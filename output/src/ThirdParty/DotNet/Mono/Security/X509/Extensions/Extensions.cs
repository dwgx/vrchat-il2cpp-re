// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.X509.Extensions
// Classes: 2
// Methods: 10

namespace ThirdParty.DotNet.Mono.Security.X509.Extensions
{
    public class AuthorityKeyIdentifierExtension
    {
        public byte[] aki; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BD1CE0
        public void Decode(){} // RVA: 0x5BD1CF0
        public void Encode(){} // RVA: 0x5BD1E40
        public void get_Identifier(){} // RVA: 0x5BD20B0
        public void ToString(){} // RVA: 0x5BD2130
    }

    public class BasicConstraintsExtension
    {
        public bool cA; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BD1CE0
        public void Decode(){} // RVA: 0x5BD23E0
        public void Encode(){} // RVA: 0x5BD2530
        public void get_CertificateAuthority(){} // RVA: 0x6E8A80
        public void ToString(){} // RVA: 0x5BD27B0
    }

}