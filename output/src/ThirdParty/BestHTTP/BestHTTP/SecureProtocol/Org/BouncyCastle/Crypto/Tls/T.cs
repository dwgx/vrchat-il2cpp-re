// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 61
// Methods: 663

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class TlsAeadCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F99B80 | overloaded x2
        public void GetPlaintextLimit(){} // RVA: 0x7FFE89F9A050
        public void EncodePlaintext(){} // RVA: 0x7FFE89F9A060
        public void DecodeCiphertext(){} // RVA: 0x7FFE89F9A480
        public void GetAdditionalData(){} // RVA: 0x7FFE89F9A8D0
    }

    public class TlsAgreementCredentials
    {
        // ── Methods ──
        public void GenerateAgreement(){} // RVA: 0x7FFE80E2E390
    }

    public class TlsAuthentication
    {
        // ── Methods ──
        public void NotifyServerCertificate(){} // RVA: 0x7FFE80E460A0
        public void GetClientCredentials(){} // RVA: 0x7FFE80E3FC10
    }

    public class TlsBlockCipher : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext context; // 0x10
        public byte[] randomData; // 0x18

        // ── Methods ──
        public void get_WriteMac(){} // RVA: 0x7FFE8143BA80
        public void get_ReadMac(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE89F9AA00
        public void GetPlaintextLimit(){} // RVA: 0x7FFE89F9B350
        public void EncodePlaintext(){} // RVA: 0x7FFE89F9B420
        public void DecodeCiphertext(){} // RVA: 0x7FFE89F9B960
        public void CheckPaddingConstantTime(){} // RVA: 0x7FFE89F9BF60
        public void ChooseExtraPadBlocks(){} // RVA: 0x7FFE89F9C0D0
        public void LowestBitSet(){} // RVA: 0x7FFE89F9C180
    }

    public class TlsCipher
    {
        // ── Methods ──
        public void GetPlaintextLimit(){} // RVA: 0x7FFE80E35520
        public void EncodePlaintext(){}
        public void DecodeCiphertext(){}
    }

    public class TlsCipherFactory
    {
        // ── Methods ──
        public void CreateCipher(){}
    }

    public class TlsClient
    {
        // ── Methods ──
        public void get_HostNames(){} // RVA: 0x7FFE80E2E2E0
        public void set_HostNames(){} // RVA: 0x7FFE80E460A0
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void GetSessionToResume(){} // RVA: 0x7FFE80E2E2E0
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0x7FFE80E2E2E0
        public void get_ClientVersion(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsFallback(){} // RVA: 0x7FFE80E2F150
        public void GetCipherSuites(){} // RVA: 0x7FFE80E2E2E0
        public void GetCompressionMethods(){} // RVA: 0x7FFE80E2E2E0
        public void GetClientExtensions(){} // RVA: 0x7FFE80E2E2E0
        public void NotifyServerVersion(){} // RVA: 0x7FFE80E460A0
        public void NotifySessionID(){} // RVA: 0x7FFE80E460A0
        public void NotifySelectedCipherSuite(){} // RVA: 0x7FFE80E46530
        public void NotifySelectedCompressionMethod(){} // RVA: 0x7FFE80E466C0
        public void ProcessServerExtensions(){} // RVA: 0x7FFE80E460A0
        public void ProcessServerSupplementalData(){} // RVA: 0x7FFE80E460A0
        public void GetKeyExchange(){} // RVA: 0x7FFE80E2E2E0
        public void GetAuthentication(){} // RVA: 0x7FFE80E2E2E0
        public void GetClientSupplementalData(){} // RVA: 0x7FFE80E2E2E0
        public void NotifyNewSessionTicket(){} // RVA: 0x7FFE80E460A0
    }

    public class TlsClientContext
    {
    }

    public class TlsClientContextImpl : AbstractTlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F9C1A0
        public void get_IsServer(){} // RVA: 0x7FFE810FB320
    }

    public class TlsClientProtocol : TlsProtocol
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsClient mTlsClient; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsClientContextImpl mTlsClientContext; // 0xB0
        public byte[] mSelectedSessionID; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F9C240 | overloaded x3
        public void Connect(){} // RVA: 0x7FFE89F9C250
        public void CleanupHandshake(){} // RVA: 0x7FFE89F9C6A0
        public void get_Context(){} // RVA: 0x7FFE81166040
        public void get_ContextAdmin(){} // RVA: 0x7FFE81166040
        public void get_Peer(){} // RVA: 0x7FFE817AB5E0
        public void HandleHandshakeMessage(){} // RVA: 0x7FFE89F9C880
        public void HandleSupplementalData(){} // RVA: 0x7FFE89F9D9C0
        public void ReceiveNewSessionTicketMessage(){} // RVA: 0x7FFE89F9DAF0
        public void ReceiveServerHelloMessage(){} // RVA: 0x7FFE89F9DBE0
        public void SendCertificateVerifyMessage(){} // RVA: 0x7FFE89F9E950
        public void SendClientHelloMessage(){} // RVA: 0x7FFE89F9E9F0
        public void SendClientKeyExchangeMessage(){} // RVA: 0x7FFE89F9F350
    }

    public class TlsCompression
    {
        // ── Methods ──
        public void Compress(){} // RVA: 0x7FFE80E2E390
        public void Decompress(){} // RVA: 0x7FFE80E2E390
    }

    public class TlsContext
    {
        // ── Methods ──
        public void get_NonceRandomGenerator(){} // RVA: 0x7FFE80E2E2E0
        public void get_SecureRandom(){} // RVA: 0x7FFE80E2E2E0
        public void get_SecurityParameters(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsServer(){} // RVA: 0x7FFE80E2F150
        public void get_ClientVersion(){} // RVA: 0x7FFE80E2E2E0
        public void get_ServerVersion(){} // RVA: 0x7FFE80E2E2E0
        public void get_ResumableSession(){} // RVA: 0x7FFE80E2E2E0
        public void get_UserObject(){} // RVA: 0x7FFE80E2E2E0
        public void set_UserObject(){} // RVA: 0x7FFE80E460A0
        public void ExportKeyingMaterial(){}
    }

    public class TlsCredentials
    {
        // ── Methods ──
        public void get_Certificate(){} // RVA: 0x7FFE80E2E2E0
    }

    public class TlsDHKeyExchange : AbstractTlsKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSigner mTlsSigner; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FA0330 | overloaded x2
        public void Init(){} // RVA: 0x7FFE89FA0590
        public void SkipServerCredentials(){} // RVA: 0x7FFE89FA0600
        public void ProcessServerCertificate(){} // RVA: 0x7FFE89FA0660
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFE89FA09F0
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFE89FA0A10
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFE89FA0B70
        public void ValidateCertificateRequest(){} // RVA: 0x7FFE89FA0D50
        public void ProcessClientCredentials(){} // RVA: 0x7FFE89FA0E50
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFE89FA1000
        public void ProcessClientCertificate(){} // RVA: 0x7FFE89FA1110
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFE89FA1170
        public void GeneratePremasterSecret(){} // RVA: 0x7FFE89FA1270
    }

    public class TlsDHUtilities : Object
    {
        // ── Methods ──
        public void FromHex(){} // RVA: 0x7FFE89FA1350
        public void FromSafeP(){} // RVA: 0x7FFE89FA1400
        public void AddNegotiatedDheGroupsClientExtension(){} // RVA: 0x7FFE89FA1560
        public void AddNegotiatedDheGroupsServerExtension(){} // RVA: 0x7FFE89FA16F0
        public void GetNegotiatedDheGroupsClientExtension(){} // RVA: 0x7FFE89FA1830
        public void GetNegotiatedDheGroupsServerExtension(){} // RVA: 0x7FFE89FA1990
        public void CreateNegotiatedDheGroupsClientExtension(){} // RVA: 0x7FFE89FA1AB0
        public void CreateNegotiatedDheGroupsServerExtension(){} // RVA: 0x7FFE89FA1B50
        public void ReadNegotiatedDheGroupsClientExtension(){} // RVA: 0x7FFE89FA1BA0
        public void ReadNegotiatedDheGroupsServerExtension(){} // RVA: 0x7FFE89FA1C40
        public void GetParametersForDHEGroup(){} // RVA: 0x7FFE89FA1C90
        public void ContainsDheCipherSuites(){} // RVA: 0x7FFE89FA1DE0
        public void IsDheCipherSuite(){} // RVA: 0x7FFE89FA20C0
        public void AreCompatibleParameters(){} // RVA: 0x7FFE89FA2300
        public void CalculateDHBasicAgreement(){} // RVA: 0x7FFE89FA23D0
        public void GenerateDHKeyPair(){} // RVA: 0x7FFE89FA2480
        public void GenerateEphemeralClientKeyExchange(){} // RVA: 0x7FFE89FA2550
        public void GenerateEphemeralServerKeyExchange(){} // RVA: 0x7FFE89FA26F0
        public void ReadDHParameter(){} // RVA: 0x7FFE89FA29B0
        public void ReadDHParameters(){} // RVA: 0x7FFE89FA2A60
        public void ReceiveDHParameters(){} // RVA: 0x7FFE89FA2B10
        public void WriteDHParameter(){} // RVA: 0x7FFE89FA2CD0
        public void WriteDHParameters(){} // RVA: 0x7FFE89FA2D50
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89FA2E80
    }

    public class TlsDHVerifier
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0x7FFE80E2F3B0
    }

    public class TlsDeflateCompression : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F9F570 | overloaded x2
        public void Compress(){} // RVA: 0x7FFE89F9F700
        public void Decompress(){} // RVA: 0x7FFE89F9F790
    }

    public class TlsDheKeyExchange : TlsDHKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F9F910 | overloaded x2
        public void ProcessServerCredentials(){} // RVA: 0x7FFE89F9F920
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFE89F9FAA0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFE89F9FE60
        public void InitVerifyer(){} // RVA: 0x7FFE89FA0190
    }

    public class TlsDsaSigner : AbstractTlsSigner
    {
        // ── Methods ──
        public void GenerateRawSignature(){} // RVA: 0x7FFE89FA3460
        public void VerifyRawSignature(){} // RVA: 0x7FFE89FA35B0
        public void CreateSigner(){} // RVA: 0x7FFE89FA36B0
        public void CreateVerifyer(){} // RVA: 0x7FFE89FA36E0
        public void MakeInitParameters(){} // RVA: 0x7FFE82C0A000
        public void MakeSigner(){} // RVA: 0x7FFE89FA3710
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE80E2F150
        public void CreateDsaImpl(){}
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TlsDssSigner : TlsDsaSigner
    {
        // ── Methods ──
        public void IsValidPublicKey(){} // RVA: 0x7FFE89FA3980
        public void CreateDsaImpl(){} // RVA: 0x7FFE89FA3A10
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE8429F400
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TlsECDHKeyExchange : AbstractTlsKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSigner mTlsSigner; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FA7FF0
        public void Init(){} // RVA: 0x7FFE89FA8290
        public void SkipServerCredentials(){} // RVA: 0x7FFE89FA8300
        public void ProcessServerCertificate(){} // RVA: 0x7FFE89FA8360
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFE89FA86C0
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFE89FA86E0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFE89FA8860
        public void ValidateCertificateRequest(){} // RVA: 0x7FFE89FA89D0
        public void ProcessClientCredentials(){} // RVA: 0x7FFE89FA8AD0
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFE89FA8C80
        public void ProcessClientCertificate(){} // RVA: 0x7FFE89FA8DA0
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFE89FA8E00
        public void GeneratePremasterSecret(){} // RVA: 0x7FFE89FA8F20
    }

    public class TlsECDheKeyExchange : TlsECDHKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FA7550
        public void ProcessServerCredentials(){} // RVA: 0x7FFE89FA7560
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFE89FA76E0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFE89FA7AD0
        public void ValidateCertificateRequest(){} // RVA: 0x7FFE89FA7DB0
        public void ProcessClientCredentials(){} // RVA: 0x7FFE89FA7E70
        public void InitVerifyer(){} // RVA: 0x7FFE89FA7EF0
    }

    public class TlsECDsaSigner : TlsDsaSigner
    {
        // ── Methods ──
        public void IsValidPublicKey(){} // RVA: 0x7FFE89FA9000
        public void CreateDsaImpl(){} // RVA: 0x7FFE89FA9090
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE86BBE8D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TlsEccUtilities : Object
    {
        // ── Methods ──
        public void AddSupportedEllipticCurvesExtension(){} // RVA: 0x7FFE89FA3B10
        public void AddSupportedPointFormatsExtension(){} // RVA: 0x7FFE89FA3BE0
        public void GetSupportedEllipticCurvesExtension(){} // RVA: 0x7FFE89FA3DE0
        public void GetSupportedPointFormatsExtension(){} // RVA: 0x7FFE89FA3E80
        public void CreateSupportedEllipticCurvesExtension(){} // RVA: 0x7FFE89FA3F20
        public void CreateSupportedPointFormatsExtension(){} // RVA: 0x7FFE89FA4140
        public void ReadSupportedEllipticCurvesExtension(){} // RVA: 0x7FFE89FA42A0
        public void ReadSupportedPointFormatsExtension(){} // RVA: 0x7FFE89FA4480
        public void GetNameOfNamedCurve(){} // RVA: 0x7FFE89FA4570
        public void GetParametersForNamedCurve(){} // RVA: 0x7FFE89FA4620
        public void HasAnySupportedNamedCurves(){} // RVA: 0x7FFE89FA4970
        public void ContainsEccCipherSuites(){} // RVA: 0x7FFE89FA49E0
        public void IsEccCipherSuite(){} // RVA: 0x7FFE89FA4A90
        public void AreOnSameCurve(){} // RVA: 0x7FFE89FA4B20
        public void IsSupportedNamedCurve(){} // RVA: 0x7FFE89FA4B40
        public void IsCompressionPreferred(){} // RVA: 0x7FFE89FA4BC0
        public void SerializeECFieldElement(){} // RVA: 0x7FFE89FA4C10
        public void SerializeECPoint(){} // RVA: 0x7FFE89FA4C30
        public void SerializeECPublicKey(){} // RVA: 0x7FFE89FA4DE0
        public void DeserializeECFieldElement(){} // RVA: 0x7FFE89FA4E50
        public void DeserializeECPoint(){} // RVA: 0x7FFE89FA4F20
        public void DeserializeECPublicKey(){} // RVA: 0x7FFE89FA5170
        public void CalculateECDHBasicAgreement(){} // RVA: 0x7FFE89FA52C0
        public void GenerateECKeyPair(){} // RVA: 0x7FFE89FA5380
        public void GenerateEphemeralClientKeyExchange(){} // RVA: 0x7FFE89FA5470
        public void GenerateEphemeralServerKeyExchange(){} // RVA: 0x7FFE89FA5760
        public void ValidateECPublicKey(){} // RVA: 0x7FFE827C4A80
        public void ReadECExponent(){} // RVA: 0x7FFE89FA5AD0
        public void ReadECFieldElement(){} // RVA: 0x7FFE89FA5BD0
        public void ReadECParameter(){} // RVA: 0x7FFE89FA5D10
        public void ReadECParameters(){} // RVA: 0x7FFE89FA5DC0
        public void CheckNamedCurve(){} // RVA: 0x7FFE89FA6430
        public void WriteECExponent(){} // RVA: 0x7FFE89FA64F0
        public void WriteECFieldElement(){} // RVA: 0x7FFE89FA6690 | overloaded x2
        public void WriteECParameter(){} // RVA: 0x7FFE89FA67C0
        public void WriteExplicitECParameters(){} // RVA: 0x7FFE89FA68B0
        public void WriteECPoint(){} // RVA: 0x7FFE89FA6E60
        public void WriteNamedECParameters(){} // RVA: 0x7FFE89FA6F80
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89FA7080
    }

    public class TlsEncryptionCredentials
    {
        // ── Methods ──
        public void DecryptPreMasterSecret(){} // RVA: 0x7FFE80E2E390
    }

    public class TlsException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869662F0
    }

    public class TlsExtensionsUtilities : Object
    {
        // ── Methods ──
        public void EnsureExtensionsInitialised(){} // RVA: 0x7FFE89FA9190
        public void AddClientCertificateTypeExtensionClient(){} // RVA: 0x7FFE89FA9230
        public void AddClientCertificateTypeExtensionServer(){} // RVA: 0x7FFE89FA92E0
        public void AddEncryptThenMacExtension(){} // RVA: 0x7FFE89FA93C0
        public void AddExtendedMasterSecretExtension(){} // RVA: 0x7FFE89FA94A0
        public void AddHeartbeatExtension(){} // RVA: 0x7FFE89FA9580
        public void AddMaxFragmentLengthExtension(){} // RVA: 0x7FFE89FA96E0
        public void AddPaddingExtension(){} // RVA: 0x7FFE89FA97C0
        public void AddServerCertificateTypeExtensionClient(){} // RVA: 0x7FFE89FA98C0
        public void AddServerCertificateTypeExtensionServer(){} // RVA: 0x7FFE89FA9970
        public void AddServerNameExtension(){} // RVA: 0x7FFE89FA9A50
        public void AddStatusRequestExtension(){} // RVA: 0x7FFE89FA9C30
        public void AddTruncatedHMacExtension(){} // RVA: 0x7FFE89FA9D90
        public void GetClientCertificateTypeExtensionClient(){} // RVA: 0x7FFE89FA9E70
        public void GetClientCertificateTypeExtensionServer(){} // RVA: 0x7FFE89FA9EE0
        public void GetHeartbeatExtension(){} // RVA: 0x7FFE89FA9F90
        public void GetMaxFragmentLengthExtension(){} // RVA: 0x7FFE89FAA000
        public void GetPaddingExtension(){} // RVA: 0x7FFE89FAA0B0
        public void GetServerCertificateTypeExtensionClient(){} // RVA: 0x7FFE89FAA190
        public void GetServerCertificateTypeExtensionServer(){} // RVA: 0x7FFE89FAA200
        public void GetServerNameExtension(){} // RVA: 0x7FFE89FAA2B0
        public void GetStatusRequestExtension(){} // RVA: 0x7FFE89FAA400
        public void HasEncryptThenMacExtension(){} // RVA: 0x7FFE89FAA550
        public void HasExtendedMasterSecretExtension(){} // RVA: 0x7FFE89FAA600
        public void HasTruncatedHMacExtension(){} // RVA: 0x7FFE89FAA6B0
        public void CreateCertificateTypeExtensionClient(){} // RVA: 0x7FFE89FAA760
        public void CreateCertificateTypeExtensionServer(){} // RVA: 0x7FFE89FAA800
        public void CreateEmptyExtensionData(){} // RVA: 0x7FFE89FAA850
        public void CreateEncryptThenMacExtension(){} // RVA: 0x7FFE89FAA8B0
        public void CreateExtendedMasterSecretExtension(){} // RVA: 0x7FFE89FAA8B0
        public void CreateHeartbeatExtension(){} // RVA: 0x7FFE89FAA910
        public void CreateMaxFragmentLengthExtension(){} // RVA: 0x7FFE89FAA9E0
        public void CreatePaddingExtension(){} // RVA: 0x7FFE89FAAA30
        public void CreateServerNameExtension(){} // RVA: 0x7FFE89FAAAA0
        public void CreateStatusRequestExtension(){} // RVA: 0x7FFE89FAAB70
        public void CreateTruncatedHMacExtension(){} // RVA: 0x7FFE89FAA8B0
        public void ReadEmptyExtensionData(){} // RVA: 0x7FFE89FAAC40
        public void ReadCertificateTypeExtensionClient(){} // RVA: 0x7FFE89FAACE0
        public void ReadCertificateTypeExtensionServer(){} // RVA: 0x7FFE89FAAD80
        public void ReadEncryptThenMacExtension(){} // RVA: 0x7FFE89FAAC40
        public void ReadExtendedMasterSecretExtension(){} // RVA: 0x7FFE89FAAC40
        public void ReadHeartbeatExtension(){} // RVA: 0x7FFE89FAADD0
        public void ReadMaxFragmentLengthExtension(){} // RVA: 0x7FFE89FAB010
        public void ReadPaddingExtension(){} // RVA: 0x7FFE89FAB060
        public void ReadServerNameExtension(){} // RVA: 0x7FFE89FAB130
        public void ReadStatusRequestExtension(){} // RVA: 0x7FFE89FAB280
        public void ReadTruncatedHMacExtension(){} // RVA: 0x7FFE89FAAC40
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TlsFatalAlert : TlsException
    {
        public byte alertDescription; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FAB420 | overloaded x2
        public void get_AlertDescription(){} // RVA: 0x7FFE820BF400
    }

    public class TlsFatalAlertReceived : TlsException
    {
        public byte alertDescription; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FAB3D0
        public void get_AlertDescription(){} // RVA: 0x7FFE820BF400
    }

    public class TlsHandshakeHash
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void NotifyPrfDetermined(){} // RVA: 0x7FFE80E2E2E0
        public void TrackHashAlgorithm(){} // RVA: 0x7FFE80E466C0
        public void SealHashAlgorithms(){} // RVA: 0x7FFE80E45FE0
        public void StopTracking(){} // RVA: 0x7FFE80E2E2E0
        public void ForkPrfHash(){} // RVA: 0x7FFE80E2E2E0
        public void GetFinalHash(){}
    }

    public class TlsKeyExchange
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void SkipServerCredentials(){} // RVA: 0x7FFE80E45FE0
        public void ProcessServerCredentials(){} // RVA: 0x7FFE80E460A0
        public void ProcessServerCertificate(){} // RVA: 0x7FFE80E460A0
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFE80E2F150
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFE80E2E2E0
        public void SkipServerKeyExchange(){} // RVA: 0x7FFE80E45FE0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFE80E460A0
        public void ValidateCertificateRequest(){} // RVA: 0x7FFE80E460A0
        public void SkipClientCredentials(){} // RVA: 0x7FFE80E45FE0
        public void ProcessClientCredentials(){} // RVA: 0x7FFE80E460A0
        public void ProcessClientCertificate(){} // RVA: 0x7FFE80E460A0
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFE80E460A0
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFE80E460A0
        public void GeneratePremasterSecret(){} // RVA: 0x7FFE80E2E2E0
    }

    public class TlsMac : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext context; // 0x10
        public byte[] secret; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FAB480
        public void get_MacSecret(){} // RVA: 0x7FFE810FE7C0
        public void get_Size(){} // RVA: 0x7FFE81156CD0
        public void CalculateMac(){} // RVA: 0x7FFE89FAB9B0
        public void CalculateMacConstantTime(){} // RVA: 0x7FFE89FABCC0
        public void GetDigestBlockCount(){} // RVA: 0x7FFE89FABEF0
        public void Truncate(){} // RVA: 0x7FFE89FABF00
    }

    public class TlsNoCloseNotifyException : EndOfStreamException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FABF80
    }

    public class TlsNullCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FAC0D0 | overloaded x2
        public void GetPlaintextLimit(){} // RVA: 0x7FFE89FAC500
        public void EncodePlaintext(){} // RVA: 0x7FFE89FAC530
        public void DecodeCiphertext(){} // RVA: 0x7FFE89FAC690
    }

    public class TlsNullCompression : Object
    {
        // ── Methods ──
        public void Compress(){} // RVA: 0x7FFE82153650
        public void Decompress(){} // RVA: 0x7FFE82153650
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TlsPeer
    {
        // ── Methods ──
        public void RequiresExtendedMasterSecret(){} // RVA: 0x7FFE80E2F150
        public void ShouldUseGmtUnixTime(){} // RVA: 0x7FFE80E2F150
        public void NotifySecureRenegotiation(){} // RVA: 0x7FFE80E466C0
        public void GetCompression(){} // RVA: 0x7FFE80E2E2E0
        public void GetCipher(){} // RVA: 0x7FFE80E2E2E0
        public void NotifyAlertRaised(){}
        public void NotifyAlertReceived(){} // RVA: 0x7FFE80E46750
        public void NotifyHandshakeComplete(){} // RVA: 0x7FFE80E45FE0
    }

    public class TlsProtocol : Object
    {
        public short CS_START;
        public short CS_CLIENT_HELLO;
        public short CS_SERVER_HELLO;
        public short CS_SERVER_SUPPLEMENTAL_DATA;
        public short CS_SERVER_CERTIFICATE;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FACD70 | overloaded x3
        public void get_Context(){} // RVA: 0x7FFE80E2E2E0
        public void get_ContextAdmin(){} // RVA: 0x7FFE80E2E2E0
        public void get_Peer(){} // RVA: 0x7FFE80E2E2E0
        public void HandleAlertMessage(){} // RVA: 0x7FFE89FAD2F0
        public void HandleAlertWarningMessage(){} // RVA: 0x7FFE89FAD3E0
        public void HandleChangeCipherSpecMessage(){} // RVA: 0x7FFE810FB310
        public void HandleClose(){} // RVA: 0x7FFE89FAD460
        public void HandleException(){} // RVA: 0x7FFE89FAD550
        public void HandleFailure(){} // RVA: 0x7FFE89FAD5B0
        public void HandleHandshakeMessage(){} // RVA: 0x7FFE80E46BE0
        public void ApplyMaxFragmentLengthExtension(){} // RVA: 0x7FFE89FAD630
        public void CheckReceivedChangeCipherSpec(){} // RVA: 0x7FFE89FAD6E0
        public void CleanupHandshake(){} // RVA: 0x7FFE89FAD740
        public void BlockForHandshake(){} // RVA: 0x7FFE89FADA50
        public void CompleteHandshake(){} // RVA: 0x7FFE89FADAE0
        public void ProcessRecord(){} // RVA: 0x7FFE89FAE1D0
        public void ProcessHandshakeQueue(){} // RVA: 0x7FFE89FAE680
        public void ProcessApplicationDataQueue(){} // RVA: 0x7FFE810FB310
        public void ProcessAlertQueue(){} // RVA: 0x7FFE89FAE900
        public void ProcessChangeCipherSpec(){} // RVA: 0x7FFE89FAEA00
        public void ApplicationDataAvailable(){} // RVA: 0x7FFE827C1480
        public void ReadApplicationData(){} // RVA: 0x7FFE89FAEBA0
        public void SafeCheckRecordHeader(){} // RVA: 0x7FFE89FAED70
        public void SafeReadRecord(){} // RVA: 0x7FFE89FAEED0
        public void SafeWriteRecord(){} // RVA: 0x7FFE89FAF0F0
        public void WriteData(){} // RVA: 0x7FFE89FAF260
        public void SetAppDataSplitMode(){} // RVA: 0x7FFE89FAF460
        public void WriteHandshakeMessage(){} // RVA: 0x7FFE89FAF510
        public void get_Stream(){} // RVA: 0x7FFE89FAF6C0
        public void CloseInput(){} // RVA: 0x7FFE89FAF730
        public void OfferInput(){} // RVA: 0x7FFE89FAF890 | overloaded x2
        public void GetAvailableInputBytes(){} // RVA: 0x7FFE89FAFB50
        public void ReadInput(){} // RVA: 0x7FFE89FAFBD0
        public void OfferOutput(){} // RVA: 0x7FFE89FAFCE0
        public void GetAvailableOutputBytes(){} // RVA: 0x7FFE89FAFDB0
        public void ReadOutput(){} // RVA: 0x7FFE89FAFE40
        public void InvalidateSession(){} // RVA: 0x7FFE89FAFED0
        public void ProcessFinishedMessage(){} // RVA: 0x7FFE89FAFFF0
        public void RaiseAlertFatal(){} // RVA: 0x7FFE89FB0200
        public void RaiseAlertWarning(){} // RVA: 0x7FFE89FB0310
        public void SendCertificateMessage(){} // RVA: 0x7FFE89FB0410
        public void SendChangeCipherSpecMessage(){} // RVA: 0x7FFE89FB0610
        public void SendFinishedMessage(){} // RVA: 0x7FFE89FB0840
        public void SendSupplementalDataMessage(){} // RVA: 0x7FFE89FB0950
        public void CreateVerifyData(){} // RVA: 0x7FFE89FB09E0
        public void Close(){} // RVA: 0x7FFE8699B180
        public void Flush(){} // RVA: 0x7FFE89FB0B10
        public void get_IsClosed(){} // RVA: 0x7FFE86DF7490
        public void ProcessMaxFragmentLengthExtension(){} // RVA: 0x7FFE89FB0B50
        public void RefuseRenegotiation(){} // RVA: 0x7FFE89FB0C00
        public void AssertEmpty(){} // RVA: 0x7FFE89FB0CF0
        public void CreateRandomBlock(){} // RVA: 0x7FFE89FB0D90
        public void CreateRenegotiationInfo(){} // RVA: 0x7FFE89FB0EF0
        public void EstablishMasterSecret(){} // RVA: 0x7FFE89FB0FC0
        public void GetCurrentPrfHash(){} // RVA: 0x7FFE89FB11A0
        public void ReadExtensions(){} // RVA: 0x7FFE89FB1330
        public void ReadSupplementalDataMessage(){} // RVA: 0x7FFE89FB16B0
        public void WriteExtensions(){} // RVA: 0x7FFE89FB1A90
        public void WriteSelectedExtensions(){} // RVA: 0x7FFE89FB1B70
        public void WriteSupplementalData(){} // RVA: 0x7FFE89FB1F50
        public void GetPrfAlgorithm(){} // RVA: 0x7FFE89FB2350
    }

    public class TlsProtocolHandler : TlsClientProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F9C230 | overloaded x2
    }

    public class TlsPskIdentity
    {
        // ── Methods ──
        public void SkipIdentityHint(){} // RVA: 0x7FFE80E45FE0
        public void NotifyIdentityHint(){} // RVA: 0x7FFE80E460A0
        public void GetPskIdentity(){} // RVA: 0x7FFE80E2E2E0
        public void GetPsk(){} // RVA: 0x7FFE80E2E2E0
    }

    public class TlsPskIdentityManager
    {
        // ── Methods ──
        public void GetHint(){} // RVA: 0x7FFE80E2E2E0
        public void GetPsk(){} // RVA: 0x7FFE80E2E390
    }

    public class TlsPskKeyExchange : AbstractTlsKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsPskIdentity mPskIdentity; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FB2A10 | overloaded x2
        public void SkipServerCredentials(){} // RVA: 0x7FFE89FB2D70
        public void ProcessServerCredentials(){} // RVA: 0x7FFE89FB2DD0
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFE89FB2F50
        public void ProcessServerCertificate(){} // RVA: 0x7FFE89FB32D0
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFE89FB35A0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFE89FB35C0
        public void ValidateCertificateRequest(){} // RVA: 0x7FFE89FB3880
        public void ProcessClientCredentials(){} // RVA: 0x7FFE89FB38D0
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFE89FB3920
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFE89FB3CC0
        public void GeneratePremasterSecret(){} // RVA: 0x7FFE89FB4070
        public void GenerateOtherSecret(){} // RVA: 0x7FFE89FB4240
        public void ValidateRsaPublicKey(){} // RVA: 0x7FFE89FB43D0
    }

    public class TlsRsaKeyExchange : AbstractTlsKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8754A7C0
        public void SkipServerCredentials(){} // RVA: 0x7FFE89FB4450
        public void ProcessServerCredentials(){} // RVA: 0x7FFE89FB44A0
        public void ProcessServerCertificate(){} // RVA: 0x7FFE89FB4620
        public void ValidateCertificateRequest(){} // RVA: 0x7FFE89FB48F0
        public void ProcessClientCredentials(){} // RVA: 0x7FFE89FB49B0
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFE89FB4A30
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFE89FB4AA0
        public void GeneratePremasterSecret(){} // RVA: 0x7FFE89FB4BC0
        public void ValidateRsaPublicKey(){} // RVA: 0x7FFE89FB4C70
    }

    public class TlsRsaSigner : AbstractTlsSigner
    {
        // ── Methods ──
        public void GenerateRawSignature(){} // RVA: 0x7FFE89FB4CF0
        public void VerifyRawSignature(){} // RVA: 0x7FFE89FB4E20
        public void CreateSigner(){} // RVA: 0x7FFE89FB4F00
        public void CreateVerifyer(){} // RVA: 0x7FFE89FB4FE0
        public void IsValidPublicKey(){} // RVA: 0x7FFE89FB5010
        public void MakeSigner(){} // RVA: 0x7FFE89FB5080
        public void CreateRsaImpl(){} // RVA: 0x7FFE89FB55D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TlsRsaUtilities : Object
    {
        // ── Methods ──
        public void GenerateEncryptedPreMasterSecret(){} // RVA: 0x7FFE89FB5650
        public void SafeDecryptPreMasterSecret(){} // RVA: 0x7FFE89FB5950
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TlsSRTPUtils : Object
    {
        // ── Methods ──
        public void AddUseSrtpExtension(){} // RVA: 0x7FFE89FBBC50
        public void GetUseSrtpExtension(){} // RVA: 0x7FFE89FBBD00
        public void CreateUseSrtpExtension(){} // RVA: 0x7FFE89FBBD70
        public void ReadUseSrtpExtension(){} // RVA: 0x7FFE89FBBF30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TlsServer
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void NotifyClientVersion(){} // RVA: 0x7FFE80E460A0
        public void NotifyFallback(){} // RVA: 0x7FFE80E466C0
        public void NotifyOfferedCipherSuites(){} // RVA: 0x7FFE80E460A0
        public void NotifyOfferedCompressionMethods(){} // RVA: 0x7FFE80E460A0
        public void ProcessClientExtensions(){} // RVA: 0x7FFE80E460A0
        public void GetServerVersion(){} // RVA: 0x7FFE80E2E2E0
        public void GetSelectedCipherSuite(){} // RVA: 0x7FFE80E2EDB0
        public void GetSelectedCompressionMethod(){} // RVA: 0x7FFE80E2F150
        public void GetServerExtensions(){} // RVA: 0x7FFE80E2E2E0
        public void GetServerSupplementalData(){} // RVA: 0x7FFE80E2E2E0
        public void GetCredentials(){} // RVA: 0x7FFE80E2E2E0
        public void GetCertificateStatus(){} // RVA: 0x7FFE80E2E2E0
        public void GetKeyExchange(){} // RVA: 0x7FFE80E2E2E0
        public void GetCertificateRequest(){} // RVA: 0x7FFE80E2E2E0
        public void ProcessClientSupplementalData(){} // RVA: 0x7FFE80E460A0
        public void NotifyClientCertificate(){} // RVA: 0x7FFE80E460A0
        public void GetNewSessionTicket(){} // RVA: 0x7FFE80E2E2E0
    }

    public class TlsServerContext
    {
    }

    public class TlsServerContextImpl : AbstractTlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FB5D60
        public void get_IsServer(){} // RVA: 0x7FFE811E0850
    }

    public class TlsServerProtocol : TlsProtocol
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsServer mTlsServer; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsServerContextImpl mTlsServerContext; // 0xB0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsKeyExchange mKeyExchange; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FB5E20 | overloaded x3
        public void Accept(){} // RVA: 0x7FFE89FB5E40
        public void CleanupHandshake(){} // RVA: 0x7FFE89FB61F0
        public void get_Context(){} // RVA: 0x7FFE81166040
        public void get_ContextAdmin(){} // RVA: 0x7FFE81166040
        public void get_Peer(){} // RVA: 0x7FFE817AB5E0
        public void HandleHandshakeMessage(){} // RVA: 0x7FFE89FB6380
        public void HandleAlertWarningMessage(){} // RVA: 0x7FFE89FB6F60
        public void NotifyClientCertificate(){} // RVA: 0x7FFE89FB7160
        public void ReceiveCertificateMessage(){} // RVA: 0x7FFE89FB7390
        public void ReceiveCertificateVerifyMessage(){} // RVA: 0x7FFE89FB74A0
        public void ReceiveClientHelloMessage(){} // RVA: 0x7FFE89FB78F0
        public void ReceiveClientKeyExchangeMessage(){} // RVA: 0x7FFE89FB7FA0
        public void SendCertificateRequestMessage(){} // RVA: 0x7FFE89FB8300
        public void SendCertificateStatusMessage(){} // RVA: 0x7FFE89FB83A0
        public void SendNewSessionTicketMessage(){} // RVA: 0x7FFE89FB8440
        public void SendServerHelloMessage(){} // RVA: 0x7FFE89FB8520
        public void SendServerHelloDoneMessage(){} // RVA: 0x7FFE89FB8F30
        public void SendServerKeyExchangeMessage(){} // RVA: 0x7FFE89FB9010
        public void ExpectCertificateVerifyMessage(){} // RVA: 0x7FFE89FB90C0
    }

    public class TlsSession
    {
        // ── Methods ──
        public void ExportSessionParameters(){} // RVA: 0x7FFE80E2E2E0
        public void get_SessionID(){} // RVA: 0x7FFE80E2E2E0
        public void Invalidate(){} // RVA: 0x7FFE80E45FE0
        public void get_IsResumable(){} // RVA: 0x7FFE80E2F150
    }

    public class TlsSessionImpl : Object
    {
        public byte[] mSessionID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.SessionParameters mSessionParameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FB9130
        public void ExportSessionParameters(){} // RVA: 0x7FFE89FB9380
        public void get_SessionID(){} // RVA: 0x7FFE89FB95A0
        public void Invalidate(){} // RVA: 0x7FFE89FB96E0
        public void get_IsResumable(){} // RVA: 0x7FFE89FB9800
    }

    public class TlsSigner
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void GenerateRawSignature(){} // RVA: 0x7FFE80E403A0 | overloaded x2
        public void VerifyRawSignature(){} // RVA: 0x7FFE80E32AD0 | overloaded x2
        public void CreateSigner(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void CreateVerifyer(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void IsValidPublicKey(){} // RVA: 0x7FFE80E2F3B0
    }

    public class TlsSignerCredentials
    {
        // ── Methods ──
        public void GenerateCertificateSignature(){} // RVA: 0x7FFE80E2E390
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x7FFE80E2E2E0
    }

    public class TlsSrpGroupVerifier
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0x7FFE80E2F3B0
    }

    public class TlsSrpIdentityManager
    {
        // ── Methods ──
        public void GetLoginParameters(){} // RVA: 0x7FFE80E2E390
    }

    public class TlsSrpKeyExchange : AbstractTlsKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSigner mTlsSigner; // 0x28

        // ── Methods ──
        public void CreateSigner(){} // RVA: 0x7FFE89FB9940
        public void .ctor(){} // RVA: 0x7FFE89FB9D10 | overloaded x3
        public void Init(){} // RVA: 0x7FFE89FBA020
        public void SkipServerCredentials(){} // RVA: 0x7FFE89FBA090
        public void ProcessServerCertificate(){} // RVA: 0x7FFE89FBA0F0
        public void ProcessServerCredentials(){} // RVA: 0x7FFE89FBA340
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFE811E0850
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFE89FBA4D0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFE89FBA900
        public void ValidateCertificateRequest(){} // RVA: 0x7FFE89FBAF10
        public void ProcessClientCredentials(){} // RVA: 0x7FFE89FBAF60
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFE89FBAFB0
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFE89FBB190
        public void GeneratePremasterSecret(){} // RVA: 0x7FFE89FBB3C0
        public void InitVerifyer(){} // RVA: 0x7FFE89FBB4A0
    }

    public class TlsSrpLoginParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters mGroup; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger mVerifier; // 0x18
        public byte[] mSalt; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00
        public void get_Group(){} // RVA: 0x7FFE81116380
        public void get_Salt(){} // RVA: 0x7FFE811290C0
        public void get_Verifier(){} // RVA: 0x7FFE810FE7C0
    }

    public class TlsSrpUtilities : Object
    {
        // ── Methods ──
        public void AddSrpExtension(){} // RVA: 0x7FFE89FBB5A0
        public void GetSrpExtension(){} // RVA: 0x7FFE89FBB730
        public void CreateSrpExtension(){} // RVA: 0x7FFE89FBB8A0
        public void ReadSrpExtension(){} // RVA: 0x7FFE89FBB9A0
        public void ReadSrpParameter(){} // RVA: 0x7FFE89FBBB10
        public void WriteSrpParameter(){} // RVA: 0x7FFE89FBBBC0
        public void IsSrpCipherSuite(){} // RVA: 0x7FFE89FBBC40
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TlsStream : Stream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsProtocol handler; // 0x28
        public object field_1; // 0x489
        public object field_2; // 0x48A
        public object field_3; // 0x48B
        public object field_4; // 0x48C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FBC2A0
        public void get_CanRead(){} // RVA: 0x7FFE89FBC340
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE89FBC340
        public void Close(){} // RVA: 0x7FFE89FBC370
        public void Flush(){} // RVA: 0x7FFE89FBC3B0
        public void get_Length(){} // RVA: 0x7FFE89FBC3E0
        public void get_Position(){} // RVA: 0x7FFE89FBC420
        public void set_Position(){} // RVA: 0x7FFE89FBC460
        public void Read(){} // RVA: 0x7FFE89FBC4A0
        public void ReadByte(){} // RVA: 0x7FFE89FBC4D0
        public void Seek(){} // RVA: 0x7FFE89FBC580
        public void SetLength(){} // RVA: 0x7FFE89FBC5C0
        public void Write(){} // RVA: 0x7FFE89FBC600
        public void WriteByte(){} // RVA: 0x7FFE89FBC630
    }

    public class TlsStreamCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FBC6D0
        public void GetPlaintextLimit(){} // RVA: 0x7FFE89FBCE70
        public void EncodePlaintext(){} // RVA: 0x7FFE89FBCEB0
        public void DecodeCiphertext(){} // RVA: 0x7FFE89FBD030
        public void CheckMac(){} // RVA: 0x7FFE89FBD210
        public void UpdateIV(){} // RVA: 0x7FFE89FBD380
    }

    public class TlsUtilities : Object
    {
        // ── Methods ──
        public void CheckUint8(){} // RVA: 0x7FFE89FBD530 | overloaded x2
        public void CheckUint16(){} // RVA: 0x7FFE89FBD650 | overloaded x2
        public void CheckUint24(){} // RVA: 0x7FFE89FBD770 | overloaded x2
        public void CheckUint32(){} // RVA: 0x7FFE89FBD800
        public void CheckUint48(){} // RVA: 0x7FFE89FBD890
        public void CheckUint64(){} // RVA: 0x7FFE89FBD930
        public void IsValidUint8(){} // RVA: 0x7FFE89FBD980 | overloaded x2
        public void IsValidUint16(){} // RVA: 0x7FFE89FBD9A0 | overloaded x2
        public void IsValidUint24(){} // RVA: 0x7FFE89FBD9C0 | overloaded x2
        public void IsValidUint32(){} // RVA: 0x7FFE89FBD9D0
        public void IsValidUint48(){} // RVA: 0x7FFE89FBD9E0
        public void IsValidUint64(){} // RVA: 0x7FFE811E0850
        public void IsSsl(){} // RVA: 0x7FFE89FBDA00
        public void IsTlsV11(){} // RVA: 0x7FFE89FBDB90 | overloaded x2
        public void IsTlsV12(){} // RVA: 0x7FFE89FBDDB0 | overloaded x2
        public void WriteUint8(){} // RVA: 0x7FFE89FBDF20 | overloaded x2
        public void WriteUint16(){} // RVA: 0x7FFE89FBDFB0 | overloaded x2
        public void WriteUint24(){} // RVA: 0x7FFE89FBE070 | overloaded x2
        public void WriteUint32(){} // RVA: 0x7FFE89FBE160 | overloaded x2
        public void WriteUint48(){} // RVA: 0x7FFE89FBE2B0 | overloaded x2
        public void WriteUint64(){} // RVA: 0x7FFE89FBE470 | overloaded x2
        public void WriteOpaque8(){} // RVA: 0x7FFE89FBE560
        public void WriteOpaque16(){} // RVA: 0x7FFE89FBE610
        public void WriteOpaque24(){} // RVA: 0x7FFE89FBE6E0
        public void WriteUint8Array(){} // RVA: 0x7FFE89FBE820 | overloaded x2
        public void WriteUint8ArrayWithUint8Length(){} // RVA: 0x7FFE89FBE990 | overloaded x2
        public void WriteUint16Array(){} // RVA: 0x7FFE89FBEB80 | overloaded x2
        public void WriteUint16ArrayWithUint16Length(){} // RVA: 0x7FFE89FBEDA0 | overloaded x2
        public void DecodeUint8(){} // RVA: 0x7FFE89FBEEE0
        public void DecodeUint8ArrayWithUint8Length(){} // RVA: 0x7FFE89FBEFD0
        public void EncodeOpaque8(){} // RVA: 0x7FFE89FBF160
        public void EncodeUint8(){} // RVA: 0x7FFE89FBF1F0
        public void EncodeUint8ArrayWithUint8Length(){} // RVA: 0x7FFE89FBF280
        public void EncodeUint16ArrayWithUint16Length(){} // RVA: 0x7FFE89FBF3E0
        public void ReadUint8(){} // RVA: 0x7FFE89FBF5F0 | overloaded x2
        public void ReadUint16(){} // RVA: 0x7FFE89FBF6C0 | overloaded x2
        public void ReadUint24(){} // RVA: 0x7FFE89FBF7C0 | overloaded x2
        public void ReadUint32(){} // RVA: 0x7FFE89FBF910 | overloaded x2
        public void ReadUint48(){} // RVA: 0x7FFE89FBFA00 | overloaded x2
        public void ReadAllOrNothing(){} // RVA: 0x7FFE89FBFAF0
        public void ReadFully(){} // RVA: 0x7FFE89FBFDC0 | overloaded x2
        public void ReadOpaque8(){} // RVA: 0x7FFE89FBFE90
        public void ReadOpaque16(){} // RVA: 0x7FFE89FBFF80
        public void ReadOpaque24(){} // RVA: 0x7FFE89FC0090
        public void ReadUint8Array(){} // RVA: 0x7FFE89FC00F0
        public void ReadUint16Array(){} // RVA: 0x7FFE89FC0210
        public void ReadVersion(){} // RVA: 0x7FFE89FC03E0 | overloaded x2
        public void ReadVersionRaw(){} // RVA: 0x7FFE89FC04C0 | overloaded x2
        public void ReadAsn1Object(){} // RVA: 0x7FFE89FC0560
        public void ReadDerObject(){} // RVA: 0x7FFE89FC06E0
        public void WriteGmtUnixTime(){} // RVA: 0x7FFE89FC0870
        public void WriteVersion(){} // RVA: 0x7FFE89FC09B0 | overloaded x2
        public void GetAllSignatureAlgorithms(){} // RVA: 0x7FFE89FC0A00
        public void GetDefaultDssSignatureAlgorithms(){} // RVA: 0x7FFE89FC0CB0
        public void GetDefaultECDsaSignatureAlgorithms(){} // RVA: 0x7FFE89FC0D70
        public void GetDefaultRsaSignatureAlgorithms(){} // RVA: 0x7FFE89FC0E30
        public void GetExtensionData(){} // RVA: 0x7FFE89FC0EF0
        public void GetDefaultSupportedSignatureAlgorithms(){} // RVA: 0x7FFE89FC0FB0
        public void GetSignatureAndHashAlgorithm(){} // RVA: 0x7FFE89FC11B0
        public void HasExpectedEmptyExtensionData(){} // RVA: 0x7FFE89FC12F0
        public void ImportSession(){} // RVA: 0x7FFE89FC13C0
        public void IsSignatureAlgorithmsExtensionAllowed(){} // RVA: 0x7FFE89FC1430
        public void AddSignatureAlgorithmsExtension(){} // RVA: 0x7FFE89FC1510
        public void GetSignatureAlgorithmsExtension(){} // RVA: 0x7FFE89FC1670
        public void CreateSignatureAlgorithmsExtension(){} // RVA: 0x7FFE89FC1800
        public void ReadSignatureAlgorithmsExtension(){} // RVA: 0x7FFE89FC18B0
        public void EncodeSupportedSignatureAlgorithms(){} // RVA: 0x7FFE89FC1A20
        public void ParseSupportedSignatureAlgorithms(){} // RVA: 0x7FFE89FC1E20
        public void VerifySupportedSignatureAlgorithm(){} // RVA: 0x7FFE89FC2050
        public void PRF(){} // RVA: 0x7FFE89FC23E0
        public void PRF_legacy(){} // RVA: 0x7FFE89FC2800 | overloaded x2
        public void Concat(){} // RVA: 0x7FFE89FC29A0
        public void HMacHash(){} // RVA: 0x7FFE89FC2A50
        public void ValidateKeyUsage(){} // RVA: 0x7FFE89FC2D20
        public void CalculateKeyBlock(){} // RVA: 0x7FFE89FC2E40
        public void CalculateKeyBlock_Ssl(){} // RVA: 0x7FFE89FC3040
        public void CalculateMasterSecret(){} // RVA: 0x7FFE89FC3660
        public void CalculateMasterSecret_Ssl(){} // RVA: 0x7FFE89FC38F0
        public void CalculateVerifyData(){} // RVA: 0x7FFE89FC3EB0
        public void CreateHash(){} // RVA: 0x7FFE89FC41E0 | overloaded x2
        public void CloneHash(){} // RVA: 0x7FFE89FC4280
        public void CreatePrfHash(){} // RVA: 0x7FFE89FC46B0
        public void ClonePrfHash(){} // RVA: 0x7FFE89FC4740
        public void GetHashAlgorithmForPrfAlgorithm(){} // RVA: 0x7FFE89FC4820
        public void GetOidForHashAlgorithm(){} // RVA: 0x7FFE89FC4910
        public void GetClientCertificateType(){} // RVA: 0x7FFE89FC4B20
        public void TrackHashAlgorithms(){} // RVA: 0x7FFE89FC4DF0
        public void HasSigningCapability(){} // RVA: 0x7FFE89FC5080
        public void CreateTlsSigner(){} // RVA: 0x7FFE89FC50A0
        public void GenSsl3Const(){} // RVA: 0x7FFE89FC51A0
        public void VectorOfOne(){} // RVA: 0x7FFE89FC5310
        public void GetCipherType(){} // RVA: 0x7FFE89FC5460
        public void GetEncryptionAlgorithm(){} // RVA: 0x7FFE89FC5560
        public void GetKeyExchangeAlgorithm(){} // RVA: 0x7FFE89FC5910
        public void GetMacAlgorithm(){} // RVA: 0x7FFE89FC5D10
        public void GetMinimumVersion(){} // RVA: 0x7FFE89FC5FB0
        public void IsAeadCipherSuite(){} // RVA: 0x7FFE89FC60C0
        public void IsBlockCipherSuite(){} // RVA: 0x7FFE89FC6120
        public void IsStreamCipherSuite(){} // RVA: 0x7FFE89FC6180
        public void IsValidCipherSuiteForSignatureAlgorithms(){} // RVA: 0x7FFE89FC61E0
        public void IsValidCipherSuiteForVersion(){} // RVA: 0x7FFE89FC63C0
        public void GetUsableSignatureAlgorithms(){} // RVA: 0x7FFE89FC65B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89FC6B10
    }

}