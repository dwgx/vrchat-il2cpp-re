// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Net.Security
// Classes: 19
// Methods: 201

namespace ThirdParty.DotNet.Mono.Net.Security
{
    public class AsyncHandshakeRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF913A020
        public void Run(){} // RVA: 0x7FFAF913A030
    }

    public class AsyncProtocolRequest
    {
        // ── Methods ──
        public void get_Parent(){} // RVA: 0x7FFAF2DA8380
        public void get_RunSynchronously(){} // RVA: 0x7FFAF2DA84E0
        public void get_Name(){} // RVA: 0x7FFAF442D840
        public void get_UserResult(){} // RVA: 0x7FFAF442C3B0
        public void set_UserResult(){} // RVA: 0x7FFAF4439FD0
        public void .ctor(){} // RVA: 0x7FFAF9138850
        public void RequestRead(){} // RVA: 0x7FFAF9138950
        public void RequestWrite(){} // RVA: 0x7FFAF9138A90
        public void StartOperation(){} // RVA: 0x7FFAF9138AA0
        public void ProcessOperation(){} // RVA: 0x7FFAF9138CA0
        public void InnerRead(){} // RVA: 0x7FFAF9138EC0
        public void Run(){} // RVA: 0x7FFAF2AC3FB0
        public void ToString(){} // RVA: 0x7FFAF91390C0
    }

    public class AsyncProtocolResult
    {
        // ── Methods ──
        public void get_UserResult(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Error(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF2DF3E80 | overloaded x2
    }

    public class AsyncReadOrWriteRequest
    {
        // ── Methods ──
        public void get_UserBuffer(){} // RVA: 0x7FFAF2F476A0
        public void get_CurrentSize(){} // RVA: 0x7FFAF2E2E080
        public void set_CurrentSize(){} // RVA: 0x7FFAF2E2E090
        public void .ctor(){} // RVA: 0x7FFAF913A060
        public void ToString(){} // RVA: 0x7FFAF913A140
    }

    public class AsyncReadRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF913A200
        public void Run(){} // RVA: 0x7FFAF913A210
    }

    public class AsyncWriteRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF913A200
        public void Run(){} // RVA: 0x7FFAF913A290
    }

    public class BufferOffsetSize
    {
        // ── Methods ──
        public void get_EndOffset(){} // RVA: 0x7FFAF9138210
        public void get_Remaining(){} // RVA: 0x7FFAF9138220
        public void .ctor(){} // RVA: 0x7FFAF9138250
        public void ToString(){} // RVA: 0x7FFAF9138380
    }

    public class BufferOffsetSize2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9138450
        public void Reset(){} // RVA: 0x7FFAF9138560
        public void MakeRoom(){} // RVA: 0x7FFAF9138600
        public void AppendData(){} // RVA: 0x7FFAF9138710
    }

    public class ChainValidationHelper
    {
        // ── Methods ──
        public void GetInternalValidator(){} // RVA: 0x7FFAF913A330
        public void Create(){} // RVA: 0x7FFAF913A420
        public void .ctor(){} // RVA: 0x7FFAF913A500
        public void GetValidationCallback(){} // RVA: 0x7FFAF913AD70
        public void DefaultSelectionCallback(){} // RVA: 0x7FFAF913AEB0
        public void get_Settings(){} // RVA: 0x7FFAF2D907C0
        public void SelectClientCertificate(){} // RVA: 0x7FFAF913AF00
        public void ValidateCertificate(){} // RVA: 0x7FFAF913AFF0
        public void ValidateChain(){} // RVA: 0x7FFAF913B170 | overloaded x2
        public void InvokeCallback(){} // RVA: 0x7FFAF913B660
    }

    public class MobileAuthenticatedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF913B8F0
        public void get_SslStream(){} // RVA: 0x7FFAF2DCC010
        public void get_Settings(){} // RVA: 0x7FFAF3246DE0
        public void get_Provider(){} // RVA: 0x7FFAF34CC8C0
        public void get_TargetHost(){} // RVA: 0x7FFAF34B85E0
        public void set_TargetHost(){} // RVA: 0x7FFAF345A5F0
        public void CheckThrow(){} // RVA: 0x7FFAF913BC20
        public void GetSSPIException(){} // RVA: 0x7FFAF913BD20
        public void GetIOException(){} // RVA: 0x7FFAF913BEC0
        public void GetInternalError(){} // RVA: 0x7FFAF913C060
        public void GetInvalidNestedCallException(){} // RVA: 0x7FFAF913C0B0
        public void SetException(){} // RVA: 0x7FFAF913C100
        public void AuthenticateAsClient(){} // RVA: 0x7FFAF913C230
        public void AuthenticateAsServer(){} // RVA: 0x7FFAF913C3F0
        public void AuthenticateAsClientAsync(){} // RVA: 0x7FFAF913C600
        public void ProcessAuthentication(){} // RVA: 0x7FFAF913C750
        public void CreateContext(){} // RVA: 0x7FFAF2ABCE10
        public void Read(){} // RVA: 0x7FFAF913C9E0
        public void Write(){} // RVA: 0x7FFAF913CAE0
        public void ReadAsync(){} // RVA: 0x7FFAF913CBE0
        public void WriteAsync(){} // RVA: 0x7FFAF913CC90
        public void StartOperation(){} // RVA: 0x7FFAF913CD40
        public void InternalRead(){} // RVA: 0x7FFAF913D180 | overloaded x2
        public void InternalWrite(){} // RVA: 0x7FFAF913D450 | overloaded x2
        public void InnerRead(){} // RVA: 0x7FFAF913D640
        public void InnerWrite(){} // RVA: 0x7FFAF913D870
        public void ProcessHandshake(){} // RVA: 0x7FFAF913DAB0
        public void ProcessRead(){} // RVA: 0x7FFAF913DEC0
        public void ProcessWrite(){} // RVA: 0x7FFAF913E0C0
        public void get_IsAuthenticated(){} // RVA: 0x7FFAF913E2C0
        public void Dispose(){} // RVA: 0x7FFAF913E440
        public void Flush(){} // RVA: 0x7FFAF8EC5940
        public void get_LocalCertificate(){} // RVA: 0x7FFAF913E770
        public void get_InternalLocalCertificate(){} // RVA: 0x7FFAF913E940
        public void Seek(){} // RVA: 0x7FFAF913EB10
        public void SetLength(){} // RVA: 0x7FFAF913EB50
        public void get_CanRead(){} // RVA: 0x7FFAF913EB80
        public void get_CanTimeout(){} // RVA: 0x7FFAF913EBD0
        public void get_CanWrite(){} // RVA: 0x7FFAF913EC00
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_Length(){} // RVA: 0x7FFAF913EC70
        public void get_Position(){} // RVA: 0x7FFAF913ECA0
        public void set_Position(){} // RVA: 0x7FFAF913ECD0
        public void get_ReadTimeout(){} // RVA: 0x7FFAF913ED10
        public void set_ReadTimeout(){} // RVA: 0x7FFAF913ED40
        public void get_WriteTimeout(){} // RVA: 0x7FFAF913ED70
        public void set_WriteTimeout(){} // RVA: 0x7FFAF913EDA0
        public void .cctor(){} // RVA: 0x7FFAF913EDD0
        public void <InnerWrite>b__67_0(){} // RVA: 0x7FFAF913EE10
    }

    public class MobileTlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9141370
        public void get_Options(){} // RVA: 0x7FFAF2D907C0
        public void get_Parent(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Settings(){} // RVA: 0x7FFAF91417D0
        public void get_IsAuthenticated(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsServer(){} // RVA: 0x7FFAF3198A80
        public void get_TargetHost(){} // RVA: 0x7FFAF30E74D0
        public void get_ServerName(){} // RVA: 0x7FFAF2F476A0
        public void get_AskForClientCertificate(){} // RVA: 0x7FFAF2E48C00
        public void get_EnabledProtocols(){} // RVA: 0x7FFAF2E2E0A0
        public void get_ClientCertificates(){} // RVA: 0x7FFAF2E08730
        public void GetProtocolVersions(){} // RVA: 0x7FFAF91417F0
        public void StartHandshake(){} // RVA: 0x7FFAF2AD4A50
        public void ProcessHandshake(){} // RVA: 0x7FFAF2ABDBE0
        public void FinishHandshake(){} // RVA: 0x7FFAF2AD4A50
        public void get_LocalServerCertificate(){} // RVA: 0x7FFAF2E2E0E0
        public void set_LocalServerCertificate(){} // RVA: 0x7FFAF2EE54D0
        public void get_LocalClientCertificate(){} // RVA: 0x7FFAF2ABCD60
        public void get_RemoteCertificate(){} // RVA: 0x7FFAF2ABCD60
        public void Flush(){} // RVA: 0x7FFAF2AD4A50
        public void Read(){}
        public void Write(){}
        public void Shutdown(){} // RVA: 0x7FFAF2AD4A50
        public void PendingRenegotiation(){} // RVA: 0x7FFAF2ABDBE0
        public void ValidateCertificate(){} // RVA: 0x7FFAF91418F0
        public void SelectServerCertificate(){} // RVA: 0x7FFAF9141950
        public void SelectClientCertificate(){} // RVA: 0x7FFAF9141C70
        public void Renegotiate(){} // RVA: 0x7FFAF2AD4A50
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF91423A0
    }

    public class MobileTlsProvider
    {
        // ── Methods ──
        public void CreateSslStream(){}
        public void ValidateCertificate(){}
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class MonoSslAuthenticationOptions
    {
        // ── Methods ──
        public void get_ServerMode(){} // RVA: 0x7FFAF2ABDBE0
        public void get_AllowRenegotiation(){} // RVA: 0x7FFAF2ABDBE0
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFAF2ABD840
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFAF2AD4FA0
        public void set_EncryptionPolicy(){} // RVA: 0x7FFAF2AD4FA0
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFAF2AD4FA0
        public void get_TargetHost(){} // RVA: 0x7FFAF2ABCD60
        public void set_TargetHost(){} // RVA: 0x7FFAF2AD4B10
        public void get_ServerCertificate(){} // RVA: 0x7FFAF2ABCD60
        public void set_ServerCertificate(){} // RVA: 0x7FFAF2AD4B10
        public void get_ClientCertificates(){} // RVA: 0x7FFAF2ABCD60
        public void set_ClientCertificates(){} // RVA: 0x7FFAF2AD4B10
        public void get_ClientCertificateRequired(){} // RVA: 0x7FFAF2ABDBE0
        public void set_ClientCertificateRequired(){} // RVA: 0x7FFAF2AD5130
        public void get_ServerCertSelectionDelegate(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class MonoSslClientAuthenticationOptions
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFAF2D907C0
        public void get_ServerMode(){} // RVA: 0x7FFAF2D8D320
        public void .ctor(){} // RVA: 0x7FFAF91423F0
        public void get_AllowRenegotiation(){} // RVA: 0x7FFAF9142480
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFAF91424A0
        public void set_EncryptionPolicy(){} // RVA: 0x7FFAF9142550
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFAF5E67190
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFAF9142600
        public void get_TargetHost(){} // RVA: 0x7FFAF8B1D2F0
        public void set_TargetHost(){} // RVA: 0x7FFAF9142620
        public void get_ClientCertificateRequired(){} // RVA: 0x7FFAF9142690
        public void set_ClientCertificateRequired(){} // RVA: 0x7FFAF91426D0
        public void get_ClientCertificates(){} // RVA: 0x7FFAF8B1D2D0
        public void set_ClientCertificates(){} // RVA: 0x7FFAF9142710
        public void get_ServerCertificate(){} // RVA: 0x7FFAF9142780
        public void set_ServerCertificate(){} // RVA: 0x7FFAF91427C0
    }

    public class MonoSslServerAuthenticationOptions
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFAF2D907C0
        public void get_ServerMode(){} // RVA: 0x7FFAF2E72850
        public void .ctor(){} // RVA: 0x7FFAF9142800
        public void get_AllowRenegotiation(){} // RVA: 0x7FFAF9142480
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFAF9142890
        public void set_EncryptionPolicy(){} // RVA: 0x7FFAF9142940
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFAF91429F0
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFAF9142A10
        public void get_ClientCertificateRequired(){} // RVA: 0x7FFAF9142A30
        public void set_ClientCertificateRequired(){} // RVA: 0x7FFAF9142A50
        public void get_TargetHost(){} // RVA: 0x7FFAF9142A70
        public void set_TargetHost(){} // RVA: 0x7FFAF9142AB0
        public void get_ServerCertificate(){} // RVA: 0x7FFAF4748E90
        public void set_ServerCertificate(){} // RVA: 0x7FFAF8B1D240
        public void get_ClientCertificates(){} // RVA: 0x7FFAF9142AF0
        public void set_ClientCertificates(){} // RVA: 0x7FFAF9142B30
    }

    public class MonoTlsProviderFactory
    {
        // ── Methods ──
        public void GetProviderInternal(){} // RVA: 0x7FFAF9142B70
        public void InitializeInternal(){} // RVA: 0x7FFAF9142D20
        public void LookupProvider(){} // RVA: 0x7FFAF9143220
        public void InitializeProviderRegistration(){} // RVA: 0x7FFAF91439A0
        public void PopulateUnityProviders(){} // RVA: 0x7FFAF9144010
        public void PopulateProviders(){} // RVA: 0x7FFAF91441D0
        public void IsBtlsSupported(){} // RVA: 0x7FFAF2D8D320
        public void CreateDefaultProviderImpl(){} // RVA: 0x7FFAF91442A0
        public void GetProvider(){} // RVA: 0x7FFAF9144510
        public void .cctor(){} // RVA: 0x7FFAF9144560
    }

    public class MonoTlsStream
    {
        // ── Methods ──
        public void get_Request(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ExceptionStatus(){} // RVA: 0x7FFAF2E2E080
        public void get_CertificateValidationFailed(){} // RVA: 0x7FFAF45A8C70
        public void set_CertificateValidationFailed(){} // RVA: 0x7FFAF45A8C60
        public void .ctor(){} // RVA: 0x7FFAF9144980
        public void CreateStream(){} // RVA: 0x7FFAF9144D70
        public void Dispose(){} // RVA: 0x7FFAF9144FD0
        public void CloseSslStream(){} // RVA: 0x7FFAF9144FE0
    }

    public class NoReflectionHelper
    {
        // ── Methods ──
        public void GetProvider(){} // RVA: 0x7FFAF9145B30
    }

    public class SystemCertificateValidator
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF9145BB0
        public void NeedsChain(){} // RVA: 0x7FFAF2D8D320
    }

}