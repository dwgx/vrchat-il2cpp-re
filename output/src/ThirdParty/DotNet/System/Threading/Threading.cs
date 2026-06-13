// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading
// Classes: 86
// Methods: 675

namespace ThirdParty.DotNet.System.Threading
{
    public class AbandonedMutexException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F21FC0 | overloaded x3
        public void SetupException(){} // RVA: 0x5F22050
    }

    public class AsyncFlowControl : Setup
    {
        // ── Methods ──
        public void Setup(){} // RVA: 0x5F2F3E0
        public void Dispose(){} // RVA: 0x5F2F4E0
        public void Undo(){} // RVA: 0x5F2F4F0
        public void GetHashCode(){} // RVA: 0x5F2F6F0
        public void Equals(){} // RVA: 0x5F2F850 | overloaded x2
    }

    public class AsyncLocalValueChangedArgs`1
    {
        public T Token;

        // ── Methods ──
        public void get_CurrentValue(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0
    }

    public class AsyncLocalValueChangedArgs`1
    {
        public Scope <PreviousValue>k__BackingField; // 0x10
    }

    public class AsyncLocalValueChangedArgs`1
    {
        public Scope <PreviousValue>k__BackingField; // 0x10
    }

    public class AsyncLocal`1 : Value
    {
        public System.Action`1<System.Threading.AsyncLocalValueChangedArgs`1<T>> m_valueChangedHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
        public void get_Value(){} // RVA: 0x283FA0
        public void set_Value(){} // RVA: 0x283FA0
        public void System.Threading.IAsyncLocal.OnValueChanged(){}
    }

    public class AsyncLocal`1
    {
        public System.Action`1<System.Threading.AsyncLocalValueChangedArgs`1<Scope>> m_valueChangedHandler; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_Value(){} // RVA: 0x4CBA5D0
        public void set_Value(){} // RVA: 0x4CBA680
        public void System.Threading.IAsyncLocal.OnValueChanged(){} // RVA: 0x4CBA700
    }

    public class AutoResetEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F22110
    }

    public class CancellationCallbackCoreWorkArguments
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x820840
    }

    public class CancellationCallbackInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x325A50
        public void ExecuteCallback(){} // RVA: 0x5F28110
        public void ExecutionContextCallback(){} // RVA: 0x5F282D0
    }

    public class CancellationToken
    {
        public System.Threading.CancellationTokenSource IsCompleted; // 0x10
        public System.Action`1<object> IsCompletedSuccessfully;

        // ── Methods ──
        public void get_None(){} // RVA: 0x519240
        public void get_IsCancellationRequested(){} // RVA: 0x5F22520
        public void get_CanBeCanceled(){} // RVA: 0x1102770
        public void .ctor(){} // RVA: 0x5F22540 | overloaded x2
        public void Register(){} // RVA: 0x5F22A70 | overloaded x5
        public void InternalRegisterWithoutEC(){} // RVA: 0x5F229C0
        public void Equals(){} // RVA: 0x5F22BD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5F22C70
        public void op_Equality(){} // RVA: 0x5F22CF0
        public void op_Inequality(){} // RVA: 0x5F22D50
        public void ThrowIfCancellationRequested(){} // RVA: 0x5F22DB0
        public void ThrowOperationCanceledException(){} // RVA: 0x5F22E30
        public void .cctor(){} // RVA: 0x5F22E90
    }

    public class CancellationTokenRegistration
    {
        public System.Threading.CancellationCallbackInfo m_callbackInfo; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x37C9050
        public void get_Token(){} // RVA: 0x5F25270
        public void Unregister(){} // RVA: 0x5F252A0
        public void Dispose(){} // RVA: 0x5F25330
        public void Equals(){} // RVA: 0x5F25570 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5F25600
        public void DisposeAsync(){} // RVA: 0x5F25680
    }

    public class CancellationTokenSource
    {
        public System.Threading.CancellationTokenSource s_canceledSource;
        public System.Threading.CancellationTokenSource s_neverCanceledSource; // 0x8
        public int s_nLists; // 0x10
        public System.Threading.ManualResetEvent _kernelEvent; // 0x10
        public System.Threading.SparselyPopulatedArray`1<System.Threading.CancellationCallbackInfo>[] _registeredCallbacksLists; // 0x18
        public int CannotBeCanceled;

        // ── Methods ──
        public void get_IsCancellationRequested(){} // RVA: 0x5F257B0
        public void get_IsCancellationCompleted(){} // RVA: 0x5F257C0
        public void get_IsDisposed(){} // RVA: 0x6E8A80
        public void get_ThreadIDExecutingCallbacks(){} // RVA: 0x5F257D0
        public void set_ThreadIDExecutingCallbacks(){} // RVA: 0x5F257E0
        public void get_Token(){} // RVA: 0x5F257F0
        public void get_ExecutingCallback(){} // RVA: 0x5DDDC00
        public void .ctor(){} // RVA: 0x5F259B0 | overloaded x3
        public void InitializeWithTimer(){} // RVA: 0x5F25A30
        public void Cancel(){} // RVA: 0x5F25BB0 | overloaded x2
        public void CancelAfter(){} // RVA: 0x5F25D00 | overloaded x2
        public void TimerCallbackLogic(){} // RVA: 0x5F25F30
        public void Dispose(){} // RVA: 0x5F260A0 | overloaded x2
        public void ThrowIfDisposed(){} // RVA: 0x5F261F0
        public void ThrowObjectDisposedException(){} // RVA: 0x5F26240
        public void InternalRegister(){} // RVA: 0x5F262A0
        public void NotifyCancellation(){} // RVA: 0x5F26870
        public void ExecuteCallbackHandlers(){} // RVA: 0x5F26930
        public void CancellationCallbackCoreWork_OnSyncContext(){} // RVA: 0x5F26DE0
        public void CancellationCallbackCoreWork(){} // RVA: 0x5F26E60
        public void CreateLinkedTokenSource(){} // RVA: 0x5F27290 | overloaded x3
        public void WaitForCallbackToComplete(){} // RVA: 0x5F27430
        public void .cctor(){} // RVA: 0x5F27500
    }

    public class ContextCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x35D190
        public void Invoke(){} // RVA: 0x338C60
    }

    public class ContextCallback`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x24B10
    }

    public class DeferredDisposableLifetime`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
        public void AddRef(){} // RVA: 0x283FA0
        public void Release(){} // RVA: 0x283FA0
        public void Dispose(){} // RVA: 0x283FA0
    }

    public class DeferredDisposableLifetime`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x1020CE0
        public void AddRef(){} // RVA: 0x2BC3D50
        public void Release(){} // RVA: 0x2BC3E40
        public void Dispose(){} // RVA: 0x2BC3ED0
    }

    public class DeferredDisposableLifetime`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x1020CE0
        public void AddRef(){} // RVA: 0x2BC3D50
        public void Release(){} // RVA: 0x2BC3E40
        public void Dispose(){} // RVA: 0x2BC3ED0
    }

    public class EventWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F2EDF0 | overloaded x2
        public void Reset(){} // RVA: 0x5F2F170
        public void Set(){} // RVA: 0x5F2F1D0
    }

    public class ExecutionContext
    {
        public System.Threading.SynchronizationContext _syncContext; // 0x10
        public System.Threading.SynchronizationContext _syncContextNoFlow; // 0x18
        public System.Runtime.Remoting.Messaging.LogicalCallContext _logicalCallContext; // 0x20
        public System.Runtime.Remoting.Messaging.IllogicalCallContext _illogicalCallContext; // 0x28
        public 0x657E1958 _flags; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Threading.IAsyncLocal,object> _localValues; // 0x38
        public System.Collections.Generic.List`1<System.Threading.IAsyncLocal> _localChangeNotifications; // 0x40

        // ── Methods ──
        public void get_isNewCapture(){} // RVA: 0x5F2F890
        public void set_isNewCapture(){} // RVA: 0x5F2F8A0
        public void get_isFlowSuppressed(){} // RVA: 0x5F2F8C0
        public void set_isFlowSuppressed(){} // RVA: 0x5F2F8D0
        public void get_IsPreAllocatedDefault(){} // RVA: 0x5F2F8F0
        public void .ctor(){} // RVA: 0x5F31A40 | overloaded x3
        public void GetLocalValue(){} // RVA: 0x5F2F910
        public void SetLocalValue(){} // RVA: 0x5F2F9F0
        public void OnAsyncLocalContextChanged(){} // RVA: 0x5F2FD90
        public void get_LogicalCallContext(){} // RVA: 0x5F301F0
        public void set_LogicalCallContext(){} // RVA: 0x30B0D0
        public void get_IllogicalCallContext(){} // RVA: 0x5F30290
        public void set_IllogicalCallContext(){} // RVA: 0x2DEE90
        public void get_SynchronizationContext(){} // RVA: 0x2F8380
        public void set_SynchronizationContext(){} // RVA: 0x2DEE30
        public void get_SynchronizationContextNoFlow(){} // RVA: 0x2E07C0
        public void set_SynchronizationContextNoFlow(){} // RVA: 0x343E80
        public void Dispose(){} // RVA: 0x1020CE0
        public void Run(){} // RVA: 0x5F30470 | overloaded x2
        public void RunInternal(){} // RVA: 0x2F420 | overloaded x4
        public void EstablishCopyOnWriteScope(){} // RVA: 0x5F30800 | overloaded x2
        public void SetExecutionContext(){} // RVA: 0x5F30940
        public void CreateCopy(){} // RVA: 0x5F30C60
        public void CreateMutableCopy(){} // RVA: 0x5F30EB0
        public void SuppressFlow(){} // RVA: 0x5F311A0
        public void RestoreFlow(){} // RVA: 0x5F31280
        public void IsFlowSuppressed(){} // RVA: 0x5F31320
        public void Capture(){} // RVA: 0x5F31450 | overloaded x2
        public void FastCapture(){} // RVA: 0x5F31400
        public void GetObjectData(){} // RVA: 0x5F31890
        public void IsDefaultFTContext(){} // RVA: 0x5F31C10
        public void .cctor(){} // RVA: 0x5F31C80
    }

    public class ExecutionContextSwitcher
    {
        // ── Methods ──
        public void UndoNoThrow(){} // RVA: 0x5F2F230
        public void Undo(){} // RVA: 0x5F2F250
    }

    public class IAsyncLocal
    {
        // ── Methods ──
        public void OnValueChanged(){}
    }

    public class IDeferredDisposable
    {
        // ── Methods ──
        public void OnFinalRelease(){} // RVA: 0x25130
    }

    public class IOCompletionCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37F3FC0
        public void Invoke(){} // RVA: 0x4394E0
    }

    public class IThreadPoolWorkItem
    {
        // ── Methods ──
        public void ExecuteWorkItem(){} // RVA: 0x24A50
        public void MarkAborted(){} // RVA: 0x24B10
    }

    public class Interlocked
    {
        // ── Methods ──
        public void CompareExchange(){} // RVA: 0x283FA0 | overloaded x9
        public void Decrement(){} // RVA: 0x5F3CE80
        public void Increment(){} // RVA: 0x5F3CEA0 | overloaded x2
        public void Exchange(){} // RVA: 0x283FA0 | overloaded x8
        public void Read(){} // RVA: 0x5F3CFF0
        public void Add(){} // RVA: 0x5F3D010 | overloaded x2
        public void MemoryBarrier(){} // RVA: 0x5F36110
    }

    public class InternalThread
    {
        // ── Methods ──
        public void Thread_free_internal(){} // RVA: 0x5F3FDC0
        public void Finalize(){} // RVA: 0x5F3FE60
        public void .ctor(){} // RVA: 0x5F3FF40
    }

    public class LazyInitializer
    {
        // ── Methods ──
        public void EnsureInitialized(){} // RVA: 0x283FA0 | overloaded x4
        public void EnsureInitializedCore(){} // RVA: 0x283FA0 | overloaded x4
        public void EnsureLockInitialized(){} // RVA: 0x5F22130
    }

    public class Lock
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x5F2ADC0
        public void Release(){} // RVA: 0x5F2AE00
        public void .ctor(){} // RVA: 0x5F2AE30
    }

    public class LockHolder
    {
        // ── Methods ──
        public void Hold(){} // RVA: 0x5F283F0
        public void Dispose(){} // RVA: 0x5F28490
    }

    public class LockQueue
    {
        public System.Threading.ReaderWriterLock rwlock; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Wait(){} // RVA: 0x5F3D020
        public void get_IsEmpty(){} // RVA: 0x5F3D270
        public void Pulse(){} // RVA: 0x5F3D3B0
    }

    public class LockRecursionException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F222A0 | overloaded x3
    }

    public class ManualResetEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F22320
    }

    public class ManualResetEventSlim
    {
        public int DEFAULT_SPIN_SP;
        public object m_lock; // 0x10
        public System.Threading.ManualResetEvent m_eventObj; // 0x18
        public int m_combinedState; // 0x20

        // ── Methods ──
        public void get_WaitHandle(){} // RVA: 0x5F230C0
        public void get_IsSet(){} // RVA: 0x5F23100
        public void set_IsSet(){} // RVA: 0x5F23160
        public void get_SpinCount(){} // RVA: 0x5F23190
        public void set_SpinCount(){} // RVA: 0x5F231F0
        public void get_Waiters(){} // RVA: 0x5F23210
        public void set_Waiters(){} // RVA: 0x5F23270
        public void .ctor(){} // RVA: 0x5F23430 | overloaded x3
        public void Initialize(){} // RVA: 0x5F23530
        public void EnsureLockObjectCreated(){} // RVA: 0x5F235F0
        public void LazyInitializeEvent(){} // RVA: 0x5F236A0
        public void Set(){} // RVA: 0x5F239B0 | overloaded x2
        public void Wait(){} // RVA: 0x5F23E20 | overloaded x3
        public void Dispose(){} // RVA: 0x5F24780 | overloaded x2
        public void ThrowIfDisposed(){} // RVA: 0x5F24910
        public void CancellationTokenCallback(){} // RVA: 0x5F24980
        public void UpdateStateAtomically(){} // RVA: 0x5F24B40
        public void ExtractStatePortionAndShiftRight(){} // RVA: 0x5F24C20
        public void ExtractStatePortion(){} // RVA: 0x5F24C30
        public void .cctor(){} // RVA: 0x5F24C40
    }

    public class Monitor
    {
        // ── Methods ──
        public void Enter(){} // RVA: 0x5F31F80 | overloaded x2
        public void ThrowLockTakenException(){} // RVA: 0x5F32000
        public void Exit(){} // RVA: 0x5F32070
        public void TryEnter(){} // RVA: 0x5F324D0 | overloaded x5
        public void MillisecondsTimeoutFromTimeSpan(){} // RVA: 0x5F32240
        public void IsEntered(){} // RVA: 0x5F32590
        public void Wait(){} // RVA: 0x5F32610 | overloaded x2
        public void Pulse(){} // RVA: 0x5F32730
        public void PulseAll(){} // RVA: 0x5F32800
        public void Monitor_test_synchronised(){} // RVA: 0x5F32910
        public void Monitor_pulse(){} // RVA: 0x5F32960
        public void ObjPulse(){} // RVA: 0x5F32990
        public void Monitor_pulse_all(){} // RVA: 0x5F32A30
        public void ObjPulseAll(){} // RVA: 0x5F32AA0
        public void Monitor_wait(){} // RVA: 0x5F32B80
        public void ObjWait(){} // RVA: 0x5F32BB0
        public void try_enter_with_atomic_var(){} // RVA: 0x5F32CA0
        public void ReliableEnterTimeout(){} // RVA: 0x5F32CE0
        public void ReliableEnter(){} // RVA: 0x5F32DC0
        public void Monitor_test_owner(){} // RVA: 0x5F32E50
        public void IsEnteredNative(){} // RVA: 0x5F32E50
    }

    public class Mutex
    {
        // ── Methods ──
        public void ReleaseMutex_internal(){} // RVA: 0x5F3D5A0
        public void .ctor(){} // RVA: 0x5F3D5C0
        public void ReleaseMutex(){} // RVA: 0x5F3D620
    }

    public class NativeEventCalls
    {
        // ── Methods ──
        public void CreateEvent_internal(){} // RVA: 0x5F3D650
        public void CreateEvent_icall(){} // RVA: 0x5F3D6E0
        public void SetEvent(){} // RVA: 0x5F3D770
        public void SetEvent_internal(){} // RVA: 0x5F3D850
        public void ResetEvent(){} // RVA: 0x5F3D870
        public void ResetEvent_internal(){} // RVA: 0x5F3D980
        public void CloseEvent_internal(){} // RVA: 0x5F3D9D0
    }

    public class NativeOverlapped
    {
    }

    public class OSSpecificSynchronizationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x343E80
        public void Get(){} // RVA: 0x5F33880
        public void CreateCopy(){} // RVA: 0x5F33AC0
        public void Send(){} // RVA: 0x5F33B60
        public void Post(){} // RVA: 0x5F33BA0
        public void InvocationEntry(){} // RVA: 0x5F33F40
        public void GetOSContext(){} // RVA: 0x5F340D0
        public void PostInternal(){} // RVA: 0x5F34160
        public void .cctor(){} // RVA: 0x5F34280
    }

    public class ParameterizedThreadStart
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x35D190
        public void Invoke(){} // RVA: 0x338C60
    }

    public class PlatformHelper
    {
        public int s_processorCount;

        // ── Methods ──
        public void get_ProcessorCount(){} // RVA: 0x5F250E0
        public void .cctor(){} // RVA: 0x5F251E0
    }

    public class PreAllocatedOverlapped
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x1020CE0
        public void Release(){} // RVA: 0x5F2AB70
        public void Dispose(){} // RVA: 0x5F2AC40
        public void System.Threading.IDeferredDisposable.OnFinalRelease(){} // RVA: 0x5F2AD30
    }

    public class QueueUserWorkItemCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F39F20
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x5F3A0C0
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x2DD310
        public void WaitCallback_Context(){} // RVA: 0x5F3A200
        public void .cctor(){} // RVA: 0x5F3A280
    }

    public class ReaderWriterCount
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ReaderWriterLock
    {
        public int seq_num; // 0x10
        public int state; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F3D9F0
        public void Finalize(){} // RVA: 0x5F36410
        public void get_IsReaderLockHeld(){} // RVA: 0x5F3DBB0
        public void get_IsWriterLockHeld(){} // RVA: 0x5F3DD90
        public void AcquireReaderLock(){} // RVA: 0x5F3DF20 | overloaded x2
        public void AcquireWriterLock(){} // RVA: 0x5F3E440 | overloaded x2
        public void ReleaseReaderLock(){} // RVA: 0x5F3EB20 | overloaded x2
        public void ReleaseWriterLock(){} // RVA: 0x5F3EE70 | overloaded x2
        public void HasWriterLock(){} // RVA: 0x5F3EED0
    }

    public class ReaderWriterLockSlim
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
        public void InitializeThreadCounts(){} // RVA: 0x667D9D0
        public void .ctor(){} // RVA: 0x667DA40 | overloaded x2
        public void IsRWEntryEmpty(){} // RVA: 0x667DAB0
        public void IsRwHashEntryChanged(){} // RVA: 0x667DAF0
        public void GetThreadRWCount(){} // RVA: 0x667DB10
        public void EnterReadLock(){} // RVA: 0x667DC80
        public void TryEnterReadLock(){} // RVA: 0x667DD30 | overloaded x2
        public void TryEnterReadLockCore(){} // RVA: 0x667DD40
        public void EnterWriteLock(){} // RVA: 0x667E0B0
        public void TryEnterWriteLock(){} // RVA: 0x667E160 | overloaded x2
        public void TryEnterWriteLockCore(){} // RVA: 0x667E170
        public void EnterUpgradeableReadLock(){} // RVA: 0x667E650
        public void TryEnterUpgradeableReadLock(){} // RVA: 0x667E700 | overloaded x2
        public void TryEnterUpgradeableReadLockCore(){} // RVA: 0x667E710
        public void ExitReadLock(){} // RVA: 0x667EBA0
        public void ExitWriteLock(){} // RVA: 0x667EDB0
        public void ExitUpgradeableReadLock(){} // RVA: 0x667EFE0
        public void LazyCreateEvent(){} // RVA: 0x667F350
        public void WaitOnEvent(){} // RVA: 0x667F490
        public void ExitAndWakeUpAppropriateWaiters(){} // RVA: 0x667F750
        public void ExitAndWakeUpAppropriateWaitersPreferringWriters(){} // RVA: 0x667F7E0
        public void ExitAndWakeUpAppropriateReadWaiters(){} // RVA: 0x667F860
        public void IsWriterAcquired(){} // RVA: 0x667F8F0
        public void SetWriterAcquired(){} // RVA: 0x667F900
        public void ClearWriterAcquired(){} // RVA: 0x667F910
        public void SetWritersWaiting(){} // RVA: 0x667F920
        public void ClearWritersWaiting(){} // RVA: 0x667F930
        public void SetUpgraderWaiting(){} // RVA: 0x667F940
        public void ClearUpgraderWaiting(){} // RVA: 0x667F950
        public void GetNumReaders(){} // RVA: 0x667F960
        public void EnterMyLock(){} // RVA: 0x667F970
        public void EnterMyLockSpin(){} // RVA: 0x667F990
        public void ExitMyLock(){} // RVA: 0x667FB00
        public void SpinWait(){} // RVA: 0x667FB10
        public void Dispose(){} // RVA: 0x667FBA0 | overloaded x2
        public void get_IsReadLockHeld(){} // RVA: 0x6680010
        public void get_IsUpgradeableReadLockHeld(){} // RVA: 0x66800E0
        public void get_IsWriteLockHeld(){} // RVA: 0x6680220
        public void get_RecursiveReadCount(){} // RVA: 0x6680360
        public void get_RecursiveUpgradeCount(){} // RVA: 0x6680420
        public void get_RecursiveWriteCount(){} // RVA: 0x6680560
        public void get_WaitingReadCount(){} // RVA: 0x197C3B0
        public void get_WaitingUpgradeCount(){} // RVA: 0xCEF5B0
        public void get_WaitingWriteCount(){} // RVA: 0x5BED50
    }

    public class RegisteredWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F3EF20
        public void Wait(){} // RVA: 0x5F3F150
        public void DoCallBack(){} // RVA: 0x5F3F930
        public void Unregister(){} // RVA: 0x5F3FBC0
    }

    public class SemaphoreFullException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x2
    }

    public class SemaphoreSlim
    {
        public int m_currentCount; // 0x10

        // ── Methods ──
        public void get_CurrentCount(){} // RVA: 0x5F2AEC0
        public void .ctor(){} // RVA: 0x5F2AEE0 | overloaded x2
        public void Wait(){} // RVA: 0x5F2B0C0 | overloaded x3
        public void WaitUntilCountOrTimeout(){} // RVA: 0x5F2B9B0
        public void WaitAsync(){} // RVA: 0x5F2BAF0 | overloaded x3
        public void CreateAndAddAsyncWaiter(){} // RVA: 0x5F2BF30
        public void RemoveAsyncWaiter(){} // RVA: 0x5F2C1A0
        public void WaitUntilCountOrTimeoutAsync(){} // RVA: 0x5F2C410
        public void Release(){} // RVA: 0x5F2C690 | overloaded x2
        public void QueueWaiterTask(){} // RVA: 0x5F2CA10
        public void Dispose(){} // RVA: 0x5F2CA90 | overloaded x2
        public void CancellationTokenCanceledEventHandler(){} // RVA: 0x5F2CC40
        public void CheckDispose(){} // RVA: 0x5F2CE00
        public void GetResourceString(){} // RVA: 0x1A3F520
        public void .cctor(){} // RVA: 0x5F2CE90
    }

    public class SendOrPostCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x35D190
        public void Invoke(){} // RVA: 0x338C60
    }

    public class SparselyPopulatedArrayAddInfo`1
    {
        public System.Threading.SparselyPopulatedArrayFragment`1<T> Item;
        public int Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BAA0
        public void get_Source(){} // RVA: 0xCD60
        public void get_Index(){} // RVA: 0xD840
    }

    public class SparselyPopulatedArrayAddInfo`1
    {
        public System.Threading.SparselyPopulatedArrayFragment`1<System.Threading.CancellationCallbackInfo> _source; // 0x10
        public int _index; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x820840
        public void get_Source(){} // RVA: 0x1AD4690
        public void get_Index(){} // RVA: 0x1EA9890
    }

    public class SparselyPopulatedArrayFragment`1
    {
        public T[] Tail;
        public int .ctor;
        public System.Threading.SparselyPopulatedArrayFragment`1<T> _next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x26C40 | overloaded x2
        public void get_Item(){} // RVA: 0x283FA0
        public void get_Length(){} // RVA: 0xD840
        public void get_Prev(){} // RVA: 0xCD60
        public void SafeAtomicRemove(){} // RVA: 0x283FA0
    }

    public class SparselyPopulatedArrayFragment`1
    {
        public System.Threading.CancellationCallbackInfo[] _elements; // 0x10
        public int _freeCount; // 0x18
        public System.Threading.SparselyPopulatedArrayFragment`1<System.Threading.CancellationCallbackInfo> _next; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x407FD60 | overloaded x2
        public void get_Item(){} // RVA: 0x407FE70
        public void get_Length(){} // RVA: 0xF3F910
        public void get_Prev(){} // RVA: 0x407FEB0
        public void SafeAtomicRemove(){} // RVA: 0x407FEC0
    }

    public class SparselyPopulatedArray`1
    {
        public System.Threading.SparselyPopulatedArrayFragment`1<T> _head;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0
        public void get_Tail(){} // RVA: 0xCD60
        public void Add(){} // RVA: 0x283FA0
    }

    public class SparselyPopulatedArray`1
    {
        public System.Threading.SparselyPopulatedArrayFragment`1<System.Threading.CancellationCallbackInfo> _head; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x407FF70
        public void get_Tail(){} // RVA: 0x40800A0
        public void Add(){} // RVA: 0x40800B0
    }

    public class SpinLock
    {
        public int m_owner; // 0x10
        public int MAXIMUM_WAITERS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F2DEE0
        public void Enter(){} // RVA: 0x5F2DF00
        public void TryEnter(){} // RVA: 0x5F2DFB0
        public void ContinueTryEnter(){} // RVA: 0x5F2E070
        public void DecrementWaiters(){} // RVA: 0x5F2E4B0
        public void ContinueTryEnterWithThreadTracking(){} // RVA: 0x5F2E570
        public void Exit(){} // RVA: 0x5F2E7D0
        public void ExitSlowPath(){} // RVA: 0x5F2E870
        public void get_IsHeldByCurrentThread(){} // RVA: 0x5F2E9B0
        public void get_IsThreadOwnerTrackingEnabled(){} // RVA: 0x5F2EAD0
        public void .cctor(){} // RVA: 0x5F2EAE0
    }

    public class SpinWait
    {
        public int FrameworkDescription;
        public int OSDescription; // 0x10

        // ── Methods ──
        public void get_Count(){} // RVA: 0x19689B0
        public void get_NextSpinWillYield(){} // RVA: 0x5F24D20
        public void SpinOnce(){} // RVA: 0x5F24DF0 | overloaded x2
        public void SpinOnceCore(){} // RVA: 0x5F24EF0
        public void Reset(){} // RVA: 0x1EDD860
        public void .cctor(){} // RVA: 0x5F25050
    }

    public class SynchronizationContext
    {
        public 0x657E1B10 _props; // 0x10
        public System.Type s_cachedPreparedType1;
        public System.Type s_cachedPreparedType2; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void SetWaitNotificationRequired(){} // RVA: 0x5F32EB0
        public void IsWaitNotificationRequired(){} // RVA: 0x5F33260
        public void Send(){} // RVA: 0x3316790
        public void Post(){} // RVA: 0x5F33270
        public void OperationStarted(){} // RVA: 0x2DD310
        public void OperationCompleted(){} // RVA: 0x2DD310
        public void Wait(){} // RVA: 0x5F33300
        public void WaitHelper(){} // RVA: 0x5F333F0
        public void SetSynchronizationContext(){} // RVA: 0x5F33490
        public void get_Current(){} // RVA: 0x5F33580
        public void get_CurrentNoFlow(){} // RVA: 0x5F33640
        public void GetThreadLocalContext(){} // RVA: 0x5F33700
        public void CreateCopy(){} // RVA: 0x5F33750
        public void get_CurrentExplicit(){} // RVA: 0x5F33790
    }

    public class SynchronizationLockException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class SystemThreading_ThreadLocalDebugView`1
    {
    }

    public class Thread
    {
        public System.LocalDataStoreMgr s_LocalDataStoreMgr;
        public System.LocalDataStoreHolder s_LocalDataStore; // 0xFFFFFFFF
        public System.Globalization.CultureInfo m_CurrentCulture; // 0xFFFFFFFF
        public System.Globalization.CultureInfo m_CurrentUICulture; // 0xFFFFFFFF
        public System.Threading.AsyncLocal`1<System.Globalization.CultureInfo> s_asyncLocalCurrentCulture; // 0x8
        public System.Threading.AsyncLocal`1<System.Globalization.CultureInfo> s_asyncLocalCurrentUICulture; // 0x10
        public System.Threading.InternalThread internal_thread; // 0x10
        public object m_ThreadStartArg; // 0x18
        public object pending_exception; // 0x20
        public System.Threading.Thread current_thread; // 0xFFFFFFFF
        public System.MulticastDelegate m_Delegate; // 0x28
        public System.Threading.ExecutionContext m_ExecutionContext; // 0x30
        public bool m_ExecutionContextBelongsToOuterScope; // 0x38
        public System.Security.Principal.IPrincipal principal; // 0x40
        public int principal_version; // 0x48

        // ── Methods ──
        public void AsyncLocalSetCurrentUICulture(){} // RVA: 0x5F34920
        public void .ctor(){} // RVA: 0x5F34B30 | overloaded x3
        public void Start(){} // RVA: 0x5F34D50 | overloaded x3
        public void GetExecutionContextReader(){} // RVA: 0x5F34F50
        public void get_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x5F34FB0
        public void set_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x5F34FC0
        public void GetMutableExecutionContext(){} // RVA: 0x5F34FD0
        public void SetExecutionContext(){} // RVA: 0x5F35100 | overloaded x2
        public void get_Priority(){} // RVA: 0x5F35160
        public void set_Priority(){} // RVA: 0x5F351E0
        public void GetPriorityNative(){} // RVA: 0x5F35160
        public void SetPriorityNative(){} // RVA: 0x5F351E0
        public void JoinInternal(){} // RVA: 0x5F35270
        public void Join(){} // RVA: 0x5F35340
        public void SleepInternal(){} // RVA: 0x5F35400
        public void Sleep(){} // RVA: 0x5F35490
        public void YieldInternal(){} // RVA: 0x5C23910
        public void Yield(){} // RVA: 0x5C23910
        public void SetStartHelper(){} // RVA: 0x5F35590
        public void get_CurrentUICulture(){} // RVA: 0x5F35750
        public void set_CurrentUICulture(){} // RVA: 0x5F35790
        public void GetCurrentUICultureNoAppX(){} // RVA: 0x5F35B70
        public void get_CurrentCulture(){} // RVA: 0x5F35D20
        public void GetCurrentCultureNoAppX(){} // RVA: 0x5F35D60
        public void nativeInitCultureAccessors(){} // RVA: 0x5F35ED0
        public void MemoryBarrier(){} // RVA: 0x5F36110
        public void ConstructInternalThread(){} // RVA: 0x5F36120
        public void get_Internal(){} // RVA: 0x5F36160
        public void get_CurrentContext(){} // RVA: 0x5CE6D40
        public void GetCurrentThread_icall(){} // RVA: 0x5F361C0
        public void GetCurrentThread(){} // RVA: 0x5F36240
        public void get_CurrentThread(){} // RVA: 0x5F362D0
        public void get_CurrentThreadId(){} // RVA: 0x5F363D0
        public void GetDomainID(){} // RVA: 0x5EFC220
        public void Thread_internal(){} // RVA: 0x5F36400
        public void Finalize(){} // RVA: 0x5F36410
        public void get_IsThreadPoolThread(){} // RVA: 0x5F36450
        public void get_IsThreadPoolThreadInternal(){} // RVA: 0x5F36450
        public void get_IsAlive(){} // RVA: 0x5F364B0
        public void set_IsBackground(){} // RVA: 0x5F36510
        public void GetName_internal(){} // RVA: 0x5F36680
        public void SetName_icall(){} // RVA: 0x5F36740
        public void SetName_internal(){} // RVA: 0x5F36750
        public void get_Name(){} // RVA: 0x5F36780
        public void set_Name(){} // RVA: 0x5F36880
        public void get_ThreadState(){} // RVA: 0x5F36900
        public void Abort_internal(){} // RVA: 0x5F36950
        public void Abort(){} // RVA: 0x5F36960
        public void SpinWait_nop(){} // RVA: 0x2DD310
        public void SpinWait(){} // RVA: 0x5F369B0
        public void StartInternal(){} // RVA: 0x5F369C0
        public void SetState(){} // RVA: 0x5F36A70
        public void ClrState(){} // RVA: 0x5F36A80
        public void GetState(){} // RVA: 0x5F36A90
        public void VolatileRead(){} // RVA: 0x219A2B0
        public void SystemMaxStackStize(){} // RVA: 0x5C339D0
        public void GetProcessDefaultStackSize(){} // RVA: 0x5F36B00
        public void SetStart(){} // RVA: 0x5F36B80
        public void get_ManagedThreadId(){} // RVA: 0x5F36C40
        public void BeginCriticalRegion(){} // RVA: 0x5F36CA0
        public void EndCriticalRegion(){} // RVA: 0x5F36D20
        public void GetHashCode(){} // RVA: 0x5F36C40
        public void ValidateThreadState(){} // RVA: 0x5F36DA0
    }

    public class ThreadAbortException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x2
    }

    public class ThreadHelper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void SetExecutionContextHelper(){} // RVA: 0x30B0D0
        public void ThreadStart_Context(){} // RVA: 0x5F34490
        public void ThreadStart(){} // RVA: 0x5F34730 | overloaded x2
        public void .cctor(){} // RVA: 0x5F34840
    }

    public class ThreadInterruptedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x2
    }

    public class ThreadLocal`1
    {
        public System.Func`1<T> m_valueFactory;
        public LinkedSlotVolatile<T>[] ts_slotArray; // 0xFFFFFFFF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
        public void Initialize(){} // RVA: 0x2A620
        public void Finalize(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x25130 | overloaded x2
        public void ToString(){} // RVA: 0xCD60
        public void get_Value(){} // RVA: 0x283FA0
        public void set_Value(){} // RVA: 0x283FA0
        public void GetValueSlow(){} // RVA: 0x283FA0
        public void SetValueSlow(){} // RVA: 0x283FA0
        public void CreateLinkedSlot(){} // RVA: 0x283FA0
        public void get_IsValueCreated(){} // RVA: 0xDBE0
        public void GrowTable(){} // RVA: 0x2BAA0
        public void GetNewTableSize(){} // RVA: 0x13FF0
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ThreadLocal`1
    {
        public System.Func`1<int> m_valueFactory; // 0x10
        public LinkedSlotVolatile<int>[] ts_slotArray; // 0xFFFFFFFF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x43EA620 | overloaded x2
        public void Initialize(){} // RVA: 0x43EA790
        public void Finalize(){} // RVA: 0x43EA910
        public void Dispose(){} // RVA: 0x43EA9F0 | overloaded x2
        public void ToString(){} // RVA: 0x43EADC0
        public void get_Value(){} // RVA: 0x43EAE70
        public void set_Value(){} // RVA: 0x43EAF90
        public void GetValueSlow(){} // RVA: 0x43EB0B0
        public void SetValueSlow(){} // RVA: 0x43EB300
        public void CreateLinkedSlot(){} // RVA: 0x43EB8F0
        public void get_IsValueCreated(){} // RVA: 0x43EBDE0
        public void GrowTable(){} // RVA: 0x43EBEF0
        public void GetNewTableSize(){} // RVA: 0x43EC240
        public void .cctor(){} // RVA: 0x43EC280
    }

    public class ThreadPool
    {
        // ── Methods ──
        public void GetMaxThreads(){} // RVA: 0x5F3A360
        public void GetMinThreads(){} // RVA: 0x5F3A3B0
        public void GetAvailableThreads(){} // RVA: 0x5F3A400
        public void RegisterWaitForSingleObject(){} // RVA: 0x5F3A8F0 | overloaded x3
        public void QueueUserWorkItem(){} // RVA: 0x283FA0 | overloaded x3
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x283FA0 | overloaded x2
        public void QueueUserWorkItemHelper(){} // RVA: 0x5F3ACD0
        public void UnsafeQueueCustomWorkItem(){} // RVA: 0x5F3B060
        public void TryPopCustomWorkItem(){} // RVA: 0x5F3B150
        public void RequestWorkerThread(){} // RVA: 0x5F3B290
        public void EnsureVMInitialized(){} // RVA: 0x5F3B2B0
        public void GetMinThreadsNative(){} // RVA: 0x5F3A3B0
        public void GetMaxThreadsNative(){} // RVA: 0x5F3A360
        public void GetAvailableThreadsNative(){} // RVA: 0x5F3A400
        public void NotifyWorkItemComplete(){} // RVA: 0x5F3B360
        public void ReportThreadStatus(){} // RVA: 0x5D9BDA0
        public void NotifyWorkItemProgress(){} // RVA: 0x5C35160
        public void NotifyWorkItemProgressNative(){} // RVA: 0x5F3B3F0
        public void NotifyWorkItemQueued(){} // RVA: 0x2DD310
        public void InitializeVMTp(){} // RVA: 0x5F3B450
        public void get_IsThreadPoolThread(){} // RVA: 0x5F3B460
    }

    public class ThreadPoolBoundHandle
    {
        public System.Runtime.InteropServices.SafeHandle _handle; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x1020CE0
        public void .ctor(){} // RVA: 0x5F28620
        public void get_Handle(){} // RVA: 0x2F8380
        public void BindHandle(){} // RVA: 0x5F286D0
        public void AllocateNativeOverlapped(){} // RVA: 0x5F28C60
        public void FreeNativeOverlapped(){} // RVA: 0x5F28EF0
        public void GetNativeOverlappedState(){} // RVA: 0x5F29200
        public void GetOverlappedData(){} // RVA: 0x5F292E0
        public void OnNativeIOCompleted(){} // RVA: 0x5F29420
        public void AddRef(){} // RVA: 0x5F29630
        public void Release(){} // RVA: 0x5F296B0
        public void Dispose(){} // RVA: 0x5F29780
        public void Finalize(){} // RVA: 0x5F29870
        public void System.Threading.IDeferredDisposable.OnFinalRelease(){} // RVA: 0x5F298C0
    }

    public class ThreadPoolCallbackWrapper
    {
        // ── Methods ──
        public void Enter(){} // RVA: 0x5F284D0
        public void Exit(){} // RVA: 0x5F28600
    }

    public class ThreadPoolGlobals
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5F36F20
    }

    public class ThreadPoolWorkQueue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F370F0
        public void EnsureCurrentThreadHasQueue(){} // RVA: 0x5F37200
        public void EnsureThreadRequested(){} // RVA: 0x5F37350
        public void MarkThreadRequestSatisfied(){} // RVA: 0x5F373F0
        public void Enqueue(){} // RVA: 0x5F37420
        public void LocalFindAndPop(){} // RVA: 0x5F37690
        public void Dequeue(){} // RVA: 0x5F37740
        public void Dispatch(){} // RVA: 0x5F37A00
        public void .cctor(){} // RVA: 0x5F37FC0
    }

    public class ThreadPoolWorkQueueThreadLocals
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F399C0
        public void CleanUp(){} // RVA: 0x5F39CB0
        public void Finalize(){} // RVA: 0x5F39E50
    }

    public class ThreadStart
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33B980
        public void Invoke(){} // RVA: 0x33BA50
    }

    public class ThreadStateException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class Timeout
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5F22470
    }

    public class TimeoutHelper
    {
        // ── Methods ──
        public void GetTime(){} // RVA: 0x5EFE300
        public void UpdateTimeOut(){} // RVA: 0x5F25230
    }

    public class Timer
    {
        public System.Threading.TimerCallback callback; // 0x18

        // ── Methods ──
        public void get_scheduler(){} // RVA: 0x5F3FF50
        public void .ctor(){} // RVA: 0x5F40100 | overloaded x3
        public void Init(){} // RVA: 0x5F40130
        public void Change(){} // RVA: 0x5F403A0 | overloaded x3
        public void Dispose(){} // RVA: 0x5F40360
        public void DisposeAsync(){} // RVA: 0x5F40610
        public void KeepRootedWhileScheduled(){} // RVA: 0x2DD310
        public void GetTimeMonotonic(){} // RVA: 0x5F40750
    }

    public class TimerCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x35D190
        public void Invoke(){} // RVA: 0x338C60
    }

    public class Volatile
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x283FA0 | overloaded x4
        public void Write(){} // RVA: 0x283FA0 | overloaded x3
    }

    public class WaitCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x35D190
        public void Invoke(){} // RVA: 0x338C60
    }

    public class WaitHandle
    {
        public int WaitTimeout;
        public int MAX_WAITHANDLES;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F3B4D0
        public void Init(){} // RVA: 0x5F3B4D0
        public void get_Handle(){} // RVA: 0x5F3B590
        public void set_Handle(){} // RVA: 0x5F3B620
        public void get_SafeWaitHandle(){} // RVA: 0x5F3B7E0
        public void SetHandleInternal(){} // RVA: 0x5F3B930
        public void WaitOne(){} // RVA: 0x5F3BB70 | overloaded x6
        public void InternalWaitOne(){} // RVA: 0x5F3BCD0
        public void WaitAny(){} // RVA: 0x5F3C1A0 | overloaded x2
        public void ThrowAbandonedMutexException(){} // RVA: 0x5F3C320 | overloaded x2
        public void Close(){} // RVA: 0x5F3C380
        public void Dispose(){} // RVA: 0x5F3C440 | overloaded x2
        public void WaitOneNative(){} // RVA: 0x5F3C4B0
        public void WaitMultiple(){} // RVA: 0x5F3C710
        public void Wait_internal(){} // RVA: 0x5F3CD10
        public void .cctor(){} // RVA: 0x5F3CD20
    }

    public class WaitHandleCannotBeOpenedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D72D30 | overloaded x3
    }

    public class WaitOrTimerCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37F2520
        public void Invoke(){} // RVA: 0x439370
    }

    public class Win32ThreadPoolNativeOverlapped
    {
        public ExecutionContextCallbackArgs t_executionContextCallbackArgs; // 0xFFFFFFFF

        // ── Methods ──
        public void .cctor(){} // RVA: 0x1020CE0
        public void get_Data(){} // RVA: 0x5F29900
        public void Allocate(){} // RVA: 0x5F29980
        public void AllocateNew(){} // RVA: 0x5F29A70
        public void SetData(){} // RVA: 0x5F29ED0
        public void Free(){} // RVA: 0x5F2A300
        public void ToNativeOverlapped(){} // RVA: 0x1A3F520
        public void FromNativeOverlapped(){} // RVA: 0x1A3F520
        public void CompleteWithCallback(){} // RVA: 0x5F2A3D0
        public void OnExecutionContextCallback(){} // RVA: 0x5F2A710
    }

    public class _ThreadPoolWaitCallback
    {
        // ── Methods ──
        public void PerformWaitCallback(){} // RVA: 0x5F39ED0
    }

}