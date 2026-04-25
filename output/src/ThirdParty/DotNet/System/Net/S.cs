// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 7
// Methods: 80

namespace ThirdParty.DotNet.System.Net
{
    public class ServerCertValidationCallback : Object
    {
        public System.Net.Security.RemoteCertificateValidationCallback ValidationCallback; // 0x10
        public System.Threading.ExecutionContext m_Context; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92DBCD0
        public void get_ValidationCallback(){} // RVA: 0x7FFAC2F3C380
        public void Callback(){} // RVA: 0x7FFAC92DBDE0
        public void Invoke(){} // RVA: 0x7FFAC92DBE90
    }

    public class ServiceNameStore : Object
    {
        public System.Collections.Generic.List`1<string> serviceNames; // 0x10
        public System.Security.Authentication.ExtendedProtection.ServiceNameCollection serviceNameCollection; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92C4C10
    }

    public class ServicePoint : Object
    {
        public System.Uri Key; // 0x10
        public System.DateTime Scheduler; // 0x18
        public System.Version Address; // 0x20
        public System.Net.IPHostEntry ConnectionLimit; // 0x28
        public bool ProtocolVersion; // 0x30
        public bool Expect100Continue; // 0x31
        public bool UseNagleAlgorithm; // 0x32
        public object SendContinue; // 0x38
        public bool UsesProxy; // 0x40
        public System.Net.BindIPEndPoint UseConnect; // 0x48
        public bool HasTimedOut; // 0x50
        public int HostEntry; // 0x54
        public int tcp_keepalive_interval; // 0x58
        public bool disposed; // 0x5C
        public int connectionLeaseTimeout; // 0x60
        public int receiveBufferSize; // 0x64
        public SPKey <Key>k__BackingField; // 0x68
        public System.Net.ServicePointScheduler <Scheduler>k__BackingField; // 0x70
        public int connectionLimit; // 0x78
        public int maxIdleTime; // 0x7C
        public object m_ServerCertificateOrBytes; // 0x80
        public object m_ClientCertificateOrBytes; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9306930
        public void get_Key(){} // RVA: 0x7FFAC2F9CD50
        public void get_Scheduler(){} // RVA: 0x7FFAC2FE9590
        public void set_Scheduler(){} // RVA: 0x7FFAC2FE95A0
        public void get_Address(){} // RVA: 0x7FFAC2F3C380
        public void get_ConnectionLimit(){} // RVA: 0x7FFAC4596EF0
        public void get_ProtocolVersion(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Expect100Continue(){} // RVA: 0x7FFAC2F47480
        public void get_UseNagleAlgorithm(){} // RVA: 0x7FFAC2FDCC00
        public void set_UseNagleAlgorithm(){} // RVA: 0x7FFAC2FDCC10
        public void get_SendContinue(){} // RVA: 0x7FFAC9306B30
        public void set_SendContinue(){} // RVA: 0x7FFAC2F47480
        public void SetTcpKeepAlive(){} // RVA: 0x7FFAC9306BF0
        public void KeepAliveSetup(){} // RVA: 0x7FFAC9306CE0
        public void PutBytes(){} // RVA: 0x7FFAC9306F90
        public void get_UsesProxy(){} // RVA: 0x7FFAC2F47450
        public void set_UsesProxy(){} // RVA: 0x7FFAC2F47460
        public void get_UseConnect(){} // RVA: 0x7FFAC64EB050
        public void set_UseConnect(){} // RVA: 0x7FFAC8259980
        public void get_HasTimedOut(){} // RVA: 0x7FFAC9307000
        public void get_HostEntry(){} // RVA: 0x7FFAC9307180
        public void SetVersion(){} // RVA: 0x7FFAC2F4F0D0
        public void SendRequest(){} // RVA: 0x7FFAC9307850
        public void CloseConnectionGroup(){} // RVA: 0x7FFAC9307A40
        public void FreeServicePoint(){} // RVA: 0x7FFAC9307D30
        public void UpdateServerCertificate(){} // RVA: 0x7FFAC9307D90
        public void UpdateClientCertificate(){} // RVA: 0x7FFAC9307E90
        public void CallEndPointDelegate(){} // RVA: 0x7FFAC9307F90
    }

    public class ServicePointManager : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<SPKey,System.Net.ServicePoint> CertificatePolicy;
        public System.Net.ICertificatePolicy CheckCertificateRevocationList; // 0x8
        public int DnsRefreshTimeout; // 0x10
        public int SecurityProtocol; // 0x14
        public int ServerCertValidationCallback; // 0x18
        public int ServerCertificateValidationCallback; // 0x1C
        public bool _checkCRL; // 0x20
        public 0x6B13A758 _securityProtocol; // 0x24
        public bool expectContinue; // 0x28
        public bool useNagle; // 0x29
        public System.Net.ServerCertValidationCallback server_cert_cb; // 0x30
        public bool tcp_keepalive; // 0x38
        public int tcp_keepalive_time; // 0x3C
        public int tcp_keepalive_interval; // 0x40

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9308060
        public void get_CertificatePolicy(){} // RVA: 0x7FFAC93081C0
        public void set_CertificatePolicy(){} // RVA: 0x7FFAC93082E0
        public void GetLegacyCertificatePolicy(){} // RVA: 0x7FFAC93083A0
        public void get_CheckCertificateRevocationList(){} // RVA: 0x7FFAC9308400
        public void get_DnsRefreshTimeout(){} // RVA: 0x7FFAC9308460
        public void get_SecurityProtocol(){} // RVA: 0x7FFAC93084C0
        public void get_ServerCertValidationCallback(){} // RVA: 0x7FFAC9308520
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7FFAC9308580
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7FFAC9308610
        public void FindServicePoint(){} // RVA: 0x7FFAC93087A0
        public void CloseConnectionGroup(){} // RVA: 0x7FFAC9309270
        public void RemoveServicePoint(){} // RVA: 0x7FFAC9309620
    }

    public class ServicePointScheduler : Object
    {
        public System.Net.ServicePoint ServicePoint; // 0x10
        public int MaxIdleTime; // 0x18
        public int maxIdleTime; // 0x1C
        public AsyncManualResetEvent schedulerEvent; // 0x20
        public ConnectionGroup defaultGroup; // 0x28
        public System.Collections.Generic.Dictionary`2<string,ConnectionGroup> groups; // 0x30
        public System.Collections.Generic.LinkedList`1<System.ValueTuple`2<ConnectionGroup,System.Net.WebOperation>> operations; // 0x38
        public System.Collections.Generic.LinkedList`1<System.ValueTuple`3<ConnectionGroup,System.Net.WebConnection,System.Threading.Tasks.Task>> idleConnections; // 0x40
        public int currentConnections; // 0x48
        public int connectionLimit; // 0x4C
        public System.DateTime idleSince; // 0x50
        public int nextId;
        public int ID; // 0x58
        public string <ME>k__BackingField; // 0x60

