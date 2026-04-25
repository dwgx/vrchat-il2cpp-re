// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 5
// Methods: 14

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class OfType`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<object> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetAsyncEnumerator(){}
    }

    public class OrderedAsyncEnumerableAwaitWithCancellation`2 : OrderedAsyncEnumerable`1
    {
        public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
        public System.Collections.Generic.IComparer`1<T> comparer;
        public bool descending;
        public Cysharp.Threading.Tasks.Linq.OrderedAsyncEnumerable`1<U> parent;

        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerableSorter(){}
    }

    public class OrderedAsyncEnumerableAwait`2 : OrderedAsyncEnumerable`1
    {
        public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
        public System.Collections.Generic.IComparer`1<T> comparer;
        public bool descending;
        public Cysharp.Threading.Tasks.Linq.OrderedAsyncEnumerable`1<U> parent;

        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerableSorter(){}
    }

    public class OrderedAsyncEnumerable`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void CreateOrderedEnumerable(){} // overloaded x3
        public void GetAsyncEnumerableSorter(){}
        public void GetAsyncEnumerator(){}
    }

    public class OrderedAsyncEnumerable`2 : OrderedAsyncEnumerable`1
    {
        public System.Func`2<U,T> keySelector;
        public System.Collections.Generic.IComparer`1<T> comparer;
        public bool descending;
        public Cysharp.Threading.Tasks.Linq.OrderedAsyncEnumerable`1<U> parent;

        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerableSorter(){}
    }

}