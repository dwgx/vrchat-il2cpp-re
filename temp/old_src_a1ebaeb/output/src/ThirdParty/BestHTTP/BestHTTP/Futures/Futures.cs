// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Futures
// Classes: 4
// Methods: 35

namespace ThirdParty.BestHTTP.BestHTTP.Futures
{
    public class FutureCallback`1 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa8660d80
        public void EndInvoke(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaa865b1c0
    }

    public class FutureValueCallback`1 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa887e5c0
        public void EndInvoke(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaa887e5c0
    }

    public class Future`1 : Object
    {
        public object _error; // 0x30FBFC40
        public object _successCallbacks; // 0x30FBFC40

        // ── Original Methods ──
        public void get_state(){} // RVA: 0x7ffaa8649ca0
        public void get_value(){} // RVA: 0x7ffaa887e5c0
        public void get_error(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void OnItem(){} // RVA: 0x7ffaa8649280
        public void OnSuccess(){} // RVA: 0x7ffaa8649280
        public void OnError(){} // RVA: 0x7ffaa8649280
        public void OnComplete(){} // RVA: 0x7ffaa8649280
        public void Process(){} // RVA: 0x7ffaa8649280
        public void ThreadFunc(){} // RVA: 0x7ffaa8660d80
        public void Assign(){} // RVA: 0x7ffaa887e5c0
        public void AssignItem(){} // RVA: 0x7ffaa887e5c0
        public void Fail(){} // RVA: 0x7ffaa8660d80
        public void AssignImpl(){} // RVA: 0x7ffaa887e5c0
        public void FailImpl(){} // RVA: 0x7ffaa8660d80
        public void FlushSuccessCallbacks(){} // RVA: 0x7ffaa8660cc0
        public void FlushErrorCallbacks(){} // RVA: 0x7ffaa8660cc0
        public void FlushComplationCallbacks(){} // RVA: 0x7ffaa8660cc0
        public void ClearCallbacks(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void BeginProcess(){} // RVA: 0x7ffaa887e5c0
    }

    public class IFuture`1
    {
        // ── Original Methods ──
        public void get_state(){} // RVA: 0x7ffaa8649ca0
        public void get_value(){} // RVA: 0x7ffaa887e5c0
        public void get_error(){} // RVA: 0x7ffaa86491d0
        public void OnItem(){} // RVA: 0x7ffaa8649280
        public void OnSuccess(){} // RVA: 0x7ffaa8649280
        public void OnError(){} // RVA: 0x7ffaa8649280
        public void OnComplete(){} // RVA: 0x7ffaa8649280
    }

}