// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store
// Classes: 12
// Methods: 119

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store
{
    public class IX509Selector
    {
        // ── Methods ──
        public void Match(){} // RVA: 0xDE40
    }

    public class IX509Store
    {
        // ── Methods ──
        public void GetMatches(){} // RVA: 0xCE10
    }

    public class IX509StoreParameters
    {
    }

    public class NoSuchStoreException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x945F710 | overloaded x3
    }

    public class X509AttrCertStoreSelector
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.IX509AttributeCertificate attributeCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date.DateTimeObject attributeCertificateValid; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.AttributeCertificateHolder holder; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.AttributeCertificateIssuer issuer; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger serialNumber; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet targetNames; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x945F8B0 | overloaded x2
        public void Match(){} // RVA: 0x945FC60
        public void Clone(){} // RVA: 0x9460180
        public void get_AttributeCert(){} // RVA: 0x2F8380
        public void set_AttributeCert(){} // RVA: 0x2DEE30
        public void get_AttribueCertificateValid(){} // RVA: 0x2E07C0
        public void set_AttribueCertificateValid(){} // RVA: 0x343E80
        public void get_AttributeCertificateValid(){} // RVA: 0x2E07C0
        public void set_AttributeCertificateValid(){} // RVA: 0x343E80
        public void get_Holder(){} // RVA: 0x30B0C0
        public void set_Holder(){} // RVA: 0x30B0D0
        public void get_Issuer(){} // RVA: 0x30B130
        public void set_Issuer(){} // RVA: 0x2DEE90
        public void get_SerialNumber(){} // RVA: 0x6374D0
        public void set_SerialNumber(){} // RVA: 0x30B890
        public void AddTargetName(){} // RVA: 0x9460240 | overloaded x2
        public void SetTargetNames(){} // RVA: 0x94602C0
        public void GetTargetNames(){} // RVA: 0x9460330
        public void AddTargetGroup(){} // RVA: 0x9460480 | overloaded x2
        public void SetTargetGroups(){} // RVA: 0x9460500
        public void GetTargetGroups(){} // RVA: 0x9460570
        public void ExtractGeneralNames(){} // RVA: 0x9460660
    }

    public class X509CertPairStoreSelector
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509CertificatePair certPair; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.X509CertStoreSelector forwardSelector; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.X509CertStoreSelector reverseSelector; // 0x20

        // ── Methods ──
        public void CloneSelector(){} // RVA: 0x9460970
        public void .ctor(){} // RVA: 0x9460A00 | overloaded x2
        public void get_CertPair(){} // RVA: 0x2F8380
        public void set_CertPair(){} // RVA: 0x2DEE30
        public void get_ForwardSelector(){} // RVA: 0x9460C70
        public void set_ForwardSelector(){} // RVA: 0x9460D10
        public void get_ReverseSelector(){} // RVA: 0x9460E00
        public void set_ReverseSelector(){} // RVA: 0x9460EA0
        public void Match(){} // RVA: 0x9460F90
        public void Clone(){} // RVA: 0x94610D0
    }

    public class X509CertStoreSelector
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

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9461130 | overloaded x2
        public void Clone(){} // RVA: 0x9461790
        public void get_AuthorityKeyIdentifier(){} // RVA: 0x94617F0
        public void set_AuthorityKeyIdentifier(){} // RVA: 0x94618A0
        public void get_BasicConstraints(){} // RVA: 0x5BED50
        public void set_BasicConstraints(){} // RVA: 0x94619A0
        public void get_Certificate(){} // RVA: 0x30B0C0
        public void set_Certificate(){} // RVA: 0x30B0D0
        public void get_CertificateValid(){} // RVA: 0x30B130
        public void set_CertificateValid(){} // RVA: 0x2DEE90
        public void get_ExtendedKeyUsage(){} // RVA: 0x9461A20
        public void set_ExtendedKeyUsage(){} // RVA: 0x9461A90
        public void get_IgnoreX509NameOrdering(){} // RVA: 0x4A6500
        public void set_IgnoreX509NameOrdering(){} // RVA: 0x4A78C0
        public void get_Issuer(){} // RVA: 0x35A740
        public void set_Issuer(){} // RVA: 0x305200
        public void get_IssuerAsString(){} // RVA: 0x9461B50
        public void get_KeyUsage(){} // RVA: 0x9461B80
        public void set_KeyUsage(){} // RVA: 0x9461C00
        public void get_Policy(){} // RVA: 0x9461CD0
        public void set_Policy(){} // RVA: 0x9461D40
        public void get_PrivateKeyValid(){} // RVA: 0x3A5500
        public void set_PrivateKeyValid(){} // RVA: 0x3A5510
        public void get_SerialNumber(){} // RVA: 0x37B370
        public void set_SerialNumber(){} // RVA: 0x37B380
        public void get_Subject(){} // RVA: 0x358D50
        public void set_Subject(){} // RVA: 0x358D60
        public void get_SubjectAsString(){} // RVA: 0x9461E00
        public void get_SubjectKeyIdentifier(){} // RVA: 0x9461E30
        public void set_SubjectKeyIdentifier(){} // RVA: 0x9461EE0
        public void get_SubjectPublicKey(){} // RVA: 0x4C7C50
        public void set_SubjectPublicKey(){} // RVA: 0x4C34F0
        public void get_SubjectPublicKeyAlgID(){} // RVA: 0x462D00
        public void set_SubjectPublicKeyAlgID(){} // RVA: 0x464450
        public void Match(){} // RVA: 0x9461FE0
        public void IssuersMatch(){} // RVA: 0x9462A70
        public void CopyBoolArray(){} // RVA: 0x9462A90
        public void CopySet(){} // RVA: 0x9462B10
        public void GetSubjectPublicKey(){} // RVA: 0x9462B80
        public void MatchExtension(){} // RVA: 0x9462BB0
    }

    public class X509CollectionStore : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9462D00
        public void GetMatches(){} // RVA: 0x9462DF0
    }

    public class X509CollectionStoreParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9463180
        public void GetCollection(){} // RVA: 0x94632C0
        public void ToString(){} // RVA: 0x9463360
    }

    public class X509CrlStoreSelector
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
        public void .ctor(){} // RVA: 0x9463490 | overloaded x2
        public void Clone(){} // RVA: 0x9463890
        public void get_CertificateChecking(){} // RVA: 0x2F8380
        public void set_CertificateChecking(){} // RVA: 0x2DEE30
        public void get_DateAndTime(){} // RVA: 0x2E07C0
        public void set_DateAndTime(){} // RVA: 0x343E80
        public void get_Issuers(){} // RVA: 0x94638F0
        public void set_Issuers(){} // RVA: 0x9463990
        public void get_MaxCrlNumber(){} // RVA: 0x30B130
        public void set_MaxCrlNumber(){} // RVA: 0x2DEE90
        public void get_MinCrlNumber(){} // RVA: 0x6374D0
        public void set_MinCrlNumber(){} // RVA: 0x30B890
        public void get_AttrCertChecking(){} // RVA: 0x4976A0
        public void set_AttrCertChecking(){} // RVA: 0x49B830
        public void get_CompleteCrlEnabled(){} // RVA: 0x398C00
        public void set_CompleteCrlEnabled(){} // RVA: 0x398C10
        public void get_DeltaCrlIndicatorEnabled(){} // RVA: 0x65EEC0
        public void set_DeltaCrlIndicatorEnabled(){} // RVA: 0x65EEB0
        public void get_IssuingDistributionPoint(){} // RVA: 0x9463A80
        public void set_IssuingDistributionPoint(){} // RVA: 0x9463B30
        public void get_IssuingDistributionPointEnabled(){} // RVA: 0x3978E0
        public void set_IssuingDistributionPointEnabled(){} // RVA: 0x3978F0
        public void get_MaxBaseCrlNumber(){} // RVA: 0x3A5500
        public void set_MaxBaseCrlNumber(){} // RVA: 0x3A5510
        public void Match(){} // RVA: 0x9463C30
    }

    public class X509StoreException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x945F710 | overloaded x3
    }

    public class X509StoreFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x94642C0
        public void checkCorrectType(){} // RVA: 0x9464900
    }

}