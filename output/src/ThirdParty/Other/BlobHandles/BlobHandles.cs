// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.BlobHandles
// Classes: 2
// Methods: 15

namespace ThirdParty.Other.BlobHandles
{
    public class BlobHandle : ValueType
    {
        public IntPtr Pointer; // 0x10
        public int Length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC0B650
        public void ToString(){} // RVA: 0x7FFD4FC0B660
        public void GetHashCode(){} // RVA: 0x7FFD4FC0B7B0
        public void Equals(){} // RVA: 0x7FFD4FC0B800 | overloaded x2
        public void MemoryCompare(){} // RVA: 0x7FFD4FC0B8A0
    }

    public class BlobString : ValueType
    {
        public em.MarkAborted.ION_4_7 Encoding;
        public ÍÎÏÎÎ.ÌÌ<byte> Bytes; // 0x10
        public ellSize_Injected.InstallEvents>b__3_3 Handle; // 0x20

        // ── Methods ──
        public void get_Encoding(){} // RVA: 0x7FFD4FC0B940
        public void .ctor(){} // RVA: 0x7FFD4FC0BBD0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD4FC0BC00
        public void GetHashCode(){} // RVA: 0x7FFD4FC0BD90
        public void Equals(){} // RVA: 0x7FFD4FC0BDF0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFD4FC0BEA0
        public void .cctor(){} // RVA: 0x7FFD4FC0BF80
    }

}