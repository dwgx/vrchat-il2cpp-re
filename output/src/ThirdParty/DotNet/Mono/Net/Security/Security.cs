// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Net.Security
// Classes: 19
// Methods: 196

namespace ThirdParty.DotNet.Mono.Net.Security
{
    public class AsyncHandshakeRequest : AsyncProtocolRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70F48D0
        public void Run(){} // RVA: 0x70F48E0
    }

    public class AsyncProtocolRequest : Object
    {
        public object _parent;
        public object _runSynchronously;
        public object _userResult;
        public object Started;
        public object RequestedSize;
        public object WriteRequested;
        public object locker;
        public object next_id;

        // ── Methods ──
        public void get_Parent(){} // RVA: 0xB5DBF0
        public void get_RunSynchronously(){} // RVA: 0xB5DD50
        public void get_Name(){} // RVA: 0x2246540
        public void get_UserResult(){} // RVA: 0x2244FB0
        public void set_UserResult(){} // RVA: 0x22735B0
        public void .ctor(){} // RVA: 0x70F3140
        public void RequestRead(){} // RVA: 0x70F3240
        public void RequestWrite(){} // RVA: 0x70F3340
        public void StartOperation(){} // RVA: 0x70F3350
        public void ProcessOperation(){} // RVA: 0x70F3550
        public void InnerRead(){} // RVA: 0x70F3770
        public void Run(){} // RVA: 0x881C20
        public void ToString(){} // RVA: 0x70F3970
    }

    public class AsyncProtocolResult : Object
    {
        public object _userResult;
        public object _error;

        // ── Methods ──
        public void get_UserResult(){} // RVA: 0xB8F8F0
        public void get_Error(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0xBA9BA0
    }

    public class AsyncReadOrWriteRequest : AsyncProtocolRequest
    {
        public object _userBuffer;
        public object _currentSize;

        // ── Methods ──
        public void get_UserBuffer(){} // RVA: 0xD05CA0
        public void get_CurrentSize(){} // RVA: 0xBE5850
        public void set_CurrentSize(){} // RVA: 0xBE5860
        public void .ctor(){} // RVA: 0x70F4910
        public void ToString(){} // RVA: 0x70F49F0
    }

    public class AsyncReadRequest : AsyncReadOrWriteRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70F4AB0
        public void Run(){} // RVA: 0x70F4AC0
    }

    public class AsyncWriteRequest : AsyncReadOrWriteRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70F4AB0
        public void Run(){} // RVA: 0x70F4B40
    }

    public class BufferOffsetSize : Object
    {
        public object Buffer;
        public object Offset;
        public object Size;
        public object TotalBytes;
        public object Complete;

        // ── Methods ──
        public void get_EndOffset(){} // RVA: 0x70F2AD0
        public void get_Remaining(){} // RVA: 0x70F2AE0
        public void .ctor(){} // RVA: 0x70F2B10
        public void ToString(){} // RVA: 0x70F2C40
    }

    public class BufferOffsetSize2 : BufferOffsetSize
    {
        public object InitialSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70F2D00
        public void Reset(){} // RVA: 0x70F2E10
        public void MakeRoom(){} // RVA: 0x70F2EB0
        public void AppendData(){} // RVA: 0x70F2FD0
    }

    public class ChainValidationHelper : Object
    {
        public object owner;
        public object settings;
        public object provider;
        public object certValidationCallback;
        public object certSelectionCallback;
        public object tlsStream;
        public object request;

        // ── Methods ──
        public void GetInternalValidator(){} // RVA: 0x70F4BE0
        public void Create(){} // RVA: 0x70F4CD0
        public void .ctor(){} // RVA: 0x70F4DC0
        public void GetValidationCallback(){} // RVA: 0x70F5630
        public void DefaultSelectionCallback(){} // RVA: 0x70F5770
        public void get_Settings(){} // RVA: 0xB465B0
        public void SelectClientCertificate(){} // RVA: 0x70F57C0
        public void ValidateCertificate(){} // RVA: 0x70F58B0
        public void ValidateChain(){} // RVA: 0x70F5A30
        public void InvokeCallback(){} // RVA: 0x70F5F30
    }

    public class MobileAuthenticatedStream : AuthenticatedStream
    {
        public object xobileTlsContext;
        public object lastException;
        public object asyncHandshakeRequest;
        public object asyncReadRequest;
        public object asyncWriteRequest;
        public object readBuffer;
        public object writeBuffer;
        public object ioLock;
        public object closeRequested;
        public object shutdown;
        public object operation;
        public object uniqueNameInteger;
        public object _sslStream;
        public object _settings;
        public object _provider;
        public object _targetHost;
        public object nextId;
        public object ID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70F61A0
        public void get_SslStream(){} // RVA: 0xB813B0
        public void get_Settings(){} // RVA: 0x1069350
        public void get_Provider(){} // RVA: 0x106A7D0
        public void get_TargetHost(){} // RVA: 0x106A050
        public void set_TargetHost(){} // RVA: 0xD5CCD0
        public void CheckThrow(){} // RVA: 0x70F64D0
        public void GetSSPIException(){} // RVA: 0x70F65D0
        public void GetIOException(){} // RVA: 0x70F6770
        public void GetInternalError(){} // RVA: 0x70F6910
        public void GetInvalidNestedCallException(){} // RVA: 0x70F6960
        public void SetException(){} // RVA: 0x70F69B0
        public void AuthenticateAsClient(){} // RVA: 0x70F6AE0
        public void AuthenticateAsServer(){} // RVA: 0x70F6CA0
        public void AuthenticateAsClientAsync(){} // RVA: 0x70F6EC0
        public void ProcessAuthentication(){} // RVA: 0x70F7010
        public void CreateContext(){} // RVA: 0x87C540
        public void Read(){} // RVA: 0x70F72A0
        public void Write(){} // RVA: 0x70F73A0
        public void ReadAsync(){} // RVA: 0x70F74A0
        public void WriteAsync(){} // RVA: 0x70F7550
        public void StartOperation(){} // RVA: 0x70F7600
        public void InternalRead(){} // RVA: 0x70F7A40
        public void InternalWrite(){} // RVA: 0x70F7D20
        public void InnerRead(){} // RVA: 0x70F7F30
        public void InnerWrite(){} // RVA: 0x70F8160
        public void ProcessHandshake(){} // RVA: 0x70F83A0
        public void ProcessRead(){} // RVA: 0x70F8770
        public void ProcessWrite(){} // RVA: 0x70F8930
        public void get_IsAuthenticated(){} // RVA: 0x70F8AF0
        public void Dispose(){} // RVA: 0x70F8C30
        public void Flush(){} // RVA: 0x6E861D0
        public void get_LocalCertificate(){} // RVA: 0x70F8F30
        public void get_InternalLocalCertificate(){} // RVA: 0x70F90D0
        public void Seek(){} // RVA: 0x70F9270
        public void SetLength(){} // RVA: 0x70F92B0
        public void get_CanRead(){} // RVA: 0x70F92E0
        public void get_CanTimeout(){} // RVA: 0x70F9330
        public void get_CanWrite(){} // RVA: 0x70F9360
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_Length(){} // RVA: 0x70F93D0
        public void get_Position(){} // RVA: 0x70F9400
        public void set_Position(){} // RVA: 0x70F9430
        public void get_ReadTimeout(){} // RVA: 0x70F9470
        public void set_ReadTimeout(){} // RVA: 0x70F94A0
        public void get_WriteTimeout(){} // RVA: 0x70F94D0
        public void set_WriteTimeout(){} // RVA: 0x70F9500
        public void .cctor(){} // RVA: 0x70F9530
        public void <InnerWrite>b__67_0(){} // RVA: 0x70F9570
    }

    public class MobileTlsContext : Object
    {
        public object certificateValidator;
        public object _options;
        public object _parent;
        public object _isServer;
        public object _targetHost;
        public object _serverName;
        public object _askForClientCertificate;
        public object _enabledProtocols;
        public object _clientCertificates;
        public object _localServerCertificate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70FB9F0
        public void get_Options(){} // RVA: 0xB465B0
        public void get_Parent(){} // RVA: 0xB700F0
        public void get_Settings(){} // RVA: 0x70FBE50
        public void get_IsAuthenticated(){} // RVA: 0x87D280
        public void get_IsServer(){} // RVA: 0xF73960
        public void get_TargetHost(){} // RVA: 0xD33E60
        public void get_ServerName(){} // RVA: 0xD05CA0
        public void get_AskForClientCertificate(){} // RVA: 0xC02470
        public void get_EnabledProtocols(){} // RVA: 0xBE5870
        public void get_ClientCertificates(){} // RVA: 0xBBF8F0
        public void GetProtocolVersions(){} // RVA: 0x70FBE70
        public void StartHandshake(){} // RVA: 0x894290
        public void ProcessHandshake(){} // RVA: 0x87D280
        public void FinishHandshake(){} // RVA: 0x894290
        public void get_LocalServerCertificate(){} // RVA: 0xBE58B0
        public void set_LocalServerCertificate(){} // RVA: 0xCA4DF0
        public void get_LocalClientCertificate(){} // RVA: 0x87C0A0
        public void get_RemoteCertificate(){} // RVA: 0x87C0A0
        public void Flush(){} // RVA: 0x894290
        public void Read(){} // RVA: 0x87D1E0
        public void Write(){} // RVA: 0x87D1E0
        public void Shutdown(){} // RVA: 0x894290
        public void PendingRenegotiation(){} // RVA: 0x87D280
        public void ValidateCertificate(){} // RVA: 0x70FBF70
        public void SelectServerCertificate(){} // RVA: 0x70FBFD0
        public void SelectClientCertificate(){} // RVA: 0x70FC2E0
        public void Renegotiate(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0xB43310
        public void Finalize(){} // RVA: 0x70FCA10
    }

    public class MobileTlsProvider : MonoTlsProvider
    {
        // ── Methods ──
        public void CreateSslStream(){} // RVA: 0x88E090
        public void ValidateCertificate(){} // RVA: 0x8808D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MonoSslAuthenticationOptions : Object
    {
        public object _serverCertSelectionDelegate;

        // ── Methods ──
        public void get_ServerMode(){} // RVA: 0x87D280
        public void get_AllowRenegotiation(){} // RVA: 0x87D280
        public void get_EnabledSslProtocols(){} // RVA: 0x87C130
        public void set_EnabledSslProtocols(){} // RVA: 0x8944F0
        public void set_EncryptionPolicy(){} // RVA: 0x8944F0
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x8944F0
        public void get_TargetHost(){} // RVA: 0x87C0A0
        public void set_TargetHost(){} // RVA: 0x894320
        public void get_ServerCertificate(){} // RVA: 0x87C0A0
        public void set_ServerCertificate(){} // RVA: 0x894320
        public void get_ClientCertificates(){} // RVA: 0x87C0A0
        public void set_ClientCertificates(){} // RVA: 0x894320
        public void get_ClientCertificateRequired(){} // RVA: 0x87D280
        public void set_ClientCertificateRequired(){} // RVA: 0x894750
        public void get_ServerCertSelectionDelegate(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
    {
        public object _options;

        // ── Methods ──
        public void get_Options(){} // RVA: 0xB465B0
        public void get_ServerMode(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0x70FCA60
        public void get_AllowRenegotiation(){} // RVA: 0x70FCAF0
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x70FCB10
        public void set_EncryptionPolicy(){} // RVA: 0x70FCBC0
        public void get_EnabledSslProtocols(){} // RVA: 0x3E42680
        public void set_EnabledSslProtocols(){} // RVA: 0x70FCC70
        public void get_TargetHost(){} // RVA: 0x6AE0BD0
        public void set_TargetHost(){} // RVA: 0x70FCC90
        public void get_ClientCertificateRequired(){} // RVA: 0x70FCD00
        public void set_ClientCertificateRequired(){} // RVA: 0x70FCD40
        public void get_ClientCertificates(){} // RVA: 0x6AE0BB0
        public void set_ClientCertificates(){} // RVA: 0x70FCD80
        public void get_ServerCertificate(){} // RVA: 0x70FCDF0
        public void set_ServerCertificate(){} // RVA: 0x70FCE30
    }

    public class MonoSslServerAuthenticationOptions : MonoSslAuthenticationOptions
    {
        public object _options;

        // ── Methods ──
        public void get_Options(){} // RVA: 0xB465B0
        public void get_ServerMode(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0x70FCE70
        public void get_AllowRenegotiation(){} // RVA: 0x70FCAF0
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x70FCF00
        public void set_EncryptionPolicy(){} // RVA: 0x70FCFB0
        public void get_EnabledSslProtocols(){} // RVA: 0x70FD060
        public void set_EnabledSslProtocols(){} // RVA: 0x70FD080
        public void get_ClientCertificateRequired(){} // RVA: 0x70FD0A0
        public void set_ClientCertificateRequired(){} // RVA: 0x70FD0C0
        public void get_TargetHost(){} // RVA: 0x70FD0E0
        public void set_TargetHost(){} // RVA: 0x70FD120
        public void get_ServerCertificate(){} // RVA: 0x2547880
        public void set_ServerCertificate(){} // RVA: 0x6AE0B20
        public void get_ClientCertificates(){} // RVA: 0x70FD160
        public void set_ClientCertificates(){} // RVA: 0x70FD1A0
    }

    public class MonoTlsProviderFactory : Object
    {
        public object locker;
        public object initialized;
        public object defaultProvider;
        public object providerRegistration;
        public object providerCache;
        public object UnityTlsId;
        public object AppleTlsId;
        public object BtlsId;

        // ── Methods ──
        public void GetProviderInternal(){} // RVA: 0x70FD1E0
        public void InitializeInternal(){} // RVA: 0x70FD370
        public void LookupProvider(){} // RVA: 0x70FD840
        public void InitializeProviderRegistration(){} // RVA: 0x70FDF90
        public void PopulateUnityProviders(){} // RVA: 0x70FE5C0
        public void PopulateProviders(){} // RVA: 0x70FE780
        public void IsBtlsSupported(){} // RVA: 0xB43320
        public void CreateDefaultProviderImpl(){} // RVA: 0x70FE840
        public void GetProvider(){} // RVA: 0x70FEAB0
        public void .cctor(){} // RVA: 0x70FEB00
    }

    public class MonoTlsStream : Object
    {
        public object provider;
        public object networkStream;
        public object request;
        public object settings;
        public object sslStream;
        public object sslStreamLock;
        public object status;
        public object _certificateValidationFailed;

        // ── Methods ──
        public void get_Request(){} // RVA: 0xB700F0
        public void get_ExceptionStatus(){} // RVA: 0xBE5850
        public void get_CertificateValidationFailed(){} // RVA: 0x23E22A0
        public void set_CertificateValidationFailed(){} // RVA: 0x23E2270
        public void .ctor(){} // RVA: 0x70FEF20
        public void CreateStream(){} // RVA: 0x70FF310
        public void Dispose(){} // RVA: 0x70FF570
        public void CloseSslStream(){} // RVA: 0x70FF580
    }

    public class NoReflectionHelper : Object
    {
        // ── Methods ──
        public void GetProvider(){} // RVA: 0x7100090
    }

    public class SystemCertificateValidator : Object
    {
        public object is_macosx;
        public object s_flags;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7100110
        public void NeedsChain(){} // RVA: 0xB43320
    }

}