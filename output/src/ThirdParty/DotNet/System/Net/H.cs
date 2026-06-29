// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 21
// Methods: 252

namespace ThirdParty.DotNet.System.Net
{
    public class HeaderInfo : Object
    {
        public object IsRequestRestricted;
        public object IsResponseRestricted;
        public object Parser;
        public object HeaderName;
        public object AllowMultiValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x758EB60
    }

    public class HeaderInfoTable : Object
    {
        public object HeaderHashTable;
        public object UnknownHeaderInfo;
        public object SingleParser;
        public object MultiParser;

        // ── Methods ──
        public void ParseSingleValue(){} // RVA: 0x758EC30
        public void ParseMultiValue(){} // RVA: 0x758ECA0
        public void .cctor(){} // RVA: 0x758EF80
        public void get_Item(){} // RVA: 0x7591150
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HeaderParser : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F6ECE0
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class HeaderVariantInfo : ValueType
    {
        public object m_name;
        public object m_variant;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x28E70
        public void get_Name(){} // RVA: 0x77900
        public void get_Variant(){} // RVA: 0x14790
    }

    public class HttpConnection : Object
    {
        public object onread_cb;
        public object BufferSize;
        public object sock;
        public object stream;
        public object epl;
        public object ms;
        public object buffer;
        public object context;
        public object current_line;
        public object prefix;
        public object i_stream;
        public object o_stream;
        public object chunked;
        public object reuses;
        public object context_bound;
        public object secure;
        public object cert;
        public object s_timeout;
        public object timer;
        public object local_ep;
        public object last_listener;
        public object client_cert_errors;
        public object client_cert;
        public object ssl_stream;
        public object input_state;
        public object line_state;
        public object position;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75B40C0
        public void Init(){} // RVA: 0x75B4570
        public void get_Reuses(){} // RVA: 0xD34720
        public void get_LocalEndPoint(){} // RVA: 0x75B47E0
        public void get_IsSecure(){} // RVA: 0x6296240
        public void set_Prefix(){} // RVA: 0xBBF900
        public void OnTimeout(){} // RVA: 0x75B4920
        public void BeginReadRequest(){} // RVA: 0x75B4970
        public void GetRequestStream(){} // RVA: 0x75B4CA0
        public void GetResponseStream(){} // RVA: 0x75B51A0
        public void OnRead(){} // RVA: 0x75B52E0
        public void OnReadInternal(){} // RVA: 0x75B5380
        public void RemoveConnection(){} // RVA: 0x75B58C0
        public void ProcessInput(){} // RVA: 0x75B5920
        public void ReadLine(){} // RVA: 0x75B5C00
        public void SendError(){} // RVA: 0x75B60F0
        public void Unbind(){} // RVA: 0x75B6120
        public void CloseSocket(){} // RVA: 0x75B6170
        public void Close(){} // RVA: 0x75B6240
        public void .cctor(){} // RVA: 0x75B66F0
        public void <.ctor>b__24_0(){} // RVA: 0x75B67D0
    }

    public class HttpContinueDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xCA8B20
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class HttpListener : Object
    {
        public object tlsProvider;
        public object tlsSettings;
        public object certificate;
        public object auth_schemes;
        public object prefixes;
        public object auth_selector;
        public object realm;
        public object ignore_write_exceptions;
        public object unsafe_ntlm_auth;
        public object listening;
        public object disposed;
        public object _internalLock;
        public object registry;
        public object ctx_queue;
        public object wait_queue;
        public object connections;
        public object defaultServiceNames;
        public object extendedProtectionPolicy;
        public object extendedProtectionSelectorDelegate;

        // ── Methods ──
        public void LoadCertificateAndKey(){} // RVA: 0x75B6980
        public void CreateSslStream(){} // RVA: 0x75B6EA0
        public void .ctor(){} // RVA: 0x75B7170
        public void get_AuthenticationSchemes(){} // RVA: 0x1065D50
        public void get_AuthenticationSchemeSelectorDelegate(){} // RVA: 0xD05CA0
        public void get_IgnoreWriteExceptions(){} // RVA: 0xBFDA40
        public void get_IsListening(){} // RVA: 0x1FA9920
        public void get_Prefixes(){} // RVA: 0x75B7740
        public void get_Realm(){} // RVA: 0xBC1B30
        public void Close(){} // RVA: 0x75B77A0
        public void Cleanup(){} // RVA: 0x75B7820
        public void BeginGetContext(){} // RVA: 0x75B8320
        public void EndGetContext(){} // RVA: 0x75B8890
        public void SelectAuthenticationScheme(){} // RVA: 0x75B8D40
        public void Start(){} // RVA: 0x75B8D80
        public void Stop(){} // RVA: 0x75B8DF0
        public void System.IDisposable.Dispose(){} // RVA: 0x75B8E20
        public void CheckDisposed(){} // RVA: 0x75B8E50
        public void GetContextFromQueue(){} // RVA: 0x75B8EE0
        public void RegisterContext(){} // RVA: 0x75B8FB0
        public void UnregisterContext(){} // RVA: 0x75B9490
        public void AddConnection(){} // RVA: 0x75B9740
        public void RemoveConnection(){} // RVA: 0x75B9770
    }

