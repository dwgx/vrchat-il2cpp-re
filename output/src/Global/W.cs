// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 93
// Methods: 672

public class WIN32_FILE_ATTRIBUTE_DATA : ValueType
{
    // ── Methods ──
    public void PopulateFrom(){} // RVA: 0x7FFE86733D20
}

public class WIN32_FIND_DATA : ValueType
{
    public uint dwFileAttributes; // 0x10

    // ── Methods ──
    public void get_cFileName(){} // RVA: 0x7FFE86733940
    public void SetFileName(){} // RVA: 0x7FFE86733990
}

public class WSABUF : ValueType
{
}

public class WTauNafCallback : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE828378F0
    public void Precompute(){} // RVA: 0x7FFE89EDAE10
}

public class WaitAsyncSource : Object
{
    public System.Action`1<object> cancellationCallback;
    public Cysharp.Threading.Tasks.TaskPool`1<WaitAsyncSource<T>> pool;
    public WaitAsyncSource<T> nextNode;

    // ── Methods ──
    public void Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.get_NextNode(){} // RVA: 0x7FFE80E2E2E0
    public void .cctor(){} // RVA: 0x7FFE80E46010
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void Create(){}
    public void TryReturn(){} // RVA: 0x7FFE80E2F150
    public void CancellationCallback(){} // RVA: 0x7FFE80E46070
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void OnCompleted(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x7FFE80E2E2E0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x7FFE80E460A0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x7FFE80E2E2E0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x7FFE80E460A0
    public void OnCanceled(){} // RVA: 0x7FFE80E46250
    public void OnError(){} // RVA: 0x7FFE80E460A0
    public void OnNext(){} // RVA: 0x7FFE810A1420
}

public class WaitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86A745C0
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class WaitForAudioCaptureDeviceAuthorisation : CustomYieldInstruction
{
    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFE86DC58B0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class WaitForAuthorisationToAccessPhotos : CustomYieldInstruction
{
    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFE86DC5910
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class WaitForCompletion : CustomYieldInstruction
{
    public DG.Tweening.Tween t; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFE82C1C300
    public void .ctor(){} // RVA: 0x7FFE810FCE30
}

public class WaitForElapsedLoops : CustomYieldInstruction
{
    public DG.Tweening.Tween t; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFE82C1C3D0
    public void .ctor(){} // RVA: 0x7FFE82AF3A20
}

public class WaitForEndOfFramePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitForEndOfFramePromise> pool;
    public WaitForEndOfFramePromise nextNode; // 0x10

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE87835E40
    public void .ctor(){} // RVA: 0x7FFE87836050
    public void Create(){} // RVA: 0x7FFE87836060
    public void GetResult(){} // RVA: 0x7FFE878363C0
    public void GetStatus(){} // RVA: 0x7FFE87836560
    public void UnsafeGetStatus(){} // RVA: 0x7FFE878365B0
    public void OnCompleted(){} // RVA: 0x7FFE878365F0
    public void TryReturn(){} // RVA: 0x7FFE87836670
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE87836720
    public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFE87836780
    public void Reset(){} // RVA: 0x7FFE87836050
}

public class WaitForKill : CustomYieldInstruction
{
    public DG.Tweening.Tween t; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFE82C1C3B0
    public void .ctor(){} // RVA: 0x7FFE810FCE30
}

public class WaitForLastPresentationAndUpdateTime : ValueType
{
}

public class WaitForPosition : CustomYieldInstruction
{
    public DG.Tweening.Tween t; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFE82C1C410
    public void .ctor(){} // RVA: 0x7FFE82C1C460
}

public class WaitForRewind : CustomYieldInstruction
{
    public DG.Tweening.Tween t; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFE82C1C340
    public void .ctor(){} // RVA: 0x7FFE810FCE30
}

public class WaitForStart : CustomYieldInstruction
{
    public DG.Tweening.Tween t; // 0x10

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x7FFE82C1C4C0
    public void .ctor(){} // RVA: 0x7FFE810FCE30
}

public class WaitUntilCanceledPromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilCanceledPromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE8783B760
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Create(){} // RVA: 0x7FFE8783B8E0
    public void GetResult(){} // RVA: 0x7FFE8783BC60
    public void GetStatus(){} // RVA: 0x7FFE8783BE00
    public void UnsafeGetStatus(){} // RVA: 0x7FFE8783BE50
    public void OnCompleted(){} // RVA: 0x7FFE8783BE90
    public void MoveNext(){} // RVA: 0x7FFE8783BF10
    public void TryReturn(){} // RVA: 0x7FFE8783BFA0
}

public class WaitUntilPromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilPromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE87839F20
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Create(){} // RVA: 0x7FFE8783A0A0
    public void GetResult(){} // RVA: 0x7FFE8783A4A0
    public void GetStatus(){} // RVA: 0x7FFE8783A690
    public void UnsafeGetStatus(){} // RVA: 0x7FFE8783A6E0
    public void OnCompleted(){} // RVA: 0x7FFE8783A720
    public void MoveNext(){} // RVA: 0x7FFE8783A7A0
    public void TryReturn(){} // RVA: 0x7FFE8783A8B0
}

