// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.BlobHandles
// Classes: 2
// Methods: 12

namespace ThirdParty.Other.BlobHandles
{
    public class BlobHandle : ValueType
    {
        public object Pointer;
        public object Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x856B0
        public void ToString(){} // RVA: 0x856C0
        public void GetHashCode(){} // RVA: 0x85810
        public void Equals(){} // RVA: 0x85860
        public void MemoryCompare(){} // RVA: 0x2574530
    }

    public class BlobString : ValueType
    {
        public object _encoding;
        public object Bytes;
        public object Handle;

        // ── Methods ──
        public void get_Encoding(){} // RVA: 0x25745D0
        public void .ctor(){} // RVA: 0x85880
        public void ToString(){} // RVA: 0x858B0
        public void GetHashCode(){} // RVA: 0x858C0
        public void Equals(){} // RVA: 0x85920
        public void Dispose(){} // RVA: 0x85930
        public void .cctor(){} // RVA: 0x2574BE0
    }

}