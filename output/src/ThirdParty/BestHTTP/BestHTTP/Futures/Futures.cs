// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Futures
// Classes: 5
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.Futures
{
    public class FutureCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE80E460A0
        public void BeginInvoke(){} // RVA: 0x7FFE80E403A0
        public void EndInvoke(){} // RVA: 0x7FFE80E460A0
    }

    public class FutureErrorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE81156C70
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class FutureValueCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
        public void BeginInvoke(){} // RVA: 0x7FFE810A1420
        public void EndInvoke(){} // RVA: 0x7FFE80E460A0
    }

    public class Future`1 : Object
    {
        public 0x664A2524 _state;
        public T _value;
        public System.Exception _error;

        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFE80E2EDB0
        public void get_value(){} // RVA: 0x7FFE810A1420
        public void get_error(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void OnItem(){} // RVA: 0x7FFE80E2E390
        public void OnSuccess(){} // RVA: 0x7FFE80E2E390
        public void OnError(){} // RVA: 0x7FFE80E2E390
        public void OnComplete(){} // RVA: 0x7FFE80E2E390
        public void Process(){} // RVA: 0x7FFE80E2E390
        public void ThreadFunc(){} // RVA: 0x7FFE80E460A0
        public void Assign(){} // RVA: 0x7FFE810A1420
        public void BeginProcess(){} // RVA: 0x7FFE810A1420
        public void AssignItem(){} // RVA: 0x7FFE810A1420
        public void Fail(){} // RVA: 0x7FFE80E460A0
        public void AssignImpl(){} // RVA: 0x7FFE810A1420
        public void FailImpl(){} // RVA: 0x7FFE80E460A0
        public void FlushSuccessCallbacks(){} // RVA: 0x7FFE80E45FE0
        public void FlushErrorCallbacks(){} // RVA: 0x7FFE80E45FE0
        public void FlushComplationCallbacks(){} // RVA: 0x7FFE80E45FE0
        public void ClearCallbacks(){} // RVA: 0x7FFE80E45FE0
    }

    public class IFuture`1
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFE80E2EDB0
        public void get_value(){} // RVA: 0x7FFE810A1420
        public void get_error(){} // RVA: 0x7FFE80E2E2E0
        public void OnItem(){} // RVA: 0x7FFE80E2E390
        public void OnSuccess(){} // RVA: 0x7FFE80E2E390
        public void OnError(){} // RVA: 0x7FFE80E2E390
        public void OnComplete(){} // RVA: 0x7FFE80E2E390
    }

}