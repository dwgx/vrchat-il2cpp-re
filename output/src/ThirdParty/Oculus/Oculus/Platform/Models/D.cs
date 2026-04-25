// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 3
// Methods: 23

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class DeserializableList`1 : Object
    {
        public System.Collections.Generic.List`1<T> Count;
        public string System.Collections.Generic.ICollection<T>.IsReadOnly;
        public string Item;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void GetEnumerator1(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void get_Data(){} // RVA: 0x7FFAC2C58E90
        public void get_HasNextPage(){} // RVA: 0x7FFAC2C59D00
        public void get_HasPreviousPage(){} // RVA: 0x7FFAC2C59D00
        public void get_NextUrl(){} // RVA: 0x7FFAC2C58E90
        public void get_PreviousUrl(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class Destination : Object
    {
        public string ApiName; // 0x10
        public string DeeplinkMessage; // 0x18
        public string DisplayName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887EAD0
    }

    public class DestinationList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887EE10
    }

}