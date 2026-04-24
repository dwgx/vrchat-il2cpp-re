// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 1
// Methods: 12

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class AwaitTaskContinuation : TaskContinuation
    {
        public object s_invokeActionCallback; // 0x35F7A490
        public object IsValidLocationForInlining; // 0x1700024C

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae109ac0
        public void CreateTask(){} // RVA: 0x7ffaae109be0
        public void Run(){} // RVA: 0x7ffaae109cc0
        public void get_IsValidLocationForInlining(){} // RVA: 0x7ffaae109d80
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7ffaae109e90
        public void InvokeAction(){} // RVA: 0x7ffaae109f40
        public void RunCallback(){} // RVA: 0x7ffaae10a0b0
        public void RunOrScheduleAction(){} // RVA: 0x7ffaae10a270
        public void UnsafeScheduleAction(){} // RVA: 0x7ffaae10a3e0
        public void ThrowAsyncIfNecessary(){} // RVA: 0x7ffaae10a4b0
        public void MarkAborted(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetInvokeActionCallback(){} // RVA: 0x7ffaae109fb0
    }

}