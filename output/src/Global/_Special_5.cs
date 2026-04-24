// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 442

public class <EveryNth>d__1`1 : Object
{
    public int System.Collections.Generic.IEnumerator<TValue>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<T> enumerable;
    public System.Collections.Generic.IEnumerable`1<T> <>3__enumerable;
    public int start;
    public int <>3__start;
    public int n;
    public int <>3__n;
    public int <index>5__2;
    public System.Collections.Generic.IEnumerator`1<T> <>7__wrap2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<TValue>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<TValue>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <ExceptIterator>d__77`1 : Object
{
    public int System.Collections.Generic.IEnumerator<TSource>.Current; // 0x10
    public VRC.Core.ApiWorldInstance System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public System.Collections.Generic.IEqualityComparer`1<VRC.Core.ApiWorldInstance> comparer; // 0x28
    public System.Collections.Generic.IEqualityComparer`1<VRC.Core.ApiWorldInstance> <>3__comparer; // 0x30
    public System.Collections.Generic.IEnumerable`1<VRC.Core.ApiWorldInstance> second; // 0x38
    public System.Collections.Generic.IEnumerable`1<VRC.Core.ApiWorldInstance> <>3__second; // 0x40
    public System.Collections.Generic.IEnumerable`1<VRC.Core.ApiWorldInstance> first; // 0x48
    public System.Collections.Generic.IEnumerable`1<VRC.Core.ApiWorldInstance> <>3__first; // 0x50
    public System.Linq.Set`1<VRC.Core.ApiWorldInstance> <set>5__2; // 0x58
    public System.Collections.Generic.IEnumerator`1<VRC.Core.ApiWorldInstance> <>7__wrap2; // 0x60

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

public class <ExtractFrameCoroutine>d__246 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public UnityEngine.Texture2D target; // 0x20
    public RenderHeads.Media.AVProVideo.MediaPlayer <>4__this; // 0x28
    public double timeSeconds; // 0x30
    public int timeThresholdMs; // 0x38
    public bool accurateSeek; // 0x3C
    public ProcessExtractedFrame callback; // 0x40
    public UnityEngine.Texture2D <result>5__2; // 0x48
    public int <currFc>5__3; // 0x50
    public int <iterations>5__4; // 0x54
    public int <maxIterations>5__5; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD4FBE2EE0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4FBE3580
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <FetchAsync>d__32`1 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<VRC.Core.ApiWorld,VRC.Core.ApiContainer>> <>t__builder; // 0x18
    public string id; // 0x30
    public bool disableCache; // 0x38
    public 0x664174C0 jobPriority; // 0x3C
    public System.Runtime.CompilerServices.TaskAwaiter`1<System.ValueTuple`2<VRC.Core.ApiWorld,VRC.Core.ApiContainer>> <>u__1; // 0x40

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <FetchAsync>d__56`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public VRC.Core.ApiModel <>4__this;
    public System.Collections.Generic.Dictionary`2<string,Token> parameters;
    public bool disableCache;
    public 0x664174C0 priority;
    public Awaiter<T> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <FinalRenderCapture>d__211 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public RenderHeads.Media.AVProVideo.MediaPlayer <>4__this; // 0x20
    public UnityEngine.YieldInstruction <wait>5__2; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD4FBE35C0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4FBE37F0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <FindComponentInPossibleClones>d__58 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.Component>.Current; // 0x10
    public UnityEngine.Component System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public UnityEngine.GameObject clonedRoot; // 0x28
    public UnityEngine.GameObject <>3__clonedRoot; // 0x30
    public UnityEngine.Component clonedComponent; // 0x38
    public UnityEngine.Component <>3__clonedComponent; // 0x40
    public UnityEngine.GameObject[] possibleClones; // 0x48
    public UnityEngine.GameObject[] <>3__possibleClones; // 0x50
    public UnityEngine.GameObject[] <>7__wrap1; // 0x58
    public int <>7__wrap2; // 0x60

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E69C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD57276770
    public void System.Collections.Generic.IEnumerator<UnityEngine.Component>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD57276B40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.Generic.IEnumerable<UnityEngine.Component>.GetEnumerator(){} // RVA: 0x7FFD57276B80
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD57276B80
}

public class <FinishWriteAsync>d__57 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task writeTask; // 0x30
    public byte[] localBuffer; // 0x38
    public 0x66436E68 <>u__1; // 0x40

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD53A0C210
    public void SetStateMachine(){} // RVA: 0x7FFD53A0C600
}

public class <Fire>d__3`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.UniTask`1<T> task;
    public Cysharp.Threading.Tasks.Internal.AsyncSubject`1<T> subject;
    public Awaiter<T> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <FirstAsync>d__0`1 : ValueType
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
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <FirstAsync>d__1`1 : ValueType
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
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <FirstAwaitAsync>d__2`1 : ValueType
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
    public T <v>5__6;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <FirstAwaitWithCancellationAsync>d__3`1 : ValueType
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
    public T <v>5__6;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <FlushAsyncInternal>d__74 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public bool haveWrittenPreamble; // 0x30
    public System.IO.StreamWriter _this; // 0x38
    public System.Text.Encoding encoding; // 0x40
    public System.IO.Stream stream; // 0x48
    public System.Threading.CancellationToken cancellationToken; // 0x50
    public System.Text.Encoder encoder; // 0x58
    public char[] charBuffer; // 0x60
    public int charPos; // 0x68
    public byte[] byteBuffer; // 0x70
    public bool flushEncoder; // 0x78
    public bool flushStream; // 0x79
    public 0x66436260 <>u__1; // 0x80
    public 0x66436E68 <>u__2; // 0x90

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD539EE1A0
    public void SetStateMachine(){} // RVA: 0x7FFD539EE9D0
}

