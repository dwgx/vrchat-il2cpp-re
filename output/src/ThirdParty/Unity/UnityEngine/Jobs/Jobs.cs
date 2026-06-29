// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Jobs
// Classes: 4
// Methods: 48

namespace ThirdParty.Unity.UnityEngine.Jobs
{
    public class IJobParallelForTransform
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0xA94080
    }

    public class IJobParallelForTransformExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x30E9F60
        public void GetReflectionData(){} // RVA: 0x30EA350
        public void Schedule(){} // RVA: 0x30EAA90
        public void ScheduleReadOnly(){} // RVA: 0x30EAD40
        public void ScheduleReadOnlyByRef(){} // RVA: 0x30EB000
    }

    public class TransformAccess : ValueType
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x9667E0
        public void get_rotation(){} // RVA: 0x966860
        public void get_localPosition(){} // RVA: 0x9668E0
        public void set_localPosition(){} // RVA: 0x966960
        public void get_localRotation(){} // RVA: 0x9669D0
        public void set_localRotation(){} // RVA: 0x966A50
        public void get_localScale(){} // RVA: 0x966AB0
        public void set_localScale(){} // RVA: 0x966B30
        public void get_localToWorldMatrix(){} // RVA: 0x966BA0
        public void get_isValid(){} // RVA: 0x311760
        public void SetLocalPositionAndRotation(){} // RVA: 0x966BE0
        public void SetLocalPositionAndRotation_Internal(){} // RVA: 0x7C21F50
        public void GetPosition(){} // RVA: 0x7C21FC0
        public void GetRotation(){} // RVA: 0x7C22020
        public void GetLocalPosition(){} // RVA: 0x7C22080
        public void SetLocalPosition(){} // RVA: 0x7C220E0
        public void GetLocalRotation(){} // RVA: 0x7C22140
        public void SetLocalRotation(){} // RVA: 0x7C221A0
        public void GetLocalScale(){} // RVA: 0x7C22200
        public void SetLocalScale(){} // RVA: 0x7C22260
        public void GetLocalToWorldMatrix(){} // RVA: 0x7C222C0
    }

    public class TransformAccessArray : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x966CE0
        public void Allocate(){} // RVA: 0x7C223C0
        public void get_isCreated(){} // RVA: 0x95AA70
        public void Dispose(){} // RVA: 0x966D00
        public void GetTransformAccessArrayForSchedule(){} // RVA: 0x44D9F0
        public void get_Item(){} // RVA: 0x966D10
        public void set_Item(){} // RVA: 0x966D20
        public void get_length(){} // RVA: 0x966D30
        public void Add(){} // RVA: 0x7C22930
        public void RemoveAtSwapBack(){} // RVA: 0x7C229D0
        public void SetTransforms(){} // RVA: 0x7C228D0
        public void Create(){} // RVA: 0x7C22820
        public void DestroyTransformAccessArray(){} // RVA: 0x7C22880
        public void GetSortedTransformAccess(){} // RVA: 0x7C22A30
        public void GetSortedToUserIndex(){} // RVA: 0x7C22A80
        public void GetLength(){} // RVA: 0x7C22AD0
        public void GetTransform(){} // RVA: 0x7C22B20
        public void SetTransform(){} // RVA: 0x7C22BB0
        public void Add_Injected(){} // RVA: 0x7C22C60
        public void GetTransform_Injected(){} // RVA: 0x7C22CC0
        public void SetTransform_Injected(){} // RVA: 0x7C22D20
    }

}