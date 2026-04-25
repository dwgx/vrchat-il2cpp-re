// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Channels
// Classes: 18
// Methods: 80

namespace ThirdParty.DotNet.System.Threading.Channels
{
    public class AsyncOperation : Object
    {
        public System.Action`1<object> s_availableSentinel;
        public System.Action`1<object> s_completedSentinel; // 0x8

        // ── Methods ──
        public void AvailableSentinel(){} // RVA: 0x7FFAC2F21310
        public void CompletedSentinel(){} // RVA: 0x7FFAC2F21310
        public void ThrowIncompleteOperationException(){} // RVA: 0x7FFAC907E150
        public void ThrowMultipleContinuations(){} // RVA: 0x7FFAC907E1C0
        public void ThrowIncorrectCurrentIdException(){} // RVA: 0x7FFAC907E230
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC907E2A0
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        public System.Threading.CancellationTokenRegistration Next;
        public bool CancellationToken;
        public bool ValueTask;
        public int ValueTaskOfT;
        public T IsCompleted;
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo _error;
        public System.Action`1<object> _continuation;
        public object _continuationState;
        public object _schedulingContext;
        public System.Threading.ExecutionContext _executionContext;
        public short _currentId;
        public System.Threading.Channels.AsyncOperation`1<T> <Next>k__BackingField;
        public System.Threading.CancellationToken <CancellationToken>k__BackingField;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void get_Next(){} // RVA: 0x7FFAC2C58E90
        public void set_Next(){} // RVA: 0x7FFAC2C70A40
        public void get_CancellationToken(){} // RVA: 0x7FFAC2E8DC40
        public void get_ValueTask(){}
        public void get_ValueTaskOfT(){} // RVA: 0x7FFAC2E8DC40
        public void GetStatus(){}
        public void get_IsCompleted(){} // RVA: 0x7FFAC2C59D00
        public void GetResult(){} // RVA: 0x7FFAC2E8DC40
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
        public void TryOwnAndReset(){} // RVA: 0x7FFAC2C59D00
        public void OnCompleted(){}
        public void UnregisterCancellation(){} // RVA: 0x7FFAC2C59D00
        public void TrySetResult(){} // RVA: 0x7FFAC2E8DC40
        public void TrySetException(){} // RVA: 0x7FFAC2C59F60
        public void TrySetCanceled(){} // RVA: 0x7FFAC2E8DC40
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x7FFAC2C59D00
        public void SignalCompletion(){} // RVA: 0x7FFAC2C70980
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x7FFAC2C70980
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x7FFAC2C70980
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7FFAC2C70C80
        public void QueueUserWorkItem(){} // RVA: 0x7FFAC2C70C80
        public void UnsafeRegister(){} // RVA: 0x7FFAC2E8DC40
    }

    public class BoundedChannelOptions : ChannelOptions
    {
        public int Capacity; // 0x18
        public 0x6B2CB400 FullMode; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC907E5A0
        public void get_Capacity(){} // RVA: 0x7FFAC3157800
        public void get_FullMode(){} // RVA: 0x7FFAC44357F0
        public void set_FullMode(){} // RVA: 0x7FFAC907E610
    }

    public class BoundedChannel`1 : Channel`1
    {
        public 0x6B2CB400 SyncObj;
        public System.Action`1<T> _itemDropped;
        public System.Threading.Channels.TaskCompletionSource _completion;
        public int _bufferedCapacity;
        public System.Collections.Generic.Deque`1<T> _items;
        public System.Collections.Generic.Deque`1<System.Threading.Channels.AsyncOperation`1<T>> _blockedReaders;
        public System.Collections.Generic.Deque`1<System.Threading.Channels.VoidAsyncOperationWithData`1<T>> _blockedWriters;
        public System.Threading.Channels.AsyncOperation`1<bool> _waitingReadersTail;
        public System.Threading.Channels.AsyncOperation`1<bool> _waitingWritersTail;
        public bool _runContinuationsAsynchronously;
        public System.Exception _doneWriting;

