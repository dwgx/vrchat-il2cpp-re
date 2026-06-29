// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 4
// Methods: 15

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class StackGuard : Object
    {
        public object m_inliningDepth;

        // ── Methods ──
        public void TryBeginInliningScope(){} // RVA: 0x69C74D0
        public void EndInliningScope(){} // RVA: 0x69C74E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StandardTaskContinuation : TaskContinuation
    {
        public object m_task;
        public object m_options;
        public object m_taskScheduler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69C7930
        public void Run(){} // RVA: 0x69C7A80
    }

    public class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
    {
        public object s_postCallback;
        public object s_postActionCallback;
        public object m_syncContext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69C7BF0
        public void Run(){} // RVA: 0x69C7C70
        public void PostAction(){} // RVA: 0x69C7EC0
        public void GetPostActionCallback(){} // RVA: 0x69C7F70
        public void .cctor(){} // RVA: 0x69C80A0
    }

    public class SynchronizationContextTaskScheduler : TaskScheduler
    {
        public object m_synchronizationContext;
        public object s_postCallback;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66ACBB0
        public void QueueTask(){} // RVA: 0x66ACC90
        public void TryExecuteTaskInline(){} // RVA: 0x66ACD20
        public void get_MaximumConcurrencyLevel(){} // RVA: 0xC3CCE0
        public void .cctor(){} // RVA: 0x66ACDC0
    }

}