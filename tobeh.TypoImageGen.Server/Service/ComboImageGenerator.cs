using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using ImageMagick;
using Microsoft.Extensions.Options;
using tobeh.TypoImageGen;
using tobeh.TypoImageGen.Server.Config;
using tobeh.Valmar;
using tobeh.Valmar.Client.Util;

namespace tobeh.TypoImageGen.Server.Service;

public class ComboImageGenerator(
    ILogger<ComboImageGenerator> logger, 
    Sprites.SpritesClient spritesClient, 
    CachedFileProvider cachedFileProvider, 
    IOptions<ImageGeneratorConfig> _options
)
{
    public async Task<List<FileChunkMessage>> GenerateComboFromUrls(GenerateComboMessage request)
    {
        logger.LogTrace("GenerateComboFromUrls(request={request})", request);

        if (request.SpriteIds.Count == 0)
        {
            return
            [
                new FileChunkMessage { ChunkIndex = 0, Chunk = ByteString.Empty, FileType = "png", Name = "empty.png" }
            ];
        }
        
        var resultFileName = $"url-combo-{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";

        var allSprites = await spritesClient.GetAllSprites(new Empty()).ToDictionaryAsync(sprite => sprite.Id);
        var combo = request.SpriteIds.Select(id => allSprites[id]).ToList();
        var colorMap = request.ColorMaps.ToDictionary(map => map.SpriteId, map => map.HueShift);
        
        var bytesTasks = combo.Select(async sprite => new {Bytes = await cachedFileProvider.GetBytesFromUrl(sprite.Url), Sprite = sprite});
        var bytes = await Task.WhenAll(bytesTasks);
     
        IMagickImage? comboImage = null;
        foreach (var imageBytes in bytes)
        {
            using var collection = new MagickImageCollection(imageBytes.Bytes);
            var modulated = collection[0].Clone();
            
            if(colorMap.TryGetValue(imageBytes.Sprite.Id, out var hueShift))
            {
                modulated.Modulate(new Percentage(100), new Percentage(100), new Percentage(hueShift));
            }
            
            if (comboImage is not null)
            {
                comboImage.Composite(modulated, CompositeOperator.Over);
            }
            else
            {
                comboImage = modulated;
            }
        }

        if (comboImage is null) throw new Exception("No frames added");
        comboImage.Format = MagickFormat.Png;
     
        var resultBytes = comboImage.ToByteArray();
        var byteChunks = resultBytes.Chunk(_options.Value.ByteChunkKByte * 1024);
     
        var messages = byteChunks.Select((chunk, index) => new FileChunkMessage
        {
            ChunkIndex = index,
            Chunk = ByteString.CopyFrom(chunk),
            Name = resultFileName,
            FileType = "png"
        }).ToList();

        return messages;
    }
}