// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Misc
// Classes: 6
// Methods: 20

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Misc
{
    public class Cast5CbcParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger KeyLength; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString iv; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD9A440
        public void .ctor(){} // RVA: 0x7FFACBD9A7D0 | overloaded x2
        public void GetIV(){} // RVA: 0x7FFACBD9AAA0
        public void get_KeyLength(){} // RVA: 0x7FFACBD9AB80
        public void ToAsn1Object(){} // RVA: 0x7FFACBD9ABE0
    }

    public class IdeaCbcPar : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString iv; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD9ACF0
        public void .ctor(){} // RVA: 0x7FFACBD9B100 | overloaded x2
        public void GetIV(){} // RVA: 0x7FFACBD2E610
        public void ToAsn1Object(){} // RVA: 0x7FFACBD9B260
    }

    public class MiscObjectIdentifiers : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Netscape;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeCertType; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeBaseUrl; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeRevocationUrl; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeCARevocationUrl; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeRenewalUrl; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeCAPolicyUrl; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeSslServerName; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeCertComment; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Verisign; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignCzagExtension; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignPrivate_6_9; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignOnSiteJurisdictionHash; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignBitString_6_13; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignDnbDunsNumber; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignIssStrongCrypto; // 0x78
        public string Novell; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NovellSecurityAttribs; // 0x88
        public string Entrust; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EntrustVersionExtension; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier cast5CBC; // 0xA0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier as_sys_sec_alg_ideaCBC; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib; // 0xB0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm; // 0xB8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm_blowfish_ECB; // 0xC0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm_blowfish_CBC; // 0xC8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm_blowfish_CFB; // 0xD0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm_blowfish_OFB; // 0xD8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier blake2; // 0xE0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2b160; // 0xE8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2b256; // 0xF0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2b384; // 0xF8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2b512; // 0x100
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2s128; // 0x108
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2s160; // 0x110
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2s224; // 0x118
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2s256; // 0x120
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_scrypt; // 0x128

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBD9B3E0
    }

    public class NetscapeCertType : DerBitString
    {
        public int SslClient;
        public int SslServer;
        public int Smime;
        public int ObjectSigning;
        public int Reserved;
        public int SslCA;
        public int SmimeCA;
        public int ObjectSigningCA;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD9CF40 | overloaded x2
        public void ToString(){} // RVA: 0x7FFACBD9CFF0
    }

    public class NetscapeRevocationUrl : DerIA5String
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD9D130
        public void ToString(){} // RVA: 0x7FFACBD9D200
    }

    public class VerisignCzagExtension : DerIA5String
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD9D130
        public void ToString(){} // RVA: 0x7FFACBD9D260
    }

}