public class <ForEachAsync>d__0`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Action`1<T> action;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ForEachAsync>d__1`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Action`2<T,int> action;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public int <index>5__5;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ForEachAwaitAsync>d__2`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask> action;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public Awaiter <>u__1;
    public Awaiter<bool> <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ForEachAwaitAsync>d__3`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,int,Cysharp.Threading.Tasks.UniTask> action;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public int <index>5__5;
    public Awaiter <>u__1;
    public Awaiter<bool> <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ForEachAwaitWithCancellationAsync>d__4`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask> action;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public Awaiter <>u__1;
    public Awaiter<bool> <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ForEachAwaitWithCancellationAsync>d__5`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`4<T,int,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask> action;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public int <index>5__5;
    public Awaiter <>u__1;
    public Awaiter<bool> <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <ForgetCoreWithCatch>d__21`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.UniTask`1<T> task;
    public bool handleExceptionOnMainThread;
    public System.Action`1<System.Exception> exceptionHandler;
    public object <>7__wrap1;
    public int <>7__wrap2;
    public Awaiter<T> <>u__1;
    public System.Exception <ex>5__4;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <GetAllItemIds>d__13 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Int32>.Current;
    public int System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<int> rootIds;
    public System.Collections.Generic.IEnumerable`1<int> <>3__rootIds;
    public UnityEngine.UIElements.TreeDataController`1<T> <>4__this;
    public System.Collections.Generic.IEnumerator`1<int> <currentIterator>5__1;
    public bool <hasNext>5__2;
    public int <currentItemId>5__3;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<System.Int32>.get_Current(){} // RVA: 0x7FFD4E079960
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <GetAllMembers>d__51`1 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Type type;
    public System.Type <>3__type;
    public 0x66438780 flags;
    public 0x66438780 <>3__flags;
    public System.Type <currentType>5__2;
    public System.Reflection.MemberInfo[] <>7__wrap2;
    public int <>7__wrap3;

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

public class <GetAllSceneObjects>d__86`1 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.Queue`1<UnityEngine.Transform> <queue>5__2;
    public UnityEngine.GameObject[] <>7__wrap2;
    public int <>7__wrap3;
    public System.Collections.IEnumerator <>7__wrap4;

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

public class <GetAllowedCodePoints>d__14 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Int32>.Current; // 0x10
    public int System.Collections.IEnumerator.Current; // 0x14
    public int <>l__initialThreadId; // 0x18
    public System.Text.Encodings.Web.TextEncoderSettings <>4__this; // 0x20
    public int <i>5__2; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD507B50A0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD53EA8F90
    public void System.Collections.Generic.IEnumerator<System.Int32>.get_Current(){} // RVA: 0x7FFD4E7F5A20
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD543F0950
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD543F0990
    public void System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator(){} // RVA: 0x7FFD543F09E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD543F09E0
}

