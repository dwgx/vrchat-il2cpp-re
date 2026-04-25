// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 93
// Methods: 655

public class WIN32_FILE_ATTRIBUTE_DATA : ValueType
{
    public int dwFileAttributes; // 0x10
    public FILE_TIME ftCreationTime; // 0x14
    public FILE_TIME ftLastAccessTime; // 0x1C
    public FILE_TIME ftLastWriteTime; // 0x24
    public uint nFileSizeHigh; // 0x2C
    public uint nFileSizeLow; // 0x30

    // ── Methods ──
    public void PopulateFrom(){} // RVA: 0x7FFAC838A420
}

public class WIN32_FIND_DATA : ValueType
{
    public uint cFileName; // 0x10
    public FILE_TIME ftCreationTime; // 0x14
    public FILE_TIME ftLastAccessTime; // 0x1C
    public FILE_TIME ftLastWriteTime; // 0x24
    public uint nFileSizeHigh; // 0x2C
    public uint nFileSizeLow; // 0x30
    public uint dwReserved0; // 0x34
    public uint dwReserved1; // 0x38
    public <_cFileName>e__FixedBuffer _cFileName; // 0x3C
    public <_cAlternateFileName>e__FixedBuffer _cAlternateFileName; // 0x244

    // ── Methods ──
    public void get_cFileName(){} // RVA: 0x7FFAC838A040
    public void SetFileName(){} // RVA: 0x7FFAC838A090
}

public class WSABUF : ValueType
{
    public int len; // 0x10
    public UIntPtr buf; // 0x18
}

public class WTauNafCallback : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.AbstractF2mPoint m_p; // 0x10
    public sbyte m_a; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC45687E0
    public void Precompute(){} // RVA: 0x7FFACBA817F0
}

