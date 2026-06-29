// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 143

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class CalculatorGraph : MpResourceHandle
    {
        // ── Methods ──
        public void AddOutputStreamPoller(){} // RVA: 0x30230B0
        public void .ctor(){} // RVA: 0x654F8E0
        public void DeleteMpPtr(){} // RVA: 0x654FA20
        public void Initialize(){} // RVA: 0x654FAE0
        public void ObserveOutputStream(){} // RVA: 0x654FC20
        public void StartRun(){} // RVA: 0x654FDA0
        public void WaitUntilDone(){} // RVA: 0x654FED0
        public void AddPacketToInputStream(){} // RVA: 0x8943B0
        public void CloseAllPacketSources(){} // RVA: 0x654FFE0
        public void SetGpuResources(){} // RVA: 0x65500F0
    }

    public class CalculatorGraphConfig : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x6575260
        public void get_Descriptor(){} // RVA: 0x65752C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x6575380
        public void .ctor(){} // RVA: 0x6575A30
        public void Clone(){} // RVA: 0x6576300
        public void get_Node(){} // RVA: 0xB465B0
        public void get_PacketFactory(){} // RVA: 0xB700F0
        public void get_PacketGenerator(){} // RVA: 0xB70160
        public void get_NumThreads(){} // RVA: 0xB9E080
        public void set_NumThreads(){} // RVA: 0xB9E090
        public void get_StatusHandler(){} // RVA: 0xD05CA0
        public void get_InputStream(){} // RVA: 0xBC1B30
        public void get_OutputStream(){} // RVA: 0xBBF8F0
        public void get_InputSidePacket(){} // RVA: 0xBE58B0
        public void get_OutputSidePacket(){} // RVA: 0xC0FFC0
        public void get_MaxQueueSize(){} // RVA: 0xD347A0
        public void set_MaxQueueSize(){} // RVA: 0xD34740
        public void get_ReportDeadlock(){} // RVA: 0x1D450E0
        public void set_ReportDeadlock(){} // RVA: 0x1D43780
        public void get_InputStreamHandler(){} // RVA: 0xBBFF90
        public void set_InputStreamHandler(){} // RVA: 0xBBFFA0
        public void get_OutputStreamHandler(){} // RVA: 0xC10050
        public void set_OutputStreamHandler(){} // RVA: 0xC10060
        public void get_Executor(){} // RVA: 0xCD3320
        public void get_ProfilerConfig(){} // RVA: 0xCD48B0
        public void set_ProfilerConfig(){} // RVA: 0xCD3600
        public void get_Package(){} // RVA: 0xB813B0
        public void set_Package(){} // RVA: 0x6576360
        public void get_Type(){} // RVA: 0x1069350
        public void set_Type(){} // RVA: 0x6576460
        public void get_Options(){} // RVA: 0x106A7D0
        public void set_Options(){} // RVA: 0xD5CC70
        public void get_GraphOptions(){} // RVA: 0x106A050
        public void Equals(){} // RVA: 0x65765C0
        public void GetHashCode(){} // RVA: 0x65769E0
        public void ToString(){} // RVA: 0x6576CC0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x6576D10
        public void CalculateSize(){} // RVA: 0x65771A0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x6577D20
        public void .cctor(){} // RVA: 0x65783F0
    }

    public class CalculatorGraphConfigExtension : Object
    {
        // ── Methods ──
        public void ParseFromTextFormat(){} // RVA: 0x6550300
    }

    public class CalculatorOptions : Object
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0xB465B0
        public void get_Parser(){} // RVA: 0x657CD30
        public void get_Descriptor(){} // RVA: 0x657CD90
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x657CE50
        public void .ctor(){} // RVA: 0x657CF40
        public void Clone(){} // RVA: 0x657D0D0
        public void get_MergeFields(){} // RVA: 0x657D290
        public void set_MergeFields(){} // RVA: 0x64E7E10
        public void get_HasMergeFields(){} // RVA: 0x64E43B0
        public void ClearMergeFields(){} // RVA: 0x64E43C0
        public void Equals(){} // RVA: 0x657D410
        public void GetHashCode(){} // RVA: 0x657D4E0
        public void ToString(){} // RVA: 0x657D580
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x657D5D0
        public void CalculateSize(){} // RVA: 0x657D670
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x657D820
        public void GetExtension(){} // RVA: 0x87C540
        public void GetOrInitializeExtension(){} // RVA: 0x87C540
        public void SetExtension(){} // RVA: 0xA94080
        public void HasExtension(){} // RVA: 0x87D350
        public void ClearExtension(){} // RVA: 0x894320
        public void .cctor(){} // RVA: 0x657D8F0
    }

    public class CalculatorOptionsReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x657C880
        public void .cctor(){} // RVA: 0x657C8E0
    }

    public class CalculatorReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x656CC90
        public void .cctor(){} // RVA: 0x656CCF0
    }

    public class Classification : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x6580820
        public void get_Descriptor(){} // RVA: 0x6580880
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x6580940
        public void .ctor(){} // RVA: 0x6580A30
        public void Clone(){} // RVA: 0x6580BE0
        public void get_Index(){} // RVA: 0x6580DC0
        public void set_Index(){} // RVA: 0x64D65C0
        public void get_HasIndex(){} // RVA: 0x64D65D0
        public void ClearIndex(){} // RVA: 0x64D65E0
        public void get_Score(){} // RVA: 0x6580E30
        public void set_Score(){} // RVA: 0x6580EA0
        public void get_HasScore(){} // RVA: 0x64D6670
        public void ClearScore(){} // RVA: 0x64D6680
        public void get_Label(){} // RVA: 0x6580EB0
        public void set_Label(){} // RVA: 0x6580F20
        public void get_HasLabel(){} // RVA: 0x64E22A0
        public void ClearLabel(){} // RVA: 0x34243A0
        public void get_DisplayName(){} // RVA: 0x6581020
        public void set_DisplayName(){} // RVA: 0x6581090
        public void get_HasDisplayName(){} // RVA: 0x5BC22D0
        public void ClearDisplayName(){} // RVA: 0x64E2420
        public void Equals(){} // RVA: 0x65811F0
        public void GetHashCode(){} // RVA: 0x65813B0
        public void ToString(){} // RVA: 0x65814F0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x6581540
        public void CalculateSize(){} // RVA: 0x6581620
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x6581880
        public void .cctor(){} // RVA: 0x65819B0
    }

    public class ClassificationList : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x6581D30
        public void get_Descriptor(){} // RVA: 0x6581D90
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x6581E50
        public void .ctor(){} // RVA: 0x6582000
        public void Clone(){} // RVA: 0x65821A0
        public void get_Classification(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x6582470
        public void GetHashCode(){} // RVA: 0x64B8050
        public void ToString(){} // RVA: 0x6582520
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x6582570
        public void CalculateSize(){} // RVA: 0x6582630
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x6582820
        public void .cctor(){} // RVA: 0x6582920
    }

    public class ClassificationListCollection : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x6582CA0
        public void get_Descriptor(){} // RVA: 0x6582D00
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x6582DC0
        public void .ctor(){} // RVA: 0x6582F70
        public void Clone(){} // RVA: 0x6583110
        public void get_ClassificationList(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x65833E0
        public void GetHashCode(){} // RVA: 0x64B8050
        public void ToString(){} // RVA: 0x6583490
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65834E0
        public void CalculateSize(){} // RVA: 0x65835A0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x6583790
        public void .cctor(){} // RVA: 0x6583890
    }

    public class ClassificationReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x657FF60
        public void .cctor(){} // RVA: 0x657FFC0
    }

}