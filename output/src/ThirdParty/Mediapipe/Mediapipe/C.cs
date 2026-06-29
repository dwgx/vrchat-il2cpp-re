// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 143

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class CalculatorGraph : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8C2730
        public void DeleteMpPtr(){} // RVA: 0x7AD8C2870
        public void Initialize(){} // RVA: 0x7AD8C2930
        public void ObserveOutputStream(){} // RVA: 0x7AD8C2A70
        public void AddOutputStreamPoller(){} // RVA: 0x7AA4040C0
        public void StartRun(){} // RVA: 0x7AD8C2BF0
        public void WaitUntilDone(){} // RVA: 0x7AD8C2D20
        public void AddPacketToInputStream(){} // RVA: 0x7A7E18890
        public void CloseAllPacketSources(){} // RVA: 0x7AD8C2E30
        public void SetGpuResources(){} // RVA: 0x7AD8C2F40
    }

    public class CalculatorGraphConfig : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD8E82F0
        public void get_Descriptor(){} // RVA: 0x7AD8E8350
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8E8410
        public void .ctor(){} // RVA: 0x7AD8E8AC0
        public void Clone(){} // RVA: 0x7AD8E9390
        public void get_Node(){} // RVA: 0x7A80DA7B0
        public void get_PacketFactory(){} // RVA: 0x7A81052C0
        public void get_PacketGenerator(){} // RVA: 0x7A8105330
        public void get_NumThreads(){} // RVA: 0x7A8133100
        public void set_NumThreads(){} // RVA: 0x7A8133110
        public void get_StatusHandler(){} // RVA: 0x7A8292C30
        public void get_InputStream(){} // RVA: 0x7A8154D80
        public void get_OutputStream(){} // RVA: 0x7A8152D80
        public void get_InputSidePacket(){} // RVA: 0x7A8178B90
        public void get_OutputSidePacket(){} // RVA: 0x7A81A0050
        public void get_MaxQueueSize(){} // RVA: 0x7A83562E0
        public void set_MaxQueueSize(){} // RVA: 0x7A8355940
        public void get_ReportDeadlock(){} // RVA: 0x7A9250CD0
        public void set_ReportDeadlock(){} // RVA: 0x7A9A93860
        public void get_InputStreamHandler(){} // RVA: 0x7A8153390
        public void set_InputStreamHandler(){} // RVA: 0x7A81533A0
        public void get_OutputStreamHandler(){} // RVA: 0x7A81A00E0
        public void set_OutputStreamHandler(){} // RVA: 0x7A81A00F0
        public void get_Executor(){} // RVA: 0x7A82C2060
        public void get_ProfilerConfig(){} // RVA: 0x7A825E100
        public void set_ProfilerConfig(){} // RVA: 0x7A825F860
        public void get_Package(){} // RVA: 0x7A81163D0
        public void set_Package(){} // RVA: 0x7AD8E93F0
        public void get_Type(){} // RVA: 0x7A8555100
        public void set_Type(){} // RVA: 0x7AD8E94F0
        public void get_Options(){} // RVA: 0x7A87D9C10
        public void set_Options(){} // RVA: 0x7A8744720
        public void get_GraphOptions(){} // RVA: 0x7A87C5850
        public void Equals(){} // RVA: 0x7AD8E9650
        public void GetHashCode(){} // RVA: 0x7AD8E9A70
        public void ToString(){} // RVA: 0x7AD8E9D70
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD8E9DC0
        public void CalculateSize(){} // RVA: 0x7AD8EA250
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8EADD0
        public void .cctor(){} // RVA: 0x7AD8EB4A0
    }

    public class CalculatorGraphConfigExtension : Object
    {
        // ── Methods ──
        public void ParseFromTextFormat(){} // RVA: 0x7AD8C3150
    }

    public class CalculatorOptions : Object
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7A80DA7B0
        public void get_Parser(){} // RVA: 0x7AD8EFE20
        public void get_Descriptor(){} // RVA: 0x7AD8EFE80
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8EFF40
        public void .ctor(){} // RVA: 0x7AD8F0030
        public void Clone(){} // RVA: 0x7AD8F01C0
        public void get_MergeFields(){} // RVA: 0x7AD8F0380
        public void set_MergeFields(){} // RVA: 0x7AD85A6B0
        public void get_HasMergeFields(){} // RVA: 0x7AD856C20
        public void ClearMergeFields(){} // RVA: 0x7AD856C30
        public void Equals(){} // RVA: 0x7AD8F0500
        public void GetHashCode(){} // RVA: 0x7AD8F05D0
        public void ToString(){} // RVA: 0x7AD8F0690
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD8F06E0
        public void CalculateSize(){} // RVA: 0x7AD8F0780
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8F0930
        public void GetExtension(){} // RVA: 0x7A7E00B20
        public void GetOrInitializeExtension(){} // RVA: 0x7A7E00B20
        public void SetExtension(){} // RVA: 0x7A8051B10
        public void HasExtension(){} // RVA: 0x7A7E019D0
        public void ClearExtension(){} // RVA: 0x7A7E18800
        public void .cctor(){} // RVA: 0x7AD8F0A00
    }

    public class CalculatorOptionsReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7AD8EF930
        public void .cctor(){} // RVA: 0x7AD8EF990
    }

    public class CalculatorReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7AD8DFBB0
        public void .cctor(){} // RVA: 0x7AD8DFC10
    }

    public class Classification : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD8F3A00
        public void get_Descriptor(){} // RVA: 0x7AD8F3A60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8F3B20
        public void .ctor(){} // RVA: 0x7AD8F3C10
        public void Clone(){} // RVA: 0x7AD8F3DC0
        public void get_Index(){} // RVA: 0x7AD8F3FA0
        public void set_Index(){} // RVA: 0x7AD848D30
        public void get_HasIndex(){} // RVA: 0x7AD848D40
        public void ClearIndex(){} // RVA: 0x7AD848D50
        public void get_Score(){} // RVA: 0x7AD8F4010
        public void set_Score(){} // RVA: 0x7AD8F4080
        public void get_HasScore(){} // RVA: 0x7AD848DE0
        public void ClearScore(){} // RVA: 0x7AD848DF0
        public void get_Label(){} // RVA: 0x7AD8F4090
        public void set_Label(){} // RVA: 0x7AD8F4100
        public void get_HasLabel(){} // RVA: 0x7AD854AF0
        public void ClearLabel(){} // RVA: 0x7AA7FD9C0
        public void get_DisplayName(){} // RVA: 0x7AD8F4200
        public void set_DisplayName(){} // RVA: 0x7AD8F4270
        public void get_HasDisplayName(){} // RVA: 0x7ACDAB700
        public void ClearDisplayName(){} // RVA: 0x7AD854C70
        public void Equals(){} // RVA: 0x7AD8F43D0
        public void GetHashCode(){} // RVA: 0x7AD8F4590
        public void ToString(){} // RVA: 0x7AD8F46D0
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD8F4720
        public void CalculateSize(){} // RVA: 0x7AD8F4800
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8F4A60
        public void .cctor(){} // RVA: 0x7AD8F4B90
    }

    public class ClassificationList : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD8F4F10
        public void get_Descriptor(){} // RVA: 0x7AD8F4F70
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8F5030
        public void .ctor(){} // RVA: 0x7AD8F51E0
        public void Clone(){} // RVA: 0x7AD8F5380
        public void get_Classification(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7AD8F5650
        public void GetHashCode(){} // RVA: 0x7AD82A430
        public void ToString(){} // RVA: 0x7AD8F5700
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD8F5750
        public void CalculateSize(){} // RVA: 0x7AD8F5810
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8F5A00
        public void .cctor(){} // RVA: 0x7AD8F5B00
    }

    public class ClassificationListCollection : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD8F5E80
        public void get_Descriptor(){} // RVA: 0x7AD8F5EE0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8F5FA0
        public void .ctor(){} // RVA: 0x7AD8F6150
        public void Clone(){} // RVA: 0x7AD8F62F0
        public void get_ClassificationList(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7AD8F65C0
        public void GetHashCode(){} // RVA: 0x7AD82A430
        public void ToString(){} // RVA: 0x7AD8F6670
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD8F66C0
        public void CalculateSize(){} // RVA: 0x7AD8F6780
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8F6970
        public void .cctor(){} // RVA: 0x7AD8F6A70
    }

    public class ClassificationReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7AD8F30C0
        public void .cctor(){} // RVA: 0x7AD8F3120
    }

}