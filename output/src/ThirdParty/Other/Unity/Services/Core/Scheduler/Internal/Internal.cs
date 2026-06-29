// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
// Classes: 6
// Methods: 27

namespace ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
{
    public class ActionScheduler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AED434F0
        public void ExecuteExpiredActions(){} // RVA: 0x7AED43A20
        public void UpdateCurrentPlayerLoopWith(){} // RVA: 0x7AED44040
        public void JoinPlayerLoopSystem(){} // RVA: 0x7AED44110
    }

    public class ITimeProvider
    {
        // ── Methods ──
        public void get_Now(){} // RVA: 0x7A7E00680
    }

    public class MinimumBinaryHeap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class MinimumBinaryHeap`1 : MinimumBinaryHeap
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7A7E00710
        public void set_Count(){} // RVA: 0x7A7E189D0
        public void get_Min(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A7E1A470
        public void Insert(){} // RVA: 0x7A8051B10
        public void IncreaseHeapCapacityWhenFull(){} // RVA: 0x7A7E18770
        public void Remove(){} // RVA: 0x7A8051B10
        public void IndexOf(){} // RVA: 0x7A8051B10
        public void ExtractMin(){} // RVA: 0x7A8051B10
        public void DecreaseHeapCapacityWhenSpare(){} // RVA: 0x7A7E18770
        public void MinHeapify(){} // RVA: 0x7A7E18770
        public void Swap(){} // RVA: 0x7A7E18AA0
        public void GetParentIndex(){} // RVA: 0x7A7E07D40
        public void GetLeftChildIndex(){} // RVA: 0x7A7E07D40
        public void GetRightChildIndex(){} // RVA: 0x7A7E07D40
        public void <MinHeapify>g__UpdateSmallestIndex|21_0(){} // RVA: 0x7A7E18800
        public void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(){} // RVA: 0x7A7E19BE0
    }

    public class ScheduledInvocationComparer : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7AED443B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UtcTimeProvider : Object
    {
        // ── Methods ──
        public void get_Now(){} // RVA: 0x7AED44470
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}