public class <GetAsyncEnumerator>d__1 : Object
{
    public int System.Collections.Generic.IAsyncEnumerator<TElement>.Current;
    public System.Runtime.CompilerServices.AsyncIteratorMethodBuilder <>t__builder;
    public System.Threading.Tasks.Sources.ManualResetValueTaskSourceCore`1<bool> <>v__promiseOfValueOrEnd;
    public T <>2__current;
    public bool <>w__disposeMode;
    public BufferedAsyncEnumerable<U,T> <>4__this;
    public Enumerator<T> <>7__wrap1;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
    public void System.Collections.Generic.IAsyncEnumerator<TElement>.MoveNextAsync(){}
    public void System.Collections.Generic.IAsyncEnumerator<TElement>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Threading.Tasks.Sources.IValueTaskSource<System.Boolean>.GetResult(){} // RVA: 0x7FFD4E07AB80
    public void System.Threading.Tasks.Sources.IValueTaskSource<System.Boolean>.GetStatus(){}
    public void System.Threading.Tasks.Sources.IValueTaskSource<System.Boolean>.OnCompleted(){}
    public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void System.Threading.Tasks.Sources.IValueTaskSource.GetStatus(){}
    public void System.Threading.Tasks.Sources.IValueTaskSource.OnCompleted(){}
    public void System.IAsyncDisposable.DisposeAsync(){}
}

public class <GetAvailableLanguagesFile>d__2 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<string> <>t__builder; // 0x18
    public VRC.Localization.ResourcesLocalizationAssetSource <>4__this; // 0x30
    public Awaiter<string> <>u__1; // 0x38

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD5364F4D0
    public void SetStateMachine(){} // RVA: 0x7FFD5364F840
}

public class <GetBaseLayouts>d__24 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.Current; // 0x10
    public UnityEngine.InputSystem.Utilities.InternedString System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x28
    public bool includeSelf; // 0x2C
    public bool <>3__includeSelf; // 0x2D
    public UnityEngine.InputSystem.Utilities.InternedString layout; // 0x30
    public UnityEngine.InputSystem.Utilities.InternedString <>3__layout; // 0x40
    public Collection <>4__this; // 0x50
    public Collection <>3__<>4__this; // 0x90

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EE1B270
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD5496F7F0
    public void System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.get_Current(){} // RVA: 0x7FFD4E9F3330
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD5496F900
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD5496F940
    public void System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString>.GetEnumerator(){} // RVA: 0x7FFD5496F990
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD5496F990
}

public class <GetBestInstance>d__209 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<VRC.Core.ApiWorldInstance> <>t__builder; // 0x18
    public string forUserId; // 0x30
    public VRC.Core.ApiWorld <>4__this; // 0x38
    public System.Collections.Generic.List`1<string> locationsToIgnore; // 0x40
    public 0x66414FF8 accessType; // 0x48
    public 0x66415260 defaultRegion; // 0x4C
    public System.Collections.Generic.IEnumerator`1<VRC.Core.ApiWorldInstance> <>7__wrap1; // 0x50
    public Awaiter<VRC.Core.ApiWorldInstance> <>u__1; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD5731B9B0
    public void SetStateMachine(){} // RVA: 0x7FFD5731C4C0
}

public class <GetBestInstance>d__210 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<VRC.Core.ApiWorldInstance> <>t__builder; // 0x18
    public string forUserId; // 0x30
    public VRC.Core.ApiWorld <>4__this; // 0x38
    public System.Collections.Generic.List`1<string> locationsToIgnore; // 0x40
    public bool includePublicInstancesOnly; // 0x48
    public bool excludePublicInstances; // 0x49
    public 0x66415260 defaultRegion; // 0x4C
    public System.Collections.Generic.IEnumerator`1<VRC.Core.ApiWorldInstance> <>7__wrap1; // 0x50
    public Awaiter<VRC.Core.ApiWorldInstance> <>u__1; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD5731C4F0
    public void SetStateMachine(){} // RVA: 0x7FFD5731D210
}

public class <GetCacheSizeInfo>d__4 : Object
{
    public int System.Collections.Generic.IEnumerator<(System.Type,System.Int32)>.Current; // 0x10
    public System.ValueTuple`2<System.Type,int> System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x28
    public System.Collections.Generic.Dictionary`2<System.Type,System.Func`1<int>> <>7__wrap1; // 0x30
    public bool <>7__wrap2; // 0x38
    public Enumerator<System.Type,System.Func`1<int>> <>7__wrap3; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EE1B270
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD548A5D60
    public void MoveNext(){} // RVA: 0x7FFD548A5ED0
    public void <>m__Finally1(){} // RVA: 0x7FFD4EE1A600
    public void <>m__Finally2(){} // RVA: 0x7FFD548A6470
    public void System.Collections.Generic.IEnumerator<(System.Type,System.Int32)>.get_Current(){} // RVA: 0x7FFD4E9F3330
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD548A64C0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD548A6500
    public void System.Collections.Generic.IEnumerable<(System.Type,System.Int32)>.GetEnumerator(){} // RVA: 0x7FFD548A6550
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD548A6550
}

public class <GetChains>d__58 : Object
{
    public int System.Collections.Generic.IEnumerator<(System.Int32chainIndex,VRC.Dynamics.PhysBoneManager.Chainchain)>.Current; // 0x10
    public System.ValueTuple`2<int,Chain> System.Collections.IEnumerator.Current; // 0x18
    public VRC.Dynamics.PhysBoneManager <>4__this; // 0x100
    public int <i>5__2; // 0x108

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD5526F0D0
    public void System.Collections.Generic.IEnumerator<(System.Int32chainIndex,VRC.Dynamics.PhysBoneManager.Chainchain)>.get_Current(){} // RVA: 0x7FFD5526F340
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD5526F3E0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD5526F420
}

