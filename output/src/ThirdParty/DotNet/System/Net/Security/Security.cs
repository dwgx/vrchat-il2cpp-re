// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Security
// Classes: 9
// Methods: 84

namespace ThirdParty.DotNet.System.Net.Security
{
    public class AuthenticatedStream
    {
        public System.IO.Stream _InnerStream; // 0x28
        public bool _LeaveStreamOpen; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BCDA40
        public void get_InnerStream(){} // RVA: 0x30B130
        public void Dispose(){} // RVA: 0x6BCDBF0
        public void get_IsAuthenticated(){} // RVA: 0xDBE0
    }

    public class CertificateHelper
    {
        // ── Methods ──
        public void GetEligibleClientCertificate(){} // RVA: 0x6BCD6A0 | overloaded x3
        public void IsValidClientCertificate(){} // RVA: 0x6BCD320
        public void IsValidForClientAuthenticationEKU(){} // RVA: 0x6BCD460
        public void IsValidForDigitalSignatureUsage(){} // RVA: 0x6BCD680
    }

    public class LocalCertSelectionCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BD95E0
        public void Invoke(){} // RVA: 0xC09580
    }

    public class LocalCertificateSelectionCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BCDC90
        public void Invoke(){} // RVA: 0x331B260
    }

    public class RemoteCertificateValidationCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BCDE10
        public void Invoke(){} // RVA: 0xC09580
    }

    public class ServerCertSelectionCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4634FE0
        public void Invoke(){} // RVA: 0x338C60
    }

    public class SslClientAuthenticationOptions
    {
        public 0x6585D240 AllowRenegotiation; // 0x10
        public 0x6584C9E8 ClientCertificateRequired; // 0x14
        public 0x6584C200 ServerCertificate; // 0x18
        public bool EnabledSslProtocols; // 0x1C
        public System.Net.Security.LocalCertificateSelectionCallback CertificateRevocationCheckMode; // 0x20
        public System.Net.Security.RemoteCertificateValidationCallback EncryptionPolicy; // 0x28
        public string <TargetHost>k__BackingField; // 0x30
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection <ClientCertificates>k__BackingField; // 0x38

        // ── Methods ──
        public void get_AllowRenegotiation(){} // RVA: 0x2F8390
        public void get_LocalCertificateSelectionCallback(){} // RVA: 0x30B0C0
        public void set_LocalCertificateSelectionCallback(){} // RVA: 0x30B0D0
        public void get_RemoteCertificateValidationCallback(){} // RVA: 0x30B130
        public void get_TargetHost(){} // RVA: 0x6374D0
        public void set_TargetHost(){} // RVA: 0x30B890
        public void get_ClientCertificates(){} // RVA: 0x4976A0
        public void set_ClientCertificates(){} // RVA: 0x49B830
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x6BCD7C0
        public void set_EncryptionPolicy(){} // RVA: 0x6BCD860
        public void get_EnabledSslProtocols(){} // RVA: 0x5BED50
        public void set_EnabledSslProtocols(){} // RVA: 0x6374E0
        public void .ctor(){} // RVA: 0x6ABC8E0
    }

    public class SslServerAuthenticationOptions
    {
        public 0x6584C9E8 _checkCertificateRevocation; // 0x10
        public 0x6584C200 _enabledSslProtocols; // 0x14
        public 0x6585D240 _encryptionPolicy; // 0x18
        public bool _allowRenegotiation; // 0x1C
        public bool <ClientCertificateRequired>k__BackingField; // 0x1D
        public System.Security.Cryptography.X509Certificates.X509Certificate <ServerCertificate>k__BackingField; // 0x20

        // ── Methods ──
        public void get_AllowRenegotiation(){} // RVA: 0x2F8390
        public void get_ClientCertificateRequired(){} // RVA: 0x1B98300
        public void set_ClientCertificateRequired(){} // RVA: 0x1B982F0
        public void get_ServerCertificate(){} // RVA: 0x30B0C0
        public void set_ServerCertificate(){} // RVA: 0x30B0D0
        public void get_EnabledSslProtocols(){} // RVA: 0x8ABED0
        public void set_EnabledSslProtocols(){} // RVA: 0x8AC660
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x6BCD900
        public void set_EncryptionPolicy(){} // RVA: 0x6BCD9A0
        public void .ctor(){} // RVA: 0x6ABC8E0
    }

    public class SslStream
    {
        public Mono.Net.Security.MobileTlsProvider provider; // 0x38
        public Mono.Security.Interface.MonoTlsSettings settings; // 0x40
        public System.Net.Security.RemoteCertificateValidationCallback validationCallback; // 0x48
        public System.Net.Security.LocalCertificateSelectionCallback selectionCallback; // 0x50
        public Mono.Net.Security.MobileAuthenticatedStream impl; // 0x58
        public bool explicitSettings; // 0x60

        // ── Methods ──
        public void get_Impl(){} // RVA: 0x6BCDF90
        public void get_InternalTargetHost(){} // RVA: 0x6BCE000
        public void GetProvider(){} // RVA: 0x6BCE070
        public void .ctor(){} // RVA: 0x6BCE5C0 | overloaded x5
        public void SetAndVerifyValidationCallback(){} // RVA: 0x6BCE840
        public void SetAndVerifySelectionCallback(){} // RVA: 0x6BCE9E0
        public void AuthenticateAsClient(){} // RVA: 0x6BCED00 | overloaded x2
        public void BeginAuthenticateAsClient(){} // RVA: 0x6BCED60
        public void EndAuthenticateAsClient(){} // RVA: 0x5C6ED10
        public void AuthenticateAsServer(){} // RVA: 0x6BCEDE0
        public void AuthenticateAsClientAsync(){} // RVA: 0x6BCEE40
        public void get_IsAuthenticated(){} // RVA: 0x6BCEEA0
        public void get_LocalCertificate(){} // RVA: 0x6BCEEE0
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanRead(){} // RVA: 0x6BCEF10
        public void get_CanTimeout(){} // RVA: 0x668EBD0
        public void get_CanWrite(){} // RVA: 0x6BCEF40
        public void get_ReadTimeout(){} // RVA: 0x6BCEF70
        public void set_ReadTimeout(){} // RVA: 0x6BCEFB0
        public void get_WriteTimeout(){} // RVA: 0x6BCEFF0
        public void set_WriteTimeout(){} // RVA: 0x6BCF030
        public void get_Length(){} // RVA: 0x6BCF070
        public void get_Position(){} // RVA: 0x6BCF0B0
        public void set_Position(){} // RVA: 0x6BCF0F0
        public void SetLength(){} // RVA: 0x6BCF150
        public void Seek(){} // RVA: 0x6BCF190
        public void FlushAsync(){} // RVA: 0x67EB680
        public void Flush(){} // RVA: 0x6415940
        public void CheckDisposed(){} // RVA: 0x6BCF1F0
        public void Dispose(){} // RVA: 0x6BCF260
        public void Read(){} // RVA: 0x6BCF360
        public void Write(){} // RVA: 0x6BCF3C0
        public void ReadAsync(){} // RVA: 0x6BCF420
        public void WriteAsync(){} // RVA: 0x6BCF480
        public void BeginRead(){} // RVA: 0x6BCF4E0
        public void EndRead(){} // RVA: 0x6BCF5B0
        public void BeginWrite(){} // RVA: 0x6BCF5F0
        public void EndWrite(){} // RVA: 0x5C6ED10
    }

}