// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509
// Classes: 25
// Methods: 302

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509
{
    public class AttributeCertificateHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBEF7B10 | overloaded x5
        public void get_DigestedObjectType(){} // RVA: 0x7FFAFBEF7DD0
        public void get_DigestAlgorithm(){} // RVA: 0x7FFAFBEF7E50
        public void GetObjectDigest(){} // RVA: 0x7FFAFBEF7EA0
        public void get_OtherObjectTypeID(){} // RVA: 0x7FFAFBEF7EF0
        public void GenerateGeneralNames(){} // RVA: 0x7FFAFBEF7F30
        public void MatchesDN(){} // RVA: 0x7FFAFBEF8010
        public void GetNames(){} // RVA: 0x7FFAFBEF8130
        public void GetPrincipals(){} // RVA: 0x7FFAFBEF82B0
        public void GetEntityNames(){} // RVA: 0x7FFAFBEF8660
        public void GetIssuer(){} // RVA: 0x7FFAFBEF86A0
        public void get_SerialNumber(){} // RVA: 0x7FFAFBEF86E0
        public void Clone(){} // RVA: 0x7FFAFBEF8720
        public void Match(){} // RVA: 0x7FFAFBEF8D10 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAFBEF8C30
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
    }

    public class AttributeCertificateIssuer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBEF8DC0 | overloaded x2
        public void GetNames(){} // RVA: 0x7FFAFBEF8F40
        public void GetPrincipals(){} // RVA: 0x7FFAFBEF91C0
        public void MatchesDN(){} // RVA: 0x7FFAFBEF9400
        public void Clone(){} // RVA: 0x7FFAFBEF9520
        public void Match(){} // RVA: 0x7FFAFBEF98E0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAFBEF9800
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
    }

    public class IX509AttributeCertificate
    {
        // ── Methods ──
        public void get_Version(){} // RVA: 0x7FFAF2ABD840
        public void get_SerialNumber(){} // RVA: 0x7FFAF2ABCD60
        public void get_NotBefore(){} // RVA: 0x7FFAF2ABCD60
        public void get_NotAfter(){} // RVA: 0x7FFAF2ABCD60
        public void get_Holder(){} // RVA: 0x7FFAF2ABCD60
        public void get_Issuer(){} // RVA: 0x7FFAF2ABCD60
        public void GetAttributes(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetIssuerUniqueID(){} // RVA: 0x7FFAF2ABCD60
        public void get_IsValidNow(){} // RVA: 0x7FFAF2ABDBE0
        public void IsValid(){} // RVA: 0x7FFAF2ABE6C0
        public void CheckValidity(){} // RVA: 0x7FFAF2AD4CC0 | overloaded x2
        public void GetSignature(){} // RVA: 0x7FFAF2ABCD60
        public void Verify(){} // RVA: 0x7FFAF2AD4B10
        public void GetEncoded(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IX509Extension
    {
        // ── Methods ──
        public void GetCriticalExtensionOids(){} // RVA: 0x7FFAF2ABCD60
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7FFAF2ABCD60
        public void GetExtensionValue(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
    }

    public class PemParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBEF9990
        public void ReadLine(){} // RVA: 0x7FFAFBEF9BE0
        public void ReadPemObject(){} // RVA: 0x7FFAFBEF9CB0
    }

    public class PrincipalUtilities
    {
        // ── Methods ──
        public void GetIssuerX509Principal(){} // RVA: 0x7FFAFBEFA0F0 | overloaded x2
        public void GetSubjectX509Principal(){} // RVA: 0x7FFAFBEFA030
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SubjectPublicKeyInfoFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void CreateSubjectPublicKeyInfo(){} // RVA: 0x7FFAFBEFA1B0
        public void ExtractBytes(){} // RVA: 0x7FFAFBEFB840 | overloaded x2
    }

    public class X509AttrCertParser
    {
        // ── Methods ──
        public void ReadDerCertificate(){} // RVA: 0x7FFAFBEFB960
        public void GetCertificate(){} // RVA: 0x7FFAFBEFBC70
        public void ReadPemCertificate(){} // RVA: 0x7FFAFBEFBDE0
        public void ReadAttrCert(){} // RVA: 0x7FFAFBEFC0F0 | overloaded x2
        public void ReadAttrCerts(){} // RVA: 0x7FFAFBEFC5B0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFBEFC730
    }

    public class X509Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBEFC9A0 | overloaded x3
        public void get_Oid(){} // RVA: 0x7FFAFBEFCB80
        public void GetValues(){} // RVA: 0x7FFAFBEFCBB0
        public void ToAsn1Object(){} // RVA: 0x7FFAF32A0250
    }

    public class X509CertPairParser
    {
        // ── Methods ──
        public void ReadDerCrossCertificatePair(){} // RVA: 0x7FFAFBF012E0
        public void ReadCertPair(){} // RVA: 0x7FFAFBF01770 | overloaded x2
        public void ReadCertPairs(){} // RVA: 0x7FFAFBF01980 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X509Certificate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBEFCDC0 | overloaded x2
        public void get_CertificateStructure(){} // RVA: 0x7FFAF2DA8380
        public void get_IsValidNow(){} // RVA: 0x7FFAFBEFD310
        public void IsValid(){} // RVA: 0x7FFAFBEFD380
        public void CheckValidity(){} // RVA: 0x7FFAFBEFD540 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAFBEFD790
        public void get_SerialNumber(){} // RVA: 0x7FFAFBEFD7B0
        public void get_IssuerDN(){} // RVA: 0x7FFAFBEFD7E0
        public void get_SubjectDN(){} // RVA: 0x7FFAFBEFD810
        public void get_NotBefore(){} // RVA: 0x7FFAFBEFD840
        public void get_NotAfter(){} // RVA: 0x7FFAFBEFD870
        public void GetTbsCertificate(){} // RVA: 0x7FFAFBEFD8A0
        public void GetSignature(){} // RVA: 0x7FFAFBEFD8D0
        public void get_SigAlgName(){} // RVA: 0x7FFAFBEFD910
        public void get_SigAlgOid(){} // RVA: 0x7FFAFBEFDA40
        public void GetSigAlgParams(){} // RVA: 0x7FFAFBEFDA80
        public void get_IssuerUniqueID(){} // RVA: 0x7FFAFBEFDB00
        public void get_SubjectUniqueID(){} // RVA: 0x7FFAFBEFDB30
        public void GetKeyUsage(){} // RVA: 0x7FFAFBEFDB60
        public void GetExtendedKeyUsage(){} // RVA: 0x7FFAFBEFDBE0
        public void GetBasicConstraints(){} // RVA: 0x7FFAFBEFE000
        public void GetSubjectAlternativeNames(){} // RVA: 0x7FFAFBEFE090
        public void GetIssuerAlternativeNames(){} // RVA: 0x7FFAFBEFE0E0
        public void GetAlternativeNames(){} // RVA: 0x7FFAFBEFE130
        public void GetX509Extensions(){} // RVA: 0x7FFAFBEFE520
        public void GetPublicKey(){} // RVA: 0x7FFAFBEFE570
        public void GetEncoded(){} // RVA: 0x7FFAFBEFE8E0
        public void Equals(){} // RVA: 0x7FFAFBEFE900
        public void GetHashCode(){} // RVA: 0x7FFAFBEFEA40
        public void ToString(){} // RVA: 0x7FFAFBEFEAA0
        public void Verify(){} // RVA: 0x7FFAFBEFFB60 | overloaded x2
        public void CheckSignature(){} // RVA: 0x7FFAFBEFFBE0
        public void IsAlgIDEqual(){} // RVA: 0x7FFAFBEFFEC0
    }

    public class X509CertificatePair
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF000A0 | overloaded x2
        public void GetEncoded(){} // RVA: 0x7FFAFBF00210
        public void get_Forward(){} // RVA: 0x7FFAF2DA8380
        public void get_Reverse(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAFBF00490
        public void GetHashCode(){} // RVA: 0x7FFAFBF005B0
    }

    public class X509CertificateParser
    {
        // ── Methods ──
        public void ReadDerCertificate(){} // RVA: 0x7FFAFBF00630
        public void GetCertificate(){} // RVA: 0x7FFAFBF00930
        public void ReadPemCertificate(){} // RVA: 0x7FFAFBF00A40
        public void CreateX509Certificate(){} // RVA: 0x7FFAFBF00AF0
        public void ReadCertificate(){} // RVA: 0x7FFAFBF00C50 | overloaded x2
        public void ReadCertificates(){} // RVA: 0x7FFAFBF01080 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFBF01200
    }

    public class X509Crl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF01B00
        public void GetX509Extensions(){} // RVA: 0x7FFAFBF01DF0
        public void GetEncoded(){} // RVA: 0x7FFAFBF01E40
        public void Verify(){} // RVA: 0x7FFAFBF01FA0 | overloaded x2
        public void CheckSignature(){} // RVA: 0x7FFAFBF02020
        public void get_Version(){} // RVA: 0x7FFAFBEFD790
        public void get_IssuerDN(){} // RVA: 0x7FFAFBF02320
        public void get_ThisUpdate(){} // RVA: 0x7FFAFBF02350
        public void get_NextUpdate(){} // RVA: 0x7FFAFBF02380
        public void LoadCrlEntries(){} // RVA: 0x7FFAFBF02400
        public void GetRevokedCertificate(){} // RVA: 0x7FFAFBF02790
        public void GetRevokedCertificates(){} // RVA: 0x7FFAFBF02A60
        public void GetTbsCertList(){} // RVA: 0x7FFAFBF02AD0
        public void GetSignature(){} // RVA: 0x7FFAFBEFD8D0
        public void get_SigAlgName(){} // RVA: 0x7FFAF2D907C0
        public void get_SigAlgOid(){} // RVA: 0x7FFAFBEFDA40
        public void GetSigAlgParams(){} // RVA: 0x7FFAFBF02B80
        public void Equals(){} // RVA: 0x7FFAFBF02C30
        public void GetHashCode(){} // RVA: 0x7FFAFBF02D70
        public void ToString(){} // RVA: 0x7FFAFBF02DD0
        public void IsRevoked(){} // RVA: 0x7FFAFBF04070
        public void get_IsIndirectCrl(){} // RVA: 0x7FFAFBF04160
    }

    public class X509CrlEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF043A0 | overloaded x2
        public void loadCertificateIssuer(){} // RVA: 0x7FFAFBF044D0
        public void GetCertificateIssuer(){} // RVA: 0x7FFAF2DBB130
        public void GetX509Extensions(){} // RVA: 0x7FFAFBF04640
        public void GetEncoded(){} // RVA: 0x7FFAFBF04660
        public void get_SerialNumber(){} // RVA: 0x7FFAFBF04700
        public void get_RevocationDate(){} // RVA: 0x7FFAFBF04730
        public void get_HasExtensions(){} // RVA: 0x7FFAFBF04760
        public void Equals(){} // RVA: 0x7FFAFBF04790
        public void GetHashCode(){} // RVA: 0x7FFAFBF04890
        public void ToString(){} // RVA: 0x7FFAFBF048F0
    }

    public class X509CrlParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E575F0 | overloaded x2
        public void ReadPemCrl(){} // RVA: 0x7FFAFBF051C0
        public void ReadDerCrl(){} // RVA: 0x7FFAFBF05270
        public void GetCrl(){} // RVA: 0x7FFAFBF05570
        public void CreateX509Crl(){} // RVA: 0x7FFAFBF05610
        public void ReadCrl(){} // RVA: 0x7FFAFBF058B0 | overloaded x2
        public void ReadCrls(){} // RVA: 0x7FFAFBF05CE0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAFBF05E60
    }

    public class X509ExtensionBase
    {
        // ── Methods ──
        public void GetX509Extensions(){} // RVA: 0x7FFAF2ABCD60
        public void GetExtensionOids(){} // RVA: 0x7FFAFBF05F40
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7FFAF974C260
        public void GetCriticalExtensionOids(){} // RVA: 0x7FFAFBF06250
        public void GetExtensionValue(){} // RVA: 0x7FFAFBF062F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X509KeyUsage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFBF06340
    }

    public class X509SignatureUtilities
    {
        // ── Methods ──
        public void SetSignatureParameters(){} // RVA: 0x7FFAFBF063E0
        public void GetSignatureName(){} // RVA: 0x7FFAFBF06470
        public void GetDigestAlgName(){} // RVA: 0x7FFAFBF067B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFBF06C90
    }

    public class X509Utilities
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFBF06D60
        public void CreatePssParams(){} // RVA: 0x7FFAFBF08590
        public void GetAlgorithmOid(){} // RVA: 0x7FFAFBF086E0
        public void GetSigAlgID(){} // RVA: 0x7FFAFBF08870
        public void GetAlgNames(){} // RVA: 0x7FFAFBF08B60
        public void GetSignatureForObject(){} // RVA: 0x7FFAFBF08CB0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X509V1CertificateGenerator
    {
        public object Version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF08E60
        public void Reset(){} // RVA: 0x7FFAFBF08F00
        public void SetSerialNumber(){} // RVA: 0x7FFAFBF08FA0
        public void SetIssuerDN(){} // RVA: 0x7FFAFBF09130
        public void SetNotBefore(){} // RVA: 0x7FFAFBF091A0
        public void SetNotAfter(){} // RVA: 0x7FFAFBF09260
        public void SetSubjectDN(){} // RVA: 0x7FFAF35DE790
        public void SetPublicKey(){} // RVA: 0x7FFAFBF09320
        public void SetSignatureAlgorithm(){} // RVA: 0x7FFAFBF09430
        public void Generate(){} // RVA: 0x7FFAFBF097C0 | overloaded x3
        public void GenerateJcaObject(){} // RVA: 0x7FFAFBF09AD0
        public void get_SignatureAlgNames(){} // RVA: 0x7FFAFBF09CB0
    }

    public class X509V2AttributeCertificate
    {
        // ── Methods ──
        public void GetObject(){} // RVA: 0x7FFAFBF09D00
        public void .ctor(){} // RVA: 0x7FFAFBF09E60 | overloaded x3
        public void get_Version(){} // RVA: 0x7FFAFBF09FA0
        public void get_SerialNumber(){} // RVA: 0x7FFAFBF0A020
        public void get_Holder(){} // RVA: 0x7FFAFBF0A050
        public void get_Issuer(){} // RVA: 0x7FFAFBF0A130
        public void get_NotBefore(){} // RVA: 0x7FFAF2D907C0
        public void get_NotAfter(){} // RVA: 0x7FFAF2DBB0C0
        public void GetIssuerUniqueID(){} // RVA: 0x7FFAFBF0A1E0
        public void get_IsValidNow(){} // RVA: 0x7FFAFBF0A310
        public void IsValid(){} // RVA: 0x7FFAFBF0A380
        public void CheckValidity(){} // RVA: 0x7FFAFBF0A540 | overloaded x2
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF35DEEA0
        public void GetSignature(){} // RVA: 0x7FFAFBEFD8D0
        public void Verify(){} // RVA: 0x7FFAFBF0A840 | overloaded x2
        public void CheckSignature(){} // RVA: 0x7FFAFBF0A8C0
        public void GetEncoded(){} // RVA: 0x7FFAFBF0AC10
        public void GetX509Extensions(){} // RVA: 0x7FFAFBF0AC30
        public void GetAttributes(){} // RVA: 0x7FFAFBF0AE80 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAFBF0B380
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
    }

    public class X509V2AttributeCertificateGenerator
    {
        public object SignatureAlgNames;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF0B450
        public void Reset(){} // RVA: 0x7FFAFBF0B590
        public void SetHolder(){} // RVA: 0x7FFAFBF0B650
        public void SetIssuer(){} // RVA: 0x7FFAFBF0B6C0
        public void SetSerialNumber(){} // RVA: 0x7FFAFBF0B740
        public void SetNotBefore(){} // RVA: 0x7FFAFBF0B8C0
        public void SetNotAfter(){} // RVA: 0x7FFAFBF0B980
        public void SetSignatureAlgorithm(){} // RVA: 0x7FFAFBF0BA40
        public void AddAttribute(){} // RVA: 0x7FFAFBF0BC90
        public void SetIssuerUniqueId(){} // RVA: 0x7FFAFBF0BCF0
        public void AddExtension(){} // RVA: 0x7FFAFBF0BDF0 | overloaded x2
        public void Generate(){} // RVA: 0x7FFAFBF0BFD0 | overloaded x3
        public void get_SignatureAlgNames(){} // RVA: 0x7FFAFBF0C550
    }

    public class X509V2CrlGenerator
    {
        public object SignatureAlgNames;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF0C5A0
        public void Reset(){} // RVA: 0x7FFAFBF0C6E0
        public void SetIssuerDN(){} // RVA: 0x7FFAF8B1D240
        public void SetThisUpdate(){} // RVA: 0x7FFAFBF0C7A0
        public void SetNextUpdate(){} // RVA: 0x7FFAFBF0C860
        public void AddCrlEntry(){} // RVA: 0x7FFAFBF0CC30 | overloaded x3
        public void AddCrl(){} // RVA: 0x7FFAFBF0CD90
        public void SetSignatureAlgorithm(){} // RVA: 0x7FFAFBF0D070
        public void AddExtension(){} // RVA: 0x7FFAFBF0D510 | overloaded x4
        public void Generate(){} // RVA: 0x7FFAFBF0D770 | overloaded x3
        public void GenerateCertList(){} // RVA: 0x7FFAFBF0DB50
        public void GenerateJcaObject(){} // RVA: 0x7FFAFBF0DC40
        public void get_SignatureAlgNames(){} // RVA: 0x7FFAFBF0DE10
    }

    public class X509V3CertificateGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF0DE60
        public void Reset(){} // RVA: 0x7FFAFBF0DFA0
        public void SetSerialNumber(){} // RVA: 0x7FFAFBF0E060
        public void SetIssuerDN(){} // RVA: 0x7FFAFBF0E1F0
        public void SetNotBefore(){} // RVA: 0x7FFAFBF0E260
        public void SetNotAfter(){} // RVA: 0x7FFAFBF0E320
        public void SetSubjectDN(){} // RVA: 0x7FFAFBF0E3E0
        public void SetPublicKey(){} // RVA: 0x7FFAFBF0E450
        public void SetSignatureAlgorithm(){} // RVA: 0x7FFAFBF0E4C0
        public void SetSubjectUniqueID(){} // RVA: 0x7FFAFBF0E720
        public void SetIssuerUniqueID(){} // RVA: 0x7FFAFBF0E790
        public void booleanToBitString(){} // RVA: 0x7FFAFBF0E800
        public void AddExtension(){} // RVA: 0x7FFAFBF0EB40 | overloaded x4
        public void CopyAndAddExtension(){} // RVA: 0x7FFAFBF0ED10 | overloaded x2
        public void Generate(){} // RVA: 0x7FFAFBF0EFE0 | overloaded x3
        public void GenerateJcaObject(){} // RVA: 0x7FFAFBF0F430
        public void get_SignatureAlgNames(){} // RVA: 0x7FFAFBF0F610
    }

}