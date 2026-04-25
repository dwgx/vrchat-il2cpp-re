// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 345

public class <ResetCoroutine>d__6 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public float delay; // 0x20
    public UnityStandardAssets.Utility.ObjectResetter <>4__this; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC2F26500
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2F26A90
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <ResetDrawAnim>d__49 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public Valve.VR.InteractionSystem.Longbow <>4__this; // 0x20
    public float <startTime>5__2; // 0x28
    public float <startLerp>5__3; // 0x2C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC8D0A050
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8D0A280
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <ResolveAsync>d__8 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<MeaMod.DNS.Model.Message> <>t__builder; // 0x18
    public MeaMod.DNS.Model.Message request; // 0x30
    public MeaMod.DNS.Server.NameServer <>4__this; // 0x38
    public <>c__DisplayClass8_0 <>8__1; // 0x40
    public System.Threading.CancellationToken cancel; // 0x48
    public Enumerator<MeaMod.DNS.Model.Question> <>7__wrap1; // 0x50
    public System.Runtime.CompilerServices.TaskAwaiter`1<MeaMod.DNS.Model.Message> <>u__1; // 0x68

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC823F3D0
    public void SetStateMachine(){} // RVA: 0x7FFAC82400A0
}

public class <ResolveAsync>d__9 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<MeaMod.DNS.Model.Message> <>t__builder; // 0x18
    public MeaMod.DNS.Model.Message response; // 0x30
    public MeaMod.DNS.Server.NameServer <>4__this; // 0x38
    public MeaMod.DNS.Model.Question question; // 0x40
    public System.Threading.CancellationToken cancel; // 0x48
    public MeaMod.DNS.Model.SOARecord <soa>5__2; // 0x50
    public System.Runtime.CompilerServices.TaskAwaiter`1<bool> <>u__1; // 0x58
    public MeaMod.DNS.Model.Message <res>5__3; // 0x60

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8240110
    public void SetStateMachine(){} // RVA: 0x7FFAC82408E0
}

public class <ReverseIterator>d__79`1 : Object
{
    public int System.Collections.Generic.IEnumerator<TSource>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<T> source;
    public System.Collections.Generic.IEnumerable`1<T> <>3__source;
    public System.Linq.Buffer`1<T> <buffer>5__2;
    public int <i>5__3;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void System.Collections.Generic.IEnumerator<TSource>.get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.Generic.IEnumerable<TSource>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class <RootNodeMiddleware>d__16 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Net.HttpListenerContext context; // 0x30
    public VRC.OSCQuery.OSCQueryHttpServer <>4__this; // 0x38
    public System.IO.StreamWriter <sw>5__2; // 0x40
    public System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC9D24940
    public void SetStateMachine(){} // RVA: 0x7FFAC9D25810
}

public class <Run>d__58 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
    public System.Net.WebOperation <>4__this; // 0x38
    public System.Net.WebRequestStream <requestStream>5__2; // 0x40
    public System.Net.WebResponseStream <stream>5__3; // 0x48
    public ConfiguredTaskAwaiter<System.Net.WebRequestStream> <>u__1; // 0x50
    public ConfiguredTaskAwaiter <>u__2; // 0x60

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC93182B0
    public void SetStateMachine(){} // RVA: 0x7FFAC360C270
}

public class <RunAsync>d__3 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> src;
    public System.Threading.CancellationToken cancellationToken;
    public System.IObserver`1<T> observer;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <RunLoopAsync>d__31 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Sentry.MetricAggregator <>4__this; // 0x30
    public System.Threading.CancellationTokenSource <shutdownTimeout>5__2; // 0x38
    public bool <shutdownRequested>5__3; // 0x40
    public int <>7__wrap3; // 0x44
    public ConfiguredTaskAwaiter <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8A49FF0
    public void SetStateMachine(){} // RVA: 0x7FFAC8A4AEC0
}