    public class HttpListenerBasicIdentity : GenericIdentity
    {
        public object password;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75B97A0
    }

    public class HttpListenerContext : Object
    {
        public object request;
        public object response;
        public object user;
        public object cnc;
        public object error;
        public object err_status;
        public object Listener;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75B9FA0
        public void get_ErrorStatus(){} // RVA: 0x18A0130
        public void set_ErrorStatus(){} // RVA: 0x189D3F0
        public void get_ErrorMessage(){} // RVA: 0xD33E60
        public void set_ErrorMessage(){} // RVA: 0xB708C0
        public void get_HaveError(){} // RVA: 0x5BC22D0
        public void get_Connection(){} // RVA: 0xB70160
        public void get_Request(){} // RVA: 0xB5DBF0
        public void get_Response(){} // RVA: 0xB465B0
        public void ParseAuthentication(){} // RVA: 0x75B9B80
        public void ParseBasicAuthentication(){} // RVA: 0x75B9CD0
    }

    public class HttpListenerException : Win32Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7580C70
        public void get_ErrorCode(){} // RVA: 0xF3A950
    }

    public class HttpListenerPrefixCollection : Object
    {
        public object prefixes;
        public object listener;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75BA740
        public void get_Count(){} // RVA: 0x75BA0F0
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void Add(){} // RVA: 0x75BA140
        public void Clear(){} // RVA: 0x75BA270
        public void Contains(){} // RVA: 0x75BA330
        public void CopyTo(){} // RVA: 0x75BA3A0
        public void GetEnumerator(){} // RVA: 0x75BA430
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x75BA520
        public void Remove(){} // RVA: 0x75BA610
    }

    public class HttpListenerRequest : Object
    {
        public object accept_types;
        public object content_encoding;
        public object content_length;
        public object cl_set;
        public object cookies;
        public object headers;
        public object method;
        public object input_stream;
        public object version;
        public object query_string;
        public object raw_url;
        public object url;
        public object referrer;
        public object user_languages;
        public object context;
        public object is_chunked;
        public object ka_set;
        public object keep_alive;
        public object gcc_delegate;
        public object _100continue;
        public object separators;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75BD930
        public void SetRequestLine(){} // RVA: 0x75BA920
        public void CreateQueryString(){} // RVA: 0x75BADC0
        public void MaybeUri(){} // RVA: 0x75BB1B0
        public void IsPredefinedScheme(){} // RVA: 0x75BB250
        public void FinishInitialization(){} // RVA: 0x75BB550
        public void Unquote(){} // RVA: 0x75BC2A0
        public void AddHeader(){} // RVA: 0x75BC320
        public void FlushInput(){} // RVA: 0x75BCE70
        public void get_HasEntityBody(){} // RVA: 0x75BD130
        public void get_Headers(){} // RVA: 0xD05CA0
        public void get_InputStream(){} // RVA: 0x75BD150
        public void get_IsSecureConnection(){} // RVA: 0x75BD260
        public void get_KeepAlive(){} // RVA: 0x75BD290
        public void get_LocalEndPoint(){} // RVA: 0x75BD5A0
        public void get_ProtocolVersion(){} // RVA: 0xBE58B0
        public void get_RawUrl(){} // RVA: 0xBE2C60
        public void get_Url(){} // RVA: 0xBBFF90
        public void get_UserHostAddress(){} // RVA: 0x75BD6F0
        public void get_UserHostName(){} // RVA: 0x75BD730
        public void .cctor(){} // RVA: 0x75BD790
    }