public class WaitAsyncSource : Object
{
    public System.Action`1<object> Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.NextNode;
    public Cysharp.Threading.Tasks.TaskPool`1<WaitAsyncSource<T>> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev;
    public WaitAsyncSource<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next;
    public Cysharp.Threading.Tasks.AsyncReactiveProperty`1<T> parent;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<T> core;
    public Cysharp.Threading.Tasks.ITriggerHandler`1<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField;
    public Cysharp.Threading.Tasks.ITriggerHandler`1<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField;

    // ── Methods ──
    public void Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.get_NextNode(){} // RVA: 0x7FFAC2C58E90
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Create(){}
    public void TryReturn(){} // RVA: 0x7FFAC2C59D00
    public void CancellationCallback(){} // RVA: 0x7FFAC2C70A10
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void OnCompleted(){} // RVA: 0x7FFAC2C70980 | overloaded x2
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x7FFAC2C58E90
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x7FFAC2C70A40
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x7FFAC2C58E90
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x7FFAC2C70A40
    public void OnCanceled(){} // RVA: 0x7FFAC2C70BF0
    public void OnError(){} // RVA: 0x7FFAC2C70A40
    public void OnNext(){} // RVA: 0x7FFAC2E8DC40
}

public class WaitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86CAE10
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class WaitForAudioCaptureDeviceAuthorisation : CustomYieldInstruction
{
    public object keepWaiting;

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFAC8A1C230
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class WaitForAuthorisationToAccessPhotos : CustomYieldInstruction
{
    public object keepWaiting;

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFAC8A1C290
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class WaitForCompletion : CustomYieldInstruction
{
    public DG.Tweening.Tween keepWaiting; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFAC49B0800
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
}

public class WaitForElapsedLoops : CustomYieldInstruction
{
    public DG.Tweening.Tween keepWaiting; // 0x10
    public int elapsedLoops; // 0x18

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFAC49B08D0
    public void .ctor(){} // RVA: 0x7FFAC488C310
}

public class WaitForEndOfFramePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitForEndOfFramePromise> NextNode;
    public WaitForEndOfFramePromise System.Collections.IEnumerator.Current; // 0x10
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<object> core; // 0x18
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x48
    public bool cancelImmediately; // 0x60
    public UnityEngine.WaitForEndOfFrame waitForEndOfFrameYieldInstruction; // 0x10
    public bool isFirst; // 0x61

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC948D700
    public void .ctor(){} // RVA: 0x7FFAC948D910
    public void Create(){} // RVA: 0x7FFAC948D920
    public void GetResult(){} // RVA: 0x7FFAC948DC80
    public void GetStatus(){} // RVA: 0x7FFAC948DE20
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC948DE70
    public void OnCompleted(){} // RVA: 0x7FFAC948DEB0
    public void TryReturn(){} // RVA: 0x7FFAC948DF30
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC948DFE0
    public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFAC948E040
    public void Reset(){} // RVA: 0x7FFAC948D910
}

public class WaitForKill : CustomYieldInstruction
{
    public DG.Tweening.Tween keepWaiting; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFAC49B08B0
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
}

public class WaitForLastPresentationAndUpdateTime : ValueType
{
}

public class WaitForPosition : CustomYieldInstruction
{
    public DG.Tweening.Tween keepWaiting; // 0x10
    public float position; // 0x18

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFAC49B0910
    public void .ctor(){} // RVA: 0x7FFAC49B0960
}

public class WaitForRewind : CustomYieldInstruction
{
    public DG.Tweening.Tween keepWaiting; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFAC49B0840
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
}

public class WaitForStart : CustomYieldInstruction
{
    public DG.Tweening.Tween keepWaiting; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFAC49B09C0
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
}

public class WaitUntilCanceledPromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilCanceledPromise> NextNode;
    public WaitUntilCanceledPromise nextNode; // 0x10
    public System.Threading.CancellationToken cancellationToken; // 0x18
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x20
    public bool cancelImmediately; // 0x38
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<object> core; // 0x40

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC9493020
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Create(){} // RVA: 0x7FFAC94931A0
    public void GetResult(){} // RVA: 0x7FFAC9493520
    public void GetStatus(){} // RVA: 0x7FFAC94936C0
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC9493710
    public void OnCompleted(){} // RVA: 0x7FFAC9493750
    public void MoveNext(){} // RVA: 0x7FFAC94937D0
    public void TryReturn(){} // RVA: 0x7FFAC9493860
}

public class WaitUntilPromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilPromise> NextNode;
    public WaitUntilPromise nextNode; // 0x10
    public System.Func`1<bool> predicate; // 0x18
    public System.Threading.CancellationToken cancellationToken; // 0x20
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x28
    public bool cancelImmediately; // 0x40
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<object> core; // 0x48

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC94917E0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Create(){} // RVA: 0x7FFAC9491960
    public void GetResult(){} // RVA: 0x7FFAC9491D60
    public void GetStatus(){} // RVA: 0x7FFAC9491F50
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC9491FA0
    public void OnCompleted(){} // RVA: 0x7FFAC9491FE0
    public void MoveNext(){} // RVA: 0x7FFAC9492060
    public void TryReturn(){} // RVA: 0x7FFAC9492170
}

public class WaitUntilPromise`1 : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilPromise`1<T>> NextNode;
    public WaitUntilPromise`1<T> nextNode;
    public System.Func`2<T,bool> predicate;
    public T argument;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration;
    public bool cancelImmediately;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<object> core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC2C58E90
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Create(){} // RVA: 0x7FFAC2E8DC40
    public void GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void TryReturn(){} // RVA: 0x7FFAC2C59D00
}

public class WaitUntilValueChangedStandardObjectPromise`2 : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilValueChangedStandardObjectPromise`2<U,T>> NextNode;
    public WaitUntilValueChangedStandardObjectPromise`2<U,T> nextNode;
    public System.WeakReference`1<U> target;
    public T currentValue;
    public System.Func`2<U,T> monitorFunction;
    public System.Collections.Generic.IEqualityComparer`1<T> equalityComparer;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration;
    public bool cancelImmediately;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<T> core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC2C58E90
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Create(){} // RVA: 0x7FFAC2E8DC40
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void TryReturn(){} // RVA: 0x7FFAC2C59D00
}

