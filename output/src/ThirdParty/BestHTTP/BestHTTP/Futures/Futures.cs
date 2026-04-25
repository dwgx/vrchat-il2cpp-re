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
        public void Invoke(){} // RVA: 0x7FFAC2C70A40
        public void BeginInvoke(){} // RVA: 0x7FFAC2C6AE80
        public void EndInvoke(){} // RVA: 0x7FFAC2C70A40
    }

    public class FutureErrorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
        public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class FutureValueCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
        public void BeginInvoke(){} // RVA: 0x7FFAC2E8DC40
        public void EndInvoke(){} // RVA: 0x7FFAC2C70A40
    }

    public class Future`1 : Object
    {
        public 0x6B0A9D90 state;
        public T value;
        public System.Exception error;
        public System.Func`1<T> _processFunc;
        public System.Collections.Generic.List`1<BestHTTP.Futures.FutureValueCallback`1<T>> _itemCallbacks;
        public System.Collections.Generic.List`1<BestHTTP.Futures.FutureValueCallback`1<T>> _successCallbacks;
        public System.Collections.Generic.List`1<BestHTTP.Futures.FutureErrorCallback> _errorCallbacks;
        public System.Collections.Generic.List`1<BestHTTP.Futures.FutureCallback`1<T>> _complationCallbacks;

        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFAC2C59960
        public void get_value(){} // RVA: 0x7FFAC2E8DC40
        public void get_error(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void OnItem(){} // RVA: 0x7FFAC2C58F40
        public void OnSuccess(){} // RVA: 0x7FFAC2C58F40
        public void OnError(){} // RVA: 0x7FFAC2C58F40
        public void OnComplete(){} // RVA: 0x7FFAC2C58F40
        public void Process(){} // RVA: 0x7FFAC2C58F40
        public void ThreadFunc(){} // RVA: 0x7FFAC2C70A40
        public void Assign(){} // RVA: 0x7FFAC2E8DC40
        public void BeginProcess(){} // RVA: 0x7FFAC2E8DC40
        public void AssignItem(){} // RVA: 0x7FFAC2E8DC40
        public void Fail(){} // RVA: 0x7FFAC2C70A40
        public void AssignImpl(){} // RVA: 0x7FFAC2E8DC40
        public void FailImpl(){} // RVA: 0x7FFAC2C70A40
        public void FlushSuccessCallbacks(){} // RVA: 0x7FFAC2C70980
        public void FlushErrorCallbacks(){} // RVA: 0x7FFAC2C70980
        public void FlushComplationCallbacks(){} // RVA: 0x7FFAC2C70980
        public void ClearCallbacks(){} // RVA: 0x7FFAC2C70980
    }

    public class IFuture`1
    {
        public object state;
        public object value;
        public object error;

        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFAC2C59960
        public void get_value(){} // RVA: 0x7FFAC2E8DC40
        public void get_error(){} // RVA: 0x7FFAC2C58E90
        public void OnItem(){} // RVA: 0x7FFAC2C58F40
        public void OnSuccess(){} // RVA: 0x7FFAC2C58F40
        public void OnError(){} // RVA: 0x7FFAC2C58F40
        public void OnComplete(){} // RVA: 0x7FFAC2C58F40
    }

}