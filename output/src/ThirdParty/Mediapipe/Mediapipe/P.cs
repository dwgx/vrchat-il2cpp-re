// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 15
// Methods: 224

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Packet : Object
    {
        // ── Methods ──
        public void CreateBool(){} // RVA: 0x7FFAC826EB70
        public void CreateGpuBuffer(){} // RVA: 0x7FFAC826EC80
        public void CreateGpuBufferAt(){} // RVA: 0x7FFAC826EDC0
        public void CreateImage(){} // RVA: 0x7FFAC826EF10
        public void CreateImageAt(){} // RVA: 0x7FFAC826F050
        public void CreateImageFrameAt(){} // RVA: 0x7FFAC826F1A0
        public void CreateInt(){} // RVA: 0x7FFAC826F2F0
        public void CreateProto(){} // RVA: 0x7FFAC2E8DC40
        public void CreateProtoAt(){} // RVA: 0x7FFAC2E8DC40
    }

    public class PacketFactoryConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketFactoryConfig> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public string PacketFactory; // 0x18
        public string HasPacketFactory; // 0x10
        public string OutputSidePacket; // 0x20
        public string HasOutputSidePacket; // 0x18
        public string ExternalOutput; // 0x28
        public Mediapipe.PacketFactoryOptions HasExternalOutput; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82BB3E0
        public void get_Descriptor(){} // RVA: 0x7FFAC82BB440
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82BB500
        public void .ctor(){} // RVA: 0x7FFAC82BB5F0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82BB9B0
        public void get_PacketFactory(){} // RVA: 0x7FFAC82BBA10
        public void set_PacketFactory(){} // RVA: 0x7FFAC82BBA80
        public void get_HasPacketFactory(){} // RVA: 0x7FFAC4860B40
        public void ClearPacketFactory(){} // RVA: 0x7FFAC515CC20
        public void get_OutputSidePacket(){} // RVA: 0x7FFAC82BBB80
        public void set_OutputSidePacket(){} // RVA: 0x7FFAC82BBBF0
        public void get_HasOutputSidePacket(){} // RVA: 0x7FFAC495C6A0
        public void ClearOutputSidePacket(){} // RVA: 0x7FFAC81EE480
        public void get_ExternalOutput(){} // RVA: 0x7FFAC82BBCF0
        public void set_ExternalOutput(){} // RVA: 0x7FFAC82BBD60
        public void get_HasExternalOutput(){} // RVA: 0x7FFAC81FF390
        public void ClearExternalOutput(){} // RVA: 0x7FFAC53F2F70
        public void get_Options(){} // RVA: 0x7FFAC31D95E0
        public void set_Options(){} // RVA: 0x7FFAC2F4F890
        public void Equals(){} // RVA: 0x7FFAC82BBEC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82BC080
        public void ToString(){} // RVA: 0x7FFAC82BC180
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82BC1D0
        public void CalculateSize(){} // RVA: 0x7FFAC82BC2B0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82BC700
        public void .cctor(){} // RVA: 0x7FFAC82BC880
    }

    public class PacketFactoryOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketFactoryOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Mediapipe.PacketFactoryOptions> Descriptor; // 0x18

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC82BA850
        public void get_Descriptor(){} // RVA: 0x7FFAC82BA8B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82BA970
        public void .ctor(){} // RVA: 0x7FFAC82BAA60 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82BABE0
        public void Equals(){} // RVA: 0x7FFAC82B98E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82B9980
        public void ToString(){} // RVA: 0x7FFAC82BAE80
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82BAED0
        public void CalculateSize(){} // RVA: 0x7FFAC82BAF40
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82BB0E0
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC82BB190
    }

    public class PacketFactoryReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82B9F50
        public void .cctor(){} // RVA: 0x7FFAC82B9FB0
    }

    public class PacketGeneratorConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketGeneratorConfig> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public string PacketGenerator; // 0x18
        public Google.Protobuf.FieldCodec`1<string> HasPacketGenerator; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<string> InputSidePacket; // 0x20
        public Google.Protobuf.FieldCodec`1<string> ExternalInput; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<string> OutputSidePacket; // 0x28
        public Google.Protobuf.FieldCodec`1<string> ExternalOutput; // 0x20
        public Google.Protobuf.Collections.RepeatedField`1<string> Options; // 0x30
        public Google.Protobuf.FieldCodec`1<string> _repeated_externalOutput_codec; // 0x28
        public Google.Protobuf.Collections.RepeatedField`1<string> externalOutput_; // 0x38
        public Mediapipe.PacketGeneratorOptions options_; // 0x40

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82BF230
        public void get_Descriptor(){} // RVA: 0x7FFAC82BF290
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82BF350
        public void .ctor(){} // RVA: 0x7FFAC82BF660 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82BFBB0
        public void get_PacketGenerator(){} // RVA: 0x7FFAC82BFC10
        public void set_PacketGenerator(){} // RVA: 0x7FFAC82BFC80
        public void get_HasPacketGenerator(){} // RVA: 0x7FFAC4860B40
        public void ClearPacketGenerator(){} // RVA: 0x7FFAC515CC20
        public void get_InputSidePacket(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ExternalInput(){} // RVA: 0x7FFAC2F4F130
        public void get_OutputSidePacket(){} // RVA: 0x7FFAC31D95E0
        public void get_ExternalOutput(){} // RVA: 0x7FFAC31D0140
        public void get_Options(){} // RVA: 0x7FFAC2F9E740
        public void set_Options(){} // RVA: 0x7FFAC2F49200
        public void Equals(){} // RVA: 0x7FFAC82BFDE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82BFFB0
        public void ToString(){} // RVA: 0x7FFAC82C00F0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82C0140
        public void CalculateSize(){} // RVA: 0x7FFAC82C02F0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82C0860
        public void .cctor(){} // RVA: 0x7FFAC82C0AF0
    }

    public class PacketGeneratorOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketGeneratorOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Mediapipe.PacketGeneratorOptions> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool MergeFields; // 0x8
        public bool HasMergeFields; // 0x24

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC82BE3E0
        public void get_Descriptor(){} // RVA: 0x7FFAC82BE440
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82BE500
        public void .ctor(){} // RVA: 0x7FFAC82BE5F0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82BE780
        public void get_MergeFields(){} // RVA: 0x7FFAC82BE940
        public void set_MergeFields(){} // RVA: 0x7FFAC8204E30
        public void get_HasMergeFields(){} // RVA: 0x7FFAC8201340
        public void ClearMergeFields(){} // RVA: 0x7FFAC8201350
        public void Equals(){} // RVA: 0x7FFAC82BEAC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82BEB90
        public void ToString(){} // RVA: 0x7FFAC82BEC50
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82BECA0
        public void CalculateSize(){} // RVA: 0x7FFAC82BED40
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82BEEF0
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC82BEFC0
    }

    public class PacketGeneratorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82BDBC0
        public void .cctor(){} // RVA: 0x7FFAC82BDC20
    }

    public class PacketGetterExtension : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC2C761F0 | overloaded x6
        public void WriteTo(){} // RVA: 0x7FFAC2C61D80
    }

    public class PacketManagerConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.PacketManagerConfig> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.PacketFactoryConfig> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.PacketFactoryConfig> Packet; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82BCC50
        public void get_Descriptor(){} // RVA: 0x7FFAC82BCCB0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82BCD70
        public void .ctor(){} // RVA: 0x7FFAC82BCF20 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82BD0C0
        public void get_Packet(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC82BD390 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC82BD440
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82BD490
        public void CalculateSize(){} // RVA: 0x7FFAC82BD550
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82BD740
        public void .cctor(){} // RVA: 0x7FFAC82BD840
    }

    public class PacketMap : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC66E6D30 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x7FFAC826F530
        public void At(){} // RVA: 0x7FFAC2C58F40
        public void Emplace(){} // RVA: 0x7FFAC2C79B30
    }

    public class Packet`1 : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x7FFAC2C70980
        public void TimestampMicroseconds(){} // RVA: 0x7FFAC2C58E90
        public void IsEmpty(){} // RVA: 0x7FFAC2C59D00
        public void SwitchNativePtr(){} // RVA: 0x7FFAC2C70BF0
        public void CreateForReference(){} // RVA: 0x7FFAC2C67ED0
    }

    public class PixelWriteLock : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC826DEA0
        public void DeleteMpPtr(){} // RVA: 0x7FFAC826E000
        public void Pixels(){} // RVA: 0x7FFAC826E0C0
    }

    public class ProfilerConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ProfilerConfig> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public long pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public long HistogramIntervalSizeUsec; // 0x20
        public bool NumHistogramIntervals; // 0x28
        public bool EnableInputOutputLatency; // 0x29
        public bool EnableProfiler; // 0x2A
        public bool EnableStreamLatency; // 0x2B
        public long UsePacketTimestampForAddedPacket; // 0x30
        public Google.Protobuf.FieldCodec`1<int> TraceLogCapacity; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<int> TraceEventTypesDisabled; // 0x38
        public string TraceLogPath; // 0x40
        public int TraceLogCount; // 0x48
        public long TraceLogIntervalUsec; // 0x50
        public long TraceLogMarginUsec; // 0x58
        public bool TraceLogDurationEvents; // 0x60
        public int TraceLogIntervalCount; // 0x64
        public bool TraceLogDisabled; // 0x68
        public bool TraceEnabled; // 0x69
        public bool TraceLogInstantEvents; // 0x6A
        public string CalculatorFilter; // 0x70

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82904B0
        public void get_Descriptor(){} // RVA: 0x7FFAC8290510
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82905D0
        public void .ctor(){} // RVA: 0x7FFAC8290860 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8290B20
        public void get_HistogramIntervalSizeUsec(){} // RVA: 0x7FFAC2F247C0
        public void set_HistogramIntervalSizeUsec(){} // RVA: 0x7FFAC38920D0
        public void get_NumHistogramIntervals(){} // RVA: 0x7FFAC2F4F0C0
        public void set_NumHistogramIntervals(){} // RVA: 0x7FFAC370BEE0
        public void get_EnableInputOutputLatency(){} // RVA: 0x7FFAC30F6BA0
        public void set_EnableInputOutputLatency(){} // RVA: 0x7FFAC3C24F40
        public void get_EnableProfiler(){} // RVA: 0x7FFAC386C550
        public void set_EnableProfiler(){} // RVA: 0x7FFAC43B4D70
        public void get_EnableStreamLatency(){} // RVA: 0x7FFAC4B82F20
        public void set_EnableStreamLatency(){} // RVA: 0x7FFAC4B82F40
        public void get_UsePacketTimestampForAddedPacket(){} // RVA: 0x7FFAC4B82F30
        public void set_UsePacketTimestampForAddedPacket(){} // RVA: 0x7FFAC4B82F10
        public void get_TraceLogCapacity(){} // RVA: 0x7FFAC31D95E0
        public void set_TraceLogCapacity(){} // RVA: 0x7FFAC4A98000
        public void get_TraceEventTypesDisabled(){} // RVA: 0x7FFAC31D0140
        public void get_TraceLogPath(){} // RVA: 0x7FFAC2F9E740
        public void set_TraceLogPath(){} // RVA: 0x7FFAC8290B80
        public void get_TraceLogCount(){} // RVA: 0x7FFAC2FC20C0
        public void set_TraceLogCount(){} // RVA: 0x7FFAC2FC20D0
        public void get_TraceLogIntervalUsec(){} // RVA: 0x7FFAC2FC20E0
        public void set_TraceLogIntervalUsec(){} // RVA: 0x7FFAC42499F0
        public void get_TraceLogMarginUsec(){} // RVA: 0x7FFAC2FE9500
        public void set_TraceLogMarginUsec(){} // RVA: 0x7FFAC4249140
        public void get_TraceLogDurationEvents(){} // RVA: 0x7FFAC2F4A020
        public void set_TraceLogDurationEvents(){} // RVA: 0x7FFAC2F4A030
        public void get_TraceLogIntervalCount(){} // RVA: 0x7FFAC3138CA0
        public void set_TraceLogIntervalCount(){} // RVA: 0x7FFAC46D5120
        public void get_TraceLogDisabled(){} // RVA: 0x7FFAC2FE9570
        public void set_TraceLogDisabled(){} // RVA: 0x7FFAC2FE9580
        public void get_TraceEnabled(){} // RVA: 0x7FFAC4670BD0
        public void set_TraceEnabled(){} // RVA: 0x7FFAC466E010
        public void get_TraceLogInstantEvents(){} // RVA: 0x7FFAC8290C80
        public void set_TraceLogInstantEvents(){} // RVA: 0x7FFAC8290C90
        public void get_CalculatorFilter(){} // RVA: 0x7FFAC2FE9590
        public void set_CalculatorFilter(){} // RVA: 0x7FFAC8290CA0
        public void Equals(){} // RVA: 0x7FFAC8290E00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8291010
        public void ToString(){} // RVA: 0x7FFAC8291260
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82912B0
        public void CalculateSize(){} // RVA: 0x7FFAC82915D0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8291BF0
        public void .cctor(){} // RVA: 0x7FFAC8291F90
    }

    public class ProtoMessageClearExtension : Object
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFAC826B2B0 | overloaded x3
    }

    public class Protobuf : Object
    {
        public LogHandler DefaultLogHandler;

        // ── Methods ──
        public void SetLogHandler(){} // RVA: 0x7FFAC826BB10
        public void ResetLogHandler(){} // RVA: 0x7FFAC826BBE0
        public void LogProtobufMessage(){} // RVA: 0x7FFAC826BC80
        public void .cctor(){} // RVA: 0x7FFAC826BEE0
    }

}