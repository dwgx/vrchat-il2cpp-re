// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 100
// Methods: 923

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class UniTask
    {
        // ── Methods ──
        public void ToCoroutine(){} // RVA: 0x7FFAF979F040
        public void .ctor(){} // RVA: 0x7FFAF5143AB0
        public void get_Status(){} // RVA: 0x7FFAF979F080
        public void GetAwaiter(){} // RVA: 0x7FFAF979F0E0
        public void SuppressCancellationThrow(){} // RVA: 0x7FFAF979F140
        public void op_Implicit(){} // RVA: 0x7FFAF979F310
        public void ToString(){} // RVA: 0x7FFAF979F3B0
        public void Preserve(){} // RVA: 0x7FFAF979F4A0
        public void AsAsyncUnitUniTask(){} // RVA: 0x7FFAF979F5D0
        public void Yield(){} // RVA: 0x7FFAF979F880 | overloaded x4
        public void NextFrame(){} // RVA: 0x7FFAF979FC30 | overloaded x4
        public void WaitForEndOfFrame(){} // RVA: 0x7FFAF979FEF0 | overloaded x4
        public void WaitForFixedUpdate(){} // RVA: 0x7FFAF97A0020 | overloaded x2
        public void WaitForSeconds(){} // RVA: 0x7FFAF97A0180 | overloaded x2
        public void DelayFrame(){} // RVA: 0x7FFAF97A0230
        public void Delay(){} // RVA: 0x7FFAF97A06E0 | overloaded x4
        public void FromException(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void FromResult(){} // RVA: 0x7FFAF2D33FA0
        public void FromCanceled(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void Create(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void Lazy(){} // RVA: 0x7FFAF2ABCE50 | overloaded x2
        public void Void(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void Action(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void UnityAction(){} // RVA: 0x7FFAF2AC2930 | overloaded x11
        public void Defer(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void Never(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void Run(){} // RVA: 0x7FFAF2D33FA0 | overloaded x8
        public void RunOnThreadPool(){} // RVA: 0x7FFAF2D33FA0 | overloaded x8
        public void SwitchToMainThread(){} // RVA: 0x7FFAF97A2310 | overloaded x2
        public void ReturnToMainThread(){} // RVA: 0x7FFAF97A2310 | overloaded x2
        public void Post(){} // RVA: 0x7FFAF97A2370
        public void SwitchToThreadPool(){} // RVA: 0x7FFAF2D8D320
        public void SwitchToTaskPool(){} // RVA: 0x7FFAF2D8D320
        public void SwitchToSynchronizationContext(){} // RVA: 0x7FFAF97A23D0
        public void ReturnToSynchronizationContext(){} // RVA: 0x7FFAF97A2460
        public void ReturnToCurrentSynchronizationContext(){} // RVA: 0x7FFAF97A2490
        public void WaitUntil(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void WaitWhile(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void WaitUntilCanceled(){} // RVA: 0x7FFAF97A26D0
        public void WaitUntilValueChanged(){} // RVA: 0x7FFAF2D33FA0
        public void WhenAll(){} // RVA: 0x7FFAF2D33FA0 | overloaded x18
        public void WhenAny(){} // RVA: 0x7FFAF2D33FA0 | overloaded x19
        public void WhenEach(){} // RVA: 0x7FFAF2ABCE50 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF97A2D30
    }

    public class UniTaskAsyncEnumerableExtensions
    {
        // ── Methods ──
        public void WithCancellation(){} // RVA: 0x7FFAF2D33FA0
    }

    public class UniTaskCancelableAsyncEnumerable`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){} // RVA: 0x7FFAF2D33FA0
    }

    public class UniTaskCancellationExtensions
    {
        // ── Methods ──
        public void GetCancellationTokenOnDestroy(){} // RVA: 0x7FFAF979EAB0 | overloaded x3
    }

    public class UniTaskCompletionSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void MarkHandled(){} // RVA: 0x7FFAF97B00E0
        public void get_Task(){} // RVA: 0x7FFAF97B00F0
        public void TrySetResult(){} // RVA: 0x7FFAF97B0150
        public void TrySetCanceled(){} // RVA: 0x7FFAF97B0160
        public void TrySetException(){} // RVA: 0x7FFAF97B01D0
        public void GetResult(){} // RVA: 0x7FFAF97B03D0
        public void GetStatus(){} // RVA: 0x7FFAF2E2E080
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF2E2E080
        public void OnCompleted(){} // RVA: 0x7FFAF97B04D0
        public void TrySignalCompletion(){} // RVA: 0x7FFAF97B08F0
    }

    public class UniTaskCompletionSourceCoreShared
    {
        // ── Methods ──
        public void CompletionSentinel(){} // RVA: 0x7FFAF97AF500
        public void .cctor(){} // RVA: 0x7FFAF97AF550
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
        public void ReportUnhandledError(){} // RVA: 0x7FFAF2AD4A50
        public void MarkHandled(){} // RVA: 0x7FFAF2AD4A50
        public void TrySetResult(){} // RVA: 0x7FFAF2D33FA0
        public void TrySetException(){} // RVA: 0x7FFAF2ABDE40
        public void TrySetCanceled(){} // RVA: 0x7FFAF2D33FA0
        public void get_Version(){} // RVA: 0x7FFAF2ABCC90
        public void GetStatus(){}
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF2ABD840
        public void GetResult(){} // RVA: 0x7FFAF2D33FA0
        public void OnCompleted(){}
        public void ValidateToken(){} // RVA: 0x7FFAF2AD4C40
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F7A6B0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F7A7F0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F7A940
        public void TrySetException(){} // RVA: 0x7FFAF6F7AA00
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F7ACB0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F7ADF0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F7AF30
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F7AFD0
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F83210
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F83350
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F834A0
        public void TrySetException(){} // RVA: 0x7FFAF6F83560
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F83810
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F83950
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F83A90
        public void GetResult(){} // RVA: 0x7FFAF6737990
        public void OnCompleted(){} // RVA: 0x7FFAF6F83B30
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F714F0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F71630
        public void MarkHandled(){} // RVA: 0x7FFAF6F64C30
        public void TrySetResult(){} // RVA: 0x7FFAF6F71780
        public void TrySetException(){} // RVA: 0x7FFAF6F71890
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F71B40
        public void get_Version(){} // RVA: 0x7FFAF5342C90
        public void GetStatus(){} // RVA: 0x7FFAF6F71C80
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F71DC0
        public void GetResult(){} // RVA: 0x7FFAF6F652E0
        public void OnCompleted(){} // RVA: 0x7FFAF6F71E60
        public void ValidateToken(){} // RVA: 0x7FFAF6F656C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F6F3B0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F6F4F0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F6F640
        public void TrySetException(){} // RVA: 0x7FFAF6F6F700
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F6F9B0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F6FAF0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F6FC30
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F6FCD0
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F8E960
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F8EAA0
        public void MarkHandled(){} // RVA: 0x7FFAF6F692E0
        public void TrySetResult(){} // RVA: 0x7FFAF6F8EBF0
        public void TrySetException(){} // RVA: 0x7FFAF6F8ED00
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F8EFB0
        public void get_Version(){} // RVA: 0x7FFAF6F697F0
        public void GetStatus(){} // RVA: 0x7FFAF6F8F0F0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F8F230
        public void GetResult(){} // RVA: 0x7FFAF6F699E0
        public void OnCompleted(){} // RVA: 0x7FFAF6F8F2D0
        public void ValidateToken(){} // RVA: 0x7FFAF6F69DC0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F759B0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F75AF0
        public void MarkHandled(){} // RVA: 0x7FFAF6F63EA0
        public void TrySetResult(){} // RVA: 0x7FFAF6F75C40
        public void TrySetException(){} // RVA: 0x7FFAF6F75D50
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F76000
        public void get_Version(){} // RVA: 0x7FFAF6F64370
        public void GetStatus(){} // RVA: 0x7FFAF6F76140
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F76280
        public void GetResult(){} // RVA: 0x7FFAF6F64560
        public void OnCompleted(){} // RVA: 0x7FFAF6F76320
        public void ValidateToken(){} // RVA: 0x7FFAF6F64940
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F68520
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F68660
        public void MarkHandled(){} // RVA: 0x7FFAF6F63EA0
        public void TrySetResult(){} // RVA: 0x7FFAF6F687B0
        public void TrySetException(){} // RVA: 0x7FFAF6F688C0
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F68B70
        public void get_Version(){} // RVA: 0x7FFAF6F64370
        public void GetStatus(){} // RVA: 0x7FFAF6F68CB0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F68DF0
        public void GetResult(){} // RVA: 0x7FFAF6F64560
        public void OnCompleted(){} // RVA: 0x7FFAF6F68E90
        public void ValidateToken(){} // RVA: 0x7FFAF6F64940
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F74E80
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F74FC0
        public void MarkHandled(){} // RVA: 0x7FFAF6F63EA0
        public void TrySetResult(){} // RVA: 0x7FFAF6F75110
        public void TrySetException(){} // RVA: 0x7FFAF6F75220
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F754D0
        public void get_Version(){} // RVA: 0x7FFAF6F64370
        public void GetStatus(){} // RVA: 0x7FFAF6F75610
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F75750
        public void GetResult(){} // RVA: 0x7FFAF6F64560
        public void OnCompleted(){} // RVA: 0x7FFAF6F757F0
        public void ValidateToken(){} // RVA: 0x7FFAF6F64940
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F6E880
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F6E9C0
        public void MarkHandled(){} // RVA: 0x7FFAF6F64C30
        public void TrySetResult(){} // RVA: 0x7FFAF6F6EB10
        public void TrySetException(){} // RVA: 0x7FFAF6F6EC20
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F6EED0
        public void get_Version(){} // RVA: 0x7FFAF5342C90
        public void GetStatus(){} // RVA: 0x7FFAF6F6F010
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F6F150
        public void GetResult(){} // RVA: 0x7FFAF6F652E0
        public void OnCompleted(){} // RVA: 0x7FFAF6F6F1F0
        public void ValidateToken(){} // RVA: 0x7FFAF6F656C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F73820
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F73960
        public void MarkHandled(){} // RVA: 0x7FFAF6F64C30
        public void TrySetResult(){} // RVA: 0x7FFAF6F73AB0
        public void TrySetException(){} // RVA: 0x7FFAF6F73BC0
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F73E70
        public void get_Version(){} // RVA: 0x7FFAF5342C90
        public void GetStatus(){} // RVA: 0x7FFAF6F73FB0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F740F0
        public void GetResult(){} // RVA: 0x7FFAF6F652E0
        public void OnCompleted(){} // RVA: 0x7FFAF6F74190
        public void ValidateToken(){} // RVA: 0x7FFAF6F656C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F6C6F0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F6C830
        public void MarkHandled(){} // RVA: 0x7FFAF6F64C30
        public void TrySetResult(){} // RVA: 0x7FFAF6F6C980
        public void TrySetException(){} // RVA: 0x7FFAF6F6CA90
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F6CD40
        public void get_Version(){} // RVA: 0x7FFAF5342C90
        public void GetStatus(){} // RVA: 0x7FFAF6F6CE80
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F6CFC0
        public void GetResult(){} // RVA: 0x7FFAF6F652E0
        public void OnCompleted(){} // RVA: 0x7FFAF6F6D060
        public void ValidateToken(){} // RVA: 0x7FFAF6F656C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F79B80
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F79CC0
        public void MarkHandled(){} // RVA: 0x7FFAF6F692E0
        public void TrySetResult(){} // RVA: 0x7FFAF6F79E10
        public void TrySetException(){} // RVA: 0x7FFAF6F79F20
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F7A1D0
        public void get_Version(){} // RVA: 0x7FFAF6F697F0
        public void GetStatus(){} // RVA: 0x7FFAF6F7A310
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F7A450
        public void GetResult(){} // RVA: 0x7FFAF6F699E0
        public void OnCompleted(){} // RVA: 0x7FFAF6F7A4F0
        public void ValidateToken(){} // RVA: 0x7FFAF6F69DC0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F6E880
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F6E9C0
        public void MarkHandled(){} // RVA: 0x7FFAF6F64C30
        public void TrySetResult(){} // RVA: 0x7FFAF6F6EB10
        public void TrySetException(){} // RVA: 0x7FFAF6F6EC20
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F6EED0
        public void get_Version(){} // RVA: 0x7FFAF5342C90
        public void GetStatus(){} // RVA: 0x7FFAF6F6F010
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F6F150
        public void GetResult(){} // RVA: 0x7FFAF6F652E0
        public void OnCompleted(){} // RVA: 0x7FFAF6F6F1F0
        public void ValidateToken(){} // RVA: 0x7FFAF6F656C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F6C6F0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F6C830
        public void MarkHandled(){} // RVA: 0x7FFAF6F64C30
        public void TrySetResult(){} // RVA: 0x7FFAF6F6C980
        public void TrySetException(){} // RVA: 0x7FFAF6F6CA90
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F6CD40
        public void get_Version(){} // RVA: 0x7FFAF5342C90
        public void GetStatus(){} // RVA: 0x7FFAF6F6CE80
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F6CFC0
        public void GetResult(){} // RVA: 0x7FFAF6F652E0
        public void OnCompleted(){} // RVA: 0x7FFAF6F6D060
        public void ValidateToken(){} // RVA: 0x7FFAF6F656C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F6AC20
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F6AD70
        public void MarkHandled(){} // RVA: 0x7FFAF6F6AEC0
        public void TrySetResult(){} // RVA: 0x7FFAF6F6AED0
        public void TrySetException(){} // RVA: 0x7FFAF6F6AFF0
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F6B2A0
        public void get_Version(){} // RVA: 0x7FFAF6697880
        public void GetStatus(){} // RVA: 0x7FFAF6F6B3E0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F6B520
        public void GetResult(){} // RVA: 0x7FFAF6F6B5C0
        public void OnCompleted(){} // RVA: 0x7FFAF6F6B7F0
        public void ValidateToken(){} // RVA: 0x7FFAF6F6B9B0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F6D220
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F6D360
        public void MarkHandled(){} // RVA: 0x7FFAF6F692E0
        public void TrySetResult(){} // RVA: 0x7FFAF6F6D4B0
        public void TrySetException(){} // RVA: 0x7FFAF6F6D5C0
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F6D870
        public void get_Version(){} // RVA: 0x7FFAF6F697F0
        public void GetStatus(){} // RVA: 0x7FFAF6F6D9B0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F6DAF0
        public void GetResult(){} // RVA: 0x7FFAF6F699E0
        public void OnCompleted(){} // RVA: 0x7FFAF6F6DB90
        public void ValidateToken(){} // RVA: 0x7FFAF6F69DC0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F8FFE0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F90130
        public void MarkHandled(){} // RVA: 0x7FFAF6F6AEC0
        public void TrySetResult(){} // RVA: 0x7FFAF6F90280
        public void TrySetException(){} // RVA: 0x7FFAF6F903A0
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F90650
        public void get_Version(){} // RVA: 0x7FFAF6697880
        public void GetStatus(){} // RVA: 0x7FFAF6F90790
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F908D0
        public void GetResult(){} // RVA: 0x7FFAF6F6B5C0
        public void OnCompleted(){} // RVA: 0x7FFAF6F90970
        public void ValidateToken(){} // RVA: 0x7FFAF6F6B9B0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F6DD50
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F6DE90
        public void MarkHandled(){} // RVA: 0x7FFAF6F64C30
        public void TrySetResult(){} // RVA: 0x7FFAF6F6DFE0
        public void TrySetException(){} // RVA: 0x7FFAF6F6E0F0
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F6E3A0
        public void get_Version(){} // RVA: 0x7FFAF5342C90
        public void GetStatus(){} // RVA: 0x7FFAF6F6E4E0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F6E620
        public void GetResult(){} // RVA: 0x7FFAF6F652E0
        public void OnCompleted(){} // RVA: 0x7FFAF6F6E6C0
        public void ValidateToken(){} // RVA: 0x7FFAF6F656C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F810C0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F81200
        public void MarkHandled(){} // RVA: 0x7FFAF6F63EA0
        public void TrySetResult(){} // RVA: 0x7FFAF6F81350
        public void TrySetException(){} // RVA: 0x7FFAF6F81460
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F81710
        public void get_Version(){} // RVA: 0x7FFAF6F64370
        public void GetStatus(){} // RVA: 0x7FFAF6F81850
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F81990
        public void GetResult(){} // RVA: 0x7FFAF6F64560
        public void OnCompleted(){} // RVA: 0x7FFAF6F81A30
        public void ValidateToken(){} // RVA: 0x7FFAF6F64940
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F83CF0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F83E30
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F83F80
        public void TrySetException(){} // RVA: 0x7FFAF6F84040
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F842F0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F84430
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F84570
        public void GetResult(){} // RVA: 0x7FFAF6737990
        public void OnCompleted(){} // RVA: 0x7FFAF6F84610
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F85FB0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F860F0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F86240
        public void TrySetException(){} // RVA: 0x7FFAF6F86300
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F865B0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F866F0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F86830
        public void GetResult(){} // RVA: 0x7FFAF6F868D0
        public void OnCompleted(){} // RVA: 0x7FFAF6F86AD0
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F82720
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F82860
        public void MarkHandled(){} // RVA: 0x7FFAF6F64C30
        public void TrySetResult(){} // RVA: 0x7FFAF6F829B0
        public void TrySetException(){} // RVA: 0x7FFAF6F82A80
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F82D30
        public void get_Version(){} // RVA: 0x7FFAF5342C90
        public void GetStatus(){} // RVA: 0x7FFAF6F82E70
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F82FB0
        public void GetResult(){} // RVA: 0x7FFAF6F652E0
        public void OnCompleted(){} // RVA: 0x7FFAF6F83050
        public void ValidateToken(){} // RVA: 0x7FFAF6F656C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F88DA0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F88EE0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F89030
        public void TrySetException(){} // RVA: 0x7FFAF6F89130
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F893E0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F89520
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F89660
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F89700
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F90B30
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F90C70
        public void MarkHandled(){} // RVA: 0x7FFAF6F64C30
        public void TrySetResult(){} // RVA: 0x7FFAF6F90DC0
        public void TrySetException(){} // RVA: 0x7FFAF6F90ED0
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F91180
        public void get_Version(){} // RVA: 0x7FFAF5342C90
        public void GetStatus(){} // RVA: 0x7FFAF6F912C0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F91400
        public void GetResult(){} // RVA: 0x7FFAF6F652E0
        public void OnCompleted(){} // RVA: 0x7FFAF6F914A0
        public void ValidateToken(){} // RVA: 0x7FFAF6F656C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F790A0
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F791E0
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F79330
        public void TrySetException(){} // RVA: 0x7FFAF6F793F0
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F796A0
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F797E0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F79920
        public void GetResult(){} // RVA: 0x7FFAF6F66050
        public void OnCompleted(){} // RVA: 0x7FFAF6F799C0
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSourceCore`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF6F6BA10
        public void ReportUnhandledError(){} // RVA: 0x7FFAF6F6BB50
        public void MarkHandled(){} // RVA: 0x7FFAF6F659B0
        public void TrySetResult(){} // RVA: 0x7FFAF6F6BCA0
        public void TrySetException(){} // RVA: 0x7FFAF6F6BD60
        public void TrySetCanceled(){} // RVA: 0x7FFAF6F6C010
        public void get_Version(){} // RVA: 0x7FFAF46BF720
        public void GetStatus(){} // RVA: 0x7FFAF6F6C150
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF6F6C290
        public void GetResult(){} // RVA: 0x7FFAF6F6C330
        public void OnCompleted(){} // RVA: 0x7FFAF6F6C530
        public void ValidateToken(){} // RVA: 0x7FFAF6F66410
    }

    public class UniTaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
        public void MarkHandled(){} // RVA: 0x7FFAF2AD4A50
        public void get_Task(){} // RVA: 0x7FFAF2D33FA0
        public void TrySetResult(){} // RVA: 0x7FFAF2D33FA0
        public void TrySetCanceled(){} // RVA: 0x7FFAF2D33FA0
        public void TrySetException(){} // RVA: 0x7FFAF2ABDE40
        public void GetResult(){} // RVA: 0x7FFAF2D33FA0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAF2AD4C40
        public void GetStatus(){}
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF2ABD840
        public void OnCompleted(){}
        public void TrySignalCompletion(){} // RVA: 0x7FFAF2ABE1F0
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void MarkHandled(){} // RVA: 0x7FFAF6FDC560
        public void get_Task(){} // RVA: 0x7FFAF6FDE200
        public void TrySetResult(){} // RVA: 0x7FFAF6FDF010
        public void TrySetCanceled(){} // RVA: 0x7FFAF6FDF080
        public void TrySetException(){} // RVA: 0x7FFAF6FDF0F0
        public void GetResult(){} // RVA: 0x7FFAF6FDE5B0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAF6FDC990
        public void GetStatus(){} // RVA: 0x7FFAF2E2E0C0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF2E2E0C0
        public void OnCompleted(){} // RVA: 0x7FFAF6FDF320
        public void TrySignalCompletion(){} // RVA: 0x7FFAF6FDF740
    }

    public class UniTaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void MarkHandled(){} // RVA: 0x7FFAF6FDC560
        public void get_Task(){} // RVA: 0x7FFAF6FDE200
        public void TrySetResult(){} // RVA: 0x7FFAF6FDF010
        public void TrySetCanceled(){} // RVA: 0x7FFAF6FDF080
        public void TrySetException(){} // RVA: 0x7FFAF6FDF0F0
        public void GetResult(){} // RVA: 0x7FFAF6FDE5B0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAF6FDC990
        public void GetStatus(){} // RVA: 0x7FFAF2E2E0C0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF2E2E0C0
        public void OnCompleted(){} // RVA: 0x7FFAF6FDF320
        public void TrySignalCompletion(){} // RVA: 0x7FFAF6FDF740
    }

    public class UniTaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void MarkHandled(){} // RVA: 0x7FFAF6FDC560
        public void get_Task(){} // RVA: 0x7FFAF6FDE200
        public void TrySetResult(){} // RVA: 0x7FFAF6FDF010
        public void TrySetCanceled(){} // RVA: 0x7FFAF6FDF080
        public void TrySetException(){} // RVA: 0x7FFAF6FDF0F0
        public void GetResult(){} // RVA: 0x7FFAF6FDE5B0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAF6FDC990
        public void GetStatus(){} // RVA: 0x7FFAF2E2E0C0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF2E2E0C0
        public void OnCompleted(){} // RVA: 0x7FFAF6FDF320
        public void TrySignalCompletion(){} // RVA: 0x7FFAF6FDF740
    }

    public class UniTaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void MarkHandled(){} // RVA: 0x7FFAF6FDC560
        public void get_Task(){} // RVA: 0x7FFAF6FDE200
        public void TrySetResult(){} // RVA: 0x7FFAF6FDF010
        public void TrySetCanceled(){} // RVA: 0x7FFAF6FDF080
        public void TrySetException(){} // RVA: 0x7FFAF6FDF0F0
        public void GetResult(){} // RVA: 0x7FFAF6FDE5B0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAF6FDC990
        public void GetStatus(){} // RVA: 0x7FFAF2E2E0C0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF2E2E0C0
        public void OnCompleted(){} // RVA: 0x7FFAF6FDF320
        public void TrySignalCompletion(){} // RVA: 0x7FFAF6FDF740
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void MarkHandled(){} // RVA: 0x7FFAF6FDC560
        public void get_Task(){} // RVA: 0x7FFAF6FDC570
        public void TrySetResult(){} // RVA: 0x7FFAF6FDC5D0
        public void TrySetCanceled(){} // RVA: 0x7FFAF6FDC600
        public void TrySetException(){} // RVA: 0x7FFAF6FDC670
        public void GetResult(){} // RVA: 0x7FFAF6FDC8A0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAF6FDC990
        public void GetStatus(){} // RVA: 0x7FFAF2E2E0C0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF2E2E0C0
        public void OnCompleted(){} // RVA: 0x7FFAF6FDCA90
        public void TrySignalCompletion(){} // RVA: 0x7FFAF6FDCEB0
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void MarkHandled(){} // RVA: 0x7FFAF6FDC560
        public void get_Task(){} // RVA: 0x7FFAF6FDE200
        public void TrySetResult(){} // RVA: 0x7FFAF6FDF010
        public void TrySetCanceled(){} // RVA: 0x7FFAF6FDF080
        public void TrySetException(){} // RVA: 0x7FFAF6FDF0F0
        public void GetResult(){} // RVA: 0x7FFAF6FDE5B0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAF6FDC990
        public void GetStatus(){} // RVA: 0x7FFAF2E2E0C0
        public void UnsafeGetStatus(){} // RVA: 0x7FFAF2E2E0C0
        public void OnCompleted(){} // RVA: 0x7FFAF6FDF320
        public void TrySignalCompletion(){} // RVA: 0x7FFAF6FDF740
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

    public class UniTaskCompletionSource`1
    {
    }

}