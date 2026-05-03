// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.UdonAnalytics
// Classes: 4
// Methods: 25

namespace VRC.Core.UdonAnalytics
{
    public class AggregateUdonAnalyticsEvent : UdonAnalyticsEvent
    {
        public System.Collections.Generic.IReadOnlyCollection`1<VRC.Core.UdonAnalytics.IUdonAnalyticsEvent> _aggregatedEvents; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A399510
        public void AggregateEvents(){} // RVA: 0x7FFE8A3995B0
        public void get_AggregatedEvents(){} // RVA: 0x7FFE81178740
    }

    public class IUdonAnalyticsEvent
    {
        // ── Methods ──
        public void get_WorldId(){} // RVA: 0x7FFE80E2E2E0
        public void get_MetricId(){} // RVA: 0x7FFE80E2E2E0
        public void get_Position(){} // RVA: 0x7FFE80E2DCF0
        public void get_Timestamp(){} // RVA: 0x7FFE80E2E2E0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void ToAPIEvent(){} // RVA: 0x7FFE80E2E2E0
    }

    public class UdonAnalyticsCache : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A399830
        public void Update(){} // RVA: 0x7FFE8A399A10
        public void Add(){} // RVA: 0x7FFE8A399B20
        public void DrainEventQueue(){} // RVA: 0x7FFE8A399BC0
        public void Rollup(){} // RVA: 0x7FFE8A399C70
        public void ProcessQueue(){} // RVA: 0x7FFE8A39A4F0
        public void SendBatch(){} // RVA: 0x7FFE8A39A580
        public void Destroy(){} // RVA: 0x7FFE8A39A840
    }

    public class UdonAnalyticsEvent : Object
    {
        public string _worldId; // 0x10
        public string _metricId; // 0x18
        public UnityEngine.Vector3 _position; // 0x20
        public System.DateTime _timestamp; // 0x30
        public int _count; // 0x38

        // ── Methods ──
        public void CreateEvent(){} // RVA: 0x7FFE8A39ACE0
        public void .ctor(){} // RVA: 0x7FFE8A39AD90
        public void get_WorldId(){} // RVA: 0x7FFE81116380
        public void get_MetricId(){} // RVA: 0x7FFE810FE7C0
        public void get_Position(){} // RVA: 0x7FFE81161EE0
        public void get_Timestamp(){} // RVA: 0x7FFE8144E200
        public void get_Count(){} // RVA: 0x7FFE81D46090
        public void ToAPIEvent(){} // RVA: 0x7FFE8A39AE70
    }

}