// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 4
// Methods: 15

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class StackGuard : Object
    {
        // ── Original Methods ──
        public void TryBeginInliningScope(){} // RVA: 0x7ffaae1087c0
        public void EndInliningScope(){} // RVA: 0x7ffaae1087d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class StandardTaskContinuation : TaskContinuation
    {
        public object m_taskScheduler; // 0x3509FAF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae108c10
        public void Run(){} // RVA: 0x7ffaae108d60
    }

    public class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
    {
        public object m_syncContext; // 0x35F7A2E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae108ed0
        public void Run(){} // RVA: 0x7ffaae108f50
        public void PostAction(){} // RVA: 0x7ffaae1091a0
        public void .cctor(){} // RVA: 0x7ffaae109380
        // ── Binary Analysis Named ──
        public void GetPostActionCallback(){} // RVA: 0x7ffaae109250
    }

    public class SynchronizationContextTaskScheduler : TaskScheduler
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaddece70
        public void QueueTask(){} // RVA: 0x7ffaaddecf50
        public void TryExecuteTaskInline(){} // RVA: 0x7ffaaddecfe0
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x7ffaa8a24af0
        public void .cctor(){} // RVA: 0x7ffaadded080
    }

}