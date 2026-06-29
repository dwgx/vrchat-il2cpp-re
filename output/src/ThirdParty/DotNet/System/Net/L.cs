// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 39

namespace ThirdParty.DotNet.System.Net
{
    public class LazyAsyncResult : Object
    {
        public object t_ThreadContext;
        public object m_AsyncObject;
        public object m_AsyncState;
        public object m_AsyncCallback;
        public object m_Result;
        public object m_IntCompleted;
        public object m_EndCalled;
        public object m_UserEvent;
        public object m_Event;

        // ── Methods ──
        public void get_CurrentThreadContext(){} // RVA: 0x7591250
        public void .ctor(){} // RVA: 0x7591360
        public void get_AsyncObject(){} // RVA: 0xB5DBF0
        public void get_AsyncState(){} // RVA: 0xB465B0
        public void get_AsyncCallback(){} // RVA: 0xB700F0
        public void get_AsyncWaitHandle(){} // RVA: 0x7591530
        public void LazilyCreateEvent(){} // RVA: 0x75915E0
        public void get_CompletedSynchronously(){} // RVA: 0x7591840
        public void get_IsCompleted(){} // RVA: 0x7591860
        public void get_InternalPeekCompleted(){} // RVA: 0x7591890
        public void get_EndCalled(){} // RVA: 0xB78D60
        public void set_EndCalled(){} // RVA: 0xB7CBE0
        public void ProtectedInvokeCallback(){} // RVA: 0x75918A0
        public void InvokeCallback(){} // RVA: 0x7591A50
        public void Complete(){} // RVA: 0x7591A60
        public void WorkerThreadComplete(){} // RVA: 0x7591D40
        public void Cleanup(){} // RVA: 0xB43310
        public void InternalWaitForCompletion(){} // RVA: 0x7591DD0
        public void WaitForCompletion(){} // RVA: 0x7591DE0
    }

    public class ListenerAsyncResult : Object
    {
        public object handle;
        public object synch;
        public object completed;
        public object cb;
        public object state;
        public object exception;
        public object context;
        public object locker;
        public object forward;
        public object EndCalled;
        public object InGet;
        public object InvokeCB;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75CBE20
        public void Complete(){} // RVA: 0x75CC300
        public void InvokeCallback(){} // RVA: 0x75CC220
        public void GetContext(){} // RVA: 0x75CCA50
        public void get_AsyncState(){} // RVA: 0x75CCAB0
        public void get_AsyncWaitHandle(){} // RVA: 0x75CCAD0
        public void get_CompletedSynchronously(){} // RVA: 0x75CCCE0
        public void get_IsCompleted(){} // RVA: 0x75CCD00
        public void .cctor(){} // RVA: 0x75CCE40
    }

    public class ListenerPrefix : Object
    {
        public object original;
        public object host;
        public object port;
        public object path;
        public object secure;
        public object addresses;
        public object Listener;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75CCF20
        public void ToString(){} // RVA: 0xB5DBF0
        public void get_Secure(){} // RVA: 0xB68DF0
        public void get_Host(){} // RVA: 0xB465B0
        public void get_Port(){} // RVA: 0x4FEF950
        public void get_Path(){} // RVA: 0xB70160
        public void Equals(){} // RVA: 0x75CCF80
        public void GetHashCode(){} // RVA: 0x1269730
        public void Parse(){} // RVA: 0x75CD030
        public void CheckUri(){} // RVA: 0x75CD470
    }

    public class Logging : Object
    {
        // ── Methods ──
        public void get_On(){} // RVA: 0xB43320
    }

}