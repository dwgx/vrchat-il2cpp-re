// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP
// Classes: 21
// Methods: 415

namespace ThirdParty.BestHTTP.BestHTTP
{
    public class ConnectionBase : Object
    {
        public string ServerAddress; // 0x10
        public 0x6B0838A8 State; // 0x18
        public BestHTTP.HTTPRequest IsFree; // 0x20
        public System.DateTime IsActive; // 0x28
        public System.DateTime CurrentRequest; // 0x30
        public System.Uri IsRemovable; // 0x38
        public System.DateTime StartTime; // 0x40
        public BestHTTP.HTTPConnectionRecycledDelegate TimedOutStart; // 0x48
        public bool HasProxy; // 0x50
        public bool LastProcessedUri; // 0x51

        // ── Methods ──
        public void get_ServerAddress(){} // RVA: 0x7FFAC2F3C380
        public void set_ServerAddress(){} // RVA: 0x7FFAC2F22E30
        public void get_State(){} // RVA: 0x7FFAC3157800
        public void set_State(){} // RVA: 0x7FFAC392CD10
        public void get_IsFree(){} // RVA: 0x7FFACBA34440
        public void get_IsActive(){} // RVA: 0x7FFACBA34460
        public void get_CurrentRequest(){} // RVA: 0x7FFAC2F4F0C0
        public void set_CurrentRequest(){} // RVA: 0x7FFAC2F4F0D0
        public void get_IsRemovable(){} // RVA: 0x7FFACBA34480
        public void get_StartTime(){} // RVA: 0x7FFAC2F4F130
        public void set_StartTime(){} // RVA: 0x7FFAC33D3BF0
        public void get_TimedOutStart(){} // RVA: 0x7FFAC31D95E0
        public void set_TimedOutStart(){} // RVA: 0x7FFAC4A98000
        public void get_HasProxy(){} // RVA: 0x7FFACBA345A0
        public void get_LastProcessedUri(){} // RVA: 0x7FFAC31D0140
        public void set_LastProcessedUri(){} // RVA: 0x7FFAC31D0C20
        public void .ctor(){} // RVA: 0x7FFACBA34680 | overloaded x2
        public void Abort(){} // RVA: 0x7FFAC2C70ED0
        public void Process(){} // RVA: 0x7FFACBA34740
        public void ThreadFunc(){} // RVA: 0x7FFAC2F21310
        public void HandleProgressCallback(){} // RVA: 0x7FFACBA34A30
        public void HandleCallback(){} // RVA: 0x7FFACBA34C70
        public void Recycle(){} // RVA: 0x7FFACBA34D70
        public void RecycleNow(){} // RVA: 0x7FFACBA34DF0
        public void get_IsDisposed(){} // RVA: 0x7FFAC8489120
        public void set_IsDisposed(){} // RVA: 0x7FFAC8946F20
        public void Dispose(){} // RVA: 0x7FFACBA34FD0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFACBA34FE0
    }

