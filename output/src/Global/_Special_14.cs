// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 355

public class <WaitAsync>d__41 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public 0x6B1DD918 waitTiming; // 0x28
    public Unity.Jobs.JobHandle jobHandle; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public Awaiter <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC94D7400
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <WaitAsync>d__46 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<bool> <>t__builder; // 0x18
    public int millisecondTimeout; // 0x30
    public System.Threading.Tasks.Task workerTask; // 0x38
    public System.Threading.CancellationTokenSource <cts>5__2; // 0x40
    public System.Threading.Tasks.Task <timeoutTask>5__3; // 0x48
    public ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC930E520
    public void SetStateMachine(){} // RVA: 0x7FFAC930EBB0
}

public class <WaitAsync>d__77 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task target; // 0x30
    public System.TimeSpan timeout; // 0x38
    public System.Threading.CancellationTokenSource <cancellationSource>5__2; // 0x40
    public System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8A30CC0
    public void SetStateMachine(){} // RVA: 0x7FFAC8A311D0
}

public class <WaitAsync>d__78 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.TimeSpan timeout; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public System.Threading.Tasks.Task task; // 0x40
    public System.Threading.Tasks.Task <delayTask>5__2; // 0x48
    public System.Runtime.CompilerServices.TaskAwaiter`1<System.Threading.Tasks.Task> <>u__1; // 0x50
    public System.Runtime.CompilerServices.TaskAwaiter <>u__2; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8A31230
    public void SetStateMachine(){} // RVA: 0x7FFAC8A318A0
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
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
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
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <WaitForCompletion>d__15 : ValueType
{
    public int <>1__state;
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<T> <>t__builder;
    public System.Net.WebCompletionSource`1<T> <>4__this;
    public ConfiguredTaskAwaiter<Result<T>> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <WaitForCompletion>d__17 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public DG.Tweening.Tween t; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC49C6AD0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC49C6B70
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <WaitForElapsedLoops>d__20 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public DG.Tweening.Tween t; // 0x20
    public int elapsedLoops; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC49C6D80
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC49C6E30
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <WaitForKill>d__19 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public DG.Tweening.Tween t; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC49C6CB0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC49C6D40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <WaitForNetworkOnlineAsync>d__15 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Sentry.Internal.PollingNetworkStatusListener <>4__this; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public ConfiguredTaskAwaiter <>u__1; // 0x40
    public ConfiguredTaskAwaiter<bool> <>u__2; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8BAE470
    public void SetStateMachine(){} // RVA: 0x7FFAC8BAEC30
}

public class <WaitForPosition>d__21 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public DG.Tweening.Tween t; // 0x20
    public float position; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC49C6E70
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC49C6F30
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <WaitForRewind>d__18 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public DG.Tweening.Tween t; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC49C6BB0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC49C6C70
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <WaitForServerToCloseConnectionAsync>d__63 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Net.WebSockets.ManagedWebSocket <>4__this; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public System.Threading.CancellationTokenSource <finalCts>5__2; // 0x40
    public System.Threading.CancellationTokenRegistration <>7__wrap2; // 0x48
    public ConfiguredValueTaskAwaiter<int> <>u__1; // 0x60

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC9357A50
    public void SetStateMachine(){} // RVA: 0x7FFAC9358310
}

public class <WaitForStart>d__22 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public DG.Tweening.Tween t; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC49C6F70
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC49C7010
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <WaitForWriteTaskAsync>d__55 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.ValueTask writeTask; // 0x30
    public System.Net.WebSockets.ManagedWebSocket <>4__this; // 0x40
    public ConfiguredValueTaskAwaiter <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC93559C0
    public void SetStateMachine(){} // RVA: 0x7FFAC9355F30
}

