// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Misc
// Classes: 6
// Methods: 17

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Misc
{
    public class Cast5CbcParameters : Asn1Encodable
    {
        public object keyLength;
        public object iv;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4373B0
        public void .ctor(){} // RVA: 0xA437740
        public void GetIV(){} // RVA: 0xA437A10
        public void get_KeyLength(){} // RVA: 0xA437AF0
        public void ToAsn1Object(){} // RVA: 0xA437B50
    }

    public class IdeaCbcPar : Asn1Encodable
    {
        public object iv;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA437C60
        public void .ctor(){} // RVA: 0xA438070
        public void GetIV(){} // RVA: 0xA3CA8E0
        public void ToAsn1Object(){} // RVA: 0xA4381D0
    }

    public class MiscObjectIdentifiers : Object
    {
        public object Netscape;
        public object NetscapeCertType;
        public object NetscapeBaseUrl;
        public object NetscapeRevocationUrl;
        public object NetscapeCARevocationUrl;
        public object NetscapeRenewalUrl;
        public object NetscapeCAPolicyUrl;
        public object NetscapeSslServerName;
        public object NetscapeCertComment;
        public object Verisign;
        public object VerisignCzagExtension;
        public object VerisignPrivate_6_9;
        public object VerisignOnSiteJurisdictionHash;
        public object VerisignBitString_6_13;
        public object VerisignDnbDunsNumber;
        public object VerisignIssStrongCrypto;
        public object Novell;
        public object NovellSecurityAttribs;
        public object Entrust;
        public object EntrustVersionExtension;
        public object cast5CBC;
        public object as_sys_sec_alg_ideaCBC;
        public object cryptlib;
        public object cryptlib_algorithm;
        public object cryptlib_algorithm_blowfish_ECB;
        public object cryptlib_algorithm_blowfish_CBC;
        public object cryptlib_algorithm_blowfish_CFB;
        public object cryptlib_algorithm_blowfish_OFB;
        public object blake2;
        public object id_blake2b160;
        public object id_blake2b256;
        public object id_blake2b384;
        public object id_blake2b512;
        public object id_blake2s128;
        public object id_blake2s160;
        public object id_blake2s224;
        public object id_blake2s256;
        public object id_scrypt;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA438370
    }

    public class NetscapeCertType : DerBitString
    {
        public object SslClient;
        public object SslServer;
        public object Smime;
        public object ObjectSigning;
        public object Reserved;
        public object SslCA;
        public object SmimeCA;
        public object ObjectSigningCA;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA439ED0
        public void ToString(){} // RVA: 0xA439F80
    }

    public class NetscapeRevocationUrl : DerIA5String
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA43A0C0
        public void ToString(){} // RVA: 0xA43A190
    }

    public class VerisignCzagExtension : DerIA5String
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA43A0C0
        public void ToString(){} // RVA: 0xA43A1F0
    }

}