// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.X509.Extensions
// Classes: 2
// Methods: 10

namespace ThirdParty.DotNet.Mono.Security.X509.Extensions
{
    public class AuthorityKeyIdentifierExtension : X509Extension
    {
        public object aki;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x664A680
        public void Decode(){} // RVA: 0x664A690
        public void Encode(){} // RVA: 0x664A7E0
        public void get_Identifier(){} // RVA: 0x664AA50
        public void ToString(){} // RVA: 0x664AAD0
    }

    public class BasicConstraintsExtension : X509Extension
    {
        public object cA;
        public object pathLenConstraint;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x664A680
        public void Decode(){} // RVA: 0x664AD90
        public void Encode(){} // RVA: 0x664AEE0
        public void get_CertificateAuthority(){} // RVA: 0xF73960
        public void ToString(){} // RVA: 0x664B160
    }

}