public class <WaitNextAsync>d__33 : ValueType
{
    public int <>1__state;
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<NextResult<T>> <>t__builder;
    public Mediapipe.Unity.OutputStream`1<T> <>4__this;
    public ConfiguredTaskAwaiter<NextResult<T>> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
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
    public void MoveNext(){} // RVA: 0x7FFAC86C48A0
    public void SetStateMachine(){} // RVA: 0x7FFAC86C54E0
}

public class <WaitforSeekCompletes>d__13 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public RenderHeads.Media.AVProMovieCapture.VideoPlayerController <>4__this; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC8A0D190
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8A0D370
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <WalkExceptions>d__12 : Object
{
    public int System.Collections.Generic.IEnumerator<Sentry.Protocol.SentryException>.Current; // 0x10
    public Sentry.Protocol.SentryException System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public System.Exception exception; // 0x28
    public System.Exception <>3__exception; // 0x30
    public Counter counter; // 0x38
    public Counter <>3__counter; // 0x40
    public Sentry.Internal.MainExceptionProcessor <>4__this; // 0x48
    public System.Nullable`1<int> parentId; // 0x50
    public System.Nullable`1<int> <>3__parentId; // 0x58
    public string source; // 0x60
    public string <>3__source; // 0x68
    public System.Exception <ex>5__2; // 0x70
    public int <id>5__3; // 0x78
    public System.AggregateException <aex>5__4; // 0x80
    public int <i>5__5; // 0x88
    public System.Collections.Generic.IEnumerator`1<Sentry.Protocol.SentryException> <>7__wrap5; // 0x90

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC8BA8E80
    public void MoveNext(){} // RVA: 0x7FFAC8BA8F40
    public void <>m__Finally1(){} // RVA: 0x7FFAC8BA9910
    public void System.Collections.Generic.IEnumerator<Sentry.Protocol.SentryException>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8BA9970
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<Sentry.Protocol.SentryException>.GetEnumerator(){} // RVA: 0x7FFAC8BA99B0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8BA9BB0
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
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void <>m__Finally1(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.Generic.IEnumerator<TSource>.get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.Generic.IEnumerable<TSource>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
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
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void <>m__Finally1(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class <WrapCoroutine>d__43 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public System.Collections.IEnumerator coroutine; // 0x20
    public System.Action onCoroutineFinished; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC8CF4490
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8CF4590
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <WriteAsyncCore>d__4 : ValueType
{
    public int <>1__state;
    public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder <>t__builder;
    public System.Threading.Channels.ChannelWriter`1<T> <>4__this;
    public T innerItem;
    public System.Threading.CancellationToken ct;
    public ConfiguredValueTaskAwaiter<bool> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <WriteAsyncCore>d__47 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.IO.Compression.DeflateManagedStream <>4__this; // 0x30
    public byte[] array; // 0x38
    public int offset; // 0x40
    public int count; // 0x44
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public ConfiguredTaskAwaiter <>u__1; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8F7CFC0
    public void SetStateMachine(){} // RVA: 0x7FFAC8F7D370
}

public class <WriteAsyncCore>d__49 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public int count; // 0x30
    public int offset; // 0x34
    public System.Security.Cryptography.CryptoStream <>4__this; // 0x38
    public byte[] buffer; // 0x40
    public bool useAsync; // 0x48
    public System.Threading.CancellationToken cancellationToken; // 0x50
    public int <bytesToWrite>5__2; // 0x58
    public int <currentInputIndex>5__3; // 0x5C
    public int <numOutputBytes>5__4; // 0x60
    public System.Runtime.CompilerServices.ValueTaskAwaiter <>u__1; // 0x68
    public int <numWholeBlocksInBytes>5__5; // 0x78
    public byte[] <tempOutputBuffer>5__6; // 0x80

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8409580
    public void SetStateMachine(){} // RVA: 0x7FFAC840A7D0
}

public class <WriteAsyncInner>d__33 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Net.WebRequestStream <>4__this; // 0x30
    public byte[] buffer; // 0x38
    public int offset; // 0x40
    public int size; // 0x44
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public System.Net.WebCompletionSource completion; // 0x50
    public ConfiguredTaskAwaiter <>u__1; // 0x58
    public System.Runtime.CompilerServices.TaskAwaiter <>u__2; // 0x68

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC931C390
    public void SetStateMachine(){} // RVA: 0x7FFAC931C9B0
}

public class <WriteAsyncInternal>d__46 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Security.Cryptography.CryptoStream <>4__this; // 0x30
    public byte[] buffer; // 0x38
    public int offset; // 0x40
    public int count; // 0x44
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public System.Threading.SemaphoreSlim <semaphore>5__2; // 0x50
    public System.Threading.Tasks.ForceAsyncAwaiter <>u__1; // 0x58
    public System.Runtime.CompilerServices.TaskAwaiter <>u__2; // 0x60

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8408E40
    public void SetStateMachine(){} // RVA: 0x7FFAC8409520
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
    public ConfiguredTaskAwaiter <>u__1; // 0x60
    public int <i>5__2; // 0x70

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC85CCDF0
    public void SetStateMachine(){} // RVA: 0x7FFAC85CD3A0
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
    public ConfiguredTaskAwaiter <>u__1; // 0x70
    public int <i>5__4; // 0x80

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC85CD400
    public void SetStateMachine(){} // RVA: 0x7FFAC85CD990
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
    public ConfiguredTaskAwaiter <>u__1; // 0x78
    public int <i>5__3; // 0x88

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC85CD9F0
    public void SetStateMachine(){} // RVA: 0x7FFAC85CE140
}

public class <WriteCharAsync>d__14 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task task; // 0x30
    public System.IO.TextWriter writer; // 0x38
    public char c; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public ConfiguredTaskAwaiter <>u__1; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC876CCD0
    public void SetStateMachine(){} // RVA: 0x7FFAC876D0C0
}

public class <WriteChunkTrailer>d__40 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Net.WebRequestStream <>4__this; // 0x30
    public System.Threading.CancellationTokenSource <cts>5__2; // 0x38
    public System.Threading.Tasks.Task <timeoutTask>5__3; // 0x40
    public ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1; // 0x48
    public ConfiguredTaskAwaiter <>u__2; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC931EBA0
    public void SetStateMachine(){} // RVA: 0x7FFAC931F8F0
}

public class <WriteChunkTrailer_inner>d__39 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Net.WebRequestStream <>4__this; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public ConfiguredTaskAwaiter <>u__1; // 0x40

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC931E860
    public void SetStateMachine(){} // RVA: 0x7FFAC931EB40
}

public class <WriteConstructorDateAsync>d__32 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Newtonsoft.Json.JsonReader reader; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public Newtonsoft.Json.JsonWriter <>4__this; // 0x40
    public System.DateTime <date>5__2; // 0x48
    public ConfiguredTaskAwaiter<bool> <>u__1; // 0x50
    public ConfiguredTaskAwaiter <>u__2; // 0x60

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC87511A0
    public void SetStateMachine(){} // RVA: 0x7FFAC87519E0
}

public class <WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public char[] writeBuffer; // 0x30
    public int lastWritePosition; // 0x38
    public Newtonsoft.Json.JsonTextWriter client; // 0x40
    public string s; // 0x48
    public System.IO.TextWriter writer; // 0x50
    public System.Threading.CancellationToken cancellationToken; // 0x58
    public bool[] charEscapeFlags; // 0x60
    public 0x6B1C5B30 stringEscapeHandling; // 0x68
    public bool <isEscapedUnicodeText>5__2; // 0x6C
    public string <escapedValue>5__3; // 0x70
    public ConfiguredTaskAwaiter <>u__1; // 0x78
    public int <i>5__4; // 0x88

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC876D120
    public void SetStateMachine(){} // RVA: 0x7FFAC876DEC0
}

public class <WriteEscapedJavaScriptStringWithDelimitersAsync>d__13 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task task; // 0x30
    public string s; // 0x38
    public System.IO.TextWriter writer; // 0x40
    public bool[] charEscapeFlags; // 0x48
    public 0x6B1C5B30 stringEscapeHandling; // 0x50
    public Newtonsoft.Json.JsonTextWriter client; // 0x58
    public char[] writeBuffer; // 0x60
    public System.Threading.CancellationToken cancellationToken; // 0x68
    public char delimiter; // 0x70
    public ConfiguredTaskAwaiter <>u__1; // 0x78

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC876DF20
    public void SetStateMachine(){} // RVA: 0x7FFAC876E4D0
}

public class <WriteIndentAsync>d__13 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Newtonsoft.Json.JsonTextWriter <>4__this; // 0x30
    public int newLineLen; // 0x38
    public int currentIndentCount; // 0x3C
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public ConfiguredTaskAwaiter <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8739D80
    public void SetStateMachine(){} // RVA: 0x7FFAC873A1F0
}

public class <WriteIntegerValueAsync>d__24 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task task; // 0x30
    public Newtonsoft.Json.JsonTextWriter <>4__this; // 0x38
    public ulong uvalue; // 0x40
    public bool negative; // 0x48
    public System.Threading.CancellationToken cancellationToken; // 0x50
    public ConfiguredTaskAwaiter <>u__1; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC873A250
    public void SetStateMachine(){} // RVA: 0x7FFAC873A630
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
    public void MoveNext(){} // RVA: 0x7FFACC0E50D0
    public void SetStateMachine(){} // RVA: 0x7FFACC0E5AE0
}

public class <WriteRequestAsync>d__38 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Net.WebRequestStream <>4__this; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public System.Net.BufferOffsetSize <buffer>5__2; // 0x40
    public ConfiguredTaskAwaiter <>u__1; // 0x48
    public System.Runtime.CompilerServices.TaskAwaiter <>u__2; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC931E010
    public void SetStateMachine(){} // RVA: 0x7FFAC931E800
}

public class <WriteToAsync>d__0 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Newtonsoft.Json.JsonWriter writer; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public Newtonsoft.Json.Linq.JArray <>4__this; // 0x40
    public Newtonsoft.Json.JsonConverter[] converters; // 0x48
    public ConfiguredTaskAwaiter <>u__1; // 0x50
    public int <i>5__2; // 0x60

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC87BD710
    public void SetStateMachine(){} // RVA: 0x7FFAC87BDD30
}

public class <WriteToAsync>d__1 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task task; // 0x30
    public Newtonsoft.Json.Linq.JProperty <>4__this; // 0x38
    public Newtonsoft.Json.JsonWriter writer; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public Newtonsoft.Json.JsonConverter[] converters; // 0x50
    public ConfiguredTaskAwaiter <>u__1; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC87D0160
    public void SetStateMachine(){} // RVA: 0x7FFAC87D0590
}

public class <WriteToUnderlyingStreamAsync>d__63 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task semaphoreLockTask; // 0x30
    public System.IO.BufferedStream <>4__this; // 0x38
    public System.ReadOnlyMemory`1<byte> buffer; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x50
    public ConfiguredTaskAwaiter <>u__1; // 0x58
    public ConfiguredValueTaskAwaiter <>u__2; // 0x68

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC85E4110
    public void SetStateMachine(){} // RVA: 0x7FFAC85E5210
}

public class <WriteTokenAsync>d__30 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Newtonsoft.Json.JsonWriter <>4__this; // 0x30
    public Newtonsoft.Json.JsonReader reader; // 0x38
    public bool writeDateConstructorAsDate; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public bool writeComments; // 0x50
    public bool writeChildren; // 0x51
    public int <initialDepth>5__2; // 0x54
    public ConfiguredTaskAwaiter <>u__1; // 0x58
    public ConfiguredTaskAwaiter<bool> <>u__2; // 0x68

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8751A40
    public void SetStateMachine(){} // RVA: 0x7FFAC8752450
}

public class <WriteTokenSyncReadingAsync>d__31 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Newtonsoft.Json.JsonWriter <>4__this; // 0x30
    public Newtonsoft.Json.JsonReader reader; // 0x38
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public int <initialDepth>5__2; // 0x48
    public ConfiguredTaskAwaiter<bool> <>u__1; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC87524B0
    public void SetStateMachine(){} // RVA: 0x7FFAC8752B10
}

public class <WriteValueInternalAsync>d__15 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task task; // 0x30
    public Newtonsoft.Json.JsonTextWriter <>4__this; // 0x38
    public string value; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public ConfiguredTaskAwaiter <>u__1; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC873A690
    public void SetStateMachine(){} // RVA: 0x7FFAC873AA90
}

