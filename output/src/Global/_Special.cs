// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 382

public class $ArrayType$131 : ValueType
{
}

public class $ArrayType$195 : ValueType
{
}

public class $ArrayType$67 : ValueType
{
}

public class $BurstDirectCallInitializer : Object
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFAC950E2D0
}

public class <<CreateNewInstance>g__asyncHelper|0>d : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass212_0 <>4__this; // 0x20
    public object <>7__wrap1; // 0x28
    public int <>7__wrap2; // 0x30
    public VRC.Core.ApiWorldInstance <instance>5__4; // 0x38
    public Awaiter<VRC.Core.ApiWorldInstance> <>u__1; // 0x40
    public Awaiter <>u__2; // 0x58
    public System.Exception <e>5__5; // 0x68

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFACBEFA890
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <<CreateOrFetch>g__asyncHelper|0>d : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass167_0 <>4__this; // 0x20
    public object <>7__wrap1; // 0x28
    public int <>7__wrap2; // 0x30
    public VRC.Core.ApiWorldInstance <instance>5__4; // 0x38
    public Awaiter<VRC.Core.ApiWorldInstance> <>u__1; // 0x40
    public Awaiter <>u__2; // 0x58
    public System.Exception <e>5__5; // 0x68

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFACBF01BE0
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <<DeserializeAsyncEnumerableCore>g__CreateAsyncEnumerable|90_0>d`1 : Object
{
    public int System.Collections.Generic.IAsyncEnumerator<T>.Current;
    public System.Runtime.CompilerServices.AsyncIteratorMethodBuilder <>t__builder;
    public System.Threading.Tasks.Sources.ManualResetValueTaskSourceCore`1<bool> <>v__promiseOfValueOrEnd;
    public T <>2__current;
    public bool <>w__disposeMode;
    public System.Threading.CancellationTokenSource <>x__combinedTokens;
    public int <>l__initialThreadId;
    public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Collections.Generic.Queue`1<T>> queueTypeInfo;
    public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Collections.Generic.Queue`1<T>> <>3__queueTypeInfo;
    public System.IO.Stream utf8Json;
    public System.IO.Stream <>3__utf8Json;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationToken <>3__cancellationToken;
    public System.Text.Json.Serialization.ReadBufferState <bufferState>5__2;
    public System.Text.Json.ReadStack <readStack>5__3;
    public System.Text.Json.JsonReaderState <jsonReaderState>5__4;
    public ConfiguredValueTaskAwaiter<System.Text.Json.Serialization.ReadBufferState> <>u__1;
    public System.Collections.Generic.Queue`1<T> <queue>5__5;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
    public void System.Collections.Generic.IAsyncEnumerable<T>.GetAsyncEnumerator(){}
    public void System.Collections.Generic.IAsyncEnumerator<T>.MoveNextAsync(){}
    public void System.Collections.Generic.IAsyncEnumerator<T>.get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Threading.Tasks.Sources.IValueTaskSource<System.Boolean>.GetResult(){} // RVA: 0x7FFAC2C5AB80
    public void System.Threading.Tasks.Sources.IValueTaskSource<System.Boolean>.GetStatus(){}
    public void System.Threading.Tasks.Sources.IValueTaskSource<System.Boolean>.OnCompleted(){}
    public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void System.Threading.Tasks.Sources.IValueTaskSource.GetStatus(){}
    public void System.Threading.Tasks.Sources.IValueTaskSource.OnCompleted(){}
    public void System.IAsyncDisposable.DisposeAsync(){}
}

public class <<Dispose>g__DestroyAsync|54_0>d : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x18
    public UnityEngine.Object obj; // 0x20
    public Awaiter <>u__1; // 0x28

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFACC004F60
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <<DisposeAsync>g__Await|26_0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.ValueTask vt; // 0x38
    public int i; // 0x48
    public System.Collections.Generic.List`1<object> toDispose; // 0x50
    public ConfiguredValueTaskAwaiter <>u__1; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC83352A0
    public void SetStateMachine(){} // RVA: 0x7FFAC3C969E0
}

