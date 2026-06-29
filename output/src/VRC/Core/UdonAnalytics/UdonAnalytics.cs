// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.UdonAnalytics
// Classes: 6
// Methods: 56

namespace VRC.Core.UdonAnalytics
{
    public class AggregateUdonAnalyticsEvent : UdonAnalyticsEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1778E10
        public void AggregateEvents(){} // RVA: 0x7B1778EB0
        public void get_AggregatedEvents(){} // RVA: 0x7A8154D80
    }

    public class AggregateUdonAnalyticsEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IUdonAnalyticsEvent
    {
        // ── Methods ──
        public void get_WorldId(){} // RVA: 0x7A7E00680
        public void get_MetricId(){} // RVA: 0x7A7E00680
        public void get_Position(){} // RVA: 0x7A7E00490
        public void get_Timestamp(){} // RVA: 0x7A7E00680
        public void get_Count(){} // RVA: 0x7A7E00710
        public void ToAPIEvent(){} // RVA: 0x7A7E00680
    }

    public class UdonAnalyticsCache : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1779130
        public void Update(){} // RVA: 0x7B1779310
        public void Add(){} // RVA: 0x7B1779420
        public void DrainEventQueue(){} // RVA: 0x7B17794C0
        public void Rollup(){} // RVA: 0x7B1779570
        public void ProcessQueue(){} // RVA: 0x7B1779E00
        public void SendBatch(){} // RVA: 0x7B1779E90
        public void Destroy(){} // RVA: 0x7B177A160
        public void Instance(){} // RVA: 0x7B419A748
    }

    public class UdonAnalyticsEvent : Object
    {
        // ── Methods ──
        public void CreateEvent(){} // RVA: 0x7B177A610
        public void .ctor(){} // RVA: 0x7B177A6C0
        public void get_WorldId(){} // RVA: 0x7A80F2570
        public void get_MetricId(){} // RVA: 0x7A80DA7B0
        public void get_Position(){} // RVA: 0x7A813E480
        public void get_Timestamp(){} // RVA: 0x7A83F69F0
        public void get_Count(){} // RVA: 0x7A8D863F0
        public void ToAPIEvent(){} // RVA: 0x7B177A7A0
    }

    public class UdonAnalyticsEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}