public class <RunOnThreadPool>d__100 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public bool configureAwait; // 0x30
    public System.Func`1<Cysharp.Threading.Tasks.UniTask> action; // 0x38
    public Awaiter <>u__1; // 0x40
    public object <>7__wrap1; // 0x48
    public int <>7__wrap2; // 0x50
    public Awaiter <>u__2; // 0x58
    public Awaiter <>u__3; // 0x68

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC9494AB0
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <RunOnThreadPool>d__101 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public bool configureAwait; // 0x30
    public System.Func`2<object,Cysharp.Threading.Tasks.UniTask> action; // 0x38
    public object state; // 0x40
    public Awaiter <>u__1; // 0x48
    public object <>7__wrap1; // 0x50
    public int <>7__wrap2; // 0x58
    public Awaiter <>u__2; // 0x60
    public Awaiter <>u__3; // 0x70

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC9495110
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <RunOnThreadPool>d__102`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public System.Threading.CancellationToken cancellationToken;
    public bool configureAwait;
    public System.Func`1<T> func;
    public Awaiter <>u__1;
    public object <>7__wrap1;
    public int <>7__wrap2;
    public T <>7__wrap3;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <RunOnThreadPool>d__103`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public System.Threading.CancellationToken cancellationToken;
    public bool configureAwait;
    public System.Func`1<Cysharp.Threading.Tasks.UniTask`1<T>> func;
    public Awaiter <>u__1;
    public object <>7__wrap1;
    public int <>7__wrap2;
    public T <>7__wrap3;
    public Awaiter<T> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <RunOnThreadPool>d__104`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public System.Threading.CancellationToken cancellationToken;
    public bool configureAwait;
    public System.Func`2<object,T> func;
    public object state;
    public Awaiter <>u__1;
    public object <>7__wrap1;
    public int <>7__wrap2;
    public T <>7__wrap3;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <RunOnThreadPool>d__105`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> <>t__builder;
    public System.Threading.CancellationToken cancellationToken;
    public bool configureAwait;
    public System.Func`2<object,Cysharp.Threading.Tasks.UniTask`1<T>> func;
    public object state;
    public Awaiter <>u__1;
    public object <>7__wrap1;
    public int <>7__wrap2;
    public T <>7__wrap3;
    public Awaiter<T> <>u__2;
    public Awaiter <>u__3;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <RunOnThreadPool>d__98 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public bool configureAwait; // 0x30
    public System.Action action; // 0x38
    public Awaiter <>u__1; // 0x40
    public object <>7__wrap1; // 0x48
    public int <>7__wrap2; // 0x50
    public Awaiter <>u__2; // 0x54

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC9495780
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <RunOnThreadPool>d__99 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public bool configureAwait; // 0x30
    public System.Action`1<object> action; // 0x38
    public object state; // 0x40
    public Awaiter <>u__1; // 0x48
    public object <>7__wrap1; // 0x50
    public int <>7__wrap2; // 0x58
    public Awaiter <>u__2; // 0x5C

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC9495B60
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <RunOther>d__17 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.UniTask other;
    public _TakeUntil<T> <>4__this;
    public Awaiter <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <RunOther>d__18 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.UniTask other;
    public _SkipUntil<T> <>4__this;
    public Awaiter <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <RunPerformanceScanEnumerator>d__0 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public IgnoreDelegate shouldIgnoreComponent; // 0x20
    public VRC.SDK3.Dynamics.Constraint.ConstraintsPerformanceScanner <>4__this; // 0x28
    public UnityEngine.GameObject avatarObject; // 0x30
    public <>c__DisplayClass0_0 <>8__1; // 0x38
    public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStats perfStats; // 0x40
    public System.Collections.Generic.List`1<UnityEngine.Animations.IConstraint> <engineConstraintBuffer>5__2; // 0x48
    public System.Collections.Generic.List`1<VRC.SDKBase.Validation.Performance.IVRCConstraint> <vrcConstraintBuffer>5__3; // 0x50

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFACC045950
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFACC045F10
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <RunPerformanceScanEnumerator>d__3 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public VRC.SDKBase.Validation.Performance.PerformanceScannerSet <>4__this; // 0x20
    public UnityEngine.GameObject avatarObject; // 0x28
    public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStats perfStats; // 0x30
    public IgnoreDelegate shouldIgnoreComponent; // 0x38
    public Enumerator<VRC.SDKBase.Validation.Performance.Scanners.AbstractPerformanceScanner> <>7__wrap1; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFACC087140
    public void MoveNext(){} // RVA: 0x7FFACC087200
    public void <>m__Finally1(){} // RVA: 0x7FFACC0874C0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFACC087510
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <RunPerformanceScanEnumerator>d__4 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public IgnoreDelegate shouldIgnoreComponent; // 0x20
    public VRC.SDKBase.Validation.Performance.Scanners.MeshPerformanceScanner <>4__this; // 0x28
    public UnityEngine.GameObject avatarObject; // 0x30
    public <>c__DisplayClass4_0 <>8__1; // 0x38
    public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStats perfStats; // 0x40
    public System.Collections.Generic.List`1<UnityEngine.Renderer> <rendererBuffer>5__2; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFACC098BD0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFACC0990A0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <RunScheduler>d__32 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Net.ServicePointScheduler <>4__this; // 0x30
    public System.ValueTuple`2<ConnectionGroup,System.Net.WebOperation>[] <operationArray>5__2; // 0x38
    public System.ValueTuple`3<ConnectionGroup,System.Net.WebConnection,System.Threading.Tasks.Task>[] <idleArray>5__3; // 0x40
    public System.Collections.Generic.List`1<System.Threading.Tasks.Task> <taskList>5__4; // 0x48
    public System.Threading.Tasks.Task`1<bool> <schedulerTask>5__5; // 0x50
    public bool <finalCleanup>5__6; // 0x58
    public ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1; // 0x60

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC930D160
    public void SetStateMachine(){} // RVA: 0x7FFAC930E4C0
}

