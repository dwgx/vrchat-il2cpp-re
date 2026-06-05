// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Jobs
// Classes: 4
// Methods: 49

namespace ThirdParty.Unity.UnityEngine.Jobs
{
    public class IJobParallelForTransform
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAF2D33FA0
    }

    public class IJobParallelForTransformExtensions
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7FFAF2AD4A80
        public void GetReflectionData(){} // RVA: 0x7FFAF2ABC960
        public void Schedule(){} // RVA: 0x7FFAF2D33FA0
        public void ScheduleReadOnly(){} // RVA: 0x7FFAF2D33FA0
        public void ScheduleReadOnlyByRef(){} // RVA: 0x7FFAF2D33FA0
    }

    public class TransformAccess
    {
        public object Header;
        public object IntermediateScriptingStructName;
        public object CodegenOptions;

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFAF9BF3090
        public void get_rotation(){} // RVA: 0x7FFAF9BF3120
        public void get_localPosition(){} // RVA: 0x7FFAF9BF31A0
        public void set_localPosition(){} // RVA: 0x7FFAF9BF3230
        public void get_localRotation(){} // RVA: 0x7FFAF9BF3290
        public void set_localRotation(){} // RVA: 0x7FFAF9BF3310
        public void get_localScale(){} // RVA: 0x7FFAF9BF3370
        public void set_localScale(){} // RVA: 0x7FFAF9BF3400
        public void get_localToWorldMatrix(){} // RVA: 0x7FFAF9BF3460
        public void get_isValid(){} // RVA: 0x7FFAF5F71790
        public void SetLocalPositionAndRotation(){} // RVA: 0x7FFAF9BF3510
        public void SetLocalPositionAndRotation_Internal(){} // RVA: 0x7FFAF9BF3580
        public void GetPosition(){} // RVA: 0x7FFAF9BF35F0
        public void GetRotation(){} // RVA: 0x7FFAF9BF3650
        public void GetLocalPosition(){} // RVA: 0x7FFAF9BF36B0
        public void SetLocalPosition(){} // RVA: 0x7FFAF9BF3710
        public void GetLocalRotation(){} // RVA: 0x7FFAF9BF3770
        public void SetLocalRotation(){} // RVA: 0x7FFAF9BF37D0
        public void GetLocalScale(){} // RVA: 0x7FFAF9BF3830
        public void SetLocalScale(){} // RVA: 0x7FFAF9BF3890
        public void GetLocalToWorldMatrix(){} // RVA: 0x7FFAF9BF38F0
    }

    public class TransformAccessArray
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9BF39D0 | overloaded x2
        public void Allocate(){} // RVA: 0x7FFAF9BF39F0
        public void get_isCreated(){} // RVA: 0x7FFAF9B4C440
        public void Dispose(){} // RVA: 0x7FFAF9BF3AB0
        public void GetTransformAccessArrayForSchedule(){} // RVA: 0x7FFAF51E8C50
        public void get_Item(){} // RVA: 0x7FFAF9BF3B60
        public void set_Item(){} // RVA: 0x7FFAF9BF3BC0
        public void get_length(){} // RVA: 0x7FFAF9BF3C30
        public void Add(){} // RVA: 0x7FFAF9BF3EB0 | overloaded x2
        public void RemoveAtSwapBack(){} // RVA: 0x7FFAF9BF3F10 | overloaded x2
        public void SetTransforms(){} // RVA: 0x7FFAF9BF3E50 | overloaded x2
        public void Create(){} // RVA: 0x7FFAF9BF3DA0
        public void DestroyTransformAccessArray(){} // RVA: 0x7FFAF9BF3E00
        public void GetSortedTransformAccess(){} // RVA: 0x7FFAF9BF3F70
        public void GetSortedToUserIndex(){} // RVA: 0x7FFAF9BF3FC0
        public void GetLength(){} // RVA: 0x7FFAF9BF4010
        public void GetTransform(){} // RVA: 0x7FFAF9BF4060
        public void SetTransform(){} // RVA: 0x7FFAF9BF40C0
    }

}