// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Unity
// Classes: 8
// Methods: 53

namespace ThirdParty.DotNet.Mono.Unity
{
    public class CertHelper : Object
    {
        // ── Methods ──
        public void AddCertificatesToNativeChain(){} // RVA: 0x7AE470F30
        public void AddCertificateToNativeChain(){} // RVA: 0x7AE4710A0
    }

    public class Debug : Object
    {
        // ── Methods ──
        public void CheckAndThrow(){} // RVA: 0x7AE4713C0
    }

    public class UnityTls : Object
    {
        // ── Methods ──
        public void GetUnityTlsInterface(){} // RVA: 0x7AE4714D0
        public void get_IsSupported(){} // RVA: 0x7AE4714E0
        public void get_NativeInterface(){} // RVA: 0x7AE471500
    }

    public class UnityTlsContext : MobileTlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE472080
        public void ExtractNativeKeyAndChainFromManagedCertificate(){} // RVA: 0x7AE472ED0
        public void get_IsAuthenticated(){} // RVA: 0x7A835F4E0
        public void get_LocalClientCertificate(){} // RVA: 0x7A8555100
        public void get_RemoteCertificate(){} // RVA: 0x7A87D9C10
        public void Flush(){} // RVA: 0x7A80D7310
        public void Read(){} // RVA: 0x7AE4731C0
        public void Write(){} // RVA: 0x7AE4733D0
        public void Renegotiate(){} // RVA: 0x7AE4735D0
        public void PendingRenegotiation(){} // RVA: 0x7A80D7320
        public void Shutdown(){} // RVA: 0x7AE473610
        public void Dispose(){} // RVA: 0x7AE473750
        public void StartHandshake(){} // RVA: 0x7AE473A40
        public void ProcessHandshake(){} // RVA: 0x7AE473C80
        public void FinishHandshake(){} // RVA: 0x7AE473F80
        public void WriteCallback(){} // RVA: 0x7AE474290
        public void ReadCallback(){} // RVA: 0x7AE4745A0
        public void VerifyCallback(){} // RVA: 0x7AE474940
        public void CertificateCallback(){} // RVA: 0x7AE474E40
    }

    public class UnityTlsConversions : Object
    {
        // ── Methods ──
        public void GetMinProtocol(){} // RVA: 0x7AE475140
        public void GetMaxProtocol(){} // RVA: 0x7AE475180
        public void ConvertProtocolVersion(){} // RVA: 0x7AE4751C0
        public void VerifyResultToAlertDescription(){} // RVA: 0x7AE4751F0
        public void VerifyResultToPolicyErrror(){} // RVA: 0x7AE475250
        public void VerifyResultToChainStatus(){} // RVA: 0x7AE475280
    }

    public class UnityTlsProvider : MobileTlsProvider
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7AE4752C0
        public void get_ID(){} // RVA: 0x7AE475300
        public void get_SupportsSslStream(){} // RVA: 0x7A81BD750
        public void get_SupportsMonoExtensions(){} // RVA: 0x7A81BD750
        public void get_SupportsConnectionInfo(){} // RVA: 0x7A81BD750
        public void get_SupportsCleanShutdown(){} // RVA: 0x7A81BD750
        public void get_SupportedProtocols(){} // RVA: 0x7AE475360
        public void CreateSslStream(){} // RVA: 0x7AE475370
        public void x509verify_callback(){} // RVA: 0x7AE475450
        public void ValidateCertificate(){} // RVA: 0x7AE4754D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UnityTlsStream : MobileAuthenticatedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE475F40
        public void CreateContext(){} // RVA: 0x7AE475FD0
    }

    public class X509ChainImplUnityTls : X509ChainImpl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE476160
        public void get_IsValid(){} // RVA: 0x7AE4762C0
        public void get_NativeCertificateChain(){} // RVA: 0x7A81052C0
        public void get_ChainElements(){} // RVA: 0x7AE4762F0
        public void AddStatus(){} // RVA: 0x7AE476740
        public void get_ChainPolicy(){} // RVA: 0x7A8105330
        public void Build(){} // RVA: 0x7A80D7320
        public void Reset(){} // RVA: 0x7AE4768D0
        public void Dispose(){} // RVA: 0x7AB5DC320
    }

}