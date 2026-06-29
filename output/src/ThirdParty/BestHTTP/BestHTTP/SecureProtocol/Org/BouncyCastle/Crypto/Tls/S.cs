// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 17
// Methods: 108

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class SecurityParameters : Object
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7B13693E0
        public void get_Entity(){} // RVA: 0x7A8124910
        public void get_CipherSuite(){} // RVA: 0x7A8668BC0
        public void get_CompressionAlgorithm(){} // RVA: 0x7A80F26D0
        public void get_PrfAlgorithm(){} // RVA: 0x7A9739200
        public void get_VerifyDataLength(){} // RVA: 0x7A851DB90
        public void get_MasterSecret(){} // RVA: 0x7A8105330
        public void get_ClientRandom(){} // RVA: 0x7A83F69F0
        public void get_ServerRandom(){} // RVA: 0x7A8292C30
        public void get_SessionHash(){} // RVA: 0x7A8154D80
        public void get_PskIdentity(){} // RVA: 0x7A8152D80
        public void get_SrpIdentity(){} // RVA: 0x7A8178B90
        public void get_IsExtendedMasterSecret(){} // RVA: 0x7A8175CC0
        public void .ctor(){} // RVA: 0x7B13694C0
    }

    public class ServerName : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13694E0
        public void get_NameType(){} // RVA: 0x7A81A2200
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void GetHostName(){} // RVA: 0x7B13695C0
        public void Encode(){} // RVA: 0x7B13696B0
        public void Parse(){} // RVA: 0x7B1369850
        public void IsCorrectType(){} // RVA: 0x7B1369A30
    }

    public class ServerNameList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1369AF0
        public void get_ServerNames(){} // RVA: 0x7A80F2570
        public void Encode(){} // RVA: 0x7B1369BA0
        public void Parse(){} // RVA: 0x7B1369F50
        public void CheckNameType(){} // RVA: 0x7B136A300
    }

    public class ServerName[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ServerOnlyTlsAuthentication : Object
    {
        // ── Methods ──
        public void NotifyServerCertificate(){} // RVA: 0x7A7E18800
        public void GetClientCredentials(){} // RVA: 0x7A82D1450
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ServerSrpParams : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B136A3D0
        public void get_B(){} // RVA: 0x7A81052C0
        public void get_G(){} // RVA: 0x7A80DA7B0
        public void get_N(){} // RVA: 0x7A80F2570
        public void get_S(){} // RVA: 0x7A8105330
        public void Encode(){} // RVA: 0x7B136A5F0
        public void Parse(){} // RVA: 0x7B136A800
    }

    public class SessionParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B136A8F0
        public void Clear(){} // RVA: 0x7B136AC40
        public void Copy(){} // RVA: 0x7B136ACC0
        public void get_CipherSuite(){} // RVA: 0x7A8124910
        public void get_CompressionAlgorithm(){} // RVA: 0x7A8227C00
        public void get_IsExtendedMasterSecret(){} // RVA: 0x7A8193790
        public void get_MasterSecret(){} // RVA: 0x7A80DA7B0
        public void get_PeerCertificate(){} // RVA: 0x7A81052C0
        public void get_PskIdentity(){} // RVA: 0x7A8105330
        public void get_SrpIdentity(){} // RVA: 0x7A83F69F0
        public void ReadServerExtensions(){} // RVA: 0x7B136AD90
    }

    public class SignatureAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SignatureAndHashAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B136B220
        public void get_Hash(){} // RVA: 0x7A81A2200
        public void get_Signature(){} // RVA: 0x7A82FBFB0
        public void Equals(){} // RVA: 0x7B136B300
        public void GetHashCode(){} // RVA: 0x7B136B440
        public void Encode(){} // RVA: 0x7B136B490
        public void Parse(){} // RVA: 0x7B136B560
    }

    public class SignerInputBuffer : MemoryStream
    {
        // ── Methods ──
        public void UpdateSigner(){} // RVA: 0x7B136B6B0
        public void .ctor(){} // RVA: 0x7B1357E90
    }

    public class SimulatedTlsSrpIdentityManager : Object
    {
        // ── Methods ──
        public void GetRfc5054Default(){} // RVA: 0x7B136B8A0
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void GetLoginParameters(){} // RVA: 0x7B136BB10
        public void .cctor(){} // RVA: 0x7B136BEB0
    }

    public class SrpTlsClient : AbstractTlsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B136C160
        public void get_RequireSrpServerExtension(){} // RVA: 0x7A80D7320
        public void GetCipherSuites(){} // RVA: 0x7B136C3E0
        public void GetClientExtensions(){} // RVA: 0x7B136C440
        public void ProcessServerExtensions(){} // RVA: 0x7B136C660
        public void GetKeyExchange(){} // RVA: 0x7B136C880
        public void GetAuthentication(){} // RVA: 0x7B136C940
        public void CreateSrpKeyExchange(){} // RVA: 0x7B136C990
    }

    public class SrpTlsServer : AbstractTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13672A0
        public void GetDsaSignerCredentials(){} // RVA: 0x7B136CB30
        public void GetRsaSignerCredentials(){} // RVA: 0x7B136CB80
        public void GetCipherSuites(){} // RVA: 0x7B136CBD0
        public void ProcessClientExtensions(){} // RVA: 0x7B136CC40
        public void GetSelectedCipherSuite(){} // RVA: 0x7B136CE20
        public void GetCredentials(){} // RVA: 0x7B136CFD0
        public void GetKeyExchange(){} // RVA: 0x7B136D0C0
        public void CreateSrpKeyExchange(){} // RVA: 0x7B136D180
    }

    public class SrtpProtectionProfile : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Ssl3Mac : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B136D220
        public void get_AlgorithmName(){} // RVA: 0x7B136D2E0
        public void Init(){} // RVA: 0x7B136D350
        public void GetMacSize(){} // RVA: 0x7B136D4E0
        public void Update(){} // RVA: 0x7B136D530
        public void BlockUpdate(){} // RVA: 0x7B136D590
        public void DoFinal(){} // RVA: 0x7B136D620
        public void Reset(){} // RVA: 0x7B136D800
        public void GenPad(){} // RVA: 0x7B136D910
        public void .cctor(){} // RVA: 0x7B136D9C0
    }

    public class SupplementalDataEntry : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AC8120
        public void get_DataType(){} // RVA: 0x7A8124910
        public void get_Data(){} // RVA: 0x7A80DA7B0
    }

    public class SupplementalDataType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}