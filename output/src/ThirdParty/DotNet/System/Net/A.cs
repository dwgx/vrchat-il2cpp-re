// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 13

namespace ThirdParty.DotNet.System.Net
{
    public class AuthenticationManager : Object
    {
        public System.Collections.ArrayList modules;
        public object locker; // 0x8
        public System.Net.ICredentialPolicy credential_policy; // 0x10

        // ── Methods ──
        public void EnsureModules(){} // RVA: 0x7FFAC92DC1E0
        public void Authenticate(){} // RVA: 0x7FFAC92DC610
        public void DoAuthenticate(){} // RVA: 0x7FFAC92DC770
        public void PreAuthenticate(){} // RVA: 0x7FFAC92DCB30
        public void .cctor(){} // RVA: 0x7FFAC92DCFD0
    }

    public class AuthenticationSchemeSelector : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8972CF0
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class Authorization : Object
    {
        public string Message; // 0x10
        public bool Complete; // 0x18
        public string ModuleAuthenticationType; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92B3130 | overloaded x2
        public void get_Message(){} // RVA: 0x7FFAC2F3C380
        public void get_Complete(){} // RVA: 0x7FFAC2F3C4E0
    }

    public class AutoWebProxyScriptEngine : Object
    {
        // ── Methods ──
        public void GetProxies(){} // RVA: 0x7FFAC8DF9EC0 | overloaded x2
    }

}