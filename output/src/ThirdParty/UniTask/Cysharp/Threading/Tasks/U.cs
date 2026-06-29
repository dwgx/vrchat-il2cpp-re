// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 100
// Methods: 537

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class UniTask : ValueType
    {
        public object source;
        public object token;
        public object CanceledUniTask;
        public object CompletedTask;

        // ── Methods ──
        public void ToCoroutine(){} // RVA: 0x774D080
        public void .ctor(){} // RVA: 0x91FF40
        public void get_Status(){} // RVA: 0x91FFA0
        public void GetAwaiter(){} // RVA: 0x8AEF40
        public void SuppressCancellationThrow(){} // RVA: 0x920000
        public void op_Implicit(){} // RVA: 0x774D350
        public void ToString(){} // RVA: 0x920030
        public void Preserve(){} // RVA: 0x920040
        public void AsAsyncUnitUniTask(){} // RVA: 0x920070
        public void Yield(){} // RVA: 0x774D8D0
        public void NextFrame(){} // RVA: 0x774DC90
        public void WaitForEndOfFrame(){} // RVA: 0x774DFB0
        public void WaitForFixedUpdate(){} // RVA: 0x774E0E0
        public void WaitForSeconds(){} // RVA: 0x774E240
        public void DelayFrame(){} // RVA: 0x774E2F0
        public void Delay(){} // RVA: 0x774E7A0
        public void FromException(){} // RVA: 0x2AC3530
        public void FromResult(){} // RVA: 0x2AC5290
        public void FromCanceled(){} // RVA: 0x2AC2A90
        public void Create(){} // RVA: 0xA94080
        public void Lazy(){} // RVA: 0x87C5C0
        public void Void(){} // RVA: 0xA94080
        public void Action(){} // RVA: 0xA94080
        public void UnityAction(){} // RVA: 0x882000
        public void Defer(){} // RVA: 0xA94080
        public void Never(){} // RVA: 0xA94080
        public void Run(){} // RVA: 0xA94080
        public void RunOnThreadPool(){} // RVA: 0xA94080
        public void SwitchToMainThread(){} // RVA: 0x77503C0
        public void ReturnToMainThread(){} // RVA: 0x77503C0
        public void Post(){} // RVA: 0x7750420
        public void SwitchToThreadPool(){} // RVA: 0xB43320
        public void SwitchToTaskPool(){} // RVA: 0xB43320
        public void SwitchToSynchronizationContext(){} // RVA: 0x7750480
        public void ReturnToSynchronizationContext(){} // RVA: 0x7750510
        public void ReturnToCurrentSynchronizationContext(){} // RVA: 0x7750540
        public void WaitUntil(){} // RVA: 0xA94080
        public void WaitWhile(){} // RVA: 0xA94080
        public void WaitUntilCanceled(){} // RVA: 0x7750780
        public void WaitUntilValueChanged(){} // RVA: 0xA94080
        public void WhenAll(){} // RVA: 0x2AC7B80
        public void WhenAny(){} // RVA: 0x2ADB610
        public void WhenEach(){} // RVA: 0x87C5C0
        public void .cctor(){} // RVA: 0x7750E00
    }

    public class UniTaskCompletionSource`1 : Object
    {
        public object cancellationToken;
        public object result;
        public object exception;
        public object gate;
        public object singleContinuation;
        public object singleState;
        public object secondaryContinuationList;
        public object intStatus;
        public object handled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Task(){} // RVA: 0x5026580
    }

    public class UniTaskCompletionSource`1 : Object
    {
        public object cancellationToken;
        public object result;
        public object exception;
        public object gate;
        public object singleContinuation;
        public object singleState;
        public object secondaryContinuationList;
        public object intStatus;
        public object handled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Task(){} // RVA: 0x502A960
    }

    public class UniTaskCompletionSource`1 : Object
    {
        public object cancellationToken;
        public object result;
        public object exception;
        public object gate;
        public object singleContinuation;
        public object singleState;
        public object secondaryContinuationList;
        public object intStatus;
        public object handled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Task(){} // RVA: 0x5026580
    }

    public class UniTaskCompletionSource`1 : Object
    {
        public object cancellationToken;
        public object result;
        public object exception;
        public object gate;
        public object singleContinuation;
        public object singleState;
        public object secondaryContinuationList;
        public object intStatus;
        public object handled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Task(){} // RVA: 0x502A960
    }

    public class UniTaskCompletionSource`1 : Object
    {
        public object cancellationToken;
        public object result;
        public object exception;
        public object gate;
        public object singleContinuation;
        public object singleState;
        public object secondaryContinuationList;
        public object intStatus;
        public object handled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Task(){} // RVA: 0x5026580
    }

    public class UniTaskCompletionSource`1 : Object
    {
        public object cancellationToken;
        public object result;
        public object exception;
        public object gate;
        public object singleContinuation;
        public object singleState;
        public object secondaryContinuationList;
        public object intStatus;
        public object handled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Task(){} // RVA: 0x502A960
        public void TrySetException(){} // RVA: 0x502B7E0
        public void TrySetResult(){} // RVA: 0x502B700
        public void MarkHandled(){} // RVA: 0x5028DB0
        public void TrySetCanceled(){} // RVA: 0x502B770
        public void GetResult(){} // RVA: 0x502AD00
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x50291C0
        public void GetStatus(){} // RVA: 0xBE5890
        public void UnsafeGetStatus(){} // RVA: 0xBE5890
        public void OnCompleted(){} // RVA: 0x502B9F0
        public void TrySignalCompletion(){} // RVA: 0x502BDE0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void .ctor(){} // RVA: 0x5A3D80
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x899B50
        public void get_Status(){} // RVA: 0x87C130
        public void GetAwaiter(){} // RVA: 0xA94080
        public void Preserve(){} // RVA: 0xA94080
        public void AsUniTask(){} // RVA: 0x87BEB0
        public void op_Implicit(){} // RVA: 0xA94080
        public void SuppressCancellationThrow(){} // RVA: 0xA94080
        public void ToString(){} // RVA: 0x87C0A0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A1E10
        public void get_Status(){} // RVA: 0x59C6A0
        public void GetAwaiter(){} // RVA: 0x571AC0
        public void Preserve(){} // RVA: 0x5A1E70
        public void AsUniTask(){} // RVA: 0x5A3170
        public void op_Implicit(){} // RVA: 0x508A5A0
        public void SuppressCancellationThrow(){} // RVA: 0x5A31A0
        public void ToString(){} // RVA: 0x5A31D0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x59C640
        public void get_Status(){} // RVA: 0x59C6A0
        public void GetAwaiter(){} // RVA: 0x571AC0
        public void Preserve(){} // RVA: 0x59C6B0
        public void AsUniTask(){} // RVA: 0x59C9C0
        public void op_Implicit(){} // RVA: 0x507CBE0
        public void SuppressCancellationThrow(){} // RVA: 0x59C870
        public void ToString(){} // RVA: 0x59C9F0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
        public void get_Status(){} // RVA: 0x560F60
        public void GetAwaiter(){} // RVA: 0x560F70
        public void Preserve(){} // RVA: 0x561020
        public void AsUniTask(){} // RVA: 0x59D320
        public void op_Implicit(){} // RVA: 0x507E8B0
        public void SuppressCancellationThrow(){} // RVA: 0x59D350
        public void ToString(){} // RVA: 0x59D390
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
        public void get_Status(){} // RVA: 0x560F60
        public void GetAwaiter(){} // RVA: 0x560F70
        public void Preserve(){} // RVA: 0x561020
        public void AsUniTask(){} // RVA: 0x59D320
        public void op_Implicit(){} // RVA: 0x507E8B0
        public void SuppressCancellationThrow(){} // RVA: 0x59D350
        public void ToString(){} // RVA: 0x59D390
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
        public void get_Status(){} // RVA: 0x560F60
        public void GetAwaiter(){} // RVA: 0x560F70
        public void Preserve(){} // RVA: 0x561020
        public void AsUniTask(){} // RVA: 0x59D320
        public void op_Implicit(){} // RVA: 0x507E8B0
        public void SuppressCancellationThrow(){} // RVA: 0x59D350
        public void ToString(){} // RVA: 0x59D390
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x562B90
        public void get_Status(){} // RVA: 0x562C00
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x562C10
        public void AsUniTask(){} // RVA: 0x5A4A90
        public void op_Implicit(){} // RVA: 0x5036010
        public void SuppressCancellationThrow(){} // RVA: 0x562DE0
        public void ToString(){} // RVA: 0x5A4AC0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
        public void get_Status(){} // RVA: 0x560F60
        public void GetAwaiter(){} // RVA: 0x560F70
        public void Preserve(){} // RVA: 0x561020
        public void AsUniTask(){} // RVA: 0x59FA60
        public void op_Implicit(){} // RVA: 0x5031C20
        public void SuppressCancellationThrow(){} // RVA: 0x59FA90
        public void ToString(){} // RVA: 0x59FAD0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x568290
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
        public void get_Status(){} // RVA: 0x560F60
        public void GetAwaiter(){} // RVA: 0x560F70
        public void Preserve(){} // RVA: 0x561020
        public void AsUniTask(){} // RVA: 0x59D320
        public void op_Implicit(){} // RVA: 0x507E8B0
        public void SuppressCancellationThrow(){} // RVA: 0x59D350
        public void ToString(){} // RVA: 0x59D390
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
        public void get_Status(){} // RVA: 0x560F60
        public void GetAwaiter(){} // RVA: 0x560F70
        public void Preserve(){} // RVA: 0x561020
        public void AsUniTask(){} // RVA: 0x59D320
        public void op_Implicit(){} // RVA: 0x507E8B0
        public void SuppressCancellationThrow(){} // RVA: 0x59D350
        public void ToString(){} // RVA: 0x59D390
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560A50
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x561420
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x59F400
        public void op_Implicit(){} // RVA: 0x5032500
        public void SuppressCancellationThrow(){} // RVA: 0x561560
        public void ToString(){} // RVA: 0x59F430
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x562B90
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x586340
        public void get_Status(){} // RVA: 0x5863A0
        public void GetAwaiter(){} // RVA: 0x571AC0
        public void Preserve(){} // RVA: 0x5863B0
        public void AsUniTask(){} // RVA: 0x5A3820
        public void op_Implicit(){} // RVA: 0x508B540
        public void SuppressCancellationThrow(){} // RVA: 0x5A36C0
        public void ToString(){} // RVA: 0x5A3850
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
        public void get_Status(){} // RVA: 0x560F60
        public void GetAwaiter(){} // RVA: 0x560F70
        public void Preserve(){} // RVA: 0x561020
        public void AsUniTask(){} // RVA: 0x59D320
        public void op_Implicit(){} // RVA: 0x507E8B0
        public void SuppressCancellationThrow(){} // RVA: 0x59D350
        public void ToString(){} // RVA: 0x59D390
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560A50
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x561420
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5616D0
        public void op_Implicit(){} // RVA: 0x5032500
        public void SuppressCancellationThrow(){} // RVA: 0x561560
        public void ToString(){} // RVA: 0x561700
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x562B90
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560A50
        public void get_Status(){} // RVA: 0x560A60
        public void GetAwaiter(){} // RVA: 0x560A70
        public void Preserve(){} // RVA: 0x560B40
        public void AsUniTask(){} // RVA: 0x5A4F80
        public void op_Implicit(){} // RVA: 0x50335A0
        public void SuppressCancellationThrow(){} // RVA: 0x561B50
        public void ToString(){} // RVA: 0x5A4FB0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x561E40
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x561E40
        public void get_Status(){} // RVA: 0x561EB0
        public void GetAwaiter(){} // RVA: 0x59EA70
        public void Preserve(){} // RVA: 0x561F00
        public void AsUniTask(){} // RVA: 0x5A4E10
        public void op_Implicit(){} // RVA: 0x5079CA0
        public void SuppressCancellationThrow(){} // RVA: 0x59B380
        public void ToString(){} // RVA: 0x5A4E40
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x563690
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
        public void get_Status(){} // RVA: 0x560F60
        public void GetAwaiter(){} // RVA: 0x560F70
        public void Preserve(){} // RVA: 0x561020
        public void AsUniTask(){} // RVA: 0x59D320
        public void op_Implicit(){} // RVA: 0x507E8B0
        public void SuppressCancellationThrow(){} // RVA: 0x59D350
        public void ToString(){} // RVA: 0x59D390
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560A50
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x5A3D90
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x5A3DA0
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void SuppressCancellationThrow(){} // RVA: 0x5A3DD0
        public void ToString(){} // RVA: 0x5A3E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
        public void get_Status(){} // RVA: 0x561420
        public void GetAwaiter(){} // RVA: 0x561430
        public void Preserve(){} // RVA: 0x5614F0
        public void AsUniTask(){} // RVA: 0x59CDB0
        public void op_Implicit(){} // RVA: 0x5032500
        public void SuppressCancellationThrow(){} // RVA: 0x561560
        public void ToString(){} // RVA: 0x59CDE0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x562B90
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x586340
        public void get_Status(){} // RVA: 0x5863A0
        public void GetAwaiter(){} // RVA: 0x571AC0
        public void Preserve(){} // RVA: 0x5863B0
        public void AsUniTask(){} // RVA: 0x5A3690
        public void op_Implicit(){} // RVA: 0x508B540
        public void SuppressCancellationThrow(){} // RVA: 0x5A36C0
        public void ToString(){} // RVA: 0x5A3700
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
        public void get_Status(){} // RVA: 0x560F60
        public void GetAwaiter(){} // RVA: 0x560F70
        public void Preserve(){} // RVA: 0x561020
        public void AsUniTask(){} // RVA: 0x5A5DE0
        public void op_Implicit(){} // RVA: 0x507E8B0
        public void SuppressCancellationThrow(){} // RVA: 0x59D350
        public void ToString(){} // RVA: 0x5A5E10
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560A50
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560A50
        public void get_Status(){} // RVA: 0x560A60
        public void GetAwaiter(){} // RVA: 0x560A70
        public void Preserve(){} // RVA: 0x560B40
        public void AsUniTask(){} // RVA: 0x5A1AD0
        public void op_Implicit(){} // RVA: 0x50870D0
        public void SuppressCancellationThrow(){} // RVA: 0x5A09A0
        public void ToString(){} // RVA: 0x5A1B00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x561E40
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
        public void get_Status(){} // RVA: 0x560F60
        public void GetAwaiter(){} // RVA: 0x560F70
        public void Preserve(){} // RVA: 0x561020
        public void AsUniTask(){} // RVA: 0x59F160
        public void op_Implicit(){} // RVA: 0x507E8B0
        public void SuppressCancellationThrow(){} // RVA: 0x59D350
        public void ToString(){} // RVA: 0x59F190
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560A50
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x563690
        public void get_Status(){} // RVA: 0x5636A0
        public void GetAwaiter(){} // RVA: 0x5636B0
        public void Preserve(){} // RVA: 0x5637A0
        public void AsUniTask(){} // RVA: 0x595BC0
        public void op_Implicit(){} // RVA: 0x506CD00
        public void SuppressCancellationThrow(){} // RVA: 0x5923C0
        public void ToString(){} // RVA: 0x595BF0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x562290
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x563690
        public void get_Status(){} // RVA: 0x5636A0
        public void GetAwaiter(){} // RVA: 0x5636B0
        public void Preserve(){} // RVA: 0x5637A0
        public void AsUniTask(){} // RVA: 0x5A5990
        public void op_Implicit(){} // RVA: 0x5037E10
        public void SuppressCancellationThrow(){} // RVA: 0x5639A0
        public void ToString(){} // RVA: 0x5A59C0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x562290
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x561E40
        public void get_Status(){} // RVA: 0x561EB0
        public void GetAwaiter(){} // RVA: 0x59EA70
        public void Preserve(){} // RVA: 0x561F00
        public void AsUniTask(){} // RVA: 0x59EAB0
        public void op_Implicit(){} // RVA: 0x5079CA0
        public void SuppressCancellationThrow(){} // RVA: 0x59B380
        public void ToString(){} // RVA: 0x59EAE0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560A50
        public void get_Status(){} // RVA: 0x560A60
        public void GetAwaiter(){} // RVA: 0x560A70
        public void Preserve(){} // RVA: 0x560B40
        public void AsUniTask(){} // RVA: 0x5A1AD0
        public void op_Implicit(){} // RVA: 0x50870D0
        public void SuppressCancellationThrow(){} // RVA: 0x5A09A0
        public void ToString(){} // RVA: 0x5A1B00
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x561E40
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x586340
        public void get_Status(){} // RVA: 0x5863A0
        public void GetAwaiter(){} // RVA: 0x571AC0
        public void Preserve(){} // RVA: 0x5863B0
        public void AsUniTask(){} // RVA: 0x5A3820
        public void op_Implicit(){} // RVA: 0x508B540
        public void SuppressCancellationThrow(){} // RVA: 0x5A36C0
        public void ToString(){} // RVA: 0x5A3850
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5613C0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560F00
        public void get_Status(){} // RVA: 0x560F60
        public void GetAwaiter(){} // RVA: 0x560F70
        public void Preserve(){} // RVA: 0x561020
        public void AsUniTask(){} // RVA: 0x59F160
        public void op_Implicit(){} // RVA: 0x507E8B0
        public void SuppressCancellationThrow(){} // RVA: 0x59D350
        public void ToString(){} // RVA: 0x59F190
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x560A50
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x563B60
        public void get_Status(){} // RVA: 0x563B70
        public void GetAwaiter(){} // RVA: 0x563B80
        public void Preserve(){} // RVA: 0x563C80
        public void AsUniTask(){} // RVA: 0x5A5130
        public void op_Implicit(){} // RVA: 0x5090CC0
        public void SuppressCancellationThrow(){} // RVA: 0x5A5160
        public void ToString(){} // RVA: 0x5A51B0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5679C0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x561E40
        public void get_Status(){} // RVA: 0x561EB0
        public void GetAwaiter(){} // RVA: 0x59EA70
        public void Preserve(){} // RVA: 0x561F00
        public void AsUniTask(){} // RVA: 0x5A55D0
        public void op_Implicit(){} // RVA: 0x5079CA0
        public void SuppressCancellationThrow(){} // RVA: 0x59B380
        public void ToString(){} // RVA: 0x5A5600
    }

}