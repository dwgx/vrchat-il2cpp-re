// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Channels
// Classes: 16
// Methods: 77

namespace ThirdParty.DotNet.System.Threading.Channels
{
    public class AsyncOperation : Object
    {
        public ileFullDirectoryInformation<object> s_availableSentinel;
        public ileFullDirectoryInformation<object> s_completedSentinel; // 0x8

        // ── Methods ──
        public void AvailableSentinel(){} // RVA: 0x7FFD4E341310
        public void CompletedSentinel(){} // RVA: 0x7FFD4E341310
        public void ThrowIncompleteOperationException(){} // RVA: 0x7FFD5449E150
        public void ThrowMultipleContinuations(){} // RVA: 0x7FFD5449E1C0
        public void ThrowIncorrectCurrentIdException(){} // RVA: 0x7FFD5449E230
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD5449E2A0
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        public sageKind.sition Next; // 0x10
        public bool CancellationToken; // 0x28
        public bool ValueTask; // 0x29
        public int ValueTaskOfT; // 0x2C
        public bool IsCompleted; // 0x30
        public .Messaging.IInternalMessage.TargetIdentity.eDictionary _error; // 0x38
        public ileFullDirectoryInformation<object> _continuation; // 0x40
        public object _continuationState; // 0x48
        public object _schedulingContext; // 0x50
        public sageKind.d _executionContext; // 0x58
        public short _currentId; // 0x60
        public bstacleAvoidance.al<bool> <Next>k__BackingField; // 0x68
        public sageKind.TICMAP_SIZE <CancellationToken>k__BackingField; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_Next(){} // RVA: 0x7FFD4E078E90
        public void set_Next(){} // RVA: 0x7FFD4E090A40
        public void get_CancellationToken(){} // RVA: 0x7FFD4E2ADC40
        public void get_ValueTask(){}
        public void get_ValueTaskOfT(){} // RVA: 0x7FFD4E2ADC40
        public void GetStatus(){}
        public void get_IsCompleted(){} // RVA: 0x7FFD4E079D00
        public void GetResult(){} // RVA: 0x7FFD4E2ADC40
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
        public void TryOwnAndReset(){} // RVA: 0x7FFD4E079D00
        public void OnCompleted(){}
        public void UnregisterCancellation(){} // RVA: 0x7FFD4E079D00
        public void TrySetResult(){} // RVA: 0x7FFD4E2ADC40
        public void TrySetException(){} // RVA: 0x7FFD4E079F60
        public void TrySetCanceled(){} // RVA: 0x7FFD4E2ADC40
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x7FFD4E079D00
        public void SignalCompletion(){} // RVA: 0x7FFD4E090980
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x7FFD4E090980
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x7FFD4E090980
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7FFD4E090C80
        public void QueueUserWorkItem(){} // RVA: 0x7FFD4E090C80
        public void UnsafeRegister(){} // RVA: 0x7FFD4E2ADC40
    }

    public class BoundedChannelOptions : ChannelOptions
    {
        public int Capacity; // 0x18
        public bstacleAvoidance.entTypeID FullMode; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5449E5A0
        public void get_Capacity(){} // RVA: 0x7FFD4E577800
        public void get_FullMode(){} // RVA: 0x7FFD4F8557F0
        public void set_FullMode(){} // RVA: 0x7FFD5449E610
    }

    public class BoundedChannel`1 : Channel`1
    {
        public bstacleAvoidance.entTypeID SyncObj;
        public ileFullDirectoryInformation<T1717742016> _itemDropped;
        public bstacleAvoidance.? _completion;
        public int _bufferedCapacity;
        public URA.path<T1717742016> _items;
        public URA.path<bstacleAvoidance.al<T1717742016>> _blockedReaders;
        public URA.path<bstacleAvoidance.ernal_Injected<T1717742016>> _blockedWriters;
        public bstacleAvoidance.al<bool> _waitingReadersTail;
        public bstacleAvoidance.al<bool> _waitingWritersTail;
        public bool _runContinuationsAsynchronously;
        public ÏÏÍÍÎÎ _doneWriting;

