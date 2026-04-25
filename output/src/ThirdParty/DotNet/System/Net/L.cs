// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 42

namespace ThirdParty.DotNet.System.Net
{
    public class LazyAsyncResult : Object
    {
        public ThreadContext CurrentThreadContext; // 0xFFFF
        public object AsyncObject; // 0x10
        public object AsyncState; // 0x18
        public System.AsyncCallback AsyncCallback; // 0x20
        public object AsyncWaitHandle; // 0x28
        public int CompletedSynchronously; // 0x30
        public bool IsCompleted; // 0x34
        public bool InternalPeekCompleted; // 0x35
        public object EndCalled; // 0x38

        // ── Methods ──
        public void get_CurrentThreadContext(){} // RVA: 0x7FFAC92C39F0
        public void .ctor(){} // RVA: 0x7FFAC92C3B00
        public void get_AsyncObject(){} // RVA: 0x7FFAC2F3C380
        public void get_AsyncState(){} // RVA: 0x7FFAC2F247C0
        public void get_AsyncCallback(){} // RVA: 0x7FFAC2F4F0C0
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFAC92C3CD0
        public void LazilyCreateEvent(){} // RVA: 0x7FFAC92C3D70
        public void get_CompletedSynchronously(){} // RVA: 0x7FFAC92C3FD0
        public void get_IsCompleted(){} // RVA: 0x7FFAC92C3FF0
        public void get_InternalPeekCompleted(){} // RVA: 0x7FFAC92C4020
        public void get_EndCalled(){} // RVA: 0x7FFAC2F57C20
        public void set_EndCalled(){} // RVA: 0x7FFAC2F5BAC0
        public void ProtectedInvokeCallback(){} // RVA: 0x7FFAC92C4030
        public void InvokeCallback(){} // RVA: 0x7FFAC92C41E0 | overloaded x2
        public void Complete(){} // RVA: 0x7FFAC92C41F0
        public void WorkerThreadComplete(){} // RVA: 0x7FFAC92C44F0
        public void Cleanup(){} // RVA: 0x7FFAC2F21310
        public void InternalWaitForCompletion(){} // RVA: 0x7FFAC92C4580
        public void WaitForCompletion(){} // RVA: 0x7FFAC92C4590
    }

    public class ListenerAsyncResult : Object
    {
        public System.Threading.ManualResetEvent AsyncState; // 0x10
        public bool AsyncWaitHandle; // 0x18
        public bool CompletedSynchronously; // 0x19
        public System.AsyncCallback IsCompleted; // 0x20
        public object state; // 0x28
        public System.Exception exception; // 0x30
        public System.Net.HttpListenerContext context; // 0x38
        public object locker; // 0x40
        public System.Net.ListenerAsyncResult forward; // 0x48
        public bool EndCalled; // 0x50
        public bool InGet; // 0x51
        public System.Threading.WaitCallback InvokeCB;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9300500
        public void Complete(){} // RVA: 0x7FFAC9300A00 | overloaded x3
        public void InvokeCallback(){} // RVA: 0x7FFAC9300920
        public void GetContext(){} // RVA: 0x7FFAC93011A0
        public void get_AsyncState(){} // RVA: 0x7FFAC9301200
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFAC9301220
        public void get_CompletedSynchronously(){} // RVA: 0x7FFAC9301460
        public void get_IsCompleted(){} // RVA: 0x7FFAC9301480
        public void .cctor(){} // RVA: 0x7FFAC93015E0
    }

    public class ListenerPrefix : Object
    {
        public string Secure; // 0x10
        public string Host; // 0x18
        public ushort Port; // 0x20
        public string Path; // 0x28
        public bool secure; // 0x30
        public System.Net.IPAddress[] addresses; // 0x38
        public System.Net.HttpListener Listener; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93016C0
        public void ToString(){} // RVA: 0x7FFAC2F3C380
        public void get_Secure(){} // RVA: 0x7FFAC2F47450
        public void get_Host(){} // RVA: 0x7FFAC2F247C0
        public void get_Port(){} // RVA: 0x7FFAC6D68C80
        public void get_Path(){} // RVA: 0x7FFAC2F4F130
        public void Equals(){} // RVA: 0x7FFAC9301720
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
        public void Parse(){} // RVA: 0x7FFAC93017D0
        public void CheckUri(){} // RVA: 0x7FFAC9301C10
    }

    public class Logging : Object
    {
        public object On;

        // ── Methods ──
        public void get_On(){} // RVA: 0x7FFAC2F21320
    }

}