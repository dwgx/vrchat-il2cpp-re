// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Jobs
// Classes: 3
// Methods: 28

namespace ThirdParty.Unity.UnityEngine.Jobs
{
    public class IJobParallelForTransform
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IJobParallelForTransformExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7FFD4E0909B0
        public void GetReflectionData(){} // RVA: 0x7FFD4E078A90
        public void Schedule(){} // RVA: 0x7FFD4E2ADC40
        public void ScheduleReadOnly(){} // RVA: 0x7FFD4E2ADC40
        public void ScheduleReadOnlyByRef(){} // RVA: 0x7FFD4E2ADC40
    }

    public class TransformAccessArray : ValueType
    {
        public UIntPtr isCreated; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54CFBF10 | overloaded x2
        public void Allocate(){} // RVA: 0x7FFD54CFBF30
        public void get_isCreated(){} // RVA: 0x7FFD54C54DB0
        public void Dispose(){} // RVA: 0x7FFD54CFBFF0
        public void GetTransformAccessArrayForSchedule(){} // RVA: 0x7FFD505F9A30
        public void get_Item(){} // RVA: 0x7FFD54CFC0A0
        public void set_Item(){} // RVA: 0x7FFD54CFC100
        public void get_length(){} // RVA: 0x7FFD54CFC170
        public void Add(){} // RVA: 0x7FFD54CFC3F0 | overloaded x2
        public void RemoveAtSwapBack(){} // RVA: 0x7FFD54CFC450 | overloaded x2
        public void SetTransforms(){} // RVA: 0x7FFD54CFC390 | overloaded x2
        public void Create(){} // RVA: 0x7FFD54CFC2E0
        public void DestroyTransformAccessArray(){} // RVA: 0x7FFD54CFC340
        public void GetSortedTransformAccess(){} // RVA: 0x7FFD54CFC4B0
        public void GetSortedToUserIndex(){} // RVA: 0x7FFD54CFC500
        public void GetLength(){} // RVA: 0x7FFD54CFC550
        public void GetTransform(){} // RVA: 0x7FFD54CFC5A0
        public void SetTransform(){} // RVA: 0x7FFD54CFC600
    }

}