        // ── Methods ──
        public void get_SyncObj(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Channel : Object
    {
        // ── Methods ──
        public void CreateUnbounded(){} // RVA: 0x7FFAC2C58F80
        public void CreateBounded(){} // RVA: 0x7FFAC2C58FF0 | overloaded x2
    }

    public class ChannelClosedException : InvalidOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class ChannelOptions : Object
    {
        public bool SingleWriter; // 0x10
        public bool SingleReader; // 0x11
        public bool AllowSynchronousContinuations; // 0x12

        // ── Methods ──
        public void set_SingleWriter(){} // RVA: 0x7FFAC2FEB5F0
        public void get_SingleReader(){} // RVA: 0x7FFAC3771DA0
        public void set_SingleReader(){} // RVA: 0x7FFAC3771D90
        public void get_AllowSynchronousContinuations(){} // RVA: 0x7FFAC3AE1A90
        public void set_AllowSynchronousContinuations(){} // RVA: 0x7FFAC4411DE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x7FFAC2C59F60
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ChannelUtilities : Object
    {
        public System.Exception s_doneWritingSentinel;
        public System.Threading.Tasks.Task`1<bool> s_trueTask; // 0x8
        public System.Threading.Tasks.Task`1<bool> s_falseTask; // 0x10
        public System.Threading.Tasks.Task s_neverCompletingTask; // 0x18

        // ── Methods ──
        public void Complete(){} // RVA: 0x7FFAC907E680
        public void QueueWaiter(){} // RVA: 0x7FFAC907E850
        public void WakeUpWaiters(){} // RVA: 0x7FFAC907EA10
        public void FailOperations(){} // RVA: 0x7FFAC2C70C80
        public void CreateInvalidCompletionException(){} // RVA: 0x7FFAC907ECA0
        public void .cctor(){} // RVA: 0x7FFAC907EED0
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x7FFAC2C59F60
        public void TryWrite(){} // RVA: 0x7FFAC2E8DC40
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x7FFAC2E8DC40
        public void WriteAsyncCore(){} // RVA: 0x7FFAC2E8DC40
        public void Complete(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5807970
    }

    public class Channel`2 : Object
    {
        public System.Threading.Channels.ChannelReader`1<T> Reader; // 0x10
        public System.Threading.Channels.ChannelWriter`1<T> Writer; // 0x18

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7FFAC2F3C380
        public void set_Reader(){} // RVA: 0x7FFAC2F22E30
        public void get_Writer(){} // RVA: 0x7FFAC2F247C0
        public void set_Writer(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DebugEnumeratorDebugView`1 : Object
    {
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        public System.Threading.Channels.TaskCompletionSource SyncObj;
        public System.Collections.Concurrent.SingleProducerSingleConsumerQueue`1<T> _items;
        public bool _runContinuationsAsynchronously;
        public System.Exception _doneWriting;
        public System.Threading.Channels.AsyncOperation`1<T> _blockedReader;
        public System.Threading.Channels.AsyncOperation`1<bool> _waitingReader;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C71060
        public void get_SyncObj(){} // RVA: 0x7FFAC2C58E90
    }

    public class TaskCompletionSource : TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC907F220
        public void TrySetResult(){} // RVA: 0x7FFAC907F280
    }

    public class UnboundedChannelOptions : ChannelOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnboundedChannel`1 : Channel`1
    {
        public System.Threading.Channels.TaskCompletionSource SyncObj;
        public System.Collections.Concurrent.ConcurrentQueue`1<T> _items;
        public System.Collections.Generic.Deque`1<System.Threading.Channels.AsyncOperation`1<T>> _blockedReaders;
        public bool _runContinuationsAsynchronously;
        public System.Threading.Channels.AsyncOperation`1<bool> _waitingReadersTail;
        public System.Exception _doneWriting;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C71060
        public void get_SyncObj(){} // RVA: 0x7FFAC2C58E90
    }

    public class VoidAsyncOperationWithData`1 : AsyncOperation`1
    {
        public T Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
    }

}