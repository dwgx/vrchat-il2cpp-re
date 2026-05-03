// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 6
// Methods: 38

namespace ThirdParty.Sentry.Sentry
{
    public class HasExtraExtensions : Object
    {
        // ── Methods ──
        public void SetExtras(){} // RVA: 0x7FFE86DEAC90
    }

    public class HasTagsExtensions : Object
    {
        // ── Methods ──
        public void SetTags(){} // RVA: 0x7FFE86DEB030
    }

    public class HintTypes : Object
    {
    }

    public class HttpHeadersExtensions : Object
    {
        // ── Methods ──
        public void GetCookies(){} // RVA: 0x7FFE86DE8570
    }

    public class HttpStatusCodeRange : ValueType
    {
        public int _start; // 0x10
        public int _end; // 0x14

        // ── Methods ──
        public void get_Start(){} // RVA: 0x7FFE826F4220
        public void set_Start(){} // RVA: 0x7FFE815BF990
        public void get_End(){} // RVA: 0x7FFE826F42A0
        public void set_End(){} // RVA: 0x7FFE826F4290
        public void .ctor(){} // RVA: 0x7FFE86DE8630 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE86DE86C0 | overloaded x4
        public void Contains(){} // RVA: 0x7FFE86DE8760 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE86DE8770
        public void PrintMembers(){} // RVA: 0x7FFE86DE88A0
        public void op_Inequality(){} // RVA: 0x7FFE86DE8A50
        public void op_Equality(){} // RVA: 0x7FFE86DE8A70
        public void GetHashCode(){} // RVA: 0x7FFE86DE8A90
        public void Equals(){} // RVA: 0x7FFE86DE8BC0 | overloaded x2
    }

    public class HubExtensions : Object
    {
        // ── Methods ──
        public void StartTransaction(){} // RVA: 0x7FFE86DE9DD0 | overloaded x5
        public void AddBreadcrumb(){} // RVA: 0x7FFE86DE94C0 | overloaded x3
        public void PushAndLockScope(){} // RVA: 0x7FFE86DE9670
        public void LockScope(){} // RVA: 0x7FFE86DE96D0
        public void UnlockScope(){} // RVA: 0x7FFE86DE9840
        public void CaptureExceptionInternal(){} // RVA: 0x7FFE86DE99B0
        public void CaptureException(){} // RVA: 0x7FFE86DE9B20
        public void CaptureMessage(){} // RVA: 0x7FFE86DE9C20
        public void GetTransaction(){} // RVA: 0x7FFE86DE9F80
        public void GetTransactionIfSampled(){} // RVA: 0x7FFE86DEA0A0
    }

}