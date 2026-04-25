// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 6
// Methods: 9

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class ECBasisType : Object
    {
        public byte ec_basis_trinomial;
        public byte ec_basis_pentanomial;

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFACBB36BE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ECCurveType : Object
    {
        public byte explicit_prime;
        public byte explicit_char2;
        public byte named_curve;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ECPointFormat : Object
    {
        public byte uncompressed;
        public byte ansiX962_compressed_prime;
        public byte ansiX962_compressed_char2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EncryptionAlgorithm : Object
    {
        public int NULL;
        public int RC4_40;
        public int RC4_128;
        public int RC2_CBC_40;
        public int IDEA_CBC;
        public int DES40_CBC;
        public int DES_CBC;
        public int cls_3DES_EDE_CBC;
        public int AES_128_CBC;
        public int AES_256_CBC;
        public int AES_128_GCM;
        public int AES_256_GCM;
        public int CAMELLIA_128_CBC;
        public int CAMELLIA_256_CBC;
        public int SEED_CBC;
        public int AES_128_CCM;
        public int AES_128_CCM_8;
        public int AES_256_CCM;
        public int AES_256_CCM_8;
        public int CAMELLIA_128_GCM;
        public int CAMELLIA_256_GCM;
        public int CHACHA20_POLY1305;
        public int AES_128_OCB_TAGLEN96;
        public int AES_256_OCB_TAGLEN96;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ExporterLabel : Object
    {
        public string client_finished;
        public string server_finished;
        public string master_secret;
        public string key_expansion;
        public string client_EAP_encryption;
        public string ttls_keying_material;
        public string ttls_challenge;
        public string dtls_srtp;
        public string extended_master_secret;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB36BF0
    }

    public class ExtensionType : Object
    {
        public int server_name;
        public int max_fragment_length;
        public int client_certificate_url;
        public int trusted_ca_keys;
        public int truncated_hmac;
        public int status_request;
        public int user_mapping;
        public int client_authz;
        public int server_authz;
        public int cert_type;
        public int supported_groups;
        public int elliptic_curves;
        public int ec_point_formats;
        public int srp;
        public int signature_algorithms;
        public int use_srtp;
        public int heartbeat;
        public int application_layer_protocol_negotiation;
        public int status_request_v2;
        public int signed_certificate_timestamp;
        public int client_certificate_type;
        public int server_certificate_type;
        public int padding;
        public int encrypt_then_mac;
        public int extended_master_secret;
        public int DRAFT_token_binding;
        public int cached_info;
        public int session_ticket;
        public int negotiated_ff_dhe_groups; // 0x4
        public int renegotiation_info;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB36CA0
    }

}