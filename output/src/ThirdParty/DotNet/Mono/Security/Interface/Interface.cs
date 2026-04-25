// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Interface
// Classes: 10
// Methods: 64

namespace ThirdParty.DotNet.Mono.Security.Interface
{
    public class Alert : Object
    {
        public 0x6B2845F8 Level; // 0x10
        public 0x6B284650 Description; // 0x11

        // ── Methods ──
        public void get_Level(){} // RVA: 0x7FFAC2FEB5E0
        public void get_Description(){} // RVA: 0x7FFAC3771DA0
        public void .ctor(){} // RVA: 0x7FFAC8370770
        public void inferAlertLevel(){} // RVA: 0x7FFAC83707F0
        public void ToString(){} // RVA: 0x7FFAC8370870
    }

    public class ICertificateValidator
    {
    }

    public class MonoLocalCertificateSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8370B30
        public void Invoke(){} // RVA: 0x7FFAC383F780
    }

    public class MonoRemoteCertificateValidationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8370A50
        public void Invoke(){} // RVA: 0x7FFAC383F780
    }

    public class MonoTlsConnectionInfo : Object
    {
        public 0x6B2847B0 CipherSuiteCode; // 0x10
        public 0x6B284B20 ProtocolVersion; // 0x14
        public string PeerDomainName; // 0x18

        // ── Methods ──
        public void get_CipherSuiteCode(){} // RVA: 0x7FFAC469AEC0
        public void set_CipherSuiteCode(){} // RVA: 0x7FFAC469BCA0
        public void get_ProtocolVersion(){} // RVA: 0x7FFAC33D5A20
        public void set_ProtocolVersion(){} // RVA: 0x7FFAC33D4990
        public void set_PeerDomainName(){} // RVA: 0x7FFAC2F87E80
        public void ToString(){} // RVA: 0x7FFAC8370970
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MonoTlsProvider : Object
    {
        public object ID;
        public object Name;
        public object SupportsSslStream;
        public object SupportsConnectionInfo;
        public object SupportsMonoExtensions;
        public object SupportedProtocols;
        public object SupportsCleanShutdown;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ID(){} // RVA: 0x7FFAC2C588A0
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_SupportsSslStream(){} // RVA: 0x7FFAC2C59D00
        public void get_SupportsConnectionInfo(){} // RVA: 0x7FFAC2C59D00
        public void get_SupportsMonoExtensions(){} // RVA: 0x7FFAC2C59D00
        public void get_SupportedProtocols(){} // RVA: 0x7FFAC2C59960
        public void get_SupportsCleanShutdown(){} // RVA: 0x7FFAC2C59D00
    }

    public class MonoTlsProviderFactory : Object
    {
        // ── Methods ──
        public void GetProvider(){} // RVA: 0x7FFAC8370C10
    }

    public class MonoTlsSettings : Object
    {
        public Mono.Security.Interface.MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback; // 0x10
        public Mono.Security.Interface.MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback; // 0x18
        public System.Nullable`1<System.DateTime> UseServicePointManagerCallback; // 0x20
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection CallbackNeedsCertificateChain; // 0x30
        public object CertificateValidationTime; // 0x38
        public string[] TrustAnchors; // 0x40
        public bool UserSettings; // 0x48
        public string[] CertificateSearchPaths; // 0x50
        public bool SendCloseNotify; // 0x58
        public System.Nullable`1<0x6B284B20> ClientCertificateIssuers; // 0x5C
        public 0x6B2847B0[] DisallowUnauthenticatedCertificateRequest; // 0x68
        public bool EnabledProtocols; // 0x70
        public bool EnabledCiphers; // 0x71
        public bool DefaultSettings; // 0x72
        public System.Nullable`1<bool> CertificateValidator; // 0x73
        public bool skipSystemValidators; // 0x75
        public bool callbackNeedsChain; // 0x76
        public Mono.Security.Interface.ICertificateValidator certificateValidator; // 0x78
        public Mono.Security.Interface.MonoTlsSettings defaultSettings;

        // ── Methods ──
        public void get_RemoteCertificateValidationCallback(){} // RVA: 0x7FFAC2F3C380
        public void set_RemoteCertificateValidationCallback(){} // RVA: 0x7FFAC2F22E30
        public void get_ClientCertificateSelectionCallback(){} // RVA: 0x7FFAC2F247C0
        public void set_ClientCertificateSelectionCallback(){} // RVA: 0x7FFAC2F87E80
        public void get_UseServicePointManagerCallback(){} // RVA: 0x7FFAC8370CF0
        public void set_UseServicePointManagerCallback(){} // RVA: 0x7FFAC8370D00
        public void get_CallbackNeedsCertificateChain(){} // RVA: 0x7FFAC3C03700
        public void get_CertificateValidationTime(){} // RVA: 0x7FFAC4A19630
        public void set_CertificateValidationTime(){} // RVA: 0x7FFAC8370D10
        public void get_TrustAnchors(){} // RVA: 0x7FFAC31D95E0
        public void set_TrustAnchors(){} // RVA: 0x7FFAC2F4F890
        public void get_UserSettings(){} // RVA: 0x7FFAC31D0140
        public void set_UserSettings(){} // RVA: 0x7FFAC31D0C20
        public void get_CertificateSearchPaths(){} // RVA: 0x7FFAC2F9E740
        public void set_CertificateSearchPaths(){} // RVA: 0x7FFAC2F49200
        public void get_SendCloseNotify(){} // RVA: 0x7FFAC2FD8D30
        public void set_SendCloseNotify(){} // RVA: 0x7FFAC2FD8D40
        public void get_ClientCertificateIssuers(){} // RVA: 0x7FFAC2FC20E0
        public void set_ClientCertificateIssuers(){} // RVA: 0x7FFAC30794D0
        public void get_DisallowUnauthenticatedCertificateRequest(){} // RVA: 0x7FFAC313F600
        public void set_DisallowUnauthenticatedCertificateRequest(){} // RVA: 0x7FFAC3892770
        public void get_EnabledProtocols(){} // RVA: 0x7FFAC8370D20
        public void set_EnabledProtocols(){} // RVA: 0x7FFAC8370D30
        public void get_EnabledCiphers(){} // RVA: 0x7FFAC2F9CD50
        public void set_EnabledCiphers(){} // RVA: 0x7FFAC2F9CD60
        public void .ctor(){} // RVA: 0x7FFAC8371020 | overloaded x2
        public void get_DefaultSettings(){} // RVA: 0x7FFAC8370D50
        public void CopyDefaultSettings(){} // RVA: 0x7FFAC8370E10
        public void get_CertificateValidator(){} // RVA: 0x7FFAC30E5600
        public void CloneWithValidator(){} // RVA: 0x7FFAC8370E80
        public void Clone(){} // RVA: 0x7FFAC8370FC0
    }

    public class TlsException : Exception
    {
        public Mono.Security.Interface.Alert alert; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83715D0 | overloaded x4
    }

    public class ValidationResult : Object
    {
        public bool Trusted; // 0x10
        public bool UserDenied; // 0x11
        public int error_code; // 0x14
        public System.Nullable`1<0x6B284860> policy_errors; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8370950
        public void get_Trusted(){} // RVA: 0x7FFAC2FEB5E0
        public void get_UserDenied(){} // RVA: 0x7FFAC3771DA0
    }

}