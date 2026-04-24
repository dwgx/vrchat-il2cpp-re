// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Channels
// Classes: 40
// Methods: 217

namespace ThirdParty.DotNet.System.Threading.Channels
{
    public class AsyncOperation : Object
    {
        public object _registration; // 0x30B29220

        // ── Original Methods ──
        public void AvailableSentinel(){} // RVA: 0x7ffaa8932310
        public void CompletedSentinel(){} // RVA: 0x7ffaa8932310
        public void ThrowIncompleteOperationException(){} // RVA: 0x7ffaaeaa0120
        public void ThrowMultipleContinuations(){} // RVA: 0x7ffaaeaa0190
        public void ThrowIncorrectCurrentIdException(){} // RVA: 0x7ffaaeaa0200
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaeaa0270
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        public object _runContinuationsAsynchronously; // 0x30B29220
        public object _error; // 0x30B29220
        public object _schedulingContext; // 0x30B29220
        public object _next; // 0x30B29220, was: <Next>k__BackingField
        public object _pooled; // 0x35096740
        public object _result; // 0x35096740

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void get_Next(){} // RVA: 0x7ffaa86491d0
        public void set_Next(){} // RVA: 0x7ffaa8660d80
        public void get_CancellationToken(){} // RVA: 0x7ffaa887e5c0
        public void get_ValueTask(){}
        public void get_ValueTaskOfT(){} // RVA: 0x7ffaa887e5c0
        public void get_IsCompleted(){} // RVA: 0x7ffaa864a040
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
        public void TryOwnAndReset(){} // RVA: 0x7ffaa864a040
        public void OnCompleted(){}
        public void UnregisterCancellation(){} // RVA: 0x7ffaa864a040
        public void TrySetResult(){} // RVA: 0x7ffaa887e5c0
        public void TrySetException(){} // RVA: 0x7ffaa864a2a0
        public void TrySetCanceled(){} // RVA: 0x7ffaa887e5c0
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x7ffaa864a040
        public void SignalCompletion(){} // RVA: 0x7ffaa8660cc0
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x7ffaa8660cc0
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7ffaa8660fc0
        public void QueueUserWorkItem(){} // RVA: 0x7ffaa8660fc0
        public void UnsafeRegister(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetStatus(){}
        public void GetResult(){} // RVA: 0x7ffaa887e5c0
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x7ffaa8660cc0
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        public object _runContinuationsAsynchronously; // 0x3149F2F0
        public object _error; // 0x3149F2F0
        public object _schedulingContext; // 0x3149F2F0
        public object _next; // 0x3149F2F0, was: <Next>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaacf5a380
        public void get_Next(){} // RVA: 0x7ffaa89add50
        public void set_Next(){} // RVA: 0x7ffaa89add60
        public void get_CancellationToken(){} // RVA: 0x7ffaa89fa590
        public void get_ValueTask(){} // RVA: 0x7ffaacf564f0
        public void get_ValueTaskOfT(){} // RVA: 0x7ffaacf56560
        public void get_IsCompleted(){} // RVA: 0x7ffaacf5a8b0
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7ffaacf5aa10
        public void TryOwnAndReset(){} // RVA: 0x7ffaacf5aaf0
        public void OnCompleted(){} // RVA: 0x7ffaacf5ad20
        public void UnregisterCancellation(){} // RVA: 0x7ffaacf5b240
        public void TrySetResult(){} // RVA: 0x7ffaacf5b2c0
        public void TrySetException(){} // RVA: 0x7ffaacf5b330
        public void TrySetCanceled(){} // RVA: 0x7ffaacf5b4a0
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x7ffaacf5b650
        public void SignalCompletion(){} // RVA: 0x7ffaacf5b6d0
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x7ffaacf5bf90
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7ffaacf5c180
        public void QueueUserWorkItem(){} // RVA: 0x7ffaacf5c1c0
        public void UnsafeRegister(){} // RVA: 0x7ffaacf5c330
        // ── Binary Analysis Named ──
        public void GetStatus(){} // RVA: 0x7ffaacf5a7c0
        public void GetResult(){} // RVA: 0x7ffaacf5a920
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x7ffaacf5bc90
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        public object _runContinuationsAsynchronously; // 0x35096740
        public object _error; // 0x35096740
        public object _schedulingContext; // 0x35096740
        public object _next; // 0x35096740, was: <Next>k__BackingField
        public object 8p; // 0x120001
        public object m_callbackInfo; // 0x30D40DD0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaacf58230
        public void get_Next(){} // RVA: 0x7ffaa89add50
        public void set_Next(){} // RVA: 0x7ffaa89add60
        public void get_CancellationToken(){} // RVA: 0x7ffaa89fa590
        public void get_ValueTask(){} // RVA: 0x7ffaacf564f0
        public void get_ValueTaskOfT(){} // RVA: 0x7ffaacf58670
        public void get_IsCompleted(){} // RVA: 0x7ffaacf587e0
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7ffaacf58940
        public void TryOwnAndReset(){} // RVA: 0x7ffaacf58a20
        public void OnCompleted(){} // RVA: 0x7ffaacf58c50
        public void UnregisterCancellation(){} // RVA: 0x7ffaacf59170
        public void TrySetResult(){} // RVA: 0x7ffaacf591f0
        public void TrySetException(){} // RVA: 0x7ffaacf592a0
        public void TrySetCanceled(){} // RVA: 0x7ffaacf59410
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x7ffaacf595c0
        public void SignalCompletion(){} // RVA: 0x7ffaacf59640
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x7ffaacf59f00
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7ffaacf5a0f0
        public void QueueUserWorkItem(){} // RVA: 0x7ffaacf5a130
        public void UnsafeRegister(){} // RVA: 0x7ffaacf5a2a0
        // ── Binary Analysis Named ──
        public void GetStatus(){} // RVA: 0x7ffaacf586f0
        public void GetResult(){} // RVA: 0x7ffaacf58850
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x7ffaacf59c00
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        public object _runContinuationsAsynchronously; // 0x35096F90
        public object _error; // 0x35096F90
        public object _schedulingContext; // 0x35096F90
        public object _next; // 0x35096F90, was: <Next>k__BackingField
        public object ); // 0x80020001

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaacf560b0
        public void get_Next(){} // RVA: 0x7ffaa89add50
        public void set_Next(){} // RVA: 0x7ffaa89add60
        public void get_CancellationToken(){} // RVA: 0x7ffaa89fa590
        public void get_ValueTask(){} // RVA: 0x7ffaacf564f0
        public void get_ValueTaskOfT(){} // RVA: 0x7ffaacf56560
        public void get_IsCompleted(){} // RVA: 0x7ffaacf566d0
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7ffaacf56830
        public void TryOwnAndReset(){} // RVA: 0x7ffaacf56910
        public void OnCompleted(){} // RVA: 0x7ffaacf56b40
        public void UnregisterCancellation(){} // RVA: 0x7ffaacf57060
        public void TrySetResult(){} // RVA: 0x7ffaacf570e0
        public void TrySetException(){} // RVA: 0x7ffaacf57150
        public void TrySetCanceled(){} // RVA: 0x7ffaacf572c0
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x7ffaacf57470
        public void SignalCompletion(){} // RVA: 0x7ffaacf574f0
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x7ffaacf57db0
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7ffaacf57fa0
        public void QueueUserWorkItem(){} // RVA: 0x7ffaacf57fe0
        public void UnsafeRegister(){} // RVA: 0x7ffaacf58150
        // ── Binary Analysis Named ──
        public void GetStatus(){} // RVA: 0x7ffaacf565e0
        public void GetResult(){} // RVA: 0x7ffaacf56740
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x7ffaacf57ab0
    }

