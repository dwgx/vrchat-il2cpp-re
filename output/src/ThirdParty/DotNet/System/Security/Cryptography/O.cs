// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 3
// Methods: 23

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class Oid
    {
        public string Item; // 0x10
        public string Count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x28914C0 | overloaded x5
        public void FromOidValue(){} // RVA: 0x6C31FA0
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void get_FriendlyName(){} // RVA: 0x6C32190
    }

    public class OidCollection
    {
        public System.Collections.Generic.List`1<System.Security.Cryptography.Oid> _list; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C32270
        public void Add(){} // RVA: 0x6C32330
        public void get_Item(){} // RVA: 0x6C32400
        public void get_Count(){} // RVA: 0x6C32480
        public void GetEnumerator(){} // RVA: 0x6C324D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6C32570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x6C32580
        public void get_IsSynchronized(){} // RVA: 0x2DD320
        public void get_SyncRoot(){} // RVA: 0x1A3F520
    }

    public class OidEnumerator
    {
        public System.Security.Cryptography.OidCollection _oids; // 0x10
        public int _current; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D7B410
        public void get_Current(){} // RVA: 0x6C327F0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x6C327F0
        public void MoveNext(){} // RVA: 0x6C32820
        public void Reset(){} // RVA: 0x1CC8140
    }

}