public class <RunSecondAfterDisposeAsync>d__16 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public _Concat<T> <>4__this;
    public Awaiter <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <RunTask>d__5 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.UniTask`1<T> task;
    public AttachExternalCancellationSource`1<T> <>4__this;
    public Awaiter<T> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <RunTask>d__6 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x18
    public Cysharp.Threading.Tasks.UniTask task; // 0x20
    public ToCoroutineEnumerator <>4__this; // 0x30
    public Awaiter <>u__1; // 0x38

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC94A2890
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <RunTask>d__8 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.UniTask`1<T> task;
    public ToCoroutineEnumerator`1<T> <>4__this;
    public Awaiter<T> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <RunUdonEventOnMainThreadAndRemoveFromQueue>d__53 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public ImageDownloader <>4__this; // 0x28
    public string eventName; // 0x30
    public System.ValueTuple`2<string,object> argument; // 0x38
    public Awaiter <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFACC0090D0
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <RunWhenEachTask>d__11 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.UniTask`1<T> task;
    public Enumerator<T> self;
    public int length;
    public Awaiter<T> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <RunWithTimeoutWorker>d__241`1 : ValueType
{
    public int <>1__state;
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<T> <>t__builder;
    public System.Threading.Tasks.Task`1<T> workerTask;
    public int timeout;
    public System.Threading.CancellationTokenSource cts;
    public System.Action abort;
    public System.Func`1<bool> aborted;
    public ConfiguredTaskAwaiter<bool> <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <RunWriterTask>d__12 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
    public Cysharp.Threading.Tasks.UniTask task;
    public _Create<T> <>4__this;
    public Awaiter <>u__1;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <ScanAvatarForComponentsOfType>d__7 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public VRC.SDKBase.Validation.Performance.Scanners.AbstractPerformanceScanner <>4__this; // 0x20
    public System.Collections.Generic.List`1<UnityEngine.Component> destinationBuffer; // 0x28
    public UnityEngine.GameObject avatarObject; // 0x30
    public System.Type componentType; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFACC091AB0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFACC091C10
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <ScanAvatarForComponentsOfType>d__8`1 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current;
    public object System.Collections.IEnumerator.Current;
    public VRC.SDKBase.Validation.Performance.Scanners.AbstractPerformanceScanner <>4__this;
    public System.Collections.Generic.List`1<T> destinationBuffer;
    public UnityEngine.GameObject avatarObject;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
}

public class <ScopeId>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <Secret>e__FixedBuffer : ValueType
{
    public byte FixedElementField; // 0x10
}

public class <SelectIterator>d__5`2 : Object
{
    public int System.Collections.Generic.IEnumerator<TResult>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<U> source;
    public System.Collections.Generic.IEnumerable`1<U> <>3__source;
    public System.Func`3<U,int,T> selector;
    public System.Func`3<U,int,T> <>3__selector;
    public int <index>5__2;
    public System.Collections.Generic.IEnumerator`1<U> <>7__wrap2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void <>m__Finally1(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.Generic.IEnumerator<TResult>.get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.Generic.IEnumerable<TResult>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class <SelectManyIterator>d__17`2 : Object
{
    public int System.Collections.Generic.IEnumerator<TResult>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<U> source;
    public System.Collections.Generic.IEnumerable`1<U> <>3__source;
    public System.Func`2<U,System.Collections.Generic.IEnumerable`1<T>> selector;
    public System.Func`2<U,System.Collections.Generic.IEnumerable`1<T>> <>3__selector;
    public System.Collections.Generic.IEnumerator`1<U> <>7__wrap1;
    public System.Collections.Generic.IEnumerator`1<T> <>7__wrap2;

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

public class <SelectManyIterator>d__23`3 : Object
{
    public int System.Collections.Generic.IEnumerator<TResult>.Current;
    public T System.Collections.IEnumerator.Current;
    public int <>l__initialThreadId;
    public System.Collections.Generic.IEnumerable`1<U> source;
    public System.Collections.Generic.IEnumerable`1<U> <>3__source;
    public System.Func`2<U,System.Collections.Generic.IEnumerable`1<V>> collectionSelector;
    public System.Func`2<U,System.Collections.Generic.IEnumerable`1<V>> <>3__collectionSelector;
    public System.Func`3<U,V,T> resultSelector;
    public System.Func`3<U,V,T> <>3__resultSelector;
    public System.Collections.Generic.IEnumerator`1<U> <>7__wrap1;
    public U <element>5__3;
    public System.Collections.Generic.IEnumerator`1<V> <>7__wrap3;

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

public class <SendAsync>d__10 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Net.Http.HttpResponseMessage> <>t__builder; // 0x18
    public System.Net.Http.HttpRequestMessage request; // 0x30
    public Sentry.SentryMessageHandler <>4__this; // 0x38
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public string <method>5__2; // 0x48
    public string <url>5__3; // 0x50
    public Sentry.ISpan <span>5__4; // 0x58
    public ConfiguredTaskAwaiter<System.Net.Http.HttpResponseMessage> <>u__1; // 0x60

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8B3C050
    public void SetStateMachine(){} // RVA: 0x7FFAC8B3C720
}

public class <SendAsync>d__11 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public MeaMod.DNS.Multicast.MulticastClient <>4__this; // 0x30
    public byte[] message; // 0x38
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Net.IPAddress,System.Net.Sockets.UdpClient>> <>7__wrap1; // 0x40
    public ConfiguredTaskAwaiter<int> <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8244390
    public void SetStateMachine(){} // RVA: 0x7FFAC8244BC0
}