public class <WriteValueNonNullAsync>d__54 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Newtonsoft.Json.JsonTextWriter <>4__this; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public byte[] value; // 0x40
    public ConfiguredTaskAwaiter <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC873AAF0
    public void SetStateMachine(){} // RVA: 0x7FFAC873B600
}

public class <WriteValueNotNullAsync>d__110 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task task; // 0x30
    public Newtonsoft.Json.JsonTextWriter <>4__this; // 0x38
    public System.Uri value; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public ConfiguredTaskAwaiter <>u__1; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC873B660
    public void SetStateMachine(){} // RVA: 0x7FFAC873BAA0
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
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void <>m__Finally1(){} // RVA: 0x7FFAC2C70980
    public void <>m__Finally2(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.Generic.IEnumerator<TResult>.get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.Generic.IEnumerable<TResult>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class <_cAlternateFileName>e__FixedBuffer : ValueType
{
    public char FixedElementField; // 0x10
}

public class <_cFileName>e__FixedBuffer : ValueType
{
    public char FixedElementField; // 0x10
}

public class <acquireMultiCastPeriodically>d__16 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public VRC.OSCQuery.Android.AndroidDiscovery <>4__this; // 0x28
    public Awaiter <>u__1; // 0x30

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC31376A0
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <buffer>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <data>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <emitter>d__11 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public Valve.VR.InteractionSystem.Sample.WheelDust <>4__this; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC8D21550
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8D21670
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <get_Children>d__22 : Object
{
    public int System.Collections.Generic.IEnumerator<OVRSimpleJSON.JSONNode>.Current; // 0x10
    public OVRSimpleJSON.JSONNode System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public OVRSimpleJSON.JSONArray <>4__this; // 0x28
    public Enumerator<OVRSimpleJSON.JSONNode> <>7__wrap1; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC896B720
    public void MoveNext(){} // RVA: 0x7FFAC896B7E0
    public void <>m__Finally1(){} // RVA: 0x7FFAC896BA90
    public void System.Collections.Generic.IEnumerator<OVRSimpleJSON.JSONNode>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC896BAE0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<OVRSimpleJSON.JSONNode>.GetEnumerator(){} // RVA: 0x7FFAC896BB20
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC896BB20
}

public class <get_Children>d__23 : Object
{
    public int System.Collections.Generic.IEnumerator<OVRSimpleJSON.JSONNode>.Current; // 0x10
    public OVRSimpleJSON.JSONNode System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public OVRSimpleJSON.JSONObject <>4__this; // 0x28
    public Enumerator<string,OVRSimpleJSON.JSONNode> <>7__wrap1; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC896CD10
    public void MoveNext(){} // RVA: 0x7FFAC896CDD0
    public void <>m__Finally1(){} // RVA: 0x7FFAC896D0D0
    public void System.Collections.Generic.IEnumerator<OVRSimpleJSON.JSONNode>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC896D120
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<OVRSimpleJSON.JSONNode>.GetEnumerator(){} // RVA: 0x7FFAC896D160
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC896D160
}

public class <get_Children>d__40 : Object
{
    public int System.Collections.Generic.IEnumerator<OVRSimpleJSON.JSONNode>.Current; // 0x10
    public OVRSimpleJSON.JSONNode System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC439A2E0
    public void System.Collections.Generic.IEnumerator<OVRSimpleJSON.JSONNode>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC896A470
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<OVRSimpleJSON.JSONNode>.GetEnumerator(){} // RVA: 0x7FFAC896A4B0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC896A4B0
}

public class <get_Claims>d__51 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current; // 0x10
    public System.Security.Claims.Claim System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public System.Security.Claims.ClaimsIdentity <>4__this; // 0x28
    public int <i>5__2; // 0x30
    public System.Collections.Generic.IEnumerator`1<System.Security.Claims.Claim> <>7__wrap2; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC84561B0
    public void MoveNext(){} // RVA: 0x7FFAC8456270
    public void <>m__Finally1(){} // RVA: 0x7FFAC8456730
    public void System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8456790
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator(){} // RVA: 0x7FFAC84567D0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC84567D0
}

public class <get_Contents>d__70 : Object
{
    public int System.Collections.Generic.IEnumerator<VRC.Core.Networking.Pose.PoseContents>.Current; // 0x10
    public 0x6B204D20 System.Collections.IEnumerator.Current; // 0x14
    public int <>l__initialThreadId; // 0x18
    public VRC.Core.Networking.Pose.PoseEvent <>4__this; // 0x20
    public System.Collections.IEnumerator <>7__wrap1; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC53950A0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC9DE00A0
    public void MoveNext(){} // RVA: 0x7FFAC9DE0170
    public void <>m__Finally1(){} // RVA: 0x7FFAC9DE0520
    public void System.Collections.Generic.IEnumerator<VRC.Core.Networking.Pose.PoseContents>.get_Current(){} // RVA: 0x7FFAC33D5A20
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC9DE0590
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC9DE05D0
    public void System.Collections.Generic.IEnumerable<VRC.Core.Networking.Pose.PoseContents>.GetEnumerator(){} // RVA: 0x7FFAC9DE0620
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9DE0620
}

public class <get_DeepChildren>d__42 : Object
{
    public int System.Collections.Generic.IEnumerator<OVRSimpleJSON.JSONNode>.Current; // 0x10
    public OVRSimpleJSON.JSONNode System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public OVRSimpleJSON.JSONNode <>4__this; // 0x28
    public System.Collections.Generic.IEnumerator`1<OVRSimpleJSON.JSONNode> <>7__wrap1; // 0x30
    public System.Collections.Generic.IEnumerator`1<OVRSimpleJSON.JSONNode> <>7__wrap2; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC896A540
    public void MoveNext(){} // RVA: 0x7FFAC896A6A0
    public void <>m__Finally1(){} // RVA: 0x7FFAC896AB60
    public void <>m__Finally2(){} // RVA: 0x7FFAC896ABC0
    public void System.Collections.Generic.IEnumerator<OVRSimpleJSON.JSONNode>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC896AC20
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<OVRSimpleJSON.JSONNode>.GetEnumerator(){} // RVA: 0x7FFAC896AC60
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC896AC60
}

public class <get_Integrations>d__62 : Object
{
    public int System.Collections.Generic.IEnumerator<Sentry.Integrations.ISdkIntegration>.Current; // 0x10
    public Sentry.Integrations.ISdkIntegration System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public Sentry.SentryOptions <>4__this; // 0x28
    public Enumerator<Sentry.Integrations.ISdkIntegration> <>7__wrap1; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC8B45250
    public void MoveNext(){} // RVA: 0x7FFAC8B45310
    public void <>m__Finally1(){} // RVA: 0x7FFAC8B45900
    public void System.Collections.Generic.IEnumerator<Sentry.Integrations.ISdkIntegration>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8B45950
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<Sentry.Integrations.ISdkIntegration>.GetEnumerator(){} // RVA: 0x7FFAC8B45990
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8B45990
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
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void <>m__Finally1(){} // RVA: 0x7FFAC2C70980
    public void <>m__Finally2(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.Generic.IEnumerator<TKey>.get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.Generic.IEnumerable<TKey>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class <get_KnownLevels>d__10 : Object
{
    public int System.Collections.Generic.IEnumerator<System.ValueTuple<System.String,System.String>>.Current; // 0x10
    public System.ValueTuple`2<string,string> System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x28
    public Enumerator<string,CategoryPrefix> <>7__wrap1; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC39FB270
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFACBF2D8B0
    public void MoveNext(){} // RVA: 0x7FFACBF2D970
    public void <>m__Finally1(){} // RVA: 0x7FFACBF2DD30
    public void System.Collections.Generic.IEnumerator<System.ValueTuple<System.String,System.String>>.get_Current(){} // RVA: 0x7FFAC35D3330
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFACBF2DD80
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFACBF2DDC0
    public void System.Collections.Generic.IEnumerable<System.ValueTuple<System.String,System.String>>.GetEnumerator(){} // RVA: 0x7FFACBF2DE10
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACBF2DE10
}

