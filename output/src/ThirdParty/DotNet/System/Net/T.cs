// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 3
// Methods: 20

namespace ThirdParty.DotNet.System.Net
{
    public class TcpValidationHelpers : Object
    {
        // ── Methods ──
        public void ValidatePortNumber(){} // RVA: 0x75841F0
    }

    public class TimerThread : Object
    {
        public object s_Queues;
        public object s_NewQueues;
        public object s_ThreadState;
        public object s_ThreadReadyEvent;
        public object s_ThreadShutdownEvent;
        public object s_ThreadEvents;
        public object s_CacheScanIteration;
        public object s_QueuesCache;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7592550
        public void CreateQueue(){} // RVA: 0x7592A90
        public void GetOrCreateQueue(){} // RVA: 0x7592D60
        public void Prod(){} // RVA: 0x75936D0
        public void ThreadProc(){} // RVA: 0x7593890
        public void StopTimerThread(){} // RVA: 0x7594110
        public void IsTickBetween(){} // RVA: 0x75941E0
        public void OnDomainUnload(){} // RVA: 0x7594200
    }

    public class TlsStream : NetworkStream
    {
        public object _sslStream;
        public object _host;
        public object _clientCertificates;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x772B050
        public void AuthenticateAsClient(){} // RVA: 0x772B230
        public void BeginAuthenticateAsClient(){} // RVA: 0x772B370
        public void EndAuthenticateAsClient(){} // RVA: 0x772B4C0
        public void BeginWrite(){} // RVA: 0x772B4F0
        public void EndWrite(){} // RVA: 0x772B530
        public void Write(){} // RVA: 0x772B560
        public void Read(){} // RVA: 0x772B590
        public void BeginRead(){} // RVA: 0x772B5C0
        public void EndRead(){} // RVA: 0x772B600
        public void Close(){} // RVA: 0x772B630
    }

}