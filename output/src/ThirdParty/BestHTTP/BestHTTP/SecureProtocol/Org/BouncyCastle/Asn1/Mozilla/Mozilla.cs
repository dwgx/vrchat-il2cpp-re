// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Mozilla
// Classes: 1
// Methods: 5

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Mozilla
{
    public class PublicKeyAndChallenge : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence SubjectPublicKeyInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo Challenge; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String challenge; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD99FB0
        public void .ctor(){} // RVA: 0x7FFACBD9A2D0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x7FFAC2F247C0
        public void get_Challenge(){} // RVA: 0x7FFAC2F4F0C0
    }

}