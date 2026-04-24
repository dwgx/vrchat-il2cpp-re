// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 9
// Methods: 91

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class AsyncInstantiateOperationExtensions : Object
    {
        // ── Original Methods ──
        public void WithCancellation(){} // RVA: 0x7ffaa887e5c0
        public void WithCancellation(){} // RVA: 0x7ffaa887e5c0
        public void ToUniTask(){} // RVA: 0x7ffaa887e5c0
        public void WithCancellation(){} // RVA: 0x7ffaa887e5c0
        public void WithCancellation(){} // RVA: 0x7ffaa887e5c0
        public void ToUniTask(){} // RVA: 0x7ffaa887e5c0
    }

    public class AsyncLazy : Object
    {
        public object completionSource; // 0x32E71130
        public object initialized; // 0x32E71130
        public object Task; // 0x17000002
        public object continuation; // 0x30D40930

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaee9d180
        public void .ctor(){} // RVA: 0x7ffaaee9d180
        public void get_Task(){} // RVA: 0x7ffaaee9d510
        public void EnsureInitialized(){} // RVA: 0x7ffaaee9d730
        public void EnsureInitializedCore(){} // RVA: 0x7ffaaee9d760
        public void .cctor(){} // RVA: 0x7ffaaee9dcd0
        // ── Binary Analysis Named ──
        public void GetAwaiter(){} // RVA: 0x7ffaaee9d5c0
        public void SetCompletionSource(){} // RVA: 0x7ffaaee9db30
        public void SetCompletionSource(){} // RVA: 0x7ffaaee9db30
    }

    public class AsyncLazy`1 : Object
    {
        public object completionSource; // 0x30D40930
        public object initialized; // 0x30D40930
        public object Task; // 0x17000003
        public object Cysharp.Threading.Tasks; // 0xB40BDC30

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void get_Task(){} // RVA: 0x7ffaa887e5c0
        public void EnsureInitialized(){} // RVA: 0x7ffaa8660cc0
        public void EnsureInitializedCore(){} // RVA: 0x7ffaa8660cc0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetAwaiter(){} // RVA: 0x7ffaa887e5c0
        public void SetCompletionSource(){} // RVA: 0x7ffaa8660d50
        public void SetCompletionSource(){} // RVA: 0x7ffaa8660d50
    }

    public class AsyncReactiveProperty`1 : Object
    {
        public object isValueType; // 0x30B41DD0
        public object Value; // 0x17000006

        // ── Original Methods ──
        public void get_Value(){} // RVA: 0x7ffaa887e5c0
        public void set_Value(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void WithoutCurrent(){} // RVA: 0x7ffaa86491d0
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void op_Implicit(){} // RVA: 0x7ffaa887e5c0
        public void ToString(){} // RVA: 0x7ffaa86491d0
        public void WaitAsync(){} // RVA: 0x7ffaa887e5c0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetAsyncEnumerator(){}
    }

    public class AsyncUnit : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa8a17850
        public void ToString(){} // RVA: 0x7ffaaee9ddb0
        public void .cctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa8f22da0
    }

    public class AsyncUnityEventHandler`1 : Object
    {
        public object unityEvent; // 0x30D422A0
        public object isDisposed; // 0x30D422A0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void OnInvokeAsync(){} // RVA: 0x7ffaa887e5c0
        public void Invoke(){} // RVA: 0x7ffaa887e5c0
        public void CancellationCallback(){} // RVA: 0x7ffaa8660d50
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void Cysharp.Threading.Tasks.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync(){} // RVA: 0x7ffaa887e5c0
        public void Cysharp.Threading.Tasks.IAsyncEndEditEventHandler<T>.OnEndEditAsync(){} // RVA: 0x7ffaa887e5c0
        public void Cysharp.Threading.Tasks.IAsyncEndTextSelectionEventHandler<T>.OnEndTextSelectionAsync(){} // RVA: 0x7ffaa887e5c0
        public void Cysharp.Threading.Tasks.IAsyncTextSelectionEventHandler<T>.OnTextSelectionAsync(){} // RVA: 0x7ffaa887e5c0
        public void Cysharp.Threading.Tasks.IAsyncDeselectEventHandler<T>.OnDeselectAsync(){} // RVA: 0x7ffaa887e5c0
        public void Cysharp.Threading.Tasks.IAsyncSelectEventHandler<T>.OnSelectAsync(){} // RVA: 0x7ffaa887e5c0
        public void Cysharp.Threading.Tasks.IAsyncSubmitEventHandler<T>.OnSubmitAsync(){} // RVA: 0x7ffaa887e5c0
        public void Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(){} // RVA: 0x7ffaa887e5c0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){}
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){}
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class AutoResetUniTaskCompletionSource : Object
    {
        public object core; // 0x36120F00

        // ── Original Methods ──
        public void get_NextNode(){} // RVA: 0x7ffaac125af0
        public void .cctor(){} // RVA: 0x7ffaaeeb9d60
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Create(){} // RVA: 0x7ffaaeeb9ee0
        public void CreateFromCanceled(){} // RVA: 0x7ffaaeeb9fa0
        public void CreateFromException(){} // RVA: 0x7ffaaeeba080
        public void CreateCompleted(){} // RVA: 0x7ffaaeeba160
        public void get_Task(){} // RVA: 0x7ffaaeeba1f0
        public void TrySetResult(){} // RVA: 0x7ffaaeeba290
        public void TrySetCanceled(){} // RVA: 0x7ffaaeeba330
        public void TrySetException(){} // RVA: 0x7ffaaeeba3a0
        public void UnsafeGetStatus(){} // RVA: 0x7ffaaeeba5a0
        public void OnCompleted(){} // RVA: 0x7ffaaeeba5e0
        public void TryReturn(){} // RVA: 0x7ffaaeeba660
        // ── Binary Analysis Named ──
        public void GetResult(){} // RVA: 0x7ffaaeeba420
        public void GetStatus(){} // RVA: 0x7ffaaeeba550
    }

    public class AutoResetUniTaskCompletionSource`1 : Object
    {
        public object core; // 0x30B281B0

        // ── Original Methods ──
        public void get_NextNode(){} // RVA: 0x7ffaa86491d0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void Create(){} // RVA: 0x7ffaa8648dd0
        public void CreateFromCanceled(){} // RVA: 0x7ffaa887e5c0
        public void CreateFromException(){} // RVA: 0x7ffaa8649330
        public void CreateFromResult(){} // RVA: 0x7ffaa887e5c0
        public void get_Task(){} // RVA: 0x7ffaa887e5c0
        public void TrySetResult(){} // RVA: 0x7ffaa887e5c0
        public void TrySetCanceled(){} // RVA: 0x7ffaa887e5c0
        public void TrySetException(){} // RVA: 0x7ffaa864a2a0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
        public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
        public void OnCompleted(){}
        public void TryReturn(){} // RVA: 0x7ffaa864a040
        // ── Binary Analysis Named ──
        public void GetResult(){} // RVA: 0x7ffaa887e5c0
        public void GetStatus(){}
    }

    public class AwaiterActions : Object
    {
        // ── Original Methods ──
        public void Continuation(){} // RVA: 0x7ffaaeeb7f10
        public void .cctor(){} // RVA: 0x7ffaaeeb7f80
    }

}