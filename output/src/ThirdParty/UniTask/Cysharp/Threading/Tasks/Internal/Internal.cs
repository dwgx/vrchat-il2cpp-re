// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Internal
// Classes: 69
// Methods: 385

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Internal
{
    public class ArrayPoolUtil : Object
    {
        // ── Methods ──
        public void Materialize(){} // RVA: 0x2F7E930
        public void EnsureCapacity(){} // RVA: 0x2F7D670
        public void EnsureCapacityCore(){} // RVA: 0x894650
    }

    public class ArrayPool`1 : Object
    {
        // ── Methods ──
        public void Return(){} // RVA: 0x43D5490
        public void Rent(){} // RVA: 0x43D51A0
        public void .ctor(){} // RVA: 0x43D4EF0
        public void CalculateSize(){} // RVA: 0x43D4120
        public void GetQueueIndex(){} // RVA: 0x43D4160
        public void .cctor(){} // RVA: 0x43D5680
    }

    public class ArrayPool`1 : Object
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x43D5B80
        public void .ctor(){} // RVA: 0x43D58D0
        public void Return(){} // RVA: 0x43D5E70
        public void CalculateSize(){} // RVA: 0x43D4120
        public void GetQueueIndex(){} // RVA: 0x43D4160
        public void .cctor(){} // RVA: 0x43D6060
    }

    public class ArrayPool`1 : Object
    {
        // ── Methods ──
        public void Return(){} // RVA: 0x43D5490
        public void Rent(){} // RVA: 0x43D51A0
    }

    public class ArrayPool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void Rent(){} // RVA: 0x87C160
        public void Return(){} // RVA: 0x899250
        public void CalculateSize(){} // RVA: 0x883700
        public void GetQueueIndex(){} // RVA: 0x883700
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class ArrayPool`1 : Object
    {
        // ── Methods ──
        public void Return(){} // RVA: 0x43D5490
        public void Rent(){} // RVA: 0x43D51A0
        public void .ctor(){} // RVA: 0x43D4EF0
        public void CalculateSize(){} // RVA: 0x43D4120
        public void GetQueueIndex(){} // RVA: 0x43D4160
        public void .cctor(){} // RVA: 0x43D5680
    }

    public class ArrayUtil : Object
    {
        // ── Methods ──
        public void EnsureCapacity(){} // RVA: 0x89AB50
        public void EnsureCore(){} // RVA: 0x89AB50
        public void Materialize(){} // RVA: 0xA94080
    }

    public class AsyncSubject`1 : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xA94080
        public void get_HasObservers(){} // RVA: 0x87D280
        public void get_IsCompleted(){} // RVA: 0x87D280
        public void OnCompleted(){} // RVA: 0x894290
        public void OnError(){} // RVA: 0x894320
        public void OnNext(){} // RVA: 0xA94080
        public void Subscribe(){} // RVA: 0x87C540
        public void Dispose(){} // RVA: 0x894290
        public void ThrowIfDisposed(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0x894290
    }

    public class ContinuationQueue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x77BA5E0
        public void Enqueue(){} // RVA: 0x77BA710
        public void Clear(){} // RVA: 0x77BAC80
        public void Run(){} // RVA: 0x77BADC0
        public void Initialization(){} // RVA: 0x77BADC0
        public void LastInitialization(){} // RVA: 0x77BADC0
        public void EarlyUpdate(){} // RVA: 0x77BADC0
        public void LastEarlyUpdate(){} // RVA: 0x77BADC0
        public void FixedUpdate(){} // RVA: 0x77BADC0
        public void LastFixedUpdate(){} // RVA: 0x77BADC0
        public void PreUpdate(){} // RVA: 0x77BADC0
        public void LastPreUpdate(){} // RVA: 0x77BADC0
        public void Update(){} // RVA: 0x77BADC0
        public void LastUpdate(){} // RVA: 0x77BADC0
        public void PreLateUpdate(){} // RVA: 0x77BADC0
        public void LastPreLateUpdate(){} // RVA: 0x77BADC0
        public void PostLateUpdate(){} // RVA: 0x77BADC0
        public void LastPostLateUpdate(){} // RVA: 0x77BADC0
        public void TimeUpdate(){} // RVA: 0x77BADC0
        public void LastTimeUpdate(){} // RVA: 0x77BADC0
        public void RunCore(){} // RVA: 0x77BADD0
    }

    public class ContinuationQueue[] : Array
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

    public class DiagnosticsExtensions : Object
    {
        // ── Methods ──
        public void CleanupAsyncStackTrace(){} // RVA: 0x77BB190
        public void IsAsync(){} // RVA: 0x77BB990
        public void TryResolveStateMachineMethod(){} // RVA: 0x77BBA60
        public void BeautifyType(){} // RVA: 0x77BBDE0
        public void IgnoreLine(){} // RVA: 0x77BC590
        public void AppendHyperLink(){} // RVA: 0x77BC770
        public void .cctor(){} // RVA: 0x77BCA90
    }

    public class DisposedObserver`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void OnCompleted(){} // RVA: 0x894290
        public void OnError(){} // RVA: 0x894320
        public void OnNext(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class EmptyDisposable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x77C1000
    }

    public class EmptyObserver`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void OnCompleted(){} // RVA: 0x894290
        public void OnError(){} // RVA: 0x894320
        public void OnNext(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class Error : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0xA94080
        public void ThrowWhenContinuationIsAlreadyRegistered(){} // RVA: 0xA94080
        public void ThrowArgumentNullExceptionCore(){} // RVA: 0x77BD850
        public void ArgumentOutOfRange(){} // RVA: 0x77BD8A0
        public void NoElements(){} // RVA: 0x77BD930
        public void MoreThanOneElement(){} // RVA: 0x77BD9A0
        public void ThrowArgumentException(){} // RVA: 0x77BDA10
        public void ThrowNotYetCompleted(){} // RVA: 0xA94080
        public void ThrowInvalidOperationExceptionCore(){} // RVA: 0x77BDAB0
        public void ThrowOperationCanceledException(){} // RVA: 0x77BDB00
    }

    public class ImmutableList`1 : Object
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894320
        public void Add(){} // RVA: 0xA94080
        public void Remove(){} // RVA: 0xA94080
        public void IndexOf(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class ListObserver`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void OnCompleted(){} // RVA: 0x894290
        public void OnError(){} // RVA: 0x894320
        public void OnNext(){} // RVA: 0xA94080
        public void Add(){} // RVA: 0x87C540
        public void Remove(){} // RVA: 0x87C540
    }

    public class MinimumQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8944F0
        public void get_Count(){} // RVA: 0x87C130
        public void Peek(){} // RVA: 0xA94080
        public void Enqueue(){} // RVA: 0xA94080
        public void Dequeue(){} // RVA: 0xA94080
        public void Grow(){} // RVA: 0x894290
        public void SetCapacity(){} // RVA: 0x8944F0
        public void MoveNext(){} // RVA: 0x894320
        public void ThrowForEmptyQueue(){} // RVA: 0x894290
    }

    public class MinimumQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x46CAC70
        public void get_Count(){} // RVA: 0xFEAE90
        public void Peek(){} // RVA: 0x46CAD60
        public void Enqueue(){} // RVA: 0x43E21C0
        public void Dequeue(){} // RVA: 0x43E2130
        public void Grow(){} // RVA: 0x46CADC0
        public void SetCapacity(){} // RVA: 0x46CAF30
        public void MoveNext(){} // RVA: 0x46CB070
        public void ThrowForEmptyQueue(){} // RVA: 0x46CB0A0
    }

    public class MinimumQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x46CAC70
        public void get_Count(){} // RVA: 0xFEAE90
        public void Dequeue(){} // RVA: 0x43E2130
        public void Enqueue(){} // RVA: 0x43E21C0
        public void Peek(){} // RVA: 0x46CAD60
        public void Grow(){} // RVA: 0x46CADC0
        public void SetCapacity(){} // RVA: 0x46CAF30
        public void MoveNext(){} // RVA: 0x46CB070
        public void ThrowForEmptyQueue(){} // RVA: 0x46CB0A0
    }

    public class MinimumQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x46CAC70
        public void get_Count(){} // RVA: 0xFEAE90
        public void Dequeue(){} // RVA: 0x43E2130
        public void Enqueue(){} // RVA: 0x43E21C0
        public void Peek(){} // RVA: 0x46CAD60
        public void Grow(){} // RVA: 0x46CADC0
        public void SetCapacity(){} // RVA: 0x46CAF30
        public void MoveNext(){} // RVA: 0x46CB070
        public void ThrowForEmptyQueue(){} // RVA: 0x46CB0A0
    }

    public class MinimumQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x46CAC70
        public void get_Count(){} // RVA: 0xFEAE90
        public void Dequeue(){} // RVA: 0x43E2130
        public void Enqueue(){} // RVA: 0x43E21C0
        public void Peek(){} // RVA: 0x46CAD60
        public void Grow(){} // RVA: 0x46CADC0
        public void SetCapacity(){} // RVA: 0x46CAF30
        public void MoveNext(){} // RVA: 0x46CB070
        public void ThrowForEmptyQueue(){} // RVA: 0x46CB0A0
    }

    public class MinimumQueue`1[] : Array
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

    public class MinimumQueue`1[] : Array
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

    public class MinimumQueue`1[] : Array
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

    public class PlayerLoopRunner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x77BDB40
        public void AddAction(){} // RVA: 0x77BDED0
        public void Clear(){} // RVA: 0x77BE270
        public void Run(){} // RVA: 0x77BE3F0
        public void Initialization(){} // RVA: 0x77BE3F0
        public void LastInitialization(){} // RVA: 0x77BE3F0
        public void EarlyUpdate(){} // RVA: 0x77BE3F0
        public void LastEarlyUpdate(){} // RVA: 0x77BE3F0
        public void FixedUpdate(){} // RVA: 0x77BE3F0
        public void LastFixedUpdate(){} // RVA: 0x77BE3F0
        public void PreUpdate(){} // RVA: 0x77BE3F0
        public void LastPreUpdate(){} // RVA: 0x77BE3F0
        public void Update(){} // RVA: 0x77BE3F0
        public void LastUpdate(){} // RVA: 0x77BE3F0
        public void PreLateUpdate(){} // RVA: 0x77BE3F0
        public void LastPreLateUpdate(){} // RVA: 0x77BE3F0
        public void PostLateUpdate(){} // RVA: 0x77BE3F0
        public void LastPostLateUpdate(){} // RVA: 0x77BE3F0
        public void TimeUpdate(){} // RVA: 0x77BE3F0
        public void LastTimeUpdate(){} // RVA: 0x77BE3F0
        public void RunCore(){} // RVA: 0x77BE400
    }

    public class PlayerLoopRunner[] : Array
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

    public class PooledDelegate`1 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x4866080
        public void get_NextNode(){} // RVA: 0x4865E00
        public void .cctor(){} // RVA: 0x4865E10
        public void .ctor(){} // RVA: 0x4865FB0
        public void Run(){} // RVA: 0x4866240
    }

    public class PooledDelegate`1 : Object
    {
        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x87C0A0
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void Create(){} // RVA: 0x87C5C0
        public void Run(){} // RVA: 0xA94080
    }

    public class RuntimeHelpersAbstraction : Object
    {
        // ── Methods ──
        public void IsWellKnownNoReferenceContainsType(){} // RVA: 0x29A52C0
        public void WellKnownNoReferenceContainsTypeInitialize(){} // RVA: 0x77BEC70
    }

    public class SingleAssignmentDisposable : Object
    {
        // ── Methods ──
        public void get_IsDisposed(){} // RVA: 0x75BFD90
        public void get_Disposable(){} // RVA: 0xB465B0
        public void set_Disposable(){} // RVA: 0x77C10A0
        public void Dispose(){} // RVA: 0x77C1310
        public void .ctor(){} // RVA: 0x77C14C0
    }

    public class StatePool`1 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DDF40
        public void Return(){} // RVA: 0x4B4CB90
        public void .cctor(){} // RVA: 0x4B4C870
    }

    public class StatePool`1 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0xA94080
        public void Return(){} // RVA: 0x894350
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class StatePool`1 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DDA40
        public void Return(){} // RVA: 0x4B4C9A0
        public void .cctor(){} // RVA: 0x4B4C870
    }

    public class StatePool`1 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DDF40
        public void Return(){} // RVA: 0x4B4CB90
        public void .cctor(){} // RVA: 0x4B4C870
    }

    public class StatePool`2 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DE440
        public void Return(){} // RVA: 0x4B4D360
        public void .cctor(){} // RVA: 0x4B4D450
    }

    public class StatePool`2 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DE440
        public void Return(){} // RVA: 0x4B4D360
        public void .cctor(){} // RVA: 0x4B4D450
    }

    public class StatePool`2 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DE440
        public void Return(){} // RVA: 0x4B4D360
        public void .cctor(){} // RVA: 0x4B4D450
    }

    public class StatePool`2 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0xA94080
        public void Return(){} // RVA: 0x894350
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class StatePool`2 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DE440
        public void Return(){} // RVA: 0x4B4D360
        public void .cctor(){} // RVA: 0x4B4D450
    }

    public class StatePool`2 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DEAA0
        public void Return(){} // RVA: 0x4B4D680
        public void .cctor(){} // RVA: 0x4B4D450
    }

    public class StatePool`2 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DE440
        public void Return(){} // RVA: 0x4B4D360
        public void .cctor(){} // RVA: 0x4B4D450
    }

    public class StatePool`3 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DF7A0
        public void Return(){} // RVA: 0x4B4E340
        public void .cctor(){} // RVA: 0x4B4E210
    }

    public class StatePool`3 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DF7A0
        public void Return(){} // RVA: 0x4B4E340
        public void .cctor(){} // RVA: 0x4B4E210
    }

    public class StatePool`3 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DF7A0
        public void Return(){} // RVA: 0x4B4E340
        public void .cctor(){} // RVA: 0x4B4E210
    }

    public class StatePool`3 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29DF470
        public void Return(){} // RVA: 0x4B4E120
        public void .cctor(){} // RVA: 0x4B4E210
    }

    public class StatePool`3 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0xA94080
        public void Return(){} // RVA: 0x894350
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class StateTuple : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x29C6B80
    }

    public class StateTuple`1 : Object
    {
        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x4B4F2A0
        public void Dispose(){} // RVA: 0x4B4F300
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StateTuple`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Deconstruct(){} // RVA: 0x4B4F2A0
        public void Dispose(){} // RVA: 0x4B4F300
    }

    public class StateTuple`1 : Object
    {
        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x894320
        public void Dispose(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0x894290
    }

    public class StateTuple`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Deconstruct(){} // RVA: 0x4B4EF60
        public void Dispose(){} // RVA: 0x4B4EFC0
    }

    public class StateTuple`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Deconstruct(){} // RVA: 0x4B4F750
        public void Dispose(){} // RVA: 0x4B4F800
    }

    public class StateTuple`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Deconstruct(){} // RVA: 0x4B4F750
        public void Dispose(){} // RVA: 0x4B4F800
    }

    public class StateTuple`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Deconstruct(){} // RVA: 0x4B4F750
        public void Dispose(){} // RVA: 0x4B4F800
    }

    public class StateTuple`2 : Object
    {
        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x4B4F750
        public void Dispose(){} // RVA: 0x4B4F800
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StateTuple`2 : Object
    {
        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x8943B0
        public void Dispose(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0x894290
    }

    public class StateTuple`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Deconstruct(){} // RVA: 0x4B4F750
        public void Dispose(){} // RVA: 0x4B4F800
    }

    public class StateTuple`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Deconstruct(){} // RVA: 0x4B4FB30
        public void Dispose(){} // RVA: 0x4B4FBF0
    }

    public class StateTuple`3 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Deconstruct(){} // RVA: 0x4B50560
        public void Dispose(){} // RVA: 0x4B50640
    }

    public class StateTuple`3 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Deconstruct(){} // RVA: 0x4B50560
        public void Dispose(){} // RVA: 0x4B50640
    }

    public class StateTuple`3 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Deconstruct(){} // RVA: 0x4B50560
        public void Dispose(){} // RVA: 0x4B50640
    }

    public class StateTuple`3 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Deconstruct(){} // RVA: 0x4B50360
        public void Dispose(){} // RVA: 0x4B50430
    }

    public class StateTuple`3 : Object
    {
        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x8954D0
        public void Dispose(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0x894290
    }

    public class ThrowObserver`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void OnCompleted(){} // RVA: 0x894290
        public void OnError(){} // RVA: 0x894320
        public void OnNext(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class UnityEqualityComparer : Object
    {
        // ── Methods ──
        public void GetDefault(){} // RVA: 0x87C0D0
        public void GetDefaultHelper(){} // RVA: 0x77BF110
        public void .cctor(){} // RVA: 0x77BF570
    }

    public class UnityWebRequestResultExtensions : Object
    {
        // ── Methods ──
        public void IsError(){} // RVA: 0x77C0D10
    }

    public class ValueStopwatch : ValueType
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x77C0DA0
        public void .ctor(){} // RVA: 0x93050
        public void get_Elapsed(){} // RVA: 0x923730
        public void get_IsInvalid(){} // RVA: 0x88E70
        public void get_ElapsedTicks(){} // RVA: 0x9237B0
        public void .cctor(){} // RVA: 0x77C0F70
    }

    public class WeakDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x897F80
        public void TryAdd(){} // RVA: 0xA94080
        public void TryGetValue(){} // RVA: 0xA94080
        public void TryRemove(){} // RVA: 0xA94080
        public void TryAddInternal(){} // RVA: 0xA94080
        public void AddToBuckets(){} // RVA: 0xA94080
        public void TryGetEntry(){} // RVA: 0xA94080
        public void Remove(){} // RVA: 0x895750
        public void ToList(){} // RVA: 0x885580
        public void CalculateCapacity(){} // RVA: 0xA94080
    }

}