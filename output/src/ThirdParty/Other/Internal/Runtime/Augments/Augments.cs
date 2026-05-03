// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Internal.Runtime.Augments
// Classes: 4
// Methods: 21

namespace ThirdParty.Other.Internal.Runtime.Augments
{
    public class ReflectionExecutionDomainCallbacks : Object
    {
        // ── Methods ──
        public void CreateMissingMetadataException(){} // RVA: 0x7FFE86764460
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RuntimeAugments : Object
    {
        public Internal.Runtime.Augments.ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks;

        // ── Methods ──
        public void ReportUnhandledException(){} // RVA: 0x7FFE86764320
        public void get_Callbacks(){} // RVA: 0x7FFE86764350
        public void .cctor(){} // RVA: 0x7FFE867643B0
    }

    public class RuntimeThread : Object
    {
        public int OptimalMaxSpinWaitsPerSpinIteration;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ResetThreadPoolThread(){} // RVA: 0x7FFE810FB310
        public void InitializeThreadPoolThread(){} // RVA: 0x7FFE867644E0
        public void Create(){} // RVA: 0x7FFE86764570
        public void set_IsBackground(){} // RVA: 0x7FFE86764710
        public void Start(){} // RVA: 0x7FFE86764730
        public void Sleep(){} // RVA: 0x7FFE86764750
        public void Yield(){} // RVA: 0x7FFE86764760
        public void SpinWait(){} // RVA: 0x7FFE811E0850
        public void GetCurrentProcessorId(){} // RVA: 0x7FFE811EDAF0
        public void .cctor(){} // RVA: 0x7FFE86764780
    }

    public class TaskTraceCallbacks : Object
    {
        // ── Methods ──
        public void get_Enabled(){} // RVA: 0x7FFE80E2F150
        public void TaskWaitBegin_Asynchronous(){}
        public void TaskWaitBegin_Synchronous(){}
        public void TaskWaitEnd(){}
        public void TaskScheduled(){}
    }

}