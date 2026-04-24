// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 700

public class WIN32_FILE_ATTRIBUTE_DATA : ValueType
{
    public object ftLastAccessTime; // 0x34F3BCF0
    public object nFileSizeLow; // 0x34F3BCF0

    // ── Original Methods ──
    public void PopulateFrom(){} // RVA: 0x7ffaaddab5d0
}

public class WaitAsyncSource : Object
{
    public object nextNode; // 0x30B41A90
    public object cancellationTokenRegistration; // 0x30B41A90
    public object _next; // 0x30B41A90, was: <Cysharp.Threading.Tasks.ITrig
    public object Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.NextNode; // 0x17000007
    public object Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev; // 0x17000008
    public object Cysharp.Threading.Tasks.ITriggerHandler<T>.Next; // 0x17000009

    // ── Original Methods ──
    public void Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.get_NextNode(){} // RVA: 0x7ffaa86491d0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    public void Create(){}
    public void TryReturn(){} // RVA: 0x7ffaa864a040
    public void CancellationCallback(){} // RVA: 0x7ffaa8660d50
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void OnCompleted(){} // RVA: 0x7ffaa8660cc0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x7ffaa86491d0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x7ffaa8660d80
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x7ffaa86491d0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x7ffaa8660d80
    public void OnCanceled(){} // RVA: 0x7ffaa8660f30
    public void OnCompleted(){} // RVA: 0x7ffaa8660cc0
    public void OnError(){} // RVA: 0x7ffaa8660d80
    public void OnNext(){} // RVA: 0x7ffaa887e5c0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WaitAsyncSource : Object
{
    public object nextNode; // 0x30B42600
    public object cancellationTokenRegistration; // 0x30B42600
    public object _next; // 0x30B42600, was: <Cysharp.Threading.Tasks.ITrig
    public object Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.ReadOnlyAsyncReactiveProperty<T>.WaitAsyncSource>.NextNode; // 0x1700000E
    public object Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev; // 0x1700000F
    public object Cysharp.Threading.Tasks.ITriggerHandler<T>.Next; // 0x17000010

    // ── Original Methods ──
    public void Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.ReadOnlyAsyncReactiveProperty<T>.WaitAsyncSource>.get_NextNode(){} // RVA: 0x7ffaa86491d0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    public void Create(){}
    public void TryReturn(){} // RVA: 0x7ffaa864a040
    public void CancellationCallback(){} // RVA: 0x7ffaa8660d50
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void OnCompleted(){} // RVA: 0x7ffaa8660cc0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x7ffaa86491d0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x7ffaa8660d80
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x7ffaa86491d0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x7ffaa8660d80
    public void OnCanceled(){} // RVA: 0x7ffaa8660f30
    public void OnCompleted(){} // RVA: 0x7ffaa8660cc0
    public void OnError(){} // RVA: 0x7ffaa8660d80
    public void OnNext(){} // RVA: 0x7ffaa887e5c0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WaitDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaae0ec020
    public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
}

public class WaitForEndOfFramePromise : Object
{
    public object core; // 0x3418C4B0
    public object cancelImmediately; // 0x3418C4B0

    // ── Original Methods ──
    public void get_NextNode(){} // RVA: 0x7ffaac125af0
    public void .cctor(){} // RVA: 0x7ffaaeeaf6d0
    public void .ctor(){} // RVA: 0x7ffaaeeaf8e0
    public void Create(){} // RVA: 0x7ffaaeeaf8f0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaaeeafe40
    public void OnCompleted(){} // RVA: 0x7ffaaeeafe80
    public void TryReturn(){} // RVA: 0x7ffaaeeaff00
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffaaeeaffb0
    public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7ffaaeeb0010
    public void Reset(){} // RVA: 0x7ffaaeeaf8e0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaaeeafc50
    public void GetStatus(){} // RVA: 0x7ffaaeeafdf0
}

public class WaitForLastPresentationAndUpdateTime : ValueType
{
}

public class WaitUntilCanceledPromise : Object
{
    public object cancellationToken; // 0x3418DAF0
    public object core; // 0x3418DAF0

