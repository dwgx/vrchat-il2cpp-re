// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Pool
// Classes: 12
// Methods: 58

namespace VRC.Core.Pool
{
    public class ArrayPool : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Contains(){} // RVA: 0x7FFD4E079DE0
        public void Release(){} // RVA: 0x7FFD4E090A10 | overloaded x2
        public void Exchange(){} // RVA: 0x7FFD4E096370
    }

    public class DictionaryPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFD4E078A90
        public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFD4E090A10
    }

    public class GenericPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFD4E078A90
        public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFD4E2ADC40
    }

    public class HashSetPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFD4E078A90
        public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFD4E090A10
    }

    public class IObjectPool`1
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IPool
    {
        public object CountInactive;
        public object ObjectType;

        // ── Methods ──
        public void get_CountInactive(){} // RVA: 0x7FFD4E079960
        public void get_ObjectType(){} // RVA: 0x7FFD4E078E90
        public void Cleanup(){} // RVA: 0x7FFD4E079960
    }

    public class ListPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFD4E078A90
        public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFD4E090A10
    }

    public class ObjectPool`1 : Object
    {
        public object ObjectType;
        public URA.leEastFrench<T1717581344> CountActive;
        public int CountInactive;
        public ormation<T1717581344> CountAll;
        public ileFullDirectoryInformation<T1717581344> OnGetFunc;
        public ileFullDirectoryInformation<T1717581344> OnReleaseFunc;
        public ileFullDirectoryInformation<T1717581344> OnDestroyFunc;
        public bool CollectionChecks;
        public int MaxSize;
        public int <CountActive>k__BackingField;

        // ── Methods ──
        public void get_ObjectType(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_CountActive(){} // RVA: 0x7FFD4E079960
        public void set_CountActive(){} // RVA: 0x7FFD4E090ED0
        public void get_CountInactive(){} // RVA: 0x7FFD4E079960
        public void get_CountAll(){} // RVA: 0x7FFD4E079960
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFD4E2ADC40
        public void Cleanup(){} // RVA: 0x7FFD4E079960
    }

    public class PoolManager : MonoBehaviour
    {
        // ── Methods ──
        public void TryInitialize(){} // RVA: 0x7FFD57356620
        public void PoolCleanupTask(){} // RVA: 0x7FFD57356B40
        public void PrintPoolStatistics(){} // RVA: 0x7FFD57356BE0
        public void AddPool(){} // RVA: 0x7FFD57357300
        public void GetAllPools(){} // RVA: 0x7FFD573576D0
        public void .ctor(){} // RVA: 0x7FFD57357BB0
        public void .cctor(){} // RVA: 0x7FFD57357C80
    }

    public class PooledArray`1 : ValueType
    {
        public ?[] Array; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
    }

    public class PooledObject`1 : ValueType
    {
        public onfigSettings.dListContainingContentId<URA.woDigitYearMax<eObjectDelegate.eNonPublicAccessors>> Pool; // 0x10
        public URA.woDigitYearMax<eObjectDelegate.eNonPublicAccessors> Object; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class StringBuilderPool : Object
    {
        // ── Methods ──
        public void GetObjectPool(){} // RVA: 0x7FFD573584B0
        public void Get(){} // RVA: 0x7FFD57358590 | overloaded x2
        public void Release(){} // RVA: 0x7FFD57358630
        public void .cctor(){} // RVA: 0x7FFD573586C0
    }

}