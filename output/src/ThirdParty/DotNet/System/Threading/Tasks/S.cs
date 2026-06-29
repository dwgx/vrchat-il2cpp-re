// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 4
// Methods: 15

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class StackGuard : Object
    {
        // ── Methods ──
        public void TryBeginInliningScope(){} // RVA: 0x7ADD3E720
        public void EndInliningScope(){} // RVA: 0x7ADD3E730
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class StandardTaskContinuation : TaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD3EB80
        public void Run(){} // RVA: 0x7ADD3ECD0
    }

    public class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD3EE40
        public void Run(){} // RVA: 0x7ADD3EEC0
        public void PostAction(){} // RVA: 0x7ADD3F110
        public void GetPostActionCallback(){} // RVA: 0x7ADD3F1C0
        public void .cctor(){} // RVA: 0x7ADD3F2F0
    }

    public class SynchronizationContextTaskScheduler : TaskScheduler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA22790
        public void QueueTask(){} // RVA: 0x7ADA22870
        public void TryExecuteTaskInline(){} // RVA: 0x7ADA22900
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x7A81CA9D0
        public void .cctor(){} // RVA: 0x7ADA229A0
    }

}