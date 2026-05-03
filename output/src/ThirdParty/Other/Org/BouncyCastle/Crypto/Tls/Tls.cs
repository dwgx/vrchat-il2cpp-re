// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Org.BouncyCastle.Crypto.Tls
// Classes: 5
// Methods: 9

namespace ThirdParty.Other.Org.BouncyCastle.Crypto.Tls
{
    public class AlwaysValidVerifyer : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ICertificateVerifyer
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE80E32650
    }

    public class IClientCredentialsProvider
    {
        // ── Methods ──
        public void GetClientCredentials(){} // RVA: 0x7FFE80E3FC10
    }

    public class LegacyTlsAuthentication : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865CA640
        public void NotifyServerCertificate(){} // RVA: 0x7FFE89E8B180
        public void GetClientCredentials(){} // RVA: 0x7FFE89E8B250
    }

    public class LegacyTlsClient : DefaultTlsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89E8B2D0
        public void GetAuthentication(){} // RVA: 0x7FFE89E8B570
    }

}