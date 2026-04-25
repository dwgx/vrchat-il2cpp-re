// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 81
// Methods: 726

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class AsyncInstantiateOperationExtensions : Object
    {
        // ── Methods ──
        public void WithCancellation(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void ToUniTask(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    }

    public class AsyncLazy : Object
    {
        public object Task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5489B1B0 | overloaded x2
        public void get_Task(){} // RVA: 0x7FFD5489B540
        public void GetAwaiter(){} // RVA: 0x7FFD5489B5F0
        public void EnsureInitialized(){} // RVA: 0x7FFD5489B760
        public void EnsureInitializedCore(){} // RVA: 0x7FFD5489B790
        public void SetCompletionSource(){} // RVA: 0x7FFD5489BB60 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD5489BD00
    }

    public class AsyncLazy`1 : Object
    {
        public object Task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void get_Task(){} // RVA: 0x7FFD4E2ADC40
        public void GetAwaiter(){} // RVA: 0x7FFD4E2ADC40
        public void EnsureInitialized(){} // RVA: 0x7FFD4E090980
        public void EnsureInitializedCore(){} // RVA: 0x7FFD4E090980
        public void SetCompletionSource(){} // RVA: 0x7FFD4E090A10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class AsyncReactiveProperty`1 : Object
    {
        public object Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
        public void set_Value(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void WithoutCurrent(){} // RVA: 0x7FFD4E078E90
        public void GetAsyncEnumerator(){}
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void WaitAsync(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class AsyncUnit : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD4E919180
        public void Equals(){} // RVA: 0x7FFD4E426850
        public void ToString(){} // RVA: 0x7FFD5489BDE0
        public void .cctor(){} // RVA: 0x7FFD4E341310
    }

    public class AsyncUnityEventHandler`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void OnInvokeAsync(){} // RVA: 0x7FFD4E2ADC40
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
        public void CancellationCallback(){} // RVA: 0x7FFD4E090A10
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Cysharp.Threading.Tasks.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.IAsyncEndEditEventHandler<T>.OnEndEditAsync(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.IAsyncEndTextSelectionEventHandler<T>.OnEndTextSelectionAsync(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.IAsyncTextSelectionEventHandler<T>.OnTextSelectionAsync(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.IAsyncDeselectEventHandler<T>.OnDeselectAsync(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.IAsyncSelectEventHandler<T>.OnSelectAsync(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.IAsyncSubmitEventHandler<T>.OnSubmitAsync(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){}
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){}
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class AutoResetUniTaskCompletionSource : Object
    {
        public object NextNode;
        public object Task;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
        public void .cctor(){} // RVA: 0x7FFD548B7D90
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Create(){} // RVA: 0x7FFD548B7F10
        public void CreateFromCanceled(){} // RVA: 0x7FFD548B7FD0
        public void CreateFromException(){} // RVA: 0x7FFD548B80B0
        public void CreateCompleted(){} // RVA: 0x7FFD548B8190
        public void get_Task(){} // RVA: 0x7FFD548B8220
        public void TrySetResult(){} // RVA: 0x7FFD548B82C0
        public void TrySetCanceled(){} // RVA: 0x7FFD548B8360
        public void TrySetException(){} // RVA: 0x7FFD548B83D0
        public void GetResult(){} // RVA: 0x7FFD548B8450
        public void GetStatus(){} // RVA: 0x7FFD548B8580
        public void UnsafeGetStatus(){} // RVA: 0x7FFD548B85D0
        public void OnCompleted(){} // RVA: 0x7FFD548B8610
        public void TryReturn(){} // RVA: 0x7FFD548B8690
    }

    public class AutoResetUniTaskCompletionSource`1 : Object
    {
        public object NextNode;
        public object Task;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFD4E078E90
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Create(){} // RVA: 0x7FFD4E078A90
        public void CreateFromCanceled(){} // RVA: 0x7FFD4E2ADC40
        public void CreateFromException(){} // RVA: 0x7FFD4E078FF0
        public void CreateFromResult(){} // RVA: 0x7FFD4E2ADC40
        public void get_Task(){} // RVA: 0x7FFD4E2ADC40
        public void TrySetResult(){} // RVA: 0x7FFD4E2ADC40
        public void TrySetCanceled(){} // RVA: 0x7FFD4E2ADC40
        public void TrySetException(){} // RVA: 0x7FFD4E079F60
        public void GetResult(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
        public void GetStatus(){}
        public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
        public void OnCompleted(){}
        public void TryReturn(){} // RVA: 0x7FFD4E079D00
    }

    public class AwaiterActions : Object
    {
        // ── Methods ──
        public void Continuation(){} // RVA: 0x7FFD548B5F40
        public void .cctor(){} // RVA: 0x7FFD548B5FB0
    }

    public class CancellationTokenEqualityComparer : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD5489BE20
        public void GetHashCode(){} // RVA: 0x7FFD5489BE80
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD5489BF40
    }

    public class CancellationTokenExtensions : Object
    {
        // ── Methods ──
        public void ToCancellationToken(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void ToCancellationTokenCore(){} // RVA: 0x7FFD5489C220
        public void ToUniTask(){} // RVA: 0x7FFD5489C3B0
        public void Callback(){} // RVA: 0x7FFD5489C760
        public void WaitUntilCanceled(){} // RVA: 0x7FFD4ECF6FB0
        public void RegisterWithoutCaptureExecutionContext(){} // RVA: 0x7FFD5489CA20 | overloaded x2
        public void AddTo(){} // RVA: 0x7FFD5489CBE0
        public void DisposeCallback(){} // RVA: 0x7FFD5489CC80
        public void .cctor(){} // RVA: 0x7FFD5489CD20
    }

    public class CancellationTokenSourceExtensions : Object
    {
        // ── Methods ──
        public void CancelCancellationTokenSourceState(){} // RVA: 0x7FFD5489D360
        public void CancelAfterSlim(){} // RVA: 0x7FFD5489D5B0 | overloaded x2
        public void RegisterRaiseCancelOnDestroy(){} // RVA: 0x7FFD5489D860 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD5489D9B0
    }

    public class Channel : Object
    {
        // ── Methods ──
        public void CreateSingleConsumerUnbounded(){} // RVA: 0x7FFD4E078A90
    }

    public class ChannelReader`1 : Object
    {
        public object Completion;

        // ── Methods ──
        public void TryRead(){} // RVA: 0x7FFD4E079F60
        public void WaitToReadAsync(){}
        public void get_Completion(){} // RVA: 0x7FFD4E0788A0
        public void ReadAsync(){} // RVA: 0x7FFD4E2ADC40
        public void ReadAsyncCore(){} // RVA: 0x7FFD4E2ADC40
        public void ReadAllAsync(){}
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryWrite(){} // RVA: 0x7FFD4E2ADC40
        public void TryComplete(){} // RVA: 0x7FFD4E079F60
        public void Complete(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class Channel`2 : Object
    {
        public object Reader;
        public object Writer;

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7FFD4E35C380
        public void set_Reader(){} // RVA: 0x7FFD4E342E30
        public void get_Writer(){} // RVA: 0x7FFD4E3447C0
        public void set_Writer(){} // RVA: 0x7FFD4E3A7E80
        public void op_Implicit(){} // RVA: 0x7FFD5321F590 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class EnumerableAsyncExtensions : Object
    {
        // ── Methods ──
        public void Select(){} // RVA: 0x7FFD4E078FF0 | overloaded x4
    }

    public class EnumeratorAsyncExtensions : Object
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7FFD4E2ADC40
        public void WithCancellation(){} // RVA: 0x7FFD5489DB40
        public void ToUniTask(){} // RVA: 0x7FFD5489DD70 | overloaded x2
        public void Core(){} // RVA: 0x7FFD5489DFD0
    }

    public class ExceptionExtensions : Object
    {
        // ── Methods ──
        public void IsOperationCanceledException(){} // RVA: 0x7FFD5489F7A0
    }

    public class IAsyncDeselectEventHandler`1
    {
        // ── Methods ──
        public void OnDeselectAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IAsyncEndEditEventHandler`1
    {
        // ── Methods ──
        public void OnEndEditAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IAsyncEndTextSelectionEventHandler`1
    {
        // ── Methods ──
        public void OnEndTextSelectionAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IAsyncReactiveProperty`1
    {
        public object Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
        public void set_Value(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IAsyncSelectEventHandler`1
    {
        // ── Methods ──
        public void OnSelectAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IAsyncSubmitEventHandler`1
    {
        // ── Methods ──
        public void OnSubmitAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IAsyncTextSelectionEventHandler`1
    {
        // ── Methods ──
        public void OnTextSelectionAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IAsyncValueChangedEventHandler`1
    {
        // ── Methods ──
        public void OnValueChangedAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ICancelPromise
    {
        // ── Methods ──
        public void TrySetCanceled(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IConnectableUniTaskAsyncEnumerable`1
    {
        // ── Methods ──
        public void Connect(){} // RVA: 0x7FFD4E078E90
    }

    public class IPlayerLoopItem
    {
        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4E079D00
    }

    public class IPromise
    {
    }

    public class IPromise`1
    {
    }

    public class IReadOnlyAsyncReactiveProperty`1
    {
        public object Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
        public void WithoutCurrent(){} // RVA: 0x7FFD4E078E90
        public void WaitAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IRejectPromise
    {
        // ── Methods ──
        public void TrySetException(){} // RVA: 0x7FFD4E079F60
    }

    public class IResolvePromise
    {
        // ── Methods ──
        public void TrySetResult(){} // RVA: 0x7FFD4E079D00
    }

    public class IResolvePromise`1
    {
        // ── Methods ──
        public void TrySetResult(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ITaskPoolNode`1
    {
        public object NextNode;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFD4E078E90
    }

    public class ITriggerHandler`1
    {
        public object Prev;
        public object Next;

        // ── Methods ──
        public void OnNext(){} // RVA: 0x7FFD4E2ADC40
        public void OnError(){} // RVA: 0x7FFD4E090A40
        public void OnCompleted(){} // RVA: 0x7FFD4E090980
        public void OnCanceled(){} // RVA: 0x7FFD4E090BF0
        public void get_Prev(){} // RVA: 0x7FFD4E078E90
        public void set_Prev(){} // RVA: 0x7FFD4E090A40
        public void get_Next(){} // RVA: 0x7FFD4E078E90
        public void set_Next(){} // RVA: 0x7FFD4E090A40
    }

    public class IUniTaskAsyncEnumerable`1
    {
        // ── Methods ──
        public void GetAsyncEnumerator(){}
    }

    public class IUniTaskAsyncEnumerator`1
    {
        public object Current;

        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFD4E2ADC40
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
        public void GetResult(){} // RVA: 0x7FFD4E090B70
        public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetStatus(){} // RVA: 0x7FFD548A0490
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7FFD548A04E0
        public void System.Threading.Tasks.Sources.IValueTaskSource.OnCompleted(){} // RVA: 0x7FFD548A0540
    }

    public class IUniTaskSource`1
    {
        // ── Methods ──
        public void GetResult(){} // RVA: 0x7FFD4E2ADC40
        public void GetStatus(){}
        public void OnCompleted(){}
        public void System.Threading.Tasks.Sources.IValueTaskSource<T>.GetStatus(){}
        public void System.Threading.Tasks.Sources.IValueTaskSource<T>.GetResult(){} // RVA: 0x7FFD4E2ADC40
        public void System.Threading.Tasks.Sources.IValueTaskSource<T>.OnCompleted(){}
    }

    public class MoveNextSource : Object
    {
        // ── Methods ──
        public void GetResult(){} // RVA: 0x7FFD548A05E0
        public void GetStatus(){} // RVA: 0x7FFD548A0630
        public void OnCompleted(){} // RVA: 0x7FFD548A0680
        public void UnsafeGetStatus(){} // RVA: 0x7FFD548A0700
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD548A0740
        public void TryGetResult(){} // RVA: 0x7FFD548A0790 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class PlayerLoopHelper : Object
    {
        public object UnitySynchronizationContext;
        public object MainThreadId;
        public object ApplicationDataPath;
        public object IsMainThread;
        public object IsEditorApplicationQuitting;

        // ── Methods ──
        public void get_UnitySynchronizationContext(){} // RVA: 0x7FFD548A0810
        public void get_MainThreadId(){} // RVA: 0x7FFD548A0870
        public void get_ApplicationDataPath(){} // RVA: 0x7FFD548A08D0
        public void get_IsMainThread(){} // RVA: 0x7FFD548A0930
        public void get_IsEditorApplicationQuitting(){} // RVA: 0x7FFD548A09F0
        public void set_IsEditorApplicationQuitting(){} // RVA: 0x7FFD548A0A50
        public void InsertRunner(){} // RVA: 0x7FFD548A0AB0
        public void RemoveRunner(){} // RVA: 0x7FFD548A1010
        public void InsertUniTaskSynchronizationContext(){} // RVA: 0x7FFD548A1230
        public void Init(){} // RVA: 0x7FFD548A1920
        public void FindLoopSystemIndex(){} // RVA: 0x7FFD548A1C20
        public void InsertLoop(){} // RVA: 0x7FFD548A1D30
        public void Initialize(){} // RVA: 0x7FFD548A2180
        public void AddAction(){} // RVA: 0x7FFD548A3D40
        public void ThrowInvalidLoopTiming(){} // RVA: 0x7FFD548A3DE0
        public void AddContinuation(){} // RVA: 0x7FFD548A3E80
        public void DumpCurrentPlayerLoop(){} // RVA: 0x7FFD548A3F20
        public void IsInjectedUniTaskPlayerLoop(){} // RVA: 0x7FFD548A43B0
        public void .cctor(){} // RVA: 0x7FFD548A4570
    }

    public class PlayerLoopTimer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD548A4A40
        public void Create(){} // RVA: 0x7FFD548A4B50
        public void StartNew(){} // RVA: 0x7FFD548A4CE0
        public void Restart(){} // RVA: 0x7FFD548A4EE0 | overloaded x2
        public void Stop(){} // RVA: 0x7FFD548A4FE0
        public void ResetCore(){}
        public void Dispose(){} // RVA: 0x7FFD548A4FF0
        public void Cysharp.Threading.Tasks.IPlayerLoopItem.MoveNext(){} // RVA: 0x7FFD548A5000
        public void MoveNextCore(){} // RVA: 0x7FFD4E079D00
    }

    public class Progress : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E078F80
        public void CreateOnlyValueChanged(){} // RVA: 0x7FFD4E078FF0
    }

    public class ReadOnlyAsyncReactiveProperty`1 : Object
    {
        public object Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ConsumeEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void WithoutCurrent(){} // RVA: 0x7FFD4E078E90
        public void GetAsyncEnumerator(){}
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void WaitAsync(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class StateExtensions : Object
    {
        // ── Methods ──
        public void ToReadOnlyAsyncReactiveProperty(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    }

    public class SwitchToMainThreadAwaitable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD515124C0
        public void GetAwaiter(){} // RVA: 0x7FFD548B67F0
    }

    public class SwitchToThreadPoolAwaitable : ValueType
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7FFD4E341320
    }

    public class TaskPool : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD548A58B0
        public void SetMaxPoolSize(){} // RVA: 0x7FFD548A5AA0
        public void GetCacheSizeInfo(){} // RVA: 0x7FFD548A5B00
        public void RegisterSizeGetter(){} // RVA: 0x7FFD548A5B50
    }

    public class TaskPool`1 : ValueType
    {
        public object Size;

        // ── Methods ──
        public void get_Size(){} // RVA: 0x7FFD4F8402A0
        public void TryPop(){} // RVA: 0x7FFD51B48040
        public void TryPush(){} // RVA: 0x7FFD51EF38E0
    }

    public class TaskTracker : Object
    {
        // ── Methods ──
        public void TrackActiveTask(){} // RVA: 0x7FFD4E341310
        public void RemoveTracking(){} // RVA: 0x7FFD4E341310
        public void CheckAndResetDirty(){} // RVA: 0x7FFD5489F830
        public void ForEachActiveTask(){} // RVA: 0x7FFD5489F890
        public void TypeBeautify(){} // RVA: 0x7FFD5489FEF0
        public void .cctor(){} // RVA: 0x7FFD548A0200
    }

    public class TextMeshProAsyncExtensions : Object
    {
        // ── Methods ──
        public void BindTo(){} // RVA: 0x7FFD4E099CB0 | overloaded x5
        public void BindToCore(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetAsyncValueChangedEventHandler(){} // RVA: 0x7FFD548E5120 | overloaded x2
        public void OnValueChangedAsync(){} // RVA: 0x7FFD548E52B0 | overloaded x2
        public void OnValueChangedAsAsyncEnumerable(){} // RVA: 0x7FFD548E5440 | overloaded x2
        public void GetAsyncEndEditEventHandler(){} // RVA: 0x7FFD548E5580 | overloaded x2
        public void OnEndEditAsync(){} // RVA: 0x7FFD548E5710 | overloaded x2
        public void OnEndEditAsAsyncEnumerable(){} // RVA: 0x7FFD548E58A0 | overloaded x2
        public void GetAsyncEndTextSelectionEventHandler(){} // RVA: 0x7FFD548E5A10 | overloaded x2
        public void OnEndTextSelectionAsync(){} // RVA: 0x7FFD548E5C00 | overloaded x2
        public void OnEndTextSelectionAsAsyncEnumerable(){} // RVA: 0x7FFD548E5DF0 | overloaded x2
        public void GetAsyncTextSelectionEventHandler(){} // RVA: 0x7FFD548E5F90 | overloaded x2
        public void OnTextSelectionAsync(){} // RVA: 0x7FFD548E6180 | overloaded x2
        public void OnTextSelectionAsAsyncEnumerable(){} // RVA: 0x7FFD548E6370 | overloaded x2
        public void GetAsyncDeselectEventHandler(){} // RVA: 0x7FFD548E64E0 | overloaded x2
        public void OnDeselectAsync(){} // RVA: 0x7FFD548E6670 | overloaded x2
        public void OnDeselectAsAsyncEnumerable(){} // RVA: 0x7FFD548E6800 | overloaded x2
        public void GetAsyncSelectEventHandler(){} // RVA: 0x7FFD548E6940 | overloaded x2
        public void OnSelectAsync(){} // RVA: 0x7FFD548E6AD0 | overloaded x2
        public void OnSelectAsAsyncEnumerable(){} // RVA: 0x7FFD548E6C60 | overloaded x2
        public void GetAsyncSubmitEventHandler(){} // RVA: 0x7FFD548E6DA0 | overloaded x2
        public void OnSubmitAsync(){} // RVA: 0x7FFD548E6F30 | overloaded x2
        public void OnSubmitAsAsyncEnumerable(){} // RVA: 0x7FFD548E70C0 | overloaded x2
    }

    public class TimeoutController : Object
    {
        // ── Methods ──
        public void CancelCancellationTokenSourceState(){} // RVA: 0x7FFD548A65E0
        public void .ctor(){} // RVA: 0x7FFD548A6810 | overloaded x2
        public void Timeout(){} // RVA: 0x7FFD548A6AA0 | overloaded x2
        public void IsTimeout(){} // RVA: 0x7FFD548A6F10
        public void Reset(){} // RVA: 0x7FFD548A6F40
        public void Dispose(){} // RVA: 0x7FFD548A6F50
        public void .cctor(){} // RVA: 0x7FFD548A7060
    }

    public class TriggerEvent`1 : ValueType
    {
        // ── Methods ──
        public void LogError(){} // RVA: 0x7FFD4E090A40
        public void SetResult(){} // RVA: 0x7FFD4E2ADC40
        public void SetCanceled(){} // RVA: 0x7FFD4E090BF0
        public void SetCompleted(){} // RVA: 0x7FFD4E090980
        public void SetError(){} // RVA: 0x7FFD4E090A40
        public void Add(){} // RVA: 0x7FFD4E090A40
        public void Remove(){} // RVA: 0x7FFD4E090A40
    }

    public class UniTask : ValueType
    {
        public object Status;

        // ── Methods ──
        public void ToCoroutine(){} // RVA: 0x7FFD548A77A0
        public void .ctor(){} // RVA: 0x7FFD50542C00
        public void get_Status(){} // RVA: 0x7FFD548A77E0
        public void GetAwaiter(){} // RVA: 0x7FFD548A7840
        public void SuppressCancellationThrow(){} // RVA: 0x7FFD548A78A0
        public void op_Implicit(){} // RVA: 0x7FFD548A7A70
        public void ToString(){} // RVA: 0x7FFD548A7B10
        public void Preserve(){} // RVA: 0x7FFD548A7C00
        public void AsAsyncUnitUniTask(){} // RVA: 0x7FFD548A7D30
        public void Yield(){} // RVA: 0x7FFD548A7FE0 | overloaded x4
        public void NextFrame(){} // RVA: 0x7FFD548A8390 | overloaded x4
        public void WaitForEndOfFrame(){} // RVA: 0x7FFD548A8650 | overloaded x4
        public void WaitForFixedUpdate(){} // RVA: 0x7FFD548A8780 | overloaded x2
        public void WaitForSeconds(){} // RVA: 0x7FFD548A88E0 | overloaded x2
        public void DelayFrame(){} // RVA: 0x7FFD548A8990
        public void Delay(){} // RVA: 0x7FFD548A8E40 | overloaded x4
        public void FromException(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void FromResult(){} // RVA: 0x7FFD4E2ADC40
        public void FromCanceled(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Create(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void Lazy(){} // RVA: 0x7FFD4E078F80 | overloaded x2
        public void Void(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void Action(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void UnityAction(){} // RVA: 0x7FFD4E07EA50 | overloaded x11
        public void Defer(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void Never(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Run(){} // RVA: 0x7FFD4E2ADC40 | overloaded x8
        public void RunOnThreadPool(){} // RVA: 0x7FFD4E2ADC40 | overloaded x8
        public void SwitchToMainThread(){} // RVA: 0x7FFD548AAA70 | overloaded x2
        public void ReturnToMainThread(){} // RVA: 0x7FFD548AAA70 | overloaded x2
        public void Post(){} // RVA: 0x7FFD548AAAD0
        public void SwitchToThreadPool(){} // RVA: 0x7FFD4E341320
        public void SwitchToTaskPool(){} // RVA: 0x7FFD4E341320
        public void SwitchToSynchronizationContext(){} // RVA: 0x7FFD548AAB30
        public void ReturnToSynchronizationContext(){} // RVA: 0x7FFD548AABC0
        public void ReturnToCurrentSynchronizationContext(){} // RVA: 0x7FFD548AABF0
        public void WaitUntil(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void WaitWhile(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void WaitUntilCanceled(){} // RVA: 0x7FFD548AAE30
        public void WaitUntilValueChanged(){} // RVA: 0x7FFD4E2ADC40
        public void WhenAll(){} // RVA: 0x7FFD4E2ADC40 | overloaded x18
        public void WhenAny(){} // RVA: 0x7FFD4E2ADC40 | overloaded x19
        public void WhenEach(){} // RVA: 0x7FFD4E078F80 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD548AB490
    }

    public class UniTaskAsyncEnumerableExtensions : Object
    {
        // ── Methods ──
        public void WithCancellation(){} // RVA: 0x7FFD4E2ADC40
    }

    public class UniTaskCancelableAsyncEnumerable`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){} // RVA: 0x7FFD4E2ADC40
    }

    public class UniTaskCompletionSource : Object
    {
        public object Task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void MarkHandled(){} // RVA: 0x7FFD548B8840
        public void get_Task(){} // RVA: 0x7FFD548B8850
        public void TrySetResult(){} // RVA: 0x7FFD548B88B0
        public void TrySetCanceled(){} // RVA: 0x7FFD548B88C0
        public void TrySetException(){} // RVA: 0x7FFD548B8930
        public void GetResult(){} // RVA: 0x7FFD548B8B30
        public void GetStatus(){} // RVA: 0x7FFD4E3E2080
        public void UnsafeGetStatus(){} // RVA: 0x7FFD4E3E2080
        public void OnCompleted(){} // RVA: 0x7FFD548B8C30
        public void TrySignalCompletion(){} // RVA: 0x7FFD548B9050
    }

    public class UniTaskCompletionSourceCoreShared : Object
    {
        // ── Methods ──
        public void CompletionSentinel(){} // RVA: 0x7FFD548B7C60
        public void .cctor(){} // RVA: 0x7FFD548B7CB0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object Version;

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD521B9730
        public void ReportUnhandledError(){} // RVA: 0x7FFD521B9870
        public void MarkHandled(){} // RVA: 0x7FFD5218A2C0
        public void TrySetResult(){} // RVA: 0x7FFD521B99C0
        public void TrySetException(){} // RVA: 0x7FFD521B9AC0
        public void TrySetCanceled(){} // RVA: 0x7FFD521B9D70
        public void get_Version(){} // RVA: 0x7FFD4FABAEC0
        public void GetStatus(){} // RVA: 0x7FFD521B9EB0
        public void UnsafeGetStatus(){} // RVA: 0x7FFD521B9FF0
        public void GetResult(){} // RVA: 0x7FFD5218A960
        public void OnCompleted(){} // RVA: 0x7FFD521BA090
        public void ValidateToken(){} // RVA: 0x7FFD5218AD20
    }

    public class UniTaskCompletionSource`1 : Object
    {
        public object Task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void MarkHandled(){} // RVA: 0x7FFD4E090980
        public void get_Task(){} // RVA: 0x7FFD4E2ADC40
        public void TrySetResult(){} // RVA: 0x7FFD4E2ADC40
        public void TrySetCanceled(){} // RVA: 0x7FFD4E2ADC40
        public void TrySetException(){} // RVA: 0x7FFD4E079F60
        public void GetResult(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
        public void GetStatus(){}
        public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
        public void OnCompleted(){}
        public void TrySignalCompletion(){} // RVA: 0x7FFD4E07A310
    }

    public class UniTaskExtensions : Object
    {
        // ── Methods ──
        public void AsUniTask(){} // RVA: 0x7FFD548B95A0 | overloaded x2
        public void AsTask(){} // RVA: 0x7FFD548B9820 | overloaded x2
        public void ToAsyncLazy(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AttachExternalCancellation(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ToCoroutine(){} // RVA: 0x7FFD548B9F20 | overloaded x2
        public void Timeout(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void TimeoutWithoutException(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Forget(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void ForgetCoreWithCatch(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ContinueWith(){} // RVA: 0x7FFD4E2ADC40 | overloaded x8
        public void Unwrap(){} // RVA: 0x7FFD548BB4A0 | overloaded x10
        public void GetAwaiter(){} // RVA: 0x7FFD548C0A00 | overloaded x32
    }

    public class UniTaskLoopRunners : Object
    {
    }

    public class UniTaskObservableExtensions : Object
    {
        // ── Methods ──
        public void ToUniTask(){} // RVA: 0x7FFD4E2ADC40
        public void ToObservable(){} // RVA: 0x7FFD548E8910 | overloaded x2
        public void Fire(){} // RVA: 0x7FFD548E8E00 | overloaded x2
    }

    public class UniTaskScheduler : Object
    {
        // ── Methods ──
        public void add_UnobservedTaskException(){} // RVA: 0x7FFD548E92F0
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFD548E9450
        public void InvokeUnobservedTaskException(){} // RVA: 0x7FFD548E95B0
        public void PublishUnobservedTaskException(){} // RVA: 0x7FFD548E9680
        public void .cctor(){} // RVA: 0x7FFD548E9A30
    }

    public class UniTaskSynchronizationContext : SynchronizationContext
    {
        // ── Methods ──
        public void Send(){} // RVA: 0x7FFD5107C990
        public void Post(){} // RVA: 0x7FFD548E9B40
        public void OperationStarted(){} // RVA: 0x7FFD548EA310
        public void OperationCompleted(){} // RVA: 0x7FFD548EA370
        public void CreateCopy(){} // RVA: 0x7FFD4F9181E0
        public void Run(){} // RVA: 0x7FFD548EA3D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD548EA7E0
    }

    public class UniTaskValueTaskExtensions : Object
    {
        // ── Methods ──
        public void AsValueTask(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AsUniTask(){} // RVA: 0x7FFD548A73A0 | overloaded x2
    }

    public class UniTaskVoid : ValueType
    {
        // ── Methods ──
        public void Forget(){} // RVA: 0x7FFD4E341310
    }

    public class UniTask`1 : ValueType
    {
        public object Status;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void get_Status(){} // RVA: 0x7FFD4E079960
        public void GetAwaiter(){} // RVA: 0x7FFD4E2ADC40
        public void Preserve(){} // RVA: 0x7FFD4E2ADC40
        public void AsUniTask(){} // RVA: 0x7FFD4E0788A0
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SuppressCancellationThrow(){} // RVA: 0x7FFD4E2ADC40
        public void ToString(){} // RVA: 0x7FFD4E078E90
    }

    public class UnityAsyncExtensions : Object
    {
        // ── Methods ──
        public void AwaitForAllAssets(){} // RVA: 0x7FFD548EAB00 | overloaded x4
        public void GetAwaiter(){} // RVA: 0x7FFD548EC640 | overloaded x7
        public void WithCancellation(){} // RVA: 0x7FFD548EC0E0 | overloaded x12
        public void ToUniTask(){} // RVA: 0x7FFD548EC840 | overloaded x7
        public void WaitAsync(){} // RVA: 0x7FFD548EC4C0
        public void StartAsyncCoroutine(){} // RVA: 0x7FFD548EC970
        public void GetAsyncEventHandler(){} // RVA: 0x7FFD4E07EA50 | overloaded x2
        public void OnInvokeAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void OnInvokeAsAsyncEnumerable(){} // RVA: 0x7FFD4E07EA50 | overloaded x2
        public void GetAsyncClickEventHandler(){} // RVA: 0x7FFD548ECBF0 | overloaded x2
        public void OnClickAsync(){} // RVA: 0x7FFD548ECD40 | overloaded x2
        public void OnClickAsAsyncEnumerable(){} // RVA: 0x7FFD548ECE80 | overloaded x2
        public void GetAsyncValueChangedEventHandler(){} // RVA: 0x7FFD548EE970 | overloaded x12
        public void OnValueChangedAsync(){} // RVA: 0x7FFD548EEAF0 | overloaded x12
        public void OnValueChangedAsAsyncEnumerable(){} // RVA: 0x7FFD548EEC70 | overloaded x12
        public void GetAsyncEndEditEventHandler(){} // RVA: 0x7FFD548EE0B0 | overloaded x2
        public void OnEndEditAsync(){} // RVA: 0x7FFD548EE240 | overloaded x2
        public void OnEndEditAsAsyncEnumerable(){} // RVA: 0x7FFD548EE3D0 | overloaded x2
    }

    public class UnityBindingExtensions : Object
    {
        // ── Methods ──
        public void BindTo(){} // RVA: 0x7FFD4E2ADC40 | overloaded x9
        public void BindToCore(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
    }

    public class UnityEventHandlerAsyncEnumerable`1 : Object
    {
        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){}
    }

    public class UnityWebRequestException : Exception
    {
        public object UnityWebRequest;
        public object Result;
        public object Error;
        public object Text;
        public object ResponseCode;
        public object ResponseHeaders;
        public object Message;

        // ── Methods ──
        public void get_UnityWebRequest(){} // RVA: 0x7FFD4E70F640
        public void get_Result(){} // RVA: 0x7FFD4FCBE530
        public void get_Error(){} // RVA: 0x7FFD4E963900
        public void get_Text(){} // RVA: 0x7FFD4E96B1A0
        public void get_ResponseCode(){} // RVA: 0x7FFD4E3AC040
        public void get_ResponseHeaders(){} // RVA: 0x7FFD4E3AC0B0
        public void .ctor(){} // RVA: 0x7FFD548FB900
        public void get_Message(){} // RVA: 0x7FFD548FBBE0
    }

    public class WhenEachEnumerable`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetAsyncEnumerator(){}
    }

    public class WhenEachResult`1 : ValueType
    {
        public object Result;
        public object Exception;
        public object IsCompletedSuccessfully;
        public object IsFaulted;

        // ── Methods ──
        public void get_Result(){} // RVA: 0x7FFD4E2ADC40
        public void get_Exception(){} // RVA: 0x7FFD4E078E90
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7FFD4E079D00
        public void get_IsFaulted(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void TryThrow(){} // RVA: 0x7FFD4E090980
        public void GetResult(){} // RVA: 0x7FFD4E2ADC40
        public void ToString(){} // RVA: 0x7FFD4E078E90
    }

    public class YieldAwaitable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E78D8B0
        public void GetAwaiter(){} // RVA: 0x7FFD4F840210
        public void ToUniTask(){} // RVA: 0x7FFD548B6090
    }

}