public class <SendAsync>d__3 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Net.Http.HttpResponseMessage> <>t__builder; // 0x18
    public System.Net.Http.HttpRequestMessage request; // 0x30
    public Sentry.Internal.Http.GzipBufferedRequestBodyHandler <>4__this; // 0x38
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public System.IO.MemoryStream <memoryStream>5__2; // 0x48
    public System.IO.Compression.GZipStream <>7__wrap2; // 0x50
    public ConfiguredTaskAwaiter <>u__1; // 0x58
    public ConfiguredTaskAwaiter<System.Net.Http.HttpResponseMessage> <>u__2; // 0x68

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8BBFF30
    public void SetStateMachine(){} // RVA: 0x7FFAC8BC09C0
}

public class <SendAsync>d__8 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Net.Http.HttpResponseMessage> <>t__builder; // 0x18
    public Sentry.Internal.Http.RetryAfterHandler <>4__this; // 0x30
    public System.Net.Http.HttpRequestMessage request; // 0x38
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public ConfiguredTaskAwaiter<System.Net.Http.HttpResponseMessage> <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8BC4830
    public void SetStateMachine(){} // RVA: 0x7FFAC8BC4C50
}

public class <SendAsync>d__99 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Net.Http.HttpResponseMessage> <>t__builder; // 0x18
    public System.Net.Http.MonoWebRequestHandler <>4__this; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public System.Net.Http.HttpRequestMessage request; // 0x40
    public System.Net.HttpWebRequest <wrequest>5__2; // 0x48
    public System.Net.HttpWebResponse <wresponse>5__3; // 0x50
    public System.Threading.CancellationTokenRegistration <>7__wrap3; // 0x58
    public System.Net.Http.HttpContent <content>5__5; // 0x70
    public ConfiguredTaskAwaiter <>u__1; // 0x78
    public System.IO.Stream <stream>5__6; // 0x88
    public ConfiguredTaskAwaiter<System.IO.Stream> <>u__2; // 0x90
    public ConfiguredTaskAwaiter<System.Net.WebResponse> <>u__3; // 0xA0
    public System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.Http.HttpResponseMessage> <>u__4; // 0xB0

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8F972B0
    public void SetStateMachine(){} // RVA: 0x7FFAC8F99650
}

public class <SendAsyncWorker>d__47 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Net.Http.HttpResponseMessage> <>t__builder; // 0x18
    public System.Net.Http.HttpClient <>4__this; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public System.Net.Http.HttpRequestMessage request; // 0x40
    public 0x6B2A2898 completionOption; // 0x48
    public System.Threading.CancellationTokenSource <lcts>5__2; // 0x50
    public System.Net.Http.HttpResponseMessage <response>5__3; // 0x58
    public ConfiguredTaskAwaiter<System.Net.Http.HttpResponseMessage> <>u__1; // 0x60
    public ConfiguredTaskAwaiter <>u__2; // 0x70

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8F9AAF0
    public void SetStateMachine(){} // RVA: 0x7FFAC8F9B400
}

public class <SendCloseFrameAsync>d__69 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public string closeStatusDescription; // 0x30
    public 0x6B142000 closeStatus; // 0x38
    public System.Net.WebSockets.ManagedWebSocket <>4__this; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public byte[] <buffer>5__2; // 0x50
    public ConfiguredValueTaskAwaiter <>u__1; // 0x58
    public ConfiguredTaskAwaiter <>u__2; // 0x68

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC93597F0
    public void SetStateMachine(){} // RVA: 0x7FFAC935A540
}

public class <SendEnvelopeAsync>d__2 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public Sentry.Unity.UnityWebRequestTransport <>4__this; // 0x20
    public Sentry.Protocol.Envelopes.Envelope envelope; // 0x28
    public Sentry.Protocol.Envelopes.Envelope <processedEnvelope>5__2; // 0x30
    public UnityEngine.Networking.UnityWebRequest <www>5__3; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC8B1B220
    public void MoveNext(){} // RVA: 0x7FFAC8B1B2E0
    public void <>m__Finally1(){} // RVA: 0x7FFAC8B1B7C0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8B1B820
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <SendEnvelopeAsync>d__3 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Sentry.Internal.Http.HttpTransport <>4__this; // 0x30
    public Sentry.Protocol.Envelopes.Envelope envelope; // 0x38
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public Sentry.Protocol.Envelopes.Envelope <processedEnvelope>5__2; // 0x48
    public System.Net.Http.HttpRequestMessage <request>5__3; // 0x50
    public System.Net.Http.HttpResponseMessage <response>5__4; // 0x58
    public ConfiguredTaskAwaiter<System.Net.Http.HttpResponseMessage> <>u__1; // 0x60
    public ConfiguredTaskAwaiter <>u__2; // 0x70

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8BC1C20
    public void SetStateMachine(){} // RVA: 0x7FFAC8BC2870
}

