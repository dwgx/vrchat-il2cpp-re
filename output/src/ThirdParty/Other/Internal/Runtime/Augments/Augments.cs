// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Internal.Runtime.Augments
// Classes: 4
// Methods: 21

namespace ThirdParty.Other.Internal.Runtime.Augments
{
    public class ReflectionExecutionDomainCallbacks : Object
    {
        // ── Methods ──
        public void CreateMissingMetadataException(){} // RVA: 0x7ADA11530
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RuntimeAugments : Object
    {
        // ── Methods ──
        public void ReportUnhandledException(){} // RVA: 0x7ADA113F0
        public void get_Callbacks(){} // RVA: 0x7ADA11420
        public void .cctor(){} // RVA: 0x7ADA11480
    }

    public class RuntimeThread : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ResetThreadPoolThread(){} // RVA: 0x7A80D7310
        public void InitializeThreadPoolThread(){} // RVA: 0x7ADA115B0
        public void Create(){} // RVA: 0x7ADA11640
        public void set_IsBackground(){} // RVA: 0x7ADA117E0
        public void Start(){} // RVA: 0x7ADA11800
        public void Sleep(){} // RVA: 0x7ADA11820
        public void Yield(){} // RVA: 0x7ADA11830
        public void SpinWait(){} // RVA: 0x7A81BD750
        public void GetCurrentProcessorId(){} // RVA: 0x7A81CA9D0
        public void .cctor(){} // RVA: 0x7ADA11850
    }

    public class TaskTraceCallbacks : Object
    {
        // ── Methods ──
        public void get_Enabled(){} // RVA: 0x7A7E01900
        public void TaskWaitBegin_Asynchronous(){} // RVA: 0x7A7E1AD90
        public void TaskWaitBegin_Synchronous(){} // RVA: 0x7A7E1AD90
        public void TaskWaitEnd(){} // RVA: 0x7A7E1AD90
        public void TaskScheduled(){} // RVA: 0x7A7E1AEA0
    }

}