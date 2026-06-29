// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Futures
// Classes: 5
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.Futures
{
    public class FutureCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DFE0
        public void Invoke(){} // RVA: 0x7A7E18800
        public void BeginInvoke(){} // RVA: 0x7A7E06710
        public void EndInvoke(){} // RVA: 0x7A7E18800
    }

    public class FutureErrorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81577F0
        public void Invoke(){} // RVA: 0x7A8133090
        public void BeginInvoke(){} // RVA: 0x7A81330A0
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class FutureValueCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DFE0
        public void Invoke(){} // RVA: 0x7A8051B10
        public void BeginInvoke(){} // RVA: 0x7A8051B10
        public void EndInvoke(){} // RVA: 0x7A7E18800
    }

    public class Future`1 : Object
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x7A7E00710
        public void get_value(){} // RVA: 0x7A8051B10
        public void get_error(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A7E18770
        public void OnItem(){} // RVA: 0x7A7E00B20
        public void OnSuccess(){} // RVA: 0x7A7E00B20
        public void OnError(){} // RVA: 0x7A7E00B20
        public void OnComplete(){} // RVA: 0x7A7E00B20
        public void Process(){} // RVA: 0x7A7E00B20
        public void ThreadFunc(){} // RVA: 0x7A7E18800
        public void Assign(){} // RVA: 0x7A8051B10
        public void BeginProcess(){} // RVA: 0x7A8051B10
        public void AssignItem(){} // RVA: 0x7A8051B10
        public void Fail(){} // RVA: 0x7A7E18800
        public void AssignImpl(){} // RVA: 0x7A8051B10
        public void FailImpl(){} // RVA: 0x7A7E18800
        public void FlushSuccessCallbacks(){} // RVA: 0x7A7E18770
        public void FlushErrorCallbacks(){} // RVA: 0x7A7E18770
        public void FlushComplationCallbacks(){} // RVA: 0x7A7E18770
        public void ClearCallbacks(){} // RVA: 0x7A7E18770
    }

    public class IFuture`1
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x7A7E00710
        public void get_value(){} // RVA: 0x7A8051B10
        public void get_error(){} // RVA: 0x7A7E00680
        public void OnItem(){} // RVA: 0x7A7E00B20
        public void OnSuccess(){} // RVA: 0x7A7E00B20
        public void OnError(){} // RVA: 0x7A7E00B20
        public void OnComplete(){} // RVA: 0x7A7E00B20
    }

}