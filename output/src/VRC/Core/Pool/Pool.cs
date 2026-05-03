// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Pool
// Classes: 12
// Methods: 58

namespace VRC.Core.Pool
{
    public class ArrayPool : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Contains(){} // RVA: 0x7FFE80E2F230
        public void Release(){} // RVA: 0x7FFE80E46070 | overloaded x2
        public void Exchange(){} // RVA: 0x7FFE80E4BA70
    }

    public class DictionaryPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFE80E2DEE0
        public void Get(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Release(){} // RVA: 0x7FFE80E46070
    }

    public class GenericPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFE80E2DEE0
        public void Get(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Release(){} // RVA: 0x7FFE810A1420
    }

    public class HashSetPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFE80E2DEE0
        public void Get(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Release(){} // RVA: 0x7FFE80E46070
    }

    public class IObjectPool`1
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Get(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Release(){} // RVA: 0x7FFE80E460A0
    }

    public class IPool
    {
        // ── Methods ──
        public void get_CountInactive(){} // RVA: 0x7FFE80E2EDB0
        public void get_ObjectType(){} // RVA: 0x7FFE80E2E2E0
        public void Cleanup(){} // RVA: 0x7FFE80E2EDB0
    }

    public class ListPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFE80E2DEE0
        public void Get(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Release(){} // RVA: 0x7FFE80E46070
    }

    public class ObjectPool`1 : Object
    {
        public object syncLock; // 0x10
        public System.Collections.Generic.Stack`1<System.Collections.Generic.List`1<UnityEngine.ParticleSystemRenderer>> Pool; // 0x18
        public int LowWaterMark; // 0x20
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.ParticleSystemRenderer>> CreateFunc; // 0x28

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x7FFE84A038D0
        public void .ctor(){} // RVA: 0x7FFE84A03980
        public void get_CountActive(){} // RVA: 0x7FFE8139DAD0
        public void set_CountActive(){} // RVA: 0x7FFE81463B00
        public void get_CountInactive(){} // RVA: 0x7FFE84023030
        public void get_CountAll(){} // RVA: 0x7FFE84A03CB0
        public void Clear(){} // RVA: 0x7FFE84A03CD0
        public void Dispose(){} // RVA: 0x7FFE84A03EC0
        public void Get(){} // RVA: 0x7FFE84A04150 | overloaded x2
        public void Release(){} // RVA: 0x7FFE84A04210
        public void Cleanup(){} // RVA: 0x7FFE84A04530
    }

    public class PoolManager : MonoBehaviour
    {
        // ── Methods ──
        public void TryInitialize(){} // RVA: 0x7FFE8A397190
        public void PoolCleanupTask(){} // RVA: 0x7FFE8A3976B0
        public void PrintPoolStatistics(){} // RVA: 0x7FFE8A397750
        public void AddPool(){} // RVA: 0x7FFE8A397E70
        public void GetAllPools(){} // RVA: 0x7FFE8A398240
        public void .ctor(){} // RVA: 0x7FFE8A398720
        public void .cctor(){} // RVA: 0x7FFE8A3987F0
    }

    public class PooledArray`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void op_Implicit(){} // RVA: 0x7FFE810A1420
    }

    public class PooledObject`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class StringBuilderPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFE8A399020
        public void Get(){} // RVA: 0x7FFE8A399100 | overloaded x2
        public void Release(){} // RVA: 0x7FFE8A3991A0
        public void .cctor(){} // RVA: 0x7FFE8A399230
    }

}