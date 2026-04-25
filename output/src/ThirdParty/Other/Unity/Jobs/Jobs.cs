// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Jobs
// Classes: 6
// Methods: 24

namespace ThirdParty.Other.Unity.Jobs
{
    public class EarlyInitHelpers : Object
    {
        public System.Collections.Generic.List`1<0x66606570> s_PendingDelegates;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD5492E3A0
        public void FlushEarlyInits(){} // RVA: 0x7FFD5492E3B0
        public void JobReflectionDataCreationFailed(){} // RVA: 0x7FFD5492E570
    }

    public class IJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD4E090980
    }

    public class IJobExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7FFD4E0909B0
        public void GetReflectionData(){} // RVA: 0x7FFD4E078A90
        public void Schedule(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IJobParallelFor
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD4E090ED0
    }

    public class IJobParallelForExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7FFD4E0909B0
        public void GetReflectionData(){} // RVA: 0x7FFD4E078A90
        public void Schedule(){} // RVA: 0x7FFD4E2ADC40
    }

    public class JobHandle : ValueType
    {
        public ulong IsCompleted; // 0x10
        public int version; // 0x18

        // ── Methods ──
        public void Complete(){} // RVA: 0x7FFD54C6E5D0
        public void get_IsCompleted(){} // RVA: 0x7FFD54C6E630
        public void ScheduleBatchedJobs(){} // RVA: 0x7FFD54C6E680
        public void ScheduleBatchedJobsAndComplete(){} // RVA: 0x7FFD54C6E6D0
        public void ScheduleBatchedJobsAndIsCompleted(){} // RVA: 0x7FFD54C6E630
        public void CombineDependencies(){} // RVA: 0x7FFD54C6E850 | overloaded x3
        public void CombineDependenciesInternal2(){} // RVA: 0x7FFD54C6E900
        public void CombineDependenciesInternalPtr(){} // RVA: 0x7FFD54C6E980
        public void Equals(){} // RVA: 0x7FFD54C6EA00
        public void CombineDependenciesInternal2_Injected(){} // RVA: 0x7FFD54C6EA10
        public void CombineDependenciesInternalPtr_Injected(){} // RVA: 0x7FFD54C6EA80
    }

}