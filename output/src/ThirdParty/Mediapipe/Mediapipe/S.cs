// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 74

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class SafeNativeMethods
    {
        // ── Methods ──
        public void absl_Status__ok(){} // RVA: 0x5ADC700
        public void absl_Status__raw_code(){} // RVA: 0x5ADC780
        public void mp_ImageFrame__Format(){} // RVA: 0x5ADC800
        public void mp_ImageFrame__Width(){} // RVA: 0x5ADC880
        public void mp_ImageFrame__Height(){} // RVA: 0x5ADC900
        public void mp_ImageFrame__WidthStep(){} // RVA: 0x5ADC980
        public void mp_ImageFrame__MutablePixelData(){} // RVA: 0x5ADCA00
        public void mp_Image__width(){} // RVA: 0x5ADCA80
        public void mp_Image__height(){} // RVA: 0x5ADCB00
        public void mp_Image__step(){} // RVA: 0x5ADCB80
        public void mp_Image__image_format(){} // RVA: 0x5ADCC00
        public void mp_PixelWriteLock__Pixels(){} // RVA: 0x5ADCC80
        public void mp_Packet__IsEmpty(){} // RVA: 0x5ADCD00
        public void mp_Packet__TimestampMicroseconds(){} // RVA: 0x5ADCD80
        public void mp_GlCalculatorHelper__GetGlContext(){} // RVA: 0x5ADCE00
        public void mp_SharedGlContext__get(){} // RVA: 0x5ADCE80
        public void mp_GlSyncToken__get(){} // RVA: 0x5ADCF00
        public void mp_SharedGpuResources__get(){} // RVA: 0x5ADCF80
        public void mp__SetCustomGlobalResourceProvider__P(){} // RVA: 0x5ADD000
        public void mp__SetCustomGlobalPathResolver__P(){} // RVA: 0x5ADD090
    }

    public class SerializedProto
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x5AD4C40
        public void Deserialize(){} // RVA: 0x283FA0
        public void WriteTo(){} // RVA: 0x283FA0
    }

    public class SerializedProtoVector
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x5AD4CA0
        public void Deserialize(){} // RVA: 0x2DC60
        public void WriteTo(){} // RVA: 0x17680
    }

    public class SharedPtrHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0
        public void Get(){} // RVA: 0xCD60
    }

    public class Status
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0
        public void DeleteMpPtr(){} // RVA: 0x5AD8980
        public void UnsafeAssertOk(){} // RVA: 0x5AD89E0
        public void AssertOk(){} // RVA: 0x5AD8B00
        public void Ok(){} // RVA: 0x5AD8C20
        public void Code(){} // RVA: 0x5AD8CE0
        public void RawCode(){} // RVA: 0x5AD8CE0
        public void ToString(){} // RVA: 0x5AD8E10
    }

    public class StatusArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AD8750
        public void Ok(){} // RVA: 0x5AD87C0
        public void InvalidArgument(){} // RVA: 0x5AD8830
        public void NotFound(){} // RVA: 0x5AD88A0
        public void Internal(){} // RVA: 0x5AD8910
    }

    public class StatusHandlerConfig
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B2A210
        public void get_Descriptor(){} // RVA: 0x5B2A270
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B2A330
        public void .ctor(){} // RVA: 0x5B2A560 | overloaded x2
        public void Clone(){} // RVA: 0x5B2A830
        public void get_StatusHandler(){} // RVA: 0x5B2A890
        public void set_StatusHandler(){} // RVA: 0x5B2A900
        public void get_HasStatusHandler(){} // RVA: 0x1D3B060
        public void ClearStatusHandler(){} // RVA: 0x26AD280
        public void get_InputSidePacket(){} // RVA: 0x30B0C0
        public void get_ExternalInput(){} // RVA: 0x30B130
        public void get_Options(){} // RVA: 0x6374D0
        public void set_Options(){} // RVA: 0x30B890
        public void Equals(){} // RVA: 0x5B2AA60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B2ABE0
        public void ToString(){} // RVA: 0x5B2ACD0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B2AD20
        public void CalculateSize(){} // RVA: 0x5B2AE80
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B2B210
        public void .cctor(){} // RVA: 0x5B2B3F0
    }

    public class StatusHandlerReflection
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B29B60
        public void .cctor(){} // RVA: 0x5B29BC0
    }

    public class StdString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AD4D60 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x5AD4ED0
        public void Swap(){} // RVA: 0x5AD4F90
    }

    public class StreamHandlerReflection
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B2B830
        public void .cctor(){} // RVA: 0x5B2B890
    }

}