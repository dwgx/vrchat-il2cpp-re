// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BC
// Classes: 2
// Methods: 9

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BC
{
    public class BCObjectIdentifiers : Object
    {
        public object bc;
        public object bc_pbe;
        public object bc_pbe_sha1;
        public object bc_pbe_sha256;
        public object bc_pbe_sha384;
        public object bc_pbe_sha512;
        public object bc_pbe_sha224;
        public object bc_pbe_sha1_pkcs5;
        public object bc_pbe_sha1_pkcs12;
        public object bc_pbe_sha256_pkcs5;
        public object bc_pbe_sha256_pkcs12;
        public object bc_pbe_sha1_pkcs12_aes128_cbc;
        public object bc_pbe_sha1_pkcs12_aes192_cbc;
        public object bc_pbe_sha1_pkcs12_aes256_cbc;
        public object bc_pbe_sha256_pkcs12_aes128_cbc;
        public object bc_pbe_sha256_pkcs12_aes192_cbc;
        public object bc_pbe_sha256_pkcs12_aes256_cbc;
        public object bc_sig;
        public object sphincs256;
        public object sphincs256_with_BLAKE512;
        public object sphincs256_with_SHA512;
        public object sphincs256_with_SHA3_512;
        public object xmss;
        public object xmss_with_SHA256;
        public object xmss_with_SHA512;
        public object xmss_with_SHAKE128;
        public object xmss_with_SHAKE256;
        public object xmss_mt;
        public object xmss_mt_with_SHA256;
        public object xmss_mt_with_SHA512;
        public object xmss_mt_with_SHAKE128;
        public object xmss_mt_with_SHAKE256;
        public object bc_exch;
        public object newHope;
        public object bc_ext;
        public object linkedCertificate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA49E070
    }

    public class LinkedCertificate : Asn1Encodable
    {
        public object mDigest;
        public object mCertLocation;
        public object mCertIssuer;
        public object mCACerts;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA49FA50
        public void GetInstance(){} // RVA: 0xA49FCA0
        public void get_Digest(){} // RVA: 0xB5DBF0
        public void get_CertLocation(){} // RVA: 0xB465B0
        public void get_CertIssuer(){} // RVA: 0xB700F0
        public void get_CACerts(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA49FD80
    }

}