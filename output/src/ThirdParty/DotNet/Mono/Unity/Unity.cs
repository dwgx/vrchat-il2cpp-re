// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Unity
// Classes: 8
// Methods: 59

namespace ThirdParty.DotNet.Mono.Unity
{
    public class CertHelper : Object
    {
        // ── Methods ──
        public void AddCertificatesToNativeChain(){} // RVA: 0x7FFAC8E19170
        public void AddCertificateToNativeChain(){} // RVA: 0x7FFAC8E192F0
    }

    public class Debug : Object
    {
        // ── Methods ──
        public void CheckAndThrow(){} // RVA: 0x7FFAC8E19610 | overloaded x2
    }

    public class UnityTls : Object
    {
        public unitytls_interface_struct IsSupported;

        // ── Methods ──
        public void GetUnityTlsInterface(){} // RVA: 0x7FFAC8E19720
        public void get_IsSupported(){} // RVA: 0x7FFAC8E19730
        public void get_NativeInterface(){} // RVA: 0x7FFAC8E19750
    }

    public class UnityTlsContext : MobileTlsContext
    {
        public unitytls_tlsctx* IsAuthenticated; // 0x58
        public unitytls_x509list* LocalClientCertificate; // 0x60
        public unitytls_key* RemoteCertificate; // 0x68
        public unitytls_tlsctx_read_callback readCallback; // 0x70
        public unitytls_tlsctx_write_callback writeCallback; // 0x78
        public unitytls_tlsctx_certificate_callback certificateCallback; // 0x80
        public unitytls_tlsctx_x509verify_callback verifyCallback; // 0x88
        public System.Security.Cryptography.X509Certificates.X509Certificate localClientCertificate; // 0x90
        public System.Security.Cryptography.X509Certificates.X509Certificate2 remoteCertificate; // 0x98
        public Mono.Security.Interface.MonoTlsConnectionInfo connectioninfo; // 0xA0
        public bool isAuthenticated; // 0xA8
        public bool hasContext; // 0xA9
        public bool closedGraceful; // 0xAA
        public byte[] writeBuffer; // 0xB0
        public byte[] readBuffer; // 0xB8
        public System.Runtime.InteropServices.GCHandle handle; // 0xC0
        public System.Exception lastException; // 0xC8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E1A280
        public void ExtractNativeKeyAndChainFromManagedCertificate(){} // RVA: 0x7FFAC8E1B180
        public void get_IsAuthenticated(){} // RVA: 0x7FFAC3141F10
        public void get_LocalClientCertificate(){} // RVA: 0x7FFAC32EF640
        public void get_RemoteCertificate(){} // RVA: 0x7FFAC354DFB0
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void Read(){} // RVA: 0x7FFAC8E1B470
        public void Write(){} // RVA: 0x7FFAC8E1B680
        public void Renegotiate(){} // RVA: 0x7FFAC8E1B880
        public void PendingRenegotiation(){} // RVA: 0x7FFAC2F21320
        public void Shutdown(){} // RVA: 0x7FFAC8E1B8C0
        public void Dispose(){} // RVA: 0x7FFAC8E1BA00
        public void StartHandshake(){} // RVA: 0x7FFAC8E1BCF0
        public void ProcessHandshake(){} // RVA: 0x7FFAC8E1BF30
        public void FinishHandshake(){} // RVA: 0x7FFAC8E1C250
        public void WriteCallback(){} // RVA: 0x7FFAC8E1C560 | overloaded x2
        public void ReadCallback(){} // RVA: 0x7FFAC8E1C870 | overloaded x2
        public void VerifyCallback(){} // RVA: 0x7FFAC8E1CC10 | overloaded x2
        public void CertificateCallback(){} // RVA: 0x7FFAC8E1D110 | overloaded x2
    }

    public class UnityTlsConversions : Object
    {
        // ── Methods ──
        public void GetMinProtocol(){} // RVA: 0x7FFAC8E1D420
        public void GetMaxProtocol(){} // RVA: 0x7FFAC8E1D460
        public void ConvertProtocolVersion(){} // RVA: 0x7FFAC8E1D4A0
        public void VerifyResultToAlertDescription(){} // RVA: 0x7FFAC8E1D4D0
        public void VerifyResultToPolicyErrror(){} // RVA: 0x7FFAC8E1D530
        public void VerifyResultToChainStatus(){} // RVA: 0x7FFAC8E1D560
    }

    public class UnityTlsProvider : MobileTlsProvider
    {
        public object Name;
        public object ID;
        public object SupportsSslStream;
        public object SupportsMonoExtensions;
        public object SupportsConnectionInfo;
        public object SupportsCleanShutdown;
        public object SupportedProtocols;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC8E1D5A0
        public void get_ID(){} // RVA: 0x7FFAC8E1D5E0
        public void get_SupportsSslStream(){} // RVA: 0x7FFAC3006850
        public void get_SupportsMonoExtensions(){} // RVA: 0x7FFAC3006850
        public void get_SupportsConnectionInfo(){} // RVA: 0x7FFAC3006850
        public void get_SupportsCleanShutdown(){} // RVA: 0x7FFAC3006850
        public void get_SupportedProtocols(){} // RVA: 0x7FFAC8E1D640
        public void CreateSslStream(){} // RVA: 0x7FFAC8E1D650
        public void x509verify_callback(){} // RVA: 0x7FFAC8E1D730
        public void ValidateCertificate(){} // RVA: 0x7FFAC8E1D7B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnityTlsStream : MobileAuthenticatedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E1E240
        public void CreateContext(){} // RVA: 0x7FFAC8E1E2D0
    }

    public class X509ChainImplUnityTls : X509ChainImpl
    {
        public System.Security.Cryptography.X509Certificates.X509ChainElementCollection IsValid; // 0x10
        public unitytls_x509list* NativeCertificateChain; // 0x18
        public unitytls_x509list_ref ChainElements; // 0x20
        public System.Security.Cryptography.X509Certificates.X509ChainPolicy ChainPolicy; // 0x28
        public System.Collections.Generic.List`1<System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList; // 0x30
        public bool reverseOrder; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E1E460 | overloaded x2
        public void get_IsValid(){} // RVA: 0x7FFAC8E1E5C0
        public void get_NativeCertificateChain(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ChainElements(){} // RVA: 0x7FFAC8E1E5F0
        public void AddStatus(){} // RVA: 0x7FFAC8E1EA40
        public void get_ChainPolicy(){} // RVA: 0x7FFAC2F4F130
        public void Build(){} // RVA: 0x7FFAC2F21320
        public void Reset(){} // RVA: 0x7FFAC8E1EBD0
        public void Dispose(){} // RVA: 0x7FFAC3F5BE50
    }

}