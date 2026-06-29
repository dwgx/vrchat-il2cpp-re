// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 6
// Methods: 9

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class ECBasisType : Object
    {
        public object ec_basis_trinomial;
        public object ec_basis_pentanomial;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xA1CFA40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ECCurveType : Object
    {
        public object explicit_prime;
        public object explicit_char2;
        public object named_curve;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ECPointFormat : Object
    {
        public object uncompressed;
        public object ansiX962_compressed_prime;
        public object ansiX962_compressed_char2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EncryptionAlgorithm : Object
    {
        public object NULL;
        public object RC4_40;
        public object RC4_128;
        public object RC2_CBC_40;
        public object IDEA_CBC;
        public object DES40_CBC;
        public object DES_CBC;
        public object cls_3DES_EDE_CBC;
        public object AES_128_CBC;
        public object AES_256_CBC;
        public object AES_128_GCM;
        public object AES_256_GCM;
        public object CAMELLIA_128_CBC;
        public object CAMELLIA_256_CBC;
        public object SEED_CBC;
        public object AES_128_CCM;
        public object AES_128_CCM_8;
        public object AES_256_CCM;
        public object AES_256_CCM_8;
        public object CAMELLIA_128_GCM;
        public object CAMELLIA_256_GCM;
        public object CHACHA20_POLY1305;
        public object AES_128_OCB_TAGLEN96;
        public object AES_256_OCB_TAGLEN96;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ExporterLabel : Object
    {
        public object client_finished;
        public object server_finished;
        public object master_secret;
        public object key_expansion;
        public object client_EAP_encryption;
        public object ttls_keying_material;
        public object ttls_challenge;
        public object dtls_srtp;
        public object extended_master_secret;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA1CFA50
    }

    public class ExtensionType : Object
    {
        public object server_name;
        public object max_fragment_length;
        public object client_certificate_url;
        public object trusted_ca_keys;
        public object truncated_hmac;
        public object status_request;
        public object user_mapping;
        public object client_authz;
        public object server_authz;
        public object cert_type;
        public object supported_groups;
        public object elliptic_curves;
        public object ec_point_formats;
        public object srp;
        public object signature_algorithms;
        public object use_srtp;
        public object heartbeat;
        public object application_layer_protocol_negotiation;
        public object status_request_v2;
        public object signed_certificate_timestamp;
        public object client_certificate_type;
        public object server_certificate_type;
        public object padding;
        public object encrypt_then_mac;
        public object extended_master_secret;
        public object DRAFT_token_binding;
        public object cached_info;
        public object session_ticket;
        public object negotiated_ff_dhe_groups;
        public object renegotiation_info;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA1CFB00
    }

}