// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 446

public class _AcknowledgeQuit_Exiting : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _AcknowledgeQuit_UserPrompt : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _AcquireOverlayView : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8978560
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97EF9E0
    public void EndInvoke(){} // RVA: 0x7FFAC4B4EB70
}

public class _AcquireReadOnlyBlock : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8978560
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97F5BE0
    public void EndInvoke(){} // RVA: 0x7FFAC4B4EB70
}

public class _AcquireVideoStreamingService : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CBA250
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97E8360
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _AcquireWriteOnlyBlock : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8977AB0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97F58A0
    public void EndInvoke(){} // RVA: 0x7FFAC4B4EB70
}

public class _AddApplicationManifest : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97E8A60
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97E8B30
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _AppendPrepend : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public T element;
    public System.Threading.CancellationToken cancellationToken;
    public 0x6B18A7D0<T> state;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void MoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _ApplyTransform : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC896FA30
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97E69F0
    public void EndInvoke(){} // RVA: 0x7FFAC6E60970
}

public class _AreBoundsVisible : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CAAD40
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class _BeginVrProfilerEvent : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4A15E60
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97F4DA0
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _Buffer : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public int count;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public bool continueNext;
    public bool completed;
    public System.Collections.Generic.List`1<T> buffer;
    public System.Collections.Generic.IList`1<T> <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2C58E90
    public void set_Current(){} // RVA: 0x7FFAC2C70A40
    public void MoveNextAsync(){}
    public void SourceMoveNext(){} // RVA: 0x7FFAC2C70980
    public void MoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _BufferSkip : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public int count;
    public int skip;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public bool continueNext;
    public bool completed;
    public System.Collections.Generic.Queue`1<System.Collections.Generic.List`1<T>> buffers;
    public int index;
    public System.Collections.Generic.IList`1<T> <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2C58E90
    public void set_Current(){} // RVA: 0x7FFAC2C70A40
    public void MoveNextAsync(){}
    public void SourceMoveNext(){} // RVA: 0x7FFAC2C70980
    public void MoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _CanRenderScene : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CAAD40
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class _CancelApplicationLaunch : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB7AA0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97E9080
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class _Cast : AsyncEnumeratorBase`2
{
    // ── Methods ──
    public void .ctor(){}
    public void TryMoveNextCore(){}
}

