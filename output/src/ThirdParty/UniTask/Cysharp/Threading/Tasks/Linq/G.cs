// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 9
// Methods: 18

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class GroupByAwaitWithCancellation`3 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
        public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> elementSelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7B8C0
        public void GetAsyncEnumerator(){}
    }

    public class GroupByAwaitWithCancellation`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
        public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> elementSelector;
        public System.Func`4<T,System.Collections.Generic.IEnumerable`1<T>,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7BB70
        public void GetAsyncEnumerator(){}
    }

    public class GroupByAwait`3 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
        public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<T>> elementSelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7B8C0
        public void GetAsyncEnumerator(){}
    }

    public class GroupByAwait`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
        public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<T>> elementSelector;
        public System.Func`3<T,System.Collections.Generic.IEnumerable`1<T>,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7BB70
        public void GetAsyncEnumerator(){}
    }

    public class GroupBy`3 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`2<T,T> keySelector;
        public System.Func`2<T,T> elementSelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7B8C0
        public void GetAsyncEnumerator(){}
    }

    public class GroupBy`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`2<T,T> keySelector;
        public System.Func`2<T,T> elementSelector;
        public System.Func`3<T,System.Collections.Generic.IEnumerable`1<T>,T> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7BB70
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
        public void .ctor(){} // RVA: 0x7FFAC2C7BCE0
        public void GetAsyncEnumerator(){}
    }

    public class GroupJoinAwait`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> outer;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> inner;
        public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<T>> outerKeySelector;
        public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<T>> innerKeySelector;
        public System.Func`3<T,System.Collections.Generic.IEnumerable`1<T>,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7BCE0
        public void GetAsyncEnumerator(){}
    }

    public class GroupJoin`4 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> outer;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> inner;
        public System.Func`2<T,T> outerKeySelector;
        public System.Func`2<T,T> innerKeySelector;
        public System.Func`3<T,System.Collections.Generic.IEnumerable`1<T>,T> resultSelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7BCE0
        public void GetAsyncEnumerator(){}
    }

}