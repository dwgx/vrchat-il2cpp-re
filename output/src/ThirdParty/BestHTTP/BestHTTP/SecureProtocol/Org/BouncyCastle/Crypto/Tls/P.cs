// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 4
// Methods: 33

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class PrfAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ProtocolVersion : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion SSLv3;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion TLSv10; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion TLSv11; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion TLSv12; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion DTLSv10; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion DTLSv12; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F91E60
        public void get_FullVersion(){} // RVA: 0x7FFE811485C0
        public void get_MajorVersion(){} // RVA: 0x7FFE89F91EC0
        public void get_MinorVersion(){} // RVA: 0x7FFE811C55E0
        public void get_IsDtls(){} // RVA: 0x7FFE89F91ED0
        public void get_IsSsl(){} // RVA: 0x7FFE89F91EF0
        public void get_IsTls(){} // RVA: 0x7FFE89F91F50
        public void GetEquivalentTLSVersion(){} // RVA: 0x7FFE89F91F70
        public void IsEqualOrEarlierVersionOf(){} // RVA: 0x7FFE89F92030
        public void IsLaterVersionOf(){} // RVA: 0x7FFE89F92090
        public void Equals(){} // RVA: 0x7FFE89F92190 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE811485C0
        public void Get(){} // RVA: 0x7FFE89F921B0
        public void ToString(){} // RVA: 0x7FFE810FE7C0
        public void GetUnknownVersion(){} // RVA: 0x7FFE89F92470
        public void .cctor(){} // RVA: 0x7FFE89F92630
    }

    public class PskTlsClient : AbstractTlsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F92EF0 | overloaded x3
        public void GetCipherSuites(){} // RVA: 0x7FFE89F92FF0
        public void GetKeyExchange(){} // RVA: 0x7FFE89F93060
        public void GetAuthentication(){} // RVA: 0x7FFE89F93120
        public void CreatePskKeyExchange(){} // RVA: 0x7FFE89F93170
    }

    public class PskTlsServer : AbstractTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F93340 | overloaded x2
        public void GetRsaEncryptionCredentials(){} // RVA: 0x7FFE89F933F0
        public void GetDHParameters(){} // RVA: 0x7FFE89F93440
        public void GetCipherSuites(){} // RVA: 0x7FFE89F934A0
        public void GetCredentials(){} // RVA: 0x7FFE89F93510
        public void GetKeyExchange(){} // RVA: 0x7FFE89F935E0
        public void CreatePskKeyExchange(){} // RVA: 0x7FFE89F936A0
    }

}