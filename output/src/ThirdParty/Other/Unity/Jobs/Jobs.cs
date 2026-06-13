// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Jobs
// Classes: 7
// Methods: 25

namespace ThirdParty.Other.Unity.Jobs
{
    public class DOTSCompilerGeneratedAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EarlyInitHelpers
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6D75C40
        public void FlushEarlyInits(){} // RVA: 0x6D75C50
        public void JobReflectionDataCreationFailed(){} // RVA: 0x6D75E10
    }

    public class IJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x24A50
    }

    public class IJobExtensions
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x24A80
        public void GetReflectionData(){} // RVA: 0xC960
        public void Schedule(){} // RVA: 0x283FA0
    }

    public class IJobParallelFor
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x24FA0
    }

    public class IJobParallelForExtensions
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x24A80
        public void GetReflectionData(){} // RVA: 0xC960
        public void Schedule(){} // RVA: 0x283FA0
    }

    public class JobHandle
    {
        public ulong jobGroup; // 0x10

        // ── Methods ──
        public void Complete(){} // RVA: 0x70B5B90
        public void get_IsCompleted(){} // RVA: 0x70B5BF0
        public void ScheduleBatchedJobs(){} // RVA: 0x70B5C40
        public void ScheduleBatchedJobsAndComplete(){} // RVA: 0x70B5C90
        public void ScheduleBatchedJobsAndIsCompleted(){} // RVA: 0x70B5BF0
        public void CombineDependencies(){} // RVA: 0x70B5E10 | overloaded x3
        public void CombineDependenciesInternal2(){} // RVA: 0x70B5EC0
        public void CombineDependenciesInternalPtr(){} // RVA: 0x70B5F40
        public void Equals(){} // RVA: 0x70B5FC0
        public void CombineDependenciesInternal2_Injected(){} // RVA: 0x70B5FD0
        public void CombineDependenciesInternalPtr_Injected(){} // RVA: 0x70B6040
    }

}