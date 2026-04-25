// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Jobs
// Classes: 7
// Methods: 25

namespace ThirdParty.Other.Unity.Jobs
{
    public class DOTSCompilerGeneratedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EarlyInitHelpers : Object
    {
        public System.Collections.Generic.List`1<EarlyInitFunction> s_PendingDelegates;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC950E3A0
        public void FlushEarlyInits(){} // RVA: 0x7FFAC950E3B0
        public void JobReflectionDataCreationFailed(){} // RVA: 0x7FFAC950E570
    }

    public class IJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC2C70980
    }

    public class IJobExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7FFAC2C709B0
        public void GetReflectionData(){} // RVA: 0x7FFAC2C58A90
        public void Schedule(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IJobParallelFor
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC2C70ED0
    }

    public class IJobParallelForExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7FFAC2C709B0
        public void GetReflectionData(){} // RVA: 0x7FFAC2C58A90
        public void Schedule(){} // RVA: 0x7FFAC2E8DC40
    }

    public class JobHandle : ValueType
    {
        public ulong IsCompleted; // 0x10
        public int version; // 0x18

        // ── Methods ──
        public void Complete(){} // RVA: 0x7FFAC984E5D0
        public void get_IsCompleted(){} // RVA: 0x7FFAC984E630
        public void ScheduleBatchedJobs(){} // RVA: 0x7FFAC984E680
        public void ScheduleBatchedJobsAndComplete(){} // RVA: 0x7FFAC984E6D0
        public void ScheduleBatchedJobsAndIsCompleted(){} // RVA: 0x7FFAC984E630
        public void CombineDependencies(){} // RVA: 0x7FFAC984E850 | overloaded x3
        public void CombineDependenciesInternal2(){} // RVA: 0x7FFAC984E900
        public void CombineDependenciesInternalPtr(){} // RVA: 0x7FFAC984E980
        public void Equals(){} // RVA: 0x7FFAC984EA00
        public void CombineDependenciesInternal2_Injected(){} // RVA: 0x7FFAC984EA10
        public void CombineDependenciesInternalPtr_Injected(){} // RVA: 0x7FFAC984EA80
    }

}