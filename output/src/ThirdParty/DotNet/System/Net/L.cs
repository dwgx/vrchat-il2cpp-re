// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 42

namespace ThirdParty.DotNet.System.Net
{
    public class LazyAsyncResult : Object
    {
        public ThreadContext t_ThreadContext; // 0xFFFF
        public object m_AsyncObject; // 0x10
        public object m_AsyncState; // 0x18
        public System.AsyncCallback m_AsyncCallback; // 0x20
        public object m_Result; // 0x28
        public int m_IntCompleted; // 0x30
        public bool m_EndCalled; // 0x34
        public bool m_UserEvent; // 0x35
        public object m_Event; // 0x38

        // ── Methods ──
        public void get_CurrentThreadContext(){} // RVA: 0x7FFE8766C130
        public void .ctor(){} // RVA: 0x7FFE8766C240
        public void get_AsyncObject(){} // RVA: 0x7FFE81116380
        public void get_AsyncState(){} // RVA: 0x7FFE810FE7C0
        public void get_AsyncCallback(){} // RVA: 0x7FFE811290C0
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFE8766C410
        public void LazilyCreateEvent(){} // RVA: 0x7FFE8766C4B0
        public void get_CompletedSynchronously(){} // RVA: 0x7FFE8766C710
        public void get_IsCompleted(){} // RVA: 0x7FFE8766C730
        public void get_InternalPeekCompleted(){} // RVA: 0x7FFE8766C760
        public void get_EndCalled(){} // RVA: 0x7FFE81131C20
        public void set_EndCalled(){} // RVA: 0x7FFE81135AC0
        public void ProtectedInvokeCallback(){} // RVA: 0x7FFE8766C770
        public void InvokeCallback(){} // RVA: 0x7FFE8766C920 | overloaded x2
        public void Complete(){} // RVA: 0x7FFE8766C930
        public void WorkerThreadComplete(){} // RVA: 0x7FFE8766CC30
        public void Cleanup(){} // RVA: 0x7FFE810FB310
        public void InternalWaitForCompletion(){} // RVA: 0x7FFE8766CCC0
        public void WaitForCompletion(){} // RVA: 0x7FFE8766CCD0
    }

    public class ListenerAsyncResult : Object
    {
        public System.Threading.ManualResetEvent handle; // 0x10
        public bool synch; // 0x18
        public bool completed; // 0x19
        public System.AsyncCallback cb; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876A8C30
        public void Complete(){} // RVA: 0x7FFE876A9130 | overloaded x3
        public void InvokeCallback(){} // RVA: 0x7FFE876A9050
        public void GetContext(){} // RVA: 0x7FFE876A98D0
        public void get_AsyncState(){} // RVA: 0x7FFE876A9930
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFE876A9950
        public void get_CompletedSynchronously(){} // RVA: 0x7FFE876A9B90
        public void get_IsCompleted(){} // RVA: 0x7FFE876A9BB0
        public void .cctor(){} // RVA: 0x7FFE876A9D10
    }

    public class ListenerPrefix : Object
    {
        public string original; // 0x10
        public string host; // 0x18
        public ushort port; // 0x20
        public string path; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876A9DF0
        public void ToString(){} // RVA: 0x7FFE81116380
        public void get_Secure(){} // RVA: 0x7FFE81121450
        public void get_Host(){} // RVA: 0x7FFE810FE7C0
        public void get_Port(){} // RVA: 0x7FFE850EF1D0
        public void get_Path(){} // RVA: 0x7FFE81129130
        public void Equals(){} // RVA: 0x7FFE876A9E50
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
        public void Parse(){} // RVA: 0x7FFE876A9F00
        public void CheckUri(){} // RVA: 0x7FFE876AA340
    }

    public class Logging : Object
    {
        // ── Methods ──
        public void get_On(){} // RVA: 0x7FFE810FB320
    }

}