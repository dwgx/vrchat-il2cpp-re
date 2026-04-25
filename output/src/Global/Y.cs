// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 3
// Methods: 19

public class YProperty : Property`2
{
    public object Name;

    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFAC99A61C0
    public void .ctor(){} // RVA: 0x7FFAC99A6200
}

public class YieldAwaiter : ValueType
{
    public System.Threading.WaitCallback IsCompleted;
    public System.Threading.SendOrPostCallback s_sendOrPostCallbackRunAction; // 0x8

    // ── Methods ──
    public void get_IsCompleted(){} // RVA: 0x7FFAC2F21320
    public void OnCompleted(){} // RVA: 0x7FFAC84DF890
    public void UnsafeOnCompleted(){} // RVA: 0x7FFAC84DF8F0
    public void QueueContinuation(){} // RVA: 0x7FFAC84DF950
    public void RunAction(){} // RVA: 0x7FFAC84DFCC0
    public void GetResult(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC84DFD30
}

public class YieldPromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<YieldPromise> NextNode;
    public YieldPromise nextNode; // 0x10
    public System.Threading.CancellationToken cancellationToken; // 0x18
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x20
    public bool cancelImmediately; // 0x38
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<object> core; // 0x40

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC948C0B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Create(){} // RVA: 0x7FFAC948C230
    public void GetResult(){} // RVA: 0x7FFAC948C5B0
    public void GetStatus(){} // RVA: 0x7FFAC948C750
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC948C7A0
    public void OnCompleted(){} // RVA: 0x7FFAC948C7E0
    public void MoveNext(){} // RVA: 0x7FFAC948C860
    public void TryReturn(){} // RVA: 0x7FFAC948C910
}
