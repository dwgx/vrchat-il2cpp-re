// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Interface
// Classes: 10
// Methods: 64

namespace ThirdParty.DotNet.Mono.Security.Interface
{
    public class Alert
    {
        public object Trusted;
        public object UserDenied;

        // ── Methods ──
        public void get_Level(){} // RVA: 0x7FFAF2E575E0
        public void get_Description(){} // RVA: 0x7FFAF2FF3460
        public void .ctor(){} // RVA: 0x7FFAF8689220
        public void inferAlertLevel(){} // RVA: 0x7FFAF86892A0
        public void ToString(){} // RVA: 0x7FFAF8689320
    }

    public class ICertificateValidator
    {
    }

    public class MonoLocalCertificateSelectionCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86895E0
        public void Invoke(){} // RVA: 0x7FFAF36B9580
    }

    public class MonoRemoteCertificateValidationCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8689500
        public void Invoke(){} // RVA: 0x7FFAF36B9580
    }

    public class MonoTlsConnectionInfo
    {
        // ── Methods ──
        public void get_CipherSuiteCode(){} // RVA: 0x7FFAF46BF720
        public void set_CipherSuiteCode(){} // RVA: 0x7FFAF46BFA70
        public void get_ProtocolVersion(){} // RVA: 0x7FFAF335BED0
        public void set_ProtocolVersion(){} // RVA: 0x7FFAF335C660
        public void set_PeerDomainName(){} // RVA: 0x7FFAF2DF3E80
        public void ToString(){} // RVA: 0x7FFAF8689420
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class MonoTlsProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_ID(){} // RVA: 0x7FFAF2ABC770
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void get_SupportsSslStream(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SupportsConnectionInfo(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SupportsMonoExtensions(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SupportedProtocols(){} // RVA: 0x7FFAF2ABD840
        public void get_SupportsCleanShutdown(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class MonoTlsProviderFactory
    {
        // ── Methods ──
        public void GetProvider(){} // RVA: 0x7FFAF86896C0
    }

    public class MonoTlsSettings
    {
        // ── Methods ──
        public void get_RemoteCertificateValidationCallback(){} // RVA: 0x7FFAF2DA8380
        public void set_RemoteCertificateValidationCallback(){} // RVA: 0x7FFAF2D8EE30
        public void get_ClientCertificateSelectionCallback(){} // RVA: 0x7FFAF2D907C0
        public void set_ClientCertificateSelectionCallback(){} // RVA: 0x7FFAF2DF3E80
        public void get_UseServicePointManagerCallback(){} // RVA: 0x7FFAF86897A0
        public void set_UseServicePointManagerCallback(){} // RVA: 0x7FFAF86897B0
        public void get_CallbackNeedsCertificateChain(){} // RVA: 0x7FFAF3C10850
        public void get_CertificateValidationTime(){} // RVA: 0x7FFAF49AB630
        public void set_CertificateValidationTime(){} // RVA: 0x7FFAF86897C0
        public void get_TrustAnchors(){} // RVA: 0x7FFAF30E74D0
        public void set_TrustAnchors(){} // RVA: 0x7FFAF2DBB890
        public void get_UserSettings(){} // RVA: 0x7FFAF2F476A0
        public void set_UserSettings(){} // RVA: 0x7FFAF2F4B830
        public void get_CertificateSearchPaths(){} // RVA: 0x7FFAF2E0A740
        public void set_CertificateSearchPaths(){} // RVA: 0x7FFAF2DB5200
        public void get_SendCloseNotify(){} // RVA: 0x7FFAF2E44D30
        public void set_SendCloseNotify(){} // RVA: 0x7FFAF2E44D40
        public void get_ClientCertificateIssuers(){} // RVA: 0x7FFAF2E2E0E0
        public void set_ClientCertificateIssuers(){} // RVA: 0x7FFAF2EE54D0
        public void get_DisallowUnauthenticatedCertificateRequest(){} // RVA: 0x7FFAF304FF30
        public void set_DisallowUnauthenticatedCertificateRequest(){} // RVA: 0x7FFAF370F680
        public void get_EnabledProtocols(){} // RVA: 0x7FFAF86897D0
        public void set_EnabledProtocols(){} // RVA: 0x7FFAF86897E0
        public void get_EnabledCiphers(){} // RVA: 0x7FFAF2E08D50
        public void set_EnabledCiphers(){} // RVA: 0x7FFAF2E08D60
        public void .ctor(){} // RVA: 0x7FFAF8689AD0 | overloaded x2
        public void get_DefaultSettings(){} // RVA: 0x7FFAF8689800
        public void CopyDefaultSettings(){} // RVA: 0x7FFAF86898C0
        public void get_CertificateValidator(){} // RVA: 0x7FFAF2F77C50
        public void CloneWithValidator(){} // RVA: 0x7FFAF8689930
        public void Clone(){} // RVA: 0x7FFAF8689A70
    }

    public class TlsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF868A080 | overloaded x4
    }

    public class ValidationResult
    {
        public object CipherSuiteCode;
        public object ProtocolVersion;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8689400
        public void get_Trusted(){} // RVA: 0x7FFAF2E575E0
        public void get_UserDenied(){} // RVA: 0x7FFAF2FF3460
    }

}