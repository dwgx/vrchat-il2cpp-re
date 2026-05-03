// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 3
// Methods: 23

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class Oid : Object
    {
        public string _value; // 0x10
        public string _friendlyName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE862265A0 | overloaded x5
        public void FromOidValue(){} // RVA: 0x7FFE87772E50
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void get_FriendlyName(){} // RVA: 0x7FFE87773040
    }

    public class OidCollection : Object
    {
        public System.Collections.Generic.List`1<System.Security.Cryptography.Oid> _list; // 0x10
        public object field_1; // 0x141
        public object field_2; // 0x142
        public object field_3; // 0x143

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87773120
        public void Add(){} // RVA: 0x7FFE877731E0
        public void get_Item(){} // RVA: 0x7FFE877732B0
        public void get_Count(){} // RVA: 0x7FFE87773330
        public void GetEnumerator(){} // RVA: 0x7FFE87773380
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87773420
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE87773430
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE827C4A80
    }

    public class OidEnumerator : Object
    {
        public System.Security.Cryptography.OidCollection _oids; // 0x10
        public int _current; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868BC2A0
        public void get_Current(){} // RVA: 0x7FFE877736A0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE877736A0
        public void MoveNext(){} // RVA: 0x7FFE877736D0
        public void Reset(){} // RVA: 0x7FFE82A55FE0
    }

}