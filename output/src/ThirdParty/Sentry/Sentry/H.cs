// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 6
// Methods: 38

namespace ThirdParty.Sentry.Sentry
{
    public class HasExtraExtensions : Object
    {
        // ── Methods ──
        public void SetExtras(){} // RVA: 0x7FFAC8A41600
    }

    public class HasTagsExtensions : Object
    {
        // ── Methods ──
        public void SetTags(){} // RVA: 0x7FFAC8A419A0
    }

    public class HintTypes : Object
    {
        public string HttpResponseMessage;
    }

    public class HttpHeadersExtensions : Object
    {
        // ── Methods ──
        public void GetCookies(){} // RVA: 0x7FFAC8A3EEE0
    }

    public class HttpStatusCodeRange : ValueType
    {
        public int Start; // 0x10
        public int End; // 0x14

        // ── Methods ──
        public void get_Start(){} // RVA: 0x7FFAC4420210
        public void set_Start(){} // RVA: 0x7FFAC336D8B0
        public void get_End(){} // RVA: 0x7FFAC44202A0
        public void set_End(){} // RVA: 0x7FFAC4420230
        public void .ctor(){} // RVA: 0x7FFAC8A3EFA0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC8A3F030 | overloaded x4
        public void Contains(){} // RVA: 0x7FFAC8A3F0D0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC8A3F0E0
        public void PrintMembers(){} // RVA: 0x7FFAC8A3F210
        public void op_Inequality(){} // RVA: 0x7FFAC8A3F3C0
        public void op_Equality(){} // RVA: 0x7FFAC8A3F3E0
        public void GetHashCode(){} // RVA: 0x7FFAC8A3F400
        public void Equals(){} // RVA: 0x7FFAC8A3F530 | overloaded x2
    }

    public class HubExtensions : Object
    {
        // ── Methods ──
        public void StartTransaction(){} // RVA: 0x7FFAC8A40740 | overloaded x5
        public void AddBreadcrumb(){} // RVA: 0x7FFAC8A3FE30 | overloaded x3
        public void PushAndLockScope(){} // RVA: 0x7FFAC8A3FFE0
        public void LockScope(){} // RVA: 0x7FFAC8A40040
        public void UnlockScope(){} // RVA: 0x7FFAC8A401B0
        public void CaptureExceptionInternal(){} // RVA: 0x7FFAC8A40320
        public void CaptureException(){} // RVA: 0x7FFAC8A40490
        public void CaptureMessage(){} // RVA: 0x7FFAC8A40590
        public void GetTransaction(){} // RVA: 0x7FFAC8A408F0
        public void GetTransactionIfSampled(){} // RVA: 0x7FFAC8A40A10
    }

}