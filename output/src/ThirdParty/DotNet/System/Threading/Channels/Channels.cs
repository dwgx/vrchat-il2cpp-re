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
        public object Next;
        public object CancellationToken;
        public object ValueTask;
        public object ValueTaskOfT;
        public object IsCompleted;

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
        public object Capacity;
        public object FullMode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5449E5A0
        public void get_Capacity(){} // RVA: 0x7FFD4E577800
        public void get_FullMode(){} // RVA: 0x7FFD4F8557F0
        public void set_FullMode(){} // RVA: 0x7FFD5449E610
    }

    public class BoundedChannel`1 : Channel`1
    {
        public object SyncObj;

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
        public object SingleWriter;
        public object SingleReader;
        public object AllowSynchronousContinuations;

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
        public object Reader;
        public object Writer;

        // ── Methods ──
        public void get_Reader(){} // RVA: 0x7FFD4E35C380
        public void set_Reader(){} // RVA: 0x7FFD4E342E30
        public void get_Writer(){} // RVA: 0x7FFD4E3447C0
        public void set_Writer(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SingleConsumerUnboundedChannel`1 : Channel`1
    {
        public object SyncObj;

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
        public object SyncObj;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E091060
        public void get_SyncObj(){} // RVA: 0x7FFD4E078E90
    }

    public class VoidAsyncOperationWithData`1 : AsyncOperation`1
    {
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
    }

}