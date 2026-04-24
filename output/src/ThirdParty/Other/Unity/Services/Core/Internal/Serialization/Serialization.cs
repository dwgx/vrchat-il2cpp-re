// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Internal.Serialization
// Classes: 2
// Methods: 4

namespace ThirdParty.Other.Unity.Services.Core.Internal.Serialization
{
    public class IJsonSerializer
    {
        // ── Methods ──
        public void DeserializeObject(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NewtonsoftSerializer : Object
    {
        public bool _startCalled; // 0x20
        public ulong _requestId; // 0x28
        public ation_4 <Space>k__BackingField; // 0x30
        public ce <Uuid>k__BackingField; // 0x38
        public URA.DateTime<ce,ion_30> SpatialAnchors;
        public URA.DateTime<ulong,ion_30> CreationRequests; // 0x8
        public URA.DateTime<ulong,on_61> SingleAnchorCompletionDelegates; // 0x10
        public URA.DateTime<ulong,rectoryInformation<s,bool>> LocalizationDelegates; // 0x18
        public URA.DateTime<ulong,ileFullDirectoryInformation<s[]>> Queries; // 0x20
        public URA.woDigitYearMax<s> UnboundAnchorBuffer; // 0x28
        public tion_[] ComponentTypeBuffer; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
        public void DeserializeObject(){} // RVA: 0x7FFD4E2ADC40
    }

}