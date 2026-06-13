// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
// Classes: 14
// Methods: 103

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
{
    public class AsymmetricKeyEntry
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter Item; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x98A97D0 | overloaded x3
        public void get_Key(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x98A9850
        public void GetHashCode(){} // RVA: 0x98A9910
    }

    public class EncryptedPrivateKeyInfoFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void CreateEncryptedPrivateKeyInfo(){} // RVA: 0x98A9A20 | overloaded x3
    }

    public class Pkcs10CertificationRequest
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x98A9C70
        public void CreatePssParams(){} // RVA: 0x98ABCD0
        public void .ctor(){} // RVA: 0x98AC150 | overloaded x7
        public void Init(){} // RVA: 0x98AC2D0
        public void GetPublicKey(){} // RVA: 0x98AC6D0
        public void Verify(){} // RVA: 0x98AC970 | overloaded x4
        public void SetSignatureParameters(){} // RVA: 0x98ACBF0
        public void GetSignatureName(){} // RVA: 0x98ACD30
        public void GetDigestAlgName(){} // RVA: 0x98ACF30
    }

    public class Pkcs10CertificationRequestDelaySigned
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x98AD680 | overloaded x6
        public void GetDataToSign(){} // RVA: 0x944E8E0
        public void SignRequest(){} // RVA: 0x30B0D0 | overloaded x2
    }

    public class Pkcs12Entry
    {
        public System.Collections.IDictionary attributes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x98ADCE0
        public void GetBagAttribute(){} // RVA: 0x98AE180 | overloaded x2
        public void GetBagAttributeKeys(){} // RVA: 0x98AE230
        public void get_Item(){} // RVA: 0x98AE370 | overloaded x2
        public void get_BagAttributeKeys(){} // RVA: 0x98AE420
    }

    public class Pkcs12Store
    {
        public IgnoresCaseHashtable keys; // 0x10
        public System.Collections.IDictionary localIds; // 0x18

        // ── Methods ──
        public void CreateSubjectKeyID(){} // RVA: 0x98AE530
        public void .ctor(){} // RVA: 0x98AE9F0 | overloaded x3
        public void LoadKeyBag(){} // RVA: 0x98AEAA0
        public void LoadPkcs8ShroudedKeyBag(){} // RVA: 0x98AF260
        public void Load(){} // RVA: 0x98AF2C0
        public void GetKey(){} // RVA: 0x98B0A10
        public void IsCertificateEntry(){} // RVA: 0x98B0B00
        public void IsKeyEntry(){} // RVA: 0x98B0BB0
        public void GetAliasesTable(){} // RVA: 0x98B0C30
        public void get_Aliases(){} // RVA: 0x98B1310
        public void ContainsAlias(){} // RVA: 0x98B1430
        public void GetCertificate(){} // RVA: 0x98B1490
        public void GetCertificateAlias(){} // RVA: 0x98B16D0
        public void GetCertificateChain(){} // RVA: 0x98B1C20
        public void SetCertificateEntry(){} // RVA: 0x98B2460
        public void SetKeyEntry(){} // RVA: 0x98B2680
        public void DeleteEntry(){} // RVA: 0x98B2A00
        public void IsEntryOfType(){} // RVA: 0x98B2E40
        public void Size(){} // RVA: 0x98B3070
        public void get_Count(){} // RVA: 0x98B3070
        public void Save(){} // RVA: 0x98B30D0
        public void CalculatePbeMac(){} // RVA: 0x98B5E30
        public void CryptPbeData(){} // RVA: 0x98B6120
    }

    public class Pkcs12StoreBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x98B6CB0
        public void Build(){} // RVA: 0x98B6DD0
        public void SetCertAlgorithm(){} // RVA: 0x1C5A060
        public void SetKeyAlgorithm(){} // RVA: 0x1E7CF00
        public void SetUseDerEncoding(){} // RVA: 0x98B6E60
    }

    public class Pkcs12Utilities
    {
        // ── Methods ──
        public void ConvertToDefiniteLength(){} // RVA: 0x98B6F10 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Pkcs8EncryptedPrivateKeyInfo
    {
        // ── Methods ──
        public void parseBytes(){} // RVA: 0x98B7400
        public void .ctor(){} // RVA: 0x98B7540 | overloaded x2
        public void ToAsn1Structure(){} // RVA: 0x2F8380
        public void GetEncryptedData(){} // RVA: 0x98B75B0
        public void GetEncoded(){} // RVA: 0x945AC10
        public void DecryptPrivateKeyInfo(){} // RVA: 0x98B75F0
    }

    public class Pkcs8EncryptedPrivateKeyInfoBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void Build(){} // RVA: 0x98B78C0
    }

    public class PkcsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x98B7C10 | overloaded x2
    }

    public class PkcsIOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E254B0 | overloaded x2
    }

    public class PrivateKeyInfoFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void CreatePrivateKeyInfo(){} // RVA: 0x98B9500 | overloaded x4
        public void ExtractBytes(){} // RVA: 0x98B9760
    }

    public class X509CertificateEntry
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate cert; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x98A97D0 | overloaded x3
        public void get_Certificate(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x98B9980
        public void GetHashCode(){} // RVA: 0x98A9910
    }

}