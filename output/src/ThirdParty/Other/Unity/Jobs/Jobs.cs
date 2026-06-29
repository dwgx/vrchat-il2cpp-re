// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Jobs
// Classes: 7
// Methods: 23

namespace ThirdParty.Other.Unity.Jobs
{
    public class DOTSCompilerGeneratedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class EarlyInitHelpers : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AEB639C0
        public void FlushEarlyInits(){} // RVA: 0x7AEB639D0
        public void JobReflectionDataCreationFailed(){} // RVA: 0x7AEB63B90
    }

    public class IJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7A7E18770
    }

    public class IJobExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7AA4BA050
        public void GetReflectionData(){} // RVA: 0x7AA4BA910
        public void Schedule(){} // RVA: 0x7AA4BAE90
    }

    public class IJobParallelFor
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7A7E189D0
    }

    public class IJobParallelForExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7AA4BB010
        public void GetReflectionData(){} // RVA: 0x7AA4BBA10
        public void Schedule(){} // RVA: 0x7AA4BC5B0
    }

    public class JobHandle : ValueType
    {
        // ── Methods ──
        public void Complete(){} // RVA: 0x7A7ED9990
        public void get_IsCompleted(){} // RVA: 0x7A7ED99F0
        public void ScheduleBatchedJobs(){} // RVA: 0x7AEE94A90
        public void ScheduleBatchedJobsAndComplete(){} // RVA: 0x7AEE94AE0
        public void ScheduleBatchedJobsAndIsCompleted(){} // RVA: 0x7AEE94A40
        public void CombineDependencies(){} // RVA: 0x7AEE94C60
        public void CombineDependenciesInternal2(){} // RVA: 0x7AEE94D10
        public void CombineDependenciesInternalPtr(){} // RVA: 0x7AEE94D90
        public void Equals(){} // RVA: 0x7A7ED9A40
        public void CombineDependenciesInternal2_Injected(){} // RVA: 0x7AEE94E20
        public void CombineDependenciesInternalPtr_Injected(){} // RVA: 0x7AEE94E90
    }

}