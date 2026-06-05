// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
// Classes: 14
// Methods: 103

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
{
    public class AsymmetricKeyEntry
    {
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC3597D0 | overloaded x3
        public void get_Key(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAFC359850
        public void GetHashCode(){} // RVA: 0x7FFAFC359910
    }

    public class EncryptedPrivateKeyInfoFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void CreateEncryptedPrivateKeyInfo(){} // RVA: 0x7FFAFC359A20 | overloaded x3
    }

    public class Pkcs10CertificationRequest
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC359C70
        public void CreatePssParams(){} // RVA: 0x7FFAFC35BCD0
        public void .ctor(){} // RVA: 0x7FFAFC35C150 | overloaded x7
        public void Init(){} // RVA: 0x7FFAFC35C2D0
        public void GetPublicKey(){} // RVA: 0x7FFAFC35C6D0
        public void Verify(){} // RVA: 0x7FFAFC35C970 | overloaded x4
        public void SetSignatureParameters(){} // RVA: 0x7FFAFC35CBF0
        public void GetSignatureName(){} // RVA: 0x7FFAFC35CD30
        public void GetDigestAlgName(){} // RVA: 0x7FFAFC35CF30
    }

    public class Pkcs10CertificationRequestDelaySigned
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC35D680 | overloaded x6
        public void GetDataToSign(){} // RVA: 0x7FFAFBEFE8E0
        public void SignRequest(){} // RVA: 0x7FFAF2DBB0D0 | overloaded x2
    }

    public class Pkcs12Entry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC35DCE0
        public void GetBagAttribute(){} // RVA: 0x7FFAFC35E180 | overloaded x2
        public void GetBagAttributeKeys(){} // RVA: 0x7FFAFC35E230
        public void get_Item(){} // RVA: 0x7FFAFC35E370 | overloaded x2
        public void get_BagAttributeKeys(){} // RVA: 0x7FFAFC35E420
    }

    public class Pkcs12Store
    {
        // ── Methods ──
        public void CreateSubjectKeyID(){} // RVA: 0x7FFAFC35E530
        public void .ctor(){} // RVA: 0x7FFAFC35E9F0 | overloaded x3
        public void LoadKeyBag(){} // RVA: 0x7FFAFC35EAA0
        public void LoadPkcs8ShroudedKeyBag(){} // RVA: 0x7FFAFC35F260
        public void Load(){} // RVA: 0x7FFAFC35F2C0
        public void GetKey(){} // RVA: 0x7FFAFC360A10
        public void IsCertificateEntry(){} // RVA: 0x7FFAFC360B00
        public void IsKeyEntry(){} // RVA: 0x7FFAFC360BB0
        public void GetAliasesTable(){} // RVA: 0x7FFAFC360C30
        public void get_Aliases(){} // RVA: 0x7FFAFC361310
        public void ContainsAlias(){} // RVA: 0x7FFAFC361430
        public void GetCertificate(){} // RVA: 0x7FFAFC361490
        public void GetCertificateAlias(){} // RVA: 0x7FFAFC3616D0
        public void GetCertificateChain(){} // RVA: 0x7FFAFC361C20
        public void SetCertificateEntry(){} // RVA: 0x7FFAFC362460
        public void SetKeyEntry(){} // RVA: 0x7FFAFC362680
        public void DeleteEntry(){} // RVA: 0x7FFAFC362A00
        public void IsEntryOfType(){} // RVA: 0x7FFAFC362E40
        public void Size(){} // RVA: 0x7FFAFC363070
        public void get_Count(){} // RVA: 0x7FFAFC363070
        public void Save(){} // RVA: 0x7FFAFC3630D0
        public void CalculatePbeMac(){} // RVA: 0x7FFAFC365E30
        public void CryptPbeData(){} // RVA: 0x7FFAFC366120
    }

    public class Pkcs12StoreBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC366CB0
        public void Build(){} // RVA: 0x7FFAFC366DD0
        public void SetCertAlgorithm(){} // RVA: 0x7FFAF470A060
        public void SetKeyAlgorithm(){} // RVA: 0x7FFAF492CF00
        public void SetUseDerEncoding(){} // RVA: 0x7FFAFC366E60
    }

    public class Pkcs12Utilities
    {
        // ── Methods ──
        public void ConvertToDefiniteLength(){} // RVA: 0x7FFAFC366F10 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Pkcs8EncryptedPrivateKeyInfo
    {
        // ── Methods ──
        public void parseBytes(){} // RVA: 0x7FFAFC367400
        public void .ctor(){} // RVA: 0x7FFAFC367540 | overloaded x2
        public void ToAsn1Structure(){} // RVA: 0x7FFAF2DA8380
        public void GetEncryptedData(){} // RVA: 0x7FFAFC3675B0
        public void GetEncoded(){} // RVA: 0x7FFAFBF0AC10
        public void DecryptPrivateKeyInfo(){} // RVA: 0x7FFAFC3675F0
    }

    public class Pkcs8EncryptedPrivateKeyInfoBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void Build(){} // RVA: 0x7FFAFC3678C0
    }

    public class PkcsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC367C10 | overloaded x2
    }

    public class PkcsIOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88D54B0 | overloaded x2
    }

    public class PrivateKeyInfoFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void CreatePrivateKeyInfo(){} // RVA: 0x7FFAFC369500 | overloaded x4
        public void ExtractBytes(){} // RVA: 0x7FFAFC369760
    }

    public class X509CertificateEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC3597D0 | overloaded x3
        public void get_Certificate(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAFC369980
        public void GetHashCode(){} // RVA: 0x7FFAFC359910
    }

}