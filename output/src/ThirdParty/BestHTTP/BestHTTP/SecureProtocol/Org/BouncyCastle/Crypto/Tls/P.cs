// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 4
// Methods: 33

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class PrfAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ProtocolVersion
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x952FA90
        public void get_FullVersion(){} // RVA: 0x32A5C0
        public void get_MajorVersion(){} // RVA: 0x952FAF0
        public void get_MinorVersion(){} // RVA: 0x3A75E0
        public void get_IsDtls(){} // RVA: 0x952FB00
        public void get_IsSsl(){} // RVA: 0x952FB20
        public void get_IsTls(){} // RVA: 0x952FB80
        public void GetEquivalentTLSVersion(){} // RVA: 0x952FBA0
        public void IsEqualOrEarlierVersionOf(){} // RVA: 0x952FC60
        public void IsLaterVersionOf(){} // RVA: 0x952FCC0
        public void Equals(){} // RVA: 0x952FDC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x32A5C0
        public void Get(){} // RVA: 0x952FDE0
        public void ToString(){} // RVA: 0x2E07C0
        public void GetUnknownVersion(){} // RVA: 0x95300A0
        public void .cctor(){} // RVA: 0x9530260
    }

    public class PskTlsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9530B20 | overloaded x3
        public void GetCipherSuites(){} // RVA: 0x9530C20
        public void GetKeyExchange(){} // RVA: 0x9530C90
        public void GetAuthentication(){} // RVA: 0x9530D50
        public void CreatePskKeyExchange(){} // RVA: 0x9530DA0
    }

    public class PskTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9530F70 | overloaded x2
        public void GetRsaEncryptionCredentials(){} // RVA: 0x9531020
        public void GetDHParameters(){} // RVA: 0x9531070
        public void GetCipherSuites(){} // RVA: 0x95310D0
        public void GetCredentials(){} // RVA: 0x9531140
        public void GetKeyExchange(){} // RVA: 0x9531210
        public void CreatePskKeyExchange(){} // RVA: 0x95312D0
    }

}