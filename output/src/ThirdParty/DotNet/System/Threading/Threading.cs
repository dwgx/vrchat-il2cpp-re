// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading
// Classes: 91
// Methods: 671

namespace ThirdParty.DotNet.System.Threading
{
    public class AbandonedMutexException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD10DD0
        public void SetupException(){} // RVA: 0x7ADD10E60
    }

    public class AsyncFlowControl : ValueType
    {
        // ── Methods ──
        public void Setup(){} // RVA: 0x7A7E437D0
        public void Dispose(){} // RVA: 0x7A7E437E0
        public void Undo(){} // RVA: 0x7A7E437F0
        public void GetHashCode(){} // RVA: 0x7A7E43800
        public void Equals(){} // RVA: 0x7A7E43970
    }

    public class AsyncLocalValueChangedArgs`1 : ValueType
    {
        // ── Methods ──
        public void get_CurrentValue(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A8051B10
    }

    public class AsyncLocalValueChangedArgs`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7C87B70
    }

    public class AsyncLocal`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void get_Value(){} // RVA: 0x7A8051B10
        public void set_Value(){} // RVA: 0x7A8051B10
        public void System.Threading.IAsyncLocal.OnValueChanged(){} // RVA: 0x7A7E1EE20
    }

    public class AsyncLocal`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Value(){} // RVA: 0x7AC915440
        public void set_Value(){} // RVA: 0x7AC9154F0
        public void System.Threading.IAsyncLocal.OnValueChanged(){} // RVA: 0x7AC915570
    }

    public class AutoResetEvent : EventWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD10F20
    }

    public class CancellationCallbackCoreWorkArguments : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7613470
    }

    public class CancellationCallbackInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A811FE30
        public void ExecuteCallback(){} // RVA: 0x7ADD16E80
        public void ExecutionContextCallback(){} // RVA: 0x7ADD17040
    }

    public class CancellationCallbackInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class CancellationToken : ValueType
    {
        // ── Methods ──
        public void get_None(){} // RVA: 0x7A82D1450
        public void get_IsCancellationRequested(){} // RVA: 0x7A7E42C90
        public void get_CanBeCanceled(){} // RVA: 0x7A763CB50
        public void .ctor(){} // RVA: 0x7A7E42CB0
        public void Register(){} // RVA: 0x7A7E42FD0
        public void InternalRegisterWithoutEC(){} // RVA: 0x7A7E42F90
        public void Equals(){} // RVA: 0x7A7E43030
        public void GetHashCode(){} // RVA: 0x7A7E43040
        public void op_Equality(){} // RVA: 0x7ADD11B00
        public void op_Inequality(){} // RVA: 0x7ADD11B60
        public void ThrowIfCancellationRequested(){} // RVA: 0x7A7E43050
        public void ThrowOperationCanceledException(){} // RVA: 0x7A7E43060
        public void .cctor(){} // RVA: 0x7ADD11CA0
    }

    public class CancellationTokenRegistration : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E43120
        public void get_Token(){} // RVA: 0x7A7E43140
        public void Unregister(){} // RVA: 0x7A7E43170
        public void Dispose(){} // RVA: 0x7A7E43180
        public void Equals(){} // RVA: 0x7A7E431A0
        public void GetHashCode(){} // RVA: 0x7A7E43240
        public void DisposeAsync(){} // RVA: 0x7A7E43250
    }

    public class CancellationTokenSource : Object
    {
        // ── Methods ──
        public void get_IsCancellationRequested(){} // RVA: 0x7ADD144D0
        public void get_IsCancellationCompleted(){} // RVA: 0x7ADD144E0
        public void get_IsDisposed(){} // RVA: 0x7A84A5BD0
        public void get_ThreadIDExecutingCallbacks(){} // RVA: 0x7ADD144F0
        public void set_ThreadIDExecutingCallbacks(){} // RVA: 0x7ADD14500
        public void get_Token(){} // RVA: 0x7ADD14510
        public void get_ExecutingCallback(){} // RVA: 0x7ADBCC6A0
        public void .ctor(){} // RVA: 0x7ADD146E0
        public void InitializeWithTimer(){} // RVA: 0x7ADD14760
        public void Cancel(){} // RVA: 0x7ADD148E0
        public void CancelAfter(){} // RVA: 0x7ADD14A40
        public void TimerCallbackLogic(){} // RVA: 0x7ADD14C70
        public void Dispose(){} // RVA: 0x7ADD14DE0
        public void ThrowIfDisposed(){} // RVA: 0x7ADD14F30
        public void ThrowObjectDisposedException(){} // RVA: 0x7ADD14F80
        public void InternalRegister(){} // RVA: 0x7ADD14FE0
        public void NotifyCancellation(){} // RVA: 0x7ADD155B0
        public void ExecuteCallbackHandlers(){} // RVA: 0x7ADD15670
        public void CancellationCallbackCoreWork_OnSyncContext(){} // RVA: 0x7ADD15B20
        public void CancellationCallbackCoreWork(){} // RVA: 0x7ADD15BA0
        public void CreateLinkedTokenSource(){} // RVA: 0x7ADD15FD0
        public void WaitForCallbackToComplete(){} // RVA: 0x7ADD16170
        public void .cctor(){} // RVA: 0x7ADD16240
    }

    public class CancellationToken[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2CE200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2A50
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA27DA80
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ContextCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81577F0
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class ContextCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DFE0
        public void Invoke(){} // RVA: 0x7A7E18800
    }

    public class DeferredDisposableLifetime`1 : ValueType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A7E187D0
        public void AddRef(){} // RVA: 0x7A8051B10
        public void Release(){} // RVA: 0x7A8051B10
        public void Dispose(){} // RVA: 0x7A8051B10
    }

    public class DeferredDisposableLifetime`1 : ValueType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A8DD7270
        public void AddRef(){} // RVA: 0x7A77F3B00
        public void Release(){} // RVA: 0x7A77F3B10
        public void Dispose(){} // RVA: 0x7A77F3BA0
    }

    public class DeferredDisposableLifetime`1 : ValueType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A8DD7270
        public void AddRef(){} // RVA: 0x7A77F3B00
        public void Release(){} // RVA: 0x7A77F3B10
        public void Dispose(){} // RVA: 0x7A77F3BA0
    }

    public class EventWaitHandle : WaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD1DAB0
        public void Reset(){} // RVA: 0x7ADD1DE30
        public void Set(){} // RVA: 0x7ADD1DE90
    }

    public class ExecutionContext : Object
    {
        // ── Methods ──
        public void get_isNewCapture(){} // RVA: 0x7ADD1E550
        public void set_isNewCapture(){} // RVA: 0x7ADD1E560
        public void get_isFlowSuppressed(){} // RVA: 0x7ADD1E580
        public void set_isFlowSuppressed(){} // RVA: 0x7ADD1E590
        public void get_IsPreAllocatedDefault(){} // RVA: 0x7ADD1E5B0
        public void .ctor(){} // RVA: 0x7ADD20700
        public void GetLocalValue(){} // RVA: 0x7ADD1E5D0
        public void SetLocalValue(){} // RVA: 0x7ADD1E6B0
        public void OnAsyncLocalContextChanged(){} // RVA: 0x7ADD1EA50
        public void get_LogicalCallContext(){} // RVA: 0x7ADD1EEA0
        public void set_LogicalCallContext(){} // RVA: 0x7A81052D0
        public void get_IllogicalCallContext(){} // RVA: 0x7ADD1EF40
        public void set_IllogicalCallContext(){} // RVA: 0x7A80D8E80
        public void get_SynchronizationContext(){} // RVA: 0x7A80F2570
        public void set_SynchronizationContext(){} // RVA: 0x7A80D8E20
        public void get_SynchronizationContextNoFlow(){} // RVA: 0x7A80DA7B0
        public void set_SynchronizationContextNoFlow(){} // RVA: 0x7A813E420
        public void Dispose(){} // RVA: 0x7A8DD7270
        public void Run(){} // RVA: 0x7ADD1F120
        public void RunInternal(){} // RVA: 0x7A7E23170
        public void EstablishCopyOnWriteScope(){} // RVA: 0x7ADD1F4C0
        public void SetExecutionContext(){} // RVA: 0x7ADD1F600
        public void CreateCopy(){} // RVA: 0x7ADD1F920
        public void CreateMutableCopy(){} // RVA: 0x7ADD1FB70
        public void SuppressFlow(){} // RVA: 0x7ADD1FE60
        public void RestoreFlow(){} // RVA: 0x7ADD1FF40
        public void IsFlowSuppressed(){} // RVA: 0x7ADD1FFE0
        public void Capture(){} // RVA: 0x7ADD20110
        public void FastCapture(){} // RVA: 0x7ADD200C0
        public void GetObjectData(){} // RVA: 0x7ADD20550
        public void IsDefaultFTContext(){} // RVA: 0x7ADD20930
        public void .cctor(){} // RVA: 0x7ADD209A0
    }

    public class ExecutionContextSwitcher : ValueType
    {
        // ── Methods ──
        public void UndoNoThrow(){} // RVA: 0x7A7E43790
        public void Undo(){} // RVA: 0x7A7E437A0
    }

    public class IAsyncLocal
    {
        // ── Methods ──
        public void OnValueChanged(){} // RVA: 0x7A7E1EE20
    }

    public class IAsyncLocal[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IDeferredDisposable
    {
        // ── Methods ──
        public void OnFinalRelease(){} // RVA: 0x7A7E18C30
    }

    public class IOCompletionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB4CA0E0
        public void Invoke(){} // RVA: 0x7A8234660
    }

    public class IThreadPoolWorkItem
    {
        // ── Methods ──
        public void ExecuteWorkItem(){} // RVA: 0x7A7E18770
        public void MarkAborted(){} // RVA: 0x7A7E18800
    }

    public class IThreadPoolWorkItem[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Interlocked : Object
    {
        // ── Methods ──
        public void CompareExchange(){} // RVA: 0x7A8051B10
        public void Decrement(){} // RVA: 0x7ADD2BBB0
        public void Increment(){} // RVA: 0x7ADD2BBD0
        public void Exchange(){} // RVA: 0x7A8051B10
        public void Read(){} // RVA: 0x7ADD2BD20
        public void Add(){} // RVA: 0x7ADD2BD40
        public void MemoryBarrier(){} // RVA: 0x7ADD24E80
    }

    public class InternalThread : CriticalFinalizerObject
    {
        // ── Methods ──
        public void Thread_free_internal(){} // RVA: 0x7ADD2E820
        public void Finalize(){} // RVA: 0x7ADD2E8C0
        public void .ctor(){} // RVA: 0x7ADD2E9A0
    }

    public class LazyInitializer : Object
    {
        // ── Methods ──
        public void EnsureInitialized(){} // RVA: 0x7AA50CC90
        public void EnsureInitializedCore(){} // RVA: 0x7AA50D030
        public void EnsureLockInitialized(){} // RVA: 0x7ADD10F40
    }

    public class Lock : Object
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7ADD19B70
        public void Release(){} // RVA: 0x7ADD19BB0
        public void .ctor(){} // RVA: 0x7ADD19BE0
    }

    public class LockHolder : ValueType
    {
        // ── Methods ──
        public void Hold(){} // RVA: 0x7ADD17150
        public void Dispose(){} // RVA: 0x7A7E433C0
    }

    public class LockQueue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Wait(){} // RVA: 0x7ADD2BD50
        public void get_IsEmpty(){} // RVA: 0x7ADD2BF60
        public void Pulse(){} // RVA: 0x7ADD2C070
    }

    public class LockRecursionException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD110B0
    }

    public class ManualResetEvent : EventWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD11130
    }

    public class ManualResetEventSlim : Object
    {
        // ── Methods ──
        public void get_WaitHandle(){} // RVA: 0x7ADD11ED0
        public void get_IsSet(){} // RVA: 0x7ADD11F10
        public void set_IsSet(){} // RVA: 0x7ADD11F70
        public void get_SpinCount(){} // RVA: 0x7ADD11FA0
        public void set_SpinCount(){} // RVA: 0x7ADD12000
        public void get_Waiters(){} // RVA: 0x7ADD12020
        public void set_Waiters(){} // RVA: 0x7ADD12080
        public void .ctor(){} // RVA: 0x7ADD12240
        public void Initialize(){} // RVA: 0x7ADD12340
        public void EnsureLockObjectCreated(){} // RVA: 0x7ADD12400
        public void LazyInitializeEvent(){} // RVA: 0x7ADD124B0
        public void Set(){} // RVA: 0x7ADD12780
        public void Wait(){} // RVA: 0x7ADD12BA0
        public void Dispose(){} // RVA: 0x7ADD134E0
        public void ThrowIfDisposed(){} // RVA: 0x7ADD13650
        public void CancellationTokenCallback(){} // RVA: 0x7ADD136C0
        public void UpdateStateAtomically(){} // RVA: 0x7ADD13840
        public void ExtractStatePortionAndShiftRight(){} // RVA: 0x7ADD13920
        public void ExtractStatePortion(){} // RVA: 0x7ADD13930
        public void .cctor(){} // RVA: 0x7ADD13940
    }

    public class Monitor : Object
    {
        // ── Methods ──
        public void Enter(){} // RVA: 0x7ADD20CA0
        public void ThrowLockTakenException(){} // RVA: 0x7ADD20D20
        public void Exit(){} // RVA: 0x7ADD20D90
        public void TryEnter(){} // RVA: 0x7ADD21210
        public void MillisecondsTimeoutFromTimeSpan(){} // RVA: 0x7ADD20F60
        public void IsEntered(){} // RVA: 0x7ADD212D0
        public void Wait(){} // RVA: 0x7ADD21350
        public void Pulse(){} // RVA: 0x7ADD21470
        public void PulseAll(){} // RVA: 0x7ADD21540
        public void Monitor_test_synchronised(){} // RVA: 0x7ADD21650
        public void Monitor_pulse(){} // RVA: 0x7ADD216A0
        public void ObjPulse(){} // RVA: 0x7ADD216D0
        public void Monitor_pulse_all(){} // RVA: 0x7ADD21770
        public void ObjPulseAll(){} // RVA: 0x7ADD217E0
        public void Monitor_wait(){} // RVA: 0x7ADD218C0
        public void ObjWait(){} // RVA: 0x7ADD218F0
        public void try_enter_with_atomic_var(){} // RVA: 0x7ADD219E0
        public void ReliableEnterTimeout(){} // RVA: 0x7ADD21A20
        public void ReliableEnter(){} // RVA: 0x7ADD21B00
        public void Monitor_test_owner(){} // RVA: 0x7ADD21B90
        public void IsEnteredNative(){} // RVA: 0x7ADD21B90
    }

    public class Mutex : WaitHandle
    {
        // ── Methods ──
        public void ReleaseMutex_internal(){} // RVA: 0x7ADD2C230
        public void .ctor(){} // RVA: 0x7ADD2C250
        public void ReleaseMutex(){} // RVA: 0x7ADD2C2B0
    }

    public class NativeEventCalls : Object
    {
        // ── Methods ──
        public void CreateEvent_internal(){} // RVA: 0x7ADD2C2E0
        public void CreateEvent_icall(){} // RVA: 0x7ADD2C370
        public void SetEvent(){} // RVA: 0x7ADD2C400
        public void SetEvent_internal(){} // RVA: 0x7ADD2C4E0
        public void ResetEvent(){} // RVA: 0x7ADD2C500
        public void ResetEvent_internal(){} // RVA: 0x7ADD2C610
        public void CloseEvent_internal(){} // RVA: 0x7ADD2C660
    }

    public class OSSpecificSynchronizationContext : SynchronizationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A813E420
        public void Get(){} // RVA: 0x7ADD225C0
        public void CreateCopy(){} // RVA: 0x7ADD22800
        public void Send(){} // RVA: 0x7ADD228A0
        public void Post(){} // RVA: 0x7ADD228E0
        public void InvocationEntry(){} // RVA: 0x7ADD22C70
        public void GetOSContext(){} // RVA: 0x7ADD22E00
        public void PostInternal(){} // RVA: 0x7ADD22E90
        public void .cctor(){} // RVA: 0x7ADD22FB0
    }

    public class ParameterizedThreadStart : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81577F0
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class PlatformHelper : Object
    {
        // ── Methods ──
        public void get_ProcessorCount(){} // RVA: 0x7ADD13DE0
        public void .cctor(){} // RVA: 0x7ADD13EE0
    }

    public class PreAllocatedOverlapped : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A8DD7270
        public void Release(){} // RVA: 0x7ADD19920
        public void Dispose(){} // RVA: 0x7ADD199F0
        public void System.Threading.IDeferredDisposable.OnFinalRelease(){} // RVA: 0x7ADD19AE0
    }

    public class QueueUserWorkItemCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD28C20
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7ADD28DC0
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7A80D7310
        public void WaitCallback_Context(){} // RVA: 0x7ADD28F00
        public void .cctor(){} // RVA: 0x7ADD28F80
    }

    public class ReaderWriterCount : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ReaderWriterLock : CriticalFinalizerObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD2C680
        public void Finalize(){} // RVA: 0x7ADD25190
        public void get_IsReaderLockHeld(){} // RVA: 0x7ADD2C840
        public void get_IsWriterLockHeld(){} // RVA: 0x7ADD2C9E0
        public void AcquireReaderLock(){} // RVA: 0x7ADD2CB30
        public void AcquireWriterLock(){} // RVA: 0x7ADD2D030
        public void ReleaseReaderLock(){} // RVA: 0x7ADD2D690
        public void ReleaseWriterLock(){} // RVA: 0x7ADD2D9B0
        public void HasWriterLock(){} // RVA: 0x7ADD2DA10
    }

    public class ReaderWriterLockSlim : Object
    {
        // ── Methods ──
        public void InitializeThreadCounts(){} // RVA: 0x7AE46C180
        public void .ctor(){} // RVA: 0x7AE46C1F0
        public void IsRWEntryEmpty(){} // RVA: 0x7AE46C260
        public void IsRwHashEntryChanged(){} // RVA: 0x7AE46C2A0
        public void GetThreadRWCount(){} // RVA: 0x7AE46C2C0
        public void EnterReadLock(){} // RVA: 0x7AE46C430
        public void TryEnterReadLock(){} // RVA: 0x7AE46C4E0
        public void TryEnterReadLockCore(){} // RVA: 0x7AE46C4F0
        public void EnterWriteLock(){} // RVA: 0x7AE46C860
        public void TryEnterWriteLock(){} // RVA: 0x7AE46C910
        public void TryEnterWriteLockCore(){} // RVA: 0x7AE46C920
        public void EnterUpgradeableReadLock(){} // RVA: 0x7AE46CE00
        public void TryEnterUpgradeableReadLock(){} // RVA: 0x7AE46CEB0
        public void TryEnterUpgradeableReadLockCore(){} // RVA: 0x7AE46CEC0
        public void ExitReadLock(){} // RVA: 0x7AE46D350
        public void ExitWriteLock(){} // RVA: 0x7AE46D560
        public void ExitUpgradeableReadLock(){} // RVA: 0x7AE46D790
        public void LazyCreateEvent(){} // RVA: 0x7AE46DB00
        public void WaitOnEvent(){} // RVA: 0x7AE46DC40
        public void ExitAndWakeUpAppropriateWaiters(){} // RVA: 0x7AE46DEE0
        public void ExitAndWakeUpAppropriateWaitersPreferringWriters(){} // RVA: 0x7AE46DF70
        public void ExitAndWakeUpAppropriateReadWaiters(){} // RVA: 0x7AE46DFF0
        public void IsWriterAcquired(){} // RVA: 0x7AE46E080
        public void SetWriterAcquired(){} // RVA: 0x7AE46E090
        public void ClearWriterAcquired(){} // RVA: 0x7AE46E0A0
        public void SetWritersWaiting(){} // RVA: 0x7AE46E0B0
        public void ClearWritersWaiting(){} // RVA: 0x7AE46E0C0
        public void SetUpgraderWaiting(){} // RVA: 0x7AE46E0D0
        public void ClearUpgraderWaiting(){} // RVA: 0x7AE46E0E0
        public void GetNumReaders(){} // RVA: 0x7AE46E0F0
        public void EnterMyLock(){} // RVA: 0x7AE46E100
        public void EnterMyLockSpin(){} // RVA: 0x7AE46E120
        public void ExitMyLock(){} // RVA: 0x7AE46E290
        public void SpinWait(){} // RVA: 0x7AE46E2A0
        public void Dispose(){} // RVA: 0x7AE46E330
        public void get_IsReadLockHeld(){} // RVA: 0x7AE46E7A0
        public void get_IsUpgradeableReadLockHeld(){} // RVA: 0x7AE46E860
        public void get_IsWriteLockHeld(){} // RVA: 0x7AE46E9A0
        public void get_RecursiveReadCount(){} // RVA: 0x7AE46EAE0
        public void get_RecursiveUpgradeCount(){} // RVA: 0x7AE46EBA0
        public void get_RecursiveWriteCount(){} // RVA: 0x7AE46ECE0
        public void get_WaitingReadCount(){} // RVA: 0x7A9739200
        public void get_WaitingUpgradeCount(){} // RVA: 0x7A8AB15F0
        public void get_WaitingWriteCount(){} // RVA: 0x7A83782A0
    }

    public class RegisteredWaitHandle : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD2DA60
        public void Wait(){} // RVA: 0x7ADD2DC90
        public void DoCallBack(){} // RVA: 0x7ADD2E400
        public void Unregister(){} // RVA: 0x7ADD2E660
    }

    public class SemaphoreFullException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class SemaphoreSlim : Object
    {
        // ── Methods ──
        public void get_CurrentCount(){} // RVA: 0x7ADD19C70
        public void .ctor(){} // RVA: 0x7ADD19C90
        public void Wait(){} // RVA: 0x7ADD19E70
        public void WaitUntilCountOrTimeout(){} // RVA: 0x7ADD1A740
        public void WaitAsync(){} // RVA: 0x7ADD1A880
        public void CreateAndAddAsyncWaiter(){} // RVA: 0x7ADD1ACA0
        public void RemoveAsyncWaiter(){} // RVA: 0x7ADD1AF10
        public void WaitUntilCountOrTimeoutAsync(){} // RVA: 0x7ADD1B180
        public void Release(){} // RVA: 0x7ADD1B400
        public void QueueWaiterTask(){} // RVA: 0x7ADD1B750
        public void Dispose(){} // RVA: 0x7ADD1B7D0
        public void CancellationTokenCanceledEventHandler(){} // RVA: 0x7ADD1B980
        public void CheckDispose(){} // RVA: 0x7ADD1BAF0
        public void GetResourceString(){} // RVA: 0x7A97F8BA0
        public void .cctor(){} // RVA: 0x7ADD1BB80
    }

    public class SendOrPostCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81577F0
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class SparselyPopulatedArrayAddInfo`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1D590
        public void get_Source(){} // RVA: 0x7A7E00680
        public void get_Index(){} // RVA: 0x7A7E00710
    }

    public class SparselyPopulatedArrayAddInfo`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7613470
        public void get_Source(){} // RVA: 0x7A765F710
        public void get_Index(){} // RVA: 0x7A75FEFA0
    }

    public class SparselyPopulatedArrayFragment`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E19BE0
        public void get_Item(){} // RVA: 0x7A8051B10
        public void get_Length(){} // RVA: 0x7A7E00710
        public void get_Prev(){} // RVA: 0x7A7E00680
        public void SafeAtomicRemove(){} // RVA: 0x7A8051B10
    }

    public class SparselyPopulatedArrayFragment`1 : Object
    {
        // ── Methods ──
        public void SafeAtomicRemove(){} // RVA: 0x7ABE750E0
        public void get_Item(){} // RVA: 0x7ABE75090
        public void get_Prev(){} // RVA: 0x7ABE750D0
        public void .ctor(){} // RVA: 0x7ABE74F80
        public void get_Length(){} // RVA: 0x7A8D0A110
    }

    public class SparselyPopulatedArray`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E189D0
        public void get_Tail(){} // RVA: 0x7A7E00680
        public void Add(){} // RVA: 0x7A8051B10
    }

    public class SparselyPopulatedArray`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABE75190
        public void get_Tail(){} // RVA: 0x7ABE752C0
        public void Add(){} // RVA: 0x7ABE752D0
    }

    public class SparselyPopulatedArray`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SpinLock : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E434F0
        public void Enter(){} // RVA: 0x7A7E43520
        public void TryEnter(){} // RVA: 0x7A7E43530
        public void ContinueTryEnter(){} // RVA: 0x7A7E43540
        public void DecrementWaiters(){} // RVA: 0x7A7E43550
        public void ContinueTryEnterWithThreadTracking(){} // RVA: 0x7A7E43560
        public void Exit(){} // RVA: 0x7A7E43570
        public void ExitSlowPath(){} // RVA: 0x7A7E43580
        public void get_IsHeldByCurrentThread(){} // RVA: 0x7A7E43590
        public void get_IsThreadOwnerTrackingEnabled(){} // RVA: 0x7A7E435A0
        public void .cctor(){} // RVA: 0x7ADD1D7A0
    }

    public class SpinLock[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A3CC0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E4410
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25D800
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SpinWait : ValueType
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7A765F070
        public void get_NextSpinWillYield(){} // RVA: 0x7A7E43070
        public void SpinOnce(){} // RVA: 0x7A7E430E0
        public void SpinOnceCore(){} // RVA: 0x7A7E430F0
        public void Reset(){} // RVA: 0x7A7682C10
        public void .cctor(){} // RVA: 0x7ADD13D50
    }

    public class SynchronizationContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void SetWaitNotificationRequired(){} // RVA: 0x7ADD21BF0
        public void IsWaitNotificationRequired(){} // RVA: 0x7ADD21F90
        public void Send(){} // RVA: 0x7AB10E320
        public void Post(){} // RVA: 0x7ADD21FA0
        public void OperationStarted(){} // RVA: 0x7A80D7310
        public void OperationCompleted(){} // RVA: 0x7A80D7310
        public void Wait(){} // RVA: 0x7ADD22030
        public void WaitHelper(){} // RVA: 0x7ADD22120
        public void SetSynchronizationContext(){} // RVA: 0x7ADD221C0
        public void get_Current(){} // RVA: 0x7ADD222B0
        public void get_CurrentNoFlow(){} // RVA: 0x7ADD22370
        public void GetThreadLocalContext(){} // RVA: 0x7ADD22430
        public void CreateCopy(){} // RVA: 0x7ADD22480
        public void get_CurrentExplicit(){} // RVA: 0x7ADD224C0
    }

    public class SynchronizationLockException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class Thread : CriticalFinalizerObject
    {
        // ── Methods ──
        public void AsyncLocalSetCurrentUICulture(){} // RVA: 0x7ADD23650
        public void .ctor(){} // RVA: 0x7ADD23860
        public void Start(){} // RVA: 0x7ADD23A80
        public void GetExecutionContextReader(){} // RVA: 0x7ADD23C80
        public void get_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x7ADD23CE0
        public void set_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x7ADD23CF0
        public void GetMutableExecutionContext(){} // RVA: 0x7ADD23D00
        public void SetExecutionContext(){} // RVA: 0x7ADD23E30
        public void get_Priority(){} // RVA: 0x7ADD23E90
        public void set_Priority(){} // RVA: 0x7ADD23F10
        public void GetPriorityNative(){} // RVA: 0x7ADD23E90
        public void SetPriorityNative(){} // RVA: 0x7ADD23F10
        public void JoinInternal(){} // RVA: 0x7ADD23FA0
        public void Join(){} // RVA: 0x7ADD24070
        public void SleepInternal(){} // RVA: 0x7ADD24130
        public void Sleep(){} // RVA: 0x7ADD241C0
        public void YieldInternal(){} // RVA: 0x7ADA11830
        public void Yield(){} // RVA: 0x7ADA11830
        public void SetStartHelper(){} // RVA: 0x7ADD242C0
        public void get_CurrentUICulture(){} // RVA: 0x7ADD244A0
        public void set_CurrentUICulture(){} // RVA: 0x7ADD244E0
        public void GetCurrentUICultureNoAppX(){} // RVA: 0x7ADD248C0
        public void get_CurrentCulture(){} // RVA: 0x7ADD24A70
        public void GetCurrentCultureNoAppX(){} // RVA: 0x7ADD24AB0
        public void nativeInitCultureAccessors(){} // RVA: 0x7ADD24C20
        public void MemoryBarrier(){} // RVA: 0x7ADD24E80
        public void ConstructInternalThread(){} // RVA: 0x7ADD24E90
        public void get_Internal(){} // RVA: 0x7ADD24ED0
        public void get_CurrentContext(){} // RVA: 0x7ADAD4970
        public void GetCurrentThread_icall(){} // RVA: 0x7ADD24F30
        public void GetCurrentThread(){} // RVA: 0x7ADD24FB0
        public void get_CurrentThread(){} // RVA: 0x7ADD25050
        public void get_CurrentThreadId(){} // RVA: 0x7ADD25150
        public void GetDomainID(){} // RVA: 0x7ADCEAE80
        public void Thread_internal(){} // RVA: 0x7ADD25180
        public void Finalize(){} // RVA: 0x7ADD25190
        public void get_IsThreadPoolThread(){} // RVA: 0x7ADD251D0
        public void get_IsThreadPoolThreadInternal(){} // RVA: 0x7ADD251D0
        public void get_IsAlive(){} // RVA: 0x7ADD25230
        public void set_IsBackground(){} // RVA: 0x7ADD25290
        public void GetName_internal(){} // RVA: 0x7ADD25400
        public void SetName_icall(){} // RVA: 0x7ADD254C0
        public void SetName_internal(){} // RVA: 0x7ADD254D0
        public void get_Name(){} // RVA: 0x7ADD25500
        public void set_Name(){} // RVA: 0x7ADD25600
        public void get_ThreadState(){} // RVA: 0x7ADD25670
        public void Abort_internal(){} // RVA: 0x7ADD256C0
        public void Abort(){} // RVA: 0x7ADD256D0
        public void SpinWait_nop(){} // RVA: 0x7A80D7310
        public void SpinWait(){} // RVA: 0x7ADD25720
        public void StartInternal(){} // RVA: 0x7ADD25730
        public void SetState(){} // RVA: 0x7ADD257E0
        public void ClrState(){} // RVA: 0x7ADD257F0
        public void GetState(){} // RVA: 0x7ADD25800
        public void VolatileRead(){} // RVA: 0x7A9FADF10
        public void SystemMaxStackStize(){} // RVA: 0x7ADA219E0
        public void GetProcessDefaultStackSize(){} // RVA: 0x7ADD25870
        public void SetStart(){} // RVA: 0x7ADD258F0
        public void get_ManagedThreadId(){} // RVA: 0x7ADD259B0
        public void BeginCriticalRegion(){} // RVA: 0x7ADD25A10
        public void EndCriticalRegion(){} // RVA: 0x7ADD25A90
        public void GetHashCode(){} // RVA: 0x7ADD259B0
        public void ValidateThreadState(){} // RVA: 0x7ADD25B10
    }

    public class ThreadAbortException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class ThreadHelper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void SetExecutionContextHelper(){} // RVA: 0x7A81052D0
        public void ThreadStart_Context(){} // RVA: 0x7ADD231C0
        public void ThreadStart(){} // RVA: 0x7ADD23460
        public void .cctor(){} // RVA: 0x7ADD23570
    }

    public class ThreadInterruptedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class ThreadLocal`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void Initialize(){} // RVA: 0x7A7E1D550
        public void Finalize(){} // RVA: 0x7A7E18770
        public void Dispose(){} // RVA: 0x7A7E18C30
        public void ToString(){} // RVA: 0x7A7E00680
        public void get_Value(){} // RVA: 0x7A8051B10
        public void set_Value(){} // RVA: 0x7A8051B10
        public void GetValueSlow(){} // RVA: 0x7A8051B10
        public void SetValueSlow(){} // RVA: 0x7A8051B10
        public void CreateLinkedSlot(){} // RVA: 0x7A8051B10
        public void get_IsValueCreated(){} // RVA: 0x7A7E01900
        public void GrowTable(){} // RVA: 0x7A7E1D590
        public void GetNewTableSize(){} // RVA: 0x7A7E07D40
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class ThreadLocal`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC1D9070
        public void Initialize(){} // RVA: 0x7AC1D91E0
        public void Finalize(){} // RVA: 0x7AC1D9360
        public void Dispose(){} // RVA: 0x7AC1D9440
        public void ToString(){} // RVA: 0x7AC1D97E0
        public void get_Value(){} // RVA: 0x7AC1D9890
        public void set_Value(){} // RVA: 0x7AC1D99B0
        public void GetValueSlow(){} // RVA: 0x7AC1D9AD0
        public void SetValueSlow(){} // RVA: 0x7AC1D9D20
        public void CreateLinkedSlot(){} // RVA: 0x7AC1DA310
        public void get_IsValueCreated(){} // RVA: 0x7AC1DA7C0
        public void GrowTable(){} // RVA: 0x7AC1DA8D0
        public void GetNewTableSize(){} // RVA: 0x7AC1DABE0
        public void .cctor(){} // RVA: 0x7AC1DAC20
    }

    public class ThreadPool : Object
    {
        // ── Methods ──
        public void GetMaxThreads(){} // RVA: 0x7ADD29060
        public void GetMinThreads(){} // RVA: 0x7ADD290B0
        public void GetAvailableThreads(){} // RVA: 0x7ADD29100
        public void RegisterWaitForSingleObject(){} // RVA: 0x7ADD295F0
        public void QueueUserWorkItem(){} // RVA: 0x7AA608C50
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7A8051B10
        public void QueueUserWorkItemHelper(){} // RVA: 0x7ADD299F0
        public void UnsafeQueueCustomWorkItem(){} // RVA: 0x7ADD29D80
        public void TryPopCustomWorkItem(){} // RVA: 0x7ADD29E60
        public void RequestWorkerThread(){} // RVA: 0x7ADD29FA0
        public void EnsureVMInitialized(){} // RVA: 0x7ADD29FC0
        public void GetMinThreadsNative(){} // RVA: 0x7ADD290B0
        public void GetMaxThreadsNative(){} // RVA: 0x7ADD29060
        public void GetAvailableThreadsNative(){} // RVA: 0x7ADD29100
        public void NotifyWorkItemComplete(){} // RVA: 0x7ADD2A070
        public void ReportThreadStatus(){} // RVA: 0x7ADB89E70
        public void NotifyWorkItemProgress(){} // RVA: 0x7ADA23180
        public void NotifyWorkItemProgressNative(){} // RVA: 0x7ADD2A100
        public void NotifyWorkItemQueued(){} // RVA: 0x7A80D7310
        public void InitializeVMTp(){} // RVA: 0x7ADD2A160
        public void get_IsThreadPoolThread(){} // RVA: 0x7ADD2A170
    }

    public class ThreadPoolBoundHandle : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A8DD7270
        public void .ctor(){} // RVA: 0x7ADD17380
        public void get_Handle(){} // RVA: 0x7A80F2570
        public void BindHandle(){} // RVA: 0x7ADD17430
        public void AllocateNativeOverlapped(){} // RVA: 0x7ADD179C0
        public void FreeNativeOverlapped(){} // RVA: 0x7ADD17C50
        public void GetNativeOverlappedState(){} // RVA: 0x7ADD17F60
        public void GetOverlappedData(){} // RVA: 0x7ADD18040
        public void OnNativeIOCompleted(){} // RVA: 0x7ADD18180
        public void AddRef(){} // RVA: 0x7ADD183A0
        public void Release(){} // RVA: 0x7ADD18410
        public void Dispose(){} // RVA: 0x7ADD184E0
        public void Finalize(){} // RVA: 0x7ADD185D0
        public void System.Threading.IDeferredDisposable.OnFinalRelease(){} // RVA: 0x7ADD18620
    }

    public class ThreadPoolCallbackWrapper : ValueType
    {
        // ── Methods ──
        public void Enter(){} // RVA: 0x7ADD17230
        public void Exit(){} // RVA: 0x7A7E43420
    }

    public class ThreadPoolGlobals : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADD25C90
    }

    public class ThreadPoolWorkQueue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD25E60
        public void EnsureCurrentThreadHasQueue(){} // RVA: 0x7ADD25F70
        public void EnsureThreadRequested(){} // RVA: 0x7ADD260C0
        public void MarkThreadRequestSatisfied(){} // RVA: 0x7ADD26160
        public void Enqueue(){} // RVA: 0x7ADD26190
        public void LocalFindAndPop(){} // RVA: 0x7ADD26400
        public void Dequeue(){} // RVA: 0x7ADD264B0
        public void Dispatch(){} // RVA: 0x7ADD26770
        public void .cctor(){} // RVA: 0x7ADD26D40
    }

    public class ThreadPoolWorkQueueThreadLocals : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD286E0
        public void CleanUp(){} // RVA: 0x7ADD289D0
        public void Finalize(){} // RVA: 0x7ADD28B50
    }

    public class ThreadStart : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8135E00
        public void Invoke(){} // RVA: 0x7A8135ED0
    }

    public class ThreadStateException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class Thread[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Timeout : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADD11280
    }

    public class TimeoutHelper : Object
    {
        // ── Methods ──
        public void GetTime(){} // RVA: 0x7ADCECFB0
        public void UpdateTimeOut(){} // RVA: 0x7ADD13F30
    }

    public class Timer : MarshalByRefObject
    {
        // ── Methods ──
        public void get_scheduler(){} // RVA: 0x7ADD2E9B0
        public void .ctor(){} // RVA: 0x7ADD2EB60
        public void Init(){} // RVA: 0x7ADD2EB90
        public void Change(){} // RVA: 0x7ADD2EE00
        public void Dispose(){} // RVA: 0x7ADD2EDC0
        public void DisposeAsync(){} // RVA: 0x7ADD2F070
        public void KeepRootedWhileScheduled(){} // RVA: 0x7A80D7310
        public void GetTimeMonotonic(){} // RVA: 0x7ADD2F1B0
    }

    public class TimerCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81577F0
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class Timer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Volatile : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7A9FADF20
        public void Read(){} // RVA: 0x7A9FADF10
    }

    public class WaitCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81577F0
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class WaitHandle : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD2A1E0
        public void Init(){} // RVA: 0x7ADD2A1E0
        public void get_Handle(){} // RVA: 0x7ADD2A2A0
        public void set_Handle(){} // RVA: 0x7ADD2A330
        public void get_SafeWaitHandle(){} // RVA: 0x7ADD2A4F0
        public void SetHandleInternal(){} // RVA: 0x7ADD2A640
        public void WaitOne(){} // RVA: 0x7ADD2A890
        public void InternalWaitOne(){} // RVA: 0x7ADD2A9F0
        public void WaitAny(){} // RVA: 0x7ADD2AED0
        public void ThrowAbandonedMutexException(){} // RVA: 0x7ADD2B060
        public void Close(){} // RVA: 0x7ADD2B0C0
        public void Dispose(){} // RVA: 0x7ADD2B180
        public void WaitOneNative(){} // RVA: 0x7ADD2B1F0
        public void WaitMultiple(){} // RVA: 0x7ADD2B450
        public void Wait_internal(){} // RVA: 0x7ADD2BA40
        public void .cctor(){} // RVA: 0x7ADD2BA50
    }

    public class WaitHandleCannotBeOpenedException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADB60DD0
    }

    public class WaitOrTimerCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB4C8720
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class Win32ThreadPoolNativeOverlapped : ValueType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A8DD7270
        public void get_Data(){} // RVA: 0x7A7E43440
        public void Allocate(){} // RVA: 0x7ADD186E0
        public void AllocateNew(){} // RVA: 0x7ADD187D0
        public void SetData(){} // RVA: 0x7A7E43450
        public void Free(){} // RVA: 0x7ADD190A0
        public void ToNativeOverlapped(){} // RVA: 0x7A97F8BA0
        public void FromNativeOverlapped(){} // RVA: 0x7A97F8BA0
        public void CompleteWithCallback(){} // RVA: 0x7ADD19170
        public void OnExecutionContextCallback(){} // RVA: 0x7ADD194B0
    }

    public class _ThreadPoolWaitCallback : Object
    {
        // ── Methods ──
        public void PerformWaitCallback(){} // RVA: 0x7ADD28BD0
    }

}