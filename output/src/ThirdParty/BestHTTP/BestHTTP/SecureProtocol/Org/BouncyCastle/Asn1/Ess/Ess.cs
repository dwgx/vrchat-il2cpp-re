// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ess
// Classes: 8
// Methods: 42

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ess
{
    public class ContentHints : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15DF9A0
        public void .ctor(){} // RVA: 0x7ADABAF10
        public void get_ContentType(){} // RVA: 0x7A80DA7B0
        public void get_ContentDescription(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7B15DFDE0
    }

    public class ContentIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15DFF90
        public void .ctor(){} // RVA: 0x7B15E0160
        public void get_Value(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class EssCertID : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E02B0
        public void .ctor(){} // RVA: 0x7B15E0780
        public void GetCertHash(){} // RVA: 0x7ADB00F00
        public void get_IssuerSerial(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15E0930
    }

    public class EssCertIDv2 : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E0B40
        public void .ctor(){} // RVA: 0x7B15E1080
        public void get_HashAlgorithm(){} // RVA: 0x7A80F2570
        public void GetCertHash(){} // RVA: 0x7B15E1270
        public void get_IssuerSerial(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15E1320
        public void .cctor(){} // RVA: 0x7B15E1640
    }

    public class OtherCertID : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E1790
        public void .ctor(){} // RVA: 0x7B15E1C50
        public void get_AlgorithmHash(){} // RVA: 0x7B15E1D80
        public void GetCertHash(){} // RVA: 0x7B15E1EE0
        public void get_IssuerSerial(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15E2010
    }

    public class OtherSigningCertificate : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E2220
        public void .ctor(){} // RVA: 0x7B15E25A0
        public void GetCerts(){} // RVA: 0x7B15E2660
        public void GetPolicies(){} // RVA: 0x7B15E2810
        public void ToAsn1Object(){} // RVA: 0x7B15E29C0
    }

    public class SigningCertificate : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E2BD0
        public void .ctor(){} // RVA: 0x7B15E2F50
        public void GetCerts(){} // RVA: 0x7B15E3010
        public void GetPolicies(){} // RVA: 0x7B15E31C0
        public void ToAsn1Object(){} // RVA: 0x7B15E3370
    }

    public class SigningCertificateV2 : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15E3580
        public void .ctor(){} // RVA: 0x7B15E3AC0
        public void GetCerts(){} // RVA: 0x7B15E3C10
        public void GetPolicies(){} // RVA: 0x7B15E3E60
        public void ToAsn1Object(){} // RVA: 0x7B15E4010
    }

}