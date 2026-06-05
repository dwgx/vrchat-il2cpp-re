// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.UdonAnalytics
// Classes: 4
// Methods: 25

namespace VRC.Core.UdonAnalytics
{
    public class AggregateUdonAnalyticsEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC3ED350
        public void AggregateEvents(){} // RVA: 0x7FFAFC3ED3F0
        public void get_AggregatedEvents(){} // RVA: 0x7FFAF2E0A740
    }

    public class IUdonAnalyticsEvent
    {
        // ── Methods ──
        public void get_WorldId(){} // RVA: 0x7FFAF2ABCD60
        public void get_MetricId(){} // RVA: 0x7FFAF2ABCD60
        public void get_Position(){} // RVA: 0x7FFAF2ABC770
        public void get_Timestamp(){} // RVA: 0x7FFAF2ABCD60
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void ToAPIEvent(){} // RVA: 0x7FFAF2ABCD60
    }

    public class UdonAnalyticsCache
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC3ED670
        public void Update(){} // RVA: 0x7FFAFC3ED850
        public void Add(){} // RVA: 0x7FFAFC3ED960
        public void DrainEventQueue(){} // RVA: 0x7FFAFC3EDA00
        public void Rollup(){} // RVA: 0x7FFAFC3EDAB0
        public void ProcessQueue(){} // RVA: 0x7FFAFC3EE330
        public void SendBatch(){} // RVA: 0x7FFAFC3EE3C0
        public void Destroy(){} // RVA: 0x7FFAFC3EE680
    }

    public class UdonAnalyticsEvent
    {
        // ── Methods ──
        public void CreateEvent(){} // RVA: 0x7FFAFC3EEB20
        public void .ctor(){} // RVA: 0x7FFAFC3EEBD0
        public void get_WorldId(){} // RVA: 0x7FFAF2DA8380
        public void get_MetricId(){} // RVA: 0x7FFAF2D907C0
        public void get_Position(){} // RVA: 0x7FFAF2DF3EE0
        public void get_Timestamp(){} // RVA: 0x7FFAF30E74D0
        public void get_Count(){} // RVA: 0x7FFAF3A8C9F0
        public void ToAPIEvent(){} // RVA: 0x7FFAFC3EECB0
    }

}