public class <SendEnvelopeAsync>d__32 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Sentry.Internal.Http.CachingTransport <>4__this; // 0x30
    public Sentry.Protocol.Envelopes.Envelope envelope; // 0x38
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public Sentry.Internal.ClientReport <clientReport>5__2; // 0x48
    public ConfiguredTaskAwaiter <>u__1; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8BBC960
    public void SetStateMachine(){} // RVA: 0x7FFAC8BBD090
}

public class <SendEnvelopeAsync>d__7 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Sentry.Http.SpotlightHttpTransport <>4__this; // 0x30
    public Sentry.Protocol.Envelopes.Envelope envelope; // 0x38
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public System.Threading.Tasks.Task <sentryTask>5__2; // 0x48
    public Sentry.Protocol.Envelopes.Envelope <processedEnvelope>5__3; // 0x50
    public System.Net.Http.HttpRequestMessage <request>5__4; // 0x58
    public System.Net.Http.HttpResponseMessage <response>5__5; // 0x60
    public ConfiguredTaskAwaiter<System.Net.Http.HttpResponseMessage> <>u__1; // 0x68
    public ConfiguredTaskAwaiter <>u__2; // 0x78

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8BDB100
    public void SetStateMachine(){} // RVA: 0x7FFAC8BDC080
}

public class <SendFinalClientReportAsync>d__23 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Sentry.Internal.BackgroundWorker <>4__this; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public Sentry.Protocol.Envelopes.Envelope <envelope>5__2; // 0x40
    public ConfiguredTaskAwaiter <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8B95460
    public void SetStateMachine(){} // RVA: 0x7FFAC8B95D10
}

public class <SendFrameFallbackAsync>d__56 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Net.WebSockets.ManagedWebSocket <>4__this; // 0x30
    public 0x6B141450 opcode; // 0x38
    public bool endOfMessage; // 0x39
    public System.ReadOnlyMemory`1<byte> payloadBuffer; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x50
    public ConfiguredTaskAwaiter <>u__1; // 0x58
    public System.Threading.CancellationTokenRegistration <>7__wrap1; // 0x68
    public ConfiguredValueTaskAwaiter <>u__2; // 0x80

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC9355F90
    public void SetStateMachine(){} // RVA: 0x7FFAC9356B70
}

public class <SendWithArrayPoolAsync>d__16 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.ReadOnlyMemory`1<byte> buffer; // 0x30
    public System.Net.WebSockets.WebSocket <>4__this; // 0x40
    public 0x6B142108 messageType; // 0x48
    public bool endOfMessage; // 0x4C
    public System.Threading.CancellationToken cancellationToken; // 0x50
    public byte[] <array>5__2; // 0x58
    public ConfiguredTaskAwaiter <>u__1; // 0x60

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC9364970
    public void SetStateMachine(){} // RVA: 0x7FFAC93650C0
}

public class <SequenceEqualAsync>d__0`1 : ValueType
{
    public int <>1__state;
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<bool> <>t__builder;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> first;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> second;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e1>5__2;
    public object <>7__wrap2;
    public int <>7__wrap3;
    public bool <>7__wrap4;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> <e2>5__6;
    public object <>7__wrap6;
    public int <>7__wrap7;
    public bool <>7__wrap8;
    public Awaiter<bool> <>u__1;
    public Awaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <SerializeAsync>d__14 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Sentry.Protocol.Envelopes.Envelope <>4__this; // 0x30
    public System.IO.Stream stream; // 0x38
    public Sentry.Extensibility.IDiagnosticLogger logger; // 0x40
    public Sentry.Infrastructure.ISystemClock clock; // 0x48
    public System.Threading.CancellationToken cancellationToken; // 0x50
    public ConfiguredTaskAwaiter <>u__1; // 0x58
    public System.Collections.Generic.IEnumerator`1<Sentry.Protocol.Envelopes.EnvelopeItem> <>7__wrap1; // 0x68

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8B83CD0
    public void SetStateMachine(){} // RVA: 0x7FFAC8B84B10
}

public class <SerializeAsync>d__21 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.IO.Stream stream; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public Sentry.Protocol.Metrics.Metric <>4__this; // 0x40
    public <>c__DisplayClass21_0 <>8__1; // 0x48
    public System.Collections.Generic.IDictionary`2<string,string> <tags>5__2; // 0x50
    public ConfiguredTaskAwaiter <>u__1; // 0x58
    public System.Runtime.CompilerServices.TaskAwaiter <>u__2; // 0x68
    public System.Collections.Generic.IEnumerator`1<System.IConvertible> <>7__wrap2; // 0x70
    public bool <first>5__4; // 0x78
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,string>> <>7__wrap4; // 0x80
    public string <key>5__6; // 0x88
    public string <value>5__7; // 0x90

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8B79D80
    public void SetStateMachine(){} // RVA: 0x7FFAC8B7BFF0
}

