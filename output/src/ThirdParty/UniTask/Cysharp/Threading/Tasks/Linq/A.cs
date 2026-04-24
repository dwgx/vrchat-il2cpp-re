// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 10
// Methods: 98

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class Aggregate : Object
    {
        // ── Methods ──
        public void AggregateAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void AggregateAwaitAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void AggregateAwaitWithCancellationAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
    }

    public class All : Object
    {
        // ── Methods ──
        public void AllAsync(){} // RVA: 0x7FFD4E2ADC40
        public void AllAwaitAsync(){} // RVA: 0x7FFD4E2ADC40
        public void AllAwaitWithCancellationAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Any : Object
    {
        // ── Methods ──
        public void AnyAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AnyAwaitAsync(){} // RVA: 0x7FFD4E2ADC40
        public void AnyAwaitWithCancellationAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class AppendPrepend`1 : Object
    {
        public eObjectDelegate.fo<T1717621472> source;
        public T1717621472 element;
        public bool append;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetAsyncEnumerator(){}
    }

    public class AsyncEnumerableSorter`1 : Object
    {
        // ── Methods ──
        public void ComputeKeysAsync(){}
        public void CompareKeys(){} // RVA: 0x7FFD4E080290
        public void SortAsync(){}
        public void QuickSort(){} // RVA: 0x7FFD52957900
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AsyncEnumeratorAwaitSelectorBase`3 : MoveNextSource
    {
        public ileFullDirectoryInformation<object> SourceCurrent;
        public ileFullDirectoryInformation<object> Current; // 0x8
        public eObjectDelegate.fo<T1717638672> source; // 0x38
        public sageKind.TICMAP_SIZE cancellationToken; // 0x40
        public eObjectDelegate.o<T1717638672> enumerator; // 0x48
        public peInfoResolverChain<bool> sourceMoveNext; // 0x50
        public peInfoResolverChain<bool> resultAwaiter; // 0x60
        public T1717638672 <SourceCurrent>k__BackingField; // 0x70
        public T1717638672 <Current>k__BackingField; // 0x78

        // ── Methods ──
        public void .ctor(){}
        public void TransformAsync(){} // RVA: 0x7FFD4E2ADC40
        public void TrySetCurrentCore(){} // RVA: 0x7FFD4E2ADC40
        public void get_SourceCurrent(){} // RVA: 0x7FFD4E2ADC40
        public void set_SourceCurrent(){} // RVA: 0x7FFD4E2ADC40
        public void ActionCompleted(){} // RVA: 0x7FFD4E2ADC40
        public void WaitAwaitCallback(){}
        public void IterateFinished(){}
        public void get_Current(){} // RVA: 0x7FFD4E2ADC40
        public void set_Current(){} // RVA: 0x7FFD4E2ADC40
        public void MoveNextAsync(){}
        public void SourceMoveNext(){} // RVA: 0x7FFD4E090980
        public void TryMoveNextCore(){} // RVA: 0x7FFD4E2ADC40
        public void UnwarapTask(){} // RVA: 0x7FFD4E2ADC40
        public void MoveNextCallBack(){} // RVA: 0x7FFD4E090A10
        public void SetCurrentCallBack(){} // RVA: 0x7FFD4E090A10
        public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class AsyncEnumeratorBase`2 : MoveNextSource
    {
        public ileFullDirectoryInformation<object> SourceCurrent;
        public eObjectDelegate.fo<T1717638544> Current; // 0x38
        public sageKind.TICMAP_SIZE cancellationToken; // 0x40
        public eObjectDelegate.o<T1717638544> enumerator; // 0x48
        public peInfoResolverChain<bool> sourceMoveNext; // 0x50
        public T1717638544 <Current>k__BackingField; // 0x60

        // ── Methods ──
        public void .ctor(){}
        public void TryMoveNextCore(){}
        public void get_SourceCurrent(){} // RVA: 0x7FFD4E2ADC40
        public void get_Current(){} // RVA: 0x7FFD4E2ADC40
        public void set_Current(){} // RVA: 0x7FFD4E2ADC40
        public void MoveNextAsync(){}
        public void OnFirstIteration(){} // RVA: 0x7FFD4E079D00
        public void SourceMoveNext(){} // RVA: 0x7FFD4E090980
        public void MoveNextCallBack(){} // RVA: 0x7FFD4E090A10
        public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class AsyncSelectorEnumerableSorter`2 : AsyncEnumerableSorter`1
    {
        public n<T1717635344,eObjectDelegate.kingField<T1717635360>> keySelector;
        public URA.ndar_data<T1717635360> comparer;
        public bool descending;
        public dLighting.rsalMode<T1717635344> next;
        public T1717635360[] keys;

        // ── Methods ──
        public void .ctor(){}
        public void ComputeKeysAsync(){}
        public void CompareKeys(){} // RVA: 0x7FFD4E080290
    }

    public class AsyncSelectorWithCancellationEnumerableSorter`2 : AsyncEnumerableSorter`1
    {
        public nalInformation<T1717635408,sageKind.TICMAP_SIZE,eObjectDelegate.kingField<T1717635424>> keySelector;
        public URA.ndar_data<T1717635424> comparer;
        public bool descending;
        public dLighting.rsalMode<T1717635408> next;
        public sageKind.TICMAP_SIZE cancellationToken;
        public T1717635424[] keys;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void ComputeKeysAsync(){}
        public void CompareKeys(){} // RVA: 0x7FFD4E080290
    }

    public class Average : Object
    {
        // ── Methods ──
        public void AverageAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x20
        public void AverageAwaitAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x10
        public void AverageAwaitWithCancellationAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x10
    }

}