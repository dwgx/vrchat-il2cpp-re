// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 21
// Methods: 269

namespace ThirdParty.DotNet.System.Net
{
    public class HeaderInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B2A790
    }

    public class HeaderInfoTable
    {
        public System.Collections.Hashtable HeaderHashTable;

        // ── Methods ──
        public void ParseSingleValue(){} // RVA: 0x6B2A860
        public void ParseMultiValue(){} // RVA: 0x6B2A8D0
        public void .cctor(){} // RVA: 0x6B2AB90
        public void get_Item(){} // RVA: 0x6B2CD70
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HeaderParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4634FE0
        public void Invoke(){} // RVA: 0x338C60
    }

    public class HeaderVariantInfo
    {
        public string m_name; // 0x10
        public 0x65856CD8 m_variant; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x820840
        public void get_Name(){} // RVA: 0x1AD4690
        public void get_Variant(){} // RVA: 0x1EA9890
    }

    public class HttpConnection
    {
        public System.AsyncCallback onread_cb;
        public int BufferSize;
        public System.Net.Sockets.Socket sock; // 0x10
        public System.IO.Stream stream; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B514A0
        public void Init(){} // RVA: 0x6B51950
        public void get_Reuses(){} // RVA: 0x59C4F0
        public void get_LocalEndPoint(){} // RVA: 0x6B51BC0
        public void get_IsSecure(){} // RVA: 0x4EC4D70
        public void set_Prefix(){} // RVA: 0x358740
        public void OnTimeout(){} // RVA: 0x6B51D00
        public void BeginReadRequest(){} // RVA: 0x6B51D50
        public void GetRequestStream(){} // RVA: 0x6B52080
        public void GetResponseStream(){} // RVA: 0x6B52580
        public void OnRead(){} // RVA: 0x6B526C0
        public void OnReadInternal(){} // RVA: 0x6B52760
        public void RemoveConnection(){} // RVA: 0x6B52CA0
        public void ProcessInput(){} // RVA: 0x6B52D00
        public void ReadLine(){} // RVA: 0x6B52FE0
        public void SendError(){} // RVA: 0x6B534C0 | overloaded x2
        public void Unbind(){} // RVA: 0x6B534F0
        public void CloseSocket(){} // RVA: 0x6B53540
        public void Close(){} // RVA: 0x6B53610
        public void .cctor(){} // RVA: 0x6B53AB0
        public void <.ctor>b__24_0(){} // RVA: 0x6B53B90
    }

    public class HttpContinueDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4392A0
        public void Invoke(){} // RVA: 0x439370
    }

    public class HttpListener
    {
        public Mono.Security.Interface.MonoTlsProvider tlsProvider; // 0x10
        public Mono.Security.Interface.MonoTlsSettings tlsSettings; // 0x18
        public System.Security.Cryptography.X509Certificates.X509Certificate certificate; // 0x20
        public 0x65855730 auth_schemes; // 0x28
        public System.Net.HttpListenerPrefixCollection prefixes; // 0x30
        public System.Net.AuthenticationSchemeSelector auth_selector; // 0x38

        // ── Methods ──
        public void LoadCertificateAndKey(){} // RVA: 0x6B53D40
        public void CreateSslStream(){} // RVA: 0x6B542B0
        public void .ctor(){} // RVA: 0x6B545B0
        public void get_AuthenticationSchemes(){} // RVA: 0x791DC0
        public void get_AuthenticationSchemeSelectorDelegate(){} // RVA: 0x4976A0
        public void get_IgnoreWriteExceptions(){} // RVA: 0x394D30
        public void get_IsListening(){} // RVA: 0x16DF2D0
        public void get_Prefixes(){} // RVA: 0x6B54B80
        public void get_Realm(){} // RVA: 0x35A740
        public void Close(){} // RVA: 0x6B54BE0 | overloaded x2
        public void Cleanup(){} // RVA: 0x6B54C60
        public void BeginGetContext(){} // RVA: 0x6B55880
        public void EndGetContext(){} // RVA: 0x6B55E40
        public void SelectAuthenticationScheme(){} // RVA: 0x6B56320
        public void Start(){} // RVA: 0x6B56360
        public void Stop(){} // RVA: 0x6B563D0
        public void System.IDisposable.Dispose(){} // RVA: 0x6B56400
        public void CheckDisposed(){} // RVA: 0x6B56430
        public void GetContextFromQueue(){} // RVA: 0x6B564C0
        public void RegisterContext(){} // RVA: 0x6B56590
        public void UnregisterContext(){} // RVA: 0x6B56B10
        public void AddConnection(){} // RVA: 0x6B56E30
        public void RemoveConnection(){} // RVA: 0x6B56E60
    }

    public class HttpListenerBasicIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B56E90
    }

    public class HttpListenerContext
    {
        public System.Net.HttpListenerRequest request; // 0x10
        public System.Net.HttpListenerResponse response; // 0x18
        public System.Security.Principal.IPrincipal user; // 0x20
        public System.Net.HttpConnection cnc; // 0x28
        public string error; // 0x30
        public int err_status; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B56F50
        public void get_ErrorStatus(){} // RVA: 0xFDC9F0
        public void set_ErrorStatus(){} // RVA: 0xFDD6E0
        public void get_ErrorMessage(){} // RVA: 0x6374D0
        public void set_ErrorMessage(){} // RVA: 0x30B890
        public void get_HaveError(){} // RVA: 0x51555E0
        public void get_Connection(){} // RVA: 0x30B130
        public void get_Request(){} // RVA: 0x2F8380
        public void get_Response(){} // RVA: 0x2E07C0
        public void ParseAuthentication(){} // RVA: 0x6B57270
        public void ParseBasicAuthentication(){} // RVA: 0x6B573C0
    }

    public class HttpListenerException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B1C9D0 | overloaded x3
        public void get_ErrorCode(){} // RVA: 0x6AFD40
    }

    public class HttpListenerPrefixCollection
    {
        public System.Collections.Generic.List`1<string> prefixes; // 0x10
        public System.Net.HttpListener listener; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B57690
        public void get_Count(){} // RVA: 0x6B577B0
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void Add(){} // RVA: 0x6B57800
        public void Clear(){} // RVA: 0x6B57930
        public void Contains(){} // RVA: 0x6B579F0
        public void CopyTo(){} // RVA: 0x6B57A60
        public void GetEnumerator(){} // RVA: 0x6B57AF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6B57BE0
        public void Remove(){} // RVA: 0x6B57CD0
    }

    public class HttpListenerRequest
    {
        public string[] ForceCloseChunked; // 0x10
        public System.Text.Encoding ContentEncoding; // 0x18
        public long ContentLength64; // 0x20
        public bool ContentType; // 0x28
        public System.Net.CookieCollection Headers; // 0x30
        public System.Net.WebHeaderCollection OutputStream; // 0x38
        public string SendChunked; // 0x40
        public System.IO.Stream StatusCode; // 0x48
        public System.Version version; // 0x50
        public System.Collections.Specialized.NameValueCollection query_string; // 0x58
        public string raw_url; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B57E00
        public void SetRequestLine(){} // RVA: 0x6B57FB0
        public void CreateQueryString(){} // RVA: 0x6B58460
        public void MaybeUri(){} // RVA: 0x6B58850
        public void IsPredefinedScheme(){} // RVA: 0x6B588F0
        public void FinishInitialization(){} // RVA: 0x6B58BC0
        public void Unquote(){} // RVA: 0x6B59920
        public void AddHeader(){} // RVA: 0x6B599A0
        public void FlushInput(){} // RVA: 0x6B5A5F0
        public void get_HasEntityBody(){} // RVA: 0x6B5A8A0
        public void get_Headers(){} // RVA: 0x4976A0
        public void get_InputStream(){} // RVA: 0x6B5A8C0
        public void get_IsSecureConnection(){} // RVA: 0x6B5A9D0
        public void get_KeepAlive(){} // RVA: 0x6B5AA00
        public void get_LocalEndPoint(){} // RVA: 0x6B5AD10
        public void get_ProtocolVersion(){} // RVA: 0x37E0E0
        public void get_RawUrl(){} // RVA: 0x37B370
        public void get_Url(){} // RVA: 0x358D50
        public void get_UserHostAddress(){} // RVA: 0x6B5AE60
        public void get_UserHostName(){} // RVA: 0x6B5AEA0
        public void .cctor(){} // RVA: 0x6B5AF00
    }

    public class HttpListenerRequestUriBuilder
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6B1CA90
        public void .ctor(){} // RVA: 0x6B1CCF0
        public void GetRequestUri(){} // RVA: 0x6B1CFD0
        public void Build(){} // RVA: 0x6B1D140
        public void BuildRequestUriUsingCookedPath(){} // RVA: 0x6B1D230
        public void BuildRequestUriUsingRawPath(){} // RVA: 0x6B1D9A0 | overloaded x2
        public void GetEncoding(){} // RVA: 0x6B1D910
        public void ParseRawPath(){} // RVA: 0x6B1DCE0
        public void AppendUnicodeCodePointValuePercentEncoded(){} // RVA: 0x6B1DEA0
        public void AddPercentEncodedOctetToRawOctetsList(){} // RVA: 0x6B1E2A0
        public void EmptyDecodeAndAppendRawOctetsList(){} // RVA: 0x6B1E4D0
        public void AppendOctetsPercentEncoded(){} // RVA: 0x6B1E890
        public void GetOctetsAsString(){} // RVA: 0x6B1EC00
        public void GetPath(){} // RVA: 0x6B1EED0
        public void AddSlashToAsteriskOnlyPath(){} // RVA: 0x6B1F230
        public void LogWarning(){} // RVA: 0x2DD310
    }

    public class HttpListenerResponse
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
        public void .ctor(){} // RVA: 0x6B5B0A0
        public void get_ForceCloseChunked(){} // RVA: 0x86DB40
        public void get_ContentEncoding(){} // RVA: 0x6B5B320
        public void set_ContentLength64(){} // RVA: 0x6B5B3A0
        public void set_ContentType(){} // RVA: 0x6B5B4E0
        public void get_Headers(){} // RVA: 0x35A740
        public void get_OutputStream(){} // RVA: 0x6B5B600
        public void get_SendChunked(){} // RVA: 0x8A10E0
        public void set_SendChunked(){} // RVA: 0x6B5B690
        public void set_StatusCode(){} // RVA: 0x6B5B760
        public void System.IDisposable.Dispose(){} // RVA: 0x6B5B8B0
        public void Close(){} // RVA: 0x6B5B960 | overloaded x3
        public void SendHeaders(){} // RVA: 0x6B5BA40
        public void FormatHeaders(){} // RVA: 0x6B5C780
        public void CookieToClientString(){} // RVA: 0x6B5CA10
        public void QuotedString(){} // RVA: 0x6B5CD40
        public void IsToken(){} // RVA: 0x6B5CEE0
        public void .cctor(){} // RVA: 0x6B5CFF0
    }

    public class HttpRequestCreator : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x6B5D0A0
    }

    public class HttpStatusDescription
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x6CC9F90 | overloaded x2
    }

    public class HttpStreamAsyncResult
    {
        public object locker; // 0x10
        public System.Threading.ManualResetEvent handle; // 0x18
        public bool completed; // 0x20
        public byte[] Buffer; // 0x28

        // ── Methods ──
        public void Complete(){} // RVA: 0x6B5D160 | overloaded x2
        public void get_AsyncState(){} // RVA: 0x35A740
        public void get_AsyncWaitHandle(){} // RVA: 0x6B5D310
        public void get_CompletedSynchronously(){} // RVA: 0x6B5D520
        public void get_IsCompleted(){} // RVA: 0x6B5D530
        public void .ctor(){} // RVA: 0x6B5D670
    }

    public class HttpValidationHelpers
    {
        // ── Methods ──
        public void IsInvalidMethodOrHeaderString(){} // RVA: 0x6CCA8A0
        public void .cctor(){} // RVA: 0x6CCA9F0
    }

    public class HttpVersion
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6CCCD60
    }

    public class HttpWebRequest
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
        public void .cctor(){} // RVA: 0x6B5D700
        public void .ctor(){} // RVA: 0x6B64040 | overloaded x4
        public void ResetAuthorization(){} // RVA: 0x6B5E100
        public void get_Address(){} // RVA: 0x35A740
        public void set_AllowAutoRedirect(){} // RVA: 0x1376F60
        public void get_AllowWriteStreamBuffering(){} // RVA: 0x16DF2D0
        public void set_AllowWriteStreamBuffering(){} // RVA: 0x16DE990
        public void get_AutomaticDecompression(){} // RVA: 0x6B5E2A0
        public void set_AutomaticDecompression(){} // RVA: 0x6B5E2B0
        public void get_InternalAllowBuffering(){} // RVA: 0x6B5E320
        public void get_MethodWithBuffer(){} // RVA: 0x6B5E330
        public void get_TlsProvider(){} // RVA: 0x3485F0
        public void get_TlsSettings(){} // RVA: 0x348660
        public void get_ClientCertificates(){} // RVA: 0x6B5E520
        public void set_ConnectionGroupName(){} // RVA: 0x3A5510
        public void get_ContentLength(){} // RVA: 0x358D50
        public void set_ContentLength(){} // RVA: 0x6B5E5D0
        public void set_InternalContentLength(){} // RVA: 0x1F0AB90
        public void get_ThrowOnError(){} // RVA: 0x627D100
        public void set_ThrowOnError(){} // RVA: 0x6B5E6A0
        public void set_CookieContainer(){} // RVA: 0x4C34F0
        public void get_Credentials(){} // RVA: 0x462D00
        public void set_Credentials(){} // RVA: 0x464450
        public void get_DefaultMaximumErrorResponseLength(){} // RVA: 0x6B5E6B0
        public void get_Headers(){} // RVA: 0x796DE0
        public void get_Host(){} // RVA: 0x6B5E710
        public void set_Host(){} // RVA: 0x6B5E8A0
        public void TryGetHostUri(){} // RVA: 0x6B5EB50
        public void get_KeepAlive(){} // RVA: 0x86DB40
        public void set_KeepAlive(){} // RVA: 0x86DB50
        public void set_MaximumAutomaticRedirections(){} // RVA: 0x6B5EC30
        public void get_DefaultMaximumResponseHeadersLength(){} // RVA: 0x6B5ECC0
        public void get_ReadWriteTimeout(){} // RVA: 0x612FB40
        public void get_Method(){} // RVA: 0xA1C130
        public void set_Method(){} // RVA: 0x6B5ED20
        public void set_PreAuthenticate(){} // RVA: 0x38EED50
        public void get_ProtocolVersion(){} // RVA: 0x348120
        public void set_ProtocolVersion(){} // RVA: 0x6B5F2A0
        public void get_Proxy(){} // RVA: 0xA96D30
        public void set_Proxy(){} // RVA: 0x6B5F460
        public void get_RequestUri(){} // RVA: 0x4976A0
        public void get_SendChunked(){} // RVA: 0x408F80
        public void set_SendChunked(){} // RVA: 0x6B5F5A0
        public void get_ServicePoint(){} // RVA: 0x6B5F610
        public void get_ServicePointNoLock(){} // RVA: 0x35E970
        public void get_Timeout(){} // RVA: 0x3739380
        public void set_Timeout(){} // RVA: 0x6B5F620
        public void get_TransferEncoding(){} // RVA: 0x6B5F690
        public void get_UseDefaultCredentials(){} // RVA: 0x6B5F6F0
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x627D110
        public void get_ExpectContinue(){} // RVA: 0x6B5F770
        public void set_ExpectContinue(){} // RVA: 0x6B5F780
        public void get_AuthUri(){} // RVA: 0x35A740
        public void get_ProxyQuery(){} // RVA: 0x6B5F790
        public void get_ServerCertValidationCallback(){} // RVA: 0x9FE130
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x6B5F7C0
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x6B5F7E0
        public void GetServicePoint(){} // RVA: 0x6B5F930
        public void SendRequest(){} // RVA: 0x6B5FB50
        public void MyGetRequestStreamAsync(){} // RVA: 0x6B5FF10
        public void BeginGetRequestStream(){} // RVA: 0x6B60620
        public void EndGetRequestStream(){} // RVA: 0x6B606E0
        public void GetRequestStreamAsync(){} // RVA: 0x6B607B0
        public void RunWithTimeout(){} // RVA: 0xCE10 | overloaded x2
        public void RunWithTimeoutWorker(){} // RVA: 0x1E490
        public void MyGetResponseAsync(){} // RVA: 0x6B60840
        public void GetResponseFromData(){} // RVA: 0x6B60A30
        public void FlattenException(){} // RVA: 0x6B60C90
        public void GetWebException(){} // RVA: 0x6B60E30 | overloaded x2
        public void CreateRequestAbortedException(){} // RVA: 0x6B61020
        public void BeginGetResponse(){} // RVA: 0x6B610E0
        public void EndGetResponse(){} // RVA: 0x6B61300
        public void GetResponse(){} // RVA: 0x6B613D0
        public void set_FinishedReading(){} // RVA: 0x6B61490
        public void get_Aborted(){} // RVA: 0x26A7D20
        public void Abort(){} // RVA: 0x6B614A0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6B61680
        public void GetObjectData(){} // RVA: 0x6B616C0
        public void CheckRequestStarted(){} // RVA: 0x6B61700
        public void DoContinueDelegate(){} // RVA: 0x6B61770
        public void RewriteRedirectToGet(){} // RVA: 0x6B61790
        public void Redirect(){} // RVA: 0x6B618A0
        public void GetHeaders(){} // RVA: 0x6B62040
        public void DoPreAuthenticate(){} // RVA: 0x6B62BE0
        public void GetRequestHeaders(){} // RVA: 0x6B62E10
        public void HandleNtlmAuth(){} // RVA: 0x6B63360
        public void CheckAuthorization(){} // RVA: 0x6B63620
        public void GetRewriteHandler(){} // RVA: 0x6B63650
        public void CheckFinalStatus(){} // RVA: 0x6B638C0
        public void <RunWithTimeout>b__242_0(){} // RVA: 0xDBE0
        public void <GetRewriteHandler>b__271_0(){} // RVA: 0x6B63EA0
    }

    public class HttpWebResponse
    {
        public System.Uri uri; // 0x20
        public System.Net.WebHeaderCollection webHeaders; // 0x28
        public System.Net.CookieCollection cookieCollection; // 0x30
        public string method; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B68000 | overloaded x4
        public void get_Headers(){} // RVA: 0x30B130
        public void get_ResponseUri(){} // RVA: 0x6B686F0
        public void get_StatusCode(){} // RVA: 0x37E0C0
        public void get_StatusDescription(){} // RVA: 0x6B68710
        public void GetResponseStream(){} // RVA: 0x6B68730
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6B28CC0
        public void GetObjectData(){} // RVA: 0x6B688B0
        public void Close(){} // RVA: 0x6B696B0
        public void System.IDisposable.Dispose(){} // RVA: 0x5E5A340
        public void Dispose(){} // RVA: 0x6B696F0
        public void CheckDisposed(){} // RVA: 0x6B69700
        public void FillCookies(){} // RVA: 0x6B69790
    }

}