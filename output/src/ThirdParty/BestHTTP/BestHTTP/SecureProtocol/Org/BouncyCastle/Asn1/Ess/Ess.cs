// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ess
// Classes: 8
// Methods: 58

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ess
{
    public class ContentHints : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerUtf8String contentDescription; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier contentType; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2073E0
        public void .ctor(){} // RVA: 0x7FFE8680DC00 | overloaded x3
        public void get_ContentType(){} // RVA: 0x7FFE810FE7C0
        public void get_ContentDescription(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE8A207820
    }

    public class ContentIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString value; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2079D0
        public void .ctor(){} // RVA: 0x7FFE8A207BA0 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class EssCertID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString certHash; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A207CF0
        public void .ctor(){} // RVA: 0x7FFE8A2081C0 | overloaded x3
        public void GetCertHash(){} // RVA: 0x7FFE86853DF0
        public void get_IssuerSerial(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A208370
    }

    public class EssCertIDv2 : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10
        public byte[] certHash; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A208570
        public void .ctor(){} // RVA: 0x7FFE8A208AB0 | overloaded x5
        public void get_HashAlgorithm(){} // RVA: 0x7FFE81116380
        public void GetCertHash(){} // RVA: 0x7FFE8A208C80
        public void get_IssuerSerial(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A208D30
        public void .cctor(){} // RVA: 0x7FFE8A209040
    }

    public class OtherCertID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable otherCertHash; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A209190
        public void .ctor(){} // RVA: 0x7FFE8A209650 | overloaded x3
        public void get_AlgorithmHash(){} // RVA: 0x7FFE8A209770
        public void GetCertHash(){} // RVA: 0x7FFE8A2098D0
        public void get_IssuerSerial(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2099E0
    }

    public class OtherSigningCertificate : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A209BE0
        public void .ctor(){} // RVA: 0x7FFE8A209F60 | overloaded x2
        public void GetCerts(){} // RVA: 0x7FFE8A20A020
        public void GetPolicies(){} // RVA: 0x7FFE8A20A1C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A20A370
    }

    public class SigningCertificate : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A20A570
        public void .ctor(){} // RVA: 0x7FFE8A20A8F0 | overloaded x2
        public void GetCerts(){} // RVA: 0x7FFE8A20A9B0
        public void GetPolicies(){} // RVA: 0x7FFE8A20AB50
        public void ToAsn1Object(){} // RVA: 0x7FFE8A20AD00
    }

    public class SigningCertificateV2 : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A20AF00
        public void .ctor(){} // RVA: 0x7FFE8A20B440 | overloaded x4
        public void GetCerts(){} // RVA: 0x7FFE8A20B590
        public void GetPolicies(){} // RVA: 0x7FFE8A20B7E0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A20B990
    }

}