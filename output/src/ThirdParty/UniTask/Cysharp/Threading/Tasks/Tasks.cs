// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 99
// Methods: 749

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class AsyncInstantiateOperationExtensions : Object
    {
        // ── Methods ──
        public void WithCancellation(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void ToUniTask(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

    public class AsyncLazy : Object
    {
        public System.Action`1<object> continuation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE878238F0 | overloaded x2
        public void get_Task(){} // RVA: 0x7FFE87823C80
        public void GetAwaiter(){} // RVA: 0x7FFE87823D30
        public void EnsureInitialized(){} // RVA: 0x7FFE87823EA0
        public void EnsureInitializedCore(){} // RVA: 0x7FFE87823ED0
        public void SetCompletionSource(){} // RVA: 0x7FFE878242A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87824440
    }

    public class AsyncLazy`1 : Object
    {
        public System.Action`1<object> continuation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void get_Task(){} // RVA: 0x7FFE810A1420
        public void GetAwaiter(){} // RVA: 0x7FFE810A1420
        public void EnsureInitialized(){} // RVA: 0x7FFE80E45FE0
        public void EnsureInitializedCore(){} // RVA: 0x7FFE80E45FE0
        public void SetCompletionSource(){} // RVA: 0x7FFE80E46070 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class AsyncReactiveProperty`1 : Object
    {
        public Cysharp.Threading.Tasks.TriggerEvent`1<T> triggerEvent;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE810A1420
        public void set_Value(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void WithoutCurrent(){} // RVA: 0x7FFE80E2E2E0
        public void GetAsyncEnumerator(){}
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void op_Implicit(){} // RVA: 0x7FFE810A1420
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void WaitAsync(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class AsyncUnit : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE813240E0
        public void Equals(){} // RVA: 0x7FFE811E0850
        public void ToString(){} // RVA: 0x7FFE87824520
        public void .cctor(){} // RVA: 0x7FFE810FB310
    }

    public class AsyncUnityEventHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87881340
        public void OnInvokeAsync(){} // RVA: 0x7FFE87881630
        public void Invoke(){} // RVA: 0x7FFE87881720
        public void CancellationCallback(){} // RVA: 0x7FFE878817A0
        public void Dispose(){} // RVA: 0x7FFE87881820
        public void Cysharp.Threading.Tasks.IAsyncClickEventHandler.OnClickAsync(){} // RVA: 0x7FFE878818D0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE87881900
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){} // RVA: 0x7FFE878819A0
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7FFE878819F0
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){} // RVA: 0x7FFE87881A30
        public void .cctor(){} // RVA: 0x7FFE87881AB0
    }

    public class AsyncUnityEventHandler`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void OnInvokeAsync(){} // RVA: 0x7FFE810A1420
        public void Invoke(){} // RVA: 0x7FFE810A1420
        public void CancellationCallback(){} // RVA: 0x7FFE80E46070
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void Cysharp.Threading.Tasks.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync(){} // RVA: 0x7FFE810A1420
        public void Cysharp.Threading.Tasks.IAsyncEndEditEventHandler<T>.OnEndEditAsync(){} // RVA: 0x7FFE810A1420
        public void Cysharp.Threading.Tasks.IAsyncEndTextSelectionEventHandler<T>.OnEndTextSelectionAsync(){} // RVA: 0x7FFE810A1420
        public void Cysharp.Threading.Tasks.IAsyncTextSelectionEventHandler<T>.OnTextSelectionAsync(){} // RVA: 0x7FFE810A1420
        public void Cysharp.Threading.Tasks.IAsyncDeselectEventHandler<T>.OnDeselectAsync(){} // RVA: 0x7FFE810A1420
        public void Cysharp.Threading.Tasks.IAsyncSelectEventHandler<T>.OnSelectAsync(){} // RVA: 0x7FFE810A1420
        public void Cysharp.Threading.Tasks.IAsyncSubmitEventHandler<T>.OnSubmitAsync(){} // RVA: 0x7FFE810A1420
        public void Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(){} // RVA: 0x7FFE810A1420
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){}
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){}
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class AutoResetUniTaskCompletionSource : Object
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource> pool;
        public Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource nextNode; // 0x10

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFE84A67100
        public void .cctor(){} // RVA: 0x7FFE878404D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87840650
        public void CreateFromCanceled(){} // RVA: 0x7FFE87840710
        public void CreateFromException(){} // RVA: 0x7FFE878407F0
        public void CreateCompleted(){} // RVA: 0x7FFE878408D0
        public void get_Task(){} // RVA: 0x7FFE87840960
        public void TrySetResult(){} // RVA: 0x7FFE87840A00
        public void TrySetCanceled(){} // RVA: 0x7FFE87840AA0
        public void TrySetException(){} // RVA: 0x7FFE87840B10
        public void GetResult(){} // RVA: 0x7FFE87840B90
        public void GetStatus(){} // RVA: 0x7FFE87840CC0
        public void UnsafeGetStatus(){} // RVA: 0x7FFE87840D10
        public void OnCompleted(){} // RVA: 0x7FFE87840D50
        public void TryReturn(){} // RVA: 0x7FFE87840DD0
    }

    public class AutoResetUniTaskCompletionSource`1 : Object
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource`1<T>> pool;
        public Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource`1<T> nextNode;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFE80E2E2E0
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Create(){} // RVA: 0x7FFE80E2DEE0
        public void CreateFromCanceled(){} // RVA: 0x7FFE810A1420
        public void CreateFromException(){} // RVA: 0x7FFE80E2E440
        public void CreateFromResult(){} // RVA: 0x7FFE810A1420
        public void get_Task(){} // RVA: 0x7FFE810A1420
        public void TrySetResult(){} // RVA: 0x7FFE810A1420
        public void TrySetCanceled(){} // RVA: 0x7FFE810A1420
        public void TrySetException(){} // RVA: 0x7FFE80E2F3B0
        public void GetResult(){} // RVA: 0x7FFE810A1420
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
        public void GetStatus(){}
        public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
        public void OnCompleted(){}
        public void TryReturn(){} // RVA: 0x7FFE80E2F150
    }

    public class AwaiterActions : Object
    {
        // ── Methods ──
        public void Continuation(){} // RVA: 0x7FFE8783E680
        public void .cctor(){} // RVA: 0x7FFE8783E6F0
    }

    public class CancellationTokenAwaitable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void GetAwaiter(){} // RVA: 0x7FFE87825930
    }

    public class CancellationTokenEqualityComparer : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87824560
        public void GetHashCode(){} // RVA: 0x7FFE878245C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87824680
    }

    public class CancellationTokenExtensions : Object
    {
        // ── Methods ──
        public void ToCancellationToken(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void ToCancellationTokenCore(){} // RVA: 0x7FFE87824960
        public void ToUniTask(){} // RVA: 0x7FFE87824AF0
        public void Callback(){} // RVA: 0x7FFE87824EA0
        public void WaitUntilCanceled(){} // RVA: 0x7FFE81D7BAB0
        public void RegisterWithoutCaptureExecutionContext(){} // RVA: 0x7FFE87825160 | overloaded x2
        public void AddTo(){} // RVA: 0x7FFE87825320
        public void DisposeCallback(){} // RVA: 0x7FFE878253C0
        public void .cctor(){} // RVA: 0x7FFE87825460
    }

    public class CancellationTokenSourceExtensions : Object
    {
        // ── Methods ──
        public void CancelCancellationTokenSourceState(){} // RVA: 0x7FFE87825AA0
        public void CancelAfterSlim(){} // RVA: 0x7FFE87825CF0 | overloaded x2
        public void RegisterRaiseCancelOnDestroy(){} // RVA: 0x7FFE87825FA0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE878260F0
    }

    public class Channel : Object
    {
        // ── Methods ──
        public void CreateSingleConsumerUnbounded(){} // RVA: 0x7FFE80E2DEE0
    }

    public class ChannelClosedException : InvalidOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869DC010 | overloaded x4
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x7FFE80E2F3B0
        public void WaitToReadAsync(){}
        public void get_Completion(){} // RVA: 0x7FFE80E2DCF0
        public void ReadAsync(){} // RVA: 0x7FFE810A1420
        public void ReadAsyncCore(){} // RVA: 0x7FFE810A1420
        public void ReadAllAsync(){}
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryWrite(){} // RVA: 0x7FFE810A1420
        public void TryComplete(){} // RVA: 0x7FFE80E2F3B0
        public void Complete(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class Channel`2 : Object
    {
        public Cysharp.Threading.Tasks.ChannelReader`1<T> _reader; // 0x10
        public Cysharp.Threading.Tasks.ChannelWriter`1<T> _writer; // 0x18

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7FFE81116380
        public void set_Reader(){} // RVA: 0x7FFE810FCE30
        public void get_Writer(){} // RVA: 0x7FFE810FE7C0
        public void set_Writer(){} // RVA: 0x7FFE81161E80
        public void op_Implicit(){} // RVA: 0x7FFE86222DF0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CompletedTasks : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8783E930
    }

    public class DeltaTimePlayerLoopTimer : PlayerLoopTimer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8782D830
        public void MoveNextCore(){} // RVA: 0x7FFE8782D900
        public void ResetCore(){} // RVA: 0x7FFE8782D9E0
    }

    public class EnumerableAsyncExtensions : Object
    {
        // ── Methods ──
        public void Select(){} // RVA: 0x7FFE80E2E440 | overloaded x4
    }

    public class EnumeratorAsyncExtensions : Object
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7FFE810A1420
        public void WithCancellation(){} // RVA: 0x7FFE87826280
        public void ToUniTask(){} // RVA: 0x7FFE878264B0 | overloaded x2
        public void Core(){} // RVA: 0x7FFE87826710
    }

    public class ExceptionExtensions : Object
    {
        // ── Methods ──
        public void IsOperationCanceledException(){} // RVA: 0x7FFE87827EE0
    }

    public class ExceptionHolder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetException(){} // RVA: 0x7FFE878402A0
        public void Finalize(){} // RVA: 0x7FFE87840300
    }

    public class IAsyncClickEventHandler
    {
        // ── Methods ──
        public void OnClickAsync(){} // RVA: 0x7FFE80E2DCF0
    }

    public class IAsyncDeselectEventHandler`1
    {
        // ── Methods ──
        public void OnDeselectAsync(){} // RVA: 0x7FFE810A1420
    }

    public class IAsyncEndEditEventHandler`1
    {
        // ── Methods ──
        public void OnEndEditAsync(){} // RVA: 0x7FFE810A1420
    }

    public class IAsyncEndTextSelectionEventHandler`1
    {
        // ── Methods ──
        public void OnEndTextSelectionAsync(){} // RVA: 0x7FFE810A1420
    }

    public class IAsyncReactiveProperty`1
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE810A1420
        public void set_Value(){} // RVA: 0x7FFE810A1420
    }

    public class IAsyncSelectEventHandler`1
    {
        // ── Methods ──
        public void OnSelectAsync(){} // RVA: 0x7FFE810A1420
    }

    public class IAsyncSubmitEventHandler`1
    {
        // ── Methods ──
        public void OnSubmitAsync(){} // RVA: 0x7FFE810A1420
    }

    public class IAsyncTextSelectionEventHandler`1
    {
        // ── Methods ──
        public void OnTextSelectionAsync(){} // RVA: 0x7FFE810A1420
    }

    public class IAsyncValueChangedEventHandler`1
    {
        // ── Methods ──
        public void OnValueChangedAsync(){} // RVA: 0x7FFE810A1420
    }

    public class ICancelPromise
    {
        // ── Methods ──
        public void TrySetCanceled(){} // RVA: 0x7FFE810A1420
    }

    public class IConnectableUniTaskAsyncEnumerable`1
    {
        // ── Methods ──
        public void Connect(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IPlayerLoopItem
    {
        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFE80E2F150
    }

    public class IPromise
    {
    }

    public class IPromise`1
    {
    }

    public class IReadOnlyAsyncReactiveProperty`1
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE810A1420
        public void WithoutCurrent(){} // RVA: 0x7FFE80E2E2E0
        public void WaitAsync(){} // RVA: 0x7FFE810A1420
    }

    public class IRejectPromise
    {
        // ── Methods ──
        public void TrySetException(){} // RVA: 0x7FFE80E2F3B0
    }

    public class IResolvePromise
    {
        // ── Methods ──
        public void TrySetResult(){} // RVA: 0x7FFE80E2F150
    }

    public class IResolvePromise`1
    {
        // ── Methods ──
        public void TrySetResult(){} // RVA: 0x7FFE810A1420
    }

    public class ITaskPoolNode`1
    {
        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ITriggerHandler`1
    {
        // ── Methods ──
        public void OnNext(){} // RVA: 0x7FFE810A1420
        public void OnError(){} // RVA: 0x7FFE80E460A0
        public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
        public void OnCanceled(){} // RVA: 0x7FFE80E46250
        public void get_Prev(){} // RVA: 0x7FFE80E2E2E0
        public void set_Prev(){} // RVA: 0x7FFE80E460A0
        public void get_Next(){} // RVA: 0x7FFE80E2E2E0
        public void set_Next(){} // RVA: 0x7FFE80E460A0
    }

    public class IUniTaskAsyncDisposable
    {
        // ── Methods ──
        public void DisposeAsync(){} // RVA: 0x7FFE80E2DCF0
    }

    public class IUniTaskAsyncEnumerable`1
    {
        // ── Methods ──
        public void GetAsyncEnumerator(){}
    }

    public class IUniTaskAsyncEnumerator`1
    {
        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFE810A1420
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
        public void GetResult(){} // RVA: 0x7FFE80E461D0
        public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetStatus(){} // RVA: 0x7FFE87828BD0
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7FFE87828C20
        public void System.Threading.Tasks.Sources.IValueTaskSource.OnCompleted(){} // RVA: 0x7FFE87828C80
    }

    public class IUniTaskSource`1
    {
    }

    public class IgnoreTimeScalePlayerLoopTimer : PlayerLoopTimer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8782DB00
        public void MoveNextCore(){} // RVA: 0x7FFE8782DBD0
        public void ResetCore(){} // RVA: 0x7FFE8782DCB0
    }

    public class MoveNextSource : Object
    {
        // ── Methods ──
        public void GetResult(){} // RVA: 0x7FFE87828D20
        public void GetStatus(){} // RVA: 0x7FFE87828D70
        public void OnCompleted(){} // RVA: 0x7FFE87828DC0
        public void UnsafeGetStatus(){} // RVA: 0x7FFE87828E40
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE87828E80
        public void TryGetResult(){} // RVA: 0x7FFE87828ED0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PlayerLoopHelper : Object
    {
        public Cysharp.Threading.Tasks.Internal.ContinuationQueue ThrowMarkerContinuationQueue;
        public Cysharp.Threading.Tasks.Internal.PlayerLoopRunner ThrowMarkerPlayerLoopRunner; // 0x8
        public int mainThreadId; // 0x10
        public string applicationDataPath; // 0x18
        public System.Threading.SynchronizationContext unitySynchronizationContext; // 0x20

        // ── Methods ──
        public void get_UnitySynchronizationContext(){} // RVA: 0x7FFE87828F50
        public void get_MainThreadId(){} // RVA: 0x7FFE87828FB0
        public void get_ApplicationDataPath(){} // RVA: 0x7FFE87829010
        public void get_IsMainThread(){} // RVA: 0x7FFE87829070
        public void get_IsEditorApplicationQuitting(){} // RVA: 0x7FFE87829130
        public void set_IsEditorApplicationQuitting(){} // RVA: 0x7FFE87829190
        public void InsertRunner(){} // RVA: 0x7FFE878291F0
        public void RemoveRunner(){} // RVA: 0x7FFE87829750
        public void InsertUniTaskSynchronizationContext(){} // RVA: 0x7FFE87829970
        public void Init(){} // RVA: 0x7FFE8782A060
        public void FindLoopSystemIndex(){} // RVA: 0x7FFE8782A360
        public void InsertLoop(){} // RVA: 0x7FFE8782A470
        public void Initialize(){} // RVA: 0x7FFE8782A8C0
        public void AddAction(){} // RVA: 0x7FFE8782C480
        public void ThrowInvalidLoopTiming(){} // RVA: 0x7FFE8782C520
        public void AddContinuation(){} // RVA: 0x7FFE8782C5C0
        public void DumpCurrentPlayerLoop(){} // RVA: 0x7FFE8782C660
        public void IsInjectedUniTaskPlayerLoop(){} // RVA: 0x7FFE8782CAF0
        public void .cctor(){} // RVA: 0x7FFE8782CCB0
    }

    public class PlayerLoopTimer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8782D180
        public void Create(){} // RVA: 0x7FFE8782D290
        public void StartNew(){} // RVA: 0x7FFE8782D420
        public void Restart(){} // RVA: 0x7FFE8782D620 | overloaded x2
        public void Stop(){} // RVA: 0x7FFE8782D720
        public void ResetCore(){}
        public void Dispose(){} // RVA: 0x7FFE8782D730
        public void Cysharp.Threading.Tasks.IPlayerLoopItem.MoveNext(){} // RVA: 0x7FFE8782D740
        public void MoveNextCore(){} // RVA: 0x7FFE80E2F150
    }

    public class Progress : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE80E2E3D0
        public void CreateOnlyValueChanged(){} // RVA: 0x7FFE80E2E440
    }

    public class ReadOnlyAsyncReactiveProperty`1 : Object
    {
        public Cysharp.Threading.Tasks.TriggerEvent`1<T> triggerEvent;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ConsumeEnumerator(){} // RVA: 0x7FFE810A1420
        public void WithoutCurrent(){} // RVA: 0x7FFE80E2E2E0
        public void GetAsyncEnumerator(){}
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void op_Implicit(){} // RVA: 0x7FFE810A1420
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void WaitAsync(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class RealtimePlayerLoopTimer : PlayerLoopTimer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8782DDD0
        public void MoveNextCore(){} // RVA: 0x7FFE8782DEA0
        public void ResetCore(){} // RVA: 0x7FFE8782DF00
    }

    public class ReturnToMainThread : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE844576B0
        public void DisposeAsync(){} // RVA: 0x7FFE8783EF30
    }

    public class ReturnToSynchronizationContext : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8783FE50
        public void DisposeAsync(){} // RVA: 0x7FFE8783FF10
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class StateExtensions : Object
    {
        // ── Methods ──
        public void ToReadOnlyAsyncReactiveProperty(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

    public class SwitchToMainThreadAwaitable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE844576B0
        public void GetAwaiter(){} // RVA: 0x7FFE8783EF30
    }

    public class SwitchToSynchronizationContextAwaitable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84459530
        public void GetAwaiter(){} // RVA: 0x7FFE8783FB00
    }

    public class SwitchToTaskPoolAwaitable : ValueType
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7FFE810FB320
    }

    public class SwitchToThreadPoolAwaitable : ValueType
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7FFE810FB320
    }

    public class TaskPool : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8782DFF0
        public void SetMaxPoolSize(){} // RVA: 0x7FFE8782E1E0
        public void GetCacheSizeInfo(){} // RVA: 0x7FFE8782E240
        public void RegisterSizeGetter(){} // RVA: 0x7FFE8782E290
    }

    public class TaskPool`1 : ValueType
    {
        public int gate; // 0x10

        // ── Methods ──
        public void get_Size(){} // RVA: 0x7FFE826F42A0
        public void TryPop(){} // RVA: 0x7FFE84A718E0
        public void TryPush(){} // RVA: 0x7FFE84E44B20
    }

    public class TaskTracker : Object
    {
        // ── Methods ──
        public void TrackActiveTask(){} // RVA: 0x7FFE810FB310
        public void RemoveTracking(){} // RVA: 0x7FFE810FB310
        public void CheckAndResetDirty(){} // RVA: 0x7FFE87827F70
        public void ForEachActiveTask(){} // RVA: 0x7FFE87827FD0
        public void TypeBeautify(){} // RVA: 0x7FFE87828630
        public void .cctor(){} // RVA: 0x7FFE87828940
    }

    public class TextMeshProAsyncExtensions : Object
    {
        // ── Methods ──
        public void BindTo(){} // RVA: 0x7FFE80E4F3B0 | overloaded x5
        public void BindToCore(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetAsyncValueChangedEventHandler(){} // RVA: 0x7FFE8786D860 | overloaded x2
        public void OnValueChangedAsync(){} // RVA: 0x7FFE8786D9F0 | overloaded x2
        public void OnValueChangedAsAsyncEnumerable(){} // RVA: 0x7FFE8786DB80 | overloaded x2
        public void GetAsyncEndEditEventHandler(){} // RVA: 0x7FFE8786DCC0 | overloaded x2
        public void OnEndEditAsync(){} // RVA: 0x7FFE8786DE50 | overloaded x2
        public void OnEndEditAsAsyncEnumerable(){} // RVA: 0x7FFE8786DFE0 | overloaded x2
        public void GetAsyncEndTextSelectionEventHandler(){} // RVA: 0x7FFE8786E150 | overloaded x2
        public void OnEndTextSelectionAsync(){} // RVA: 0x7FFE8786E340 | overloaded x2
        public void OnEndTextSelectionAsAsyncEnumerable(){} // RVA: 0x7FFE8786E530 | overloaded x2
        public void GetAsyncTextSelectionEventHandler(){} // RVA: 0x7FFE8786E6D0 | overloaded x2
        public void OnTextSelectionAsync(){} // RVA: 0x7FFE8786E8C0 | overloaded x2
        public void OnTextSelectionAsAsyncEnumerable(){} // RVA: 0x7FFE8786EAB0 | overloaded x2
        public void GetAsyncDeselectEventHandler(){} // RVA: 0x7FFE8786EC20 | overloaded x2
        public void OnDeselectAsync(){} // RVA: 0x7FFE8786EDB0 | overloaded x2
        public void OnDeselectAsAsyncEnumerable(){} // RVA: 0x7FFE8786EF40 | overloaded x2
        public void GetAsyncSelectEventHandler(){} // RVA: 0x7FFE8786F080 | overloaded x2
        public void OnSelectAsync(){} // RVA: 0x7FFE8786F210 | overloaded x2
        public void OnSelectAsAsyncEnumerable(){} // RVA: 0x7FFE8786F3A0 | overloaded x2
        public void GetAsyncSubmitEventHandler(){} // RVA: 0x7FFE8786F4E0 | overloaded x2
        public void OnSubmitAsync(){} // RVA: 0x7FFE8786F670 | overloaded x2
        public void OnSubmitAsAsyncEnumerable(){} // RVA: 0x7FFE8786F800 | overloaded x2
    }

    public class TextSelectionEventConverter : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87880FB0
        public void InvokeCore(){} // RVA: 0x7FFE878811D0
        public void Dispose(){} // RVA: 0x7FFE878812C0
    }

    public class TimeoutController : Object
    {
        // ── Methods ──
        public void CancelCancellationTokenSourceState(){} // RVA: 0x7FFE8782ED20
        public void .ctor(){} // RVA: 0x7FFE8782EF50 | overloaded x2
        public void Timeout(){} // RVA: 0x7FFE8782F1E0 | overloaded x2
        public void IsTimeout(){} // RVA: 0x7FFE8782F650
        public void Reset(){} // RVA: 0x7FFE8782F680
        public void Dispose(){} // RVA: 0x7FFE8782F690
        public void .cctor(){} // RVA: 0x7FFE8782F7A0
    }

    public class TriggerEvent`1 : ValueType
    {
        // ── Methods ──
        public void LogError(){} // RVA: 0x7FFE80E460A0
        public void SetResult(){} // RVA: 0x7FFE810A1420
        public void SetCanceled(){} // RVA: 0x7FFE80E46250
        public void SetCompleted(){} // RVA: 0x7FFE80E45FE0
        public void SetError(){} // RVA: 0x7FFE80E460A0
        public void Add(){} // RVA: 0x7FFE80E460A0
        public void Remove(){} // RVA: 0x7FFE80E460A0
    }

    public class UniTask : ValueType
    {
        public Cysharp.Threading.Tasks.IUniTaskSource source; // 0x10

        // ── Methods ──
        public void ToCoroutine(){} // RVA: 0x7FFE8782FEE0
        public void .ctor(){} // RVA: 0x7FFE833D3C80
        public void get_Status(){} // RVA: 0x7FFE8782FF20
        public void GetAwaiter(){} // RVA: 0x7FFE8782FF80
        public void SuppressCancellationThrow(){} // RVA: 0x7FFE8782FFE0
        public void op_Implicit(){} // RVA: 0x7FFE878301B0
        public void ToString(){} // RVA: 0x7FFE87830250
        public void Preserve(){} // RVA: 0x7FFE87830340
        public void AsAsyncUnitUniTask(){} // RVA: 0x7FFE87830470
        public void Yield(){} // RVA: 0x7FFE87830720 | overloaded x4
        public void NextFrame(){} // RVA: 0x7FFE87830AD0 | overloaded x4
        public void WaitForEndOfFrame(){} // RVA: 0x7FFE87830D90 | overloaded x4
        public void WaitForFixedUpdate(){} // RVA: 0x7FFE87830EC0 | overloaded x2
        public void WaitForSeconds(){} // RVA: 0x7FFE87831020 | overloaded x2
        public void DelayFrame(){} // RVA: 0x7FFE878310D0
        public void Delay(){} // RVA: 0x7FFE87831580 | overloaded x4
        public void FromException(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void FromResult(){} // RVA: 0x7FFE810A1420
        public void FromCanceled(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Create(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void Lazy(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void Void(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void Action(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void UnityAction(){} // RVA: 0x7FFE80E33EA0 | overloaded x11
        public void Defer(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void Never(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Run(){} // RVA: 0x7FFE810A1420 | overloaded x8
        public void RunOnThreadPool(){} // RVA: 0x7FFE810A1420 | overloaded x8
        public void SwitchToMainThread(){} // RVA: 0x7FFE878331B0 | overloaded x2
        public void ReturnToMainThread(){} // RVA: 0x7FFE878331B0 | overloaded x2
        public void Post(){} // RVA: 0x7FFE87833210
        public void SwitchToThreadPool(){} // RVA: 0x7FFE810FB320
        public void SwitchToTaskPool(){} // RVA: 0x7FFE810FB320
        public void SwitchToSynchronizationContext(){} // RVA: 0x7FFE87833270
        public void ReturnToSynchronizationContext(){} // RVA: 0x7FFE87833300
        public void ReturnToCurrentSynchronizationContext(){} // RVA: 0x7FFE87833330
        public void WaitUntil(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void WaitWhile(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void WaitUntilCanceled(){} // RVA: 0x7FFE87833570
        public void WaitUntilValueChanged(){} // RVA: 0x7FFE810A1420
        public void WhenAll(){} // RVA: 0x7FFE810A1420 | overloaded x18
        public void WhenAny(){} // RVA: 0x7FFE810A1420 | overloaded x19
        public void WhenEach(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87833BD0
    }

    public class UniTaskAsyncEnumerableExtensions : Object
    {
        // ── Methods ──
        public void WithCancellation(){} // RVA: 0x7FFE810A1420
    }

    public class UniTaskCancelableAsyncEnumerable`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){} // RVA: 0x7FFE810A1420
    }

    public class UniTaskCancellationExtensions : Object
    {
        // ── Methods ──
        public void GetCancellationTokenOnDestroy(){} // RVA: 0x7FFE8782F950 | overloaded x3
    }

    public class UniTaskCompletionSource : Object
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void MarkHandled(){} // RVA: 0x7FFE87840F80
        public void get_Task(){} // RVA: 0x7FFE87840F90
        public void TrySetResult(){} // RVA: 0x7FFE87840FF0
        public void TrySetCanceled(){} // RVA: 0x7FFE87841000
        public void TrySetException(){} // RVA: 0x7FFE87841070
        public void GetResult(){} // RVA: 0x7FFE87841270
        public void GetStatus(){} // RVA: 0x7FFE8119C080
        public void UnsafeGetStatus(){} // RVA: 0x7FFE8119C080
        public void OnCompleted(){} // RVA: 0x7FFE87841370
        public void TrySignalCompletion(){} // RVA: 0x7FFE87841790
    }

    public class UniTaskCompletionSourceCoreShared : Object
    {
        // ── Methods ──
        public void CompletionSentinel(){} // RVA: 0x7FFE878403A0
        public void .cctor(){} // RVA: 0x7FFE878403F0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public UnityEngine.AudioClip result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE8511FB90
        public void ReportUnhandledError(){} // RVA: 0x7FFE8511FCD0
        public void MarkHandled(){} // RVA: 0x7FFE850F0810
        public void TrySetResult(){} // RVA: 0x7FFE8511FE20
        public void TrySetException(){} // RVA: 0x7FFE8511FF20
        public void TrySetCanceled(){} // RVA: 0x7FFE851201D0
        public void get_Version(){} // RVA: 0x7FFE8299FB40
        public void GetStatus(){} // RVA: 0x7FFE85120310
        public void UnsafeGetStatus(){} // RVA: 0x7FFE85120450
        public void GetResult(){} // RVA: 0x7FFE850F0EB0
        public void OnCompleted(){} // RVA: 0x7FFE851204F0
        public void ValidateToken(){} // RVA: 0x7FFE850F1270
    }

    public class UniTaskCompletionSource`1 : Object
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskExtensions : Object
    {
        // ── Methods ──
        public void AsUniTask(){} // RVA: 0x7FFE87841CE0 | overloaded x2
        public void AsTask(){} // RVA: 0x7FFE87841F60 | overloaded x2
        public void ToAsyncLazy(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void AttachExternalCancellation(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ToCoroutine(){} // RVA: 0x7FFE87842660 | overloaded x2
        public void Timeout(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void TimeoutWithoutException(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Forget(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void ForgetCoreWithCatch(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ContinueWith(){} // RVA: 0x7FFE810A1420 | overloaded x8
        public void Unwrap(){} // RVA: 0x7FFE87843BE0 | overloaded x10
        public void GetAwaiter(){} // RVA: 0x7FFE87849140 | overloaded x32
    }

    public class UniTaskLoopRunners : Object
    {
    }

    public class UniTaskObservableExtensions : Object
    {
        // ── Methods ──
        public void ToUniTask(){} // RVA: 0x7FFE810A1420
        public void ToObservable(){} // RVA: 0x7FFE87871050 | overloaded x2
        public void Fire(){} // RVA: 0x7FFE87871540 | overloaded x2
    }

    public class UniTaskScheduler : Object
    {
        // ── Methods ──
        public void add_UnobservedTaskException(){} // RVA: 0x7FFE87871A30
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFE87871B90
        public void InvokeUnobservedTaskException(){} // RVA: 0x7FFE87871CF0
        public void PublishUnobservedTaskException(){} // RVA: 0x7FFE87871DC0
        public void .cctor(){} // RVA: 0x7FFE87872170
    }

    public class UniTaskStatusExtensions : Object
    {
        // ── Methods ──
        public void IsCompleted(){} // RVA: 0x7FFE868BE980
        public void IsCompletedSuccessfully(){} // RVA: 0x7FFE82703690
        public void IsCanceled(){} // RVA: 0x7FFE87828D00
        public void IsFaulted(){} // RVA: 0x7FFE87828D10
    }

    public class UniTaskSynchronizationContext : SynchronizationContext
    {
        // ── Methods ──
        public void Send(){} // RVA: 0x7FFE83F952D0
        public void Post(){} // RVA: 0x7FFE87872280
        public void OperationStarted(){} // RVA: 0x7FFE87872A50
        public void OperationCompleted(){} // RVA: 0x7FFE87872AB0
        public void CreateCopy(){} // RVA: 0x7FFE827C4A80
        public void Run(){} // RVA: 0x7FFE87872B10
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87872F20
    }

    public class UniTaskValueTaskExtensions : Object
    {
        // ── Methods ──
        public void AsValueTask(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void AsUniTask(){} // RVA: 0x7FFE8782FAE0 | overloaded x2
    }

    public class UniTaskVoid : ValueType
    {
        // ── Methods ──
        public void Forget(){} // RVA: 0x7FFE810FB310
    }

    public class UniTask`1 : ValueType
    {
        public Cysharp.Threading.Tasks.IUniTaskSource`1<System.ValueTuple`2<bool,UnityEngine.AudioClip>> source; // 0x10
    }

    public class UnityAsyncExtensions : Object
    {
        // ── Methods ──
        public void AwaitForAllAssets(){} // RVA: 0x7FFE87873240 | overloaded x4
        public void GetAwaiter(){} // RVA: 0x7FFE87874D80 | overloaded x7
        public void WithCancellation(){} // RVA: 0x7FFE87874820 | overloaded x12
        public void ToUniTask(){} // RVA: 0x7FFE87874F80 | overloaded x7
        public void WaitAsync(){} // RVA: 0x7FFE87874C00
        public void StartAsyncCoroutine(){} // RVA: 0x7FFE878750B0
        public void GetAsyncEventHandler(){} // RVA: 0x7FFE80E33EA0 | overloaded x2
        public void OnInvokeAsync(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void OnInvokeAsAsyncEnumerable(){} // RVA: 0x7FFE80E33EA0 | overloaded x2
        public void GetAsyncClickEventHandler(){} // RVA: 0x7FFE87875330 | overloaded x2
        public void OnClickAsync(){} // RVA: 0x7FFE87875480 | overloaded x2
        public void OnClickAsAsyncEnumerable(){} // RVA: 0x7FFE878755C0 | overloaded x2
        public void GetAsyncValueChangedEventHandler(){} // RVA: 0x7FFE878770B0 | overloaded x12
        public void OnValueChangedAsync(){} // RVA: 0x7FFE87877230 | overloaded x12
        public void OnValueChangedAsAsyncEnumerable(){} // RVA: 0x7FFE878773B0 | overloaded x12
        public void GetAsyncEndEditEventHandler(){} // RVA: 0x7FFE878767F0 | overloaded x2
        public void OnEndEditAsync(){} // RVA: 0x7FFE87876980 | overloaded x2
        public void OnEndEditAsAsyncEnumerable(){} // RVA: 0x7FFE87876B10 | overloaded x2
    }

    public class UnityBindingExtensions : Object
    {
        // ── Methods ──
        public void BindTo(){} // RVA: 0x7FFE810A1420 | overloaded x9
        public void BindToCore(){} // RVA: 0x7FFE810A1420 | overloaded x4
    }

    public class UnityEventHandlerAsyncEnumerable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83BAAB10
        public void GetAsyncEnumerator(){} // RVA: 0x7FFE87881B90
    }

    public class UnityEventHandlerAsyncEnumerable`1 : Object
    {
        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){}
    }

    public class UnityWebRequestException : Exception
    {
        public UnityEngine.Networking.UnityWebRequest _unityWebRequest; // 0x90
        public 0x666C8DBC _result; // 0x98
        public string _error; // 0xA0
        public string _text; // 0xA8
        public long _responseCode; // 0xB0
        public System.Collections.Generic.Dictionary`2<string,string> _responseHeaders; // 0xB8
        public string msg; // 0xC0

        // ── Methods ──
        public void get_UnityWebRequest(){} // RVA: 0x7FFE8154EB60
        public void get_Result(){} // RVA: 0x7FFE82B06A40
        public void get_Error(){} // RVA: 0x7FFE8179C860
        public void get_Text(){} // RVA: 0x7FFE817AB5E0
        public void get_ResponseCode(){} // RVA: 0x7FFE81166040
        public void get_ResponseHeaders(){} // RVA: 0x7FFE811660B0
        public void .ctor(){} // RVA: 0x7FFE87884040
        public void get_Message(){} // RVA: 0x7FFE87884320
    }

    public class WhenEachEnumerable`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void GetAsyncEnumerator(){}
    }

    public class WhenEachResult`1 : ValueType
    {
        public T _result;
        public System.Exception _exception;
        public object field_2; // 0x4A
        public object field_3; // 0x4B

        // ── Methods ──
        public void get_Result(){} // RVA: 0x7FFE810A1420
        public void get_Exception(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7FFE80E2F150
        public void get_IsFaulted(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void TryThrow(){} // RVA: 0x7FFE80E45FE0
        public void GetResult(){} // RVA: 0x7FFE810A1420
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
    }

    public class YieldAwaitable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815BF990
        public void GetAwaiter(){} // RVA: 0x7FFE826F4220
        public void ToUniTask(){} // RVA: 0x7FFE8783E7D0
    }

}