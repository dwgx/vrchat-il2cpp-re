// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 3
// Methods: 6

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class JoinAwaitWithCancellation`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> outer;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V> inner;
        public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<W>> outerKeySelector;
        public System.Func`3<V,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<W>> innerKeySelector;
        public System.Func`4<U,V,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<W> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09BCE0
        public void GetAsyncEnumerator(){}
    }

    public class JoinAwait`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> outer;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V> inner;
        public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<W>> outerKeySelector;
        public System.Func`2<V,Cysharp.Threading.Tasks.UniTask`1<W>> innerKeySelector;
        public System.Func`3<U,V,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<W> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09BCE0
        public void GetAsyncEnumerator(){}
    }

    public class Join`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> outer;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V> inner;
        public System.Func`2<U,W> outerKeySelector;
        public System.Func`2<V,W> innerKeySelector;
        public System.Func`3<U,V,T> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<W> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09BCE0
        public void GetAsyncEnumerator(){}
    }

}