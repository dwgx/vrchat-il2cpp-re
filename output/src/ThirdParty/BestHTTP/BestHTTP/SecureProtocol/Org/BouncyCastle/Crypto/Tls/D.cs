// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 22
// Methods: 215

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class DatagramTransport
    {
        // ── Methods ──
        public void GetReceiveLimit(){} // RVA: 0x7FFAC2C59960
        public void GetSendLimit(){} // RVA: 0x7FFAC2C59960
        public void Receive(){}
        public void Send(){}
        public void Close(){} // RVA: 0x7FFAC2C70980
    }

    public class DefaultTlsAgreementCredentials : AbstractTlsAgreementCredentials
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate Certificate; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter mPrivateKey; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBasicAgreement mBasicAgreement; // 0x20
        public bool mTruncateAgreement; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB249A0
        public void get_Certificate(){} // RVA: 0x7FFAC2F3C380
        public void GenerateAgreement(){} // RVA: 0x7FFACBB24CE0
    }

    public class DefaultTlsCipherFactory : AbstractTlsCipherFactory
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0x7FFACBB24DA0
        public void CreateAESCipher(){} // RVA: 0x7FFACBB25100
        public void CreateCamelliaCipher(){} // RVA: 0x7FFACBB25210
        public void CreateChaCha20Poly1305(){} // RVA: 0x7FFACBB25320
        public void CreateCipher_Aes_Ccm(){} // RVA: 0x7FFACBB25380
        public void CreateCipher_Aes_Gcm(){} // RVA: 0x7FFACBB25450
        public void CreateCipher_Aes_Ocb(){} // RVA: 0x7FFACBB25520
        public void CreateCipher_Camellia_Gcm(){} // RVA: 0x7FFACBB255F0
        public void CreateDesEdeCipher(){} // RVA: 0x7FFACBB256C0
        public void CreateNullCipher(){} // RVA: 0x7FFACBB257D0
        public void CreateRC4Cipher(){} // RVA: 0x7FFACBB25890
        public void CreateSeedCipher(){} // RVA: 0x7FFACBB259B0
        public void CreateAesEngine(){} // RVA: 0x7FFACBB25AC0
        public void CreateCamelliaEngine(){} // RVA: 0x7FFACBB25B00
        public void CreateAesBlockCipher(){} // RVA: 0x7FFACBB25B50
        public void CreateAeadBlockCipher_Aes_Ccm(){} // RVA: 0x7FFACBB25BD0
        public void CreateAeadBlockCipher_Aes_Gcm(){} // RVA: 0x7FFACBB25C50
        public void CreateAeadBlockCipher_Aes_Ocb(){} // RVA: 0x7FFACBB25CD0
        public void CreateAeadBlockCipher_Camellia_Gcm(){} // RVA: 0x7FFACBB25D70
        public void CreateCamelliaBlockCipher(){} // RVA: 0x7FFACBB25DF0
        public void CreateDesEdeBlockCipher(){} // RVA: 0x7FFACBB25E70
        public void CreateRC4StreamCipher(){} // RVA: 0x7FFACBB25F20
        public void CreateSeedBlockCipher(){} // RVA: 0x7FFACBB25F60
        public void CreateHMacDigest(){} // RVA: 0x7FFACBB25FE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DefaultTlsClient : AbstractTlsClient
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsDHVerifier mDHVerifier; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB26390 | overloaded x3
        public void GetCipherSuites(){} // RVA: 0x7FFACBB26440
        public void GetKeyExchange(){} // RVA: 0x7FFACBB264B0
        public void CreateDHKeyExchange(){} // RVA: 0x7FFACBB26660
        public void CreateDheKeyExchange(){} // RVA: 0x7FFACBB266F0
        public void CreateECDHKeyExchange(){} // RVA: 0x7FFACBB26780
        public void CreateECDheKeyExchange(){} // RVA: 0x7FFACBB26820
        public void CreateRsaKeyExchange(){} // RVA: 0x7FFACBB268C0
    }

    public class DefaultTlsDHVerifier : Object
    {
        public int MinimumPrimeBits;
        public System.Collections.IList DefaultGroups; // 0x8
        public System.Collections.IList mGroups; // 0x10
        public int mMinimumPrimeBits; // 0x18

        // ── Methods ──
        public void AddDefaultGroup(){} // RVA: 0x7FFACBB26960
        public void .cctor(){} // RVA: 0x7FFACBB269F0
        public void .ctor(){} // RVA: 0x7FFAC488C310 | overloaded x3
        public void Accept(){} // RVA: 0x7FFACBB272E0
        public void get_MinimumPrimeBits(){} // RVA: 0x7FFAC3157800
        public void AreGroupsEqual(){} // RVA: 0x7FFACBB27340
        public void AreParametersEqual(){} // RVA: 0x7FFACBB273E0
        public void CheckGroup(){} // RVA: 0x7FFACBB27420
        public void CheckMinimumPrimeBits(){} // RVA: 0x7FFACBB27620
    }

    public class DefaultTlsEncryptionCredentials : AbstractTlsEncryptionCredentials
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext Certificate; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate mCertificate; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter mPrivateKey; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB27680
        public void get_Certificate(){} // RVA: 0x7FFAC2F247C0
        public void DecryptPreMasterSecret(){} // RVA: 0x7FFACBB27940
    }

    public class DefaultTlsServer : AbstractTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void GetDsaSignerCredentials(){} // RVA: 0x7FFACBB279D0
        public void GetECDsaSignerCredentials(){} // RVA: 0x7FFACBB27A20
        public void GetRsaEncryptionCredentials(){} // RVA: 0x7FFACBB27A70
        public void GetRsaSignerCredentials(){} // RVA: 0x7FFACBB27AC0
        public void GetDHParameters(){} // RVA: 0x7FFACBB27B10
        public void GetCipherSuites(){} // RVA: 0x7FFACBB27B70
        public void GetCredentials(){} // RVA: 0x7FFACBB27BE0
        public void GetKeyExchange(){} // RVA: 0x7FFACBB27D50
        public void CreateDHKeyExchange(){} // RVA: 0x7FFACBB27F00
        public void CreateDheKeyExchange(){} // RVA: 0x7FFACBB27FA0
        public void CreateECDHKeyExchange(){} // RVA: 0x7FFACBB28040
        public void CreateECDheKeyExchange(){} // RVA: 0x7FFACBB280E0
        public void CreateRsaKeyExchange(){} // RVA: 0x7FFACBB28180
    }

    public class DefaultTlsSignerCredentials : AbstractTlsSignerCredentials
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext Certificate; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate SignatureAndHashAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter mPrivateKey; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm mSignatureAndHashAlgorithm; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSigner mSigner; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB28240 | overloaded x2
        public void get_Certificate(){} // RVA: 0x7FFAC2F247C0
        public void GenerateCertificateSignature(){} // RVA: 0x7FFACBB286C0
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x7FFAC2F4F130
    }

    public class DefaultTlsSrpGroupVerifier : Object
    {
        public System.Collections.IList DefaultGroups;
        public System.Collections.IList mGroups; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBB288D0
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void Accept(){} // RVA: 0x7FFACBB28C60
        public void AreGroupsEqual(){} // RVA: 0x7FFACBB28E30
        public void AreParametersEqual(){} // RVA: 0x7FFACBB273E0
    }

    public class DeferredHash : Object
    {
        public int AlgorithmName;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext mContext; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DigestInputBuffer mBuf; // 0x18
        public System.Collections.IDictionary mHashes; // 0x20
        public int mPrfHashAlgorithm; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB29060 | overloaded x2
        public void Init(){} // RVA: 0x7FFAC2F22E30
        public void NotifyPrfDetermined(){} // RVA: 0x7FFACBB29230
        public void TrackHashAlgorithm(){} // RVA: 0x7FFACBB29380
        public void SealHashAlgorithms(){} // RVA: 0x7FFACBB29400
        public void StopTracking(){} // RVA: 0x7FFACBB29420
        public void ForkPrfHash(){} // RVA: 0x7FFACBB295B0
        public void GetFinalHash(){} // RVA: 0x7FFACBB29730
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB29910
        public void GetByteLength(){} // RVA: 0x7FFACBB29960
        public void GetDigestSize(){} // RVA: 0x7FFACBB299B0
        public void Update(){} // RVA: 0x7FFACBB29A00
        public void BlockUpdate(){} // RVA: 0x7FFACBB29D40
        public void DoFinal(){} // RVA: 0x7FFACBB2A090
        public void Reset(){} // RVA: 0x7FFACBB2A0E0
        public void CheckStopBuffering(){} // RVA: 0x7FFACBB2A400
        public void CheckTrackingHash(){} // RVA: 0x7FFACBB2A710
    }

    public class DigestInputBuffer : MemoryStream
    {
        // ── Methods ──
        public void UpdateDigest(){} // RVA: 0x7FFACBB2A830
        public void .ctor(){} // RVA: 0x7FFACBB2A930
    }

    public class DigitallySigned : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm Algorithm; // 0x10
        public byte[] Signature; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB2AAD0
        public void get_Algorithm(){} // RVA: 0x7FFAC2F3C380
        public void get_Signature(){} // RVA: 0x7FFAC2F247C0
        public void Encode(){} // RVA: 0x7FFACBB2ABE0
        public void Parse(){} // RVA: 0x7FFACBB2AC70
    }

    public class DtlsClientProtocol : DtlsProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB2AD40
        public void Connect(){} // RVA: 0x7FFACBB2ADF0
        public void AbortClientHandshake(){} // RVA: 0x7FFACBB2B3B0
        public void ClientHandshake(){} // RVA: 0x7FFACBB2B410
        public void GenerateCertificateVerify(){} // RVA: 0x7FFACBB2C440
        public void GenerateClientHello(){} // RVA: 0x7FFACBB2C4E0
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFACBB2CD60
        public void InvalidateSession(){} // RVA: 0x7FFACBB2CE10
        public void ProcessCertificateRequest(){} // RVA: 0x7FFACBB2CF40
        public void ProcessCertificateStatus(){} // RVA: 0x7FFACBB2D0F0
        public void ProcessHelloVerifyRequest(){} // RVA: 0x7FFACBB2D280
        public void ProcessNewSessionTicket(){} // RVA: 0x7FFACBB2D540
        public void ProcessServerCertificate(){} // RVA: 0x7FFACBB2D660
        public void ProcessServerHello(){} // RVA: 0x7FFACBB2D870
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFACBB2E420
        public void ProcessServerSupplementalData(){} // RVA: 0x7FFACBB2E550
        public void ReportServerVersion(){} // RVA: 0x7FFACBB2E600
        public void PatchClientHelloWithCookie(){} // RVA: 0x7FFACBB2E700
    }

    public class DtlsEpoch : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DtlsReplayWindow Cipher; // 0x10
        public int Epoch; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCipher ReplayWindow; // 0x20
        public long SequenceNumber; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB2E850
        public void AllocateSequenceNumber(){} // RVA: 0x7FFACBB2EA10
        public void get_Cipher(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Epoch(){} // RVA: 0x7FFAC3157800
        public void get_ReplayWindow(){} // RVA: 0x7FFAC2F3C380
        public void get_SequenceNumber(){} // RVA: 0x7FFACBB2EBB0
    }

    public class DtlsHandshakeRetransmit
    {
        // ── Methods ──
        public void ReceivedHandshakeRecord(){}
    }

    public class DtlsProtocol : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom mSecureRandom; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB2AD40
        public void ProcessFinished(){} // RVA: 0x7FFACBB2ECF0
        public void ApplyMaxFragmentLengthExtension(){} // RVA: 0x7FFACBB2EEE0
        public void EvaluateMaxFragmentLengthExtension(){} // RVA: 0x7FFACBB2EF80
        public void GenerateCertificate(){} // RVA: 0x7FFACBB2F030
        public void GenerateSupplementalData(){} // RVA: 0x7FFACBB2F0D0
        public void ValidateSelectedCipherSuite(){} // RVA: 0x7FFACBB2F160
    }

    public class DtlsReassembler : Object
    {
        public byte MsgType; // 0x10
        public byte[] mBody; // 0x18
        public System.Collections.IList mMissing; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB2F200
        public void get_MsgType(){} // RVA: 0x7FFAC2FEB5E0
        public void GetBodyIfComplete(){} // RVA: 0x7FFACBB2F3D0
        public void ContributeFragment(){} // RVA: 0x7FFACBB2F430
        public void Reset(){} // RVA: 0x7FFACBB2F780
    }

    public class DtlsRecordLayer : Object
    {
        public int ReadEpoch;
        public int ReadVersion;
        public long TCP_MSL;
        public long RETRANSMIT_TIMEOUT;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DatagramTransport mTransport; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext mContext; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsPeer mPeer; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ByteQueue mRecordQueue; // 0x28
        public bool mClosed; // 0x30
        public bool mFailed; // 0x31
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion mReadVersion; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion mWriteVersion; // 0x40
        public bool mInHandshake; // 0x48
        public int mPlaintextLimit; // 0x4C
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DtlsEpoch mCurrentEpoch; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DtlsEpoch mPendingEpoch; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DtlsEpoch mReadEpoch; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DtlsEpoch mWriteEpoch; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DtlsHandshakeRetransmit mRetransmit; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DtlsEpoch mRetransmitEpoch; // 0x78
        public long mRetransmitExpiry; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB2F830
        public void SetPlaintextLimit(){} // RVA: 0x7FFACBB2FBB0
        public void get_ReadEpoch(){} // RVA: 0x7FFACBB2FBC0
        public void get_ReadVersion(){} // RVA: 0x7FFACBB2FBE0
        public void set_ReadVersion(){} // RVA: 0x7FFACBB2FBF0
        public void SetWriteVersion(){} // RVA: 0x7FFAC8BAEE10
        public void InitPendingEpoch(){} // RVA: 0x7FFACBB2FC50
        public void HandshakeSuccessful(){} // RVA: 0x7FFACBB2FD60
        public void ResetWriteEpoch(){} // RVA: 0x7FFACBB2FEF0
        public void GetReceiveLimit(){} // RVA: 0x7FFACBB2FFC0
        public void GetSendLimit(){} // RVA: 0x7FFACBB30090
        public void Receive(){} // RVA: 0x7FFACBB30170
        public void Send(){} // RVA: 0x7FFACBB30B90
        public void Close(){} // RVA: 0x7FFACBB30D80
        public void Failed(){} // RVA: 0x7FFACBB30E00
        public void Fail(){} // RVA: 0x7FFACBB30E30
        public void Warn(){} // RVA: 0x7FFACBB30E90
        public void CloseTransport(){} // RVA: 0x7FFACBB30EC0
        public void RaiseAlert(){} // RVA: 0x7FFACBB30F60
        public void ReceiveRecord(){} // RVA: 0x7FFACBB31050
        public void SendRecord(){} // RVA: 0x7FFACBB31330
        public void GetMacSequenceNumber(){} // RVA: 0x7FFACBB31680
    }

    public class DtlsReliableHandshake : Object
    {
        public int HandshakeHash;
        public int MessageHeaderLength;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer mRecordLayer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash mHandshakeHash; // 0x18
        public System.Collections.IDictionary mCurrentInboundFlight; // 0x20
        public System.Collections.IDictionary mPreviousInboundFlight; // 0x28
        public System.Collections.IList mOutboundFlight; // 0x30
        public bool mSending; // 0x38
        public int mMessageSeq; // 0x3C
        public int mNextReceiveSeq; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB31690
        public void NotifyHelloComplete(){} // RVA: 0x7FFACBB31920
        public void get_HandshakeHash(){} // RVA: 0x7FFAC2F247C0
        public void PrepareToFinish(){} // RVA: 0x7FFACBB319C0
        public void SendMessage(){} // RVA: 0x7FFACBB31A70
        public void ReceiveMessageBody(){} // RVA: 0x7FFACBB31BF0
        public void ReceiveMessage(){} // RVA: 0x7FFACBB31C60
        public void Finish(){} // RVA: 0x7FFACBB31EF0
        public void ResetHandshakeMessagesDigest(){} // RVA: 0x7FFACBB31FD0
        public void BackOff(){} // RVA: 0x7FFACBB32020
        public void CheckInboundFlight(){} // RVA: 0x7FFACBB32080
        public void GetPendingMessage(){} // RVA: 0x7FFACBB32290
        public void PrepareInboundFlight(){} // RVA: 0x7FFACBB324A0
        public void ProcessRecord(){} // RVA: 0x7FFACBB32580
        public void ResendOutboundFlight(){} // RVA: 0x7FFACBB32A60
        public void UpdateHandshakeMessagesDigest(){} // RVA: 0x7FFACBB32C90
        public void WriteMessage(){} // RVA: 0x7FFACBB32E90
        public void WriteHandshakeFragment(){} // RVA: 0x7FFACBB32FD0
        public void CheckAll(){} // RVA: 0x7FFACBB332B0
        public void ResetAll(){} // RVA: 0x7FFACBB33500
    }

    public class DtlsReplayWindow : Object
    {
        public long VALID_SEQ_MASK;
        public long WINDOW_SIZE;
        public long mLatestConfirmedSeq; // 0x10
        public long mBitmap; // 0x18

        // ── Methods ──
        public void ShouldDiscard(){} // RVA: 0x7FFACBB33990
        public void ReportAuthenticated(){} // RVA: 0x7FFACBB339E0
        public void Reset(){} // RVA: 0x7FFACBB33AD0
        public void .ctor(){} // RVA: 0x7FFACBB33AF0
    }

    public class DtlsServerProtocol : DtlsProtocol
    {
        public bool VerifyRequests; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB33B00
        public void get_VerifyRequests(){} // RVA: 0x7FFAC2F3C4E0
        public void set_VerifyRequests(){} // RVA: 0x7FFAC2F3C4F0
        public void Accept(){} // RVA: 0x7FFACBB33BB0
        public void AbortServerHandshake(){} // RVA: 0x7FFACBB340E0
        public void ServerHandshake(){} // RVA: 0x7FFACBB34140
        public void InvalidateSession(){} // RVA: 0x7FFACBB34CE0
        public void GenerateCertificateRequest(){} // RVA: 0x7FFACBB34E10
        public void GenerateCertificateStatus(){} // RVA: 0x7FFACBB34EB0
        public void GenerateNewSessionTicket(){} // RVA: 0x7FFACBB34F50
        public void GenerateServerHello(){} // RVA: 0x7FFACBB34FF0
        public void NotifyClientCertificate(){} // RVA: 0x7FFACBB35860
        public void ProcessClientCertificate(){} // RVA: 0x7FFACBB35A80
        public void ProcessCertificateVerify(){} // RVA: 0x7FFACBB35BD0
        public void ProcessClientHello(){} // RVA: 0x7FFACBB36030
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFACBB36680
        public void ProcessClientSupplementalData(){} // RVA: 0x7FFACBB367B0
        public void ExpectCertificateVerifyMessage(){} // RVA: 0x7FFACBB36860
    }

    public class DtlsTransport : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer mRecordLayer; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetReceiveLimit(){} // RVA: 0x7FFAC84AA770
        public void GetSendLimit(){} // RVA: 0x7FFAC84AA5F0
        public void Receive(){} // RVA: 0x7FFACBB368F0
        public void Send(){} // RVA: 0x7FFACBB36A70
        public void Close(){} // RVA: 0x7FFAC8B8D5F0
    }

}