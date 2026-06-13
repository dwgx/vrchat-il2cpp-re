// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Jobs
// Classes: 4
// Methods: 49

namespace ThirdParty.Unity.UnityEngine.Jobs
{
    public class IJobParallelForTransform
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x283FA0
    }

    public class IJobParallelForTransformExtensions
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x24A80
        public void GetReflectionData(){} // RVA: 0xC960
        public void Schedule(){} // RVA: 0x283FA0
        public void ScheduleReadOnly(){} // RVA: 0x283FA0
        public void ScheduleReadOnlyByRef(){} // RVA: 0x283FA0
    }

    public class TransformAccess
    {
        public UIntPtr Header; // 0x10
        public int IntermediateScriptingStructName; // 0x18

        // ── Methods ──
        public void get_position(){} // RVA: 0x7143090
        public void get_rotation(){} // RVA: 0x7143120
        public void get_localPosition(){} // RVA: 0x71431A0
        public void set_localPosition(){} // RVA: 0x7143230
        public void get_localRotation(){} // RVA: 0x7143290
        public void set_localRotation(){} // RVA: 0x7143310
        public void get_localScale(){} // RVA: 0x7143370
        public void set_localScale(){} // RVA: 0x7143400
        public void get_localToWorldMatrix(){} // RVA: 0x7143460
        public void get_isValid(){} // RVA: 0x34C1790
        public void SetLocalPositionAndRotation(){} // RVA: 0x7143510
        public void SetLocalPositionAndRotation_Internal(){} // RVA: 0x7143580
        public void GetPosition(){} // RVA: 0x71435F0
        public void GetRotation(){} // RVA: 0x7143650
        public void GetLocalPosition(){} // RVA: 0x71436B0
        public void SetLocalPosition(){} // RVA: 0x7143710
        public void GetLocalRotation(){} // RVA: 0x7143770
        public void SetLocalRotation(){} // RVA: 0x71437D0
        public void GetLocalScale(){} // RVA: 0x7143830
        public void SetLocalScale(){} // RVA: 0x7143890
        public void GetLocalToWorldMatrix(){} // RVA: 0x71438F0
    }

    public class TransformAccessArray
    {
        public UIntPtr m_TransformArray; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71439D0 | overloaded x2
        public void Allocate(){} // RVA: 0x71439F0
        public void get_isCreated(){} // RVA: 0x709C440
        public void Dispose(){} // RVA: 0x7143AB0
        public void GetTransformAccessArrayForSchedule(){} // RVA: 0x2738C50
        public void get_Item(){} // RVA: 0x7143B60
        public void set_Item(){} // RVA: 0x7143BC0
        public void get_length(){} // RVA: 0x7143C30
        public void Add(){} // RVA: 0x7143EB0 | overloaded x2
        public void RemoveAtSwapBack(){} // RVA: 0x7143F10 | overloaded x2
        public void SetTransforms(){} // RVA: 0x7143E50 | overloaded x2
        public void Create(){} // RVA: 0x7143DA0
        public void DestroyTransformAccessArray(){} // RVA: 0x7143E00
        public void GetSortedTransformAccess(){} // RVA: 0x7143F70
        public void GetSortedToUserIndex(){} // RVA: 0x7143FC0
        public void GetLength(){} // RVA: 0x7144010
        public void GetTransform(){} // RVA: 0x7144060
        public void SetTransform(){} // RVA: 0x71440C0
    }

}