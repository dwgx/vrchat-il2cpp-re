// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 2
// Methods: 17

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class AsyncCausalityTracer : Object
    {
        // ── Methods ──
        public void get_LoggingOn(){} // RVA: 0x7A80D7320
        public void TraceOperationCreation(){} // RVA: 0x7A80D7310
        public void TraceOperationCompletion(){} // RVA: 0x7A80D7310
        public void TraceSynchronousWorkStart(){} // RVA: 0x7A80D7310
        public void TraceSynchronousWorkCompletion(){} // RVA: 0x7A80D7310
    }

    public class AwaitTaskContinuation : TaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD3FA30
        public void CreateTask(){} // RVA: 0x7ADD3FB50
        public void Run(){} // RVA: 0x7ADD3FC30
        public void get_IsValidLocationForInlining(){} // RVA: 0x7ADD3FCF0
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7ADD3FE00
        public void InvokeAction(){} // RVA: 0x7ADD3FEB0
        public void GetInvokeActionCallback(){} // RVA: 0x7ADD3FF20
        public void RunCallback(){} // RVA: 0x7ADD40020
        public void RunOrScheduleAction(){} // RVA: 0x7ADD401C0
        public void UnsafeScheduleAction(){} // RVA: 0x7ADD40320
        public void ThrowAsyncIfNecessary(){} // RVA: 0x7ADD403F0
        public void MarkAborted(){} // RVA: 0x7A80D7310
    }

}