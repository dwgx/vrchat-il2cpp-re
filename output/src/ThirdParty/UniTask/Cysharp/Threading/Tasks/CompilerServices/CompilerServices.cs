// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.CompilerServices
// Classes: 10
// Methods: 79

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.CompilerServices
{
    public class AsyncUniTaskMethodBuilder : ValueType
    {
        public Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise Task; // 0x10
        public System.Exception ex; // 0x18

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC3FB3780
        public void get_Task(){} // RVA: 0x7FFAC94FDFA0
        public void SetException(){} // RVA: 0x7FFAC94FE090
        public void SetResult(){} // RVA: 0x7FFAC94FE140
        public void AwaitOnCompleted(){} // RVA: 0x7FFAC2C79B30
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFAC2C79B30
        public void Start(){} // RVA: 0x7FFAC2C70A40
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
    }

    public class AsyncUniTaskMethodBuilder`1 : ValueType
    {
        public Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise`1<T> Task;
        public System.Exception ex;
        public T result;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void get_Task(){} // RVA: 0x7FFAC2E8DC40
        public void SetException(){} // RVA: 0x7FFAC2C70A40
        public void SetResult(){} // RVA: 0x7FFAC2E8DC40
        public void AwaitOnCompleted(){} // RVA: 0x7FFAC2C79B30
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFAC2C79B30
        public void Start(){} // RVA: 0x7FFAC2C70A40
        public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
    }

    public class AsyncUniTaskVoidMethodBuilder : ValueType
    {
        public Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunner Task; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC34F9180
        public void get_Task(){} // RVA: 0x7FFAC2F21320
        public void SetException(){} // RVA: 0x7FFAC94FE190
        public void SetResult(){} // RVA: 0x7FFAC94FE2B0
        public void AwaitOnCompleted(){} // RVA: 0x7FFAC2C79B30
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFAC2C79B30
        public void Start(){} // RVA: 0x7FFAC2C70A40
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
    }

    public class AsyncUniTaskVoid`1 : Object
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid`1<T>> ReturnAction;
        public System.Action MoveNext;
        public T NextNode;
        public System.Action <MoveNext>k__BackingField;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid`1<T> nextNode;

        // ── Methods ──
        public void get_ReturnAction(){} // RVA: 0x7FFAC2C58E90
        public void get_MoveNext(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void SetStateMachine(){} // RVA: 0x7FFAC2C70C80
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void get_NextNode(){} // RVA: 0x7FFAC2C58E90
        public void Return(){} // RVA: 0x7FFAC2C70980
        public void Run(){} // RVA: 0x7FFAC2C70980
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){}
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){}
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    }

    public class AsyncUniTask`1 : Object
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask`1<ÌÎÍÍÍÌÌÍÏÌÍÌÍÍÎÎÎÌÎÍÌÏÏ>> MoveNext;
        public System.Action NextNode; // 0x10
        public System.Action Task; // 0x18
        public ÌÎÍÍÍÌÌÍÏÌÍÌÍÍÎÎÎÌÎÍÌÏÏ stateMachine; // 0x20
        public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core; // 0x70
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask`1<ÌÎÍÍÍÌÌÍÏÌÍÌÍÍÎÎÎÌÎÍÌÏÏ> nextNode; // 0x98

        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC7B221A0
        public void SetStateMachine(){} // RVA: 0x7FFAC7B22300
        public void get_NextNode(){} // RVA: 0x7FFAC7A3A9E0
        public void .cctor(){} // RVA: 0x7FFAC7B22660
        public void Return(){} // RVA: 0x7FFAC7B22840
        public void TryReturn(){} // RVA: 0x7FFAC7B22920
        public void Run(){} // RVA: 0x7FFAC7B22A00
        public void get_Task(){} // RVA: 0x7FFAC7B22A20
        public void SetResult(){} // RVA: 0x7FFAC7B22AD0
        public void SetException(){} // RVA: 0x7FFAC7B22B50
        public void GetResult(){} // RVA: 0x7FFAC7B22BA0
        public void GetStatus(){} // RVA: 0x7FFAC7B22C60
        public void UnsafeGetStatus(){} // RVA: 0x7FFAC7B22CB0
        public void OnCompleted(){} // RVA: 0x7FFAC7B22CF0
    }

    public class AsyncUniTask`2 : Object
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask`2<ÎÎÎÏÏÌÍÌÌÍÍÌÏÌÎÍÎÏÍÎÎÏÎ,ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>> MoveNext;
        public System.Action NextNode; // 0x10
        public System.Action Task; // 0x18
        public ÎÎÎÏÏÌÍÌÌÍÍÌÏÌÎÍÎÏÍÎÎÏÎ stateMachine; // 0x20
        public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ> core; // 0x60
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask`2<ÎÎÎÏÏÌÍÌÌÍÍÌÏÌÎÍÎÏÍÎÎÏÎ,ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ> nextNode; // 0x88

        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC7BD61D0
        public void SetStateMachine(){} // RVA: 0x7FFAC7BD6330
        public void get_NextNode(){} // RVA: 0x7FFAC7A3A230
        public void .cctor(){} // RVA: 0x7FFAC7BD6680
        public void Return(){} // RVA: 0x7FFAC7B864C0
        public void TryReturn(){} // RVA: 0x7FFAC7B864C0
        public void Run(){} // RVA: 0x7FFAC7BD6860
        public void get_Task(){} // RVA: 0x7FFAC7B865A0
        public void SetResult(){} // RVA: 0x7FFAC7B86610
        public void SetException(){} // RVA: 0x7FFAC7B86630
        public void GetResult(){} // RVA: 0x7FFAC7BD6880
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC7BD6960
        public void GetStatus(){} // RVA: 0x7FFAC7B86750
        public void UnsafeGetStatus(){} // RVA: 0x7FFAC7B86770
        public void OnCompleted(){} // RVA: 0x7FFAC7B86790
    }

    public class IStateMachineRunner
    {
        public object MoveNext;
        public object ReturnAction;

        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFAC2C58E90
        public void Return(){} // RVA: 0x7FFAC2C70980
        public void get_ReturnAction(){} // RVA: 0x7FFAC2C58E90
    }

    public class IStateMachineRunnerPromise
    {
        public object MoveNext;
        public object Task;

        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFAC2C58E90
        public void get_Task(){} // RVA: 0x7FFAC2C588A0
        public void SetResult(){} // RVA: 0x7FFAC2C70980
        public void SetException(){} // RVA: 0x7FFAC2C70A40
    }

    public class IStateMachineRunnerPromise`1
    {
        public object MoveNext;
        public object Task;

        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFAC2C58E90
        public void get_Task(){} // RVA: 0x7FFAC2E8DC40
        public void SetResult(){} // RVA: 0x7FFAC2E8DC40
        public void SetException(){} // RVA: 0x7FFAC2C70A40
    }

    public class StateMachineUtility : Object
    {
        // ── Methods ──
        public void GetState(){} // RVA: 0x7FFAC94FE390
    }

}