// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 10
// Methods: 43

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class Parallel
    {
        // ── Methods ──
        public void CheckTimeoutReached(){} // RVA: 0x7FFAF89F3910
        public void ComputeTimeoutPoint(){} // RVA: 0x7FFAF89F3940
        public void ForWorker(){} // RVA: 0x7FFAF2D33FA0
        public void ForEach(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void ForEachWorker(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void PartitionerForEachWorker(){} // RVA: 0x7FFAF2D33FA0
        public void ReduceToSingleCancellationException(){} // RVA: 0x7FFAF89F3960
        public void ThrowSingleCancellationExceptionOrOtherException(){} // RVA: 0x7FFAF89F3C90
        public void .cctor(){} // RVA: 0x7FFAF89F3CF0
    }

    public class ParallelEtwProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88BE7D0
        public void ParallelLoopBegin(){} // RVA: 0x7FFAF89F3DC0
        public void ParallelLoopEnd(){} // RVA: 0x7FFAF89F3DF0
        public void ParallelFork(){} // RVA: 0x7FFAF3AD0CE0
        public void ParallelJoin(){} // RVA: 0x7FFAF3AD0CE0
        public void .cctor(){} // RVA: 0x7FFAF89F3E20
    }

    public class ParallelLoopResult
    {
    }

    public class ParallelLoopState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
    }

    public class ParallelLoopState32
    {
        public object LowestBreakIteration;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89F3ED0
        public void set_CurrentIteration(){} // RVA: 0x7FFAF344E0D0
    }

    public class ParallelLoopState64
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89F3ED0
        public void set_CurrentIteration(){} // RVA: 0x7FFAF35983A0
    }

    public class ParallelLoopStateFlags
    {
        // ── Methods ──
        public void get_LoopStateFlags(){} // RVA: 0x7FFAF89DAEC0
        public void AtomicLoopStateUpdate(){} // RVA: 0x7FFAF89F4070 | overloaded x2
        public void SetExceptional(){} // RVA: 0x7FFAF89F4180
        public void Cancel(){} // RVA: 0x7FFAF89F4190
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ParallelLoopStateFlags32
    {
        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x7FFAF89F41A0
        public void ShouldExitLoop(){} // RVA: 0x7FFAF89F41E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF89F4200
    }

    public class ParallelLoopStateFlags64
    {
        public object LoopStateFlags;

        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x7FFAF2D907C0
        public void ShouldExitLoop(){} // RVA: 0x7FFAF89F4210
        public void .ctor(){} // RVA: 0x7FFAF89F4240
    }

    public class ParallelOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89F35D0
        public void get_TaskScheduler(){} // RVA: 0x7FFAF2DA8380
        public void get_EffectiveTaskScheduler(){} // RVA: 0x7FFAF89F3750
        public void get_MaxDegreeOfParallelism(){} // RVA: 0x7FFAF306ED50
        public void set_MaxDegreeOfParallelism(){} // RVA: 0x7FFAF89F37B0
        public void get_CancellationToken(){} // RVA: 0x7FFAF2DBB0C0
        public void get_EffectiveMaxConcurrencyLevel(){} // RVA: 0x7FFAF89F3820
    }

}