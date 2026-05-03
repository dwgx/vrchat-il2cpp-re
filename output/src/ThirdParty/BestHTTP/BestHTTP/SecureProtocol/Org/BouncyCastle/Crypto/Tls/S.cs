// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 16
// Methods: 96

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class SecurityParameters : Object
    {
        public int entity; // 0x10
        public int cipherSuite; // 0x14
        public byte compressionAlgorithm; // 0x18
        public int prfAlgorithm; // 0x1C
        public int verifyDataLength; // 0x20
        public byte[] masterSecret; // 0x28
        public byte[] clientRandom; // 0x30
        public byte[] serverRandom; // 0x38
        public byte[] sessionHash; // 0x40
        public byte[] pskIdentity; // 0x48
        public byte[] srpIdentity; // 0x50
        public short maxFragmentLength; // 0x58

        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFE89F95480
        public void get_Entity(){} // RVA: 0x7FFE811485C0
        public void get_CipherSuite(){} // RVA: 0x7FFE8164B230
        public void get_CompressionAlgorithm(){} // RVA: 0x7FFE811164E0
        public void get_PrfAlgorithm(){} // RVA: 0x7FFE82707EE0
        public void get_VerifyDataLength(){} // RVA: 0x7FFE8151D690
        public void get_MasterSecret(){} // RVA: 0x7FFE81129130
        public void get_ClientRandom(){} // RVA: 0x7FFE8144E200
        public void get_ServerRandom(){} // RVA: 0x7FFE8143BA80
        public void get_SessionHash(){} // RVA: 0x7FFE81178740
        public void get_PskIdentity(){} // RVA: 0x7FFE81176730
        public void get_SrpIdentity(){} // RVA: 0x7FFE8119C0E0
        public void get_IsExtendedMasterSecret(){} // RVA: 0x7FFE81199240
        public void .ctor(){} // RVA: 0x7FFE89F95560
    }

    public class ServerName : Object
    {
        public byte mNameType; // 0x10
        public object mName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F95580
        public void get_NameType(){} // RVA: 0x7FFE811C55E0
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void GetHostName(){} // RVA: 0x7FFE89F95660
        public void Encode(){} // RVA: 0x7FFE89F95750
        public void Parse(){} // RVA: 0x7FFE89F958F0
        public void IsCorrectType(){} // RVA: 0x7FFE89F95AC0
    }

    public class ServerNameList : Object
    {
        public System.Collections.IList mServerNameList; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F95B80
        public void get_ServerNames(){} // RVA: 0x7FFE81116380
        public void Encode(){} // RVA: 0x7FFE89F95C30
        public void Parse(){} // RVA: 0x7FFE89F95FE0
        public void CheckNameType(){} // RVA: 0x7FFE89F96390
    }

    public class ServerOnlyTlsAuthentication : Object
    {
        // ── Methods ──
        public void NotifyServerCertificate(){} // RVA: 0x7FFE80E460A0
        public void GetClientCredentials(){} // RVA: 0x7FFE813240E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ServerSrpParams : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_N; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_g; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_B; // 0x20
        public byte[] m_s; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F96450
        public void get_B(){} // RVA: 0x7FFE811290C0
        public void get_G(){} // RVA: 0x7FFE810FE7C0
        public void get_N(){} // RVA: 0x7FFE81116380
        public void get_S(){} // RVA: 0x7FFE81129130
        public void Encode(){} // RVA: 0x7FFE89F96670
        public void Parse(){} // RVA: 0x7FFE89F96880
    }

    public class SessionParameters : Object
    {
        public int mCipherSuite; // 0x10
        public byte mCompressionAlgorithm; // 0x14
        public byte[] mMasterSecret; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate mPeerCertificate; // 0x20
        public byte[] mPskIdentity; // 0x28
        public byte[] mSrpIdentity; // 0x30
        public byte[] mEncodedServerExtensions; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F96970
        public void Clear(){} // RVA: 0x7FFE89F96CB0
        public void Copy(){} // RVA: 0x7FFE89F96D30
        public void get_CipherSuite(){} // RVA: 0x7FFE811485C0
        public void get_CompressionAlgorithm(){} // RVA: 0x7FFE8124ABD0
        public void get_IsExtendedMasterSecret(){} // RVA: 0x7FFE811B6C00
        public void get_MasterSecret(){} // RVA: 0x7FFE810FE7C0
        public void get_PeerCertificate(){} // RVA: 0x7FFE811290C0
        public void get_PskIdentity(){} // RVA: 0x7FFE81129130
        public void get_SrpIdentity(){} // RVA: 0x7FFE8144E200
        public void ReadServerExtensions(){} // RVA: 0x7FFE89F96E00
    }

    public class SignatureAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SignatureAndHashAlgorithm : Object
    {
        public byte mHash; // 0x10
        public byte mSignature; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F97290
        public void get_Hash(){} // RVA: 0x7FFE811C55E0
        public void get_Signature(){} // RVA: 0x7FFE81346E30
        public void Equals(){} // RVA: 0x7FFE89F97370
        public void GetHashCode(){} // RVA: 0x7FFE89F974B0
        public void Encode(){} // RVA: 0x7FFE89F97500
        public void Parse(){} // RVA: 0x7FFE89F975D0
    }

    public class SignerInputBuffer : MemoryStream
    {
        // ── Methods ──
        public void UpdateSigner(){} // RVA: 0x7FFE89F97720
        public void .ctor(){} // RVA: 0x7FFE89F83F50
    }

    public class SimulatedTlsSrpIdentityManager : Object
    {
        // ── Methods ──
        public void GetRfc5054Default(){} // RVA: 0x7FFE89F97910
        public void .ctor(){} // RVA: 0x7FFE811DAE00
        public void GetLoginParameters(){} // RVA: 0x7FFE89F97B80
        public void .cctor(){} // RVA: 0x7FFE89F97F10
    }

    public class SrpTlsClient : AbstractTlsClient
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSrpGroupVerifier mGroupVerifier; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F981C0 | overloaded x3
        public void get_RequireSrpServerExtension(){} // RVA: 0x7FFE810FB320
        public void GetCipherSuites(){} // RVA: 0x7FFE89F98440
        public void GetClientExtensions(){} // RVA: 0x7FFE89F984A0
        public void ProcessServerExtensions(){} // RVA: 0x7FFE89F986C0
        public void GetKeyExchange(){} // RVA: 0x7FFE89F988E0
        public void GetAuthentication(){} // RVA: 0x7FFE89F989A0
        public void CreateSrpKeyExchange(){} // RVA: 0x7FFE89F989F0
    }

    public class SrpTlsServer : AbstractTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F93340 | overloaded x2
        public void GetDsaSignerCredentials(){} // RVA: 0x7FFE89F98B90
        public void GetRsaSignerCredentials(){} // RVA: 0x7FFE89F98BE0
        public void GetCipherSuites(){} // RVA: 0x7FFE89F98C30
        public void ProcessClientExtensions(){} // RVA: 0x7FFE89F98CA0
        public void GetSelectedCipherSuite(){} // RVA: 0x7FFE89F98E80
        public void GetCredentials(){} // RVA: 0x7FFE89F99030
        public void GetKeyExchange(){} // RVA: 0x7FFE89F99120
        public void CreateSrpKeyExchange(){} // RVA: 0x7FFE89F991E0
    }

    public class SrtpProtectionProfile : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Ssl3Mac : Object
    {
        public byte IPAD_BYTE;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F99280
        public void get_AlgorithmName(){} // RVA: 0x7FFE89F99340
        public void Init(){} // RVA: 0x7FFE89F993B0
        public void GetMacSize(){} // RVA: 0x7FFE89F99540
        public void Update(){} // RVA: 0x7FFE89F99590
        public void BlockUpdate(){} // RVA: 0x7FFE89F995F0
        public void DoFinal(){} // RVA: 0x7FFE89F99680
        public void Reset(){} // RVA: 0x7FFE89F99860
        public void GenPad(){} // RVA: 0x7FFE89F99970
        public void .cctor(){} // RVA: 0x7FFE89F99A20
    }

    public class SupplementalDataEntry : Object
    {
        public int mDataType; // 0x10
        public byte[] mData; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A53990
        public void get_DataType(){} // RVA: 0x7FFE811485C0
        public void get_Data(){} // RVA: 0x7FFE810FE7C0
    }

    public class SupplementalDataType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}