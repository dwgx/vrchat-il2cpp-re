// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.UdonAnalytics
// Classes: 4
// Methods: 25

namespace VRC.Core.UdonAnalytics
{
    public class AggregateUdonAnalyticsEvent : UdonAnalyticsEvent
    {
        public System.Collections.Generic.IReadOnlyCollection`1<VRC.Core.UdonAnalytics.IUdonAnalyticsEvent> AggregatedEvents; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF389A0
        public void AggregateEvents(){} // RVA: 0x7FFACBF38A40
        public void get_AggregatedEvents(){} // RVA: 0x7FFAC2F9E740
    }

    public class IUdonAnalyticsEvent
    {
        public object WorldId;
        public object MetricId;
        public object Position;
        public object Timestamp;
        public object Count;

        // ── Methods ──
        public void get_WorldId(){} // RVA: 0x7FFAC2C58E90
        public void get_MetricId(){} // RVA: 0x7FFAC2C58E90
        public void get_Position(){} // RVA: 0x7FFAC2C588A0
        public void get_Timestamp(){} // RVA: 0x7FFAC2C58E90
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void ToAPIEvent(){} // RVA: 0x7FFAC2C58E90
    }

    public class UdonAnalyticsCache : Object
    {
        public VRC.Core.UdonAnalytics.UdonAnalyticsCache Instance;
        public int MaxBatchSize;
        public float ProcessDelaySeconds;
        public float fetchTimer; // 0x10
        public System.Collections.Generic.Queue`1<VRC.Core.UdonAnalytics.UdonAnalyticsEvent> _eventQueue; // 0x18
        public System.Collections.Generic.Queue`1<VRC.Core.UdonAnalytics.AggregateUdonAnalyticsEvent> _batchQueue; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF38CC0
        public void Update(){} // RVA: 0x7FFACBF38EA0
        public void Add(){} // RVA: 0x7FFACBF38FB0
        public void DrainEventQueue(){} // RVA: 0x7FFACBF39050
        public void Rollup(){} // RVA: 0x7FFACBF39100
        public void ProcessQueue(){} // RVA: 0x7FFACBF39980
        public void SendBatch(){} // RVA: 0x7FFACBF39A10
        public void Destroy(){} // RVA: 0x7FFACBF39CD0
    }

    public class UdonAnalyticsEvent : Object
    {
        public string WorldId; // 0x10
        public string MetricId; // 0x18
        public UnityEngine.Vector3 Position; // 0x20
        public System.DateTime Timestamp; // 0x30
        public int Count; // 0x38

        // ── Methods ──
        public void CreateEvent(){} // RVA: 0x7FFACBF3A170
        public void .ctor(){} // RVA: 0x7FFACBF3A220
        public void get_WorldId(){} // RVA: 0x7FFAC2F3C380
        public void get_MetricId(){} // RVA: 0x7FFAC2F247C0
        public void get_Position(){} // RVA: 0x7FFAC2F87EE0
        public void get_Timestamp(){} // RVA: 0x7FFAC31D95E0
        public void get_Count(){} // RVA: 0x7FFAC358A870
        public void ToAPIEvent(){} // RVA: 0x7FFACBF3A300
    }

}