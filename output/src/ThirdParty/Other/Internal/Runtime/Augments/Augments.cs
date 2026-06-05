// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Internal.Runtime.Augments
// Classes: 4
// Methods: 21

namespace ThirdParty.Other.Internal.Runtime.Augments
{
    public class ReflectionExecutionDomainCallbacks
    {
        // ── Methods ──
        public void CreateMissingMetadataException(){} // RVA: 0x7FFAF86D3610
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class RuntimeAugments
    {
        // ── Methods ──
        public void ReportUnhandledException(){} // RVA: 0x7FFAF86D34D0
        public void get_Callbacks(){} // RVA: 0x7FFAF86D3500
        public void .cctor(){} // RVA: 0x7FFAF86D3560
    }

    public class RuntimeThread
    {
        public object Enabled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void ResetThreadPoolThread(){} // RVA: 0x7FFAF2D8D310
        public void InitializeThreadPoolThread(){} // RVA: 0x7FFAF86D3690
        public void Create(){} // RVA: 0x7FFAF86D3720
        public void set_IsBackground(){} // RVA: 0x7FFAF86D38C0
        public void Start(){} // RVA: 0x7FFAF86D38E0
        public void Sleep(){} // RVA: 0x7FFAF86D3900
        public void Yield(){} // RVA: 0x7FFAF86D3910
        public void SpinWait(){} // RVA: 0x7FFAF2E72850
        public void GetCurrentProcessorId(){} // RVA: 0x7FFAF2E7FAF0
        public void .cctor(){} // RVA: 0x7FFAF86D3930
    }

    public class TaskTraceCallbacks
    {
        // ── Methods ──
        public void get_Enabled(){} // RVA: 0x7FFAF2ABDBE0
        public void TaskWaitBegin_Asynchronous(){}
        public void TaskWaitBegin_Synchronous(){}
        public void TaskWaitEnd(){}
        public void TaskScheduled(){}
    }

}