public class _ClearLastSubmittedFrame : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _ClearOverlayCursorPositionOverride : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EE820
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _ClearOverlayTexture : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EE950
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _ClearSkyboxOverride : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _ClearStageOverride : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _Close : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97F46D0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _CloseMessageOverlay : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _CombineLatest : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.Action`1<object> Completed2Delegate;
    public System.Action`1<object> Completed3Delegate;
    public System.Action`1<object> Completed4Delegate;
    public System.Action`1<object> Completed5Delegate;
    public System.Action`1<object> Completed6Delegate;
    public System.Action`1<object> Completed7Delegate;
    public System.Action`1<object> Completed8Delegate;
    public System.Action`1<object> Completed9Delegate;
    public System.Action`1<object> Completed10Delegate;
    public System.Action`1<object> Completed11Delegate;
    public System.Action`1<object> Completed12Delegate;
    public int CompleteCount;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source1;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source3;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source4;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source5;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source6;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source7;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source8;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source9;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source10;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source11;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source12;
    public System.Func`13<T,T,T,T,T,T,T,T,T,T,T,T,T> resultSelector;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator1;
    public Awaiter<bool> awaiter1;
    public bool hasCurrent1;
    public bool running1;
    public T current1;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator2;
    public Awaiter<bool> awaiter2;
    public bool hasCurrent2;
    public bool running2;
    public T current2;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator3;
    public Awaiter<bool> awaiter3;
    public bool hasCurrent3;
    public bool running3;
    public T current3;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator4;
    public Awaiter<bool> awaiter4;
    public bool hasCurrent4;
    public bool running4;
    public T current4;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator5;
    public Awaiter<bool> awaiter5;
    public bool hasCurrent5;
    public bool running5;
    public T current5;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator6;
    public Awaiter<bool> awaiter6;
    public bool hasCurrent6;
    public bool running6;
    public T current6;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator7;
    public Awaiter<bool> awaiter7;
    public bool hasCurrent7;
    public bool running7;
    public T current7;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator8;
    public Awaiter<bool> awaiter8;
    public bool hasCurrent8;
    public bool running8;
    public T current8;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator9;
    public Awaiter<bool> awaiter9;
    public bool hasCurrent9;
    public bool running9;
    public T current9;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator10;
    public Awaiter<bool> awaiter10;
    public bool hasCurrent10;
    public bool running10;
    public T current10;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator11;
    public Awaiter<bool> awaiter11;
    public bool hasCurrent11;
    public bool running11;
    public T current11;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator12;
    public Awaiter<bool> awaiter12;
    public bool hasCurrent12;
    public bool running12;
    public T current12;
    public int completedCount;
    public bool syncRunning;
    public T result;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void Completed1(){} // RVA: 0x7FFAC2C70A10
    public void Completed2(){} // RVA: 0x7FFAC2C70A10
    public void Completed3(){} // RVA: 0x7FFAC2C70A10
    public void Completed4(){} // RVA: 0x7FFAC2C70A10
    public void Completed5(){} // RVA: 0x7FFAC2C70A10
    public void Completed6(){} // RVA: 0x7FFAC2C70A10
    public void Completed7(){} // RVA: 0x7FFAC2C70A10
    public void Completed8(){} // RVA: 0x7FFAC2C70A10
    public void Completed9(){} // RVA: 0x7FFAC2C70A10
    public void Completed10(){} // RVA: 0x7FFAC2C70A10
    public void Completed11(){} // RVA: 0x7FFAC2C70A10
    public void Completed12(){} // RVA: 0x7FFAC2C70A10
    public void TrySetResult(){} // RVA: 0x7FFAC2C59D00
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _CommitWorkingCopy : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB00E0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EA140
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class _CompositorBringToFront : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _CompositorDumpImages : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _CompositorGoToBack : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _CompositorQuit : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _ComputeDistortion : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC896EFF0
    public void Invoke(){} // RVA: 0x7FFAC61931F0
    public void BeginInvoke(){} // RVA: 0x7FFAC97E63C0
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class _ComputeOverlayIntersection : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8979030
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97EE3C0
    public void EndInvoke(){} // RVA: 0x7FFAC896F450
}

public class _Concat : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> first;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> second;
    public System.Threading.CancellationToken cancellationToken;
    public 0x6B18C820<T> iteratingState;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void StartIterate(){} // RVA: 0x7FFAC2C70980
    public void MoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void RunSecondAfterDisposeAsync(){} // RVA: 0x7FFAC2C59D00
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _Connect : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4B4E9E0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F5770
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _Create : MoveNextSource
{
    public System.Func`3<Cysharp.Threading.Tasks.Linq.IAsyncWriter`1<T>,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask> Current;
    public System.Threading.CancellationToken cancellationToken;
    public int state;
    public AsyncWriter<T> writer;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void MoveNextAsync(){}
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void RunWriterTask(){} // RVA: 0x7FFAC2E8DC40
    public void SetResult(){} // RVA: 0x7FFAC2E8DC40
}

public class _CreateDashboardOverlay : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8977120
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97EEE90
    public void EndInvoke(){} // RVA: 0x7FFAC4B4EB70
}

public class _CreateNotification : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC897BAD0
    public void Invoke(){} // RVA: 0x7FFAC5CC1AD0
    public void BeginInvoke(){} // RVA: 0x7FFAC97F0F00
    public void EndInvoke(){} // RVA: 0x7FFAC4B4EB70
}

public class _CreateOverlay : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8977AB0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97EBFA0
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _CreateSpatialAnchorFromDescriptor : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F4A10
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _CreateSpatialAnchorFromPose : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8971E20
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97F4AC0
    public void EndInvoke(){} // RVA: 0x7FFAC4B4EB70
}

