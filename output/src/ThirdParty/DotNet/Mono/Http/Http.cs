// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Http
// Classes: 2
// Methods: 7

namespace ThirdParty.DotNet.Mono.Http
{
    public class NtlmClient : Object
    {
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Net.HttpWebRequest,Mono.Http.NtlmSession> AuthenticationType;

        // ── Methods ──
        public void Authenticate(){} // RVA: 0x7FFAC8E2D160
        public void PreAuthenticate(){} // RVA: 0x7FFAC34F9180
        public void get_AuthenticationType(){} // RVA: 0x7FFAC8E2D600
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8E2D640
    }

    public class NtlmSession : Object
    {
        public Mono.Security.Protocol.Ntlm.MessageBase message; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Authenticate(){} // RVA: 0x7FFAC8E2C9B0
    }

}