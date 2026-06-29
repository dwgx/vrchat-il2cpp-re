// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 100
// Methods: 656

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class UniTaskCompletionSource : Object
    {
        public object cancellationToken;
        public object exception;
        public object gate;
        public object singleContinuation;
        public object singleState;
        public object secondaryContinuationList;
        public object intStatus;
        public object handled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void MarkHandled(){} // RVA: 0x775E2B0
        public void get_Task(){} // RVA: 0x775E2C0
        public void TrySetResult(){} // RVA: 0x775E320
        public void TrySetCanceled(){} // RVA: 0x775E330
        public void TrySetException(){} // RVA: 0x775E3A0
        public void GetResult(){} // RVA: 0x775E590
        public void GetStatus(){} // RVA: 0xBE5850
        public void UnsafeGetStatus(){} // RVA: 0xBE5850
        public void OnCompleted(){} // RVA: 0x775E690
        public void TrySignalCompletion(){} // RVA: 0x775EA80
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x55AAE0
        public void ReportUnhandledError(){} // RVA: 0x55AAF0
        public void MarkHandled(){} // RVA: 0x54C8D0
        public void TrySetResult(){} // RVA: 0x55AB00
        public void TrySetException(){} // RVA: 0x55AB10
        public void TrySetCanceled(){} // RVA: 0x55AB20
        public void get_Version(){} // RVA: 0x93030
        public void GetStatus(){} // RVA: 0x55AB30
        public void UnsafeGetStatus(){} // RVA: 0x55AB40
        public void GetResult(){} // RVA: 0x54CA60
        public void OnCompleted(){} // RVA: 0x55AB50
        public void ValidateToken(){} // RVA: 0x5481A0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x55AAE0
        public void ReportUnhandledError(){} // RVA: 0x55AAF0
        public void MarkHandled(){} // RVA: 0x54C8D0
        public void TrySetResult(){} // RVA: 0x55AB00
        public void TrySetException(){} // RVA: 0x55AB10
        public void TrySetCanceled(){} // RVA: 0x55AB20
        public void get_Version(){} // RVA: 0x93030
        public void GetStatus(){} // RVA: 0x55AB30
        public void UnsafeGetStatus(){} // RVA: 0x55AB40
        public void GetResult(){} // RVA: 0x54CA60
        public void OnCompleted(){} // RVA: 0x55AB50
        public void ValidateToken(){} // RVA: 0x5481A0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x55AAE0
        public void ReportUnhandledError(){} // RVA: 0x55AAF0
        public void MarkHandled(){} // RVA: 0x54C8D0
        public void TrySetResult(){} // RVA: 0x55AB00
        public void TrySetException(){} // RVA: 0x55AB10
        public void TrySetCanceled(){} // RVA: 0x55AB20
        public void get_Version(){} // RVA: 0x93030
        public void GetStatus(){} // RVA: 0x55AB30
        public void UnsafeGetStatus(){} // RVA: 0x55AB40
        public void GetResult(){} // RVA: 0x54CA60
        public void OnCompleted(){} // RVA: 0x55AB50
        public void ValidateToken(){} // RVA: 0x5481A0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x55AAE0
        public void ReportUnhandledError(){} // RVA: 0x55AAF0
        public void MarkHandled(){} // RVA: 0x54C8D0
        public void TrySetResult(){} // RVA: 0x55AB00
        public void TrySetException(){} // RVA: 0x55AB10
        public void TrySetCanceled(){} // RVA: 0x55AB20
        public void get_Version(){} // RVA: 0x93030
        public void GetStatus(){} // RVA: 0x55AB30
        public void UnsafeGetStatus(){} // RVA: 0x55AB40
        public void GetResult(){} // RVA: 0x54CA60
        public void OnCompleted(){} // RVA: 0x55AB50
        public void ValidateToken(){} // RVA: 0x5481A0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x55AAE0
        public void ReportUnhandledError(){} // RVA: 0x55AAF0
        public void MarkHandled(){} // RVA: 0x54C8D0
        public void TrySetResult(){} // RVA: 0x55AB00
        public void TrySetException(){} // RVA: 0x55AB10
        public void TrySetCanceled(){} // RVA: 0x55AB20
        public void get_Version(){} // RVA: 0x93030
        public void GetStatus(){} // RVA: 0x55AB30
        public void UnsafeGetStatus(){} // RVA: 0x55AB40
        public void GetResult(){} // RVA: 0x54CA60
        public void OnCompleted(){} // RVA: 0x55AB50
        public void ValidateToken(){} // RVA: 0x5481A0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x54D170
        public void ReportUnhandledError(){} // RVA: 0x54D180
        public void MarkHandled(){} // RVA: 0x54C490
        public void TrySetResult(){} // RVA: 0x54D190
        public void TrySetException(){} // RVA: 0x54D1C0
        public void TrySetCanceled(){} // RVA: 0x54D1D0
        public void get_Version(){} // RVA: 0x54C620
        public void GetStatus(){} // RVA: 0x54D310
        public void UnsafeGetStatus(){} // RVA: 0x54D320
        public void GetResult(){} // RVA: 0x54C650
        public void OnCompleted(){} // RVA: 0x54D330
        public void ValidateToken(){} // RVA: 0x54A810
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x54E010
        public void ReportUnhandledError(){} // RVA: 0x54E020
        public void MarkHandled(){} // RVA: 0x54C6C0
        public void TrySetResult(){} // RVA: 0x54E030
        public void TrySetException(){} // RVA: 0x54E050
        public void TrySetCanceled(){} // RVA: 0x54E060
        public void get_Version(){} // RVA: 0x54C840
        public void GetStatus(){} // RVA: 0x54E1A0
        public void UnsafeGetStatus(){} // RVA: 0x54E1B0
        public void GetResult(){} // RVA: 0x54C870
        public void OnCompleted(){} // RVA: 0x54E1C0
        public void ValidateToken(){} // RVA: 0x54A150
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x54E1D0
        public void ReportUnhandledError(){} // RVA: 0x54E1E0
        public void MarkHandled(){} // RVA: 0x54DBE0
        public void TrySetResult(){} // RVA: 0x54E1F0
        public void TrySetException(){} // RVA: 0x54E230
        public void TrySetCanceled(){} // RVA: 0x54E240
        public void get_Version(){} // RVA: 0x425380
        public void GetStatus(){} // RVA: 0x54E250
        public void UnsafeGetStatus(){} // RVA: 0x54E260
        public void GetResult(){} // RVA: 0x54DDA0
        public void OnCompleted(){} // RVA: 0x54E270
        public void ValidateToken(){} // RVA: 0x54DDF0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x55AAE0
        public void ReportUnhandledError(){} // RVA: 0x55AAF0
        public void MarkHandled(){} // RVA: 0x54C8D0
        public void TrySetResult(){} // RVA: 0x55AB00
        public void TrySetException(){} // RVA: 0x55AB10
        public void TrySetCanceled(){} // RVA: 0x55AB20
        public void get_Version(){} // RVA: 0x93030
        public void GetStatus(){} // RVA: 0x55AB30
        public void UnsafeGetStatus(){} // RVA: 0x55AB40
        public void GetResult(){} // RVA: 0x54CA60
        public void OnCompleted(){} // RVA: 0x55AB50
        public void ValidateToken(){} // RVA: 0x5481A0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x557440
        public void ReportUnhandledError(){} // RVA: 0x557450
        public void MarkHandled(){} // RVA: 0x54C8D0
        public void TrySetResult(){} // RVA: 0x557460
        public void TrySetException(){} // RVA: 0x557470
        public void TrySetCanceled(){} // RVA: 0x557480
        public void get_Version(){} // RVA: 0x93030
        public void GetStatus(){} // RVA: 0x5575C0
        public void UnsafeGetStatus(){} // RVA: 0x5575D0
        public void GetResult(){} // RVA: 0x54CA60
        public void OnCompleted(){} // RVA: 0x5575E0
        public void ValidateToken(){} // RVA: 0x5481A0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x54E610
        public void ReportUnhandledError(){} // RVA: 0x54E620
        public void MarkHandled(){} // RVA: 0x54C6C0
        public void TrySetResult(){} // RVA: 0x54E630
        public void TrySetException(){} // RVA: 0x54E650
        public void TrySetCanceled(){} // RVA: 0x54E660
        public void get_Version(){} // RVA: 0x54C840
        public void GetStatus(){} // RVA: 0x54E7A0
        public void UnsafeGetStatus(){} // RVA: 0x54E7B0
        public void GetResult(){} // RVA: 0x54C870
        public void OnCompleted(){} // RVA: 0x54E7C0
        public void ValidateToken(){} // RVA: 0x54A150
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x557DC0
        public void ReportUnhandledError(){} // RVA: 0x557DD0
        public void MarkHandled(){} // RVA: 0x54C6C0
        public void TrySetResult(){} // RVA: 0x557DE0
        public void TrySetException(){} // RVA: 0x557E00
        public void TrySetCanceled(){} // RVA: 0x557E10
        public void get_Version(){} // RVA: 0x54C840
        public void GetStatus(){} // RVA: 0x557F50
        public void UnsafeGetStatus(){} // RVA: 0x557F60
        public void GetResult(){} // RVA: 0x54C870
        public void OnCompleted(){} // RVA: 0x557F70
        public void ValidateToken(){} // RVA: 0x54A150
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x55AAE0
        public void ReportUnhandledError(){} // RVA: 0x55AAF0
        public void MarkHandled(){} // RVA: 0x54C8D0
        public void TrySetResult(){} // RVA: 0x55AB00
        public void TrySetException(){} // RVA: 0x55AB10
        public void TrySetCanceled(){} // RVA: 0x55AB20
        public void get_Version(){} // RVA: 0x93030
        public void GetStatus(){} // RVA: 0x55AB30
        public void UnsafeGetStatus(){} // RVA: 0x55AB40
        public void GetResult(){} // RVA: 0x54CA60
        public void OnCompleted(){} // RVA: 0x55AB50
        public void ValidateToken(){} // RVA: 0x5481A0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x55AAE0
        public void ReportUnhandledError(){} // RVA: 0x55AAF0
        public void MarkHandled(){} // RVA: 0x54C8D0
        public void TrySetResult(){} // RVA: 0x55AB00
        public void TrySetException(){} // RVA: 0x55AB10
        public void TrySetCanceled(){} // RVA: 0x55AB20
        public void get_Version(){} // RVA: 0x93030
        public void GetStatus(){} // RVA: 0x55AB30
        public void UnsafeGetStatus(){} // RVA: 0x55AB40
        public void GetResult(){} // RVA: 0x54CA60
        public void OnCompleted(){} // RVA: 0x55AB50
        public void ValidateToken(){} // RVA: 0x5481A0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x54E010
        public void ReportUnhandledError(){} // RVA: 0x54E020
        public void MarkHandled(){} // RVA: 0x54C6C0
        public void TrySetResult(){} // RVA: 0x54E030
        public void TrySetException(){} // RVA: 0x54E050
        public void TrySetCanceled(){} // RVA: 0x54E060
        public void get_Version(){} // RVA: 0x54C840
        public void GetStatus(){} // RVA: 0x54E1A0
        public void UnsafeGetStatus(){} // RVA: 0x54E1B0
        public void GetResult(){} // RVA: 0x54C870
        public void OnCompleted(){} // RVA: 0x54E1C0
        public void ValidateToken(){} // RVA: 0x54A150
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x54E610
        public void ReportUnhandledError(){} // RVA: 0x54E620
        public void MarkHandled(){} // RVA: 0x54C6C0
        public void TrySetResult(){} // RVA: 0x54E630
        public void TrySetException(){} // RVA: 0x54E650
        public void TrySetCanceled(){} // RVA: 0x54E660
        public void get_Version(){} // RVA: 0x54C840
        public void GetStatus(){} // RVA: 0x54E7A0
        public void UnsafeGetStatus(){} // RVA: 0x54E7B0
        public void GetResult(){} // RVA: 0x54C870
        public void OnCompleted(){} // RVA: 0x54E7C0
        public void ValidateToken(){} // RVA: 0x54A150
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x54E010
        public void ReportUnhandledError(){} // RVA: 0x54E020
        public void MarkHandled(){} // RVA: 0x54C6C0
        public void TrySetResult(){} // RVA: 0x54E030
        public void TrySetException(){} // RVA: 0x54E050
        public void TrySetCanceled(){} // RVA: 0x54E060
        public void get_Version(){} // RVA: 0x54C840
        public void GetStatus(){} // RVA: 0x54E1A0
        public void UnsafeGetStatus(){} // RVA: 0x54E1B0
        public void GetResult(){} // RVA: 0x54C870
        public void OnCompleted(){} // RVA: 0x54E1C0
        public void ValidateToken(){} // RVA: 0x54A150
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x54DA80
        public void ReportUnhandledError(){} // RVA: 0x54DBD0
        public void MarkHandled(){} // RVA: 0x54DBE0
        public void TrySetResult(){} // RVA: 0x54DBF0
        public void TrySetException(){} // RVA: 0x54DC30
        public void TrySetCanceled(){} // RVA: 0x54DC40
        public void get_Version(){} // RVA: 0x425380
        public void GetStatus(){} // RVA: 0x54DD80
        public void UnsafeGetStatus(){} // RVA: 0x54DD90
        public void GetResult(){} // RVA: 0x54DDA0
        public void OnCompleted(){} // RVA: 0x54DDE0
        public void ValidateToken(){} // RVA: 0x54DDF0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x54E280
        public void ReportUnhandledError(){} // RVA: 0x54E290
        public void MarkHandled(){} // RVA: 0x54D490
        public void TrySetResult(){} // RVA: 0x54E2A0
        public void TrySetException(){} // RVA: 0x54E2D0
        public void TrySetCanceled(){} // RVA: 0x54E2E0
        public void get_Version(){} // RVA: 0x54D620
        public void GetStatus(){} // RVA: 0x54E420
        public void UnsafeGetStatus(){} // RVA: 0x54E430
        public void GetResult(){} // RVA: 0x54D650
        public void OnCompleted(){} // RVA: 0x54E440
        public void ValidateToken(){} // RVA: 0x54A4B0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x5602B0
        public void ReportUnhandledError(){} // RVA: 0x5602C0
        public void MarkHandled(){} // RVA: 0x54DBE0
        public void TrySetResult(){} // RVA: 0x5602D0
        public void TrySetException(){} // RVA: 0x560310
        public void TrySetCanceled(){} // RVA: 0x560320
        public void get_Version(){} // RVA: 0x425380
        public void GetStatus(){} // RVA: 0x560460
        public void UnsafeGetStatus(){} // RVA: 0x560470
        public void GetResult(){} // RVA: 0x54DDA0
        public void OnCompleted(){} // RVA: 0x560480
        public void ValidateToken(){} // RVA: 0x54DDF0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x55AAE0
        public void ReportUnhandledError(){} // RVA: 0x55AAF0
        public void MarkHandled(){} // RVA: 0x54C8D0
        public void TrySetResult(){} // RVA: 0x55AB00
        public void TrySetException(){} // RVA: 0x55AB10
        public void TrySetCanceled(){} // RVA: 0x55AB20
        public void get_Version(){} // RVA: 0x93030
        public void GetStatus(){} // RVA: 0x55AB30
        public void UnsafeGetStatus(){} // RVA: 0x55AB40
        public void GetResult(){} // RVA: 0x54CA60
        public void OnCompleted(){} // RVA: 0x55AB50
        public void ValidateToken(){} // RVA: 0x5481A0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x54E450
        public void ReportUnhandledError(){} // RVA: 0x54E460
        public void MarkHandled(){} // RVA: 0x54C6C0
        public void TrySetResult(){} // RVA: 0x54E470
        public void TrySetException(){} // RVA: 0x54E490
        public void TrySetCanceled(){} // RVA: 0x54E4A0
        public void get_Version(){} // RVA: 0x54C840
        public void GetStatus(){} // RVA: 0x54E5E0
        public void UnsafeGetStatus(){} // RVA: 0x54E5F0
        public void GetResult(){} // RVA: 0x54C870
        public void OnCompleted(){} // RVA: 0x54E600
        public void ValidateToken(){} // RVA: 0x54A150
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x559E20
        public void ReportUnhandledError(){} // RVA: 0x559E30
        public void MarkHandled(){} // RVA: 0x54C490
        public void TrySetResult(){} // RVA: 0x559E40
        public void TrySetException(){} // RVA: 0x559E70
        public void TrySetCanceled(){} // RVA: 0x559E80
        public void get_Version(){} // RVA: 0x54C620
        public void GetStatus(){} // RVA: 0x559FC0
        public void UnsafeGetStatus(){} // RVA: 0x559FD0
        public void GetResult(){} // RVA: 0x54C650
        public void OnCompleted(){} // RVA: 0x559FE0
        public void ValidateToken(){} // RVA: 0x54A810
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x55AAE0
        public void ReportUnhandledError(){} // RVA: 0x55AAF0
        public void MarkHandled(){} // RVA: 0x54C8D0
        public void TrySetResult(){} // RVA: 0x55AB00
        public void TrySetException(){} // RVA: 0x55AB10
        public void TrySetCanceled(){} // RVA: 0x55AB20
        public void get_Version(){} // RVA: 0x93030
        public void GetStatus(){} // RVA: 0x55AB30
        public void UnsafeGetStatus(){} // RVA: 0x55AB40
        public void GetResult(){} // RVA: 0x54CA60
        public void OnCompleted(){} // RVA: 0x55AB50
        public void ValidateToken(){} // RVA: 0x5481A0
    }

    public class UniTaskCompletionSourceCore`1 : ValueType
    {
        public object result;
        public object error;
        public object version;
        public object hasUnhandledError;
        public object completedCount;
        public object continuation;
        public object continuationState;

        // ── Methods ──
        public void Reset(){} // RVA: 0x55AAE0
        public void ReportUnhandledError(){} // RVA: 0x55AAF0
        public void MarkHandled(){} // RVA: 0x54C8D0
        public void TrySetResult(){} // RVA: 0x55AB00
        public void TrySetException(){} // RVA: 0x55AB10
        public void TrySetCanceled(){} // RVA: 0x55AB20
        public void get_Version(){} // RVA: 0x93030
        public void GetStatus(){} // RVA: 0x55AB30
        public void UnsafeGetStatus(){} // RVA: 0x55AB40
        public void GetResult(){} // RVA: 0x54CA60
        public void OnCompleted(){} // RVA: 0x55AB50
        public void ValidateToken(){} // RVA: 0x5481A0
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
        public void get_Task(){} // RVA: 0x502A960
        public void MarkHandled(){} // RVA: 0x5028DB0
        public void TrySetResult(){} // RVA: 0x502B700
        public void TrySetCanceled(){} // RVA: 0x502B770
        public void TrySetException(){} // RVA: 0x502B7E0
        public void GetResult(){} // RVA: 0x502AD00
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x50291C0
        public void GetStatus(){} // RVA: 0xBE5890
        public void UnsafeGetStatus(){} // RVA: 0xBE5890
        public void OnCompleted(){} // RVA: 0x502B9F0
        public void TrySignalCompletion(){} // RVA: 0x502BDE0
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
        public void MarkHandled(){} // RVA: 0x5028DB0
        public void TrySetResult(){} // RVA: 0x502B700
        public void TrySetCanceled(){} // RVA: 0x502B770
        public void TrySetException(){} // RVA: 0x502B7E0
        public void GetResult(){} // RVA: 0x502AD00
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x50291C0
        public void GetStatus(){} // RVA: 0xBE5890
        public void UnsafeGetStatus(){} // RVA: 0xBE5890
        public void OnCompleted(){} // RVA: 0x502B9F0
        public void TrySignalCompletion(){} // RVA: 0x502BDE0
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
        public void MarkHandled(){} // RVA: 0x5028DB0
        public void TrySetResult(){} // RVA: 0x502B700
        public void TrySetCanceled(){} // RVA: 0x502B770
        public void TrySetException(){} // RVA: 0x502B7E0
        public void GetResult(){} // RVA: 0x502AD00
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x50291C0
        public void GetStatus(){} // RVA: 0xBE5890
        public void UnsafeGetStatus(){} // RVA: 0xBE5890
        public void OnCompleted(){} // RVA: 0x502B9F0
        public void TrySignalCompletion(){} // RVA: 0x502BDE0
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
        public void MarkHandled(){} // RVA: 0x5028DB0
        public void TrySetResult(){} // RVA: 0x502B700
        public void TrySetCanceled(){} // RVA: 0x502B770
        public void TrySetException(){} // RVA: 0x502B7E0
        public void GetResult(){} // RVA: 0x502AD00
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x50291C0
        public void GetStatus(){} // RVA: 0xBE5890
        public void UnsafeGetStatus(){} // RVA: 0xBE5890
        public void OnCompleted(){} // RVA: 0x502B9F0
        public void TrySignalCompletion(){} // RVA: 0x502BDE0
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
        public void get_Task(){} // RVA: 0x502F2D0
        public void MarkHandled(){} // RVA: 0x502F2C0
        public void TrySetResult(){} // RVA: 0x502F300
        public void TrySetCanceled(){} // RVA: 0x502F3A0
        public void TrySetException(){} // RVA: 0x502F410
        public void GetResult(){} // RVA: 0x502F6A0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x502F7B0
        public void GetStatus(){} // RVA: 0x23ADD10
        public void UnsafeGetStatus(){} // RVA: 0x23ADD10
        public void OnCompleted(){} // RVA: 0x502F8B0
        public void TrySignalCompletion(){} // RVA: 0x502FCA0
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
        public void TrySetCanceled(){} // RVA: 0x5030240
        public void get_Task(){} // RVA: 0x5026580
        public void .ctor(){} // RVA: 0xB43310
        public void MarkHandled(){} // RVA: 0x5026570
        public void TrySetResult(){} // RVA: 0x50301C0
        public void TrySetException(){} // RVA: 0x50302B0
        public void GetResult(){} // RVA: 0x5026980
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x5026A80
        public void GetStatus(){} // RVA: 0x12BB630
        public void UnsafeGetStatus(){} // RVA: 0x12BB630
        public void OnCompleted(){} // RVA: 0x50304C0
        public void TrySignalCompletion(){} // RVA: 0x50308B0
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
        public void get_Task(){} // RVA: 0x5023E20
        public void MarkHandled(){} // RVA: 0x5023E10
        public void TrySetResult(){} // RVA: 0x5023EA0
        public void TrySetCanceled(){} // RVA: 0x5023F30
        public void TrySetException(){} // RVA: 0x5023FA0
        public void GetResult(){} // RVA: 0x50241B0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x50242C0
        public void GetStatus(){} // RVA: 0x2536460
        public void UnsafeGetStatus(){} // RVA: 0x2536460
        public void OnCompleted(){} // RVA: 0x50243C0
        public void TrySignalCompletion(){} // RVA: 0x50247B0
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
        public void get_Task(){} // RVA: 0x5029BD0
        public void MarkHandled(){} // RVA: 0x5028DB0
        public void TrySetResult(){} // RVA: 0x5029C30
        public void TrySetCanceled(){} // RVA: 0x5029C60
        public void TrySetException(){} // RVA: 0x5029CD0
        public void GetResult(){} // RVA: 0x5029F60
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x50291C0
        public void GetStatus(){} // RVA: 0xBE5890
        public void UnsafeGetStatus(){} // RVA: 0xBE5890
        public void OnCompleted(){} // RVA: 0x502A050
        public void TrySignalCompletion(){} // RVA: 0x502A440
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
        public void MarkHandled(){} // RVA: 0x5028DB0
        public void TrySetResult(){} // RVA: 0x502B700
        public void TrySetCanceled(){} // RVA: 0x502B770
        public void TrySetException(){} // RVA: 0x502B7E0
        public void GetResult(){} // RVA: 0x502AD00
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x50291C0
        public void GetStatus(){} // RVA: 0xBE5890
        public void UnsafeGetStatus(){} // RVA: 0xBE5890
        public void OnCompleted(){} // RVA: 0x502B9F0
        public void TrySignalCompletion(){} // RVA: 0x502BDE0
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
        public void MarkHandled(){} // RVA: 0x5028DB0
        public void TrySetResult(){} // RVA: 0x502A9D0
        public void TrySetCanceled(){} // RVA: 0x502AA00
        public void TrySetException(){} // RVA: 0x502AA70
        public void GetResult(){} // RVA: 0x502AD00
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x50291C0
        public void GetStatus(){} // RVA: 0xBE5890
        public void UnsafeGetStatus(){} // RVA: 0xBE5890
        public void OnCompleted(){} // RVA: 0x502ADF0
        public void TrySignalCompletion(){} // RVA: 0x502B1E0
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

    public class UniTaskCompletionSource`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class UniTask[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class UniTask[][] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
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
        public void op_Implicit(){} // RVA: 0x508CB90
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
        public void op_Implicit(){} // RVA: 0x508CB90
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
        public void get_Status(){} // RVA: 0x560A60
        public void .ctor(){} // RVA: 0x5A5740
        public void SuppressCancellationThrow(){} // RVA: 0x5A09A0
        public void GetAwaiter(){} // RVA: 0x560A70
        public void Preserve(){} // RVA: 0x560B40
        public void AsUniTask(){} // RVA: 0x5A5820
        public void op_Implicit(){} // RVA: 0x50870D0
        public void ToString(){} // RVA: 0x5A5850
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A1DB0
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x508CB90
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x508CB90
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x508CB90
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x508CB90
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void .ctor(){} // RVA: 0x5613C0
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
        public void op_Implicit(){} // RVA: 0x508CB90
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x508CB90
    }

    public class UniTask`1 : ValueType
    {
        public object source;
        public object result;
        public object token;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x508CBF0
        public void .ctor(){} // RVA: 0x5613C0
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
        public void op_Implicit(){} // RVA: 0x508CB90
    }

    public class UniTask`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DD60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34170
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class UniTask`1[][] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}