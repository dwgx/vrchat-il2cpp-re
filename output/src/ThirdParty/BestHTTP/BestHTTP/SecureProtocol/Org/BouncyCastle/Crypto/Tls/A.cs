// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 13
// Methods: 127

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class AbstractTlsAgreementCredentials
    {
        // ── Methods ──
        public void GenerateAgreement(){} // RVA: 0xCE10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AbstractTlsCipherFactory
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0x9511520
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AbstractTlsClient
    {
        // ── Methods ──
        public void get_HostNames(){} // RVA: 0x358730
        public void set_HostNames(){} // RVA: 0x358740
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void AllowUnexpectedServerExtension(){} // RVA: 0x9511600
        public void CheckForUnexpectedServerExtension(){} // RVA: 0x95116A0
        public void Init(){} // RVA: 0x343E80
        public void GetSessionToResume(){} // RVA: 0x519240
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0x9511770
        public void get_ClientVersion(){} // RVA: 0x9511790
        public void get_IsFallback(){} // RVA: 0x2DD320
        public void GetClientExtensions(){} // RVA: 0x95117F0
        public void get_MinimumVersion(){} // RVA: 0x9511FE0
        public void NotifyServerVersion(){} // RVA: 0x9512040
        public void GetCipherSuites(){} // RVA: 0xCD60
        public void GetCompressionMethods(){} // RVA: 0x95120F0
        public void NotifySessionID(){} // RVA: 0x2DD310
        public void NotifySelectedCipherSuite(){} // RVA: 0x37E090
        public void NotifySelectedCompressionMethod(){} // RVA: 0x9512130
        public void ProcessServerExtensions(){} // RVA: 0x9512140
        public void ProcessServerSupplementalData(){} // RVA: 0x95122B0
        public void GetKeyExchange(){} // RVA: 0xCD60
        public void GetAuthentication(){} // RVA: 0xCD60
        public void GetClientSupplementalData(){} // RVA: 0x519240
        public void GetCompression(){} // RVA: 0x9512310
        public void GetCipher(){} // RVA: 0x9512520
        public void NotifyNewSessionTicket(){} // RVA: 0x2DD310
    }

    public class AbstractTlsContext
    {
        // ── Methods ──
        public void NextCounterValue(){} // RVA: 0x95125C0
        public void .ctor(){} // RVA: 0x9512620
        public void get_NonceRandomGenerator(){} // RVA: 0x2F8380
        public void get_SecureRandom(){} // RVA: 0x2E07C0
        public void get_SecurityParameters(){} // RVA: 0x30B0C0
        public void get_IsServer(){} // RVA: 0xDBE0
        public void get_ClientVersion(){} // RVA: 0x30B130
        public void SetClientVersion(){} // RVA: 0x2DEE90
        public void get_ServerVersion(){} // RVA: 0x6374D0
        public void SetServerVersion(){} // RVA: 0x30B890
        public void get_ResumableSession(){} // RVA: 0x4976A0
        public void SetResumableSession(){} // RVA: 0x49B830
        public void get_UserObject(){} // RVA: 0x35A740
        public void set_UserObject(){} // RVA: 0x305200
        public void ExportKeyingMaterial(){} // RVA: 0x9512950
        public void .cctor(){} // RVA: 0x9512CC0
    }

    public class AbstractTlsCredentials
    {
        // ── Methods ──
        public void get_Certificate(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AbstractTlsEncryptionCredentials
    {
        // ── Methods ──
        public void DecryptPreMasterSecret(){} // RVA: 0xCE10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AbstractTlsKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5AF0
        public void ParseSignature(){} // RVA: 0x9512D30
        public void Init(){} // RVA: 0x9512DE0
        public void SkipServerCredentials(){} // RVA: 0x24A50
        public void ProcessServerCertificate(){} // RVA: 0x2DD310
        public void ProcessServerCredentials(){} // RVA: 0x9513240
        public void get_RequiresServerKeyExchange(){} // RVA: 0x2DD320
        public void GenerateServerKeyExchange(){} // RVA: 0x95132B0
        public void SkipServerKeyExchange(){} // RVA: 0x9513320
        public void ProcessServerKeyExchange(){} // RVA: 0x9513390
        public void ValidateCertificateRequest(){} // RVA: 0x24B10
        public void SkipClientCredentials(){} // RVA: 0x2DD310
        public void ProcessClientCredentials(){} // RVA: 0x24B10
        public void ProcessClientCertificate(){} // RVA: 0x2DD310
        public void GenerateClientKeyExchange(){} // RVA: 0x24B10
        public void ProcessClientKeyExchange(){} // RVA: 0x9513400
        public void GeneratePremasterSecret(){} // RVA: 0xCD60
    }

    public class AbstractTlsPeer
    {
        // ── Methods ──
        public void RequiresExtendedMasterSecret(){} // RVA: 0x2DD320
        public void ShouldUseGmtUnixTime(){} // RVA: 0x2DD320
        public void NotifySecureRenegotiation(){} // RVA: 0x9513450
        public void GetCompression(){} // RVA: 0xCD60
        public void GetCipher(){} // RVA: 0xCD60
        public void NotifyAlertRaised(){} // RVA: 0x2DD310
        public void NotifyAlertReceived(){} // RVA: 0x2DD310
        public void NotifyHandshakeComplete(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AbstractTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_AllowEncryptThenMac(){} // RVA: 0x3C2850
        public void get_AllowTruncatedHMac(){} // RVA: 0x2DD320
        public void CheckServerExtensions(){} // RVA: 0x9513540
        public void GetCipherSuites(){} // RVA: 0xCD60
        public void GetCompressionMethods(){} // RVA: 0x9513640
        public void get_MaximumVersion(){} // RVA: 0x9513680
        public void get_MinimumVersion(){} // RVA: 0x95136E0
        public void SupportsClientEccCapabilities(){} // RVA: 0x9513740
        public void Init(){} // RVA: 0x343E80
        public void NotifyClientVersion(){} // RVA: 0x30B0D0
        public void NotifyFallback(){} // RVA: 0x9513880
        public void NotifyOfferedCipherSuites(){} // RVA: 0x9513930
        public void NotifyOfferedCompressionMethods(){} // RVA: 0x30B890
        public void ProcessClientExtensions(){} // RVA: 0x95139F0
        public void GetServerVersion(){} // RVA: 0x9513EC0
        public void GetSelectedCipherSuite(){} // RVA: 0x9514080
        public void GetSelectedCompressionMethod(){} // RVA: 0x95142B0
        public void GetServerExtensions(){} // RVA: 0x9514400
        public void GetServerSupplementalData(){} // RVA: 0x519240
        public void GetCredentials(){} // RVA: 0xCD60
        public void GetCertificateStatus(){} // RVA: 0x519240
        public void GetKeyExchange(){} // RVA: 0xCD60
        public void GetCertificateRequest(){} // RVA: 0x519240
        public void ProcessClientSupplementalData(){} // RVA: 0x95148C0
        public void NotifyClientCertificate(){} // RVA: 0x9514920
        public void GetCompression(){} // RVA: 0x9514970
        public void GetCipher(){} // RVA: 0x95149F0
        public void GetNewSessionTicket(){} // RVA: 0x9514A90
    }

    public class AbstractTlsSigner
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x2DEE30
        public void GenerateRawSignature(){} // RVA: 0x1EE30 | overloaded x2
        public void VerifyRawSignature(){} // RVA: 0x115A0 | overloaded x2
        public void CreateSigner(){} // RVA: 0x1E6A0 | overloaded x2
        public void CreateVerifyer(){} // RVA: 0x1E6A0 | overloaded x2
        public void IsValidPublicKey(){} // RVA: 0xDE40
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AbstractTlsSignerCredentials
    {
        // ── Methods ──
        public void GenerateCertificateSignature(){} // RVA: 0xCE10
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x9514C00
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AlertDescription
    {
        // ── Methods ──
        public void GetName(){} // RVA: 0x9514C50
        public void GetText(){} // RVA: 0x9515140
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AlertLevel
    {
        // ── Methods ──
        public void GetName(){} // RVA: 0x95151C0
        public void GetText(){} // RVA: 0x9515240
        public void .ctor(){} // RVA: 0x2DD310
    }

}