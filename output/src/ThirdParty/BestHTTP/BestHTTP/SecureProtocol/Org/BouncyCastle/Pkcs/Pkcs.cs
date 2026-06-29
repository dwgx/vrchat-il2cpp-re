// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
// Classes: 14
// Methods: 70

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
{
    public class AsymmetricKeyEntry : Pkcs12Entry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16E4660
        public void get_Key(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7B16E46E0
        public void GetHashCode(){} // RVA: 0x7B16E4780
    }

    public class EncryptedPrivateKeyInfoFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CreateEncryptedPrivateKeyInfo(){} // RVA: 0x7B16E4890
    }

    public class Pkcs10CertificationRequest : CertificationRequest
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B16E4C40
        public void CreatePssParams(){} // RVA: 0x7B16E6CA0
        public void .ctor(){} // RVA: 0x7B16E7120
        public void Init(){} // RVA: 0x7B16E72A0
        public void GetPublicKey(){} // RVA: 0x7B16E76A0
        public void Verify(){} // RVA: 0x7B16E7940
        public void SetSignatureParameters(){} // RVA: 0x7B16E7BC0
        public void GetSignatureName(){} // RVA: 0x7B16E7D00
        public void GetDigestAlgName(){} // RVA: 0x7B16E7F00
    }

    public class Pkcs10CertificationRequestDelaySigned : Pkcs10CertificationRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16E8650
        public void GetDataToSign(){} // RVA: 0x7B12824F0
        public void SignRequest(){} // RVA: 0x7A81052D0
    }

    public class Pkcs12Entry : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16E8CB0
        public void GetBagAttribute(){} // RVA: 0x7B16E9140
        public void GetBagAttributeKeys(){} // RVA: 0x7B16E91F0
        public void get_Item(){} // RVA: 0x7B16E9330
        public void get_BagAttributeKeys(){} // RVA: 0x7B16E93E0
    }

    public class Pkcs12Store : Object
    {
        // ── Methods ──
        public void CreateSubjectKeyID(){} // RVA: 0x7B16E94F0
        public void .ctor(){} // RVA: 0x7B16E99B0
        public void LoadKeyBag(){} // RVA: 0x7B16E9A60
        public void LoadPkcs8ShroudedKeyBag(){} // RVA: 0x7B16EA220
        public void Load(){} // RVA: 0x7B16EA280
        public void GetKey(){} // RVA: 0x7B16EB9C0
        public void IsCertificateEntry(){} // RVA: 0x7B16EBAB0
        public void IsKeyEntry(){} // RVA: 0x7B16EBB60
        public void GetAliasesTable(){} // RVA: 0x7B16EBBE0
        public void get_Aliases(){} // RVA: 0x7B16EC290
        public void ContainsAlias(){} // RVA: 0x7B16EC3B0
        public void GetCertificate(){} // RVA: 0x7B16EC410
        public void GetCertificateAlias(){} // RVA: 0x7B16EC650
        public void GetCertificateChain(){} // RVA: 0x7B16ECB60
        public void SetCertificateEntry(){} // RVA: 0x7B16ED3A0
        public void SetKeyEntry(){} // RVA: 0x7B16ED5C0
        public void DeleteEntry(){} // RVA: 0x7B16ED930
        public void IsEntryOfType(){} // RVA: 0x7B16EDD50
        public void Size(){} // RVA: 0x7B16EDF80
        public void get_Count(){} // RVA: 0x7B16EDF80
        public void Save(){} // RVA: 0x7B16EDFE0
        public void CalculatePbeMac(){} // RVA: 0x7B16F0F90
        public void CryptPbeData(){} // RVA: 0x7B16F1280
    }

    public class Pkcs12StoreBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16F1DE0
        public void Build(){} // RVA: 0x7B16F1F00
        public void SetCertAlgorithm(){} // RVA: 0x7A9A186C0
        public void SetKeyAlgorithm(){} // RVA: 0x7A9C818D0
        public void SetUseDerEncoding(){} // RVA: 0x7B16F1F90
    }

    public class Pkcs12Utilities : Object
    {
        // ── Methods ──
        public void ConvertToDefiniteLength(){} // RVA: 0x7B16F2040
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Pkcs8EncryptedPrivateKeyInfo : Object
    {
        // ── Methods ──
        public void parseBytes(){} // RVA: 0x7B16F2540
        public void .ctor(){} // RVA: 0x7B16F2680
        public void ToAsn1Structure(){} // RVA: 0x7A80F2570
        public void GetEncryptedData(){} // RVA: 0x7B16F26F0
        public void GetEncoded(){} // RVA: 0x7B128E860
        public void DecryptPrivateKeyInfo(){} // RVA: 0x7B16F2730
    }

    public class Pkcs8EncryptedPrivateKeyInfoBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Build(){} // RVA: 0x7B16F2A00
    }

    public class PkcsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16F2D60
    }

    public class PkcsIOException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC13C20
    }

    public class PrivateKeyInfoFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CreatePrivateKeyInfo(){} // RVA: 0x7B16F4910
        public void ExtractBytes(){} // RVA: 0x7B16F4CD0
    }

    public class X509CertificateEntry : Pkcs12Entry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16E4660
        public void get_Certificate(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7B16F4EF0
        public void GetHashCode(){} // RVA: 0x7B16E4780
    }

}