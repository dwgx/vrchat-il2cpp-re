// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.BlobHandles
// Classes: 2
// Methods: 15

namespace ThirdParty.Other.BlobHandles
{
    public class BlobHandle : ValueType
    {
        public byte* Pointer; // 0x10
        public int Length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47EB650
        public void ToString(){} // RVA: 0x7FFAC47EB660
        public void GetHashCode(){} // RVA: 0x7FFAC47EB7B0
        public void Equals(){} // RVA: 0x7FFAC47EB800 | overloaded x2
        public void MemoryCompare(){} // RVA: 0x7FFAC47EB8A0
    }

    public class BlobString : ValueType
    {
        public System.Text.Encoding Encoding;
        public Unity.Collections.NativeArray`1<byte> Bytes; // 0x10
        public BlobHandles.BlobHandle Handle; // 0x20

        // ── Methods ──
        public void get_Encoding(){} // RVA: 0x7FFAC47EB940
        public void .ctor(){} // RVA: 0x7FFAC47EBBD0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC47EBC00
        public void GetHashCode(){} // RVA: 0x7FFAC47EBD90
        public void Equals(){} // RVA: 0x7FFAC47EBDF0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC47EBEA0
        public void .cctor(){} // RVA: 0x7FFAC47EBF80
    }

}