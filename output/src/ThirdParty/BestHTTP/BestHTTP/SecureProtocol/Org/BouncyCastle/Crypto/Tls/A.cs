// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 13
// Methods: 127

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class AbstractTlsAgreementCredentials
    {
        // ── Methods ──
        public void GenerateAgreement(){} // RVA: 0x7FFAF2ABCE10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AbstractTlsCipherFactory
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0x7FFAFBFC1520
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AbstractTlsClient
    {
        // ── Methods ──
        public void get_HostNames(){} // RVA: 0x7FFAF2E08730
        public void set_HostNames(){} // RVA: 0x7FFAF2E08740
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void AllowUnexpectedServerExtension(){} // RVA: 0x7FFAFBFC1600
        public void CheckForUnexpectedServerExtension(){} // RVA: 0x7FFAFBFC16A0
        public void Init(){} // RVA: 0x7FFAF2DF3E80
        public void GetSessionToResume(){} // RVA: 0x7FFAF2FC9240
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0x7FFAFBFC1770
        public void get_ClientVersion(){} // RVA: 0x7FFAFBFC1790
        public void get_IsFallback(){} // RVA: 0x7FFAF2D8D320
        public void GetClientExtensions(){} // RVA: 0x7FFAFBFC17F0
        public void get_MinimumVersion(){} // RVA: 0x7FFAFBFC1FE0
        public void NotifyServerVersion(){} // RVA: 0x7FFAFBFC2040
        public void GetCipherSuites(){} // RVA: 0x7FFAF2ABCD60
        public void GetCompressionMethods(){} // RVA: 0x7FFAFBFC20F0
        public void NotifySessionID(){} // RVA: 0x7FFAF2D8D310
        public void NotifySelectedCipherSuite(){} // RVA: 0x7FFAF2E2E090
        public void NotifySelectedCompressionMethod(){} // RVA: 0x7FFAFBFC2130
        public void ProcessServerExtensions(){} // RVA: 0x7FFAFBFC2140
        public void ProcessServerSupplementalData(){} // RVA: 0x7FFAFBFC22B0
        public void GetKeyExchange(){} // RVA: 0x7FFAF2ABCD60
        public void GetAuthentication(){} // RVA: 0x7FFAF2ABCD60
        public void GetClientSupplementalData(){} // RVA: 0x7FFAF2FC9240
        public void GetCompression(){} // RVA: 0x7FFAFBFC2310
        public void GetCipher(){} // RVA: 0x7FFAFBFC2520
        public void NotifyNewSessionTicket(){} // RVA: 0x7FFAF2D8D310
    }

    public class AbstractTlsContext
    {
        // ── Methods ──
        public void NextCounterValue(){} // RVA: 0x7FFAFBFC25C0
        public void .ctor(){} // RVA: 0x7FFAFBFC2620
        public void get_NonceRandomGenerator(){} // RVA: 0x7FFAF2DA8380
        public void get_SecureRandom(){} // RVA: 0x7FFAF2D907C0
        public void get_SecurityParameters(){} // RVA: 0x7FFAF2DBB0C0
        public void get_IsServer(){} // RVA: 0x7FFAF2ABDBE0
        public void get_ClientVersion(){} // RVA: 0x7FFAF2DBB130
        public void SetClientVersion(){} // RVA: 0x7FFAF2D8EE90
        public void get_ServerVersion(){} // RVA: 0x7FFAF30E74D0
        public void SetServerVersion(){} // RVA: 0x7FFAF2DBB890
        public void get_ResumableSession(){} // RVA: 0x7FFAF2F476A0
        public void SetResumableSession(){} // RVA: 0x7FFAF2F4B830
        public void get_UserObject(){} // RVA: 0x7FFAF2E0A740
        public void set_UserObject(){} // RVA: 0x7FFAF2DB5200
        public void ExportKeyingMaterial(){} // RVA: 0x7FFAFBFC2950
        public void .cctor(){} // RVA: 0x7FFAFBFC2CC0
    }

    public class AbstractTlsCredentials
    {
        // ── Methods ──
        public void get_Certificate(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AbstractTlsEncryptionCredentials
    {
        // ── Methods ──
        public void DecryptPreMasterSecret(){} // RVA: 0x7FFAF2ABCE10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AbstractTlsKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4775AF0
        public void ParseSignature(){} // RVA: 0x7FFAFBFC2D30
        public void Init(){} // RVA: 0x7FFAFBFC2DE0
        public void SkipServerCredentials(){} // RVA: 0x7FFAF2AD4A50
        public void ProcessServerCertificate(){} // RVA: 0x7FFAF2D8D310
        public void ProcessServerCredentials(){} // RVA: 0x7FFAFBFC3240
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFAF2D8D320
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFAFBFC32B0
        public void SkipServerKeyExchange(){} // RVA: 0x7FFAFBFC3320
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFAFBFC3390
        public void ValidateCertificateRequest(){} // RVA: 0x7FFAF2AD4B10
        public void SkipClientCredentials(){} // RVA: 0x7FFAF2D8D310
        public void ProcessClientCredentials(){} // RVA: 0x7FFAF2AD4B10
        public void ProcessClientCertificate(){} // RVA: 0x7FFAF2D8D310
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFAF2AD4B10
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFAFBFC3400
        public void GeneratePremasterSecret(){} // RVA: 0x7FFAF2ABCD60
    }

    public class AbstractTlsPeer
    {
        // ── Methods ──
        public void RequiresExtendedMasterSecret(){} // RVA: 0x7FFAF2D8D320
        public void ShouldUseGmtUnixTime(){} // RVA: 0x7FFAF2D8D320
        public void NotifySecureRenegotiation(){} // RVA: 0x7FFAFBFC3450
        public void GetCompression(){} // RVA: 0x7FFAF2ABCD60
        public void GetCipher(){} // RVA: 0x7FFAF2ABCD60
        public void NotifyAlertRaised(){} // RVA: 0x7FFAF2D8D310
        public void NotifyAlertReceived(){} // RVA: 0x7FFAF2D8D310
        public void NotifyHandshakeComplete(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AbstractTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void get_AllowEncryptThenMac(){} // RVA: 0x7FFAF2E72850
        public void get_AllowTruncatedHMac(){} // RVA: 0x7FFAF2D8D320
        public void CheckServerExtensions(){} // RVA: 0x7FFAFBFC3540
        public void GetCipherSuites(){} // RVA: 0x7FFAF2ABCD60
        public void GetCompressionMethods(){} // RVA: 0x7FFAFBFC3640
        public void get_MaximumVersion(){} // RVA: 0x7FFAFBFC3680
        public void get_MinimumVersion(){} // RVA: 0x7FFAFBFC36E0
        public void SupportsClientEccCapabilities(){} // RVA: 0x7FFAFBFC3740
        public void Init(){} // RVA: 0x7FFAF2DF3E80
        public void NotifyClientVersion(){} // RVA: 0x7FFAF2DBB0D0
        public void NotifyFallback(){} // RVA: 0x7FFAFBFC3880
        public void NotifyOfferedCipherSuites(){} // RVA: 0x7FFAFBFC3930
        public void NotifyOfferedCompressionMethods(){} // RVA: 0x7FFAF2DBB890
        public void ProcessClientExtensions(){} // RVA: 0x7FFAFBFC39F0
        public void GetServerVersion(){} // RVA: 0x7FFAFBFC3EC0
        public void GetSelectedCipherSuite(){} // RVA: 0x7FFAFBFC4080
        public void GetSelectedCompressionMethod(){} // RVA: 0x7FFAFBFC42B0
        public void GetServerExtensions(){} // RVA: 0x7FFAFBFC4400
        public void GetServerSupplementalData(){} // RVA: 0x7FFAF2FC9240
        public void GetCredentials(){} // RVA: 0x7FFAF2ABCD60
        public void GetCertificateStatus(){} // RVA: 0x7FFAF2FC9240
        public void GetKeyExchange(){} // RVA: 0x7FFAF2ABCD60
        public void GetCertificateRequest(){} // RVA: 0x7FFAF2FC9240
        public void ProcessClientSupplementalData(){} // RVA: 0x7FFAFBFC48C0
        public void NotifyClientCertificate(){} // RVA: 0x7FFAFBFC4920
        public void GetCompression(){} // RVA: 0x7FFAFBFC4970
        public void GetCipher(){} // RVA: 0x7FFAFBFC49F0
        public void GetNewSessionTicket(){} // RVA: 0x7FFAFBFC4A90
    }

    public class AbstractTlsSigner
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF2D8EE30
        public void GenerateRawSignature(){} // RVA: 0x7FFAF2ACEE30 | overloaded x2
        public void VerifyRawSignature(){} // RVA: 0x7FFAF2AC15A0 | overloaded x2
        public void CreateSigner(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void CreateVerifyer(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void IsValidPublicKey(){} // RVA: 0x7FFAF2ABDE40
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AbstractTlsSignerCredentials
    {
        // ── Methods ──
        public void GenerateCertificateSignature(){} // RVA: 0x7FFAF2ABCE10
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x7FFAFBFC4C00
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AlertDescription
    {
        // ── Methods ──
        public void GetName(){} // RVA: 0x7FFAFBFC4C50
        public void GetText(){} // RVA: 0x7FFAFBFC5140
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AlertLevel
    {
        // ── Methods ──
        public void GetName(){} // RVA: 0x7FFAFBFC51C0
        public void GetText(){} // RVA: 0x7FFAFBFC5240
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}