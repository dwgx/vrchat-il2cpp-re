// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Operators
// Classes: 2
// Methods: 7

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Operators
{
    public class CmsContentEncryptorBuilder : Object
    {
        public object KeySizes;
        public object encryptionOID;
        public object keySize;
        public object helper;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA1A9D80
        public void GetKeySize(){} // RVA: 0xA1AA140
        public void .ctor(){} // RVA: 0xA1AA480
        public void Build(){} // RVA: 0xA1AA580
    }

    public class CmsKeyTransRecipientInfoGenerator : KeyTransRecipientInfoGenerator
    {
        public object keyWrapper;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AA8A0
        public void get_AlgorithmDetails(){} // RVA: 0xA1AAA80
        public void GenerateWrappedKey(){} // RVA: 0xA1AAB20
    }

}