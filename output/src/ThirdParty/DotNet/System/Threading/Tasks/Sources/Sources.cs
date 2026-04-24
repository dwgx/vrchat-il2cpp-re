// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks.Sources
// Classes: 3
// Methods: 17

namespace ThirdParty.DotNet.System.Threading.Tasks.Sources
{
    public class IValueTaskSource
    {
        // ── Methods ──
        public void GetStatus(){}
        public void OnCompleted(){}
        public void GetResult(){} // RVA: 0x7FFD4E090B70
    }

    public class IValueTaskSource`1
    {
        // ── Methods ──
        public void GetStatus(){}
        public void OnCompleted(){}
        public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ManualResetValueTaskSourceCore`1 : ValueType
    {
        public ileFullDirectoryInformation<object> RunContinuationsAsynchronously;
        public object Version;
        public sageKind.d _executionContext;
        public object _capturedContext;
        public bool _completed;
        public T1717588544 _result;
        public .Messaging.IInternalMessage.TargetIdentity.eDictionary _error;
        public short _version;
        public bool <RunContinuationsAsynchronously>k__BackingField;

        // ── Methods ──
        public void get_RunContinuationsAsynchronously(){} // RVA: 0x7FFD4E079D00
        public void Reset(){} // RVA: 0x7FFD4E090980
        public void SetResult(){} // RVA: 0x7FFD4E2ADC40
        public void SetException(){} // RVA: 0x7FFD4E090A40
        public void get_Version(){} // RVA: 0x7FFD4E078DC0
        public void GetStatus(){}
        public void GetResult(){} // RVA: 0x7FFD4E2ADC40
        public void OnCompleted(){}
        public void ValidateToken(){} // RVA: 0x7FFD4E090B70
        public void SignalCompletion(){} // RVA: 0x7FFD4E090980
        public void InvokeContinuation(){} // RVA: 0x7FFD4E090980
    }

}