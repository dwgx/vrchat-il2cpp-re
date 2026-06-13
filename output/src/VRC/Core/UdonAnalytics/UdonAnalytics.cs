// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.UdonAnalytics
// Classes: 4
// Methods: 25

namespace VRC.Core.UdonAnalytics
{
    public class AggregateUdonAnalyticsEvent
    {
        public System.Collections.Generic.IReadOnlyCollection`1<VRC.Core.UdonAnalytics.IUdonAnalyticsEvent> <AggregatedEvents>k__BackingField; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x993D350
        public void AggregateEvents(){} // RVA: 0x993D3F0
        public void get_AggregatedEvents(){} // RVA: 0x35A740
    }

    public class IUdonAnalyticsEvent
    {
        // ── Methods ──
        public void get_WorldId(){} // RVA: 0xCD60
        public void get_MetricId(){} // RVA: 0xCD60
        public void get_Position(){} // RVA: 0xC770
        public void get_Timestamp(){} // RVA: 0xCD60
        public void get_Count(){} // RVA: 0xD840
        public void ToAPIEvent(){} // RVA: 0xCD60
    }

    public class UdonAnalyticsCache
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x993D670
        public void Update(){} // RVA: 0x993D850
        public void Add(){} // RVA: 0x993D960
        public void DrainEventQueue(){} // RVA: 0x993DA00
        public void Rollup(){} // RVA: 0x993DAB0
        public void ProcessQueue(){} // RVA: 0x993E330
        public void SendBatch(){} // RVA: 0x993E3C0
        public void Destroy(){} // RVA: 0x993E680
    }

    public class UdonAnalyticsEvent
    {
        public string <WorldId>k__BackingField; // 0x10
        public string <MetricId>k__BackingField; // 0x18
        public UnityEngine.Vector3 <Position>k__BackingField; // 0x20
        public System.DateTime <Timestamp>k__BackingField; // 0x30
        public int <Count>k__BackingField; // 0x38

        // ── Methods ──
        public void CreateEvent(){} // RVA: 0x993EB20
        public void .ctor(){} // RVA: 0x993EBD0
        public void get_WorldId(){} // RVA: 0x2F8380
        public void get_MetricId(){} // RVA: 0x2E07C0
        public void get_Position(){} // RVA: 0x343EE0
        public void get_Timestamp(){} // RVA: 0x6374D0
        public void get_Count(){} // RVA: 0xFDC9F0
        public void ToAPIEvent(){} // RVA: 0x993ECB0
    }

}