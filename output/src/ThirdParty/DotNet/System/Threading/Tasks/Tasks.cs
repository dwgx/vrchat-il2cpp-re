// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 32
// Methods: 372

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class AwaitTaskContinuation : TaskContinuation
    {
        public object IsValidLocationForInlining;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53B088B0
        public void CreateTask(){} // RVA: 0x7FFD53B089D0
        public void Run(){} // RVA: 0x7FFD53B08AB0
        public void get_IsValidLocationForInlining(){} // RVA: 0x7FFD53B08B70
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFD53B08C80
        public void InvokeAction(){} // RVA: 0x7FFD53B08D30
        public void GetInvokeActionCallback(){} // RVA: 0x7FFD53B08DA0
        public void RunCallback(){} // RVA: 0x7FFD53B08EA0
        public void RunOrScheduleAction(){} // RVA: 0x7FFD53B09060
        public void UnsafeScheduleAction(){} // RVA: 0x7FFD53B091D0
        public void ThrowAsyncIfNecessary(){} // RVA: 0x7FFD53B092A0
        public void MarkAborted(){} // RVA: 0x7FFD4E341310
    }

    public class Box`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ContinuationResultTaskFromResultTask`2 : Task`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void InnerInvoke(){} // RVA: 0x7FFD4E090980
    }

    public class ContinuationResultTaskFromTask`1 : Task`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void InnerInvoke(){} // RVA: 0x7FFD4E090980
    }

    public class ContinuationTaskFromResultTask`1 : Task
    {
        // ── Methods ──
        public void .ctor(){}
        public void InnerInvoke(){} // RVA: 0x7FFD4E090980
    }

    public class DebuggerSupport : Object
    {
        public object LoggingOn;

        // ── Methods ──
        public void get_LoggingOn(){} // RVA: 0x7FFD4E341320
        public void TraceOperationCreation(){} // RVA: 0x7FFD4E341310
        public void TraceOperationCompletion(){} // RVA: 0x7FFD4E341310
        public void TraceOperationRelation(){} // RVA: 0x7FFD4E341310
        public void TraceSynchronousWorkStart(){} // RVA: 0x7FFD4E341310
        public void TraceSynchronousWorkCompletion(){} // RVA: 0x7FFD4E341310
        public void AddToActiveTasks(){} // RVA: 0x7FFD53AFCAC0
        public void AddToActiveTasksNonInlined(){} // RVA: 0x7FFD53AFCB60
        public void RemoveFromActiveTasks(){} // RVA: 0x7FFD53AFCD60
        public void RemoveFromActiveTasksNonInlined(){} // RVA: 0x7FFD53AFCE00
        public void .cctor(){} // RVA: 0x7FFD53AFCFF0
    }

    public class ITaskCompletionAction
    {
        public object InvokeMayRunArbitraryCode;

        // ── Methods ──
        public void Invoke(){} // RVA: 0x7FFD4E090A40
        public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFD4E079D00
    }

    public class Parallel : Object
    {
        // ── Methods ──
        public void CheckTimeoutReached(){} // RVA: 0x7FFD53AFAF80
        public void ComputeTimeoutPoint(){} // RVA: 0x7FFD53AFAFB0
        public void ForWorker(){} // RVA: 0x7FFD4E2ADC40
        public void ForEach(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ForEachWorker(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void PartitionerForEachWorker(){} // RVA: 0x7FFD4E2ADC40
        public void ReduceToSingleCancellationException(){} // RVA: 0x7FFD53AFAFD0
        public void ThrowSingleCancellationExceptionOrOtherException(){} // RVA: 0x7FFD53AFB300
        public void .cctor(){} // RVA: 0x7FFD53AFB360
    }

    public class ParallelEtwProvider : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD539C5E30
        public void ParallelLoopBegin(){} // RVA: 0x7FFD53AFB430
        public void ParallelLoopEnd(){} // RVA: 0x7FFD53AFB460
        public void ParallelFork(){} // RVA: 0x7FFD4E9F2DD0
        public void ParallelJoin(){} // RVA: 0x7FFD4E9F2DD0
        public void .cctor(){} // RVA: 0x7FFD53AFB490
    }

    public class ParallelLoopResult : ValueType
    {
    }

    public class ParallelLoopState : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class ParallelLoopState64 : ParallelLoopState
    {
        public object CurrentIteration;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AFB540
        public void set_CurrentIteration(){} // RVA: 0x7FFD4EB2BEE0
    }

    public class ParallelLoopStateFlags : Object
    {
        public object LoopStateFlags;

        // ── Methods ──
        public void get_LoopStateFlags(){} // RVA: 0x7FFD53AE2530
        public void AtomicLoopStateUpdate(){} // RVA: 0x7FFD53AFB6E0 | overloaded x2
        public void SetExceptional(){} // RVA: 0x7FFD53AFB7F0
        public void Cancel(){} // RVA: 0x7FFD53AFB800
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ParallelLoopStateFlags64 : ParallelLoopStateFlags
    {
        public object LowestBreakIteration;

        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x7FFD4E3447C0
        public void ShouldExitLoop(){} // RVA: 0x7FFD53AFB880
        public void .ctor(){} // RVA: 0x7FFD53AFB8B0
    }

    public class ParallelOptions : Object
    {
        public object TaskScheduler;
        public object EffectiveTaskScheduler;
        public object MaxDegreeOfParallelism;
        public object CancellationToken;
        public object EffectiveMaxConcurrencyLevel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AFAC40
        public void get_TaskScheduler(){} // RVA: 0x7FFD4E35C380
        public void get_EffectiveTaskScheduler(){} // RVA: 0x7FFD53AFADC0
        public void get_MaxDegreeOfParallelism(){} // RVA: 0x7FFD4E577800
        public void set_MaxDegreeOfParallelism(){} // RVA: 0x7FFD53AFAE20
        public void get_CancellationToken(){} // RVA: 0x7FFD4E36F0C0
        public void get_EffectiveMaxConcurrencyLevel(){} // RVA: 0x7FFD53AFAE90
    }

    public class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53B07CC0
        public void Run(){} // RVA: 0x7FFD53B07D40
        public void PostAction(){} // RVA: 0x7FFD53B07F90
        public void GetPostActionCallback(){} // RVA: 0x7FFD53B08040
        public void .cctor(){} // RVA: 0x7FFD53B08170
    }

    public class SynchronizationContextTaskScheduler : TaskScheduler
    {
        public object MaximumConcurrencyLevel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537EBCC0
        public void QueueTask(){} // RVA: 0x7FFD537EBDA0
        public void TryExecuteTaskInline(){} // RVA: 0x7FFD537EBE30
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x7FFD4E433AF0
        public void .cctor(){} // RVA: 0x7FFD537EBED0
    }

    public class Task : Object
    {
        public object Options;
        public object IsWaitNotificationEnabledOrNotRanToCompletion;
        public object ShouldNotifyDebuggerOfWaitCompletion;
        public object IsWaitNotificationEnabled;
        public object Id;
        public object CurrentId;
        public object InternalCurrent;
        public object CurrentStackGuard;
        public object Exception;
        public object Status;
        public object IsCanceled;
        public object IsCancellationRequested;
        public object CancellationToken;
        public object IsCancellationAcknowledged;
        public object IsCompleted;
        public object IsCompletedSuccessfully;
        public object CreationOptions;
        public object System.IAsyncResult.AsyncWaitHandle;
        public object AsyncState;
        public object System.IAsyncResult.CompletedSynchronously;
        public object ExecutingTaskScheduler;
        public object Factory;
        public object CompletedTask;
        public object CompletedEvent;
        public object ExceptionRecorded;
        public object IsFaulted;
        public object CapturedContext;
        public object IsExceptionObservedByParent;
        public object IsDelegateInvoked;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AFD7B0 | overloaded x7
        public void TaskConstructorCore(){} // RVA: 0x7FFD53AFD8B0
        public void AssignCancellationToken(){} // RVA: 0x7FFD53AFDC00
        public void TaskCancelCallback(){} // RVA: 0x7FFD53AFE010
        public void TrySetCanceled(){} // RVA: 0x7FFD53AFE160 | overloaded x2
        public void TrySetException(){} // RVA: 0x7FFD53AFE2E0
        public void get_Options(){} // RVA: 0x7FFD53AFE350
        public void OptionsMethod(){} // RVA: 0x7FFD5043CA40
        public void AtomicStateUpdate(){} // RVA: 0x7FFD53AFE490 | overloaded x2
        public void SetNotificationForWaitCompletion(){} // RVA: 0x7FFD53AFE5A0
        public void NotifyDebuggerOfWaitCompletionIfNecessary(){} // RVA: 0x7FFD53AFE690
        public void AnyTaskRequiresNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7FFD53AFE6E0
        public void get_IsWaitNotificationEnabledOrNotRanToCompletion(){} // RVA: 0x7FFD53AFE760
        public void get_ShouldNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7FFD53AFE780
        public void get_IsWaitNotificationEnabled(){} // RVA: 0x7FFD53AFE780
        public void NotifyDebuggerOfWaitCompletion(){} // RVA: 0x7FFD53AFE7A0
        public void MarkStarted(){} // RVA: 0x7FFD53AFE7D0
        public void AddNewChild(){} // RVA: 0x7FFD53AFE7F0
        public void DisregardChild(){} // RVA: 0x7FFD53AFE840
        public void Start(){} // RVA: 0x7FFD53AFE870
        public void RunSynchronously(){} // RVA: 0x7FFD53AFEAA0
        public void InternalRunSynchronously(){} // RVA: 0x7FFD53AFEB10
        public void InternalStartNew(){} // RVA: 0x7FFD53AFEE80
        public void get_Id(){} // RVA: 0x7FFD53AFF040
        public void get_CurrentId(){} // RVA: 0x7FFD53AFF0D0
        public void get_InternalCurrent(){} // RVA: 0x7FFD53AFF150
        public void InternalCurrentIfAttached(){} // RVA: 0x7FFD53AFF1F0
        public void get_CurrentStackGuard(){} // RVA: 0x7FFD53AFF250
        public void get_Exception(){} // RVA: 0x7FFD53AFF390
        public void get_Status(){} // RVA: 0x7FFD53AFF3C0
        public void get_IsCanceled(){} // RVA: 0x7FFD53AFF420
        public void get_IsCancellationRequested(){} // RVA: 0x7FFD53AFF440
        public void EnsureContingentPropertiesInitialized(){} // RVA: 0x7FFD53AFF4D0
        public void EnsureContingentPropertiesInitializedCore(){} // RVA: 0x7FFD53AFF620
        public void get_CancellationToken(){} // RVA: 0x7FFD53AFF760
        public void get_IsCancellationAcknowledged(){} // RVA: 0x7FFD53AFF780
        public void get_IsCompleted(){} // RVA: 0x7FFD53AFF7A0
        public void IsCompletedMethod(){} // RVA: 0x7FFD53AFF800
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7FFD53AFF810
        public void get_CreationOptions(){} // RVA: 0x7FFD53AFF830
        public void System.IAsyncResult.get_AsyncWaitHandle(){} // RVA: 0x7FFD53AFF880
        public void get_AsyncState(){} // RVA: 0x7FFD4E36F0C0
        public void System.IAsyncResult.get_CompletedSynchronously(){} // RVA: 0x7FFD4E341320
        public void get_ExecutingTaskScheduler(){} // RVA: 0x7FFD4E36F130
        public void get_Factory(){} // RVA: 0x7FFD53AFF930
        public void get_CompletedTask(){} // RVA: 0x7FFD53AFF990
        public void get_CompletedEvent(){} // RVA: 0x7FFD53AFF9F0
        public void get_ExceptionRecorded(){} // RVA: 0x7FFD53AFFB70
        public void get_IsFaulted(){} // RVA: 0x7FFD53AFFBC0
        public void get_CapturedContext(){} // RVA: 0x7FFD53AFFBE0
        public void set_CapturedContext(){} // RVA: 0x7FFD53AFFC60
        public void Dispose(){} // RVA: 0x7FFD53AFFDB0 | overloaded x2
        public void ScheduleAndStart(){} // RVA: 0x7FFD53AFFEE0
        public void AddException(){} // RVA: 0x7FFD53B00070 | overloaded x2
        public void GetExceptions(){} // RVA: 0x7FFD53B00380
        public void GetExceptionDispatchInfos(){} // RVA: 0x7FFD53B00550
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x7FFD53B007E0
        public void ThrowIfExceptional(){} // RVA: 0x7FFD53B00810
        public void UpdateExceptionObservedStatus(){} // RVA: 0x7FFD53B00860
        public void get_IsExceptionObservedByParent(){} // RVA: 0x7FFD53B00980
        public void get_IsDelegateInvoked(){} // RVA: 0x7FFD53B009A0
        public void Finish(){} // RVA: 0x7FFD53B009C0
        public void FinishStageTwo(){} // RVA: 0x7FFD53B00BF0
        public void FinishStageThree(){} // RVA: 0x7FFD53B00D30
        public void ProcessChildCompletion(){} // RVA: 0x7FFD53B00E20
        public void AddExceptionsFromChildren(){} // RVA: 0x7FFD53B010F0
        public void Execute(){} // RVA: 0x7FFD53B014F0
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFD53B01530
        public void ExecuteEntry(){} // RVA: 0x7FFD53B01540
        public void ExecutionContextCallback(){} // RVA: 0x7FFD53B01720
        public void InnerInvoke(){} // RVA: 0x7FFD53B017B0
        public void HandleException(){} // RVA: 0x7FFD53B01850
        public void GetAwaiter(){} // RVA: 0x7FFD4ECF6FB0
        public void ConfigureAwait(){} // RVA: 0x7FFD53B01990
        public void SetContinuationForAwait(){} // RVA: 0x7FFD53B019B0
        public void Yield(){} // RVA: 0x7FFD4E341320
        public void Wait(){} // RVA: 0x7FFD53B01C80 | overloaded x3
        public void WrappedTryRunInline(){} // RVA: 0x7FFD53B01DC0
        public void InternalWait(){} // RVA: 0x7FFD53B01E60
        public void SpinThenBlockingWait(){} // RVA: 0x7FFD53B02330
        public void SpinWait(){} // RVA: 0x7FFD53B02740
        public void InternalCancel(){} // RVA: 0x7FFD53B028F0
        public void RecordInternalCancellationRequest(){} // RVA: 0x7FFD53B02C30 | overloaded x3
        public void CancellationCleanupLogic(){} // RVA: 0x7FFD53B02D60
        public void SetCancellationAcknowledged(){} // RVA: 0x7FFD53B02E20
        public void FinishContinuations(){} // RVA: 0x7FFD53B02E40
        public void LogFinishCompletionNotification(){} // RVA: 0x7FFD53B034F0
        public void ContinueWith(){} // RVA: 0x7FFD4E2ADC40 | overloaded x8
        public void CreationOptionsFromContinuationOptions(){} // RVA: 0x7FFD53B039B0
        public void ContinueWithCore(){} // RVA: 0x7FFD53B03B10
        public void AddCompletionAction(){} // RVA: 0x7FFD53B03E70 | overloaded x2
        public void AddTaskContinuationComplex(){} // RVA: 0x7FFD53B03EF0
        public void AddTaskContinuation(){} // RVA: 0x7FFD53B042E0
        public void RemoveContinuation(){} // RVA: 0x7FFD53B043F0
        public void FromResult(){} // RVA: 0x7FFD4E2ADC40
        public void FromException(){} // RVA: 0x7FFD4E078F80 | overloaded x2
        public void FromCancellation(){} // RVA: 0x7FFD4E078F80 | overloaded x3
        public void FromCanceled(){} // RVA: 0x7FFD4E087ED0 | overloaded x2
        public void Run(){} // RVA: 0x7FFD4E07EA50 | overloaded x6
        public void Delay(){} // RVA: 0x7FFD53B04F80 | overloaded x3
        public void WhenAll(){} // RVA: 0x7FFD4E078F80 | overloaded x2
        public void InternalWhenAll(){} // RVA: 0x7FFD4E078F80 | overloaded x2
        public void WhenAny(){} // RVA: 0x7FFD53B058E0 | overloaded x2
        public void CreateUnwrapPromise(){} // RVA: 0x7FFD4E089730
        public void AddToActiveTasks(){} // RVA: 0x7FFD53B05BD0
        public void RemoveFromActiveTasks(){} // RVA: 0x7FFD53B05E00
        public void MarkAborted(){} // RVA: 0x7FFD4E341310
        public void ExecuteWithThreadLocal(){} // RVA: 0x7FFD53B05FD0
        public void .cctor(){} // RVA: 0x7FFD53B06300
    }

    public class TaskCompletionSource`1 : Object
    {
        public object Task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51E025B0 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFD4E35C380
        public void SpinUntilCompleted(){} // RVA: 0x7FFD51E02680
        public void TrySetException(){} // RVA: 0x7FFD51E02790
        public void SetException(){} // RVA: 0x7FFD51E02810
        public void TrySetResult(){} // RVA: 0x7FFD51E02860
        public void SetResult(){} // RVA: 0x7FFD51E02970
        public void TrySetCanceled(){} // RVA: 0x7FFD51E02A90 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFD51E02B40
    }

    public class TaskExtensions : Object
    {
        // ── Methods ──
        public void Unwrap(){} // RVA: 0x7FFD4E078F80 | overloaded x2
    }

    public class TaskFactory : Object
    {
        public object Scheduler;

        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x7FFD537EA370
        public void .ctor(){} // RVA: 0x7FFD51E02D00 | overloaded x2
        public void CheckCreationOptions(){} // RVA: 0x7FFD537EA460
        public void get_Scheduler(){} // RVA: 0x7FFD4E3447C0
        public void StartNew(){} // RVA: 0x7FFD4E2ADC40 | overloaded x6
        public void FromAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void CheckFromAsyncOptions(){} // RVA: 0x7FFD537EA6A0
        public void CommonCWAnyLogic(){} // RVA: 0x7FFD537EA7D0
        public void CheckMultiTaskContinuationOptions(){} // RVA: 0x7FFD537EAAB0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x7FFD4E078F40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void StartNew(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void FromAsyncCoreLogic(){}
        public void FromAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void FromAsyncImpl(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void FromAsyncTrim(){} // RVA: 0x7FFD4E2ADC40
    }

    public class TaskReplicator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AFBF20
        public void Run(){} // RVA: 0x7FFD4E099CB0
        public void GenerateCooperativeMultitaskingTaskTimeout(){} // RVA: 0x7FFD53AFC0A0
    }

    public class TaskScheduler : Object
    {
        public object MaximumConcurrencyLevel;
        public object RequiresAtomicStartTransition;
        public object Default;
        public object Current;
        public object InternalCurrent;
        public object Id;

        // ── Methods ──
        public void QueueTask(){} // RVA: 0x7FFD4E090A40
        public void TryExecuteTaskInline(){}
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x7FFD537EAF20
        public void TryRunInline(){} // RVA: 0x7FFD537EAF30
        public void TryDequeue(){} // RVA: 0x7FFD4E341320
        public void NotifyWorkItemProgress(){} // RVA: 0x7FFD4E341310
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x7FFD4E426850
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_Default(){} // RVA: 0x7FFD537EB150
        public void get_Current(){} // RVA: 0x7FFD537EB1B0
        public void get_InternalCurrent(){} // RVA: 0x7FFD537EB260
        public void FromCurrentSynchronizationContext(){} // RVA: 0x7FFD537EB310
        public void get_Id(){} // RVA: 0x7FFD537EB430
        public void TryExecuteTask(){} // RVA: 0x7FFD537EB4D0
        public void add_UnobservedTaskException(){} // RVA: 0x7FFD537EB550
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFD537EB790
        public void PublishUnobservedTaskException(){} // RVA: 0x7FFD537EB980
        public void .cctor(){} // RVA: 0x7FFD537EBAA0
    }

    public class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53B07CC0
        public void Run(){} // RVA: 0x7FFD53B083A0
    }

    public class TaskToApm : Object
    {
        // ── Methods ──
        public void Begin(){} // RVA: 0x7FFD543AF9F0
        public void End(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x7FFD543AFCA0
    }

    public class Task`1 : Task
    {
        public object Result;
        public object ResultOnSuccess;
        public object Factory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD52067050 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFD52067360 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFD52067530
        public void DangerousSetResult(){} // RVA: 0x7FFD520676C0
        public void get_Result(){} // RVA: 0x7FFD4E27B230
        public void get_ResultOnSuccess(){} // RVA: 0x7FFD4E27B230
        public void GetResultCore(){} // RVA: 0x7FFD4E27B230
        public void get_Factory(){} // RVA: 0x7FFD52067AD0
        public void InnerInvoke(){} // RVA: 0x7FFD52067C90
        public void GetAwaiter(){} // RVA: 0x7FFD51EF52A0
        public void ConfigureAwait(){} // RVA: 0x7FFD51EF5300
        public void ContinueWith(){} // RVA: 0x7FFD4E2ADC40 | overloaded x10
    }

    public class ThreadPoolTaskScheduler : TaskScheduler
    {
        public object RequiresAtomicStartTransition;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537EC1B0
        public void QueueTask(){} // RVA: 0x7FFD537EC200
        public void TryExecuteTaskInline(){} // RVA: 0x7FFD537EC5D0
        public void TryDequeue(){} // RVA: 0x7FFD537EC6A0
        public void NotifyWorkItemProgress(){} // RVA: 0x7FFD537EC6B0
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x7FFD4E341320
        public void .cctor(){} // RVA: 0x7FFD537EC720
    }

    public class UnwrapPromise`1 : Task`1
    {
        public object InvokeMayRunArbitraryCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E096500
        public void Invoke(){} // RVA: 0x7FFD4E090A40
        public void InvokeCore(){} // RVA: 0x7FFD4E090A40
        public void InvokeCoreAsync(){} // RVA: 0x7FFD4E090A40
        public void ProcessCompletedOuterTask(){} // RVA: 0x7FFD4E090A40
        public void TrySetFromTask(){}
        public void ProcessInnerTask(){} // RVA: 0x7FFD4E090A40
        public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFD4E079D00
    }

    public class ValueTask : ValueType
    {
        public object CompletedTask;
        public object IsCompleted;
        public object IsCompletedSuccessfully;

        // ── Methods ──
        public void get_CompletedTask(){} // RVA: 0x7FFD53AF9A90
        public void .ctor(){} // RVA: 0x7FFD50EA2840 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFD52B81A90
        public void Equals(){} // RVA: 0x7FFD53AF9CC0 | overloaded x2
        public void AsTask(){} // RVA: 0x7FFD53AF9CE0
        public void GetTaskForValueTaskSource(){} // RVA: 0x7FFD53AF9DC0
        public void get_IsCompleted(){} // RVA: 0x7FFD53AFA0E0
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7FFD53AFA190
        public void ThrowIfCompletedUnsuccessfully(){} // RVA: 0x7FFD53AFA250
        public void GetAwaiter(){} // RVA: 0x7FFD538FBB90
        public void ConfigureAwait(){} // RVA: 0x7FFD50EA2750
        public void .cctor(){} // RVA: 0x7FFD53AFA310
    }

    public class ValueTask`1 : ValueType
    {
        public object IsCompleted;
        public object IsCompletedSuccessfully;
        public object Result;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5248FAC0 | overloaded x4
        public void GetHashCode(){} // RVA: 0x7FFD52491480
        public void Equals(){} // RVA: 0x7FFD52490B10 | overloaded x2
        public void AsTask(){} // RVA: 0x7FFD52491520
        public void GetTaskForValueTaskSource(){} // RVA: 0x7FFD52491660
        public void get_IsCompleted(){} // RVA: 0x7FFD5246CC00
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7FFD5246CD00
        public void get_Result(){} // RVA: 0x7FFD524904C0
        public void GetAwaiter(){} // RVA: 0x7FFD508B29A0
        public void ConfigureAwait(){} // RVA: 0x7FFD52491C50
        public void ToString(){} // RVA: 0x7FFD52491DA0
    }

    public class VoidTaskResult : ValueType
    {
    }

}