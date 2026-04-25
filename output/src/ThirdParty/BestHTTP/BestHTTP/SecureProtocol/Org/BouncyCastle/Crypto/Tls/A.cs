// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 13
// Methods: 127

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class AbstractTlsAgreementCredentials : AbstractTlsCredentials
    {
        // ── Methods ──
        public void GenerateAgreement(){} // RVA: 0x7FFAC2C58F40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AbstractTlsCipherFactory : Object
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0x7FFACBB1A2D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AbstractTlsClient : AbstractTlsPeer
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCipherFactory HostNames; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsClientContext ClientHelloRecordLayerVersion; // 0x18
        public System.Collections.IList ClientVersion; // 0x20
        public int[] IsFallback; // 0x28
        public byte[] MinimumVersion; // 0x30
        public byte[] mServerECPointFormats; // 0x38
        public int mSelectedCipherSuite; // 0x40
        public short mSelectedCompressionMethod; // 0x44
        public System.Collections.Generic.List`1<string> <HostNames>k__BackingField; // 0x48

        // ── Methods ──
        public void get_HostNames(){} // RVA: 0x7FFAC2F9C730
        public void set_HostNames(){} // RVA: 0x7FFAC2F9C740
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void AllowUnexpectedServerExtension(){} // RVA: 0x7FFACBB1A3B0
        public void CheckForUnexpectedServerExtension(){} // RVA: 0x7FFACBB1A450
        public void Init(){} // RVA: 0x7FFAC2F87E80
        public void GetSessionToResume(){} // RVA: 0x7FFAC34F9180
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0x7FFACBB1A520
        public void get_ClientVersion(){} // RVA: 0x7FFACBB1A540
        public void get_IsFallback(){} // RVA: 0x7FFAC2F21320
        public void GetClientExtensions(){} // RVA: 0x7FFACBB1A5A0
        public void get_MinimumVersion(){} // RVA: 0x7FFACBB1AD90
        public void NotifyServerVersion(){} // RVA: 0x7FFACBB1ADF0
        public void GetCipherSuites(){} // RVA: 0x7FFAC2C58E90
        public void GetCompressionMethods(){} // RVA: 0x7FFACBB1AEA0
        public void NotifySessionID(){} // RVA: 0x7FFAC2F21310
        public void NotifySelectedCipherSuite(){} // RVA: 0x7FFAC2FC2090
        public void NotifySelectedCompressionMethod(){} // RVA: 0x7FFACBB1AEE0
        public void ProcessServerExtensions(){} // RVA: 0x7FFACBB1AEF0
        public void ProcessServerSupplementalData(){} // RVA: 0x7FFACBB1B060
        public void GetKeyExchange(){} // RVA: 0x7FFAC2C58E90
        public void GetAuthentication(){} // RVA: 0x7FFAC2C58E90
        public void GetClientSupplementalData(){} // RVA: 0x7FFAC34F9180
        public void GetCompression(){} // RVA: 0x7FFACBB1B0C0
        public void GetCipher(){} // RVA: 0x7FFACBB1B2D0
        public void NotifyNewSessionTicket(){} // RVA: 0x7FFAC2F21310
    }

    public class AbstractTlsContext : Object
    {
        public long NonceRandomGenerator;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.IRandomGenerator SecureRandom; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom SecurityParameters; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.SecurityParameters IsServer; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion ServerVersion; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSession ResumableSession; // 0x38
        public object UserObject; // 0x40

        // ── Methods ──
        public void NextCounterValue(){} // RVA: 0x7FFACBB1B370
        public void .ctor(){} // RVA: 0x7FFACBB1B3D0
        public void get_NonceRandomGenerator(){} // RVA: 0x7FFAC2F3C380
        public void get_SecureRandom(){} // RVA: 0x7FFAC2F247C0
        public void get_SecurityParameters(){} // RVA: 0x7FFAC2F4F0C0
        public void get_IsServer(){} // RVA: 0x7FFAC2C59D00
        public void get_ClientVersion(){} // RVA: 0x7FFAC2F4F130
        public void SetClientVersion(){} // RVA: 0x7FFAC2F22E90
        public void get_ServerVersion(){} // RVA: 0x7FFAC31D95E0
        public void SetServerVersion(){} // RVA: 0x7FFAC2F4F890
        public void get_ResumableSession(){} // RVA: 0x7FFAC31D0140
        public void SetResumableSession(){} // RVA: 0x7FFAC31D0C20
        public void get_UserObject(){} // RVA: 0x7FFAC2F9E740
        public void set_UserObject(){} // RVA: 0x7FFAC2F49200
        public void ExportKeyingMaterial(){} // RVA: 0x7FFACBB1B700
        public void .cctor(){} // RVA: 0x7FFACBB1BA70
    }

    public class AbstractTlsCredentials : Object
    {
        public object Certificate;

        // ── Methods ──
        public void get_Certificate(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AbstractTlsEncryptionCredentials : AbstractTlsCredentials
    {
        // ── Methods ──
        public void DecryptPreMasterSecret(){} // RVA: 0x7FFAC2C58F40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AbstractTlsKeyExchange : Object
    {
        public int RequiresServerKeyExchange; // 0x10
        public System.Collections.IList mSupportedSignatureAlgorithms; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext mContext; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47EB5F0
        public void ParseSignature(){} // RVA: 0x7FFACBB1BAE0
        public void Init(){} // RVA: 0x7FFACBB1BB90
        public void SkipServerCredentials(){} // RVA: 0x7FFAC2C70980
        public void ProcessServerCertificate(){} // RVA: 0x7FFAC2F21310
        public void ProcessServerCredentials(){} // RVA: 0x7FFACBB1BFF0
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFAC2F21320
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFACBB1C060
        public void SkipServerKeyExchange(){} // RVA: 0x7FFACBB1C0D0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFACBB1C140
        public void ValidateCertificateRequest(){} // RVA: 0x7FFAC2C70A40
        public void SkipClientCredentials(){} // RVA: 0x7FFAC2F21310
        public void ProcessClientCredentials(){} // RVA: 0x7FFAC2C70A40
        public void ProcessClientCertificate(){} // RVA: 0x7FFAC2F21310
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFAC2C70A40
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFACBB1C1B0
        public void GeneratePremasterSecret(){} // RVA: 0x7FFAC2C58E90
    }

    public class AbstractTlsPeer : Object
    {
        // ── Methods ──
        public void RequiresExtendedMasterSecret(){} // RVA: 0x7FFAC2F21320
        public void ShouldUseGmtUnixTime(){} // RVA: 0x7FFAC2F21320
        public void NotifySecureRenegotiation(){} // RVA: 0x7FFACBB1C200
        public void GetCompression(){} // RVA: 0x7FFAC2C58E90
        public void GetCipher(){} // RVA: 0x7FFAC2C58E90
        public void NotifyAlertRaised(){} // RVA: 0x7FFAC2F21310
        public void NotifyAlertReceived(){} // RVA: 0x7FFAC2F21310
        public void NotifyHandshakeComplete(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AbstractTlsServer : AbstractTlsPeer
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCipherFactory AllowEncryptThenMac; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsServerContext AllowTruncatedHMac; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion MaximumVersion; // 0x20
        public int[] MinimumVersion; // 0x28
        public byte[] mOfferedCompressionMethods; // 0x30
        public System.Collections.IDictionary mClientExtensions; // 0x38
        public bool mEncryptThenMacOffered; // 0x40
        public short mMaxFragmentLengthOffered; // 0x42
        public bool mTruncatedHMacOffered; // 0x44
        public System.Collections.IList mSupportedSignatureAlgorithms; // 0x48
        public bool mEccCipherSuitesOffered; // 0x50
        public int[] mNamedCurves; // 0x58
        public byte[] mClientECPointFormats; // 0x60
        public byte[] mServerECPointFormats; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion mServerVersion; // 0x70
        public int mSelectedCipherSuite; // 0x78
        public byte mSelectedCompressionMethod; // 0x7C
        public System.Collections.IDictionary mServerExtensions; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_AllowEncryptThenMac(){} // RVA: 0x7FFAC3006850
        public void get_AllowTruncatedHMac(){} // RVA: 0x7FFAC2F21320
        public void CheckServerExtensions(){} // RVA: 0x7FFACBB1C2F0
        public void GetCipherSuites(){} // RVA: 0x7FFAC2C58E90
        public void GetCompressionMethods(){} // RVA: 0x7FFACBB1C3F0
        public void get_MaximumVersion(){} // RVA: 0x7FFACBB1C430
        public void get_MinimumVersion(){} // RVA: 0x7FFACBB1C490
        public void SupportsClientEccCapabilities(){} // RVA: 0x7FFACBB1C4F0
        public void Init(){} // RVA: 0x7FFAC2F87E80
        public void NotifyClientVersion(){} // RVA: 0x7FFAC2F4F0D0
        public void NotifyFallback(){} // RVA: 0x7FFACBB1C630
        public void NotifyOfferedCipherSuites(){} // RVA: 0x7FFACBB1C6E0
        public void NotifyOfferedCompressionMethods(){} // RVA: 0x7FFAC2F4F890
        public void ProcessClientExtensions(){} // RVA: 0x7FFACBB1C7A0
        public void GetServerVersion(){} // RVA: 0x7FFACBB1CC70
        public void GetSelectedCipherSuite(){} // RVA: 0x7FFACBB1CE30
        public void GetSelectedCompressionMethod(){} // RVA: 0x7FFACBB1D060
        public void GetServerExtensions(){} // RVA: 0x7FFACBB1D1B0
        public void GetServerSupplementalData(){} // RVA: 0x7FFAC34F9180
        public void GetCredentials(){} // RVA: 0x7FFAC2C58E90
        public void GetCertificateStatus(){} // RVA: 0x7FFAC34F9180
        public void GetKeyExchange(){} // RVA: 0x7FFAC2C58E90
        public void GetCertificateRequest(){} // RVA: 0x7FFAC34F9180
        public void ProcessClientSupplementalData(){} // RVA: 0x7FFACBB1D670
        public void NotifyClientCertificate(){} // RVA: 0x7FFACBB1D6D0
        public void GetCompression(){} // RVA: 0x7FFACBB1D720
        public void GetCipher(){} // RVA: 0x7FFACBB1D7A0
        public void GetNewSessionTicket(){} // RVA: 0x7FFACBB1D840
    }

    public class AbstractTlsSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext mContext; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2F22E30
        public void GenerateRawSignature(){} // RVA: 0x7FFAC2C6AE80 | overloaded x2
        public void VerifyRawSignature(){} // RVA: 0x7FFAC2C5D680 | overloaded x2
        public void CreateSigner(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void CreateVerifyer(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void IsValidPublicKey(){} // RVA: 0x7FFAC2C59F60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AbstractTlsSignerCredentials : AbstractTlsCredentials
    {
        public object SignatureAndHashAlgorithm;

        // ── Methods ──
        public void GenerateCertificateSignature(){} // RVA: 0x7FFAC2C58F40
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x7FFACBB1D9B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AlertDescription : Object
    {
        public byte close_notify;
        public byte unexpected_message;
        public byte bad_record_mac;
        public byte decryption_failed;
        public byte record_overflow;
        public byte decompression_failure;
        public byte handshake_failure;
        public byte no_certificate;
        public byte bad_certificate;
        public byte unsupported_certificate;
        public byte certificate_revoked;
        public byte certificate_expired;
        public byte certificate_unknown;
        public byte illegal_parameter;
        public byte unknown_ca;
        public byte access_denied;
        public byte decode_error;
        public byte decrypt_error;
        public byte export_restriction;
        public byte protocol_version;
        public byte insufficient_security;
        public byte internal_error;
        public byte user_canceled;
        public byte no_renegotiation;
        public byte unsupported_extension;
        public byte certificate_unobtainable;
        public byte unrecognized_name;
        public byte bad_certificate_status_response;
        public byte bad_certificate_hash_value;
        public byte unknown_psk_identity;
        public byte inappropriate_fallback;

        // ── Methods ──
        public void GetName(){} // RVA: 0x7FFACBB1DA00
        public void GetText(){} // RVA: 0x7FFACBB1DEF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AlertLevel : Object
    {
        public byte warning;
        public byte fatal;

        // ── Methods ──
        public void GetName(){} // RVA: 0x7FFACBB1DF70
        public void GetText(){} // RVA: 0x7FFACBB1DFF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}