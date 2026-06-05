// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading
// Classes: 86
// Methods: 675

namespace ThirdParty.DotNet.System.Threading
{
    public class AbandonedMutexException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89D1FC0 | overloaded x3
        public void SetupException(){} // RVA: 0x7FFAF89D2050
    }

    public class AsyncFlowControl : Setup
    {
        // ── Methods ──
        public void Setup(){} // RVA: 0x7FFAF89DF3E0
        public void Dispose(){} // RVA: 0x7FFAF89DF4E0
        public void Undo(){} // RVA: 0x7FFAF89DF4F0
        public void GetHashCode(){} // RVA: 0x7FFAF89DF6F0
        public void Equals(){} // RVA: 0x7FFAF89DF850 | overloaded x2
    }

    public class AsyncLocalValueChangedArgs`1
    {
        public object Token;

        // ── Methods ──
        public void get_CurrentValue(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0
    }

    public class AsyncLocalValueChangedArgs`1
    {
    }

    public class AsyncLocalValueChangedArgs`1
    {
    }

    public class AsyncLocal`1 : Value
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAF2D33FA0
        public void set_Value(){} // RVA: 0x7FFAF2D33FA0
        public void System.Threading.IAsyncLocal.OnValueChanged(){}
    }

    public class AsyncLocal`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAF776A5D0
        public void set_Value(){} // RVA: 0x7FFAF776A680
        public void System.Threading.IAsyncLocal.OnValueChanged(){} // RVA: 0x7FFAF776A700
    }

    public class AutoResetEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89D2110
    }

    public class CancellationCallbackCoreWorkArguments
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32D0840
    }

    public class CancellationCallbackInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DD5A50
        public void ExecuteCallback(){} // RVA: 0x7FFAF89D8110
        public void ExecutionContextCallback(){} // RVA: 0x7FFAF89D82D0
    }

    public class CancellationToken
    {
        public object IsCompleted;
        public object IsCompletedSuccessfully;
        public object Result;

        // ── Methods ──
        public void get_None(){} // RVA: 0x7FFAF2FC9240
        public void get_IsCancellationRequested(){} // RVA: 0x7FFAF89D2520
        public void get_CanBeCanceled(){} // RVA: 0x7FFAF3BB2770
        public void .ctor(){} // RVA: 0x7FFAF89D2540 | overloaded x2
        public void Register(){} // RVA: 0x7FFAF89D2A70 | overloaded x5
        public void InternalRegisterWithoutEC(){} // RVA: 0x7FFAF89D29C0
        public void Equals(){} // RVA: 0x7FFAF89D2BD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF89D2C70
        public void op_Equality(){} // RVA: 0x7FFAF89D2CF0
        public void op_Inequality(){} // RVA: 0x7FFAF89D2D50
        public void ThrowIfCancellationRequested(){} // RVA: 0x7FFAF89D2DB0
        public void ThrowOperationCanceledException(){} // RVA: 0x7FFAF89D2E30
        public void .cctor(){} // RVA: 0x7FFAF89D2E90
    }

    public class CancellationTokenRegistration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6279050
        public void get_Token(){} // RVA: 0x7FFAF89D5270
        public void Unregister(){} // RVA: 0x7FFAF89D52A0
        public void Dispose(){} // RVA: 0x7FFAF89D5330
        public void Equals(){} // RVA: 0x7FFAF89D5570 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF89D5600
        public void DisposeAsync(){} // RVA: 0x7FFAF89D5680
    }

    public class CancellationTokenSource
    {
        // ── Methods ──
        public void get_IsCancellationRequested(){} // RVA: 0x7FFAF89D57B0
        public void get_IsCancellationCompleted(){} // RVA: 0x7FFAF89D57C0
        public void get_IsDisposed(){} // RVA: 0x7FFAF3198A80
        public void get_ThreadIDExecutingCallbacks(){} // RVA: 0x7FFAF89D57D0
        public void set_ThreadIDExecutingCallbacks(){} // RVA: 0x7FFAF89D57E0
        public void get_Token(){} // RVA: 0x7FFAF89D57F0
        public void get_ExecutingCallback(){} // RVA: 0x7FFAF888DC00
        public void .ctor(){} // RVA: 0x7FFAF89D59B0 | overloaded x3
        public void InitializeWithTimer(){} // RVA: 0x7FFAF89D5A30
        public void Cancel(){} // RVA: 0x7FFAF89D5BB0 | overloaded x2
        public void CancelAfter(){} // RVA: 0x7FFAF89D5D00 | overloaded x2
        public void TimerCallbackLogic(){} // RVA: 0x7FFAF89D5F30
        public void Dispose(){} // RVA: 0x7FFAF89D60A0 | overloaded x2
        public void ThrowIfDisposed(){} // RVA: 0x7FFAF89D61F0
        public void ThrowObjectDisposedException(){} // RVA: 0x7FFAF89D6240
        public void InternalRegister(){} // RVA: 0x7FFAF89D62A0
        public void NotifyCancellation(){} // RVA: 0x7FFAF89D6870
        public void ExecuteCallbackHandlers(){} // RVA: 0x7FFAF89D6930
        public void CancellationCallbackCoreWork_OnSyncContext(){} // RVA: 0x7FFAF89D6DE0
        public void CancellationCallbackCoreWork(){} // RVA: 0x7FFAF89D6E60
        public void CreateLinkedTokenSource(){} // RVA: 0x7FFAF89D7290 | overloaded x3
        public void WaitForCallbackToComplete(){} // RVA: 0x7FFAF89D7430
        public void .cctor(){} // RVA: 0x7FFAF89D7500
    }

    public class ContextCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E0D190
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    }

    public class ContextCallback`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAF2AD4B10
    }

    public class DeferredDisposableLifetime`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
        public void AddRef(){} // RVA: 0x7FFAF2D33FA0
        public void Release(){} // RVA: 0x7FFAF2D33FA0
        public void Dispose(){} // RVA: 0x7FFAF2D33FA0
    }

    public class DeferredDisposableLifetime`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF3AD0CE0
        public void AddRef(){} // RVA: 0x7FFAF5673D50
        public void Release(){} // RVA: 0x7FFAF5673E40
        public void Dispose(){} // RVA: 0x7FFAF5673ED0
    }

    public class DeferredDisposableLifetime`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF3AD0CE0
        public void AddRef(){} // RVA: 0x7FFAF5673D50
        public void Release(){} // RVA: 0x7FFAF5673E40
        public void Dispose(){} // RVA: 0x7FFAF5673ED0
    }

    public class EventWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89DEDF0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAF89DF170
        public void Set(){} // RVA: 0x7FFAF89DF1D0
    }

    public class ExecutionContext
    {
        // ── Methods ──
        public void get_isNewCapture(){} // RVA: 0x7FFAF89DF890
        public void set_isNewCapture(){} // RVA: 0x7FFAF89DF8A0
        public void get_isFlowSuppressed(){} // RVA: 0x7FFAF89DF8C0
        public void set_isFlowSuppressed(){} // RVA: 0x7FFAF89DF8D0
        public void get_IsPreAllocatedDefault(){} // RVA: 0x7FFAF89DF8F0
        public void .ctor(){} // RVA: 0x7FFAF89E1A40 | overloaded x3
        public void GetLocalValue(){} // RVA: 0x7FFAF89DF910
        public void SetLocalValue(){} // RVA: 0x7FFAF89DF9F0
        public void OnAsyncLocalContextChanged(){} // RVA: 0x7FFAF89DFD90
        public void get_LogicalCallContext(){} // RVA: 0x7FFAF89E01F0
        public void set_LogicalCallContext(){} // RVA: 0x7FFAF2DBB0D0
        public void get_IllogicalCallContext(){} // RVA: 0x7FFAF89E0290
        public void set_IllogicalCallContext(){} // RVA: 0x7FFAF2D8EE90
        public void get_SynchronizationContext(){} // RVA: 0x7FFAF2DA8380
        public void set_SynchronizationContext(){} // RVA: 0x7FFAF2D8EE30
        public void get_SynchronizationContextNoFlow(){} // RVA: 0x7FFAF2D907C0
        public void set_SynchronizationContextNoFlow(){} // RVA: 0x7FFAF2DF3E80
        public void Dispose(){} // RVA: 0x7FFAF3AD0CE0
        public void Run(){} // RVA: 0x7FFAF89E0470 | overloaded x2
        public void RunInternal(){} // RVA: 0x7FFAF2ADF420 | overloaded x4
        public void EstablishCopyOnWriteScope(){} // RVA: 0x7FFAF89E0800 | overloaded x2
        public void SetExecutionContext(){} // RVA: 0x7FFAF89E0940
        public void CreateCopy(){} // RVA: 0x7FFAF89E0C60
        public void CreateMutableCopy(){} // RVA: 0x7FFAF89E0EB0
        public void SuppressFlow(){} // RVA: 0x7FFAF89E11A0
        public void RestoreFlow(){} // RVA: 0x7FFAF89E1280
        public void IsFlowSuppressed(){} // RVA: 0x7FFAF89E1320
        public void Capture(){} // RVA: 0x7FFAF89E1450 | overloaded x2
        public void FastCapture(){} // RVA: 0x7FFAF89E1400
        public void GetObjectData(){} // RVA: 0x7FFAF89E1890
        public void IsDefaultFTContext(){} // RVA: 0x7FFAF89E1C10
        public void .cctor(){} // RVA: 0x7FFAF89E1C80
    }

    public class ExecutionContextSwitcher
    {
        // ── Methods ──
        public void UndoNoThrow(){} // RVA: 0x7FFAF89DF230
        public void Undo(){} // RVA: 0x7FFAF89DF250
    }

    public class IAsyncLocal
    {
        // ── Methods ──
        public void OnValueChanged(){}
    }

    public class IDeferredDisposable
    {
        // ── Methods ──
        public void OnFinalRelease(){} // RVA: 0x7FFAF2AD5130
    }

    public class IOCompletionCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF62A3FC0
        public void Invoke(){} // RVA: 0x7FFAF2EE94E0
    }

    public class IThreadPoolWorkItem
    {
        // ── Methods ──
        public void ExecuteWorkItem(){} // RVA: 0x7FFAF2AD4A50
        public void MarkAborted(){} // RVA: 0x7FFAF2AD4B10
    }

    public class Interlocked
    {
        // ── Methods ──
        public void CompareExchange(){} // RVA: 0x7FFAF2D33FA0 | overloaded x9
        public void Decrement(){} // RVA: 0x7FFAF89ECE80
        public void Increment(){} // RVA: 0x7FFAF89ECEA0 | overloaded x2
        public void Exchange(){} // RVA: 0x7FFAF2D33FA0 | overloaded x8
        public void Read(){} // RVA: 0x7FFAF89ECFF0
        public void Add(){} // RVA: 0x7FFAF89ED010 | overloaded x2
        public void MemoryBarrier(){} // RVA: 0x7FFAF89E6110
    }

    public class InternalThread
    {
        // ── Methods ──
        public void Thread_free_internal(){} // RVA: 0x7FFAF89EFDC0
        public void Finalize(){} // RVA: 0x7FFAF89EFE60
        public void .ctor(){} // RVA: 0x7FFAF89EFF40
    }

    public class LazyInitializer
    {
        // ── Methods ──
        public void EnsureInitialized(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void EnsureInitializedCore(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void EnsureLockInitialized(){} // RVA: 0x7FFAF89D2130
    }

    public class Lock
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFAF89DADC0
        public void Release(){} // RVA: 0x7FFAF89DAE00
        public void .ctor(){} // RVA: 0x7FFAF89DAE30
    }

    public class LockHolder
    {
        // ── Methods ──
        public void Hold(){} // RVA: 0x7FFAF89D83F0
        public void Dispose(){} // RVA: 0x7FFAF89D8490
    }

    public class LockQueue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Wait(){} // RVA: 0x7FFAF89ED020
        public void get_IsEmpty(){} // RVA: 0x7FFAF89ED270
        public void Pulse(){} // RVA: 0x7FFAF89ED3B0
    }

    public class LockRecursionException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89D22A0 | overloaded x3
    }

    public class ManualResetEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89D2320
    }

    public class ManualResetEventSlim
    {
        // ── Methods ──
        public void get_WaitHandle(){} // RVA: 0x7FFAF89D30C0
        public void get_IsSet(){} // RVA: 0x7FFAF89D3100
        public void set_IsSet(){} // RVA: 0x7FFAF89D3160
        public void get_SpinCount(){} // RVA: 0x7FFAF89D3190
        public void set_SpinCount(){} // RVA: 0x7FFAF89D31F0
        public void get_Waiters(){} // RVA: 0x7FFAF89D3210
        public void set_Waiters(){} // RVA: 0x7FFAF89D3270
        public void .ctor(){} // RVA: 0x7FFAF89D3430 | overloaded x3
        public void Initialize(){} // RVA: 0x7FFAF89D3530
        public void EnsureLockObjectCreated(){} // RVA: 0x7FFAF89D35F0
        public void LazyInitializeEvent(){} // RVA: 0x7FFAF89D36A0
        public void Set(){} // RVA: 0x7FFAF89D39B0 | overloaded x2
        public void Wait(){} // RVA: 0x7FFAF89D3E20 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFAF89D4780 | overloaded x2
        public void ThrowIfDisposed(){} // RVA: 0x7FFAF89D4910
        public void CancellationTokenCallback(){} // RVA: 0x7FFAF89D4980
        public void UpdateStateAtomically(){} // RVA: 0x7FFAF89D4B40
        public void ExtractStatePortionAndShiftRight(){} // RVA: 0x7FFAF89D4C20
        public void ExtractStatePortion(){} // RVA: 0x7FFAF89D4C30
        public void .cctor(){} // RVA: 0x7FFAF89D4C40
    }

    public class Monitor
    {
        // ── Methods ──
        public void Enter(){} // RVA: 0x7FFAF89E1F80 | overloaded x2
        public void ThrowLockTakenException(){} // RVA: 0x7FFAF89E2000
        public void Exit(){} // RVA: 0x7FFAF89E2070
        public void TryEnter(){} // RVA: 0x7FFAF89E24D0 | overloaded x5
        public void MillisecondsTimeoutFromTimeSpan(){} // RVA: 0x7FFAF89E2240
        public void IsEntered(){} // RVA: 0x7FFAF89E2590
        public void Wait(){} // RVA: 0x7FFAF89E2610 | overloaded x2
        public void Pulse(){} // RVA: 0x7FFAF89E2730
        public void PulseAll(){} // RVA: 0x7FFAF89E2800
        public void Monitor_test_synchronised(){} // RVA: 0x7FFAF89E2910
        public void Monitor_pulse(){} // RVA: 0x7FFAF89E2960
        public void ObjPulse(){} // RVA: 0x7FFAF89E2990
        public void Monitor_pulse_all(){} // RVA: 0x7FFAF89E2A30
        public void ObjPulseAll(){} // RVA: 0x7FFAF89E2AA0
        public void Monitor_wait(){} // RVA: 0x7FFAF89E2B80
        public void ObjWait(){} // RVA: 0x7FFAF89E2BB0
        public void try_enter_with_atomic_var(){} // RVA: 0x7FFAF89E2CA0
        public void ReliableEnterTimeout(){} // RVA: 0x7FFAF89E2CE0
        public void ReliableEnter(){} // RVA: 0x7FFAF89E2DC0
        public void Monitor_test_owner(){} // RVA: 0x7FFAF89E2E50
        public void IsEnteredNative(){} // RVA: 0x7FFAF89E2E50
    }

    public class Mutex
    {
        // ── Methods ──
        public void ReleaseMutex_internal(){} // RVA: 0x7FFAF89ED5A0
        public void .ctor(){} // RVA: 0x7FFAF89ED5C0
        public void ReleaseMutex(){} // RVA: 0x7FFAF89ED620
    }

    public class NativeEventCalls
    {
        // ── Methods ──
        public void CreateEvent_internal(){} // RVA: 0x7FFAF89ED650
        public void CreateEvent_icall(){} // RVA: 0x7FFAF89ED6E0
        public void SetEvent(){} // RVA: 0x7FFAF89ED770
        public void SetEvent_internal(){} // RVA: 0x7FFAF89ED850
        public void ResetEvent(){} // RVA: 0x7FFAF89ED870
        public void ResetEvent_internal(){} // RVA: 0x7FFAF89ED980
        public void CloseEvent_internal(){} // RVA: 0x7FFAF89ED9D0
    }

    public class NativeOverlapped
    {
    }

    public class OSSpecificSynchronizationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DF3E80
        public void Get(){} // RVA: 0x7FFAF89E3880
        public void CreateCopy(){} // RVA: 0x7FFAF89E3AC0
        public void Send(){} // RVA: 0x7FFAF89E3B60
        public void Post(){} // RVA: 0x7FFAF89E3BA0
        public void InvocationEntry(){} // RVA: 0x7FFAF89E3F40
        public void GetOSContext(){} // RVA: 0x7FFAF89E40D0
        public void PostInternal(){} // RVA: 0x7FFAF89E4160
        public void .cctor(){} // RVA: 0x7FFAF89E4280
    }

    public class ParameterizedThreadStart
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E0D190
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    }

    public class PlatformHelper
    {
        // ── Methods ──
        public void get_ProcessorCount(){} // RVA: 0x7FFAF89D50E0
        public void .cctor(){} // RVA: 0x7FFAF89D51E0
    }

    public class PreAllocatedOverlapped
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF3AD0CE0
        public void Release(){} // RVA: 0x7FFAF89DAB70
        public void Dispose(){} // RVA: 0x7FFAF89DAC40
        public void System.Threading.IDeferredDisposable.OnFinalRelease(){} // RVA: 0x7FFAF89DAD30
    }

    public class QueueUserWorkItemCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89E9F20
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFAF89EA0C0
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFAF2D8D310
        public void WaitCallback_Context(){} // RVA: 0x7FFAF89EA200
        public void .cctor(){} // RVA: 0x7FFAF89EA280
    }

    public class ReaderWriterCount
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ReaderWriterLock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89ED9F0
        public void Finalize(){} // RVA: 0x7FFAF89E6410
        public void get_IsReaderLockHeld(){} // RVA: 0x7FFAF89EDBB0
        public void get_IsWriterLockHeld(){} // RVA: 0x7FFAF89EDD90
        public void AcquireReaderLock(){} // RVA: 0x7FFAF89EDF20 | overloaded x2
        public void AcquireWriterLock(){} // RVA: 0x7FFAF89EE440 | overloaded x2
        public void ReleaseReaderLock(){} // RVA: 0x7FFAF89EEB20 | overloaded x2
        public void ReleaseWriterLock(){} // RVA: 0x7FFAF89EEE70 | overloaded x2
        public void HasWriterLock(){} // RVA: 0x7FFAF89EEED0
    }

    public class ReaderWriterLockSlim
    {
        // ── Methods ──
        public void InitializeThreadCounts(){} // RVA: 0x7FFAF912D9D0
        public void .ctor(){} // RVA: 0x7FFAF912DA40 | overloaded x2
        public void IsRWEntryEmpty(){} // RVA: 0x7FFAF912DAB0
        public void IsRwHashEntryChanged(){} // RVA: 0x7FFAF912DAF0
        public void GetThreadRWCount(){} // RVA: 0x7FFAF912DB10
        public void EnterReadLock(){} // RVA: 0x7FFAF912DC80
        public void TryEnterReadLock(){} // RVA: 0x7FFAF912DD30 | overloaded x2
        public void TryEnterReadLockCore(){} // RVA: 0x7FFAF912DD40
        public void EnterWriteLock(){} // RVA: 0x7FFAF912E0B0
        public void TryEnterWriteLock(){} // RVA: 0x7FFAF912E160 | overloaded x2
        public void TryEnterWriteLockCore(){} // RVA: 0x7FFAF912E170
        public void EnterUpgradeableReadLock(){} // RVA: 0x7FFAF912E650
        public void TryEnterUpgradeableReadLock(){} // RVA: 0x7FFAF912E700 | overloaded x2
        public void TryEnterUpgradeableReadLockCore(){} // RVA: 0x7FFAF912E710
        public void ExitReadLock(){} // RVA: 0x7FFAF912EBA0
        public void ExitWriteLock(){} // RVA: 0x7FFAF912EDB0
        public void ExitUpgradeableReadLock(){} // RVA: 0x7FFAF912EFE0
        public void LazyCreateEvent(){} // RVA: 0x7FFAF912F350
        public void WaitOnEvent(){} // RVA: 0x7FFAF912F490
        public void ExitAndWakeUpAppropriateWaiters(){} // RVA: 0x7FFAF912F750
        public void ExitAndWakeUpAppropriateWaitersPreferringWriters(){} // RVA: 0x7FFAF912F7E0
        public void ExitAndWakeUpAppropriateReadWaiters(){} // RVA: 0x7FFAF912F860
        public void IsWriterAcquired(){} // RVA: 0x7FFAF912F8F0
        public void SetWriterAcquired(){} // RVA: 0x7FFAF912F900
        public void ClearWriterAcquired(){} // RVA: 0x7FFAF912F910
        public void SetWritersWaiting(){} // RVA: 0x7FFAF912F920
        public void ClearWritersWaiting(){} // RVA: 0x7FFAF912F930
        public void SetUpgraderWaiting(){} // RVA: 0x7FFAF912F940
        public void ClearUpgraderWaiting(){} // RVA: 0x7FFAF912F950
        public void GetNumReaders(){} // RVA: 0x7FFAF912F960
        public void EnterMyLock(){} // RVA: 0x7FFAF912F970
        public void EnterMyLockSpin(){} // RVA: 0x7FFAF912F990
        public void ExitMyLock(){} // RVA: 0x7FFAF912FB00
        public void SpinWait(){} // RVA: 0x7FFAF912FB10
        public void Dispose(){} // RVA: 0x7FFAF912FBA0 | overloaded x2
        public void get_IsReadLockHeld(){} // RVA: 0x7FFAF9130010
        public void get_IsUpgradeableReadLockHeld(){} // RVA: 0x7FFAF91300E0
        public void get_IsWriteLockHeld(){} // RVA: 0x7FFAF9130220
        public void get_RecursiveReadCount(){} // RVA: 0x7FFAF9130360
        public void get_RecursiveUpgradeCount(){} // RVA: 0x7FFAF9130420
        public void get_RecursiveWriteCount(){} // RVA: 0x7FFAF9130560
        public void get_WaitingReadCount(){} // RVA: 0x7FFAF442C3B0
        public void get_WaitingUpgradeCount(){} // RVA: 0x7FFAF379F5B0
        public void get_WaitingWriteCount(){} // RVA: 0x7FFAF306ED50
    }

    public class RegisteredWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89EEF20
        public void Wait(){} // RVA: 0x7FFAF89EF150
        public void DoCallBack(){} // RVA: 0x7FFAF89EF930
        public void Unregister(){} // RVA: 0x7FFAF89EFBC0
    }

    public class SemaphoreFullException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x2
    }

    public class SemaphoreSlim
    {
        // ── Methods ──
        public void get_CurrentCount(){} // RVA: 0x7FFAF89DAEC0
        public void .ctor(){} // RVA: 0x7FFAF89DAEE0 | overloaded x2
        public void Wait(){} // RVA: 0x7FFAF89DB0C0 | overloaded x3
        public void WaitUntilCountOrTimeout(){} // RVA: 0x7FFAF89DB9B0
        public void WaitAsync(){} // RVA: 0x7FFAF89DBAF0 | overloaded x3
        public void CreateAndAddAsyncWaiter(){} // RVA: 0x7FFAF89DBF30
        public void RemoveAsyncWaiter(){} // RVA: 0x7FFAF89DC1A0
        public void WaitUntilCountOrTimeoutAsync(){} // RVA: 0x7FFAF89DC410
        public void Release(){} // RVA: 0x7FFAF89DC690 | overloaded x2
        public void QueueWaiterTask(){} // RVA: 0x7FFAF89DCA10
        public void Dispose(){} // RVA: 0x7FFAF89DCA90 | overloaded x2
        public void CancellationTokenCanceledEventHandler(){} // RVA: 0x7FFAF89DCC40
        public void CheckDispose(){} // RVA: 0x7FFAF89DCE00
        public void GetResourceString(){} // RVA: 0x7FFAF44EF520
        public void .cctor(){} // RVA: 0x7FFAF89DCE90
    }

    public class SendOrPostCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E0D190
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    }

    public class SparselyPopulatedArrayAddInfo`1
    {
        public object Item;
        public object Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2ADBAA0
        public void get_Source(){} // RVA: 0x7FFAF2ABCD60
        public void get_Index(){} // RVA: 0x7FFAF2ABD840
    }

    public class SparselyPopulatedArrayAddInfo`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32D0840
        public void get_Source(){} // RVA: 0x7FFAF4584690
        public void get_Index(){} // RVA: 0x7FFAF4959890
    }

    public class SparselyPopulatedArrayFragment`1
    {
        public object Tail;
        public object .ctor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD6C40 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAF2D33FA0
        public void get_Length(){} // RVA: 0x7FFAF2ABD840
        public void get_Prev(){} // RVA: 0x7FFAF2ABCD60
        public void SafeAtomicRemove(){} // RVA: 0x7FFAF2D33FA0
    }

    public class SparselyPopulatedArrayFragment`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B2FD60 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAF6B2FE70
        public void get_Length(){} // RVA: 0x7FFAF39EF910
        public void get_Prev(){} // RVA: 0x7FFAF6B2FEB0
        public void SafeAtomicRemove(){} // RVA: 0x7FFAF6B2FEC0
    }

    public class SparselyPopulatedArray`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4FA0
        public void get_Tail(){} // RVA: 0x7FFAF2ABCD60
        public void Add(){} // RVA: 0x7FFAF2D33FA0
    }

    public class SparselyPopulatedArray`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B2FF70
        public void get_Tail(){} // RVA: 0x7FFAF6B300A0
        public void Add(){} // RVA: 0x7FFAF6B300B0
    }

    public class SpinLock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89DDEE0
        public void Enter(){} // RVA: 0x7FFAF89DDF00
        public void TryEnter(){} // RVA: 0x7FFAF89DDFB0
        public void ContinueTryEnter(){} // RVA: 0x7FFAF89DE070
        public void DecrementWaiters(){} // RVA: 0x7FFAF89DE4B0
        public void ContinueTryEnterWithThreadTracking(){} // RVA: 0x7FFAF89DE570
        public void Exit(){} // RVA: 0x7FFAF89DE7D0
        public void ExitSlowPath(){} // RVA: 0x7FFAF89DE870
        public void get_IsHeldByCurrentThread(){} // RVA: 0x7FFAF89DE9B0
        public void get_IsThreadOwnerTrackingEnabled(){} // RVA: 0x7FFAF89DEAD0
        public void .cctor(){} // RVA: 0x7FFAF89DEAE0
    }

    public class SpinWait
    {
        public object FrameworkDescription;
        public object OSDescription;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAF44189B0
        public void get_NextSpinWillYield(){} // RVA: 0x7FFAF89D4D20
        public void SpinOnce(){} // RVA: 0x7FFAF89D4DF0 | overloaded x2
        public void SpinOnceCore(){} // RVA: 0x7FFAF89D4EF0
        public void Reset(){} // RVA: 0x7FFAF498D860
        public void .cctor(){} // RVA: 0x7FFAF89D5050
    }

    public class SynchronizationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void SetWaitNotificationRequired(){} // RVA: 0x7FFAF89E2EB0
        public void IsWaitNotificationRequired(){} // RVA: 0x7FFAF89E3260
        public void Send(){} // RVA: 0x7FFAF5DC6790
        public void Post(){} // RVA: 0x7FFAF89E3270
        public void OperationStarted(){} // RVA: 0x7FFAF2D8D310
        public void OperationCompleted(){} // RVA: 0x7FFAF2D8D310
        public void Wait(){} // RVA: 0x7FFAF89E3300
        public void WaitHelper(){} // RVA: 0x7FFAF89E33F0
        public void SetSynchronizationContext(){} // RVA: 0x7FFAF89E3490
        public void get_Current(){} // RVA: 0x7FFAF89E3580
        public void get_CurrentNoFlow(){} // RVA: 0x7FFAF89E3640
        public void GetThreadLocalContext(){} // RVA: 0x7FFAF89E3700
        public void CreateCopy(){} // RVA: 0x7FFAF89E3750
        public void get_CurrentExplicit(){} // RVA: 0x7FFAF89E3790
    }

    public class SynchronizationLockException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x3
    }

    public class SystemThreading_ThreadLocalDebugView`1
    {
    }

    public class Thread
    {
        // ── Methods ──
        public void AsyncLocalSetCurrentUICulture(){} // RVA: 0x7FFAF89E4920
        public void .ctor(){} // RVA: 0x7FFAF89E4B30 | overloaded x3
        public void Start(){} // RVA: 0x7FFAF89E4D50 | overloaded x3
        public void GetExecutionContextReader(){} // RVA: 0x7FFAF89E4F50
        public void get_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x7FFAF89E4FB0
        public void set_ExecutionContextBelongsToCurrentScope(){} // RVA: 0x7FFAF89E4FC0
        public void GetMutableExecutionContext(){} // RVA: 0x7FFAF89E4FD0
        public void SetExecutionContext(){} // RVA: 0x7FFAF89E5100 | overloaded x2
        public void get_Priority(){} // RVA: 0x7FFAF89E5160
        public void set_Priority(){} // RVA: 0x7FFAF89E51E0
        public void GetPriorityNative(){} // RVA: 0x7FFAF89E5160
        public void SetPriorityNative(){} // RVA: 0x7FFAF89E51E0
        public void JoinInternal(){} // RVA: 0x7FFAF89E5270
        public void Join(){} // RVA: 0x7FFAF89E5340
        public void SleepInternal(){} // RVA: 0x7FFAF89E5400
        public void Sleep(){} // RVA: 0x7FFAF89E5490
        public void YieldInternal(){} // RVA: 0x7FFAF86D3910
        public void Yield(){} // RVA: 0x7FFAF86D3910
        public void SetStartHelper(){} // RVA: 0x7FFAF89E5590
        public void get_CurrentUICulture(){} // RVA: 0x7FFAF89E5750
        public void set_CurrentUICulture(){} // RVA: 0x7FFAF89E5790
        public void GetCurrentUICultureNoAppX(){} // RVA: 0x7FFAF89E5B70
        public void get_CurrentCulture(){} // RVA: 0x7FFAF89E5D20
        public void GetCurrentCultureNoAppX(){} // RVA: 0x7FFAF89E5D60
        public void nativeInitCultureAccessors(){} // RVA: 0x7FFAF89E5ED0
        public void MemoryBarrier(){} // RVA: 0x7FFAF89E6110
        public void ConstructInternalThread(){} // RVA: 0x7FFAF89E6120
        public void get_Internal(){} // RVA: 0x7FFAF89E6160
        public void get_CurrentContext(){} // RVA: 0x7FFAF8796D40
        public void GetCurrentThread_icall(){} // RVA: 0x7FFAF89E61C0
        public void GetCurrentThread(){} // RVA: 0x7FFAF89E6240
        public void get_CurrentThread(){} // RVA: 0x7FFAF89E62D0
        public void get_CurrentThreadId(){} // RVA: 0x7FFAF89E63D0
        public void GetDomainID(){} // RVA: 0x7FFAF89AC220
        public void Thread_internal(){} // RVA: 0x7FFAF89E6400
        public void Finalize(){} // RVA: 0x7FFAF89E6410
        public void get_IsThreadPoolThread(){} // RVA: 0x7FFAF89E6450
        public void get_IsThreadPoolThreadInternal(){} // RVA: 0x7FFAF89E6450
        public void get_IsAlive(){} // RVA: 0x7FFAF89E64B0
        public void set_IsBackground(){} // RVA: 0x7FFAF89E6510
        public void GetName_internal(){} // RVA: 0x7FFAF89E6680
        public void SetName_icall(){} // RVA: 0x7FFAF89E6740
        public void SetName_internal(){} // RVA: 0x7FFAF89E6750
        public void get_Name(){} // RVA: 0x7FFAF89E6780
        public void set_Name(){} // RVA: 0x7FFAF89E6880
        public void get_ThreadState(){} // RVA: 0x7FFAF89E6900
        public void Abort_internal(){} // RVA: 0x7FFAF89E6950
        public void Abort(){} // RVA: 0x7FFAF89E6960
        public void SpinWait_nop(){} // RVA: 0x7FFAF2D8D310
        public void SpinWait(){} // RVA: 0x7FFAF89E69B0
        public void StartInternal(){} // RVA: 0x7FFAF89E69C0
        public void SetState(){} // RVA: 0x7FFAF89E6A70
        public void ClrState(){} // RVA: 0x7FFAF89E6A80
        public void GetState(){} // RVA: 0x7FFAF89E6A90
        public void VolatileRead(){} // RVA: 0x7FFAF4C4A2B0
        public void SystemMaxStackStize(){} // RVA: 0x7FFAF86E39D0
        public void GetProcessDefaultStackSize(){} // RVA: 0x7FFAF89E6B00
        public void SetStart(){} // RVA: 0x7FFAF89E6B80
        public void get_ManagedThreadId(){} // RVA: 0x7FFAF89E6C40
        public void BeginCriticalRegion(){} // RVA: 0x7FFAF89E6CA0
        public void EndCriticalRegion(){} // RVA: 0x7FFAF89E6D20
        public void GetHashCode(){} // RVA: 0x7FFAF89E6C40
        public void ValidateThreadState(){} // RVA: 0x7FFAF89E6DA0
    }

    public class ThreadAbortException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x2
    }

    public class ThreadHelper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void SetExecutionContextHelper(){} // RVA: 0x7FFAF2DBB0D0
        public void ThreadStart_Context(){} // RVA: 0x7FFAF89E4490
        public void ThreadStart(){} // RVA: 0x7FFAF89E4730 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF89E4840
    }

    public class ThreadInterruptedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x2
    }

    public class ThreadLocal`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAF2ADA620
        public void Finalize(){} // RVA: 0x7FFAF2AD4A50
        public void Dispose(){} // RVA: 0x7FFAF2AD5130 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF2ABCD60
        public void get_Value(){} // RVA: 0x7FFAF2D33FA0
        public void set_Value(){} // RVA: 0x7FFAF2D33FA0
        public void GetValueSlow(){} // RVA: 0x7FFAF2D33FA0
        public void SetValueSlow(){} // RVA: 0x7FFAF2D33FA0
        public void CreateLinkedSlot(){} // RVA: 0x7FFAF2D33FA0
        public void get_IsValueCreated(){} // RVA: 0x7FFAF2ABDBE0
        public void GrowTable(){} // RVA: 0x7FFAF2ADBAA0
        public void GetNewTableSize(){} // RVA: 0x7FFAF2AC3FF0
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
    }

    public class ThreadLocal`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E9A620 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAF6E9A790
        public void Finalize(){} // RVA: 0x7FFAF6E9A910
        public void Dispose(){} // RVA: 0x7FFAF6E9A9F0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF6E9ADC0
        public void get_Value(){} // RVA: 0x7FFAF6E9AE70
        public void set_Value(){} // RVA: 0x7FFAF6E9AF90
        public void GetValueSlow(){} // RVA: 0x7FFAF6E9B0B0
        public void SetValueSlow(){} // RVA: 0x7FFAF6E9B300
        public void CreateLinkedSlot(){} // RVA: 0x7FFAF6E9B8F0
        public void get_IsValueCreated(){} // RVA: 0x7FFAF6E9BDE0
        public void GrowTable(){} // RVA: 0x7FFAF6E9BEF0
        public void GetNewTableSize(){} // RVA: 0x7FFAF6E9C240
        public void .cctor(){} // RVA: 0x7FFAF6E9C280
    }

    public class ThreadPool
    {
        // ── Methods ──
        public void GetMaxThreads(){} // RVA: 0x7FFAF89EA360
        public void GetMinThreads(){} // RVA: 0x7FFAF89EA3B0
        public void GetAvailableThreads(){} // RVA: 0x7FFAF89EA400
        public void RegisterWaitForSingleObject(){} // RVA: 0x7FFAF89EA8F0 | overloaded x3
        public void QueueUserWorkItem(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void QueueUserWorkItemHelper(){} // RVA: 0x7FFAF89EACD0
        public void UnsafeQueueCustomWorkItem(){} // RVA: 0x7FFAF89EB060
        public void TryPopCustomWorkItem(){} // RVA: 0x7FFAF89EB150
        public void RequestWorkerThread(){} // RVA: 0x7FFAF89EB290
        public void EnsureVMInitialized(){} // RVA: 0x7FFAF89EB2B0
        public void GetMinThreadsNative(){} // RVA: 0x7FFAF89EA3B0
        public void GetMaxThreadsNative(){} // RVA: 0x7FFAF89EA360
        public void GetAvailableThreadsNative(){} // RVA: 0x7FFAF89EA400
        public void NotifyWorkItemComplete(){} // RVA: 0x7FFAF89EB360
        public void ReportThreadStatus(){} // RVA: 0x7FFAF884BDA0
        public void NotifyWorkItemProgress(){} // RVA: 0x7FFAF86E5160
        public void NotifyWorkItemProgressNative(){} // RVA: 0x7FFAF89EB3F0
        public void NotifyWorkItemQueued(){} // RVA: 0x7FFAF2D8D310
        public void InitializeVMTp(){} // RVA: 0x7FFAF89EB450
        public void get_IsThreadPoolThread(){} // RVA: 0x7FFAF89EB460
    }

    public class ThreadPoolBoundHandle
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF3AD0CE0
        public void .ctor(){} // RVA: 0x7FFAF89D8620
        public void get_Handle(){} // RVA: 0x7FFAF2DA8380
        public void BindHandle(){} // RVA: 0x7FFAF89D86D0
        public void AllocateNativeOverlapped(){} // RVA: 0x7FFAF89D8C60
        public void FreeNativeOverlapped(){} // RVA: 0x7FFAF89D8EF0
        public void GetNativeOverlappedState(){} // RVA: 0x7FFAF89D9200
        public void GetOverlappedData(){} // RVA: 0x7FFAF89D92E0
        public void OnNativeIOCompleted(){} // RVA: 0x7FFAF89D9420
        public void AddRef(){} // RVA: 0x7FFAF89D9630
        public void Release(){} // RVA: 0x7FFAF89D96B0
        public void Dispose(){} // RVA: 0x7FFAF89D9780
        public void Finalize(){} // RVA: 0x7FFAF89D9870
        public void System.Threading.IDeferredDisposable.OnFinalRelease(){} // RVA: 0x7FFAF89D98C0
    }

    public class ThreadPoolCallbackWrapper
    {
        // ── Methods ──
        public void Enter(){} // RVA: 0x7FFAF89D84D0
        public void Exit(){} // RVA: 0x7FFAF89D8600
    }

    public class ThreadPoolGlobals
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF89E6F20
    }

    public class ThreadPoolWorkQueue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89E70F0
        public void EnsureCurrentThreadHasQueue(){} // RVA: 0x7FFAF89E7200
        public void EnsureThreadRequested(){} // RVA: 0x7FFAF89E7350
        public void MarkThreadRequestSatisfied(){} // RVA: 0x7FFAF89E73F0
        public void Enqueue(){} // RVA: 0x7FFAF89E7420
        public void LocalFindAndPop(){} // RVA: 0x7FFAF89E7690
        public void Dequeue(){} // RVA: 0x7FFAF89E7740
        public void Dispatch(){} // RVA: 0x7FFAF89E7A00
        public void .cctor(){} // RVA: 0x7FFAF89E7FC0
    }

    public class ThreadPoolWorkQueueThreadLocals
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89E99C0
        public void CleanUp(){} // RVA: 0x7FFAF89E9CB0
        public void Finalize(){} // RVA: 0x7FFAF89E9E50
    }

    public class ThreadStart
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DEB980
        public void Invoke(){} // RVA: 0x7FFAF2DEBA50
    }

    public class ThreadStateException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x3
    }

    public class Timeout
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF89D2470
    }

    public class TimeoutHelper
    {
        // ── Methods ──
        public void GetTime(){} // RVA: 0x7FFAF89AE300
        public void UpdateTimeOut(){} // RVA: 0x7FFAF89D5230
    }

    public class Timer
    {
        // ── Methods ──
        public void get_scheduler(){} // RVA: 0x7FFAF89EFF50
        public void .ctor(){} // RVA: 0x7FFAF89F0100 | overloaded x3
        public void Init(){} // RVA: 0x7FFAF89F0130
        public void Change(){} // RVA: 0x7FFAF89F03A0 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFAF89F0360
        public void DisposeAsync(){} // RVA: 0x7FFAF89F0610
        public void KeepRootedWhileScheduled(){} // RVA: 0x7FFAF2D8D310
        public void GetTimeMonotonic(){} // RVA: 0x7FFAF89F0750
    }

    public class TimerCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E0D190
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    }

    public class Volatile
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void Write(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
    }

    public class WaitCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E0D190
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    }

    public class WaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89EB4D0
        public void Init(){} // RVA: 0x7FFAF89EB4D0
        public void get_Handle(){} // RVA: 0x7FFAF89EB590
        public void set_Handle(){} // RVA: 0x7FFAF89EB620
        public void get_SafeWaitHandle(){} // RVA: 0x7FFAF89EB7E0
        public void SetHandleInternal(){} // RVA: 0x7FFAF89EB930
        public void WaitOne(){} // RVA: 0x7FFAF89EBB70 | overloaded x6
        public void InternalWaitOne(){} // RVA: 0x7FFAF89EBCD0
        public void WaitAny(){} // RVA: 0x7FFAF89EC1A0 | overloaded x2
        public void ThrowAbandonedMutexException(){} // RVA: 0x7FFAF89EC320 | overloaded x2
        public void Close(){} // RVA: 0x7FFAF89EC380
        public void Dispose(){} // RVA: 0x7FFAF89EC440 | overloaded x2
        public void WaitOneNative(){} // RVA: 0x7FFAF89EC4B0
        public void WaitMultiple(){} // RVA: 0x7FFAF89EC710
        public void Wait_internal(){} // RVA: 0x7FFAF89ECD10
        public void .cctor(){} // RVA: 0x7FFAF89ECD20
    }

    public class WaitHandleCannotBeOpenedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8822D30 | overloaded x3
    }

    public class WaitOrTimerCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF62A2520
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
    }

    public class Win32ThreadPoolNativeOverlapped
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF3AD0CE0
        public void get_Data(){} // RVA: 0x7FFAF89D9900
        public void Allocate(){} // RVA: 0x7FFAF89D9980
        public void AllocateNew(){} // RVA: 0x7FFAF89D9A70
        public void SetData(){} // RVA: 0x7FFAF89D9ED0
        public void Free(){} // RVA: 0x7FFAF89DA300
        public void ToNativeOverlapped(){} // RVA: 0x7FFAF44EF520
        public void FromNativeOverlapped(){} // RVA: 0x7FFAF44EF520
        public void CompleteWithCallback(){} // RVA: 0x7FFAF89DA3D0
        public void OnExecutionContextCallback(){} // RVA: 0x7FFAF89DA710
    }

    public class _ThreadPoolWaitCallback
    {
        // ── Methods ──
        public void PerformWaitCallback(){} // RVA: 0x7FFAF89E9ED0
    }

}