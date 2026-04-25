// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Pool
// Classes: 5
// Methods: 19

namespace ThirdParty.Unity.UnityEngine.Pool
{
    public class CollectionPool`2 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class GenericPool`1 : Object
    {
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
        public object CountAll;
        public object CountInactive;

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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    }

}