public class _DecompressSkeletalBoneData : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97F3390
    public void Invoke(){} // RVA: 0x7FFAC5C60E20
    public void BeginInvoke(){} // RVA: 0x7FFAC97F38F0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _DefaultIfEmpty : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public T defaultValue;
    public System.Threading.CancellationToken cancellationToken;
    public 0x6B18CDA0<T> iteratingState;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void MoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _Destroy : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97F5820
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _DestroyOverlay : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EC060
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _Distinct : AsyncEnumeratorBase`2
{
    public System.Collections.Generic.HashSet`1<T> set;

    // ── Methods ──
    public void .ctor(){}
    public void TryMoveNextCore(){}
}

public class _DistinctAwait : AsyncEnumeratorAwaitSelectorBase`3
{
    public System.Collections.Generic.HashSet`1<T> set;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;

    // ── Methods ──
    public void .ctor(){}
    public void TransformAsync(){} // RVA: 0x7FFAC2E8DC40
    public void TrySetCurrentCore(){} // RVA: 0x7FFAC2E8DC40
}

public class _DistinctAwaitWithCancellation : AsyncEnumeratorAwaitSelectorBase`3
{
    public System.Collections.Generic.HashSet`1<T> set;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;

    // ── Methods ──
    public void .ctor(){}
    public void TransformAsync(){} // RVA: 0x7FFAC2E8DC40
    public void TrySetCurrentCore(){} // RVA: 0x7FFAC2E8DC40
}