    public class HttpListenerRequestUriBuilder : Object
    {
        public object useCookedRequestUrl;
        public object utf8Encoding;
        public object ansiEncoding;
        public object rawUri;
        public object cookedUriScheme;
        public object cookedUriHost;
        public object cookedUriPath;
        public object cookedUriQuery;
        public object requestUriString;
        public object rawOctets;
        public object rawPath;
        public object requestUri;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7580D30
        public void .ctor(){} // RVA: 0x7580F90
        public void GetRequestUri(){} // RVA: 0x7581260
        public void Build(){} // RVA: 0x75813D0
        public void BuildRequestUriUsingCookedPath(){} // RVA: 0x75814C0
        public void BuildRequestUriUsingRawPath(){} // RVA: 0x7581C10
        public void GetEncoding(){} // RVA: 0x7581B80
        public void ParseRawPath(){} // RVA: 0x7581F70
        public void AppendUnicodeCodePointValuePercentEncoded(){} // RVA: 0x7582130
        public void AddPercentEncodedOctetToRawOctetsList(){} // RVA: 0x7582670
        public void EmptyDecodeAndAppendRawOctetsList(){} // RVA: 0x7582890
        public void AppendOctetsPercentEncoded(){} // RVA: 0x7582C50
        public void GetOctetsAsString(){} // RVA: 0x7582FD0
        public void GetPath(){} // RVA: 0x75832B0
        public void AddSlashToAsteriskOnlyPath(){} // RVA: 0x7583610
        public void LogWarning(){} // RVA: 0xB43310
    }

    public class HttpListenerResponse : Object
    {
        public object disposed;
        public object content_encoding;
        public object content_length;
        public object cl_set;
        public object content_type;
        public object cookies;
        public object headers;
        public object keep_alive;
        public object output_stream;
        public object version;
        public object location;
        public object status_code;
        public object status_description;
        public object chunked;
        public object context;
        public object HeadersSent;
        public object headers_lock;
        public object force_close_chunked;
        public object tspecials;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75BF940
        public void get_ForceCloseChunked(){} // RVA: 0x11319D0
        public void get_ContentEncoding(){} // RVA: 0x75BDBE0
        public void set_ContentLength64(){} // RVA: 0x75BDC60
        public void set_ContentType(){} // RVA: 0x75BDDA0
        public void get_Headers(){} // RVA: 0xBC1B30
        public void get_OutputStream(){} // RVA: 0x75BDEC0
        public void get_SendChunked(){} // RVA: 0x1165710
        public void set_SendChunked(){} // RVA: 0x75BDF50
        public void set_StatusCode(){} // RVA: 0x75BE020
        public void System.IDisposable.Dispose(){} // RVA: 0x75BE170
        public void Close(){} // RVA: 0x75BE220
        public void SendHeaders(){} // RVA: 0x75BE300
        public void FormatHeaders(){} // RVA: 0x75BF030
        public void CookieToClientString(){} // RVA: 0x75BF2C0
        public void QuotedString(){} // RVA: 0x75BF5E0
        public void IsToken(){} // RVA: 0x75BF780
        public void .cctor(){} // RVA: 0x75BF890
    }

