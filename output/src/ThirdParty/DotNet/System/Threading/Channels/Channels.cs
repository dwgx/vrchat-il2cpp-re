// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Channels
// Classes: 44
// Methods: 220

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
        public System.Threading.CancellationTokenRegistration _registration;
        public bool _pooled;
        public bool _runContinuationsAsynchronously;
        public int _completionReserved;
        public T _result;

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

    public class AsyncOperation`1
    {
        public System.Threading.CancellationTokenRegistration `; // 0x10
        public bool set_Item; // 0x28
        public bool _runContinuationsAsynchronously; // 0x29
        public int _completionReserved; // 0x2C
        public System.VoidResult _result; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CBF370
        public void get_Next(){} // RVA: 0x358D50
        public void set_Next(){} // RVA: 0x358D60
        public void get_CancellationToken(){} // RVA: 0x3A5590
        public void get_ValueTask(){} // RVA: 0x4CBB4E0
        public void get_ValueTaskOfT(){} // RVA: 0x4CBB550
        public void GetStatus(){} // RVA: 0x4CBF7B0
        public void get_IsCompleted(){} // RVA: 0x4CBF8A0
        public void GetResult(){} // RVA: 0x4CBF910
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x4CBFA00
        public void TryOwnAndReset(){} // RVA: 0x4CBFAE0
        public void OnCompleted(){} // RVA: 0x4CBFD10
        public void UnregisterCancellation(){} // RVA: 0x4CC0230
        public void TrySetResult(){} // RVA: 0x4CC02B0
        public void TrySetException(){} // RVA: 0x4CC0320
        public void TrySetCanceled(){} // RVA: 0x4CC0490
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x4CC0640
        public void SignalCompletion(){} // RVA: 0x4CC06C0
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x4CC0C80
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x4CC0F80
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x4CC1170
        public void QueueUserWorkItem(){} // RVA: 0x4CC11B0
        public void UnsafeRegister(){} // RVA: 0x4CC1320
    }

    public class AsyncOperation`1
    {
        public System.Threading.CancellationTokenRegistration _registration; // 0x10
        public bool _pooled; // 0x28
        public bool _runContinuationsAsynchronously; // 0x29
        public int _completionReserved; // 0x2C
        public ZLogger.IZLoggerEntry _result; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CBD220
        public void get_Next(){} // RVA: 0x358D50
        public void set_Next(){} // RVA: 0x358D60
        public void get_CancellationToken(){} // RVA: 0x3A5590
        public void get_ValueTask(){} // RVA: 0x4CBB4E0
        public void get_ValueTaskOfT(){} // RVA: 0x4CBD660
        public void GetStatus(){} // RVA: 0x4CBD6E0
        public void get_IsCompleted(){} // RVA: 0x4CBD7D0
        public void GetResult(){} // RVA: 0x4CBD840
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x4CBD930
        public void TryOwnAndReset(){} // RVA: 0x4CBDA10
        public void OnCompleted(){} // RVA: 0x4CBDC40
        public void UnregisterCancellation(){} // RVA: 0x4CBE160
        public void TrySetResult(){} // RVA: 0x4CBE1E0
        public void TrySetException(){} // RVA: 0x4CBE290
        public void TrySetCanceled(){} // RVA: 0x4CBE400
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x4CBE5B0
        public void SignalCompletion(){} // RVA: 0x4CBE630
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x4CBEBF0
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x4CBEEF0
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x4CBF0E0
        public void QueueUserWorkItem(){} // RVA: 0x4CBF120
        public void UnsafeRegister(){} // RVA: 0x4CBF290
    }

    public class AsyncOperation`1
    {
        public System.Threading.CancellationTokenRegistration _registration; // 0x10
        public bool _pooled; // 0x28
        public bool _runContinuationsAsynchronously; // 0x29
        public int _completionReserved; // 0x2C
        public bool _result; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CBB0A0
        public void get_Next(){} // RVA: 0x358D50
        public void set_Next(){} // RVA: 0x358D60
        public void get_CancellationToken(){} // RVA: 0x3A5590
        public void get_ValueTask(){} // RVA: 0x4CBB4E0
        public void get_ValueTaskOfT(){} // RVA: 0x4CBB550
        public void GetStatus(){} // RVA: 0x4CBB5D0
        public void get_IsCompleted(){} // RVA: 0x4CBB6C0
        public void GetResult(){} // RVA: 0x4CBB730
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x4CBB820
        public void TryOwnAndReset(){} // RVA: 0x4CBB900
        public void OnCompleted(){} // RVA: 0x4CBBB30
        public void UnregisterCancellation(){} // RVA: 0x4CBC050
        public void TrySetResult(){} // RVA: 0x4CBC0D0
        public void TrySetException(){} // RVA: 0x4CBC140
        public void TrySetCanceled(){} // RVA: 0x4CBC2B0
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x4CBC460
        public void SignalCompletion(){} // RVA: 0x4CBC4E0
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x4CBCAA0
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x4CBCDA0
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x4CBCF90
        public void QueueUserWorkItem(){} // RVA: 0x4CBCFD0
        public void UnsafeRegister(){} // RVA: 0x4CBD140
    }

    public class BoundedChannelOptions
    {
        public int SingleWriter; // 0x18
        public 0x659EE4C0 SingleReader; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68E7A80
        public void get_Capacity(){} // RVA: 0x5BED50
        public void get_FullMode(){} // RVA: 0x197C3B0
        public void set_FullMode(){} // RVA: 0x68E7AF0
    }

    public class BoundedChannel`1
    {
        public 0x659EE4C0 _mode;

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
        public bool <SingleWriter>k__BackingField; // 0x10
        public bool <SingleReader>k__BackingField; // 0x11
        public bool <AllowSynchronousContinuations>k__BackingField; // 0x12

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

    public class ChannelReader`1
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0xDE40
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x24A50
    }

    public class ChannelReader`1
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0xDE40
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ChannelReader`1
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0xDE40
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ChannelReader`1
    {
    }

    public class ChannelReader`1
    {
    }

    public class ChannelReader`1
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0xDE40
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ChannelReader`1
    {
    }

    public class ChannelReader`1
    {
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

    public class ChannelWriter`1
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x2DD320
        public void TryWrite(){} // RVA: 0x283FA0
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x5771ED0
        public void WriteAsyncCore(){} // RVA: 0x5772200
        public void Complete(){} // RVA: 0x5771E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ChannelWriter`1
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x2DD320
        public void TryWrite(){} // RVA: 0x283FA0
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x5771ED0
        public void WriteAsyncCore(){} // RVA: 0x5772200
        public void Complete(){} // RVA: 0x5771E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ChannelWriter`1
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x2DD320
        public void TryWrite(){} // RVA: 0x283FA0
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x5771ED0
        public void WriteAsyncCore(){} // RVA: 0x5772200
        public void Complete(){} // RVA: 0x5771E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ChannelWriter`1
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x2DD320
        public void TryWrite(){} // RVA: 0xDE40
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x5771A30
        public void WriteAsyncCore(){} // RVA: 0x5771C50
        public void Complete(){} // RVA: 0x5771E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E751C0
    }

    public class Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
    }

    public class Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E751C0
    }

    public class Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E751C0
    }

    public class Channel`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Channel`2
    {
        public System.Threading.Channels.ChannelReader`1<T> <Reader>k__BackingField; // 0x10
        public System.Threading.Channels.ChannelWriter`1<T> <Writer>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x2F8380
        public void set_Reader(){} // RVA: 0x2DEE30
        public void get_Writer(){} // RVA: 0x2E07C0
        public void set_Writer(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Channel`2
    {
        public System.Threading.Channels.ChannelReader`1<T> <Reader>k__BackingField; // 0x10
        public System.Threading.Channels.ChannelWriter`1<T> <Writer>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x2F8380
        public void set_Reader(){} // RVA: 0x2DEE30
        public void get_Writer(){} // RVA: 0x2E07C0
        public void set_Writer(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Channel`2
    {
        public System.Threading.Channels.ChannelReader`1<T> <Reader>k__BackingField;
        public System.Threading.Channels.ChannelWriter`1<U> <Writer>k__BackingField;

        // ── Methods ──
        public void get_Reader(){} // RVA: 0xCD60
        public void set_Reader(){} // RVA: 0x24B10
        public void get_Writer(){} // RVA: 0xCD60
        public void set_Writer(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24A50
    }

    public class Channel`2
    {
        public System.Threading.Channels.ChannelReader`1<T> <Reader>k__BackingField; // 0x10
        public System.Threading.Channels.ChannelWriter`1<T> <Writer>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x2F8380
        public void set_Reader(){} // RVA: 0x2DEE30
        public void get_Writer(){} // RVA: 0x2E07C0
        public void set_Writer(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Channel`2
    {
        public System.Threading.Channels.ChannelReader`1<T> <Reader>k__BackingField; // 0x10
        public System.Threading.Channels.ChannelWriter`1<T> <Writer>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x2F8380
        public void set_Reader(){} // RVA: 0x2DEE30
        public void get_Writer(){} // RVA: 0x2E07C0
        public void set_Writer(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Channel`2
    {
        public System.Threading.Channels.ChannelReader`1<ZLogger.IZLoggerEntry> <Reader>k__BackingField; // 0x10
        public System.Threading.Channels.ChannelWriter`1<ZLogger.IZLoggerEntry> <Writer>k__BackingField; // 0x18

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
        public System.Threading.Channels.TaskCompletionSource instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25130
        public void get_SyncObj(){} // RVA: 0xCD60
    }

    public class SingleConsumerUnboundedChannel`1
    {
        public System.Threading.Channels.TaskCompletionSource _completion; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4027AA0
        public void get_SyncObj(){} // RVA: 0x30B130
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
        public System.Threading.Channels.TaskCompletionSource _completion;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25130
        public void get_SyncObj(){} // RVA: 0xCD60
    }

    public class UnboundedChannel`1
    {
        public System.Threading.Channels.TaskCompletionSource _completion; // 0x20
    }

    public class VoidAsyncOperationWithData`1
    {
        public T <Item>k__BackingField;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
    }

}