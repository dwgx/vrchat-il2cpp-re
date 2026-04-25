// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading
// Classes: 77
// Methods: 634

namespace ThirdParty.DotNet.System.Threading
{
    public class AbandonedMutexException : SystemException
    {
        public int _mutexIndex; // 0x90
        public System.Threading.Mutex _mutex; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86B9630 | overloaded x3
        public void SetupException(){} // RVA: 0x7FFAC86B96C0
    }

    public class AsyncFlowControl : ValueType
    {
        public bool useEC; // 0x10
        public System.Threading.ExecutionContext _ec; // 0x18
        public System.Threading.Thread _thread; // 0x20

        // ── Methods ──
        public void Setup(){} // RVA: 0x7FFAC86C6A50
        public void Dispose(){} // RVA: 0x7FFAC86C6B50
        public void Undo(){} // RVA: 0x7FFAC86C6B60
        public void GetHashCode(){} // RVA: 0x7FFAC86C6D60
        public void Equals(){} // RVA: 0x7FFAC86C6EC0 | overloaded x2
    }

    public class AsyncLocalValueChangedArgs`1 : ValueType
    {
        public T CurrentValue;
        public T <CurrentValue>k__BackingField;
        public bool <ThreadContextChanged>k__BackingField;

        // ── Methods ──
        public void get_CurrentValue(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    }

    public class AsyncLocal`1 : Object
    {
        public System.Action`1<System.Threading.AsyncLocalValueChangedArgs`1<T>> Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
        public void set_Value(){} // RVA: 0x7FFAC2E8DC40
        public void System.Threading.IAsyncLocal.OnValueChanged(){}
    }

