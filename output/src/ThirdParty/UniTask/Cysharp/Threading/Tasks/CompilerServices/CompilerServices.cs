// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.CompilerServices
// Classes: 9
// Methods: 78

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.CompilerServices
{
    public class AsyncUniTaskMethodBuilder : ValueType
    {
        public object Task;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4F3D3780
        public void get_Task(){} // RVA: 0x7FFD5491DFA0
        public void SetException(){} // RVA: 0x7FFD5491E090
        public void SetResult(){} // RVA: 0x7FFD5491E140
        public void AwaitOnCompleted(){} // RVA: 0x7FFD4E099B30
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFD4E099B30
        public void Start(){} // RVA: 0x7FFD4E090A40
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
    }

    public class AsyncUniTaskMethodBuilder`1 : ValueType
    {
        public object Task;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void get_Task(){} // RVA: 0x7FFD4E2ADC40
        public void SetException(){} // RVA: 0x7FFD4E090A40
        public void SetResult(){} // RVA: 0x7FFD4E2ADC40
        public void AwaitOnCompleted(){} // RVA: 0x7FFD4E099B30
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFD4E099B30
        public void Start(){} // RVA: 0x7FFD4E090A40
        public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
    }

    public class AsyncUniTaskVoidMethodBuilder : ValueType
    {
        public object Task;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E919180
        public void get_Task(){} // RVA: 0x7FFD4E341320
        public void SetException(){} // RVA: 0x7FFD5491E190
        public void SetResult(){} // RVA: 0x7FFD5491E2B0
        public void AwaitOnCompleted(){} // RVA: 0x7FFD4E099B30
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFD4E099B30
        public void Start(){} // RVA: 0x7FFD4E090A40
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
    }

    public class AsyncUniTaskVoid`1 : Object
    {
        public object ReturnAction;
        public object MoveNext;
        public object NextNode;

        // ── Methods ──
        public void get_ReturnAction(){} // RVA: 0x7FFD4E078E90
        public void get_MoveNext(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void SetStateMachine(){} // RVA: 0x7FFD4E090C80
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void get_NextNode(){} // RVA: 0x7FFD4E078E90
        public void Return(){} // RVA: 0x7FFD4E090980
        public void Run(){} // RVA: 0x7FFD4E090980
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){}
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){}
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    }

    public class AsyncUniTask`1 : Object
    {
        public object MoveNext;
        public object NextNode;
        public object Task;

        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFD4E3447C0
        public void .ctor(){} // RVA: 0x7FFD52F421A0
        public void SetStateMachine(){} // RVA: 0x7FFD52F42300
        public void get_NextNode(){} // RVA: 0x7FFD52E5A9E0
        public void .cctor(){} // RVA: 0x7FFD52F42660
        public void Return(){} // RVA: 0x7FFD52F42840
        public void TryReturn(){} // RVA: 0x7FFD52F42920
        public void Run(){} // RVA: 0x7FFD52F42A00
        public void get_Task(){} // RVA: 0x7FFD52F42A20
        public void SetResult(){} // RVA: 0x7FFD52F42AD0
        public void SetException(){} // RVA: 0x7FFD52F42B50
        public void GetResult(){} // RVA: 0x7FFD52F42BA0
        public void GetStatus(){} // RVA: 0x7FFD52F42C60
        public void UnsafeGetStatus(){} // RVA: 0x7FFD52F42CB0
        public void OnCompleted(){} // RVA: 0x7FFD52F42CF0
    }

    public class AsyncUniTask`2 : Object
    {
        public object MoveNext;
        public object NextNode;
        public object Task;

        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFD4E3447C0
        public void .ctor(){} // RVA: 0x7FFD52FF61D0
        public void SetStateMachine(){} // RVA: 0x7FFD52FF6330
        public void get_NextNode(){} // RVA: 0x7FFD52E5A230
        public void .cctor(){} // RVA: 0x7FFD52FF6680
        public void Return(){} // RVA: 0x7FFD52FA64C0
        public void TryReturn(){} // RVA: 0x7FFD52FA64C0
        public void Run(){} // RVA: 0x7FFD52FF6860
        public void get_Task(){} // RVA: 0x7FFD52FA65A0
        public void SetResult(){} // RVA: 0x7FFD52FA6610
        public void SetException(){} // RVA: 0x7FFD52FA6630
        public void GetResult(){} // RVA: 0x7FFD52FF6880
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD52FF6960
        public void GetStatus(){} // RVA: 0x7FFD52FA6750
        public void UnsafeGetStatus(){} // RVA: 0x7FFD52FA6770
        public void OnCompleted(){} // RVA: 0x7FFD52FA6790
    }

    public class IStateMachineRunner
    {
        public object MoveNext;
        public object ReturnAction;

        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFD4E078E90
        public void Return(){} // RVA: 0x7FFD4E090980
        public void get_ReturnAction(){} // RVA: 0x7FFD4E078E90
    }

    public class IStateMachineRunnerPromise
    {
        public object MoveNext;
        public object Task;

        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFD4E078E90
        public void get_Task(){} // RVA: 0x7FFD4E0788A0
        public void SetResult(){} // RVA: 0x7FFD4E090980
        public void SetException(){} // RVA: 0x7FFD4E090A40
    }

    public class IStateMachineRunnerPromise`1
    {
        public object MoveNext;
        public object Task;

        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFD4E078E90
        public void get_Task(){} // RVA: 0x7FFD4E2ADC40
        public void SetResult(){} // RVA: 0x7FFD4E2ADC40
        public void SetException(){} // RVA: 0x7FFD4E090A40
    }

}