// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
// Classes: 14
// Methods: 70

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
{
    public class AsymmetricKeyEntry : Pkcs12Entry
    {
        public object key;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA54FD30
        public void get_Key(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0xA54FDB0
        public void GetHashCode(){} // RVA: 0xA54FE50
    }

    public class EncryptedPrivateKeyInfoFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreateEncryptedPrivateKeyInfo(){} // RVA: 0xA54FF60
    }

    public class Pkcs10CertificationRequest : CertificationRequest
    {
        public object algorithms;
        public object exParams;
        public object keyAlgorithms;
        public object oids;
        public object noParams;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA550300
        public void CreatePssParams(){} // RVA: 0xA552360
        public void .ctor(){} // RVA: 0xA5527E0
        public void Init(){} // RVA: 0xA552960
        public void GetPublicKey(){} // RVA: 0xA552D60
        public void Verify(){} // RVA: 0xA553000
        public void SetSignatureParameters(){} // RVA: 0xA553280
        public void GetSignatureName(){} // RVA: 0xA5533C0
        public void GetDigestAlgName(){} // RVA: 0xA5535C0
    }

    public class Pkcs10CertificationRequestDelaySigned : Pkcs10CertificationRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA553D10
        public void GetDataToSign(){} // RVA: 0xA0EDD90
        public void SignRequest(){} // RVA: 0xB70100
    }

    public class Pkcs12Entry : Object
    {
        public object attributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA554370
        public void GetBagAttribute(){} // RVA: 0xA5547D0
        public void GetBagAttributeKeys(){} // RVA: 0xA554880
        public void get_Item(){} // RVA: 0xA5549C0
        public void get_BagAttributeKeys(){} // RVA: 0xA554A70
    }

    public class Pkcs12Store : Object
    {
        public object keys;
        public object localIds;
        public object certs;
        public object chainCerts;
        public object keyCerts;
        public object keyAlgorithm;
        public object certAlgorithm;
        public object useDerEncoding;
        public object unmarkedKeyEntry;
        public object MinIterations;
        public object SaltSize;

        // ── Methods ──
        public void CreateSubjectKeyID(){} // RVA: 0xA554B80
        public void .ctor(){} // RVA: 0xA555040
        public void LoadKeyBag(){} // RVA: 0xA5550F0
        public void LoadPkcs8ShroudedKeyBag(){} // RVA: 0xA5558B0
        public void Load(){} // RVA: 0xA555910
        public void GetKey(){} // RVA: 0xA557050
        public void IsCertificateEntry(){} // RVA: 0xA557140
        public void IsKeyEntry(){} // RVA: 0xA5571F0
        public void GetAliasesTable(){} // RVA: 0xA557270
        public void get_Aliases(){} // RVA: 0xA557910
        public void ContainsAlias(){} // RVA: 0xA557A30
        public void GetCertificate(){} // RVA: 0xA557A90
        public void GetCertificateAlias(){} // RVA: 0xA557CC0
        public void GetCertificateChain(){} // RVA: 0xA5581C0
        public void SetCertificateEntry(){} // RVA: 0xA558A00
        public void SetKeyEntry(){} // RVA: 0xA558C20
        public void DeleteEntry(){} // RVA: 0xA558F90
        public void IsEntryOfType(){} // RVA: 0xA5593A0
        public void Size(){} // RVA: 0xA5595D0
        public void get_Count(){} // RVA: 0xA5595D0
        public void Save(){} // RVA: 0xA559630
        public void CalculatePbeMac(){} // RVA: 0xA55C5D0
        public void CryptPbeData(){} // RVA: 0xA55C8C0
    }

    public class Pkcs12StoreBuilder : Object
    {
        public object keyAlgorithm;
        public object certAlgorithm;
        public object useDerEncoding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA55D3F0
        public void Build(){} // RVA: 0xA55D510
        public void SetCertAlgorithm(){} // RVA: 0xD33F30
        public void SetKeyAlgorithm(){} // RVA: 0x26FE8D0
        public void SetUseDerEncoding(){} // RVA: 0xA55D5A0
    }

    public class Pkcs12Utilities : Object
    {
        // ── Methods ──
        public void ConvertToDefiniteLength(){} // RVA: 0xA55D650
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Pkcs8EncryptedPrivateKeyInfo : Object
    {
        public object encryptedPrivateKeyInfo;

        // ── Methods ──
        public void parseBytes(){} // RVA: 0xA55DB50
        public void .ctor(){} // RVA: 0xA55DC90
        public void ToAsn1Structure(){} // RVA: 0xB5DBF0
        public void GetEncryptedData(){} // RVA: 0xA55DD00
        public void GetEncoded(){} // RVA: 0xA0FA1B0
        public void DecryptPrivateKeyInfo(){} // RVA: 0xA55DD40
    }

    public class Pkcs8EncryptedPrivateKeyInfoBuilder : Object
    {
        public object privateKeyInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Build(){} // RVA: 0xA55E010
    }

    public class PkcsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA55E370
    }

    public class PkcsIOException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x689ED90
    }

    public class PrivateKeyInfoFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreatePrivateKeyInfo(){} // RVA: 0xA55FF20
        public void ExtractBytes(){} // RVA: 0xA5602E0
    }

    public class X509CertificateEntry : Pkcs12Entry
    {
        public object cert;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA54FD30
        public void get_Certificate(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0xA560500
        public void GetHashCode(){} // RVA: 0xA54FE50
    }

}