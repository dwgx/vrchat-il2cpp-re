// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Internal
// Classes: 29
// Methods: 173

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Internal
{
    public class ArrayPoolUtil : Object
    {
        // ── Methods ──
        public void EnsureCapacity(){} // RVA: 0x7FFE80E46370
        public void EnsureCapacityCore(){} // RVA: 0x7FFE80E46370
        public void Materialize(){} // RVA: 0x7FFE810A1420
    }

    public class ArrayPool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Rent(){} // RVA: 0x7FFE80E3D230
        public void Return(){} // RVA: 0x7FFE80E4BC00
        public void CalculateSize(){} // RVA: 0x7FFE80E35560
        public void GetQueueIndex(){} // RVA: 0x7FFE80E35560
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ArrayUtil : Object
    {
        // ── Methods ──
        public void EnsureCapacity(){} // RVA: 0x7FFE80E4BA70
        public void EnsureCore(){} // RVA: 0x7FFE80E4BA70
        public void Materialize(){} // RVA: 0x7FFE810A1420
    }

    public class AsyncSubject`1 : Object
    {
        public object observerLock;
        public T lastValue;
        public bool hasValue;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE810A1420
        public void get_HasObservers(){} // RVA: 0x7FFE80E2F150
        public void get_IsCompleted(){} // RVA: 0x7FFE80E2F150
        public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
        public void OnError(){} // RVA: 0x7FFE80E460A0
        public void OnNext(){} // RVA: 0x7FFE810A1420
        public void Subscribe(){} // RVA: 0x7FFE80E2E390
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void ThrowIfDisposed(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ContinuationQueue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8789F170
        public void Enqueue(){} // RVA: 0x7FFE8789F2A0
        public void Clear(){} // RVA: 0x7FFE8789F830
        public void Run(){} // RVA: 0x7FFE8789F970
        public void Initialization(){} // RVA: 0x7FFE8789F970
        public void LastInitialization(){} // RVA: 0x7FFE8789F970
        public void EarlyUpdate(){} // RVA: 0x7FFE8789F970
        public void LastEarlyUpdate(){} // RVA: 0x7FFE8789F970
        public void FixedUpdate(){} // RVA: 0x7FFE8789F970
        public void LastFixedUpdate(){} // RVA: 0x7FFE8789F970
        public void PreUpdate(){} // RVA: 0x7FFE8789F970
        public void LastPreUpdate(){} // RVA: 0x7FFE8789F970
        public void Update(){} // RVA: 0x7FFE8789F970
        public void LastUpdate(){} // RVA: 0x7FFE8789F970
        public void PreLateUpdate(){} // RVA: 0x7FFE8789F970
        public void LastPreLateUpdate(){} // RVA: 0x7FFE8789F970
        public void PostLateUpdate(){} // RVA: 0x7FFE8789F970
        public void LastPostLateUpdate(){} // RVA: 0x7FFE8789F970
        public void TimeUpdate(){} // RVA: 0x7FFE8789F970
        public void LastTimeUpdate(){} // RVA: 0x7FFE8789F970
        public void RunCore(){} // RVA: 0x7FFE8789F980
    }

    public class DiagnosticsExtensions : Object
    {
        // ── Methods ──
        public void CleanupAsyncStackTrace(){} // RVA: 0x7FFE8789FD50
        public void IsAsync(){} // RVA: 0x7FFE878A0540
        public void TryResolveStateMachineMethod(){} // RVA: 0x7FFE878A0640
        public void BeautifyType(){} // RVA: 0x7FFE878A09D0
        public void IgnoreLine(){} // RVA: 0x7FFE878A1090
        public void AppendHyperLink(){} // RVA: 0x7FFE878A1270
        public void .cctor(){} // RVA: 0x7FFE878A1590
    }

    public class DisposedObserver`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
        public void OnError(){} // RVA: 0x7FFE80E460A0
        public void OnNext(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class EmptyDisposable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE878A6120
    }

    public class EmptyObserver`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
        public void OnError(){} // RVA: 0x7FFE80E460A0
        public void OnNext(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class Error : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7FFE810A1420
        public void ThrowArgumentNullExceptionCore(){} // RVA: 0x7FFE878A26B0
        public void ArgumentOutOfRange(){} // RVA: 0x7FFE878A2700
        public void NoElements(){} // RVA: 0x7FFE878A2790
        public void MoreThanOneElement(){} // RVA: 0x7FFE878A2800
        public void ThrowArgumentException(){} // RVA: 0x7FFE878A2870
        public void ThrowNotYetCompleted(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ThrowWhenContinuationIsAlreadyRegistered(){} // RVA: 0x7FFE810A1420
        public void ThrowInvalidOperationExceptionCore(){} // RVA: 0x7FFE878A2910
        public void ThrowOperationCanceledException(){} // RVA: 0x7FFE878A2960
    }

    public class ImmutableList`1 : Object
    {
        public Cysharp.Threading.Tasks.Internal.ImmutableList`1<T> Empty;

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ListObserver`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
        public void OnError(){} // RVA: 0x7FFE80E460A0
        public void OnNext(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE80E2E390
        public void Remove(){} // RVA: 0x7FFE80E2E390
    }

    public class MinimumQueue`1 : Object
    {
        public int MinimumGrow;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void Peek(){} // RVA: 0x7FFE810A1420
        public void Enqueue(){} // RVA: 0x7FFE810A1420
        public void Dequeue(){} // RVA: 0x7FFE810A1420
        public void Grow(){} // RVA: 0x7FFE80E45FE0
        public void SetCapacity(){} // RVA: 0x7FFE80E46530
        public void MoveNext(){} // RVA: 0x7FFE80E460A0
        public void ThrowForEmptyQueue(){} // RVA: 0x7FFE80E45FE0
    }

    public class PlayerLoopRunner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE878A29A0
        public void AddAction(){} // RVA: 0x7FFE878A2D20
        public void Clear(){} // RVA: 0x7FFE878A3130
        public void Run(){} // RVA: 0x7FFE878A32F0
        public void Initialization(){} // RVA: 0x7FFE878A32F0
        public void LastInitialization(){} // RVA: 0x7FFE878A32F0
        public void EarlyUpdate(){} // RVA: 0x7FFE878A32F0
        public void LastEarlyUpdate(){} // RVA: 0x7FFE878A32F0
        public void FixedUpdate(){} // RVA: 0x7FFE878A32F0
        public void LastFixedUpdate(){} // RVA: 0x7FFE878A32F0
        public void PreUpdate(){} // RVA: 0x7FFE878A32F0
        public void LastPreUpdate(){} // RVA: 0x7FFE878A32F0
        public void Update(){} // RVA: 0x7FFE878A32F0
        public void LastUpdate(){} // RVA: 0x7FFE878A32F0
        public void PreLateUpdate(){} // RVA: 0x7FFE878A32F0
        public void LastPreLateUpdate(){} // RVA: 0x7FFE878A32F0
        public void PostLateUpdate(){} // RVA: 0x7FFE878A32F0
        public void LastPostLateUpdate(){} // RVA: 0x7FFE878A32F0
        public void TimeUpdate(){} // RVA: 0x7FFE878A32F0
        public void LastTimeUpdate(){} // RVA: 0x7FFE878A32F0
        public void RunCore(){} // RVA: 0x7FFE878A3300
    }

    public class PooledDelegate`1 : Object
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.Internal.PooledDelegate`1<UnityEngine.AsyncOperation>> pool;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFE84A67100
        public void .cctor(){} // RVA: 0x7FFE84A67110
        public void .ctor(){} // RVA: 0x7FFE84A672F0
        public void Create(){} // RVA: 0x7FFE84A673C0
        public void Run(){} // RVA: 0x7FFE84A67580
    }

    public class RuntimeHelpersAbstraction : Object
    {
        // ── Methods ──
        public void IsWellKnownNoReferenceContainsType(){} // RVA: 0x7FFE80E2F180
        public void WellKnownNoReferenceContainsTypeInitialize(){} // RVA: 0x7FFE878A3C00
    }

    public class SingleAssignmentDisposable : Object
    {
        public object gate; // 0x10
        public System.IDisposable current; // 0x18

        // ── Methods ──
        public void get_IsDisposed(){} // RVA: 0x7FFE8769C7E0
        public void get_Disposable(){} // RVA: 0x7FFE810FE7C0
        public void set_Disposable(){} // RVA: 0x7FFE878A61C0
        public void Dispose(){} // RVA: 0x7FFE878A6470
        public void .ctor(){} // RVA: 0x7FFE878A6650
    }

    public class StatePool`1 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE810A1420
        public void Return(){} // RVA: 0x7FFE80E46070
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class StatePool`2 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE834E1640
        public void Return(){} // RVA: 0x7FFE84CFFE90
        public void .cctor(){} // RVA: 0x7FFE84CFFF80
    }

    public class StatePool`3 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE810A1420
        public void Return(){} // RVA: 0x7FFE80E46070
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class StateTuple : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE810A1420 | overloaded x3
    }

    public class StateTuple`1 : Object
    {
        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x7FFE80E460A0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class StateTuple`2 : Object
    {
    }

    public class StateTuple`3 : Object
    {
        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x7FFE80E50660
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ThrowObserver`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
        public void OnError(){} // RVA: 0x7FFE80E460A0
        public void OnNext(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class UnityEqualityComparer : Object
    {
        // ── Methods ──
        public void GetDefault(){} // RVA: 0x7FFE80E2DEE0
        public void GetDefaultHelper(){} // RVA: 0x7FFE878A4090
        public void .cctor(){} // RVA: 0x7FFE878A44F0
    }

    public class UnityWebRequestResultExtensions : Object
    {
        // ── Methods ──
        public void IsError(){} // RVA: 0x7FFE878A5E40
    }

    public class ValueStopwatch : ValueType
    {
        public double TimestampToTicks;
        public long startTimestamp; // 0x10
        public object field_2; // 0x9AD0

        // ── Methods ──
        public void StartNew(){} // RVA: 0x7FFE878A5EC0
        public void .ctor(){} // RVA: 0x7FFE82889220
        public void get_Elapsed(){} // RVA: 0x7FFE878A5F10
        public void get_IsInvalid(){} // RVA: 0x7FFE82AB4690
        public void get_ElapsedTicks(){} // RVA: 0x7FFE878A5F90
        public void .cctor(){} // RVA: 0x7FFE878A6090
    }

    public class WeakDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E49BC0
        public void TryAdd(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void TryRemove(){} // RVA: 0x7FFE810A1420
        public void TryAddInternal(){} // RVA: 0x7FFE810A1420
        public void AddToBuckets(){} // RVA: 0x7FFE810A1420
        public void TryGetEntry(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE80E48220
        public void ToList(){} // RVA: 0x7FFE80E2E2E0 | overloaded x2
        public void CalculateCapacity(){} // RVA: 0x7FFE810A1420
    }

}