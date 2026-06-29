// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Security
// Classes: 9
// Methods: 77

namespace ThirdParty.DotNet.System.Net.Security
{
    public class AuthenticatedStream : Stream
    {
        public object _InnerStream;
        public object _LeaveStreamOpen;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x762EA60
        public void get_InnerStream(){} // RVA: 0xB70160
        public void Dispose(){} // RVA: 0x762EC10
        public void get_IsAuthenticated(){} // RVA: 0x87D280
    }

    public class CertificateHelper : Object
    {
        // ── Methods ──
        public void GetEligibleClientCertificate(){} // RVA: 0x762E6C0
        public void IsValidClientCertificate(){} // RVA: 0x762E340
        public void IsValidForClientAuthenticationEKU(){} // RVA: 0x762E480
        public void IsValidForDigitalSignatureUsage(){} // RVA: 0x762E6A0
    }

    public class LocalCertSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6651F70
        public void Invoke(){} // RVA: 0x14CC9D0
    }

    public class LocalCertificateSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x762ECB0
        public void Invoke(){} // RVA: 0x3DCCA70
    }

    public class RemoteCertificateValidationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x762EE20
        public void Invoke(){} // RVA: 0x14CC9D0
    }

    public class ServerCertSelectionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F6ECE0
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class SslClientAuthenticationOptions : Object
    {
        public object _encryptionPolicy;
        public object _checkCertificateRevocation;
        public object _enabledSslProtocols;
        public object _allowRenegotiation;
        public object _localCertificateSelectionCallback;
        public object _remoteCertificateValidationCallback;
        public object _targetHost;
        public object _clientCertificates;

        // ── Methods ──
        public void get_AllowRenegotiation(){} // RVA: 0xB5DC00
        public void get_LocalCertificateSelectionCallback(){} // RVA: 0xB700F0
        public void set_LocalCertificateSelectionCallback(){} // RVA: 0xB70100
        public void get_RemoteCertificateValidationCallback(){} // RVA: 0xB70160
        public void get_TargetHost(){} // RVA: 0xD33E60
        public void set_TargetHost(){} // RVA: 0xB708C0
        public void get_ClientCertificates(){} // RVA: 0xD05CA0
        public void set_ClientCertificates(){} // RVA: 0xD09D70
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x762E7E0
        public void set_EncryptionPolicy(){} // RVA: 0x762E880
        public void get_EnabledSslProtocols(){} // RVA: 0xE62D00
        public void set_EnabledSslProtocols(){} // RVA: 0x1033F40
        public void .ctor(){} // RVA: 0x7521270
    }

    public class SslServerAuthenticationOptions : Object
    {
        public object _checkCertificateRevocation;
        public object _enabledSslProtocols;
        public object _encryptionPolicy;
        public object _allowRenegotiation;
        public object _clientCertificateRequired;
        public object _serverCertificate;

        // ── Methods ──
        public void get_AllowRenegotiation(){} // RVA: 0xB5DC00
        public void get_ClientCertificateRequired(){} // RVA: 0x246F120
        public void set_ClientCertificateRequired(){} // RVA: 0x246E520
        public void get_ServerCertificate(){} // RVA: 0xB700F0
        public void set_ServerCertificate(){} // RVA: 0xB70100
        public void get_EnabledSslProtocols(){} // RVA: 0x116A650
        public void set_EnabledSslProtocols(){} // RVA: 0x116BB10
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x762E920
        public void set_EncryptionPolicy(){} // RVA: 0x762E9C0
        public void .ctor(){} // RVA: 0x7521270
    }

    public class SslStream : AuthenticatedStream
    {
        public object provider;
        public object settings;
        public object validationCallback;
        public object selectionCallback;
        public object impl;
        public object explicitSettings;

        // ── Methods ──
        public void get_Impl(){} // RVA: 0x762EF90
        public void get_InternalTargetHost(){} // RVA: 0x762F000
        public void GetProvider(){} // RVA: 0x762F070
        public void .ctor(){} // RVA: 0x762F5C0
        public void SetAndVerifyValidationCallback(){} // RVA: 0x762F840
        public void SetAndVerifySelectionCallback(){} // RVA: 0x762F9E0
        public void AuthenticateAsClient(){} // RVA: 0x762FD00
        public void BeginAuthenticateAsClient(){} // RVA: 0x762FD60
        public void EndAuthenticateAsClient(){} // RVA: 0x66E7340
        public void AuthenticateAsServer(){} // RVA: 0x762FDE0
        public void AuthenticateAsClientAsync(){} // RVA: 0x762FE40
        public void get_IsAuthenticated(){} // RVA: 0x762FEA0
        public void get_LocalCertificate(){} // RVA: 0x762FEE0
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanRead(){} // RVA: 0x762FF10
        public void get_CanTimeout(){} // RVA: 0x70F9330
        public void get_CanWrite(){} // RVA: 0x762FF40
        public void get_ReadTimeout(){} // RVA: 0x762FF70
        public void set_ReadTimeout(){} // RVA: 0x762FFB0
        public void get_WriteTimeout(){} // RVA: 0x762FFF0
        public void set_WriteTimeout(){} // RVA: 0x7630030
        public void get_Length(){} // RVA: 0x7630070
        public void get_Position(){} // RVA: 0x76300B0
        public void set_Position(){} // RVA: 0x76300F0
        public void SetLength(){} // RVA: 0x7630150
        public void Seek(){} // RVA: 0x7630190
        public void FlushAsync(){} // RVA: 0x7250AA0
        public void Flush(){} // RVA: 0x6E861D0
        public void CheckDisposed(){} // RVA: 0x76301F0
        public void Dispose(){} // RVA: 0x7630260
        public void Read(){} // RVA: 0x7630360
        public void Write(){} // RVA: 0x76303C0
        public void ReadAsync(){} // RVA: 0x7630420
        public void WriteAsync(){} // RVA: 0x7630480
        public void BeginRead(){} // RVA: 0x76304E0
        public void EndRead(){} // RVA: 0x76305B0
        public void BeginWrite(){} // RVA: 0x76305F0
        public void EndWrite(){} // RVA: 0x66E7340
    }

}