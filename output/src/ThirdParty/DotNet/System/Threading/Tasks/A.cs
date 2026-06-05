// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 2
// Methods: 17

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class AsyncCausalityTracer
    {
        // ── Methods ──
        public void get_LoggingOn(){} // RVA: 0x7FFAF2D8D320
        public void TraceOperationCreation(){} // RVA: 0x7FFAF2D8D310
        public void TraceOperationCompletion(){} // RVA: 0x7FFAF2D8D310
        public void TraceSynchronousWorkStart(){} // RVA: 0x7FFAF2D8D310
        public void TraceSynchronousWorkCompletion(){} // RVA: 0x7FFAF2D8D310
    }

    public class AwaitTaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8A01240
        public void CreateTask(){} // RVA: 0x7FFAF8A01360
        public void Run(){} // RVA: 0x7FFAF8A01440
        public void get_IsValidLocationForInlining(){} // RVA: 0x7FFAF8A01500
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFAF8A01610
        public void InvokeAction(){} // RVA: 0x7FFAF8A016C0
        public void GetInvokeActionCallback(){} // RVA: 0x7FFAF8A01730
        public void RunCallback(){} // RVA: 0x7FFAF8A01830
        public void RunOrScheduleAction(){} // RVA: 0x7FFAF8A019F0
        public void UnsafeScheduleAction(){} // RVA: 0x7FFAF8A01B60
        public void ThrowAsyncIfNecessary(){} // RVA: 0x7FFAF8A01C30
        public void MarkAborted(){} // RVA: 0x7FFAF2D8D310
    }

}