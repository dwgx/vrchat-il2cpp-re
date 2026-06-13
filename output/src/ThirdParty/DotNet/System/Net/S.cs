// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 7
// Methods: 80

namespace ThirdParty.DotNet.System.Net
{
    public class ServerCertValidationCallback
    {
        public System.Net.Security.RemoteCertificateValidationCallback m_ValidationCallback; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B45150
        public void get_ValidationCallback(){} // RVA: 0x2F8380
        public void Callback(){} // RVA: 0x6B45260
        public void Invoke(){} // RVA: 0x6B45310
    }

    public class ServiceNameStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B2E090
    }

    public class ServicePoint
    {
        public System.Uri uri; // 0x10
        public System.DateTime lastDnsResolve; // 0x18
        public System.Version protocolVersion; // 0x20
        public System.Net.IPHostEntry host; // 0x28
        public bool usesProxy; // 0x30
        public bool sendContinue; // 0x31
        public bool useConnect; // 0x32
        public object hostE; // 0x38
        public bool useNagle; // 0x40
        public System.Net.BindIPEndPoint endPointCallback; // 0x48
        public bool tcp_keepalive; // 0x50
        public int tcp_keepalive_time; // 0x54

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B6FDB0
        public void get_Key(){} // RVA: 0x358D50
        public void get_Scheduler(){} // RVA: 0x3A5590
        public void set_Scheduler(){} // RVA: 0x3A55A0
        public void get_Address(){} // RVA: 0x2F8380
        public void get_ConnectionLimit(){} // RVA: 0x1AE3800
        public void get_ProtocolVersion(){} // RVA: 0x30B0C0
        public void set_Expect100Continue(){} // RVA: 0x303480
        public void get_UseNagleAlgorithm(){} // RVA: 0x398C00
        public void set_UseNagleAlgorithm(){} // RVA: 0x398C10
        public void get_SendContinue(){} // RVA: 0x6B6FFB0
        public void set_SendContinue(){} // RVA: 0x303480
        public void SetTcpKeepAlive(){} // RVA: 0x6B70070
        public void KeepAliveSetup(){} // RVA: 0x6B70160
        public void PutBytes(){} // RVA: 0x6B70410
        public void get_UsesProxy(){} // RVA: 0x303450
        public void set_UsesProxy(){} // RVA: 0x303460
        public void get_UseConnect(){} // RVA: 0x3BE7520
        public void set_UseConnect(){} // RVA: 0x5AC2490
        public void get_HasTimedOut(){} // RVA: 0x6B70480
        public void get_HostEntry(){} // RVA: 0x6B70600
        public void SetVersion(){} // RVA: 0x30B0D0
        public void SendRequest(){} // RVA: 0x6B70CD0
        public void CloseConnectionGroup(){} // RVA: 0x6B70EC0
        public void FreeServicePoint(){} // RVA: 0x6B711B0
        public void UpdateServerCertificate(){} // RVA: 0x6B71210
        public void UpdateClientCertificate(){} // RVA: 0x6B71310
        public void CallEndPointDelegate(){} // RVA: 0x6B71410
    }

    public class ServicePointManager
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<SPKey,System.Net.ServicePoint> servicePoints;
        public System.Net.ICertificatePolicy policy; // 0x8
        public int defaultConnectionLimit; // 0x10
        public int maxServicePointIdleTime; // 0x14
        public int maxServicePoints; // 0x18
        public int dnsRefreshTimeout; // 0x1C

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6B714E0
        public void get_CertificatePolicy(){} // RVA: 0x6B71640
        public void set_CertificatePolicy(){} // RVA: 0x6B71760
        public void GetLegacyCertificatePolicy(){} // RVA: 0x6B71820
        public void get_CheckCertificateRevocationList(){} // RVA: 0x6B71880
        public void get_DnsRefreshTimeout(){} // RVA: 0x6B718E0
        public void get_SecurityProtocol(){} // RVA: 0x6B71940
        public void get_ServerCertValidationCallback(){} // RVA: 0x6B719A0
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x6B71A00
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x6B71A90
        public void FindServicePoint(){} // RVA: 0x6B71C20
        public void CloseConnectionGroup(){} // RVA: 0x6B726F0
        public void RemoveServicePoint(){} // RVA: 0x6B72AA0
    }

    public class ServicePointScheduler
    {
        public System.Net.ServicePoint <ServicePoint>k__BackingField; // 0x10
        public int running; // 0x18

        // ── Methods ──
        public void get_ServicePoint(){} // RVA: 0x2F8380
        public void set_ServicePoint(){} // RVA: 0x2DEE30
        public void get_MaxIdleTime(){} // RVA: 0x197C3B0
        public void .ctor(){} // RVA: 0x6B72E00
        public void Run(){} // RVA: 0x6B731C0
        public void RunScheduler(){} // RVA: 0x6B732D0
        public void Cleanup(){} // RVA: 0x6B73490
        public void RunSchedulerIteration(){} // RVA: 0x6B736D0
        public void OperationCompleted(){} // RVA: 0x6B738E0
        public void CloseIdleConnection(){} // RVA: 0x6B73B90
        public void SchedulerIteration(){} // RVA: 0x6B73BE0
        public void RemoveOperation(){} // RVA: 0x6B73E20
        public void RemoveIdleConnection(){} // RVA: 0x6B73F00
        public void FinalCleanup(){} // RVA: 0x6B73FE0
        public void SendRequest(){} // RVA: 0x6B74340
        public void CloseConnectionGroup(){} // RVA: 0x6B74500
        public void GetConnectionGroup(){} // RVA: 0x6B74660
        public void OnConnectionCreated(){} // RVA: 0x6B749E0
        public void OnConnectionClosed(){} // RVA: 0x6B749F0
        public void WaitAsync(){} // RVA: 0x6B74A10
        public void <Run>b__31_0(){} // RVA: 0x6B732D0
    }

    public class SocketAddress
    {
        public int m_Size; // 0x10
        public byte[] m_Buffer; // 0x18
        public bool m_changed; // 0x20

        // ── Methods ──
        public void get_Family(){} // RVA: 0x6B21360
        public void get_Size(){} // RVA: 0x32A5C0
        public void get_Item(){} // RVA: 0x6B213A0
        public void .ctor(){} // RVA: 0x6B21960 | overloaded x3
        public void GetIPAddress(){} // RVA: 0x6B219C0
        public void GetIPEndPoint(){} // RVA: 0x6B21C90
        public void Equals(){} // RVA: 0x6B21D40
        public void GetHashCode(){} // RVA: 0x6B21E70
        public void ToString(){} // RVA: 0x6B21F90
    }

    public class SystemNetworkCredential
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B1C730
        public void .cctor(){} // RVA: 0x6B1C790
    }

}