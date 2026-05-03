// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 10
// Methods: 98

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class Aggregate : Object
    {
        // ── Methods ──
        public void AggregateAsync(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void AggregateAwaitAsync(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void AggregateAwaitWithCancellationAsync(){} // RVA: 0x7FFE810A1420 | overloaded x3
    }

    public class All : Object
    {
        // ── Methods ──
        public void AllAsync(){} // RVA: 0x7FFE810A1420
        public void AllAwaitAsync(){} // RVA: 0x7FFE810A1420
        public void AllAwaitWithCancellationAsync(){} // RVA: 0x7FFE810A1420
    }

    public class Any : Object
    {
        // ── Methods ──
        public void AnyAsync(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void AnyAwaitAsync(){} // RVA: 0x7FFE810A1420
        public void AnyAwaitWithCancellationAsync(){} // RVA: 0x7FFE810A1420
    }

    public class AppendPrepend`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GetAsyncEnumerator(){}
    }

    public class AsyncEnumerableSorter`1 : Object
    {
        // ── Methods ──
        public void ComputeKeysAsync(){}
        public void CompareKeys(){} // RVA: 0x7FFE80E356E0
        public void SortAsync(){}
        public void QuickSort(){} // RVA: 0x7FFE858D7050
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AsyncEnumeratorAwaitSelectorBase`3 : MoveNextSource
    {
        public System.Action`1<object> moveNextCallbackDelegate;
        public System.Action`1<object> setCurrentCallbackDelegate;

        // ── Methods ──
        public void .ctor(){}
        public void TransformAsync(){} // RVA: 0x7FFE810A1420
        public void TrySetCurrentCore(){} // RVA: 0x7FFE810A1420
        public void get_SourceCurrent(){} // RVA: 0x7FFE810A1420
        public void set_SourceCurrent(){} // RVA: 0x7FFE810A1420
        public void ActionCompleted(){} // RVA: 0x7FFE810A1420
        public void WaitAwaitCallback(){}
        public void IterateFinished(){}
        public void get_Current(){} // RVA: 0x7FFE810A1420
        public void set_Current(){} // RVA: 0x7FFE810A1420
        public void MoveNextAsync(){}
        public void SourceMoveNext(){} // RVA: 0x7FFE80E45FE0
        public void TryMoveNextCore(){} // RVA: 0x7FFE810A1420
        public void UnwarapTask(){} // RVA: 0x7FFE810A1420
        public void MoveNextCallBack(){} // RVA: 0x7FFE80E46070
        public void SetCurrentCallBack(){} // RVA: 0x7FFE80E46070
        public void DisposeAsync(){} // RVA: 0x7FFE80E2DCF0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class AsyncEnumeratorBase`2 : MoveNextSource
    {
        public System.Action`1<object> moveNextCallbackDelegate;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;

        // ── Methods ──
        public void .ctor(){}
        public void TryMoveNextCore(){}
        public void get_SourceCurrent(){} // RVA: 0x7FFE810A1420
        public void get_Current(){} // RVA: 0x7FFE810A1420
        public void set_Current(){} // RVA: 0x7FFE810A1420
        public void MoveNextAsync(){}
        public void OnFirstIteration(){} // RVA: 0x7FFE80E2F150
        public void SourceMoveNext(){} // RVA: 0x7FFE80E45FE0
        public void MoveNextCallBack(){} // RVA: 0x7FFE80E46070
        public void DisposeAsync(){} // RVA: 0x7FFE80E2DCF0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class AsyncSelectorEnumerableSorter`2 : AsyncEnumerableSorter`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void ComputeKeysAsync(){}
        public void CompareKeys(){} // RVA: 0x7FFE80E356E0
    }

    public class AsyncSelectorWithCancellationEnumerableSorter`2 : AsyncEnumerableSorter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void ComputeKeysAsync(){}
        public void CompareKeys(){} // RVA: 0x7FFE80E356E0
    }

    public class Average : Object
    {
        // ── Methods ──
        public void AverageAsync(){} // RVA: 0x7FFE810A1420 | overloaded x20
        public void AverageAwaitAsync(){} // RVA: 0x7FFE810A1420 | overloaded x10
        public void AverageAwaitWithCancellationAsync(){} // RVA: 0x7FFE810A1420 | overloaded x10
    }

}