// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Jobs.LowLevel.Unsafe
// Classes: 3
// Methods: 18

namespace ThirdParty.Other.Unity.Jobs.LowLevel.Unsafe
{
    public class BatchQueryJobStruct`1 : ValueType
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4E078A90
    }

    public class BatchQueryJob`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    }

    public class JobsUtility : Object
    {
        public object IsExecutingJob;
        public object JobCompilerEnabled;
        public object ThreadIndexCount;

        // ── Methods ──
        public void GetJobRange(){} // RVA: 0x7FFD54C6EAF0
        public void GetWorkStealingRange(){} // RVA: 0x7FFD54C6EB10
        public void Schedule(){} // RVA: 0x7FFD54C6EB90
        public void ScheduleParallelFor(){} // RVA: 0x7FFD54C6EC00
        public void ScheduleParallelForTransform(){} // RVA: 0x7FFD54C6EC90
        public void ScheduleParallelForTransformReadOnly(){} // RVA: 0x7FFD54C6ED10
        public void CreateJobReflectionData(){} // RVA: 0x7FFD54C6EE30 | overloaded x2
        public void get_IsExecutingJob(){} // RVA: 0x7FFD54C6EEC0
        public void set_JobCompilerEnabled(){} // RVA: 0x7FFD54C6EF10
        public void get_ThreadIndexCount(){} // RVA: 0x7FFD54C6EF60
        public void InvokePanicFunction(){} // RVA: 0x7FFD54C6EFB0
        public void Schedule_Injected(){} // RVA: 0x7FFD54C6F010
        public void ScheduleParallelFor_Injected(){} // RVA: 0x7FFD54C6F070
        public void ScheduleParallelForTransform_Injected(){} // RVA: 0x7FFD54C6F0F0
        public void ScheduleParallelForTransformReadOnly_Injected(){} // RVA: 0x7FFD54C6F160
    }

}