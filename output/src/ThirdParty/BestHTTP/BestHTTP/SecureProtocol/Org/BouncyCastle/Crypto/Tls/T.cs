// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 61
// Methods: 663

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class TlsAeadCipher : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE77B0 | overloaded x2
        public void GetPlaintextLimit(){} // RVA: 0x7FFAFBFE7C80
        public void EncodePlaintext(){} // RVA: 0x7FFAFBFE7C90
        public void DecodeCiphertext(){} // RVA: 0x7FFAFBFE80B0
        public void GetAdditionalData(){} // RVA: 0x7FFAFBFE8500
    }

    public class TlsAgreementCredentials
    {
        // ── Methods ──
        public void GenerateAgreement(){} // RVA: 0x7FFAF2ABCE10
    }

    public class TlsAuthentication
    {
        // ── Methods ──
        public void NotifyServerCertificate(){} // RVA: 0x7FFAF2AD4B10
        public void GetClientCredentials(){} // RVA: 0x7FFAF2ACE6A0
    }

    public class TlsBlockCipher
    {
        // ── Methods ──
        public void get_WriteMac(){} // RVA: 0x7FFAF2F476A0
        public void get_ReadMac(){} // RVA: 0x7FFAF2E0A740
        public void .ctor(){} // RVA: 0x7FFAFBFE8630
        public void GetPlaintextLimit(){} // RVA: 0x7FFAFBFE8F80
        public void EncodePlaintext(){} // RVA: 0x7FFAFBFE9050
        public void DecodeCiphertext(){} // RVA: 0x7FFAFBFE9590
        public void CheckPaddingConstantTime(){} // RVA: 0x7FFAFBFE9B90
        public void ChooseExtraPadBlocks(){} // RVA: 0x7FFAFBFE9D00
        public void LowestBitSet(){} // RVA: 0x7FFAFBFE9DB0
    }

    public class TlsCipher
    {
        // ── Methods ──
        public void GetPlaintextLimit(){} // RVA: 0x7FFAF2AC3FB0
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
        public void get_HostNames(){} // RVA: 0x7FFAF2ABCD60
        public void set_HostNames(){} // RVA: 0x7FFAF2AD4B10
        public void Init(){} // RVA: 0x7FFAF2AD4B10
        public void GetSessionToResume(){} // RVA: 0x7FFAF2ABCD60
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0x7FFAF2ABCD60
        public void get_ClientVersion(){} // RVA: 0x7FFAF2ABCD60
        public void get_IsFallback(){} // RVA: 0x7FFAF2ABDBE0
        public void GetCipherSuites(){} // RVA: 0x7FFAF2ABCD60
        public void GetCompressionMethods(){} // RVA: 0x7FFAF2ABCD60
        public void GetClientExtensions(){} // RVA: 0x7FFAF2ABCD60
        public void NotifyServerVersion(){} // RVA: 0x7FFAF2AD4B10
        public void NotifySessionID(){} // RVA: 0x7FFAF2AD4B10
        public void NotifySelectedCipherSuite(){} // RVA: 0x7FFAF2AD4FA0
        public void NotifySelectedCompressionMethod(){} // RVA: 0x7FFAF2AD5130
        public void ProcessServerExtensions(){} // RVA: 0x7FFAF2AD4B10
        public void ProcessServerSupplementalData(){} // RVA: 0x7FFAF2AD4B10
        public void GetKeyExchange(){} // RVA: 0x7FFAF2ABCD60
        public void GetAuthentication(){} // RVA: 0x7FFAF2ABCD60
        public void GetClientSupplementalData(){} // RVA: 0x7FFAF2ABCD60
        public void NotifyNewSessionTicket(){} // RVA: 0x7FFAF2AD4B10
    }

    public class TlsClientContext
    {
    }

    public class TlsClientContextImpl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE9DD0
        public void get_IsServer(){} // RVA: 0x7FFAF2D8D320
    }

    public class TlsClientProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE9E70 | overloaded x3
        public void Connect(){} // RVA: 0x7FFAFBFE9E80
        public void CleanupHandshake(){} // RVA: 0x7FFAFBFEA2D0
        public void get_Context(){} // RVA: 0x7FFAF2DF8040
        public void get_ContextAdmin(){} // RVA: 0x7FFAF2DF8040
        public void get_Peer(){} // RVA: 0x7FFAF34CC130
        public void HandleHandshakeMessage(){} // RVA: 0x7FFAFBFEA4B0
        public void HandleSupplementalData(){} // RVA: 0x7FFAFBFEB5F0
        public void ReceiveNewSessionTicketMessage(){} // RVA: 0x7FFAFBFEB720
        public void ReceiveServerHelloMessage(){} // RVA: 0x7FFAFBFEB810
        public void SendCertificateVerifyMessage(){} // RVA: 0x7FFAFBFEC580
        public void SendClientHelloMessage(){} // RVA: 0x7FFAFBFEC620
        public void SendClientKeyExchangeMessage(){} // RVA: 0x7FFAFBFECF80
    }

    public class TlsCompression
    {
        // ── Methods ──
        public void Compress(){} // RVA: 0x7FFAF2ABCE10
        public void Decompress(){} // RVA: 0x7FFAF2ABCE10
    }

    public class TlsContext
    {
        // ── Methods ──
        public void get_NonceRandomGenerator(){} // RVA: 0x7FFAF2ABCD60
        public void get_SecureRandom(){} // RVA: 0x7FFAF2ABCD60
        public void get_SecurityParameters(){} // RVA: 0x7FFAF2ABCD60
        public void get_IsServer(){} // RVA: 0x7FFAF2ABDBE0
        public void get_ClientVersion(){} // RVA: 0x7FFAF2ABCD60
        public void get_ServerVersion(){} // RVA: 0x7FFAF2ABCD60
        public void get_ResumableSession(){} // RVA: 0x7FFAF2ABCD60
        public void get_UserObject(){} // RVA: 0x7FFAF2ABCD60
        public void set_UserObject(){} // RVA: 0x7FFAF2AD4B10
        public void ExportKeyingMaterial(){}
    }

    public class TlsCredentials
    {
        // ── Methods ──
        public void get_Certificate(){} // RVA: 0x7FFAF2ABCD60
    }

    public class TlsDHKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFEDF60 | overloaded x2
        public void Init(){} // RVA: 0x7FFAFBFEE1C0
        public void SkipServerCredentials(){} // RVA: 0x7FFAFBFEE230
        public void ProcessServerCertificate(){} // RVA: 0x7FFAFBFEE290
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFAFBFEE620
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFAFBFEE640
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFAFBFEE7A0
        public void ValidateCertificateRequest(){} // RVA: 0x7FFAFBFEE980
        public void ProcessClientCredentials(){} // RVA: 0x7FFAFBFEEA80
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFAFBFEEC30
        public void ProcessClientCertificate(){} // RVA: 0x7FFAFBFEED40
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFAFBFEEDA0
        public void GeneratePremasterSecret(){} // RVA: 0x7FFAFBFEEEA0
    }

    public class TlsDHUtilities
    {
        // ── Methods ──
        public void FromHex(){} // RVA: 0x7FFAFBFEEF80
        public void FromSafeP(){} // RVA: 0x7FFAFBFEF030
        public void AddNegotiatedDheGroupsClientExtension(){} // RVA: 0x7FFAFBFEF190
        public void AddNegotiatedDheGroupsServerExtension(){} // RVA: 0x7FFAFBFEF320
        public void GetNegotiatedDheGroupsClientExtension(){} // RVA: 0x7FFAFBFEF460
        public void GetNegotiatedDheGroupsServerExtension(){} // RVA: 0x7FFAFBFEF5C0
        public void CreateNegotiatedDheGroupsClientExtension(){} // RVA: 0x7FFAFBFEF6E0
        public void CreateNegotiatedDheGroupsServerExtension(){} // RVA: 0x7FFAFBFEF780
        public void ReadNegotiatedDheGroupsClientExtension(){} // RVA: 0x7FFAFBFEF7D0
        public void ReadNegotiatedDheGroupsServerExtension(){} // RVA: 0x7FFAFBFEF870
        public void GetParametersForDHEGroup(){} // RVA: 0x7FFAFBFEF8C0
        public void ContainsDheCipherSuites(){} // RVA: 0x7FFAFBFEFA10
        public void IsDheCipherSuite(){} // RVA: 0x7FFAFBFEFCF0
        public void AreCompatibleParameters(){} // RVA: 0x7FFAFBFEFF30
        public void CalculateDHBasicAgreement(){} // RVA: 0x7FFAFBFF0000
        public void GenerateDHKeyPair(){} // RVA: 0x7FFAFBFF00B0
        public void GenerateEphemeralClientKeyExchange(){} // RVA: 0x7FFAFBFF0180
        public void GenerateEphemeralServerKeyExchange(){} // RVA: 0x7FFAFBFF0320
        public void ReadDHParameter(){} // RVA: 0x7FFAFBFF05E0
        public void ReadDHParameters(){} // RVA: 0x7FFAFBFF0690
        public void ReceiveDHParameters(){} // RVA: 0x7FFAFBFF0740
        public void WriteDHParameter(){} // RVA: 0x7FFAFBFF0900
        public void WriteDHParameters(){} // RVA: 0x7FFAFBFF0980
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFBFF0AB0
    }

    public class TlsDHVerifier
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0x7FFAF2ABDE40
    }

    public class TlsDeflateCompression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFED1A0 | overloaded x2
        public void Compress(){} // RVA: 0x7FFAFBFED330
        public void Decompress(){} // RVA: 0x7FFAFBFED3C0
    }

    public class TlsDheKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFED540 | overloaded x2
        public void ProcessServerCredentials(){} // RVA: 0x7FFAFBFED550
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFAFBFED6D0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFAFBFEDA90
        public void InitVerifyer(){} // RVA: 0x7FFAFBFEDDC0
    }

    public class TlsDsaSigner
    {
        // ── Methods ──
        public void GenerateRawSignature(){} // RVA: 0x7FFAFBFF1090
        public void VerifyRawSignature(){} // RVA: 0x7FFAFBFF11E0
        public void CreateSigner(){} // RVA: 0x7FFAFBFF12E0
        public void CreateVerifyer(){} // RVA: 0x7FFAFBFF1310
        public void MakeInitParameters(){} // RVA: 0x7FFAF4930870
        public void MakeSigner(){} // RVA: 0x7FFAFBFF1340
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF2ABDBE0
        public void CreateDsaImpl(){}
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TlsDssSigner
    {
        // ── Methods ──
        public void IsValidPublicKey(){} // RVA: 0x7FFAFBFF15B0
        public void CreateDsaImpl(){} // RVA: 0x7FFAFBFF1640
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF60D58F0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TlsECDHKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFF5C20
        public void Init(){} // RVA: 0x7FFAFBFF5EC0
        public void SkipServerCredentials(){} // RVA: 0x7FFAFBFF5F30
        public void ProcessServerCertificate(){} // RVA: 0x7FFAFBFF5F90
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFAFBFF62F0
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFAFBFF6310
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFAFBFF6490
        public void ValidateCertificateRequest(){} // RVA: 0x7FFAFBFF6600
        public void ProcessClientCredentials(){} // RVA: 0x7FFAFBFF6700
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFAFBFF68B0
        public void ProcessClientCertificate(){} // RVA: 0x7FFAFBFF69D0
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFAFBFF6A30
        public void GeneratePremasterSecret(){} // RVA: 0x7FFAFBFF6B50
    }

    public class TlsECDheKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFF5180
        public void ProcessServerCredentials(){} // RVA: 0x7FFAFBFF5190
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFAFBFF5310
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFAFBFF5700
        public void ValidateCertificateRequest(){} // RVA: 0x7FFAFBFF59E0
        public void ProcessClientCredentials(){} // RVA: 0x7FFAFBFF5AA0
        public void InitVerifyer(){} // RVA: 0x7FFAFBFF5B20
    }

    public class TlsECDsaSigner
    {
        // ── Methods ──
        public void IsValidPublicKey(){} // RVA: 0x7FFAFBFF6C30
        public void CreateDsaImpl(){} // RVA: 0x7FFAFBFF6CC0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF8B2DB00
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TlsEccUtilities
    {
        // ── Methods ──
        public void AddSupportedEllipticCurvesExtension(){} // RVA: 0x7FFAFBFF1740
        public void AddSupportedPointFormatsExtension(){} // RVA: 0x7FFAFBFF1810
        public void GetSupportedEllipticCurvesExtension(){} // RVA: 0x7FFAFBFF1A10
        public void GetSupportedPointFormatsExtension(){} // RVA: 0x7FFAFBFF1AB0
        public void CreateSupportedEllipticCurvesExtension(){} // RVA: 0x7FFAFBFF1B50
        public void CreateSupportedPointFormatsExtension(){} // RVA: 0x7FFAFBFF1D70
        public void ReadSupportedEllipticCurvesExtension(){} // RVA: 0x7FFAFBFF1ED0
        public void ReadSupportedPointFormatsExtension(){} // RVA: 0x7FFAFBFF20B0
        public void GetNameOfNamedCurve(){} // RVA: 0x7FFAFBFF21A0
        public void GetParametersForNamedCurve(){} // RVA: 0x7FFAFBFF2250
        public void HasAnySupportedNamedCurves(){} // RVA: 0x7FFAFBFF25A0
        public void ContainsEccCipherSuites(){} // RVA: 0x7FFAFBFF2610
        public void IsEccCipherSuite(){} // RVA: 0x7FFAFBFF26C0
        public void AreOnSameCurve(){} // RVA: 0x7FFAFBFF2750
        public void IsSupportedNamedCurve(){} // RVA: 0x7FFAFBFF2770
        public void IsCompressionPreferred(){} // RVA: 0x7FFAFBFF27F0
        public void SerializeECFieldElement(){} // RVA: 0x7FFAFBFF2840
        public void SerializeECPoint(){} // RVA: 0x7FFAFBFF2860
        public void SerializeECPublicKey(){} // RVA: 0x7FFAFBFF2A10
        public void DeserializeECFieldElement(){} // RVA: 0x7FFAFBFF2A80
        public void DeserializeECPoint(){} // RVA: 0x7FFAFBFF2B50
        public void DeserializeECPublicKey(){} // RVA: 0x7FFAFBFF2DA0
        public void CalculateECDHBasicAgreement(){} // RVA: 0x7FFAFBFF2EF0
        public void GenerateECKeyPair(){} // RVA: 0x7FFAFBFF2FB0
        public void GenerateEphemeralClientKeyExchange(){} // RVA: 0x7FFAFBFF30A0
        public void GenerateEphemeralServerKeyExchange(){} // RVA: 0x7FFAFBFF3390
        public void ValidateECPublicKey(){} // RVA: 0x7FFAF44EF520
        public void ReadECExponent(){} // RVA: 0x7FFAFBFF3700
        public void ReadECFieldElement(){} // RVA: 0x7FFAFBFF3800
        public void ReadECParameter(){} // RVA: 0x7FFAFBFF3940
        public void ReadECParameters(){} // RVA: 0x7FFAFBFF39F0
        public void CheckNamedCurve(){} // RVA: 0x7FFAFBFF4060
        public void WriteECExponent(){} // RVA: 0x7FFAFBFF4120
        public void WriteECFieldElement(){} // RVA: 0x7FFAFBFF42C0 | overloaded x2
        public void WriteECParameter(){} // RVA: 0x7FFAFBFF43F0
        public void WriteExplicitECParameters(){} // RVA: 0x7FFAFBFF44E0
        public void WriteECPoint(){} // RVA: 0x7FFAFBFF4A90
        public void WriteNamedECParameters(){} // RVA: 0x7FFAFBFF4BB0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFBFF4CB0
    }

    public class TlsEncryptionCredentials
    {
        // ── Methods ──
        public void DecryptPreMasterSecret(){} // RVA: 0x7FFAF2ABCE10
    }

    public class TlsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88D54B0
    }

    public class TlsExtensionsUtilities
    {
        // ── Methods ──
        public void EnsureExtensionsInitialised(){} // RVA: 0x7FFAFBFF6DC0
        public void AddClientCertificateTypeExtensionClient(){} // RVA: 0x7FFAFBFF6E60
        public void AddClientCertificateTypeExtensionServer(){} // RVA: 0x7FFAFBFF6F10
        public void AddEncryptThenMacExtension(){} // RVA: 0x7FFAFBFF6FF0
        public void AddExtendedMasterSecretExtension(){} // RVA: 0x7FFAFBFF70D0
        public void AddHeartbeatExtension(){} // RVA: 0x7FFAFBFF71B0
        public void AddMaxFragmentLengthExtension(){} // RVA: 0x7FFAFBFF7310
        public void AddPaddingExtension(){} // RVA: 0x7FFAFBFF73F0
        public void AddServerCertificateTypeExtensionClient(){} // RVA: 0x7FFAFBFF74F0
        public void AddServerCertificateTypeExtensionServer(){} // RVA: 0x7FFAFBFF75A0
        public void AddServerNameExtension(){} // RVA: 0x7FFAFBFF7680
        public void AddStatusRequestExtension(){} // RVA: 0x7FFAFBFF7860
        public void AddTruncatedHMacExtension(){} // RVA: 0x7FFAFBFF79C0
        public void GetClientCertificateTypeExtensionClient(){} // RVA: 0x7FFAFBFF7AA0
        public void GetClientCertificateTypeExtensionServer(){} // RVA: 0x7FFAFBFF7B10
        public void GetHeartbeatExtension(){} // RVA: 0x7FFAFBFF7BC0
        public void GetMaxFragmentLengthExtension(){} // RVA: 0x7FFAFBFF7C30
        public void GetPaddingExtension(){} // RVA: 0x7FFAFBFF7CE0
        public void GetServerCertificateTypeExtensionClient(){} // RVA: 0x7FFAFBFF7DC0
        public void GetServerCertificateTypeExtensionServer(){} // RVA: 0x7FFAFBFF7E30
        public void GetServerNameExtension(){} // RVA: 0x7FFAFBFF7EE0
        public void GetStatusRequestExtension(){} // RVA: 0x7FFAFBFF8030
        public void HasEncryptThenMacExtension(){} // RVA: 0x7FFAFBFF8180
        public void HasExtendedMasterSecretExtension(){} // RVA: 0x7FFAFBFF8230
        public void HasTruncatedHMacExtension(){} // RVA: 0x7FFAFBFF82E0
        public void CreateCertificateTypeExtensionClient(){} // RVA: 0x7FFAFBFF8390
        public void CreateCertificateTypeExtensionServer(){} // RVA: 0x7FFAFBFF8430
        public void CreateEmptyExtensionData(){} // RVA: 0x7FFAFBFF8480
        public void CreateEncryptThenMacExtension(){} // RVA: 0x7FFAFBFF84E0
        public void CreateExtendedMasterSecretExtension(){} // RVA: 0x7FFAFBFF84E0
        public void CreateHeartbeatExtension(){} // RVA: 0x7FFAFBFF8540
        public void CreateMaxFragmentLengthExtension(){} // RVA: 0x7FFAFBFF8610
        public void CreatePaddingExtension(){} // RVA: 0x7FFAFBFF8660
        public void CreateServerNameExtension(){} // RVA: 0x7FFAFBFF86D0
        public void CreateStatusRequestExtension(){} // RVA: 0x7FFAFBFF87A0
        public void CreateTruncatedHMacExtension(){} // RVA: 0x7FFAFBFF84E0
        public void ReadEmptyExtensionData(){} // RVA: 0x7FFAFBFF8870
        public void ReadCertificateTypeExtensionClient(){} // RVA: 0x7FFAFBFF8910
        public void ReadCertificateTypeExtensionServer(){} // RVA: 0x7FFAFBFF89B0
        public void ReadEncryptThenMacExtension(){} // RVA: 0x7FFAFBFF8870
        public void ReadExtendedMasterSecretExtension(){} // RVA: 0x7FFAFBFF8870
        public void ReadHeartbeatExtension(){} // RVA: 0x7FFAFBFF8A00
        public void ReadMaxFragmentLengthExtension(){} // RVA: 0x7FFAFBFF8C40
        public void ReadPaddingExtension(){} // RVA: 0x7FFAFBFF8C90
        public void ReadServerNameExtension(){} // RVA: 0x7FFAFBFF8D60
        public void ReadStatusRequestExtension(){} // RVA: 0x7FFAFBFF8EB0
        public void ReadTruncatedHMacExtension(){} // RVA: 0x7FFAFBFF8870
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TlsFatalAlert
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFF9050 | overloaded x2
        public void get_AlertDescription(){} // RVA: 0x7FFAF3DFA670
    }

    public class TlsFatalAlertReceived
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFF9000
        public void get_AlertDescription(){} // RVA: 0x7FFAF3DFA670
    }

    public class TlsHandshakeHash
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF2AD4B10
        public void NotifyPrfDetermined(){} // RVA: 0x7FFAF2ABCD60
        public void TrackHashAlgorithm(){} // RVA: 0x7FFAF2AD5130
        public void SealHashAlgorithms(){} // RVA: 0x7FFAF2AD4A50
        public void StopTracking(){} // RVA: 0x7FFAF2ABCD60
        public void ForkPrfHash(){} // RVA: 0x7FFAF2ABCD60
        public void GetFinalHash(){}
    }

    public class TlsKeyExchange
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF2AD4B10
        public void SkipServerCredentials(){} // RVA: 0x7FFAF2AD4A50
        public void ProcessServerCredentials(){} // RVA: 0x7FFAF2AD4B10
        public void ProcessServerCertificate(){} // RVA: 0x7FFAF2AD4B10
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFAF2ABDBE0
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFAF2ABCD60
        public void SkipServerKeyExchange(){} // RVA: 0x7FFAF2AD4A50
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFAF2AD4B10
        public void ValidateCertificateRequest(){} // RVA: 0x7FFAF2AD4B10
        public void SkipClientCredentials(){} // RVA: 0x7FFAF2AD4A50
        public void ProcessClientCredentials(){} // RVA: 0x7FFAF2AD4B10
        public void ProcessClientCertificate(){} // RVA: 0x7FFAF2AD4B10
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFAF2AD4B10
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFAF2AD4B10
        public void GeneratePremasterSecret(){} // RVA: 0x7FFAF2ABCD60
    }

    public class TlsMac
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFF90B0
        public void get_MacSecret(){} // RVA: 0x7FFAF2D907C0
        public void get_Size(){} // RVA: 0x7FFAF2DE8CD0
        public void CalculateMac(){} // RVA: 0x7FFAFBFF95E0
        public void CalculateMacConstantTime(){} // RVA: 0x7FFAFBFF98F0
        public void GetDigestBlockCount(){} // RVA: 0x7FFAFBFF9B20
        public void Truncate(){} // RVA: 0x7FFAFBFF9B30
    }

    public class TlsNoCloseNotifyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFF9BB0
    }

    public class TlsNullCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFF9D00 | overloaded x2
        public void GetPlaintextLimit(){} // RVA: 0x7FFAFBFFA130
        public void EncodePlaintext(){} // RVA: 0x7FFAFBFFA160
        public void DecodeCiphertext(){} // RVA: 0x7FFAFBFFA2C0
    }

    public class TlsNullCompression
    {
        // ── Methods ──
        public void Compress(){} // RVA: 0x7FFAF3E8CE00
        public void Decompress(){} // RVA: 0x7FFAF3E8CE00
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TlsPeer
    {
        // ── Methods ──
        public void RequiresExtendedMasterSecret(){} // RVA: 0x7FFAF2ABDBE0
        public void ShouldUseGmtUnixTime(){} // RVA: 0x7FFAF2ABDBE0
        public void NotifySecureRenegotiation(){} // RVA: 0x7FFAF2AD5130
        public void GetCompression(){} // RVA: 0x7FFAF2ABCD60
        public void GetCipher(){} // RVA: 0x7FFAF2ABCD60
        public void NotifyAlertRaised(){}
        public void NotifyAlertReceived(){} // RVA: 0x7FFAF2AD51C0
        public void NotifyHandshakeComplete(){} // RVA: 0x7FFAF2AD4A50
    }

    public class TlsProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFFA9A0 | overloaded x3
        public void get_Context(){} // RVA: 0x7FFAF2ABCD60
        public void get_ContextAdmin(){} // RVA: 0x7FFAF2ABCD60
        public void get_Peer(){} // RVA: 0x7FFAF2ABCD60
        public void HandleAlertMessage(){} // RVA: 0x7FFAFBFFAF20
        public void HandleAlertWarningMessage(){} // RVA: 0x7FFAFBFFB010
        public void HandleChangeCipherSpecMessage(){} // RVA: 0x7FFAF2D8D310
        public void HandleClose(){} // RVA: 0x7FFAFBFFB090
        public void HandleException(){} // RVA: 0x7FFAFBFFB180
        public void HandleFailure(){} // RVA: 0x7FFAFBFFB1E0
        public void HandleHandshakeMessage(){} // RVA: 0x7FFAF2AD5600
        public void ApplyMaxFragmentLengthExtension(){} // RVA: 0x7FFAFBFFB260
        public void CheckReceivedChangeCipherSpec(){} // RVA: 0x7FFAFBFFB310
        public void CleanupHandshake(){} // RVA: 0x7FFAFBFFB370
        public void BlockForHandshake(){} // RVA: 0x7FFAFBFFB680
        public void CompleteHandshake(){} // RVA: 0x7FFAFBFFB710
        public void ProcessRecord(){} // RVA: 0x7FFAFBFFBE00
        public void ProcessHandshakeQueue(){} // RVA: 0x7FFAFBFFC2B0
        public void ProcessApplicationDataQueue(){} // RVA: 0x7FFAF2D8D310
        public void ProcessAlertQueue(){} // RVA: 0x7FFAFBFFC530
        public void ProcessChangeCipherSpec(){} // RVA: 0x7FFAFBFFC630
        public void ApplicationDataAvailable(){} // RVA: 0x7FFAF44EAF00
        public void ReadApplicationData(){} // RVA: 0x7FFAFBFFC7D0
        public void SafeCheckRecordHeader(){} // RVA: 0x7FFAFBFFC9A0
        public void SafeReadRecord(){} // RVA: 0x7FFAFBFFCB00
        public void SafeWriteRecord(){} // RVA: 0x7FFAFBFFCD20
        public void WriteData(){} // RVA: 0x7FFAFBFFCE90
        public void SetAppDataSplitMode(){} // RVA: 0x7FFAFBFFD090
        public void WriteHandshakeMessage(){} // RVA: 0x7FFAFBFFD140
        public void get_Stream(){} // RVA: 0x7FFAFBFFD2F0
        public void CloseInput(){} // RVA: 0x7FFAFBFFD360
        public void OfferInput(){} // RVA: 0x7FFAFBFFD4C0 | overloaded x2
        public void GetAvailableInputBytes(){} // RVA: 0x7FFAFBFFD780
        public void ReadInput(){} // RVA: 0x7FFAFBFFD800
        public void OfferOutput(){} // RVA: 0x7FFAFBFFD910
        public void GetAvailableOutputBytes(){} // RVA: 0x7FFAFBFFD9E0
        public void ReadOutput(){} // RVA: 0x7FFAFBFFDA70
        public void InvalidateSession(){} // RVA: 0x7FFAFBFFDB00
        public void ProcessFinishedMessage(){} // RVA: 0x7FFAFBFFDC20
        public void RaiseAlertFatal(){} // RVA: 0x7FFAFBFFDE30
        public void RaiseAlertWarning(){} // RVA: 0x7FFAFBFFDF40
        public void SendCertificateMessage(){} // RVA: 0x7FFAFBFFE040
        public void SendChangeCipherSpecMessage(){} // RVA: 0x7FFAFBFFE240
        public void SendFinishedMessage(){} // RVA: 0x7FFAFBFFE470
        public void SendSupplementalDataMessage(){} // RVA: 0x7FFAFBFFE580
        public void CreateVerifyData(){} // RVA: 0x7FFAFBFFE610
        public void Close(){} // RVA: 0x7FFAF890A340
        public void Flush(){} // RVA: 0x7FFAFBFFE740
        public void get_IsClosed(){} // RVA: 0x7FFAF8D66A60
        public void ProcessMaxFragmentLengthExtension(){} // RVA: 0x7FFAFBFFE780
        public void RefuseRenegotiation(){} // RVA: 0x7FFAFBFFE830
        public void AssertEmpty(){} // RVA: 0x7FFAFBFFE920
        public void CreateRandomBlock(){} // RVA: 0x7FFAFBFFE9C0
        public void CreateRenegotiationInfo(){} // RVA: 0x7FFAFBFFEB20
        public void EstablishMasterSecret(){} // RVA: 0x7FFAFBFFEBF0
        public void GetCurrentPrfHash(){} // RVA: 0x7FFAFBFFEDD0
        public void ReadExtensions(){} // RVA: 0x7FFAFBFFEF60
        public void ReadSupplementalDataMessage(){} // RVA: 0x7FFAFBFFF2E0
        public void WriteExtensions(){} // RVA: 0x7FFAFBFFF6C0
        public void WriteSelectedExtensions(){} // RVA: 0x7FFAFBFFF7A0
        public void WriteSupplementalData(){} // RVA: 0x7FFAFBFFFB80
        public void GetPrfAlgorithm(){} // RVA: 0x7FFAFBFFFF80
    }

    public class TlsProtocolHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE9E60 | overloaded x2
    }

    public class TlsPskIdentity
    {
        // ── Methods ──
        public void SkipIdentityHint(){} // RVA: 0x7FFAF2AD4A50
        public void NotifyIdentityHint(){} // RVA: 0x7FFAF2AD4B10
        public void GetPskIdentity(){} // RVA: 0x7FFAF2ABCD60
        public void GetPsk(){} // RVA: 0x7FFAF2ABCD60
    }

    public class TlsPskIdentityManager
    {
        // ── Methods ──
        public void GetHint(){} // RVA: 0x7FFAF2ABCD60
        public void GetPsk(){} // RVA: 0x7FFAF2ABCE10
    }

    public class TlsPskKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC000640 | overloaded x2
        public void SkipServerCredentials(){} // RVA: 0x7FFAFC0009A0
        public void ProcessServerCredentials(){} // RVA: 0x7FFAFC000A00
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFAFC000B80
        public void ProcessServerCertificate(){} // RVA: 0x7FFAFC000F00
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFAFC0011D0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFAFC0011F0
        public void ValidateCertificateRequest(){} // RVA: 0x7FFAFC0014B0
        public void ProcessClientCredentials(){} // RVA: 0x7FFAFC001500
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFAFC001550
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFAFC0018F0
        public void GeneratePremasterSecret(){} // RVA: 0x7FFAFC001CA0
        public void GenerateOtherSecret(){} // RVA: 0x7FFAFC001E70
        public void ValidateRsaPublicKey(){} // RVA: 0x7FFAFC002000
    }

    public class TlsRsaKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94BB4C0
        public void SkipServerCredentials(){} // RVA: 0x7FFAFC002080
        public void ProcessServerCredentials(){} // RVA: 0x7FFAFC0020D0
        public void ProcessServerCertificate(){} // RVA: 0x7FFAFC002250
        public void ValidateCertificateRequest(){} // RVA: 0x7FFAFC002520
        public void ProcessClientCredentials(){} // RVA: 0x7FFAFC0025E0
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFAFC002660
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFAFC0026D0
        public void GeneratePremasterSecret(){} // RVA: 0x7FFAFC0027F0
        public void ValidateRsaPublicKey(){} // RVA: 0x7FFAFC0028A0
    }

    public class TlsRsaSigner
    {
        // ── Methods ──
        public void GenerateRawSignature(){} // RVA: 0x7FFAFC002920
        public void VerifyRawSignature(){} // RVA: 0x7FFAFC002A50
        public void CreateSigner(){} // RVA: 0x7FFAFC002B30
        public void CreateVerifyer(){} // RVA: 0x7FFAFC002C10
        public void IsValidPublicKey(){} // RVA: 0x7FFAFC002C40
        public void MakeSigner(){} // RVA: 0x7FFAFC002CB0
        public void CreateRsaImpl(){} // RVA: 0x7FFAFC003200
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TlsRsaUtilities
    {
        // ── Methods ──
        public void GenerateEncryptedPreMasterSecret(){} // RVA: 0x7FFAFC003280
        public void SafeDecryptPreMasterSecret(){} // RVA: 0x7FFAFC003580
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TlsSRTPUtils
    {
        // ── Methods ──
        public void AddUseSrtpExtension(){} // RVA: 0x7FFAFC009880
        public void GetUseSrtpExtension(){} // RVA: 0x7FFAFC009930
        public void CreateUseSrtpExtension(){} // RVA: 0x7FFAFC0099A0
        public void ReadUseSrtpExtension(){} // RVA: 0x7FFAFC009B60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TlsServer
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF2AD4B10
        public void NotifyClientVersion(){} // RVA: 0x7FFAF2AD4B10
        public void NotifyFallback(){} // RVA: 0x7FFAF2AD5130
        public void NotifyOfferedCipherSuites(){} // RVA: 0x7FFAF2AD4B10
        public void NotifyOfferedCompressionMethods(){} // RVA: 0x7FFAF2AD4B10
        public void ProcessClientExtensions(){} // RVA: 0x7FFAF2AD4B10
        public void GetServerVersion(){} // RVA: 0x7FFAF2ABCD60
        public void GetSelectedCipherSuite(){} // RVA: 0x7FFAF2ABD840
        public void GetSelectedCompressionMethod(){} // RVA: 0x7FFAF2ABDBE0
        public void GetServerExtensions(){} // RVA: 0x7FFAF2ABCD60
        public void GetServerSupplementalData(){} // RVA: 0x7FFAF2ABCD60
        public void GetCredentials(){} // RVA: 0x7FFAF2ABCD60
        public void GetCertificateStatus(){} // RVA: 0x7FFAF2ABCD60
        public void GetKeyExchange(){} // RVA: 0x7FFAF2ABCD60
        public void GetCertificateRequest(){} // RVA: 0x7FFAF2ABCD60
        public void ProcessClientSupplementalData(){} // RVA: 0x7FFAF2AD4B10
        public void NotifyClientCertificate(){} // RVA: 0x7FFAF2AD4B10
        public void GetNewSessionTicket(){} // RVA: 0x7FFAF2ABCD60
    }

    public class TlsServerContext
    {
    }

    public class TlsServerContextImpl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC003990
        public void get_IsServer(){} // RVA: 0x7FFAF2E72850
    }

    public class TlsServerProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC003A50 | overloaded x3
        public void Accept(){} // RVA: 0x7FFAFC003A70
        public void CleanupHandshake(){} // RVA: 0x7FFAFC003E20
        public void get_Context(){} // RVA: 0x7FFAF2DF8040
        public void get_ContextAdmin(){} // RVA: 0x7FFAF2DF8040
        public void get_Peer(){} // RVA: 0x7FFAF34CC130
        public void HandleHandshakeMessage(){} // RVA: 0x7FFAFC003FB0
        public void HandleAlertWarningMessage(){} // RVA: 0x7FFAFC004B90
        public void NotifyClientCertificate(){} // RVA: 0x7FFAFC004D90
        public void ReceiveCertificateMessage(){} // RVA: 0x7FFAFC004FC0
        public void ReceiveCertificateVerifyMessage(){} // RVA: 0x7FFAFC0050D0
        public void ReceiveClientHelloMessage(){} // RVA: 0x7FFAFC005520
        public void ReceiveClientKeyExchangeMessage(){} // RVA: 0x7FFAFC005BD0
        public void SendCertificateRequestMessage(){} // RVA: 0x7FFAFC005F30
        public void SendCertificateStatusMessage(){} // RVA: 0x7FFAFC005FD0
        public void SendNewSessionTicketMessage(){} // RVA: 0x7FFAFC006070
        public void SendServerHelloMessage(){} // RVA: 0x7FFAFC006150
        public void SendServerHelloDoneMessage(){} // RVA: 0x7FFAFC006B60
        public void SendServerKeyExchangeMessage(){} // RVA: 0x7FFAFC006C40
        public void ExpectCertificateVerifyMessage(){} // RVA: 0x7FFAFC006CF0
    }

    public class TlsSession
    {
        // ── Methods ──
        public void ExportSessionParameters(){} // RVA: 0x7FFAF2ABCD60
        public void get_SessionID(){} // RVA: 0x7FFAF2ABCD60
        public void Invalidate(){} // RVA: 0x7FFAF2AD4A50
        public void get_IsResumable(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class TlsSessionImpl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC006D60
        public void ExportSessionParameters(){} // RVA: 0x7FFAFC006FB0
        public void get_SessionID(){} // RVA: 0x7FFAFC0071D0
        public void Invalidate(){} // RVA: 0x7FFAFC007310
        public void get_IsResumable(){} // RVA: 0x7FFAFC007430
    }

    public class TlsSigner
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF2AD4B10
        public void GenerateRawSignature(){} // RVA: 0x7FFAF2ACEE30 | overloaded x2
        public void VerifyRawSignature(){} // RVA: 0x7FFAF2AC15A0 | overloaded x2
        public void CreateSigner(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void CreateVerifyer(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void IsValidPublicKey(){} // RVA: 0x7FFAF2ABDE40
    }

    public class TlsSignerCredentials
    {
        // ── Methods ──
        public void GenerateCertificateSignature(){} // RVA: 0x7FFAF2ABCE10
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x7FFAF2ABCD60
    }

    public class TlsSrpGroupVerifier
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0x7FFAF2ABDE40
    }

    public class TlsSrpIdentityManager
    {
        // ── Methods ──
        public void GetLoginParameters(){} // RVA: 0x7FFAF2ABCE10
    }

    public class TlsSrpKeyExchange
    {
        // ── Methods ──
        public void CreateSigner(){} // RVA: 0x7FFAFC007570
        public void .ctor(){} // RVA: 0x7FFAFC007940 | overloaded x3
        public void Init(){} // RVA: 0x7FFAFC007C50
        public void SkipServerCredentials(){} // RVA: 0x7FFAFC007CC0
        public void ProcessServerCertificate(){} // RVA: 0x7FFAFC007D20
        public void ProcessServerCredentials(){} // RVA: 0x7FFAFC007F70
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFAF2E72850
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFAFC008100
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFAFC008530
        public void ValidateCertificateRequest(){} // RVA: 0x7FFAFC008B40
        public void ProcessClientCredentials(){} // RVA: 0x7FFAFC008B90
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFAFC008BE0
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFAFC008DC0
        public void GeneratePremasterSecret(){} // RVA: 0x7FFAFC008FF0
        public void InitVerifyer(){} // RVA: 0x7FFAFC0090D0
    }

    public class TlsSrpLoginParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E6CE00
        public void get_Group(){} // RVA: 0x7FFAF2DA8380
        public void get_Salt(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Verifier(){} // RVA: 0x7FFAF2D907C0
    }

    public class TlsSrpUtilities
    {
        // ── Methods ──
        public void AddSrpExtension(){} // RVA: 0x7FFAFC0091D0
        public void GetSrpExtension(){} // RVA: 0x7FFAFC009360
        public void CreateSrpExtension(){} // RVA: 0x7FFAFC0094D0
        public void ReadSrpExtension(){} // RVA: 0x7FFAFC0095D0
        public void ReadSrpParameter(){} // RVA: 0x7FFAFC009740
        public void WriteSrpParameter(){} // RVA: 0x7FFAFC0097F0
        public void IsSrpCipherSuite(){} // RVA: 0x7FFAFC009870
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TlsStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC009ED0
        public void get_CanRead(){} // RVA: 0x7FFAFC009F70
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAFC009F70
        public void Close(){} // RVA: 0x7FFAFC009FA0
        public void Flush(){} // RVA: 0x7FFAFC009FE0
        public void get_Length(){} // RVA: 0x7FFAFC00A010
        public void get_Position(){} // RVA: 0x7FFAFC00A050
        public void set_Position(){} // RVA: 0x7FFAFC00A090
        public void Read(){} // RVA: 0x7FFAFC00A0D0
        public void ReadByte(){} // RVA: 0x7FFAFC00A100
        public void Seek(){} // RVA: 0x7FFAFC00A1B0
        public void SetLength(){} // RVA: 0x7FFAFC00A1F0
        public void Write(){} // RVA: 0x7FFAFC00A230
        public void WriteByte(){} // RVA: 0x7FFAFC00A260
    }

    public class TlsStreamCipher : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC00A300
        public void GetPlaintextLimit(){} // RVA: 0x7FFAFC00AAA0
        public void EncodePlaintext(){} // RVA: 0x7FFAFC00AAE0
        public void DecodeCiphertext(){} // RVA: 0x7FFAFC00AC60
        public void CheckMac(){} // RVA: 0x7FFAFC00AE40
        public void UpdateIV(){} // RVA: 0x7FFAFC00AFB0
    }

    public class TlsUtilities
    {
        // ── Methods ──
        public void CheckUint8(){} // RVA: 0x7FFAFC00B160 | overloaded x2
        public void CheckUint16(){} // RVA: 0x7FFAFC00B280 | overloaded x2
        public void CheckUint24(){} // RVA: 0x7FFAFC00B3A0 | overloaded x2
        public void CheckUint32(){} // RVA: 0x7FFAFC00B430
        public void CheckUint48(){} // RVA: 0x7FFAFC00B4C0
        public void CheckUint64(){} // RVA: 0x7FFAFC00B560
        public void IsValidUint8(){} // RVA: 0x7FFAFC00B5B0 | overloaded x2
        public void IsValidUint16(){} // RVA: 0x7FFAFC00B5D0 | overloaded x2
        public void IsValidUint24(){} // RVA: 0x7FFAFC00B5F0 | overloaded x2
        public void IsValidUint32(){} // RVA: 0x7FFAFC00B600
        public void IsValidUint48(){} // RVA: 0x7FFAFC00B610
        public void IsValidUint64(){} // RVA: 0x7FFAF2E72850
        public void IsSsl(){} // RVA: 0x7FFAFC00B630
        public void IsTlsV11(){} // RVA: 0x7FFAFC00B7C0 | overloaded x2
        public void IsTlsV12(){} // RVA: 0x7FFAFC00B9E0 | overloaded x2
        public void WriteUint8(){} // RVA: 0x7FFAFC00BB50 | overloaded x2
        public void WriteUint16(){} // RVA: 0x7FFAFC00BBE0 | overloaded x2
        public void WriteUint24(){} // RVA: 0x7FFAFC00BCA0 | overloaded x2
        public void WriteUint32(){} // RVA: 0x7FFAFC00BD90 | overloaded x2
        public void WriteUint48(){} // RVA: 0x7FFAFC00BEE0 | overloaded x2
        public void WriteUint64(){} // RVA: 0x7FFAFC00C0A0 | overloaded x2
        public void WriteOpaque8(){} // RVA: 0x7FFAFC00C190
        public void WriteOpaque16(){} // RVA: 0x7FFAFC00C240
        public void WriteOpaque24(){} // RVA: 0x7FFAFC00C310
        public void WriteUint8Array(){} // RVA: 0x7FFAFC00C450 | overloaded x2
        public void WriteUint8ArrayWithUint8Length(){} // RVA: 0x7FFAFC00C5C0 | overloaded x2
        public void WriteUint16Array(){} // RVA: 0x7FFAFC00C7B0 | overloaded x2
        public void WriteUint16ArrayWithUint16Length(){} // RVA: 0x7FFAFC00C9D0 | overloaded x2
        public void DecodeUint8(){} // RVA: 0x7FFAFC00CB10
        public void DecodeUint8ArrayWithUint8Length(){} // RVA: 0x7FFAFC00CC00
        public void EncodeOpaque8(){} // RVA: 0x7FFAFC00CD90
        public void EncodeUint8(){} // RVA: 0x7FFAFC00CE20
        public void EncodeUint8ArrayWithUint8Length(){} // RVA: 0x7FFAFC00CEB0
        public void EncodeUint16ArrayWithUint16Length(){} // RVA: 0x7FFAFC00D010
        public void ReadUint8(){} // RVA: 0x7FFAFC00D220 | overloaded x2
        public void ReadUint16(){} // RVA: 0x7FFAFC00D2F0 | overloaded x2
        public void ReadUint24(){} // RVA: 0x7FFAFC00D3F0 | overloaded x2
        public void ReadUint32(){} // RVA: 0x7FFAFC00D540 | overloaded x2
        public void ReadUint48(){} // RVA: 0x7FFAFC00D630 | overloaded x2
        public void ReadAllOrNothing(){} // RVA: 0x7FFAFC00D720
        public void ReadFully(){} // RVA: 0x7FFAFC00D9F0 | overloaded x2
        public void ReadOpaque8(){} // RVA: 0x7FFAFC00DAC0
        public void ReadOpaque16(){} // RVA: 0x7FFAFC00DBB0
        public void ReadOpaque24(){} // RVA: 0x7FFAFC00DCC0
        public void ReadUint8Array(){} // RVA: 0x7FFAFC00DD20
        public void ReadUint16Array(){} // RVA: 0x7FFAFC00DE40
        public void ReadVersion(){} // RVA: 0x7FFAFC00E010 | overloaded x2
        public void ReadVersionRaw(){} // RVA: 0x7FFAFC00E0F0 | overloaded x2
        public void ReadAsn1Object(){} // RVA: 0x7FFAFC00E190
        public void ReadDerObject(){} // RVA: 0x7FFAFC00E310
        public void WriteGmtUnixTime(){} // RVA: 0x7FFAFC00E4A0
        public void WriteVersion(){} // RVA: 0x7FFAFC00E5E0 | overloaded x2
        public void GetAllSignatureAlgorithms(){} // RVA: 0x7FFAFC00E630
        public void GetDefaultDssSignatureAlgorithms(){} // RVA: 0x7FFAFC00E8E0
        public void GetDefaultECDsaSignatureAlgorithms(){} // RVA: 0x7FFAFC00E9A0
        public void GetDefaultRsaSignatureAlgorithms(){} // RVA: 0x7FFAFC00EA60
        public void GetExtensionData(){} // RVA: 0x7FFAFC00EB20
        public void GetDefaultSupportedSignatureAlgorithms(){} // RVA: 0x7FFAFC00EBE0
        public void GetSignatureAndHashAlgorithm(){} // RVA: 0x7FFAFC00EDE0
        public void HasExpectedEmptyExtensionData(){} // RVA: 0x7FFAFC00EF20
        public void ImportSession(){} // RVA: 0x7FFAFC00EFF0
        public void IsSignatureAlgorithmsExtensionAllowed(){} // RVA: 0x7FFAFC00F060
        public void AddSignatureAlgorithmsExtension(){} // RVA: 0x7FFAFC00F140
        public void GetSignatureAlgorithmsExtension(){} // RVA: 0x7FFAFC00F2A0
        public void CreateSignatureAlgorithmsExtension(){} // RVA: 0x7FFAFC00F430
        public void ReadSignatureAlgorithmsExtension(){} // RVA: 0x7FFAFC00F4E0
        public void EncodeSupportedSignatureAlgorithms(){} // RVA: 0x7FFAFC00F650
        public void ParseSupportedSignatureAlgorithms(){} // RVA: 0x7FFAFC00FA50
        public void VerifySupportedSignatureAlgorithm(){} // RVA: 0x7FFAFC00FC80
        public void PRF(){} // RVA: 0x7FFAFC010010
        public void PRF_legacy(){} // RVA: 0x7FFAFC010430 | overloaded x2
        public void Concat(){} // RVA: 0x7FFAFC0105D0
        public void HMacHash(){} // RVA: 0x7FFAFC010680
        public void ValidateKeyUsage(){} // RVA: 0x7FFAFC010950
        public void CalculateKeyBlock(){} // RVA: 0x7FFAFC010A70
        public void CalculateKeyBlock_Ssl(){} // RVA: 0x7FFAFC010C70
        public void CalculateMasterSecret(){} // RVA: 0x7FFAFC011290
        public void CalculateMasterSecret_Ssl(){} // RVA: 0x7FFAFC011520
        public void CalculateVerifyData(){} // RVA: 0x7FFAFC011AE0
        public void CreateHash(){} // RVA: 0x7FFAFC011E10 | overloaded x2
        public void CloneHash(){} // RVA: 0x7FFAFC011EB0
        public void CreatePrfHash(){} // RVA: 0x7FFAFC0122E0
        public void ClonePrfHash(){} // RVA: 0x7FFAFC012370
        public void GetHashAlgorithmForPrfAlgorithm(){} // RVA: 0x7FFAFC012450
        public void GetOidForHashAlgorithm(){} // RVA: 0x7FFAFC012540
        public void GetClientCertificateType(){} // RVA: 0x7FFAFC012750
        public void TrackHashAlgorithms(){} // RVA: 0x7FFAFC012A20
        public void HasSigningCapability(){} // RVA: 0x7FFAFC012CB0
        public void CreateTlsSigner(){} // RVA: 0x7FFAFC012CD0
        public void GenSsl3Const(){} // RVA: 0x7FFAFC012DD0
        public void VectorOfOne(){} // RVA: 0x7FFAFC012F40
        public void GetCipherType(){} // RVA: 0x7FFAFC013090
        public void GetEncryptionAlgorithm(){} // RVA: 0x7FFAFC013190
        public void GetKeyExchangeAlgorithm(){} // RVA: 0x7FFAFC013540
        public void GetMacAlgorithm(){} // RVA: 0x7FFAFC013940
        public void GetMinimumVersion(){} // RVA: 0x7FFAFC013BE0
        public void IsAeadCipherSuite(){} // RVA: 0x7FFAFC013CF0
        public void IsBlockCipherSuite(){} // RVA: 0x7FFAFC013D50
        public void IsStreamCipherSuite(){} // RVA: 0x7FFAFC013DB0
        public void IsValidCipherSuiteForSignatureAlgorithms(){} // RVA: 0x7FFAFC013E10
        public void IsValidCipherSuiteForVersion(){} // RVA: 0x7FFAFC013FF0
        public void GetUsableSignatureAlgorithms(){} // RVA: 0x7FFAFC0141E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC014740
    }

}