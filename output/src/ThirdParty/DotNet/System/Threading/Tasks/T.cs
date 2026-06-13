// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 100
// Methods: 1031

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class Task
    {
        public int s_taskIdCounter;
        public int m_taskId; // 0x10
        public System.Delegate m_action; // 0x18
        public object m_stateObject; // 0x20
        public System.Threading.Tasks.TaskScheduler m_taskScheduler; // 0x28
        public System.Threading.Tasks.Task m_parent; // 0x30
        public int m_stateFlags; // 0x38
        public int OptionsMask;
        public int TASK_STATE_STARTED;
        public int TASK_STATE_DELEGATE_INVOKED;
        public int TASK_STATE_DISPOSED;
        public int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT;
        public int TASK_STATE_CANCELLATIONACKNOWLEDGED;
        public int TASK_STATE_FAULTED;
        public int TASK_STATE_CANCELED;
        public int TASK_STATE_WAITING_ON_CHILDREN;
        public int TASK_STATE_RAN_TO_COMPLETION;
        public int TASK_STATE_WAITINGFORACTIVATION;
        public int TASK_STATE_COMPLETION_RESERVED;
        public int TASK_STATE_THREAD_WAS_ABORTED;
        public int TASK_STATE_WAIT_COMPLETION_NOTIFICATION;
        public int TASK_STATE_COMPLETED_MASK;
        public int CANCELLATION_REQUESTED;
        public object m_continuationObject; // 0x40
        public object s_taskCompletionSentinel; // 0x8
        public bool s_asyncDebuggingEnabled; // 0x10
        public ContingentProperties m_contingentProperties; // 0x48
        public System.Action`1<object> s_taskCancelCallback; // 0x18
        public System.Threading.Tasks.Task t_currentTask; // 0xFFFFFFFF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F46140 | overloaded x7
        public void TaskConstructorCore(){} // RVA: 0x5F46240
        public void AssignCancellationToken(){} // RVA: 0x5F46590
        public void TaskCancelCallback(){} // RVA: 0x5F469A0
        public void TrySetCanceled(){} // RVA: 0x5F46AF0 | overloaded x2
        public void TrySetException(){} // RVA: 0x5F46C70
        public void get_Options(){} // RVA: 0x5F46CE0
        public void OptionsMethod(){} // RVA: 0x2572DF0
        public void AtomicStateUpdate(){} // RVA: 0x5F46E20 | overloaded x2
        public void SetNotificationForWaitCompletion(){} // RVA: 0x5F46F30
        public void NotifyDebuggerOfWaitCompletionIfNecessary(){} // RVA: 0x5F47020
        public void AnyTaskRequiresNotifyDebuggerOfWaitCompletion(){} // RVA: 0x5F47070
        public void get_IsWaitNotificationEnabledOrNotRanToCompletion(){} // RVA: 0x5F470F0
        public void get_ShouldNotifyDebuggerOfWaitCompletion(){} // RVA: 0x5F47110
        public void get_IsWaitNotificationEnabled(){} // RVA: 0x5F47110
        public void NotifyDebuggerOfWaitCompletion(){} // RVA: 0x5F47130
        public void MarkStarted(){} // RVA: 0x5F47160
        public void AddNewChild(){} // RVA: 0x5F47180
        public void DisregardChild(){} // RVA: 0x5F471D0
        public void Start(){} // RVA: 0x5F47200
        public void RunSynchronously(){} // RVA: 0x5F47430
        public void InternalRunSynchronously(){} // RVA: 0x5F474A0
        public void InternalStartNew(){} // RVA: 0x5F47810
        public void get_Id(){} // RVA: 0x5F479D0
        public void get_CurrentId(){} // RVA: 0x5F47A60
        public void get_InternalCurrent(){} // RVA: 0x5F47AE0
        public void InternalCurrentIfAttached(){} // RVA: 0x5F47B80
        public void get_CurrentStackGuard(){} // RVA: 0x5F47BE0
        public void get_Exception(){} // RVA: 0x5F47D20
        public void get_Status(){} // RVA: 0x5F47D50
        public void get_IsCanceled(){} // RVA: 0x5F47DB0
        public void get_IsCancellationRequested(){} // RVA: 0x5F47DD0
        public void EnsureContingentPropertiesInitialized(){} // RVA: 0x5F47E60
        public void EnsureContingentPropertiesInitializedCore(){} // RVA: 0x5F47FB0
        public void get_CancellationToken(){} // RVA: 0x5F480F0
        public void get_IsCancellationAcknowledged(){} // RVA: 0x5F48110
        public void get_IsCompleted(){} // RVA: 0x5F48130
        public void IsCompletedMethod(){} // RVA: 0x5F48190
        public void get_IsCompletedSuccessfully(){} // RVA: 0x5F481A0
        public void get_CreationOptions(){} // RVA: 0x5F481C0
        public void System.IAsyncResult.get_AsyncWaitHandle(){} // RVA: 0x5F48210
        public void get_AsyncState(){} // RVA: 0x30B0C0
        public void System.IAsyncResult.get_CompletedSynchronously(){} // RVA: 0x2DD320
        public void get_ExecutingTaskScheduler(){} // RVA: 0x30B130
        public void get_Factory(){} // RVA: 0x5F482C0
        public void get_CompletedTask(){} // RVA: 0x5F48320
        public void get_CompletedEvent(){} // RVA: 0x5F48380
        public void get_ExceptionRecorded(){} // RVA: 0x5F48500
        public void get_IsFaulted(){} // RVA: 0x5F48550
        public void get_CapturedContext(){} // RVA: 0x5F48570
        public void set_CapturedContext(){} // RVA: 0x5F485F0
        public void Dispose(){} // RVA: 0x5F48740 | overloaded x2
        public void ScheduleAndStart(){} // RVA: 0x5F48870
        public void AddException(){} // RVA: 0x5F48A00 | overloaded x2
        public void GetExceptions(){} // RVA: 0x5F48D10
        public void GetExceptionDispatchInfos(){} // RVA: 0x5F48EE0
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x5F49170
        public void ThrowIfExceptional(){} // RVA: 0x5F491A0
        public void UpdateExceptionObservedStatus(){} // RVA: 0x5F491F0
        public void get_IsExceptionObservedByParent(){} // RVA: 0x5F49310
        public void get_IsDelegateInvoked(){} // RVA: 0x5F49330
        public void Finish(){} // RVA: 0x5F49350
        public void FinishStageTwo(){} // RVA: 0x5F49580
        public void FinishStageThree(){} // RVA: 0x5F496C0
        public void ProcessChildCompletion(){} // RVA: 0x5F497B0
        public void AddExceptionsFromChildren(){} // RVA: 0x5F49A80
        public void Execute(){} // RVA: 0x5F49E80
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x5F49EC0
        public void ExecuteEntry(){} // RVA: 0x5F49ED0
        public void ExecutionContextCallback(){} // RVA: 0x5F4A0B0
        public void InnerInvoke(){} // RVA: 0x5F4A140
        public void HandleException(){} // RVA: 0x5F4A1E0
        public void GetAwaiter(){} // RVA: 0x10073D0
        public void ConfigureAwait(){} // RVA: 0x5F4A320
        public void SetContinuationForAwait(){} // RVA: 0x5F4A340
        public void Yield(){} // RVA: 0x2DD320
        public void Wait(){} // RVA: 0x5F4A610 | overloaded x3
        public void WrappedTryRunInline(){} // RVA: 0x5F4A750
        public void InternalWait(){} // RVA: 0x5F4A7F0
        public void SpinThenBlockingWait(){} // RVA: 0x5F4ACC0
        public void SpinWait(){} // RVA: 0x5F4B0D0
        public void InternalCancel(){} // RVA: 0x5F4B280
        public void RecordInternalCancellationRequest(){} // RVA: 0x5F4B5C0 | overloaded x3
        public void CancellationCleanupLogic(){} // RVA: 0x5F4B6F0
        public void SetCancellationAcknowledged(){} // RVA: 0x5F4B7B0
        public void FinishContinuations(){} // RVA: 0x5F4B7D0
        public void LogFinishCompletionNotification(){} // RVA: 0x5F4BE80
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x8
        public void CreationOptionsFromContinuationOptions(){} // RVA: 0x5F4C340
        public void ContinueWithCore(){} // RVA: 0x5F4C4A0
        public void AddCompletionAction(){} // RVA: 0x5F4C800 | overloaded x2
        public void AddTaskContinuationComplex(){} // RVA: 0x5F4C880
        public void AddTaskContinuation(){} // RVA: 0x5F4CC70
        public void RemoveContinuation(){} // RVA: 0x5F4CD80
        public void FromResult(){} // RVA: 0x283FA0
        public void FromException(){} // RVA: 0xCE50 | overloaded x2
        public void FromCancellation(){} // RVA: 0xCE50 | overloaded x3
        public void FromCanceled(){} // RVA: 0x1BDB0 | overloaded x2
        public void Run(){} // RVA: 0x12930 | overloaded x6
        public void Delay(){} // RVA: 0x5F4D910 | overloaded x3
        public void WhenAll(){} // RVA: 0xCE50 | overloaded x2
        public void InternalWhenAll(){} // RVA: 0xCE50 | overloaded x2
        public void WhenAny(){} // RVA: 0x5F4E270 | overloaded x2
        public void CreateUnwrapPromise(){} // RVA: 0x1D680
        public void AddToActiveTasks(){} // RVA: 0x5F4E560
        public void RemoveFromActiveTasks(){} // RVA: 0x5F4E790
        public void MarkAborted(){} // RVA: 0x2DD310
        public void ExecuteWithThreadLocal(){} // RVA: 0x5F4E960
        public void .cctor(){} // RVA: 0x5F4EC90
    }

    public class TaskAsyncEnumerableExtensions
    {
        // ── Methods ──
        public void ConfigureAwait(){} // RVA: 0x62BC2A0
    }

    public class TaskAwaiters
    {
        // ── Methods ──
        public void ForceAsync(){} // RVA: 0x10073D0
    }

    public class TaskCanceledException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class TaskCompletionSource`1
    {
        public System.Threading.Tasks.Task`1<T> _task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x40D95D0 | overloaded x4
        public void get_Task(){} // RVA: 0x2F8380
        public void SpinUntilCompleted(){} // RVA: 0x40D96A0
        public void TrySetException(){} // RVA: 0x40D97B0
        public void SetException(){} // RVA: 0x40D9830
        public void TrySetResult(){} // RVA: 0x40D9880
        public void SetResult(){} // RVA: 0x40D9990
        public void TrySetCanceled(){} // RVA: 0x40D9AB0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x40D9B60
    }

    public class TaskCompletionSource`1
    {
        public System.Threading.Tasks.Task`1<T> _task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x40D95D0 | overloaded x4
        public void get_Task(){} // RVA: 0x2F8380
        public void SpinUntilCompleted(){} // RVA: 0x40D96A0
        public void TrySetException(){} // RVA: 0x40D97B0
        public void SetException(){} // RVA: 0x40D9830
        public void TrySetResult(){} // RVA: 0x40D9880
        public void SetResult(){} // RVA: 0x40D9990
        public void TrySetCanceled(){} // RVA: 0x40D9AB0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x40D9B60
    }

    public class TaskCompletionSource`1
    {
        public System.Threading.Tasks.Task`1<T> IsCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BAA0 | overloaded x4
        public void get_Task(){} // RVA: 0xCD60
        public void SpinUntilCompleted(){} // RVA: 0x24A50
        public void TrySetException(){} // RVA: 0xDE40
        public void SetException(){} // RVA: 0x24B10
        public void TrySetResult(){} // RVA: 0x283FA0
        public void SetResult(){} // RVA: 0x283FA0
        public void TrySetCanceled(){} // RVA: 0x283FA0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x24A50
    }

    public class TaskCompletionSource`1
    {
        public System.Threading.Tasks.Task`1<object> _task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x40D8700 | overloaded x4
        public void get_Task(){} // RVA: 0x2F8380
        public void SpinUntilCompleted(){} // RVA: 0x40D87C0
        public void TrySetException(){} // RVA: 0x40D88D0
        public void SetException(){} // RVA: 0x40D8930
        public void TrySetResult(){} // RVA: 0x40D89A0
        public void SetResult(){} // RVA: 0x40D89E0
        public void TrySetCanceled(){} // RVA: 0x40D8AD0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x40D8B60
    }

    public class TaskCompletionSource`1
    {
        public System.Threading.Tasks.Task`1<System.VoidResult> _task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x40D8CA0 | overloaded x4
        public void get_Task(){} // RVA: 0x2F8380
        public void SpinUntilCompleted(){} // RVA: 0x40D8D60
        public void TrySetException(){} // RVA: 0x40D8E70
        public void SetException(){} // RVA: 0x40D8ED0
        public void TrySetResult(){} // RVA: 0x40D8F40
        public void SetResult(){} // RVA: 0x40D8F80
        public void TrySetCanceled(){} // RVA: 0x40D8FD0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x40D9060
    }

    public class TaskCompletionSource`1
    {
        public System.Threading.Tasks.Task`1<short> _task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x40D7C00 | overloaded x4
        public void get_Task(){} // RVA: 0x2F8380
        public void SpinUntilCompleted(){} // RVA: 0x40D7CC0
        public void TrySetException(){} // RVA: 0x40D7DD0
        public void SetException(){} // RVA: 0x40D7E30
        public void TrySetResult(){} // RVA: 0x40D7EA0
        public void SetResult(){} // RVA: 0x40D7EE0
        public void TrySetCanceled(){} // RVA: 0x40D7FB0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x40D8040
    }

    public class TaskCompletionSource`1
    {
        public System.Threading.Tasks.Task`1<bool> _task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x40D7690 | overloaded x4
        public void get_Task(){} // RVA: 0x2F8380
        public void SpinUntilCompleted(){} // RVA: 0x40D7750
        public void TrySetException(){} // RVA: 0x40D7860
        public void SetException(){} // RVA: 0x40D78C0
        public void TrySetResult(){} // RVA: 0x40D7930
        public void SetResult(){} // RVA: 0x40D7970
        public void TrySetCanceled(){} // RVA: 0x40D7A40 | overloaded x2
        public void SetCanceled(){} // RVA: 0x40D7AD0
    }

    public class TaskCompletionSource`1
    {
        public System.Threading.Tasks.Task`1<Result<object>> _task; // 0x10
    }

    public class TaskCompletionSource`1
    {
        public System.Threading.Tasks.Task`1<System.IO.Pipes.VoidResult> _task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x40D91A0 | overloaded x4
        public void get_Task(){} // RVA: 0x2F8380
        public void SpinUntilCompleted(){} // RVA: 0x40D9260
        public void TrySetException(){} // RVA: 0x40D9370
        public void SetException(){} // RVA: 0x40D93D0
        public void TrySetResult(){} // RVA: 0x40D9440
        public void SetResult(){} // RVA: 0x40D9480
        public void TrySetCanceled(){} // RVA: 0x40D94D0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x40D9560
    }

    public class TaskCompletionSource`1
    {
        public System.Threading.Tasks.Task`1<int> _task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x40D8200 | overloaded x4
        public void get_Task(){} // RVA: 0x2F8380
        public void SpinUntilCompleted(){} // RVA: 0x40D82C0
        public void TrySetException(){} // RVA: 0x40D83D0
        public void SetException(){} // RVA: 0x40D8430
        public void TrySetResult(){} // RVA: 0x40D84A0
        public void SetResult(){} // RVA: 0x40D84E0
        public void TrySetCanceled(){} // RVA: 0x40D8530 | overloaded x2
        public void SetCanceled(){} // RVA: 0x40D85C0
    }

    public class TaskCompletionSource`1
    {
        public System.Threading.Tasks.Task`1<System.ValueTuple`2<VRC.Core.ApiWorld,VRC.Core.ApiContainer>> _task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x40D6420 | overloaded x4
        public void get_Task(){} // RVA: 0x2F8380
        public void SpinUntilCompleted(){} // RVA: 0x40D64E0
        public void TrySetException(){} // RVA: 0x40D65F0
        public void SetException(){} // RVA: 0x40D6650
        public void TrySetResult(){} // RVA: 0x40D66C0
        public void SetResult(){} // RVA: 0x40D6700
        public void TrySetCanceled(){} // RVA: 0x40D67E0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x40D6870
    }

    public class TaskContinuation
    {
        // ── Methods ──
        public void Run(){} // RVA: 0x2A620
        public void InlineIfPossibleOrElseQueue(){} // RVA: 0x5F50290
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TaskExceptionHolder
    {
        public bool BinaryStackTraceArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ShouldFailFastOnUnobservedException(){} // RVA: 0x2DD320
        public void Finalize(){} // RVA: 0x5C31EE0
        public void get_ContainsFaultList(){} // RVA: 0x5C32100
        public void Add(){} // RVA: 0x5C32110
        public void SetCancellationException(){} // RVA: 0x5C32130
        public void AddFaultException(){} // RVA: 0x5C32330
        public void MarkAsUnhandled(){} // RVA: 0x5C32940
        public void MarkAsHandled(){} // RVA: 0x5C329B0
        public void CreateExceptionObject(){} // RVA: 0x5C32A30
        public void GetExceptionDispatchInfos(){} // RVA: 0x5C32CC0
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x30B0C0
        public void .cctor(){} // RVA: 0x5C32DE0
    }

    public class TaskExtensions
    {
        // ── Methods ──
        public void Unwrap(){} // RVA: 0xCE50 | overloaded x2
    }

    public class TaskFactory
    {
        public System.Threading.CancellationToken m_defaultCancellationToken; // 0x10

        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x5C32E20
        public void .ctor(){} // RVA: 0x40D9D20 | overloaded x2
        public void CheckCreationOptions(){} // RVA: 0x5C32F10
        public void get_Scheduler(){} // RVA: 0x2E07C0
        public void StartNew(){} // RVA: 0x283FA0 | overloaded x6
        public void FromAsync(){} // RVA: 0x283FA0 | overloaded x4
        public void CheckFromAsyncOptions(){} // RVA: 0x5C33150
        public void CommonCWAnyLogic(){} // RVA: 0x5C33280
        public void CheckMultiTaskContinuationOptions(){} // RVA: 0x5C33560
    }

    public class TaskFactory`1
    {
        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0xCE10
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
        public void StartNew(){} // RVA: 0x283FA0 | overloaded x2
        public void FromAsyncCoreLogic(){}
        public void FromAsync(){} // RVA: 0x283FA0 | overloaded x3
        public void FromAsyncImpl(){} // RVA: 0x283FA0 | overloaded x4
        public void FromAsyncTrim(){} // RVA: 0x283FA0
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskFactory`1
    {
    }

    public class TaskReplicator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F448B0
        public void Run(){} // RVA: 0x2DDE0
        public void GenerateCooperativeMultitaskingTaskTimeout(){} // RVA: 0x5F44A30
    }

    public class TaskScheduler
    {
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Threading.Tasks.TaskScheduler,object> s_activeTaskSchedulers;
        public System.Threading.Tasks.TaskScheduler s_defaultTaskScheduler; // 0x8
        public int s_taskSchedulerIdCounter; // 0x10
        public int m_taskSchedulerId; // 0x10
        public System.EventHandler`1<System.Threading.Tasks.UnobservedTaskExceptionEventArgs> _unobservedTaskException; // 0x18
        public System.Threading.Lock _unobservedTaskExceptionLockObject; // 0x20

        // ── Methods ──
        public void QueueTask(){} // RVA: 0x24B10
        public void TryExecuteTaskInline(){}
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x5C339D0
        public void TryRunInline(){} // RVA: 0x5C339E0
        public void TryDequeue(){} // RVA: 0x2DD320
        public void NotifyWorkItemProgress(){} // RVA: 0x2DD310
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Default(){} // RVA: 0x5C33C00
        public void get_Current(){} // RVA: 0x5C33C60
        public void get_InternalCurrent(){} // RVA: 0x5C33D10
        public void FromCurrentSynchronizationContext(){} // RVA: 0x5C33DC0
        public void get_Id(){} // RVA: 0x5C33EE0
        public void TryExecuteTask(){} // RVA: 0x5C33F80
        public void add_UnobservedTaskException(){} // RVA: 0x5C34000
        public void remove_UnobservedTaskException(){} // RVA: 0x5C34240
        public void PublishUnobservedTaskException(){} // RVA: 0x5C34430
        public void .cctor(){} // RVA: 0x5C34550
    }

    public class TaskSchedulerAwaitTaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F50650
        public void Run(){} // RVA: 0x5F50D30
    }

    public class TaskSchedulerException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F41E90 | overloaded x3
    }

    public class TaskToApm
    {
        // ── Methods ──
        public void Begin(){} // RVA: 0x67F8B30
        public void End(){} // RVA: 0x283FA0 | overloaded x2
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x67F8DE0
    }

    public class TaskToApm
    {
        // ── Methods ──
        public void Begin(){} // RVA: 0x5F41F10
        public void End(){} // RVA: 0x283FA0 | overloaded x2
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x5F421C0
    }

    public class Task`1
    {
        public T m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<T> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4391990 | overloaded x8
        public void StartNew(){} // RVA: 0x4391CA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x4391E70
        public void DangerousSetResult(){} // RVA: 0x4392000
        public void get_Result(){} // RVA: 0x263BC0
        public void get_ResultOnSuccess(){} // RVA: 0x263BC0
        public void GetResultCore(){} // RVA: 0x263BC0
        public void get_Factory(){} // RVA: 0x4392410
        public void InnerInvoke(){} // RVA: 0x43925D0
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public T m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<T> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4391990 | overloaded x8
        public void StartNew(){} // RVA: 0x4391CA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x4391E70
        public void DangerousSetResult(){} // RVA: 0x4392000
        public void get_Result(){} // RVA: 0x263BC0
        public void get_ResultOnSuccess(){} // RVA: 0x263BC0
        public void GetResultCore(){} // RVA: 0x263BC0
        public void get_Factory(){} // RVA: 0x4392410
        public void InnerInvoke(){} // RVA: 0x43925D0
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public T m_result;
        public System.Threading.Tasks.TaskFactory`1<T> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x8
        public void StartNew(){} // RVA: 0x283FA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x283FA0
        public void DangerousSetResult(){} // RVA: 0x283FA0
        public void get_Result(){} // RVA: 0x283FA0
        public void get_ResultOnSuccess(){} // RVA: 0x283FA0
        public void GetResultCore(){} // RVA: 0x283FA0
        public void get_Factory(){} // RVA: 0xC960
        public void InnerInvoke(){} // RVA: 0x24A50
        public void GetAwaiter(){} // RVA: 0x283FA0
        public void ConfigureAwait(){} // RVA: 0x283FA0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public T m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<T> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4391990 | overloaded x8
        public void StartNew(){} // RVA: 0x4391CA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x4391E70
        public void DangerousSetResult(){} // RVA: 0x4392000
        public void get_Result(){} // RVA: 0x263BC0
        public void get_ResultOnSuccess(){} // RVA: 0x263BC0
        public void GetResultCore(){} // RVA: 0x263BC0
        public void get_Factory(){} // RVA: 0x4392410
        public void InnerInvoke(){} // RVA: 0x43925D0
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public T m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<T> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4391990 | overloaded x8
        public void StartNew(){} // RVA: 0x4391CA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x4391E70
        public void DangerousSetResult(){} // RVA: 0x4392000
        public void get_Result(){} // RVA: 0x263BC0
        public void get_ResultOnSuccess(){} // RVA: 0x263BC0
        public void GetResultCore(){} // RVA: 0x263BC0
        public void get_Factory(){} // RVA: 0x4392410
        public void InnerInvoke(){} // RVA: 0x43925D0
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public T m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<T> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4391990 | overloaded x8
        public void StartNew(){} // RVA: 0x4391CA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x4391E70
        public void DangerousSetResult(){} // RVA: 0x4392000
        public void get_Result(){} // RVA: 0x263BC0
        public void get_ResultOnSuccess(){} // RVA: 0x263BC0
        public void GetResultCore(){} // RVA: 0x263BC0
        public void get_Factory(){} // RVA: 0x4392410
        public void InnerInvoke(){} // RVA: 0x43925D0
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public T[] m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<T[]> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x436D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x436DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x436DC40
        public void DangerousSetResult(){} // RVA: 0x436DD80
        public void get_Result(){} // RVA: 0x436DE20
        public void get_ResultOnSuccess(){} // RVA: 0x37E0E0
        public void GetResultCore(){} // RVA: 0x41E9A60
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x436DE60
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public System.Threading.Tasks.VoidTaskResult m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.Threading.Tasks.VoidTaskResult> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4390840 | overloaded x8
        public void StartNew(){} // RVA: 0x4390B20 | overloaded x2
        public void TrySetResult(){} // RVA: 0x4358CE0
        public void DangerousSetResult(){} // RVA: 0x4358DD0
        public void get_Result(){} // RVA: 0x4358E00
        public void get_ResultOnSuccess(){} // RVA: 0x3978E0
        public void GetResultCore(){} // RVA: 0x4358F30
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x4359050
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public System.ValueTuple`2<VRC.Core.ApiWorld,VRC.Core.ApiContainer> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.ValueTuple`2<VRC.Core.ApiWorld,VRC.Core.ApiContainer>> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4336260 | overloaded x8
        public void StartNew(){} // RVA: 0x4336540 | overloaded x2
        public void TrySetResult(){} // RVA: 0x41DFE00
        public void DangerousSetResult(){} // RVA: 0x41DFF50
        public void get_Result(){} // RVA: 0x41DFFE0
        public void get_ResultOnSuccess(){} // RVA: 0x41E0130
        public void GetResultCore(){} // RVA: 0x41E0140
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x41E04B0
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public System.ValueTuple`2<VRC.Core.ApiAvatar,VRC.Core.ApiContainer> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.ValueTuple`2<VRC.Core.ApiAvatar,VRC.Core.ApiContainer>> s_defaultFactory;
    }

    public class Task`1
    {
        public object m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<object> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x436D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x436DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x436DC40
        public void DangerousSetResult(){} // RVA: 0x436DD80
        public void get_Result(){} // RVA: 0x436DE20
        public void get_ResultOnSuccess(){} // RVA: 0x37E0E0
        public void GetResultCore(){} // RVA: 0x41E9A60
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x436DE60
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public int m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<int> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4366BE0 | overloaded x8
        public void StartNew(){} // RVA: 0x4366EC0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x4367060
        public void DangerousSetResult(){} // RVA: 0x4367150
        public void get_Result(){} // RVA: 0x429E8F0
        public void get_ResultOnSuccess(){} // RVA: 0x59C540
        public void GetResultCore(){} // RVA: 0x429EA20
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x429EB40
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public ÌÎÌÌÏÍÎÎÌÎÌÏÏÍÏÍÏÎÎÎÎÎÎ m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<ÌÎÌÌÏÍÎÎÌÎÌÏÏÍÏÍÏÎÎÎÎÎÎ> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x436D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x436DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x436DC40
        public void DangerousSetResult(){} // RVA: 0x436DD80
        public void get_Result(){} // RVA: 0x436DE20
        public void get_ResultOnSuccess(){} // RVA: 0x37E0E0
        public void GetResultCore(){} // RVA: 0x41E9A60
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x436DE60
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public System.ValueTuple`2<VRC.Core.APIUser,VRC.Core.ApiContainer> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.ValueTuple`2<VRC.Core.APIUser,VRC.Core.ApiContainer>> s_defaultFactory;
    }

    public class Task`1
    {
        public VRC.OSCQuery.OSCQueryRootNode m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<VRC.OSCQuery.OSCQueryRootNode> s_defaultFactory;
    }

    public class Task`1
    {
        public VRC.OSCQuery.HostInfo m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<VRC.OSCQuery.HostInfo> s_defaultFactory;
    }

    public class Task`1
    {
        public System.ValueTuple`2<VRC.Core.ApiWorldInstance,VRC.Core.ApiContainer> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.ValueTuple`2<VRC.Core.ApiWorldInstance,VRC.Core.ApiContainer>> s_defaultFactory;
    }

    public class Task`1
    {
        public Mediapipe.ImageFrame m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<Mediapipe.ImageFrame> s_defaultFactory;
    }

    public class Task`1
    {
        public NextResult<Mediapipe.ImageFrame> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<NextResult<Mediapipe.ImageFrame>> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x41E2490 | overloaded x8
        public void StartNew(){} // RVA: 0x41E2770 | overloaded x2
        public void TrySetResult(){} // RVA: 0x41DFE00
        public void DangerousSetResult(){} // RVA: 0x41DFF50
        public void get_Result(){} // RVA: 0x41DFFE0
        public void get_ResultOnSuccess(){} // RVA: 0x41E0130
        public void GetResultCore(){} // RVA: 0x41E0140
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x41E04B0
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public ÍÎÎÎÍÎÍÍÌÌÌÌÍÌÌÎÎÏÎÍÌÌÏ m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<ÍÎÎÎÍÎÍÍÌÌÌÌÍÌÌÎÎÏÎÍÌÌÏ> s_defaultFactory;
    }

    public class Task`1
    {
        public System.ValueTuple`5<NextResult<...>,NextResult<...>,NextResult<...>,NextResult<Mediapipe.ImageFrame>,NextResult<...>> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.ValueTuple`5<NextResult<...>,NextResult<...>,NextResult<...>,NextResult<Mediapipe.ImageFrame>,NextResult<...>>> s_defaultFactory;
    }

    public class Task`1
    {
        public System.Collections.Generic.List`1<Mediapipe.Detection> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.Collections.Generic.List`1<Mediapipe.Detection>> s_defaultFactory;
    }

    public class Task`1
    {
        public NextResult<System.Collections.Generic.List`1<Mediapipe.Detection>> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<NextResult<System.Collections.Generic.List`1<Mediapipe.Detection>>> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x41E2490 | overloaded x8
        public void StartNew(){} // RVA: 0x41E2770 | overloaded x2
        public void TrySetResult(){} // RVA: 0x41DFE00
        public void DangerousSetResult(){} // RVA: 0x41DFF50
        public void get_Result(){} // RVA: 0x41DFFE0
        public void get_ResultOnSuccess(){} // RVA: 0x41E0130
        public void GetResultCore(){} // RVA: 0x41E0140
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x41E04B0
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public ÍÍÎÎÎÎÌÍÎÏÍÍÎÏÍÍÌÎÎÍÍÌÏ m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<ÍÍÎÎÎÎÌÍÎÏÍÍÎÏÍÍÌÎÎÍÍÌÏ> s_defaultFactory;
    }

    public class Task`1
    {
        public System.ValueTuple`3<NextResult<System.Collections.Generic.List`1<Mediapipe.Detection>>,NextResult<...>,NextResult<...>> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.ValueTuple`3<NextResult<System.Collections.Generic.List`1<Mediapipe.Detection>>,NextResult<...>,NextResult<...>>> s_defaultFactory;
    }

    public class Task`1
    {
        public ÌÏÍÌÍÎÎÏÏÎÍÌÍÌÍÏÍÍÏÌÎÏÍ m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<ÌÏÍÌÍÎÎÏÏÎÍÌÍÌÍÏÍÍÏÌÎÏÍ> s_defaultFactory;
    }

    public class Task`1
    {
        public System.ValueTuple`8<NextResult<...>,NextResult<...>,NextResult<...>,NextResult<...>,NextResult<...>,NextResult<...>,NextResult<Mediapipe.ImageFrame>,System.ValueTuple`1<...>> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.ValueTuple`8<NextResult<...>,NextResult<...>,NextResult<...>,NextResult<...>,NextResult<...>,NextResult<...>,NextResult<Mediapipe.ImageFrame>,System.ValueTuple`1<...>>> s_defaultFactory;
    }

    public class Task`1
    {
        public ÏÏÍÏÍÌÍÌÏÍÌÎÍÌÍÍÍÍÍÍÌÎÏ m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<ÏÏÍÏÍÌÍÌÏÍÌÎÍÌÍÍÍÍÍÍÌÎÏ> s_defaultFactory;
    }

    public class Task`1
    {
        public System.ValueTuple`6<NextResult<System.Collections.Generic.List`1<Mediapipe.Detection>>,NextResult<...>,NextResult<...>,NextResult<...>,NextResult<...>,NextResult<...>> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.ValueTuple`6<NextResult<System.Collections.Generic.List`1<Mediapipe.Detection>>,NextResult<...>,NextResult<...>,NextResult<...>,NextResult<...>,NextResult<...>>> s_defaultFactory;
    }

    public class Task`1
    {
        public ÍÍÏÎÎÌÍÌÍÌÌÎÎÎÎÌÏÏÎÍÎÌÌ m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<ÍÍÏÎÎÌÍÌÍÌÌÎÎÎÎÌÏÏÎÍÎÌÌ> s_defaultFactory;
    }

    public class Task`1
    {
        public System.ValueTuple`4<NextResult<System.Collections.Generic.List`1<Mediapipe.Detection>>,NextResult<...>,NextResult<...>,NextResult<...>> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.ValueTuple`4<NextResult<System.Collections.Generic.List`1<Mediapipe.Detection>>,NextResult<...>,NextResult<...>,NextResult<...>>> s_defaultFactory;
    }

    public class Task`1
    {
        public short m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<short> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4365B60 | overloaded x8
        public void StartNew(){} // RVA: 0x4365E40 | overloaded x2
        public void TrySetResult(){} // RVA: 0x435D4C0
        public void DangerousSetResult(){} // RVA: 0x435D5B0
        public void get_Result(){} // RVA: 0x41E3AE0
        public void get_ResultOnSuccess(){} // RVA: 0x41E3C10
        public void GetResultCore(){} // RVA: 0x41E3C20
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x41E3D40
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public ÎÎÌÏÎÏÏÎÍÎÏÍÎÎÎÍÎÏÏÌÎÎÍ m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<ÎÎÌÏÎÏÏÎÍÎÏÍÎÎÎÍÎÏÏÌÎÎÍ> s_defaultFactory;
    }

    public class Task`1
    {
        public VRC.Core.ApiContainer m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<VRC.Core.ApiContainer> s_defaultFactory;
    }

    public class Task`1
    {
        public System.ValueTuple`2<bool,UnityEngine.Purchasing.Extension.PurchaseFailureDescription> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.ValueTuple`2<bool,UnityEngine.Purchasing.Extension.PurchaseFailureDescription>> s_defaultFactory;
    }

    public class Task`1
    {
        public System.Collections.Generic.List`1<VRC.Core.ApiPendingTransaction> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.Collections.Generic.List`1<VRC.Core.ApiPendingTransaction>> s_defaultFactory;
    }

    public class Task`1
    {
        public System.Collections.Generic.IReadOnlyList`1<VRC.Core.ApiVRChatProductDetails> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.Collections.Generic.IReadOnlyList`1<VRC.Core.ApiVRChatProductDetails>> s_defaultFactory;
    }

    public class Task`1
    {
        public bool m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<bool> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4359D40 | overloaded x8
        public void StartNew(){} // RVA: 0x435A020 | overloaded x2
        public void TrySetResult(){} // RVA: 0x435A1C0
        public void DangerousSetResult(){} // RVA: 0x435A2B0
        public void get_Result(){} // RVA: 0x4358E00
        public void get_ResultOnSuccess(){} // RVA: 0x3978E0
        public void GetResultCore(){} // RVA: 0x4358F30
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x4359050
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public System.Threading.Tasks.Task m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.Threading.Tasks.Task> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x436D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x436DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x436DC40
        public void DangerousSetResult(){} // RVA: 0x436DD80
        public void get_Result(){} // RVA: 0x436DE20
        public void get_ResultOnSuccess(){} // RVA: 0x37E0E0
        public void GetResultCore(){} // RVA: 0x41E9A60
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x436DE60
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public System.ValueTuple`3<bool,string,UnityEngine.Texture2D> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.ValueTuple`3<bool,string,UnityEngine.Texture2D>> s_defaultFactory;
    }

    public class Task`1
    {
        public VRC.Economy.IProduct[] m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<VRC.Economy.IProduct[]> s_defaultFactory;
    }

    public class Task`1
    {
        public System.ValueTuple`2<bool,string> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.ValueTuple`2<bool,string>> s_defaultFactory;
    }

    public class Task`1
    {
        public System.VoidResult m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.VoidResult> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x438E700 | overloaded x8
        public void StartNew(){} // RVA: 0x438E9E0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x4358CE0
        public void DangerousSetResult(){} // RVA: 0x4358DD0
        public void get_Result(){} // RVA: 0x4358E00
        public void get_ResultOnSuccess(){} // RVA: 0x3978E0
        public void GetResultCore(){} // RVA: 0x4358F30
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x4359050
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public ZLogger.IZLoggerEntry m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<ZLogger.IZLoggerEntry> s_defaultFactory;
    }

    public class Task`1
    {
        public System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x436D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x436DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x436DC40
        public void DangerousSetResult(){} // RVA: 0x436DD80
        public void get_Result(){} // RVA: 0x436DE20
        public void get_ResultOnSuccess(){} // RVA: 0x37E0E0
        public void GetResultCore(){} // RVA: 0x41E9A60
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x436DE60
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public NextResult<Mediapipe.NormalizedLandmarkList> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<NextResult<Mediapipe.NormalizedLandmarkList>> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x41E2490 | overloaded x8
        public void StartNew(){} // RVA: 0x41E2770 | overloaded x2
        public void TrySetResult(){} // RVA: 0x41DFE00
        public void DangerousSetResult(){} // RVA: 0x41DFF50
        public void get_Result(){} // RVA: 0x41DFFE0
        public void get_ResultOnSuccess(){} // RVA: 0x41E0130
        public void GetResultCore(){} // RVA: 0x41E0140
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x41E04B0
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public System.Threading.Tasks.Task`1<ÌÎÌÌÏÍÎÎÌÎÌÏÏÍÏÍÏÎÎÎÎÎÎ> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.Threading.Tasks.Task`1<ÌÎÌÌÏÍÎÎÌÎÌÏÏÍÏÍÏÎÎÎÎÎÎ>> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x436D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x436DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x436DC40
        public void DangerousSetResult(){} // RVA: 0x436DD80
        public void get_Result(){} // RVA: 0x436DE20
        public void get_ResultOnSuccess(){} // RVA: 0x37E0E0
        public void GetResultCore(){} // RVA: 0x41E9A60
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x436DE60
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public System.Net.Sockets.Socket m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<System.Net.Sockets.Socket> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x436D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x436DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x436DC40
        public void DangerousSetResult(){} // RVA: 0x436DD80
        public void get_Result(){} // RVA: 0x436DE20
        public void get_ResultOnSuccess(){} // RVA: 0x37E0E0
        public void GetResultCore(){} // RVA: 0x41E9A60
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x436DE60
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

    public class Task`1
    {
        public NextResult<Mediapipe.Detection> m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<NextResult<Mediapipe.Detection>> s_defaultFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x41E2490 | overloaded x8
        public void StartNew(){} // RVA: 0x41E2770 | overloaded x2
        public void TrySetResult(){} // RVA: 0x41DFE00
        public void DangerousSetResult(){} // RVA: 0x41DFF50
        public void get_Result(){} // RVA: 0x41DFFE0
        public void get_ResultOnSuccess(){} // RVA: 0x41E0130
        public void GetResultCore(){} // RVA: 0x41E0140
        public void get_Factory(){} // RVA: 0x41E0270
        public void InnerInvoke(){} // RVA: 0x41E04B0
        public void GetAwaiter(){} // RVA: 0x41E0640
        public void ConfigureAwait(){} // RVA: 0x41E06A0
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x10
    }

}