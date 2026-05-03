// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Net.Security
// Classes: 19
// Methods: 201

namespace ThirdParty.DotNet.Mono.Net.Security
{
    public class AsyncHandshakeRequest : AsyncProtocolRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871C8F10
        public void Run(){} // RVA: 0x7FFE871C8F20
    }

    public class AsyncProtocolRequest : Object
    {
        public Mono.Net.Security.MobileAuthenticatedStream _parent; // 0x10
        public bool _runSynchronously; // 0x18
        public int _userResult; // 0x1C
        public int Started; // 0x20

        // ── Methods ──
        public void get_Parent(){} // RVA: 0x7FFE81116380
        public void get_RunSynchronously(){} // RVA: 0x7FFE811164E0
        public void get_Name(){} // RVA: 0x7FFE82709E10
        public void get_UserResult(){} // RVA: 0x7FFE82707EE0
        public void set_UserResult(){} // RVA: 0x7FFE82717690
        public void .ctor(){} // RVA: 0x7FFE871C7740
        public void RequestRead(){} // RVA: 0x7FFE871C7840
        public void RequestWrite(){} // RVA: 0x7FFE871C7980
        public void StartOperation(){} // RVA: 0x7FFE871C7990
        public void ProcessOperation(){} // RVA: 0x7FFE871C7B90
        public void InnerRead(){} // RVA: 0x7FFE871C7DB0
        public void Run(){} // RVA: 0x7FFE80E35520
        public void ToString(){} // RVA: 0x7FFE871C7FB0
    }

    public class AsyncProtocolResult : Object
    {
        public int _userResult; // 0x10
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo _error; // 0x18

        // ── Methods ──
        public void get_UserResult(){} // RVA: 0x7FFE811485C0
        public void get_Error(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE81161E80 | overloaded x2
    }

    public class AsyncReadOrWriteRequest : AsyncProtocolRequest
    {
        public Mono.Net.Security.BufferOffsetSize _userBuffer; // 0x38
        public int _currentSize; // 0x40

        // ── Methods ──
        public void get_UserBuffer(){} // RVA: 0x7FFE8143BA80
        public void get_CurrentSize(){} // RVA: 0x7FFE8119C080
        public void set_CurrentSize(){} // RVA: 0x7FFE8119C090
        public void .ctor(){} // RVA: 0x7FFE871C8F50
        public void ToString(){} // RVA: 0x7FFE871C9030
    }

    public class AsyncReadRequest : AsyncReadOrWriteRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871C90F0
        public void Run(){} // RVA: 0x7FFE871C9100
    }

    public class AsyncWriteRequest : AsyncReadOrWriteRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871C90F0
        public void Run(){} // RVA: 0x7FFE871C9180
    }

    public class BufferOffsetSize : Object
    {
        public byte[] Buffer; // 0x10
        public int Offset; // 0x18

        // ── Methods ──
        public void get_EndOffset(){} // RVA: 0x7FFE871C7100
        public void get_Remaining(){} // RVA: 0x7FFE871C7110
        public void .ctor(){} // RVA: 0x7FFE871C7140
        public void ToString(){} // RVA: 0x7FFE871C7270
    }

    public class BufferOffsetSize2 : BufferOffsetSize
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871C7340
        public void Reset(){} // RVA: 0x7FFE871C7450
        public void MakeRoom(){} // RVA: 0x7FFE871C74F0
        public void AppendData(){} // RVA: 0x7FFE871C7600
    }

    public class ChainValidationHelper : Object
    {
        public System.WeakReference`1<System.Net.Security.SslStream> owner; // 0x10

        // ── Methods ──
        public void GetInternalValidator(){} // RVA: 0x7FFE871C9220
        public void Create(){} // RVA: 0x7FFE871C9310
        public void .ctor(){} // RVA: 0x7FFE871C93F0
        public void GetValidationCallback(){} // RVA: 0x7FFE871C9C60
        public void DefaultSelectionCallback(){} // RVA: 0x7FFE871C9DA0
        public void get_Settings(){} // RVA: 0x7FFE810FE7C0
        public void SelectClientCertificate(){} // RVA: 0x7FFE871C9DF0
        public void ValidateCertificate(){} // RVA: 0x7FFE871C9EE0
        public void ValidateChain(){} // RVA: 0x7FFE871CA060 | overloaded x2
        public void InvokeCallback(){} // RVA: 0x7FFE871CA550
    }

    public class MobileAuthenticatedStream : AuthenticatedStream
    {
        public Mono.Net.Security.MobileTlsContext xobileTlsContext; // 0x38
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo lastException; // 0x40
        public Mono.Net.Security.AsyncProtocolRequest asyncHandshakeRequest; // 0x48
        public Mono.Net.Security.AsyncProtocolRequest asyncReadRequest; // 0x50
        public Mono.Net.Security.AsyncProtocolRequest asyncWriteRequest; // 0x58
        public Mono.Net.Security.BufferOffsetSize2 readBuffer; // 0x60
        public Mono.Net.Security.BufferOffsetSize2 writeBuffer; // 0x68
        public object ioLock; // 0x70
        public int closeRequested; // 0x78
        public bool shutdown; // 0x7C
        public 0x665259CC operation; // 0x80
        public int uniqueNameInteger;
        public System.Net.Security.SslStream _sslStream; // 0x88
        public Mono.Security.Interface.MonoTlsSettings _settings; // 0x90
        public Mono.Net.Security.MobileTlsProvider _provider; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871CA7E0
        public void get_SslStream(){} // RVA: 0x7FFE8113A010
        public void get_Settings(){} // RVA: 0x7FFE8154EB60
        public void get_Provider(){} // RVA: 0x7FFE817AE360
        public void get_TargetHost(){} // RVA: 0x7FFE8179C860
        public void set_TargetHost(){} // RVA: 0x7FFE8171B4D0
        public void CheckThrow(){} // RVA: 0x7FFE871CAB10
        public void GetSSPIException(){} // RVA: 0x7FFE871CAC10
        public void GetIOException(){} // RVA: 0x7FFE871CADB0
        public void GetInternalError(){} // RVA: 0x7FFE871CAF50
        public void GetInvalidNestedCallException(){} // RVA: 0x7FFE871CAFA0
        public void SetException(){} // RVA: 0x7FFE871CAFF0
        public void AuthenticateAsClient(){} // RVA: 0x7FFE871CB120
        public void AuthenticateAsServer(){} // RVA: 0x7FFE871CB2E0
        public void AuthenticateAsClientAsync(){} // RVA: 0x7FFE871CB4F0
        public void ProcessAuthentication(){} // RVA: 0x7FFE871CB640
        public void CreateContext(){} // RVA: 0x7FFE80E2E390
        public void Read(){} // RVA: 0x7FFE871CB8D0
        public void Write(){} // RVA: 0x7FFE871CB9D0
        public void ReadAsync(){} // RVA: 0x7FFE871CBAD0
        public void WriteAsync(){} // RVA: 0x7FFE871CBB80
        public void StartOperation(){} // RVA: 0x7FFE871CBC30
        public void InternalRead(){} // RVA: 0x7FFE871CC070 | overloaded x2
        public void InternalWrite(){} // RVA: 0x7FFE871CC340 | overloaded x2
        public void InnerRead(){} // RVA: 0x7FFE871CC530
        public void InnerWrite(){} // RVA: 0x7FFE871CC760
        public void ProcessHandshake(){} // RVA: 0x7FFE871CC9A0
        public void ProcessRead(){} // RVA: 0x7FFE871CCDB0
        public void ProcessWrite(){} // RVA: 0x7FFE871CCFB0
        public void get_IsAuthenticated(){} // RVA: 0x7FFE871CD1B0
        public void Dispose(){} // RVA: 0x7FFE871CD330
        public void Flush(){} // RVA: 0x7FFE86F56340
        public void get_LocalCertificate(){} // RVA: 0x7FFE871CD660
        public void get_InternalLocalCertificate(){} // RVA: 0x7FFE871CD830
        public void Seek(){} // RVA: 0x7FFE871CDA00
        public void SetLength(){} // RVA: 0x7FFE871CDA40
        public void get_CanRead(){} // RVA: 0x7FFE871CDA70
        public void get_CanTimeout(){} // RVA: 0x7FFE871CDAC0
        public void get_CanWrite(){} // RVA: 0x7FFE871CDAF0
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_Length(){} // RVA: 0x7FFE871CDB60
        public void get_Position(){} // RVA: 0x7FFE871CDB90
        public void set_Position(){} // RVA: 0x7FFE871CDBC0
        public void get_ReadTimeout(){} // RVA: 0x7FFE871CDC00
        public void set_ReadTimeout(){} // RVA: 0x7FFE871CDC30
        public void get_WriteTimeout(){} // RVA: 0x7FFE871CDC60
        public void set_WriteTimeout(){} // RVA: 0x7FFE871CDC90
        public void .cctor(){} // RVA: 0x7FFE871CDCC0
        public void <InnerWrite>b__67_0(){} // RVA: 0x7FFE871CDD00
    }

    public class MobileTlsContext : Object
    {
        public Mono.Net.Security.ChainValidationHelper certificateValidator; // 0x10
        public Mono.Net.Security.MonoSslAuthenticationOptions _options; // 0x18
        public Mono.Net.Security.MobileAuthenticatedStream _parent; // 0x20
        public bool _isServer; // 0x28
        public string _targetHost; // 0x30
        public string _serverName; // 0x38
        public bool _askForClientCertificate; // 0x40
        public 0x6652A1A4 _enabledProtocols; // 0x44
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates; // 0x48
        public System.Security.Cryptography.X509Certificates.X509Certificate _localServerCertificate; // 0x50
        public object field_10; // 0x32
        public object field_11; // 0x33
        public object field_12; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871D0260
        public void get_Options(){} // RVA: 0x7FFE810FE7C0
        public void get_Parent(){} // RVA: 0x7FFE811290C0
        public void get_Settings(){} // RVA: 0x7FFE871D06C0
        public void get_IsAuthenticated(){} // RVA: 0x7FFE80E2F150
        public void get_IsServer(){} // RVA: 0x7FFE815F1380
        public void get_TargetHost(){} // RVA: 0x7FFE8144E200
        public void get_ServerName(){} // RVA: 0x7FFE8143BA80
        public void get_AskForClientCertificate(){} // RVA: 0x7FFE811B6C00
        public void get_EnabledProtocols(){} // RVA: 0x7FFE8119C0A0
        public void get_ClientCertificates(){} // RVA: 0x7FFE81176730
        public void GetProtocolVersions(){} // RVA: 0x7FFE871D06E0
        public void StartHandshake(){} // RVA: 0x7FFE80E45FE0
        public void ProcessHandshake(){} // RVA: 0x7FFE80E2F150
        public void FinishHandshake(){} // RVA: 0x7FFE80E45FE0
        public void get_LocalServerCertificate(){} // RVA: 0x7FFE8119C0E0
        public void set_LocalServerCertificate(){} // RVA: 0x7FFE812534D0
        public void get_LocalClientCertificate(){} // RVA: 0x7FFE80E2E2E0
        public void get_RemoteCertificate(){} // RVA: 0x7FFE80E2E2E0
        public void Flush(){} // RVA: 0x7FFE80E45FE0
        public void Read(){}
        public void Write(){}
        public void Shutdown(){} // RVA: 0x7FFE80E45FE0
        public void PendingRenegotiation(){} // RVA: 0x7FFE80E2F150
        public void ValidateCertificate(){} // RVA: 0x7FFE871D07E0
        public void SelectServerCertificate(){} // RVA: 0x7FFE871D0840
        public void SelectClientCertificate(){} // RVA: 0x7FFE871D0B60
        public void Renegotiate(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE871D1290
    }

    public class MobileTlsProvider : MonoTlsProvider
    {
        // ── Methods ──
        public void CreateSslStream(){}
        public void ValidateCertificate(){}
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MonoSslAuthenticationOptions : Object
    {
        public System.Net.Security.ServerCertSelectionCallback _serverCertSelectionDelegate; // 0x10
        public object field_1; // 0x3F
        public object field_2; // 0x40
        public object field_3; // 0x41
        public object field_4; // 0x42
        public object field_5; // 0x43
        public object field_6; // 0x44
        public object field_7; // 0x45
        public object field_8; // 0x46
        public object field_9; // 0x47

        // ── Methods ──
        public void get_ServerMode(){} // RVA: 0x7FFE80E2F150
        public void get_AllowRenegotiation(){} // RVA: 0x7FFE80E2F150
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFE80E2EDB0
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFE80E46530
        public void set_EncryptionPolicy(){} // RVA: 0x7FFE80E46530
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFE80E46530
        public void get_TargetHost(){} // RVA: 0x7FFE80E2E2E0
        public void set_TargetHost(){} // RVA: 0x7FFE80E460A0
        public void get_ServerCertificate(){} // RVA: 0x7FFE80E2E2E0
        public void set_ServerCertificate(){} // RVA: 0x7FFE80E460A0
        public void get_ClientCertificates(){} // RVA: 0x7FFE80E2E2E0
        public void set_ClientCertificates(){} // RVA: 0x7FFE80E460A0
        public void get_ClientCertificateRequired(){} // RVA: 0x7FFE80E2F150
        public void set_ClientCertificateRequired(){} // RVA: 0x7FFE80E466C0
        public void get_ServerCertSelectionDelegate(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
    {
        public System.Net.Security.SslClientAuthenticationOptions _options; // 0x18
        public object field_1; // 0x49
        public object field_2; // 0x4A
        public object field_3; // 0x4B
        public object field_4; // 0x4C
        public object field_5; // 0x4D
        public object field_6; // 0x4E
        public object field_7; // 0x4F
        public object field_8; // 0x50
        public object field_9; // 0x51

        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFE810FE7C0
        public void get_ServerMode(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE871D12E0
        public void get_AllowRenegotiation(){} // RVA: 0x7FFE871D1370
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFE871D1390
        public void set_EncryptionPolicy(){} // RVA: 0x7FFE871D1440
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFE84023030
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFE871D14F0
        public void get_TargetHost(){} // RVA: 0x7FFE86BAE0C0
        public void set_TargetHost(){} // RVA: 0x7FFE871D1510
        public void get_ClientCertificateRequired(){} // RVA: 0x7FFE871D1580
        public void set_ClientCertificateRequired(){} // RVA: 0x7FFE871D15C0
        public void get_ClientCertificates(){} // RVA: 0x7FFE86BAE0A0
        public void set_ClientCertificates(){} // RVA: 0x7FFE871D1600
        public void get_ServerCertificate(){} // RVA: 0x7FFE871D1670
        public void set_ServerCertificate(){} // RVA: 0x7FFE871D16B0
    }

    public class MonoSslServerAuthenticationOptions : MonoSslAuthenticationOptions
    {
        public System.Net.Security.SslServerAuthenticationOptions _options; // 0x18
        public object field_1; // 0x53
        public object field_2; // 0x54
        public object field_3; // 0x55
        public object field_4; // 0x56
        public object field_5; // 0x57
        public object field_6; // 0x58
        public object field_7; // 0x59
        public object field_8; // 0x5A
        public object field_9; // 0x5B

        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFE810FE7C0
        public void get_ServerMode(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE871D16F0
        public void get_AllowRenegotiation(){} // RVA: 0x7FFE871D1370
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFE871D1780
        public void set_EncryptionPolicy(){} // RVA: 0x7FFE871D1830
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFE871D18E0
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFE871D1900
        public void get_ClientCertificateRequired(){} // RVA: 0x7FFE871D1920
        public void set_ClientCertificateRequired(){} // RVA: 0x7FFE871D1940
        public void get_TargetHost(){} // RVA: 0x7FFE871D1960
        public void set_TargetHost(){} // RVA: 0x7FFE871D19A0
        public void get_ServerCertificate(){} // RVA: 0x7FFE82A2A930
        public void set_ServerCertificate(){} // RVA: 0x7FFE86BAE010
        public void get_ClientCertificates(){} // RVA: 0x7FFE871D19E0
        public void set_ClientCertificates(){} // RVA: 0x7FFE871D1A20
    }

    public class MonoTlsProviderFactory : Object
    {
        // ── Methods ──
        public void GetProviderInternal(){} // RVA: 0x7FFE871D1A60
        public void InitializeInternal(){} // RVA: 0x7FFE871D1C10
        public void LookupProvider(){} // RVA: 0x7FFE871D2110
        public void InitializeProviderRegistration(){} // RVA: 0x7FFE871D2890
        public void PopulateUnityProviders(){} // RVA: 0x7FFE871D2F00
        public void PopulateProviders(){} // RVA: 0x7FFE871D30C0
        public void IsBtlsSupported(){} // RVA: 0x7FFE810FB320
        public void CreateDefaultProviderImpl(){} // RVA: 0x7FFE871D3190
        public void GetProvider(){} // RVA: 0x7FFE871D3400
        public void .cctor(){} // RVA: 0x7FFE871D3450
    }

    public class MonoTlsStream : Object
    {
        public Mono.Net.Security.MobileTlsProvider provider; // 0x10
        public System.Net.Sockets.NetworkStream networkStream; // 0x18
        public System.Net.HttpWebRequest request; // 0x20

        // ── Methods ──
        public void get_Request(){} // RVA: 0x7FFE811290C0
        public void get_ExceptionStatus(){} // RVA: 0x7FFE8119C080
        public void get_CertificateValidationFailed(){} // RVA: 0x7FFE82876440
        public void set_CertificateValidationFailed(){} // RVA: 0x7FFE82876430
        public void .ctor(){} // RVA: 0x7FFE871D3870
        public void CreateStream(){} // RVA: 0x7FFE871D3C60
        public void Dispose(){} // RVA: 0x7FFE871D3EC0
        public void CloseSslStream(){} // RVA: 0x7FFE871D3ED0
    }

    public class NoReflectionHelper : Object
    {
        // ── Methods ──
        public void GetProvider(){} // RVA: 0x7FFE871D4A20
    }

    public class SystemCertificateValidator : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE871D4AA0
        public void NeedsChain(){} // RVA: 0x7FFE810FB320
    }

}