// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 18
// Methods: 75

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class CertChainType : Object
    {
        public object individual_certs;
        public object pkipath;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xA1B83B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Certificate : Object
    {
        public object EmptyChain;
        public object mCertificateList;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1B83C0
        public void GetCertificateList(){} // RVA: 0xCADE00
        public void GetCertificateAt(){} // RVA: 0x753C8F0
        public void get_Length(){} // RVA: 0x17F0080
        public void get_IsEmpty(){} // RVA: 0xA1B8470
        public void Encode(){} // RVA: 0xA1B8490
        public void Parse(){} // RVA: 0xA1B8A20
        public void CloneCertificateList(){} // RVA: 0xA1B9070
        public void .cctor(){} // RVA: 0xA1B90F0
    }

    public class CertificateRequest : Object
    {
        public object mCertificateTypes;
        public object mSupportedSignatureAlgorithms;
        public object mCertificateAuthorities;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void get_CertificateTypes(){} // RVA: 0xB5DBF0
        public void get_SupportedSignatureAlgorithms(){} // RVA: 0xB465B0
        public void get_CertificateAuthorities(){} // RVA: 0xB700F0
        public void Encode(){} // RVA: 0xA1B9260
        public void Parse(){} // RVA: 0xA1B9AF0
    }

    public class CertificateStatus : Object
    {
        public object mStatusType;
        public object mResponse;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1BA0E0
        public void get_StatusType(){} // RVA: 0xC120A0
        public void get_Response(){} // RVA: 0xB465B0
        public void GetOcspResponse(){} // RVA: 0xA1BA1C0
        public void Encode(){} // RVA: 0xA1BA2E0
        public void Parse(){} // RVA: 0xA1BA450
        public void IsCorrectType(){} // RVA: 0xA1BA6C0
    }

    public class CertificateStatusRequest : Object
    {
        public object mStatusType;
        public object mRequest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1BA7B0
        public void get_StatusType(){} // RVA: 0xC120A0
        public void get_Request(){} // RVA: 0xB465B0
        public void GetOcspStatusRequest(){} // RVA: 0xA1BA890
        public void Encode(){} // RVA: 0xA1BA9B0
        public void Parse(){} // RVA: 0xA1BAAE0
        public void IsCorrectType(){} // RVA: 0xA1BACE0
    }

    public class CertificateStatusType : Object
    {
        public object ocsp;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CertificateType : Object
    {
        public object X509;
        public object OpenPGP;
        public object RawPublicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CertificateUrl : Object
    {
        public object mType;
        public object mUrlAndHashList;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1BADD0
        public void get_Type(){} // RVA: 0xC120A0
        public void get_UrlAndHashList(){} // RVA: 0xB465B0
        public void Encode(){} // RVA: 0xA1BAF10
        public void parse(){} // RVA: 0xA1BB360
    }

    public class Chacha20Poly1305 : Object
    {
        public object Zeroes;
        public object context;
        public object encryptCipher;
        public object decryptCipher;
        public object encryptIV;
        public object decryptIV;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1BB9A0
        public void GetPlaintextLimit(){} // RVA: 0xA1BBDE0
        public void EncodePlaintext(){} // RVA: 0xA1BBDF0
        public void DecodeCiphertext(){} // RVA: 0xA1BBF70
        public void InitRecord(){} // RVA: 0xA1BC220
        public void CalculateNonce(){} // RVA: 0xA1BC330
        public void GenerateRecordMacKey(){} // RVA: 0xA1BC420
        public void CalculateRecordMac(){} // RVA: 0xA1BC550
        public void UpdateRecordMacLength(){} // RVA: 0xA1BC860
        public void UpdateRecordMacText(){} // RVA: 0xA1BC930
        public void GetAdditionalData(){} // RVA: 0xA1BCA30
        public void .cctor(){} // RVA: 0xA1BCB60
    }

    public class ChangeCipherSpec : Object
    {
        public object change_cipher_spec;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CipherSuite : Object
    {
        public object TLS_NULL_WITH_NULL_NULL;
        public object TLS_RSA_WITH_NULL_MD5;
        public object TLS_RSA_WITH_NULL_SHA;
        public object TLS_RSA_EXPORT_WITH_RC4_40_MD5;
        public object TLS_RSA_WITH_RC4_128_MD5;
        public object TLS_RSA_WITH_RC4_128_SHA;
        public object TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5;
        public object TLS_RSA_WITH_IDEA_CBC_SHA;
        public object TLS_RSA_EXPORT_WITH_DES40_CBC_SHA;
        public object TLS_RSA_WITH_DES_CBC_SHA;
        public object TLS_RSA_WITH_3DES_EDE_CBC_SHA;
        public object TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA;
        public object TLS_DH_DSS_WITH_DES_CBC_SHA;
        public object TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA;
        public object TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA;
        public object TLS_DH_RSA_WITH_DES_CBC_SHA;
        public object TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA;
        public object TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA;
        public object TLS_DHE_DSS_WITH_DES_CBC_SHA;
        public object TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA;
        public object TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA;
        public object TLS_DHE_RSA_WITH_DES_CBC_SHA;
        public object TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA;
        public object TLS_DH_anon_EXPORT_WITH_RC4_40_MD5;
        public object TLS_DH_anon_WITH_RC4_128_MD5;
        public object TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA;
        public object TLS_DH_anon_WITH_DES_CBC_SHA;
        public object TLS_DH_anon_WITH_3DES_EDE_CBC_SHA;
        public object TLS_RSA_WITH_AES_128_CBC_SHA;
        public object TLS_DH_DSS_WITH_AES_128_CBC_SHA;
        public object TLS_DH_RSA_WITH_AES_128_CBC_SHA;
        public object TLS_DHE_DSS_WITH_AES_128_CBC_SHA;
        public object TLS_DHE_RSA_WITH_AES_128_CBC_SHA;
        public object TLS_DH_anon_WITH_AES_128_CBC_SHA;
        public object TLS_RSA_WITH_AES_256_CBC_SHA;
        public object TLS_DH_DSS_WITH_AES_256_CBC_SHA;
        public object TLS_DH_RSA_WITH_AES_256_CBC_SHA;
        public object TLS_DHE_DSS_WITH_AES_256_CBC_SHA;
        public object TLS_DHE_RSA_WITH_AES_256_CBC_SHA;
        public object TLS_DH_anon_WITH_AES_256_CBC_SHA;
        public object TLS_RSA_WITH_CAMELLIA_128_CBC_SHA;
        public object TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA;
        public object TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA;
        public object TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA;
        public object TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA;
        public object TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA;
        public object TLS_RSA_WITH_CAMELLIA_256_CBC_SHA;
        public object TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA;
        public object TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA;
        public object TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA;
        public object TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA;
        public object TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA;
        public object TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256;
        public object TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256;
        public object TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256;
        public object TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256;
        public object TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256;
        public object TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256;
        public object TLS_RSA_WITH_SEED_CBC_SHA;
        public object TLS_DH_DSS_WITH_SEED_CBC_SHA;
        public object TLS_DH_RSA_WITH_SEED_CBC_SHA;
        public object TLS_DHE_DSS_WITH_SEED_CBC_SHA;
        public object TLS_DHE_RSA_WITH_SEED_CBC_SHA;
        public object TLS_DH_anon_WITH_SEED_CBC_SHA;
        public object TLS_PSK_WITH_RC4_128_SHA;
        public object TLS_PSK_WITH_3DES_EDE_CBC_SHA;
        public object TLS_PSK_WITH_AES_128_CBC_SHA;
        public object TLS_PSK_WITH_AES_256_CBC_SHA;
        public object TLS_DHE_PSK_WITH_RC4_128_SHA;
        public object TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA;
        public object TLS_DHE_PSK_WITH_AES_128_CBC_SHA;
        public object TLS_DHE_PSK_WITH_AES_256_CBC_SHA;
        public object TLS_RSA_PSK_WITH_RC4_128_SHA;
        public object TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA;
        public object TLS_RSA_PSK_WITH_AES_128_CBC_SHA;
        public object TLS_RSA_PSK_WITH_AES_256_CBC_SHA;
        public object TLS_ECDH_ECDSA_WITH_NULL_SHA;
        public object TLS_ECDH_ECDSA_WITH_RC4_128_SHA;
        public object TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA;
        public object TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA;
        public object TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA;
        public object TLS_ECDHE_ECDSA_WITH_NULL_SHA;
        public object TLS_ECDHE_ECDSA_WITH_RC4_128_SHA;
        public object TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA;
        public object TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA;
        public object TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA;
        public object TLS_ECDH_RSA_WITH_NULL_SHA;
        public object TLS_ECDH_RSA_WITH_RC4_128_SHA;
        public object TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA;
        public object TLS_ECDH_RSA_WITH_AES_128_CBC_SHA;
        public object TLS_ECDH_RSA_WITH_AES_256_CBC_SHA;
        public object TLS_ECDHE_RSA_WITH_NULL_SHA;
        public object TLS_ECDHE_RSA_WITH_RC4_128_SHA;
        public object TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA;
        public object TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA;
        public object TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA;
        public object TLS_ECDH_anon_WITH_NULL_SHA;
        public object TLS_ECDH_anon_WITH_RC4_128_SHA;
        public object TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA;
        public object TLS_ECDH_anon_WITH_AES_128_CBC_SHA;
        public object TLS_ECDH_anon_WITH_AES_256_CBC_SHA;
        public object TLS_PSK_WITH_NULL_SHA;
        public object TLS_DHE_PSK_WITH_NULL_SHA;
        public object TLS_RSA_PSK_WITH_NULL_SHA;
        public object TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA;
        public object TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA;
        public object TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA;
        public object TLS_SRP_SHA_WITH_AES_128_CBC_SHA;
        public object TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA;
        public object TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA;
        public object TLS_SRP_SHA_WITH_AES_256_CBC_SHA;
        public object TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA;
        public object TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA;
        public object TLS_RSA_WITH_NULL_SHA256;
        public object TLS_RSA_WITH_AES_128_CBC_SHA256;
        public object TLS_RSA_WITH_AES_256_CBC_SHA256;
        public object TLS_DH_DSS_WITH_AES_128_CBC_SHA256;
        public object TLS_DH_RSA_WITH_AES_128_CBC_SHA256;
        public object TLS_DHE_DSS_WITH_AES_128_CBC_SHA256;
        public object TLS_DHE_RSA_WITH_AES_128_CBC_SHA256;
        public object TLS_DH_DSS_WITH_AES_256_CBC_SHA256;
        public object TLS_DH_RSA_WITH_AES_256_CBC_SHA256;
        public object TLS_DHE_DSS_WITH_AES_256_CBC_SHA256;
        public object TLS_DHE_RSA_WITH_AES_256_CBC_SHA256;
        public object TLS_DH_anon_WITH_AES_128_CBC_SHA256;
        public object TLS_DH_anon_WITH_AES_256_CBC_SHA256;
        public object TLS_RSA_WITH_AES_128_GCM_SHA256;
        public object TLS_RSA_WITH_AES_256_GCM_SHA384;
        public object TLS_DHE_RSA_WITH_AES_128_GCM_SHA256;
        public object TLS_DHE_RSA_WITH_AES_256_GCM_SHA384;
        public object TLS_DH_RSA_WITH_AES_128_GCM_SHA256;
        public object TLS_DH_RSA_WITH_AES_256_GCM_SHA384;
        public object TLS_DHE_DSS_WITH_AES_128_GCM_SHA256;
        public object TLS_DHE_DSS_WITH_AES_256_GCM_SHA384;
        public object TLS_DH_DSS_WITH_AES_128_GCM_SHA256;
        public object TLS_DH_DSS_WITH_AES_256_GCM_SHA384;
        public object TLS_DH_anon_WITH_AES_128_GCM_SHA256;
        public object TLS_DH_anon_WITH_AES_256_GCM_SHA384;
        public object TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256;
        public object TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384;
        public object TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256;
        public object TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384;
        public object TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256;
        public object TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384;
        public object TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256;
        public object TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384;
        public object TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256;
        public object TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384;
        public object TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256;
        public object TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384;
        public object TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256;
        public object TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384;
        public object TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256;
        public object TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384;
        public object TLS_PSK_WITH_AES_128_GCM_SHA256;
        public object TLS_PSK_WITH_AES_256_GCM_SHA384;
        public object TLS_DHE_PSK_WITH_AES_128_GCM_SHA256;
        public object TLS_DHE_PSK_WITH_AES_256_GCM_SHA384;
        public object TLS_RSA_PSK_WITH_AES_128_GCM_SHA256;
        public object TLS_RSA_PSK_WITH_AES_256_GCM_SHA384;
        public object TLS_PSK_WITH_AES_128_CBC_SHA256;
        public object TLS_PSK_WITH_AES_256_CBC_SHA384;
        public object TLS_PSK_WITH_NULL_SHA256;
        public object TLS_PSK_WITH_NULL_SHA384;
        public object TLS_DHE_PSK_WITH_AES_128_CBC_SHA256;
        public object TLS_DHE_PSK_WITH_AES_256_CBC_SHA384;
        public object TLS_DHE_PSK_WITH_NULL_SHA256;
        public object TLS_DHE_PSK_WITH_NULL_SHA384;
        public object TLS_RSA_PSK_WITH_AES_128_CBC_SHA256;
        public object TLS_RSA_PSK_WITH_AES_256_CBC_SHA384;
        public object TLS_RSA_PSK_WITH_NULL_SHA256;
        public object TLS_RSA_PSK_WITH_NULL_SHA384;
        public object TLS_ECDHE_PSK_WITH_RC4_128_SHA;
        public object TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA;
        public object TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA;
        public object TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA;
        public object TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256;
        public object TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384;
        public object TLS_ECDHE_PSK_WITH_NULL_SHA;
        public object TLS_ECDHE_PSK_WITH_NULL_SHA256;
        public object TLS_ECDHE_PSK_WITH_NULL_SHA384;
        public object TLS_EMPTY_RENEGOTIATION_INFO_SCSV;
        public object TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384;
        public object TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384;
        public object TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384;
        public object TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384;
        public object TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256;
        public object TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384;
        public object TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384;
        public object TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384;
        public object TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384;
        public object TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256;
        public object TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384;
        public object TLS_RSA_WITH_AES_128_CCM;
        public object TLS_RSA_WITH_AES_256_CCM;
        public object TLS_DHE_RSA_WITH_AES_128_CCM;
        public object TLS_DHE_RSA_WITH_AES_256_CCM;
        public object TLS_RSA_WITH_AES_128_CCM_8;
        public object TLS_RSA_WITH_AES_256_CCM_8;
        public object TLS_DHE_RSA_WITH_AES_128_CCM_8;
        public object TLS_DHE_RSA_WITH_AES_256_CCM_8;
        public object TLS_PSK_WITH_AES_128_CCM;
        public object TLS_PSK_WITH_AES_256_CCM;
        public object TLS_DHE_PSK_WITH_AES_128_CCM;
        public object TLS_DHE_PSK_WITH_AES_256_CCM;
        public object TLS_PSK_WITH_AES_128_CCM_8;
        public object TLS_PSK_WITH_AES_256_CCM_8;
        public object TLS_PSK_DHE_WITH_AES_128_CCM_8;
        public object TLS_PSK_DHE_WITH_AES_256_CCM_8;
        public object TLS_ECDHE_ECDSA_WITH_AES_128_CCM;
        public object TLS_ECDHE_ECDSA_WITH_AES_256_CCM;
        public object TLS_ECDHE_ECDSA_WITH_AES_128_CCM_8;
        public object TLS_ECDHE_ECDSA_WITH_AES_256_CCM_8;
        public object TLS_FALLBACK_SCSV;
        public object DRAFT_TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256;
        public object DRAFT_TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256;
        public object DRAFT_TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256;
        public object DRAFT_TLS_PSK_WITH_CHACHA20_POLY1305_SHA256;
        public object DRAFT_TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256;

        // ── Methods ──
        public void IsScsv(){} // RVA: 0xA1BCC20
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CipherType : Object
    {
        public object stream;
        public object block;
        public object aead;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ClientAuthenticationType : Object
    {
        public object anonymous;
        public object certificate_based;
        public object psk;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ClientCertificateType : Object
    {
        public object rsa_sign;
        public object dss_sign;
        public object rsa_fixed_dh;
        public object dss_fixed_dh;
        public object rsa_ephemeral_dh_RESERVED;
        public object dss_ephemeral_dh_RESERVED;
        public object fortezza_dms_RESERVED;
        public object ecdsa_sign;
        public object rsa_fixed_ecdh;
        public object ecdsa_fixed_ecdh;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CombinedHash : Object
    {
        public object mContext;
        public object mMd5;
        public object mSha1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1BCD60
        public void Init(){} // RVA: 0xB44D60
        public void NotifyPrfDetermined(){} // RVA: 0x2303260
        public void TrackHashAlgorithm(){} // RVA: 0xA1BCF00
        public void SealHashAlgorithms(){} // RVA: 0xB43310
        public void StopTracking(){} // RVA: 0xA1BCF50
        public void ForkPrfHash(){} // RVA: 0xA1BCFB0
        public void GetFinalHash(){} // RVA: 0xA1BD010
        public void get_AlgorithmName(){} // RVA: 0xA1BD060
        public void GetByteLength(){} // RVA: 0xA1BD100
        public void GetDigestSize(){} // RVA: 0xA1BD1B0
        public void Update(){} // RVA: 0xA1BD230
        public void BlockUpdate(){} // RVA: 0xA1BD2B0
        public void DoFinal(){} // RVA: 0xA1BD360
        public void Reset(){} // RVA: 0xA1BD500
        public void Ssl3Complete(){} // RVA: 0xA1BD570
    }

    public class CompressionMethod : Object
    {
        public object cls_null;
        public object DEFLATE;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ConnectionEnd : Object
    {
        public object server;
        public object client;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ContentType : Object
    {
        public object change_cipher_spec;
        public object alert;
        public object handshake;
        public object application_data;
        public object heartbeat;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

}