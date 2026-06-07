// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Unity
// Classes: 8
// Methods: 59

namespace ThirdParty.DotNet.Mono.Unity
{
    public class CertHelper
    {
        // ── Methods ──
        public void AddCertificatesToNativeChain(){} // RVA: 0x66826B0
        public void AddCertificateToNativeChain(){} // RVA: 0x6682830
    }

    public class Debug
    {
        // ── Methods ──
        public void CheckAndThrow(){} // RVA: 0x6682B50 | overloaded x2
    }

    public class UnityTls
    {
        // ── Methods ──
        public void GetUnityTlsInterface(){} // RVA: 0x6682C60
        public void get_IsSupported(){} // RVA: 0x6682C70
        public void get_NativeInterface(){} // RVA: 0x6682C90
    }

    public class UnityTlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66837C0
        public void ExtractNativeKeyAndChainFromManagedCertificate(){} // RVA: 0x66846C0
        public void get_IsAuthenticated(){} // RVA: 0x5A6180
        public void get_LocalClientCertificate(){} // RVA: 0x796DE0
        public void get_RemoteCertificate(){} // RVA: 0xA1C8C0
        public void Flush(){} // RVA: 0x2DD310
        public void Read(){} // RVA: 0x66849B0
        public void Write(){} // RVA: 0x6684BC0
        public void Renegotiate(){} // RVA: 0x6684DC0
        public void PendingRenegotiation(){} // RVA: 0x2DD320
        public void Shutdown(){} // RVA: 0x6684E00
        public void Dispose(){} // RVA: 0x6684F40
        public void StartHandshake(){} // RVA: 0x6685230
        public void ProcessHandshake(){} // RVA: 0x6685470
        public void FinishHandshake(){} // RVA: 0x6685790
        public void WriteCallback(){} // RVA: 0x6685AA0 | overloaded x2
        public void ReadCallback(){} // RVA: 0x6685DB0 | overloaded x2
        public void VerifyCallback(){} // RVA: 0x6686150 | overloaded x2
        public void CertificateCallback(){} // RVA: 0x6686650 | overloaded x2
    }

    public class UnityTlsConversions
    {
        // ── Methods ──
        public void GetMinProtocol(){} // RVA: 0x6686960
        public void GetMaxProtocol(){} // RVA: 0x66869A0
        public void ConvertProtocolVersion(){} // RVA: 0x66869E0
        public void VerifyResultToAlertDescription(){} // RVA: 0x6686A10
        public void VerifyResultToPolicyErrror(){} // RVA: 0x6686A70
        public void VerifyResultToChainStatus(){} // RVA: 0x6686AA0
    }

    public class UnityTlsProvider
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x6686AE0
        public void get_ID(){} // RVA: 0x6686B20
        public void get_SupportsSslStream(){} // RVA: 0x3C2850
        public void get_SupportsMonoExtensions(){} // RVA: 0x3C2850
        public void get_SupportsConnectionInfo(){} // RVA: 0x3C2850
        public void get_SupportsCleanShutdown(){} // RVA: 0x3C2850
        public void get_SupportedProtocols(){} // RVA: 0x6686B80
        public void CreateSslStream(){} // RVA: 0x6686B90
        public void x509verify_callback(){} // RVA: 0x6686C70
        public void ValidateCertificate(){} // RVA: 0x6686CF0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UnityTlsStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6687780
        public void CreateContext(){} // RVA: 0x6687810
    }

    public class X509ChainImplUnityTls
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66879A0 | overloaded x2
        public void get_IsValid(){} // RVA: 0x6687B00
        public void get_NativeCertificateChain(){} // RVA: 0x30B0C0
        public void get_ChainElements(){} // RVA: 0x6687B30
        public void AddStatus(){} // RVA: 0x6687F80
        public void get_ChainPolicy(){} // RVA: 0x30B130
        public void Build(){} // RVA: 0x2DD320
        public void Reset(){} // RVA: 0x6688110
        public void Dispose(){} // RVA: 0x37EF790
    }

}