public class <get_Values>d__27 : Object
{
    public int System.Collections.Generic.IEnumerator<TValue>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Immutable.ImmutableDictionary`2<U,T> <>4__this;
    public Enumerator<HashBucket<U,T>> <>7__wrap1;
    public Enumerator<U,T> <>7__wrap2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void <>m__Finally1(){} // RVA: 0x7FFAC2C70980
    public void <>m__Finally2(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.Generic.IEnumerator<TValue>.get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.Generic.IEnumerable<TValue>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class <get_bindings>d__9 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.Current; // 0x10
    public UnityEngine.InputSystem.InputBinding System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x70
    public UnityEngine.InputSystem.InputActionAsset <>4__this; // 0x78
    public int <numActionMaps>5__2; // 0x80
    public int <i>5__3; // 0x84
    public UnityEngine.InputSystem.InputBinding[] <bindings>5__4; // 0x88
    public int <numBindings>5__5; // 0x90
    public int <n>5__6; // 0x94

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9521630
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC9521650
    public void System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current(){} // RVA: 0x7FFAC4A24350
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC95218B0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC95218F0
    public void System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>.GetEnumerator(){} // RVA: 0x7FFAC9521970
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9521970
}

public class <get_controls>d__2 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.Current; // 0x10
    public PartBinding System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x28
    public UnityEngine.InputSystem.InputBindingCompositeContext <>4__this; // 0x30
    public UnityEngine.InputSystem.InputBindingCompositeContext <>3__<>4__this; // 0x40
    public int <totalBindingCount>5__2; // 0x50
    public int <bindingIndex>5__3; // 0x54
    public BindingState <bindingState>5__4; // 0x58
    public int <controlStartIndex>5__5; // 0x78
    public int <i>5__6; // 0x7C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC39FB270
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC9575E50
    public void System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.get_Current(){} // RVA: 0x7FFAC35D3330
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC9575FD0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC9576010
    public void System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.GetEnumerator(){} // RVA: 0x7FFAC9576060
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9576060
}

public class <get_outputs>d__16 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current; // 0x10
    public UnityEngine.Playables.PlayableBinding System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x38
    public UnityEngine.Timeline.AudioPlayableAsset <>4__this; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97AEE60
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC97C70F0
    public void System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current(){} // RVA: 0x7FFAC56EE570
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC97C71D0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC97C7210
    public void System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator(){} // RVA: 0x7FFAC97C7270
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC97C7270
}

public class <get_outputs>d__27 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current; // 0x10
    public UnityEngine.Playables.PlayableBinding System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x38
    public UnityEngine.Timeline.TimelineAsset <>4__this; // 0x40
    public System.Collections.Generic.IEnumerator`1<UnityEngine.Timeline.TrackAsset> <>7__wrap1; // 0x48
    public System.Collections.Generic.IEnumerator`1<UnityEngine.Playables.PlayableBinding> <>7__wrap2; // 0x50

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97AEE60
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC97BC710
    public void MoveNext(){} // RVA: 0x7FFAC97BC870
    public void <>m__Finally1(){} // RVA: 0x7FFAC97BCD40
    public void <>m__Finally2(){} // RVA: 0x7FFAC97BCDA0
    public void System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current(){} // RVA: 0x7FFAC56EE570
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC97BCE00
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC97BCE40
    public void System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator(){} // RVA: 0x7FFAC97BCEA0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC97BCEA0
}

public class <get_outputs>d__4 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current; // 0x10
    public UnityEngine.Playables.PlayableBinding System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x38
    public UnityEngine.Timeline.AudioTrack <>4__this; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97AEE60
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC97C70F0
    public void System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current(){} // RVA: 0x7FFAC56EE570
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC97C81D0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC97C8210
    public void System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator(){} // RVA: 0x7FFAC97C8270
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC97C8270
}

public class <get_outputs>d__45 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current; // 0x10
    public UnityEngine.Playables.PlayableBinding System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x38
    public UnityEngine.Timeline.AnimationPlayableAsset <>4__this; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97AEE60
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC97AEE80
    public void System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current(){} // RVA: 0x7FFAC56EE570
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC97AEF60
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC97AEFA0
    public void System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator(){} // RVA: 0x7FFAC97AF000
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC97AF000
}

public class <get_outputs>d__49 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current; // 0x10
    public UnityEngine.Playables.PlayableBinding System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x38
    public UnityEngine.Timeline.AnimationTrack <>4__this; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97AEE60
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC97AEE80
    public void System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current(){} // RVA: 0x7FFAC56EE570
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC97B4E10
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC97B4E50
    public void System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator(){} // RVA: 0x7FFAC97B4EB0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC97B4EB0
}

public class <get_outputs>d__69 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current; // 0x10
    public UnityEngine.Playables.PlayableBinding System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x38
    public UnityEngine.Timeline.TrackAsset <>4__this; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97AEE60
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC97C6270
    public void System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current(){} // RVA: 0x7FFAC56EE570
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC97C6550
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC97C6590
    public void System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator(){} // RVA: 0x7FFAC97C65F0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC97C65F0
}

public class <get_patterns>d__4 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current; // 0x10
    public System.Collections.Generic.KeyValuePair`2<string,object> System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x28
    public UnityEngine.InputSystem.Layouts.InputDeviceMatcher <>4__this; // 0x30
    public UnityEngine.InputSystem.Layouts.InputDeviceMatcher <>3__<>4__this; // 0x38
    public int <count>5__2; // 0x40
    public int <i>5__3; // 0x44

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC39FB270
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC955A8D0
    public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current(){} // RVA: 0x7FFAC35D3330
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC955AA90
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC955AAD0
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator(){} // RVA: 0x7FFAC955AB20
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC955AB20
}

