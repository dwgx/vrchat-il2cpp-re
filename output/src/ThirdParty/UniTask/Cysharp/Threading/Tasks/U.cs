// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 100
// Methods: 923

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class UniTask
    {
        public Cysharp.Threading.Tasks.IUniTaskSource source; // 0x10

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
        public System.Threading.CancellationToken cancellationToken; // 0x10

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
        public ÍÎÏÍÌÏÍÏÌÏÍÏÍÌÏÌÍÎÎÌÌÎÎ result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public ÍÎÏÍÌÏÍÏÌÏÍÏÍÌÏÌÍÎÎÌÌÎÎ[] result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public T result;

        // ── Methods ──
        public void Reset(){} // RVA: 0x24A50
        public void ReportUnhandledError(){} // RVA: 0x24A50
        public void MarkHandled(){} // RVA: 0x24A50
        public void TrySetResult(){} // RVA: 0x283FA0
        public void TrySetException(){} // RVA: 0xDE40
        public void TrySetCanceled(){} // RVA: 0x283FA0
        public void get_Version(){} // RVA: 0xCC90
        public void GetStatus(){}
        public void UnsafeGetStatus(){} // RVA: 0xD840
        public void GetResult(){} // RVA: 0x283FA0
        public void OnCompleted(){}
        public void ValidateToken(){} // RVA: 0x24C40
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`3<int,bool,bool> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44CA6B0
        public void ReportUnhandledError(){} // RVA: 0x44CA7F0
        public void MarkHandled(){} // RVA: 0x44B59B0
        public void TrySetResult(){} // RVA: 0x44CA940
        public void TrySetException(){} // RVA: 0x44CAA00
        public void TrySetCanceled(){} // RVA: 0x44CACB0
        public void get_Version(){} // RVA: 0x1C0F720
        public void GetStatus(){} // RVA: 0x44CADF0
        public void UnsafeGetStatus(){} // RVA: 0x44CAF30
        public void GetResult(){} // RVA: 0x44B6050
        public void OnCompleted(){} // RVA: 0x44CAFD0
        public void ValidateToken(){} // RVA: 0x44B6410
    }

    public class UniTaskCompletionSourceCore`1
    {
        public object result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public Cysharp.Threading.Tasks.AsyncUnit result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44D3210
        public void ReportUnhandledError(){} // RVA: 0x44D3350
        public void MarkHandled(){} // RVA: 0x44B59B0
        public void TrySetResult(){} // RVA: 0x44D34A0
        public void TrySetException(){} // RVA: 0x44D3560
        public void TrySetCanceled(){} // RVA: 0x44D3810
        public void get_Version(){} // RVA: 0x1C0F720
        public void GetStatus(){} // RVA: 0x44D3950
        public void UnsafeGetStatus(){} // RVA: 0x44D3A90
        public void GetResult(){} // RVA: 0x3C87990
        public void OnCompleted(){} // RVA: 0x44D3B30
        public void ValidateToken(){} // RVA: 0x44B6410
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`2<System.Collections.Generic.Dictionary`2<System.Type,ÏÍÏÏÏÏÎÎÌÌÌÏÏÎÏÏÌÎÍÍÌÏÌ>,System.Collections.Generic.Dictionary`2<System.Type,ÌÏÌÏÎÎÌÌÍÏÌÏÌÏÏÏÏÌÌÏÎÍÏ>> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44C14F0
        public void ReportUnhandledError(){} // RVA: 0x44C1630
        public void MarkHandled(){} // RVA: 0x44B4C30
        public void TrySetResult(){} // RVA: 0x44C1780
        public void TrySetException(){} // RVA: 0x44C1890
        public void TrySetCanceled(){} // RVA: 0x44C1B40
        public void get_Version(){} // RVA: 0x2892C90
        public void GetStatus(){} // RVA: 0x44C1C80
        public void UnsafeGetStatus(){} // RVA: 0x44C1DC0
        public void GetResult(){} // RVA: 0x44B52E0
        public void OnCompleted(){} // RVA: 0x44C1E60
        public void ValidateToken(){} // RVA: 0x44B56C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.List`1<ÍÍÍÏÍÏÎÏÎÌÌÌÏÍÌÏÍÌÌÎÎÌÍ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public VRC.Core.ApiUserPermissions result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.List`1<ÎÌÏÏÍÎÍÎÌÍÎÌÍÌÌÎÎÎÍÎÏÏÏ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`2<0x65705CC8,uint> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44BF3B0
        public void ReportUnhandledError(){} // RVA: 0x44BF4F0
        public void MarkHandled(){} // RVA: 0x44B59B0
        public void TrySetResult(){} // RVA: 0x44BF640
        public void TrySetException(){} // RVA: 0x44BF700
        public void TrySetCanceled(){} // RVA: 0x44BF9B0
        public void get_Version(){} // RVA: 0x1C0F720
        public void GetStatus(){} // RVA: 0x44BFAF0
        public void UnsafeGetStatus(){} // RVA: 0x44BFC30
        public void GetResult(){} // RVA: 0x44B6050
        public void OnCompleted(){} // RVA: 0x44BFCD0
        public void ValidateToken(){} // RVA: 0x44B6410
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.List`1<ÍÎÌÍÏÎÍÏÌÏÍÌÎÏÍÌÎÍÏÌÎÎÌ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.List`1<ÎÎÍÌÌÌÍÌÌÏÎÌÌÍÍÎÎÎÍÌÏÏÏ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.List`1<ÍÎÌÏÏÌÌÏÍÎÌÎÎÎÌÎÍÏÎÏÏÍÍ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.List`1<ÍÍÍÌÎÍÏÍÍÏÌÌÎÍÏÍÎÍÌÍÍÏÎ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.List`1<ÌÎÌÎÌÍÌÎÍÏÏÍÎÍÏÍÎÌÏÎÍÏÎ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.List`1<ÎÍÌÌÏÎÎÍÎÌÏÌÎÏÍÏÎÌÌÌÌÌÏ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.List`1<ÎÎÍÎÍÍÏÍÎÏÍÌÎÏÌÏÍÎÎÌÌÍÎ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.List`1<ÎÎÍÎÌÌÏÎÎÎÎÏÍÍÌÎÏÌÍÏÎÌÌ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.IEnumerable`1<VRC.Core.APICalendarEntry> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.IEnumerable`1<VRC.Core.APICalendarEntry>[] result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.HashSet`1<ÏÌÍÌÍÎÏÏÎÏÏÎÏÏÍÏÏÍÏÌÌÏÎ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.IReadOnlyList`1<ÌÎÌÏÎÌÌÌÌÏÍÌÏÏÏÎÍÍÌÎÎÏÍ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public UnityEngine.Texture2D result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public ÌÌÏÎÌÌÍÎÎÎÍÏÍÌÎÏÎÏÏÏÏÌÌ result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44DE960
        public void ReportUnhandledError(){} // RVA: 0x44DEAA0
        public void MarkHandled(){} // RVA: 0x44B92E0
        public void TrySetResult(){} // RVA: 0x44DEBF0
        public void TrySetException(){} // RVA: 0x44DED00
        public void TrySetCanceled(){} // RVA: 0x44DEFB0
        public void get_Version(){} // RVA: 0x44B97F0
        public void GetStatus(){} // RVA: 0x44DF0F0
        public void UnsafeGetStatus(){} // RVA: 0x44DF230
        public void GetResult(){} // RVA: 0x44B99E0
        public void OnCompleted(){} // RVA: 0x44DF2D0
        public void ValidateToken(){} // RVA: 0x44B9DC0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`3<bool,UnityEngine.Texture2D,byte[]> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44C59B0
        public void ReportUnhandledError(){} // RVA: 0x44C5AF0
        public void MarkHandled(){} // RVA: 0x44B3EA0
        public void TrySetResult(){} // RVA: 0x44C5C40
        public void TrySetException(){} // RVA: 0x44C5D50
        public void TrySetCanceled(){} // RVA: 0x44C6000
        public void get_Version(){} // RVA: 0x44B4370
        public void GetStatus(){} // RVA: 0x44C6140
        public void UnsafeGetStatus(){} // RVA: 0x44C6280
        public void GetResult(){} // RVA: 0x44B4560
        public void OnCompleted(){} // RVA: 0x44C6320
        public void ValidateToken(){} // RVA: 0x44B4940
    }

    public class UniTaskCompletionSourceCore`1
    {
        public VRC.Core.ApiWorldInstance result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.List`1<ÍÎÍÎÎÍÌÌÏÍÌÏÎÌÎÏÎÍÍÌÍÏÎ> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.Nullable`1<Cysharp.Threading.Tasks.UniTask> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44B8520
        public void ReportUnhandledError(){} // RVA: 0x44B8660
        public void MarkHandled(){} // RVA: 0x44B3EA0
        public void TrySetResult(){} // RVA: 0x44B87B0
        public void TrySetException(){} // RVA: 0x44B88C0
        public void TrySetCanceled(){} // RVA: 0x44B8B70
        public void get_Version(){} // RVA: 0x44B4370
        public void GetStatus(){} // RVA: 0x44B8CB0
        public void UnsafeGetStatus(){} // RVA: 0x44B8DF0
        public void GetResult(){} // RVA: 0x44B4560
        public void OnCompleted(){} // RVA: 0x44B8E90
        public void ValidateToken(){} // RVA: 0x44B4940
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`3<bool,UnityEngine.Texture2D,0x6588EAF0> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44C4E80
        public void ReportUnhandledError(){} // RVA: 0x44C4FC0
        public void MarkHandled(){} // RVA: 0x44B3EA0
        public void TrySetResult(){} // RVA: 0x44C5110
        public void TrySetException(){} // RVA: 0x44C5220
        public void TrySetCanceled(){} // RVA: 0x44C54D0
        public void get_Version(){} // RVA: 0x44B4370
        public void GetStatus(){} // RVA: 0x44C5610
        public void UnsafeGetStatus(){} // RVA: 0x44C5750
        public void GetResult(){} // RVA: 0x44B4560
        public void OnCompleted(){} // RVA: 0x44C57F0
        public void ValidateToken(){} // RVA: 0x44B4940
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`2<0x65716AA0,UnityEngine.GameObject> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44BE880
        public void ReportUnhandledError(){} // RVA: 0x44BE9C0
        public void MarkHandled(){} // RVA: 0x44B4C30
        public void TrySetResult(){} // RVA: 0x44BEB10
        public void TrySetException(){} // RVA: 0x44BEC20
        public void TrySetCanceled(){} // RVA: 0x44BEED0
        public void get_Version(){} // RVA: 0x2892C90
        public void GetStatus(){} // RVA: 0x44BF010
        public void UnsafeGetStatus(){} // RVA: 0x44BF150
        public void GetResult(){} // RVA: 0x44B52E0
        public void OnCompleted(){} // RVA: 0x44BF1F0
        public void ValidateToken(){} // RVA: 0x44B56C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`3<bool,bool,UnityEngine.GameObject> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44C3820
        public void ReportUnhandledError(){} // RVA: 0x44C3960
        public void MarkHandled(){} // RVA: 0x44B4C30
        public void TrySetResult(){} // RVA: 0x44C3AB0
        public void TrySetException(){} // RVA: 0x44C3BC0
        public void TrySetCanceled(){} // RVA: 0x44C3E70
        public void get_Version(){} // RVA: 0x2892C90
        public void GetStatus(){} // RVA: 0x44C3FB0
        public void UnsafeGetStatus(){} // RVA: 0x44C40F0
        public void GetResult(){} // RVA: 0x44B52E0
        public void OnCompleted(){} // RVA: 0x44C4190
        public void ValidateToken(){} // RVA: 0x44B56C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public ÍÎÌÏÎÏÏÍÎÎÌÍÏÍÌÍÌÍÌÏÍÍÌ result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public ÎÏÍÏÍÎÌÏÍÎÍÌÏÎÎÌÎÍÌÍÎÌÏ result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`2<bool,string> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44BC6F0
        public void ReportUnhandledError(){} // RVA: 0x44BC830
        public void MarkHandled(){} // RVA: 0x44B4C30
        public void TrySetResult(){} // RVA: 0x44BC980
        public void TrySetException(){} // RVA: 0x44BCA90
        public void TrySetCanceled(){} // RVA: 0x44BCD40
        public void get_Version(){} // RVA: 0x2892C90
        public void GetStatus(){} // RVA: 0x44BCE80
        public void UnsafeGetStatus(){} // RVA: 0x44BCFC0
        public void GetResult(){} // RVA: 0x44B52E0
        public void OnCompleted(){} // RVA: 0x44BD060
        public void ValidateToken(){} // RVA: 0x44B56C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`3<int,System.ValueTuple`2<...,...>,bool> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44C9B80
        public void ReportUnhandledError(){} // RVA: 0x44C9CC0
        public void MarkHandled(){} // RVA: 0x44B92E0
        public void TrySetResult(){} // RVA: 0x44C9E10
        public void TrySetException(){} // RVA: 0x44C9F20
        public void TrySetCanceled(){} // RVA: 0x44CA1D0
        public void get_Version(){} // RVA: 0x44B97F0
        public void GetStatus(){} // RVA: 0x44CA310
        public void UnsafeGetStatus(){} // RVA: 0x44CA450
        public void GetResult(){} // RVA: 0x44B99E0
        public void OnCompleted(){} // RVA: 0x44CA4F0
        public void ValidateToken(){} // RVA: 0x44B9DC0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public ÎÌÎÎÌÎÎÎÍÌÏÎÌÍÏÌÎÍÍÎÎÍÎ result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`2<0x65716A48,ÎÍÏÌÍÎÍÏÎÌÏÏÍÏÏÎÏÎÏÌÎÏÌ> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44BE880
        public void ReportUnhandledError(){} // RVA: 0x44BE9C0
        public void MarkHandled(){} // RVA: 0x44B4C30
        public void TrySetResult(){} // RVA: 0x44BEB10
        public void TrySetException(){} // RVA: 0x44BEC20
        public void TrySetCanceled(){} // RVA: 0x44BEED0
        public void get_Version(){} // RVA: 0x2892C90
        public void GetStatus(){} // RVA: 0x44BF010
        public void UnsafeGetStatus(){} // RVA: 0x44BF150
        public void GetResult(){} // RVA: 0x44B52E0
        public void OnCompleted(){} // RVA: 0x44BF1F0
        public void ValidateToken(){} // RVA: 0x44B56C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`2<bool,UnityEngine.GameObject> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44BC6F0
        public void ReportUnhandledError(){} // RVA: 0x44BC830
        public void MarkHandled(){} // RVA: 0x44B4C30
        public void TrySetResult(){} // RVA: 0x44BC980
        public void TrySetException(){} // RVA: 0x44BCA90
        public void TrySetCanceled(){} // RVA: 0x44BCD40
        public void get_Version(){} // RVA: 0x2892C90
        public void GetStatus(){} // RVA: 0x44BCE80
        public void UnsafeGetStatus(){} // RVA: 0x44BCFC0
        public void GetResult(){} // RVA: 0x44B52E0
        public void OnCompleted(){} // RVA: 0x44BD060
        public void ValidateToken(){} // RVA: 0x44B56C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`2<bool,System.ValueTuple`2<bool,ÌÌÍÍÌÍÏÍÌÏÍÏÏÏÌÍÌÏÎÏÎÍÎ>> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44BAC20
        public void ReportUnhandledError(){} // RVA: 0x44BAD70
        public void MarkHandled(){} // RVA: 0x44BAEC0
        public void TrySetResult(){} // RVA: 0x44BAED0
        public void TrySetException(){} // RVA: 0x44BAFF0
        public void TrySetCanceled(){} // RVA: 0x44BB2A0
        public void get_Version(){} // RVA: 0x3BE7880
        public void GetStatus(){} // RVA: 0x44BB3E0
        public void UnsafeGetStatus(){} // RVA: 0x44BB520
        public void GetResult(){} // RVA: 0x44BB5C0
        public void OnCompleted(){} // RVA: 0x44BB7F0
        public void ValidateToken(){} // RVA: 0x44BB9B0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`2<bool,ÌÌÍÍÌÍÏÍÌÏÍÏÏÏÌÍÌÏÎÏÎÍÎ> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44BD220
        public void ReportUnhandledError(){} // RVA: 0x44BD360
        public void MarkHandled(){} // RVA: 0x44B92E0
        public void TrySetResult(){} // RVA: 0x44BD4B0
        public void TrySetException(){} // RVA: 0x44BD5C0
        public void TrySetCanceled(){} // RVA: 0x44BD870
        public void get_Version(){} // RVA: 0x44B97F0
        public void GetStatus(){} // RVA: 0x44BD9B0
        public void UnsafeGetStatus(){} // RVA: 0x44BDAF0
        public void GetResult(){} // RVA: 0x44B99E0
        public void OnCompleted(){} // RVA: 0x44BDB90
        public void ValidateToken(){} // RVA: 0x44B9DC0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public ÎÏÏÌÌÏÏÎÍÍÎÍÍÎÏÏÍÎÏÏÏÏÎ result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44DFFE0
        public void ReportUnhandledError(){} // RVA: 0x44E0130
        public void MarkHandled(){} // RVA: 0x44BAEC0
        public void TrySetResult(){} // RVA: 0x44E0280
        public void TrySetException(){} // RVA: 0x44E03A0
        public void TrySetCanceled(){} // RVA: 0x44E0650
        public void get_Version(){} // RVA: 0x3BE7880
        public void GetStatus(){} // RVA: 0x44E0790
        public void UnsafeGetStatus(){} // RVA: 0x44E08D0
        public void GetResult(){} // RVA: 0x44BB5C0
        public void OnCompleted(){} // RVA: 0x44E0970
        public void ValidateToken(){} // RVA: 0x44BB9B0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.Collections.Generic.Dictionary`2<string,string> result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`2<int,ÏÎÌÌÍÍÎÏÍÏÌÎÌÎÏÌÍÎÎÌÌÏÍ> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44BDD50
        public void ReportUnhandledError(){} // RVA: 0x44BDE90
        public void MarkHandled(){} // RVA: 0x44B4C30
        public void TrySetResult(){} // RVA: 0x44BDFE0
        public void TrySetException(){} // RVA: 0x44BE0F0
        public void TrySetCanceled(){} // RVA: 0x44BE3A0
        public void get_Version(){} // RVA: 0x2892C90
        public void GetStatus(){} // RVA: 0x44BE4E0
        public void UnsafeGetStatus(){} // RVA: 0x44BE620
        public void GetResult(){} // RVA: 0x44B52E0
        public void OnCompleted(){} // RVA: 0x44BE6C0
        public void ValidateToken(){} // RVA: 0x44B56C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public ÌÎÍÍÌÍÌÌÎÏÌÌÎÌÏÎÎÎÌÎÎÌÏ<ÏÎÌÌÍÍÎÏÍÏÌÎÌÎÏÌÍÎÎÌÌÏÍ> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44D10C0
        public void ReportUnhandledError(){} // RVA: 0x44D1200
        public void MarkHandled(){} // RVA: 0x44B3EA0
        public void TrySetResult(){} // RVA: 0x44D1350
        public void TrySetException(){} // RVA: 0x44D1460
        public void TrySetCanceled(){} // RVA: 0x44D1710
        public void get_Version(){} // RVA: 0x44B4370
        public void GetStatus(){} // RVA: 0x44D1850
        public void UnsafeGetStatus(){} // RVA: 0x44D1990
        public void GetResult(){} // RVA: 0x44B4560
        public void OnCompleted(){} // RVA: 0x44D1A30
        public void ValidateToken(){} // RVA: 0x44B4940
    }

    public class UniTaskCompletionSourceCore`1
    {
        public VRC.Core.ApiAvatarPart result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public ÎÍÎÌÌÍÍÏÍÌÌÌÍÎÏÌÌÍÎÏÍÍÍ result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public bool result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44D3CF0
        public void ReportUnhandledError(){} // RVA: 0x44D3E30
        public void MarkHandled(){} // RVA: 0x44B59B0
        public void TrySetResult(){} // RVA: 0x44D3F80
        public void TrySetException(){} // RVA: 0x44D4040
        public void TrySetCanceled(){} // RVA: 0x44D42F0
        public void get_Version(){} // RVA: 0x1C0F720
        public void GetStatus(){} // RVA: 0x44D4430
        public void UnsafeGetStatus(){} // RVA: 0x44D4570
        public void GetResult(){} // RVA: 0x3C87990
        public void OnCompleted(){} // RVA: 0x44D4610
        public void ValidateToken(){} // RVA: 0x44B6410
    }

    public class UniTaskCompletionSourceCore`1
    {
        public int result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44D5FB0
        public void ReportUnhandledError(){} // RVA: 0x44D60F0
        public void MarkHandled(){} // RVA: 0x44B59B0
        public void TrySetResult(){} // RVA: 0x44D6240
        public void TrySetException(){} // RVA: 0x44D6300
        public void TrySetCanceled(){} // RVA: 0x44D65B0
        public void get_Version(){} // RVA: 0x1C0F720
        public void GetStatus(){} // RVA: 0x44D66F0
        public void UnsafeGetStatus(){} // RVA: 0x44D6830
        public void GetResult(){} // RVA: 0x44D68D0
        public void OnCompleted(){} // RVA: 0x44D6AD0
        public void ValidateToken(){} // RVA: 0x44B6410
    }

    public class UniTaskCompletionSourceCore`1
    {
        public UnityEngine.Object[] result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public UnityEngine.Rendering.AsyncGPUReadbackRequest result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44D2720
        public void ReportUnhandledError(){} // RVA: 0x44D2860
        public void MarkHandled(){} // RVA: 0x44B4C30
        public void TrySetResult(){} // RVA: 0x44D29B0
        public void TrySetException(){} // RVA: 0x44D2A80
        public void TrySetCanceled(){} // RVA: 0x44D2D30
        public void get_Version(){} // RVA: 0x2892C90
        public void GetStatus(){} // RVA: 0x44D2E70
        public void UnsafeGetStatus(){} // RVA: 0x44D2FB0
        public void GetResult(){} // RVA: 0x44B52E0
        public void OnCompleted(){} // RVA: 0x44D3050
        public void ValidateToken(){} // RVA: 0x44B56C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public UnityEngine.Object result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public UnityEngine.AssetBundle result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public UnityEngine.Networking.UnityWebRequest result; // 0x10

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

    public class UniTaskCompletionSourceCore`1
    {
        public ÎÌÎÍÏÌÌÍÎÏÍÍÍÏÎÍÏÍÏÌÍÍÏ result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44E0B30
        public void ReportUnhandledError(){} // RVA: 0x44E0C70
        public void MarkHandled(){} // RVA: 0x44B4C30
        public void TrySetResult(){} // RVA: 0x44E0DC0
        public void TrySetException(){} // RVA: 0x44E0ED0
        public void TrySetCanceled(){} // RVA: 0x44E1180
        public void get_Version(){} // RVA: 0x2892C90
        public void GetStatus(){} // RVA: 0x44E12C0
        public void UnsafeGetStatus(){} // RVA: 0x44E1400
        public void GetResult(){} // RVA: 0x44B52E0
        public void OnCompleted(){} // RVA: 0x44E14A0
        public void ValidateToken(){} // RVA: 0x44B56C0
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`3<int,System.ValueTuple`2<bool,bool>,bool> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44C90A0
        public void ReportUnhandledError(){} // RVA: 0x44C91E0
        public void MarkHandled(){} // RVA: 0x44B59B0
        public void TrySetResult(){} // RVA: 0x44C9330
        public void TrySetException(){} // RVA: 0x44C93F0
        public void TrySetCanceled(){} // RVA: 0x44C96A0
        public void get_Version(){} // RVA: 0x1C0F720
        public void GetStatus(){} // RVA: 0x44C97E0
        public void UnsafeGetStatus(){} // RVA: 0x44C9920
        public void GetResult(){} // RVA: 0x44B6050
        public void OnCompleted(){} // RVA: 0x44C99C0
        public void ValidateToken(){} // RVA: 0x44B6410
    }

    public class UniTaskCompletionSourceCore`1
    {
        public System.ValueTuple`2<bool,bool> result; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x44BBA10
        public void ReportUnhandledError(){} // RVA: 0x44BBB50
        public void MarkHandled(){} // RVA: 0x44B59B0
        public void TrySetResult(){} // RVA: 0x44BBCA0
        public void TrySetException(){} // RVA: 0x44BBD60
        public void TrySetCanceled(){} // RVA: 0x44BC010
        public void get_Version(){} // RVA: 0x1C0F720
        public void GetStatus(){} // RVA: 0x44BC150
        public void UnsafeGetStatus(){} // RVA: 0x44BC290
        public void GetResult(){} // RVA: 0x44BC330
        public void OnCompleted(){} // RVA: 0x44BC530
        public void ValidateToken(){} // RVA: 0x44B6410
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken;

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

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void MarkHandled(){} // RVA: 0x452C560
        public void get_Task(){} // RVA: 0x452E200
        public void TrySetResult(){} // RVA: 0x452F010
        public void TrySetCanceled(){} // RVA: 0x452F080
        public void TrySetException(){} // RVA: 0x452F0F0
        public void GetResult(){} // RVA: 0x452E5B0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x452C990
        public void GetStatus(){} // RVA: 0x37E0C0
        public void UnsafeGetStatus(){} // RVA: 0x37E0C0
        public void OnCompleted(){} // RVA: 0x452F320
        public void TrySignalCompletion(){} // RVA: 0x452F740
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void MarkHandled(){} // RVA: 0x452C560
        public void get_Task(){} // RVA: 0x452E200
        public void TrySetResult(){} // RVA: 0x452F010
        public void TrySetCanceled(){} // RVA: 0x452F080
        public void TrySetException(){} // RVA: 0x452F0F0
        public void GetResult(){} // RVA: 0x452E5B0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x452C990
        public void GetStatus(){} // RVA: 0x37E0C0
        public void UnsafeGetStatus(){} // RVA: 0x37E0C0
        public void OnCompleted(){} // RVA: 0x452F320
        public void TrySignalCompletion(){} // RVA: 0x452F740
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void MarkHandled(){} // RVA: 0x452C560
        public void get_Task(){} // RVA: 0x452E200
        public void TrySetResult(){} // RVA: 0x452F010
        public void TrySetCanceled(){} // RVA: 0x452F080
        public void TrySetException(){} // RVA: 0x452F0F0
        public void GetResult(){} // RVA: 0x452E5B0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x452C990
        public void GetStatus(){} // RVA: 0x37E0C0
        public void UnsafeGetStatus(){} // RVA: 0x37E0C0
        public void OnCompleted(){} // RVA: 0x452F320
        public void TrySignalCompletion(){} // RVA: 0x452F740
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void MarkHandled(){} // RVA: 0x452C560
        public void get_Task(){} // RVA: 0x452E200
        public void TrySetResult(){} // RVA: 0x452F010
        public void TrySetCanceled(){} // RVA: 0x452F080
        public void TrySetException(){} // RVA: 0x452F0F0
        public void GetResult(){} // RVA: 0x452E5B0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x452C990
        public void GetStatus(){} // RVA: 0x37E0C0
        public void UnsafeGetStatus(){} // RVA: 0x37E0C0
        public void OnCompleted(){} // RVA: 0x452F320
        public void TrySignalCompletion(){} // RVA: 0x452F740
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void MarkHandled(){} // RVA: 0x452C560
        public void get_Task(){} // RVA: 0x452C570
        public void TrySetResult(){} // RVA: 0x452C5D0
        public void TrySetCanceled(){} // RVA: 0x452C600
        public void TrySetException(){} // RVA: 0x452C670
        public void GetResult(){} // RVA: 0x452C8A0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x452C990
        public void GetStatus(){} // RVA: 0x37E0C0
        public void UnsafeGetStatus(){} // RVA: 0x37E0C0
        public void OnCompleted(){} // RVA: 0x452CA90
        public void TrySignalCompletion(){} // RVA: 0x452CEB0
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void MarkHandled(){} // RVA: 0x452C560
        public void get_Task(){} // RVA: 0x452E200
        public void TrySetResult(){} // RVA: 0x452F010
        public void TrySetCanceled(){} // RVA: 0x452F080
        public void TrySetException(){} // RVA: 0x452F0F0
        public void GetResult(){} // RVA: 0x452E5B0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x452C990
        public void GetStatus(){} // RVA: 0x37E0C0
        public void UnsafeGetStatus(){} // RVA: 0x37E0C0
        public void OnCompleted(){} // RVA: 0x452F320
        public void TrySignalCompletion(){} // RVA: 0x452F740
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

    public class UniTaskCompletionSource`1
    {
        public System.Threading.CancellationToken cancellationToken; // 0x10
    }

}