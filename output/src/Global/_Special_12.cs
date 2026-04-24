// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 307

public class _ShouldAppRenderWithLowResources : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510CAD40
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
    public void BeginInvoke(){} // RVA: 0x7FFD4E39FA60
    public void EndInvoke(){} // RVA: 0x7FFD4EF03450
}

public class _ShouldApplicationPause : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510CAD40
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
    public void BeginInvoke(){} // RVA: 0x7FFD4E39FA60
    public void EndInvoke(){} // RVA: 0x7FFD4EF03450
}

public class _ShouldApplicationReduceRenderingWork : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510CAD40
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
    public void BeginInvoke(){} // RVA: 0x7FFD4E39FA60
    public void EndInvoke(){} // RVA: 0x7FFD4EF03450
}

public class _ShowActionOrigins : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5337FAB0
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD54C13F20
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _ShowBindingsForActionSet : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53D9E650
    public void Invoke(){} // RVA: 0x7FFD4EC5F780
    public void BeginInvoke(){} // RVA: 0x7FFD54C13FB0
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _ShowDashboard : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FD9DFD0
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD54C0F150
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class _ShowKeyboard : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54C0F1D0
    public void Invoke(){} // RVA: 0x7FFD510E1AD0
    public void BeginInvoke(){} // RVA: 0x7FFD54C0F2A0
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _ShowKeyboardForOverlay : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54C0F3F0
    public void Invoke(){} // RVA: 0x7FFD510E1C70
    public void BeginInvoke(){} // RVA: 0x7FFD54C0F4C0
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _ShowMessageOverlay : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54C0F810
    public void Invoke(){} // RVA: 0x7FFD510E1930
    public void BeginInvoke(){} // RVA: 0x7FFD54C0F8E0
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _ShowMirrorWindow : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
    public void BeginInvoke(){} // RVA: 0x7FFD4E39FA60
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class _ShowOverlay : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F841F80
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD54C0DD30
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _ShowWorkingSetPreview : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
    public void BeginInvoke(){} // RVA: 0x7FFD4E39FA60
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class _Skip : AsyncEnumeratorBase`2
{
    public int count;
    public int index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryMoveNextCore(){}
}

public class _SkipLast : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public int count;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public System.Collections.Generic.Queue`1<T> queue;
    public bool continueNext;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void SourceMoveNext(){} // RVA: 0x7FFD4E090980
    public void MoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class _SkipUntil : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.Action`1<object> MoveNextCoreDelegate;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken1;
    public bool completed;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration1;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public bool continueNext;
    public System.Exception exception;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void SourceMoveNext(){} // RVA: 0x7FFD4E090980
    public void MoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void RunOther(){} // RVA: 0x7FFD4E2ADC40
    public void OnCanceled1(){} // RVA: 0x7FFD4E090A10
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class _SkipUntilCanceled : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.Action`1<object> CancelDelegate2;
    public System.Action`1<object> MoveNextCoreDelegate;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken1;
    public System.Threading.CancellationToken cancellationToken2;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration1;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration2;
    public int isCanceled;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public bool continueNext;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void SourceMoveNext(){} // RVA: 0x7FFD4E090980
    public void MoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void OnCanceled1(){} // RVA: 0x7FFD4E090A10
    public void OnCanceled2(){} // RVA: 0x7FFD4E090A10
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class _SkipWhile : AsyncEnumeratorBase`2
{
    public System.Func`2<T,bool> predicate;

    // ── Methods ──
    public void .ctor(){}
    public void TryMoveNextCore(){}
}

public class _SkipWhileAwait : AsyncEnumeratorAwaitSelectorBase`3
{
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;

    // ── Methods ──
    public void .ctor(){}
    public void TransformAsync(){} // RVA: 0x7FFD4E2ADC40
    public void TrySetCurrentCore(){}
}

public class _SkipWhileAwaitWithCancellation : AsyncEnumeratorAwaitSelectorBase`3
{
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;

    // ── Methods ──
    public void .ctor(){}
    public void TransformAsync(){} // RVA: 0x7FFD4E2ADC40
    public void TrySetCurrentCore(){}
}

public class _SkipWhileInt : AsyncEnumeratorBase`2
{
    public System.Func`3<T,int,bool> predicate;
    public int index;

    // ── Methods ──
    public void .ctor(){}
    public void TryMoveNextCore(){}
}

public class _SkipWhileIntAwait : AsyncEnumeratorAwaitSelectorBase`3
{
    public System.Func`3<T,int,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;
    public int index;

    // ── Methods ──
    public void .ctor(){}
    public void TransformAsync(){} // RVA: 0x7FFD4E2ADC40
    public void TrySetCurrentCore(){}
}

public class _SkipWhileIntAwaitWithCancellation : AsyncEnumeratorAwaitSelectorBase`3
{
    public System.Func`4<T,int,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;
    public int index;

    // ── Methods ──
    public void .ctor(){}
    public void TransformAsync(){} // RVA: 0x7FFD4E2ADC40
    public void TrySetCurrentCore(){}
}

public class _StringToHandle : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FF6E9E0
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD54C153F0
    public void EndInvoke(){} // RVA: 0x7FFD4FE35FD0
}

public class _Submit : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53D91580
    public void Invoke(){} // RVA: 0x7FFD4EC5F780
    public void BeginInvoke(){} // RVA: 0x7FFD54C0ADD0
    public void EndInvoke(){} // RVA: 0x7FFD4FF6EB70
}

public class _SubmitExplicitTimingData : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5098C080
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
    public void BeginInvoke(){} // RVA: 0x7FFD4E39FA60
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _SubmitScreenshot : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53D91E20
    public void Invoke(){} // RVA: 0x7FFD4EC5F780
    public void BeginInvoke(){} // RVA: 0x7FFD54C12400
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _SubmitWithArrayIndex : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54C0AED0
    public void Invoke(){} // RVA: 0x7FFD51080E20
    public void BeginInvoke(){} // RVA: 0x7FFD54C0AFA0
    public void EndInvoke(){} // RVA: 0x7FFD4FF6EB70
}

public class _SuspendRendering : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F4DEC20
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD54C0B610
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class _Take : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public int count;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public int index;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void SourceMoveNext(){} // RVA: 0x7FFD4E090980
    public void MoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class _TakeLast : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public int count;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public System.Collections.Generic.Queue`1<T> queue;
    public bool iterateCompleted;
    public bool continueNext;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void SourceMoveNext(){} // RVA: 0x7FFD4E090980
    public void MoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class _TakeStereoScreenshot : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FF6EBA0
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    public void BeginInvoke(){} // RVA: 0x7FFD54C12340
    public void EndInvoke(){} // RVA: 0x7FFD4FE35FD0
}

public class _TakeUntil : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.Action`1<object> MoveNextCoreDelegate;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken1;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration1;
    public bool completed;
    public System.Exception exception;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void SourceMoveNext(){} // RVA: 0x7FFD4E090980
    public void MoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void RunOther(){} // RVA: 0x7FFD4E2ADC40
    public void OnCanceled1(){} // RVA: 0x7FFD4E090A10
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class _TakeUntilCanceled : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.Action`1<object> CancelDelegate2;
    public System.Action`1<object> MoveNextCoreDelegate;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
    public System.Threading.CancellationToken cancellationToken1;
    public System.Threading.CancellationToken cancellationToken2;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration1;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration2;
    public bool isCanceled;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void SourceMoveNext(){} // RVA: 0x7FFD4E090980
    public void MoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void OnCanceled1(){} // RVA: 0x7FFD4E090A10
    public void OnCanceled2(){} // RVA: 0x7FFD4E090A10
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class _TakeWhile : AsyncEnumeratorBase`2
{
    public System.Func`2<T,bool> predicate;

    // ── Methods ──
    public void .ctor(){}
    public void TryMoveNextCore(){}
}

public class _TakeWhileAwait : AsyncEnumeratorAwaitSelectorBase`3
{
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;

    // ── Methods ──
    public void .ctor(){}
    public void TransformAsync(){} // RVA: 0x7FFD4E2ADC40
    public void TrySetCurrentCore(){}
}

public class _TakeWhileAwaitWithCancellation : AsyncEnumeratorAwaitSelectorBase`3
{
    public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;

    // ── Methods ──
    public void .ctor(){}
    public void TransformAsync(){} // RVA: 0x7FFD4E2ADC40
    public void TrySetCurrentCore(){}
}

public class _TakeWhileInt : AsyncEnumeratorBase`2
{
    public System.Func`3<T,int,bool> predicate;
    public int index;

    // ── Methods ──
    public void .ctor(){}
    public void TryMoveNextCore(){}
}

public class _TakeWhileIntAwait : AsyncEnumeratorAwaitSelectorBase`3
{
    public System.Func`3<T,int,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;
    public int index;

    // ── Methods ──
    public void .ctor(){}
    public void TransformAsync(){} // RVA: 0x7FFD4E2ADC40
    public void TrySetCurrentCore(){}
}

public class _TakeWhileIntAwaitWithCancellation : AsyncEnumeratorAwaitSelectorBase`3
{
    public System.Func`4<T,int,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;
    public int index;

    // ── Methods ──
    public void .ctor(){}
    public void TransformAsync(){} // RVA: 0x7FFD4E2ADC40
    public void TrySetCurrentCore(){}
}

public class _Throw : Object
{
    public System.Exception Current;
    public System.Threading.CancellationToken cancellationToken;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
}

public class _ToUniTaskAsyncEnumerable : Object
{
    public System.Collections.Generic.IEnumerable`1<T> Current;
    public System.Threading.CancellationToken cancellationToken;
    public System.Collections.Generic.IEnumerator`1<T> enumerator;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
}

public class _ToUniTaskAsyncEnumerableObservable : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.IObservable`1<T> source;
    public System.Threading.CancellationToken cancellationToken;
    public bool useCachedCurrent;
    public T current;
    public bool subscribeCompleted;
    public System.Collections.Generic.Queue`1<T> queuedResult;
    public System.Exception error;
    public System.IDisposable subscription;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void OnCompleted(){} // RVA: 0x7FFD4E090980
    public void OnError(){} // RVA: 0x7FFD4E090A40
    public void OnNext(){} // RVA: 0x7FFD4E2ADC40
    public void OnCanceled(){} // RVA: 0x7FFD4E090A10
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class _ToUniTaskAsyncEnumerableTask : Object
{
    public System.Threading.Tasks.Task`1<T> Current;
    public System.Threading.CancellationToken cancellationToken;
    public T current;
    public bool called;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
}

public class _ToUniTaskAsyncEnumerableUniTask : Object
{
    public Cysharp.Threading.Tasks.UniTask`1<T> Current;
    public System.Threading.CancellationToken cancellationToken;
    public T current;
    public bool called;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
}

public class _TrackedDeviceToPropertyContainer : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510D01B0
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD54C151D0
    public void EndInvoke(){} // RVA: 0x7FFD4FF78720
}

public class _TriggerHapticPulse : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53D912F0
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    public void BeginInvoke(){} // RVA: 0x7FFD54C07810
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class _TriggerHapticVibrationAction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53D9E170
    public void Invoke(){} // RVA: 0x7FFD53D9E240
    public void BeginInvoke(){} // RVA: 0x7FFD54C139E0
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _TriggerLaserMouseHapticVibration : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53D96F70
    public void Invoke(){} // RVA: 0x7FFD515B31F0
    public void BeginInvoke(){} // RVA: 0x7FFD54C0E600
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _UnlockGLSharedTextureForAccess : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FD9DFD0
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD54C0B9C0
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class _UpdateActionState : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53A169B0
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    public void BeginInvoke(){} // RVA: 0x7FFD54C12A90
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _UpdateScreenshotProgress : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53D9D040
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD54C12290
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _WaitAndAcquireReadOnlyBlock : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54C159F0
    public void Invoke(){} // RVA: 0x7FFD51080E20
    public void BeginInvoke(){} // RVA: 0x7FFD54C15AC0
    public void EndInvoke(){} // RVA: 0x7FFD4FF6EB70
}

public class _WaitFrameSync : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510D0280
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD54C0DFB0
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _WaitGetPoses : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53D94F00
    public void Invoke(){} // RVA: 0x7FFD4EC5F780
    public void BeginInvoke(){} // RVA: 0x7FFD54C0ABB0
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _Where : MoveNextSource
{
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> Current;
    public System.Func`2<T,bool> predicate;
    public System.Threading.CancellationToken cancellationToken;
    public int state;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public System.Action moveNextAction;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
}

public class _WhereAwait : MoveNextSource
{
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> Current;
    public System.Func`3<T,int,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;
    public System.Threading.CancellationToken cancellationToken;
    public int state;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public Awaiter<bool> awaiter2;
    public System.Action moveNextAction;
    public int index;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
}

public class _WhereAwaitWithCancellation : MoveNextSource
{
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> Current;
    public System.Func`4<T,int,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;
    public System.Threading.CancellationToken cancellationToken;
    public int state;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
    public Awaiter<bool> awaiter;
    public Awaiter<bool> awaiter2;
    public System.Action moveNextAction;
    public int index;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void MoveNext(){} // RVA: 0x7FFD4E090980
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
}

public class _Write : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53D96160
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    public void BeginInvoke(){} // RVA: 0x7FFD54C14840
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class _WritePathBatch : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53D96160
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    public void BeginInvoke(){} // RVA: 0x7FFD54C15320
    public void EndInvoke(){} // RVA: 0x7FFD4FE35FD0
}

public class _WritePropertyBatch : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53D96160
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    public void BeginInvoke(){} // RVA: 0x7FFD54C15080
    public void EndInvoke(){} // RVA: 0x7FFD4FE35FD0
}

public class _Zip : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.Action`1<object> secondMoveNextCoreDelegate;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> first;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V> second;
    public System.Func`3<U,V,T> resultSelector;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> firstEnumerator;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<V> secondEnumerator;
    public Awaiter<bool> firstAwaiter;
    public Awaiter<bool> secondAwaiter;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void FirstMoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void SecondMoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class _ZipAwait : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.Action`1<object> secondMoveNextCoreDelegate;
    public System.Action`1<object> resultAwaitCoreDelegate;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> first;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V> second;
    public System.Func`3<U,V,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> firstEnumerator;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<V> secondEnumerator;
    public Awaiter<bool> firstAwaiter;
    public Awaiter<bool> secondAwaiter;
    public Awaiter<T> resultAwaiter;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void FirstMoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void SecondMoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void ResultAwaitCore(){} // RVA: 0x7FFD4E090A10
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class _ZipAwaitWithCancellation : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.Action`1<object> secondMoveNextCoreDelegate;
    public System.Action`1<object> resultAwaitCoreDelegate;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> first;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V> second;
    public System.Func`4<U,V,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<U> firstEnumerator;
    public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<V> secondEnumerator;
    public Awaiter<bool> firstAwaiter;
    public Awaiter<bool> secondAwaiter;
    public Awaiter<T> resultAwaiter;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void FirstMoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void SecondMoveNextCore(){} // RVA: 0x7FFD4E090A10
    public void ResultAwaitCore(){} // RVA: 0x7FFD4E090A10
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class __JobReflectionRegistrationOutput__1221673671587648887 : Object
{
    // ── Methods ──
    public void EarlyInit(){} // RVA: 0x7FFD4EF034F0
    public void Equals(){} // RVA: 0x7FFD4EF03500
    public void GetHashCode(){} // RVA: 0x7FFD4EF03580
    public void op_Implicit(){} // RVA: 0x7FFD4EF03590
    public void CompareBaseObjects(){} // RVA: 0x7FFD4EF03610
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4EF03690
    public void GetCachedPtr(){} // RVA: 0x7FFD4EF036A0
    public void get_name(){} // RVA: 0x7FFD4EF03720
}

public class __JobReflectionRegistrationOutput__1652832624114795843 : Object
{
    // ── Methods ──
    public void CreateJobReflectionData(){} // RVA: 0x7FFD54935540
    public void EarlyInit(){} // RVA: 0x7FFD54935C20
}

public class __JobReflectionRegistrationOutput__18144967076915524336 : Object
{
    // ── Methods ──
    public void CreateJobReflectionData(){} // RVA: 0x7FFD552794C0
    public void EarlyInit(){} // RVA: 0x7FFD55279A90
}

public class __StaticArrayInitTypeSize=10 : ValueType
{
}

public class __StaticArrayInitTypeSize=1018 : ValueType
{
}

public class __StaticArrayInitTypeSize=1024 : ValueType
{
}

public class __StaticArrayInitTypeSize=10800 : ValueType
{
}

public class __StaticArrayInitTypeSize=11 : ValueType
{
}

public class __StaticArrayInitTypeSize=112 : ValueType
{
}

public class __StaticArrayInitTypeSize=116 : ValueType
{
}

public class __StaticArrayInitTypeSize=12 : ValueType
{
}

public class __StaticArrayInitTypeSize=120 : ValueType
{
}

public class __StaticArrayInitTypeSize=1208 : ValueType
{
}

public class __StaticArrayInitTypeSize=128 : ValueType
{
}

public class __StaticArrayInitTypeSize=13 : ValueType
{
}

public class __StaticArrayInitTypeSize=130 : ValueType
{
}

public class __StaticArrayInitTypeSize=1320 : ValueType
{
}

public class __StaticArrayInitTypeSize=14 : ValueType
{
}

public class __StaticArrayInitTypeSize=1450 : ValueType
{
}

public class __StaticArrayInitTypeSize=1472 : ValueType
{
}

public class __StaticArrayInitTypeSize=15 : ValueType
{
}

public class __StaticArrayInitTypeSize=152 : ValueType
{
}

public class __StaticArrayInitTypeSize=16 : ValueType
{
}

public class __StaticArrayInitTypeSize=1665 : ValueType
{
}

public class __StaticArrayInitTypeSize=170 : ValueType
{
}

public class __StaticArrayInitTypeSize=172 : ValueType
{
}

public class __StaticArrayInitTypeSize=174 : ValueType
{
}

public class __StaticArrayInitTypeSize=1824 : ValueType
{
}

public class __StaticArrayInitTypeSize=19 : ValueType
{
}

public class __StaticArrayInitTypeSize=192 : ValueType
{
}

public class __StaticArrayInitTypeSize=20 : ValueType
{
}

public class __StaticArrayInitTypeSize=2048 : ValueType
{
}

public class __StaticArrayInitTypeSize=2052 : ValueType
{
}

public class __StaticArrayInitTypeSize=2100 : ValueType
{
}

public class __StaticArrayInitTypeSize=212 : ValueType
{
}

public class __StaticArrayInitTypeSize=2176 : ValueType
{
}

public class __StaticArrayInitTypeSize=2350 : ValueType
{
}
