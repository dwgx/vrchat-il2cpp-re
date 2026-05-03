// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
// Classes: 14
// Methods: 103

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
{
    public class AsymmetricKeyEntry : Pkcs12Entry
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter key; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A30B4F0 | overloaded x3
        public void get_Key(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE8A30B570
        public void GetHashCode(){} // RVA: 0x7FFE8A30B630
    }

    public class EncryptedPrivateKeyInfoFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreateEncryptedPrivateKeyInfo(){} // RVA: 0x7FFE8A30B740 | overloaded x3
    }

    public class Pkcs10CertificationRequest : CertificationRequest
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A30B990
        public void CreatePssParams(){} // RVA: 0x7FFE8A30D9F0
        public void .ctor(){} // RVA: 0x7FFE8A30DE70 | overloaded x7
        public void Init(){} // RVA: 0x7FFE8A30DFF0
        public void GetPublicKey(){} // RVA: 0x7FFE8A30E3F0
        public void Verify(){} // RVA: 0x7FFE8A30E690 | overloaded x4
        public void SetSignatureParameters(){} // RVA: 0x7FFE8A30E910
        public void GetSignatureName(){} // RVA: 0x7FFE8A30EA50
        public void GetDigestAlgName(){} // RVA: 0x7FFE8A30EC50
    }

    public class Pkcs10CertificationRequestDelaySigned : Pkcs10CertificationRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A30F3A0 | overloaded x6
        public void GetDataToSign(){} // RVA: 0x7FFE89EB0CB0
        public void SignRequest(){} // RVA: 0x7FFE811290D0 | overloaded x2
    }

    public class Pkcs12Entry : Object
    {
        public System.Collections.IDictionary attributes; // 0x10
        public object field_1; // 0x18F
        public object field_2; // 0x190

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A30FA00
        public void GetBagAttribute(){} // RVA: 0x7FFE8A30FEA0 | overloaded x2
        public void GetBagAttributeKeys(){} // RVA: 0x7FFE8A30FF50
        public void get_Item(){} // RVA: 0x7FFE8A310090 | overloaded x2
        public void get_BagAttributeKeys(){} // RVA: 0x7FFE8A310140
    }

    public class Pkcs12Store : Object
    {
        public IgnoresCaseHashtable keys; // 0x10
        public System.Collections.IDictionary localIds; // 0x18

        // ── Methods ──
        public void CreateSubjectKeyID(){} // RVA: 0x7FFE8A310250
        public void .ctor(){} // RVA: 0x7FFE8A310710 | overloaded x3
        public void LoadKeyBag(){} // RVA: 0x7FFE8A3107C0
        public void LoadPkcs8ShroudedKeyBag(){} // RVA: 0x7FFE8A310F80
        public void Load(){} // RVA: 0x7FFE8A310FE0
        public void GetKey(){} // RVA: 0x7FFE8A312730
        public void IsCertificateEntry(){} // RVA: 0x7FFE8A312820
        public void IsKeyEntry(){} // RVA: 0x7FFE8A3128D0
        public void GetAliasesTable(){} // RVA: 0x7FFE8A312950
        public void get_Aliases(){} // RVA: 0x7FFE8A313030
        public void ContainsAlias(){} // RVA: 0x7FFE8A313150
        public void GetCertificate(){} // RVA: 0x7FFE8A3131B0
        public void GetCertificateAlias(){} // RVA: 0x7FFE8A3133F0
        public void GetCertificateChain(){} // RVA: 0x7FFE8A313940
        public void SetCertificateEntry(){} // RVA: 0x7FFE8A314180
        public void SetKeyEntry(){} // RVA: 0x7FFE8A3143A0
        public void DeleteEntry(){} // RVA: 0x7FFE8A314720
        public void IsEntryOfType(){} // RVA: 0x7FFE8A314B60
        public void Size(){} // RVA: 0x7FFE8A314D90
        public void get_Count(){} // RVA: 0x7FFE8A314D90
        public void Save(){} // RVA: 0x7FFE8A314DF0
        public void CalculatePbeMac(){} // RVA: 0x7FFE8A317B50
        public void CryptPbeData(){} // RVA: 0x7FFE8A317E40
    }

    public class Pkcs12StoreBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3189D0
        public void Build(){} // RVA: 0x7FFE8A318AF0
        public void SetCertAlgorithm(){} // RVA: 0x7FFE829DE9A0
        public void SetKeyAlgorithm(){} // RVA: 0x7FFE82C06680
        public void SetUseDerEncoding(){} // RVA: 0x7FFE8A318B80
    }

    public class Pkcs12Utilities : Object
    {
        // ── Methods ──
        public void ConvertToDefiniteLength(){} // RVA: 0x7FFE8A318C30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Pkcs8EncryptedPrivateKeyInfo : Object
    {
        // ── Methods ──
        public void parseBytes(){} // RVA: 0x7FFE8A319120
        public void .ctor(){} // RVA: 0x7FFE8A319260 | overloaded x2
        public void ToAsn1Structure(){} // RVA: 0x7FFE81116380
        public void GetEncryptedData(){} // RVA: 0x7FFE8A3192D0
        public void GetEncoded(){} // RVA: 0x7FFE89EBCFE0
        public void DecryptPrivateKeyInfo(){} // RVA: 0x7FFE8A319310
    }

    public class Pkcs8EncryptedPrivateKeyInfoBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void Build(){} // RVA: 0x7FFE8A3195E0
    }

    public class PkcsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A319930 | overloaded x2
    }

    public class PkcsIOException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869662F0 | overloaded x2
    }

    public class PrivateKeyInfoFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreatePrivateKeyInfo(){} // RVA: 0x7FFE8A31B220 | overloaded x4
        public void ExtractBytes(){} // RVA: 0x7FFE8A31B480
    }

    public class X509CertificateEntry : Pkcs12Entry
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate cert; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A30B4F0 | overloaded x3
        public void get_Certificate(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE8A31B6A0
        public void GetHashCode(){} // RVA: 0x7FFE8A30B630
    }

}