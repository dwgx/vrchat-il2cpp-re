// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 61
// Methods: 663

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class TlsAeadCipher : Object
    {
        public int NONCE_RFC5288;
        public int NONCE_DRAFT_CHACHA20_POLY1305;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext context; // 0x10
        public int macSize; // 0x18
        public int record_iv_length; // 0x1C
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher encryptCipher; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher decryptCipher; // 0x28
        public byte[] encryptImplicitNonce; // 0x30
        public byte[] decryptImplicitNonce; // 0x38
        public int nonceMode; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB40560 | overloaded x2
        public void GetPlaintextLimit(){} // RVA: 0x7FFACBB40A30
        public void EncodePlaintext(){} // RVA: 0x7FFACBB40A40
        public void DecodeCiphertext(){} // RVA: 0x7FFACBB40E60
        public void GetAdditionalData(){} // RVA: 0x7FFACBB412B0
    }

    public class TlsAgreementCredentials
    {
        // ── Methods ──
        public void GenerateAgreement(){} // RVA: 0x7FFAC2C58F40
    }

    public class TlsAuthentication
    {
        // ── Methods ──
        public void NotifyServerCertificate(){} // RVA: 0x7FFAC2C70A40
        public void GetClientCredentials(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class TlsBlockCipher : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext WriteMac; // 0x10
        public byte[] ReadMac; // 0x18
        public bool useExplicitIV; // 0x20
        public bool encryptThenMac; // 0x21
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher encryptCipher; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher decryptCipher; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsMac mWriteMac; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsMac mReadMac; // 0x40
        public byte[] explicitIV; // 0x48

        // ── Methods ──
        public void get_WriteMac(){} // RVA: 0x7FFAC31D0140
        public void get_ReadMac(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFACBB413E0
        public void GetPlaintextLimit(){} // RVA: 0x7FFACBB41D30
        public void EncodePlaintext(){} // RVA: 0x7FFACBB41E00
        public void DecodeCiphertext(){} // RVA: 0x7FFACBB42340
        public void CheckPaddingConstantTime(){} // RVA: 0x7FFACBB42940
        public void ChooseExtraPadBlocks(){} // RVA: 0x7FFACBB42AB0
        public void LowestBitSet(){} // RVA: 0x7FFACBB42B60
    }

    public class TlsCipher
    {
        // ── Methods ──
        public void GetPlaintextLimit(){} // RVA: 0x7FFAC2C600D0
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
        public object HostNames;
        public object ClientHelloRecordLayerVersion;
        public object ClientVersion;
        public object IsFallback;

        // ── Methods ──
        public void get_HostNames(){} // RVA: 0x7FFAC2C58E90
        public void set_HostNames(){} // RVA: 0x7FFAC2C70A40
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void GetSessionToResume(){} // RVA: 0x7FFAC2C58E90
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0x7FFAC2C58E90
        public void get_ClientVersion(){} // RVA: 0x7FFAC2C58E90
        public void get_IsFallback(){} // RVA: 0x7FFAC2C59D00
        public void GetCipherSuites(){} // RVA: 0x7FFAC2C58E90
        public void GetCompressionMethods(){} // RVA: 0x7FFAC2C58E90
        public void GetClientExtensions(){} // RVA: 0x7FFAC2C58E90
        public void NotifyServerVersion(){} // RVA: 0x7FFAC2C70A40
        public void NotifySessionID(){} // RVA: 0x7FFAC2C70A40
        public void NotifySelectedCipherSuite(){} // RVA: 0x7FFAC2C70ED0
        public void NotifySelectedCompressionMethod(){} // RVA: 0x7FFAC2C71060
        public void ProcessServerExtensions(){} // RVA: 0x7FFAC2C70A40
        public void ProcessServerSupplementalData(){} // RVA: 0x7FFAC2C70A40
        public void GetKeyExchange(){} // RVA: 0x7FFAC2C58E90
        public void GetAuthentication(){} // RVA: 0x7FFAC2C58E90
        public void GetClientSupplementalData(){} // RVA: 0x7FFAC2C58E90
        public void NotifyNewSessionTicket(){} // RVA: 0x7FFAC2C70A40
    }

    public class TlsClientContext
    {
    }

    public class TlsClientContextImpl : AbstractTlsContext
    {
        public object IsServer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB42B80
        public void get_IsServer(){} // RVA: 0x7FFAC2F21320
    }

    public class TlsClientProtocol : TlsProtocol
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsClient Context; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsClientContextImpl ContextAdmin; // 0xB0
        public byte[] Peer; // 0xB8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsKeyExchange mKeyExchange; // 0xC0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsAuthentication mAuthentication; // 0xC8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.CertificateStatus mCertificateStatus; // 0xD0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.CertificateRequest mCertificateRequest; // 0xD8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB42C20 | overloaded x3
        public void Connect(){} // RVA: 0x7FFACBB42C30
        public void CleanupHandshake(){} // RVA: 0x7FFACBB43080
        public void get_Context(){} // RVA: 0x7FFAC2F8C040
        public void get_ContextAdmin(){} // RVA: 0x7FFAC2F8C040
        public void get_Peer(){} // RVA: 0x7FFAC354B1A0
        public void HandleHandshakeMessage(){} // RVA: 0x7FFACBB43260
        public void HandleSupplementalData(){} // RVA: 0x7FFACBB443A0
        public void ReceiveNewSessionTicketMessage(){} // RVA: 0x7FFACBB444D0
        public void ReceiveServerHelloMessage(){} // RVA: 0x7FFACBB445C0
        public void SendCertificateVerifyMessage(){} // RVA: 0x7FFACBB45330
        public void SendClientHelloMessage(){} // RVA: 0x7FFACBB453D0
        public void SendClientKeyExchangeMessage(){} // RVA: 0x7FFACBB45D30
    }

    public class TlsCompression
    {
        // ── Methods ──
        public void Compress(){} // RVA: 0x7FFAC2C58F40
        public void Decompress(){} // RVA: 0x7FFAC2C58F40
    }

    public class TlsContext
    {
        public object NonceRandomGenerator;
        public object SecureRandom;
        public object SecurityParameters;
        public object IsServer;
        public object ClientVersion;
        public object ServerVersion;
        public object ResumableSession;
        public object UserObject;

        // ── Methods ──
        public void get_NonceRandomGenerator(){} // RVA: 0x7FFAC2C58E90
        public void get_SecureRandom(){} // RVA: 0x7FFAC2C58E90
        public void get_SecurityParameters(){} // RVA: 0x7FFAC2C58E90
        public void get_IsServer(){} // RVA: 0x7FFAC2C59D00
        public void get_ClientVersion(){} // RVA: 0x7FFAC2C58E90
        public void get_ServerVersion(){} // RVA: 0x7FFAC2C58E90
        public void get_ResumableSession(){} // RVA: 0x7FFAC2C58E90
        public void get_UserObject(){} // RVA: 0x7FFAC2C58E90
        public void set_UserObject(){} // RVA: 0x7FFAC2C70A40
        public void ExportKeyingMaterial(){}
    }

    public class TlsCredentials
    {
        public object Certificate;

        // ── Methods ──
        public void get_Certificate(){} // RVA: 0x7FFAC2C58E90
    }

    public class TlsDHKeyExchange : AbstractTlsKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSigner RequiresServerKeyExchange; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsDHVerifier mDHVerifier; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters mDHParameters; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsAgreementCredentials mAgreementCredentials; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters mDHAgreePrivateKey; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters mDHAgreePublicKey; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB46D10 | overloaded x2
        public void Init(){} // RVA: 0x7FFACBB46F70
        public void SkipServerCredentials(){} // RVA: 0x7FFACBB46FE0
        public void ProcessServerCertificate(){} // RVA: 0x7FFACBB47040
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFACBB473D0
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFACBB473F0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFACBB47550
        public void ValidateCertificateRequest(){} // RVA: 0x7FFACBB47730
        public void ProcessClientCredentials(){} // RVA: 0x7FFACBB47830
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFACBB479E0
        public void ProcessClientCertificate(){} // RVA: 0x7FFACBB47AF0
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFACBB47B50
        public void GeneratePremasterSecret(){} // RVA: 0x7FFACBB47C50
    }

    public class TlsDHUtilities : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Two;
        public string draft_ffdhe2432_p; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe2432; // 0x10
        public string draft_ffdhe3072_p; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe3072; // 0x20
        public string draft_ffdhe4096_p; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe4096; // 0x30
        public string draft_ffdhe6144_p; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe6144; // 0x40
        public string draft_ffdhe8192_p; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe8192; // 0x50

        // ── Methods ──
        public void FromHex(){} // RVA: 0x7FFACBB47D30
        public void FromSafeP(){} // RVA: 0x7FFACBB47DE0
        public void AddNegotiatedDheGroupsClientExtension(){} // RVA: 0x7FFACBB47F40
        public void AddNegotiatedDheGroupsServerExtension(){} // RVA: 0x7FFACBB480D0
        public void GetNegotiatedDheGroupsClientExtension(){} // RVA: 0x7FFACBB48210
        public void GetNegotiatedDheGroupsServerExtension(){} // RVA: 0x7FFACBB48370
        public void CreateNegotiatedDheGroupsClientExtension(){} // RVA: 0x7FFACBB48490
        public void CreateNegotiatedDheGroupsServerExtension(){} // RVA: 0x7FFACBB48530
        public void ReadNegotiatedDheGroupsClientExtension(){} // RVA: 0x7FFACBB48580
        public void ReadNegotiatedDheGroupsServerExtension(){} // RVA: 0x7FFACBB48620
        public void GetParametersForDHEGroup(){} // RVA: 0x7FFACBB48670
        public void ContainsDheCipherSuites(){} // RVA: 0x7FFACBB487C0
        public void IsDheCipherSuite(){} // RVA: 0x7FFACBB48AA0
        public void AreCompatibleParameters(){} // RVA: 0x7FFACBB48CE0
        public void CalculateDHBasicAgreement(){} // RVA: 0x7FFACBB48DB0
        public void GenerateDHKeyPair(){} // RVA: 0x7FFACBB48E60
        public void GenerateEphemeralClientKeyExchange(){} // RVA: 0x7FFACBB48F30
        public void GenerateEphemeralServerKeyExchange(){} // RVA: 0x7FFACBB490D0
        public void ReadDHParameter(){} // RVA: 0x7FFACBB49390
        public void ReadDHParameters(){} // RVA: 0x7FFACBB49440
        public void ReceiveDHParameters(){} // RVA: 0x7FFACBB494F0
        public void WriteDHParameter(){} // RVA: 0x7FFACBB496B0
        public void WriteDHParameters(){} // RVA: 0x7FFACBB49730
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB49860
    }

    public class TlsDHVerifier
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0x7FFAC2C59F60
    }

    public class TlsDeflateCompression : Object
    {
        public int LEVEL_NONE;
        public int LEVEL_FASTEST;
        public int LEVEL_SMALLEST;
        public int LEVEL_DEFAULT;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream zIn; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream zOut; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB45F50 | overloaded x2
        public void Compress(){} // RVA: 0x7FFACBB460E0
        public void Decompress(){} // RVA: 0x7FFACBB46170
    }

    public class TlsDheKeyExchange : TlsDHKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials mServerCredentials; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB462F0 | overloaded x2
        public void ProcessServerCredentials(){} // RVA: 0x7FFACBB46300
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFACBB46480
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFACBB46840
        public void InitVerifyer(){} // RVA: 0x7FFACBB46B70
    }

    public class TlsDsaSigner : AbstractTlsSigner
    {
        public object SignatureAlgorithm;

        // ── Methods ──
        public void GenerateRawSignature(){} // RVA: 0x7FFACBB49E40
        public void VerifyRawSignature(){} // RVA: 0x7FFACBB49F90
        public void CreateSigner(){} // RVA: 0x7FFACBB4A090
        public void CreateVerifyer(){} // RVA: 0x7FFACBB4A0C0
        public void MakeInitParameters(){} // RVA: 0x7FFAC499E500
        public void MakeSigner(){} // RVA: 0x7FFACBB4A0F0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC2C59D00
        public void CreateDsaImpl(){}
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TlsDssSigner : TlsDsaSigner
    {
        public object SignatureAlgorithm;

        // ── Methods ──
        public void IsValidPublicKey(){} // RVA: 0x7FFACBB4A360
        public void CreateDsaImpl(){} // RVA: 0x7FFACBB4A3F0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC5F481B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TlsECDHKeyExchange : AbstractTlsKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSigner RequiresServerKeyExchange; // 0x28
        public int[] mNamedCurves; // 0x30
        public byte[] mClientECPointFormats; // 0x38
        public byte[] mServerECPointFormats; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsAgreementCredentials mAgreementCredentials; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mECAgreePrivateKey; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters mECAgreePublicKey; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB4E9D0
        public void Init(){} // RVA: 0x7FFACBB4EC70
        public void SkipServerCredentials(){} // RVA: 0x7FFACBB4ECE0
        public void ProcessServerCertificate(){} // RVA: 0x7FFACBB4ED40
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFACBB4F0A0
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFACBB4F0C0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFACBB4F240
        public void ValidateCertificateRequest(){} // RVA: 0x7FFACBB4F3B0
        public void ProcessClientCredentials(){} // RVA: 0x7FFACBB4F4B0
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFACBB4F660
        public void ProcessClientCertificate(){} // RVA: 0x7FFACBB4F780
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFACBB4F7E0
        public void GeneratePremasterSecret(){} // RVA: 0x7FFACBB4F900
    }

    public class TlsECDheKeyExchange : TlsECDHKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials mServerCredentials; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB4DF30
        public void ProcessServerCredentials(){} // RVA: 0x7FFACBB4DF40
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFACBB4E0C0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFACBB4E4B0
        public void ValidateCertificateRequest(){} // RVA: 0x7FFACBB4E790
        public void ProcessClientCredentials(){} // RVA: 0x7FFACBB4E850
        public void InitVerifyer(){} // RVA: 0x7FFACBB4E8D0
    }

    public class TlsECDsaSigner : TlsDsaSigner
    {
        public object SignatureAlgorithm;

        // ── Methods ──
        public void IsValidPublicKey(){} // RVA: 0x7FFACBB4F9E0
        public void CreateDsaImpl(){} // RVA: 0x7FFACBB4FA70
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC88151E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TlsEccUtilities : Object
    {
        public string[] CurveNames;

        // ── Methods ──
        public void AddSupportedEllipticCurvesExtension(){} // RVA: 0x7FFACBB4A4F0
        public void AddSupportedPointFormatsExtension(){} // RVA: 0x7FFACBB4A5C0
        public void GetSupportedEllipticCurvesExtension(){} // RVA: 0x7FFACBB4A7C0
        public void GetSupportedPointFormatsExtension(){} // RVA: 0x7FFACBB4A860
        public void CreateSupportedEllipticCurvesExtension(){} // RVA: 0x7FFACBB4A900
        public void CreateSupportedPointFormatsExtension(){} // RVA: 0x7FFACBB4AB20
        public void ReadSupportedEllipticCurvesExtension(){} // RVA: 0x7FFACBB4AC80
        public void ReadSupportedPointFormatsExtension(){} // RVA: 0x7FFACBB4AE60
        public void GetNameOfNamedCurve(){} // RVA: 0x7FFACBB4AF50
        public void GetParametersForNamedCurve(){} // RVA: 0x7FFACBB4B000
        public void HasAnySupportedNamedCurves(){} // RVA: 0x7FFACBB4B350
        public void ContainsEccCipherSuites(){} // RVA: 0x7FFACBB4B3C0
        public void IsEccCipherSuite(){} // RVA: 0x7FFACBB4B470
        public void AreOnSameCurve(){} // RVA: 0x7FFACBB4B500
        public void IsSupportedNamedCurve(){} // RVA: 0x7FFACBB4B520
        public void IsCompressionPreferred(){} // RVA: 0x7FFACBB4B5A0
        public void SerializeECFieldElement(){} // RVA: 0x7FFACBB4B5F0
        public void SerializeECPoint(){} // RVA: 0x7FFACBB4B610
        public void SerializeECPublicKey(){} // RVA: 0x7FFACBB4B7C0
        public void DeserializeECFieldElement(){} // RVA: 0x7FFACBB4B830
        public void DeserializeECPoint(){} // RVA: 0x7FFACBB4B900
        public void DeserializeECPublicKey(){} // RVA: 0x7FFACBB4BB50
        public void CalculateECDHBasicAgreement(){} // RVA: 0x7FFACBB4BCA0
        public void GenerateECKeyPair(){} // RVA: 0x7FFACBB4BD60
        public void GenerateEphemeralClientKeyExchange(){} // RVA: 0x7FFACBB4BE50
        public void GenerateEphemeralServerKeyExchange(){} // RVA: 0x7FFACBB4C140
        public void ValidateECPublicKey(){} // RVA: 0x7FFAC44F81E0
        public void ReadECExponent(){} // RVA: 0x7FFACBB4C4B0
        public void ReadECFieldElement(){} // RVA: 0x7FFACBB4C5B0
        public void ReadECParameter(){} // RVA: 0x7FFACBB4C6F0
        public void ReadECParameters(){} // RVA: 0x7FFACBB4C7A0
        public void CheckNamedCurve(){} // RVA: 0x7FFACBB4CE10
        public void WriteECExponent(){} // RVA: 0x7FFACBB4CED0
        public void WriteECFieldElement(){} // RVA: 0x7FFACBB4D070 | overloaded x2
        public void WriteECParameter(){} // RVA: 0x7FFACBB4D1A0
        public void WriteExplicitECParameters(){} // RVA: 0x7FFACBB4D290
        public void WriteECPoint(){} // RVA: 0x7FFACBB4D840
        public void WriteNamedECParameters(){} // RVA: 0x7FFACBB4D960
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB4DA60
    }

    public class TlsEncryptionCredentials
    {
        // ── Methods ──
        public void DecryptPreMasterSecret(){} // RVA: 0x7FFAC2C58F40
    }

    public class TlsException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85BCB20
    }

    public class TlsExtensionsUtilities : Object
    {
        // ── Methods ──
        public void EnsureExtensionsInitialised(){} // RVA: 0x7FFACBB4FB70
        public void AddClientCertificateTypeExtensionClient(){} // RVA: 0x7FFACBB4FC10
        public void AddClientCertificateTypeExtensionServer(){} // RVA: 0x7FFACBB4FCC0
        public void AddEncryptThenMacExtension(){} // RVA: 0x7FFACBB4FDA0
        public void AddExtendedMasterSecretExtension(){} // RVA: 0x7FFACBB4FE80
        public void AddHeartbeatExtension(){} // RVA: 0x7FFACBB4FF60
        public void AddMaxFragmentLengthExtension(){} // RVA: 0x7FFACBB500C0
        public void AddPaddingExtension(){} // RVA: 0x7FFACBB501A0
        public void AddServerCertificateTypeExtensionClient(){} // RVA: 0x7FFACBB502A0
        public void AddServerCertificateTypeExtensionServer(){} // RVA: 0x7FFACBB50350
        public void AddServerNameExtension(){} // RVA: 0x7FFACBB50430
        public void AddStatusRequestExtension(){} // RVA: 0x7FFACBB50610
        public void AddTruncatedHMacExtension(){} // RVA: 0x7FFACBB50770
        public void GetClientCertificateTypeExtensionClient(){} // RVA: 0x7FFACBB50850
        public void GetClientCertificateTypeExtensionServer(){} // RVA: 0x7FFACBB508C0
        public void GetHeartbeatExtension(){} // RVA: 0x7FFACBB50970
        public void GetMaxFragmentLengthExtension(){} // RVA: 0x7FFACBB509E0
        public void GetPaddingExtension(){} // RVA: 0x7FFACBB50A90
        public void GetServerCertificateTypeExtensionClient(){} // RVA: 0x7FFACBB50B70
        public void GetServerCertificateTypeExtensionServer(){} // RVA: 0x7FFACBB50BE0
        public void GetServerNameExtension(){} // RVA: 0x7FFACBB50C90
        public void GetStatusRequestExtension(){} // RVA: 0x7FFACBB50DE0
        public void HasEncryptThenMacExtension(){} // RVA: 0x7FFACBB50F30
        public void HasExtendedMasterSecretExtension(){} // RVA: 0x7FFACBB50FE0
        public void HasTruncatedHMacExtension(){} // RVA: 0x7FFACBB51090
        public void CreateCertificateTypeExtensionClient(){} // RVA: 0x7FFACBB51140
        public void CreateCertificateTypeExtensionServer(){} // RVA: 0x7FFACBB511E0
        public void CreateEmptyExtensionData(){} // RVA: 0x7FFACBB51230
        public void CreateEncryptThenMacExtension(){} // RVA: 0x7FFACBB51290
        public void CreateExtendedMasterSecretExtension(){} // RVA: 0x7FFACBB51290
        public void CreateHeartbeatExtension(){} // RVA: 0x7FFACBB512F0
        public void CreateMaxFragmentLengthExtension(){} // RVA: 0x7FFACBB513C0
        public void CreatePaddingExtension(){} // RVA: 0x7FFACBB51410
        public void CreateServerNameExtension(){} // RVA: 0x7FFACBB51480
        public void CreateStatusRequestExtension(){} // RVA: 0x7FFACBB51550
        public void CreateTruncatedHMacExtension(){} // RVA: 0x7FFACBB51290
        public void ReadEmptyExtensionData(){} // RVA: 0x7FFACBB51620
        public void ReadCertificateTypeExtensionClient(){} // RVA: 0x7FFACBB516C0
        public void ReadCertificateTypeExtensionServer(){} // RVA: 0x7FFACBB51760
        public void ReadEncryptThenMacExtension(){} // RVA: 0x7FFACBB51620
        public void ReadExtendedMasterSecretExtension(){} // RVA: 0x7FFACBB51620
        public void ReadHeartbeatExtension(){} // RVA: 0x7FFACBB517B0
        public void ReadMaxFragmentLengthExtension(){} // RVA: 0x7FFACBB519F0
        public void ReadPaddingExtension(){} // RVA: 0x7FFACBB51A40
        public void ReadServerNameExtension(){} // RVA: 0x7FFACBB51B10
        public void ReadStatusRequestExtension(){} // RVA: 0x7FFACBB51C60
        public void ReadTruncatedHMacExtension(){} // RVA: 0x7FFACBB51620
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TlsFatalAlert : TlsException
    {
        public byte AlertDescription; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB51E00 | overloaded x2
        public void get_AlertDescription(){} // RVA: 0x7FFAC3E0D160
    }

    public class TlsFatalAlertReceived : TlsException
    {
        public byte AlertDescription; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB51DB0
        public void get_AlertDescription(){} // RVA: 0x7FFAC3E0D160
    }

    public class TlsHandshakeHash
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void NotifyPrfDetermined(){} // RVA: 0x7FFAC2C58E90
        public void TrackHashAlgorithm(){} // RVA: 0x7FFAC2C71060
        public void SealHashAlgorithms(){} // RVA: 0x7FFAC2C70980
        public void StopTracking(){} // RVA: 0x7FFAC2C58E90
        public void ForkPrfHash(){} // RVA: 0x7FFAC2C58E90
        public void GetFinalHash(){}
    }

    public class TlsKeyExchange
    {
        public object RequiresServerKeyExchange;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void SkipServerCredentials(){} // RVA: 0x7FFAC2C70980
        public void ProcessServerCredentials(){} // RVA: 0x7FFAC2C70A40
        public void ProcessServerCertificate(){} // RVA: 0x7FFAC2C70A40
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFAC2C59D00
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFAC2C58E90
        public void SkipServerKeyExchange(){} // RVA: 0x7FFAC2C70980
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFAC2C70A40
        public void ValidateCertificateRequest(){} // RVA: 0x7FFAC2C70A40
        public void SkipClientCredentials(){} // RVA: 0x7FFAC2C70980
        public void ProcessClientCredentials(){} // RVA: 0x7FFAC2C70A40
        public void ProcessClientCertificate(){} // RVA: 0x7FFAC2C70A40
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFAC2C70A40
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFAC2C70A40
        public void GeneratePremasterSecret(){} // RVA: 0x7FFAC2C58E90
    }

    public class TlsMac : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext MacSecret; // 0x10
        public byte[] Size; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac mac; // 0x20
        public int digestBlockSize; // 0x28
        public int digestOverhead; // 0x2C
        public int macLength; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB51E60
        public void get_MacSecret(){} // RVA: 0x7FFAC2F247C0
        public void get_Size(){} // RVA: 0x7FFAC2F7CCD0
        public void CalculateMac(){} // RVA: 0x7FFACBB52390
        public void CalculateMacConstantTime(){} // RVA: 0x7FFACBB526A0
        public void GetDigestBlockCount(){} // RVA: 0x7FFACBB528D0
        public void Truncate(){} // RVA: 0x7FFACBB528E0
    }

    public class TlsNoCloseNotifyException : EndOfStreamException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB52960
    }

    public class TlsNullCipher : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext context; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsMac writeMac; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsMac readMac; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB52AB0 | overloaded x2
        public void GetPlaintextLimit(){} // RVA: 0x7FFACBB52EE0
        public void EncodePlaintext(){} // RVA: 0x7FFACBB52F10
        public void DecodeCiphertext(){} // RVA: 0x7FFACBB53070
    }

    public class TlsNullCompression : Object
    {
        // ── Methods ──
        public void Compress(){} // RVA: 0x7FFAC3E92FB0
        public void Decompress(){} // RVA: 0x7FFAC3E92FB0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TlsPeer
    {
        // ── Methods ──
        public void RequiresExtendedMasterSecret(){} // RVA: 0x7FFAC2C59D00
        public void ShouldUseGmtUnixTime(){} // RVA: 0x7FFAC2C59D00
        public void NotifySecureRenegotiation(){} // RVA: 0x7FFAC2C71060
        public void GetCompression(){} // RVA: 0x7FFAC2C58E90
        public void GetCipher(){} // RVA: 0x7FFAC2C58E90
        public void NotifyAlertRaised(){}
        public void NotifyAlertReceived(){} // RVA: 0x7FFAC2C710F0
        public void NotifyHandshakeComplete(){} // RVA: 0x7FFAC2C70980
    }

    public class TlsProtocol : Object
    {
        public short Context;
        public short ContextAdmin;
        public short Peer;
        public short Stream;
        public short IsClosed;
        public short CS_CERTIFICATE_STATUS;
        public short CS_SERVER_KEY_EXCHANGE;
        public short CS_CERTIFICATE_REQUEST;
        public short CS_SERVER_HELLO_DONE;
        public short CS_CLIENT_SUPPLEMENTAL_DATA;
        public short CS_CLIENT_CERTIFICATE;
        public short CS_CLIENT_KEY_EXCHANGE;
        public short CS_CERTIFICATE_VERIFY;
        public short CS_CLIENT_FINISHED;
        public short CS_SERVER_SESSION_TICKET;
        public short CS_SERVER_FINISHED;
        public short CS_END;
        public short ADS_MODE_1_Nsub1;
        public short ADS_MODE_0_N;
        public short ADS_MODE_0_N_FIRSTONLY;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ByteQueue mApplicationDataQueue; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ByteQueue mAlertQueue; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ByteQueue mHandshakeQueue; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.RecordStream mRecordStream; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom mSecureRandom; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsStream mTlsStream; // 0x38
        public bool mClosed; // 0x40
        public bool mFailedWithError; // 0x41
        public bool mAppDataReady; // 0x42
        public bool mAppDataSplitEnabled; // 0x43
        public int mAppDataSplitMode; // 0x44
        public byte[] mExpectedVerifyData; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSession mTlsSession; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.SessionParameters mSessionParameters; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.SecurityParameters mSecurityParameters; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate mPeerCertificate; // 0x68
        public int[] mOfferedCipherSuites; // 0x70
        public byte[] mOfferedCompressionMethods; // 0x78
        public System.Collections.IDictionary mClientExtensions; // 0x80
        public System.Collections.IDictionary mServerExtensions; // 0x88
        public short mConnectionState; // 0x90
        public bool mResumedSession; // 0x92
        public bool mReceivedChangeCipherSpec; // 0x93
        public bool mSecureRenegotiation; // 0x94
        public bool mAllowCertificateStatus; // 0x95
        public bool mExpectSessionTicket; // 0x96
        public bool mBlocking; // 0x97
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ByteQueueStream mInputBuffers; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ByteQueueStream mOutputBuffer; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB53750 | overloaded x3
        public void get_Context(){} // RVA: 0x7FFAC2C58E90
        public void get_ContextAdmin(){} // RVA: 0x7FFAC2C58E90
        public void get_Peer(){} // RVA: 0x7FFAC2C58E90
        public void HandleAlertMessage(){} // RVA: 0x7FFACBB53CD0
        public void HandleAlertWarningMessage(){} // RVA: 0x7FFACBB53DC0
        public void HandleChangeCipherSpecMessage(){} // RVA: 0x7FFAC2F21310
        public void HandleClose(){} // RVA: 0x7FFACBB53E40
        public void HandleException(){} // RVA: 0x7FFACBB53F30
        public void HandleFailure(){} // RVA: 0x7FFACBB53F90
        public void HandleHandshakeMessage(){} // RVA: 0x7FFAC2C71580
        public void ApplyMaxFragmentLengthExtension(){} // RVA: 0x7FFACBB54010
        public void CheckReceivedChangeCipherSpec(){} // RVA: 0x7FFACBB540C0
        public void CleanupHandshake(){} // RVA: 0x7FFACBB54120
        public void BlockForHandshake(){} // RVA: 0x7FFACBB54430
        public void CompleteHandshake(){} // RVA: 0x7FFACBB544C0
        public void ProcessRecord(){} // RVA: 0x7FFACBB54BB0
        public void ProcessHandshakeQueue(){} // RVA: 0x7FFACBB55060
        public void ProcessApplicationDataQueue(){} // RVA: 0x7FFAC2F21310
        public void ProcessAlertQueue(){} // RVA: 0x7FFACBB552E0
        public void ProcessChangeCipherSpec(){} // RVA: 0x7FFACBB553E0
        public void ApplicationDataAvailable(){} // RVA: 0x7FFAC44F4DD0
        public void ReadApplicationData(){} // RVA: 0x7FFACBB55580
        public void SafeCheckRecordHeader(){} // RVA: 0x7FFACBB55750
        public void SafeReadRecord(){} // RVA: 0x7FFACBB558B0
        public void SafeWriteRecord(){} // RVA: 0x7FFACBB55AD0
        public void WriteData(){} // RVA: 0x7FFACBB55C40
        public void SetAppDataSplitMode(){} // RVA: 0x7FFACBB55E40
        public void WriteHandshakeMessage(){} // RVA: 0x7FFACBB55EF0
        public void get_Stream(){} // RVA: 0x7FFACBB560A0
        public void CloseInput(){} // RVA: 0x7FFACBB56110
        public void OfferInput(){} // RVA: 0x7FFACBB56270 | overloaded x2
        public void GetAvailableInputBytes(){} // RVA: 0x7FFACBB56530
        public void ReadInput(){} // RVA: 0x7FFACBB565B0
        public void OfferOutput(){} // RVA: 0x7FFACBB566C0
        public void GetAvailableOutputBytes(){} // RVA: 0x7FFACBB56790
        public void ReadOutput(){} // RVA: 0x7FFACBB56820
        public void InvalidateSession(){} // RVA: 0x7FFACBB568B0
        public void ProcessFinishedMessage(){} // RVA: 0x7FFACBB569D0
        public void RaiseAlertFatal(){} // RVA: 0x7FFACBB56BE0
        public void RaiseAlertWarning(){} // RVA: 0x7FFACBB56CF0
        public void SendCertificateMessage(){} // RVA: 0x7FFACBB56DF0
        public void SendChangeCipherSpecMessage(){} // RVA: 0x7FFACBB56FF0
        public void SendFinishedMessage(){} // RVA: 0x7FFACBB57220
        public void SendSupplementalDataMessage(){} // RVA: 0x7FFACBB57330
        public void CreateVerifyData(){} // RVA: 0x7FFACBB573C0
        public void Close(){} // RVA: 0x7FFAC85F19B0
        public void Flush(){} // RVA: 0x7FFACBB574F0
        public void get_IsClosed(){} // RVA: 0x7FFAC8A4DE00
        public void ProcessMaxFragmentLengthExtension(){} // RVA: 0x7FFACBB57530
        public void RefuseRenegotiation(){} // RVA: 0x7FFACBB575E0
        public void AssertEmpty(){} // RVA: 0x7FFACBB576D0
        public void CreateRandomBlock(){} // RVA: 0x7FFACBB57770
        public void CreateRenegotiationInfo(){} // RVA: 0x7FFACBB578D0
        public void EstablishMasterSecret(){} // RVA: 0x7FFACBB579A0
        public void GetCurrentPrfHash(){} // RVA: 0x7FFACBB57B80
        public void ReadExtensions(){} // RVA: 0x7FFACBB57D10
        public void ReadSupplementalDataMessage(){} // RVA: 0x7FFACBB58090
        public void WriteExtensions(){} // RVA: 0x7FFACBB58470
        public void WriteSelectedExtensions(){} // RVA: 0x7FFACBB58550
        public void WriteSupplementalData(){} // RVA: 0x7FFACBB58930
        public void GetPrfAlgorithm(){} // RVA: 0x7FFACBB58D30
    }

    public class TlsProtocolHandler : TlsClientProtocol
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB42C10 | overloaded x2
    }

    public class TlsPskIdentity
    {
        // ── Methods ──
        public void SkipIdentityHint(){} // RVA: 0x7FFAC2C70980
        public void NotifyIdentityHint(){} // RVA: 0x7FFAC2C70A40
        public void GetPskIdentity(){} // RVA: 0x7FFAC2C58E90
        public void GetPsk(){} // RVA: 0x7FFAC2C58E90
    }

    public class TlsPskIdentityManager
    {
        // ── Methods ──
        public void GetHint(){} // RVA: 0x7FFAC2C58E90
        public void GetPsk(){} // RVA: 0x7FFAC2C58F40
    }

    public class TlsPskKeyExchange : AbstractTlsKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsPskIdentity RequiresServerKeyExchange; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager mPskIdentityManager; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsDHVerifier mDHVerifier; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters mDHParameters; // 0x40
        public int[] mNamedCurves; // 0x48
        public byte[] mClientECPointFormats; // 0x50
        public byte[] mServerECPointFormats; // 0x58
        public byte[] mPskIdentityHint; // 0x60
        public byte[] mPsk; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters mDHAgreePrivateKey; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters mDHAgreePublicKey; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mECAgreePrivateKey; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters mECAgreePublicKey; // 0x88
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters mRsaServerPublicKey; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials mServerCredentials; // 0xA0
        public byte[] mPremasterSecret; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB593F0 | overloaded x2
        public void SkipServerCredentials(){} // RVA: 0x7FFACBB59750
        public void ProcessServerCredentials(){} // RVA: 0x7FFACBB597B0
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFACBB59930
        public void ProcessServerCertificate(){} // RVA: 0x7FFACBB59CB0
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFACBB59F80
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFACBB59FA0
        public void ValidateCertificateRequest(){} // RVA: 0x7FFACBB5A260
        public void ProcessClientCredentials(){} // RVA: 0x7FFACBB5A2B0
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFACBB5A300
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFACBB5A6A0
        public void GeneratePremasterSecret(){} // RVA: 0x7FFACBB5AA50
        public void GenerateOtherSecret(){} // RVA: 0x7FFACBB5AC20
        public void ValidateRsaPublicKey(){} // RVA: 0x7FFACBB5ADB0
    }

    public class TlsRsaKeyExchange : AbstractTlsKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters mRsaServerPublicKey; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials mServerCredentials; // 0x38
        public byte[] mPremasterSecret; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91A2010
        public void SkipServerCredentials(){} // RVA: 0x7FFACBB5AE30
        public void ProcessServerCredentials(){} // RVA: 0x7FFACBB5AE80
        public void ProcessServerCertificate(){} // RVA: 0x7FFACBB5B000
        public void ValidateCertificateRequest(){} // RVA: 0x7FFACBB5B2D0
        public void ProcessClientCredentials(){} // RVA: 0x7FFACBB5B390
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFACBB5B410
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFACBB5B480
        public void GeneratePremasterSecret(){} // RVA: 0x7FFACBB5B5A0
        public void ValidateRsaPublicKey(){} // RVA: 0x7FFACBB5B650
    }

    public class TlsRsaSigner : AbstractTlsSigner
    {
        // ── Methods ──
        public void GenerateRawSignature(){} // RVA: 0x7FFACBB5B6D0
        public void VerifyRawSignature(){} // RVA: 0x7FFACBB5B800
        public void CreateSigner(){} // RVA: 0x7FFACBB5B8E0
        public void CreateVerifyer(){} // RVA: 0x7FFACBB5B9C0
        public void IsValidPublicKey(){} // RVA: 0x7FFACBB5B9F0
        public void MakeSigner(){} // RVA: 0x7FFACBB5BA60
        public void CreateRsaImpl(){} // RVA: 0x7FFACBB5BFB0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TlsRsaUtilities : Object
    {
        // ── Methods ──
        public void GenerateEncryptedPreMasterSecret(){} // RVA: 0x7FFACBB5C030
        public void SafeDecryptPreMasterSecret(){} // RVA: 0x7FFACBB5C330
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TlsSRTPUtils : Object
    {
        // ── Methods ──
        public void AddUseSrtpExtension(){} // RVA: 0x7FFACBB62630
        public void GetUseSrtpExtension(){} // RVA: 0x7FFACBB626E0
        public void CreateUseSrtpExtension(){} // RVA: 0x7FFACBB62750
        public void ReadUseSrtpExtension(){} // RVA: 0x7FFACBB62910
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TlsServer
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void NotifyClientVersion(){} // RVA: 0x7FFAC2C70A40
        public void NotifyFallback(){} // RVA: 0x7FFAC2C71060
        public void NotifyOfferedCipherSuites(){} // RVA: 0x7FFAC2C70A40
        public void NotifyOfferedCompressionMethods(){} // RVA: 0x7FFAC2C70A40
        public void ProcessClientExtensions(){} // RVA: 0x7FFAC2C70A40
        public void GetServerVersion(){} // RVA: 0x7FFAC2C58E90
        public void GetSelectedCipherSuite(){} // RVA: 0x7FFAC2C59960
        public void GetSelectedCompressionMethod(){} // RVA: 0x7FFAC2C59D00
        public void GetServerExtensions(){} // RVA: 0x7FFAC2C58E90
        public void GetServerSupplementalData(){} // RVA: 0x7FFAC2C58E90
        public void GetCredentials(){} // RVA: 0x7FFAC2C58E90
        public void GetCertificateStatus(){} // RVA: 0x7FFAC2C58E90
        public void GetKeyExchange(){} // RVA: 0x7FFAC2C58E90
        public void GetCertificateRequest(){} // RVA: 0x7FFAC2C58E90
        public void ProcessClientSupplementalData(){} // RVA: 0x7FFAC2C70A40
        public void NotifyClientCertificate(){} // RVA: 0x7FFAC2C70A40
        public void GetNewSessionTicket(){} // RVA: 0x7FFAC2C58E90
    }

    public class TlsServerContext
    {
    }

    public class TlsServerContextImpl : AbstractTlsContext
    {
        public object IsServer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB5C740
        public void get_IsServer(){} // RVA: 0x7FFAC3006850
    }

    public class TlsServerProtocol : TlsProtocol
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsServer Context; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsServerContextImpl ContextAdmin; // 0xB0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsKeyExchange Peer; // 0xB8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCredentials mServerCredentials; // 0xC0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.CertificateRequest mCertificateRequest; // 0xC8
        public short mClientCertificateType; // 0xD0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash mPrepareFinishHash; // 0xD8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB5C800 | overloaded x3
        public void Accept(){} // RVA: 0x7FFACBB5C820
        public void CleanupHandshake(){} // RVA: 0x7FFACBB5CBD0
        public void get_Context(){} // RVA: 0x7FFAC2F8C040
        public void get_ContextAdmin(){} // RVA: 0x7FFAC2F8C040
        public void get_Peer(){} // RVA: 0x7FFAC354B1A0
        public void HandleHandshakeMessage(){} // RVA: 0x7FFACBB5CD60
        public void HandleAlertWarningMessage(){} // RVA: 0x7FFACBB5D940
        public void NotifyClientCertificate(){} // RVA: 0x7FFACBB5DB40
        public void ReceiveCertificateMessage(){} // RVA: 0x7FFACBB5DD70
        public void ReceiveCertificateVerifyMessage(){} // RVA: 0x7FFACBB5DE80
        public void ReceiveClientHelloMessage(){} // RVA: 0x7FFACBB5E2D0
        public void ReceiveClientKeyExchangeMessage(){} // RVA: 0x7FFACBB5E980
        public void SendCertificateRequestMessage(){} // RVA: 0x7FFACBB5ECE0
        public void SendCertificateStatusMessage(){} // RVA: 0x7FFACBB5ED80
        public void SendNewSessionTicketMessage(){} // RVA: 0x7FFACBB5EE20
        public void SendServerHelloMessage(){} // RVA: 0x7FFACBB5EF00
        public void SendServerHelloDoneMessage(){} // RVA: 0x7FFACBB5F910
        public void SendServerKeyExchangeMessage(){} // RVA: 0x7FFACBB5F9F0
        public void ExpectCertificateVerifyMessage(){} // RVA: 0x7FFACBB5FAA0
    }

    public class TlsSession
    {
        public object SessionID;
        public object IsResumable;

        // ── Methods ──
        public void ExportSessionParameters(){} // RVA: 0x7FFAC2C58E90
        public void get_SessionID(){} // RVA: 0x7FFAC2C58E90
        public void Invalidate(){} // RVA: 0x7FFAC2C70980
        public void get_IsResumable(){} // RVA: 0x7FFAC2C59D00
    }

    public class TlsSessionImpl : Object
    {
        public byte[] SessionID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.SessionParameters IsResumable; // 0x18
        public bool mResumable; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB5FB10
        public void ExportSessionParameters(){} // RVA: 0x7FFACBB5FD60
        public void get_SessionID(){} // RVA: 0x7FFACBB5FF80
        public void Invalidate(){} // RVA: 0x7FFACBB600C0
        public void get_IsResumable(){} // RVA: 0x7FFACBB601E0
    }

    public class TlsSigner
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void GenerateRawSignature(){} // RVA: 0x7FFAC2C6AE80 | overloaded x2
        public void VerifyRawSignature(){} // RVA: 0x7FFAC2C5D680 | overloaded x2
        public void CreateSigner(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void CreateVerifyer(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void IsValidPublicKey(){} // RVA: 0x7FFAC2C59F60
    }

    public class TlsSignerCredentials
    {
        public object SignatureAndHashAlgorithm;

        // ── Methods ──
        public void GenerateCertificateSignature(){} // RVA: 0x7FFAC2C58F40
        public void get_SignatureAndHashAlgorithm(){} // RVA: 0x7FFAC2C58E90
    }

    public class TlsSrpGroupVerifier
    {
        // ── Methods ──
        public void Accept(){} // RVA: 0x7FFAC2C59F60
    }

    public class TlsSrpIdentityManager
    {
        // ── Methods ──
        public void GetLoginParameters(){} // RVA: 0x7FFAC2C58F40
    }

    public class TlsSrpKeyExchange : AbstractTlsKeyExchange
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSigner RequiresServerKeyExchange; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSrpGroupVerifier mGroupVerifier; // 0x30
        public byte[] mIdentity; // 0x38
        public byte[] mPassword; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters mSrpGroup; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Client mSrpClient; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Server mSrpServer; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger mSrpPeerCredentials; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger mSrpVerifier; // 0x70
        public byte[] mSrpSalt; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials mServerCredentials; // 0x80

        // ── Methods ──
        public void CreateSigner(){} // RVA: 0x7FFACBB60320
        public void .ctor(){} // RVA: 0x7FFACBB606F0 | overloaded x3
        public void Init(){} // RVA: 0x7FFACBB60A00
        public void SkipServerCredentials(){} // RVA: 0x7FFACBB60A70
        public void ProcessServerCertificate(){} // RVA: 0x7FFACBB60AD0
        public void ProcessServerCredentials(){} // RVA: 0x7FFACBB60D20
        public void get_RequiresServerKeyExchange(){} // RVA: 0x7FFAC3006850
        public void GenerateServerKeyExchange(){} // RVA: 0x7FFACBB60EB0
        public void ProcessServerKeyExchange(){} // RVA: 0x7FFACBB612E0
        public void ValidateCertificateRequest(){} // RVA: 0x7FFACBB618F0
        public void ProcessClientCredentials(){} // RVA: 0x7FFACBB61940
        public void GenerateClientKeyExchange(){} // RVA: 0x7FFACBB61990
        public void ProcessClientKeyExchange(){} // RVA: 0x7FFACBB61B70
        public void GeneratePremasterSecret(){} // RVA: 0x7FFACBB61DA0
        public void InitVerifyer(){} // RVA: 0x7FFACBB61E80
    }

    public class TlsSrpLoginParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters Group; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Salt; // 0x18
        public byte[] Verifier; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00
        public void get_Group(){} // RVA: 0x7FFAC2F3C380
        public void get_Salt(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Verifier(){} // RVA: 0x7FFAC2F247C0
    }

    public class TlsSrpUtilities : Object
    {
        // ── Methods ──
        public void AddSrpExtension(){} // RVA: 0x7FFACBB61F80
        public void GetSrpExtension(){} // RVA: 0x7FFACBB62110
        public void CreateSrpExtension(){} // RVA: 0x7FFACBB62280
        public void ReadSrpExtension(){} // RVA: 0x7FFACBB62380
        public void ReadSrpParameter(){} // RVA: 0x7FFACBB624F0
        public void WriteSrpParameter(){} // RVA: 0x7FFACBB625A0
        public void IsSrpCipherSuite(){} // RVA: 0x7FFACBB62620
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TlsStream : Stream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsProtocol CanRead; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB62C80
        public void get_CanRead(){} // RVA: 0x7FFACBB62D20
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFACBB62D20
        public void Close(){} // RVA: 0x7FFACBB62D50
        public void Flush(){} // RVA: 0x7FFACBB62D90
        public void get_Length(){} // RVA: 0x7FFACBB62DC0
        public void get_Position(){} // RVA: 0x7FFACBB62E00
        public void set_Position(){} // RVA: 0x7FFACBB62E40
        public void Read(){} // RVA: 0x7FFACBB62E80
        public void ReadByte(){} // RVA: 0x7FFACBB62EB0
        public void Seek(){} // RVA: 0x7FFACBB62F60
        public void SetLength(){} // RVA: 0x7FFACBB62FA0
        public void Write(){} // RVA: 0x7FFACBB62FE0
        public void WriteByte(){} // RVA: 0x7FFACBB63010
    }

    public class TlsStreamCipher : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsContext context; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IStreamCipher encryptCipher; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IStreamCipher decryptCipher; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsMac writeMac; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsMac readMac; // 0x30
        public bool usesNonce; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB630B0
        public void GetPlaintextLimit(){} // RVA: 0x7FFACBB63850
        public void EncodePlaintext(){} // RVA: 0x7FFACBB63890
        public void DecodeCiphertext(){} // RVA: 0x7FFACBB63A10
        public void CheckMac(){} // RVA: 0x7FFACBB63BF0
        public void UpdateIV(){} // RVA: 0x7FFACBB63D60
    }

    public class TlsUtilities : Object
    {
        public byte[] EmptyBytes;
        public short[] EmptyShorts; // 0x8
        public int[] EmptyInts; // 0x10
        public long[] EmptyLongs; // 0x18
        public byte[] SSL_CLIENT; // 0x20
        public byte[] SSL_SERVER; // 0x28
        public byte[][] SSL3_CONST; // 0x30

        // ── Methods ──
        public void CheckUint8(){} // RVA: 0x7FFACBB63F10 | overloaded x2
        public void CheckUint16(){} // RVA: 0x7FFACBB64030 | overloaded x2
        public void CheckUint24(){} // RVA: 0x7FFACBB64150 | overloaded x2
        public void CheckUint32(){} // RVA: 0x7FFACBB641E0
        public void CheckUint48(){} // RVA: 0x7FFACBB64270
        public void CheckUint64(){} // RVA: 0x7FFACBB64310
        public void IsValidUint8(){} // RVA: 0x7FFACBB64360 | overloaded x2
        public void IsValidUint16(){} // RVA: 0x7FFACBB64380 | overloaded x2
        public void IsValidUint24(){} // RVA: 0x7FFACBB643A0 | overloaded x2
        public void IsValidUint32(){} // RVA: 0x7FFACBB643B0
        public void IsValidUint48(){} // RVA: 0x7FFACBB643C0
        public void IsValidUint64(){} // RVA: 0x7FFAC3006850
        public void IsSsl(){} // RVA: 0x7FFACBB643E0
        public void IsTlsV11(){} // RVA: 0x7FFACBB64570 | overloaded x2
        public void IsTlsV12(){} // RVA: 0x7FFACBB64790 | overloaded x2
        public void WriteUint8(){} // RVA: 0x7FFACBB64900 | overloaded x2
        public void WriteUint16(){} // RVA: 0x7FFACBB64990 | overloaded x2
        public void WriteUint24(){} // RVA: 0x7FFACBB64A50 | overloaded x2
        public void WriteUint32(){} // RVA: 0x7FFACBB64B40 | overloaded x2
        public void WriteUint48(){} // RVA: 0x7FFACBB64C90 | overloaded x2
        public void WriteUint64(){} // RVA: 0x7FFACBB64E50 | overloaded x2
        public void WriteOpaque8(){} // RVA: 0x7FFACBB64F40
        public void WriteOpaque16(){} // RVA: 0x7FFACBB64FF0
        public void WriteOpaque24(){} // RVA: 0x7FFACBB650C0
        public void WriteUint8Array(){} // RVA: 0x7FFACBB65200 | overloaded x2
        public void WriteUint8ArrayWithUint8Length(){} // RVA: 0x7FFACBB65370 | overloaded x2
        public void WriteUint16Array(){} // RVA: 0x7FFACBB65560 | overloaded x2
        public void WriteUint16ArrayWithUint16Length(){} // RVA: 0x7FFACBB65780 | overloaded x2
        public void DecodeUint8(){} // RVA: 0x7FFACBB658C0
        public void DecodeUint8ArrayWithUint8Length(){} // RVA: 0x7FFACBB659B0
        public void EncodeOpaque8(){} // RVA: 0x7FFACBB65B40
        public void EncodeUint8(){} // RVA: 0x7FFACBB65BD0
        public void EncodeUint8ArrayWithUint8Length(){} // RVA: 0x7FFACBB65C60
        public void EncodeUint16ArrayWithUint16Length(){} // RVA: 0x7FFACBB65DC0
        public void ReadUint8(){} // RVA: 0x7FFACBB65FD0 | overloaded x2
        public void ReadUint16(){} // RVA: 0x7FFACBB660A0 | overloaded x2
        public void ReadUint24(){} // RVA: 0x7FFACBB661A0 | overloaded x2
        public void ReadUint32(){} // RVA: 0x7FFACBB662F0 | overloaded x2
        public void ReadUint48(){} // RVA: 0x7FFACBB663E0 | overloaded x2
        public void ReadAllOrNothing(){} // RVA: 0x7FFACBB664D0
        public void ReadFully(){} // RVA: 0x7FFACBB667A0 | overloaded x2
        public void ReadOpaque8(){} // RVA: 0x7FFACBB66870
        public void ReadOpaque16(){} // RVA: 0x7FFACBB66960
        public void ReadOpaque24(){} // RVA: 0x7FFACBB66A70
        public void ReadUint8Array(){} // RVA: 0x7FFACBB66AD0
        public void ReadUint16Array(){} // RVA: 0x7FFACBB66BF0
        public void ReadVersion(){} // RVA: 0x7FFACBB66DC0 | overloaded x2
        public void ReadVersionRaw(){} // RVA: 0x7FFACBB66EA0 | overloaded x2
        public void ReadAsn1Object(){} // RVA: 0x7FFACBB66F40
        public void ReadDerObject(){} // RVA: 0x7FFACBB670C0
        public void WriteGmtUnixTime(){} // RVA: 0x7FFACBB67250
        public void WriteVersion(){} // RVA: 0x7FFACBB67390 | overloaded x2
        public void GetAllSignatureAlgorithms(){} // RVA: 0x7FFACBB673E0
        public void GetDefaultDssSignatureAlgorithms(){} // RVA: 0x7FFACBB67690
        public void GetDefaultECDsaSignatureAlgorithms(){} // RVA: 0x7FFACBB67750
        public void GetDefaultRsaSignatureAlgorithms(){} // RVA: 0x7FFACBB67810
        public void GetExtensionData(){} // RVA: 0x7FFACBB678D0
        public void GetDefaultSupportedSignatureAlgorithms(){} // RVA: 0x7FFACBB67990
        public void GetSignatureAndHashAlgorithm(){} // RVA: 0x7FFACBB67B90
        public void HasExpectedEmptyExtensionData(){} // RVA: 0x7FFACBB67CD0
        public void ImportSession(){} // RVA: 0x7FFACBB67DA0
        public void IsSignatureAlgorithmsExtensionAllowed(){} // RVA: 0x7FFACBB67E10
        public void AddSignatureAlgorithmsExtension(){} // RVA: 0x7FFACBB67EF0
        public void GetSignatureAlgorithmsExtension(){} // RVA: 0x7FFACBB68050
        public void CreateSignatureAlgorithmsExtension(){} // RVA: 0x7FFACBB681E0
        public void ReadSignatureAlgorithmsExtension(){} // RVA: 0x7FFACBB68290
        public void EncodeSupportedSignatureAlgorithms(){} // RVA: 0x7FFACBB68400
        public void ParseSupportedSignatureAlgorithms(){} // RVA: 0x7FFACBB68800
        public void VerifySupportedSignatureAlgorithm(){} // RVA: 0x7FFACBB68A30
        public void PRF(){} // RVA: 0x7FFACBB68DC0
        public void PRF_legacy(){} // RVA: 0x7FFACBB691E0 | overloaded x2
        public void Concat(){} // RVA: 0x7FFACBB69380
        public void HMacHash(){} // RVA: 0x7FFACBB69430
        public void ValidateKeyUsage(){} // RVA: 0x7FFACBB69700
        public void CalculateKeyBlock(){} // RVA: 0x7FFACBB69820
        public void CalculateKeyBlock_Ssl(){} // RVA: 0x7FFACBB69A20
        public void CalculateMasterSecret(){} // RVA: 0x7FFACBB6A040
        public void CalculateMasterSecret_Ssl(){} // RVA: 0x7FFACBB6A2D0
        public void CalculateVerifyData(){} // RVA: 0x7FFACBB6A890
        public void CreateHash(){} // RVA: 0x7FFACBB6ABC0 | overloaded x2
        public void CloneHash(){} // RVA: 0x7FFACBB6AC60
        public void CreatePrfHash(){} // RVA: 0x7FFACBB6B090
        public void ClonePrfHash(){} // RVA: 0x7FFACBB6B120
        public void GetHashAlgorithmForPrfAlgorithm(){} // RVA: 0x7FFACBB6B200
        public void GetOidForHashAlgorithm(){} // RVA: 0x7FFACBB6B2F0
        public void GetClientCertificateType(){} // RVA: 0x7FFACBB6B500
        public void TrackHashAlgorithms(){} // RVA: 0x7FFACBB6B7D0
        public void HasSigningCapability(){} // RVA: 0x7FFACBB6BA60
        public void CreateTlsSigner(){} // RVA: 0x7FFACBB6BA80
        public void GenSsl3Const(){} // RVA: 0x7FFACBB6BB80
        public void VectorOfOne(){} // RVA: 0x7FFACBB6BCF0
        public void GetCipherType(){} // RVA: 0x7FFACBB6BE40
        public void GetEncryptionAlgorithm(){} // RVA: 0x7FFACBB6BF40
        public void GetKeyExchangeAlgorithm(){} // RVA: 0x7FFACBB6C2F0
        public void GetMacAlgorithm(){} // RVA: 0x7FFACBB6C6F0
        public void GetMinimumVersion(){} // RVA: 0x7FFACBB6C990
        public void IsAeadCipherSuite(){} // RVA: 0x7FFACBB6CAA0
        public void IsBlockCipherSuite(){} // RVA: 0x7FFACBB6CB00
        public void IsStreamCipherSuite(){} // RVA: 0x7FFACBB6CB60
        public void IsValidCipherSuiteForSignatureAlgorithms(){} // RVA: 0x7FFACBB6CBC0
        public void IsValidCipherSuiteForVersion(){} // RVA: 0x7FFACBB6CDA0
        public void GetUsableSignatureAlgorithms(){} // RVA: 0x7FFACBB6CF90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB6D4F0
    }

}