public class <<DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|32_0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder`1<System.Exception> <>t__builder; // 0x18
    public System.Collections.IEnumerator collectionEnumerator; // 0x40
    public System.IAsyncDisposable asyncDisposable; // 0x48
    public System.Exception exception; // 0x50
    public ConfiguredValueTaskAwaiter <>u__1; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC90491E0
    public void SetStateMachine(){} // RVA: 0x7FFAC9049500
}

public class <<DownloadImage>g__SlicedTextureUpload|52_0>d : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder; // 0x18
    public int width; // 0x28
    public int bytesPerPixel; // 0x2C
    public int height; // 0x30
    public 0x6B17C078 format; // 0x34
    public Unity.Collections.NativeSlice`1<byte> outputBuffer; // 0x38
    public UnityEngine.Texture2D outputTexture; // 0x48
    public int mipLevel; // 0x50
    public int <sliceHeight>5__2; // 0x54
    public UnityEngine.Texture2D <sliceTexture>5__3; // 0x58
    public UnityEngine.Texture2D <uploadTexture>5__4; // 0x60
    public Awaiter <>u__1; // 0x68
    public int <sliceCount>5__5; // 0x6C
    public int <bytesPerRow>5__6; // 0x70
    public int <sliceIndex>5__7; // 0x74

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFACC005300
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <<Get>g__asyncHelper|0>d : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass151_0 <>4__this; // 0x20
    public Awaiter<VRC.Core.ApiWorldInstance> <>u__1; // 0x28

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFACBF01180
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <<GetRewriteHandler>b__271_0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Net.BufferOffsetSize> <>t__builder; // 0x18
    public System.Net.HttpWebRequest <>4__this; // 0x30
    public System.IO.MemoryStream <ms>5__2; // 0x38
    public ConfiguredTaskAwaiter <>u__1; // 0x40

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC92FDD80
    public void SetStateMachine(){} // RVA: 0x7FFAC92FE300
}

