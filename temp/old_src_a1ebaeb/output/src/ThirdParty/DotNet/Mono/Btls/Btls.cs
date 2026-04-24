// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Btls
// Classes: 1
// Methods: 30

namespace ThirdParty.DotNet.Mono.Btls
{
    public class MonoBtlsContext : MobileTlsContext
    {
        public object nativeServerCertificate; // 0x31831940
        public object ssl; // 0x31831940
        public object connectionInfo; // 0x31831940
        public object connected; // 0x31831940
        public object IsAuthenticated; // 0x17000062
        public object LocalClientCertificate; // 0x17000063
        public object RemoteCertificate; // 0x17000064

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae851230
        public void VerifyCallback(){} // RVA: 0x7ffaae851550
        public void SelectCallback(){} // RVA: 0x7ffaae851770
        public void ServerNameCallback(){} // RVA: 0x7ffaae8518e0
        public void StartHandshake(){} // RVA: 0x7ffaae8519a0
        public void ProcessHandshake(){} // RVA: 0x7ffaae852a00
        public void FinishHandshake(){} // RVA: 0x7ffaae852d40
        public void InitializeConnection(){} // RVA: 0x7ffaae852d60
        public void InitializeSession(){} // RVA: 0x7ffaae853ae0
        public void Flush(){} // RVA: 0x7ffaae853f30
        public void Read(){} // RVA: 0x7ffaae853f70
        public void Write(){} // RVA: 0x7ffaae8542f0
        public void Renegotiate(){} // RVA: 0x7ffaae854620
        public void Shutdown(){} // RVA: 0x7ffaae854660
        public void PendingRenegotiation(){} // RVA: 0x7ffaae854810
        public void Dispose(){} // RVA: 0x7ffaae8548c0
        public void Dispose(){} // RVA: 0x7ffaae8548c0
        public void Mono.Btls.IMonoBtlsBioMono.Read(){} // RVA: 0x7ffaae854a40
        public void Mono.Btls.IMonoBtlsBioMono.Write(){} // RVA: 0x7ffaae854a70
        public void Mono.Btls.IMonoBtlsBioMono.Flush(){} // RVA: 0x7ffaa8932310
        public void Mono.Btls.IMonoBtlsBioMono.Close(){} // RVA: 0x7ffaa8932310
        public void get_IsAuthenticated(){} // RVA: 0x7ffaaa250a70
        public void get_LocalClientCertificate(){} // RVA: 0x7ffaa89d0370
        public void get_RemoteCertificate(){} // RVA: 0x7ffaa89fa500
        // ── Binary Analysis Named ──
        public void GetPrivateCertificate(){} // RVA: 0x7ffaae8512b0
        public void SetPrivateCertificate(){} // RVA: 0x7ffaae851d40
        public void GetException(){} // RVA: 0x7ffaae8523a0
        public void DoProcessHandshake(){} // RVA: 0x7ffaae852b40
        public void GetPeerCertificate(){} // RVA: 0x7ffaae853830
        public void GetProtocol(){} // RVA: 0x7ffaae853eb0
    }

}