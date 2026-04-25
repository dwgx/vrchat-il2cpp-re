// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 24
// Methods: 96

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class SelectAwaitWithCancellation`2 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SelectAwait`2 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<T>> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SelectIntAwaitWithCancellation`2 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`4<U,int,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SelectIntAwait`2 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`3<U,int,Cysharp.Threading.Tasks.UniTask`1<T>> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SelectInt`2 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`3<U,int,T> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SelectManyAwaitWithCancellation`3 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V>>> selector1;
        public System.Func`4<U,int,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V>>> selector2;
        public System.Func`4<U,V,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60 | overloaded x2
        public void GetAsyncEnumerator(){}
    }

    public class SelectManyAwait`3 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V>>> selector1;
        public System.Func`3<U,int,Cysharp.Threading.Tasks.UniTask`1<Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V>>> selector2;
        public System.Func`3<U,V,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60 | overloaded x2
        public void GetAsyncEnumerator(){}
    }

    public class SelectMany`3 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`2<U,Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V>> selector1;
        public System.Func`3<U,int,Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V>> selector2;
        public System.Func`3<U,V,T> resultSelector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60 | overloaded x2
        public void GetAsyncEnumerator(){}
    }

    public class Select`2 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Func`2<U,T> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SequenceEqual : Object
    {
        // ── Methods ──
        public void SequenceEqualAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SingleOperator : Object
    {
        // ── Methods ──
        public void SingleAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SingleAwaitAsync(){} // RVA: 0x7FFD4E2ADC40
        public void SingleAwaitWithCancellationAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SkipLast`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public int count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970
        public void GetAsyncEnumerator(){}
    }

    public class SkipUntilCanceled`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Threading.CancellationToken cancellationToken;

        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){}
    }

    public class SkipUntil`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public Cysharp.Threading.Tasks.UniTask other;
        public System.Func`2<System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask> other2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetAsyncEnumerator(){}
    }

    public class SkipWhileAwaitWithCancellation`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SkipWhileAwait`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SkipWhileIntAwaitWithCancellation`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`4<T,int,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SkipWhileIntAwait`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`3<T,int,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SkipWhileInt`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`3<T,int,bool> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SkipWhile`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`2<T,bool> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class Skip`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public int count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970
        public void GetAsyncEnumerator(){}
    }

    public class Subscribe : Object
    {
        public System.Action`1<System.Exception> NopError;
        public System.Action NopCompleted; // 0x8

        // ── Methods ──
        public void SubscribeCore(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void SubscribeAwaitCore(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD548DC390
    }

    public class Sum : Object
    {
        // ── Methods ──
        public void SumAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x20
        public void SumAwaitAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x10
        public void SumAwaitWithCancellationAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x10
    }

    public class SyncSelectorAsyncEnumerableSorter`2 : AsyncEnumerableSorter`1
    {
        public System.Func`2<U,T> keySelector;
        public System.Collections.Generic.IComparer`1<T> comparer;
        public bool descending;
        public Cysharp.Threading.Tasks.Linq.AsyncEnumerableSorter`1<U> next;
        public T[] keys;

        // ── Methods ──
        public void .ctor(){}
        public void ComputeKeysAsync(){}
        public void CompareKeys(){} // RVA: 0x7FFD4E080290
    }

}