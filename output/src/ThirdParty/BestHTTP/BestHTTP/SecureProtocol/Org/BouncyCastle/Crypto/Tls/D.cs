// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 22
// Methods: 207

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class DatagramTransport
    {
        // ── Methods ──
        public void GetReceiveLimit(){} // RVA: 0x87C130
        public void GetSendLimit(){} // RVA: 0x87C130
        public void Receive(){} // RVA: 0x8854C0
        public void Send(){} // RVA: 0x89B9B0
        public void Close(){} // RVA: 0x894290
    }

    public class DefaultTlsAgreementCredentials : AbstractTlsAgreementCredentials
    {
        public object mCertificate;
        public object mPrivateKey;
        public object mBasicAgreement;
        public object mTruncateAgreement;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1BD770
        public void get_Certificate(){} // RVA: 0xB5DBF0
        public void GenerateAgreement(){} // RVA: 0xA1BDAB0
    }

    public class DefaultTlsCipherFactory : AbstractTlsCipherFactory
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0xA1BDB70
        public void CreateAESCipher(){} // RVA: 0xA1BDED0
        public void CreateCamelliaCipher(){} // RVA: 0xA1BDFE0
        public void CreateChaCha20Poly1305(){} // RVA: 0xA1BE0F0
        public void CreateCipher_Aes_Ccm(){} // RVA: 0xA1BE150
        public void CreateCipher_Aes_Gcm(){} // RVA: 0xA1BE220
        public void CreateCipher_Aes_Ocb(){} // RVA: 0xA1BE2F0
        public void CreateCipher_Camellia_Gcm(){} // RVA: 0xA1BE3C0
        public void CreateDesEdeCipher(){} // RVA: 0xA1BE490
        public void CreateNullCipher(){} // RVA: 0xA1BE5A0
        public void CreateRC4Cipher(){} // RVA: 0xA1BE660
        public void CreateSeedCipher(){} // RVA: 0xA1BE780
        public void CreateAesEngine(){} // RVA: 0xA1BE890
        public void CreateCamelliaEngine(){} // RVA: 0xA1BE8D0
        public void CreateAesBlockCipher(){} // RVA: 0xA1BE920
        public void CreateAeadBlockCipher_Aes_Ccm(){} // RVA: 0xA1BE9A0
        public void CreateAeadBlockCipher_Aes_Gcm(){} // RVA: 0xA1BEA20
        public void CreateAeadBlockCipher_Aes_Ocb(){} // RVA: 0xA1BEAA0
        public void CreateAeadBlockCipher_Camellia_Gcm(){} // RVA: 0xA1BEB40
        public void CreateCamelliaBlockCipher(){} // RVA: 0xA1BEBC0
        public void CreateDesEdeBlockCipher(){} // RVA: 0xA1BEC40
        public void CreateRC4StreamCipher(){} // RVA: 0xA1BECF0
        public void CreateSeedBlockCipher(){} // RVA: 0xA1BED30
        public void CreateHMacDigest(){} // RVA: 0xA1BEDB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DefaultTlsClient : AbstractTlsClient
    {
        public object mDHVerifier;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1BF160
        public void GetCipherSuites(){} // RVA: 0xA1BF210
        public void GetKeyExchange(){} // RVA: 0xA1BF280
        public void CreateDHKeyExchange(){} // RVA: 0xA1BF440
        public void CreateDheKeyExchange(){} // RVA: 0xA1BF4D0
        public void CreateECDHKeyExchange(){} // RVA: 0xA1BF560
        public void CreateECDheKeyExchange(){} // RVA: 0xA1BF600
        public void CreateRsaKeyExchange(){} // RVA: 0xA1BF6A0
    }

    public class DefaultTlsDHVerifier : Object
    {
        public object DefaultMinimumPrimeBits;
        public object DefaultGroups;
        public object mGroups;
        public object mMinimumPrimeBits;

        // ── Methods ──
        public void AddDefaultGroup(){} // RVA: 0xA1BF740
        public void .cctor(){} // RVA: 0xA1BF7D0
        public void .ctor(){} // RVA: 0x2615F10
        public void Accept(){} // RVA: 0xA1C00C0
        public void get_MinimumPrimeBits(){} // RVA: 0xE62D00
        public void AreGroupsEqual(){} // RVA: 0xA1C0120
        public void AreParametersEqual(){} // RVA: 0xA1C01C0
        public void CheckGroup(){} // RVA: 0xA1C0200
        public void CheckMinimumPrimeBits(){} // RVA: 0xA1C03F0
    }

    public class DefaultTlsEncryptionCredentials : AbstractTlsEncryptionCredentials
    {
        public object mContext;
        public object mCertificate;
        public object mPrivateKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1C0450
        public void get_Certificate(){} // RVA: 0xB465B0
        public void DecryptPreMasterSecret(){} // RVA: 0xA1C0710
    }

    public class DefaultTlsServer : AbstractTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetDsaSignerCredentials(){} // RVA: 0xA1C07A0
        public void GetECDsaSignerCredentials(){} // RVA: 0xA1C07F0
        public void GetRsaEncryptionCredentials(){} // RVA: 0xA1C0840
        public void GetRsaSignerCredentials(){} // RVA: 0xA1C0890
        public void GetDHParameters(){} // RVA: 0xA1C08E0
        public void GetCipherSuites(){} // RVA: 0xA1C0940
        public void GetCredentials(){} // RVA: 0xA1C09B0
        public void GetKeyExchange(){} // RVA: 0xA1C0B20
        public void CreateDHKeyExchange(){} // RVA: 0xA1C0CE0
        public void CreateDheKeyExchange(){} // RVA: 0xA1C0D80
        public void CreateECDHKeyExchange(){} // RVA: 0xA1C0E20
        public void CreateECDheKeyExchange(){} // RVA: 0xA1C0EC0
        public void CreateRsaKeyExchange(){} // RVA: 0xA1C0F60
    }

    public class DefaultTlsSignerCredentials : AbstractTlsSignerCredentials
    {
        public object mContext;
        public object mCertificate;
        public object mPrivateKey;
        public object mSignatureAndHashAlgorithm;
        public object mSigner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1C1020
        public void get_Certificate(){} // RVA: 0xB465B0
        public void GenerateCertificateSignature(){} // RVA: 0xA1C14A0
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0xB70160
    }

    public class DefaultTlsSrpGroupVerifier : Object
    {
        public object DefaultGroups;
        public object mGroups;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA1C16B0
        public void .ctor(){} // RVA: 0xB44D60
        public void Accept(){} // RVA: 0xA1C1A40
        public void AreGroupsEqual(){} // RVA: 0xA1C1C10
        public void AreParametersEqual(){} // RVA: 0xA1C01C0
    }

    public class DeferredHash : Object
    {
        public object BUFFERING_HASH_LIMIT;
        public object mContext;
        public object mBuf;
        public object mHashes;
        public object mPrfHashAlgorithm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1C1E40
        public void Init(){} // RVA: 0xB44D60
        public void NotifyPrfDetermined(){} // RVA: 0xA1C2000
        public void TrackHashAlgorithm(){} // RVA: 0xA1C2150
        public void SealHashAlgorithms(){} // RVA: 0xA1C21D0
        public void StopTracking(){} // RVA: 0xA1C21F0
        public void ForkPrfHash(){} // RVA: 0xA1C24D0
        public void GetFinalHash(){} // RVA: 0xA1C2640
        public void get_AlgorithmName(){} // RVA: 0xA1C2810
        public void GetByteLength(){} // RVA: 0xA1C2860
        public void GetDigestSize(){} // RVA: 0xA1C28B0
        public void Update(){} // RVA: 0xA1C2900
        public void BlockUpdate(){} // RVA: 0xA1C2C30
        public void DoFinal(){} // RVA: 0xA1C2F80
        public void Reset(){} // RVA: 0xA1C2FD0
        public void CheckStopBuffering(){} // RVA: 0xA1C32E0
        public void CheckTrackingHash(){} // RVA: 0xA1C35E0
    }

    public class DigestInputBuffer : MemoryStream
    {
        // ── Methods ──
        public void UpdateDigest(){} // RVA: 0xA1C36E0
        public void .ctor(){} // RVA: 0xA1C37E0
    }

    public class DigitallySigned : Object
    {
        public object mAlgorithm;
        public object mSignature;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1C3980
        public void get_Algorithm(){} // RVA: 0xB5DBF0
        public void get_Signature(){} // RVA: 0xB465B0
        public void Encode(){} // RVA: 0xA1C3A90
        public void Parse(){} // RVA: 0xA1C3B20
    }

    public class DtlsClientProtocol : DtlsProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1C3BF0
        public void Connect(){} // RVA: 0xA1C3CA0
        public void AbortClientHandshake(){} // RVA: 0xA1C4260
        public void ClientHandshake(){} // RVA: 0xA1C42C0
        public void GenerateCertificateVerify(){} // RVA: 0xA1C52D0
        public void GenerateClientHello(){} // RVA: 0xA1C5370
        public void GenerateClientKeyExchange(){} // RVA: 0xA1C5C10
        public void InvalidateSession(){} // RVA: 0xA1C5CC0
        public void ProcessCertificateRequest(){} // RVA: 0xA1C5DF0
        public void ProcessCertificateStatus(){} // RVA: 0xA1C5FA0
        public void ProcessHelloVerifyRequest(){} // RVA: 0xA1C6130
        public void ProcessNewSessionTicket(){} // RVA: 0xA1C63F0
        public void ProcessServerCertificate(){} // RVA: 0xA1C6510
        public void ProcessServerHello(){} // RVA: 0xA1C6720
        public void ProcessServerKeyExchange(){} // RVA: 0xA1C72C0
        public void ProcessServerSupplementalData(){} // RVA: 0xA1C73F0
        public void ReportServerVersion(){} // RVA: 0xA1C74A0
        public void PatchClientHelloWithCookie(){} // RVA: 0xA1C75A0
    }

    public class DtlsEpoch : Object
    {
        public object mReplayWindow;
        public object mEpoch;
        public object mCipher;
        public object mSequenceNumber;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1C76F0
        public void AllocateSequenceNumber(){} // RVA: 0xA1C78B0
        public void get_Cipher(){} // RVA: 0xB700F0
        public void get_Epoch(){} // RVA: 0xE62D00
        public void get_ReplayWindow(){} // RVA: 0xB5DBF0
        public void get_SequenceNumber(){} // RVA: 0xA1C7A20
    }

    public class DtlsHandshakeRetransmit
    {
        // ── Methods ──
        public void ReceivedHandshakeRecord(){} // RVA: 0x897700
    }

    public class DtlsProtocol : Object
    {
        public object mSecureRandom;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1C3BF0
        public void ProcessFinished(){} // RVA: 0xA1C7B20
        public void ApplyMaxFragmentLengthExtension(){} // RVA: 0xA1C7D20
        public void EvaluateMaxFragmentLengthExtension(){} // RVA: 0xA1C7DC0
        public void GenerateCertificate(){} // RVA: 0xA1C7E70
        public void GenerateSupplementalData(){} // RVA: 0xA1C7F10
        public void ValidateSelectedCipherSuite(){} // RVA: 0xA1C7FA0
    }

    public class DtlsReassembler : Object
    {
        public object mMsgType;
        public object mBody;
        public object mMissing;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1C8040
        public void get_MsgType(){} // RVA: 0xC120A0
        public void GetBodyIfComplete(){} // RVA: 0xA1C8210
        public void ContributeFragment(){} // RVA: 0xA1C8270
        public void Reset(){} // RVA: 0xA1C85B0
    }

    public class DtlsRecordLayer : Object
    {
        public object RECORD_HEADER_LENGTH;
        public object MAX_FRAGMENT_LENGTH;
        public object TCP_MSL;
        public object RETRANSMIT_TIMEOUT;
        public object mTransport;
        public object mContext;
        public object mPeer;
        public object mRecordQueue;
        public object mClosed;
        public object mFailed;
        public object mReadVersion;
        public object mWriteVersion;
        public object mInHandshake;
        public object mPlaintextLimit;
        public object mCurrentEpoch;
        public object mPendingEpoch;
        public object mReadEpoch;
        public object mWriteEpoch;
        public object mRetransmit;
        public object mRetransmitEpoch;
        public object mRetransmitExpiry;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1C8660
        public void SetPlaintextLimit(){} // RVA: 0xA1C89E0
        public void get_ReadEpoch(){} // RVA: 0xA1C89F0
        public void get_ReadVersion(){} // RVA: 0xA1C8A10
        public void set_ReadVersion(){} // RVA: 0xA1C8A20
        public void SetWriteVersion(){} // RVA: 0x6E882F0
        public void InitPendingEpoch(){} // RVA: 0xA1C8A80
        public void HandshakeSuccessful(){} // RVA: 0xA1C8B90
        public void ResetWriteEpoch(){} // RVA: 0xA1C8D20
        public void GetReceiveLimit(){} // RVA: 0xA1C8DF0
        public void GetSendLimit(){} // RVA: 0xA1C8EC0
        public void Receive(){} // RVA: 0xA1C8FA0
        public void Send(){} // RVA: 0xA1C99C0
        public void Close(){} // RVA: 0xA1C9BB0
        public void Failed(){} // RVA: 0xA1C9C30
        public void Fail(){} // RVA: 0xA1C9C60
        public void Warn(){} // RVA: 0xA1C9CC0
        public void CloseTransport(){} // RVA: 0xA1C9CF0
        public void RaiseAlert(){} // RVA: 0xA1C9D90
        public void ReceiveRecord(){} // RVA: 0xA1C9E80
        public void SendRecord(){} // RVA: 0xA1CA150
        public void GetMacSequenceNumber(){} // RVA: 0xA1CA4A0
    }

    public class DtlsReliableHandshake : Object
    {
        public object MaxReceiveAhead;
        public object MessageHeaderLength;
        public object mRecordLayer;
        public object mHandshakeHash;
        public object mCurrentInboundFlight;
        public object mPreviousInboundFlight;
        public object mOutboundFlight;
        public object mSending;
        public object mMessageSeq;
        public object mNextReceiveSeq;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1CA4B0
        public void NotifyHelloComplete(){} // RVA: 0xA1CA760
        public void get_HandshakeHash(){} // RVA: 0xB465B0
        public void PrepareToFinish(){} // RVA: 0xA1CA800
        public void SendMessage(){} // RVA: 0xA1CA8B0
        public void ReceiveMessageBody(){} // RVA: 0xA1CAA40
        public void ReceiveMessage(){} // RVA: 0xA1CAAB0
        public void Finish(){} // RVA: 0xA1CAD40
        public void ResetHandshakeMessagesDigest(){} // RVA: 0xA1CAE20
        public void BackOff(){} // RVA: 0xA1CAE70
        public void CheckInboundFlight(){} // RVA: 0xA1CAED0
        public void GetPendingMessage(){} // RVA: 0xA1CB0B0
        public void PrepareInboundFlight(){} // RVA: 0xA1CB2B0
        public void ProcessRecord(){} // RVA: 0xA1CB390
        public void ResendOutboundFlight(){} // RVA: 0xA1CB880
        public void UpdateHandshakeMessagesDigest(){} // RVA: 0xA1CBAB0
        public void WriteMessage(){} // RVA: 0xA1CBCB0
        public void WriteHandshakeFragment(){} // RVA: 0xA1CBE00
        public void CheckAll(){} // RVA: 0xA1CC0E0
        public void ResetAll(){} // RVA: 0xA1CC330
    }

    public class DtlsReplayWindow : Object
    {
        public object VALID_SEQ_MASK;
        public object WINDOW_SIZE;
        public object mLatestConfirmedSeq;
        public object mBitmap;

        // ── Methods ──
        public void ShouldDiscard(){} // RVA: 0xA1CC7B0
        public void ReportAuthenticated(){} // RVA: 0xA1CC800
        public void Reset(){} // RVA: 0xA1CC8F0
        public void .ctor(){} // RVA: 0xA1CC910
    }

    public class DtlsServerProtocol : DtlsProtocol
    {
        public object mVerifyRequests;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1CC920
        public void get_VerifyRequests(){} // RVA: 0xB5DD50
        public void set_VerifyRequests(){} // RVA: 0xB5DD60
        public void Accept(){} // RVA: 0xA1CC9E0
        public void AbortServerHandshake(){} // RVA: 0xA1CCF20
        public void ServerHandshake(){} // RVA: 0xA1CCF80
        public void InvalidateSession(){} // RVA: 0xA1CDB20
        public void GenerateCertificateRequest(){} // RVA: 0xA1CDC50
        public void GenerateCertificateStatus(){} // RVA: 0xA1CDCF0
        public void GenerateNewSessionTicket(){} // RVA: 0xA1CDD90
        public void GenerateServerHello(){} // RVA: 0xA1CDE30
        public void NotifyClientCertificate(){} // RVA: 0xA1CE6A0
        public void ProcessClientCertificate(){} // RVA: 0xA1CE8C0
        public void ProcessCertificateVerify(){} // RVA: 0xA1CEA10
        public void ProcessClientHello(){} // RVA: 0xA1CEE70
        public void ProcessClientKeyExchange(){} // RVA: 0xA1CF4E0
        public void ProcessClientSupplementalData(){} // RVA: 0xA1CF610
        public void ExpectCertificateVerifyMessage(){} // RVA: 0xA1CF6C0
    }

    public class DtlsTransport : Object
    {
        public object mRecordLayer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetReceiveLimit(){} // RVA: 0x10ACFC0
        public void GetSendLimit(){} // RVA: 0x10AC4B0
        public void Receive(){} // RVA: 0xA1CF750
        public void Send(){} // RVA: 0xA1CF8D0
        public void Close(){} // RVA: 0x6E669C0
    }

}