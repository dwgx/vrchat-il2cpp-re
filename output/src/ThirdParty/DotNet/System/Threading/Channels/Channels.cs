// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Channels
// Classes: 18
// Methods: 80

namespace ThirdParty.DotNet.System.Threading.Channels
{
    public class AsyncOperation
    {
        // ── Methods ──
        public void AvailableSentinel(){} // RVA: 0x2DD310
        public void CompletedSentinel(){} // RVA: 0x2DD310
        public void ThrowIncompleteOperationException(){} // RVA: 0x68E7630
        public void ThrowMultipleContinuations(){} // RVA: 0x68E76A0
        public void ThrowIncorrectCurrentIdException(){} // RVA: 0x68E7710
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x68E7780
    }

    public class AsyncOperation`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void get_Next(){} // RVA: 0xCD60
        public void set_Next(){} // RVA: 0x24B10
        public void get_CancellationToken(){} // RVA: 0x283FA0
        public void get_ValueTask(){}
        public void get_ValueTaskOfT(){} // RVA: 0x283FA0
        public void GetStatus(){}
        public void get_IsCompleted(){} // RVA: 0xDBE0
        public void GetResult(){} // RVA: 0x283FA0
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x24C40
        public void TryOwnAndReset(){} // RVA: 0xDBE0
        public void OnCompleted(){}
        public void UnregisterCancellation(){} // RVA: 0xDBE0
        public void TrySetResult(){} // RVA: 0x283FA0
        public void TrySetException(){} // RVA: 0xDE40
        public void TrySetCanceled(){} // RVA: 0x283FA0
        public void TryReserveCompletionIfCancelable(){} // RVA: 0xDBE0
        public void SignalCompletion(){} // RVA: 0x24A50
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x24A50
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x24A50
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x24D50
        public void QueueUserWorkItem(){} // RVA: 0x24D50
        public void UnsafeRegister(){} // RVA: 0x283FA0
    }

    public class BoundedChannelOptions
    {
        public object SingleWriter;
        public object SingleReader;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68E7A80
        public void get_Capacity(){} // RVA: 0x5BED50
        public void get_FullMode(){} // RVA: 0x197C3B0
        public void set_FullMode(){} // RVA: 0x68E7AF0
    }

    public class BoundedChannel`1
    {
        // ── Methods ──
        public void get_SyncObj(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x283FA0
    }

    public class Channel
    {
        // ── Methods ──
        public void CreateUnbounded(){} // RVA: 0xCE50
        public void CreateBounded(){} // RVA: 0xCEC0 | overloaded x2
    }

    public class ChannelClosedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class ChannelOptions
    {
        // ── Methods ──
        public void set_SingleWriter(){} // RVA: 0x3A75F0
        public void get_SingleReader(){} // RVA: 0x543460
        public void set_SingleReader(){} // RVA: 0x543470
        public void get_AllowSynchronousContinuations(){} // RVA: 0x195A940
        public void set_AllowSynchronousContinuations(){} // RVA: 0x195A9A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ChannelReader`1
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0xDE40
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ChannelUtilities
    {
        // ── Methods ──
        public void Complete(){} // RVA: 0x68E7B60
        public void QueueWaiter(){} // RVA: 0x68E7D30
        public void WakeUpWaiters(){} // RVA: 0x68E7EF0
        public void FailOperations(){} // RVA: 0x24D50
        public void CreateInvalidCompletionException(){} // RVA: 0x68E8180
        public void .cctor(){} // RVA: 0x68E83B0
    }

    public class ChannelWriter`1
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0xDE40
        public void TryWrite(){} // RVA: 0x283FA0
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x283FA0
        public void WriteAsyncCore(){} // RVA: 0x283FA0
        public void Complete(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24A50
    }

    public class Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E751C0
    }

    public class Channel`2
    {
        // ── Methods ──
        public void get_Reader(){} // RVA: 0x2F8380
        public void set_Reader(){} // RVA: 0x2DEE30
        public void get_Writer(){} // RVA: 0x2E07C0
        public void set_Writer(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DebugEnumeratorDebugView`1
    {
    }

    public class SingleConsumerUnboundedChannel`1
    {
        public object instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25130
        public void get_SyncObj(){} // RVA: 0xCD60
    }

    public class TaskCompletionSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68E8700
        public void TrySetResult(){} // RVA: 0x68E8760
    }

    public class UnboundedChannelOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UnboundedChannel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x25130
        public void get_SyncObj(){} // RVA: 0xCD60
    }

    public class VoidAsyncOperationWithData`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
    }

}