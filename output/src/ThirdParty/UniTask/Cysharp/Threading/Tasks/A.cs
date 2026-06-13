// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 11
// Methods: 119

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
        public System.Action`1<object> continuation;

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
        public System.Action`1<object> IsCompleted;

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
        public Cysharp.Threading.Tasks.TriggerEvent`1<T> triggerEvent;

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
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource> pool;
        public Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource nextNode; // 0x10

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
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource`1<T>> pool;
        public Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource`1<T> nextNode;

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

    public class AutoResetUniTaskCompletionSource`1
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource`1<UnityEngine.Networking.UnityWebRequest>> pool;
        public Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource`1<UnityEngine.Networking.UnityWebRequest> nextNode; // 0x10

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x3DF6A30
        public void .cctor(){} // RVA: 0x557CFD0
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x557D1B0
        public void CreateFromCanceled(){} // RVA: 0x557D310
        public void CreateFromException(){} // RVA: 0x557D420
        public void CreateFromResult(){} // RVA: 0x557D530
        public void get_Task(){} // RVA: 0x557D640
        public void TrySetResult(){} // RVA: 0x557D6B0
        public void TrySetCanceled(){} // RVA: 0x557D6E0
        public void TrySetException(){} // RVA: 0x557D710
        public void GetResult(){} // RVA: 0x557D740
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x557D8B0
        public void GetStatus(){} // RVA: 0x557D8D0
        public void UnsafeGetStatus(){} // RVA: 0x557D8F0
        public void OnCompleted(){} // RVA: 0x557D910
        public void TryReturn(){} // RVA: 0x557D940
    }

    public class AwaiterActions
    {
        // ── Methods ──
        public void Continuation(){} // RVA: 0x6CFD7E0
        public void .cctor(){} // RVA: 0x6CFD850
    }

}