public class WaitUntilPromise`1 : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilPromise`1<T>> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE80E2E2E0
    public void .cctor(){} // RVA: 0x7FFE80E46010
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void Create(){} // RVA: 0x7FFE810A1420
    public void GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void TryReturn(){} // RVA: 0x7FFE80E2F150
}

public class WaitUntilValueChangedStandardObjectPromise`2 : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilValueChangedStandardObjectPromise`2<U,T>> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE80E2E2E0
    public void .cctor(){} // RVA: 0x7FFE80E46010
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void Create(){} // RVA: 0x7FFE810A1420
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void TryReturn(){} // RVA: 0x7FFE80E2F150
}

public class WaitUntilValueChangedUnityObjectPromise`2 : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitUntilValueChangedUnityObjectPromise`2<U,U>> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE80E2E2E0
    public void .cctor(){} // RVA: 0x7FFE80E46010
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void Create(){} // RVA: 0x7FFE810A1420
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void TryReturn(){} // RVA: 0x7FFE80E2F150
}

public class WaitWhilePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitWhilePromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE8783AB40
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Create(){} // RVA: 0x7FFE8783ACC0
    public void GetResult(){} // RVA: 0x7FFE8783B0C0
    public void GetStatus(){} // RVA: 0x7FFE8783B2B0
    public void UnsafeGetStatus(){} // RVA: 0x7FFE8783B300
    public void OnCompleted(){} // RVA: 0x7FFE8783B340
    public void MoveNext(){} // RVA: 0x7FFE8783B3C0
    public void TryReturn(){} // RVA: 0x7FFE8783B4D0
}

public class WaitWhilePromise`1 : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<WaitWhilePromise`1<T>> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE80E2E2E0
    public void .cctor(){} // RVA: 0x7FFE80E46010
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void Create(){} // RVA: 0x7FFE810A1420
    public void GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void TryReturn(){} // RVA: 0x7FFE80E2F150
}

public class WapiP192V1Holder : X9ECParametersHolder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void CreateParameters(){} // RVA: 0x7FFE8A2049D0
    public void .cctor(){} // RVA: 0x7FFE8A204BB0
}

public class Waypoint : ValueType
{
}

public class WaypointList : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81104D60
}

