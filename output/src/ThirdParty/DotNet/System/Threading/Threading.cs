// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading
// Classes: 93
// Methods: 711

namespace ThirdParty.DotNet.System.Threading
{
    public class AbandonedMutexException : SystemException
    {
        public object _mutexIndex;
        public object _mutex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6999C30
        public void SetupException(){} // RVA: 0x6999CC0
    }

    public class AsyncFlowControl : ValueType
    {
        public object useEC;
        public object _ec;
        public object _thread;

        // ── Methods ──
        public void Setup(){} // RVA: 0x8C1B10
        public void Dispose(){} // RVA: 0x8C1B20
        public void Undo(){} // RVA: 0x8C1B30
        public void GetHashCode(){} // RVA: 0x8C1B40
        public void Equals(){} // RVA: 0x8C1CB0
    }

    public class AsyncLocalValueChangedArgs`1 : ValueType
    {
        public object _previousValue;
        public object _currentValue;
        public object _threadContextChanged;

        // ── Methods ──
        public void get_CurrentValue(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xA94080
    }

    public class AsyncLocalValueChangedArgs`1 : ValueType
    {
        public object _previousValue;
        public object _currentValue;
        public object _threadContextChanged;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6FA210
    }

    public class AsyncLocal`1 : Object
    {
        public object m_valueChangedHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void get_Value(){} // RVA: 0xA94080
        public void set_Value(){} // RVA: 0xA94080
        public void System.Threading.IAsyncLocal.OnValueChanged(){} // RVA: 0x89AA50
    }

    public class AsyncLocal`1 : Object
    {
        public object m_valueChangedHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Value(){} // RVA: 0x5771450
        public void set_Value(){} // RVA: 0x5771500
        public void System.Threading.IAsyncLocal.OnValueChanged(){} // RVA: 0x5771580
    }

