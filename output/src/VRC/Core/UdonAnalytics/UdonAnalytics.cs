// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.UdonAnalytics
// Classes: 3
// Methods: 17

namespace VRC.Core.UdonAnalytics
{
    public class AggregateUdonAnalyticsEvent : UdonAnalyticsEvent
    {
        public object AggregatedEvents;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD573589A0
        public void AggregateEvents(){} // RVA: 0x7FFD57358A40
        public void get_AggregatedEvents(){} // RVA: 0x7FFD4E3BE740
    }

    public class IUdonAnalyticsEvent
    {
        public object WorldId;
        public object MetricId;
        public object Position;
        public object Timestamp;
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
        public object WorldId;
        public object MetricId;
        public object Position;
        public object Timestamp;
        public object Count;

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