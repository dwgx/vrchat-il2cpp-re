// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509
// Classes: 25
// Methods: 302

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509
{
    public class AttributeCertificateHolder : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Holder DigestedObjectType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA508C0 | overloaded x5
        public void get_DigestedObjectType(){} // RVA: 0x7FFACBA50B80
        public void get_DigestAlgorithm(){} // RVA: 0x7FFACBA50C00
        public void GetObjectDigest(){} // RVA: 0x7FFACBA50C50
        public void get_OtherObjectTypeID(){} // RVA: 0x7FFACBA50CA0
        public void GenerateGeneralNames(){} // RVA: 0x7FFACBA50CE0
        public void MatchesDN(){} // RVA: 0x7FFACBA50DC0
        public void GetNames(){} // RVA: 0x7FFACBA50EE0
        public void GetPrincipals(){} // RVA: 0x7FFACBA51060
        public void GetEntityNames(){} // RVA: 0x7FFACBA51410
        public void GetIssuer(){} // RVA: 0x7FFACBA51450
        public void get_SerialNumber(){} // RVA: 0x7FFACBA51490
        public void Clone(){} // RVA: 0x7FFACBA514D0
        public void Match(){} // RVA: 0x7FFACBA51AC0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFACBA519E0
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

    public class AttributeCertificateIssuer : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable form; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA51B70 | overloaded x2
        public void GetNames(){} // RVA: 0x7FFACBA51CF0
        public void GetPrincipals(){} // RVA: 0x7FFACBA51F70
        public void MatchesDN(){} // RVA: 0x7FFACBA521B0
        public void Clone(){} // RVA: 0x7FFACBA522D0
        public void Match(){} // RVA: 0x7FFACBA52690 | overloaded x2
        public void Equals(){} // RVA: 0x7FFACBA525B0
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

    public class IX509AttributeCertificate
    {
        public object Version;
        public object SerialNumber;
        public object NotBefore;
        public object NotAfter;
        public object Holder;
        public object Issuer;
        public object IsValidNow;

        // ── Methods ──
        public void get_Version(){} // RVA: 0x7FFAC2C59960
        public void get_SerialNumber(){} // RVA: 0x7FFAC2C58E90
        public void get_NotBefore(){} // RVA: 0x7FFAC2C58E90
        public void get_NotAfter(){} // RVA: 0x7FFAC2C58E90
        public void get_Holder(){} // RVA: 0x7FFAC2C58E90
        public void get_Issuer(){} // RVA: 0x7FFAC2C58E90
        public void GetAttributes(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetIssuerUniqueID(){} // RVA: 0x7FFAC2C58E90
        public void get_IsValidNow(){} // RVA: 0x7FFAC2C59D00
        public void IsValid(){} // RVA: 0x7FFAC2C5A7E0
        public void CheckValidity(){} // RVA: 0x7FFAC2C70BF0 | overloaded x2
        public void GetSignature(){} // RVA: 0x7FFAC2C58E90
        public void Verify(){} // RVA: 0x7FFAC2C70A40
        public void GetEncoded(){} // RVA: 0x7FFAC2C58E90
    }

    public class IX509Extension
    {
        // ── Methods ──
        public void GetCriticalExtensionOids(){} // RVA: 0x7FFAC2C58E90
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7FFAC2C58E90
        public void GetExtensionValue(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
    }

    public class PemParser : Object
    {
        public string _header1; // 0x10
        public string _header2; // 0x18
        public string _footer1; // 0x20
        public string _footer2; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA52740
        public void ReadLine(){} // RVA: 0x7FFACBA52990
        public void ReadPemObject(){} // RVA: 0x7FFACBA52A60
    }

    public class PrincipalUtilities : Object
    {
        // ── Methods ──
        public void GetIssuerX509Principal(){} // RVA: 0x7FFACBA52EA0 | overloaded x2
        public void GetSubjectX509Principal(){} // RVA: 0x7FFACBA52DE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SubjectPublicKeyInfoFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateSubjectPublicKeyInfo(){} // RVA: 0x7FFACBA52F60
        public void ExtractBytes(){} // RVA: 0x7FFACBA545F0 | overloaded x2
    }

    public class X509AttrCertParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.PemParser PemAttrCertParser;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set sData; // 0x10
        public int sDataObjectCount; // 0x18
        public System.IO.Stream currentStream; // 0x20

        // ── Methods ──
        public void ReadDerCertificate(){} // RVA: 0x7FFACBA54710
        public void GetCertificate(){} // RVA: 0x7FFACBA54A20
        public void ReadPemCertificate(){} // RVA: 0x7FFACBA54B90
        public void ReadAttrCert(){} // RVA: 0x7FFACBA54EA0 | overloaded x2
        public void ReadAttrCerts(){} // RVA: 0x7FFACBA55360 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA554E0
    }

    public class X509Attribute : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttributeX509 Oid; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA55750 | overloaded x3
        public void get_Oid(){} // RVA: 0x7FFACBA55930
        public void GetValues(){} // RVA: 0x7FFACBA55960
        public void ToAsn1Object(){} // RVA: 0x7FFAC87BB0A0
    }

    public class X509CertPairParser : Object
    {
        public System.IO.Stream currentStream; // 0x10

        // ── Methods ──
        public void ReadDerCrossCertificatePair(){} // RVA: 0x7FFACBA5A090
        public void ReadCertPair(){} // RVA: 0x7FFACBA5A520 | overloaded x2
        public void ReadCertPairs(){} // RVA: 0x7FFACBA5A730 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X509Certificate : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure CertificateStructure; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.BasicConstraints IsValidNow; // 0x18
        public bool[] Version; // 0x20
        public object SerialNumber; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter IssuerDN; // 0x30
        public bool SubjectDN; // 0x38
        public int NotBefore; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA55B70 | overloaded x2
        public void get_CertificateStructure(){} // RVA: 0x7FFAC2F3C380
        public void get_IsValidNow(){} // RVA: 0x7FFACBA560C0
        public void IsValid(){} // RVA: 0x7FFACBA56130
        public void CheckValidity(){} // RVA: 0x7FFACBA562F0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFACBA56540
        public void get_SerialNumber(){} // RVA: 0x7FFACBA56560
        public void get_IssuerDN(){} // RVA: 0x7FFACBA56590
        public void get_SubjectDN(){} // RVA: 0x7FFACBA565C0
        public void get_NotBefore(){} // RVA: 0x7FFACBA565F0
        public void get_NotAfter(){} // RVA: 0x7FFACBA56620
        public void GetTbsCertificate(){} // RVA: 0x7FFACBA56650
        public void GetSignature(){} // RVA: 0x7FFACBA56680
        public void get_SigAlgName(){} // RVA: 0x7FFACBA566C0
        public void get_SigAlgOid(){} // RVA: 0x7FFACBA567F0
        public void GetSigAlgParams(){} // RVA: 0x7FFACBA56830
        public void get_IssuerUniqueID(){} // RVA: 0x7FFACBA568B0
        public void get_SubjectUniqueID(){} // RVA: 0x7FFACBA568E0
        public void GetKeyUsage(){} // RVA: 0x7FFACBA56910
        public void GetExtendedKeyUsage(){} // RVA: 0x7FFACBA56990
        public void GetBasicConstraints(){} // RVA: 0x7FFACBA56DB0
        public void GetSubjectAlternativeNames(){} // RVA: 0x7FFACBA56E40
        public void GetIssuerAlternativeNames(){} // RVA: 0x7FFACBA56E90
        public void GetAlternativeNames(){} // RVA: 0x7FFACBA56EE0
        public void GetX509Extensions(){} // RVA: 0x7FFACBA572D0
        public void GetPublicKey(){} // RVA: 0x7FFACBA57320
        public void GetEncoded(){} // RVA: 0x7FFACBA57690
        public void Equals(){} // RVA: 0x7FFACBA576B0
        public void GetHashCode(){} // RVA: 0x7FFACBA577F0
        public void ToString(){} // RVA: 0x7FFACBA57850
        public void Verify(){} // RVA: 0x7FFACBA58910 | overloaded x2
        public void CheckSignature(){} // RVA: 0x7FFACBA58990
        public void IsAlgIDEqual(){} // RVA: 0x7FFACBA58C70
    }

    public class X509CertificatePair : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate Forward; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate Reverse; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA58E50 | overloaded x2
        public void GetEncoded(){} // RVA: 0x7FFACBA58FC0
        public void get_Forward(){} // RVA: 0x7FFAC2F3C380
        public void get_Reverse(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFACBA59240
        public void GetHashCode(){} // RVA: 0x7FFACBA59360
    }

    public class X509CertificateParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.PemParser PemCertParser;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set sData; // 0x10
        public int sDataObjectCount; // 0x18
        public System.IO.Stream currentStream; // 0x20

        // ── Methods ──
        public void ReadDerCertificate(){} // RVA: 0x7FFACBA593E0
        public void GetCertificate(){} // RVA: 0x7FFACBA596E0
        public void ReadPemCertificate(){} // RVA: 0x7FFACBA597F0
        public void CreateX509Certificate(){} // RVA: 0x7FFACBA598A0
        public void ReadCertificate(){} // RVA: 0x7FFACBA59A00 | overloaded x2
        public void ReadCertificates(){} // RVA: 0x7FFACBA59E30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA59FB0
    }

    public class X509Crl : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.CertificateList Version; // 0x10
        public string IssuerDN; // 0x18
        public byte[] ThisUpdate; // 0x20
        public bool NextUpdate; // 0x28
        public bool SigAlgName; // 0x29
        public int SigAlgOid; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA5A8B0
        public void GetX509Extensions(){} // RVA: 0x7FFACBA5ABA0
        public void GetEncoded(){} // RVA: 0x7FFACBA5ABF0
        public void Verify(){} // RVA: 0x7FFACBA5AD50 | overloaded x2
        public void CheckSignature(){} // RVA: 0x7FFACBA5ADD0
        public void get_Version(){} // RVA: 0x7FFACBA56540
        public void get_IssuerDN(){} // RVA: 0x7FFACBA5B0D0
        public void get_ThisUpdate(){} // RVA: 0x7FFACBA5B100
        public void get_NextUpdate(){} // RVA: 0x7FFACBA5B130
        public void LoadCrlEntries(){} // RVA: 0x7FFACBA5B1B0
        public void GetRevokedCertificate(){} // RVA: 0x7FFACBA5B540
        public void GetRevokedCertificates(){} // RVA: 0x7FFACBA5B810
        public void GetTbsCertList(){} // RVA: 0x7FFACBA5B880
        public void GetSignature(){} // RVA: 0x7FFACBA56680
        public void get_SigAlgName(){} // RVA: 0x7FFAC2F247C0
        public void get_SigAlgOid(){} // RVA: 0x7FFACBA567F0
        public void GetSigAlgParams(){} // RVA: 0x7FFACBA5B930
        public void Equals(){} // RVA: 0x7FFACBA5B9E0
        public void GetHashCode(){} // RVA: 0x7FFACBA5BB20
        public void ToString(){} // RVA: 0x7FFACBA5BB80
        public void IsRevoked(){} // RVA: 0x7FFACBA5CE20
        public void get_IsIndirectCrl(){} // RVA: 0x7FFACBA5CF10
    }

    public class X509CrlEntry : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.CrlEntry SerialNumber; // 0x10
        public bool RevocationDate; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name HasExtensions; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name certificateIssuer; // 0x28
        public bool hashValueSet; // 0x30
        public int hashValue; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA5D150 | overloaded x2
        public void loadCertificateIssuer(){} // RVA: 0x7FFACBA5D280
        public void GetCertificateIssuer(){} // RVA: 0x7FFAC2F4F130
        public void GetX509Extensions(){} // RVA: 0x7FFACBA5D3F0
        public void GetEncoded(){} // RVA: 0x7FFACBA5D410
        public void get_SerialNumber(){} // RVA: 0x7FFACBA5D4B0
        public void get_RevocationDate(){} // RVA: 0x7FFACBA5D4E0
        public void get_HasExtensions(){} // RVA: 0x7FFACBA5D510
        public void Equals(){} // RVA: 0x7FFACBA5D540
        public void GetHashCode(){} // RVA: 0x7FFACBA5D640
        public void ToString(){} // RVA: 0x7FFACBA5D6A0
    }

    public class X509CrlParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.PemParser PemCrlParser;
        public bool lazyAsn1; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set sCrlData; // 0x18
        public int sCrlDataObjectCount; // 0x20
        public System.IO.Stream currentCrlStream; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0 | overloaded x2
        public void ReadPemCrl(){} // RVA: 0x7FFACBA5DF70
        public void ReadDerCrl(){} // RVA: 0x7FFACBA5E020
        public void GetCrl(){} // RVA: 0x7FFACBA5E320
        public void CreateX509Crl(){} // RVA: 0x7FFACBA5E3C0
        public void ReadCrl(){} // RVA: 0x7FFACBA5E660 | overloaded x2
        public void ReadCrls(){} // RVA: 0x7FFACBA5EA90 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFACBA5EC10
    }

    public class X509ExtensionBase : Object
    {
        // ── Methods ──
        public void GetX509Extensions(){} // RVA: 0x7FFAC2C58E90
        public void GetExtensionOids(){} // RVA: 0x7FFACBA5ECF0
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7FFAC4004050
        public void GetCriticalExtensionOids(){} // RVA: 0x7FFACBA5F000
        public void GetExtensionValue(){} // RVA: 0x7FFACBA5F0A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X509KeyUsage : Asn1Encodable
    {
        public int DigitalSignature;
        public int NonRepudiation;
        public int KeyEncipherment;
        public int DataEncipherment;
        public int KeyAgreement;
        public int KeyCertSign;
        public int CrlSign;
        public int EncipherOnly;
        public int DecipherOnly;
        public int usage; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBA5F0F0
    }

    public class X509SignatureUtilities : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Null derNull;

        // ── Methods ──
        public void SetSignatureParameters(){} // RVA: 0x7FFACBA5F190
        public void GetSignatureName(){} // RVA: 0x7FFACBA5F220
        public void GetDigestAlgName(){} // RVA: 0x7FFACBA5F560
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA5FA40
    }

    public class X509Utilities : Object
    {
        public System.Collections.IDictionary algorithms;
        public System.Collections.IDictionary exParams; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet noParams; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBA5FB10
        public void CreatePssParams(){} // RVA: 0x7FFACBA61340
        public void GetAlgorithmOid(){} // RVA: 0x7FFACBA61490
        public void GetSigAlgID(){} // RVA: 0x7FFACBA61620
        public void GetAlgNames(){} // RVA: 0x7FFACBA61910
        public void GetSignatureForObject(){} // RVA: 0x7FFACBA61A60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X509V1CertificateGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.V1TbsCertificateGenerator SignatureAlgNames; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sigOID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId; // 0x20
        public string signatureAlgorithm; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA61C10
        public void Reset(){} // RVA: 0x7FFACBA61CB0
        public void SetSerialNumber(){} // RVA: 0x7FFACBA61D50
        public void SetIssuerDN(){} // RVA: 0x7FFACBA61EE0
        public void SetNotBefore(){} // RVA: 0x7FFACBA61F50
        public void SetNotAfter(){} // RVA: 0x7FFACBA62010
        public void SetSubjectDN(){} // RVA: 0x7FFAC3773210
        public void SetPublicKey(){} // RVA: 0x7FFACBA620D0
        public void SetSignatureAlgorithm(){} // RVA: 0x7FFACBA621E0
        public void Generate(){} // RVA: 0x7FFACBA62570 | overloaded x3
        public void GenerateJcaObject(){} // RVA: 0x7FFACBA62880
        public void get_SignatureAlgNames(){} // RVA: 0x7FFACBA62A60
    }

    public class X509V2AttributeCertificate : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttributeCertificate Version; // 0x10
        public System.DateTime SerialNumber; // 0x18
        public System.DateTime Holder; // 0x20

        // ── Methods ──
        public void GetObject(){} // RVA: 0x7FFACBA62AB0
        public void .ctor(){} // RVA: 0x7FFACBA62C10 | overloaded x3
        public void get_Version(){} // RVA: 0x7FFACBA62D50
        public void get_SerialNumber(){} // RVA: 0x7FFACBA62DD0
        public void get_Holder(){} // RVA: 0x7FFACBA62E00
        public void get_Issuer(){} // RVA: 0x7FFACBA62EE0
        public void get_NotBefore(){} // RVA: 0x7FFAC2F247C0
        public void get_NotAfter(){} // RVA: 0x7FFAC2F4F0C0
        public void GetIssuerUniqueID(){} // RVA: 0x7FFACBA62F90
        public void get_IsValidNow(){} // RVA: 0x7FFACBA630C0
        public void IsValid(){} // RVA: 0x7FFACBA63130
        public void CheckValidity(){} // RVA: 0x7FFACBA632F0 | overloaded x2
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC356B610
        public void GetSignature(){} // RVA: 0x7FFACBA56680
        public void Verify(){} // RVA: 0x7FFACBA635F0 | overloaded x2
        public void CheckSignature(){} // RVA: 0x7FFACBA63670
        public void GetEncoded(){} // RVA: 0x7FFACBA639C0
        public void GetX509Extensions(){} // RVA: 0x7FFACBA639E0
        public void GetAttributes(){} // RVA: 0x7FFACBA63C30 | overloaded x2
        public void Equals(){} // RVA: 0x7FFACBA64130
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

    public class X509V2AttributeCertificateGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator SignatureAlgNames; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.V2AttributeCertificateInfoGenerator acInfoGen; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sigOID; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId; // 0x28
        public string signatureAlgorithm; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA64200
        public void Reset(){} // RVA: 0x7FFACBA64340
        public void SetHolder(){} // RVA: 0x7FFACBA64400
        public void SetIssuer(){} // RVA: 0x7FFACBA64470
        public void SetSerialNumber(){} // RVA: 0x7FFACBA644F0
        public void SetNotBefore(){} // RVA: 0x7FFACBA64670
        public void SetNotAfter(){} // RVA: 0x7FFACBA64730
        public void SetSignatureAlgorithm(){} // RVA: 0x7FFACBA647F0
        public void AddAttribute(){} // RVA: 0x7FFACBA64A40
        public void SetIssuerUniqueId(){} // RVA: 0x7FFACBA64AA0
        public void AddExtension(){} // RVA: 0x7FFACBA64BA0 | overloaded x2
        public void Generate(){} // RVA: 0x7FFACBA64D80 | overloaded x3
        public void get_SignatureAlgNames(){} // RVA: 0x7FFACBA65300
    }

    public class X509V2CrlGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator SignatureAlgNames; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.V2TbsCertListGenerator tbsGen; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sigOID; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId; // 0x28
        public string signatureAlgorithm; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA65350
        public void Reset(){} // RVA: 0x7FFACBA65490
        public void SetIssuerDN(){} // RVA: 0x7FFAC88048F0
        public void SetThisUpdate(){} // RVA: 0x7FFACBA65550
        public void SetNextUpdate(){} // RVA: 0x7FFACBA65610
        public void AddCrlEntry(){} // RVA: 0x7FFACBA659E0 | overloaded x3
        public void AddCrl(){} // RVA: 0x7FFACBA65B40
        public void SetSignatureAlgorithm(){} // RVA: 0x7FFACBA65E20
        public void AddExtension(){} // RVA: 0x7FFACBA662C0 | overloaded x4
        public void Generate(){} // RVA: 0x7FFACBA66520 | overloaded x3
        public void GenerateCertList(){} // RVA: 0x7FFACBA66900
        public void GenerateJcaObject(){} // RVA: 0x7FFACBA669F0
        public void get_SignatureAlgNames(){} // RVA: 0x7FFACBA66BC0
    }

    public class X509V3CertificateGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator SignatureAlgNames; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.V3TbsCertificateGenerator tbsGen; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sigOid; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId; // 0x28
        public string signatureAlgorithm; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA66C10
        public void Reset(){} // RVA: 0x7FFACBA66D50
        public void SetSerialNumber(){} // RVA: 0x7FFACBA66E10
        public void SetIssuerDN(){} // RVA: 0x7FFACBA66FA0
        public void SetNotBefore(){} // RVA: 0x7FFACBA67010
        public void SetNotAfter(){} // RVA: 0x7FFACBA670D0
        public void SetSubjectDN(){} // RVA: 0x7FFACBA67190
        public void SetPublicKey(){} // RVA: 0x7FFACBA67200
        public void SetSignatureAlgorithm(){} // RVA: 0x7FFACBA67270
        public void SetSubjectUniqueID(){} // RVA: 0x7FFACBA674D0
        public void SetIssuerUniqueID(){} // RVA: 0x7FFACBA67540
        public void booleanToBitString(){} // RVA: 0x7FFACBA675B0
        public void AddExtension(){} // RVA: 0x7FFACBA678F0 | overloaded x4
        public void CopyAndAddExtension(){} // RVA: 0x7FFACBA67AC0 | overloaded x2
        public void Generate(){} // RVA: 0x7FFACBA67D90 | overloaded x3
        public void GenerateJcaObject(){} // RVA: 0x7FFACBA681E0
        public void get_SignatureAlgNames(){} // RVA: 0x7FFACBA683C0
    }

}