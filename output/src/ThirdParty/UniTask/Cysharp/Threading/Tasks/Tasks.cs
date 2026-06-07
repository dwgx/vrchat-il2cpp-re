// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 99
// Methods: 777

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class AsyncInstantiateOperationExtensions
    {
        // ── Methods ──
        public void WithCancellation(){} // RVA: 0x283FA0 | overloaded x4
        public void ToUniTask(){} // RVA: 0x283FA0 | overloaded x2
    }

    public class AsyncLazy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CE2A50 | overloaded x2
        public void get_Task(){} // RVA: 0x6CE2DE0
        public void GetAwaiter(){} // RVA: 0x6CE2E90
        public void EnsureInitialized(){} // RVA: 0x6CE3000
        public void EnsureInitializedCore(){} // RVA: 0x6CE3030
        public void SetCompletionSource(){} // RVA: 0x6CE3400 | overloaded x2
        public void .cctor(){} // RVA: 0x6CE35A0
    }

    public class AsyncLazy`1
    {
        public object IsCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
        public void get_Task(){} // RVA: 0x283FA0
        public void GetAwaiter(){} // RVA: 0x283FA0
        public void EnsureInitialized(){} // RVA: 0x24A50
        public void EnsureInitializedCore(){} // RVA: 0x24A50
        public void SetCompletionSource(){} // RVA: 0x24AE0 | overloaded x2
        public void .cctor(){} // RVA: 0x24A80
    }

    public class AsyncReactiveProperty`1
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x283FA0
        public void set_Value(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0
        public void WithoutCurrent(){} // RVA: 0xCD60
        public void GetAsyncEnumerator(){}
        public void Dispose(){} // RVA: 0x24A50
        public void op_Implicit(){} // RVA: 0x283FA0
        public void ToString(){} // RVA: 0xCD60
        public void WaitAsync(){} // RVA: 0x283FA0
        public void .cctor(){} // RVA: 0x24A80
    }

    public class AsyncUnit
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x519240
        public void Equals(){} // RVA: 0x3C2850
        public void ToString(){} // RVA: 0x6CE3680
        public void .cctor(){} // RVA: 0x2DD310
    }

    public class AsyncUnityEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D404A0
        public void OnInvokeAsync(){} // RVA: 0x6D40790
        public void Invoke(){} // RVA: 0x6D40880
        public void CancellationCallback(){} // RVA: 0x6D40900
        public void Dispose(){} // RVA: 0x6D40980
        public void Cysharp.Threading.Tasks.IAsyncClickEventHandler.OnClickAsync(){} // RVA: 0x6D40A30
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x6D40A60
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){} // RVA: 0x6D40B00
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x6D40B50
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){} // RVA: 0x6D40B90
        public void .cctor(){} // RVA: 0x6D40C10
    }

    public class AsyncUnityEventHandler`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void OnInvokeAsync(){} // RVA: 0x283FA0
        public void Invoke(){} // RVA: 0x283FA0
        public void CancellationCallback(){} // RVA: 0x24AE0
        public void Dispose(){} // RVA: 0x24A50
        public void Cysharp.Threading.Tasks.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync(){} // RVA: 0x283FA0
        public void Cysharp.Threading.Tasks.IAsyncEndEditEventHandler<T>.OnEndEditAsync(){} // RVA: 0x283FA0
        public void Cysharp.Threading.Tasks.IAsyncEndTextSelectionEventHandler<T>.OnEndTextSelectionAsync(){} // RVA: 0x283FA0
        public void Cysharp.Threading.Tasks.IAsyncTextSelectionEventHandler<T>.OnTextSelectionAsync(){} // RVA: 0x283FA0
        public void Cysharp.Threading.Tasks.IAsyncDeselectEventHandler<T>.OnDeselectAsync(){} // RVA: 0x283FA0
        public void Cysharp.Threading.Tasks.IAsyncSelectEventHandler<T>.OnSelectAsync(){} // RVA: 0x283FA0
        public void Cysharp.Threading.Tasks.IAsyncSubmitEventHandler<T>.OnSubmitAsync(){} // RVA: 0x283FA0
        public void Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(){} // RVA: 0x283FA0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){}
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0xD840
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){}
        public void .cctor(){} // RVA: 0x24A80
    }

    public class AutoResetUniTaskCompletionSource : Cysharp.Threading.Tasks
    {
        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x3DF6A30
        public void .cctor(){} // RVA: 0x6CFF630
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x6CFF7B0
        public void CreateFromCanceled(){} // RVA: 0x6CFF870
        public void CreateFromException(){} // RVA: 0x6CFF950
        public void CreateCompleted(){} // RVA: 0x6CFFA30
        public void get_Task(){} // RVA: 0x6CFFAC0
        public void TrySetResult(){} // RVA: 0x6CFFB60
        public void TrySetCanceled(){} // RVA: 0x6CFFC00
        public void TrySetException(){} // RVA: 0x6CFFC70
        public void GetResult(){} // RVA: 0x6CFFCF0
        public void GetStatus(){} // RVA: 0x6CFFE20
        public void UnsafeGetStatus(){} // RVA: 0x6CFFE70
        public void OnCompleted(){} // RVA: 0x6CFFEB0
        public void TryReturn(){} // RVA: 0x6CFFF30
    }

    public class AutoResetUniTaskCompletionSource`1
    {
        // ── Methods ──
        public void get_NextNode(){} // RVA: 0xCD60
        public void .cctor(){} // RVA: 0x24A80
        public void .ctor(){} // RVA: 0x24A50
        public void Create(){} // RVA: 0xC960
        public void CreateFromCanceled(){} // RVA: 0x283FA0
        public void CreateFromException(){} // RVA: 0xCEC0
        public void CreateFromResult(){} // RVA: 0x283FA0
        public void get_Task(){} // RVA: 0x283FA0
        public void TrySetResult(){} // RVA: 0x283FA0
        public void TrySetCanceled(){} // RVA: 0x283FA0
        public void TrySetException(){} // RVA: 0xDE40
        public void GetResult(){} // RVA: 0x283FA0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
        public void GetStatus(){}
        public void UnsafeGetStatus(){} // RVA: 0xD840
        public void OnCompleted(){}
        public void TryReturn(){} // RVA: 0xDBE0
    }

    public class AwaiterActions
    {
        // ── Methods ──
        public void Continuation(){} // RVA: 0x6CFD7E0
        public void .cctor(){} // RVA: 0x6CFD850
    }

    public class CancellationTokenAwaitable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x100A2F0
        public void GetAwaiter(){} // RVA: 0x6CE4A90
    }

    public class CancellationTokenEqualityComparer
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x6CE36C0
        public void GetHashCode(){} // RVA: 0x6CE3720
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6CE37E0
    }

    public class CancellationTokenExtensions
    {
        // ── Methods ──
        public void ToCancellationToken(){} // RVA: 0x283FA0 | overloaded x4
        public void ToCancellationTokenCore(){} // RVA: 0x6CE3AC0
        public void ToUniTask(){} // RVA: 0x6CE3C50
        public void Callback(){} // RVA: 0x6CE4000
        public void WaitUntilCanceled(){} // RVA: 0x10073D0
        public void RegisterWithoutCaptureExecutionContext(){} // RVA: 0x6CE42C0 | overloaded x2
        public void AddTo(){} // RVA: 0x6CE4480
        public void DisposeCallback(){} // RVA: 0x6CE4520
        public void .cctor(){} // RVA: 0x6CE45C0
    }

    public class CancellationTokenSourceExtensions
    {
        // ── Methods ──
        public void CancelCancellationTokenSourceState(){} // RVA: 0x6CE4C00
        public void CancelAfterSlim(){} // RVA: 0x6CE4E50 | overloaded x2
        public void RegisterRaiseCancelOnDestroy(){} // RVA: 0x6CE5100 | overloaded x2
        public void .cctor(){} // RVA: 0x6CE5250
    }

    public class Channel
    {
        // ── Methods ──
        public void CreateSingleConsumerUnbounded(){} // RVA: 0xC960
    }

    public class ChannelClosedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E9B1D0 | overloaded x4
    }

    public class ChannelReader`1
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0xDE40
        public void WaitToReadAsync(){}
        public void get_Completion(){} // RVA: 0xC770
        public void ReadAsync(){} // RVA: 0x283FA0
        public void ReadAsyncCore(){} // RVA: 0x283FA0
        public void ReadAllAsync(){}
        public void .ctor(){} // RVA: 0x24A50
    }

    public class ChannelWriter`1
    {
        // ── Methods ──
        public void TryWrite(){} // RVA: 0x283FA0
        public void TryComplete(){} // RVA: 0xDE40
        public void Complete(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24A50
    }

    public class Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
    }

    public class Channel`2
    {
        public object `;

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x2F8380
        public void set_Reader(){} // RVA: 0x2DEE30
        public void get_Writer(){} // RVA: 0x2E07C0
        public void set_Writer(){} // RVA: 0x343E80
        public void op_Implicit(){} // RVA: 0x57726A0 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CompletedTasks
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6CFDA90
    }

    public class DeltaTimePlayerLoopTimer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CEC990
        public void MoveNextCore(){} // RVA: 0x6CECA60
        public void ResetCore(){} // RVA: 0x6CECB40
    }

    public class EnumerableAsyncExtensions
    {
        // ── Methods ──
        public void Select(){} // RVA: 0xCEC0 | overloaded x4
    }

    public class EnumeratorAsyncExtensions
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x283FA0
        public void WithCancellation(){} // RVA: 0x6CE53E0
        public void ToUniTask(){} // RVA: 0x6CE5610 | overloaded x2
        public void Core(){} // RVA: 0x6CE5870
    }

    public class ExceptionExtensions
    {
        // ── Methods ──
        public void IsOperationCanceledException(){} // RVA: 0x6CE7040
    }

    public class ExceptionHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetException(){} // RVA: 0x6CFF400
        public void Finalize(){} // RVA: 0x6CFF460
    }

    public class IAsyncClickEventHandler
    {
        // ── Methods ──
        public void OnClickAsync(){} // RVA: 0xC770
    }

    public class IAsyncDeselectEventHandler`1
    {
        // ── Methods ──
        public void OnDeselectAsync(){} // RVA: 0x283FA0
    }

    public class IAsyncEndEditEventHandler`1
    {
        // ── Methods ──
        public void OnEndEditAsync(){} // RVA: 0x283FA0
    }

    public class IAsyncEndTextSelectionEventHandler`1
    {
        // ── Methods ──
        public void OnEndTextSelectionAsync(){} // RVA: 0x283FA0
    }

    public class IAsyncReactiveProperty`1
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x283FA0
        public void set_Value(){} // RVA: 0x283FA0
    }

    public class IAsyncSelectEventHandler`1
    {
        // ── Methods ──
        public void OnSelectAsync(){} // RVA: 0x283FA0
    }

    public class IAsyncSubmitEventHandler`1
    {
        // ── Methods ──
        public void OnSubmitAsync(){} // RVA: 0x283FA0
    }

    public class IAsyncTextSelectionEventHandler`1
    {
        // ── Methods ──
        public void OnTextSelectionAsync(){} // RVA: 0x283FA0
    }

    public class IAsyncValueChangedEventHandler`1
    {
        // ── Methods ──
        public void OnValueChangedAsync(){} // RVA: 0x283FA0
    }

    public class ICancelPromise
    {
        // ── Methods ──
        public void TrySetCanceled(){} // RVA: 0x283FA0
    }

    public class IConnectableUniTaskAsyncEnumerable`1
    {
        // ── Methods ──
        public void Connect(){} // RVA: 0xCD60
    }

    public class IPlayerLoopItem
    {
        // ── Methods ──
        public void MoveNext(){} // RVA: 0xDBE0
    }

    public class IPromise : .ctor
    {
    }

    public class IPromise`1
    {
    }

    public class IReadOnlyAsyncReactiveProperty`1
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x283FA0
        public void WithoutCurrent(){} // RVA: 0xCD60
        public void WaitAsync(){} // RVA: 0x283FA0
    }

    public class IRejectPromise
    {
        // ── Methods ──
        public void TrySetException(){} // RVA: 0xDE40
    }

    public class IResolvePromise
    {
        // ── Methods ──
        public void TrySetResult(){} // RVA: 0xDBE0
    }

    public class IResolvePromise`1
    {
        // ── Methods ──
        public void TrySetResult(){} // RVA: 0x283FA0
    }

    public class ITaskPoolNode`1
    {
        // ── Methods ──
        public void get_NextNode(){} // RVA: 0xCD60
    }

    public class ITriggerHandler`1
    {
        // ── Methods ──
        public void OnNext(){} // RVA: 0x283FA0
        public void OnError(){} // RVA: 0x24B10
        public void OnCompleted(){} // RVA: 0x24A50
        public void OnCanceled(){} // RVA: 0x24CC0
        public void get_Prev(){} // RVA: 0xCD60
        public void set_Prev(){} // RVA: 0x24B10
        public void get_Next(){} // RVA: 0xCD60
        public void set_Next(){} // RVA: 0x24B10
    }

    public class IUniTaskAsyncDisposable
    {
        // ── Methods ──
        public void DisposeAsync(){} // RVA: 0xC770
    }

    public class IUniTaskAsyncEnumerable`1
    {
        // ── Methods ──
        public void GetAsyncEnumerator(){}
    }

    public class IUniTaskAsyncEnumerator`1
    {
        // ── Methods ──
        public void get_Current(){} // RVA: 0x283FA0
        public void MoveNextAsync(){}
    }

    public class IUniTaskOrderedAsyncEnumerable`1
    {
        // ── Methods ──
        public void CreateOrderedEnumerable(){} // overloaded x3
    }

    public class IUniTaskSource
    {
        // ── Methods ──
        public void GetStatus(){}
        public void OnCompleted(){}
        public void GetResult(){} // RVA: 0x24C40
        public void UnsafeGetStatus(){} // RVA: 0xD840
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetStatus(){} // RVA: 0x6CE7D30
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x6CE7D80
        public void System.Threading.Tasks.Sources.IValueTaskSource.OnCompleted(){} // RVA: 0x6CE7DE0
    }

    public class IUniTaskSource`1
    {
        // ── Methods ──
        public void GetResult(){} // RVA: 0x283FA0
        public void GetStatus(){}
        public void OnCompleted(){}
        public void System.Threading.Tasks.Sources.IValueTaskSource<T>.GetStatus(){}
        public void System.Threading.Tasks.Sources.IValueTaskSource<T>.GetResult(){} // RVA: 0x283FA0
        public void System.Threading.Tasks.Sources.IValueTaskSource<T>.OnCompleted(){}
    }

    public class IgnoreTimeScalePlayerLoopTimer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CECC60
        public void MoveNextCore(){} // RVA: 0x6CECD30
        public void ResetCore(){} // RVA: 0x6CECE10
    }

    public class MoveNextSource
    {
        // ── Methods ──
        public void GetResult(){} // RVA: 0x6CE7E80
        public void GetStatus(){} // RVA: 0x6CE7ED0
        public void OnCompleted(){} // RVA: 0x6CE7F20
        public void UnsafeGetStatus(){} // RVA: 0x6CE7FA0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x6CE7FE0
        public void TryGetResult(){} // RVA: 0x6CE8030 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PlayerLoopHelper
    {
        public object Parser;
        public object Descriptor;
        public object pb::Google.Protobuf.IMessage.Descriptor;
        public object GeometryPipelineOptions;

        // ── Methods ──
        public void get_UnitySynchronizationContext(){} // RVA: 0x6CE80B0
        public void get_MainThreadId(){} // RVA: 0x6CE8110
        public void get_ApplicationDataPath(){} // RVA: 0x6CE8170
        public void get_IsMainThread(){} // RVA: 0x6CE81D0
        public void get_IsEditorApplicationQuitting(){} // RVA: 0x6CE8290
        public void set_IsEditorApplicationQuitting(){} // RVA: 0x6CE82F0
        public void InsertRunner(){} // RVA: 0x6CE8350
        public void RemoveRunner(){} // RVA: 0x6CE88B0
        public void InsertUniTaskSynchronizationContext(){} // RVA: 0x6CE8AD0
        public void Init(){} // RVA: 0x6CE91C0
        public void FindLoopSystemIndex(){} // RVA: 0x6CE94C0
        public void InsertLoop(){} // RVA: 0x6CE95D0
        public void Initialize(){} // RVA: 0x6CE9A20
        public void AddAction(){} // RVA: 0x6CEB5E0
        public void ThrowInvalidLoopTiming(){} // RVA: 0x6CEB680
        public void AddContinuation(){} // RVA: 0x6CEB720
        public void DumpCurrentPlayerLoop(){} // RVA: 0x6CEB7C0
        public void IsInjectedUniTaskPlayerLoop(){} // RVA: 0x6CEBC50
        public void .cctor(){} // RVA: 0x6CEBE10
    }

    public class PlayerLoopTimer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CEC2E0
        public void Create(){} // RVA: 0x6CEC3F0
        public void StartNew(){} // RVA: 0x6CEC580
        public void Restart(){} // RVA: 0x6CEC780 | overloaded x2
        public void Stop(){} // RVA: 0x6CEC880
        public void ResetCore(){}
        public void Dispose(){} // RVA: 0x6CEC890
        public void Cysharp.Threading.Tasks.IPlayerLoopItem.MoveNext(){} // RVA: 0x6CEC8A0
        public void MoveNextCore(){} // RVA: 0xDBE0
    }

    public class Progress
    {
        // ── Methods ──
        public void Create(){} // RVA: 0xCE50
        public void CreateOnlyValueChanged(){} // RVA: 0xCEC0
    }

    public class ReadOnlyAsyncReactiveProperty`1
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
        public void ConsumeEnumerator(){} // RVA: 0x283FA0
        public void WithoutCurrent(){} // RVA: 0xCD60
        public void GetAsyncEnumerator(){}
        public void Dispose(){} // RVA: 0x24A50
        public void op_Implicit(){} // RVA: 0x283FA0
        public void ToString(){} // RVA: 0xCD60
        public void WaitAsync(){} // RVA: 0x283FA0
        public void .cctor(){} // RVA: 0x24A80
    }

    public class RealtimePlayerLoopTimer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CECF30
        public void MoveNextCore(){} // RVA: 0x6CED000
        public void ResetCore(){} // RVA: 0x6CED060
    }

    public class ReturnToMainThread
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37C6C70
        public void DisposeAsync(){} // RVA: 0x6CFE090
    }

    public class ReturnToSynchronizationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CFEFB0
        public void DisposeAsync(){} // RVA: 0x6CFF070
    }

    public class SingleConsumerUnboundedChannel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
    }

    public class StateExtensions
    {
        // ── Methods ──
        public void ToReadOnlyAsyncReactiveProperty(){} // RVA: 0x283FA0 | overloaded x2
    }

    public class SwitchToMainThreadAwaitable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37C6C70
        public void GetAwaiter(){} // RVA: 0x6CFE090
    }

    public class SwitchToSynchronizationContextAwaitable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37C8AF0
        public void GetAwaiter(){} // RVA: 0x6CFEC60
    }

    public class SwitchToTaskPoolAwaitable
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x2DD320
    }

    public class SwitchToThreadPoolAwaitable
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x2DD320
    }

    public class TaskPool
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6CED150
        public void SetMaxPoolSize(){} // RVA: 0x6CED340
        public void GetCacheSizeInfo(){} // RVA: 0x6CED3A0
        public void RegisterSizeGetter(){} // RVA: 0x6CED3F0
    }

    public class TaskPool`1
    {
        // ── Methods ──
        public void get_Size(){} // RVA: 0x19689E0
        public void TryPop(){} // RVA: 0x3E04090
        public void TryPush(){} // RVA: 0x41DEC80
    }

    public class TaskTracker
    {
        // ── Methods ──
        public void TrackActiveTask(){} // RVA: 0x2DD310
        public void RemoveTracking(){} // RVA: 0x2DD310
        public void CheckAndResetDirty(){} // RVA: 0x6CE70D0
        public void ForEachActiveTask(){} // RVA: 0x6CE7130
        public void TypeBeautify(){} // RVA: 0x6CE7790
        public void .cctor(){} // RVA: 0x6CE7AA0
    }

    public class TextMeshProAsyncExtensions
    {
        // ── Methods ──
        public void BindTo(){} // RVA: 0x2DDE0 | overloaded x5
        public void BindToCore(){} // RVA: 0x283FA0 | overloaded x2
        public void GetAsyncValueChangedEventHandler(){} // RVA: 0x6D2C9C0 | overloaded x2
        public void OnValueChangedAsync(){} // RVA: 0x6D2CB50 | overloaded x2
        public void OnValueChangedAsAsyncEnumerable(){} // RVA: 0x6D2CCE0 | overloaded x2
        public void GetAsyncEndEditEventHandler(){} // RVA: 0x6D2CE20 | overloaded x2
        public void OnEndEditAsync(){} // RVA: 0x6D2CFB0 | overloaded x2
        public void OnEndEditAsAsyncEnumerable(){} // RVA: 0x6D2D140 | overloaded x2
        public void GetAsyncEndTextSelectionEventHandler(){} // RVA: 0x6D2D2B0 | overloaded x2
        public void OnEndTextSelectionAsync(){} // RVA: 0x6D2D4A0 | overloaded x2
        public void OnEndTextSelectionAsAsyncEnumerable(){} // RVA: 0x6D2D690 | overloaded x2
        public void GetAsyncTextSelectionEventHandler(){} // RVA: 0x6D2D830 | overloaded x2
        public void OnTextSelectionAsync(){} // RVA: 0x6D2DA20 | overloaded x2
        public void OnTextSelectionAsAsyncEnumerable(){} // RVA: 0x6D2DC10 | overloaded x2
        public void GetAsyncDeselectEventHandler(){} // RVA: 0x6D2DD80 | overloaded x2
        public void OnDeselectAsync(){} // RVA: 0x6D2DF10 | overloaded x2
        public void OnDeselectAsAsyncEnumerable(){} // RVA: 0x6D2E0A0 | overloaded x2
        public void GetAsyncSelectEventHandler(){} // RVA: 0x6D2E1E0 | overloaded x2
        public void OnSelectAsync(){} // RVA: 0x6D2E370 | overloaded x2
        public void OnSelectAsAsyncEnumerable(){} // RVA: 0x6D2E500 | overloaded x2
        public void GetAsyncSubmitEventHandler(){} // RVA: 0x6D2E640 | overloaded x2
        public void OnSubmitAsync(){} // RVA: 0x6D2E7D0 | overloaded x2
        public void OnSubmitAsAsyncEnumerable(){} // RVA: 0x6D2E960 | overloaded x2
    }

    public class TextSelectionEventConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D40110
        public void InvokeCore(){} // RVA: 0x6D40330
        public void Dispose(){} // RVA: 0x6D40420
    }

    public class TimeoutController
    {
        // ── Methods ──
        public void CancelCancellationTokenSourceState(){} // RVA: 0x6CEDE80
        public void .ctor(){} // RVA: 0x6CEE0B0 | overloaded x2
        public void Timeout(){} // RVA: 0x6CEE340 | overloaded x2
        public void IsTimeout(){} // RVA: 0x6CEE7B0
        public void Reset(){} // RVA: 0x6CEE7E0
        public void Dispose(){} // RVA: 0x6CEE7F0
        public void .cctor(){} // RVA: 0x6CEE900
    }

    public class TriggerEvent`1
    {
        // ── Methods ──
        public void LogError(){} // RVA: 0x24B10
        public void SetResult(){} // RVA: 0x283FA0
        public void SetCanceled(){} // RVA: 0x24CC0
        public void SetCompleted(){} // RVA: 0x24A50
        public void SetError(){} // RVA: 0x24B10
        public void Add(){} // RVA: 0x24B10
        public void Remove(){} // RVA: 0x24B10
    }

    public class UniTask
    {
        // ── Methods ──
        public void ToCoroutine(){} // RVA: 0x6CEF040
        public void .ctor(){} // RVA: 0x2693AB0
        public void get_Status(){} // RVA: 0x6CEF080
        public void GetAwaiter(){} // RVA: 0x6CEF0E0
        public void SuppressCancellationThrow(){} // RVA: 0x6CEF140
        public void op_Implicit(){} // RVA: 0x6CEF310
        public void ToString(){} // RVA: 0x6CEF3B0
        public void Preserve(){} // RVA: 0x6CEF4A0
        public void AsAsyncUnitUniTask(){} // RVA: 0x6CEF5D0
        public void Yield(){} // RVA: 0x6CEF880 | overloaded x4
        public void NextFrame(){} // RVA: 0x6CEFC30 | overloaded x4
        public void WaitForEndOfFrame(){} // RVA: 0x6CEFEF0 | overloaded x4
        public void WaitForFixedUpdate(){} // RVA: 0x6CF0020 | overloaded x2
        public void WaitForSeconds(){} // RVA: 0x6CF0180 | overloaded x2
        public void DelayFrame(){} // RVA: 0x6CF0230
        public void Delay(){} // RVA: 0x6CF06E0 | overloaded x4
        public void FromException(){} // RVA: 0x283FA0 | overloaded x2
        public void FromResult(){} // RVA: 0x283FA0
        public void FromCanceled(){} // RVA: 0x283FA0 | overloaded x2
        public void Create(){} // RVA: 0x283FA0 | overloaded x4
        public void Lazy(){} // RVA: 0xCE50 | overloaded x2
        public void Void(){} // RVA: 0x283FA0 | overloaded x3
        public void Action(){} // RVA: 0x283FA0 | overloaded x3
        public void UnityAction(){} // RVA: 0x12930 | overloaded x11
        public void Defer(){} // RVA: 0x283FA0 | overloaded x4
        public void Never(){} // RVA: 0x283FA0 | overloaded x2
        public void Run(){} // RVA: 0x283FA0 | overloaded x8
        public void RunOnThreadPool(){} // RVA: 0x283FA0 | overloaded x8
        public void SwitchToMainThread(){} // RVA: 0x6CF2310 | overloaded x2
        public void ReturnToMainThread(){} // RVA: 0x6CF2310 | overloaded x2
        public void Post(){} // RVA: 0x6CF2370
        public void SwitchToThreadPool(){} // RVA: 0x2DD320
        public void SwitchToTaskPool(){} // RVA: 0x2DD320
        public void SwitchToSynchronizationContext(){} // RVA: 0x6CF23D0
        public void ReturnToSynchronizationContext(){} // RVA: 0x6CF2460
        public void ReturnToCurrentSynchronizationContext(){} // RVA: 0x6CF2490
        public void WaitUntil(){} // RVA: 0x283FA0 | overloaded x2
        public void WaitWhile(){} // RVA: 0x283FA0 | overloaded x2
        public void WaitUntilCanceled(){} // RVA: 0x6CF26D0
        public void WaitUntilValueChanged(){} // RVA: 0x283FA0
        public void WhenAll(){} // RVA: 0x283FA0 | overloaded x18
        public void WhenAny(){} // RVA: 0x283FA0 | overloaded x19
        public void WhenEach(){} // RVA: 0xCE50 | overloaded x2
        public void .cctor(){} // RVA: 0x6CF2D30
    }

    public class UniTaskAsyncEnumerableExtensions
    {
        // ── Methods ──
        public void WithCancellation(){} // RVA: 0x283FA0
    }

    public class UniTaskCancelableAsyncEnumerable`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){} // RVA: 0x283FA0
    }

    public class UniTaskCancellationExtensions
    {
        // ── Methods ──
        public void GetCancellationTokenOnDestroy(){} // RVA: 0x6CEEAB0 | overloaded x3
    }

    public class UniTaskCompletionSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void MarkHandled(){} // RVA: 0x6D000E0
        public void get_Task(){} // RVA: 0x6D000F0
        public void TrySetResult(){} // RVA: 0x6D00150
        public void TrySetCanceled(){} // RVA: 0x6D00160
        public void TrySetException(){} // RVA: 0x6D001D0
        public void GetResult(){} // RVA: 0x6D003D0
        public void GetStatus(){} // RVA: 0x37E080
        public void UnsafeGetStatus(){} // RVA: 0x37E080
        public void OnCompleted(){} // RVA: 0x6D004D0
        public void TrySignalCompletion(){} // RVA: 0x6D008F0
    }

    public class UniTaskCompletionSourceCoreShared
    {
        // ── Methods ──
        public void CompletionSentinel(){} // RVA: 0x6CFF500
        public void .cctor(){} // RVA: 0x6CFF550
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x44D8DA0
        public void ReportUnhandledError(){} // RVA: 0x44D8EE0
        public void MarkHandled(){} // RVA: 0x44B59B0
        public void TrySetResult(){} // RVA: 0x44D9030
        public void TrySetException(){} // RVA: 0x44D9130
        public void TrySetCanceled(){} // RVA: 0x44D93E0
        public void get_Version(){} // RVA: 0x1C0F720
        public void GetStatus(){} // RVA: 0x44D9520
        public void UnsafeGetStatus(){} // RVA: 0x44D9660
        public void GetResult(){} // RVA: 0x44B6050
        public void OnCompleted(){} // RVA: 0x44D9700
        public void ValidateToken(){} // RVA: 0x44B6410
    }

    public class UniTaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void MarkHandled(){} // RVA: 0x24A50
        public void get_Task(){} // RVA: 0x283FA0
        public void TrySetResult(){} // RVA: 0x283FA0
        public void TrySetCanceled(){} // RVA: 0x283FA0
        public void TrySetException(){} // RVA: 0xDE40
        public void GetResult(){} // RVA: 0x283FA0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
        public void GetStatus(){}
        public void UnsafeGetStatus(){} // RVA: 0xD840
        public void OnCompleted(){}
        public void TrySignalCompletion(){} // RVA: 0xE1F0
    }

    public class UniTaskExtensions
    {
        // ── Methods ──
        public void AsUniTask(){} // RVA: 0x6D00E40 | overloaded x2
        public void AsTask(){} // RVA: 0x6D010C0 | overloaded x2
        public void ToAsyncLazy(){} // RVA: 0x283FA0 | overloaded x2
        public void AttachExternalCancellation(){} // RVA: 0x283FA0 | overloaded x2
        public void ToCoroutine(){} // RVA: 0x6D017C0 | overloaded x2
        public void Timeout(){} // RVA: 0x283FA0 | overloaded x2
        public void TimeoutWithoutException(){} // RVA: 0x283FA0 | overloaded x2
        public void Forget(){} // RVA: 0x283FA0 | overloaded x4
        public void ForgetCoreWithCatch(){} // RVA: 0x283FA0 | overloaded x2
        public void ContinueWith(){} // RVA: 0x283FA0 | overloaded x8
        public void Unwrap(){} // RVA: 0x6D02D40 | overloaded x10
        public void GetAwaiter(){} // RVA: 0x6D082A0 | overloaded x32
    }

    public class UniTaskLoopRunners
    {
    }

    public class UniTaskObservableExtensions
    {
        // ── Methods ──
        public void ToUniTask(){} // RVA: 0x283FA0
        public void ToObservable(){} // RVA: 0x6D301B0 | overloaded x2
        public void Fire(){} // RVA: 0x6D306A0 | overloaded x2
    }

    public class UniTaskScheduler
    {
        // ── Methods ──
        public void add_UnobservedTaskException(){} // RVA: 0x6D30B90
        public void remove_UnobservedTaskException(){} // RVA: 0x6D30CF0
        public void InvokeUnobservedTaskException(){} // RVA: 0x6D30E50
        public void PublishUnobservedTaskException(){} // RVA: 0x6D30F20
        public void .cctor(){} // RVA: 0x6D312D0
    }

    public class UniTaskStatusExtensions
    {
        // ── Methods ──
        public void IsCompleted(){} // RVA: 0x5D7DAF0
        public void IsCompletedSuccessfully(){} // RVA: 0x19775B0
        public void IsCanceled(){} // RVA: 0x6CE7E60
        public void IsFaulted(){} // RVA: 0x6CE7E70
    }

    public class UniTaskSynchronizationContext
    {
        // ── Methods ──
        public void Send(){} // RVA: 0x3316790
        public void Post(){} // RVA: 0x6D313E0
        public void OperationStarted(){} // RVA: 0x6D31BB0
        public void OperationCompleted(){} // RVA: 0x6D31C10
        public void CreateCopy(){} // RVA: 0x1A3F520
        public void Run(){} // RVA: 0x6D31C70
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6D32080
    }

    public class UniTaskValueTaskExtensions
    {
        // ── Methods ──
        public void AsValueTask(){} // RVA: 0x283FA0 | overloaded x2
        public void AsUniTask(){} // RVA: 0x6CEEC40 | overloaded x2
    }

    public class UniTaskVoid
    {
        // ── Methods ──
        public void Forget(){} // RVA: 0x2DD310
    }

    public class UniTask`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
        public void get_Status(){} // RVA: 0xD840
        public void GetAwaiter(){} // RVA: 0x283FA0
        public void Preserve(){} // RVA: 0x283FA0
        public void AsUniTask(){} // RVA: 0xC770
        public void op_Implicit(){} // RVA: 0x283FA0 | overloaded x2
        public void SuppressCancellationThrow(){} // RVA: 0x283FA0
        public void ToString(){} // RVA: 0xCD60
    }

    public class UnityAsyncExtensions
    {
        // ── Methods ──
        public void AwaitForAllAssets(){} // RVA: 0x6D323A0 | overloaded x4
        public void GetAwaiter(){} // RVA: 0x6D33EE0 | overloaded x7
        public void WithCancellation(){} // RVA: 0x6D33980 | overloaded x12
        public void ToUniTask(){} // RVA: 0x6D340E0 | overloaded x7
        public void WaitAsync(){} // RVA: 0x6D33D60
        public void StartAsyncCoroutine(){} // RVA: 0x6D34210
        public void GetAsyncEventHandler(){} // RVA: 0x12930 | overloaded x2
        public void OnInvokeAsync(){} // RVA: 0x283FA0 | overloaded x2
        public void OnInvokeAsAsyncEnumerable(){} // RVA: 0x12930 | overloaded x2
        public void GetAsyncClickEventHandler(){} // RVA: 0x6D34490 | overloaded x2
        public void OnClickAsync(){} // RVA: 0x6D345E0 | overloaded x2
        public void OnClickAsAsyncEnumerable(){} // RVA: 0x6D34720 | overloaded x2
        public void GetAsyncValueChangedEventHandler(){} // RVA: 0x6D36210 | overloaded x12
        public void OnValueChangedAsync(){} // RVA: 0x6D36390 | overloaded x12
        public void OnValueChangedAsAsyncEnumerable(){} // RVA: 0x6D36510 | overloaded x12
        public void GetAsyncEndEditEventHandler(){} // RVA: 0x6D35950 | overloaded x2
        public void OnEndEditAsync(){} // RVA: 0x6D35AE0 | overloaded x2
        public void OnEndEditAsAsyncEnumerable(){} // RVA: 0x6D35C70 | overloaded x2
    }

    public class UnityBindingExtensions
    {
        // ── Methods ──
        public void BindTo(){} // RVA: 0x283FA0 | overloaded x9
        public void BindToCore(){} // RVA: 0x283FA0 | overloaded x4
    }

    public class UnityEventHandlerAsyncEnumerable : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2EDB9E0
        public void GetAsyncEnumerator(){} // RVA: 0x6D40CF0
    }

    public class UnityEventHandlerAsyncEnumerable`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){}
    }

    public class UnityWebRequestException
    {
        // ── Methods ──
        public void get_UnityWebRequest(){} // RVA: 0x796DE0
        public void get_Result(){} // RVA: 0x1D76570
        public void get_Error(){} // RVA: 0xA085E0
        public void get_Text(){} // RVA: 0xA1C130
        public void get_ResponseCode(){} // RVA: 0x348040
        public void get_ResponseHeaders(){} // RVA: 0x3480B0
        public void .ctor(){} // RVA: 0x6D431A0
        public void get_Message(){} // RVA: 0x6D43480
    }

    public class WhenEachEnumerable`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void GetAsyncEnumerator(){}
    }

    public class WhenEachResult`1
    {
        public object Current;
        public object System.Collections.IEnumerator.Current;

        // ── Methods ──
        public void get_Result(){} // RVA: 0x283FA0
        public void get_Exception(){} // RVA: 0xCD60
        public void get_IsCompletedSuccessfully(){} // RVA: 0xDBE0
        public void get_IsFaulted(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
        public void TryThrow(){} // RVA: 0x24A50
        public void GetResult(){} // RVA: 0x283FA0
        public void ToString(){} // RVA: 0xCD60
    }

    public class YieldAwaitable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x833580
        public void GetAwaiter(){} // RVA: 0x19689B0
        public void ToUniTask(){} // RVA: 0x6CFD930
    }

}