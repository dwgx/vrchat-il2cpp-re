// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 11

namespace ThirdParty.DotNet.System.Net
{
    public class AuthenticationManager : Object
    {
        public object modules;
        public object locker;
        public object credential_policy;

        // ── Methods ──
        public void EnsureModules(){} // RVA: 0x75A8950
        public void Authenticate(){} // RVA: 0x75A8D50
        public void DoAuthenticate(){} // RVA: 0x75A8EB0
        public void PreAuthenticate(){} // RVA: 0x75A9220
        public void .cctor(){} // RVA: 0x75A9680
    }

    public class AuthenticationSchemeSelector : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F6EBF0
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class Authorization : Object
    {
        public object m_Message;
        public object m_Complete;
        public object ModuleAuthenticationType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75808A0
        public void get_Message(){} // RVA: 0xB5DBF0
        public void get_Complete(){} // RVA: 0xB5DD50
    }

    public class AutoWebProxyScriptEngine : Object
    {
        // ── Methods ──
        public void GetProxies(){} // RVA: 0x70CE570
    }

}