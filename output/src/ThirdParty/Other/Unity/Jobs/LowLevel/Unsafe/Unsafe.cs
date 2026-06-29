// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Jobs.LowLevel.Unsafe
// Classes: 5
// Methods: 34

namespace ThirdParty.Other.Unity.Jobs.LowLevel.Unsafe
{
    public class BatchQueryJobStruct`1 : ValueType
    {
        public object jobReflectionData;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x87C0D0
    }

    public class BatchQueryJob`2 : ValueType
    {
        public object commands;
        public object results;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
    }

    public class JobProducerTypeAttribute : Attribute
    {
        public object _producerType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class JobsUtility : Object
    {
        public object PanicFunction;

        // ── Methods ──
        public void GetJobRange(){} // RVA: 0x7B47BA0
        public void GetWorkStealingRange(){} // RVA: 0x7B47BC0
        public void Schedule(){} // RVA: 0x7B47C40
        public void ScheduleParallelFor(){} // RVA: 0x7B47CB0
        public void ScheduleParallelForTransform(){} // RVA: 0x7B47D40
        public void ScheduleParallelForTransformReadOnly(){} // RVA: 0x7B47DC0
        public void CreateJobReflectionData(){} // RVA: 0x7B47EE0
        public void get_IsExecutingJob(){} // RVA: 0x7B47F70
        public void set_JobCompilerEnabled(){} // RVA: 0x7B47FC0
        public void get_ThreadIndex(){} // RVA: 0x7B48010
        public void get_ThreadIndexCount(){} // RVA: 0x7B48060
        public void InvokePanicFunction(){} // RVA: 0x7B480B0
        public void Schedule_Injected(){} // RVA: 0x7B48110
        public void ScheduleParallelFor_Injected(){} // RVA: 0x7B48170
        public void ScheduleParallelForTransform_Injected(){} // RVA: 0x7B481F0
        public void ScheduleParallelForTransformReadOnly_Injected(){} // RVA: 0x7B48260
    }

    public class JobsUtility[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}