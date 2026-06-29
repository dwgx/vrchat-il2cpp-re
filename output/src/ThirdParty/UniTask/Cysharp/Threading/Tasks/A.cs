// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 11
// Methods: 111

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class AsyncInstantiateOperationExtensions : Object
    {
        // ── Methods ──
        public void WithCancellation(){} // RVA: 0xA94080
        public void ToUniTask(){} // RVA: 0xA94080
    }

    public class AsyncLazy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x77413A0
        public void get_Task(){} // RVA: 0x7741730
        public void GetAwaiter(){} // RVA: 0x77417E0
        public void EnsureInitialized(){} // RVA: 0x7741950
        public void EnsureInitializedCore(){} // RVA: 0x7741980
        public void SetCompletionSource(){} // RVA: 0x7741D20
        public void .cctor(){} // RVA: 0x7741ED0
    }

    public class AsyncLazy`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void get_Task(){} // RVA: 0xA94080
        public void GetAwaiter(){} // RVA: 0xA94080
        public void EnsureInitialized(){} // RVA: 0x894290
        public void EnsureInitializedCore(){} // RVA: 0x894290
        public void SetCompletionSource(){} // RVA: 0x894350
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class AsyncReactiveProperty`1 : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xA94080
        public void set_Value(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xA94080
        public void WithoutCurrent(){} // RVA: 0x87C0A0
        public void GetAsyncEnumerator(){} // RVA: 0x881D60
        public void Dispose(){} // RVA: 0x894290
        public void op_Implicit(){} // RVA: 0xA94080
        public void ToString(){} // RVA: 0x87C0A0
        public void WaitAsync(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class AsyncUnit : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x99090
        public void Equals(){} // RVA: 0x318130
        public void ToString(){} // RVA: 0x91FC50
        public void .cctor(){} // RVA: 0xB43310
    }

    public class AsyncUnityEventHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x779EE30
        public void OnInvokeAsync(){} // RVA: 0x779F120
        public void Invoke(){} // RVA: 0x779F210
        public void CancellationCallback(){} // RVA: 0x779F290
        public void Dispose(){} // RVA: 0x779F310
        public void Cysharp.Threading.Tasks.IAsyncClickEventHandler.OnClickAsync(){} // RVA: 0x779F3C0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x779F3F0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){} // RVA: 0x779F490
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x779F4E0
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){} // RVA: 0x779F520
        public void .cctor(){} // RVA: 0x779F5A0
    }

    public class AsyncUnityEventHandler`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void OnInvokeAsync(){} // RVA: 0xA94080
        public void Invoke(){} // RVA: 0xA94080
        public void CancellationCallback(){} // RVA: 0x894350
        public void Dispose(){} // RVA: 0x894290
        public void Cysharp.Threading.Tasks.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync(){} // RVA: 0xA94080
        public void Cysharp.Threading.Tasks.IAsyncEndEditEventHandler<T>.OnEndEditAsync(){} // RVA: 0xA94080
        public void Cysharp.Threading.Tasks.IAsyncEndTextSelectionEventHandler<T>.OnEndTextSelectionAsync(){} // RVA: 0xA94080
        public void Cysharp.Threading.Tasks.IAsyncTextSelectionEventHandler<T>.OnTextSelectionAsync(){} // RVA: 0xA94080
        public void Cysharp.Threading.Tasks.IAsyncDeselectEventHandler<T>.OnDeselectAsync(){} // RVA: 0xA94080
        public void Cysharp.Threading.Tasks.IAsyncSelectEventHandler<T>.OnSelectAsync(){} // RVA: 0xA94080
        public void Cysharp.Threading.Tasks.IAsyncSubmitEventHandler<T>.OnSubmitAsync(){} // RVA: 0xA94080
        public void Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(){} // RVA: 0xA94080
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){} // RVA: 0x87D010
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x87C130
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){} // RVA: 0x89DD60
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class AutoResetUniTaskCompletionSource : Object
    {
        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x4865E00
        public void .cctor(){} // RVA: 0x775D840
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x775D980
        public void CreateFromCanceled(){} // RVA: 0x775DA40
        public void CreateFromException(){} // RVA: 0x775DB20
        public void CreateCompleted(){} // RVA: 0x775DC00
        public void get_Task(){} // RVA: 0x775DC90
        public void TrySetResult(){} // RVA: 0x775DD30
        public void TrySetCanceled(){} // RVA: 0x775DDD0
        public void TrySetException(){} // RVA: 0x775DE40
        public void GetResult(){} // RVA: 0x775DEC0
        public void GetStatus(){} // RVA: 0x775DFF0
        public void UnsafeGetStatus(){} // RVA: 0x775E040
        public void OnCompleted(){} // RVA: 0x775E080
        public void TryReturn(){} // RVA: 0x775E100
    }

    public class AutoResetUniTaskCompletionSource`1 : Object
    {
        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x87C0A0
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void Create(){} // RVA: 0x87C0D0
        public void CreateFromCanceled(){} // RVA: 0xA94080
        public void CreateFromException(){} // RVA: 0x87C630
        public void CreateFromResult(){} // RVA: 0xA94080
        public void get_Task(){} // RVA: 0xA94080
        public void TrySetResult(){} // RVA: 0xA94080
        public void TrySetCanceled(){} // RVA: 0xA94080
        public void TrySetException(){} // RVA: 0x87D350
        public void GetResult(){} // RVA: 0xA94080
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
        public void GetStatus(){} // RVA: 0x87D010
        public void UnsafeGetStatus(){} // RVA: 0x87C130
        public void OnCompleted(){} // RVA: 0x89DD60
        public void TryReturn(){} // RVA: 0x87D280
    }

    public class AutoResetUniTaskCompletionSource`1 : Object
    {
        // ── Methods ──
        public void CreateFromCanceled(){} // RVA: 0x609D4F0
        public void get_NextNode(){} // RVA: 0x4865E00
        public void .cctor(){} // RVA: 0x609D1F0
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x609D390
        public void CreateFromException(){} // RVA: 0x609D600
        public void CreateFromResult(){} // RVA: 0x609D710
        public void get_Task(){} // RVA: 0x609D820
        public void TrySetResult(){} // RVA: 0x609D890
        public void TrySetCanceled(){} // RVA: 0x609D8C0
        public void TrySetException(){} // RVA: 0x609D8F0
        public void GetResult(){} // RVA: 0x609D920
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x609DA80
        public void GetStatus(){} // RVA: 0x609DAA0
        public void UnsafeGetStatus(){} // RVA: 0x609DAC0
        public void OnCompleted(){} // RVA: 0x609DAE0
        public void TryReturn(){} // RVA: 0x609DB10
    }

    public class AwaiterActions : Object
    {
        // ── Methods ──
        public void Continuation(){} // RVA: 0x775B9F0
        public void .cctor(){} // RVA: 0x775BA60
    }

}