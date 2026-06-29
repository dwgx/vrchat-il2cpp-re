// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Interface
// Classes: 10
// Methods: 75

namespace ThirdParty.DotNet.Mono.Security.Interface
{
    public class Alert : Object
    {
        // ── Methods ──
        public void get_Level(){} // RVA: 0x7A81A2200
        public void get_Description(){} // RVA: 0x7A82FBFB0
        public void .ctor(){} // RVA: 0x7AD9C6D80
        public void inferAlertLevel(){} // RVA: 0x7AD9C6E00
        public void ToString(){} // RVA: 0x7AD9C6E80
    }

    public class CipherSuiteCode[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2DC5C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EB50
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6000
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA299010
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EB50
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class MonoLocalCertificateSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9C7150
        public void Invoke(){} // RVA: 0x7A89D0820
    }

    public class MonoRemoteCertificateValidationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9C7060
        public void Invoke(){} // RVA: 0x7A89D0820
    }

    public class MonoTlsConnectionInfo : Object
    {
        // ── Methods ──
        public void get_CipherSuiteCode(){} // RVA: 0x7A99CD750
        public void set_CipherSuiteCode(){} // RVA: 0x7A99CDAA0
        public void get_ProtocolVersion(){} // RVA: 0x7A8668BC0
        public void set_ProtocolVersion(){} // RVA: 0x7A8669360
        public void set_PeerDomainName(){} // RVA: 0x7A813E420
        public void ToString(){} // RVA: 0x7AD9C6F80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class MonoTlsProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_ID(){} // RVA: 0x7A7E00490
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_SupportsSslStream(){} // RVA: 0x7A7E01900
        public void get_SupportsConnectionInfo(){} // RVA: 0x7A7E01900
        public void get_SupportsMonoExtensions(){} // RVA: 0x7A7E01900
        public void get_SupportedProtocols(){} // RVA: 0x7A7E00710
        public void get_SupportsCleanShutdown(){} // RVA: 0x7A7E01900
    }

    public class MonoTlsProviderFactory : Object
    {
        // ── Methods ──
        public void GetProvider(){} // RVA: 0x7AD9C7240
    }

    public class MonoTlsSettings : Object
    {
        // ── Methods ──
        public void get_RemoteCertificateValidationCallback(){} // RVA: 0x7A80F2570
        public void set_RemoteCertificateValidationCallback(){} // RVA: 0x7A80D8E20
        public void get_ClientCertificateSelectionCallback(){} // RVA: 0x7A80DA7B0
        public void set_ClientCertificateSelectionCallback(){} // RVA: 0x7A813E420
        public void get_UseServicePointManagerCallback(){} // RVA: 0x7AD9C7320
        public void set_UseServicePointManagerCallback(){} // RVA: 0x7AD9C7330
        public void get_CallbackNeedsCertificateChain(){} // RVA: 0x7A8F12DA0
        public void get_CertificateValidationTime(){} // RVA: 0x7A9D01C90
        public void set_CertificateValidationTime(){} // RVA: 0x7AD9C7340
        public void get_TrustAnchors(){} // RVA: 0x7A83F69F0
        public void set_TrustAnchors(){} // RVA: 0x7A8105A90
        public void get_UserSettings(){} // RVA: 0x7A8292C30
        public void set_UserSettings(){} // RVA: 0x7A8296DE0
        public void get_CertificateSearchPaths(){} // RVA: 0x7A8154D80
        public void set_CertificateSearchPaths(){} // RVA: 0x7A80FF440
        public void get_SendCloseNotify(){} // RVA: 0x7A818F850
        public void set_SendCloseNotify(){} // RVA: 0x7A818F860
        public void get_ClientCertificateIssuers(){} // RVA: 0x7A8178B90
        public void set_ClientCertificateIssuers(){} // RVA: 0x7A8230620
        public void get_DisallowUnauthenticatedCertificateRequest(){} // RVA: 0x7A8359360
        public void set_DisallowUnauthenticatedCertificateRequest(){} // RVA: 0x7A8A21900
        public void get_EnabledProtocols(){} // RVA: 0x7AD9C7350
        public void set_EnabledProtocols(){} // RVA: 0x7AD9C7360
        public void get_EnabledCiphers(){} // RVA: 0x7A8153390
        public void set_EnabledCiphers(){} // RVA: 0x7A81533A0
        public void .ctor(){} // RVA: 0x7AD9C7650
        public void get_DefaultSettings(){} // RVA: 0x7AD9C7380
        public void CopyDefaultSettings(){} // RVA: 0x7AD9C7440
        public void get_CertificateValidator(){} // RVA: 0x7A82C2060
        public void CloneWithValidator(){} // RVA: 0x7AD9C74B0
        public void Clone(){} // RVA: 0x7AD9C75F0
    }

    public class TlsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9C7C00
    }

    public class ValidationResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9C6F60
        public void get_Trusted(){} // RVA: 0x7A81A2200
        public void get_UserDenied(){} // RVA: 0x7A82FBFB0
    }

}