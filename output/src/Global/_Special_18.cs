// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 455

public class _LoadTexture_Async : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CBA250
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F0130
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _LockGLSharedTextureForAccess : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DFD0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EB940
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _Merge : MoveNextSource
{
    public System.Action`1<object> Current;
    public int length;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T>[] enumerators;
    public 0x6B18FB00<T>[] states;
    public System.Collections.Generic.Queue`1<System.ValueTuple`3<T,System.Exception,bool>> queuedResult;
    public System.Threading.CancellationToken cancellationToken;
    public int moveNextCompleted;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){}
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void GetResultAt(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    public void HasQueuedResult(){} // RVA: 0x7FFAC2C59D00
    public void IsCompletedAll(){} // RVA: 0x7FFAC2C59D00
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _MoveGamepadFocusToNeighbor : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CBA250
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC8979380
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _Never : Object
{
    public System.Threading.CancellationToken Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70BF0
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void <MoveNextAsync>b__4_0(){} // RVA: 0x7FFAC2C70A40
}

public class _OfType : AsyncEnumeratorBase`2
{
    // ── Methods ──
    public void .ctor(){}
    public void TryMoveNextCore(){}
}

public class _Open : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97F44F0
    public void Invoke(){} // RVA: 0x7FFAC5C60E20
    public void BeginInvoke(){} // RVA: 0x7FFAC97F45C0
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _OpenBindingUI : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97F4280
    public void Invoke(){} // RVA: 0x7FFAC44ECD30
    public void BeginInvoke(){} // RVA: 0x7FFAC97F4350
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _OrderedAsyncEnumerator : MoveNextSource
{
    public Cysharp.Threading.Tasks.Linq.OrderedAsyncEnumerable`1<T> Current;
    public System.Threading.CancellationToken cancellationToken;
    public T[] buffer;
    public int[] map;
    public int index;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void CreateSortSource(){} // RVA: 0x7FFAC2C59D00
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
}

public class _Pairwise : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public T prev;
    public bool isFirst;
    public System.ValueTuple`2<T,T> <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void SourceMoveNext(){} // RVA: 0x7FFAC2C70980
    public void MoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _PerformApplicationPrelaunchCheck : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97E9BF0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _PerformFirmwareUpdate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB0280
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97E79D0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _PollNextEvent : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC72C5360
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97E7370
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class _PollNextEventPacked : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC72C5360
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F71E0
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class _PollNextEventWithPose : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8970BC0
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97E7420
    public void EndInvoke(){} // RVA: 0x7FFAC896F450
}

public class _PollNextOverlayEvent : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8978BD0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97EE030
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class _PollNextOverlayEventPacked : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8978BD0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97FB0E0
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class _PostOverlayEvent : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC49781F0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EFB70
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class _PostPresentHandoff : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _PropertyContainer : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB0690
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97F4910
    public void EndInvoke(){} // RVA: 0x7FFAC4B58720
}

public class _Publish : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.Linq.Publish`1<T> Cysharp.Threading.Tasks.ITriggerHandler<TSource>.Prev;
    public System.Threading.CancellationToken Cysharp.Threading.Tasks.ITriggerHandler<TSource>.Next;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration;
    public bool isDisposed;
    public T <Current>k__BackingField;
    public Cysharp.Threading.Tasks.ITriggerHandler`1<T> <Cysharp.Threading.Tasks.ITriggerHandler<TSource>.Prev>k__BackingField;
    public Cysharp.Threading.Tasks.ITriggerHandler`1<T> <Cysharp.Threading.Tasks.ITriggerHandler<TSource>.Next>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.ITriggerHandler<TSource>.get_Prev(){} // RVA: 0x7FFAC2C58E90
    public void Cysharp.Threading.Tasks.ITriggerHandler<TSource>.set_Prev(){} // RVA: 0x7FFAC2C70A40
    public void Cysharp.Threading.Tasks.ITriggerHandler<TSource>.get_Next(){} // RVA: 0x7FFAC2C58E90
    public void Cysharp.Threading.Tasks.ITriggerHandler<TSource>.set_Next(){} // RVA: 0x7FFAC2C70A40
    public void MoveNextAsync(){}
    public void OnCanceled(){} // RVA: 0x7FFAC2C70BF0 | overloaded x2
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void OnNext(){} // RVA: 0x7FFAC2E8DC40
    public void OnCompleted(){} // RVA: 0x7FFAC2C70980
    public void OnError(){} // RVA: 0x7FFAC2C70A40
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _Put32Bit : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5C4D540
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _Put8Bit : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5C4D540
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _Queue : Object
{
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> Current;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.Channel`1<T> channel;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> channelEnumerator;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> sourceEnumerator;
    public bool channelClosed;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void ConsumeAll(){} // RVA: 0x7FFAC2E8DC40
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
}