    public class HttpRequestCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x75BF970
    }

    public class HttpStatusDescription : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7728870
    }

    public class HttpStreamAsyncResult : Object
    {
        public object locker;
        public object handle;
        public object completed;
        public object Buffer;
        public object Offset;
        public object Count;
        public object Callback;
        public object State;
        public object SynchRead;
        public object Error;

        // ── Methods ──
        public void Complete(){} // RVA: 0x75BFA30
        public void get_AsyncState(){} // RVA: 0xBC1B30
        public void get_AsyncWaitHandle(){} // RVA: 0x75BFBA0
        public void get_CompletedSynchronously(){} // RVA: 0x75BFD80
        public void get_IsCompleted(){} // RVA: 0x75BFD90
        public void .ctor(){} // RVA: 0x75BFEA0
    }

    public class HttpValidationHelpers : Object
    {
        public object s_httpTrimCharacters;

        // ── Methods ──
        public void IsInvalidMethodOrHeaderString(){} // RVA: 0x77291A0
        public void .cctor(){} // RVA: 0x7729300
    }

    public class HttpVersion : Object
    {
        public object Unknown;
        public object Version10;
        public object Version11;
        public object Version20;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x772B670
    }

    public class HttpWebRequest : WebRequest
    {
        public object requestUri;
        public object actualUri;
        public object hostChanged;
        public object allowAutoRedirect;
        public object allowBuffering;
        public object allowReadStreamBuffering;
        public object certificates;
        public object connectionGroup;
        public object haveContentLength;
        public object contentLength;
        public object continueDelegate;
        public object cookieContainer;
        public object credentials;
        public object haveResponse;
        public object requestSent;
        public object webHeaders;
        public object keepAlive;
        public object maxAutoRedirect;
        public object mediaType;
        public object method;
        public object initialMethod;
        public object pipelined;
        public object preAuthenticate;
        public object usedPreAuth;
        public object version;
        public object force_version;
        public object actualVersion;
        public object proxy;
        public object sendChunked;
        public object servicePoint;
        public object timeout;
        public object continueTimeout;
        public object writeStream;
        public object webResponse;
        public object responseTask;
        public object currentOperation;
        public object aborted;
        public object gotRequestStream;
        public object redirects;
        public object expectContinue;
        public object getResponseCalled;
        public object locker;
        public object finished_reading;
        public object auto_decomp;
        public object maxResponseHeadersLength;
        public object defaultMaxResponseHeadersLength;
        public object defaultMaximumErrorResponseLength;
        public object defaultCachePolicy;
        public object readWriteTimeout;
        public object tlsProvider;
        public object tlsSettings;
        public object certValidationCallback;
        public object hostHasPort;
        public object hostUri;
        public object auth_state;
        public object proxy_auth_state;
        public object ResendContentFactory;
        public object ID;
        public object _throwOnError;
        public object unsafe_auth_blah;
        public object _reuseConnection;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x75BFF30
        public void .ctor(){} // RVA: 0x75C66E0
        public void ResetAuthorization(){} // RVA: 0x75C0890
        public void get_Address(){} // RVA: 0xBC1B30
        public void set_AllowAutoRedirect(){} // RVA: 0x1C58C90
        public void get_AllowWriteStreamBuffering(){} // RVA: 0x1FA9920
        public void set_AllowWriteStreamBuffering(){} // RVA: 0x1FA9F50
        public void get_AutomaticDecompression(){} // RVA: 0x75C0A30
        public void set_AutomaticDecompression(){} // RVA: 0x75C0A40
        public void get_InternalAllowBuffering(){} // RVA: 0x75C0AB0
        public void get_MethodWithBuffer(){} // RVA: 0x75C0AC0
        public void get_TlsProvider(){} // RVA: 0xBAE8F0
        public void get_TlsSettings(){} // RVA: 0xBAE960
        public void get_ClientCertificates(){} // RVA: 0x75C0CB0
        public void set_ConnectionGroupName(){} // RVA: 0xC0FFD0
        public void get_ContentLength(){} // RVA: 0xBBFF90
        public void set_ContentLength(){} // RVA: 0x75C0D60
        public void set_InternalContentLength(){} // RVA: 0x278E9A0
        public void get_ThrowOnError(){} // RVA: 0x6CEA7D0
        public void set_ThrowOnError(){} // RVA: 0x75C0E30
        public void set_CookieContainer(){} // RVA: 0xCD4740
        public void get_Credentials(){} // RVA: 0xCD48B0
        public void set_Credentials(){} // RVA: 0xCD3600
        public void get_DefaultMaximumErrorResponseLength(){} // RVA: 0x75C0E40
        public void get_Headers(){} // RVA: 0x1069350
        public void get_Host(){} // RVA: 0x75C0EA0
        public void set_Host(){} // RVA: 0x75C1030
        public void TryGetHostUri(){} // RVA: 0x75C12E0
        public void get_KeepAlive(){} // RVA: 0x11319D0
        public void set_KeepAlive(){} // RVA: 0x112ECB0
        public void set_MaximumAutomaticRedirections(){} // RVA: 0x75C13C0
        public void get_DefaultMaximumResponseHeadersLength(){} // RVA: 0x75C1450
        public void get_ReadWriteTimeout(){} // RVA: 0x100D890
        public void get_Method(){} // RVA: 0x12EB090
        public void set_Method(){} // RVA: 0x75C14B0
        public void set_PreAuthenticate(){} // RVA: 0x421A230
        public void get_ProtocolVersion(){} // RVA: 0xBAE420
        public void set_ProtocolVersion(){} // RVA: 0x75C1A40
        public void get_Proxy(){} // RVA: 0x135D730
        public void set_Proxy(){} // RVA: 0x75C1C10
        public void get_RequestUri(){} // RVA: 0xD05CA0
        public void get_SendChunked(){} // RVA: 0xC77E50
        public void set_SendChunked(){} // RVA: 0x75C1D50
        public void get_ServicePoint(){} // RVA: 0x75C1DC0
        public void get_ServicePointNoLock(){} // RVA: 0xBC5BA0
        public void get_Timeout(){} // RVA: 0x255B930
        public void set_Timeout(){} // RVA: 0x75C1DD0
        public void get_TransferEncoding(){} // RVA: 0x75C1E40
        public void get_UseDefaultCredentials(){} // RVA: 0x75C1EA0
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x6CEA7E0
        public void get_ExpectContinue(){} // RVA: 0x75C1F20
        public void set_ExpectContinue(){} // RVA: 0x75C1F30
        public void get_AuthUri(){} // RVA: 0xBC1B30
        public void get_ProxyQuery(){} // RVA: 0x75C1F40
        public void get_ServerCertValidationCallback(){} // RVA: 0x12CDBF0
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x75C1F70
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x75C1F90
        public void GetServicePoint(){} // RVA: 0x75C20E0
        public void SendRequest(){} // RVA: 0x75C22C0
        public void MyGetRequestStreamAsync(){} // RVA: 0x75C2660
        public void BeginGetRequestStream(){} // RVA: 0x75C2D40
        public void EndGetRequestStream(){} // RVA: 0x75C2E00
        public void GetRequestStreamAsync(){} // RVA: 0x75C2ED0
        public void RunWithTimeout(){} // RVA: 0x87C540
        public void RunWithTimeoutWorker(){} // RVA: 0x88DC70
        public void MyGetResponseAsync(){} // RVA: 0x75C2F60
        public void GetResponseFromData(){} // RVA: 0x75C3150
        public void FlattenException(){} // RVA: 0x75C33B0
        public void GetWebException(){} // RVA: 0x75C3540
        public void CreateRequestAbortedException(){} // RVA: 0x75C3720
        public void BeginGetResponse(){} // RVA: 0x75C37E0
        public void EndGetResponse(){} // RVA: 0x75C3A00
        public void GetResponse(){} // RVA: 0x75C3AD0
        public void set_FinishedReading(){} // RVA: 0x75C3B90
        public void get_Aborted(){} // RVA: 0x30E55F0
        public void Abort(){} // RVA: 0x75C3BA0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x75C3D80
        public void GetObjectData(){} // RVA: 0x75C3DC0
        public void CheckRequestStarted(){} // RVA: 0x75C3E00
        public void DoContinueDelegate(){} // RVA: 0x75C3E70
        public void RewriteRedirectToGet(){} // RVA: 0x75C3E90
        public void Redirect(){} // RVA: 0x75C3FA0
        public void GetHeaders(){} // RVA: 0x75C4730
        public void DoPreAuthenticate(){} // RVA: 0x75C52D0
        public void GetRequestHeaders(){} // RVA: 0x75C54F0
        public void HandleNtlmAuth(){} // RVA: 0x75C5A10
        public void CheckAuthorization(){} // RVA: 0x75C5CD0
        public void GetRewriteHandler(){} // RVA: 0x75C5D00
        public void CheckFinalStatus(){} // RVA: 0x75C5F70
        public void <RunWithTimeout>b__242_0(){} // RVA: 0x87D280
        public void <GetRewriteHandler>b__271_0(){} // RVA: 0x75C6540
    }

    public class HttpWebResponse : WebResponse
    {
        public object uri;
        public object webHeaders;
        public object cookieCollection;
        public object method;
        public object version;
        public object statusCode;
        public object statusDescription;
        public object contentLength;
        public object contentType;
        public object cookie_container;
        public object disposed;
        public object stream;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75CA550
        public void get_Headers(){} // RVA: 0xB70160
        public void get_ResponseUri(){} // RVA: 0x75CABB0
        public void get_StatusCode(){} // RVA: 0xBE5890
        public void get_StatusDescription(){} // RVA: 0x75CABD0
        public void GetResponseStream(){} // RVA: 0x75CABF0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x758D090
        public void GetObjectData(){} // RVA: 0x75CAD70
        public void Close(){} // RVA: 0x75CBB50
        public void System.IDisposable.Dispose(){} // RVA: 0x68D3A30
        public void Dispose(){} // RVA: 0x75CBB90
        public void CheckDisposed(){} // RVA: 0x75CBBA0
        public void FillCookies(){} // RVA: 0x75CBC30
    }

}