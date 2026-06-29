// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP
// Classes: 23
// Methods: 420

namespace ThirdParty.BestHTTP.BestHTTP
{
    public class ConnectionBase : Object
    {
        public object _serverAddress;
        public object _state;
        public object _currentRequest;
        public object _startTime;
        public object _timedOutStart;
        public object _lastProcessedUri;
        public object LastProcessTime;
        public object OnConnectionRecycled;
        public object IsThreaded;
        public object _isDisposed;

        // ── Methods ──
        public void get_ServerAddress(){} // RVA: 0xB5DBF0
        public void set_ServerAddress(){} // RVA: 0xB44D60
        public void get_State(){} // RVA: 0xE62D00
        public void set_State(){} // RVA: 0x1033F40
        public void get_IsFree(){} // RVA: 0xA0CAE60
        public void get_IsActive(){} // RVA: 0xA0CAE80
        public void get_CurrentRequest(){} // RVA: 0xB700F0
        public void set_CurrentRequest(){} // RVA: 0xB70100
        public void get_IsRemovable(){} // RVA: 0xA0CAEA0
        public void get_StartTime(){} // RVA: 0xB70160
        public void set_StartTime(){} // RVA: 0x116B360
        public void get_TimedOutStart(){} // RVA: 0xD33E60
        public void set_TimedOutStart(){} // RVA: 0x27FA7C0
        public void get_HasProxy(){} // RVA: 0xA0CAFC0
        public void get_LastProcessedUri(){} // RVA: 0xD05CA0
        public void set_LastProcessedUri(){} // RVA: 0xD09D70
        public void .ctor(){} // RVA: 0xA0CB0A0
        public void Abort(){} // RVA: 0x8944F0
        public void Process(){} // RVA: 0xA0CB160
        public void ThreadFunc(){} // RVA: 0xB43310
        public void HandleProgressCallback(){} // RVA: 0xA0CB450
        public void HandleCallback(){} // RVA: 0xA0CB690
        public void Recycle(){} // RVA: 0xA0CB790
        public void RecycleNow(){} // RVA: 0xA0CB810
        public void get_IsDisposed(){} // RVA: 0x24BED30
        public void set_IsDisposed(){} // RVA: 0x24BA470
        public void Dispose(){} // RVA: 0xA0CB9F0
        public void Finalize(){} // RVA: 0xA0CBA00
    }

    public class ConnectionBase[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class FileConnection : ConnectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0CBA50
        public void Abort(){} // RVA: 0xA0CBA60
        public void ThreadFunc(){} // RVA: 0xA0CBAE0
    }

    public class HTTPConnection : ConnectionBase
    {
        public object Client;
        public object Stream;
        public object KeepAlive;

        // ── Methods ──
        public void get_IsRemovable(){} // RVA: 0xA0CC600
        public void .ctor(){} // RVA: 0xA0CBA50
        public void ThreadFunc(){} // RVA: 0xA0CC7D0
        public void Connect(){} // RVA: 0xA0CDF10
        public void Receive(){} // RVA: 0xA0CEE60
        public void LoadFromCache(){} // RVA: 0xA0CF690
        public void TryLoadAllFromCache(){} // RVA: 0xA0CFCB0
        public void TryStoreInCache(){} // RVA: 0xA0CFF50
        public void GetRedirectUri(){} // RVA: 0xA0D00C0
        public void Abort(){} // RVA: 0xA0D0270
        public void Close(){} // RVA: 0xA0D0300
        public void Dispose(){} // RVA: 0xA0D0530
        public void <Connect>b__7_0(){} // RVA: 0xA0D0550
    }

    public class HTTPConnectionRecycledDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
        public void Invoke(){} // RVA: 0xB9E010
        public void BeginInvoke(){} // RVA: 0xB9E020
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class HTTPManager : Object
    {
        public object maxConnectionPerServer;
        public object _keepAliveDefaultValue;
        public object _isCachingDisabled;
        public object _maxConnectionIdleTime;
        public object _isCookiesEnabled;
        public object _cookieJarSize;
        public object _enablePrivateBrowsing;
        public object _connectTimeout;
        public object _requestTimeout;
        public object _rootCacheFolderProvider;
        public object _proxy;
        public object heartbeats;
        public object logger;
        public object _defaultCertificateVerifyer;
        public object _defaultClientCredentialsProvider;
        public object _useAlternateSSLDefaultValue;
        public object _defaultCertificationValidator;
        public object TryToMinimizeTCPLatency;
        public object SendBufferSize;
        public object ReceiveBufferSize;
        public object IOService;
        public object _maxPathLength;
        public object UserAgent;
        public object Connections;
        public object ActiveConnections;
        public object FreeConnections;
        public object RecycledConnections;
        public object RequestQueue;
        public object IsCallingCallbacks;
        public object Locker;
        public object _isQuitting;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA0D05A0
        public void get_MaxConnectionPerServer(){} // RVA: 0xA0D1050
        public void set_MaxConnectionPerServer(){} // RVA: 0xA0D10B0
        public void get_KeepAliveDefaultValue(){} // RVA: 0xA0D1160
        public void set_KeepAliveDefaultValue(){} // RVA: 0xA0D11C0
        public void get_IsCachingDisabled(){} // RVA: 0xA0D1220
        public void set_IsCachingDisabled(){} // RVA: 0xA0D1280
        public void get_MaxConnectionIdleTime(){} // RVA: 0xA0D12E0
        public void set_MaxConnectionIdleTime(){} // RVA: 0xA0D1340
        public void get_IsCookiesEnabled(){} // RVA: 0xA0D13A0
        public void set_IsCookiesEnabled(){} // RVA: 0xA0D1400
        public void get_CookieJarSize(){} // RVA: 0xA0D1460
        public void set_CookieJarSize(){} // RVA: 0xA0D14C0
        public void get_EnablePrivateBrowsing(){} // RVA: 0xA0D1520
        public void set_EnablePrivateBrowsing(){} // RVA: 0xA0D1580
        public void get_ConnectTimeout(){} // RVA: 0xA0D15E0
        public void set_ConnectTimeout(){} // RVA: 0xA0D1640
        public void get_RequestTimeout(){} // RVA: 0xA0D16A0
        public void set_RequestTimeout(){} // RVA: 0xA0D1700
        public void get_RootCacheFolderProvider(){} // RVA: 0xA0D1760
        public void set_RootCacheFolderProvider(){} // RVA: 0xA0D17C0
        public void get_Proxy(){} // RVA: 0xA0D1880
        public void set_Proxy(){} // RVA: 0xA0D18E0
        public void get_Heartbeats(){} // RVA: 0xA0D19A0
        public void get_Logger(){} // RVA: 0xA0D1C90
        public void set_Logger(){} // RVA: 0xA0D1E00
        public void get_DefaultCertificateVerifyer(){} // RVA: 0xA0D1EC0
        public void set_DefaultCertificateVerifyer(){} // RVA: 0xA0D1F20
        public void get_DefaultClientCredentialsProvider(){} // RVA: 0xA0D1FE0
        public void set_DefaultClientCredentialsProvider(){} // RVA: 0xA0D2040
        public void get_UseAlternateSSLDefaultValue(){} // RVA: 0xA0D2100
        public void set_UseAlternateSSLDefaultValue(){} // RVA: 0xA0D2160
        public void get_DefaultCertificationValidator(){} // RVA: 0xA0D21C0
        public void set_DefaultCertificationValidator(){} // RVA: 0xA0D2220
        public void get_MaxPathLength(){} // RVA: 0xA0D22E0
        public void set_MaxPathLength(){} // RVA: 0xA0D2340
        public void get_IsQuitting(){} // RVA: 0xA0D23A0
        public void set_IsQuitting(){} // RVA: 0xA0D2400
        public void Setup(){} // RVA: 0xA0D2460
        public void SendRequest(){} // RVA: 0xA0D2930
        public void GetGeneralStatistics(){} // RVA: 0xA0D2BF0
        public void SendRequestImpl(){} // RVA: 0xA0D3090
        public void GetKeyForRequest(){} // RVA: 0xA0D3350
        public void CreateConnection(){} // RVA: 0xA0D35E0
        public void FindOrCreateFreeConnection(){} // RVA: 0xA0D3700
        public void CanProcessFromQueue(){} // RVA: 0xA0D3DE0
        public void RecycleConnection(){} // RVA: 0xA0D3F00
        public void OnConnectionRecylced(){} // RVA: 0xA0D3FE0
        public void GetConnectionWith(){} // RVA: 0xA0D4190
        public void RemoveFromQueue(){} // RVA: 0xA0D4430
        public void GetRootCacheFolder(){} // RVA: 0xA0D44C0
        public void OnUpdate(){} // RVA: 0xA0D4660
        public void OnQuit(){} // RVA: 0xA0D58B0
        public void AbortAll(){} // RVA: 0xA0D5AD0
    }

