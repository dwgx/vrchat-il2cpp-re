// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 8
// Methods: 37

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class Parallel : Object
    {
        // ── Original Methods ──
        public void ComputeTimeoutPoint(){} // RVA: 0x7ffaae0fc1c0
        public void ForWorker(){} // RVA: 0x7ffaa887e5c0
        public void ForEach(){} // RVA: 0x7ffaa887e5c0
        public void ForEach(){} // RVA: 0x7ffaa887e5c0
        public void ForEachWorker(){} // RVA: 0x7ffaa887e5c0
        public void ForEachWorker(){} // RVA: 0x7ffaa887e5c0
        public void ForEachWorker(){} // RVA: 0x7ffaa887e5c0
        public void PartitionerForEachWorker(){} // RVA: 0x7ffaa887e5c0
        public void ReduceToSingleCancellationException(){} // RVA: 0x7ffaae0fc1e0
        public void ThrowSingleCancellationExceptionOrOtherException(){} // RVA: 0x7ffaae0fc510
        public void .cctor(){} // RVA: 0x7ffaae0fc570
        // ── Binary Analysis Named ──
        public void CheckTimeoutReached(){} // RVA: 0x7ffaae0fc190
    }

    public class ParallelEtwProvider : EventSource
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadfc7050
        public void ParallelLoopBegin(){} // RVA: 0x7ffaae0fc640
        public void ParallelLoopEnd(){} // RVA: 0x7ffaae0fc670
        public void ParallelFork(){} // RVA: 0x7ffaa94a7020
        public void ParallelJoin(){} // RVA: 0x7ffaa94a7020
        public void .cctor(){} // RVA: 0x7ffaae0fc6a0
    }

    public class ParallelLoopResult : ValueType
    {
    }

    public class ParallelLoopState : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
    }

    public class ParallelLoopState64 : ParallelLoopState
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae0fc750
        public void set_CurrentIteration(){} // RVA: 0x7ffaa9137320
    }

    public class ParallelLoopStateFlags : Object
    {
        // ── Original Methods ──
        public void get_LoopStateFlags(){} // RVA: 0x7ffaae0e3740
        public void AtomicLoopStateUpdate(){} // RVA: 0x7ffaae0fc8f0
        public void AtomicLoopStateUpdate(){} // RVA: 0x7ffaae0fc8f0
        public void Cancel(){} // RVA: 0x7ffaae0fca10
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetExceptional(){} // RVA: 0x7ffaae0fca00
    }

    public class ParallelLoopStateFlags64 : ParallelLoopStateFlags
    {
        // ── Original Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x7ffaa89357c0
        public void ShouldExitLoop(){} // RVA: 0x7ffaae0fca90
        public void .ctor(){} // RVA: 0x7ffaae0fcac0
    }

    public class ParallelOptions : Object
    {
        public object _cancellationToken; // 0x366F9560
        public object TaskScheduler; // 0x17000219

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae0fbe50
        public void get_TaskScheduler(){} // RVA: 0x7ffaa894d380
        public void get_EffectiveTaskScheduler(){} // RVA: 0x7ffaae0fbfd0
        public void get_MaxDegreeOfParallelism(){} // RVA: 0x7ffaa8b945a0
        public void set_MaxDegreeOfParallelism(){} // RVA: 0x7ffaae0fc030
        public void get_CancellationToken(){} // RVA: 0x7ffaa89600c0
        public void get_EffectiveMaxConcurrencyLevel(){} // RVA: 0x7ffaae0fc0a0
    }

}