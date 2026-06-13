// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 10
// Methods: 43

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class Parallel
    {
        // ── Methods ──
        public void CheckTimeoutReached(){} // RVA: 0x5F43910
        public void ComputeTimeoutPoint(){} // RVA: 0x5F43940
        public void ForWorker(){} // RVA: 0x283FA0
        public void ForEach(){} // RVA: 0x283FA0 | overloaded x2
        public void ForEachWorker(){} // RVA: 0x283FA0 | overloaded x3
        public void PartitionerForEachWorker(){} // RVA: 0x283FA0
        public void ReduceToSingleCancellationException(){} // RVA: 0x5F43960
        public void ThrowSingleCancellationExceptionOrOtherException(){} // RVA: 0x5F43C90
        public void .cctor(){} // RVA: 0x5F43CF0
    }

    public class ParallelEtwProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E0E7D0
        public void ParallelLoopBegin(){} // RVA: 0x5F43DC0
        public void ParallelLoopEnd(){} // RVA: 0x5F43DF0
        public void ParallelFork(){} // RVA: 0x1020CE0
        public void ParallelJoin(){} // RVA: 0x1020CE0
        public void .cctor(){} // RVA: 0x5F43E20
    }

    public class ParallelLoopResult
    {
    }

    public class ParallelLoopState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class ParallelLoopState32
    {
        public System.Threading.Tasks.ParallelLoopStateFlags32 LowestBreakIteration; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F43ED0
        public void set_CurrentIteration(){} // RVA: 0x99E0D0
    }

    public class ParallelLoopState64
    {
        public System.Threading.Tasks.ParallelLoopStateFlags64 _sharedParallelStateFlags; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F43ED0
        public void set_CurrentIteration(){} // RVA: 0xAE83A0
    }

    public class ParallelLoopStateFlags
    {
        public int _loopStateFlags; // 0x10

        // ── Methods ──
        public void get_LoopStateFlags(){} // RVA: 0x5F2AEC0
        public void AtomicLoopStateUpdate(){} // RVA: 0x5F44070 | overloaded x2
        public void SetExceptional(){} // RVA: 0x5F44180
        public void Cancel(){} // RVA: 0x5F44190
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ParallelLoopStateFlags32
    {
        public int _lowestBreakIteration; // 0x18

        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x5F441A0
        public void ShouldExitLoop(){} // RVA: 0x5F441E0 | overloaded x2
        public void .ctor(){} // RVA: 0x5F44200
    }

    public class ParallelLoopStateFlags64
    {
        public long LoopStateFlags; // 0x18

        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x2E07C0
        public void ShouldExitLoop(){} // RVA: 0x5F44210
        public void .ctor(){} // RVA: 0x5F44240
    }

    public class ParallelOptions
    {
        public System.Threading.Tasks.TaskScheduler _scheduler; // 0x10
        public int _maxDegreeOfParallelism; // 0x18
        public System.Threading.CancellationToken _cancellationToken; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F435D0
        public void get_TaskScheduler(){} // RVA: 0x2F8380
        public void get_EffectiveTaskScheduler(){} // RVA: 0x5F43750
        public void get_MaxDegreeOfParallelism(){} // RVA: 0x5BED50
        public void set_MaxDegreeOfParallelism(){} // RVA: 0x5F437B0
        public void get_CancellationToken(){} // RVA: 0x30B0C0
        public void get_EffectiveMaxConcurrencyLevel(){} // RVA: 0x5F43820
    }

}