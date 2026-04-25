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
        public void Get(){} // RVA: 0x7FFD4E078A90
        public void Release(){} // RVA: 0x7FFD4E090A10
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ObjectPool`1 : Object
    {
        public System.Collections.Generic.Stack`1<T> maxSize;
        public int m_MaxSize;
        public System.Func`1<T> CreateFunc;

        // ── Methods ──
        public void get_maxSize(){} // RVA: 0x7FFD4E079960
        public void set_maxSize(){} // RVA: 0x7FFD4E090ED0
        public void .ctor(){} // RVA: 0x7FFD4E097970
        public void Size(){} // RVA: 0x7FFD4E079960
        public void Get(){} // RVA: 0x7FFD4E2ADC40
        public void Release(){} // RVA: 0x7FFD4E2ADC40
    }

}