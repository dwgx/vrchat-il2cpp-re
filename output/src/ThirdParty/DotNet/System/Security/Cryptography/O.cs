// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 3
// Methods: 23

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class Oid : Object
    {
        public string Value; // 0x10
        public string FriendlyName; // 0x18
        public 0x6B131648 _group; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC7E02DD0 | overloaded x5
        public void FromOidValue(){} // RVA: 0x7FFAC93CA720
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void get_FriendlyName(){} // RVA: 0x7FFAC93CA910
    }

    public class OidCollection : Object
    {
        public System.Collections.Generic.List`1<System.Security.Cryptography.Oid> Item; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93CA9F0
        public void Add(){} // RVA: 0x7FFAC93CAAB0
        public void get_Item(){} // RVA: 0x7FFAC93CAB80
        public void get_Count(){} // RVA: 0x7FFAC93CAC00
        public void GetEnumerator(){} // RVA: 0x7FFAC93CAC50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC93CACF0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC93CAD00
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
    }

    public class OidEnumerator : Object
    {
        public System.Security.Cryptography.OidCollection Current; // 0x10
        public int System.Collections.IEnumerator.Current; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8512AA0
        public void get_Current(){} // RVA: 0x7FFAC93CAF70
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC93CAF70
        public void MoveNext(){} // RVA: 0x7FFAC93CAFA0
        public void Reset(){} // RVA: 0x7FFAC47EDC40
    }

}