        // ── Methods ──
        public void get_SyncObj(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Channel : Object
    {
        // ── Methods ──
        public void CreateUnbounded(){} // RVA: 0x7FFD4E078F80
        public void CreateBounded(){} // RVA: 0x7FFD4E078FF0 | overloaded x2
    }

    public class ChannelOptions : Object
    {
        public bool SingleWriter; // 0x10
        public bool SingleReader; // 0x11
        public bool AllowSynchronousContinuations; // 0x12

        // ── Methods ──
        public void set_SingleWriter(){} // RVA: 0x7FFD4E40B5F0
        public void get_SingleReader(){} // RVA: 0x7FFD4EB91DA0
        public void set_SingleReader(){} // RVA: 0x7FFD4EB91D90
        public void get_AllowSynchronousContinuations(){} // RVA: 0x7FFD4EF01A90
        public void set_AllowSynchronousContinuations(){} // RVA: 0x7FFD4F831DE0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x7FFD4E079F60
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ChannelUtilities : Object
    {
        public ÏÏÍÍÎÎ s_doneWritingSentinel;
        public utes.?<bool> s_trueTask; // 0x8
        public utes.?<bool> s_falseTask; // 0x10
        public utes.Line s_neverCompletingTask; // 0x18

        // ── Methods ──
        public void Complete(){} // RVA: 0x7FFD5449E680
        public void QueueWaiter(){} // RVA: 0x7FFD5449E850
        public void WakeUpWaiters(){} // RVA: 0x7FFD5449EA10
        public void FailOperations(){} // RVA: 0x7FFD4E090C80
        public void CreateInvalidCompletionException(){} // RVA: 0x7FFD5449ECA0
        public void .cctor(){} // RVA: 0x7FFD5449EED0
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x7FFD4E079F60
        public void TryWrite(){} // RVA: 0x7FFD4E2ADC40
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x7FFD4E2ADC40
        public void WriteAsyncCore(){} // RVA: 0x7FFD4E2ADC40
        public void Complete(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD50C27970
    }

    public class Channel`2 : Object
    {
        public bstacleAvoidance.ateFSharpSetConstructor<ÎÏÍÍÍÌÎÍÏÌÎÎÌÌÏÎÏÍÏ> Reader; // 0x10
        public bstacleAvoidance.harpCompilationMappingAttribute<ÎÏÍÍÍÌÎÍÏÌÎÎÌÌÏÎÏÍÏ> Writer; // 0x18

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7FFD4E35C380
        public void set_Reader(){} // RVA: 0x7FFD4E342E30
        public void get_Writer(){} // RVA: 0x7FFD4E3447C0
        public void set_Writer(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        public bstacleAvoidance.? SyncObj; // 0x20
        public JapaneseLangName.tale<ÎÏÍÍÍÌÎÍÏÌÎÎÌÌÏÎÏÍÏ> _items; // 0x28
        public bool _runContinuationsAsynchronously; // 0x30
        public ÏÏÍÍÎÎ _doneWriting; // 0x38
        public bstacleAvoidance.al<ÎÏÍÍÍÌÎÍÏÌÎÎÌÌÏÎÏÍÏ> _blockedReader; // 0x40
        public bstacleAvoidance.al<bool> _waitingReader; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E091060
        public void get_SyncObj(){} // RVA: 0x7FFD4E078E90
    }

    public class TaskCompletionSource : TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5449F220
        public void TrySetResult(){} // RVA: 0x7FFD5449F280
    }

    public class UnboundedChannelOptions : ChannelOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UnboundedChannel`1 : Channel`1
    {
        public bstacleAvoidance.? SyncObj; // 0x20
        public JapaneseLangName.me<ÎÏÍÍÍÌÎÍÏÌÎÎÌÌÏÎÏÍÏ> _items; // 0x28
        public URA.path<bstacleAvoidance.al<ÎÏÍÍÍÌÎÍÏÌÎÎÌÌÏÎÏÍÏ>> _blockedReaders; // 0x30
        public bool _runContinuationsAsynchronously; // 0x38
        public bstacleAvoidance.al<bool> _waitingReadersTail; // 0x40
        public ÏÏÍÍÎÎ _doneWriting; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E091060
        public void get_SyncObj(){} // RVA: 0x7FFD4E078E90
    }

    public class VoidAsyncOperationWithData`1 : AsyncOperation`1
    {
        public T1717741968 Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
    }

}