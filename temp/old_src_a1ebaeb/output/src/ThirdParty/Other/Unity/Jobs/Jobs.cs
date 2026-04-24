// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Jobs
// Classes: 6
// Methods: 24

namespace ThirdParty.Other.Unity.Jobs
{
    public class EarlyInitHelpers : Object
    {
        public object 00; // 0x852546B8

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaef30370
        public void FlushEarlyInits(){} // RVA: 0x7ffaaef30380
        public void JobReflectionDataCreationFailed(){} // RVA: 0x7ffaaef30540
    }

    public class IJob
    {
        // ── Original Methods ──
        public void Execute(){} // RVA: 0x7ffaa8660cc0
    }

    public class IJobExtensions : Object
    {
        // ── Original Methods ──
        public void EarlyJobInit(){} // RVA: 0x7ffaa8660cf0
        public void Schedule(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetReflectionData(){} // RVA: 0x7ffaa8648dd0
    }

    public class IJobParallelFor
    {
        // ── Original Methods ──
        public void Execute(){} // RVA: 0x7ffaa8661210
    }

    public class IJobParallelForExtensions : Object
    {
        // ── Original Methods ──
        public void EarlyJobInit(){} // RVA: 0x7ffaa8660cf0
        public void Schedule(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetReflectionData(){} // RVA: 0x7ffaa8648dd0
    }

    public class JobHandle : ValueType
    {
        // ── Original Methods ──
        public void Complete(){} // RVA: 0x7ffaaf270530
        public void get_IsCompleted(){} // RVA: 0x7ffaaf270590
        public void ScheduleBatchedJobs(){} // RVA: 0x7ffaaf2705e0
        public void ScheduleBatchedJobsAndComplete(){} // RVA: 0x7ffaaf270630
        public void ScheduleBatchedJobsAndIsCompleted(){} // RVA: 0x7ffaaf270590
        public void CombineDependencies(){} // RVA: 0x7ffaaf2707b0
        public void CombineDependencies(){} // RVA: 0x7ffaaf2707b0
        public void CombineDependencies(){} // RVA: 0x7ffaaf2707b0
        public void CombineDependenciesInternal2(){} // RVA: 0x7ffaaf270860
        public void CombineDependenciesInternalPtr(){} // RVA: 0x7ffaaf2708e0
        public void Equals(){} // RVA: 0x7ffaaf270960
        public void CombineDependenciesInternal2_Injected(){} // RVA: 0x7ffaaf270970
        public void CombineDependenciesInternalPtr_Injected(){} // RVA: 0x7ffaaf2709e0
    }

}