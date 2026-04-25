// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store
// Classes: 12
// Methods: 119

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store
{
    public class IX509Selector
    {
        // ── Methods ──
        public void Match(){} // RVA: 0x7FFAC2C59F60
    }

    public class IX509Store
    {
        // ── Methods ──
        public void GetMatches(){} // RVA: 0x7FFAC2C58F40
    }

    public class IX509StoreParameters
    {
    }

    public class NoSuchStoreException : X509StoreException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA684C0 | overloaded x3
    }

    public class X509AttrCertStoreSelector : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.IX509AttributeCertificate AttributeCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date.DateTimeObject AttribueCertificateValid; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.AttributeCertificateHolder AttributeCertificateValid; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.AttributeCertificateIssuer Holder; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Issuer; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet SerialNumber; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet targetGroups; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA68660 | overloaded x2
        public void Match(){} // RVA: 0x7FFACBA68A10
        public void Clone(){} // RVA: 0x7FFACBA68F30
        public void get_AttributeCert(){} // RVA: 0x7FFAC2F3C380
        public void set_AttributeCert(){} // RVA: 0x7FFAC2F22E30
        public void get_AttribueCertificateValid(){} // RVA: 0x7FFAC2F247C0
        public void set_AttribueCertificateValid(){} // RVA: 0x7FFAC2F87E80
        public void get_AttributeCertificateValid(){} // RVA: 0x7FFAC2F247C0
        public void set_AttributeCertificateValid(){} // RVA: 0x7FFAC2F87E80
        public void get_Holder(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Holder(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Issuer(){} // RVA: 0x7FFAC2F4F130
        public void set_Issuer(){} // RVA: 0x7FFAC2F22E90
        public void get_SerialNumber(){} // RVA: 0x7FFAC31D95E0
        public void set_SerialNumber(){} // RVA: 0x7FFAC2F4F890
        public void AddTargetName(){} // RVA: 0x7FFACBA68FF0 | overloaded x2
        public void SetTargetNames(){} // RVA: 0x7FFACBA69070
        public void GetTargetNames(){} // RVA: 0x7FFACBA690E0
        public void AddTargetGroup(){} // RVA: 0x7FFACBA69230 | overloaded x2
        public void SetTargetGroups(){} // RVA: 0x7FFACBA692B0
        public void GetTargetGroups(){} // RVA: 0x7FFACBA69320
        public void ExtractGeneralNames(){} // RVA: 0x7FFACBA69410
    }

    public class X509CertPairStoreSelector : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509CertificatePair CertPair; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.X509CertStoreSelector ForwardSelector; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store.X509CertStoreSelector ReverseSelector; // 0x20

        // ── Methods ──
        public void CloneSelector(){} // RVA: 0x7FFACBA69720
        public void .ctor(){} // RVA: 0x7FFACBA697B0 | overloaded x2
        public void get_CertPair(){} // RVA: 0x7FFAC2F3C380
        public void set_CertPair(){} // RVA: 0x7FFAC2F22E30
        public void get_ForwardSelector(){} // RVA: 0x7FFACBA69A20
        public void set_ForwardSelector(){} // RVA: 0x7FFACBA69AC0
        public void get_ReverseSelector(){} // RVA: 0x7FFACBA69BB0
        public void set_ReverseSelector(){} // RVA: 0x7FFACBA69C50
        public void Match(){} // RVA: 0x7FFACBA69D40
        public void Clone(){} // RVA: 0x7FFACBA69E80
    }

    public class X509CertStoreSelector : Object
    {
        public byte[] AuthorityKeyIdentifier; // 0x10
        public int BasicConstraints; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate Certificate; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date.DateTimeObject CertificateValid; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet ExtendedKeyUsage; // 0x30
        public bool IgnoreX509NameOrdering; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name Issuer; // 0x40
        public bool[] IssuerAsString; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet KeyUsage; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date.DateTimeObject Policy; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger PrivateKeyValid; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name SerialNumber; // 0x68
        public byte[] Subject; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo SubjectAsString; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectKeyIdentifier; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA69EE0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFACBA6A540
        public void get_AuthorityKeyIdentifier(){} // RVA: 0x7FFACBA6A5A0
        public void set_AuthorityKeyIdentifier(){} // RVA: 0x7FFACBA6A650
        public void get_BasicConstraints(){} // RVA: 0x7FFAC3157800
        public void set_BasicConstraints(){} // RVA: 0x7FFACBA6A750
        public void get_Certificate(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Certificate(){} // RVA: 0x7FFAC2F4F0D0
        public void get_CertificateValid(){} // RVA: 0x7FFAC2F4F130
        public void set_CertificateValid(){} // RVA: 0x7FFAC2F22E90
        public void get_ExtendedKeyUsage(){} // RVA: 0x7FFACBA6A7D0
        public void set_ExtendedKeyUsage(){} // RVA: 0x7FFACBA6A840
        public void get_IgnoreX509NameOrdering(){} // RVA: 0x7FFAC31D95D0
        public void set_IgnoreX509NameOrdering(){} // RVA: 0x7FFAC31D95C0
        public void get_Issuer(){} // RVA: 0x7FFAC2F9E740
        public void set_Issuer(){} // RVA: 0x7FFAC2F49200
        public void get_IssuerAsString(){} // RVA: 0x7FFACBA6A900
        public void get_KeyUsage(){} // RVA: 0x7FFACBA6A930
        public void set_KeyUsage(){} // RVA: 0x7FFACBA6A9B0
        public void get_Policy(){} // RVA: 0x7FFACBA6AA80
        public void set_Policy(){} // RVA: 0x7FFACBA6AAF0
        public void get_PrivateKeyValid(){} // RVA: 0x7FFAC2FE9500
        public void set_PrivateKeyValid(){} // RVA: 0x7FFAC2FE9510
        public void get_SerialNumber(){} // RVA: 0x7FFAC2FBF370
        public void set_SerialNumber(){} // RVA: 0x7FFAC2FBF380
        public void get_Subject(){} // RVA: 0x7FFAC2F9CD50
        public void set_Subject(){} // RVA: 0x7FFAC2F9CD60
        public void get_SubjectAsString(){} // RVA: 0x7FFACBA6ABB0
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7FFACBA6ABE0
        public void set_SubjectKeyIdentifier(){} // RVA: 0x7FFACBA6AC90
        public void get_SubjectPublicKey(){} // RVA: 0x7FFAC30E5600
        public void set_SubjectPublicKey(){} // RVA: 0x7FFAC30E06F0
        public void get_SubjectPublicKeyAlgID(){} // RVA: 0x7FFAC32EF410
        public void set_SubjectPublicKeyAlgID(){} // RVA: 0x7FFAC34D4AA0
        public void Match(){} // RVA: 0x7FFACBA6AD90
        public void IssuersMatch(){} // RVA: 0x7FFACBA6B820
        public void CopyBoolArray(){} // RVA: 0x7FFACBA6B840
        public void CopySet(){} // RVA: 0x7FFACBA6B8C0
        public void GetSubjectPublicKey(){} // RVA: 0x7FFACBA6B930
        public void MatchExtension(){} // RVA: 0x7FFACBA6B960
    }

    public class X509CollectionStore : Object
    {
        public System.Collections.ICollection _local; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA6BAB0
        public void GetMatches(){} // RVA: 0x7FFACBA6BBA0
    }

    public class X509CollectionStoreParameters : Object
    {
        public System.Collections.IList collection; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA6BF30
        public void GetCollection(){} // RVA: 0x7FFACBA6C070
        public void ToString(){} // RVA: 0x7FFACBA6C110
    }

    public class X509CrlStoreSelector : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509Certificate CertificateChecking; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date.DateTimeObject DateAndTime; // 0x18
        public System.Collections.ICollection Issuers; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger MaxCrlNumber; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger MinCrlNumber; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.X509.IX509AttributeCertificate AttrCertChecking; // 0x38
        public bool CompleteCrlEnabled; // 0x40
        public bool DeltaCrlIndicatorEnabled; // 0x41
        public byte[] IssuingDistributionPoint; // 0x48
        public bool IssuingDistributionPointEnabled; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger MaxBaseCrlNumber; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA6C240 | overloaded x2
        public void Clone(){} // RVA: 0x7FFACBA6C640
        public void get_CertificateChecking(){} // RVA: 0x7FFAC2F3C380
        public void set_CertificateChecking(){} // RVA: 0x7FFAC2F22E30
        public void get_DateAndTime(){} // RVA: 0x7FFAC2F247C0
        public void set_DateAndTime(){} // RVA: 0x7FFAC2F87E80
        public void get_Issuers(){} // RVA: 0x7FFACBA6C6A0
        public void set_Issuers(){} // RVA: 0x7FFACBA6C740
        public void get_MaxCrlNumber(){} // RVA: 0x7FFAC2F4F130
        public void set_MaxCrlNumber(){} // RVA: 0x7FFAC2F22E90
        public void get_MinCrlNumber(){} // RVA: 0x7FFAC31D95E0
        public void set_MinCrlNumber(){} // RVA: 0x7FFAC2F4F890
        public void get_AttrCertChecking(){} // RVA: 0x7FFAC31D0140
        public void set_AttrCertChecking(){} // RVA: 0x7FFAC31D0C20
        public void get_CompleteCrlEnabled(){} // RVA: 0x7FFAC2FDCC00
        public void set_CompleteCrlEnabled(){} // RVA: 0x7FFAC2FDCC10
        public void get_DeltaCrlIndicatorEnabled(){} // RVA: 0x7FFAC31D8A60
        public void set_DeltaCrlIndicatorEnabled(){} // RVA: 0x7FFAC31D8A10
        public void get_IssuingDistributionPoint(){} // RVA: 0x7FFACBA6C830
        public void set_IssuingDistributionPoint(){} // RVA: 0x7FFACBA6C8E0
        public void get_IssuingDistributionPointEnabled(){} // RVA: 0x7FFAC2FDB8E0
        public void set_IssuingDistributionPointEnabled(){} // RVA: 0x7FFAC2FDB8F0
        public void get_MaxBaseCrlNumber(){} // RVA: 0x7FFAC2FE9500
        public void set_MaxBaseCrlNumber(){} // RVA: 0x7FFAC2FE9510
        public void Match(){} // RVA: 0x7FFACBA6C9E0
    }

    public class X509StoreException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA684C0 | overloaded x3
    }

    public class X509StoreFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFACBA6D070
        public void checkCorrectType(){} // RVA: 0x7FFACBA6D6B0
    }

}