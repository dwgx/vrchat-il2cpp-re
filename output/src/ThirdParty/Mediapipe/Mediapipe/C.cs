// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 160

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class CalculatorGraph : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86615ED0
        public void DeleteMpPtr(){} // RVA: 0x7FFE86616010
        public void Initialize(){} // RVA: 0x7FFE866160D0
        public void ObserveOutputStream(){} // RVA: 0x7FFE86616210
        public void AddOutputStreamPoller(){} // RVA: 0x7FFE80E3EBB0
        public void StartRun(){} // RVA: 0x7FFE86616390
        public void WaitUntilDone(){} // RVA: 0x7FFE866164C0
        public void AddPacketToInputStream(){} // RVA: 0x7FFE80E4F230
        public void CloseAllPacketSources(){} // RVA: 0x7FFE866165D0
        public void SetGpuResources(){} // RVA: 0x7FFE866166E0
    }

    public class CalculatorGraphConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.CalculatorGraphConfig> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Node> _repeated_node_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Node> node_; // 0x18
        public Google.Protobuf.FieldCodec`1<Mediapipe.PacketFactoryConfig> _repeated_packetFactory_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.PacketFactoryConfig> packetFactory_; // 0x20
        public Google.Protobuf.FieldCodec`1<Mediapipe.PacketGeneratorConfig> _repeated_packetGenerator_codec; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.PacketGeneratorConfig> packetGenerator_; // 0x28
        public int numThreads_; // 0x30
        public Google.Protobuf.FieldCodec`1<Mediapipe.StatusHandlerConfig> _repeated_statusHandler_codec; // 0x20
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.StatusHandlerConfig> statusHandler_; // 0x38
        public Google.Protobuf.FieldCodec`1<string> _repeated_inputStream_codec; // 0x28
        public Google.Protobuf.Collections.RepeatedField`1<string> inputStream_; // 0x40
        public Google.Protobuf.FieldCodec`1<string> _repeated_outputStream_codec; // 0x30
        public Google.Protobuf.Collections.RepeatedField`1<string> outputStream_; // 0x48
        public Google.Protobuf.FieldCodec`1<string> _repeated_inputSidePacket_codec; // 0x38
        public Google.Protobuf.Collections.RepeatedField`1<string> inputSidePacket_; // 0x50
        public Google.Protobuf.FieldCodec`1<string> _repeated_outputSidePacket_codec; // 0x40
        public Google.Protobuf.Collections.RepeatedField`1<string> outputSidePacket_; // 0x58
        public int maxQueueSize_; // 0x60
        public bool reportDeadlock_; // 0x64
        public Mediapipe.InputStreamHandlerConfig inputStreamHandler_; // 0x68

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8663BBB0
        public void get_Descriptor(){} // RVA: 0x7FFE8663BC10
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8663BCD0
        public void .ctor(){} // RVA: 0x7FFE8663C380 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8663CC90
        public void get_Node(){} // RVA: 0x7FFE810FE7C0
        public void get_PacketFactory(){} // RVA: 0x7FFE811290C0
        public void get_PacketGenerator(){} // RVA: 0x7FFE81129130
        public void get_NumThreads(){} // RVA: 0x7FFE81156CD0
        public void set_NumThreads(){} // RVA: 0x7FFE81156CE0
        public void get_StatusHandler(){} // RVA: 0x7FFE8143BA80
        public void get_InputStream(){} // RVA: 0x7FFE81178740
        public void get_OutputStream(){} // RVA: 0x7FFE81176730
        public void get_InputSidePacket(){} // RVA: 0x7FFE8119C0E0
        public void get_OutputSidePacket(){} // RVA: 0x7FFE811C3500
        public void get_MaxQueueSize(){} // RVA: 0x7FFE8139EA30
        public void set_MaxQueueSize(){} // RVA: 0x7FFE8139E520
        public void get_ReportDeadlock(){} // RVA: 0x7FFE821FF050
        public void set_ReportDeadlock(){} // RVA: 0x7FFE82A22EE0
        public void get_InputStreamHandler(){} // RVA: 0x7FFE81176D50
        public void set_InputStreamHandler(){} // RVA: 0x7FFE81176D60
        public void get_OutputStreamHandler(){} // RVA: 0x7FFE811C3590
        public void set_OutputStreamHandler(){} // RVA: 0x7FFE811C35A0
        public void get_Executor(){} // RVA: 0x7FFE81463AE0
        public void get_ProfilerConfig(){} // RVA: 0x7FFE81280C30
        public void set_ProfilerConfig(){} // RVA: 0x7FFE81282380
        public void get_Package(){} // RVA: 0x7FFE8113A010
        public void set_Package(){} // RVA: 0x7FFE8663CCF0
        public void get_Type(){} // RVA: 0x7FFE8154EB60
        public void set_Type(){} // RVA: 0x7FFE8663CDF0
        public void get_Options(){} // RVA: 0x7FFE817AE360
        public void set_Options(){} // RVA: 0x7FFE8171B470
        public void get_GraphOptions(){} // RVA: 0x7FFE8179C860
        public void Equals(){} // RVA: 0x7FFE8663CF50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8663D370
        public void ToString(){} // RVA: 0x7FFE8663D670
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8663D6C0
        public void CalculateSize(){} // RVA: 0x7FFE8663DB50
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8663E6C0
        public void .cctor(){} // RVA: 0x7FFE8663ED90
    }

    public class CalculatorGraphConfigExtension : Object
    {
        // ── Methods ──
        public void ParseFromTextFormat(){} // RVA: 0x7FFE866168F0
    }

    public class CalculatorOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.CalculatorOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Mediapipe.CalculatorOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public bool MergeFieldsDefaultValue; // 0x8
        public bool mergeFields_; // 0x24

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE86643740
        public void get_Descriptor(){} // RVA: 0x7FFE866437A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86643860
        public void .ctor(){} // RVA: 0x7FFE86643950 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86643AE0
        public void get_MergeFields(){} // RVA: 0x7FFE86643CA0
        public void set_MergeFields(){} // RVA: 0x7FFE865AE770
        public void get_HasMergeFields(){} // RVA: 0x7FFE865AAC80
        public void ClearMergeFields(){} // RVA: 0x7FFE865AAC90
        public void Equals(){} // RVA: 0x7FFE86643E20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86643EF0
        public void ToString(){} // RVA: 0x7FFE86643FB0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86644000
        public void CalculateSize(){} // RVA: 0x7FFE866440A0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86644250
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE86644320
    }

    public class CalculatorOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE86643250
        public void .cctor(){} // RVA: 0x7FFE866432B0
    }

    public class CalculatorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE86633350
        public void .cctor(){} // RVA: 0x7FFE866333B0
    }

    public class Classification : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Classification> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public int IndexFieldNumber;
        public int IndexDefaultValue; // 0x8
        public int index_; // 0x1C
        public int ScoreFieldNumber;
        public float ScoreDefaultValue; // 0xC
        public float score_; // 0x20
        public int LabelFieldNumber;
        public string LabelDefaultValue; // 0x10

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86647320
        public void get_Descriptor(){} // RVA: 0x7FFE86647380
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86647440
        public void .ctor(){} // RVA: 0x7FFE86647530 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866476E0
        public void get_Index(){} // RVA: 0x7FFE866478C0
        public void set_Index(){} // RVA: 0x7FFE8659D0A0
        public void get_HasIndex(){} // RVA: 0x7FFE8659D0B0
        public void ClearIndex(){} // RVA: 0x7FFE8659D0C0
        public void get_Score(){} // RVA: 0x7FFE86647930
        public void set_Score(){} // RVA: 0x7FFE866479A0
        public void get_HasScore(){} // RVA: 0x7FFE8659D150
        public void ClearScore(){} // RVA: 0x7FFE8659D160
        public void get_Label(){} // RVA: 0x7FFE866479B0
        public void set_Label(){} // RVA: 0x7FFE86647A20
        public void get_HasLabel(){} // RVA: 0x7FFE865A8CD0
        public void ClearLabel(){} // RVA: 0x7FFE836E7F30
        public void get_DisplayName(){} // RVA: 0x7FFE86647B20
        public void set_DisplayName(){} // RVA: 0x7FFE86647B90
        public void get_HasDisplayName(){} // RVA: 0x7FFE85C00B10
        public void ClearDisplayName(){} // RVA: 0x7FFE865A8E50
        public void Equals(){} // RVA: 0x7FFE86647CF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86647EB0
        public void ToString(){} // RVA: 0x7FFE86647FF0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86648040
        public void CalculateSize(){} // RVA: 0x7FFE86648120
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86648380
        public void .cctor(){} // RVA: 0x7FFE866484B0
    }

    public class ClassificationList : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ClassificationList> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int ClassificationFieldNumber;
        public Google.Protobuf.FieldCodec`1<Mediapipe.Classification> _repeated_classification_codec; // 0x8

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86648830
        public void get_Descriptor(){} // RVA: 0x7FFE86648890
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86648950
        public void .ctor(){} // RVA: 0x7FFE86648B00 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86648CA0
        public void get_Classification(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE86648F70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE86649020
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86649070
        public void CalculateSize(){} // RVA: 0x7FFE86649130
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86649320
        public void .cctor(){} // RVA: 0x7FFE86649420
    }

    public class ClassificationListCollection : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ClassificationListCollection> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.ClassificationList> _repeated_classificationList_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.ClassificationList> classificationList_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866497A0
        public void get_Descriptor(){} // RVA: 0x7FFE86649800
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866498C0
        public void .ctor(){} // RVA: 0x7FFE86649A70 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86649C10
        public void get_ClassificationList(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE86649EE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE86649F90
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86649FE0
        public void CalculateSize(){} // RVA: 0x7FFE8664A0A0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8664A290
        public void .cctor(){} // RVA: 0x7FFE8664A390
    }

    public class ClassificationReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866469E0
        public void .cctor(){} // RVA: 0x7FFE86646A40
    }

}