public class WaitUntilValueChangedUnityObjectPromise`2 : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilValueChangedUnityObjectPromise`2<U,U>> NextNode;
    public WaitUntilValueChangedUnityObjectPromise`2<U,U> nextNode;
    public U target;
    public UnityEngine.Object targetAsUnityObject;
    public U currentValue;
    public System.Func`2<U,U> monitorFunction;
    public System.Collections.Generic.IEqualityComparer`1<U> equalityComparer;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration;
    public bool cancelImmediately;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<U> core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC2C58E90
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Create(){} // RVA: 0x7FFAC2E8DC40
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void TryReturn(){} // RVA: 0x7FFAC2C59D00
}

public class WaitWhilePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitWhilePromise> NextNode;
    public WaitWhilePromise nextNode; // 0x10
    public System.Func`1<bool> predicate; // 0x18
    public System.Threading.CancellationToken cancellationToken; // 0x20
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x28
    public bool cancelImmediately; // 0x40
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<object> core; // 0x48

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC9492400
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Create(){} // RVA: 0x7FFAC9492580
    public void GetResult(){} // RVA: 0x7FFAC9492980
    public void GetStatus(){} // RVA: 0x7FFAC9492B70
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC9492BC0
    public void OnCompleted(){} // RVA: 0x7FFAC9492C00
    public void MoveNext(){} // RVA: 0x7FFAC9492C80
    public void TryReturn(){} // RVA: 0x7FFAC9492D90
}

public class WaitWhilePromise`1 : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitWhilePromise`1<T>> NextNode;
    public WaitWhilePromise`1<T> nextNode;
    public System.Func`2<T,bool> predicate;
    public T argument;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration;
    public bool cancelImmediately;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<object> core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC2C58E90
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Create(){} // RVA: 0x7FFAC2E8DC40
    public void GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void TryReturn(){} // RVA: 0x7FFAC2C59D00
}

public class WapiP192V1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBDAB3B0
    public void .cctor(){} // RVA: 0x7FFACBDAB590
}

public class Waypoint : ValueType
{
    public UnityEngine.Vector3 position; // 0x10
    public UnityEngine.Vector3 tangent; // 0x1C
    public float roll; // 0x28
}

public class WaypointList : Object
{
    public UnityStandardAssets.Utility.WaypointCircuit circuit; // 0x10
    public UnityEngine.Transform[] items; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F2AD60
}

