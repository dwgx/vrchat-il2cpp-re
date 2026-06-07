// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks.Sources
// Classes: 4
// Methods: 19

namespace ThirdParty.DotNet.System.Threading.Tasks.Sources
{
    public class IValueTaskSource
    {
        // ── Methods ──
        public void GetStatus(){}
        public void OnCompleted(){}
        public void GetResult(){} // RVA: 0x24C40
    }

    public class IValueTaskSource`1
    {
        // ── Methods ──
        public void GetStatus(){}
        public void OnCompleted(){}
        public void GetResult(){} // RVA: 0x283FA0
    }

    public class ManualResetValueTaskSourceCoreShared
    {
        // ── Methods ──
        public void CompletionSentinel(){} // RVA: 0x62BC310
        public void .cctor(){} // RVA: 0x62BC350
    }

    public class ManualResetValueTaskSourceCore`1
    {
        // ── Methods ──
        public void get_RunContinuationsAsynchronously(){} // RVA: 0xDBE0
        public void Reset(){} // RVA: 0x24A50
        public void SetResult(){} // RVA: 0x283FA0
        public void SetException(){} // RVA: 0x24B10
        public void get_Version(){} // RVA: 0xCC90
        public void GetStatus(){}
        public void GetResult(){} // RVA: 0x283FA0
        public void OnCompleted(){}
        public void ValidateToken(){} // RVA: 0x24C40
        public void SignalCompletion(){} // RVA: 0x24A50
        public void InvokeContinuation(){} // RVA: 0x24A50
    }

}