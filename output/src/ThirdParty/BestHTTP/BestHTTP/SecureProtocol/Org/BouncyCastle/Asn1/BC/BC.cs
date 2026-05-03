// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BC
// Classes: 2
// Methods: 11

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BC
{
    public class BCObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A25AC20
    }

    public class LinkedCertificate : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DigestInfo mDigest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName mCertLocation; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name mCertIssuer; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames mCACerts; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A25C600 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A25C850
        public void get_Digest(){} // RVA: 0x7FFE81116380
        public void get_CertLocation(){} // RVA: 0x7FFE810FE7C0
        public void get_CertIssuer(){} // RVA: 0x7FFE811290C0
        public void get_CACerts(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A25C930
    }

}