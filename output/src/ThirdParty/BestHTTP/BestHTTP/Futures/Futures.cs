// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Futures
// Classes: 4
// Methods: 35

namespace ThirdParty.BestHTTP.BestHTTP.Futures
{
    public class FutureCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E090A40
        public void BeginInvoke(){} // RVA: 0x7FFD4E08AE80
        public void EndInvoke(){} // RVA: 0x7FFD4E090A40
    }

    public class FutureValueCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
        public void BeginInvoke(){} // RVA: 0x7FFD4E2ADC40
        public void EndInvoke(){} // RVA: 0x7FFD4E090A40
    }

    public class Future`1 : Object
    {
        public % state;
        public T value;
        public System.Exception error;
        public System.Func`1<T> _processFunc;
        public System.Collections.Generic.List`1<BestHTTP.Futures.FutureValueCallback`1<T>> _itemCallbacks;
        public System.Collections.Generic.List`1<BestHTTP.Futures.FutureValueCallback`1<T>> _successCallbacks;
        public System.Collections.Generic.List`1<0x66409EF0> _errorCallbacks;
        public System.Collections.Generic.List`1<BestHTTP.Futures.FutureCallback`1<T>> _complationCallbacks;

        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFD4E079960
        public void get_value(){} // RVA: 0x7FFD4E2ADC40
        public void get_error(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void OnItem(){} // RVA: 0x7FFD4E078F40
        public void OnSuccess(){} // RVA: 0x7FFD4E078F40
        public void OnError(){} // RVA: 0x7FFD4E078F40
        public void OnComplete(){} // RVA: 0x7FFD4E078F40
        public void Process(){} // RVA: 0x7FFD4E078F40
        public void ThreadFunc(){} // RVA: 0x7FFD4E090A40
        public void Assign(){} // RVA: 0x7FFD4E2ADC40
        public void BeginProcess(){} // RVA: 0x7FFD4E2ADC40
        public void AssignItem(){} // RVA: 0x7FFD4E2ADC40
        public void Fail(){} // RVA: 0x7FFD4E090A40
        public void AssignImpl(){} // RVA: 0x7FFD4E2ADC40
        public void FailImpl(){} // RVA: 0x7FFD4E090A40
        public void FlushSuccessCallbacks(){} // RVA: 0x7FFD4E090980
        public void FlushErrorCallbacks(){} // RVA: 0x7FFD4E090980
        public void FlushComplationCallbacks(){} // RVA: 0x7FFD4E090980
        public void ClearCallbacks(){} // RVA: 0x7FFD4E090980
    }

    public class IFuture`1
    {
        public System.Collections.Immutable.SecureObjectPool`2<System.Collections.Generic.Stack`1<System.Collections.Immutable.RefAsValueType`1<Node<T>>>,Enumerator<T>> state;
        public Builder<T> value;
        public int error;

        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFD4E079960
        public void get_value(){} // RVA: 0x7FFD4E2ADC40
        public void get_error(){} // RVA: 0x7FFD4E078E90
        public void OnItem(){} // RVA: 0x7FFD4E078F40
        public void OnSuccess(){} // RVA: 0x7FFD4E078F40
        public void OnError(){} // RVA: 0x7FFD4E078F40
        public void OnComplete(){} // RVA: 0x7FFD4E078F40
    }

}