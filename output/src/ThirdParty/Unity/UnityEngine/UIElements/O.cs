// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 2
// Methods: 9

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class ObjectListPool`1 : Object
    {
        public UnityEngine.UIElements.ObjectPool`1<System.Collections.Generic.List`1<T>> pool;

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC2C58A90
        public void Release(){} // RVA: 0x7FFAC2C70A10
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ObjectPool`1 : Object
    {
        public System.Collections.Generic.Stack`1<T> maxSize;
        public int m_MaxSize;
        public System.Func`1<T> CreateFunc;

        // ── Methods ──
        public void get_maxSize(){} // RVA: 0x7FFAC2C59960
        public void set_maxSize(){} // RVA: 0x7FFAC2C70ED0
        public void .ctor(){} // RVA: 0x7FFAC2C77970
        public void Size(){} // RVA: 0x7FFAC2C59960
        public void Get(){} // RVA: 0x7FFAC2E8DC40
        public void Release(){} // RVA: 0x7FFAC2E8DC40
    }

}