public class _DistinctUntilChanged : MoveNextSource
{
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> Current;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public System.Threading.CancellationToken cancellationToken;
    public int state;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
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

public class _DistinctUntilChangedAwait : MoveNextSource
{
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> Current;
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public System.Threading.CancellationToken cancellationToken;
    public int state;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public Awaiter<T> awaiter2;
    public System.Action moveNextAction;
    public T enumeratorCurrent;
    public T prev;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
}

public class _DistinctUntilChangedAwaitWithCancellation : MoveNextSource
{
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> Current;
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> keySelector;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public System.Threading.CancellationToken cancellationToken;
    public int state;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public Awaiter<T> awaiter2;
    public System.Action moveNextAction;
    public T enumeratorCurrent;
    public T prev;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void MoveNext(){} // RVA: 0x7FFAC2C70980
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
}

public class _Do : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Action`1<T> onNext;
    public System.Action`1<System.Exception> onError;
    public System.Action onCompleted;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void CallTrySetExceptionAfterNotification(){} // RVA: 0x7FFAC2C70A40
    public void TryGetResultWithNotification(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextCore(){} // RVA: 0x7FFAC2C70A10
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _DriverDebugRequest : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8971580
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97F4EE0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _EmitVrProfilerEvent : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97F4D20
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _Empty : Object
{
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _EveryUpdate : MoveNextSource
{
    public 0x6B1DD918 Current; // 0x38
    public System.Threading.CancellationToken cancellationToken; // 0x40
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x48
    public bool disposed; // 0x60

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC94C3340
    public void get_Current(){} // RVA: 0x7FFAC2F21320
    public void MoveNextAsync(){} // RVA: 0x7FFAC94C35E0
    public void DisposeAsync(){} // RVA: 0x7FFAC94C3780
    public void MoveNext(){} // RVA: 0x7FFAC94C37E0
}

public class _EveryValueChanged : MoveNextSource
{
    public System.WeakReference`1<U> Current;
    public System.Collections.Generic.IEqualityComparer`1<U> equalityComparer;
    public System.Func`2<U,U> propertySelector;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration;
    public bool first;
    public U currentValue;
    public bool disposed;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
}

public class _Except : AsyncEnumeratorBase`2
{
    public System.Action`1<object> HashSetAsyncCoreDelegate;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> second;
    public System.Collections.Generic.HashSet`1<T> set;
    public Awaiter<System.Collections.Generic.HashSet`1<T>> awaiter;

    // ── Methods ──
    public void .ctor(){}
    public void OnFirstIteration(){} // RVA: 0x7FFAC2C59D00
    public void HashSetAsyncCore(){} // RVA: 0x7FFAC2C70A10
    public void TryMoveNextCore(){}
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class _ExportLiveToBuffer : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6CEBC10
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EA920
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class _FadeGrid : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8975A10
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EB450
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _FadeToColor : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89756C0
    public void Invoke(){} // RVA: 0x7FFAC8975790
    public void BeginInvoke(){} // RVA: 0x7FFAC97EB2C0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _FindOverlay : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97EBEF0
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _FinishVrProfilerEvent : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F4E30
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _ForceBoundsVisible : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC40BEC20
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EA040
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _ForceInterleavedReprojectionOn : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC40BEC20
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97EB590
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _ForceReconnectProcess : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _FreeRenderModel : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DFD0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97F00B0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _FreeTexture : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DFD0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97F01E0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _FreeTextureD3D11 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DFD0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97F03C0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _Get32Bit : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CBC4C0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9D70D70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _Get8Bit : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CBC4C0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9D70CE0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class _GetActionBindingInfo : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97F3D70
    public void Invoke(){} // RVA: 0x7FFAC5C60E20
    public void BeginInvoke(){} // RVA: 0x7FFAC97F3E40
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _GetActionHandle : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F2930
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _GetActionOrigins : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8978560
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97F3AF0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _GetActionSetHandle : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F2880
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _GetAnalogActionData : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976590
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97F2C20
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _GetAppContainerFilePaths : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8973C10
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97E7A50
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _GetApplicationAutoLaunch : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB7AA0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97E97A0
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class _GetApplicationCount : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC556C080
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _GetApplicationKeyByIndex : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8972DD0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97E8CE0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _GetApplicationKeyByProcessId : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8972DD0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97E8D80
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _GetApplicationLaunchArguments : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8972DD0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97E9AC0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _GetApplicationProcessId : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97E91A0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _GetApplicationPropertyBool : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97E9480
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97E9550
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class _GetApplicationPropertyString : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97E92A0
    public void Invoke(){} // RVA: 0x7FFAC5C60E20
    public void BeginInvoke(){} // RVA: 0x7FFAC97E9370
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _GetApplicationPropertyUint64 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2F1E0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97E9620
    public void EndInvoke(){} // RVA: 0x7FFAC6EA1C40
}

public class _GetApplicationSupportedMimeTypes : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8978BD0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97E9960
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class _GetApplicationsErrorNameFromEnum : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB01B0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97E9220
    public void EndInvoke(){} // RVA: 0x7FFAC4B58720
}

public class _GetApplicationsThatSupportMimeType : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976160
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97E9A10
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _GetApplicationsTransitionStateNameFromEnum : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB01B0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC8973D80
    public void EndInvoke(){} // RVA: 0x7FFAC4B58720
}

public class _GetArrayTrackedDeviceProperty : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89706D0
    public void Invoke(){} // RVA: 0x7FFAC5CC1930
    public void BeginInvoke(){} // RVA: 0x7FFAC97E70D0
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _GetBindingVariant : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976160
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97F4440
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _GetBoneCount : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC97F3150
    public void EndInvoke(){} // RVA: 0x7FFAC4A15FD0
}

public class _GetBoneHierarchy : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976160
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97F3200
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _GetBoneName : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97F0560
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC97F32B0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _GetBool : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8979030
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97F1850
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class _GetBoolTrackedDeviceProperty : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC896FDE0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC97E6CC0
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class _GetBoundsColor : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89740A0
    public void Invoke(){} // RVA: 0x7FFAC6193050
    public void BeginInvoke(){} // RVA: 0x7FFAC97E9F50
    public void EndInvoke(){} // RVA: 0x7FFAC3B16FD0
}

public class _GetButtonIdNameFromEnum : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB01B0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97E78D0
    public void EndInvoke(){} // RVA: 0x7FFAC4B58720
}

public class _GetCalibrationState : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC556C080
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class _GetCameraErrorNameFromEnum : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB01B0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC97E7D70
    public void EndInvoke(){} // RVA: 0x7FFAC4B58720
}

public class _GetCameraFrameSize : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8971C20
    public void Invoke(){} // RVA: 0x7FFAC5C60E20
    public void BeginInvoke(){} // RVA: 0x7FFAC97E7EA0
    public void EndInvoke(){} // RVA: 0x7FFAC8971DE0
}
