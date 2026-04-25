// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
// Classes: 14
// Methods: 103

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs
{
    public class AsymmetricKeyEntry : Pkcs12Entry
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter Key; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBEAD950 | overloaded x3
        public void get_Key(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFACBEAD9D0
        public void GetHashCode(){} // RVA: 0x7FFACBEADA90
    }

    public class EncryptedPrivateKeyInfoFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateEncryptedPrivateKeyInfo(){} // RVA: 0x7FFACBEADBA0 | overloaded x3
    }

    public class Pkcs10CertificationRequest : CertificationRequest
    {
        public System.Collections.IDictionary algorithms;
        public System.Collections.IDictionary exParams; // 0x8
        public System.Collections.IDictionary keyAlgorithms; // 0x10
        public System.Collections.IDictionary oids; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet noParams; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBEADDF0
        public void CreatePssParams(){} // RVA: 0x7FFACBEAFE50
        public void .ctor(){} // RVA: 0x7FFACBEB02D0 | overloaded x7
        public void Init(){} // RVA: 0x7FFACBEB0450
        public void GetPublicKey(){} // RVA: 0x7FFACBEB0850
        public void Verify(){} // RVA: 0x7FFACBEB0AF0 | overloaded x4
        public void SetSignatureParameters(){} // RVA: 0x7FFACBEB0D70
        public void GetSignatureName(){} // RVA: 0x7FFACBEB0EB0
        public void GetDigestAlgName(){} // RVA: 0x7FFACBEB10B0
    }

    public class Pkcs10CertificationRequestDelaySigned : Pkcs10CertificationRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBEB1800 | overloaded x6
        public void GetDataToSign(){} // RVA: 0x7FFACBA57690
        public void SignRequest(){} // RVA: 0x7FFAC2F4F0D0 | overloaded x2
    }

    public class Pkcs12Entry : Object
    {
        public System.Collections.IDictionary Item; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBEB1E60
        public void GetBagAttribute(){} // RVA: 0x7FFACBEB2300 | overloaded x2
        public void GetBagAttributeKeys(){} // RVA: 0x7FFACBEB23B0
        public void get_Item(){} // RVA: 0x7FFACBEB24F0 | overloaded x2
        public void get_BagAttributeKeys(){} // RVA: 0x7FFACBEB25A0
    }

    public class Pkcs12Store : Object
    {
        public IgnoresCaseHashtable Aliases; // 0x10
        public System.Collections.IDictionary Count; // 0x18
        public IgnoresCaseHashtable certs; // 0x20
        public System.Collections.IDictionary chainCerts; // 0x28
        public System.Collections.IDictionary keyCerts; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier keyAlgorithm; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier certAlgorithm; // 0x40
        public bool useDerEncoding; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs.AsymmetricKeyEntry unmarkedKeyEntry; // 0x50
        public int MinIterations;
        public int SaltSize;

        // ── Methods ──
        public void CreateSubjectKeyID(){} // RVA: 0x7FFACBEB26B0
        public void .ctor(){} // RVA: 0x7FFACBEB2B70 | overloaded x3
        public void LoadKeyBag(){} // RVA: 0x7FFACBEB2C20
        public void LoadPkcs8ShroudedKeyBag(){} // RVA: 0x7FFACBEB33E0
        public void Load(){} // RVA: 0x7FFACBEB3440
        public void GetKey(){} // RVA: 0x7FFACBEB4B90
        public void IsCertificateEntry(){} // RVA: 0x7FFACBEB4C80
        public void IsKeyEntry(){} // RVA: 0x7FFACBEB4D30
        public void GetAliasesTable(){} // RVA: 0x7FFACBEB4DB0
        public void get_Aliases(){} // RVA: 0x7FFACBEB5490
        public void ContainsAlias(){} // RVA: 0x7FFACBEB55B0
        public void GetCertificate(){} // RVA: 0x7FFACBEB5610
        public void GetCertificateAlias(){} // RVA: 0x7FFACBEB5850
        public void GetCertificateChain(){} // RVA: 0x7FFACBEB5DA0
        public void SetCertificateEntry(){} // RVA: 0x7FFACBEB65E0
        public void SetKeyEntry(){} // RVA: 0x7FFACBEB6800
        public void DeleteEntry(){} // RVA: 0x7FFACBEB6B80
        public void IsEntryOfType(){} // RVA: 0x7FFACBEB6FC0
        public void Size(){} // RVA: 0x7FFACBEB71F0
        public void get_Count(){} // RVA: 0x7FFACBEB71F0
        public void Save(){} // RVA: 0x7FFACBEB7250
        public void CalculatePbeMac(){} // RVA: 0x7FFACBEB9FB0
        public void CryptPbeData(){} // RVA: 0x7FFACBEBA2A0
    }

    public class Pkcs12StoreBuilder : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier keyAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier certAlgorithm; // 0x18
        public bool useDerEncoding; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBEBAE30
        public void Build(){} // RVA: 0x7FFACBEBAF50
        public void SetCertAlgorithm(){} // RVA: 0x7FFAC46D4B40
        public void SetKeyAlgorithm(){} // RVA: 0x7FFAC499AB80
        public void SetUseDerEncoding(){} // RVA: 0x7FFACBEBAFE0
    }

    public class Pkcs12Utilities : Object
    {
        // ── Methods ──
        public void ConvertToDefiniteLength(){} // RVA: 0x7FFACBEBB090 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Pkcs8EncryptedPrivateKeyInfo : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo encryptedPrivateKeyInfo; // 0x10

        // ── Methods ──
        public void parseBytes(){} // RVA: 0x7FFACBEBB580
        public void .ctor(){} // RVA: 0x7FFACBEBB6C0 | overloaded x2
        public void ToAsn1Structure(){} // RVA: 0x7FFAC2F3C380
        public void GetEncryptedData(){} // RVA: 0x7FFACBEBB730
        public void GetEncoded(){} // RVA: 0x7FFACBA639C0
        public void DecryptPrivateKeyInfo(){} // RVA: 0x7FFACBEBB770
    }

    public class Pkcs8EncryptedPrivateKeyInfoBuilder : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo privateKeyInfo; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void Build(){} // RVA: 0x7FFACBEBBA40
    }

    public class PkcsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBEBBD90 | overloaded x2
    }

    public class PkcsIOException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85BCB20 | overloaded x2
    }

    public class PrivateKeyInfoFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreatePrivateKeyInfo(){} // RVA: 0x7FFACBEBD680 | overloaded x4
        public void ExtractBytes(){} // RVA: 0x7FFACBEBD8E0
    }

    public class X509CertificateEntry : Pkcs12Entry
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate Certificate; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBEAD950 | overloaded x3
        public void get_Certificate(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFACBEBDB00
        public void GetHashCode(){} // RVA: 0x7FFACBEADA90
    }

}