    // ── Original Methods ──
    public void get_NextNode(){} // RVA: 0x7ffaac125af0
    public void .cctor(){} // RVA: 0x7ffaaeeb4ff0
    public void .ctor(){} // RVA: 0x7ffaa8932310
    public void Create(){} // RVA: 0x7ffaaeeb5170
    public void UnsafeGetStatus(){} // RVA: 0x7ffaaeeb56e0
    public void OnCompleted(){} // RVA: 0x7ffaaeeb5720
    public void MoveNext(){} // RVA: 0x7ffaaeeb57a0
    public void TryReturn(){} // RVA: 0x7ffaaeeb5830
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaaeeb54f0
    public void GetStatus(){} // RVA: 0x7ffaaeeb5690
}

public class WaitUntilPromise : Object
{
    public object predicate; // 0x3418D670
    public object cancelImmediately; // 0x3418D670

    // ── Original Methods ──
    public void get_NextNode(){} // RVA: 0x7ffaac125af0
    public void .cctor(){} // RVA: 0x7ffaaeeb37b0
    public void .ctor(){} // RVA: 0x7ffaa8932310
    public void Create(){} // RVA: 0x7ffaaeeb3930
    public void UnsafeGetStatus(){} // RVA: 0x7ffaaeeb3f70
    public void OnCompleted(){} // RVA: 0x7ffaaeeb3fb0
    public void MoveNext(){} // RVA: 0x7ffaaeeb4030
    public void TryReturn(){} // RVA: 0x7ffaaeeb4140
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaaeeb3d30
    public void GetStatus(){} // RVA: 0x7ffaaeeb3f20
}

public class WaitUntilPromise`1 : Object
{
    public object predicate; // 0x30B42C90
    public object cancellationTokenRegistration; // 0x30B42C90
    public object .cctor; // 0xB3F6FFF0

    // ── Original Methods ──
    public void get_NextNode(){} // RVA: 0x7ffaa86491d0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    public void Create(){} // RVA: 0x7ffaa887e5c0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void TryReturn(){} // RVA: 0x7ffaa864a040
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8660eb0
    public void GetStatus(){}
}

public class WaitUntilValueChangedStandardObjectPromise`2 : Object
{
    public object target; // 0x30B63450
    public object equalityComparer; // 0x30B63450
    public object cancelImmediately; // 0x30B63450

    // ── Original Methods ──
    public void get_NextNode(){} // RVA: 0x7ffaa86491d0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    public void Create(){} // RVA: 0x7ffaa887e5c0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void TryReturn(){} // RVA: 0x7ffaa864a040
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WaitUntilValueChangedUnityObjectPromise`2 : Object
{
    public object target; // 0x30B6A700
    public object monitorFunction; // 0x30B6A700
    public object cancellationTokenRegistration; // 0x30B6A700

    // ── Original Methods ──
    public void get_NextNode(){} // RVA: 0x7ffaa86491d0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    public void Create(){} // RVA: 0x7ffaa887e5c0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void TryReturn(){} // RVA: 0x7ffaa864a040
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WaitWhilePromise : Object
{
    public object predicate; // 0x3418D8B0
    public object cancelImmediately; // 0x3418D8B0

    // ── Original Methods ──
    public void get_NextNode(){} // RVA: 0x7ffaac125af0
    public void .cctor(){} // RVA: 0x7ffaaeeb43d0
    public void .ctor(){} // RVA: 0x7ffaa8932310
    public void Create(){} // RVA: 0x7ffaaeeb4550
    public void UnsafeGetStatus(){} // RVA: 0x7ffaaeeb4b90
    public void OnCompleted(){} // RVA: 0x7ffaaeeb4bd0
    public void MoveNext(){} // RVA: 0x7ffaaeeb4c50
    public void TryReturn(){} // RVA: 0x7ffaaeeb4d60
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaaeeb4950
    public void GetStatus(){} // RVA: 0x7ffaaeeb4b40
}

public class WaitWhilePromise`1 : Object
{
    public object predicate; // 0x30B43050
    public object cancellationTokenRegistration; // 0x30B43050
    public object .cctor; // 0xB3F6FFF0