public class <get_stylesheets>d__23 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.Current; // 0x10
    public UnityEngine.UIElements.StyleSheet System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public UnityEngine.UIElements.VisualTreeAsset <>4__this; // 0x28
    public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.StyleSheet> <sent>5__1; // 0x30
    public Enumerator<UnityEngine.UIElements.VisualElementAsset> <>s__2; // 0x38
    public UnityEngine.UIElements.VisualElementAsset <vea>5__3; // 0x50
    public Enumerator<UnityEngine.UIElements.StyleSheet> <>s__4; // 0x58
    public UnityEngine.UIElements.StyleSheet <stylesheet>5__5; // 0x70
    public Enumerator<string> <>s__6; // 0x78
    public string <stylesheetPath>5__7; // 0x90
    public UnityEngine.UIElements.StyleSheet <stylesheet>5__8; // 0x98

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC9ABB680
    public void MoveNext(){} // RVA: 0x7FFAC9ABB8A0
    public void <>m__Finally1(){} // RVA: 0x7FFAC9ABC630
    public void <>m__Finally2(){} // RVA: 0x7FFAC9ABC680
    public void <>m__Finally3(){} // RVA: 0x7FFAC9ABC6D0
    public void System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC9ABC720
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>.GetEnumerator(){} // RVA: 0x7FFAC9ABC760
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9ABC760
}

