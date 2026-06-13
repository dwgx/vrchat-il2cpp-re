// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 696

public class WIN32_FILE_ATTRIBUTE_DATA
{
    // ── Methods ──
    public void PopulateFrom(){} // RVA: 0x5BF2ED0
}

public class WIN32_FIND_DATA
{
    public uint dwFileAttributes; // 0x10

    // ── Methods ──
    public void get_cFileName(){} // RVA: 0x5BF2AF0
    public void SetFileName(){} // RVA: 0x5BF2B40
}

public class WSABUF
{
}

public class WTauNafCallback : `
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1AB41A0
    public void Precompute(){} // RVA: 0x9478A40
}

public class WaitAsyncSource
{
    public System.Action`1<object> cancellationCallback;
    public Cysharp.Threading.Tasks.TaskPool`1<WaitAsyncSource<T>> pool;
    public WaitAsyncSource<T> nextNode;

    // ── Methods ──
    public void Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.get_NextNode(){} // RVA: 0xCD60
    public void .cctor(){} // RVA: 0x24A80
    public void .ctor(){} // RVA: 0x24A50
    public void Create(){}
    public void TryReturn(){} // RVA: 0xDBE0
    public void CancellationCallback(){} // RVA: 0x24AE0
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void OnCompleted(){} // RVA: 0x24A50 | overloaded x2
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0xCD60
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x24B10
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0xCD60
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x24B10
    public void OnCanceled(){} // RVA: 0x24CC0
    public void OnError(){} // RVA: 0x24B10
    public void OnNext(){} // RVA: 0x283FA0
}

public class WaitAsyncSource
{
    public System.Action`1<object> cancellationCallback;
    public Cysharp.Threading.Tasks.TaskPool`1<WaitAsyncSource<T>> pool;
    public WaitAsyncSource<T> nextNode;

    // ── Methods ──
    public void Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.ReadOnlyAsyncReactiveProperty<T>.WaitAsyncSource>.get_NextNode(){} // RVA: 0xCD60
    public void .cctor(){} // RVA: 0x24A80
    public void .ctor(){} // RVA: 0x24A50
    public void Create(){}
    public void TryReturn(){} // RVA: 0xDBE0
    public void CancellationCallback(){} // RVA: 0x24AE0
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void OnCompleted(){} // RVA: 0x24A50 | overloaded x2
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0xCD60
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x24B10
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0xCD60
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x24B10
    public void OnCanceled(){} // RVA: 0x24CC0
    public void OnError(){} // RVA: 0x24B10
    public void OnNext(){} // RVA: 0x283FA0
}

public class WaitDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5F337A0
    public void Invoke(){} // RVA: 0x4394E0
}

public class WaitForAudioCaptureDeviceAuthorisation
{
    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x6284E80
    public void .ctor(){} // RVA: 0x2DD310
}

public class WaitForAuthorisationToAccessPhotos
{
    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x6284EE0
    public void .ctor(){} // RVA: 0x2DD310
}

public class WaitForCompletion
{
    public DG.Tweening.Tween t; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x1E92BA0
    public void .ctor(){} // RVA: 0x2DEE30
}

public class WaitForElapsedLoops
{
    public DG.Tweening.Tween t; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x1E92C70
    public void .ctor(){} // RVA: 0x1D66A50
}

public class WaitForEndOfFramePromise
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitForEndOfFramePromise> pool;
    public WaitForEndOfFramePromise nextNode; // 0x10

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x3DF6A30
    public void .cctor(){} // RVA: 0x6CF4FA0
    public void .ctor(){} // RVA: 0x6CF51B0
    public void Create(){} // RVA: 0x6CF51C0
    public void GetResult(){} // RVA: 0x6CF5520
    public void GetStatus(){} // RVA: 0x6CF56C0
    public void UnsafeGetStatus(){} // RVA: 0x6CF5710
    public void OnCompleted(){} // RVA: 0x6CF5750
    public void TryReturn(){} // RVA: 0x6CF57D0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x6CF5880
    public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x6CF58E0
    public void Reset(){} // RVA: 0x6CF51B0
}

public class WaitForKill
{
    public DG.Tweening.Tween t; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x1E92C50
    public void .ctor(){} // RVA: 0x2DEE30
}

public class WaitForLastPresentationAndUpdateTime
{
}

public class WaitForPosition
{
    public DG.Tweening.Tween t; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x1E92CB0
    public void .ctor(){} // RVA: 0x1E92D00
}

public class WaitForRewind
{
    public DG.Tweening.Tween t; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x1E92BE0
    public void .ctor(){} // RVA: 0x2DEE30
}

public class WaitForStart
{
    public DG.Tweening.Tween t; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x1E92D60
    public void .ctor(){} // RVA: 0x2DEE30
}

public class WaitUntilCanceledPromise
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilCanceledPromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x3DF6A30
    public void .cctor(){} // RVA: 0x6CFA8C0
    public void .ctor(){} // RVA: 0x2DD310
    public void Create(){} // RVA: 0x6CFAA40
    public void GetResult(){} // RVA: 0x6CFADC0
    public void GetStatus(){} // RVA: 0x6CFAF60
    public void UnsafeGetStatus(){} // RVA: 0x6CFAFB0
    public void OnCompleted(){} // RVA: 0x6CFAFF0
    public void MoveNext(){} // RVA: 0x6CFB070
    public void TryReturn(){} // RVA: 0x6CFB100
}

public class WaitUntilPromise
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilPromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x3DF6A30
    public void .cctor(){} // RVA: 0x6CF9080
    public void .ctor(){} // RVA: 0x2DD310
    public void Create(){} // RVA: 0x6CF9200
    public void GetResult(){} // RVA: 0x6CF9600
    public void GetStatus(){} // RVA: 0x6CF97F0
    public void UnsafeGetStatus(){} // RVA: 0x6CF9840
    public void OnCompleted(){} // RVA: 0x6CF9880
    public void MoveNext(){} // RVA: 0x6CF9900
    public void TryReturn(){} // RVA: 0x6CF9A10
}

public class WaitUntilPromise`1
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilPromise`1<T>> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0xCD60
    public void .cctor(){} // RVA: 0x24A80
    public void .ctor(){} // RVA: 0x24A50
    public void Create(){} // RVA: 0x283FA0
    public void GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0xDBE0
    public void TryReturn(){} // RVA: 0xDBE0
}

public class WaitUntilValueChangedStandardObjectPromise`2
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilValueChangedStandardObjectPromise`2<U,T>> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0xCD60
    public void .cctor(){} // RVA: 0x24A80
    public void .ctor(){} // RVA: 0x24A50
    public void Create(){} // RVA: 0x283FA0
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0xDBE0
    public void TryReturn(){} // RVA: 0xDBE0
}

public class WaitUntilValueChangedUnityObjectPromise`2
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilValueChangedUnityObjectPromise`2<U,U>> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0xCD60
    public void .cctor(){} // RVA: 0x24A80
    public void .ctor(){} // RVA: 0x24A50
    public void Create(){} // RVA: 0x283FA0
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0xDBE0
    public void TryReturn(){} // RVA: 0xDBE0
}

public class WaitWhilePromise
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitWhilePromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x3DF6A30
    public void .cctor(){} // RVA: 0x6CF9CA0
    public void .ctor(){} // RVA: 0x2DD310
    public void Create(){} // RVA: 0x6CF9E20
    public void GetResult(){} // RVA: 0x6CFA220
    public void GetStatus(){} // RVA: 0x6CFA410
    public void UnsafeGetStatus(){} // RVA: 0x6CFA460
    public void OnCompleted(){} // RVA: 0x6CFA4A0
    public void MoveNext(){} // RVA: 0x6CFA520
    public void TryReturn(){} // RVA: 0x6CFA630
}

public class WaitWhilePromise`1
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitWhilePromise`1<T>> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0xCD60
    public void .cctor(){} // RVA: 0x24A80
    public void .ctor(){} // RVA: 0x24A50
    public void Create(){} // RVA: 0x283FA0
    public void GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0xDBE0
    public void TryReturn(){} // RVA: 0xDBE0
}

public class WapiP192V1Holder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DD310
    public void CreateParameters(){} // RVA: 0x97A25D0
    public void .cctor(){} // RVA: 0x97A27B0
}

public class Waypoint
{
    public UnityEngine.Vector3 position; // 0x10
}

public class Waypoint
{
    public UnityEngine.Vector3 position; // 0x10

    // ── Methods ──
    public void get_AsVector4(){} // RVA: 0x1A53750
    public void FromVector4(){} // RVA: 0x1CEB620
}

public class WaypointList
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2E6D60
}

public class WeakKeyComparer
{
    // ── Methods ──
    public void System.Collections.IEqualityComparer.Equals(){} // RVA: 0x6CB1470
    public void System.Collections.IEqualityComparer.GetHashCode(){} // RVA: 0x604140
    public void .ctor(){} // RVA: 0x2DD310
}

public class WebFile
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DD310
}

public class WebSocketReceiveResultGetter
{
    // ── Methods ──
    public void GetResult(){} // RVA: 0x6BBE9A0
}

public class WeightCurve
{
    // ── Methods ──
    public void GetValue(){} // RVA: 0x433320
    public void .ctor(){} // RVA: 0x2DD310
}

public class WeightInfo
{
}

public class WellKnownNoReferenceContainsType`1
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x4B5F290
}