public class <GetCustomAttributes>d__64`1 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Type type;
    public System.Type <>3__type;
    public bool inherit;
    public bool <>3__inherit;
    public object[] <attrs>5__2;
    public int <i>5__3;

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

public class <GetDeclaredMethods>d__10 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo>.Current; // 0x10
    public System.Reflection.MethodInfo System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public System.Reflection.TypeInfo <>4__this; // 0x28
    public string name; // 0x30
    public string <>3__name; // 0x38
    public System.Reflection.MethodInfo[] <>7__wrap1; // 0x40
    public int <>7__wrap2; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E69C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD539468A0
    public void System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD53946A90
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>.GetEnumerator(){} // RVA: 0x7FFD53946AD0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD53946AD0
}

public class <GetDescendants>d__23`1 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement>.Current;
    public ÍÌÎÎÌÎÎÌÍÏÏÏÍÍÌÍÎ.ÎÌÍÎÎÏÏÍÍÍÍÌÍÍ System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<T> source;
    public System.Collections.Generic.IEnumerable`1<T> <>3__source;
    public bool self;
    public bool <>3__self;
    public ÍÌÎÎÌÎÎÌÍÏÏÏÍÍÌÍÎ.Ì name;
    public ÍÌÎÎÌÎÎÌÍÏÏÏÍÍÌÍÎ.Ì <>3__name;
    public System.Collections.Generic.IEnumerator`1<T> <>7__wrap1;
    public System.Xml.Linq.XContainer <root>5__3;
    public System.Xml.Linq.XNode <n>5__4;
    public ÍÌÎÎÌÎÎÌÍÏÏÏÍÍÌÍÎ.ÎÌÍÎÎÏÏÍÍÍÍÌÍÍ <e>5__5;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement>.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__1 : Object
{
    public int System.Collections.Generic.IEnumerator<TElement>.Current; // 0x10
    public System.Collections.Generic.KeyValuePair`2<int,byte[]> System.Collections.IEnumerator.Current; // 0x18
    public System.Linq.OrderedEnumerable`1<System.Collections.Generic.KeyValuePair`2<int,byte[]>> <>4__this; // 0x28
    public System.Linq.Buffer`1<System.Collections.Generic.KeyValuePair`2<int,byte[]>> <buffer>5__2; // 0x30
    public int[] <map>5__3; // 0x40
    public int <i>5__4; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<TElement>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__11 : Object
{
    public int System.Collections.Generic.IEnumerator<System.String>.Current;
    public System.Collections.Generic.KeyValuePair`2<string,object> System.Collections.IEnumerator.Current;
    public LogValues`3<U,V,T> <>4__this;
    public int <i>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<System.String>.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__12 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.Current; // 0x10
    public System.Linq.IGrouping`2<string,0x66414C30> System.Collections.IEnumerator.Current; // 0x18
    public System.Linq.Lookup`2<string,0x66414C30> <>4__this; // 0x20
    public Grouping<string,0x66414C30> <g>5__2; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__13 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current; // 0x10
    public System.Collections.Generic.KeyValuePair`2<string,int> System.Collections.IEnumerator.Current; // 0x18
    public FillCollection`1<System.Collections.Generic.KeyValuePair`2<string,int>> <>4__this; // 0x28
    public int <i>5__2; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<T>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__14 : Object
{
    public int System.Collections.Generic.IEnumerator<System.String>.Current;
    public System.Collections.Generic.KeyValuePair`2<string,object> System.Collections.IEnumerator.Current;
    public LogValues`5<U,V,W,T4,T> <>4__this;
    public int <i>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<System.String>.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__15 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current; // 0x10
    public ZLogger.IZLoggerEntry System.Collections.IEnumerator.Current; // 0x18
    public System.Collections.Concurrent.SingleProducerSingleConsumerQueue`1<ZLogger.IZLoggerEntry> <>4__this; // 0x20
    public Segment<ZLogger.IZLoggerEntry> <segment>5__2; // 0x28
    public int <pt>5__3; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<T>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__18 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,T>>.Current;
    public System.Collections.Generic.KeyValuePair`2<string,T> System.Collections.IEnumerator.Current;
    public System.Text.Json.JsonPropertyDictionary`1<T> <>4__this;
    public Enumerator<System.Collections.Generic.KeyValuePair`2<string,T>> <>7__wrap1;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,T>>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__2 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Current;
    public System.Collections.Generic.KeyValuePair`2<object,object> System.Collections.IEnumerator.Current;
    public EnumerableDictionaryWrapper`2<U,T> <>4__this;
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<U,T>> <>7__wrap1;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current(){} // RVA: 0x7FFD4E0788A0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__20 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current;
    public T System.Collections.IEnumerator.Current;
    public ZLinq.Linq.Grouping`2<U,T> <>4__this;
    public int <i>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<T>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__28 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current;
    public T System.Collections.IEnumerator.Current;
    public Google.Protobuf.Collections.RepeatedField`1<T> <>4__this;
    public int <i>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<T>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__3 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,BestHTTP.JSON.Json.Token>>.Current; // 0x10
    public System.Collections.Generic.KeyValuePair`2<string,Token> System.Collections.IEnumerator.Current; // 0x18
    public DictionaryWrapper`1<Token> <>4__this; // 0x38
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,Token>> <>7__wrap1; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,BestHTTP.JSON.Json.Token>>.get_Current(){}
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__32 : Object
{
    public int System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.Current; // 0x10
    public UnityEngine.InputSystem.InputAction System.Collections.IEnumerator.Current; // 0x18
    public UnityEngine.InputSystem.InputActionAsset <>4__this; // 0x20
    public int <i>5__2; // 0x28
    public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputAction> <actions>5__3; // 0x30
    public int <actionCount>5__4; // 0x40
    public int <n>5__5; // 0x44

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD54941450
    public void System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD549415F0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <GetEnumerator>d__35 : Object
{
    public int <>1__state; // 0x10
    public System.Collections.Generic.KeyValuePair`2<System.Type,{> <>2__current; // 0x18
    public System.Collections.Concurrent.ConcurrentDictionary`2<System.Type,{> <>4__this; // 0x28
    public Node<System.Type,{>[] <buckets>5__2; // 0x30
    public int <i>5__3; // 0x38
    public Node<System.Type,{> <current>5__4; // 0x40
}

public class <GetEnumerator>d__50 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current;
    public T System.Collections.IEnumerator.Current;
    public Builder<T> <>4__this;
    public int <i>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<T>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__7 : Object
{
    public int System.Collections.Generic.IEnumerator<BestHTTP.JSON.Json.Token>.Current; // 0x10
    public 0x66414C30 System.Collections.IEnumerator.Current; // 0x18
    public Grouping<string,0x66414C30> <>4__this; // 0x20
    public int <i>5__2; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<BestHTTP.JSON.Json.Token>.get_Current(){} // RVA: 0x7FFD4E0788A0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__8 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current;
    public System.Collections.Generic.KeyValuePair`2<string,object> System.Collections.IEnumerator.Current;
    public LogValues`1<T> <>4__this;
    public int <i>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current(){} // RVA: 0x7FFD4E0788A0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumerator>d__9 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current;
    public System.Collections.Generic.KeyValuePair`2<string,object> System.Collections.IEnumerator.Current;
    public LogValues`2<U,T> <>4__this;
    public int <i>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current(){} // RVA: 0x7FFD4E0788A0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumeratorImpl>d__19 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current;
    public T System.Collections.IEnumerator.Current;
    public MeaMod.DNS.Server.ConcurrentSet`1<T> <>4__this;
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<T,byte>> <>7__wrap1;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<T>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetEnumeratorWorker>d__7 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current;
    public System.Collections.Generic.KeyValuePair`2<U,U> System.Collections.IEnumerator.Current;
    public System.Linq.Expressions.Interpreter.HybridReferenceDictionary`2<U,U> <>4__this;
    public int <i>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
}

public class <GetGrabs>d__152 : Object
{
    public int System.Collections.Generic.IEnumerator<VRC.Dynamics.PhysBoneManager.Grab>.Current; // 0x10
    public Grab System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public VRC.Dynamics.PhysBoneManager <>4__this; // 0x28
    public int <i>5__2; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E69C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD5526F500
    public void System.Collections.Generic.IEnumerator<VRC.Dynamics.PhysBoneManager.Grab>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD5526F620
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.Generic.IEnumerable<VRC.Dynamics.PhysBoneManager.Grab>.GetEnumerator(){} // RVA: 0x7FFD5526F660
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD5526F660
}

public class <GetItemIds>d__9 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Int32>.Current;
    public int System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.TreeViewItemData`1<T>> items;
    public System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.TreeViewItemData`1<T>> <>3__items;
    public System.Collections.Generic.IEnumerator`1<UnityEngine.UIElements.TreeViewItemData`1<T>> <>s__1;
    public UnityEngine.UIElements.TreeViewItemData`1<T> <item>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void <>m__Finally1(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.IEnumerator<System.Int32>.get_Current(){} // RVA: 0x7FFD4E079960
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class <GetLanguageFiles>d__4 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.IReadOnlyList`1<System.ValueTuple`3<string,string,string>>> <>t__builder; // 0x18
    public VRC.Localization.ResourcesLocalizationAssetSource <>4__this; // 0x30
    public string language; // 0x38
    public System.Collections.Generic.List`1<System.ValueTuple`3<string,string,string>> <files>5__2; // 0x40
    public string[] <>7__wrap2; // 0x48
    public int <>7__wrap3; // 0x50
    public string <groupFolder>5__5; // 0x58
    public string <keys>5__6; // 0x60
    public Awaiter<string> <>u__1; // 0x68

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD5364F870
    public void SetStateMachine(){} // RVA: 0x7FFD53650210
}

public class <GetPartNames>d__12 : Object
{
    public int System.Collections.Generic.IEnumerator<System.String>.Current; // 0x10
    public string System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public string composite; // 0x28
    public string <>3__composite; // 0x30
    public System.Reflection.FieldInfo[] <>7__wrap1; // 0x38
    public int <>7__wrap2; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E69C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD54995580
    public void System.Collections.Generic.IEnumerator<System.String>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD549957B0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.Generic.IEnumerable<System.String>.GetEnumerator(){} // RVA: 0x7FFD549957F0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD549957F0
}

public class <GetShapeData>d__11 : Object
{
    public int System.Collections.Generic.IEnumerator<VRC.Dynamics.CollisionScene.ShapeData>.Current; // 0x10
    public ShapeData System.Collections.IEnumerator.Current; // 0x14
    public VRC.Dynamics.CollisionScene <>4__this; // 0xE0
    public int <i>5__2; // 0xE8

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD5521D980
    public void System.Collections.Generic.IEnumerator<VRC.Dynamics.CollisionScene.ShapeData>.get_Current(){} // RVA: 0x7FFD50CD92B0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD5521DBA0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD5521DBE0
}

public class <GetValues>d__9`1 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Text.Json.Nodes.JsonArray <>4__this;
    public Enumerator<System.Text.Json.Nodes.JsonNode> <>7__wrap1;

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

public class <IgnoreExceptions>d__1`2 : Object
{
    public int System.Collections.Generic.IEnumerator<T>.Current;
    public U System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<U> enumerable;
    public System.Collections.Generic.IEnumerable`1<U> <>3__enumerable;
    public System.Action`1<T> onException;
    public System.Action`1<T> <>3__onException;
    public System.Collections.Generic.IEnumerator`1<U> <enumerator>5__2;
    public bool <hasNext>5__3;

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

public class <InitializeLoader>d__24 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public UnityEngine.XR.Management.XRManagerSettings <>4__this; // 0x20
    public Enumerator<UnityEngine.XR.Management.XRLoader> <>7__wrap1; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD54C059C0
    public void MoveNext(){} // RVA: 0x7FFD54C05A80
    public void <>m__Finally1(){} // RVA: 0x7FFD54C05F60
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD54C05FB0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <InitializeProjectConfigAsync>d__52 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Unity.Services.Core.Registration.CorePackageInitializer <>4__this; // 0x30
    public Unity.Services.Core.InitializationOptions options; // 0x38
    public System.Runtime.CompilerServices.TaskAwaiter`1<Unity.Services.Core.Configuration.ProjectConfiguration> <>u__1; // 0x40

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD54B1D3A0
    public void SetStateMachine(){} // RVA: 0x7FFD54B1D830
}

public class <IntersectIterator>d__74`1 : Object
{
    public int System.Collections.Generic.IEnumerator<TSource>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public System.Collections.Generic.IEqualityComparer`1<T> <>3__comparer;
    public System.Collections.Generic.IEnumerable`1<T> second;
    public System.Collections.Generic.IEnumerable`1<T> <>3__second;
    public System.Collections.Generic.IEnumerable`1<T> first;
    public System.Collections.Generic.IEnumerable`1<T> <>3__first;
    public System.Linq.Set`1<T> <set>5__2;
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

public class <LastAsync>d__0`1 : ValueType
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
    public T <value>5__6;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <LastAsync>d__1`1 : ValueType
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

public class <LastAwaitAsync>d__2`1 : ValueType
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

public class <LastAwaitWithCancellationAsync>d__3`1 : ValueType
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

public class <ListControlLayouts>d__97 : Object
{
    public int System.Collections.Generic.IEnumerator<System.String>.Current; // 0x10
    public string System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public string basedOn; // 0x28
    public string <>3__basedOn; // 0x30
    public UnityEngine.InputSystem.InputManager <>4__this; // 0x38
    public UnityEngine.InputSystem.Utilities.InternedString <internedBasedOn>5__2; // 0x40
    public Enumerator<UnityEngine.InputSystem.Utilities.InternedString,System.Type> <>7__wrap2; // 0x50
    public Enumerator<UnityEngine.InputSystem.Utilities.InternedString,string> <>7__wrap3; // 0x80
    public Enumerator<UnityEngine.InputSystem.Utilities.InternedString,System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>> <>7__wrap4; // 0xB0

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E69C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD54A3E550
    public void MoveNext(){} // RVA: 0x7FFD54A3E990
    public void <>m__Finally1(){} // RVA: 0x7FFD54A3F780
    public void <>m__Finally2(){} // RVA: 0x7FFD54A3F7D0
    public void <>m__Finally3(){} // RVA: 0x7FFD54A3F820
    public void <>m__Finally4(){} // RVA: 0x7FFD54A3F870
    public void <>m__Finally5(){} // RVA: 0x7FFD54A3F8C0
    public void <>m__Finally6(){} // RVA: 0x7FFD54A3F910
    public void System.Collections.Generic.IEnumerator<System.String>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD54A3F960
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.Generic.IEnumerable<System.String>.GetEnumerator(){} // RVA: 0x7FFD54A3F9A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD54A3F9A0
}

public class <LoadAssetLanguage>d__34 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public VRC.Localization.LocalizationAssetSource localizationAssetSource; // 0x28
    public VRC.Localization.LocalizationDatabase <>4__this; // 0x30
    public Awaiter<System.Collections.Generic.IReadOnlyList`1<System.ValueTuple`3<string,string,string>>> <>u__1; // 0x38

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD53652BC0
    public void SetStateMachine(){} // RVA: 0x7FFD4E341310
}

public class <LoadAvailableLanguages>d__35 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public VRC.Localization.LocalizationAssetSource localizationAssetSource; // 0x28
    public VRC.Localization.LocalizationDatabase <>4__this; // 0x30
    public Awaiter<string> <>u__1; // 0x38

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD53653120
    public void SetStateMachine(){} // RVA: 0x7FFD4E341310
}

public class <LoadDefaultAssets>d__30 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x18
    public VRC.Localization.LocalizationDatabase <>4__this; // 0x20
    public Awaiter <>u__1; // 0x28

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD536536A0
    public void SetStateMachine(){} // RVA: 0x7FFD4E341310
}

public class <LoadLanguage>d__31 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public string language; // 0x28
    public VRC.Localization.LocalizationDatabase <>4__this; // 0x30
    public bool isRTL; // 0x38
    public Enumerator<VRC.Localization.LocalizationAssetSource> <>7__wrap1; // 0x40
    public Awaiter <>u__1; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD53653980
    public void SetStateMachine(){} // RVA: 0x7FFD4E341310
}

public class <LoadSubtitlesCoroutine>d__286 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public string url; // 0x20
    public RenderHeads.Media.AVProVideo.MediaPlayer <>4__this; // 0x28
    public 0x665D4AB0 mediaPath; // 0x30
    public UnityEngine.Networking.UnityWebRequest <www>5__2; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3440C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFD4E341310
    public void MoveNext(){} // RVA: 0x7FFD4FBE3830
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFD4E3447C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4FBE3BC0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E3447C0
}

public class <LongCountAsync>d__0`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<long> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public long <count>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <LongCountAsync>d__1`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<long> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,bool> predicate;
    public long <count>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <LongCountAwaitAsync>d__2`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<long> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;
    public long <count>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <LongCountAwaitWithCancellationAsync>d__3`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<long> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;
    public long <count>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <LoopClientAsync>d__22 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
    public System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4FFEE0C0
    public void SetStateMachine(){} // RVA: 0x7FFD4EA2C270
}

public class <MaxAsync>d__0`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public T <value>5__2;
    public System.Collections.Generic.Comparer`1<T> <comparer>5__3;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__4;
    public object <>7__wrap4;
    public int <>7__wrap5;
    public T <>7__wrap6;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAsync>d__13`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<float> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,float> selector;
    public float <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAsync>d__17`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<double> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,double> selector;
    public double <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAsync>d__1`2 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<U,T> selector;
    public T <value>5__2;
    public System.Collections.Generic.Comparer`1<T> <comparer>5__3;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__4;
    public object <>7__wrap4;
    public int <>7__wrap5;
    public T <>7__wrap6;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAsync>d__21`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Decimal> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,System.Decimal> selector;
    public System.Decimal <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAsync>d__25`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<int>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,System.Nullable`1<int>> selector;
    public System.Nullable`1<int> <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<int> <>7__wrap5;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAsync>d__29`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<long>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,System.Nullable`1<long>> selector;
    public System.Nullable`1<long> <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<long> <>7__wrap5;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAsync>d__33`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<float>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,System.Nullable`1<float>> selector;
    public System.Nullable`1<float> <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<float> <>7__wrap5;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAsync>d__37`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<double>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,System.Nullable`1<double>> selector;
    public System.Nullable`1<double> <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<double> <>7__wrap5;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAsync>d__41`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<System.Decimal>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,System.Nullable`1<System.Decimal>> selector;
    public System.Nullable`1<System.Decimal> <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public System.Nullable`1<System.Decimal> <>7__wrap5;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAsync>d__5`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<int> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,int> selector;
    public int <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAsync>d__9`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<long> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,long> selector;
    public long <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAwaitAsync>d__10`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<long> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<long>> selector;
    public long <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<long> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAwaitAsync>d__14`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<float> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<float>> selector;
    public float <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<float> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAwaitAsync>d__18`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<double> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<double>> selector;
    public double <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<double> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAwaitAsync>d__22`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Decimal> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<System.Decimal>> selector;
    public System.Decimal <value>5__2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__3;
    public object <>7__wrap3;
    public int <>7__wrap4;
    public Awaiter<System.Decimal> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAwaitAsync>d__26`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<int>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<int>>> selector;
    public System.Nullable`1<int> <value>5__2;
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

public class <MaxAwaitAsync>d__2`2 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<T>> selector;
    public T <value>5__2;
    public System.Collections.Generic.Comparer`1<T> <comparer>5__3;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> <e>5__4;
    public object <>7__wrap4;
    public int <>7__wrap5;
    public T <>7__wrap6;
    public Awaiter<T> <>u__1;
    public Awaiter<bool> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
}

public class <MaxAwaitAsync>d__30`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<long>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<long>>> selector;
    public System.Nullable`1<long> <value>5__2;
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

public class <MaxAwaitAsync>d__34`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<float>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<float>>> selector;
    public System.Nullable`1<float> <value>5__2;
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

public class <MaxAwaitAsync>d__38`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Nullable`1<double>> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<System.Nullable`1<double>>> selector;
    public System.Nullable`1<double> <value>5__2;
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
