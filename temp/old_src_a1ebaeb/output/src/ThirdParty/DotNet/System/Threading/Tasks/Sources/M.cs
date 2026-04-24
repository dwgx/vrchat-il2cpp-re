// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks.Sources
// Classes: 2
// Methods: 22

namespace ThirdParty.DotNet.System.Threading.Tasks.Sources
{
    public class ManualResetValueTaskSourceCore`1 : ValueType
    {
        public object _executionContext; // 0x30B29F10
        public object _result; // 0x30B29F10
        public object _runContinuationsAsynchronously; // 0x30B29F10, was: <RunContinuationsAsynchronousl
        public object RunContinuationsAsynchronously; // 0x17000002
        public object Version; // 0x17000003

        // ── Original Methods ──
        public void get_RunContinuationsAsynchronously(){} // RVA: 0x7ffaa864a040
        public void Reset(){} // RVA: 0x7ffaa8660cc0
        public void get_Version(){} // RVA: 0x7ffaa8649100
        public void OnCompleted(){}
        public void ValidateToken(){} // RVA: 0x7ffaa8660eb0
        public void SignalCompletion(){} // RVA: 0x7ffaa8660cc0
        public void InvokeContinuation(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetResult(){} // RVA: 0x7ffaa887e5c0
        public void SetException(){} // RVA: 0x7ffaa8660d80
        public void GetStatus(){}
        public void GetResult(){} // RVA: 0x7ffaa887e5c0
    }

    public class ManualResetValueTaskSourceCore`1 : ValueType
    {
        public object _executionContext; // 0x30B2A210
        public object _result; // 0x30B2A210
        public object _runContinuationsAsynchronously; // 0x30B2A210, was: <RunContinuationsAsynchronousl
        public object RunContinuationsAsynchronously; // 0x1700025A
        public object Version; // 0x1700025B

        // ── Original Methods ──
        public void get_RunContinuationsAsynchronously(){} // RVA: 0x7ffaa864a040
        public void Reset(){} // RVA: 0x7ffaa8660cc0
        public void get_Version(){} // RVA: 0x7ffaa8649100
        public void OnCompleted(){}
        public void ValidateToken(){} // RVA: 0x7ffaa8660eb0
        public void SignalCompletion(){} // RVA: 0x7ffaa8660cc0
        public void InvokeContinuation(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetResult(){} // RVA: 0x7ffaa887e5c0
        public void SetException(){} // RVA: 0x7ffaa8660d80
        public void GetStatus(){}
        public void GetResult(){} // RVA: 0x7ffaa887e5c0
    }

}