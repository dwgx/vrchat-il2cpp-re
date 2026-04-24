// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Internal
// Classes: 27
// Methods: 168

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Internal
{
    public class ArrayPoolUtil : Object
    {
        // ── Methods ──
        public void EnsureCapacity(){} // RVA: 0x7FFD4E090D10
        public void EnsureCapacityCore(){} // RVA: 0x7FFD4E090D10
        public void Materialize(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ArrayPool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD517A1650
        public void Rent(){} // RVA: 0x7FFD517A18D0
        public void Return(){} // RVA: 0x7FFD517A1BD0
        public void CalculateSize(){} // RVA: 0x7FFD5172ACB0
        public void GetQueueIndex(){} // RVA: 0x7FFD5172ACF0
        public void .cctor(){} // RVA: 0x7FFD517A1DE0
    }

    public class ArrayUtil : Object
    {
        public er<T>.OnTextSelectionAsync.ectEventHandler<T>.OnSelectAsync runner; // 0x10

        // ── Methods ──
        public void EnsureCapacity(){} // RVA: 0x7FFD4E096370
        public void EnsureCore(){} // RVA: 0x7FFD4E096370
        public void Materialize(){} // RVA: 0x7FFD4E2ADC40
    }

    public class AsyncSubject`1 : Object
    {
        public object Value;
        public object HasObservers;
        public object IsCompleted;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
        public void get_HasObservers(){} // RVA: 0x7FFD4E079D00
        public void get_IsCompleted(){} // RVA: 0x7FFD4E079D00
        public void OnCompleted(){} // RVA: 0x7FFD4E090980
        public void OnError(){} // RVA: 0x7FFD4E090A40
        public void OnNext(){} // RVA: 0x7FFD4E2ADC40
        public void Subscribe(){} // RVA: 0x7FFD4E078F40
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void ThrowIfDisposed(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ContinuationQueue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54916A30
        public void Enqueue(){} // RVA: 0x7FFD54916B60
        public void Clear(){} // RVA: 0x7FFD549170F0
        public void Run(){} // RVA: 0x7FFD54917230
        public void Initialization(){} // RVA: 0x7FFD54917230
        public void LastInitialization(){} // RVA: 0x7FFD54917230
        public void EarlyUpdate(){} // RVA: 0x7FFD54917230
        public void LastEarlyUpdate(){} // RVA: 0x7FFD54917230
        public void FixedUpdate(){} // RVA: 0x7FFD54917230
        public void LastFixedUpdate(){} // RVA: 0x7FFD54917230
        public void PreUpdate(){} // RVA: 0x7FFD54917230
        public void LastPreUpdate(){} // RVA: 0x7FFD54917230
        public void Update(){} // RVA: 0x7FFD54917230
        public void LastUpdate(){} // RVA: 0x7FFD54917230
        public void PreLateUpdate(){} // RVA: 0x7FFD54917230
        public void LastPreLateUpdate(){} // RVA: 0x7FFD54917230
        public void PostLateUpdate(){} // RVA: 0x7FFD54917230
        public void LastPostLateUpdate(){} // RVA: 0x7FFD54917230
        public void TimeUpdate(){} // RVA: 0x7FFD54917230
        public void LastTimeUpdate(){} // RVA: 0x7FFD54917230
        public void RunCore(){} // RVA: 0x7FFD54917240
    }

    public class DiagnosticsExtensions : Object
    {
        // ── Methods ──
        public void CleanupAsyncStackTrace(){} // RVA: 0x7FFD54917610
        public void IsAsync(){} // RVA: 0x7FFD54917E00
        public void TryResolveStateMachineMethod(){} // RVA: 0x7FFD54917F00
        public void BeautifyType(){} // RVA: 0x7FFD54918290
        public void IgnoreLine(){} // RVA: 0x7FFD54918950
        public void AppendHyperLink(){} // RVA: 0x7FFD54918B30
        public void .cctor(){} // RVA: 0x7FFD54918E50
    }

    public class DisposedObserver`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void OnCompleted(){} // RVA: 0x7FFD4E090980
        public void OnError(){} // RVA: 0x7FFD4E090A40
        public void OnNext(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class EmptyObserver`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void OnCompleted(){} // RVA: 0x7FFD4E090980
        public void OnError(){} // RVA: 0x7FFD4E090A40
        public void OnNext(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class Error : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7FFD4E2ADC40
        public void ThrowArgumentNullExceptionCore(){} // RVA: 0x7FFD54919F70
        public void ArgumentOutOfRange(){} // RVA: 0x7FFD54919FC0
        public void NoElements(){} // RVA: 0x7FFD5491A050
        public void MoreThanOneElement(){} // RVA: 0x7FFD5491A0C0
        public void ThrowArgumentException(){} // RVA: 0x7FFD5491A130
        public void ThrowNotYetCompleted(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ThrowWhenContinuationIsAlreadyRegistered(){} // RVA: 0x7FFD4E2ADC40
        public void ThrowInvalidOperationExceptionCore(){} // RVA: 0x7FFD5491A1D0
        public void ThrowOperationCanceledException(){} // RVA: 0x7FFD5491A220
    }

    public class ImmutableList`1 : Object
    {
        public object Data;

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ListObserver`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void OnCompleted(){} // RVA: 0x7FFD4E090980
        public void OnError(){} // RVA: 0x7FFD4E090A40
        public void OnNext(){} // RVA: 0x7FFD4E2ADC40
        public void Add(){} // RVA: 0x7FFD4E078F40
        public void Remove(){} // RVA: 0x7FFD4E078F40
    }

    public class MinimumQueue`1 : Object
    {
        public object Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51958920
        public void get_Count(){} // RVA: 0x7FFD4E4FBBE0
        public void Peek(){} // RVA: 0x7FFD51958A10
        public void Enqueue(){} // RVA: 0x7FFD5172B110
        public void Dequeue(){} // RVA: 0x7FFD5172B080
        public void Grow(){} // RVA: 0x7FFD51958A70
        public void SetCapacity(){} // RVA: 0x7FFD51958BE0
        public void MoveNext(){} // RVA: 0x7FFD51958D20
        public void ThrowForEmptyQueue(){} // RVA: 0x7FFD51958D50
    }

    public class PlayerLoopRunner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5491A260
        public void AddAction(){} // RVA: 0x7FFD5491A5E0
        public void Clear(){} // RVA: 0x7FFD5491A9F0
        public void Run(){} // RVA: 0x7FFD5491ABB0
        public void Initialization(){} // RVA: 0x7FFD5491ABB0
        public void LastInitialization(){} // RVA: 0x7FFD5491ABB0
        public void EarlyUpdate(){} // RVA: 0x7FFD5491ABB0
        public void LastEarlyUpdate(){} // RVA: 0x7FFD5491ABB0
        public void FixedUpdate(){} // RVA: 0x7FFD5491ABB0
        public void LastFixedUpdate(){} // RVA: 0x7FFD5491ABB0
        public void PreUpdate(){} // RVA: 0x7FFD5491ABB0
        public void LastPreUpdate(){} // RVA: 0x7FFD5491ABB0
        public void Update(){} // RVA: 0x7FFD5491ABB0
        public void LastUpdate(){} // RVA: 0x7FFD5491ABB0
        public void PreLateUpdate(){} // RVA: 0x7FFD5491ABB0
        public void LastPreLateUpdate(){} // RVA: 0x7FFD5491ABB0
        public void PostLateUpdate(){} // RVA: 0x7FFD5491ABB0
        public void LastPostLateUpdate(){} // RVA: 0x7FFD5491ABB0
        public void TimeUpdate(){} // RVA: 0x7FFD5491ABB0
        public void LastTimeUpdate(){} // RVA: 0x7FFD5491ABB0
        public void RunCore(){} // RVA: 0x7FFD5491ABC0
    }

    public class PooledDelegate`1 : Object
    {
        public eObjectDelegate.ion<n.questAwaiterConfiguredSource<T1717671456>> NextNode;
        public n.questAwaiterConfiguredSource<T1717671456> nextNode;
        public ileFullDirectoryInformation<T1717671456> runDelegate;
        public ÎÌÍÏÏÌÍÏ continuation;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFD4E078E90
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Create(){} // RVA: 0x7FFD4E078F80
        public void Run(){} // RVA: 0x7FFD4E2ADC40
    }

    public class RuntimeHelpersAbstraction : Object
    {
        // ── Methods ──
        public void IsWellKnownNoReferenceContainsType(){} // RVA: 0x7FFD4E079D30
        public void WellKnownNoReferenceContainsTypeInitialize(){} // RVA: 0x7FFD5491B4C0
    }

    public class StatePool`1 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void Return(){} // RVA: 0x7FFD4E090A10
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class StatePool`2 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void Return(){} // RVA: 0x7FFD4E090A10
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class StatePool`3 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD50653AD0
        public void Return(){} // RVA: 0x7FFD51DBF5F0
        public void .cctor(){} // RVA: 0x7FFD51DBF6F0
    }

    public class StateTuple : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
    }

    public class StateTuple`1 : Object
    {
        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x7FFD4E090A40
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class StateTuple`2 : Object
    {
        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x7FFD4E099B30
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class StateTuple`3 : Object
    {
        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x7FFD51DC12B0
        public void Dispose(){} // RVA: 0x7FFD51DC1390
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ThrowObserver`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void OnCompleted(){} // RVA: 0x7FFD4E090980
        public void OnError(){} // RVA: 0x7FFD4E090A40
        public void OnNext(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class UnityEqualityComparer : Object
    {
        // ── Methods ──
        public void GetDefault(){} // RVA: 0x7FFD4E078A90
        public void GetDefaultHelper(){} // RVA: 0x7FFD5491B950
        public void .cctor(){} // RVA: 0x7FFD5491BDB0
    }

    public class UnityWebRequestResultExtensions : Object
    {
        // ── Methods ──
        public void IsError(){} // RVA: 0x7FFD5491D700
    }

    public class ValueStopwatch : ValueType
    {
        public object Elapsed;
        public object IsInvalid;
        public object ElapsedTicks;

        // ── Methods ──
        public void StartNew(){} // RVA: 0x7FFD5491D780
        public void .ctor(){} // RVA: 0x7FFD4F9DB120
        public void get_Elapsed(){} // RVA: 0x7FFD5491D7D0
        public void get_IsInvalid(){} // RVA: 0x7FFD4FC6C2F0
        public void get_ElapsedTicks(){} // RVA: 0x7FFD5491D850
        public void .cctor(){} // RVA: 0x7FFD5491D950
    }

    public class WeakDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E094550
        public void TryAdd(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void TryRemove(){} // RVA: 0x7FFD4E2ADC40
        public void TryAddInternal(){} // RVA: 0x7FFD4E2ADC40
        public void AddToBuckets(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetEntry(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E092BC0
        public void ToList(){} // RVA: 0x7FFD4E078E90 | overloaded x2
        public void CalculateCapacity(){} // RVA: 0x7FFD4E2ADC40
    }

}