// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 52
// Methods: 431

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class AsyncCausalityTracer
    {
        // ── Methods ──
        public void get_LoggingOn(){} // RVA: 0x2DD320
        public void TraceOperationCreation(){} // RVA: 0x2DD310
        public void TraceOperationCompletion(){} // RVA: 0x2DD310
        public void TraceSynchronousWorkStart(){} // RVA: 0x2DD310
        public void TraceSynchronousWorkCompletion(){} // RVA: 0x2DD310
    }

    public class AwaitTaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F51240
        public void CreateTask(){} // RVA: 0x5F51360
        public void Run(){} // RVA: 0x5F51440
        public void get_IsValidLocationForInlining(){} // RVA: 0x5F51500
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x5F51610
        public void InvokeAction(){} // RVA: 0x5F516C0
        public void GetInvokeActionCallback(){} // RVA: 0x5F51730
        public void RunCallback(){} // RVA: 0x5F51830
        public void RunOrScheduleAction(){} // RVA: 0x5F519F0
        public void UnsafeScheduleAction(){} // RVA: 0x5F51B60
        public void ThrowAsyncIfNecessary(){} // RVA: 0x5F51C30
        public void MarkAborted(){} // RVA: 0x2DD310
    }

    public class Box`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
    }

    public class CompletionActionInvoker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x5F4FEF0
        public void MarkAborted(){} // RVA: 0x2DD310
    }

    public class ContinuationResultTaskFromResultTask`2
    {
        // ── Methods ──
        public void .ctor(){}
        public void InnerInvoke(){} // RVA: 0x24A50
    }

    public class ContinuationResultTaskFromTask`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void InnerInvoke(){} // RVA: 0x24A50
    }

    public class ContinuationTaskFromResultTask`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void InnerInvoke(){} // RVA: 0x24A50
    }

    public class ContinuationTaskFromTask
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F4FF60
        public void InnerInvoke(){} // RVA: 0x5F50150
    }

    public class DebuggerSupport
    {
        public object IsBackground;

        // ── Methods ──
        public void get_LoggingOn(){} // RVA: 0x2DD320
        public void TraceOperationCreation(){} // RVA: 0x2DD310
        public void TraceOperationCompletion(){} // RVA: 0x2DD310
        public void TraceOperationRelation(){} // RVA: 0x2DD310
        public void TraceSynchronousWorkStart(){} // RVA: 0x2DD310
        public void TraceSynchronousWorkCompletion(){} // RVA: 0x2DD310
        public void AddToActiveTasks(){} // RVA: 0x5F45450
        public void AddToActiveTasksNonInlined(){} // RVA: 0x5F454F0
        public void RemoveFromActiveTasks(){} // RVA: 0x5F456F0
        public void RemoveFromActiveTasksNonInlined(){} // RVA: 0x5F45790
        public void .cctor(){} // RVA: 0x5F45980
    }

    public class ForceAsyncAwaiter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x100A2F0
        public void GetAwaiter(){} // RVA: 0x1AD4690
        public void get_IsCompleted(){} // RVA: 0x2DD320
        public void GetResult(){} // RVA: 0x5F43390
        public void OnCompleted(){} // RVA: 0x5F43430
        public void UnsafeOnCompleted(){} // RVA: 0x5F43500
    }

    public class ITaskCompletionAction
    {
        // ── Methods ──
        public void Invoke(){} // RVA: 0x24B10
        public void get_InvokeMayRunArbitraryCode(){} // RVA: 0xDBE0
    }

    public class IndexRange
    {
    }

    public class Parallel
    {
        // ── Methods ──
        public void CheckTimeoutReached(){} // RVA: 0x5F43910
        public void ComputeTimeoutPoint(){} // RVA: 0x5F43940
        public void ForWorker(){} // RVA: 0x283FA0
        public void ForEach(){} // RVA: 0x283FA0 | overloaded x2
        public void ForEachWorker(){} // RVA: 0x283FA0 | overloaded x3
        public void PartitionerForEachWorker(){} // RVA: 0x283FA0
        public void ReduceToSingleCancellationException(){} // RVA: 0x5F43960
        public void ThrowSingleCancellationExceptionOrOtherException(){} // RVA: 0x5F43C90
        public void .cctor(){} // RVA: 0x5F43CF0
    }

    public class ParallelEtwProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E0E7D0
        public void ParallelLoopBegin(){} // RVA: 0x5F43DC0
        public void ParallelLoopEnd(){} // RVA: 0x5F43DF0
        public void ParallelFork(){} // RVA: 0x1020CE0
        public void ParallelJoin(){} // RVA: 0x1020CE0
        public void .cctor(){} // RVA: 0x5F43E20
    }

    public class ParallelLoopResult
    {
    }

    public class ParallelLoopState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class ParallelLoopState32
    {
        public object LowestBreakIteration;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F43ED0
        public void set_CurrentIteration(){} // RVA: 0x99E0D0
    }

    public class ParallelLoopState64
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F43ED0
        public void set_CurrentIteration(){} // RVA: 0xAE83A0
    }

    public class ParallelLoopStateFlags
    {
        // ── Methods ──
        public void get_LoopStateFlags(){} // RVA: 0x5F2AEC0
        public void AtomicLoopStateUpdate(){} // RVA: 0x5F44070 | overloaded x2
        public void SetExceptional(){} // RVA: 0x5F44180
        public void Cancel(){} // RVA: 0x5F44190
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ParallelLoopStateFlags32
    {
        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x5F441A0
        public void ShouldExitLoop(){} // RVA: 0x5F441E0 | overloaded x2
        public void .ctor(){} // RVA: 0x5F44200
    }

    public class ParallelLoopStateFlags64
    {
        public object LoopStateFlags;

        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x2E07C0
        public void ShouldExitLoop(){} // RVA: 0x5F44210
        public void .ctor(){} // RVA: 0x5F44240
    }

    public class ParallelOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F435D0
        public void get_TaskScheduler(){} // RVA: 0x2F8380
        public void get_EffectiveTaskScheduler(){} // RVA: 0x5F43750
        public void get_MaxDegreeOfParallelism(){} // RVA: 0x5BED50
        public void set_MaxDegreeOfParallelism(){} // RVA: 0x5F437B0
        public void get_CancellationToken(){} // RVA: 0x30B0C0
        public void get_EffectiveMaxConcurrencyLevel(){} // RVA: 0x5F43820
    }

    public class RangeManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F445A0
        public void RegisterNewWorker(){} // RVA: 0x5F447F0
    }

    public class RangeWorker
    {
        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0x1102770
        public void .ctor(){} // RVA: 0x5F44250
        public void FindNewWork(){} // RVA: 0x5F442C0
        public void FindNewWork32(){} // RVA: 0x5F44550
    }

    public class StackGuard
    {
        // ── Methods ──
        public void TryBeginInliningScope(){} // RVA: 0x5F4FF40
        public void EndInliningScope(){} // RVA: 0x5F4FF50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class StandardTaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F50390
        public void Run(){} // RVA: 0x5F504E0
    }

    public class SynchronizationContextAwaitTaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F50650
        public void Run(){} // RVA: 0x5F506D0
        public void PostAction(){} // RVA: 0x5F50920
        public void GetPostActionCallback(){} // RVA: 0x5F509D0
        public void .cctor(){} // RVA: 0x5F50B00
    }

    public class SynchronizationContextTaskScheduler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C34770
        public void QueueTask(){} // RVA: 0x5C34850
        public void TryExecuteTaskInline(){} // RVA: 0x5C348E0
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x3CFAF0
        public void .cctor(){} // RVA: 0x5C34980
    }

    public class SystemThreadingTasks_FutureDebugView`1
    {
    }

    public class SystemThreadingTasks_TaskDebugView
    {
    }

    public class Task
    {
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

    public class TaskContinuation
    {
        // ── Methods ──
        public void Run(){} // RVA: 0x2A620
        public void InlineIfPossibleOrElseQueue(){} // RVA: 0x5F50290
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TaskExceptionHolder
    {
        public object BinaryStackTraceArray;

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

    public class TaskReplicator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F448B0
        public void Run(){} // RVA: 0x2DDE0
        public void GenerateCooperativeMultitaskingTaskTimeout(){} // RVA: 0x5F44A30
    }

    public class TaskScheduler
    {
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

    public class Task`1
    {
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

    public class ThreadPoolTaskScheduler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C34C60
        public void QueueTask(){} // RVA: 0x5C34CB0
        public void TryExecuteTaskInline(){} // RVA: 0x5C35080
        public void TryDequeue(){} // RVA: 0x5C35150
        public void NotifyWorkItemProgress(){} // RVA: 0x5C35160
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x2DD320
        public void .cctor(){} // RVA: 0x5C351D0
    }

    public class UnobservedTaskExceptionEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C34BC0
        public void get_Exception(){} // RVA: 0x2F8380
    }

    public class UnwrapPromise`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2A620
        public void Invoke(){} // RVA: 0x24B10
        public void InvokeCore(){} // RVA: 0x24B10
        public void InvokeCoreAsync(){} // RVA: 0x24B10
        public void ProcessCompletedOuterTask(){} // RVA: 0x24B10
        public void TrySetFromTask(){}
        public void ProcessInnerTask(){} // RVA: 0x24B10
        public void get_InvokeMayRunArbitraryCode(){} // RVA: 0xDBE0
    }

    public class ValueTask
    {
        // ── Methods ──
        public void get_CompletedTask(){} // RVA: 0x5F42420
        public void .ctor(){} // RVA: 0x3121720 | overloaded x3
        public void GetHashCode(){} // RVA: 0x501BC00
        public void Equals(){} // RVA: 0x5F42650 | overloaded x2
        public void AsTask(){} // RVA: 0x5F42670
        public void GetTaskForValueTaskSource(){} // RVA: 0x5F42750
        public void get_IsCompleted(){} // RVA: 0x5F42A70
        public void get_IsCompletedSuccessfully(){} // RVA: 0x5F42B20
        public void ThrowIfCompletedUnsuccessfully(){} // RVA: 0x5F42BE0
        public void GetAwaiter(){} // RVA: 0x5D444C0
        public void ConfigureAwait(){} // RVA: 0x3121630
        public void .cctor(){} // RVA: 0x5F42CA0
    }

    public class ValueTask`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4800040 | overloaded x4
        public void GetHashCode(){} // RVA: 0x4801A00
        public void Equals(){} // RVA: 0x4801090 | overloaded x2
        public void AsTask(){} // RVA: 0x4801AA0
        public void GetTaskForValueTaskSource(){} // RVA: 0x4801BE0
        public void get_IsCompleted(){} // RVA: 0x47D8530
        public void get_IsCompletedSuccessfully(){} // RVA: 0x47D8630
        public void get_Result(){} // RVA: 0x4800A40
        public void GetAwaiter(){} // RVA: 0x2AC89D0
        public void ConfigureAwait(){} // RVA: 0x48021D0
        public void ToString(){} // RVA: 0x4802320
    }

    public class VoidTaskResult
    {
    }

}