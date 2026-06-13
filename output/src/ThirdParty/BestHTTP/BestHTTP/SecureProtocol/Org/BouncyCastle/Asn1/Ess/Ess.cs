// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ess
// Classes: 8
// Methods: 58

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ess
{
    public class ContentHints
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerUtf8String contentDescription; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier contentType; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97A4FE0
        public void .ctor(){} // RVA: 0x5CCCD00 | overloaded x3
        public void get_ContentType(){} // RVA: 0x2E07C0
        public void get_ContentDescription(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x97A5420
    }

    public class ContentIdentifier
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString value; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97A55D0
        public void .ctor(){} // RVA: 0x97A57A0 | overloaded x2
        public void get_Value(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class EssCertID
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString certHash; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97A58F0
        public void .ctor(){} // RVA: 0x97A5DC0 | overloaded x3
        public void GetCertHash(){} // RVA: 0x5D12EF0
        public void get_IssuerSerial(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97A5F70
    }

    public class EssCertIDv2
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10
        public byte[] certHash; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97A6170
        public void .ctor(){} // RVA: 0x97A66B0 | overloaded x5
        public void get_HashAlgorithm(){} // RVA: 0x2F8380
        public void GetCertHash(){} // RVA: 0x97A6880
        public void get_IssuerSerial(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97A6930
        public void .cctor(){} // RVA: 0x97A6C40
    }

    public class OtherCertID
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable otherCertHash; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97A6D90
        public void .ctor(){} // RVA: 0x97A7250 | overloaded x3
        public void get_AlgorithmHash(){} // RVA: 0x97A7370
        public void GetCertHash(){} // RVA: 0x97A74D0
        public void get_IssuerSerial(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97A75E0
    }

    public class OtherSigningCertificate
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97A77E0
        public void .ctor(){} // RVA: 0x97A7B60 | overloaded x2
        public void GetCerts(){} // RVA: 0x97A7C20
        public void GetPolicies(){} // RVA: 0x97A7DC0
        public void ToAsn1Object(){} // RVA: 0x97A7F70
    }

    public class SigningCertificate
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97A8170
        public void .ctor(){} // RVA: 0x97A84F0 | overloaded x2
        public void GetCerts(){} // RVA: 0x97A85B0
        public void GetPolicies(){} // RVA: 0x97A8750
        public void ToAsn1Object(){} // RVA: 0x97A8900
    }

    public class SigningCertificateV2
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97A8B00
        public void .ctor(){} // RVA: 0x97A9040 | overloaded x4
        public void GetCerts(){} // RVA: 0x97A9190
        public void GetPolicies(){} // RVA: 0x97A93E0
        public void ToAsn1Object(){} // RVA: 0x97A9590
    }

}