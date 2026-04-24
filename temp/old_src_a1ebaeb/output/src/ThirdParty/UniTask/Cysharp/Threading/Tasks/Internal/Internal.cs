// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Internal
// Classes: 47
// Methods: 251

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Internal
{
    public class ArrayPoolUtil : Object
    {
        // ── Original Methods ──
        public void EnsureCapacity(){} // RVA: 0x7ffaa8661050
        public void EnsureCapacityCore(){} // RVA: 0x7ffaa8661050
        public void Materialize(){} // RVA: 0x7ffaa887e5c0
    }

    public class ArrayPool`1 : Object
    {
        public object Shared; // 0x300D1538

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd95000
        public void Rent(){} // RVA: 0x7ffaabd95280
        public void Return(){} // RVA: 0x7ffaabd95580
        public void CalculateSize(){} // RVA: 0x7ffaabd94c30
        public void .cctor(){} // RVA: 0x7ffaabd95790
        // ── Binary Analysis Named ──
        public void GetQueueIndex(){} // RVA: 0x7ffaabd94c70
    }

    public class ArrayPool`1 : Object
    {
        public object Shared; // 0x30CF9C00
        public object Array; // 0x312EBE30

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void CalculateSize(){} // RVA: 0x7ffaa8650450
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetQueueIndex(){} // RVA: 0x7ffaa8650450
    }

    public class ArrayPool`1 : Object
    {
        public object Shared; // 0x37BE7D10

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd95000
        public void Rent(){} // RVA: 0x7ffaabd95280
        public void Return(){} // RVA: 0x7ffaabd95580
        public void CalculateSize(){} // RVA: 0x7ffaabd94c30
        public void .cctor(){} // RVA: 0x7ffaabd95790
        // ── Binary Analysis Named ──
        public void GetQueueIndex(){} // RVA: 0x7ffaabd94c70
    }

    public class ArrayUtil : Object
    {
        // ── Original Methods ──
        public void EnsureCapacity(){} // RVA: 0x7ffaa86666b0
        public void EnsureCore(){} // RVA: 0x7ffaa86666b0
        public void Materialize(){} // RVA: 0x7ffaa887e5c0
    }

    public class AsyncSubject`1 : Object
    {
        public object hasValue; // 0x30D40F80
        public object lastError; // 0x30D40F80

        // ── Original Methods ──
        public void get_Value(){} // RVA: 0x7ffaa887e5c0
        public void get_HasObservers(){} // RVA: 0x7ffaa864a040
        public void get_IsCompleted(){} // RVA: 0x7ffaa864a040
        public void OnCompleted(){} // RVA: 0x7ffaa8660cc0
        public void OnError(){} // RVA: 0x7ffaa8660d80
        public void OnNext(){} // RVA: 0x7ffaa887e5c0
        public void Subscribe(){} // RVA: 0x7ffaa8649280
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void ThrowIfDisposed(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class ContinuationQueue : Object
    {
        public object timing; // 0x33CC49A0
        public object actionListCount; // 0x33CC49A0
        public object waitingList; // 0x33CC49A0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaef18a00
        public void Enqueue(){} // RVA: 0x7ffaaef18b30
        public void Clear(){} // RVA: 0x7ffaaef190c0
        public void Run(){} // RVA: 0x7ffaaef19200
        public void Initialization(){} // RVA: 0x7ffaaef19200
        public void LastInitialization(){} // RVA: 0x7ffaaef19200
        public void EarlyUpdate(){} // RVA: 0x7ffaaef19200
        public void LastEarlyUpdate(){} // RVA: 0x7ffaaef19200
        public void FixedUpdate(){} // RVA: 0x7ffaaef19200
        public void LastFixedUpdate(){} // RVA: 0x7ffaaef19200
        public void PreUpdate(){} // RVA: 0x7ffaaef19200
        public void LastPreUpdate(){} // RVA: 0x7ffaaef19200
        public void Update(){} // RVA: 0x7ffaaef19200
        public void LastUpdate(){} // RVA: 0x7ffaaef19200
        public void PreLateUpdate(){} // RVA: 0x7ffaaef19200
        public void LastPreLateUpdate(){} // RVA: 0x7ffaaef19200
        public void PostLateUpdate(){} // RVA: 0x7ffaaef19200
        public void LastPostLateUpdate(){} // RVA: 0x7ffaaef19200
        public void TimeUpdate(){} // RVA: 0x7ffaaef19200
        public void LastTimeUpdate(){} // RVA: 0x7ffaaef19200
        public void RunCore(){} // RVA: 0x7ffaaef19210
    }

    public class DiagnosticsExtensions : Object
    {
        public object builtInTypeNames; // 0x33CD0A00

        // ── Original Methods ──
        public void CleanupAsyncStackTrace(){} // RVA: 0x7ffaaef195e0
        public void IsAsync(){} // RVA: 0x7ffaaef19dd0
        public void TryResolveStateMachineMethod(){} // RVA: 0x7ffaaef19ed0
        public void BeautifyType(){} // RVA: 0x7ffaaef1a260
        public void IgnoreLine(){} // RVA: 0x7ffaaef1a920
        public void AppendHyperLink(){} // RVA: 0x7ffaaef1ab00
        public void .cctor(){} // RVA: 0x7ffaaef1ae20
    }

    public class DisposedObserver`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void OnCompleted(){} // RVA: 0x7ffaa8660cc0
        public void OnError(){} // RVA: 0x7ffaa8660d80
        public void OnNext(){} // RVA: 0x7ffaa887e5c0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class EmptyObserver`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void OnCompleted(){} // RVA: 0x7ffaa8660cc0
        public void OnError(){} // RVA: 0x7ffaa8660d80
        public void OnNext(){} // RVA: 0x7ffaa887e5c0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class Error : Object
    {
        // ── Original Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7ffaa887e5c0
        public void ThrowArgumentNullExceptionCore(){} // RVA: 0x7ffaaef1bf40
        public void ArgumentOutOfRange(){} // RVA: 0x7ffaaef1bf90
        public void NoElements(){} // RVA: 0x7ffaaef1c020
        public void MoreThanOneElement(){} // RVA: 0x7ffaaef1c090
        public void ThrowArgumentException(){} // RVA: 0x7ffaaef1c100
        public void ThrowNotYetCompleted(){} // RVA: 0x7ffaa887e5c0
        public void ThrowNotYetCompleted(){} // RVA: 0x7ffaa887e5c0
        public void ThrowWhenContinuationIsAlreadyRegistered(){} // RVA: 0x7ffaa887e5c0
        public void ThrowInvalidOperationExceptionCore(){} // RVA: 0x7ffaaef1c1a0
        public void ThrowOperationCanceledException(){} // RVA: 0x7ffaaef1c1f0
    }

    public class ImmutableList`1 : Object
    {
        // ── Original Methods ──
        public void get_Data(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void IndexOf(){} // RVA: 0x7ffaa887e5c0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class ListObserver`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void OnCompleted(){} // RVA: 0x7ffaa8660cc0
        public void OnError(){} // RVA: 0x7ffaa8660d80
        public void OnNext(){} // RVA: 0x7ffaa887e5c0
        public void Add(){} // RVA: 0x7ffaa8649280
        public void Remove(){} // RVA: 0x7ffaa8649280
    }

    public class MinimumQueue`1 : Object
    {
        public object array; // 0x300D1D90
        public object size; // 0x300D1D90

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabf45dd0
        public void get_Count(){} // RVA: 0x7ffaa8aeced0
        public void Peek(){} // RVA: 0x7ffaabf45ec0
        public void Enqueue(){} // RVA: 0x7ffaabda1410
        public void Dequeue(){} // RVA: 0x7ffaabda1380
        public void Grow(){} // RVA: 0x7ffaabf45f20
        public void MoveNext(){} // RVA: 0x7ffaabf461d0
        public void ThrowForEmptyQueue(){} // RVA: 0x7ffaabf46200
        // ── Binary Analysis Named ──
        public void SetCapacity(){} // RVA: 0x7ffaabf46090
    }

    public class MinimumQueue`1 : Object
    {
        public object array; // 0x3122AA30
        public object size; // 0x3122AA30
        public object Count; // 0x17000077

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void Peek(){} // RVA: 0x7ffaa887e5c0
        public void Enqueue(){} // RVA: 0x7ffaa887e5c0
        public void Dequeue(){} // RVA: 0x7ffaa887e5c0
        public void Grow(){} // RVA: 0x7ffaa8660cc0
        public void MoveNext(){} // RVA: 0x7ffaa8660d80
        public void ThrowForEmptyQueue(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetCapacity(){} // RVA: 0x7ffaa8661210
    }

    public class MinimumQueue`1 : Object
    {
        public object array; // 0x351F14B8
        public object size; // 0x351F14B8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabf45dd0
        public void get_Count(){} // RVA: 0x7ffaa8aeced0
        public void Peek(){} // RVA: 0x7ffaabf45ec0
        public void Enqueue(){} // RVA: 0x7ffaabda1410
        public void Dequeue(){} // RVA: 0x7ffaabda1380
        public void Grow(){} // RVA: 0x7ffaabf45f20
        public void MoveNext(){} // RVA: 0x7ffaabf461d0
        public void ThrowForEmptyQueue(){} // RVA: 0x7ffaabf46200
        // ── Binary Analysis Named ──
        public void SetCapacity(){} // RVA: 0x7ffaabf46090
    }

    public class MinimumQueue`1 : Object
    {
        public object array; // 0x37BE8568
        public object size; // 0x37BE8568

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabf45dd0
        public void get_Count(){} // RVA: 0x7ffaa8aeced0
        public void Peek(){} // RVA: 0x7ffaabf45ec0
        public void Enqueue(){} // RVA: 0x7ffaabda1410
        public void Dequeue(){} // RVA: 0x7ffaabda1380
        public void Grow(){} // RVA: 0x7ffaabf45f20
        public void MoveNext(){} // RVA: 0x7ffaabf461d0
        public void ThrowForEmptyQueue(){} // RVA: 0x7ffaabf46200
        // ── Binary Analysis Named ──
        public void SetCapacity(){} // RVA: 0x7ffaabf46090
    }

    public class PlayerLoopRunner : Object
    {
        public object runningAndQueueLock; // 0x335D9FE0
        public object tail; // 0x335D9FE0
        public object waitQueue; // 0x335D9FE0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaef1c230
        public void AddAction(){} // RVA: 0x7ffaaef1c5b0
        public void Clear(){} // RVA: 0x7ffaaef1c9c0
        public void Run(){} // RVA: 0x7ffaaef1cb80
        public void Initialization(){} // RVA: 0x7ffaaef1cb80
        public void LastInitialization(){} // RVA: 0x7ffaaef1cb80
        public void EarlyUpdate(){} // RVA: 0x7ffaaef1cb80
        public void LastEarlyUpdate(){} // RVA: 0x7ffaaef1cb80
        public void FixedUpdate(){} // RVA: 0x7ffaaef1cb80
        public void LastFixedUpdate(){} // RVA: 0x7ffaaef1cb80
        public void PreUpdate(){} // RVA: 0x7ffaaef1cb80
        public void LastPreUpdate(){} // RVA: 0x7ffaaef1cb80
        public void Update(){} // RVA: 0x7ffaaef1cb80
        public void LastUpdate(){} // RVA: 0x7ffaaef1cb80
        public void PreLateUpdate(){} // RVA: 0x7ffaaef1cb80
        public void LastPreLateUpdate(){} // RVA: 0x7ffaaef1cb80
        public void PostLateUpdate(){} // RVA: 0x7ffaaef1cb80
        public void LastPostLateUpdate(){} // RVA: 0x7ffaaef1cb80
        public void TimeUpdate(){} // RVA: 0x7ffaaef1cb80
        public void LastTimeUpdate(){} // RVA: 0x7ffaaef1cb80
        public void RunCore(){} // RVA: 0x7ffaaef1cb90
    }

    public class PooledDelegate`1 : Object
    {
        public object runDelegate; // 0x30B3A720

        // ── Original Methods ──
        public void get_NextNode(){} // RVA: 0x7ffaa86491d0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void Create(){} // RVA: 0x7ffaa86492c0
        public void Run(){} // RVA: 0x7ffaa887e5c0
    }

    public class PooledDelegate`1 : Object
    {
        public object runDelegate; // 0x37F52D10

        // ── Original Methods ──
        public void get_NextNode(){} // RVA: 0x7ffaac125af0
        public void .cctor(){} // RVA: 0x7ffaac125b00
        public void .ctor(){} // RVA: 0x7ffaac125ce0
        public void Create(){} // RVA: 0x7ffaac125db0
        public void Run(){} // RVA: 0x7ffaac125f70
    }

    public class RuntimeHelpersAbstraction : Object
    {
        // ── Original Methods ──
        public void IsWellKnownNoReferenceContainsType(){} // RVA: 0x7ffaa864a070
        public void WellKnownNoReferenceContainsTypeInitialize(){} // RVA: 0x7ffaaef1d490
    }

    public class StatePool`1 : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaa887e5c0
        public void Return(){} // RVA: 0x7ffaa8660d50
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class StatePool`2 : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaa887e5c0
        public void Return(){} // RVA: 0x7ffaa8660d50
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class StatePool`2 : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaac331e0
        public void Return(){} // RVA: 0x7ffaac3aee00
        public void .cctor(){} // RVA: 0x7ffaac3aeef0
    }

    public class StatePool`2 : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaac331e0
        public void Return(){} // RVA: 0x7ffaac3aee00
        public void .cctor(){} // RVA: 0x7ffaac3aeef0
    }

    public class StatePool`2 : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaac331e0
        public void Return(){} // RVA: 0x7ffaac3aee00
        public void .cctor(){} // RVA: 0x7ffaac3aeef0
    }

    public class StatePool`3 : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaac33ec0
        public void Return(){} // RVA: 0x7ffaac3afad0
        public void .cctor(){} // RVA: 0x7ffaac3afbd0
    }

    public class StatePool`3 : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaa887e5c0
        public void Return(){} // RVA: 0x7ffaa8660d50
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class StatePool`3 : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaac33ec0
        public void Return(){} // RVA: 0x7ffaac3afad0
        public void .cctor(){} // RVA: 0x7ffaac3afbd0
    }

    public class StatePool`3 : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaac33ec0
        public void Return(){} // RVA: 0x7ffaac3afad0
        public void .cctor(){} // RVA: 0x7ffaac3afbd0
    }

    public class StateTuple : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaa887e5c0
        public void Create(){} // RVA: 0x7ffaa887e5c0
        public void Create(){} // RVA: 0x7ffaa887e5c0
    }

    public class StateTuple`1 : Object
    {
        // ── Original Methods ──
        public void Deconstruct(){} // RVA: 0x7ffaa8660d80
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class StateTuple`1 : Object
    {
        // ── Original Methods ──
        public void Deconstruct(){} // RVA: 0x7ffaac3b0770
        public void Dispose(){} // RVA: 0x7ffaac3b07d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class StateTuple`2 : Object
    {
        // ── Original Methods ──
        public void Deconstruct(){} // RVA: 0x7ffaa8669e70
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class StateTuple`2 : Object
    {
        // ── Original Methods ──
        public void Deconstruct(){} // RVA: 0x7ffaac3b0da0
        public void Dispose(){} // RVA: 0x7ffaac3b0e50
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class StateTuple`2 : Object
    {
    }

    public class StateTuple`2 : Object
    {
        // ── Original Methods ──
        public void Deconstruct(){} // RVA: 0x7ffaac3b0da0
        public void Dispose(){} // RVA: 0x7ffaac3b0e50
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class StateTuple`2 : Object
    {
        // ── Original Methods ──
        public void Deconstruct(){} // RVA: 0x7ffaac3b0da0
        public void Dispose(){} // RVA: 0x7ffaac3b0e50
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class StateTuple`3 : Object
    {
        public object Item3; // 0x300D9BE0

        // ── Original Methods ──
        public void Deconstruct(){} // RVA: 0x7ffaac3b1790
        public void Dispose(){} // RVA: 0x7ffaac3b1870
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class StateTuple`3 : Object
    {
        public object Item3; // 0x313C9EE0
        public object queue; // 0x313C9D60

        // ── Original Methods ──
        public void Deconstruct(){} // RVA: 0x7ffaa866b2a0
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class StateTuple`3 : Object
    {
        public object Item3; // 0x379DA388

        // ── Original Methods ──
        public void Deconstruct(){} // RVA: 0x7ffaac3b1790
        public void Dispose(){} // RVA: 0x7ffaac3b1870
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class StateTuple`3 : Object
    {
        public object Item3; // 0x37BF85E8

        // ── Original Methods ──
        public void Deconstruct(){} // RVA: 0x7ffaac3b1790
        public void Dispose(){} // RVA: 0x7ffaac3b1870
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ThrowObserver`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void OnCompleted(){} // RVA: 0x7ffaa8660cc0
        public void OnError(){} // RVA: 0x7ffaa8660d80
        public void OnNext(){} // RVA: 0x7ffaa887e5c0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class UnityEqualityComparer : Object
    {
        public object Vector4; // 0x30DE77A0
        public object Rect; // 0x30DE77A0
        public object vector2Type; // 0x30DE77A0
        public object colorType; // 0x30DE77A0
        public object boundsType; // 0x30DE77A0
        public object Vector3Int; // 0x30DE77A0
        public object BoundsInt; // 0x30DE77A0
        public object rangeIntType; // 0x30DE77A0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaef1dd80
        // ── Binary Analysis Named ──
        public void GetDefault(){} // RVA: 0x7ffaa8648dd0
        public void GetDefaultHelper(){} // RVA: 0x7ffaaef1d920
    }

    public class UnityWebRequestResultExtensions : Object
    {
        // ── Original Methods ──
        public void IsError(){} // RVA: 0x7ffaaef1f6d0
    }

    public class ValueStopwatch : ValueType
    {
        // ── Original Methods ──
        public void StartNew(){} // RVA: 0x7ffaaef1f750
        public void .ctor(){} // RVA: 0x7ffaa9fe08a0
        public void get_Elapsed(){} // RVA: 0x7ffaaef1f7a0
        public void get_IsInvalid(){} // RVA: 0x7ffaaa254200
        public void get_ElapsedTicks(){} // RVA: 0x7ffaaef1f820
        public void .cctor(){} // RVA: 0x7ffaaef1f920
    }

    public class WeakDictionary`2 : Object
    {
        public object gate; // 0x30ECEFF0
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8664890
        public void TryAdd(){} // RVA: 0x7ffaa887e5c0
        public void TryGetValue(){} // RVA: 0x7ffaa887e5c0
        public void TryRemove(){} // RVA: 0x7ffaa887e5c0
        public void TryAddInternal(){} // RVA: 0x7ffaa887e5c0
        public void AddToBuckets(){} // RVA: 0x7ffaa887e5c0
        public void TryGetEntry(){} // RVA: 0x7ffaa887e5c0
        public void Remove(){} // RVA: 0x7ffaa8662f00
        public void ToList(){} // RVA: 0x7ffaa86491d0
        public void ToList(){} // RVA: 0x7ffaa86491d0
        public void CalculateCapacity(){} // RVA: 0x7ffaa887e5c0
    }

}