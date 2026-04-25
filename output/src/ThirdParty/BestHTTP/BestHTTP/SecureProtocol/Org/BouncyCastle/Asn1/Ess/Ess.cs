// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ess
// Classes: 8
// Methods: 58

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ess
{
    public class ContentHints : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerUtf8String ContentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ContentDescription; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDADDC0
        public void .ctor(){} // RVA: 0x7FFAC84642F0 | overloaded x3
        public void get_ContentType(){} // RVA: 0x7FFAC2F247C0
        public void get_ContentDescription(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFACBDAE200
    }

    public class ContentIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString Value; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDAE3B0
        public void .ctor(){} // RVA: 0x7FFACBDAE580 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class EssCertID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString IssuerSerial; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDAE6D0
        public void .ctor(){} // RVA: 0x7FFACBDAEBA0 | overloaded x3
        public void GetCertHash(){} // RVA: 0x7FFAC84AA530
        public void get_IssuerSerial(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDAED50
    }

    public class EssCertIDv2 : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm; // 0x10
        public byte[] IssuerSerial; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultAlgID;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDAEF50
        public void .ctor(){} // RVA: 0x7FFACBDAF490 | overloaded x5
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC2F3C380
        public void GetCertHash(){} // RVA: 0x7FFACBDAF660
        public void get_IssuerSerial(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDAF710
        public void .cctor(){} // RVA: 0x7FFACBDAFA20
    }

    public class OtherCertID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable AlgorithmHash; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial IssuerSerial; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDAFB70
        public void .ctor(){} // RVA: 0x7FFACBDB0030 | overloaded x3
        public void get_AlgorithmHash(){} // RVA: 0x7FFACBDB0150
        public void GetCertHash(){} // RVA: 0x7FFACBDB02B0
        public void get_IssuerSerial(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDB03C0
    }

    public class OtherSigningCertificate : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence certs; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence policies; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB05C0
        public void .ctor(){} // RVA: 0x7FFACBDB0940 | overloaded x2
        public void GetCerts(){} // RVA: 0x7FFACBDB0A00
        public void GetPolicies(){} // RVA: 0x7FFACBDB0BA0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDB0D50
    }

    public class SigningCertificate : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence certs; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence policies; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB0F50
        public void .ctor(){} // RVA: 0x7FFACBDB12D0 | overloaded x2
        public void GetCerts(){} // RVA: 0x7FFACBDB1390
        public void GetPolicies(){} // RVA: 0x7FFACBDB1530
        public void ToAsn1Object(){} // RVA: 0x7FFACBDB16E0
    }

    public class SigningCertificateV2 : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence certs; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence policies; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDB18E0
        public void .ctor(){} // RVA: 0x7FFACBDB1E20 | overloaded x4
        public void GetCerts(){} // RVA: 0x7FFACBDB1F70
        public void GetPolicies(){} // RVA: 0x7FFACBDB21C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDB2370
    }

}