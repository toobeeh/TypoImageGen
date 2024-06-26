// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: staticFiles.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace tobeh.TypoContentService {

  /// <summary>Holder for reflection information generated from staticFiles.proto</summary>
  public static partial class StaticFilesReflection {

    #region Descriptor
    /// <summary>File descriptor for staticFiles.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StaticFilesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFzdGF0aWNGaWxlcy5wcm90bxILc3RhdGljRmlsZXMaDWNvbnRlbnQucHJv",
            "dG8aG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90byJLChZGaWxlSW5mb3Jt",
            "YXRpb25NZXNzYWdlEgwKBG5hbWUYASABKAkSIwoEdHlwZRgCIAEoDjIVLnN0",
            "YXRpY0ZpbGVzLkZpbGVUeXBlIogBCg5BZGRGaWxlTWVzc2FnZRIuCglmaWxl",
            "Q2h1bmsYASABKAsyGS5jb250ZW50LkZpbGVDaHVua01lc3NhZ2VIABI+Cg9m",
            "aWxlSW5mb3JtYXRpb24YAiABKAsyIy5zdGF0aWNGaWxlcy5GaWxlSW5mb3Jt",
            "YXRpb25NZXNzYWdlSABCBgoEZGF0YSo8CghGaWxlVHlwZRIKCgZTcHJpdGUQ",
            "ABIJCgVTY2VuZRABEg8KC0V2ZW50U3ByaXRlEAISCAoERHJvcBADMk8KC1N0",
            "YXRpY0ZpbGVzEkAKB0FkZEZpbGUSGy5zdGF0aWNGaWxlcy5BZGRGaWxlTWVz",
            "c2FnZRoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSgBQhuqAhh0b2JlaC5UeXBv",
            "Q29udGVudFNlcnZpY2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::tobeh.TypoContentService.ContentReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::tobeh.TypoContentService.FileType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::tobeh.TypoContentService.FileInformationMessage), global::tobeh.TypoContentService.FileInformationMessage.Parser, new[]{ "Name", "Type" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::tobeh.TypoContentService.AddFileMessage), global::tobeh.TypoContentService.AddFileMessage.Parser, new[]{ "FileChunk", "FileInformation" }, new[]{ "Data" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum FileType {
    [pbr::OriginalName("Sprite")] Sprite = 0,
    [pbr::OriginalName("Scene")] Scene = 1,
    [pbr::OriginalName("EventSprite")] EventSprite = 2,
    [pbr::OriginalName("Drop")] Drop = 3,
  }

  #endregion

  #region Messages
  public sealed partial class FileInformationMessage : pb::IMessage<FileInformationMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FileInformationMessage> _parser = new pb::MessageParser<FileInformationMessage>(() => new FileInformationMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FileInformationMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::tobeh.TypoContentService.StaticFilesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FileInformationMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FileInformationMessage(FileInformationMessage other) : this() {
      name_ = other.name_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FileInformationMessage Clone() {
      return new FileInformationMessage(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::tobeh.TypoContentService.FileType type_ = global::tobeh.TypoContentService.FileType.Sprite;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::tobeh.TypoContentService.FileType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FileInformationMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FileInformationMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type != global::tobeh.TypoContentService.FileType.Sprite) hash ^= Type.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Type != global::tobeh.TypoContentService.FileType.Sprite) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Type != global::tobeh.TypoContentService.FileType.Sprite) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Type != global::tobeh.TypoContentService.FileType.Sprite) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FileInformationMessage other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Type != global::tobeh.TypoContentService.FileType.Sprite) {
        Type = other.Type;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::tobeh.TypoContentService.FileType) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::tobeh.TypoContentService.FileType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AddFileMessage : pb::IMessage<AddFileMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddFileMessage> _parser = new pb::MessageParser<AddFileMessage>(() => new AddFileMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AddFileMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::tobeh.TypoContentService.StaticFilesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddFileMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddFileMessage(AddFileMessage other) : this() {
      switch (other.DataCase) {
        case DataOneofCase.FileChunk:
          FileChunk = other.FileChunk.Clone();
          break;
        case DataOneofCase.FileInformation:
          FileInformation = other.FileInformation.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddFileMessage Clone() {
      return new AddFileMessage(this);
    }

    /// <summary>Field number for the "fileChunk" field.</summary>
    public const int FileChunkFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::tobeh.TypoContentService.FileChunkMessage FileChunk {
      get { return dataCase_ == DataOneofCase.FileChunk ? (global::tobeh.TypoContentService.FileChunkMessage) data_ : null; }
      set {
        data_ = value;
        dataCase_ = value == null ? DataOneofCase.None : DataOneofCase.FileChunk;
      }
    }

    /// <summary>Field number for the "fileInformation" field.</summary>
    public const int FileInformationFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::tobeh.TypoContentService.FileInformationMessage FileInformation {
      get { return dataCase_ == DataOneofCase.FileInformation ? (global::tobeh.TypoContentService.FileInformationMessage) data_ : null; }
      set {
        data_ = value;
        dataCase_ = value == null ? DataOneofCase.None : DataOneofCase.FileInformation;
      }
    }

    private object data_;
    /// <summary>Enum of possible cases for the "data" oneof.</summary>
    public enum DataOneofCase {
      None = 0,
      FileChunk = 1,
      FileInformation = 2,
    }
    private DataOneofCase dataCase_ = DataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataOneofCase DataCase {
      get { return dataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearData() {
      dataCase_ = DataOneofCase.None;
      data_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AddFileMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AddFileMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FileChunk, other.FileChunk)) return false;
      if (!object.Equals(FileInformation, other.FileInformation)) return false;
      if (DataCase != other.DataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (dataCase_ == DataOneofCase.FileChunk) hash ^= FileChunk.GetHashCode();
      if (dataCase_ == DataOneofCase.FileInformation) hash ^= FileInformation.GetHashCode();
      hash ^= (int) dataCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (dataCase_ == DataOneofCase.FileChunk) {
        output.WriteRawTag(10);
        output.WriteMessage(FileChunk);
      }
      if (dataCase_ == DataOneofCase.FileInformation) {
        output.WriteRawTag(18);
        output.WriteMessage(FileInformation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (dataCase_ == DataOneofCase.FileChunk) {
        output.WriteRawTag(10);
        output.WriteMessage(FileChunk);
      }
      if (dataCase_ == DataOneofCase.FileInformation) {
        output.WriteRawTag(18);
        output.WriteMessage(FileInformation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (dataCase_ == DataOneofCase.FileChunk) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FileChunk);
      }
      if (dataCase_ == DataOneofCase.FileInformation) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FileInformation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AddFileMessage other) {
      if (other == null) {
        return;
      }
      switch (other.DataCase) {
        case DataOneofCase.FileChunk:
          if (FileChunk == null) {
            FileChunk = new global::tobeh.TypoContentService.FileChunkMessage();
          }
          FileChunk.MergeFrom(other.FileChunk);
          break;
        case DataOneofCase.FileInformation:
          if (FileInformation == null) {
            FileInformation = new global::tobeh.TypoContentService.FileInformationMessage();
          }
          FileInformation.MergeFrom(other.FileInformation);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            global::tobeh.TypoContentService.FileChunkMessage subBuilder = new global::tobeh.TypoContentService.FileChunkMessage();
            if (dataCase_ == DataOneofCase.FileChunk) {
              subBuilder.MergeFrom(FileChunk);
            }
            input.ReadMessage(subBuilder);
            FileChunk = subBuilder;
            break;
          }
          case 18: {
            global::tobeh.TypoContentService.FileInformationMessage subBuilder = new global::tobeh.TypoContentService.FileInformationMessage();
            if (dataCase_ == DataOneofCase.FileInformation) {
              subBuilder.MergeFrom(FileInformation);
            }
            input.ReadMessage(subBuilder);
            FileInformation = subBuilder;
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            global::tobeh.TypoContentService.FileChunkMessage subBuilder = new global::tobeh.TypoContentService.FileChunkMessage();
            if (dataCase_ == DataOneofCase.FileChunk) {
              subBuilder.MergeFrom(FileChunk);
            }
            input.ReadMessage(subBuilder);
            FileChunk = subBuilder;
            break;
          }
          case 18: {
            global::tobeh.TypoContentService.FileInformationMessage subBuilder = new global::tobeh.TypoContentService.FileInformationMessage();
            if (dataCase_ == DataOneofCase.FileInformation) {
              subBuilder.MergeFrom(FileInformation);
            }
            input.ReadMessage(subBuilder);
            FileInformation = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code