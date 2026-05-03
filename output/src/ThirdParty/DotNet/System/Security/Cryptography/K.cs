// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 2
// Methods: 12

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class KeySizes : Object
    {
        public int m_minSize; // 0x10
        public int m_maxSize; // 0x14
        public int m_skipSize; // 0x18

        // ── Methods ──
        public void get_MinSize(){} // RVA: 0x7FFE811485C0
        public void get_MaxSize(){} // RVA: 0x7FFE8164B230
        public void get_SkipSize(){} // RVA: 0x7FFE813DB630
        public void .ctor(){} // RVA: 0x7FFE82B1BB00
        public void IsLegal(){} // RVA: 0x7FFE867B8D40
        public void IsLegalKeySize(){} // RVA: 0x7FFE867B8D70
    }

    public class KeyedHashAlgorithm : HashAlgorithm
    {
        public byte[] KeyValue; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE867C0930
        public void get_Key(){} // RVA: 0x7FFE867C09C0
        public void set_Key(){} // RVA: 0x7FFE867C0A40
        public void Create(){} // RVA: 0x7FFE867C0C40 | overloaded x2
    }

}