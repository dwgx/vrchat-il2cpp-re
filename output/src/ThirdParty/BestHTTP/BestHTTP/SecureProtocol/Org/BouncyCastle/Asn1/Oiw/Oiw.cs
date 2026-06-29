// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Oiw
// Classes: 2
// Methods: 6

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Oiw
{
    public class ElGamalParameter : Asn1Encodable
    {
        public object p;
        public object g;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA429BB0
        public void get_P(){} // RVA: 0xA3D0110
        public void get_G(){} // RVA: 0xA3D0130
        public void ToAsn1Object(){} // RVA: 0xA429D50
    }

    public class OiwObjectIdentifiers : Object
    {
        public object MD4WithRsa;
        public object MD5WithRsa;
        public object MD4WithRsaEncryption;
        public object DesEcb;
        public object DesCbc;
        public object DesOfb;
        public object DesCfb;
        public object DesEde;
        public object IdSha1;
        public object DsaWithSha1;
        public object Sha1WithRsa;
        public object ElGamalAlgorithm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA429E60
    }

}