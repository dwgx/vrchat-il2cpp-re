// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 160

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class CalculatorGraph
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AD50A0
        public void DeleteMpPtr(){} // RVA: 0x5AD51E0
        public void Initialize(){} // RVA: 0x5AD52A0
        public void ObserveOutputStream(){} // RVA: 0x5AD53E0
        public void AddOutputStreamPoller(){} // RVA: 0x1D640
        public void StartRun(){} // RVA: 0x5AD5560
        public void WaitUntilDone(){} // RVA: 0x5AD5690
        public void AddPacketToInputStream(){} // RVA: 0x2DC60
        public void CloseAllPacketSources(){} // RVA: 0x5AD57A0
        public void SetGpuResources(){} // RVA: 0x5AD58B0
    }

    public class CalculatorGraphConfig
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
        public void get_Parser(){} // RVA: 0x5AFAD80
        public void get_Descriptor(){} // RVA: 0x5AFADE0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5AFAEA0
        public void .ctor(){} // RVA: 0x5AFB550 | overloaded x2
        public void Clone(){} // RVA: 0x5AFBE60
        public void get_Node(){} // RVA: 0x2E07C0
        public void get_PacketFactory(){} // RVA: 0x30B0C0
        public void get_PacketGenerator(){} // RVA: 0x30B130
        public void get_NumThreads(){} // RVA: 0x338CD0
        public void set_NumThreads(){} // RVA: 0x338CE0
        public void get_StatusHandler(){} // RVA: 0x4976A0
        public void get_InputStream(){} // RVA: 0x35A740
        public void get_OutputStream(){} // RVA: 0x358730
        public void get_InputSidePacket(){} // RVA: 0x37E0E0
        public void get_OutputSidePacket(){} // RVA: 0x3A5500
        public void get_MaxQueueSize(){} // RVA: 0x59CEC0
        public void set_MaxQueueSize(){} // RVA: 0x59C530
        public void get_ReportDeadlock(){} // RVA: 0x1498640
        public void set_ReportDeadlock(){} // RVA: 0x1C91430
        public void get_InputStreamHandler(){} // RVA: 0x358D50
        public void set_InputStreamHandler(){} // RVA: 0x358D60
        public void get_OutputStreamHandler(){} // RVA: 0x3A5590
        public void set_OutputStreamHandler(){} // RVA: 0x3A55A0
        public void get_Executor(){} // RVA: 0x4C7C50
        public void get_ProfilerConfig(){} // RVA: 0x462D00
        public void set_ProfilerConfig(){} // RVA: 0x464450
        public void get_Package(){} // RVA: 0x31C010
        public void set_Package(){} // RVA: 0x5AFBEC0
        public void get_Type(){} // RVA: 0x796DE0
        public void set_Type(){} // RVA: 0x5AFBFC0
        public void get_Options(){} // RVA: 0xA1C8C0
        public void set_Options(){} // RVA: 0x9AA650
        public void get_GraphOptions(){} // RVA: 0xA085E0
        public void Equals(){} // RVA: 0x5AFC120 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5AFC540
        public void ToString(){} // RVA: 0x5AFC840
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5AFC890
        public void CalculateSize(){} // RVA: 0x5AFCD20
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5AFD890
        public void .cctor(){} // RVA: 0x5AFDF60
    }

    public class CalculatorGraphConfigExtension
    {
        // ── Methods ──
        public void ParseFromTextFormat(){} // RVA: 0x5AD5AC0
    }

    public class CalculatorOptions
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.CalculatorOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Mediapipe.CalculatorOptions> _extensions; // 0x18
        public int _hasBits0; // 0x20
        public bool MergeFieldsDefaultValue; // 0x8
        public bool mergeFields_; // 0x24

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5B02910
        public void get_Descriptor(){} // RVA: 0x5B02970
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B02A30
        public void .ctor(){} // RVA: 0x5B02B20 | overloaded x2
        public void Clone(){} // RVA: 0x5B02CB0
        public void get_MergeFields(){} // RVA: 0x5B02E70
        public void set_MergeFields(){} // RVA: 0x5A6DA10
        public void get_HasMergeFields(){} // RVA: 0x5A69F80
        public void ClearMergeFields(){} // RVA: 0x5A69F90
        public void Equals(){} // RVA: 0x5B02FF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B030C0
        public void ToString(){} // RVA: 0x5B03180
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B031D0
        public void CalculateSize(){} // RVA: 0x5B03270
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B03420
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5B034F0
    }

    public class CalculatorOptionsReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B02420
        public void .cctor(){} // RVA: 0x5B02480
    }

    public class CalculatorReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5AF2520
        public void .cctor(){} // RVA: 0x5AF2580
    }

    public class Classification
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
        public void get_Parser(){} // RVA: 0x5B064F0
        public void get_Descriptor(){} // RVA: 0x5B06550
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B06610
        public void .ctor(){} // RVA: 0x5B06700 | overloaded x2
        public void Clone(){} // RVA: 0x5B068B0
        public void get_Index(){} // RVA: 0x5B06A90
        public void set_Index(){} // RVA: 0x5A5C3A0
        public void get_HasIndex(){} // RVA: 0x5A5C3B0
        public void ClearIndex(){} // RVA: 0x5A5C3C0
        public void get_Score(){} // RVA: 0x5B06B00
        public void set_Score(){} // RVA: 0x5B06B70
        public void get_HasScore(){} // RVA: 0x5A5C450
        public void ClearScore(){} // RVA: 0x5A5C460
        public void get_Label(){} // RVA: 0x5B06B80
        public void set_Label(){} // RVA: 0x5B06BF0
        public void get_HasLabel(){} // RVA: 0x5A67FD0
        public void ClearLabel(){} // RVA: 0x29FDA70
        public void get_DisplayName(){} // RVA: 0x5B06CF0
        public void set_DisplayName(){} // RVA: 0x5B06D60
        public void get_HasDisplayName(){} // RVA: 0x51555E0
        public void ClearDisplayName(){} // RVA: 0x5A68150
        public void Equals(){} // RVA: 0x5B06EC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B07080
        public void ToString(){} // RVA: 0x5B071C0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B07210
        public void CalculateSize(){} // RVA: 0x5B072F0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B07550
        public void .cctor(){} // RVA: 0x5B07680
    }

    public class ClassificationList
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ClassificationList> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int ClassificationFieldNumber;
        public Google.Protobuf.FieldCodec`1<Mediapipe.Classification> _repeated_classification_codec; // 0x8

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B07A00
        public void get_Descriptor(){} // RVA: 0x5B07A60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B07B20
        public void .ctor(){} // RVA: 0x5B07CD0 | overloaded x2
        public void Clone(){} // RVA: 0x5B07E70
        public void get_Classification(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5B08140 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5B081F0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B08240
        public void CalculateSize(){} // RVA: 0x5B08300
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B084F0
        public void .cctor(){} // RVA: 0x5B085F0
    }

    public class ClassificationListCollection
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ClassificationListCollection> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.ClassificationList> _repeated_classificationList_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.ClassificationList> classificationList_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B08970
        public void get_Descriptor(){} // RVA: 0x5B089D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B08A90
        public void .ctor(){} // RVA: 0x5B08C40 | overloaded x2
        public void Clone(){} // RVA: 0x5B08DE0
        public void get_ClassificationList(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5B090B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5B09160
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B091B0
        public void CalculateSize(){} // RVA: 0x5B09270
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B09460
        public void .cctor(){} // RVA: 0x5B09560
    }

    public class ClassificationReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B05BB0
        public void .cctor(){} // RVA: 0x5B05C10
    }

}