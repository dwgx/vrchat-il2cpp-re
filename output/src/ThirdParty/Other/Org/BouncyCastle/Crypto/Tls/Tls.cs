// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Org.BouncyCastle.Crypto.Tls
// Classes: 5
// Methods: 9

namespace ThirdParty.Other.Org.BouncyCastle.Crypto.Tls
{
    public class AlwaysValidVerifyer : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ICertificateVerifyer
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A7E01A40
    }

    public class IClientCredentialsProvider
    {
        // ── Methods ──
        public void GetClientCredentials(){} // RVA: 0x7A7E00BD0
    }

    public class LegacyTlsAuthentication : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD876680
        public void NotifyServerCertificate(){} // RVA: 0x7B125C870
        public void GetClientCredentials(){} // RVA: 0x7B125C940
    }

    public class LegacyTlsClient : DefaultTlsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B125C9C0
        public void GetAuthentication(){} // RVA: 0x7B125CC60
    }

}