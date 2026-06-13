// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 22
// Methods: 215

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class DatagramTransport
    {
        // ── Methods ──
        public void GetReceiveLimit(){} // RVA: 0xD840
        public void GetSendLimit(){} // RVA: 0xD840
        public void Receive(){}
        public void Send(){}
        public void Close(){} // RVA: 0x24A50
    }

    public class DefaultTlsAgreementCredentials
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate mCertificate; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x951BBF0
        public void get_Certificate(){} // RVA: 0x2F8380
        public void GenerateAgreement(){} // RVA: 0x951BF30
    }

    public class DefaultTlsCipherFactory
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0x951BFF0
        public void CreateAESCipher(){} // RVA: 0x951C350
        public void CreateCamelliaCipher(){} // RVA: 0x951C460
        public void CreateChaCha20Poly1305(){} // RVA: 0x951C570
        public void CreateCipher_Aes_Ccm(){} // RVA: 0x951C5D0
        public void CreateCipher_Aes_Gcm(){} // RVA: 0x951C6A0
        public void CreateCipher_Aes_Ocb(){} // RVA: 0x951C770
        public void CreateCipher_Camellia_Gcm(){} // RVA: 0x951C840
        public void CreateDesEdeCipher(){} // RVA: 0x951C910
        public void CreateNullCipher(){} // RVA: 0x951CA20
        public void CreateRC4Cipher(){} // RVA: 0x951CAE0
        public void CreateSeedCipher(){} // RVA: 0x951CC00
        public void CreateAesEngine(){} // RVA: 0x951CD10
        public void CreateCamelliaEngine(){} // RVA: 0x951CD50
        public void CreateAesBlockCipher(){} // RVA: 0x951CDA0
        public void CreateAeadBlockCipher_Aes_Ccm(){} // RVA: 0x951CE20
        public void CreateAeadBlockCipher_Aes_Gcm(){} // RVA: 0x951CEA0
        public void CreateAeadBlockCipher_Aes_Ocb(){} // RVA: 0x951CF20
        public void CreateAeadBlockCipher_Camellia_Gcm(){} // RVA: 0x951CFC0
        public void CreateCamelliaBlockCipher(){} // RVA: 0x951D040
        public void CreateDesEdeBlockCipher(){} // RVA: 0x951D0C0
        public void CreateRC4StreamCipher(){} // RVA: 0x951D170
        public void CreateSeedBlockCipher(){} // RVA: 0x951D1B0
        public void CreateHMacDigest(){} // RVA: 0x951D230
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DefaultTlsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x951D5E0 | overloaded x3
        public void GetCipherSuites(){} // RVA: 0x951D690
        public void GetKeyExchange(){} // RVA: 0x951D700
        public void CreateDHKeyExchange(){} // RVA: 0x951D8B0
        public void CreateDheKeyExchange(){} // RVA: 0x951D940
        public void CreateECDHKeyExchange(){} // RVA: 0x951D9D0
        public void CreateECDheKeyExchange(){} // RVA: 0x951DA70
        public void CreateRsaKeyExchange(){} // RVA: 0x951DB10
    }

    public class DefaultTlsDHVerifier
    {
        public int DefaultMinimumPrimeBits;

        // ── Methods ──
        public void AddDefaultGroup(){} // RVA: 0x951DBB0
        public void .cctor(){} // RVA: 0x951DC40
        public void .ctor(){} // RVA: 0x1D66A50 | overloaded x3
        public void Accept(){} // RVA: 0x951E530
        public void get_MinimumPrimeBits(){} // RVA: 0x5BED50
        public void AreGroupsEqual(){} // RVA: 0x951E590
        public void AreParametersEqual(){} // RVA: 0x951E630
        public void CheckGroup(){} // RVA: 0x951E670
        public void CheckMinimumPrimeBits(){} // RVA: 0x951E870
    }

    public class DefaultTlsEncryptionCredentials
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext mContext; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x951E8D0
        public void get_Certificate(){} // RVA: 0x2E07C0
        public void DecryptPreMasterSecret(){} // RVA: 0x951EB90
    }

    public class DefaultTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void GetDsaSignerCredentials(){} // RVA: 0x951EC20
        public void GetECDsaSignerCredentials(){} // RVA: 0x951EC70
        public void GetRsaEncryptionCredentials(){} // RVA: 0x951ECC0
        public void GetRsaSignerCredentials(){} // RVA: 0x951ED10
        public void GetDHParameters(){} // RVA: 0x951ED60
        public void GetCipherSuites(){} // RVA: 0x951EDC0
        public void GetCredentials(){} // RVA: 0x951EE30
        public void GetKeyExchange(){} // RVA: 0x951EFA0
        public void CreateDHKeyExchange(){} // RVA: 0x951F150
        public void CreateDheKeyExchange(){} // RVA: 0x951F1F0
        public void CreateECDHKeyExchange(){} // RVA: 0x951F290
        public void CreateECDheKeyExchange(){} // RVA: 0x951F330
        public void CreateRsaKeyExchange(){} // RVA: 0x951F3D0
    }

    public class DefaultTlsSignerCredentials
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext mContext; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate mCertificate; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x951F490 | overloaded x2
        public void get_Certificate(){} // RVA: 0x2E07C0
        public void GenerateCertificateSignature(){} // RVA: 0x951F910
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x30B130
    }

    public class DefaultTlsSrpGroupVerifier : .cctor
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x951FB20
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void Accept(){} // RVA: 0x951FEB0
        public void AreGroupsEqual(){} // RVA: 0x9520080
        public void AreParametersEqual(){} // RVA: 0x951E630
    }

    public class DeferredHash
    {
        public int BUFFERING_HASH_LIMIT;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95202B0 | overloaded x2
        public void Init(){} // RVA: 0x2DEE30
        public void NotifyPrfDetermined(){} // RVA: 0x9520480
        public void TrackHashAlgorithm(){} // RVA: 0x95205D0
        public void SealHashAlgorithms(){} // RVA: 0x9520650
        public void StopTracking(){} // RVA: 0x9520670
        public void ForkPrfHash(){} // RVA: 0x9520800
        public void GetFinalHash(){} // RVA: 0x9520980
        public void get_AlgorithmName(){} // RVA: 0x9520B60
        public void GetByteLength(){} // RVA: 0x9520BB0
        public void GetDigestSize(){} // RVA: 0x9520C00
        public void Update(){} // RVA: 0x9520C50
        public void BlockUpdate(){} // RVA: 0x9520F90
        public void DoFinal(){} // RVA: 0x95212E0
        public void Reset(){} // RVA: 0x9521330
        public void CheckStopBuffering(){} // RVA: 0x9521650
        public void CheckTrackingHash(){} // RVA: 0x9521960
    }

    public class DigestInputBuffer
    {
        // ── Methods ──
        public void UpdateDigest(){} // RVA: 0x9521A80
        public void .ctor(){} // RVA: 0x9521B80
    }

    public class DigitallySigned
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm mAlgorithm; // 0x10
        public byte[] mSignature; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9521D20
        public void get_Algorithm(){} // RVA: 0x2F8380
        public void get_Signature(){} // RVA: 0x2E07C0
        public void Encode(){} // RVA: 0x9521E30
        public void Parse(){} // RVA: 0x9521EC0
    }

    public class DtlsClientProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9521F90
        public void Connect(){} // RVA: 0x9522040
        public void AbortClientHandshake(){} // RVA: 0x9522600
        public void ClientHandshake(){} // RVA: 0x9522660
        public void GenerateCertificateVerify(){} // RVA: 0x9523690
        public void GenerateClientHello(){} // RVA: 0x9523730
        public void GenerateClientKeyExchange(){} // RVA: 0x9523FB0
        public void InvalidateSession(){} // RVA: 0x9524060
        public void ProcessCertificateRequest(){} // RVA: 0x9524190
        public void ProcessCertificateStatus(){} // RVA: 0x9524340
        public void ProcessHelloVerifyRequest(){} // RVA: 0x95244D0
        public void ProcessNewSessionTicket(){} // RVA: 0x9524790
        public void ProcessServerCertificate(){} // RVA: 0x95248B0
        public void ProcessServerHello(){} // RVA: 0x9524AC0
        public void ProcessServerKeyExchange(){} // RVA: 0x9525670
        public void ProcessServerSupplementalData(){} // RVA: 0x95257A0
        public void ReportServerVersion(){} // RVA: 0x9525850
        public void PatchClientHelloWithCookie(){} // RVA: 0x9525950
    }

    public class DtlsEpoch
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DtlsReplayWindow mReplayWindow; // 0x10
        public int mEpoch; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCipher mCipher; // 0x20
        public long mSequenceNumber; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9525AA0
        public void AllocateSequenceNumber(){} // RVA: 0x9525C60
        public void get_Cipher(){} // RVA: 0x30B0C0
        public void get_Epoch(){} // RVA: 0x5BED50
        public void get_ReplayWindow(){} // RVA: 0x2F8380
        public void get_SequenceNumber(){} // RVA: 0x9525E00
    }

    public class DtlsHandshakeRetransmit
    {
        // ── Methods ──
        public void ReceivedHandshakeRecord(){}
    }

    public class DtlsProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9521F90
        public void ProcessFinished(){} // RVA: 0x9525F40
        public void ApplyMaxFragmentLengthExtension(){} // RVA: 0x9526130
        public void EvaluateMaxFragmentLengthExtension(){} // RVA: 0x95261D0
        public void GenerateCertificate(){} // RVA: 0x9526280
        public void GenerateSupplementalData(){} // RVA: 0x9526320
        public void ValidateSelectedCipherSuite(){} // RVA: 0x95263B0
    }

    public class DtlsReassembler
    {
        public byte ReadEpoch; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9526450
        public void get_MsgType(){} // RVA: 0x3A75E0
        public void GetBodyIfComplete(){} // RVA: 0x9526620
        public void ContributeFragment(){} // RVA: 0x9526680
        public void Reset(){} // RVA: 0x95269D0
    }

    public class DtlsRecordLayer
    {
        public int RECORD_HEADER_LENGTH;
        public int MAX_FRAGMENT_LENGTH;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9526A80
        public void SetPlaintextLimit(){} // RVA: 0x9526E00
        public void get_ReadEpoch(){} // RVA: 0x9526E10
        public void get_ReadVersion(){} // RVA: 0x9526E30
        public void set_ReadVersion(){} // RVA: 0x9526E40
        public void SetWriteVersion(){} // RVA: 0x6417A90
        public void InitPendingEpoch(){} // RVA: 0x9526EA0
        public void HandshakeSuccessful(){} // RVA: 0x9526FB0
        public void ResetWriteEpoch(){} // RVA: 0x9527140
        public void GetReceiveLimit(){} // RVA: 0x9527210
        public void GetSendLimit(){} // RVA: 0x95272E0
        public void Receive(){} // RVA: 0x95273C0
        public void Send(){} // RVA: 0x9527DE0
        public void Close(){} // RVA: 0x9527FD0
        public void Failed(){} // RVA: 0x9528050
        public void Fail(){} // RVA: 0x9528080
        public void Warn(){} // RVA: 0x95280E0
        public void CloseTransport(){} // RVA: 0x9528110
        public void RaiseAlert(){} // RVA: 0x95281B0
        public void ReceiveRecord(){} // RVA: 0x95282A0
        public void SendRecord(){} // RVA: 0x9528580
        public void GetMacSequenceNumber(){} // RVA: 0x95288D0
    }

    public class DtlsReliableHandshake
    {
        public int MaxReceiveAhead;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95288E0
        public void NotifyHelloComplete(){} // RVA: 0x9528B70
        public void get_HandshakeHash(){} // RVA: 0x2E07C0
        public void PrepareToFinish(){} // RVA: 0x9528C10
        public void SendMessage(){} // RVA: 0x9528CC0
        public void ReceiveMessageBody(){} // RVA: 0x9528E40
        public void ReceiveMessage(){} // RVA: 0x9528EB0
        public void Finish(){} // RVA: 0x9529140
        public void ResetHandshakeMessagesDigest(){} // RVA: 0x9529220
        public void BackOff(){} // RVA: 0x9529270
        public void CheckInboundFlight(){} // RVA: 0x95292D0
        public void GetPendingMessage(){} // RVA: 0x95294E0
        public void PrepareInboundFlight(){} // RVA: 0x95296F0
        public void ProcessRecord(){} // RVA: 0x95297D0
        public void ResendOutboundFlight(){} // RVA: 0x9529CB0
        public void UpdateHandshakeMessagesDigest(){} // RVA: 0x9529EE0
        public void WriteMessage(){} // RVA: 0x952A0E0
        public void WriteHandshakeFragment(){} // RVA: 0x952A220
        public void CheckAll(){} // RVA: 0x952A500
        public void ResetAll(){} // RVA: 0x952A750
    }

    public class DtlsReplayWindow
    {
        // ── Methods ──
        public void ShouldDiscard(){} // RVA: 0x952ABE0
        public void ReportAuthenticated(){} // RVA: 0x952AC30
        public void Reset(){} // RVA: 0x952AD20
        public void .ctor(){} // RVA: 0x952AD40
    }

    public class DtlsServerProtocol
    {
        public bool mVerifyRequests; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x952AD50
        public void get_VerifyRequests(){} // RVA: 0x2F84E0
        public void set_VerifyRequests(){} // RVA: 0x2F84F0
        public void Accept(){} // RVA: 0x952AE00
        public void AbortServerHandshake(){} // RVA: 0x952B330
        public void ServerHandshake(){} // RVA: 0x952B390
        public void InvalidateSession(){} // RVA: 0x952BF30
        public void GenerateCertificateRequest(){} // RVA: 0x952C060
        public void GenerateCertificateStatus(){} // RVA: 0x952C100
        public void GenerateNewSessionTicket(){} // RVA: 0x952C1A0
        public void GenerateServerHello(){} // RVA: 0x952C240
        public void NotifyClientCertificate(){} // RVA: 0x952CAB0
        public void ProcessClientCertificate(){} // RVA: 0x952CCD0
        public void ProcessCertificateVerify(){} // RVA: 0x952CE20
        public void ProcessClientHello(){} // RVA: 0x952D280
        public void ProcessClientKeyExchange(){} // RVA: 0x952D8D0
        public void ProcessClientSupplementalData(){} // RVA: 0x952DA00
        public void ExpectCertificateVerifyMessage(){} // RVA: 0x952DAB0
    }

    public class DtlsTransport : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetReceiveLimit(){} // RVA: 0x7F0150
        public void GetSendLimit(){} // RVA: 0x7F0370
        public void Receive(){} // RVA: 0x952DB40
        public void Send(){} // RVA: 0x952DCC0
        public void Close(){} // RVA: 0x63F6270
    }

}