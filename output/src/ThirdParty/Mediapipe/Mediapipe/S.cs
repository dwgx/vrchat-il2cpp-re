// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 70

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class SafeNativeMethods : Object
    {
        // ── Methods ──
        public void absl_Status__ok(){} // RVA: 0x6557070
        public void absl_Status__raw_code(){} // RVA: 0x65570F0
        public void mp_ImageFrame__Format(){} // RVA: 0x6557170
        public void mp_ImageFrame__Width(){} // RVA: 0x65571F0
        public void mp_ImageFrame__Height(){} // RVA: 0x6557270
        public void mp_ImageFrame__WidthStep(){} // RVA: 0x65572F0
        public void mp_ImageFrame__MutablePixelData(){} // RVA: 0x6557370
        public void mp_Image__width(){} // RVA: 0x65573F0
        public void mp_Image__height(){} // RVA: 0x6557470
        public void mp_Image__step(){} // RVA: 0x65574F0
        public void mp_Image__image_format(){} // RVA: 0x6557570
        public void mp_PixelWriteLock__Pixels(){} // RVA: 0x65575F0
        public void mp_Packet__IsEmpty(){} // RVA: 0x6557670
        public void mp_Packet__TimestampMicroseconds(){} // RVA: 0x65576F0
        public void mp_GlCalculatorHelper__GetGlContext(){} // RVA: 0x6557770
        public void mp_SharedGlContext__get(){} // RVA: 0x65577F0
        public void mp_GlSyncToken__get(){} // RVA: 0x6557870
        public void mp_SharedGpuResources__get(){} // RVA: 0x65578F0
        public void mp__SetCustomGlobalResourceProvider__P(){} // RVA: 0x6557970
        public void mp__SetCustomGlobalPathResolver__P(){} // RVA: 0x6557A00
    }

    public class SerializedProto : ValueType
    {
        public object _str;
        public object _length;

        // ── Methods ──
        public void Dispose(){} // RVA: 0x8A5990
        public void Deserialize(){} // RVA: 0xA94080
        public void WriteTo(){} // RVA: 0xA94080
    }

    public class SerializedProtoVector : ValueType
    {
        public object _data;
        public object _size;

        // ── Methods ──
        public void Dispose(){} // RVA: 0x8A59F0
        public void Deserialize(){} // RVA: 0x8943B0
        public void WriteTo(){} // RVA: 0x881CA0
    }

    public class SharedPtrHandle : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4848120
        public void Get(){} // RVA: 0x87C0A0
    }

    public class Status : MpResourceHandle
    {
        public object _ok;
        public object _rawCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4848120
        public void DeleteMpPtr(){} // RVA: 0x6553310
        public void UnsafeAssertOk(){} // RVA: 0x6553370
        public void AssertOk(){} // RVA: 0x6553490
        public void Ok(){} // RVA: 0x65535B0
        public void Code(){} // RVA: 0x6553670
        public void RawCode(){} // RVA: 0x6553670
        public void ToString(){} // RVA: 0x65537A0
    }

    public class StatusArgs : ValueType
    {
        public object _code;
        public object _message;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8A5B90
        public void Ok(){} // RVA: 0x6553150
        public void InvalidArgument(){} // RVA: 0x65531C0
        public void NotFound(){} // RVA: 0x6553230
        public void Internal(){} // RVA: 0x65532A0
    }

    public class StatusHandlerConfig : Object
    {
        public object _parser;
        public object _unknownFields;
        public object StatusHandlerDefaultValue;
        public object statusHandler_;
        public object _repeated_inputSidePacket_codec;
        public object inputSidePacket_;
        public object _repeated_externalInput_codec;
        public object externalInput_;
        public object options_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65A4000
        public void get_Descriptor(){} // RVA: 0x65A4060
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65A4120
        public void .ctor(){} // RVA: 0x65A4350
        public void Clone(){} // RVA: 0x65A4620
        public void get_StatusHandler(){} // RVA: 0x65A4680
        public void set_StatusHandler(){} // RVA: 0x65A46F0
        public void get_HasStatusHandler(){} // RVA: 0x25E9250
        public void ClearStatusHandler(){} // RVA: 0x30FBB60
        public void get_InputSidePacket(){} // RVA: 0xB700F0
        public void get_ExternalInput(){} // RVA: 0xB70160
        public void get_Options(){} // RVA: 0xD33E60
        public void set_Options(){} // RVA: 0xB708C0
        public void Equals(){} // RVA: 0x65A4850
        public void GetHashCode(){} // RVA: 0x65A49D0
        public void ToString(){} // RVA: 0x65A4AC0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65A4B10
        public void CalculateSize(){} // RVA: 0x65A4C70
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65A5000
        public void .cctor(){} // RVA: 0x65A51E0
    }

    public class StatusHandlerReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x65A3980
        public void .cctor(){} // RVA: 0x65A39E0
    }

    public class StdString : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x654F5A0
        public void DeleteMpPtr(){} // RVA: 0x654F710
        public void Swap(){} // RVA: 0x654F7D0
    }

    public class StreamHandlerReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x65A5620
        public void .cctor(){} // RVA: 0x65A5680
    }

}