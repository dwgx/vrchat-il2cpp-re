// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 6
// Methods: 41

namespace ThirdParty.Sentry.Sentry
{
    public class HasExtraExtensions : Object
    {
        // ── Methods ──
        public void SetExtras(){} // RVA: 0x6D17480
    }

    public class HasTagsExtensions : Object
    {
        // ── Methods ──
        public void SetTags(){} // RVA: 0x6D17820
    }

    public class HttpHeadersExtensions : Object
    {
        // ── Methods ──
        public void GetCookies(){} // RVA: 0x6D14D10
    }

    public class HttpStatusCodeRange : ValueType
    {
        public object _start;
        public object _end;

        // ── Methods ──
        public void get_Start(){} // RVA: 0x77E60
        public void set_Start(){} // RVA: 0x29580
        public void get_End(){} // RVA: 0x77E50
        public void set_End(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x8E6B10
        public void op_Implicit(){} // RVA: 0x6D14E50
        public void Contains(){} // RVA: 0x8E6B20
        public void ToString(){} // RVA: 0x8E6B30
        public void PrintMembers(){} // RVA: 0x8E6C60
        public void op_Inequality(){} // RVA: 0x6D151E0
        public void op_Equality(){} // RVA: 0x6D15200
        public void GetHashCode(){} // RVA: 0x8E6C70
        public void Equals(){} // RVA: 0x8E6D10
    }

    public class HttpStatusCodeRange[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB03E0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3CA0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6BED0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class HubExtensions : Object
    {
        // ── Methods ──
        public void StartTransaction(){} // RVA: 0x6D165D0
        public void AddBreadcrumb(){} // RVA: 0x6D15C50
        public void PushAndLockScope(){} // RVA: 0x6D15E00
        public void LockScope(){} // RVA: 0x6D15E60
        public void UnlockScope(){} // RVA: 0x6D15FD0
        public void CaptureExceptionInternal(){} // RVA: 0x6D16140
        public void CaptureException(){} // RVA: 0x6D162B0
        public void CaptureMessage(){} // RVA: 0x6D163B0
        public void GetTransaction(){} // RVA: 0x6D16770
        public void GetTransactionIfSampled(){} // RVA: 0x6D16890
    }

}