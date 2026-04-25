// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 4
// Methods: 33

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class PrfAlgorithm : Object
    {
        public int tls_prf_legacy;
        public int tls_prf_sha256;
        public int tls_prf_sha384;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ProtocolVersion : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion FullVersion;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion MajorVersion; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion MinorVersion; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion IsDtls; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion IsSsl; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion IsTls; // 0x28
        public int version; // 0x10
        public string name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB38840
        public void get_FullVersion(){} // RVA: 0x7FFAC2F6E5C0
        public void get_MajorVersion(){} // RVA: 0x7FFACBB388A0
        public void get_MinorVersion(){} // RVA: 0x7FFAC2FEB5E0
        public void get_IsDtls(){} // RVA: 0x7FFACBB388B0
        public void get_IsSsl(){} // RVA: 0x7FFACBB388D0
        public void get_IsTls(){} // RVA: 0x7FFACBB38930
        public void GetEquivalentTLSVersion(){} // RVA: 0x7FFACBB38950
        public void IsEqualOrEarlierVersionOf(){} // RVA: 0x7FFACBB38A10
        public void IsLaterVersionOf(){} // RVA: 0x7FFACBB38A70
        public void Equals(){} // RVA: 0x7FFACBB38B70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2F6E5C0
        public void Get(){} // RVA: 0x7FFACBB38B90
        public void ToString(){} // RVA: 0x7FFAC2F247C0
        public void GetUnknownVersion(){} // RVA: 0x7FFACBB38E50
        public void .cctor(){} // RVA: 0x7FFACBB39010
    }

    public class PskTlsClient : AbstractTlsClient
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsDHVerifier mDHVerifier; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsPskIdentity mPskIdentity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB398D0 | overloaded x3
        public void GetCipherSuites(){} // RVA: 0x7FFACBB399D0
        public void GetKeyExchange(){} // RVA: 0x7FFACBB39A40
        public void GetAuthentication(){} // RVA: 0x7FFACBB39B00
        public void CreatePskKeyExchange(){} // RVA: 0x7FFACBB39B50
    }

    public class PskTlsServer : AbstractTlsServer
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager mPskIdentityManager; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB39D20 | overloaded x2
        public void GetRsaEncryptionCredentials(){} // RVA: 0x7FFACBB39DD0
        public void GetDHParameters(){} // RVA: 0x7FFACBB39E20
        public void GetCipherSuites(){} // RVA: 0x7FFACBB39E80
        public void GetCredentials(){} // RVA: 0x7FFACBB39EF0
        public void GetKeyExchange(){} // RVA: 0x7FFACBB39FC0
        public void CreatePskKeyExchange(){} // RVA: 0x7FFACBB3A080
    }

}