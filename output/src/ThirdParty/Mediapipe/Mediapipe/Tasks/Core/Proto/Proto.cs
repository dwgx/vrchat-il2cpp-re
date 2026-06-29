// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Core.Proto
// Classes: 8
// Methods: 130

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Core.Proto
{
    public class Acceleration : Object
    {
        public object _parser;
        public object _unknownFields;
        public object delegate_;
        public object delegateCase_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65F6B20
        public void get_Descriptor(){} // RVA: 0x65F6B80
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65F6C40
        public void .ctor(){} // RVA: 0x65F6D30
        public void Clone(){} // RVA: 0x65F7060
        public void get_Xnnpack(){} // RVA: 0x65F70C0
        public void set_Xnnpack(){} // RVA: 0x655F290
        public void get_Gpu(){} // RVA: 0x65F7120
        public void set_Gpu(){} // RVA: 0x655F350
        public void get_Tflite(){} // RVA: 0x65F7180
        public void set_Tflite(){} // RVA: 0x655F4D0
        public void get_Nnapi(){} // RVA: 0x65F71E0
        public void set_Nnapi(){} // RVA: 0x64BD3E0
        public void get_DelegateCase(){} // RVA: 0xFEAE90
        public void ClearDelegate(){} // RVA: 0x64BD500
        public void Equals(){} // RVA: 0x65F72A0
        public void GetHashCode(){} // RVA: 0x65F7460
        public void ToString(){} // RVA: 0x65F7690
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65F76E0
        public void CalculateSize(){} // RVA: 0x65F78E0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65F8110
        public void .cctor(){} // RVA: 0x65F8380
    }

    public class AccelerationReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x65F63B0
        public void .cctor(){} // RVA: 0x65F6410
    }

    public class BaseOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object modelAsset_;
        public object UseStreamModeDefaultValue;
        public object useStreamMode_;
        public object acceleration_;
        public object GpuOriginDefaultValue;
        public object gpuOrigin_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65F8DF0
        public void get_Descriptor(){} // RVA: 0x65F8E50
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65F8F10
        public void .ctor(){} // RVA: 0x65F9000
        public void Clone(){} // RVA: 0x65F9240
        public void get_ModelAsset(){} // RVA: 0xB700F0
        public void set_ModelAsset(){} // RVA: 0xB70100
        public void get_UseStreamMode(){} // RVA: 0x65F92A0
        public void set_UseStreamMode(){} // RVA: 0x64F2300
        public void get_HasUseStreamMode(){} // RVA: 0x64D65D0
        public void ClearUseStreamMode(){} // RVA: 0x64D65E0
        public void get_Acceleration(){} // RVA: 0xD33E60
        public void set_Acceleration(){} // RVA: 0xB708C0
        public void get_GpuOrigin(){} // RVA: 0x65F9310
        public void set_GpuOrigin(){} // RVA: 0x65F9380
        public void get_HasGpuOrigin(){} // RVA: 0x64D6670
        public void ClearGpuOrigin(){} // RVA: 0x64D6680
        public void Equals(){} // RVA: 0x65F9500
        public void GetHashCode(){} // RVA: 0x65F9630
        public void ToString(){} // RVA: 0x65F9710
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65F9760
        public void CalculateSize(){} // RVA: 0x65F9830
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65F9BF0
        public void .cctor(){} // RVA: 0x65F9D40
    }

    public class BaseOptionsReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x65F85D0
        public void .cctor(){} // RVA: 0x65F8630
    }

    public class ExternalFile : Object
    {
        public object _parser;
        public object _unknownFields;
        public object FileContentDefaultValue;
        public object fileContent_;
        public object FileNameDefaultValue;
        public object fileName_;
        public object fileDescriptorMeta_;
        public object filePointerMeta_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65FA930
        public void get_Descriptor(){} // RVA: 0x65FA990
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65FAA50
        public void .ctor(){} // RVA: 0x65FAB40
        public void Clone(){} // RVA: 0x65FAF90
        public void get_FileContent(){} // RVA: 0x65FAFF0
        public void set_FileContent(){} // RVA: 0x65FB060
        public void get_HasFileContent(){} // RVA: 0x65FB160
        public void ClearFileContent(){} // RVA: 0x30FBB60
        public void get_FileName(){} // RVA: 0x65FB220
        public void set_FileName(){} // RVA: 0x65FB290
        public void get_HasFileName(){} // RVA: 0x26C1120
        public void ClearFileName(){} // RVA: 0x64D1270
        public void get_FileDescriptorMeta(){} // RVA: 0xB70160
        public void set_FileDescriptorMeta(){} // RVA: 0xB44DC0
        public void get_FilePointerMeta(){} // RVA: 0xD33E60
        public void set_FilePointerMeta(){} // RVA: 0xB708C0
        public void Equals(){} // RVA: 0x65FB3F0
        public void GetHashCode(){} // RVA: 0x65FB5B0
        public void ToString(){} // RVA: 0x65FB6B0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65FB700
        public void CalculateSize(){} // RVA: 0x65FB7E0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65FBDC0
        public void .cctor(){} // RVA: 0x65FBF30
    }

    public class ExternalFileReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x65F9FC0
        public void .cctor(){} // RVA: 0x65FA020
    }

    public class FileDescriptorMeta : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object FdDefaultValue;
        public object fd_;
        public object LengthDefaultValue;
        public object length_;
        public object OffsetDefaultValue;
        public object offset_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65FC300
        public void get_Descriptor(){} // RVA: 0x65FC360
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65FC420
        public void .ctor(){} // RVA: 0x65FC510
        public void Clone(){} // RVA: 0x65FC610
        public void get_Fd(){} // RVA: 0x65FC740
        public void set_Fd(){} // RVA: 0x64D65C0
        public void get_HasFd(){} // RVA: 0x64D65D0
        public void ClearFd(){} // RVA: 0x64D65E0
        public void get_Length(){} // RVA: 0x65FC7B0
        public void set_Length(){} // RVA: 0x65FC820
        public void get_HasLength(){} // RVA: 0x64D6670
        public void ClearLength(){} // RVA: 0x64D6680
        public void get_Offset(){} // RVA: 0x65FC830
        public void set_Offset(){} // RVA: 0x655BA10
        public void get_HasOffset(){} // RVA: 0x64D9870
        public void ClearOffset(){} // RVA: 0x64D9880
        public void Equals(){} // RVA: 0x65FC9C0
        public void GetHashCode(){} // RVA: 0x65FCAA0
        public void ToString(){} // RVA: 0x65FCB40
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65FCB90
        public void CalculateSize(){} // RVA: 0x65FCC50
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65FCF00
        public void .cctor(){} // RVA: 0x65FCFC0
    }

    public class FilePointerMeta : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object PointerDefaultValue;
        public object pointer_;
        public object LengthDefaultValue;
        public object length_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65FD250
        public void get_Descriptor(){} // RVA: 0x65FD2B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65FD370
        public void .ctor(){} // RVA: 0x65FD460
        public void Clone(){} // RVA: 0x65FD550
        public void get_Pointer(){} // RVA: 0x65FD670
        public void set_Pointer(){} // RVA: 0x65FD6E0
        public void get_HasPointer(){} // RVA: 0x64D65D0
        public void ClearPointer(){} // RVA: 0x64D65E0
        public void get_Length(){} // RVA: 0x65FD6F0
        public void set_Length(){} // RVA: 0x65FD760
        public void get_HasLength(){} // RVA: 0x64D6670
        public void ClearLength(){} // RVA: 0x64D6680
        public void Equals(){} // RVA: 0x65FD870
        public void GetHashCode(){} // RVA: 0x65FD930
        public void ToString(){} // RVA: 0x65FD9B0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65FDA00
        public void CalculateSize(){} // RVA: 0x65FDA90
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65FDCE0
        public void .cctor(){} // RVA: 0x65FDD80
    }

}