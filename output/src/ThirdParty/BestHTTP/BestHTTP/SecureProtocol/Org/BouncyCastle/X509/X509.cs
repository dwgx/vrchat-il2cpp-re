// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509
// Classes: 25
// Methods: 249

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509
{
    public class AttributeCertificateHolder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B127B750
        public void get_DigestedObjectType(){} // RVA: 0x7B127BA10
        public void get_DigestAlgorithm(){} // RVA: 0x7B127BA90
        public void GetObjectDigest(){} // RVA: 0x7B127BAE0
        public void get_OtherObjectTypeID(){} // RVA: 0x7B127BB30
        public void GenerateGeneralNames(){} // RVA: 0x7B127BB70
        public void MatchesDN(){} // RVA: 0x7B127BC50
        public void GetNames(){} // RVA: 0x7B127BD70
        public void GetPrincipals(){} // RVA: 0x7B127BF00
        public void GetEntityNames(){} // RVA: 0x7B127C170
        public void GetIssuer(){} // RVA: 0x7B127C1B0
        public void get_SerialNumber(){} // RVA: 0x7B127C1F0
        public void Clone(){} // RVA: 0x7B127C230
        public void Match(){} // RVA: 0x7B127C810
        public void Equals(){} // RVA: 0x7B127C730
        public void GetHashCode(){} // RVA: 0x7A8738190
    }

    public class AttributeCertificateIssuer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B127C8C0
        public void GetNames(){} // RVA: 0x7B127CA40
        public void GetPrincipals(){} // RVA: 0x7B127CCE0
        public void MatchesDN(){} // RVA: 0x7B127CF20
        public void Clone(){} // RVA: 0x7B127D040
        public void Match(){} // RVA: 0x7B127D400
        public void Equals(){} // RVA: 0x7B127D320
        public void GetHashCode(){} // RVA: 0x7A8738190
    }

    public class IX509AttributeCertificate
    {
        // ── Methods ──
        public void get_Version(){} // RVA: 0x7A7E00710
        public void get_SerialNumber(){} // RVA: 0x7A7E00680
        public void get_NotBefore(){} // RVA: 0x7A7E00680
        public void get_NotAfter(){} // RVA: 0x7A7E00680
        public void get_Holder(){} // RVA: 0x7A7E00680
        public void get_Issuer(){} // RVA: 0x7A7E00680
        public void GetAttributes(){} // RVA: 0x7A7E00B20
        public void GetIssuerUniqueID(){} // RVA: 0x7A7E00680
        public void get_IsValidNow(){} // RVA: 0x7A7E01900
        public void IsValid(){} // RVA: 0x7A7E01B10
        public void CheckValidity(){} // RVA: 0x7A7E188D0
        public void GetSignature(){} // RVA: 0x7A7E00680
        public void Verify(){} // RVA: 0x7A7E18800
        public void GetEncoded(){} // RVA: 0x7A7E00680
    }

    public class IX509Extension
    {
        // ── Methods ──
        public void GetCriticalExtensionOids(){} // RVA: 0x7A7E00680
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7A7E00680
        public void GetExtensionValue(){} // RVA: 0x7A7E00B20
    }

    public class PemParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B127D4B0
        public void ReadLine(){} // RVA: 0x7B127D700
        public void ReadPemObject(){} // RVA: 0x7B127D7D0
    }

    public class PrincipalUtilities : Object
    {
        // ── Methods ──
        public void GetIssuerX509Principal(){} // RVA: 0x7B127DC10
        public void GetSubjectX509Principal(){} // RVA: 0x7B127DB50
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SubjectPublicKeyInfoFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CreateSubjectPublicKeyInfo(){} // RVA: 0x7B127DCD0
        public void ExtractBytes(){} // RVA: 0x7B127F4C0
    }

    public class X509AttrCertParser : Object
    {
        // ── Methods ──
        public void ReadDerCertificate(){} // RVA: 0x7B127F5E0
        public void GetCertificate(){} // RVA: 0x7B127F8F0
        public void ReadPemCertificate(){} // RVA: 0x7B127FA60
        public void ReadAttrCert(){} // RVA: 0x7B127FD70
        public void ReadAttrCerts(){} // RVA: 0x7B1280230
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B12803B0
    }

    public class X509Attribute : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1280620
        public void get_Oid(){} // RVA: 0x7B1280800
        public void GetValues(){} // RVA: 0x7B1280830
        public void ToAsn1Object(){} // RVA: 0x7A858AB20
    }

    public class X509CertPairParser : Object
    {
        // ── Methods ──
        public void ReadDerCrossCertificatePair(){} // RVA: 0x7B1284F20
        public void ReadCertPair(){} // RVA: 0x7B12853B0
        public void ReadCertPairs(){} // RVA: 0x7B12855D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X509Certificate : X509ExtensionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1280A50
        public void get_CertificateStructure(){} // RVA: 0x7A80F2570
        public void get_IsValidNow(){} // RVA: 0x7B1280FB0
        public void IsValid(){} // RVA: 0x7B1281020
        public void CheckValidity(){} // RVA: 0x7B12811E0
        public void get_Version(){} // RVA: 0x7B1281430
        public void get_SerialNumber(){} // RVA: 0x7B1281450
        public void get_IssuerDN(){} // RVA: 0x7B1281480
        public void get_SubjectDN(){} // RVA: 0x7B12814B0
        public void get_NotBefore(){} // RVA: 0x7B12814E0
        public void get_NotAfter(){} // RVA: 0x7B1281510
        public void GetTbsCertificate(){} // RVA: 0x7B1281540
        public void GetSignature(){} // RVA: 0x7B1281570
        public void get_SigAlgName(){} // RVA: 0x7B12815B0
        public void get_SigAlgOid(){} // RVA: 0x7B12816E0
        public void GetSigAlgParams(){} // RVA: 0x7B1281720
        public void get_IssuerUniqueID(){} // RVA: 0x7B12817A0
        public void get_SubjectUniqueID(){} // RVA: 0x7B12817D0
        public void GetKeyUsage(){} // RVA: 0x7B1281800
        public void GetExtendedKeyUsage(){} // RVA: 0x7B1281880
        public void GetBasicConstraints(){} // RVA: 0x7B1281CA0
        public void GetSubjectAlternativeNames(){} // RVA: 0x7B1281D30
        public void GetIssuerAlternativeNames(){} // RVA: 0x7B1281D80
        public void GetAlternativeNames(){} // RVA: 0x7B1281DD0
        public void GetX509Extensions(){} // RVA: 0x7B12821C0
        public void GetPublicKey(){} // RVA: 0x7B1282210
        public void GetEncoded(){} // RVA: 0x7B12824F0
        public void Equals(){} // RVA: 0x7B1282510
        public void GetHashCode(){} // RVA: 0x7B1282630
        public void ToString(){} // RVA: 0x7B1282690
        public void Verify(){} // RVA: 0x7B12837B0
        public void CheckSignature(){} // RVA: 0x7B1283830
        public void IsAlgIDEqual(){} // RVA: 0x7B1283B10
    }

    public class X509CertificatePair : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1283CF0
        public void GetEncoded(){} // RVA: 0x7B1283E60
        public void get_Forward(){} // RVA: 0x7A80F2570
        public void get_Reverse(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7B12840E0
        public void GetHashCode(){} // RVA: 0x7B12841D0
    }

    public class X509CertificateParser : Object
    {
        // ── Methods ──
        public void ReadDerCertificate(){} // RVA: 0x7B1284250
        public void GetCertificate(){} // RVA: 0x7B1284550
        public void ReadPemCertificate(){} // RVA: 0x7B1284660
        public void CreateX509Certificate(){} // RVA: 0x7B1284710
        public void ReadCertificate(){} // RVA: 0x7B1284870
        public void ReadCertificates(){} // RVA: 0x7B1284CC0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1284E40
    }

    public class X509Crl : X509ExtensionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1285750
        public void GetX509Extensions(){} // RVA: 0x7B1285A50
        public void GetEncoded(){} // RVA: 0x7B1285AA0
        public void Verify(){} // RVA: 0x7B1285C00
        public void CheckSignature(){} // RVA: 0x7B1285C80
        public void get_Version(){} // RVA: 0x7B1281430
        public void get_IssuerDN(){} // RVA: 0x7B1285F80
        public void get_ThisUpdate(){} // RVA: 0x7B1285FB0
        public void get_NextUpdate(){} // RVA: 0x7B1285FE0
        public void LoadCrlEntries(){} // RVA: 0x7B1286060
        public void GetRevokedCertificate(){} // RVA: 0x7B12863F0
        public void GetRevokedCertificates(){} // RVA: 0x7B12866C0
        public void GetTbsCertList(){} // RVA: 0x7B1286730
        public void GetSignature(){} // RVA: 0x7B1281570
        public void get_SigAlgName(){} // RVA: 0x7A80DA7B0
        public void get_SigAlgOid(){} // RVA: 0x7B12816E0
        public void GetSigAlgParams(){} // RVA: 0x7B12867E0
        public void Equals(){} // RVA: 0x7B1286890
        public void GetHashCode(){} // RVA: 0x7B12869B0
        public void ToString(){} // RVA: 0x7B1286A10
        public void IsRevoked(){} // RVA: 0x7B1287CA0
        public void get_IsIndirectCrl(){} // RVA: 0x7B1287D90
    }

    public class X509CrlEntry : X509ExtensionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1287FD0
        public void loadCertificateIssuer(){} // RVA: 0x7B1288100
        public void GetCertificateIssuer(){} // RVA: 0x7A8105330
        public void GetX509Extensions(){} // RVA: 0x7B1288270
        public void GetEncoded(){} // RVA: 0x7B1288290
        public void get_SerialNumber(){} // RVA: 0x7B1288330
        public void get_RevocationDate(){} // RVA: 0x7B1288360
        public void get_HasExtensions(){} // RVA: 0x7B1288390
        public void Equals(){} // RVA: 0x7B12883C0
        public void GetHashCode(){} // RVA: 0x7B12884B0
        public void ToString(){} // RVA: 0x7B1288510
    }

    public class X509CrlParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81A2210
        public void ReadPemCrl(){} // RVA: 0x7B1288DF0
        public void ReadDerCrl(){} // RVA: 0x7B1288EA0
        public void GetCrl(){} // RVA: 0x7B12891A0
        public void CreateX509Crl(){} // RVA: 0x7B1289240
        public void ReadCrl(){} // RVA: 0x7B12894E0
        public void ReadCrls(){} // RVA: 0x7B1289920
        public void .cctor(){} // RVA: 0x7B1289AA0
    }

    public class X509ExtensionBase : Object
    {
        // ── Methods ──
        public void GetX509Extensions(){} // RVA: 0x7A7E00680
        public void GetExtensionOids(){} // RVA: 0x7B1289B80
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7AEA8B810
        public void GetCriticalExtensionOids(){} // RVA: 0x7B1289E80
        public void GetExtensionValue(){} // RVA: 0x7B1289F20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X509KeyUsage : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void ToAsn1Object(){} // RVA: 0x7B1289F70
    }

    public class X509SignatureUtilities : Object
    {
        // ── Methods ──
        public void SetSignatureParameters(){} // RVA: 0x7B128A010
        public void GetSignatureName(){} // RVA: 0x7B128A0A0
        public void GetDigestAlgName(){} // RVA: 0x7B128A3E0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B128A8C0
    }

    public class X509Utilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B128A990
        public void CreatePssParams(){} // RVA: 0x7B128C1C0
        public void GetAlgorithmOid(){} // RVA: 0x7B128C310
        public void GetSigAlgID(){} // RVA: 0x7B128C4A0
        public void GetAlgNames(){} // RVA: 0x7B128C790
        public void GetSignatureForObject(){} // RVA: 0x7B128C8E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X509V1CertificateGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B128CA90
        public void Reset(){} // RVA: 0x7B128CB30
        public void SetSerialNumber(){} // RVA: 0x7B128CBD0
        public void SetIssuerDN(){} // RVA: 0x7B128CD60
        public void SetNotBefore(){} // RVA: 0x7B128CDD0
        public void SetNotAfter(){} // RVA: 0x7B128CE90
        public void SetSubjectDN(){} // RVA: 0x7A88F3B30
        public void SetPublicKey(){} // RVA: 0x7B128CF50
        public void SetSignatureAlgorithm(){} // RVA: 0x7B128D060
        public void Generate(){} // RVA: 0x7B128D3F0
        public void GenerateJcaObject(){} // RVA: 0x7B128D710
        public void get_SignatureAlgNames(){} // RVA: 0x7B128D8F0
    }

    public class X509V2AttributeCertificate : X509ExtensionBase
    {
        // ── Methods ──
        public void GetObject(){} // RVA: 0x7B128D940
        public void .ctor(){} // RVA: 0x7B128DAA0
        public void get_Version(){} // RVA: 0x7B128DBE0
        public void get_SerialNumber(){} // RVA: 0x7B128DC60
        public void get_Holder(){} // RVA: 0x7B128DC90
        public void get_Issuer(){} // RVA: 0x7B128DD70
        public void get_NotBefore(){} // RVA: 0x7A80DA7B0
        public void get_NotAfter(){} // RVA: 0x7A81052C0
        public void GetIssuerUniqueID(){} // RVA: 0x7B128DE20
        public void get_IsValidNow(){} // RVA: 0x7B128DF50
        public void IsValid(){} // RVA: 0x7B128DFC0
        public void CheckValidity(){} // RVA: 0x7B128E180
        public void get_SignatureAlgorithm(){} // RVA: 0x7A88F4330
        public void GetSignature(){} // RVA: 0x7B1281570
        public void Verify(){} // RVA: 0x7B128E480
        public void CheckSignature(){} // RVA: 0x7B128E500
        public void GetEncoded(){} // RVA: 0x7B128E860
        public void GetX509Extensions(){} // RVA: 0x7B128E880
        public void GetAttributes(){} // RVA: 0x7B128EAF0
        public void Equals(){} // RVA: 0x7B128F000
        public void GetHashCode(){} // RVA: 0x7A8738190
    }

    public class X509V2AttributeCertificateGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B128F0C0
        public void Reset(){} // RVA: 0x7B128F200
        public void SetHolder(){} // RVA: 0x7B128F2C0
        public void SetIssuer(){} // RVA: 0x7B128F330
        public void SetSerialNumber(){} // RVA: 0x7B128F3B0
        public void SetNotBefore(){} // RVA: 0x7B128F530
        public void SetNotAfter(){} // RVA: 0x7B128F5F0
        public void SetSignatureAlgorithm(){} // RVA: 0x7B128F6B0
        public void AddAttribute(){} // RVA: 0x7B128F900
        public void SetIssuerUniqueId(){} // RVA: 0x7B128F960
        public void AddExtension(){} // RVA: 0x7B128FA60
        public void Generate(){} // RVA: 0x7B128FC40
        public void get_SignatureAlgNames(){} // RVA: 0x7B12901C0
    }

    public class X509V2CrlGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1290210
        public void Reset(){} // RVA: 0x7B1290350
        public void SetIssuerDN(){} // RVA: 0x7ADE59590
        public void SetThisUpdate(){} // RVA: 0x7B1290410
        public void SetNextUpdate(){} // RVA: 0x7B12904D0
        public void AddCrlEntry(){} // RVA: 0x7B12908C0
        public void AddCrl(){} // RVA: 0x7B1290A40
        public void SetSignatureAlgorithm(){} // RVA: 0x7B1290D10
        public void AddExtension(){} // RVA: 0x7B12911C0
        public void Generate(){} // RVA: 0x7B1291420
        public void GenerateCertList(){} // RVA: 0x7B1291810
        public void GenerateJcaObject(){} // RVA: 0x7B1291900
        public void get_SignatureAlgNames(){} // RVA: 0x7B1291AD0
    }

    public class X509V3CertificateGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1291B20
        public void Reset(){} // RVA: 0x7B1291C60
        public void SetSerialNumber(){} // RVA: 0x7B1291D20
        public void SetIssuerDN(){} // RVA: 0x7B1291EB0
        public void SetNotBefore(){} // RVA: 0x7B1291F20
        public void SetNotAfter(){} // RVA: 0x7B1291FE0
        public void SetSubjectDN(){} // RVA: 0x7B12920A0
        public void SetPublicKey(){} // RVA: 0x7B1292110
        public void SetSignatureAlgorithm(){} // RVA: 0x7B1292180
        public void SetSubjectUniqueID(){} // RVA: 0x7B12923F0
        public void SetIssuerUniqueID(){} // RVA: 0x7B1292460
        public void booleanToBitString(){} // RVA: 0x7B12924D0
        public void AddExtension(){} // RVA: 0x7B1292820
        public void CopyAndAddExtension(){} // RVA: 0x7B12929F0
        public void Generate(){} // RVA: 0x7B1292CC0
        public void GenerateJcaObject(){} // RVA: 0x7B1293120
        public void get_SignatureAlgNames(){} // RVA: 0x7B1293300
    }

}