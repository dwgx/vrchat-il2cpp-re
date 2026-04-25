// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 160

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class CalculatorGraph : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC826C5B0
        public void DeleteMpPtr(){} // RVA: 0x7FFAC826C6F0
        public void Initialize(){} // RVA: 0x7FFAC826C7B0
        public void ObserveOutputStream(){} // RVA: 0x7FFAC826C8F0
        public void AddOutputStreamPoller(){} // RVA: 0x7FFAC2C696F0
        public void StartRun(){} // RVA: 0x7FFAC826CA70
        public void WaitUntilDone(){} // RVA: 0x7FFAC826CBA0
        public void AddPacketToInputStream(){} // RVA: 0x7FFAC2C79B30
        public void CloseAllPacketSources(){} // RVA: 0x7FFAC826CCB0
        public void SetGpuResources(){} // RVA: 0x7FFAC826CDC0
    }

    public class CalculatorGraphConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.CalculatorGraphConfig> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.FieldCodec`1<Node> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Node> Node; // 0x18
        public Google.Protobuf.FieldCodec`1<Mediapipe.PacketFactoryConfig> PacketFactory; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.PacketFactoryConfig> PacketGenerator; // 0x20
        public Google.Protobuf.FieldCodec`1<Mediapipe.PacketGeneratorConfig> NumThreads; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.PacketGeneratorConfig> StatusHandler; // 0x28
        public int InputStream; // 0x30
        public Google.Protobuf.FieldCodec`1<Mediapipe.StatusHandlerConfig> OutputStream; // 0x20
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.StatusHandlerConfig> InputSidePacket; // 0x38
        public Google.Protobuf.FieldCodec`1<string> OutputSidePacket; // 0x28
        public Google.Protobuf.Collections.RepeatedField`1<string> MaxQueueSize; // 0x40
        public Google.Protobuf.FieldCodec`1<string> ReportDeadlock; // 0x30
        public Google.Protobuf.Collections.RepeatedField`1<string> InputStreamHandler; // 0x48
        public Google.Protobuf.FieldCodec`1<string> OutputStreamHandler; // 0x38
        public Google.Protobuf.Collections.RepeatedField`1<string> Executor; // 0x50
        public Google.Protobuf.FieldCodec`1<string> ProfilerConfig; // 0x40
        public Google.Protobuf.Collections.RepeatedField`1<string> Package; // 0x58
        public int Type; // 0x60
        public bool Options; // 0x64
        public Mediapipe.InputStreamHandlerConfig GraphOptions; // 0x68
        public Mediapipe.OutputStreamHandlerConfig outputStreamHandler_; // 0x70
        public Google.Protobuf.FieldCodec`1<Mediapipe.ExecutorConfig> _repeated_executor_codec; // 0x48
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.ExecutorConfig> executor_; // 0x78
        public Mediapipe.ProfilerConfig profilerConfig_; // 0x80
        public string package_; // 0x88
        public string type_; // 0x90
        public Mediapipe.MediaPipeOptions options_; // 0x98
        public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Any> _repeated_graphOptions_codec; // 0x50
        public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Any> graphOptions_; // 0xA0

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC8292290
        public void get_Descriptor(){} // RVA: 0x7FFAC82922F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82923B0
        public void .ctor(){} // RVA: 0x7FFAC8292A60 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8293370
        public void get_Node(){} // RVA: 0x7FFAC2F247C0
        public void get_PacketFactory(){} // RVA: 0x7FFAC2F4F0C0
        public void get_PacketGenerator(){} // RVA: 0x7FFAC2F4F130
        public void get_NumThreads(){} // RVA: 0x7FFAC2F7CCD0
        public void set_NumThreads(){} // RVA: 0x7FFAC2F7CCE0
        public void get_StatusHandler(){} // RVA: 0x7FFAC31D0140
        public void get_InputStream(){} // RVA: 0x7FFAC2F9E740
        public void get_OutputStream(){} // RVA: 0x7FFAC2F9C730
        public void get_InputSidePacket(){} // RVA: 0x7FFAC2FC20E0
        public void get_OutputSidePacket(){} // RVA: 0x7FFAC2FE9500
        public void get_MaxQueueSize(){} // RVA: 0x7FFAC3138C20
        public void set_MaxQueueSize(){} // RVA: 0x7FFAC3138C10
        public void get_ReportDeadlock(){} // RVA: 0x7FFAC3F45FE0
        public void set_ReportDeadlock(){} // RVA: 0x7FFAC47BAB40
        public void get_InputStreamHandler(){} // RVA: 0x7FFAC2F9CD50
        public void set_InputStreamHandler(){} // RVA: 0x7FFAC2F9CD60
        public void get_OutputStreamHandler(){} // RVA: 0x7FFAC2FE9590
        public void set_OutputStreamHandler(){} // RVA: 0x7FFAC2FE95A0
        public void get_Executor(){} // RVA: 0x7FFAC30E5600
        public void get_ProfilerConfig(){} // RVA: 0x7FFAC32EF410
        public void set_ProfilerConfig(){} // RVA: 0x7FFAC34D4AA0
        public void get_Package(){} // RVA: 0x7FFAC2F60010
        public void set_Package(){} // RVA: 0x7FFAC82933D0
        public void get_Type(){} // RVA: 0x7FFAC32EF640
        public void set_Type(){} // RVA: 0x7FFAC82934D0
        public void get_Options(){} // RVA: 0x7FFAC354DFB0
        public void set_Options(){} // RVA: 0x7FFAC354E3C0
        public void get_GraphOptions(){} // RVA: 0x7FFAC3543900
        public void Equals(){} // RVA: 0x7FFAC8293630 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8293A50
        public void ToString(){} // RVA: 0x7FFAC8293D50
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8293DA0
        public void CalculateSize(){} // RVA: 0x7FFAC8294230
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8294DA0
        public void .cctor(){} // RVA: 0x7FFAC8295470
    }

    public class CalculatorGraphConfigExtension : Object
    {
        // ── Methods ──
        public void ParseFromTextFormat(){} // RVA: 0x7FFAC826CFD0
    }

    public class CalculatorOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.CalculatorOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Mediapipe.CalculatorOptions> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool MergeFields; // 0x8
        public bool HasMergeFields; // 0x24

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC8299E20
        public void get_Descriptor(){} // RVA: 0x7FFAC8299E80
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8299F40
        public void .ctor(){} // RVA: 0x7FFAC829A030 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC829A1C0
        public void get_MergeFields(){} // RVA: 0x7FFAC829A380
        public void set_MergeFields(){} // RVA: 0x7FFAC8204E30
        public void get_HasMergeFields(){} // RVA: 0x7FFAC8201340
        public void ClearMergeFields(){} // RVA: 0x7FFAC8201350
        public void Equals(){} // RVA: 0x7FFAC829A500 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC829A5D0
        public void ToString(){} // RVA: 0x7FFAC829A690
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC829A6E0
        public void CalculateSize(){} // RVA: 0x7FFAC829A780
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC829A930
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC829AA00
    }

    public class CalculatorOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC8299930
        public void .cctor(){} // RVA: 0x7FFAC8299990
    }

    public class CalculatorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC8289A30
        public void .cctor(){} // RVA: 0x7FFAC8289A90
    }

    public class Classification : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Classification> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int Index;
        public int HasIndex; // 0x8
        public int Score; // 0x1C
        public int HasScore;
        public float Label; // 0xC
        public float HasLabel; // 0x20
        public int DisplayName;
        public string HasDisplayName; // 0x10
        public string label_; // 0x28
        public int DisplayNameFieldNumber;
        public string DisplayNameDefaultValue; // 0x18
        public string displayName_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC829DA00
        public void get_Descriptor(){} // RVA: 0x7FFAC829DA60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC829DB20
        public void .ctor(){} // RVA: 0x7FFAC829DC10 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC829DDC0
        public void get_Index(){} // RVA: 0x7FFAC829DFA0
        public void set_Index(){} // RVA: 0x7FFAC81F3760
        public void get_HasIndex(){} // RVA: 0x7FFAC81F3770
        public void ClearIndex(){} // RVA: 0x7FFAC81F3780
        public void get_Score(){} // RVA: 0x7FFAC829E010
        public void set_Score(){} // RVA: 0x7FFAC829E080
        public void get_HasScore(){} // RVA: 0x7FFAC81F3810
        public void ClearScore(){} // RVA: 0x7FFAC81F3820
        public void get_Label(){} // RVA: 0x7FFAC829E090
        public void set_Label(){} // RVA: 0x7FFAC829E100
        public void get_HasLabel(){} // RVA: 0x7FFAC81FF390
        public void ClearLabel(){} // RVA: 0x7FFAC53F2F70
        public void get_DisplayName(){} // RVA: 0x7FFAC829E200
        public void set_DisplayName(){} // RVA: 0x7FFAC829E270
        public void get_HasDisplayName(){} // RVA: 0x7FFAC781E0A0
        public void ClearDisplayName(){} // RVA: 0x7FFAC81FF510
        public void Equals(){} // RVA: 0x7FFAC829E3D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC829E590
        public void ToString(){} // RVA: 0x7FFAC829E6D0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC829E720
        public void CalculateSize(){} // RVA: 0x7FFAC829E800
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC829EA60
        public void .cctor(){} // RVA: 0x7FFAC829EB90
    }

    public class ClassificationList : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ClassificationList> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor;
        public Google.Protobuf.FieldCodec`1<Mediapipe.Classification> Classification; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.Classification> classification_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC829EF10
        public void get_Descriptor(){} // RVA: 0x7FFAC829EF70
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC829F030
        public void .ctor(){} // RVA: 0x7FFAC829F1E0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC829F380
        public void get_Classification(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC829F650 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC829F700
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC829F750
        public void CalculateSize(){} // RVA: 0x7FFAC829F810
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC829FA00
        public void .cctor(){} // RVA: 0x7FFAC829FB00
    }

    public class ClassificationListCollection : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ClassificationListCollection> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.ClassificationList> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.ClassificationList> ClassificationList; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC829FE80
        public void get_Descriptor(){} // RVA: 0x7FFAC829FEE0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC829FFA0
        public void .ctor(){} // RVA: 0x7FFAC82A0150 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82A02F0
        public void get_ClassificationList(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC82A05C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC82A0670
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82A06C0
        public void CalculateSize(){} // RVA: 0x7FFAC82A0780
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82A0970
        public void .cctor(){} // RVA: 0x7FFAC82A0A70
    }

    public class ClassificationReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC829D0C0
        public void .cctor(){} // RVA: 0x7FFAC829D120
    }

}