public class <<HttpListenerLoop>b__0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass9_0 <>4__this; // 0x30
    public <>c__DisplayClass9_1 <>8__1; // 0x38
    public <>c__DisplayClass9_2 <>8__2; // 0x40
    public <>c__DisplayClass9_3 <>8__3; // 0x48
    public Enumerator<System.Func`3<System.Net.HttpListenerContext,System.Action,System.Threading.Tasks.Task>> <>7__wrap1; // 0x50
    public System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x68

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC9D22590
    public void SetStateMachine(){} // RVA: 0x7FFAC9D23600
}

public class <<InitializeRegistryAsync>g__InitializePackageAsync|2>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass3_0 <>4__this; // 0x30
    public Unity.Services.Core.Internal.IInitializablePackage package; // 0x38
    public System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x40

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC96F2B70
    public void SetStateMachine(){} // RVA: 0x7FFAC96F2F50
}

public class <<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass3_0 <>4__this; // 0x30
    public Unity.Services.Core.Internal.IInitializablePackage package; // 0x38
    public System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x40

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC96F2FB0
    public void SetStateMachine(){} // RVA: 0x7FFAC96F3520
}

public class <<InitializeServicesAsync>g__InitializePackagesAsync|1>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass22_0 <>4__this; // 0x30
    public System.Runtime.CompilerServices.TaskAwaiter`1<System.Collections.Generic.List`1<Unity.Services.Core.Internal.PackageInitializationInfo>> <>u__1; // 0x38

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC96F8AC0
    public void SetStateMachine(){} // RVA: 0x7FFAC96F9030
}

public class <<InternalWriteEndAsync>g__AwaitEnd|11_2>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task task; // 0x30
    public Newtonsoft.Json.JsonWriter <>4__this; // 0x38
    public int LevelsToComplete; // 0x40
    public System.Threading.CancellationToken CancellationToken; // 0x48
    public ConfiguredTaskAwaiter <>u__1; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC874F200
    public void SetStateMachine(){} // RVA: 0x7FFAC874F5E0
}

public class <<InternalWriteEndAsync>g__AwaitIndent|11_1>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task task; // 0x30
    public Newtonsoft.Json.JsonWriter <>4__this; // 0x38
    public 0x6B1C5298 token; // 0x40
    public System.Threading.CancellationToken CancellationToken; // 0x48
    public int LevelsToComplete; // 0x50
    public ConfiguredTaskAwaiter <>u__1; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC874F640
    public void SetStateMachine(){} // RVA: 0x7FFAC874FC10
}

public class <<InternalWriteEndAsync>g__AwaitProperty|11_0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task task; // 0x30
    public Newtonsoft.Json.JsonWriter <>4__this; // 0x38
    public System.Threading.CancellationToken CancellationToken; // 0x40
    public 0x6B1C5298 token; // 0x48
    public int LevelsToComplete; // 0x4C
    public ConfiguredTaskAwaiter <>u__1; // 0x50

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC874FC70
    public void SetStateMachine(){} // RVA: 0x7FFAC87503C0
}

public class <<InternalWriteEndAsync>g__AwaitRemaining|11_3>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public Newtonsoft.Json.JsonWriter <>4__this; // 0x30
    public System.Threading.CancellationToken CancellationToken; // 0x38
    public int LevelsToComplete; // 0x40
    public 0x6B1C5298 <token>5__2; // 0x44
    public ConfiguredTaskAwaiter <>u__1; // 0x48

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8750420
    public void SetStateMachine(){} // RVA: 0x7FFAC87509A0
}

public class <<Invoke>g__Retry|0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass4_0 <>4__this; // 0x38
    public System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x40

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC99E27B0
    public void SetStateMachine(){} // RVA: 0x7FFAC360C270
}

public class <<Invoke>g__WaitAndRetry|0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass4_0 <>4__this; // 0x38
    public System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x40

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC99E3540
    public void SetStateMachine(){} // RVA: 0x7FFAC360C270
}

public class <<Invoke>g__WaitAndRetry|1>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass4_0 <>4__this; // 0x30
    public System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC99E2BA0
    public void SetStateMachine(){} // RVA: 0x7FFAC99E2FA0
}

public class <<Listen>b__0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass12_0 <>4__this; // 0x30
    public ConfiguredTaskAwaiter<System.Net.Sockets.UdpReceiveResult> <>u__1; // 0x38

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8244F90
    public void SetStateMachine(){} // RVA: 0x7FFAC8245540
}

public class <<OnMain>b__0>d : ValueType
{
    public int <>1__state; // 0x10
    public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass53_0 <>4__this; // 0x20
    public Awaiter <>u__1; // 0x28

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC9E6AB20
    public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
}

public class <<ProcessQueryResult>g__EnabledComponents|0>d : Object
{
    public int System.Collections.Generic.IEnumerator<System.String>.Current; // 0x10
    public string System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x20
    public <>c__DisplayClass43_0 <>4__this; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC327C740
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC8924590
    public void System.Collections.Generic.IEnumerator<System.String>.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8924CD0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.Generic.IEnumerable<System.String>.GetEnumerator(){} // RVA: 0x7FFAC8924D10
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8924D10
}

public class <<PruneContinuously>b__0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass1_0 <>4__this; // 0x30
    public System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC823B310
    public void SetStateMachine(){} // RVA: 0x7FFAC823B620
}

public class <<ReadAsync>g__FinishReadAsync|44_0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder`1<int> <>t__builder; // 0x18
    public System.Threading.Tasks.Task`1<int> readTask; // 0x38
    public byte[] localBuffer; // 0x40
    public System.Memory`1<byte> localDestination; // 0x48
    public ConfiguredTaskAwaiter<int> <>u__1; // 0x58

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC85EC660
    public void SetStateMachine(){} // RVA: 0x7FFAC85ECB60
}

public class <<SerializeAsync>g__Write|0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public <>c__DisplayClass21_0 <>4__this; // 0x30
    public string content; // 0x38
    public ConfiguredValueTaskAwaiter <>u__1; // 0x40

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC8B79830
    public void SetStateMachine(){} // RVA: 0x7FFAC8B79D20
}

public class <<WriteToAsync>g__AwaitProperties|0_0>d : ValueType
{
    public int <>1__state; // 0x10
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
    public System.Threading.Tasks.Task task; // 0x30
    public Newtonsoft.Json.Linq.JObject <>4__this; // 0x38
    public int i; // 0x40
    public Newtonsoft.Json.JsonWriter Writer; // 0x48
    public System.Threading.CancellationToken CancellationToken; // 0x50
    public Newtonsoft.Json.JsonConverter[] Converters; // 0x58
    public ConfiguredTaskAwaiter <>u__1; // 0x60

