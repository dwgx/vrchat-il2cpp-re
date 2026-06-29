// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 378

public class WTauNafCallback : Object
{
    public object m_p;
    public object m_a;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x237A5A0
    public void Precompute(){} // RVA: 0xA118330
}

public class WaitAsyncSource : Object
{
    public object cancellationCallback;
    public object pool;
    public object nextNode;
    public object parent;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object core;
    public object _prev;
    public object _next;

    // ── Methods ──
    public void Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.get_NextNode(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
    public void .ctor(){} // RVA: 0x894290
    public void TryReturn(){} // RVA: 0x87D280
    public void CancellationCallback(){} // RVA: 0x894350
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void OnCompleted(){} // RVA: 0x894290
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x87C0A0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x894320
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x87C0A0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x894320
    public void OnCanceled(){} // RVA: 0x8943F0
    public void OnError(){} // RVA: 0x894320
    public void OnNext(){} // RVA: 0xA94080
}

public class WaitAsyncSource : Object
{
    public object cancellationCallback;
    public object pool;
    public object nextNode;
    public object parent;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object core;
    public object _prev;
    public object _next;

    // ── Methods ──
    public void Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.ReadOnlyAsyncReactiveProperty<T>.WaitAsyncSource>.get_NextNode(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
    public void .ctor(){} // RVA: 0x894290
    public void TryReturn(){} // RVA: 0x87D280
    public void CancellationCallback(){} // RVA: 0x894350
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void OnCompleted(){} // RVA: 0x894290
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x87C0A0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x894320
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x87C0A0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x894320
    public void OnCanceled(){} // RVA: 0x8943F0
    public void OnError(){} // RVA: 0x894320
    public void OnNext(){} // RVA: 0xA94080
}

public class WaitForEndOfFramePromise : Object
{
    public object pool;
    public object nextNode;
    public object core;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object cancelImmediately;
    public object waitForEndOfFrameYieldInstruction;
    public object isFirst;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x4865E00
    public void .cctor(){} // RVA: 0x7752FF0
    public void .ctor(){} // RVA: 0x77531D0
    public void Create(){} // RVA: 0x77531E0
    public void GetResult(){} // RVA: 0x7753540
    public void GetStatus(){} // RVA: 0x77536E0
    public void UnsafeGetStatus(){} // RVA: 0x7753730
    public void OnCompleted(){} // RVA: 0x7753770
    public void TryReturn(){} // RVA: 0x77537F0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x77538A0
    public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7753900
    public void Reset(){} // RVA: 0x77531D0
}

public class WaitUntilCanceledPromise : Object
{
    public object pool;
    public object nextNode;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object cancelImmediately;
    public object core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x4865E00
    public void .cctor(){} // RVA: 0x7758760
    public void .ctor(){} // RVA: 0xB43310
    public void Create(){} // RVA: 0x77588A0
    public void GetResult(){} // RVA: 0x7758C20
    public void GetStatus(){} // RVA: 0x7758DC0
    public void UnsafeGetStatus(){} // RVA: 0x7758E10
    public void OnCompleted(){} // RVA: 0x7758E50
    public void MoveNext(){} // RVA: 0x7758ED0
    public void TryReturn(){} // RVA: 0x7758F60
}

public class WaitUntilPromise`1 : Object
{
    public object pool;
    public object nextNode;
    public object predicate;
    public object argument;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object cancelImmediately;
    public object core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
    public void .ctor(){} // RVA: 0x894290
    public void Create(){} // RVA: 0xA94080
    public void GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
    public void MoveNext(){} // RVA: 0x87D280
    public void TryReturn(){} // RVA: 0x87D280
}

public class WaitUntilValueChangedStandardObjectPromise`2 : Object
{
    public object pool;
    public object nextNode;
    public object target;
    public object currentValue;
    public object monitorFunction;
    public object equalityComparer;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object cancelImmediately;
    public object core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
    public void .ctor(){} // RVA: 0x894290
    public void Create(){} // RVA: 0xA94080
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
    public void MoveNext(){} // RVA: 0x87D280
    public void TryReturn(){} // RVA: 0x87D280
}

public class WaitUntilValueChangedUnityObjectPromise`2 : Object
{
    public object pool;
    public object nextNode;
    public object target;
    public object targetAsUnityObject;
    public object currentValue;
    public object monitorFunction;
    public object equalityComparer;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object cancelImmediately;
    public object core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
    public void .ctor(){} // RVA: 0x894290
    public void Create(){} // RVA: 0xA94080
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
    public void MoveNext(){} // RVA: 0x87D280
    public void TryReturn(){} // RVA: 0x87D280
}

public class WaitWhilePromise : Object
{
    public object pool;
    public object nextNode;
    public object predicate;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object cancelImmediately;
    public object core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x4865E00
    public void .cctor(){} // RVA: 0x7757B80
    public void .ctor(){} // RVA: 0xB43310
    public void Create(){} // RVA: 0x7757CC0
    public void GetResult(){} // RVA: 0x77580C0
    public void GetStatus(){} // RVA: 0x77582B0
    public void UnsafeGetStatus(){} // RVA: 0x7758300
    public void OnCompleted(){} // RVA: 0x7758340
    public void MoveNext(){} // RVA: 0x77583C0
    public void TryReturn(){} // RVA: 0x77584D0
}

public class WaitWhilePromise`1 : Object
{
    public object pool;
    public object nextNode;
    public object predicate;
    public object argument;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object cancelImmediately;
    public object core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x87C0A0
    public void .cctor(){} // RVA: 0x8942F0
    public void .ctor(){} // RVA: 0x894290
    public void Create(){} // RVA: 0xA94080
    public void GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
    public void MoveNext(){} // RVA: 0x87D280
    public void TryReturn(){} // RVA: 0x87D280
}

public class WapiP192V1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA448520
    public void .cctor(){} // RVA: 0xA448700
}

public class WaypointList : Object
{
    public object circuit;
    public object items;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB4CD10
}

public class WebTextureResource : BaseTextureResource
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26500E0
    public void Unload(){} // RVA: 0x265B550
}

