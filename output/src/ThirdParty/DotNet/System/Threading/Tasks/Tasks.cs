// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 52
// Methods: 431

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class AsyncCausalityTracer : Object
    {
        public object LoggingOn;

        // ── Methods ──
        public void get_LoggingOn(){} // RVA: 0x7FFAC2F21320
        public void TraceOperationCreation(){} // RVA: 0x7FFAC2F21310
        public void TraceOperationCompletion(){} // RVA: 0x7FFAC2F21310
        public void TraceSynchronousWorkStart(){} // RVA: 0x7FFAC2F21310
        public void TraceSynchronousWorkCompletion(){} // RVA: 0x7FFAC2F21310
    }

    public class AwaitTaskContinuation : TaskContinuation
    {
        public System.Threading.ExecutionContext IsValidLocationForInlining; // 0x10
        public System.Action m_action; // 0x18
        public System.Threading.ContextCallback s_invokeActionCallback;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86E88B0
        public void CreateTask(){} // RVA: 0x7FFAC86E89D0
        public void Run(){} // RVA: 0x7FFAC86E8AB0
        public void get_IsValidLocationForInlining(){} // RVA: 0x7FFAC86E8B70
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFAC86E8C80
        public void InvokeAction(){} // RVA: 0x7FFAC86E8D30
        public void GetInvokeActionCallback(){} // RVA: 0x7FFAC86E8DA0
        public void RunCallback(){} // RVA: 0x7FFAC86E8EA0
        public void RunOrScheduleAction(){} // RVA: 0x7FFAC86E9060
        public void UnsafeScheduleAction(){} // RVA: 0x7FFAC86E91D0
        public void ThrowAsyncIfNecessary(){} // RVA: 0x7FFAC86E92A0
        public void MarkAborted(){} // RVA: 0x7FFAC2F21310
    }

    public class Box`1 : Object
    {
        public T Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    }

    public class CompletionActionInvoker : Object
    {
        public System.Threading.Tasks.ITaskCompletionAction m_action; // 0x10
        public System.Threading.Tasks.Task m_completingTask; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFAC86E7560
        public void MarkAborted(){} // RVA: 0x7FFAC2F21310
    }

    public class ContinuationResultTaskFromResultTask`2 : Task`1
    {
        public System.Threading.Tasks.Task`1<U> m_antecedent;

        // ── Methods ──
        public void .ctor(){}
        public void InnerInvoke(){} // RVA: 0x7FFAC2C70980
    }

    public class ContinuationResultTaskFromTask`1 : Task`1
    {
        public System.Threading.Tasks.Task m_antecedent;

        // ── Methods ──
        public void .ctor(){}
        public void InnerInvoke(){} // RVA: 0x7FFAC2C70980
    }

    public class ContinuationTaskFromResultTask`1 : Task
    {
        public System.Threading.Tasks.Task`1<T> m_antecedent;

        // ── Methods ──
        public void .ctor(){}
        public void InnerInvoke(){} // RVA: 0x7FFAC2C70980
    }

    public class ContinuationTaskFromTask : Task
    {
        public System.Threading.Tasks.Task m_antecedent; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86E75D0
        public void InnerInvoke(){} // RVA: 0x7FFAC86E77C0
    }

    public class DebuggerSupport : Object
    {
        public System.Collections.Generic.LowLevelDictionary`2<int,System.Threading.Tasks.Task> LoggingOn;
        public object s_activeTasksLock; // 0x8

        // ── Methods ──
        public void get_LoggingOn(){} // RVA: 0x7FFAC2F21320
        public void TraceOperationCreation(){} // RVA: 0x7FFAC2F21310
        public void TraceOperationCompletion(){} // RVA: 0x7FFAC2F21310
        public void TraceOperationRelation(){} // RVA: 0x7FFAC2F21310
        public void TraceSynchronousWorkStart(){} // RVA: 0x7FFAC2F21310
        public void TraceSynchronousWorkCompletion(){} // RVA: 0x7FFAC2F21310
        public void AddToActiveTasks(){} // RVA: 0x7FFAC86DCAC0
        public void AddToActiveTasksNonInlined(){} // RVA: 0x7FFAC86DCB60
        public void RemoveFromActiveTasks(){} // RVA: 0x7FFAC86DCD60
        public void RemoveFromActiveTasksNonInlined(){} // RVA: 0x7FFAC86DCE00
        public void .cctor(){} // RVA: 0x7FFAC86DCFF0
    }

    public class ForceAsyncAwaiter : ValueType
    {
        public System.Threading.Tasks.Task IsCompleted; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void GetAwaiter(){} // RVA: 0x7FFAC3AD9F60
        public void get_IsCompleted(){} // RVA: 0x7FFAC2F21320
        public void GetResult(){} // RVA: 0x7FFAC86DAA00
        public void OnCompleted(){} // RVA: 0x7FFAC86DAAA0
        public void UnsafeOnCompleted(){} // RVA: 0x7FFAC86DAB70
    }

    public class ITaskCompletionAction
    {
        public object InvokeMayRunArbitraryCode;

        // ── Methods ──
        public void Invoke(){} // RVA: 0x7FFAC2C70A40
        public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFAC2C59D00
    }

    public class IndexRange : ValueType
    {
        public long _nFromInclusive; // 0x10
        public long _nToExclusive; // 0x18
        public System.Threading.Tasks.Box`1<long> _nSharedCurrentIndexOffset; // 0x20
        public int _bRangeFinished; // 0x28
    }

    public class Parallel : Object
    {
        public int s_forkJoinContextID;
        public System.Threading.Tasks.ParallelOptions s_defaultParallelOptions; // 0x8

        // ── Methods ──
        public void CheckTimeoutReached(){} // RVA: 0x7FFAC86DAF80
        public void ComputeTimeoutPoint(){} // RVA: 0x7FFAC86DAFB0
        public void ForWorker(){} // RVA: 0x7FFAC2E8DC40
        public void ForEach(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ForEachWorker(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void PartitionerForEachWorker(){} // RVA: 0x7FFAC2E8DC40
        public void ReduceToSingleCancellationException(){} // RVA: 0x7FFAC86DAFD0
        public void ThrowSingleCancellationExceptionOrOtherException(){} // RVA: 0x7FFAC86DB300
        public void .cctor(){} // RVA: 0x7FFAC86DB360
    }

    public class ParallelEtwProvider : EventSource
    {
        public System.Threading.Tasks.ParallelEtwProvider Log;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85A5E30
        public void ParallelLoopBegin(){} // RVA: 0x7FFAC86DB430
        public void ParallelLoopEnd(){} // RVA: 0x7FFAC86DB460
        public void ParallelFork(){} // RVA: 0x7FFAC35D2DD0
        public void ParallelJoin(){} // RVA: 0x7FFAC35D2DD0
        public void .cctor(){} // RVA: 0x7FFAC86DB490
    }

    public class ParallelLoopResult : ValueType
    {
        public bool _completed; // 0x10
        public System.Nullable`1<long> _lowestBreakIteration; // 0x18
    }

    public class ParallelLoopState : Object
    {
        public System.Threading.Tasks.ParallelLoopStateFlags _flagsBase; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class ParallelLoopState32 : ParallelLoopState
    {
        public System.Threading.Tasks.ParallelLoopStateFlags32 CurrentIteration; // 0x18
        public int _currentIteration; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86DB540
        public void set_CurrentIteration(){} // RVA: 0x7FFAC35DB7A0
    }

    public class ParallelLoopState64 : ParallelLoopState
    {
        public System.Threading.Tasks.ParallelLoopStateFlags64 CurrentIteration; // 0x18
        public long _currentIteration; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86DB540
        public void set_CurrentIteration(){} // RVA: 0x7FFAC370BEE0
    }

    public class ParallelLoopStateFlags : Object
    {
        public int LoopStateFlags; // 0x10

        // ── Methods ──
        public void get_LoopStateFlags(){} // RVA: 0x7FFAC86C2530
        public void AtomicLoopStateUpdate(){} // RVA: 0x7FFAC86DB6E0 | overloaded x2
        public void SetExceptional(){} // RVA: 0x7FFAC86DB7F0
        public void Cancel(){} // RVA: 0x7FFAC86DB800
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ParallelLoopStateFlags32 : ParallelLoopStateFlags
    {
        public int LowestBreakIteration; // 0x18

        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x7FFAC86DB810
        public void ShouldExitLoop(){} // RVA: 0x7FFAC86DB850 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC86DB870
    }

    public class ParallelLoopStateFlags64 : ParallelLoopStateFlags
    {
        public long LowestBreakIteration; // 0x18

        // ── Methods ──
        public void get_LowestBreakIteration(){} // RVA: 0x7FFAC2F247C0
        public void ShouldExitLoop(){} // RVA: 0x7FFAC86DB880
        public void .ctor(){} // RVA: 0x7FFAC86DB8B0
    }

    public class ParallelOptions : Object
    {
        public System.Threading.Tasks.TaskScheduler TaskScheduler; // 0x10
        public int EffectiveTaskScheduler; // 0x18
        public System.Threading.CancellationToken MaxDegreeOfParallelism; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86DAC40
        public void get_TaskScheduler(){} // RVA: 0x7FFAC2F3C380
        public void get_EffectiveTaskScheduler(){} // RVA: 0x7FFAC86DADC0
        public void get_MaxDegreeOfParallelism(){} // RVA: 0x7FFAC3157800
        public void set_MaxDegreeOfParallelism(){} // RVA: 0x7FFAC86DAE20
        public void get_CancellationToken(){} // RVA: 0x7FFAC2F4F0C0
        public void get_EffectiveMaxConcurrencyLevel(){} // RVA: 0x7FFAC86DAE90
    }

    public class RangeManager : Object
    {
        public System.Threading.Tasks.IndexRange[] _indexRanges; // 0x10
        public bool _use32BitCurrentIndex; // 0x18
        public int _nCurrentIndexRangeToAssign; // 0x1C
        public long _nStep; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86DBC10
        public void RegisterNewWorker(){} // RVA: 0x7FFAC86DBE60
    }

    public class RangeWorker : ValueType
    {
        public System.Threading.Tasks.IndexRange[] IsInitialized; // 0x10
        public int _nCurrentIndexRange; // 0x18
        public long _nStep; // 0x20
        public long _nIncrementValue; // 0x28
        public long _nMaxIncrementValue; // 0x30
        public bool _use32BitCurrentIndex; // 0x38

        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0x7FFAC3BB0800
        public void .ctor(){} // RVA: 0x7FFAC86DB8C0
        public void FindNewWork(){} // RVA: 0x7FFAC86DB930
        public void FindNewWork32(){} // RVA: 0x7FFAC86DBBC0
    }

    public class StackGuard : Object
    {
        public int m_inliningDepth; // 0x10
        public int MAX_UNCHECKED_INLINING_DEPTH;

        // ── Methods ──
        public void TryBeginInliningScope(){} // RVA: 0x7FFAC86E75B0
        public void EndInliningScope(){} // RVA: 0x7FFAC86E75C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StandardTaskContinuation : TaskContinuation
    {
        public System.Threading.Tasks.Task m_task; // 0x10
        public 0x6B0C8F50 m_options; // 0x18
        public System.Threading.Tasks.TaskScheduler m_taskScheduler; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86E7A00
        public void Run(){} // RVA: 0x7FFAC86E7B50
    }

    public class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
    {
        public System.Threading.SendOrPostCallback s_postCallback;
        public System.Threading.ContextCallback s_postActionCallback; // 0x8
        public System.Threading.SynchronizationContext m_syncContext; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86E7CC0
        public void Run(){} // RVA: 0x7FFAC86E7D40
        public void PostAction(){} // RVA: 0x7FFAC86E7F90
        public void GetPostActionCallback(){} // RVA: 0x7FFAC86E8040
        public void .cctor(){} // RVA: 0x7FFAC86E8170
    }

    public class SynchronizationContextTaskScheduler : TaskScheduler
    {
        public System.Threading.SynchronizationContext MaximumConcurrencyLevel; // 0x18
        public System.Threading.SendOrPostCallback s_postCallback;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83CBCC0
        public void QueueTask(){} // RVA: 0x7FFAC83CBDA0
        public void TryExecuteTaskInline(){} // RVA: 0x7FFAC83CBE30
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x7FFAC3013AF0
        public void .cctor(){} // RVA: 0x7FFAC83CBED0
    }

    public class SystemThreadingTasks_FutureDebugView`1 : Object
    {
    }

    public class SystemThreadingTasks_TaskDebugView : Object
    {
    }

    public class Task : Object
    {
        public int Options;
        public int IsWaitNotificationEnabledOrNotRanToCompletion; // 0x10
        public System.Delegate ShouldNotifyDebuggerOfWaitCompletion; // 0x18
        public object IsWaitNotificationEnabled; // 0x20
        public System.Threading.Tasks.TaskScheduler Id; // 0x28
        public System.Threading.Tasks.Task CurrentId; // 0x30
        public int InternalCurrent; // 0x38
        public int CurrentStackGuard;
        public int Exception;
        public int Status;
        public int IsCanceled;
        public int IsCancellationRequested;
        public int CancellationToken;
        public int IsCancellationAcknowledged;
        public int IsCompleted;
        public int IsCompletedSuccessfully;
        public int CreationOptions;
        public int System.IAsyncResult.AsyncWaitHandle;
        public int AsyncState;
        public int System.IAsyncResult.CompletedSynchronously;
        public int ExecutingTaskScheduler;
        public int Factory;
        public int CompletedTask;
        public object CompletedEvent; // 0x40
        public object ExceptionRecorded; // 0x8
        public bool IsFaulted; // 0x10
        public ContingentProperties CapturedContext; // 0x48
        public System.Action`1<object> IsExceptionObservedByParent; // 0x18
        public System.Threading.Tasks.Task IsDelegateInvoked; // 0xFFFF
        public System.Threading.Tasks.StackGuard t_stackGuard; // 0xFFFF
        public System.Func`1<ContingentProperties> s_createContingentProperties; // 0x20
        public System.Threading.Tasks.TaskFactory <Factory>k__BackingField; // 0x28
        public System.Threading.Tasks.Task <CompletedTask>k__BackingField; // 0x30
        public System.Predicate`1<System.Threading.Tasks.Task> s_IsExceptionObservedByParentPredicate; // 0x38
        public System.Threading.ContextCallback s_ecCallback; // 0x40
        public System.Predicate`1<object> s_IsTaskContinuationNullPredicate; // 0x48
        public System.Collections.Generic.Dictionary`2<int,System.Threading.Tasks.Task> s_currentActiveTasks; // 0x50
        public object s_activeTasksLock; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86DD7B0 | overloaded x7
        public void TaskConstructorCore(){} // RVA: 0x7FFAC86DD8B0
        public void AssignCancellationToken(){} // RVA: 0x7FFAC86DDC00
        public void TaskCancelCallback(){} // RVA: 0x7FFAC86DE010
        public void TrySetCanceled(){} // RVA: 0x7FFAC86DE160 | overloaded x2
        public void TrySetException(){} // RVA: 0x7FFAC86DE2E0
        public void get_Options(){} // RVA: 0x7FFAC86DE350
        public void OptionsMethod(){} // RVA: 0x7FFAC501CA40
        public void AtomicStateUpdate(){} // RVA: 0x7FFAC86DE490 | overloaded x2
        public void SetNotificationForWaitCompletion(){} // RVA: 0x7FFAC86DE5A0
        public void NotifyDebuggerOfWaitCompletionIfNecessary(){} // RVA: 0x7FFAC86DE690
        public void AnyTaskRequiresNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7FFAC86DE6E0
        public void get_IsWaitNotificationEnabledOrNotRanToCompletion(){} // RVA: 0x7FFAC86DE760
        public void get_ShouldNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7FFAC86DE780
        public void get_IsWaitNotificationEnabled(){} // RVA: 0x7FFAC86DE780
        public void NotifyDebuggerOfWaitCompletion(){} // RVA: 0x7FFAC86DE7A0
        public void MarkStarted(){} // RVA: 0x7FFAC86DE7D0
        public void AddNewChild(){} // RVA: 0x7FFAC86DE7F0
        public void DisregardChild(){} // RVA: 0x7FFAC86DE840
        public void Start(){} // RVA: 0x7FFAC86DE870
        public void RunSynchronously(){} // RVA: 0x7FFAC86DEAA0
        public void InternalRunSynchronously(){} // RVA: 0x7FFAC86DEB10
        public void InternalStartNew(){} // RVA: 0x7FFAC86DEE80
        public void get_Id(){} // RVA: 0x7FFAC86DF040
        public void get_CurrentId(){} // RVA: 0x7FFAC86DF0D0
        public void get_InternalCurrent(){} // RVA: 0x7FFAC86DF150
        public void InternalCurrentIfAttached(){} // RVA: 0x7FFAC86DF1F0
        public void get_CurrentStackGuard(){} // RVA: 0x7FFAC86DF250
        public void get_Exception(){} // RVA: 0x7FFAC86DF390
        public void get_Status(){} // RVA: 0x7FFAC86DF3C0
        public void get_IsCanceled(){} // RVA: 0x7FFAC86DF420
        public void get_IsCancellationRequested(){} // RVA: 0x7FFAC86DF440
        public void EnsureContingentPropertiesInitialized(){} // RVA: 0x7FFAC86DF4D0
        public void EnsureContingentPropertiesInitializedCore(){} // RVA: 0x7FFAC86DF620
        public void get_CancellationToken(){} // RVA: 0x7FFAC86DF760
        public void get_IsCancellationAcknowledged(){} // RVA: 0x7FFAC86DF780
        public void get_IsCompleted(){} // RVA: 0x7FFAC86DF7A0
        public void IsCompletedMethod(){} // RVA: 0x7FFAC86DF800
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7FFAC86DF810
        public void get_CreationOptions(){} // RVA: 0x7FFAC86DF830
        public void System.IAsyncResult.get_AsyncWaitHandle(){} // RVA: 0x7FFAC86DF880
        public void get_AsyncState(){} // RVA: 0x7FFAC2F4F0C0
        public void System.IAsyncResult.get_CompletedSynchronously(){} // RVA: 0x7FFAC2F21320
        public void get_ExecutingTaskScheduler(){} // RVA: 0x7FFAC2F4F130
        public void get_Factory(){} // RVA: 0x7FFAC86DF930
        public void get_CompletedTask(){} // RVA: 0x7FFAC86DF990
        public void get_CompletedEvent(){} // RVA: 0x7FFAC86DF9F0
        public void get_ExceptionRecorded(){} // RVA: 0x7FFAC86DFB70
        public void get_IsFaulted(){} // RVA: 0x7FFAC86DFBC0
        public void get_CapturedContext(){} // RVA: 0x7FFAC86DFBE0
        public void set_CapturedContext(){} // RVA: 0x7FFAC86DFC60
        public void Dispose(){} // RVA: 0x7FFAC86DFDB0 | overloaded x2
        public void ScheduleAndStart(){} // RVA: 0x7FFAC86DFEE0
        public void AddException(){} // RVA: 0x7FFAC86E0070 | overloaded x2
        public void GetExceptions(){} // RVA: 0x7FFAC86E0380
        public void GetExceptionDispatchInfos(){} // RVA: 0x7FFAC86E0550
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x7FFAC86E07E0
        public void ThrowIfExceptional(){} // RVA: 0x7FFAC86E0810
        public void UpdateExceptionObservedStatus(){} // RVA: 0x7FFAC86E0860
        public void get_IsExceptionObservedByParent(){} // RVA: 0x7FFAC86E0980
        public void get_IsDelegateInvoked(){} // RVA: 0x7FFAC86E09A0
        public void Finish(){} // RVA: 0x7FFAC86E09C0
        public void FinishStageTwo(){} // RVA: 0x7FFAC86E0BF0
        public void FinishStageThree(){} // RVA: 0x7FFAC86E0D30
        public void ProcessChildCompletion(){} // RVA: 0x7FFAC86E0E20
        public void AddExceptionsFromChildren(){} // RVA: 0x7FFAC86E10F0
        public void Execute(){} // RVA: 0x7FFAC86E14F0
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFAC86E1530
        public void ExecuteEntry(){} // RVA: 0x7FFAC86E1540
        public void ExecutionContextCallback(){} // RVA: 0x7FFAC86E1720
        public void InnerInvoke(){} // RVA: 0x7FFAC86E17B0
        public void HandleException(){} // RVA: 0x7FFAC86E1850
        public void GetAwaiter(){} // RVA: 0x7FFAC38D6FB0
        public void ConfigureAwait(){} // RVA: 0x7FFAC86E1990
        public void SetContinuationForAwait(){} // RVA: 0x7FFAC86E19B0
        public void Yield(){} // RVA: 0x7FFAC2F21320
        public void Wait(){} // RVA: 0x7FFAC86E1C80 | overloaded x3
        public void WrappedTryRunInline(){} // RVA: 0x7FFAC86E1DC0
        public void InternalWait(){} // RVA: 0x7FFAC86E1E60
        public void SpinThenBlockingWait(){} // RVA: 0x7FFAC86E2330
        public void SpinWait(){} // RVA: 0x7FFAC86E2740
        public void InternalCancel(){} // RVA: 0x7FFAC86E28F0
        public void RecordInternalCancellationRequest(){} // RVA: 0x7FFAC86E2C30 | overloaded x3
        public void CancellationCleanupLogic(){} // RVA: 0x7FFAC86E2D60
        public void SetCancellationAcknowledged(){} // RVA: 0x7FFAC86E2E20
        public void FinishContinuations(){} // RVA: 0x7FFAC86E2E40
        public void LogFinishCompletionNotification(){} // RVA: 0x7FFAC86E34F0
        public void ContinueWith(){} // RVA: 0x7FFAC2E8DC40 | overloaded x8
        public void CreationOptionsFromContinuationOptions(){} // RVA: 0x7FFAC86E39B0
        public void ContinueWithCore(){} // RVA: 0x7FFAC86E3B10
        public void AddCompletionAction(){} // RVA: 0x7FFAC86E3E70 | overloaded x2
        public void AddTaskContinuationComplex(){} // RVA: 0x7FFAC86E3EF0
        public void AddTaskContinuation(){} // RVA: 0x7FFAC86E42E0
        public void RemoveContinuation(){} // RVA: 0x7FFAC86E43F0
        public void FromResult(){} // RVA: 0x7FFAC2E8DC40
        public void FromException(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
        public void FromCancellation(){} // RVA: 0x7FFAC2C58F80 | overloaded x3
        public void FromCanceled(){} // RVA: 0x7FFAC2C67ED0 | overloaded x2
        public void Run(){} // RVA: 0x7FFAC2C5EA50 | overloaded x6
        public void Delay(){} // RVA: 0x7FFAC86E4F80 | overloaded x3
        public void WhenAll(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
        public void InternalWhenAll(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
        public void WhenAny(){} // RVA: 0x7FFAC86E58E0 | overloaded x2
        public void CreateUnwrapPromise(){} // RVA: 0x7FFAC2C69730
        public void AddToActiveTasks(){} // RVA: 0x7FFAC86E5BD0
        public void RemoveFromActiveTasks(){} // RVA: 0x7FFAC86E5E00
        public void MarkAborted(){} // RVA: 0x7FFAC2F21310
        public void ExecuteWithThreadLocal(){} // RVA: 0x7FFAC86E5FD0
        public void .cctor(){} // RVA: 0x7FFAC86E6300
    }

    public class TaskAsyncEnumerableExtensions : Object
    {
        // ── Methods ──
        public void ConfigureAwait(){} // RVA: 0x7FFAC8A53640
    }

    public class TaskAwaiters : Object
    {
        // ── Methods ──
        public void ForceAsync(){} // RVA: 0x7FFAC38D6FB0
    }

    public class TaskCanceledException : OperationCanceledException
    {
        public System.Threading.Tasks.Task _canceledTask; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class TaskCompletionSource`1 : Object
    {
        public System.Threading.Tasks.Task`1<T> Task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC69E25B0 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFAC2F3C380
        public void SpinUntilCompleted(){} // RVA: 0x7FFAC69E2680
        public void TrySetException(){} // RVA: 0x7FFAC69E2790
        public void SetException(){} // RVA: 0x7FFAC69E2810
        public void TrySetResult(){} // RVA: 0x7FFAC69E2860
        public void SetResult(){} // RVA: 0x7FFAC69E2970
        public void TrySetCanceled(){} // RVA: 0x7FFAC69E2A90 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFAC69E2B40
    }

    public class TaskContinuation : Object
    {
        // ── Methods ──
        public void Run(){} // RVA: 0x7FFAC2C76500
        public void InlineIfPossibleOrElseQueue(){} // RVA: 0x7FFAC86E7900
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TaskExceptionHolder : Object
    {
        public bool ContainsFaultList;
        public System.Threading.Tasks.Task m_task; // 0x10
        public System.Collections.Generic.LowLevelListWithIList`1<System.Runtime.ExceptionServices.ExceptionDispatchInfo> m_faultExceptions; // 0x18
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo m_cancellationException; // 0x20
        public bool m_isHandled; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ShouldFailFastOnUnobservedException(){} // RVA: 0x7FFAC2F21320
        public void Finalize(){} // RVA: 0x7FFAC83C9430
        public void get_ContainsFaultList(){} // RVA: 0x7FFAC83C9650
        public void Add(){} // RVA: 0x7FFAC83C9660
        public void SetCancellationException(){} // RVA: 0x7FFAC83C9680
        public void AddFaultException(){} // RVA: 0x7FFAC83C9880
        public void MarkAsUnhandled(){} // RVA: 0x7FFAC83C9E90
        public void MarkAsHandled(){} // RVA: 0x7FFAC83C9F00
        public void CreateExceptionObject(){} // RVA: 0x7FFAC83C9F80
        public void GetExceptionDispatchInfos(){} // RVA: 0x7FFAC83CA210
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void .cctor(){} // RVA: 0x7FFAC83CA330
    }

    public class TaskExtensions : Object
    {
        // ── Methods ──
        public void Unwrap(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
    }

    public class TaskFactory : Object
    {
        public System.Threading.CancellationToken Scheduler; // 0x10
        public System.Threading.Tasks.TaskScheduler m_defaultScheduler; // 0x18
        public 0x6B0C8EA0 m_defaultCreationOptions; // 0x20
        public 0x6B0C8F50 m_defaultContinuationOptions; // 0x24

        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x7FFAC83CA370
        public void .ctor(){} // RVA: 0x7FFAC69E2D00 | overloaded x2
        public void CheckCreationOptions(){} // RVA: 0x7FFAC83CA460
        public void get_Scheduler(){} // RVA: 0x7FFAC2F247C0
        public void StartNew(){} // RVA: 0x7FFAC2E8DC40 | overloaded x6
        public void FromAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void CheckFromAsyncOptions(){} // RVA: 0x7FFAC83CA6A0
        public void CommonCWAnyLogic(){} // RVA: 0x7FFAC83CA7D0
        public void CheckMultiTaskContinuationOptions(){} // RVA: 0x7FFAC83CAAB0
    }

    public class TaskFactory`1 : Object
    {
        public System.Threading.CancellationToken m_defaultCancellationToken;
        public System.Threading.Tasks.TaskScheduler m_defaultScheduler;
        public 0x6B0C8EA0 m_defaultCreationOptions;
        public 0x6B0C8F50 m_defaultContinuationOptions;

        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x7FFAC2C58F40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void StartNew(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void FromAsyncCoreLogic(){}
        public void FromAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void FromAsyncImpl(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void FromAsyncTrim(){} // RVA: 0x7FFAC2E8DC40
    }

    public class TaskReplicator : Object
    {
        public System.Threading.Tasks.TaskScheduler _scheduler; // 0x10
        public bool _stopOnFirstFailure; // 0x18
        public System.Collections.Concurrent.ConcurrentQueue`1<Replica> _pendingReplicas; // 0x20
        public System.Collections.Concurrent.ConcurrentQueue`1<System.Exception> _exceptions; // 0x28
        public bool _stopReplicating; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86DBF20
        public void Run(){} // RVA: 0x7FFAC2C79CB0
        public void GenerateCooperativeMultitaskingTaskTimeout(){} // RVA: 0x7FFAC86DC0A0
    }

    public class TaskScheduler : Object
    {
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Threading.Tasks.TaskScheduler,object> MaximumConcurrencyLevel;
        public System.Threading.Tasks.TaskScheduler RequiresAtomicStartTransition; // 0x8
        public int Default; // 0x10
        public int Current; // 0x10
        public System.EventHandler`1<System.Threading.Tasks.UnobservedTaskExceptionEventArgs> InternalCurrent; // 0x18
        public System.Threading.Lock Id; // 0x20

        // ── Methods ──
        public void QueueTask(){} // RVA: 0x7FFAC2C70A40
        public void TryExecuteTaskInline(){}
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x7FFAC83CAF20
        public void TryRunInline(){} // RVA: 0x7FFAC83CAF30
        public void TryDequeue(){} // RVA: 0x7FFAC2F21320
        public void NotifyWorkItemProgress(){} // RVA: 0x7FFAC2F21310
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Default(){} // RVA: 0x7FFAC83CB150
        public void get_Current(){} // RVA: 0x7FFAC83CB1B0
        public void get_InternalCurrent(){} // RVA: 0x7FFAC83CB260
        public void FromCurrentSynchronizationContext(){} // RVA: 0x7FFAC83CB310
        public void get_Id(){} // RVA: 0x7FFAC83CB430
        public void TryExecuteTask(){} // RVA: 0x7FFAC83CB4D0
        public void add_UnobservedTaskException(){} // RVA: 0x7FFAC83CB550
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFAC83CB790
        public void PublishUnobservedTaskException(){} // RVA: 0x7FFAC83CB980
        public void .cctor(){} // RVA: 0x7FFAC83CBAA0
    }

    public class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
    {
        public System.Threading.Tasks.TaskScheduler m_scheduler; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86E7CC0
        public void Run(){} // RVA: 0x7FFAC86E83A0
    }

    public class TaskSchedulerException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86D9500 | overloaded x3
    }

    public class TaskToApm : Object
    {
        // ── Methods ──
        public void Begin(){} // RVA: 0x7FFAC8F8F9F0
        public void End(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x7FFAC8F8FCA0
    }

    public class Task`1 : Task
    {
        public T Result; // 0x50
        public System.Threading.Tasks.TaskFactory`1<T> ResultOnSuccess;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6C47050 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAC6C47360 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAC6C47530
        public void DangerousSetResult(){} // RVA: 0x7FFAC6C476C0
        public void get_Result(){} // RVA: 0x7FFAC2E5B230
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAC2E5B230
        public void GetResultCore(){} // RVA: 0x7FFAC2E5B230
        public void get_Factory(){} // RVA: 0x7FFAC6C47AD0
        public void InnerInvoke(){} // RVA: 0x7FFAC6C47C90
        public void GetAwaiter(){} // RVA: 0x7FFAC6AD52A0
        public void ConfigureAwait(){} // RVA: 0x7FFAC6AD5300
        public void ContinueWith(){} // RVA: 0x7FFAC2E8DC40 | overloaded x10
    }

    public class ThreadPoolTaskScheduler : TaskScheduler
    {
        public System.Threading.ParameterizedThreadStart RequiresAtomicStartTransition;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83CC1B0
        public void QueueTask(){} // RVA: 0x7FFAC83CC200
        public void TryExecuteTaskInline(){} // RVA: 0x7FFAC83CC5D0
        public void TryDequeue(){} // RVA: 0x7FFAC83CC6A0
        public void NotifyWorkItemProgress(){} // RVA: 0x7FFAC83CC6B0
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x7FFAC2F21320
        public void .cctor(){} // RVA: 0x7FFAC83CC720
    }

    public class UnobservedTaskExceptionEventArgs : EventArgs
    {
        public System.AggregateException Exception; // 0x10
        public bool m_observed; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83CC110
        public void get_Exception(){} // RVA: 0x7FFAC2F3C380
    }

    public class UnwrapPromise`1 : Task`1
    {
        public byte InvokeMayRunArbitraryCode;
        public bool _lookForOce;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C76500
        public void Invoke(){} // RVA: 0x7FFAC2C70A40
        public void InvokeCore(){} // RVA: 0x7FFAC2C70A40
        public void InvokeCoreAsync(){} // RVA: 0x7FFAC2C70A40
        public void ProcessCompletedOuterTask(){} // RVA: 0x7FFAC2C70A40
        public void TrySetFromTask(){}
        public void ProcessInnerTask(){} // RVA: 0x7FFAC2C70A40
        public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFAC2C59D00
    }

    public class ValueTask : ValueType
    {
        public System.Threading.Tasks.Task CompletedTask;
        public object IsCompleted; // 0x10
        public short IsCompletedSuccessfully; // 0x18
        public bool _continueOnCapturedContext; // 0x1A

        // ── Methods ──
        public void get_CompletedTask(){} // RVA: 0x7FFAC86D9A90
        public void .ctor(){} // RVA: 0x7FFAC5A82840 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAC7761A90
        public void Equals(){} // RVA: 0x7FFAC86D9CC0 | overloaded x2
        public void AsTask(){} // RVA: 0x7FFAC86D9CE0
        public void GetTaskForValueTaskSource(){} // RVA: 0x7FFAC86D9DC0
        public void get_IsCompleted(){} // RVA: 0x7FFAC86DA0E0
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7FFAC86DA190
        public void ThrowIfCompletedUnsuccessfully(){} // RVA: 0x7FFAC86DA250
        public void GetAwaiter(){} // RVA: 0x7FFAC84DBB90
        public void ConfigureAwait(){} // RVA: 0x7FFAC5A82750
        public void .cctor(){} // RVA: 0x7FFAC86DA310
    }

    public class ValueTask`1 : ValueType
    {
        public System.Threading.Tasks.Task`1<bool> IsCompleted;
        public object IsCompletedSuccessfully; // 0x10
        public bool Result; // 0x18
        public short _token; // 0x1A
        public bool _continueOnCapturedContext; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC706FAC0 | overloaded x4
        public void GetHashCode(){} // RVA: 0x7FFAC7071480
        public void Equals(){} // RVA: 0x7FFAC7070B10 | overloaded x2
        public void AsTask(){} // RVA: 0x7FFAC7071520
        public void GetTaskForValueTaskSource(){} // RVA: 0x7FFAC7071660
        public void get_IsCompleted(){} // RVA: 0x7FFAC704CC00
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7FFAC704CD00
        public void get_Result(){} // RVA: 0x7FFAC70704C0
        public void GetAwaiter(){} // RVA: 0x7FFAC54929A0
        public void ConfigureAwait(){} // RVA: 0x7FFAC7071C50
        public void ToString(){} // RVA: 0x7FFAC7071DA0
    }

    public class VoidTaskResult : ValueType
    {
    }

}