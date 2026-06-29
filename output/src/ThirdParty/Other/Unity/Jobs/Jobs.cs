// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Jobs
// Classes: 7
// Methods: 23

namespace ThirdParty.Other.Unity.Jobs
{
    public class DOTSCompilerGeneratedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EarlyInitHelpers : Object
    {
        public object s_PendingDelegates;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x77D12C0
        public void FlushEarlyInits(){} // RVA: 0x77D12D0
        public void JobReflectionDataCreationFailed(){} // RVA: 0x77D1490
    }

    public class IJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x894290
    }

    public class IJobExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x30E6510
        public void GetReflectionData(){} // RVA: 0x30E6DD0
        public void Schedule(){} // RVA: 0x30E7350
    }

    public class IJobParallelFor
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x8944F0
    }

    public class IJobParallelForExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x30E74D0
        public void GetReflectionData(){} // RVA: 0x30E8110
        public void Schedule(){} // RVA: 0x30E8FD0
    }

    public class JobHandle : ValueType
    {
        public object jobGroup;
        public object version;

        // ── Methods ──
        public void Complete(){} // RVA: 0x95E820
        public void get_IsCompleted(){} // RVA: 0x95E880
        public void ScheduleBatchedJobs(){} // RVA: 0x7B47730
        public void ScheduleBatchedJobsAndComplete(){} // RVA: 0x7B47780
        public void ScheduleBatchedJobsAndIsCompleted(){} // RVA: 0x7B476E0
        public void CombineDependencies(){} // RVA: 0x7B47900
        public void CombineDependenciesInternal2(){} // RVA: 0x7B479B0
        public void CombineDependenciesInternalPtr(){} // RVA: 0x7B47A30
        public void Equals(){} // RVA: 0x95E8D0
        public void CombineDependenciesInternal2_Injected(){} // RVA: 0x7B47AC0
        public void CombineDependenciesInternalPtr_Injected(){} // RVA: 0x7B47B30
    }

}