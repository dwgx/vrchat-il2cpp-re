// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 21
// Methods: 269

namespace ThirdParty.DotNet.System.Net
{
    public class HeaderInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87669A50
    }

    public class HeaderInfoTable : Object
    {
        public System.Collections.Hashtable HeaderHashTable;

        // ── Methods ──
        public void ParseSingleValue(){} // RVA: 0x7FFE87669B20
        public void ParseMultiValue(){} // RVA: 0x7FFE87669B90
        public void .cctor(){} // RVA: 0x7FFE87669E50
        public void get_Item(){} // RVA: 0x7FFE8766C030
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HeaderParser : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8526B7D0
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class HeaderVariantInfo : ValueType
    {
        public string m_name; // 0x10
        public 0x66534C7C m_variant; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815AE520
        public void get_Name(){} // RVA: 0x7FFE8284EF60
        public void get_Variant(){} // RVA: 0x7FFE82C33000
    }

    public class HttpConnection : Object
    {
        public System.AsyncCallback onread_cb;
        public int BufferSize;
        public System.Net.Sockets.Socket sock; // 0x10
        public System.IO.Stream stream; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87690750
        public void Init(){} // RVA: 0x7FFE87690C00
        public void get_Reuses(){} // RVA: 0x7FFE8139DA60
        public void get_LocalEndPoint(){} // RVA: 0x7FFE87690E70
        public void get_IsSecure(){} // RVA: 0x7FFE85B63B60
        public void set_Prefix(){} // RVA: 0x7FFE81176740
        public void OnTimeout(){} // RVA: 0x7FFE87690FB0
        public void BeginReadRequest(){} // RVA: 0x7FFE87691000
        public void GetRequestStream(){} // RVA: 0x7FFE87691330
        public void GetResponseStream(){} // RVA: 0x7FFE87691830
        public void OnRead(){} // RVA: 0x7FFE87691970
        public void OnReadInternal(){} // RVA: 0x7FFE87691A10
        public void RemoveConnection(){} // RVA: 0x7FFE87691F50
        public void ProcessInput(){} // RVA: 0x7FFE87691FB0
        public void ReadLine(){} // RVA: 0x7FFE87692290
        public void SendError(){} // RVA: 0x7FFE87692770 | overloaded x2
        public void Unbind(){} // RVA: 0x7FFE876927A0
        public void CloseSocket(){} // RVA: 0x7FFE876927F0
        public void Close(){} // RVA: 0x7FFE876928C0
        public void .cctor(){} // RVA: 0x7FFE87692D60
        public void <.ctor>b__24_0(){} // RVA: 0x7FFE87692E40
    }

    public class HttpContinueDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE812572A0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class HttpListener : Object
    {
        public Mono.Security.Interface.MonoTlsProvider tlsProvider; // 0x10
        public Mono.Security.Interface.MonoTlsSettings tlsSettings; // 0x18
        public System.Security.Cryptography.X509Certificates.X509Certificate certificate; // 0x20
        public 0x665336D4 auth_schemes; // 0x28
        public System.Net.HttpListenerPrefixCollection prefixes; // 0x30
        public System.Net.AuthenticationSchemeSelector auth_selector; // 0x38

        // ── Methods ──
        public void LoadCertificateAndKey(){} // RVA: 0x7FFE87692FF0
        public void CreateSslStream(){} // RVA: 0x7FFE87693560
        public void .ctor(){} // RVA: 0x7FFE87693860
        public void get_AuthenticationSchemes(){} // RVA: 0x7FFE81549710
        public void get_AuthenticationSchemeSelectorDelegate(){} // RVA: 0x7FFE8143BA80
        public void get_IgnoreWriteExceptions(){} // RVA: 0x7FFE811B2D30
        public void get_IsListening(){} // RVA: 0x7FFE82446000
        public void get_Prefixes(){} // RVA: 0x7FFE87693E30
        public void get_Realm(){} // RVA: 0x7FFE81178740
        public void Close(){} // RVA: 0x7FFE87693E90 | overloaded x2
        public void Cleanup(){} // RVA: 0x7FFE87693F10
        public void BeginGetContext(){} // RVA: 0x7FFE87694B30
        public void EndGetContext(){} // RVA: 0x7FFE876950F0
        public void SelectAuthenticationScheme(){} // RVA: 0x7FFE876955D0
        public void Start(){} // RVA: 0x7FFE87695610
        public void Stop(){} // RVA: 0x7FFE87695680
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE876956B0
        public void CheckDisposed(){} // RVA: 0x7FFE876956E0
        public void GetContextFromQueue(){} // RVA: 0x7FFE87695770
        public void RegisterContext(){} // RVA: 0x7FFE87695840
        public void UnregisterContext(){} // RVA: 0x7FFE87695DC0
        public void AddConnection(){} // RVA: 0x7FFE876960E0
        public void RemoveConnection(){} // RVA: 0x7FFE87696110
    }

    public class HttpListenerBasicIdentity : GenericIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87696140
    }

    public class HttpListenerContext : Object
    {
        public System.Net.HttpListenerRequest request; // 0x10
        public System.Net.HttpListenerResponse response; // 0x18
        public System.Security.Principal.IPrincipal user; // 0x20
        public System.Net.HttpConnection cnc; // 0x28
        public string error; // 0x30
        public int err_status; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87696200
        public void get_ErrorStatus(){} // RVA: 0x7FFE81D46090
        public void set_ErrorStatus(){} // RVA: 0x7FFE81D46A00
        public void get_ErrorMessage(){} // RVA: 0x7FFE8144E200
        public void set_ErrorMessage(){} // RVA: 0x7FFE81129890
        public void get_HaveError(){} // RVA: 0x7FFE85C00B10
        public void get_Connection(){} // RVA: 0x7FFE81129130
        public void get_Request(){} // RVA: 0x7FFE81116380
        public void get_Response(){} // RVA: 0x7FFE810FE7C0
        public void ParseAuthentication(){} // RVA: 0x7FFE87696520
        public void ParseBasicAuthentication(){} // RVA: 0x7FFE87696670
    }

    public class HttpListenerException : Win32Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8765BC90 | overloaded x3
        public void get_ErrorCode(){} // RVA: 0x7FFE814AA220
    }

    public class HttpListenerPrefixCollection : Object
    {
        public System.Collections.Generic.List`1<string> prefixes; // 0x10
        public System.Net.HttpListener listener; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87696940
        public void get_Count(){} // RVA: 0x7FFE87696A60
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void Add(){} // RVA: 0x7FFE87696AB0
        public void Clear(){} // RVA: 0x7FFE87696BE0
        public void Contains(){} // RVA: 0x7FFE87696CA0
        public void CopyTo(){} // RVA: 0x7FFE87696D10
        public void GetEnumerator(){} // RVA: 0x7FFE87696DA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87696E90
        public void Remove(){} // RVA: 0x7FFE87696F80
    }

    public class HttpListenerRequest : Object
    {
        public string[] accept_types; // 0x10
        public System.Text.Encoding content_encoding; // 0x18
        public long content_length; // 0x20
        public bool cl_set; // 0x28
        public System.Net.CookieCollection cookies; // 0x30
        public System.Net.WebHeaderCollection headers; // 0x38
        public string method; // 0x40
        public System.IO.Stream input_stream; // 0x48
        public System.Version version; // 0x50
        public System.Collections.Specialized.NameValueCollection query_string; // 0x58
        public string raw_url; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876970B0
        public void SetRequestLine(){} // RVA: 0x7FFE87697260
        public void CreateQueryString(){} // RVA: 0x7FFE87697710
        public void MaybeUri(){} // RVA: 0x7FFE87697B00
        public void IsPredefinedScheme(){} // RVA: 0x7FFE87697BA0
        public void FinishInitialization(){} // RVA: 0x7FFE87697E70
        public void Unquote(){} // RVA: 0x7FFE87698BD0
        public void AddHeader(){} // RVA: 0x7FFE87698C50
        public void FlushInput(){} // RVA: 0x7FFE876998A0
        public void get_HasEntityBody(){} // RVA: 0x7FFE87699B50
        public void get_Headers(){} // RVA: 0x7FFE8143BA80
        public void get_InputStream(){} // RVA: 0x7FFE87699B70
        public void get_IsSecureConnection(){} // RVA: 0x7FFE87699C80
        public void get_KeepAlive(){} // RVA: 0x7FFE87699CB0
        public void get_LocalEndPoint(){} // RVA: 0x7FFE87699FC0
        public void get_ProtocolVersion(){} // RVA: 0x7FFE8119C0E0
        public void get_RawUrl(){} // RVA: 0x7FFE81199370
        public void get_Url(){} // RVA: 0x7FFE81176D50
        public void get_UserHostAddress(){} // RVA: 0x7FFE8769A110
        public void get_UserHostName(){} // RVA: 0x7FFE8769A150
        public void .cctor(){} // RVA: 0x7FFE8769A1B0
    }

    public class HttpListenerRequestUriBuilder : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8765BD50
        public void .ctor(){} // RVA: 0x7FFE8765BFB0
        public void GetRequestUri(){} // RVA: 0x7FFE8765C290
        public void Build(){} // RVA: 0x7FFE8765C400
        public void BuildRequestUriUsingCookedPath(){} // RVA: 0x7FFE8765C4F0
        public void BuildRequestUriUsingRawPath(){} // RVA: 0x7FFE8765CC60 | overloaded x2
        public void GetEncoding(){} // RVA: 0x7FFE8765CBD0
        public void ParseRawPath(){} // RVA: 0x7FFE8765CFA0
        public void AppendUnicodeCodePointValuePercentEncoded(){} // RVA: 0x7FFE8765D160
        public void AddPercentEncodedOctetToRawOctetsList(){} // RVA: 0x7FFE8765D560
        public void EmptyDecodeAndAppendRawOctetsList(){} // RVA: 0x7FFE8765D790
        public void AppendOctetsPercentEncoded(){} // RVA: 0x7FFE8765DB50
        public void GetOctetsAsString(){} // RVA: 0x7FFE8765DEC0
        public void GetPath(){} // RVA: 0x7FFE8765E190
        public void AddSlashToAsteriskOnlyPath(){} // RVA: 0x7FFE8765E4F0
        public void LogWarning(){} // RVA: 0x7FFE810FB310
    }

    public class HttpListenerResponse : Object
    {
        public bool disposed; // 0x10
        public System.Text.Encoding content_encoding; // 0x18
        public long content_length; // 0x20
        public bool cl_set; // 0x28
        public string content_type; // 0x30
        public System.Net.CookieCollection cookies; // 0x38
        public System.Net.WebHeaderCollection headers; // 0x40
        public bool keep_alive; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8769A350
        public void get_ForceCloseChunked(){} // RVA: 0x7FFE81611920
        public void get_ContentEncoding(){} // RVA: 0x7FFE8769A5D0
        public void set_ContentLength64(){} // RVA: 0x7FFE8769A650
        public void set_ContentType(){} // RVA: 0x7FFE8769A790
        public void get_Headers(){} // RVA: 0x7FFE81178740
        public void get_OutputStream(){} // RVA: 0x7FFE8769A8B0
        public void get_SendChunked(){} // RVA: 0x7FFE816400C0
        public void set_SendChunked(){} // RVA: 0x7FFE8769A940
        public void set_StatusCode(){} // RVA: 0x7FFE8769AA10
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE8769AB60
        public void Close(){} // RVA: 0x7FFE8769AC10 | overloaded x3
        public void SendHeaders(){} // RVA: 0x7FFE8769ACF0
        public void FormatHeaders(){} // RVA: 0x7FFE8769BA30
        public void CookieToClientString(){} // RVA: 0x7FFE8769BCC0
        public void QuotedString(){} // RVA: 0x7FFE8769BFF0
        public void IsToken(){} // RVA: 0x7FFE8769C190
        public void .cctor(){} // RVA: 0x7FFE8769C2A0
    }

    public class HttpRequestCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE8769C350
    }

    public class HttpStatusDescription : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE8780AE30 | overloaded x2
    }

    public class HttpStreamAsyncResult : Object
    {
        public object locker; // 0x10
        public System.Threading.ManualResetEvent handle; // 0x18
        public bool completed; // 0x20
        public byte[] Buffer; // 0x28

        // ── Methods ──
        public void Complete(){} // RVA: 0x7FFE8769C410 | overloaded x2
        public void get_AsyncState(){} // RVA: 0x7FFE81178740
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFE8769C5C0
        public void get_CompletedSynchronously(){} // RVA: 0x7FFE8769C7D0
        public void get_IsCompleted(){} // RVA: 0x7FFE8769C7E0
        public void .ctor(){} // RVA: 0x7FFE8769C920
    }

    public class HttpValidationHelpers : Object
    {
        // ── Methods ──
        public void IsInvalidMethodOrHeaderString(){} // RVA: 0x7FFE8780B740
        public void .cctor(){} // RVA: 0x7FFE8780B890
    }

    public class HttpVersion : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8780DC00
    }

    public class HttpWebRequest : WebRequest
    {
        public System.Uri requestUri; // 0x38
        public System.Uri actualUri; // 0x40
        public bool hostChanged; // 0x48
        public bool allowAutoRedirect; // 0x49
        public bool allowBuffering; // 0x4A
        public bool allowReadStreamBuffering; // 0x4B
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates; // 0x50
        public string connectionGroup; // 0x58
        public bool haveContentLength; // 0x60
        public long contentLength; // 0x68
        public System.Net.HttpContinueDelegate continueDelegate; // 0x70
        public System.Net.CookieContainer cookieContainer; // 0x78
        public System.Net.ICredentials credentials; // 0x80
        public bool haveResponse; // 0x88
        public bool requestSent; // 0x89
        public System.Net.WebHeaderCollection webHeaders; // 0x90
        public bool keepAlive; // 0x98
        public int maxAutoRedirect; // 0x9C
        public string mediaType; // 0xA0
        public string method; // 0xA8
        public string initialMethod; // 0xB0
        public bool pipelined; // 0xB8
        public bool preAuthenticate; // 0xB9
        public bool usedPreAuth; // 0xBA
        public System.Version version; // 0xC0
        public bool force_version; // 0xC8
        public System.Version actualVersion; // 0xD0
        public System.Net.IWebProxy proxy; // 0xD8
        public bool sendChunked; // 0xE0
        public System.Net.ServicePoint servicePoint; // 0xE8
        public int timeout; // 0xF0
        public int continueTimeout; // 0xF4
        public System.Net.WebRequestStream writeStream; // 0xF8
        public System.Net.HttpWebResponse webResponse; // 0x100
        public System.Net.WebCompletionSource responseTask; // 0x108
        public System.Net.WebOperation currentOperation; // 0x110
        public int aborted; // 0x118
        public bool gotRequestStream; // 0x11C
        public int redirects; // 0x120
        public bool expectContinue; // 0x124
        public bool getResponseCalled; // 0x125

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8769C9B0
        public void .ctor(){} // RVA: 0x7FFE876A32F0 | overloaded x4
        public void ResetAuthorization(){} // RVA: 0x7FFE8769D3B0
        public void get_Address(){} // RVA: 0x7FFE81178740
        public void set_AllowAutoRedirect(){} // RVA: 0x7FFE820ED810
        public void get_AllowWriteStreamBuffering(){} // RVA: 0x7FFE82446000
        public void set_AllowWriteStreamBuffering(){} // RVA: 0x7FFE82444AD0
        public void get_AutomaticDecompression(){} // RVA: 0x7FFE8769D550
        public void set_AutomaticDecompression(){} // RVA: 0x7FFE8769D560
        public void get_InternalAllowBuffering(){} // RVA: 0x7FFE8769D5D0
        public void get_MethodWithBuffer(){} // RVA: 0x7FFE8769D5E0
        public void get_TlsProvider(){} // RVA: 0x7FFE811665F0
        public void get_TlsSettings(){} // RVA: 0x7FFE81166660
        public void get_ClientCertificates(){} // RVA: 0x7FFE8769D7D0
        public void set_ConnectionGroupName(){} // RVA: 0x7FFE811C3510
        public void get_ContentLength(){} // RVA: 0x7FFE81176D50
        public void set_ContentLength(){} // RVA: 0x7FFE8769D880
        public void set_InternalContentLength(){} // RVA: 0x7FFE82C95C80
        public void get_ThrowOnError(){} // RVA: 0x7FFE86DBDB30
        public void set_ThrowOnError(){} // RVA: 0x7FFE8769D950
        public void set_CookieContainer(){} // RVA: 0x7FFE81464570
        public void get_Credentials(){} // RVA: 0x7FFE81280C30
        public void set_Credentials(){} // RVA: 0x7FFE81282380
        public void get_DefaultMaximumErrorResponseLength(){} // RVA: 0x7FFE8769D960
        public void get_Headers(){} // RVA: 0x7FFE8154EB60
        public void get_Host(){} // RVA: 0x7FFE8769D9C0
        public void set_Host(){} // RVA: 0x7FFE8769DB50
        public void TryGetHostUri(){} // RVA: 0x7FFE8769DE00
        public void get_KeepAlive(){} // RVA: 0x7FFE81611920
        public void set_KeepAlive(){} // RVA: 0x7FFE81611930
        public void set_MaximumAutomaticRedirections(){} // RVA: 0x7FFE8769DEE0
        public void get_DefaultMaximumResponseHeadersLength(){} // RVA: 0x7FFE8769DF70
        public void get_ReadWriteTimeout(){} // RVA: 0x7FFE86C70920
        public void get_Method(){} // RVA: 0x7FFE817AB5E0
        public void set_Method(){} // RVA: 0x7FFE8769DFD0
        public void set_PreAuthenticate(){} // RVA: 0x7FFE8453D830
        public void get_ProtocolVersion(){} // RVA: 0x7FFE81166120
        public void set_ProtocolVersion(){} // RVA: 0x7FFE8769E550
        public void get_Proxy(){} // RVA: 0x7FFE8181EA80
        public void set_Proxy(){} // RVA: 0x7FFE8769E710
        public void get_RequestUri(){} // RVA: 0x7FFE8143BA80
        public void get_SendChunked(){} // RVA: 0x7FFE81226F80
        public void set_SendChunked(){} // RVA: 0x7FFE8769E850
        public void get_ServicePoint(){} // RVA: 0x7FFE8769E8C0
        public void get_ServicePointNoLock(){} // RVA: 0x7FFE8117C970
        public void get_Timeout(){} // RVA: 0x7FFE843B5350
        public void set_Timeout(){} // RVA: 0x7FFE8769E8D0
        public void get_TransferEncoding(){} // RVA: 0x7FFE8769E940
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFE8769E9A0
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7FFE86DBDB40
        public void get_ExpectContinue(){} // RVA: 0x7FFE8769EA20
        public void set_ExpectContinue(){} // RVA: 0x7FFE8769EA30
        public void get_AuthUri(){} // RVA: 0x7FFE81178740
        public void get_ProxyQuery(){} // RVA: 0x7FFE8769EA40
        public void get_ServerCertValidationCallback(){} // RVA: 0x7FFE81790740
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7FFE8769EA70
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7FFE8769EA90
        public void GetServicePoint(){} // RVA: 0x7FFE8769EBE0
        public void SendRequest(){} // RVA: 0x7FFE8769EE00
        public void MyGetRequestStreamAsync(){} // RVA: 0x7FFE8769F1C0
        public void BeginGetRequestStream(){} // RVA: 0x7FFE8769F8D0
        public void EndGetRequestStream(){} // RVA: 0x7FFE8769F990
        public void GetRequestStreamAsync(){} // RVA: 0x7FFE8769FA60
        public void RunWithTimeout(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void RunWithTimeoutWorker(){} // RVA: 0x7FFE80E3FA00
        public void MyGetResponseAsync(){} // RVA: 0x7FFE8769FAF0
        public void GetResponseFromData(){} // RVA: 0x7FFE8769FCE0
        public void FlattenException(){} // RVA: 0x7FFE8769FF40
        public void GetWebException(){} // RVA: 0x7FFE876A00E0 | overloaded x2
        public void CreateRequestAbortedException(){} // RVA: 0x7FFE876A02D0
        public void BeginGetResponse(){} // RVA: 0x7FFE876A0390
        public void EndGetResponse(){} // RVA: 0x7FFE876A05B0
        public void GetResponse(){} // RVA: 0x7FFE876A0680
        public void set_FinishedReading(){} // RVA: 0x7FFE876A0740
        public void get_Aborted(){} // RVA: 0x7FFE833F8BA0
        public void Abort(){} // RVA: 0x7FFE876A0750
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE876A0930
        public void GetObjectData(){} // RVA: 0x7FFE876A0970
        public void CheckRequestStarted(){} // RVA: 0x7FFE876A09B0
        public void DoContinueDelegate(){} // RVA: 0x7FFE876A0A20
        public void RewriteRedirectToGet(){} // RVA: 0x7FFE876A0A40
        public void Redirect(){} // RVA: 0x7FFE876A0B50
        public void GetHeaders(){} // RVA: 0x7FFE876A12F0
        public void DoPreAuthenticate(){} // RVA: 0x7FFE876A1E90
        public void GetRequestHeaders(){} // RVA: 0x7FFE876A20C0
        public void HandleNtlmAuth(){} // RVA: 0x7FFE876A2610
        public void CheckAuthorization(){} // RVA: 0x7FFE876A28D0
        public void GetRewriteHandler(){} // RVA: 0x7FFE876A2900
        public void CheckFinalStatus(){} // RVA: 0x7FFE876A2B70
        public void <RunWithTimeout>b__242_0(){} // RVA: 0x7FFE80E2F150
        public void <GetRewriteHandler>b__271_0(){} // RVA: 0x7FFE876A3150
    }

    public class HttpWebResponse : WebResponse
    {
        public System.Uri uri; // 0x20
        public System.Net.WebHeaderCollection webHeaders; // 0x28
        public System.Net.CookieCollection cookieCollection; // 0x30
        public string method; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876A72B0 | overloaded x4
        public void get_Headers(){} // RVA: 0x7FFE81129130
        public void get_ResponseUri(){} // RVA: 0x7FFE876A79A0
        public void get_StatusCode(){} // RVA: 0x7FFE8119C0C0
        public void get_StatusDescription(){} // RVA: 0x7FFE876A79C0
        public void GetResponseStream(){} // RVA: 0x7FFE876A79E0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87667F80
        public void GetObjectData(){} // RVA: 0x7FFE876A7B60
        public void Close(){} // RVA: 0x7FFE876A8960
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE8699B180
        public void Dispose(){} // RVA: 0x7FFE876A89A0
        public void CheckDisposed(){} // RVA: 0x7FFE876A89B0
        public void FillCookies(){} // RVA: 0x7FFE876A8A40
    }

}