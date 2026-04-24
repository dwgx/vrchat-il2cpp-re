// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Jobs
// Classes: 4
// Methods: 49

namespace ThirdParty.Unity.UnityEngine.Jobs
{
    public class IJobParallelForTransform
    {
        // ── Original Methods ──
        public void Execute(){} // RVA: 0x7ffaa887e5c0
    }

    public class IJobParallelForTransformExtensions : Object
    {
        // ── Original Methods ──
        public void EarlyJobInit(){} // RVA: 0x7ffaa8660cf0
        public void Schedule(){} // RVA: 0x7ffaa887e5c0
        public void ScheduleReadOnly(){} // RVA: 0x7ffaa887e5c0
        public void ScheduleReadOnlyByRef(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetReflectionData(){} // RVA: 0x7ffaa8648dd0
    }

    public class TransformAccess : ValueType
    {
        // ── Original Methods ──
        public void get_position(){} // RVA: 0x7ffaaf2fd530
        public void get_rotation(){} // RVA: 0x7ffaaf2fd5c0
        public void get_localPosition(){} // RVA: 0x7ffaaf2fd640
        public void set_localPosition(){} // RVA: 0x7ffaaf2fd6d0
        public void get_localRotation(){} // RVA: 0x7ffaaf2fd730
        public void set_localRotation(){} // RVA: 0x7ffaaf2fd7b0
        public void get_localScale(){} // RVA: 0x7ffaaf2fd810
        public void set_localScale(){} // RVA: 0x7ffaaf2fd8a0
        public void get_localToWorldMatrix(){} // RVA: 0x7ffaaf2fd900
        public void get_isValid(){} // RVA: 0x7ffaab7cf5a0
        // ── Binary Analysis Named ──
        public void SetLocalPositionAndRotation(){} // RVA: 0x7ffaaf2fd9b0
        public void SetLocalPositionAndRotation_Internal(){} // RVA: 0x7ffaaf2fda20
        public void GetPosition(){} // RVA: 0x7ffaaf2fda90
        public void GetRotation(){} // RVA: 0x7ffaaf2fdaf0
        public void GetLocalPosition(){} // RVA: 0x7ffaaf2fdb50
        public void SetLocalPosition(){} // RVA: 0x7ffaaf2fdbb0
        public void GetLocalRotation(){} // RVA: 0x7ffaaf2fdc10
        public void SetLocalRotation(){} // RVA: 0x7ffaaf2fdc70
        public void GetLocalScale(){} // RVA: 0x7ffaaf2fdcd0
        public void SetLocalScale(){} // RVA: 0x7ffaaf2fdd30
        public void GetLocalToWorldMatrix(){} // RVA: 0x7ffaaf2fdd90
    }

    public class TransformAccessArray : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf2fde70
        public void .ctor(){} // RVA: 0x7ffaaf2fde70
        public void Allocate(){} // RVA: 0x7ffaaf2fde90
        public void get_isCreated(){} // RVA: 0x7ffaaf256d10
        public void Dispose(){} // RVA: 0x7ffaaf2fdf50
        public void get_Item(){} // RVA: 0x7ffaaf2fe000
        public void set_Item(){} // RVA: 0x7ffaaf2fe060
        public void get_length(){} // RVA: 0x7ffaaf2fe0d0
        public void Add(){} // RVA: 0x7ffaaf2fe350
        public void RemoveAtSwapBack(){} // RVA: 0x7ffaaf2fe3b0
        public void Create(){} // RVA: 0x7ffaaf2fe240
        public void DestroyTransformAccessArray(){} // RVA: 0x7ffaaf2fe2a0
        public void Add(){} // RVA: 0x7ffaaf2fe350
        public void RemoveAtSwapBack(){} // RVA: 0x7ffaaf2fe3b0
        // ── Binary Analysis Named ──
        public void GetTransformAccessArrayForSchedule(){} // RVA: 0x7ffaaabdb990
        public void SetTransforms(){} // RVA: 0x7ffaaf2fe2f0
        public void SetTransforms(){} // RVA: 0x7ffaaf2fe2f0
        public void GetSortedTransformAccess(){} // RVA: 0x7ffaaf2fe410
        public void GetSortedToUserIndex(){} // RVA: 0x7ffaaf2fe460
        public void GetLength(){} // RVA: 0x7ffaaf2fe4b0
        public void GetTransform(){} // RVA: 0x7ffaaf2fe500
        public void SetTransform(){} // RVA: 0x7ffaaf2fe560
    }

}