public class _QueueHasReader : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F5D60
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _Range : Object
{
    public int Current; // 0x10
    public int end; // 0x14
    public int current; // 0x18
    public System.Threading.CancellationToken cancellationToken; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC94BC180
    public void get_Current(){} // RVA: 0x7FFAC3157800
    public void MoveNextAsync(){} // RVA: 0x7FFAC94BC200
    public void DisposeAsync(){} // RVA: 0x7FFAC3FB3780
}

public class _Read : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976590
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97F4750
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _ReadPathBatch : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976160
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97F5250
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _ReadPropertyBatch : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976160
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97F4FB0
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _ReleaseMirrorTextureD3D11 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DFD0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EB750
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _ReleaseNativeOverlayHandle : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EED20
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _ReleaseOverlayView : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4A15E60
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EFAE0
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _ReleaseReadOnlyBlock : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F5CD0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _ReleaseSharedGLTexture : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CBA180
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EB8A0
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class _ReleaseVideoStreamTextureGL : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8972A00
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97E8930
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _ReleaseVideoStreamingService : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97E8410
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _ReleaseWriteOnlyBlock : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F5960
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _ReloadFromDisk : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3012370
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EA810
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _ReloadInfo : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _RemoveApplicationManifest : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97E8BE0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _RemoveKeyInSection : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97F1DE0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97F1EB0
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class _RemoveNotification : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB0280
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97F1070
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _RemoveSection : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC49781F0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F1D30
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class _RenderModelHasComponent : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97F0B60
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F0C30
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class _Repeat : Object
{
    public T Current;
    public int count;
    public int remaining;
    public System.Threading.CancellationToken cancellationToken;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
}

public class _RequestScreenshot : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC897CC60
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97F1F70
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _ResetSeatedZeroPose : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _ResetZeroPose : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3012370
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EA0C0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _Return : Object
{
    public T Current;
    public System.Threading.CancellationToken cancellationToken;
    public bool called;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
}

public class _Reverse : MoveNextSource
{
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> Current;
    public System.Threading.CancellationToken cancellationToken;
    public T[] array;
    public int index;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
}

