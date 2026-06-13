// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BC
// Classes: 2
// Methods: 11

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BC
{
    public class BCObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x97F8820
    }

    public class LinkedCertificate
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DigestInfo mDigest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName mCertLocation; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name mCertIssuer; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames mCACerts; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97FA200 | overloaded x3
        public void GetInstance(){} // RVA: 0x97FA450
        public void get_Digest(){} // RVA: 0x2F8380
        public void get_CertLocation(){} // RVA: 0x2E07C0
        public void get_CertIssuer(){} // RVA: 0x30B0C0
        public void get_CACerts(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x97FA530
    }

}