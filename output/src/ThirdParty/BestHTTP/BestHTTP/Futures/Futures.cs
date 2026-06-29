// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Futures
// Classes: 5
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.Futures
{
    public class FutureCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0x894320
        public void BeginInvoke(){} // RVA: 0x882090
        public void EndInvoke(){} // RVA: 0x894320
    }

    public class FutureErrorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
        public void Invoke(){} // RVA: 0xB9E010
        public void BeginInvoke(){} // RVA: 0xB9E020
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class FutureValueCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0xA94080
        public void BeginInvoke(){} // RVA: 0xA94080
        public void EndInvoke(){} // RVA: 0x894320
    }

    public class Future`1 : Object
    {
        public object _state;
        public object _value;
        public object _error;
        public object _processFunc;
        public object _itemCallbacks;
        public object _successCallbacks;
        public object _errorCallbacks;
        public object _complationCallbacks;

        // ── Methods ──
        public void get_state(){} // RVA: 0x87C130
        public void get_value(){} // RVA: 0xA94080
        public void get_error(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894290
        public void OnItem(){} // RVA: 0x87C540
        public void OnSuccess(){} // RVA: 0x87C540
        public void OnError(){} // RVA: 0x87C540
        public void OnComplete(){} // RVA: 0x87C540
        public void Process(){} // RVA: 0x87C540
        public void ThreadFunc(){} // RVA: 0x894320
        public void Assign(){} // RVA: 0xA94080
        public void BeginProcess(){} // RVA: 0xA94080
        public void AssignItem(){} // RVA: 0xA94080
        public void Fail(){} // RVA: 0x894320
        public void AssignImpl(){} // RVA: 0xA94080
        public void FailImpl(){} // RVA: 0x894320
        public void FlushSuccessCallbacks(){} // RVA: 0x894290
        public void FlushErrorCallbacks(){} // RVA: 0x894290
        public void FlushComplationCallbacks(){} // RVA: 0x894290
        public void ClearCallbacks(){} // RVA: 0x894290
    }

    public class IFuture`1
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x87C130
        public void get_value(){} // RVA: 0xA94080
        public void get_error(){} // RVA: 0x87C0A0
        public void OnItem(){} // RVA: 0x87C540
        public void OnSuccess(){} // RVA: 0x87C540
        public void OnError(){} // RVA: 0x87C540
        public void OnComplete(){} // RVA: 0x87C540
    }

}