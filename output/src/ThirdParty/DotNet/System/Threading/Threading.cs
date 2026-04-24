// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading
// Classes: 46
// Methods: 453

namespace ThirdParty.DotNet.System.Threading
{
    public class AsyncLocalValueChangedArgs`1 : ValueType
    {
        public T1717586608 CurrentValue;
        public T1717586608 <CurrentValue>k__BackingField;
        public bool <ThreadContextChanged>k__BackingField;

        // ── Methods ──
        public void get_CurrentValue(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    }

    public class AsyncLocal`1 : Object
    {
        public ileFullDirectoryInformation<sageKind.hreshold<T1717586592>> Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
        public void set_Value(){} // RVA: 0x7FFD4E2ADC40
        public void System.Threading.IAsyncLocal.OnValueChanged(){}
    }

    public class CancellationToken : ValueType
    {
        public sageKind._internal None; // 0x10
        public ileFullDirectoryInformation<object> IsCancellationRequested;

        // ── Methods ──
        public void get_None(){} // RVA: 0x7FFD4E919180
        public void get_IsCancellationRequested(){} // RVA: 0x7FFD53AD9B90
        public void get_CanBeCanceled(){} // RVA: 0x7FFD4EFD0800
        public void .ctor(){} // RVA: 0x7FFD53AD9BB0 | overloaded x2
        public void Register(){} // RVA: 0x7FFD53ADA0E0 | overloaded x5
        public void InternalRegisterWithoutEC(){} // RVA: 0x7FFD53ADA030
        public void Equals(){} // RVA: 0x7FFD53ADA240 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53ADA2E0
        public void op_Equality(){} // RVA: 0x7FFD53ADA360
        public void op_Inequality(){} // RVA: 0x7FFD53ADA3C0
        public void ThrowIfCancellationRequested(){} // RVA: 0x7FFD53ADA420
        public void ThrowOperationCanceledException(){} // RVA: 0x7FFD53ADA4A0
        public void .cctor(){} // RVA: 0x7FFD53ADA500
    }

    public class CancellationTokenRegistration : ValueType
    {
        public sageKind.rg_RegSetStrArrNull Token; // 0x10
        public sageKind.tionSet<sageKind.rg_RegSetStrArrNull> m_registrationInfo; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD515148A0
        public void get_Token(){} // RVA: 0x7FFD53ADC8E0
        public void Unregister(){} // RVA: 0x7FFD53ADC910
        public void Dispose(){} // RVA: 0x7FFD53ADC9A0
        public void Equals(){} // RVA: 0x7FFD53ADCBE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53ADCC70
        public void DisposeAsync(){} // RVA: 0x7FFD53ADCCF0
    }

    public class CancellationTokenSource : Object
    {
        public sageKind._internal IsCancellationRequested;
        public sageKind._internal IsCancellationCompleted; // 0x8
        public int IsDisposed; // 0x10
        public sageKind.tion ThreadIDExecutingCallbacks; // 0x10
        public sageKind.ype<sageKind.rg_RegSetStrArrNull>[] Token; // 0x18
        public int ExecutingCallback;
        public int NotCanceledState;
        public int NotifyingState;
        public int NotifyingCompleteState;
        public int _state; // 0x20
        public int _threadIDExecutingCallbacks; // 0x24
        public bool _disposed; // 0x28
        public sageKind.rg_RegSetStrArrNull _executingCallback; // 0x30
        public sageKind.lized _timer; // 0x38
        public sageKind.icCookieGlitch s_timerCallback; // 0x18

