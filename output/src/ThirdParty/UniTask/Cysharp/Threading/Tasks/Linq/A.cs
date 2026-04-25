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
        public object SourceCurrent;
        public object Current;

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
        public object SourceCurrent;
        public object Current;

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
        // ── Methods ──
        public void .ctor(){}
        public void ComputeKeysAsync(){}
        public void CompareKeys(){} // RVA: 0x7FFD4E080290
    }

    public class AsyncSelectorWithCancellationEnumerableSorter`2 : AsyncEnumerableSorter`1
    {
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