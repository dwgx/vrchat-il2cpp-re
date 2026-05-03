// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Http
// Classes: 2
// Methods: 7

namespace ThirdParty.DotNet.Mono.Http
{
    public class NtlmClient : Object
    {
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Net.HttpWebRequest,Mono.Http.NtlmSession> cache;

        // ── Methods ──
        public void Authenticate(){} // RVA: 0x7FFE871D5590
        public void PreAuthenticate(){} // RVA: 0x7FFE813240E0
        public void get_AuthenticationType(){} // RVA: 0x7FFE871D5A30
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE871D5A70
    }

    public class NtlmSession : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Authenticate(){} // RVA: 0x7FFE871D4DE0
    }

}