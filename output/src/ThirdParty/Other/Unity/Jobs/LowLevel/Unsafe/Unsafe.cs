// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Jobs.LowLevel.Unsafe
// Classes: 5
// Methods: 19

namespace ThirdParty.Other.Unity.Jobs.LowLevel.Unsafe
{
    public class BatchQueryJobStruct`1 : ValueType
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE80E2DEE0
    }

    public class BatchQueryJob`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
    }

    public class JobProducerTypeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class JobRanges : ValueType
    {
    }

    public class JobsUtility : Object
    {
        public PanicFunction_ PanicFunction;
        public object IsExecutingJob;
        public object IsExecutingJob; // 0x93F0

        // ── Methods ──
        public void GetJobRange(){} // RVA: 0x7FFE87BF7090
        public void GetWorkStealingRange(){} // RVA: 0x7FFE87BF70B0
        public void Schedule(){} // RVA: 0x7FFE87BF7130
        public void ScheduleParallelFor(){} // RVA: 0x7FFE87BF71A0
        public void ScheduleParallelForTransform(){} // RVA: 0x7FFE87BF7230
        public void ScheduleParallelForTransformReadOnly(){} // RVA: 0x7FFE87BF72B0
        public void CreateJobReflectionData(){} // RVA: 0x7FFE87BF73D0 | overloaded x2
        public void get_IsExecutingJob(){} // RVA: 0x7FFE87BF7460
        public void set_JobCompilerEnabled(){} // RVA: 0x7FFE87BF74B0
        public void get_ThreadIndexCount(){} // RVA: 0x7FFE87BF7500
        public void InvokePanicFunction(){} // RVA: 0x7FFE87BF7550
        public void Schedule_Injected(){} // RVA: 0x7FFE87BF75B0
        public void ScheduleParallelFor_Injected(){} // RVA: 0x7FFE87BF7610
        public void ScheduleParallelForTransform_Injected(){} // RVA: 0x7FFE87BF7690
        public void ScheduleParallelForTransformReadOnly_Injected(){} // RVA: 0x7FFE87BF7700
    }

}