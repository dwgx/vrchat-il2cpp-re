// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 10
// Methods: 20

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class DefaultIfEmpty`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public T defaultValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetAsyncEnumerator(){}
    }

    public class DistinctAwaitWithCancellation`2 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void GetAsyncEnumerator(){}
    }

    public class DistinctAwait`2 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void GetAsyncEnumerator(){}
    }

    public class DistinctUntilChangedAwaitWithCancellation`2 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void GetAsyncEnumerator(){}
    }

    public class DistinctUntilChangedAwait`2 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void GetAsyncEnumerator(){}
    }

    public class DistinctUntilChanged`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void GetAsyncEnumerator(){}
    }

    public class DistinctUntilChanged`2 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`2<T,T> keySelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void GetAsyncEnumerator(){}
    }

    public class Distinct`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void GetAsyncEnumerator(){}
    }

    public class Distinct`2 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`2<T,T> keySelector;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void GetAsyncEnumerator(){}
    }

    public class Do`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Action`1<T> onNext;
        public System.Action`1<System.Exception> onError;
        public System.Action onCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7B8C0
        public void GetAsyncEnumerator(){}
    }

}