public class WeightCurve : Object
{
    public object type;
    public object curve;

    // ── Methods ──
    public void GetValue(){} // RVA: 0xCA2B30
    public void .ctor(){} // RVA: 0xB43310
}

public class WeightCurve[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class WhenAllPromise : Object
{
    public object completeCount;
    public object tasksLength;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x77591B0
    public void TryInvokeContinuation(){} // RVA: 0x7759480
    public void GetResult(){} // RVA: 0x77595A0
    public void GetStatus(){} // RVA: 0x7759620
    public void UnsafeGetStatus(){} // RVA: 0x7759670
    public void OnCompleted(){} // RVA: 0x77596B0
}

public class WhenAllPromise`1 : Object
{
    public object result;
    public object completeCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x899290
    public void TryInvokeContinuation(){} // RVA: 0x89DC30
    public void GetResult(){} // RVA: 0x87C500
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`2 : Object
{
    public object t1;
    public object t2;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAnyLRPromise`1 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x56C5980
    public void TryLeftInvokeContinuation(){} // RVA: 0x56C6110
    public void TryRightInvokeContinuation(){} // RVA: 0x56C62C0
    public void GetResult(){} // RVA: 0x56C6470
    public void GetStatus(){} // RVA: 0x56C6530
    public void OnCompleted(){} // RVA: 0x56C6550
    public void UnsafeGetStatus(){} // RVA: 0x56C6580
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x56C6590
}

public class Where : Object
{
    public object m_Observable;
    public object m_Observer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8943B0
    public void OnCompleted(){} // RVA: 0x894290
    public void OnError(){} // RVA: 0x894320
    public void OnNext(){} // RVA: 0xA94080
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
    public void Clone(){} // RVA: 0x575F070
    public void MoveNext(){} // RVA: 0x575F440
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x575F4E0
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EB70
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575E780
    public void Clone(){} // RVA: 0x575E860
    public void Dispose(){} // RVA: 0x57602D0
    public void MoveNext(){} // RVA: 0x5760380
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x5760570
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void Clone(){} // RVA: 0x575F070
    public void Dispose(){} // RVA: 0x5766360
    public void MoveNext(){} // RVA: 0x5766410
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x57665C0
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
    public void Clone(){} // RVA: 0x575F070
    public void Dispose(){} // RVA: 0x5762140
    public void MoveNext(){} // RVA: 0x57621F0
    public void Select(){} // RVA: 0x2D2C800
    public void Where(){} // RVA: 0x5762390
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EB70
    public void Clone(){} // RVA: 0x575EC50
    public void Dispose(){} // RVA: 0x57635E0
    public void MoveNext(){} // RVA: 0x5763690
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x5760E90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5764260
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
    public void Clone(){} // RVA: 0x575F070
    public void Dispose(){} // RVA: 0x5766360
    public void MoveNext(){} // RVA: 0x5766410
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x57665C0
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EB70
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
    public void Clone(){} // RVA: 0x575F070
    public void Dispose(){} // RVA: 0x5766360
    public void MoveNext(){} // RVA: 0x5766410
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x57665C0
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereListIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereListIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
    public void Clone(){} // RVA: 0x575F070
    public void MoveNext(){} // RVA: 0x576A260
    public void Select(){} // RVA: 0x2D2C800
    public void Where(){} // RVA: 0x576A420
}

public class WhereListIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereListIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereListIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EB70
}

public class WhereListIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
    public void Clone(){} // RVA: 0x575F070
    public void MoveNext(){} // RVA: 0x576A260
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x576A420
}

public class WhereListIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereListIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B400
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5796DE0
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void Clone(){} // RVA: 0x576B950
    public void MoveNext(){} // RVA: 0x579B4B0
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x576BAB0
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B400
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void MoveNext(){} // RVA: 0x579B4B0
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x576BAB0
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void Dispose(){} // RVA: 0x5806C40
    public void MoveNext(){} // RVA: 0x5806CF0
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x57A0960
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void Dispose(){} // RVA: 0x57B1760
    public void MoveNext(){} // RVA: 0x57B1810
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x57A0960
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B400
    public void Clone(){} // RVA: 0x576B530
    public void Dispose(){} // RVA: 0x5804AD0
    public void MoveNext(){} // RVA: 0x5804B80
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x579ED80
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5796DE0
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void Dispose(){} // RVA: 0x5806C40
    public void MoveNext(){} // RVA: 0x5806CF0
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x57A0960
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B400
    public void Clone(){} // RVA: 0x576B530
    public void Dispose(){} // RVA: 0x579F410
    public void MoveNext(){} // RVA: 0x579F4C0
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x579ED80
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void Dispose(){} // RVA: 0x57DD370
    public void MoveNext(){} // RVA: 0x57DD420
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x57A0960
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void MoveNext(){} // RVA: 0x585C190
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x581B120
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void MoveNext(){} // RVA: 0x585C190
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x581B120
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B400
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5796DE0
    public void Clone(){} // RVA: 0x5796F10
    public void MoveNext(){} // RVA: 0x584C970
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x584CB70
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void MoveNext(){} // RVA: 0x585C190
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x581B120
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B400
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void MoveNext(){} // RVA: 0x585BDD0
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x581B120
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void MoveNext(){} // RVA: 0x585C540
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x581B120
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhitelistGroup[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class WithoutCurrentEnumerable : Object
{
    public object parent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void GetAsyncEnumerator(){} // RVA: 0x881D60
}

public class WithoutCurrentEnumerable : Object
{
    public object parent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void GetAsyncEnumerator(){} // RVA: 0x881D60
}

public class WorldFetchParameters : Object
{
    public object _endpoint;
    public object _parameters;

    // ── Methods ──
    public void get_Endpoint(){} // RVA: 0xB5DBF0
    public void set_Endpoint(){} // RVA: 0xB44D60
    public void get_Parameters(){} // RVA: 0xB465B0
    public void set_Parameters(){} // RVA: 0xBA9BA0
    public void .ctor(){} // RVA: 0xA5A30F0
}

public class WriteActionJson : ValueType
{
    public object name;
    public object type;
    public object id;
    public object expectedControlType;
    public object processors;
    public object interactions;
    public object initialStateCheck;

    // ── Methods ──
    public void FromAction(){} // RVA: 0x77E74F0
}

public class WriteDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0xA94080
}

public class WriteFileJson : ValueType
{
    public object maps;

    // ── Methods ──
    public void FromMap(){} // RVA: 0x77E7D40
    public void FromMaps(){} // RVA: 0x77E7E90
}

public class WriteInstanceDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2697880
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x23E7ED0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class WriteMapJson : ValueType
{
    public object name;
    public object id;
    public object actions;
    public object bindings;

    // ── Methods ──
    public void FromMap(){} // RVA: 0x77E77A0
}

public class WritePlayerDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E4960
    public void Invoke(){} // RVA: 0x14CC9D0
    public void BeginInvoke(){} // RVA: 0x828CF70
    public void EndInvoke(){} // RVA: 0xB44BE0
}
