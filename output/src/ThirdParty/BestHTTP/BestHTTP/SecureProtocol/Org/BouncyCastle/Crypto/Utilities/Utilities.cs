// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Utilities
// Classes: 4
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Utilities
{
    public class AlgorithmIdentifierFactory : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IDEA_CBC;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CAST5_CBC; // 0x8
        public short[] rc2Table; // 0x10

        // ── Methods ──
        public void GenerateEncryptionAlgID(){} // RVA: 0x7FFACBB16680
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB16E70
    }

    public class CipherFactory : Object
    {
        public short[] rc2Ekb;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateContentCipher(){} // RVA: 0x7FFACBB170B0
        public void CreateCipher(){} // RVA: 0x7FFACBB179D0
        public void .cctor(){} // RVA: 0x7FFACBB17E50
    }

    public class CipherKeyGeneratorFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateKeyGenerator(){} // RVA: 0x7FFACBB17F30
        public void CreateCipherKeyGenerator(){} // RVA: 0x7FFACBB18690
    }

    public class Pack : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void UInt16_To_BE(){} // RVA: 0x7FFACBB187E0 | overloaded x2
        public void BE_To_UInt16(){} // RVA: 0x7FFACBB18860 | overloaded x2
        public void UInt32_To_BE(){} // RVA: 0x7FFACBB18A70 | overloaded x5
        public void BE_To_UInt32(){} // RVA: 0x7FFACBB18BF0 | overloaded x3
        public void UInt64_To_BE(){} // RVA: 0x7FFACBB18EF0 | overloaded x5
        public void BE_To_UInt64(){} // RVA: 0x7FFACBB191E0 | overloaded x3
        public void UInt16_To_LE(){} // RVA: 0x7FFAC845D830 | overloaded x2
        public void LE_To_UInt16(){} // RVA: 0x7FFAC845D710 | overloaded x2
        public void UInt32_To_LE(){} // RVA: 0x7FFACBB195E0 | overloaded x5
        public void LE_To_UInt32(){} // RVA: 0x7FFACBB19860 | overloaded x5
        public void UInt64_To_LE(){} // RVA: 0x7FFACBB19CD0 | overloaded x6
        public void LE_To_UInt64(){} // RVA: 0x7FFACBB1A150 | overloaded x4
    }

}