// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 2
// Methods: 37

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class AbstractTlsClient : AbstractTlsPeer
    {
        public 0x663F2268 HostNames; // 0x10
        public 0x663F2318 ClientHelloRecordLayerVersion; // 0x18
        public System.Collections.IList ClientVersion; // 0x20
        public int[] IsFallback; // 0x28
        public byte[] MinimumVersion; // 0x30
        public byte[] mServerECPointFormats; // 0x38
        public int mSelectedCipherSuite; // 0x40
        public short mSelectedCompressionMethod; // 0x44
        public System.Collections.Generic.List`1<string> <HostNames>k__BackingField; // 0x48

        // ── Methods ──
        public void get_HostNames(){} // RVA: 0x7FFD4E3BC730
        public void set_HostNames(){} // RVA: 0x7FFD4E3BC740
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
        public void AllowUnexpectedServerExtension(){} // RVA: 0x7FFD56F3A3B0
        public void CheckForUnexpectedServerExtension(){} // RVA: 0x7FFD56F3A450
        public void Init(){} // RVA: 0x7FFD4E3A7E80
        public void GetSessionToResume(){} // RVA: 0x7FFD4E919180
        public void get_ClientHelloRecordLayerVersion(){} // RVA: 0x7FFD56F3A520
        public void get_ClientVersion(){} // RVA: 0x7FFD56F3A540
        public void get_IsFallback(){} // RVA: 0x7FFD4E341320
        public void GetClientExtensions(){} // RVA: 0x7FFD56F3A5A0
        public void get_MinimumVersion(){} // RVA: 0x7FFD56F3AD90
        public void NotifyServerVersion(){} // RVA: 0x7FFD56F3ADF0
        public void GetCipherSuites(){} // RVA: 0x7FFD4E078E90
        public void GetCompressionMethods(){} // RVA: 0x7FFD56F3AEA0
        public void NotifySessionID(){} // RVA: 0x7FFD4E341310
        public void NotifySelectedCipherSuite(){} // RVA: 0x7FFD4E3E2090
        public void NotifySelectedCompressionMethod(){} // RVA: 0x7FFD56F3AEE0
        public void ProcessServerExtensions(){} // RVA: 0x7FFD56F3AEF0
        public void ProcessServerSupplementalData(){} // RVA: 0x7FFD56F3B060
        public void GetKeyExchange(){} // RVA: 0x7FFD4E078E90
        public void GetAuthentication(){} // RVA: 0x7FFD4E078E90
        public void GetClientSupplementalData(){} // RVA: 0x7FFD4E919180
        public void GetCompression(){} // RVA: 0x7FFD56F3B0C0
        public void GetCipher(){} // RVA: 0x7FFD56F3B2D0
        public void NotifyNewSessionTicket(){} // RVA: 0x7FFD4E341310
    }

    public class DefaultTlsClient : AbstractTlsClient
    {
        public i mDHVerifier; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD56F46390 | overloaded x3
        public void GetCipherSuites(){} // RVA: 0x7FFD56F46440
        public void GetKeyExchange(){} // RVA: 0x7FFD56F464B0
        public void CreateDHKeyExchange(){} // RVA: 0x7FFD56F46660
        public void CreateDheKeyExchange(){} // RVA: 0x7FFD56F466F0
        public void CreateECDHKeyExchange(){} // RVA: 0x7FFD56F46780
        public void CreateECDheKeyExchange(){} // RVA: 0x7FFD56F46820
        public void CreateRsaKeyExchange(){} // RVA: 0x7FFD56F468C0
    }

}