// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 13
// Methods: 127

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class AbstractTlsAgreementCredentials : AbstractTlsCredentials
    {
        // ── Methods ──
        public void GenerateAgreement(){} // RVA: 0x7FFE80E2E390
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AbstractTlsCipherFactory : Object
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0x7FFE89F738F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AbstractTlsClient : AbstractTlsPeer
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCipherFactory mCipherFactory; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsClientContext mContext; // 0x18
        public System.Collections.IList mSupportedSignatureAlgorithms; // 0x20
        public int[] mNamedCurves; // 0x28
        public byte[] mClientECPointFormats; // 0x30

        // ── Methods ──
        public void get_HostNames(){} // RVA: 0x7FFE81176730
        public void set_HostNames(){} // RVA: 0x7FFE81176740
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void AllowUnexpectedServerExtension(){} // RVA: 0x7FFE89F739D0
        public void CheckForUnexpectedServerExtension(){} // RVA: 0x7FFE89F73A70
        public void Init(){} // RVA: 0x7FFE81161E80
        public void GetSessionToResume(){} // RVA: 0x7FFE813240E0
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0x7FFE89F73B40
        public void get_ClientVersion(){} // RVA: 0x7FFE89F73B60
        public void get_IsFallback(){} // RVA: 0x7FFE810FB320
        public void GetClientExtensions(){} // RVA: 0x7FFE89F73BC0
        public void get_MinimumVersion(){} // RVA: 0x7FFE89F743B0
        public void NotifyServerVersion(){} // RVA: 0x7FFE89F74410
        public void GetCipherSuites(){} // RVA: 0x7FFE80E2E2E0
        public void GetCompressionMethods(){} // RVA: 0x7FFE89F744C0
        public void NotifySessionID(){} // RVA: 0x7FFE810FB310
        public void NotifySelectedCipherSuite(){} // RVA: 0x7FFE8119C090
        public void NotifySelectedCompressionMethod(){} // RVA: 0x7FFE89F74500
        public void ProcessServerExtensions(){} // RVA: 0x7FFE89F74510
        public void ProcessServerSupplementalData(){} // RVA: 0x7FFE89F74680
        public void GetKeyExchange(){} // RVA: 0x7FFE80E2E2E0
        public void GetAuthentication(){} // RVA: 0x7FFE80E2E2E0
        public void GetClientSupplementalData(){} // RVA: 0x7FFE813240E0
        public void GetCompression(){} // RVA: 0x7FFE89F746E0
        public void GetCipher(){} // RVA: 0x7FFE89F748F0
        public void NotifyNewSessionTicket(){} // RVA: 0x7FFE810FB310
    }

    public class AbstractTlsContext : Object
    {
        public long counter;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.IRandomGenerator mNonceRandom; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom mSecureRandom; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.SecurityParameters mSecurityParameters; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion mClientVersion; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion mServerVersion; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSession mSession; // 0x38
        public object mUserObject; // 0x40

        // ── Methods ──
        public void NextCounterValue(){} // RVA: 0x7FFE89F74990
        public void .ctor(){} // RVA: 0x7FFE89F749F0
        public void get_NonceRandomGenerator(){} // RVA: 0x7FFE81116380
        public void get_SecureRandom(){} // RVA: 0x7FFE810FE7C0
        public void get_SecurityParameters(){} // RVA: 0x7FFE811290C0
        public void get_IsServer(){} // RVA: 0x7FFE80E2F150
        public void get_ClientVersion(){} // RVA: 0x7FFE81129130
        public void SetClientVersion(){} // RVA: 0x7FFE810FCE90
        public void get_ServerVersion(){} // RVA: 0x7FFE8144E200
        public void SetServerVersion(){} // RVA: 0x7FFE81129890
        public void get_ResumableSession(){} // RVA: 0x7FFE8143BA80
        public void SetResumableSession(){} // RVA: 0x7FFE81437330
        public void get_UserObject(){} // RVA: 0x7FFE81178740
        public void set_UserObject(){} // RVA: 0x7FFE81123200
        public void ExportKeyingMaterial(){} // RVA: 0x7FFE89F74D20
        public void .cctor(){} // RVA: 0x7FFE89F75090
    }

    public class AbstractTlsCredentials : Object
    {
        // ── Methods ──
        public void get_Certificate(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AbstractTlsEncryptionCredentials : AbstractTlsCredentials
    {
        // ── Methods ──
        public void DecryptPreMasterSecret(){} // RVA: 0x7FFE80E2E390
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AbstractTlsKeyExchange : Object
    {
        public int mKeyExchange; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A53990
        public void ParseSignature(){} // RVA: 0x7FFE89F75100
        public void Init(){} // RVA: 0x7FFE89F751B0
        public void SkipServerCredentials(){} // RVA: 0x7FFE80E45FE0
        public void ProcessServerCertificate(){} // RVA: 0x7FFE810FB310
        public void ProcessServerCredentials(){} // RVA: 0x7FFE89F75610
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFE810FB320
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFE89F75680
        public void SkipServerKeyExchange(){} // RVA: 0x7FFE89F756F0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFE89F75760
        public void ValidateCertificateRequest(){} // RVA: 0x7FFE80E460A0
        public void SkipClientCredentials(){} // RVA: 0x7FFE810FB310
        public void ProcessClientCredentials(){} // RVA: 0x7FFE80E460A0
        public void ProcessClientCertificate(){} // RVA: 0x7FFE810FB310
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFE80E460A0
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFE89F757D0
        public void GeneratePremasterSecret(){} // RVA: 0x7FFE80E2E2E0
    }

    public class AbstractTlsPeer : Object
    {
        // ── Methods ──
        public void RequiresExtendedMasterSecret(){} // RVA: 0x7FFE810FB320
        public void ShouldUseGmtUnixTime(){} // RVA: 0x7FFE810FB320
        public void NotifySecureRenegotiation(){} // RVA: 0x7FFE89F75820
        public void GetCompression(){} // RVA: 0x7FFE80E2E2E0
        public void GetCipher(){} // RVA: 0x7FFE80E2E2E0
        public void NotifyAlertRaised(){} // RVA: 0x7FFE810FB310
        public void NotifyAlertReceived(){} // RVA: 0x7FFE810FB310
        public void NotifyHandshakeComplete(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AbstractTlsServer : AbstractTlsPeer
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCipherFactory mCipherFactory; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsServerContext mContext; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion mClientVersion; // 0x20
        public int[] mOfferedCipherSuites; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_AllowEncryptThenMac(){} // RVA: 0x7FFE811E0850
        public void get_AllowTruncatedHMac(){} // RVA: 0x7FFE810FB320
        public void CheckServerExtensions(){} // RVA: 0x7FFE89F75910
        public void GetCipherSuites(){} // RVA: 0x7FFE80E2E2E0
        public void GetCompressionMethods(){} // RVA: 0x7FFE89F75A10
        public void get_MaximumVersion(){} // RVA: 0x7FFE89F75A50
        public void get_MinimumVersion(){} // RVA: 0x7FFE89F75AB0
        public void SupportsClientEccCapabilities(){} // RVA: 0x7FFE89F75B10
        public void Init(){} // RVA: 0x7FFE81161E80
        public void NotifyClientVersion(){} // RVA: 0x7FFE811290D0
        public void NotifyFallback(){} // RVA: 0x7FFE89F75C50
        public void NotifyOfferedCipherSuites(){} // RVA: 0x7FFE89F75D00
        public void NotifyOfferedCompressionMethods(){} // RVA: 0x7FFE81129890
        public void ProcessClientExtensions(){} // RVA: 0x7FFE89F75DC0
        public void GetServerVersion(){} // RVA: 0x7FFE89F76290
        public void GetSelectedCipherSuite(){} // RVA: 0x7FFE89F76450
        public void GetSelectedCompressionMethod(){} // RVA: 0x7FFE89F76680
        public void GetServerExtensions(){} // RVA: 0x7FFE89F767D0
        public void GetServerSupplementalData(){} // RVA: 0x7FFE813240E0
        public void GetCredentials(){} // RVA: 0x7FFE80E2E2E0
        public void GetCertificateStatus(){} // RVA: 0x7FFE813240E0
        public void GetKeyExchange(){} // RVA: 0x7FFE80E2E2E0
        public void GetCertificateRequest(){} // RVA: 0x7FFE813240E0
        public void ProcessClientSupplementalData(){} // RVA: 0x7FFE89F76C90
        public void NotifyClientCertificate(){} // RVA: 0x7FFE89F76CF0
        public void GetCompression(){} // RVA: 0x7FFE89F76D40
        public void GetCipher(){} // RVA: 0x7FFE89F76DC0
        public void GetNewSessionTicket(){} // RVA: 0x7FFE89F76E60
    }

    public class AbstractTlsSigner : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE810FCE30
        public void GenerateRawSignature(){} // RVA: 0x7FFE80E403A0 | overloaded x2
        public void VerifyRawSignature(){} // RVA: 0x7FFE80E32AD0 | overloaded x2
        public void CreateSigner(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void CreateVerifyer(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void IsValidPublicKey(){} // RVA: 0x7FFE80E2F3B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AbstractTlsSignerCredentials : AbstractTlsCredentials
    {
        // ── Methods ──
        public void GenerateCertificateSignature(){} // RVA: 0x7FFE80E2E390
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x7FFE89F76FD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AlertDescription : Object
    {
        // ── Methods ──
        public void GetName(){} // RVA: 0x7FFE89F77020
        public void GetText(){} // RVA: 0x7FFE89F77510
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AlertLevel : Object
    {
        // ── Methods ──
        public void GetName(){} // RVA: 0x7FFE89F77590
        public void GetText(){} // RVA: 0x7FFE89F77610
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}