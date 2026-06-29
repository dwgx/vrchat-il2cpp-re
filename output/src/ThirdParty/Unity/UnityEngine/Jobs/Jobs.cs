// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Jobs
// Classes: 4
// Methods: 45

namespace ThirdParty.Unity.UnityEngine.Jobs
{
    public class IJobParallelForTransform
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7A8051B10
    }

    public class IJobParallelForTransformExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7AA4BCEC0
        public void GetReflectionData(){} // RVA: 0x7AA4BCFB0
        public void Schedule(){} // RVA: 0x7AA4BD430
        public void ScheduleReadOnly(){} // RVA: 0x7AA4BDCA0
        public void ScheduleReadOnlyByRef(){} // RVA: 0x7AA4BDF60
    }

    public class TransformAccess : ValueType
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x7A7EDFCA0
        public void get_rotation(){} // RVA: 0x7A7EDFD20
        public void get_localPosition(){} // RVA: 0x7A7EDFDA0
        public void set_localPosition(){} // RVA: 0x7A7EDFE20
        public void get_localRotation(){} // RVA: 0x7A7EDFE90
        public void set_localRotation(){} // RVA: 0x7A7EDFF10
        public void get_localScale(){} // RVA: 0x7A7EDFF70
        public void set_localScale(){} // RVA: 0x7A7EDFFF0
        public void get_localToWorldMatrix(){} // RVA: 0x7A7EE0060
        public void get_isValid(){} // RVA: 0x7A78CF330
        public void SetLocalPositionAndRotation(){} // RVA: 0x7A7EE00A0
        public void SetLocalPositionAndRotation_Internal(){} // RVA: 0x7AEF22480
        public void GetPosition(){} // RVA: 0x7AEF224F0
        public void GetRotation(){} // RVA: 0x7AEF22550
        public void GetLocalPosition(){} // RVA: 0x7AEF225B0
        public void SetLocalPosition(){} // RVA: 0x7AEF22610
        public void GetLocalRotation(){} // RVA: 0x7AEF22670
        public void SetLocalRotation(){} // RVA: 0x7AEF226D0
        public void GetLocalScale(){} // RVA: 0x7AEF22730
        public void SetLocalScale(){} // RVA: 0x7AEF22790
        public void GetLocalToWorldMatrix(){} // RVA: 0x7AEF227F0
    }

    public class TransformAccessArray : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EE01A0
        public void Allocate(){} // RVA: 0x7AEF228F0
        public void get_isCreated(){} // RVA: 0x7A7ED5AA0
        public void Dispose(){} // RVA: 0x7A7EE01C0
        public void GetTransformAccessArrayForSchedule(){} // RVA: 0x7A79E3DA0
        public void get_Item(){} // RVA: 0x7A7EE01D0
        public void set_Item(){} // RVA: 0x7A7EE0230
        public void get_length(){} // RVA: 0x7A7EE0240
        public void Add(){} // RVA: 0x7AEF22DB0
        public void RemoveAtSwapBack(){} // RVA: 0x7AEF22E10
        public void SetTransforms(){} // RVA: 0x7AEF22D50
        public void Create(){} // RVA: 0x7AEF22CA0
        public void DestroyTransformAccessArray(){} // RVA: 0x7AEF22D00
        public void GetSortedTransformAccess(){} // RVA: 0x7AEF22E70
        public void GetSortedToUserIndex(){} // RVA: 0x7AEF22EC0
        public void GetLength(){} // RVA: 0x7AEF22F10
        public void GetTransform(){} // RVA: 0x7AEF22F60
        public void SetTransform(){} // RVA: 0x7AEF22FC0
    }

}