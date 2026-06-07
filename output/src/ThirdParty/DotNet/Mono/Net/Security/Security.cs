// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Net.Security
// Classes: 19
// Methods: 201

namespace ThirdParty.DotNet.Mono.Net.Security
{
    public class AsyncHandshakeRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x668A020
        public void Run(){} // RVA: 0x668A030
    }

    public class AsyncProtocolRequest
    {
        // ── Methods ──
        public void get_Parent(){} // RVA: 0x2F8380
        public void get_RunSynchronously(){} // RVA: 0x2F84E0
        public void get_Name(){} // RVA: 0x197D840
        public void get_UserResult(){} // RVA: 0x197C3B0
        public void set_UserResult(){} // RVA: 0x1989FD0
        public void .ctor(){} // RVA: 0x6688850
        public void RequestRead(){} // RVA: 0x6688950
        public void RequestWrite(){} // RVA: 0x6688A90
        public void StartOperation(){} // RVA: 0x6688AA0
        public void ProcessOperation(){} // RVA: 0x6688CA0
        public void InnerRead(){} // RVA: 0x6688EC0
        public void Run(){} // RVA: 0x13FB0
        public void ToString(){} // RVA: 0x66890C0
    }

    public class AsyncProtocolResult
    {
        // ── Methods ──
        public void get_UserResult(){} // RVA: 0x32A5C0
        public void get_Error(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x343E80 | overloaded x2
    }

    public class AsyncReadOrWriteRequest
    {
        // ── Methods ──
        public void get_UserBuffer(){} // RVA: 0x4976A0
        public void get_CurrentSize(){} // RVA: 0x37E080
        public void set_CurrentSize(){} // RVA: 0x37E090
        public void .ctor(){} // RVA: 0x668A060
        public void ToString(){} // RVA: 0x668A140
    }

    public class AsyncReadRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x668A200
        public void Run(){} // RVA: 0x668A210
    }

    public class AsyncWriteRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x668A200
        public void Run(){} // RVA: 0x668A290
    }

    public class BufferOffsetSize
    {
        // ── Methods ──
        public void get_EndOffset(){} // RVA: 0x6688210
        public void get_Remaining(){} // RVA: 0x6688220
        public void .ctor(){} // RVA: 0x6688250
        public void ToString(){} // RVA: 0x6688380
    }

    public class BufferOffsetSize2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6688450
        public void Reset(){} // RVA: 0x6688560
        public void MakeRoom(){} // RVA: 0x6688600
        public void AppendData(){} // RVA: 0x6688710
    }

    public class ChainValidationHelper
    {
        // ── Methods ──
        public void GetInternalValidator(){} // RVA: 0x668A330
        public void Create(){} // RVA: 0x668A420
        public void .ctor(){} // RVA: 0x668A500
        public void GetValidationCallback(){} // RVA: 0x668AD70
        public void DefaultSelectionCallback(){} // RVA: 0x668AEB0
        public void get_Settings(){} // RVA: 0x2E07C0
        public void SelectClientCertificate(){} // RVA: 0x668AF00
        public void ValidateCertificate(){} // RVA: 0x668AFF0
        public void ValidateChain(){} // RVA: 0x668B170 | overloaded x2
        public void InvokeCallback(){} // RVA: 0x668B660
    }

    public class MobileAuthenticatedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x668B8F0
        public void get_SslStream(){} // RVA: 0x31C010
        public void get_Settings(){} // RVA: 0x796DE0
        public void get_Provider(){} // RVA: 0xA1C8C0
        public void get_TargetHost(){} // RVA: 0xA085E0
        public void set_TargetHost(){} // RVA: 0x9AA5F0
        public void CheckThrow(){} // RVA: 0x668BC20
        public void GetSSPIException(){} // RVA: 0x668BD20
        public void GetIOException(){} // RVA: 0x668BEC0
        public void GetInternalError(){} // RVA: 0x668C060
        public void GetInvalidNestedCallException(){} // RVA: 0x668C0B0
        public void SetException(){} // RVA: 0x668C100
        public void AuthenticateAsClient(){} // RVA: 0x668C230
        public void AuthenticateAsServer(){} // RVA: 0x668C3F0
        public void AuthenticateAsClientAsync(){} // RVA: 0x668C600
        public void ProcessAuthentication(){} // RVA: 0x668C750
        public void CreateContext(){} // RVA: 0xCE10
        public void Read(){} // RVA: 0x668C9E0
        public void Write(){} // RVA: 0x668CAE0
        public void ReadAsync(){} // RVA: 0x668CBE0
        public void WriteAsync(){} // RVA: 0x668CC90
        public void StartOperation(){} // RVA: 0x668CD40
        public void InternalRead(){} // RVA: 0x668D180 | overloaded x2
        public void InternalWrite(){} // RVA: 0x668D450 | overloaded x2
        public void InnerRead(){} // RVA: 0x668D640
        public void InnerWrite(){} // RVA: 0x668D870
        public void ProcessHandshake(){} // RVA: 0x668DAB0
        public void ProcessRead(){} // RVA: 0x668DEC0
        public void ProcessWrite(){} // RVA: 0x668E0C0
        public void get_IsAuthenticated(){} // RVA: 0x668E2C0
        public void Dispose(){} // RVA: 0x668E440
        public void Flush(){} // RVA: 0x6415940
        public void get_LocalCertificate(){} // RVA: 0x668E770
        public void get_InternalLocalCertificate(){} // RVA: 0x668E940
        public void Seek(){} // RVA: 0x668EB10
        public void SetLength(){} // RVA: 0x668EB50
        public void get_CanRead(){} // RVA: 0x668EB80
        public void get_CanTimeout(){} // RVA: 0x668EBD0
        public void get_CanWrite(){} // RVA: 0x668EC00
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_Length(){} // RVA: 0x668EC70
        public void get_Position(){} // RVA: 0x668ECA0
        public void set_Position(){} // RVA: 0x668ECD0
        public void get_ReadTimeout(){} // RVA: 0x668ED10
        public void set_ReadTimeout(){} // RVA: 0x668ED40
        public void get_WriteTimeout(){} // RVA: 0x668ED70
        public void set_WriteTimeout(){} // RVA: 0x668EDA0
        public void .cctor(){} // RVA: 0x668EDD0
        public void <InnerWrite>b__67_0(){} // RVA: 0x668EE10
    }

    public class MobileTlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6691370
        public void get_Options(){} // RVA: 0x2E07C0
        public void get_Parent(){} // RVA: 0x30B0C0
        public void get_Settings(){} // RVA: 0x66917D0
        public void get_IsAuthenticated(){} // RVA: 0xDBE0
        public void get_IsServer(){} // RVA: 0x6E8A80
        public void get_TargetHost(){} // RVA: 0x6374D0
        public void get_ServerName(){} // RVA: 0x4976A0
        public void get_AskForClientCertificate(){} // RVA: 0x398C00
        public void get_EnabledProtocols(){} // RVA: 0x37E0A0
        public void get_ClientCertificates(){} // RVA: 0x358730
        public void GetProtocolVersions(){} // RVA: 0x66917F0
        public void StartHandshake(){} // RVA: 0x24A50
        public void ProcessHandshake(){} // RVA: 0xDBE0
        public void FinishHandshake(){} // RVA: 0x24A50
        public void get_LocalServerCertificate(){} // RVA: 0x37E0E0
        public void set_LocalServerCertificate(){} // RVA: 0x4354D0
        public void get_LocalClientCertificate(){} // RVA: 0xCD60
        public void get_RemoteCertificate(){} // RVA: 0xCD60
        public void Flush(){} // RVA: 0x24A50
        public void Read(){}
        public void Write(){}
        public void Shutdown(){} // RVA: 0x24A50
        public void PendingRenegotiation(){} // RVA: 0xDBE0
        public void ValidateCertificate(){} // RVA: 0x66918F0
        public void SelectServerCertificate(){} // RVA: 0x6691950
        public void SelectClientCertificate(){} // RVA: 0x6691C70
        public void Renegotiate(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void Finalize(){} // RVA: 0x66923A0
    }

    public class MobileTlsProvider
    {
        // ── Methods ──
        public void CreateSslStream(){}
        public void ValidateCertificate(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MonoSslAuthenticationOptions
    {
        // ── Methods ──
        public void get_ServerMode(){} // RVA: 0xDBE0
        public void get_AllowRenegotiation(){} // RVA: 0xDBE0
        public void get_EnabledSslProtocols(){} // RVA: 0xD840
        public void set_EnabledSslProtocols(){} // RVA: 0x24FA0
        public void set_EncryptionPolicy(){} // RVA: 0x24FA0
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x24FA0
        public void get_TargetHost(){} // RVA: 0xCD60
        public void set_TargetHost(){} // RVA: 0x24B10
        public void get_ServerCertificate(){} // RVA: 0xCD60
        public void set_ServerCertificate(){} // RVA: 0x24B10
        public void get_ClientCertificates(){} // RVA: 0xCD60
        public void set_ClientCertificates(){} // RVA: 0x24B10
        public void get_ClientCertificateRequired(){} // RVA: 0xDBE0
        public void set_ClientCertificateRequired(){} // RVA: 0x25130
        public void get_ServerCertSelectionDelegate(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MonoSslClientAuthenticationOptions
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x2E07C0
        public void get_ServerMode(){} // RVA: 0x2DD320
        public void .ctor(){} // RVA: 0x66923F0
        public void get_AllowRenegotiation(){} // RVA: 0x6692480
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x66924A0
        public void set_EncryptionPolicy(){} // RVA: 0x6692550
        public void get_EnabledSslProtocols(){} // RVA: 0x33B7190
        public void set_EnabledSslProtocols(){} // RVA: 0x6692600
        public void get_TargetHost(){} // RVA: 0x606D2F0
        public void set_TargetHost(){} // RVA: 0x6692620
        public void get_ClientCertificateRequired(){} // RVA: 0x6692690
        public void set_ClientCertificateRequired(){} // RVA: 0x66926D0
        public void get_ClientCertificates(){} // RVA: 0x606D2D0
        public void set_ClientCertificates(){} // RVA: 0x6692710
        public void get_ServerCertificate(){} // RVA: 0x6692780
        public void set_ServerCertificate(){} // RVA: 0x66927C0
    }

    public class MonoSslServerAuthenticationOptions
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x2E07C0
        public void get_ServerMode(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x6692800
        public void get_AllowRenegotiation(){} // RVA: 0x6692480
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x6692890
        public void set_EncryptionPolicy(){} // RVA: 0x6692940
        public void get_EnabledSslProtocols(){} // RVA: 0x66929F0
        public void set_EnabledSslProtocols(){} // RVA: 0x6692A10
        public void get_ClientCertificateRequired(){} // RVA: 0x6692A30
        public void set_ClientCertificateRequired(){} // RVA: 0x6692A50
        public void get_TargetHost(){} // RVA: 0x6692A70
        public void set_TargetHost(){} // RVA: 0x6692AB0
        public void get_ServerCertificate(){} // RVA: 0x1C98E90
        public void set_ServerCertificate(){} // RVA: 0x606D240
        public void get_ClientCertificates(){} // RVA: 0x6692AF0
        public void set_ClientCertificates(){} // RVA: 0x6692B30
    }

    public class MonoTlsProviderFactory
    {
        // ── Methods ──
        public void GetProviderInternal(){} // RVA: 0x6692B70
        public void InitializeInternal(){} // RVA: 0x6692D20
        public void LookupProvider(){} // RVA: 0x6693220
        public void InitializeProviderRegistration(){} // RVA: 0x66939A0
        public void PopulateUnityProviders(){} // RVA: 0x6694010
        public void PopulateProviders(){} // RVA: 0x66941D0
        public void IsBtlsSupported(){} // RVA: 0x2DD320
        public void CreateDefaultProviderImpl(){} // RVA: 0x66942A0
        public void GetProvider(){} // RVA: 0x6694510
        public void .cctor(){} // RVA: 0x6694560
    }

    public class MonoTlsStream
    {
        // ── Methods ──
        public void get_Request(){} // RVA: 0x30B0C0
        public void get_ExceptionStatus(){} // RVA: 0x37E080
        public void get_CertificateValidationFailed(){} // RVA: 0x1AF8C70
        public void set_CertificateValidationFailed(){} // RVA: 0x1AF8C60
        public void .ctor(){} // RVA: 0x6694980
        public void CreateStream(){} // RVA: 0x6694D70
        public void Dispose(){} // RVA: 0x6694FD0
        public void CloseSslStream(){} // RVA: 0x6694FE0
    }

    public class NoReflectionHelper
    {
        // ── Methods ──
        public void GetProvider(){} // RVA: 0x6695B30
    }

    public class SystemCertificateValidator
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6695BB0
        public void NeedsChain(){} // RVA: 0x2DD320
    }

}