    public class BoundedChannelOptions : ChannelOptions
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaeaa0570
        public void get_Capacity(){} // RVA: 0x7ffaa8b945a0
        public void get_FullMode(){} // RVA: 0x7ffaa9e5ac10
        public void set_FullMode(){} // RVA: 0x7ffaaeaa05e0
    }

    public class BoundedChannel`1 : Channel`1
    {
        public object _completion; // 0x30DE4370
        public object _blockedReaders; // 0x30DE4370
        public object _waitingWritersTail; // 0x30DE4370
        public object value__; // 0x30DE49B0

        // ── Original Methods ──
        public void get_SyncObj(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
    }

    public class Channel : Object
    {
        // ── Original Methods ──
        public void CreateUnbounded(){} // RVA: 0x7ffaa86492c0
        public void CreateBounded(){} // RVA: 0x7ffaa8649330
        public void CreateBounded(){} // RVA: 0x7ffaa8649330
    }

    public class ChannelOptions : Object
    {
        public object _allowSynchronousContinuations; // 0x35067980, was: <AllowSynchronousContinuations
        public object SingleWriter; // 0x17000012

        // ── Original Methods ──
        public void set_SingleWriter(){} // RVA: 0x7ffaa89fc5f0
        public void get_SingleReader(){} // RVA: 0x7ffaa8b37c40
        public void set_SingleReader(){} // RVA: 0x7ffaa919b040
        public void get_AllowSynchronousContinuations(){} // RVA: 0x7ffaa950f430
        public void set_AllowSynchronousContinuations(){} // RVA: 0x7ffaa9e38fe0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ChannelReader`1 : Object
    {
        // ── Original Methods ──
        public void TryRead(){} // RVA: 0x7ffaa864a2a0
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ChannelReader`1 : Object
    {
        // ── Original Methods ──
        public void TryRead(){} // RVA: 0x7ffaa864a2a0
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class ChannelReader`1 : Object
    {
        // ── Original Methods ──
        public void TryRead(){} // RVA: 0x7ffaa864a2a0
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ChannelReader`1 : Object
    {
        // ── Original Methods ──
        public void TryRead(){} // RVA: 0x7ffaa864a2a0
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ChannelReader`1 : Object
    {
    }

    public class ChannelReader`1 : Object
    {
    }

    public class ChannelReader`1 : Object
    {
        // ── Original Methods ──
        public void TryRead(){} // RVA: 0x7ffaa864a2a0
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ChannelUtilities : Object
    {
        public object s_falseTask; // 0x3171CB90

        // ── Original Methods ──
        public void Complete(){} // RVA: 0x7ffaaeaa0650
        public void QueueWaiter(){} // RVA: 0x7ffaaeaa0820
        public void WakeUpWaiters(){} // RVA: 0x7ffaaeaa09e0
        public void FailOperations(){} // RVA: 0x7ffaa8660fc0
        public void CreateInvalidCompletionException(){} // RVA: 0x7ffaaeaa0c70
        public void .cctor(){} // RVA: 0x7ffaaeaa0ea0
    }

    public class ChannelWriter`1 : Object
    {
        // ── Original Methods ──
        public void TryComplete(){} // RVA: 0x7ffaa864a2a0
        public void TryWrite(){} // RVA: 0x7ffaa887e5c0
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x7ffaa887e5c0
        public void WriteAsyncCore(){} // RVA: 0x7ffaa887e5c0
        public void Complete(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class ChannelWriter`1 : Object
    {
        // ── Original Methods ──
        public void TryComplete(){} // RVA: 0x7ffaa8932320
        public void TryWrite(){} // RVA: 0x7ffaa887e5c0
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x7ffaad833720
        public void WriteAsyncCore(){} // RVA: 0x7ffaad833a50
        public void Complete(){} // RVA: 0x7ffaad8336d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ChannelWriter`1 : Object
    {
        // ── Original Methods ──
        public void TryComplete(){} // RVA: 0x7ffaa8932320
        public void TryWrite(){} // RVA: 0x7ffaa887e5c0
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x7ffaad833720
        public void WriteAsyncCore(){} // RVA: 0x7ffaad833a50
        public void Complete(){} // RVA: 0x7ffaad8336d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ChannelWriter`1 : Object
    {
        // ── Original Methods ──
        public void TryComplete(){} // RVA: 0x7ffaa8932320
        public void TryWrite(){} // RVA: 0x7ffaa887e5c0
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x7ffaad833720
        public void WriteAsyncCore(){} // RVA: 0x7ffaad833a50
        public void Complete(){} // RVA: 0x7ffaad8336d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ChannelWriter`1 : Object
    {
        // ── Original Methods ──
        public void TryComplete(){} // RVA: 0x7ffaa8932320
        public void TryWrite(){} // RVA: 0x7ffaa864a2a0
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x7ffaad833280
        public void WriteAsyncCore(){} // RVA: 0x7ffaad8334a0
        public void Complete(){} // RVA: 0x7ffaad8336d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Channel`1 : Channel`2
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab211800
    }

    public class Channel`1 : Channel`2
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class Channel`1 : Channel`2
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab211800
    }

    public class Channel`1 : Channel`2
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab211800
    }

    public class Channel`1 : Channel`2
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Channel`2 : Object
    {
        // ── Original Methods ──
        public void get_Reader(){} // RVA: 0x7ffaa894d380
        public void set_Reader(){} // RVA: 0x7ffaa8933e30
        public void get_Writer(){} // RVA: 0x7ffaa89357c0
        public void set_Writer(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Channel`2 : Object
    {
        // ── Original Methods ──
        public void get_Reader(){} // RVA: 0x7ffaa894d380
        public void set_Reader(){} // RVA: 0x7ffaa8933e30
        public void get_Writer(){} // RVA: 0x7ffaa89357c0
        public void set_Writer(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Channel`2 : Object
    {
        public object _reader; // 0x3508A7D8, was: <Reader>k__BackingField

        // ── Original Methods ──
        public void get_Reader(){} // RVA: 0x7ffaa86491d0
        public void set_Reader(){} // RVA: 0x7ffaa8660d80
        public void get_Writer(){} // RVA: 0x7ffaa86491d0
        public void set_Writer(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class Channel`2 : Object
    {
        // ── Original Methods ──
        public void get_Reader(){} // RVA: 0x7ffaa894d380
        public void set_Reader(){} // RVA: 0x7ffaa8933e30
        public void get_Writer(){} // RVA: 0x7ffaa89357c0
        public void set_Writer(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Channel`2 : Object
    {
        // ── Original Methods ──
        public void get_Reader(){} // RVA: 0x7ffaa894d380
        public void set_Reader(){} // RVA: 0x7ffaa8933e30
        public void get_Writer(){} // RVA: 0x7ffaa89357c0
        public void set_Writer(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Channel`2 : Object
    {
        // ── Original Methods ──
        public void get_Reader(){} // RVA: 0x7ffaa894d380
        public void set_Reader(){} // RVA: 0x7ffaa8933e30
        public void get_Writer(){} // RVA: 0x7ffaa89357c0
        public void set_Writer(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        public object _runContinuationsAsynchronously; // 0x31390E80
        public object _waitingReader; // 0x31390E80
        public object _runContinuationsAsynchronously; // 0x3508A4C8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa86613a0
        public void get_SyncObj(){} // RVA: 0x7ffaa86491d0
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        public object _runContinuationsAsynchronously; // 0x3508A4C8
        public object _waitingReader; // 0x3508A4C8
        public object X00; // 0x3508AC68

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac340200
        public void get_SyncObj(){} // RVA: 0x7ffaa8960130
    }

    public class TaskCompletionSource : TaskCompletionSource`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaeaa11f0
        public void TrySetResult(){} // RVA: 0x7ffaaeaa1250
    }

    public class UnboundedChannelOptions : ChannelOptions
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class UnboundedChannel`1 : Channel`1
    {
        public object _blockedReaders; // 0x314686D0
        public object _doneWriting; // 0x314686D0
        public object _blockedReaders; // 0x3508ACD8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa86613a0
        public void get_SyncObj(){} // RVA: 0x7ffaa86491d0
    }

    public class UnboundedChannel`1 : Channel`1
    {
        public object _blockedReaders; // 0x3508ACD8
        public object _doneWriting; // 0x3508ACD8
    }

    public class VoidAsyncOperationWithData`1 : AsyncOperation`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void set_Item(){} // RVA: 0x7ffaa887e5c0
    }

}