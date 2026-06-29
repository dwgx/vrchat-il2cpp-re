// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 4
// Methods: 29

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class PrfAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ProtocolVersion : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1365DC0
        public void get_FullVersion(){} // RVA: 0x7A8124910
        public void get_MajorVersion(){} // RVA: 0x7B1365E20
        public void get_MinorVersion(){} // RVA: 0x7A81A2200
        public void get_IsDtls(){} // RVA: 0x7B1365E30
        public void get_IsSsl(){} // RVA: 0x7B1365E50
        public void get_IsTls(){} // RVA: 0x7B1365EB0
        public void GetEquivalentTLSVersion(){} // RVA: 0x7B1365ED0
        public void IsEqualOrEarlierVersionOf(){} // RVA: 0x7B1365F90
        public void IsLaterVersionOf(){} // RVA: 0x7B1365FF0
        public void Equals(){} // RVA: 0x7B13660F0
        public void GetHashCode(){} // RVA: 0x7A8124910
        public void Get(){} // RVA: 0x7B1366110
        public void ToString(){} // RVA: 0x7A80DA7B0
        public void GetUnknownVersion(){} // RVA: 0x7B13663D0
        public void .cctor(){} // RVA: 0x7B1366590
    }

    public class PskTlsClient : AbstractTlsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1366E50
        public void GetCipherSuites(){} // RVA: 0x7B1366F50
        public void GetKeyExchange(){} // RVA: 0x7B1366FC0
        public void GetAuthentication(){} // RVA: 0x7B1367080
        public void CreatePskKeyExchange(){} // RVA: 0x7B13670D0
    }

    public class PskTlsServer : AbstractTlsServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13672A0
        public void GetRsaEncryptionCredentials(){} // RVA: 0x7B1367350
        public void GetDHParameters(){} // RVA: 0x7B13673A0
        public void GetCipherSuites(){} // RVA: 0x7B1367400
        public void GetCredentials(){} // RVA: 0x7B1367470
        public void GetKeyExchange(){} // RVA: 0x7B1367540
        public void CreatePskKeyExchange(){} // RVA: 0x7B1367600
    }

}