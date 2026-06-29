// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.ScopeStack
// Classes: 3
// Methods: 8

namespace ThirdParty.Sentry.Sentry.Internal.ScopeStack
{
    public class AsyncLocalScopeStackContainer : Object
    {
        public object _asyncLocalScope;

        // ── Methods ──
        public void get_Stack(){} // RVA: 0x6E8FAD0
        public void set_Stack(){} // RVA: 0x6E8FB20
        public void .ctor(){} // RVA: 0x6E8FB80
    }

    public class GlobalScopeStackContainer : Object
    {
        public object _stack;

        // ── Methods ──
        public void get_Stack(){} // RVA: 0xB5DBF0
        public void set_Stack(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IScopeStackContainer
    {
        // ── Methods ──
        public void get_Stack(){} // RVA: 0x87C0A0
        public void set_Stack(){} // RVA: 0x894320
    }

}