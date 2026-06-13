// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP
// Classes: 21
// Methods: 415

namespace ThirdParty.BestHTTP.BestHTTP
{
    public class ConnectionBase
    {
        public string <ServerAddress>k__BackingField; // 0x10
        public 0x6579D648 <State>k__BackingField; // 0x18
        public BestHTTP.HTTPRequest <CurrentRequest>k__BackingField; // 0x20
        public System.DateTime <StartTime>k__BackingField; // 0x28
        public System.DateTime <TimedOutStart>k__BackingField; // 0x30
        public System.Uri <LastProcessedUri>k__BackingField; // 0x38
        public System.DateTime LastProcessTime; // 0x40
        public BestHTTP.HTTPConnectionRecycledDelegate OnConnectionRecycled; // 0x48
        public bool IsThreaded; // 0x50
        public bool <IsDisposed>k__BackingField; // 0x51

        // ── Methods ──
        public void get_ServerAddress(){} // RVA: 0x2F8380
        public void set_ServerAddress(){} // RVA: 0x2DEE30
        public void get_State(){} // RVA: 0x5BED50
        public void set_State(){} // RVA: 0x6374E0
        public void get_IsFree(){} // RVA: 0x942B690
        public void get_IsActive(){} // RVA: 0x942B6B0
        public void get_CurrentRequest(){} // RVA: 0x30B0C0
        public void set_CurrentRequest(){} // RVA: 0x30B0D0
        public void get_IsRemovable(){} // RVA: 0x942B6D0
        public void get_StartTime(){} // RVA: 0x30B130
        public void set_StartTime(){} // RVA: 0x8AC650
        public void get_TimedOutStart(){} // RVA: 0x6374D0
        public void set_TimedOutStart(){} // RVA: 0x1F74DF0
        public void get_HasProxy(){} // RVA: 0x942B7F0
        public void get_LastProcessedUri(){} // RVA: 0x4976A0
        public void set_LastProcessedUri(){} // RVA: 0x49B830
        public void .ctor(){} // RVA: 0x942B8D0 | overloaded x2
        public void Abort(){} // RVA: 0x24FA0
        public void Process(){} // RVA: 0x942B990
        public void ThreadFunc(){} // RVA: 0x2DD310
        public void HandleProgressCallback(){} // RVA: 0x942BC80
        public void HandleCallback(){} // RVA: 0x942BEC0
        public void Recycle(){} // RVA: 0x942BFC0
        public void RecycleNow(){} // RVA: 0x942C040
        public void get_IsDisposed(){} // RVA: 0x1BE4C90
        public void set_IsDisposed(){} // RVA: 0x1BE2170
        public void Dispose(){} // RVA: 0x942C220 | overloaded x2
        public void Finalize(){} // RVA: 0x942C230
    }