        // ── Methods ──
        public void get_IsCancellationRequested(){} // RVA: 0x7FFD53ADCE20
        public void get_IsCancellationCompleted(){} // RVA: 0x7FFD53ADCE30
        public void get_IsDisposed(){} // RVA: 0x7FFD4E516BA0
        public void get_ThreadIDExecutingCallbacks(){} // RVA: 0x7FFD53ADCE40
        public void set_ThreadIDExecutingCallbacks(){} // RVA: 0x7FFD53ADCE50
        public void get_Token(){} // RVA: 0x7FFD53ADCE60
        public void get_ExecutingCallback(){} // RVA: 0x7FFD53995260
        public void .ctor(){} // RVA: 0x7FFD53ADD020 | overloaded x3
        public void InitializeWithTimer(){} // RVA: 0x7FFD53ADD0A0
        public void Cancel(){} // RVA: 0x7FFD53ADD220 | overloaded x2
        public void CancelAfter(){} // RVA: 0x7FFD53ADD370 | overloaded x2
        public void TimerCallbackLogic(){} // RVA: 0x7FFD53ADD5A0
        public void Dispose(){} // RVA: 0x7FFD53ADD710 | overloaded x2
        public void ThrowIfDisposed(){} // RVA: 0x7FFD53ADD860
        public void ThrowObjectDisposedException(){} // RVA: 0x7FFD53ADD8B0
        public void InternalRegister(){} // RVA: 0x7FFD53ADD910
        public void NotifyCancellation(){} // RVA: 0x7FFD53ADDEE0
        public void ExecuteCallbackHandlers(){} // RVA: 0x7FFD53ADDFA0
        public void CancellationCallbackCoreWork_OnSyncContext(){} // RVA: 0x7FFD53ADE450
        public void CancellationCallbackCoreWork(){} // RVA: 0x7FFD53ADE4D0
        public void CreateLinkedTokenSource(){} // RVA: 0x7FFD53ADE900 | overloaded x3
        public void WaitForCallbackToComplete(){} // RVA: 0x7FFD53ADEAA0
        public void .cctor(){} // RVA: 0x7FFD53ADEB70
    }

