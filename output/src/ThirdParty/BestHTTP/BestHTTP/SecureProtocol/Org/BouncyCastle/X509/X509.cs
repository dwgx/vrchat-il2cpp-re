// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509
// Classes: 25
// Methods: 302

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509
{
    public class AttributeCertificateHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9447B10 | overloaded x5
        public void get_DigestedObjectType(){} // RVA: 0x9447DD0
        public void get_DigestAlgorithm(){} // RVA: 0x9447E50
        public void GetObjectDigest(){} // RVA: 0x9447EA0
        public void get_OtherObjectTypeID(){} // RVA: 0x9447EF0
        public void GenerateGeneralNames(){} // RVA: 0x9447F30
        public void MatchesDN(){} // RVA: 0x9448010
        public void GetNames(){} // RVA: 0x9448130
        public void GetPrincipals(){} // RVA: 0x94482B0
        public void GetEntityNames(){} // RVA: 0x9448660
        public void GetIssuer(){} // RVA: 0x94486A0
        public void get_SerialNumber(){} // RVA: 0x94486E0
        public void Clone(){} // RVA: 0x9448720
        public void Match(){} // RVA: 0x9448D10 | overloaded x2
        public void Equals(){} // RVA: 0x9448C30
        public void GetHashCode(){} // RVA: 0x99E0E0
    }

    public class AttributeCertificateIssuer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9448DC0 | overloaded x2
        public void GetNames(){} // RVA: 0x9448F40
        public void GetPrincipals(){} // RVA: 0x94491C0
        public void MatchesDN(){} // RVA: 0x9449400
        public void Clone(){} // RVA: 0x9449520
        public void Match(){} // RVA: 0x94498E0 | overloaded x2
        public void Equals(){} // RVA: 0x9449800
        public void GetHashCode(){} // RVA: 0x99E0E0
    }

    public class IX509AttributeCertificate
    {
        // ── Methods ──
        public void get_Version(){} // RVA: 0xD840
        public void get_SerialNumber(){} // RVA: 0xCD60
        public void get_NotBefore(){} // RVA: 0xCD60
        public void get_NotAfter(){} // RVA: 0xCD60
        public void get_Holder(){} // RVA: 0xCD60
        public void get_Issuer(){} // RVA: 0xCD60
        public void GetAttributes(){} // RVA: 0xCE10 | overloaded x2
        public void GetIssuerUniqueID(){} // RVA: 0xCD60
        public void get_IsValidNow(){} // RVA: 0xDBE0
        public void IsValid(){} // RVA: 0xE6C0
        public void CheckValidity(){} // RVA: 0x24CC0 | overloaded x2
        public void GetSignature(){} // RVA: 0xCD60
        public void Verify(){} // RVA: 0x24B10
        public void GetEncoded(){} // RVA: 0xCD60
    }

    public class IX509Extension
    {
        // ── Methods ──
        public void GetCriticalExtensionOids(){} // RVA: 0xCD60
        public void GetNonCriticalExtensionOids(){} // RVA: 0xCD60
        public void GetExtensionValue(){} // RVA: 0xCE10 | overloaded x2
    }

    public class PemParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9449990
        public void ReadLine(){} // RVA: 0x9449BE0
        public void ReadPemObject(){} // RVA: 0x9449CB0
    }

    public class PrincipalUtilities
    {
        // ── Methods ──
        public void GetIssuerX509Principal(){} // RVA: 0x944A0F0 | overloaded x2
        public void GetSubjectX509Principal(){} // RVA: 0x944A030
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SubjectPublicKeyInfoFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void CreateSubjectPublicKeyInfo(){} // RVA: 0x944A1B0
        public void ExtractBytes(){} // RVA: 0x944B840 | overloaded x2
    }

    public class X509AttrCertParser
    {
        // ── Methods ──
        public void ReadDerCertificate(){} // RVA: 0x944B960
        public void GetCertificate(){} // RVA: 0x944BC70
        public void ReadPemCertificate(){} // RVA: 0x944BDE0
        public void ReadAttrCert(){} // RVA: 0x944C0F0 | overloaded x2
        public void ReadAttrCerts(){} // RVA: 0x944C5B0 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x944C730
    }

    public class X509Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x944C9A0 | overloaded x3
        public void get_Oid(){} // RVA: 0x944CB80
        public void GetValues(){} // RVA: 0x944CBB0
        public void ToAsn1Object(){} // RVA: 0x7F0250
    }

    public class X509CertPairParser
    {
        // ── Methods ──
        public void ReadDerCrossCertificatePair(){} // RVA: 0x94512E0
        public void ReadCertPair(){} // RVA: 0x9451770 | overloaded x2
        public void ReadCertPairs(){} // RVA: 0x9451980 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X509Certificate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x944CDC0 | overloaded x2
        public void get_CertificateStructure(){} // RVA: 0x2F8380
        public void get_IsValidNow(){} // RVA: 0x944D310
        public void IsValid(){} // RVA: 0x944D380
        public void CheckValidity(){} // RVA: 0x944D540 | overloaded x2
        public void get_Version(){} // RVA: 0x944D790
        public void get_SerialNumber(){} // RVA: 0x944D7B0
        public void get_IssuerDN(){} // RVA: 0x944D7E0
        public void get_SubjectDN(){} // RVA: 0x944D810
        public void get_NotBefore(){} // RVA: 0x944D840
        public void get_NotAfter(){} // RVA: 0x944D870
        public void GetTbsCertificate(){} // RVA: 0x944D8A0
        public void GetSignature(){} // RVA: 0x944D8D0
        public void get_SigAlgName(){} // RVA: 0x944D910
        public void get_SigAlgOid(){} // RVA: 0x944DA40
        public void GetSigAlgParams(){} // RVA: 0x944DA80
        public void get_IssuerUniqueID(){} // RVA: 0x944DB00
        public void get_SubjectUniqueID(){} // RVA: 0x944DB30
        public void GetKeyUsage(){} // RVA: 0x944DB60
        public void GetExtendedKeyUsage(){} // RVA: 0x944DBE0
        public void GetBasicConstraints(){} // RVA: 0x944E000
        public void GetSubjectAlternativeNames(){} // RVA: 0x944E090
        public void GetIssuerAlternativeNames(){} // RVA: 0x944E0E0
        public void GetAlternativeNames(){} // RVA: 0x944E130
        public void GetX509Extensions(){} // RVA: 0x944E520
        public void GetPublicKey(){} // RVA: 0x944E570
        public void GetEncoded(){} // RVA: 0x944E8E0
        public void Equals(){} // RVA: 0x944E900
        public void GetHashCode(){} // RVA: 0x944EA40
        public void ToString(){} // RVA: 0x944EAA0
        public void Verify(){} // RVA: 0x944FB60 | overloaded x2
        public void CheckSignature(){} // RVA: 0x944FBE0
        public void IsAlgIDEqual(){} // RVA: 0x944FEC0
    }

    public class X509CertificatePair
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x94500A0 | overloaded x2
        public void GetEncoded(){} // RVA: 0x9450210
        public void get_Forward(){} // RVA: 0x2F8380
        public void get_Reverse(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x9450490
        public void GetHashCode(){} // RVA: 0x94505B0
    }

    public class X509CertificateParser
    {
        // ── Methods ──
        public void ReadDerCertificate(){} // RVA: 0x9450630
        public void GetCertificate(){} // RVA: 0x9450930
        public void ReadPemCertificate(){} // RVA: 0x9450A40
        public void CreateX509Certificate(){} // RVA: 0x9450AF0
        public void ReadCertificate(){} // RVA: 0x9450C50 | overloaded x2
        public void ReadCertificates(){} // RVA: 0x9451080 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9451200
    }

    public class X509Crl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9451B00
        public void GetX509Extensions(){} // RVA: 0x9451DF0
        public void GetEncoded(){} // RVA: 0x9451E40
        public void Verify(){} // RVA: 0x9451FA0 | overloaded x2
        public void CheckSignature(){} // RVA: 0x9452020
        public void get_Version(){} // RVA: 0x944D790
        public void get_IssuerDN(){} // RVA: 0x9452320
        public void get_ThisUpdate(){} // RVA: 0x9452350
        public void get_NextUpdate(){} // RVA: 0x9452380
        public void LoadCrlEntries(){} // RVA: 0x9452400
        public void GetRevokedCertificate(){} // RVA: 0x9452790
        public void GetRevokedCertificates(){} // RVA: 0x9452A60
        public void GetTbsCertList(){} // RVA: 0x9452AD0
        public void GetSignature(){} // RVA: 0x944D8D0
        public void get_SigAlgName(){} // RVA: 0x2E07C0
        public void get_SigAlgOid(){} // RVA: 0x944DA40
        public void GetSigAlgParams(){} // RVA: 0x9452B80
        public void Equals(){} // RVA: 0x9452C30
        public void GetHashCode(){} // RVA: 0x9452D70
        public void ToString(){} // RVA: 0x9452DD0
        public void IsRevoked(){} // RVA: 0x9454070
        public void get_IsIndirectCrl(){} // RVA: 0x9454160
    }

    public class X509CrlEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x94543A0 | overloaded x2
        public void loadCertificateIssuer(){} // RVA: 0x94544D0
        public void GetCertificateIssuer(){} // RVA: 0x30B130
        public void GetX509Extensions(){} // RVA: 0x9454640
        public void GetEncoded(){} // RVA: 0x9454660
        public void get_SerialNumber(){} // RVA: 0x9454700
        public void get_RevocationDate(){} // RVA: 0x9454730
        public void get_HasExtensions(){} // RVA: 0x9454760
        public void Equals(){} // RVA: 0x9454790
        public void GetHashCode(){} // RVA: 0x9454890
        public void ToString(){} // RVA: 0x94548F0
    }

    public class X509CrlParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A75F0 | overloaded x2
        public void ReadPemCrl(){} // RVA: 0x94551C0
        public void ReadDerCrl(){} // RVA: 0x9455270
        public void GetCrl(){} // RVA: 0x9455570
        public void CreateX509Crl(){} // RVA: 0x9455610
        public void ReadCrl(){} // RVA: 0x94558B0 | overloaded x2
        public void ReadCrls(){} // RVA: 0x9455CE0 | overloaded x2
        public void .cctor(){} // RVA: 0x9455E60
    }

    public class X509ExtensionBase
    {
        // ── Methods ──
        public void GetX509Extensions(){} // RVA: 0xCD60
        public void GetExtensionOids(){} // RVA: 0x9455F40
        public void GetNonCriticalExtensionOids(){} // RVA: 0x6C9C260
        public void GetCriticalExtensionOids(){} // RVA: 0x9456250
        public void GetExtensionValue(){} // RVA: 0x94562F0 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X509KeyUsage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void ToAsn1Object(){} // RVA: 0x9456340
    }

    public class X509SignatureUtilities
    {
        // ── Methods ──
        public void SetSignatureParameters(){} // RVA: 0x94563E0
        public void GetSignatureName(){} // RVA: 0x9456470
        public void GetDigestAlgName(){} // RVA: 0x94567B0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9456C90
    }

    public class X509Utilities
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x9456D60
        public void CreatePssParams(){} // RVA: 0x9458590
        public void GetAlgorithmOid(){} // RVA: 0x94586E0
        public void GetSigAlgID(){} // RVA: 0x9458870
        public void GetAlgNames(){} // RVA: 0x9458B60
        public void GetSignatureForObject(){} // RVA: 0x9458CB0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X509V1CertificateGenerator
    {
        public object Version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9458E60
        public void Reset(){} // RVA: 0x9458F00
        public void SetSerialNumber(){} // RVA: 0x9458FA0
        public void SetIssuerDN(){} // RVA: 0x9459130
        public void SetNotBefore(){} // RVA: 0x94591A0
        public void SetNotAfter(){} // RVA: 0x9459260
        public void SetSubjectDN(){} // RVA: 0xB2E790
        public void SetPublicKey(){} // RVA: 0x9459320
        public void SetSignatureAlgorithm(){} // RVA: 0x9459430
        public void Generate(){} // RVA: 0x94597C0 | overloaded x3
        public void GenerateJcaObject(){} // RVA: 0x9459AD0
        public void get_SignatureAlgNames(){} // RVA: 0x9459CB0
    }

    public class X509V2AttributeCertificate
    {
        // ── Methods ──
        public void GetObject(){} // RVA: 0x9459D00
        public void .ctor(){} // RVA: 0x9459E60 | overloaded x3
        public void get_Version(){} // RVA: 0x9459FA0
        public void get_SerialNumber(){} // RVA: 0x945A020
        public void get_Holder(){} // RVA: 0x945A050
        public void get_Issuer(){} // RVA: 0x945A130
        public void get_NotBefore(){} // RVA: 0x2E07C0
        public void get_NotAfter(){} // RVA: 0x30B0C0
        public void GetIssuerUniqueID(){} // RVA: 0x945A1E0
        public void get_IsValidNow(){} // RVA: 0x945A310
        public void IsValid(){} // RVA: 0x945A380
        public void CheckValidity(){} // RVA: 0x945A540 | overloaded x2
        public void get_SignatureAlgorithm(){} // RVA: 0xB2EEA0
        public void GetSignature(){} // RVA: 0x944D8D0
        public void Verify(){} // RVA: 0x945A840 | overloaded x2
        public void CheckSignature(){} // RVA: 0x945A8C0
        public void GetEncoded(){} // RVA: 0x945AC10
        public void GetX509Extensions(){} // RVA: 0x945AC30
        public void GetAttributes(){} // RVA: 0x945AE80 | overloaded x2
        public void Equals(){} // RVA: 0x945B380
        public void GetHashCode(){} // RVA: 0x99E0E0
    }

    public class X509V2AttributeCertificateGenerator
    {
        public object SignatureAlgNames;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x945B450
        public void Reset(){} // RVA: 0x945B590
        public void SetHolder(){} // RVA: 0x945B650
        public void SetIssuer(){} // RVA: 0x945B6C0
        public void SetSerialNumber(){} // RVA: 0x945B740
        public void SetNotBefore(){} // RVA: 0x945B8C0
        public void SetNotAfter(){} // RVA: 0x945B980
        public void SetSignatureAlgorithm(){} // RVA: 0x945BA40
        public void AddAttribute(){} // RVA: 0x945BC90
        public void SetIssuerUniqueId(){} // RVA: 0x945BCF0
        public void AddExtension(){} // RVA: 0x945BDF0 | overloaded x2
        public void Generate(){} // RVA: 0x945BFD0 | overloaded x3
        public void get_SignatureAlgNames(){} // RVA: 0x945C550
    }

    public class X509V2CrlGenerator
    {
        public object SignatureAlgNames;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x945C5A0
        public void Reset(){} // RVA: 0x945C6E0
        public void SetIssuerDN(){} // RVA: 0x606D240
        public void SetThisUpdate(){} // RVA: 0x945C7A0
        public void SetNextUpdate(){} // RVA: 0x945C860
        public void AddCrlEntry(){} // RVA: 0x945CC30 | overloaded x3
        public void AddCrl(){} // RVA: 0x945CD90
        public void SetSignatureAlgorithm(){} // RVA: 0x945D070
        public void AddExtension(){} // RVA: 0x945D510 | overloaded x4
        public void Generate(){} // RVA: 0x945D770 | overloaded x3
        public void GenerateCertList(){} // RVA: 0x945DB50
        public void GenerateJcaObject(){} // RVA: 0x945DC40
        public void get_SignatureAlgNames(){} // RVA: 0x945DE10
    }

    public class X509V3CertificateGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x945DE60
        public void Reset(){} // RVA: 0x945DFA0
        public void SetSerialNumber(){} // RVA: 0x945E060
        public void SetIssuerDN(){} // RVA: 0x945E1F0
        public void SetNotBefore(){} // RVA: 0x945E260
        public void SetNotAfter(){} // RVA: 0x945E320
        public void SetSubjectDN(){} // RVA: 0x945E3E0
        public void SetPublicKey(){} // RVA: 0x945E450
        public void SetSignatureAlgorithm(){} // RVA: 0x945E4C0
        public void SetSubjectUniqueID(){} // RVA: 0x945E720
        public void SetIssuerUniqueID(){} // RVA: 0x945E790
        public void booleanToBitString(){} // RVA: 0x945E800
        public void AddExtension(){} // RVA: 0x945EB40 | overloaded x4
        public void CopyAndAddExtension(){} // RVA: 0x945ED10 | overloaded x2
        public void Generate(){} // RVA: 0x945EFE0 | overloaded x3
        public void GenerateJcaObject(){} // RVA: 0x945F430
        public void get_SignatureAlgNames(){} // RVA: 0x945F610
    }

}