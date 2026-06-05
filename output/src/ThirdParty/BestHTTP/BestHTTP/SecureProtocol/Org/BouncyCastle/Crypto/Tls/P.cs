// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 4
// Methods: 33

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class PrfAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ProtocolVersion
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFDFA90
        public void get_FullVersion(){} // RVA: 0x7FFAF2DDA5C0
        public void get_MajorVersion(){} // RVA: 0x7FFAFBFDFAF0
        public void get_MinorVersion(){} // RVA: 0x7FFAF2E575E0
        public void get_IsDtls(){} // RVA: 0x7FFAFBFDFB00
        public void get_IsSsl(){} // RVA: 0x7FFAFBFDFB20
        public void get_IsTls(){} // RVA: 0x7FFAFBFDFB80
        public void GetEquivalentTLSVersion(){} // RVA: 0x7FFAFBFDFBA0
        public void IsEqualOrEarlierVersionOf(){} // RVA: 0x7FFAFBFDFC60
        public void IsLaterVersionOf(){} // RVA: 0x7FFAFBFDFCC0
        public void Equals(){} // RVA: 0x7FFAFBFDFDC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF2DDA5C0
        public void Get(){} // RVA: 0x7FFAFBFDFDE0
        public void ToString(){} // RVA: 0x7FFAF2D907C0
        public void GetUnknownVersion(){} // RVA: 0x7FFAFBFE00A0
        public void .cctor(){} // RVA: 0x7FFAFBFE0260
    }

    public class PskTlsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE0B20 | overloaded x3
        public void GetCipherSuites(){} // RVA: 0x7FFAFBFE0C20
        public void GetKeyExchange(){} // RVA: 0x7FFAFBFE0C90
        public void GetAuthentication(){} // RVA: 0x7FFAFBFE0D50
        public void CreatePskKeyExchange(){} // RVA: 0x7FFAFBFE0DA0
    }

    public class PskTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFE0F70 | overloaded x2
        public void GetRsaEncryptionCredentials(){} // RVA: 0x7FFAFBFE1020
        public void GetDHParameters(){} // RVA: 0x7FFAFBFE1070
        public void GetCipherSuites(){} // RVA: 0x7FFAFBFE10D0
        public void GetCredentials(){} // RVA: 0x7FFAFBFE1140
        public void GetKeyExchange(){} // RVA: 0x7FFAFBFE1210
        public void CreatePskKeyExchange(){} // RVA: 0x7FFAFBFE12D0
    }

}