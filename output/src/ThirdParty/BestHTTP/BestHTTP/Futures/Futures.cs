// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Futures
// Classes: 6
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.Futures
{
    public class FutureCallback`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAF2AD4B10
        public void BeginInvoke(){} // RVA: 0x7FFAF2ACEE30
        public void EndInvoke(){} // RVA: 0x7FFAF2AD4B10
    }

    public class FutureErrorCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E0D190
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
        public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class FutureValueCallback`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAF2D33FA0
        public void BeginInvoke(){} // RVA: 0x7FFAF2D33FA0
        public void EndInvoke(){} // RVA: 0x7FFAF2AD4B10
    }

    public class Future`1
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFAF2ABD840
        public void get_value(){} // RVA: 0x7FFAF2D33FA0
        public void get_error(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
        public void OnItem(){} // RVA: 0x7FFAF2ABCE10
        public void OnSuccess(){} // RVA: 0x7FFAF2ABCE10
        public void OnError(){} // RVA: 0x7FFAF2ABCE10
        public void OnComplete(){} // RVA: 0x7FFAF2ABCE10
        public void Process(){} // RVA: 0x7FFAF2ABCE10
        public void ThreadFunc(){} // RVA: 0x7FFAF2AD4B10
        public void Assign(){} // RVA: 0x7FFAF2D33FA0
        public void BeginProcess(){} // RVA: 0x7FFAF2D33FA0
        public void AssignItem(){} // RVA: 0x7FFAF2D33FA0
        public void Fail(){} // RVA: 0x7FFAF2AD4B10
        public void AssignImpl(){} // RVA: 0x7FFAF2D33FA0
        public void FailImpl(){} // RVA: 0x7FFAF2AD4B10
        public void FlushSuccessCallbacks(){} // RVA: 0x7FFAF2AD4A50
        public void FlushErrorCallbacks(){} // RVA: 0x7FFAF2AD4A50
        public void FlushComplationCallbacks(){} // RVA: 0x7FFAF2AD4A50
        public void ClearCallbacks(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IFuture`1
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFAF2ABD840
        public void get_value(){} // RVA: 0x7FFAF2D33FA0
        public void get_error(){} // RVA: 0x7FFAF2ABCD60
        public void OnItem(){} // RVA: 0x7FFAF2ABCE10
        public void OnSuccess(){} // RVA: 0x7FFAF2ABCE10
        public void OnError(){} // RVA: 0x7FFAF2ABCE10
        public void OnComplete(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFuture`1
    {
    }

}