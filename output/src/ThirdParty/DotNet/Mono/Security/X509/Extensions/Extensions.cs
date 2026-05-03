// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.X509.Extensions
// Classes: 2
// Methods: 10

namespace ThirdParty.DotNet.Mono.Security.X509.Extensions
{
    public class AuthorityKeyIdentifierExtension : X509Extension
    {
        public byte[] aki; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86712B30
        public void Decode(){} // RVA: 0x7FFE86712B40
        public void Encode(){} // RVA: 0x7FFE86712C90
        public void get_Identifier(){} // RVA: 0x7FFE86712F00
        public void ToString(){} // RVA: 0x7FFE86712F80
    }

    public class BasicConstraintsExtension : X509Extension
    {
        public bool cA; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86712B30
        public void Decode(){} // RVA: 0x7FFE86713230
        public void Encode(){} // RVA: 0x7FFE86713380
        public void get_CertificateAuthority(){} // RVA: 0x7FFE815F1380
        public void ToString(){} // RVA: 0x7FFE86713600
    }

}