// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Pool
// Classes: 5
// Methods: 18

namespace ThirdParty.Unity.UnityEngine.Pool
{
    public class CollectionPool`2 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE86226B50 | overloaded x2
        public void Release(){} // RVA: 0x7FFE86226CB0
        public void .cctor(){} // RVA: 0x7FFE86226D90
    }

    public class GenericPool`1 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE810A1420
        public void Release(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class IObjectPool`1
    {
    }

    public class ObjectPool`1 : Object
    {
        public System.Collections.Generic.List`1<System.Collections.Generic.List`1<HIDElementDescriptor>> m_List; // 0x10
        public System.Func`1<System.Collections.Generic.List`1<HIDElementDescriptor>> m_CreateFunc; // 0x18

        // ── Methods ──
        public void get_CountAll(){} // RVA: 0x7FFE8119C080
        public void set_CountAll(){} // RVA: 0x7FFE8119C090
        public void get_CountInactive(){} // RVA: 0x7FFE81CCB610
        public void .ctor(){} // RVA: 0x7FFE84A022A0
        public void Get(){} // RVA: 0x7FFE84A02650 | overloaded x2
        public void Release(){} // RVA: 0x7FFE84A026F0
        public void Clear(){} // RVA: 0x7FFE84A027F0
        public void Dispose(){} // RVA: 0x7FFE84A02970
    }

    public class PooledObject`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8272BDB0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE84A6B510
    }

}