// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509
// Classes: 25
// Methods: 249

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509
{
    public class AttributeCertificateHolder : Object
    {
        public object holder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0E7010
        public void get_DigestedObjectType(){} // RVA: 0xA0E72D0
        public void get_DigestAlgorithm(){} // RVA: 0xA0E7350
        public void GetObjectDigest(){} // RVA: 0xA0E73A0
        public void get_OtherObjectTypeID(){} // RVA: 0xA0E73F0
        public void GenerateGeneralNames(){} // RVA: 0xA0E7430
        public void MatchesDN(){} // RVA: 0xA0E7510
        public void GetNames(){} // RVA: 0xA0E7630
        public void GetPrincipals(){} // RVA: 0xA0E77C0
        public void GetEntityNames(){} // RVA: 0xA0E7A30
        public void GetIssuer(){} // RVA: 0xA0E7A70
        public void get_SerialNumber(){} // RVA: 0xA0E7AB0
        public void Clone(){} // RVA: 0xA0E7AF0
        public void Match(){} // RVA: 0xA0E80D0
        public void Equals(){} // RVA: 0xA0E7FF0
        public void GetHashCode(){} // RVA: 0x1269730
    }

    public class AttributeCertificateIssuer : Object
    {
        public object form;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0E8180
        public void GetNames(){} // RVA: 0xA0E8300
        public void GetPrincipals(){} // RVA: 0xA0E85A0
        public void MatchesDN(){} // RVA: 0xA0E87E0
        public void Clone(){} // RVA: 0xA0E8900
        public void Match(){} // RVA: 0xA0E8CC0
        public void Equals(){} // RVA: 0xA0E8BE0
        public void GetHashCode(){} // RVA: 0x1269730
    }

    public class IX509AttributeCertificate
    {
        // ── Methods ──
        public void get_Version(){} // RVA: 0x87C130
        public void get_SerialNumber(){} // RVA: 0x87C0A0
        public void get_NotBefore(){} // RVA: 0x87C0A0
        public void get_NotAfter(){} // RVA: 0x87C0A0
        public void get_Holder(){} // RVA: 0x87C0A0
        public void get_Issuer(){} // RVA: 0x87C0A0
        public void GetAttributes(){} // RVA: 0x87C540
        public void GetIssuerUniqueID(){} // RVA: 0x87C0A0
        public void get_IsValidNow(){} // RVA: 0x87D280
        public void IsValid(){} // RVA: 0x87D490
        public void CheckValidity(){} // RVA: 0x8943F0
        public void GetSignature(){} // RVA: 0x87C0A0
        public void Verify(){} // RVA: 0x894320
        public void GetEncoded(){} // RVA: 0x87C0A0
    }

    public class IX509Extension
    {
        // ── Methods ──
        public void GetCriticalExtensionOids(){} // RVA: 0x87C0A0
        public void GetNonCriticalExtensionOids(){} // RVA: 0x87C0A0
        public void GetExtensionValue(){} // RVA: 0x87C540
    }

    public class PemParser : Object
    {
        public object _header1;
        public object _header2;
        public object _footer1;
        public object _footer2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0E8D70
        public void ReadLine(){} // RVA: 0xA0E8FC0
        public void ReadPemObject(){} // RVA: 0xA0E9090
    }

    public class PrincipalUtilities : Object
    {
        // ── Methods ──
        public void GetIssuerX509Principal(){} // RVA: 0xA0E94D0
        public void GetSubjectX509Principal(){} // RVA: 0xA0E9410
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SubjectPublicKeyInfoFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreateSubjectPublicKeyInfo(){} // RVA: 0xA0E9590
        public void ExtractBytes(){} // RVA: 0xA0EAD80
    }

    public class X509AttrCertParser : Object
    {
        public object PemAttrCertParser;
        public object sData;
        public object sDataObjectCount;
        public object currentStream;

        // ── Methods ──
        public void ReadDerCertificate(){} // RVA: 0xA0EAEA0
        public void GetCertificate(){} // RVA: 0xA0EB1B0
        public void ReadPemCertificate(){} // RVA: 0xA0EB320
        public void ReadAttrCert(){} // RVA: 0xA0EB630
        public void ReadAttrCerts(){} // RVA: 0xA0EBAF0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA0EBC70
    }

    public class X509Attribute : Asn1Encodable
    {
        public object attr;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0EBEE0
        public void get_Oid(){} // RVA: 0xA0EC0C0
        public void GetValues(){} // RVA: 0xA0EC0F0
        public void ToAsn1Object(){} // RVA: 0x10ACB60
    }

    public class X509CertPairParser : Object
    {
        public object currentStream;

        // ── Methods ──
        public void ReadDerCrossCertificatePair(){} // RVA: 0xA0F0820
        public void ReadCertPair(){} // RVA: 0xA0F0CB0
        public void ReadCertPairs(){} // RVA: 0xA0F0ED0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X509Certificate : X509ExtensionBase
    {
        public object c;
        public object basicConstraints;
        public object keyUsage;
        public object cacheLock;
        public object publicKeyValue;
        public object hashValueSet;
        public object hashValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0EC310
        public void get_CertificateStructure(){} // RVA: 0xB5DBF0
        public void get_IsValidNow(){} // RVA: 0xA0EC870
        public void IsValid(){} // RVA: 0xA0EC8E0
        public void CheckValidity(){} // RVA: 0xA0ECAA0
        public void get_Version(){} // RVA: 0xA0ECCF0
        public void get_SerialNumber(){} // RVA: 0xA0ECD10
        public void get_IssuerDN(){} // RVA: 0xA0ECD40
        public void get_SubjectDN(){} // RVA: 0xA0ECD70
        public void get_NotBefore(){} // RVA: 0xA0ECDA0
        public void get_NotAfter(){} // RVA: 0xA0ECDD0
        public void GetTbsCertificate(){} // RVA: 0xA0ECE00
        public void GetSignature(){} // RVA: 0xA0ECE30
        public void get_SigAlgName(){} // RVA: 0xA0ECE70
        public void get_SigAlgOid(){} // RVA: 0xA0ECF90
        public void GetSigAlgParams(){} // RVA: 0xA0ECFD0
        public void get_IssuerUniqueID(){} // RVA: 0xA0ED050
        public void get_SubjectUniqueID(){} // RVA: 0xA0ED080
        public void GetKeyUsage(){} // RVA: 0xA0ED0B0
        public void GetExtendedKeyUsage(){} // RVA: 0xA0ED130
        public void GetBasicConstraints(){} // RVA: 0xA0ED550
        public void GetSubjectAlternativeNames(){} // RVA: 0xA0ED5E0
        public void GetIssuerAlternativeNames(){} // RVA: 0xA0ED630
        public void GetAlternativeNames(){} // RVA: 0xA0ED680
        public void GetX509Extensions(){} // RVA: 0xA0EDA60
        public void GetPublicKey(){} // RVA: 0xA0EDAB0
        public void GetEncoded(){} // RVA: 0xA0EDD90
        public void Equals(){} // RVA: 0xA0EDDB0
        public void GetHashCode(){} // RVA: 0xA0EDED0
        public void ToString(){} // RVA: 0xA0EDF30
        public void Verify(){} // RVA: 0xA0EF0B0
        public void CheckSignature(){} // RVA: 0xA0EF130
        public void IsAlgIDEqual(){} // RVA: 0xA0EF410
    }

    public class X509CertificatePair : Object
    {
        public object forward;
        public object reverse;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0EF5F0
        public void GetEncoded(){} // RVA: 0xA0EF760
        public void get_Forward(){} // RVA: 0xB5DBF0
        public void get_Reverse(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0xA0EF9E0
        public void GetHashCode(){} // RVA: 0xA0EFAD0
    }

    public class X509CertificateParser : Object
    {
        public object PemCertParser;
        public object sData;
        public object sDataObjectCount;
        public object currentStream;

        // ── Methods ──
        public void ReadDerCertificate(){} // RVA: 0xA0EFB50
        public void GetCertificate(){} // RVA: 0xA0EFE50
        public void ReadPemCertificate(){} // RVA: 0xA0EFF60
        public void CreateX509Certificate(){} // RVA: 0xA0F0010
        public void ReadCertificate(){} // RVA: 0xA0F0170
        public void ReadCertificates(){} // RVA: 0xA0F05C0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA0F0740
    }

    public class X509Crl : X509ExtensionBase
    {
        public object c;
        public object sigAlgName;
        public object sigAlgParams;
        public object isIndirect;
        public object hashValueSet;
        public object hashValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0F1050
        public void GetX509Extensions(){} // RVA: 0xA0F1350
        public void GetEncoded(){} // RVA: 0xA0F13A0
        public void Verify(){} // RVA: 0xA0F1500
        public void CheckSignature(){} // RVA: 0xA0F1580
        public void get_Version(){} // RVA: 0xA0ECCF0
        public void get_IssuerDN(){} // RVA: 0xA0F1880
        public void get_ThisUpdate(){} // RVA: 0xA0F18B0
        public void get_NextUpdate(){} // RVA: 0xA0F18E0
        public void LoadCrlEntries(){} // RVA: 0xA0F1960
        public void GetRevokedCertificate(){} // RVA: 0xA0F1CF0
        public void GetRevokedCertificates(){} // RVA: 0xA0F1FC0
        public void GetTbsCertList(){} // RVA: 0xA0F2030
        public void GetSignature(){} // RVA: 0xA0ECE30
        public void get_SigAlgName(){} // RVA: 0xB465B0
        public void get_SigAlgOid(){} // RVA: 0xA0ECF90
        public void GetSigAlgParams(){} // RVA: 0xA0F20E0
        public void Equals(){} // RVA: 0xA0F2190
        public void GetHashCode(){} // RVA: 0xA0F22B0
        public void ToString(){} // RVA: 0xA0F2310
        public void IsRevoked(){} // RVA: 0xA0F35F0
        public void get_IsIndirectCrl(){} // RVA: 0xA0F36E0
    }

    public class X509CrlEntry : X509ExtensionBase
    {
        public object c;
        public object isIndirect;
        public object previousCertificateIssuer;
        public object certificateIssuer;
        public object hashValueSet;
        public object hashValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0F3920
        public void loadCertificateIssuer(){} // RVA: 0xA0F3A50
        public void GetCertificateIssuer(){} // RVA: 0xB70160
        public void GetX509Extensions(){} // RVA: 0xA0F3BC0
        public void GetEncoded(){} // RVA: 0xA0F3BE0
        public void get_SerialNumber(){} // RVA: 0xA0F3C80
        public void get_RevocationDate(){} // RVA: 0xA0F3CB0
        public void get_HasExtensions(){} // RVA: 0xA0F3CE0
        public void Equals(){} // RVA: 0xA0F3D10
        public void GetHashCode(){} // RVA: 0xA0F3E00
        public void ToString(){} // RVA: 0xA0F3E60
    }

    public class X509CrlParser : Object
    {
        public object PemCrlParser;
        public object lazyAsn1;
        public object sCrlData;
        public object sCrlDataObjectCount;
        public object currentCrlStream;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void ReadPemCrl(){} // RVA: 0xA0F4740
        public void ReadDerCrl(){} // RVA: 0xA0F47F0
        public void GetCrl(){} // RVA: 0xA0F4AF0
        public void CreateX509Crl(){} // RVA: 0xA0F4B90
        public void ReadCrl(){} // RVA: 0xA0F4E30
        public void ReadCrls(){} // RVA: 0xA0F5270
        public void .cctor(){} // RVA: 0xA0F53F0
    }

    public class X509ExtensionBase : Object
    {
        // ── Methods ──
        public void GetX509Extensions(){} // RVA: 0x87C0A0
        public void GetExtensionOids(){} // RVA: 0xA0F54D0
        public void GetNonCriticalExtensionOids(){} // RVA: 0x76FB500
        public void GetCriticalExtensionOids(){} // RVA: 0xA0F57D0
        public void GetExtensionValue(){} // RVA: 0xA0F5870
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X509KeyUsage : Asn1Encodable
    {
        public object DigitalSignature;
        public object NonRepudiation;
        public object KeyEncipherment;
        public object DataEncipherment;
        public object KeyAgreement;
        public object KeyCertSign;
        public object CrlSign;
        public object EncipherOnly;
        public object DecipherOnly;
        public object usage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void ToAsn1Object(){} // RVA: 0xA0F58C0
    }

    public class X509SignatureUtilities : Object
    {
        public object derNull;

        // ── Methods ──
        public void SetSignatureParameters(){} // RVA: 0xA0F5960
        public void GetSignatureName(){} // RVA: 0xA0F59F0
        public void GetDigestAlgName(){} // RVA: 0xA0F5D30
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA0F6210
    }

    public class X509Utilities : Object
    {
        public object algorithms;
        public object exParams;
        public object noParams;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA0F62E0
        public void CreatePssParams(){} // RVA: 0xA0F7B10
        public void GetAlgorithmOid(){} // RVA: 0xA0F7C60
        public void GetSigAlgID(){} // RVA: 0xA0F7DF0
        public void GetAlgNames(){} // RVA: 0xA0F80E0
        public void GetSignatureForObject(){} // RVA: 0xA0F8230
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X509V1CertificateGenerator : Object
    {
        public object tbsGen;
        public object sigOID;
        public object sigAlgId;
        public object signatureAlgorithm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0F83E0
        public void Reset(){} // RVA: 0xA0F8480
        public void SetSerialNumber(){} // RVA: 0xA0F8520
        public void SetIssuerDN(){} // RVA: 0xA0F86B0
        public void SetNotBefore(){} // RVA: 0xA0F8720
        public void SetNotAfter(){} // RVA: 0xA0F87E0
        public void SetSubjectDN(){} // RVA: 0x13F9240
        public void SetPublicKey(){} // RVA: 0xA0F88A0
        public void SetSignatureAlgorithm(){} // RVA: 0xA0F89B0
        public void Generate(){} // RVA: 0xA0F8D40
        public void GenerateJcaObject(){} // RVA: 0xA0F9060
        public void get_SignatureAlgNames(){} // RVA: 0xA0F9240
    }

    public class X509V2AttributeCertificate : X509ExtensionBase
    {
        public object cert;
        public object notBefore;
        public object notAfter;

        // ── Methods ──
        public void GetObject(){} // RVA: 0xA0F9290
        public void .ctor(){} // RVA: 0xA0F93F0
        public void get_Version(){} // RVA: 0xA0F9530
        public void get_SerialNumber(){} // RVA: 0xA0F95B0
        public void get_Holder(){} // RVA: 0xA0F95E0
        public void get_Issuer(){} // RVA: 0xA0F96C0
        public void get_NotBefore(){} // RVA: 0xB465B0
        public void get_NotAfter(){} // RVA: 0xB700F0
        public void GetIssuerUniqueID(){} // RVA: 0xA0F9770
        public void get_IsValidNow(){} // RVA: 0xA0F98A0
        public void IsValid(){} // RVA: 0xA0F9910
        public void CheckValidity(){} // RVA: 0xA0F9AD0
        public void get_SignatureAlgorithm(){} // RVA: 0x13F9400
        public void GetSignature(){} // RVA: 0xA0ECE30
        public void Verify(){} // RVA: 0xA0F9DD0
        public void CheckSignature(){} // RVA: 0xA0F9E50
        public void GetEncoded(){} // RVA: 0xA0FA1B0
        public void GetX509Extensions(){} // RVA: 0xA0FA1D0
        public void GetAttributes(){} // RVA: 0xA0FA440
        public void Equals(){} // RVA: 0xA0FA950
        public void GetHashCode(){} // RVA: 0x1269730
    }

    public class X509V2AttributeCertificateGenerator : Object
    {
        public object extGenerator;
        public object acInfoGen;
        public object sigOID;
        public object sigAlgId;
        public object signatureAlgorithm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0FAA10
        public void Reset(){} // RVA: 0xA0FAB50
        public void SetHolder(){} // RVA: 0xA0FAC10
        public void SetIssuer(){} // RVA: 0xA0FAC80
        public void SetSerialNumber(){} // RVA: 0xA0FAD00
        public void SetNotBefore(){} // RVA: 0xA0FAE80
        public void SetNotAfter(){} // RVA: 0xA0FAF40
        public void SetSignatureAlgorithm(){} // RVA: 0xA0FB000
        public void AddAttribute(){} // RVA: 0xA0FB250
        public void SetIssuerUniqueId(){} // RVA: 0xA0FB2B0
        public void AddExtension(){} // RVA: 0xA0FB3B0
        public void Generate(){} // RVA: 0xA0FB590
        public void get_SignatureAlgNames(){} // RVA: 0xA0FBB10
    }

    public class X509V2CrlGenerator : Object
    {
        public object extGenerator;
        public object tbsGen;
        public object sigOID;
        public object sigAlgId;
        public object signatureAlgorithm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0FBB60
        public void Reset(){} // RVA: 0xA0FBCA0
        public void SetIssuerDN(){} // RVA: 0x6AE0B20
        public void SetThisUpdate(){} // RVA: 0xA0FBD60
        public void SetNextUpdate(){} // RVA: 0xA0FBE20
        public void AddCrlEntry(){} // RVA: 0xA0FC210
        public void AddCrl(){} // RVA: 0xA0FC390
        public void SetSignatureAlgorithm(){} // RVA: 0xA0FC660
        public void AddExtension(){} // RVA: 0xA0FCB10
        public void Generate(){} // RVA: 0xA0FCD70
        public void GenerateCertList(){} // RVA: 0xA0FD160
        public void GenerateJcaObject(){} // RVA: 0xA0FD250
        public void get_SignatureAlgNames(){} // RVA: 0xA0FD420
    }

    public class X509V3CertificateGenerator : Object
    {
        public object extGenerator;
        public object tbsGen;
        public object sigOid;
        public object sigAlgId;
        public object signatureAlgorithm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0FD470
        public void Reset(){} // RVA: 0xA0FD5B0
        public void SetSerialNumber(){} // RVA: 0xA0FD670
        public void SetIssuerDN(){} // RVA: 0xA0FD800
        public void SetNotBefore(){} // RVA: 0xA0FD870
        public void SetNotAfter(){} // RVA: 0xA0FD930
        public void SetSubjectDN(){} // RVA: 0xA0FD9F0
        public void SetPublicKey(){} // RVA: 0xA0FDA60
        public void SetSignatureAlgorithm(){} // RVA: 0xA0FDAD0
        public void SetSubjectUniqueID(){} // RVA: 0xA0FDD40
        public void SetIssuerUniqueID(){} // RVA: 0xA0FDDB0
        public void booleanToBitString(){} // RVA: 0xA0FDE20
        public void AddExtension(){} // RVA: 0xA0FE170
        public void CopyAndAddExtension(){} // RVA: 0xA0FE340
        public void Generate(){} // RVA: 0xA0FE610
        public void GenerateJcaObject(){} // RVA: 0xA0FEA70
        public void get_SignatureAlgNames(){} // RVA: 0xA0FEC50
    }

}