    // ── Methods ──
    public void MoveNext(){} // RVA: 0x7FFAC87CC1C0
    public void SetStateMachine(){} // RVA: 0x7FFAC87CC800
}

public class <<get_Baggage>g__Iterate|87_0>d : Object
{
    public int System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current; // 0x10
    public System.Collections.Generic.KeyValuePair`2<string,string> System.Collections.IEnumerator.Current; // 0x18
    public int <>l__initialThreadId; // 0x28
    public System.Diagnostics.Activity activity; // 0x30
    public System.Diagnostics.Activity <>3__activity; // 0x38
    public System.Diagnostics.DiagNode`1<System.Collections.Generic.KeyValuePair`2<string,string>> <current>5__2; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC39FB270
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void MoveNext(){} // RVA: 0x7FFAC8F736B0
    public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current(){} // RVA: 0x7FFAC35D3330
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC8F73910
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC8F73950
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator(){} // RVA: 0x7FFAC8F739A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8F739A0
}

public class <>O : Object
{
    public System.Func`1<ZLogger.IZLoggerFormatter> <0>__DefaultFormatterFactory;
}

public class <>c : Object
{
    public <>c <>9;
    public System.Func`2<string,System.ValueTuple`2<string,string>> <>9__1_0; // 0x8

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFACC0EB810
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void <GetOrAdd>b__1_0(){} // RVA: 0x7FFACC0EB8B0
}

public class <>c__0`1 : Object
{
    public <>c__0`1<T> <>9;
    public System.Action`2<System.Threading.Tasks.Task`1<T>,object> <>9__0_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <AsUniTask>b__0_0(){} // RVA: 0x7FFAC2C79B30
}

