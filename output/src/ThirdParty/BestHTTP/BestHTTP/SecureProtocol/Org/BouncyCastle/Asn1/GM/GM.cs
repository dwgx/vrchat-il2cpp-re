// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.GM
// Classes: 2
// Methods: 13

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.GM
{
    public class GMNamedCurves : Object
    {
        public System.Collections.IDictionary Names;
        public System.Collections.IDictionary curves; // 0x8
        public System.Collections.IDictionary names; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ConfigureBasepoint(){} // RVA: 0x7FFACBDAA620
        public void ConfigureCurve(){} // RVA: 0x7FFAC44F81E0
        public void FromHex(){} // RVA: 0x7FFACBDAA710
        public void DefineCurve(){} // RVA: 0x7FFACBDAA7C0
        public void .cctor(){} // RVA: 0x7FFACBDAA910
        public void GetByName(){} // RVA: 0x7FFACBDAAC90
        public void GetByOid(){} // RVA: 0x7FFACBDAAD10
        public void GetOid(){} // RVA: 0x7FFACBDAAE00
        public void GetName(){} // RVA: 0x7FFACBDAAF20
        public void get_Names(){} // RVA: 0x7FFACBDAAFE0
    }

    public class GMObjectIdentifiers : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm_scheme;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm6_ecb; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm6_cbc; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm6_ofb128; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm6_cfb128; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm1_ecb; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm1_cbc; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm1_ofb128; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm1_cfb128; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm1_cfb1; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm1_cfb8; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ssf33_ecb; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ssf33_cbc; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ssf33_ofb128; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ssf33_cfb128; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ssf33_cfb1; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ssf33_cfb8; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_ecb; // 0x88
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_cbc; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_ofb128; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_cfb128; // 0xA0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_cfb1; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_cfb8; // 0xB0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_ctr; // 0xB8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_gcm; // 0xC0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_ccm; // 0xC8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_xts; // 0xD0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_wrap; // 0xD8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_wrap_pad; // 0xE0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_ocb; // 0xE8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm5; // 0xF0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2p256v1; // 0xF8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign; // 0x100
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2exchange; // 0x108
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt; // 0x110
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier wapip192v1; // 0x118
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_recommendedParameters; // 0x120
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_specifiedParameters; // 0x128
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_sm3; // 0x130
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_sha1; // 0x138
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_sha224; // 0x140
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_sha256; // 0x148
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_sha384; // 0x150
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_sha512; // 0x158
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_rmd160; // 0x160
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_whirlpool; // 0x168
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_blake2b512; // 0x170
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_blake2s256; // 0x178
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_md5; // 0x180
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_sm9PublicKey; // 0x188
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm9sign; // 0x190
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm9keyagreement; // 0x198
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm9encrypt; // 0x1A0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm3; // 0x1A8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier hmac_sm3; // 0x1B0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_sm3; // 0x1B8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_sha1; // 0x1C0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_sha256; // 0x1C8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_sha512; // 0x1D0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_sha224; // 0x1D8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_sha384; // 0x1E0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_rmd160; // 0x1E8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_whirlpool; // 0x1F0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_blake2b512; // 0x1F8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_blake2s256; // 0x200

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBDAB630
    }

}