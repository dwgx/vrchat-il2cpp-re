// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 9
// Methods: 38

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class Parallel : Object
    {
        public object s_forkJoinContextID;
        public object s_defaultParallelOptions;

        // ── Methods ──
        public void CheckTimeoutReached(){} // RVA: 0x69BB0A0
        public void ComputeTimeoutPoint(){} // RVA: 0x69BB0D0
        public void ForWorker(){} // RVA: 0xA94080
        public void ForEach(){} // RVA: 0x317E550
        public void ForEachWorker(){} // RVA: 0x317ED40
        public void PartitionerForEachWorker(){} // RVA: 0x3181D80
        public void ReduceToSingleCancellationException(){} // RVA: 0x69BB0F0
        public void ThrowSingleCancellationExceptionOrOtherException(){} // RVA: 0x69BB3F0
        public void .cctor(){} // RVA: 0x69BB450
    }

    public class ParallelEtwProvider : EventSource
    {
        public object Log;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6888090
        public void ParallelLoopBegin(){} // RVA: 0x69BB520
        public void ParallelLoopEnd(){} // RVA: 0x69BB550
        public void ParallelFork(){} // RVA: 0x18F3EB0
        public void ParallelJoin(){} // RVA: 0x18F3EB0
        public void .cctor(){} // RVA: 0x69BB580
    }

    public class ParallelLoopState : Object
    {
        public object _flagsBase;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class ParallelLoopState32 : ParallelLoopState
    {
        public object _sharedParallelStateFlags;
        public object _currentIteration;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69BB630
        public void set_CurrentIteration(){} // RVA: 0x1269760
    }

    public class ParallelLoopState64 : ParallelLoopState
    {
        public object _sharedParallelStateFlags;
        public object _currentIteration;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69BB630
        public void set_CurrentIteration(){} // RVA: 0x13B3F80
    }

    public class ParallelLoopStateFlags : Object
    {
        public object _loopStateFlags;

        // ── Methods ──
        public void get_LoopStateFlags(){} // RVA: 0x69A2AA0
        public void AtomicLoopStateUpdate(){} // RVA: 0x69BB7D0
        public void SetExceptional(){} // RVA: 0x69BB8E0
        public void Cancel(){} // RVA: 0x69BB8F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ParallelLoopStateFlags32 : ParallelLoopStateFlags
    {
        public object _lowestBreakIteration;

        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x69BB900
        public void ShouldExitLoop(){} // RVA: 0x69BB940
        public void .ctor(){} // RVA: 0x69BB960
    }

    public class ParallelLoopStateFlags64 : ParallelLoopStateFlags
    {
        public object _lowestBreakIteration;

        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0xB465B0
        public void ShouldExitLoop(){} // RVA: 0x69BB970
        public void .ctor(){} // RVA: 0x69BB9A0
    }

    public class ParallelOptions : Object
    {
        public object _scheduler;
        public object _maxDegreeOfParallelism;
        public object _cancellationToken;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69BAD60
        public void get_TaskScheduler(){} // RVA: 0xB5DBF0
        public void get_EffectiveTaskScheduler(){} // RVA: 0x69BAEE0
        public void get_MaxDegreeOfParallelism(){} // RVA: 0xE62D00
        public void set_MaxDegreeOfParallelism(){} // RVA: 0x69BAF40
        public void get_CancellationToken(){} // RVA: 0xB700F0
        public void get_EffectiveMaxConcurrencyLevel(){} // RVA: 0x69BAFB0
    }

}