// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Jobs
// Classes: 7
// Methods: 25

namespace ThirdParty.Other.Unity.Jobs
{
    public class DOTSCompilerGeneratedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EarlyInitHelpers : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE878B6AE0
        public void FlushEarlyInits(){} // RVA: 0x7FFE878B6AF0
        public void JobReflectionDataCreationFailed(){} // RVA: 0x7FFE878B6CB0
    }

    public class IJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE80E45FE0
    }

    public class IJobExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7FFE80E46010
        public void GetReflectionData(){} // RVA: 0x7FFE80E2DEE0
        public void Schedule(){} // RVA: 0x7FFE810A1420
    }

    public class IJobParallelFor
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE80E46530
    }

    public class IJobParallelForExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7FFE80E46010
        public void GetReflectionData(){} // RVA: 0x7FFE80E2DEE0
        public void Schedule(){} // RVA: 0x7FFE810A1420
    }

    public class JobHandle : ValueType
    {
        public ulong jobGroup; // 0x10

        // ── Methods ──
        public void Complete(){} // RVA: 0x7FFE87BF6B70
        public void get_IsCompleted(){} // RVA: 0x7FFE87BF6BD0
        public void ScheduleBatchedJobs(){} // RVA: 0x7FFE87BF6C20
        public void ScheduleBatchedJobsAndComplete(){} // RVA: 0x7FFE87BF6C70
        public void ScheduleBatchedJobsAndIsCompleted(){} // RVA: 0x7FFE87BF6BD0
        public void CombineDependencies(){} // RVA: 0x7FFE87BF6DF0 | overloaded x3
        public void CombineDependenciesInternal2(){} // RVA: 0x7FFE87BF6EA0
        public void CombineDependenciesInternalPtr(){} // RVA: 0x7FFE87BF6F20
        public void Equals(){} // RVA: 0x7FFE87BF6FA0
        public void CombineDependenciesInternal2_Injected(){} // RVA: 0x7FFE87BF6FB0
        public void CombineDependenciesInternalPtr_Injected(){} // RVA: 0x7FFE87BF7020
    }

}