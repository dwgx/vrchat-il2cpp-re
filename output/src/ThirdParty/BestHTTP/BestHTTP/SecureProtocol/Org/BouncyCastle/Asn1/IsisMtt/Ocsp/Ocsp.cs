// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.Ocsp
// Classes: 2
// Methods: 14

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.Ocsp
{
    public class CertHash
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10
        public byte[] certificateHash; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x979C7B0
        public void .ctor(){} // RVA: 0x979CB60 | overloaded x2
        public void get_HashAlgorithm(){} // RVA: 0x2F8380
        public void get_CertificateHash(){} // RVA: 0x979CD70
        public void ToAsn1Object(){} // RVA: 0x979CDF0
    }

    public class RequestedCertificate
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure cert; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x979D240 | overloaded x2
        public void .ctor(){} // RVA: 0x979D550 | overloaded x3
        public void get_Type(){} // RVA: 0x979D6E0
        public void GetCertificateBytes(){} // RVA: 0x979D700
        public void ToAsn1Object(){} // RVA: 0x979D800
    }

}