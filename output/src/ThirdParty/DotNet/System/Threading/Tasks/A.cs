// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 2
// Methods: 17

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class AsyncCausalityTracer
    {
        // ── Methods ──
        public void get_LoggingOn(){} // RVA: 0x2DD320
        public void TraceOperationCreation(){} // RVA: 0x2DD310
        public void TraceOperationCompletion(){} // RVA: 0x2DD310
        public void TraceSynchronousWorkStart(){} // RVA: 0x2DD310
        public void TraceSynchronousWorkCompletion(){} // RVA: 0x2DD310
    }

    public class AwaitTaskContinuation
    {
        public System.Threading.ExecutionContext m_capturedContext; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F51240
        public void CreateTask(){} // RVA: 0x5F51360
        public void Run(){} // RVA: 0x5F51440
        public void get_IsValidLocationForInlining(){} // RVA: 0x5F51500
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x5F51610
        public void InvokeAction(){} // RVA: 0x5F516C0
        public void GetInvokeActionCallback(){} // RVA: 0x5F51730
        public void RunCallback(){} // RVA: 0x5F51830
        public void RunOrScheduleAction(){} // RVA: 0x5F519F0
        public void UnsafeScheduleAction(){} // RVA: 0x5F51B60
        public void ThrowAsyncIfNecessary(){} // RVA: 0x5F51C30
        public void MarkAborted(){} // RVA: 0x2DD310
    }

}