// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP
// Classes: 21
// Methods: 415

namespace ThirdParty.BestHTTP.BestHTTP
{
    public class ConnectionBase : Object
    {
        public string _serverAddress; // 0x10
        public 0x6647C03C _state; // 0x18
        public BestHTTP.HTTPRequest _currentRequest; // 0x20
        public System.DateTime _startTime; // 0x28
        public System.DateTime _timedOutStart; // 0x30
        public System.Uri _lastProcessedUri; // 0x38
        public System.DateTime LastProcessTime; // 0x40
        public BestHTTP.HTTPConnectionRecycledDelegate OnConnectionRecycled; // 0x48
        public bool IsThreaded; // 0x50
        public bool _isDisposed; // 0x51
        public object field_10; // 0x15

        // ── Methods ──
        public void get_ServerAddress(){} // RVA: 0x7FFE81116380
        public void set_ServerAddress(){} // RVA: 0x7FFE810FCE30
        public void get_State(){} // RVA: 0x7FFE813DB630
        public void set_State(){} // RVA: 0x7FFE8144DF00
        public void get_IsFree(){} // RVA: 0x7FFE89E8DA60
        public void get_IsActive(){} // RVA: 0x7FFE89E8DA80
        public void get_CurrentRequest(){} // RVA: 0x7FFE811290C0
        public void set_CurrentRequest(){} // RVA: 0x7FFE811290D0
        public void get_IsRemovable(){} // RVA: 0x7FFE89E8DAA0
        public void get_StartTime(){} // RVA: 0x7FFE81129130
        public void set_StartTime(){} // RVA: 0x7FFE8164D390
        public void get_TimedOutStart(){} // RVA: 0x7FFE8144E200
        public void set_TimedOutStart(){} // RVA: 0x7FFE82D00170
        public void get_HasProxy(){} // RVA: 0x7FFE89E8DBC0
        public void get_LastProcessedUri(){} // RVA: 0x7FFE8143BA80
        public void set_LastProcessedUri(){} // RVA: 0x7FFE81437330
        public void .ctor(){} // RVA: 0x7FFE89E8DCA0 | overloaded x2
        public void Abort(){} // RVA: 0x7FFE80E46530
        public void Process(){} // RVA: 0x7FFE89E8DD60
        public void ThreadFunc(){} // RVA: 0x7FFE810FB310
        public void HandleProgressCallback(){} // RVA: 0x7FFE89E8E050
        public void HandleCallback(){} // RVA: 0x7FFE89E8E290
        public void Recycle(){} // RVA: 0x7FFE89E8E390
        public void RecycleNow(){} // RVA: 0x7FFE89E8E410
        public void get_IsDisposed(){} // RVA: 0x7FFE82976380
        public void set_IsDisposed(){} // RVA: 0x7FFE82974280
        public void Dispose(){} // RVA: 0x7FFE89E8E5F0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE89E8E600
    }

