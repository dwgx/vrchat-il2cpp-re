// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.Ocsp
// Classes: 2
// Methods: 10

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.Ocsp
{
    public class CertHash : Asn1Encodable
    {
        public object hashAlgorithm;
        public object certificateHash;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA442560
        public void .ctor(){} // RVA: 0xA442910
        public void get_HashAlgorithm(){} // RVA: 0xB5DBF0
        public void get_CertificateHash(){} // RVA: 0xA442B20
        public void ToAsn1Object(){} // RVA: 0xA442BA0
    }

    public class RequestedCertificate : Asn1Encodable
    {
        public object cert;
        public object publicKeyCert;
        public object attributeCert;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA442FF0
        public void .ctor(){} // RVA: 0xA443300
        public void get_Type(){} // RVA: 0xA443490
        public void GetCertificateBytes(){} // RVA: 0xA4434B0
        public void ToAsn1Object(){} // RVA: 0xA4435B0
    }

}