public class WeakKeyComparer : Object
{
    // ── Methods ──
    public void System.Collections.IEqualityComparer.Equals(){} // RVA: 0x7FFE877F2320
    public void System.Collections.IEqualityComparer.GetHashCode(){} // RVA: 0x7FFE81407EB0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class WebFile : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class WebSocketReceiveResultGetter : ValueType
{
    // ── Methods ──
    public void GetResult(){} // RVA: 0x7FFE876FDC50
}

public class WeightCurve : Object
{
    // ── Methods ──
    public void GetValue(){} // RVA: 0x7FFE81251320
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class WeightInfo : ValueType
{
}

public class WellKnownNoReferenceContainsType`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class WhenAllPromise : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8783C1F0
    public void TryInvokeContinuation(){} // RVA: 0x7FFE8783C4C0
    public void GetResult(){} // RVA: 0x7FFE8783C5E0
    public void GetStatus(){} // RVA: 0x7FFE8783C660
    public void UnsafeGetStatus(){} // RVA: 0x7FFE8783C6B0
    public void OnCompleted(){} // RVA: 0x7FFE8783C6F0
}

public class WhenAllPromise`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4D070
    public void TryInvokeContinuation(){} // RVA: 0x7FFE80E4F370
    public void GetResult(){} // RVA: 0x7FFE80E3E250
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`10 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`11 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`12 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`13 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`14 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`15 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT15(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`2 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`3 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`4 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`5 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`6 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`7 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`8 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAllPromise`9 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
}

public class WhenAnyLRPromise`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryLeftInvokeContinuation(){} // RVA: 0x7FFE80E462E0
    public void TryRightInvokeContinuation(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8783C910
    public void TryInvokeContinuation(){} // RVA: 0x7FFE8783CBD0
    public void GetResult(){} // RVA: 0x7FFE8783CCC0
    public void GetStatus(){} // RVA: 0x7FFE8783CD40
    public void OnCompleted(){} // RVA: 0x7FFE8783CD90
    public void UnsafeGetStatus(){} // RVA: 0x7FFE8783CE10
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE8783CCC0
}

public class WhenAnyPromise`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4D070
    public void TryInvokeContinuation(){} // RVA: 0x7FFE80E4F370
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`10 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`11 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`12 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`13 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`14 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`15 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT15(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`2 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE85856140
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE858567E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE858569C0
    public void GetResult(){} // RVA: 0x7FFE85856B40
    public void GetStatus(){} // RVA: 0x7FFE85856BF0
    public void OnCompleted(){} // RVA: 0x7FFE85856C10
    public void UnsafeGetStatus(){} // RVA: 0x7FFE85856C40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE85856C50
}

public class WhenAnyPromise`3 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`4 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`5 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`6 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`7 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`8 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class WhenAnyPromise`9 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFE80E462E0
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFE80E462E0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
}

public class Where : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4F230
    public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
    public void OnError(){} // RVA: 0x7FFE80E460A0
    public void OnNext(){} // RVA: 0x7FFE810A1420
}

public class WhereArrayIterator`1 : Iterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4F230
    public void Clone(){} // RVA: 0x7FFE80E2E2E0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Select(){} // RVA: 0x7FFE80E2E390
    public void Where(){} // RVA: 0x7FFE80E2E390
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4F230
    public void Clone(){} // RVA: 0x7FFE80E2E2E0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Select(){} // RVA: 0x7FFE80E2E390
    public void Where(){} // RVA: 0x7FFE80E2E390
}

public class WhereListIterator`1 : Iterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4F230
    public void Clone(){} // RVA: 0x7FFE80E2E2E0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Select(){} // RVA: 0x7FFE80E2E390
    public void Where(){} // RVA: 0x7FFE80E2E390
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E50660
    public void Clone(){} // RVA: 0x7FFE80E2E2E0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Select(){} // RVA: 0x7FFE80E2E390
    public void Where(){} // RVA: 0x7FFE80E2E390
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E50660
    public void Clone(){} // RVA: 0x7FFE80E2E2E0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Select(){} // RVA: 0x7FFE80E2E390
    public void Where(){} // RVA: 0x7FFE80E2E390
}

public class WhereSelectListIterator`2 : Iterator`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E50660
    public void Clone(){} // RVA: 0x7FFE80E2E2E0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Select(){} // RVA: 0x7FFE80E2E390
    public void Where(){} // RVA: 0x7FFE80E2E390
}

