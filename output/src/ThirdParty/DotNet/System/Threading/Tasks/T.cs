// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 100
// Methods: 716

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class Task : Object
    {
        public object s_taskIdCounter;
        public object m_taskId;
        public object m_action;
        public object m_stateObject;
        public object m_taskScheduler;
        public object m_parent;
        public object m_stateFlags;
        public object m_continuationObject;
        public object s_taskCompletionSentinel;
        public object s_asyncDebuggingEnabled;
        public object m_contingentProperties;
        public object s_taskCancelCallback;
        public object t_currentTask;
        public object t_stackGuard;
        public object s_createContingentProperties;
        public object _factory;
        public object _completedTask;
        public object s_IsExceptionObservedByParentPredicate;
        public object s_ecCallback;
        public object s_IsTaskContinuationNullPredicate;
        public object s_currentActiveTasks;
        public object s_activeTasksLock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69BD880
        public void TaskConstructorCore(){} // RVA: 0x69BD980
        public void AssignCancellationToken(){} // RVA: 0x69BDCD0
        public void TaskCancelCallback(){} // RVA: 0x69BE0E0
        public void TrySetCanceled(){} // RVA: 0x69BE200
        public void TrySetException(){} // RVA: 0x69BE380
        public void get_Options(){} // RVA: 0x69BE3F0
        public void OptionsMethod(){} // RVA: 0x2F70100
        public void AtomicStateUpdate(){} // RVA: 0x69BE530
        public void SetNotificationForWaitCompletion(){} // RVA: 0x69BE640
        public void NotifyDebuggerOfWaitCompletionIfNecessary(){} // RVA: 0x69BE730
        public void AnyTaskRequiresNotifyDebuggerOfWaitCompletion(){} // RVA: 0x69BE780
        public void get_IsWaitNotificationEnabledOrNotRanToCompletion(){} // RVA: 0x69BE820
        public void get_ShouldNotifyDebuggerOfWaitCompletion(){} // RVA: 0x69BE840
        public void get_IsWaitNotificationEnabled(){} // RVA: 0x69BE840
        public void NotifyDebuggerOfWaitCompletion(){} // RVA: 0x69BE860
        public void MarkStarted(){} // RVA: 0x69BE890
        public void AddNewChild(){} // RVA: 0x69BE8B0
        public void DisregardChild(){} // RVA: 0x69BE900
        public void Start(){} // RVA: 0x69BE930
        public void RunSynchronously(){} // RVA: 0x69BEB60
        public void InternalRunSynchronously(){} // RVA: 0x69BEBD0
        public void InternalStartNew(){} // RVA: 0x69BEF40
        public void get_Id(){} // RVA: 0x69BF100
        public void get_CurrentId(){} // RVA: 0x69BF190
        public void get_InternalCurrent(){} // RVA: 0x69BF210
        public void InternalCurrentIfAttached(){} // RVA: 0x69BF2B0
        public void get_CurrentStackGuard(){} // RVA: 0x69BF310
        public void get_Exception(){} // RVA: 0x69BF450
        public void get_Status(){} // RVA: 0x69BF480
        public void get_IsCanceled(){} // RVA: 0x69BF4E0
        public void get_IsCancellationRequested(){} // RVA: 0x69BF500
        public void EnsureContingentPropertiesInitialized(){} // RVA: 0x69BF590
        public void EnsureContingentPropertiesInitializedCore(){} // RVA: 0x69BF6E0
        public void get_CancellationToken(){} // RVA: 0x69BF820
        public void get_IsCancellationAcknowledged(){} // RVA: 0x69BF840
        public void get_IsCompleted(){} // RVA: 0x69BF860
        public void IsCompletedMethod(){} // RVA: 0x69BF8C0
        public void get_IsCompletedSuccessfully(){} // RVA: 0x69BF8D0
        public void get_CreationOptions(){} // RVA: 0x69BF8F0
        public void System.IAsyncResult.get_AsyncWaitHandle(){} // RVA: 0x69BF940
        public void get_AsyncState(){} // RVA: 0xB700F0
        public void System.IAsyncResult.get_CompletedSynchronously(){} // RVA: 0xB43320
        public void get_ExecutingTaskScheduler(){} // RVA: 0xB70160
        public void get_Factory(){} // RVA: 0x69BF9F0
        public void get_CompletedTask(){} // RVA: 0x69BFA50
        public void get_CompletedEvent(){} // RVA: 0x69BFAB0
        public void get_ExceptionRecorded(){} // RVA: 0x69BFC30
        public void get_IsFaulted(){} // RVA: 0x69BFC80
        public void get_CapturedContext(){} // RVA: 0x69BFCA0
        public void set_CapturedContext(){} // RVA: 0x69BFD20
        public void Dispose(){} // RVA: 0x69BFE70
        public void ScheduleAndStart(){} // RVA: 0x69BFFA0
        public void AddException(){} // RVA: 0x69C0130
        public void GetExceptions(){} // RVA: 0x69C0410
        public void GetExceptionDispatchInfos(){} // RVA: 0x69C05E0
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x69C0860
        public void ThrowIfExceptional(){} // RVA: 0x69C0890
        public void UpdateExceptionObservedStatus(){} // RVA: 0x69C08E0
        public void get_IsExceptionObservedByParent(){} // RVA: 0x69C0A00
        public void get_IsDelegateInvoked(){} // RVA: 0x69C0A20
        public void Finish(){} // RVA: 0x69C0A40
        public void FinishStageTwo(){} // RVA: 0x69C0C40
        public void FinishStageThree(){} // RVA: 0x69C0D80
        public void ProcessChildCompletion(){} // RVA: 0x69C0E70
        public void AddExceptionsFromChildren(){} // RVA: 0x69C1110
        public void Execute(){} // RVA: 0x69C14E0
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x69C1520
        public void ExecuteEntry(){} // RVA: 0x69C1530
        public void ExecutionContextCallback(){} // RVA: 0x69C1710
        public void InnerInvoke(){} // RVA: 0x69C17A0
        public void HandleException(){} // RVA: 0x69C1840
        public void GetAwaiter(){} // RVA: 0x18D7680
        public void ConfigureAwait(){} // RVA: 0x69C1960
        public void SetContinuationForAwait(){} // RVA: 0x69C1980
        public void Yield(){} // RVA: 0xB43320
        public void Wait(){} // RVA: 0x69C1C60
        public void WrappedTryRunInline(){} // RVA: 0x69C1DA0
        public void InternalWait(){} // RVA: 0x69C1E40
        public void SpinThenBlockingWait(){} // RVA: 0x69C2310
        public void SpinWait(){} // RVA: 0x69C2720
        public void InternalCancel(){} // RVA: 0x69C28D0
        public void RecordInternalCancellationRequest(){} // RVA: 0x69C2C10
        public void CancellationCleanupLogic(){} // RVA: 0x69C2D40
        public void SetCancellationAcknowledged(){} // RVA: 0x69C2E00
        public void FinishContinuations(){} // RVA: 0x69C2E20
        public void LogFinishCompletionNotification(){} // RVA: 0x69C34B0
        public void ContinueWith(){} // RVA: 0xA94080
        public void CreationOptionsFromContinuationOptions(){} // RVA: 0x69C3970
        public void ContinueWithCore(){} // RVA: 0x69C3AD0
        public void AddCompletionAction(){} // RVA: 0x69C3E50
        public void AddTaskContinuationComplex(){} // RVA: 0x69C3ED0
        public void AddTaskContinuation(){} // RVA: 0x69C4290
        public void RemoveContinuation(){} // RVA: 0x69C43A0
        public void FromResult(){} // RVA: 0x2A325D0
        public void FromException(){} // RVA: 0x2A30850
        public void FromCancellation(){} // RVA: 0x2A1A0C0
        public void FromCanceled(){} // RVA: 0x2A00D90
        public void Run(){} // RVA: 0x2A32A50
        public void Delay(){} // RVA: 0x69C4EF0
        public void WhenAll(){} // RVA: 0x87C5C0
        public void InternalWhenAll(){} // RVA: 0x87C5C0
        public void WhenAny(){} // RVA: 0x69C58B0
        public void CreateUnwrapPromise(){} // RVA: 0x29E3890
        public void AddToActiveTasks(){} // RVA: 0x69C5BB0
        public void RemoveFromActiveTasks(){} // RVA: 0x69C5D90
        public void MarkAborted(){} // RVA: 0xB43310
        public void ExecuteWithThreadLocal(){} // RVA: 0x69C5F40
        public void .cctor(){} // RVA: 0x69C6260
    }

    public class TaskCompletionSource`1 : Object
    {
        public object _task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x899290
        public void get_Task(){} // RVA: 0x87C0A0
        public void SpinUntilCompleted(){} // RVA: 0x894290
        public void TrySetException(){} // RVA: 0x87D350
        public void SetException(){} // RVA: 0x894320
        public void TrySetResult(){} // RVA: 0xA94080
        public void SetResult(){} // RVA: 0xA94080
        public void TrySetCanceled(){} // RVA: 0xA94080
        public void SetCanceled(){} // RVA: 0x894290
    }

    public class TaskCompletionSource`1 : Object
    {
        public object _task;

        // ── Methods ──
        public void TrySetResult(){} // RVA: 0x4BB9360
        public void .ctor(){} // RVA: 0x4BB90C0
        public void get_Task(){} // RVA: 0xB5DBF0
        public void SpinUntilCompleted(){} // RVA: 0x4BB9180
        public void TrySetException(){} // RVA: 0x4BB9290
        public void SetException(){} // RVA: 0x4BB92F0
        public void SetResult(){} // RVA: 0x4BB93A0
        public void TrySetCanceled(){} // RVA: 0x4BB9490
        public void SetCanceled(){} // RVA: 0x4BB9520
    }

    public class TaskCompletionSource`1 : Object
    {
        public object _task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BB9660
        public void get_Task(){} // RVA: 0xB5DBF0
        public void SpinUntilCompleted(){} // RVA: 0x4BB9720
        public void TrySetException(){} // RVA: 0x4BB9830
        public void SetException(){} // RVA: 0x4BB9890
        public void TrySetResult(){} // RVA: 0x4BB9900
        public void SetResult(){} // RVA: 0x4BB9940
        public void TrySetCanceled(){} // RVA: 0x4BB9990
        public void SetCanceled(){} // RVA: 0x4BB9A20
    }

    public class TaskCompletionSource`1 : Object
    {
        public object _task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BB85C0
        public void get_Task(){} // RVA: 0xB5DBF0
        public void SpinUntilCompleted(){} // RVA: 0x4BB8680
        public void TrySetException(){} // RVA: 0x4BB8790
        public void SetException(){} // RVA: 0x4BB87F0
        public void TrySetResult(){} // RVA: 0x4BB8860
        public void SetResult(){} // RVA: 0x4BB88A0
        public void TrySetCanceled(){} // RVA: 0x4BB8970
        public void SetCanceled(){} // RVA: 0x4BB8A00
    }

    public class TaskCompletionSource`1 : Object
    {
        public object _task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BB6DE0
        public void get_Task(){} // RVA: 0xB5DBF0
        public void TrySetResult(){} // RVA: 0x4BB7080
        public void SpinUntilCompleted(){} // RVA: 0x4BB6EA0
        public void TrySetException(){} // RVA: 0x4BB6FB0
        public void SetException(){} // RVA: 0x4BB7010
        public void SetResult(){} // RVA: 0x4BB70C0
        public void TrySetCanceled(){} // RVA: 0x4BB71A0
        public void SetCanceled(){} // RVA: 0x4BB7230
    }

    public class TaskCompletionSource`1 : Object
    {
        public object _task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BB90C0
        public void get_Task(){} // RVA: 0xB5DBF0
        public void SpinUntilCompleted(){} // RVA: 0x4BB9180
        public void TrySetException(){} // RVA: 0x4BB9290
        public void SetException(){} // RVA: 0x4BB92F0
        public void TrySetResult(){} // RVA: 0x4BB9360
        public void SetResult(){} // RVA: 0x4BB93A0
        public void TrySetCanceled(){} // RVA: 0x4BB9490
        public void SetCanceled(){} // RVA: 0x4BB9520
    }

    public class TaskContinuation : Object
    {
        // ── Methods ──
        public void Run(){} // RVA: 0x899250
        public void InlineIfPossibleOrElseQueue(){} // RVA: 0x69C7830
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TaskExceptionHolder : Object
    {
        public object s_failFastOnUnobservedException;
        public object m_task;
        public object m_faultExceptions;
        public object m_cancellationException;
        public object m_isHandled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ShouldFailFastOnUnobservedException(){} // RVA: 0xB43320
        public void Finalize(){} // RVA: 0x66AA310
        public void get_ContainsFaultList(){} // RVA: 0x66AA540
        public void Add(){} // RVA: 0x66AA550
        public void SetCancellationException(){} // RVA: 0x66AA570
        public void AddFaultException(){} // RVA: 0x66AA770
        public void MarkAsUnhandled(){} // RVA: 0x66AAD70
        public void MarkAsHandled(){} // RVA: 0x66AADE0
        public void CreateExceptionObject(){} // RVA: 0x66AAE60
        public void GetExceptionDispatchInfos(){} // RVA: 0x66AB0F0
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0xB700F0
        public void .cctor(){} // RVA: 0x66AB210
    }

    public class TaskExtensions : Object
    {
        // ── Methods ──
        public void Unwrap(){} // RVA: 0x87C5C0
    }

    public class TaskFactory : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x66AB250
        public void .ctor(){} // RVA: 0x4BBA6D0
        public void CheckCreationOptions(){} // RVA: 0x66AB340
        public void get_Scheduler(){} // RVA: 0xB465B0
        public void StartNew(){} // RVA: 0x2A34290
        public void FromAsync(){} // RVA: 0xA94080
        public void CheckFromAsyncOptions(){} // RVA: 0x66AB580
        public void CommonCWAnyLogic(){} // RVA: 0x66AB6B0
        public void CheckMultiTaskContinuationOptions(){} // RVA: 0x66AB990
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0xA94080
        public void StartNew(){} // RVA: 0xA94080
        public void FromAsync(){} // RVA: 0xA94080
        public void FromAsyncImpl(){} // RVA: 0xA94080
        public void FromAsyncTrim(){} // RVA: 0xA94080
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA6D0
        public void FromAsync(){} // RVA: 0xA94080
        public void GetDefaultScheduler(){} // RVA: 0x4C9ED30
        public void StartNew(){} // RVA: 0x4C9EF60
        public void FromAsyncCoreLogic(){} // RVA: 0x4C9F050
        public void FromAsyncImpl(){} // RVA: 0x2CFCF80
        public void FromAsyncTrim(){} // RVA: 0xA94080
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void StartNew(){} // RVA: 0x4BBBE50
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
        public void StartNew(){} // RVA: 0x4BBBE50
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void StartNew(){} // RVA: 0x4BBBE50
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void StartNew(){} // RVA: 0x4BBBE50
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void StartNew(){} // RVA: 0x4BBBE50
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void FromAsync(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x4BBA6D0
        public void GetDefaultScheduler(){} // RVA: 0x4CA9CF0
        public void StartNew(){} // RVA: 0x4CA9F20
        public void FromAsyncCoreLogic(){} // RVA: 0x4CAA010
        public void FromAsyncImpl(){} // RVA: 0xA94080
        public void FromAsyncTrim(){} // RVA: 0xA94080
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void StartNew(){} // RVA: 0x4BBBE50
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void StartNew(){} // RVA: 0x4BBBE50
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void StartNew(){} // RVA: 0x4BBBE50
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCancellationToken;
        public object m_defaultScheduler;
        public object m_defaultCreationOptions;
        public object m_defaultContinuationOptions;

        // ── Methods ──
        public void StartNew(){} // RVA: 0x4BBBE50
        public void .ctor(){} // RVA: 0x4BBA620
    }

    public class TaskReplicator : Object
    {
        public object _scheduler;
        public object _stopOnFirstFailure;
        public object _pendingReplicas;
        public object _exceptions;
        public object _stopReplicating;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69BC020
        public void Run(){} // RVA: 0x2A34A80
        public void GenerateCooperativeMultitaskingTaskTimeout(){} // RVA: 0x69BC1A0
    }

    public class TaskScheduler : Object
    {
        public object s_defaultTaskScheduler;
        public object s_taskSchedulerIdCounter;
        public object m_taskSchedulerId;
        public object _unobservedTaskException;
        public object _unobservedTaskExceptionLockObject;

        // ── Methods ──
        public void QueueTask(){} // RVA: 0x894320
        public void TryExecuteTaskInline(){} // RVA: 0x87F360
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x66ABE00
        public void TryRunInline(){} // RVA: 0x66ABE10
        public void TryDequeue(){} // RVA: 0xB43320
        public void NotifyWorkItemProgress(){} // RVA: 0xB43310
        public void get_RequiresAtomicStartTransition(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0xB43310
        public void get_Default(){} // RVA: 0x66AC040
        public void get_Current(){} // RVA: 0x66AC0A0
        public void get_InternalCurrent(){} // RVA: 0x66AC150
        public void FromCurrentSynchronizationContext(){} // RVA: 0x66AC200
        public void get_Id(){} // RVA: 0x66AC320
        public void TryExecuteTask(){} // RVA: 0x66AC3C0
        public void add_UnobservedTaskException(){} // RVA: 0x66AC440
        public void remove_UnobservedTaskException(){} // RVA: 0x66AC680
        public void PublishUnobservedTaskException(){} // RVA: 0x66AC870
        public void .cctor(){} // RVA: 0x66AC990
    }

    public class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
    {
        public object m_scheduler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69C7BF0
        public void Run(){} // RVA: 0x69C82D0
    }

    public class Task[] : Array
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

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void StartNew(){} // RVA: 0xA94080
        public void TrySetResult(){} // RVA: 0xA94080
        public void DangerousSetResult(){} // RVA: 0xA94080
        public void get_Result(){} // RVA: 0xA94080
        public void get_ResultOnSuccess(){} // RVA: 0xA94080
        public void GetResultCore(){} // RVA: 0xA94080
        public void get_Factory(){} // RVA: 0x87C0D0
        public void InnerInvoke(){} // RVA: 0x894290
        public void GetAwaiter(){} // RVA: 0xA94080
        public void ConfigureAwait(){} // RVA: 0xA94080
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E51C00
        public void StartNew(){} // RVA: 0x4E51EE0
        public void TrySetResult(){} // RVA: 0x4E52080
        public void DangerousSetResult(){} // RVA: 0x4E52170
        public void get_Result(){} // RVA: 0x4D805E0
        public void get_ResultOnSuccess(){} // RVA: 0xE32C80
        public void GetResultCore(){} // RVA: 0x4D80710
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4D80830
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void .ctor(){} // RVA: 0x4E15F50
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void StartNew(){} // RVA: 0x4E16230
        public void DangerousSetResult(){} // RVA: 0x4CBDAA0
        public void get_Result(){} // RVA: 0x4CBDB30
        public void GetResultCore(){} // RVA: 0x4CBDC90
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4CBE000
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x4E58330
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void StartNew(){} // RVA: 0x4E58AC0
        public void DangerousSetResult(){} // RVA: 0x4E58DA0
        public void get_Result(){} // RVA: 0x4E58E40
        public void GetResultCore(){} // RVA: 0x4CD4120
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E58E80
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E6AC40
        public void TrySetResult(){} // RVA: 0x4E368F0
        public void StartNew(){} // RVA: 0x4E6AF20
        public void DangerousSetResult(){} // RVA: 0x4E369E0
        public void get_Result(){} // RVA: 0x4E36A10
        public void get_ResultOnSuccess(){} // RVA: 0xC00EC0
        public void GetResultCore(){} // RVA: 0x4E36B40
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E36C60
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void .ctor(){} // RVA: 0x4E587E0
        public void StartNew(){} // RVA: 0x4E58AC0
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void DangerousSetResult(){} // RVA: 0x4E58DA0
        public void get_Result(){} // RVA: 0x4E58E40
        public void GetResultCore(){} // RVA: 0x4CD4120
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E58E80
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void GetAwaiter(){} // RVA: 0x4CBE190
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void GetAwaiter(){} // RVA: 0x4CBE190
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void .ctor(){} // RVA: 0x4CBFFE0
        public void StartNew(){} // RVA: 0x4CC02C0
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void DangerousSetResult(){} // RVA: 0x4CBDAA0
        public void get_Result(){} // RVA: 0x4CBDB30
        public void GetResultCore(){} // RVA: 0x4CBDC90
        public void InnerInvoke(){} // RVA: 0x4CBE000
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E71AC0
        public void TrySetResult(){} // RVA: 0x4E57780
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4D15480
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void .ctor(){} // RVA: 0x4CBFFE0
        public void StartNew(){} // RVA: 0x4CC02C0
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void DangerousSetResult(){} // RVA: 0x4CBDAA0
        public void get_Result(){} // RVA: 0x4CBDB30
        public void GetResultCore(){} // RVA: 0x4CBDC90
        public void InnerInvoke(){} // RVA: 0x4CBE000
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E6D1A0
        public void TrySetResult(){} // RVA: 0x4E237F0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CDE990
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E72C10
        public void TrySetResult(){} // RVA: 0x4E24CE0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4E2C5C0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E73D70
        public void TrySetResult(){} // RVA: 0x4E185B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4D226E0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E74EB0
        public void TrySetResult(){} // RVA: 0x4CDCE90
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CF6420
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CCE2D0
        public void ContinueWith(){} // RVA: 0x2D001E0
        public void .ctor(){} // RVA: 0x4E43770
        public void TrySetResult(){} // RVA: 0x4E3B0D0
        public void StartNew(){} // RVA: 0x4E43A50
        public void DangerousSetResult(){} // RVA: 0x4E3B1C0
        public void get_Result(){} // RVA: 0x4CCE1A0
        public void GetResultCore(){} // RVA: 0x4CCE2E0
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4CCE400
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4DFC050
        public void TrySetResult(){} // RVA: 0x4DFC980
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void GetAwaiter(){} // RVA: 0x4CBE190
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void GetAwaiter(){} // RVA: 0x4CBE190
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xC00EC0
        public void .ctor(){} // RVA: 0x4E37950
        public void TrySetResult(){} // RVA: 0x4E37DD0
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void StartNew(){} // RVA: 0x4E37C30
        public void DangerousSetResult(){} // RVA: 0x4E37EC0
        public void get_Result(){} // RVA: 0x4E36A10
        public void GetResultCore(){} // RVA: 0x4E36B40
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E36C60
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void StartNew(){} // RVA: 0x4E58AC0
        public void .ctor(){} // RVA: 0x4E587E0
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void DangerousSetResult(){} // RVA: 0x4E58DA0
        public void get_Result(){} // RVA: 0x4E58E40
        public void GetResultCore(){} // RVA: 0x4CD4120
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E58E80
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E1C460
        public void get_ResultOnSuccess(){} // RVA: 0x4CD0AB0
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void TrySetResult(){} // RVA: 0x4CD7580
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E58330
        public void TrySetResult(){} // RVA: 0x4E58C60
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E68B00
        public void TrySetResult(){} // RVA: 0x4E368F0
        public void StartNew(){} // RVA: 0x4E68DE0
        public void DangerousSetResult(){} // RVA: 0x4E369E0
        public void get_Result(){} // RVA: 0x4E36A10
        public void get_ResultOnSuccess(){} // RVA: 0xC00EC0
        public void GetResultCore(){} // RVA: 0x4E36B40
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E36C60
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E6BD90
        public void StartNew(){} // RVA: 0x4E6C0A0
        public void TrySetResult(){} // RVA: 0x4E6C270
        public void DangerousSetResult(){} // RVA: 0x4E6C3F0
        public void get_Result(){} // RVA: 0xAD0950
        public void get_ResultOnSuccess(){} // RVA: 0xAD0950
        public void GetResultCore(){} // RVA: 0xAD0950
        public void get_Factory(){} // RVA: 0x4E6C7E0
        public void InnerInvoke(){} // RVA: 0x4E6C9B0
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_Result(){} // RVA: 0x4E58E40
        public void .ctor(){} // RVA: 0x4E587E0
        public void StartNew(){} // RVA: 0x4E58AC0
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void DangerousSetResult(){} // RVA: 0x4E58DA0
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void GetResultCore(){} // RVA: 0x4CD4120
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E58E80
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void .ctor(){} // RVA: 0x4CBFFE0
        public void StartNew(){} // RVA: 0x4CC02C0
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void DangerousSetResult(){} // RVA: 0x4CBDAA0
        public void get_Result(){} // RVA: 0x4CBDB30
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void GetResultCore(){} // RVA: 0x4CBDC90
        public void InnerInvoke(){} // RVA: 0x4CBE000
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CBFFE0
        public void StartNew(){} // RVA: 0x4CC02C0
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void DangerousSetResult(){} // RVA: 0x4CBDAA0
        public void get_Result(){} // RVA: 0x4CBDB30
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void GetResultCore(){} // RVA: 0x4CBDC90
        public void InnerInvoke(){} // RVA: 0x4CBE000
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
        public void get_Factory(){} // RVA: 0x4CBDDC0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void .ctor(){} // RVA: 0x4CBFFE0
        public void StartNew(){} // RVA: 0x4CC02C0
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void DangerousSetResult(){} // RVA: 0x4CBDAA0
        public void get_Result(){} // RVA: 0x4CBDB30
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void GetResultCore(){} // RVA: 0x4CBDC90
        public void InnerInvoke(){} // RVA: 0x4CBE000
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void .ctor(){} // RVA: 0x4CBFFE0
        public void StartNew(){} // RVA: 0x4CC02C0
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void DangerousSetResult(){} // RVA: 0x4CBDAA0
        public void get_Result(){} // RVA: 0x4CBDB30
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void GetResultCore(){} // RVA: 0x4CBDC90
        public void InnerInvoke(){} // RVA: 0x4CBE000
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E587E0
        public void StartNew(){} // RVA: 0x4E58AC0
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void DangerousSetResult(){} // RVA: 0x4E58DA0
        public void get_Result(){} // RVA: 0x4E58E40
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void GetResultCore(){} // RVA: 0x4CD4120
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E58E80
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E6BD90
        public void StartNew(){} // RVA: 0x4E6C0A0
        public void TrySetResult(){} // RVA: 0x4E6C270
        public void DangerousSetResult(){} // RVA: 0x4E6C3F0
        public void get_Result(){} // RVA: 0xAD0950
        public void get_ResultOnSuccess(){} // RVA: 0xAD0950
        public void GetResultCore(){} // RVA: 0xAD0950
        public void get_Factory(){} // RVA: 0x4E6C7E0
        public void InnerInvoke(){} // RVA: 0x4E6C9B0
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E6BD90
        public void StartNew(){} // RVA: 0x4E6C0A0
        public void TrySetResult(){} // RVA: 0x4E6C270
        public void DangerousSetResult(){} // RVA: 0x4E6C3F0
        public void get_Result(){} // RVA: 0xAD0950
        public void get_ResultOnSuccess(){} // RVA: 0xAD0950
        public void GetResultCore(){} // RVA: 0xAD0950
        public void get_Factory(){} // RVA: 0x4E6C7E0
        public void InnerInvoke(){} // RVA: 0x4E6C9B0
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E587E0
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void StartNew(){} // RVA: 0x4E58AC0
        public void DangerousSetResult(){} // RVA: 0x4E58DA0
        public void get_Result(){} // RVA: 0x4E58E40
        public void GetResultCore(){} // RVA: 0x4CD4120
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E58E80
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ContinueWith(){} // RVA: 0xA94080
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void .ctor(){} // RVA: 0x4CD3610
        public void StartNew(){} // RVA: 0x4CD3D20
        public void DangerousSetResult(){} // RVA: 0x4CD3FB0
        public void get_Result(){} // RVA: 0x4CD3FF0
        public void GetResultCore(){} // RVA: 0x4CD4120
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4CD4240
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ContinueWith(){} // RVA: 0xA94080
        public void TrySetResult(){} // RVA: 0x4CD3EC0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void .ctor(){} // RVA: 0x4E64380
        public void StartNew(){} // RVA: 0x4E64660
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void DangerousSetResult(){} // RVA: 0x4CBDAA0
        public void get_Result(){} // RVA: 0x4CBDB30
        public void GetResultCore(){} // RVA: 0x4CBDC90
        public void InnerInvoke(){} // RVA: 0x4CBE000
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void StartNew(){} // RVA: 0x4E58AC0
        public void .ctor(){} // RVA: 0x4E587E0
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void DangerousSetResult(){} // RVA: 0x4E58DA0
        public void get_Result(){} // RVA: 0x4E58E40
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void GetResultCore(){} // RVA: 0x4CD4120
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E58E80
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E587E0
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void StartNew(){} // RVA: 0x4E58AC0
        public void DangerousSetResult(){} // RVA: 0x4E58DA0
        public void get_Result(){} // RVA: 0x4E58E40
        public void GetResultCore(){} // RVA: 0x4CD4120
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E58E80
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4E587E0
        public void TrySetResult(){} // RVA: 0x4E58C60
        public void StartNew(){} // RVA: 0x4E58AC0
        public void DangerousSetResult(){} // RVA: 0x4E58DA0
        public void get_Result(){} // RVA: 0x4E58E40
        public void get_ResultOnSuccess(){} // RVA: 0xBE58B0
        public void GetResultCore(){} // RVA: 0x4CD4120
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void InnerInvoke(){} // RVA: 0x4E58E80
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void .ctor(){} // RVA: 0x4CBFFE0
        public void StartNew(){} // RVA: 0x4CC02C0
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void DangerousSetResult(){} // RVA: 0x4CBDAA0
        public void get_Result(){} // RVA: 0x4CBDB30
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void GetResultCore(){} // RVA: 0x4CBDC90
        public void InnerInvoke(){} // RVA: 0x4CBE000
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void .ctor(){} // RVA: 0x4CBFFE0
        public void StartNew(){} // RVA: 0x4CC02C0
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void DangerousSetResult(){} // RVA: 0x4CBDAA0
        public void get_Result(){} // RVA: 0x4CBDB30
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void GetResultCore(){} // RVA: 0x4CBDC90
        public void InnerInvoke(){} // RVA: 0x4CBE000
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1 : Task
    {
        public object m_result;
        public object s_defaultFactory;

        // ── Methods ──
        public void get_Factory(){} // RVA: 0x4CBDDC0
        public void .ctor(){} // RVA: 0x4CBFFE0
        public void StartNew(){} // RVA: 0x4CC02C0
        public void TrySetResult(){} // RVA: 0x4CBD950
        public void DangerousSetResult(){} // RVA: 0x4CBDAA0
        public void get_Result(){} // RVA: 0x4CBDB30
        public void get_ResultOnSuccess(){} // RVA: 0x4CBDC80
        public void GetResultCore(){} // RVA: 0x4CBDC90
        public void InnerInvoke(){} // RVA: 0x4CBE000
        public void GetAwaiter(){} // RVA: 0x4CBE190
        public void ConfigureAwait(){} // RVA: 0x4CBE1F0
        public void ContinueWith(){} // RVA: 0xA94080
    }

    public class Task`1[] : Array
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

    public class ThreadPoolTaskScheduler : TaskScheduler
    {
        public object s_longRunningThreadWork;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66AD0A0
        public void QueueTask(){} // RVA: 0x66AD0F0
        public void TryExecuteTaskInline(){} // RVA: 0x66AD4C0
        public void TryDequeue(){} // RVA: 0x66AD590
        public void NotifyWorkItemProgress(){} // RVA: 0x66AD5A0
        public void get_RequiresAtomicStartTransition(){} // RVA: 0xB43320
        public void .cctor(){} // RVA: 0x66AD610
    }

}