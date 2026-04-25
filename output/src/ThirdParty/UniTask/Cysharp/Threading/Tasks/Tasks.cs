// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 99
// Methods: 777

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class AsyncInstantiateOperationExtensions : Object
    {
        // ── Methods ──
        public void WithCancellation(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void ToUniTask(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

    public class AsyncLazy : Object
    {
        public System.Action`1<object> Task;
        public System.Func`1<Cysharp.Threading.Tasks.UniTask> taskFactory; // 0x10
        public Cysharp.Threading.Tasks.UniTaskCompletionSource completionSource; // 0x18
        public Awaiter awaiter; // 0x20
        public object syncLock; // 0x30
        public bool initialized; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC947B1B0 | overloaded x2
        public void get_Task(){} // RVA: 0x7FFAC947B540
        public void GetAwaiter(){} // RVA: 0x7FFAC947B5F0
        public void EnsureInitialized(){} // RVA: 0x7FFAC947B760
        public void EnsureInitializedCore(){} // RVA: 0x7FFAC947B790
        public void SetCompletionSource(){} // RVA: 0x7FFAC947BB60 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC947BD00
    }

    public class AsyncLazy`1 : Object
    {
        public System.Action`1<object> Task;
        public System.Func`1<Cysharp.Threading.Tasks.UniTask`1<T>> taskFactory;
        public Cysharp.Threading.Tasks.UniTaskCompletionSource`1<T> completionSource;
        public Awaiter<T> awaiter;
        public object syncLock;
        public bool initialized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void get_Task(){} // RVA: 0x7FFAC2E8DC40
        public void GetAwaiter(){} // RVA: 0x7FFAC2E8DC40
        public void EnsureInitialized(){} // RVA: 0x7FFAC2C70980
        public void EnsureInitializedCore(){} // RVA: 0x7FFAC2C70980
        public void SetCompletionSource(){} // RVA: 0x7FFAC2C70A10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class AsyncReactiveProperty`1 : Object
    {
        public Cysharp.Threading.Tasks.TriggerEvent`1<T> Value;
        public T latestValue;
        public bool isValueType;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
        public void set_Value(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void WithoutCurrent(){} // RVA: 0x7FFAC2C58E90
        public void GetAsyncEnumerator(){}
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void WaitAsync(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class AsyncUnit : ValueType
    {
        public Cysharp.Threading.Tasks.AsyncUnit Default;

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAC34F9180
        public void Equals(){} // RVA: 0x7FFAC3006850
        public void ToString(){} // RVA: 0x7FFAC947BDE0
        public void .cctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AsyncUnityEventHandler : Object
    {
        public System.Action`1<object> cancellationCallback;
        public UnityEngine.Events.UnityAction action; // 0x10
        public UnityEngine.Events.UnityEvent unityEvent; // 0x18
        public System.Threading.CancellationToken cancellationToken; // 0x20
        public System.Threading.CancellationTokenRegistration registration; // 0x28
        public bool isDisposed; // 0x40
        public bool callOnce; // 0x41
        public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94D8C00
        public void OnInvokeAsync(){} // RVA: 0x7FFAC94D8EF0
        public void Invoke(){} // RVA: 0x7FFAC94D8FE0
        public void CancellationCallback(){} // RVA: 0x7FFAC94D9060
        public void Dispose(){} // RVA: 0x7FFAC94D90E0
        public void Cysharp.Threading.Tasks.IAsyncClickEventHandler.OnClickAsync(){} // RVA: 0x7FFAC94D9190
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC94D91C0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){} // RVA: 0x7FFAC94D9260
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7FFAC94D92B0
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){} // RVA: 0x7FFAC94D92F0
        public void .cctor(){} // RVA: 0x7FFAC94D9370
    }

    public class AsyncUnityEventHandler`1 : Object
    {
        public System.Action`1<object> cancellationCallback;
        public UnityEngine.Events.UnityAction`1<T> action;
        public UnityEngine.Events.UnityEvent`1<T> unityEvent;
        public System.Threading.CancellationToken cancellationToken;
        public System.Threading.CancellationTokenRegistration registration;
        public bool isDisposed;
        public bool callOnce;
        public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<T> core;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void OnInvokeAsync(){} // RVA: 0x7FFAC2E8DC40
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
        public void CancellationCallback(){} // RVA: 0x7FFAC2C70A10
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void Cysharp.Threading.Tasks.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync(){} // RVA: 0x7FFAC2E8DC40
        public void Cysharp.Threading.Tasks.IAsyncEndEditEventHandler<T>.OnEndEditAsync(){} // RVA: 0x7FFAC2E8DC40
        public void Cysharp.Threading.Tasks.IAsyncEndTextSelectionEventHandler<T>.OnEndTextSelectionAsync(){} // RVA: 0x7FFAC2E8DC40
        public void Cysharp.Threading.Tasks.IAsyncTextSelectionEventHandler<T>.OnTextSelectionAsync(){} // RVA: 0x7FFAC2E8DC40
        public void Cysharp.Threading.Tasks.IAsyncDeselectEventHandler<T>.OnDeselectAsync(){} // RVA: 0x7FFAC2E8DC40
        public void Cysharp.Threading.Tasks.IAsyncSelectEventHandler<T>.OnSelectAsync(){} // RVA: 0x7FFAC2E8DC40
        public void Cysharp.Threading.Tasks.IAsyncSubmitEventHandler<T>.OnSubmitAsync(){} // RVA: 0x7FFAC2E8DC40
        public void Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(){} // RVA: 0x7FFAC2E8DC40
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){}
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){}
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class AutoResetUniTaskCompletionSource : Object
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource> NextNode;
        public Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource Task; // 0x10
        public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core; // 0x18
        public short version; // 0x40

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
        public void .cctor(){} // RVA: 0x7FFAC9497D90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC9497F10
        public void CreateFromCanceled(){} // RVA: 0x7FFAC9497FD0
        public void CreateFromException(){} // RVA: 0x7FFAC94980B0
        public void CreateCompleted(){} // RVA: 0x7FFAC9498190
        public void get_Task(){} // RVA: 0x7FFAC9498220
        public void TrySetResult(){} // RVA: 0x7FFAC94982C0
        public void TrySetCanceled(){} // RVA: 0x7FFAC9498360
        public void TrySetException(){} // RVA: 0x7FFAC94983D0
        public void GetResult(){} // RVA: 0x7FFAC9498450
        public void GetStatus(){} // RVA: 0x7FFAC9498580
        public void UnsafeGetStatus(){} // RVA: 0x7FFAC94985D0
        public void OnCompleted(){} // RVA: 0x7FFAC9498610
        public void TryReturn(){} // RVA: 0x7FFAC9498690
    }

    public class AutoResetUniTaskCompletionSource`1 : Object
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource`1<T>> NextNode;
        public Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource`1<T> Task;
        public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<T> core;
        public short version;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFAC2C58E90
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Create(){} // RVA: 0x7FFAC2C58A90
        public void CreateFromCanceled(){} // RVA: 0x7FFAC2E8DC40
        public void CreateFromException(){} // RVA: 0x7FFAC2C58FF0
        public void CreateFromResult(){} // RVA: 0x7FFAC2E8DC40
        public void get_Task(){} // RVA: 0x7FFAC2E8DC40
        public void TrySetResult(){} // RVA: 0x7FFAC2E8DC40
        public void TrySetCanceled(){} // RVA: 0x7FFAC2E8DC40
        public void TrySetException(){} // RVA: 0x7FFAC2C59F60
        public void GetResult(){} // RVA: 0x7FFAC2E8DC40
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
        public void GetStatus(){}
        public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
        public void OnCompleted(){}
        public void TryReturn(){} // RVA: 0x7FFAC2C59D00
    }

    public class AwaiterActions : Object
    {
        public System.Action`1<object> InvokeContinuationDelegate;

        // ── Methods ──
        public void Continuation(){} // RVA: 0x7FFAC9495F40
        public void .cctor(){} // RVA: 0x7FFAC9495FB0
    }

    public class CancellationTokenAwaitable : ValueType
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void GetAwaiter(){} // RVA: 0x7FFAC947D1F0
    }

    public class CancellationTokenEqualityComparer : Object
    {
        public System.Collections.Generic.IEqualityComparer`1<System.Threading.CancellationToken> Default;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC947BE20
        public void GetHashCode(){} // RVA: 0x7FFAC947BE80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC947BF40
    }

    public class CancellationTokenExtensions : Object
    {
        public System.Action`1<object> cancellationTokenCallback;
        public System.Action`1<object> disposeCallback; // 0x8

        // ── Methods ──
        public void ToCancellationToken(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void ToCancellationTokenCore(){} // RVA: 0x7FFAC947C220
        public void ToUniTask(){} // RVA: 0x7FFAC947C3B0
        public void Callback(){} // RVA: 0x7FFAC947C760
        public void WaitUntilCanceled(){} // RVA: 0x7FFAC38D6FB0
        public void RegisterWithoutCaptureExecutionContext(){} // RVA: 0x7FFAC947CA20 | overloaded x2
        public void AddTo(){} // RVA: 0x7FFAC947CBE0
        public void DisposeCallback(){} // RVA: 0x7FFAC947CC80
        public void .cctor(){} // RVA: 0x7FFAC947CD20
    }

    public class CancellationTokenSourceExtensions : Object
    {
        public System.Action`1<object> CancelCancellationTokenSourceStateDelegate;

        // ── Methods ──
        public void CancelCancellationTokenSourceState(){} // RVA: 0x7FFAC947D360
        public void CancelAfterSlim(){} // RVA: 0x7FFAC947D5B0 | overloaded x2
        public void RegisterRaiseCancelOnDestroy(){} // RVA: 0x7FFAC947D860 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC947D9B0
    }

    public class Channel : Object
    {
        // ── Methods ──
        public void CreateSingleConsumerUnbounded(){} // RVA: 0x7FFAC2C58A90
    }

    public class ChannelClosedException : InvalidOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8632840 | overloaded x4
    }

    public class ChannelReader`1 : Object
    {
        public object Completion;

        // ── Methods ──
        public void TryRead(){} // RVA: 0x7FFAC2C59F60
        public void WaitToReadAsync(){}
        public void get_Completion(){} // RVA: 0x7FFAC2C588A0
        public void ReadAsync(){} // RVA: 0x7FFAC2E8DC40
        public void ReadAsyncCore(){} // RVA: 0x7FFAC2E8DC40
        public void ReadAllAsync(){}
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryWrite(){} // RVA: 0x7FFAC2E8DC40
        public void TryComplete(){} // RVA: 0x7FFAC2C59F60
        public void Complete(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class Channel`2 : Object
    {
        public Cysharp.Threading.Tasks.ChannelReader`1<T> Reader; // 0x10
        public Cysharp.Threading.Tasks.ChannelWriter`1<T> Writer; // 0x18

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7FFAC2F3C380
        public void set_Reader(){} // RVA: 0x7FFAC2F22E30
        public void get_Writer(){} // RVA: 0x7FFAC2F247C0
        public void set_Writer(){} // RVA: 0x7FFAC2F87E80
        public void op_Implicit(){} // RVA: 0x7FFAC7DFF590 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CompletedTasks : Object
    {
        public Cysharp.Threading.Tasks.UniTask`1<Cysharp.Threading.Tasks.AsyncUnit> AsyncUnit;
        public Cysharp.Threading.Tasks.UniTask`1<bool> True; // 0x10
        public Cysharp.Threading.Tasks.UniTask`1<bool> False; // 0x20
        public Cysharp.Threading.Tasks.UniTask`1<int> Zero; // 0x30
        public Cysharp.Threading.Tasks.UniTask`1<int> MinusOne; // 0x40
        public Cysharp.Threading.Tasks.UniTask`1<int> One; // 0x50

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC94961F0
    }

    public class DeltaTimePlayerLoopTimer : PlayerLoopTimer
    {
        public int initialFrame; // 0x30
        public float elapsed; // 0x34
        public float interval; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94850F0
        public void MoveNextCore(){} // RVA: 0x7FFAC94851C0
        public void ResetCore(){} // RVA: 0x7FFAC94852A0
    }

    public class EnumerableAsyncExtensions : Object
    {
        // ── Methods ──
        public void Select(){} // RVA: 0x7FFAC2C58FF0 | overloaded x4
    }

    public class EnumeratorAsyncExtensions : Object
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7FFAC2E8DC40
        public void WithCancellation(){} // RVA: 0x7FFAC947DB40
        public void ToUniTask(){} // RVA: 0x7FFAC947DD70 | overloaded x2
        public void Core(){} // RVA: 0x7FFAC947DFD0
    }

    public class ExceptionExtensions : Object
    {
        // ── Methods ──
        public void IsOperationCanceledException(){} // RVA: 0x7FFAC947F7A0
    }

    public class ExceptionHolder : Object
    {
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo exception; // 0x10
        public bool calledGet; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetException(){} // RVA: 0x7FFAC9497B60
        public void Finalize(){} // RVA: 0x7FFAC9497BC0
    }

    public class IAsyncClickEventHandler
    {
        // ── Methods ──
        public void OnClickAsync(){} // RVA: 0x7FFAC2C588A0
    }

    public class IAsyncDeselectEventHandler`1
    {
        // ── Methods ──
        public void OnDeselectAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IAsyncEndEditEventHandler`1
    {
        // ── Methods ──
        public void OnEndEditAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IAsyncEndTextSelectionEventHandler`1
    {
        // ── Methods ──
        public void OnEndTextSelectionAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IAsyncReactiveProperty`1
    {
        public object Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
        public void set_Value(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IAsyncSelectEventHandler`1
    {
        // ── Methods ──
        public void OnSelectAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IAsyncSubmitEventHandler`1
    {
        // ── Methods ──
        public void OnSubmitAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IAsyncTextSelectionEventHandler`1
    {
        // ── Methods ──
        public void OnTextSelectionAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IAsyncValueChangedEventHandler`1
    {
        // ── Methods ──
        public void OnValueChangedAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ICancelPromise
    {
        // ── Methods ──
        public void TrySetCanceled(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IConnectableUniTaskAsyncEnumerable`1
    {
        // ── Methods ──
        public void Connect(){} // RVA: 0x7FFAC2C58E90
    }

    public class IPlayerLoopItem
    {
        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC2C59D00
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
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
        public void WithoutCurrent(){} // RVA: 0x7FFAC2C58E90
        public void WaitAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IRejectPromise
    {
        // ── Methods ──
        public void TrySetException(){} // RVA: 0x7FFAC2C59F60
    }

    public class IResolvePromise
    {
        // ── Methods ──
        public void TrySetResult(){} // RVA: 0x7FFAC2C59D00
    }

    public class IResolvePromise`1
    {
        // ── Methods ──
        public void TrySetResult(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ITaskPoolNode`1
    {
        public object NextNode;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFAC2C58E90
    }

    public class ITriggerHandler`1
    {
        public object Prev;
        public object Next;

        // ── Methods ──
        public void OnNext(){} // RVA: 0x7FFAC2E8DC40
        public void OnError(){} // RVA: 0x7FFAC2C70A40
        public void OnCompleted(){} // RVA: 0x7FFAC2C70980
        public void OnCanceled(){} // RVA: 0x7FFAC2C70BF0
        public void get_Prev(){} // RVA: 0x7FFAC2C58E90
        public void set_Prev(){} // RVA: 0x7FFAC2C70A40
        public void get_Next(){} // RVA: 0x7FFAC2C58E90
        public void set_Next(){} // RVA: 0x7FFAC2C70A40
    }

    public class IUniTaskAsyncDisposable
    {
        // ── Methods ──
        public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
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
        public void get_Current(){} // RVA: 0x7FFAC2E8DC40
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
        public void GetResult(){} // RVA: 0x7FFAC2C70B70
        public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetStatus(){} // RVA: 0x7FFAC9480490
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7FFAC94804E0
        public void System.Threading.Tasks.Sources.IValueTaskSource.OnCompleted(){} // RVA: 0x7FFAC9480540
    }

    public class IUniTaskSource`1
    {
        // ── Methods ──
        public void GetResult(){} // RVA: 0x7FFAC2E8DC40
        public void GetStatus(){}
        public void OnCompleted(){}
        public void System.Threading.Tasks.Sources.IValueTaskSource<T>.GetStatus(){}
        public void System.Threading.Tasks.Sources.IValueTaskSource<T>.GetResult(){} // RVA: 0x7FFAC2E8DC40
        public void System.Threading.Tasks.Sources.IValueTaskSource<T>.OnCompleted(){}
    }

    public class IgnoreTimeScalePlayerLoopTimer : PlayerLoopTimer
    {
        public int initialFrame; // 0x30
        public float elapsed; // 0x34
        public float interval; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94853C0
        public void MoveNextCore(){} // RVA: 0x7FFAC9485490
        public void ResetCore(){} // RVA: 0x7FFAC9485570
    }

    public class MoveNextSource : Object
    {
        public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<bool> completionSource; // 0x10

        // ── Methods ──
        public void GetResult(){} // RVA: 0x7FFAC94805E0
        public void GetStatus(){} // RVA: 0x7FFAC9480630
        public void OnCompleted(){} // RVA: 0x7FFAC9480680
        public void UnsafeGetStatus(){} // RVA: 0x7FFAC9480700
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC9480740
        public void TryGetResult(){} // RVA: 0x7FFAC9480790 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PlayerLoopHelper : Object
    {
        public Cysharp.Threading.Tasks.Internal.ContinuationQueue UnitySynchronizationContext;
        public Cysharp.Threading.Tasks.Internal.PlayerLoopRunner MainThreadId; // 0x8
        public int ApplicationDataPath; // 0x10
        public string IsMainThread; // 0x18
        public System.Threading.SynchronizationContext IsEditorApplicationQuitting; // 0x20
        public Cysharp.Threading.Tasks.Internal.ContinuationQueue[] yielders; // 0x28
        public Cysharp.Threading.Tasks.Internal.PlayerLoopRunner[] runners; // 0x30
        public bool <IsEditorApplicationQuitting>k__BackingField; // 0x38

        // ── Methods ──
        public void get_UnitySynchronizationContext(){} // RVA: 0x7FFAC9480810
        public void get_MainThreadId(){} // RVA: 0x7FFAC9480870
        public void get_ApplicationDataPath(){} // RVA: 0x7FFAC94808D0
        public void get_IsMainThread(){} // RVA: 0x7FFAC9480930
        public void get_IsEditorApplicationQuitting(){} // RVA: 0x7FFAC94809F0
        public void set_IsEditorApplicationQuitting(){} // RVA: 0x7FFAC9480A50
        public void InsertRunner(){} // RVA: 0x7FFAC9480AB0
        public void RemoveRunner(){} // RVA: 0x7FFAC9481010
        public void InsertUniTaskSynchronizationContext(){} // RVA: 0x7FFAC9481230
        public void Init(){} // RVA: 0x7FFAC9481920
        public void FindLoopSystemIndex(){} // RVA: 0x7FFAC9481C20
        public void InsertLoop(){} // RVA: 0x7FFAC9481D30
        public void Initialize(){} // RVA: 0x7FFAC9482180
        public void AddAction(){} // RVA: 0x7FFAC9483D40
        public void ThrowInvalidLoopTiming(){} // RVA: 0x7FFAC9483DE0
        public void AddContinuation(){} // RVA: 0x7FFAC9483E80
        public void DumpCurrentPlayerLoop(){} // RVA: 0x7FFAC9483F20
        public void IsInjectedUniTaskPlayerLoop(){} // RVA: 0x7FFAC94843B0
        public void .cctor(){} // RVA: 0x7FFAC9484570
    }

    public class PlayerLoopTimer : Object
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
        public System.Action`1<object> timerCallback; // 0x18
        public object state; // 0x20
        public 0x6B1DD918 playerLoopTiming; // 0x28
        public bool periodic; // 0x2C
        public bool isRunning; // 0x2D
        public bool tryStop; // 0x2E
        public bool isDisposed; // 0x2F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9484A40
        public void Create(){} // RVA: 0x7FFAC9484B50
        public void StartNew(){} // RVA: 0x7FFAC9484CE0
        public void Restart(){} // RVA: 0x7FFAC9484EE0 | overloaded x2
        public void Stop(){} // RVA: 0x7FFAC9484FE0
        public void ResetCore(){}
        public void Dispose(){} // RVA: 0x7FFAC9484FF0
        public void Cysharp.Threading.Tasks.IPlayerLoopItem.MoveNext(){} // RVA: 0x7FFAC9485000
        public void MoveNextCore(){} // RVA: 0x7FFAC2C59D00
    }

    public class Progress : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2C58F80
        public void CreateOnlyValueChanged(){} // RVA: 0x7FFAC2C58FF0
    }

    public class ReadOnlyAsyncReactiveProperty`1 : Object
    {
        public Cysharp.Threading.Tasks.TriggerEvent`1<T> Value;
        public T latestValue;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
        public bool isValueType;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ConsumeEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void WithoutCurrent(){} // RVA: 0x7FFAC2C58E90
        public void GetAsyncEnumerator(){}
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void WaitAsync(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class RealtimePlayerLoopTimer : PlayerLoopTimer
    {
        public Cysharp.Threading.Tasks.Internal.ValueStopwatch stopwatch; // 0x30
        public long intervalTicks; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9485690
        public void MoveNextCore(){} // RVA: 0x7FFAC9485760
        public void ResetCore(){} // RVA: 0x7FFAC94857C0
    }

    public class ReturnToMainThread : ValueType
    {
        public 0x6B1DD918 playerLoopTiming; // 0x10
        public System.Threading.CancellationToken cancellationToken; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60F24C0
        public void DisposeAsync(){} // RVA: 0x7FFAC94967F0
    }

    public class ReturnToSynchronizationContext : ValueType
    {
        public System.Threading.SynchronizationContext syncContext; // 0x10
        public bool dontPostWhenSameContext; // 0x18
        public System.Threading.CancellationToken cancellationToken; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9497710
        public void DisposeAsync(){} // RVA: 0x7FFAC94977D0
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        public System.Collections.Generic.Queue`1<T> items;
        public SingleConsumerUnboundedChannelReader<T> readerSource;
        public Cysharp.Threading.Tasks.UniTaskCompletionSource completedTaskSource;
        public Cysharp.Threading.Tasks.UniTask completedTask;
        public System.Exception completionError;
        public bool closed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class StateExtensions : Object
    {
        // ── Methods ──
        public void ToReadOnlyAsyncReactiveProperty(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

    public class SwitchToMainThreadAwaitable : ValueType
    {
        public 0x6B1DD918 playerLoopTiming; // 0x10
        public System.Threading.CancellationToken cancellationToken; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60F24C0
        public void GetAwaiter(){} // RVA: 0x7FFAC94967F0
    }

    public class SwitchToSynchronizationContextAwaitable : ValueType
    {
        public System.Threading.SynchronizationContext synchronizationContext; // 0x10
        public System.Threading.CancellationToken cancellationToken; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60F4340
        public void GetAwaiter(){} // RVA: 0x7FFAC94973C0
    }

    public class SwitchToTaskPoolAwaitable : ValueType
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7FFAC2F21320
    }

    public class SwitchToThreadPoolAwaitable : ValueType
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7FFAC2F21320
    }

    public class TaskPool : Object
    {
        public int MaxPoolSize;
        public System.Collections.Generic.Dictionary`2<System.Type,System.Func`1<int>> sizes; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC94858B0
        public void SetMaxPoolSize(){} // RVA: 0x7FFAC9485AA0
        public void GetCacheSizeInfo(){} // RVA: 0x7FFAC9485B00
        public void RegisterSizeGetter(){} // RVA: 0x7FFAC9485B50
    }

    public class TaskPool`1 : ValueType
    {
        public int Size; // 0x10
        public int size; // 0x14
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask`1<ÌÎÍÍÍÌÌÍÏÌÍÌÍÍÎÎÎÌÎÍÌÏÏ> root; // 0x18

        // ── Methods ──
        public void get_Size(){} // RVA: 0x7FFAC44202A0
        public void TryPop(){} // RVA: 0x7FFAC6728040
        public void TryPush(){} // RVA: 0x7FFAC6AD38E0
    }

    public class TaskTracker : Object
    {
        public System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<Cysharp.Threading.Tasks.IUniTaskSource,System.ValueTuple`4<string,int,System.DateTime,string>>> listPool;
        public Cysharp.Threading.Tasks.Internal.WeakDictionary`2<Cysharp.Threading.Tasks.IUniTaskSource,System.ValueTuple`4<string,int,System.DateTime,string>> tracking; // 0x8
        public bool dirty; // 0x10

        // ── Methods ──
        public void TrackActiveTask(){} // RVA: 0x7FFAC2F21310
        public void RemoveTracking(){} // RVA: 0x7FFAC2F21310
        public void CheckAndResetDirty(){} // RVA: 0x7FFAC947F830
        public void ForEachActiveTask(){} // RVA: 0x7FFAC947F890
        public void TypeBeautify(){} // RVA: 0x7FFAC947FEF0
        public void .cctor(){} // RVA: 0x7FFAC9480200
    }

    public class TextMeshProAsyncExtensions : Object
    {
        // ── Methods ──
        public void BindTo(){} // RVA: 0x7FFAC2C79CB0 | overloaded x5
        public void BindToCore(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetAsyncValueChangedEventHandler(){} // RVA: 0x7FFAC94C5120 | overloaded x2
        public void OnValueChangedAsync(){} // RVA: 0x7FFAC94C52B0 | overloaded x2
        public void OnValueChangedAsAsyncEnumerable(){} // RVA: 0x7FFAC94C5440 | overloaded x2
        public void GetAsyncEndEditEventHandler(){} // RVA: 0x7FFAC94C5580 | overloaded x2
        public void OnEndEditAsync(){} // RVA: 0x7FFAC94C5710 | overloaded x2
        public void OnEndEditAsAsyncEnumerable(){} // RVA: 0x7FFAC94C58A0 | overloaded x2
        public void GetAsyncEndTextSelectionEventHandler(){} // RVA: 0x7FFAC94C5A10 | overloaded x2
        public void OnEndTextSelectionAsync(){} // RVA: 0x7FFAC94C5C00 | overloaded x2
        public void OnEndTextSelectionAsAsyncEnumerable(){} // RVA: 0x7FFAC94C5DF0 | overloaded x2
        public void GetAsyncTextSelectionEventHandler(){} // RVA: 0x7FFAC94C5F90 | overloaded x2
        public void OnTextSelectionAsync(){} // RVA: 0x7FFAC94C6180 | overloaded x2
        public void OnTextSelectionAsAsyncEnumerable(){} // RVA: 0x7FFAC94C6370 | overloaded x2
        public void GetAsyncDeselectEventHandler(){} // RVA: 0x7FFAC94C64E0 | overloaded x2
        public void OnDeselectAsync(){} // RVA: 0x7FFAC94C6670 | overloaded x2
        public void OnDeselectAsAsyncEnumerable(){} // RVA: 0x7FFAC94C6800 | overloaded x2
        public void GetAsyncSelectEventHandler(){} // RVA: 0x7FFAC94C6940 | overloaded x2
        public void OnSelectAsync(){} // RVA: 0x7FFAC94C6AD0 | overloaded x2
        public void OnSelectAsAsyncEnumerable(){} // RVA: 0x7FFAC94C6C60 | overloaded x2
        public void GetAsyncSubmitEventHandler(){} // RVA: 0x7FFAC94C6DA0 | overloaded x2
        public void OnSubmitAsync(){} // RVA: 0x7FFAC94C6F30 | overloaded x2
        public void OnSubmitAsAsyncEnumerable(){} // RVA: 0x7FFAC94C70C0 | overloaded x2
    }

    public class TextSelectionEventConverter : UnityEvent`1
    {
        public UnityEngine.Events.UnityEvent`3<string,int,int> innerEvent; // 0x30
        public UnityEngine.Events.UnityAction`3<string,int,int> invokeDelegate; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94D8870
        public void InvokeCore(){} // RVA: 0x7FFAC94D8A90
        public void Dispose(){} // RVA: 0x7FFAC94D8B80
    }

    public class TimeoutController : Object
    {
        public System.Action`1<object> CancelCancellationTokenSourceStateDelegate;
        public System.Threading.CancellationTokenSource timeoutSource; // 0x10
        public System.Threading.CancellationTokenSource linkedSource; // 0x18
        public Cysharp.Threading.Tasks.PlayerLoopTimer timer; // 0x20
        public bool isDisposed; // 0x28
        public 0x6B1E10C8 delayType; // 0x2C
        public 0x6B1DD918 delayTiming; // 0x30
        public System.Threading.CancellationTokenSource originalLinkCancellationTokenSource; // 0x38

        // ── Methods ──
        public void CancelCancellationTokenSourceState(){} // RVA: 0x7FFAC94865E0
        public void .ctor(){} // RVA: 0x7FFAC9486810 | overloaded x2
        public void Timeout(){} // RVA: 0x7FFAC9486AA0 | overloaded x2
        public void IsTimeout(){} // RVA: 0x7FFAC9486F10
        public void Reset(){} // RVA: 0x7FFAC9486F40
        public void Dispose(){} // RVA: 0x7FFAC9486F50
        public void .cctor(){} // RVA: 0x7FFAC9487060
    }

    public class TriggerEvent`1 : ValueType
    {
        public Cysharp.Threading.Tasks.ITriggerHandler`1<T> head;
        public Cysharp.Threading.Tasks.ITriggerHandler`1<T> iteratingHead;
        public Cysharp.Threading.Tasks.ITriggerHandler`1<T> iteratingNode;

        // ── Methods ──
        public void LogError(){} // RVA: 0x7FFAC2C70A40
        public void SetResult(){} // RVA: 0x7FFAC2E8DC40
        public void SetCanceled(){} // RVA: 0x7FFAC2C70BF0
        public void SetCompleted(){} // RVA: 0x7FFAC2C70980
        public void SetError(){} // RVA: 0x7FFAC2C70A40
        public void Add(){} // RVA: 0x7FFAC2C70A40
        public void Remove(){} // RVA: 0x7FFAC2C70A40
    }

    public class UniTask : ValueType
    {
        public Cysharp.Threading.Tasks.IUniTaskSource Status; // 0x10
        public short token; // 0x18
        public Cysharp.Threading.Tasks.UniTask CanceledUniTask;
        public Cysharp.Threading.Tasks.UniTask CompletedTask; // 0x10

        // ── Methods ──
        public void ToCoroutine(){} // RVA: 0x7FFAC94877A0
        public void .ctor(){} // RVA: 0x7FFAC5122C00
        public void get_Status(){} // RVA: 0x7FFAC94877E0
        public void GetAwaiter(){} // RVA: 0x7FFAC9487840
        public void SuppressCancellationThrow(){} // RVA: 0x7FFAC94878A0
        public void op_Implicit(){} // RVA: 0x7FFAC9487A70
        public void ToString(){} // RVA: 0x7FFAC9487B10
        public void Preserve(){} // RVA: 0x7FFAC9487C00
        public void AsAsyncUnitUniTask(){} // RVA: 0x7FFAC9487D30
        public void Yield(){} // RVA: 0x7FFAC9487FE0 | overloaded x4
        public void NextFrame(){} // RVA: 0x7FFAC9488390 | overloaded x4
        public void WaitForEndOfFrame(){} // RVA: 0x7FFAC9488650 | overloaded x4
        public void WaitForFixedUpdate(){} // RVA: 0x7FFAC9488780 | overloaded x2
        public void WaitForSeconds(){} // RVA: 0x7FFAC94888E0 | overloaded x2
        public void DelayFrame(){} // RVA: 0x7FFAC9488990
        public void Delay(){} // RVA: 0x7FFAC9488E40 | overloaded x4
        public void FromException(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void FromResult(){} // RVA: 0x7FFAC2E8DC40
        public void FromCanceled(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Create(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void Lazy(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
        public void Void(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void Action(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void UnityAction(){} // RVA: 0x7FFAC2C5EA50 | overloaded x11
        public void Defer(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void Never(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Run(){} // RVA: 0x7FFAC2E8DC40 | overloaded x8
        public void RunOnThreadPool(){} // RVA: 0x7FFAC2E8DC40 | overloaded x8
        public void SwitchToMainThread(){} // RVA: 0x7FFAC948AA70 | overloaded x2
        public void ReturnToMainThread(){} // RVA: 0x7FFAC948AA70 | overloaded x2
        public void Post(){} // RVA: 0x7FFAC948AAD0
        public void SwitchToThreadPool(){} // RVA: 0x7FFAC2F21320
        public void SwitchToTaskPool(){} // RVA: 0x7FFAC2F21320
        public void SwitchToSynchronizationContext(){} // RVA: 0x7FFAC948AB30
        public void ReturnToSynchronizationContext(){} // RVA: 0x7FFAC948ABC0
        public void ReturnToCurrentSynchronizationContext(){} // RVA: 0x7FFAC948ABF0
        public void WaitUntil(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void WaitWhile(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void WaitUntilCanceled(){} // RVA: 0x7FFAC948AE30
        public void WaitUntilValueChanged(){} // RVA: 0x7FFAC2E8DC40
        public void WhenAll(){} // RVA: 0x7FFAC2E8DC40 | overloaded x18
        public void WhenAny(){} // RVA: 0x7FFAC2E8DC40 | overloaded x19
        public void WhenEach(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC948B490
    }

    public class UniTaskAsyncEnumerableExtensions : Object
    {
        // ── Methods ──
        public void WithCancellation(){} // RVA: 0x7FFAC2E8DC40
    }

    public class UniTaskCancelableAsyncEnumerable`1 : ValueType
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> enumerable;
        public System.Threading.CancellationToken cancellationToken;

        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){} // RVA: 0x7FFAC2E8DC40
    }

    public class UniTaskCancellationExtensions : Object
    {
        // ── Methods ──
        public void GetCancellationTokenOnDestroy(){} // RVA: 0x7FFAC9487210 | overloaded x3
    }

    public class UniTaskCompletionSource : Object
    {
        public System.Threading.CancellationToken Task; // 0x10
        public Cysharp.Threading.Tasks.ExceptionHolder exception; // 0x18
        public object gate; // 0x20
        public System.Action`1<object> singleContinuation; // 0x28
        public object singleState; // 0x30
        public System.Collections.Generic.List`1<System.ValueTuple`2<System.Action`1<object>,object>> secondaryContinuationList; // 0x38
        public int intStatus; // 0x40
        public bool handled; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void MarkHandled(){} // RVA: 0x7FFAC9498840
        public void get_Task(){} // RVA: 0x7FFAC9498850
        public void TrySetResult(){} // RVA: 0x7FFAC94988B0
        public void TrySetCanceled(){} // RVA: 0x7FFAC94988C0
        public void TrySetException(){} // RVA: 0x7FFAC9498930
        public void GetResult(){} // RVA: 0x7FFAC9498B30
        public void GetStatus(){} // RVA: 0x7FFAC2FC2080
        public void UnsafeGetStatus(){} // RVA: 0x7FFAC2FC2080
        public void OnCompleted(){} // RVA: 0x7FFAC9498C30
        public void TrySignalCompletion(){} // RVA: 0x7FFAC9499050
    }

    public class UniTaskCompletionSourceCoreShared : Object
    {
        public System.Action`1<object> s_sentinel;

        // ── Methods ──
        public void CompletionSentinel(){} // RVA: 0x7FFAC9497C60
        public void .cctor(){} // RVA: 0x7FFAC9497CB0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ Version; // 0x10
        public object error; // 0x18
        public short version; // 0x20
        public bool hasUnhandledError; // 0x22
        public int completedCount; // 0x24
        public System.Action`1<object> continuation; // 0x28
        public object continuationState; // 0x30

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC6D99730
        public void ReportUnhandledError(){} // RVA: 0x7FFAC6D99870
        public void MarkHandled(){} // RVA: 0x7FFAC6D6A2C0
        public void TrySetResult(){} // RVA: 0x7FFAC6D999C0
        public void TrySetException(){} // RVA: 0x7FFAC6D99AC0
        public void TrySetCanceled(){} // RVA: 0x7FFAC6D99D70
        public void get_Version(){} // RVA: 0x7FFAC469AEC0
        public void GetStatus(){} // RVA: 0x7FFAC6D99EB0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAC6D99FF0
        public void GetResult(){} // RVA: 0x7FFAC6D6A960
        public void OnCompleted(){} // RVA: 0x7FFAC6D9A090
        public void ValidateToken(){} // RVA: 0x7FFAC6D6AD20
    }

    public class UniTaskCompletionSource`1 : Object
    {
        public System.Threading.CancellationToken Task;
        public T result;
        public Cysharp.Threading.Tasks.ExceptionHolder exception;
        public object gate;
        public System.Action`1<object> singleContinuation;
        public object singleState;
        public System.Collections.Generic.List`1<System.ValueTuple`2<System.Action`1<object>,object>> secondaryContinuationList;
        public int intStatus;
        public bool handled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void MarkHandled(){} // RVA: 0x7FFAC2C70980
        public void get_Task(){} // RVA: 0x7FFAC2E8DC40
        public void TrySetResult(){} // RVA: 0x7FFAC2E8DC40
        public void TrySetCanceled(){} // RVA: 0x7FFAC2E8DC40
        public void TrySetException(){} // RVA: 0x7FFAC2C59F60
        public void GetResult(){} // RVA: 0x7FFAC2E8DC40
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
        public void GetStatus(){}
        public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
        public void OnCompleted(){}
        public void TrySignalCompletion(){} // RVA: 0x7FFAC2C5A310
    }

    public class UniTaskExtensions : Object
    {
        // ── Methods ──
        public void AsUniTask(){} // RVA: 0x7FFAC94995A0 | overloaded x2
        public void AsTask(){} // RVA: 0x7FFAC9499820 | overloaded x2
        public void ToAsyncLazy(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void AttachExternalCancellation(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ToCoroutine(){} // RVA: 0x7FFAC9499F20 | overloaded x2
        public void Timeout(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void TimeoutWithoutException(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Forget(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void ForgetCoreWithCatch(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ContinueWith(){} // RVA: 0x7FFAC2E8DC40 | overloaded x8
        public void Unwrap(){} // RVA: 0x7FFAC949B4A0 | overloaded x10
        public void GetAwaiter(){} // RVA: 0x7FFAC94A0A00 | overloaded x32
    }

    public class UniTaskLoopRunners : Object
    {
    }

    public class UniTaskObservableExtensions : Object
    {
        // ── Methods ──
        public void ToUniTask(){} // RVA: 0x7FFAC2E8DC40
        public void ToObservable(){} // RVA: 0x7FFAC94C8910 | overloaded x2
        public void Fire(){} // RVA: 0x7FFAC94C8E00 | overloaded x2
    }

    public class UniTaskScheduler : Object
    {
        public System.Action`1<System.Exception> UnobservedTaskException;
        public bool PropagateOperationCanceledException; // 0x8
        public 0x6B179630 UnobservedExceptionWriteLogType; // 0xC
        public bool DispatchUnityMainThread; // 0x10
        public System.Threading.SendOrPostCallback handleExceptionInvoke; // 0x18

        // ── Methods ──
        public void add_UnobservedTaskException(){} // RVA: 0x7FFAC94C92F0
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFAC94C9450
        public void InvokeUnobservedTaskException(){} // RVA: 0x7FFAC94C95B0
        public void PublishUnobservedTaskException(){} // RVA: 0x7FFAC94C9680
        public void .cctor(){} // RVA: 0x7FFAC94C9A30
    }

    public class UniTaskStatusExtensions : Object
    {
        // ── Methods ──
        public void IsCompleted(){} // RVA: 0x7FFAC8515180
        public void IsCompletedSuccessfully(){} // RVA: 0x7FFAC4430B00
        public void IsCanceled(){} // RVA: 0x7FFAC94805C0
        public void IsFaulted(){} // RVA: 0x7FFAC94805D0
    }

    public class UniTaskSynchronizationContext : SynchronizationContext
    {
        public int MaxArrayLength;
        public int InitialSize;
        public System.Threading.SpinLock gate;
        public bool dequing; // 0x4
        public int actionListCount; // 0x8
        public Callback[] actionList; // 0x10
        public int waitingListCount; // 0x18
        public Callback[] waitingList; // 0x20
        public int opCount; // 0x28

        // ── Methods ──
        public void Send(){} // RVA: 0x7FFAC5C5C990
        public void Post(){} // RVA: 0x7FFAC94C9B40
        public void OperationStarted(){} // RVA: 0x7FFAC94CA310
        public void OperationCompleted(){} // RVA: 0x7FFAC94CA370
        public void CreateCopy(){} // RVA: 0x7FFAC44F81E0
        public void Run(){} // RVA: 0x7FFAC94CA3D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC94CA7E0
    }

    public class UniTaskValueTaskExtensions : Object
    {
        // ── Methods ──
        public void AsValueTask(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void AsUniTask(){} // RVA: 0x7FFAC94873A0 | overloaded x2
    }

    public class UniTaskVoid : ValueType
    {
        // ── Methods ──
        public void Forget(){} // RVA: 0x7FFAC2F21310
    }

    public class UniTask`1 : ValueType
    {
        public Cysharp.Threading.Tasks.IUniTaskSource`1<T> Status;
        public T result;
        public short token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void get_Status(){} // RVA: 0x7FFAC2C59960
        public void GetAwaiter(){} // RVA: 0x7FFAC2E8DC40
        public void Preserve(){} // RVA: 0x7FFAC2E8DC40
        public void AsUniTask(){} // RVA: 0x7FFAC2C588A0
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SuppressCancellationThrow(){} // RVA: 0x7FFAC2E8DC40
        public void ToString(){} // RVA: 0x7FFAC2C58E90
    }

    public class UnityAsyncExtensions : Object
    {
        // ── Methods ──
        public void AwaitForAllAssets(){} // RVA: 0x7FFAC94CAB00 | overloaded x4
        public void GetAwaiter(){} // RVA: 0x7FFAC94CC640 | overloaded x7
        public void WithCancellation(){} // RVA: 0x7FFAC94CC0E0 | overloaded x12
        public void ToUniTask(){} // RVA: 0x7FFAC94CC840 | overloaded x7
        public void WaitAsync(){} // RVA: 0x7FFAC94CC4C0
        public void StartAsyncCoroutine(){} // RVA: 0x7FFAC94CC970
        public void GetAsyncEventHandler(){} // RVA: 0x7FFAC2C5EA50 | overloaded x2
        public void OnInvokeAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void OnInvokeAsAsyncEnumerable(){} // RVA: 0x7FFAC2C5EA50 | overloaded x2
        public void GetAsyncClickEventHandler(){} // RVA: 0x7FFAC94CCBF0 | overloaded x2
        public void OnClickAsync(){} // RVA: 0x7FFAC94CCD40 | overloaded x2
        public void OnClickAsAsyncEnumerable(){} // RVA: 0x7FFAC94CCE80 | overloaded x2
        public void GetAsyncValueChangedEventHandler(){} // RVA: 0x7FFAC94CE970 | overloaded x12
        public void OnValueChangedAsync(){} // RVA: 0x7FFAC94CEAF0 | overloaded x12
        public void OnValueChangedAsAsyncEnumerable(){} // RVA: 0x7FFAC94CEC70 | overloaded x12
        public void GetAsyncEndEditEventHandler(){} // RVA: 0x7FFAC94CE0B0 | overloaded x2
        public void OnEndEditAsync(){} // RVA: 0x7FFAC94CE240 | overloaded x2
        public void OnEndEditAsAsyncEnumerable(){} // RVA: 0x7FFAC94CE3D0 | overloaded x2
    }

    public class UnityBindingExtensions : Object
    {
        // ── Methods ──
        public void BindTo(){} // RVA: 0x7FFAC2E8DC40 | overloaded x9
        public void BindToCore(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
    }

    public class UnityEventHandlerAsyncEnumerable : Object
    {
        public UnityEngine.Events.UnityEvent unityEvent; // 0x10
        public System.Threading.CancellationToken cancellationToken1; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC586E150
        public void GetAsyncEnumerator(){} // RVA: 0x7FFAC94D9450
    }

    public class UnityEventHandlerAsyncEnumerable`1 : Object
    {
        public UnityEngine.Events.UnityEvent`1<T> unityEvent;
        public System.Threading.CancellationToken cancellationToken1;

        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){}
    }

    public class UnityWebRequestException : Exception
    {
        public UnityEngine.Networking.UnityWebRequest UnityWebRequest; // 0x90
        public 0x6B2CE268 Result; // 0x98
        public string Error; // 0xA0
        public string Text; // 0xA8
        public long ResponseCode; // 0xB0
        public System.Collections.Generic.Dictionary`2<string,string> ResponseHeaders; // 0xB8
        public string Message; // 0xC0

        // ── Methods ──
        public void get_UnityWebRequest(){} // RVA: 0x7FFAC32EF640
        public void get_Result(){} // RVA: 0x7FFAC489E530
        public void get_Error(){} // RVA: 0x7FFAC3543900
        public void get_Text(){} // RVA: 0x7FFAC354B1A0
        public void get_ResponseCode(){} // RVA: 0x7FFAC2F8C040
        public void get_ResponseHeaders(){} // RVA: 0x7FFAC2F8C0B0
        public void .ctor(){} // RVA: 0x7FFAC94DB900
        public void get_Message(){} // RVA: 0x7FFAC94DBBE0
    }

    public class WhenEachEnumerable`1 : Object
    {
        public System.Collections.Generic.IEnumerable`1<Cysharp.Threading.Tasks.UniTask`1<T>> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetAsyncEnumerator(){}
    }

    public class WhenEachResult`1 : ValueType
    {
        public T Result;
        public System.Exception Exception;

        // ── Methods ──
        public void get_Result(){} // RVA: 0x7FFAC2E8DC40
        public void get_Exception(){} // RVA: 0x7FFAC2C58E90
        public void get_IsCompletedSuccessfully(){} // RVA: 0x7FFAC2C59D00
        public void get_IsFaulted(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void TryThrow(){} // RVA: 0x7FFAC2C70980
        public void GetResult(){} // RVA: 0x7FFAC2E8DC40
        public void ToString(){} // RVA: 0x7FFAC2C58E90
    }

    public class YieldAwaitable : ValueType
    {
        public 0x6B1DD918 timing; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC336D8B0
        public void GetAwaiter(){} // RVA: 0x7FFAC4420210
        public void ToUniTask(){} // RVA: 0x7FFAC9496090
    }

}