public class <get_templateDependencies>d__19 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.Current; // 0x10
    public UnityEngine.UIElements.VisualTreeAsset System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public UnityEngine.UIElements.VisualTreeAsset <>4__this; // 0x28
    public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualTreeAsset> <sent>5__1; // 0x30
    public Enumerator<UsingEntry> <>s__2; // 0x38
    public UsingEntry <entry>5__3; // 0x60
    public UnityEngine.UIElements.VisualTreeAsset <vta>5__4; // 0x78

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC9ABC830
    public void MoveNext(){} // RVA: 0x7FFAC9ABC8F0
    public void <>m__Finally1(){} // RVA: 0x7FFAC9ABD130
    public void System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC9ABD180
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>.GetEnumerator(){} // RVA: 0x7FFAC9ABD1C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9ABD1C0
}

public class <hashes>e__FixedBuffer : ValueType
{
    public int FixedElementField; // 0x10
}

public class <idBuffer>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <keys>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <layerCullDistances>e__FixedBuffer : ValueType
{
    public float FixedElementField; // 0x10
}

public class <m_CameraCullPlanes>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <m_Counters>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <m_CullingPlanes>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <m_LayerFarCullDistances>e__FixedBuffer : ValueType
{
    public float FixedElementField; // 0x10
}

public class <m_ShadowCullPlanes>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <m_StateWithControlIndex>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <m_StateWithoutControlIndex>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <m_ValueData>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <m_blocks>e__FixedBuffer : ValueType
{
    public uint FixedElementField; // 0x10
}

public class <nameBuffer>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <padding3>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <primaryTouchData>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <public_key_token>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <rawData>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <stateData>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <touchData>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <unknown1>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <unknown2>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class @
{
}
