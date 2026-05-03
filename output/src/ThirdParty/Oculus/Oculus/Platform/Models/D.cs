// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 3
// Methods: 23

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class DeserializableList`1 : Object
    {
        public System.Collections.Generic.List`1<T> _Data;
        public string _NextUrl;
        public string _PreviousUrl;
        public System.Collections.Generic.List`1<Oculus.Platform.Models.AchievementDefinition> _Data; // 0x10
        public string _NextUrl; // 0x18
        public string _PreviousUrl; // 0x20
        public object field_6; // 0x3478
        public object field_7; // 0x710

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void GetEnumerator1(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void get_Data(){} // RVA: 0x7FFE80E2E2E0
        public void get_HasNextPage(){} // RVA: 0x7FFE80E2F150
        public void get_HasPreviousPage(){} // RVA: 0x7FFE80E2F150
        public void get_NextUrl(){} // RVA: 0x7FFE80E2E2E0
        public void get_PreviousUrl(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class Destination : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C281C0
    }

    public class DestinationList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C28500
    }

}