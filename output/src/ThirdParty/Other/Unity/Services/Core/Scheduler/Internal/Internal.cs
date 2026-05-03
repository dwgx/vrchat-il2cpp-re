// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
// Classes: 8
// Methods: 29

namespace ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
{
    public class ActionScheduler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87AA5E50 | overloaded x2
        public void ExecuteExpiredActions(){} // RVA: 0x7FFE87AA6350
        public void UpdateCurrentPlayerLoopWith(){} // RVA: 0x7FFE87AA69B0
        public void JoinPlayerLoopSystem(){} // RVA: 0x7FFE87AA6A80
    }

    public class IActionScheduler
    {
    }

    public class ITimeProvider
    {
        // ── Methods ──
        public void get_Now(){} // RVA: 0x7FFE80E2E2E0
    }

    public class MinimumBinaryHeap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MinimumBinaryHeap`1 : MinimumBinaryHeap
    {
        public object m_Lock;
        public System.Collections.Generic.IComparer`1<T> m_Comparer;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void set_Count(){} // RVA: 0x7FFE80E46530
        public void get_Min(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E4D070 | overloaded x2
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void IncreaseHeapCapacityWhenFull(){} // RVA: 0x7FFE80E45FE0
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void ExtractMin(){} // RVA: 0x7FFE810A1420
        public void DecreaseHeapCapacityWhenSpare(){} // RVA: 0x7FFE80E45FE0
        public void MinHeapify(){} // RVA: 0x7FFE80E45FE0
        public void Swap(){} // RVA: 0x7FFE80E462E0
        public void GetParentIndex(){} // RVA: 0x7FFE80E35560
        public void GetLeftChildIndex(){} // RVA: 0x7FFE80E35560
        public void GetRightChildIndex(){} // RVA: 0x7FFE80E35560
        public void <MinHeapify>g__UpdateSmallestIndex|21_0(){} // RVA: 0x7FFE80E460A0
        public void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(){} // RVA: 0x7FFE80E48220
    }

    public class ScheduledInvocation : Object
    {
    }

    public class ScheduledInvocationComparer : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFE87AA6D20
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UtcTimeProvider : Object
    {
        // ── Methods ──
        public void get_Now(){} // RVA: 0x7FFE87AA6DF0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}