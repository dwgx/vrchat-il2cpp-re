// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Net.Security
// Classes: 19
// Methods: 196

namespace ThirdParty.DotNet.Mono.Net.Security
{
    public class AsyncHandshakeRequest : AsyncProtocolRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4787E0
        public void Run(){} // RVA: 0x7AE4787F0
    }

    public class AsyncProtocolRequest : Object
    {
        // ── Methods ──
        public void get_Parent(){} // RVA: 0x7A80F2570
        public void get_RunSynchronously(){} // RVA: 0x7A80F26D0
        public void get_Name(){} // RVA: 0x7A973A680
        public void get_UserResult(){} // RVA: 0x7A9739200
        public void set_UserResult(){} // RVA: 0x7A9746990
        public void .ctor(){} // RVA: 0x7AE477050
        public void RequestRead(){} // RVA: 0x7AE477150
        public void RequestWrite(){} // RVA: 0x7AE477250
        public void StartOperation(){} // RVA: 0x7AE477260
        public void ProcessOperation(){} // RVA: 0x7AE477460
        public void InnerRead(){} // RVA: 0x7AE477680
        public void Run(){} // RVA: 0x7A7E062A0
        public void ToString(){} // RVA: 0x7AE477880
    }

    public class AsyncProtocolResult : Object
    {
        // ── Methods ──
        public void get_UserResult(){} // RVA: 0x7A8124910
        public void get_Error(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A813E420
    }

    public class AsyncReadOrWriteRequest : AsyncProtocolRequest
    {
        // ── Methods ──
        public void get_UserBuffer(){} // RVA: 0x7A8292C30
        public void get_CurrentSize(){} // RVA: 0x7A8178B30
        public void set_CurrentSize(){} // RVA: 0x7A8178B40
        public void .ctor(){} // RVA: 0x7AE478820
        public void ToString(){} // RVA: 0x7AE478900
    }

    public class AsyncReadRequest : AsyncReadOrWriteRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4789C0
        public void Run(){} // RVA: 0x7AE4789D0
    }

    public class AsyncWriteRequest : AsyncReadOrWriteRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4789C0
        public void Run(){} // RVA: 0x7AE478A50
    }

    public class BufferOffsetSize : Object
    {
        // ── Methods ──
        public void get_EndOffset(){} // RVA: 0x7AE4769D0
        public void get_Remaining(){} // RVA: 0x7AE4769E0
        public void .ctor(){} // RVA: 0x7AE476A10
        public void ToString(){} // RVA: 0x7AE476B40
    }

    public class BufferOffsetSize2 : BufferOffsetSize
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE476C10
        public void Reset(){} // RVA: 0x7AE476D20
        public void MakeRoom(){} // RVA: 0x7AE476DC0
        public void AppendData(){} // RVA: 0x7AE476EE0
    }

    public class ChainValidationHelper : Object
    {
        // ── Methods ──
        public void GetInternalValidator(){} // RVA: 0x7AE478AF0
        public void Create(){} // RVA: 0x7AE478BE0
        public void .ctor(){} // RVA: 0x7AE478CD0
        public void GetValidationCallback(){} // RVA: 0x7AE479540
        public void DefaultSelectionCallback(){} // RVA: 0x7AE479680
        public void get_Settings(){} // RVA: 0x7A80DA7B0
        public void SelectClientCertificate(){} // RVA: 0x7AE4796D0
        public void ValidateCertificate(){} // RVA: 0x7AE4797C0
        public void ValidateChain(){} // RVA: 0x7AE479940
        public void InvokeCallback(){} // RVA: 0x7AE479E40
    }

    public class MobileAuthenticatedStream : AuthenticatedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE47A0B0
        public void get_SslStream(){} // RVA: 0x7A81163D0
        public void get_Settings(){} // RVA: 0x7A8555100
        public void get_Provider(){} // RVA: 0x7A87D9C10
        public void get_TargetHost(){} // RVA: 0x7A87C5850
        public void set_TargetHost(){} // RVA: 0x7A87446C0
        public void CheckThrow(){} // RVA: 0x7AE47A3E0
        public void GetSSPIException(){} // RVA: 0x7AE47A4E0
        public void GetIOException(){} // RVA: 0x7AE47A680
        public void GetInternalError(){} // RVA: 0x7AE47A820
        public void GetInvalidNestedCallException(){} // RVA: 0x7AE47A870
        public void SetException(){} // RVA: 0x7AE47A8C0
        public void AuthenticateAsClient(){} // RVA: 0x7AE47A9F0
        public void AuthenticateAsServer(){} // RVA: 0x7AE47ABB0
        public void AuthenticateAsClientAsync(){} // RVA: 0x7AE47ADD0
        public void ProcessAuthentication(){} // RVA: 0x7AE47AF20
        public void CreateContext(){} // RVA: 0x7A7E00B20
        public void Read(){} // RVA: 0x7AE47B1B0
        public void Write(){} // RVA: 0x7AE47B2B0
        public void ReadAsync(){} // RVA: 0x7AE47B3B0
        public void WriteAsync(){} // RVA: 0x7AE47B460
        public void StartOperation(){} // RVA: 0x7AE47B510
        public void InternalRead(){} // RVA: 0x7AE47B950
        public void InternalWrite(){} // RVA: 0x7AE47BC30
        public void InnerRead(){} // RVA: 0x7AE47BE40
        public void InnerWrite(){} // RVA: 0x7AE47C070
        public void ProcessHandshake(){} // RVA: 0x7AE47C2B0
        public void ProcessRead(){} // RVA: 0x7AE47C680
        public void ProcessWrite(){} // RVA: 0x7AE47C840
        public void get_IsAuthenticated(){} // RVA: 0x7AE47CA00
        public void Dispose(){} // RVA: 0x7AE47CB40
        public void Flush(){} // RVA: 0x7AE203670
        public void get_LocalCertificate(){} // RVA: 0x7AE47CE40
        public void get_InternalLocalCertificate(){} // RVA: 0x7AE47CFE0
        public void Seek(){} // RVA: 0x7AE47D180
        public void SetLength(){} // RVA: 0x7AE47D1C0
        public void get_CanRead(){} // RVA: 0x7AE47D1F0
        public void get_CanTimeout(){} // RVA: 0x7AE47D240
        public void get_CanWrite(){} // RVA: 0x7AE47D270
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_Length(){} // RVA: 0x7AE47D2E0
        public void get_Position(){} // RVA: 0x7AE47D310
        public void set_Position(){} // RVA: 0x7AE47D340
        public void get_ReadTimeout(){} // RVA: 0x7AE47D380
        public void set_ReadTimeout(){} // RVA: 0x7AE47D3B0
        public void get_WriteTimeout(){} // RVA: 0x7AE47D3E0
        public void set_WriteTimeout(){} // RVA: 0x7AE47D410
        public void .cctor(){} // RVA: 0x7AE47D440
        public void <InnerWrite>b__67_0(){} // RVA: 0x7AE47D480
    }

    public class MobileTlsContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE47F900
        public void get_Options(){} // RVA: 0x7A80DA7B0
        public void get_Parent(){} // RVA: 0x7A81052C0
        public void get_Settings(){} // RVA: 0x7AE47FD60
        public void get_IsAuthenticated(){} // RVA: 0x7A7E01900
        public void get_IsServer(){} // RVA: 0x7A84A5BD0
        public void get_TargetHost(){} // RVA: 0x7A83F69F0
        public void get_ServerName(){} // RVA: 0x7A8292C30
        public void get_AskForClientCertificate(){} // RVA: 0x7A8193790
        public void get_EnabledProtocols(){} // RVA: 0x7A8178B50
        public void get_ClientCertificates(){} // RVA: 0x7A8152D80
        public void GetProtocolVersions(){} // RVA: 0x7AE47FD80
        public void StartHandshake(){} // RVA: 0x7A7E18770
        public void ProcessHandshake(){} // RVA: 0x7A7E01900
        public void FinishHandshake(){} // RVA: 0x7A7E18770
        public void get_LocalServerCertificate(){} // RVA: 0x7A8178B90
        public void set_LocalServerCertificate(){} // RVA: 0x7A8230620
        public void get_LocalClientCertificate(){} // RVA: 0x7A7E00680
        public void get_RemoteCertificate(){} // RVA: 0x7A7E00680
        public void Flush(){} // RVA: 0x7A7E18770
        public void Read(){} // RVA: 0x7A7E017C0
        public void Write(){} // RVA: 0x7A7E017C0
        public void Shutdown(){} // RVA: 0x7A7E18770
        public void PendingRenegotiation(){} // RVA: 0x7A7E01900
        public void ValidateCertificate(){} // RVA: 0x7AE47FE80
        public void SelectServerCertificate(){} // RVA: 0x7AE47FEE0
        public void SelectClientCertificate(){} // RVA: 0x7AE480200
        public void Renegotiate(){} // RVA: 0x7A7E18770
        public void Dispose(){} // RVA: 0x7A80D7310
        public void Finalize(){} // RVA: 0x7AE480930
    }

    public class MobileTlsProvider : MonoTlsProvider
    {
        // ── Methods ──
        public void CreateSslStream(){} // RVA: 0x7A7E12600
        public void ValidateCertificate(){} // RVA: 0x7A7E04F50
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class MonoSslAuthenticationOptions : Object
    {
        // ── Methods ──
        public void get_ServerMode(){} // RVA: 0x7A7E01900
        public void get_AllowRenegotiation(){} // RVA: 0x7A7E01900
        public void get_EnabledSslProtocols(){} // RVA: 0x7A7E00710
        public void set_EnabledSslProtocols(){} // RVA: 0x7A7E189D0
        public void set_EncryptionPolicy(){} // RVA: 0x7A7E189D0
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7A7E189D0
        public void get_TargetHost(){} // RVA: 0x7A7E00680
        public void set_TargetHost(){} // RVA: 0x7A7E18800
        public void get_ServerCertificate(){} // RVA: 0x7A7E00680
        public void set_ServerCertificate(){} // RVA: 0x7A7E18800
        public void get_ClientCertificates(){} // RVA: 0x7A7E00680
        public void set_ClientCertificates(){} // RVA: 0x7A7E18800
        public void get_ClientCertificateRequired(){} // RVA: 0x7A7E01900
        public void set_ClientCertificateRequired(){} // RVA: 0x7A7E18C30
        public void get_ServerCertSelectionDelegate(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x7A80DA7B0
        public void get_ServerMode(){} // RVA: 0x7A80D7320
        public void .ctor(){} // RVA: 0x7AE480980
        public void get_AllowRenegotiation(){} // RVA: 0x7AE480A10
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7AE480A30
        public void set_EncryptionPolicy(){} // RVA: 0x7AE480AE0
        public void get_EnabledSslProtocols(){} // RVA: 0x7AB1ACB90
        public void set_EnabledSslProtocols(){} // RVA: 0x7AE480B90
        public void get_TargetHost(){} // RVA: 0x7ADE59640
        public void set_TargetHost(){} // RVA: 0x7AE480BB0
        public void get_ClientCertificateRequired(){} // RVA: 0x7AE480C20
        public void set_ClientCertificateRequired(){} // RVA: 0x7AE480C60
        public void get_ClientCertificates(){} // RVA: 0x7ADE59620
        public void set_ClientCertificates(){} // RVA: 0x7AE480CA0
        public void get_ServerCertificate(){} // RVA: 0x7AE480D10
        public void set_ServerCertificate(){} // RVA: 0x7AE480D50
    }

    public class MonoSslServerAuthenticationOptions : MonoSslAuthenticationOptions
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x7A80DA7B0
        public void get_ServerMode(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7AE480D90
        public void get_AllowRenegotiation(){} // RVA: 0x7AE480A10
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7AE480E20
        public void set_EncryptionPolicy(){} // RVA: 0x7AE480ED0
        public void get_EnabledSslProtocols(){} // RVA: 0x7AE480F80
        public void set_EnabledSslProtocols(){} // RVA: 0x7AE480FA0
        public void get_ClientCertificateRequired(){} // RVA: 0x7AE480FC0
        public void set_ClientCertificateRequired(){} // RVA: 0x7AE480FE0
        public void get_TargetHost(){} // RVA: 0x7AE481000
        public void set_TargetHost(){} // RVA: 0x7AE481040
        public void get_ServerCertificate(){} // RVA: 0x7A9A9B340
        public void set_ServerCertificate(){} // RVA: 0x7ADE59590
        public void get_ClientCertificates(){} // RVA: 0x7AE481080
        public void set_ClientCertificates(){} // RVA: 0x7AE4810C0
    }

    public class MonoTlsProviderFactory : Object
    {
        // ── Methods ──
        public void GetProviderInternal(){} // RVA: 0x7AE481100
        public void InitializeInternal(){} // RVA: 0x7AE481290
        public void LookupProvider(){} // RVA: 0x7AE481760
        public void InitializeProviderRegistration(){} // RVA: 0x7AE481EC0
        public void PopulateUnityProviders(){} // RVA: 0x7AE482500
        public void PopulateProviders(){} // RVA: 0x7AE4826C0
        public void IsBtlsSupported(){} // RVA: 0x7A80D7320
        public void CreateDefaultProviderImpl(){} // RVA: 0x7AE482790
        public void GetProvider(){} // RVA: 0x7AE482A00
        public void .cctor(){} // RVA: 0x7AE482A50
    }

    public class MonoTlsStream : Object
    {
        // ── Methods ──
        public void get_Request(){} // RVA: 0x7A81052C0
        public void get_ExceptionStatus(){} // RVA: 0x7A8178B30
        public void get_CertificateValidationFailed(){} // RVA: 0x7A98B2AB0
        public void set_CertificateValidationFailed(){} // RVA: 0x7A98B2AA0
        public void .ctor(){} // RVA: 0x7AE482E70
        public void CreateStream(){} // RVA: 0x7AE483260
        public void Dispose(){} // RVA: 0x7AE4834C0
        public void CloseSslStream(){} // RVA: 0x7AE4834D0
    }

    public class NoReflectionHelper : Object
    {
        // ── Methods ──
        public void GetProvider(){} // RVA: 0x7AE483FE0
    }

    public class SystemCertificateValidator : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE484060
        public void NeedsChain(){} // RVA: 0x7A80D7320
    }

}