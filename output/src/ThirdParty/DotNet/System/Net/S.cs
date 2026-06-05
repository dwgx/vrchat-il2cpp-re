// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 7
// Methods: 80

namespace ThirdParty.DotNet.System.Net
{
    public class ServerCertValidationCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95F5150
        public void get_ValidationCallback(){} // RVA: 0x7FFAF2DA8380
        public void Callback(){} // RVA: 0x7FFAF95F5260
        public void Invoke(){} // RVA: 0x7FFAF95F5310
    }

    public class ServiceNameStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95DE090
    }

    public class ServicePoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF961FDB0
        public void get_Key(){} // RVA: 0x7FFAF2E08D50
        public void get_Scheduler(){} // RVA: 0x7FFAF2E55590
        public void set_Scheduler(){} // RVA: 0x7FFAF2E555A0
        public void get_Address(){} // RVA: 0x7FFAF2DA8380
        public void get_ConnectionLimit(){} // RVA: 0x7FFAF4593800
        public void get_ProtocolVersion(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Expect100Continue(){} // RVA: 0x7FFAF2DB3480
        public void get_UseNagleAlgorithm(){} // RVA: 0x7FFAF2E48C00
        public void set_UseNagleAlgorithm(){} // RVA: 0x7FFAF2E48C10
        public void get_SendContinue(){} // RVA: 0x7FFAF961FFB0
        public void set_SendContinue(){} // RVA: 0x7FFAF2DB3480
        public void SetTcpKeepAlive(){} // RVA: 0x7FFAF9620070
        public void KeepAliveSetup(){} // RVA: 0x7FFAF9620160
        public void PutBytes(){} // RVA: 0x7FFAF9620410
        public void get_UsesProxy(){} // RVA: 0x7FFAF2DB3450
        public void set_UsesProxy(){} // RVA: 0x7FFAF2DB3460
        public void get_UseConnect(){} // RVA: 0x7FFAF6697520
        public void set_UseConnect(){} // RVA: 0x7FFAF8572490
        public void get_HasTimedOut(){} // RVA: 0x7FFAF9620480
        public void get_HostEntry(){} // RVA: 0x7FFAF9620600
        public void SetVersion(){} // RVA: 0x7FFAF2DBB0D0
        public void SendRequest(){} // RVA: 0x7FFAF9620CD0
        public void CloseConnectionGroup(){} // RVA: 0x7FFAF9620EC0
        public void FreeServicePoint(){} // RVA: 0x7FFAF96211B0
        public void UpdateServerCertificate(){} // RVA: 0x7FFAF9621210
        public void UpdateClientCertificate(){} // RVA: 0x7FFAF9621310
        public void CallEndPointDelegate(){} // RVA: 0x7FFAF9621410
    }

    public class ServicePointManager
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF96214E0
        public void get_CertificatePolicy(){} // RVA: 0x7FFAF9621640
        public void set_CertificatePolicy(){} // RVA: 0x7FFAF9621760
        public void GetLegacyCertificatePolicy(){} // RVA: 0x7FFAF9621820
        public void get_CheckCertificateRevocationList(){} // RVA: 0x7FFAF9621880
        public void get_DnsRefreshTimeout(){} // RVA: 0x7FFAF96218E0
        public void get_SecurityProtocol(){} // RVA: 0x7FFAF9621940
        public void get_ServerCertValidationCallback(){} // RVA: 0x7FFAF96219A0
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7FFAF9621A00
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7FFAF9621A90
        public void FindServicePoint(){} // RVA: 0x7FFAF9621C20
        public void CloseConnectionGroup(){} // RVA: 0x7FFAF96226F0
        public void RemoveServicePoint(){} // RVA: 0x7FFAF9622AA0
    }

    public class ServicePointScheduler
    {
        // ── Methods ──
        public void get_ServicePoint(){} // RVA: 0x7FFAF2DA8380
        public void set_ServicePoint(){} // RVA: 0x7FFAF2D8EE30
        public void get_MaxIdleTime(){} // RVA: 0x7FFAF442C3B0
        public void .ctor(){} // RVA: 0x7FFAF9622E00
        public void Run(){} // RVA: 0x7FFAF96231C0
        public void RunScheduler(){} // RVA: 0x7FFAF96232D0
        public void Cleanup(){} // RVA: 0x7FFAF9623490
        public void RunSchedulerIteration(){} // RVA: 0x7FFAF96236D0
        public void OperationCompleted(){} // RVA: 0x7FFAF96238E0
        public void CloseIdleConnection(){} // RVA: 0x7FFAF9623B90
        public void SchedulerIteration(){} // RVA: 0x7FFAF9623BE0
        public void RemoveOperation(){} // RVA: 0x7FFAF9623E20
        public void RemoveIdleConnection(){} // RVA: 0x7FFAF9623F00
        public void FinalCleanup(){} // RVA: 0x7FFAF9623FE0
        public void SendRequest(){} // RVA: 0x7FFAF9624340
        public void CloseConnectionGroup(){} // RVA: 0x7FFAF9624500
        public void GetConnectionGroup(){} // RVA: 0x7FFAF9624660
        public void OnConnectionCreated(){} // RVA: 0x7FFAF96249E0
        public void OnConnectionClosed(){} // RVA: 0x7FFAF96249F0
        public void WaitAsync(){} // RVA: 0x7FFAF9624A10
        public void <Run>b__31_0(){} // RVA: 0x7FFAF96232D0
    }

    public class SocketAddress
    {
        // ── Methods ──
        public void get_Family(){} // RVA: 0x7FFAF95D1360
        public void get_Size(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Item(){} // RVA: 0x7FFAF95D13A0
        public void .ctor(){} // RVA: 0x7FFAF95D1960 | overloaded x3
        public void GetIPAddress(){} // RVA: 0x7FFAF95D19C0
        public void GetIPEndPoint(){} // RVA: 0x7FFAF95D1C90
        public void Equals(){} // RVA: 0x7FFAF95D1D40
        public void GetHashCode(){} // RVA: 0x7FFAF95D1E70
        public void ToString(){} // RVA: 0x7FFAF95D1F90
    }

    public class SystemNetworkCredential
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95CC730
        public void .cctor(){} // RVA: 0x7FFAF95CC790
    }

}