// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Pool
// Classes: 12
// Methods: 58

namespace VRC.Core.Pool
{
    public class ArrayPool
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x283FA0 | overloaded x2
        public void Contains(){} // RVA: 0xDCC0
        public void Release(){} // RVA: 0x24AE0 | overloaded x2
        public void Exchange(){} // RVA: 0x2A490
    }

    public class DictionaryPool
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0xC960
        public void Get(){} // RVA: 0x283FA0 | overloaded x2
        public void Release(){} // RVA: 0x24AE0
    }

    public class GenericPool
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0xC960
        public void Get(){} // RVA: 0x283FA0 | overloaded x2
        public void Release(){} // RVA: 0x283FA0
    }

    public class HashSetPool
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0xC960
        public void Get(){} // RVA: 0x283FA0 | overloaded x2
        public void Release(){} // RVA: 0x24AE0
    }

    public class IObjectPool`1 : Clear
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x24A50
        public void Get(){} // RVA: 0x283FA0 | overloaded x2
        public void Release(){} // RVA: 0x283FA0
    }

    public class IPool
    {
        // ── Methods ──
        public void get_CountInactive(){} // RVA: 0xD840
        public void get_ObjectType(){} // RVA: 0xCD60
        public void Cleanup(){} // RVA: 0xD840
    }

    public class ListPool
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0xC960
        public void Get(){} // RVA: 0x283FA0 | overloaded x2
        public void Release(){} // RVA: 0x24AE0
    }

    public class ObjectPool`1
    {
        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x283FA0
        public void get_CountActive(){} // RVA: 0xD840
        public void set_CountActive(){} // RVA: 0x24FA0
        public void get_CountInactive(){} // RVA: 0xD840
        public void get_CountAll(){} // RVA: 0xD840
        public void Clear(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x24A50
        public void Get(){} // RVA: 0x283FA0 | overloaded x2
        public void Release(){} // RVA: 0x283FA0
        public void Cleanup(){} // RVA: 0xD840
    }

    public class PoolManager
    {
        // ── Methods ──
        public void TryInitialize(){} // RVA: 0x993AFD0
        public void PoolCleanupTask(){} // RVA: 0x993B4F0
        public void PrintPoolStatistics(){} // RVA: 0x993B590
        public void AddPool(){} // RVA: 0x993BCB0
        public void GetAllPools(){} // RVA: 0x993C080
        public void .ctor(){} // RVA: 0x993C560
        public void .cctor(){} // RVA: 0x993C630
    }

    public class PooledArray`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void Dispose(){} // RVA: 0x24A50
        public void op_Implicit(){} // RVA: 0x283FA0
    }

    public class PooledObject`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void Dispose(){} // RVA: 0x24A50
    }

    public class StringBuilderPool
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x993CE60
        public void Get(){} // RVA: 0x993CF40 | overloaded x2
        public void Release(){} // RVA: 0x993CFE0
        public void .cctor(){} // RVA: 0x993D070
    }

}