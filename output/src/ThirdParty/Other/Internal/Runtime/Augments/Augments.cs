// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Internal.Runtime.Augments
// Classes: 4
// Methods: 21

namespace ThirdParty.Other.Internal.Runtime.Augments
{
    public class ReflectionExecutionDomainCallbacks
    {
        // ── Methods ──
        public void CreateMissingMetadataException(){} // RVA: 0x5C23610
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RuntimeAugments
    {
        public Internal.Runtime.Augments.ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks;

        // ── Methods ──
        public void ReportUnhandledException(){} // RVA: 0x5C234D0
        public void get_Callbacks(){} // RVA: 0x5C23500
        public void .cctor(){} // RVA: 0x5C23560
    }

    public class RuntimeThread
    {
        public int Enabled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ResetThreadPoolThread(){} // RVA: 0x2DD310
        public void InitializeThreadPoolThread(){} // RVA: 0x5C23690
        public void Create(){} // RVA: 0x5C23720
        public void set_IsBackground(){} // RVA: 0x5C238C0
        public void Start(){} // RVA: 0x5C238E0
        public void Sleep(){} // RVA: 0x5C23900
        public void Yield(){} // RVA: 0x5C23910
        public void SpinWait(){} // RVA: 0x3C2850
        public void GetCurrentProcessorId(){} // RVA: 0x3CFAF0
        public void .cctor(){} // RVA: 0x5C23930
    }

    public class TaskTraceCallbacks
    {
        // ── Methods ──
        public void get_Enabled(){} // RVA: 0xDBE0
        public void TaskWaitBegin_Asynchronous(){}
        public void TaskWaitBegin_Synchronous(){}
        public void TaskWaitEnd(){}
        public void TaskScheduled(){}
    }

}