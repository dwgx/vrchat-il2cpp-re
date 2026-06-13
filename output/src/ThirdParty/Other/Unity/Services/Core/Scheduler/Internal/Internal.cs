// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
// Classes: 8
// Methods: 29

namespace ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
{
    public class ActionScheduler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F64FC0 | overloaded x2
        public void ExecuteExpiredActions(){} // RVA: 0x6F654C0
        public void UpdateCurrentPlayerLoopWith(){} // RVA: 0x6F65B20
        public void JoinPlayerLoopSystem(){} // RVA: 0x6F65BF0
    }

    public class IActionScheduler
    {
    }

    public class ITimeProvider
    {
        // ── Methods ──
        public void get_Now(){} // RVA: 0xCD60
    }

    public class MinimumBinaryHeap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MinimumBinaryHeap`1
    {
        public object m_Lock;
        public System.Collections.Generic.IComparer`1<T> m_Comparer;

        // ── Methods ──
        public void get_Count(){} // RVA: 0xD840
        public void set_Count(){} // RVA: 0x24FA0
        public void get_Min(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x2BAA0 | overloaded x2
        public void Insert(){} // RVA: 0x283FA0
        public void IncreaseHeapCapacityWhenFull(){} // RVA: 0x24A50
        public void Remove(){} // RVA: 0x283FA0
        public void IndexOf(){} // RVA: 0x283FA0
        public void ExtractMin(){} // RVA: 0x283FA0
        public void DecreaseHeapCapacityWhenSpare(){} // RVA: 0x24A50
        public void MinHeapify(){} // RVA: 0x24A50
        public void Swap(){} // RVA: 0x24D50
        public void GetParentIndex(){} // RVA: 0x13FF0
        public void GetLeftChildIndex(){} // RVA: 0x13FF0
        public void GetRightChildIndex(){} // RVA: 0x13FF0
        public void <MinHeapify>g__UpdateSmallestIndex|21_0(){} // RVA: 0x24B10
        public void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(){} // RVA: 0x26C40
    }

    public class ScheduledInvocation
    {
    }

    public class ScheduledInvocationComparer
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x6F65E90
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UtcTimeProvider
    {
        // ── Methods ──
        public void get_Now(){} // RVA: 0x6F65F60
        public void .ctor(){} // RVA: 0x2DD310
    }

}