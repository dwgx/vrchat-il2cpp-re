// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 6
// Methods: 12

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class ElementAt : Object
    {
        // ── Methods ──
        public void ElementAtAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Empty`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetAsyncEnumerator(){}
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class EveryUpdate : Object
    {
        public 0x6B1DD918 updateTiming; // 0x10
        public bool cancelImmediately; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86ACE60
        public void GetAsyncEnumerator(){} // RVA: 0x7FFAC94C32B0
    }

    public class EveryValueChangedStandardObject`2 : Object
    {
        public System.WeakReference`1<U> target;
        public System.Func`2<U,T> propertySelector;
        public System.Collections.Generic.IEqualityComparer`1<T> equalityComparer;
        public 0x6B1DD918 monitorTiming;
        public bool cancelImmediately;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetAsyncEnumerator(){}
    }

    public class EveryValueChangedUnityObject`2 : Object
    {
        public U target;
        public System.Func`2<U,U> propertySelector;
        public System.Collections.Generic.IEqualityComparer`1<U> equalityComparer;
        public 0x6B1DD918 monitorTiming;
        public bool cancelImmediately;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetAsyncEnumerator(){}
    }

    public class Except`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> first;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> second;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void GetAsyncEnumerator(){}
    }

}