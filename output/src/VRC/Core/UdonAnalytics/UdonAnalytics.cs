// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.UdonAnalytics
// Classes: 6
// Methods: 55

namespace VRC.Core.UdonAnalytics
{
    public class AggregateUdonAnalyticsEvent : UdonAnalyticsEvent
    {
        public object _aggregatedEvents;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5E5050
        public void AggregateEvents(){} // RVA: 0xA5E50F0
        public void get_AggregatedEvents(){} // RVA: 0xBC1B30
    }

    public class AggregateUdonAnalyticsEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IUdonAnalyticsEvent
    {
        // ── Methods ──
        public void get_WorldId(){} // RVA: 0x87C0A0
        public void get_MetricId(){} // RVA: 0x87C0A0
        public void get_Position(){} // RVA: 0x87BEB0
        public void get_Timestamp(){} // RVA: 0x87C0A0
        public void get_Count(){} // RVA: 0x87C130
        public void ToAPIEvent(){} // RVA: 0x87C0A0
    }

    public class UdonAnalyticsCache : Object
    {
        public object Instance;
        public object MaxBatchSize;
        public object ProcessDelaySeconds;
        public object fetchTimer;
        public object _eventQueue;
        public object _batchQueue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5E5370
        public void Update(){} // RVA: 0xA5E5550
        public void Add(){} // RVA: 0xA5E5660
        public void DrainEventQueue(){} // RVA: 0xA5E5700
        public void Rollup(){} // RVA: 0xA5E57B0
        public void ProcessQueue(){} // RVA: 0xA5E6040
        public void SendBatch(){} // RVA: 0xA5E60D0
        public void Destroy(){} // RVA: 0xA5E63A0
    }

    public class UdonAnalyticsEvent : Object
    {
        public object _worldId;
        public object _metricId;
        public object _position;
        public object _timestamp;
        public object _count;

        // ── Methods ──
        public void CreateEvent(){} // RVA: 0xA5E6850
        public void .ctor(){} // RVA: 0xA5E6900
        public void get_WorldId(){} // RVA: 0xB5DBF0
        public void get_MetricId(){} // RVA: 0xB465B0
        public void get_Position(){} // RVA: 0xBA9C00
        public void get_Timestamp(){} // RVA: 0xD33E60
        public void get_Count(){} // RVA: 0x18A0130
        public void ToAPIEvent(){} // RVA: 0xA5E69E0
    }

    public class UdonAnalyticsEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}