// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Net.Security
// Classes: 1
// Methods: 31

namespace ThirdParty.DotNet.Mono.Net.Security
{
    public class MobileTlsContext : Object
    {
        public object Options;
        public object Parent;
        public object Settings;
        public object IsAuthenticated;
        public object IsServer;
        public object TargetHost;
        public object ServerName;
        public object AskForClientCertificate;
        public object EnabledProtocols;
        public object ClientCertificates;
        public object LocalServerCertificate;
        public object LocalClientCertificate;
        public object RemoteCertificate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54247E30
        public void get_Options(){} // RVA: 0x7FFD4E3447C0
        public void get_Parent(){} // RVA: 0x7FFD4E36F0C0
        public void get_Settings(){} // RVA: 0x7FFD54248290
        public void get_IsAuthenticated(){} // RVA: 0x7FFD4E079D00
        public void get_IsServer(){} // RVA: 0x7FFD4E516BA0
        public void get_TargetHost(){} // RVA: 0x7FFD4E5F95E0
        public void get_ServerName(){} // RVA: 0x7FFD4E5F0140
        public void get_AskForClientCertificate(){} // RVA: 0x7FFD4E3FCC00
        public void get_EnabledProtocols(){} // RVA: 0x7FFD4E3E20A0
        public void get_ClientCertificates(){} // RVA: 0x7FFD4E3BC730
        public void GetProtocolVersions(){} // RVA: 0x7FFD542482B0
        public void StartHandshake(){} // RVA: 0x7FFD4E090980
        public void ProcessHandshake(){} // RVA: 0x7FFD4E079D00
        public void FinishHandshake(){} // RVA: 0x7FFD4E090980
        public void get_LocalServerCertificate(){} // RVA: 0x7FFD4E3E20E0
        public void set_LocalServerCertificate(){} // RVA: 0x7FFD4E4994D0
        public void get_LocalClientCertificate(){} // RVA: 0x7FFD4E078E90
        public void get_RemoteCertificate(){} // RVA: 0x7FFD4E078E90
        public void Flush(){} // RVA: 0x7FFD4E090980
        public void Read(){}
        public void Write(){}
        public void Shutdown(){} // RVA: 0x7FFD4E090980
        public void PendingRenegotiation(){} // RVA: 0x7FFD4E079D00
        public void ValidateCertificate(){} // RVA: 0x7FFD542483B0
        public void SelectServerCertificate(){} // RVA: 0x7FFD54248410
        public void SelectClientCertificate(){} // RVA: 0x7FFD54248730
        public void Renegotiate(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD54248E60
    }

}