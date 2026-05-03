// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 3
// Methods: 19

public class YProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFE87D4EA60
    public void .ctor(){} // RVA: 0x7FFE87D4EAA0
}

public class YieldAwaiter : ValueType
{
    public System.Threading.WaitCallback s_waitCallbackRunAction;

    // ── Methods ──
    public void get_IsCompleted(){} // RVA: 0x7FFE810FB320
    public void OnCompleted(){} // RVA: 0x7FFE868890C0
    public void UnsafeOnCompleted(){} // RVA: 0x7FFE86889120
    public void QueueContinuation(){} // RVA: 0x7FFE86889180
    public void RunAction(){} // RVA: 0x7FFE868894F0
    public void GetResult(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE86889560
}

public class YieldPromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<YieldPromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE878347F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Create(){} // RVA: 0x7FFE87834970
    public void GetResult(){} // RVA: 0x7FFE87834CF0
    public void GetStatus(){} // RVA: 0x7FFE87834E90
    public void UnsafeGetStatus(){} // RVA: 0x7FFE87834EE0
    public void OnCompleted(){} // RVA: 0x7FFE87834F20
    public void MoveNext(){} // RVA: 0x7FFE87834FA0
    public void TryReturn(){} // RVA: 0x7FFE87835050
}
