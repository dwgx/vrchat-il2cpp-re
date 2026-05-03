// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 74

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class SafeNativeMethods : Object
    {
        // ── Methods ──
        public void absl_Status__ok(){} // RVA: 0x7FFE8661D530
        public void absl_Status__raw_code(){} // RVA: 0x7FFE8661D5B0
        public void mp_ImageFrame__Format(){} // RVA: 0x7FFE8661D630
        public void mp_ImageFrame__Width(){} // RVA: 0x7FFE8661D6B0
        public void mp_ImageFrame__Height(){} // RVA: 0x7FFE8661D730
        public void mp_ImageFrame__WidthStep(){} // RVA: 0x7FFE8661D7B0
        public void mp_ImageFrame__MutablePixelData(){} // RVA: 0x7FFE8661D830
        public void mp_Image__width(){} // RVA: 0x7FFE8661D8B0
        public void mp_Image__height(){} // RVA: 0x7FFE8661D930
        public void mp_Image__step(){} // RVA: 0x7FFE8661D9B0
        public void mp_Image__image_format(){} // RVA: 0x7FFE8661DA30
        public void mp_PixelWriteLock__Pixels(){} // RVA: 0x7FFE8661DAB0
        public void mp_Packet__IsEmpty(){} // RVA: 0x7FFE8661DB30
        public void mp_Packet__TimestampMicroseconds(){} // RVA: 0x7FFE8661DBB0
        public void mp_GlCalculatorHelper__GetGlContext(){} // RVA: 0x7FFE8661DC30
        public void mp_SharedGlContext__get(){} // RVA: 0x7FFE8661DCB0
        public void mp_GlSyncToken__get(){} // RVA: 0x7FFE8661DD30
        public void mp_SharedGpuResources__get(){} // RVA: 0x7FFE8661DDB0
        public void mp__SetCustomGlobalResourceProvider__P(){} // RVA: 0x7FFE8661DE30
        public void mp__SetCustomGlobalPathResolver__P(){} // RVA: 0x7FFE8661DEC0
    }

    public class SerializedProto : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE86615A70
        public void Deserialize(){} // RVA: 0x7FFE810A1420
        public void WriteTo(){} // RVA: 0x7FFE810A1420
    }

    public class SerializedProtoVector : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE86615AD0
        public void Deserialize(){} // RVA: 0x7FFE80E4F230
        public void WriteTo(){} // RVA: 0x7FFE80E38BF0
    }

    public class SharedPtrHandle : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84A4B910
        public void Get(){} // RVA: 0x7FFE80E2E2E0
    }

    public class Status : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84A4B910
        public void DeleteMpPtr(){} // RVA: 0x7FFE866197B0
        public void UnsafeAssertOk(){} // RVA: 0x7FFE86619810
        public void AssertOk(){} // RVA: 0x7FFE86619930
        public void Ok(){} // RVA: 0x7FFE86619A50
        public void Code(){} // RVA: 0x7FFE86619B10
        public void RawCode(){} // RVA: 0x7FFE86619B10
        public void ToString(){} // RVA: 0x7FFE86619C40
    }

    public class StatusArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86619580
        public void Ok(){} // RVA: 0x7FFE866195F0
        public void InvalidArgument(){} // RVA: 0x7FFE86619660
        public void NotFound(){} // RVA: 0x7FFE866196D0
        public void Internal(){} // RVA: 0x7FFE86619740
    }

    public class StatusHandlerConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.StatusHandlerConfig> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string StatusHandlerDefaultValue; // 0x8
        public string statusHandler_; // 0x18
        public Google.Protobuf.FieldCodec`1<string> _repeated_inputSidePacket_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<string> inputSidePacket_; // 0x20
        public Google.Protobuf.FieldCodec`1<string> _repeated_externalInput_codec; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<string> externalInput_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8666B040
        public void get_Descriptor(){} // RVA: 0x7FFE8666B0A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8666B160
        public void .ctor(){} // RVA: 0x7FFE8666B390 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8666B660
        public void get_StatusHandler(){} // RVA: 0x7FFE8666B6C0
        public void set_StatusHandler(){} // RVA: 0x7FFE8666B730
        public void get_HasStatusHandler(){} // RVA: 0x7FFE82AC8EE0
        public void ClearStatusHandler(){} // RVA: 0x7FFE8340D8D0
        public void get_InputSidePacket(){} // RVA: 0x7FFE811290C0
        public void get_ExternalInput(){} // RVA: 0x7FFE81129130
        public void get_Options(){} // RVA: 0x7FFE8144E200
        public void set_Options(){} // RVA: 0x7FFE81129890
        public void Equals(){} // RVA: 0x7FFE8666B890 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8666BA10
        public void ToString(){} // RVA: 0x7FFE8666BB00
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8666BB50
        public void CalculateSize(){} // RVA: 0x7FFE8666BCB0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8666C040
        public void .cctor(){} // RVA: 0x7FFE8666C220
    }

    public class StatusHandlerReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8666A990
        public void .cctor(){} // RVA: 0x7FFE8666A9F0
    }

    public class StdString : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86615B90 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x7FFE86615D00
        public void Swap(){} // RVA: 0x7FFE86615DC0
    }

    public class StreamHandlerReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8666C660
        public void .cctor(){} // RVA: 0x7FFE8666C6C0
    }

}