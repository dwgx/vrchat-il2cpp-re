// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Unity
// Classes: 8
// Methods: 53

namespace ThirdParty.DotNet.Mono.Unity
{
    public class CertHelper : Object
    {
        // ── Methods ──
        public void AddCertificatesToNativeChain(){} // RVA: 0x70ED040
        public void AddCertificateToNativeChain(){} // RVA: 0x70ED1B0
    }

    public class Debug : Object
    {
        // ── Methods ──
        public void CheckAndThrow(){} // RVA: 0x70ED4D0
    }

    public class UnityTls : Object
    {
        public object marshalledInterface;

        // ── Methods ──
        public void GetUnityTlsInterface(){} // RVA: 0x70ED5E0
        public void get_IsSupported(){} // RVA: 0x70ED5F0
        public void get_NativeInterface(){} // RVA: 0x70ED610
    }

    public class UnityTlsContext : MobileTlsContext
    {
        public object tlsContext;
        public object requestedClientCertChain;
        public object requestedClientKey;
        public object readCallback;
        public object writeCallback;
        public object certificateCallback;
        public object verifyCallback;
        public object localClientCertificate;
        public object remoteCertificate;
        public object connectioninfo;
        public object isAuthenticated;
        public object hasContext;
        public object closedGraceful;
        public object writeBuffer;
        public object readBuffer;
        public object handle;
        public object lastException;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70EE160
        public void ExtractNativeKeyAndChainFromManagedCertificate(){} // RVA: 0x70EEFB0
        public void get_IsAuthenticated(){} // RVA: 0xE3F3E0
        public void get_LocalClientCertificate(){} // RVA: 0x1069350
        public void get_RemoteCertificate(){} // RVA: 0x106A7D0
        public void Flush(){} // RVA: 0xB43310
        public void Read(){} // RVA: 0x70EF2A0
        public void Write(){} // RVA: 0x70EF4B0
        public void Renegotiate(){} // RVA: 0x70EF6B0
        public void PendingRenegotiation(){} // RVA: 0xB43320
        public void Shutdown(){} // RVA: 0x70EF6F0
        public void Dispose(){} // RVA: 0x70EF830
        public void StartHandshake(){} // RVA: 0x70EFB20
        public void ProcessHandshake(){} // RVA: 0x70EFD60
        public void FinishHandshake(){} // RVA: 0x70F0060
        public void WriteCallback(){} // RVA: 0x70F0380
        public void ReadCallback(){} // RVA: 0x70F06A0
        public void VerifyCallback(){} // RVA: 0x70F0A40
        public void CertificateCallback(){} // RVA: 0x70F0F40
    }

    public class UnityTlsConversions : Object
    {
        // ── Methods ──
        public void GetMinProtocol(){} // RVA: 0x70F1240
        public void GetMaxProtocol(){} // RVA: 0x70F1280
        public void ConvertProtocolVersion(){} // RVA: 0x70F12C0
        public void VerifyResultToAlertDescription(){} // RVA: 0x70F12F0
        public void VerifyResultToPolicyErrror(){} // RVA: 0x70F1350
        public void VerifyResultToChainStatus(){} // RVA: 0x70F1380
    }

    public class UnityTlsProvider : MobileTlsProvider
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x70F13C0
        public void get_ID(){} // RVA: 0x70F1400
        public void get_SupportsSslStream(){} // RVA: 0xC2E4C0
        public void get_SupportsMonoExtensions(){} // RVA: 0xC2E4C0
        public void get_SupportsConnectionInfo(){} // RVA: 0xC2E4C0
        public void get_SupportsCleanShutdown(){} // RVA: 0xC2E4C0
        public void get_SupportedProtocols(){} // RVA: 0x70F1460
        public void CreateSslStream(){} // RVA: 0x70F1470
        public void x509verify_callback(){} // RVA: 0x70F1550
        public void ValidateCertificate(){} // RVA: 0x70F15D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnityTlsStream : MobileAuthenticatedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70F2040
        public void CreateContext(){} // RVA: 0x70F20D0
    }

    public class X509ChainImplUnityTls : X509ChainImpl
    {
        public object elements;
        public object ownedList;
        public object nativeCertificateChain;
        public object policy;
        public object chainStatusList;
        public object reverseOrder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70F2260
        public void get_IsValid(){} // RVA: 0x70F23C0
        public void get_NativeCertificateChain(){} // RVA: 0xB700F0
        public void get_ChainElements(){} // RVA: 0x70F23F0
        public void AddStatus(){} // RVA: 0x70F2840
        public void get_ChainPolicy(){} // RVA: 0xB70160
        public void Build(){} // RVA: 0xB43320
        public void Reset(){} // RVA: 0x70F29D0
        public void Dispose(){} // RVA: 0x11F4110
    }

}