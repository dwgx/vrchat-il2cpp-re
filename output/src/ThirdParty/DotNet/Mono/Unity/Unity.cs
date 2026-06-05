// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Unity
// Classes: 8
// Methods: 59

namespace ThirdParty.DotNet.Mono.Unity
{
    public class CertHelper
    {
        // ── Methods ──
        public void AddCertificatesToNativeChain(){} // RVA: 0x7FFAF91326B0
        public void AddCertificateToNativeChain(){} // RVA: 0x7FFAF9132830
    }

    public class Debug
    {
        // ── Methods ──
        public void CheckAndThrow(){} // RVA: 0x7FFAF9132B50 | overloaded x2
    }

    public class UnityTls
    {
        // ── Methods ──
        public void GetUnityTlsInterface(){} // RVA: 0x7FFAF9132C60
        public void get_IsSupported(){} // RVA: 0x7FFAF9132C70
        public void get_NativeInterface(){} // RVA: 0x7FFAF9132C90
    }

    public class UnityTlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF91337C0
        public void ExtractNativeKeyAndChainFromManagedCertificate(){} // RVA: 0x7FFAF91346C0
        public void get_IsAuthenticated(){} // RVA: 0x7FFAF3056180
        public void get_LocalClientCertificate(){} // RVA: 0x7FFAF3246DE0
        public void get_RemoteCertificate(){} // RVA: 0x7FFAF34CC8C0
        public void Flush(){} // RVA: 0x7FFAF2D8D310
        public void Read(){} // RVA: 0x7FFAF91349B0
        public void Write(){} // RVA: 0x7FFAF9134BC0
        public void Renegotiate(){} // RVA: 0x7FFAF9134DC0
        public void PendingRenegotiation(){} // RVA: 0x7FFAF2D8D320
        public void Shutdown(){} // RVA: 0x7FFAF9134E00
        public void Dispose(){} // RVA: 0x7FFAF9134F40
        public void StartHandshake(){} // RVA: 0x7FFAF9135230
        public void ProcessHandshake(){} // RVA: 0x7FFAF9135470
        public void FinishHandshake(){} // RVA: 0x7FFAF9135790
        public void WriteCallback(){} // RVA: 0x7FFAF9135AA0 | overloaded x2
        public void ReadCallback(){} // RVA: 0x7FFAF9135DB0 | overloaded x2
        public void VerifyCallback(){} // RVA: 0x7FFAF9136150 | overloaded x2
        public void CertificateCallback(){} // RVA: 0x7FFAF9136650 | overloaded x2
    }

    public class UnityTlsConversions
    {
        // ── Methods ──
        public void GetMinProtocol(){} // RVA: 0x7FFAF9136960
        public void GetMaxProtocol(){} // RVA: 0x7FFAF91369A0
        public void ConvertProtocolVersion(){} // RVA: 0x7FFAF91369E0
        public void VerifyResultToAlertDescription(){} // RVA: 0x7FFAF9136A10
        public void VerifyResultToPolicyErrror(){} // RVA: 0x7FFAF9136A70
        public void VerifyResultToChainStatus(){} // RVA: 0x7FFAF9136AA0
    }

    public class UnityTlsProvider
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF9136AE0
        public void get_ID(){} // RVA: 0x7FFAF9136B20
        public void get_SupportsSslStream(){} // RVA: 0x7FFAF2E72850
        public void get_SupportsMonoExtensions(){} // RVA: 0x7FFAF2E72850
        public void get_SupportsConnectionInfo(){} // RVA: 0x7FFAF2E72850
        public void get_SupportsCleanShutdown(){} // RVA: 0x7FFAF2E72850
        public void get_SupportedProtocols(){} // RVA: 0x7FFAF9136B80
        public void CreateSslStream(){} // RVA: 0x7FFAF9136B90
        public void x509verify_callback(){} // RVA: 0x7FFAF9136C70
        public void ValidateCertificate(){} // RVA: 0x7FFAF9136CF0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UnityTlsStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9137780
        public void CreateContext(){} // RVA: 0x7FFAF9137810
    }

    public class X509ChainImplUnityTls
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF91379A0 | overloaded x2
        public void get_IsValid(){} // RVA: 0x7FFAF9137B00
        public void get_NativeCertificateChain(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ChainElements(){} // RVA: 0x7FFAF9137B30
        public void AddStatus(){} // RVA: 0x7FFAF9137F80
        public void get_ChainPolicy(){} // RVA: 0x7FFAF2DBB130
        public void Build(){} // RVA: 0x7FFAF2D8D320
        public void Reset(){} // RVA: 0x7FFAF9138110
        public void Dispose(){} // RVA: 0x7FFAF629F790
    }

}