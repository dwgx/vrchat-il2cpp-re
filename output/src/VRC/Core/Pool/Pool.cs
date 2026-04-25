// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Pool
// Classes: 12
// Methods: 58

namespace VRC.Core.Pool
{
    public class ArrayPool : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Contains(){} // RVA: 0x7FFAC2C59DE0
        public void Release(){} // RVA: 0x7FFAC2C70A10 | overloaded x2
        public void Exchange(){} // RVA: 0x7FFAC2C76370
    }

    public class DictionaryPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFAC2C58A90
        public void Get(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFAC2C70A10
    }

    public class GenericPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFAC2C58A90
        public void Get(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFAC2E8DC40
    }

    public class HashSetPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFAC2C58A90
        public void Get(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFAC2C70A10
    }

    public class IObjectPool`1
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Get(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IPool
    {
        public object CountInactive;
        public object ObjectType;

        // ── Methods ──
        public void get_CountInactive(){} // RVA: 0x7FFAC2C59960
        public void get_ObjectType(){} // RVA: 0x7FFAC2C58E90
        public void Cleanup(){} // RVA: 0x7FFAC2C59960
    }

    public class ListPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFAC2C58A90
        public void Get(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFAC2C70A10
    }

    public class ObjectPool`1 : Object
    {
        public object ObjectType;
        public System.Collections.Generic.Stack`1<T> CountActive;
        public int CountInactive;
        public System.Func`1<T> CountAll;
        public System.Action`1<T> OnGetFunc;
        public System.Action`1<T> OnReleaseFunc;
        public System.Action`1<T> OnDestroyFunc;
        public bool CollectionChecks;
        public int MaxSize;
        public int <CountActive>k__BackingField;

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void get_CountActive(){} // RVA: 0x7FFAC2C59960
        public void set_CountActive(){} // RVA: 0x7FFAC2C70ED0
        public void get_CountInactive(){} // RVA: 0x7FFAC2C59960
        public void get_CountAll(){} // RVA: 0x7FFAC2C59960
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void Get(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFAC2E8DC40
        public void Cleanup(){} // RVA: 0x7FFAC2C59960
    }

    public class PoolManager : MonoBehaviour
    {
        public object syncLock;
        public System.Collections.Generic.List`1<System.WeakReference`1<VRC.Core.Pool.IPool>> Pools; // 0x8
        public UnityEngine.WaitForSeconds PoolCleanupTaskInterval; // 0x20
        public Unity.Profiling.ProfilerMarker _cleanupProfilerMarker; // 0x10
        public VRC.Core.Pool.PoolManager Instance; // 0x18

        // ── Methods ──
        public void TryInitialize(){} // RVA: 0x7FFACBF36620
        public void PoolCleanupTask(){} // RVA: 0x7FFACBF36B40
        public void PrintPoolStatistics(){} // RVA: 0x7FFACBF36BE0
        public void AddPool(){} // RVA: 0x7FFACBF37300
        public void GetAllPools(){} // RVA: 0x7FFACBF376D0
        public void .ctor(){} // RVA: 0x7FFACBF37BB0
        public void .cctor(){} // RVA: 0x7FFACBF37C80
    }

    public class PooledArray`1 : ValueType
    {
        public T[] Array;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
    }

    public class PooledObject`1 : ValueType
    {
        public VRC.Core.Pool.IObjectPool`1<T> Pool;
        public T Object;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class StringBuilderPool : Object
    {
        public VRC.Core.Pool.ObjectPool`1<System.Text.StringBuilder> Pool;

        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFACBF384B0
        public void Get(){} // RVA: 0x7FFACBF38590 | overloaded x2
        public void Release(){} // RVA: 0x7FFACBF38630
        public void .cctor(){} // RVA: 0x7FFACBF386C0
    }

}