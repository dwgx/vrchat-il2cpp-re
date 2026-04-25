// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Jobs.LowLevel.Unsafe
// Classes: 5
// Methods: 19

namespace ThirdParty.Other.Unity.Jobs.LowLevel.Unsafe
{
    public class BatchQueryJobStruct`1 : ValueType
    {
        public UIntPtr jobReflectionData;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC2C58A90
    }

    public class BatchQueryJob`2 : ValueType
    {
        public Unity.Collections.NativeArray`1<T> commands;
        public Unity.Collections.NativeArray`1<T> results;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    }

    public class JobProducerTypeAttribute : Attribute
    {
        public System.Type <ProducerType>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class JobRanges : ValueType
    {
        public int BatchSize; // 0x10
        public int NumJobs; // 0x14
        public int TotalIterationCount; // 0x18
        public UIntPtr StartEndIndex; // 0x20
    }

    public class JobsUtility : Object
    {
        public PanicFunction_ IsExecutingJob;

        // ── Methods ──
        public void GetJobRange(){} // RVA: 0x7FFAC984EAF0
        public void GetWorkStealingRange(){} // RVA: 0x7FFAC984EB10
        public void Schedule(){} // RVA: 0x7FFAC984EB90
        public void ScheduleParallelFor(){} // RVA: 0x7FFAC984EC00
        public void ScheduleParallelForTransform(){} // RVA: 0x7FFAC984EC90
        public void ScheduleParallelForTransformReadOnly(){} // RVA: 0x7FFAC984ED10
        public void CreateJobReflectionData(){} // RVA: 0x7FFAC984EE30 | overloaded x2
        public void get_IsExecutingJob(){} // RVA: 0x7FFAC984EEC0
        public void set_JobCompilerEnabled(){} // RVA: 0x7FFAC984EF10
        public void get_ThreadIndexCount(){} // RVA: 0x7FFAC984EF60
        public void InvokePanicFunction(){} // RVA: 0x7FFAC984EFB0
        public void Schedule_Injected(){} // RVA: 0x7FFAC984F010
        public void ScheduleParallelFor_Injected(){} // RVA: 0x7FFAC984F070
        public void ScheduleParallelForTransform_Injected(){} // RVA: 0x7FFAC984F0F0
        public void ScheduleParallelForTransformReadOnly_Injected(){} // RVA: 0x7FFAC984F160
    }

}