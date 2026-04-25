// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
// Classes: 8
// Methods: 29

namespace ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
{
    public class ActionScheduler : Object
    {
        public UnityEngine.LowLevel.PlayerLoopSystem SchedulerLoopSystem; // 0x10
        public Unity.Services.Core.Scheduler.Internal.ITimeProvider m_TimeProvider; // 0x38
        public object m_Lock; // 0x40
        public Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap`1<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_ScheduledActions; // 0x48
        public System.Collections.Generic.Dictionary`2<long,Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_IdScheduledInvocationMap; // 0x50
        public System.Collections.Generic.List`1<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_ExpiredActions; // 0x58
        public long m_NextId; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96FD8E0 | overloaded x2
        public void ExecuteExpiredActions(){} // RVA: 0x7FFAC96FDDE0
        public void UpdateCurrentPlayerLoopWith(){} // RVA: 0x7FFAC96FE440
        public void JoinPlayerLoopSystem(){} // RVA: 0x7FFAC96FE510
    }

    public class IActionScheduler
    {
    }

    public class ITimeProvider
    {
        public object Now;

        // ── Methods ──
        public void get_Now(){} // RVA: 0x7FFAC2C58E90
    }

    public class MinimumBinaryHeap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MinimumBinaryHeap`1 : MinimumBinaryHeap
    {
        public object Count;
        public System.Collections.Generic.IComparer`1<T> Min;
        public int m_MinimumCapacity;
        public T[] m_HeapArray;
        public int <Count>k__BackingField;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void set_Count(){} // RVA: 0x7FFAC2C70ED0
        public void get_Min(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C77970 | overloaded x2
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void IncreaseHeapCapacityWhenFull(){} // RVA: 0x7FFAC2C70980
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void ExtractMin(){} // RVA: 0x7FFAC2E8DC40
        public void DecreaseHeapCapacityWhenSpare(){} // RVA: 0x7FFAC2C70980
        public void MinHeapify(){} // RVA: 0x7FFAC2C70980
        public void Swap(){} // RVA: 0x7FFAC2C70C80
        public void GetParentIndex(){} // RVA: 0x7FFAC2C60110
        public void GetLeftChildIndex(){} // RVA: 0x7FFAC2C60110
        public void GetRightChildIndex(){} // RVA: 0x7FFAC2C60110
        public void <MinHeapify>g__UpdateSmallestIndex|21_0(){} // RVA: 0x7FFAC2C70A40
        public void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(){} // RVA: 0x7FFAC2C72BC0
    }

    public class ScheduledInvocation : Object
    {
        public System.Action Action; // 0x10
        public System.DateTime InvocationTime; // 0x18
        public long ActionId; // 0x20
    }

    public class ScheduledInvocationComparer : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAC96FE7B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UtcTimeProvider : Object
    {
        public object Now;

        // ── Methods ──
        public void get_Now(){} // RVA: 0x7FFAC96FE880
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}