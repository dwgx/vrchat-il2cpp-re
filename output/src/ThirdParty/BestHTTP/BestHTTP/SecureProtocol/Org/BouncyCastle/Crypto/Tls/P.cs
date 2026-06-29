// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 4
// Methods: 29

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class PrfAlgorithm : Object
    {
        public object tls_prf_legacy;
        public object tls_prf_sha256;
        public object tls_prf_sha384;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ProtocolVersion : Object
    {
        public object SSLv3;
        public object TLSv10;
        public object TLSv11;
        public object TLSv12;
        public object DTLSv10;
        public object DTLSv12;
        public object version;
        public object name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D16B0
        public void get_FullVersion(){} // RVA: 0xB8F8F0
        public void get_MajorVersion(){} // RVA: 0xA1D1710
        public void get_MinorVersion(){} // RVA: 0xC120A0
        public void get_IsDtls(){} // RVA: 0xA1D1720
        public void get_IsSsl(){} // RVA: 0xA1D1740
        public void get_IsTls(){} // RVA: 0xA1D17A0
        public void GetEquivalentTLSVersion(){} // RVA: 0xA1D17C0
        public void IsEqualOrEarlierVersionOf(){} // RVA: 0xA1D1880
        public void IsLaterVersionOf(){} // RVA: 0xA1D18E0
        public void Equals(){} // RVA: 0xA1D19E0
        public void GetHashCode(){} // RVA: 0xB8F8F0
        public void Get(){} // RVA: 0xA1D1A00
        public void ToString(){} // RVA: 0xB465B0
        public void GetUnknownVersion(){} // RVA: 0xA1D1CC0
        public void .cctor(){} // RVA: 0xA1D1E80
    }

    public class PskTlsClient : AbstractTlsClient
    {
        public object mDHVerifier;
        public object mPskIdentity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D2740
        public void GetCipherSuites(){} // RVA: 0xA1D2840
        public void GetKeyExchange(){} // RVA: 0xA1D28B0
        public void GetAuthentication(){} // RVA: 0xA1D2970
        public void CreatePskKeyExchange(){} // RVA: 0xA1D29C0
    }

    public class PskTlsServer : AbstractTlsServer
    {
        public object mPskIdentityManager;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D2B90
        public void GetRsaEncryptionCredentials(){} // RVA: 0xA1D2C40
        public void GetDHParameters(){} // RVA: 0xA1D2C90
        public void GetCipherSuites(){} // RVA: 0xA1D2CF0
        public void GetCredentials(){} // RVA: 0xA1D2D60
        public void GetKeyExchange(){} // RVA: 0xA1D2E30
        public void CreatePskKeyExchange(){} // RVA: 0xA1D2EF0
    }

}