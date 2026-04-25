// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Operators
// Classes: 2
// Methods: 9

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Operators
{
    public class CmsContentEncryptorBuilder : Object
    {
        public System.Collections.IDictionary KeySizes;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionOID; // 0x10
        public int keySize; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.EnvelopedDataHelper helper; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBB11100
        public void GetKeySize(){} // RVA: 0x7FFACBB114D0
        public void .ctor(){} // RVA: 0x7FFACBB11830 | overloaded x2
        public void Build(){} // RVA: 0x7FFACBB11930
    }

    public class CmsKeyTransRecipientInfoGenerator : KeyTransRecipientInfoGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IKeyWrapper AlgorithmDetails; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB11C50 | overloaded x2
        public void get_AlgorithmDetails(){} // RVA: 0x7FFACBB11E30
        public void GenerateWrappedKey(){} // RVA: 0x7FFACBB11ED0
    }

}