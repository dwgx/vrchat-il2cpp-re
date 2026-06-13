// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 26
// Methods: 301

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Packet
    {
        // ── Methods ──
        public void CreateBool(){} // RVA: 0x5AD7660
        public void CreateGpuBuffer(){} // RVA: 0x5AD7770
        public void CreateGpuBufferAt(){} // RVA: 0x5AD78B0
        public void CreateImage(){} // RVA: 0x5AD7A00
        public void CreateImageAt(){} // RVA: 0x5AD7B40
        public void CreateImageFrameAt(){} // RVA: 0x5AD7C90
        public void CreateInt(){} // RVA: 0x5AD7DE0
        public void CreateProto(){} // RVA: 0x283FA0
        public void CreateProtoAt(){} // RVA: 0x283FA0
    }

    public class PacketFactoryConfig
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketFactoryConfig> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string PacketFactoryDefaultValue; // 0x8
        public string packetFactory_; // 0x18
        public string OutputSidePacketDefaultValue; // 0x10
        public string outputSidePacket_; // 0x20
        public string ExternalOutputDefaultValue; // 0x18
        public string externalOutput_; // 0x28
        public Mediapipe.PacketFactoryOptions options_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B23ED0
        public void get_Descriptor(){} // RVA: 0x5B23F30
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B23FF0
        public void .ctor(){} // RVA: 0x5B240E0 | overloaded x2
        public void Clone(){} // RVA: 0x5B244A0
        public void get_PacketFactory(){} // RVA: 0x5B24500
        public void set_PacketFactory(){} // RVA: 0x5B24570
        public void get_HasPacketFactory(){} // RVA: 0x1D3B060
        public void ClearPacketFactory(){} // RVA: 0x26AD280
        public void get_OutputSidePacket(){} // RVA: 0x5B24670
        public void set_OutputSidePacket(){} // RVA: 0x5B246E0
        public void get_HasOutputSidePacket(){} // RVA: 0x1E3EC10
        public void ClearOutputSidePacket(){} // RVA: 0x5A57060
        public void get_ExternalOutput(){} // RVA: 0x5B247E0
        public void set_ExternalOutput(){} // RVA: 0x5B24850
        public void get_HasExternalOutput(){} // RVA: 0x5A67FD0
        public void ClearExternalOutput(){} // RVA: 0x29FDA70
        public void get_Options(){} // RVA: 0x6374D0
        public void set_Options(){} // RVA: 0x30B890
        public void Equals(){} // RVA: 0x5B249B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B24B70
        public void ToString(){} // RVA: 0x5B24C70
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B24CC0
        public void CalculateSize(){} // RVA: 0x5B24DA0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B251F0
        public void .cctor(){} // RVA: 0x5B25370
    }

    public class PacketFactoryOptions
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketFactoryOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Mediapipe.PacketFactoryOptions> _extensions; // 0x18

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5B23340
        public void get_Descriptor(){} // RVA: 0x5B233A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B23460
        public void .ctor(){} // RVA: 0x5B23550 | overloaded x2
        public void Clone(){} // RVA: 0x5B236D0
        public void Equals(){} // RVA: 0x5B223D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B22470
        public void ToString(){} // RVA: 0x5B23970
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B239C0
        public void CalculateSize(){} // RVA: 0x5B23A30
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B23BD0
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5B23C80
    }

    public class PacketFactoryReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B22A40
        public void .cctor(){} // RVA: 0x5B22AA0
    }

    public class PacketGeneratorConfig
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketGeneratorConfig> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string PacketGeneratorDefaultValue; // 0x8
        public string packetGenerator_; // 0x18
        public Google.Protobuf.FieldCodec`1<string> _repeated_inputSidePacket_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<string> inputSidePacket_; // 0x20
        public Google.Protobuf.FieldCodec`1<string> _repeated_externalInput_codec; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<string> externalInput_; // 0x28
        public Google.Protobuf.FieldCodec`1<string> _repeated_outputSidePacket_codec; // 0x20
        public Google.Protobuf.Collections.RepeatedField`1<string> outputSidePacket_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B27D20
        public void get_Descriptor(){} // RVA: 0x5B27D80
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B27E40
        public void .ctor(){} // RVA: 0x5B28150 | overloaded x2
        public void Clone(){} // RVA: 0x5B286A0
        public void get_PacketGenerator(){} // RVA: 0x5B28700
        public void set_PacketGenerator(){} // RVA: 0x5B28770
        public void get_HasPacketGenerator(){} // RVA: 0x1D3B060
        public void ClearPacketGenerator(){} // RVA: 0x26AD280
        public void get_InputSidePacket(){} // RVA: 0x30B0C0
        public void get_ExternalInput(){} // RVA: 0x30B130
        public void get_OutputSidePacket(){} // RVA: 0x6374D0
        public void get_ExternalOutput(){} // RVA: 0x4976A0
        public void get_Options(){} // RVA: 0x35A740
        public void set_Options(){} // RVA: 0x305200
        public void Equals(){} // RVA: 0x5B288D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B28AA0
        public void ToString(){} // RVA: 0x5B28BE0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B28C30
        public void CalculateSize(){} // RVA: 0x5B28DE0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B29350
        public void .cctor(){} // RVA: 0x5B295E0
    }

    public class PacketGeneratorOptions
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketGeneratorOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Mediapipe.PacketGeneratorOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public bool MergeFieldsDefaultValue; // 0x8
        public bool mergeFields_; // 0x24

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5B26ED0
        public void get_Descriptor(){} // RVA: 0x5B26F30
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B26FF0
        public void .ctor(){} // RVA: 0x5B270E0 | overloaded x2
        public void Clone(){} // RVA: 0x5B27270
        public void get_MergeFields(){} // RVA: 0x5B27430
        public void set_MergeFields(){} // RVA: 0x5A6DA10
        public void get_HasMergeFields(){} // RVA: 0x5A69F80
        public void ClearMergeFields(){} // RVA: 0x5A69F90
        public void Equals(){} // RVA: 0x5B275B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B27680
        public void ToString(){} // RVA: 0x5B27740
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B27790
        public void CalculateSize(){} // RVA: 0x5B27830
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B279E0
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5B27AB0
    }

    public class PacketGeneratorReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B266B0
        public void .cctor(){} // RVA: 0x5B26710
    }

    public class PacketGetterExtension
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x2A310 | overloaded x6
        public void WriteTo(){} // RVA: 0x15C60
    }

    public class PacketManagerConfig
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketManagerConfig> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.PacketFactoryConfig> _repeated_packet_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.PacketFactoryConfig> packet_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B25740
        public void get_Descriptor(){} // RVA: 0x5B257A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B25860
        public void .ctor(){} // RVA: 0x5B25A10 | overloaded x2
        public void Clone(){} // RVA: 0x5B25BB0
        public void get_Packet(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5B25E80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5B25F30
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B25F80
        public void CalculateSize(){} // RVA: 0x5B26040
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B26230
        public void .cctor(){} // RVA: 0x5B26330
    }

    public class PacketMap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x5AD8020
        public void At(){} // RVA: 0xCE10
        public void Emplace(){} // RVA: 0x2DC60
    }

    public class Packet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x24A50
        public void TimestampMicroseconds(){} // RVA: 0xCD60
        public void IsEmpty(){} // RVA: 0xDBE0
        public void SwitchNativePtr(){} // RVA: 0x24CC0
        public void CreateForReference(){} // RVA: 0x1BDB0
    }

    public class Packet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x3DDBB00
        public void TimestampMicroseconds(){} // RVA: 0x3DDBB60
        public void IsEmpty(){} // RVA: 0x3DDB480
        public void SwitchNativePtr(){} // RVA: 0x3DDB4B0
        public void CreateForReference(){} // RVA: 0x3DDB520
    }

    public class Packet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x3DDBB00
        public void TimestampMicroseconds(){} // RVA: 0x3DDBB60
        public void IsEmpty(){} // RVA: 0x3DDB480
        public void SwitchNativePtr(){} // RVA: 0x3DDB4B0
        public void CreateForReference(){} // RVA: 0x3DDB520
    }

    public class Packet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x3DDBB00
        public void TimestampMicroseconds(){} // RVA: 0x3DDBB60
        public void IsEmpty(){} // RVA: 0x3DDB480
        public void SwitchNativePtr(){} // RVA: 0x3DDB4B0
        public void CreateForReference(){} // RVA: 0x3DDB520
    }

    public class Packet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x3DDBB00
        public void TimestampMicroseconds(){} // RVA: 0x3DDBB60
        public void IsEmpty(){} // RVA: 0x3DDB480
        public void SwitchNativePtr(){} // RVA: 0x3DDB4B0
        public void CreateForReference(){} // RVA: 0x3DDB520
    }

    public class Packet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x3DDBB00
        public void TimestampMicroseconds(){} // RVA: 0x3DDBB60
        public void IsEmpty(){} // RVA: 0x3DDB480
        public void SwitchNativePtr(){} // RVA: 0x3DDB4B0
        public void CreateForReference(){} // RVA: 0x3DDB520
    }

    public class Packet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x3DDBB00
        public void TimestampMicroseconds(){} // RVA: 0x3DDBB60
        public void IsEmpty(){} // RVA: 0x3DDB480
        public void SwitchNativePtr(){} // RVA: 0x3DDB4B0
        public void CreateForReference(){} // RVA: 0x3DDB520
    }

    public class Packet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x3DDBB00
        public void TimestampMicroseconds(){} // RVA: 0x3DDBB60
        public void IsEmpty(){} // RVA: 0x3DDB480
        public void SwitchNativePtr(){} // RVA: 0x3DDB4B0
        public void CreateForReference(){} // RVA: 0x3DDB520
    }

    public class Packet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x3DDBB00
        public void TimestampMicroseconds(){} // RVA: 0x3DDBB60
        public void IsEmpty(){} // RVA: 0x3DDB480
        public void SwitchNativePtr(){} // RVA: 0x3DDB4B0
        public void CreateForReference(){} // RVA: 0x3DDB520
    }

    public class Packet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x3DDBB00
        public void TimestampMicroseconds(){} // RVA: 0x3DDBB60
        public void IsEmpty(){} // RVA: 0x3DDB480
        public void SwitchNativePtr(){} // RVA: 0x3DDB4B0
        public void CreateForReference(){} // RVA: 0x3DDB520
    }

    public class Packet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x3DDBB00
        public void TimestampMicroseconds(){} // RVA: 0x3DDBB60
        public void IsEmpty(){} // RVA: 0x3DDB480
        public void SwitchNativePtr(){} // RVA: 0x3DDB4B0
        public void CreateForReference(){} // RVA: 0x3DDB520
    }

    public class Packet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x3DDBB00
        public void TimestampMicroseconds(){} // RVA: 0x3DDBB60
        public void IsEmpty(){} // RVA: 0x3DDB480
        public void SwitchNativePtr(){} // RVA: 0x3DDB4B0
        public void CreateForReference(){} // RVA: 0x3DDB520
    }

    public class PixelWriteLock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AD6990
        public void DeleteMpPtr(){} // RVA: 0x5AD6AF0
        public void Pixels(){} // RVA: 0x5AD6BB0
    }

    public class ProfilerConfig
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ProfilerConfig> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public long histogramIntervalSizeUsec_; // 0x18
        public long numHistogramIntervals_; // 0x20
        public bool enableInputOutputLatency_; // 0x28
        public bool enableProfiler_; // 0x29
        public bool enableStreamLatency_; // 0x2A
        public bool usePacketTimestampForAddedPacket_; // 0x2B
        public long traceLogCapacity_; // 0x30
        public Google.Protobuf.FieldCodec`1<int> _repeated_traceEventTypesDisabled_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<int> traceEventTypesDisabled_; // 0x38
        public string traceLogPath_; // 0x40
        public int traceLogCount_; // 0x48
        public long traceLogIntervalUsec_; // 0x50
        public long traceLogMarginUsec_; // 0x58
        public bool traceLogDurationEvents_; // 0x60
        public int traceLogIntervalCount_; // 0x64
        public bool traceLogDisabled_; // 0x68
        public bool traceEnabled_; // 0x69
        public bool traceLogInstantEvents_; // 0x6A
        public string calculatorFilter_; // 0x70

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5AF8FA0
        public void get_Descriptor(){} // RVA: 0x5AF9000
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5AF90C0
        public void .ctor(){} // RVA: 0x5AF9350 | overloaded x2
        public void Clone(){} // RVA: 0x5AF9610
        public void get_HistogramIntervalSizeUsec(){} // RVA: 0x2E07C0
        public void set_HistogramIntervalSizeUsec(){} // RVA: 0xC5BE60
        public void get_NumHistogramIntervals(){} // RVA: 0x30B0C0
        public void set_NumHistogramIntervals(){} // RVA: 0xAE83A0
        public void get_EnableInputOutputLatency(){} // RVA: 0x6E8A80
        public void set_EnableInputOutputLatency(){} // RVA: 0x6E8B80
        public void get_EnableProfiler(){} // RVA: 0xC36000
        public void set_EnableProfiler(){} // RVA: 0x190AB20
        public void get_EnableStreamLatency(){} // RVA: 0x205EA40
        public void set_EnableStreamLatency(){} // RVA: 0x205EA30
        public void get_UsePacketTimestampForAddedPacket(){} // RVA: 0x205EA50
        public void set_UsePacketTimestampForAddedPacket(){} // RVA: 0x205EA20
        public void get_TraceLogCapacity(){} // RVA: 0x6374D0
        public void set_TraceLogCapacity(){} // RVA: 0x1F74DF0
        public void get_TraceEventTypesDisabled(){} // RVA: 0x4976A0
        public void get_TraceLogPath(){} // RVA: 0x35A740
        public void set_TraceLogPath(){} // RVA: 0x5AF9670
        public void get_TraceLogCount(){} // RVA: 0x37E0C0
        public void set_TraceLogCount(){} // RVA: 0x37E0D0
        public void get_TraceLogIntervalUsec(){} // RVA: 0x37E0E0
        public void set_TraceLogIntervalUsec(){} // RVA: 0x4C4D50
        public void get_TraceLogMarginUsec(){} // RVA: 0x3A5500
        public void set_TraceLogMarginUsec(){} // RVA: 0x4C34E0
        public void get_TraceLogDurationEvents(){} // RVA: 0x306020
        public void set_TraceLogDurationEvents(){} // RVA: 0x306030
        public void get_TraceLogIntervalCount(){} // RVA: 0x59C4F0
        public void set_TraceLogIntervalCount(){} // RVA: 0x1C5A610
        public void get_TraceLogDisabled(){} // RVA: 0x3A5570
        public void set_TraceLogDisabled(){} // RVA: 0x3A5580
        public void get_TraceEnabled(){} // RVA: 0x4EC4D70
        public void set_TraceEnabled(){} // RVA: 0x4EC47C0
        public void get_TraceLogInstantEvents(){} // RVA: 0x5AF9770
        public void set_TraceLogInstantEvents(){} // RVA: 0x5AF9780
        public void get_CalculatorFilter(){} // RVA: 0x3A5590
        public void set_CalculatorFilter(){} // RVA: 0x5AF9790
        public void Equals(){} // RVA: 0x5AF98F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5AF9B00
        public void ToString(){} // RVA: 0x5AF9D50
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5AF9DA0
        public void CalculateSize(){} // RVA: 0x5AFA0C0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5AFA6E0
        public void .cctor(){} // RVA: 0x5AFAA80
    }

    public class ProtoMessageClearExtension
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x5AD3DA0 | overloaded x3
    }

    public class Protobuf
    {
        // ── Methods ──
        public void SetLogHandler(){} // RVA: 0x5AD4600
        public void ResetLogHandler(){} // RVA: 0x5AD46D0
        public void LogProtobufMessage(){} // RVA: 0x5AD4770
        public void .cctor(){} // RVA: 0x5AD49D0
    }

}