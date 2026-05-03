// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Jobs
// Classes: 4
// Methods: 49

namespace ThirdParty.Unity.UnityEngine.Jobs
{
    public class IJobParallelForTransform
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE810A1420
    }

    public class IJobParallelForTransformExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7FFE80E46010
        public void GetReflectionData(){} // RVA: 0x7FFE80E2DEE0
        public void Schedule(){} // RVA: 0x7FFE810A1420
        public void ScheduleReadOnly(){} // RVA: 0x7FFE810A1420
        public void ScheduleReadOnlyByRef(){} // RVA: 0x7FFE810A1420
    }

    public class TransformAccess : ValueType
    {
        public UIntPtr hierarchy; // 0x10
        public int index; // 0x18
        public object field_2; // 0xF348
        public object field_3; // 0x9C53
        public object field_4; // 0xB238
        public object field_5;
        public object field_6;

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFE87C83D00
        public void get_rotation(){} // RVA: 0x7FFE87C83D90
        public void get_localPosition(){} // RVA: 0x7FFE87C83E10
        public void set_localPosition(){} // RVA: 0x7FFE87C83EA0
        public void get_localRotation(){} // RVA: 0x7FFE87C83F00
        public void set_localRotation(){} // RVA: 0x7FFE87C83F80
        public void get_localScale(){} // RVA: 0x7FFE87C83FE0
        public void set_localScale(){} // RVA: 0x7FFE87C84070
        public void get_localToWorldMatrix(){} // RVA: 0x7FFE87C840D0
        public void get_isValid(){} // RVA: 0x7FFE8412EC80
        public void SetLocalPositionAndRotation(){} // RVA: 0x7FFE87C84180
        public void SetLocalPositionAndRotation_Internal(){} // RVA: 0x7FFE87C841F0
        public void GetPosition(){} // RVA: 0x7FFE87C84260
        public void GetRotation(){} // RVA: 0x7FFE87C842C0
        public void GetLocalPosition(){} // RVA: 0x7FFE87C84320
        public void SetLocalPosition(){} // RVA: 0x7FFE87C84380
        public void GetLocalRotation(){} // RVA: 0x7FFE87C843E0
        public void SetLocalRotation(){} // RVA: 0x7FFE87C84440
        public void GetLocalScale(){} // RVA: 0x7FFE87C844A0
        public void SetLocalScale(){} // RVA: 0x7FFE87C84500
        public void GetLocalToWorldMatrix(){} // RVA: 0x7FFE87C84560
    }

    public class TransformAccessArray : ValueType
    {
        public UIntPtr m_TransformArray; // 0x10
        public object field_1; // 0x18B0
        public object field_2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C84640 | overloaded x2
        public void Allocate(){} // RVA: 0x7FFE87C84660
        public void get_isCreated(){} // RVA: 0x7FFE87BDD300
        public void Dispose(){} // RVA: 0x7FFE87C84720
        public void GetTransformAccessArrayForSchedule(){} // RVA: 0x7FFE8348B260
        public void get_Item(){} // RVA: 0x7FFE87C847D0
        public void set_Item(){} // RVA: 0x7FFE87C84830
        public void get_length(){} // RVA: 0x7FFE87C848A0
        public void Add(){} // RVA: 0x7FFE87C84B20 | overloaded x2
        public void RemoveAtSwapBack(){} // RVA: 0x7FFE87C84B80 | overloaded x2
        public void SetTransforms(){} // RVA: 0x7FFE87C84AC0 | overloaded x2
        public void Create(){} // RVA: 0x7FFE87C84A10
        public void DestroyTransformAccessArray(){} // RVA: 0x7FFE87C84A70
        public void GetSortedTransformAccess(){} // RVA: 0x7FFE87C84BE0
        public void GetSortedToUserIndex(){} // RVA: 0x7FFE87C84C30
        public void GetLength(){} // RVA: 0x7FFE87C84C80
        public void GetTransform(){} // RVA: 0x7FFE87C84CD0
        public void SetTransform(){} // RVA: 0x7FFE87C84D30
    }

}