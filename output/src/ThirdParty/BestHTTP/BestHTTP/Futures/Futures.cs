// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Futures
// Classes: 5
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.Futures
{
    public class FutureCallback`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x24B10
        public void BeginInvoke(){} // RVA: 0x1EE30
        public void EndInvoke(){} // RVA: 0x24B10
    }

    public class FutureErrorCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x35D190
        public void Invoke(){} // RVA: 0x338C60
        public void BeginInvoke(){} // RVA: 0x338C70
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class FutureValueCallback`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x283FA0
        public void BeginInvoke(){} // RVA: 0x283FA0
        public void EndInvoke(){} // RVA: 0x24B10
    }

    public class Future`1
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0xD840
        public void get_value(){} // RVA: 0x283FA0
        public void get_error(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24A50
        public void OnItem(){} // RVA: 0xCE10
        public void OnSuccess(){} // RVA: 0xCE10
        public void OnError(){} // RVA: 0xCE10
        public void OnComplete(){} // RVA: 0xCE10
        public void Process(){} // RVA: 0xCE10
        public void ThreadFunc(){} // RVA: 0x24B10
        public void Assign(){} // RVA: 0x283FA0
        public void BeginProcess(){} // RVA: 0x283FA0
        public void AssignItem(){} // RVA: 0x283FA0
        public void Fail(){} // RVA: 0x24B10
        public void AssignImpl(){} // RVA: 0x283FA0
        public void FailImpl(){} // RVA: 0x24B10
        public void FlushSuccessCallbacks(){} // RVA: 0x24A50
        public void FlushErrorCallbacks(){} // RVA: 0x24A50
        public void FlushComplationCallbacks(){} // RVA: 0x24A50
        public void ClearCallbacks(){} // RVA: 0x24A50
    }

    public class IFuture`1
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0xD840
        public void get_value(){} // RVA: 0x283FA0
        public void get_error(){} // RVA: 0xCD60
        public void OnItem(){} // RVA: 0xCE10
        public void OnSuccess(){} // RVA: 0xCE10
        public void OnError(){} // RVA: 0xCE10
        public void OnComplete(){} // RVA: 0xCE10
    }

}