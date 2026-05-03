// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Channels
// Classes: 18
// Methods: 80

namespace ThirdParty.DotNet.System.Threading.Channels
{
    public class AsyncOperation : Object
    {
        // ── Methods ──
        public void AvailableSentinel(){} // RVA: 0x7FFE810FB310
        public void CompletedSentinel(){} // RVA: 0x7FFE810FB310
        public void ThrowIncompleteOperationException(){} // RVA: 0x7FFE87426900
        public void ThrowMultipleContinuations(){} // RVA: 0x7FFE87426970
        public void ThrowIncorrectCurrentIdException(){} // RVA: 0x7FFE874269E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87426A50
    }

    public class AsyncOperation`1 : AsyncOperation
    {
        public System.Threading.CancellationTokenRegistration _registration;
        public bool _pooled;
        public bool _runContinuationsAsynchronously;
        public int _completionReserved;
        public T _result;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_Next(){} // RVA: 0x7FFE80E2E2E0
        public void set_Next(){} // RVA: 0x7FFE80E460A0
        public void get_CancellationToken(){} // RVA: 0x7FFE810A1420
        public void get_ValueTask(){}
        public void get_ValueTaskOfT(){} // RVA: 0x7FFE810A1420
        public void GetStatus(){}
        public void get_IsCompleted(){} // RVA: 0x7FFE80E2F150
        public void GetResult(){} // RVA: 0x7FFE810A1420
        public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
        public void TryOwnAndReset(){} // RVA: 0x7FFE80E2F150
        public void OnCompleted(){}
        public void UnregisterCancellation(){} // RVA: 0x7FFE80E2F150
        public void TrySetResult(){} // RVA: 0x7FFE810A1420
        public void TrySetException(){} // RVA: 0x7FFE80E2F3B0
        public void TrySetCanceled(){} // RVA: 0x7FFE810A1420
        public void TryReserveCompletionIfCancelable(){} // RVA: 0x7FFE80E2F150
        public void SignalCompletion(){} // RVA: 0x7FFE80E45FE0
        public void SetCompletionAndInvokeContinuation(){} // RVA: 0x7FFE80E45FE0
        public void UnsafeQueueSetCompletionAndInvokeContinuation(){} // RVA: 0x7FFE80E45FE0
        public void UnsafeQueueUserWorkItem(){} // RVA: 0x7FFE80E462E0
        public void QueueUserWorkItem(){} // RVA: 0x7FFE80E462E0
        public void UnsafeRegister(){} // RVA: 0x7FFE810A1420
    }

    public class BoundedChannelOptions : ChannelOptions
    {
        public int _capacity; // 0x18
        public 0x666C5F54 _mode; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87426D50
        public void get_Capacity(){} // RVA: 0x7FFE813DB630
        public void get_FullMode(){} // RVA: 0x7FFE82707EE0
        public void set_FullMode(){} // RVA: 0x7FFE87426DC0
    }

    public class BoundedChannel`1 : Channel`1
    {
        public 0x666C5F54 _mode;

        // ── Methods ──
        public void get_SyncObj(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810A1420
    }

    public class Channel : Object
    {
        // ── Methods ──
        public void CreateUnbounded(){} // RVA: 0x7FFE80E2E3D0
        public void CreateBounded(){} // RVA: 0x7FFE80E2E440 | overloaded x2
    }

    public class ChannelClosedException : InvalidOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class ChannelOptions : Object
    {
        public bool _singleWriter; // 0x10
        public bool _singleReader; // 0x11
        public bool _allowSynchronousContinuations; // 0x12

        // ── Methods ──
        public void set_SingleWriter(){} // RVA: 0x7FFE811C55F0
        public void get_SingleReader(){} // RVA: 0x7FFE81346E30
        public void set_SingleReader(){} // RVA: 0x7FFE813471A0
        public void get_AllowSynchronousContinuations(){} // RVA: 0x7FFE826E3520
        public void set_AllowSynchronousContinuations(){} // RVA: 0x7FFE826E34A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ChannelReader`1 : Object
    {
        // ── Methods ──
        public void TryRead(){} // RVA: 0x7FFE80E2F3B0
        public void WaitToReadAsync(){}
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ChannelUtilities : Object
    {
        // ── Methods ──
        public void Complete(){} // RVA: 0x7FFE87426E30
        public void QueueWaiter(){} // RVA: 0x7FFE87427000
        public void WakeUpWaiters(){} // RVA: 0x7FFE874271C0
        public void FailOperations(){} // RVA: 0x7FFE80E462E0
        public void CreateInvalidCompletionException(){} // RVA: 0x7FFE87427450
        public void .cctor(){} // RVA: 0x7FFE87427680
    }

    public class ChannelWriter`1 : Object
    {
        // ── Methods ──
        public void TryComplete(){} // RVA: 0x7FFE80E2F3B0
        public void TryWrite(){} // RVA: 0x7FFE810A1420
        public void WaitToWriteAsync(){}
        public void WriteAsync(){} // RVA: 0x7FFE810A1420
        public void WriteAsyncCore(){} // RVA: 0x7FFE810A1420
        public void Complete(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class Channel`1 : Channel`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83B23B00
    }

    public class Channel`2 : Object
    {
        public System.Threading.Channels.ChannelReader`1<T> _reader; // 0x10
        public System.Threading.Channels.ChannelWriter`1<T> _writer; // 0x18

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7FFE81116380
        public void set_Reader(){} // RVA: 0x7FFE810FCE30
        public void get_Writer(){} // RVA: 0x7FFE810FE7C0
        public void set_Writer(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DebugEnumeratorDebugView`1 : Object
    {
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        public System.Threading.Channels.TaskCompletionSource _completion;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E466C0
        public void get_SyncObj(){} // RVA: 0x7FFE80E2E2E0
    }

    public class TaskCompletionSource : TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE874279D0
        public void TrySetResult(){} // RVA: 0x7FFE87427A30
    }

    public class UnboundedChannelOptions : ChannelOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnboundedChannel`1 : Channel`1
    {
        public System.Threading.Channels.TaskCompletionSource _completion;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E466C0
        public void get_SyncObj(){} // RVA: 0x7FFE80E2E2E0
    }

    public class VoidAsyncOperationWithData`1 : AsyncOperation`1
    {
        public T _item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
    }

}