// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Internal.Runtime.Augments
// Classes: 4
// Methods: 21

namespace ThirdParty.Other.Internal.Runtime.Augments
{
    public class ReflectionExecutionDomainCallbacks : Object
    {
        // ── Methods ──
        public void CreateMissingMetadataException(){} // RVA: 0x7FFAC83BAB60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RuntimeAugments : Object
    {
        public Internal.Runtime.Augments.ReflectionExecutionDomainCallbacks Callbacks;

        // ── Methods ──
        public void ReportUnhandledException(){} // RVA: 0x7FFAC83BAA20
        public void get_Callbacks(){} // RVA: 0x7FFAC83BAA50
        public void .cctor(){} // RVA: 0x7FFAC83BAAB0
    }

    public class RuntimeThread : Object
    {
        public int IsBackground;
        public System.Threading.Thread thread; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ResetThreadPoolThread(){} // RVA: 0x7FFAC2F21310
        public void InitializeThreadPoolThread(){} // RVA: 0x7FFAC83BABE0
        public void Create(){} // RVA: 0x7FFAC83BAC70
        public void set_IsBackground(){} // RVA: 0x7FFAC83BAE10
        public void Start(){} // RVA: 0x7FFAC83BAE30
        public void Sleep(){} // RVA: 0x7FFAC83BAE50
        public void Yield(){} // RVA: 0x7FFAC83BAE60
        public void SpinWait(){} // RVA: 0x7FFAC3006850
        public void GetCurrentProcessorId(){} // RVA: 0x7FFAC3013AF0
        public void .cctor(){} // RVA: 0x7FFAC83BAE80
    }

    public class TaskTraceCallbacks : Object
    {
        public object Enabled;

        // ── Methods ──
        public void get_Enabled(){} // RVA: 0x7FFAC2C59D00
        public void TaskWaitBegin_Asynchronous(){}
        public void TaskWaitBegin_Synchronous(){}
        public void TaskWaitEnd(){}
        public void TaskScheduled(){}
    }

}