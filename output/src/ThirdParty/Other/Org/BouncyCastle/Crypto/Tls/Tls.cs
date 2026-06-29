// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Org.BouncyCastle.Crypto.Tls
// Classes: 5
// Methods: 9

namespace ThirdParty.Other.Org.BouncyCastle.Crypto.Tls
{
    public class AlwaysValidVerifyer : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ICertificateVerifyer
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x87D3C0
    }

    public class IClientCredentialsProvider
    {
        // ── Methods ──
        public void GetClientCredentials(){} // RVA: 0x87C5F0
    }

    public class LegacyTlsAuthentication : Object
    {
        public object verifyer;
        public object credProvider;
        public object TargetUri;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6503CD0
        public void NotifyServerCertificate(){} // RVA: 0xA0C8560
        public void GetClientCredentials(){} // RVA: 0xA0C8630
    }

    public class LegacyTlsClient : DefaultTlsClient
    {
        public object TargetUri;
        public object verifyer;
        public object credProvider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0C86B0
        public void GetAuthentication(){} // RVA: 0xA0C8950
    }

}