// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.Internal
// Classes: 2
// Methods: 6

namespace ThirdParty.DotNet.System.Reflection.Internal
{
    public class EmptyArray`1 : Object
    {
        public T[] Instance;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ObjectPool`1 : Object
    {
        public 0x665F77E8<T>[] _items;
        public System.Func`1<T> _factory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970 | overloaded x2
        public void CreateInstance(){} // RVA: 0x7FFD4E2ADC40
        public void Allocate(){} // RVA: 0x7FFD4E2ADC40
        public void Free(){} // RVA: 0x7FFD4E2ADC40
    }

}