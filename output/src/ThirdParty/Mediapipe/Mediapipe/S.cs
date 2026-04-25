// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 74

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class SafeNativeMethods : Object
    {
        // ── Methods ──
        public void absl_Status__ok(){} // RVA: 0x7FFAC8273C10
        public void absl_Status__raw_code(){} // RVA: 0x7FFAC8273C90
        public void mp_ImageFrame__Format(){} // RVA: 0x7FFAC8273D10
        public void mp_ImageFrame__Width(){} // RVA: 0x7FFAC8273D90
        public void mp_ImageFrame__Height(){} // RVA: 0x7FFAC8273E10
        public void mp_ImageFrame__WidthStep(){} // RVA: 0x7FFAC8273E90
        public void mp_ImageFrame__MutablePixelData(){} // RVA: 0x7FFAC8273F10
        public void mp_Image__width(){} // RVA: 0x7FFAC8273F90
        public void mp_Image__height(){} // RVA: 0x7FFAC8274010
        public void mp_Image__step(){} // RVA: 0x7FFAC8274090
        public void mp_Image__image_format(){} // RVA: 0x7FFAC8274110
        public void mp_PixelWriteLock__Pixels(){} // RVA: 0x7FFAC8274190
        public void mp_Packet__IsEmpty(){} // RVA: 0x7FFAC8274210
        public void mp_Packet__TimestampMicroseconds(){} // RVA: 0x7FFAC8274290
        public void mp_GlCalculatorHelper__GetGlContext(){} // RVA: 0x7FFAC8274310
        public void mp_SharedGlContext__get(){} // RVA: 0x7FFAC8274390
        public void mp_GlSyncToken__get(){} // RVA: 0x7FFAC8274410
        public void mp_SharedGpuResources__get(){} // RVA: 0x7FFAC8274490
        public void mp__SetCustomGlobalResourceProvider__P(){} // RVA: 0x7FFAC8274510
        public void mp__SetCustomGlobalPathResolver__P(){} // RVA: 0x7FFAC82745A0
    }

    public class SerializedProto : ValueType
    {
        public UIntPtr _str; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC826C150
        public void Deserialize(){} // RVA: 0x7FFAC2E8DC40
        public void WriteTo(){} // RVA: 0x7FFAC2E8DC40
    }

    public class SerializedProtoVector : ValueType
    {
        public UIntPtr _data; // 0x10
        public int _size; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC826C1B0
        public void Deserialize(){} // RVA: 0x7FFAC2C79B30
        public void WriteTo(){} // RVA: 0x7FFAC2C637A0
    }

    public class SharedPtrHandle : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC66E6D30
        public void Get(){} // RVA: 0x7FFAC2C58E90
    }

    public class Status : MpResourceHandle
    {
        public System.Nullable`1<bool> _ok; // 0x20
        public System.Nullable`1<int> _rawCode; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC66E6D30
        public void DeleteMpPtr(){} // RVA: 0x7FFAC826FE90
        public void UnsafeAssertOk(){} // RVA: 0x7FFAC826FEF0
        public void AssertOk(){} // RVA: 0x7FFAC8270010
        public void Ok(){} // RVA: 0x7FFAC8270130
        public void Code(){} // RVA: 0x7FFAC82701F0
        public void RawCode(){} // RVA: 0x7FFAC82701F0
        public void ToString(){} // RVA: 0x7FFAC8270320
    }

    public class StatusArgs : ValueType
    {
        public 0x6B20F9B0 _code; // 0x10
        public UIntPtr _message; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC826FC60
        public void Ok(){} // RVA: 0x7FFAC826FCD0
        public void InvalidArgument(){} // RVA: 0x7FFAC826FD40
        public void NotFound(){} // RVA: 0x7FFAC826FDB0
        public void Internal(){} // RVA: 0x7FFAC826FE20
    }

    public class StatusHandlerConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.StatusHandlerConfig> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public string StatusHandler; // 0x18
        public Google.Protobuf.FieldCodec`1<string> HasStatusHandler; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<string> InputSidePacket; // 0x20
        public Google.Protobuf.FieldCodec`1<string> ExternalInput; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<string> Options; // 0x28
        public Mediapipe.MediaPipeOptions options_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82C1720
        public void get_Descriptor(){} // RVA: 0x7FFAC82C1780
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82C1840
        public void .ctor(){} // RVA: 0x7FFAC82C1A70 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82C1D40
        public void get_StatusHandler(){} // RVA: 0x7FFAC82C1DA0
        public void set_StatusHandler(){} // RVA: 0x7FFAC82C1E10
        public void get_HasStatusHandler(){} // RVA: 0x7FFAC4860B40
        public void ClearStatusHandler(){} // RVA: 0x7FFAC515CC20
        public void get_InputSidePacket(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ExternalInput(){} // RVA: 0x7FFAC2F4F130
        public void get_Options(){} // RVA: 0x7FFAC31D95E0
        public void set_Options(){} // RVA: 0x7FFAC2F4F890
        public void Equals(){} // RVA: 0x7FFAC82C1F70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82C20F0
        public void ToString(){} // RVA: 0x7FFAC82C21E0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82C2230
        public void CalculateSize(){} // RVA: 0x7FFAC82C2390
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82C2720
        public void .cctor(){} // RVA: 0x7FFAC82C2900
    }

    public class StatusHandlerReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82C1070
        public void .cctor(){} // RVA: 0x7FFAC82C10D0
    }

    public class StdString : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC826C270 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x7FFAC826C3E0
        public void Swap(){} // RVA: 0x7FFAC826C4A0
    }

    public class StreamHandlerReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82C2D40
        public void .cctor(){} // RVA: 0x7FFAC82C2DA0
    }

}