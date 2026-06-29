// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Channels
// Classes: 39
// Methods: 218

namespace ThirdParty.DotNet.System.Threading.Channels
{
    public class AsyncOperation : Object
    {
        // ── Methods ──
        public void AvailableSentinel(){} // RVA: 0x7A80D7310
        public void CompletedSentinel(){} // RVA: 0x7A80D7310
        public void ThrowIncompleteOperationException(){} // RVA: 0x7AE6D5ED0
        public void ThrowMultipleContinuations(){} // RVA: 0x7AE6D5F40
        public void ThrowIncorrectCurrentIdException(){} // RVA: 0x7AE6D5FB0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE6D6020
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
        public void get_Next(){} // RVA: 0x7A7E00680
        public void set_Next(){} // RVA: 0x7A7E18800
        public void get_CancellationToken(){} // RVA: 0x7A8051B10
        public void get_ValueTask(){} // RVA: 0x7A7E00490
        public void get_ValueTaskOfT(){} // RVA: 0x7A8051B10
        public void GetStatus(){} // RVA: 0x7A7E015F0
        public void get_IsCompleted(){} // RVA: 0x7A7E01900
        public void GetResult(){} // RVA: 0x7A8051B10
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7A7E18950
        public void TryOwnAndReset(){} // RVA: 0x7A7E01900
        public void OnCompleted(){} // RVA: 0x7A7E22080
        public void UnregisterCancellation(){} // RVA: 0x7A7E01900
        public void TrySetResult(){} // RVA: 0x7A8051B10
        public void TrySetException(){} // RVA: 0x7A7E019D0
        public void TrySetCanceled(){} // RVA: 0x7A8051B10
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x7A7E01900
        public void SignalCompletion(){} // RVA: 0x7A7E18770
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x7A7E18770
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x7A7E18770
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7A7E18AA0
        public void QueueUserWorkItem(){} // RVA: 0x7A7E18AA0
        public void UnsafeRegister(){} // RVA: 0x7A8051B10
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC918080
        public void get_Next(){} // RVA: 0x7A8153390
        public void set_Next(){} // RVA: 0x7A81533A0
        public void get_CancellationToken(){} // RVA: 0x7A81A00E0
        public void get_ValueTask(){} // RVA: 0x7AC916330
        public void get_ValueTaskOfT(){} // RVA: 0x7AC9184C0
        public void GetStatus(){} // RVA: 0x7AC918540
        public void get_IsCompleted(){} // RVA: 0x7AC918630
        public void GetResult(){} // RVA: 0x7AC9186A0
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7AC918790
        public void TryOwnAndReset(){} // RVA: 0x7AC918870
        public void OnCompleted(){} // RVA: 0x7AC918AA0
        public void UnregisterCancellation(){} // RVA: 0x7AC918FE0
        public void TrySetResult(){} // RVA: 0x7AC919060
        public void TrySetException(){} // RVA: 0x7AC919110
        public void TrySetCanceled(){} // RVA: 0x7AC919280
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x7AC919430
        public void SignalCompletion(){} // RVA: 0x7AC9194B0
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x7AC919A60
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x7AC919D60
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7AC919F50
        public void QueueUserWorkItem(){} // RVA: 0x7AC919F90
        public void UnsafeRegister(){} // RVA: 0x7AC91A100
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC915EF0
        public void get_Next(){} // RVA: 0x7A8153390
        public void set_Next(){} // RVA: 0x7A81533A0
        public void get_CancellationToken(){} // RVA: 0x7A81A00E0
        public void get_ValueTask(){} // RVA: 0x7AC916330
        public void get_ValueTaskOfT(){} // RVA: 0x7AC9163A0
        public void GetStatus(){} // RVA: 0x7AC916420
        public void get_IsCompleted(){} // RVA: 0x7AC916510
        public void GetResult(){} // RVA: 0x7AC916580
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7AC916670
        public void TryOwnAndReset(){} // RVA: 0x7AC916750
        public void OnCompleted(){} // RVA: 0x7AC916980
        public void UnregisterCancellation(){} // RVA: 0x7AC916EC0
        public void TrySetResult(){} // RVA: 0x7AC916F40
        public void TrySetException(){} // RVA: 0x7AC916FB0
        public void TrySetCanceled(){} // RVA: 0x7AC917120
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x7AC9172D0
        public void SignalCompletion(){} // RVA: 0x7AC917350
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x7AC917900
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x7AC917C00
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7AC917DF0
        public void QueueUserWorkItem(){} // RVA: 0x7AC917E30
        public void UnsafeRegister(){} // RVA: 0x7AC917FA0
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC91A1E0
        public void get_Next(){} // RVA: 0x7A8153390
        public void set_Next(){} // RVA: 0x7A81533A0
        public void get_CancellationToken(){} // RVA: 0x7A81A00E0
        public void get_ValueTask(){} // RVA: 0x7AC916330
        public void get_ValueTaskOfT(){} // RVA: 0x7AC9163A0
        public void GetStatus(){} // RVA: 0x7AC91A620
        public void get_IsCompleted(){} // RVA: 0x7AC91A710
        public void GetResult(){} // RVA: 0x7AC91A780
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7AC91A870
        public void TryOwnAndReset(){} // RVA: 0x7AC91A950
        public void OnCompleted(){} // RVA: 0x7AC91AB80
        public void UnregisterCancellation(){} // RVA: 0x7AC91B0C0
        public void TrySetResult(){} // RVA: 0x7AC91B140
        public void TrySetException(){} // RVA: 0x7AC91B1B0
        public void TrySetCanceled(){} // RVA: 0x7AC91B320
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x7AC91B4D0
        public void SignalCompletion(){} // RVA: 0x7AC91B550
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x7AC91BB00
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x7AC91BE00
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7AC91BFF0
        public void QueueUserWorkItem(){} // RVA: 0x7AC91C030
        public void UnsafeRegister(){} // RVA: 0x7AC91C1A0
    }