        // ── Methods ──
        public void get_ServicePoint(){} // RVA: 0x7FFAC2F3C380
        public void set_ServicePoint(){} // RVA: 0x7FFAC2F22E30
        public void get_MaxIdleTime(){} // RVA: 0x7FFAC44357F0
        public void .ctor(){} // RVA: 0x7FFAC9309980
        public void Run(){} // RVA: 0x7FFAC9309D40
        public void RunScheduler(){} // RVA: 0x7FFAC9309E50
        public void Cleanup(){} // RVA: 0x7FFAC930A010
        public void RunSchedulerIteration(){} // RVA: 0x7FFAC930A250
        public void OperationCompleted(){} // RVA: 0x7FFAC930A460
        public void CloseIdleConnection(){} // RVA: 0x7FFAC930A710
        public void SchedulerIteration(){} // RVA: 0x7FFAC930A760
        public void RemoveOperation(){} // RVA: 0x7FFAC930A9A0
        public void RemoveIdleConnection(){} // RVA: 0x7FFAC930AA80
        public void FinalCleanup(){} // RVA: 0x7FFAC930AB60
        public void SendRequest(){} // RVA: 0x7FFAC930AEC0
        public void CloseConnectionGroup(){} // RVA: 0x7FFAC930B080
        public void GetConnectionGroup(){} // RVA: 0x7FFAC930B1E0
        public void OnConnectionCreated(){} // RVA: 0x7FFAC930B560
        public void OnConnectionClosed(){} // RVA: 0x7FFAC930B570
        public void WaitAsync(){} // RVA: 0x7FFAC930B590
        public void <Run>b__31_0(){} // RVA: 0x7FFAC9309E50
    }

    public class SocketAddress : Object
    {
        public int Family; // 0x10
        public byte[] Size; // 0x18
        public bool Item; // 0x20
        public int m_hash; // 0x24

        // ── Methods ──
        public void get_Family(){} // RVA: 0x7FFAC92B7EE0
        public void get_Size(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Item(){} // RVA: 0x7FFAC92B7F20
        public void .ctor(){} // RVA: 0x7FFAC92B84E0 | overloaded x3
        public void GetIPAddress(){} // RVA: 0x7FFAC92B8540
        public void GetIPEndPoint(){} // RVA: 0x7FFAC92B8810
        public void Equals(){} // RVA: 0x7FFAC92B88C0
        public void GetHashCode(){} // RVA: 0x7FFAC92B89F0
        public void ToString(){} // RVA: 0x7FFAC92B8B10
    }

    public class SystemNetworkCredential : NetworkCredential
    {
        public System.Net.SystemNetworkCredential defaultCredential;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92B32B0
        public void .cctor(){} // RVA: 0x7FFAC92B3310
    }

}