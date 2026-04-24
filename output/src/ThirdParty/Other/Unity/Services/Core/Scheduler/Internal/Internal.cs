// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
// Classes: 8
// Methods: 29

namespace ThirdParty.Other.Unity.Services.Core.Scheduler.Internal
{
    public class ActionScheduler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B1D8E0 | overloaded x2
        public void ExecuteExpiredActions(){} // RVA: 0x7FFD54B1DDE0
        public void UpdateCurrentPlayerLoopWith(){} // RVA: 0x7FFD54B1E440
        public void JoinPlayerLoopSystem(){} // RVA: 0x7FFD54B1E510
    }

    public class IActionScheduler
    {
        public int MaxCameras;
        public float m_Weight0; // 0xA8
        public float m_Weight1; // 0xAC
        public float m_Weight2; // 0xB0
        public float m_Weight3; // 0xB4
        public float m_Weight4; // 0xB8
        public float m_Weight5; // 0xBC
        public float m_Weight6; // 0xC0
        public float m_Weight7; // 0xC4
        public EXTERNAL_INDEX_REF_SIG.eResult m_State; // 0xC8
        public EXTERNAL_INDEX_REF_SIG.Callback <LiveChild>k__BackingField; // 0x1B0
        public object <LookAt>k__BackingField; // 0x1B8
        public object <Follow>k__BackingField; // 0x1C0
        public EXTERNAL_INDEX_REF_SIG.StaticFieldGetter[] m_ChildCameras; // 0x1C8
        public URA.DateTime<EXTERNAL_INDEX_REF_SIG.StaticFieldGetter,int> m_indexMap; // 0x1D0
    }

    public class ITimeProvider
    {
        public object Now;

        // ── Methods ──
        public void get_Now(){} // RVA: 0x7FFD4E078E90
    }

    public class MinimumBinaryHeap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class MinimumBinaryHeap`1 : MinimumBinaryHeap
    {
        public object Count;
        public object Min;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void set_Count(){} // RVA: 0x7FFD4E090ED0
        public void get_Min(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E097970 | overloaded x2
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void IncreaseHeapCapacityWhenFull(){} // RVA: 0x7FFD4E090980
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void ExtractMin(){} // RVA: 0x7FFD4E2ADC40
        public void DecreaseHeapCapacityWhenSpare(){} // RVA: 0x7FFD4E090980
        public void MinHeapify(){} // RVA: 0x7FFD4E090980
        public void Swap(){} // RVA: 0x7FFD4E090C80
        public void GetParentIndex(){} // RVA: 0x7FFD4E080110
        public void GetLeftChildIndex(){} // RVA: 0x7FFD4E080110
        public void GetRightChildIndex(){} // RVA: 0x7FFD4E080110
        public void <MinHeapify>g__UpdateSmallestIndex|21_0(){} // RVA: 0x7FFD4E090A40
        public void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(){} // RVA: 0x7FFD4E092BC0
    }

    public class ScheduledInvocation : Object
    {
    }

    public class ScheduledInvocationComparer : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFD54B1E7B0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UtcTimeProvider : Object
    {
        public object Now;

        // ── Methods ──
        public void get_Now(){} // RVA: 0x7FFD54B1E880
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}