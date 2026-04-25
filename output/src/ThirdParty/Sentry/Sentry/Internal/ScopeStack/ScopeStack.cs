// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.ScopeStack
// Classes: 3
// Methods: 8

namespace ThirdParty.Sentry.Sentry.Internal.ScopeStack
{
    public class AsyncLocalScopeStackContainer : Object
    {
        public System.Threading.AsyncLocal`1<System.Collections.Generic.KeyValuePair`2<Sentry.Scope,Sentry.ISentryClient>[]> Stack; // 0x10

        // ── Methods ──
        public void get_Stack(){} // RVA: 0x7FFAC8BB64B0
        public void set_Stack(){} // RVA: 0x7FFAC8BB6500
        public void .ctor(){} // RVA: 0x7FFAC8BB6560
    }

    public class GlobalScopeStackContainer : Object
    {
        public System.Collections.Generic.KeyValuePair`2<Sentry.Scope,Sentry.ISentryClient>[] Stack; // 0x10

        // ── Methods ──
        public void get_Stack(){} // RVA: 0x7FFAC2F3C380
        public void set_Stack(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IScopeStackContainer
    {
        public object Stack;

        // ── Methods ──
        public void get_Stack(){} // RVA: 0x7FFAC2C58E90
        public void set_Stack(){} // RVA: 0x7FFAC2C70A40
    }

}