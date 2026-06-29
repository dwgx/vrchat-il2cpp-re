// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store
// Classes: 11
// Methods: 109

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store
{
    public class IX509Selector
    {
        // ── Methods ──
        public void Match(){} // RVA: 0x87D350
    }

    public class IX509Store
    {
        // ── Methods ──
        public void GetMatches(){} // RVA: 0x87C540
    }

    public class NoSuchStoreException : X509StoreException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0FED50
    }

    public class X509AttrCertStoreSelector : Object
    {
        public object attributeCert;
        public object attributeCertificateValid;
        public object holder;
        public object issuer;
        public object serialNumber;
        public object targetNames;
        public object targetGroups;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0FEEF0
        public void Match(){} // RVA: 0xA0FF2B0
        public void Clone(){} // RVA: 0xA0FF7D0
        public void get_AttributeCert(){} // RVA: 0xB5DBF0
        public void set_AttributeCert(){} // RVA: 0xB44D60
        public void get_AttribueCertificateValid(){} // RVA: 0xB465B0
        public void set_AttribueCertificateValid(){} // RVA: 0xBA9BA0
        public void get_AttributeCertificateValid(){} // RVA: 0xB465B0
        public void set_AttributeCertificateValid(){} // RVA: 0xBA9BA0
        public void get_Holder(){} // RVA: 0xB700F0
        public void set_Holder(){} // RVA: 0xB70100
        public void get_Issuer(){} // RVA: 0xB70160
        public void set_Issuer(){} // RVA: 0xB44DC0
        public void get_SerialNumber(){} // RVA: 0xD33E60
        public void set_SerialNumber(){} // RVA: 0xB708C0
        public void AddTargetName(){} // RVA: 0xA0FF890
        public void SetTargetNames(){} // RVA: 0xA0FF910
        public void GetTargetNames(){} // RVA: 0xA0FF980
        public void AddTargetGroup(){} // RVA: 0xA0FFAD0
        public void SetTargetGroups(){} // RVA: 0xA0FFB50
        public void GetTargetGroups(){} // RVA: 0xA0FFBC0
        public void ExtractGeneralNames(){} // RVA: 0xA0FFCB0
    }

    public class X509CertPairStoreSelector : Object
    {
        public object certPair;
        public object forwardSelector;
        public object reverseSelector;

        // ── Methods ──
        public void CloneSelector(){} // RVA: 0xA0FFFB0
        public void .ctor(){} // RVA: 0xA100040
        public void get_CertPair(){} // RVA: 0xB5DBF0
        public void set_CertPair(){} // RVA: 0xB44D60
        public void get_ForwardSelector(){} // RVA: 0xA1002B0
        public void set_ForwardSelector(){} // RVA: 0xA100340
        public void get_ReverseSelector(){} // RVA: 0xA100430
        public void set_ReverseSelector(){} // RVA: 0xA1004C0
        public void Match(){} // RVA: 0xA1005B0
        public void Clone(){} // RVA: 0xA1006F0
    }

    public class X509CertStoreSelector : Object
    {
        public object authorityKeyIdentifier;
        public object basicConstraints;
        public object certificate;
        public object certificateValid;
        public object extendedKeyUsage;
        public object ignoreX509NameOrdering;
        public object issuer;
        public object keyUsage;
        public object policy;
        public object privateKeyValid;
        public object serialNumber;
        public object subject;
        public object subjectKeyIdentifier;
        public object subjectPublicKey;
        public object subjectPublicKeyAlgID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA100750
        public void Clone(){} // RVA: 0xA100DB0
        public void get_AuthorityKeyIdentifier(){} // RVA: 0xA100E10
        public void set_AuthorityKeyIdentifier(){} // RVA: 0xA100EC0
        public void get_BasicConstraints(){} // RVA: 0xE62D00
        public void set_BasicConstraints(){} // RVA: 0xA100FC0
        public void get_Certificate(){} // RVA: 0xB700F0
        public void set_Certificate(){} // RVA: 0xB70100
        public void get_CertificateValid(){} // RVA: 0xB70160
        public void set_CertificateValid(){} // RVA: 0xB44DC0
        public void get_ExtendedKeyUsage(){} // RVA: 0xA101040
        public void set_ExtendedKeyUsage(){} // RVA: 0xA1010B0
        public void get_IgnoreX509NameOrdering(){} // RVA: 0xD16660
        public void set_IgnoreX509NameOrdering(){} // RVA: 0xD14C10
        public void get_Issuer(){} // RVA: 0xBC1B30
        public void set_Issuer(){} // RVA: 0xB6A8C0
        public void get_IssuerAsString(){} // RVA: 0xA101170
        public void get_KeyUsage(){} // RVA: 0xA1011A0
        public void set_KeyUsage(){} // RVA: 0xA101220
        public void get_Policy(){} // RVA: 0xA1012F0
        public void set_Policy(){} // RVA: 0xA101360
        public void get_PrivateKeyValid(){} // RVA: 0xC0FFC0
        public void set_PrivateKeyValid(){} // RVA: 0xC0FFD0
        public void get_SerialNumber(){} // RVA: 0xBE2C60
        public void set_SerialNumber(){} // RVA: 0xBE2C70
        public void get_Subject(){} // RVA: 0xBBFF90
        public void set_Subject(){} // RVA: 0xBBFFA0
        public void get_SubjectAsString(){} // RVA: 0xA101420
        public void get_SubjectKeyIdentifier(){} // RVA: 0xA101450
        public void set_SubjectKeyIdentifier(){} // RVA: 0xA101500
        public void get_SubjectPublicKey(){} // RVA: 0xCD3320
        public void set_SubjectPublicKey(){} // RVA: 0xCD4740
        public void get_SubjectPublicKeyAlgID(){} // RVA: 0xCD48B0
        public void set_SubjectPublicKeyAlgID(){} // RVA: 0xCD3600
        public void Match(){} // RVA: 0xA101600
        public void IssuersMatch(){} // RVA: 0xA1020A0
        public void CopyBoolArray(){} // RVA: 0xA1020C0
        public void CopySet(){} // RVA: 0xA102140
        public void GetSubjectPublicKey(){} // RVA: 0xA1021B0
        public void MatchExtension(){} // RVA: 0xA1021E0
    }

    public class X509CollectionStore : Object
    {
        public object _local;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA102330
        public void GetMatches(){} // RVA: 0xA102420
    }

    public class X509CollectionStoreParameters : Object
    {
        public object collection;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1027A0
        public void GetCollection(){} // RVA: 0xA1028E0
        public void ToString(){} // RVA: 0xA102980
    }

    public class X509CrlStoreSelector : Object
    {
        public object certificateChecking;
        public object dateAndTime;
        public object issuers;
        public object maxCrlNumber;
        public object minCrlNumber;
        public object attrCertChecking;
        public object completeCrlEnabled;
        public object deltaCrlIndicatorEnabled;
        public object issuingDistributionPoint;
        public object issuingDistributionPointEnabled;
        public object maxBaseCrlNumber;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA102AB0
        public void Clone(){} // RVA: 0xA102EB0
        public void get_CertificateChecking(){} // RVA: 0xB5DBF0
        public void set_CertificateChecking(){} // RVA: 0xB44D60
        public void get_DateAndTime(){} // RVA: 0xB465B0
        public void set_DateAndTime(){} // RVA: 0xBA9BA0
        public void get_Issuers(){} // RVA: 0xA102F10
        public void set_Issuers(){} // RVA: 0xA102FB0
        public void get_MaxCrlNumber(){} // RVA: 0xB70160
        public void set_MaxCrlNumber(){} // RVA: 0xB44DC0
        public void get_MinCrlNumber(){} // RVA: 0xD33E60
        public void set_MinCrlNumber(){} // RVA: 0xB708C0
        public void get_AttrCertChecking(){} // RVA: 0xD05CA0
        public void set_AttrCertChecking(){} // RVA: 0xD09D70
        public void get_CompleteCrlEnabled(){} // RVA: 0xC02470
        public void set_CompleteCrlEnabled(){} // RVA: 0xC02480
        public void get_DeltaCrlIndicatorEnabled(){} // RVA: 0xEEA010
        public void set_DeltaCrlIndicatorEnabled(){} // RVA: 0xEEA000
        public void get_IssuingDistributionPoint(){} // RVA: 0xA1030A0
        public void set_IssuingDistributionPoint(){} // RVA: 0xA103150
        public void get_IssuingDistributionPointEnabled(){} // RVA: 0xC00EC0
        public void set_IssuingDistributionPointEnabled(){} // RVA: 0xC00ED0
        public void get_MaxBaseCrlNumber(){} // RVA: 0xC0FFC0
        public void set_MaxBaseCrlNumber(){} // RVA: 0xC0FFD0
        public void Match(){} // RVA: 0xA103250
    }

    public class X509StoreException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0FED50
    }

    public class X509StoreFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0xA1038E0
        public void checkCorrectType(){} // RVA: 0xA103F10
    }

}