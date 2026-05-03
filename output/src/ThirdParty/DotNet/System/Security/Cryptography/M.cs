// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 4
// Methods: 24

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class MACTripleDES : KeyedHashAlgorithm
    {
        public System.Security.Cryptography.ICryptoTransform m_encryptor; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867C1020 | overloaded x3
        public void Initialize(){} // RVA: 0x7FFE865A8E50
        public void get_Padding(){} // RVA: 0x7FFE867C1480
        public void set_Padding(){} // RVA: 0x7FFE867C14B0
        public void HashCore(){} // RVA: 0x7FFE867C1550
        public void HashFinal(){} // RVA: 0x7FFE867C1810
        public void Dispose(){} // RVA: 0x7FFE867C1AE0
    }

    public class MD5 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8671D600
        public void Create(){} // RVA: 0x7FFE867C2480 | overloaded x2
    }

    public class MD5CryptoServiceProvider : MD5
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867E95F0
        public void Finalize(){} // RVA: 0x7FFE867E9780
        public void Dispose(){} // RVA: 0x7FFE867E97D0
        public void HashCore(){} // RVA: 0x7FFE867E9850
        public void HashFinal(){} // RVA: 0x7FFE867E9990
        public void Initialize(){} // RVA: 0x7FFE867E9A80
        public void ProcessBlock(){} // RVA: 0x7FFE867E9B00
        public void ProcessFinalBlock(){} // RVA: 0x7FFE867EB210
        public void AddLength(){} // RVA: 0x7FFE867EB440
        public void .cctor(){} // RVA: 0x7FFE867EB520
    }

    public class MaskGenerationMethod : Object
    {
        // ── Methods ──
        public void GenerateMask(){} // RVA: 0x7FFE80E3F2F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}