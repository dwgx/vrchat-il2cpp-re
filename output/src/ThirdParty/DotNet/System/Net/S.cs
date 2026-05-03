// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 7
// Methods: 80

namespace ThirdParty.DotNet.System.Net
{
    public class ServerCertValidationCallback : Object
    {
        public System.Net.Security.RemoteCertificateValidationCallback m_ValidationCallback; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87684400
        public void get_ValidationCallback(){} // RVA: 0x7FFE81116380
        public void Callback(){} // RVA: 0x7FFE87684510
        public void Invoke(){} // RVA: 0x7FFE876845C0
    }

    public class ServiceNameStore : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8766D350
    }

    public class ServicePoint : Object
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
        public void .ctor(){} // RVA: 0x7FFE876AF060
        public void get_Key(){} // RVA: 0x7FFE81176D50
        public void get_Scheduler(){} // RVA: 0x7FFE811C3590
        public void set_Scheduler(){} // RVA: 0x7FFE811C35A0
        public void get_Address(){} // RVA: 0x7FFE81116380
        public void get_ConnectionLimit(){} // RVA: 0x7FFE8286C0A0
        public void get_ProtocolVersion(){} // RVA: 0x7FFE811290C0
        public void set_Expect100Continue(){} // RVA: 0x7FFE81121480
        public void get_UseNagleAlgorithm(){} // RVA: 0x7FFE811B6C00
        public void set_UseNagleAlgorithm(){} // RVA: 0x7FFE811B6C10
        public void get_SendContinue(){} // RVA: 0x7FFE876AF260
        public void set_SendContinue(){} // RVA: 0x7FFE81121480
        public void SetTcpKeepAlive(){} // RVA: 0x7FFE876AF320
        public void KeepAliveSetup(){} // RVA: 0x7FFE876AF410
        public void PutBytes(){} // RVA: 0x7FFE876AF6C0
        public void get_UsesProxy(){} // RVA: 0x7FFE81121450
        public void set_UsesProxy(){} // RVA: 0x7FFE81121460
        public void get_UseConnect(){} // RVA: 0x7FFE848700A0
        public void set_UseConnect(){} // RVA: 0x7FFE866032C0
        public void get_HasTimedOut(){} // RVA: 0x7FFE876AF730
        public void get_HostEntry(){} // RVA: 0x7FFE876AF8B0
        public void SetVersion(){} // RVA: 0x7FFE811290D0
        public void SendRequest(){} // RVA: 0x7FFE876AFF80
        public void CloseConnectionGroup(){} // RVA: 0x7FFE876B0170
        public void FreeServicePoint(){} // RVA: 0x7FFE876B0460
        public void UpdateServerCertificate(){} // RVA: 0x7FFE876B04C0
        public void UpdateClientCertificate(){} // RVA: 0x7FFE876B05C0
        public void CallEndPointDelegate(){} // RVA: 0x7FFE876B06C0
    }

    public class ServicePointManager : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<SPKey,System.Net.ServicePoint> servicePoints;
        public System.Net.ICertificatePolicy policy; // 0x8
        public int defaultConnectionLimit; // 0x10
        public int maxServicePointIdleTime; // 0x14
        public int maxServicePoints; // 0x18
        public int dnsRefreshTimeout; // 0x1C

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE876B0790
        public void get_CertificatePolicy(){} // RVA: 0x7FFE876B08F0
        public void set_CertificatePolicy(){} // RVA: 0x7FFE876B0A10
        public void GetLegacyCertificatePolicy(){} // RVA: 0x7FFE876B0AD0
        public void get_CheckCertificateRevocationList(){} // RVA: 0x7FFE876B0B30
        public void get_DnsRefreshTimeout(){} // RVA: 0x7FFE876B0B90
        public void get_SecurityProtocol(){} // RVA: 0x7FFE876B0BF0
        public void get_ServerCertValidationCallback(){} // RVA: 0x7FFE876B0C50
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7FFE876B0CB0
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7FFE876B0D40
        public void FindServicePoint(){} // RVA: 0x7FFE876B0ED0
        public void CloseConnectionGroup(){} // RVA: 0x7FFE876B19A0
        public void RemoveServicePoint(){} // RVA: 0x7FFE876B1D50
    }

    public class ServicePointScheduler : Object
    {
        public System.Net.ServicePoint _servicePoint; // 0x10
        public int running; // 0x18

        // ── Methods ──
        public void get_ServicePoint(){} // RVA: 0x7FFE81116380
        public void set_ServicePoint(){} // RVA: 0x7FFE810FCE30
        public void get_MaxIdleTime(){} // RVA: 0x7FFE82707EE0
        public void .ctor(){} // RVA: 0x7FFE876B20B0
        public void Run(){} // RVA: 0x7FFE876B2470
        public void RunScheduler(){} // RVA: 0x7FFE876B2580
        public void Cleanup(){} // RVA: 0x7FFE876B2740
        public void RunSchedulerIteration(){} // RVA: 0x7FFE876B2980
        public void OperationCompleted(){} // RVA: 0x7FFE876B2B90
        public void CloseIdleConnection(){} // RVA: 0x7FFE876B2E40
        public void SchedulerIteration(){} // RVA: 0x7FFE876B2E90
        public void RemoveOperation(){} // RVA: 0x7FFE876B30D0
        public void RemoveIdleConnection(){} // RVA: 0x7FFE876B31B0
        public void FinalCleanup(){} // RVA: 0x7FFE876B3290
        public void SendRequest(){} // RVA: 0x7FFE876B35F0
        public void CloseConnectionGroup(){} // RVA: 0x7FFE876B37B0
        public void GetConnectionGroup(){} // RVA: 0x7FFE876B3910
        public void OnConnectionCreated(){} // RVA: 0x7FFE876B3C90
        public void OnConnectionClosed(){} // RVA: 0x7FFE876B3CA0
        public void WaitAsync(){} // RVA: 0x7FFE876B3CC0
        public void <Run>b__31_0(){} // RVA: 0x7FFE876B2580
    }

    public class SocketAddress : Object
    {
        public int m_Size; // 0x10
        public byte[] m_Buffer; // 0x18
        public bool m_changed; // 0x20

        // ── Methods ──
        public void get_Family(){} // RVA: 0x7FFE87660620
        public void get_Size(){} // RVA: 0x7FFE811485C0
        public void get_Item(){} // RVA: 0x7FFE87660660
        public void .ctor(){} // RVA: 0x7FFE87660C20 | overloaded x3
        public void GetIPAddress(){} // RVA: 0x7FFE87660C80
        public void GetIPEndPoint(){} // RVA: 0x7FFE87660F50
        public void Equals(){} // RVA: 0x7FFE87661000
        public void GetHashCode(){} // RVA: 0x7FFE87661130
        public void ToString(){} // RVA: 0x7FFE87661250
    }

    public class SystemNetworkCredential : NetworkCredential
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8765B9F0
        public void .cctor(){} // RVA: 0x7FFE8765BA50
    }

}