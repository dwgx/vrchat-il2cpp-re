// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 2
// Methods: 12

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class KeySizes : Object
    {
        public int MinSize; // 0x10
        public int MaxSize; // 0x14
        public int SkipSize; // 0x18

        // ── Methods ──
        public void get_MinSize(){} // RVA: 0x7FFAC2F6E5C0
        public void get_MaxSize(){} // RVA: 0x7FFAC33D5A20
        public void get_SkipSize(){} // RVA: 0x7FFAC3157800
        public void .ctor(){} // RVA: 0x7FFAC48B1250
        public void IsLegal(){} // RVA: 0x7FFAC840F430
        public void IsLegalKeySize(){} // RVA: 0x7FFAC840F460
    }

    public class KeyedHashAlgorithm : HashAlgorithm
    {
        public byte[] Key; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC8417020
        public void get_Key(){} // RVA: 0x7FFAC84170B0
        public void set_Key(){} // RVA: 0x7FFAC8417130
        public void Create(){} // RVA: 0x7FFAC8417330 | overloaded x2
    }

}