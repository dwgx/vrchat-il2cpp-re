// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 7
// Methods: 78

namespace ThirdParty.DotNet.System.Net
{
    public class ServerCertValidationCallback : Object
    {
        public object m_ValidationCallback;
        public object m_Context;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75A8440
        public void get_ValidationCallback(){} // RVA: 0xB5DBF0
        public void Callback(){} // RVA: 0x75A8550
        public void Invoke(){} // RVA: 0x75A8600
    }

    public class ServiceNameStore : Object
    {
        public object serviceNames;
        public object serviceNameCollection;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7592430
    }

    public class ServicePoint : Object
    {
        public object uri;
        public object lastDnsResolve;
        public object protocolVersion;
        public object host;
        public object usesProxy;
        public object sendContinue;
        public object useConnect;
        public object hostE;
        public object useNagle;
        public object endPointCallback;
        public object tcp_keepalive;
        public object tcp_keepalive_time;
        public object tcp_keepalive_interval;
        public object disposed;
        public object connectionLeaseTimeout;
        public object receiveBufferSize;
        public object _key;
        public object _scheduler;
        public object connectionLimit;
        public object maxIdleTime;
        public object m_ServerCertificateOrBytes;
        public object m_ClientCertificateOrBytes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75D37A0
        public void get_Key(){} // RVA: 0xBBFF90
        public void get_Scheduler(){} // RVA: 0xC10050
        public void set_Scheduler(){} // RVA: 0xC10060
        public void get_Address(){} // RVA: 0xB5DBF0
        public void get_ConnectionLimit(){} // RVA: 0x23ADD10
        public void get_ProtocolVersion(){} // RVA: 0xB700F0
        public void set_Expect100Continue(){} // RVA: 0xB68E20
        public void get_UseNagleAlgorithm(){} // RVA: 0xC02470
        public void set_UseNagleAlgorithm(){} // RVA: 0xC02480
        public void get_SendContinue(){} // RVA: 0x75D2310
        public void set_SendContinue(){} // RVA: 0xB68E20
        public void SetTcpKeepAlive(){} // RVA: 0x75D23D0
        public void KeepAliveSetup(){} // RVA: 0x75D24C0
        public void PutBytes(){} // RVA: 0x75D2770
        public void get_UsesProxy(){} // RVA: 0xB68DF0
        public void set_UsesProxy(){} // RVA: 0xB68E00
        public void get_UseConnect(){} // RVA: 0x4674B20
        public void set_UseConnect(){} // RVA: 0x653CDE0
        public void get_HasTimedOut(){} // RVA: 0x75D27E0
        public void get_HostEntry(){} // RVA: 0x75D2960
        public void SetVersion(){} // RVA: 0xB70100
        public void SendRequest(){} // RVA: 0x75D2FF0
        public void CloseConnectionGroup(){} // RVA: 0x75D31A0
        public void FreeServicePoint(){} // RVA: 0x75D3460
        public void UpdateServerCertificate(){} // RVA: 0x75D34C0
        public void UpdateClientCertificate(){} // RVA: 0x75D35C0
        public void CallEndPointDelegate(){} // RVA: 0x75D36C0
    }

    public class ServicePointManager : Object
    {
        public object servicePoints;
        public object policy;
        public object defaultConnectionLimit;
        public object maxServicePointIdleTime;
        public object maxServicePoints;
        public object dnsRefreshTimeout;
        public object _checkCRL;
        public object _securityProtocol;
        public object expectContinue;
        public object useNagle;
        public object server_cert_cb;
        public object tcp_keepalive;
        public object tcp_keepalive_time;
        public object tcp_keepalive_interval;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x75D37D0
        public void get_CertificatePolicy(){} // RVA: 0x75D3930
        public void set_CertificatePolicy(){} // RVA: 0x75D3A50
        public void GetLegacyCertificatePolicy(){} // RVA: 0x75D3B10
        public void get_CheckCertificateRevocationList(){} // RVA: 0x75D3B70
        public void get_DnsRefreshTimeout(){} // RVA: 0x75D3BD0
        public void get_SecurityProtocol(){} // RVA: 0x75D3C30
        public void get_ServerCertValidationCallback(){} // RVA: 0x75D3C90
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x75D3CF0
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x75D3D80
        public void FindServicePoint(){} // RVA: 0x75D3F10
        public void CloseConnectionGroup(){} // RVA: 0x75D4900
        public void RemoveServicePoint(){} // RVA: 0x75D4C80
    }

    public class ServicePointScheduler : Object
    {
        public object _servicePoint;
        public object running;
        public object maxIdleTime;
        public object schedulerEvent;
        public object defaultGroup;
        public object groups;
        public object operations;
        public object idleConnections;
        public object currentConnections;
        public object connectionLimit;
        public object idleSince;
        public object nextId;
        public object ID;
        public object _mE;

        // ── Methods ──
        public void get_ServicePoint(){} // RVA: 0xB5DBF0
        public void set_ServicePoint(){} // RVA: 0xB44D60
        public void get_MaxIdleTime(){} // RVA: 0x2244FB0
        public void .ctor(){} // RVA: 0x75D4FD0
        public void Run(){} // RVA: 0x75D53A0
        public void RunScheduler(){} // RVA: 0x75D54B0
        public void Cleanup(){} // RVA: 0x75D5670
        public void RunSchedulerIteration(){} // RVA: 0x75D58B0
        public void OperationCompleted(){} // RVA: 0x75D5AC0
        public void CloseIdleConnection(){} // RVA: 0x75D5D60
        public void SchedulerIteration(){} // RVA: 0x75D5DB0
        public void RemoveOperation(){} // RVA: 0x75D5FE0
        public void RemoveIdleConnection(){} // RVA: 0x75D60C0
        public void FinalCleanup(){} // RVA: 0x75D61A0
        public void SendRequest(){} // RVA: 0x75D6500
        public void CloseConnectionGroup(){} // RVA: 0x75D6680
        public void GetConnectionGroup(){} // RVA: 0x75D67E0
        public void OnConnectionCreated(){} // RVA: 0x75D6B20
        public void OnConnectionClosed(){} // RVA: 0x75D6B30
        public void WaitAsync(){} // RVA: 0x75D6B50
        public void <Run>b__31_0(){} // RVA: 0x75D54B0
    }

    public class SocketAddress : Object
    {
        public object m_Size;
        public object m_Buffer;
        public object m_changed;
        public object m_hash;

        // ── Methods ──
        public void get_Family(){} // RVA: 0x7585830
        public void get_Size(){} // RVA: 0xB8F8F0
        public void get_Item(){} // RVA: 0x7585870
        public void .ctor(){} // RVA: 0x7585E10
        public void GetIPAddress(){} // RVA: 0x7585E70
        public void GetIPEndPoint(){} // RVA: 0x7586140
        public void Equals(){} // RVA: 0x75861F0
        public void GetHashCode(){} // RVA: 0x7586330
        public void ToString(){} // RVA: 0x7586470
    }

    public class SystemNetworkCredential : NetworkCredential
    {
        public object defaultCredential;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7580A20
        public void .cctor(){} // RVA: 0x7580A50
    }

}