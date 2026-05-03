// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.Ocsp
// Classes: 2
// Methods: 14

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.Ocsp
{
    public class CertHash : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10
        public byte[] certificateHash; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1FEBB0
        public void .ctor(){} // RVA: 0x7FFE8A1FEF60 | overloaded x2
        public void get_HashAlgorithm(){} // RVA: 0x7FFE81116380
        public void get_CertificateHash(){} // RVA: 0x7FFE8A1FF170
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1FF1F0
    }

    public class RequestedCertificate : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure cert; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1FF640 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1FF950 | overloaded x3
        public void get_Type(){} // RVA: 0x7FFE8A1FFAE0
        public void GetCertificateBytes(){} // RVA: 0x7FFE8A1FFB00
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1FFC00
    }

}