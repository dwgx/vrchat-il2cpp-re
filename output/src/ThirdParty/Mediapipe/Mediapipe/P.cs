// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 15
// Methods: 224

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Packet : Object
    {
        // ── Methods ──
        public void CreateBool(){} // RVA: 0x7FFE86618490
        public void CreateGpuBuffer(){} // RVA: 0x7FFE866185A0
        public void CreateGpuBufferAt(){} // RVA: 0x7FFE866186E0
        public void CreateImage(){} // RVA: 0x7FFE86618830
        public void CreateImageAt(){} // RVA: 0x7FFE86618970
        public void CreateImageFrameAt(){} // RVA: 0x7FFE86618AC0
        public void CreateInt(){} // RVA: 0x7FFE86618C10
        public void CreateProto(){} // RVA: 0x7FFE810A1420
        public void CreateProtoAt(){} // RVA: 0x7FFE810A1420
    }

    public class PacketFactoryConfig : Object
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
        public object field_9; // 0x1D9

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86664D00
        public void get_Descriptor(){} // RVA: 0x7FFE86664D60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86664E20
        public void .ctor(){} // RVA: 0x7FFE86664F10 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866652D0
        public void get_PacketFactory(){} // RVA: 0x7FFE86665330
        public void set_PacketFactory(){} // RVA: 0x7FFE866653A0
        public void get_HasPacketFactory(){} // RVA: 0x7FFE82AC8EE0
        public void ClearPacketFactory(){} // RVA: 0x7FFE8340D8D0
        public void get_OutputSidePacket(){} // RVA: 0x7FFE866654A0
        public void set_OutputSidePacket(){} // RVA: 0x7FFE86665510
        public void get_HasOutputSidePacket(){} // RVA: 0x7FFE82BC81D0
        public void ClearOutputSidePacket(){} // RVA: 0x7FFE86597DC0
        public void get_ExternalOutput(){} // RVA: 0x7FFE86665610
        public void set_ExternalOutput(){} // RVA: 0x7FFE86665680
        public void get_HasExternalOutput(){} // RVA: 0x7FFE865A8CD0
        public void ClearExternalOutput(){} // RVA: 0x7FFE836E7F30
        public void get_Options(){} // RVA: 0x7FFE8144E200
        public void set_Options(){} // RVA: 0x7FFE81129890
        public void Equals(){} // RVA: 0x7FFE866657E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866659A0
        public void ToString(){} // RVA: 0x7FFE86665AA0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86665AF0
        public void CalculateSize(){} // RVA: 0x7FFE86665BD0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86666020
        public void .cctor(){} // RVA: 0x7FFE866661A0
    }

    public class PacketFactoryOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketFactoryOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Mediapipe.PacketFactoryOptions> _extensions; // 0x18
        public object field_3; // 0x1D5

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE86664170
        public void get_Descriptor(){} // RVA: 0x7FFE866641D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86664290
        public void .ctor(){} // RVA: 0x7FFE86664380 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86664500
        public void Equals(){} // RVA: 0x7FFE86663200 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866632A0
        public void ToString(){} // RVA: 0x7FFE866647A0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866647F0
        public void CalculateSize(){} // RVA: 0x7FFE86664860
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86664A00
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE86664AB0
    }

    public class PacketFactoryReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE86663870
        public void .cctor(){} // RVA: 0x7FFE866638D0
    }

    public class PacketGeneratorConfig : Object
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
        public void get_Parser(){} // RVA: 0x7FFE86668B50
        public void get_Descriptor(){} // RVA: 0x7FFE86668BB0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86668C70
        public void .ctor(){} // RVA: 0x7FFE86668F80 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866694D0
        public void get_PacketGenerator(){} // RVA: 0x7FFE86669530
        public void set_PacketGenerator(){} // RVA: 0x7FFE866695A0
        public void get_HasPacketGenerator(){} // RVA: 0x7FFE82AC8EE0
        public void ClearPacketGenerator(){} // RVA: 0x7FFE8340D8D0
        public void get_InputSidePacket(){} // RVA: 0x7FFE811290C0
        public void get_ExternalInput(){} // RVA: 0x7FFE81129130
        public void get_OutputSidePacket(){} // RVA: 0x7FFE8144E200
        public void get_ExternalOutput(){} // RVA: 0x7FFE8143BA80
        public void get_Options(){} // RVA: 0x7FFE81178740
        public void set_Options(){} // RVA: 0x7FFE81123200
        public void Equals(){} // RVA: 0x7FFE86669700 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866698D0
        public void ToString(){} // RVA: 0x7FFE86669A10
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86669A60
        public void CalculateSize(){} // RVA: 0x7FFE86669C10
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8666A180
        public void .cctor(){} // RVA: 0x7FFE8666A410
    }

    public class PacketGeneratorOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketGeneratorOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Mediapipe.PacketGeneratorOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public bool MergeFieldsDefaultValue; // 0x8
        public bool mergeFields_; // 0x24

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE86667D00
        public void get_Descriptor(){} // RVA: 0x7FFE86667D60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86667E20
        public void .ctor(){} // RVA: 0x7FFE86667F10 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866680A0
        public void get_MergeFields(){} // RVA: 0x7FFE86668260
        public void set_MergeFields(){} // RVA: 0x7FFE865AE770
        public void get_HasMergeFields(){} // RVA: 0x7FFE865AAC80
        public void ClearMergeFields(){} // RVA: 0x7FFE865AAC90
        public void Equals(){} // RVA: 0x7FFE866683E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866684B0
        public void ToString(){} // RVA: 0x7FFE86668570
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866685C0
        public void CalculateSize(){} // RVA: 0x7FFE86668660
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86668810
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE866688E0
    }

    public class PacketGeneratorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866674E0
        public void .cctor(){} // RVA: 0x7FFE86667540
    }

    public class PacketGetterExtension : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE80E4B8F0 | overloaded x6
        public void WriteTo(){} // RVA: 0x7FFE80E371D0
    }

    public class PacketManagerConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketManagerConfig> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.PacketFactoryConfig> _repeated_packet_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.PacketFactoryConfig> packet_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86666570
        public void get_Descriptor(){} // RVA: 0x7FFE866665D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86666690
        public void .ctor(){} // RVA: 0x7FFE86666840 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866669E0
        public void get_Packet(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE86666CB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE86666D60
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86666DB0
        public void CalculateSize(){} // RVA: 0x7FFE86666E70
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86667060
        public void .cctor(){} // RVA: 0x7FFE86667160
    }

    public class PacketMap : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84A4B910 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x7FFE86618E50
        public void At(){} // RVA: 0x7FFE80E2E390
        public void Emplace(){} // RVA: 0x7FFE80E4F230
    }

    public class Packet`1 : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x7FFE80E45FE0
        public void TimestampMicroseconds(){} // RVA: 0x7FFE80E2E2E0
        public void IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void SwitchNativePtr(){} // RVA: 0x7FFE80E46250
        public void CreateForReference(){} // RVA: 0x7FFE80E3D320
    }

    public class PixelWriteLock : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866177C0
        public void DeleteMpPtr(){} // RVA: 0x7FFE86617920
        public void Pixels(){} // RVA: 0x7FFE866179E0
    }

    public class ProfilerConfig : Object
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
        public void get_Parser(){} // RVA: 0x7FFE86639DD0
        public void get_Descriptor(){} // RVA: 0x7FFE86639E30
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86639EF0
        public void .ctor(){} // RVA: 0x7FFE8663A180 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8663A440
        public void get_HistogramIntervalSizeUsec(){} // RVA: 0x7FFE810FE7C0
        public void set_HistogramIntervalSizeUsec(){} // RVA: 0x7FFE819EA910
        public void get_NumHistogramIntervals(){} // RVA: 0x7FFE811290C0
        public void set_NumHistogramIntervals(){} // RVA: 0x7FFE81859C50
        public void get_EnableInputOutputLatency(){} // RVA: 0x7FFE815F1380
        public void set_EnableInputOutputLatency(){} // RVA: 0x7FFE81C15740
        public void get_EnableProfiler(){} // RVA: 0x7FFE819C2EA0
        public void set_EnableProfiler(){} // RVA: 0x7FFE8268C820
        public void get_EnableStreamLatency(){} // RVA: 0x7FFE82DEC5E0
        public void set_EnableStreamLatency(){} // RVA: 0x7FFE82DEC5B0
        public void get_UsePacketTimestampForAddedPacket(){} // RVA: 0x7FFE82DEC5C0
        public void set_UsePacketTimestampForAddedPacket(){} // RVA: 0x7FFE82DEC5D0
        public void get_TraceLogCapacity(){} // RVA: 0x7FFE8144E200
        public void set_TraceLogCapacity(){} // RVA: 0x7FFE82D00170
        public void get_TraceEventTypesDisabled(){} // RVA: 0x7FFE8143BA80
        public void get_TraceLogPath(){} // RVA: 0x7FFE81178740
        public void set_TraceLogPath(){} // RVA: 0x7FFE8663A4A0
        public void get_TraceLogCount(){} // RVA: 0x7FFE8119C0C0
        public void set_TraceLogCount(){} // RVA: 0x7FFE8119C0D0
        public void get_TraceLogIntervalUsec(){} // RVA: 0x7FFE8119C0E0
        public void set_TraceLogIntervalUsec(){} // RVA: 0x7FFE82506C00
        public void get_TraceLogMarginUsec(){} // RVA: 0x7FFE811C3500
        public void set_TraceLogMarginUsec(){} // RVA: 0x7FFE825093B0
        public void get_TraceLogDurationEvents(){} // RVA: 0x7FFE81124020
        public void set_TraceLogDurationEvents(){} // RVA: 0x7FFE81124030
        public void get_TraceLogIntervalCount(){} // RVA: 0x7FFE8139DA60
        public void set_TraceLogIntervalCount(){} // RVA: 0x7FFE829DF320
        public void get_TraceLogDisabled(){} // RVA: 0x7FFE811C3570
        public void set_TraceLogDisabled(){} // RVA: 0x7FFE811C3580
        public void get_TraceEnabled(){} // RVA: 0x7FFE85B63B60
        public void set_TraceEnabled(){} // RVA: 0x7FFE85B63740
        public void get_TraceLogInstantEvents(){} // RVA: 0x7FFE8663A5A0
        public void set_TraceLogInstantEvents(){} // RVA: 0x7FFE8663A5B0
        public void get_CalculatorFilter(){} // RVA: 0x7FFE811C3590
        public void set_CalculatorFilter(){} // RVA: 0x7FFE8663A5C0
        public void Equals(){} // RVA: 0x7FFE8663A720 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8663A930
        public void ToString(){} // RVA: 0x7FFE8663AB80
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8663ABD0
        public void CalculateSize(){} // RVA: 0x7FFE8663AEF0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8663B510
        public void .cctor(){} // RVA: 0x7FFE8663B8B0
    }

    public class ProtoMessageClearExtension : Object
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFE86614BD0 | overloaded x3
    }

    public class Protobuf : Object
    {
        // ── Methods ──
        public void SetLogHandler(){} // RVA: 0x7FFE86615430
        public void ResetLogHandler(){} // RVA: 0x7FFE86615500
        public void LogProtobufMessage(){} // RVA: 0x7FFE866155A0
        public void .cctor(){} // RVA: 0x7FFE86615800
    }

}