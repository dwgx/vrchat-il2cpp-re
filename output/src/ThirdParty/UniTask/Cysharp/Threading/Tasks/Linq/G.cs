// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 9
// Methods: 18

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class GroupByAwaitWithCancellation`3 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<V>> keySelector;
        public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> elementSelector;
        public System.Collections.Generic.IEqualityComparer`1<V> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09B8C0
        public void GetAsyncEnumerator(){}
    }

    public class GroupByAwaitWithCancellation`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<V>> keySelector;
        public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<W>> elementSelector;
        public System.Func`4<V,System.Collections.Generic.IEnumerable`1<W>,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<V> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09BB70
        public void GetAsyncEnumerator(){}
    }

    public class GroupByAwait`3 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<V>> keySelector;
        public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<T>> elementSelector;
        public System.Collections.Generic.IEqualityComparer`1<V> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09B8C0
        public void GetAsyncEnumerator(){}
    }

    public class GroupByAwait`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<V>> keySelector;
        public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<W>> elementSelector;
        public System.Func`3<V,System.Collections.Generic.IEnumerable`1<W>,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<V> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09BB70
        public void GetAsyncEnumerator(){}
    }

    public class GroupBy`3 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`2<U,V> keySelector;
        public System.Func`2<U,T> elementSelector;
        public System.Collections.Generic.IEqualityComparer`1<V> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09B8C0
        public void GetAsyncEnumerator(){}
    }

    public class GroupBy`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`2<U,V> keySelector;
        public System.Func`2<U,W> elementSelector;
        public System.Func`3<V,System.Collections.Generic.IEnumerable`1<W>,T> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<V> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09BB70
        public void GetAsyncEnumerator(){}
    }

    public class GroupJoinAwaitWithCancellation`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> outer;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V> inner;
        public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<W>> outerKeySelector;
        public System.Func`3<V,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<W>> innerKeySelector;
        public System.Func`4<U,System.Collections.Generic.IEnumerable`1<V>,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<W> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09BCE0
        public void GetAsyncEnumerator(){}
    }

    public class GroupJoinAwait`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> outer;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V> inner;
        public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<W>> outerKeySelector;
        public System.Func`2<V,Cysharp.Threading.Tasks.UniTask`1<W>> innerKeySelector;
        public System.Func`3<U,System.Collections.Generic.IEnumerable`1<V>,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<W> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09BCE0
        public void GetAsyncEnumerator(){}
    }

    public class GroupJoin`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> outer;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V> inner;
        public System.Func`2<U,W> outerKeySelector;
        public System.Func`2<V,W> innerKeySelector;
        public System.Func`3<U,System.Collections.Generic.IEnumerable`1<V>,T> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<W> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09BCE0
        public void GetAsyncEnumerator(){}
    }

}