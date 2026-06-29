// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 100
// Methods: 677

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class Task : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD34AE0
        public void TaskConstructorCore(){} // RVA: 0x7ADD34BE0
        public void AssignCancellationToken(){} // RVA: 0x7ADD34F30
        public void TaskCancelCallback(){} // RVA: 0x7ADD35340
        public void TrySetCanceled(){} // RVA: 0x7ADD35460
        public void TrySetException(){} // RVA: 0x7ADD355E0
        public void get_Options(){} // RVA: 0x7ADD35650
        public void OptionsMethod(){} // RVA: 0x7AA384900
        public void AtomicStateUpdate(){} // RVA: 0x7ADD35790
        public void SetNotificationForWaitCompletion(){} // RVA: 0x7ADD358A0
        public void NotifyDebuggerOfWaitCompletionIfNecessary(){} // RVA: 0x7ADD35990
        public void AnyTaskRequiresNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7ADD359E0
        public void get_IsWaitNotificationEnabledOrNotRanToCompletion(){} // RVA: 0x7ADD35A80
        public void get_ShouldNotifyDebuggerOfWaitCompletion(){} // RVA: 0x7ADD35AA0
        public void get_IsWaitNotificationEnabled(){} // RVA: 0x7ADD35AA0
        public void NotifyDebuggerOfWaitCompletion(){} // RVA: 0x7ADD35AC0
        public void MarkStarted(){} // RVA: 0x7ADD35AF0
        public void AddNewChild(){} // RVA: 0x7ADD35B10
        public void DisregardChild(){} // RVA: 0x7ADD35B60
        public void Start(){} // RVA: 0x7ADD35B90
        public void RunSynchronously(){} // RVA: 0x7ADD35DC0
        public void InternalRunSynchronously(){} // RVA: 0x7ADD35E30
        public void InternalStartNew(){} // RVA: 0x7ADD361A0
        public void get_Id(){} // RVA: 0x7ADD36360
        public void get_CurrentId(){} // RVA: 0x7ADD363F0
        public void get_InternalCurrent(){} // RVA: 0x7ADD36470
        public void InternalCurrentIfAttached(){} // RVA: 0x7ADD36510
        public void get_CurrentStackGuard(){} // RVA: 0x7ADD36570
        public void get_Exception(){} // RVA: 0x7ADD366B0
        public void get_Status(){} // RVA: 0x7ADD366E0
        public void get_IsCanceled(){} // RVA: 0x7ADD36740
        public void get_IsCancellationRequested(){} // RVA: 0x7ADD36760
        public void EnsureContingentPropertiesInitialized(){} // RVA: 0x7ADD367F0
        public void EnsureContingentPropertiesInitializedCore(){} // RVA: 0x7ADD36940
        public void get_CancellationToken(){} // RVA: 0x7ADD36A80
        public void get_IsCancellationAcknowledged(){} // RVA: 0x7ADD36AA0
        public void get_IsCompleted(){} // RVA: 0x7ADD36AC0
        public void IsCompletedMethod(){} // RVA: 0x7ADD36B20
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7ADD36B30
        public void get_CreationOptions(){} // RVA: 0x7ADD36B50
        public void System.IAsyncResult.get_AsyncWaitHandle(){} // RVA: 0x7ADD36BA0
        public void get_AsyncState(){} // RVA: 0x7A81052C0
        public void System.IAsyncResult.get_CompletedSynchronously(){} // RVA: 0x7A80D7320
        public void get_ExecutingTaskScheduler(){} // RVA: 0x7A8105330
        public void get_Factory(){} // RVA: 0x7ADD36C50
        public void get_CompletedTask(){} // RVA: 0x7ADD36CB0
        public void get_CompletedEvent(){} // RVA: 0x7ADD36D10
        public void get_ExceptionRecorded(){} // RVA: 0x7ADD36E90
        public void get_IsFaulted(){} // RVA: 0x7ADD36EE0
        public void get_CapturedContext(){} // RVA: 0x7ADD36F00
        public void set_CapturedContext(){} // RVA: 0x7ADD36F80
        public void Dispose(){} // RVA: 0x7ADD370D0
        public void ScheduleAndStart(){} // RVA: 0x7ADD37200
        public void AddException(){} // RVA: 0x7ADD37390
        public void GetExceptions(){} // RVA: 0x7ADD37670
        public void GetExceptionDispatchInfos(){} // RVA: 0x7ADD37840
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x7ADD37AC0
        public void ThrowIfExceptional(){} // RVA: 0x7ADD37AF0
        public void UpdateExceptionObservedStatus(){} // RVA: 0x7ADD37B40
        public void get_IsExceptionObservedByParent(){} // RVA: 0x7ADD37C60
        public void get_IsDelegateInvoked(){} // RVA: 0x7ADD37C80
        public void Finish(){} // RVA: 0x7ADD37CA0
        public void FinishStageTwo(){} // RVA: 0x7ADD37EA0
        public void FinishStageThree(){} // RVA: 0x7ADD37FE0
        public void ProcessChildCompletion(){} // RVA: 0x7ADD380D0
        public void AddExceptionsFromChildren(){} // RVA: 0x7ADD38370
        public void Execute(){} // RVA: 0x7ADD38740
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7ADD38780
        public void ExecuteEntry(){} // RVA: 0x7ADD38790
        public void ExecutionContextCallback(){} // RVA: 0x7ADD38970
        public void InnerInvoke(){} // RVA: 0x7ADD38A00
        public void HandleException(){} // RVA: 0x7ADD38AA0
        public void GetAwaiter(){} // RVA: 0x7A8DBD970
        public void ConfigureAwait(){} // RVA: 0x7ADD38BC0
        public void SetContinuationForAwait(){} // RVA: 0x7ADD38BE0
        public void Yield(){} // RVA: 0x7A80D7320
        public void Wait(){} // RVA: 0x7ADD38EB0
        public void WrappedTryRunInline(){} // RVA: 0x7ADD38FF0
        public void InternalWait(){} // RVA: 0x7ADD39090
        public void SpinThenBlockingWait(){} // RVA: 0x7ADD39560
        public void SpinWait(){} // RVA: 0x7ADD39970
        public void InternalCancel(){} // RVA: 0x7ADD39B20
        public void RecordInternalCancellationRequest(){} // RVA: 0x7ADD39E60
        public void CancellationCleanupLogic(){} // RVA: 0x7ADD39F90
        public void SetCancellationAcknowledged(){} // RVA: 0x7ADD3A050
        public void FinishContinuations(){} // RVA: 0x7ADD3A070
        public void LogFinishCompletionNotification(){} // RVA: 0x7ADD3A700
        public void ContinueWith(){} // RVA: 0x7A8051B10
        public void CreationOptionsFromContinuationOptions(){} // RVA: 0x7ADD3ABC0
        public void ContinueWithCore(){} // RVA: 0x7ADD3AD20
        public void AddCompletionAction(){} // RVA: 0x7ADD3B0A0
        public void AddTaskContinuationComplex(){} // RVA: 0x7ADD3B120
        public void AddTaskContinuation(){} // RVA: 0x7ADD3B4E0
        public void RemoveContinuation(){} // RVA: 0x7ADD3B5F0
        public void FromResult(){} // RVA: 0x7AA604400
        public void FromException(){} // RVA: 0x7AA602470
        public void FromCancellation(){} // RVA: 0x7AA5EBAC0
        public void FromCanceled(){} // RVA: 0x7AA5D24F0
        public void Run(){} // RVA: 0x7AA604760
        public void Delay(){} // RVA: 0x7ADD3C140
        public void WhenAll(){} // RVA: 0x7A7E00BA0
        public void InternalWhenAll(){} // RVA: 0x7A7E00BA0
        public void WhenAny(){} // RVA: 0x7ADD3CB00
        public void CreateUnwrapPromise(){} // RVA: 0x7AA5B4E80
        public void AddToActiveTasks(){} // RVA: 0x7ADD3CE00
        public void RemoveFromActiveTasks(){} // RVA: 0x7ADD3CFE0
        public void MarkAborted(){} // RVA: 0x7A80D7310
        public void ExecuteWithThreadLocal(){} // RVA: 0x7ADD3D190
        public void .cctor(){} // RVA: 0x7ADD3D4B0
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1D590
        public void get_Task(){} // RVA: 0x7A7E00680
        public void SpinUntilCompleted(){} // RVA: 0x7A7E18770
        public void TrySetException(){} // RVA: 0x7A7E019D0
        public void SetException(){} // RVA: 0x7A7E18800
        public void TrySetResult(){} // RVA: 0x7A8051B10
        public void SetResult(){} // RVA: 0x7A8051B10
        public void TrySetCanceled(){} // RVA: 0x7A8051B10
        public void SetCanceled(){} // RVA: 0x7A7E18770
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Methods ──
        public void TrySetResult(){} // RVA: 0x7ABECAF00
        public void .ctor(){} // RVA: 0x7ABECAC60
        public void get_Task(){} // RVA: 0x7A80F2570
        public void SpinUntilCompleted(){} // RVA: 0x7ABECAD20
        public void TrySetException(){} // RVA: 0x7ABECAE30
        public void SetException(){} // RVA: 0x7ABECAE90
        public void SetResult(){} // RVA: 0x7ABECAF40
        public void TrySetCanceled(){} // RVA: 0x7ABECB030
        public void SetCanceled(){} // RVA: 0x7ABECB0C0
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECB200
        public void get_Task(){} // RVA: 0x7A80F2570
        public void SpinUntilCompleted(){} // RVA: 0x7ABECB2C0
        public void TrySetException(){} // RVA: 0x7ABECB3D0
        public void SetException(){} // RVA: 0x7ABECB430
        public void TrySetResult(){} // RVA: 0x7ABECB4A0
        public void SetResult(){} // RVA: 0x7ABECB4E0
        public void TrySetCanceled(){} // RVA: 0x7ABECB530
        public void SetCanceled(){} // RVA: 0x7ABECB5C0
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECA160
        public void get_Task(){} // RVA: 0x7A80F2570
        public void SpinUntilCompleted(){} // RVA: 0x7ABECA220
        public void TrySetException(){} // RVA: 0x7ABECA330
        public void SetException(){} // RVA: 0x7ABECA390
        public void TrySetResult(){} // RVA: 0x7ABECA400
        public void SetResult(){} // RVA: 0x7ABECA440
        public void TrySetCanceled(){} // RVA: 0x7ABECA510
        public void SetCanceled(){} // RVA: 0x7ABECA5A0
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABEC8980
        public void get_Task(){} // RVA: 0x7A80F2570
        public void TrySetResult(){} // RVA: 0x7ABEC8C20
        public void SpinUntilCompleted(){} // RVA: 0x7ABEC8A40
        public void TrySetException(){} // RVA: 0x7ABEC8B50
        public void SetException(){} // RVA: 0x7ABEC8BB0
        public void SetResult(){} // RVA: 0x7ABEC8C60
        public void TrySetCanceled(){} // RVA: 0x7ABEC8D40
        public void SetCanceled(){} // RVA: 0x7ABEC8DD0
    }

    public class TaskCompletionSource`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECAC60
        public void get_Task(){} // RVA: 0x7A80F2570
        public void SpinUntilCompleted(){} // RVA: 0x7ABECAD20
        public void TrySetException(){} // RVA: 0x7ABECAE30
        public void SetException(){} // RVA: 0x7ABECAE90
        public void TrySetResult(){} // RVA: 0x7ABECAF00
        public void SetResult(){} // RVA: 0x7ABECAF40
        public void TrySetCanceled(){} // RVA: 0x7ABECB030
        public void SetCanceled(){} // RVA: 0x7ABECB0C0
    }

    public class TaskContinuation : Object
    {
        // ── Methods ──
        public void Run(){} // RVA: 0x7A7E1D550
        public void InlineIfPossibleOrElseQueue(){} // RVA: 0x7ADD3EA80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TaskExceptionHolder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ShouldFailFastOnUnobservedException(){} // RVA: 0x7A80D7320
        public void Finalize(){} // RVA: 0x7ADA1FEF0
        public void get_ContainsFaultList(){} // RVA: 0x7ADA20120
        public void Add(){} // RVA: 0x7ADA20130
        public void SetCancellationException(){} // RVA: 0x7ADA20150
        public void AddFaultException(){} // RVA: 0x7ADA20350
        public void MarkAsUnhandled(){} // RVA: 0x7ADA20950
        public void MarkAsHandled(){} // RVA: 0x7ADA209C0
        public void CreateExceptionObject(){} // RVA: 0x7ADA20A40
        public void GetExceptionDispatchInfos(){} // RVA: 0x7ADA20CD0
        public void GetCancellationExceptionDispatchInfo(){} // RVA: 0x7A81052C0
        public void .cctor(){} // RVA: 0x7ADA20DF0
    }

    public class TaskExtensions : Object
    {
        // ── Methods ──
        public void Unwrap(){} // RVA: 0x7AA605530
    }

    public class TaskFactory : Object
    {
        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x7ADA20E30
        public void .ctor(){} // RVA: 0x7ABECC270
        public void CheckCreationOptions(){} // RVA: 0x7ADA20F20
        public void get_Scheduler(){} // RVA: 0x7A80DA7B0
        public void StartNew(){} // RVA: 0x7AA605FA0
        public void FromAsync(){} // RVA: 0x7A8051B10
        public void CheckFromAsyncOptions(){} // RVA: 0x7ADA21160
        public void CommonCWAnyLogic(){} // RVA: 0x7ADA21290
        public void CheckMultiTaskContinuationOptions(){} // RVA: 0x7ADA21570
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void GetDefaultScheduler(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A8051B10
        public void StartNew(){} // RVA: 0x7A8051B10
        public void FromAsync(){} // RVA: 0x7A8051B10
        public void FromAsyncImpl(){} // RVA: 0x7A8051B10
        public void FromAsyncTrim(){} // RVA: 0x7A8051B10
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7ABECD9F0
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7ABECD9F0
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7ABECD9F0
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7ABECD9F0
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7ABECD9F0
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7ABECD9F0
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7ABECD9F0
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7ABECD9F0
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7ABECD9F0
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskFactory`1 : Object
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7ABECD9F0
        public void .ctor(){} // RVA: 0x7ABECC1C0
    }

    public class TaskReplicator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD33280
        public void Run(){} // RVA: 0x7AA606790
        public void GenerateCooperativeMultitaskingTaskTimeout(){} // RVA: 0x7ADD33400
    }

    public class TaskScheduler : Object
    {
        // ── Methods ──
        public void QueueTask(){} // RVA: 0x7A7E18800
        public void TryExecuteTaskInline(){} // RVA: 0x7A7E03AD0
        public void get_MaximumConcurrencyLevel(){} // RVA: 0x7ADA219E0
        public void TryRunInline(){} // RVA: 0x7ADA219F0
        public void TryDequeue(){} // RVA: 0x7A80D7320
        public void NotifyWorkItemProgress(){} // RVA: 0x7A80D7310
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Default(){} // RVA: 0x7ADA21C20
        public void get_Current(){} // RVA: 0x7ADA21C80
        public void get_InternalCurrent(){} // RVA: 0x7ADA21D30
        public void FromCurrentSynchronizationContext(){} // RVA: 0x7ADA21DE0
        public void get_Id(){} // RVA: 0x7ADA21F00
        public void TryExecuteTask(){} // RVA: 0x7ADA21FA0
        public void add_UnobservedTaskException(){} // RVA: 0x7ADA22020
        public void remove_UnobservedTaskException(){} // RVA: 0x7ADA22260
        public void PublishUnobservedTaskException(){} // RVA: 0x7ADA22450
        public void .cctor(){} // RVA: 0x7ADA22570
    }

    public class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD3EE40
        public void Run(){} // RVA: 0x7ADD3F520
    }

    public class TaskToApm : Object
    {
        // ── Methods ──
        public void Begin(){} // RVA: 0x7AE5E7380
        public void End(){} // RVA: 0x7A8051B10
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x7AE5E7630
    }

    public class TaskToApm : Object
    {
        // ── Methods ──
        public void Begin(){} // RVA: 0x7ADD30930
        public void End(){} // RVA: 0x7AA606F10
        public void InvokeCallbackWhenTaskCompletes(){} // RVA: 0x7ADD30BE0
    }

    public class Task[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
        public void StartNew(){} // RVA: 0x7A8051B10
        public void TrySetResult(){} // RVA: 0x7A8051B10
        public void DangerousSetResult(){} // RVA: 0x7A8051B10
        public void get_Result(){} // RVA: 0x7A8051B10
        public void get_ResultOnSuccess(){} // RVA: 0x7A8051B10
        public void GetResultCore(){} // RVA: 0x7A8051B10
        public void get_Factory(){} // RVA: 0x7A7E006B0
        public void InnerInvoke(){} // RVA: 0x7A7E18770
        public void GetAwaiter(){} // RVA: 0x7A8051B10
        public void ConfigureAwait(){} // RVA: 0x7A8051B10
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void .ctor(){} // RVA: 0x7AC127140
        public void TrySetResult(){} // RVA: 0x7ABFD0690
        public void StartNew(){} // RVA: 0x7AC127420
        public void DangerousSetResult(){} // RVA: 0x7ABFD07E0
        public void get_Result(){} // RVA: 0x7ABFD0870
        public void GetResultCore(){} // RVA: 0x7ABFD09D0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7ABFD0D40
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
        public void .ctor(){} // RVA: 0x7AC15E1F0
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void StartNew(){} // RVA: 0x7AC15E980
        public void DangerousSetResult(){} // RVA: 0x7AC15EC60
        public void get_Result(){} // RVA: 0x7AC15ED00
        public void GetResultCore(){} // RVA: 0x7ABFDA2F0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7AC15ED40
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
        public void TrySetResult(){} // RVA: 0x7AC15EB20
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC157AC0
        public void TrySetResult(){} // RVA: 0x7AC157F40
        public void StartNew(){} // RVA: 0x7AC157DA0
        public void DangerousSetResult(){} // RVA: 0x7AC158030
        public void get_Result(){} // RVA: 0x7AC08F7D0
        public void get_ResultOnSuccess(){} // RVA: 0x7A8355950
        public void GetResultCore(){} // RVA: 0x7AC08F900
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7AC08FA20
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC170B00
        public void TrySetResult(){} // RVA: 0x7AC149BC0
        public void StartNew(){} // RVA: 0x7AC170DE0
        public void DangerousSetResult(){} // RVA: 0x7AC149CB0
        public void get_Result(){} // RVA: 0x7AC149CE0
        public void get_ResultOnSuccess(){} // RVA: 0x7A8192400
        public void GetResultCore(){} // RVA: 0x7AC149E10
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7AC149F30
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void .ctor(){} // RVA: 0x7AC15E6A0
        public void StartNew(){} // RVA: 0x7AC15E980
        public void TrySetResult(){} // RVA: 0x7AC15EB20
        public void DangerousSetResult(){} // RVA: 0x7AC15EC60
        public void get_Result(){} // RVA: 0x7AC15ED00
        public void GetResultCore(){} // RVA: 0x7ABFDA2F0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7AC15ED40
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
        public void .ctor(){} // RVA: 0x7AC15E1F0
        public void TrySetResult(){} // RVA: 0x7AC15EB20
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
        public void .ctor(){} // RVA: 0x7AC15E1F0
        public void TrySetResult(){} // RVA: 0x7AC15EB20
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC15E1F0
        public void TrySetResult(){} // RVA: 0x7AC15EB20
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void .ctor(){} // RVA: 0x7ABFD2D20
        public void StartNew(){} // RVA: 0x7ABFD3000
        public void TrySetResult(){} // RVA: 0x7ABFD0690
        public void DangerousSetResult(){} // RVA: 0x7ABFD07E0
        public void get_Result(){} // RVA: 0x7ABFD0870
        public void GetResultCore(){} // RVA: 0x7ABFD09D0
        public void InnerInvoke(){} // RVA: 0x7ABFD0D40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC1853B0
        public void TrySetResult(){} // RVA: 0x7AC15D640
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7AC022530
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC15E1F0
        public void TrySetResult(){} // RVA: 0x7AC15EB20
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void .ctor(){} // RVA: 0x7ABFD2D20
        public void StartNew(){} // RVA: 0x7ABFD3000
        public void TrySetResult(){} // RVA: 0x7ABFD0690
        public void DangerousSetResult(){} // RVA: 0x7ABFD07E0
        public void get_Result(){} // RVA: 0x7ABFD0870
        public void GetResultCore(){} // RVA: 0x7ABFD09D0
        public void InnerInvoke(){} // RVA: 0x7ABFD0D40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC186500
        public void TrySetResult(){} // RVA: 0x7AC135B20
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFE3A20
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC181BB0
        public void TrySetResult(){} // RVA: 0x7AC137010
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7AC13FED0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC1898C0
        public void TrySetResult(){} // RVA: 0x7AC1297A0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7AC02B6A0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC187640
        public void TrySetResult(){} // RVA: 0x7ABFE1F20
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7AC005770
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD44A0
        public void ContinueWith(){} // RVA: 0x7AA13BB90
        public void .ctor(){} // RVA: 0x7AC156A40
        public void TrySetResult(){} // RVA: 0x7AC14E3A0
        public void StartNew(){} // RVA: 0x7AC156D20
        public void DangerousSetResult(){} // RVA: 0x7AC14E490
        public void get_Result(){} // RVA: 0x7ABFD4370
        public void GetResultCore(){} // RVA: 0x7ABFD44B0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7ABFD45D0
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC15E1F0
        public void TrySetResult(){} // RVA: 0x7AC15EB20
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC10D240
        public void TrySetResult(){} // RVA: 0x7AC10DB70
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC15E1F0
        public void TrySetResult(){} // RVA: 0x7AC15EB20
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC15E1F0
        public void TrySetResult(){} // RVA: 0x7AC15EB20
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7A8192400
        public void .ctor(){} // RVA: 0x7AC14AC20
        public void TrySetResult(){} // RVA: 0x7AC14B0A0
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void StartNew(){} // RVA: 0x7AC14AF00
        public void DangerousSetResult(){} // RVA: 0x7AC14B190
        public void get_Result(){} // RVA: 0x7AC149CE0
        public void GetResultCore(){} // RVA: 0x7AC149E10
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7AC149F30
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
        public void StartNew(){} // RVA: 0x7AC15E980
        public void .ctor(){} // RVA: 0x7AC15E6A0
        public void TrySetResult(){} // RVA: 0x7AC15EB20
        public void DangerousSetResult(){} // RVA: 0x7AC15EC60
        public void get_Result(){} // RVA: 0x7AC15ED00
        public void GetResultCore(){} // RVA: 0x7ABFDA2F0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7AC15ED40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC12E790
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD6C80
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void TrySetResult(){} // RVA: 0x7ABFDD750
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC15E1F0
        public void TrySetResult(){} // RVA: 0x7AC15EB20
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC16E9C0
        public void TrySetResult(){} // RVA: 0x7AC149BC0
        public void StartNew(){} // RVA: 0x7AC16ECA0
        public void DangerousSetResult(){} // RVA: 0x7AC149CB0
        public void get_Result(){} // RVA: 0x7AC149CE0
        public void get_ResultOnSuccess(){} // RVA: 0x7A8192400
        public void GetResultCore(){} // RVA: 0x7AC149E10
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7AC149F30
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC171C50
        public void StartNew(){} // RVA: 0x7AC171F60
        public void TrySetResult(){} // RVA: 0x7AC172130
        public void DangerousSetResult(){} // RVA: 0x7AC1722B0
        public void get_Result(){} // RVA: 0x7A80804D0
        public void get_ResultOnSuccess(){} // RVA: 0x7A80804D0
        public void GetResultCore(){} // RVA: 0x7A80804D0
        public void get_Factory(){} // RVA: 0x7AC1726A0
        public void InnerInvoke(){} // RVA: 0x7AC172870
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_Result(){} // RVA: 0x7AC15ED00
        public void .ctor(){} // RVA: 0x7AC15E6A0
        public void StartNew(){} // RVA: 0x7AC15E980
        public void TrySetResult(){} // RVA: 0x7AC15EB20
        public void DangerousSetResult(){} // RVA: 0x7AC15EC60
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
        public void GetResultCore(){} // RVA: 0x7ABFDA2F0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7AC15ED40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7AC15E980
        public void .ctor(){} // RVA: 0x7AC15E6A0
        public void TrySetResult(){} // RVA: 0x7AC15EB20
        public void DangerousSetResult(){} // RVA: 0x7AC15EC60
        public void get_Result(){} // RVA: 0x7AC15ED00
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
        public void GetResultCore(){} // RVA: 0x7ABFDA2F0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7AC15ED40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void .ctor(){} // RVA: 0x7AC15E1F0
        public void StartNew(){} // RVA: 0x7AC15E980
        public void DangerousSetResult(){} // RVA: 0x7AC15EC60
        public void get_Result(){} // RVA: 0x7AC15ED00
        public void GetResultCore(){} // RVA: 0x7ABFDA2F0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7AC15ED40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ContinueWith(){} // RVA: 0x7A8051B10
        public void TrySetResult(){} // RVA: 0x7AC15EB20
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABFD76A0
        public void TrySetResult(){} // RVA: 0x7ABFD69D0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABFD8740
        public void TrySetResult(){} // RVA: 0x7ABFD5730
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABFD9C10
        public void TrySetResult(){} // RVA: 0x7ABFDA090
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void StartNew(){} // RVA: 0x7ABFD9EF0
        public void DangerousSetResult(){} // RVA: 0x7ABFDA180
        public void get_Result(){} // RVA: 0x7ABFDA1C0
        public void GetResultCore(){} // RVA: 0x7ABFDA2F0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7ABFDA410
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC14DAF0
        public void TrySetResult(){} // RVA: 0x7AC14E3A0
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD44A0
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC15E6A0
        public void TrySetResult(){} // RVA: 0x7AC15EB20
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void StartNew(){} // RVA: 0x7AC15E980
        public void DangerousSetResult(){} // RVA: 0x7AC15EC60
        public void get_Result(){} // RVA: 0x7AC15ED00
        public void GetResultCore(){} // RVA: 0x7ABFDA2F0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7AC15ED40
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC15E6A0
        public void TrySetResult(){} // RVA: 0x7AC15EB20
        public void StartNew(){} // RVA: 0x7AC15E980
        public void DangerousSetResult(){} // RVA: 0x7AC15EC60
        public void get_Result(){} // RVA: 0x7AC15ED00
        public void get_ResultOnSuccess(){} // RVA: 0x7A8178B90
        public void GetResultCore(){} // RVA: 0x7ABFDA2F0
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void InnerInvoke(){} // RVA: 0x7AC15ED40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void .ctor(){} // RVA: 0x7ABFD2D20
        public void StartNew(){} // RVA: 0x7ABFD3000
        public void TrySetResult(){} // RVA: 0x7ABFD0690
        public void DangerousSetResult(){} // RVA: 0x7ABFD07E0
        public void get_Result(){} // RVA: 0x7ABFD0870
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
        public void GetResultCore(){} // RVA: 0x7ABFD09D0
        public void InnerInvoke(){} // RVA: 0x7ABFD0D40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void .ctor(){} // RVA: 0x7ABFD2D20
        public void StartNew(){} // RVA: 0x7ABFD3000
        public void TrySetResult(){} // RVA: 0x7ABFD0690
        public void DangerousSetResult(){} // RVA: 0x7ABFD07E0
        public void get_Result(){} // RVA: 0x7ABFD0870
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
        public void GetResultCore(){} // RVA: 0x7ABFD09D0
        public void InnerInvoke(){} // RVA: 0x7ABFD0D40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void .ctor(){} // RVA: 0x7ABFD2D20
        public void StartNew(){} // RVA: 0x7ABFD3000
        public void TrySetResult(){} // RVA: 0x7ABFD0690
        public void DangerousSetResult(){} // RVA: 0x7ABFD07E0
        public void get_Result(){} // RVA: 0x7ABFD0870
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
        public void GetResultCore(){} // RVA: 0x7ABFD09D0
        public void InnerInvoke(){} // RVA: 0x7ABFD0D40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void .ctor(){} // RVA: 0x7ABFD2D20
        public void StartNew(){} // RVA: 0x7ABFD3000
        public void TrySetResult(){} // RVA: 0x7ABFD0690
        public void DangerousSetResult(){} // RVA: 0x7ABFD07E0
        public void get_Result(){} // RVA: 0x7ABFD0870
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
        public void GetResultCore(){} // RVA: 0x7ABFD09D0
        public void InnerInvoke(){} // RVA: 0x7ABFD0D40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void .ctor(){} // RVA: 0x7ABFD2D20
        public void StartNew(){} // RVA: 0x7ABFD3000
        public void TrySetResult(){} // RVA: 0x7ABFD0690
        public void DangerousSetResult(){} // RVA: 0x7ABFD07E0
        public void get_Result(){} // RVA: 0x7ABFD0870
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
        public void GetResultCore(){} // RVA: 0x7ABFD09D0
        public void InnerInvoke(){} // RVA: 0x7ABFD0D40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void .ctor(){} // RVA: 0x7ABFD2D20
        public void StartNew(){} // RVA: 0x7ABFD3000
        public void TrySetResult(){} // RVA: 0x7ABFD0690
        public void DangerousSetResult(){} // RVA: 0x7ABFD07E0
        public void get_Result(){} // RVA: 0x7ABFD0870
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
        public void GetResultCore(){} // RVA: 0x7ABFD09D0
        public void InnerInvoke(){} // RVA: 0x7ABFD0D40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void .ctor(){} // RVA: 0x7ABFD2D20
        public void StartNew(){} // RVA: 0x7ABFD3000
        public void TrySetResult(){} // RVA: 0x7ABFD0690
        public void DangerousSetResult(){} // RVA: 0x7ABFD07E0
        public void get_Result(){} // RVA: 0x7ABFD0870
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
        public void GetResultCore(){} // RVA: 0x7ABFD09D0
        public void InnerInvoke(){} // RVA: 0x7ABFD0D40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7ABFD0B00
        public void .ctor(){} // RVA: 0x7ABFD2D20
        public void StartNew(){} // RVA: 0x7ABFD3000
        public void TrySetResult(){} // RVA: 0x7ABFD0690
        public void DangerousSetResult(){} // RVA: 0x7ABFD07E0
        public void get_Result(){} // RVA: 0x7ABFD0870
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD09C0
        public void GetResultCore(){} // RVA: 0x7ABFD09D0
        public void InnerInvoke(){} // RVA: 0x7ABFD0D40
        public void GetAwaiter(){} // RVA: 0x7ABFD0ED0
        public void ConfigureAwait(){} // RVA: 0x7ABFD0F30
        public void ContinueWith(){} // RVA: 0x7A8051B10
    }

    public class Task`1 : Task
    {
        // ── Methods ──
        public void get_ResultOnSuccess(){} // RVA: 0x7ABFD6C80
    }

    public class Task`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ThreadPoolTaskScheduler : TaskScheduler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA22C80
        public void QueueTask(){} // RVA: 0x7ADA22CD0
        public void TryExecuteTaskInline(){} // RVA: 0x7ADA230A0
        public void TryDequeue(){} // RVA: 0x7ADA23170
        public void NotifyWorkItemProgress(){} // RVA: 0x7ADA23180
        public void get_RequiresAtomicStartTransition(){} // RVA: 0x7A80D7320
        public void .cctor(){} // RVA: 0x7ADA231F0
    }

}