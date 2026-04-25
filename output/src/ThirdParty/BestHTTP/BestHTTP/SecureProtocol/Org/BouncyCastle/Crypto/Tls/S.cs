// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 16
// Methods: 96

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class SecurityParameters : Object
    {
        public int Entity; // 0x10
        public int CipherSuite; // 0x14
        public byte CompressionAlgorithm; // 0x18
        public int PrfAlgorithm; // 0x1C
        public int VerifyDataLength; // 0x20
        public byte[] MasterSecret; // 0x28
        public byte[] ClientRandom; // 0x30
        public byte[] ServerRandom; // 0x38
        public byte[] SessionHash; // 0x40
        public byte[] PskIdentity; // 0x48
        public byte[] SrpIdentity; // 0x50
        public short IsExtendedMasterSecret; // 0x58
        public bool truncatedHMac; // 0x5A
        public bool encryptThenMac; // 0x5B
        public bool extendedMasterSecret; // 0x5C

        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFACBB3BE60
        public void get_Entity(){} // RVA: 0x7FFAC2F6E5C0
        public void get_CipherSuite(){} // RVA: 0x7FFAC33D5A20
        public void get_CompressionAlgorithm(){} // RVA: 0x7FFAC2F3C4E0
        public void get_PrfAlgorithm(){} // RVA: 0x7FFAC44357F0
        public void get_VerifyDataLength(){} // RVA: 0x7FFAC30DBBE0
        public void get_MasterSecret(){} // RVA: 0x7FFAC2F4F130
        public void get_ClientRandom(){} // RVA: 0x7FFAC31D95E0
        public void get_ServerRandom(){} // RVA: 0x7FFAC31D0140
        public void get_SessionHash(){} // RVA: 0x7FFAC2F9E740
        public void get_PskIdentity(){} // RVA: 0x7FFAC2F9C730
        public void get_SrpIdentity(){} // RVA: 0x7FFAC2FC20E0
        public void get_IsExtendedMasterSecret(){} // RVA: 0x7FFAC2FBF240
        public void .ctor(){} // RVA: 0x7FFACBB3BF40
    }

    public class ServerName : Object
    {
        public byte NameType; // 0x10
        public object Name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB3BF60
        public void get_NameType(){} // RVA: 0x7FFAC2FEB5E0
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void GetHostName(){} // RVA: 0x7FFACBB3C040
        public void Encode(){} // RVA: 0x7FFACBB3C130
        public void Parse(){} // RVA: 0x7FFACBB3C2D0
        public void IsCorrectType(){} // RVA: 0x7FFACBB3C4A0
    }

    public class ServerNameList : Object
    {
        public System.Collections.IList ServerNames; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB3C560
        public void get_ServerNames(){} // RVA: 0x7FFAC2F3C380
        public void Encode(){} // RVA: 0x7FFACBB3C610
        public void Parse(){} // RVA: 0x7FFACBB3C9C0
        public void CheckNameType(){} // RVA: 0x7FFACBB3CD70
    }

    public class ServerOnlyTlsAuthentication : Object
    {
        // ── Methods ──
        public void NotifyServerCertificate(){} // RVA: 0x7FFAC2C70A40
        public void GetClientCredentials(){} // RVA: 0x7FFAC34F9180
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ServerSrpParams : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger B; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger G; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger N; // 0x20
        public byte[] S; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB3CE30
        public void get_B(){} // RVA: 0x7FFAC2F4F0C0
        public void get_G(){} // RVA: 0x7FFAC2F247C0
        public void get_N(){} // RVA: 0x7FFAC2F3C380
        public void get_S(){} // RVA: 0x7FFAC2F4F130
        public void Encode(){} // RVA: 0x7FFACBB3D050
        public void Parse(){} // RVA: 0x7FFACBB3D260
    }

    public class SessionParameters : Object
    {
        public int CipherSuite; // 0x10
        public byte CompressionAlgorithm; // 0x14
        public byte[] IsExtendedMasterSecret; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate MasterSecret; // 0x20
        public byte[] PeerCertificate; // 0x28
        public byte[] PskIdentity; // 0x30
        public byte[] SrpIdentity; // 0x38
        public bool mExtendedMasterSecret; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB3D350
        public void Clear(){} // RVA: 0x7FFACBB3D690
        public void Copy(){} // RVA: 0x7FFACBB3D710
        public void get_CipherSuite(){} // RVA: 0x7FFAC2F6E5C0
        public void get_CompressionAlgorithm(){} // RVA: 0x7FFAC3070BD0
        public void get_IsExtendedMasterSecret(){} // RVA: 0x7FFAC2FDCC00
        public void get_MasterSecret(){} // RVA: 0x7FFAC2F247C0
        public void get_PeerCertificate(){} // RVA: 0x7FFAC2F4F0C0
        public void get_PskIdentity(){} // RVA: 0x7FFAC2F4F130
        public void get_SrpIdentity(){} // RVA: 0x7FFAC31D95E0
        public void ReadServerExtensions(){} // RVA: 0x7FFACBB3D7E0
    }

    public class SignatureAlgorithm : Object
    {
        public byte anonymous;
        public byte rsa;
        public byte dsa;
        public byte ecdsa;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SignatureAndHashAlgorithm : Object
    {
        public byte Hash; // 0x10
        public byte Signature; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB3DC70
        public void get_Hash(){} // RVA: 0x7FFAC2FEB5E0
        public void get_Signature(){} // RVA: 0x7FFAC3771DA0
        public void Equals(){} // RVA: 0x7FFACBB3DD50
        public void GetHashCode(){} // RVA: 0x7FFACBB3DE90
        public void Encode(){} // RVA: 0x7FFACBB3DEE0
        public void Parse(){} // RVA: 0x7FFACBB3DFB0
    }

    public class SignerInputBuffer : MemoryStream
    {
        // ── Methods ──
        public void UpdateSigner(){} // RVA: 0x7FFACBB3E100
        public void .ctor(){} // RVA: 0x7FFACBB2A930
    }

    public class SimulatedTlsSrpIdentityManager : Object
    {
        public byte[] PREFIX_PASSWORD;
        public byte[] PREFIX_SALT; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters mGroup; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp.Srp6VerifierGenerator mVerifierGenerator; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac mMac; // 0x20

        // ── Methods ──
        public void GetRfc5054Default(){} // RVA: 0x7FFACBB3E2F0
        public void .ctor(){} // RVA: 0x7FFAC3000E00
        public void GetLoginParameters(){} // RVA: 0x7FFACBB3E560
        public void .cctor(){} // RVA: 0x7FFACBB3E8F0
    }

    public class SrpTlsClient : AbstractTlsClient
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSrpGroupVerifier RequireSrpServerExtension; // 0x50
        public byte[] mIdentity; // 0x58
        public byte[] mPassword; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB3EBA0 | overloaded x3
        public void get_RequireSrpServerExtension(){} // RVA: 0x7FFAC2F21320
        public void GetCipherSuites(){} // RVA: 0x7FFACBB3EE20
        public void GetClientExtensions(){} // RVA: 0x7FFACBB3EE80
        public void ProcessServerExtensions(){} // RVA: 0x7FFACBB3F0A0
        public void GetKeyExchange(){} // RVA: 0x7FFACBB3F2C0
        public void GetAuthentication(){} // RVA: 0x7FFACBB3F380
        public void CreateSrpKeyExchange(){} // RVA: 0x7FFACBB3F3D0
    }

    public class SrpTlsServer : AbstractTlsServer
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSrpIdentityManager mSrpIdentityManager; // 0x88
        public byte[] mSrpIdentity; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSrpLoginParameters mLoginParameters; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB39D20 | overloaded x2
        public void GetDsaSignerCredentials(){} // RVA: 0x7FFACBB3F570
        public void GetRsaSignerCredentials(){} // RVA: 0x7FFACBB3F5C0
        public void GetCipherSuites(){} // RVA: 0x7FFACBB3F610
        public void ProcessClientExtensions(){} // RVA: 0x7FFACBB3F680
        public void GetSelectedCipherSuite(){} // RVA: 0x7FFACBB3F860
        public void GetCredentials(){} // RVA: 0x7FFACBB3FA10
        public void GetKeyExchange(){} // RVA: 0x7FFACBB3FB00
        public void CreateSrpKeyExchange(){} // RVA: 0x7FFACBB3FBC0
    }

    public class SrtpProtectionProfile : Object
    {
        public int SRTP_AES128_CM_HMAC_SHA1_80;
        public int SRTP_AES128_CM_HMAC_SHA1_32;
        public int SRTP_NULL_HMAC_SHA1_80;
        public int SRTP_NULL_HMAC_SHA1_32;
        public int SRTP_AEAD_AES_128_GCM;
        public int SRTP_AEAD_AES_256_GCM;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Ssl3Mac : Object
    {
        public byte AlgorithmName;
        public byte OPAD_BYTE;
        public byte[] IPAD;
        public byte[] OPAD; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x10
        public int padLength; // 0x18
        public byte[] secret; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB3FC60
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB3FD20
        public void Init(){} // RVA: 0x7FFACBB3FD90
        public void GetMacSize(){} // RVA: 0x7FFACBB3FF20
        public void Update(){} // RVA: 0x7FFACBB3FF70
        public void BlockUpdate(){} // RVA: 0x7FFACBB3FFD0
        public void DoFinal(){} // RVA: 0x7FFACBB40060
        public void Reset(){} // RVA: 0x7FFACBB40240
        public void GenPad(){} // RVA: 0x7FFACBB40350
        public void .cctor(){} // RVA: 0x7FFACBB40400
    }

    public class SupplementalDataEntry : Object
    {
        public int DataType; // 0x10
        public byte[] Data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47EB5F0
        public void get_DataType(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Data(){} // RVA: 0x7FFAC2F247C0
    }

    public class SupplementalDataType : Object
    {
        public int user_mapping_data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}