    public class FileConnection : ConnectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA35030
        public void Abort(){} // RVA: 0x7FFACBA35040
        public void ThreadFunc(){} // RVA: 0x7FFACBA350C0
    }

    public class HTTPConnection : ConnectionBase
    {
        public BestHTTP.PlatformSupport.TcpClient.General.TcpClient IsRemovable; // 0x58
        public System.IO.Stream Stream; // 0x60
        public BestHTTP.KeepAliveHeader KeepAlive; // 0x68

        // ── Methods ──
        public void get_IsRemovable(){} // RVA: 0x7FFACBA35BE0
        public void .ctor(){} // RVA: 0x7FFACBA35030
        public void ThreadFunc(){} // RVA: 0x7FFACBA35DB0
        public void Connect(){} // RVA: 0x7FFACBA37510
        public void Receive(){} // RVA: 0x7FFACBA38460
        public void LoadFromCache(){} // RVA: 0x7FFACBA38C90
        public void TryLoadAllFromCache(){} // RVA: 0x7FFACBA39290
        public void TryStoreInCache(){} // RVA: 0x7FFACBA39530
        public void GetRedirectUri(){} // RVA: 0x7FFACBA39690
        public void Abort(){} // RVA: 0x7FFACBA398A0
        public void Close(){} // RVA: 0x7FFACBA39930
        public void Dispose(){} // RVA: 0x7FFACBA39B60
        public void <Connect>b__7_0(){} // RVA: 0x7FFACBA39B80
    }

    public class HTTPConnectionRecycledDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
        public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class HTTPManager : Object
    {
        public byte MaxConnectionPerServer;
        public bool KeepAliveDefaultValue; // 0x1
        public bool IsCachingDisabled; // 0x2
        public System.TimeSpan MaxConnectionIdleTime; // 0x8
        public bool IsCookiesEnabled; // 0x10
        public uint CookieJarSize; // 0x14
        public bool EnablePrivateBrowsing; // 0x18
        public System.TimeSpan ConnectTimeout; // 0x20
        public System.TimeSpan RequestTimeout; // 0x28
        public System.Func`1<string> RootCacheFolderProvider; // 0x30
        public BestHTTP.Proxy Proxy; // 0x38
        public BestHTTP.Extensions.HeartbeatManager Heartbeats; // 0x40
        public BestHTTP.Logger.ILogger Logger; // 0x48
        public Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer DefaultCertificateVerifyer; // 0x50
        public Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider DefaultClientCredentialsProvider; // 0x58
        public bool UseAlternateSSLDefaultValue; // 0x60
        public System.Func`4<BestHTTP.HTTPRequest,System.Security.Cryptography.X509Certificates.X509Certificate,System.Security.Cryptography.X509Certificates.X509Chain,bool> DefaultCertificationValidator; // 0x68
        public bool MaxPathLength; // 0x70
        public int IsQuitting; // 0x74
        public int ReceiveBufferSize; // 0x78
        public BestHTTP.PlatformSupport.FileSystem.IIOService IOService; // 0x80
        public int <MaxPathLength>k__BackingField; // 0x88
        public string UserAgent; // 0x90
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<BestHTTP.ConnectionBase>> Connections; // 0x98
        public System.Collections.Generic.List`1<BestHTTP.ConnectionBase> ActiveConnections; // 0xA0
        public System.Collections.Generic.List`1<BestHTTP.ConnectionBase> FreeConnections; // 0xA8
        public System.Collections.Generic.List`1<BestHTTP.ConnectionBase> RecycledConnections; // 0xB0
        public System.Collections.Generic.List`1<BestHTTP.HTTPRequest> RequestQueue; // 0xB8
        public bool IsCallingCallbacks; // 0xC0
        public object Locker; // 0xC8
        public bool <IsQuitting>k__BackingField; // 0xD0

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBA39BD0
        public void get_MaxConnectionPerServer(){} // RVA: 0x7FFACBA3A680
        public void set_MaxConnectionPerServer(){} // RVA: 0x7FFACBA3A6E0
        public void get_KeepAliveDefaultValue(){} // RVA: 0x7FFACBA3A790
        public void set_KeepAliveDefaultValue(){} // RVA: 0x7FFACBA3A7F0
        public void get_IsCachingDisabled(){} // RVA: 0x7FFACBA3A850
        public void set_IsCachingDisabled(){} // RVA: 0x7FFACBA3A8B0
        public void get_MaxConnectionIdleTime(){} // RVA: 0x7FFACBA3A910
        public void set_MaxConnectionIdleTime(){} // RVA: 0x7FFACBA3A970
        public void get_IsCookiesEnabled(){} // RVA: 0x7FFACBA3A9D0
        public void set_IsCookiesEnabled(){} // RVA: 0x7FFACBA3AA30
        public void get_CookieJarSize(){} // RVA: 0x7FFACBA3AA90
        public void set_CookieJarSize(){} // RVA: 0x7FFACBA3AAF0
        public void get_EnablePrivateBrowsing(){} // RVA: 0x7FFACBA3AB50
        public void set_EnablePrivateBrowsing(){} // RVA: 0x7FFACBA3ABB0
        public void get_ConnectTimeout(){} // RVA: 0x7FFACBA3AC10
        public void set_ConnectTimeout(){} // RVA: 0x7FFACBA3AC70
        public void get_RequestTimeout(){} // RVA: 0x7FFACBA3ACD0
        public void set_RequestTimeout(){} // RVA: 0x7FFACBA3AD30
        public void get_RootCacheFolderProvider(){} // RVA: 0x7FFACBA3AD90
        public void set_RootCacheFolderProvider(){} // RVA: 0x7FFACBA3ADF0
        public void get_Proxy(){} // RVA: 0x7FFACBA3AEB0
        public void set_Proxy(){} // RVA: 0x7FFACBA3AF10
        public void get_Heartbeats(){} // RVA: 0x7FFACBA3AFD0
        public void get_Logger(){} // RVA: 0x7FFACBA3B2C0
        public void set_Logger(){} // RVA: 0x7FFACBA3B430
        public void get_DefaultCertificateVerifyer(){} // RVA: 0x7FFACBA3B4F0
        public void set_DefaultCertificateVerifyer(){} // RVA: 0x7FFACBA3B550
        public void get_DefaultClientCredentialsProvider(){} // RVA: 0x7FFACBA3B610
        public void set_DefaultClientCredentialsProvider(){} // RVA: 0x7FFACBA3B670
        public void get_UseAlternateSSLDefaultValue(){} // RVA: 0x7FFACBA3B730
        public void set_UseAlternateSSLDefaultValue(){} // RVA: 0x7FFACBA3B790
        public void get_DefaultCertificationValidator(){} // RVA: 0x7FFACBA3B7F0
        public void set_DefaultCertificationValidator(){} // RVA: 0x7FFACBA3B850
        public void get_MaxPathLength(){} // RVA: 0x7FFACBA3B910
        public void set_MaxPathLength(){} // RVA: 0x7FFACBA3B970
        public void get_IsQuitting(){} // RVA: 0x7FFACBA3B9D0
        public void set_IsQuitting(){} // RVA: 0x7FFACBA3BA30
        public void Setup(){} // RVA: 0x7FFACBA3BA90
        public void SendRequest(){} // RVA: 0x7FFACBA3C0E0 | overloaded x5
        public void GetGeneralStatistics(){} // RVA: 0x7FFACBA3C3E0
        public void SendRequestImpl(){} // RVA: 0x7FFACBA3C890
        public void GetKeyForRequest(){} // RVA: 0x7FFACBA3CB50
        public void CreateConnection(){} // RVA: 0x7FFACBA3CDE0
        public void FindOrCreateFreeConnection(){} // RVA: 0x7FFACBA3CEF0
        public void CanProcessFromQueue(){} // RVA: 0x7FFACBA3D5A0
        public void RecycleConnection(){} // RVA: 0x7FFACBA3D6B0
        public void OnConnectionRecylced(){} // RVA: 0x7FFACBA3D790
        public void GetConnectionWith(){} // RVA: 0x7FFACBA3D960
        public void RemoveFromQueue(){} // RVA: 0x7FFACBA3DC30
        public void GetRootCacheFolder(){} // RVA: 0x7FFACBA3DCC0
        public void OnUpdate(){} // RVA: 0x7FFACBA3DE90
        public void OnQuit(){} // RVA: 0x7FFACBA3F0D0
        public void AbortAll(){} // RVA: 0x7FFACBA3F320
    }

    public class HTTPProtocolFactory : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFACBA3FB10
        public void GetProtocolFromUri(){} // RVA: 0x7FFACBA3FCD0
        public void IsSecureProtocol(){} // RVA: 0x7FFACBA3FDA0
    }

    public class HTTPProxy : Proxy
    {
        public bool IsTransparent; // 0x20
        public bool SendWholeUri; // 0x21
        public bool NonTransparentForHTTPS; // 0x22

        // ── Methods ──
        public void get_IsTransparent(){} // RVA: 0x7FFAC300F9D0
        public void set_IsTransparent(){} // RVA: 0x7FFAC300F9E0
        public void get_SendWholeUri(){} // RVA: 0x7FFAC322AD20
        public void set_SendWholeUri(){} // RVA: 0x7FFAC376A610
        public void get_NonTransparentForHTTPS(){} // RVA: 0x7FFAC45F8AA0
        public void set_NonTransparentForHTTPS(){} // RVA: 0x7FFAC3F5A420
        public void .ctor(){} // RVA: 0x7FFACBA3FF90 | overloaded x5
        public void GetRequestPath(){} // RVA: 0x7FFACBA3FFD0
        public void Connect(){} // RVA: 0x7FFACBA400F0
    }

    public class HTTPRange : Object
    {
        public int FirstBytePos; // 0x10
        public int LastBytePos; // 0x14
        public int ContentLength; // 0x18
        public bool IsValid; // 0x1C

        // ── Methods ──
        public void get_FirstBytePos(){} // RVA: 0x7FFAC2F6E5C0
        public void set_FirstBytePos(){} // RVA: 0x7FFAC2F240C0
        public void get_LastBytePos(){} // RVA: 0x7FFAC33D5A20
        public void set_LastBytePos(){} // RVA: 0x7FFAC33D4990
        public void get_ContentLength(){} // RVA: 0x7FFAC3157800
        public void set_ContentLength(){} // RVA: 0x7FFAC392CD10
        public void get_IsValid(){} // RVA: 0x7FFAC2F3C390
        public void set_IsValid(){} // RVA: 0x7FFAC2F3C3A0
        public void .ctor(){} // RVA: 0x7FFACBA418C0 | overloaded x3
        public void ToString(){} // RVA: 0x7FFACBA418E0
    }

    public class HTTPRequest : Object
    {
        public byte[] Uri;
        public string[] MethodType; // 0x8
        public int RawData; // 0x10
        public System.Uri UploadStream; // 0x10
        public 0x6B083A08 DisposeUploadStream; // 0x18
        public byte[] UseUploadStreamLength; // 0x20
        public System.IO.Stream IsKeepAlive; // 0x28
        public bool DisableCache; // 0x30
        public bool CacheOnly; // 0x31
        public BestHTTP.OnUploadProgressDelegate UseStreaming; // 0x38
        public int StreamFragmentSize; // 0x40
        public BestHTTP.OnRequestFinishedDelegate MaxFragmentQueueLength; // 0x48
        public BestHTTP.OnDownloadProgressDelegate Callback; // 0x50
        public BestHTTP.OnRequestFinishedDelegate DisableRetry; // 0x58
        public bool IsRedirected; // 0x60
        public bool RedirectUri; // 0x61
        public System.Uri CurrentUri; // 0x68
        public BestHTTP.HTTPResponse Response; // 0x70
        public BestHTTP.HTTPResponse ProxyResponse; // 0x78
        public System.Exception Exception; // 0x80
        public object Tag; // 0x88
        public BestHTTP.Authentication.Credentials Credentials; // 0x90
        public BestHTTP.Proxy HasProxy; // 0x98
        public int Proxy; // 0xA0
        public bool MaxRedirects; // 0xA4
        public bool UseAlternateSSL; // 0xA5
        public System.Collections.Generic.List`1<BestHTTP.Cookies.Cookie> IsCookiesEnabled; // 0xA8
        public 0x6B0A9BD8 Cookies; // 0xB0
        public 0x6B083C18 FormUsage; // 0xB4
        public int State; // 0xB8
        public System.Func`4<BestHTTP.HTTPRequest,System.Security.Cryptography.X509Certificates.X509Certificate,System.Security.Cryptography.X509Certificates.X509Chain,bool> RedirectCount; // 0xC0
        public System.TimeSpan ConnectTimeout; // 0xC8
        public System.TimeSpan Timeout; // 0xD0
        public bool EnableTimoutForStreaming; // 0xD8
        public bool EnableSafeReadOnUnknownContentLength; // 0xD9
        public int Priority; // 0xDC
        public Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer CustomCertificateVerifyer; // 0xE0
        public Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider CustomClientCredentialsProvider; // 0xE8
        public System.Collections.Generic.List`1<string> CustomTLSServerNameList; // 0xF0
        public 0x6B083A60 ProtocolHandler; // 0xF8
        public BestHTTP.OnBeforeRedirectionDelegate TryToMinimizeTCPLatency; // 0x100
        public BestHTTP.OnBeforeHeaderSendDelegate SendBufferSize; // 0x108
        public bool ReceiveBufferSize; // 0x110
        public int Downloaded; // 0x114
        public int DownloadLength; // 0x118
        public long DownloadProgressChanged; // 0x120
        public long UploadStreamLength; // 0x128
        public bool Uploaded; // 0x130
        public long UploadLength; // 0x138
        public long UploadProgressChanged; // 0x140
        public bool Headers; // 0x148
        public bool Current; // 0x149
        public bool System.Collections.Generic.IEnumerator<BestHTTP.HTTPRequest>.Current; // 0x14A
        public bool cacheOnly; // 0x14B
        public int streamFragmentSize; // 0x14C
        public bool useStreaming; // 0x150
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<string>> <Headers>k__BackingField; // 0x158
        public BestHTTP.Forms.HTTPFormBase FieldCollector; // 0x160
        public BestHTTP.Forms.HTTPFormBase FormImpl; // 0x168

        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7FFAC2F3C380
        public void set_Uri(){} // RVA: 0x7FFAC2F22E30
        public void get_MethodType(){} // RVA: 0x7FFAC2F3C4E0
        public void set_MethodType(){} // RVA: 0x7FFAC2F3C4F0
        public void get_RawData(){} // RVA: 0x7FFAC2F4F0C0
        public void set_RawData(){} // RVA: 0x7FFAC2F4F0D0
        public void get_UploadStream(){} // RVA: 0x7FFAC2F4F130
        public void set_UploadStream(){} // RVA: 0x7FFAC2F22E90
        public void get_DisposeUploadStream(){} // RVA: 0x7FFAC2F47450
        public void set_DisposeUploadStream(){} // RVA: 0x7FFAC2F47460
        public void get_UseUploadStreamLength(){} // RVA: 0x7FFAC2F47470
        public void set_UseUploadStreamLength(){} // RVA: 0x7FFAC2F47480
        public void get_IsKeepAlive(){} // RVA: 0x7FFACBA41C70
        public void set_IsKeepAlive(){} // RVA: 0x7FFACBA41C80
        public void get_DisableCache(){} // RVA: 0x7FFACBA41CF0
        public void set_DisableCache(){} // RVA: 0x7FFACBA41D00
        public void get_CacheOnly(){} // RVA: 0x7FFACBA41D70
        public void set_CacheOnly(){} // RVA: 0x7FFACBA41D80
        public void get_UseStreaming(){} // RVA: 0x7FFACBA41DF0
        public void set_UseStreaming(){} // RVA: 0x7FFACBA41E00
        public void get_StreamFragmentSize(){} // RVA: 0x7FFAC8A11690
        public void set_StreamFragmentSize(){} // RVA: 0x7FFACBA41E70
        public void get_MaxFragmentQueueLength(){} // RVA: 0x7FFAC2FC2080
        public void set_MaxFragmentQueueLength(){} // RVA: 0x7FFAC2FC2090
        public void get_Callback(){} // RVA: 0x7FFAC2F9C730
        public void set_Callback(){} // RVA: 0x7FFAC2F9C740
        public void get_DisableRetry(){} // RVA: 0x7FFAC2F4A020
        public void set_DisableRetry(){} // RVA: 0x7FFAC2F4A030
        public void get_IsRedirected(){} // RVA: 0x7FFAC3C11000
        public void set_IsRedirected(){} // RVA: 0x7FFAC3C04530
        public void get_RedirectUri(){} // RVA: 0x7FFAC2F9CD50
        public void set_RedirectUri(){} // RVA: 0x7FFAC2F9CD60
        public void get_CurrentUri(){} // RVA: 0x7FFACBA41F30
        public void get_Response(){} // RVA: 0x7FFAC2FE9590
        public void set_Response(){} // RVA: 0x7FFAC2FE95A0
        public void get_ProxyResponse(){} // RVA: 0x7FFAC30E5600
        public void set_ProxyResponse(){} // RVA: 0x7FFAC30E06F0
        public void get_Exception(){} // RVA: 0x7FFAC32EF410
        public void set_Exception(){} // RVA: 0x7FFAC34D4AA0
        public void get_Tag(){} // RVA: 0x7FFAC2F60010
        public void set_Tag(){} // RVA: 0x7FFAC354E300
        public void get_Credentials(){} // RVA: 0x7FFAC32EF640
        public void set_Credentials(){} // RVA: 0x7FFAC354E360
        public void get_HasProxy(){} // RVA: 0x7FFACB2BACD0
        public void get_Proxy(){} // RVA: 0x7FFAC354DFB0
        public void set_Proxy(){} // RVA: 0x7FFAC354E3C0
        public void get_MaxRedirects(){} // RVA: 0x7FFAC489E510
        public void set_MaxRedirects(){} // RVA: 0x7FFAC489E550
        public void get_UseAlternateSSL(){} // RVA: 0x7FFAC3145120
        public void set_UseAlternateSSL(){} // RVA: 0x7FFAC313EEF0
        public void get_IsCookiesEnabled(){} // RVA: 0x7FFAC3144830
        public void set_IsCookiesEnabled(){} // RVA: 0x7FFAC3140BD0
        public void get_Cookies(){} // RVA: 0x7FFACBA41F40
        public void set_Cookies(){} // RVA: 0x7FFAC334B370
        public void get_FormUsage(){} // RVA: 0x7FFAC4BF81F0
        public void set_FormUsage(){} // RVA: 0x7FFAC87B5A90
        public void get_State(){} // RVA: 0x7FFAC6715300
        public void set_State(){} // RVA: 0x7FFAC6715310
        public void get_RedirectCount(){} // RVA: 0x7FFAC431B350
        public void set_RedirectCount(){} // RVA: 0x7FFAC431A220
        public void add_CustomCertificationValidator(){} // RVA: 0x7FFACBA42010
        public void remove_CustomCertificationValidator(){} // RVA: 0x7FFACBA42110
        public void get_ConnectTimeout(){} // RVA: 0x7FFAC3079460
        public void set_ConnectTimeout(){} // RVA: 0x7FFACB9790D0
        public void get_Timeout(){} // RVA: 0x7FFAC303E100
        public void set_Timeout(){} // RVA: 0x7FFAC906B850
        public void get_EnableTimoutForStreaming(){} // RVA: 0x7FFAC3DBD9E0
        public void set_EnableTimoutForStreaming(){} // RVA: 0x7FFAC88C7210
        public void get_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x7FFAC8B103E0
        public void set_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x7FFAC8B103F0
        public void get_Priority(){} // RVA: 0x7FFAC913EF30
        public void set_Priority(){} // RVA: 0x7FFAC913EF40
        public void get_CustomCertificateVerifyer(){} // RVA: 0x7FFAC2FA2900
        public void set_CustomCertificateVerifyer(){} // RVA: 0x7FFAC2FA2910
        public void get_CustomClientCredentialsProvider(){} // RVA: 0x7FFAC2FA2970
        public void set_CustomClientCredentialsProvider(){} // RVA: 0x7FFAC2FA2980
        public void get_CustomTLSServerNameList(){} // RVA: 0x7FFAC2F8C2A0
        public void set_CustomTLSServerNameList(){} // RVA: 0x7FFAC2F8C2B0
        public void get_ProtocolHandler(){} // RVA: 0x7FFAC3E69BA0
        public void set_ProtocolHandler(){} // RVA: 0x7FFAC3E69950
        public void add_OnBeforeRedirection(){} // RVA: 0x7FFACBA42210
        public void remove_OnBeforeRedirection(){} // RVA: 0x7FFACBA42310
        public void add_OnBeforeHeaderSend(){} // RVA: 0x7FFACBA42410
        public void remove_OnBeforeHeaderSend(){} // RVA: 0x7FFACBA42510
        public void get_TryToMinimizeTCPLatency(){} // RVA: 0x7FFAC31E7D90
        public void set_TryToMinimizeTCPLatency(){} // RVA: 0x7FFAC31E5C40
        public void get_SendBufferSize(){} // RVA: 0x7FFAC9745510
        public void set_SendBufferSize(){} // RVA: 0x7FFAC9745520
        public void get_ReceiveBufferSize(){} // RVA: 0x7FFAC49661E0
        public void set_ReceiveBufferSize(){} // RVA: 0x7FFAC49661F0
        public void get_Downloaded(){} // RVA: 0x7FFAC313CBB0
        public void set_Downloaded(){} // RVA: 0x7FFAC8B66FC0
        public void get_DownloadLength(){} // RVA: 0x7FFAC35466F0
        public void set_DownloadLength(){} // RVA: 0x7FFACBA42610
        public void get_DownloadProgressChanged(){} // RVA: 0x7FFAC90ADDB0
        public void set_DownloadProgressChanged(){} // RVA: 0x7FFAC92F8010
        public void get_UploadStreamLength(){} // RVA: 0x7FFACBA42620
        public void get_Uploaded(){} // RVA: 0x7FFAC35422C0
        public void set_Uploaded(){} // RVA: 0x7FFACBA42670
        public void get_UploadLength(){} // RVA: 0x7FFAC2F8C5F0
        public void set_UploadLength(){} // RVA: 0x7FFAC8B3E9E0
        public void get_UploadProgressChanged(){} // RVA: 0x7FFAC4138670
        public void set_UploadProgressChanged(){} // RVA: 0x7FFAC412E500
        public void get_Headers(){} // RVA: 0x7FFAC3542410
        public void set_Headers(){} // RVA: 0x7FFAC39A74B0
        public void .ctor(){} // RVA: 0x7FFACBA42D20 | overloaded x8
        public void AddField(){} // RVA: 0x7FFACBA43500 | overloaded x2
        public void AddBinaryData(){} // RVA: 0x7FFACBA43630 | overloaded x3
        public void SetForm(){} // RVA: 0x7FFAC39A80B0
        public void GetFormFields(){} // RVA: 0x7FFACBA43720
        public void ClearForm(){} // RVA: 0x7FFACBA43800
        public void SelectFormImplementation(){} // RVA: 0x7FFACBA438C0
        public void AddHeader(){} // RVA: 0x7FFACBA43A00
        public void SetHeader(){} // RVA: 0x7FFACBA43CA0
        public void RemoveHeader(){} // RVA: 0x7FFACBA43F80
        public void HasHeader(){} // RVA: 0x7FFACBA43FF0
        public void GetFirstHeaderValue(){} // RVA: 0x7FFACBA44070
        public void GetHeaderValues(){} // RVA: 0x7FFACBA44150
        public void RemoveHeaders(){} // RVA: 0x7FFACBA441F0
        public void SetRangeHeader(){} // RVA: 0x7FFACBA44330 | overloaded x2
        public void EnumerateHeaders(){} // RVA: 0x7FFACBA44440 | overloaded x2
        public void SendHeaders(){} // RVA: 0x7FFACBA453F0
        public void DumpHeaders(){} // RVA: 0x7FFACBA45630
        public void GetEntityBody(){} // RVA: 0x7FFACBA45820
        public void SendOutTo(){} // RVA: 0x7FFACBA458A0
        public void UpgradeCallback(){} // RVA: 0x7FFACBA46600
        public void CallCallback(){} // RVA: 0x7FFACBA466E0
        public void CallOnBeforeRedirection(){} // RVA: 0x7FFACBA467A0
        public void FinishStreaming(){} // RVA: 0x7FFACBA467E0
        public void Prepare(){} // RVA: 0x7FFAC2F21310
        public void CallCustomCertificationValidator(){} // RVA: 0x7FFACBA468C0
        public void Send(){} // RVA: 0x7FFACBA46910
        public void Abort(){} // RVA: 0x7FFACBA46960
        public void Clear(){} // RVA: 0x7FFACBA46ED0
        public void VerboseLogging(){} // RVA: 0x7FFACBA46FF0
        public void get_Current(){} // RVA: 0x7FFAC34F9180
        public void MoveNext(){} // RVA: 0x7FFACBA47110
        public void Reset(){} // RVA: 0x7FFACBA47120
        public void System.Collections.Generic.IEnumerator<BestHTTP.HTTPRequest>.get_Current(){} // RVA: 0x7FFAC44F81E0
        public void Dispose(){} // RVA: 0x7FFACBA47160
        public void .cctor(){} // RVA: 0x7FFACBA47180
    }

    public class HTTPResponse : Object
    {
        public byte VersionMajor;
        public byte VersionMinor;
        public int StatusCode;
        public int IsSuccess; // 0x10
        public int Message; // 0x14
        public int IsStreamed; // 0x18
        public string IsStreamingFinished; // 0x20
        public bool IsFromCache; // 0x28
        public bool CacheFileInfo; // 0x29
        public bool IsCacheOnly; // 0x2A
        public BestHTTP.Caching.HTTPCacheFileInfo Headers; // 0x30
        public bool Data; // 0x38
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<string>> IsUpgraded; // 0x40
        public byte[] Cookies; // 0x48
        public bool DataAsText; // 0x50
        public System.Collections.Generic.List`1<BestHTTP.Cookies.Cookie> DataAsTexture2D; // 0x58
        public string IsClosedManually; // 0x60
        public UnityEngine.Texture2D texture; // 0x68
        public bool <IsClosedManually>k__BackingField; // 0x70
        public BestHTTP.HTTPRequest baseRequest; // 0x78
        public System.IO.Stream Stream; // 0x80
        public System.Collections.Generic.List`1<byte[]> streamedFragments; // 0x88
        public System.Threading.ReaderWriterLockSlim rwLock; // 0x90
        public byte[] fragmentBuffer; // 0x98
        public int fragmentBufferDataLength; // 0xA0
        public System.IO.Stream cacheStream; // 0xA8
        public int allFragmentSize; // 0xB0
        public BestHTTP.Extensions.BufferPoolMemoryStream decompressorInputStream; // 0xB8
        public BestHTTP.Extensions.BufferPoolMemoryStream decompressorOutputStream; // 0xC0
        public BestHTTP.Decompression.Zlib.GZipStream decompressorGZipStream; // 0xC8
        public int MinLengthToDecompress;
        public System.Threading.AutoResetEvent fragmentWaitEvent; // 0xD0

        // ── Methods ──
        public void get_VersionMajor(){} // RVA: 0x7FFAC2F6E5C0
        public void set_VersionMajor(){} // RVA: 0x7FFAC2F240C0
        public void get_VersionMinor(){} // RVA: 0x7FFAC33D5A20
        public void set_VersionMinor(){} // RVA: 0x7FFAC33D4990
        public void get_StatusCode(){} // RVA: 0x7FFAC3157800
        public void set_StatusCode(){} // RVA: 0x7FFAC392CD10
        public void get_IsSuccess(){} // RVA: 0x7FFACBA47A40
        public void get_Message(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Message(){} // RVA: 0x7FFAC2F4F0D0
        public void get_IsStreamed(){} // RVA: 0x7FFAC30F6BA0
        public void set_IsStreamed(){} // RVA: 0x7FFAC3C24F40
        public void get_IsStreamingFinished(){} // RVA: 0x7FFAC386C550
        public void set_IsStreamingFinished(){} // RVA: 0x7FFAC43B4D70
        public void get_IsFromCache(){} // RVA: 0x7FFAC4B82F20
        public void set_IsFromCache(){} // RVA: 0x7FFAC4B82F40
        public void get_CacheFileInfo(){} // RVA: 0x7FFAC31D95E0
        public void set_CacheFileInfo(){} // RVA: 0x7FFAC2F4F890
        public void get_IsCacheOnly(){} // RVA: 0x7FFAC31D95D0
        public void set_IsCacheOnly(){} // RVA: 0x7FFAC31D95C0
        public void get_Headers(){} // RVA: 0x7FFAC2F9E740
        public void set_Headers(){} // RVA: 0x7FFAC2F49200
        public void get_Data(){} // RVA: 0x7FFAC2F9C730
        public void set_Data(){} // RVA: 0x7FFAC2F9C740
        public void get_IsUpgraded(){} // RVA: 0x7FFAC2FDB8E0
        public void set_IsUpgraded(){} // RVA: 0x7FFAC2FDB8F0
        public void get_Cookies(){} // RVA: 0x7FFAC2FE9500
        public void set_Cookies(){} // RVA: 0x7FFAC2FE9510
        public void get_DataAsText(){} // RVA: 0x7FFACBA47A60
        public void get_DataAsTexture2D(){} // RVA: 0x7FFACBA47B70
        public void get_IsClosedManually(){} // RVA: 0x7FFAC2F9D320
        public void set_IsClosedManually(){} // RVA: 0x7FFAC2F9D330
        public void .ctor(){} // RVA: 0x7FFACBA47D30
        public void Receive(){} // RVA: 0x7FFACBA47F10
        public void ReadPayload(){} // RVA: 0x7FFACBA48920
        public void ReadHeaders(){} // RVA: 0x7FFACBA48B50
        public void AddHeader(){} // RVA: 0x7FFACBA48D50
        public void GetHeaderValues(){} // RVA: 0x7FFACBA48FF0
        public void GetFirstHeaderValue(){} // RVA: 0x7FFACBA490A0
        public void HasHeaderWithValue(){} // RVA: 0x7FFACBA49190
        public void HasHeader(){} // RVA: 0x7FFACBA49300
        public void GetRange(){} // RVA: 0x7FFACBA49320
        public void ReadTo(){} // RVA: 0x7FFACBA498E0 | overloaded x2
        public void NoTrimReadTo(){} // RVA: 0x7FFACBA49BE0
        public void ReadChunkLength(){} // RVA: 0x7FFACBA49E80
        public void ReadChunked(){} // RVA: 0x7FFACBA4A0B0
        public void ReadRaw(){} // RVA: 0x7FFACBA4A9E0
        public void ReadUnknownSize(){} // RVA: 0x7FFACBA4B050
        public void DecodeStream(){} // RVA: 0x7FFACBA4B710
        public void CloseDecompressors(){} // RVA: 0x7FFACBA4BB10
        public void Decompress(){} // RVA: 0x7FFACBA4BCC0
        public void BeginReceiveStreamFragments(){} // RVA: 0x7FFACBA4C0C0
        public void FeedStreamFragment(){} // RVA: 0x7FFACBA4C1E0
        public void FlushRemainingFragmentBuffer(){} // RVA: 0x7FFACBA4C470
        public void AddStreamedFragment(){} // RVA: 0x7FFACBA4C6D0
        public void WaitWhileFragmentQueueIsFull(){} // RVA: 0x7FFACBA4C9F0
        public void FragmentQueueIsFull(){} // RVA: 0x7FFACBA4CB40
        public void GetStreamedFragments(){} // RVA: 0x7FFACBA4CDE0
        public void HasStreamedFragments(){} // RVA: 0x7FFACBA4D110
        public void FinishStreaming(){} // RVA: 0x7FFACBA4D210
        public void VerboseLogging(){} // RVA: 0x7FFACBA4D2C0
        public void Dispose(){} // RVA: 0x7FFACBA4D430
    }

    public class HTTPUpdateDelegator : MonoBehaviour
    {
        public BestHTTP.HTTPUpdateDelegator Instance;
        public bool IsCreated; // 0x8
        public bool IsThreaded; // 0x9
        public bool IsThreadRunning; // 0xA
        public int ThreadFrequencyInMS; // 0xC
        public System.Func`1<bool> OnBeforeApplicationQuit; // 0x10
        public System.Action`1<bool> OnApplicationForegroundStateChanged; // 0x18
        public bool IsSetupCalled; // 0x20

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFACBA4D5D0
        public void set_Instance(){} // RVA: 0x7FFACBA4D630
        public void get_IsCreated(){} // RVA: 0x7FFACBA4D6E0
        public void set_IsCreated(){} // RVA: 0x7FFACBA4D740
        public void get_IsThreaded(){} // RVA: 0x7FFACBA4D7A0
        public void set_IsThreaded(){} // RVA: 0x7FFACBA4D800
        public void get_IsThreadRunning(){} // RVA: 0x7FFACBA4D860
        public void set_IsThreadRunning(){} // RVA: 0x7FFACBA4D8C0
        public void get_ThreadFrequencyInMS(){} // RVA: 0x7FFACBA4D920
        public void set_ThreadFrequencyInMS(){} // RVA: 0x7FFACBA4D980
        public void .cctor(){} // RVA: 0x7FFACBA4D9E0
        public void CheckInstance(){} // RVA: 0x7FFACBA4DA40
        public void Setup(){} // RVA: 0x7FFACBA4DFA0
        public void ThreadFunc(){} // RVA: 0x7FFACBA4E1B0
        public void Update(){} // RVA: 0x7FFACBA4E450
        public void OnDisable(){} // RVA: 0x7FFACBA4E570
        public void OnApplicationPause(){} // RVA: 0x7FFACBA4E630
        public void OnApplicationQuit(){} // RVA: 0x7FFACBA4E6D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class IProtocol
    {
        public object IsClosed;

        // ── Methods ──
        public void get_IsClosed(){} // RVA: 0x7FFAC2C59D00
        public void HandleEvents(){} // RVA: 0x7FFAC2C70980
    }

    public class KeepAliveHeader : Object
    {
        public System.TimeSpan TimeOut; // 0x10
        public int MaxRequests; // 0x18

        // ── Methods ──
        public void get_TimeOut(){} // RVA: 0x7FFAC2F3C380
        public void set_TimeOut(){} // RVA: 0x7FFAC441EFB0
        public void get_MaxRequests(){} // RVA: 0x7FFAC3157800
        public void set_MaxRequests(){} // RVA: 0x7FFAC392CD10
        public void Parse(){} // RVA: 0x7FFACBA35980
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OnBeforeHeaderSendDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7CB80
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
        public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class OnBeforeRedirectionDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC897C5E0
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
        public void BeginInvoke(){} // RVA: 0x7FFAC3C20DC0
        public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
    }

    public class OnDownloadProgressDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3C20CE0
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
        public void BeginInvoke(){} // RVA: 0x7FFACBA41B30
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class OnHeaderEnumerationDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4935D20
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class OnRequestFinishedDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4935D20
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class OnUploadProgressDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3C20CE0
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
        public void BeginInvoke(){} // RVA: 0x7FFACBA41BD0
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class Proxy : Object
    {
        public System.Uri Address; // 0x10
        public BestHTTP.Authentication.Credentials Credentials; // 0x18

        // ── Methods ──
        public void get_Address(){} // RVA: 0x7FFAC2F3C380
        public void set_Address(){} // RVA: 0x7FFAC2F22E30
        public void get_Credentials(){} // RVA: 0x7FFAC2F247C0
        public void set_Credentials(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void Connect(){} // RVA: 0x7FFAC2C79B30
        public void GetRequestPath(){} // RVA: 0x7FFAC2C58F40
    }

    public class SOCKSProxy : Proxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B38D30
        public void GetRequestPath(){} // RVA: 0x7FFACBA4EBA0
        public void Connect(){} // RVA: 0x7FFACBA4EC40
        public void WriteString(){} // RVA: 0x7FFACBA4FE90
        public void WriteBytes(){} // RVA: 0x7FFACBA4FFC0
        public void BufferToHexStr(){} // RVA: 0x7FFACBA50010
    }

}