public class WidthProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFE87D4F020
    public void .ctor(){} // RVA: 0x7FFE87D4F060
}

public class WillRenderCanvases : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81159980
    public void Invoke(){} // RVA: 0x7FFE81159A50
}

public class WindUpdate : ValueType
{
}

public class WindowFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811EC370
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class WindowsCancelHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8400E360
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class WindowsConsole : Object
{
    // ── Methods ──
    public void GetConsoleCP(){} // RVA: 0x7FFE86A424D0
    public void GetConsoleOutputCP(){} // RVA: 0x7FFE86A42540
    public void DoWindowsConsoleCancelEvent(){} // RVA: 0x7FFE86A425B0
    public void GetInputCodePage(){} // RVA: 0x7FFE86A42610
    public void GetOutputCodePage(){} // RVA: 0x7FFE86A426B0
    public void .cctor(){} // RVA: 0x7FFE86A42750
}

public class WithSyncContext : CancellationCallbackInfo
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86A69190
}

public class WithoutCurrentEnumerable : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void GetAsyncEnumerator(){}
}

public class WorkRequest : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82760A10
    public void Invoke(){} // RVA: 0x7FFE87C71620
}

public class WorkStealingQueue : Object
{
    public int _headIndex;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void LocalPush(){} // RVA: 0x7FFE810A1420
    public void TryLocalPop(){} // RVA: 0x7FFE80E2F3B0
    public void TrySteal(){}
    public void DangerousCopyTo(){}
    public void get_DangerousCount(){} // RVA: 0x7FFE80E2EDB0
}

public class WorldFetchParameters : Object
{
    public string _endpoint; // 0x10
    public System.Collections.Generic.Dictionary`2<string,Token> _parameters; // 0x18

    // ── Methods ──
    public void get_Endpoint(){} // RVA: 0x7FFE81116380
    public void set_Endpoint(){} // RVA: 0x7FFE810FCE30
    public void get_Parameters(){} // RVA: 0x7FFE810FE7C0
    public void set_Parameters(){} // RVA: 0x7FFE81161E80
    public void .ctor(){} // RVA: 0x7FFE8A358140
}

public class WrappedPropertyDescriptor : PropertyDescriptor
{
    public object target; // 0x88
    public System.ComponentModel.PropertyDescriptor property; // 0x90
    public object field_2; // 0x31C
    public object field_3; // 0x31D

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE877F3E30
    public void get_Attributes(){} // RVA: 0x7FFE877F3F50
    public void get_ComponentType(){} // RVA: 0x7FFE877F3F80
    public void get_IsReadOnly(){} // RVA: 0x7FFE877F3FB0
    public void get_PropertyType(){} // RVA: 0x7FFE877F3FE0
    public void CanResetValue(){} // RVA: 0x7FFE877F4010
    public void GetValue(){} // RVA: 0x7FFE877F4050
    public void ResetValue(){} // RVA: 0x7FFE877F4090
    public void SetValue(){} // RVA: 0x7FFE877F40D0
    public void ShouldSerializeValue(){} // RVA: 0x7FFE877F4110
}

public class WriteActionJson : ValueType
{
    // ── Methods ──
    public void FromAction(){} // RVA: 0x7FFE878D0A90
}

public class WriteCallbackInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class WriteDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}

public class WriteFileJson : ValueType
{
}

public class WriteFileJsonNoName : ValueType
{
}

public class WriteInstanceDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE82886970
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class WriteMapJson : ValueType
{
    // ── Methods ──
    public void FromMap(){} // RVA: 0x7FFE878D0D40
}

public class WriteMethod : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE869A0360
    public void Invoke(){} // RVA: 0x7FFE812574E0
    public void BeginInvoke(){} // RVA: 0x7FFE87808E20
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class WritePlayerDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84423E50
    public void Invoke(){} // RVA: 0x7FFE81998A70
    public void BeginInvoke(){} // RVA: 0x7FFE88190670
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}
