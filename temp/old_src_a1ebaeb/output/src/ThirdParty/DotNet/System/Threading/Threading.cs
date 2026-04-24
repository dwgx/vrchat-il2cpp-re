// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading
// Classes: 49
// Methods: 461

namespace ThirdParty.DotNet.System.Threading
{
    public class AsyncLocalValueChangedArgs`1 : ValueType
    {
        public object _threadContextChanged; // 0x30D40C50, was: <ThreadContextChanged>k__Backi

        // ── Original Methods ──
        public void get_CurrentValue(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
    }

    public class AsyncLocalValueChangedArgs`1 : ValueType
    {
        public object _threadContextChanged; // 0x350D1E08, was: <ThreadContextChanged>k__Backi
    }

    public class AsyncLocalValueChangedArgs`1 : ValueType
    {
    }

    public class AsyncLocal`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void get_Value(){} // RVA: 0x7ffaa887e5c0
        public void set_Value(){} // RVA: 0x7ffaa887e5c0
        public void System.Threading.IAsyncLocal.OnValueChanged(){}
    }

    public class CancellationToken : ValueType
    {
        // ── Original Methods ──
        public void get_None(){} // RVA: 0x7ffaa8f22da0
        public void get_IsCancellationRequested(){} // RVA: 0x7ffaae0dada0
        public void get_CanBeCanceled(){} // RVA: 0x7ffaa95e1360
        public void .ctor(){} // RVA: 0x7ffaae0dadc0
        public void .ctor(){} // RVA: 0x7ffaae0dadc0
        public void Register(){} // RVA: 0x7ffaae0db2f0
        public void Register(){} // RVA: 0x7ffaae0db2f0
        public void Register(){} // RVA: 0x7ffaae0db2f0
        public void Register(){} // RVA: 0x7ffaae0db2f0
        public void InternalRegisterWithoutEC(){} // RVA: 0x7ffaae0db240
        public void Register(){} // RVA: 0x7ffaae0db2f0
        public void Equals(){} // RVA: 0x7ffaae0db450
        public void Equals(){} // RVA: 0x7ffaae0db450
        public void op_Equality(){} // RVA: 0x7ffaae0db570
        public void op_Inequality(){} // RVA: 0x7ffaae0db5d0
        public void ThrowIfCancellationRequested(){} // RVA: 0x7ffaae0db630
        public void ThrowOperationCanceledException(){} // RVA: 0x7ffaae0db6b0
        public void .cctor(){} // RVA: 0x7ffaae0db710
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaae0db4f0
    }

    public class CancellationTokenRegistration : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabb05e50
        public void get_Token(){} // RVA: 0x7ffaae0ddaf0
        public void Unregister(){} // RVA: 0x7ffaae0ddb20
        public void Dispose(){} // RVA: 0x7ffaae0ddbb0
        public void Equals(){} // RVA: 0x7ffaae0dddf0
        public void Equals(){} // RVA: 0x7ffaae0dddf0
        public void DisposeAsync(){} // RVA: 0x7ffaae0ddf00
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaae0dde80
    }

    public class CancellationTokenSource : Object
    {
        public object s_nLists; // 0x33B276D0
        public object CannotBeCanceled; // 0x33B276D0
        public object NotifyingCompleteState; // 0x33B276D0
        public object _disposed; // 0x33B276D0
        public object s_timerCallback; // 0x33B276D0
        public object IsCancellationRequested; // 0x170001D3
        public object IsCancellationCompleted; // 0x170001D4
        public object IsDisposed; // 0x170001D5
        public object ThreadIDExecutingCallbacks; // 0x170001D6
        public object Token; // 0x170001D7

        // ── Original Methods ──
        public void get_IsCancellationRequested(){} // RVA: 0x7ffaae0de030
        public void get_IsCancellationCompleted(){} // RVA: 0x7ffaae0de040
        public void get_IsDisposed(){} // RVA: 0x7ffaa8b0edb0
        public void get_ThreadIDExecutingCallbacks(){} // RVA: 0x7ffaae0de050
        public void set_ThreadIDExecutingCallbacks(){} // RVA: 0x7ffaae0de060
        public void get_Token(){} // RVA: 0x7ffaae0de070
        public void get_ExecutingCallback(){} // RVA: 0x7ffaadf964a0
        public void .ctor(){} // RVA: 0x7ffaae0de230
        public void .ctor(){} // RVA: 0x7ffaae0de230
        public void .ctor(){} // RVA: 0x7ffaae0de230
        public void InitializeWithTimer(){} // RVA: 0x7ffaae0de2b0
        public void Cancel(){} // RVA: 0x7ffaae0de430
        public void Cancel(){} // RVA: 0x7ffaae0de430
        public void CancelAfter(){} // RVA: 0x7ffaae0de580
        public void CancelAfter(){} // RVA: 0x7ffaae0de580
        public void TimerCallbackLogic(){} // RVA: 0x7ffaae0de7b0
        public void Dispose(){} // RVA: 0x7ffaae0de920
        public void Dispose(){} // RVA: 0x7ffaae0de920
        public void ThrowIfDisposed(){} // RVA: 0x7ffaae0dea70
        public void ThrowObjectDisposedException(){} // RVA: 0x7ffaae0deac0
        public void InternalRegister(){} // RVA: 0x7ffaae0deb20
        public void NotifyCancellation(){} // RVA: 0x7ffaae0df0f0
        public void ExecuteCallbackHandlers(){} // RVA: 0x7ffaae0df1b0
        public void CancellationCallbackCoreWork_OnSyncContext(){} // RVA: 0x7ffaae0df660
        public void CancellationCallbackCoreWork(){} // RVA: 0x7ffaae0df6e0
        public void CreateLinkedTokenSource(){} // RVA: 0x7ffaae0dfb10
        public void CreateLinkedTokenSource(){} // RVA: 0x7ffaae0dfb10
        public void CreateLinkedTokenSource(){} // RVA: 0x7ffaae0dfb10
        public void WaitForCallbackToComplete(){} // RVA: 0x7ffaae0dfcb0
        public void .cctor(){} // RVA: 0x7ffaae0dfd80
    }

    public class ContextCallback : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89b2190
        public void Invoke(){} // RVA: 0x7ffaa898dc60
    }

    public class ContextCallback`1 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa8660d80
    }

    public class DeferredDisposableLifetime`1 : ValueType
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void AddRef(){} // RVA: 0x7ffaa887e5c0
        public void Release(){} // RVA: 0x7ffaa887e5c0
        public void Dispose(){} // RVA: 0x7ffaa887e5c0
    }

    public class EventWaitHandle : WaitHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae0e7670
        public void .ctor(){} // RVA: 0x7ffaae0e7670
        public void Reset(){} // RVA: 0x7ffaae0e79f0
        // ── Binary Analysis Named ──
        public void Set(){} // RVA: 0x7ffaae0e7a50
    }

    public class ExecutionContext : Object
    {
        public object _logicalCallContext; // 0x317517E0
        public object _localValues; // 0x317517E0
        public object Default; // 0x317517E0
        public object isNewCapture; // 0x170001E6
        public object isFlowSuppressed; // 0x170001E7
        public object IsPreAllocatedDefault; // 0x170001E8

        // ── Original Methods ──
        public void get_isNewCapture(){} // RVA: 0x7ffaae0e8110
        public void set_isNewCapture(){} // RVA: 0x7ffaae0e8120
        public void get_isFlowSuppressed(){} // RVA: 0x7ffaae0e8140
        public void set_isFlowSuppressed(){} // RVA: 0x7ffaae0e8150
        public void get_IsPreAllocatedDefault(){} // RVA: 0x7ffaae0e8170
        public void .ctor(){} // RVA: 0x7ffaae0ea2c0
        public void .ctor(){} // RVA: 0x7ffaae0ea2c0
        public void OnAsyncLocalContextChanged(){} // RVA: 0x7ffaae0e8610
        public void get_LogicalCallContext(){} // RVA: 0x7ffaae0e8a70
        public void set_LogicalCallContext(){} // RVA: 0x7ffaa89600d0
        public void get_IllogicalCallContext(){} // RVA: 0x7ffaae0e8b10
        public void set_IllogicalCallContext(){} // RVA: 0x7ffaa8933e90
        public void get_SynchronizationContext(){} // RVA: 0x7ffaa894d380
        public void set_SynchronizationContext(){} // RVA: 0x7ffaa8933e30
        public void get_SynchronizationContextNoFlow(){} // RVA: 0x7ffaa89357c0
        public void set_SynchronizationContextNoFlow(){} // RVA: 0x7ffaa8998e80
        public void Dispose(){} // RVA: 0x7ffaa94a7020
        public void Run(){} // RVA: 0x7ffaae0e8cf0
        public void Run(){} // RVA: 0x7ffaae0e8cf0
        public void RunInternal(){} // RVA: 0x7ffaa866b630
        public void RunInternal(){} // RVA: 0x7ffaa866b630
        public void RunInternal(){} // RVA: 0x7ffaa866b630
        public void RunInternal(){} // RVA: 0x7ffaa866b630
        public void EstablishCopyOnWriteScope(){} // RVA: 0x7ffaae0e9080
        public void EstablishCopyOnWriteScope(){} // RVA: 0x7ffaae0e9080
        public void CreateCopy(){} // RVA: 0x7ffaae0e94e0
        public void CreateMutableCopy(){} // RVA: 0x7ffaae0e9730
        public void SuppressFlow(){} // RVA: 0x7ffaae0e9a20
        public void RestoreFlow(){} // RVA: 0x7ffaae0e9b00
        public void IsFlowSuppressed(){} // RVA: 0x7ffaae0e9ba0
        public void Capture(){} // RVA: 0x7ffaae0e9cd0
        public void FastCapture(){} // RVA: 0x7ffaae0e9c80
        public void Capture(){} // RVA: 0x7ffaae0e9cd0
        public void .ctor(){} // RVA: 0x7ffaae0ea2c0
        public void IsDefaultFTContext(){} // RVA: 0x7ffaae0ea490
        public void .cctor(){} // RVA: 0x7ffaae0ea500
        // ── Binary Analysis Named ──
        public void GetLocalValue(){} // RVA: 0x7ffaae0e8190
        public void SetLocalValue(){} // RVA: 0x7ffaae0e8270
        public void SetExecutionContext(){} // RVA: 0x7ffaae0e91c0
        public void GetObjectData(){} // RVA: 0x7ffaae0ea110
    }

    public class IAsyncLocal
    {
        // ── Original Methods ──
        public void OnValueChanged(){}
    }

    public class IThreadPoolWorkItem
    {
        // ── Original Methods ──
        public void ExecuteWorkItem(){} // RVA: 0x7ffaa8660cc0
        public void MarkAborted(){} // RVA: 0x7ffaa8660d80
    }

    public class Interlocked : Object
    {
        // ── Original Methods ──
        public void CompareExchange(){} // RVA: 0x7ffaa887e5c0
        public void CompareExchange(){} // RVA: 0x7ffaa887e5c0
        public void CompareExchange(){} // RVA: 0x7ffaa887e5c0
        public void CompareExchange(){} // RVA: 0x7ffaa887e5c0
        public void CompareExchange(){} // RVA: 0x7ffaa887e5c0
        public void Decrement(){} // RVA: 0x7ffaae0f5700
        public void Increment(){} // RVA: 0x7ffaae0f5720
        public void Increment(){} // RVA: 0x7ffaae0f5720
        public void Exchange(){} // RVA: 0x7ffaa887e5c0
        public void Exchange(){} // RVA: 0x7ffaa887e5c0
        public void Exchange(){} // RVA: 0x7ffaa887e5c0
        public void Exchange(){} // RVA: 0x7ffaa887e5c0
        public void CompareExchange(){} // RVA: 0x7ffaa887e5c0
        public void CompareExchange(){} // RVA: 0x7ffaa887e5c0
        public void CompareExchange(){} // RVA: 0x7ffaa887e5c0
        public void CompareExchange(){} // RVA: 0x7ffaa887e5c0
        public void Exchange(){} // RVA: 0x7ffaa887e5c0
        public void Exchange(){} // RVA: 0x7ffaa887e5c0
        public void Exchange(){} // RVA: 0x7ffaa887e5c0
        public void Exchange(){} // RVA: 0x7ffaa887e5c0
        public void Read(){} // RVA: 0x7ffaae0f5870
        public void Add(){} // RVA: 0x7ffaae0f5890
        public void Add(){} // RVA: 0x7ffaae0f5890
        public void MemoryBarrier(){} // RVA: 0x7ffaae0ee990
    }

    public class InternalThread : CriticalFinalizerObject
    {
        public object native_handle; // 0x3030FD90
        public object name_length; // 0x3030FD90
        public object abort_state_handle; // 0x3030FD90
        public object static_data; // 0x3030FD90
        public object root_domain_thread; // 0x3030FD90
        public object appdomain_refs; // 0x3030FD90
        public object threadpool_thread; // 0x3030FD90
        public object apartment_state; // 0x3030FD90
        public object small_id; // 0x3030FD90
        public object thread_pinning_ref; // 0x3030FD90
        public object owned_mutex; // 0x3030FD90
        public object thread_state; // 0x3030FD90
        public object netcore2; // 0x3030FD90
        public object cache_path; // 0x30316380
        public object license_file; // 0x30316380
        public object shadow_copy_directories; // 0x30316380
        public object path_changed; // 0x30316380
        public object disallow_code_downloads; // 0x30316380

        // ── Original Methods ──
        public void Thread_free_internal(){} // RVA: 0x7ffaae0f8640
        public void Finalize(){} // RVA: 0x7ffaae0f86e0
        public void .ctor(){} // RVA: 0x7ffaae0f87c0
    }

    public class LazyInitializer : Object
    {
        // ── Original Methods ──
        public void EnsureInitialized(){} // RVA: 0x7ffaa887e5c0
        public void EnsureInitializedCore(){} // RVA: 0x7ffaa887e5c0
        public void EnsureInitialized(){} // RVA: 0x7ffaa887e5c0
        public void EnsureInitializedCore(){} // RVA: 0x7ffaa887e5c0
        public void EnsureInitialized(){} // RVA: 0x7ffaa887e5c0
        public void EnsureInitializedCore(){} // RVA: 0x7ffaa887e5c0
        public void EnsureInitialized(){} // RVA: 0x7ffaa887e5c0
        public void EnsureInitializedCore(){} // RVA: 0x7ffaa887e5c0
        public void EnsureLockInitialized(){} // RVA: 0x7ffaae0da9b0
    }

    public class Lock : Object
    {
        // ── Original Methods ──
        public void Acquire(){} // RVA: 0x7ffaae0e3640
        public void Release(){} // RVA: 0x7ffaae0e3680
        public void .ctor(){} // RVA: 0x7ffaae0e36b0
    }

    public class ManualResetEvent : EventWaitHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae0daba0
    }

    public class ManualResetEventSlim : Object
    {
        public object m_eventObj; // 0x34FA1AE0
        public object SignalledState_ShiftCount; // 0x34FA1AE0
        public object SpinCountState_ShiftCount; // 0x34FA1AE0
        public object NumWaitersState_ShiftCount; // 0x34FA1AE0

        // ── Original Methods ──
        public void get_WaitHandle(){} // RVA: 0x7ffaae0db940
        public void get_IsSet(){} // RVA: 0x7ffaae0db980
        public void set_IsSet(){} // RVA: 0x7ffaae0db9e0
        public void get_SpinCount(){} // RVA: 0x7ffaae0dba10
        public void set_SpinCount(){} // RVA: 0x7ffaae0dba70
        public void get_Waiters(){} // RVA: 0x7ffaae0dba90
        public void set_Waiters(){} // RVA: 0x7ffaae0dbaf0
        public void .ctor(){} // RVA: 0x7ffaae0dbcb0
        public void .ctor(){} // RVA: 0x7ffaae0dbcb0
        public void .ctor(){} // RVA: 0x7ffaae0dbcb0
        public void Initialize(){} // RVA: 0x7ffaae0dbdb0
        public void EnsureLockObjectCreated(){} // RVA: 0x7ffaae0dbe70
        public void LazyInitializeEvent(){} // RVA: 0x7ffaae0dbf20
        public void Wait(){} // RVA: 0x7ffaae0dc6a0
        public void Wait(){} // RVA: 0x7ffaae0dc6a0
        public void Wait(){} // RVA: 0x7ffaae0dc6a0
        public void Dispose(){} // RVA: 0x7ffaae0dd000
        public void Dispose(){} // RVA: 0x7ffaae0dd000
        public void ThrowIfDisposed(){} // RVA: 0x7ffaae0dd190
        public void CancellationTokenCallback(){} // RVA: 0x7ffaae0dd200
        public void UpdateStateAtomically(){} // RVA: 0x7ffaae0dd3c0
        public void ExtractStatePortionAndShiftRight(){} // RVA: 0x7ffaae0dd4a0
        public void ExtractStatePortion(){} // RVA: 0x7ffaae0dd4b0
        public void .cctor(){} // RVA: 0x7ffaae0dd4c0
        // ── Binary Analysis Named ──
        public void Set(){} // RVA: 0x7ffaae0dc230
        public void Set(){} // RVA: 0x7ffaae0dc230
    }

    public class OSSpecificSynchronizationContext : SynchronizationContext
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8998e80
        public void CreateCopy(){} // RVA: 0x7ffaae0ec340
        public void Send(){} // RVA: 0x7ffaae0ec3e0
        public void Post(){} // RVA: 0x7ffaae0ec420
        public void InvocationEntry(){} // RVA: 0x7ffaae0ec7c0
        public void PostInternal(){} // RVA: 0x7ffaae0ec9e0
        public void .cctor(){} // RVA: 0x7ffaae0ecb00
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaae0ec100
        public void GetOSContext(){} // RVA: 0x7ffaae0ec950
    }

    public class ParameterizedThreadStart : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89b2190
        public void Invoke(){} // RVA: 0x7ffaa898dc60
    }

    public class PlatformHelper : Object
    {
        public object IsSingleProcessor; // 0x33B27D50
        public object ProcessorCount; // 0x170001D1

        // ── Original Methods ──
        public void get_ProcessorCount(){} // RVA: 0x7ffaae0dd960
        public void .cctor(){} // RVA: 0x7ffaae0dda60
    }

    public class QueueUserWorkItemCallback : Object
    {
        public object state; // 0x35E90E50

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae0f27a0
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7ffaae0f2940
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7ffaa8932310
        public void WaitCallback_Context(){} // RVA: 0x7ffaae0f2a80
        public void .cctor(){} // RVA: 0x7ffaae0f2b00
    }

    public class SemaphoreSlim : Object
    {
        public object m_waitCount; // 0x3520B1B0
        public object m_asyncHead; // 0x3520B1B0
        public object s_falseTask; // 0x3520B1B0
        public object ; // 0x30300020

        // ── Original Methods ──
        public void get_CurrentCount(){} // RVA: 0x7ffaae0e3740
        public void .ctor(){} // RVA: 0x7ffaae0e3760
        public void .ctor(){} // RVA: 0x7ffaae0e3760
        public void Wait(){} // RVA: 0x7ffaae0e3940
        public void Wait(){} // RVA: 0x7ffaae0e3940
        public void Wait(){} // RVA: 0x7ffaae0e3940
        public void WaitUntilCountOrTimeout(){} // RVA: 0x7ffaae0e4230
        public void WaitAsync(){} // RVA: 0x7ffaae0e4370
        public void WaitAsync(){} // RVA: 0x7ffaae0e4370
        public void WaitAsync(){} // RVA: 0x7ffaae0e4370
        public void CreateAndAddAsyncWaiter(){} // RVA: 0x7ffaae0e47b0
        public void RemoveAsyncWaiter(){} // RVA: 0x7ffaae0e4a20
        public void WaitUntilCountOrTimeoutAsync(){} // RVA: 0x7ffaae0e4c90
        public void Release(){} // RVA: 0x7ffaae0e4f10
        public void Release(){} // RVA: 0x7ffaae0e4f10
        public void QueueWaiterTask(){} // RVA: 0x7ffaae0e5290
        public void Dispose(){} // RVA: 0x7ffaae0e5310
        public void Dispose(){} // RVA: 0x7ffaae0e5310
        public void CancellationTokenCanceledEventHandler(){} // RVA: 0x7ffaae0e54c0
        public void .cctor(){} // RVA: 0x7ffaae0e5710
        // ── Binary Analysis Named ──
        public void CheckDispose(){} // RVA: 0x7ffaae0e5680
        public void GetResourceString(){} // RVA: 0x7ffaa9f19100
    }

    public class SendOrPostCallback : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89b2190
        public void Invoke(){} // RVA: 0x7ffaa898dc60
    }

    public class SparselyPopulatedArrayAddInfo`1 : ValueType
    {
        public object _source; // 0x35096CF8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8667cb0
        public void get_Source(){} // RVA: 0x7ffaa86491d0
        public void get_Index(){} // RVA: 0x7ffaa8649ca0
    }

    public class SparselyPopulatedArrayAddInfo`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8d82c00
        public void get_Source(){} // RVA: 0x7ffaa950bda0
        public void get_Index(){} // RVA: 0x7ffaaa3cef80
    }

    public class SparselyPopulatedArrayFragment`1 : Object
    {
        public object _next; // 0x31393950
        public object _freeCount; // 0x350989F8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8662f00
        public void .ctor(){} // RVA: 0x7ffaa8662f00
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void get_Length(){} // RVA: 0x7ffaa8649ca0
        public void get_Prev(){} // RVA: 0x7ffaa86491d0
        public void SafeAtomicRemove(){} // RVA: 0x7ffaa887e5c0
    }

    public class SparselyPopulatedArrayFragment`1 : Object
    {
        public object _next; // 0x350989F8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3a5310
        public void .ctor(){} // RVA: 0x7ffaac3a5310
        public void get_Item(){} // RVA: 0x7ffaac3a5420
        public void get_Length(){} // RVA: 0x7ffaa8f3de30
        public void get_Prev(){} // RVA: 0x7ffaac3a5460
        public void SafeAtomicRemove(){} // RVA: 0x7ffaac3a5470
    }

    public class SparselyPopulatedArray`1 : Object
    {
        public object _head; // 0x81B42888

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void get_Tail(){} // RVA: 0x7ffaa86491d0
        public void Add(){} // RVA: 0x7ffaa887e5c0
    }

    public class SpinLock : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae0e6760
        public void Enter(){} // RVA: 0x7ffaae0e6780
        public void TryEnter(){} // RVA: 0x7ffaae0e6830
        public void ContinueTryEnter(){} // RVA: 0x7ffaae0e68f0
        public void DecrementWaiters(){} // RVA: 0x7ffaae0e6d30
        public void ContinueTryEnterWithThreadTracking(){} // RVA: 0x7ffaae0e6df0
        public void Exit(){} // RVA: 0x7ffaae0e7050
        public void ExitSlowPath(){} // RVA: 0x7ffaae0e70f0
        public void get_IsHeldByCurrentThread(){} // RVA: 0x7ffaae0e7230
        public void get_IsThreadOwnerTrackingEnabled(){} // RVA: 0x7ffaae0e7350
        public void .cctor(){} // RVA: 0x7ffaae0e7360
    }

    public class SpinWait : ValueType
    {
        // ── Original Methods ──
        public void get_Count(){} // RVA: 0x7ffaa9e47550
        public void get_NextSpinWillYield(){} // RVA: 0x7ffaae0dd5a0
        public void SpinOnce(){} // RVA: 0x7ffaae0dd670
        public void SpinOnce(){} // RVA: 0x7ffaae0dd670
        public void SpinOnceCore(){} // RVA: 0x7ffaae0dd770
        public void Reset(){} // RVA: 0x7ffaaa4039b0
        public void .cctor(){} // RVA: 0x7ffaae0dd8d0
    }

    public class SynchronizationContext : Object
    {
        public object s_cachedPreparedType2; // 0x32CE29D0
        public object s_cachedPreparedType5; // 0x32CE29D0
        public object Current; // 0x170001F2
        public object CurrentNoFlow; // 0x170001F3

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void IsWaitNotificationRequired(){} // RVA: 0x7ffaae0ebae0
        public void Send(){} // RVA: 0x7ffaab6649c0
        public void Post(){} // RVA: 0x7ffaae0ebaf0
        public void OperationStarted(){} // RVA: 0x7ffaa8932310
        public void OperationCompleted(){} // RVA: 0x7ffaa8932310
        public void Wait(){} // RVA: 0x7ffaae0ebb80
        public void WaitHelper(){} // RVA: 0x7ffaae0ebc70
        public void get_Current(){} // RVA: 0x7ffaae0ebe00
        public void get_CurrentNoFlow(){} // RVA: 0x7ffaae0ebec0
        public void CreateCopy(){} // RVA: 0x7ffaae0ebfd0
        public void get_CurrentExplicit(){} // RVA: 0x7ffaae0ec010
        // ── Binary Analysis Named ──
        public void SetWaitNotificationRequired(){} // RVA: 0x7ffaae0eb730
        public void SetSynchronizationContext(){} // RVA: 0x7ffaae0ebd10
        public void GetThreadLocalContext(){} // RVA: 0x7ffaae0ebf80
    }

    public class Thread : CriticalFinalizerObject
    {
        public object m_CurrentCulture; // 0x3030FA90
        public object s_asyncLocalCurrentUICulture; // 0x3030FA90
        public object pending_exception; // 0x3030FA90
        public object m_ExecutionContext; // 0x3030FA90
        public object principal_version; // 0x3030FA90
        public object ExecutionContextBelongsToCurrentScope; // 0x170001F5
        public object Priority; // 0x170001F6
        public object CurrentUICulture; // 0x170001F7
        public object CurrentCulture; // 0x170001F8
        public object Internal; // 0x170001F9

        // ── Original Methods ──
        public void AsyncLocalSetCurrentUICulture(){} // RVA: 0x7ffaae0ed1a0
        public void .ctor(){} // RVA: 0x7ffaae0ed3b0
        public void .ctor(){} // RVA: 0x7ffaae0ed3b0
        public void .ctor(){} // RVA: 0x7ffaae0ed3b0
        public void Start(){} // RVA: 0x7ffaae0ed5d0
        public void Start(){} // RVA: 0x7ffaae0ed5d0
        public void Start(){} // RVA: 0x7ffaae0ed5d0
        public void get_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x7ffaae0ed830
        public void set_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x7ffaae0ed840
        public void get_Priority(){} // RVA: 0x7ffaae0ed9e0
        public void set_Priority(){} // RVA: 0x7ffaae0eda60
        public void JoinInternal(){} // RVA: 0x7ffaae0edaf0
        public void Join(){} // RVA: 0x7ffaae0edbc0
        public void SleepInternal(){} // RVA: 0x7ffaae0edc80
        public void Sleep(){} // RVA: 0x7ffaae0edd10
        public void YieldInternal(){} // RVA: 0x7ffaadddc010
        public void Yield(){} // RVA: 0x7ffaadddc010
        public void get_CurrentUICulture(){} // RVA: 0x7ffaae0edfd0
        public void set_CurrentUICulture(){} // RVA: 0x7ffaae0ee010
        public void get_CurrentCulture(){} // RVA: 0x7ffaae0ee5a0
        public void nativeInitCultureAccessors(){} // RVA: 0x7ffaae0ee750
        public void MemoryBarrier(){} // RVA: 0x7ffaae0ee990
        public void ConstructInternalThread(){} // RVA: 0x7ffaae0ee9a0
        public void get_Internal(){} // RVA: 0x7ffaae0ee9e0
        public void get_CurrentContext(){} // RVA: 0x7ffaade9f4e0
        public void get_CurrentThread(){} // RVA: 0x7ffaae0eeb50
        public void get_CurrentThreadId(){} // RVA: 0x7ffaae0eec50
        public void Thread_internal(){} // RVA: 0x7ffaae0eec80
        public void Finalize(){} // RVA: 0x7ffaae0eec90
        public void get_IsThreadPoolThread(){} // RVA: 0x7ffaae0eecd0
        public void get_IsThreadPoolThreadInternal(){} // RVA: 0x7ffaae0eecd0
        public void get_IsAlive(){} // RVA: 0x7ffaae0eed30
        public void set_IsBackground(){} // RVA: 0x7ffaae0eed90
        public void get_Name(){} // RVA: 0x7ffaae0ef000
        public void set_Name(){} // RVA: 0x7ffaae0ef100
        public void get_ThreadState(){} // RVA: 0x7ffaae0ef180
        public void Abort_internal(){} // RVA: 0x7ffaae0ef1d0
        public void Abort(){} // RVA: 0x7ffaae0ef1e0
        public void SpinWait_nop(){} // RVA: 0x7ffaa8932310
        public void SpinWait(){} // RVA: 0x7ffaae0ef230
        public void StartInternal(){} // RVA: 0x7ffaae0ef240
        public void ClrState(){} // RVA: 0x7ffaae0ef300
        public void VolatileRead(){} // RVA: 0x7ffaaa660b50
        public void SystemMaxStackStize(){} // RVA: 0x7ffaaddec0d0
        public void get_ManagedThreadId(){} // RVA: 0x7ffaae0ef4c0
        public void EndCriticalRegion(){} // RVA: 0x7ffaae0ef5a0
        public void ValidateThreadState(){} // RVA: 0x7ffaae0ef620
        // ── Binary Analysis Named ──
        public void GetExecutionContextReader(){} // RVA: 0x7ffaae0ed7d0
        public void GetMutableExecutionContext(){} // RVA: 0x7ffaae0ed850
        public void SetExecutionContext(){} // RVA: 0x7ffaae0ed980
        public void SetExecutionContext(){} // RVA: 0x7ffaae0ed980
        public void GetPriorityNative(){} // RVA: 0x7ffaae0ed9e0
        public void SetPriorityNative(){} // RVA: 0x7ffaae0eda60
        public void SetStartHelper(){} // RVA: 0x7ffaae0ede10
        public void GetCurrentUICultureNoAppX(){} // RVA: 0x7ffaae0ee3f0
        public void GetCurrentCultureNoAppX(){} // RVA: 0x7ffaae0ee5e0
        public void GetCurrentThread_icall(){} // RVA: 0x7ffaae0eea40
        public void GetCurrentThread(){} // RVA: 0x7ffaae0eeac0
        public void GetDomainID(){} // RVA: 0x7ffaae0b4a90
        public void GetName_internal(){} // RVA: 0x7ffaae0eef00
        public void SetName_icall(){} // RVA: 0x7ffaae0eefc0
        public void SetName_internal(){} // RVA: 0x7ffaae0eefd0
        public void SetState(){} // RVA: 0x7ffaae0ef2f0
        public void GetState(){} // RVA: 0x7ffaae0ef310
        public void GetProcessDefaultStackSize(){} // RVA: 0x7ffaae0ef380
        public void SetStart(){} // RVA: 0x7ffaae0ef400
        public void BeginCriticalRegion(){} // RVA: 0x7ffaae0ef520
        public void GetHashCode(){} // RVA: 0x7ffaae0ef4c0
    }

    public class ThreadHelper : Object
    {
        public object _executionContext; // 0x35F7A140
        public object h	00; // 0x35ECA6F0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void ThreadStart_Context(){} // RVA: 0x7ffaae0ecd10
        public void ThreadStart(){} // RVA: 0x7ffaae0ecfb0
        public void ThreadStart(){} // RVA: 0x7ffaae0ecfb0
        public void .cctor(){} // RVA: 0x7ffaae0ed0c0
        // ── Binary Analysis Named ──
        public void SetExecutionContextHelper(){} // RVA: 0x7ffaa89600d0
    }

    public class ThreadLocal`1 : Object
    {
        public object ts_finalizationHelper; // 0x30FBD0F0
        public object s_idManager; // 0x30FBD0F0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Initialize(){} // RVA: 0x7ffaa8666840
        public void Finalize(){} // RVA: 0x7ffaa8660cc0
        public void Dispose(){} // RVA: 0x7ffaa86613a0
        public void Dispose(){} // RVA: 0x7ffaa86613a0
        public void ToString(){} // RVA: 0x7ffaa86491d0
        public void get_Value(){} // RVA: 0x7ffaa887e5c0
        public void set_Value(){} // RVA: 0x7ffaa887e5c0
        public void CreateLinkedSlot(){} // RVA: 0x7ffaa887e5c0
        public void get_IsValueCreated(){} // RVA: 0x7ffaa864a040
        public void GrowTable(){} // RVA: 0x7ffaa8667cb0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetValueSlow(){} // RVA: 0x7ffaa887e5c0
        public void SetValueSlow(){} // RVA: 0x7ffaa887e5c0
        public void GetNewTableSize(){} // RVA: 0x7ffaa8650450
    }

    public class ThreadPool : Object
    {
        // ── Original Methods ──
        public void RegisterWaitForSingleObject(){} // RVA: 0x7ffaae0f3170
        public void RegisterWaitForSingleObject(){} // RVA: 0x7ffaae0f3170
        public void RegisterWaitForSingleObject(){} // RVA: 0x7ffaae0f3170
        public void QueueUserWorkItem(){} // RVA: 0x7ffaa887e5c0
        public void QueueUserWorkItem(){} // RVA: 0x7ffaa887e5c0
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7ffaa887e5c0
        public void QueueUserWorkItem(){} // RVA: 0x7ffaa887e5c0
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7ffaa887e5c0
        public void QueueUserWorkItemHelper(){} // RVA: 0x7ffaae0f3550
        public void UnsafeQueueCustomWorkItem(){} // RVA: 0x7ffaae0f38e0
        public void TryPopCustomWorkItem(){} // RVA: 0x7ffaae0f39d0
        public void RequestWorkerThread(){} // RVA: 0x7ffaae0f3b10
        public void EnsureVMInitialized(){} // RVA: 0x7ffaae0f3b30
        public void NotifyWorkItemComplete(){} // RVA: 0x7ffaae0f3be0
        public void ReportThreadStatus(){} // RVA: 0x7ffaadf54650
        public void NotifyWorkItemProgress(){} // RVA: 0x7ffaadded860
        public void NotifyWorkItemProgressNative(){} // RVA: 0x7ffaae0f3c70
        public void NotifyWorkItemQueued(){} // RVA: 0x7ffaa8932310
        public void InitializeVMTp(){} // RVA: 0x7ffaae0f3cd0
        public void get_IsThreadPoolThread(){} // RVA: 0x7ffaae0f3ce0
        // ── Binary Analysis Named ──
        public void GetMaxThreads(){} // RVA: 0x7ffaae0f2be0
        public void GetMinThreads(){} // RVA: 0x7ffaae0f2c30
        public void GetAvailableThreads(){} // RVA: 0x7ffaae0f2c80
        public void GetMinThreadsNative(){} // RVA: 0x7ffaae0f2c30
        public void GetMaxThreadsNative(){} // RVA: 0x7ffaae0f2be0
        public void GetAvailableThreadsNative(){} // RVA: 0x7ffaae0f2c80
    }

    public class ThreadPoolGlobals : Object
    {
        public object enableWorkerTracking; // 0x3509D290

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaae0ef7a0
    }

    public class ThreadPoolWorkQueue : Object
    {
        public object allThreadQueues; // 0x31393650

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae0ef970
        public void EnsureCurrentThreadHasQueue(){} // RVA: 0x7ffaae0efa80
        public void EnsureThreadRequested(){} // RVA: 0x7ffaae0efbd0
        public void MarkThreadRequestSatisfied(){} // RVA: 0x7ffaae0efc70
        public void Enqueue(){} // RVA: 0x7ffaae0efca0
        public void LocalFindAndPop(){} // RVA: 0x7ffaae0eff10
        public void Dequeue(){} // RVA: 0x7ffaae0effc0
        public void Dispatch(){} // RVA: 0x7ffaae0f0280
        public void .cctor(){} // RVA: 0x7ffaae0f0840
    }

    public class ThreadPoolWorkQueueThreadLocals : Object
    {
        public object workStealingQueue; // 0x3509DA10

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae0f2240
        public void CleanUp(){} // RVA: 0x7ffaae0f2530
        public void Finalize(){} // RVA: 0x7ffaae0f26d0
    }

    public class ThreadStart : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8990980
        public void Invoke(){} // RVA: 0x7ffaa8990a50
    }

    public class Timeout : Object
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaae0dacf0
    }

    public class Timer : MarshalByRefObject
    {
        public object due_time_ms; // 0x35F79810
        public object disposed; // 0x35F79810
        public object MaxValue; // 0x35F79810
        public object scheduler; // 0x1700020B

        // ── Original Methods ──
        public void get_scheduler(){} // RVA: 0x7ffaae0f87d0
        public void .ctor(){} // RVA: 0x7ffaae0f8980
        public void .ctor(){} // RVA: 0x7ffaae0f8980
        public void .ctor(){} // RVA: 0x7ffaae0f8980
        public void Init(){} // RVA: 0x7ffaae0f89b0
        public void Change(){} // RVA: 0x7ffaae0f8c20
        public void Change(){} // RVA: 0x7ffaae0f8c20
        public void Dispose(){} // RVA: 0x7ffaae0f8be0
        public void Change(){} // RVA: 0x7ffaae0f8c20
        public void DisposeAsync(){} // RVA: 0x7ffaae0f8e90
        public void KeepRootedWhileScheduled(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetTimeMonotonic(){} // RVA: 0x7ffaae0f8fd0
    }

    public class TimerCallback : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89b2190
        public void Invoke(){} // RVA: 0x7ffaa898dc60
    }

    public class Volatile : Object
    {
        // ── Original Methods ──
        public void Read(){} // RVA: 0x7ffaa887e5c0
        public void Write(){} // RVA: 0x7ffaa887e5c0
        public void Read(){} // RVA: 0x7ffaa887e5c0
        public void Write(){} // RVA: 0x7ffaa887e5c0
        public void Read(){} // RVA: 0x7ffaa887e5c0
        public void Read(){} // RVA: 0x7ffaa887e5c0
        public void Write(){} // RVA: 0x7ffaa887e5c0
    }

    public class WaitCallback : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89b2190
        public void Invoke(){} // RVA: 0x7ffaa898dc60
    }

    public class WaitHandle : MarshalByRefObject
    {
        public object waitHandle; // 0x3030E9C0
        public object WAIT_OBJECT_0; // 0x3030E9C0
        public object ERROR_TOO_MANY_POSTS; // 0x3030E9C0
        public object MaxWaitHandles; // 0x3030E9C0
        public object Handle; // 0x17000206
        public object SafeWaitHandle; // 0x17000207

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae0f3d50
        public void Init(){} // RVA: 0x7ffaae0f3d50
        public void get_Handle(){} // RVA: 0x7ffaae0f3e10
        public void set_Handle(){} // RVA: 0x7ffaae0f3ea0
        public void get_SafeWaitHandle(){} // RVA: 0x7ffaae0f4060
        public void WaitOne(){} // RVA: 0x7ffaae0f43f0
        public void WaitOne(){} // RVA: 0x7ffaae0f43f0
        public void WaitOne(){} // RVA: 0x7ffaae0f43f0
        public void WaitOne(){} // RVA: 0x7ffaae0f43f0
        public void WaitOne(){} // RVA: 0x7ffaae0f43f0
        public void WaitOne(){} // RVA: 0x7ffaae0f43f0
        public void InternalWaitOne(){} // RVA: 0x7ffaae0f4550
        public void WaitAny(){} // RVA: 0x7ffaae0f4a20
        public void WaitAny(){} // RVA: 0x7ffaae0f4a20
        public void ThrowAbandonedMutexException(){} // RVA: 0x7ffaae0f4ba0
        public void ThrowAbandonedMutexException(){} // RVA: 0x7ffaae0f4ba0
        public void Close(){} // RVA: 0x7ffaae0f4c00
        public void Dispose(){} // RVA: 0x7ffaae0f4cc0
        public void Dispose(){} // RVA: 0x7ffaae0f4cc0
        public void WaitOneNative(){} // RVA: 0x7ffaae0f4d30
        public void WaitMultiple(){} // RVA: 0x7ffaae0f4f90
        public void Wait_internal(){} // RVA: 0x7ffaae0f5590
        public void .cctor(){} // RVA: 0x7ffaae0f55a0
        // ── Binary Analysis Named ──
        public void SetHandleInternal(){} // RVA: 0x7ffaae0f41b0
    }

    public class _ThreadPoolWaitCallback : Object
    {
        // ── Original Methods ──
        public void PerformWaitCallback(){} // RVA: 0x7ffaae0f2750
    }

}