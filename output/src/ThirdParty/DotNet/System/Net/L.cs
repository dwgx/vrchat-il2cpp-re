// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 42

namespace ThirdParty.DotNet.System.Net
{
    public class LazyAsyncResult
    {
        public ThreadContext t_ThreadContext; // 0xFFFFFFFF
        public object m_AsyncObject; // 0x10
        public object m_AsyncState; // 0x18
        public System.AsyncCallback m_AsyncCallback; // 0x20
        public object m_Result; // 0x28
        public int m_IntCompleted; // 0x30
        public bool m_EndCalled; // 0x34
        public bool m_UserEvent; // 0x35
        public object m_Event; // 0x38

        // ── Methods ──
        public void get_CurrentThreadContext(){} // RVA: 0x6B2CE70
        public void .ctor(){} // RVA: 0x6B2CF80
        public void get_AsyncObject(){} // RVA: 0x2F8380
        public void get_AsyncState(){} // RVA: 0x2E07C0
        public void get_AsyncCallback(){} // RVA: 0x30B0C0
        public void get_AsyncWaitHandle(){} // RVA: 0x6B2D150
        public void LazilyCreateEvent(){} // RVA: 0x6B2D1F0
        public void get_CompletedSynchronously(){} // RVA: 0x6B2D450
        public void get_IsCompleted(){} // RVA: 0x6B2D470
        public void get_InternalPeekCompleted(){} // RVA: 0x6B2D4A0
        public void get_EndCalled(){} // RVA: 0x313C20
        public void set_EndCalled(){} // RVA: 0x317AC0
        public void ProtectedInvokeCallback(){} // RVA: 0x6B2D4B0
        public void InvokeCallback(){} // RVA: 0x6B2D660 | overloaded x2
        public void Complete(){} // RVA: 0x6B2D670
        public void WorkerThreadComplete(){} // RVA: 0x6B2D970
        public void Cleanup(){} // RVA: 0x2DD310
        public void InternalWaitForCompletion(){} // RVA: 0x6B2DA00
        public void WaitForCompletion(){} // RVA: 0x6B2DA10
    }

    public class ListenerAsyncResult
    {
        public System.Threading.ManualResetEvent handle; // 0x10
        public bool synch; // 0x18
        public bool completed; // 0x19
        public System.AsyncCallback cb; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B69980
        public void Complete(){} // RVA: 0x6B69E80 | overloaded x3
        public void InvokeCallback(){} // RVA: 0x6B69DA0
        public void GetContext(){} // RVA: 0x6B6A620
        public void get_AsyncState(){} // RVA: 0x6B6A680
        public void get_AsyncWaitHandle(){} // RVA: 0x6B6A6A0
        public void get_CompletedSynchronously(){} // RVA: 0x6B6A8E0
        public void get_IsCompleted(){} // RVA: 0x6B6A900
        public void .cctor(){} // RVA: 0x6B6AA60
    }

    public class ListenerPrefix
    {
        public string original; // 0x10
        public string host; // 0x18
        public ushort port; // 0x20
        public string path; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B6AB40
        public void ToString(){} // RVA: 0x2F8380
        public void get_Secure(){} // RVA: 0x303450
        public void get_Host(){} // RVA: 0x2E07C0
        public void get_Port(){} // RVA: 0x44B4370
        public void get_Path(){} // RVA: 0x30B130
        public void Equals(){} // RVA: 0x6B6ABA0
        public void GetHashCode(){} // RVA: 0x99E0E0
        public void Parse(){} // RVA: 0x6B6AC50
        public void CheckUri(){} // RVA: 0x6B6B090
    }

    public class Logging
    {
        // ── Methods ──
        public void get_On(){} // RVA: 0x2DD320
    }

}