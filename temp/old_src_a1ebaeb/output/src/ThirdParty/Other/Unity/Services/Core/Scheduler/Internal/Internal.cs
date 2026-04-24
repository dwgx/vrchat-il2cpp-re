// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
// Classes: 8
// Methods: 29

namespace ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
{
    public class ActionScheduler : Object
    {
        public object m_Lock; // 0x33727320
        public object m_ExpiredActions; // 0x33727320
        public object (+00; // 0x854DBCE0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf11f8c0
        public void .ctor(){} // RVA: 0x7ffaaf11f8c0
        public void ExecuteExpiredActions(){} // RVA: 0x7ffaaf11fdc0
        public void UpdateCurrentPlayerLoopWith(){} // RVA: 0x7ffaaf120420
        public void JoinPlayerLoopSystem(){} // RVA: 0x7ffaaf1204f0
    }

    public class IActionScheduler
    {
    }

    public class ITimeProvider
    {
        // ── Original Methods ──
        public void get_Now(){} // RVA: 0x7ffaa86491d0
    }

    public class MinimumBinaryHeap : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class MinimumBinaryHeap`1 : MinimumBinaryHeap
    {
        public object m_MinimumCapacity; // 0x3122A730

        // ── Original Methods ──
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void set_Count(){} // RVA: 0x7ffaa8661210
        public void get_Min(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8667cb0
        public void .ctor(){} // RVA: 0x7ffaa8667cb0
        public void Insert(){} // RVA: 0x7ffaa887e5c0
        public void IncreaseHeapCapacityWhenFull(){} // RVA: 0x7ffaa8660cc0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void IndexOf(){} // RVA: 0x7ffaa887e5c0
        public void ExtractMin(){} // RVA: 0x7ffaa887e5c0
        public void DecreaseHeapCapacityWhenSpare(){} // RVA: 0x7ffaa8660cc0
        public void MinHeapify(){} // RVA: 0x7ffaa8660cc0
        public void Swap(){} // RVA: 0x7ffaa8660fc0
        public void <MinHeapify>g__UpdateSmallestIndex|21_0(){} // RVA: 0x7ffaa8660d80
        public void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(){} // RVA: 0x7ffaa8662f00
        // ── Binary Analysis Named ──
        public void GetParentIndex(){} // RVA: 0x7ffaa8650450
        public void GetLeftChildIndex(){} // RVA: 0x7ffaa8650450
        public void GetRightChildIndex(){} // RVA: 0x7ffaa8650450
    }

    public class ScheduledInvocation : Object
    {
        public object ActionId; // 0x333CABA0
    }

    public class ScheduledInvocationComparer : Object
    {
        // ── Original Methods ──
        public void Compare(){} // RVA: 0x7ffaaf120790
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class UtcTimeProvider : Object
    {
        // ── Original Methods ──
        public void get_Now(){} // RVA: 0x7ffaaf120860
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}