// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 3
// Methods: 29

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class PKCS1MaskGenerationMethod : MaskGenerationMethod
    {
        public string HashNameValue; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867C4270
        public void get_HashName(){} // RVA: 0x7FFE81116380
        public void set_HashName(){} // RVA: 0x7FFE867C4300
        public void GenerateMask(){} // RVA: 0x7FFE867C4400
    }

    public class PasswordDeriveBytes : DeriveBytes
    {
        public int _extraCount; // 0x10
        public int _prefix; // 0x14
        public int _iterations; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867C2A70 | overloaded x8
        public void get_HashName(){} // RVA: 0x7FFE8143BA80
        public void set_HashName(){} // RVA: 0x7FFE867C2C30
        public void get_IterationCount(){} // RVA: 0x7FFE813DB630
        public void set_IterationCount(){} // RVA: 0x7FFE867C2ED0
        public void get_Salt(){} // RVA: 0x7FFE867C3010
        public void set_Salt(){} // RVA: 0x7FFE867C3090
        public void GetBytes(){} // RVA: 0x7FFE867C32C0
        public void Reset(){} // RVA: 0x7FFE867C3590
        public void Dispose(){} // RVA: 0x7FFE867C3650
        public void CryptDeriveKey(){} // RVA: 0x7FFE867C36F0
        public void ComputeBaseValue(){} // RVA: 0x7FFE867C37B0
        public void ComputeBytes(){} // RVA: 0x7FFE867C3B60
        public void HashPrefix(){} // RVA: 0x7FFE867C4080
    }

    public class PbeParameters : Object
    {
        public 0x664C6C7C _encryptionAlgorithm; // 0x10
        public System.Security.Cryptography.HashAlgorithmName _hashAlgorithm; // 0x18
        public int _iterationCount; // 0x20

        // ── Methods ──
        public void get_EncryptionAlgorithm(){} // RVA: 0x7FFE811485C0
        public void get_HashAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void get_IterationCount(){} // RVA: 0x7FFE8151D690
        public void .ctor(){} // RVA: 0x7FFE867F09B0
    }

}