public class <>c__10`1 : Object
{
    public <>c__10`1<T> <>9;
    public System.Predicate`1<ÍÏÌÌÏÍÍÎÍÏÍÌÌÎÎÌÏÌÏÏÎÍÍ> <>9__10_0;

    // ── Methods ──
    public void GetInstanceID(){}
    public void Equals(){}
    public void GetHashCode(){}
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void CompareBaseObjects(){}
    public void IsNativeObjectAlive(){}
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){}
}

public class <>c__128`2 : Object
{
    public <>c__128`2<U,T> <>9;
    public System.Func`2<U,U> <>9__128_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GroupBy>b__128_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__129`2 : Object
{
    public <>c__129`2<U,T> <>9;
    public System.Func`2<U,U> <>9__129_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GroupBy>b__129_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__12`1 : Object
{
    public <>c__12`1<T> <>9;
    public System.Predicate`1<System.WeakReference> <>9__12_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GetChild>b__12_0(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__132`3 : Object
{
    public <>c__132`3<U,V,T> <>9;
    public System.Func`2<U,U> <>9__132_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GroupBy>b__132_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__133`3 : Object
{
    public <>c__133`3<U,V,T> <>9;
    public System.Func`2<U,U> <>9__133_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GroupBy>b__133_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__136`2 : Object
{
    public <>c__136`2<U,T> <>9;
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<U>> <>9__136_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GroupByAwait>b__136_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__137`2 : Object
{
    public <>c__137`2<U,T> <>9;
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<U>> <>9__137_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GroupByAwait>b__137_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__13`2 : Object
{
    public <>c__13`2<U,T> <>9;
    public System.Func`2<U,System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>> <>9__13_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <Children>b__13_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__140`3 : Object
{
    public <>c__140`3<U,V,T> <>9;
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<U>> <>9__140_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GroupByAwait>b__140_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__142`3 : Object
{
    public <>c__142`3<U,V,T> <>9;
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<U>> <>9__142_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GroupByAwait>b__142_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__144`2 : Object
{
    public <>c__144`2<U,T> <>9;
    public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<U>> <>9__144_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GroupByAwaitWithCancellation>b__144_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__145`2 : Object
{
    public <>c__145`2<U,T> <>9;
    public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<U>> <>9__145_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GroupByAwaitWithCancellation>b__145_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__148`3 : Object
{
    public <>c__148`3<U,V,T> <>9;
    public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<U>> <>9__148_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GroupByAwaitWithCancellation>b__148_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__150`3 : Object
{
    public <>c__150`3<U,V,T> <>9;
    public System.Func`3<U,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<U>> <>9__150_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GroupByAwaitWithCancellation>b__150_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__154`1 : Object
{
    public <>c__154`1<T> <>9;
    public System.Func`2<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ,bool> <>9__154_0;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){} // RVA: 0x7FFAC2C59F60
    public void Equals(){} // RVA: 0x7FFAC2C59F60
    public void op_Implicit(){} // RVA: 0x7FFAC2C59F60
    public void CompareBaseObjects(){} // RVA: 0x7FFAC2C59F60
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2C59F60
    public void GetCachedPtr(){} // RVA: 0x7FFAC2C59F60
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void set_name(){} // RVA: 0x7FFAC2C59F60
    public void Instantiate(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__155`1 : Object
{
    public <>c__155`1<T> <>9;
    public System.Func`2<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ,bool> <>9__155_0;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC2C59F60
    public void Equals(){} // RVA: 0x7FFAC2C59F60
    public void GetHashCode(){} // RVA: 0x7FFAC2C59F60
    public void op_Implicit(){} // RVA: 0x7FFAC2C59F60
    public void CompareBaseObjects(){} // RVA: 0x7FFAC2C59F60
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){} // RVA: 0x7FFAC2C59F60
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void set_name(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__15`2 : Object
{
    public <>c__15`2<U,T> <>9;
    public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<U>> <>9__15_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <CreateIEnumerableInfo>b__15_0(){} // RVA: 0x7FFAC2C58E90
}

public class <>c__162`1 : Object
{
    public <>c__162`1<T> <>9;
    public System.Func`2<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ,bool> <>9__162_0;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC2C59F60
    public void Equals(){} // RVA: 0x7FFAC2C59F60
    public void GetHashCode(){} // RVA: 0x7FFAC2C59F60
    public void op_Implicit(){} // RVA: 0x7FFAC2C59F60
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void GetCachedPtr(){} // RVA: 0x7FFAC2C59F60
    public void get_name(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__163`1 : Object
{
    public <>c__163`1<T> <>9;
    public System.Func`2<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ,bool> <>9__163_0;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC2C59F60
    public void Equals(){} // RVA: 0x7FFAC2C59F60
    public void GetHashCode(){} // RVA: 0x7FFAC2C59F60
    public void op_Implicit(){} // RVA: 0x7FFAC2C59F60
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){} // RVA: 0x7FFAC2C59F60
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void get_name(){} // RVA: 0x7FFAC2C59F60
    public void set_name(){} // RVA: 0x7FFAC2C59F60
    public void Instantiate(){} // RVA: 0x7FFAC2C59F60
    public void ToString(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__182`2 : Object
{
    public <>c__182`2<T,T> <>9;
    public System.Func`2<System.Nullable`1<T>,bool> <>9__182_0;
    public System.Func`2<System.Nullable`1<T>,T> <>9__182_1;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <Sum>b__182_0(){} // RVA: 0x7FFAC2E8DC40
    public void <Sum>b__182_1(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__19`1 : Object
{
    public <>c__19`1<T> <>9;
    public System.Action`1<object> <>9__19_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <Forget>b__19_0(){} // RVA: 0x7FFAC2C70A40
}

public class <>c__1`1 : Object
{
    public <>c__1`1<T> <>9;
    public System.Func`2<T,System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>> <>9__1_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <AncestorsAndSelf>b__1_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__241`1 : Object
{
    public <>c__241`1<T> <>9;
    public System.Func`2<System.Threading.Tasks.Task`1<T>,System.Nullable`1<int>> <>9__241_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <RunWithTimeoutWorker>b__241_0(){} // RVA: 0x7FFAC2C58F40
}

public class <>c__26`1 : Object
{
    public <>c__26`1<T> <>9;
    public System.Func`2<ÌÎÎÏÎÎÎÏÏÌÌÍÌÏÌÎÌÏÏÌÎÎÍ<T>,VRC.Localization.LocalizableOptionData> <>9__26_0;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void Initialize(){}
}

public class <>c__2`1 : Object
{
    public <>c__2`1<T> <>9;
    public System.Func`2<T,string> <>9__2_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <Format>b__2_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__2`2 : Object
{
    public <>c__2`2<U,T> <>9;
    public System.Func`2<System.Collections.Generic.KeyValuePair`2<U,T>,U> <>9__2_0;
    public System.Func`2<System.Collections.Generic.KeyValuePair`2<U,T>,T> <>9__2_1;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <ToDict>b__2_0(){} // RVA: 0x7FFAC2E8DC40
    public void <ToDict>b__2_1(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__2`3 : Object
{
    public <>c__2`3<U,V,T> <>9;
    public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<U>> <>9__2_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <CreateDictionaryInfo>b__2_0(){} // RVA: 0x7FFAC2C58E90
}

public class <>c__309`2 : Object
{
    public <>c__309`2<U,T> <>9;
    public System.Func`3<U,T,T> <>9__309_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <SelectMany>b__309_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__310`2 : Object
{
    public <>c__310`2<U,T> <>9;
    public System.Func`3<U,T,T> <>9__310_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <SelectMany>b__310_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__313`2 : Object
{
    public <>c__313`2<U,T> <>9;
    public System.Func`3<U,T,Cysharp.Threading.Tasks.UniTask`1<T>> <>9__313_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <SelectManyAwait>b__313_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__314`2 : Object
{
    public <>c__314`2<U,T> <>9;
    public System.Func`3<U,T,Cysharp.Threading.Tasks.UniTask`1<T>> <>9__314_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <SelectManyAwait>b__314_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__317`2 : Object
{
    public <>c__317`2<U,T> <>9;
    public System.Func`4<U,T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> <>9__317_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <SelectManyAwaitWithCancellation>b__317_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__318`2 : Object
{
    public <>c__318`2<U,T> <>9;
    public System.Func`4<U,T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> <>9__318_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <SelectManyAwaitWithCancellation>b__318_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__31`1 : Object
{
    public <>c__31`1<T> <>9;
    public System.Func`2<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ,bool> <>9__31_0;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC2C59F60
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){} // RVA: 0x7FFAC2C59F60
    public void CompareBaseObjects(){} // RVA: 0x7FFAC2C59F60
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2C59F60
    public void GetCachedPtr(){} // RVA: 0x7FFAC2C59F60
    public void get_name(){} // RVA: 0x7FFAC2C59F60
    public void set_name(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__32`1 : Object
{
    public <>c__32`1<T> <>9;
    public Google.Protobuf.ValueWriter`1<T> <>9__32_1;
    public ValuesMerger<T> <>9__32_3;
    public System.Func`2<T,int> <>9__32_4;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <ForMessage>b__32_1(){} // RVA: 0x7FFAC2E8DC40
    public void <ForMessage>b__32_3(){} // RVA: 0x7FFAC2E8DC40
    public void <ForMessage>b__32_4(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__348`1 : Object
{
    public <>c__348`1<T> <>9;
    public System.Predicate`1<Sentry.Integrations.ISdkIntegration> <>9__348_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <RemoveIntegration>b__348_0(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__350`1 : Object
{
    public <>c__350`1<T> <>9;
    public System.Predicate`1<Sentry.Extensibility.IExceptionFilter> <>9__350_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <RemoveExceptionFilter>b__350_0(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__362`1 : Object
{
    public <>c__362`1<T> <>9;
    public System.Predicate`1<System.ValueTuple`2<System.Type,System.Lazy`1<Sentry.Extensibility.ISentryEventProcessor>>> <>9__362_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <RemoveEventProcessor>b__362_0(){}
}

public class <>c__366`1 : Object
{
    public <>c__366`1<T> <>9;
    public System.Predicate`1<Sentry.Extensibility.ISentryTransactionProcessor> <>9__366_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <RemoveTransactionProcessor>b__366_0(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__378`1 : Object
{
    public <>c__378`1<T> <>9;
    public System.Func`2<Sentry.Integrations.ISdkIntegration,bool> <>9__378_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <HasIntegration>b__378_0(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__37`1 : Object
{
    public <>c__37`1<T> <>9;
    public System.Func`3<T,T,bool> <>9__37_0;
    public System.Func`3<T,T,bool> <>9__37_1;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GetEqualityComparerDelegate>b__37_0(){} // RVA: 0x7FFAC2E8DC40
    public void <GetEqualityComparerDelegate>b__37_1(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__39`1 : Object
{
    public <>c__39`1<T> <>9;
    public System.Func`1<ÏÌÏÍÌÏÎÌÍÎÏÎÌÍÏÍÍÌÌÎÎÍÍ> <>9__39_0;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC2C58E90
    public void Equals(){} // RVA: 0x7FFAC2C58E90
    public void GetHashCode(){} // RVA: 0x7FFAC2C58E90
    public void op_Implicit(){} // RVA: 0x7FFAC2C58E90
    public void CompareBaseObjects(){} // RVA: 0x7FFAC2C58E90
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2C58E90
    public void GetCachedPtr(){} // RVA: 0x7FFAC2C58E90
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void set_name(){} // RVA: 0x7FFAC2C58E90
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class <>c__3`1 : Object
{
    public <>c__3`1<T> <>9;
    public System.Func`2<T,System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>> <>9__3_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <DescendantsAndSelf>b__3_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__3`2 : Object
{
    public <>c__3`2<U,T> <>9;
    public System.Func`2<object,object> <>9__3_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <RunOnEmptyStack>b__3_0(){} // RVA: 0x7FFAC2C58F40
}

public class <>c__3`3 : Object
{
    public <>c__3`3<U,V,T> <>9;
    public System.Func`2<object,T> <>9__3_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <RunOnEmptyStack>b__3_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__471`2 : Object
{
    public <>c__471`2<U,T> <>9;
    public System.Func`3<U,T,System.ValueTuple`2<U,T>> <>9__471_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <Zip>b__471_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__47`1 : Object
{
    public <>c__47`1<T> <>9;
    public System.Func`2<T,T> <>9__47_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <Median>b__47_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__48`1 : Object
{
    public <>c__48`1<T> <>9;
    public System.Func`2<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ,bool> <>9__48_0;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC2C59F60
    public void Equals(){} // RVA: 0x7FFAC2C59F60
    public void GetHashCode(){} // RVA: 0x7FFAC2C59F60
    public void op_Implicit(){} // RVA: 0x7FFAC2C59F60
    public void CompareBaseObjects(){} // RVA: 0x7FFAC2C59F60
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2C59F60
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__49`1 : Object
{
    public <>c__49`1<T> <>9;
    public System.Func`2<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ,bool> <>9__49_0;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void Equals(){} // RVA: 0x7FFAC2C59F60
    public void op_Implicit(){} // RVA: 0x7FFAC2C59F60
    public void CompareBaseObjects(){} // RVA: 0x7FFAC2C59F60
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2C59F60
    public void GetCachedPtr(){} // RVA: 0x7FFAC2C59F60
    public void get_name(){} // RVA: 0x7FFAC2C59F60
    public void set_name(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__4`1 : Object
{
    public <>c__4`1<T> <>9;
    public System.Func`2<ulong,bool> <>9__4_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GetFlagsValues>b__4_0(){} // RVA: 0x7FFAC2C5A7E0
}

public class <>c__4`3 : Object
{
    public <>c__4`3<T,T,T> <>9;
    public System.Func`2<System.Delegate,bool> <>9__4_0;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC2C59F60
    public void Equals(){} // RVA: 0x7FFAC2C59F60
    public void GetHashCode(){} // RVA: 0x7FFAC2C59F60
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){} // RVA: 0x7FFAC2C59F60
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2C59F60
    public void GetCachedPtr(){} // RVA: 0x7FFAC2C59F60
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class <>c__51`1 : Object
{
    public <>c__51`1<T> <>9;
    public System.Func`2<object,Token> <>9__51_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <TryFromObject>b__51_0(){}
}

public class <>c__52`1 : Object
{
    public <>c__52`1<U,T> <>9;
    public System.Func`2<ÎÏÍÍÍÌÏÌÍÍÎÍÎÍÍÍÍÌÍÍÎÏÏ,bool> <>9__52_0;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC2C59F60
    public void Equals(){} // RVA: 0x7FFAC2C59F60
    public void GetHashCode(){} // RVA: 0x7FFAC2C59F60
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){} // RVA: 0x7FFAC2C59F60
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2C59F60
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void get_name(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__55`2 : Object
{
    public <>c__55`2<U,T> <>9;
    public System.Func`2<System.Collections.Generic.KeyValuePair`2<U,T>,System.Tuple`2<U,T>> <>9__55_1;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <BuildMapCreator>b__55_1(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__57`1 : Object
{
    public <>c__57`1<U,T> <>9;
    public System.Func`3<T,int,ÎÌÌÍÏÌÍÌÌÎÌÏÌÌÌÎÎÎÏÍÍÏÎ<U>> <>9__57_0;
    public System.Func`3<T,int,ÎÌÌÍÏÌÍÌÌÎÌÏÌÌÌÎÎÎÏÍÍÏÎ<U>> <>9__57_1;
    public System.Func`2<ÎÌÌÍÏÌÍÌÌÎÌÏÌÌÌÎÎÎÏÍÍÏÎ<U>,T> <>9__57_2;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC2E8DC40
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void Equals(){} // RVA: 0x7FFAC2E8DC40
    public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class <>c__5`1 : Object
{
    public <>c__5`1<T> <>9;
    public System.Func`1<System.Collections.Generic.List`1<T>> <>9__5_0;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void Equals(){} // RVA: 0x7FFAC2C58E90
}

public class <>c__5`3 : Object
{
    public <>c__5`3<T,T,T> <>9;
    public System.Func`2<System.Delegate,bool> <>9__5_0;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC2C59F60
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){} // RVA: 0x7FFAC2C59F60
    public void op_Implicit(){} // RVA: 0x7FFAC2C59F60
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2C59F60
    public void GetCachedPtr(){} // RVA: 0x7FFAC2C59F60
    public void get_name(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__61`2 : Object
{
    public <>c__61`2<U,U> <>9;
    public System.Action`1<object> <>9__61_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <ReceiveAsyncPrivate>b__61_0(){} // RVA: 0x7FFAC2C70A40
}

public class <>c__66`1 : Object
{
    public <>c__66`1<T> <>9;
    public System.Predicate`1<System.Collections.Generic.KeyValuePair`2<System.Type,UnityEngine.Component>> <>9__66_0;

    // ── Methods ──
    public void GetInstanceID(){}
    public void Equals(){}
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void op_Implicit(){}
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){}
    public void GetCachedPtr(){}
    public void get_name(){}
    public void set_name(){}
    public void Instantiate(){}
    public void GetHashCode(){}
}

public class <>c__69`1 : Object
{
    public <>c__69`1<T,T> <>9;
    public System.Func`2<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ,bool> <>9__69_0;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){} // RVA: 0x7FFAC2C59F60
    public void Equals(){} // RVA: 0x7FFAC2C59F60
    public void op_Implicit(){} // RVA: 0x7FFAC2C59F60
    public void CompareBaseObjects(){} // RVA: 0x7FFAC2C59F60
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void GetCachedPtr(){} // RVA: 0x7FFAC2C59F60
    public void get_name(){} // RVA: 0x7FFAC2C59F60
    public void set_name(){} // RVA: 0x7FFAC2C59F60
    public void Instantiate(){} // RVA: 0x7FFAC2C59F60
    public void GetHashCode(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__6`1 : Object
{
    public <>c__6`1<T> <>9;
    public System.Func`1<T> <>9__6_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <FromCanceled>b__6_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__6`4 : Object
{
    public <>c__6`4<U,V,W,T> <>9;
    public System.Func`2<object,T> <>9__6_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <RunOnEmptyStack>b__6_0(){} // RVA: 0x7FFAC2E8DC40
}

public class <>c__70`1 : Object
{
    public <>c__70`1<T,U> <>9;
    public System.Func`2<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ,bool> <>9__70_0;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){} // RVA: 0x7FFAC2C59F60
    public void Equals(){} // RVA: 0x7FFAC2C59F60
    public void op_Implicit(){} // RVA: 0x7FFAC2C59F60
    public void CompareBaseObjects(){} // RVA: 0x7FFAC2C59F60
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void GetCachedPtr(){} // RVA: 0x7FFAC2C59F60
    public void get_name(){} // RVA: 0x7FFAC2C59F60
    public void set_name(){} // RVA: 0x7FFAC2C59F60
    public void Instantiate(){} // RVA: 0x7FFAC2C59F60
}

public class <>c__75`1 : Object
{
    public <>c__75`1<T> <>9;
    public System.Predicate`1<System.WeakReference> <>9__75_0;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void <GetDataSource>b__75_0(){} // RVA: 0x7FFAC2C59F60
}
