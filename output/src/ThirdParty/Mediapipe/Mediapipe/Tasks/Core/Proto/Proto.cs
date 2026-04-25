// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Core.Proto
// Classes: 8
// Methods: 145

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Core.Proto
{
    public class Acceleration : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.Acceleration> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public object pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public 0x6B217CA8 Xnnpack; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC8314220
        public void get_Descriptor(){} // RVA: 0x7FFAC8314280
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8314340
        public void .ctor(){} // RVA: 0x7FFAC8314430 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8314760
        public void get_Xnnpack(){} // RVA: 0x7FFAC83147C0
        public void set_Xnnpack(){} // RVA: 0x7FFAC827BF60
        public void get_Gpu(){} // RVA: 0x7FFAC8314820
        public void set_Gpu(){} // RVA: 0x7FFAC827C020
        public void get_Tflite(){} // RVA: 0x7FFAC8314880
        public void set_Tflite(){} // RVA: 0x7FFAC827C1A0
        public void get_Nnapi(){} // RVA: 0x7FFAC83148E0
        public void set_Nnapi(){} // RVA: 0x7FFAC81DA580
        public void get_DelegateCase(){} // RVA: 0x7FFAC30DBBE0
        public void ClearDelegate(){} // RVA: 0x7FFAC81DA6A0
        public void Equals(){} // RVA: 0x7FFAC83149A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8314B60
        public void ToString(){} // RVA: 0x7FFAC8314D90
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8314DE0
        public void CalculateSize(){} // RVA: 0x7FFAC8314FE0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8315810
        public void .cctor(){} // RVA: 0x7FFAC8315A80
    }

    public class AccelerationReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC8313A80
        public void .cctor(){} // RVA: 0x7FFAC8313AE0
    }

    public class BaseOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.BaseOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Mediapipe.Tasks.Core.Proto.ExternalFile ModelAsset; // 0x20
        public bool UseStreamMode; // 0x8
        public bool HasUseStreamMode; // 0x28
        public Mediapipe.Tasks.Core.Proto.Acceleration Acceleration; // 0x30
        public 0x6B213898 GpuOrigin; // 0xC
        public 0x6B213898 HasGpuOrigin; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC8316530
        public void get_Descriptor(){} // RVA: 0x7FFAC8316590
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8316650
        public void .ctor(){} // RVA: 0x7FFAC8316740 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8316980
        public void get_ModelAsset(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ModelAsset(){} // RVA: 0x7FFAC2F4F0D0
        public void get_UseStreamMode(){} // RVA: 0x7FFAC83169E0
        public void set_UseStreamMode(){} // RVA: 0x7FFAC820F3E0
        public void get_HasUseStreamMode(){} // RVA: 0x7FFAC81F3770
        public void ClearUseStreamMode(){} // RVA: 0x7FFAC81F3780
        public void get_Acceleration(){} // RVA: 0x7FFAC31D95E0
        public void set_Acceleration(){} // RVA: 0x7FFAC2F4F890
        public void get_GpuOrigin(){} // RVA: 0x7FFAC8316A50
        public void set_GpuOrigin(){} // RVA: 0x7FFAC8316AC0
        public void get_HasGpuOrigin(){} // RVA: 0x7FFAC81F3810
        public void ClearGpuOrigin(){} // RVA: 0x7FFAC81F3820
        public void Equals(){} // RVA: 0x7FFAC8316C40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8316D70
        public void ToString(){} // RVA: 0x7FFAC8316E70
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8316EC0
        public void CalculateSize(){} // RVA: 0x7FFAC8316F90
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8317350
        public void .cctor(){} // RVA: 0x7FFAC83174A0
    }

    public class BaseOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC8315CD0
        public void .cctor(){} // RVA: 0x7FFAC8315D30
    }

    public class ExternalFile : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.ExternalFile> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.ByteString pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.ByteString FileContent; // 0x18
        public string HasFileContent; // 0x10
        public string FileName; // 0x20
        public Mediapipe.Tasks.Core.Proto.FileDescriptorMeta HasFileName; // 0x28
        public Mediapipe.Tasks.Core.Proto.FilePointerMeta FileDescriptorMeta; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC8318100
        public void get_Descriptor(){} // RVA: 0x7FFAC8318160
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8318220
        public void .ctor(){} // RVA: 0x7FFAC8318310 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8318750
        public void get_FileContent(){} // RVA: 0x7FFAC83187B0
        public void set_FileContent(){} // RVA: 0x7FFAC8318820
        public void get_HasFileContent(){} // RVA: 0x7FFAC8318920
        public void ClearFileContent(){} // RVA: 0x7FFAC515CC20
        public void get_FileName(){} // RVA: 0x7FFAC83189E0
        public void set_FileName(){} // RVA: 0x7FFAC8318A50
        public void get_HasFileName(){} // RVA: 0x7FFAC495C6A0
        public void ClearFileName(){} // RVA: 0x7FFAC81EE480
        public void get_FileDescriptorMeta(){} // RVA: 0x7FFAC2F4F130
        public void set_FileDescriptorMeta(){} // RVA: 0x7FFAC2F22E90
        public void get_FilePointerMeta(){} // RVA: 0x7FFAC31D95E0
        public void set_FilePointerMeta(){} // RVA: 0x7FFAC2F4F890
        public void Equals(){} // RVA: 0x7FFAC8318BB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8318D70
        public void ToString(){} // RVA: 0x7FFAC8318E70
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8318EC0
        public void CalculateSize(){} // RVA: 0x7FFAC8318FA0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8319580
        public void .cctor(){} // RVA: 0x7FFAC83196F0
    }

    public class ExternalFileReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC8317720
        public void .cctor(){} // RVA: 0x7FFAC8317780
    }

    public class FileDescriptorMeta : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.FileDescriptorMeta> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int Fd; // 0x8
        public int HasFd; // 0x1C
        public long Length; // 0x10
        public long HasLength; // 0x20
        public long Offset; // 0x18
        public long HasOffset; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC8319AC0
        public void get_Descriptor(){} // RVA: 0x7FFAC8319B20
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8319BE0
        public void .ctor(){} // RVA: 0x7FFAC8319CD0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8319DD0
        public void get_Fd(){} // RVA: 0x7FFAC8319F00
        public void set_Fd(){} // RVA: 0x7FFAC81F3760
        public void get_HasFd(){} // RVA: 0x7FFAC81F3770
        public void ClearFd(){} // RVA: 0x7FFAC81F3780
        public void get_Length(){} // RVA: 0x7FFAC8319F70
        public void set_Length(){} // RVA: 0x7FFAC8319FE0
        public void get_HasLength(){} // RVA: 0x7FFAC81F3810
        public void ClearLength(){} // RVA: 0x7FFAC81F3820
        public void get_Offset(){} // RVA: 0x7FFAC8319FF0
        public void set_Offset(){} // RVA: 0x7FFAC8278580
        public void get_HasOffset(){} // RVA: 0x7FFAC81F6A10
        public void ClearOffset(){} // RVA: 0x7FFAC81F6A20
        public void Equals(){} // RVA: 0x7FFAC831A180 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC831A260
        public void ToString(){} // RVA: 0x7FFAC831A300
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC831A350
        public void CalculateSize(){} // RVA: 0x7FFAC831A410
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC831A6C0
        public void .cctor(){} // RVA: 0x7FFAC831A780
    }

    public class FilePointerMeta : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Core.Proto.FilePointerMeta> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public ulong Pointer; // 0x8
        public ulong HasPointer; // 0x20
        public long Length; // 0x10
        public long HasLength; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC831AA10
        public void get_Descriptor(){} // RVA: 0x7FFAC831AA70
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC831AB30
        public void .ctor(){} // RVA: 0x7FFAC831AC20 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC831AD10
        public void get_Pointer(){} // RVA: 0x7FFAC831AE30
        public void set_Pointer(){} // RVA: 0x7FFAC831AEA0
        public void get_HasPointer(){} // RVA: 0x7FFAC81F3770
        public void ClearPointer(){} // RVA: 0x7FFAC81F3780
        public void get_Length(){} // RVA: 0x7FFAC831AEB0
        public void set_Length(){} // RVA: 0x7FFAC831AF20
        public void get_HasLength(){} // RVA: 0x7FFAC81F3810
        public void ClearLength(){} // RVA: 0x7FFAC81F3820
        public void Equals(){} // RVA: 0x7FFAC831B030 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC831B0F0
        public void ToString(){} // RVA: 0x7FFAC831B170
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC831B1C0
        public void CalculateSize(){} // RVA: 0x7FFAC831B250
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC831B4A0
        public void .cctor(){} // RVA: 0x7FFAC831B540
    }

}