// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.UdonAnalytics
// Classes: 3
// Methods: 17

namespace VRC.Core.UdonAnalytics
{
    public class AggregateUdonAnalyticsEvent : UdonAnalyticsEvent
    {
        public System.Collections.Generic.IReadOnlyCollection`1<VRC.Core.UdonAnalytics.IUdonAnalyticsEvent> AggregatedEvents; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD573589A0
        public void AggregateEvents(){} // RVA: 0x7FFD57358A40
        public void get_AggregatedEvents(){} // RVA: 0x7FFD4E3BE740
    }

    public class IUdonAnalyticsEvent
    {
        public int WorldId;
        public System.Collections.Generic.KeyValuePair`2<string,object> MetricId;
        public LogValues`3<U,V,T> Position;
        public int Timestamp;
        public object Count;

        // ── Methods ──
        public void get_WorldId(){} // RVA: 0x7FFD4E078E90
        public void get_MetricId(){} // RVA: 0x7FFD4E078E90
        public void get_Position(){} // RVA: 0x7FFD4E0788A0
        public void get_Timestamp(){} // RVA: 0x7FFD4E078E90
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void ToAPIEvent(){} // RVA: 0x7FFD4E078E90
    }

    public class UdonAnalyticsEvent : Object
    {
        public string WorldId; // 0x10
        public string MetricId; // 0x18
        public UnityEngine.Vector3 Position; // 0x20
        public System.DateTime Timestamp; // 0x30
        public int Count; // 0x38

        // ── Methods ──
        public void CreateEvent(){} // RVA: 0x7FFD5735A170
        public void .ctor(){} // RVA: 0x7FFD5735A220
        public void get_WorldId(){} // RVA: 0x7FFD4E35C380
        public void get_MetricId(){} // RVA: 0x7FFD4E3447C0
        public void get_Position(){} // RVA: 0x7FFD4E3A7EE0
        public void get_Timestamp(){} // RVA: 0x7FFD4E5F95E0
        public void get_Count(){} // RVA: 0x7FFD4E9AA870
        public void ToAPIEvent(){} // RVA: 0x7FFD5735A300
    }

}