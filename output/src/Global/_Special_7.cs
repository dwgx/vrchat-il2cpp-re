// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 339

public class <SingleAsync>d__0`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public bool defaultIfEmpty;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public T <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public T <v>5__6;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SingleAsync>d__1`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,bool> predicate;
    public bool defaultIfEmpty;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public T <>7__wrap4;
    public T <value>5__6;
    public bool <found>5__7;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SingleAwaitAsync>d__2`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;
    public bool defaultIfEmpty;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public T <>7__wrap4;
    public T <value>5__6;
    public bool <found>5__7;
    public T <v>5__8;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SingleAwaitWithCancellationAsync>d__3`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;
    public bool defaultIfEmpty;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public T <>7__wrap4;
    public T <value>5__6;
    public bool <found>5__7;
    public T <v>5__8;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SkipIterator>d__31`1 : Object
{
    public int System.Collections.Generic.IEnumerator<TSource>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<T> source;
    public System.Collections.Generic.IEnumerable`1<T> <>3__source;
    public int count;
    public int <>3__count;
    public System.Collections.Generic.IEnumerator`1<T> <e>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<TSource>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<TSource>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <SkipLast>d__1`1 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<T> source;
    public System.Collections.Generic.IEnumerable`1<T> <>3__source;
    public int count;
    public int <>3__count;
    public System.Collections.Generic.Queue`1<T> <queue>5__2;
    public System.Collections.Generic.IEnumerator`1<T> <e>5__3;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<T>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <SortAsync>d__2 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<int[]> <>t__builder;
    public Cysharp.Threading.Tasks.Linq.AsyncEnumerableSorter`1<T> <>4__this;
    public T[] elements;
    public int count;
    public Awaiter <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <Start>d__2 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current;
    public object System.Collections.IEnumerator.Current;
    public T tweenInfo;
    public float <elapsedTime>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <Start>d__6 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public UnityStandardAssets.Effects.ExplosionFireAndDebris <>4__this; // 0x20
    public float <multiplier>5__2; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD4E34E060
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E34EE00
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <StartSkidTrail>d__20 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public UnityStandardAssets.Vehicles.Car.WheelEffects <>4__this; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD4E3687D0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E368C10
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <SubscribeAwaitCore>d__6`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask> onNext;
    public System.Action onCompleted;
    public System.Action`1<System.Exception> onError;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public Awaiter <>u__1;
    public Awaiter<bool> <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SubscribeAwaitCore>d__7`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask> onNext;
    public System.Action onCompleted;
    public System.Action`1<System.Exception> onError;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public Awaiter <>u__1;
    public Awaiter<bool> <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SubscribeCore>d__2`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Action`1<T> onNext;
    public System.Action onCompleted;
    public System.Action`1<System.Exception> onError;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SubscribeCore>d__3`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTaskVoid> onNext;
    public System.Action onCompleted;
    public System.Action`1<System.Exception> onError;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SubscribeCore>d__4`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTaskVoid> onNext;
    public System.Action onCompleted;
    public System.Action`1<System.Exception> onError;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SubscribeCore>d__5`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.IObserver`1<T> observer;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAsync>d__13`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<double> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,double> selector;
    public double <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAsync>d__17`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Decimal> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,System.Decimal> selector;
    public System.Decimal <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAsync>d__1`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<int> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,int> selector;
    public int <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAsync>d__21`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<int>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,System.Nullable`1<int>> selector;
    public System.Nullable`1<int> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAsync>d__25`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<long>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,System.Nullable`1<long>> selector;
    public System.Nullable`1<long> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAsync>d__29`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<float>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,System.Nullable`1<float>> selector;
    public System.Nullable`1<float> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAsync>d__33`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<double>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,System.Nullable`1<double>> selector;
    public System.Nullable`1<double> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAsync>d__37`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<System.Decimal>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,System.Nullable`1<System.Decimal>> selector;
    public System.Nullable`1<System.Decimal> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAsync>d__5`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<long> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,long> selector;
    public long <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAsync>d__9`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<float> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,float> selector;
    public float <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitAsync>d__10`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<float> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<float>> selector;
    public float <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public float <>7__wrap5;
    public Awaiter<float> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitAsync>d__14`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<double> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<double>> selector;
    public double <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public double <>7__wrap5;
    public Awaiter<double> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitAsync>d__18`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Decimal> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<System.Decimal>> selector;
    public System.Decimal <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Decimal <>7__wrap5;
    public Awaiter<System.Decimal> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitAsync>d__22`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<int>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<int>>> selector;
    public System.Nullable`1<int> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<int> <>7__wrap5;
    public Awaiter<System.Nullable`1<int>> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitAsync>d__26`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<long>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<long>>> selector;
    public System.Nullable`1<long> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<long> <>7__wrap5;
    public Awaiter<System.Nullable`1<long>> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitAsync>d__2`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<int> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<int>> selector;
    public int <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public int <>7__wrap5;
    public Awaiter<int> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitAsync>d__30`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<float>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<float>>> selector;
    public System.Nullable`1<float> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<float> <>7__wrap5;
    public Awaiter<System.Nullable`1<float>> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitAsync>d__34`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<double>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<double>>> selector;
    public System.Nullable`1<double> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<double> <>7__wrap5;
    public Awaiter<System.Nullable`1<double>> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitAsync>d__38`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<System.Decimal>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<System.Decimal>>> selector;
    public System.Nullable`1<System.Decimal> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<System.Decimal> <>7__wrap5;
    public Awaiter<System.Nullable`1<System.Decimal>> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitAsync>d__6`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<long> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<long>> selector;
    public long <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public long <>7__wrap5;
    public Awaiter<long> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitWithCancellationAsync>d__11`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<float> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<float>> selector;
    public float <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public float <>7__wrap5;
    public Awaiter<float> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitWithCancellationAsync>d__15`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<double> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<double>> selector;
    public double <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public double <>7__wrap5;
    public Awaiter<double> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitWithCancellationAsync>d__19`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Decimal> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<System.Decimal>> selector;
    public System.Decimal <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Decimal <>7__wrap5;
    public Awaiter<System.Decimal> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitWithCancellationAsync>d__23`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<int>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<int>>> selector;
    public System.Nullable`1<int> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<int> <>7__wrap5;
    public Awaiter<System.Nullable`1<int>> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitWithCancellationAsync>d__27`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<long>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<long>>> selector;
    public System.Nullable`1<long> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<long> <>7__wrap5;
    public Awaiter<System.Nullable`1<long>> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitWithCancellationAsync>d__31`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<float>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<float>>> selector;
    public System.Nullable`1<float> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<float> <>7__wrap5;
    public Awaiter<System.Nullable`1<float>> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitWithCancellationAsync>d__35`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<double>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<double>>> selector;
    public System.Nullable`1<double> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<double> <>7__wrap5;
    public Awaiter<System.Nullable`1<double>> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitWithCancellationAsync>d__39`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<System.Decimal>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<System.Decimal>>> selector;
    public System.Nullable`1<System.Decimal> <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<System.Decimal> <>7__wrap5;
    public Awaiter<System.Nullable`1<System.Decimal>> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitWithCancellationAsync>d__3`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<int> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<int>> selector;
    public int <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public int <>7__wrap5;
    public Awaiter<int> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <SumAwaitWithCancellationAsync>d__7`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<long> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<long>> selector;
    public long <sum>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public long <>7__wrap5;
    public Awaiter<long> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__6 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public JArray <>4__this; // 0x20
    public System.Collections.Generic.IEnumerator`1<Token> <>7__wrap1; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD5722DE20
    public void MoveNext(){} // RVA: 0x7FFD5722DEE0
    public void <>m__Finally1(){} // RVA: 0x7FFD5722E240
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD5722E2A0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <System-Collections-IEnumerable-GetEnumerator>d__6 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current;
    public object System.Collections.IEnumerator.Current;
    public ValueCollection<T> <>4__this;
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,T>> <>7__wrap1;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <System-Collections-IEnumerable-GetEnumerator>d__9 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current;
    public object System.Collections.IEnumerator.Current;
    public ValueCollection<T> <>4__this;
    public Enumerator<System.Collections.Generic.KeyValuePair`2<string,T>> <>7__wrap1;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <TakeIterator>d__25`1 : Object
{
    public int System.Collections.Generic.IEnumerator<TSource>.Current; // 0x10
    public System.Collections.Generic.IReadOnlyDictionary`2<string,object> System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public int count; // 0x24
    public int <>3__count; // 0x28
    public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.IReadOnlyDictionary`2<string,object>> source; // 0x30
    public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.IReadOnlyDictionary`2<string,object>> <>3__source; // 0x38
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.IReadOnlyDictionary`2<string,object>> <>7__wrap1; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<TSource>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<TSource>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <Timeout>d__13`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public System.TimeSpan timeout;
    public 0x665410C8 delayType;
    public 0x6653D918 timeoutCheckTiming;
    public Cysharp.Threading.Tasks.UniTask`1<T> task;
    public System.Threading.CancellationTokenSource taskCancellationTokenSource;
    public System.Threading.CancellationTokenSource <delayCancellationTokenSource>5__2;
    public Awaiter<System.ValueTuple`3<int,System.ValueTuple`2<bool,T>,bool>> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <TimeoutWithoutException>d__15`1 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.ValueTuple`2<bool,UnityEngine.GameObject>> <>t__builder; // 0x18
    public System.TimeSpan timeout; // 0x38
    public 0x665410C8 delayType; // 0x40
    public 0x6653D918 timeoutCheckTiming; // 0x44
    public Cysharp.Threading.Tasks.UniTask`1<UnityEngine.GameObject> task; // 0x48
    public System.Threading.CancellationTokenSource taskCancellationTokenSource; // 0x60
    public System.Threading.CancellationTokenSource <delayCancellationTokenSource>5__2; // 0x68
    public Awaiter<System.ValueTuple`3<int,System.ValueTuple`2<bool,UnityEngine.GameObject>,bool>> <>u__1; // 0x70

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToArrayAsync>d__0`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T[]> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.Internal.ArrayPool`1<T> <pool>5__2;
    public T[] <array>5__3;
    public T[] <result>5__4;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__5;
    public object <>7__wrap5;
    public int <>7__wrap6;
    public int <i>5__8;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToCancellationTokenCore>d__6 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x18
    public Cysharp.Threading.Tasks.UniTask task; // 0x20
    public System.Threading.CancellationTokenSource cts; // 0x30
    public Awaiter <>u__1; // 0x38

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD5489CEB0
    public void SetStateMachine(){} // RVA: 0x7FFD4E341310
}

public class <ToDictionaryAsync>d__0`2 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.Dictionary`2<T,U>> <>t__builder;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<U,T> keySelector;
    public System.Collections.Generic.Dictionary`2<T,U> <dict>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToDictionaryAsync>d__1`3 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.Dictionary`2<V,T>> <>t__builder;
    public System.Collections.Generic.IEqualityComparer`1<V> comparer;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<U,V> keySelector;
    public System.Func`2<U,T> elementSelector;
    public System.Collections.Generic.Dictionary`2<V,T> <dict>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToDictionaryAwaitAsync>d__2`2 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.Dictionary`2<T,U>> <>t__builder;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
    public System.Collections.Generic.Dictionary`2<T,U> <dict>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public U <v>5__6;
    public Awaiter<T> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToDictionaryAwaitAsync>d__3`3 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.Dictionary`2<V,T>> <>t__builder;
    public System.Collections.Generic.IEqualityComparer`1<V> comparer;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<V>> keySelector;
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<T>> elementSelector;
    public System.Collections.Generic.Dictionary`2<V,T> <dict>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public U <v>5__6;
    public V <key>5__7;
    public Awaiter<V> <>u__1;
    public Awaiter<T> <>u__2;
    public Awaiter<bool> <>u__3;
    public Awaiter <>u__4;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToDictionaryAwaitWithCancellationAsync>d__4`2 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.Dictionary`2<T,U>> <>t__builder;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
    public System.Collections.Generic.Dictionary`2<T,U> <dict>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public U <v>5__6;
    public Awaiter<T> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToDictionaryAwaitWithCancellationAsync>d__5`3 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.Dictionary`2<V,T>> <>t__builder;
    public System.Collections.Generic.IEqualityComparer`1<V> comparer;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<V>> keySelector;
    public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> elementSelector;
    public System.Collections.Generic.Dictionary`2<V,T> <dict>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public U <v>5__6;
    public V <key>5__7;
    public Awaiter<V> <>u__1;
    public Awaiter<T> <>u__2;
    public Awaiter<bool> <>u__3;
    public Awaiter <>u__4;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToEnumerable>d__14`1 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.ReadOnlyMemory`1<T> memory;
    public System.ReadOnlyMemory`1<T> <>3__memory;
    public int <i>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<T>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <ToHashSetAsync>d__0`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.HashSet`1<T>> <>t__builder;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Collections.Generic.HashSet`1<T> <set>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToListAsync>d__0`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.List`1<T>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Collections.Generic.List`1<T> <list>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToLookupAsync>d__0`2 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Linq.ILookup`2<T,U>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<U,T> keySelector;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public Cysharp.Threading.Tasks.Internal.ArrayPool`1<U> <pool>5__2;
    public U[] <array>5__3;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__4;
    public object <>7__wrap4;
    public int <>7__wrap5;
    public System.Linq.ILookup`2<T,U> <>7__wrap6;
    public int <i>5__8;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToLookupAsync>d__1`3 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Linq.ILookup`2<V,T>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<U,V> keySelector;
    public System.Func`2<U,T> elementSelector;
    public System.Collections.Generic.IEqualityComparer`1<V> comparer;
    public Cysharp.Threading.Tasks.Internal.ArrayPool`1<U> <pool>5__2;
    public U[] <array>5__3;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__4;
    public object <>7__wrap4;
    public int <>7__wrap5;
    public System.Linq.ILookup`2<V,T> <>7__wrap6;
    public int <i>5__8;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToLookupAwaitAsync>d__2`2 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Linq.ILookup`2<T,U>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public Cysharp.Threading.Tasks.Internal.ArrayPool`1<U> <pool>5__2;
    public U[] <array>5__3;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__4;
    public object <>7__wrap4;
    public int <>7__wrap5;
    public System.Linq.ILookup`2<T,U> <>7__wrap6;
    public int <i>5__8;
    public Awaiter<bool> <>u__1;
    public Awaiter<Lookup`2<T,U>> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToLookupAwaitAsync>d__3`3 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Linq.ILookup`2<V,T>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<V>> keySelector;
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<T>> elementSelector;
    public System.Collections.Generic.IEqualityComparer`1<V> comparer;
    public Cysharp.Threading.Tasks.Internal.ArrayPool`1<U> <pool>5__2;
    public U[] <array>5__3;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__4;
    public object <>7__wrap4;
    public int <>7__wrap5;
    public System.Linq.ILookup`2<V,T> <>7__wrap6;
    public int <i>5__8;
    public Awaiter<bool> <>u__1;
    public Awaiter<Lookup`2<V,T>> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToLookupAwaitWithCancellationAsync>d__4`2 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Linq.ILookup`2<T,U>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public Cysharp.Threading.Tasks.Internal.ArrayPool`1<U> <pool>5__2;
    public U[] <array>5__3;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__4;
    public object <>7__wrap4;
    public int <>7__wrap5;
    public System.Linq.ILookup`2<T,U> <>7__wrap6;
    public int <i>5__8;
    public Awaiter<bool> <>u__1;
    public Awaiter<Lookup`2<T,U>> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ToLookupAwaitWithCancellationAsync>d__5`3 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Linq.ILookup`2<V,T>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<V>> keySelector;
    public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> elementSelector;
    public System.Collections.Generic.IEqualityComparer`1<V> comparer;
    public Cysharp.Threading.Tasks.Internal.ArrayPool`1<U> <pool>5__2;
    public U[] <array>5__3;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__4;
    public object <>7__wrap4;
    public int <>7__wrap5;
    public System.Linq.ILookup`2<V,T> <>7__wrap6;
    public int <i>5__8;
    public Awaiter<bool> <>u__1;
    public Awaiter<Lookup`2<V,T>> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <UnionIterator>d__71`1 : Object
{
    public int System.Collections.Generic.IEnumerator<TSource>.Current; // 0x10
    public byte System.Collections.IEnumerator.Current; // 0x14
    public int <>l__initialThreadId; // 0x18
    public System.Collections.Generic.IEqualityComparer`1<byte> comparer; // 0x20
    public System.Collections.Generic.IEqualityComparer`1<byte> <>3__comparer; // 0x28
    public System.Collections.Generic.IEnumerable`1<byte> first; // 0x30
    public System.Collections.Generic.IEnumerable`1<byte> <>3__first; // 0x38
    public System.Collections.Generic.IEnumerable`1<byte> second; // 0x40
    public System.Collections.Generic.IEnumerable`1<byte> <>3__second; // 0x48
    public System.Linq.Set`1<byte> <set>5__2; // 0x50
    public System.Collections.Generic.IEnumerator`1<byte> <>7__wrap2; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void <>m__Finally2(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<TSource>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<TSource>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <Unwrap>d__30`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public Cysharp.Threading.Tasks.UniTask`1<Cysharp.Threading.Tasks.UniTask`1<T>> task;
    public Awaiter<Cysharp.Threading.Tasks.UniTask`1<T>> <>u__1;
    public Awaiter<T> <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <Unwrap>d__32`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public System.Threading.Tasks.Task`1<Cysharp.Threading.Tasks.UniTask`1<T>> task;
    public System.Runtime.CompilerServices.TaskAwaiter`1<Cysharp.Threading.Tasks.UniTask`1<T>> <>u__1;
    public Awaiter<T> <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <Unwrap>d__33`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public System.Threading.Tasks.Task`1<Cysharp.Threading.Tasks.UniTask`1<T>> task;
    public bool continueOnCapturedContext;
    public ConfiguredTaskAwaiter<Cysharp.Threading.Tasks.UniTask`1<T>> <>u__1;
    public Awaiter<T> <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <Unwrap>d__36`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public Cysharp.Threading.Tasks.UniTask`1<System.Threading.Tasks.Task`1<T>> task;
    public Awaiter<System.Threading.Tasks.Task`1<T>> <>u__1;
    public System.Runtime.CompilerServices.TaskAwaiter`1<T> <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <Unwrap>d__37`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public Cysharp.Threading.Tasks.UniTask`1<System.Threading.Tasks.Task`1<T>> task;
    public bool continueOnCapturedContext;
    public Awaiter<System.Threading.Tasks.Task`1<T>> <>u__1;
    public ConfiguredTaskAwaiter<T> <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <Values>d__11`2 : Object
{
    public int System.Collections.Generic.IEnumerator<U>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<U> source;
    public System.Collections.Generic.IEnumerable`1<U> <>3__source;
    public object key;
    public object <>3__key;
    public System.Collections.Generic.IEnumerator`1<U> <>7__wrap1;
    public System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken> <>7__wrap2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void <>m__Finally2(){} // RVA: 0x7FFD4E090980
    public void <>m__Finally3(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<U>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<U>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <WaitAsync>d__80`1 : ValueType
{
    public int <>1__state;
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<T> <>t__builder;
    public System.Threading.Tasks.Task`1<T> task;
    public System.TimeSpan timeout;
    public System.Threading.CancellationTokenSource <cancellationSource>5__2;
    public System.Runtime.CompilerServices.TaskAwaiter`1<T> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <WaitAsync>d__81`1 : ValueType
{
    public int <>1__state;
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<T> <>t__builder;
    public System.TimeSpan timeout;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.Tasks.Task`1<T> task;
    public System.Threading.Tasks.Task <delayTask>5__2;
    public System.Runtime.CompilerServices.TaskAwaiter`1<System.Threading.Tasks.Task> <>u__1;
    public System.Runtime.CompilerServices.TaskAwaiter`1<T> <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <WaitForCompletion>d__15 : ValueType
{
    public int <>1__state;
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<T> <>t__builder;
    public System.Net.WebCompletionSource`1<T> <>4__this;
    public ConfiguredTaskAwaiter<Result<T>> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <WaitForCompletion>d__17 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public DG.Tweening.Tween t; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD4FDE6AD0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4FDE6B70
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <WaitForElapsedLoops>d__20 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public DG.Tweening.Tween t; // 0x20
    public int elapsedLoops; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD4FDE6D80
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4FDE6E30
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <WaitForKill>d__19 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public DG.Tweening.Tween t; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD4FDE6CB0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4FDE6D40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <WaitForNetworkOnlineAsync>d__15 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Sentry.Internal.PollingNetworkStatusListener <>4__this; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public 0x66436E68 <>u__1; // 0x40
    public ConfiguredTaskAwaiter<bool> <>u__2; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD53FCE470
    public void SetStateMachine(){} // RVA: 0x7FFD53FCEC30
}

public class <WaitForPosition>d__21 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public DG.Tweening.Tween t; // 0x20
    public float position; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD4FDE6E70
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4FDE6F30
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <WaitForRewind>d__18 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public DG.Tweening.Tween t; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD4FDE6BB0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4FDE6C70
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <WaitForStart>d__22 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public DG.Tweening.Tween t; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD4FDE6F70
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4FDE7010
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <WaitNextAsync>d__33 : ValueType
{
    public int <>1__state;
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<NextResult<T>> <>t__builder;
    public Mediapipe.Unity.OutputStream`1<T> <>4__this;
    public ConfiguredTaskAwaiter<NextResult<T>> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <WaitUntilCountOrTimeoutAsync>d__32 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<bool> <>t__builder; // 0x18
    public System.Threading.CancellationToken cancellationToken; // 0x30
    public TaskNode asyncWaiter; // 0x38
    public int millisecondsTimeout; // 0x40
    public System.Threading.SemaphoreSlim <>4__this; // 0x48
    public System.Threading.CancellationTokenSource <cts>5__2; // 0x50
    public object <>7__wrap2; // 0x58
    public ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1; // 0x60
    public ConfiguredTaskAwaiter<bool> <>u__2; // 0x70

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD53AE48A0
    public void SetStateMachine(){} // RVA: 0x7FFD53AE54E0
}

public class <WhereIterator>d__2`1 : Object
{
    public int System.Collections.Generic.IEnumerator<TSource>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<T> source;
    public System.Collections.Generic.IEnumerable`1<T> <>3__source;
    public System.Func`3<T,int,bool> predicate;
    public System.Func`3<T,int,bool> <>3__predicate;
    public int <index>5__2;
    public System.Collections.Generic.IEnumerator`1<T> <>7__wrap2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<TSource>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<TSource>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <WhereNotNullValue>d__3`2 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current;
    public System.Collections.Generic.KeyValuePair`2<U,T> System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<U,T>> source;
    public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<U,T>> <>3__source;
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<U,T>> <>7__wrap1;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <WriteAsyncCore>d__4 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Channels.ChannelWriter`1<ZLogger.IZLoggerEntry> <>4__this; // 0x38
    public ZLogger.IZLoggerEntry innerItem; // 0x40
    public System.Threading.CancellationToken ct; // 0x48
    public ConfiguredValueTaskAwaiter<bool> <>u__1; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <WriteAsyncInternal>d__57 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public int charPos; // 0x30
    public int charLen; // 0x34
    public System.IO.StreamWriter _this; // 0x38
    public char[] charBuffer; // 0x40
    public char value; // 0x48
    public bool appendNewLine; // 0x4A
    public char[] coreNewLine; // 0x50
    public bool autoFlush; // 0x58
    public 0x66436E68 <>u__1; // 0x60
    public int <i>5__2; // 0x70

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD539ECDF0
    public void SetStateMachine(){} // RVA: 0x7FFD539ED3A0
}

public class <WriteAsyncInternal>d__59 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public string value; // 0x30
    public int charPos; // 0x38
    public int charLen; // 0x3C
    public System.IO.StreamWriter _this; // 0x40
    public char[] charBuffer; // 0x48
    public bool appendNewLine; // 0x50
    public char[] coreNewLine; // 0x58
    public bool autoFlush; // 0x60
    public int <count>5__2; // 0x64
    public int <index>5__3; // 0x68
    public 0x66436E68 <>u__1; // 0x70
    public int <i>5__4; // 0x80

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD539ED400
    public void SetStateMachine(){} // RVA: 0x7FFD539ED990
}

public class <WriteAsyncInternal>d__62 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public int charPos; // 0x30
    public int charLen; // 0x34
    public System.IO.StreamWriter _this; // 0x38
    public char[] charBuffer; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public System.ReadOnlyMemory`1<char> source; // 0x50
    public bool appendNewLine; // 0x60
    public char[] coreNewLine; // 0x68
    public bool autoFlush; // 0x70
    public int <copied>5__2; // 0x74
    public 0x66436E68 <>u__1; // 0x78
    public int <i>5__3; // 0x88

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD539ED9F0
    public void SetStateMachine(){} // RVA: 0x7FFD539EE140
}

public class <WriteLoop>d__14 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public ZLogger.AsyncStreamLineMessageWriter <>4__this; // 0x30
    public ZLogger.Internal.StreamBufferWriter <writer>5__2; // 0x38
    public ZLogger.IZLoggerFormatter <formatter>5__3; // 0x40
    public bool <withLineBreak>5__4; // 0x48
    public bool <requireFilterCheck>5__5; // 0x49
    public System.Threading.Channels.ChannelReader`1<ZLogger.IZLoggerEntry> <reader>5__6; // 0x50
    public ConfiguredValueTaskAwaiter<bool> <>u__1; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD575050D0
    public void SetStateMachine(){} // RVA: 0x7FFD57505AE0
}

public class <ZipIterator>d__65`3 : Object
{
    public int System.Collections.Generic.IEnumerator<TResult>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<U> first;
    public System.Collections.Generic.IEnumerable`1<U> <>3__first;
    public System.Collections.Generic.IEnumerable`1<V> second;
    public System.Collections.Generic.IEnumerable`1<V> <>3__second;
    public System.Func`3<U,V,T> resultSelector;
    public System.Func`3<U,V,T> <>3__resultSelector;
    public System.Collections.Generic.IEnumerator`1<U> <e1>5__2;
    public System.Collections.Generic.IEnumerator`1<V> <e2>5__3;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void <>m__Finally2(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<TResult>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<TResult>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <acquireMultiCastPeriodically>d__16 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public VRC.OSCQuery.Android.AndroidDiscovery <>4__this; // 0x28
    public Awaiter <>u__1; // 0x30

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E5576A0
    public void SetStateMachine(){} // RVA: 0x7FFD4E341310
}

public class <get_Claims>d__51 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current; // 0x10
    public 0x6642E490 System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public System.Security.Claims.ClaimsIdentity <>4__this; // 0x28
    public int <i>5__2; // 0x30
    public System.Collections.Generic.IEnumerator`1<0x6642E490> <>7__wrap2; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E69C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD538761B0
    public void MoveNext(){} // RVA: 0x7FFD53876270
    public void <>m__Finally1(){} // RVA: 0x7FFD53876730
    public void System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD53876790
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator(){} // RVA: 0x7FFD538767D0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD538767D0
}

public class <get_Integrations>d__62 : Object
{
    public int System.Collections.Generic.IEnumerator<Sentry.Integrations.ISdkIntegration>.Current; // 0x10
    public Sentry.Integrations.ISdkIntegration System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public Sentry.SentryOptions <>4__this; // 0x28
    public Enumerator<Sentry.Integrations.ISdkIntegration> <>7__wrap1; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E69C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD53F65250
    public void MoveNext(){} // RVA: 0x7FFD53F65310
    public void <>m__Finally1(){} // RVA: 0x7FFD53F65900
    public void System.Collections.Generic.IEnumerator<Sentry.Integrations.ISdkIntegration>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD53F65950
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.Generic.IEnumerable<Sentry.Integrations.ISdkIntegration>.GetEnumerator(){} // RVA: 0x7FFD53F65990
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD53F65990
}

public class <get_Keys>d__25 : Object
{
    public int System.Collections.Generic.IEnumerator<TKey>.Current;
    public U System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Immutable.ImmutableDictionary`2<U,T> <>4__this;
    public Enumerator<HashBucket<U,T>> <>7__wrap1;
    public Enumerator<U,T> <>7__wrap2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void <>m__Finally2(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<TKey>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<TKey>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}