    public class HTTPProtocolFactory : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0xA0D62A0
        public void GetProtocolFromUri(){} // RVA: 0xA0D6460
        public void IsSecureProtocol(){} // RVA: 0xA0D6530
    }

    public class HTTPProxy : Proxy
    {
        public object _isTransparent;
        public object _sendWholeUri;
        public object _nonTransparentForHTTPS;

        // ── Methods ──
        public void get_IsTransparent(){} // RVA: 0xC38360
        public void set_IsTransparent(){} // RVA: 0xC38370
        public void get_SendWholeUri(){} // RVA: 0xF45EE0
        public void set_SendWholeUri(){} // RVA: 0x1AD91E0
        public void get_NonTransparentForHTTPS(){} // RVA: 0x246F130
        public void set_NonTransparentForHTTPS(){} // RVA: 0x1AD8C10
        public void .ctor(){} // RVA: 0xA0D6720
        public void GetRequestPath(){} // RVA: 0xA0D6760
        public void Connect(){} // RVA: 0xA0D6880
    }

    public class HTTPRange : Object
    {
        public object _firstBytePos;
        public object _lastBytePos;
        public object _contentLength;
        public object _isValid;

        // ── Methods ──
        public void get_FirstBytePos(){} // RVA: 0xB8F8F0
        public void set_FirstBytePos(){} // RVA: 0xB460A0
        public void get_LastBytePos(){} // RVA: 0x116A650
        public void set_LastBytePos(){} // RVA: 0x116BB10
        public void get_ContentLength(){} // RVA: 0xE62D00
        public void set_ContentLength(){} // RVA: 0x1033F40
        public void get_IsValid(){} // RVA: 0xB5DC00
        public void set_IsValid(){} // RVA: 0xB5DC10
        public void .ctor(){} // RVA: 0xA0D8060
        public void ToString(){} // RVA: 0xA0D8080
    }

    public class HTTPRequest : Object
    {
        public object EOL;
        public object MethodNames;
        public object UploadChunkSize;
        public object _uri;
        public object _methodType;
        public object _rawData;
        public object _uploadStream;
        public object _disposeUploadStream;
        public object _useUploadStreamLength;
        public object OnUploadProgress;
        public object _maxFragmentQueueLength;
        public object _callback;
        public object OnProgress;
        public object OnUpgraded;
        public object _disableRetry;
        public object _isRedirected;
        public object _redirectUri;
        public object _response;
        public object _proxyResponse;
        public object _exception;
        public object _tag;
        public object _credentials;
        public object _proxy;
        public object _maxRedirects;
        public object _useAlternateSSL;
        public object _isCookiesEnabled;
        public object customCookies;
        public object _formUsage;
        public object _state;
        public object _redirectCount;
        public object CustomCertificationValidator;
        public object _connectTimeout;
        public object _timeout;
        public object _enableTimoutForStreaming;
        public object _enableSafeReadOnUnknownContentLength;
        public object _priority;
        public object _customCertificateVerifyer;
        public object _customClientCredentialsProvider;
        public object _customTLSServerNameList;
        public object _protocolHandler;
        public object onBeforeRedirection;
        public object _onBeforeHeaderSend;
        public object _tryToMinimizeTCPLatency;
        public object _sendBufferSize;
        public object _receiveBufferSize;
        public object _downloaded;
        public object _downloadLength;
        public object _downloadProgressChanged;
        public object _uploaded;
        public object _uploadLength;
        public object _uploadProgressChanged;
        public object isKeepAlive;
        public object disableCache;
        public object cacheOnly;
        public object streamFragmentSize;
        public object useStreaming;
        public object _headers;
        public object FieldCollector;
        public object FormImpl;

        // ── Methods ──
        public void get_Uri(){} // RVA: 0xB5DBF0
        public void set_Uri(){} // RVA: 0xB44D60
        public void get_MethodType(){} // RVA: 0xB5DD50
        public void set_MethodType(){} // RVA: 0xB5DD60
        public void get_RawData(){} // RVA: 0xB700F0
        public void set_RawData(){} // RVA: 0xB70100
        public void get_UploadStream(){} // RVA: 0xB70160
        public void set_UploadStream(){} // RVA: 0xB44DC0
        public void get_DisposeUploadStream(){} // RVA: 0xB68DF0
        public void set_DisposeUploadStream(){} // RVA: 0xB68E00
        public void get_UseUploadStreamLength(){} // RVA: 0xB68E10
        public void set_UseUploadStreamLength(){} // RVA: 0xB68E20
        public void get_IsKeepAlive(){} // RVA: 0xA0D8320
        public void set_IsKeepAlive(){} // RVA: 0xA0D8330
        public void get_DisableCache(){} // RVA: 0xA0D83A0
        public void set_DisableCache(){} // RVA: 0xA0D83B0
        public void get_CacheOnly(){} // RVA: 0xA0D8420
        public void set_CacheOnly(){} // RVA: 0xA0D8430
        public void get_UseStreaming(){} // RVA: 0x7F6BF00
        public void set_UseStreaming(){} // RVA: 0xA0D84A0
        public void get_StreamFragmentSize(){} // RVA: 0x6CE7AE0
        public void set_StreamFragmentSize(){} // RVA: 0xA0D8510
        public void get_MaxFragmentQueueLength(){} // RVA: 0xBE5850
        public void set_MaxFragmentQueueLength(){} // RVA: 0xBE5860
        public void get_Callback(){} // RVA: 0xBBF8F0
        public void set_Callback(){} // RVA: 0xBBF900
        public void get_DisableRetry(){} // RVA: 0xB6B1A0
        public void set_DisableRetry(){} // RVA: 0xB6B1B0
        public void get_IsRedirected(){} // RVA: 0x1A1E0A0
        public void set_IsRedirected(){} // RVA: 0x1A194B0
        public void get_RedirectUri(){} // RVA: 0xBBFF90
        public void set_RedirectUri(){} // RVA: 0xBBFFA0
        public void get_CurrentUri(){} // RVA: 0xA0D85D0
        public void get_Response(){} // RVA: 0xC10050
        public void set_Response(){} // RVA: 0xC10060
        public void get_ProxyResponse(){} // RVA: 0xCD3320
        public void set_ProxyResponse(){} // RVA: 0xCD4740
        public void get_Exception(){} // RVA: 0xCD48B0
        public void set_Exception(){} // RVA: 0xCD3600
        public void get_Tag(){} // RVA: 0xB813B0
        public void set_Tag(){} // RVA: 0xD5CBB0
        public void get_Credentials(){} // RVA: 0x1069350
        public void set_Credentials(){} // RVA: 0xD5CC10
        public void get_HasProxy(){} // RVA: 0x97EEAF0
        public void get_Proxy(){} // RVA: 0x106A7D0
        public void set_Proxy(){} // RVA: 0xD5CC70
        public void get_MaxRedirects(){} // RVA: 0x262A8F0
        public void set_MaxRedirects(){} // RVA: 0x262A940
        public void get_UseAlternateSSL(){} // RVA: 0xE37D60
        public void set_UseAlternateSSL(){} // RVA: 0xE3D080
        public void get_IsCookiesEnabled(){} // RVA: 0xE3E250
        public void set_IsCookiesEnabled(){} // RVA: 0xE34E40
        public void get_Cookies(){} // RVA: 0xA0D85E0
        public void set_Cookies(){} // RVA: 0x13B1040
        public void get_FormUsage(){} // RVA: 0x295D4E0
        public void set_FormUsage(){} // RVA: 0x6A92F20
        public void get_State(){} // RVA: 0x68504F0
        public void set_State(){} // RVA: 0x798F510
        public void get_RedirectCount(){} // RVA: 0x215C150
        public void set_RedirectCount(){} // RVA: 0x215CA00
        public void add_CustomCertificationValidator(){} // RVA: 0xA0D86B0
        public void remove_CustomCertificationValidator(){} // RVA: 0xA0D87D0
        public void get_ConnectTimeout(){} // RVA: 0xCA4D80
        public void set_ConnectTimeout(){} // RVA: 0x981B490
        public void get_Timeout(){} // RVA: 0xC68EB0
        public void set_Timeout(){} // RVA: 0x7339DC0
        public void get_EnableTimoutForStreaming(){} // RVA: 0x11629E0
        public void set_EnableTimoutForStreaming(){} // RVA: 0x1AE6E90
        public void get_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x6DE6320
        public void set_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x6DE6330
        public void get_Priority(){} // RVA: 0x1162FE0
        public void set_Priority(){} // RVA: 0x740E170
        public void get_CustomCertificateVerifyer(){} // RVA: 0xBC5B30
        public void set_CustomCertificateVerifyer(){} // RVA: 0xBC5B40
        public void get_CustomClientCredentialsProvider(){} // RVA: 0xBC5BA0
        public void set_CustomClientCredentialsProvider(){} // RVA: 0xBC5BB0
        public void get_CustomTLSServerNameList(){} // RVA: 0xBAE5A0
        public void set_CustomTLSServerNameList(){} // RVA: 0xBAE5B0
        public void get_ProtocolHandler(){} // RVA: 0x7E45E60
        public void set_ProtocolHandler(){} // RVA: 0x485FE90
        public void add_OnBeforeRedirection(){} // RVA: 0xA0D88F0
        public void remove_OnBeforeRedirection(){} // RVA: 0xA0D89F0
        public void add_OnBeforeHeaderSend(){} // RVA: 0xA0D8AF0
        public void remove_OnBeforeHeaderSend(){} // RVA: 0xA0D8BF0
        public void get_TryToMinimizeTCPLatency(){} // RVA: 0x1184420
        public void set_TryToMinimizeTCPLatency(){} // RVA: 0x1EBEA50
        public void get_SendBufferSize(){} // RVA: 0x80F08F0
        public void set_SendBufferSize(){} // RVA: 0x7DCD9F0
        public void get_ReceiveBufferSize(){} // RVA: 0x1AE6530
        public void set_ReceiveBufferSize(){} // RVA: 0x1CA09C0
        public void get_Downloaded(){} // RVA: 0x114AC20
        public void set_Downloaded(){} // RVA: 0x6E3F300
        public void get_DownloadLength(){} // RVA: 0xE3C930
        public void set_DownloadLength(){} // RVA: 0xA0D8CF0
        public void get_DownloadProgressChanged(){} // RVA: 0x737C360
        public void set_DownloadProgressChanged(){} // RVA: 0x75C3B90
        public void get_UploadStreamLength(){} // RVA: 0xA0D8D00
        public void get_Uploaded(){} // RVA: 0x135A170
        public void set_Uploaded(){} // RVA: 0xA0D8D50
        public void get_UploadLength(){} // RVA: 0xBAE8F0
        public void set_UploadLength(){} // RVA: 0x6E15240
        public void get_UploadProgressChanged(){} // RVA: 0x2540EB0
        public void set_UploadProgressChanged(){} // RVA: 0x6CE7AD0
        public void get_Headers(){} // RVA: 0x1661250
        public void set_Headers(){} // RVA: 0x166A5F0
        public void .ctor(){} // RVA: 0xA0D9400
        public void AddField(){} // RVA: 0xA0D9BE0
        public void AddBinaryData(){} // RVA: 0xA0D9D10
        public void SetForm(){} // RVA: 0x16601C0
        public void GetFormFields(){} // RVA: 0xA0D9E00
        public void ClearForm(){} // RVA: 0xA0D9EE0
        public void SelectFormImplementation(){} // RVA: 0xA0D9FA0
        public void AddHeader(){} // RVA: 0xA0DA0E0
        public void SetHeader(){} // RVA: 0xA0DA380
        public void RemoveHeader(){} // RVA: 0xA0DA660
        public void HasHeader(){} // RVA: 0xA0DA6D0
        public void GetFirstHeaderValue(){} // RVA: 0xA0DA750
        public void GetHeaderValues(){} // RVA: 0xA0DA830
        public void RemoveHeaders(){} // RVA: 0xA0DA8D0
        public void SetRangeHeader(){} // RVA: 0xA0DA9F0
        public void EnumerateHeaders(){} // RVA: 0xA0DAAF0
        public void SendHeaders(){} // RVA: 0xA0DBAD0
        public void DumpHeaders(){} // RVA: 0xA0DBD00
        public void GetEntityBody(){} // RVA: 0xA0DBF00
        public void SendOutTo(){} // RVA: 0xA0DBF80
        public void UpgradeCallback(){} // RVA: 0xA0DCCD0
        public void CallCallback(){} // RVA: 0xA0DCDB0
        public void CallOnBeforeRedirection(){} // RVA: 0xA0DCE70
        public void FinishStreaming(){} // RVA: 0xA0DCEB0
        public void Prepare(){} // RVA: 0xB43310
        public void CallCustomCertificationValidator(){} // RVA: 0xA0DCF90
        public void Send(){} // RVA: 0xA0DCFE0
        public void Abort(){} // RVA: 0xA0DD030
        public void Clear(){} // RVA: 0xA0DD5C0
        public void VerboseLogging(){} // RVA: 0xA0DD6E0
        public void get_Current(){} // RVA: 0xDAC980
        public void MoveNext(){} // RVA: 0xA0DD810
        public void Reset(){} // RVA: 0xA0DD820
        public void System.Collections.Generic.IEnumerator<BestHTTP.HTTPRequest>.get_Current(){} // RVA: 0x2303260
        public void Dispose(){} // RVA: 0xA0DD860
        public void .cctor(){} // RVA: 0xA0DD880
    }

    public class HTTPRequest[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class HTTPResponse : Object
    {
        public object CR;
        public object LF;
        public object MinBufferSize;
        public object _versionMajor;
        public object _versionMinor;
        public object _statusCode;
        public object _message;
        public object _isStreamed;
        public object _isStreamingFinished;
        public object _isFromCache;
        public object _cacheFileInfo;
        public object _isCacheOnly;
        public object _headers;
        public object _data;
        public object _isUpgraded;
        public object _cookies;
        public object dataAsText;
        public object texture;
        public object _isClosedManually;
        public object baseRequest;
        public object Stream;
        public object streamedFragments;
        public object rwLock;
        public object fragmentBuffer;
        public object fragmentBufferDataLength;
        public object cacheStream;
        public object allFragmentSize;
        public object decompressorInputStream;
        public object decompressorOutputStream;
        public object decompressorGZipStream;
        public object MinLengthToDecompress;
        public object fragmentWaitEvent;

        // ── Methods ──
        public void get_VersionMajor(){} // RVA: 0xB8F8F0
        public void set_VersionMajor(){} // RVA: 0xB460A0
        public void get_VersionMinor(){} // RVA: 0x116A650
        public void set_VersionMinor(){} // RVA: 0x116BB10
        public void get_StatusCode(){} // RVA: 0xE62D00
        public void set_StatusCode(){} // RVA: 0x1033F40
        public void get_IsSuccess(){} // RVA: 0xA0DE160
        public void get_Message(){} // RVA: 0xB700F0
        public void set_Message(){} // RVA: 0xB70100
        public void get_IsStreamed(){} // RVA: 0xF73960
        public void set_IsStreamed(){} // RVA: 0xF73A60
        public void get_IsStreamingFinished(){} // RVA: 0x14F7430
        public void set_IsStreamingFinished(){} // RVA: 0x21CBB70
        public void get_IsFromCache(){} // RVA: 0x28E58A0
        public void set_IsFromCache(){} // RVA: 0x28E5890
        public void get_CacheFileInfo(){} // RVA: 0xD33E60
        public void set_CacheFileInfo(){} // RVA: 0xB708C0
        public void get_IsCacheOnly(){} // RVA: 0xD16660
        public void set_IsCacheOnly(){} // RVA: 0xD14C10
        public void get_Headers(){} // RVA: 0xBC1B30
        public void set_Headers(){} // RVA: 0xB6A8C0
        public void get_Data(){} // RVA: 0xBBF8F0
        public void set_Data(){} // RVA: 0xBBF900
        public void get_IsUpgraded(){} // RVA: 0xC00EC0
        public void set_IsUpgraded(){} // RVA: 0xC00ED0
        public void get_Cookies(){} // RVA: 0xC0FFC0
        public void set_Cookies(){} // RVA: 0xC0FFD0
        public void get_DataAsText(){} // RVA: 0xA0DE180
        public void get_DataAsTexture2D(){} // RVA: 0xA0DE270
        public void get_IsClosedManually(){} // RVA: 0xBC03E0
        public void set_IsClosedManually(){} // RVA: 0xBC03F0
        public void .ctor(){} // RVA: 0xA0DE440
        public void Receive(){} // RVA: 0xA0DE640
        public void ReadPayload(){} // RVA: 0xA0DF030
        public void ReadHeaders(){} // RVA: 0xA0DF260
        public void AddHeader(){} // RVA: 0xA0DF450
        public void GetHeaderValues(){} // RVA: 0xA0DF6F0
        public void GetFirstHeaderValue(){} // RVA: 0xA0DF7A0
        public void HasHeaderWithValue(){} // RVA: 0xA0DF890
        public void HasHeader(){} // RVA: 0xA0DFA10
        public void GetRange(){} // RVA: 0xA0DFA30
        public void ReadTo(){} // RVA: 0xA0E0030
        public void NoTrimReadTo(){} // RVA: 0xA0E0340
        public void ReadChunkLength(){} // RVA: 0xA0E05D0
        public void ReadChunked(){} // RVA: 0xA0E07F0
        public void ReadRaw(){} // RVA: 0xA0E1100
        public void ReadUnknownSize(){} // RVA: 0xA0E1770
        public void DecodeStream(){} // RVA: 0xA0E1E40
        public void CloseDecompressors(){} // RVA: 0xA0E2240
        public void Decompress(){} // RVA: 0xA0E23F0
        public void BeginReceiveStreamFragments(){} // RVA: 0xA0E27F0
        public void FeedStreamFragment(){} // RVA: 0xA0E2920
        public void FlushRemainingFragmentBuffer(){} // RVA: 0xA0E2BB0
        public void AddStreamedFragment(){} // RVA: 0xA0E2E20
        public void WaitWhileFragmentQueueIsFull(){} // RVA: 0xA0E3140
        public void FragmentQueueIsFull(){} // RVA: 0xA0E3290
        public void GetStreamedFragments(){} // RVA: 0xA0E3520
        public void HasStreamedFragments(){} // RVA: 0xA0E3840
        public void FinishStreaming(){} // RVA: 0xA0E3940
        public void VerboseLogging(){} // RVA: 0xA0E39F0
        public void Dispose(){} // RVA: 0xA0E3B60
    }

    public class HTTPUpdateDelegator : MonoBehaviour
    {
        public object _instance;
        public object _isCreated;
        public object _isThreaded;
        public object _isThreadRunning;
        public object _threadFrequencyInMS;
        public object OnBeforeApplicationQuit;
        public object OnApplicationForegroundStateChanged;
        public object IsSetupCalled;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0xA0E3D00
        public void set_Instance(){} // RVA: 0xA0E3D60
        public void get_IsCreated(){} // RVA: 0xA0E3E10
        public void set_IsCreated(){} // RVA: 0xA0E3E70
        public void get_IsThreaded(){} // RVA: 0xA0E3ED0
        public void set_IsThreaded(){} // RVA: 0xA0E3F30
        public void get_IsThreadRunning(){} // RVA: 0xA0E3F90
        public void set_IsThreadRunning(){} // RVA: 0xA0E3FF0
        public void get_ThreadFrequencyInMS(){} // RVA: 0xA0E4050
        public void set_ThreadFrequencyInMS(){} // RVA: 0xA0E40B0
        public void .cctor(){} // RVA: 0xA0E4110
        public void CheckInstance(){} // RVA: 0xA0E4170
        public void Setup(){} // RVA: 0xA0E46B0
        public void ThreadFunc(){} // RVA: 0xA0E48C0
        public void Update(){} // RVA: 0xA0E4B60
        public void OnDisable(){} // RVA: 0xA0E4C80
        public void OnApplicationPause(){} // RVA: 0xA0E4D40
        public void OnApplicationQuit(){} // RVA: 0xA0E4DE0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class IProtocol
    {
        // ── Methods ──
        public void get_IsClosed(){} // RVA: 0x87D280
        public void HandleEvents(){} // RVA: 0x894290
    }

    public class KeepAliveHeader : Object
    {
        public object _timeOut;
        public object _maxRequests;

        // ── Methods ──
        public void get_TimeOut(){} // RVA: 0xB5DBF0
        public void set_TimeOut(){} // RVA: 0x2230E30
        public void get_MaxRequests(){} // RVA: 0xE62D00
        public void set_MaxRequests(){} // RVA: 0x1033F40
        public void Parse(){} // RVA: 0xA0CC3C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OnBeforeHeaderSendDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB9DF20
        public void Invoke(){} // RVA: 0xB9E010
        public void BeginInvoke(){} // RVA: 0xB9E020
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class OnBeforeRedirectionDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C54980
        public void Invoke(){} // RVA: 0xCA8D60
        public void BeginInvoke(){} // RVA: 0x1A4D0B0
        public void EndInvoke(){} // RVA: 0x2404860
    }

    public class OnDownloadProgressDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A4CFC0
        public void Invoke(){} // RVA: 0xCA8D60
        public void BeginInvoke(){} // RVA: 0xA0D82B0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class OnHeaderEnumerationDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2697880
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class OnRequestFinishedDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2697880
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class OnUploadProgressDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A4CFC0
        public void Invoke(){} // RVA: 0xCA8D60
        public void BeginInvoke(){} // RVA: 0xA0D82B0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class Proxy : Object
    {
        public object _address;
        public object _credentials;

        // ── Methods ──
        public void get_Address(){} // RVA: 0xB5DBF0
        public void set_Address(){} // RVA: 0xB44D60
        public void get_Credentials(){} // RVA: 0xB465B0
        public void set_Credentials(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Connect(){} // RVA: 0x8943B0
        public void GetRequestPath(){} // RVA: 0x87C540
    }

    public class SOCKSProxy : Proxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E0F300
        public void GetRequestPath(){} // RVA: 0xA0E52B0
        public void Connect(){} // RVA: 0xA0E5350
        public void WriteString(){} // RVA: 0xA0E65B0
        public void WriteBytes(){} // RVA: 0xA0E66E0
        public void BufferToHexStr(){} // RVA: 0xA0E6730
    }

}