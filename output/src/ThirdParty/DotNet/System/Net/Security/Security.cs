// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Security
// Classes: 9
// Methods: 84

namespace ThirdParty.DotNet.System.Net.Security
{
    public class AuthenticatedStream : Stream
    {
        public System.IO.Stream _InnerStream; // 0x28
        public bool _LeaveStreamOpen; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8770E8F0
        public void get_InnerStream(){} // RVA: 0x7FFE81129130
        public void Dispose(){} // RVA: 0x7FFE8770EAA0
        public void get_IsAuthenticated(){} // RVA: 0x7FFE80E2F150
    }

    public class CertificateHelper : Object
    {
        // ── Methods ──
        public void GetEligibleClientCertificate(){} // RVA: 0x7FFE8770E550 | overloaded x3
        public void IsValidClientCertificate(){} // RVA: 0x7FFE8770E1D0
        public void IsValidForClientAuthenticationEKU(){} // RVA: 0x7FFE8770E310
        public void IsValidForDigitalSignatureUsage(){} // RVA: 0x7FFE8770E530
    }

    public class LocalCertSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8671A430
        public void Invoke(){} // RVA: 0x7FFE81998A70
    }

    public class LocalCertificateSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8770EB40
        public void Invoke(){} // RVA: 0x7FFE83F99C10
    }

    public class RemoteCertificateValidationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8770ECC0
        public void Invoke(){} // RVA: 0x7FFE81998A70
    }

    public class ServerCertSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8526B7D0
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class SslClientAuthenticationOptions : Object
    {
        public 0x6653B2EC _encryptionPolicy; // 0x10
        public 0x6652A98C _checkCertificateRevocation; // 0x14
        public 0x6652A1A4 _enabledSslProtocols; // 0x18
        public bool _allowRenegotiation; // 0x1C
        public System.Net.Security.LocalCertificateSelectionCallback _localCertificateSelectionCallback; // 0x20
        public System.Net.Security.RemoteCertificateValidationCallback _remoteCertificateValidationCallback; // 0x28
        public string _targetHost; // 0x30
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates; // 0x38

        // ── Methods ──
        public void get_AllowRenegotiation(){} // RVA: 0x7FFE81116390
        public void get_LocalCertificateSelectionCallback(){} // RVA: 0x7FFE811290C0
        public void set_LocalCertificateSelectionCallback(){} // RVA: 0x7FFE811290D0
        public void get_RemoteCertificateValidationCallback(){} // RVA: 0x7FFE81129130
        public void get_TargetHost(){} // RVA: 0x7FFE8144E200
        public void set_TargetHost(){} // RVA: 0x7FFE81129890
        public void get_ClientCertificates(){} // RVA: 0x7FFE8143BA80
        public void set_ClientCertificates(){} // RVA: 0x7FFE81437330
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFE8770E670
        public void set_EncryptionPolicy(){} // RVA: 0x7FFE8770E710
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFE813DB630
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFE8144DF00
        public void .ctor(){} // RVA: 0x7FFE875FBBD0
    }

    public class SslServerAuthenticationOptions : Object
    {
        public 0x6652A98C _checkCertificateRevocation; // 0x10
        public 0x6652A1A4 _enabledSslProtocols; // 0x14
        public 0x6653B2EC _encryptionPolicy; // 0x18
        public bool _allowRenegotiation; // 0x1C
        public bool _clientCertificateRequired; // 0x1D
        public System.Security.Cryptography.X509Certificates.X509Certificate _serverCertificate; // 0x20

        // ── Methods ──
        public void get_AllowRenegotiation(){} // RVA: 0x7FFE81116390
        public void get_ClientCertificateRequired(){} // RVA: 0x7FFE82930100
        public void set_ClientCertificateRequired(){} // RVA: 0x7FFE8292ECA0
        public void get_ServerCertificate(){} // RVA: 0x7FFE811290C0
        public void set_ServerCertificate(){} // RVA: 0x7FFE811290D0
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFE8164B230
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFE8164E0F0
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFE8770E7B0
        public void set_EncryptionPolicy(){} // RVA: 0x7FFE8770E850
        public void .ctor(){} // RVA: 0x7FFE875FBBD0
    }

    public class SslStream : AuthenticatedStream
    {
        public Mono.Net.Security.MobileTlsProvider provider; // 0x38
        public Mono.Security.Interface.MonoTlsSettings settings; // 0x40
        public System.Net.Security.RemoteCertificateValidationCallback validationCallback; // 0x48
        public System.Net.Security.LocalCertificateSelectionCallback selectionCallback; // 0x50
        public Mono.Net.Security.MobileAuthenticatedStream impl; // 0x58
        public bool explicitSettings; // 0x60
        public object field_6; // 0x62E
        public object field_7; // 0x62F
        public object field_8; // 0x630
        public object field_9; // 0x631
        public object field_10; // 0x632
        public object field_11; // 0x633

        // ── Methods ──
        public void get_Impl(){} // RVA: 0x7FFE8770EE40
        public void get_InternalTargetHost(){} // RVA: 0x7FFE8770EEB0
        public void GetProvider(){} // RVA: 0x7FFE8770EF20
        public void .ctor(){} // RVA: 0x7FFE8770F470 | overloaded x5
        public void SetAndVerifyValidationCallback(){} // RVA: 0x7FFE8770F6F0
        public void SetAndVerifySelectionCallback(){} // RVA: 0x7FFE8770F890
        public void AuthenticateAsClient(){} // RVA: 0x7FFE8770FBB0 | overloaded x2
        public void BeginAuthenticateAsClient(){} // RVA: 0x7FFE8770FC10
        public void EndAuthenticateAsClient(){} // RVA: 0x7FFE867AFBB0
        public void AuthenticateAsServer(){} // RVA: 0x7FFE8770FC90
        public void AuthenticateAsClientAsync(){} // RVA: 0x7FFE8770FCF0
        public void get_IsAuthenticated(){} // RVA: 0x7FFE8770FD50
        public void get_LocalCertificate(){} // RVA: 0x7FFE8770FD90
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanRead(){} // RVA: 0x7FFE8770FDC0
        public void get_CanTimeout(){} // RVA: 0x7FFE871CDAC0
        public void get_CanWrite(){} // RVA: 0x7FFE8770FDF0
        public void get_ReadTimeout(){} // RVA: 0x7FFE8770FE20
        public void set_ReadTimeout(){} // RVA: 0x7FFE8770FE60
        public void get_WriteTimeout(){} // RVA: 0x7FFE8770FEA0
        public void set_WriteTimeout(){} // RVA: 0x7FFE8770FEE0
        public void get_Length(){} // RVA: 0x7FFE8770FF20
        public void get_Position(){} // RVA: 0x7FFE8770FF60
        public void set_Position(){} // RVA: 0x7FFE8770FFA0
        public void SetLength(){} // RVA: 0x7FFE87710000
        public void Seek(){} // RVA: 0x7FFE87710040
        public void FlushAsync(){} // RVA: 0x7FFE81D50180
        public void Flush(){} // RVA: 0x7FFE86F56340
        public void CheckDisposed(){} // RVA: 0x7FFE877100A0
        public void Dispose(){} // RVA: 0x7FFE87710110
        public void Read(){} // RVA: 0x7FFE87710210
        public void Write(){} // RVA: 0x7FFE87710270
        public void ReadAsync(){} // RVA: 0x7FFE877102D0
        public void WriteAsync(){} // RVA: 0x7FFE87710330
        public void BeginRead(){} // RVA: 0x7FFE87710390
        public void EndRead(){} // RVA: 0x7FFE87710460
        public void BeginWrite(){} // RVA: 0x7FFE877104A0
        public void EndWrite(){} // RVA: 0x7FFE867AFBB0
    }

}