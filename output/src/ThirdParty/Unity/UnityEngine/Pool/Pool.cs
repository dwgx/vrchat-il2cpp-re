// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Pool
// Classes: 5
// Methods: 19

namespace ThirdParty.Unity.UnityEngine.Pool
{
    public class CollectionPool`2 : Object
    {
        public cy.gContentId<T1717606848> s_Pool;

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class GenericPool`1 : Object
    {
        public cy.gContentId<T1717606896> s_Pool;

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
        public URA.woDigitYearMax<T1717606928> CountAll;
        public ormation<T1717606928> CountInactive;
        public ileFullDirectoryInformation<T1717606928> m_ActionOnGet;
        public ileFullDirectoryInformation<T1717606928> m_ActionOnRelease;
        public ileFullDirectoryInformation<T1717606928> m_ActionOnDestroy;
        public int m_MaxSize;
        public bool m_CollectionCheck;
        public int <CountAll>k__BackingField;

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
        public URA.woDigitYearMax<eObjectDelegate.eNonPublicAccessors> m_ToReturn; // 0x10
        public cy.dListContainingContentId<URA.woDigitYearMax<eObjectDelegate.eNonPublicAccessors>> m_Pool; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    }

}