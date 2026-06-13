// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Core.Proto
// Classes: 8
// Methods: 145

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Core.Proto
{
    public class Acceleration
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.Acceleration> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public object delegate_; // 0x18
        public 0x65933E60 delegateCase_; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B7CCF0
        public void get_Descriptor(){} // RVA: 0x5B7CD50
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B7CE10
        public void .ctor(){} // RVA: 0x5B7CF00 | overloaded x2
        public void Clone(){} // RVA: 0x5B7D230
        public void get_Xnnpack(){} // RVA: 0x5B7D290
        public void set_Xnnpack(){} // RVA: 0x5AE4A50
        public void get_Gpu(){} // RVA: 0x5B7D2F0
        public void set_Gpu(){} // RVA: 0x5AE4B10
        public void get_Tflite(){} // RVA: 0x5B7D350
        public void set_Tflite(){} // RVA: 0x5AE4C90
        public void get_Nnapi(){} // RVA: 0x5B7D3B0
        public void set_Nnapi(){} // RVA: 0x5A43160
        public void get_DelegateCase(){} // RVA: 0x760030
        public void ClearDelegate(){} // RVA: 0x5A43280
        public void Equals(){} // RVA: 0x5B7D470 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B7D630
        public void ToString(){} // RVA: 0x5B7D860
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B7D8B0
        public void CalculateSize(){} // RVA: 0x5B7DAB0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B7E2E0
        public void .cctor(){} // RVA: 0x5B7E550
    }

    public class AccelerationReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B7C550
        public void .cctor(){} // RVA: 0x5B7C5B0
    }

    public class BaseOptions
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.BaseOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Mediapipe.Tasks.Core.Proto.ExternalFile modelAsset_; // 0x20
        public bool UseStreamModeDefaultValue; // 0x8
        public bool useStreamMode_; // 0x28
        public Mediapipe.Tasks.Core.Proto.Acceleration acceleration_; // 0x30
        public 0x6592FA50 GpuOriginDefaultValue; // 0xC
        public 0x6592FA50 gpuOrigin_; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B7F000
        public void get_Descriptor(){} // RVA: 0x5B7F060
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B7F120
        public void .ctor(){} // RVA: 0x5B7F210 | overloaded x2
        public void Clone(){} // RVA: 0x5B7F450
        public void get_ModelAsset(){} // RVA: 0x30B0C0
        public void set_ModelAsset(){} // RVA: 0x30B0D0
        public void get_UseStreamMode(){} // RVA: 0x5B7F4B0
        public void set_UseStreamMode(){} // RVA: 0x5A77FC0
        public void get_HasUseStreamMode(){} // RVA: 0x5A5C3B0
        public void ClearUseStreamMode(){} // RVA: 0x5A5C3C0
        public void get_Acceleration(){} // RVA: 0x6374D0
        public void set_Acceleration(){} // RVA: 0x30B890
        public void get_GpuOrigin(){} // RVA: 0x5B7F520
        public void set_GpuOrigin(){} // RVA: 0x5B7F590
        public void get_HasGpuOrigin(){} // RVA: 0x5A5C450
        public void ClearGpuOrigin(){} // RVA: 0x5A5C460
        public void Equals(){} // RVA: 0x5B7F710 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B7F840
        public void ToString(){} // RVA: 0x5B7F940
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B7F990
        public void CalculateSize(){} // RVA: 0x5B7FA60
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B7FE20
        public void .cctor(){} // RVA: 0x5B7FF70
    }

    public class BaseOptionsReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B7E7A0
        public void .cctor(){} // RVA: 0x5B7E800
    }

    public class ExternalFile
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.ExternalFile> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ByteString FileContentDefaultValue; // 0x8
        public Google.Protobuf.ByteString fileContent_; // 0x18
        public string FileNameDefaultValue; // 0x10
        public string fileName_; // 0x20
        public Mediapipe.Tasks.Core.Proto.FileDescriptorMeta fileDescriptorMeta_; // 0x28
        public Mediapipe.Tasks.Core.Proto.FilePointerMeta filePointerMeta_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B80BD0
        public void get_Descriptor(){} // RVA: 0x5B80C30
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B80CF0
        public void .ctor(){} // RVA: 0x5B80DE0 | overloaded x2
        public void Clone(){} // RVA: 0x5B81220
        public void get_FileContent(){} // RVA: 0x5B81280
        public void set_FileContent(){} // RVA: 0x5B812F0
        public void get_HasFileContent(){} // RVA: 0x5B813F0
        public void ClearFileContent(){} // RVA: 0x26AD280
        public void get_FileName(){} // RVA: 0x5B814B0
        public void set_FileName(){} // RVA: 0x5B81520
        public void get_HasFileName(){} // RVA: 0x1E3EC10
        public void ClearFileName(){} // RVA: 0x5A57060
        public void get_FileDescriptorMeta(){} // RVA: 0x30B130
        public void set_FileDescriptorMeta(){} // RVA: 0x2DEE90
        public void get_FilePointerMeta(){} // RVA: 0x6374D0
        public void set_FilePointerMeta(){} // RVA: 0x30B890
        public void Equals(){} // RVA: 0x5B81680 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B81840
        public void ToString(){} // RVA: 0x5B81940
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B81990
        public void CalculateSize(){} // RVA: 0x5B81A70
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B82050
        public void .cctor(){} // RVA: 0x5B821C0
    }

    public class ExternalFileReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B801F0
        public void .cctor(){} // RVA: 0x5B80250
    }

    public class FileDescriptorMeta
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.FileDescriptorMeta> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public int FdDefaultValue; // 0x8
        public int fd_; // 0x1C
        public long LengthDefaultValue; // 0x10
        public long length_; // 0x20
        public long OffsetDefaultValue; // 0x18
        public long offset_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B82590
        public void get_Descriptor(){} // RVA: 0x5B825F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B826B0
        public void .ctor(){} // RVA: 0x5B827A0 | overloaded x2
        public void Clone(){} // RVA: 0x5B828A0
        public void get_Fd(){} // RVA: 0x5B829D0
        public void set_Fd(){} // RVA: 0x5A5C3A0
        public void get_HasFd(){} // RVA: 0x5A5C3B0
        public void ClearFd(){} // RVA: 0x5A5C3C0
        public void get_Length(){} // RVA: 0x5B82A40
        public void set_Length(){} // RVA: 0x5B82AB0
        public void get_HasLength(){} // RVA: 0x5A5C450
        public void ClearLength(){} // RVA: 0x5A5C460
        public void get_Offset(){} // RVA: 0x5B82AC0
        public void set_Offset(){} // RVA: 0x5AE1070
        public void get_HasOffset(){} // RVA: 0x5A5F650
        public void ClearOffset(){} // RVA: 0x5A5F660
        public void Equals(){} // RVA: 0x5B82C50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B82D30
        public void ToString(){} // RVA: 0x5B82DD0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B82E20
        public void CalculateSize(){} // RVA: 0x5B82EE0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B83190
        public void .cctor(){} // RVA: 0x5B83250
    }

    public class FilePointerMeta
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.FilePointerMeta> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public ulong PointerDefaultValue; // 0x8
        public ulong pointer_; // 0x20
        public long LengthDefaultValue; // 0x10
        public long length_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B834E0
        public void get_Descriptor(){} // RVA: 0x5B83540
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B83600
        public void .ctor(){} // RVA: 0x5B836F0 | overloaded x2
        public void Clone(){} // RVA: 0x5B837E0
        public void get_Pointer(){} // RVA: 0x5B83900
        public void set_Pointer(){} // RVA: 0x5B83970
        public void get_HasPointer(){} // RVA: 0x5A5C3B0
        public void ClearPointer(){} // RVA: 0x5A5C3C0
        public void get_Length(){} // RVA: 0x5B83980
        public void set_Length(){} // RVA: 0x5B839F0
        public void get_HasLength(){} // RVA: 0x5A5C450
        public void ClearLength(){} // RVA: 0x5A5C460
        public void Equals(){} // RVA: 0x5B83B00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B83BC0
        public void ToString(){} // RVA: 0x5B83C40
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B83C90
        public void CalculateSize(){} // RVA: 0x5B83D20
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B83F70
        public void .cctor(){} // RVA: 0x5B84010
    }

}