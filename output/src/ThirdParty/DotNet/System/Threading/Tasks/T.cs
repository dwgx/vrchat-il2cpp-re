// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 100
// Methods: 1031

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89F6140 | overloaded x7
        public void TaskConstructorCore(){} // RVA: 0x7FFAF89F6240
        public void AssignCancellationToken(){} // RVA: 0x7FFAF89F6590
        public void TaskCancelCallback(){} // RVA: 0x7FFAF89F69A0
        public void TrySetCanceled(){} // RVA: 0x7FFAF89F6AF0 | overloaded x2
        public void TrySetException(){} // RVA: 0x7FFAF89F6C70
        public void get_Options(){} // RVA: 0x7FFAF89F6CE0
        public void OptionsMethod(){} // RVA: 0x7FFAF5022DF0
        public void AtomicStateUpdate(){} // RVA: 0x7FFAF89F6E20 | overloaded x2
        public void SetNotificationForWaitCompletion(){} // RVA: 0x7FFAF89F6F30
        public void NotifyDebuggerOfWaitCompletionIfNecessary(){} // RVA: 0x7FFAF89F7020
        public void AnyTaskRequiresNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7FFAF89F7070
        public void get_IsWaitNotificationEnabledOrNotRanToCompletion(){} // RVA: 0x7FFAF89F70F0
        public void get_ShouldNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7FFAF89F7110
        public void get_IsWaitNotificationEnabled(){} // RVA: 0x7FFAF89F7110
        public void NotifyDebuggerOfWaitCompletion(){} // RVA: 0x7FFAF89F7130
        public void MarkStarted(){} // RVA: 0x7FFAF89F7160
        public void AddNewChild(){} // RVA: 0x7FFAF89F7180
        public void DisregardChild(){} // RVA: 0x7FFAF89F71D0
        public void Start(){} // RVA: 0x7FFAF89F7200
        public void RunSynchronously(){} // RVA: 0x7FFAF89F7430
        public void InternalRunSynchronously(){} // RVA: 0x7FFAF89F74A0
        public void InternalStartNew(){} // RVA: 0x7FFAF89F7810
        public void get_Id(){} // RVA: 0x7FFAF89F79D0
        public void get_CurrentId(){} // RVA: 0x7FFAF89F7A60
        public void get_InternalCurrent(){} // RVA: 0x7FFAF89F7AE0
        public void InternalCurrentIfAttached(){} // RVA: 0x7FFAF89F7B80
        public void get_CurrentStackGuard(){} // RVA: 0x7FFAF89F7BE0
        public void get_Exception(){} // RVA: 0x7FFAF89F7D20
        public void get_Status(){} // RVA: 0x7FFAF89F7D50
        public void get_IsCanceled(){} // RVA: 0x7FFAF89F7DB0
        public void get_IsCancellationRequested(){} // RVA: 0x7FFAF89F7DD0
        public void EnsureContingentPropertiesInitialized(){} // RVA: 0x7FFAF89F7E60
        public void EnsureContingentPropertiesInitializedCore(){} // RVA: 0x7FFAF89F7FB0
        public void get_CancellationToken(){} // RVA: 0x7FFAF89F80F0
        public void get_IsCancellationAcknowledged(){} // RVA: 0x7FFAF89F8110
        public void get_IsCompleted(){} // RVA: 0x7FFAF89F8130
        public void IsCompletedMethod(){} // RVA: 0x7FFAF89F8190
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7FFAF89F81A0
        public void get_CreationOptions(){} // RVA: 0x7FFAF89F81C0
        public void System.IAsyncResult.get_AsyncWaitHandle(){} // RVA: 0x7FFAF89F8210
        public void get_AsyncState(){} // RVA: 0x7FFAF2DBB0C0
        public void System.IAsyncResult.get_CompletedSynchronously(){} // RVA: 0x7FFAF2D8D320
        public void get_ExecutingTaskScheduler(){} // RVA: 0x7FFAF2DBB130
        public void get_Factory(){} // RVA: 0x7FFAF89F82C0
        public void get_CompletedTask(){} // RVA: 0x7FFAF89F8320
        public void get_CompletedEvent(){} // RVA: 0x7FFAF89F8380
        public void get_ExceptionRecorded(){} // RVA: 0x7FFAF89F8500
        public void get_IsFaulted(){} // RVA: 0x7FFAF89F8550
        public void get_CapturedContext(){} // RVA: 0x7FFAF89F8570
        public void set_CapturedContext(){} // RVA: 0x7FFAF89F85F0
        public void Dispose(){} // RVA: 0x7FFAF89F8740 | overloaded x2
        public void ScheduleAndStart(){} // RVA: 0x7FFAF89F8870
        public void AddException(){} // RVA: 0x7FFAF89F8A00 | overloaded x2
        public void GetExceptions(){} // RVA: 0x7FFAF89F8D10
        public void GetExceptionDispatchInfos(){} // RVA: 0x7FFAF89F8EE0
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x7FFAF89F9170
        public void ThrowIfExceptional(){} // RVA: 0x7FFAF89F91A0
        public void UpdateExceptionObservedStatus(){} // RVA: 0x7FFAF89F91F0
        public void get_IsExceptionObservedByParent(){} // RVA: 0x7FFAF89F9310
        public void get_IsDelegateInvoked(){} // RVA: 0x7FFAF89F9330
        public void Finish(){} // RVA: 0x7FFAF89F9350
        public void FinishStageTwo(){} // RVA: 0x7FFAF89F9580
        public void FinishStageThree(){} // RVA: 0x7FFAF89F96C0
        public void ProcessChildCompletion(){} // RVA: 0x7FFAF89F97B0
        public void AddExceptionsFromChildren(){} // RVA: 0x7FFAF89F9A80
        public void Execute(){} // RVA: 0x7FFAF89F9E80
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFAF89F9EC0
        public void ExecuteEntry(){} // RVA: 0x7FFAF89F9ED0
        public void ExecutionContextCallback(){} // RVA: 0x7FFAF89FA0B0
        public void InnerInvoke(){} // RVA: 0x7FFAF89FA140
        public void HandleException(){} // RVA: 0x7FFAF89FA1E0
        public void GetAwaiter(){} // RVA: 0x7FFAF3AB73D0
        public void ConfigureAwait(){} // RVA: 0x7FFAF89FA320
        public void SetContinuationForAwait(){} // RVA: 0x7FFAF89FA340
        public void Yield(){} // RVA: 0x7FFAF2D8D320
        public void Wait(){} // RVA: 0x7FFAF89FA610 | overloaded x3
        public void WrappedTryRunInline(){} // RVA: 0x7FFAF89FA750
        public void InternalWait(){} // RVA: 0x7FFAF89FA7F0
        public void SpinThenBlockingWait(){} // RVA: 0x7FFAF89FACC0
        public void SpinWait(){} // RVA: 0x7FFAF89FB0D0
        public void InternalCancel(){} // RVA: 0x7FFAF89FB280
        public void RecordInternalCancellationRequest(){} // RVA: 0x7FFAF89FB5C0 | overloaded x3
        public void CancellationCleanupLogic(){} // RVA: 0x7FFAF89FB6F0
        public void SetCancellationAcknowledged(){} // RVA: 0x7FFAF89FB7B0
        public void FinishContinuations(){} // RVA: 0x7FFAF89FB7D0
        public void LogFinishCompletionNotification(){} // RVA: 0x7FFAF89FBE80
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x8
        public void CreationOptionsFromContinuationOptions(){} // RVA: 0x7FFAF89FC340
        public void ContinueWithCore(){} // RVA: 0x7FFAF89FC4A0
        public void AddCompletionAction(){} // RVA: 0x7FFAF89FC800 | overloaded x2
        public void AddTaskContinuationComplex(){} // RVA: 0x7FFAF89FC880
        public void AddTaskContinuation(){} // RVA: 0x7FFAF89FCC70
        public void RemoveContinuation(){} // RVA: 0x7FFAF89FCD80
        public void FromResult(){} // RVA: 0x7FFAF2D33FA0
        public void FromException(){} // RVA: 0x7FFAF2ABCE50 | overloaded x2
        public void FromCancellation(){} // RVA: 0x7FFAF2ABCE50 | overloaded x3
        public void FromCanceled(){} // RVA: 0x7FFAF2ACBDB0 | overloaded x2
        public void Run(){} // RVA: 0x7FFAF2AC2930 | overloaded x6
        public void Delay(){} // RVA: 0x7FFAF89FD910 | overloaded x3
        public void WhenAll(){} // RVA: 0x7FFAF2ABCE50 | overloaded x2
        public void InternalWhenAll(){} // RVA: 0x7FFAF2ABCE50 | overloaded x2
        public void WhenAny(){} // RVA: 0x7FFAF89FE270 | overloaded x2
        public void CreateUnwrapPromise(){} // RVA: 0x7FFAF2ACD680
        public void AddToActiveTasks(){} // RVA: 0x7FFAF89FE560
        public void RemoveFromActiveTasks(){} // RVA: 0x7FFAF89FE790
        public void MarkAborted(){} // RVA: 0x7FFAF2D8D310
        public void ExecuteWithThreadLocal(){} // RVA: 0x7FFAF89FE960
        public void .cctor(){} // RVA: 0x7FFAF89FEC90
    }

    public class TaskAsyncEnumerableExtensions
    {
        // ── Methods ──
        public void ConfigureAwait(){} // RVA: 0x7FFAF8D6C2A0
    }

    public class TaskAwaiters
    {
        // ── Methods ──
        public void ForceAsync(){} // RVA: 0x7FFAF3AB73D0
    }

    public class TaskCanceledException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x3
    }

    public class TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B895D0 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFAF2DA8380
        public void SpinUntilCompleted(){} // RVA: 0x7FFAF6B896A0
        public void TrySetException(){} // RVA: 0x7FFAF6B897B0
        public void SetException(){} // RVA: 0x7FFAF6B89830
        public void TrySetResult(){} // RVA: 0x7FFAF6B89880
        public void SetResult(){} // RVA: 0x7FFAF6B89990
        public void TrySetCanceled(){} // RVA: 0x7FFAF6B89AB0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFAF6B89B60
    }

    public class TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B895D0 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFAF2DA8380
        public void SpinUntilCompleted(){} // RVA: 0x7FFAF6B896A0
        public void TrySetException(){} // RVA: 0x7FFAF6B897B0
        public void SetException(){} // RVA: 0x7FFAF6B89830
        public void TrySetResult(){} // RVA: 0x7FFAF6B89880
        public void SetResult(){} // RVA: 0x7FFAF6B89990
        public void TrySetCanceled(){} // RVA: 0x7FFAF6B89AB0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFAF6B89B60
    }

    public class TaskCompletionSource`1
    {
        public object IsCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2ADBAA0 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFAF2ABCD60
        public void SpinUntilCompleted(){} // RVA: 0x7FFAF2AD4A50
        public void TrySetException(){} // RVA: 0x7FFAF2ABDE40
        public void SetException(){} // RVA: 0x7FFAF2AD4B10
        public void TrySetResult(){} // RVA: 0x7FFAF2D33FA0
        public void SetResult(){} // RVA: 0x7FFAF2D33FA0
        public void TrySetCanceled(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFAF2AD4A50
    }

    public class TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B88700 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFAF2DA8380
        public void SpinUntilCompleted(){} // RVA: 0x7FFAF6B887C0
        public void TrySetException(){} // RVA: 0x7FFAF6B888D0
        public void SetException(){} // RVA: 0x7FFAF6B88930
        public void TrySetResult(){} // RVA: 0x7FFAF6B889A0
        public void SetResult(){} // RVA: 0x7FFAF6B889E0
        public void TrySetCanceled(){} // RVA: 0x7FFAF6B88AD0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFAF6B88B60
    }

    public class TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B88CA0 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFAF2DA8380
        public void SpinUntilCompleted(){} // RVA: 0x7FFAF6B88D60
        public void TrySetException(){} // RVA: 0x7FFAF6B88E70
        public void SetException(){} // RVA: 0x7FFAF6B88ED0
        public void TrySetResult(){} // RVA: 0x7FFAF6B88F40
        public void SetResult(){} // RVA: 0x7FFAF6B88F80
        public void TrySetCanceled(){} // RVA: 0x7FFAF6B88FD0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFAF6B89060
    }

    public class TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B87C00 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFAF2DA8380
        public void SpinUntilCompleted(){} // RVA: 0x7FFAF6B87CC0
        public void TrySetException(){} // RVA: 0x7FFAF6B87DD0
        public void SetException(){} // RVA: 0x7FFAF6B87E30
        public void TrySetResult(){} // RVA: 0x7FFAF6B87EA0
        public void SetResult(){} // RVA: 0x7FFAF6B87EE0
        public void TrySetCanceled(){} // RVA: 0x7FFAF6B87FB0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFAF6B88040
    }

    public class TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B87690 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFAF2DA8380
        public void SpinUntilCompleted(){} // RVA: 0x7FFAF6B87750
        public void TrySetException(){} // RVA: 0x7FFAF6B87860
        public void SetException(){} // RVA: 0x7FFAF6B878C0
        public void TrySetResult(){} // RVA: 0x7FFAF6B87930
        public void SetResult(){} // RVA: 0x7FFAF6B87970
        public void TrySetCanceled(){} // RVA: 0x7FFAF6B87A40 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFAF6B87AD0
    }

    public class TaskCompletionSource`1
    {
    }

    public class TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B891A0 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFAF2DA8380
        public void SpinUntilCompleted(){} // RVA: 0x7FFAF6B89260
        public void TrySetException(){} // RVA: 0x7FFAF6B89370
        public void SetException(){} // RVA: 0x7FFAF6B893D0
        public void TrySetResult(){} // RVA: 0x7FFAF6B89440
        public void SetResult(){} // RVA: 0x7FFAF6B89480
        public void TrySetCanceled(){} // RVA: 0x7FFAF6B894D0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFAF6B89560
    }

    public class TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B88200 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFAF2DA8380
        public void SpinUntilCompleted(){} // RVA: 0x7FFAF6B882C0
        public void TrySetException(){} // RVA: 0x7FFAF6B883D0
        public void SetException(){} // RVA: 0x7FFAF6B88430
        public void TrySetResult(){} // RVA: 0x7FFAF6B884A0
        public void SetResult(){} // RVA: 0x7FFAF6B884E0
        public void TrySetCanceled(){} // RVA: 0x7FFAF6B88530 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFAF6B885C0
    }

    public class TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B86420 | overloaded x4
        public void get_Task(){} // RVA: 0x7FFAF2DA8380
        public void SpinUntilCompleted(){} // RVA: 0x7FFAF6B864E0
        public void TrySetException(){} // RVA: 0x7FFAF6B865F0
        public void SetException(){} // RVA: 0x7FFAF6B86650
        public void TrySetResult(){} // RVA: 0x7FFAF6B866C0
        public void SetResult(){} // RVA: 0x7FFAF6B86700
        public void TrySetCanceled(){} // RVA: 0x7FFAF6B867E0 | overloaded x2
        public void SetCanceled(){} // RVA: 0x7FFAF6B86870
    }

    public class TaskContinuation
    {
        // ── Methods ──
        public void Run(){} // RVA: 0x7FFAF2ADA620
        public void InlineIfPossibleOrElseQueue(){} // RVA: 0x7FFAF8A00290
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TaskExceptionHolder
    {
        public object BinaryStackTraceArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void ShouldFailFastOnUnobservedException(){} // RVA: 0x7FFAF2D8D320
        public void Finalize(){} // RVA: 0x7FFAF86E1EE0
        public void get_ContainsFaultList(){} // RVA: 0x7FFAF86E2100
        public void Add(){} // RVA: 0x7FFAF86E2110
        public void SetCancellationException(){} // RVA: 0x7FFAF86E2130
        public void AddFaultException(){} // RVA: 0x7FFAF86E2330
        public void MarkAsUnhandled(){} // RVA: 0x7FFAF86E2940
        public void MarkAsHandled(){} // RVA: 0x7FFAF86E29B0
        public void CreateExceptionObject(){} // RVA: 0x7FFAF86E2A30
        public void GetExceptionDispatchInfos(){} // RVA: 0x7FFAF86E2CC0
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x7FFAF2DBB0C0
        public void .cctor(){} // RVA: 0x7FFAF86E2DE0
    }

    public class TaskExtensions
    {
        // ── Methods ──
        public void Unwrap(){} // RVA: 0x7FFAF2ABCE50 | overloaded x2
    }

    public class TaskFactory
    {
        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x7FFAF86E2E20
        public void .ctor(){} // RVA: 0x7FFAF6B89D20 | overloaded x2
        public void CheckCreationOptions(){} // RVA: 0x7FFAF86E2F10
        public void get_Scheduler(){} // RVA: 0x7FFAF2D907C0
        public void StartNew(){} // RVA: 0x7FFAF2D33FA0 | overloaded x6
        public void FromAsync(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void CheckFromAsyncOptions(){} // RVA: 0x7FFAF86E3150
        public void CommonCWAnyLogic(){} // RVA: 0x7FFAF86E3280
        public void CheckMultiTaskContinuationOptions(){} // RVA: 0x7FFAF86E3560
    }

    public class TaskFactory`1
    {
        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x7FFAF2ABCE10
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void StartNew(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void FromAsyncCoreLogic(){}
        public void FromAsync(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void FromAsyncImpl(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void FromAsyncTrim(){} // RVA: 0x7FFAF2D33FA0
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
        public void .ctor(){} // RVA: 0x7FFAF89F48B0
        public void Run(){} // RVA: 0x7FFAF2ADDDE0
        public void GenerateCooperativeMultitaskingTaskTimeout(){} // RVA: 0x7FFAF89F4A30
    }

    public class TaskScheduler
    {
        // ── Methods ──
        public void QueueTask(){} // RVA: 0x7FFAF2AD4B10
        public void TryExecuteTaskInline(){}
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x7FFAF86E39D0
        public void TryRunInline(){} // RVA: 0x7FFAF86E39E0
        public void TryDequeue(){} // RVA: 0x7FFAF2D8D320
        public void NotifyWorkItemProgress(){} // RVA: 0x7FFAF2D8D310
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x7FFAF2E72850
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Default(){} // RVA: 0x7FFAF86E3C00
        public void get_Current(){} // RVA: 0x7FFAF86E3C60
        public void get_InternalCurrent(){} // RVA: 0x7FFAF86E3D10
        public void FromCurrentSynchronizationContext(){} // RVA: 0x7FFAF86E3DC0
        public void get_Id(){} // RVA: 0x7FFAF86E3EE0
        public void TryExecuteTask(){} // RVA: 0x7FFAF86E3F80
        public void add_UnobservedTaskException(){} // RVA: 0x7FFAF86E4000
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFAF86E4240
        public void PublishUnobservedTaskException(){} // RVA: 0x7FFAF86E4430
        public void .cctor(){} // RVA: 0x7FFAF86E4550
    }

    public class TaskSchedulerAwaitTaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8A00650
        public void Run(){} // RVA: 0x7FFAF8A00D30
    }

    public class TaskSchedulerException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89F1E90 | overloaded x3
    }

    public class TaskToApm
    {
        // ── Methods ──
        public void Begin(){} // RVA: 0x7FFAF92A8B30
        public void End(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x7FFAF92A8DE0
    }

    public class TaskToApm
    {
        // ── Methods ──
        public void Begin(){} // RVA: 0x7FFAF89F1F10
        public void End(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x7FFAF89F21C0
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E41990 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E41CA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E41E70
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E42000
        public void get_Result(){} // RVA: 0x7FFAF2D13BC0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2D13BC0
        public void GetResultCore(){} // RVA: 0x7FFAF2D13BC0
        public void get_Factory(){} // RVA: 0x7FFAF6E42410
        public void InnerInvoke(){} // RVA: 0x7FFAF6E425D0
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E41990 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E41CA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E41E70
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E42000
        public void get_Result(){} // RVA: 0x7FFAF2D13BC0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2D13BC0
        public void GetResultCore(){} // RVA: 0x7FFAF2D13BC0
        public void get_Factory(){} // RVA: 0x7FFAF6E42410
        public void InnerInvoke(){} // RVA: 0x7FFAF6E425D0
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF2D33FA0
        public void DangerousSetResult(){} // RVA: 0x7FFAF2D33FA0
        public void get_Result(){} // RVA: 0x7FFAF2D33FA0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2D33FA0
        public void GetResultCore(){} // RVA: 0x7FFAF2D33FA0
        public void get_Factory(){} // RVA: 0x7FFAF2ABC960
        public void InnerInvoke(){} // RVA: 0x7FFAF2AD4A50
        public void GetAwaiter(){} // RVA: 0x7FFAF2D33FA0
        public void ConfigureAwait(){} // RVA: 0x7FFAF2D33FA0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E41990 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E41CA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E41E70
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E42000
        public void get_Result(){} // RVA: 0x7FFAF2D13BC0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2D13BC0
        public void GetResultCore(){} // RVA: 0x7FFAF2D13BC0
        public void get_Factory(){} // RVA: 0x7FFAF6E42410
        public void InnerInvoke(){} // RVA: 0x7FFAF6E425D0
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E41990 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E41CA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E41E70
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E42000
        public void get_Result(){} // RVA: 0x7FFAF2D13BC0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2D13BC0
        public void GetResultCore(){} // RVA: 0x7FFAF2D13BC0
        public void get_Factory(){} // RVA: 0x7FFAF6E42410
        public void InnerInvoke(){} // RVA: 0x7FFAF6E425D0
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E41990 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E41CA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E41E70
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E42000
        public void get_Result(){} // RVA: 0x7FFAF2D13BC0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2D13BC0
        public void GetResultCore(){} // RVA: 0x7FFAF2D13BC0
        public void get_Factory(){} // RVA: 0x7FFAF6E42410
        public void InnerInvoke(){} // RVA: 0x7FFAF6E425D0
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E1D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E1DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E1DC40
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E1DD80
        public void get_Result(){} // RVA: 0x7FFAF6E1DE20
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2E2E0E0
        public void GetResultCore(){} // RVA: 0x7FFAF6C99A60
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6E1DE60
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E40840 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E40B20 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E08CE0
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E08DD0
        public void get_Result(){} // RVA: 0x7FFAF6E08E00
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2E478E0
        public void GetResultCore(){} // RVA: 0x7FFAF6E08F30
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6E09050
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6DE6260 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6DE6540 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6C8FE00
        public void DangerousSetResult(){} // RVA: 0x7FFAF6C8FF50
        public void get_Result(){} // RVA: 0x7FFAF6C8FFE0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF6C90130
        public void GetResultCore(){} // RVA: 0x7FFAF6C90140
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6C904B0
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E1D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E1DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E1DC40
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E1DD80
        public void get_Result(){} // RVA: 0x7FFAF6E1DE20
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2E2E0E0
        public void GetResultCore(){} // RVA: 0x7FFAF6C99A60
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6E1DE60
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E16BE0 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E16EC0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E17060
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E17150
        public void get_Result(){} // RVA: 0x7FFAF6D4E8F0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF304C540
        public void GetResultCore(){} // RVA: 0x7FFAF6D4EA20
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6D4EB40
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E1D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E1DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E1DC40
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E1DD80
        public void get_Result(){} // RVA: 0x7FFAF6E1DE20
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2E2E0E0
        public void GetResultCore(){} // RVA: 0x7FFAF6C99A60
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6E1DE60
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6C92490 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6C92770 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6C8FE00
        public void DangerousSetResult(){} // RVA: 0x7FFAF6C8FF50
        public void get_Result(){} // RVA: 0x7FFAF6C8FFE0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF6C90130
        public void GetResultCore(){} // RVA: 0x7FFAF6C90140
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6C904B0
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6C92490 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6C92770 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6C8FE00
        public void DangerousSetResult(){} // RVA: 0x7FFAF6C8FF50
        public void get_Result(){} // RVA: 0x7FFAF6C8FFE0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF6C90130
        public void GetResultCore(){} // RVA: 0x7FFAF6C90140
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6C904B0
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E15B60 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E15E40 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E0D4C0
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E0D5B0
        public void get_Result(){} // RVA: 0x7FFAF6C93AE0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF6C93C10
        public void GetResultCore(){} // RVA: 0x7FFAF6C93C20
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6C93D40
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E09D40 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E0A020 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E0A1C0
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E0A2B0
        public void get_Result(){} // RVA: 0x7FFAF6E08E00
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2E478E0
        public void GetResultCore(){} // RVA: 0x7FFAF6E08F30
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6E09050
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E1D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E1DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E1DC40
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E1DD80
        public void get_Result(){} // RVA: 0x7FFAF6E1DE20
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2E2E0E0
        public void GetResultCore(){} // RVA: 0x7FFAF6C99A60
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6E1DE60
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E3E700 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E3E9E0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E08CE0
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E08DD0
        public void get_Result(){} // RVA: 0x7FFAF6E08E00
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2E478E0
        public void GetResultCore(){} // RVA: 0x7FFAF6E08F30
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6E09050
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E1D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E1DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E1DC40
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E1DD80
        public void get_Result(){} // RVA: 0x7FFAF6E1DE20
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2E2E0E0
        public void GetResultCore(){} // RVA: 0x7FFAF6C99A60
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6E1DE60
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6C92490 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6C92770 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6C8FE00
        public void DangerousSetResult(){} // RVA: 0x7FFAF6C8FF50
        public void get_Result(){} // RVA: 0x7FFAF6C8FFE0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF6C90130
        public void GetResultCore(){} // RVA: 0x7FFAF6C90140
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6C904B0
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E1D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E1DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E1DC40
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E1DD80
        public void get_Result(){} // RVA: 0x7FFAF6E1DE20
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2E2E0E0
        public void GetResultCore(){} // RVA: 0x7FFAF6C99A60
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6E1DE60
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E1D7C0 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6E1DAA0 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6E1DC40
        public void DangerousSetResult(){} // RVA: 0x7FFAF6E1DD80
        public void get_Result(){} // RVA: 0x7FFAF6E1DE20
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF2E2E0E0
        public void GetResultCore(){} // RVA: 0x7FFAF6C99A60
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6E1DE60
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

    public class Task`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6C92490 | overloaded x8
        public void StartNew(){} // RVA: 0x7FFAF6C92770 | overloaded x2
        public void TrySetResult(){} // RVA: 0x7FFAF6C8FE00
        public void DangerousSetResult(){} // RVA: 0x7FFAF6C8FF50
        public void get_Result(){} // RVA: 0x7FFAF6C8FFE0
        public void get_ResultOnSuccess(){} // RVA: 0x7FFAF6C90130
        public void GetResultCore(){} // RVA: 0x7FFAF6C90140
        public void get_Factory(){} // RVA: 0x7FFAF6C90270
        public void InnerInvoke(){} // RVA: 0x7FFAF6C904B0
        public void GetAwaiter(){} // RVA: 0x7FFAF6C90640
        public void ConfigureAwait(){} // RVA: 0x7FFAF6C906A0
        public void ContinueWith(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
    }

}