    public class FileConnection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x942C280
        public void Abort(){} // RVA: 0x942C290
        public void ThreadFunc(){} // RVA: 0x942C310
    }

    public class HTTPConnection
    {
        public BestHTTP.PlatformSupport.TcpClient.General.TcpClient Client; // 0x58

        // ── Methods ──
        public void get_IsRemovable(){} // RVA: 0x942CE30
        public void .ctor(){} // RVA: 0x942C280
        public void ThreadFunc(){} // RVA: 0x942D000
        public void Connect(){} // RVA: 0x942E760
        public void Receive(){} // RVA: 0x942F6B0
        public void LoadFromCache(){} // RVA: 0x942FEE0
        public void TryLoadAllFromCache(){} // RVA: 0x94304E0
        public void TryStoreInCache(){} // RVA: 0x9430780
        public void GetRedirectUri(){} // RVA: 0x94308E0
        public void Abort(){} // RVA: 0x9430AF0
        public void Close(){} // RVA: 0x9430B80
        public void Dispose(){} // RVA: 0x9430DB0
        public void <Connect>b__7_0(){} // RVA: 0x9430DD0
    }

    public class HTTPConnectionRecycledDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x35D190
        public void Invoke(){} // RVA: 0x338C60
        public void BeginInvoke(){} // RVA: 0x338C70
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class HTTPManager
    {
        public byte maxConnectionPerServer;
        public bool <KeepAliveDefaultValue>k__BackingField; // 0x1
        public bool <IsCachingDisabled>k__BackingField; // 0x2
        public System.TimeSpan <MaxConnectionIdleTime>k__BackingField; // 0x8
        public bool <IsCookiesEnabled>k__BackingField; // 0x10
        public uint <CookieJarSize>k__BackingField; // 0x14
        public bool <EnablePrivateBrowsing>k__BackingField; // 0x18
        public System.TimeSpan <ConnectTimeout>k__BackingField; // 0x20
        public System.TimeSpan <RequestTimeout>k__BackingField; // 0x28
        public System.Func`1<string> <RootCacheFolderProvider>k__BackingField; // 0x30
        public BestHTTP.Proxy <Proxy>k__BackingField; // 0x38
        public BestHTTP.Extensions.HeartbeatManager heartbeats; // 0x40
        public BestHTTP.Logger.ILogger logger; // 0x48
        public Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer <DefaultCertificateVerifyer>k__BackingField; // 0x50
        public Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider <DefaultClientCredentialsProvider>k__BackingField; // 0x58
        public bool <UseAlternateSSLDefaultValue>k__BackingField; // 0x60
        public System.Func`4<BestHTTP.HTTPRequest,System.Security.Cryptography.X509Certificates.X509Certificate,System.Security.Cryptography.X509Certificates.X509Chain,bool> <DefaultCertificationValidator>k__BackingField; // 0x68
        public bool TryToMinimizeTCPLatency; // 0x70
        public int SendBufferSize; // 0x74

        // ── Methods ──
        public void .cctor(){} // RVA: 0x9430E20
        public void get_MaxConnectionPerServer(){} // RVA: 0x94318D0
        public void set_MaxConnectionPerServer(){} // RVA: 0x9431930
        public void get_KeepAliveDefaultValue(){} // RVA: 0x94319E0
        public void set_KeepAliveDefaultValue(){} // RVA: 0x9431A40
        public void get_IsCachingDisabled(){} // RVA: 0x9431AA0
        public void set_IsCachingDisabled(){} // RVA: 0x9431B00
        public void get_MaxConnectionIdleTime(){} // RVA: 0x9431B60
        public void set_MaxConnectionIdleTime(){} // RVA: 0x9431BC0
        public void get_IsCookiesEnabled(){} // RVA: 0x9431C20
        public void set_IsCookiesEnabled(){} // RVA: 0x9431C80
        public void get_CookieJarSize(){} // RVA: 0x9431CE0
        public void set_CookieJarSize(){} // RVA: 0x9431D40
        public void get_EnablePrivateBrowsing(){} // RVA: 0x9431DA0
        public void set_EnablePrivateBrowsing(){} // RVA: 0x9431E00
        public void get_ConnectTimeout(){} // RVA: 0x9431E60
        public void set_ConnectTimeout(){} // RVA: 0x9431EC0
        public void get_RequestTimeout(){} // RVA: 0x9431F20
        public void set_RequestTimeout(){} // RVA: 0x9431F80
        public void get_RootCacheFolderProvider(){} // RVA: 0x9431FE0
        public void set_RootCacheFolderProvider(){} // RVA: 0x9432040
        public void get_Proxy(){} // RVA: 0x9432100
        public void set_Proxy(){} // RVA: 0x9432160
        public void get_Heartbeats(){} // RVA: 0x9432220
        public void get_Logger(){} // RVA: 0x9432510
        public void set_Logger(){} // RVA: 0x9432680
        public void get_DefaultCertificateVerifyer(){} // RVA: 0x9432740
        public void set_DefaultCertificateVerifyer(){} // RVA: 0x94327A0
        public void get_DefaultClientCredentialsProvider(){} // RVA: 0x9432860
        public void set_DefaultClientCredentialsProvider(){} // RVA: 0x94328C0
        public void get_UseAlternateSSLDefaultValue(){} // RVA: 0x9432980
        public void set_UseAlternateSSLDefaultValue(){} // RVA: 0x94329E0
        public void get_DefaultCertificationValidator(){} // RVA: 0x9432A40
        public void set_DefaultCertificationValidator(){} // RVA: 0x9432AA0
        public void get_MaxPathLength(){} // RVA: 0x9432B60
        public void set_MaxPathLength(){} // RVA: 0x9432BC0
        public void get_IsQuitting(){} // RVA: 0x9432C20
        public void set_IsQuitting(){} // RVA: 0x9432C80
        public void Setup(){} // RVA: 0x9432CE0
        public void SendRequest(){} // RVA: 0x9433330 | overloaded x5
        public void GetGeneralStatistics(){} // RVA: 0x9433630
        public void SendRequestImpl(){} // RVA: 0x9433AE0
        public void GetKeyForRequest(){} // RVA: 0x9433DA0
        public void CreateConnection(){} // RVA: 0x9434030
        public void FindOrCreateFreeConnection(){} // RVA: 0x9434140
        public void CanProcessFromQueue(){} // RVA: 0x94347F0
        public void RecycleConnection(){} // RVA: 0x9434900
        public void OnConnectionRecylced(){} // RVA: 0x94349E0
        public void GetConnectionWith(){} // RVA: 0x9434BB0
        public void RemoveFromQueue(){} // RVA: 0x9434E80
        public void GetRootCacheFolder(){} // RVA: 0x9434F10
        public void OnUpdate(){} // RVA: 0x94350E0
        public void OnQuit(){} // RVA: 0x9436320
        public void AbortAll(){} // RVA: 0x9436570
    }

    public class HTTPProtocolFactory
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x9436D60
        public void GetProtocolFromUri(){} // RVA: 0x9436F20
        public void IsSecureProtocol(){} // RVA: 0x9436FF0
    }

    public class HTTPProxy
    {
        public bool <IsTransparent>k__BackingField; // 0x20
        public bool <SendWholeUri>k__BackingField; // 0x21
        public bool <NonTransparentForHTTPS>k__BackingField; // 0x22

        // ── Methods ──
        public void get_IsTransparent(){} // RVA: 0x3CB9D0
        public void set_IsTransparent(){} // RVA: 0x3CB9E0
        public void get_SendWholeUri(){} // RVA: 0x6BB3A0
        public void set_SendWholeUri(){} // RVA: 0xB265D0
        public void get_NonTransparentForHTTPS(){} // RVA: 0x1B97EB0
        public void set_NonTransparentForHTTPS(){} // RVA: 0x14AD720
        public void .ctor(){} // RVA: 0x94371E0 | overloaded x5
        public void GetRequestPath(){} // RVA: 0x9437220
        public void Connect(){} // RVA: 0x9437340
    }

    public class HTTPRange
    {
        public int <FirstBytePos>k__BackingField; // 0x10
        public int <LastBytePos>k__BackingField; // 0x14
        public int <ContentLength>k__BackingField; // 0x18
        public bool <IsValid>k__BackingField; // 0x1C

        // ── Methods ──
        public void get_FirstBytePos(){} // RVA: 0x32A5C0
        public void set_FirstBytePos(){} // RVA: 0x2E00C0
        public void get_LastBytePos(){} // RVA: 0x8ABED0
        public void set_LastBytePos(){} // RVA: 0x8AC660
        public void get_ContentLength(){} // RVA: 0x5BED50
        public void set_ContentLength(){} // RVA: 0x6374E0
        public void get_IsValid(){} // RVA: 0x2F8390
        public void set_IsValid(){} // RVA: 0x2F83A0
        public void .ctor(){} // RVA: 0x9438B10 | overloaded x3
        public void ToString(){} // RVA: 0x9438B30
    }

    public class HTTPRequest
    {
        public byte[] EOL;
        public string[] MethodNames; // 0x8
        public int UploadChunkSize; // 0x10
        public System.Uri <Uri>k__BackingField; // 0x10
        public 0x6579D7A8 <MethodType>k__BackingField; // 0x18
        public byte[] <RawData>k__BackingField; // 0x20
        public System.IO.Stream <UploadStream>k__BackingField; // 0x28
        public bool <DisposeUploadStream>k__BackingField; // 0x30
        public bool <UseUploadStreamLength>k__BackingField; // 0x31
        public BestHTTP.OnUploadProgressDelegate OnUploadProgress; // 0x38
        public int <MaxFragmentQueueLength>k__BackingField; // 0x40
        public BestHTTP.OnRequestFinishedDelegate <Callback>k__BackingField; // 0x48
        public BestHTTP.OnDownloadProgressDelegate OnProgress; // 0x50
        public BestHTTP.OnRequestFinishedDelegate OnUpgraded; // 0x58
        public bool <DisableRetry>k__BackingField; // 0x60
        public bool <IsRedirected>k__BackingField; // 0x61
        public System.Uri <RedirectUri>k__BackingField; // 0x68
        public BestHTTP.HTTPResponse <Response>k__BackingField; // 0x70
        public BestHTTP.HTTPResponse <ProxyResponse>k__BackingField; // 0x78
        public System.Exception <Exception>k__BackingField; // 0x80
        public object <Tag>k__BackingField; // 0x88
        public BestHTTP.Authentication.Credentials <Credentials>k__BackingField; // 0x90
        public BestHTTP.Proxy <Proxy>k__BackingField; // 0x98
        public int <MaxRedirects>k__BackingField; // 0xA0
        public bool <UseAlternateSSL>k__BackingField; // 0xA4
        public bool <IsCookiesEnabled>k__BackingField; // 0xA5
        public System.Collections.Generic.List`1<BestHTTP.Cookies.Cookie> customCookies; // 0xA8
        public 0x657C3978 <FormUsage>k__BackingField; // 0xB0
        public 0x6579D9B8 <State>k__BackingField; // 0xB4
        public int <RedirectCount>k__BackingField; // 0xB8
        public System.Func`4<BestHTTP.HTTPRequest,System.Security.Cryptography.X509Certificates.X509Certificate,System.Security.Cryptography.X509Certificates.X509Chain,bool> CustomCertificationValidator; // 0xC0
        public System.TimeSpan <ConnectTimeout>k__BackingField; // 0xC8
        public System.TimeSpan <Timeout>k__BackingField; // 0xD0
        public bool <EnableTimoutForStreaming>k__BackingField; // 0xD8
        public bool <EnableSafeReadOnUnknownContentLength>k__BackingField; // 0xD9
        public int <Priority>k__BackingField; // 0xDC
        public Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer <CustomCertificateVerifyer>k__BackingField; // 0xE0
        public Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider <CustomClientCredentialsProvider>k__BackingField; // 0xE8
        public System.Collections.Generic.List`1<string> <CustomTLSServerNameList>k__BackingField; // 0xF0
        public 0x6579D800 <ProtocolHandler>k__BackingField; // 0xF8
        public BestHTTP.OnBeforeRedirectionDelegate onBeforeRedirection; // 0x100
        public BestHTTP.OnBeforeHeaderSendDelegate _onBeforeHeaderSend; // 0x108
        public bool <TryToMinimizeTCPLatency>k__BackingField; // 0x110
        public int <SendBufferSize>k__BackingField; // 0x114
        public int <ReceiveBufferSize>k__BackingField; // 0x118
        public long <Downloaded>k__BackingField; // 0x120
        public long <DownloadLength>k__BackingField; // 0x128
        public bool <DownloadProgressChanged>k__BackingField; // 0x130
        public long <Uploaded>k__BackingField; // 0x138
        public long <UploadLength>k__BackingField; // 0x140
        public bool <UploadProgressChanged>k__BackingField; // 0x148
        public bool isKeepAlive; // 0x149
        public bool disableCache; // 0x14A

        // ── Methods ──
        public void get_Uri(){} // RVA: 0x2F8380
        public void set_Uri(){} // RVA: 0x2DEE30
        public void get_MethodType(){} // RVA: 0x2F84E0
        public void set_MethodType(){} // RVA: 0x2F84F0
        public void get_RawData(){} // RVA: 0x30B0C0
        public void set_RawData(){} // RVA: 0x30B0D0
        public void get_UploadStream(){} // RVA: 0x30B130
        public void set_UploadStream(){} // RVA: 0x2DEE90
        public void get_DisposeUploadStream(){} // RVA: 0x303450
        public void set_DisposeUploadStream(){} // RVA: 0x303460
        public void get_UseUploadStreamLength(){} // RVA: 0x303470
        public void set_UseUploadStreamLength(){} // RVA: 0x303480
        public void get_IsKeepAlive(){} // RVA: 0x9438EC0
        public void set_IsKeepAlive(){} // RVA: 0x9438ED0
        public void get_DisableCache(){} // RVA: 0x9438F40
        public void set_DisableCache(){} // RVA: 0x9438F50
        public void get_CacheOnly(){} // RVA: 0x9438FC0
        public void set_CacheOnly(){} // RVA: 0x9438FD0
        public void get_UseStreaming(){} // RVA: 0x9413E70
        public void set_UseStreaming(){} // RVA: 0x9439040
        public void get_StreamFragmentSize(){} // RVA: 0x627A2E0
        public void set_StreamFragmentSize(){} // RVA: 0x94390B0
        public void get_MaxFragmentQueueLength(){} // RVA: 0x37E080
        public void set_MaxFragmentQueueLength(){} // RVA: 0x37E090
        public void get_Callback(){} // RVA: 0x358730
        public void set_Callback(){} // RVA: 0x358740
        public void get_DisableRetry(){} // RVA: 0x306020
        public void set_DisableRetry(){} // RVA: 0x306030
        public void get_IsRedirected(){} // RVA: 0x115A230
        public void set_IsRedirected(){} // RVA: 0x114F200
        public void get_RedirectUri(){} // RVA: 0x358D50
        public void set_RedirectUri(){} // RVA: 0x358D60
        public void get_CurrentUri(){} // RVA: 0x9439170
        public void get_Response(){} // RVA: 0x3A5590
        public void set_Response(){} // RVA: 0x3A55A0
        public void get_ProxyResponse(){} // RVA: 0x4C7C50
        public void set_ProxyResponse(){} // RVA: 0x4C34F0
        public void get_Exception(){} // RVA: 0x462D00
        public void set_Exception(){} // RVA: 0x464450
        public void get_Tag(){} // RVA: 0x31C010
        public void set_Tag(){} // RVA: 0x463060
        public void get_Credentials(){} // RVA: 0x796DE0
        public void set_Credentials(){} // RVA: 0xB54600
        public void get_HasProxy(){} // RVA: 0x8B5F640
        public void get_Proxy(){} // RVA: 0xA1C8C0
        public void set_Proxy(){} // RVA: 0x9AA650
        public void get_MaxRedirects(){} // RVA: 0x1D76590
        public void set_MaxRedirects(){} // RVA: 0x1D76550
        public void get_UseAlternateSSL(){} // RVA: 0x59FF40
        public void set_UseAlternateSSL(){} // RVA: 0x5A6940
        public void get_IsCookiesEnabled(){} // RVA: 0x5A0300
        public void set_IsCookiesEnabled(){} // RVA: 0x59E540
        public void get_Cookies(){} // RVA: 0x9439180
        public void set_Cookies(){} // RVA: 0xAE5030
        public void get_FormUsage(){} // RVA: 0x20D67F0
        public void set_FormUsage(){} // RVA: 0x601E410
        public void get_State(){} // RVA: 0x3DF1350
        public void set_State(){} // RVA: 0x3DF1360
        public void get_RedirectCount(){} // RVA: 0x1896340
        public void set_RedirectCount(){} // RVA: 0x1896350
        public void add_CustomCertificationValidator(){} // RVA: 0x9439250
        public void remove_CustomCertificationValidator(){} // RVA: 0x9439350
        public void get_ConnectTimeout(){} // RVA: 0x435460
        public void set_ConnectTimeout(){} // RVA: 0x8B8A2E0
        public void get_Timeout(){} // RVA: 0x3FA100
        public void set_Timeout(){} // RVA: 0x68D4D30
        public void get_EnableTimoutForStreaming(){} // RVA: 0x12FD610
        public void set_EnableTimoutForStreaming(){} // RVA: 0x612FB20
        public void get_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x6379020
        public void set_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x6379030
        public void get_Priority(){} // RVA: 0x69A8410
        public void set_Priority(){} // RVA: 0x69A8420
        public void get_CustomCertificateVerifyer(){} // RVA: 0x35E900
        public void set_CustomCertificateVerifyer(){} // RVA: 0x35E910
        public void get_CustomClientCredentialsProvider(){} // RVA: 0x35E970
        public void set_CustomClientCredentialsProvider(){} // RVA: 0x35E980
        public void get_CustomTLSServerNameList(){} // RVA: 0x3482A0
        public void set_CustomTLSServerNameList(){} // RVA: 0x3482B0
        public void get_ProtocolHandler(){} // RVA: 0x72D6570
        public void set_ProtocolHandler(){} // RVA: 0x9439450
        public void add_OnBeforeRedirection(){} // RVA: 0x9439460
        public void remove_OnBeforeRedirection(){} // RVA: 0x9439560
        public void add_OnBeforeHeaderSend(){} // RVA: 0x9439660
        public void remove_OnBeforeHeaderSend(){} // RVA: 0x9439760
        public void get_TryToMinimizeTCPLatency(){} // RVA: 0x66C530
        public void set_TryToMinimizeTCPLatency(){} // RVA: 0x66C8F0
        public void get_SendBufferSize(){} // RVA: 0x6FACBE0
        public void set_SendBufferSize(){} // RVA: 0x6FACBF0
        public void get_ReceiveBufferSize(){} // RVA: 0x13CBAD0
        public void set_ReceiveBufferSize(){} // RVA: 0x13D7860
        public void get_Downloaded(){} // RVA: 0x59E660
        public void set_Downloaded(){} // RVA: 0x63CFC10
        public void get_DownloadLength(){} // RVA: 0xA8EE80
        public void set_DownloadLength(){} // RVA: 0x9439860
        public void get_DownloadProgressChanged(){} // RVA: 0x6917290
        public void set_DownloadProgressChanged(){} // RVA: 0x6B61490
        public void get_UploadStreamLength(){} // RVA: 0x9439870
        public void get_Uploaded(){} // RVA: 0xA933D0
        public void set_Uploaded(){} // RVA: 0x94398C0
        public void get_UploadLength(){} // RVA: 0x3485F0
        public void set_UploadLength(){} // RVA: 0x63A7620
        public void get_UploadProgressChanged(){} // RVA: 0x167DAF0
        public void set_UploadProgressChanged(){} // RVA: 0x1686780
        public void get_Headers(){} // RVA: 0xD8A610
        public void set_Headers(){} // RVA: 0xD95D10
        public void .ctor(){} // RVA: 0x9439F70 | overloaded x8
        public void AddField(){} // RVA: 0x943A750 | overloaded x2
        public void AddBinaryData(){} // RVA: 0x943A880 | overloaded x3
        public void SetForm(){} // RVA: 0xD93D70
        public void GetFormFields(){} // RVA: 0x943A970
        public void ClearForm(){} // RVA: 0x943AA50
        public void SelectFormImplementation(){} // RVA: 0x943AB10
        public void AddHeader(){} // RVA: 0x943AC50
        public void SetHeader(){} // RVA: 0x943AEF0
        public void RemoveHeader(){} // RVA: 0x943B1D0
        public void HasHeader(){} // RVA: 0x943B240
        public void GetFirstHeaderValue(){} // RVA: 0x943B2C0
        public void GetHeaderValues(){} // RVA: 0x943B3A0
        public void RemoveHeaders(){} // RVA: 0x943B440
        public void SetRangeHeader(){} // RVA: 0x943B580 | overloaded x2
        public void EnumerateHeaders(){} // RVA: 0x943B690 | overloaded x2
        public void SendHeaders(){} // RVA: 0x943C640
        public void DumpHeaders(){} // RVA: 0x943C880
        public void GetEntityBody(){} // RVA: 0x943CA70
        public void SendOutTo(){} // RVA: 0x943CAF0
        public void UpgradeCallback(){} // RVA: 0x943D850
        public void CallCallback(){} // RVA: 0x943D930
        public void CallOnBeforeRedirection(){} // RVA: 0x943D9F0
        public void FinishStreaming(){} // RVA: 0x943DA30
        public void Prepare(){} // RVA: 0x2DD310
        public void CallCustomCertificationValidator(){} // RVA: 0x943DB10
        public void Send(){} // RVA: 0x943DB60
        public void Abort(){} // RVA: 0x943DBB0
        public void Clear(){} // RVA: 0x943E120
        public void VerboseLogging(){} // RVA: 0x943E240
        public void get_Current(){} // RVA: 0x519240
        public void MoveNext(){} // RVA: 0x943E360
        public void Reset(){} // RVA: 0x943E370
        public void System.Collections.Generic.IEnumerator<BestHTTP.HTTPRequest>.get_Current(){} // RVA: 0x1A3F520
        public void Dispose(){} // RVA: 0x943E3B0
        public void .cctor(){} // RVA: 0x943E3D0
    }

    public class HTTPResponse
    {
        public byte CR;
        public byte LF;
        public int MinBufferSize;
        public int <VersionMajor>k__BackingField; // 0x10
        public int <VersionMinor>k__BackingField; // 0x14
        public int <StatusCode>k__BackingField; // 0x18
        public string <Message>k__BackingField; // 0x20
        public bool <IsStreamed>k__BackingField; // 0x28
        public bool <IsStreamingFinished>k__BackingField; // 0x29
        public bool <IsFromCache>k__BackingField; // 0x2A
        public BestHTTP.Caching.HTTPCacheFileInfo <CacheFileInfo>k__BackingField; // 0x30
        public bool <IsCacheOnly>k__BackingField; // 0x38
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<string>> <Headers>k__BackingField; // 0x40
        public byte[] <Data>k__BackingField; // 0x48
        public bool <IsUpgraded>k__BackingField; // 0x50
        public System.Collections.Generic.List`1<BestHTTP.Cookies.Cookie> <Cookies>k__BackingField; // 0x58
        public string dataAsText; // 0x60

        // ── Methods ──
        public void get_VersionMajor(){} // RVA: 0x32A5C0
        public void set_VersionMajor(){} // RVA: 0x2E00C0
        public void get_VersionMinor(){} // RVA: 0x8ABED0
        public void set_VersionMinor(){} // RVA: 0x8AC660
        public void get_StatusCode(){} // RVA: 0x5BED50
        public void set_StatusCode(){} // RVA: 0x6374E0
        public void get_IsSuccess(){} // RVA: 0x943EC90
        public void get_Message(){} // RVA: 0x30B0C0
        public void set_Message(){} // RVA: 0x30B0D0
        public void get_IsStreamed(){} // RVA: 0x6E8A80
        public void set_IsStreamed(){} // RVA: 0x6E8B80
        public void get_IsStreamingFinished(){} // RVA: 0xC36000
        public void set_IsStreamingFinished(){} // RVA: 0x190AB20
        public void get_IsFromCache(){} // RVA: 0x205EA40
        public void set_IsFromCache(){} // RVA: 0x205EA30
        public void get_CacheFileInfo(){} // RVA: 0x6374D0
        public void set_CacheFileInfo(){} // RVA: 0x30B890
        public void get_IsCacheOnly(){} // RVA: 0x4A6500
        public void set_IsCacheOnly(){} // RVA: 0x4A78C0
        public void get_Headers(){} // RVA: 0x35A740
        public void set_Headers(){} // RVA: 0x305200
        public void get_Data(){} // RVA: 0x358730
        public void set_Data(){} // RVA: 0x358740
        public void get_IsUpgraded(){} // RVA: 0x3978E0
        public void set_IsUpgraded(){} // RVA: 0x3978F0
        public void get_Cookies(){} // RVA: 0x3A5500
        public void set_Cookies(){} // RVA: 0x3A5510
        public void get_DataAsText(){} // RVA: 0x943ECB0
        public void get_DataAsTexture2D(){} // RVA: 0x943EDC0
        public void get_IsClosedManually(){} // RVA: 0x359320
        public void set_IsClosedManually(){} // RVA: 0x359330
        public void .ctor(){} // RVA: 0x943EF80
        public void Receive(){} // RVA: 0x943F160
        public void ReadPayload(){} // RVA: 0x943FB70
        public void ReadHeaders(){} // RVA: 0x943FDA0
        public void AddHeader(){} // RVA: 0x943FFA0
        public void GetHeaderValues(){} // RVA: 0x9440240
        public void GetFirstHeaderValue(){} // RVA: 0x94402F0
        public void HasHeaderWithValue(){} // RVA: 0x94403E0
        public void HasHeader(){} // RVA: 0x9440550
        public void GetRange(){} // RVA: 0x9440570
        public void ReadTo(){} // RVA: 0x9440B30 | overloaded x2
        public void NoTrimReadTo(){} // RVA: 0x9440E30
        public void ReadChunkLength(){} // RVA: 0x94410D0
        public void ReadChunked(){} // RVA: 0x9441300
        public void ReadRaw(){} // RVA: 0x9441C30
        public void ReadUnknownSize(){} // RVA: 0x94422A0
        public void DecodeStream(){} // RVA: 0x9442960
        public void CloseDecompressors(){} // RVA: 0x9442D60
        public void Decompress(){} // RVA: 0x9442F10
        public void BeginReceiveStreamFragments(){} // RVA: 0x9443310
        public void FeedStreamFragment(){} // RVA: 0x9443430
        public void FlushRemainingFragmentBuffer(){} // RVA: 0x94436C0
        public void AddStreamedFragment(){} // RVA: 0x9443920
        public void WaitWhileFragmentQueueIsFull(){} // RVA: 0x9443C40
        public void FragmentQueueIsFull(){} // RVA: 0x9443D90
        public void GetStreamedFragments(){} // RVA: 0x9444030
        public void HasStreamedFragments(){} // RVA: 0x9444360
        public void FinishStreaming(){} // RVA: 0x9444460
        public void VerboseLogging(){} // RVA: 0x9444510
        public void Dispose(){} // RVA: 0x9444680
    }

    public class HTTPUpdateDelegator
    {
        public BestHTTP.HTTPUpdateDelegator <Instance>k__BackingField;
        public bool <IsCreated>k__BackingField; // 0x8
        public bool <IsThreaded>k__BackingField; // 0x9
        public bool <IsThreadRunning>k__BackingField; // 0xA
        public int <ThreadFrequencyInMS>k__BackingField; // 0xC

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x9444820
        public void set_Instance(){} // RVA: 0x9444880
        public void get_IsCreated(){} // RVA: 0x9444930
        public void set_IsCreated(){} // RVA: 0x9444990
        public void get_IsThreaded(){} // RVA: 0x94449F0
        public void set_IsThreaded(){} // RVA: 0x9444A50
        public void get_IsThreadRunning(){} // RVA: 0x9444AB0
        public void set_IsThreadRunning(){} // RVA: 0x9444B10
        public void get_ThreadFrequencyInMS(){} // RVA: 0x9444B70
        public void set_ThreadFrequencyInMS(){} // RVA: 0x9444BD0
        public void .cctor(){} // RVA: 0x9444C30
        public void CheckInstance(){} // RVA: 0x9444C90
        public void Setup(){} // RVA: 0x94451F0
        public void ThreadFunc(){} // RVA: 0x9445400
        public void Update(){} // RVA: 0x94456A0
        public void OnDisable(){} // RVA: 0x94457C0
        public void OnApplicationPause(){} // RVA: 0x9445880
        public void OnApplicationQuit(){} // RVA: 0x9445920
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class IProtocol
    {
        // ── Methods ──
        public void get_IsClosed(){} // RVA: 0xDBE0
        public void HandleEvents(){} // RVA: 0x24A50
    }

    public class KeepAliveHeader
    {
        public System.TimeSpan <TimeOut>k__BackingField; // 0x10
        public int <MaxRequests>k__BackingField; // 0x18

        // ── Methods ──
        public void get_TimeOut(){} // RVA: 0x2F8380
        public void set_TimeOut(){} // RVA: 0x1967700
        public void get_MaxRequests(){} // RVA: 0x5BED50
        public void set_MaxRequests(){} // RVA: 0x6374E0
        public void Parse(){} // RVA: 0x942CBD0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OnBeforeHeaderSendDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x338B80
        public void Invoke(){} // RVA: 0x338C60
        public void BeginInvoke(){} // RVA: 0x338C70
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class OnBeforeRedirectionDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61E4DD0
        public void Invoke(){} // RVA: 0x4394E0
        public void BeginInvoke(){} // RVA: 0x1176A90
        public void EndInvoke(){} // RVA: 0x1B3C940
    }

    public class OnDownloadProgressDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x11769B0
        public void Invoke(){} // RVA: 0x4394E0
        public void BeginInvoke(){} // RVA: 0x9438D80
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class OnHeaderEnumerationDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1E11FC0
        public void Invoke(){} // RVA: 0x439370
        public void BeginInvoke(){} // RVA: 0x1AFE3C0
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class OnRequestFinishedDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1E11FC0
        public void Invoke(){} // RVA: 0x439370
        public void BeginInvoke(){} // RVA: 0x1AFE3C0
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class OnUploadProgressDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x11769B0
        public void Invoke(){} // RVA: 0x4394E0
        public void BeginInvoke(){} // RVA: 0x9438E20
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class Proxy
    {
        public System.Uri <Address>k__BackingField; // 0x10
        public BestHTTP.Authentication.Credentials <Credentials>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Address(){} // RVA: 0x2F8380
        public void set_Address(){} // RVA: 0x2DEE30
        public void get_Credentials(){} // RVA: 0x2E07C0
        public void set_Credentials(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0xF19AE0
        public void Connect(){} // RVA: 0x2DC60
        public void GetRequestPath(){} // RVA: 0xCE10
    }

    public class SOCKSProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x63A1980
        public void GetRequestPath(){} // RVA: 0x9445DF0
        public void Connect(){} // RVA: 0x9445E90
        public void WriteString(){} // RVA: 0x94470E0
        public void WriteBytes(){} // RVA: 0x9447210
        public void BufferToHexStr(){} // RVA: 0x9447260
    }

}