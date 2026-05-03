// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Core.Proto
// Classes: 8
// Methods: 145

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Core.Proto
{
    public class Acceleration : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.Acceleration> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public object delegate_; // 0x18
        public 0x6661156C delegateCase_; // 0x20
        public object field_4; // 0x307
        public object field_5; // 0x308
        public object field_6; // 0x309
        public object field_7; // 0x30A

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866BDB20
        public void get_Descriptor(){} // RVA: 0x7FFE866BDB80
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866BDC40
        public void .ctor(){} // RVA: 0x7FFE866BDD30 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866BE060
        public void get_Xnnpack(){} // RVA: 0x7FFE866BE0C0
        public void set_Xnnpack(){} // RVA: 0x7FFE86625880
        public void get_Gpu(){} // RVA: 0x7FFE866BE120
        public void set_Gpu(){} // RVA: 0x7FFE86625940
        public void get_Tflite(){} // RVA: 0x7FFE866BE180
        public void set_Tflite(){} // RVA: 0x7FFE86625AC0
        public void get_Nnapi(){} // RVA: 0x7FFE866BE1E0
        public void set_Nnapi(){} // RVA: 0x7FFE86583EC0
        public void get_DelegateCase(){} // RVA: 0x7FFE8151D690
        public void ClearDelegate(){} // RVA: 0x7FFE86583FE0
        public void Equals(){} // RVA: 0x7FFE866BE2A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866BE460
        public void ToString(){} // RVA: 0x7FFE866BE690
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866BE6E0
        public void CalculateSize(){} // RVA: 0x7FFE866BE8E0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866BF110
        public void .cctor(){} // RVA: 0x7FFE866BF380
    }

    public class AccelerationReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866BD380
        public void .cctor(){} // RVA: 0x7FFE866BD3E0
    }

    public class BaseOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.BaseOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Mediapipe.Tasks.Core.Proto.ExternalFile modelAsset_; // 0x20
        public bool UseStreamModeDefaultValue; // 0x8
        public bool useStreamMode_; // 0x28
        public Mediapipe.Tasks.Core.Proto.Acceleration acceleration_; // 0x30
        public 0x6660D15C GpuOriginDefaultValue; // 0xC
        public 0x6660D15C gpuOrigin_; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866BFE30
        public void get_Descriptor(){} // RVA: 0x7FFE866BFE90
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866BFF50
        public void .ctor(){} // RVA: 0x7FFE866C0040 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866C0280
        public void get_ModelAsset(){} // RVA: 0x7FFE811290C0
        public void set_ModelAsset(){} // RVA: 0x7FFE811290D0
        public void get_UseStreamMode(){} // RVA: 0x7FFE866C02E0
        public void set_UseStreamMode(){} // RVA: 0x7FFE865B8D20
        public void get_HasUseStreamMode(){} // RVA: 0x7FFE8659D0B0
        public void ClearUseStreamMode(){} // RVA: 0x7FFE8659D0C0
        public void get_Acceleration(){} // RVA: 0x7FFE8144E200
        public void set_Acceleration(){} // RVA: 0x7FFE81129890
        public void get_GpuOrigin(){} // RVA: 0x7FFE866C0350
        public void set_GpuOrigin(){} // RVA: 0x7FFE866C03C0
        public void get_HasGpuOrigin(){} // RVA: 0x7FFE8659D150
        public void ClearGpuOrigin(){} // RVA: 0x7FFE8659D160
        public void Equals(){} // RVA: 0x7FFE866C0540 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866C0670
        public void ToString(){} // RVA: 0x7FFE866C0770
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866C07C0
        public void CalculateSize(){} // RVA: 0x7FFE866C0890
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866C0C50
        public void .cctor(){} // RVA: 0x7FFE866C0DA0
    }

    public class BaseOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866BF5D0
        public void .cctor(){} // RVA: 0x7FFE866BF630
    }

    public class ExternalFile : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.ExternalFile> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ByteString FileContentDefaultValue; // 0x8
        public Google.Protobuf.ByteString fileContent_; // 0x18
        public string FileNameDefaultValue; // 0x10
        public string fileName_; // 0x20
        public Mediapipe.Tasks.Core.Proto.FileDescriptorMeta fileDescriptorMeta_; // 0x28
        public Mediapipe.Tasks.Core.Proto.FilePointerMeta filePointerMeta_; // 0x30
        public object field_8; // 0x31A

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866C1A00
        public void get_Descriptor(){} // RVA: 0x7FFE866C1A60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866C1B20
        public void .ctor(){} // RVA: 0x7FFE866C1C10 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866C2050
        public void get_FileContent(){} // RVA: 0x7FFE866C20B0
        public void set_FileContent(){} // RVA: 0x7FFE866C2120
        public void get_HasFileContent(){} // RVA: 0x7FFE866C2220
        public void ClearFileContent(){} // RVA: 0x7FFE8340D8D0
        public void get_FileName(){} // RVA: 0x7FFE866C22E0
        public void set_FileName(){} // RVA: 0x7FFE866C2350
        public void get_HasFileName(){} // RVA: 0x7FFE82BC81D0
        public void ClearFileName(){} // RVA: 0x7FFE86597DC0
        public void get_FileDescriptorMeta(){} // RVA: 0x7FFE81129130
        public void set_FileDescriptorMeta(){} // RVA: 0x7FFE810FCE90
        public void get_FilePointerMeta(){} // RVA: 0x7FFE8144E200
        public void set_FilePointerMeta(){} // RVA: 0x7FFE81129890
        public void Equals(){} // RVA: 0x7FFE866C24B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866C2670
        public void ToString(){} // RVA: 0x7FFE866C2770
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866C27C0
        public void CalculateSize(){} // RVA: 0x7FFE866C28A0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866C2E80
        public void .cctor(){} // RVA: 0x7FFE866C2FF0
    }

    public class ExternalFileReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866C1020
        public void .cctor(){} // RVA: 0x7FFE866C1080
    }

    public class FileDescriptorMeta : Object
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
        public void get_Parser(){} // RVA: 0x7FFE866C33C0
        public void get_Descriptor(){} // RVA: 0x7FFE866C3420
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866C34E0
        public void .ctor(){} // RVA: 0x7FFE866C35D0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866C36D0
        public void get_Fd(){} // RVA: 0x7FFE866C3800
        public void set_Fd(){} // RVA: 0x7FFE8659D0A0
        public void get_HasFd(){} // RVA: 0x7FFE8659D0B0
        public void ClearFd(){} // RVA: 0x7FFE8659D0C0
        public void get_Length(){} // RVA: 0x7FFE866C3870
        public void set_Length(){} // RVA: 0x7FFE866C38E0
        public void get_HasLength(){} // RVA: 0x7FFE8659D150
        public void ClearLength(){} // RVA: 0x7FFE8659D160
        public void get_Offset(){} // RVA: 0x7FFE866C38F0
        public void set_Offset(){} // RVA: 0x7FFE86621EA0
        public void get_HasOffset(){} // RVA: 0x7FFE865A0350
        public void ClearOffset(){} // RVA: 0x7FFE865A0360
        public void Equals(){} // RVA: 0x7FFE866C3A80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866C3B60
        public void ToString(){} // RVA: 0x7FFE866C3C00
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866C3C50
        public void CalculateSize(){} // RVA: 0x7FFE866C3D10
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866C3FC0
        public void .cctor(){} // RVA: 0x7FFE866C4080
    }

    public class FilePointerMeta : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.FilePointerMeta> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public ulong PointerDefaultValue; // 0x8
        public ulong pointer_; // 0x20
        public long LengthDefaultValue; // 0x10
        public long length_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866C4310
        public void get_Descriptor(){} // RVA: 0x7FFE866C4370
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866C4430
        public void .ctor(){} // RVA: 0x7FFE866C4520 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866C4610
        public void get_Pointer(){} // RVA: 0x7FFE866C4730
        public void set_Pointer(){} // RVA: 0x7FFE866C47A0
        public void get_HasPointer(){} // RVA: 0x7FFE8659D0B0
        public void ClearPointer(){} // RVA: 0x7FFE8659D0C0
        public void get_Length(){} // RVA: 0x7FFE866C47B0
        public void set_Length(){} // RVA: 0x7FFE866C4820
        public void get_HasLength(){} // RVA: 0x7FFE8659D150
        public void ClearLength(){} // RVA: 0x7FFE8659D160
        public void Equals(){} // RVA: 0x7FFE866C4930 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866C49F0
        public void ToString(){} // RVA: 0x7FFE866C4A70
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866C4AC0
        public void CalculateSize(){} // RVA: 0x7FFE866C4B50
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866C4DA0
        public void .cctor(){} // RVA: 0x7FFE866C4E40
    }

}