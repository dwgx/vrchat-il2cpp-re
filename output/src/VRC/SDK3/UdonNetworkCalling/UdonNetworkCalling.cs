// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.UdonNetworkCalling
// Classes: 5
// Methods: 44

namespace VRC.SDK3.UdonNetworkCalling
{
    public class NetworkCallableAttribute : Attribute
    {
        // ── Methods ──
        public void get_MaxEventsPerSecond(){} // RVA: 0x7A8124910
        public void set_MaxEventsPerSecond(){} // RVA: 0x7A80DA0C0
        public void .ctor(){} // RVA: 0x7A80DA0C0
    }

    public class NetworkCalling : Object
    {
        // ── Methods ──
        public void get_InNetworkCall(){} // RVA: 0x7B183A9B0
        public void set_InNetworkCall(){} // RVA: 0x7B183AA10
        public void get_CallingPlayer(){} // RVA: 0x7B183AA70
        public void set_CallingPlayer(){} // RVA: 0x7B183AAD0
        public void get_SendCustomNetworkEventProxy(){} // RVA: 0x7B183AB90
        public void set_SendCustomNetworkEventProxy(){} // RVA: 0x7B183ABF0
        public void get_GetQueuedEventsProxy(){} // RVA: 0x7B183ACB0
        public void set_GetQueuedEventsProxy(){} // RVA: 0x7B183AD10
        public void get_GetAllQueuedEventsProxy(){} // RVA: 0x7B183ADD0
        public void set_GetAllQueuedEventsProxy(){} // RVA: 0x7B183AE30
        public void CheckMainThread(){} // RVA: 0x7B183AEF0
        public void SendCustomNetworkEvent(){} // RVA: 0x7B183C610
        public void SendCustomNetworkEventInternal(){} // RVA: 0x7B183CAB0
        public void WithNetworkCallingContext(){} // RVA: 0x7B183CC10
        public void GetQueuedEvents(){} // RVA: 0x7B183CD70
        public void GetAllQueuedEvents(){} // RVA: 0x7B183CE90
        public void .cctor(){} // RVA: 0x7B183CFA0
    }

    public class NetworkCallingEntrypointMetadata : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void get_MaxEventsPerSecond(){} // RVA: 0x7A8124910
        public void get_Parameters(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7B183D290
        public void Validate(){} // RVA: 0x7B183D3D0
        public void ValidateOnce(){} // RVA: 0x7B183D9B0
    }

    public class NetworkCallingEntrypointMetadata[] : Array
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

    public class NetworkCallingParameterMetadata : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_Type(){} // RVA: 0x7A80F26D0
        public void .ctor(){} // RVA: 0x7B183D9D0
    }

}