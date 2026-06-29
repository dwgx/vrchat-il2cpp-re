// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 13
// Methods: 121

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class AbstractTlsAgreementCredentials : AbstractTlsCredentials
    {
        // ── Methods ──
        public void GenerateAgreement(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AbstractTlsCipherFactory : Object
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0x7B13475F0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AbstractTlsClient : AbstractTlsPeer
    {
        // ── Methods ──
        public void get_HostNames(){} // RVA: 0x7A8152D80
        public void set_HostNames(){} // RVA: 0x7A8152D90
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void AllowUnexpectedServerExtension(){} // RVA: 0x7B13476D0
        public void CheckForUnexpectedServerExtension(){} // RVA: 0x7B1347770
        public void Init(){} // RVA: 0x7A813E420
        public void GetSessionToResume(){} // RVA: 0x7A82D1450
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0x7B1347840
        public void get_ClientVersion(){} // RVA: 0x7B1347860
        public void get_IsFallback(){} // RVA: 0x7A80D7320
        public void GetClientExtensions(){} // RVA: 0x7B13478C0
        public void get_MinimumVersion(){} // RVA: 0x7B1348150
        public void NotifyServerVersion(){} // RVA: 0x7B13481B0
        public void GetCipherSuites(){} // RVA: 0x7A7E00680
        public void GetCompressionMethods(){} // RVA: 0x7B1348260
        public void NotifySessionID(){} // RVA: 0x7A80D7310
        public void NotifySelectedCipherSuite(){} // RVA: 0x7A8178B40
        public void NotifySelectedCompressionMethod(){} // RVA: 0x7B13482A0
        public void ProcessServerExtensions(){} // RVA: 0x7B13482B0
        public void ProcessServerSupplementalData(){} // RVA: 0x7B1348420
        public void GetKeyExchange(){} // RVA: 0x7A7E00680
        public void GetAuthentication(){} // RVA: 0x7A7E00680
        public void GetClientSupplementalData(){} // RVA: 0x7A82D1450
        public void GetCompression(){} // RVA: 0x7B1348480
        public void GetCipher(){} // RVA: 0x7B1348690
        public void NotifyNewSessionTicket(){} // RVA: 0x7A80D7310
    }

    public class AbstractTlsContext : Object
    {
        // ── Methods ──
        public void NextCounterValue(){} // RVA: 0x7B1348730
        public void .ctor(){} // RVA: 0x7B1348790
        public void get_NonceRandomGenerator(){} // RVA: 0x7A80F2570
        public void get_SecureRandom(){} // RVA: 0x7A80DA7B0
        public void get_SecurityParameters(){} // RVA: 0x7A81052C0
        public void get_IsServer(){} // RVA: 0x7A7E01900
        public void get_ClientVersion(){} // RVA: 0x7A8105330
        public void SetClientVersion(){} // RVA: 0x7A80D8E80
        public void get_ServerVersion(){} // RVA: 0x7A83F69F0
        public void SetServerVersion(){} // RVA: 0x7A8105A90
        public void get_ResumableSession(){} // RVA: 0x7A8292C30
        public void SetResumableSession(){} // RVA: 0x7A8296DE0
        public void get_UserObject(){} // RVA: 0x7A8154D80
        public void set_UserObject(){} // RVA: 0x7A80FF440
        public void ExportKeyingMaterial(){} // RVA: 0x7B1348AC0
        public void .cctor(){} // RVA: 0x7B1348E30
    }

    public class AbstractTlsCredentials : Object
    {
        // ── Methods ──
        public void get_Certificate(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AbstractTlsEncryptionCredentials : AbstractTlsCredentials
    {
        // ── Methods ──
        public void DecryptPreMasterSecret(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AbstractTlsKeyExchange : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AC8120
        public void ParseSignature(){} // RVA: 0x7B1348EA0
        public void Init(){} // RVA: 0x7B1348F50
        public void SkipServerCredentials(){} // RVA: 0x7A7E18770
        public void ProcessServerCertificate(){} // RVA: 0x7A80D7310
        public void ProcessServerCredentials(){} // RVA: 0x7B13493B0
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7A80D7320
        public void GenerateServerKeyExchange(){} // RVA: 0x7B1349420
        public void SkipServerKeyExchange(){} // RVA: 0x7B1349490
        public void ProcessServerKeyExchange(){} // RVA: 0x7B1349500
        public void ValidateCertificateRequest(){} // RVA: 0x7A7E18800
        public void SkipClientCredentials(){} // RVA: 0x7A80D7310
        public void ProcessClientCredentials(){} // RVA: 0x7A7E18800
        public void ProcessClientCertificate(){} // RVA: 0x7A80D7310
        public void GenerateClientKeyExchange(){} // RVA: 0x7A7E18800
        public void ProcessClientKeyExchange(){} // RVA: 0x7B1349570
        public void GeneratePremasterSecret(){} // RVA: 0x7A7E00680
    }

    public class AbstractTlsPeer : Object
    {
        // ── Methods ──
        public void RequiresExtendedMasterSecret(){} // RVA: 0x7A80D7320
        public void ShouldUseGmtUnixTime(){} // RVA: 0x7A80D7320
        public void NotifySecureRenegotiation(){} // RVA: 0x7B13495C0
        public void GetCompression(){} // RVA: 0x7A7E00680
        public void GetCipher(){} // RVA: 0x7A7E00680
        public void NotifyAlertRaised(){} // RVA: 0x7A80D7310
        public void NotifyAlertReceived(){} // RVA: 0x7A80D7310
        public void NotifyHandshakeComplete(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AbstractTlsServer : AbstractTlsPeer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_AllowEncryptThenMac(){} // RVA: 0x7A81BD750
        public void get_AllowTruncatedHMac(){} // RVA: 0x7A80D7320
        public void CheckServerExtensions(){} // RVA: 0x7B13496B0
        public void GetCipherSuites(){} // RVA: 0x7A7E00680
        public void GetCompressionMethods(){} // RVA: 0x7B13497B0
        public void get_MaximumVersion(){} // RVA: 0x7B13497F0
        public void get_MinimumVersion(){} // RVA: 0x7B1349850
        public void SupportsClientEccCapabilities(){} // RVA: 0x7B13498B0
        public void Init(){} // RVA: 0x7A813E420
        public void NotifyClientVersion(){} // RVA: 0x7A81052D0
        public void NotifyFallback(){} // RVA: 0x7B1349A00
        public void NotifyOfferedCipherSuites(){} // RVA: 0x7B1349AC0
        public void NotifyOfferedCompressionMethods(){} // RVA: 0x7A8105A90
        public void ProcessClientExtensions(){} // RVA: 0x7B1349B80
        public void GetServerVersion(){} // RVA: 0x7B134A040
        public void GetSelectedCipherSuite(){} // RVA: 0x7B134A210
        public void GetSelectedCompressionMethod(){} // RVA: 0x7B134A440
        public void GetServerExtensions(){} // RVA: 0x7B134A590
        public void GetServerSupplementalData(){} // RVA: 0x7A82D1450
        public void GetCredentials(){} // RVA: 0x7A7E00680
        public void GetCertificateStatus(){} // RVA: 0x7A82D1450
        public void GetKeyExchange(){} // RVA: 0x7A7E00680
        public void GetCertificateRequest(){} // RVA: 0x7A82D1450
        public void ProcessClientSupplementalData(){} // RVA: 0x7B134AA50
        public void NotifyClientCertificate(){} // RVA: 0x7B134AAB0
        public void GetCompression(){} // RVA: 0x7B134AB00
        public void GetCipher(){} // RVA: 0x7B134AB80
        public void GetNewSessionTicket(){} // RVA: 0x7B134AC20
    }

    public class AbstractTlsSigner : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A80D8E20
        public void GenerateRawSignature(){} // RVA: 0x7A7E06710
        public void VerifyRawSignature(){} // RVA: 0x7A7E01DE0
        public void CreateSigner(){} // RVA: 0x7A7E00BD0
        public void CreateVerifyer(){} // RVA: 0x7A7E00BD0
        public void IsValidPublicKey(){} // RVA: 0x7A7E019D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AbstractTlsSignerCredentials : AbstractTlsCredentials
    {
        // ── Methods ──
        public void GenerateCertificateSignature(){} // RVA: 0x7A7E00B20
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x7B134AD90
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AlertDescription : Object
    {
        // ── Methods ──
        public void GetName(){} // RVA: 0x7B134ADE0
        public void GetText(){} // RVA: 0x7B134B2E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AlertLevel : Object
    {
        // ── Methods ──
        public void GetName(){} // RVA: 0x7B134B360
        public void GetText(){} // RVA: 0x7B134B3E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}