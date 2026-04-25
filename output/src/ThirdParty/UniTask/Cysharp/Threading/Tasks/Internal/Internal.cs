// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Internal
// Classes: 29
// Methods: 176

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Internal
{
    public class ArrayPoolUtil : Object
    {
        // ── Methods ──
        public void EnsureCapacity(){} // RVA: 0x7FFAC2C70D10
        public void EnsureCapacityCore(){} // RVA: 0x7FFAC2C70D10
        public void Materialize(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ArrayPool`1 : Object
    {
        public int DefaultMaxNumberOfArraysPerBucket;
        public Cysharp.Threading.Tasks.UniTask`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>[] EmptyArray;
        public Cysharp.Threading.Tasks.Internal.ArrayPool`1<Cysharp.Threading.Tasks.UniTask`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>> Shared; // 0x8
        public Cysharp.Threading.Tasks.Internal.MinimumQueue`1<Cysharp.Threading.Tasks.UniTask`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>[]>[] buckets; // 0x10
        public System.Threading.SpinLock[] locks; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6381650
        public void Rent(){} // RVA: 0x7FFAC63818D0
        public void Return(){} // RVA: 0x7FFAC6381BD0
        public void CalculateSize(){} // RVA: 0x7FFAC630ACB0
        public void GetQueueIndex(){} // RVA: 0x7FFAC630ACF0
        public void .cctor(){} // RVA: 0x7FFAC6381DE0
    }

    public class ArrayUtil : Object
    {
        // ── Methods ──
        public void EnsureCapacity(){} // RVA: 0x7FFAC2C76370
        public void EnsureCore(){} // RVA: 0x7FFAC2C76370
        public void Materialize(){} // RVA: 0x7FFAC2E8DC40
    }

    public class AsyncSubject`1 : Object
    {
        public object Value;
        public T HasObservers;
        public bool IsCompleted;
        public bool isStopped;
        public bool isDisposed;
        public System.Exception lastError;
        public System.IObserver`1<T> outObserver;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
        public void get_HasObservers(){} // RVA: 0x7FFAC2C59D00
        public void get_IsCompleted(){} // RVA: 0x7FFAC2C59D00
        public void OnCompleted(){} // RVA: 0x7FFAC2C70980
        public void OnError(){} // RVA: 0x7FFAC2C70A40
        public void OnNext(){} // RVA: 0x7FFAC2E8DC40
        public void Subscribe(){} // RVA: 0x7FFAC2C58F40
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void ThrowIfDisposed(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ContinuationQueue : Object
    {
        public int MaxArrayLength;
        public int InitialSize;
        public 0x6B1DD918 timing; // 0x10
        public System.Threading.SpinLock gate; // 0x14
        public bool dequing; // 0x18
        public int actionListCount; // 0x1C
        public System.Action[] actionList; // 0x20
        public int waitingListCount; // 0x28
        public System.Action[] waitingList; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94F6A30
        public void Enqueue(){} // RVA: 0x7FFAC94F6B60
        public void Clear(){} // RVA: 0x7FFAC94F70F0
        public void Run(){} // RVA: 0x7FFAC94F7230
        public void Initialization(){} // RVA: 0x7FFAC94F7230
        public void LastInitialization(){} // RVA: 0x7FFAC94F7230
        public void EarlyUpdate(){} // RVA: 0x7FFAC94F7230
        public void LastEarlyUpdate(){} // RVA: 0x7FFAC94F7230
        public void FixedUpdate(){} // RVA: 0x7FFAC94F7230
        public void LastFixedUpdate(){} // RVA: 0x7FFAC94F7230
        public void PreUpdate(){} // RVA: 0x7FFAC94F7230
        public void LastPreUpdate(){} // RVA: 0x7FFAC94F7230
        public void Update(){} // RVA: 0x7FFAC94F7230
        public void LastUpdate(){} // RVA: 0x7FFAC94F7230
        public void PreLateUpdate(){} // RVA: 0x7FFAC94F7230
        public void LastPreLateUpdate(){} // RVA: 0x7FFAC94F7230
        public void PostLateUpdate(){} // RVA: 0x7FFAC94F7230
        public void LastPostLateUpdate(){} // RVA: 0x7FFAC94F7230
        public void TimeUpdate(){} // RVA: 0x7FFAC94F7230
        public void LastTimeUpdate(){} // RVA: 0x7FFAC94F7230
        public void RunCore(){} // RVA: 0x7FFAC94F7240
    }

    public class DiagnosticsExtensions : Object
    {
        public bool displayFilenames;
        public System.Text.RegularExpressions.Regex typeBeautifyRegex; // 0x8
        public System.Collections.Generic.Dictionary`2<System.Type,string> builtInTypeNames; // 0x10

        // ── Methods ──
        public void CleanupAsyncStackTrace(){} // RVA: 0x7FFAC94F7610
        public void IsAsync(){} // RVA: 0x7FFAC94F7E00
        public void TryResolveStateMachineMethod(){} // RVA: 0x7FFAC94F7F00
        public void BeautifyType(){} // RVA: 0x7FFAC94F8290
        public void IgnoreLine(){} // RVA: 0x7FFAC94F8950
        public void AppendHyperLink(){} // RVA: 0x7FFAC94F8B30
        public void .cctor(){} // RVA: 0x7FFAC94F8E50
    }

    public class DisposedObserver`1 : Object
    {
        public Cysharp.Threading.Tasks.Internal.DisposedObserver`1<T> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void OnCompleted(){} // RVA: 0x7FFAC2C70980
        public void OnError(){} // RVA: 0x7FFAC2C70A40
        public void OnNext(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class EmptyDisposable : Object
    {
        public Cysharp.Threading.Tasks.Internal.EmptyDisposable Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC94FD9E0
    }

    public class EmptyObserver`1 : Object
    {
        public Cysharp.Threading.Tasks.Internal.EmptyObserver`1<T> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void OnCompleted(){} // RVA: 0x7FFAC2C70980
        public void OnError(){} // RVA: 0x7FFAC2C70A40
        public void OnNext(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class Error : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7FFAC2E8DC40
        public void ThrowArgumentNullExceptionCore(){} // RVA: 0x7FFAC94F9F70
        public void ArgumentOutOfRange(){} // RVA: 0x7FFAC94F9FC0
        public void NoElements(){} // RVA: 0x7FFAC94FA050
        public void MoreThanOneElement(){} // RVA: 0x7FFAC94FA0C0
        public void ThrowArgumentException(){} // RVA: 0x7FFAC94FA130
        public void ThrowNotYetCompleted(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ThrowWhenContinuationIsAlreadyRegistered(){} // RVA: 0x7FFAC2E8DC40
        public void ThrowInvalidOperationExceptionCore(){} // RVA: 0x7FFAC94FA1D0
        public void ThrowOperationCanceledException(){} // RVA: 0x7FFAC94FA220
    }

    public class ImmutableList`1 : Object
    {
        public Cysharp.Threading.Tasks.Internal.ImmutableList`1<T> Data;
        public T[] data;

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ListObserver`1 : Object
    {
        public Cysharp.Threading.Tasks.Internal.ImmutableList`1<System.IObserver`1<T>> _observers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void OnCompleted(){} // RVA: 0x7FFAC2C70980
        public void OnError(){} // RVA: 0x7FFAC2C70A40
        public void OnNext(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2C58F40
        public void Remove(){} // RVA: 0x7FFAC2C58F40
    }

    public class MinimumQueue`1 : Object
    {
        public int Count;
        public int GrowFactor;
        public Cysharp.Threading.Tasks.UniTask`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>[][] array; // 0x10
        public int head; // 0x18
        public int tail; // 0x1C
        public int size; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6538920
        public void get_Count(){} // RVA: 0x7FFAC30DBBE0
        public void Peek(){} // RVA: 0x7FFAC6538A10
        public void Enqueue(){} // RVA: 0x7FFAC630B110
        public void Dequeue(){} // RVA: 0x7FFAC630B080
        public void Grow(){} // RVA: 0x7FFAC6538A70
        public void SetCapacity(){} // RVA: 0x7FFAC6538BE0
        public void MoveNext(){} // RVA: 0x7FFAC6538D20
        public void ThrowForEmptyQueue(){} // RVA: 0x7FFAC6538D50
    }

    public class PlayerLoopRunner : Object
    {
        public int InitialSize;
        public 0x6B1DD918 timing; // 0x10
        public object runningAndQueueLock; // 0x18
        public object arrayLock; // 0x20
        public System.Action`1<System.Exception> unhandledExceptionCallback; // 0x28
        public int tail; // 0x30
        public bool running; // 0x34
        public Cysharp.Threading.Tasks.IPlayerLoopItem[] loopItems; // 0x38
        public Cysharp.Threading.Tasks.Internal.MinimumQueue`1<Cysharp.Threading.Tasks.IPlayerLoopItem> waitQueue; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94FA260
        public void AddAction(){} // RVA: 0x7FFAC94FA5E0
        public void Clear(){} // RVA: 0x7FFAC94FA9F0
        public void Run(){} // RVA: 0x7FFAC94FABB0
        public void Initialization(){} // RVA: 0x7FFAC94FABB0
        public void LastInitialization(){} // RVA: 0x7FFAC94FABB0
        public void EarlyUpdate(){} // RVA: 0x7FFAC94FABB0
        public void LastEarlyUpdate(){} // RVA: 0x7FFAC94FABB0
        public void FixedUpdate(){} // RVA: 0x7FFAC94FABB0
        public void LastFixedUpdate(){} // RVA: 0x7FFAC94FABB0
        public void PreUpdate(){} // RVA: 0x7FFAC94FABB0
        public void LastPreUpdate(){} // RVA: 0x7FFAC94FABB0
        public void Update(){} // RVA: 0x7FFAC94FABB0
        public void LastUpdate(){} // RVA: 0x7FFAC94FABB0
        public void PreLateUpdate(){} // RVA: 0x7FFAC94FABB0
        public void LastPreLateUpdate(){} // RVA: 0x7FFAC94FABB0
        public void PostLateUpdate(){} // RVA: 0x7FFAC94FABB0
        public void LastPostLateUpdate(){} // RVA: 0x7FFAC94FABB0
        public void TimeUpdate(){} // RVA: 0x7FFAC94FABB0
        public void LastTimeUpdate(){} // RVA: 0x7FFAC94FABB0
        public void RunCore(){} // RVA: 0x7FFAC94FABC0
    }

    public class PooledDelegate`1 : Object
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.Internal.PooledDelegate`1<T>> NextNode;
        public Cysharp.Threading.Tasks.Internal.PooledDelegate`1<T> nextNode;
        public System.Action`1<T> runDelegate;
        public System.Action continuation;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFAC2C58E90
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Create(){} // RVA: 0x7FFAC2C58F80
        public void Run(){} // RVA: 0x7FFAC2E8DC40
    }

    public class RuntimeHelpersAbstraction : Object
    {
        // ── Methods ──
        public void IsWellKnownNoReferenceContainsType(){} // RVA: 0x7FFAC2C59D30
        public void WellKnownNoReferenceContainsTypeInitialize(){} // RVA: 0x7FFAC94FB4C0
    }

    public class SingleAssignmentDisposable : Object
    {
        public object IsDisposed; // 0x10
        public System.IDisposable Disposable; // 0x18
        public bool disposed; // 0x20

        // ── Methods ──
        public void get_IsDisposed(){} // RVA: 0x7FFAC92F40B0
        public void get_Disposable(){} // RVA: 0x7FFAC2F247C0
        public void set_Disposable(){} // RVA: 0x7FFAC94FDA80
        public void Dispose(){} // RVA: 0x7FFAC94FDD30
        public void .ctor(){} // RVA: 0x7FFAC94FDF10
    }

    public class StatePool`1 : Object
    {
        public System.Collections.Concurrent.ConcurrentQueue`1<Cysharp.Threading.Tasks.Internal.StateTuple`1<T>> queue;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void Return(){} // RVA: 0x7FFAC2C70A10
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class StatePool`2 : Object
    {
        public System.Collections.Concurrent.ConcurrentQueue`1<Cysharp.Threading.Tasks.Internal.StateTuple`2<U,T>> queue;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void Return(){} // RVA: 0x7FFAC2C70A10
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class StatePool`3 : Object
    {
        public System.Collections.Concurrent.ConcurrentQueue`1<Cysharp.Threading.Tasks.Internal.StateTuple`3<WhenAllPromise`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>,Awaiter<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>,int>> queue;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC5233AD0
        public void Return(){} // RVA: 0x7FFAC699F5F0
        public void .cctor(){} // RVA: 0x7FFAC699F6F0
    }

    public class StateTuple : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
    }

    public class StateTuple`1 : Object
    {
        public T Item1;

        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x7FFAC2C70A40
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class StateTuple`2 : Object
    {
        public U Item1;
        public T Item2;

        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x7FFAC2C79B30
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class StateTuple`3 : Object
    {
        public WhenAllPromise`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ> Item1; // 0x10
        public Awaiter<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ> Item2; // 0x18
        public int Item3; // 0x30

        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x7FFAC69A12B0
        public void Dispose(){} // RVA: 0x7FFAC69A1390
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ThrowObserver`1 : Object
    {
        public Cysharp.Threading.Tasks.Internal.ThrowObserver`1<T> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void OnCompleted(){} // RVA: 0x7FFAC2C70980
        public void OnError(){} // RVA: 0x7FFAC2C70A40
        public void OnNext(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class UnityEqualityComparer : Object
    {
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Vector2> Vector2;
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Vector3> Vector3; // 0x8
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Vector4> Vector4; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Color> Color; // 0x18
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Color32> Color32; // 0x20
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Rect> Rect; // 0x28
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Bounds> Bounds; // 0x30
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Quaternion> Quaternion; // 0x38
        public System.RuntimeTypeHandle vector2Type; // 0x40
        public System.RuntimeTypeHandle vector3Type; // 0x48
        public System.RuntimeTypeHandle vector4Type; // 0x50
        public System.RuntimeTypeHandle colorType; // 0x58
        public System.RuntimeTypeHandle color32Type; // 0x60
        public System.RuntimeTypeHandle rectType; // 0x68
        public System.RuntimeTypeHandle boundsType; // 0x70
        public System.RuntimeTypeHandle quaternionType; // 0x78
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Vector2Int> Vector2Int; // 0x80
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Vector3Int> Vector3Int; // 0x88
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.RangeInt> RangeInt; // 0x90
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.RectInt> RectInt; // 0x98
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.BoundsInt> BoundsInt; // 0xA0
        public System.RuntimeTypeHandle vector2IntType; // 0xA8
        public System.RuntimeTypeHandle vector3IntType; // 0xB0
        public System.RuntimeTypeHandle rangeIntType; // 0xB8
        public System.RuntimeTypeHandle rectIntType; // 0xC0
        public System.RuntimeTypeHandle boundsIntType; // 0xC8

        // ── Methods ──
        public void GetDefault(){} // RVA: 0x7FFAC2C58A90
        public void GetDefaultHelper(){} // RVA: 0x7FFAC94FB950
        public void .cctor(){} // RVA: 0x7FFAC94FBDB0
    }

    public class UnityWebRequestResultExtensions : Object
    {
        // ── Methods ──
        public void IsError(){} // RVA: 0x7FFAC94FD700
    }

    public class ValueStopwatch : ValueType
    {
        public double Elapsed;
        public long IsInvalid; // 0x10

        // ── Methods ──
        public void StartNew(){} // RVA: 0x7FFAC94FD780
        public void .ctor(){} // RVA: 0x7FFAC45BB120
        public void get_Elapsed(){} // RVA: 0x7FFAC94FD7D0
        public void get_IsInvalid(){} // RVA: 0x7FFAC484C2F0
        public void get_ElapsedTicks(){} // RVA: 0x7FFAC94FD850
        public void .cctor(){} // RVA: 0x7FFAC94FD950
    }

    public class WeakDictionary`2 : Object
    {
        public Entry<U,T>[] buckets;
        public int size;
        public System.Threading.SpinLock gate;
        public float loadFactor;
        public System.Collections.Generic.IEqualityComparer`1<U> keyEqualityComparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C74550
        public void TryAdd(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void TryRemove(){} // RVA: 0x7FFAC2E8DC40
        public void TryAddInternal(){} // RVA: 0x7FFAC2E8DC40
        public void AddToBuckets(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetEntry(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2C72BC0
        public void ToList(){} // RVA: 0x7FFAC2C58E90 | overloaded x2
        public void CalculateCapacity(){} // RVA: 0x7FFAC2E8DC40
    }

}