    public class BoundedChannelOptions : ChannelOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6D6320
        public void get_Capacity(){} // RVA: 0x7A83782A0
        public void get_FullMode(){} // RVA: 0x7A9739200
        public void set_FullMode(){} // RVA: 0x7AE6D6390
    }

    public class BoundedChannel`1 : Channel`1
    {
        // ── Methods ──
        public void get_SyncObj(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A8051B10
    }

    public class Channel : Object
    {
        // ── Methods ──
        public void CreateUnbounded(){} // RVA: 0x7AA407670
        public void CreateBounded(){} // RVA: 0x7AA407350
    }

    public class ChannelClosedException : InvalidOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class ChannelOptions : Object
    {
        // ── Methods ──
        public void set_SingleWriter(){} // RVA: 0x7A81A2210
        public void get_SingleReader(){} // RVA: 0x7A82FBFB0
        public void set_SingleReader(){} // RVA: 0x7A82FBFC0
        public void get_AllowSynchronousContinuations(){} // RVA: 0x7A9716B70
        public void set_AllowSynchronousContinuations(){} // RVA: 0x7A9716BD0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x7A7E019D0
        public void WaitToReadAsync(){} // RVA: 0x7A7E00820
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x7A7E019D0
        public void WaitToReadAsync(){} // RVA: 0x7A7E00820
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x7A7E019D0
        public void WaitToReadAsync(){} // RVA: 0x7A7E00820
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x7A7E019D0
        public void WaitToReadAsync(){} // RVA: 0x7A7E00820
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x7A7E019D0
        public void WaitToReadAsync(){} // RVA: 0x7A7E00820
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ChannelUtilities : Object
    {
        // ── Methods ──
        public void Complete(){} // RVA: 0x7AE6D6400
        public void QueueWaiter(){} // RVA: 0x7AE6D65C0
        public void WakeUpWaiters(){} // RVA: 0x7AE6D6780
        public void FailOperations(){} // RVA: 0x7A7E18AA0
        public void CreateInvalidCompletionException(){} // RVA: 0x7AE6D6A10
        public void .cctor(){} // RVA: 0x7AE6D6C40
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x7A7E019D0
        public void TryWrite(){} // RVA: 0x7A8051B10
        public void WaitToWriteAsync(){} // RVA: 0x7A7E00820
        public void WriteAsync(){} // RVA: 0x7A8051B10
        public void WriteAsyncCore(){} // RVA: 0x7A8051B10
        public void Complete(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x7A80D7320
        public void TryWrite(){} // RVA: 0x7A8051B10
        public void WaitToWriteAsync(){} // RVA: 0x7A7E00820
        public void WriteAsync(){} // RVA: 0x7AD540F00
        public void WriteAsyncCore(){} // RVA: 0x7AD541220
        public void Complete(){} // RVA: 0x7AD540EB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x7A80D7320
        public void TryWrite(){} // RVA: 0x7A7E019D0
        public void WaitToWriteAsync(){} // RVA: 0x7A7E00820
        public void WriteAsync(){} // RVA: 0x7AD540A50
        public void WriteAsyncCore(){} // RVA: 0x7AD540C80
        public void Complete(){} // RVA: 0x7AD540EB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x7A80D7320
        public void TryWrite(){} // RVA: 0x7A8051B10
        public void WaitToWriteAsync(){} // RVA: 0x7A7E00820
        public void WriteAsync(){} // RVA: 0x7AD540F00
        public void WriteAsyncCore(){} // RVA: 0x7AD541220
        public void Complete(){} // RVA: 0x7AD540EB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x7A80D7320
        public void TryWrite(){} // RVA: 0x7A8051B10
        public void WaitToWriteAsync(){} // RVA: 0x7A7E00820
        public void WriteAsync(){} // RVA: 0x7AD540F00
        public void WriteAsyncCore(){} // RVA: 0x7AD541220
        public void Complete(){} // RVA: 0x7AD540EB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAC6CC10
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAC6CC10
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAC6CC10
    }

    public class Channel`2 : Object
    {
        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7A7E00680
        public void set_Reader(){} // RVA: 0x7A7E18800
        public void get_Writer(){} // RVA: 0x7A7E00680
        public void set_Writer(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class Channel`2 : Object
    {
        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7A80F2570
        public void set_Reader(){} // RVA: 0x7A80D8E20
        public void get_Writer(){} // RVA: 0x7A80DA7B0
        public void set_Writer(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Channel`2 : Object
    {
        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7A80F2570
        public void set_Reader(){} // RVA: 0x7A80D8E20
        public void get_Writer(){} // RVA: 0x7A80DA7B0
        public void set_Writer(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Channel`2 : Object
    {
        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7A80F2570
        public void set_Reader(){} // RVA: 0x7A80D8E20
        public void get_Writer(){} // RVA: 0x7A80DA7B0
        public void set_Writer(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Channel`2 : Object
    {
        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7A80F2570
        public void set_Reader(){} // RVA: 0x7A80D8E20
        public void get_Writer(){} // RVA: 0x7A80DA7B0
        public void set_Writer(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Channel`2 : Object
    {
        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7A80F2570
        public void set_Reader(){} // RVA: 0x7A80D8E20
        public void get_Writer(){} // RVA: 0x7A80DA7B0
        public void set_Writer(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18C30
        public void get_SyncObj(){} // RVA: 0x7A7E00680
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABE1D4F0
        public void get_SyncObj(){} // RVA: 0x7A8105330
    }

    public class TaskCompletionSource : TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6D6F90
        public void TrySetResult(){} // RVA: 0x7AE6D6FF0
    }

    public class UnboundedChannelOptions : ChannelOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UnboundedChannel`1 : Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18C30
        public void get_SyncObj(){} // RVA: 0x7A7E00680
    }

    public class UnboundedChannel`1 : Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC2A15E0
    }

    public class VoidAsyncOperationWithData`1 : AsyncOperation`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
        public void get_Item(){} // RVA: 0x7A8051B10
        public void set_Item(){} // RVA: 0x7A8051B10
    }

}