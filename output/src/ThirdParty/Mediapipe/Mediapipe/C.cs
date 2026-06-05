// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 160

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class CalculatorGraph
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF85850A0
        public void DeleteMpPtr(){} // RVA: 0x7FFAF85851E0
        public void Initialize(){} // RVA: 0x7FFAF85852A0
        public void ObserveOutputStream(){} // RVA: 0x7FFAF85853E0
        public void AddOutputStreamPoller(){} // RVA: 0x7FFAF2ACD640
        public void StartRun(){} // RVA: 0x7FFAF8585560
        public void WaitUntilDone(){} // RVA: 0x7FFAF8585690
        public void AddPacketToInputStream(){} // RVA: 0x7FFAF2ADDC60
        public void CloseAllPacketSources(){} // RVA: 0x7FFAF85857A0
        public void SetGpuResources(){} // RVA: 0x7FFAF85858B0
    }

    public class CalculatorGraphConfig
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85AAD80
        public void get_Descriptor(){} // RVA: 0x7FFAF85AADE0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85AAEA0
        public void .ctor(){} // RVA: 0x7FFAF85AB550 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85ABE60
        public void get_Node(){} // RVA: 0x7FFAF2D907C0
        public void get_PacketFactory(){} // RVA: 0x7FFAF2DBB0C0
        public void get_PacketGenerator(){} // RVA: 0x7FFAF2DBB130
        public void get_NumThreads(){} // RVA: 0x7FFAF2DE8CD0
        public void set_NumThreads(){} // RVA: 0x7FFAF2DE8CE0
        public void get_StatusHandler(){} // RVA: 0x7FFAF2F476A0
        public void get_InputStream(){} // RVA: 0x7FFAF2E0A740
        public void get_OutputStream(){} // RVA: 0x7FFAF2E08730
        public void get_InputSidePacket(){} // RVA: 0x7FFAF2E2E0E0
        public void get_OutputSidePacket(){} // RVA: 0x7FFAF2E55500
        public void get_MaxQueueSize(){} // RVA: 0x7FFAF304CEC0
        public void set_MaxQueueSize(){} // RVA: 0x7FFAF304C530
        public void get_ReportDeadlock(){} // RVA: 0x7FFAF3F48640
        public void set_ReportDeadlock(){} // RVA: 0x7FFAF4741430
        public void get_InputStreamHandler(){} // RVA: 0x7FFAF2E08D50
        public void set_InputStreamHandler(){} // RVA: 0x7FFAF2E08D60
        public void get_OutputStreamHandler(){} // RVA: 0x7FFAF2E55590
        public void set_OutputStreamHandler(){} // RVA: 0x7FFAF2E555A0
        public void get_Executor(){} // RVA: 0x7FFAF2F77C50
        public void get_ProfilerConfig(){} // RVA: 0x7FFAF2F12D00
        public void set_ProfilerConfig(){} // RVA: 0x7FFAF2F14450
        public void get_Package(){} // RVA: 0x7FFAF2DCC010
        public void set_Package(){} // RVA: 0x7FFAF85ABEC0
        public void get_Type(){} // RVA: 0x7FFAF3246DE0
        public void set_Type(){} // RVA: 0x7FFAF85ABFC0
        public void get_Options(){} // RVA: 0x7FFAF34CC8C0
        public void set_Options(){} // RVA: 0x7FFAF345A650
        public void get_GraphOptions(){} // RVA: 0x7FFAF34B85E0
        public void Equals(){} // RVA: 0x7FFAF85AC120 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF85AC540
        public void ToString(){} // RVA: 0x7FFAF85AC840
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85AC890
        public void CalculateSize(){} // RVA: 0x7FFAF85ACD20
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85AD890
        public void .cctor(){} // RVA: 0x7FFAF85ADF60
    }

    public class CalculatorGraphConfigExtension
    {
        // ── Methods ──
        public void ParseFromTextFormat(){} // RVA: 0x7FFAF8585AC0
    }

    public class CalculatorOptions
    {
        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAF2D907C0
        public void get_Parser(){} // RVA: 0x7FFAF85B2910
        public void get_Descriptor(){} // RVA: 0x7FFAF85B2970
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85B2A30
        public void .ctor(){} // RVA: 0x7FFAF85B2B20 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85B2CB0
        public void get_MergeFields(){} // RVA: 0x7FFAF85B2E70
        public void set_MergeFields(){} // RVA: 0x7FFAF851DA10
        public void get_HasMergeFields(){} // RVA: 0x7FFAF8519F80
        public void ClearMergeFields(){} // RVA: 0x7FFAF8519F90
        public void Equals(){} // RVA: 0x7FFAF85B2FF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF85B30C0
        public void ToString(){} // RVA: 0x7FFAF85B3180
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85B31D0
        public void CalculateSize(){} // RVA: 0x7FFAF85B3270
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85B3420
        public void GetExtension(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAF2ABCE10
        public void SetExtension(){} // RVA: 0x7FFAF2D33FA0
        public void HasExtension(){} // RVA: 0x7FFAF2ABDE40
        public void ClearExtension(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF85B34F0
    }

    public class CalculatorOptionsReflection
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAF85B2420
        public void .cctor(){} // RVA: 0x7FFAF85B2480
    }

    public class CalculatorReflection
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAF85A2520
        public void .cctor(){} // RVA: 0x7FFAF85A2580
    }

    public class Classification
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85B64F0
        public void get_Descriptor(){} // RVA: 0x7FFAF85B6550
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85B6610
        public void .ctor(){} // RVA: 0x7FFAF85B6700 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85B68B0
        public void get_Index(){} // RVA: 0x7FFAF85B6A90
        public void set_Index(){} // RVA: 0x7FFAF850C3A0
        public void get_HasIndex(){} // RVA: 0x7FFAF850C3B0
        public void ClearIndex(){} // RVA: 0x7FFAF850C3C0
        public void get_Score(){} // RVA: 0x7FFAF85B6B00
        public void set_Score(){} // RVA: 0x7FFAF85B6B70
        public void get_HasScore(){} // RVA: 0x7FFAF850C450
        public void ClearScore(){} // RVA: 0x7FFAF850C460
        public void get_Label(){} // RVA: 0x7FFAF85B6B80
        public void set_Label(){} // RVA: 0x7FFAF85B6BF0
        public void get_HasLabel(){} // RVA: 0x7FFAF8517FD0
        public void ClearLabel(){} // RVA: 0x7FFAF54ADA70
        public void get_DisplayName(){} // RVA: 0x7FFAF85B6CF0
        public void set_DisplayName(){} // RVA: 0x7FFAF85B6D60
        public void get_HasDisplayName(){} // RVA: 0x7FFAF7C055E0
        public void ClearDisplayName(){} // RVA: 0x7FFAF8518150
        public void Equals(){} // RVA: 0x7FFAF85B6EC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF85B7080
        public void ToString(){} // RVA: 0x7FFAF85B71C0
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85B7210
        public void CalculateSize(){} // RVA: 0x7FFAF85B72F0
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85B7550
        public void .cctor(){} // RVA: 0x7FFAF85B7680
    }

    public class ClassificationList
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85B7A00
        public void get_Descriptor(){} // RVA: 0x7FFAF85B7A60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85B7B20
        public void .ctor(){} // RVA: 0x7FFAF85B7CD0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85B7E70
        public void get_Classification(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAF85B8140 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF84EDF40
        public void ToString(){} // RVA: 0x7FFAF85B81F0
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85B8240
        public void CalculateSize(){} // RVA: 0x7FFAF85B8300
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85B84F0
        public void .cctor(){} // RVA: 0x7FFAF85B85F0
    }

    public class ClassificationListCollection
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85B8970
        public void get_Descriptor(){} // RVA: 0x7FFAF85B89D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85B8A90
        public void .ctor(){} // RVA: 0x7FFAF85B8C40 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85B8DE0
        public void get_ClassificationList(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAF85B90B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF84EDF40
        public void ToString(){} // RVA: 0x7FFAF85B9160
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85B91B0
        public void CalculateSize(){} // RVA: 0x7FFAF85B9270
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85B9460
        public void .cctor(){} // RVA: 0x7FFAF85B9560
    }

    public class ClassificationReflection
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAF85B5BB0
        public void .cctor(){} // RVA: 0x7FFAF85B5C10
    }

}