// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Security
// Classes: 9
// Methods: 84

namespace ThirdParty.DotNet.System.Net.Security
{
    public class AuthenticatedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF967DA40
        public void get_InnerStream(){} // RVA: 0x7FFAF2DBB130
        public void Dispose(){} // RVA: 0x7FFAF967DBF0
        public void get_IsAuthenticated(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class CertificateHelper
    {
        // ── Methods ──
        public void GetEligibleClientCertificate(){} // RVA: 0x7FFAF967D6A0 | overloaded x3
        public void IsValidClientCertificate(){} // RVA: 0x7FFAF967D320
        public void IsValidForClientAuthenticationEKU(){} // RVA: 0x7FFAF967D460
        public void IsValidForDigitalSignatureUsage(){} // RVA: 0x7FFAF967D680
    }

    public class LocalCertSelectionCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86895E0
        public void Invoke(){} // RVA: 0x7FFAF36B9580
    }

    public class LocalCertificateSelectionCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF967DC90
        public void Invoke(){} // RVA: 0x7FFAF5DCB260
    }

    public class RemoteCertificateValidationCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF967DE10
        public void Invoke(){} // RVA: 0x7FFAF36B9580
    }

    public class ServerCertSelectionCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF70E4FE0
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
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
        public void get_AllowRenegotiation(){} // RVA: 0x7FFAF2DA8390
        public void get_LocalCertificateSelectionCallback(){} // RVA: 0x7FFAF2DBB0C0
        public void set_LocalCertificateSelectionCallback(){} // RVA: 0x7FFAF2DBB0D0
        public void get_RemoteCertificateValidationCallback(){} // RVA: 0x7FFAF2DBB130
        public void get_TargetHost(){} // RVA: 0x7FFAF30E74D0
        public void set_TargetHost(){} // RVA: 0x7FFAF2DBB890
        public void get_ClientCertificates(){} // RVA: 0x7FFAF2F476A0
        public void set_ClientCertificates(){} // RVA: 0x7FFAF2F4B830
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFAF967D7C0
        public void set_EncryptionPolicy(){} // RVA: 0x7FFAF967D860
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFAF306ED50
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFAF30E74E0
        public void .ctor(){} // RVA: 0x7FFAF956C8E0
    }

    public class SslServerAuthenticationOptions
    {
        // ── Methods ──
        public void get_AllowRenegotiation(){} // RVA: 0x7FFAF2DA8390
        public void get_ClientCertificateRequired(){} // RVA: 0x7FFAF4648300
        public void set_ClientCertificateRequired(){} // RVA: 0x7FFAF46482F0
        public void get_ServerCertificate(){} // RVA: 0x7FFAF2DBB0C0
        public void set_ServerCertificate(){} // RVA: 0x7FFAF2DBB0D0
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFAF335BED0
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFAF335C660
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFAF967D900
        public void set_EncryptionPolicy(){} // RVA: 0x7FFAF967D9A0
        public void .ctor(){} // RVA: 0x7FFAF956C8E0
    }

    public class SslStream
    {
        // ── Methods ──
        public void get_Impl(){} // RVA: 0x7FFAF967DF90
        public void get_InternalTargetHost(){} // RVA: 0x7FFAF967E000
        public void GetProvider(){} // RVA: 0x7FFAF967E070
        public void .ctor(){} // RVA: 0x7FFAF967E5C0 | overloaded x5
        public void SetAndVerifyValidationCallback(){} // RVA: 0x7FFAF967E840
        public void SetAndVerifySelectionCallback(){} // RVA: 0x7FFAF967E9E0
        public void AuthenticateAsClient(){} // RVA: 0x7FFAF967ED00 | overloaded x2
        public void BeginAuthenticateAsClient(){} // RVA: 0x7FFAF967ED60
        public void EndAuthenticateAsClient(){} // RVA: 0x7FFAF871ED10
        public void AuthenticateAsServer(){} // RVA: 0x7FFAF967EDE0
        public void AuthenticateAsClientAsync(){} // RVA: 0x7FFAF967EE40
        public void get_IsAuthenticated(){} // RVA: 0x7FFAF967EEA0
        public void get_LocalCertificate(){} // RVA: 0x7FFAF967EEE0
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanRead(){} // RVA: 0x7FFAF967EF10
        public void get_CanTimeout(){} // RVA: 0x7FFAF913EBD0
        public void get_CanWrite(){} // RVA: 0x7FFAF967EF40
        public void get_ReadTimeout(){} // RVA: 0x7FFAF967EF70
        public void set_ReadTimeout(){} // RVA: 0x7FFAF967EFB0
        public void get_WriteTimeout(){} // RVA: 0x7FFAF967EFF0
        public void set_WriteTimeout(){} // RVA: 0x7FFAF967F030
        public void get_Length(){} // RVA: 0x7FFAF967F070
        public void get_Position(){} // RVA: 0x7FFAF967F0B0
        public void set_Position(){} // RVA: 0x7FFAF967F0F0
        public void SetLength(){} // RVA: 0x7FFAF967F150
        public void Seek(){} // RVA: 0x7FFAF967F190
        public void FlushAsync(){} // RVA: 0x7FFAF929B680
        public void Flush(){} // RVA: 0x7FFAF8EC5940
        public void CheckDisposed(){} // RVA: 0x7FFAF967F1F0
        public void Dispose(){} // RVA: 0x7FFAF967F260
        public void Read(){} // RVA: 0x7FFAF967F360
        public void Write(){} // RVA: 0x7FFAF967F3C0
        public void ReadAsync(){} // RVA: 0x7FFAF967F420
        public void WriteAsync(){} // RVA: 0x7FFAF967F480
        public void BeginRead(){} // RVA: 0x7FFAF967F4E0
        public void EndRead(){} // RVA: 0x7FFAF967F5B0
        public void BeginWrite(){} // RVA: 0x7FFAF967F5F0
        public void EndWrite(){} // RVA: 0x7FFAF871ED10
    }

}