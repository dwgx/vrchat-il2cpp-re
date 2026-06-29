// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 9
// Methods: 38

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class Parallel : Object
    {
        // ── Methods ──
        public void CheckTimeoutReached(){} // RVA: 0x7ADD32300
        public void ComputeTimeoutPoint(){} // RVA: 0x7ADD32330
        public void ForWorker(){} // RVA: 0x7A8051B10
        public void ForEach(){} // RVA: 0x7AA555860
        public void ForEachWorker(){} // RVA: 0x7AA556050
        public void PartitionerForEachWorker(){} // RVA: 0x7AA559090
        public void ReduceToSingleCancellationException(){} // RVA: 0x7ADD32350
        public void ThrowSingleCancellationExceptionOrOtherException(){} // RVA: 0x7ADD32650
        public void .cctor(){} // RVA: 0x7ADD326B0
    }

    public class ParallelEtwProvider : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBFCE20
        public void ParallelLoopBegin(){} // RVA: 0x7ADD32780
        public void ParallelLoopEnd(){} // RVA: 0x7ADD327B0
        public void ParallelFork(){} // RVA: 0x7A8DD7270
        public void ParallelJoin(){} // RVA: 0x7A8DD7270
        public void .cctor(){} // RVA: 0x7ADD327E0
    }

    public class ParallelLoopState : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class ParallelLoopState32 : ParallelLoopState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD32890
        public void set_CurrentIteration(){} // RVA: 0x7A8738180
    }

    public class ParallelLoopState64 : ParallelLoopState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD32890
        public void set_CurrentIteration(){} // RVA: 0x7A8884B10
    }

    public class ParallelLoopStateFlags : Object
    {
        // ── Methods ──
        public void get_LoopStateFlags(){} // RVA: 0x7ADD19C70
        public void AtomicLoopStateUpdate(){} // RVA: 0x7ADD32A30
        public void SetExceptional(){} // RVA: 0x7ADD32B40
        public void Cancel(){} // RVA: 0x7ADD32B50
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ParallelLoopStateFlags32 : ParallelLoopStateFlags
    {
        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x7ADD32B60
        public void ShouldExitLoop(){} // RVA: 0x7ADD32BA0
        public void .ctor(){} // RVA: 0x7ADD32BC0
    }

    public class ParallelLoopStateFlags64 : ParallelLoopStateFlags
    {
        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x7A80DA7B0
        public void ShouldExitLoop(){} // RVA: 0x7ADD32BD0
        public void .ctor(){} // RVA: 0x7ADD32C00
    }

    public class ParallelOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD31FC0
        public void get_TaskScheduler(){} // RVA: 0x7A80F2570
        public void get_EffectiveTaskScheduler(){} // RVA: 0x7ADD32140
        public void get_MaxDegreeOfParallelism(){} // RVA: 0x7A83782A0
        public void set_MaxDegreeOfParallelism(){} // RVA: 0x7ADD321A0
        public void get_CancellationToken(){} // RVA: 0x7A81052C0
        public void get_EffectiveMaxConcurrencyLevel(){} // RVA: 0x7ADD32210
    }

}