    public class AutoResetEvent : EventWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6999D80
    }

    public class CancellationCallbackCoreWorkArguments : ValueType
    {
        public object _currArrayFragment;
        public object _currArrayIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x28E70
    }

    public class CancellationCallbackInfo : Object
    {
        public object Callback;
        public object StateForCallback;
        public object TargetExecutionContext;
        public object CancellationTokenSource;
        public object s_executionContextCallback;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB8AE10
        public void ExecuteCallback(){} // RVA: 0x699FCB0
        public void ExecutionContextCallback(){} // RVA: 0x699FE70
    }

    public class CancellationCallbackInfo[] : Array
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

    public class CancellationToken : ValueType
    {
        public object _source;
        public object s_actionToActionObjShunt;

        // ── Methods ──
        public void get_None(){} // RVA: 0xDAC980
        public void get_IsCancellationRequested(){} // RVA: 0x8C0D60
        public void get_CanBeCanceled(){} // RVA: 0x54A60
        public void .ctor(){} // RVA: 0x8C0D80
        public void Register(){} // RVA: 0x8C10A0
        public void InternalRegisterWithoutEC(){} // RVA: 0x8C1060
        public void Equals(){} // RVA: 0x8C1100
        public void GetHashCode(){} // RVA: 0x8C1110
        public void op_Equality(){} // RVA: 0x699A960
        public void op_Inequality(){} // RVA: 0x699A9C0
        public void ThrowIfCancellationRequested(){} // RVA: 0x8C1120
        public void ThrowOperationCanceledException(){} // RVA: 0x8C1130
        public void .cctor(){} // RVA: 0x699AB00
    }

    public class CancellationTokenRegistration : ValueType
    {
        public object m_callbackInfo;
        public object m_registrationInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8C1290
        public void get_Token(){} // RVA: 0x8C12B0
        public void Unregister(){} // RVA: 0x8C12E0
        public void Dispose(){} // RVA: 0x8C12F0
        public void Equals(){} // RVA: 0x8C1310
        public void GetHashCode(){} // RVA: 0x8C13B0
        public void DisposeAsync(){} // RVA: 0x8C13C0
    }

    public class CancellationTokenRegistration[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAC2C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E57650
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CancellationTokenSource : Object
    {
        public object s_canceledSource;
        public object s_neverCanceledSource;
        public object s_nLists;
        public object _kernelEvent;
        public object _registeredCallbacksLists;
        public object _state;
        public object _threadIDExecutingCallbacks;
        public object _disposed;
        public object _executingCallback;
        public object _timer;
        public object s_timerCallback;

        // ── Methods ──
        public void get_IsCancellationRequested(){} // RVA: 0x699D330
        public void get_IsCancellationCompleted(){} // RVA: 0x699D340
        public void get_IsDisposed(){} // RVA: 0xF73960
        public void get_ThreadIDExecutingCallbacks(){} // RVA: 0x699D350
        public void set_ThreadIDExecutingCallbacks(){} // RVA: 0x699D360
        public void get_Token(){} // RVA: 0x699D370
        public void get_ExecutingCallback(){} // RVA: 0x6857CA0
        public void .ctor(){} // RVA: 0x699D540
        public void InitializeWithTimer(){} // RVA: 0x699D5C0
        public void Cancel(){} // RVA: 0x699D740
        public void CancelAfter(){} // RVA: 0x699D8A0
        public void TimerCallbackLogic(){} // RVA: 0x699DAD0
        public void Dispose(){} // RVA: 0x699DC40
        public void ThrowIfDisposed(){} // RVA: 0x699DD90
        public void ThrowObjectDisposedException(){} // RVA: 0x699DDE0
        public void InternalRegister(){} // RVA: 0x699DE40
        public void NotifyCancellation(){} // RVA: 0x699E410
        public void ExecuteCallbackHandlers(){} // RVA: 0x699E4D0
        public void CancellationCallbackCoreWork_OnSyncContext(){} // RVA: 0x699E980
        public void CancellationCallbackCoreWork(){} // RVA: 0x699EA00
        public void CreateLinkedTokenSource(){} // RVA: 0x699EE30
        public void WaitForCallbackToComplete(){} // RVA: 0x699EFD0
        public void .cctor(){} // RVA: 0x699F0A0
    }

    public class CancellationToken[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAC0A0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3CA0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E57510
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ContextCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class ContextCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0x894320
    }

    public class DeferredDisposableLifetime`1 : ValueType
    {
        public object _count;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void AddRef(){} // RVA: 0xA94080
        public void Release(){} // RVA: 0xA94080
        public void Dispose(){} // RVA: 0xA94080
    }

    public class DeferredDisposableLifetime`1 : ValueType
    {
        public object _count;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x18F3EB0
        public void AddRef(){} // RVA: 0x22E690
        public void Release(){} // RVA: 0x22E6A0
        public void Dispose(){} // RVA: 0x22E730
    }

    public class EventWaitHandle : WaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x69A68D0
        public void Reset(){} // RVA: 0x69A6C50
        public void Set(){} // RVA: 0x69A6CB0
    }

    public class ExecutionContext : Object
    {
        public object _syncContext;
        public object _syncContextNoFlow;
        public object _logicalCallContext;
        public object _illogicalCallContext;
        public object _flags;
        public object _localValues;
        public object _localChangeNotifications;
        public object s_dummyDefaultEC;
        public object Default;

        // ── Methods ──
        public void get_isNewCapture(){} // RVA: 0x69A7370
        public void set_isNewCapture(){} // RVA: 0x69A7380
        public void get_isFlowSuppressed(){} // RVA: 0x69A73A0
        public void set_isFlowSuppressed(){} // RVA: 0x69A73B0
        public void get_IsPreAllocatedDefault(){} // RVA: 0x69A73D0
        public void .ctor(){} // RVA: 0x69A9540
        public void GetLocalValue(){} // RVA: 0x69A73F0
        public void SetLocalValue(){} // RVA: 0x69A74D0
        public void OnAsyncLocalContextChanged(){} // RVA: 0x69A7870
        public void get_LogicalCallContext(){} // RVA: 0x69A7CC0
        public void set_LogicalCallContext(){} // RVA: 0xB70100
        public void get_IllogicalCallContext(){} // RVA: 0x69A7D60
        public void set_IllogicalCallContext(){} // RVA: 0xB44DC0
        public void get_SynchronizationContext(){} // RVA: 0xB5DBF0
        public void set_SynchronizationContext(){} // RVA: 0xB44D60
        public void get_SynchronizationContextNoFlow(){} // RVA: 0xB465B0
        public void set_SynchronizationContextNoFlow(){} // RVA: 0xBA9BA0
        public void Dispose(){} // RVA: 0x18F3EB0
        public void Run(){} // RVA: 0x69A7F40
        public void RunInternal(){} // RVA: 0x89EDE0
        public void EstablishCopyOnWriteScope(){} // RVA: 0x69A82E0
        public void SetExecutionContext(){} // RVA: 0x69A8420
        public void CreateCopy(){} // RVA: 0x69A8740
        public void CreateMutableCopy(){} // RVA: 0x69A8990
        public void SuppressFlow(){} // RVA: 0x69A8C80
        public void RestoreFlow(){} // RVA: 0x69A8D60
        public void IsFlowSuppressed(){} // RVA: 0x69A8E00
        public void Capture(){} // RVA: 0x69A8F30
        public void FastCapture(){} // RVA: 0x69A8EE0
        public void GetObjectData(){} // RVA: 0x69A9370
        public void IsDefaultFTContext(){} // RVA: 0x69A9770
        public void .cctor(){} // RVA: 0x69A97E0
    }

    public class ExecutionContextSwitcher : ValueType
    {
        public object outerEC;
        public object outerECBelongsToScope;
        public object hecsw;
        public object thread;

        // ── Methods ──
        public void UndoNoThrow(){} // RVA: 0x8C1A30
        public void Undo(){} // RVA: 0x8C1A40
    }

    public class IAsyncLocal
    {
        // ── Methods ──
        public void OnValueChanged(){} // RVA: 0x89AA50
    }

    public class IAsyncLocal[] : Array
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

    public class IDeferredDisposable
    {
        // ── Methods ──
        public void OnFinalRelease(){} // RVA: 0x894750
    }

    public class IOCompletionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x40E1BA0
        public void Invoke(){} // RVA: 0xCA8D60
    }

    public class IThreadPoolWorkItem
    {
        // ── Methods ──
        public void ExecuteWorkItem(){} // RVA: 0x894290
        public void MarkAborted(){} // RVA: 0x894320
    }

    public class IThreadPoolWorkItem[] : Array
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

    public class Interlocked : Object
    {
        // ── Methods ──
        public void CompareExchange(){} // RVA: 0xA94080
        public void Decrement(){} // RVA: 0x69B4A80
        public void Increment(){} // RVA: 0x69B4AA0
        public void Exchange(){} // RVA: 0xA94080
        public void Read(){} // RVA: 0x69B4BF0
        public void Add(){} // RVA: 0x69B4C10
        public void MemoryBarrier(){} // RVA: 0x69ADD10
    }

    public class InternalThread : CriticalFinalizerObject
    {
        public object lock_thread_id;
        public object handle;
        public object native_handle;
        public object name_chars;
        public object name_free;
        public object name_length;
        public object state;
        public object abort_exc;
        public object abort_state_handle;
        public object thread_id;
        public object debugger_thread;
        public object static_data;
        public object runtime_thread_info;
        public object current_appcontext;
        public object root_domain_thread;
        public object _serialized_principal;
        public object _serialized_principal_version;
        public object appdomain_refs;
        public object interruption_requested;
        public object longlived;
        public object threadpool_thread;
        public object thread_interrupt_requested;
        public object stack_size;
        public object apartment_state;
        public object critical_region_level;
        public object managed_id;
        public object small_id;
        public object manage_callback;
        public object flags;
        public object thread_pinning_ref;
        public object abort_protected_block_count;
        public object priority;
        public object owned_mutex;
        public object suspended_event;
        public object self_suspended;
        public object thread_state;
        public object netcore0;
        public object netcore1;
        public object netcore2;
        public object last;

        // ── Methods ──
        public void Thread_free_internal(){} // RVA: 0x69B7600
        public void Finalize(){} // RVA: 0x69B7680
        public void .ctor(){} // RVA: 0x69B7740
    }

    public class LazyInitializer : Object
    {
        // ── Methods ──
        public void EnsureInitialized(){} // RVA: 0x3137BB0
        public void EnsureInitializedCore(){} // RVA: 0x3137F50
        public void EnsureLockInitialized(){} // RVA: 0x6999DA0
    }

    public class Lock : Object
    {
        public object _lock;

        // ── Methods ──
        public void Acquire(){} // RVA: 0x69A29A0
        public void Release(){} // RVA: 0x69A29E0
        public void .ctor(){} // RVA: 0x69A2A10
    }

    public class LockHolder : ValueType
    {
        public object _lock;

        // ── Methods ──
        public void Hold(){} // RVA: 0x699FF80
        public void Dispose(){} // RVA: 0x8C1570
    }

    public class LockQueue : Object
    {
        public object rwlock;
        public object lockCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Wait(){} // RVA: 0x69B4C20
        public void get_IsEmpty(){} // RVA: 0x69B4E30
        public void Pulse(){} // RVA: 0x69B4F40
    }

    public class LockRecursionException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6999F10
    }

    public class ManualResetEvent : EventWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6999F90
    }

    public class ManualResetEventSlim : Object
    {
        public object m_lock;
        public object m_eventObj;
        public object m_combinedState;
        public object s_cancellationTokenCallback;

        // ── Methods ──
        public void get_WaitHandle(){} // RVA: 0x699AD30
        public void get_IsSet(){} // RVA: 0x699AD70
        public void set_IsSet(){} // RVA: 0x699ADD0
        public void get_SpinCount(){} // RVA: 0x699AE00
        public void set_SpinCount(){} // RVA: 0x699AE60
        public void get_Waiters(){} // RVA: 0x699AE80
        public void set_Waiters(){} // RVA: 0x699AEE0
        public void .ctor(){} // RVA: 0x699B0A0
        public void Initialize(){} // RVA: 0x699B1A0
        public void EnsureLockObjectCreated(){} // RVA: 0x699B260
        public void LazyInitializeEvent(){} // RVA: 0x699B310
        public void Set(){} // RVA: 0x699B5E0
        public void Wait(){} // RVA: 0x699BA00
        public void Dispose(){} // RVA: 0x699C340
        public void ThrowIfDisposed(){} // RVA: 0x699C4B0
        public void CancellationTokenCallback(){} // RVA: 0x699C520
        public void UpdateStateAtomically(){} // RVA: 0x699C6A0
        public void ExtractStatePortionAndShiftRight(){} // RVA: 0x699C780
        public void ExtractStatePortion(){} // RVA: 0x699C790
        public void .cctor(){} // RVA: 0x699C7A0
    }

    public class Monitor : Object
    {
        // ── Methods ──
        public void Enter(){} // RVA: 0x69A9AE0
        public void ThrowLockTakenException(){} // RVA: 0x69A9B60
        public void Exit(){} // RVA: 0x69A9BD0
        public void TryEnter(){} // RVA: 0x69AA050
        public void MillisecondsTimeoutFromTimeSpan(){} // RVA: 0x69A9DA0
        public void IsEntered(){} // RVA: 0x69AA110
        public void Wait(){} // RVA: 0x69AA190
        public void Pulse(){} // RVA: 0x69AA2B0
        public void PulseAll(){} // RVA: 0x69AA380
        public void Monitor_test_synchronised(){} // RVA: 0x69AA490
        public void Monitor_pulse(){} // RVA: 0x69AA4E0
        public void ObjPulse(){} // RVA: 0x69AA510
        public void Monitor_pulse_all(){} // RVA: 0x69AA5B0
        public void ObjPulseAll(){} // RVA: 0x69AA620
        public void Monitor_wait(){} // RVA: 0x69AA700
        public void ObjWait(){} // RVA: 0x69AA730
        public void try_enter_with_atomic_var(){} // RVA: 0x69AA820
        public void ReliableEnterTimeout(){} // RVA: 0x69AA860
        public void ReliableEnter(){} // RVA: 0x69AA940
        public void Monitor_test_owner(){} // RVA: 0x69AA9D0
        public void IsEnteredNative(){} // RVA: 0x69AA9D0
    }

    public class Mutex : WaitHandle
    {
        // ── Methods ──
        public void ReleaseMutex_internal(){} // RVA: 0x69B5100
        public void .ctor(){} // RVA: 0x69B5120
        public void ReleaseMutex(){} // RVA: 0x69B5180
    }

    public class NativeEventCalls : Object
    {
        // ── Methods ──
        public void CreateEvent_internal(){} // RVA: 0x69B51B0
        public void CreateEvent_icall(){} // RVA: 0x69B5240
        public void SetEvent(){} // RVA: 0x69B52D0
        public void SetEvent_internal(){} // RVA: 0x69B53B0
        public void ResetEvent(){} // RVA: 0x69B53D0
        public void ResetEvent_internal(){} // RVA: 0x69B54D0
        public void CloseEvent_internal(){} // RVA: 0x69B5520
    }

    public class OSSpecificSynchronizationContext : SynchronizationContext
    {
        public object m_OSSynchronizationContext;
        public object s_ContextCache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA9BA0
        public void Get(){} // RVA: 0x69AB3F0
        public void CreateCopy(){} // RVA: 0x69AB630
        public void Send(){} // RVA: 0x69AB6D0
        public void Post(){} // RVA: 0x69AB710
        public void InvocationEntry(){} // RVA: 0x69ABAA0
        public void GetOSContext(){} // RVA: 0x69ABC50
        public void PostInternal(){} // RVA: 0x69ABCE0
        public void .cctor(){} // RVA: 0x69ABE00
    }

    public class ParameterizedThreadStart : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class PlatformHelper : Object
    {
        public object s_processorCount;
        public object s_lastProcessorCountRefreshTicks;
        public object IsSingleProcessor;

        // ── Methods ──
        public void get_ProcessorCount(){} // RVA: 0x699CC40
        public void .cctor(){} // RVA: 0x699CD40
    }

    public class PreAllocatedOverlapped : Object
    {
        public object _overlapped;
        public object _lifetime;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x18F3EB0
        public void Release(){} // RVA: 0x69A2750
        public void Dispose(){} // RVA: 0x69A2820
        public void System.Threading.IDeferredDisposable.OnFinalRelease(){} // RVA: 0x69A2910
    }

    public class QueueUserWorkItemCallback : Object
    {
        public object callback;
        public object context;
        public object state;
        public object ccb;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69B1AF0
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x69B1C90
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0xB43310
        public void WaitCallback_Context(){} // RVA: 0x69B1DD0
        public void .cctor(){} // RVA: 0x69B1E50
    }

    public class ReaderWriterCount : Object
    {
        public object lockID;
        public object readercount;
        public object writercount;
        public object upgradecount;
        public object next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ReaderWriterLock : CriticalFinalizerObject
    {
        public object seq_num;
        public object state;
        public object readers;
        public object writer_lock_owner;
        public object writer_queue;
        public object reader_locks;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69B5540
        public void Finalize(){} // RVA: 0x69AE020
        public void get_IsReaderLockHeld(){} // RVA: 0x69B5700
        public void get_IsWriterLockHeld(){} // RVA: 0x69B5880
        public void AcquireReaderLock(){} // RVA: 0x69B59D0
        public void AcquireWriterLock(){} // RVA: 0x69B5EA0
        public void ReleaseReaderLock(){} // RVA: 0x69B64C0
        public void ReleaseWriterLock(){} // RVA: 0x69B67C0
        public void HasWriterLock(){} // RVA: 0x69B6820
    }

    public class ReaderWriterLockSlim : Object
    {
        public object fIsReentrant;
        public object myLock;
        public object LockSpinCycles;
        public object LockSpinCount;
        public object LockSleep0Count;
        public object numWriteWaiters;
        public object numReadWaiters;
        public object numWriteUpgradeWaiters;
        public object numUpgradeWaiters;
        public object fNoWaiters;
        public object upgradeLockOwnerId;
        public object writeLockOwnerId;
        public object writeEvent;
        public object readEvent;
        public object upgradeEvent;
        public object waitUpgradeEvent;
        public object s_nextLockID;
        public object lockID;
        public object t_rwc;
        public object fUpgradeThreadHoldingRead;
        public object MaxSpinCount;
        public object owners;
        public object WRITER_HELD;
        public object WAITING_WRITERS;
        public object WAITING_UPGRADER;
        public object MAX_READER;
        public object READER_MASK;
        public object fDisposed;

        // ── Methods ──
        public void InitializeThreadCounts(){} // RVA: 0x70E8280
        public void .ctor(){} // RVA: 0x70E82F0
        public void IsRWEntryEmpty(){} // RVA: 0x70E8360
        public void IsRwHashEntryChanged(){} // RVA: 0x70E83A0
        public void GetThreadRWCount(){} // RVA: 0x70E83C0
        public void EnterReadLock(){} // RVA: 0x70E8530
        public void TryEnterReadLock(){} // RVA: 0x70E85E0
        public void TryEnterReadLockCore(){} // RVA: 0x70E85F0
        public void EnterWriteLock(){} // RVA: 0x70E8960
        public void TryEnterWriteLock(){} // RVA: 0x70E8A10
        public void TryEnterWriteLockCore(){} // RVA: 0x70E8A20
        public void EnterUpgradeableReadLock(){} // RVA: 0x70E8F00
        public void TryEnterUpgradeableReadLock(){} // RVA: 0x70E8FB0
        public void TryEnterUpgradeableReadLockCore(){} // RVA: 0x70E8FC0
        public void ExitReadLock(){} // RVA: 0x70E9450
        public void ExitWriteLock(){} // RVA: 0x70E9660
        public void ExitUpgradeableReadLock(){} // RVA: 0x70E9890
        public void LazyCreateEvent(){} // RVA: 0x70E9C00
        public void WaitOnEvent(){} // RVA: 0x70E9D40
        public void ExitAndWakeUpAppropriateWaiters(){} // RVA: 0x70E9FE0
        public void ExitAndWakeUpAppropriateWaitersPreferringWriters(){} // RVA: 0x70EA070
        public void ExitAndWakeUpAppropriateReadWaiters(){} // RVA: 0x70EA0F0
        public void IsWriterAcquired(){} // RVA: 0x70EA180
        public void SetWriterAcquired(){} // RVA: 0x70EA190
        public void ClearWriterAcquired(){} // RVA: 0x70EA1A0
        public void SetWritersWaiting(){} // RVA: 0x70EA1B0
        public void ClearWritersWaiting(){} // RVA: 0x70EA1C0
        public void SetUpgraderWaiting(){} // RVA: 0x70EA1D0
        public void ClearUpgraderWaiting(){} // RVA: 0x70EA1E0
        public void GetNumReaders(){} // RVA: 0x70EA1F0
        public void EnterMyLock(){} // RVA: 0x70EA200
        public void EnterMyLockSpin(){} // RVA: 0x70EA220
        public void ExitMyLock(){} // RVA: 0x70EA3A0
        public void SpinWait(){} // RVA: 0x70EA3B0
        public void Dispose(){} // RVA: 0x70EA440
        public void get_IsReadLockHeld(){} // RVA: 0x70EA8B0
        public void get_IsUpgradeableReadLockHeld(){} // RVA: 0x70EA970
        public void get_IsWriteLockHeld(){} // RVA: 0x70EAAB0
        public void get_RecursiveReadCount(){} // RVA: 0x70EABF0
        public void get_RecursiveUpgradeCount(){} // RVA: 0x70EACB0
        public void get_RecursiveWriteCount(){} // RVA: 0x70EADF0
        public void get_WaitingReadCount(){} // RVA: 0x2244FB0
        public void get_WaitingUpgradeCount(){} // RVA: 0x15AF000
        public void get_WaitingWriteCount(){} // RVA: 0xE62D00
    }

    public class RegisteredWaitHandle : MarshalByRefObject
    {
        public object _waitObject;
        public object _callback;
        public object _state;
        public object _finalEvent;
        public object _cancelEvent;
        public object _timeout;
        public object _callsInProcess;
        public object _executeOnlyOnce;
        public object _unregistered;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69B6870
        public void Wait(){} // RVA: 0x69B6AA0
        public void DoCallBack(){} // RVA: 0x69B7200
        public void Unregister(){} // RVA: 0x69B7440
    }

    public class SemaphoreFullException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class SemaphoreSlim : Object
    {
        public object m_currentCount;
        public object m_maxCount;
        public object m_waitCount;
        public object m_lockObj;
        public object m_waitHandle;
        public object m_asyncHead;
        public object m_asyncTail;
        public object s_trueTask;
        public object s_falseTask;
        public object s_cancellationTokenCanceledEventHandler;

        // ── Methods ──
        public void get_CurrentCount(){} // RVA: 0x69A2AA0
        public void .ctor(){} // RVA: 0x69A2AC0
        public void Wait(){} // RVA: 0x69A2C90
        public void WaitUntilCountOrTimeout(){} // RVA: 0x69A3550
        public void WaitAsync(){} // RVA: 0x69A3690
        public void CreateAndAddAsyncWaiter(){} // RVA: 0x69A3AB0
        public void RemoveAsyncWaiter(){} // RVA: 0x69A3D20
        public void WaitUntilCountOrTimeoutAsync(){} // RVA: 0x69A3F90
        public void Release(){} // RVA: 0x69A4210
        public void QueueWaiterTask(){} // RVA: 0x69A4550
        public void Dispose(){} // RVA: 0x69A45D0
        public void CancellationTokenCanceledEventHandler(){} // RVA: 0x69A4780
        public void CheckDispose(){} // RVA: 0x69A48F0
        public void GetResourceString(){} // RVA: 0x2303260
        public void .cctor(){} // RVA: 0x69A4980
    }

    public class SendOrPostCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class SparselyPopulatedArrayAddInfo`1 : ValueType
    {
        public object _source;
        public object _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x899290
        public void get_Source(){} // RVA: 0x87C0A0
        public void get_Index(){} // RVA: 0x87C130
    }

    public class SparselyPopulatedArrayAddInfo`1 : ValueType
    {
        public object _source;
        public object _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x28E70
        public void get_Source(){} // RVA: 0x77900
        public void get_Index(){} // RVA: 0x14790
    }

    public class SparselyPopulatedArrayFragment`1 : Object
    {
        public object _elements;
        public object _freeCount;
        public object _next;
        public object _prev;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x895750
        public void get_Item(){} // RVA: 0xA94080
        public void get_Length(){} // RVA: 0x87C130
        public void get_Prev(){} // RVA: 0x87C0A0
        public void SafeAtomicRemove(){} // RVA: 0xA94080
    }

    public class SparselyPopulatedArrayFragment`1 : Object
    {
        public object _elements;
        public object _freeCount;
        public object _next;
        public object _prev;

        // ── Methods ──
        public void SafeAtomicRemove(){} // RVA: 0x4B432D0
        public void get_Item(){} // RVA: 0x4B43280
        public void get_Prev(){} // RVA: 0x4B432C0
        public void .ctor(){} // RVA: 0x4B43170
        public void get_Length(){} // RVA: 0x17F0080
    }

    public class SparselyPopulatedArray`1 : Object
    {
        public object _head;
        public object _tail;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8944F0
        public void get_Tail(){} // RVA: 0x87C0A0
        public void Add(){} // RVA: 0xA94080
    }

    public class SparselyPopulatedArray`1 : Object
    {
        public object _head;
        public object _tail;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B43380
        public void get_Tail(){} // RVA: 0x4B434B0
        public void Add(){} // RVA: 0x4B434C0
    }

    public class SparselyPopulatedArray`1[] : Array
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

    public class SpinLock : ValueType
    {
        public object m_owner;
        public object MAXIMUM_WAITERS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8C1740
        public void Enter(){} // RVA: 0x8C1770
        public void TryEnter(){} // RVA: 0x8C1780
        public void ContinueTryEnter(){} // RVA: 0x8C1790
        public void DecrementWaiters(){} // RVA: 0x8C17A0
        public void ContinueTryEnterWithThreadTracking(){} // RVA: 0x8C17B0
        public void Exit(){} // RVA: 0x8C17D0
        public void ExitSlowPath(){} // RVA: 0x8C17E0
        public void get_IsHeldByCurrentThread(){} // RVA: 0x8C17F0
        public void get_IsThreadOwnerTrackingEnabled(){} // RVA: 0x8C1800
        public void .cctor(){} // RVA: 0x69A65C0
    }

    public class SpinLock[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E80ED0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC5B20
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E368F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SpinWait : ValueType
    {
        public object SpinCountforSpinBeforeWait;
        public object _count;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x77E60
        public void get_NextSpinWillYield(){} // RVA: 0x8C1140
        public void SpinOnce(){} // RVA: 0x8C11B0
        public void SpinOnceCore(){} // RVA: 0x8C11C0
        public void Reset(){} // RVA: 0x96220
        public void .cctor(){} // RVA: 0x699CBB0
    }

    public class SynchronizationContext : Object
    {
        public object _props;
        public object s_cachedPreparedType1;
        public object s_cachedPreparedType2;
        public object s_cachedPreparedType3;
        public object s_cachedPreparedType4;
        public object s_cachedPreparedType5;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void SetWaitNotificationRequired(){} // RVA: 0x69AAA30
        public void IsWaitNotificationRequired(){} // RVA: 0x69AADC0
        public void Send(){} // RVA: 0x3DC7FC0
        public void Post(){} // RVA: 0x69AADD0
        public void OperationStarted(){} // RVA: 0xB43310
        public void OperationCompleted(){} // RVA: 0xB43310
        public void Wait(){} // RVA: 0x69AAE60
        public void WaitHelper(){} // RVA: 0x69AAF50
        public void SetSynchronizationContext(){} // RVA: 0x69AAFF0
        public void get_Current(){} // RVA: 0x69AB0E0
        public void get_CurrentNoFlow(){} // RVA: 0x69AB1A0
        public void GetThreadLocalContext(){} // RVA: 0x69AB260
        public void CreateCopy(){} // RVA: 0x69AB2B0
        public void get_CurrentExplicit(){} // RVA: 0x69AB2F0
    }

    public class SynchronizationLockException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class Thread : CriticalFinalizerObject
    {
        public object s_LocalDataStoreMgr;
        public object s_LocalDataStore;
        public object m_CurrentCulture;
        public object m_CurrentUICulture;
        public object s_asyncLocalCurrentCulture;
        public object s_asyncLocalCurrentUICulture;
        public object internal_thread;
        public object m_ThreadStartArg;
        public object pending_exception;
        public object current_thread;
        public object m_Delegate;
        public object m_ExecutionContext;
        public object m_ExecutionContextBelongsToOuterScope;
        public object principal;
        public object principal_version;

        // ── Methods ──
        public void AsyncLocalSetCurrentUICulture(){} // RVA: 0x69AC4A0
        public void .ctor(){} // RVA: 0x69AC6B0
        public void Start(){} // RVA: 0x69AC8D0
        public void GetExecutionContextReader(){} // RVA: 0x69ACAD0
        public void get_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x69ACB30
        public void set_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x69ACB40
        public void GetMutableExecutionContext(){} // RVA: 0x69ACB50
        public void SetExecutionContext(){} // RVA: 0x69ACC80
        public void get_Priority(){} // RVA: 0x69ACCE0
        public void set_Priority(){} // RVA: 0x69ACD70
        public void GetPriorityNative(){} // RVA: 0x69ACCE0
        public void SetPriorityNative(){} // RVA: 0x69ACD70
        public void JoinInternal(){} // RVA: 0x69ACE10
        public void Join(){} // RVA: 0x69ACEE0
        public void SleepInternal(){} // RVA: 0x69ACFA0
        public void Sleep(){} // RVA: 0x69AD040
        public void YieldInternal(){} // RVA: 0x669C280
        public void Yield(){} // RVA: 0x669C280
        public void SetStartHelper(){} // RVA: 0x69AD150
        public void get_CurrentUICulture(){} // RVA: 0x69AD330
        public void set_CurrentUICulture(){} // RVA: 0x69AD370
        public void GetCurrentUICultureNoAppX(){} // RVA: 0x69AD750
        public void get_CurrentCulture(){} // RVA: 0x69AD900
        public void GetCurrentCultureNoAppX(){} // RVA: 0x69AD940
        public void nativeInitCultureAccessors(){} // RVA: 0x69ADAB0
        public void MemoryBarrier(){} // RVA: 0x69ADD10
        public void ConstructInternalThread(){} // RVA: 0x69ADD20
        public void get_Internal(){} // RVA: 0x69ADD60
        public void get_CurrentContext(){} // RVA: 0x675FA50
        public void GetCurrentThread_icall(){} // RVA: 0x69ADDC0
        public void GetCurrentThread(){} // RVA: 0x69ADE40
        public void get_CurrentThread(){} // RVA: 0x69ADEE0
        public void get_CurrentThreadId(){} // RVA: 0x69ADFE0
        public void GetDomainID(){} // RVA: 0x6973D30
        public void Thread_internal(){} // RVA: 0x69AE010
        public void Finalize(){} // RVA: 0x69AE020
        public void get_IsThreadPoolThread(){} // RVA: 0x69AE060
        public void get_IsThreadPoolThreadInternal(){} // RVA: 0x69AE060
        public void get_IsAlive(){} // RVA: 0x69AE0C0
        public void set_IsBackground(){} // RVA: 0x69AE120
        public void GetName_internal(){} // RVA: 0x69AE2A0
        public void SetName_icall(){} // RVA: 0x69AE370
        public void SetName_internal(){} // RVA: 0x69AE380
        public void get_Name(){} // RVA: 0x69AE3B0
        public void set_Name(){} // RVA: 0x69AE4C0
        public void get_ThreadState(){} // RVA: 0x69AE530
        public void Abort_internal(){} // RVA: 0x69AE580
        public void Abort(){} // RVA: 0x69AE590
        public void SpinWait_nop(){} // RVA: 0xB43310
        public void SpinWait(){} // RVA: 0x69AE5E0
        public void StartInternal(){} // RVA: 0x69AE5F0
        public void SetState(){} // RVA: 0x69AE6A0
        public void ClrState(){} // RVA: 0x69AE6B0
        public void GetState(){} // RVA: 0x69AE6C0
        public void VolatileRead(){} // RVA: 0x2B852E0
        public void SystemMaxStackStize(){} // RVA: 0x66ABE00
        public void GetProcessDefaultStackSize(){} // RVA: 0x69AE740
        public void SetStart(){} // RVA: 0x69AE7C0
        public void get_ManagedThreadId(){} // RVA: 0x69AE880
        public void BeginCriticalRegion(){} // RVA: 0x69AE8E0
        public void EndCriticalRegion(){} // RVA: 0x69AE960
        public void GetHashCode(){} // RVA: 0x69AE880
        public void ValidateThreadState(){} // RVA: 0x69AE9E0
    }

    public class ThreadAbortException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class ThreadHelper : Object
    {
        public object _start;
        public object _startArg;
        public object _executionContext;
        public object _ccb;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void SetExecutionContextHelper(){} // RVA: 0xB70100
        public void ThreadStart_Context(){} // RVA: 0x69AC010
        public void ThreadStart(){} // RVA: 0x69AC2B0
        public void .cctor(){} // RVA: 0x69AC3C0
    }

    public class ThreadInterruptedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class ThreadLocal`1 : Object
    {
        public object m_valueFactory;
        public object ts_slotArray;
        public object ts_finalizationHelper;
        public object m_idComplement;
        public object m_initialized;
        public object s_idManager;
        public object m_linkedSlot;
        public object m_trackAllValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void Initialize(){} // RVA: 0x899250
        public void Finalize(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0x894750
        public void ToString(){} // RVA: 0x87C0A0
        public void get_Value(){} // RVA: 0xA94080
        public void set_Value(){} // RVA: 0xA94080
        public void GetValueSlow(){} // RVA: 0xA94080
        public void SetValueSlow(){} // RVA: 0xA94080
        public void CreateLinkedSlot(){} // RVA: 0xA94080
        public void get_IsValueCreated(){} // RVA: 0x87D280
        public void GrowTable(){} // RVA: 0x899290
        public void GetNewTableSize(){} // RVA: 0x883700
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class ThreadLocal`1 : Object
    {
        public object m_valueFactory;
        public object ts_slotArray;
        public object ts_finalizationHelper;
        public object m_idComplement;
        public object m_initialized;
        public object s_idManager;
        public object m_linkedSlot;
        public object m_trackAllValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4EED600
        public void Initialize(){} // RVA: 0x4EED880
        public void Finalize(){} // RVA: 0x4EEBB60
        public void Dispose(){} // RVA: 0x4EEDA70
        public void ToString(){} // RVA: 0x4EEDE10
        public void get_Value(){} // RVA: 0x4EEDE50
        public void set_Value(){} // RVA: 0x4EEDF70
        public void GetValueSlow(){} // RVA: 0x4EEE0A0
        public void SetValueSlow(){} // RVA: 0x4EEE2F0
        public void CreateLinkedSlot(){} // RVA: 0x4EEE8E0
        public void get_IsValueCreated(){} // RVA: 0x4EECFC0
        public void GrowTable(){} // RVA: 0x4EED0D0
        public void GetNewTableSize(){} // RVA: 0x4EED3E0
        public void .cctor(){} // RVA: 0x4EEEDE0
    }

    public class ThreadLocal`1 : Object
    {
        public object m_valueFactory;
        public object ts_slotArray;
        public object ts_finalizationHelper;
        public object m_idComplement;
        public object m_initialized;
        public object s_idManager;
        public object m_linkedSlot;
        public object m_trackAllValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4EEB870
        public void Initialize(){} // RVA: 0x4EEB9E0
        public void Finalize(){} // RVA: 0x4EEBB60
        public void Dispose(){} // RVA: 0x4EEBC40
        public void ToString(){} // RVA: 0x4EEBFE0
        public void get_Value(){} // RVA: 0x4EEC090
        public void set_Value(){} // RVA: 0x4EEC1B0
        public void GetValueSlow(){} // RVA: 0x4EEC2D0
        public void SetValueSlow(){} // RVA: 0x4EEC520
        public void CreateLinkedSlot(){} // RVA: 0x4EECB10
        public void get_IsValueCreated(){} // RVA: 0x4EECFC0
        public void GrowTable(){} // RVA: 0x4EED0D0
        public void GetNewTableSize(){} // RVA: 0x4EED3E0
        public void .cctor(){} // RVA: 0x4EED420
    }

    public class ThreadPool : Object
    {
        // ── Methods ──
        public void GetMaxThreads(){} // RVA: 0x69B1F30
        public void GetMinThreads(){} // RVA: 0x69B1F80
        public void GetAvailableThreads(){} // RVA: 0x69B1FD0
        public void RegisterWaitForSingleObject(){} // RVA: 0x69B24C0
        public void QueueUserWorkItem(){} // RVA: 0x2A37900
        public void UnsafeQueueUserWorkItem(){} // RVA: 0xA94080
        public void QueueUserWorkItemHelper(){} // RVA: 0x69B28C0
        public void UnsafeQueueCustomWorkItem(){} // RVA: 0x69B2C50
        public void TryPopCustomWorkItem(){} // RVA: 0x69B2D30
        public void RequestWorkerThread(){} // RVA: 0x69B2E70
        public void EnsureVMInitialized(){} // RVA: 0x69B2E90
        public void GetMinThreadsNative(){} // RVA: 0x69B1F80
        public void GetMaxThreadsNative(){} // RVA: 0x69B1F30
        public void GetAvailableThreadsNative(){} // RVA: 0x69B1FD0
        public void NotifyWorkItemComplete(){} // RVA: 0x69B2F40
        public void ReportThreadStatus(){} // RVA: 0x6814ED0
        public void NotifyWorkItemProgress(){} // RVA: 0x66AD5A0
        public void NotifyWorkItemProgressNative(){} // RVA: 0x69B2FD0
        public void NotifyWorkItemQueued(){} // RVA: 0xB43310
        public void InitializeVMTp(){} // RVA: 0x69B3030
        public void get_IsThreadPoolThread(){} // RVA: 0x69B3040
    }

    public class ThreadPoolBoundHandle : Object
    {
        public object _handle;
        public object _threadPoolHandle;
        public object _lifetime;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x18F3EB0
        public void .ctor(){} // RVA: 0x69A01B0
        public void get_Handle(){} // RVA: 0xB5DBF0
        public void BindHandle(){} // RVA: 0x69A0260
        public void AllocateNativeOverlapped(){} // RVA: 0x69A07F0
        public void FreeNativeOverlapped(){} // RVA: 0x69A0A80
        public void GetNativeOverlappedState(){} // RVA: 0x69A0D90
        public void GetOverlappedData(){} // RVA: 0x69A0E70
        public void OnNativeIOCompleted(){} // RVA: 0x69A0FB0
        public void AddRef(){} // RVA: 0x69A11D0
        public void Release(){} // RVA: 0x69A1240
        public void Dispose(){} // RVA: 0x69A1310
        public void Finalize(){} // RVA: 0x69A1400
        public void System.Threading.IDeferredDisposable.OnFinalRelease(){} // RVA: 0x69A1450
    }

    public class ThreadPoolCallbackWrapper : ValueType
    {
        public object _currentThread;

        // ── Methods ──
        public void Enter(){} // RVA: 0x69A0060
        public void Exit(){} // RVA: 0x8C1670
    }

    public class ThreadPoolGlobals : Object
    {
        public object processorCount;
        public object vmTpInitialized;
        public object enableWorkerTracking;
        public object workQueue;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x69AEB60
    }

    public class ThreadPoolWorkQueue : Object
    {
        public object queueHead;
        public object queueTail;
        public object allThreadQueues;
        public object numOutstandingThreadRequests;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69AED30
        public void EnsureCurrentThreadHasQueue(){} // RVA: 0x69AEE40
        public void EnsureThreadRequested(){} // RVA: 0x69AEF90
        public void MarkThreadRequestSatisfied(){} // RVA: 0x69AF030
        public void Enqueue(){} // RVA: 0x69AF060
        public void LocalFindAndPop(){} // RVA: 0x69AF2D0
        public void Dequeue(){} // RVA: 0x69AF380
        public void Dispatch(){} // RVA: 0x69AF640
        public void .cctor(){} // RVA: 0x69AFC10
    }

    public class ThreadPoolWorkQueueThreadLocals : Object
    {
        public object threadLocals;
        public object workQueue;
        public object workStealingQueue;
        public object random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69B15B0
        public void CleanUp(){} // RVA: 0x69B18A0
        public void Finalize(){} // RVA: 0x69B1A20
    }

    public class ThreadStart : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA0FE0
        public void Invoke(){} // RVA: 0xBA10B0
    }

    public class ThreadStateException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class Thread[] : Array
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

    public class Timeout : Object
    {
        public object InfiniteTimeSpan;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x699A0E0
    }

    public class TimeoutHelper : Object
    {
        // ── Methods ──
        public void GetTime(){} // RVA: 0x6975C80
        public void UpdateTimeOut(){} // RVA: 0x699CD90
    }

    public class Timer : MarshalByRefObject
    {
        public object callback;
        public object state;
        public object due_time_ms;
        public object period_ms;
        public object next_run;
        public object disposed;
        public object is_dead;
        public object is_added;

        // ── Methods ──
        public void get_scheduler(){} // RVA: 0x69B7750
        public void .ctor(){} // RVA: 0x69B7900
        public void Init(){} // RVA: 0x69B7930
        public void Change(){} // RVA: 0x69B7BA0
        public void Dispose(){} // RVA: 0x69B7B60
        public void DisposeAsync(){} // RVA: 0x69B7E10
        public void KeepRootedWhileScheduled(){} // RVA: 0xB43310
        public void GetTimeMonotonic(){} // RVA: 0x69B7F50
    }

    public class TimerCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class Timer[] : Array
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

    public class Volatile : Object
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x2B852E0
        public void Write(){} // RVA: 0x2B852F0
    }

    public class WaitCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class WaitHandle : MarshalByRefObject
    {
        public object WaitTimeout;
        public object MAX_WAITHANDLES;
        public object waitHandle;
        public object safeWaitHandle;
        public object hasThreadAffinity;
        public object WAIT_OBJECT_0;
        public object WAIT_ABANDONED;
        public object WAIT_FAILED;
        public object ERROR_TOO_MANY_POSTS;
        public object ERROR_NOT_OWNED_BY_CALLER;
        public object InvalidHandle;
        public object MaxWaitHandles;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69B30B0
        public void Init(){} // RVA: 0x69B30B0
        public void get_Handle(){} // RVA: 0x69B3170
        public void set_Handle(){} // RVA: 0x69B3200
        public void get_SafeWaitHandle(){} // RVA: 0x69B33C0
        public void SetHandleInternal(){} // RVA: 0x69B3510
        public void WaitOne(){} // RVA: 0x69B3760
        public void InternalWaitOne(){} // RVA: 0x69B38C0
        public void WaitAny(){} // RVA: 0x69B3DA0
        public void ThrowAbandonedMutexException(){} // RVA: 0x69B3F30
        public void Close(){} // RVA: 0x69B3F90
        public void Dispose(){} // RVA: 0x69B4050
        public void WaitOneNative(){} // RVA: 0x69B40C0
        public void WaitMultiple(){} // RVA: 0x69B4320
        public void Wait_internal(){} // RVA: 0x69B4910
        public void .cctor(){} // RVA: 0x69B4920
    }

    public class WaitHandleCannotBeOpenedException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67EC2E0
    }

    public class WaitHandle[] : Array
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

    public class WaitOrTimerCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x40E01E0
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Win32ThreadPoolNativeOverlapped : ValueType
    {
        public object t_executionContextCallbackArgs;
        public object s_executionContextCallback;
        public object s_dataArray;
        public object s_dataCount;
        public object s_freeList;
        public object _overlapped;
        public object _nextFree;
        public object _dataIndex;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x18F3EB0
        public void get_Data(){} // RVA: 0x8C1690
        public void Allocate(){} // RVA: 0x69A1510
        public void AllocateNew(){} // RVA: 0x69A1600
        public void SetData(){} // RVA: 0x8C16A0
        public void Free(){} // RVA: 0x69A1EE0
        public void ToNativeOverlapped(){} // RVA: 0x2303260
        public void FromNativeOverlapped(){} // RVA: 0x2303260
        public void CompleteWithCallback(){} // RVA: 0x69A1FB0
        public void OnExecutionContextCallback(){} // RVA: 0x69A22F0
    }

    public class _ThreadPoolWaitCallback : Object
    {
        // ── Methods ──
        public void PerformWaitCallback(){} // RVA: 0x69B1AA0
    }

}