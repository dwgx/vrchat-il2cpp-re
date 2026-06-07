// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Security
// Classes: 9
// Methods: 84

namespace ThirdParty.DotNet.System.Net.Security
{
    public class AuthenticatedStream
    {
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
        public object AllowRenegotiation;
        public object ClientCertificateRequired;
        public object ServerCertificate;
        public object EnabledSslProtocols;
        public object CertificateRevocationCheckMode;
        public object EncryptionPolicy;

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