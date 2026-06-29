// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 2
// Methods: 17

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class AsyncCausalityTracer : Object
    {
        // ── Methods ──
        public void get_LoggingOn(){} // RVA: 0xB43320
        public void TraceOperationCreation(){} // RVA: 0xB43310
        public void TraceOperationCompletion(){} // RVA: 0xB43310
        public void TraceSynchronousWorkStart(){} // RVA: 0xB43310
        public void TraceSynchronousWorkCompletion(){} // RVA: 0xB43310
    }

    public class AwaitTaskContinuation : TaskContinuation
    {
        public object m_capturedContext;
        public object m_action;
        public object s_invokeActionCallback;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69C87E0
        public void CreateTask(){} // RVA: 0x69C8900
        public void Run(){} // RVA: 0x69C89E0
        public void get_IsValidLocationForInlining(){} // RVA: 0x69C8AA0
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x69C8BC0
        public void InvokeAction(){} // RVA: 0x69C8C70
        public void GetInvokeActionCallback(){} // RVA: 0x69C8CE0
        public void RunCallback(){} // RVA: 0x69C8DE0
        public void RunOrScheduleAction(){} // RVA: 0x69C8F80
        public void UnsafeScheduleAction(){} // RVA: 0x69C90E0
        public void ThrowAsyncIfNecessary(){} // RVA: 0x69C91B0
        public void MarkAborted(){} // RVA: 0xB43310
    }

}