public class <SerializeAsync>d__31 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Sentry.Protocol.Envelopes.EnvelopeItem <>4__this; // 0x30
    public Sentry.Extensibility.IDiagnosticLogger logger; // 0x38
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public System.IO.Stream stream; // 0x48
    public System.IO.MemoryStream <payloadBuffer>5__2; // 0x50
    public ConfiguredTaskAwaiter<System.IO.MemoryStream> <>u__1; // 0x58
    public System.IO.MemoryStream <>7__wrap2; // 0x68
    public ConfiguredTaskAwaiter <>u__2; // 0x70

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8B8B330
    public void SetStateMachine(){} // RVA: 0x7FFAC8B8C0F0
}

public class <SerializeAsync>d__4 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.IO.Stream stream; // 0x30
    public Sentry.Protocol.Envelopes.JsonSerializable <>4__this; // 0x38
    public Sentry.Extensibility.IDiagnosticLogger logger; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public System.Runtime.CompilerServices.ConfiguredAsyncDisposable <>7__wrap1; // 0x50
    public object <>7__wrap2; // 0x60
    public int <>7__wrap3; // 0x68
    public ConfiguredTaskAwaiter <>u__1; // 0x70
    public ConfiguredValueTaskAwaiter <>u__2; // 0x80

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8B8CD30
    public void SetStateMachine(){} // RVA: 0x7FFAC8B8D4A0
}

public class <SerializeAsync>d__5 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Sentry.Protocol.Envelopes.AsyncJsonSerializable <>4__this; // 0x30
    public System.IO.Stream stream; // 0x38
    public Sentry.Extensibility.IDiagnosticLogger logger; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public ConfiguredTaskAwaiter<Sentry.ISentryJsonSerializable> <>u__1; // 0x50
    public System.Runtime.CompilerServices.ConfiguredAsyncDisposable <>7__wrap1; // 0x60
    public object <>7__wrap2; // 0x70
    public int <>7__wrap3; // 0x78
    public ConfiguredTaskAwaiter <>u__2; // 0x80
    public ConfiguredValueTaskAwaiter <>u__3; // 0x90

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8B7F370
    public void SetStateMachine(){} // RVA: 0x7FFAC8B7FCF0
}

public class <SerializeAsync>d__9 : ValueType
{
    public int <>1__state;
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
    public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<T> <>4__this;
    public T rootValue;
    public System.IO.Stream utf8Json;
    public System.Threading.CancellationToken cancellationToken;
    public object rootValueBoxed;
    public System.Text.Json.PooledByteBufferWriter <bufferWriter>5__2;
    public ConfiguredTaskAwaiter <>u__1;
    public bool <isFinalBlock>5__3;
    public System.Text.Json.WriteStack <state>5__4;
    public System.Text.Json.Utf8JsonWriter <writer>5__5;
    public object <>7__wrap5;
    public int <>7__wrap6;
    public object <>7__wrap7;
    public int <>7__wrap8;
    public ConfiguredValueTaskAwaiter <>u__2;

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <SerializeHeaderAsync>d__11 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.IO.Stream stream; // 0x30
    public Sentry.Protocol.Envelopes.Envelope <>4__this; // 0x38
    public Sentry.Infrastructure.ISystemClock clock; // 0x40
    public Sentry.Extensibility.IDiagnosticLogger logger; // 0x48
    public System.Threading.CancellationToken cancellationToken; // 0x50
    public System.Text.Json.Utf8JsonWriter <>7__wrap1; // 0x58
    public object <>7__wrap2; // 0x60
    public int <>7__wrap3; // 0x68
    public ConfiguredTaskAwaiter <>u__1; // 0x70
    public System.Runtime.CompilerServices.ValueTaskAwaiter <>u__2; // 0x80

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8B84B70
    public void SetStateMachine(){} // RVA: 0x7FFAC8B855A0
}