    // ── Original Methods ──
    public void get_NextNode(){} // RVA: 0x7ffaa86491d0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    public void Create(){} // RVA: 0x7ffaa887e5c0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void TryReturn(){} // RVA: 0x7ffaa864a040
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8660eb0
    public void GetStatus(){}
}

public class Waypoint : ValueType
{
    public object roll; // 0x34B3C7B0
}

public class Waypoint : ValueType
{
    // ── Original Methods ──
    public void get_AsVector4(){} // RVA: 0x7ffaa9f2b290
    public void FromVector4(){} // RVA: 0x7ffaaa219010
}

public class WebFile : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class WellKnownNoReferenceContainsType`1 : Object
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaacd995e0
}

public class WellKnownNoReferenceContainsType`1 : Object
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
}

public class WhenAllPromise : Object
{
    public object core; // 0x3418DD30

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaeeb5a80
    public void TryInvokeContinuation(){} // RVA: 0x7ffaaeeb5d50
    public void UnsafeGetStatus(){} // RVA: 0x7ffaaeeb5f40
    public void OnCompleted(){} // RVA: 0x7ffaaeeb5f80
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaaeeb5e70
    public void GetStatus(){} // RVA: 0x7ffaaeeb5ef0
}

public class WhenAllPromise : Task`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaae107f60
    public void Invoke(){} // RVA: 0x7ffaae108180
    public void get_ShouldNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7ffaae108490
    public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7ffaa8a17850
}

public class WhenAllPromise`1 : Object
{
    public object core; // 0x300D0CA8

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaacd99fc0
    public void TryInvokeContinuation(){} // RVA: 0x7ffaacd9a440
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaacd9a610
    public void UnsafeGetStatus(){} // RVA: 0x7ffaacd9a6d0
    public void OnCompleted(){} // RVA: 0x7ffaacd9a6f0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaacd9a580
    public void GetStatus(){} // RVA: 0x7ffaacd9a6b0
}

public class WhenAllPromise`1 : Object
{
    public object core; // 0x30B412F0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8667cb0
    public void TryInvokeContinuation(){} // RVA: 0x7ffaa8669fb0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8659140
    public void GetStatus(){}
}

public class WhenAllPromise`1 : Task`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void Invoke(){} // RVA: 0x7ffaa8660d80
    public void get_ShouldNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7ffaa864a040
    public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7ffaa864a040
}

public class WhenAllPromise`1 : Object
{
}

public class WhenAllPromise`10 : Object
{
    public object t3; // 0x30B78030
    public object t6; // 0x30B78030
    public object t9; // 0x30B78030
    public object core; // 0x30B78030

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT10(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`11 : Object
{
    public object t3; // 0x30B78710
    public object t6; // 0x30B78710
    public object t9; // 0x30B78710
    public object completedCount; // 0x30B78710

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT10(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT11(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`12 : Object
{
    public object t3; // 0x30B78F70
    public object t6; // 0x30B78F70
    public object t9; // 0x30B78F70
    public object t12; // 0x30B78F70

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT10(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT11(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT12(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`13 : Object
{
    public object t3; // 0x30B797D0
    public object t6; // 0x30B797D0
    public object t9; // 0x30B797D0
    public object t12; // 0x30B797D0
    public object core; // 0x30B797D0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT10(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT11(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT12(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT13(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`14 : Object
{
    public object t3; // 0x30B7A030
    public object t6; // 0x30B7A030
    public object t9; // 0x30B7A030
    public object t12; // 0x30B7A030
    public object completedCount; // 0x30B7A030

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT10(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT11(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT12(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT13(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT14(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`15 : Object
{
    public object t3; // 0x30B7A890
    public object t6; // 0x30B7A890
    public object t9; // 0x30B7A890
    public object t12; // 0x30B7A890
    public object t15; // 0x30B7A890

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT10(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT11(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT12(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT13(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT14(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT15(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`2 : Object
{
    public object completedCount; // 0x30B58F00

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`3 : Object
{
    public object t3; // 0x30B6B830

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`4 : Object
{
    public object t3; // 0x30B704F0
    public object core; // 0x30B704F0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`5 : Object
{
    public object t3; // 0x30B71090
    public object completedCount; // 0x30B71090

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`6 : Object
{
    public object t3; // 0x30B71C30
    public object t6; // 0x30B71C30

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`7 : Object
{
    public object t3; // 0x30B72490
    public object t6; // 0x30B72490
    public object core; // 0x30B72490

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`8 : Object
{
    public object t3; // 0x30B72CF0
    public object t6; // 0x30B72CF0
    public object completedCount; // 0x30B72CF0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAllPromise`9 : Object
{
    public object t3; // 0x30B73550
    public object t6; // 0x30B73550
    public object t9; // 0x30B73550

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyLRPromise`1 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryLeftInvokeContinuation(){} // RVA: 0x7ffaa8660fc0
    public void TryRightInvokeContinuation(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaeeb61a0
    public void TryInvokeContinuation(){} // RVA: 0x7ffaaeeb6460
    public void OnCompleted(){} // RVA: 0x7ffaaeeb6620
    public void UnsafeGetStatus(){} // RVA: 0x7ffaaeeb66a0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaaeeb6550
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaaeeb6550
    public void GetStatus(){} // RVA: 0x7ffaaeeb65d0
}

public class WhenAnyPromise`1 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8667cb0
    public void TryInvokeContinuation(){} // RVA: 0x7ffaa8669fb0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`10 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT10(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`11 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT10(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT11(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`12 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT10(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT11(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT12(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`13 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT10(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT11(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT12(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT13(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`14 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT10(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT11(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT12(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT13(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT14(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`15 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT10(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT11(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT12(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT13(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT14(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT15(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`2 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`2 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaacea70c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaacea7760
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaacea7860
    public void OnCompleted(){} // RVA: 0x7ffaacea7a20
    public void UnsafeGetStatus(){} // RVA: 0x7ffaacea7a50
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaacea7a60
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaacea7970
    public void GetStatus(){} // RVA: 0x7ffaacea7a00
}

public class WhenAnyPromise`3 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`4 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`5 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`6 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`7 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`8 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class WhenAnyPromise`9 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void TryInvokeContinuationT1(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT2(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT3(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT4(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT5(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT6(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT7(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT8(){} // RVA: 0x7ffaa8660fc0
    public void TryInvokeContinuationT9(){} // RVA: 0x7ffaa8660fc0
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class Where : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8669e70
    public void OnCompleted(){} // RVA: 0x7ffaa8660cc0
    public void OnError(){} // RVA: 0x7ffaa8660d80
    public void OnNext(){} // RVA: 0x7ffaa887e5c0
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object index; // 0x300C4B00
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object index; // 0x314CBA60

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8669e70
    public void Clone(){} // RVA: 0x7ffaa86491d0
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaa8649280
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object index; // 0x31FD17F0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaced2540
    public void Clone(){} // RVA: 0x7ffaaced2620
    public void MoveNext(){} // RVA: 0x7ffaaced29f0
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaaced2a90
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object index; // 0x351F6D90

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaced2b10
    public void Clone(){} // RVA: 0x7ffaaced2bf0
    public void MoveNext(){} // RVA: 0x7ffaaced2c60
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaaced2d60
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object index; // 0x35882010

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaced2540
    public void Clone(){} // RVA: 0x7ffaaced2620
    public void MoveNext(){} // RVA: 0x7ffaaced29f0
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaaced2a90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object enumerator; // 0x300C5890
    public object  y20; // 0x150001

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaced2120
    public void Clone(){} // RVA: 0x7ffaaced2200
    public void Dispose(){} // RVA: 0x7ffaaced4c00
    public void MoveNext(){} // RVA: 0x7ffaaced4cb0
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaaced45c0
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object enumerator; // 0x300E17A0
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object enumerator; // 0x31530030

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8669e70
    public void Clone(){} // RVA: 0x7ffaa86491d0
    public void Dispose(){} // RVA: 0x7ffaa8660cc0
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaa8649280
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object enumerator; // 0x31FD2580
    public object  y20; // 0x150001
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object enumerator; // 0x351F7610
    public object  y20; // 0x150001
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object enumerator; // 0x35882DA0
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object enumerator; // 0x37544E70
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object enumerator; // 0x379D33E0
    public object  y20; // 0x150001
}

public class WhereListIterator`1 : Iterator`1
{
    public object enumerator; // 0x300C52B8
}

public class WhereListIterator`1 : Iterator`1
{
    public object enumerator; // 0x31530720

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8669e70
    public void Clone(){} // RVA: 0x7ffaa86491d0
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaa8649280
}

public class WhereListIterator`1 : Iterator`1
{
    public object enumerator; // 0x31FD1FA8
}

public class WhereListIterator`1 : Iterator`1
{
    public object enumerator; // 0x351F71D0
}

public class WhereListIterator`1 : Iterator`1
{
    public object enumerator; // 0x358827C8
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object selector; // 0x300DFDB0
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object selector; // 0x31530960
    public object predicate; // 0x37542428

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa866b2a0
    public void Clone(){} // RVA: 0x7ffaa86491d0
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaa8649280
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object selector; // 0x3591D3E8
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object selector; // 0x37542428

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaacedeeb0
    public void Clone(){} // RVA: 0x7ffaacedefe0
    public void MoveNext(){} // RVA: 0x7ffaacee7060
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaacedf140
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object selector; // 0x300E07D8
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object selector; // 0x31530BA0
    public object predicate; // 0x37543030

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa866b2a0
    public void Clone(){} // RVA: 0x7ffaa86491d0
    public void Dispose(){} // RVA: 0x7ffaa8660cc0
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaa8649280
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object selector; // 0x3591E6F8
    public object  y20; // 0x150001

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaacede760
    public void Clone(){} // RVA: 0x7ffaacede890
    public void Dispose(){} // RVA: 0x7ffaacf2e7b0
    public void MoveNext(){} // RVA: 0x7ffaacf2e860
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaaceea850
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object selector; // 0x37543030
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object selector; // 0x300E0420

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaacedea90
    public void Clone(){} // RVA: 0x7ffaacedebc0
    public void MoveNext(){} // RVA: 0x7ffaacfa3eb0
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaacf8ed10
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object selector; // 0x31530DE0
    public object predicate; // 0x37542B88

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa866b2a0
    public void Clone(){} // RVA: 0x7ffaa86491d0
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaa8649280
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object selector; // 0x3591E0D8
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object selector; // 0x37542B88
}

public class WillRenderCanvases : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8990980
    public void Invoke(){} // RVA: 0x7ffaa8990a50
}

public class WindUpdate : ValueType
{
}

public class WindowFunction : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8a23370
    public void Invoke(){} // RVA: 0x7ffaa898dc60
}

public class WithoutCurrentEnumerable : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    // ── Binary Analysis Named ──
    public void GetAsyncEnumerator(){}
}

public class WithoutCurrentEnumerable : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    // ── Binary Analysis Named ──
    public void GetAsyncEnumerator(){}
}

public class WorkRequest : ValueType
{
    public object m_WaitHandle; // 0x32CE3CA0
    public object Capacity; // 0x170008CD

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa9e95260
    public void Invoke(){} // RVA: 0x7ffaaf2eae50
}

public class WorkStealingQueue : Object
{
    public object _array; // 0x30E1CAF0
    public object _stealCount; // 0x30E1CAF0
    public object _nextQueue; // 0x30E1CAF0
    public object System.Collections.Generic; // 0xB40DC9F0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void LocalPush(){} // RVA: 0x7ffaa887e5c0
    public void TryLocalPop(){} // RVA: 0x7ffaa864a2a0
    public void TrySteal(){}
    public void DangerousCopyTo(){}
    public void get_DangerousCount(){} // RVA: 0x7ffaa8649ca0
}

public class WorkStealingQueue : Object
{
    public object m_headIndex; // 0x3509D410
    public object m_owner; // 0x3509D710

    // ── Original Methods ──
    public void LocalPush(){} // RVA: 0x7ffaae0f09a0
    public void LocalFindAndPop(){} // RVA: 0x7ffaae0f1090
    public void LocalPop(){} // RVA: 0x7ffaae0f1380
    public void TrySteal(){} // RVA: 0x7ffaae0f18a0
    public void TrySteal(){} // RVA: 0x7ffaae0f18a0
    public void .ctor(){} // RVA: 0x7ffaae0f1cc0
}

public class WorldFetchParameters : Object
{
    // ── Original Methods ──
    public void get_Endpoint(){} // RVA: 0x7ffaa894d380
    public void set_Endpoint(){} // RVA: 0x7ffaa8933e30
    public void get_Parameters(){} // RVA: 0x7ffaa89357c0
    public void set_Parameters(){} // RVA: 0x7ffaa8998e80
    public void .ctor(){} // RVA: 0x7ffab1913db0
}

public class WriteDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7ffaa887e5c0
}

public class WriteDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaae017db0
    public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
    public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaae017e90
}

public class WriteFileJson : ValueType
{
    public object controlSchemes; // 0x33B3EEB0
}

public class WriteFileJsonNoName : ValueType
{
}
