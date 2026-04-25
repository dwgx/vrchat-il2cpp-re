// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.X509.Extensions
// Classes: 2
// Methods: 10

namespace ThirdParty.DotNet.Mono.Security.X509.Extensions
{
    public class AuthorityKeyIdentifierExtension : X509Extension
    {
        public byte[] Identifier; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8369230
        public void Decode(){} // RVA: 0x7FFAC8369240
        public void Encode(){} // RVA: 0x7FFAC8369390
        public void get_Identifier(){} // RVA: 0x7FFAC8369600
        public void ToString(){} // RVA: 0x7FFAC8369680
    }

    public class BasicConstraintsExtension : X509Extension
    {
        public bool CertificateAuthority; // 0x28
        public int pathLenConstraint; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8369230
        public void Decode(){} // RVA: 0x7FFAC8369930
        public void Encode(){} // RVA: 0x7FFAC8369A80
        public void get_CertificateAuthority(){} // RVA: 0x7FFAC30F6BA0
        public void ToString(){} // RVA: 0x7FFAC8369D00
    }

}