public class WellKnownNoReferenceContainsType`1
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x24A80
}

public class WellKnownNoReferenceContainsType`1
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x4B5F3B0
}

public class WellKnownNoReferenceContainsType`1
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x4B5F170
}

public class WhenAllPromise
{
    public System.Threading.Tasks.Task[] m_tasks; // 0x58
    public int m_count; // 0x60

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6CFB350
    public void TryInvokeContinuation(){} // RVA: 0x6CFB620
    public void GetResult(){} // RVA: 0x6CFB740
    public void GetStatus(){} // RVA: 0x6CFB7C0
    public void UnsafeGetStatus(){} // RVA: 0x6CFB810
    public void OnCompleted(){} // RVA: 0x6CFB850
}

public class WhenAllPromise
{
    public System.Threading.Tasks.Task[] m_tasks; // 0x58
    public int m_count; // 0x60

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5F4F6E0
    public void Invoke(){} // RVA: 0x5F4F900
    public void get_ShouldNotifyDebuggerOfWaitCompletion(){} // RVA: 0x5F4FC10
    public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x3C2850
}

public class WhenAllPromise`1
{
    public System.Threading.Tasks.Task`1<T>[] m_tasks;
    public int m_count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4B603C0
    public void TryInvokeContinuation(){} // RVA: 0x4B60840
    public void GetResult(){} // RVA: 0x4B60980
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x4B60A10
    public void GetStatus(){} // RVA: 0x4B5FCD0
    public void UnsafeGetStatus(){} // RVA: 0x4B5FCF0
    public void OnCompleted(){} // RVA: 0x4B5FD10
}

public class WhenAllPromise`1
{
    public System.Threading.Tasks.Task`1<T>[] m_tasks;
    public int m_count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BAA0
    public void TryInvokeContinuation(){} // RVA: 0x2DDA0
    public void GetResult(){} // RVA: 0x1CCE0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`1
{
    public System.Threading.Tasks.Task`1<T>[] m_tasks;
    public int m_count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x24B10
    public void Invoke(){} // RVA: 0x24B10
    public void get_ShouldNotifyDebuggerOfWaitCompletion(){} // RVA: 0xDBE0
    public void get_InvokeMayRunArbitraryCode(){} // RVA: 0xDBE0
}

public class WhenAllPromise`1
{
    public System.Threading.Tasks.Task`1<T>[] m_tasks;
    public int m_count;
}

public class WhenAllPromise`1
{
    public System.Threading.Tasks.Task`1<T>[] m_tasks;
    public int m_count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4B603C0
    public void TryInvokeContinuation(){} // RVA: 0x4B60840
    public void GetResult(){} // RVA: 0x4B60980
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x4B60A10
    public void GetStatus(){} // RVA: 0x4B5FCD0
    public void UnsafeGetStatus(){} // RVA: 0x4B5FCF0
    public void OnCompleted(){} // RVA: 0x4B5FD10
}

public class WhenAllPromise`10
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void TryInvokeContinuationT10(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`11
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void TryInvokeContinuationT10(){} // RVA: 0x24D50
    public void TryInvokeContinuationT11(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`12
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void TryInvokeContinuationT10(){} // RVA: 0x24D50
    public void TryInvokeContinuationT11(){} // RVA: 0x24D50
    public void TryInvokeContinuationT12(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`13
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void TryInvokeContinuationT10(){} // RVA: 0x24D50
    public void TryInvokeContinuationT11(){} // RVA: 0x24D50
    public void TryInvokeContinuationT12(){} // RVA: 0x24D50
    public void TryInvokeContinuationT13(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`14
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void TryInvokeContinuationT10(){} // RVA: 0x24D50
    public void TryInvokeContinuationT11(){} // RVA: 0x24D50
    public void TryInvokeContinuationT12(){} // RVA: 0x24D50
    public void TryInvokeContinuationT13(){} // RVA: 0x24D50
    public void TryInvokeContinuationT14(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`15
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void TryInvokeContinuationT10(){} // RVA: 0x24D50
    public void TryInvokeContinuationT11(){} // RVA: 0x24D50
    public void TryInvokeContinuationT12(){} // RVA: 0x24D50
    public void TryInvokeContinuationT13(){} // RVA: 0x24D50
    public void TryInvokeContinuationT14(){} // RVA: 0x24D50
    public void TryInvokeContinuationT15(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`3
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`4
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`5
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`6
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`7
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`8
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAllPromise`9
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
}

public class WhenAnyLRPromise`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryLeftInvokeContinuation(){} // RVA: 0x24D50
    public void TryRightInvokeContinuation(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyLRPromise`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4BF7330
    public void TryLeftInvokeContinuation(){} // RVA: 0x4BF7AC0
    public void TryRightInvokeContinuation(){} // RVA: 0x4BF7C70
    public void GetResult(){} // RVA: 0x4BF7E10
    public void GetStatus(){} // RVA: 0x4BF7ED0
    public void OnCompleted(){} // RVA: 0x4BF7EF0
    public void UnsafeGetStatus(){} // RVA: 0x4BF7F20
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x4BF7F30
}

public class WhenAnyLRPromise`1
{
}

public class WhenAnyPromise
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6CFBA70
    public void TryInvokeContinuation(){} // RVA: 0x6CFBD30
    public void GetResult(){} // RVA: 0x6CFBE20
    public void GetStatus(){} // RVA: 0x6CFBEA0
    public void OnCompleted(){} // RVA: 0x6CFBEF0
    public void UnsafeGetStatus(){} // RVA: 0x6CFBF70
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x6CFBE20
}

public class WhenAnyPromise`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BAA0
    public void TryInvokeContinuation(){} // RVA: 0x2DDA0
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`10
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void TryInvokeContinuationT10(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`11
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void TryInvokeContinuationT10(){} // RVA: 0x24D50
    public void TryInvokeContinuationT11(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`12
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void TryInvokeContinuationT10(){} // RVA: 0x24D50
    public void TryInvokeContinuationT11(){} // RVA: 0x24D50
    public void TryInvokeContinuationT12(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`13
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void TryInvokeContinuationT10(){} // RVA: 0x24D50
    public void TryInvokeContinuationT11(){} // RVA: 0x24D50
    public void TryInvokeContinuationT12(){} // RVA: 0x24D50
    public void TryInvokeContinuationT13(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`14
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void TryInvokeContinuationT10(){} // RVA: 0x24D50
    public void TryInvokeContinuationT11(){} // RVA: 0x24D50
    public void TryInvokeContinuationT12(){} // RVA: 0x24D50
    public void TryInvokeContinuationT13(){} // RVA: 0x24D50
    public void TryInvokeContinuationT14(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`15
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void TryInvokeContinuationT10(){} // RVA: 0x24D50
    public void TryInvokeContinuationT11(){} // RVA: 0x24D50
    public void TryInvokeContinuationT12(){} // RVA: 0x24D50
    public void TryInvokeContinuationT13(){} // RVA: 0x24D50
    public void TryInvokeContinuationT14(){} // RVA: 0x24D50
    public void TryInvokeContinuationT15(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4C65420
    public void TryInvokeContinuationT1(){} // RVA: 0x4C65AC0
    public void TryInvokeContinuationT2(){} // RVA: 0x4C65BC0
    public void GetResult(){} // RVA: 0x4C65CD0
    public void GetStatus(){} // RVA: 0x4C65D60
    public void OnCompleted(){} // RVA: 0x4C65D80
    public void UnsafeGetStatus(){} // RVA: 0x4C65DB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x4C65DC0
}

public class WhenAnyPromise`2
{
}

public class WhenAnyPromise`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4C64870
    public void TryInvokeContinuationT1(){} // RVA: 0x4C64F10
    public void TryInvokeContinuationT2(){} // RVA: 0x4C650F0
    public void GetResult(){} // RVA: 0x4C65270
    public void GetStatus(){} // RVA: 0x4C65320
    public void OnCompleted(){} // RVA: 0x4C65340
    public void UnsafeGetStatus(){} // RVA: 0x4C65370
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x4C65380
}

public class WhenAnyPromise`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4C63E20
    public void TryInvokeContinuationT1(){} // RVA: 0x4C644C0
    public void TryInvokeContinuationT2(){} // RVA: 0x4C645C0
    public void GetResult(){} // RVA: 0x4C646E0
    public void GetStatus(){} // RVA: 0x4C64770
    public void OnCompleted(){} // RVA: 0x4C64790
    public void UnsafeGetStatus(){} // RVA: 0x4C647C0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x4C647D0
}

public class WhenAnyPromise`3
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`4
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`5
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`6
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`7
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`8
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class WhenAnyPromise`9
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void TryInvokeContinuationT1(){} // RVA: 0x24D50
    public void TryInvokeContinuationT2(){} // RVA: 0x24D50
    public void TryInvokeContinuationT3(){} // RVA: 0x24D50
    public void TryInvokeContinuationT4(){} // RVA: 0x24D50
    public void TryInvokeContinuationT5(){} // RVA: 0x24D50
    public void TryInvokeContinuationT6(){} // RVA: 0x24D50
    public void TryInvokeContinuationT7(){} // RVA: 0x24D50
    public void TryInvokeContinuationT8(){} // RVA: 0x24D50
    public void TryInvokeContinuationT9(){} // RVA: 0x24D50
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
}

public class Where
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DC60
    public void OnCompleted(){} // RVA: 0x24A50
    public void OnError(){} // RVA: 0x24B10
    public void OnNext(){} // RVA: 0x283FA0
}

public class WhereArrayIterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DC60
    public void Clone(){} // RVA: 0xCD60
    public void MoveNext(){} // RVA: 0xDBE0
    public void Select(){} // RVA: 0xCE10
    public void Where(){} // RVA: 0xCE10
}

public class WhereArrayIterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4C911B0
    public void Clone(){} // RVA: 0x4C91290
    public void MoveNext(){} // RVA: 0x4C91300
    public void Select(){} // RVA: 0xCE10
    public void Where(){} // RVA: 0x4C91400
}

public class WhereArrayIterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4C90BE0
    public void Clone(){} // RVA: 0x4C90CC0
    public void MoveNext(){} // RVA: 0x4C91090
    public void Select(){} // RVA: 0xCE10
    public void Where(){} // RVA: 0x4C91130
}

public class WhereArrayIterator`1
{
}

public class WhereArrayIterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4C90BE0
    public void Clone(){} // RVA: 0x4C90CC0
    public void MoveNext(){} // RVA: 0x4C91090
    public void Select(){} // RVA: 0xCE10
    public void Where(){} // RVA: 0x4C91130
}

public class WhereArrayIterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4C90BE0
    public void Clone(){} // RVA: 0x4C90CC0
    public void MoveNext(){} // RVA: 0x4C91090
    public void Select(){} // RVA: 0xCE10
    public void Where(){} // RVA: 0x4C91130
}

public class WhereArrayIterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4C90BE0
    public void Clone(){} // RVA: 0x4C90CC0
    public void MoveNext(){} // RVA: 0x4C91090
    public void Select(){} // RVA: 0xCE10
    public void Where(){} // RVA: 0x4C91130
}

public class WhereArrayIterator`1
{
}

public class WhereArrayIterator`1
{
}

public class WhereArrayIterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4C90BE0
    public void Clone(){} // RVA: 0x4C90CC0
    public void MoveNext(){} // RVA: 0x4C91090
    public void Select(){} // RVA: 0xCE10
    public void Where(){} // RVA: 0x4C91130
}

public class WhereArrayIterator`1
{
}

public class WhereArrayIterator`1
{
}

public class WhereArrayIterator`1
{
}

public class WhereArrayIterator`1
{
}

public class WhereArrayIterator`1
{
}

public class WhereArrayIterator`1
{
}

public class WhereArrayIterator`1
{
}

public class WhereArrayIterator`1
{
}
