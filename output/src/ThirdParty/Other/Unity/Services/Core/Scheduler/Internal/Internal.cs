// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
// Classes: 6
// Methods: 27

namespace ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
{
    public class ActionScheduler : Object
    {
        public object SchedulerLoopSystem;
        public object m_TimeProvider;
        public object m_Lock;
        public object m_ScheduledActions;
        public object m_IdScheduledInvocationMap;
        public object m_ExpiredActions;
        public object m_NextId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x79AFF80
        public void ExecuteExpiredActions(){} // RVA: 0x79B0480
        public void UpdateCurrentPlayerLoopWith(){} // RVA: 0x79B0AA0
        public void JoinPlayerLoopSystem(){} // RVA: 0x79B0B70
    }

    public class ITimeProvider
    {
        // ── Methods ──
        public void get_Now(){} // RVA: 0x87C0A0
    }

    public class MinimumBinaryHeap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MinimumBinaryHeap`1 : MinimumBinaryHeap
    {
        public object m_Lock;
        public object m_Comparer;
        public object m_MinimumCapacity;
        public object m_HeapArray;
        public object _count;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x87C130
        public void set_Count(){} // RVA: 0x8944F0
        public void get_Min(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x895FE0
        public void Insert(){} // RVA: 0xA94080
        public void IncreaseHeapCapacityWhenFull(){} // RVA: 0x894290
        public void Remove(){} // RVA: 0xA94080
        public void IndexOf(){} // RVA: 0xA94080
        public void ExtractMin(){} // RVA: 0xA94080
        public void DecreaseHeapCapacityWhenSpare(){} // RVA: 0x894290
        public void MinHeapify(){} // RVA: 0x894290
        public void Swap(){} // RVA: 0x8945C0
        public void GetParentIndex(){} // RVA: 0x883700
        public void GetLeftChildIndex(){} // RVA: 0x883700
        public void GetRightChildIndex(){} // RVA: 0x883700
        public void <MinHeapify>g__UpdateSmallestIndex|21_0(){} // RVA: 0x894320
        public void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(){} // RVA: 0x895750
    }

    public class ScheduledInvocationComparer : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x79B0E10
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UtcTimeProvider : Object
    {
        // ── Methods ──
        public void get_Now(){} // RVA: 0x79B0ED0
        public void .ctor(){} // RVA: 0xB43310
    }

}