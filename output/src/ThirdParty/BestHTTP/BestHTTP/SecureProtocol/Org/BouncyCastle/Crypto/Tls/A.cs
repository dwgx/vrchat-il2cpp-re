// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 13
// Methods: 121

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class AbstractTlsAgreementCredentials : AbstractTlsCredentials
    {
        // ── Methods ──
        public void GenerateAgreement(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AbstractTlsCipherFactory : Object
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0xA1B2F40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AbstractTlsClient : AbstractTlsPeer
    {
        public object mCipherFactory;
        public object mContext;
        public object mSupportedSignatureAlgorithms;
        public object mNamedCurves;
        public object mClientECPointFormats;
        public object mServerECPointFormats;
        public object mSelectedCipherSuite;
        public object mSelectedCompressionMethod;
        public object _hostNames;

        // ── Methods ──
        public void get_HostNames(){} // RVA: 0xBBF8F0
        public void set_HostNames(){} // RVA: 0xBBF900
        public void .ctor(){} // RVA: 0xB44D60
        public void AllowUnexpectedServerExtension(){} // RVA: 0xA1B3020
        public void CheckForUnexpectedServerExtension(){} // RVA: 0xA1B30C0
        public void Init(){} // RVA: 0xBA9BA0
        public void GetSessionToResume(){} // RVA: 0xDAC980
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0xA1B3190
        public void get_ClientVersion(){} // RVA: 0xA1B31B0
        public void get_IsFallback(){} // RVA: 0xB43320
        public void GetClientExtensions(){} // RVA: 0xA1B3210
        public void get_MinimumVersion(){} // RVA: 0xA1B3B40
        public void NotifyServerVersion(){} // RVA: 0xA1B3BA0
        public void GetCipherSuites(){} // RVA: 0x87C0A0
        public void GetCompressionMethods(){} // RVA: 0xA1B3C50
        public void NotifySessionID(){} // RVA: 0xB43310
        public void NotifySelectedCipherSuite(){} // RVA: 0xBE5860
        public void NotifySelectedCompressionMethod(){} // RVA: 0xA1B3C90
        public void ProcessServerExtensions(){} // RVA: 0xA1B3CA0
        public void ProcessServerSupplementalData(){} // RVA: 0xA1B3E10
        public void GetKeyExchange(){} // RVA: 0x87C0A0
        public void GetAuthentication(){} // RVA: 0x87C0A0
        public void GetClientSupplementalData(){} // RVA: 0xDAC980
        public void GetCompression(){} // RVA: 0xA1B3E70
        public void GetCipher(){} // RVA: 0xA1B4080
        public void NotifyNewSessionTicket(){} // RVA: 0xB43310
    }

    public class AbstractTlsContext : Object
    {
        public object counter;
        public object mNonceRandom;
        public object mSecureRandom;
        public object mSecurityParameters;
        public object mClientVersion;
        public object mServerVersion;
        public object mSession;
        public object mUserObject;

        // ── Methods ──
        public void NextCounterValue(){} // RVA: 0xA1B4120
        public void .ctor(){} // RVA: 0xA1B4180
        public void get_NonceRandomGenerator(){} // RVA: 0xB5DBF0
        public void get_SecureRandom(){} // RVA: 0xB465B0
        public void get_SecurityParameters(){} // RVA: 0xB700F0
        public void get_IsServer(){} // RVA: 0x87D280
        public void get_ClientVersion(){} // RVA: 0xB70160
        public void SetClientVersion(){} // RVA: 0xB44DC0
        public void get_ServerVersion(){} // RVA: 0xD33E60
        public void SetServerVersion(){} // RVA: 0xB708C0
        public void get_ResumableSession(){} // RVA: 0xD05CA0
        public void SetResumableSession(){} // RVA: 0xD09D70
        public void get_UserObject(){} // RVA: 0xBC1B30
        public void set_UserObject(){} // RVA: 0xB6A8C0
        public void ExportKeyingMaterial(){} // RVA: 0xA1B44B0
        public void .cctor(){} // RVA: 0xA1B4820
    }

    public class AbstractTlsCredentials : Object
    {
        // ── Methods ──
        public void get_Certificate(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AbstractTlsEncryptionCredentials : AbstractTlsCredentials
    {
        // ── Methods ──
        public void DecryptPreMasterSecret(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AbstractTlsKeyExchange : Object
    {
        public object mKeyExchange;
        public object mSupportedSignatureAlgorithms;
        public object mContext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2574280
        public void ParseSignature(){} // RVA: 0xA1B4890
        public void Init(){} // RVA: 0xA1B4940
        public void SkipServerCredentials(){} // RVA: 0x894290
        public void ProcessServerCertificate(){} // RVA: 0xB43310
        public void ProcessServerCredentials(){} // RVA: 0xA1B4DA0
        public void get_RequiresServerKeyExchange(){} // RVA: 0xB43320
        public void GenerateServerKeyExchange(){} // RVA: 0xA1B4E10
        public void SkipServerKeyExchange(){} // RVA: 0xA1B4E80
        public void ProcessServerKeyExchange(){} // RVA: 0xA1B4EF0
        public void ValidateCertificateRequest(){} // RVA: 0x894320
        public void SkipClientCredentials(){} // RVA: 0xB43310
        public void ProcessClientCredentials(){} // RVA: 0x894320
        public void ProcessClientCertificate(){} // RVA: 0xB43310
        public void GenerateClientKeyExchange(){} // RVA: 0x894320
        public void ProcessClientKeyExchange(){} // RVA: 0xA1B4F60
        public void GeneratePremasterSecret(){} // RVA: 0x87C0A0
    }

    public class AbstractTlsPeer : Object
    {
        // ── Methods ──
        public void RequiresExtendedMasterSecret(){} // RVA: 0xB43320
        public void ShouldUseGmtUnixTime(){} // RVA: 0xB43320
        public void NotifySecureRenegotiation(){} // RVA: 0xA1B4FB0
        public void GetCompression(){} // RVA: 0x87C0A0
        public void GetCipher(){} // RVA: 0x87C0A0
        public void NotifyAlertRaised(){} // RVA: 0xB43310
        public void NotifyAlertReceived(){} // RVA: 0xB43310
        public void NotifyHandshakeComplete(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AbstractTlsServer : AbstractTlsPeer
    {
        public object mCipherFactory;
        public object mContext;
        public object mClientVersion;
        public object mOfferedCipherSuites;
        public object mOfferedCompressionMethods;
        public object mClientExtensions;
        public object mEncryptThenMacOffered;
        public object mMaxFragmentLengthOffered;
        public object mTruncatedHMacOffered;
        public object mSupportedSignatureAlgorithms;
        public object mEccCipherSuitesOffered;
        public object mNamedCurves;
        public object mClientECPointFormats;
        public object mServerECPointFormats;
        public object mServerVersion;
        public object mSelectedCipherSuite;
        public object mSelectedCompressionMethod;
        public object mServerExtensions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_AllowEncryptThenMac(){} // RVA: 0xC2E4C0
        public void get_AllowTruncatedHMac(){} // RVA: 0xB43320
        public void CheckServerExtensions(){} // RVA: 0xA1B50A0
        public void GetCipherSuites(){} // RVA: 0x87C0A0
        public void GetCompressionMethods(){} // RVA: 0xA1B51A0
        public void get_MaximumVersion(){} // RVA: 0xA1B51E0
        public void get_MinimumVersion(){} // RVA: 0xA1B5240
        public void SupportsClientEccCapabilities(){} // RVA: 0xA1B52A0
        public void Init(){} // RVA: 0xBA9BA0
        public void NotifyClientVersion(){} // RVA: 0xB70100
        public void NotifyFallback(){} // RVA: 0xA1B53F0
        public void NotifyOfferedCipherSuites(){} // RVA: 0xA1B54B0
        public void NotifyOfferedCompressionMethods(){} // RVA: 0xB708C0
        public void ProcessClientExtensions(){} // RVA: 0xA1B5570
        public void GetServerVersion(){} // RVA: 0xA1B5A30
        public void GetSelectedCipherSuite(){} // RVA: 0xA1B5C00
        public void GetSelectedCompressionMethod(){} // RVA: 0xA1B5E30
        public void GetServerExtensions(){} // RVA: 0xA1B5F80
        public void GetServerSupplementalData(){} // RVA: 0xDAC980
        public void GetCredentials(){} // RVA: 0x87C0A0
        public void GetCertificateStatus(){} // RVA: 0xDAC980
        public void GetKeyExchange(){} // RVA: 0x87C0A0
        public void GetCertificateRequest(){} // RVA: 0xDAC980
        public void ProcessClientSupplementalData(){} // RVA: 0xA1B6410
        public void NotifyClientCertificate(){} // RVA: 0xA1B6470
        public void GetCompression(){} // RVA: 0xA1B64C0
        public void GetCipher(){} // RVA: 0xA1B6540
        public void GetNewSessionTicket(){} // RVA: 0xA1B65E0
    }

    public class AbstractTlsSigner : Object
    {
        public object mContext;

        // ── Methods ──
        public void Init(){} // RVA: 0xB44D60
        public void GenerateRawSignature(){} // RVA: 0x882090
        public void VerifyRawSignature(){} // RVA: 0x87D760
        public void CreateSigner(){} // RVA: 0x87C5F0
        public void CreateVerifyer(){} // RVA: 0x87C5F0
        public void IsValidPublicKey(){} // RVA: 0x87D350
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AbstractTlsSignerCredentials : AbstractTlsCredentials
    {
        // ── Methods ──
        public void GenerateCertificateSignature(){} // RVA: 0x87C540
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0xA1B6750
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AlertDescription : Object
    {
        public object close_notify;
        public object unexpected_message;
        public object bad_record_mac;
        public object decryption_failed;
        public object record_overflow;
        public object decompression_failure;
        public object handshake_failure;
        public object no_certificate;
        public object bad_certificate;
        public object unsupported_certificate;
        public object certificate_revoked;
        public object certificate_expired;
        public object certificate_unknown;
        public object illegal_parameter;
        public object unknown_ca;
        public object access_denied;
        public object decode_error;
        public object decrypt_error;
        public object export_restriction;
        public object protocol_version;
        public object insufficient_security;
        public object internal_error;
        public object user_canceled;
        public object no_renegotiation;
        public object unsupported_extension;
        public object certificate_unobtainable;
        public object unrecognized_name;
        public object bad_certificate_status_response;
        public object bad_certificate_hash_value;
        public object unknown_psk_identity;
        public object inappropriate_fallback;

        // ── Methods ──
        public void GetName(){} // RVA: 0xA1B67A0
        public void GetText(){} // RVA: 0xA1B6CA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AlertLevel : Object
    {
        public object warning;
        public object fatal;

        // ── Methods ──
        public void GetName(){} // RVA: 0xA1B6D20
        public void GetText(){} // RVA: 0xA1B6DA0
        public void .ctor(){} // RVA: 0xB43310
    }

}