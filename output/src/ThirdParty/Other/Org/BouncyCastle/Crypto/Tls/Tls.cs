// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Org.BouncyCastle.Crypto.Tls
// Classes: 5
// Methods: 9

namespace ThirdParty.Other.Org.BouncyCastle.Crypto.Tls
{
    public class AlwaysValidVerifyer : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E426850
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ICertificateVerifyer
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E07D200
    }

    public class IClientCredentialsProvider
    {
        // ── Methods ──
        public void GetClientCredentials(){} // RVA: 0x7FFD4E08A6F0
    }

    public class LegacyTlsAuthentication : Object
    {
        public Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer verifyer; // 0x10
        public Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider credProvider; // 0x18
        public System.Uri TargetUri; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53640D00
        public void NotifyServerCertificate(){} // RVA: 0x7FFD56E51B60
        public void GetClientCredentials(){} // RVA: 0x7FFD56E51C30
    }

    public class LegacyTlsClient : DefaultTlsClient
    {
        public System.Uri TargetUri; // 0x58
        public Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer verifyer; // 0x60
        public Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider credProvider; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD56E51CB0
        public void GetAuthentication(){} // RVA: 0x7FFD56E51F50
    }

}