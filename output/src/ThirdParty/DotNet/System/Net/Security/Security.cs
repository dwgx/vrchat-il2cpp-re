// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Security
// Classes: 9
// Methods: 84

namespace ThirdParty.DotNet.System.Net.Security
{
    public class AuthenticatedStream : Stream
    {
        public System.IO.Stream InnerStream; // 0x28
        public bool IsAuthenticated; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93661C0
        public void get_InnerStream(){} // RVA: 0x7FFAC2F4F130
        public void Dispose(){} // RVA: 0x7FFAC9366370
        public void get_IsAuthenticated(){} // RVA: 0x7FFAC2C59D00
    }

    public class CertificateHelper : Object
    {
        // ── Methods ──
        public void GetEligibleClientCertificate(){} // RVA: 0x7FFAC9365E20 | overloaded x3
        public void IsValidClientCertificate(){} // RVA: 0x7FFAC9365AA0
        public void IsValidForClientAuthenticationEKU(){} // RVA: 0x7FFAC9365BE0
        public void IsValidForDigitalSignatureUsage(){} // RVA: 0x7FFAC9365E00
    }

    public class LocalCertSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8370B30
        public void Invoke(){} // RVA: 0x7FFAC383F780
    }

    public class LocalCertificateSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9366410
        public void Invoke(){} // RVA: 0x7FFAC5C60E20
    }

    public class RemoteCertificateValidationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9366590
        public void Invoke(){} // RVA: 0x7FFAC383F780
    }

    public class ServerCertSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6EA1B30
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class SslClientAuthenticationOptions : Object
    {
        public 0x6B1423C8 AllowRenegotiation; // 0x10
        public 0x6B131A68 LocalCertificateSelectionCallback; // 0x14
        public 0x6B131280 RemoteCertificateValidationCallback; // 0x18
        public bool TargetHost; // 0x1C
        public System.Net.Security.LocalCertificateSelectionCallback ClientCertificates; // 0x20
        public System.Net.Security.RemoteCertificateValidationCallback CertificateRevocationCheckMode; // 0x28
        public string EncryptionPolicy; // 0x30
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection EnabledSslProtocols; // 0x38

        // ── Methods ──
        public void get_AllowRenegotiation(){} // RVA: 0x7FFAC2F3C390
        public void get_LocalCertificateSelectionCallback(){} // RVA: 0x7FFAC2F4F0C0
        public void set_LocalCertificateSelectionCallback(){} // RVA: 0x7FFAC2F4F0D0
        public void get_RemoteCertificateValidationCallback(){} // RVA: 0x7FFAC2F4F130
        public void get_TargetHost(){} // RVA: 0x7FFAC31D95E0
        public void set_TargetHost(){} // RVA: 0x7FFAC2F4F890
        public void get_ClientCertificates(){} // RVA: 0x7FFAC31D0140
        public void set_ClientCertificates(){} // RVA: 0x7FFAC31D0C20
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFAC9365F40
        public void set_EncryptionPolicy(){} // RVA: 0x7FFAC9365FE0
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFAC3157800
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFAC392CD10
        public void .ctor(){} // RVA: 0x7FFAC9253460
    }

    public class SslServerAuthenticationOptions : Object
    {
        public 0x6B131A68 AllowRenegotiation; // 0x10
        public 0x6B131280 ClientCertificateRequired; // 0x14
        public 0x6B1423C8 ServerCertificate; // 0x18
        public bool EnabledSslProtocols; // 0x1C
        public bool CertificateRevocationCheckMode; // 0x1D
        public System.Security.Cryptography.X509Certificates.X509Certificate EncryptionPolicy; // 0x20

        // ── Methods ──
        public void get_AllowRenegotiation(){} // RVA: 0x7FFAC2F3C390
        public void get_ClientCertificateRequired(){} // RVA: 0x7FFAC45FA990
        public void set_ClientCertificateRequired(){} // RVA: 0x7FFAC45F8A90
        public void get_ServerCertificate(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ServerCertificate(){} // RVA: 0x7FFAC2F4F0D0
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFAC33D5A20
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFAC33D4990
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFAC9366080
        public void set_EncryptionPolicy(){} // RVA: 0x7FFAC9366120
        public void .ctor(){} // RVA: 0x7FFAC9253460
    }

    public class SslStream : AuthenticatedStream
    {
        public Mono.Net.Security.MobileTlsProvider Impl; // 0x38
        public Mono.Security.Interface.MonoTlsSettings InternalTargetHost; // 0x40
        public System.Net.Security.RemoteCertificateValidationCallback IsAuthenticated; // 0x48
        public System.Net.Security.LocalCertificateSelectionCallback LocalCertificate; // 0x50
        public Mono.Net.Security.MobileAuthenticatedStream CanSeek; // 0x58
        public bool CanRead; // 0x60

        // ── Methods ──
        public void get_Impl(){} // RVA: 0x7FFAC9366710
        public void get_InternalTargetHost(){} // RVA: 0x7FFAC9366780
        public void GetProvider(){} // RVA: 0x7FFAC93667F0
        public void .ctor(){} // RVA: 0x7FFAC9366D40 | overloaded x5
        public void SetAndVerifyValidationCallback(){} // RVA: 0x7FFAC9366FC0
        public void SetAndVerifySelectionCallback(){} // RVA: 0x7FFAC9367160
        public void AuthenticateAsClient(){} // RVA: 0x7FFAC9367480 | overloaded x2
        public void BeginAuthenticateAsClient(){} // RVA: 0x7FFAC93674E0
        public void EndAuthenticateAsClient(){} // RVA: 0x7FFAC84062A0
        public void AuthenticateAsServer(){} // RVA: 0x7FFAC9367560
        public void AuthenticateAsClientAsync(){} // RVA: 0x7FFAC93675C0
        public void get_IsAuthenticated(){} // RVA: 0x7FFAC9367620
        public void get_LocalCertificate(){} // RVA: 0x7FFAC9367660
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanRead(){} // RVA: 0x7FFAC9367690
        public void get_CanTimeout(){} // RVA: 0x7FFAC8E25690
        public void get_CanWrite(){} // RVA: 0x7FFAC93676C0
        public void get_ReadTimeout(){} // RVA: 0x7FFAC93676F0
        public void set_ReadTimeout(){} // RVA: 0x7FFAC9367730
        public void get_WriteTimeout(){} // RVA: 0x7FFAC9367770
        public void set_WriteTimeout(){} // RVA: 0x7FFAC93677B0
        public void get_Length(){} // RVA: 0x7FFAC93677F0
        public void get_Position(){} // RVA: 0x7FFAC9367830
        public void set_Position(){} // RVA: 0x7FFAC9367870
        public void SetLength(){} // RVA: 0x7FFAC93678D0
        public void Seek(){} // RVA: 0x7FFAC9367910
        public void FlushAsync(){} // RVA: 0x7FFAC8F82540
        public void Flush(){} // RVA: 0x7FFAC8BACCC0
        public void CheckDisposed(){} // RVA: 0x7FFAC9367970
        public void Dispose(){} // RVA: 0x7FFAC93679E0
        public void Read(){} // RVA: 0x7FFAC9367AE0
        public void Write(){} // RVA: 0x7FFAC9367B40
        public void ReadAsync(){} // RVA: 0x7FFAC9367BA0
        public void WriteAsync(){} // RVA: 0x7FFAC9367C00
        public void BeginRead(){} // RVA: 0x7FFAC9367C60
        public void EndRead(){} // RVA: 0x7FFAC9367D30
        public void BeginWrite(){} // RVA: 0x7FFAC9367D70
        public void EndWrite(){} // RVA: 0x7FFAC84062A0
    }

}