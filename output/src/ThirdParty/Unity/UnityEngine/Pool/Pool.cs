// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Pool
// Classes: 5
// Methods: 19

namespace ThirdParty.Unity.UnityEngine.Pool
{
    public class CollectionPool`2 : Object
    {
        public UnityEngine.Pool.ObjectPool`1<U> s_Pool;

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class GenericPool`1 : Object
    {
        public UnityEngine.Pool.ObjectPool`1<T> s_Pool;

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC2E8DC40
        public void Release(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class IObjectPool`1
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ObjectPool`1 : Object
    {
        public System.Collections.Generic.List`1<T> CountAll;
        public System.Func`1<T> CountInactive;
        public System.Action`1<T> m_ActionOnGet;
        public System.Action`1<T> m_ActionOnRelease;
        public System.Action`1<T> m_ActionOnDestroy;
        public int m_MaxSize;
        public bool m_CollectionCheck;
        public int <CountAll>k__BackingField;

        // ── Methods ──
        public void get_CountAll(){} // RVA: 0x7FFAC2C59960
        public void set_CountAll(){} // RVA: 0x7FFAC2C70ED0
        public void get_CountInactive(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Get(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class PooledObject`1 : ValueType
    {
        public T m_ToReturn;
        public UnityEngine.Pool.IObjectPool`1<T> m_Pool;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2C70980
    }

}