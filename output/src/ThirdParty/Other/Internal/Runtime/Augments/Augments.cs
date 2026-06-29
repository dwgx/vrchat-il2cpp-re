// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Internal.Runtime.Augments
// Classes: 4
// Methods: 21

namespace ThirdParty.Other.Internal.Runtime.Augments
{
    public class ReflectionExecutionDomainCallbacks : Object
    {
        // ── Methods ──
        public void CreateMissingMetadataException(){} // RVA: 0x669BF80
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RuntimeAugments : Object
    {
        public object s_reflectionExecutionDomainCallbacks;

        // ── Methods ──
        public void ReportUnhandledException(){} // RVA: 0x669BE40
        public void get_Callbacks(){} // RVA: 0x669BE70
        public void .cctor(){} // RVA: 0x669BED0
    }

    public class RuntimeThread : Object
    {
        public object OptimalMaxSpinWaitsPerSpinIteration;
        public object thread;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ResetThreadPoolThread(){} // RVA: 0xB43310
        public void InitializeThreadPoolThread(){} // RVA: 0x669C000
        public void Create(){} // RVA: 0x669C090
        public void set_IsBackground(){} // RVA: 0x669C230
        public void Start(){} // RVA: 0x669C250
        public void Sleep(){} // RVA: 0x669C270
        public void Yield(){} // RVA: 0x669C280
        public void SpinWait(){} // RVA: 0xC2E4C0
        public void GetCurrentProcessorId(){} // RVA: 0xC3CCE0
        public void .cctor(){} // RVA: 0x669C2A0
    }

    public class TaskTraceCallbacks : Object
    {
        // ── Methods ──
        public void get_Enabled(){} // RVA: 0x87D280
        public void TaskWaitBegin_Asynchronous(){} // RVA: 0x896900
        public void TaskWaitBegin_Synchronous(){} // RVA: 0x896900
        public void TaskWaitEnd(){} // RVA: 0x896900
        public void TaskScheduled(){} // RVA: 0x896A10
    }

}