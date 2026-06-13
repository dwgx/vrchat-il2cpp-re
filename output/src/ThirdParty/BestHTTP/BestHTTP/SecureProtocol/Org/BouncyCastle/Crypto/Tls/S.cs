// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 16
// Methods: 96

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class SecurityParameters
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
        public void Clear(){} // RVA: 0x95330B0
        public void get_Entity(){} // RVA: 0x32A5C0
        public void get_CipherSuite(){} // RVA: 0x8ABED0
        public void get_CompressionAlgorithm(){} // RVA: 0x2F84E0
        public void get_PrfAlgorithm(){} // RVA: 0x197C3B0
        public void get_VerifyDataLength(){} // RVA: 0x760030
        public void get_MasterSecret(){} // RVA: 0x30B130
        public void get_ClientRandom(){} // RVA: 0x6374D0
        public void get_ServerRandom(){} // RVA: 0x4976A0
        public void get_SessionHash(){} // RVA: 0x35A740
        public void get_PskIdentity(){} // RVA: 0x358730
        public void get_SrpIdentity(){} // RVA: 0x37E0E0
        public void get_IsExtendedMasterSecret(){} // RVA: 0x37B240
        public void .ctor(){} // RVA: 0x9533190
    }

    public class ServerName
    {
        public byte mNameType; // 0x10
        public object mName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95331B0
        public void get_NameType(){} // RVA: 0x3A75E0
        public void get_Name(){} // RVA: 0x2E07C0
        public void GetHostName(){} // RVA: 0x9533290
        public void Encode(){} // RVA: 0x9533380
        public void Parse(){} // RVA: 0x9533520
        public void IsCorrectType(){} // RVA: 0x95336F0
    }

    public class ServerNameList
    {
        public System.Collections.IList mServerNameList; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95337B0
        public void get_ServerNames(){} // RVA: 0x2F8380
        public void Encode(){} // RVA: 0x9533860
        public void Parse(){} // RVA: 0x9533C10
        public void CheckNameType(){} // RVA: 0x9533FC0
    }

    public class ServerOnlyTlsAuthentication
    {
        // ── Methods ──
        public void NotifyServerCertificate(){} // RVA: 0x24B10
        public void GetClientCredentials(){} // RVA: 0x519240
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ServerSrpParams
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_N; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_g; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_B; // 0x20
        public byte[] m_s; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9534080
        public void get_B(){} // RVA: 0x30B0C0
        public void get_G(){} // RVA: 0x2E07C0
        public void get_N(){} // RVA: 0x2F8380
        public void get_S(){} // RVA: 0x30B130
        public void Encode(){} // RVA: 0x95342A0
        public void Parse(){} // RVA: 0x95344B0
    }

    public class SessionParameters
    {
        public int mCipherSuite; // 0x10
        public byte mCompressionAlgorithm; // 0x14
        public byte[] mMasterSecret; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.Certificate mPeerCertificate; // 0x20
        public byte[] mPskIdentity; // 0x28
        public byte[] mSrpIdentity; // 0x30
        public byte[] mEncodedServerExtensions; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95345A0
        public void Clear(){} // RVA: 0x95348E0
        public void Copy(){} // RVA: 0x9534960
        public void get_CipherSuite(){} // RVA: 0x32A5C0
        public void get_CompressionAlgorithm(){} // RVA: 0x42CBD0
        public void get_IsExtendedMasterSecret(){} // RVA: 0x398C00
        public void get_MasterSecret(){} // RVA: 0x2E07C0
        public void get_PeerCertificate(){} // RVA: 0x30B0C0
        public void get_PskIdentity(){} // RVA: 0x30B130
        public void get_SrpIdentity(){} // RVA: 0x6374D0
        public void ReadServerExtensions(){} // RVA: 0x9534A30
    }

    public class SignatureAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SignatureAndHashAlgorithm
    {
        public byte mHash; // 0x10
        public byte mSignature; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9534EC0
        public void get_Hash(){} // RVA: 0x3A75E0
        public void get_Signature(){} // RVA: 0x543460
        public void Equals(){} // RVA: 0x9534FA0
        public void GetHashCode(){} // RVA: 0x95350E0
        public void Encode(){} // RVA: 0x9535130
        public void Parse(){} // RVA: 0x9535200
    }

    public class SignerInputBuffer
    {
        // ── Methods ──
        public void UpdateSigner(){} // RVA: 0x9535350
        public void .ctor(){} // RVA: 0x9521B80
    }

    public class SimulatedTlsSrpIdentityManager
    {
        // ── Methods ──
        public void GetRfc5054Default(){} // RVA: 0x9535540
        public void .ctor(){} // RVA: 0x3BCE00
        public void GetLoginParameters(){} // RVA: 0x95357B0
        public void .cctor(){} // RVA: 0x9535B40
    }

    public class SrpTlsClient
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsSrpGroupVerifier mGroupVerifier; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9535DF0 | overloaded x3
        public void get_RequireSrpServerExtension(){} // RVA: 0x2DD320
        public void GetCipherSuites(){} // RVA: 0x9536070
        public void GetClientExtensions(){} // RVA: 0x95360D0
        public void ProcessServerExtensions(){} // RVA: 0x95362F0
        public void GetKeyExchange(){} // RVA: 0x9536510
        public void GetAuthentication(){} // RVA: 0x95365D0
        public void CreateSrpKeyExchange(){} // RVA: 0x9536620
    }

    public class SrpTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9530F70 | overloaded x2
        public void GetDsaSignerCredentials(){} // RVA: 0x95367C0
        public void GetRsaSignerCredentials(){} // RVA: 0x9536810
        public void GetCipherSuites(){} // RVA: 0x9536860
        public void ProcessClientExtensions(){} // RVA: 0x95368D0
        public void GetSelectedCipherSuite(){} // RVA: 0x9536AB0
        public void GetCredentials(){} // RVA: 0x9536C60
        public void GetKeyExchange(){} // RVA: 0x9536D50
        public void CreateSrpKeyExchange(){} // RVA: 0x9536E10
    }

    public class SrtpProtectionProfile
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Ssl3Mac
    {
        public byte IPAD_BYTE;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9536EB0
        public void get_AlgorithmName(){} // RVA: 0x9536F70
        public void Init(){} // RVA: 0x9536FE0
        public void GetMacSize(){} // RVA: 0x9537170
        public void Update(){} // RVA: 0x95371C0
        public void BlockUpdate(){} // RVA: 0x9537220
        public void DoFinal(){} // RVA: 0x95372B0
        public void Reset(){} // RVA: 0x9537490
        public void GenPad(){} // RVA: 0x95375A0
        public void .cctor(){} // RVA: 0x9537650
    }

    public class SupplementalDataEntry
    {
        public int mDataType; // 0x10
        public byte[] mData; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5AF0
        public void get_DataType(){} // RVA: 0x32A5C0
        public void get_Data(){} // RVA: 0x2E07C0
    }

    public class SupplementalDataType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

}