// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Utilities
// Classes: 4
// Methods: 23

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Utilities
{
    public class AlgorithmIdentifierFactory : Object
    {
        public object IDEA_CBC;
        public object CAST5_CBC;
        public object rc2Table;

        // ── Methods ──
        public void GenerateEncryptionAlgID(){} // RVA: 0xA1AF270
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA1AFB20
    }

    public class CipherFactory : Object
    {
        public object rc2Ekb;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreateContentCipher(){} // RVA: 0xA1AFD60
        public void CreateCipher(){} // RVA: 0xA1B0680
        public void .cctor(){} // RVA: 0xA1B0B00
    }

    public class CipherKeyGeneratorFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreateKeyGenerator(){} // RVA: 0xA1B0BE0
        public void CreateCipherKeyGenerator(){} // RVA: 0xA1B1340
    }

    public class Pack : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void UInt16_To_BE(){} // RVA: 0xA1B1490
        public void BE_To_UInt16(){} // RVA: 0xA1B1510
        public void UInt32_To_BE(){} // RVA: 0xA1B1720
        public void BE_To_UInt32(){} // RVA: 0xA1B18B0
        public void UInt64_To_BE(){} // RVA: 0xA1B1BC0
        public void BE_To_UInt64(){} // RVA: 0xA1B1EB0
        public void UInt16_To_LE(){} // RVA: 0x673F850
        public void LE_To_UInt16(){} // RVA: 0x673F730
        public void UInt32_To_LE(){} // RVA: 0xA1B2290
        public void LE_To_UInt32(){} // RVA: 0xA1B2530
        public void UInt64_To_LE(){} // RVA: 0xA1B2990
        public void LE_To_UInt64(){} // RVA: 0xA1B2DD0
    }

}