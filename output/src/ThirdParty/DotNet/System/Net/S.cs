// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 7
// Methods: 78

namespace ThirdParty.DotNet.System.Net
{
    public class ServerCertValidationCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE935360
        public void get_ValidationCallback(){} // RVA: 0x7A80F2570
        public void Callback(){} // RVA: 0x7AE935470
        public void Invoke(){} // RVA: 0x7AE935520
    }

    public class ServiceNameStore : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE91ED20
    }

    public class ServicePoint : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE95F2A0
        public void get_Key(){} // RVA: 0x7A8153390
        public void get_Scheduler(){} // RVA: 0x7A81A00E0
        public void set_Scheduler(){} // RVA: 0x7A81A00F0
        public void get_Address(){} // RVA: 0x7A80F2570
        public void get_ConnectionLimit(){} // RVA: 0x7A989D5C0
        public void get_ProtocolVersion(){} // RVA: 0x7A81052C0
        public void set_Expect100Continue(){} // RVA: 0x7A80FD6C0
        public void get_UseNagleAlgorithm(){} // RVA: 0x7A8193790
        public void set_UseNagleAlgorithm(){} // RVA: 0x7A81937A0
        public void get_SendContinue(){} // RVA: 0x7AE95F4B0
        public void set_SendContinue(){} // RVA: 0x7A80FD6C0
        public void SetTcpKeepAlive(){} // RVA: 0x7AE95F570
        public void KeepAliveSetup(){} // RVA: 0x7AE95F660
        public void PutBytes(){} // RVA: 0x7AE95F910
        public void get_UsesProxy(){} // RVA: 0x7A80FD690
        public void set_UsesProxy(){} // RVA: 0x7A80FD6A0
        public void get_UseConnect(){} // RVA: 0x7AB9DF6A0
        public void set_UseConnect(){} // RVA: 0x7AD8AFA40
        public void get_HasTimedOut(){} // RVA: 0x7AE95F980
        public void get_HostEntry(){} // RVA: 0x7AE95FB00
        public void SetVersion(){} // RVA: 0x7A81052D0
        public void SendRequest(){} // RVA: 0x7AE960190
        public void CloseConnectionGroup(){} // RVA: 0x7AE960350
        public void FreeServicePoint(){} // RVA: 0x7AE960610
        public void UpdateServerCertificate(){} // RVA: 0x7AE960670
        public void UpdateClientCertificate(){} // RVA: 0x7AE960770
        public void CallEndPointDelegate(){} // RVA: 0x7AE960870
    }

    public class ServicePointManager : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE960950
        public void get_CertificatePolicy(){} // RVA: 0x7AE960AB0
        public void set_CertificatePolicy(){} // RVA: 0x7AE960BD0
        public void GetLegacyCertificatePolicy(){} // RVA: 0x7AE960C90
        public void get_CheckCertificateRevocationList(){} // RVA: 0x7AE960CF0
        public void get_DnsRefreshTimeout(){} // RVA: 0x7AE960D50
        public void get_SecurityProtocol(){} // RVA: 0x7AE960DB0
        public void get_ServerCertValidationCallback(){} // RVA: 0x7AE960E10
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7AE960E70
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7AE960F00
        public void FindServicePoint(){} // RVA: 0x7AE961090
        public void CloseConnectionGroup(){} // RVA: 0x7AE961B40
        public void RemoveServicePoint(){} // RVA: 0x7AE961EC0
    }

    public class ServicePointScheduler : Object
    {
        // ── Methods ──
        public void get_ServicePoint(){} // RVA: 0x7A80F2570
        public void set_ServicePoint(){} // RVA: 0x7A80D8E20
        public void get_MaxIdleTime(){} // RVA: 0x7A9739200
        public void .ctor(){} // RVA: 0x7AE962210
        public void Run(){} // RVA: 0x7AE9625F0
        public void RunScheduler(){} // RVA: 0x7AE962700
        public void Cleanup(){} // RVA: 0x7AE9628C0
        public void RunSchedulerIteration(){} // RVA: 0x7AE962B00
        public void OperationCompleted(){} // RVA: 0x7AE962D10
        public void CloseIdleConnection(){} // RVA: 0x7AE962FB0
        public void SchedulerIteration(){} // RVA: 0x7AE963000
        public void RemoveOperation(){} // RVA: 0x7AE963230
        public void RemoveIdleConnection(){} // RVA: 0x7AE963310
        public void FinalCleanup(){} // RVA: 0x7AE9633F0
        public void SendRequest(){} // RVA: 0x7AE963750
        public void CloseConnectionGroup(){} // RVA: 0x7AE9638D0
        public void GetConnectionGroup(){} // RVA: 0x7AE963A30
        public void OnConnectionCreated(){} // RVA: 0x7AE963D70
        public void OnConnectionClosed(){} // RVA: 0x7AE963D80
        public void WaitAsync(){} // RVA: 0x7AE963DA0
        public void <Run>b__31_0(){} // RVA: 0x7AE962700
    }

    public class SocketAddress : Object
    {
        // ── Methods ──
        public void get_Family(){} // RVA: 0x7AE912030
        public void get_Size(){} // RVA: 0x7A8124910
        public void get_Item(){} // RVA: 0x7AE912070
        public void .ctor(){} // RVA: 0x7AE912610
        public void GetIPAddress(){} // RVA: 0x7AE912670
        public void GetIPEndPoint(){} // RVA: 0x7AE912940
        public void Equals(){} // RVA: 0x7AE9129F0
        public void GetHashCode(){} // RVA: 0x7AE912B30
        public void ToString(){} // RVA: 0x7AE912C70
    }

    public class SystemNetworkCredential : NetworkCredential
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE90D190
        public void .cctor(){} // RVA: 0x7AE90D1F0
    }

}