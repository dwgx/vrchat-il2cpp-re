// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 83
// Methods: 1005

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class Task : Object
    {
        public object m_action; // 0x30B22D20
        public object m_parent; // 0x30B22D20
        public object TASK_STATE_STARTED; // 0x30B22D20
        public object TASK_STATE_EXCEPTIONOBSERVEDBYPARENT; // 0x30B22D20
        public object TASK_STATE_CANCELED; // 0x30B22D20
        public object TASK_STATE_WAITINGFORACTIVATION; // 0x30B22D20
        public object TASK_STATE_WAIT_COMPLETION_NOTIFICATION; // 0x30B22D20
        public object m_continuationObject; // 0x30B22D20
        public object m_contingentProperties; // 0x30B22D20
        public object t_stackGuard; // 0x30B22D20
        public object _completedTask; // 0x30B22D20, was: <CompletedTask>k__BackingField
        public object s_IsTaskContinuationNullPredicate; // 0x30B22D20
        public object m_result; // 0x30B22B00
        public object s_defaultFactory; // 0x3426D548

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae0fe9c0
        public void .ctor(){} // RVA: 0x7ffaae0fe9c0
        public void .ctor(){} // RVA: 0x7ffaae0fe9c0
        public void .ctor(){} // RVA: 0x7ffaae0fe9c0
        public void .ctor(){} // RVA: 0x7ffaae0fe9c0
        public void .ctor(){} // RVA: 0x7ffaae0fe9c0
        public void .ctor(){} // RVA: 0x7ffaae0fe9c0
        public void TaskConstructorCore(){} // RVA: 0x7ffaae0feac0
        public void AssignCancellationToken(){} // RVA: 0x7ffaae0fee10
        public void TaskCancelCallback(){} // RVA: 0x7ffaae0ff220
        public void TrySetCanceled(){} // RVA: 0x7ffaae0ff370
        public void TrySetCanceled(){} // RVA: 0x7ffaae0ff370
        public void TrySetException(){} // RVA: 0x7ffaae0ff4f0
        public void get_Options(){} // RVA: 0x7ffaae0ff560
        public void OptionsMethod(){} // RVA: 0x7ffaaaa1e9a0
        public void AtomicStateUpdate(){} // RVA: 0x7ffaae0ff6a0
        public void AtomicStateUpdate(){} // RVA: 0x7ffaae0ff6a0
        public void NotifyDebuggerOfWaitCompletionIfNecessary(){} // RVA: 0x7ffaae0ff8a0
        public void AnyTaskRequiresNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7ffaae0ff8f0
        public void get_IsWaitNotificationEnabledOrNotRanToCompletion(){} // RVA: 0x7ffaae0ff970
        public void get_ShouldNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7ffaae0ff990
        public void get_IsWaitNotificationEnabled(){} // RVA: 0x7ffaae0ff990
        public void NotifyDebuggerOfWaitCompletion(){} // RVA: 0x7ffaae0ff9b0
        public void MarkStarted(){} // RVA: 0x7ffaae0ff9e0
        public void AddNewChild(){} // RVA: 0x7ffaae0ffa00
        public void DisregardChild(){} // RVA: 0x7ffaae0ffa50
        public void Start(){} // RVA: 0x7ffaae0ffa80
        public void RunSynchronously(){} // RVA: 0x7ffaae0ffcb0
        public void InternalRunSynchronously(){} // RVA: 0x7ffaae0ffd20
        public void InternalStartNew(){} // RVA: 0x7ffaae100090
        public void get_Id(){} // RVA: 0x7ffaae100250
        public void get_CurrentId(){} // RVA: 0x7ffaae1002e0
        public void get_InternalCurrent(){} // RVA: 0x7ffaae100360
        public void InternalCurrentIfAttached(){} // RVA: 0x7ffaae100400
        public void get_CurrentStackGuard(){} // RVA: 0x7ffaae100460
        public void get_Exception(){} // RVA: 0x7ffaae1005a0
        public void get_Status(){} // RVA: 0x7ffaae1005d0
        public void get_IsCanceled(){} // RVA: 0x7ffaae100630
        public void get_IsCancellationRequested(){} // RVA: 0x7ffaae100650
        public void EnsureContingentPropertiesInitialized(){} // RVA: 0x7ffaae1006e0
        public void EnsureContingentPropertiesInitializedCore(){} // RVA: 0x7ffaae100830
        public void get_CancellationToken(){} // RVA: 0x7ffaae100970
        public void get_IsCancellationAcknowledged(){} // RVA: 0x7ffaae100990
        public void get_IsCompleted(){} // RVA: 0x7ffaae1009b0
        public void IsCompletedMethod(){} // RVA: 0x7ffaae100a10
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7ffaae100a20
        public void get_CreationOptions(){} // RVA: 0x7ffaae100a40
        public void System.IAsyncResult.get_AsyncWaitHandle(){} // RVA: 0x7ffaae100a90
        public void get_AsyncState(){} // RVA: 0x7ffaa89600c0
        public void System.IAsyncResult.get_CompletedSynchronously(){} // RVA: 0x7ffaa8932320
        public void get_ExecutingTaskScheduler(){} // RVA: 0x7ffaa8960130
        public void get_Factory(){} // RVA: 0x7ffaae100b40
        public void get_CompletedTask(){} // RVA: 0x7ffaae100ba0
        public void get_CompletedEvent(){} // RVA: 0x7ffaae100c00
        public void get_ExceptionRecorded(){} // RVA: 0x7ffaae100d80
        public void get_IsFaulted(){} // RVA: 0x7ffaae100dd0
        public void get_CapturedContext(){} // RVA: 0x7ffaae100df0
        public void set_CapturedContext(){} // RVA: 0x7ffaae100e70
        public void Dispose(){} // RVA: 0x7ffaae100fc0
        public void Dispose(){} // RVA: 0x7ffaae100fc0
        public void ScheduleAndStart(){} // RVA: 0x7ffaae1010f0
        public void AddException(){} // RVA: 0x7ffaae101280
        public void AddException(){} // RVA: 0x7ffaae101280
        public void ThrowIfExceptional(){} // RVA: 0x7ffaae101a20
        public void UpdateExceptionObservedStatus(){} // RVA: 0x7ffaae101a70
        public void get_IsExceptionObservedByParent(){} // RVA: 0x7ffaae101b90
        public void get_IsDelegateInvoked(){} // RVA: 0x7ffaae101bb0
        public void Finish(){} // RVA: 0x7ffaae101bd0
        public void FinishStageTwo(){} // RVA: 0x7ffaae101e00
        public void FinishStageThree(){} // RVA: 0x7ffaae101f40
        public void ProcessChildCompletion(){} // RVA: 0x7ffaae102030
        public void AddExceptionsFromChildren(){} // RVA: 0x7ffaae102300
        public void Execute(){} // RVA: 0x7ffaae102700
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7ffaae102740
        public void ExecuteEntry(){} // RVA: 0x7ffaae102750
        public void ExecutionContextCallback(){} // RVA: 0x7ffaae102930
        public void InnerInvoke(){} // RVA: 0x7ffaae1029c0
        public void HandleException(){} // RVA: 0x7ffaae102a60
        public void ConfigureAwait(){} // RVA: 0x7ffaae102ba0
        public void Yield(){} // RVA: 0x7ffaa8932320
        public void Wait(){} // RVA: 0x7ffaae102e90
        public void Wait(){} // RVA: 0x7ffaae102e90
        public void Wait(){} // RVA: 0x7ffaae102e90
        public void WrappedTryRunInline(){} // RVA: 0x7ffaae102fd0
        public void InternalWait(){} // RVA: 0x7ffaae103070
        public void SpinThenBlockingWait(){} // RVA: 0x7ffaae103540
        public void SpinWait(){} // RVA: 0x7ffaae103950
        public void InternalCancel(){} // RVA: 0x7ffaae103b00
        public void RecordInternalCancellationRequest(){} // RVA: 0x7ffaae103e40
        public void RecordInternalCancellationRequest(){} // RVA: 0x7ffaae103e40
        public void RecordInternalCancellationRequest(){} // RVA: 0x7ffaae103e40
        public void CancellationCleanupLogic(){} // RVA: 0x7ffaae103f70
        public void FinishContinuations(){} // RVA: 0x7ffaae104050
        public void LogFinishCompletionNotification(){} // RVA: 0x7ffaae104700
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void CreationOptionsFromContinuationOptions(){} // RVA: 0x7ffaae104bc0
        public void ContinueWithCore(){} // RVA: 0x7ffaae104d20
        public void AddCompletionAction(){} // RVA: 0x7ffaae105080
        public void AddCompletionAction(){} // RVA: 0x7ffaae105080
        public void AddTaskContinuationComplex(){} // RVA: 0x7ffaae105100
        public void AddTaskContinuation(){} // RVA: 0x7ffaae1054f0
        public void RemoveContinuation(){} // RVA: 0x7ffaae105600
        public void FromResult(){} // RVA: 0x7ffaa887e5c0
        public void FromException(){} // RVA: 0x7ffaa86492c0
        public void FromException(){} // RVA: 0x7ffaa86492c0
        public void FromCancellation(){} // RVA: 0x7ffaa86492c0
        public void FromCanceled(){} // RVA: 0x7ffaa8658210
        public void FromCancellation(){} // RVA: 0x7ffaa86492c0
        public void FromCanceled(){} // RVA: 0x7ffaa8658210
        public void FromCancellation(){} // RVA: 0x7ffaa86492c0
        public void Run(){} // RVA: 0x7ffaa864ed90
        public void Run(){} // RVA: 0x7ffaa864ed90
        public void Run(){} // RVA: 0x7ffaa864ed90
        public void Run(){} // RVA: 0x7ffaa864ed90
        public void Run(){} // RVA: 0x7ffaa864ed90
        public void Run(){} // RVA: 0x7ffaa864ed90
        public void Delay(){} // RVA: 0x7ffaae106190
        public void Delay(){} // RVA: 0x7ffaae106190
        public void Delay(){} // RVA: 0x7ffaae106190
        public void WhenAll(){} // RVA: 0x7ffaa86492c0
        public void InternalWhenAll(){} // RVA: 0x7ffaa86492c0
        public void WhenAll(){} // RVA: 0x7ffaa86492c0
        public void InternalWhenAll(){} // RVA: 0x7ffaa86492c0
        public void WhenAny(){} // RVA: 0x7ffaae106af0
        public void WhenAny(){} // RVA: 0x7ffaae106af0
        public void CreateUnwrapPromise(){} // RVA: 0x7ffaa8659a70
        public void AddToActiveTasks(){} // RVA: 0x7ffaae106de0
        public void RemoveFromActiveTasks(){} // RVA: 0x7ffaae107010
        public void MarkAborted(){} // RVA: 0x7ffaa8932310
        public void ExecuteWithThreadLocal(){} // RVA: 0x7ffaae1071e0
        public void .cctor(){} // RVA: 0x7ffaae107510
        // ── Binary Analysis Named ──
        public void SetNotificationForWaitCompletion(){} // RVA: 0x7ffaae0ff7b0
        public void GetExceptions(){} // RVA: 0x7ffaae101590
        public void GetExceptionDispatchInfos(){} // RVA: 0x7ffaae101760
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x7ffaae1019f0
        public void GetAwaiter(){} // RVA: 0x7ffaa930c0f0
        public void SetContinuationForAwait(){} // RVA: 0x7ffaae102bc0
        public void SetCancellationAcknowledged(){} // RVA: 0x7ffaae104030
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3f2a90
        public void .ctor(){} // RVA: 0x7ffaac3f2a90
        public void .ctor(){} // RVA: 0x7ffaac3f2a90
        public void .ctor(){} // RVA: 0x7ffaac3f2a90
        public void get_Task(){} // RVA: 0x7ffaa894d380
        public void SpinUntilCompleted(){} // RVA: 0x7ffaac3f2b60
        public void TrySetException(){} // RVA: 0x7ffaac3f2c70
        public void TrySetResult(){} // RVA: 0x7ffaac3f2d40
        public void TrySetCanceled(){} // RVA: 0x7ffaac3f2f70
        public void TrySetCanceled(){} // RVA: 0x7ffaac3f2f70
        // ── Binary Analysis Named ──
        public void SetException(){} // RVA: 0x7ffaac3f2cf0
        public void SetResult(){} // RVA: 0x7ffaac3f2e50
        public void SetCanceled(){} // RVA: 0x7ffaac3f3020
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3f2a90
        public void .ctor(){} // RVA: 0x7ffaac3f2a90
        public void .ctor(){} // RVA: 0x7ffaac3f2a90
        public void .ctor(){} // RVA: 0x7ffaac3f2a90
        public void get_Task(){} // RVA: 0x7ffaa894d380
        public void SpinUntilCompleted(){} // RVA: 0x7ffaac3f2b60
        public void TrySetException(){} // RVA: 0x7ffaac3f2c70
        public void TrySetResult(){} // RVA: 0x7ffaac3f2d40
        public void TrySetCanceled(){} // RVA: 0x7ffaac3f2f70
        public void TrySetCanceled(){} // RVA: 0x7ffaac3f2f70
        // ── Binary Analysis Named ──
        public void SetException(){} // RVA: 0x7ffaac3f2cf0
        public void SetResult(){} // RVA: 0x7ffaac3f2e50
        public void SetCanceled(){} // RVA: 0x7ffaac3f3020
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8667cb0
        public void .ctor(){} // RVA: 0x7ffaa8667cb0
        public void .ctor(){} // RVA: 0x7ffaa8667cb0
        public void .ctor(){} // RVA: 0x7ffaa8667cb0
        public void get_Task(){} // RVA: 0x7ffaa86491d0
        public void SpinUntilCompleted(){} // RVA: 0x7ffaa8660cc0
        public void TrySetException(){} // RVA: 0x7ffaa864a2a0
        public void TrySetResult(){} // RVA: 0x7ffaa887e5c0
        public void TrySetCanceled(){} // RVA: 0x7ffaa887e5c0
        public void TrySetCanceled(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void SetException(){} // RVA: 0x7ffaa8660d80
        public void SetResult(){} // RVA: 0x7ffaa887e5c0
        public void SetCanceled(){} // RVA: 0x7ffaa8660cc0
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3f1bc0
        public void .ctor(){} // RVA: 0x7ffaac3f1bc0
        public void .ctor(){} // RVA: 0x7ffaac3f1bc0
        public void .ctor(){} // RVA: 0x7ffaac3f1bc0
        public void get_Task(){} // RVA: 0x7ffaa894d380
        public void SpinUntilCompleted(){} // RVA: 0x7ffaac3f1c80
        public void TrySetException(){} // RVA: 0x7ffaac3f1d90
        public void TrySetResult(){} // RVA: 0x7ffaac3f1e60
        public void TrySetCanceled(){} // RVA: 0x7ffaac3f1f90
        public void TrySetCanceled(){} // RVA: 0x7ffaac3f1f90
        // ── Binary Analysis Named ──
        public void SetException(){} // RVA: 0x7ffaac3f1df0
        public void SetResult(){} // RVA: 0x7ffaac3f1ea0
        public void SetCanceled(){} // RVA: 0x7ffaac3f2020
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3f2160
        public void .ctor(){} // RVA: 0x7ffaac3f2160
        public void .ctor(){} // RVA: 0x7ffaac3f2160
        public void .ctor(){} // RVA: 0x7ffaac3f2160
        public void get_Task(){} // RVA: 0x7ffaa894d380
        public void SpinUntilCompleted(){} // RVA: 0x7ffaac3f2220
        public void TrySetException(){} // RVA: 0x7ffaac3f2330
        public void TrySetResult(){} // RVA: 0x7ffaac3f2400
        public void TrySetCanceled(){} // RVA: 0x7ffaac3f2490
        public void TrySetCanceled(){} // RVA: 0x7ffaac3f2490
        // ── Binary Analysis Named ──
        public void SetException(){} // RVA: 0x7ffaac3f2390
        public void SetResult(){} // RVA: 0x7ffaac3f2440
        public void SetCanceled(){} // RVA: 0x7ffaac3f2520
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3f10c0
        public void .ctor(){} // RVA: 0x7ffaac3f10c0
        public void .ctor(){} // RVA: 0x7ffaac3f10c0
        public void .ctor(){} // RVA: 0x7ffaac3f10c0
        public void get_Task(){} // RVA: 0x7ffaa894d380
        public void SpinUntilCompleted(){} // RVA: 0x7ffaac3f1180
        public void TrySetException(){} // RVA: 0x7ffaac3f1290
        public void TrySetResult(){} // RVA: 0x7ffaac3f1360
        public void TrySetCanceled(){} // RVA: 0x7ffaac3f1470
        public void TrySetCanceled(){} // RVA: 0x7ffaac3f1470
        // ── Binary Analysis Named ──
        public void SetException(){} // RVA: 0x7ffaac3f12f0
        public void SetResult(){} // RVA: 0x7ffaac3f13a0
        public void SetCanceled(){} // RVA: 0x7ffaac3f1500
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3ef8e0
        public void .ctor(){} // RVA: 0x7ffaac3ef8e0
        public void .ctor(){} // RVA: 0x7ffaac3ef8e0
        public void .ctor(){} // RVA: 0x7ffaac3ef8e0
        public void get_Task(){} // RVA: 0x7ffaa894d380
        public void SpinUntilCompleted(){} // RVA: 0x7ffaac3ef9a0
        public void TrySetException(){} // RVA: 0x7ffaac3efab0
        public void TrySetResult(){} // RVA: 0x7ffaac3efb80
        public void TrySetCanceled(){} // RVA: 0x7ffaac3efca0
        public void TrySetCanceled(){} // RVA: 0x7ffaac3efca0
        // ── Binary Analysis Named ──
        public void SetException(){} // RVA: 0x7ffaac3efb10
        public void SetResult(){} // RVA: 0x7ffaac3efbc0
        public void SetCanceled(){} // RVA: 0x7ffaac3efd30
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3f1bc0
        public void .ctor(){} // RVA: 0x7ffaac3f1bc0
        public void .ctor(){} // RVA: 0x7ffaac3f1bc0
        public void .ctor(){} // RVA: 0x7ffaac3f1bc0
        public void get_Task(){} // RVA: 0x7ffaa894d380
        public void SpinUntilCompleted(){} // RVA: 0x7ffaac3f1c80
        public void TrySetException(){} // RVA: 0x7ffaac3f1d90
        public void TrySetResult(){} // RVA: 0x7ffaac3f1e60
        public void TrySetCanceled(){} // RVA: 0x7ffaac3f1f90
        public void TrySetCanceled(){} // RVA: 0x7ffaac3f1f90
        // ── Binary Analysis Named ──
        public void SetException(){} // RVA: 0x7ffaac3f1df0
        public void SetResult(){} // RVA: 0x7ffaac3f1ea0
        public void SetCanceled(){} // RVA: 0x7ffaac3f2020
    }

    public class TaskContinuation : Object
    {
        // ── Original Methods ──
        public void Run(){} // RVA: 0x7ffaa8666840
        public void InlineIfPossibleOrElseQueue(){} // RVA: 0x7ffaae108b10
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class TaskExtensions : Object
    {
        // ── Original Methods ──
        public void Unwrap(){} // RVA: 0x7ffaa86492c0
        public void Unwrap(){} // RVA: 0x7ffaa86492c0
    }

    public class TaskFactory : Object
    {
        public object m_defaultCreationOptions; // 0x318C1C70

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3f31e0
        public void .ctor(){} // RVA: 0x7ffaac3f31e0
        public void get_Scheduler(){} // RVA: 0x7ffaa89357c0
        public void StartNew(){} // RVA: 0x7ffaa887e5c0
        public void StartNew(){} // RVA: 0x7ffaa887e5c0
        public void StartNew(){} // RVA: 0x7ffaa887e5c0
        public void StartNew(){} // RVA: 0x7ffaa887e5c0
        public void StartNew(){} // RVA: 0x7ffaa887e5c0
        public void StartNew(){} // RVA: 0x7ffaa887e5c0
        public void FromAsync(){} // RVA: 0x7ffaa887e5c0
        public void FromAsync(){} // RVA: 0x7ffaa887e5c0
        public void FromAsync(){} // RVA: 0x7ffaa887e5c0
        public void FromAsync(){} // RVA: 0x7ffaa887e5c0
        public void CommonCWAnyLogic(){} // RVA: 0x7ffaaddeb980
        // ── Binary Analysis Named ──
        public void GetDefaultScheduler(){} // RVA: 0x7ffaaddeb520
        public void CheckCreationOptions(){} // RVA: 0x7ffaaddeb610
        public void CheckFromAsyncOptions(){} // RVA: 0x7ffaaddeb850
        public void CheckMultiTaskContinuationOptions(){} // RVA: 0x7ffaaddebc60
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x30BDACE0
        public object m_defaultScheduler; // 0x34FA8FB0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void StartNew(){} // RVA: 0x7ffaa887e5c0
        public void StartNew(){} // RVA: 0x7ffaa887e5c0
        public void FromAsyncCoreLogic(){}
        public void FromAsync(){} // RVA: 0x7ffaa887e5c0
        public void FromAsyncImpl(){} // RVA: 0x7ffaa887e5c0
        public void FromAsync(){} // RVA: 0x7ffaa887e5c0
        public void FromAsyncImpl(){} // RVA: 0x7ffaa887e5c0
        public void FromAsyncImpl(){} // RVA: 0x7ffaa887e5c0
        public void FromAsync(){} // RVA: 0x7ffaa887e5c0
        public void FromAsyncImpl(){} // RVA: 0x7ffaa887e5c0
        public void FromAsyncTrim(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetDefaultScheduler(){} // RVA: 0x7ffaa8649280
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x34FA8FB0
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x35094978
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x350A5B38
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x350A8CE0
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x356C6570
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x35D13A90
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x35D19F30
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x37A710E0
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x37A73AF8
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x37A90800
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x37A9AA48

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3f31e0
        public void .ctor(){} // RVA: 0x7ffaac3f31e0
        public void StartNew(){} // RVA: 0x7ffaac4ca900
        public void StartNew(){} // RVA: 0x7ffaac4ca900
        public void FromAsyncCoreLogic(){} // RVA: 0x7ffaac4ca9f0
        public void FromAsync(){} // RVA: 0x7ffaa887e5c0
        public void FromAsyncImpl(){} // RVA: 0x7ffaa887e5c0
        public void FromAsync(){} // RVA: 0x7ffaa887e5c0
        public void FromAsyncImpl(){} // RVA: 0x7ffaa887e5c0
        public void FromAsyncImpl(){} // RVA: 0x7ffaa887e5c0
        public void FromAsync(){} // RVA: 0x7ffaa887e5c0
        public void FromAsyncImpl(){} // RVA: 0x7ffaa887e5c0
        public void FromAsyncTrim(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetDefaultScheduler(){} // RVA: 0x7ffaac4ca6d0
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x37AB4C70
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x37AB7300
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x37ACFD18
    }

    public class TaskFactory`1 : Object
    {
        public object m_defaultCreationOptions; // 0x37BE3FC8
    }

    public class TaskReplicator : Object
    {
        public object _pendingReplicas; // 0x313619F0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae0fd130
        public void Run(){} // RVA: 0x7ffaa8669ff0
        public void GenerateCooperativeMultitaskingTaskTimeout(){} // RVA: 0x7ffaae0fd2b0
    }

    public class TaskScheduler : Object
    {
        public object s_taskSchedulerIdCounter; // 0x34D6AE50
        public object _unobservedTaskExceptionLockObject; // 0x34D6AE50

        // ── Original Methods ──
        public void QueueTask(){} // RVA: 0x7ffaa8660d80
        public void TryExecuteTaskInline(){}
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x7ffaaddec0d0
        public void TryRunInline(){} // RVA: 0x7ffaaddec0e0
        public void TryDequeue(){} // RVA: 0x7ffaa8932320
        public void NotifyWorkItemProgress(){} // RVA: 0x7ffaa8932310
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x7ffaa8a17850
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_Default(){} // RVA: 0x7ffaaddec300
        public void get_Current(){} // RVA: 0x7ffaaddec360
        public void get_InternalCurrent(){} // RVA: 0x7ffaaddec410
        public void FromCurrentSynchronizationContext(){} // RVA: 0x7ffaaddec4c0
        public void get_Id(){} // RVA: 0x7ffaaddec5e0
        public void TryExecuteTask(){} // RVA: 0x7ffaaddec680
        public void add_UnobservedTaskException(){} // RVA: 0x7ffaaddec700
        public void remove_UnobservedTaskException(){} // RVA: 0x7ffaaddec940
        public void PublishUnobservedTaskException(){} // RVA: 0x7ffaaddecb30
        public void .cctor(){} // RVA: 0x7ffaaddecc50
    }

    public class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae108ed0
        public void Run(){} // RVA: 0x7ffaae1095b0
    }

    public class TaskToApm : Object
    {
        // ── Original Methods ──
        public void End(){} // RVA: 0x7ffaa887e5c0
        public void End(){} // RVA: 0x7ffaa887e5c0
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x7ffaae9b1c70
        // ── Binary Analysis Named ──
        public void Begin(){} // RVA: 0x7ffaae9b19c0
    }

    public class TaskToApm : Object
    {
        // ── Original Methods ──
        public void End(){} // RVA: 0x7ffaa887e5c0
        public void End(){} // RVA: 0x7ffaa887e5c0
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x7ffaae0faa40
        // ── Binary Analysis Named ──
        public void Begin(){} // RVA: 0x7ffaae0fa790
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void StartNew(){} // RVA: 0x7ffaac658300
        public void StartNew(){} // RVA: 0x7ffaac658300
        public void TrySetResult(){} // RVA: 0x7ffaac6584d0
        public void DangerousSetResult(){} // RVA: 0x7ffaac658660
        public void get_Result(){} // RVA: 0x7ffaa884bb60
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa884bb60
        public void get_Factory(){} // RVA: 0x7ffaac658a70
        public void InnerInvoke(){} // RVA: 0x7ffaac658c30
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaa884bb60
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void StartNew(){} // RVA: 0x7ffaac658300
        public void StartNew(){} // RVA: 0x7ffaac658300
        public void TrySetResult(){} // RVA: 0x7ffaac6584d0
        public void DangerousSetResult(){} // RVA: 0x7ffaac658660
        public void get_Result(){} // RVA: 0x7ffaa884bb60
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa884bb60
        public void get_Factory(){} // RVA: 0x7ffaac658a70
        public void InnerInvoke(){} // RVA: 0x7ffaac658c30
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaa884bb60
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        public object m_result; // 0x3426D548

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void StartNew(){} // RVA: 0x7ffaa887e5c0
        public void StartNew(){} // RVA: 0x7ffaa887e5c0
        public void TrySetResult(){} // RVA: 0x7ffaa887e5c0
        public void DangerousSetResult(){} // RVA: 0x7ffaa887e5c0
        public void get_Result(){} // RVA: 0x7ffaa887e5c0
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa887e5c0
        public void get_Factory(){} // RVA: 0x7ffaa8648dd0
        public void InnerInvoke(){} // RVA: 0x7ffaa8660cc0
        public void ConfigureAwait(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaa887e5c0
        public void GetAwaiter(){} // RVA: 0x7ffaa887e5c0
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void StartNew(){} // RVA: 0x7ffaac658300
        public void StartNew(){} // RVA: 0x7ffaac658300
        public void TrySetResult(){} // RVA: 0x7ffaac6584d0
        public void DangerousSetResult(){} // RVA: 0x7ffaac658660
        public void get_Result(){} // RVA: 0x7ffaa884bb60
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa884bb60
        public void get_Factory(){} // RVA: 0x7ffaac658a70
        public void InnerInvoke(){} // RVA: 0x7ffaac658c30
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaa884bb60
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void StartNew(){} // RVA: 0x7ffaac658300
        public void StartNew(){} // RVA: 0x7ffaac658300
        public void TrySetResult(){} // RVA: 0x7ffaac6584d0
        public void DangerousSetResult(){} // RVA: 0x7ffaac658660
        public void get_Result(){} // RVA: 0x7ffaa884bb60
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa884bb60
        public void get_Factory(){} // RVA: 0x7ffaac658a70
        public void InnerInvoke(){} // RVA: 0x7ffaac658c30
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaa884bb60
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void .ctor(){} // RVA: 0x7ffaac657ff0
        public void StartNew(){} // RVA: 0x7ffaac658300
        public void StartNew(){} // RVA: 0x7ffaac658300
        public void TrySetResult(){} // RVA: 0x7ffaac6584d0
        public void DangerousSetResult(){} // RVA: 0x7ffaac658660
        public void get_Result(){} // RVA: 0x7ffaa884bb60
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa884bb60
        public void get_Factory(){} // RVA: 0x7ffaac658a70
        public void InnerInvoke(){} // RVA: 0x7ffaac658c30
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaa884bb60
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void StartNew(){} // RVA: 0x7ffaac643c80
        public void StartNew(){} // RVA: 0x7ffaac643c80
        public void TrySetResult(){} // RVA: 0x7ffaac643e20
        public void DangerousSetResult(){} // RVA: 0x7ffaac643f60
        public void get_Result(){} // RVA: 0x7ffaac644000
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa89d30e0
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac644040
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4efd80
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac605e70
        public void .ctor(){} // RVA: 0x7ffaac605e70
        public void .ctor(){} // RVA: 0x7ffaac605e70
        public void .ctor(){} // RVA: 0x7ffaac605e70
        public void .ctor(){} // RVA: 0x7ffaac605e70
        public void .ctor(){} // RVA: 0x7ffaac605e70
        public void .ctor(){} // RVA: 0x7ffaac605e70
        public void .ctor(){} // RVA: 0x7ffaac605e70
        public void StartNew(){} // RVA: 0x7ffaac606150
        public void StartNew(){} // RVA: 0x7ffaac606150
        public void TrySetResult(){} // RVA: 0x7ffaac4e6120
        public void DangerousSetResult(){} // RVA: 0x7ffaac4e6270
        public void get_Result(){} // RVA: 0x7ffaac4e6300
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaac4e6450
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac4e67d0
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4e6460
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac656ea0
        public void .ctor(){} // RVA: 0x7ffaac656ea0
        public void .ctor(){} // RVA: 0x7ffaac656ea0
        public void .ctor(){} // RVA: 0x7ffaac656ea0
        public void .ctor(){} // RVA: 0x7ffaac656ea0
        public void .ctor(){} // RVA: 0x7ffaac656ea0
        public void .ctor(){} // RVA: 0x7ffaac656ea0
        public void .ctor(){} // RVA: 0x7ffaac656ea0
        public void StartNew(){} // RVA: 0x7ffaac657180
        public void StartNew(){} // RVA: 0x7ffaac657180
        public void TrySetResult(){} // RVA: 0x7ffaac62eec0
        public void DangerousSetResult(){} // RVA: 0x7ffaac62efb0
        public void get_Result(){} // RVA: 0x7ffaac62efe0
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa89ec8e0
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac62f230
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac62f110
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void StartNew(){} // RVA: 0x7ffaac643c80
        public void StartNew(){} // RVA: 0x7ffaac643c80
        public void TrySetResult(){} // RVA: 0x7ffaac643e20
        public void DangerousSetResult(){} // RVA: 0x7ffaac643f60
        public void get_Result(){} // RVA: 0x7ffaac644000
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa89d30e0
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac644040
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4efd80
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac63cdc0
        public void .ctor(){} // RVA: 0x7ffaac63cdc0
        public void .ctor(){} // RVA: 0x7ffaac63cdc0
        public void .ctor(){} // RVA: 0x7ffaac63cdc0
        public void .ctor(){} // RVA: 0x7ffaac63cdc0
        public void .ctor(){} // RVA: 0x7ffaac63cdc0
        public void .ctor(){} // RVA: 0x7ffaac63cdc0
        public void .ctor(){} // RVA: 0x7ffaac63cdc0
        public void StartNew(){} // RVA: 0x7ffaac63d0a0
        public void StartNew(){} // RVA: 0x7ffaac63d0a0
        public void TrySetResult(){} // RVA: 0x7ffaac63d240
        public void DangerousSetResult(){} // RVA: 0x7ffaac63d330
        public void get_Result(){} // RVA: 0x7ffaac581ca0
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa8b023d0
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac581ef0
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac581dd0
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void StartNew(){} // RVA: 0x7ffaac643c80
        public void StartNew(){} // RVA: 0x7ffaac643c80
        public void TrySetResult(){} // RVA: 0x7ffaac643e20
        public void DangerousSetResult(){} // RVA: 0x7ffaac643f60
        public void get_Result(){} // RVA: 0x7ffaac644000
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa89d30e0
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac644040
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4efd80
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void StartNew(){} // RVA: 0x7ffaac4e8a90
        public void StartNew(){} // RVA: 0x7ffaac4e8a90
        public void TrySetResult(){} // RVA: 0x7ffaac4e6120
        public void DangerousSetResult(){} // RVA: 0x7ffaac4e6270
        public void get_Result(){} // RVA: 0x7ffaac4e6300
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaac4e6450
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac4e67d0
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4e6460
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void StartNew(){} // RVA: 0x7ffaac4e8a90
        public void StartNew(){} // RVA: 0x7ffaac4e8a90
        public void TrySetResult(){} // RVA: 0x7ffaac4e6120
        public void DangerousSetResult(){} // RVA: 0x7ffaac4e6270
        public void get_Result(){} // RVA: 0x7ffaac4e6300
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaac4e6450
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac4e67d0
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4e6460
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac63bd40
        public void .ctor(){} // RVA: 0x7ffaac63bd40
        public void .ctor(){} // RVA: 0x7ffaac63bd40
        public void .ctor(){} // RVA: 0x7ffaac63bd40
        public void .ctor(){} // RVA: 0x7ffaac63bd40
        public void .ctor(){} // RVA: 0x7ffaac63bd40
        public void .ctor(){} // RVA: 0x7ffaac63bd40
        public void .ctor(){} // RVA: 0x7ffaac63bd40
        public void StartNew(){} // RVA: 0x7ffaac63c020
        public void StartNew(){} // RVA: 0x7ffaac63c020
        public void TrySetResult(){} // RVA: 0x7ffaac6336a0
        public void DangerousSetResult(){} // RVA: 0x7ffaac633790
        public void get_Result(){} // RVA: 0x7ffaac4e9e00
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaac4e9f30
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac4ea060
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4e9f40
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac651700
        public void .ctor(){} // RVA: 0x7ffaac651700
        public void .ctor(){} // RVA: 0x7ffaac651700
        public void .ctor(){} // RVA: 0x7ffaac651700
        public void .ctor(){} // RVA: 0x7ffaac651700
        public void .ctor(){} // RVA: 0x7ffaac651700
        public void .ctor(){} // RVA: 0x7ffaac651700
        public void .ctor(){} // RVA: 0x7ffaac651700
        public void StartNew(){} // RVA: 0x7ffaac6519e0
        public void StartNew(){} // RVA: 0x7ffaac6519e0
        public void TrySetResult(){} // RVA: 0x7ffaac4efb20
        public void DangerousSetResult(){} // RVA: 0x7ffaac4efc10
        public void get_Result(){} // RVA: 0x7ffaac4efc50
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa89d30e0
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac4efea0
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4efd80
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac62ff20
        public void .ctor(){} // RVA: 0x7ffaac62ff20
        public void .ctor(){} // RVA: 0x7ffaac62ff20
        public void .ctor(){} // RVA: 0x7ffaac62ff20
        public void .ctor(){} // RVA: 0x7ffaac62ff20
        public void .ctor(){} // RVA: 0x7ffaac62ff20
        public void .ctor(){} // RVA: 0x7ffaac62ff20
        public void .ctor(){} // RVA: 0x7ffaac62ff20
        public void StartNew(){} // RVA: 0x7ffaac630200
        public void StartNew(){} // RVA: 0x7ffaac630200
        public void TrySetResult(){} // RVA: 0x7ffaac6303a0
        public void DangerousSetResult(){} // RVA: 0x7ffaac630490
        public void get_Result(){} // RVA: 0x7ffaac62efe0
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa89ec8e0
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac62f230
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac62f110
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void StartNew(){} // RVA: 0x7ffaac643c80
        public void StartNew(){} // RVA: 0x7ffaac643c80
        public void TrySetResult(){} // RVA: 0x7ffaac643e20
        public void DangerousSetResult(){} // RVA: 0x7ffaac643f60
        public void get_Result(){} // RVA: 0x7ffaac644000
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa89d30e0
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac644040
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4efd80
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac654d60
        public void .ctor(){} // RVA: 0x7ffaac654d60
        public void .ctor(){} // RVA: 0x7ffaac654d60
        public void .ctor(){} // RVA: 0x7ffaac654d60
        public void .ctor(){} // RVA: 0x7ffaac654d60
        public void .ctor(){} // RVA: 0x7ffaac654d60
        public void .ctor(){} // RVA: 0x7ffaac654d60
        public void .ctor(){} // RVA: 0x7ffaac654d60
        public void StartNew(){} // RVA: 0x7ffaac655040
        public void StartNew(){} // RVA: 0x7ffaac655040
        public void TrySetResult(){} // RVA: 0x7ffaac62eec0
        public void DangerousSetResult(){} // RVA: 0x7ffaac62efb0
        public void get_Result(){} // RVA: 0x7ffaac62efe0
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa89ec8e0
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac62f230
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac62f110
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void StartNew(){} // RVA: 0x7ffaac643c80
        public void StartNew(){} // RVA: 0x7ffaac643c80
        public void TrySetResult(){} // RVA: 0x7ffaac643e20
        public void DangerousSetResult(){} // RVA: 0x7ffaac643f60
        public void get_Result(){} // RVA: 0x7ffaac644000
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa89d30e0
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac644040
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4efd80
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void StartNew(){} // RVA: 0x7ffaac4e8a90
        public void StartNew(){} // RVA: 0x7ffaac4e8a90
        public void TrySetResult(){} // RVA: 0x7ffaac4e6120
        public void DangerousSetResult(){} // RVA: 0x7ffaac4e6270
        public void get_Result(){} // RVA: 0x7ffaac4e6300
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaac4e6450
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac4e67d0
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4e6460
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void .ctor(){} // RVA: 0x7ffaac4e87b0
        public void StartNew(){} // RVA: 0x7ffaac4e8a90
        public void StartNew(){} // RVA: 0x7ffaac4e8a90
        public void TrySetResult(){} // RVA: 0x7ffaac4e6120
        public void DangerousSetResult(){} // RVA: 0x7ffaac4e6270
        public void get_Result(){} // RVA: 0x7ffaac4e6300
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaac4e6450
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac4e67d0
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4e6460
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class Task`1 : Task
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void .ctor(){} // RVA: 0x7ffaac6439a0
        public void StartNew(){} // RVA: 0x7ffaac643c80
        public void StartNew(){} // RVA: 0x7ffaac643c80
        public void TrySetResult(){} // RVA: 0x7ffaac643e20
        public void DangerousSetResult(){} // RVA: 0x7ffaac643f60
        public void get_Result(){} // RVA: 0x7ffaac644000
        public void get_ResultOnSuccess(){} // RVA: 0x7ffaa89d30e0
        public void get_Factory(){} // RVA: 0x7ffaac4e6590
        public void InnerInvoke(){} // RVA: 0x7ffaac644040
        public void ConfigureAwait(){} // RVA: 0x7ffaac4e69c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        public void ContinueWith(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetResultCore(){} // RVA: 0x7ffaac4efd80
        public void GetAwaiter(){} // RVA: 0x7ffaac4e6960
    }

    public class ThreadPoolTaskScheduler : TaskScheduler
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadded360
        public void QueueTask(){} // RVA: 0x7ffaadded3b0
        public void TryExecuteTaskInline(){} // RVA: 0x7ffaadded780
        public void TryDequeue(){} // RVA: 0x7ffaadded850
        public void NotifyWorkItemProgress(){} // RVA: 0x7ffaadded860
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x7ffaa8932320
        public void .cctor(){} // RVA: 0x7ffaadded8d0
    }

}