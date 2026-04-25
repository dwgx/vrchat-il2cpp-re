// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 10
// Methods: 98

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class Aggregate : Object
    {
        // ── Methods ──
        public void AggregateAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void AggregateAwaitAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void AggregateAwaitWithCancellationAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
    }

    public class All : Object
    {
        // ── Methods ──
        public void AllAsync(){} // RVA: 0x7FFAC2E8DC40
        public void AllAwaitAsync(){} // RVA: 0x7FFAC2E8DC40
        public void AllAwaitWithCancellationAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Any : Object
    {
        // ── Methods ──
        public void AnyAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void AnyAwaitAsync(){} // RVA: 0x7FFAC2E8DC40
        public void AnyAwaitWithCancellationAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class AppendPrepend`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public T element;
        public bool append;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetAsyncEnumerator(){}
    }

    public class AsyncEnumerableSorter`1 : Object
    {
        // ── Methods ──
        public void ComputeKeysAsync(){}
        public void CompareKeys(){} // RVA: 0x7FFAC2C60290
        public void SortAsync(){}
        public void QuickSort(){} // RVA: 0x7FFAC7537900
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AsyncEnumeratorAwaitSelectorBase`3 : MoveNextSource
    {
        public System.Action`1<object> SourceCurrent;
        public System.Action`1<object> Current;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
        public System.Threading.CancellationToken cancellationToken;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> enumerator;
        public Awaiter<bool> sourceMoveNext;
        public Awaiter<T> resultAwaiter;
        public U <SourceCurrent>k__BackingField;
        public V <Current>k__BackingField;

        // ── Methods ──
        public void .ctor(){}
        public void TransformAsync(){} // RVA: 0x7FFAC2E8DC40
        public void TrySetCurrentCore(){} // RVA: 0x7FFAC2E8DC40
        public void get_SourceCurrent(){} // RVA: 0x7FFAC2E8DC40
        public void set_SourceCurrent(){} // RVA: 0x7FFAC2E8DC40
        public void ActionCompleted(){} // RVA: 0x7FFAC2E8DC40
        public void WaitAwaitCallback(){}
        public void IterateFinished(){}
        public void get_Current(){} // RVA: 0x7FFAC2E8DC40
        public void set_Current(){} // RVA: 0x7FFAC2E8DC40
        public void MoveNextAsync(){}
        public void SourceMoveNext(){} // RVA: 0x7FFAC2C70980
        public void TryMoveNextCore(){} // RVA: 0x7FFAC2E8DC40
        public void UnwarapTask(){} // RVA: 0x7FFAC2E8DC40
        public void MoveNextCallBack(){} // RVA: 0x7FFAC2C70A10
        public void SetCurrentCallBack(){} // RVA: 0x7FFAC2C70A10
        public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class AsyncEnumeratorBase`2 : MoveNextSource
    {
        public System.Action`1<object> SourceCurrent;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> Current;
        public System.Threading.CancellationToken cancellationToken;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> enumerator;
        public Awaiter<bool> sourceMoveNext;
        public T <Current>k__BackingField;

        // ── Methods ──
        public void .ctor(){}
        public void TryMoveNextCore(){}
        public void get_SourceCurrent(){} // RVA: 0x7FFAC2E8DC40
        public void get_Current(){} // RVA: 0x7FFAC2E8DC40
        public void set_Current(){} // RVA: 0x7FFAC2E8DC40
        public void MoveNextAsync(){}
        public void OnFirstIteration(){} // RVA: 0x7FFAC2C59D00
        public void SourceMoveNext(){} // RVA: 0x7FFAC2C70980
        public void MoveNextCallBack(){} // RVA: 0x7FFAC2C70A10
        public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class AsyncSelectorEnumerableSorter`2 : AsyncEnumerableSorter`1
    {
        public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
        public System.Collections.Generic.IComparer`1<T> comparer;
        public bool descending;
        public Cysharp.Threading.Tasks.Linq.AsyncEnumerableSorter`1<U> next;
        public T[] keys;

        // ── Methods ──
        public void .ctor(){}
        public void ComputeKeysAsync(){}
        public void CompareKeys(){} // RVA: 0x7FFAC2C60290
    }

    public class AsyncSelectorWithCancellationEnumerableSorter`2 : AsyncEnumerableSorter`1
    {
        public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
        public System.Collections.Generic.IComparer`1<T> comparer;
        public bool descending;
        public Cysharp.Threading.Tasks.Linq.AsyncEnumerableSorter`1<U> next;
        public System.Threading.CancellationToken cancellationToken;
        public T[] keys;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void ComputeKeysAsync(){}
        public void CompareKeys(){} // RVA: 0x7FFAC2C60290
    }

    public class Average : Object
    {
        // ── Methods ──
        public void AverageAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x20
        public void AverageAwaitAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x10
        public void AverageAwaitWithCancellationAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x10
    }

}