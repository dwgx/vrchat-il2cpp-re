// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store
// Classes: 12
// Methods: 119

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store
{
    public class IX509Selector
    {
        // ── Methods ──
        public void Match(){} // RVA: 0x7FFE80E2F3B0
    }

    public class IX509Store
    {
        // ── Methods ──
        public void GetMatches(){} // RVA: 0x7FFE80E2E390
    }

    public class IX509StoreParameters
    {
    }

    public class NoSuchStoreException : X509StoreException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EC1AE0 | overloaded x3
    }

    public class X509AttrCertStoreSelector : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.IX509AttributeCertificate attributeCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date.DateTimeObject attributeCertificateValid; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.AttributeCertificateHolder holder; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.AttributeCertificateIssuer issuer; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger serialNumber; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet targetNames; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EC1C80 | overloaded x2
        public void Match(){} // RVA: 0x7FFE89EC2030
        public void Clone(){} // RVA: 0x7FFE89EC2550
        public void get_AttributeCert(){} // RVA: 0x7FFE81116380
        public void set_AttributeCert(){} // RVA: 0x7FFE810FCE30
        public void get_AttribueCertificateValid(){} // RVA: 0x7FFE810FE7C0
        public void set_AttribueCertificateValid(){} // RVA: 0x7FFE81161E80
        public void get_AttributeCertificateValid(){} // RVA: 0x7FFE810FE7C0
        public void set_AttributeCertificateValid(){} // RVA: 0x7FFE81161E80
        public void get_Holder(){} // RVA: 0x7FFE811290C0
        public void set_Holder(){} // RVA: 0x7FFE811290D0
        public void get_Issuer(){} // RVA: 0x7FFE81129130
        public void set_Issuer(){} // RVA: 0x7FFE810FCE90
        public void get_SerialNumber(){} // RVA: 0x7FFE8144E200
        public void set_SerialNumber(){} // RVA: 0x7FFE81129890
        public void AddTargetName(){} // RVA: 0x7FFE89EC2610 | overloaded x2
        public void SetTargetNames(){} // RVA: 0x7FFE89EC2690
        public void GetTargetNames(){} // RVA: 0x7FFE89EC2700
        public void AddTargetGroup(){} // RVA: 0x7FFE89EC2850 | overloaded x2
        public void SetTargetGroups(){} // RVA: 0x7FFE89EC28D0
        public void GetTargetGroups(){} // RVA: 0x7FFE89EC2940
        public void ExtractGeneralNames(){} // RVA: 0x7FFE89EC2A30
    }

    public class X509CertPairStoreSelector : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509CertificatePair certPair; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.X509CertStoreSelector forwardSelector; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.X509CertStoreSelector reverseSelector; // 0x20

        // ── Methods ──
        public void CloneSelector(){} // RVA: 0x7FFE89EC2D40
        public void .ctor(){} // RVA: 0x7FFE89EC2DD0 | overloaded x2
        public void get_CertPair(){} // RVA: 0x7FFE81116380
        public void set_CertPair(){} // RVA: 0x7FFE810FCE30
        public void get_ForwardSelector(){} // RVA: 0x7FFE89EC3040
        public void set_ForwardSelector(){} // RVA: 0x7FFE89EC30E0
        public void get_ReverseSelector(){} // RVA: 0x7FFE89EC31D0
        public void set_ReverseSelector(){} // RVA: 0x7FFE89EC3270
        public void Match(){} // RVA: 0x7FFE89EC3360
        public void Clone(){} // RVA: 0x7FFE89EC34A0
    }

    public class X509CertStoreSelector : Object
    {
        public byte[] authorityKeyIdentifier; // 0x10
        public int basicConstraints; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate certificate; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date.DateTimeObject certificateValid; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet extendedKeyUsage; // 0x30
        public bool ignoreX509NameOrdering; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name issuer; // 0x40
        public bool[] keyUsage; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet policy; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date.DateTimeObject privateKeyValid; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger serialNumber; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name subject; // 0x68
        public byte[] subjectKeyIdentifier; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo subjectPublicKey; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier subjectPublicKeyAlgID; // 0x80
        public object field_15; // 0xC4
        public object field_16; // 0xC5

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EC3500 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE89EC3B60
        public void get_AuthorityKeyIdentifier(){} // RVA: 0x7FFE89EC3BC0
        public void set_AuthorityKeyIdentifier(){} // RVA: 0x7FFE89EC3C70
        public void get_BasicConstraints(){} // RVA: 0x7FFE813DB630
        public void set_BasicConstraints(){} // RVA: 0x7FFE89EC3D70
        public void get_Certificate(){} // RVA: 0x7FFE811290C0
        public void set_Certificate(){} // RVA: 0x7FFE811290D0
        public void get_CertificateValid(){} // RVA: 0x7FFE81129130
        public void set_CertificateValid(){} // RVA: 0x7FFE810FCE90
        public void get_ExtendedKeyUsage(){} // RVA: 0x7FFE89EC3DF0
        public void set_ExtendedKeyUsage(){} // RVA: 0x7FFE89EC3E60
        public void get_IgnoreX509NameOrdering(){} // RVA: 0x7FFE812CF770
        public void set_IgnoreX509NameOrdering(){} // RVA: 0x7FFE812D0010
        public void get_Issuer(){} // RVA: 0x7FFE81178740
        public void set_Issuer(){} // RVA: 0x7FFE81123200
        public void get_IssuerAsString(){} // RVA: 0x7FFE89EC3F20
        public void get_KeyUsage(){} // RVA: 0x7FFE89EC3F50
        public void set_KeyUsage(){} // RVA: 0x7FFE89EC3FD0
        public void get_Policy(){} // RVA: 0x7FFE89EC40A0
        public void set_Policy(){} // RVA: 0x7FFE89EC4110
        public void get_PrivateKeyValid(){} // RVA: 0x7FFE811C3500
        public void set_PrivateKeyValid(){} // RVA: 0x7FFE811C3510
        public void get_SerialNumber(){} // RVA: 0x7FFE81199370
        public void set_SerialNumber(){} // RVA: 0x7FFE81199380
        public void get_Subject(){} // RVA: 0x7FFE81176D50
        public void set_Subject(){} // RVA: 0x7FFE81176D60
        public void get_SubjectAsString(){} // RVA: 0x7FFE89EC41D0
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7FFE89EC4200
        public void set_SubjectKeyIdentifier(){} // RVA: 0x7FFE89EC42B0
        public void get_SubjectPublicKey(){} // RVA: 0x7FFE81463AE0
        public void set_SubjectPublicKey(){} // RVA: 0x7FFE81464570
        public void get_SubjectPublicKeyAlgID(){} // RVA: 0x7FFE81280C30
        public void set_SubjectPublicKeyAlgID(){} // RVA: 0x7FFE81282380
        public void Match(){} // RVA: 0x7FFE89EC43B0
        public void IssuersMatch(){} // RVA: 0x7FFE89EC4E40
        public void CopyBoolArray(){} // RVA: 0x7FFE89EC4E60
        public void CopySet(){} // RVA: 0x7FFE89EC4EE0
        public void GetSubjectPublicKey(){} // RVA: 0x7FFE89EC4F50
        public void MatchExtension(){} // RVA: 0x7FFE89EC4F80
    }

    public class X509CollectionStore : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EC50D0
        public void GetMatches(){} // RVA: 0x7FFE89EC51C0
    }

    public class X509CollectionStoreParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EC5550
        public void GetCollection(){} // RVA: 0x7FFE89EC5690
        public void ToString(){} // RVA: 0x7FFE89EC5730
    }

    public class X509CrlStoreSelector : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate certificateChecking; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date.DateTimeObject dateAndTime; // 0x18
        public System.Collections.ICollection issuers; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger maxCrlNumber; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger minCrlNumber; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.IX509AttributeCertificate attrCertChecking; // 0x38
        public bool completeCrlEnabled; // 0x40
        public bool deltaCrlIndicatorEnabled; // 0x41
        public byte[] issuingDistributionPoint; // 0x48
        public bool issuingDistributionPointEnabled; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger maxBaseCrlNumber; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EC5860 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE89EC5C60
        public void get_CertificateChecking(){} // RVA: 0x7FFE81116380
        public void set_CertificateChecking(){} // RVA: 0x7FFE810FCE30
        public void get_DateAndTime(){} // RVA: 0x7FFE810FE7C0
        public void set_DateAndTime(){} // RVA: 0x7FFE81161E80
        public void get_Issuers(){} // RVA: 0x7FFE89EC5CC0
        public void set_Issuers(){} // RVA: 0x7FFE89EC5D60
        public void get_MaxCrlNumber(){} // RVA: 0x7FFE81129130
        public void set_MaxCrlNumber(){} // RVA: 0x7FFE810FCE90
        public void get_MinCrlNumber(){} // RVA: 0x7FFE8144E200
        public void set_MinCrlNumber(){} // RVA: 0x7FFE81129890
        public void get_AttrCertChecking(){} // RVA: 0x7FFE8143BA80
        public void set_AttrCertChecking(){} // RVA: 0x7FFE81437330
        public void get_CompleteCrlEnabled(){} // RVA: 0x7FFE811B6C00
        public void set_CompleteCrlEnabled(){} // RVA: 0x7FFE811B6C10
        public void get_DeltaCrlIndicatorEnabled(){} // RVA: 0x7FFE814645D0
        public void set_DeltaCrlIndicatorEnabled(){} // RVA: 0x7FFE814641E0
        public void get_IssuingDistributionPoint(){} // RVA: 0x7FFE89EC5E50
        public void set_IssuingDistributionPoint(){} // RVA: 0x7FFE89EC5F00
        public void get_IssuingDistributionPointEnabled(){} // RVA: 0x7FFE811B58E0
        public void set_IssuingDistributionPointEnabled(){} // RVA: 0x7FFE811B58F0
        public void get_MaxBaseCrlNumber(){} // RVA: 0x7FFE811C3500
        public void set_MaxBaseCrlNumber(){} // RVA: 0x7FFE811C3510
        public void Match(){} // RVA: 0x7FFE89EC6000
    }

    public class X509StoreException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EC1AE0 | overloaded x3
    }

    public class X509StoreFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE89EC6690
        public void checkCorrectType(){} // RVA: 0x7FFE89EC6CD0
    }

}