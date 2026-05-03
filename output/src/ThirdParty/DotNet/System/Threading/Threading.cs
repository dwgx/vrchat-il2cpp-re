// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading
// Classes: 77
// Methods: 634

namespace ThirdParty.DotNet.System.Threading
{
    public class AbandonedMutexException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A62DE0 | overloaded x3
        public void SetupException(){} // RVA: 0x7FFE86A62E70
    }

    public class AsyncFlowControl : ValueType
    {
        // ── Methods ──
        public void Setup(){} // RVA: 0x7FFE86A70200
        public void Dispose(){} // RVA: 0x7FFE86A70300
        public void Undo(){} // RVA: 0x7FFE86A70310
        public void GetHashCode(){} // RVA: 0x7FFE86A70510
        public void Equals(){} // RVA: 0x7FFE86A70670 | overloaded x2
    }

    public class AsyncLocalValueChangedArgs`1 : ValueType
    {
        public T _previousValue;

        // ── Methods ──
        public void get_CurrentValue(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810A1420
    }

    public class AsyncLocal`1 : Object
    {
        public System.Action`1<System.Threading.AsyncLocalValueChangedArgs`1<T>> m_valueChangedHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFE810A1420
        public void set_Value(){} // RVA: 0x7FFE810A1420
        public void System.Threading.IAsyncLocal.OnValueChanged(){}
    }

    public class AutoResetEvent : EventWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A62F30
    }

    public class CancellationCallbackCoreWorkArguments : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815AE520
    }

    public class CancellationCallbackInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81143A50
        public void ExecuteCallback(){} // RVA: 0x7FFE86A68F30
        public void ExecutionContextCallback(){} // RVA: 0x7FFE86A690F0
    }

    public class CancellationToken : ValueType
    {
        public System.Threading.CancellationTokenSource _source; // 0x10
        public System.Action`1<object> s_actionToActionObjShunt;
        public object field_2; // 0x82

        // ── Methods ──
        public void get_None(){} // RVA: 0x7FFE813240E0
        public void get_IsCancellationRequested(){} // RVA: 0x7FFE86A63340
        public void get_CanBeCanceled(){} // RVA: 0x7FFE81E76100
        public void .ctor(){} // RVA: 0x7FFE86A63360 | overloaded x2
        public void Register(){} // RVA: 0x7FFE86A63890 | overloaded x5
        public void InternalRegisterWithoutEC(){} // RVA: 0x7FFE86A637E0
        public void Equals(){} // RVA: 0x7FFE86A639F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86A63A90
        public void op_Equality(){} // RVA: 0x7FFE86A63B10
        public void op_Inequality(){} // RVA: 0x7FFE86A63B70
        public void ThrowIfCancellationRequested(){} // RVA: 0x7FFE86A63BD0
        public void ThrowOperationCanceledException(){} // RVA: 0x7FFE86A63C50
        public void .cctor(){} // RVA: 0x7FFE86A63CB0
    }

    public class CancellationTokenRegistration : ValueType
    {
        public System.Threading.CancellationCallbackInfo m_callbackInfo; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84459A90
        public void get_Token(){} // RVA: 0x7FFE86A66090
        public void Unregister(){} // RVA: 0x7FFE86A660C0
        public void Dispose(){} // RVA: 0x7FFE86A66150
        public void Equals(){} // RVA: 0x7FFE86A66390 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86A66420
        public void DisposeAsync(){} // RVA: 0x7FFE86A664A0
    }

    public class CancellationTokenSource : Object
    {
        public System.Threading.CancellationTokenSource s_canceledSource;
        public System.Threading.CancellationTokenSource s_neverCanceledSource; // 0x8
        public int s_nLists; // 0x10
        public System.Threading.ManualResetEvent _kernelEvent; // 0x10
        public System.Threading.SparselyPopulatedArray`1<System.Threading.CancellationCallbackInfo>[] _registeredCallbacksLists; // 0x18
        public int CannotBeCanceled;

        // ── Methods ──
        public void get_IsCancellationRequested(){} // RVA: 0x7FFE86A665D0
        public void get_IsCancellationCompleted(){} // RVA: 0x7FFE86A665E0
        public void get_IsDisposed(){} // RVA: 0x7FFE815F1380
        public void get_ThreadIDExecutingCallbacks(){} // RVA: 0x7FFE86A665F0
        public void set_ThreadIDExecutingCallbacks(){} // RVA: 0x7FFE86A66600
        public void get_Token(){} // RVA: 0x7FFE86A66610
        public void get_ExecutingCallback(){} // RVA: 0x7FFE8691EA90
        public void .ctor(){} // RVA: 0x7FFE86A667D0 | overloaded x3
        public void InitializeWithTimer(){} // RVA: 0x7FFE86A66850
        public void Cancel(){} // RVA: 0x7FFE86A669D0 | overloaded x2
        public void CancelAfter(){} // RVA: 0x7FFE86A66B20 | overloaded x2
        public void TimerCallbackLogic(){} // RVA: 0x7FFE86A66D50
        public void Dispose(){} // RVA: 0x7FFE86A66EC0 | overloaded x2
        public void ThrowIfDisposed(){} // RVA: 0x7FFE86A67010
        public void ThrowObjectDisposedException(){} // RVA: 0x7FFE86A67060
        public void InternalRegister(){} // RVA: 0x7FFE86A670C0
        public void NotifyCancellation(){} // RVA: 0x7FFE86A67690
        public void ExecuteCallbackHandlers(){} // RVA: 0x7FFE86A67750
        public void CancellationCallbackCoreWork_OnSyncContext(){} // RVA: 0x7FFE86A67C00
        public void CancellationCallbackCoreWork(){} // RVA: 0x7FFE86A67C80
        public void CreateLinkedTokenSource(){} // RVA: 0x7FFE86A680B0 | overloaded x3
        public void WaitForCallbackToComplete(){} // RVA: 0x7FFE86A68250
        public void .cctor(){} // RVA: 0x7FFE86A68320
    }

    public class ContextCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class ContextCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE80E460A0
    }

    public class DeferredDisposableLifetime`1 : ValueType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void AddRef(){} // RVA: 0x7FFE810A1420
        public void Release(){} // RVA: 0x7FFE810A1420
        public void Dispose(){} // RVA: 0x7FFE810A1420
    }

    public class EventWaitHandle : WaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A6FC10 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE86A6FF90
        public void Set(){} // RVA: 0x7FFE86A6FFF0
    }

    public class ExecutionContext : Object
    {
        public System.Threading.SynchronizationContext _syncContext; // 0x10
        public System.Threading.SynchronizationContext _syncContextNoFlow; // 0x18
        public System.Runtime.Remoting.Messaging.LogicalCallContext _logicalCallContext; // 0x20
        public System.Runtime.Remoting.Messaging.IllogicalCallContext _illogicalCallContext; // 0x28
        public 0x664BF8FC _flags; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Threading.IAsyncLocal,object> _localValues; // 0x38
        public System.Collections.Generic.List`1<System.Threading.IAsyncLocal> _localChangeNotifications; // 0x40

        // ── Methods ──
        public void get_isNewCapture(){} // RVA: 0x7FFE86A706B0
        public void set_isNewCapture(){} // RVA: 0x7FFE86A706C0
        public void get_isFlowSuppressed(){} // RVA: 0x7FFE86A706E0
        public void set_isFlowSuppressed(){} // RVA: 0x7FFE86A706F0
        public void get_IsPreAllocatedDefault(){} // RVA: 0x7FFE86A70710
        public void .ctor(){} // RVA: 0x7FFE86A72860 | overloaded x3
        public void GetLocalValue(){} // RVA: 0x7FFE86A70730
        public void SetLocalValue(){} // RVA: 0x7FFE86A70810
        public void OnAsyncLocalContextChanged(){} // RVA: 0x7FFE86A70BB0
        public void get_LogicalCallContext(){} // RVA: 0x7FFE86A71010
        public void set_LogicalCallContext(){} // RVA: 0x7FFE811290D0
        public void get_IllogicalCallContext(){} // RVA: 0x7FFE86A710B0
        public void set_IllogicalCallContext(){} // RVA: 0x7FFE810FCE90
        public void get_SynchronizationContext(){} // RVA: 0x7FFE81116380
        public void set_SynchronizationContext(){} // RVA: 0x7FFE810FCE30
        public void get_SynchronizationContextNoFlow(){} // RVA: 0x7FFE810FE7C0
        public void set_SynchronizationContextNoFlow(){} // RVA: 0x7FFE81161E80
        public void Dispose(){} // RVA: 0x7FFE81D95990
        public void Run(){} // RVA: 0x7FFE86A71290 | overloaded x2
        public void RunInternal(){} // RVA: 0x7FFE80E509F0 | overloaded x4
        public void EstablishCopyOnWriteScope(){} // RVA: 0x7FFE86A71620 | overloaded x2
        public void SetExecutionContext(){} // RVA: 0x7FFE86A71760
        public void CreateCopy(){} // RVA: 0x7FFE86A71A80
        public void CreateMutableCopy(){} // RVA: 0x7FFE86A71CD0
        public void SuppressFlow(){} // RVA: 0x7FFE86A71FC0
        public void RestoreFlow(){} // RVA: 0x7FFE86A720A0
        public void IsFlowSuppressed(){} // RVA: 0x7FFE86A72140
        public void Capture(){} // RVA: 0x7FFE86A72270 | overloaded x2
        public void FastCapture(){} // RVA: 0x7FFE86A72220
        public void GetObjectData(){} // RVA: 0x7FFE86A726B0
        public void IsDefaultFTContext(){} // RVA: 0x7FFE86A72A30
        public void .cctor(){} // RVA: 0x7FFE86A72AA0
    }

    public class ExecutionContextSwitcher : ValueType
    {
        // ── Methods ──
        public void UndoNoThrow(){} // RVA: 0x7FFE86A70050
        public void Undo(){} // RVA: 0x7FFE86A70070
    }

    public class IAsyncLocal
    {
        // ── Methods ──
        public void OnValueChanged(){}
    }

    public class IDeferredDisposable
    {
        // ── Methods ──
        public void OnFinalRelease(){} // RVA: 0x7FFE80E466C0
    }

    public class IOCompletionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE844210E0
        public void Invoke(){} // RVA: 0x7FFE812574E0
    }

    public class IThreadPoolWorkItem
    {
        // ── Methods ──
        public void ExecuteWorkItem(){} // RVA: 0x7FFE80E45FE0
        public void MarkAborted(){} // RVA: 0x7FFE80E460A0
    }

    public class Interlocked : Object
    {
        // ── Methods ──
        public void CompareExchange(){} // RVA: 0x7FFE810A1420 | overloaded x9
        public void Decrement(){} // RVA: 0x7FFE86A7DCA0
        public void Increment(){} // RVA: 0x7FFE86A7DCC0 | overloaded x2
        public void Exchange(){} // RVA: 0x7FFE810A1420 | overloaded x8
        public void Read(){} // RVA: 0x7FFE86A7DE10
        public void Add(){} // RVA: 0x7FFE86A7DE30 | overloaded x2
        public void MemoryBarrier(){} // RVA: 0x7FFE86A76F30
    }

    public class InternalThread : CriticalFinalizerObject
    {
        // ── Methods ──
        public void Thread_free_internal(){} // RVA: 0x7FFE86A80BE0
        public void Finalize(){} // RVA: 0x7FFE86A80C80
        public void .ctor(){} // RVA: 0x7FFE86A80D60
    }

    public class LazyInitializer : Object
    {
        // ── Methods ──
        public void EnsureInitialized(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void EnsureInitializedCore(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void EnsureLockInitialized(){} // RVA: 0x7FFE86A62F50
    }

    public class Lock : Object
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFE86A6BBE0
        public void Release(){} // RVA: 0x7FFE86A6BC20
        public void .ctor(){} // RVA: 0x7FFE86A6BC50
    }

    public class LockHolder : ValueType
    {
        // ── Methods ──
        public void Hold(){} // RVA: 0x7FFE86A69210
        public void Dispose(){} // RVA: 0x7FFE86A692B0
    }

    public class LockQueue : Object
    {
        public System.Threading.ReaderWriterLock rwlock; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Wait(){} // RVA: 0x7FFE86A7DE40
        public void get_IsEmpty(){} // RVA: 0x7FFE86A7E090
        public void Pulse(){} // RVA: 0x7FFE86A7E1D0
    }

    public class LockRecursionException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A630C0 | overloaded x3
    }

    public class ManualResetEvent : EventWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A63140
    }

    public class ManualResetEventSlim : Object
    {
        public int DEFAULT_SPIN_SP;
        public object m_lock; // 0x10
        public System.Threading.ManualResetEvent m_eventObj; // 0x18
        public int m_combinedState; // 0x20

        // ── Methods ──
        public void get_WaitHandle(){} // RVA: 0x7FFE86A63EE0
        public void get_IsSet(){} // RVA: 0x7FFE86A63F20
        public void set_IsSet(){} // RVA: 0x7FFE86A63F80
        public void get_SpinCount(){} // RVA: 0x7FFE86A63FB0
        public void set_SpinCount(){} // RVA: 0x7FFE86A64010
        public void get_Waiters(){} // RVA: 0x7FFE86A64030
        public void set_Waiters(){} // RVA: 0x7FFE86A64090
        public void .ctor(){} // RVA: 0x7FFE86A64250 | overloaded x3
        public void Initialize(){} // RVA: 0x7FFE86A64350
        public void EnsureLockObjectCreated(){} // RVA: 0x7FFE86A64410
        public void LazyInitializeEvent(){} // RVA: 0x7FFE86A644C0
        public void Set(){} // RVA: 0x7FFE86A647D0 | overloaded x2
        public void Wait(){} // RVA: 0x7FFE86A64C40 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFE86A655A0 | overloaded x2
        public void ThrowIfDisposed(){} // RVA: 0x7FFE86A65730
        public void CancellationTokenCallback(){} // RVA: 0x7FFE86A657A0
        public void UpdateStateAtomically(){} // RVA: 0x7FFE86A65960
        public void ExtractStatePortionAndShiftRight(){} // RVA: 0x7FFE86A65A40
        public void ExtractStatePortion(){} // RVA: 0x7FFE86A65A50
        public void .cctor(){} // RVA: 0x7FFE86A65A60
    }

    public class Monitor : Object
    {
        // ── Methods ──
        public void Enter(){} // RVA: 0x7FFE86A72DA0 | overloaded x2
        public void ThrowLockTakenException(){} // RVA: 0x7FFE86A72E20
        public void Exit(){} // RVA: 0x7FFE86A72E90
        public void TryEnter(){} // RVA: 0x7FFE86A732F0 | overloaded x5
        public void MillisecondsTimeoutFromTimeSpan(){} // RVA: 0x7FFE86A73060
        public void IsEntered(){} // RVA: 0x7FFE86A733B0
        public void Wait(){} // RVA: 0x7FFE86A73430 | overloaded x2
        public void Pulse(){} // RVA: 0x7FFE86A73550
        public void PulseAll(){} // RVA: 0x7FFE86A73620
        public void Monitor_test_synchronised(){} // RVA: 0x7FFE86A73730
        public void Monitor_pulse(){} // RVA: 0x7FFE86A73780
        public void ObjPulse(){} // RVA: 0x7FFE86A737B0
        public void Monitor_pulse_all(){} // RVA: 0x7FFE86A73850
        public void ObjPulseAll(){} // RVA: 0x7FFE86A738C0
        public void Monitor_wait(){} // RVA: 0x7FFE86A739A0
        public void ObjWait(){} // RVA: 0x7FFE86A739D0
        public void try_enter_with_atomic_var(){} // RVA: 0x7FFE86A73AC0
        public void ReliableEnterTimeout(){} // RVA: 0x7FFE86A73B00
        public void ReliableEnter(){} // RVA: 0x7FFE86A73BE0
        public void Monitor_test_owner(){} // RVA: 0x7FFE86A73C70
        public void IsEnteredNative(){} // RVA: 0x7FFE86A73C70
    }

    public class Mutex : WaitHandle
    {
        // ── Methods ──
        public void ReleaseMutex_internal(){} // RVA: 0x7FFE86A7E3C0
        public void .ctor(){} // RVA: 0x7FFE86A7E3E0
        public void ReleaseMutex(){} // RVA: 0x7FFE86A7E440
    }

    public class NativeEventCalls : Object
    {
        // ── Methods ──
        public void CreateEvent_internal(){} // RVA: 0x7FFE86A7E470
        public void CreateEvent_icall(){} // RVA: 0x7FFE86A7E500
        public void SetEvent(){} // RVA: 0x7FFE86A7E590
        public void SetEvent_internal(){} // RVA: 0x7FFE86A7E670
        public void ResetEvent(){} // RVA: 0x7FFE86A7E690
        public void ResetEvent_internal(){} // RVA: 0x7FFE86A7E7A0
        public void CloseEvent_internal(){} // RVA: 0x7FFE86A7E7F0
    }

    public class NativeOverlapped : ValueType
    {
    }

    public class OSSpecificSynchronizationContext : SynchronizationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81161E80
        public void Get(){} // RVA: 0x7FFE86A746A0
        public void CreateCopy(){} // RVA: 0x7FFE86A748E0
        public void Send(){} // RVA: 0x7FFE86A74980
        public void Post(){} // RVA: 0x7FFE86A749C0
        public void InvocationEntry(){} // RVA: 0x7FFE86A74D60
        public void GetOSContext(){} // RVA: 0x7FFE86A74EF0
        public void PostInternal(){} // RVA: 0x7FFE86A74F80
        public void .cctor(){} // RVA: 0x7FFE86A750A0
    }

    public class ParameterizedThreadStart : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class PlatformHelper : Object
    {
        public int s_processorCount;

        // ── Methods ──
        public void get_ProcessorCount(){} // RVA: 0x7FFE86A65F00
        public void .cctor(){} // RVA: 0x7FFE86A66000
    }

    public class PreAllocatedOverlapped : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE81D95990
        public void Release(){} // RVA: 0x7FFE86A6B990
        public void Dispose(){} // RVA: 0x7FFE86A6BA60
        public void System.Threading.IDeferredDisposable.OnFinalRelease(){} // RVA: 0x7FFE86A6BB50
    }

    public class QueueUserWorkItemCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A7AD40
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFE86A7AEE0
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFE810FB310
        public void WaitCallback_Context(){} // RVA: 0x7FFE86A7B020
        public void .cctor(){} // RVA: 0x7FFE86A7B0A0
    }

    public class ReaderWriterCount : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ReaderWriterLock : CriticalFinalizerObject
    {
        public int seq_num; // 0x10
        public int state; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A7E810
        public void Finalize(){} // RVA: 0x7FFE86A77230
        public void get_IsReaderLockHeld(){} // RVA: 0x7FFE86A7E9D0
        public void get_IsWriterLockHeld(){} // RVA: 0x7FFE86A7EBB0
        public void AcquireReaderLock(){} // RVA: 0x7FFE86A7ED40 | overloaded x2
        public void AcquireWriterLock(){} // RVA: 0x7FFE86A7F260 | overloaded x2
        public void ReleaseReaderLock(){} // RVA: 0x7FFE86A7F940 | overloaded x2
        public void ReleaseWriterLock(){} // RVA: 0x7FFE86A7FC90 | overloaded x2
        public void HasWriterLock(){} // RVA: 0x7FFE86A7FCF0
    }

    public class ReaderWriterLockSlim : Object
    {
        public bool fIsReentrant; // 0x10
        public int myLock; // 0x14
        public int LockSpinCycles;
        public int LockSpinCount;
        public int LockSleep0Count;
        public uint numWriteWaiters; // 0x18
        public uint numReadWaiters; // 0x1C
        public uint numWriteUpgradeWaiters; // 0x20
        public uint numUpgradeWaiters; // 0x24

        // ── Methods ──
        public void InitializeThreadCounts(){} // RVA: 0x7FFE871BC8C0
        public void .ctor(){} // RVA: 0x7FFE871BC930 | overloaded x2
        public void IsRWEntryEmpty(){} // RVA: 0x7FFE871BC9A0
        public void IsRwHashEntryChanged(){} // RVA: 0x7FFE871BC9E0
        public void GetThreadRWCount(){} // RVA: 0x7FFE871BCA00
        public void EnterReadLock(){} // RVA: 0x7FFE871BCB70
        public void TryEnterReadLock(){} // RVA: 0x7FFE871BCC20 | overloaded x2
        public void TryEnterReadLockCore(){} // RVA: 0x7FFE871BCC30
        public void EnterWriteLock(){} // RVA: 0x7FFE871BCFA0
        public void TryEnterWriteLock(){} // RVA: 0x7FFE871BD050 | overloaded x2
        public void TryEnterWriteLockCore(){} // RVA: 0x7FFE871BD060
        public void EnterUpgradeableReadLock(){} // RVA: 0x7FFE871BD540
        public void TryEnterUpgradeableReadLock(){} // RVA: 0x7FFE871BD5F0 | overloaded x2
        public void TryEnterUpgradeableReadLockCore(){} // RVA: 0x7FFE871BD600
        public void ExitReadLock(){} // RVA: 0x7FFE871BDA90
        public void ExitWriteLock(){} // RVA: 0x7FFE871BDCA0
        public void ExitUpgradeableReadLock(){} // RVA: 0x7FFE871BDED0
        public void LazyCreateEvent(){} // RVA: 0x7FFE871BE240
        public void WaitOnEvent(){} // RVA: 0x7FFE871BE380
        public void ExitAndWakeUpAppropriateWaiters(){} // RVA: 0x7FFE871BE640
        public void ExitAndWakeUpAppropriateWaitersPreferringWriters(){} // RVA: 0x7FFE871BE6D0
        public void ExitAndWakeUpAppropriateReadWaiters(){} // RVA: 0x7FFE871BE750
        public void IsWriterAcquired(){} // RVA: 0x7FFE871BE7E0
        public void SetWriterAcquired(){} // RVA: 0x7FFE871BE7F0
        public void ClearWriterAcquired(){} // RVA: 0x7FFE871BE800
        public void SetWritersWaiting(){} // RVA: 0x7FFE871BE810
        public void ClearWritersWaiting(){} // RVA: 0x7FFE871BE820
        public void SetUpgraderWaiting(){} // RVA: 0x7FFE871BE830
        public void ClearUpgraderWaiting(){} // RVA: 0x7FFE871BE840
        public void GetNumReaders(){} // RVA: 0x7FFE871BE850
        public void EnterMyLock(){} // RVA: 0x7FFE871BE860
        public void EnterMyLockSpin(){} // RVA: 0x7FFE871BE880
        public void ExitMyLock(){} // RVA: 0x7FFE871BE9F0
        public void SpinWait(){} // RVA: 0x7FFE871BEA00
        public void Dispose(){} // RVA: 0x7FFE871BEA90 | overloaded x2
        public void get_IsReadLockHeld(){} // RVA: 0x7FFE871BEF00
        public void get_IsUpgradeableReadLockHeld(){} // RVA: 0x7FFE871BEFD0
        public void get_IsWriteLockHeld(){} // RVA: 0x7FFE871BF110
        public void get_RecursiveReadCount(){} // RVA: 0x7FFE871BF250
        public void get_RecursiveUpgradeCount(){} // RVA: 0x7FFE871BF310
        public void get_RecursiveWriteCount(){} // RVA: 0x7FFE871BF450
        public void get_WaitingReadCount(){} // RVA: 0x7FFE82707EE0
        public void get_WaitingUpgradeCount(){} // RVA: 0x7FFE81A56130
        public void get_WaitingWriteCount(){} // RVA: 0x7FFE813DB630
    }

    public class RegisteredWaitHandle : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A7FD40
        public void Wait(){} // RVA: 0x7FFE86A7FF70
        public void DoCallBack(){} // RVA: 0x7FFE86A80750
        public void Unregister(){} // RVA: 0x7FFE86A809E0
    }

    public class SemaphoreFullException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x2
    }

    public class SemaphoreSlim : Object
    {
        public int m_currentCount; // 0x10

        // ── Methods ──
        public void get_CurrentCount(){} // RVA: 0x7FFE86A6BCE0
        public void .ctor(){} // RVA: 0x7FFE86A6BD00 | overloaded x2
        public void Wait(){} // RVA: 0x7FFE86A6BEE0 | overloaded x3
        public void WaitUntilCountOrTimeout(){} // RVA: 0x7FFE86A6C7D0
        public void WaitAsync(){} // RVA: 0x7FFE86A6C910 | overloaded x3
        public void CreateAndAddAsyncWaiter(){} // RVA: 0x7FFE86A6CD50
        public void RemoveAsyncWaiter(){} // RVA: 0x7FFE86A6CFC0
        public void WaitUntilCountOrTimeoutAsync(){} // RVA: 0x7FFE86A6D230
        public void Release(){} // RVA: 0x7FFE86A6D4B0 | overloaded x2
        public void QueueWaiterTask(){} // RVA: 0x7FFE86A6D830
        public void Dispose(){} // RVA: 0x7FFE86A6D8B0 | overloaded x2
        public void CancellationTokenCanceledEventHandler(){} // RVA: 0x7FFE86A6DA60
        public void CheckDispose(){} // RVA: 0x7FFE86A6DC20
        public void GetResourceString(){} // RVA: 0x7FFE827C4A80
        public void .cctor(){} // RVA: 0x7FFE86A6DCB0
    }

    public class SendOrPostCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class SparselyPopulatedArrayAddInfo`1 : ValueType
    {
        public System.Threading.SparselyPopulatedArrayFragment`1<T> _source;
        public int _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4D070
        public void get_Source(){} // RVA: 0x7FFE80E2E2E0
        public void get_Index(){} // RVA: 0x7FFE80E2EDB0
    }

    public class SparselyPopulatedArrayFragment`1 : Object
    {
        public T[] _elements;
        public int _freeCount;
        public System.Threading.SparselyPopulatedArrayFragment`1<T> _next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E48220 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void get_Prev(){} // RVA: 0x7FFE80E2E2E0
        public void SafeAtomicRemove(){} // RVA: 0x7FFE810A1420
    }

    public class SparselyPopulatedArray`1 : Object
    {
        public System.Threading.SparselyPopulatedArrayFragment`1<T> _head;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void get_Tail(){} // RVA: 0x7FFE80E2E2E0
        public void Add(){} // RVA: 0x7FFE810A1420
    }

    public class SpinLock : ValueType
    {
        public int m_owner; // 0x10
        public int MAXIMUM_WAITERS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A6ED00
        public void Enter(){} // RVA: 0x7FFE86A6ED20
        public void TryEnter(){} // RVA: 0x7FFE86A6EDD0
        public void ContinueTryEnter(){} // RVA: 0x7FFE86A6EE90
        public void DecrementWaiters(){} // RVA: 0x7FFE86A6F2D0
        public void ContinueTryEnterWithThreadTracking(){} // RVA: 0x7FFE86A6F390
        public void Exit(){} // RVA: 0x7FFE86A6F5F0
        public void ExitSlowPath(){} // RVA: 0x7FFE86A6F690
        public void get_IsHeldByCurrentThread(){} // RVA: 0x7FFE86A6F7D0
        public void get_IsThreadOwnerTrackingEnabled(){} // RVA: 0x7FFE86A6F8F0
        public void .cctor(){} // RVA: 0x7FFE86A6F900
    }

    public class SpinWait : ValueType
    {
        public int SpinCountforSpinBeforeWait;
        public int _count; // 0x10

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE826F4220
        public void get_NextSpinWillYield(){} // RVA: 0x7FFE86A65B40
        public void SpinOnce(){} // RVA: 0x7FFE86A65C10 | overloaded x2
        public void SpinOnceCore(){} // RVA: 0x7FFE86A65D10
        public void Reset(){} // RVA: 0x7FFE82C67CC0
        public void .cctor(){} // RVA: 0x7FFE86A65E70
    }

    public class SynchronizationContext : Object
    {
        public 0x664BFAB4 _props; // 0x10
        public System.Type s_cachedPreparedType1;
        public System.Type s_cachedPreparedType2; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void SetWaitNotificationRequired(){} // RVA: 0x7FFE86A73CD0
        public void IsWaitNotificationRequired(){} // RVA: 0x7FFE86A74080
        public void Send(){} // RVA: 0x7FFE83F952D0
        public void Post(){} // RVA: 0x7FFE86A74090
        public void OperationStarted(){} // RVA: 0x7FFE810FB310
        public void OperationCompleted(){} // RVA: 0x7FFE810FB310
        public void Wait(){} // RVA: 0x7FFE86A74120
        public void WaitHelper(){} // RVA: 0x7FFE86A74210
        public void SetSynchronizationContext(){} // RVA: 0x7FFE86A742B0
        public void get_Current(){} // RVA: 0x7FFE86A743A0
        public void get_CurrentNoFlow(){} // RVA: 0x7FFE86A74460
        public void GetThreadLocalContext(){} // RVA: 0x7FFE86A74520
        public void CreateCopy(){} // RVA: 0x7FFE86A74570
        public void get_CurrentExplicit(){} // RVA: 0x7FFE86A745B0
    }

    public class SynchronizationLockException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class SystemThreading_ThreadLocalDebugView`1 : Object
    {
    }

    public class Thread : CriticalFinalizerObject
    {
        public System.LocalDataStoreMgr s_LocalDataStoreMgr;
        public System.LocalDataStoreHolder s_LocalDataStore; // 0xFFFF
        public System.Globalization.CultureInfo m_CurrentCulture; // 0xFFFF
        public System.Globalization.CultureInfo m_CurrentUICulture; // 0xFFFF
        public System.Threading.AsyncLocal`1<System.Globalization.CultureInfo> s_asyncLocalCurrentCulture; // 0x8
        public System.Threading.AsyncLocal`1<System.Globalization.CultureInfo> s_asyncLocalCurrentUICulture; // 0x10
        public System.Threading.InternalThread internal_thread; // 0x10
        public object m_ThreadStartArg; // 0x18
        public object pending_exception; // 0x20
        public System.Threading.Thread current_thread; // 0xFFFF
        public System.MulticastDelegate m_Delegate; // 0x28
        public System.Threading.ExecutionContext m_ExecutionContext; // 0x30
        public bool m_ExecutionContextBelongsToOuterScope; // 0x38
        public System.Security.Principal.IPrincipal principal; // 0x40
        public int principal_version; // 0x48

        // ── Methods ──
        public void AsyncLocalSetCurrentUICulture(){} // RVA: 0x7FFE86A75740
        public void .ctor(){} // RVA: 0x7FFE86A75950 | overloaded x3
        public void Start(){} // RVA: 0x7FFE86A75B70 | overloaded x3
        public void GetExecutionContextReader(){} // RVA: 0x7FFE86A75D70
        public void get_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x7FFE86A75DD0
        public void set_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x7FFE86A75DE0
        public void GetMutableExecutionContext(){} // RVA: 0x7FFE86A75DF0
        public void SetExecutionContext(){} // RVA: 0x7FFE86A75F20 | overloaded x2
        public void get_Priority(){} // RVA: 0x7FFE86A75F80
        public void set_Priority(){} // RVA: 0x7FFE86A76000
        public void GetPriorityNative(){} // RVA: 0x7FFE86A75F80
        public void SetPriorityNative(){} // RVA: 0x7FFE86A76000
        public void JoinInternal(){} // RVA: 0x7FFE86A76090
        public void Join(){} // RVA: 0x7FFE86A76160
        public void SleepInternal(){} // RVA: 0x7FFE86A76220
        public void Sleep(){} // RVA: 0x7FFE86A762B0
        public void YieldInternal(){} // RVA: 0x7FFE86764760
        public void Yield(){} // RVA: 0x7FFE86764760
        public void SetStartHelper(){} // RVA: 0x7FFE86A763B0
        public void get_CurrentUICulture(){} // RVA: 0x7FFE86A76570
        public void set_CurrentUICulture(){} // RVA: 0x7FFE86A765B0
        public void GetCurrentUICultureNoAppX(){} // RVA: 0x7FFE86A76990
        public void get_CurrentCulture(){} // RVA: 0x7FFE86A76B40
        public void GetCurrentCultureNoAppX(){} // RVA: 0x7FFE86A76B80
        public void nativeInitCultureAccessors(){} // RVA: 0x7FFE86A76CF0
        public void MemoryBarrier(){} // RVA: 0x7FFE86A76F30
        public void ConstructInternalThread(){} // RVA: 0x7FFE86A76F40
        public void get_Internal(){} // RVA: 0x7FFE86A76F80
        public void get_CurrentContext(){} // RVA: 0x7FFE86827C40
        public void GetCurrentThread_icall(){} // RVA: 0x7FFE86A76FE0
        public void GetCurrentThread(){} // RVA: 0x7FFE86A77060
        public void get_CurrentThread(){} // RVA: 0x7FFE86A770F0
        public void get_CurrentThreadId(){} // RVA: 0x7FFE86A771F0
        public void GetDomainID(){} // RVA: 0x7FFE86A3D060
        public void Thread_internal(){} // RVA: 0x7FFE86A77220
        public void Finalize(){} // RVA: 0x7FFE86A77230
        public void get_IsThreadPoolThread(){} // RVA: 0x7FFE86A77270
        public void get_IsThreadPoolThreadInternal(){} // RVA: 0x7FFE86A77270
        public void get_IsAlive(){} // RVA: 0x7FFE86A772D0
        public void set_IsBackground(){} // RVA: 0x7FFE86A77330
        public void GetName_internal(){} // RVA: 0x7FFE86A774A0
        public void SetName_icall(){} // RVA: 0x7FFE86A77560
        public void SetName_internal(){} // RVA: 0x7FFE86A77570
        public void get_Name(){} // RVA: 0x7FFE86A775A0
        public void set_Name(){} // RVA: 0x7FFE86A776A0
        public void get_ThreadState(){} // RVA: 0x7FFE86A77720
        public void Abort_internal(){} // RVA: 0x7FFE86A77770
        public void Abort(){} // RVA: 0x7FFE86A77780
        public void SpinWait_nop(){} // RVA: 0x7FFE810FB310
        public void SpinWait(){} // RVA: 0x7FFE86A777D0
        public void StartInternal(){} // RVA: 0x7FFE86A777E0
        public void SetState(){} // RVA: 0x7FFE86A77890
        public void ClrState(){} // RVA: 0x7FFE86A778A0
        public void GetState(){} // RVA: 0x7FFE86A778B0
        public void VolatileRead(){} // RVA: 0x7FFE82EFC3B0
        public void SystemMaxStackStize(){} // RVA: 0x7FFE86774820
        public void GetProcessDefaultStackSize(){} // RVA: 0x7FFE86A77920
        public void SetStart(){} // RVA: 0x7FFE86A779A0
        public void get_ManagedThreadId(){} // RVA: 0x7FFE86A77A60
        public void BeginCriticalRegion(){} // RVA: 0x7FFE86A77AC0
        public void EndCriticalRegion(){} // RVA: 0x7FFE86A77B40
        public void GetHashCode(){} // RVA: 0x7FFE86A77A60
        public void ValidateThreadState(){} // RVA: 0x7FFE86A77BC0
    }

    public class ThreadAbortException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x2
    }

    public class ThreadHelper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void SetExecutionContextHelper(){} // RVA: 0x7FFE811290D0
        public void ThreadStart_Context(){} // RVA: 0x7FFE86A752B0
        public void ThreadStart(){} // RVA: 0x7FFE86A75550 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE86A75660
    }

    public class ThreadInterruptedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x2
    }

    public class ThreadLocal`1 : Object
    {
        public System.Func`1<T> m_valueFactory;
        public LinkedSlotVolatile<T>[] ts_slotArray; // 0xFFFF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFE80E4BC00
        public void Finalize(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E466C0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void get_Value(){} // RVA: 0x7FFE810A1420
        public void set_Value(){} // RVA: 0x7FFE810A1420
        public void GetValueSlow(){} // RVA: 0x7FFE810A1420
        public void SetValueSlow(){} // RVA: 0x7FFE810A1420
        public void CreateLinkedSlot(){} // RVA: 0x7FFE810A1420
        public void get_IsValueCreated(){} // RVA: 0x7FFE80E2F150
        public void GrowTable(){} // RVA: 0x7FFE80E4D070
        public void GetNewTableSize(){} // RVA: 0x7FFE80E35560
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ThreadPool : Object
    {
        // ── Methods ──
        public void GetMaxThreads(){} // RVA: 0x7FFE86A7B180
        public void GetMinThreads(){} // RVA: 0x7FFE86A7B1D0
        public void GetAvailableThreads(){} // RVA: 0x7FFE86A7B220
        public void RegisterWaitForSingleObject(){} // RVA: 0x7FFE86A7B710 | overloaded x3
        public void QueueUserWorkItem(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void QueueUserWorkItemHelper(){} // RVA: 0x7FFE86A7BAF0
        public void UnsafeQueueCustomWorkItem(){} // RVA: 0x7FFE86A7BE80
        public void TryPopCustomWorkItem(){} // RVA: 0x7FFE86A7BF70
        public void RequestWorkerThread(){} // RVA: 0x7FFE86A7C0B0
        public void EnsureVMInitialized(){} // RVA: 0x7FFE86A7C0D0
        public void GetMinThreadsNative(){} // RVA: 0x7FFE86A7B1D0
        public void GetMaxThreadsNative(){} // RVA: 0x7FFE86A7B180
        public void GetAvailableThreadsNative(){} // RVA: 0x7FFE86A7B220
        public void NotifyWorkItemComplete(){} // RVA: 0x7FFE86A7C180
        public void ReportThreadStatus(){} // RVA: 0x7FFE868DCC30
        public void NotifyWorkItemProgress(){} // RVA: 0x7FFE86775FB0
        public void NotifyWorkItemProgressNative(){} // RVA: 0x7FFE86A7C210
        public void NotifyWorkItemQueued(){} // RVA: 0x7FFE810FB310
        public void InitializeVMTp(){} // RVA: 0x7FFE86A7C270
        public void get_IsThreadPoolThread(){} // RVA: 0x7FFE86A7C280
    }

    public class ThreadPoolBoundHandle : Object
    {
        public System.Runtime.InteropServices.SafeHandle _handle; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE81D95990
        public void .ctor(){} // RVA: 0x7FFE86A69440
        public void get_Handle(){} // RVA: 0x7FFE81116380
        public void BindHandle(){} // RVA: 0x7FFE86A694F0
        public void AllocateNativeOverlapped(){} // RVA: 0x7FFE86A69A80
        public void FreeNativeOverlapped(){} // RVA: 0x7FFE86A69D10
        public void GetNativeOverlappedState(){} // RVA: 0x7FFE86A6A020
        public void GetOverlappedData(){} // RVA: 0x7FFE86A6A100
        public void OnNativeIOCompleted(){} // RVA: 0x7FFE86A6A240
        public void AddRef(){} // RVA: 0x7FFE86A6A450
        public void Release(){} // RVA: 0x7FFE86A6A4D0
        public void Dispose(){} // RVA: 0x7FFE86A6A5A0
        public void Finalize(){} // RVA: 0x7FFE86A6A690
        public void System.Threading.IDeferredDisposable.OnFinalRelease(){} // RVA: 0x7FFE86A6A6E0
    }

    public class ThreadPoolCallbackWrapper : ValueType
    {
        // ── Methods ──
        public void Enter(){} // RVA: 0x7FFE86A692F0
        public void Exit(){} // RVA: 0x7FFE86A69420
    }

    public class ThreadPoolGlobals : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86A77D40
    }

    public class ThreadPoolWorkQueue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A77F10
        public void EnsureCurrentThreadHasQueue(){} // RVA: 0x7FFE86A78020
        public void EnsureThreadRequested(){} // RVA: 0x7FFE86A78170
        public void MarkThreadRequestSatisfied(){} // RVA: 0x7FFE86A78210
        public void Enqueue(){} // RVA: 0x7FFE86A78240
        public void LocalFindAndPop(){} // RVA: 0x7FFE86A784B0
        public void Dequeue(){} // RVA: 0x7FFE86A78560
        public void Dispatch(){} // RVA: 0x7FFE86A78820
        public void .cctor(){} // RVA: 0x7FFE86A78DE0
    }

    public class ThreadPoolWorkQueueThreadLocals : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A7A7E0
        public void CleanUp(){} // RVA: 0x7FFE86A7AAD0
        public void Finalize(){} // RVA: 0x7FFE86A7AC70
    }

    public class ThreadStart : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81159980
        public void Invoke(){} // RVA: 0x7FFE81159A50
    }

    public class ThreadStateException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class Timeout : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86A63290
    }

    public class TimeoutHelper : Object
    {
        // ── Methods ──
        public void GetTime(){} // RVA: 0x7FFE86A3F140
        public void UpdateTimeOut(){} // RVA: 0x7FFE86A66050
    }

    public class Timer : MarshalByRefObject
    {
        public System.Threading.TimerCallback callback; // 0x18

        // ── Methods ──
        public void get_scheduler(){} // RVA: 0x7FFE86A80D70
        public void .ctor(){} // RVA: 0x7FFE86A80F20 | overloaded x3
        public void Init(){} // RVA: 0x7FFE86A80F50
        public void Change(){} // RVA: 0x7FFE86A811C0 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFE86A81180
        public void DisposeAsync(){} // RVA: 0x7FFE86A81430
        public void KeepRootedWhileScheduled(){} // RVA: 0x7FFE810FB310
        public void GetTimeMonotonic(){} // RVA: 0x7FFE86A81570
    }

    public class TimerCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class Volatile : Object
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void Write(){} // RVA: 0x7FFE810A1420 | overloaded x3
    }

    public class WaitCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class WaitHandle : MarshalByRefObject
    {
        public int WaitTimeout;
        public int MAX_WAITHANDLES;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A7C2F0
        public void Init(){} // RVA: 0x7FFE86A7C2F0
        public void get_Handle(){} // RVA: 0x7FFE86A7C3B0
        public void set_Handle(){} // RVA: 0x7FFE86A7C440
        public void get_SafeWaitHandle(){} // RVA: 0x7FFE86A7C600
        public void SetHandleInternal(){} // RVA: 0x7FFE86A7C750
        public void WaitOne(){} // RVA: 0x7FFE86A7C990 | overloaded x6
        public void InternalWaitOne(){} // RVA: 0x7FFE86A7CAF0
        public void WaitAny(){} // RVA: 0x7FFE86A7CFC0 | overloaded x2
        public void ThrowAbandonedMutexException(){} // RVA: 0x7FFE86A7D140 | overloaded x2
        public void Close(){} // RVA: 0x7FFE86A7D1A0
        public void Dispose(){} // RVA: 0x7FFE86A7D260 | overloaded x2
        public void WaitOneNative(){} // RVA: 0x7FFE86A7D2D0
        public void WaitMultiple(){} // RVA: 0x7FFE86A7D530
        public void Wait_internal(){} // RVA: 0x7FFE86A7DB30
        public void .cctor(){} // RVA: 0x7FFE86A7DB40
    }

    public class WaitHandleCannotBeOpenedException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868B3BC0 | overloaded x3
    }

    public class WaitOrTimerCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8441F520
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class Win32ThreadPoolNativeOverlapped : ValueType
    {
        public ExecutionContextCallbackArgs t_executionContextCallbackArgs; // 0xFFFF

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE81D95990
        public void get_Data(){} // RVA: 0x7FFE86A6A720
        public void Allocate(){} // RVA: 0x7FFE86A6A7A0
        public void AllocateNew(){} // RVA: 0x7FFE86A6A890
        public void SetData(){} // RVA: 0x7FFE86A6ACF0
        public void Free(){} // RVA: 0x7FFE86A6B120
        public void ToNativeOverlapped(){} // RVA: 0x7FFE827C4A80
        public void FromNativeOverlapped(){} // RVA: 0x7FFE827C4A80
        public void CompleteWithCallback(){} // RVA: 0x7FFE86A6B1F0
        public void OnExecutionContextCallback(){} // RVA: 0x7FFE86A6B530
    }

    public class _ThreadPoolWaitCallback : Object
    {
        // ── Methods ──
        public void PerformWaitCallback(){} // RVA: 0x7FFE86A7ACF0
    }

}