public class <SerializeHeaderAsync>d__29 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.IO.Stream stream; // 0x30
    public System.Collections.Generic.IReadOnlyDictionary`2<string,object> header; // 0x38
    public Sentry.Extensibility.IDiagnosticLogger logger; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public System.Runtime.CompilerServices.ConfiguredAsyncDisposable <>7__wrap1; // 0x50
    public object <>7__wrap2; // 0x60
    public int <>7__wrap3; // 0x68
    public ConfiguredTaskAwaiter <>u__1; // 0x70
    public ConfiguredValueTaskAwaiter <>u__2; // 0x80

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8B8C150
    public void SetStateMachine(){} // RVA: 0x7FFAC8B8C8C0
}

public class <SerializeToStreamAsync>d__4 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Sentry.Internal.Http.EnvelopeHttpContent <>4__this; // 0x30
    public System.IO.Stream stream; // 0x38
    public ConfiguredTaskAwaiter <>u__1; // 0x40

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8BBF480
    public void SetStateMachine(){} // RVA: 0x7FFAC8BBF7B0
}

public class <SerializeToStringAsync>d__0 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<string> <>t__builder; // 0x18
    public Sentry.Infrastructure.ISystemClock clock; // 0x30
    public Sentry.Protocol.Envelopes.ISerializable serializable; // 0x38
    public Sentry.Extensibility.IDiagnosticLogger logger; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public System.IO.MemoryStream <stream>5__2; // 0x50
    public System.IO.MemoryStream <>7__wrap2; // 0x58
    public System.IO.StreamReader <reader>5__4; // 0x60
    public ConfiguredTaskAwaiter <>u__1; // 0x68
    public ConfiguredTaskAwaiter<string> <>u__2; // 0x78

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8BB3950
    public void SetStateMachine(){} // RVA: 0x7FFAC8BB4500
}

public class <SerializedStatsdValues>d__27 : Object
{
    public int System.Collections.Generic.IEnumerator<System.IConvertible>.Current; // 0x10
    public System.IConvertible System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public Sentry.Protocol.Metrics.GaugeMetric <>4__this; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC8B78720
    public void System.Collections.Generic.IEnumerator<System.IConvertible>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8B78910
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<System.IConvertible>.GetEnumerator(){} // RVA: 0x7FFAC8B78950
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8B78950
}

public class <SerializedStatsdValues>d__8 : Object
{
    public int System.Collections.Generic.IEnumerator<System.IConvertible>.Current; // 0x10
    public System.IConvertible System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public Sentry.Protocol.Metrics.CounterMetric <>4__this; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC8B77D60
    public void System.Collections.Generic.IEnumerator<System.IConvertible>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8B77E40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<System.IConvertible>.GetEnumerator(){} // RVA: 0x7FFAC8B77E80
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8B77E80
}

public class <ServeStaticFile>d__7 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public string path; // 0x30
    public System.Net.HttpListenerContext context; // 0x38
    public string mimeType; // 0x40
    public System.IO.FileStream <targetFile>5__2; // 0x48
    public System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC9D20250
    public void SetStateMachine(){} // RVA: 0x7FFAC9D20A80
}

public class <SetHeadersAsync>d__37 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Net.WebRequestStream <>4__this; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public bool setInternalLength; // 0x40
    public ConfiguredTaskAwaiter <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC931D680
    public void SetStateMachine(){} // RVA: 0x7FFAC931DFB0
}

public class <SetModelAsync>d__29 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public Valve.VR.SteamVR_RenderModel <>4__this; // 0x20
    public string newRenderModelName; // 0x28
    public RenderModelInterfaceHolder <holder>5__2; // 0x30
    public Valve.VR.CVRRenderModels <renderModels>5__3; // 0x38
    public string[] <renderModelNames>5__4; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC8CB5E20
    public void MoveNext(){} // RVA: 0x7FFAC8CB5EE0
    public void <>m__Finally1(){} // RVA: 0x7FFAC8CB6BA0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8CB6C00
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <ShowPano>d__12 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public VRC.SDKBase.VRC_Panorama <>4__this; // 0x20
    public int index; // 0x28
    public UnityEngine.Networking.UnityWebRequest <unityWebRequest>5__2; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFACC064AC0
    public void MoveNext(){} // RVA: 0x7FFACC064B80
    public void <>m__Finally1(){} // RVA: 0x7FFACC065170
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFACC0651D0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

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
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
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
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
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
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
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
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <SkipAsync>d__1 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Newtonsoft.Json.JsonReader <>4__this; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public ConfiguredTaskAwaiter<bool> <>u__1; // 0x40
    public int <depth>5__2; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC86FA310
    public void SetStateMachine(){} // RVA: 0x7FFAC86FA860
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
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void <>m__Finally1(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.Generic.IEnumerator<T>.get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class <SkipNewlinesAsync>d__1 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.IO.Stream stream; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public Sentry.Internal.PooledBuffer`1<byte> <buffer>5__2; // 0x40
    public ConfiguredTaskAwaiter<int> <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8BD2510
    public void SetStateMachine(){} // RVA: 0x7FFAC8BD2B10
}

public class <SmoothActivate>d__21 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public RootMotion.Dynamics.BehaviourFall <>4__this; // 0x20
    public float <fader>5__2; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC2F81640
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2F81980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <SolveCaptcha>d__1 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder`1<bool> <>t__builder; // 0x18
    public string id; // 0x38
    public string solution; // 0x40
    public System.Runtime.CompilerServices.TaskAwaiter`1<bool> <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFACBF07F40
    public void SetStateMachine(){} // RVA: 0x7FFACBF08760
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
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}

public class <Split>d__9 : Object
{
    public int System.Collections.Generic.IEnumerator<System.String>.Current; // 0x10
    public string System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public string str; // 0x28
    public string <>3__str; // 0x30
    public System.Func`2<char,bool> predicate; // 0x38
    public System.Func`2<char,bool> <>3__predicate; // 0x40
    public int <length>5__2; // 0x48
    public int <position>5__3; // 0x4C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC9571A90
    public void System.Collections.Generic.IEnumerator<System.String>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC9571BE0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<System.String>.GetEnumerator(){} // RVA: 0x7FFAC9571C20
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9571C20
}

