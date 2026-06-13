// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 61
// Methods: 663

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class TlsAeadCipher : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95377B0 | overloaded x2
        public void GetPlaintextLimit(){} // RVA: 0x9537C80
        public void EncodePlaintext(){} // RVA: 0x9537C90
        public void DecodeCiphertext(){} // RVA: 0x95380B0
        public void GetAdditionalData(){} // RVA: 0x9538500
    }

    public class TlsAgreementCredentials
    {
        // ── Methods ──
        public void GenerateAgreement(){} // RVA: 0xCE10
    }

    public class TlsAuthentication
    {
        // ── Methods ──
        public void NotifyServerCertificate(){} // RVA: 0x24B10
        public void GetClientCredentials(){} // RVA: 0x1E6A0
    }

    public class TlsBlockCipher
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext context; // 0x10
        public byte[] randomData; // 0x18

        // ── Methods ──
        public void get_WriteMac(){} // RVA: 0x4976A0
        public void get_ReadMac(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x9538630
        public void GetPlaintextLimit(){} // RVA: 0x9538F80
        public void EncodePlaintext(){} // RVA: 0x9539050
        public void DecodeCiphertext(){} // RVA: 0x9539590
        public void CheckPaddingConstantTime(){} // RVA: 0x9539B90
        public void ChooseExtraPadBlocks(){} // RVA: 0x9539D00
        public void LowestBitSet(){} // RVA: 0x9539DB0
    }

    public class TlsCipher
    {
        // ── Methods ──
        public void GetPlaintextLimit(){} // RVA: 0x13FB0
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
        public void get_HostNames(){} // RVA: 0xCD60
        public void set_HostNames(){} // RVA: 0x24B10
        public void Init(){} // RVA: 0x24B10
        public void GetSessionToResume(){} // RVA: 0xCD60
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0xCD60
        public void get_ClientVersion(){} // RVA: 0xCD60
        public void get_IsFallback(){} // RVA: 0xDBE0
        public void GetCipherSuites(){} // RVA: 0xCD60
        public void GetCompressionMethods(){} // RVA: 0xCD60
        public void GetClientExtensions(){} // RVA: 0xCD60
        public void NotifyServerVersion(){} // RVA: 0x24B10
        public void NotifySessionID(){} // RVA: 0x24B10
        public void NotifySelectedCipherSuite(){} // RVA: 0x24FA0
        public void NotifySelectedCompressionMethod(){} // RVA: 0x25130
        public void ProcessServerExtensions(){} // RVA: 0x24B10
        public void ProcessServerSupplementalData(){} // RVA: 0x24B10
        public void GetKeyExchange(){} // RVA: 0xCD60
        public void GetAuthentication(){} // RVA: 0xCD60
        public void GetClientSupplementalData(){} // RVA: 0xCD60
        public void NotifyNewSessionTicket(){} // RVA: 0x24B10
    }

    public class TlsClientContext
    {
    }

    public class TlsClientContextImpl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9539DD0
        public void get_IsServer(){} // RVA: 0x2DD320
    }

    public class TlsClientProtocol
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsClient mTlsClient; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsClientContextImpl mTlsClientContext; // 0xB0
        public byte[] mSelectedSessionID; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9539E70 | overloaded x3
        public void Connect(){} // RVA: 0x9539E80
        public void CleanupHandshake(){} // RVA: 0x953A2D0
        public void get_Context(){} // RVA: 0x348040
        public void get_ContextAdmin(){} // RVA: 0x348040
        public void get_Peer(){} // RVA: 0xA1C130
        public void HandleHandshakeMessage(){} // RVA: 0x953A4B0
        public void HandleSupplementalData(){} // RVA: 0x953B5F0
        public void ReceiveNewSessionTicketMessage(){} // RVA: 0x953B720
        public void ReceiveServerHelloMessage(){} // RVA: 0x953B810
        public void SendCertificateVerifyMessage(){} // RVA: 0x953C580
        public void SendClientHelloMessage(){} // RVA: 0x953C620
        public void SendClientKeyExchangeMessage(){} // RVA: 0x953CF80
    }

    public class TlsCompression
    {
        // ── Methods ──
        public void Compress(){} // RVA: 0xCE10
        public void Decompress(){} // RVA: 0xCE10
    }

    public class TlsContext
    {
        // ── Methods ──
        public void get_NonceRandomGenerator(){} // RVA: 0xCD60
        public void get_SecureRandom(){} // RVA: 0xCD60
        public void get_SecurityParameters(){} // RVA: 0xCD60
        public void get_IsServer(){} // RVA: 0xDBE0
        public void get_ClientVersion(){} // RVA: 0xCD60
        public void get_ServerVersion(){} // RVA: 0xCD60
        public void get_ResumableSession(){} // RVA: 0xCD60
        public void get_UserObject(){} // RVA: 0xCD60
        public void set_UserObject(){} // RVA: 0x24B10
        public void ExportKeyingMaterial(){}
    }

    public class TlsCredentials
    {
        // ── Methods ──
        public void get_Certificate(){} // RVA: 0xCD60
    }

    public class TlsDHKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSigner mTlsSigner; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x953DF60 | overloaded x2
        public void Init(){} // RVA: 0x953E1C0
        public void SkipServerCredentials(){} // RVA: 0x953E230
        public void ProcessServerCertificate(){} // RVA: 0x953E290
        public void get_RequiresServerKeyExchange(){} // RVA: 0x953E620
        public void GenerateServerKeyExchange(){} // RVA: 0x953E640
        public void ProcessServerKeyExchange(){} // RVA: 0x953E7A0
        public void ValidateCertificateRequest(){} // RVA: 0x953E980
        public void ProcessClientCredentials(){} // RVA: 0x953EA80
        public void GenerateClientKeyExchange(){} // RVA: 0x953EC30
        public void ProcessClientCertificate(){} // RVA: 0x953ED40
        public void ProcessClientKeyExchange(){} // RVA: 0x953EDA0
        public void GeneratePremasterSecret(){} // RVA: 0x953EEA0
    }

    public class TlsDHUtilities
    {
        // ── Methods ──
        public void FromHex(){} // RVA: 0x953EF80
        public void FromSafeP(){} // RVA: 0x953F030
        public void AddNegotiatedDheGroupsClientExtension(){} // RVA: 0x953F190
        public void AddNegotiatedDheGroupsServerExtension(){} // RVA: 0x953F320
        public void GetNegotiatedDheGroupsClientExtension(){} // RVA: 0x953F460
        public void GetNegotiatedDheGroupsServerExtension(){} // RVA: 0x953F5C0
        public void CreateNegotiatedDheGroupsClientExtension(){} // RVA: 0x953F6E0
        public void CreateNegotiatedDheGroupsServerExtension(){} // RVA: 0x953F780
        public void ReadNegotiatedDheGroupsClientExtension(){} // RVA: 0x953F7D0
        public void ReadNegotiatedDheGroupsServerExtension(){} // RVA: 0x953F870
        public void GetParametersForDHEGroup(){} // RVA: 0x953F8C0
        public void ContainsDheCipherSuites(){} // RVA: 0x953FA10
        public void IsDheCipherSuite(){} // RVA: 0x953FCF0
        public void AreCompatibleParameters(){} // RVA: 0x953FF30
        public void CalculateDHBasicAgreement(){} // RVA: 0x9540000
        public void GenerateDHKeyPair(){} // RVA: 0x95400B0
        public void GenerateEphemeralClientKeyExchange(){} // RVA: 0x9540180
        public void GenerateEphemeralServerKeyExchange(){} // RVA: 0x9540320
        public void ReadDHParameter(){} // RVA: 0x95405E0
        public void ReadDHParameters(){} // RVA: 0x9540690
        public void ReceiveDHParameters(){} // RVA: 0x9540740
        public void WriteDHParameter(){} // RVA: 0x9540900
        public void WriteDHParameters(){} // RVA: 0x9540980
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9540AB0
    }

    public class TlsDHVerifier
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0xDE40
    }

    public class TlsDeflateCompression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x953D1A0 | overloaded x2
        public void Compress(){} // RVA: 0x953D330
        public void Decompress(){} // RVA: 0x953D3C0
    }

    public class TlsDheKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x953D540 | overloaded x2
        public void ProcessServerCredentials(){} // RVA: 0x953D550
        public void GenerateServerKeyExchange(){} // RVA: 0x953D6D0
        public void ProcessServerKeyExchange(){} // RVA: 0x953DA90
        public void InitVerifyer(){} // RVA: 0x953DDC0
    }

    public class TlsDsaSigner
    {
        // ── Methods ──
        public void GenerateRawSignature(){} // RVA: 0x9541090
        public void VerifyRawSignature(){} // RVA: 0x95411E0
        public void CreateSigner(){} // RVA: 0x95412E0
        public void CreateVerifyer(){} // RVA: 0x9541310
        public void MakeInitParameters(){} // RVA: 0x1E80870
        public void MakeSigner(){} // RVA: 0x9541340
        public void get_SignatureAlgorithm(){} // RVA: 0xDBE0
        public void CreateDsaImpl(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TlsDssSigner
    {
        // ── Methods ──
        public void IsValidPublicKey(){} // RVA: 0x95415B0
        public void CreateDsaImpl(){} // RVA: 0x9541640
        public void get_SignatureAlgorithm(){} // RVA: 0x36258F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TlsECDHKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSigner mTlsSigner; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9545C20
        public void Init(){} // RVA: 0x9545EC0
        public void SkipServerCredentials(){} // RVA: 0x9545F30
        public void ProcessServerCertificate(){} // RVA: 0x9545F90
        public void get_RequiresServerKeyExchange(){} // RVA: 0x95462F0
        public void GenerateServerKeyExchange(){} // RVA: 0x9546310
        public void ProcessServerKeyExchange(){} // RVA: 0x9546490
        public void ValidateCertificateRequest(){} // RVA: 0x9546600
        public void ProcessClientCredentials(){} // RVA: 0x9546700
        public void GenerateClientKeyExchange(){} // RVA: 0x95468B0
        public void ProcessClientCertificate(){} // RVA: 0x95469D0
        public void ProcessClientKeyExchange(){} // RVA: 0x9546A30
        public void GeneratePremasterSecret(){} // RVA: 0x9546B50
    }

    public class TlsECDheKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9545180
        public void ProcessServerCredentials(){} // RVA: 0x9545190
        public void GenerateServerKeyExchange(){} // RVA: 0x9545310
        public void ProcessServerKeyExchange(){} // RVA: 0x9545700
        public void ValidateCertificateRequest(){} // RVA: 0x95459E0
        public void ProcessClientCredentials(){} // RVA: 0x9545AA0
        public void InitVerifyer(){} // RVA: 0x9545B20
    }

    public class TlsECDsaSigner
    {
        // ── Methods ──
        public void IsValidPublicKey(){} // RVA: 0x9546C30
        public void CreateDsaImpl(){} // RVA: 0x9546CC0
        public void get_SignatureAlgorithm(){} // RVA: 0x607DB00
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TlsEccUtilities
    {
        // ── Methods ──
        public void AddSupportedEllipticCurvesExtension(){} // RVA: 0x9541740
        public void AddSupportedPointFormatsExtension(){} // RVA: 0x9541810
        public void GetSupportedEllipticCurvesExtension(){} // RVA: 0x9541A10
        public void GetSupportedPointFormatsExtension(){} // RVA: 0x9541AB0
        public void CreateSupportedEllipticCurvesExtension(){} // RVA: 0x9541B50
        public void CreateSupportedPointFormatsExtension(){} // RVA: 0x9541D70
        public void ReadSupportedEllipticCurvesExtension(){} // RVA: 0x9541ED0
        public void ReadSupportedPointFormatsExtension(){} // RVA: 0x95420B0
        public void GetNameOfNamedCurve(){} // RVA: 0x95421A0
        public void GetParametersForNamedCurve(){} // RVA: 0x9542250
        public void HasAnySupportedNamedCurves(){} // RVA: 0x95425A0
        public void ContainsEccCipherSuites(){} // RVA: 0x9542610
        public void IsEccCipherSuite(){} // RVA: 0x95426C0
        public void AreOnSameCurve(){} // RVA: 0x9542750
        public void IsSupportedNamedCurve(){} // RVA: 0x9542770
        public void IsCompressionPreferred(){} // RVA: 0x95427F0
        public void SerializeECFieldElement(){} // RVA: 0x9542840
        public void SerializeECPoint(){} // RVA: 0x9542860
        public void SerializeECPublicKey(){} // RVA: 0x9542A10
        public void DeserializeECFieldElement(){} // RVA: 0x9542A80
        public void DeserializeECPoint(){} // RVA: 0x9542B50
        public void DeserializeECPublicKey(){} // RVA: 0x9542DA0
        public void CalculateECDHBasicAgreement(){} // RVA: 0x9542EF0
        public void GenerateECKeyPair(){} // RVA: 0x9542FB0
        public void GenerateEphemeralClientKeyExchange(){} // RVA: 0x95430A0
        public void GenerateEphemeralServerKeyExchange(){} // RVA: 0x9543390
        public void ValidateECPublicKey(){} // RVA: 0x1A3F520
        public void ReadECExponent(){} // RVA: 0x9543700
        public void ReadECFieldElement(){} // RVA: 0x9543800
        public void ReadECParameter(){} // RVA: 0x9543940
        public void ReadECParameters(){} // RVA: 0x95439F0
        public void CheckNamedCurve(){} // RVA: 0x9544060
        public void WriteECExponent(){} // RVA: 0x9544120
        public void WriteECFieldElement(){} // RVA: 0x95442C0 | overloaded x2
        public void WriteECParameter(){} // RVA: 0x95443F0
        public void WriteExplicitECParameters(){} // RVA: 0x95444E0
        public void WriteECPoint(){} // RVA: 0x9544A90
        public void WriteNamedECParameters(){} // RVA: 0x9544BB0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9544CB0
    }

    public class TlsEncryptionCredentials
    {
        // ── Methods ──
        public void DecryptPreMasterSecret(){} // RVA: 0xCE10
    }

    public class TlsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E254B0
    }

    public class TlsExtensionsUtilities
    {
        // ── Methods ──
        public void EnsureExtensionsInitialised(){} // RVA: 0x9546DC0
        public void AddClientCertificateTypeExtensionClient(){} // RVA: 0x9546E60
        public void AddClientCertificateTypeExtensionServer(){} // RVA: 0x9546F10
        public void AddEncryptThenMacExtension(){} // RVA: 0x9546FF0
        public void AddExtendedMasterSecretExtension(){} // RVA: 0x95470D0
        public void AddHeartbeatExtension(){} // RVA: 0x95471B0
        public void AddMaxFragmentLengthExtension(){} // RVA: 0x9547310
        public void AddPaddingExtension(){} // RVA: 0x95473F0
        public void AddServerCertificateTypeExtensionClient(){} // RVA: 0x95474F0
        public void AddServerCertificateTypeExtensionServer(){} // RVA: 0x95475A0
        public void AddServerNameExtension(){} // RVA: 0x9547680
        public void AddStatusRequestExtension(){} // RVA: 0x9547860
        public void AddTruncatedHMacExtension(){} // RVA: 0x95479C0
        public void GetClientCertificateTypeExtensionClient(){} // RVA: 0x9547AA0
        public void GetClientCertificateTypeExtensionServer(){} // RVA: 0x9547B10
        public void GetHeartbeatExtension(){} // RVA: 0x9547BC0
        public void GetMaxFragmentLengthExtension(){} // RVA: 0x9547C30
        public void GetPaddingExtension(){} // RVA: 0x9547CE0
        public void GetServerCertificateTypeExtensionClient(){} // RVA: 0x9547DC0
        public void GetServerCertificateTypeExtensionServer(){} // RVA: 0x9547E30
        public void GetServerNameExtension(){} // RVA: 0x9547EE0
        public void GetStatusRequestExtension(){} // RVA: 0x9548030
        public void HasEncryptThenMacExtension(){} // RVA: 0x9548180
        public void HasExtendedMasterSecretExtension(){} // RVA: 0x9548230
        public void HasTruncatedHMacExtension(){} // RVA: 0x95482E0
        public void CreateCertificateTypeExtensionClient(){} // RVA: 0x9548390
        public void CreateCertificateTypeExtensionServer(){} // RVA: 0x9548430
        public void CreateEmptyExtensionData(){} // RVA: 0x9548480
        public void CreateEncryptThenMacExtension(){} // RVA: 0x95484E0
        public void CreateExtendedMasterSecretExtension(){} // RVA: 0x95484E0
        public void CreateHeartbeatExtension(){} // RVA: 0x9548540
        public void CreateMaxFragmentLengthExtension(){} // RVA: 0x9548610
        public void CreatePaddingExtension(){} // RVA: 0x9548660
        public void CreateServerNameExtension(){} // RVA: 0x95486D0
        public void CreateStatusRequestExtension(){} // RVA: 0x95487A0
        public void CreateTruncatedHMacExtension(){} // RVA: 0x95484E0
        public void ReadEmptyExtensionData(){} // RVA: 0x9548870
        public void ReadCertificateTypeExtensionClient(){} // RVA: 0x9548910
        public void ReadCertificateTypeExtensionServer(){} // RVA: 0x95489B0
        public void ReadEncryptThenMacExtension(){} // RVA: 0x9548870
        public void ReadExtendedMasterSecretExtension(){} // RVA: 0x9548870
        public void ReadHeartbeatExtension(){} // RVA: 0x9548A00
        public void ReadMaxFragmentLengthExtension(){} // RVA: 0x9548C40
        public void ReadPaddingExtension(){} // RVA: 0x9548C90
        public void ReadServerNameExtension(){} // RVA: 0x9548D60
        public void ReadStatusRequestExtension(){} // RVA: 0x9548EB0
        public void ReadTruncatedHMacExtension(){} // RVA: 0x9548870
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TlsFatalAlert
    {
        public byte alertDescription; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9549050 | overloaded x2
        public void get_AlertDescription(){} // RVA: 0x134A670
    }

    public class TlsFatalAlertReceived
    {
        public byte alertDescription; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9549000
        public void get_AlertDescription(){} // RVA: 0x134A670
    }

    public class TlsHandshakeHash
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x24B10
        public void NotifyPrfDetermined(){} // RVA: 0xCD60
        public void TrackHashAlgorithm(){} // RVA: 0x25130
        public void SealHashAlgorithms(){} // RVA: 0x24A50
        public void StopTracking(){} // RVA: 0xCD60
        public void ForkPrfHash(){} // RVA: 0xCD60
        public void GetFinalHash(){}
    }

    public class TlsKeyExchange
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x24B10
        public void SkipServerCredentials(){} // RVA: 0x24A50
        public void ProcessServerCredentials(){} // RVA: 0x24B10
        public void ProcessServerCertificate(){} // RVA: 0x24B10
        public void get_RequiresServerKeyExchange(){} // RVA: 0xDBE0
        public void GenerateServerKeyExchange(){} // RVA: 0xCD60
        public void SkipServerKeyExchange(){} // RVA: 0x24A50
        public void ProcessServerKeyExchange(){} // RVA: 0x24B10
        public void ValidateCertificateRequest(){} // RVA: 0x24B10
        public void SkipClientCredentials(){} // RVA: 0x24A50
        public void ProcessClientCredentials(){} // RVA: 0x24B10
        public void ProcessClientCertificate(){} // RVA: 0x24B10
        public void GenerateClientKeyExchange(){} // RVA: 0x24B10
        public void ProcessClientKeyExchange(){} // RVA: 0x24B10
        public void GeneratePremasterSecret(){} // RVA: 0xCD60
    }

    public class TlsMac
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext context; // 0x10
        public byte[] secret; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95490B0
        public void get_MacSecret(){} // RVA: 0x2E07C0
        public void get_Size(){} // RVA: 0x338CD0
        public void CalculateMac(){} // RVA: 0x95495E0
        public void CalculateMacConstantTime(){} // RVA: 0x95498F0
        public void GetDigestBlockCount(){} // RVA: 0x9549B20
        public void Truncate(){} // RVA: 0x9549B30
    }

    public class TlsNoCloseNotifyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9549BB0
    }

    public class TlsNullCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9549D00 | overloaded x2
        public void GetPlaintextLimit(){} // RVA: 0x954A130
        public void EncodePlaintext(){} // RVA: 0x954A160
        public void DecodeCiphertext(){} // RVA: 0x954A2C0
    }

    public class TlsNullCompression
    {
        // ── Methods ──
        public void Compress(){} // RVA: 0x13DCE00
        public void Decompress(){} // RVA: 0x13DCE00
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TlsPeer
    {
        // ── Methods ──
        public void RequiresExtendedMasterSecret(){} // RVA: 0xDBE0
        public void ShouldUseGmtUnixTime(){} // RVA: 0xDBE0
        public void NotifySecureRenegotiation(){} // RVA: 0x25130
        public void GetCompression(){} // RVA: 0xCD60
        public void GetCipher(){} // RVA: 0xCD60
        public void NotifyAlertRaised(){}
        public void NotifyAlertReceived(){} // RVA: 0x251C0
        public void NotifyHandshakeComplete(){} // RVA: 0x24A50
    }

    public class TlsProtocol
    {
        public short CS_START;
        public short CS_CLIENT_HELLO;
        public short CS_SERVER_HELLO;
        public short CS_SERVER_SUPPLEMENTAL_DATA;
        public short CS_SERVER_CERTIFICATE;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x954A9A0 | overloaded x3
        public void get_Context(){} // RVA: 0xCD60
        public void get_ContextAdmin(){} // RVA: 0xCD60
        public void get_Peer(){} // RVA: 0xCD60
        public void HandleAlertMessage(){} // RVA: 0x954AF20
        public void HandleAlertWarningMessage(){} // RVA: 0x954B010
        public void HandleChangeCipherSpecMessage(){} // RVA: 0x2DD310
        public void HandleClose(){} // RVA: 0x954B090
        public void HandleException(){} // RVA: 0x954B180
        public void HandleFailure(){} // RVA: 0x954B1E0
        public void HandleHandshakeMessage(){} // RVA: 0x25600
        public void ApplyMaxFragmentLengthExtension(){} // RVA: 0x954B260
        public void CheckReceivedChangeCipherSpec(){} // RVA: 0x954B310
        public void CleanupHandshake(){} // RVA: 0x954B370
        public void BlockForHandshake(){} // RVA: 0x954B680
        public void CompleteHandshake(){} // RVA: 0x954B710
        public void ProcessRecord(){} // RVA: 0x954BE00
        public void ProcessHandshakeQueue(){} // RVA: 0x954C2B0
        public void ProcessApplicationDataQueue(){} // RVA: 0x2DD310
        public void ProcessAlertQueue(){} // RVA: 0x954C530
        public void ProcessChangeCipherSpec(){} // RVA: 0x954C630
        public void ApplicationDataAvailable(){} // RVA: 0x1A3AF00
        public void ReadApplicationData(){} // RVA: 0x954C7D0
        public void SafeCheckRecordHeader(){} // RVA: 0x954C9A0
        public void SafeReadRecord(){} // RVA: 0x954CB00
        public void SafeWriteRecord(){} // RVA: 0x954CD20
        public void WriteData(){} // RVA: 0x954CE90
        public void SetAppDataSplitMode(){} // RVA: 0x954D090
        public void WriteHandshakeMessage(){} // RVA: 0x954D140
        public void get_Stream(){} // RVA: 0x954D2F0
        public void CloseInput(){} // RVA: 0x954D360
        public void OfferInput(){} // RVA: 0x954D4C0 | overloaded x2
        public void GetAvailableInputBytes(){} // RVA: 0x954D780
        public void ReadInput(){} // RVA: 0x954D800
        public void OfferOutput(){} // RVA: 0x954D910
        public void GetAvailableOutputBytes(){} // RVA: 0x954D9E0
        public void ReadOutput(){} // RVA: 0x954DA70
        public void InvalidateSession(){} // RVA: 0x954DB00
        public void ProcessFinishedMessage(){} // RVA: 0x954DC20
        public void RaiseAlertFatal(){} // RVA: 0x954DE30
        public void RaiseAlertWarning(){} // RVA: 0x954DF40
        public void SendCertificateMessage(){} // RVA: 0x954E040
        public void SendChangeCipherSpecMessage(){} // RVA: 0x954E240
        public void SendFinishedMessage(){} // RVA: 0x954E470
        public void SendSupplementalDataMessage(){} // RVA: 0x954E580
        public void CreateVerifyData(){} // RVA: 0x954E610
        public void Close(){} // RVA: 0x5E5A340
        public void Flush(){} // RVA: 0x954E740
        public void get_IsClosed(){} // RVA: 0x62B6A60
        public void ProcessMaxFragmentLengthExtension(){} // RVA: 0x954E780
        public void RefuseRenegotiation(){} // RVA: 0x954E830
        public void AssertEmpty(){} // RVA: 0x954E920
        public void CreateRandomBlock(){} // RVA: 0x954E9C0
        public void CreateRenegotiationInfo(){} // RVA: 0x954EB20
        public void EstablishMasterSecret(){} // RVA: 0x954EBF0
        public void GetCurrentPrfHash(){} // RVA: 0x954EDD0
        public void ReadExtensions(){} // RVA: 0x954EF60
        public void ReadSupplementalDataMessage(){} // RVA: 0x954F2E0
        public void WriteExtensions(){} // RVA: 0x954F6C0
        public void WriteSelectedExtensions(){} // RVA: 0x954F7A0
        public void WriteSupplementalData(){} // RVA: 0x954FB80
        public void GetPrfAlgorithm(){} // RVA: 0x954FF80
    }

    public class TlsProtocolHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9539E60 | overloaded x2
    }

    public class TlsPskIdentity
    {
        // ── Methods ──
        public void SkipIdentityHint(){} // RVA: 0x24A50
        public void NotifyIdentityHint(){} // RVA: 0x24B10
        public void GetPskIdentity(){} // RVA: 0xCD60
        public void GetPsk(){} // RVA: 0xCD60
    }

    public class TlsPskIdentityManager
    {
        // ── Methods ──
        public void GetHint(){} // RVA: 0xCD60
        public void GetPsk(){} // RVA: 0xCE10
    }

    public class TlsPskKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsPskIdentity mPskIdentity; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9550640 | overloaded x2
        public void SkipServerCredentials(){} // RVA: 0x95509A0
        public void ProcessServerCredentials(){} // RVA: 0x9550A00
        public void GenerateServerKeyExchange(){} // RVA: 0x9550B80
        public void ProcessServerCertificate(){} // RVA: 0x9550F00
        public void get_RequiresServerKeyExchange(){} // RVA: 0x95511D0
        public void ProcessServerKeyExchange(){} // RVA: 0x95511F0
        public void ValidateCertificateRequest(){} // RVA: 0x95514B0
        public void ProcessClientCredentials(){} // RVA: 0x9551500
        public void GenerateClientKeyExchange(){} // RVA: 0x9551550
        public void ProcessClientKeyExchange(){} // RVA: 0x95518F0
        public void GeneratePremasterSecret(){} // RVA: 0x9551CA0
        public void GenerateOtherSecret(){} // RVA: 0x9551E70
        public void ValidateRsaPublicKey(){} // RVA: 0x9552000
    }

    public class TlsRsaKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A0B4C0
        public void SkipServerCredentials(){} // RVA: 0x9552080
        public void ProcessServerCredentials(){} // RVA: 0x95520D0
        public void ProcessServerCertificate(){} // RVA: 0x9552250
        public void ValidateCertificateRequest(){} // RVA: 0x9552520
        public void ProcessClientCredentials(){} // RVA: 0x95525E0
        public void GenerateClientKeyExchange(){} // RVA: 0x9552660
        public void ProcessClientKeyExchange(){} // RVA: 0x95526D0
        public void GeneratePremasterSecret(){} // RVA: 0x95527F0
        public void ValidateRsaPublicKey(){} // RVA: 0x95528A0
    }

    public class TlsRsaSigner
    {
        // ── Methods ──
        public void GenerateRawSignature(){} // RVA: 0x9552920
        public void VerifyRawSignature(){} // RVA: 0x9552A50
        public void CreateSigner(){} // RVA: 0x9552B30
        public void CreateVerifyer(){} // RVA: 0x9552C10
        public void IsValidPublicKey(){} // RVA: 0x9552C40
        public void MakeSigner(){} // RVA: 0x9552CB0
        public void CreateRsaImpl(){} // RVA: 0x9553200
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TlsRsaUtilities
    {
        // ── Methods ──
        public void GenerateEncryptedPreMasterSecret(){} // RVA: 0x9553280
        public void SafeDecryptPreMasterSecret(){} // RVA: 0x9553580
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TlsSRTPUtils
    {
        // ── Methods ──
        public void AddUseSrtpExtension(){} // RVA: 0x9559880
        public void GetUseSrtpExtension(){} // RVA: 0x9559930
        public void CreateUseSrtpExtension(){} // RVA: 0x95599A0
        public void ReadUseSrtpExtension(){} // RVA: 0x9559B60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TlsServer
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x24B10
        public void NotifyClientVersion(){} // RVA: 0x24B10
        public void NotifyFallback(){} // RVA: 0x25130
        public void NotifyOfferedCipherSuites(){} // RVA: 0x24B10
        public void NotifyOfferedCompressionMethods(){} // RVA: 0x24B10
        public void ProcessClientExtensions(){} // RVA: 0x24B10
        public void GetServerVersion(){} // RVA: 0xCD60
        public void GetSelectedCipherSuite(){} // RVA: 0xD840
        public void GetSelectedCompressionMethod(){} // RVA: 0xDBE0
        public void GetServerExtensions(){} // RVA: 0xCD60
        public void GetServerSupplementalData(){} // RVA: 0xCD60
        public void GetCredentials(){} // RVA: 0xCD60
        public void GetCertificateStatus(){} // RVA: 0xCD60
        public void GetKeyExchange(){} // RVA: 0xCD60
        public void GetCertificateRequest(){} // RVA: 0xCD60
        public void ProcessClientSupplementalData(){} // RVA: 0x24B10
        public void NotifyClientCertificate(){} // RVA: 0x24B10
        public void GetNewSessionTicket(){} // RVA: 0xCD60
    }

    public class TlsServerContext
    {
    }

    public class TlsServerContextImpl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9553990
        public void get_IsServer(){} // RVA: 0x3C2850
    }

    public class TlsServerProtocol
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsServer mTlsServer; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsServerContextImpl mTlsServerContext; // 0xB0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsKeyExchange mKeyExchange; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9553A50 | overloaded x3
        public void Accept(){} // RVA: 0x9553A70
        public void CleanupHandshake(){} // RVA: 0x9553E20
        public void get_Context(){} // RVA: 0x348040
        public void get_ContextAdmin(){} // RVA: 0x348040
        public void get_Peer(){} // RVA: 0xA1C130
        public void HandleHandshakeMessage(){} // RVA: 0x9553FB0
        public void HandleAlertWarningMessage(){} // RVA: 0x9554B90
        public void NotifyClientCertificate(){} // RVA: 0x9554D90
        public void ReceiveCertificateMessage(){} // RVA: 0x9554FC0
        public void ReceiveCertificateVerifyMessage(){} // RVA: 0x95550D0
        public void ReceiveClientHelloMessage(){} // RVA: 0x9555520
        public void ReceiveClientKeyExchangeMessage(){} // RVA: 0x9555BD0
        public void SendCertificateRequestMessage(){} // RVA: 0x9555F30
        public void SendCertificateStatusMessage(){} // RVA: 0x9555FD0
        public void SendNewSessionTicketMessage(){} // RVA: 0x9556070
        public void SendServerHelloMessage(){} // RVA: 0x9556150
        public void SendServerHelloDoneMessage(){} // RVA: 0x9556B60
        public void SendServerKeyExchangeMessage(){} // RVA: 0x9556C40
        public void ExpectCertificateVerifyMessage(){} // RVA: 0x9556CF0
    }

    public class TlsSession
    {
        // ── Methods ──
        public void ExportSessionParameters(){} // RVA: 0xCD60
        public void get_SessionID(){} // RVA: 0xCD60
        public void Invalidate(){} // RVA: 0x24A50
        public void get_IsResumable(){} // RVA: 0xDBE0
    }

    public class TlsSessionImpl
    {
        public byte[] mSessionID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.SessionParameters mSessionParameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9556D60
        public void ExportSessionParameters(){} // RVA: 0x9556FB0
        public void get_SessionID(){} // RVA: 0x95571D0
        public void Invalidate(){} // RVA: 0x9557310
        public void get_IsResumable(){} // RVA: 0x9557430
    }

    public class TlsSigner
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x24B10
        public void GenerateRawSignature(){} // RVA: 0x1EE30 | overloaded x2
        public void VerifyRawSignature(){} // RVA: 0x115A0 | overloaded x2
        public void CreateSigner(){} // RVA: 0x1E6A0 | overloaded x2
        public void CreateVerifyer(){} // RVA: 0x1E6A0 | overloaded x2
        public void IsValidPublicKey(){} // RVA: 0xDE40
    }

    public class TlsSignerCredentials
    {
        // ── Methods ──
        public void GenerateCertificateSignature(){} // RVA: 0xCE10
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0xCD60
    }

    public class TlsSrpGroupVerifier
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0xDE40
    }

    public class TlsSrpIdentityManager
    {
        // ── Methods ──
        public void GetLoginParameters(){} // RVA: 0xCE10
    }

    public class TlsSrpKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSigner mTlsSigner; // 0x28

        // ── Methods ──
        public void CreateSigner(){} // RVA: 0x9557570
        public void .ctor(){} // RVA: 0x9557940 | overloaded x3
        public void Init(){} // RVA: 0x9557C50
        public void SkipServerCredentials(){} // RVA: 0x9557CC0
        public void ProcessServerCertificate(){} // RVA: 0x9557D20
        public void ProcessServerCredentials(){} // RVA: 0x9557F70
        public void get_RequiresServerKeyExchange(){} // RVA: 0x3C2850
        public void GenerateServerKeyExchange(){} // RVA: 0x9558100
        public void ProcessServerKeyExchange(){} // RVA: 0x9558530
        public void ValidateCertificateRequest(){} // RVA: 0x9558B40
        public void ProcessClientCredentials(){} // RVA: 0x9558B90
        public void GenerateClientKeyExchange(){} // RVA: 0x9558BE0
        public void ProcessClientKeyExchange(){} // RVA: 0x9558DC0
        public void GeneratePremasterSecret(){} // RVA: 0x9558FF0
        public void InitVerifyer(){} // RVA: 0x95590D0
    }

    public class TlsSrpLoginParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters mGroup; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger mVerifier; // 0x18
        public byte[] mSalt; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BCE00
        public void get_Group(){} // RVA: 0x2F8380
        public void get_Salt(){} // RVA: 0x30B0C0
        public void get_Verifier(){} // RVA: 0x2E07C0
    }

    public class TlsSrpUtilities
    {
        // ── Methods ──
        public void AddSrpExtension(){} // RVA: 0x95591D0
        public void GetSrpExtension(){} // RVA: 0x9559360
        public void CreateSrpExtension(){} // RVA: 0x95594D0
        public void ReadSrpExtension(){} // RVA: 0x95595D0
        public void ReadSrpParameter(){} // RVA: 0x9559740
        public void WriteSrpParameter(){} // RVA: 0x95597F0
        public void IsSrpCipherSuite(){} // RVA: 0x9559870
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TlsStream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsProtocol handler; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9559ED0
        public void get_CanRead(){} // RVA: 0x9559F70
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x9559F70
        public void Close(){} // RVA: 0x9559FA0
        public void Flush(){} // RVA: 0x9559FE0
        public void get_Length(){} // RVA: 0x955A010
        public void get_Position(){} // RVA: 0x955A050
        public void set_Position(){} // RVA: 0x955A090
        public void Read(){} // RVA: 0x955A0D0
        public void ReadByte(){} // RVA: 0x955A100
        public void Seek(){} // RVA: 0x955A1B0
        public void SetLength(){} // RVA: 0x955A1F0
        public void Write(){} // RVA: 0x955A230
        public void WriteByte(){} // RVA: 0x955A260
    }

    public class TlsStreamCipher : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x955A300
        public void GetPlaintextLimit(){} // RVA: 0x955AAA0
        public void EncodePlaintext(){} // RVA: 0x955AAE0
        public void DecodeCiphertext(){} // RVA: 0x955AC60
        public void CheckMac(){} // RVA: 0x955AE40
        public void UpdateIV(){} // RVA: 0x955AFB0
    }

    public class TlsUtilities
    {
        // ── Methods ──
        public void CheckUint8(){} // RVA: 0x955B160 | overloaded x2
        public void CheckUint16(){} // RVA: 0x955B280 | overloaded x2
        public void CheckUint24(){} // RVA: 0x955B3A0 | overloaded x2
        public void CheckUint32(){} // RVA: 0x955B430
        public void CheckUint48(){} // RVA: 0x955B4C0
        public void CheckUint64(){} // RVA: 0x955B560
        public void IsValidUint8(){} // RVA: 0x955B5B0 | overloaded x2
        public void IsValidUint16(){} // RVA: 0x955B5D0 | overloaded x2
        public void IsValidUint24(){} // RVA: 0x955B5F0 | overloaded x2
        public void IsValidUint32(){} // RVA: 0x955B600
        public void IsValidUint48(){} // RVA: 0x955B610
        public void IsValidUint64(){} // RVA: 0x3C2850
        public void IsSsl(){} // RVA: 0x955B630
        public void IsTlsV11(){} // RVA: 0x955B7C0 | overloaded x2
        public void IsTlsV12(){} // RVA: 0x955B9E0 | overloaded x2
        public void WriteUint8(){} // RVA: 0x955BB50 | overloaded x2
        public void WriteUint16(){} // RVA: 0x955BBE0 | overloaded x2
        public void WriteUint24(){} // RVA: 0x955BCA0 | overloaded x2
        public void WriteUint32(){} // RVA: 0x955BD90 | overloaded x2
        public void WriteUint48(){} // RVA: 0x955BEE0 | overloaded x2
        public void WriteUint64(){} // RVA: 0x955C0A0 | overloaded x2
        public void WriteOpaque8(){} // RVA: 0x955C190
        public void WriteOpaque16(){} // RVA: 0x955C240
        public void WriteOpaque24(){} // RVA: 0x955C310
        public void WriteUint8Array(){} // RVA: 0x955C450 | overloaded x2
        public void WriteUint8ArrayWithUint8Length(){} // RVA: 0x955C5C0 | overloaded x2
        public void WriteUint16Array(){} // RVA: 0x955C7B0 | overloaded x2
        public void WriteUint16ArrayWithUint16Length(){} // RVA: 0x955C9D0 | overloaded x2
        public void DecodeUint8(){} // RVA: 0x955CB10
        public void DecodeUint8ArrayWithUint8Length(){} // RVA: 0x955CC00
        public void EncodeOpaque8(){} // RVA: 0x955CD90
        public void EncodeUint8(){} // RVA: 0x955CE20
        public void EncodeUint8ArrayWithUint8Length(){} // RVA: 0x955CEB0
        public void EncodeUint16ArrayWithUint16Length(){} // RVA: 0x955D010
        public void ReadUint8(){} // RVA: 0x955D220 | overloaded x2
        public void ReadUint16(){} // RVA: 0x955D2F0 | overloaded x2
        public void ReadUint24(){} // RVA: 0x955D3F0 | overloaded x2
        public void ReadUint32(){} // RVA: 0x955D540 | overloaded x2
        public void ReadUint48(){} // RVA: 0x955D630 | overloaded x2
        public void ReadAllOrNothing(){} // RVA: 0x955D720
        public void ReadFully(){} // RVA: 0x955D9F0 | overloaded x2
        public void ReadOpaque8(){} // RVA: 0x955DAC0
        public void ReadOpaque16(){} // RVA: 0x955DBB0
        public void ReadOpaque24(){} // RVA: 0x955DCC0
        public void ReadUint8Array(){} // RVA: 0x955DD20
        public void ReadUint16Array(){} // RVA: 0x955DE40
        public void ReadVersion(){} // RVA: 0x955E010 | overloaded x2
        public void ReadVersionRaw(){} // RVA: 0x955E0F0 | overloaded x2
        public void ReadAsn1Object(){} // RVA: 0x955E190
        public void ReadDerObject(){} // RVA: 0x955E310
        public void WriteGmtUnixTime(){} // RVA: 0x955E4A0
        public void WriteVersion(){} // RVA: 0x955E5E0 | overloaded x2
        public void GetAllSignatureAlgorithms(){} // RVA: 0x955E630
        public void GetDefaultDssSignatureAlgorithms(){} // RVA: 0x955E8E0
        public void GetDefaultECDsaSignatureAlgorithms(){} // RVA: 0x955E9A0
        public void GetDefaultRsaSignatureAlgorithms(){} // RVA: 0x955EA60
        public void GetExtensionData(){} // RVA: 0x955EB20
        public void GetDefaultSupportedSignatureAlgorithms(){} // RVA: 0x955EBE0
        public void GetSignatureAndHashAlgorithm(){} // RVA: 0x955EDE0
        public void HasExpectedEmptyExtensionData(){} // RVA: 0x955EF20
        public void ImportSession(){} // RVA: 0x955EFF0
        public void IsSignatureAlgorithmsExtensionAllowed(){} // RVA: 0x955F060
        public void AddSignatureAlgorithmsExtension(){} // RVA: 0x955F140
        public void GetSignatureAlgorithmsExtension(){} // RVA: 0x955F2A0
        public void CreateSignatureAlgorithmsExtension(){} // RVA: 0x955F430
        public void ReadSignatureAlgorithmsExtension(){} // RVA: 0x955F4E0
        public void EncodeSupportedSignatureAlgorithms(){} // RVA: 0x955F650
        public void ParseSupportedSignatureAlgorithms(){} // RVA: 0x955FA50
        public void VerifySupportedSignatureAlgorithm(){} // RVA: 0x955FC80
        public void PRF(){} // RVA: 0x9560010
        public void PRF_legacy(){} // RVA: 0x9560430 | overloaded x2
        public void Concat(){} // RVA: 0x95605D0
        public void HMacHash(){} // RVA: 0x9560680
        public void ValidateKeyUsage(){} // RVA: 0x9560950
        public void CalculateKeyBlock(){} // RVA: 0x9560A70
        public void CalculateKeyBlock_Ssl(){} // RVA: 0x9560C70
        public void CalculateMasterSecret(){} // RVA: 0x9561290
        public void CalculateMasterSecret_Ssl(){} // RVA: 0x9561520
        public void CalculateVerifyData(){} // RVA: 0x9561AE0
        public void CreateHash(){} // RVA: 0x9561E10 | overloaded x2
        public void CloneHash(){} // RVA: 0x9561EB0
        public void CreatePrfHash(){} // RVA: 0x95622E0
        public void ClonePrfHash(){} // RVA: 0x9562370
        public void GetHashAlgorithmForPrfAlgorithm(){} // RVA: 0x9562450
        public void GetOidForHashAlgorithm(){} // RVA: 0x9562540
        public void GetClientCertificateType(){} // RVA: 0x9562750
        public void TrackHashAlgorithms(){} // RVA: 0x9562A20
        public void HasSigningCapability(){} // RVA: 0x9562CB0
        public void CreateTlsSigner(){} // RVA: 0x9562CD0
        public void GenSsl3Const(){} // RVA: 0x9562DD0
        public void VectorOfOne(){} // RVA: 0x9562F40
        public void GetCipherType(){} // RVA: 0x9563090
        public void GetEncryptionAlgorithm(){} // RVA: 0x9563190
        public void GetKeyExchangeAlgorithm(){} // RVA: 0x9563540
        public void GetMacAlgorithm(){} // RVA: 0x9563940
        public void GetMinimumVersion(){} // RVA: 0x9563BE0
        public void IsAeadCipherSuite(){} // RVA: 0x9563CF0
        public void IsBlockCipherSuite(){} // RVA: 0x9563D50
        public void IsStreamCipherSuite(){} // RVA: 0x9563DB0
        public void IsValidCipherSuiteForSignatureAlgorithms(){} // RVA: 0x9563E10
        public void IsValidCipherSuiteForVersion(){} // RVA: 0x9563FF0
        public void GetUsableSignatureAlgorithms(){} // RVA: 0x95641E0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9564740
    }

}