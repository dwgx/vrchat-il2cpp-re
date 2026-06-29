// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Interface
// Classes: 10
// Methods: 75

namespace ThirdParty.DotNet.Mono.Security.Interface
{
    public class Alert : Object
    {
        public object level;
        public object description;

        // ── Methods ──
        public void get_Level(){} // RVA: 0xC120A0
        public void get_Description(){} // RVA: 0xDD5C50
        public void .ctor(){} // RVA: 0x6651BA0
        public void inferAlertLevel(){} // RVA: 0x6651C20
        public void ToString(){} // RVA: 0x6651CA0
    }

    public class CipherSuiteCode[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EBD500
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B590
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC7AB0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E755F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B590
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MonoLocalCertificateSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6651F70
        public void Invoke(){} // RVA: 0x14CC9D0
    }

    public class MonoRemoteCertificateValidationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6651E80
        public void Invoke(){} // RVA: 0x14CC9D0
    }

    public class MonoTlsConnectionInfo : Object
    {
        public object _cipherSuiteCode;
        public object _protocolVersion;
        public object _peerDomainName;

        // ── Methods ──
        public void get_CipherSuiteCode(){} // RVA: 0x24EA1D0
        public void set_CipherSuiteCode(){} // RVA: 0x24EAB10
        public void get_ProtocolVersion(){} // RVA: 0x116A650
        public void set_ProtocolVersion(){} // RVA: 0x116BB10
        public void set_PeerDomainName(){} // RVA: 0xBA9BA0
        public void ToString(){} // RVA: 0x6651DA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MonoTlsProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_ID(){} // RVA: 0x87BEB0
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_SupportsSslStream(){} // RVA: 0x87D280
        public void get_SupportsConnectionInfo(){} // RVA: 0x87D280
        public void get_SupportsMonoExtensions(){} // RVA: 0x87D280
        public void get_SupportedProtocols(){} // RVA: 0x87C130
        public void get_SupportsCleanShutdown(){} // RVA: 0x87D280
    }

    public class MonoTlsProviderFactory : Object
    {
        // ── Methods ──
        public void GetProvider(){} // RVA: 0x6652060
    }

    public class MonoTlsSettings : Object
    {
        public object _remoteCertificateValidationCallback;
        public object _clientCertificateSelectionCallback;
        public object _certificateValidationTime;
        public object _trustAnchors;
        public object _userSettings;
        public object _certificateSearchPaths;
        public object _sendCloseNotify;
        public object _clientCertificateIssuers;
        public object _disallowUnauthenticatedCertificateRequest;
        public object _enabledProtocols;
        public object _enabledCiphers;
        public object cloned;
        public object checkCertName;
        public object checkCertRevocationStatus;
        public object useServicePointManagerCallback;
        public object skipSystemValidators;
        public object callbackNeedsChain;
        public object certificateValidator;
        public object defaultSettings;

        // ── Methods ──
        public void get_RemoteCertificateValidationCallback(){} // RVA: 0xB5DBF0
        public void set_RemoteCertificateValidationCallback(){} // RVA: 0xB44D60
        public void get_ClientCertificateSelectionCallback(){} // RVA: 0xB465B0
        public void set_ClientCertificateSelectionCallback(){} // RVA: 0xBA9BA0
        public void get_UseServicePointManagerCallback(){} // RVA: 0x6652140
        public void set_UseServicePointManagerCallback(){} // RVA: 0x6652150
        public void get_CallbackNeedsCertificateChain(){} // RVA: 0x1A1F4B0
        public void get_CertificateValidationTime(){} // RVA: 0x16CD810
        public void set_CertificateValidationTime(){} // RVA: 0x16DCCA0
        public void get_TrustAnchors(){} // RVA: 0xD33E60
        public void set_TrustAnchors(){} // RVA: 0xB708C0
        public void get_UserSettings(){} // RVA: 0xD05CA0
        public void set_UserSettings(){} // RVA: 0xD09D70
        public void get_CertificateSearchPaths(){} // RVA: 0xBC1B30
        public void set_CertificateSearchPaths(){} // RVA: 0xB6A8C0
        public void get_SendCloseNotify(){} // RVA: 0xBFDA40
        public void set_SendCloseNotify(){} // RVA: 0xBFDA50
        public void get_ClientCertificateIssuers(){} // RVA: 0xBE58B0
        public void set_ClientCertificateIssuers(){} // RVA: 0xCA4DF0
        public void get_DisallowUnauthenticatedCertificateRequest(){} // RVA: 0xE3F480
        public void set_DisallowUnauthenticatedCertificateRequest(){} // RVA: 0x1546550
        public void get_EnabledProtocols(){} // RVA: 0x6652160
        public void set_EnabledProtocols(){} // RVA: 0x6652170
        public void get_EnabledCiphers(){} // RVA: 0xBBFF90
        public void set_EnabledCiphers(){} // RVA: 0xBBFFA0
        public void .ctor(){} // RVA: 0x6652460
        public void get_DefaultSettings(){} // RVA: 0x6652190
        public void CopyDefaultSettings(){} // RVA: 0x6652250
        public void get_CertificateValidator(){} // RVA: 0xCD3320
        public void CloneWithValidator(){} // RVA: 0x66522C0
        public void Clone(){} // RVA: 0x6652400
    }

    public class TlsException : Exception
    {
        public object alert;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6652A10
    }

    public class ValidationResult : Object
    {
        public object trusted;
        public object user_denied;
        public object error_code;
        public object policy_errors;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6651D80
        public void get_Trusted(){} // RVA: 0xC120A0
        public void get_UserDenied(){} // RVA: 0xDD5C50
    }

}