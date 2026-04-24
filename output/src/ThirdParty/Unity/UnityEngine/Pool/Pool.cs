// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Pool
// Classes: 5
// Methods: 19

namespace ThirdParty.Unity.UnityEngine.Pool
{
    public class CollectionPool`2 : Object
    {
        public UnityEngine.Pool.ObjectPool`1<System.Collections.Generic.List`1<UnityEngine.UI.IMaterialModifier>> s_Pool;

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class GenericPool`1 : Object
    {
        public UnityEngine.Pool.ObjectPool`1<T> s_Pool;

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD4E2ADC40
        public void Release(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class IObjectPool`1
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ObjectPool`1 : Object
    {
        public System.Collections.Generic.List`1<System.Collections.Generic.List`1<UnityEngine.UI.IMaterialModifier>> CountAll; // 0x10
        public System.Func`1<System.Collections.Generic.List`1<UnityEngine.UI.IMaterialModifier>> CountInactive; // 0x18
        public System.Action`1<System.Collections.Generic.List`1<UnityEngine.UI.IMaterialModifier>> m_ActionOnGet; // 0x20
        public System.Action`1<System.Collections.Generic.List`1<UnityEngine.UI.IMaterialModifier>> m_ActionOnRelease; // 0x28
        public System.Action`1<System.Collections.Generic.List`1<UnityEngine.UI.IMaterialModifier>> m_ActionOnDestroy; // 0x30
        public int m_MaxSize; // 0x38
        public bool m_CollectionCheck; // 0x3C
        public int <CountAll>k__BackingField; // 0x40

        // ── Methods ──
        public void get_CountAll(){} // RVA: 0x7FFD4E079960
        public void set_CountAll(){} // RVA: 0x7FFD4E090ED0
        public void get_CountInactive(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class PooledObject`1 : ValueType
    {
        public System.Collections.Generic.List`1<UnityEngine.UI.IMaterialModifier> m_ToReturn; // 0x10
        public UnityEngine.Pool.IObjectPool`1<System.Collections.Generic.List`1<UnityEngine.UI.IMaterialModifier>> m_Pool; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    }

}