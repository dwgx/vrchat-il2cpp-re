// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Channels
// Classes: 39
// Methods: 218

namespace ThirdParty.DotNet.System.Threading.Channels
{
    public class AsyncOperation : Object
    {
        public object s_availableSentinel;
        public object s_completedSentinel;

        // ── Methods ──
        public void AvailableSentinel(){} // RVA: 0xB43310
        public void CompletedSentinel(){} // RVA: 0xB43310
        public void ThrowIncompleteOperationException(){} // RVA: 0x734C040
        public void ThrowMultipleContinuations(){} // RVA: 0x734C0B0
        public void ThrowIncorrectCurrentIdException(){} // RVA: 0x734C120
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x734C190
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        public object _registration;
        public object _pooled;
        public object _runContinuationsAsynchronously;
        public object _completionReserved;
        public object _result;
        public object _error;
        public object _continuation;
        public object _continuationState;
        public object _schedulingContext;
        public object _executionContext;
        public object _currentId;
        public object _next;
        public object _cancellationToken;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void get_Next(){} // RVA: 0x87C0A0
        public void set_Next(){} // RVA: 0x894320
        public void get_CancellationToken(){} // RVA: 0xA94080
        public void get_ValueTask(){} // RVA: 0x87BEB0
        public void get_ValueTaskOfT(){} // RVA: 0xA94080
        public void GetStatus(){} // RVA: 0x87D010
        public void get_IsCompleted(){} // RVA: 0x87D280
        public void GetResult(){} // RVA: 0xA94080
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x894470
        public void TryOwnAndReset(){} // RVA: 0x87D280
        public void OnCompleted(){} // RVA: 0x89DDB0
        public void UnregisterCancellation(){} // RVA: 0x87D280
        public void TrySetResult(){} // RVA: 0xA94080
        public void TrySetException(){} // RVA: 0x87D350
        public void TrySetCanceled(){} // RVA: 0xA94080
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x87D280
        public void SignalCompletion(){} // RVA: 0x894290
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x894290
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x894290
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x8945C0
        public void QueueUserWorkItem(){} // RVA: 0x8945C0
        public void UnsafeRegister(){} // RVA: 0xA94080
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        public object _registration;
        public object _pooled;
        public object _runContinuationsAsynchronously;
        public object _completionReserved;
        public object _result;
        public object _error;
        public object _continuation;
        public object _continuationState;
        public object _schedulingContext;
        public object _executionContext;
        public object _currentId;
        public object _next;
        public object _cancellationToken;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5774080
        public void get_Next(){} // RVA: 0xBBFF90
        public void set_Next(){} // RVA: 0xBBFFA0
        public void get_CancellationToken(){} // RVA: 0xC10050
        public void get_ValueTask(){} // RVA: 0x5772340
        public void get_ValueTaskOfT(){} // RVA: 0x57744C0
        public void GetStatus(){} // RVA: 0x5774540
        public void get_IsCompleted(){} // RVA: 0x5774630
        public void GetResult(){} // RVA: 0x57746A0
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x5774790
        public void TryOwnAndReset(){} // RVA: 0x5774870
        public void OnCompleted(){} // RVA: 0x5774AA0
        public void UnregisterCancellation(){} // RVA: 0x5774FD0
        public void TrySetResult(){} // RVA: 0x5775050
        public void TrySetException(){} // RVA: 0x5775100
        public void TrySetCanceled(){} // RVA: 0x5775270
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x5775420
        public void SignalCompletion(){} // RVA: 0x57754A0
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x5775A50
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x5775D50
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x5775F40
        public void QueueUserWorkItem(){} // RVA: 0x5775F80
        public void UnsafeRegister(){} // RVA: 0x57760F0
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        public object _registration;
        public object _pooled;
        public object _runContinuationsAsynchronously;
        public object _completionReserved;
        public object _result;
        public object _error;
        public object _continuation;
        public object _continuationState;
        public object _schedulingContext;
        public object _executionContext;
        public object _currentId;
        public object _next;
        public object _cancellationToken;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5771F00
        public void get_Next(){} // RVA: 0xBBFF90
        public void set_Next(){} // RVA: 0xBBFFA0
        public void get_CancellationToken(){} // RVA: 0xC10050
        public void get_ValueTask(){} // RVA: 0x5772340
        public void get_ValueTaskOfT(){} // RVA: 0x57723B0
        public void GetStatus(){} // RVA: 0x5772430
        public void get_IsCompleted(){} // RVA: 0x5772520
        public void GetResult(){} // RVA: 0x5772590
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x5772680
        public void TryOwnAndReset(){} // RVA: 0x5772760
        public void OnCompleted(){} // RVA: 0x5772990
        public void UnregisterCancellation(){} // RVA: 0x5772EC0
        public void TrySetResult(){} // RVA: 0x5772F40
        public void TrySetException(){} // RVA: 0x5772FB0
        public void TrySetCanceled(){} // RVA: 0x5773120
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x57732D0
        public void SignalCompletion(){} // RVA: 0x5773350
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x5773900
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x5773C00
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x5773DF0
        public void QueueUserWorkItem(){} // RVA: 0x5773E30
        public void UnsafeRegister(){} // RVA: 0x5773FA0
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        public object _registration;
        public object _pooled;
        public object _runContinuationsAsynchronously;
        public object _completionReserved;
        public object _result;
        public object _error;
        public object _continuation;
        public object _continuationState;
        public object _schedulingContext;
        public object _executionContext;
        public object _currentId;
        public object _next;
        public object _cancellationToken;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x57761D0
        public void get_Next(){} // RVA: 0xBBFF90
        public void set_Next(){} // RVA: 0xBBFFA0
        public void get_CancellationToken(){} // RVA: 0xC10050
        public void get_ValueTask(){} // RVA: 0x5772340
        public void get_ValueTaskOfT(){} // RVA: 0x57723B0
        public void GetStatus(){} // RVA: 0x5776610
        public void get_IsCompleted(){} // RVA: 0x5776700
        public void GetResult(){} // RVA: 0x5776770
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x5776860
        public void TryOwnAndReset(){} // RVA: 0x5776940
        public void OnCompleted(){} // RVA: 0x5776B70
        public void UnregisterCancellation(){} // RVA: 0x57770A0
        public void TrySetResult(){} // RVA: 0x5777120
        public void TrySetException(){} // RVA: 0x5777190
        public void TrySetCanceled(){} // RVA: 0x5777300
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x57774B0
        public void SignalCompletion(){} // RVA: 0x5777530
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x5777AE0
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x5777DE0
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x5777FD0
        public void QueueUserWorkItem(){} // RVA: 0x5778010
        public void UnsafeRegister(){} // RVA: 0x5778180
    }

