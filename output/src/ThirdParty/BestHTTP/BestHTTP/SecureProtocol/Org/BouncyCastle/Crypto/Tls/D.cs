// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 22
// Methods: 215

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class DatagramTransport
    {
        // ── Methods ──
        public void GetReceiveLimit(){} // RVA: 0x7FFAF2ABD840
        public void GetSendLimit(){} // RVA: 0x7FFAF2ABD840
        public void Receive(){}
        public void Send(){}
        public void Close(){} // RVA: 0x7FFAF2AD4A50
    }

    public class DefaultTlsAgreementCredentials
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFCBBF0
        public void get_Certificate(){} // RVA: 0x7FFAF2DA8380
        public void GenerateAgreement(){} // RVA: 0x7FFAFBFCBF30
    }

    public class DefaultTlsCipherFactory
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0x7FFAFBFCBFF0
        public void CreateAESCipher(){} // RVA: 0x7FFAFBFCC350
        public void CreateCamelliaCipher(){} // RVA: 0x7FFAFBFCC460
        public void CreateChaCha20Poly1305(){} // RVA: 0x7FFAFBFCC570
        public void CreateCipher_Aes_Ccm(){} // RVA: 0x7FFAFBFCC5D0
        public void CreateCipher_Aes_Gcm(){} // RVA: 0x7FFAFBFCC6A0
        public void CreateCipher_Aes_Ocb(){} // RVA: 0x7FFAFBFCC770
        public void CreateCipher_Camellia_Gcm(){} // RVA: 0x7FFAFBFCC840
        public void CreateDesEdeCipher(){} // RVA: 0x7FFAFBFCC910
        public void CreateNullCipher(){} // RVA: 0x7FFAFBFCCA20
        public void CreateRC4Cipher(){} // RVA: 0x7FFAFBFCCAE0
        public void CreateSeedCipher(){} // RVA: 0x7FFAFBFCCC00
        public void CreateAesEngine(){} // RVA: 0x7FFAFBFCCD10
        public void CreateCamelliaEngine(){} // RVA: 0x7FFAFBFCCD50
        public void CreateAesBlockCipher(){} // RVA: 0x7FFAFBFCCDA0
        public void CreateAeadBlockCipher_Aes_Ccm(){} // RVA: 0x7FFAFBFCCE20
        public void CreateAeadBlockCipher_Aes_Gcm(){} // RVA: 0x7FFAFBFCCEA0
        public void CreateAeadBlockCipher_Aes_Ocb(){} // RVA: 0x7FFAFBFCCF20
        public void CreateAeadBlockCipher_Camellia_Gcm(){} // RVA: 0x7FFAFBFCCFC0
        public void CreateCamelliaBlockCipher(){} // RVA: 0x7FFAFBFCD040
        public void CreateDesEdeBlockCipher(){} // RVA: 0x7FFAFBFCD0C0
        public void CreateRC4StreamCipher(){} // RVA: 0x7FFAFBFCD170
        public void CreateSeedBlockCipher(){} // RVA: 0x7FFAFBFCD1B0
        public void CreateHMacDigest(){} // RVA: 0x7FFAFBFCD230
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DefaultTlsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFCD5E0 | overloaded x3
        public void GetCipherSuites(){} // RVA: 0x7FFAFBFCD690
        public void GetKeyExchange(){} // RVA: 0x7FFAFBFCD700
        public void CreateDHKeyExchange(){} // RVA: 0x7FFAFBFCD8B0
        public void CreateDheKeyExchange(){} // RVA: 0x7FFAFBFCD940
        public void CreateECDHKeyExchange(){} // RVA: 0x7FFAFBFCD9D0
        public void CreateECDheKeyExchange(){} // RVA: 0x7FFAFBFCDA70
        public void CreateRsaKeyExchange(){} // RVA: 0x7FFAFBFCDB10
    }

    public class DefaultTlsDHVerifier
    {
        // ── Methods ──
        public void AddDefaultGroup(){} // RVA: 0x7FFAFBFCDBB0
        public void .cctor(){} // RVA: 0x7FFAFBFCDC40
        public void .ctor(){} // RVA: 0x7FFAF4816A50 | overloaded x3
        public void Accept(){} // RVA: 0x7FFAFBFCE530
        public void get_MinimumPrimeBits(){} // RVA: 0x7FFAF306ED50
        public void AreGroupsEqual(){} // RVA: 0x7FFAFBFCE590
        public void AreParametersEqual(){} // RVA: 0x7FFAFBFCE630
        public void CheckGroup(){} // RVA: 0x7FFAFBFCE670
        public void CheckMinimumPrimeBits(){} // RVA: 0x7FFAFBFCE870
    }

    public class DefaultTlsEncryptionCredentials
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFCE8D0
        public void get_Certificate(){} // RVA: 0x7FFAF2D907C0
        public void DecryptPreMasterSecret(){} // RVA: 0x7FFAFBFCEB90
    }

    public class DefaultTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void GetDsaSignerCredentials(){} // RVA: 0x7FFAFBFCEC20
        public void GetECDsaSignerCredentials(){} // RVA: 0x7FFAFBFCEC70
        public void GetRsaEncryptionCredentials(){} // RVA: 0x7FFAFBFCECC0
        public void GetRsaSignerCredentials(){} // RVA: 0x7FFAFBFCED10
        public void GetDHParameters(){} // RVA: 0x7FFAFBFCED60
        public void GetCipherSuites(){} // RVA: 0x7FFAFBFCEDC0
        public void GetCredentials(){} // RVA: 0x7FFAFBFCEE30
        public void GetKeyExchange(){} // RVA: 0x7FFAFBFCEFA0
        public void CreateDHKeyExchange(){} // RVA: 0x7FFAFBFCF150
        public void CreateDheKeyExchange(){} // RVA: 0x7FFAFBFCF1F0
        public void CreateECDHKeyExchange(){} // RVA: 0x7FFAFBFCF290
        public void CreateECDheKeyExchange(){} // RVA: 0x7FFAFBFCF330
        public void CreateRsaKeyExchange(){} // RVA: 0x7FFAFBFCF3D0
    }

    public class DefaultTlsSignerCredentials
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFCF490 | overloaded x2
        public void get_Certificate(){} // RVA: 0x7FFAF2D907C0
        public void GenerateCertificateSignature(){} // RVA: 0x7FFAFBFCF910
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x7FFAF2DBB130
    }

    public class DefaultTlsSrpGroupVerifier : .cctor
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFBFCFB20
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void Accept(){} // RVA: 0x7FFAFBFCFEB0
        public void AreGroupsEqual(){} // RVA: 0x7FFAFBFD0080
        public void AreParametersEqual(){} // RVA: 0x7FFAFBFCE630
    }

    public class DeferredHash
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFD02B0 | overloaded x2
        public void Init(){} // RVA: 0x7FFAF2D8EE30
        public void NotifyPrfDetermined(){} // RVA: 0x7FFAFBFD0480
        public void TrackHashAlgorithm(){} // RVA: 0x7FFAFBFD05D0
        public void SealHashAlgorithms(){} // RVA: 0x7FFAFBFD0650
        public void StopTracking(){} // RVA: 0x7FFAFBFD0670
        public void ForkPrfHash(){} // RVA: 0x7FFAFBFD0800
        public void GetFinalHash(){} // RVA: 0x7FFAFBFD0980
        public void get_AlgorithmName(){} // RVA: 0x7FFAFBFD0B60
        public void GetByteLength(){} // RVA: 0x7FFAFBFD0BB0
        public void GetDigestSize(){} // RVA: 0x7FFAFBFD0C00
        public void Update(){} // RVA: 0x7FFAFBFD0C50
        public void BlockUpdate(){} // RVA: 0x7FFAFBFD0F90
        public void DoFinal(){} // RVA: 0x7FFAFBFD12E0
        public void Reset(){} // RVA: 0x7FFAFBFD1330
        public void CheckStopBuffering(){} // RVA: 0x7FFAFBFD1650
        public void CheckTrackingHash(){} // RVA: 0x7FFAFBFD1960
    }

    public class DigestInputBuffer
    {
        // ── Methods ──
        public void UpdateDigest(){} // RVA: 0x7FFAFBFD1A80
        public void .ctor(){} // RVA: 0x7FFAFBFD1B80
    }

    public class DigitallySigned
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFD1D20
        public void get_Algorithm(){} // RVA: 0x7FFAF2DA8380
        public void get_Signature(){} // RVA: 0x7FFAF2D907C0
        public void Encode(){} // RVA: 0x7FFAFBFD1E30
        public void Parse(){} // RVA: 0x7FFAFBFD1EC0
    }

    public class DtlsClientProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFD1F90
        public void Connect(){} // RVA: 0x7FFAFBFD2040
        public void AbortClientHandshake(){} // RVA: 0x7FFAFBFD2600
        public void ClientHandshake(){} // RVA: 0x7FFAFBFD2660
        public void GenerateCertificateVerify(){} // RVA: 0x7FFAFBFD3690
        public void GenerateClientHello(){} // RVA: 0x7FFAFBFD3730
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFAFBFD3FB0
        public void InvalidateSession(){} // RVA: 0x7FFAFBFD4060
        public void ProcessCertificateRequest(){} // RVA: 0x7FFAFBFD4190
        public void ProcessCertificateStatus(){} // RVA: 0x7FFAFBFD4340
        public void ProcessHelloVerifyRequest(){} // RVA: 0x7FFAFBFD44D0
        public void ProcessNewSessionTicket(){} // RVA: 0x7FFAFBFD4790
        public void ProcessServerCertificate(){} // RVA: 0x7FFAFBFD48B0
        public void ProcessServerHello(){} // RVA: 0x7FFAFBFD4AC0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFAFBFD5670
        public void ProcessServerSupplementalData(){} // RVA: 0x7FFAFBFD57A0
        public void ReportServerVersion(){} // RVA: 0x7FFAFBFD5850
        public void PatchClientHelloWithCookie(){} // RVA: 0x7FFAFBFD5950
    }

    public class DtlsEpoch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFD5AA0
        public void AllocateSequenceNumber(){} // RVA: 0x7FFAFBFD5C60
        public void get_Cipher(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Epoch(){} // RVA: 0x7FFAF306ED50
        public void get_ReplayWindow(){} // RVA: 0x7FFAF2DA8380
        public void get_SequenceNumber(){} // RVA: 0x7FFAFBFD5E00
    }

    public class DtlsHandshakeRetransmit
    {
        // ── Methods ──
        public void ReceivedHandshakeRecord(){}
    }

    public class DtlsProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFD1F90
        public void ProcessFinished(){} // RVA: 0x7FFAFBFD5F40
        public void ApplyMaxFragmentLengthExtension(){} // RVA: 0x7FFAFBFD6130
        public void EvaluateMaxFragmentLengthExtension(){} // RVA: 0x7FFAFBFD61D0
        public void GenerateCertificate(){} // RVA: 0x7FFAFBFD6280
        public void GenerateSupplementalData(){} // RVA: 0x7FFAFBFD6320
        public void ValidateSelectedCipherSuite(){} // RVA: 0x7FFAFBFD63B0
    }

    public class DtlsReassembler
    {
        public object ReadEpoch;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFD6450
        public void get_MsgType(){} // RVA: 0x7FFAF2E575E0
        public void GetBodyIfComplete(){} // RVA: 0x7FFAFBFD6620
        public void ContributeFragment(){} // RVA: 0x7FFAFBFD6680
        public void Reset(){} // RVA: 0x7FFAFBFD69D0
    }

    public class DtlsRecordLayer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFD6A80
        public void SetPlaintextLimit(){} // RVA: 0x7FFAFBFD6E00
        public void get_ReadEpoch(){} // RVA: 0x7FFAFBFD6E10
        public void get_ReadVersion(){} // RVA: 0x7FFAFBFD6E30
        public void set_ReadVersion(){} // RVA: 0x7FFAFBFD6E40
        public void SetWriteVersion(){} // RVA: 0x7FFAF8EC7A90
        public void InitPendingEpoch(){} // RVA: 0x7FFAFBFD6EA0
        public void HandshakeSuccessful(){} // RVA: 0x7FFAFBFD6FB0
        public void ResetWriteEpoch(){} // RVA: 0x7FFAFBFD7140
        public void GetReceiveLimit(){} // RVA: 0x7FFAFBFD7210
        public void GetSendLimit(){} // RVA: 0x7FFAFBFD72E0
        public void Receive(){} // RVA: 0x7FFAFBFD73C0
        public void Send(){} // RVA: 0x7FFAFBFD7DE0
        public void Close(){} // RVA: 0x7FFAFBFD7FD0
        public void Failed(){} // RVA: 0x7FFAFBFD8050
        public void Fail(){} // RVA: 0x7FFAFBFD8080
        public void Warn(){} // RVA: 0x7FFAFBFD80E0
        public void CloseTransport(){} // RVA: 0x7FFAFBFD8110
        public void RaiseAlert(){} // RVA: 0x7FFAFBFD81B0
        public void ReceiveRecord(){} // RVA: 0x7FFAFBFD82A0
        public void SendRecord(){} // RVA: 0x7FFAFBFD8580
        public void GetMacSequenceNumber(){} // RVA: 0x7FFAFBFD88D0
    }

    public class DtlsReliableHandshake
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFD88E0
        public void NotifyHelloComplete(){} // RVA: 0x7FFAFBFD8B70
        public void get_HandshakeHash(){} // RVA: 0x7FFAF2D907C0
        public void PrepareToFinish(){} // RVA: 0x7FFAFBFD8C10
        public void SendMessage(){} // RVA: 0x7FFAFBFD8CC0
        public void ReceiveMessageBody(){} // RVA: 0x7FFAFBFD8E40
        public void ReceiveMessage(){} // RVA: 0x7FFAFBFD8EB0
        public void Finish(){} // RVA: 0x7FFAFBFD9140
        public void ResetHandshakeMessagesDigest(){} // RVA: 0x7FFAFBFD9220
        public void BackOff(){} // RVA: 0x7FFAFBFD9270
        public void CheckInboundFlight(){} // RVA: 0x7FFAFBFD92D0
        public void GetPendingMessage(){} // RVA: 0x7FFAFBFD94E0
        public void PrepareInboundFlight(){} // RVA: 0x7FFAFBFD96F0
        public void ProcessRecord(){} // RVA: 0x7FFAFBFD97D0
        public void ResendOutboundFlight(){} // RVA: 0x7FFAFBFD9CB0
        public void UpdateHandshakeMessagesDigest(){} // RVA: 0x7FFAFBFD9EE0
        public void WriteMessage(){} // RVA: 0x7FFAFBFDA0E0
        public void WriteHandshakeFragment(){} // RVA: 0x7FFAFBFDA220
        public void CheckAll(){} // RVA: 0x7FFAFBFDA500
        public void ResetAll(){} // RVA: 0x7FFAFBFDA750
    }

    public class DtlsReplayWindow
    {
        // ── Methods ──
        public void ShouldDiscard(){} // RVA: 0x7FFAFBFDABE0
        public void ReportAuthenticated(){} // RVA: 0x7FFAFBFDAC30
        public void Reset(){} // RVA: 0x7FFAFBFDAD20
        public void .ctor(){} // RVA: 0x7FFAFBFDAD40
    }

    public class DtlsServerProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFDAD50
        public void get_VerifyRequests(){} // RVA: 0x7FFAF2DA84E0
        public void set_VerifyRequests(){} // RVA: 0x7FFAF2DA84F0
        public void Accept(){} // RVA: 0x7FFAFBFDAE00
        public void AbortServerHandshake(){} // RVA: 0x7FFAFBFDB330
        public void ServerHandshake(){} // RVA: 0x7FFAFBFDB390
        public void InvalidateSession(){} // RVA: 0x7FFAFBFDBF30
        public void GenerateCertificateRequest(){} // RVA: 0x7FFAFBFDC060
        public void GenerateCertificateStatus(){} // RVA: 0x7FFAFBFDC100
        public void GenerateNewSessionTicket(){} // RVA: 0x7FFAFBFDC1A0
        public void GenerateServerHello(){} // RVA: 0x7FFAFBFDC240
        public void NotifyClientCertificate(){} // RVA: 0x7FFAFBFDCAB0
        public void ProcessClientCertificate(){} // RVA: 0x7FFAFBFDCCD0
        public void ProcessCertificateVerify(){} // RVA: 0x7FFAFBFDCE20
        public void ProcessClientHello(){} // RVA: 0x7FFAFBFDD280
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFAFBFDD8D0
        public void ProcessClientSupplementalData(){} // RVA: 0x7FFAFBFDDA00
        public void ExpectCertificateVerifyMessage(){} // RVA: 0x7FFAFBFDDAB0
    }

    public class DtlsTransport : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetReceiveLimit(){} // RVA: 0x7FFAF32A0150
        public void GetSendLimit(){} // RVA: 0x7FFAF32A0370
        public void Receive(){} // RVA: 0x7FFAFBFDDB40
        public void Send(){} // RVA: 0x7FFAFBFDDCC0
        public void Close(){} // RVA: 0x7FFAF8EA6270
    }

}