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
        public void GetResult(){} // RVA: 0x7FFAC2C70B70
    }

    public class IValueTaskSource`1
    {
        // ── Methods ──
        public void GetStatus(){}
        public void OnCompleted(){}
        public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ManualResetValueTaskSourceCoreShared : Object
    {
        public System.Action`1<object> s_sentinel;

        // ── Methods ──
        public void CompletionSentinel(){} // RVA: 0x7FFAC8A536B0
        public void .cctor(){} // RVA: 0x7FFAC8A536F0
    }

    public class ManualResetValueTaskSourceCore`1 : ValueType
    {
        public System.Action`1<object> RunContinuationsAsynchronously;
        public object Version;
        public System.Threading.ExecutionContext _executionContext;
        public object _capturedContext;
        public bool _completed;
        public T _result;
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo _error;
        public short _version;
        public bool <RunContinuationsAsynchronously>k__BackingField;

        // ── Methods ──
        public void get_RunContinuationsAsynchronously(){} // RVA: 0x7FFAC2C59D00
        public void Reset(){} // RVA: 0x7FFAC2C70980
        public void SetResult(){} // RVA: 0x7FFAC2E8DC40
        public void SetException(){} // RVA: 0x7FFAC2C70A40
        public void get_Version(){} // RVA: 0x7FFAC2C58DC0
        public void GetStatus(){}
        public void GetResult(){} // RVA: 0x7FFAC2E8DC40
        public void OnCompleted(){}
        public void ValidateToken(){} // RVA: 0x7FFAC2C70B70
        public void SignalCompletion(){} // RVA: 0x7FFAC2C70980
        public void InvokeContinuation(){} // RVA: 0x7FFAC2C70980
    }

}