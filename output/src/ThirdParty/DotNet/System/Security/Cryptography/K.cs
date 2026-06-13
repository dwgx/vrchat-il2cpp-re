// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 2
// Methods: 12

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class KeySizes
    {
        public int m_minSize; // 0x10
        public int m_maxSize; // 0x14
        public int m_skipSize; // 0x18

        // ── Methods ──
        public void get_MinSize(){} // RVA: 0x32A5C0
        public void get_MaxSize(){} // RVA: 0x8ABED0
        public void get_SkipSize(){} // RVA: 0x5BED50
        public void .ctor(){} // RVA: 0x1D897D0
        public void IsLegal(){} // RVA: 0x5C77EA0
        public void IsLegalKeySize(){} // RVA: 0x5C77ED0
    }

    public class KeyedHashAlgorithm
    {
        public byte[] KeyValue; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x5C7FA90
        public void get_Key(){} // RVA: 0x5C7FB20
        public void set_Key(){} // RVA: 0x5C7FBA0
        public void Create(){} // RVA: 0x5C7FDA0 | overloaded x2
    }

}