// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.ScopeStack
// Classes: 3
// Methods: 8

namespace ThirdParty.Sentry.Sentry.Internal.ScopeStack
{
    public class AsyncLocalScopeStackContainer : Object
    {
        public System.Threading.AsyncLocal`1<System.Collections.Generic.KeyValuePair`2<Sentry.Scope,Sentry.ISentryClient>[]> _asyncLocalScope; // 0x10

        // ── Methods ──
        public void get_Stack(){} // RVA: 0x7FFE86F5FB30
        public void set_Stack(){} // RVA: 0x7FFE86F5FB80
        public void .ctor(){} // RVA: 0x7FFE86F5FBE0
    }

    public class GlobalScopeStackContainer : Object
    {
        public System.Collections.Generic.KeyValuePair`2<Sentry.Scope,Sentry.ISentryClient>[] _stack; // 0x10

        // ── Methods ──
        public void get_Stack(){} // RVA: 0x7FFE81116380
        public void set_Stack(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IScopeStackContainer
    {
        // ── Methods ──
        public void get_Stack(){} // RVA: 0x7FFE80E2E2E0
        public void set_Stack(){} // RVA: 0x7FFE80E460A0
    }

}