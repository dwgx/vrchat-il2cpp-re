// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Unity
// Classes: 8
// Methods: 59

namespace ThirdParty.DotNet.Mono.Unity
{
    public class CertHelper : Object
    {
        // ── Methods ──
        public void AddCertificatesToNativeChain(){} // RVA: 0x7FFE871C15A0
        public void AddCertificateToNativeChain(){} // RVA: 0x7FFE871C1720
    }

    public class Debug : Object
    {
        // ── Methods ──
        public void CheckAndThrow(){} // RVA: 0x7FFE871C1A40 | overloaded x2
    }

    public class UnityTls : Object
    {
        public unitytls_interface_struct marshalledInterface;
        public object field_1; // 0x8

        // ── Methods ──
        public void GetUnityTlsInterface(){} // RVA: 0x7FFE871C1B50
        public void get_IsSupported(){} // RVA: 0x7FFE871C1B60
        public void get_NativeInterface(){} // RVA: 0x7FFE871C1B80
    }

    public class UnityTlsContext : MobileTlsContext
    {
        public unitytls_tlsctx* tlsContext; // 0x58
        public unitytls_x509list* requestedClientCertChain; // 0x60
        public unitytls_key* requestedClientKey; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871C26B0
        public void ExtractNativeKeyAndChainFromManagedCertificate(){} // RVA: 0x7FFE871C35B0
        public void get_IsAuthenticated(){} // RVA: 0x7FFE813A1D80
        public void get_LocalClientCertificate(){} // RVA: 0x7FFE8154EB60
        public void get_RemoteCertificate(){} // RVA: 0x7FFE817AE360
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void Read(){} // RVA: 0x7FFE871C38A0
        public void Write(){} // RVA: 0x7FFE871C3AB0
        public void Renegotiate(){} // RVA: 0x7FFE871C3CB0
        public void PendingRenegotiation(){} // RVA: 0x7FFE810FB320
        public void Shutdown(){} // RVA: 0x7FFE871C3CF0
        public void Dispose(){} // RVA: 0x7FFE871C3E30
        public void StartHandshake(){} // RVA: 0x7FFE871C4120
        public void ProcessHandshake(){} // RVA: 0x7FFE871C4360
        public void FinishHandshake(){} // RVA: 0x7FFE871C4680
        public void WriteCallback(){} // RVA: 0x7FFE871C4990 | overloaded x2
        public void ReadCallback(){} // RVA: 0x7FFE871C4CA0 | overloaded x2
        public void VerifyCallback(){} // RVA: 0x7FFE871C5040 | overloaded x2
        public void CertificateCallback(){} // RVA: 0x7FFE871C5540 | overloaded x2
    }

    public class UnityTlsConversions : Object
    {
        // ── Methods ──
        public void GetMinProtocol(){} // RVA: 0x7FFE871C5850
        public void GetMaxProtocol(){} // RVA: 0x7FFE871C5890
        public void ConvertProtocolVersion(){} // RVA: 0x7FFE871C58D0
        public void VerifyResultToAlertDescription(){} // RVA: 0x7FFE871C5900
        public void VerifyResultToPolicyErrror(){} // RVA: 0x7FFE871C5960
        public void VerifyResultToChainStatus(){} // RVA: 0x7FFE871C5990
    }

    public class UnityTlsProvider : MobileTlsProvider
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE871C59D0
        public void get_ID(){} // RVA: 0x7FFE871C5A10
        public void get_SupportsSslStream(){} // RVA: 0x7FFE811E0850
        public void get_SupportsMonoExtensions(){} // RVA: 0x7FFE811E0850
        public void get_SupportsConnectionInfo(){} // RVA: 0x7FFE811E0850
        public void get_SupportsCleanShutdown(){} // RVA: 0x7FFE811E0850
        public void get_SupportedProtocols(){} // RVA: 0x7FFE871C5A70
        public void CreateSslStream(){} // RVA: 0x7FFE871C5A80
        public void x509verify_callback(){} // RVA: 0x7FFE871C5B60
        public void ValidateCertificate(){} // RVA: 0x7FFE871C5BE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnityTlsStream : MobileAuthenticatedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871C6670
        public void CreateContext(){} // RVA: 0x7FFE871C6700
    }

    public class X509ChainImplUnityTls : X509ChainImpl
    {
        public System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements; // 0x10
        public unitytls_x509list* ownedList; // 0x18
        public unitytls_x509list_ref nativeCertificateChain; // 0x20
        public System.Security.Cryptography.X509Certificates.X509ChainPolicy policy; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871C6890 | overloaded x2
        public void get_IsValid(){} // RVA: 0x7FFE871C69F0
        public void get_NativeCertificateChain(){} // RVA: 0x7FFE811290C0
        public void get_ChainElements(){} // RVA: 0x7FFE871C6A20
        public void AddStatus(){} // RVA: 0x7FFE871C6E70
        public void get_ChainPolicy(){} // RVA: 0x7FFE81129130
        public void Build(){} // RVA: 0x7FFE810FB320
        public void Reset(){} // RVA: 0x7FFE871C7000
        public void Dispose(){} // RVA: 0x7FFE844800F0
    }

}