// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 59
// Methods: 612

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class TlsAeadCipher : Object
    {
        public object NONCE_RFC5288;
        public object NONCE_DRAFT_CHACHA20_POLY1305;
        public object context;
        public object macSize;
        public object record_iv_length;
        public object encryptCipher;
        public object decryptCipher;
        public object encryptImplicitNonce;
        public object decryptImplicitNonce;
        public object nonceMode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D93F0
        public void GetPlaintextLimit(){} // RVA: 0xA1D98B0
        public void EncodePlaintext(){} // RVA: 0xA1D98C0
        public void DecodeCiphertext(){} // RVA: 0xA1D9CF0
        public void GetAdditionalData(){} // RVA: 0xA1DA150
    }

    public class TlsAgreementCredentials
    {
        // ── Methods ──
        public void GenerateAgreement(){} // RVA: 0x87C540
    }

    public class TlsAuthentication
    {
        // ── Methods ──
        public void NotifyServerCertificate(){} // RVA: 0x894320
        public void GetClientCredentials(){} // RVA: 0x87C5F0
    }

    public class TlsBlockCipher : Object
    {
        public object context;
        public object randomData;
        public object useExplicitIV;
        public object encryptThenMac;
        public object encryptCipher;
        public object decryptCipher;
        public object mWriteMac;
        public object mReadMac;
        public object explicitIV;

        // ── Methods ──
        public void get_WriteMac(){} // RVA: 0xD05CA0
        public void get_ReadMac(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0xA1DA280
        public void GetPlaintextLimit(){} // RVA: 0xA1DABD0
        public void EncodePlaintext(){} // RVA: 0xA1DACA0
        public void DecodeCiphertext(){} // RVA: 0xA1DB1E0
        public void CheckPaddingConstantTime(){} // RVA: 0xA1DB7E0
        public void ChooseExtraPadBlocks(){} // RVA: 0xA1DB970
        public void LowestBitSet(){} // RVA: 0xA1DBA20
    }

    public class TlsCipher
    {
        // ── Methods ──
        public void GetPlaintextLimit(){} // RVA: 0x881C20
        public void EncodePlaintext(){} // RVA: 0x88CB10
        public void DecodeCiphertext(){} // RVA: 0x88CB10
    }

    public class TlsCipherFactory
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0x87D1E0
    }

    public class TlsClient
    {
        // ── Methods ──
        public void get_HostNames(){} // RVA: 0x87C0A0
        public void set_HostNames(){} // RVA: 0x894320
        public void Init(){} // RVA: 0x894320
        public void GetSessionToResume(){} // RVA: 0x87C0A0
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0x87C0A0
        public void get_ClientVersion(){} // RVA: 0x87C0A0
        public void get_IsFallback(){} // RVA: 0x87D280
        public void GetCipherSuites(){} // RVA: 0x87C0A0
        public void GetCompressionMethods(){} // RVA: 0x87C0A0
        public void GetClientExtensions(){} // RVA: 0x87C0A0
        public void NotifyServerVersion(){} // RVA: 0x894320
        public void NotifySessionID(){} // RVA: 0x894320
        public void NotifySelectedCipherSuite(){} // RVA: 0x8944F0
        public void NotifySelectedCompressionMethod(){} // RVA: 0x894750
        public void ProcessServerExtensions(){} // RVA: 0x894320
        public void ProcessServerSupplementalData(){} // RVA: 0x894320
        public void GetKeyExchange(){} // RVA: 0x87C0A0
        public void GetAuthentication(){} // RVA: 0x87C0A0
        public void GetClientSupplementalData(){} // RVA: 0x87C0A0
        public void NotifyNewSessionTicket(){} // RVA: 0x894320
    }

    public class TlsClientContextImpl : AbstractTlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1DBA40
        public void get_IsServer(){} // RVA: 0xB43320
    }

    public class TlsClientProtocol : TlsProtocol
    {
        public object mTlsClient;
        public object mTlsClientContext;
        public object mSelectedSessionID;
        public object mKeyExchange;
        public object mAuthentication;
        public object mCertificateStatus;
        public object mCertificateRequest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1DBAE0
        public void Connect(){} // RVA: 0xA1DBAF0
        public void CleanupHandshake(){} // RVA: 0xA1DBF40
        public void get_Context(){} // RVA: 0xBAE340
        public void get_ContextAdmin(){} // RVA: 0xBAE340
        public void get_Peer(){} // RVA: 0x12EB090
        public void HandleHandshakeMessage(){} // RVA: 0xA1DC120
        public void HandleSupplementalData(){} // RVA: 0xA1DD250
        public void ReceiveNewSessionTicketMessage(){} // RVA: 0xA1DD380
        public void ReceiveServerHelloMessage(){} // RVA: 0xA1DD470
        public void SendCertificateVerifyMessage(){} // RVA: 0xA1DE1E0
        public void SendClientHelloMessage(){} // RVA: 0xA1DE280
        public void SendClientKeyExchangeMessage(){} // RVA: 0xA1DEC00
    }

    public class TlsCompression
    {
        // ── Methods ──
        public void Compress(){} // RVA: 0x87C540
        public void Decompress(){} // RVA: 0x87C540
    }

    public class TlsContext
    {
        // ── Methods ──
        public void get_NonceRandomGenerator(){} // RVA: 0x87C0A0
        public void get_SecureRandom(){} // RVA: 0x87C0A0
        public void get_SecurityParameters(){} // RVA: 0x87C0A0
        public void get_IsServer(){} // RVA: 0x87D280
        public void get_ClientVersion(){} // RVA: 0x87C0A0
        public void get_ServerVersion(){} // RVA: 0x87C0A0
        public void get_ResumableSession(){} // RVA: 0x87C0A0
        public void get_UserObject(){} // RVA: 0x87C0A0
        public void set_UserObject(){} // RVA: 0x894320
        public void ExportKeyingMaterial(){} // RVA: 0x88E290
    }

    public class TlsCredentials
    {
        // ── Methods ──
        public void get_Certificate(){} // RVA: 0x87C0A0
    }

    public class TlsDHKeyExchange : AbstractTlsKeyExchange
    {
        public object mTlsSigner;
        public object mDHVerifier;
        public object mDHParameters;
        public object mServerPublicKey;
        public object mAgreementCredentials;
        public object mDHAgreePrivateKey;
        public object mDHAgreePublicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1DFBE0
        public void Init(){} // RVA: 0xA1DFE40
        public void SkipServerCredentials(){} // RVA: 0xA1DFEB0
        public void ProcessServerCertificate(){} // RVA: 0xA1DFF10
        public void get_RequiresServerKeyExchange(){} // RVA: 0xA1E02A0
        public void GenerateServerKeyExchange(){} // RVA: 0xA1E02C0
        public void ProcessServerKeyExchange(){} // RVA: 0xA1E0420
        public void ValidateCertificateRequest(){} // RVA: 0xA1E0600
        public void ProcessClientCredentials(){} // RVA: 0xA1E0700
        public void GenerateClientKeyExchange(){} // RVA: 0xA1E08B0
        public void ProcessClientCertificate(){} // RVA: 0xA1E09C0
        public void ProcessClientKeyExchange(){} // RVA: 0xA1E0A20
        public void GeneratePremasterSecret(){} // RVA: 0xA1E0B20
    }

    public class TlsDHUtilities : Object
    {
        public object Two;
        public object draft_ffdhe2432_p;
        public object draft_ffdhe2432;
        public object draft_ffdhe3072_p;
        public object draft_ffdhe3072;
        public object draft_ffdhe4096_p;
        public object draft_ffdhe4096;
        public object draft_ffdhe6144_p;
        public object draft_ffdhe6144;
        public object draft_ffdhe8192_p;
        public object draft_ffdhe8192;

        // ── Methods ──
        public void FromHex(){} // RVA: 0xA1E0C00
        public void FromSafeP(){} // RVA: 0xA1E0CB0
        public void AddNegotiatedDheGroupsClientExtension(){} // RVA: 0xA1E0E10
        public void AddNegotiatedDheGroupsServerExtension(){} // RVA: 0xA1E0F90
        public void GetNegotiatedDheGroupsClientExtension(){} // RVA: 0xA1E10C0
        public void GetNegotiatedDheGroupsServerExtension(){} // RVA: 0xA1E1220
        public void CreateNegotiatedDheGroupsClientExtension(){} // RVA: 0xA1E1340
        public void CreateNegotiatedDheGroupsServerExtension(){} // RVA: 0xA1E13E0
        public void ReadNegotiatedDheGroupsClientExtension(){} // RVA: 0xA1E1430
        public void ReadNegotiatedDheGroupsServerExtension(){} // RVA: 0xA1E14D0
        public void GetParametersForDHEGroup(){} // RVA: 0xA1E1520
        public void ContainsDheCipherSuites(){} // RVA: 0xA1E1670
        public void IsDheCipherSuite(){} // RVA: 0xA1E1980
        public void AreCompatibleParameters(){} // RVA: 0xA1E1BE0
        public void CalculateDHBasicAgreement(){} // RVA: 0xA1E1CB0
        public void GenerateDHKeyPair(){} // RVA: 0xA1E1D60
        public void GenerateEphemeralClientKeyExchange(){} // RVA: 0xA1E1E30
        public void GenerateEphemeralServerKeyExchange(){} // RVA: 0xA1E1FD0
        public void ReadDHParameter(){} // RVA: 0xA1E2290
        public void ReadDHParameters(){} // RVA: 0xA1E2340
        public void ReceiveDHParameters(){} // RVA: 0xA1E23F0
        public void WriteDHParameter(){} // RVA: 0xA1E25B0
        public void WriteDHParameters(){} // RVA: 0xA1E2630
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA1E2760
    }

    public class TlsDHVerifier
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0x87D350
    }

    public class TlsDeflateCompression : Object
    {
        public object LEVEL_NONE;
        public object LEVEL_FASTEST;
        public object LEVEL_SMALLEST;
        public object LEVEL_DEFAULT;
        public object zIn;
        public object zOut;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1DEE20
        public void Compress(){} // RVA: 0xA1DEFB0
        public void Decompress(){} // RVA: 0xA1DF040
    }

    public class TlsDheKeyExchange : TlsDHKeyExchange
    {
        public object mServerCredentials;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1DF1C0
        public void ProcessServerCredentials(){} // RVA: 0xA1DF1D0
        public void GenerateServerKeyExchange(){} // RVA: 0xA1DF350
        public void ProcessServerKeyExchange(){} // RVA: 0xA1DF710
        public void InitVerifyer(){} // RVA: 0xA1DFA40
    }

    public class TlsDsaSigner : AbstractTlsSigner
    {
        // ── Methods ──
        public void GenerateRawSignature(){} // RVA: 0xA1E2D40
        public void VerifyRawSignature(){} // RVA: 0xA1E2FD0
        public void CreateSigner(){} // RVA: 0xA1E30D0
        public void CreateVerifyer(){} // RVA: 0xA1E3100
        public void MakeInitParameters(){} // RVA: 0x2702130
        public void MakeSigner(){} // RVA: 0xA1E3130
        public void get_SignatureAlgorithm(){} // RVA: 0x87D280
        public void CreateDsaImpl(){} // RVA: 0x881D20
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TlsDssSigner : TlsDsaSigner
    {
        // ── Methods ──
        public void IsValidPublicKey(){} // RVA: 0xA1E33A0
        public void CreateDsaImpl(){} // RVA: 0xA1E3420
        public void get_SignatureAlgorithm(){} // RVA: 0x40A00B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TlsECDHKeyExchange : AbstractTlsKeyExchange
    {
        public object mTlsSigner;
        public object mNamedCurves;
        public object mClientECPointFormats;
        public object mServerECPointFormats;
        public object mServerPublicKey;
        public object mAgreementCredentials;
        public object mECAgreePrivateKey;
        public object mECAgreePublicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1E7940
        public void Init(){} // RVA: 0xA1E7BE0
        public void SkipServerCredentials(){} // RVA: 0xA1E7C50
        public void ProcessServerCertificate(){} // RVA: 0xA1E7CB0
        public void get_RequiresServerKeyExchange(){} // RVA: 0xA1E8010
        public void GenerateServerKeyExchange(){} // RVA: 0xA1E8030
        public void ProcessServerKeyExchange(){} // RVA: 0xA1E81B0
        public void ValidateCertificateRequest(){} // RVA: 0xA1E8320
        public void ProcessClientCredentials(){} // RVA: 0xA1E8420
        public void GenerateClientKeyExchange(){} // RVA: 0xA1E85D0
        public void ProcessClientCertificate(){} // RVA: 0xA1E86F0
        public void ProcessClientKeyExchange(){} // RVA: 0xA1E8750
        public void GeneratePremasterSecret(){} // RVA: 0xA1E8870
    }

    public class TlsECDheKeyExchange : TlsECDHKeyExchange
    {
        public object mServerCredentials;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1E6EA0
        public void ProcessServerCredentials(){} // RVA: 0xA1E6EB0
        public void GenerateServerKeyExchange(){} // RVA: 0xA1E7030
        public void ProcessServerKeyExchange(){} // RVA: 0xA1E7420
        public void ValidateCertificateRequest(){} // RVA: 0xA1E7700
        public void ProcessClientCredentials(){} // RVA: 0xA1E77C0
        public void InitVerifyer(){} // RVA: 0xA1E7840
    }

    public class TlsECDsaSigner : TlsDsaSigner
    {
        // ── Methods ──
        public void IsValidPublicKey(){} // RVA: 0xA1E8950
        public void CreateDsaImpl(){} // RVA: 0xA1E89D0
        public void get_SignatureAlgorithm(){} // RVA: 0x6AF1170
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TlsEccUtilities : Object
    {
        public object CurveNames;

        // ── Methods ──
        public void AddSupportedEllipticCurvesExtension(){} // RVA: 0xA1E3520
        public void AddSupportedPointFormatsExtension(){} // RVA: 0xA1E3660
        public void GetSupportedEllipticCurvesExtension(){} // RVA: 0xA1E3860
        public void GetSupportedPointFormatsExtension(){} // RVA: 0xA1E3900
        public void CreateSupportedEllipticCurvesExtension(){} // RVA: 0xA1E39A0
        public void CreateSupportedPointFormatsExtension(){} // RVA: 0xA1E3A40
        public void ReadSupportedEllipticCurvesExtension(){} // RVA: 0xA1E3BB0
        public void ReadSupportedPointFormatsExtension(){} // RVA: 0xA1E3D90
        public void GetNameOfNamedCurve(){} // RVA: 0xA1E3E80
        public void GetParametersForNamedCurve(){} // RVA: 0xA1E3F30
        public void HasAnySupportedNamedCurves(){} // RVA: 0xA1E4280
        public void ContainsEccCipherSuites(){} // RVA: 0xA1E42F0
        public void IsEccCipherSuite(){} // RVA: 0xA1E43A0
        public void AreOnSameCurve(){} // RVA: 0xA1E4430
        public void IsSupportedNamedCurve(){} // RVA: 0xA1E4450
        public void IsCompressionPreferred(){} // RVA: 0xA1E44D0
        public void SerializeECFieldElement(){} // RVA: 0xA1E4520
        public void SerializeECPoint(){} // RVA: 0xA1E4540
        public void SerializeECPublicKey(){} // RVA: 0xA1E4700
        public void DeserializeECFieldElement(){} // RVA: 0xA1E4770
        public void DeserializeECPoint(){} // RVA: 0xA1E4840
        public void DeserializeECPublicKey(){} // RVA: 0xA1E4A90
        public void CalculateECDHBasicAgreement(){} // RVA: 0xA1E4BE0
        public void GenerateECKeyPair(){} // RVA: 0xA1E4CA0
        public void GenerateEphemeralClientKeyExchange(){} // RVA: 0xA1E4D90
        public void GenerateEphemeralServerKeyExchange(){} // RVA: 0xA1E5080
        public void ValidateECPublicKey(){} // RVA: 0x2303260
        public void ReadECExponent(){} // RVA: 0xA1E5410
        public void ReadECFieldElement(){} // RVA: 0xA1E5510
        public void ReadECParameter(){} // RVA: 0xA1E5650
        public void ReadECParameters(){} // RVA: 0xA1E5700
        public void CheckNamedCurve(){} // RVA: 0xA1E5D80
        public void WriteECExponent(){} // RVA: 0xA1E5E40
        public void WriteECFieldElement(){} // RVA: 0xA1E5FE0
        public void WriteECParameter(){} // RVA: 0xA1E6110
        public void WriteExplicitECParameters(){} // RVA: 0xA1E6200
        public void WriteECPoint(){} // RVA: 0xA1E67B0
        public void WriteNamedECParameters(){} // RVA: 0xA1E68D0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA1E69D0
    }

    public class TlsEncryptionCredentials
    {
        // ── Methods ──
        public void DecryptPreMasterSecret(){} // RVA: 0x87C540
    }

    public class TlsException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x689ED90
    }

    public class TlsExtensionsUtilities : Object
    {
        // ── Methods ──
        public void EnsureExtensionsInitialised(){} // RVA: 0xA1E8AD0
        public void AddClientCertificateTypeExtensionClient(){} // RVA: 0xA1E8B70
        public void AddClientCertificateTypeExtensionServer(){} // RVA: 0xA1E8C10
        public void AddEncryptThenMacExtension(){} // RVA: 0xA1E8CE0
        public void AddExtendedMasterSecretExtension(){} // RVA: 0xA1E8DB0
        public void AddHeartbeatExtension(){} // RVA: 0xA1E8E80
        public void AddMaxFragmentLengthExtension(){} // RVA: 0xA1E8FD0
        public void AddPaddingExtension(){} // RVA: 0xA1E90A0
        public void AddServerCertificateTypeExtensionClient(){} // RVA: 0xA1E9190
        public void AddServerCertificateTypeExtensionServer(){} // RVA: 0xA1E9230
        public void AddServerNameExtension(){} // RVA: 0xA1E9300
        public void AddStatusRequestExtension(){} // RVA: 0xA1E94D0
        public void AddTruncatedHMacExtension(){} // RVA: 0xA1E9620
        public void GetClientCertificateTypeExtensionClient(){} // RVA: 0xA1E96F0
        public void GetClientCertificateTypeExtensionServer(){} // RVA: 0xA1E9760
        public void GetHeartbeatExtension(){} // RVA: 0xA1E9810
        public void GetMaxFragmentLengthExtension(){} // RVA: 0xA1E9880
        public void GetPaddingExtension(){} // RVA: 0xA1E9930
        public void GetServerCertificateTypeExtensionClient(){} // RVA: 0xA1E9A10
        public void GetServerCertificateTypeExtensionServer(){} // RVA: 0xA1E9A80
        public void GetServerNameExtension(){} // RVA: 0xA1E9B30
        public void GetStatusRequestExtension(){} // RVA: 0xA1E9C80
        public void HasEncryptThenMacExtension(){} // RVA: 0xA1E9DD0
        public void HasExtendedMasterSecretExtension(){} // RVA: 0xA1E9E80
        public void HasTruncatedHMacExtension(){} // RVA: 0xA1E9F30
        public void CreateCertificateTypeExtensionClient(){} // RVA: 0xA1E9FE0
        public void CreateCertificateTypeExtensionServer(){} // RVA: 0xA1EA080
        public void CreateEmptyExtensionData(){} // RVA: 0xA1EA0D0
        public void CreateEncryptThenMacExtension(){} // RVA: 0xA1EA130
        public void CreateExtendedMasterSecretExtension(){} // RVA: 0xA1EA130
        public void CreateHeartbeatExtension(){} // RVA: 0xA1EA190
        public void CreateMaxFragmentLengthExtension(){} // RVA: 0xA1EA260
        public void CreatePaddingExtension(){} // RVA: 0xA1EA2B0
        public void CreateServerNameExtension(){} // RVA: 0xA1EA320
        public void CreateStatusRequestExtension(){} // RVA: 0xA1EA3F0
        public void CreateTruncatedHMacExtension(){} // RVA: 0xA1EA130
        public void ReadEmptyExtensionData(){} // RVA: 0xA1EA4C0
        public void ReadCertificateTypeExtensionClient(){} // RVA: 0xA1EA560
        public void ReadCertificateTypeExtensionServer(){} // RVA: 0xA1EA600
        public void ReadEncryptThenMacExtension(){} // RVA: 0xA1EA4C0
        public void ReadExtendedMasterSecretExtension(){} // RVA: 0xA1EA4C0
        public void ReadHeartbeatExtension(){} // RVA: 0xA1EA650
        public void ReadMaxFragmentLengthExtension(){} // RVA: 0xA1EA890
        public void ReadPaddingExtension(){} // RVA: 0xA1EA8E0
        public void ReadServerNameExtension(){} // RVA: 0xA1EA9B0
        public void ReadStatusRequestExtension(){} // RVA: 0xA1EAB00
        public void ReadTruncatedHMacExtension(){} // RVA: 0xA1EA4C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TlsFatalAlert : TlsException
    {
        public object alertDescription;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1EACA0
        public void get_AlertDescription(){} // RVA: 0x1C4D9A0
    }

    public class TlsFatalAlertReceived : TlsException
    {
        public object alertDescription;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1EAC50
        public void get_AlertDescription(){} // RVA: 0x1C4D9A0
    }

    public class TlsHandshakeHash
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894320
        public void NotifyPrfDetermined(){} // RVA: 0x87C0A0
        public void TrackHashAlgorithm(){} // RVA: 0x894750
        public void SealHashAlgorithms(){} // RVA: 0x894290
        public void StopTracking(){} // RVA: 0x87C0A0
        public void ForkPrfHash(){} // RVA: 0x87C0A0
        public void GetFinalHash(){} // RVA: 0x881D20
    }

    public class TlsKeyExchange
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894320
        public void SkipServerCredentials(){} // RVA: 0x894290
        public void ProcessServerCredentials(){} // RVA: 0x894320
        public void ProcessServerCertificate(){} // RVA: 0x894320
        public void get_RequiresServerKeyExchange(){} // RVA: 0x87D280
        public void GenerateServerKeyExchange(){} // RVA: 0x87C0A0
        public void SkipServerKeyExchange(){} // RVA: 0x894290
        public void ProcessServerKeyExchange(){} // RVA: 0x894320
        public void ValidateCertificateRequest(){} // RVA: 0x894320
        public void SkipClientCredentials(){} // RVA: 0x894290
        public void ProcessClientCredentials(){} // RVA: 0x894320
        public void ProcessClientCertificate(){} // RVA: 0x894320
        public void GenerateClientKeyExchange(){} // RVA: 0x894320
        public void ProcessClientKeyExchange(){} // RVA: 0x894320
        public void GeneratePremasterSecret(){} // RVA: 0x87C0A0
    }

    public class TlsMac : Object
    {
        public object context;
        public object secret;
        public object mac;
        public object digestBlockSize;
        public object digestOverhead;
        public object macLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1EAD00
        public void get_MacSecret(){} // RVA: 0xB465B0
        public void get_Size(){} // RVA: 0xB9E080
        public void CalculateMac(){} // RVA: 0xA1EB210
        public void CalculateMacConstantTime(){} // RVA: 0xA1EB520
        public void GetDigestBlockCount(){} // RVA: 0xA1EB750
        public void Truncate(){} // RVA: 0xA1EB760
    }

    public class TlsNoCloseNotifyException : EndOfStreamException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1EB7E0
    }

    public class TlsNullCipher : Object
    {
        public object context;
        public object writeMac;
        public object readMac;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1EB930
        public void GetPlaintextLimit(){} // RVA: 0xA1EBD60
        public void EncodePlaintext(){} // RVA: 0xA1EBD90
        public void DecodeCiphertext(){} // RVA: 0xA1EBEF0
    }

    public class TlsNullCompression : Object
    {
        // ── Methods ──
        public void Compress(){} // RVA: 0x1CB3B00
        public void Decompress(){} // RVA: 0x1CB3B00
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TlsPeer
    {
        // ── Methods ──
        public void RequiresExtendedMasterSecret(){} // RVA: 0x87D280
        public void ShouldUseGmtUnixTime(){} // RVA: 0x87D280
        public void NotifySecureRenegotiation(){} // RVA: 0x894750
        public void GetCompression(){} // RVA: 0x87C0A0
        public void GetCipher(){} // RVA: 0x87C0A0
        public void NotifyAlertRaised(){} // RVA: 0x894CE0
        public void NotifyAlertReceived(){} // RVA: 0x8949A0
        public void NotifyHandshakeComplete(){} // RVA: 0x894290
    }

    public class TlsProtocol : Object
    {
        public object CS_START;
        public object CS_CLIENT_HELLO;
        public object CS_SERVER_HELLO;
        public object CS_SERVER_SUPPLEMENTAL_DATA;
        public object CS_SERVER_CERTIFICATE;
        public object CS_CERTIFICATE_STATUS;
        public object CS_SERVER_KEY_EXCHANGE;
        public object CS_CERTIFICATE_REQUEST;
        public object CS_SERVER_HELLO_DONE;
        public object CS_CLIENT_SUPPLEMENTAL_DATA;
        public object CS_CLIENT_CERTIFICATE;
        public object CS_CLIENT_KEY_EXCHANGE;
        public object CS_CERTIFICATE_VERIFY;
        public object CS_CLIENT_FINISHED;
        public object CS_SERVER_SESSION_TICKET;
        public object CS_SERVER_FINISHED;
        public object CS_END;
        public object ADS_MODE_1_Nsub1;
        public object ADS_MODE_0_N;
        public object ADS_MODE_0_N_FIRSTONLY;
        public object mApplicationDataQueue;
        public object mAlertQueue;
        public object mHandshakeQueue;
        public object mRecordStream;
        public object mSecureRandom;
        public object mTlsStream;
        public object mClosed;
        public object mFailedWithError;
        public object mAppDataReady;
        public object mAppDataSplitEnabled;
        public object mAppDataSplitMode;
        public object mExpectedVerifyData;
        public object mTlsSession;
        public object mSessionParameters;
        public object mSecurityParameters;
        public object mPeerCertificate;
        public object mOfferedCipherSuites;
        public object mOfferedCompressionMethods;
        public object mClientExtensions;
        public object mServerExtensions;
        public object mConnectionState;
        public object mResumedSession;
        public object mReceivedChangeCipherSpec;
        public object mSecureRenegotiation;
        public object mAllowCertificateStatus;
        public object mExpectSessionTicket;
        public object mBlocking;
        public object mInputBuffers;
        public object mOutputBuffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1EC5E0
        public void get_Context(){} // RVA: 0x87C0A0
        public void get_ContextAdmin(){} // RVA: 0x87C0A0
        public void get_Peer(){} // RVA: 0x87C0A0
        public void HandleAlertMessage(){} // RVA: 0xA1ECB60
        public void HandleAlertWarningMessage(){} // RVA: 0xA1ECC50
        public void HandleChangeCipherSpecMessage(){} // RVA: 0xB43310
        public void HandleClose(){} // RVA: 0xA1ECCD0
        public void HandleException(){} // RVA: 0xA1ECDC0
        public void HandleFailure(){} // RVA: 0xA1ECE20
        public void HandleHandshakeMessage(){} // RVA: 0x894DF0
        public void ApplyMaxFragmentLengthExtension(){} // RVA: 0xA1ECEA0
        public void CheckReceivedChangeCipherSpec(){} // RVA: 0xA1ECF50
        public void CleanupHandshake(){} // RVA: 0xA1ECFB0
        public void BlockForHandshake(){} // RVA: 0xA1ED2C0
        public void CompleteHandshake(){} // RVA: 0xA1ED350
        public void ProcessRecord(){} // RVA: 0xA1EDA50
        public void ProcessHandshakeQueue(){} // RVA: 0xA1EDED0
        public void ProcessApplicationDataQueue(){} // RVA: 0xB43310
        public void ProcessAlertQueue(){} // RVA: 0xA1EE150
        public void ProcessChangeCipherSpec(){} // RVA: 0xA1EE250
        public void ApplicationDataAvailable(){} // RVA: 0x2300BB0
        public void ReadApplicationData(){} // RVA: 0xA1EE3E0
        public void SafeCheckRecordHeader(){} // RVA: 0xA1EE5B0
        public void SafeReadRecord(){} // RVA: 0xA1EE710
        public void SafeWriteRecord(){} // RVA: 0xA1EE930
        public void WriteData(){} // RVA: 0xA1EEAA0
        public void SetAppDataSplitMode(){} // RVA: 0xA1EECA0
        public void WriteHandshakeMessage(){} // RVA: 0xA1EED50
        public void get_Stream(){} // RVA: 0xA1EEF00
        public void CloseInput(){} // RVA: 0xA1EEF70
        public void OfferInput(){} // RVA: 0xA1EF0D0
        public void GetAvailableInputBytes(){} // RVA: 0xA1EF390
        public void ReadInput(){} // RVA: 0xA1EF410
        public void OfferOutput(){} // RVA: 0xA1EF520
        public void GetAvailableOutputBytes(){} // RVA: 0xA1EF5F0
        public void ReadOutput(){} // RVA: 0xA1EF680
        public void InvalidateSession(){} // RVA: 0xA1EF710
        public void ProcessFinishedMessage(){} // RVA: 0xA1EF830
        public void RaiseAlertFatal(){} // RVA: 0xA1EFA40
        public void RaiseAlertWarning(){} // RVA: 0xA1EFB50
        public void SendCertificateMessage(){} // RVA: 0xA1EFC50
        public void SendChangeCipherSpecMessage(){} // RVA: 0xA1EFE50
        public void SendFinishedMessage(){} // RVA: 0xA1F0080
        public void SendSupplementalDataMessage(){} // RVA: 0xA1F0190
        public void CreateVerifyData(){} // RVA: 0xA1F0220
        public void Close(){} // RVA: 0x68D3A30
        public void Flush(){} // RVA: 0xA1F0350
        public void get_IsClosed(){} // RVA: 0x6D23B00
        public void ProcessMaxFragmentLengthExtension(){} // RVA: 0xA1F0390
        public void RefuseRenegotiation(){} // RVA: 0xA1F0440
        public void AssertEmpty(){} // RVA: 0xA1F0530
        public void CreateRandomBlock(){} // RVA: 0xA1F05D0
        public void CreateRenegotiationInfo(){} // RVA: 0xA1F0730
        public void EstablishMasterSecret(){} // RVA: 0xA1F0800
        public void GetCurrentPrfHash(){} // RVA: 0xA1F09E0
        public void ReadExtensions(){} // RVA: 0xA1F0B70
        public void ReadSupplementalDataMessage(){} // RVA: 0xA1F0EE0
        public void WriteExtensions(){} // RVA: 0xA1F12C0
        public void WriteSelectedExtensions(){} // RVA: 0xA1F13A0
        public void WriteSupplementalData(){} // RVA: 0xA1F1760
        public void GetPrfAlgorithm(){} // RVA: 0xA1F1B60
    }

    public class TlsProtocolHandler : TlsClientProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1DBAD0
    }

    public class TlsPskIdentity
    {
        // ── Methods ──
        public void SkipIdentityHint(){} // RVA: 0x894290
        public void NotifyIdentityHint(){} // RVA: 0x894320
        public void GetPskIdentity(){} // RVA: 0x87C0A0
        public void GetPsk(){} // RVA: 0x87C0A0
    }

    public class TlsPskIdentityManager
    {
        // ── Methods ──
        public void GetHint(){} // RVA: 0x87C0A0
        public void GetPsk(){} // RVA: 0x87C540
    }

    public class TlsPskKeyExchange : AbstractTlsKeyExchange
    {
        public object mPskIdentity;
        public object mPskIdentityManager;
        public object mDHVerifier;
        public object mDHParameters;
        public object mNamedCurves;
        public object mClientECPointFormats;
        public object mServerECPointFormats;
        public object mPskIdentityHint;
        public object mPsk;
        public object mDHAgreePrivateKey;
        public object mDHAgreePublicKey;
        public object mECAgreePrivateKey;
        public object mECAgreePublicKey;
        public object mServerPublicKey;
        public object mRsaServerPublicKey;
        public object mServerCredentials;
        public object mPremasterSecret;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1F2220
        public void SkipServerCredentials(){} // RVA: 0xA1F2580
        public void ProcessServerCredentials(){} // RVA: 0xA1F25E0
        public void GenerateServerKeyExchange(){} // RVA: 0xA1F2760
        public void ProcessServerCertificate(){} // RVA: 0xA1F2AE0
        public void get_RequiresServerKeyExchange(){} // RVA: 0xA1F2DB0
        public void ProcessServerKeyExchange(){} // RVA: 0xA1F2DD0
        public void ValidateCertificateRequest(){} // RVA: 0xA1F30B0
        public void ProcessClientCredentials(){} // RVA: 0xA1F3100
        public void GenerateClientKeyExchange(){} // RVA: 0xA1F3150
        public void ProcessClientKeyExchange(){} // RVA: 0xA1F34E0
        public void GeneratePremasterSecret(){} // RVA: 0xA1F38B0
        public void GenerateOtherSecret(){} // RVA: 0xA1F3A80
        public void ValidateRsaPublicKey(){} // RVA: 0xA1F3C10
    }

    public class TlsRsaKeyExchange : AbstractTlsKeyExchange
    {
        public object mServerPublicKey;
        public object mRsaServerPublicKey;
        public object mServerCredentials;
        public object mPremasterSecret;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7470D50
        public void SkipServerCredentials(){} // RVA: 0xA1F3C90
        public void ProcessServerCredentials(){} // RVA: 0xA1F3CE0
        public void ProcessServerCertificate(){} // RVA: 0xA1F3E60
        public void ValidateCertificateRequest(){} // RVA: 0xA1F4130
        public void ProcessClientCredentials(){} // RVA: 0xA1F41F0
        public void GenerateClientKeyExchange(){} // RVA: 0xA1F4270
        public void ProcessClientKeyExchange(){} // RVA: 0xA1F42E0
        public void GeneratePremasterSecret(){} // RVA: 0xA1F4400
        public void ValidateRsaPublicKey(){} // RVA: 0xA1F44B0
    }

    public class TlsRsaSigner : AbstractTlsSigner
    {
        // ── Methods ──
        public void GenerateRawSignature(){} // RVA: 0xA1F4530
        public void VerifyRawSignature(){} // RVA: 0xA1F47A0
        public void CreateSigner(){} // RVA: 0xA1F4880
        public void CreateVerifyer(){} // RVA: 0xA1F4A80
        public void IsValidPublicKey(){} // RVA: 0xA1F4AB0
        public void MakeSigner(){} // RVA: 0xA1F4B20
        public void CreateRsaImpl(){} // RVA: 0xA1F5070
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TlsRsaUtilities : Object
    {
        // ── Methods ──
        public void GenerateEncryptedPreMasterSecret(){} // RVA: 0xA1F50F0
        public void SafeDecryptPreMasterSecret(){} // RVA: 0xA1F5520
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TlsSRTPUtils : Object
    {
        // ── Methods ──
        public void AddUseSrtpExtension(){} // RVA: 0xA1FB880
        public void GetUseSrtpExtension(){} // RVA: 0xA1FBAA0
        public void CreateUseSrtpExtension(){} // RVA: 0xA1FBB10
        public void ReadUseSrtpExtension(){} // RVA: 0xA1FBCD0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TlsServer
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894320
        public void NotifyClientVersion(){} // RVA: 0x894320
        public void NotifyFallback(){} // RVA: 0x894750
        public void NotifyOfferedCipherSuites(){} // RVA: 0x894320
        public void NotifyOfferedCompressionMethods(){} // RVA: 0x894320
        public void ProcessClientExtensions(){} // RVA: 0x894320
        public void GetServerVersion(){} // RVA: 0x87C0A0
        public void GetSelectedCipherSuite(){} // RVA: 0x87C130
        public void GetSelectedCompressionMethod(){} // RVA: 0x87D280
        public void GetServerExtensions(){} // RVA: 0x87C0A0
        public void GetServerSupplementalData(){} // RVA: 0x87C0A0
        public void GetCredentials(){} // RVA: 0x87C0A0
        public void GetCertificateStatus(){} // RVA: 0x87C0A0
        public void GetKeyExchange(){} // RVA: 0x87C0A0
        public void GetCertificateRequest(){} // RVA: 0x87C0A0
        public void ProcessClientSupplementalData(){} // RVA: 0x894320
        public void NotifyClientCertificate(){} // RVA: 0x894320
        public void GetNewSessionTicket(){} // RVA: 0x87C0A0
    }

    public class TlsServerContextImpl : AbstractTlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1F5A80
        public void get_IsServer(){} // RVA: 0xC2E4C0
    }

    public class TlsServerProtocol : TlsProtocol
    {
        public object mTlsServer;
        public object mTlsServerContext;
        public object mKeyExchange;
        public object mServerCredentials;
        public object mCertificateRequest;
        public object mClientCertificateType;
        public object mPrepareFinishHash;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1F5B40
        public void Accept(){} // RVA: 0xA1F5B60
        public void CleanupHandshake(){} // RVA: 0xA1F5F10
        public void get_Context(){} // RVA: 0xBAE340
        public void get_ContextAdmin(){} // RVA: 0xBAE340
        public void get_Peer(){} // RVA: 0x12EB090
        public void HandleHandshakeMessage(){} // RVA: 0xA1F60A0
        public void HandleAlertWarningMessage(){} // RVA: 0xA1F6C70
        public void NotifyClientCertificate(){} // RVA: 0xA1F6E70
        public void ReceiveCertificateMessage(){} // RVA: 0xA1F70A0
        public void ReceiveCertificateVerifyMessage(){} // RVA: 0xA1F71B0
        public void ReceiveClientHelloMessage(){} // RVA: 0xA1F7600
        public void ReceiveClientKeyExchangeMessage(){} // RVA: 0xA1F7CD0
        public void SendCertificateRequestMessage(){} // RVA: 0xA1F8030
        public void SendCertificateStatusMessage(){} // RVA: 0xA1F80D0
        public void SendNewSessionTicketMessage(){} // RVA: 0xA1F8170
        public void SendServerHelloMessage(){} // RVA: 0xA1F8250
        public void SendServerHelloDoneMessage(){} // RVA: 0xA1F8C50
        public void SendServerKeyExchangeMessage(){} // RVA: 0xA1F8D30
        public void ExpectCertificateVerifyMessage(){} // RVA: 0xA1F8DE0
    }

    public class TlsSession
    {
        // ── Methods ──
        public void ExportSessionParameters(){} // RVA: 0x87C0A0
        public void get_SessionID(){} // RVA: 0x87C0A0
        public void Invalidate(){} // RVA: 0x894290
        public void get_IsResumable(){} // RVA: 0x87D280
    }

    public class TlsSessionImpl : Object
    {
        public object mSessionID;
        public object mSessionParameters;
        public object mResumable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1F8E50
        public void ExportSessionParameters(){} // RVA: 0xA1F90A0
        public void get_SessionID(){} // RVA: 0xA1F9280
        public void Invalidate(){} // RVA: 0xA1F9380
        public void get_IsResumable(){} // RVA: 0xA1F9470
    }

    public class TlsSigner
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894320
        public void GenerateRawSignature(){} // RVA: 0x882090
        public void VerifyRawSignature(){} // RVA: 0x87D760
        public void CreateSigner(){} // RVA: 0x87C5F0
        public void CreateVerifyer(){} // RVA: 0x87C5F0
        public void IsValidPublicKey(){} // RVA: 0x87D350
    }

    public class TlsSignerCredentials
    {
        // ── Methods ──
        public void GenerateCertificateSignature(){} // RVA: 0x87C540
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x87C0A0
    }

    public class TlsSrpGroupVerifier
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0x87D350
    }

    public class TlsSrpIdentityManager
    {
        // ── Methods ──
        public void GetLoginParameters(){} // RVA: 0x87C540
    }

    public class TlsSrpKeyExchange : AbstractTlsKeyExchange
    {
        public object mTlsSigner;
        public object mGroupVerifier;
        public object mIdentity;
        public object mPassword;
        public object mServerPublicKey;
        public object mSrpGroup;
        public object mSrpClient;
        public object mSrpServer;
        public object mSrpPeerCredentials;
        public object mSrpVerifier;
        public object mSrpSalt;
        public object mServerCredentials;

        // ── Methods ──
        public void CreateSigner(){} // RVA: 0xA1F9570
        public void .ctor(){} // RVA: 0xA1F9940
        public void Init(){} // RVA: 0xA1F9C50
        public void SkipServerCredentials(){} // RVA: 0xA1F9CC0
        public void ProcessServerCertificate(){} // RVA: 0xA1F9D20
        public void ProcessServerCredentials(){} // RVA: 0xA1F9F70
        public void get_RequiresServerKeyExchange(){} // RVA: 0xC2E4C0
        public void GenerateServerKeyExchange(){} // RVA: 0xA1FA100
        public void ProcessServerKeyExchange(){} // RVA: 0xA1FA530
        public void ValidateCertificateRequest(){} // RVA: 0xA1FAB40
        public void ProcessClientCredentials(){} // RVA: 0xA1FAB90
        public void GenerateClientKeyExchange(){} // RVA: 0xA1FABE0
        public void ProcessClientKeyExchange(){} // RVA: 0xA1FADC0
        public void GeneratePremasterSecret(){} // RVA: 0xA1FB000
        public void InitVerifyer(){} // RVA: 0xA1FB0E0
    }

    public class TlsSrpLoginParameters : Object
    {
        public object mGroup;
        public object mVerifier;
        public object mSalt;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void get_Group(){} // RVA: 0xB5DBF0
        public void get_Salt(){} // RVA: 0xB700F0
        public void get_Verifier(){} // RVA: 0xB465B0
    }

    public class TlsSrpUtilities : Object
    {
        // ── Methods ──
        public void AddSrpExtension(){} // RVA: 0xA1FB1E0
        public void GetSrpExtension(){} // RVA: 0xA1FB360
        public void CreateSrpExtension(){} // RVA: 0xA1FB4D0
        public void ReadSrpExtension(){} // RVA: 0xA1FB5D0
        public void ReadSrpParameter(){} // RVA: 0xA1FB740
        public void WriteSrpParameter(){} // RVA: 0xA1FB7F0
        public void IsSrpCipherSuite(){} // RVA: 0xA1FB870
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TlsStream : Stream
    {
        public object handler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1FC040
        public void get_CanRead(){} // RVA: 0xA1FC0E0
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xA1FC0E0
        public void Close(){} // RVA: 0xA1FC110
        public void Flush(){} // RVA: 0xA1FC150
        public void get_Length(){} // RVA: 0xA1FC180
        public void get_Position(){} // RVA: 0xA1FC1C0
        public void set_Position(){} // RVA: 0xA1FC200
        public void Read(){} // RVA: 0xA1FC240
        public void ReadByte(){} // RVA: 0xA1FC270
        public void Seek(){} // RVA: 0xA1FC320
        public void SetLength(){} // RVA: 0xA1FC360
        public void Write(){} // RVA: 0xA1FC3A0
        public void WriteByte(){} // RVA: 0xA1FC3D0
    }

    public class TlsStreamCipher : Object
    {
        public object context;
        public object encryptCipher;
        public object decryptCipher;
        public object writeMac;
        public object readMac;
        public object usesNonce;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1FC470
        public void GetPlaintextLimit(){} // RVA: 0xA1FCC10
        public void EncodePlaintext(){} // RVA: 0xA1FCC50
        public void DecodeCiphertext(){} // RVA: 0xA1FCDD0
        public void CheckMac(){} // RVA: 0xA1FCFB0
        public void UpdateIV(){} // RVA: 0xA1FD130
    }

    public class TlsUtilities : Object
    {
        public object EmptyBytes;
        public object EmptyShorts;
        public object EmptyInts;
        public object EmptyLongs;
        public object SSL_CLIENT;
        public object SSL_SERVER;
        public object SSL3_CONST;

        // ── Methods ──
        public void CheckUint8(){} // RVA: 0xA1FD2E0
        public void CheckUint16(){} // RVA: 0xA1FD400
        public void CheckUint24(){} // RVA: 0xA1FD520
        public void CheckUint32(){} // RVA: 0xA1FD5B0
        public void CheckUint48(){} // RVA: 0xA1FD640
        public void CheckUint64(){} // RVA: 0xA1FD6E0
        public void IsValidUint8(){} // RVA: 0xA1FD730
        public void IsValidUint16(){} // RVA: 0xA1FD750
        public void IsValidUint24(){} // RVA: 0xA1FD770
        public void IsValidUint32(){} // RVA: 0xA1FD780
        public void IsValidUint48(){} // RVA: 0xA1FD790
        public void IsValidUint64(){} // RVA: 0xC2E4C0
        public void IsSsl(){} // RVA: 0xA1FD7B0
        public void IsTlsV11(){} // RVA: 0xA1FD940
        public void IsTlsV12(){} // RVA: 0xA1FDB60
        public void WriteUint8(){} // RVA: 0xA1FDCD0
        public void WriteUint16(){} // RVA: 0xA1FDD60
        public void WriteUint24(){} // RVA: 0xA1FDE20
        public void WriteUint32(){} // RVA: 0xA1FDF10
        public void WriteUint48(){} // RVA: 0xA1FE060
        public void WriteUint64(){} // RVA: 0xA1FE220
        public void WriteOpaque8(){} // RVA: 0xA1FE310
        public void WriteOpaque16(){} // RVA: 0xA1FE3C0
        public void WriteOpaque24(){} // RVA: 0xA1FE490
        public void WriteUint8Array(){} // RVA: 0xA1FE5D0
        public void WriteUint8ArrayWithUint8Length(){} // RVA: 0xA1FE750
        public void WriteUint16Array(){} // RVA: 0xA1FE960
        public void WriteUint16ArrayWithUint16Length(){} // RVA: 0xA1FEBA0
        public void DecodeUint8(){} // RVA: 0xA1FED00
        public void DecodeUint8ArrayWithUint8Length(){} // RVA: 0xA1FEDF0
        public void EncodeOpaque8(){} // RVA: 0xA1FEFB0
        public void EncodeUint8(){} // RVA: 0xA1FF040
        public void EncodeUint8ArrayWithUint8Length(){} // RVA: 0xA1FF0D0
        public void EncodeUint16ArrayWithUint16Length(){} // RVA: 0xA1FF250
        public void ReadUint8(){} // RVA: 0xA1FF470
        public void ReadUint16(){} // RVA: 0xA1FF540
        public void ReadUint24(){} // RVA: 0xA1FF640
        public void ReadUint32(){} // RVA: 0xA1FF790
        public void ReadUint48(){} // RVA: 0xA1FF880
        public void ReadAllOrNothing(){} // RVA: 0xA1FF970
        public void ReadFully(){} // RVA: 0xA1FFC40
        public void ReadOpaque8(){} // RVA: 0xA1FFD10
        public void ReadOpaque16(){} // RVA: 0xA1FFE00
        public void ReadOpaque24(){} // RVA: 0xA1FFF10
        public void ReadUint8Array(){} // RVA: 0xA1FFF70
        public void ReadUint16Array(){} // RVA: 0xA200090
        public void ReadVersion(){} // RVA: 0xA200280
        public void ReadVersionRaw(){} // RVA: 0xA200360
        public void ReadAsn1Object(){} // RVA: 0xA200400
        public void ReadDerObject(){} // RVA: 0xA200580
        public void WriteGmtUnixTime(){} // RVA: 0xA200720
        public void WriteVersion(){} // RVA: 0xA200860
        public void GetAllSignatureAlgorithms(){} // RVA: 0xA2008B0
        public void GetDefaultDssSignatureAlgorithms(){} // RVA: 0xA200B50
        public void GetDefaultECDsaSignatureAlgorithms(){} // RVA: 0xA200C10
        public void GetDefaultRsaSignatureAlgorithms(){} // RVA: 0xA200CD0
        public void GetExtensionData(){} // RVA: 0xA200D90
        public void GetDefaultSupportedSignatureAlgorithms(){} // RVA: 0xA200E40
        public void GetSignatureAndHashAlgorithm(){} // RVA: 0xA201060
        public void HasExpectedEmptyExtensionData(){} // RVA: 0xA2011A0
        public void ImportSession(){} // RVA: 0xA201270
        public void IsSignatureAlgorithmsExtensionAllowed(){} // RVA: 0xA2012E0
        public void AddSignatureAlgorithmsExtension(){} // RVA: 0xA2013C0
        public void GetSignatureAlgorithmsExtension(){} // RVA: 0xA201510
        public void CreateSignatureAlgorithmsExtension(){} // RVA: 0xA2016A0
        public void ReadSignatureAlgorithmsExtension(){} // RVA: 0xA201750
        public void EncodeSupportedSignatureAlgorithms(){} // RVA: 0xA2018C0
        public void ParseSupportedSignatureAlgorithms(){} // RVA: 0xA201C90
        public void VerifySupportedSignatureAlgorithm(){} // RVA: 0xA201EC0
        public void PRF(){} // RVA: 0xA202240
        public void PRF_legacy(){} // RVA: 0xA202660
        public void Concat(){} // RVA: 0xA202810
        public void HMacHash(){} // RVA: 0xA2028C0
        public void ValidateKeyUsage(){} // RVA: 0xA202B90
        public void CalculateKeyBlock(){} // RVA: 0xA202CB0
        public void CalculateKeyBlock_Ssl(){} // RVA: 0xA202EB0
        public void CalculateMasterSecret(){} // RVA: 0xA2034E0
        public void CalculateMasterSecret_Ssl(){} // RVA: 0xA203770
        public void CalculateVerifyData(){} // RVA: 0xA203D40
        public void CreateHash(){} // RVA: 0xA204070
        public void CloneHash(){} // RVA: 0xA204110
        public void CreatePrfHash(){} // RVA: 0xA204550
        public void ClonePrfHash(){} // RVA: 0xA2045E0
        public void GetHashAlgorithmForPrfAlgorithm(){} // RVA: 0xA2046C0
        public void GetOidForHashAlgorithm(){} // RVA: 0xA2047B0
        public void GetClientCertificateType(){} // RVA: 0xA2049C0
        public void TrackHashAlgorithms(){} // RVA: 0xA204C90
        public void HasSigningCapability(){} // RVA: 0xA204F10
        public void CreateTlsSigner(){} // RVA: 0xA204F30
        public void GenSsl3Const(){} // RVA: 0xA205030
        public void VectorOfOne(){} // RVA: 0xA2051B0
        public void GetCipherType(){} // RVA: 0xA205300
        public void GetEncryptionAlgorithm(){} // RVA: 0xA205400
        public void GetKeyExchangeAlgorithm(){} // RVA: 0xA2057C0
        public void GetMacAlgorithm(){} // RVA: 0xA205BE0
        public void GetMinimumVersion(){} // RVA: 0xA205E90
        public void IsAeadCipherSuite(){} // RVA: 0xA205FA0
        public void IsBlockCipherSuite(){} // RVA: 0xA206000
        public void IsStreamCipherSuite(){} // RVA: 0xA206060
        public void IsValidCipherSuiteForSignatureAlgorithms(){} // RVA: 0xA2060C0
        public void IsValidCipherSuiteForVersion(){} // RVA: 0xA2062A0
        public void GetUsableSignatureAlgorithms(){} // RVA: 0xA206490
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA2069C0
    }

}