// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks.Sources
// Classes: 4
// Methods: 16

namespace ThirdParty.DotNet.System.Threading.Tasks.Sources
{
    public class IValueTaskSource
    {
        // ── Methods ──
        public void GetStatus(){}
        public void OnCompleted(){}
        public void GetResult(){} // RVA: 0x7FFE80E461D0
    }

    public class IValueTaskSource`1
    {
    }

    public class ManualResetValueTaskSourceCoreShared : Object
    {
        // ── Methods ──
        public void CompletionSentinel(){} // RVA: 0x7FFE86DFCD40
        public void .cctor(){} // RVA: 0x7FFE86DFCD80
    }

    public class ManualResetValueTaskSourceCore`1 : ValueType
    {
        public System.Action`1<object> _continuation;
        public object _continuationState;

        // ── Methods ──
        public void get_RunContinuationsAsynchronously(){} // RVA: 0x7FFE80E2F150
        public void Reset(){} // RVA: 0x7FFE80E45FE0
        public void SetResult(){} // RVA: 0x7FFE810A1420
        public void SetException(){} // RVA: 0x7FFE80E460A0
        public void get_Version(){} // RVA: 0x7FFE80E2E210
        public void GetStatus(){}
        public void GetResult(){} // RVA: 0x7FFE810A1420
        public void OnCompleted(){}
        public void ValidateToken(){} // RVA: 0x7FFE80E461D0
        public void SignalCompletion(){} // RVA: 0x7FFE80E45FE0
        public void InvokeContinuation(){} // RVA: 0x7FFE80E45FE0
    }

}