    public class AutoResetEvent : EventWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86B9780
    }

    public class CancellationCallbackCoreWorkArguments : ValueType
    {
        public System.Threading.SparselyPopulatedArrayFragment`1<System.Threading.CancellationCallbackInfo> _currArrayFragment; // 0x10
        public int _currArrayIndex; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC335C3C0
    }

    public class CancellationCallbackInfo : Object
    {
        public System.Action`1<object> Callback; // 0x10
        public object StateForCallback; // 0x18
        public System.Threading.ExecutionContext TargetExecutionContext; // 0x20
        public System.Threading.CancellationTokenSource CancellationTokenSource; // 0x28
        public System.Threading.ContextCallback s_executionContextCallback;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F69A50
        public void ExecuteCallback(){} // RVA: 0x7FFAC86BF780
        public void ExecutionContextCallback(){} // RVA: 0x7FFAC86BF940
    }

    public class CancellationToken : ValueType
    {
        public System.Threading.CancellationTokenSource None; // 0x10
        public System.Action`1<object> IsCancellationRequested;

        // ── Methods ──
        public void get_None(){} // RVA: 0x7FFAC34F9180
        public void get_IsCancellationRequested(){} // RVA: 0x7FFAC86B9B90
        public void get_CanBeCanceled(){} // RVA: 0x7FFAC3BB0800
        public void .ctor(){} // RVA: 0x7FFAC86B9BB0 | overloaded x2
        public void Register(){} // RVA: 0x7FFAC86BA0E0 | overloaded x5
        public void InternalRegisterWithoutEC(){} // RVA: 0x7FFAC86BA030
        public void Equals(){} // RVA: 0x7FFAC86BA240 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC86BA2E0
        public void op_Equality(){} // RVA: 0x7FFAC86BA360
        public void op_Inequality(){} // RVA: 0x7FFAC86BA3C0
        public void ThrowIfCancellationRequested(){} // RVA: 0x7FFAC86BA420
        public void ThrowOperationCanceledException(){} // RVA: 0x7FFAC86BA4A0
        public void .cctor(){} // RVA: 0x7FFAC86BA500
    }

    public class CancellationTokenRegistration : ValueType
    {
        public System.Threading.CancellationCallbackInfo Token; // 0x10
        public System.Threading.SparselyPopulatedArrayAddInfo`1<System.Threading.CancellationCallbackInfo> m_registrationInfo; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60F48A0
        public void get_Token(){} // RVA: 0x7FFAC86BC8E0
        public void Unregister(){} // RVA: 0x7FFAC86BC910
        public void Dispose(){} // RVA: 0x7FFAC86BC9A0
        public void Equals(){} // RVA: 0x7FFAC86BCBE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC86BCC70
        public void DisposeAsync(){} // RVA: 0x7FFAC86BCCF0
    }

    public class CancellationTokenSource : Object
    {
        public System.Threading.CancellationTokenSource IsCancellationRequested;
        public System.Threading.CancellationTokenSource IsCancellationCompleted; // 0x8
        public int IsDisposed; // 0x10
        public System.Threading.ManualResetEvent ThreadIDExecutingCallbacks; // 0x10
        public System.Threading.SparselyPopulatedArray`1<System.Threading.CancellationCallbackInfo>[] Token; // 0x18
        public int ExecutingCallback;
        public int NotCanceledState;
        public int NotifyingState;
        public int NotifyingCompleteState;
        public int _state; // 0x20
        public int _threadIDExecutingCallbacks; // 0x24
        public bool _disposed; // 0x28
        public System.Threading.CancellationCallbackInfo _executingCallback; // 0x30
        public System.Threading.Timer _timer; // 0x38
        public System.Threading.TimerCallback s_timerCallback; // 0x18

        // ── Methods ──
        public void get_IsCancellationRequested(){} // RVA: 0x7FFAC86BCE20
        public void get_IsCancellationCompleted(){} // RVA: 0x7FFAC86BCE30
        public void get_IsDisposed(){} // RVA: 0x7FFAC30F6BA0
        public void get_ThreadIDExecutingCallbacks(){} // RVA: 0x7FFAC86BCE40
        public void set_ThreadIDExecutingCallbacks(){} // RVA: 0x7FFAC86BCE50
        public void get_Token(){} // RVA: 0x7FFAC86BCE60
        public void get_ExecutingCallback(){} // RVA: 0x7FFAC8575260
        public void .ctor(){} // RVA: 0x7FFAC86BD020 | overloaded x3
        public void InitializeWithTimer(){} // RVA: 0x7FFAC86BD0A0
        public void Cancel(){} // RVA: 0x7FFAC86BD220 | overloaded x2
        public void CancelAfter(){} // RVA: 0x7FFAC86BD370 | overloaded x2
        public void TimerCallbackLogic(){} // RVA: 0x7FFAC86BD5A0
        public void Dispose(){} // RVA: 0x7FFAC86BD710 | overloaded x2
        public void ThrowIfDisposed(){} // RVA: 0x7FFAC86BD860
        public void ThrowObjectDisposedException(){} // RVA: 0x7FFAC86BD8B0
        public void InternalRegister(){} // RVA: 0x7FFAC86BD910
        public void NotifyCancellation(){} // RVA: 0x7FFAC86BDEE0
        public void ExecuteCallbackHandlers(){} // RVA: 0x7FFAC86BDFA0
        public void CancellationCallbackCoreWork_OnSyncContext(){} // RVA: 0x7FFAC86BE450
        public void CancellationCallbackCoreWork(){} // RVA: 0x7FFAC86BE4D0
        public void CreateLinkedTokenSource(){} // RVA: 0x7FFAC86BE900 | overloaded x3
        public void WaitForCallbackToComplete(){} // RVA: 0x7FFAC86BEAA0
        public void .cctor(){} // RVA: 0x7FFAC86BEB70
    }

    public class ContextCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class ContextCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2C70A40
    }

    public class DeferredDisposableLifetime`1 : ValueType
    {
        public int _count;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void AddRef(){} // RVA: 0x7FFAC2E8DC40
        public void Release(){} // RVA: 0x7FFAC2E8DC40
        public void Dispose(){} // RVA: 0x7FFAC2E8DC40
    }

    public class EventWaitHandle : WaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86C6460 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAC86C67E0
        public void Set(){} // RVA: 0x7FFAC86C6840
    }

    public class ExecutionContext : Object
    {
        public System.Threading.SynchronizationContext isNewCapture; // 0x10
        public System.Threading.SynchronizationContext isFlowSuppressed; // 0x18
        public System.Runtime.Remoting.Messaging.LogicalCallContext IsPreAllocatedDefault; // 0x20
        public System.Runtime.Remoting.Messaging.IllogicalCallContext LogicalCallContext; // 0x28
        public 0x6B0C69D8 IllogicalCallContext; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Threading.IAsyncLocal,object> SynchronizationContext; // 0x38
        public System.Collections.Generic.List`1<System.Threading.IAsyncLocal> SynchronizationContextNoFlow; // 0x40
        public System.Threading.ExecutionContext s_dummyDefaultEC;
        public System.Threading.ExecutionContext Default; // 0x8

        // ── Methods ──
        public void get_isNewCapture(){} // RVA: 0x7FFAC86C6F00
        public void set_isNewCapture(){} // RVA: 0x7FFAC86C6F10
        public void get_isFlowSuppressed(){} // RVA: 0x7FFAC86C6F30
        public void set_isFlowSuppressed(){} // RVA: 0x7FFAC86C6F40
        public void get_IsPreAllocatedDefault(){} // RVA: 0x7FFAC86C6F60
        public void .ctor(){} // RVA: 0x7FFAC86C90B0 | overloaded x3
        public void GetLocalValue(){} // RVA: 0x7FFAC86C6F80
        public void SetLocalValue(){} // RVA: 0x7FFAC86C7060
        public void OnAsyncLocalContextChanged(){} // RVA: 0x7FFAC86C7400
        public void get_LogicalCallContext(){} // RVA: 0x7FFAC86C7860
        public void set_LogicalCallContext(){} // RVA: 0x7FFAC2F4F0D0
        public void get_IllogicalCallContext(){} // RVA: 0x7FFAC86C7900
        public void set_IllogicalCallContext(){} // RVA: 0x7FFAC2F22E90
        public void get_SynchronizationContext(){} // RVA: 0x7FFAC2F3C380
        public void set_SynchronizationContext(){} // RVA: 0x7FFAC2F22E30
        public void get_SynchronizationContextNoFlow(){} // RVA: 0x7FFAC2F247C0
        public void set_SynchronizationContextNoFlow(){} // RVA: 0x7FFAC2F87E80
        public void Dispose(){} // RVA: 0x7FFAC35D2DD0
        public void Run(){} // RVA: 0x7FFAC86C7AE0 | overloaded x2
        public void RunInternal(){} // RVA: 0x7FFAC2C7B2F0 | overloaded x4
        public void EstablishCopyOnWriteScope(){} // RVA: 0x7FFAC86C7E70 | overloaded x2
        public void SetExecutionContext(){} // RVA: 0x7FFAC86C7FB0
        public void CreateCopy(){} // RVA: 0x7FFAC86C82D0
        public void CreateMutableCopy(){} // RVA: 0x7FFAC86C8520
        public void SuppressFlow(){} // RVA: 0x7FFAC86C8810
        public void RestoreFlow(){} // RVA: 0x7FFAC86C88F0
        public void IsFlowSuppressed(){} // RVA: 0x7FFAC86C8990
        public void Capture(){} // RVA: 0x7FFAC86C8AC0 | overloaded x2
        public void FastCapture(){} // RVA: 0x7FFAC86C8A70
        public void GetObjectData(){} // RVA: 0x7FFAC86C8F00
        public void IsDefaultFTContext(){} // RVA: 0x7FFAC86C9280
        public void .cctor(){} // RVA: 0x7FFAC86C92F0
    }

    public class ExecutionContextSwitcher : ValueType
    {
        public Reader outerEC; // 0x10
        public bool outerECBelongsToScope; // 0x18
        public object hecsw; // 0x20
        public System.Threading.Thread thread; // 0x28

        // ── Methods ──
        public void UndoNoThrow(){} // RVA: 0x7FFAC86C68A0
        public void Undo(){} // RVA: 0x7FFAC86C68C0
    }

    public class IAsyncLocal
    {
        // ── Methods ──
        public void OnValueChanged(){}
    }

    public class IDeferredDisposable
    {
        // ── Methods ──
        public void OnFinalRelease(){} // RVA: 0x7FFAC2C71060
    }

    public class IOCompletionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6058000
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
    }

    public class IThreadPoolWorkItem
    {
        // ── Methods ──
        public void ExecuteWorkItem(){} // RVA: 0x7FFAC2C70980
        public void MarkAborted(){} // RVA: 0x7FFAC2C70A40
    }

    public class Interlocked : Object
    {
        // ── Methods ──
        public void CompareExchange(){} // RVA: 0x7FFAC2E8DC40 | overloaded x9
        public void Decrement(){} // RVA: 0x7FFAC86D44F0
        public void Increment(){} // RVA: 0x7FFAC86D4510 | overloaded x2
        public void Exchange(){} // RVA: 0x7FFAC2E8DC40 | overloaded x8
        public void Read(){} // RVA: 0x7FFAC86D4660
        public void Add(){} // RVA: 0x7FFAC86D4680 | overloaded x2
        public void MemoryBarrier(){} // RVA: 0x7FFAC86CD780
    }

    public class InternalThread : CriticalFinalizerObject
    {
        public int lock_thread_id; // 0x10
        public UIntPtr handle; // 0x18
        public UIntPtr native_handle; // 0x20
        public UIntPtr name_chars; // 0x28
        public int name_free; // 0x30
        public int name_length; // 0x34
        public 0x6B0C5900 state; // 0x38
        public object abort_exc; // 0x40
        public int abort_state_handle; // 0x48
        public long thread_id; // 0x50
        public UIntPtr debugger_thread; // 0x58
        public object static_data; // 0x60
        public UIntPtr runtime_thread_info; // 0x68
        public object current_appcontext; // 0x70
        public object root_domain_thread; // 0x78
        public byte[] _serialized_principal; // 0x80
        public int _serialized_principal_version; // 0x88
        public UIntPtr appdomain_refs; // 0x90
        public int interruption_requested; // 0x98
        public UIntPtr longlived; // 0xA0
        public bool threadpool_thread; // 0xA8
        public bool thread_interrupt_requested; // 0xA9
        public int stack_size; // 0xAC
        public byte apartment_state; // 0xB0
        public int critical_region_level; // 0xB4
        public int managed_id; // 0xB8
        public int small_id; // 0xBC
        public UIntPtr manage_callback; // 0xC0
        public UIntPtr flags; // 0xC8
        public UIntPtr thread_pinning_ref; // 0xD0
        public UIntPtr abort_protected_block_count; // 0xD8
        public int priority; // 0xE0
        public UIntPtr owned_mutex; // 0xE8
        public UIntPtr suspended_event; // 0xF0
        public int self_suspended; // 0xF8
        public UIntPtr thread_state; // 0x100
        public UIntPtr netcore0; // 0x108
        public UIntPtr netcore1; // 0x110
        public UIntPtr netcore2; // 0x118
        public UIntPtr last; // 0x120

        // ── Methods ──
        public void Thread_free_internal(){} // RVA: 0x7FFAC86D7430
        public void Finalize(){} // RVA: 0x7FFAC86D74D0
        public void .ctor(){} // RVA: 0x7FFAC86D75B0
    }

    public class LazyInitializer : Object
    {
        // ── Methods ──
        public void EnsureInitialized(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void EnsureInitializedCore(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void EnsureLockInitialized(){} // RVA: 0x7FFAC86B97A0
    }

    public class Lock : Object
    {
        public object _lock; // 0x10

        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFAC86C2430
        public void Release(){} // RVA: 0x7FFAC86C2470
        public void .ctor(){} // RVA: 0x7FFAC86C24A0
    }

    public class LockHolder : ValueType
    {
        public System.Threading.Lock _lock; // 0x10

        // ── Methods ──
        public void Hold(){} // RVA: 0x7FFAC86BFA60
        public void Dispose(){} // RVA: 0x7FFAC86BFB00
    }

    public class LockQueue : Object
    {
        public System.Threading.ReaderWriterLock IsEmpty; // 0x10
        public int lockCount; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Wait(){} // RVA: 0x7FFAC86D4690
        public void get_IsEmpty(){} // RVA: 0x7FFAC86D48E0
        public void Pulse(){} // RVA: 0x7FFAC86D4A20
    }

    public class LockRecursionException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86B9910 | overloaded x3
    }

    public class ManualResetEvent : EventWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86B9990
    }

    public class ManualResetEventSlim : Object
    {
        public int WaitHandle;
        public object IsSet; // 0x10
        public System.Threading.ManualResetEvent SpinCount; // 0x18
        public int Waiters; // 0x20
        public int SignalledState_BitMask;
        public int SignalledState_ShiftCount;
        public int Dispose_BitMask;
        public int SpinCountState_BitMask;
        public int SpinCountState_ShiftCount;
        public int SpinCountState_MaxValue;
        public int NumWaitersState_BitMask;
        public int NumWaitersState_ShiftCount;
        public int NumWaitersState_MaxValue;
        public System.Action`1<object> s_cancellationTokenCallback;

        // ── Methods ──
        public void get_WaitHandle(){} // RVA: 0x7FFAC86BA730
        public void get_IsSet(){} // RVA: 0x7FFAC86BA770
        public void set_IsSet(){} // RVA: 0x7FFAC86BA7D0
        public void get_SpinCount(){} // RVA: 0x7FFAC86BA800
        public void set_SpinCount(){} // RVA: 0x7FFAC86BA860
        public void get_Waiters(){} // RVA: 0x7FFAC86BA880
        public void set_Waiters(){} // RVA: 0x7FFAC86BA8E0
        public void .ctor(){} // RVA: 0x7FFAC86BAAA0 | overloaded x3
        public void Initialize(){} // RVA: 0x7FFAC86BABA0
        public void EnsureLockObjectCreated(){} // RVA: 0x7FFAC86BAC60
        public void LazyInitializeEvent(){} // RVA: 0x7FFAC86BAD10
        public void Set(){} // RVA: 0x7FFAC86BB020 | overloaded x2
        public void Wait(){} // RVA: 0x7FFAC86BB490 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFAC86BBDF0 | overloaded x2
        public void ThrowIfDisposed(){} // RVA: 0x7FFAC86BBF80
        public void CancellationTokenCallback(){} // RVA: 0x7FFAC86BBFF0
        public void UpdateStateAtomically(){} // RVA: 0x7FFAC86BC1B0
        public void ExtractStatePortionAndShiftRight(){} // RVA: 0x7FFAC86BC290
        public void ExtractStatePortion(){} // RVA: 0x7FFAC86BC2A0
        public void .cctor(){} // RVA: 0x7FFAC86BC2B0
    }

    public class Monitor : Object
    {
        // ── Methods ──
        public void Enter(){} // RVA: 0x7FFAC86C95F0 | overloaded x2
        public void ThrowLockTakenException(){} // RVA: 0x7FFAC86C9670
        public void Exit(){} // RVA: 0x7FFAC86C96E0
        public void TryEnter(){} // RVA: 0x7FFAC86C9B40 | overloaded x5
        public void MillisecondsTimeoutFromTimeSpan(){} // RVA: 0x7FFAC86C98B0
        public void IsEntered(){} // RVA: 0x7FFAC86C9C00
        public void Wait(){} // RVA: 0x7FFAC86C9C80 | overloaded x2
        public void Pulse(){} // RVA: 0x7FFAC86C9DA0
        public void PulseAll(){} // RVA: 0x7FFAC86C9E70
        public void Monitor_test_synchronised(){} // RVA: 0x7FFAC86C9F80
        public void Monitor_pulse(){} // RVA: 0x7FFAC86C9FD0
        public void ObjPulse(){} // RVA: 0x7FFAC86CA000
        public void Monitor_pulse_all(){} // RVA: 0x7FFAC86CA0A0
        public void ObjPulseAll(){} // RVA: 0x7FFAC86CA110
        public void Monitor_wait(){} // RVA: 0x7FFAC86CA1F0
        public void ObjWait(){} // RVA: 0x7FFAC86CA220
        public void try_enter_with_atomic_var(){} // RVA: 0x7FFAC86CA310
        public void ReliableEnterTimeout(){} // RVA: 0x7FFAC86CA350
        public void ReliableEnter(){} // RVA: 0x7FFAC86CA430
        public void Monitor_test_owner(){} // RVA: 0x7FFAC86CA4C0
        public void IsEnteredNative(){} // RVA: 0x7FFAC86CA4C0
    }

    public class Mutex : WaitHandle
    {
        // ── Methods ──
        public void ReleaseMutex_internal(){} // RVA: 0x7FFAC86D4C10
        public void .ctor(){} // RVA: 0x7FFAC86D4C30
        public void ReleaseMutex(){} // RVA: 0x7FFAC86D4C90
    }

    public class NativeEventCalls : Object
    {
        // ── Methods ──
        public void CreateEvent_internal(){} // RVA: 0x7FFAC86D4CC0
        public void CreateEvent_icall(){} // RVA: 0x7FFAC86D4D50
        public void SetEvent(){} // RVA: 0x7FFAC86D4DE0
        public void SetEvent_internal(){} // RVA: 0x7FFAC86D4EC0
        public void ResetEvent(){} // RVA: 0x7FFAC86D4EE0
        public void ResetEvent_internal(){} // RVA: 0x7FFAC86D4FF0
        public void CloseEvent_internal(){} // RVA: 0x7FFAC86D5040
    }

    public class NativeOverlapped : ValueType
    {
        public UIntPtr InternalLow; // 0x10
        public UIntPtr InternalHigh; // 0x18
        public int OffsetLow; // 0x20
        public int OffsetHigh; // 0x24
        public UIntPtr EventHandle; // 0x28
    }

    public class OSSpecificSynchronizationContext : SynchronizationContext
    {
        public object m_OSSynchronizationContext; // 0x18
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<object,System.Threading.OSSpecificSynchronizationContext> s_ContextCache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F87E80
        public void Get(){} // RVA: 0x7FFAC86CAEF0
        public void CreateCopy(){} // RVA: 0x7FFAC86CB130
        public void Send(){} // RVA: 0x7FFAC86CB1D0
        public void Post(){} // RVA: 0x7FFAC86CB210
        public void InvocationEntry(){} // RVA: 0x7FFAC86CB5B0
        public void GetOSContext(){} // RVA: 0x7FFAC86CB740
        public void PostInternal(){} // RVA: 0x7FFAC86CB7D0
        public void .cctor(){} // RVA: 0x7FFAC86CB8F0
    }

    public class ParameterizedThreadStart : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class PlatformHelper : Object
    {
        public int ProcessorCount;
        public int s_lastProcessorCountRefreshTicks; // 0x4
        public bool IsSingleProcessor; // 0x8

        // ── Methods ──
        public void get_ProcessorCount(){} // RVA: 0x7FFAC86BC750
        public void .cctor(){} // RVA: 0x7FFAC86BC850
    }

    public class PreAllocatedOverlapped : Object
    {
        public System.Threading.Win32ThreadPoolNativeOverlapped* _overlapped; // 0x10
        public System.Threading.DeferredDisposableLifetime`1<System.Threading.PreAllocatedOverlapped> _lifetime; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC35D2DD0
        public void Release(){} // RVA: 0x7FFAC86C21E0
        public void Dispose(){} // RVA: 0x7FFAC86C22B0
        public void System.Threading.IDeferredDisposable.OnFinalRelease(){} // RVA: 0x7FFAC86C23A0
    }

    public class QueueUserWorkItemCallback : Object
    {
        public System.Threading.WaitCallback callback; // 0x10
        public System.Threading.ExecutionContext context; // 0x18
        public object state; // 0x20
        public System.Threading.ContextCallback ccb;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86D1590
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFAC86D1730
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFAC2F21310
        public void WaitCallback_Context(){} // RVA: 0x7FFAC86D1870
        public void .cctor(){} // RVA: 0x7FFAC86D18F0
    }

    public class ReaderWriterCount : Object
    {
        public long lockID; // 0x10
        public int readercount; // 0x18
        public int writercount; // 0x1C
        public int upgradecount; // 0x20
        public System.Threading.ReaderWriterCount next; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ReaderWriterLock : CriticalFinalizerObject
    {
        public int IsReaderLockHeld; // 0x10
        public int IsWriterLockHeld; // 0x14
        public int readers; // 0x18
        public int writer_lock_owner; // 0x1C
        public System.Threading.LockQueue writer_queue; // 0x20
        public System.Collections.Hashtable reader_locks; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86D5060
        public void Finalize(){} // RVA: 0x7FFAC86CDA80
        public void get_IsReaderLockHeld(){} // RVA: 0x7FFAC86D5220
        public void get_IsWriterLockHeld(){} // RVA: 0x7FFAC86D5400
        public void AcquireReaderLock(){} // RVA: 0x7FFAC86D5590 | overloaded x2
        public void AcquireWriterLock(){} // RVA: 0x7FFAC86D5AB0 | overloaded x2
        public void ReleaseReaderLock(){} // RVA: 0x7FFAC86D6190 | overloaded x2
        public void ReleaseWriterLock(){} // RVA: 0x7FFAC86D64E0 | overloaded x2
        public void HasWriterLock(){} // RVA: 0x7FFAC86D6540
    }

    public class ReaderWriterLockSlim : Object
    {
        public bool IsReadLockHeld; // 0x10
        public int IsUpgradeableReadLockHeld; // 0x14
        public int IsWriteLockHeld;
        public int RecursiveReadCount;
        public int RecursiveUpgradeCount;
        public uint RecursiveWriteCount; // 0x18
        public uint WaitingReadCount; // 0x1C
        public uint WaitingUpgradeCount; // 0x20
        public uint WaitingWriteCount; // 0x24
        public bool fNoWaiters; // 0x28
        public int upgradeLockOwnerId; // 0x2C
        public int writeLockOwnerId; // 0x30
        public System.Threading.EventWaitHandle writeEvent; // 0x38
        public System.Threading.EventWaitHandle readEvent; // 0x40
        public System.Threading.EventWaitHandle upgradeEvent; // 0x48
        public System.Threading.EventWaitHandle waitUpgradeEvent; // 0x50
        public long s_nextLockID;
        public long lockID; // 0x58
        public System.Threading.ReaderWriterCount t_rwc; // 0xFFFF
        public bool fUpgradeThreadHoldingRead; // 0x60
        public int MaxSpinCount;
        public uint owners; // 0x64
        public uint WRITER_HELD;
        public uint WAITING_WRITERS;
        public uint WAITING_UPGRADER;
        public uint MAX_READER;
        public uint READER_MASK;
        public bool fDisposed; // 0x68

        // ── Methods ──
        public void InitializeThreadCounts(){} // RVA: 0x7FFAC8E14490
        public void .ctor(){} // RVA: 0x7FFAC8E14500 | overloaded x2
        public void IsRWEntryEmpty(){} // RVA: 0x7FFAC8E14570
        public void IsRwHashEntryChanged(){} // RVA: 0x7FFAC8E145B0
        public void GetThreadRWCount(){} // RVA: 0x7FFAC8E145D0
        public void EnterReadLock(){} // RVA: 0x7FFAC8E14740
        public void TryEnterReadLock(){} // RVA: 0x7FFAC8E147F0 | overloaded x2
        public void TryEnterReadLockCore(){} // RVA: 0x7FFAC8E14800
        public void EnterWriteLock(){} // RVA: 0x7FFAC8E14B70
        public void TryEnterWriteLock(){} // RVA: 0x7FFAC8E14C20 | overloaded x2
        public void TryEnterWriteLockCore(){} // RVA: 0x7FFAC8E14C30
        public void EnterUpgradeableReadLock(){} // RVA: 0x7FFAC8E15110
        public void TryEnterUpgradeableReadLock(){} // RVA: 0x7FFAC8E151C0 | overloaded x2
        public void TryEnterUpgradeableReadLockCore(){} // RVA: 0x7FFAC8E151D0
        public void ExitReadLock(){} // RVA: 0x7FFAC8E15660
        public void ExitWriteLock(){} // RVA: 0x7FFAC8E15870
        public void ExitUpgradeableReadLock(){} // RVA: 0x7FFAC8E15AA0
        public void LazyCreateEvent(){} // RVA: 0x7FFAC8E15E10
        public void WaitOnEvent(){} // RVA: 0x7FFAC8E15F50
        public void ExitAndWakeUpAppropriateWaiters(){} // RVA: 0x7FFAC8E16210
        public void ExitAndWakeUpAppropriateWaitersPreferringWriters(){} // RVA: 0x7FFAC8E162A0
        public void ExitAndWakeUpAppropriateReadWaiters(){} // RVA: 0x7FFAC8E16320
        public void IsWriterAcquired(){} // RVA: 0x7FFAC8E163B0
        public void SetWriterAcquired(){} // RVA: 0x7FFAC8E163C0
        public void ClearWriterAcquired(){} // RVA: 0x7FFAC8E163D0
        public void SetWritersWaiting(){} // RVA: 0x7FFAC8E163E0
        public void ClearWritersWaiting(){} // RVA: 0x7FFAC8E163F0
        public void SetUpgraderWaiting(){} // RVA: 0x7FFAC8E16400
        public void ClearUpgraderWaiting(){} // RVA: 0x7FFAC8E16410
        public void GetNumReaders(){} // RVA: 0x7FFAC8E16420
        public void EnterMyLock(){} // RVA: 0x7FFAC8E16430
        public void EnterMyLockSpin(){} // RVA: 0x7FFAC8E16450
        public void ExitMyLock(){} // RVA: 0x7FFAC8E165C0
        public void SpinWait(){} // RVA: 0x7FFAC8E165D0
        public void Dispose(){} // RVA: 0x7FFAC8E16660 | overloaded x2
        public void get_IsReadLockHeld(){} // RVA: 0x7FFAC8E16AD0
        public void get_IsUpgradeableReadLockHeld(){} // RVA: 0x7FFAC8E16BA0
        public void get_IsWriteLockHeld(){} // RVA: 0x7FFAC8E16CE0
        public void get_RecursiveReadCount(){} // RVA: 0x7FFAC8E16E20
        public void get_RecursiveUpgradeCount(){} // RVA: 0x7FFAC8E16EE0
        public void get_RecursiveWriteCount(){} // RVA: 0x7FFAC8E17020
        public void get_WaitingReadCount(){} // RVA: 0x7FFAC44357F0
        public void get_WaitingUpgradeCount(){} // RVA: 0x7FFAC3921980
        public void get_WaitingWriteCount(){} // RVA: 0x7FFAC3157800
    }

    public class RegisteredWaitHandle : MarshalByRefObject
    {
        public System.Threading.WaitHandle _waitObject; // 0x18
        public System.Threading.WaitOrTimerCallback _callback; // 0x20
        public object _state; // 0x28
        public System.Threading.WaitHandle _finalEvent; // 0x30
        public System.Threading.ManualResetEvent _cancelEvent; // 0x38
        public System.TimeSpan _timeout; // 0x40
        public int _callsInProcess; // 0x48
        public bool _executeOnlyOnce; // 0x4C
        public bool _unregistered; // 0x4D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86D6590
        public void Wait(){} // RVA: 0x7FFAC86D67C0
        public void DoCallBack(){} // RVA: 0x7FFAC86D6FA0
        public void Unregister(){} // RVA: 0x7FFAC86D7230
    }

    public class SemaphoreFullException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x2
    }

    public class SemaphoreSlim : Object
    {
        public int CurrentCount; // 0x10
        public int m_maxCount; // 0x14
        public int m_waitCount; // 0x18
        public object m_lockObj; // 0x20
        public System.Threading.ManualResetEvent m_waitHandle; // 0x28
        public TaskNode m_asyncHead; // 0x30
        public TaskNode m_asyncTail; // 0x38
        public System.Threading.Tasks.Task`1<bool> s_trueTask;
        public System.Threading.Tasks.Task`1<bool> s_falseTask; // 0x8
        public int NO_MAXIMUM;
        public System.Action`1<object> s_cancellationTokenCanceledEventHandler; // 0x10

        // ── Methods ──
        public void get_CurrentCount(){} // RVA: 0x7FFAC86C2530
        public void .ctor(){} // RVA: 0x7FFAC86C2550 | overloaded x2
        public void Wait(){} // RVA: 0x7FFAC86C2730 | overloaded x3
        public void WaitUntilCountOrTimeout(){} // RVA: 0x7FFAC86C3020
        public void WaitAsync(){} // RVA: 0x7FFAC86C3160 | overloaded x3
        public void CreateAndAddAsyncWaiter(){} // RVA: 0x7FFAC86C35A0
        public void RemoveAsyncWaiter(){} // RVA: 0x7FFAC86C3810
        public void WaitUntilCountOrTimeoutAsync(){} // RVA: 0x7FFAC86C3A80
        public void Release(){} // RVA: 0x7FFAC86C3D00 | overloaded x2
        public void QueueWaiterTask(){} // RVA: 0x7FFAC86C4080
        public void Dispose(){} // RVA: 0x7FFAC86C4100 | overloaded x2
        public void CancellationTokenCanceledEventHandler(){} // RVA: 0x7FFAC86C42B0
        public void CheckDispose(){} // RVA: 0x7FFAC86C4470
        public void GetResourceString(){} // RVA: 0x7FFAC44F81E0
        public void .cctor(){} // RVA: 0x7FFAC86C4500
    }

    public class SendOrPostCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class SparselyPopulatedArrayAddInfo`1 : ValueType
    {
        public System.Threading.SparselyPopulatedArrayFragment`1<T> Source;
        public int Index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C77970
        public void get_Source(){} // RVA: 0x7FFAC2C58E90
        public void get_Index(){} // RVA: 0x7FFAC2C59960
    }

    public class SparselyPopulatedArrayFragment`1 : Object
    {
        public T[] Item;
        public int Length;
        public System.Threading.SparselyPopulatedArrayFragment`1<T> Prev;
        public System.Threading.SparselyPopulatedArrayFragment`1<T> _prev;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72BC0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void get_Prev(){} // RVA: 0x7FFAC2C58E90
        public void SafeAtomicRemove(){} // RVA: 0x7FFAC2E8DC40
    }

    public class SparselyPopulatedArray`1 : Object
    {
        public System.Threading.SparselyPopulatedArrayFragment`1<T> Tail;
        public System.Threading.SparselyPopulatedArrayFragment`1<T> _tail;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void get_Tail(){} // RVA: 0x7FFAC2C58E90
        public void Add(){} // RVA: 0x7FFAC2E8DC40
    }

    public class SpinLock : ValueType
    {
        public int IsHeldByCurrentThread; // 0x10
        public int IsThreadOwnerTrackingEnabled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86C5550
        public void Enter(){} // RVA: 0x7FFAC86C5570
        public void TryEnter(){} // RVA: 0x7FFAC86C5620
        public void ContinueTryEnter(){} // RVA: 0x7FFAC86C56E0
        public void DecrementWaiters(){} // RVA: 0x7FFAC86C5B20
        public void ContinueTryEnterWithThreadTracking(){} // RVA: 0x7FFAC86C5BE0
        public void Exit(){} // RVA: 0x7FFAC86C5E40
        public void ExitSlowPath(){} // RVA: 0x7FFAC86C5EE0
        public void get_IsHeldByCurrentThread(){} // RVA: 0x7FFAC86C6020
        public void get_IsThreadOwnerTrackingEnabled(){} // RVA: 0x7FFAC86C6140
        public void .cctor(){} // RVA: 0x7FFAC86C6150
    }

    public class SpinWait : ValueType
    {
        public int Count;
        public int NextSpinWillYield; // 0x10

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC4420210
        public void get_NextSpinWillYield(){} // RVA: 0x7FFAC86BC390
        public void SpinOnce(){} // RVA: 0x7FFAC86BC460 | overloaded x2
        public void SpinOnceCore(){} // RVA: 0x7FFAC86BC560
        public void Reset(){} // RVA: 0x7FFAC49FC580
        public void .cctor(){} // RVA: 0x7FFAC86BC6C0
    }

    public class SynchronizationContext : Object
    {
        public 0x6B0C6B90 Current; // 0x10
        public System.Type CurrentNoFlow;
        public System.Type CurrentExplicit; // 0x8
        public System.Type s_cachedPreparedType3; // 0x10
        public System.Type s_cachedPreparedType4; // 0x18
        public System.Type s_cachedPreparedType5; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void SetWaitNotificationRequired(){} // RVA: 0x7FFAC86CA520
        public void IsWaitNotificationRequired(){} // RVA: 0x7FFAC86CA8D0
        public void Send(){} // RVA: 0x7FFAC5C5C990
        public void Post(){} // RVA: 0x7FFAC86CA8E0
        public void OperationStarted(){} // RVA: 0x7FFAC2F21310
        public void OperationCompleted(){} // RVA: 0x7FFAC2F21310
        public void Wait(){} // RVA: 0x7FFAC86CA970
        public void WaitHelper(){} // RVA: 0x7FFAC86CAA60
        public void SetSynchronizationContext(){} // RVA: 0x7FFAC86CAB00
        public void get_Current(){} // RVA: 0x7FFAC86CABF0
        public void get_CurrentNoFlow(){} // RVA: 0x7FFAC86CACB0
        public void GetThreadLocalContext(){} // RVA: 0x7FFAC86CAD70
        public void CreateCopy(){} // RVA: 0x7FFAC86CADC0
        public void get_CurrentExplicit(){} // RVA: 0x7FFAC86CAE00
    }

    public class SynchronizationLockException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class SystemThreading_ThreadLocalDebugView`1 : Object
    {
    }

    public class Thread : CriticalFinalizerObject
    {
        public System.LocalDataStoreMgr ExecutionContextBelongsToCurrentScope;
        public System.LocalDataStoreHolder Priority; // 0xFFFF
        public System.Globalization.CultureInfo CurrentUICulture; // 0xFFFF
        public System.Globalization.CultureInfo CurrentCulture; // 0xFFFF
        public System.Threading.AsyncLocal`1<System.Globalization.CultureInfo> Internal; // 0x8
        public System.Threading.AsyncLocal`1<System.Globalization.CultureInfo> CurrentContext; // 0x10
        public System.Threading.InternalThread CurrentThread; // 0x10
        public object CurrentThreadId; // 0x18
        public object IsThreadPoolThread; // 0x20
        public System.Threading.Thread IsThreadPoolThreadInternal; // 0xFFFF
        public System.MulticastDelegate IsAlive; // 0x28
        public System.Threading.ExecutionContext IsBackground; // 0x30
        public bool Name; // 0x38
        public System.Security.Principal.IPrincipal ThreadState; // 0x40
        public int ManagedThreadId; // 0x48

        // ── Methods ──
        public void AsyncLocalSetCurrentUICulture(){} // RVA: 0x7FFAC86CBF90
        public void .ctor(){} // RVA: 0x7FFAC86CC1A0 | overloaded x3
        public void Start(){} // RVA: 0x7FFAC86CC3C0 | overloaded x3
        public void GetExecutionContextReader(){} // RVA: 0x7FFAC86CC5C0
        public void get_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x7FFAC86CC620
        public void set_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x7FFAC86CC630
        public void GetMutableExecutionContext(){} // RVA: 0x7FFAC86CC640
        public void SetExecutionContext(){} // RVA: 0x7FFAC86CC770 | overloaded x2
        public void get_Priority(){} // RVA: 0x7FFAC86CC7D0
        public void set_Priority(){} // RVA: 0x7FFAC86CC850
        public void GetPriorityNative(){} // RVA: 0x7FFAC86CC7D0
        public void SetPriorityNative(){} // RVA: 0x7FFAC86CC850
        public void JoinInternal(){} // RVA: 0x7FFAC86CC8E0
        public void Join(){} // RVA: 0x7FFAC86CC9B0
        public void SleepInternal(){} // RVA: 0x7FFAC86CCA70
        public void Sleep(){} // RVA: 0x7FFAC86CCB00
        public void YieldInternal(){} // RVA: 0x7FFAC83BAE60
        public void Yield(){} // RVA: 0x7FFAC83BAE60
        public void SetStartHelper(){} // RVA: 0x7FFAC86CCC00
        public void get_CurrentUICulture(){} // RVA: 0x7FFAC86CCDC0
        public void set_CurrentUICulture(){} // RVA: 0x7FFAC86CCE00
        public void GetCurrentUICultureNoAppX(){} // RVA: 0x7FFAC86CD1E0
        public void get_CurrentCulture(){} // RVA: 0x7FFAC86CD390
        public void GetCurrentCultureNoAppX(){} // RVA: 0x7FFAC86CD3D0
        public void nativeInitCultureAccessors(){} // RVA: 0x7FFAC86CD540
        public void MemoryBarrier(){} // RVA: 0x7FFAC86CD780
        public void ConstructInternalThread(){} // RVA: 0x7FFAC86CD790
        public void get_Internal(){} // RVA: 0x7FFAC86CD7D0
        public void get_CurrentContext(){} // RVA: 0x7FFAC847E330
        public void GetCurrentThread_icall(){} // RVA: 0x7FFAC86CD830
        public void GetCurrentThread(){} // RVA: 0x7FFAC86CD8B0
        public void get_CurrentThread(){} // RVA: 0x7FFAC86CD940
        public void get_CurrentThreadId(){} // RVA: 0x7FFAC86CDA40
        public void GetDomainID(){} // RVA: 0x7FFAC8693880
        public void Thread_internal(){} // RVA: 0x7FFAC86CDA70
        public void Finalize(){} // RVA: 0x7FFAC86CDA80
        public void get_IsThreadPoolThread(){} // RVA: 0x7FFAC86CDAC0
        public void get_IsThreadPoolThreadInternal(){} // RVA: 0x7FFAC86CDAC0
        public void get_IsAlive(){} // RVA: 0x7FFAC86CDB20
        public void set_IsBackground(){} // RVA: 0x7FFAC86CDB80
        public void GetName_internal(){} // RVA: 0x7FFAC86CDCF0
        public void SetName_icall(){} // RVA: 0x7FFAC86CDDB0
        public void SetName_internal(){} // RVA: 0x7FFAC86CDDC0
        public void get_Name(){} // RVA: 0x7FFAC86CDDF0
        public void set_Name(){} // RVA: 0x7FFAC86CDEF0
        public void get_ThreadState(){} // RVA: 0x7FFAC86CDF70
        public void Abort_internal(){} // RVA: 0x7FFAC86CDFC0
        public void Abort(){} // RVA: 0x7FFAC86CDFD0
        public void SpinWait_nop(){} // RVA: 0x7FFAC2F21310
        public void SpinWait(){} // RVA: 0x7FFAC86CE020
        public void StartInternal(){} // RVA: 0x7FFAC86CE030
        public void SetState(){} // RVA: 0x7FFAC86CE0E0
        public void ClrState(){} // RVA: 0x7FFAC86CE0F0
        public void GetState(){} // RVA: 0x7FFAC86CE100
        public void VolatileRead(){} // RVA: 0x7FFAC4C5EB10
        public void SystemMaxStackStize(){} // RVA: 0x7FFAC83CAF20
        public void GetProcessDefaultStackSize(){} // RVA: 0x7FFAC86CE170
        public void SetStart(){} // RVA: 0x7FFAC86CE1F0
        public void get_ManagedThreadId(){} // RVA: 0x7FFAC86CE2B0
        public void BeginCriticalRegion(){} // RVA: 0x7FFAC86CE310
        public void EndCriticalRegion(){} // RVA: 0x7FFAC86CE390
        public void GetHashCode(){} // RVA: 0x7FFAC86CE2B0
        public void ValidateThreadState(){} // RVA: 0x7FFAC86CE410
    }

    public class ThreadAbortException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x2
    }

    public class ThreadHelper : Object
    {
        public System.Delegate _start; // 0x10
        public object _startArg; // 0x18
        public System.Threading.ExecutionContext _executionContext; // 0x20
        public System.Threading.ContextCallback _ccb;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void SetExecutionContextHelper(){} // RVA: 0x7FFAC2F4F0D0
        public void ThreadStart_Context(){} // RVA: 0x7FFAC86CBB00
        public void ThreadStart(){} // RVA: 0x7FFAC86CBDA0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC86CBEB0
    }

    public class ThreadInterruptedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x2
    }

    public class ThreadLocal`1 : Object
    {
        public System.Func`1<T> Value;
        public LinkedSlotVolatile<T>[] IsValueCreated; // 0xFFFF
        public FinalizationHelper<T> ts_finalizationHelper; // 0xFFFF
        public int m_idComplement;
        public bool m_initialized;
        public IdManager<T> s_idManager;
        public LinkedSlot<T> m_linkedSlot;
        public bool m_trackAllValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAC2C76500
        public void Finalize(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C71060 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
        public void set_Value(){} // RVA: 0x7FFAC2E8DC40
        public void GetValueSlow(){} // RVA: 0x7FFAC2E8DC40
        public void SetValueSlow(){} // RVA: 0x7FFAC2E8DC40
        public void CreateLinkedSlot(){} // RVA: 0x7FFAC2E8DC40
        public void get_IsValueCreated(){} // RVA: 0x7FFAC2C59D00
        public void GrowTable(){} // RVA: 0x7FFAC2C77970
        public void GetNewTableSize(){} // RVA: 0x7FFAC2C60110
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ThreadPool : Object
    {
        public object IsThreadPoolThread;

        // ── Methods ──
        public void GetMaxThreads(){} // RVA: 0x7FFAC86D19D0
        public void GetMinThreads(){} // RVA: 0x7FFAC86D1A20
        public void GetAvailableThreads(){} // RVA: 0x7FFAC86D1A70
        public void RegisterWaitForSingleObject(){} // RVA: 0x7FFAC86D1F60 | overloaded x3
        public void QueueUserWorkItem(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void QueueUserWorkItemHelper(){} // RVA: 0x7FFAC86D2340
        public void UnsafeQueueCustomWorkItem(){} // RVA: 0x7FFAC86D26D0
        public void TryPopCustomWorkItem(){} // RVA: 0x7FFAC86D27C0
        public void RequestWorkerThread(){} // RVA: 0x7FFAC86D2900
        public void EnsureVMInitialized(){} // RVA: 0x7FFAC86D2920
        public void GetMinThreadsNative(){} // RVA: 0x7FFAC86D1A20
        public void GetMaxThreadsNative(){} // RVA: 0x7FFAC86D19D0
        public void GetAvailableThreadsNative(){} // RVA: 0x7FFAC86D1A70
        public void NotifyWorkItemComplete(){} // RVA: 0x7FFAC86D29D0
        public void ReportThreadStatus(){} // RVA: 0x7FFAC8533400
        public void NotifyWorkItemProgress(){} // RVA: 0x7FFAC83CC6B0
        public void NotifyWorkItemProgressNative(){} // RVA: 0x7FFAC86D2A60
        public void NotifyWorkItemQueued(){} // RVA: 0x7FFAC2F21310
        public void InitializeVMTp(){} // RVA: 0x7FFAC86D2AC0
        public void get_IsThreadPoolThread(){} // RVA: 0x7FFAC86D2AD0
    }

    public class ThreadPoolBoundHandle : Object
    {
        public System.Runtime.InteropServices.SafeHandle Handle; // 0x10
        public Microsoft.Win32.SafeHandles.SafeThreadPoolIOHandle _threadPoolHandle; // 0x18
        public System.Threading.DeferredDisposableLifetime`1<System.Threading.ThreadPoolBoundHandle> _lifetime; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC35D2DD0
        public void .ctor(){} // RVA: 0x7FFAC86BFC90
        public void get_Handle(){} // RVA: 0x7FFAC2F3C380
        public void BindHandle(){} // RVA: 0x7FFAC86BFD40
        public void AllocateNativeOverlapped(){} // RVA: 0x7FFAC86C02D0
        public void FreeNativeOverlapped(){} // RVA: 0x7FFAC86C0560
        public void GetNativeOverlappedState(){} // RVA: 0x7FFAC86C0870
        public void GetOverlappedData(){} // RVA: 0x7FFAC86C0950
        public void OnNativeIOCompleted(){} // RVA: 0x7FFAC86C0A90
        public void AddRef(){} // RVA: 0x7FFAC86C0CA0
        public void Release(){} // RVA: 0x7FFAC86C0D20
        public void Dispose(){} // RVA: 0x7FFAC86C0DF0
        public void Finalize(){} // RVA: 0x7FFAC86C0EE0
        public void System.Threading.IDeferredDisposable.OnFinalRelease(){} // RVA: 0x7FFAC86C0F30
    }

    public class ThreadPoolCallbackWrapper : ValueType
    {
        public Internal.Runtime.Augments.RuntimeThread _currentThread; // 0x10

        // ── Methods ──
        public void Enter(){} // RVA: 0x7FFAC86BFB40
        public void Exit(){} // RVA: 0x7FFAC86BFC70
    }

    public class ThreadPoolGlobals : Object
    {
        public int processorCount;
        public bool vmTpInitialized; // 0x4
        public bool enableWorkerTracking; // 0x5
        public System.Threading.ThreadPoolWorkQueue workQueue; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC86CE590
    }

    public class ThreadPoolWorkQueue : Object
    {
        public QueueSegment queueHead; // 0x10
        public QueueSegment queueTail; // 0x18
        public SparseArray`1<WorkStealingQueue> allThreadQueues;
        public int numOutstandingThreadRequests; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86CE760
        public void EnsureCurrentThreadHasQueue(){} // RVA: 0x7FFAC86CE870
        public void EnsureThreadRequested(){} // RVA: 0x7FFAC86CE9C0
        public void MarkThreadRequestSatisfied(){} // RVA: 0x7FFAC86CEA60
        public void Enqueue(){} // RVA: 0x7FFAC86CEA90
        public void LocalFindAndPop(){} // RVA: 0x7FFAC86CED00
        public void Dequeue(){} // RVA: 0x7FFAC86CEDB0
        public void Dispatch(){} // RVA: 0x7FFAC86CF070
        public void .cctor(){} // RVA: 0x7FFAC86CF630
    }

    public class ThreadPoolWorkQueueThreadLocals : Object
    {
        public System.Threading.ThreadPoolWorkQueueThreadLocals threadLocals; // 0xFFFF
        public System.Threading.ThreadPoolWorkQueue workQueue; // 0x10
        public WorkStealingQueue workStealingQueue; // 0x18
        public System.Random random; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86D1030
        public void CleanUp(){} // RVA: 0x7FFAC86D1320
        public void Finalize(){} // RVA: 0x7FFAC86D14C0
    }

    public class ThreadStart : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7F980
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    }

    public class ThreadStateException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class Timeout : Object
    {
        public System.TimeSpan InfiniteTimeSpan;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC86B9AE0
    }

    public class TimeoutHelper : Object
    {
        // ── Methods ──
        public void GetTime(){} // RVA: 0x7FFAC8695960
        public void UpdateTimeOut(){} // RVA: 0x7FFAC86BC8A0
    }

    public class Timer : MarshalByRefObject
    {
        public System.Threading.TimerCallback scheduler; // 0x18
        public object state; // 0x20
        public long due_time_ms; // 0x28
        public long period_ms; // 0x30
        public long next_run; // 0x38
        public bool disposed; // 0x40
        public bool is_dead; // 0x41
        public bool is_added; // 0x42
        public long MaxValue;

        // ── Methods ──
        public void get_scheduler(){} // RVA: 0x7FFAC86D75C0
        public void .ctor(){} // RVA: 0x7FFAC86D7770 | overloaded x3
        public void Init(){} // RVA: 0x7FFAC86D77A0
        public void Change(){} // RVA: 0x7FFAC86D7A10 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFAC86D79D0
        public void DisposeAsync(){} // RVA: 0x7FFAC86D7C80
        public void KeepRootedWhileScheduled(){} // RVA: 0x7FFAC2F21310
        public void GetTimeMonotonic(){} // RVA: 0x7FFAC86D7DC0
    }

    public class TimerCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class Volatile : Object
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void Write(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
    }

    public class WaitCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class WaitHandle : MarshalByRefObject
    {
        public int Handle;
        public int SafeWaitHandle;
        public UIntPtr waitHandle; // 0x18
        public Microsoft.Win32.SafeHandles.SafeWaitHandle safeWaitHandle; // 0x20
        public bool hasThreadAffinity; // 0x28
        public int WAIT_OBJECT_0;
        public int WAIT_ABANDONED;
        public int WAIT_FAILED;
        public int ERROR_TOO_MANY_POSTS;
        public int ERROR_NOT_OWNED_BY_CALLER;
        public UIntPtr InvalidHandle;
        public int MaxWaitHandles;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86D2B40
        public void Init(){} // RVA: 0x7FFAC86D2B40
        public void get_Handle(){} // RVA: 0x7FFAC86D2C00
        public void set_Handle(){} // RVA: 0x7FFAC86D2C90
        public void get_SafeWaitHandle(){} // RVA: 0x7FFAC86D2E50
        public void SetHandleInternal(){} // RVA: 0x7FFAC86D2FA0
        public void WaitOne(){} // RVA: 0x7FFAC86D31E0 | overloaded x6
        public void InternalWaitOne(){} // RVA: 0x7FFAC86D3340
        public void WaitAny(){} // RVA: 0x7FFAC86D3810 | overloaded x2
        public void ThrowAbandonedMutexException(){} // RVA: 0x7FFAC86D3990 | overloaded x2
        public void Close(){} // RVA: 0x7FFAC86D39F0
        public void Dispose(){} // RVA: 0x7FFAC86D3AB0 | overloaded x2
        public void WaitOneNative(){} // RVA: 0x7FFAC86D3B20
        public void WaitMultiple(){} // RVA: 0x7FFAC86D3D80
        public void Wait_internal(){} // RVA: 0x7FFAC86D4380
        public void .cctor(){} // RVA: 0x7FFAC86D4390
    }

    public class WaitHandleCannotBeOpenedException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC850A3C0 | overloaded x3
    }

    public class WaitOrTimerCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6056440
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class Win32ThreadPoolNativeOverlapped : ValueType
    {
        public ExecutionContextCallbackArgs Data; // 0xFFFF
        public System.Threading.ContextCallback s_executionContextCallback;
        public OverlappedData[] s_dataArray; // 0x8
        public int s_dataCount; // 0x10
        public UIntPtr s_freeList; // 0x18
        public System.Threading.NativeOverlapped _overlapped; // 0x10
        public UIntPtr _nextFree; // 0x30
        public int _dataIndex; // 0x38

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC35D2DD0
        public void get_Data(){} // RVA: 0x7FFAC86C0F70
        public void Allocate(){} // RVA: 0x7FFAC86C0FF0
        public void AllocateNew(){} // RVA: 0x7FFAC86C10E0
        public void SetData(){} // RVA: 0x7FFAC86C1540
        public void Free(){} // RVA: 0x7FFAC86C1970
        public void ToNativeOverlapped(){} // RVA: 0x7FFAC44F81E0
        public void FromNativeOverlapped(){} // RVA: 0x7FFAC44F81E0
        public void CompleteWithCallback(){} // RVA: 0x7FFAC86C1A40
        public void OnExecutionContextCallback(){} // RVA: 0x7FFAC86C1D80
    }

    public class _ThreadPoolWaitCallback : Object
    {
        // ── Methods ──
        public void PerformWaitCallback(){} // RVA: 0x7FFAC86D1540
    }

}