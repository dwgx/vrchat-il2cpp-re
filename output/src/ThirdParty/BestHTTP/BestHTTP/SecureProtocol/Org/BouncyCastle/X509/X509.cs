// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509
// Classes: 25
// Methods: 302

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509
{
    public class AttributeCertificateHolder : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Holder holder; // 0x10
        public object field_1; // 0x8B
        public object field_2; // 0x8C
        public object field_3; // 0x8D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EA9EE0 | overloaded x5
        public void get_DigestedObjectType(){} // RVA: 0x7FFE89EAA1A0
        public void get_DigestAlgorithm(){} // RVA: 0x7FFE89EAA220
        public void GetObjectDigest(){} // RVA: 0x7FFE89EAA270
        public void get_OtherObjectTypeID(){} // RVA: 0x7FFE89EAA2C0
        public void GenerateGeneralNames(){} // RVA: 0x7FFE89EAA300
        public void MatchesDN(){} // RVA: 0x7FFE89EAA3E0
        public void GetNames(){} // RVA: 0x7FFE89EAA500
        public void GetPrincipals(){} // RVA: 0x7FFE89EAA680
        public void GetEntityNames(){} // RVA: 0x7FFE89EAAA30
        public void GetIssuer(){} // RVA: 0x7FFE89EAAA70
        public void get_SerialNumber(){} // RVA: 0x7FFE89EAAAB0
        public void Clone(){} // RVA: 0x7FFE89EAAAF0
        public void Match(){} // RVA: 0x7FFE89EAB0E0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE89EAB000
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

    public class AttributeCertificateIssuer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EAB190 | overloaded x2
        public void GetNames(){} // RVA: 0x7FFE89EAB310
        public void GetPrincipals(){} // RVA: 0x7FFE89EAB590
        public void MatchesDN(){} // RVA: 0x7FFE89EAB7D0
        public void Clone(){} // RVA: 0x7FFE89EAB8F0
        public void Match(){} // RVA: 0x7FFE89EABCB0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE89EABBD0
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

    public class IX509AttributeCertificate
    {
        // ── Methods ──
        public void get_Version(){} // RVA: 0x7FFE80E2EDB0
        public void get_SerialNumber(){} // RVA: 0x7FFE80E2E2E0
        public void get_NotBefore(){} // RVA: 0x7FFE80E2E2E0
        public void get_NotAfter(){} // RVA: 0x7FFE80E2E2E0
        public void get_Holder(){} // RVA: 0x7FFE80E2E2E0
        public void get_Issuer(){} // RVA: 0x7FFE80E2E2E0
        public void GetAttributes(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetIssuerUniqueID(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsValidNow(){} // RVA: 0x7FFE80E2F150
        public void IsValid(){} // RVA: 0x7FFE80E2FC30
        public void CheckValidity(){} // RVA: 0x7FFE80E46250 | overloaded x2
        public void GetSignature(){} // RVA: 0x7FFE80E2E2E0
        public void Verify(){} // RVA: 0x7FFE80E460A0
        public void GetEncoded(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IX509Extension
    {
        // ── Methods ──
        public void GetCriticalExtensionOids(){} // RVA: 0x7FFE80E2E2E0
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7FFE80E2E2E0
        public void GetExtensionValue(){} // RVA: 0x7FFE80E2E390 | overloaded x2
    }

    public class PemParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EABD60
        public void ReadLine(){} // RVA: 0x7FFE89EABFB0
        public void ReadPemObject(){} // RVA: 0x7FFE89EAC080
    }

    public class PrincipalUtilities : Object
    {
        // ── Methods ──
        public void GetIssuerX509Principal(){} // RVA: 0x7FFE89EAC4C0 | overloaded x2
        public void GetSubjectX509Principal(){} // RVA: 0x7FFE89EAC400
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SubjectPublicKeyInfoFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreateSubjectPublicKeyInfo(){} // RVA: 0x7FFE89EAC580
        public void ExtractBytes(){} // RVA: 0x7FFE89EADC10 | overloaded x2
    }

    public class X509AttrCertParser : Object
    {
        // ── Methods ──
        public void ReadDerCertificate(){} // RVA: 0x7FFE89EADD30
        public void GetCertificate(){} // RVA: 0x7FFE89EAE040
        public void ReadPemCertificate(){} // RVA: 0x7FFE89EAE1B0
        public void ReadAttrCert(){} // RVA: 0x7FFE89EAE4C0 | overloaded x2
        public void ReadAttrCerts(){} // RVA: 0x7FFE89EAE980 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89EAEB00
    }

    public class X509Attribute : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttributeX509 attr; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EAED70 | overloaded x3
        public void get_Oid(){} // RVA: 0x7FFE89EAEF50
        public void GetValues(){} // RVA: 0x7FFE89EAEF80
        public void ToAsn1Object(){} // RVA: 0x7FFE815888E0
    }

    public class X509CertPairParser : Object
    {
        // ── Methods ──
        public void ReadDerCrossCertificatePair(){} // RVA: 0x7FFE89EB36B0
        public void ReadCertPair(){} // RVA: 0x7FFE89EB3B40 | overloaded x2
        public void ReadCertPairs(){} // RVA: 0x7FFE89EB3D50 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X509Certificate : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure c; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.BasicConstraints basicConstraints; // 0x18
        public bool[] keyUsage; // 0x20
        public object cacheLock; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKeyValue; // 0x30
        public bool hashValueSet; // 0x38
        public int hashValue; // 0x3C
        public object field_7; // 0x97
        public object field_8; // 0x98
        public object field_9; // 0x99
        public object field_10; // 0x9A
        public object field_11; // 0x9B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EAF190 | overloaded x2
        public void get_CertificateStructure(){} // RVA: 0x7FFE81116380
        public void get_IsValidNow(){} // RVA: 0x7FFE89EAF6E0
        public void IsValid(){} // RVA: 0x7FFE89EAF750
        public void CheckValidity(){} // RVA: 0x7FFE89EAF910 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE89EAFB60
        public void get_SerialNumber(){} // RVA: 0x7FFE89EAFB80
        public void get_IssuerDN(){} // RVA: 0x7FFE89EAFBB0
        public void get_SubjectDN(){} // RVA: 0x7FFE89EAFBE0
        public void get_NotBefore(){} // RVA: 0x7FFE89EAFC10
        public void get_NotAfter(){} // RVA: 0x7FFE89EAFC40
        public void GetTbsCertificate(){} // RVA: 0x7FFE89EAFC70
        public void GetSignature(){} // RVA: 0x7FFE89EAFCA0
        public void get_SigAlgName(){} // RVA: 0x7FFE89EAFCE0
        public void get_SigAlgOid(){} // RVA: 0x7FFE89EAFE10
        public void GetSigAlgParams(){} // RVA: 0x7FFE89EAFE50
        public void get_IssuerUniqueID(){} // RVA: 0x7FFE89EAFED0
        public void get_SubjectUniqueID(){} // RVA: 0x7FFE89EAFF00
        public void GetKeyUsage(){} // RVA: 0x7FFE89EAFF30
        public void GetExtendedKeyUsage(){} // RVA: 0x7FFE89EAFFB0
        public void GetBasicConstraints(){} // RVA: 0x7FFE89EB03D0
        public void GetSubjectAlternativeNames(){} // RVA: 0x7FFE89EB0460
        public void GetIssuerAlternativeNames(){} // RVA: 0x7FFE89EB04B0
        public void GetAlternativeNames(){} // RVA: 0x7FFE89EB0500
        public void GetX509Extensions(){} // RVA: 0x7FFE89EB08F0
        public void GetPublicKey(){} // RVA: 0x7FFE89EB0940
        public void GetEncoded(){} // RVA: 0x7FFE89EB0CB0
        public void Equals(){} // RVA: 0x7FFE89EB0CD0
        public void GetHashCode(){} // RVA: 0x7FFE89EB0E10
        public void ToString(){} // RVA: 0x7FFE89EB0E70
        public void Verify(){} // RVA: 0x7FFE89EB1F30 | overloaded x2
        public void CheckSignature(){} // RVA: 0x7FFE89EB1FB0
        public void IsAlgIDEqual(){} // RVA: 0x7FFE89EB2290
    }

    public class X509CertificatePair : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate forward; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate reverse; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EB2470 | overloaded x2
        public void GetEncoded(){} // RVA: 0x7FFE89EB25E0
        public void get_Forward(){} // RVA: 0x7FFE81116380
        public void get_Reverse(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE89EB2860
        public void GetHashCode(){} // RVA: 0x7FFE89EB2980
    }

    public class X509CertificateParser : Object
    {
        // ── Methods ──
        public void ReadDerCertificate(){} // RVA: 0x7FFE89EB2A00
        public void GetCertificate(){} // RVA: 0x7FFE89EB2D00
        public void ReadPemCertificate(){} // RVA: 0x7FFE89EB2E10
        public void CreateX509Certificate(){} // RVA: 0x7FFE89EB2EC0
        public void ReadCertificate(){} // RVA: 0x7FFE89EB3020 | overloaded x2
        public void ReadCertificates(){} // RVA: 0x7FFE89EB3450 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89EB35D0
    }

    public class X509Crl : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.CertificateList c; // 0x10
        public string sigAlgName; // 0x18
        public byte[] sigAlgParams; // 0x20
        public bool isIndirect; // 0x28
        public bool hashValueSet; // 0x29
        public int hashValue; // 0x2C
        public object field_6; // 0xA5

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EB3ED0
        public void GetX509Extensions(){} // RVA: 0x7FFE89EB41C0
        public void GetEncoded(){} // RVA: 0x7FFE89EB4210
        public void Verify(){} // RVA: 0x7FFE89EB4370 | overloaded x2
        public void CheckSignature(){} // RVA: 0x7FFE89EB43F0
        public void get_Version(){} // RVA: 0x7FFE89EAFB60
        public void get_IssuerDN(){} // RVA: 0x7FFE89EB46F0
        public void get_ThisUpdate(){} // RVA: 0x7FFE89EB4720
        public void get_NextUpdate(){} // RVA: 0x7FFE89EB4750
        public void LoadCrlEntries(){} // RVA: 0x7FFE89EB47D0
        public void GetRevokedCertificate(){} // RVA: 0x7FFE89EB4B60
        public void GetRevokedCertificates(){} // RVA: 0x7FFE89EB4E30
        public void GetTbsCertList(){} // RVA: 0x7FFE89EB4EA0
        public void GetSignature(){} // RVA: 0x7FFE89EAFCA0
        public void get_SigAlgName(){} // RVA: 0x7FFE810FE7C0
        public void get_SigAlgOid(){} // RVA: 0x7FFE89EAFE10
        public void GetSigAlgParams(){} // RVA: 0x7FFE89EB4F50
        public void Equals(){} // RVA: 0x7FFE89EB5000
        public void GetHashCode(){} // RVA: 0x7FFE89EB5140
        public void ToString(){} // RVA: 0x7FFE89EB51A0
        public void IsRevoked(){} // RVA: 0x7FFE89EB6440
        public void get_IsIndirectCrl(){} // RVA: 0x7FFE89EB6530
    }

    public class X509CrlEntry : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.CrlEntry c; // 0x10
        public bool isIndirect; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name previousCertificateIssuer; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EB6770 | overloaded x2
        public void loadCertificateIssuer(){} // RVA: 0x7FFE89EB68A0
        public void GetCertificateIssuer(){} // RVA: 0x7FFE81129130
        public void GetX509Extensions(){} // RVA: 0x7FFE89EB6A10
        public void GetEncoded(){} // RVA: 0x7FFE89EB6A30
        public void get_SerialNumber(){} // RVA: 0x7FFE89EB6AD0
        public void get_RevocationDate(){} // RVA: 0x7FFE89EB6B00
        public void get_HasExtensions(){} // RVA: 0x7FFE89EB6B30
        public void Equals(){} // RVA: 0x7FFE89EB6B60
        public void GetHashCode(){} // RVA: 0x7FFE89EB6C60
        public void ToString(){} // RVA: 0x7FFE89EB6CC0
    }

    public class X509CrlParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0 | overloaded x2
        public void ReadPemCrl(){} // RVA: 0x7FFE89EB7590
        public void ReadDerCrl(){} // RVA: 0x7FFE89EB7640
        public void GetCrl(){} // RVA: 0x7FFE89EB7940
        public void CreateX509Crl(){} // RVA: 0x7FFE89EB79E0
        public void ReadCrl(){} // RVA: 0x7FFE89EB7C80 | overloaded x2
        public void ReadCrls(){} // RVA: 0x7FFE89EB80B0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE89EB8230
    }

    public class X509ExtensionBase : Object
    {
        // ── Methods ──
        public void GetX509Extensions(){} // RVA: 0x7FFE80E2E2E0
        public void GetExtensionOids(){} // RVA: 0x7FFE89EB8310
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7FFE877DD110
        public void GetCriticalExtensionOids(){} // RVA: 0x7FFE89EB8620
        public void GetExtensionValue(){} // RVA: 0x7FFE89EB86C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X509KeyUsage : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void ToAsn1Object(){} // RVA: 0x7FFE89EB8710
    }

    public class X509SignatureUtilities : Object
    {
        // ── Methods ──
        public void SetSignatureParameters(){} // RVA: 0x7FFE89EB87B0
        public void GetSignatureName(){} // RVA: 0x7FFE89EB8840
        public void GetDigestAlgName(){} // RVA: 0x7FFE89EB8B80
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89EB9060
    }

    public class X509Utilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE89EB9130
        public void CreatePssParams(){} // RVA: 0x7FFE89EBA960
        public void GetAlgorithmOid(){} // RVA: 0x7FFE89EBAAB0
        public void GetSigAlgID(){} // RVA: 0x7FFE89EBAC40
        public void GetAlgNames(){} // RVA: 0x7FFE89EBAF30
        public void GetSignatureForObject(){} // RVA: 0x7FFE89EBB080
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X509V1CertificateGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.V1TbsCertificateGenerator tbsGen; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EBB230
        public void Reset(){} // RVA: 0x7FFE89EBB2D0
        public void SetSerialNumber(){} // RVA: 0x7FFE89EBB370
        public void SetIssuerDN(){} // RVA: 0x7FFE89EBB500
        public void SetNotBefore(){} // RVA: 0x7FFE89EBB570
        public void SetNotAfter(){} // RVA: 0x7FFE89EBB630
        public void SetSubjectDN(){} // RVA: 0x7FFE8189BBB0
        public void SetPublicKey(){} // RVA: 0x7FFE89EBB6F0
        public void SetSignatureAlgorithm(){} // RVA: 0x7FFE89EBB800
        public void Generate(){} // RVA: 0x7FFE89EBBB90 | overloaded x3
        public void GenerateJcaObject(){} // RVA: 0x7FFE89EBBEA0
        public void get_SignatureAlgNames(){} // RVA: 0x7FFE89EBC080
    }

    public class X509V2AttributeCertificate : X509ExtensionBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttributeCertificate cert; // 0x10
        public System.DateTime notBefore; // 0x18
        public System.DateTime notAfter; // 0x20
        public object field_3; // 0xB0
        public object field_4; // 0xB1
        public object field_5; // 0xB2
        public object field_6; // 0xB3
        public object field_7; // 0xB4

        // ── Methods ──
        public void GetObject(){} // RVA: 0x7FFE89EBC0D0
        public void .ctor(){} // RVA: 0x7FFE89EBC230 | overloaded x3
        public void get_Version(){} // RVA: 0x7FFE89EBC370
        public void get_SerialNumber(){} // RVA: 0x7FFE89EBC3F0
        public void get_Holder(){} // RVA: 0x7FFE89EBC420
        public void get_Issuer(){} // RVA: 0x7FFE89EBC500
        public void get_NotBefore(){} // RVA: 0x7FFE810FE7C0
        public void get_NotAfter(){} // RVA: 0x7FFE811290C0
        public void GetIssuerUniqueID(){} // RVA: 0x7FFE89EBC5B0
        public void get_IsValidNow(){} // RVA: 0x7FFE89EBC6E0
        public void IsValid(){} // RVA: 0x7FFE89EBC750
        public void CheckValidity(){} // RVA: 0x7FFE89EBC910 | overloaded x2
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE8189C080
        public void GetSignature(){} // RVA: 0x7FFE89EAFCA0
        public void Verify(){} // RVA: 0x7FFE89EBCC10 | overloaded x2
        public void CheckSignature(){} // RVA: 0x7FFE89EBCC90
        public void GetEncoded(){} // RVA: 0x7FFE89EBCFE0
        public void GetX509Extensions(){} // RVA: 0x7FFE89EBD000
        public void GetAttributes(){} // RVA: 0x7FFE89EBD250 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE89EBD750
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

    public class X509V2AttributeCertificateGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator extGenerator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EBD820
        public void Reset(){} // RVA: 0x7FFE89EBD960
        public void SetHolder(){} // RVA: 0x7FFE89EBDA20
        public void SetIssuer(){} // RVA: 0x7FFE89EBDA90
        public void SetSerialNumber(){} // RVA: 0x7FFE89EBDB10
        public void SetNotBefore(){} // RVA: 0x7FFE89EBDC90
        public void SetNotAfter(){} // RVA: 0x7FFE89EBDD50
        public void SetSignatureAlgorithm(){} // RVA: 0x7FFE89EBDE10
        public void AddAttribute(){} // RVA: 0x7FFE89EBE060
        public void SetIssuerUniqueId(){} // RVA: 0x7FFE89EBE0C0
        public void AddExtension(){} // RVA: 0x7FFE89EBE1C0 | overloaded x2
        public void Generate(){} // RVA: 0x7FFE89EBE3A0 | overloaded x3
        public void get_SignatureAlgNames(){} // RVA: 0x7FFE89EBE920
    }

    public class X509V2CrlGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator extGenerator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EBE970
        public void Reset(){} // RVA: 0x7FFE89EBEAB0
        public void SetIssuerDN(){} // RVA: 0x7FFE86BAE010
        public void SetThisUpdate(){} // RVA: 0x7FFE89EBEB70
        public void SetNextUpdate(){} // RVA: 0x7FFE89EBEC30
        public void AddCrlEntry(){} // RVA: 0x7FFE89EBF000 | overloaded x3
        public void AddCrl(){} // RVA: 0x7FFE89EBF160
        public void SetSignatureAlgorithm(){} // RVA: 0x7FFE89EBF440
        public void AddExtension(){} // RVA: 0x7FFE89EBF8E0 | overloaded x4
        public void Generate(){} // RVA: 0x7FFE89EBFB40 | overloaded x3
        public void GenerateCertList(){} // RVA: 0x7FFE89EBFF20
        public void GenerateJcaObject(){} // RVA: 0x7FFE89EC0010
        public void get_SignatureAlgNames(){} // RVA: 0x7FFE89EC01E0
    }

    public class X509V3CertificateGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator extGenerator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EC0230
        public void Reset(){} // RVA: 0x7FFE89EC0370
        public void SetSerialNumber(){} // RVA: 0x7FFE89EC0430
        public void SetIssuerDN(){} // RVA: 0x7FFE89EC05C0
        public void SetNotBefore(){} // RVA: 0x7FFE89EC0630
        public void SetNotAfter(){} // RVA: 0x7FFE89EC06F0
        public void SetSubjectDN(){} // RVA: 0x7FFE89EC07B0
        public void SetPublicKey(){} // RVA: 0x7FFE89EC0820
        public void SetSignatureAlgorithm(){} // RVA: 0x7FFE89EC0890
        public void SetSubjectUniqueID(){} // RVA: 0x7FFE89EC0AF0
        public void SetIssuerUniqueID(){} // RVA: 0x7FFE89EC0B60
        public void booleanToBitString(){} // RVA: 0x7FFE89EC0BD0
        public void AddExtension(){} // RVA: 0x7FFE89EC0F10 | overloaded x4
        public void CopyAndAddExtension(){} // RVA: 0x7FFE89EC10E0 | overloaded x2
        public void Generate(){} // RVA: 0x7FFE89EC13B0 | overloaded x3
        public void GenerateJcaObject(){} // RVA: 0x7FFE89EC1800
        public void get_SignatureAlgNames(){} // RVA: 0x7FFE89EC19E0
    }

}