    public class ContextCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3C1190
        public void Invoke(){} // RVA: 0x7FFD4E39CC60
    }

    public class ContextCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E090A40
    }

    public class DeferredDisposableLifetime`1 : ValueType
    {
        public int _count;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void AddRef(){} // RVA: 0x7FFD4E2ADC40
        public void Release(){} // RVA: 0x7FFD4E2ADC40
        public void Dispose(){} // RVA: 0x7FFD4E2ADC40
    }

    public class EventWaitHandle : WaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AE6460 | overloaded x2
        public void Reset(){} // RVA: 0x7FFD53AE67E0
        public void Set(){} // RVA: 0x7FFD53AE6840
    }

    public class ExecutionContext : Object
    {
        public sageKind.ironmentVariable_native isNewCapture; // 0x10
        public sageKind.ironmentVariable_native isFlowSuppressed; // 0x18
        public _HasPrivateKey.iables IsPreAllocatedDefault; // 0x20
        public _HasPrivateKey.neArgs LogicalCallContext; // 0x28
        public tf32 IllogicalCallContext; // 0x30
        public URA.DateTime<sageKind.rray,object> SynchronizationContext; // 0x38
        public URA.woDigitYearMax<sageKind.rray> SynchronizationContextNoFlow; // 0x40
        public sageKind.d s_dummyDefaultEC;
        public sageKind.d Default; // 0x8

        // ── Methods ──
        public void get_isNewCapture(){} // RVA: 0x7FFD53AE6F00
        public void set_isNewCapture(){} // RVA: 0x7FFD53AE6F10
        public void get_isFlowSuppressed(){} // RVA: 0x7FFD53AE6F30
        public void set_isFlowSuppressed(){} // RVA: 0x7FFD53AE6F40
        public void get_IsPreAllocatedDefault(){} // RVA: 0x7FFD53AE6F60
        public void .ctor(){} // RVA: 0x7FFD53AE90B0 | overloaded x3
        public void GetLocalValue(){} // RVA: 0x7FFD53AE6F80
        public void SetLocalValue(){} // RVA: 0x7FFD53AE7060
        public void OnAsyncLocalContextChanged(){} // RVA: 0x7FFD53AE7400
        public void get_LogicalCallContext(){} // RVA: 0x7FFD53AE7860
        public void set_LogicalCallContext(){} // RVA: 0x7FFD4E36F0D0
        public void get_IllogicalCallContext(){} // RVA: 0x7FFD53AE7900
        public void set_IllogicalCallContext(){} // RVA: 0x7FFD4E342E90
        public void get_SynchronizationContext(){} // RVA: 0x7FFD4E35C380
        public void set_SynchronizationContext(){} // RVA: 0x7FFD4E342E30
        public void get_SynchronizationContextNoFlow(){} // RVA: 0x7FFD4E3447C0
        public void set_SynchronizationContextNoFlow(){} // RVA: 0x7FFD4E3A7E80
        public void Dispose(){} // RVA: 0x7FFD4E9F2DD0
        public void Run(){} // RVA: 0x7FFD53AE7AE0 | overloaded x2
        public void RunInternal(){} // RVA: 0x7FFD4E09B2F0 | overloaded x4
        public void EstablishCopyOnWriteScope(){} // RVA: 0x7FFD53AE7E70 | overloaded x2
        public void SetExecutionContext(){} // RVA: 0x7FFD53AE7FB0
        public void CreateCopy(){} // RVA: 0x7FFD53AE82D0
        public void CreateMutableCopy(){} // RVA: 0x7FFD53AE8520
        public void SuppressFlow(){} // RVA: 0x7FFD53AE8810
        public void RestoreFlow(){} // RVA: 0x7FFD53AE88F0
        public void IsFlowSuppressed(){} // RVA: 0x7FFD53AE8990
        public void Capture(){} // RVA: 0x7FFD53AE8AC0 | overloaded x2
        public void FastCapture(){} // RVA: 0x7FFD53AE8A70
        public void GetObjectData(){} // RVA: 0x7FFD53AE8F00
        public void IsDefaultFTContext(){} // RVA: 0x7FFD53AE9280
        public void .cctor(){} // RVA: 0x7FFD53AE92F0
    }

    public class IAsyncLocal
    {
        // ── Methods ──
        public void OnValueChanged(){}
    }

    public class IDeferredDisposable
    {
        // ── Methods ──
        public void OnFinalRelease(){} // RVA: 0x7FFD4E091060
    }

    public class IThreadPoolWorkItem
    {
        // ── Methods ──
        public void ExecuteWorkItem(){} // RVA: 0x7FFD4E090980
        public void MarkAborted(){} // RVA: 0x7FFD4E090A40
    }

    public class Interlocked : Object
    {
        // ── Methods ──
        public void CompareExchange(){} // RVA: 0x7FFD4E2ADC40 | overloaded x9
        public void Decrement(){} // RVA: 0x7FFD53AF44F0
        public void Increment(){} // RVA: 0x7FFD53AF4510 | overloaded x2
        public void Exchange(){} // RVA: 0x7FFD4E2ADC40 | overloaded x8
        public void Read(){} // RVA: 0x7FFD53AF4660
        public void Add(){} // RVA: 0x7FFD53AF4680 | overloaded x2
        public void MemoryBarrier(){} // RVA: 0x7FFD53AED780
    }

    public class InternalThread : CriticalFinalizerObject
    {
        public int lock_thread_id; // 0x10
        public UIntPtr handle; // 0x18
        public UIntPtr native_handle; // 0x20
        public UIntPtr name_chars; // 0x28
        public int name_free; // 0x30
        public int name_length; // 0x34
        public sageKind.meKind state; // 0x38
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
        public void Thread_free_internal(){} // RVA: 0x7FFD53AF7430
        public void Finalize(){} // RVA: 0x7FFD53AF74D0
        public void .ctor(){} // RVA: 0x7FFD53AF75B0
    }

    public class LazyInitializer : Object
    {
        // ── Methods ──
        public void EnsureInitialized(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void EnsureInitializedCore(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void EnsureLockInitialized(){} // RVA: 0x7FFD53AD97A0
    }

    public class Lock : Object
    {
        public object _lock; // 0x10

        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFD53AE2430
        public void Release(){} // RVA: 0x7FFD53AE2470
        public void .ctor(){} // RVA: 0x7FFD53AE24A0
    }

    public class ManualResetEvent : EventWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AD9990
    }

    public class ManualResetEventSlim : Object
    {
        public int WaitHandle;
        public object IsSet; // 0x10
        public sageKind.tion SpinCount; // 0x18
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
        public ileFullDirectoryInformation<object> s_cancellationTokenCallback;

        // ── Methods ──
        public void get_WaitHandle(){} // RVA: 0x7FFD53ADA730
        public void get_IsSet(){} // RVA: 0x7FFD53ADA770
        public void set_IsSet(){} // RVA: 0x7FFD53ADA7D0
        public void get_SpinCount(){} // RVA: 0x7FFD53ADA800
        public void set_SpinCount(){} // RVA: 0x7FFD53ADA860
        public void get_Waiters(){} // RVA: 0x7FFD53ADA880
        public void set_Waiters(){} // RVA: 0x7FFD53ADA8E0
        public void .ctor(){} // RVA: 0x7FFD53ADAAA0 | overloaded x3
        public void Initialize(){} // RVA: 0x7FFD53ADABA0
        public void EnsureLockObjectCreated(){} // RVA: 0x7FFD53ADAC60
        public void LazyInitializeEvent(){} // RVA: 0x7FFD53ADAD10
        public void Set(){} // RVA: 0x7FFD53ADB020 | overloaded x2
        public void Wait(){} // RVA: 0x7FFD53ADB490 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFD53ADBDF0 | overloaded x2
        public void ThrowIfDisposed(){} // RVA: 0x7FFD53ADBF80
        public void CancellationTokenCallback(){} // RVA: 0x7FFD53ADBFF0
        public void UpdateStateAtomically(){} // RVA: 0x7FFD53ADC1B0
        public void ExtractStatePortionAndShiftRight(){} // RVA: 0x7FFD53ADC290
        public void ExtractStatePortion(){} // RVA: 0x7FFD53ADC2A0
        public void .cctor(){} // RVA: 0x7FFD53ADC2B0
    }

    public class OSSpecificSynchronizationContext : SynchronizationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3A7E80
        public void Get(){} // RVA: 0x7FFD53AEAEF0
        public void CreateCopy(){} // RVA: 0x7FFD53AEB130
        public void Send(){} // RVA: 0x7FFD53AEB1D0
        public void Post(){} // RVA: 0x7FFD53AEB210
        public void InvocationEntry(){} // RVA: 0x7FFD53AEB5B0
        public void GetOSContext(){} // RVA: 0x7FFD53AEB740
        public void PostInternal(){} // RVA: 0x7FFD53AEB7D0
        public void .cctor(){} // RVA: 0x7FFD53AEB8F0
    }

    public class ParameterizedThreadStart : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3C1190
        public void Invoke(){} // RVA: 0x7FFD4E39CC60
    }

    public class PlatformHelper : Object
    {
        public int ProcessorCount;
        public int s_lastProcessorCountRefreshTicks; // 0x4
        public bool IsSingleProcessor; // 0x8

        // ── Methods ──
        public void get_ProcessorCount(){} // RVA: 0x7FFD53ADC750
        public void .cctor(){} // RVA: 0x7FFD53ADC850
    }

    public class QueueUserWorkItemCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AF1590
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFD53AF1730
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFD4E341310
        public void WaitCallback_Context(){} // RVA: 0x7FFD53AF1870
        public void .cctor(){} // RVA: 0x7FFD53AF18F0
    }

    public class SemaphoreSlim : Object
    {
        public int CurrentCount; // 0x10
        public int m_maxCount; // 0x14
        public int m_waitCount; // 0x18
        public object m_lockObj; // 0x20
        public sageKind.tion m_waitHandle; // 0x28
        public object m_asyncHead; // 0x30
        public object m_asyncTail; // 0x38
        public utes.?<bool> s_trueTask;
        public utes.?<bool> s_falseTask; // 0x8
        public int NO_MAXIMUM;
        public ileFullDirectoryInformation<object> s_cancellationTokenCanceledEventHandler; // 0x10

        // ── Methods ──
        public void get_CurrentCount(){} // RVA: 0x7FFD53AE2530
        public void .ctor(){} // RVA: 0x7FFD53AE2550 | overloaded x2
        public void Wait(){} // RVA: 0x7FFD53AE2730 | overloaded x3
        public void WaitUntilCountOrTimeout(){} // RVA: 0x7FFD53AE3020
        public void WaitAsync(){} // RVA: 0x7FFD53AE3160 | overloaded x3
        public void CreateAndAddAsyncWaiter(){} // RVA: 0x7FFD53AE35A0
        public void RemoveAsyncWaiter(){} // RVA: 0x7FFD53AE3810
        public void WaitUntilCountOrTimeoutAsync(){} // RVA: 0x7FFD53AE3A80
        public void Release(){} // RVA: 0x7FFD53AE3D00 | overloaded x2
        public void QueueWaiterTask(){} // RVA: 0x7FFD53AE4080
        public void Dispose(){} // RVA: 0x7FFD53AE4100 | overloaded x2
        public void CancellationTokenCanceledEventHandler(){} // RVA: 0x7FFD53AE42B0
        public void CheckDispose(){} // RVA: 0x7FFD53AE4470
        public void GetResourceString(){} // RVA: 0x7FFD4F9181E0
        public void .cctor(){} // RVA: 0x7FFD53AE4500
    }

    public class SendOrPostCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3C1190
        public void Invoke(){} // RVA: 0x7FFD4E39CC60
    }

    public class SparselyPopulatedArrayAddInfo`1 : ValueType
    {
        public sageKind.Capacity<sageKind.rg_RegSetStrArrNull> Source; // 0x10
        public int Index; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970
        public void get_Source(){} // RVA: 0x7FFD4E078E90
        public void get_Index(){} // RVA: 0x7FFD4E079960
    }

    public class SparselyPopulatedArrayFragment`1 : Object
    {
        public sageKind.rg_RegSetStrArrNull[] Item; // 0x10
        public int Length; // 0x18
        public sageKind.Capacity<sageKind.rg_RegSetStrArrNull> Prev; // 0x20
        public sageKind.Capacity<sageKind.rg_RegSetStrArrNull> _prev; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E092BC0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_Prev(){} // RVA: 0x7FFD4E078E90
        public void SafeAtomicRemove(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SparselyPopulatedArray`1 : Object
    {
        public sageKind.Capacity<T1717586768> Tail;
        public sageKind.Capacity<T1717586768> _tail;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
        public void get_Tail(){} // RVA: 0x7FFD4E078E90
        public void Add(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SpinLock : ValueType
    {
        public int IsHeldByCurrentThread; // 0x10
        public int IsThreadOwnerTrackingEnabled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AE5550
        public void Enter(){} // RVA: 0x7FFD53AE5570
        public void TryEnter(){} // RVA: 0x7FFD53AE5620
        public void ContinueTryEnter(){} // RVA: 0x7FFD53AE56E0
        public void DecrementWaiters(){} // RVA: 0x7FFD53AE5B20
        public void ContinueTryEnterWithThreadTracking(){} // RVA: 0x7FFD53AE5BE0
        public void Exit(){} // RVA: 0x7FFD53AE5E40
        public void ExitSlowPath(){} // RVA: 0x7FFD53AE5EE0
        public void get_IsHeldByCurrentThread(){} // RVA: 0x7FFD53AE6020
        public void get_IsThreadOwnerTrackingEnabled(){} // RVA: 0x7FFD53AE6140
        public void .cctor(){} // RVA: 0x7FFD53AE6150
    }

    public class SpinWait : ValueType
    {
        public int Count;
        public int NextSpinWillYield; // 0x10

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFD4F840210
        public void get_NextSpinWillYield(){} // RVA: 0x7FFD53ADC390
        public void SpinOnce(){} // RVA: 0x7FFD53ADC460 | overloaded x2
        public void SpinOnceCore(){} // RVA: 0x7FFD53ADC560
        public void Reset(){} // RVA: 0x7FFD4FE1C580
        public void .cctor(){} // RVA: 0x7FFD53ADC6C0
    }

    public class SynchronizationContext : Object
    {
        public sageKind.geSize Current; // 0x10
        public object CurrentNoFlow;
        public object CurrentExplicit; // 0x8
        public object s_cachedPreparedType3; // 0x10
        public object s_cachedPreparedType4; // 0x18
        public object s_cachedPreparedType5; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void SetWaitNotificationRequired(){} // RVA: 0x7FFD53AEA520
        public void IsWaitNotificationRequired(){} // RVA: 0x7FFD53AEA8D0
        public void Send(){} // RVA: 0x7FFD5107C990
        public void Post(){} // RVA: 0x7FFD53AEA8E0
        public void OperationStarted(){} // RVA: 0x7FFD4E341310
        public void OperationCompleted(){} // RVA: 0x7FFD4E341310
        public void Wait(){} // RVA: 0x7FFD53AEA970
        public void WaitHelper(){} // RVA: 0x7FFD53AEAA60
        public void SetSynchronizationContext(){} // RVA: 0x7FFD53AEAB00
        public void get_Current(){} // RVA: 0x7FFD53AEABF0
        public void get_CurrentNoFlow(){} // RVA: 0x7FFD53AEACB0
        public void GetThreadLocalContext(){} // RVA: 0x7FFD53AEAD70
        public void CreateCopy(){} // RVA: 0x7FFD53AEADC0
        public void get_CurrentExplicit(){} // RVA: 0x7FFD53AEAE00
    }

    public class Thread : CriticalFinalizerObject
    {
        public D_MNd ExecutionContextBelongsToCurrentScope;
        public ce Priority; // 0xFFFFFFFF
        public 0.T_I8 CurrentUICulture; // 0xFFFFFFFF
        public 0.T_I8 CurrentCulture; // 0xFFFFFFFF
        public sageKind.GCCollectionMode<0.T_I8> Internal; // 0x8
        public sageKind.GCCollectionMode<0.T_I8> CurrentContext; // 0x10
        public sageKind.ffer CurrentThread; // 0x10
        public object CurrentThreadId; // 0x18
        public object IsThreadPoolThread; // 0x20
        public sageKind.nVideos IsThreadPoolThreadInternal; // 0xFFFFFFFF
        public xedBufferExtensions IsAlive; // 0x28
        public sageKind.d IsBackground; // 0x30
        public bool Name; // 0x38
        public Context.chronously ThreadState; // 0x40
        public int ManagedThreadId; // 0x48

        // ── Methods ──
        public void AsyncLocalSetCurrentUICulture(){} // RVA: 0x7FFD53AEBF90
        public void .ctor(){} // RVA: 0x7FFD53AEC1A0 | overloaded x3
        public void Start(){} // RVA: 0x7FFD53AEC3C0 | overloaded x3
        public void GetExecutionContextReader(){} // RVA: 0x7FFD53AEC5C0
        public void get_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x7FFD53AEC620
        public void set_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x7FFD53AEC630
        public void GetMutableExecutionContext(){} // RVA: 0x7FFD53AEC640
        public void SetExecutionContext(){} // RVA: 0x7FFD53AEC770 | overloaded x2
        public void get_Priority(){} // RVA: 0x7FFD53AEC7D0
        public void set_Priority(){} // RVA: 0x7FFD53AEC850
        public void GetPriorityNative(){} // RVA: 0x7FFD53AEC7D0
        public void SetPriorityNative(){} // RVA: 0x7FFD53AEC850
        public void JoinInternal(){} // RVA: 0x7FFD53AEC8E0
        public void Join(){} // RVA: 0x7FFD53AEC9B0
        public void SleepInternal(){} // RVA: 0x7FFD53AECA70
        public void Sleep(){} // RVA: 0x7FFD53AECB00
        public void YieldInternal(){} // RVA: 0x7FFD537DAE60
        public void Yield(){} // RVA: 0x7FFD537DAE60
        public void SetStartHelper(){} // RVA: 0x7FFD53AECC00
        public void get_CurrentUICulture(){} // RVA: 0x7FFD53AECDC0
        public void set_CurrentUICulture(){} // RVA: 0x7FFD53AECE00
        public void GetCurrentUICultureNoAppX(){} // RVA: 0x7FFD53AED1E0
        public void get_CurrentCulture(){} // RVA: 0x7FFD53AED390
        public void GetCurrentCultureNoAppX(){} // RVA: 0x7FFD53AED3D0
        public void nativeInitCultureAccessors(){} // RVA: 0x7FFD53AED540
        public void MemoryBarrier(){} // RVA: 0x7FFD53AED780
        public void ConstructInternalThread(){} // RVA: 0x7FFD53AED790
        public void get_Internal(){} // RVA: 0x7FFD53AED7D0
        public void get_CurrentContext(){} // RVA: 0x7FFD5389E330
        public void GetCurrentThread_icall(){} // RVA: 0x7FFD53AED830
        public void GetCurrentThread(){} // RVA: 0x7FFD53AED8B0
        public void get_CurrentThread(){} // RVA: 0x7FFD53AED940
        public void get_CurrentThreadId(){} // RVA: 0x7FFD53AEDA40
        public void GetDomainID(){} // RVA: 0x7FFD53AB3880
        public void Thread_internal(){} // RVA: 0x7FFD53AEDA70
        public void Finalize(){} // RVA: 0x7FFD53AEDA80
        public void get_IsThreadPoolThread(){} // RVA: 0x7FFD53AEDAC0
        public void get_IsThreadPoolThreadInternal(){} // RVA: 0x7FFD53AEDAC0
        public void get_IsAlive(){} // RVA: 0x7FFD53AEDB20
        public void set_IsBackground(){} // RVA: 0x7FFD53AEDB80
        public void GetName_internal(){} // RVA: 0x7FFD53AEDCF0
        public void SetName_icall(){} // RVA: 0x7FFD53AEDDB0
        public void SetName_internal(){} // RVA: 0x7FFD53AEDDC0
        public void get_Name(){} // RVA: 0x7FFD53AEDDF0
        public void set_Name(){} // RVA: 0x7FFD53AEDEF0
        public void get_ThreadState(){} // RVA: 0x7FFD53AEDF70
        public void Abort_internal(){} // RVA: 0x7FFD53AEDFC0
        public void Abort(){} // RVA: 0x7FFD53AEDFD0
        public void SpinWait_nop(){} // RVA: 0x7FFD4E341310
        public void SpinWait(){} // RVA: 0x7FFD53AEE020
        public void StartInternal(){} // RVA: 0x7FFD53AEE030
        public void SetState(){} // RVA: 0x7FFD53AEE0E0
        public void ClrState(){} // RVA: 0x7FFD53AEE0F0
        public void GetState(){} // RVA: 0x7FFD53AEE100
        public void VolatileRead(){} // RVA: 0x7FFD5007EB10
        public void SystemMaxStackStize(){} // RVA: 0x7FFD537EAF20
        public void GetProcessDefaultStackSize(){} // RVA: 0x7FFD53AEE170
        public void SetStart(){} // RVA: 0x7FFD53AEE1F0
        public void get_ManagedThreadId(){} // RVA: 0x7FFD53AEE2B0
        public void BeginCriticalRegion(){} // RVA: 0x7FFD53AEE310
        public void EndCriticalRegion(){} // RVA: 0x7FFD53AEE390
        public void GetHashCode(){} // RVA: 0x7FFD53AEE2B0
        public void ValidateThreadState(){} // RVA: 0x7FFD53AEE410
    }

    public class ThreadHelper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void SetExecutionContextHelper(){} // RVA: 0x7FFD4E36F0D0
        public void ThreadStart_Context(){} // RVA: 0x7FFD53AEBB00
        public void ThreadStart(){} // RVA: 0x7FFD53AEBDA0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD53AEBEB0
    }

    public class ThreadLocal`1 : Object
    {
        public ormation<T1717586880> Value;
        public ingForUnload<T1717586880>[] IsValueCreated; // 0xFFFFFFFF
        public esting<T1717586880> ts_finalizationHelper; // 0xFFFFFFFF
        public int m_idComplement;
        public bool m_initialized;
        public AssemblyLoad<T1717586880> s_idManager;
        public lizingForUnload<T1717586880> m_linkedSlot;
        public bool m_trackAllValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFD4E096500
        public void Finalize(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E091060 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
        public void set_Value(){} // RVA: 0x7FFD4E2ADC40
        public void GetValueSlow(){} // RVA: 0x7FFD4E2ADC40
        public void SetValueSlow(){} // RVA: 0x7FFD4E2ADC40
        public void CreateLinkedSlot(){} // RVA: 0x7FFD4E2ADC40
        public void get_IsValueCreated(){} // RVA: 0x7FFD4E079D00
        public void GrowTable(){} // RVA: 0x7FFD4E097970
        public void GetNewTableSize(){} // RVA: 0x7FFD4E080110
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ThreadPool : Object
    {
        public object IsThreadPoolThread;

        // ── Methods ──
        public void GetMaxThreads(){} // RVA: 0x7FFD53AF19D0
        public void GetMinThreads(){} // RVA: 0x7FFD53AF1A20
        public void GetAvailableThreads(){} // RVA: 0x7FFD53AF1A70
        public void RegisterWaitForSingleObject(){} // RVA: 0x7FFD53AF1F60 | overloaded x3
        public void QueueUserWorkItem(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void QueueUserWorkItemHelper(){} // RVA: 0x7FFD53AF2340
        public void UnsafeQueueCustomWorkItem(){} // RVA: 0x7FFD53AF26D0
        public void TryPopCustomWorkItem(){} // RVA: 0x7FFD53AF27C0
        public void RequestWorkerThread(){} // RVA: 0x7FFD53AF2900
        public void EnsureVMInitialized(){} // RVA: 0x7FFD53AF2920
        public void GetMinThreadsNative(){} // RVA: 0x7FFD53AF1A20
        public void GetMaxThreadsNative(){} // RVA: 0x7FFD53AF19D0
        public void GetAvailableThreadsNative(){} // RVA: 0x7FFD53AF1A70
        public void NotifyWorkItemComplete(){} // RVA: 0x7FFD53AF29D0
        public void ReportThreadStatus(){} // RVA: 0x7FFD53953400
        public void NotifyWorkItemProgress(){} // RVA: 0x7FFD537EC6B0
        public void NotifyWorkItemProgressNative(){} // RVA: 0x7FFD53AF2A60
        public void NotifyWorkItemQueued(){} // RVA: 0x7FFD4E341310
        public void InitializeVMTp(){} // RVA: 0x7FFD53AF2AC0
        public void get_IsThreadPoolThread(){} // RVA: 0x7FFD53AF2AD0
    }

    public class ThreadPoolGlobals : Object
    {
        public int processorCount;
        public bool vmTpInitialized; // 0x4
        public bool enableWorkerTracking; // 0x5
        public sageKind.? workQueue; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD53AEE590
    }

    public class ThreadPoolWorkQueue : Object
    {
        public lizationHolder queueHead; // 0x10
        public lizationHolder queueTail; // 0x18
        public arg<_method> allThreadQueues;
        public int numOutstandingThreadRequests; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AEE760
        public void EnsureCurrentThreadHasQueue(){} // RVA: 0x7FFD53AEE870
        public void EnsureThreadRequested(){} // RVA: 0x7FFD53AEE9C0
        public void MarkThreadRequestSatisfied(){} // RVA: 0x7FFD53AEEA60
        public void Enqueue(){} // RVA: 0x7FFD53AEEA90
        public void LocalFindAndPop(){} // RVA: 0x7FFD53AEED00
        public void Dequeue(){} // RVA: 0x7FFD53AEEDB0
        public void Dispatch(){} // RVA: 0x7FFD53AEF070
        public void .cctor(){} // RVA: 0x7FFD53AEF630
    }

    public class ThreadPoolWorkQueueThreadLocals : Object
    {
        public sageKind.EmptyArray`1 threadLocals; // 0xFFFFFFFF
        public sageKind.? workQueue; // 0x10
        public _method workStealingQueue; // 0x18
        public object random; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AF1030
        public void CleanUp(){} // RVA: 0x7FFD53AF1320
        public void Finalize(){} // RVA: 0x7FFD53AF14C0
    }

    public class ThreadStart : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E39F980
        public void Invoke(){} // RVA: 0x7FFD4E39FA50
    }

    public class Timeout : Object
    {
        public ializable.GetObjectData InfiniteTimeSpan;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD53AD9AE0
    }

    public class Timer : MarshalByRefObject
    {
        public object scheduler;

        // ── Methods ──
        public void get_scheduler(){} // RVA: 0x7FFD53AF75C0
        public void .ctor(){} // RVA: 0x7FFD53AF7770 | overloaded x3
        public void Init(){} // RVA: 0x7FFD53AF77A0
        public void Change(){} // RVA: 0x7FFD53AF7A10 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFD53AF79D0
        public void DisposeAsync(){} // RVA: 0x7FFD53AF7C80
        public void KeepRootedWhileScheduled(){} // RVA: 0x7FFD4E341310
        public void GetTimeMonotonic(){} // RVA: 0x7FFD53AF7DC0
    }

    public class TimerCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3C1190
        public void Invoke(){} // RVA: 0x7FFD4E39CC60
    }

    public class Volatile : Object
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void Write(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
    }

    public class WaitCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3C1190
        public void Invoke(){} // RVA: 0x7FFD4E39CC60
    }

    public class WaitHandle : MarshalByRefObject
    {
        public int Handle;
        public int SafeWaitHandle;
        public UIntPtr waitHandle; // 0x18
        public 01B30335EAF483F59E5EDCB41DF7C4807E1B.272491DFC646754F4A9D safeWaitHandle; // 0x20
        public bool hasThreadAffinity; // 0x28
        public int WAIT_OBJECT_0;
        public int WAIT_ABANDONED;
        public int WAIT_FAILED;
        public int ERROR_TOO_MANY_POSTS;
        public int ERROR_NOT_OWNED_BY_CALLER;
        public UIntPtr InvalidHandle;
        public int MaxWaitHandles;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AF2B40
        public void Init(){} // RVA: 0x7FFD53AF2B40
        public void get_Handle(){} // RVA: 0x7FFD53AF2C00
        public void set_Handle(){} // RVA: 0x7FFD53AF2C90
        public void get_SafeWaitHandle(){} // RVA: 0x7FFD53AF2E50
        public void SetHandleInternal(){} // RVA: 0x7FFD53AF2FA0
        public void WaitOne(){} // RVA: 0x7FFD53AF31E0 | overloaded x6
        public void InternalWaitOne(){} // RVA: 0x7FFD53AF3340
        public void WaitAny(){} // RVA: 0x7FFD53AF3810 | overloaded x2
        public void ThrowAbandonedMutexException(){} // RVA: 0x7FFD53AF3990 | overloaded x2
        public void Close(){} // RVA: 0x7FFD53AF39F0
        public void Dispose(){} // RVA: 0x7FFD53AF3AB0 | overloaded x2
        public void WaitOneNative(){} // RVA: 0x7FFD53AF3B20
        public void WaitMultiple(){} // RVA: 0x7FFD53AF3D80
        public void Wait_internal(){} // RVA: 0x7FFD53AF4380
        public void .cctor(){} // RVA: 0x7FFD53AF4390
    }

    public class _ThreadPoolWaitCallback : Object
    {
        // ── Methods ──
        public void PerformWaitCallback(){} // RVA: 0x7FFD53AF1540
    }

}