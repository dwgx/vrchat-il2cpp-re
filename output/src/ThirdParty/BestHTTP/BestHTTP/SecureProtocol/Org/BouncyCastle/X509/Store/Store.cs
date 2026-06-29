// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store
// Classes: 11
// Methods: 109

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store
{
    public class IX509Selector
    {
        // ── Methods ──
        public void Match(){} // RVA: 0x7A7E019D0
    }

    public class IX509Store
    {
        // ── Methods ──
        public void GetMatches(){} // RVA: 0x7A7E00B20
    }

    public class NoSuchStoreException : X509StoreException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1293400
    }

    public class X509AttrCertStoreSelector : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B12935A0
        public void Match(){} // RVA: 0x7B1293960
        public void Clone(){} // RVA: 0x7B1293E80
        public void get_AttributeCert(){} // RVA: 0x7A80F2570
        public void set_AttributeCert(){} // RVA: 0x7A80D8E20
        public void get_AttribueCertificateValid(){} // RVA: 0x7A80DA7B0
        public void set_AttribueCertificateValid(){} // RVA: 0x7A813E420
        public void get_AttributeCertificateValid(){} // RVA: 0x7A80DA7B0
        public void set_AttributeCertificateValid(){} // RVA: 0x7A813E420
        public void get_Holder(){} // RVA: 0x7A81052C0
        public void set_Holder(){} // RVA: 0x7A81052D0
        public void get_Issuer(){} // RVA: 0x7A8105330
        public void set_Issuer(){} // RVA: 0x7A80D8E80
        public void get_SerialNumber(){} // RVA: 0x7A83F69F0
        public void set_SerialNumber(){} // RVA: 0x7A8105A90
        public void AddTargetName(){} // RVA: 0x7B1293F40
        public void SetTargetNames(){} // RVA: 0x7B1293FC0
        public void GetTargetNames(){} // RVA: 0x7B1294030
        public void AddTargetGroup(){} // RVA: 0x7B1294180
        public void SetTargetGroups(){} // RVA: 0x7B1294200
        public void GetTargetGroups(){} // RVA: 0x7B1294270
        public void ExtractGeneralNames(){} // RVA: 0x7B1294360
    }

    public class X509CertPairStoreSelector : Object
    {
        // ── Methods ──
        public void CloneSelector(){} // RVA: 0x7B1294660
        public void .ctor(){} // RVA: 0x7B12946F0
        public void get_CertPair(){} // RVA: 0x7A80F2570
        public void set_CertPair(){} // RVA: 0x7A80D8E20
        public void get_ForwardSelector(){} // RVA: 0x7B1294960
        public void set_ForwardSelector(){} // RVA: 0x7B12949F0
        public void get_ReverseSelector(){} // RVA: 0x7B1294AE0
        public void set_ReverseSelector(){} // RVA: 0x7B1294B70
        public void Match(){} // RVA: 0x7B1294C60
        public void Clone(){} // RVA: 0x7B1294DA0
    }

    public class X509CertStoreSelector : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1294E00
        public void Clone(){} // RVA: 0x7B1295460
        public void get_AuthorityKeyIdentifier(){} // RVA: 0x7B12954C0
        public void set_AuthorityKeyIdentifier(){} // RVA: 0x7B1295570
        public void get_BasicConstraints(){} // RVA: 0x7A83782A0
        public void set_BasicConstraints(){} // RVA: 0x7B1295670
        public void get_Certificate(){} // RVA: 0x7A81052C0
        public void set_Certificate(){} // RVA: 0x7A81052D0
        public void get_CertificateValid(){} // RVA: 0x7A8105330
        public void set_CertificateValid(){} // RVA: 0x7A80D8E80
        public void get_ExtendedKeyUsage(){} // RVA: 0x7B12956F0
        public void set_ExtendedKeyUsage(){} // RVA: 0x7B1295760
        public void get_IgnoreX509NameOrdering(){} // RVA: 0x7A82A20A0
        public void set_IgnoreX509NameOrdering(){} // RVA: 0x7A82A2C90
        public void get_Issuer(){} // RVA: 0x7A8154D80
        public void set_Issuer(){} // RVA: 0x7A80FF440
        public void get_IssuerAsString(){} // RVA: 0x7B1295820
        public void get_KeyUsage(){} // RVA: 0x7B1295850
        public void set_KeyUsage(){} // RVA: 0x7B12958D0
        public void get_Policy(){} // RVA: 0x7B12959A0
        public void set_Policy(){} // RVA: 0x7B1295A10
        public void get_PrivateKeyValid(){} // RVA: 0x7A81A0050
        public void set_PrivateKeyValid(){} // RVA: 0x7A81A0060
        public void get_SerialNumber(){} // RVA: 0x7A8175DF0
        public void set_SerialNumber(){} // RVA: 0x7A8175E00
        public void get_Subject(){} // RVA: 0x7A8153390
        public void set_Subject(){} // RVA: 0x7A81533A0
        public void get_SubjectAsString(){} // RVA: 0x7B1295AD0
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7B1295B00
        public void set_SubjectKeyIdentifier(){} // RVA: 0x7B1295BB0
        public void get_SubjectPublicKey(){} // RVA: 0x7A82C2060
        public void set_SubjectPublicKey(){} // RVA: 0x7A82C0530
        public void get_SubjectPublicKeyAlgID(){} // RVA: 0x7A825E100
        public void set_SubjectPublicKeyAlgID(){} // RVA: 0x7A825F860
        public void Match(){} // RVA: 0x7B1295CB0
        public void IssuersMatch(){} // RVA: 0x7B1296750
        public void CopyBoolArray(){} // RVA: 0x7B1296770
        public void CopySet(){} // RVA: 0x7B12967F0
        public void GetSubjectPublicKey(){} // RVA: 0x7B1296860
        public void MatchExtension(){} // RVA: 0x7B1296890
    }

    public class X509CollectionStore : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B12969E0
        public void GetMatches(){} // RVA: 0x7B1296AD0
    }

    public class X509CollectionStoreParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1296E50
        public void GetCollection(){} // RVA: 0x7B1296F90
        public void ToString(){} // RVA: 0x7B1297030
    }

    public class X509CrlStoreSelector : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1297160
        public void Clone(){} // RVA: 0x7B1297560
        public void get_CertificateChecking(){} // RVA: 0x7A80F2570
        public void set_CertificateChecking(){} // RVA: 0x7A80D8E20
        public void get_DateAndTime(){} // RVA: 0x7A80DA7B0
        public void set_DateAndTime(){} // RVA: 0x7A813E420
        public void get_Issuers(){} // RVA: 0x7B12975C0
        public void set_Issuers(){} // RVA: 0x7B1297660
        public void get_MaxCrlNumber(){} // RVA: 0x7A8105330
        public void set_MaxCrlNumber(){} // RVA: 0x7A80D8E80
        public void get_MinCrlNumber(){} // RVA: 0x7A83F69F0
        public void set_MinCrlNumber(){} // RVA: 0x7A8105A90
        public void get_AttrCertChecking(){} // RVA: 0x7A8292C30
        public void set_AttrCertChecking(){} // RVA: 0x7A8296DE0
        public void get_CompleteCrlEnabled(){} // RVA: 0x7A8193790
        public void set_CompleteCrlEnabled(){} // RVA: 0x7A81937A0
        public void get_DeltaCrlIndicatorEnabled(){} // RVA: 0x7A83F3AD0
        public void set_DeltaCrlIndicatorEnabled(){} // RVA: 0x7A83F3AC0
        public void get_IssuingDistributionPoint(){} // RVA: 0x7B1297750
        public void set_IssuingDistributionPoint(){} // RVA: 0x7B1297800
        public void get_IssuingDistributionPointEnabled(){} // RVA: 0x7A8192400
        public void set_IssuingDistributionPointEnabled(){} // RVA: 0x7A8192410
        public void get_MaxBaseCrlNumber(){} // RVA: 0x7A81A0050
        public void set_MaxBaseCrlNumber(){} // RVA: 0x7A81A0060
        public void Match(){} // RVA: 0x7B1297900
    }

    public class X509StoreException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1293400
    }

    public class X509StoreFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7B1297F90
        public void checkCorrectType(){} // RVA: 0x7B12985D0
    }

}