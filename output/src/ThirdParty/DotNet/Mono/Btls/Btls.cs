// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Btls
// Classes: 1
// Methods: 30

namespace ThirdParty.DotNet.Mono.Btls
{
    public class MonoBtlsContext : MobileTlsContext
    {
        public 0x66491C78 IsAuthenticated; // 0x58
        public 0x6642DEB8 LocalClientCertificate; // 0x60
        public 0x6648E788 RemoteCertificate; // 0x68
        public 0x6648E788 nativeClientCertificate; // 0x70
        public 0x6648DCE0 ctx; // 0x78
        public 0x6648DB28 ssl; // 0x80
        public 0x6648D340 bio; // 0x88
        public 0x6648D340 errbio; // 0x90
        public 0x665E4808 connectionInfo; // 0x98
        public bool certificateValidated; // 0xA0
        public bool isAuthenticated; // 0xA1
        public bool connected; // 0xA2

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5424F2B0
        public void GetPrivateCertificate(){} // RVA: 0x7FFD5424F330
        public void VerifyCallback(){} // RVA: 0x7FFD5424F5D0
        public void SelectCallback(){} // RVA: 0x7FFD5424F7F0
        public void ServerNameCallback(){} // RVA: 0x7FFD5424F960
        public void StartHandshake(){} // RVA: 0x7FFD5424FA20
        public void SetPrivateCertificate(){} // RVA: 0x7FFD5424FDC0
        public void GetException(){} // RVA: 0x7FFD54250420
        public void ProcessHandshake(){} // RVA: 0x7FFD54250A80
        public void DoProcessHandshake(){} // RVA: 0x7FFD54250BC0
        public void FinishHandshake(){} // RVA: 0x7FFD54250DC0
        public void InitializeConnection(){} // RVA: 0x7FFD54250DE0
        public void GetPeerCertificate(){} // RVA: 0x7FFD542518B0
        public void InitializeSession(){} // RVA: 0x7FFD54251B60
        public void GetProtocol(){} // RVA: 0x7FFD54251F30
        public void Flush(){} // RVA: 0x7FFD54251FB0
        public void Read(){} // RVA: 0x7FFD54251FF0
        public void Write(){} // RVA: 0x7FFD54252370
        public void Renegotiate(){} // RVA: 0x7FFD542526A0
        public void Shutdown(){} // RVA: 0x7FFD542526E0
        public void PendingRenegotiation(){} // RVA: 0x7FFD54252890
        public void Dispose(){} // RVA: 0x7FFD54252940 | overloaded x2
        public void Mono.Btls.IMonoBtlsBioMono.Read(){} // RVA: 0x7FFD54252AC0
        public void Mono.Btls.IMonoBtlsBioMono.Write(){} // RVA: 0x7FFD54252AF0
        public void Mono.Btls.IMonoBtlsBioMono.Flush(){} // RVA: 0x7FFD4E341310
        public void Mono.Btls.IMonoBtlsBioMono.Close(){} // RVA: 0x7FFD4E341310
        public void get_IsAuthenticated(){} // RVA: 0x7FFD4FC68B60
        public void get_LocalClientCertificate(){} // RVA: 0x7FFD4E3DF370
        public void get_RemoteCertificate(){} // RVA: 0x7FFD4E409500
    }

}