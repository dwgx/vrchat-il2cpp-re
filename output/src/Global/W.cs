// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 65
// Methods: 585

public class WIN32_FILE_ATTRIBUTE_DATA : ValueType
{
    public int dwFileAttributes; // 0x10
    public FILE_TIME ftCreationTime; // 0x14
    public FILE_TIME ftLastAccessTime; // 0x1C
    public FILE_TIME ftLastWriteTime; // 0x24
    public uint nFileSizeHigh; // 0x2C
    public uint nFileSizeLow; // 0x30

    // ── Methods ──
    public void PopulateFrom(){} // RVA: 0x7FFD537AA420
}

public class WaitAsyncSource : Object
{
    public System.Action`1<object> Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.NextNode;
    public Cysharp.Threading.Tasks.TaskPool`1<WaitAsyncSource<T>> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev;
    public WaitAsyncSource<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next;
    public Cysharp.Threading.Tasks.ReadOnlyAsyncReactiveProperty`1<T> parent;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<T> core;
    public Cysharp.Threading.Tasks.ITriggerHandler`1<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField;
    public Cysharp.Threading.Tasks.ITriggerHandler`1<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField;

    // ── Methods ──
    public void Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.get_NextNode(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Create(){}
    public void TryReturn(){} // RVA: 0x7FFD4E079D00
    public void CancellationCallback(){} // RVA: 0x7FFD4E090A10
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void OnCompleted(){} // RVA: 0x7FFD4E090980 | overloaded x2
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x7FFD4E078E90
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x7FFD4E090A40
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x7FFD4E078E90
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x7FFD4E090A40
    public void OnCanceled(){} // RVA: 0x7FFD4E090BF0
    public void OnError(){} // RVA: 0x7FFD4E090A40
    public void OnNext(){} // RVA: 0x7FFD4E2ADC40
}

public class WaitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53AEAE10
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
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
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548AD700
    public void .ctor(){} // RVA: 0x7FFD548AD910
    public void Create(){} // RVA: 0x7FFD548AD920
    public void GetResult(){} // RVA: 0x7FFD548ADC80
    public void GetStatus(){} // RVA: 0x7FFD548ADE20
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548ADE70
    public void OnCompleted(){} // RVA: 0x7FFD548ADEB0
    public void TryReturn(){} // RVA: 0x7FFD548ADF30
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD548ADFE0
    public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFD548AE040
    public void Reset(){} // RVA: 0x7FFD548AD910
}

public class WaitForLastPresentationAndUpdateTime : ValueType
{
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
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548B3020
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Create(){} // RVA: 0x7FFD548B31A0
    public void GetResult(){} // RVA: 0x7FFD548B3520
    public void GetStatus(){} // RVA: 0x7FFD548B36C0
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B3710
    public void OnCompleted(){} // RVA: 0x7FFD548B3750
    public void MoveNext(){} // RVA: 0x7FFD548B37D0
    public void TryReturn(){} // RVA: 0x7FFD548B3860
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
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548B17E0
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Create(){} // RVA: 0x7FFD548B1960
    public void GetResult(){} // RVA: 0x7FFD548B1D60
    public void GetStatus(){} // RVA: 0x7FFD548B1F50
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B1FA0
    public void OnCompleted(){} // RVA: 0x7FFD548B1FE0
    public void MoveNext(){} // RVA: 0x7FFD548B2060
    public void TryReturn(){} // RVA: 0x7FFD548B2170
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
    public void get_NextNode(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Create(){} // RVA: 0x7FFD4E2ADC40
    public void GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void TryReturn(){} // RVA: 0x7FFD4E079D00
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
    public void get_NextNode(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Create(){} // RVA: 0x7FFD4E2ADC40
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void TryReturn(){} // RVA: 0x7FFD4E079D00
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
    public void get_NextNode(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Create(){} // RVA: 0x7FFD4E2ADC40
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void TryReturn(){} // RVA: 0x7FFD4E079D00
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
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548B2400
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Create(){} // RVA: 0x7FFD548B2580
    public void GetResult(){} // RVA: 0x7FFD548B2980
    public void GetStatus(){} // RVA: 0x7FFD548B2B70
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B2BC0
    public void OnCompleted(){} // RVA: 0x7FFD548B2C00
    public void MoveNext(){} // RVA: 0x7FFD548B2C80
    public void TryReturn(){} // RVA: 0x7FFD548B2D90
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
    public void get_NextNode(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Create(){} // RVA: 0x7FFD4E2ADC40
    public void GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void TryReturn(){} // RVA: 0x7FFD4E079D00
}

public class Waypoint : ValueType
{
    public UnityEngine.Vector3 position; // 0x10
    public float roll; // 0x1C
}

public class WebFile : Object
{
    public byte[] data; // 0x10
    public string path; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class WellKnownNoReferenceContainsType`1 : Object
{
    public bool IsWellKnownType;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD527A58C0
}

public class WhenAllPromise : Object
{
    public System.Threading.Tasks.Task[] m_tasks; // 0x58
    public int m_count; // 0x60

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD548B3AB0
    public void TryInvokeContinuation(){} // RVA: 0x7FFD548B3D80
    public void GetResult(){} // RVA: 0x7FFD548B3EA0
    public void GetStatus(){} // RVA: 0x7FFD548B3F20
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B3F70
    public void OnCompleted(){} // RVA: 0x7FFD548B3FB0
}

public class WhenAllPromise`1 : Object
{
    public VRC.Core.ApiInventoryItem[] m_tasks; // 0x10
    public int m_count; // 0x18
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<VRC.Core.ApiInventoryItem[]> core; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD527A62A0
    public void TryInvokeContinuation(){} // RVA: 0x7FFD527A6720
    public void GetResult(){} // RVA: 0x7FFD527A6860
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD527A68F0
    public void GetStatus(){} // RVA: 0x7FFD527A6990
    public void UnsafeGetStatus(){} // RVA: 0x7FFD527A69B0
    public void OnCompleted(){} // RVA: 0x7FFD527A69D0
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT15(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`2 : Object
{
    public U t1;
    public T t2;
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`2<U,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAnyLRPromise`1 : Object
{
    public int completedCount; // 0x10
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`2<bool,System.ValueTuple`2<bool,ÍÌÌÏÍÎÎÎÎÍÍÏÏÌÎÌÎÌÍÏÎÎÍ>>> core; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryLeftInvokeContinuation(){} // RVA: 0x7FFD4E090C80
    public void TryRightInvokeContinuation(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise : Object
{
    public int completedCount; // 0x10
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<int> core; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD548B41D0
    public void TryInvokeContinuation(){} // RVA: 0x7FFD548B4490
    public void GetResult(){} // RVA: 0x7FFD548B4580
    public void GetStatus(){} // RVA: 0x7FFD548B4600
    public void OnCompleted(){} // RVA: 0x7FFD548B4650
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B46D0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD548B4580
}

public class WhenAnyPromise`1 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`2<int,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E097970
    public void TryInvokeContinuation(){} // RVA: 0x7FFD4E099C70
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`10 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`4<T7,T8,T9,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`11 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`5<T7,T8,T9,T10,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`12 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`6<T7,T8,T9,T10,T11,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`13 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`7<T7,T8,T9,T10,T11,T12,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`14 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`8<T7,T8,T9,T10,T11,T12,T13,System.ValueTuple`1<T>>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`15 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`8<T7,T8,T9,T10,T11,T12,T13,System.ValueTuple`2<T14,T>>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT15(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`2 : Object
{
    public int completedCount; // 0x10
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`3<int,System.ValueTuple`2<bool,UnityEngine.GameObject>,bool>> core; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`3 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`4<int,U,V,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`4 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`5<int,U,V,W,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`5 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`6<int,U,V,W,T4,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`6 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`7<int,U,V,W,T4,T5,T>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`7 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`1<T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`8 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`2<T7,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`9 : Object
{
    public int completedCount;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<System.ValueTuple`8<int,U,V,W,T4,T5,T6,System.ValueTuple`3<T7,T8,T>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class Where : Object
{
    public UnityEngine.InputSystem.Utilities.WhereObservable`1<T> m_Observable;
    public System.IObserver`1<T> m_Observer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void OnCompleted(){} // RVA: 0x7FFD4E090980
    public void OnError(){} // RVA: 0x7FFD4E090A40
    public void OnNext(){} // RVA: 0x7FFD4E2ADC40
}

public class WhereArrayIterator`1 : Iterator`1
{
    public 0x66560390[] source; // 0x20
    public System.Func`2<0x66560390,bool> predicate; // 0x28
    public int index; // 0x30
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public System.Collections.Generic.IEnumerable`1<float> source; // 0x20
    public System.Func`2<float,bool> predicate; // 0x28
    public System.Collections.Generic.IEnumerator`1<float> enumerator; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD528E15E0
    public void Clone(){} // RVA: 0x7FFD528E16C0
    public void Dispose(){} // RVA: 0x7FFD528E40C0
    public void MoveNext(){} // RVA: 0x7FFD528E4170
    public void Select(){} // RVA: 0x7FFD4E078F40
    public void Where(){} // RVA: 0x7FFD528E3A80
}

public class WhereListIterator`1 : Iterator`1
{
    public System.Collections.Generic.List`1<0x66560390> source; // 0x20
    public System.Func`2<0x66560390,bool> predicate; // 0x28
    public Enumerator<0x66560390> enumerator; // 0x30
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public VRC.SDKBase.Network.VRCNetworkBehaviour[] source; // 0x20
    public System.Func`2<VRC.SDKBase.Network.VRCNetworkBehaviour,bool> predicate; // 0x28
    public System.Func`2<VRC.SDKBase.Network.VRCNetworkBehaviour,string> selector; // 0x30
    public int index; // 0x38
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public System.Collections.Generic.IEnumerable`1<VRC.SDKBase.Network.VRCNetworkBehaviour> source; // 0x20
    public System.Func`2<VRC.SDKBase.Network.VRCNetworkBehaviour,bool> predicate; // 0x28
    public System.Func`2<VRC.SDKBase.Network.VRCNetworkBehaviour,string> selector; // 0x30
    public System.Collections.Generic.IEnumerator`1<VRC.SDKBase.Network.VRCNetworkBehaviour> enumerator; // 0x38
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public System.Collections.Generic.List`1<VRC.SDKBase.Network.VRCNetworkBehaviour> source; // 0x20
    public System.Func`2<VRC.SDKBase.Network.VRCNetworkBehaviour,bool> predicate; // 0x28
    public System.Func`2<VRC.SDKBase.Network.VRCNetworkBehaviour,string> selector; // 0x30
    public Enumerator<VRC.SDKBase.Network.VRCNetworkBehaviour> enumerator; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD528EDF50
    public void Clone(){} // RVA: 0x7FFD528EE080
    public void MoveNext(){} // RVA: 0x7FFD529B9A50
    public void Select(){} // RVA: 0x7FFD4E078F40
    public void Where(){} // RVA: 0x7FFD529A48B0
}

public class WillRenderCanvases : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class WindUpdate : ValueType
{
}

public class WindowFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E432370
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class WithoutCurrentEnumerable : Object
{
    public Cysharp.Threading.Tasks.ReadOnlyAsyncReactiveProperty`1<T> parent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetAsyncEnumerator(){}
}

public class WorkRequest : ValueType
{
    public System.Threading.SendOrPostCallback m_DelagateCallback; // 0x10
    public object m_DelagateState; // 0x18
    public System.Threading.ManualResetEvent m_WaitHandle; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F88FCC0
    public void Invoke(){} // RVA: 0x7FFD54CE8EF0
}

public class WorkStealingQueue : Object
{
    public System.Threading.IThreadPoolWorkItem[] DangerousCount; // 0x10
    public int m_mask; // 0x18
    public int m_headIndex; // 0x1C
    public int m_tailIndex; // 0x20
    public System.Threading.SpinLock m_foreignLock; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void LocalPush(){} // RVA: 0x7FFD4E2ADC40
    public void TryLocalPop(){} // RVA: 0x7FFD4E079F60
    public void TrySteal(){}
    public void DangerousCopyTo(){}
    public void get_DangerousCount(){} // RVA: 0x7FFD4E079960
}

public class WorldFetchParameters : Object
{
    public string Endpoint; // 0x10
    public System.Collections.Generic.Dictionary`2<string,Token> Parameters; // 0x18

    // ── Methods ──
    public void get_Endpoint(){} // RVA: 0x7FFD4E35C380
    public void set_Endpoint(){} // RVA: 0x7FFD4E342E30
    public void get_Parameters(){} // RVA: 0x7FFD4E3447C0
    public void set_Parameters(){} // RVA: 0x7FFD4E3A7E80
    public void .ctor(){} // RVA: 0x7FFD573180E0
}

public class WriteDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class WriteFileJson : ValueType
{
    public string name; // 0x10
    public 0x664A5AC8[] maps; // 0x18
    public 0x664A6D58[] controlSchemes; // 0x20
}

public class WriteFileJsonNoName : ValueType
{
    public 0x664A5AC8[] maps; // 0x10
    public 0x664A6D58[] controlSchemes; // 0x18
}
