// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Security
// Classes: 9
// Methods: 77

namespace ThirdParty.DotNet.System.Net.Security
{
    public class AuthenticatedStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BC960
        public void get_InnerStream(){} // RVA: 0x7A8105330
        public void Dispose(){} // RVA: 0x7AE9BCB10
        public void get_IsAuthenticated(){} // RVA: 0x7A7E01900
    }

    public class CertificateHelper : Object
    {
        // ── Methods ──
        public void GetEligibleClientCertificate(){} // RVA: 0x7AE9BC5C0
        public void IsValidClientCertificate(){} // RVA: 0x7AE9BC240
        public void IsValidForClientAuthenticationEKU(){} // RVA: 0x7AE9BC380
        public void IsValidForDigitalSignatureUsage(){} // RVA: 0x7AE9BC5A0
    }

    public class LocalCertSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9C7150
        public void Invoke(){} // RVA: 0x7A89D0820
    }

    public class LocalCertificateSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BCBB0
        public void Invoke(){} // RVA: 0x7AB112E00
    }

    public class RemoteCertificateValidationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BCD20
        public void Invoke(){} // RVA: 0x7A89D0820
    }

    public class ServerCertSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC426AF0
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class SslClientAuthenticationOptions : Object
    {
        // ── Methods ──
        public void get_AllowRenegotiation(){} // RVA: 0x7A80F2580
        public void get_LocalCertificateSelectionCallback(){} // RVA: 0x7A81052C0
        public void set_LocalCertificateSelectionCallback(){} // RVA: 0x7A81052D0
        public void get_RemoteCertificateValidationCallback(){} // RVA: 0x7A8105330
        public void get_TargetHost(){} // RVA: 0x7A83F69F0
        public void set_TargetHost(){} // RVA: 0x7A8105A90
        public void get_ClientCertificates(){} // RVA: 0x7A8292C30
        public void set_ClientCertificates(){} // RVA: 0x7A8296DE0
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7AE9BC6E0
        public void set_EncryptionPolicy(){} // RVA: 0x7AE9BC780
        public void get_EnabledSslProtocols(){} // RVA: 0x7A83782A0
        public void set_EnabledSslProtocols(){} // RVA: 0x7A84385B0
        public void .ctor(){} // RVA: 0x7AE8AD0C0
    }

    public class SslServerAuthenticationOptions : Object
    {
        // ── Methods ──
        public void get_AllowRenegotiation(){} // RVA: 0x7A80F2580
        public void get_ClientCertificateRequired(){} // RVA: 0x7A99562E0
        public void set_ClientCertificateRequired(){} // RVA: 0x7A99562D0
        public void get_ServerCertificate(){} // RVA: 0x7A81052C0
        public void set_ServerCertificate(){} // RVA: 0x7A81052D0
        public void get_EnabledSslProtocols(){} // RVA: 0x7A8668BC0
        public void set_EnabledSslProtocols(){} // RVA: 0x7A8669360
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7AE9BC820
        public void set_EncryptionPolicy(){} // RVA: 0x7AE9BC8C0
        public void .ctor(){} // RVA: 0x7AE8AD0C0
    }

    public class SslStream : AuthenticatedStream
    {
        // ── Methods ──
        public void get_Impl(){} // RVA: 0x7AE9BCE90
        public void get_InternalTargetHost(){} // RVA: 0x7AE9BCF00
        public void GetProvider(){} // RVA: 0x7AE9BCF70
        public void .ctor(){} // RVA: 0x7AE9BD4C0
        public void SetAndVerifyValidationCallback(){} // RVA: 0x7AE9BD740
        public void SetAndVerifySelectionCallback(){} // RVA: 0x7AE9BD8E0
        public void AuthenticateAsClient(){} // RVA: 0x7AE9BDC00
        public void BeginAuthenticateAsClient(){} // RVA: 0x7AE9BDC60
        public void EndAuthenticateAsClient(){} // RVA: 0x7ADA5CD30
        public void AuthenticateAsServer(){} // RVA: 0x7AE9BDCE0
        public void AuthenticateAsClientAsync(){} // RVA: 0x7AE9BDD40
        public void get_IsAuthenticated(){} // RVA: 0x7AE9BDDA0
        public void get_LocalCertificate(){} // RVA: 0x7AE9BDDE0
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanRead(){} // RVA: 0x7AE9BDE10
        public void get_CanTimeout(){} // RVA: 0x7AE47D240
        public void get_CanWrite(){} // RVA: 0x7AE9BDE40
        public void get_ReadTimeout(){} // RVA: 0x7AE9BDE70
        public void set_ReadTimeout(){} // RVA: 0x7AE9BDEB0
        public void get_WriteTimeout(){} // RVA: 0x7AE9BDEF0
        public void set_WriteTimeout(){} // RVA: 0x7AE9BDF30
        public void get_Length(){} // RVA: 0x7AE9BDF70
        public void get_Position(){} // RVA: 0x7AE9BDFB0
        public void set_Position(){} // RVA: 0x7AE9BDFF0
        public void SetLength(){} // RVA: 0x7AE9BE050
        public void Seek(){} // RVA: 0x7AE9BE090
        public void FlushAsync(){} // RVA: 0x7AE5D9B90
        public void Flush(){} // RVA: 0x7AE203670
        public void CheckDisposed(){} // RVA: 0x7AE9BE0F0
        public void Dispose(){} // RVA: 0x7AE9BE160
        public void Read(){} // RVA: 0x7AE9BE260
        public void Write(){} // RVA: 0x7AE9BE2C0
        public void ReadAsync(){} // RVA: 0x7AE9BE320
        public void WriteAsync(){} // RVA: 0x7AE9BE380
        public void BeginRead(){} // RVA: 0x7AE9BE3E0
        public void EndRead(){} // RVA: 0x7AE9BE4B0
        public void BeginWrite(){} // RVA: 0x7AE9BE4F0
        public void EndWrite(){} // RVA: 0x7ADA5CD30
    }

}