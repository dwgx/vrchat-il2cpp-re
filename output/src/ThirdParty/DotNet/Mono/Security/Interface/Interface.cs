// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Interface
// Classes: 10
// Methods: 64

namespace ThirdParty.DotNet.Mono.Security.Interface
{
    public class Alert : Object
    {
        public 0x6667E3E4 level; // 0x10
        public 0x6667E43C description; // 0x11

        // ── Methods ──
        public void get_Level(){} // RVA: 0x7FFE811C55E0
        public void get_Description(){} // RVA: 0x7FFE81346E30
        public void .ctor(){} // RVA: 0x7FFE8671A070
        public void inferAlertLevel(){} // RVA: 0x7FFE8671A0F0
        public void ToString(){} // RVA: 0x7FFE8671A170
    }

    public class ICertificateValidator
    {
    }

    public class MonoLocalCertificateSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8671A430
        public void Invoke(){} // RVA: 0x7FFE81998A70
    }

    public class MonoRemoteCertificateValidationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8671A350
        public void Invoke(){} // RVA: 0x7FFE81998A70
    }

    public class MonoTlsConnectionInfo : Object
    {
        public 0x6667E59C _cipherSuiteCode; // 0x10
        public 0x6667E90C _protocolVersion; // 0x14
        public string _peerDomainName; // 0x18

        // ── Methods ──
        public void get_CipherSuiteCode(){} // RVA: 0x7FFE8299FB40
        public void set_CipherSuiteCode(){} // RVA: 0x7FFE8299FB10
        public void get_ProtocolVersion(){} // RVA: 0x7FFE8164B230
        public void set_ProtocolVersion(){} // RVA: 0x7FFE8164E0F0
        public void set_PeerDomainName(){} // RVA: 0x7FFE81161E80
        public void ToString(){} // RVA: 0x7FFE8671A270
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MonoTlsProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ID(){} // RVA: 0x7FFE80E2DCF0
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_SupportsSslStream(){} // RVA: 0x7FFE80E2F150
        public void get_SupportsConnectionInfo(){} // RVA: 0x7FFE80E2F150
        public void get_SupportsMonoExtensions(){} // RVA: 0x7FFE80E2F150
        public void get_SupportedProtocols(){} // RVA: 0x7FFE80E2EDB0
        public void get_SupportsCleanShutdown(){} // RVA: 0x7FFE80E2F150
    }

    public class MonoTlsProviderFactory : Object
    {
        // ── Methods ──
        public void GetProvider(){} // RVA: 0x7FFE8671A510
    }

    public class MonoTlsSettings : Object
    {
        public Mono.Security.Interface.MonoRemoteCertificateValidationCallback _remoteCertificateValidationCallback; // 0x10
        public Mono.Security.Interface.MonoLocalCertificateSelectionCallback _clientCertificateSelectionCallback; // 0x18
        public System.Nullable`1<System.DateTime> _certificateValidationTime; // 0x20
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection _trustAnchors; // 0x30
        public object _userSettings; // 0x38
        public string[] _certificateSearchPaths; // 0x40
        public bool _sendCloseNotify; // 0x48
        public string[] _clientCertificateIssuers; // 0x50
        public bool _disallowUnauthenticatedCertificateRequest; // 0x58
        public System.Nullable`1<0x6667E90C> _enabledProtocols; // 0x5C
        public 0x6667E59C[] _enabledCiphers; // 0x68
        public bool cloned; // 0x70
        public bool checkCertName; // 0x71
        public bool checkCertRevocationStatus; // 0x72
        public System.Nullable`1<bool> useServicePointManagerCallback; // 0x73

        // ── Methods ──
        public void get_RemoteCertificateValidationCallback(){} // RVA: 0x7FFE81116380
        public void set_RemoteCertificateValidationCallback(){} // RVA: 0x7FFE810FCE30
        public void get_ClientCertificateSelectionCallback(){} // RVA: 0x7FFE810FE7C0
        public void set_ClientCertificateSelectionCallback(){} // RVA: 0x7FFE81161E80
        public void get_UseServicePointManagerCallback(){} // RVA: 0x7FFE8671A5F0
        public void set_UseServicePointManagerCallback(){} // RVA: 0x7FFE8671A600
        public void get_CallbackNeedsCertificateChain(){} // RVA: 0x7FFE81EC3960
        public void get_CertificateValidationTime(){} // RVA: 0x7FFE82C84C90
        public void set_CertificateValidationTime(){} // RVA: 0x7FFE8671A610
        public void get_TrustAnchors(){} // RVA: 0x7FFE8144E200
        public void set_TrustAnchors(){} // RVA: 0x7FFE81129890
        public void get_UserSettings(){} // RVA: 0x7FFE8143BA80
        public void set_UserSettings(){} // RVA: 0x7FFE81437330
        public void get_CertificateSearchPaths(){} // RVA: 0x7FFE81178740
        public void set_CertificateSearchPaths(){} // RVA: 0x7FFE81123200
        public void get_SendCloseNotify(){} // RVA: 0x7FFE811B2D30
        public void set_SendCloseNotify(){} // RVA: 0x7FFE811B2D40
        public void get_ClientCertificateIssuers(){} // RVA: 0x7FFE8119C0E0
        public void set_ClientCertificateIssuers(){} // RVA: 0x7FFE812534D0
        public void get_DisallowUnauthenticatedCertificateRequest(){} // RVA: 0x7FFE813A1140
        public void set_DisallowUnauthenticatedCertificateRequest(){} // RVA: 0x7FFE819E83C0
        public void get_EnabledProtocols(){} // RVA: 0x7FFE8671A620
        public void set_EnabledProtocols(){} // RVA: 0x7FFE8671A630
        public void get_EnabledCiphers(){} // RVA: 0x7FFE81176D50
        public void set_EnabledCiphers(){} // RVA: 0x7FFE81176D60
        public void .ctor(){} // RVA: 0x7FFE8671A920 | overloaded x2
        public void get_DefaultSettings(){} // RVA: 0x7FFE8671A650
        public void CopyDefaultSettings(){} // RVA: 0x7FFE8671A710
        public void get_CertificateValidator(){} // RVA: 0x7FFE81463AE0
        public void CloneWithValidator(){} // RVA: 0x7FFE8671A780
        public void Clone(){} // RVA: 0x7FFE8671A8C0
    }

    public class TlsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8671AED0 | overloaded x4
    }

    public class ValidationResult : Object
    {
        public bool trusted; // 0x10
        public bool user_denied; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8671A250
        public void get_Trusted(){} // RVA: 0x7FFE811C55E0
        public void get_UserDenied(){} // RVA: 0x7FFE81346E30
    }

}