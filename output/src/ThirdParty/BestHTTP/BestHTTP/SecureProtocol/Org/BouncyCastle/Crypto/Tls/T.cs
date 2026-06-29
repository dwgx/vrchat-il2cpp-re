// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 59
// Methods: 612

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class TlsAeadCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B136DB20
        public void GetPlaintextLimit(){} // RVA: 0x7B136DFE0
        public void EncodePlaintext(){} // RVA: 0x7B136DFF0
        public void DecodeCiphertext(){} // RVA: 0x7B136E420
        public void GetAdditionalData(){} // RVA: 0x7B136E880
    }

    public class TlsAgreementCredentials
    {
        // ── Methods ──
        public void GenerateAgreement(){} // RVA: 0x7A7E00B20
    }

    public class TlsAuthentication
    {
        // ── Methods ──
        public void NotifyServerCertificate(){} // RVA: 0x7A7E18800
        public void GetClientCredentials(){} // RVA: 0x7A7E00BD0
    }

    public class TlsBlockCipher : Object
    {
        // ── Methods ──
        public void get_WriteMac(){} // RVA: 0x7A8292C30
        public void get_ReadMac(){} // RVA: 0x7A8154D80
        public void .ctor(){} // RVA: 0x7B136E9B0
        public void GetPlaintextLimit(){} // RVA: 0x7B136F300
        public void EncodePlaintext(){} // RVA: 0x7B136F3D0
        public void DecodeCiphertext(){} // RVA: 0x7B136F910
        public void CheckPaddingConstantTime(){} // RVA: 0x7B136FF10
        public void ChooseExtraPadBlocks(){} // RVA: 0x7B13700A0
        public void LowestBitSet(){} // RVA: 0x7B1370150
    }

    public class TlsCipher
    {
        // ── Methods ──
        public void GetPlaintextLimit(){} // RVA: 0x7A7E062A0
        public void EncodePlaintext(){} // RVA: 0x7A7E110F0
        public void DecodeCiphertext(){} // RVA: 0x7A7E110F0
    }

    public class TlsCipherFactory
    {
        // ── Methods ──
        public void CreateCipher(){} // RVA: 0x7A7E017C0
    }

    public class TlsClient
    {
        // ── Methods ──
        public void get_HostNames(){} // RVA: 0x7A7E00680
        public void set_HostNames(){} // RVA: 0x7A7E18800
        public void Init(){} // RVA: 0x7A7E18800
        public void GetSessionToResume(){} // RVA: 0x7A7E00680
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0x7A7E00680
        public void get_ClientVersion(){} // RVA: 0x7A7E00680
        public void get_IsFallback(){} // RVA: 0x7A7E01900
        public void GetCipherSuites(){} // RVA: 0x7A7E00680
        public void GetCompressionMethods(){} // RVA: 0x7A7E00680
        public void GetClientExtensions(){} // RVA: 0x7A7E00680
        public void NotifyServerVersion(){} // RVA: 0x7A7E18800
        public void NotifySessionID(){} // RVA: 0x7A7E18800
        public void NotifySelectedCipherSuite(){} // RVA: 0x7A7E189D0
        public void NotifySelectedCompressionMethod(){} // RVA: 0x7A7E18C30
        public void ProcessServerExtensions(){} // RVA: 0x7A7E18800
        public void ProcessServerSupplementalData(){} // RVA: 0x7A7E18800
        public void GetKeyExchange(){} // RVA: 0x7A7E00680
        public void GetAuthentication(){} // RVA: 0x7A7E00680
        public void GetClientSupplementalData(){} // RVA: 0x7A7E00680
        public void NotifyNewSessionTicket(){} // RVA: 0x7A7E18800
    }

    public class TlsClientContextImpl : AbstractTlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1370170
        public void get_IsServer(){} // RVA: 0x7A80D7320
    }

    public class TlsClientProtocol : TlsProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1370210
        public void Connect(){} // RVA: 0x7B1370220
        public void CleanupHandshake(){} // RVA: 0x7B1370670
        public void get_Context(){} // RVA: 0x7A8142610
        public void get_ContextAdmin(){} // RVA: 0x7A8142610
        public void get_Peer(){} // RVA: 0x7A87D9480
        public void HandleHandshakeMessage(){} // RVA: 0x7B1370850
        public void HandleSupplementalData(){} // RVA: 0x7B1371980
        public void ReceiveNewSessionTicketMessage(){} // RVA: 0x7B1371AB0
        public void ReceiveServerHelloMessage(){} // RVA: 0x7B1371BA0
        public void SendCertificateVerifyMessage(){} // RVA: 0x7B1372920
        public void SendClientHelloMessage(){} // RVA: 0x7B13729C0
        public void SendClientKeyExchangeMessage(){} // RVA: 0x7B1373340
    }

    public class TlsCompression
    {
        // ── Methods ──
        public void Compress(){} // RVA: 0x7A7E00B20
        public void Decompress(){} // RVA: 0x7A7E00B20
    }

    public class TlsContext
    {
        // ── Methods ──
        public void get_NonceRandomGenerator(){} // RVA: 0x7A7E00680
        public void get_SecureRandom(){} // RVA: 0x7A7E00680
        public void get_SecurityParameters(){} // RVA: 0x7A7E00680
        public void get_IsServer(){} // RVA: 0x7A7E01900
        public void get_ClientVersion(){} // RVA: 0x7A7E00680
        public void get_ServerVersion(){} // RVA: 0x7A7E00680
        public void get_ResumableSession(){} // RVA: 0x7A7E00680
        public void get_UserObject(){} // RVA: 0x7A7E00680
        public void set_UserObject(){} // RVA: 0x7A7E18800
        public void ExportKeyingMaterial(){} // RVA: 0x7A7E12800
    }

    public class TlsCredentials
    {
        // ── Methods ──
        public void get_Certificate(){} // RVA: 0x7A7E00680
    }

    public class TlsDHKeyExchange : AbstractTlsKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1374320
        public void Init(){} // RVA: 0x7B1374580
        public void SkipServerCredentials(){} // RVA: 0x7B13745F0
        public void ProcessServerCertificate(){} // RVA: 0x7B1374650
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7B13749E0
        public void GenerateServerKeyExchange(){} // RVA: 0x7B1374A00
        public void ProcessServerKeyExchange(){} // RVA: 0x7B1374B60
        public void ValidateCertificateRequest(){} // RVA: 0x7B1374D40
        public void ProcessClientCredentials(){} // RVA: 0x7B1374E40
        public void GenerateClientKeyExchange(){} // RVA: 0x7B1374FF0
        public void ProcessClientCertificate(){} // RVA: 0x7B1375100
        public void ProcessClientKeyExchange(){} // RVA: 0x7B1375160
        public void GeneratePremasterSecret(){} // RVA: 0x7B1375260
    }

    public class TlsDHUtilities : Object
    {
        // ── Methods ──
        public void FromHex(){} // RVA: 0x7B1375340
        public void FromSafeP(){} // RVA: 0x7B13753F0
        public void AddNegotiatedDheGroupsClientExtension(){} // RVA: 0x7B1375550
        public void AddNegotiatedDheGroupsServerExtension(){} // RVA: 0x7B13756E0
        public void GetNegotiatedDheGroupsClientExtension(){} // RVA: 0x7B1375820
        public void GetNegotiatedDheGroupsServerExtension(){} // RVA: 0x7B1375980
        public void CreateNegotiatedDheGroupsClientExtension(){} // RVA: 0x7B1375AA0
        public void CreateNegotiatedDheGroupsServerExtension(){} // RVA: 0x7B1375B40
        public void ReadNegotiatedDheGroupsClientExtension(){} // RVA: 0x7B1375B90
        public void ReadNegotiatedDheGroupsServerExtension(){} // RVA: 0x7B1375C30
        public void GetParametersForDHEGroup(){} // RVA: 0x7B1375C80
        public void ContainsDheCipherSuites(){} // RVA: 0x7B1375DD0
        public void IsDheCipherSuite(){} // RVA: 0x7B13760E0
        public void AreCompatibleParameters(){} // RVA: 0x7B1376340
        public void CalculateDHBasicAgreement(){} // RVA: 0x7B1376410
        public void GenerateDHKeyPair(){} // RVA: 0x7B13764C0
        public void GenerateEphemeralClientKeyExchange(){} // RVA: 0x7B1376590
        public void GenerateEphemeralServerKeyExchange(){} // RVA: 0x7B1376730
        public void ReadDHParameter(){} // RVA: 0x7B13769F0
        public void ReadDHParameters(){} // RVA: 0x7B1376AA0
        public void ReceiveDHParameters(){} // RVA: 0x7B1376B50
        public void WriteDHParameter(){} // RVA: 0x7B1376D10
        public void WriteDHParameters(){} // RVA: 0x7B1376D90
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1376EC0
    }

    public class TlsDHVerifier
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0x7A7E019D0
    }

    public class TlsDeflateCompression : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1373560
        public void Compress(){} // RVA: 0x7B13736F0
        public void Decompress(){} // RVA: 0x7B1373780
    }

    public class TlsDheKeyExchange : TlsDHKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1373900
        public void ProcessServerCredentials(){} // RVA: 0x7B1373910
        public void GenerateServerKeyExchange(){} // RVA: 0x7B1373A90
        public void ProcessServerKeyExchange(){} // RVA: 0x7B1373E50
        public void InitVerifyer(){} // RVA: 0x7B1374180
    }

    public class TlsDsaSigner : AbstractTlsSigner
    {
        // ── Methods ──
        public void GenerateRawSignature(){} // RVA: 0x7B13774A0
        public void VerifyRawSignature(){} // RVA: 0x7B1377730
        public void CreateSigner(){} // RVA: 0x7B1377830
        public void CreateVerifyer(){} // RVA: 0x7B1377860
        public void MakeInitParameters(){} // RVA: 0x7A9C85140
        public void MakeSigner(){} // RVA: 0x7B1377890
        public void get_SignatureAlgorithm(){} // RVA: 0x7A7E01900
        public void CreateDsaImpl(){} // RVA: 0x7A7E063A0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TlsDssSigner : TlsDsaSigner
    {
        // ── Methods ──
        public void IsValidPublicKey(){} // RVA: 0x7B1377B00
        public void CreateDsaImpl(){} // RVA: 0x7B1377B80
        public void get_SignatureAlgorithm(){} // RVA: 0x7AB40BF50
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TlsECDHKeyExchange : AbstractTlsKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B137C0C0
        public void Init(){} // RVA: 0x7B137C360
        public void SkipServerCredentials(){} // RVA: 0x7B137C3D0
        public void ProcessServerCertificate(){} // RVA: 0x7B137C430
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7B137C790
        public void GenerateServerKeyExchange(){} // RVA: 0x7B137C7B0
        public void ProcessServerKeyExchange(){} // RVA: 0x7B137C930
        public void ValidateCertificateRequest(){} // RVA: 0x7B137CAA0
        public void ProcessClientCredentials(){} // RVA: 0x7B137CBA0
        public void GenerateClientKeyExchange(){} // RVA: 0x7B137CD50
        public void ProcessClientCertificate(){} // RVA: 0x7B137CE70
        public void ProcessClientKeyExchange(){} // RVA: 0x7B137CED0
        public void GeneratePremasterSecret(){} // RVA: 0x7B137CFF0
    }

    public class TlsECDheKeyExchange : TlsECDHKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B137B620
        public void ProcessServerCredentials(){} // RVA: 0x7B137B630
        public void GenerateServerKeyExchange(){} // RVA: 0x7B137B7B0
        public void ProcessServerKeyExchange(){} // RVA: 0x7B137BBA0
        public void ValidateCertificateRequest(){} // RVA: 0x7B137BE80
        public void ProcessClientCredentials(){} // RVA: 0x7B137BF40
        public void InitVerifyer(){} // RVA: 0x7B137BFC0
    }

    public class TlsECDsaSigner : TlsDsaSigner
    {
        // ── Methods ──
        public void IsValidPublicKey(){} // RVA: 0x7B137D0D0
        public void CreateDsaImpl(){} // RVA: 0x7B137D150
        public void get_SignatureAlgorithm(){} // RVA: 0x7ADE69AF0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TlsEccUtilities : Object
    {
        // ── Methods ──
        public void AddSupportedEllipticCurvesExtension(){} // RVA: 0x7B1377C80
        public void AddSupportedPointFormatsExtension(){} // RVA: 0x7B1377DD0
        public void GetSupportedEllipticCurvesExtension(){} // RVA: 0x7B1377FE0
        public void GetSupportedPointFormatsExtension(){} // RVA: 0x7B1378080
        public void CreateSupportedEllipticCurvesExtension(){} // RVA: 0x7B1378120
        public void CreateSupportedPointFormatsExtension(){} // RVA: 0x7B13781C0
        public void ReadSupportedEllipticCurvesExtension(){} // RVA: 0x7B1378330
        public void ReadSupportedPointFormatsExtension(){} // RVA: 0x7B1378510
        public void GetNameOfNamedCurve(){} // RVA: 0x7B1378600
        public void GetParametersForNamedCurve(){} // RVA: 0x7B13786B0
        public void HasAnySupportedNamedCurves(){} // RVA: 0x7B1378A00
        public void ContainsEccCipherSuites(){} // RVA: 0x7B1378A70
        public void IsEccCipherSuite(){} // RVA: 0x7B1378B20
        public void AreOnSameCurve(){} // RVA: 0x7B1378BB0
        public void IsSupportedNamedCurve(){} // RVA: 0x7B1378BD0
        public void IsCompressionPreferred(){} // RVA: 0x7B1378C50
        public void SerializeECFieldElement(){} // RVA: 0x7B1378CA0
        public void SerializeECPoint(){} // RVA: 0x7B1378CC0
        public void SerializeECPublicKey(){} // RVA: 0x7B1378E80
        public void DeserializeECFieldElement(){} // RVA: 0x7B1378EF0
        public void DeserializeECPoint(){} // RVA: 0x7B1378FC0
        public void DeserializeECPublicKey(){} // RVA: 0x7B1379210
        public void CalculateECDHBasicAgreement(){} // RVA: 0x7B1379360
        public void GenerateECKeyPair(){} // RVA: 0x7B1379420
        public void GenerateEphemeralClientKeyExchange(){} // RVA: 0x7B1379510
        public void GenerateEphemeralServerKeyExchange(){} // RVA: 0x7B1379800
        public void ValidateECPublicKey(){} // RVA: 0x7A97F8BA0
        public void ReadECExponent(){} // RVA: 0x7B1379B90
        public void ReadECFieldElement(){} // RVA: 0x7B1379C90
        public void ReadECParameter(){} // RVA: 0x7B1379DD0
        public void ReadECParameters(){} // RVA: 0x7B1379E80
        public void CheckNamedCurve(){} // RVA: 0x7B137A500
        public void WriteECExponent(){} // RVA: 0x7B137A5C0
        public void WriteECFieldElement(){} // RVA: 0x7B137A760
        public void WriteECParameter(){} // RVA: 0x7B137A890
        public void WriteExplicitECParameters(){} // RVA: 0x7B137A980
        public void WriteECPoint(){} // RVA: 0x7B137AF30
        public void WriteNamedECParameters(){} // RVA: 0x7B137B050
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B137B150
    }

    public class TlsEncryptionCredentials
    {
        // ── Methods ──
        public void DecryptPreMasterSecret(){} // RVA: 0x7A7E00B20
    }

    public class TlsException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC13C20
    }

    public class TlsExtensionsUtilities : Object
    {
        // ── Methods ──
        public void EnsureExtensionsInitialised(){} // RVA: 0x7B137D250
        public void AddClientCertificateTypeExtensionClient(){} // RVA: 0x7B137D2F0
        public void AddClientCertificateTypeExtensionServer(){} // RVA: 0x7B137D3A0
        public void AddEncryptThenMacExtension(){} // RVA: 0x7B137D480
        public void AddExtendedMasterSecretExtension(){} // RVA: 0x7B137D560
        public void AddHeartbeatExtension(){} // RVA: 0x7B137D640
        public void AddMaxFragmentLengthExtension(){} // RVA: 0x7B137D7A0
        public void AddPaddingExtension(){} // RVA: 0x7B137D880
        public void AddServerCertificateTypeExtensionClient(){} // RVA: 0x7B137D980
        public void AddServerCertificateTypeExtensionServer(){} // RVA: 0x7B137DA30
        public void AddServerNameExtension(){} // RVA: 0x7B137DB10
        public void AddStatusRequestExtension(){} // RVA: 0x7B137DCF0
        public void AddTruncatedHMacExtension(){} // RVA: 0x7B137DE50
        public void GetClientCertificateTypeExtensionClient(){} // RVA: 0x7B137DF30
        public void GetClientCertificateTypeExtensionServer(){} // RVA: 0x7B137DFA0
        public void GetHeartbeatExtension(){} // RVA: 0x7B137E050
        public void GetMaxFragmentLengthExtension(){} // RVA: 0x7B137E0C0
        public void GetPaddingExtension(){} // RVA: 0x7B137E170
        public void GetServerCertificateTypeExtensionClient(){} // RVA: 0x7B137E250
        public void GetServerCertificateTypeExtensionServer(){} // RVA: 0x7B137E2C0
        public void GetServerNameExtension(){} // RVA: 0x7B137E370
        public void GetStatusRequestExtension(){} // RVA: 0x7B137E4C0
        public void HasEncryptThenMacExtension(){} // RVA: 0x7B137E610
        public void HasExtendedMasterSecretExtension(){} // RVA: 0x7B137E6C0
        public void HasTruncatedHMacExtension(){} // RVA: 0x7B137E770
        public void CreateCertificateTypeExtensionClient(){} // RVA: 0x7B137E820
        public void CreateCertificateTypeExtensionServer(){} // RVA: 0x7B137E8C0
        public void CreateEmptyExtensionData(){} // RVA: 0x7B137E910
        public void CreateEncryptThenMacExtension(){} // RVA: 0x7B137E970
        public void CreateExtendedMasterSecretExtension(){} // RVA: 0x7B137E970
        public void CreateHeartbeatExtension(){} // RVA: 0x7B137E9D0
        public void CreateMaxFragmentLengthExtension(){} // RVA: 0x7B137EAA0
        public void CreatePaddingExtension(){} // RVA: 0x7B137EAF0
        public void CreateServerNameExtension(){} // RVA: 0x7B137EB60
        public void CreateStatusRequestExtension(){} // RVA: 0x7B137EC30
        public void CreateTruncatedHMacExtension(){} // RVA: 0x7B137E970
        public void ReadEmptyExtensionData(){} // RVA: 0x7B137ED00
        public void ReadCertificateTypeExtensionClient(){} // RVA: 0x7B137EDA0
        public void ReadCertificateTypeExtensionServer(){} // RVA: 0x7B137EE40
        public void ReadEncryptThenMacExtension(){} // RVA: 0x7B137ED00
        public void ReadExtendedMasterSecretExtension(){} // RVA: 0x7B137ED00
        public void ReadHeartbeatExtension(){} // RVA: 0x7B137EE90
        public void ReadMaxFragmentLengthExtension(){} // RVA: 0x7B137F0D0
        public void ReadPaddingExtension(){} // RVA: 0x7B137F120
        public void ReadServerNameExtension(){} // RVA: 0x7B137F1F0
        public void ReadStatusRequestExtension(){} // RVA: 0x7B137F340
        public void ReadTruncatedHMacExtension(){} // RVA: 0x7B137ED00
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TlsFatalAlert : TlsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B137F4E0
        public void get_AlertDescription(){} // RVA: 0x7A9101D40
    }

    public class TlsFatalAlertReceived : TlsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B137F490
        public void get_AlertDescription(){} // RVA: 0x7A9101D40
    }

    public class TlsHandshakeHash
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E18800
        public void NotifyPrfDetermined(){} // RVA: 0x7A7E00680
        public void TrackHashAlgorithm(){} // RVA: 0x7A7E18C30
        public void SealHashAlgorithms(){} // RVA: 0x7A7E18770
        public void StopTracking(){} // RVA: 0x7A7E00680
        public void ForkPrfHash(){} // RVA: 0x7A7E00680
        public void GetFinalHash(){} // RVA: 0x7A7E063A0
    }

    public class TlsKeyExchange
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E18800
        public void SkipServerCredentials(){} // RVA: 0x7A7E18770
        public void ProcessServerCredentials(){} // RVA: 0x7A7E18800
        public void ProcessServerCertificate(){} // RVA: 0x7A7E18800
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7A7E01900
        public void GenerateServerKeyExchange(){} // RVA: 0x7A7E00680
        public void SkipServerKeyExchange(){} // RVA: 0x7A7E18770
        public void ProcessServerKeyExchange(){} // RVA: 0x7A7E18800
        public void ValidateCertificateRequest(){} // RVA: 0x7A7E18800
        public void SkipClientCredentials(){} // RVA: 0x7A7E18770
        public void ProcessClientCredentials(){} // RVA: 0x7A7E18800
        public void ProcessClientCertificate(){} // RVA: 0x7A7E18800
        public void GenerateClientKeyExchange(){} // RVA: 0x7A7E18800
        public void ProcessClientKeyExchange(){} // RVA: 0x7A7E18800
        public void GeneratePremasterSecret(){} // RVA: 0x7A7E00680
    }

    public class TlsMac : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B137F540
        public void get_MacSecret(){} // RVA: 0x7A80DA7B0
        public void get_Size(){} // RVA: 0x7A8133100
        public void CalculateMac(){} // RVA: 0x7B137FA50
        public void CalculateMacConstantTime(){} // RVA: 0x7B137FD60
        public void GetDigestBlockCount(){} // RVA: 0x7B137FF90
        public void Truncate(){} // RVA: 0x7B137FFA0
    }

    public class TlsNoCloseNotifyException : EndOfStreamException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1380020
    }

    public class TlsNullCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1380170
        public void GetPlaintextLimit(){} // RVA: 0x7B13805A0
        public void EncodePlaintext(){} // RVA: 0x7B13805D0
        public void DecodeCiphertext(){} // RVA: 0x7B1380730
    }

    public class TlsNullCompression : Object
    {
        // ── Methods ──
        public void Compress(){} // RVA: 0x7A9194610
        public void Decompress(){} // RVA: 0x7A9194610
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TlsPeer
    {
        // ── Methods ──
        public void RequiresExtendedMasterSecret(){} // RVA: 0x7A7E01900
        public void ShouldUseGmtUnixTime(){} // RVA: 0x7A7E01900
        public void NotifySecureRenegotiation(){} // RVA: 0x7A7E18C30
        public void GetCompression(){} // RVA: 0x7A7E00680
        public void GetCipher(){} // RVA: 0x7A7E00680
        public void NotifyAlertRaised(){} // RVA: 0x7A7E19200
        public void NotifyAlertReceived(){} // RVA: 0x7A7E18EC0
        public void NotifyHandshakeComplete(){} // RVA: 0x7A7E18770
    }

    public class TlsProtocol : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1380E20
        public void get_Context(){} // RVA: 0x7A7E00680
        public void get_ContextAdmin(){} // RVA: 0x7A7E00680
        public void get_Peer(){} // RVA: 0x7A7E00680
        public void HandleAlertMessage(){} // RVA: 0x7B13813A0
        public void HandleAlertWarningMessage(){} // RVA: 0x7B1381490
        public void HandleChangeCipherSpecMessage(){} // RVA: 0x7A80D7310
        public void HandleClose(){} // RVA: 0x7B1381510
        public void HandleException(){} // RVA: 0x7B1381600
        public void HandleFailure(){} // RVA: 0x7B1381660
        public void HandleHandshakeMessage(){} // RVA: 0x7A7E19310
        public void ApplyMaxFragmentLengthExtension(){} // RVA: 0x7B13816E0
        public void CheckReceivedChangeCipherSpec(){} // RVA: 0x7B1381790
        public void CleanupHandshake(){} // RVA: 0x7B13817F0
        public void BlockForHandshake(){} // RVA: 0x7B1381B00
        public void CompleteHandshake(){} // RVA: 0x7B1381B90
        public void ProcessRecord(){} // RVA: 0x7B1382290
        public void ProcessHandshakeQueue(){} // RVA: 0x7B1382710
        public void ProcessApplicationDataQueue(){} // RVA: 0x7A80D7310
        public void ProcessAlertQueue(){} // RVA: 0x7B1382990
        public void ProcessChangeCipherSpec(){} // RVA: 0x7B1382A90
        public void ApplicationDataAvailable(){} // RVA: 0x7A97F45C0
        public void ReadApplicationData(){} // RVA: 0x7B1382C20
        public void SafeCheckRecordHeader(){} // RVA: 0x7B1382DF0
        public void SafeReadRecord(){} // RVA: 0x7B1382F50
        public void SafeWriteRecord(){} // RVA: 0x7B1383170
        public void WriteData(){} // RVA: 0x7B13832E0
        public void SetAppDataSplitMode(){} // RVA: 0x7B13834E0
        public void WriteHandshakeMessage(){} // RVA: 0x7B1383590
        public void get_Stream(){} // RVA: 0x7B1383740
        public void CloseInput(){} // RVA: 0x7B13837B0
        public void OfferInput(){} // RVA: 0x7B1383910
        public void GetAvailableInputBytes(){} // RVA: 0x7B1383BD0
        public void ReadInput(){} // RVA: 0x7B1383C50
        public void OfferOutput(){} // RVA: 0x7B1383D60
        public void GetAvailableOutputBytes(){} // RVA: 0x7B1383E30
        public void ReadOutput(){} // RVA: 0x7B1383EC0
        public void InvalidateSession(){} // RVA: 0x7B1383F50
        public void ProcessFinishedMessage(){} // RVA: 0x7B1384070
        public void RaiseAlertFatal(){} // RVA: 0x7B1384280
        public void RaiseAlertWarning(){} // RVA: 0x7B1384390
        public void SendCertificateMessage(){} // RVA: 0x7B1384490
        public void SendChangeCipherSpecMessage(){} // RVA: 0x7B1384690
        public void SendFinishedMessage(){} // RVA: 0x7B13848C0
        public void SendSupplementalDataMessage(){} // RVA: 0x7B13849D0
        public void CreateVerifyData(){} // RVA: 0x7B1384A60
        public void Close(){} // RVA: 0x7ADC48D50
        public void Flush(){} // RVA: 0x7B1384B90
        public void get_IsClosed(){} // RVA: 0x7AE0A2950
        public void ProcessMaxFragmentLengthExtension(){} // RVA: 0x7B1384BD0
        public void RefuseRenegotiation(){} // RVA: 0x7B1384C80
        public void AssertEmpty(){} // RVA: 0x7B1384D70
        public void CreateRandomBlock(){} // RVA: 0x7B1384E10
        public void CreateRenegotiationInfo(){} // RVA: 0x7B1384F70
        public void EstablishMasterSecret(){} // RVA: 0x7B1385040
        public void GetCurrentPrfHash(){} // RVA: 0x7B1385220
        public void ReadExtensions(){} // RVA: 0x7B13853B0
        public void ReadSupplementalDataMessage(){} // RVA: 0x7B1385730
        public void WriteExtensions(){} // RVA: 0x7B1385B10
        public void WriteSelectedExtensions(){} // RVA: 0x7B1385BF0
        public void WriteSupplementalData(){} // RVA: 0x7B1385FC0
        public void GetPrfAlgorithm(){} // RVA: 0x7B13863C0
    }

    public class TlsProtocolHandler : TlsClientProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1370200
    }

    public class TlsPskIdentity
    {
        // ── Methods ──
        public void SkipIdentityHint(){} // RVA: 0x7A7E18770
        public void NotifyIdentityHint(){} // RVA: 0x7A7E18800
        public void GetPskIdentity(){} // RVA: 0x7A7E00680
        public void GetPsk(){} // RVA: 0x7A7E00680
    }

    public class TlsPskIdentityManager
    {
        // ── Methods ──
        public void GetHint(){} // RVA: 0x7A7E00680
        public void GetPsk(){} // RVA: 0x7A7E00B20
    }

    public class TlsPskKeyExchange : AbstractTlsKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1386A80
        public void SkipServerCredentials(){} // RVA: 0x7B1386DE0
        public void ProcessServerCredentials(){} // RVA: 0x7B1386E40
        public void GenerateServerKeyExchange(){} // RVA: 0x7B1386FC0
        public void ProcessServerCertificate(){} // RVA: 0x7B1387340
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7B1387610
        public void ProcessServerKeyExchange(){} // RVA: 0x7B1387630
        public void ValidateCertificateRequest(){} // RVA: 0x7B1387910
        public void ProcessClientCredentials(){} // RVA: 0x7B1387960
        public void GenerateClientKeyExchange(){} // RVA: 0x7B13879B0
        public void ProcessClientKeyExchange(){} // RVA: 0x7B1387D40
        public void GeneratePremasterSecret(){} // RVA: 0x7B1388110
        public void GenerateOtherSecret(){} // RVA: 0x7B13882E0
        public void ValidateRsaPublicKey(){} // RVA: 0x7B1388470
    }

    public class TlsRsaKeyExchange : AbstractTlsKeyExchange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7FB640
        public void SkipServerCredentials(){} // RVA: 0x7B13884F0
        public void ProcessServerCredentials(){} // RVA: 0x7B1388540
        public void ProcessServerCertificate(){} // RVA: 0x7B13886C0
        public void ValidateCertificateRequest(){} // RVA: 0x7B1388990
        public void ProcessClientCredentials(){} // RVA: 0x7B1388A50
        public void GenerateClientKeyExchange(){} // RVA: 0x7B1388AD0
        public void ProcessClientKeyExchange(){} // RVA: 0x7B1388B40
        public void GeneratePremasterSecret(){} // RVA: 0x7B1388C60
        public void ValidateRsaPublicKey(){} // RVA: 0x7B1388D10
    }

    public class TlsRsaSigner : AbstractTlsSigner
    {
        // ── Methods ──
        public void GenerateRawSignature(){} // RVA: 0x7B1388D90
        public void VerifyRawSignature(){} // RVA: 0x7B1389000
        public void CreateSigner(){} // RVA: 0x7B13890E0
        public void CreateVerifyer(){} // RVA: 0x7B13892E0
        public void IsValidPublicKey(){} // RVA: 0x7B1389310
        public void MakeSigner(){} // RVA: 0x7B1389380
        public void CreateRsaImpl(){} // RVA: 0x7B13898D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TlsRsaUtilities : Object
    {
        // ── Methods ──
        public void GenerateEncryptedPreMasterSecret(){} // RVA: 0x7B1389950
        public void SafeDecryptPreMasterSecret(){} // RVA: 0x7B1389D80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TlsSRTPUtils : Object
    {
        // ── Methods ──
        public void AddUseSrtpExtension(){} // RVA: 0x7B1390100
        public void GetUseSrtpExtension(){} // RVA: 0x7B1390330
        public void CreateUseSrtpExtension(){} // RVA: 0x7B13903A0
        public void ReadUseSrtpExtension(){} // RVA: 0x7B1390560
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TlsServer
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E18800
        public void NotifyClientVersion(){} // RVA: 0x7A7E18800
        public void NotifyFallback(){} // RVA: 0x7A7E18C30
        public void NotifyOfferedCipherSuites(){} // RVA: 0x7A7E18800
        public void NotifyOfferedCompressionMethods(){} // RVA: 0x7A7E18800
        public void ProcessClientExtensions(){} // RVA: 0x7A7E18800
        public void GetServerVersion(){} // RVA: 0x7A7E00680
        public void GetSelectedCipherSuite(){} // RVA: 0x7A7E00710
        public void GetSelectedCompressionMethod(){} // RVA: 0x7A7E01900
        public void GetServerExtensions(){} // RVA: 0x7A7E00680
        public void GetServerSupplementalData(){} // RVA: 0x7A7E00680
        public void GetCredentials(){} // RVA: 0x7A7E00680
        public void GetCertificateStatus(){} // RVA: 0x7A7E00680
        public void GetKeyExchange(){} // RVA: 0x7A7E00680
        public void GetCertificateRequest(){} // RVA: 0x7A7E00680
        public void ProcessClientSupplementalData(){} // RVA: 0x7A7E18800
        public void NotifyClientCertificate(){} // RVA: 0x7A7E18800
        public void GetNewSessionTicket(){} // RVA: 0x7A7E00680
    }

    public class TlsServerContextImpl : AbstractTlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B138A2E0
        public void get_IsServer(){} // RVA: 0x7A81BD750
    }

    public class TlsServerProtocol : TlsProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B138A3A0
        public void Accept(){} // RVA: 0x7B138A3C0
        public void CleanupHandshake(){} // RVA: 0x7B138A770
        public void get_Context(){} // RVA: 0x7A8142610
        public void get_ContextAdmin(){} // RVA: 0x7A8142610
        public void get_Peer(){} // RVA: 0x7A87D9480
        public void HandleHandshakeMessage(){} // RVA: 0x7B138A900
        public void HandleAlertWarningMessage(){} // RVA: 0x7B138B4D0
        public void NotifyClientCertificate(){} // RVA: 0x7B138B6D0
        public void ReceiveCertificateMessage(){} // RVA: 0x7B138B900
        public void ReceiveCertificateVerifyMessage(){} // RVA: 0x7B138BA10
        public void ReceiveClientHelloMessage(){} // RVA: 0x7B138BE60
        public void ReceiveClientKeyExchangeMessage(){} // RVA: 0x7B138C530
        public void SendCertificateRequestMessage(){} // RVA: 0x7B138C890
        public void SendCertificateStatusMessage(){} // RVA: 0x7B138C930
        public void SendNewSessionTicketMessage(){} // RVA: 0x7B138C9D0
        public void SendServerHelloMessage(){} // RVA: 0x7B138CAB0
        public void SendServerHelloDoneMessage(){} // RVA: 0x7B138D4C0
        public void SendServerKeyExchangeMessage(){} // RVA: 0x7B138D5A0
        public void ExpectCertificateVerifyMessage(){} // RVA: 0x7B138D650
    }

    public class TlsSession
    {
        // ── Methods ──
        public void ExportSessionParameters(){} // RVA: 0x7A7E00680
        public void get_SessionID(){} // RVA: 0x7A7E00680
        public void Invalidate(){} // RVA: 0x7A7E18770
        public void get_IsResumable(){} // RVA: 0x7A7E01900
    }

    public class TlsSessionImpl : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B138D6C0
        public void ExportSessionParameters(){} // RVA: 0x7B138D910
        public void get_SessionID(){} // RVA: 0x7B138DAF0
        public void Invalidate(){} // RVA: 0x7B138DBF0
        public void get_IsResumable(){} // RVA: 0x7B138DCE0
    }

    public class TlsSigner
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E18800
        public void GenerateRawSignature(){} // RVA: 0x7A7E06710
        public void VerifyRawSignature(){} // RVA: 0x7A7E01DE0
        public void CreateSigner(){} // RVA: 0x7A7E00BD0
        public void CreateVerifyer(){} // RVA: 0x7A7E00BD0
        public void IsValidPublicKey(){} // RVA: 0x7A7E019D0
    }

    public class TlsSignerCredentials
    {
        // ── Methods ──
        public void GenerateCertificateSignature(){} // RVA: 0x7A7E00B20
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x7A7E00680
    }

    public class TlsSrpGroupVerifier
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0x7A7E019D0
    }

    public class TlsSrpIdentityManager
    {
        // ── Methods ──
        public void GetLoginParameters(){} // RVA: 0x7A7E00B20
    }

    public class TlsSrpKeyExchange : AbstractTlsKeyExchange
    {
        // ── Methods ──
        public void CreateSigner(){} // RVA: 0x7B138DDE0
        public void .ctor(){} // RVA: 0x7B138E1B0
        public void Init(){} // RVA: 0x7B138E4C0
        public void SkipServerCredentials(){} // RVA: 0x7B138E530
        public void ProcessServerCertificate(){} // RVA: 0x7B138E590
        public void ProcessServerCredentials(){} // RVA: 0x7B138E7E0
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7A81BD750
        public void GenerateServerKeyExchange(){} // RVA: 0x7B138E970
        public void ProcessServerKeyExchange(){} // RVA: 0x7B138EDA0
        public void ValidateCertificateRequest(){} // RVA: 0x7B138F3B0
        public void ProcessClientCredentials(){} // RVA: 0x7B138F400
        public void GenerateClientKeyExchange(){} // RVA: 0x7B138F450
        public void ProcessClientKeyExchange(){} // RVA: 0x7B138F630
        public void GeneratePremasterSecret(){} // RVA: 0x7B138F870
        public void InitVerifyer(){} // RVA: 0x7B138F950
    }

    public class TlsSrpLoginParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void get_Group(){} // RVA: 0x7A80F2570
        public void get_Salt(){} // RVA: 0x7A81052C0
        public void get_Verifier(){} // RVA: 0x7A80DA7B0
    }

    public class TlsSrpUtilities : Object
    {
        // ── Methods ──
        public void AddSrpExtension(){} // RVA: 0x7B138FA50
        public void GetSrpExtension(){} // RVA: 0x7B138FBE0
        public void CreateSrpExtension(){} // RVA: 0x7B138FD50
        public void ReadSrpExtension(){} // RVA: 0x7B138FE50
        public void ReadSrpParameter(){} // RVA: 0x7B138FFC0
        public void WriteSrpParameter(){} // RVA: 0x7B1390070
        public void IsSrpCipherSuite(){} // RVA: 0x7B13900F0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TlsStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13908D0
        public void get_CanRead(){} // RVA: 0x7B1390970
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7B1390970
        public void Close(){} // RVA: 0x7B13909A0
        public void Flush(){} // RVA: 0x7B13909E0
        public void get_Length(){} // RVA: 0x7B1390A10
        public void get_Position(){} // RVA: 0x7B1390A50
        public void set_Position(){} // RVA: 0x7B1390A90
        public void Read(){} // RVA: 0x7B1390AD0
        public void ReadByte(){} // RVA: 0x7B1390B00
        public void Seek(){} // RVA: 0x7B1390BB0
        public void SetLength(){} // RVA: 0x7B1390BF0
        public void Write(){} // RVA: 0x7B1390C30
        public void WriteByte(){} // RVA: 0x7B1390C60
    }

    public class TlsStreamCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1390D00
        public void GetPlaintextLimit(){} // RVA: 0x7B13914A0
        public void EncodePlaintext(){} // RVA: 0x7B13914E0
        public void DecodeCiphertext(){} // RVA: 0x7B1391660
        public void CheckMac(){} // RVA: 0x7B1391840
        public void UpdateIV(){} // RVA: 0x7B13919C0
    }

    public class TlsUtilities : Object
    {
        // ── Methods ──
        public void CheckUint8(){} // RVA: 0x7B1391B70
        public void CheckUint16(){} // RVA: 0x7B1391C90
        public void CheckUint24(){} // RVA: 0x7B1391DB0
        public void CheckUint32(){} // RVA: 0x7B1391E40
        public void CheckUint48(){} // RVA: 0x7B1391ED0
        public void CheckUint64(){} // RVA: 0x7B1391F70
        public void IsValidUint8(){} // RVA: 0x7B1391FC0
        public void IsValidUint16(){} // RVA: 0x7B1391FE0
        public void IsValidUint24(){} // RVA: 0x7B1392000
        public void IsValidUint32(){} // RVA: 0x7B1392010
        public void IsValidUint48(){} // RVA: 0x7B1392020
        public void IsValidUint64(){} // RVA: 0x7A81BD750
        public void IsSsl(){} // RVA: 0x7B1392040
        public void IsTlsV11(){} // RVA: 0x7B13921D0
        public void IsTlsV12(){} // RVA: 0x7B13923F0
        public void WriteUint8(){} // RVA: 0x7B1392560
        public void WriteUint16(){} // RVA: 0x7B13925F0
        public void WriteUint24(){} // RVA: 0x7B13926B0
        public void WriteUint32(){} // RVA: 0x7B13927A0
        public void WriteUint48(){} // RVA: 0x7B13928F0
        public void WriteUint64(){} // RVA: 0x7B1392AB0
        public void WriteOpaque8(){} // RVA: 0x7B1392BA0
        public void WriteOpaque16(){} // RVA: 0x7B1392C50
        public void WriteOpaque24(){} // RVA: 0x7B1392D20
        public void WriteUint8Array(){} // RVA: 0x7B1392E60
        public void WriteUint8ArrayWithUint8Length(){} // RVA: 0x7B1392FE0
        public void WriteUint16Array(){} // RVA: 0x7B13931F0
        public void WriteUint16ArrayWithUint16Length(){} // RVA: 0x7B1393430
        public void DecodeUint8(){} // RVA: 0x7B1393590
        public void DecodeUint8ArrayWithUint8Length(){} // RVA: 0x7B1393680
        public void EncodeOpaque8(){} // RVA: 0x7B1393840
        public void EncodeUint8(){} // RVA: 0x7B13938D0
        public void EncodeUint8ArrayWithUint8Length(){} // RVA: 0x7B1393960
        public void EncodeUint16ArrayWithUint16Length(){} // RVA: 0x7B1393AE0
        public void ReadUint8(){} // RVA: 0x7B1393D00
        public void ReadUint16(){} // RVA: 0x7B1393DD0
        public void ReadUint24(){} // RVA: 0x7B1393ED0
        public void ReadUint32(){} // RVA: 0x7B1394020
        public void ReadUint48(){} // RVA: 0x7B1394110
        public void ReadAllOrNothing(){} // RVA: 0x7B1394200
        public void ReadFully(){} // RVA: 0x7B13944D0
        public void ReadOpaque8(){} // RVA: 0x7B13945A0
        public void ReadOpaque16(){} // RVA: 0x7B1394690
        public void ReadOpaque24(){} // RVA: 0x7B13947A0
        public void ReadUint8Array(){} // RVA: 0x7B1394800
        public void ReadUint16Array(){} // RVA: 0x7B1394920
        public void ReadVersion(){} // RVA: 0x7B1394B10
        public void ReadVersionRaw(){} // RVA: 0x7B1394BF0
        public void ReadAsn1Object(){} // RVA: 0x7B1394C90
        public void ReadDerObject(){} // RVA: 0x7B1394E10
        public void WriteGmtUnixTime(){} // RVA: 0x7B1394FB0
        public void WriteVersion(){} // RVA: 0x7B13950F0
        public void GetAllSignatureAlgorithms(){} // RVA: 0x7B1395140
        public void GetDefaultDssSignatureAlgorithms(){} // RVA: 0x7B13953F0
        public void GetDefaultECDsaSignatureAlgorithms(){} // RVA: 0x7B13954B0
        public void GetDefaultRsaSignatureAlgorithms(){} // RVA: 0x7B1395570
        public void GetExtensionData(){} // RVA: 0x7B1395630
        public void GetDefaultSupportedSignatureAlgorithms(){} // RVA: 0x7B13956F0
        public void GetSignatureAndHashAlgorithm(){} // RVA: 0x7B1395910
        public void HasExpectedEmptyExtensionData(){} // RVA: 0x7B1395A50
        public void ImportSession(){} // RVA: 0x7B1395B20
        public void IsSignatureAlgorithmsExtensionAllowed(){} // RVA: 0x7B1395B90
        public void AddSignatureAlgorithmsExtension(){} // RVA: 0x7B1395C70
        public void GetSignatureAlgorithmsExtension(){} // RVA: 0x7B1395DD0
        public void CreateSignatureAlgorithmsExtension(){} // RVA: 0x7B1395F60
        public void ReadSignatureAlgorithmsExtension(){} // RVA: 0x7B1396010
        public void EncodeSupportedSignatureAlgorithms(){} // RVA: 0x7B1396180
        public void ParseSupportedSignatureAlgorithms(){} // RVA: 0x7B1396550
        public void VerifySupportedSignatureAlgorithm(){} // RVA: 0x7B1396780
        public void PRF(){} // RVA: 0x7B1396B00
        public void PRF_legacy(){} // RVA: 0x7B1396F20
        public void Concat(){} // RVA: 0x7B13970D0
        public void HMacHash(){} // RVA: 0x7B1397180
        public void ValidateKeyUsage(){} // RVA: 0x7B1397450
        public void CalculateKeyBlock(){} // RVA: 0x7B1397570
        public void CalculateKeyBlock_Ssl(){} // RVA: 0x7B1397770
        public void CalculateMasterSecret(){} // RVA: 0x7B1397DA0
        public void CalculateMasterSecret_Ssl(){} // RVA: 0x7B1398030
        public void CalculateVerifyData(){} // RVA: 0x7B1398600
        public void CreateHash(){} // RVA: 0x7B1398930
        public void CloneHash(){} // RVA: 0x7B13989D0
        public void CreatePrfHash(){} // RVA: 0x7B1398E10
        public void ClonePrfHash(){} // RVA: 0x7B1398EA0
        public void GetHashAlgorithmForPrfAlgorithm(){} // RVA: 0x7B1398F80
        public void GetOidForHashAlgorithm(){} // RVA: 0x7B1399070
        public void GetClientCertificateType(){} // RVA: 0x7B1399280
        public void TrackHashAlgorithms(){} // RVA: 0x7B1399550
        public void HasSigningCapability(){} // RVA: 0x7B13997D0
        public void CreateTlsSigner(){} // RVA: 0x7B13997F0
        public void GenSsl3Const(){} // RVA: 0x7B13998F0
        public void VectorOfOne(){} // RVA: 0x7B1399A70
        public void GetCipherType(){} // RVA: 0x7B1399BC0
        public void GetEncryptionAlgorithm(){} // RVA: 0x7B1399CC0
        public void GetKeyExchangeAlgorithm(){} // RVA: 0x7B139A080
        public void GetMacAlgorithm(){} // RVA: 0x7B139A4A0
        public void GetMinimumVersion(){} // RVA: 0x7B139A750
        public void IsAeadCipherSuite(){} // RVA: 0x7B139A860
        public void IsBlockCipherSuite(){} // RVA: 0x7B139A8C0
        public void IsStreamCipherSuite(){} // RVA: 0x7B139A920
        public void IsValidCipherSuiteForSignatureAlgorithms(){} // RVA: 0x7B139A980
        public void IsValidCipherSuiteForVersion(){} // RVA: 0x7B139AB70
        public void GetUsableSignatureAlgorithms(){} // RVA: 0x7B139AD60
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B139B2A0
    }

}