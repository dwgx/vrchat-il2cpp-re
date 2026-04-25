// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 3
// Methods: 29

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class PKCS1MaskGenerationMethod : MaskGenerationMethod
    {
        public string HashName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC841A960
        public void get_HashName(){} // RVA: 0x7FFAC2F3C380
        public void set_HashName(){} // RVA: 0x7FFAC841A9F0
        public void GenerateMask(){} // RVA: 0x7FFAC841AAF0
    }

    public class PasswordDeriveBytes : DeriveBytes
    {
        public int HashName; // 0x10
        public int IterationCount; // 0x14
        public int Salt; // 0x18
        public byte[] _baseValue; // 0x20
        public byte[] _extra; // 0x28
        public byte[] _salt; // 0x30
        public string _hashName; // 0x38
        public byte[] _password; // 0x40
        public System.Security.Cryptography.HashAlgorithm _hash; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8419160 | overloaded x8
        public void get_HashName(){} // RVA: 0x7FFAC31D0140
        public void set_HashName(){} // RVA: 0x7FFAC8419320
        public void get_IterationCount(){} // RVA: 0x7FFAC3157800
        public void set_IterationCount(){} // RVA: 0x7FFAC84195C0
        public void get_Salt(){} // RVA: 0x7FFAC8419700
        public void set_Salt(){} // RVA: 0x7FFAC8419780
        public void GetBytes(){} // RVA: 0x7FFAC84199B0
        public void Reset(){} // RVA: 0x7FFAC8419C80
        public void Dispose(){} // RVA: 0x7FFAC8419D40
        public void CryptDeriveKey(){} // RVA: 0x7FFAC8419DE0
        public void ComputeBaseValue(){} // RVA: 0x7FFAC8419EA0
        public void ComputeBytes(){} // RVA: 0x7FFAC841A250
        public void HashPrefix(){} // RVA: 0x7FFAC841A770
    }

    public class PbeParameters : Object
    {
        public 0x6B0CDD58 EncryptionAlgorithm; // 0x10
        public System.Security.Cryptography.HashAlgorithmName HashAlgorithm; // 0x18
        public int IterationCount; // 0x20

        // ── Methods ──
        public void get_EncryptionAlgorithm(){} // RVA: 0x7FFAC2F6E5C0
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void get_IterationCount(){} // RVA: 0x7FFAC30DBBE0
        public void .ctor(){} // RVA: 0x7FFAC84470A0
    }

}