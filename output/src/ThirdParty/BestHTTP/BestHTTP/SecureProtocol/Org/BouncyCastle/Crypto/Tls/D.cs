// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 22
// Methods: 215

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class DatagramTransport
    {
        // ── Methods ──
        public void GetReceiveLimit(){} // RVA: 0x7FFE80E2EDB0
        public void GetSendLimit(){} // RVA: 0x7FFE80E2EDB0
        public void Receive(){}
        public void Send(){}
        public void Close(){} // RVA: 0x7FFE80E45FE0
    }

    public class DefaultTlsAgreementCredentials : AbstractTlsAgreementCredentials
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate mCertificate; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F7DFC0
        public void get_Certificate(){} // RVA: 0x7FFE81116380
        public void GenerateAgreement(){} // RVA: 0x7FFE89F7E300
    }

    public class DefaultTlsCipherFactory : AbstractTlsCipherFactory
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0x7FFE89F7E3C0
        public void CreateAESCipher(){} // RVA: 0x7FFE89F7E720
        public void CreateCamelliaCipher(){} // RVA: 0x7FFE89F7E830
        public void CreateChaCha20Poly1305(){} // RVA: 0x7FFE89F7E940
        public void CreateCipher_Aes_Ccm(){} // RVA: 0x7FFE89F7E9A0
        public void CreateCipher_Aes_Gcm(){} // RVA: 0x7FFE89F7EA70
        public void CreateCipher_Aes_Ocb(){} // RVA: 0x7FFE89F7EB40
        public void CreateCipher_Camellia_Gcm(){} // RVA: 0x7FFE89F7EC10
        public void CreateDesEdeCipher(){} // RVA: 0x7FFE89F7ECE0
        public void CreateNullCipher(){} // RVA: 0x7FFE89F7EDF0
        public void CreateRC4Cipher(){} // RVA: 0x7FFE89F7EEB0
        public void CreateSeedCipher(){} // RVA: 0x7FFE89F7EFD0
        public void CreateAesEngine(){} // RVA: 0x7FFE89F7F0E0
        public void CreateCamelliaEngine(){} // RVA: 0x7FFE89F7F120
        public void CreateAesBlockCipher(){} // RVA: 0x7FFE89F7F170
        public void CreateAeadBlockCipher_Aes_Ccm(){} // RVA: 0x7FFE89F7F1F0
        public void CreateAeadBlockCipher_Aes_Gcm(){} // RVA: 0x7FFE89F7F270
        public void CreateAeadBlockCipher_Aes_Ocb(){} // RVA: 0x7FFE89F7F2F0
        public void CreateAeadBlockCipher_Camellia_Gcm(){} // RVA: 0x7FFE89F7F390
        public void CreateCamelliaBlockCipher(){} // RVA: 0x7FFE89F7F410
        public void CreateDesEdeBlockCipher(){} // RVA: 0x7FFE89F7F490
        public void CreateRC4StreamCipher(){} // RVA: 0x7FFE89F7F540
        public void CreateSeedBlockCipher(){} // RVA: 0x7FFE89F7F580
        public void CreateHMacDigest(){} // RVA: 0x7FFE89F7F600
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DefaultTlsClient : AbstractTlsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F7F9B0 | overloaded x3
        public void GetCipherSuites(){} // RVA: 0x7FFE89F7FA60
        public void GetKeyExchange(){} // RVA: 0x7FFE89F7FAD0
        public void CreateDHKeyExchange(){} // RVA: 0x7FFE89F7FC80
        public void CreateDheKeyExchange(){} // RVA: 0x7FFE89F7FD10
        public void CreateECDHKeyExchange(){} // RVA: 0x7FFE89F7FDA0
        public void CreateECDheKeyExchange(){} // RVA: 0x7FFE89F7FE40
        public void CreateRsaKeyExchange(){} // RVA: 0x7FFE89F7FEE0
    }

    public class DefaultTlsDHVerifier : Object
    {
        public int DefaultMinimumPrimeBits;

        // ── Methods ──
        public void AddDefaultGroup(){} // RVA: 0x7FFE89F7FF80
        public void .cctor(){} // RVA: 0x7FFE89F80010
        public void .ctor(){} // RVA: 0x7FFE82AF3A20 | overloaded x3
        public void Accept(){} // RVA: 0x7FFE89F80900
        public void get_MinimumPrimeBits(){} // RVA: 0x7FFE813DB630
        public void AreGroupsEqual(){} // RVA: 0x7FFE89F80960
        public void AreParametersEqual(){} // RVA: 0x7FFE89F80A00
        public void CheckGroup(){} // RVA: 0x7FFE89F80A40
        public void CheckMinimumPrimeBits(){} // RVA: 0x7FFE89F80C40
    }

    public class DefaultTlsEncryptionCredentials : AbstractTlsEncryptionCredentials
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext mContext; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F80CA0
        public void get_Certificate(){} // RVA: 0x7FFE810FE7C0
        public void DecryptPreMasterSecret(){} // RVA: 0x7FFE89F80F60
    }

    public class DefaultTlsServer : AbstractTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void GetDsaSignerCredentials(){} // RVA: 0x7FFE89F80FF0
        public void GetECDsaSignerCredentials(){} // RVA: 0x7FFE89F81040
        public void GetRsaEncryptionCredentials(){} // RVA: 0x7FFE89F81090
        public void GetRsaSignerCredentials(){} // RVA: 0x7FFE89F810E0
        public void GetDHParameters(){} // RVA: 0x7FFE89F81130
        public void GetCipherSuites(){} // RVA: 0x7FFE89F81190
        public void GetCredentials(){} // RVA: 0x7FFE89F81200
        public void GetKeyExchange(){} // RVA: 0x7FFE89F81370
        public void CreateDHKeyExchange(){} // RVA: 0x7FFE89F81520
        public void CreateDheKeyExchange(){} // RVA: 0x7FFE89F815C0
        public void CreateECDHKeyExchange(){} // RVA: 0x7FFE89F81660
        public void CreateECDheKeyExchange(){} // RVA: 0x7FFE89F81700
        public void CreateRsaKeyExchange(){} // RVA: 0x7FFE89F817A0
    }

    public class DefaultTlsSignerCredentials : AbstractTlsSignerCredentials
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext mContext; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate mCertificate; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F81860 | overloaded x2
        public void get_Certificate(){} // RVA: 0x7FFE810FE7C0
        public void GenerateCertificateSignature(){} // RVA: 0x7FFE89F81CE0
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x7FFE81129130
    }

    public class DefaultTlsSrpGroupVerifier : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE89F81EF0
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void Accept(){} // RVA: 0x7FFE89F82280
        public void AreGroupsEqual(){} // RVA: 0x7FFE89F82450
        public void AreParametersEqual(){} // RVA: 0x7FFE89F80A00
    }

    public class DeferredHash : Object
    {
        public int BUFFERING_HASH_LIMIT;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F82680 | overloaded x2
        public void Init(){} // RVA: 0x7FFE810FCE30
        public void NotifyPrfDetermined(){} // RVA: 0x7FFE89F82850
        public void TrackHashAlgorithm(){} // RVA: 0x7FFE89F829A0
        public void SealHashAlgorithms(){} // RVA: 0x7FFE89F82A20
        public void StopTracking(){} // RVA: 0x7FFE89F82A40
        public void ForkPrfHash(){} // RVA: 0x7FFE89F82BD0
        public void GetFinalHash(){} // RVA: 0x7FFE89F82D50
        public void get_AlgorithmName(){} // RVA: 0x7FFE89F82F30
        public void GetByteLength(){} // RVA: 0x7FFE89F82F80
        public void GetDigestSize(){} // RVA: 0x7FFE89F82FD0
        public void Update(){} // RVA: 0x7FFE89F83020
        public void BlockUpdate(){} // RVA: 0x7FFE89F83360
        public void DoFinal(){} // RVA: 0x7FFE89F836B0
        public void Reset(){} // RVA: 0x7FFE89F83700
        public void CheckStopBuffering(){} // RVA: 0x7FFE89F83A20
        public void CheckTrackingHash(){} // RVA: 0x7FFE89F83D30
    }

    public class DigestInputBuffer : MemoryStream
    {
        // ── Methods ──
        public void UpdateDigest(){} // RVA: 0x7FFE89F83E50
        public void .ctor(){} // RVA: 0x7FFE89F83F50
    }

    public class DigitallySigned : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm mAlgorithm; // 0x10
        public byte[] mSignature; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F840F0
        public void get_Algorithm(){} // RVA: 0x7FFE81116380
        public void get_Signature(){} // RVA: 0x7FFE810FE7C0
        public void Encode(){} // RVA: 0x7FFE89F84200
        public void Parse(){} // RVA: 0x7FFE89F84290
    }

    public class DtlsClientProtocol : DtlsProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F84360
        public void Connect(){} // RVA: 0x7FFE89F84410
        public void AbortClientHandshake(){} // RVA: 0x7FFE89F849D0
        public void ClientHandshake(){} // RVA: 0x7FFE89F84A30
        public void GenerateCertificateVerify(){} // RVA: 0x7FFE89F85A60
        public void GenerateClientHello(){} // RVA: 0x7FFE89F85B00
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFE89F86380
        public void InvalidateSession(){} // RVA: 0x7FFE89F86430
        public void ProcessCertificateRequest(){} // RVA: 0x7FFE89F86560
        public void ProcessCertificateStatus(){} // RVA: 0x7FFE89F86710
        public void ProcessHelloVerifyRequest(){} // RVA: 0x7FFE89F868A0
        public void ProcessNewSessionTicket(){} // RVA: 0x7FFE89F86B60
        public void ProcessServerCertificate(){} // RVA: 0x7FFE89F86C80
        public void ProcessServerHello(){} // RVA: 0x7FFE89F86E90
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFE89F87A40
        public void ProcessServerSupplementalData(){} // RVA: 0x7FFE89F87B70
        public void ReportServerVersion(){} // RVA: 0x7FFE89F87C20
        public void PatchClientHelloWithCookie(){} // RVA: 0x7FFE89F87D20
    }

    public class DtlsEpoch : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DtlsReplayWindow mReplayWindow; // 0x10
        public int mEpoch; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCipher mCipher; // 0x20
        public long mSequenceNumber; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F87E70
        public void AllocateSequenceNumber(){} // RVA: 0x7FFE89F88030
        public void get_Cipher(){} // RVA: 0x7FFE811290C0
        public void get_Epoch(){} // RVA: 0x7FFE813DB630
        public void get_ReplayWindow(){} // RVA: 0x7FFE81116380
        public void get_SequenceNumber(){} // RVA: 0x7FFE89F881D0
    }

    public class DtlsHandshakeRetransmit
    {
        // ── Methods ──
        public void ReceivedHandshakeRecord(){}
    }

    public class DtlsProtocol : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F84360
        public void ProcessFinished(){} // RVA: 0x7FFE89F88310
        public void ApplyMaxFragmentLengthExtension(){} // RVA: 0x7FFE89F88500
        public void EvaluateMaxFragmentLengthExtension(){} // RVA: 0x7FFE89F885A0
        public void GenerateCertificate(){} // RVA: 0x7FFE89F88650
        public void GenerateSupplementalData(){} // RVA: 0x7FFE89F886F0
        public void ValidateSelectedCipherSuite(){} // RVA: 0x7FFE89F88780
    }

    public class DtlsReassembler : Object
    {
        public byte mMsgType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F88820
        public void get_MsgType(){} // RVA: 0x7FFE811C55E0
        public void GetBodyIfComplete(){} // RVA: 0x7FFE89F889F0
        public void ContributeFragment(){} // RVA: 0x7FFE89F88A50
        public void Reset(){} // RVA: 0x7FFE89F88DA0
    }

    public class DtlsRecordLayer : Object
    {
        public int RECORD_HEADER_LENGTH;
        public int MAX_FRAGMENT_LENGTH;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F88E50
        public void SetPlaintextLimit(){} // RVA: 0x7FFE89F891D0
        public void get_ReadEpoch(){} // RVA: 0x7FFE89F891E0
        public void get_ReadVersion(){} // RVA: 0x7FFE89F89200
        public void set_ReadVersion(){} // RVA: 0x7FFE89F89210
        public void SetWriteVersion(){} // RVA: 0x7FFE86F58490
        public void InitPendingEpoch(){} // RVA: 0x7FFE89F89270
        public void HandshakeSuccessful(){} // RVA: 0x7FFE89F89380
        public void ResetWriteEpoch(){} // RVA: 0x7FFE89F89510
        public void GetReceiveLimit(){} // RVA: 0x7FFE89F895E0
        public void GetSendLimit(){} // RVA: 0x7FFE89F896B0
        public void Receive(){} // RVA: 0x7FFE89F89790
        public void Send(){} // RVA: 0x7FFE89F8A1B0
        public void Close(){} // RVA: 0x7FFE89F8A3A0
        public void Failed(){} // RVA: 0x7FFE89F8A420
        public void Fail(){} // RVA: 0x7FFE89F8A450
        public void Warn(){} // RVA: 0x7FFE89F8A4B0
        public void CloseTransport(){} // RVA: 0x7FFE89F8A4E0
        public void RaiseAlert(){} // RVA: 0x7FFE89F8A580
        public void ReceiveRecord(){} // RVA: 0x7FFE89F8A670
        public void SendRecord(){} // RVA: 0x7FFE89F8A950
        public void GetMacSequenceNumber(){} // RVA: 0x7FFE89F8ACA0
    }

    public class DtlsReliableHandshake : Object
    {
        public int MaxReceiveAhead;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F8ACB0
        public void NotifyHelloComplete(){} // RVA: 0x7FFE89F8AF40
        public void get_HandshakeHash(){} // RVA: 0x7FFE810FE7C0
        public void PrepareToFinish(){} // RVA: 0x7FFE89F8AFE0
        public void SendMessage(){} // RVA: 0x7FFE89F8B090
        public void ReceiveMessageBody(){} // RVA: 0x7FFE89F8B210
        public void ReceiveMessage(){} // RVA: 0x7FFE89F8B280
        public void Finish(){} // RVA: 0x7FFE89F8B510
        public void ResetHandshakeMessagesDigest(){} // RVA: 0x7FFE89F8B5F0
        public void BackOff(){} // RVA: 0x7FFE89F8B640
        public void CheckInboundFlight(){} // RVA: 0x7FFE89F8B6A0
        public void GetPendingMessage(){} // RVA: 0x7FFE89F8B8B0
        public void PrepareInboundFlight(){} // RVA: 0x7FFE89F8BAC0
        public void ProcessRecord(){} // RVA: 0x7FFE89F8BBA0
        public void ResendOutboundFlight(){} // RVA: 0x7FFE89F8C080
        public void UpdateHandshakeMessagesDigest(){} // RVA: 0x7FFE89F8C2B0
        public void WriteMessage(){} // RVA: 0x7FFE89F8C4B0
        public void WriteHandshakeFragment(){} // RVA: 0x7FFE89F8C5F0
        public void CheckAll(){} // RVA: 0x7FFE89F8C8D0
        public void ResetAll(){} // RVA: 0x7FFE89F8CB20
    }

    public class DtlsReplayWindow : Object
    {
        // ── Methods ──
        public void ShouldDiscard(){} // RVA: 0x7FFE89F8CFB0
        public void ReportAuthenticated(){} // RVA: 0x7FFE89F8D000
        public void Reset(){} // RVA: 0x7FFE89F8D0F0
        public void .ctor(){} // RVA: 0x7FFE89F8D110
    }

    public class DtlsServerProtocol : DtlsProtocol
    {
        public bool mVerifyRequests; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F8D120
        public void get_VerifyRequests(){} // RVA: 0x7FFE811164E0
        public void set_VerifyRequests(){} // RVA: 0x7FFE811164F0
        public void Accept(){} // RVA: 0x7FFE89F8D1D0
        public void AbortServerHandshake(){} // RVA: 0x7FFE89F8D700
        public void ServerHandshake(){} // RVA: 0x7FFE89F8D760
        public void InvalidateSession(){} // RVA: 0x7FFE89F8E300
        public void GenerateCertificateRequest(){} // RVA: 0x7FFE89F8E430
        public void GenerateCertificateStatus(){} // RVA: 0x7FFE89F8E4D0
        public void GenerateNewSessionTicket(){} // RVA: 0x7FFE89F8E570
        public void GenerateServerHello(){} // RVA: 0x7FFE89F8E610
        public void NotifyClientCertificate(){} // RVA: 0x7FFE89F8EE80
        public void ProcessClientCertificate(){} // RVA: 0x7FFE89F8F0A0
        public void ProcessCertificateVerify(){} // RVA: 0x7FFE89F8F1F0
        public void ProcessClientHello(){} // RVA: 0x7FFE89F8F650
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFE89F8FCA0
        public void ProcessClientSupplementalData(){} // RVA: 0x7FFE89F8FDD0
        public void ExpectCertificateVerifyMessage(){} // RVA: 0x7FFE89F8FE80
    }

    public class DtlsTransport : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetReceiveLimit(){} // RVA: 0x7FFE815889C0
        public void GetSendLimit(){} // RVA: 0x7FFE81588910
        public void Receive(){} // RVA: 0x7FFE89F8FF10
        public void Send(){} // RVA: 0x7FFE89F90090
        public void Close(){} // RVA: 0x7FFE86F36C70
    }

}