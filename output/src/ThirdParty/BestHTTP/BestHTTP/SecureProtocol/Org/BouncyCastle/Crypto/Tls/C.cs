// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 18
// Methods: 76

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class CertChainType : Object
    {
        public byte individual_certs;
        public byte pkipath;

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFACBB1F600
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Certificate : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate Length;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] IsEmpty; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB1F610
        public void GetCertificateList(){} // RVA: 0x7FFAC30821C0
        public void GetCertificateAt(){} // RVA: 0x7FFAC926F060
        public void get_Length(){} // RVA: 0x7FFAC3510620
        public void get_IsEmpty(){} // RVA: 0x7FFACBB1F6C0
        public void Encode(){} // RVA: 0x7FFACBB1F6E0
        public void Parse(){} // RVA: 0x7FFACBB1FC80
        public void CloneCertificateList(){} // RVA: 0x7FFACBB202A0
        public void .cctor(){} // RVA: 0x7FFACBB20320
    }

    public class CertificateRequest : Object
    {
        public byte[] CertificateTypes; // 0x10
        public System.Collections.IList SupportedSignatureAlgorithms; // 0x18
        public System.Collections.IList CertificateAuthorities; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00
        public void get_CertificateTypes(){} // RVA: 0x7FFAC2F3C380
        public void get_SupportedSignatureAlgorithms(){} // RVA: 0x7FFAC2F247C0
        public void get_CertificateAuthorities(){} // RVA: 0x7FFAC2F4F0C0
        public void Encode(){} // RVA: 0x7FFACBB20490
        public void Parse(){} // RVA: 0x7FFACBB20D20
    }

    public class CertificateStatus : Object
    {
        public byte StatusType; // 0x10
        public object Response; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB21310
        public void get_StatusType(){} // RVA: 0x7FFAC2FEB5E0
        public void get_Response(){} // RVA: 0x7FFAC2F247C0
        public void GetOcspResponse(){} // RVA: 0x7FFACBB213F0
        public void Encode(){} // RVA: 0x7FFACBB21510
        public void Parse(){} // RVA: 0x7FFACBB21680
        public void IsCorrectType(){} // RVA: 0x7FFACBB218E0
    }

    public class CertificateStatusRequest : Object
    {
        public byte StatusType; // 0x10
        public object Request; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB219E0
        public void get_StatusType(){} // RVA: 0x7FFAC2FEB5E0
        public void get_Request(){} // RVA: 0x7FFAC2F247C0
        public void GetOcspStatusRequest(){} // RVA: 0x7FFACBB21AC0
        public void Encode(){} // RVA: 0x7FFACBB21BE0
        public void Parse(){} // RVA: 0x7FFACBB21D10
        public void IsCorrectType(){} // RVA: 0x7FFACBB21F00
    }

    public class CertificateStatusType : Object
    {
        public byte ocsp;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CertificateType : Object
    {
        public byte X509;
        public byte OpenPGP;
        public byte RawPublicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CertificateUrl : Object
    {
        public byte Type; // 0x10
        public System.Collections.IList UrlAndHashList; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB22000
        public void get_Type(){} // RVA: 0x7FFAC2FEB5E0
        public void get_UrlAndHashList(){} // RVA: 0x7FFAC2F247C0
        public void Encode(){} // RVA: 0x7FFACBB22140
        public void parse(){} // RVA: 0x7FFACBB225A0
    }

    public class Chacha20Poly1305 : Object
    {
        public byte[] Zeroes;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext context; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine encryptCipher; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine decryptCipher; // 0x20
        public byte[] encryptIV; // 0x28
        public byte[] decryptIV; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB22BE0
        public void GetPlaintextLimit(){} // RVA: 0x7FFACBB23030
        public void EncodePlaintext(){} // RVA: 0x7FFACBB23040
        public void DecodeCiphertext(){} // RVA: 0x7FFACBB231C0
        public void InitRecord(){} // RVA: 0x7FFACBB23460
        public void CalculateNonce(){} // RVA: 0x7FFACBB23570
        public void GenerateRecordMacKey(){} // RVA: 0x7FFACBB23650
        public void CalculateRecordMac(){} // RVA: 0x7FFACBB23780
        public void UpdateRecordMacLength(){} // RVA: 0x7FFACBB23A90
        public void UpdateRecordMacText(){} // RVA: 0x7FFACBB23B60
        public void GetAdditionalData(){} // RVA: 0x7FFACBB23C60
        public void .cctor(){} // RVA: 0x7FFACBB23D90
    }

    public class ChangeCipherSpec : Object
    {
        public byte change_cipher_spec;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CipherSuite : Object
    {
        public int TLS_NULL_WITH_NULL_NULL;
        public int TLS_RSA_WITH_NULL_MD5;
        public int TLS_RSA_WITH_NULL_SHA;
        public int TLS_RSA_EXPORT_WITH_RC4_40_MD5;
        public int TLS_RSA_WITH_RC4_128_MD5;
        public int TLS_RSA_WITH_RC4_128_SHA;
        public int TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5;
        public int TLS_RSA_WITH_IDEA_CBC_SHA;
        public int TLS_RSA_EXPORT_WITH_DES40_CBC_SHA;
        public int TLS_RSA_WITH_DES_CBC_SHA;
        public int TLS_RSA_WITH_3DES_EDE_CBC_SHA;
        public int TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA;
        public int TLS_DH_DSS_WITH_DES_CBC_SHA;
        public int TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA;
        public int TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA;
        public int TLS_DH_RSA_WITH_DES_CBC_SHA;
        public int TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA;
        public int TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA;
        public int TLS_DHE_DSS_WITH_DES_CBC_SHA;
        public int TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA;
        public int TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA;
        public int TLS_DHE_RSA_WITH_DES_CBC_SHA;
        public int TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA;
        public int TLS_DH_anon_EXPORT_WITH_RC4_40_MD5;
        public int TLS_DH_anon_WITH_RC4_128_MD5;
        public int TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA;
        public int TLS_DH_anon_WITH_DES_CBC_SHA;
        public int TLS_DH_anon_WITH_3DES_EDE_CBC_SHA;
        public int TLS_RSA_WITH_AES_128_CBC_SHA;
        public int TLS_DH_DSS_WITH_AES_128_CBC_SHA;
        public int TLS_DH_RSA_WITH_AES_128_CBC_SHA;
        public int TLS_DHE_DSS_WITH_AES_128_CBC_SHA;
        public int TLS_DHE_RSA_WITH_AES_128_CBC_SHA;
        public int TLS_DH_anon_WITH_AES_128_CBC_SHA;
        public int TLS_RSA_WITH_AES_256_CBC_SHA;
        public int TLS_DH_DSS_WITH_AES_256_CBC_SHA;
        public int TLS_DH_RSA_WITH_AES_256_CBC_SHA;
        public int TLS_DHE_DSS_WITH_AES_256_CBC_SHA;
        public int TLS_DHE_RSA_WITH_AES_256_CBC_SHA;
        public int TLS_DH_anon_WITH_AES_256_CBC_SHA;
        public int TLS_RSA_WITH_CAMELLIA_128_CBC_SHA;
        public int TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA;
        public int TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA;
        public int TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA;
        public int TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA;
        public int TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA;
        public int TLS_RSA_WITH_CAMELLIA_256_CBC_SHA;
        public int TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA;
        public int TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA;
        public int TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA;
        public int TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA;
        public int TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA;
        public int TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256;
        public int TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256;
        public int TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256;
        public int TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256;
        public int TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256;
        public int TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256;
        public int TLS_RSA_WITH_SEED_CBC_SHA;
        public int TLS_DH_DSS_WITH_SEED_CBC_SHA;
        public int TLS_DH_RSA_WITH_SEED_CBC_SHA;
        public int TLS_DHE_DSS_WITH_SEED_CBC_SHA;
        public int TLS_DHE_RSA_WITH_SEED_CBC_SHA;
        public int TLS_DH_anon_WITH_SEED_CBC_SHA;
        public int TLS_PSK_WITH_RC4_128_SHA;
        public int TLS_PSK_WITH_3DES_EDE_CBC_SHA;
        public int TLS_PSK_WITH_AES_128_CBC_SHA;
        public int TLS_PSK_WITH_AES_256_CBC_SHA;
        public int TLS_DHE_PSK_WITH_RC4_128_SHA;
        public int TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA;
        public int TLS_DHE_PSK_WITH_AES_128_CBC_SHA;
        public int TLS_DHE_PSK_WITH_AES_256_CBC_SHA;
        public int TLS_RSA_PSK_WITH_RC4_128_SHA;
        public int TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA;
        public int TLS_RSA_PSK_WITH_AES_128_CBC_SHA;
        public int TLS_RSA_PSK_WITH_AES_256_CBC_SHA;
        public int TLS_ECDH_ECDSA_WITH_NULL_SHA;
        public int TLS_ECDH_ECDSA_WITH_RC4_128_SHA;
        public int TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA;
        public int TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA;
        public int TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA;
        public int TLS_ECDHE_ECDSA_WITH_NULL_SHA;
        public int TLS_ECDHE_ECDSA_WITH_RC4_128_SHA;
        public int TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA;
        public int TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA;
        public int TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA;
        public int TLS_ECDH_RSA_WITH_NULL_SHA;
        public int TLS_ECDH_RSA_WITH_RC4_128_SHA;
        public int TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA;
        public int TLS_ECDH_RSA_WITH_AES_128_CBC_SHA;
        public int TLS_ECDH_RSA_WITH_AES_256_CBC_SHA;
        public int TLS_ECDHE_RSA_WITH_NULL_SHA;
        public int TLS_ECDHE_RSA_WITH_RC4_128_SHA;
        public int TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA;
        public int TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA;
        public int TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA;
        public int TLS_ECDH_anon_WITH_NULL_SHA;
        public int TLS_ECDH_anon_WITH_RC4_128_SHA;
        public int TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA;
        public int TLS_ECDH_anon_WITH_AES_128_CBC_SHA;
        public int TLS_ECDH_anon_WITH_AES_256_CBC_SHA;
        public int TLS_PSK_WITH_NULL_SHA;
        public int TLS_DHE_PSK_WITH_NULL_SHA;
        public int TLS_RSA_PSK_WITH_NULL_SHA;
        public int TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA;
        public int TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA;
        public int TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA;
        public int TLS_SRP_SHA_WITH_AES_128_CBC_SHA;
        public int TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA;
        public int TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA;
        public int TLS_SRP_SHA_WITH_AES_256_CBC_SHA;
        public int TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA;
        public int TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA;
        public int TLS_RSA_WITH_NULL_SHA256;
        public int TLS_RSA_WITH_AES_128_CBC_SHA256;
        public int TLS_RSA_WITH_AES_256_CBC_SHA256;
        public int TLS_DH_DSS_WITH_AES_128_CBC_SHA256;
        public int TLS_DH_RSA_WITH_AES_128_CBC_SHA256;
        public int TLS_DHE_DSS_WITH_AES_128_CBC_SHA256;
        public int TLS_DHE_RSA_WITH_AES_128_CBC_SHA256;
        public int TLS_DH_DSS_WITH_AES_256_CBC_SHA256;
        public int TLS_DH_RSA_WITH_AES_256_CBC_SHA256;
        public int TLS_DHE_DSS_WITH_AES_256_CBC_SHA256;
        public int TLS_DHE_RSA_WITH_AES_256_CBC_SHA256;
        public int TLS_DH_anon_WITH_AES_128_CBC_SHA256;
        public int TLS_DH_anon_WITH_AES_256_CBC_SHA256;
        public int TLS_RSA_WITH_AES_128_GCM_SHA256;
        public int TLS_RSA_WITH_AES_256_GCM_SHA384;
        public int TLS_DHE_RSA_WITH_AES_128_GCM_SHA256;
        public int TLS_DHE_RSA_WITH_AES_256_GCM_SHA384;
        public int TLS_DH_RSA_WITH_AES_128_GCM_SHA256;
        public int TLS_DH_RSA_WITH_AES_256_GCM_SHA384;
        public int TLS_DHE_DSS_WITH_AES_128_GCM_SHA256;
        public int TLS_DHE_DSS_WITH_AES_256_GCM_SHA384;
        public int TLS_DH_DSS_WITH_AES_128_GCM_SHA256;
        public int TLS_DH_DSS_WITH_AES_256_GCM_SHA384;
        public int TLS_DH_anon_WITH_AES_128_GCM_SHA256;
        public int TLS_DH_anon_WITH_AES_256_GCM_SHA384;
        public int TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256;
        public int TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384;
        public int TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256;
        public int TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384;
        public int TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256;
        public int TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384;
        public int TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256;
        public int TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384;
        public int TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256;
        public int TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384;
        public int TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256;
        public int TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384;
        public int TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256;
        public int TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384;
        public int TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256;
        public int TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384;
        public int TLS_PSK_WITH_AES_128_GCM_SHA256;
        public int TLS_PSK_WITH_AES_256_GCM_SHA384;
        public int TLS_DHE_PSK_WITH_AES_128_GCM_SHA256;
        public int TLS_DHE_PSK_WITH_AES_256_GCM_SHA384;
        public int TLS_RSA_PSK_WITH_AES_128_GCM_SHA256;
        public int TLS_RSA_PSK_WITH_AES_256_GCM_SHA384;
        public int TLS_PSK_WITH_AES_128_CBC_SHA256;
        public int TLS_PSK_WITH_AES_256_CBC_SHA384;
        public int TLS_PSK_WITH_NULL_SHA256;
        public int TLS_PSK_WITH_NULL_SHA384;
        public int TLS_DHE_PSK_WITH_AES_128_CBC_SHA256;
        public int TLS_DHE_PSK_WITH_AES_256_CBC_SHA384;
        public int TLS_DHE_PSK_WITH_NULL_SHA256;
        public int TLS_DHE_PSK_WITH_NULL_SHA384;
        public int TLS_RSA_PSK_WITH_AES_128_CBC_SHA256;
        public int TLS_RSA_PSK_WITH_AES_256_CBC_SHA384;
        public int TLS_RSA_PSK_WITH_NULL_SHA256;
        public int TLS_RSA_PSK_WITH_NULL_SHA384;
        public int TLS_ECDHE_PSK_WITH_RC4_128_SHA;
        public int TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA;
        public int TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA;
        public int TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA;
        public int TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256;
        public int TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384;
        public int TLS_ECDHE_PSK_WITH_NULL_SHA;
        public int TLS_ECDHE_PSK_WITH_NULL_SHA256;
        public int TLS_ECDHE_PSK_WITH_NULL_SHA384;
        public int TLS_EMPTY_RENEGOTIATION_INFO_SCSV;
        public int TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384;
        public int TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384;
        public int TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384;
        public int TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384;
        public int TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256;
        public int TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384;
        public int TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384;
        public int TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384;
        public int TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384;
        public int TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256;
        public int TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384;
        public int TLS_RSA_WITH_AES_128_CCM;
        public int TLS_RSA_WITH_AES_256_CCM;
        public int TLS_DHE_RSA_WITH_AES_128_CCM;
        public int TLS_DHE_RSA_WITH_AES_256_CCM;
        public int TLS_RSA_WITH_AES_128_CCM_8;
        public int TLS_RSA_WITH_AES_256_CCM_8;
        public int TLS_DHE_RSA_WITH_AES_128_CCM_8;
        public int TLS_DHE_RSA_WITH_AES_256_CCM_8;
        public int TLS_PSK_WITH_AES_128_CCM;
        public int TLS_PSK_WITH_AES_256_CCM;
        public int TLS_DHE_PSK_WITH_AES_128_CCM;
        public int TLS_DHE_PSK_WITH_AES_256_CCM;
        public int TLS_PSK_WITH_AES_128_CCM_8;
        public int TLS_PSK_WITH_AES_256_CCM_8;
        public int TLS_PSK_DHE_WITH_AES_128_CCM_8;
        public int TLS_PSK_DHE_WITH_AES_256_CCM_8;
        public int TLS_ECDHE_ECDSA_WITH_AES_128_CCM;
        public int TLS_ECDHE_ECDSA_WITH_AES_256_CCM;
        public int TLS_ECDHE_ECDSA_WITH_AES_128_CCM_8;
        public int TLS_ECDHE_ECDSA_WITH_AES_256_CCM_8;
        public int TLS_FALLBACK_SCSV;
        public int DRAFT_TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256;
        public int DRAFT_TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256;
        public int DRAFT_TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256;
        public int DRAFT_TLS_PSK_WITH_CHACHA20_POLY1305_SHA256;
        public int DRAFT_TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256;
        public int DRAFT_TLS_DHE_PSK_WITH_CHACHA20_POLY1305_SHA256;
        public int DRAFT_TLS_RSA_PSK_WITH_CHACHA20_POLY1305_SHA256;
        public int DRAFT_TLS_DHE_RSA_WITH_AES_128_OCB;
        public int DRAFT_TLS_DHE_RSA_WITH_AES_256_OCB;
        public int DRAFT_TLS_ECDHE_RSA_WITH_AES_128_OCB;
        public int DRAFT_TLS_ECDHE_RSA_WITH_AES_256_OCB;
        public int DRAFT_TLS_ECDHE_ECDSA_WITH_AES_128_OCB;
        public int DRAFT_TLS_ECDHE_ECDSA_WITH_AES_256_OCB;
        public int DRAFT_TLS_PSK_WITH_AES_128_OCB;
        public int DRAFT_TLS_PSK_WITH_AES_256_OCB;
        public int DRAFT_TLS_DHE_PSK_WITH_AES_128_OCB;
        public int DRAFT_TLS_DHE_PSK_WITH_AES_256_OCB;
        public int DRAFT_TLS_ECDHE_PSK_WITH_AES_128_OCB;
        public int DRAFT_TLS_ECDHE_PSK_WITH_AES_256_OCB;

        // ── Methods ──
        public void IsScsv(){} // RVA: 0x7FFACBB23E50
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CipherType : Object
    {
        public int stream;
        public int block;
        public int aead;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ClientAuthenticationType : Object
    {
        public byte anonymous;
        public byte certificate_based;
        public byte psk;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ClientCertificateType : Object
    {
        public byte rsa_sign;
        public byte dss_sign;
        public byte rsa_fixed_dh;
        public byte dss_fixed_dh;
        public byte rsa_ephemeral_dh_RESERVED;
        public byte dss_ephemeral_dh_RESERVED;
        public byte fortezza_dms_RESERVED;
        public byte ecdsa_sign;
        public byte rsa_fixed_ecdh;
        public byte ecdsa_fixed_ecdh;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CombinedHash : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mMd5; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mSha1; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB23F90 | overloaded x2
        public void Init(){} // RVA: 0x7FFAC2F22E30
        public void NotifyPrfDetermined(){} // RVA: 0x7FFAC44F81E0
        public void TrackHashAlgorithm(){} // RVA: 0x7FFACBB24130
        public void SealHashAlgorithms(){} // RVA: 0x7FFAC2F21310
        public void StopTracking(){} // RVA: 0x7FFACBB24180
        public void ForkPrfHash(){} // RVA: 0x7FFACBB241E0
        public void GetFinalHash(){} // RVA: 0x7FFACBB24240
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB24290
        public void GetByteLength(){} // RVA: 0x7FFACBB24330
        public void GetDigestSize(){} // RVA: 0x7FFACBB243E0
        public void Update(){} // RVA: 0x7FFACBB24460
        public void BlockUpdate(){} // RVA: 0x7FFACBB244E0
        public void DoFinal(){} // RVA: 0x7FFACBB24590
        public void Reset(){} // RVA: 0x7FFACBB24730
        public void Ssl3Complete(){} // RVA: 0x7FFACBB247A0
    }

    public class CompressionMethod : Object
    {
        public byte cls_null;
        public byte DEFLATE;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ConnectionEnd : Object
    {
        public int server;
        public int client;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ContentType : Object
    {
        public byte change_cipher_spec;
        public byte alert;
        public byte handshake;
        public byte application_data;
        public byte heartbeat;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}