public class _RevertWorkingCopy : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _RoomSetupStarting : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _Select : MoveNextSource
{
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> Current;
    public System.Func`3<T,int,T> selector;
    public System.Threading.CancellationToken cancellationToken;
    public int state;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public System.Action moveNextAction;
    public int index;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
}

public class _SelectAwait : MoveNextSource
{
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> Current;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<T>> selector;
    public System.Threading.CancellationToken cancellationToken;
    public int state;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public Awaiter<T> awaiter2;
    public System.Action moveNextAction;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
}

public class _SelectAwaitWithCancellation : MoveNextSource
{
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> Current;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> selector;
    public System.Threading.CancellationToken cancellationToken;
    public int state;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public Awaiter<T> awaiter2;
    public System.Action moveNextAction;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
}

public class _SelectMany : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.Action`1<object> selectedSourceMoveNextCoreDelegate;
    public System.Action`1<object> selectedEnumeratorDisposeAsyncCoreDelegate;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Func`2<T,Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T>> selector1;
    public System.Func`3<T,int,Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T>> selector2;
    public System.Func`3<T,T,T> resultSelector;
    public System.Threading.CancellationToken cancellationToken;
    public T sourceCurrent;
    public int sourceIndex;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> sourceEnumerator;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> selectedEnumerator;
    public Awaiter<bool> sourceAwaiter;
    public Awaiter<bool> selectedAwaiter;
    public Awaiter selectedDisposeAsyncAwaiter;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void MoveNextSource(){} // RVA: 0x7FFAC2C70980
    public void MoveNextSelected(){} // RVA: 0x7FFAC2C70980
    public void SourceMoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void SeletedSourceMoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void SelectedEnumeratorDisposeAsyncCore(){} // RVA: 0x7FFAC2C70A10
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _SelectManyAwait : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.Action`1<object> selectedSourceMoveNextCoreDelegate;
    public System.Action`1<object> selectedEnumeratorDisposeAsyncCoreDelegate;
    public System.Action`1<object> selectorAwaitCoreDelegate;
    public System.Action`1<object> resultSelectorAwaitCoreDelegate;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T>>> selector1;
    public System.Func`3<T,int,Cysharp.Threading.Tasks.UniTask`1<Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T>>> selector2;
    public System.Func`3<T,T,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
    public System.Threading.CancellationToken cancellationToken;
    public T sourceCurrent;
    public int sourceIndex;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> sourceEnumerator;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> selectedEnumerator;
    public Awaiter<bool> sourceAwaiter;
    public Awaiter<bool> selectedAwaiter;
    public Awaiter selectedDisposeAsyncAwaiter;
    public Awaiter<Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T>> collectionSelectorAwaiter;
    public Awaiter<T> resultSelectorAwaiter;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void MoveNextSource(){} // RVA: 0x7FFAC2C70980
    public void MoveNextSelected(){} // RVA: 0x7FFAC2C70980
    public void SourceMoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void SeletedSourceMoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void SelectedEnumeratorDisposeAsyncCore(){} // RVA: 0x7FFAC2C70A10
    public void SelectorAwaitCore(){} // RVA: 0x7FFAC2C70A10
    public void ResultSelectorAwaitCore(){} // RVA: 0x7FFAC2C70A10
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _SelectManyAwaitWithCancellation : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.Action`1<object> selectedSourceMoveNextCoreDelegate;
    public System.Action`1<object> selectedEnumeratorDisposeAsyncCoreDelegate;
    public System.Action`1<object> selectorAwaitCoreDelegate;
    public System.Action`1<object> resultSelectorAwaitCoreDelegate;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T>>> selector1;
    public System.Func`4<T,int,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T>>> selector2;
    public System.Func`4<T,T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
    public System.Threading.CancellationToken cancellationToken;
    public T sourceCurrent;
    public int sourceIndex;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> sourceEnumerator;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> selectedEnumerator;
    public Awaiter<bool> sourceAwaiter;
    public Awaiter<bool> selectedAwaiter;
    public Awaiter selectedDisposeAsyncAwaiter;
    public Awaiter<Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T>> collectionSelectorAwaiter;
    public Awaiter<T> resultSelectorAwaiter;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void MoveNextSource(){} // RVA: 0x7FFAC2C70980
    public void MoveNextSelected(){} // RVA: 0x7FFAC2C70980
    public void SourceMoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void SeletedSourceMoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void SelectedEnumeratorDisposeAsyncCore(){} // RVA: 0x7FFAC2C70A10
    public void SelectorAwaitCore(){} // RVA: 0x7FFAC2C70A10
    public void ResultSelectorAwaitCore(){} // RVA: 0x7FFAC2C70A10
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _SetActionManifestPath : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97F2800
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetApplicationAutoLaunch : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97E8A60
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97E96F0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetBool : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97F1170
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97F1240
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class _SetCameraTrackingSpace : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3012370
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97E89E0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _SetDashboardOverlaySceneProcess : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8972A00
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EEFF0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetDefaultApplicationForMimeType : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97E9820
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetDisplayVisibility : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CAF6A0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97E6740
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class _SetDominantHand : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB0280
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97F30D0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetExplicitTimingMode : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3012370
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EBB80
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _SetFloat : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97F14F0
    public void Invoke(){} // RVA: 0x7FFAC6193050
    public void BeginInvoke(){} // RVA: 0x7FFAC97F15C0
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class _SetGamepadFocusOverlay : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC8979250
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetHeadsetViewBlendRange : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC60576C0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EFED0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _SetHeadsetViewCropped : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC40BEC20
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EFE50
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _SetHeadsetViewMode : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3012370
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EFDD0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _SetHeadsetViewSize : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6055BD0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EFCA0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _SetHighQualityOverlay : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC8976510
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetInt32 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97F1330
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97F1400
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class _SetKeyboardPositionForOverlay : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC897A8C0
    public void Invoke(){} // RVA: 0x7FFAC5C4DBE0
    public void BeginInvoke(){} // RVA: 0x7FFAC97EF760
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _SetKeyboardTransformAbsolute : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC307D2A0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EF6B0
    public void EndInvoke(){} // RVA: 0x7FFAC49FC700
}

public class _SetOverlayAlpha : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89772D0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97ECA10
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayAutoCurveDistanceRangeInMeters : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8977920
    public void Invoke(){} // RVA: 0x7FFAC5CBFAA0
    public void BeginInvoke(){} // RVA: 0x7FFAC89779F0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayColor : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976F70
    public void Invoke(){} // RVA: 0x7FFAC61931F0
    public void BeginInvoke(){} // RVA: 0x7FFAC97EC850
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayCursor : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EE6E0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayCursorPositionOverride : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EE770
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _SetOverlayCurvature : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89772D0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97ECF90
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayDualAnalogTransform : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8979420
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC89794F0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayFlag : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976C30
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97EC600
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayFromFile : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EEAD0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayInputMethod : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8972A00
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EE1B0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayIntersectionMask : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC897AA40
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97EE510
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _SetOverlayMouseScale : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EE310
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _SetOverlayName : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EC2A0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayNeighbor : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8975140
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC89792D0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayPreCurvePitch : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89772D0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97ED0F0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayRaw : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89798F0
    public void Invoke(){} // RVA: 0x7FFAC5C60E20
    public void BeginInvoke(){} // RVA: 0x7FFAC97EE9D0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayRenderModel : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8977AB0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC8978010
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _SetOverlayRenderingPid : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8972A00
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EC4D0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlaySortOrder : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8972A00
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97ECCD0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayTexelAspect : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89772D0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97ECB70
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _SetOverlayTexture : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EE8A0
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _SetOverlayTextureBounds : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97ED3B0
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _SetOverlayTextureColorSpace : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8972A00
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97ED250
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}
