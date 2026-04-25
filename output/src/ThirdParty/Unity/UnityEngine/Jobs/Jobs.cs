// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Jobs
// Classes: 4
// Methods: 49

namespace ThirdParty.Unity.UnityEngine.Jobs
{
    public class IJobParallelForTransform
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IJobParallelForTransformExtensions : Object
    {
        // ── Methods ──
        public void EarlyJobInit(){} // RVA: 0x7FFAC2C709B0
        public void GetReflectionData(){} // RVA: 0x7FFAC2C58A90
        public void Schedule(){} // RVA: 0x7FFAC2E8DC40
        public void ScheduleReadOnly(){} // RVA: 0x7FFAC2E8DC40
        public void ScheduleReadOnlyByRef(){} // RVA: 0x7FFAC2E8DC40
    }

    public class TransformAccess : ValueType
    {
        public UIntPtr position; // 0x10
        public int rotation; // 0x18

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFAC98DB5D0
        public void get_rotation(){} // RVA: 0x7FFAC98DB660
        public void get_localPosition(){} // RVA: 0x7FFAC98DB6E0
        public void set_localPosition(){} // RVA: 0x7FFAC98DB770
        public void get_localRotation(){} // RVA: 0x7FFAC98DB7D0
        public void set_localRotation(){} // RVA: 0x7FFAC98DB850
        public void get_localScale(){} // RVA: 0x7FFAC98DB8B0
        public void set_localScale(){} // RVA: 0x7FFAC98DB940
        public void get_localToWorldMatrix(){} // RVA: 0x7FFAC98DB9A0
        public void get_isValid(){} // RVA: 0x7FFAC5DC6CA0
        public void SetLocalPositionAndRotation(){} // RVA: 0x7FFAC98DBA50
        public void SetLocalPositionAndRotation_Internal(){} // RVA: 0x7FFAC98DBAC0
        public void GetPosition(){} // RVA: 0x7FFAC98DBB30
        public void GetRotation(){} // RVA: 0x7FFAC98DBB90
        public void GetLocalPosition(){} // RVA: 0x7FFAC98DBBF0
        public void SetLocalPosition(){} // RVA: 0x7FFAC98DBC50
        public void GetLocalRotation(){} // RVA: 0x7FFAC98DBCB0
        public void SetLocalRotation(){} // RVA: 0x7FFAC98DBD10
        public void GetLocalScale(){} // RVA: 0x7FFAC98DBD70
        public void SetLocalScale(){} // RVA: 0x7FFAC98DBDD0
        public void GetLocalToWorldMatrix(){} // RVA: 0x7FFAC98DBE30
    }

    public class TransformAccessArray : ValueType
    {
        public UIntPtr isCreated; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98DBF10 | overloaded x2
        public void Allocate(){} // RVA: 0x7FFAC98DBF30
        public void get_isCreated(){} // RVA: 0x7FFAC9834DB0
        public void Dispose(){} // RVA: 0x7FFAC98DBFF0
        public void GetTransformAccessArrayForSchedule(){} // RVA: 0x7FFAC51D9A30
        public void get_Item(){} // RVA: 0x7FFAC98DC0A0
        public void set_Item(){} // RVA: 0x7FFAC98DC100
        public void get_length(){} // RVA: 0x7FFAC98DC170
        public void Add(){} // RVA: 0x7FFAC98DC3F0 | overloaded x2
        public void RemoveAtSwapBack(){} // RVA: 0x7FFAC98DC450 | overloaded x2
        public void SetTransforms(){} // RVA: 0x7FFAC98DC390 | overloaded x2
        public void Create(){} // RVA: 0x7FFAC98DC2E0
        public void DestroyTransformAccessArray(){} // RVA: 0x7FFAC98DC340
        public void GetSortedTransformAccess(){} // RVA: 0x7FFAC98DC4B0
        public void GetSortedToUserIndex(){} // RVA: 0x7FFAC98DC500
        public void GetLength(){} // RVA: 0x7FFAC98DC550
        public void GetTransform(){} // RVA: 0x7FFAC98DC5A0
        public void SetTransform(){} // RVA: 0x7FFAC98DC600
    }

}