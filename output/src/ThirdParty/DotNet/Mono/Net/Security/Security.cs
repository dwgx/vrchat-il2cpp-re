// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Net.Security
// Classes: 19
// Methods: 201

namespace ThirdParty.DotNet.Mono.Net.Security
{
    public class AsyncHandshakeRequest : AsyncProtocolRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E20AE0
        public void Run(){} // RVA: 0x7FFAC8E20AF0
    }

    public class AsyncProtocolRequest : Object
    {
        public Mono.Net.Security.MobileAuthenticatedStream Parent; // 0x10
        public bool RunSynchronously; // 0x18
        public int Name; // 0x1C
        public int UserResult; // 0x20
        public int RequestedSize; // 0x24
        public int WriteRequested; // 0x28
        public object locker; // 0x30
        public int next_id;

        // ── Methods ──
        public void get_Parent(){} // RVA: 0x7FFAC2F3C380
        public void get_RunSynchronously(){} // RVA: 0x7FFAC2F3C4E0
        public void get_Name(){} // RVA: 0x7FFAC44375F0
        public void get_UserResult(){} // RVA: 0x7FFAC44357F0
        public void set_UserResult(){} // RVA: 0x7FFAC44474D0
        public void .ctor(){} // RVA: 0x7FFAC8E1F310
        public void RequestRead(){} // RVA: 0x7FFAC8E1F410
        public void RequestWrite(){} // RVA: 0x7FFAC8E1F550
        public void StartOperation(){} // RVA: 0x7FFAC8E1F560
        public void ProcessOperation(){} // RVA: 0x7FFAC8E1F760
        public void InnerRead(){} // RVA: 0x7FFAC8E1F980
        public void Run(){} // RVA: 0x7FFAC2C600D0
        public void ToString(){} // RVA: 0x7FFAC8E1FB80
    }

    public class AsyncProtocolResult : Object
    {
        public int UserResult; // 0x10
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo Error; // 0x18

        // ── Methods ──
        public void get_UserResult(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Error(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC2F87E80 | overloaded x2
    }

    public class AsyncReadOrWriteRequest : AsyncProtocolRequest
    {
        public Mono.Net.Security.BufferOffsetSize UserBuffer; // 0x38
        public int CurrentSize; // 0x40

        // ── Methods ──
        public void get_UserBuffer(){} // RVA: 0x7FFAC31D0140
        public void get_CurrentSize(){} // RVA: 0x7FFAC2FC2080
        public void set_CurrentSize(){} // RVA: 0x7FFAC2FC2090
        public void .ctor(){} // RVA: 0x7FFAC8E20B20
        public void ToString(){} // RVA: 0x7FFAC8E20C00
    }

    public class AsyncReadRequest : AsyncReadOrWriteRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E20CC0
        public void Run(){} // RVA: 0x7FFAC8E20CD0
    }

    public class AsyncWriteRequest : AsyncReadOrWriteRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E20CC0
        public void Run(){} // RVA: 0x7FFAC8E20D50
    }

    public class BufferOffsetSize : Object
    {
        public byte[] EndOffset; // 0x10
        public int Remaining; // 0x18
        public int Size; // 0x1C
        public int TotalBytes; // 0x20
        public bool Complete; // 0x24

        // ── Methods ──
        public void get_EndOffset(){} // RVA: 0x7FFAC8E1ECD0
        public void get_Remaining(){} // RVA: 0x7FFAC8E1ECE0
        public void .ctor(){} // RVA: 0x7FFAC8E1ED10
        public void ToString(){} // RVA: 0x7FFAC8E1EE40
    }

    public class BufferOffsetSize2 : BufferOffsetSize
    {
        public int InitialSize; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E1EF10
        public void Reset(){} // RVA: 0x7FFAC8E1F020
        public void MakeRoom(){} // RVA: 0x7FFAC8E1F0C0
        public void AppendData(){} // RVA: 0x7FFAC8E1F1D0
    }

    public class ChainValidationHelper : Object
    {
        public System.WeakReference`1<System.Net.Security.SslStream> Settings; // 0x10
        public Mono.Security.Interface.MonoTlsSettings settings; // 0x18
        public Mono.Net.Security.MobileTlsProvider provider; // 0x20
        public System.Net.ServerCertValidationCallback certValidationCallback; // 0x28
        public System.Net.Security.LocalCertSelectionCallback certSelectionCallback; // 0x30
        public Mono.Net.Security.MonoTlsStream tlsStream; // 0x38
        public System.Net.HttpWebRequest request; // 0x40

        // ── Methods ──
        public void GetInternalValidator(){} // RVA: 0x7FFAC8E20DF0
        public void Create(){} // RVA: 0x7FFAC8E20EE0
        public void .ctor(){} // RVA: 0x7FFAC8E20FC0
        public void GetValidationCallback(){} // RVA: 0x7FFAC8E21830
        public void DefaultSelectionCallback(){} // RVA: 0x7FFAC8E21970
        public void get_Settings(){} // RVA: 0x7FFAC2F247C0
        public void SelectClientCertificate(){} // RVA: 0x7FFAC8E219C0
        public void ValidateCertificate(){} // RVA: 0x7FFAC8E21AB0
        public void ValidateChain(){} // RVA: 0x7FFAC8E21C30 | overloaded x2
        public void InvokeCallback(){} // RVA: 0x7FFAC8E22120
    }

    public class MobileAuthenticatedStream : AuthenticatedStream
    {
        public Mono.Net.Security.MobileTlsContext SslStream; // 0x38
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo Settings; // 0x40
        public Mono.Net.Security.AsyncProtocolRequest Provider; // 0x48
        public Mono.Net.Security.AsyncProtocolRequest TargetHost; // 0x50
        public Mono.Net.Security.AsyncProtocolRequest IsAuthenticated; // 0x58
        public Mono.Net.Security.BufferOffsetSize2 LocalCertificate; // 0x60
        public Mono.Net.Security.BufferOffsetSize2 InternalLocalCertificate; // 0x68
        public object CanRead; // 0x70
        public int CanTimeout; // 0x78
        public bool CanWrite; // 0x7C
        public 0x6B12CAA8 CanSeek; // 0x80
        public int Length;
        public System.Net.Security.SslStream Position; // 0x88
        public Mono.Security.Interface.MonoTlsSettings ReadTimeout; // 0x90
        public Mono.Net.Security.MobileTlsProvider WriteTimeout; // 0x98
        public string <TargetHost>k__BackingField; // 0xA0
        public int nextId; // 0x4
        public int ID; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E223B0
        public void get_SslStream(){} // RVA: 0x7FFAC2F60010
        public void get_Settings(){} // RVA: 0x7FFAC32EF640
        public void get_Provider(){} // RVA: 0x7FFAC354DFB0
        public void get_TargetHost(){} // RVA: 0x7FFAC3543900
        public void set_TargetHost(){} // RVA: 0x7FFAC354E420
        public void CheckThrow(){} // RVA: 0x7FFAC8E226E0
        public void GetSSPIException(){} // RVA: 0x7FFAC8E227E0
        public void GetIOException(){} // RVA: 0x7FFAC8E22980
        public void GetInternalError(){} // RVA: 0x7FFAC8E22B20
        public void GetInvalidNestedCallException(){} // RVA: 0x7FFAC8E22B70
        public void SetException(){} // RVA: 0x7FFAC8E22BC0
        public void AuthenticateAsClient(){} // RVA: 0x7FFAC8E22CF0
        public void AuthenticateAsServer(){} // RVA: 0x7FFAC8E22EB0
        public void AuthenticateAsClientAsync(){} // RVA: 0x7FFAC8E230C0
        public void ProcessAuthentication(){} // RVA: 0x7FFAC8E23210
        public void CreateContext(){} // RVA: 0x7FFAC2C58F40
        public void Read(){} // RVA: 0x7FFAC8E234A0
        public void Write(){} // RVA: 0x7FFAC8E235A0
        public void ReadAsync(){} // RVA: 0x7FFAC8E236A0
        public void WriteAsync(){} // RVA: 0x7FFAC8E23750
        public void StartOperation(){} // RVA: 0x7FFAC8E23800
        public void InternalRead(){} // RVA: 0x7FFAC8E23C40 | overloaded x2
        public void InternalWrite(){} // RVA: 0x7FFAC8E23F10 | overloaded x2
        public void InnerRead(){} // RVA: 0x7FFAC8E24100
        public void InnerWrite(){} // RVA: 0x7FFAC8E24330
        public void ProcessHandshake(){} // RVA: 0x7FFAC8E24570
        public void ProcessRead(){} // RVA: 0x7FFAC8E24980
        public void ProcessWrite(){} // RVA: 0x7FFAC8E24B80
        public void get_IsAuthenticated(){} // RVA: 0x7FFAC8E24D80
        public void Dispose(){} // RVA: 0x7FFAC8E24F00
        public void Flush(){} // RVA: 0x7FFAC8BACCC0
        public void get_LocalCertificate(){} // RVA: 0x7FFAC8E25230
        public void get_InternalLocalCertificate(){} // RVA: 0x7FFAC8E25400
        public void Seek(){} // RVA: 0x7FFAC8E255D0
        public void SetLength(){} // RVA: 0x7FFAC8E25610
        public void get_CanRead(){} // RVA: 0x7FFAC8E25640
        public void get_CanTimeout(){} // RVA: 0x7FFAC8E25690
        public void get_CanWrite(){} // RVA: 0x7FFAC8E256C0
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_Length(){} // RVA: 0x7FFAC8E25730
        public void get_Position(){} // RVA: 0x7FFAC8E25760
        public void set_Position(){} // RVA: 0x7FFAC8E25790
        public void get_ReadTimeout(){} // RVA: 0x7FFAC8E257D0
        public void set_ReadTimeout(){} // RVA: 0x7FFAC8E25800
        public void get_WriteTimeout(){} // RVA: 0x7FFAC8E25830
        public void set_WriteTimeout(){} // RVA: 0x7FFAC8E25860
        public void .cctor(){} // RVA: 0x7FFAC8E25890
        public void <InnerWrite>b__67_0(){} // RVA: 0x7FFAC8E258D0
    }

    public class MobileTlsContext : Object
    {
        public Mono.Net.Security.ChainValidationHelper Options; // 0x10
        public Mono.Net.Security.MonoSslAuthenticationOptions Parent; // 0x18
        public Mono.Net.Security.MobileAuthenticatedStream Settings; // 0x20
        public bool IsAuthenticated; // 0x28
        public string IsServer; // 0x30
        public string TargetHost; // 0x38
        public bool ServerName; // 0x40
        public 0x6B131280 AskForClientCertificate; // 0x44
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection EnabledProtocols; // 0x48
        public System.Security.Cryptography.X509Certificates.X509Certificate ClientCertificates; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E27E30
        public void get_Options(){} // RVA: 0x7FFAC2F247C0
        public void get_Parent(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Settings(){} // RVA: 0x7FFAC8E28290
        public void get_IsAuthenticated(){} // RVA: 0x7FFAC2C59D00
        public void get_IsServer(){} // RVA: 0x7FFAC30F6BA0
        public void get_TargetHost(){} // RVA: 0x7FFAC31D95E0
        public void get_ServerName(){} // RVA: 0x7FFAC31D0140
        public void get_AskForClientCertificate(){} // RVA: 0x7FFAC2FDCC00
        public void get_EnabledProtocols(){} // RVA: 0x7FFAC2FC20A0
        public void get_ClientCertificates(){} // RVA: 0x7FFAC2F9C730
        public void GetProtocolVersions(){} // RVA: 0x7FFAC8E282B0
        public void StartHandshake(){} // RVA: 0x7FFAC2C70980
        public void ProcessHandshake(){} // RVA: 0x7FFAC2C59D00
        public void FinishHandshake(){} // RVA: 0x7FFAC2C70980
        public void get_LocalServerCertificate(){} // RVA: 0x7FFAC2FC20E0
        public void set_LocalServerCertificate(){} // RVA: 0x7FFAC30794D0
        public void get_LocalClientCertificate(){} // RVA: 0x7FFAC2C58E90
        public void get_RemoteCertificate(){} // RVA: 0x7FFAC2C58E90
        public void Flush(){} // RVA: 0x7FFAC2C70980
        public void Read(){}
        public void Write(){}
        public void Shutdown(){} // RVA: 0x7FFAC2C70980
        public void PendingRenegotiation(){} // RVA: 0x7FFAC2C59D00
        public void ValidateCertificate(){} // RVA: 0x7FFAC8E283B0
        public void SelectServerCertificate(){} // RVA: 0x7FFAC8E28410
        public void SelectClientCertificate(){} // RVA: 0x7FFAC8E28730
        public void Renegotiate(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8E28E60
    }

    public class MobileTlsProvider : MonoTlsProvider
    {
        // ── Methods ──
        public void CreateSslStream(){}
        public void ValidateCertificate(){}
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MonoSslAuthenticationOptions : Object
    {
        public System.Net.Security.ServerCertSelectionCallback ServerMode; // 0x10

        // ── Methods ──
        public void get_ServerMode(){} // RVA: 0x7FFAC2C59D00
        public void get_AllowRenegotiation(){} // RVA: 0x7FFAC2C59D00
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFAC2C59960
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFAC2C70ED0
        public void set_EncryptionPolicy(){} // RVA: 0x7FFAC2C70ED0
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFAC2C70ED0
        public void get_TargetHost(){} // RVA: 0x7FFAC2C58E90
        public void set_TargetHost(){} // RVA: 0x7FFAC2C70A40
        public void get_ServerCertificate(){} // RVA: 0x7FFAC2C58E90
        public void set_ServerCertificate(){} // RVA: 0x7FFAC2C70A40
        public void get_ClientCertificates(){} // RVA: 0x7FFAC2C58E90
        public void set_ClientCertificates(){} // RVA: 0x7FFAC2C70A40
        public void get_ClientCertificateRequired(){} // RVA: 0x7FFAC2C59D00
        public void set_ClientCertificateRequired(){} // RVA: 0x7FFAC2C71060
        public void get_ServerCertSelectionDelegate(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
    {
        public System.Net.Security.SslClientAuthenticationOptions Options; // 0x18

        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFAC2F247C0
        public void get_ServerMode(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC8E28EB0
        public void get_AllowRenegotiation(){} // RVA: 0x7FFAC8E28F40
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFAC8E28F60
        public void set_EncryptionPolicy(){} // RVA: 0x7FFAC8E29010
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFAC5CC4BA0
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFAC8E290C0
        public void get_TargetHost(){} // RVA: 0x7FFAC88049A0
        public void set_TargetHost(){} // RVA: 0x7FFAC8E290E0
        public void get_ClientCertificateRequired(){} // RVA: 0x7FFAC8E29150
        public void set_ClientCertificateRequired(){} // RVA: 0x7FFAC8E29190
        public void get_ClientCertificates(){} // RVA: 0x7FFAC8804980
        public void set_ClientCertificates(){} // RVA: 0x7FFAC8E291D0
        public void get_ServerCertificate(){} // RVA: 0x7FFAC8E29240
        public void set_ServerCertificate(){} // RVA: 0x7FFAC8E29280
    }

    public class MonoSslServerAuthenticationOptions : MonoSslAuthenticationOptions
    {
        public System.Net.Security.SslServerAuthenticationOptions Options; // 0x18

        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFAC2F247C0
        public void get_ServerMode(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC8E292C0
        public void get_AllowRenegotiation(){} // RVA: 0x7FFAC8E28F40
        public void set_CertificateRevocationCheckMode(){} // RVA: 0x7FFAC8E29350
        public void set_EncryptionPolicy(){} // RVA: 0x7FFAC8E29400
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFAC8E294B0
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFAC8E294D0
        public void get_ClientCertificateRequired(){} // RVA: 0x7FFAC8E294F0
        public void set_ClientCertificateRequired(){} // RVA: 0x7FFAC8E29510
        public void get_TargetHost(){} // RVA: 0x7FFAC8E29530
        public void set_TargetHost(){} // RVA: 0x7FFAC8E29570
        public void get_ServerCertificate(){} // RVA: 0x7FFAC47C2590
        public void set_ServerCertificate(){} // RVA: 0x7FFAC88048F0
        public void get_ClientCertificates(){} // RVA: 0x7FFAC8E295B0
        public void set_ClientCertificates(){} // RVA: 0x7FFAC8E295F0
    }

    public class MonoTlsProviderFactory : Object
    {
        public object locker;
        public bool initialized; // 0x8
        public Mono.Net.Security.MobileTlsProvider defaultProvider; // 0x10
        public System.Collections.Generic.Dictionary`2<string,System.Tuple`2<System.Guid,string>> providerRegistration; // 0x18
        public System.Collections.Generic.Dictionary`2<System.Guid,Mono.Net.Security.MobileTlsProvider> providerCache; // 0x20
        public System.Guid UnityTlsId; // 0x28
        public System.Guid AppleTlsId; // 0x38
        public System.Guid BtlsId; // 0x48

        // ── Methods ──
        public void GetProviderInternal(){} // RVA: 0x7FFAC8E29630
        public void InitializeInternal(){} // RVA: 0x7FFAC8E297E0
        public void LookupProvider(){} // RVA: 0x7FFAC8E29CE0
        public void InitializeProviderRegistration(){} // RVA: 0x7FFAC8E2A460
        public void PopulateUnityProviders(){} // RVA: 0x7FFAC8E2AAD0
        public void PopulateProviders(){} // RVA: 0x7FFAC8E2AC90
        public void IsBtlsSupported(){} // RVA: 0x7FFAC2F21320
        public void CreateDefaultProviderImpl(){} // RVA: 0x7FFAC8E2AD60
        public void GetProvider(){} // RVA: 0x7FFAC8E2AFD0
        public void .cctor(){} // RVA: 0x7FFAC8E2B020
    }

    public class MonoTlsStream : Object
    {
        public Mono.Net.Security.MobileTlsProvider Request; // 0x10
        public System.Net.Sockets.NetworkStream ExceptionStatus; // 0x18
        public System.Net.HttpWebRequest CertificateValidationFailed; // 0x20
        public Mono.Security.Interface.MonoTlsSettings settings; // 0x28
        public System.Net.Security.SslStream sslStream; // 0x30
        public object sslStreamLock; // 0x38
        public 0x6B13B258 status; // 0x40
        public bool <CertificateValidationFailed>k__BackingField; // 0x44

        // ── Methods ──
        public void get_Request(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ExceptionStatus(){} // RVA: 0x7FFAC2FC2080
        public void get_CertificateValidationFailed(){} // RVA: 0x7FFAC45A8350
        public void set_CertificateValidationFailed(){} // RVA: 0x7FFAC45A8340
        public void .ctor(){} // RVA: 0x7FFAC8E2B440
        public void CreateStream(){} // RVA: 0x7FFAC8E2B830
        public void Dispose(){} // RVA: 0x7FFAC8E2BA90
        public void CloseSslStream(){} // RVA: 0x7FFAC8E2BAA0
    }

    public class NoReflectionHelper : Object
    {
        // ── Methods ──
        public void GetProvider(){} // RVA: 0x7FFAC8E2C5F0
    }

    public class SystemCertificateValidator : Object
    {
        public bool is_macosx;
        public 0x6B131960 s_flags; // 0x4

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8E2C670
        public void NeedsChain(){} // RVA: 0x7FFAC2F21320
    }

}