public class WeakKeyComparer : Object
{
    // ── Methods ──
    public void System.Collections.IEqualityComparer.Equals(){} // RVA: 0x7FFAC9449BD0
    public void System.Collections.IEqualityComparer.GetHashCode(){} // RVA: 0x7FFAC31A13D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class WebFile : Object
{
    public byte[] data; // 0x10
    public string path; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class WebSocketReceiveResultGetter : ValueType
{
    // ── Methods ──
    public void GetResult(){} // RVA: 0x7FFAC9355520
}

public class WeightCurve : Object
{
    public 0x6B1C0D28 type; // 0x10
    public UnityEngine.AnimationCurve curve; // 0x18

    // ── Methods ──
    public void GetValue(){} // RVA: 0x7FFAC3077320
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class WeightInfo : ValueType
{
    public UnityEngine.Playables.Playable mixer; // 0x10
    public UnityEngine.Playables.Playable parentMixer; // 0x20
    public int port; // 0x30
}

public class WellKnownNoReferenceContainsType`1 : Object
{
    public bool IsWellKnownType;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC73858C0
}

public class WhenAllPromise : Object
{
    public int completeCount; // 0x10
    public int tasksLength; // 0x14
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9493AB0
    public void TryInvokeContinuation(){} // RVA: 0x7FFAC9493D80
    public void GetResult(){} // RVA: 0x7FFAC9493EA0
    public void GetStatus(){} // RVA: 0x7FFAC9493F20
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC9493F70
    public void OnCompleted(){} // RVA: 0x7FFAC9493FB0
}

public class WhenAllPromise`1 : Object
{
    public ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ[] result; // 0x10
    public int completeCount; // 0x18
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ[]> core; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC73862A0
    public void TryInvokeContinuation(){} // RVA: 0x7FFAC7386720
    public void GetResult(){} // RVA: 0x7FFAC7386860
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC73868F0
    public void GetStatus(){} // RVA: 0x7FFAC7386990
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC73869B0
    public void OnCompleted(){} // RVA: 0x7FFAC73869D0
}

public class WhenAllPromise`10 : Object
{
    public U t1;
    public V t2;
    public W t3;
    public T4 t4;
    public T5 t5;
    public T6 t6;
    public T7 t7;
    public T8 t8;
    public T9 t9;
    public T t10;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<U,V,W,T4,T5,T6,T7,System.ValueTuple`3<T8,T9,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`11 : Object
{
    public U t1;
    public V t2;
    public W t3;
    public T4 t4;
    public T5 t5;
    public T6 t6;
    public T7 t7;
    public T8 t8;
    public T9 t9;
    public T10 t10;
    public T t11;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<U,V,W,T4,T5,T6,T7,System.ValueTuple`4<T8,T9,T10,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`12 : Object
{
    public U t1;
    public V t2;
    public W t3;
    public T4 t4;
    public T5 t5;
    public T6 t6;
    public T7 t7;
    public T8 t8;
    public T9 t9;
    public T10 t10;
    public T11 t11;
    public T t12;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<U,V,W,T4,T5,T6,T7,System.ValueTuple`5<T8,T9,T10,T11,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`13 : Object
{
    public U t1;
    public V t2;
    public W t3;
    public T4 t4;
    public T5 t5;
    public T6 t6;
    public T7 t7;
    public T8 t8;
    public T9 t9;
    public T10 t10;
    public T11 t11;
    public T12 t12;
    public T t13;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<U,V,W,T4,T5,T6,T7,System.ValueTuple`6<T8,T9,T10,T11,T12,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`14 : Object
{
    public U t1;
    public V t2;
    public W t3;
    public T4 t4;
    public T5 t5;
    public T6 t6;
    public T7 t7;
    public T8 t8;
    public T9 t9;
    public T10 t10;
    public T11 t11;
    public T12 t12;
    public T13 t13;
    public T t14;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<U,V,W,T4,T5,T6,T7,System.ValueTuple`7<T8,T9,T10,T11,T12,T13,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`15 : Object
{
    public U t1;
    public V t2;
    public W t3;
    public T4 t4;
    public T5 t5;
    public T6 t6;
    public T7 t7;
    public T8 t8;
    public T9 t9;
    public T10 t10;
    public T11 t11;
    public T12 t12;
    public T13 t13;
    public T14 t14;
    public T t15;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<U,V,W,T4,T5,T6,T7,System.ValueTuple`8<T8,T9,T10,T11,T12,T13,T14,System.ValueTuple`1<T>>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT15(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`2 : Object
{
    public U t1;
    public T t2;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`2<U,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`3 : Object
{
    public U t1;
    public V t2;
    public T t3;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`3<U,V,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`4 : Object
{
    public U t1;
    public V t2;
    public W t3;
    public T t4;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`4<U,V,W,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`5 : Object
{
    public U t1;
    public V t2;
    public W t3;
    public T4 t4;
    public T t5;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`5<U,V,W,T4,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`6 : Object
{
    public U t1;
    public V t2;
    public W t3;
    public T4 t4;
    public T5 t5;
    public T t6;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`6<U,V,W,T4,T5,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`7 : Object
{
    public U t1;
    public V t2;
    public W t3;
    public T4 t4;
    public T5 t5;
    public T6 t6;
    public T t7;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`7<U,V,W,T4,T5,T6,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`8 : Object
{
    public U t1;
    public V t2;
    public W t3;
    public T4 t4;
    public T5 t5;
    public T6 t6;
    public T7 t7;
    public T t8;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<U,V,W,T4,T5,T6,T7,System.ValueTuple`1<T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAllPromise`9 : Object
{
    public U t1;
    public V t2;
    public W t3;
    public T4 t4;
    public T5 t5;
    public T6 t6;
    public T7 t7;
    public T8 t8;
    public T t9;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<U,V,W,T4,T5,T6,T7,System.ValueTuple`2<T8,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class WhenAnyLRPromise`1 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`2<bool,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryLeftInvokeContinuation(){} // RVA: 0x7FFAC2C70C80
    public void TryRightInvokeContinuation(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise : Object
{
    public int completedCount; // 0x10
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<int> core; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC94941D0
    public void TryInvokeContinuation(){} // RVA: 0x7FFAC9494490
    public void GetResult(){} // RVA: 0x7FFAC9494580
    public void GetStatus(){} // RVA: 0x7FFAC9494600
    public void OnCompleted(){} // RVA: 0x7FFAC9494650
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC94946D0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC9494580
}

public class WhenAnyPromise`1 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`2<int,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C77970
    public void TryInvokeContinuation(){} // RVA: 0x7FFAC2C79C70
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`10 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`4<T7,T8,T9,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`11 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`5<T7,T8,T9,T10,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`12 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`6<T7,T8,T9,T10,T11,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`13 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`7<T7,T8,T9,T10,T11,T12,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`14 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`8<T7,T8,T9,T10,T11,T12,T13,System.ValueTuple`1<T>>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`15 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`8<T7,T8,T9,T10,T11,T12,T13,System.ValueTuple`2<T14,T>>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT15(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`2 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`3<int,U,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`3 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`4<int,U,V,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`4 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`5<int,U,V,W,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`5 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`6<int,U,V,W,T4,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`6 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`7<int,U,V,W,T4,T5,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`7 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`1<T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`8 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`2<T7,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class WhenAnyPromise`9 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`3<T7,T8,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFAC2C70C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFAC2C70C80
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
}

public class Where : Object
{
    public UnityEngine.InputSystem.Utilities.WhereObservable`1<T> m_Observable;
    public System.IObserver`1<T> m_Observer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C79B30
    public void OnCompleted(){} // RVA: 0x7FFAC2C70980
    public void OnError(){} // RVA: 0x7FFAC2C70A40
    public void OnNext(){} // RVA: 0x7FFAC2E8DC40
}

public class WhereArrayIterator`1 : Iterator`1
{
    public T[] source;
    public System.Func`2<T,bool> predicate;
    public int index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C79B30
    public void Clone(){} // RVA: 0x7FFAC2C58E90
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void Select(){} // RVA: 0x7FFAC2C58F40
    public void Where(){} // RVA: 0x7FFAC2C58F40
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public System.Collections.Generic.IEnumerable`1<System.ValueTuple`2<string,string>> source; // 0x28
    public System.Func`2<System.ValueTuple`2<string,string>,bool> predicate; // 0x30
    public System.Collections.Generic.IEnumerator`1<System.ValueTuple`2<string,string>> enumerator; // 0x38
}

public class WhereListIterator`1 : Iterator`1
{
    public System.Collections.Generic.List`1<T> source;
    public System.Func`2<T,bool> predicate;
    public Enumerator<T> enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C79B30
    public void Clone(){} // RVA: 0x7FFAC2C58E90
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void Select(){} // RVA: 0x7FFAC2C58F40
    public void Where(){} // RVA: 0x7FFAC2C58F40
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public string[] source; // 0x28
    public System.Func`2<string,bool> predicate; // 0x30
    public System.Func`2<string,System.ValueTuple`2<string,string>> selector; // 0x38
    public int index; // 0x40
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public System.Collections.Generic.IEnumerable`1<string> source; // 0x28
    public System.Func`2<string,bool> predicate; // 0x30
    public System.Func`2<string,System.ValueTuple`2<string,string>> selector; // 0x38
    public System.Collections.Generic.IEnumerator`1<string> enumerator; // 0x40
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public System.Collections.Generic.List`1<string> source; // 0x28
    public System.Func`2<string,bool> predicate; // 0x30
    public System.Func`2<string,System.ValueTuple`2<string,string>> selector; // 0x38
    public Enumerator<string> enumerator; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC74CDF50
    public void Clone(){} // RVA: 0x7FFAC74CE080
    public void MoveNext(){} // RVA: 0x7FFAC7599A50
    public void Select(){} // RVA: 0x7FFAC2C58F40
    public void Where(){} // RVA: 0x7FFAC75848B0
}

public class WidthProperty : Property`2
{
    public object Name;

    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFAC99A6780
    public void .ctor(){} // RVA: 0x7FFAC99A67C0
}

public class WillRenderCanvases : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class WindUpdate : ValueType
{
}

public class WindowFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3012370
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class WindowsCancelHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB00E0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class WindowsConsole : Object
{
    public bool ctrlHandlerAdded;
    public WindowsCancelHandler cancelHandler; // 0x8

    // ── Methods ──
    public void GetConsoleCP(){} // RVA: 0x7FFAC8698CF0
    public void GetConsoleOutputCP(){} // RVA: 0x7FFAC8698D60
    public void DoWindowsConsoleCancelEvent(){} // RVA: 0x7FFAC8698DD0
    public void GetInputCodePage(){} // RVA: 0x7FFAC8698E30
    public void GetOutputCodePage(){} // RVA: 0x7FFAC8698ED0
    public void .cctor(){} // RVA: 0x7FFAC8698F70
}

public class WithSyncContext : CancellationCallbackInfo
{
    public System.Threading.SynchronizationContext TargetSyncContext; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86BF9E0
}

public class WithoutCurrentEnumerable : Object
{
    public Cysharp.Threading.Tasks.AsyncReactiveProperty`1<T> parent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void GetAsyncEnumerator(){}
}

public class WorkRequest : ValueType
{
    public System.Threading.SendOrPostCallback m_DelagateCallback; // 0x10
    public object m_DelagateState; // 0x18
    public System.Threading.ManualResetEvent m_WaitHandle; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC446FCC0
    public void Invoke(){} // RVA: 0x7FFAC98C8EF0
}

public class WorkStealingQueue : Object
{
    public int DangerousCount;
    public int _tailIndex;
    public T[] _array;
    public int _mask;
    public int _addTakeCount;
    public int _stealCount;
    public int _currentOp;
    public bool _frozen;
    public WorkStealingQueue<T> _nextQueue;
    public int _ownerThreadId;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void LocalPush(){} // RVA: 0x7FFAC2E8DC40
    public void TryLocalPop(){} // RVA: 0x7FFAC2C59F60
    public void TrySteal(){}
    public void DangerousCopyTo(){}
    public void get_DangerousCount(){} // RVA: 0x7FFAC2C59960
}

public class WorldFetchParameters : Object
{
    public string Endpoint; // 0x10
    public System.Collections.Generic.Dictionary`2<string,Token> Parameters; // 0x18

    // ── Methods ──
    public void get_Endpoint(){} // RVA: 0x7FFAC2F3C380
    public void set_Endpoint(){} // RVA: 0x7FFAC2F22E30
    public void get_Parameters(){} // RVA: 0x7FFAC2F247C0
    public void set_Parameters(){} // RVA: 0x7FFAC2F87E80
    public void .ctor(){} // RVA: 0x7FFACBEF80E0
}

public class WrappedPropertyDescriptor : PropertyDescriptor
{
    public object Attributes; // 0x88
    public System.ComponentModel.PropertyDescriptor ComponentType; // 0x90

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC944B6F0
    public void get_Attributes(){} // RVA: 0x7FFAC944B810
    public void get_ComponentType(){} // RVA: 0x7FFAC944B840
    public void get_IsReadOnly(){} // RVA: 0x7FFAC944B870
    public void get_PropertyType(){} // RVA: 0x7FFAC944B8A0
    public void CanResetValue(){} // RVA: 0x7FFAC944B8D0
    public void GetValue(){} // RVA: 0x7FFAC944B910
    public void ResetValue(){} // RVA: 0x7FFAC944B950
    public void SetValue(){} // RVA: 0x7FFAC944B990
    public void ShouldSerializeValue(){} // RVA: 0x7FFAC944B9D0
}

public class WriteActionJson : ValueType
{
    public string name; // 0x10
    public string type; // 0x18
    public string id; // 0x20
    public string expectedControlType; // 0x28
    public string processors; // 0x30
    public string interactions; // 0x38
    public bool initialStateCheck; // 0x40

    // ── Methods ──
    public void FromAction(){} // RVA: 0x7FFAC9528350
}

public class WriteCallbackInfo : Object
{
    public System.Type Type; // 0x10
    public string TypeName; // 0x18
    public string TypeNs; // 0x20
    public System.Xml.Serialization.XmlSerializationReadCallback Callback; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class WriteDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class WriteFileJson : ValueType
{
    public string name; // 0x10
    public WriteMapJson[] maps; // 0x18
    public SchemeJson[] controlSchemes; // 0x20
}

public class WriteFileJsonNoName : ValueType
{
    public WriteMapJson[] maps; // 0x10
    public SchemeJson[] controlSchemes; // 0x18
}

public class WriteInstanceDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class WriteMapJson : ValueType
{
    public string name; // 0x10
    public string id; // 0x18
    public WriteActionJson[] actions; // 0x20
    public BindingJson[] bindings; // 0x28

    // ── Methods ──
    public void FromMap(){} // RVA: 0x7FFAC9528600
}

public class WriteMethod : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85F6B90
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC94606E0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class WritePlayerDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6192A30
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC9DEB8C0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}