    public class FileConnection : ConnectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89E8E650
        public void Abort(){} // RVA: 0x7FFE89E8E660
        public void ThreadFunc(){} // RVA: 0x7FFE89E8E6E0
    }

    public class HTTPConnection : ConnectionBase
    {
        public BestHTTP.PlatformSupport.TcpClient.General.TcpClient Client; // 0x58

        // ── Methods ──
        public void get_IsRemovable(){} // RVA: 0x7FFE89E8F200
        public void .ctor(){} // RVA: 0x7FFE89E8E650
        public void ThreadFunc(){} // RVA: 0x7FFE89E8F3D0
        public void Connect(){} // RVA: 0x7FFE89E90B30
        public void Receive(){} // RVA: 0x7FFE89E91A80
        public void LoadFromCache(){} // RVA: 0x7FFE89E922B0
        public void TryLoadAllFromCache(){} // RVA: 0x7FFE89E928B0
        public void TryStoreInCache(){} // RVA: 0x7FFE89E92B50
        public void GetRedirectUri(){} // RVA: 0x7FFE89E92CB0
        public void Abort(){} // RVA: 0x7FFE89E92EC0
        public void Close(){} // RVA: 0x7FFE89E92F50
        public void Dispose(){} // RVA: 0x7FFE89E93180
        public void <Connect>b__7_0(){} // RVA: 0x7FFE89E931A0
    }

    public class HTTPConnectionRecycledDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE81156C70
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class HTTPManager : Object
    {
        public byte maxConnectionPerServer;
        public bool _keepAliveDefaultValue; // 0x1
        public bool _isCachingDisabled; // 0x2
        public System.TimeSpan _maxConnectionIdleTime; // 0x8
        public bool _isCookiesEnabled; // 0x10
        public uint _cookieJarSize; // 0x14
        public bool _enablePrivateBrowsing; // 0x18
        public System.TimeSpan _connectTimeout; // 0x20
        public System.TimeSpan _requestTimeout; // 0x28
        public System.Func`1<string> _rootCacheFolderProvider; // 0x30
        public BestHTTP.Proxy _proxy; // 0x38
        public BestHTTP.Extensions.HeartbeatManager heartbeats; // 0x40
        public BestHTTP.Logger.ILogger logger; // 0x48
        public Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer _defaultCertificateVerifyer; // 0x50
        public Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider _defaultClientCredentialsProvider; // 0x58
        public bool _useAlternateSSLDefaultValue; // 0x60
        public System.Func`4<BestHTTP.HTTPRequest,System.Security.Cryptography.X509Certificates.X509Certificate,System.Security.Cryptography.X509Certificates.X509Chain,bool> _defaultCertificationValidator; // 0x68
        public bool TryToMinimizeTCPLatency; // 0x70
        public int SendBufferSize; // 0x74

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE89E931F0
        public void get_MaxConnectionPerServer(){} // RVA: 0x7FFE89E93CA0
        public void set_MaxConnectionPerServer(){} // RVA: 0x7FFE89E93D00
        public void get_KeepAliveDefaultValue(){} // RVA: 0x7FFE89E93DB0
        public void set_KeepAliveDefaultValue(){} // RVA: 0x7FFE89E93E10
        public void get_IsCachingDisabled(){} // RVA: 0x7FFE89E93E70
        public void set_IsCachingDisabled(){} // RVA: 0x7FFE89E93ED0
        public void get_MaxConnectionIdleTime(){} // RVA: 0x7FFE89E93F30
        public void set_MaxConnectionIdleTime(){} // RVA: 0x7FFE89E93F90
        public void get_IsCookiesEnabled(){} // RVA: 0x7FFE89E93FF0
        public void set_IsCookiesEnabled(){} // RVA: 0x7FFE89E94050
        public void get_CookieJarSize(){} // RVA: 0x7FFE89E940B0
        public void set_CookieJarSize(){} // RVA: 0x7FFE89E94110
        public void get_EnablePrivateBrowsing(){} // RVA: 0x7FFE89E94170
        public void set_EnablePrivateBrowsing(){} // RVA: 0x7FFE89E941D0
        public void get_ConnectTimeout(){} // RVA: 0x7FFE89E94230
        public void set_ConnectTimeout(){} // RVA: 0x7FFE89E94290
        public void get_RequestTimeout(){} // RVA: 0x7FFE89E942F0
        public void set_RequestTimeout(){} // RVA: 0x7FFE89E94350
        public void get_RootCacheFolderProvider(){} // RVA: 0x7FFE89E943B0
        public void set_RootCacheFolderProvider(){} // RVA: 0x7FFE89E94410
        public void get_Proxy(){} // RVA: 0x7FFE89E944D0
        public void set_Proxy(){} // RVA: 0x7FFE89E94530
        public void get_Heartbeats(){} // RVA: 0x7FFE89E945F0
        public void get_Logger(){} // RVA: 0x7FFE89E948E0
        public void set_Logger(){} // RVA: 0x7FFE89E94A50
        public void get_DefaultCertificateVerifyer(){} // RVA: 0x7FFE89E94B10
        public void set_DefaultCertificateVerifyer(){} // RVA: 0x7FFE89E94B70
        public void get_DefaultClientCredentialsProvider(){} // RVA: 0x7FFE89E94C30
        public void set_DefaultClientCredentialsProvider(){} // RVA: 0x7FFE89E94C90
        public void get_UseAlternateSSLDefaultValue(){} // RVA: 0x7FFE89E94D50
        public void set_UseAlternateSSLDefaultValue(){} // RVA: 0x7FFE89E94DB0
        public void get_DefaultCertificationValidator(){} // RVA: 0x7FFE89E94E10
        public void set_DefaultCertificationValidator(){} // RVA: 0x7FFE89E94E70
        public void get_MaxPathLength(){} // RVA: 0x7FFE89E94F30
        public void set_MaxPathLength(){} // RVA: 0x7FFE89E94F90
        public void get_IsQuitting(){} // RVA: 0x7FFE89E94FF0
        public void set_IsQuitting(){} // RVA: 0x7FFE89E95050
        public void Setup(){} // RVA: 0x7FFE89E950B0
        public void SendRequest(){} // RVA: 0x7FFE89E95700 | overloaded x5
        public void GetGeneralStatistics(){} // RVA: 0x7FFE89E95A00
        public void SendRequestImpl(){} // RVA: 0x7FFE89E95EB0
        public void GetKeyForRequest(){} // RVA: 0x7FFE89E96170
        public void CreateConnection(){} // RVA: 0x7FFE89E96400
        public void FindOrCreateFreeConnection(){} // RVA: 0x7FFE89E96510
        public void CanProcessFromQueue(){} // RVA: 0x7FFE89E96BC0
        public void RecycleConnection(){} // RVA: 0x7FFE89E96CD0
        public void OnConnectionRecylced(){} // RVA: 0x7FFE89E96DB0
        public void GetConnectionWith(){} // RVA: 0x7FFE89E96F80
        public void RemoveFromQueue(){} // RVA: 0x7FFE89E97250
        public void GetRootCacheFolder(){} // RVA: 0x7FFE89E972E0
        public void OnUpdate(){} // RVA: 0x7FFE89E974B0
        public void OnQuit(){} // RVA: 0x7FFE89E986F0
        public void AbortAll(){} // RVA: 0x7FFE89E98940
    }

    public class HTTPProtocolFactory : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE89E99130
        public void GetProtocolFromUri(){} // RVA: 0x7FFE89E992F0
        public void IsSecureProtocol(){} // RVA: 0x7FFE89E993C0
    }

    public class HTTPProxy : Proxy
    {
        public bool _isTransparent; // 0x20
        public bool _sendWholeUri; // 0x21
        public bool _nonTransparentForHTTPS; // 0x22

        // ── Methods ──
        public void get_IsTransparent(){} // RVA: 0x7FFE811E99D0
        public void set_IsTransparent(){} // RVA: 0x7FFE811E99E0
        public void get_SendWholeUri(){} // RVA: 0x7FFE814B5BF0
        public void set_SendWholeUri(){} // RVA: 0x7FFE818933B0
        public void get_NonTransparentForHTTPS(){} // RVA: 0x7FFE8292F1A0
        public void set_NonTransparentForHTTPS(){} // RVA: 0x7FFE822131E0
        public void .ctor(){} // RVA: 0x7FFE89E995B0 | overloaded x5
        public void GetRequestPath(){} // RVA: 0x7FFE89E995F0
        public void Connect(){} // RVA: 0x7FFE89E99710
    }

    public class HTTPRange : Object
    {
        public int _firstBytePos; // 0x10
        public int _lastBytePos; // 0x14
        public int _contentLength; // 0x18
        public bool _isValid; // 0x1C

        // ── Methods ──
        public void get_FirstBytePos(){} // RVA: 0x7FFE811485C0
        public void set_FirstBytePos(){} // RVA: 0x7FFE810FE0C0
        public void get_LastBytePos(){} // RVA: 0x7FFE8164B230
        public void set_LastBytePos(){} // RVA: 0x7FFE8164E0F0
        public void get_ContentLength(){} // RVA: 0x7FFE813DB630
        public void set_ContentLength(){} // RVA: 0x7FFE8144DF00
        public void get_IsValid(){} // RVA: 0x7FFE81116390
        public void set_IsValid(){} // RVA: 0x7FFE811163A0
        public void .ctor(){} // RVA: 0x7FFE89E9AEE0 | overloaded x3
        public void ToString(){} // RVA: 0x7FFE89E9AF00
    }

    public class HTTPRequest : Object
    {
        public byte[] EOL;
        public string[] MethodNames; // 0x8
        public int UploadChunkSize; // 0x10
        public System.Uri _uri; // 0x10
        public 0x6647C19C _methodType; // 0x18
        public byte[] _rawData; // 0x20
        public System.IO.Stream _uploadStream; // 0x28
        public bool _disposeUploadStream; // 0x30
        public bool _useUploadStreamLength; // 0x31
        public BestHTTP.OnUploadProgressDelegate OnUploadProgress; // 0x38
        public int _maxFragmentQueueLength; // 0x40
        public BestHTTP.OnRequestFinishedDelegate _callback; // 0x48
        public BestHTTP.OnDownloadProgressDelegate OnProgress; // 0x50
        public BestHTTP.OnRequestFinishedDelegate OnUpgraded; // 0x58
        public bool _disableRetry; // 0x60
        public bool _isRedirected; // 0x61
        public System.Uri _redirectUri; // 0x68
        public BestHTTP.HTTPResponse _response; // 0x70
        public BestHTTP.HTTPResponse _proxyResponse; // 0x78
        public System.Exception _exception; // 0x80
        public object _tag; // 0x88
        public BestHTTP.Authentication.Credentials _credentials; // 0x90
        public BestHTTP.Proxy _proxy; // 0x98
        public int _maxRedirects; // 0xA0
        public bool _useAlternateSSL; // 0xA4
        public bool _isCookiesEnabled; // 0xA5
        public System.Collections.Generic.List`1<BestHTTP.Cookies.Cookie> customCookies; // 0xA8
        public 0x664A236C _formUsage; // 0xB0
        public 0x6647C3AC _state; // 0xB4
        public int _redirectCount; // 0xB8
        public System.Func`4<BestHTTP.HTTPRequest,System.Security.Cryptography.X509Certificates.X509Certificate,System.Security.Cryptography.X509Certificates.X509Chain,bool> CustomCertificationValidator; // 0xC0
        public System.TimeSpan _connectTimeout; // 0xC8
        public System.TimeSpan _timeout; // 0xD0
        public bool _enableTimoutForStreaming; // 0xD8
        public bool _enableSafeReadOnUnknownContentLength; // 0xD9
        public int _priority; // 0xDC
        public Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer _customCertificateVerifyer; // 0xE0
        public Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider _customClientCredentialsProvider; // 0xE8
        public System.Collections.Generic.List`1<string> _customTLSServerNameList; // 0xF0
        public 0x6647C1F4 _protocolHandler; // 0xF8
        public BestHTTP.OnBeforeRedirectionDelegate onBeforeRedirection; // 0x100
        public BestHTTP.OnBeforeHeaderSendDelegate _onBeforeHeaderSend; // 0x108
        public bool _tryToMinimizeTCPLatency; // 0x110
        public int _sendBufferSize; // 0x114
        public int _receiveBufferSize; // 0x118
        public long _downloaded; // 0x120
        public long _downloadLength; // 0x128
        public bool _downloadProgressChanged; // 0x130
        public long _uploaded; // 0x138
        public long _uploadLength; // 0x140
        public bool _uploadProgressChanged; // 0x148
        public bool isKeepAlive; // 0x149
        public bool disableCache; // 0x14A

        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7FFE81116380
        public void set_Uri(){} // RVA: 0x7FFE810FCE30
        public void get_MethodType(){} // RVA: 0x7FFE811164E0
        public void set_MethodType(){} // RVA: 0x7FFE811164F0
        public void get_RawData(){} // RVA: 0x7FFE811290C0
        public void set_RawData(){} // RVA: 0x7FFE811290D0
        public void get_UploadStream(){} // RVA: 0x7FFE81129130
        public void set_UploadStream(){} // RVA: 0x7FFE810FCE90
        public void get_DisposeUploadStream(){} // RVA: 0x7FFE81121450
        public void set_DisposeUploadStream(){} // RVA: 0x7FFE81121460
        public void get_UseUploadStreamLength(){} // RVA: 0x7FFE81121470
        public void set_UseUploadStreamLength(){} // RVA: 0x7FFE81121480
        public void get_IsKeepAlive(){} // RVA: 0x7FFE89E9B290
        public void set_IsKeepAlive(){} // RVA: 0x7FFE89E9B2A0
        public void get_DisableCache(){} // RVA: 0x7FFE89E9B310
        public void set_DisableCache(){} // RVA: 0x7FFE89E9B320
        public void get_CacheOnly(){} // RVA: 0x7FFE89E9B390
        public void set_CacheOnly(){} // RVA: 0x7FFE89E9B3A0
        public void get_UseStreaming(){} // RVA: 0x7FFE89E9B410
        public void set_UseStreaming(){} // RVA: 0x7FFE89E9B420
        public void get_StreamFragmentSize(){} // RVA: 0x7FFE86DBAD10
        public void set_StreamFragmentSize(){} // RVA: 0x7FFE89E9B490
        public void get_MaxFragmentQueueLength(){} // RVA: 0x7FFE8119C080
        public void set_MaxFragmentQueueLength(){} // RVA: 0x7FFE8119C090
        public void get_Callback(){} // RVA: 0x7FFE81176730
        public void set_Callback(){} // RVA: 0x7FFE81176740
        public void get_DisableRetry(){} // RVA: 0x7FFE81124020
        public void set_DisableRetry(){} // RVA: 0x7FFE81124030
        public void get_IsRedirected(){} // RVA: 0x7FFE81EC3970
        public void set_IsRedirected(){} // RVA: 0x7FFE81EB6360
        public void get_RedirectUri(){} // RVA: 0x7FFE81176D50
        public void set_RedirectUri(){} // RVA: 0x7FFE81176D60
        public void get_CurrentUri(){} // RVA: 0x7FFE89E9B550
        public void get_Response(){} // RVA: 0x7FFE811C3590
        public void set_Response(){} // RVA: 0x7FFE811C35A0
        public void get_ProxyResponse(){} // RVA: 0x7FFE81463AE0
        public void set_ProxyResponse(){} // RVA: 0x7FFE81464570
        public void get_Exception(){} // RVA: 0x7FFE81280C30
        public void set_Exception(){} // RVA: 0x7FFE81282380
        public void get_Tag(){} // RVA: 0x7FFE8113A010
        public void set_Tag(){} // RVA: 0x7FFE81280F90
        public void get_Credentials(){} // RVA: 0x7FFE8154EB60
        public void set_Credentials(){} // RVA: 0x7FFE818CE320
        public void get_HasProxy(){} // RVA: 0x7FFE8967BA20
        public void get_Proxy(){} // RVA: 0x7FFE817AE360
        public void set_Proxy(){} // RVA: 0x7FFE8171B470
        public void get_MaxRedirects(){} // RVA: 0x7FFE82B06FB0
        public void set_MaxRedirects(){} // RVA: 0x7FFE82B06FC0
        public void get_UseAlternateSSL(){} // RVA: 0x7FFE813A1BB0
        public void set_UseAlternateSSL(){} // RVA: 0x7FFE813A4B20
        public void get_IsCookiesEnabled(){} // RVA: 0x7FFE813A10F0
        public void set_IsCookiesEnabled(){} // RVA: 0x7FFE813A2020
        public void get_Cookies(){} // RVA: 0x7FFE89E9B560
        public void set_Cookies(){} // RVA: 0x7FFE81857260
        public void get_FormUsage(){} // RVA: 0x7FFE82E64BF0
        public void set_FormUsage(){} // RVA: 0x7FFE86B5F1F0
        public void get_State(){} // RVA: 0x7FFE84A61A20
        public void set_State(){} // RVA: 0x7FFE84A61A30
        public void get_RedirectCount(){} // RVA: 0x7FFE8260FFA0
        public void set_RedirectCount(){} // RVA: 0x7FFE826140C0
        public void add_CustomCertificationValidator(){} // RVA: 0x7FFE89E9B630
        public void remove_CustomCertificationValidator(){} // RVA: 0x7FFE89E9B730
        public void get_ConnectTimeout(){} // RVA: 0x7FFE81253460
        public void set_ConnectTimeout(){} // RVA: 0x7FFE89DBC280
        public void get_Timeout(){} // RVA: 0x7FFE81218100
        public void set_Timeout(){} // RVA: 0x7FFE87414000
        public void get_EnableTimoutForStreaming(){} // RVA: 0x7FFE82078290
        public void set_EnableTimoutForStreaming(){} // RVA: 0x7FFE86C70900
        public void get_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x7FFE86EB9A40
        public void set_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x7FFE86EB9A50
        public void get_Priority(){} // RVA: 0x7FFE874E76E0
        public void set_Priority(){} // RVA: 0x7FFE874E76F0
        public void get_CustomCertificateVerifyer(){} // RVA: 0x7FFE8117C900
        public void set_CustomCertificateVerifyer(){} // RVA: 0x7FFE8117C910
        public void get_CustomClientCredentialsProvider(){} // RVA: 0x7FFE8117C970
        public void set_CustomClientCredentialsProvider(){} // RVA: 0x7FFE8117C980
        public void get_CustomTLSServerNameList(){} // RVA: 0x7FFE811662A0
        public void set_CustomTLSServerNameList(){} // RVA: 0x7FFE811662B0
        public void get_ProtocolHandler(){} // RVA: 0x7FFE82144660
        public void set_ProtocolHandler(){} // RVA: 0x7FFE8213C830
        public void add_OnBeforeRedirection(){} // RVA: 0x7FFE89E9B830
        public void remove_OnBeforeRedirection(){} // RVA: 0x7FFE89E9B930
        public void add_OnBeforeHeaderSend(){} // RVA: 0x7FFE89E9BA30
        public void remove_OnBeforeHeaderSend(){} // RVA: 0x7FFE89E9BB30
        public void get_TryToMinimizeTCPLatency(){} // RVA: 0x7FFE81472650
        public void set_TryToMinimizeTCPLatency(){} // RVA: 0x7FFE81472660
        public void get_SendBufferSize(){} // RVA: 0x7FFE87AEDA80
        public void set_SendBufferSize(){} // RVA: 0x7FFE87AEDA90
        public void get_ReceiveBufferSize(){} // RVA: 0x7FFE812BC010
        public void set_ReceiveBufferSize(){} // RVA: 0x7FFE82BD1CF0
        public void get_Downloaded(){} // RVA: 0x7FFE813A1DA0
        public void set_Downloaded(){} // RVA: 0x7FFE86F10640
        public void get_DownloadLength(){} // RVA: 0x7FFE8182B890
        public void set_DownloadLength(){} // RVA: 0x7FFE89E9BC30
        public void get_DownloadProgressChanged(){} // RVA: 0x7FFE87456560
        public void set_DownloadProgressChanged(){} // RVA: 0x7FFE876A0740
        public void get_UploadStreamLength(){} // RVA: 0x7FFE89E9BC40
        public void get_Uploaded(){} // RVA: 0x7FFE8181EA70
        public void set_Uploaded(){} // RVA: 0x7FFE89E9BC90
        public void get_UploadLength(){} // RVA: 0x7FFE811665F0
        public void set_UploadLength(){} // RVA: 0x7FFE86EE8050
        public void get_UploadProgressChanged(){} // RVA: 0x7FFE823E5620
        public void set_UploadProgressChanged(){} // RVA: 0x7FFE823F09C0
        public void get_Headers(){} // RVA: 0x7FFE81B16560
        public void set_Headers(){} // RVA: 0x7FFE81B21880
        public void .ctor(){} // RVA: 0x7FFE89E9C340 | overloaded x8
        public void AddField(){} // RVA: 0x7FFE89E9CB20 | overloaded x2
        public void AddBinaryData(){} // RVA: 0x7FFE89E9CC50 | overloaded x3
        public void SetForm(){} // RVA: 0x7FFE81B23F80
        public void GetFormFields(){} // RVA: 0x7FFE89E9CD40
        public void ClearForm(){} // RVA: 0x7FFE89E9CE20
        public void SelectFormImplementation(){} // RVA: 0x7FFE89E9CEE0
        public void AddHeader(){} // RVA: 0x7FFE89E9D020
        public void SetHeader(){} // RVA: 0x7FFE89E9D2C0
        public void RemoveHeader(){} // RVA: 0x7FFE89E9D5A0
        public void HasHeader(){} // RVA: 0x7FFE89E9D610
        public void GetFirstHeaderValue(){} // RVA: 0x7FFE89E9D690
        public void GetHeaderValues(){} // RVA: 0x7FFE89E9D770
        public void RemoveHeaders(){} // RVA: 0x7FFE89E9D810
        public void SetRangeHeader(){} // RVA: 0x7FFE89E9D950 | overloaded x2
        public void EnumerateHeaders(){} // RVA: 0x7FFE89E9DA60 | overloaded x2
        public void SendHeaders(){} // RVA: 0x7FFE89E9EA10
        public void DumpHeaders(){} // RVA: 0x7FFE89E9EC50
        public void GetEntityBody(){} // RVA: 0x7FFE89E9EE40
        public void SendOutTo(){} // RVA: 0x7FFE89E9EEC0
        public void UpgradeCallback(){} // RVA: 0x7FFE89E9FC20
        public void CallCallback(){} // RVA: 0x7FFE89E9FD00
        public void CallOnBeforeRedirection(){} // RVA: 0x7FFE89E9FDC0
        public void FinishStreaming(){} // RVA: 0x7FFE89E9FE00
        public void Prepare(){} // RVA: 0x7FFE810FB310
        public void CallCustomCertificationValidator(){} // RVA: 0x7FFE89E9FEE0
        public void Send(){} // RVA: 0x7FFE89E9FF30
        public void Abort(){} // RVA: 0x7FFE89E9FF80
        public void Clear(){} // RVA: 0x7FFE89EA04F0
        public void VerboseLogging(){} // RVA: 0x7FFE89EA0610
        public void get_Current(){} // RVA: 0x7FFE813240E0
        public void MoveNext(){} // RVA: 0x7FFE89EA0730
        public void Reset(){} // RVA: 0x7FFE89EA0740
        public void System.Collections.Generic.IEnumerator<BestHTTP.HTTPRequest>.get_Current(){} // RVA: 0x7FFE827C4A80
        public void Dispose(){} // RVA: 0x7FFE89EA0780
        public void .cctor(){} // RVA: 0x7FFE89EA07A0
    }

    public class HTTPResponse : Object
    {
        public byte CR;
        public byte LF;
        public int MinBufferSize;
        public int _versionMajor; // 0x10
        public int _versionMinor; // 0x14
        public int _statusCode; // 0x18
        public string _message; // 0x20
        public bool _isStreamed; // 0x28
        public bool _isStreamingFinished; // 0x29
        public bool _isFromCache; // 0x2A
        public BestHTTP.Caching.HTTPCacheFileInfo _cacheFileInfo; // 0x30
        public bool _isCacheOnly; // 0x38
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<string>> _headers; // 0x40
        public byte[] _data; // 0x48
        public bool _isUpgraded; // 0x50
        public System.Collections.Generic.List`1<BestHTTP.Cookies.Cookie> _cookies; // 0x58
        public string dataAsText; // 0x60

        // ── Methods ──
        public void get_VersionMajor(){} // RVA: 0x7FFE811485C0
        public void set_VersionMajor(){} // RVA: 0x7FFE810FE0C0
        public void get_VersionMinor(){} // RVA: 0x7FFE8164B230
        public void set_VersionMinor(){} // RVA: 0x7FFE8164E0F0
        public void get_StatusCode(){} // RVA: 0x7FFE813DB630
        public void set_StatusCode(){} // RVA: 0x7FFE8144DF00
        public void get_IsSuccess(){} // RVA: 0x7FFE89EA1060
        public void get_Message(){} // RVA: 0x7FFE811290C0
        public void set_Message(){} // RVA: 0x7FFE811290D0
        public void get_IsStreamed(){} // RVA: 0x7FFE815F1380
        public void set_IsStreamed(){} // RVA: 0x7FFE81C15740
        public void get_IsStreamingFinished(){} // RVA: 0x7FFE819C2EA0
        public void set_IsStreamingFinished(){} // RVA: 0x7FFE8268C820
        public void get_IsFromCache(){} // RVA: 0x7FFE82DEC5E0
        public void set_IsFromCache(){} // RVA: 0x7FFE82DEC5B0
        public void get_CacheFileInfo(){} // RVA: 0x7FFE8144E200
        public void set_CacheFileInfo(){} // RVA: 0x7FFE81129890
        public void get_IsCacheOnly(){} // RVA: 0x7FFE812CF770
        public void set_IsCacheOnly(){} // RVA: 0x7FFE812D0010
        public void get_Headers(){} // RVA: 0x7FFE81178740
        public void set_Headers(){} // RVA: 0x7FFE81123200
        public void get_Data(){} // RVA: 0x7FFE81176730
        public void set_Data(){} // RVA: 0x7FFE81176740
        public void get_IsUpgraded(){} // RVA: 0x7FFE811B58E0
        public void set_IsUpgraded(){} // RVA: 0x7FFE811B58F0
        public void get_Cookies(){} // RVA: 0x7FFE811C3500
        public void set_Cookies(){} // RVA: 0x7FFE811C3510
        public void get_DataAsText(){} // RVA: 0x7FFE89EA1080
        public void get_DataAsTexture2D(){} // RVA: 0x7FFE89EA1190
        public void get_IsClosedManually(){} // RVA: 0x7FFE81177320
        public void set_IsClosedManually(){} // RVA: 0x7FFE81177330
        public void .ctor(){} // RVA: 0x7FFE89EA1350
        public void Receive(){} // RVA: 0x7FFE89EA1530
        public void ReadPayload(){} // RVA: 0x7FFE89EA1F40
        public void ReadHeaders(){} // RVA: 0x7FFE89EA2170
        public void AddHeader(){} // RVA: 0x7FFE89EA2370
        public void GetHeaderValues(){} // RVA: 0x7FFE89EA2610
        public void GetFirstHeaderValue(){} // RVA: 0x7FFE89EA26C0
        public void HasHeaderWithValue(){} // RVA: 0x7FFE89EA27B0
        public void HasHeader(){} // RVA: 0x7FFE89EA2920
        public void GetRange(){} // RVA: 0x7FFE89EA2940
        public void ReadTo(){} // RVA: 0x7FFE89EA2F00 | overloaded x2
        public void NoTrimReadTo(){} // RVA: 0x7FFE89EA3200
        public void ReadChunkLength(){} // RVA: 0x7FFE89EA34A0
        public void ReadChunked(){} // RVA: 0x7FFE89EA36D0
        public void ReadRaw(){} // RVA: 0x7FFE89EA4000
        public void ReadUnknownSize(){} // RVA: 0x7FFE89EA4670
        public void DecodeStream(){} // RVA: 0x7FFE89EA4D30
        public void CloseDecompressors(){} // RVA: 0x7FFE89EA5130
        public void Decompress(){} // RVA: 0x7FFE89EA52E0
        public void BeginReceiveStreamFragments(){} // RVA: 0x7FFE89EA56E0
        public void FeedStreamFragment(){} // RVA: 0x7FFE89EA5800
        public void FlushRemainingFragmentBuffer(){} // RVA: 0x7FFE89EA5A90
        public void AddStreamedFragment(){} // RVA: 0x7FFE89EA5CF0
        public void WaitWhileFragmentQueueIsFull(){} // RVA: 0x7FFE89EA6010
        public void FragmentQueueIsFull(){} // RVA: 0x7FFE89EA6160
        public void GetStreamedFragments(){} // RVA: 0x7FFE89EA6400
        public void HasStreamedFragments(){} // RVA: 0x7FFE89EA6730
        public void FinishStreaming(){} // RVA: 0x7FFE89EA6830
        public void VerboseLogging(){} // RVA: 0x7FFE89EA68E0
        public void Dispose(){} // RVA: 0x7FFE89EA6A50
    }

    public class HTTPUpdateDelegator : MonoBehaviour
    {
        public BestHTTP.HTTPUpdateDelegator _instance;
        public bool _isCreated; // 0x8
        public bool _isThreaded; // 0x9
        public bool _isThreadRunning; // 0xA
        public int _threadFrequencyInMS; // 0xC

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE89EA6BF0
        public void set_Instance(){} // RVA: 0x7FFE89EA6C50
        public void get_IsCreated(){} // RVA: 0x7FFE89EA6D00
        public void set_IsCreated(){} // RVA: 0x7FFE89EA6D60
        public void get_IsThreaded(){} // RVA: 0x7FFE89EA6DC0
        public void set_IsThreaded(){} // RVA: 0x7FFE89EA6E20
        public void get_IsThreadRunning(){} // RVA: 0x7FFE89EA6E80
        public void set_IsThreadRunning(){} // RVA: 0x7FFE89EA6EE0
        public void get_ThreadFrequencyInMS(){} // RVA: 0x7FFE89EA6F40
        public void set_ThreadFrequencyInMS(){} // RVA: 0x7FFE89EA6FA0
        public void .cctor(){} // RVA: 0x7FFE89EA7000
        public void CheckInstance(){} // RVA: 0x7FFE89EA7060
        public void Setup(){} // RVA: 0x7FFE89EA75C0
        public void ThreadFunc(){} // RVA: 0x7FFE89EA77D0
        public void Update(){} // RVA: 0x7FFE89EA7A70
        public void OnDisable(){} // RVA: 0x7FFE89EA7B90
        public void OnApplicationPause(){} // RVA: 0x7FFE89EA7C50
        public void OnApplicationQuit(){} // RVA: 0x7FFE89EA7CF0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class IProtocol
    {
        // ── Methods ──
        public void get_IsClosed(){} // RVA: 0x7FFE80E2F150
        public void HandleEvents(){} // RVA: 0x7FFE80E45FE0
    }

    public class KeepAliveHeader : Object
    {
        public System.TimeSpan _timeOut; // 0x10
        public int _maxRequests; // 0x18

        // ── Methods ──
        public void get_TimeOut(){} // RVA: 0x7FFE81116380
        public void set_TimeOut(){} // RVA: 0x7FFE826F2ED0
        public void get_MaxRequests(){} // RVA: 0x7FFE813DB630
        public void set_MaxRequests(){} // RVA: 0x7FFE8144DF00
        public void Parse(){} // RVA: 0x7FFE89E8EFA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OnBeforeHeaderSendDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81156B80
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE81156C70
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class OnBeforeRedirectionDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D25C70
        public void Invoke(){} // RVA: 0x7FFE812574E0
        public void BeginInvoke(){} // RVA: 0x7FFE81EE8B90
        public void EndInvoke(){} // RVA: 0x7FFE828C6E90
    }

    public class OnDownloadProgressDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81EE8AB0
        public void Invoke(){} // RVA: 0x7FFE812574E0
        public void BeginInvoke(){} // RVA: 0x7FFE89E9B150
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class OnHeaderEnumerationDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82B9EE00
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class OnRequestFinishedDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82B9EE00
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class OnUploadProgressDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81EE8AB0
        public void Invoke(){} // RVA: 0x7FFE812574E0
        public void BeginInvoke(){} // RVA: 0x7FFE89E9B1F0
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class Proxy : Object
    {
        public System.Uri _address; // 0x10
        public BestHTTP.Authentication.Credentials _credentials; // 0x18

        // ── Methods ──
        public void get_Address(){} // RVA: 0x7FFE81116380
        public void set_Address(){} // RVA: 0x7FFE810FCE30
        public void get_Credentials(){} // RVA: 0x7FFE810FE7C0
        public void set_Credentials(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void Connect(){} // RVA: 0x7FFE80E4F230
        public void GetRequestPath(){} // RVA: 0x7FFE80E2E390
    }

    public class SOCKSProxy : Proxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EE23A0
        public void GetRequestPath(){} // RVA: 0x7FFE89EA81C0
        public void Connect(){} // RVA: 0x7FFE89EA8260
        public void WriteString(){} // RVA: 0x7FFE89EA94B0
        public void WriteBytes(){} // RVA: 0x7FFE89EA95E0
        public void BufferToHexStr(){} // RVA: 0x7FFE89EA9630
    }

}