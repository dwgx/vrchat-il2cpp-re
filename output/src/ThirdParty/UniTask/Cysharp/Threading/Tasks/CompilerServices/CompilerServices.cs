// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.CompilerServices
// Classes: 10
// Methods: 79

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.CompilerServices
{
    public class AsyncUniTaskMethodBuilder : ValueType
    {
        public Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise runnerPromise; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE822CCD10
        public void get_Task(){} // RVA: 0x7FFE878A66E0
        public void SetException(){} // RVA: 0x7FFE878A67D0
        public void SetResult(){} // RVA: 0x7FFE878A6880
        public void AwaitOnCompleted(){} // RVA: 0x7FFE80E4F230
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFE80E4F230
        public void Start(){} // RVA: 0x7FFE80E460A0
        public void SetStateMachine(){} // RVA: 0x7FFE810FB310
    }

    public class AsyncUniTaskMethodBuilder`1 : ValueType
    {
        public Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise`1<T> runnerPromise;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE810A1420
        public void get_Task(){} // RVA: 0x7FFE810A1420
        public void SetException(){} // RVA: 0x7FFE80E460A0
        public void SetResult(){} // RVA: 0x7FFE810A1420
        public void AwaitOnCompleted(){} // RVA: 0x7FFE80E4F230
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFE80E4F230
        public void Start(){} // RVA: 0x7FFE80E460A0
        public void SetStateMachine(){} // RVA: 0x7FFE80E460A0
    }

    public class AsyncUniTaskVoidMethodBuilder : ValueType
    {
        public Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunner runner; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE813240E0
        public void get_Task(){} // RVA: 0x7FFE810FB320
        public void SetException(){} // RVA: 0x7FFE878A68D0
        public void SetResult(){} // RVA: 0x7FFE878A69F0
        public void AwaitOnCompleted(){} // RVA: 0x7FFE80E4F230
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFE80E4F230
        public void Start(){} // RVA: 0x7FFE80E460A0
        public void SetStateMachine(){} // RVA: 0x7FFE810FB310
    }

    public class AsyncUniTaskVoid`1 : Object
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid`1<ÏÏÏÌÍÏÏÎÎÏÍÏÍÏÌÌÍÎÍÎÌÌÌ>> pool;
        public System.Action _returnAction; // 0x10
        public ÏÏÏÌÍÏÏÎÎÏÍÏÍÏÌÌÍÎÍÎÌÌÌ stateMachine; // 0x18

        // ── Methods ──
        public void get_ReturnAction(){} // RVA: 0x7FFE81116380
        public void get_MoveNext(){} // RVA: 0x7FFE811C3500
        public void .ctor(){} // RVA: 0x7FFE85E6D7E0
        public void SetStateMachine(){} // RVA: 0x7FFE85E6D920
        public void .cctor(){} // RVA: 0x7FFE85E6DC70
        public void get_NextNode(){} // RVA: 0x7FFE85E231A0
        public void Return(){} // RVA: 0x7FFE85E231B0
        public void Run(){} // RVA: 0x7FFE85E6DE50
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){} // RVA: 0x7FFE813240E0
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7FFE813240E0
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){} // RVA: 0x7FFE810FB310
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE810FB310
    }

    public class AsyncUniTask`1 : Object
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask`1<<ContinueWith>d__22`1<UnityEngine.AudioClip>>> pool;
        public System.Action returnDelegate; // 0x10
        public System.Action _moveNext; // 0x18

        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE85EAD3A0
        public void SetStateMachine(){} // RVA: 0x7FFE85EAD500
        public void get_NextNode(){} // RVA: 0x7FFE85EAD860
        public void .cctor(){} // RVA: 0x7FFE85EAD870
        public void Return(){} // RVA: 0x7FFE85EADA50
        public void TryReturn(){} // RVA: 0x7FFE85EADB30
        public void Run(){} // RVA: 0x7FFE85EADC10
        public void get_Task(){} // RVA: 0x7FFE85EADC30
        public void SetResult(){} // RVA: 0x7FFE85EADCE0
        public void SetException(){} // RVA: 0x7FFE85EADD60
        public void GetResult(){} // RVA: 0x7FFE85EADDB0
        public void GetStatus(){} // RVA: 0x7FFE85EADE70
        public void UnsafeGetStatus(){} // RVA: 0x7FFE85EADEC0
        public void OnCompleted(){} // RVA: 0x7FFE85EADF00
    }

    public class AsyncUniTask`2 : Object
    {
        public Cysharp.Threading.Tasks.TaskPool`1<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask`2<ÌÏÎÏÍÏÍÍÍÍÏÏÎÎÍÍÌÏÍÎÍÍÎ,UnityEngine.AudioClip>> pool;
        public System.Action returnDelegate; // 0x10
        public System.Action _moveNext; // 0x18

        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE85FCD270
        public void SetStateMachine(){} // RVA: 0x7FFE85FCD3D0
        public void get_NextNode(){} // RVA: 0x7FFE85E1FE80
        public void .cctor(){} // RVA: 0x7FFE85FCD720
        public void Return(){} // RVA: 0x7FFE85F89FB0
        public void TryReturn(){} // RVA: 0x7FFE85F89FB0
        public void Run(){} // RVA: 0x7FFE85FCD900
        public void get_Task(){} // RVA: 0x7FFE85F8A090
        public void SetResult(){} // RVA: 0x7FFE85F8A100
        public void SetException(){} // RVA: 0x7FFE85F8A120
        public void GetResult(){} // RVA: 0x7FFE85FCD920
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE85FCDA00
        public void GetStatus(){} // RVA: 0x7FFE85F8A240
        public void UnsafeGetStatus(){} // RVA: 0x7FFE85F8A260
        public void OnCompleted(){} // RVA: 0x7FFE85F8A280
    }

    public class IStateMachineRunner
    {
        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFE80E2E2E0
        public void Return(){} // RVA: 0x7FFE80E45FE0
        public void get_ReturnAction(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IStateMachineRunnerPromise
    {
        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFE80E2E2E0
        public void get_Task(){} // RVA: 0x7FFE80E2DCF0
        public void SetResult(){} // RVA: 0x7FFE80E45FE0
        public void SetException(){} // RVA: 0x7FFE80E460A0
    }

    public class IStateMachineRunnerPromise`1
    {
        // ── Methods ──
        public void get_MoveNext(){} // RVA: 0x7FFE80E2E2E0
        public void get_Task(){} // RVA: 0x7FFE810A1420
        public void SetResult(){} // RVA: 0x7FFE810A1420
        public void SetException(){} // RVA: 0x7FFE80E460A0
    }

    public class StateMachineUtility : Object
    {
        // ── Methods ──
        public void GetState(){} // RVA: 0x7FFE878A6AD0
    }

}