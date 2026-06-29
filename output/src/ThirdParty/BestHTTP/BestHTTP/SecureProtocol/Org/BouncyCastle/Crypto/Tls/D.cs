// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 22
// Methods: 207

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class DatagramTransport
    {
        // ── Methods ──
        public void GetReceiveLimit(){} // RVA: 0x7A7E00710
        public void GetSendLimit(){} // RVA: 0x7A7E00710
        public void Receive(){} // RVA: 0x7A7E09B00
        public void Send(){} // RVA: 0x7A7E1E220
        public void Close(){} // RVA: 0x7A7E18770
    }

    public class DefaultTlsAgreementCredentials : AbstractTlsAgreementCredentials
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1351DB0
        public void get_Certificate(){} // RVA: 0x7A80F2570
        public void GenerateAgreement(){} // RVA: 0x7B13520F0
    }

    public class DefaultTlsCipherFactory : AbstractTlsCipherFactory
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0x7B13521B0
        public void CreateAESCipher(){} // RVA: 0x7B1352510
        public void CreateCamelliaCipher(){} // RVA: 0x7B1352620
        public void CreateChaCha20Poly1305(){} // RVA: 0x7B1352730
        public void CreateCipher_Aes_Ccm(){} // RVA: 0x7B1352790
        public void CreateCipher_Aes_Gcm(){} // RVA: 0x7B1352860
        public void CreateCipher_Aes_Ocb(){} // RVA: 0x7B1352930
        public void CreateCipher_Camellia_Gcm(){} // RVA: 0x7B1352A00
        public void CreateDesEdeCipher(){} // RVA: 0x7B1352AD0
        public void CreateNullCipher(){} // RVA: 0x7B1352BE0
        public void CreateRC4Cipher(){} // RVA: 0x7B1352CA0
        public void CreateSeedCipher(){} // RVA: 0x7B1352DC0
        public void CreateAesEngine(){} // RVA: 0x7B1352ED0
        public void CreateCamelliaEngine(){} // RVA: 0x7B1352F10
        public void CreateAesBlockCipher(){} // RVA: 0x7B1352F60
        public void CreateAeadBlockCipher_Aes_Ccm(){} // RVA: 0x7B1352FE0
        public void CreateAeadBlockCipher_Aes_Gcm(){} // RVA: 0x7B1353060
        public void CreateAeadBlockCipher_Aes_Ocb(){} // RVA: 0x7B13530E0
        public void CreateAeadBlockCipher_Camellia_Gcm(){} // RVA: 0x7B1353180
        public void CreateCamelliaBlockCipher(){} // RVA: 0x7B1353200
        public void CreateDesEdeBlockCipher(){} // RVA: 0x7B1353280
        public void CreateRC4StreamCipher(){} // RVA: 0x7B1353330
        public void CreateSeedBlockCipher(){} // RVA: 0x7B1353370
        public void CreateHMacDigest(){} // RVA: 0x7B13533F0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DefaultTlsClient : AbstractTlsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13537A0
        public void GetCipherSuites(){} // RVA: 0x7B1353850
        public void GetKeyExchange(){} // RVA: 0x7B13538C0
        public void CreateDHKeyExchange(){} // RVA: 0x7B1353A80
        public void CreateDheKeyExchange(){} // RVA: 0x7B1353B10
        public void CreateECDHKeyExchange(){} // RVA: 0x7B1353BA0
        public void CreateECDheKeyExchange(){} // RVA: 0x7B1353C40
        public void CreateRsaKeyExchange(){} // RVA: 0x7B1353CE0
    }

    public class DefaultTlsDHVerifier : Object
    {
        // ── Methods ──
        public void AddDefaultGroup(){} // RVA: 0x7B1353D80
        public void .cctor(){} // RVA: 0x7B1353E10
        public void .ctor(){} // RVA: 0x7A9B6A000
        public void Accept(){} // RVA: 0x7B1354700
        public void get_MinimumPrimeBits(){} // RVA: 0x7A83782A0
        public void AreGroupsEqual(){} // RVA: 0x7B1354760
        public void AreParametersEqual(){} // RVA: 0x7B1354800
        public void CheckGroup(){} // RVA: 0x7B1354840
        public void CheckMinimumPrimeBits(){} // RVA: 0x7B1354A30
    }

    public class DefaultTlsEncryptionCredentials : AbstractTlsEncryptionCredentials
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1354A90
        public void get_Certificate(){} // RVA: 0x7A80DA7B0
        public void DecryptPreMasterSecret(){} // RVA: 0x7B1354D50
    }

    public class DefaultTlsServer : AbstractTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetDsaSignerCredentials(){} // RVA: 0x7B1354DE0
        public void GetECDsaSignerCredentials(){} // RVA: 0x7B1354E30
        public void GetRsaEncryptionCredentials(){} // RVA: 0x7B1354E80
        public void GetRsaSignerCredentials(){} // RVA: 0x7B1354ED0
        public void GetDHParameters(){} // RVA: 0x7B1354F20
        public void GetCipherSuites(){} // RVA: 0x7B1354F80
        public void GetCredentials(){} // RVA: 0x7B1354FF0
        public void GetKeyExchange(){} // RVA: 0x7B1355160
        public void CreateDHKeyExchange(){} // RVA: 0x7B1355320
        public void CreateDheKeyExchange(){} // RVA: 0x7B13553C0
        public void CreateECDHKeyExchange(){} // RVA: 0x7B1355460
        public void CreateECDheKeyExchange(){} // RVA: 0x7B1355500
        public void CreateRsaKeyExchange(){} // RVA: 0x7B13555A0
    }

    public class DefaultTlsSignerCredentials : AbstractTlsSignerCredentials
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1355660
        public void get_Certificate(){} // RVA: 0x7A80DA7B0
        public void GenerateCertificateSignature(){} // RVA: 0x7B1355AE0
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x7A8105330
    }

    public class DefaultTlsSrpGroupVerifier : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B1355CF0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Accept(){} // RVA: 0x7B1356080
        public void AreGroupsEqual(){} // RVA: 0x7B1356250
        public void AreParametersEqual(){} // RVA: 0x7B1354800
    }

    public class DeferredHash : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1356480
        public void Init(){} // RVA: 0x7A80D8E20
        public void NotifyPrfDetermined(){} // RVA: 0x7B1356650
        public void TrackHashAlgorithm(){} // RVA: 0x7B13567A0
        public void SealHashAlgorithms(){} // RVA: 0x7B1356820
        public void StopTracking(){} // RVA: 0x7B1356840
        public void ForkPrfHash(){} // RVA: 0x7B1356B40
        public void GetFinalHash(){} // RVA: 0x7B1356CC0
        public void get_AlgorithmName(){} // RVA: 0x7B1356EA0
        public void GetByteLength(){} // RVA: 0x7B1356EF0
        public void GetDigestSize(){} // RVA: 0x7B1356F40
        public void Update(){} // RVA: 0x7B1356F90
        public void BlockUpdate(){} // RVA: 0x7B13572C0
        public void DoFinal(){} // RVA: 0x7B1357610
        public void Reset(){} // RVA: 0x7B1357660
        public void CheckStopBuffering(){} // RVA: 0x7B1357970
        public void CheckTrackingHash(){} // RVA: 0x7B1357C70
    }

    public class DigestInputBuffer : MemoryStream
    {
        // ── Methods ──
        public void UpdateDigest(){} // RVA: 0x7B1357D90
        public void .ctor(){} // RVA: 0x7B1357E90
    }

    public class DigitallySigned : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1358030
        public void get_Algorithm(){} // RVA: 0x7A80F2570
        public void get_Signature(){} // RVA: 0x7A80DA7B0
        public void Encode(){} // RVA: 0x7B1358140
        public void Parse(){} // RVA: 0x7B13581D0
    }

    public class DtlsClientProtocol : DtlsProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13582A0
        public void Connect(){} // RVA: 0x7B1358350
        public void AbortClientHandshake(){} // RVA: 0x7B1358910
        public void ClientHandshake(){} // RVA: 0x7B1358970
        public void GenerateCertificateVerify(){} // RVA: 0x7B1359980
        public void GenerateClientHello(){} // RVA: 0x7B1359A20
        public void GenerateClientKeyExchange(){} // RVA: 0x7B135A2C0
        public void InvalidateSession(){} // RVA: 0x7B135A370
        public void ProcessCertificateRequest(){} // RVA: 0x7B135A4A0
        public void ProcessCertificateStatus(){} // RVA: 0x7B135A650
        public void ProcessHelloVerifyRequest(){} // RVA: 0x7B135A7E0
        public void ProcessNewSessionTicket(){} // RVA: 0x7B135AAA0
        public void ProcessServerCertificate(){} // RVA: 0x7B135ABC0
        public void ProcessServerHello(){} // RVA: 0x7B135ADD0
        public void ProcessServerKeyExchange(){} // RVA: 0x7B135B990
        public void ProcessServerSupplementalData(){} // RVA: 0x7B135BAC0
        public void ReportServerVersion(){} // RVA: 0x7B135BB70
        public void PatchClientHelloWithCookie(){} // RVA: 0x7B135BC70
    }

    public class DtlsEpoch : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B135BDC0
        public void AllocateSequenceNumber(){} // RVA: 0x7B135BF80
        public void get_Cipher(){} // RVA: 0x7A81052C0
        public void get_Epoch(){} // RVA: 0x7A83782A0
        public void get_ReplayWindow(){} // RVA: 0x7A80F2570
        public void get_SequenceNumber(){} // RVA: 0x7B135C0F0
    }

    public class DtlsHandshakeRetransmit
    {
        // ── Methods ──
        public void ReceivedHandshakeRecord(){} // RVA: 0x7A7E1BAC0
    }

    public class DtlsProtocol : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13582A0
        public void ProcessFinished(){} // RVA: 0x7B135C1F0
        public void ApplyMaxFragmentLengthExtension(){} // RVA: 0x7B135C3F0
        public void EvaluateMaxFragmentLengthExtension(){} // RVA: 0x7B135C490
        public void GenerateCertificate(){} // RVA: 0x7B135C540
        public void GenerateSupplementalData(){} // RVA: 0x7B135C5E0
        public void ValidateSelectedCipherSuite(){} // RVA: 0x7B135C670
    }

    public class DtlsReassembler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B135C710
        public void get_MsgType(){} // RVA: 0x7A81A2200
        public void GetBodyIfComplete(){} // RVA: 0x7B135C8E0
        public void ContributeFragment(){} // RVA: 0x7B135C940
        public void Reset(){} // RVA: 0x7B135CC80
    }

    public class DtlsRecordLayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B135CD30
        public void SetPlaintextLimit(){} // RVA: 0x7B135D0B0
        public void get_ReadEpoch(){} // RVA: 0x7B135D0C0
        public void get_ReadVersion(){} // RVA: 0x7B135D0E0
        public void set_ReadVersion(){} // RVA: 0x7B135D0F0
        public void SetWriteVersion(){} // RVA: 0x7AE2057F0
        public void InitPendingEpoch(){} // RVA: 0x7B135D150
        public void HandshakeSuccessful(){} // RVA: 0x7B135D260
        public void ResetWriteEpoch(){} // RVA: 0x7B135D3F0
        public void GetReceiveLimit(){} // RVA: 0x7B135D4C0
        public void GetSendLimit(){} // RVA: 0x7B135D590
        public void Receive(){} // RVA: 0x7B135D670
        public void Send(){} // RVA: 0x7B135E090
        public void Close(){} // RVA: 0x7B135E280
        public void Failed(){} // RVA: 0x7B135E300
        public void Fail(){} // RVA: 0x7B135E330
        public void Warn(){} // RVA: 0x7B135E390
        public void CloseTransport(){} // RVA: 0x7B135E3C0
        public void RaiseAlert(){} // RVA: 0x7B135E460
        public void ReceiveRecord(){} // RVA: 0x7B135E550
        public void SendRecord(){} // RVA: 0x7B135E820
        public void GetMacSequenceNumber(){} // RVA: 0x7B135EB70
    }

    public class DtlsReliableHandshake : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B135EB80
        public void NotifyHelloComplete(){} // RVA: 0x7B135EE30
        public void get_HandshakeHash(){} // RVA: 0x7A80DA7B0
        public void PrepareToFinish(){} // RVA: 0x7B135EED0
        public void SendMessage(){} // RVA: 0x7B135EF80
        public void ReceiveMessageBody(){} // RVA: 0x7B135F110
        public void ReceiveMessage(){} // RVA: 0x7B135F180
        public void Finish(){} // RVA: 0x7B135F410
        public void ResetHandshakeMessagesDigest(){} // RVA: 0x7B135F4F0
        public void BackOff(){} // RVA: 0x7B135F540
        public void CheckInboundFlight(){} // RVA: 0x7B135F5A0
        public void GetPendingMessage(){} // RVA: 0x7B135F790
        public void PrepareInboundFlight(){} // RVA: 0x7B135F9A0
        public void ProcessRecord(){} // RVA: 0x7B135FA80
        public void ResendOutboundFlight(){} // RVA: 0x7B135FF80
        public void UpdateHandshakeMessagesDigest(){} // RVA: 0x7B13601B0
        public void WriteMessage(){} // RVA: 0x7B13603B0
        public void WriteHandshakeFragment(){} // RVA: 0x7B1360500
        public void CheckAll(){} // RVA: 0x7B13607E0
        public void ResetAll(){} // RVA: 0x7B1360A30
    }

    public class DtlsReplayWindow : Object
    {
        // ── Methods ──
        public void ShouldDiscard(){} // RVA: 0x7B1360EB0
        public void ReportAuthenticated(){} // RVA: 0x7B1360F00
        public void Reset(){} // RVA: 0x7B1360FF0
        public void .ctor(){} // RVA: 0x7B1361010
    }

    public class DtlsServerProtocol : DtlsProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1361020
        public void get_VerifyRequests(){} // RVA: 0x7A80F26D0
        public void set_VerifyRequests(){} // RVA: 0x7A80F26E0
        public void Accept(){} // RVA: 0x7B13610E0
        public void AbortServerHandshake(){} // RVA: 0x7B1361620
        public void ServerHandshake(){} // RVA: 0x7B1361680
        public void InvalidateSession(){} // RVA: 0x7B1362220
        public void GenerateCertificateRequest(){} // RVA: 0x7B1362350
        public void GenerateCertificateStatus(){} // RVA: 0x7B13623F0
        public void GenerateNewSessionTicket(){} // RVA: 0x7B1362490
        public void GenerateServerHello(){} // RVA: 0x7B1362530
        public void NotifyClientCertificate(){} // RVA: 0x7B1362DB0
        public void ProcessClientCertificate(){} // RVA: 0x7B1362FD0
        public void ProcessCertificateVerify(){} // RVA: 0x7B1363120
        public void ProcessClientHello(){} // RVA: 0x7B1363580
        public void ProcessClientKeyExchange(){} // RVA: 0x7B1363BF0
        public void ProcessClientSupplementalData(){} // RVA: 0x7B1363D20
        public void ExpectCertificateVerifyMessage(){} // RVA: 0x7B1363DD0
    }

    public class DtlsTransport : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetReceiveLimit(){} // RVA: 0x7A858AA20
        public void GetSendLimit(){} // RVA: 0x7A858AC40
        public void Receive(){} // RVA: 0x7B1363E60
        public void Send(){} // RVA: 0x7B1363FE0
        public void Close(){} // RVA: 0x7AE1E3E00
    }

}