// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 16
// Methods: 96

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class SecurityParameters
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFAFBFE30B0
        public void get_Entity(){} // RVA: 0x7FFAF2DDA5C0
        public void get_CipherSuite(){} // RVA: 0x7FFAF335BED0
        public void get_CompressionAlgorithm(){} // RVA: 0x7FFAF2DA84E0
        public void get_PrfAlgorithm(){} // RVA: 0x7FFAF442C3B0
        public void get_VerifyDataLength(){} // RVA: 0x7FFAF3210030
        public void get_MasterSecret(){} // RVA: 0x7FFAF2DBB130
        public void get_ClientRandom(){} // RVA: 0x7FFAF30E74D0
        public void get_ServerRandom(){} // RVA: 0x7FFAF2F476A0
        public void get_SessionHash(){} // RVA: 0x7FFAF2E0A740
        public void get_PskIdentity(){} // RVA: 0x7FFAF2E08730
        public void get_SrpIdentity(){} // RVA: 0x7FFAF2E2E0E0
        public void get_IsExtendedMasterSecret(){} // RVA: 0x7FFAF2E2B240
        public void .ctor(){} // RVA: 0x7FFAFBFE3190
    }

    public class ServerName
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE31B0
        public void get_NameType(){} // RVA: 0x7FFAF2E575E0
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void GetHostName(){} // RVA: 0x7FFAFBFE3290
        public void Encode(){} // RVA: 0x7FFAFBFE3380
        public void Parse(){} // RVA: 0x7FFAFBFE3520
        public void IsCorrectType(){} // RVA: 0x7FFAFBFE36F0
    }

    public class ServerNameList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE37B0
        public void get_ServerNames(){} // RVA: 0x7FFAF2DA8380
        public void Encode(){} // RVA: 0x7FFAFBFE3860
        public void Parse(){} // RVA: 0x7FFAFBFE3C10
        public void CheckNameType(){} // RVA: 0x7FFAFBFE3FC0
    }

    public class ServerOnlyTlsAuthentication
    {
        // ── Methods ──
        public void NotifyServerCertificate(){} // RVA: 0x7FFAF2AD4B10
        public void GetClientCredentials(){} // RVA: 0x7FFAF2FC9240
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ServerSrpParams
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE4080
        public void get_B(){} // RVA: 0x7FFAF2DBB0C0
        public void get_G(){} // RVA: 0x7FFAF2D907C0
        public void get_N(){} // RVA: 0x7FFAF2DA8380
        public void get_S(){} // RVA: 0x7FFAF2DBB130
        public void Encode(){} // RVA: 0x7FFAFBFE42A0
        public void Parse(){} // RVA: 0x7FFAFBFE44B0
    }

    public class SessionParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE45A0
        public void Clear(){} // RVA: 0x7FFAFBFE48E0
        public void Copy(){} // RVA: 0x7FFAFBFE4960
        public void get_CipherSuite(){} // RVA: 0x7FFAF2DDA5C0
        public void get_CompressionAlgorithm(){} // RVA: 0x7FFAF2EDCBD0
        public void get_IsExtendedMasterSecret(){} // RVA: 0x7FFAF2E48C00
        public void get_MasterSecret(){} // RVA: 0x7FFAF2D907C0
        public void get_PeerCertificate(){} // RVA: 0x7FFAF2DBB0C0
        public void get_PskIdentity(){} // RVA: 0x7FFAF2DBB130
        public void get_SrpIdentity(){} // RVA: 0x7FFAF30E74D0
        public void ReadServerExtensions(){} // RVA: 0x7FFAFBFE4A30
    }

    public class SignatureAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SignatureAndHashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE4EC0
        public void get_Hash(){} // RVA: 0x7FFAF2E575E0
        public void get_Signature(){} // RVA: 0x7FFAF2FF3460
        public void Equals(){} // RVA: 0x7FFAFBFE4FA0
        public void GetHashCode(){} // RVA: 0x7FFAFBFE50E0
        public void Encode(){} // RVA: 0x7FFAFBFE5130
        public void Parse(){} // RVA: 0x7FFAFBFE5200
    }

    public class SignerInputBuffer
    {
        // ── Methods ──
        public void UpdateSigner(){} // RVA: 0x7FFAFBFE5350
        public void .ctor(){} // RVA: 0x7FFAFBFD1B80
    }

    public class SimulatedTlsSrpIdentityManager
    {
        // ── Methods ──
        public void GetRfc5054Default(){} // RVA: 0x7FFAFBFE5540
        public void .ctor(){} // RVA: 0x7FFAF2E6CE00
        public void GetLoginParameters(){} // RVA: 0x7FFAFBFE57B0
        public void .cctor(){} // RVA: 0x7FFAFBFE5B40
    }

    public class SrpTlsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE5DF0 | overloaded x3
        public void get_RequireSrpServerExtension(){} // RVA: 0x7FFAF2D8D320
        public void GetCipherSuites(){} // RVA: 0x7FFAFBFE6070
        public void GetClientExtensions(){} // RVA: 0x7FFAFBFE60D0
        public void ProcessServerExtensions(){} // RVA: 0x7FFAFBFE62F0
        public void GetKeyExchange(){} // RVA: 0x7FFAFBFE6510
        public void GetAuthentication(){} // RVA: 0x7FFAFBFE65D0
        public void CreateSrpKeyExchange(){} // RVA: 0x7FFAFBFE6620
    }

    public class SrpTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE0F70 | overloaded x2
        public void GetDsaSignerCredentials(){} // RVA: 0x7FFAFBFE67C0
        public void GetRsaSignerCredentials(){} // RVA: 0x7FFAFBFE6810
        public void GetCipherSuites(){} // RVA: 0x7FFAFBFE6860
        public void ProcessClientExtensions(){} // RVA: 0x7FFAFBFE68D0
        public void GetSelectedCipherSuite(){} // RVA: 0x7FFAFBFE6AB0
        public void GetCredentials(){} // RVA: 0x7FFAFBFE6C60
        public void GetKeyExchange(){} // RVA: 0x7FFAFBFE6D50
        public void CreateSrpKeyExchange(){} // RVA: 0x7FFAFBFE6E10
    }

    public class SrtpProtectionProfile
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Ssl3Mac
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE6EB0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFBFE6F70
        public void Init(){} // RVA: 0x7FFAFBFE6FE0
        public void GetMacSize(){} // RVA: 0x7FFAFBFE7170
        public void Update(){} // RVA: 0x7FFAFBFE71C0
        public void BlockUpdate(){} // RVA: 0x7FFAFBFE7220
        public void DoFinal(){} // RVA: 0x7FFAFBFE72B0
        public void Reset(){} // RVA: 0x7FFAFBFE7490
        public void GenPad(){} // RVA: 0x7FFAFBFE75A0
        public void .cctor(){} // RVA: 0x7FFAFBFE7650
    }

    public class SupplementalDataEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4775AF0
        public void get_DataType(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Data(){} // RVA: 0x7FFAF2D907C0
    }

    public class SupplementalDataType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}