public class <SplitHeaderValue>d__11 : Object
{
    public string System.Collections.Generic.IEnumerator<System.String>.Current; // 0x10
    public int System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x1C
    public string value; // 0x20
    public string <>3__value; // 0x28
    public char[] separators; // 0x30
    public char[] <>3__separators; // 0x38
    public int <len>5__12; // 0x40
    public string <seps>5__13; // 0x48
    public System.Text.StringBuilder <buff>5__14; // 0x50
    public bool <escaped>5__15; // 0x58
    public bool <quoted>5__16; // 0x59
    public int <i>5__17; // 0x5C
    public char <c>5__18; // 0x60

    // ── Methods ──
    public void System.Collections.Generic.IEnumerable<System.String>.GetEnumerator(){} // RVA: 0x7FFACC0A4170
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACC0A4170
    public void MoveNext(){} // RVA: 0x7FFACC0A4300
    public void System.Collections.Generic.IEnumerator<System.String>.get_Current(){} // RVA: 0x7FFAC5CC4750
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFACC0A46C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC5CC4750
    public void .ctor(){} // RVA: 0x7FFACC0A4700
}

public class <StandardName>e__FixedBuffer : ValueType
{
    public char FixedElementField; // 0x10
}

public class <Start>d__1 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public UnityStandardAssets.Effects.ExplosionPhysicsForce <>4__this; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC2F2EF30
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2F2F5F0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <Start>d__2 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current;
    public object System.Collections.IEnumerator.Current;
    public T tweenInfo;
    public float <elapsedTime>5__2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
}

public class <Start>d__21 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public Valve.VR.InteractionSystem.ChaperoneInfo <>4__this; // 0x20
    public Valve.VR.CVRChaperone <chaperone>5__2; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC8D0CAB0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8D0CEB0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <Start>d__30 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public Valve.VR.InteractionSystem.Player <>4__this; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC8CE7AD0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8CE7CC0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <Start>d__4 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public UnityStandardAssets.Utility.ParticleSystemDestroyer <>4__this; // 0x20
    public UnityEngine.ParticleSystem[] <systems>5__2; // 0x28
    public float <stopTime>5__3; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC2F26BE0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2F27330
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <Start>d__6 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public UnityStandardAssets.Effects.ExplosionFireAndDebris <>4__this; // 0x20
    public float <multiplier>5__2; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC2F2E060
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2F2EE00
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <Start>d__87 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public Valve.VR.InteractionSystem.Hand <>4__this; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC8CD5070
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8CD5560
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <StartAtCorrectTime>d__32 : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public VRC.SDK3.StringLoading.VRCStringDownload <>4__this; // 0x30
    public Awaiter <>u__1; // 0x38

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFACC0016C0
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <StartAutoplayWithDuration>d__9 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public float duration; // 0x20
    public VRC.SDKBase.VRC_SlideShow <>4__this; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFACC058190
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFACC0582A0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <StartOperation>d__23 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<Mono.Net.Security.AsyncProtocolResult> <>t__builder; // 0x18
    public Mono.Net.Security.AsyncProtocolRequest <>4__this; // 0x30
    public System.Threading.CancellationToken cancellationToken; // 0x38
    public ConfiguredTaskAwaiter <>u__1; // 0x40

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8E1FC30
    public void SetStateMachine(){} // RVA: 0x7FFAC8E1FFD0
}

public class <StartOperation>d__57 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<int> <>t__builder; // 0x18
    public Mono.Net.Security.MobileAuthenticatedStream <>4__this; // 0x30
    public 0x6B12CB00 type; // 0x38
    public Mono.Net.Security.AsyncProtocolRequest asyncRequest; // 0x40
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public ConfiguredTaskAwaiter<Mono.Net.Security.AsyncProtocolResult> <>u__1; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8E267A0
    public void SetStateMachine(){} // RVA: 0x7FFAC8E273E0
}

public class <StartSkidTrail>d__20 : Object
{
    public int System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x10
    public object System.Collections.IEnumerator.Current; // 0x18
    public UnityStandardAssets.Vehicles.Car.WheelEffects <>4__this; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC2F487D0
    public void System.Collections.Generic.IEnumerator<System.Object>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2F48C10
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
}

public class <StoreToCacheAsync>d__30 : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Sentry.Internal.Http.CachingTransport <>4__this; // 0x30
    public Sentry.Protocol.Envelopes.Envelope envelope; // 0x38
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public string <envelopeFilePath>5__2; // 0x48
    public System.IDisposable <lockClaim>5__3; // 0x50
    public ConfiguredTaskAwaiter<System.IDisposable> <>u__1; // 0x58
    public System.IO.Stream <>7__wrap3; // 0x68
    public ConfiguredTaskAwaiter <>u__2; // 0x70

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8BBD0F0
    public void SetStateMachine(){} // RVA: 0x7FFAC8BBE0F0
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
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
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
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
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
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
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
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
}
