// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.Ocsp
// Classes: 2
// Methods: 14

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.Ocsp
{
    public class CertHash : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm; // 0x10
        public byte[] CertificateHash; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDA5590
        public void .ctor(){} // RVA: 0x7FFACBDA5940 | overloaded x2
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC2F3C380
        public void get_CertificateHash(){} // RVA: 0x7FFACBDA5B50
        public void ToAsn1Object(){} // RVA: 0x7FFACBDA5BD0
    }

    public class RequestedCertificate : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure Type; // 0x10
        public byte[] publicKeyCert; // 0x18
        public byte[] attributeCert; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDA6020 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBDA6330 | overloaded x3
        public void get_Type(){} // RVA: 0x7FFACBDA64C0
        public void GetCertificateBytes(){} // RVA: 0x7FFACBDA64E0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDA65E0
    }

}