// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Interface
// Classes: 10
// Methods: 64

namespace ThirdParty.DotNet.Mono.Security.Interface
{
    public class Alert
    {
        public 0x659A5F58 Trusted; // 0x10
        public 0x659A5FB0 UserDenied; // 0x11

        // ── Methods ──
        public void get_Level(){} // RVA: 0x3A75E0
        public void get_Description(){} // RVA: 0x543460
        public void .ctor(){} // RVA: 0x5BD9220
        public void inferAlertLevel(){} // RVA: 0x5BD92A0
        public void ToString(){} // RVA: 0x5BD9320
    }

    public class ICertificateValidator
    {
    }

    public class MonoLocalCertificateSelectionCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BD95E0
        public void Invoke(){} // RVA: 0xC09580
    }

    public class MonoRemoteCertificateValidationCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BD9500
        public void Invoke(){} // RVA: 0xC09580
    }

    public class MonoTlsConnectionInfo
    {
        public 0x659A6110 <CipherSuiteCode>k__BackingField; // 0x10
        public 0x659A6480 <ProtocolVersion>k__BackingField; // 0x14
        public string <PeerDomainName>k__BackingField; // 0x18

        // ── Methods ──
        public void get_CipherSuiteCode(){} // RVA: 0x1C0F720
        public void set_CipherSuiteCode(){} // RVA: 0x1C0FA70
        public void get_ProtocolVersion(){} // RVA: 0x8ABED0
        public void set_ProtocolVersion(){} // RVA: 0x8AC660
        public void set_PeerDomainName(){} // RVA: 0x343E80
        public void ToString(){} // RVA: 0x5BD9420
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MonoTlsProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_ID(){} // RVA: 0xC770
        public void get_Name(){} // RVA: 0xCD60
        public void get_SupportsSslStream(){} // RVA: 0xDBE0
        public void get_SupportsConnectionInfo(){} // RVA: 0xDBE0
        public void get_SupportsMonoExtensions(){} // RVA: 0xDBE0
        public void get_SupportedProtocols(){} // RVA: 0xD840
        public void get_SupportsCleanShutdown(){} // RVA: 0xDBE0
    }

    public class MonoTlsProviderFactory
    {
        // ── Methods ──
        public void GetProvider(){} // RVA: 0x5BD96C0
    }

    public class MonoTlsSettings
    {
        public Mono.Security.Interface.MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
        public Mono.Security.Interface.MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
        public System.Nullable`1<System.DateTime> <CertificateValidationTime>k__BackingField; // 0x20
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
        public object <UserSettings>k__BackingField; // 0x38
        public string[] <CertificateSearchPaths>k__BackingField; // 0x40
        public bool <SendCloseNotify>k__BackingField; // 0x48
        public string[] <ClientCertificateIssuers>k__BackingField; // 0x50
        public bool <DisallowUnauthenticatedCertificateRequest>k__BackingField; // 0x58
        public System.Nullable`1<0x659A6480> <EnabledProtocols>k__BackingField; // 0x5C
        public 0x659A6110[] <EnabledCiphers>k__BackingField; // 0x68
        public bool cloned; // 0x70
        public bool checkCertName; // 0x71
        public bool checkCertRevocationStatus; // 0x72
        public System.Nullable`1<bool> useServicePointManagerCallback; // 0x73

        // ── Methods ──
        public void get_RemoteCertificateValidationCallback(){} // RVA: 0x2F8380
        public void set_RemoteCertificateValidationCallback(){} // RVA: 0x2DEE30
        public void get_ClientCertificateSelectionCallback(){} // RVA: 0x2E07C0
        public void set_ClientCertificateSelectionCallback(){} // RVA: 0x343E80
        public void get_UseServicePointManagerCallback(){} // RVA: 0x5BD97A0
        public void set_UseServicePointManagerCallback(){} // RVA: 0x5BD97B0
        public void get_CallbackNeedsCertificateChain(){} // RVA: 0x1160850
        public void get_CertificateValidationTime(){} // RVA: 0x1EFB630
        public void set_CertificateValidationTime(){} // RVA: 0x5BD97C0
        public void get_TrustAnchors(){} // RVA: 0x6374D0
        public void set_TrustAnchors(){} // RVA: 0x30B890
        public void get_UserSettings(){} // RVA: 0x4976A0
        public void set_UserSettings(){} // RVA: 0x49B830
        public void get_CertificateSearchPaths(){} // RVA: 0x35A740
        public void set_CertificateSearchPaths(){} // RVA: 0x305200
        public void get_SendCloseNotify(){} // RVA: 0x394D30
        public void set_SendCloseNotify(){} // RVA: 0x394D40
        public void get_ClientCertificateIssuers(){} // RVA: 0x37E0E0
        public void set_ClientCertificateIssuers(){} // RVA: 0x4354D0
        public void get_DisallowUnauthenticatedCertificateRequest(){} // RVA: 0x59FF30
        public void set_DisallowUnauthenticatedCertificateRequest(){} // RVA: 0xC5F680
        public void get_EnabledProtocols(){} // RVA: 0x5BD97D0
        public void set_EnabledProtocols(){} // RVA: 0x5BD97E0
        public void get_EnabledCiphers(){} // RVA: 0x358D50
        public void set_EnabledCiphers(){} // RVA: 0x358D60
        public void .ctor(){} // RVA: 0x5BD9AD0 | overloaded x2
        public void get_DefaultSettings(){} // RVA: 0x5BD9800
        public void CopyDefaultSettings(){} // RVA: 0x5BD98C0
        public void get_CertificateValidator(){} // RVA: 0x4C7C50
        public void CloneWithValidator(){} // RVA: 0x5BD9930
        public void Clone(){} // RVA: 0x5BD9A70
    }

    public class TlsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BDA080 | overloaded x4
    }

    public class ValidationResult
    {
        public bool CipherSuiteCode; // 0x10
        public bool ProtocolVersion; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BD9400
        public void get_Trusted(){} // RVA: 0x3A75E0
        public void get_UserDenied(){} // RVA: 0x543460
    }

}