    public class BoundedChannelOptions : ChannelOptions
    {
        public object _capacity;
        public object _mode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x734C490
        public void get_Capacity(){} // RVA: 0xE62D00
        public void get_FullMode(){} // RVA: 0x2244FB0
        public void set_FullMode(){} // RVA: 0x734C500
    }

    public class BoundedChannel`1 : Channel`1
    {
        public object _mode;
        public object _itemDropped;
        public object _completion;
        public object _bufferedCapacity;
        public object _items;
        public object _blockedReaders;
        public object _blockedWriters;
        public object _waitingReadersTail;
        public object _waitingWritersTail;
        public object _runContinuationsAsynchronously;
        public object _doneWriting;

        // ── Methods ──
        public void get_SyncObj(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0xA94080
    }

    public class Channel : Object
    {
        // ── Methods ──
        public void CreateUnbounded(){} // RVA: 0x3026480
        public void CreateBounded(){} // RVA: 0x3026160
    }

    public class ChannelClosedException : InvalidOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class ChannelOptions : Object
    {
        public object _singleWriter;
        public object _singleReader;
        public object _allowSynchronousContinuations;

        // ── Methods ──
        public void set_SingleWriter(){} // RVA: 0xC120B0
        public void get_SingleReader(){} // RVA: 0xDD5C50
        public void set_SingleReader(){} // RVA: 0xDD7A00
        public void get_AllowSynchronousContinuations(){} // RVA: 0x22201E0
        public void set_AllowSynchronousContinuations(){} // RVA: 0x22201F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x87D350
        public void WaitToReadAsync(){} // RVA: 0x87C240
        public void .ctor(){} // RVA: 0x894290
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x87D350
        public void WaitToReadAsync(){} // RVA: 0x87C240
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x87D350
        public void WaitToReadAsync(){} // RVA: 0x87C240
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x87D350
        public void WaitToReadAsync(){} // RVA: 0x87C240
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x87D350
        public void WaitToReadAsync(){} // RVA: 0x87C240
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ChannelUtilities : Object
    {
        public object s_doneWritingSentinel;
        public object s_trueTask;
        public object s_falseTask;
        public object s_neverCompletingTask;

        // ── Methods ──
        public void Complete(){} // RVA: 0x734C570
        public void QueueWaiter(){} // RVA: 0x734C730
        public void WakeUpWaiters(){} // RVA: 0x734C8F0
        public void FailOperations(){} // RVA: 0x8945C0
        public void CreateInvalidCompletionException(){} // RVA: 0x734CB80
        public void .cctor(){} // RVA: 0x734CDB0
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x87D350
        public void TryWrite(){} // RVA: 0xA94080
        public void WaitToWriteAsync(){} // RVA: 0x87C240
        public void WriteAsync(){} // RVA: 0xA94080
        public void WriteAsyncCore(){} // RVA: 0xA94080
        public void Complete(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x894290
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0xB43320
        public void TryWrite(){} // RVA: 0xA94080
        public void WaitToWriteAsync(){} // RVA: 0x87C240
        public void WriteAsync(){} // RVA: 0x629C1D0
        public void WriteAsyncCore(){} // RVA: 0x629C4F0
        public void Complete(){} // RVA: 0x629C180
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0xB43320
        public void TryWrite(){} // RVA: 0x87D350
        public void WaitToWriteAsync(){} // RVA: 0x87C240
        public void WriteAsync(){} // RVA: 0x629BD20
        public void WriteAsyncCore(){} // RVA: 0x629BF50
        public void Complete(){} // RVA: 0x629C180
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0xB43320
        public void TryWrite(){} // RVA: 0xA94080
        public void WaitToWriteAsync(){} // RVA: 0x87C240
        public void WriteAsync(){} // RVA: 0x629C1D0
        public void WriteAsyncCore(){} // RVA: 0x629C4F0
        public void Complete(){} // RVA: 0x629C180
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0xB43320
        public void TryWrite(){} // RVA: 0xA94080
        public void WaitToWriteAsync(){} // RVA: 0x87C240
        public void WriteAsync(){} // RVA: 0x629C1D0
        public void WriteAsyncCore(){} // RVA: 0x629C4F0
        public void Complete(){} // RVA: 0x629C180
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3896ED0
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3896ED0
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3896ED0
    }

    public class Channel`2 : Object
    {
        public object _reader;
        public object _writer;

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x87C0A0
        public void set_Reader(){} // RVA: 0x894320
        public void get_Writer(){} // RVA: 0x87C0A0
        public void set_Writer(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x894290
    }

    public class Channel`2 : Object
    {
        public object _reader;
        public object _writer;

        // ── Methods ──
        public void get_Reader(){} // RVA: 0xB5DBF0
        public void set_Reader(){} // RVA: 0xB44D60
        public void get_Writer(){} // RVA: 0xB465B0
        public void set_Writer(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Channel`2 : Object
    {
        public object _reader;
        public object _writer;

        // ── Methods ──
        public void get_Reader(){} // RVA: 0xB5DBF0
        public void set_Reader(){} // RVA: 0xB44D60
        public void get_Writer(){} // RVA: 0xB465B0
        public void set_Writer(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Channel`2 : Object
    {
        public object _reader;
        public object _writer;

        // ── Methods ──
        public void get_Reader(){} // RVA: 0xB5DBF0
        public void set_Reader(){} // RVA: 0xB44D60
        public void get_Writer(){} // RVA: 0xB465B0
        public void set_Writer(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Channel`2 : Object
    {
        public object _reader;
        public object _writer;

        // ── Methods ──
        public void get_Reader(){} // RVA: 0xB5DBF0
        public void set_Reader(){} // RVA: 0xB44D60
        public void get_Writer(){} // RVA: 0xB465B0
        public void set_Writer(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Channel`2 : Object
    {
        public object _reader;
        public object _writer;

        // ── Methods ──
        public void get_Reader(){} // RVA: 0xB5DBF0
        public void set_Reader(){} // RVA: 0xB44D60
        public void get_Writer(){} // RVA: 0xB465B0
        public void set_Writer(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        public object _completion;
        public object _items;
        public object _runContinuationsAsynchronously;
        public object _doneWriting;
        public object _blockedReader;
        public object _waitingReader;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894750
        public void get_SyncObj(){} // RVA: 0x87C0A0
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        public object _completion;
        public object _items;
        public object _runContinuationsAsynchronously;
        public object _doneWriting;
        public object _blockedReader;
        public object _waitingReader;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4ACEF00
        public void get_SyncObj(){} // RVA: 0xB70160
    }

    public class TaskCompletionSource : TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x734D100
        public void TrySetResult(){} // RVA: 0x734D160
    }

    public class UnboundedChannelOptions : ChannelOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnboundedChannel`1 : Channel`1
    {
        public object _completion;
        public object _items;
        public object _blockedReaders;
        public object _runContinuationsAsynchronously;
        public object _waitingReadersTail;
        public object _doneWriting;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894750
        public void get_SyncObj(){} // RVA: 0x87C0A0
    }

    public class UnboundedChannel`1 : Channel`1
    {
        public object _completion;
        public object _items;
        public object _blockedReaders;
        public object _runContinuationsAsynchronously;
        public object _waitingReadersTail;
        public object _doneWriting;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4FEEA80
    }

    public class VoidAsyncOperationWithData`1 : AsyncOperation`1
    {
        public object _item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
    }

}