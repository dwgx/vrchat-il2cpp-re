// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 20

namespace ThirdParty.DotNet.System.Net
{
    public class TcpValidationHelpers : Object
    {
        // ── Methods ──
        public void ValidatePortNumber(){} // RVA: 0x7FFAC92B6760
    }

    public class TimerThread : Object
    {
        public System.Collections.Generic.LinkedList`1<System.WeakReference> s_Queues;
        public System.Collections.Generic.LinkedList`1<System.WeakReference> s_NewQueues; // 0x8
        public int s_ThreadState; // 0x10
        public System.Threading.AutoResetEvent s_ThreadReadyEvent; // 0x18
        public System.Threading.ManualResetEvent s_ThreadShutdownEvent; // 0x20
        public System.Threading.WaitHandle[] s_ThreadEvents; // 0x28
        public int s_CacheScanIteration; // 0x30
        public System.Collections.Hashtable s_QueuesCache; // 0x38

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC92C4D30
        public void CreateQueue(){} // RVA: 0x7FFAC92C5270
        public void GetOrCreateQueue(){} // RVA: 0x7FFAC92C5570
        public void Prod(){} // RVA: 0x7FFAC92C5F20
        public void ThreadProc(){} // RVA: 0x7FFAC92C60E0
        public void StopTimerThread(){} // RVA: 0x7FFAC92C69A0
        public void IsTickBetween(){} // RVA: 0x7FFAC92C6A70
        public void OnDomainUnload(){} // RVA: 0x7FFAC92C6AA0
    }

    public class TlsStream : NetworkStream
    {
        public System.Net.Security.SslStream _sslStream; // 0x48
        public string _host; // 0x50
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9464EB0
        public void AuthenticateAsClient(){} // RVA: 0x7FFAC9465080
        public void BeginAuthenticateAsClient(){} // RVA: 0x7FFAC94651C0
        public void EndAuthenticateAsClient(){} // RVA: 0x7FFAC9465310
        public void BeginWrite(){} // RVA: 0x7FFAC9465340
        public void EndWrite(){} // RVA: 0x7FFAC9465380
        public void Write(){} // RVA: 0x7FFAC94653B0
        public void Read(){} // RVA: 0x7FFAC94653E0
        public void BeginRead(){} // RVA: 0x7FFAC9465410
        public void EndRead(){} // RVA: 0x7FFAC9465450
        public void Close(){} // RVA: 0x7FFAC9465480
    }

    public class TransportContext : Object
    {
    }

}