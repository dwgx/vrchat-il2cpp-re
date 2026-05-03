// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 52
// Methods: 416

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class AsyncCausalityTracer : Object
    {
        // ── Methods ──
        public void get_LoggingOn(){} // RVA: 0x7FFE810FB320
        public void TraceOperationCreation(){} // RVA: 0x7FFE810FB310
        public void TraceOperationCompletion(){} // RVA: 0x7FFE810FB310
        public void TraceSynchronousWorkStart(){} // RVA: 0x7FFE810FB310
        public void TraceSynchronousWorkCompletion(){} // RVA: 0x7FFE810FB310
    }

    public class AwaitTaskContinuation : TaskContinuation
    {
        public System.Threading.ExecutionContext m_capturedContext; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A92060
        public void CreateTask(){} // RVA: 0x7FFE86A92180
        public void Run(){} // RVA: 0x7FFE86A92260
        public void get_IsValidLocationForInlining(){} // RVA: 0x7FFE86A92320
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFE86A92430
        public void InvokeAction(){} // RVA: 0x7FFE86A924E0
        public void GetInvokeActionCallback(){} // RVA: 0x7FFE86A92550
        public void RunCallback(){} // RVA: 0x7FFE86A92650
        public void RunOrScheduleAction(){} // RVA: 0x7FFE86A92810
        public void UnsafeScheduleAction(){} // RVA: 0x7FFE86A92980
        public void ThrowAsyncIfNecessary(){} // RVA: 0x7FFE86A92A50
        public void MarkAborted(){} // RVA: 0x7FFE810FB310
    }

    public class Box`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
    }

    public class CompletionActionInvoker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFE86A90D10
        public void MarkAborted(){} // RVA: 0x7FFE810FB310
    }

    public class ContinuationResultTaskFromResultTask`2 : Task`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void InnerInvoke(){} // RVA: 0x7FFE80E45FE0
    }

    public class ContinuationResultTaskFromTask`1 : Task`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void InnerInvoke(){} // RVA: 0x7FFE80E45FE0
    }

    public class ContinuationTaskFromResultTask`1 : Task
    {
        // ── Methods ──
        public void .ctor(){}
        public void InnerInvoke(){} // RVA: 0x7FFE80E45FE0
    }

    public class ContinuationTaskFromTask : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A90D80
        public void InnerInvoke(){} // RVA: 0x7FFE86A90F70
    }

    public class DebuggerSupport : Object
    {
        public System.Collections.Generic.LowLevelDictionary`2<int,System.Threading.Tasks.Task> s_activeTasks;

        // ── Methods ──
        public void get_LoggingOn(){} // RVA: 0x7FFE810FB320
        public void TraceOperationCreation(){} // RVA: 0x7FFE810FB310
        public void TraceOperationCompletion(){} // RVA: 0x7FFE810FB310
        public void TraceOperationRelation(){} // RVA: 0x7FFE810FB310
        public void TraceSynchronousWorkStart(){} // RVA: 0x7FFE810FB310
        public void TraceSynchronousWorkCompletion(){} // RVA: 0x7FFE810FB310
        public void AddToActiveTasks(){} // RVA: 0x7FFE86A86270
        public void AddToActiveTasksNonInlined(){} // RVA: 0x7FFE86A86310
        public void RemoveFromActiveTasks(){} // RVA: 0x7FFE86A86510
        public void RemoveFromActiveTasksNonInlined(){} // RVA: 0x7FFE86A865B0
        public void .cctor(){} // RVA: 0x7FFE86A867A0
    }

    public class ForceAsyncAwaiter : ValueType
    {
        public System.Threading.Tasks.Task _task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void GetAwaiter(){} // RVA: 0x7FFE8284EF60
        public void get_IsCompleted(){} // RVA: 0x7FFE810FB320
        public void GetResult(){} // RVA: 0x7FFE86A841B0
        public void OnCompleted(){} // RVA: 0x7FFE86A84250
        public void UnsafeOnCompleted(){} // RVA: 0x7FFE86A84320
    }

    public class ITaskCompletionAction
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x7FFE80E460A0
        public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFE80E2F150
    }

    public class IndexRange : ValueType
    {
    }

    public class Parallel : Object
    {
        // ── Methods ──
        public void CheckTimeoutReached(){} // RVA: 0x7FFE86A84730
        public void ComputeTimeoutPoint(){} // RVA: 0x7FFE86A84760
        public void ForWorker(){} // RVA: 0x7FFE810A1420
        public void ForEach(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ForEachWorker(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void PartitionerForEachWorker(){} // RVA: 0x7FFE810A1420
        public void ReduceToSingleCancellationException(){} // RVA: 0x7FFE86A84780
        public void ThrowSingleCancellationExceptionOrOtherException(){} // RVA: 0x7FFE86A84AB0
        public void .cctor(){} // RVA: 0x7FFE86A84B10
    }

    public class ParallelEtwProvider : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8694F610
        public void ParallelLoopBegin(){} // RVA: 0x7FFE86A84BE0
        public void ParallelLoopEnd(){} // RVA: 0x7FFE86A84C10
        public void ParallelFork(){} // RVA: 0x7FFE81D95990
        public void ParallelJoin(){} // RVA: 0x7FFE81D95990
        public void .cctor(){} // RVA: 0x7FFE86A84C40
    }

    public class ParallelLoopResult : ValueType
    {
    }

    public class ParallelLoopState : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class ParallelLoopState32 : ParallelLoopState
    {
        public System.Threading.Tasks.ParallelLoopStateFlags32 _sharedParallelStateFlags; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A84CF0
        public void set_CurrentIteration(){} // RVA: 0x7FFE8170B670
    }

    public class ParallelLoopState64 : ParallelLoopState
    {
        public System.Threading.Tasks.ParallelLoopStateFlags64 _sharedParallelStateFlags; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A84CF0
        public void set_CurrentIteration(){} // RVA: 0x7FFE81859C50
    }

    public class ParallelLoopStateFlags : Object
    {
        public int _loopStateFlags; // 0x10

        // ── Methods ──
        public void get_LoopStateFlags(){} // RVA: 0x7FFE86A6BCE0
        public void AtomicLoopStateUpdate(){} // RVA: 0x7FFE86A84E90 | overloaded x2
        public void SetExceptional(){} // RVA: 0x7FFE86A84FA0
        public void Cancel(){} // RVA: 0x7FFE86A84FB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ParallelLoopStateFlags32 : ParallelLoopStateFlags
    {
        public int _lowestBreakIteration; // 0x18

        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x7FFE86A84FC0
        public void ShouldExitLoop(){} // RVA: 0x7FFE86A85000 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE86A85020
    }

    public class ParallelLoopStateFlags64 : ParallelLoopStateFlags
    {
        public long _lowestBreakIteration; // 0x18

        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x7FFE810FE7C0
        public void ShouldExitLoop(){} // RVA: 0x7FFE86A85030
        public void .ctor(){} // RVA: 0x7FFE86A85060
    }

    public class ParallelOptions : Object
    {
        public System.Threading.Tasks.TaskScheduler _scheduler; // 0x10
        public int _maxDegreeOfParallelism; // 0x18
        public System.Threading.CancellationToken _cancellationToken; // 0x20
        public object field_3; // 0x219
        public object field_4; // 0x21A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A843F0
        public void get_TaskScheduler(){} // RVA: 0x7FFE81116380
        public void get_EffectiveTaskScheduler(){} // RVA: 0x7FFE86A84570
        public void get_MaxDegreeOfParallelism(){} // RVA: 0x7FFE813DB630
        public void set_MaxDegreeOfParallelism(){} // RVA: 0x7FFE86A845D0
        public void get_CancellationToken(){} // RVA: 0x7FFE811290C0
        public void get_EffectiveMaxConcurrencyLevel(){} // RVA: 0x7FFE86A84640
    }

    public class RangeManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A853C0
        public void RegisterNewWorker(){} // RVA: 0x7FFE86A85610
    }

    public class RangeWorker : ValueType
    {
        public System.Threading.Tasks.IndexRange[] _indexRanges; // 0x10

        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0x7FFE81E76100
        public void .ctor(){} // RVA: 0x7FFE86A85070
        public void FindNewWork(){} // RVA: 0x7FFE86A850E0
        public void FindNewWork32(){} // RVA: 0x7FFE86A85370
    }

    public class StackGuard : Object
    {
        // ── Methods ──
        public void TryBeginInliningScope(){} // RVA: 0x7FFE86A90D60
        public void EndInliningScope(){} // RVA: 0x7FFE86A90D70
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StandardTaskContinuation : TaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A911B0
        public void Run(){} // RVA: 0x7FFE86A91300
    }

    public class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A91470
        public void Run(){} // RVA: 0x7FFE86A914F0
        public void PostAction(){} // RVA: 0x7FFE86A91740
        public void GetPostActionCallback(){} // RVA: 0x7FFE86A917F0
        public void .cctor(){} // RVA: 0x7FFE86A91920
    }

    public class SynchronizationContextTaskScheduler : TaskScheduler
    {
        public System.Threading.SynchronizationContext m_synchronizationContext; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867755C0
        public void QueueTask(){} // RVA: 0x7FFE867756A0
        public void TryExecuteTaskInline(){} // RVA: 0x7FFE86775730
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x7FFE811EDAF0
        public void .cctor(){} // RVA: 0x7FFE867757D0
    }

    public class SystemThreadingTasks_FutureDebugView`1 : Object
    {
    }

    public class SystemThreadingTasks_TaskDebugView : Object
    {
    }

    public class Task : Object
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
        public System.Threading.Tasks.Task t_currentTask; // 0xFFFF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A86F60 | overloaded x7
        public void TaskConstructorCore(){} // RVA: 0x7FFE86A87060
        public void AssignCancellationToken(){} // RVA: 0x7FFE86A873B0
        public void TaskCancelCallback(){} // RVA: 0x7FFE86A877C0
        public void TrySetCanceled(){} // RVA: 0x7FFE86A87910 | overloaded x2
        public void TrySetException(){} // RVA: 0x7FFE86A87A90
        public void get_Options(){} // RVA: 0x7FFE86A87B00
        public void OptionsMethod(){} // RVA: 0x7FFE832C8C90
        public void AtomicStateUpdate(){} // RVA: 0x7FFE86A87C40 | overloaded x2
        public void SetNotificationForWaitCompletion(){} // RVA: 0x7FFE86A87D50
        public void NotifyDebuggerOfWaitCompletionIfNecessary(){} // RVA: 0x7FFE86A87E40
        public void AnyTaskRequiresNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7FFE86A87E90
        public void get_IsWaitNotificationEnabledOrNotRanToCompletion(){} // RVA: 0x7FFE86A87F10
        public void get_ShouldNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7FFE86A87F30
        public void get_IsWaitNotificationEnabled(){} // RVA: 0x7FFE86A87F30
        public void NotifyDebuggerOfWaitCompletion(){} // RVA: 0x7FFE86A87F50
        public void MarkStarted(){} // RVA: 0x7FFE86A87F80
        public void AddNewChild(){} // RVA: 0x7FFE86A87FA0
        public void DisregardChild(){} // RVA: 0x7FFE86A87FF0
        public void Start(){} // RVA: 0x7FFE86A88020
        public void RunSynchronously(){} // RVA: 0x7FFE86A88250
        public void InternalRunSynchronously(){} // RVA: 0x7FFE86A882C0
        public void InternalStartNew(){} // RVA: 0x7FFE86A88630
        public void get_Id(){} // RVA: 0x7FFE86A887F0
        public void get_CurrentId(){} // RVA: 0x7FFE86A88880
        public void get_InternalCurrent(){} // RVA: 0x7FFE86A88900
        public void InternalCurrentIfAttached(){} // RVA: 0x7FFE86A889A0
        public void get_CurrentStackGuard(){} // RVA: 0x7FFE86A88A00
        public void get_Exception(){} // RVA: 0x7FFE86A88B40
        public void get_Status(){} // RVA: 0x7FFE86A88B70
        public void get_IsCanceled(){} // RVA: 0x7FFE86A88BD0
        public void get_IsCancellationRequested(){} // RVA: 0x7FFE86A88BF0
        public void EnsureContingentPropertiesInitialized(){} // RVA: 0x7FFE86A88C80
        public void EnsureContingentPropertiesInitializedCore(){} // RVA: 0x7FFE86A88DD0
        public void get_CancellationToken(){} // RVA: 0x7FFE86A88F10
        public void get_IsCancellationAcknowledged(){} // RVA: 0x7FFE86A88F30
        public void get_IsCompleted(){} // RVA: 0x7FFE86A88F50
        public void IsCompletedMethod(){} // RVA: 0x7FFE86A88FB0
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7FFE86A88FC0
        public void get_CreationOptions(){} // RVA: 0x7FFE86A88FE0
        public void System.IAsyncResult.get_AsyncWaitHandle(){} // RVA: 0x7FFE86A89030
        public void get_AsyncState(){} // RVA: 0x7FFE811290C0
        public void System.IAsyncResult.get_CompletedSynchronously(){} // RVA: 0x7FFE810FB320
        public void get_ExecutingTaskScheduler(){} // RVA: 0x7FFE81129130
        public void get_Factory(){} // RVA: 0x7FFE86A890E0
        public void get_CompletedTask(){} // RVA: 0x7FFE86A89140
        public void get_CompletedEvent(){} // RVA: 0x7FFE86A891A0
        public void get_ExceptionRecorded(){} // RVA: 0x7FFE86A89320
        public void get_IsFaulted(){} // RVA: 0x7FFE86A89370
        public void get_CapturedContext(){} // RVA: 0x7FFE86A89390
        public void set_CapturedContext(){} // RVA: 0x7FFE86A89410
        public void Dispose(){} // RVA: 0x7FFE86A89560 | overloaded x2
        public void ScheduleAndStart(){} // RVA: 0x7FFE86A89690
        public void AddException(){} // RVA: 0x7FFE86A89820 | overloaded x2
        public void GetExceptions(){} // RVA: 0x7FFE86A89B30
        public void GetExceptionDispatchInfos(){} // RVA: 0x7FFE86A89D00
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x7FFE86A89F90
        public void ThrowIfExceptional(){} // RVA: 0x7FFE86A89FC0
        public void UpdateExceptionObservedStatus(){} // RVA: 0x7FFE86A8A010
        public void get_IsExceptionObservedByParent(){} // RVA: 0x7FFE86A8A130
        public void get_IsDelegateInvoked(){} // RVA: 0x7FFE86A8A150
        public void Finish(){} // RVA: 0x7FFE86A8A170
        public void FinishStageTwo(){} // RVA: 0x7FFE86A8A3A0
        public void FinishStageThree(){} // RVA: 0x7FFE86A8A4E0
        public void ProcessChildCompletion(){} // RVA: 0x7FFE86A8A5D0
        public void AddExceptionsFromChildren(){} // RVA: 0x7FFE86A8A8A0
        public void Execute(){} // RVA: 0x7FFE86A8ACA0
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFE86A8ACE0
        public void ExecuteEntry(){} // RVA: 0x7FFE86A8ACF0
        public void ExecutionContextCallback(){} // RVA: 0x7FFE86A8AED0
        public void InnerInvoke(){} // RVA: 0x7FFE86A8AF60
        public void HandleException(){} // RVA: 0x7FFE86A8B000
        public void GetAwaiter(){} // RVA: 0x7FFE81D7BAB0
        public void ConfigureAwait(){} // RVA: 0x7FFE86A8B140
        public void SetContinuationForAwait(){} // RVA: 0x7FFE86A8B160
        public void Yield(){} // RVA: 0x7FFE810FB320
        public void Wait(){} // RVA: 0x7FFE86A8B430 | overloaded x3
        public void WrappedTryRunInline(){} // RVA: 0x7FFE86A8B570
        public void InternalWait(){} // RVA: 0x7FFE86A8B610
        public void SpinThenBlockingWait(){} // RVA: 0x7FFE86A8BAE0
        public void SpinWait(){} // RVA: 0x7FFE86A8BEF0
        public void InternalCancel(){} // RVA: 0x7FFE86A8C0A0
        public void RecordInternalCancellationRequest(){} // RVA: 0x7FFE86A8C3E0 | overloaded x3
        public void CancellationCleanupLogic(){} // RVA: 0x7FFE86A8C510
        public void SetCancellationAcknowledged(){} // RVA: 0x7FFE86A8C5D0
        public void FinishContinuations(){} // RVA: 0x7FFE86A8C5F0
        public void LogFinishCompletionNotification(){} // RVA: 0x7FFE86A8CCA0
        public void ContinueWith(){} // RVA: 0x7FFE810A1420 | overloaded x8
        public void CreationOptionsFromContinuationOptions(){} // RVA: 0x7FFE86A8D160
        public void ContinueWithCore(){} // RVA: 0x7FFE86A8D2C0
        public void AddCompletionAction(){} // RVA: 0x7FFE86A8D620 | overloaded x2
        public void AddTaskContinuationComplex(){} // RVA: 0x7FFE86A8D6A0
        public void AddTaskContinuation(){} // RVA: 0x7FFE86A8DA90
        public void RemoveContinuation(){} // RVA: 0x7FFE86A8DBA0
        public void FromResult(){} // RVA: 0x7FFE810A1420
        public void FromException(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void FromCancellation(){} // RVA: 0x7FFE80E2E3D0 | overloaded x3
        public void FromCanceled(){} // RVA: 0x7FFE80E3D320 | overloaded x2
        public void Run(){} // RVA: 0x7FFE80E33EA0 | overloaded x6
        public void Delay(){} // RVA: 0x7FFE86A8E730 | overloaded x3
        public void WhenAll(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void InternalWhenAll(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void WhenAny(){} // RVA: 0x7FFE86A8F090 | overloaded x2
        public void CreateUnwrapPromise(){} // RVA: 0x7FFE80E3EBF0
        public void AddToActiveTasks(){} // RVA: 0x7FFE86A8F380
        public void RemoveFromActiveTasks(){} // RVA: 0x7FFE86A8F5B0
        public void MarkAborted(){} // RVA: 0x7FFE810FB310
        public void ExecuteWithThreadLocal(){} // RVA: 0x7FFE86A8F780
        public void .cctor(){} // RVA: 0x7FFE86A8FAB0
    }

    public class TaskAsyncEnumerableExtensions : Object
    {
        // ── Methods ──
        public void ConfigureAwait(){} // RVA: 0x7FFE86DFCCD0
    }

    public class TaskAwaiters : Object
    {
        // ── Methods ──
        public void ForceAsync(){} // RVA: 0x7FFE81D7BAB0
    }

    public class TaskCanceledException : OperationCanceledException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class TaskCompletionSource`1 : Object
    {
        public System.Threading.Tasks.Task`1<T> _task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84D437D0 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFE81116380
        public void SpinUntilCompleted(){} // RVA: 0x7FFE84D438A0
        public void TrySetException(){} // RVA: 0x7FFE84D439B0
        public void SetException(){} // RVA: 0x7FFE84D43A30
        public void TrySetResult(){} // RVA: 0x7FFE84D43A80
        public void SetResult(){} // RVA: 0x7FFE84D43B90
        public void TrySetCanceled(){} // RVA: 0x7FFE84D43CB0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFE84D43D60
    }

    public class TaskContinuation : Object
    {
        // ── Methods ──
        public void Run(){} // RVA: 0x7FFE80E4BC00
        public void InlineIfPossibleOrElseQueue(){} // RVA: 0x7FFE86A910B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TaskExceptionHolder : Object
    {
        public bool s_failFastOnUnobservedException;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ShouldFailFastOnUnobservedException(){} // RVA: 0x7FFE810FB320
        public void Finalize(){} // RVA: 0x7FFE86772D30
        public void get_ContainsFaultList(){} // RVA: 0x7FFE86772F50
        public void Add(){} // RVA: 0x7FFE86772F60
        public void SetCancellationException(){} // RVA: 0x7FFE86772F80
        public void AddFaultException(){} // RVA: 0x7FFE86773180
        public void MarkAsUnhandled(){} // RVA: 0x7FFE86773790
        public void MarkAsHandled(){} // RVA: 0x7FFE86773800
        public void CreateExceptionObject(){} // RVA: 0x7FFE86773880
        public void GetExceptionDispatchInfos(){} // RVA: 0x7FFE86773B10
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x7FFE811290C0
        public void .cctor(){} // RVA: 0x7FFE86773C30
    }

    public class TaskExtensions : Object
    {
        // ── Methods ──
        public void Unwrap(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
    }

    public class TaskFactory : Object
    {
        public System.Threading.CancellationToken m_defaultCancellationToken; // 0x10

        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x7FFE86773C70
        public void .ctor(){} // RVA: 0x7FFE84D43F20 | overloaded x2
        public void CheckCreationOptions(){} // RVA: 0x7FFE86773D60
        public void get_Scheduler(){} // RVA: 0x7FFE810FE7C0
        public void StartNew(){} // RVA: 0x7FFE810A1420 | overloaded x6
        public void FromAsync(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void CheckFromAsyncOptions(){} // RVA: 0x7FFE86773FA0
        public void CommonCWAnyLogic(){} // RVA: 0x7FFE867740D0
        public void CheckMultiTaskContinuationOptions(){} // RVA: 0x7FFE867743B0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x7FFE80E2E390
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void StartNew(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void FromAsyncCoreLogic(){}
        public void FromAsync(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void FromAsyncImpl(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void FromAsyncTrim(){} // RVA: 0x7FFE810A1420
    }

    public class TaskReplicator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A856D0
        public void Run(){} // RVA: 0x7FFE80E4F3B0
        public void GenerateCooperativeMultitaskingTaskTimeout(){} // RVA: 0x7FFE86A85850
    }

    public class TaskScheduler : Object
    {
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Threading.Tasks.TaskScheduler,object> s_activeTaskSchedulers;
        public System.Threading.Tasks.TaskScheduler s_defaultTaskScheduler; // 0x8
        public int s_taskSchedulerIdCounter; // 0x10
        public int m_taskSchedulerId; // 0x10
        public System.EventHandler`1<System.Threading.Tasks.UnobservedTaskExceptionEventArgs> _unobservedTaskException; // 0x18
        public System.Threading.Lock _unobservedTaskExceptionLockObject; // 0x20

        // ── Methods ──
        public void QueueTask(){} // RVA: 0x7FFE80E460A0
        public void TryExecuteTaskInline(){}
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x7FFE86774820
        public void TryRunInline(){} // RVA: 0x7FFE86774830
        public void TryDequeue(){} // RVA: 0x7FFE810FB320
        public void NotifyWorkItemProgress(){} // RVA: 0x7FFE810FB310
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Default(){} // RVA: 0x7FFE86774A50
        public void get_Current(){} // RVA: 0x7FFE86774AB0
        public void get_InternalCurrent(){} // RVA: 0x7FFE86774B60
        public void FromCurrentSynchronizationContext(){} // RVA: 0x7FFE86774C10
        public void get_Id(){} // RVA: 0x7FFE86774D30
        public void TryExecuteTask(){} // RVA: 0x7FFE86774DD0
        public void add_UnobservedTaskException(){} // RVA: 0x7FFE86774E50
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFE86775090
        public void PublishUnobservedTaskException(){} // RVA: 0x7FFE86775280
        public void .cctor(){} // RVA: 0x7FFE867753A0
    }

    public class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A91470
        public void Run(){} // RVA: 0x7FFE86A91B50
    }

    public class TaskSchedulerException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A82CB0 | overloaded x3
    }

    public class TaskToApm : Object
    {
        // ── Methods ──
        public void Begin(){} // RVA: 0x7FFE87337E10
        public void End(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x7FFE873380C0
    }

    public class Task`1 : Task
    {
        public T m_result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<T> s_defaultFactory;
        public object field_2; // 0xF755

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84FCD690 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFE84FCD9A0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFE84FCDB70
        public void DangerousSetResult(){} // RVA: 0x7FFE84FCDD00
        public void get_Result(){} // RVA: 0x7FFE81081080
        public void get_ResultOnSuccess(){} // RVA: 0x7FFE81081080
        public void GetResultCore(){} // RVA: 0x7FFE81081080
        public void get_Factory(){} // RVA: 0x7FFE84FCE100
        public void InnerInvoke(){} // RVA: 0x7FFE84FCE2C0
        public void GetAwaiter(){} // RVA: 0x7FFE84E464E0
        public void ConfigureAwait(){} // RVA: 0x7FFE84E46540
        public void ContinueWith(){} // RVA: 0x7FFE810A1420 | overloaded x10
    }

    public class ThreadPoolTaskScheduler : TaskScheduler
    {
        public System.Threading.ParameterizedThreadStart s_longRunningThreadWork;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86775AB0
        public void QueueTask(){} // RVA: 0x7FFE86775B00
        public void TryExecuteTaskInline(){} // RVA: 0x7FFE86775ED0
        public void TryDequeue(){} // RVA: 0x7FFE86775FA0
        public void NotifyWorkItemProgress(){} // RVA: 0x7FFE86775FB0
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x7FFE810FB320
        public void .cctor(){} // RVA: 0x7FFE86776020
    }

    public class UnobservedTaskExceptionEventArgs : EventArgs
    {
        public System.AggregateException m_exception; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86775A10
        public void get_Exception(){} // RVA: 0x7FFE81116380
    }

    public class UnwrapPromise`1 : Task`1
    {
        public byte _state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4BC00
        public void Invoke(){} // RVA: 0x7FFE80E460A0
        public void InvokeCore(){} // RVA: 0x7FFE80E460A0
        public void InvokeCoreAsync(){} // RVA: 0x7FFE80E460A0
        public void ProcessCompletedOuterTask(){} // RVA: 0x7FFE80E460A0
        public void TrySetFromTask(){}
        public void ProcessInnerTask(){} // RVA: 0x7FFE80E460A0
        public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFE80E2F150
    }

    public class ValueTask : ValueType
    {
        public System.Threading.Tasks.Task s_canceledTask;
        public object _obj; // 0x10
        public short _token; // 0x18

        // ── Methods ──
        public void get_CompletedTask(){} // RVA: 0x7FFE86A83240
        public void .ctor(){} // RVA: 0x7FFE83E7C1F0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE85A7EFA0
        public void Equals(){} // RVA: 0x7FFE86A83470 | overloaded x2
        public void AsTask(){} // RVA: 0x7FFE86A83490
        public void GetTaskForValueTaskSource(){} // RVA: 0x7FFE86A83570
        public void get_IsCompleted(){} // RVA: 0x7FFE86A83890
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7FFE86A83940
        public void ThrowIfCompletedUnsuccessfully(){} // RVA: 0x7FFE86A83A00
        public void GetAwaiter(){} // RVA: 0x7FFE868853C0
        public void ConfigureAwait(){} // RVA: 0x7FFE83E7C100
        public void .cctor(){} // RVA: 0x7FFE86A83AC0
    }

    public class ValueTask`1 : ValueType
    {
        public System.Threading.Tasks.Task`1<UnityEngine.AudioClip> s_canceledTask;
        public object _obj; // 0x10
        public UnityEngine.AudioClip _result; // 0x18
    }

    public class VoidTaskResult : ValueType
    {
    }

}