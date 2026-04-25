// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 21
// Methods: 269

namespace ThirdParty.DotNet.System.Net
{
    public class HeaderInfo : Object
    {
        public bool IsRequestRestricted; // 0x10
        public bool IsResponseRestricted; // 0x11
        public System.Net.HeaderParser Parser; // 0x18
        public string HeaderName; // 0x20
        public bool AllowMultiValues; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92C1310
    }

    public class HeaderInfoTable : Object
    {
        public System.Collections.Hashtable Item;
        public System.Net.HeaderInfo UnknownHeaderInfo; // 0x8
        public System.Net.HeaderParser SingleParser; // 0x10
        public System.Net.HeaderParser MultiParser; // 0x18

        // ── Methods ──
        public void ParseSingleValue(){} // RVA: 0x7FFAC92C13E0
        public void ParseMultiValue(){} // RVA: 0x7FFAC92C1450
        public void .cctor(){} // RVA: 0x7FFAC92C1710
        public void get_Item(){} // RVA: 0x7FFAC92C38F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HeaderParser : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6EA1B30
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class HeaderVariantInfo : ValueType
    {
        public string Name; // 0x10
        public 0x6B13BD58 Variant; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC335C3C0
        public void get_Name(){} // RVA: 0x7FFAC3AD9F60
        public void get_Variant(){} // RVA: 0x7FFAC49C7500
    }

    public class HttpConnection : Object
    {
        public System.AsyncCallback Reuses;
        public int LocalEndPoint;
        public System.Net.Sockets.Socket IsSecure; // 0x10
        public System.IO.Stream Prefix; // 0x18
        public System.Net.EndPointListener epl; // 0x20
        public System.IO.MemoryStream ms; // 0x28
        public byte[] buffer; // 0x30
        public System.Net.HttpListenerContext context; // 0x38
        public System.Text.StringBuilder current_line; // 0x40
        public System.Net.ListenerPrefix prefix; // 0x48
        public System.Net.RequestStream i_stream; // 0x50
        public System.Net.ResponseStream o_stream; // 0x58
        public bool chunked; // 0x60
        public int reuses; // 0x64
        public bool context_bound; // 0x68
        public bool secure; // 0x69
        public System.Security.Cryptography.X509Certificates.X509Certificate cert; // 0x70
        public int s_timeout; // 0x78
        public System.Threading.Timer timer; // 0x80
        public System.Net.IPEndPoint local_ep; // 0x88
        public System.Net.HttpListener last_listener; // 0x90
        public int[] client_cert_errors; // 0x98
        public System.Security.Cryptography.X509Certificates.X509Certificate2 client_cert; // 0xA0
        public System.Net.Security.SslStream ssl_stream; // 0xA8
        public 0x6B13CE30 input_state; // 0xB0
        public 0x6B13CE88 line_state; // 0xB4
        public int position; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92E8020
        public void Init(){} // RVA: 0x7FFAC92E84D0
        public void get_Reuses(){} // RVA: 0x7FFAC3138CA0
        public void get_LocalEndPoint(){} // RVA: 0x7FFAC92E8740
        public void get_IsSecure(){} // RVA: 0x7FFAC4670BD0
        public void set_Prefix(){} // RVA: 0x7FFAC2F9C740
        public void OnTimeout(){} // RVA: 0x7FFAC92E8880
        public void BeginReadRequest(){} // RVA: 0x7FFAC92E88D0
        public void GetRequestStream(){} // RVA: 0x7FFAC92E8C00
        public void GetResponseStream(){} // RVA: 0x7FFAC92E9100
        public void OnRead(){} // RVA: 0x7FFAC92E9240
        public void OnReadInternal(){} // RVA: 0x7FFAC92E92E0
        public void RemoveConnection(){} // RVA: 0x7FFAC92E9820
        public void ProcessInput(){} // RVA: 0x7FFAC92E9880
        public void ReadLine(){} // RVA: 0x7FFAC92E9B60
        public void SendError(){} // RVA: 0x7FFAC92EA040 | overloaded x2
        public void Unbind(){} // RVA: 0x7FFAC92EA070
        public void CloseSocket(){} // RVA: 0x7FFAC92EA0C0
        public void Close(){} // RVA: 0x7FFAC92EA190
        public void .cctor(){} // RVA: 0x7FFAC92EA630
        public void <.ctor>b__24_0(){} // RVA: 0x7FFAC92EA710
    }

    public class HttpContinueDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC307D2A0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class HttpListener : Object
    {
        public Mono.Security.Interface.MonoTlsProvider AuthenticationSchemes; // 0x10
        public Mono.Security.Interface.MonoTlsSettings AuthenticationSchemeSelectorDelegate; // 0x18
        public System.Security.Cryptography.X509Certificates.X509Certificate IgnoreWriteExceptions; // 0x20
        public 0x6B13A7B0 IsListening; // 0x28
        public System.Net.HttpListenerPrefixCollection Prefixes; // 0x30
        public System.Net.AuthenticationSchemeSelector Realm; // 0x38
        public string realm; // 0x40
        public bool ignore_write_exceptions; // 0x48
        public bool unsafe_ntlm_auth; // 0x49
        public bool listening; // 0x4A
        public bool disposed; // 0x4B
        public object _internalLock; // 0x50
        public System.Collections.Hashtable registry; // 0x58
        public System.Collections.ArrayList ctx_queue; // 0x60
        public System.Collections.ArrayList wait_queue; // 0x68
        public System.Collections.Hashtable connections; // 0x70
        public System.Net.ServiceNameStore defaultServiceNames; // 0x78
        public System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy extendedProtectionPolicy; // 0x80
        public ExtendedProtectionSelector extendedProtectionSelectorDelegate; // 0x88

        // ── Methods ──
        public void LoadCertificateAndKey(){} // RVA: 0x7FFAC92EA8C0
        public void CreateSslStream(){} // RVA: 0x7FFAC92EAE30
        public void .ctor(){} // RVA: 0x7FFAC92EB130
        public void get_AuthenticationSchemes(){} // RVA: 0x7FFAC32EC4C0
        public void get_AuthenticationSchemeSelectorDelegate(){} // RVA: 0x7FFAC31D0140
        public void get_IgnoreWriteExceptions(){} // RVA: 0x7FFAC2FD8D30
        public void get_IsListening(){} // RVA: 0x7FFAC41656F0
        public void get_Prefixes(){} // RVA: 0x7FFAC92EB700
        public void get_Realm(){} // RVA: 0x7FFAC2F9E740
        public void Close(){} // RVA: 0x7FFAC92EB760 | overloaded x2
        public void Cleanup(){} // RVA: 0x7FFAC92EB7E0
        public void BeginGetContext(){} // RVA: 0x7FFAC92EC400
        public void EndGetContext(){} // RVA: 0x7FFAC92EC9C0
        public void SelectAuthenticationScheme(){} // RVA: 0x7FFAC92ECEA0
        public void Start(){} // RVA: 0x7FFAC92ECEE0
        public void Stop(){} // RVA: 0x7FFAC92ECF50
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC92ECF80
        public void CheckDisposed(){} // RVA: 0x7FFAC92ECFB0
        public void GetContextFromQueue(){} // RVA: 0x7FFAC92ED040
        public void RegisterContext(){} // RVA: 0x7FFAC92ED110
        public void UnregisterContext(){} // RVA: 0x7FFAC92ED690
        public void AddConnection(){} // RVA: 0x7FFAC92ED9B0
        public void RemoveConnection(){} // RVA: 0x7FFAC92ED9E0
    }

    public class HttpListenerBasicIdentity : GenericIdentity
    {
        public string password; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92EDA10
    }

    public class HttpListenerContext : Object
    {
        public System.Net.HttpListenerRequest ErrorStatus; // 0x10
        public System.Net.HttpListenerResponse ErrorMessage; // 0x18
        public System.Security.Principal.IPrincipal HaveError; // 0x20
        public System.Net.HttpConnection Connection; // 0x28
        public string Request; // 0x30
        public int Response; // 0x38
        public System.Net.HttpListener Listener; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92EDAD0
        public void get_ErrorStatus(){} // RVA: 0x7FFAC358A870
        public void set_ErrorStatus(){} // RVA: 0x7FFAC3588350
        public void get_ErrorMessage(){} // RVA: 0x7FFAC31D95E0
        public void set_ErrorMessage(){} // RVA: 0x7FFAC2F4F890
        public void get_HaveError(){} // RVA: 0x7FFAC781E0A0
        public void get_Connection(){} // RVA: 0x7FFAC2F4F130
        public void get_Request(){} // RVA: 0x7FFAC2F3C380
        public void get_Response(){} // RVA: 0x7FFAC2F247C0
        public void ParseAuthentication(){} // RVA: 0x7FFAC92EDDF0
        public void ParseBasicAuthentication(){} // RVA: 0x7FFAC92EDF40
    }

    public class HttpListenerException : Win32Exception
    {
        public object ErrorCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92B3550 | overloaded x3
        public void get_ErrorCode(){} // RVA: 0x7FFAC3220660
    }

    public class HttpListenerPrefixCollection : Object
    {
        public System.Collections.Generic.List`1<string> Count; // 0x10
        public System.Net.HttpListener IsReadOnly; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92EE210
        public void get_Count(){} // RVA: 0x7FFAC92EE330
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void Add(){} // RVA: 0x7FFAC92EE380
        public void Clear(){} // RVA: 0x7FFAC92EE4B0
        public void Contains(){} // RVA: 0x7FFAC92EE570
        public void CopyTo(){} // RVA: 0x7FFAC92EE5E0
        public void GetEnumerator(){} // RVA: 0x7FFAC92EE670
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC92EE760
        public void Remove(){} // RVA: 0x7FFAC92EE850
    }

    public class HttpListenerRequest : Object
    {
        public string[] HasEntityBody; // 0x10
        public System.Text.Encoding Headers; // 0x18
        public long InputStream; // 0x20
        public bool IsSecureConnection; // 0x28
        public System.Net.CookieCollection KeepAlive; // 0x30
        public System.Net.WebHeaderCollection LocalEndPoint; // 0x38
        public string ProtocolVersion; // 0x40
        public System.IO.Stream RawUrl; // 0x48
        public System.Version Url; // 0x50
        public System.Collections.Specialized.NameValueCollection UserHostAddress; // 0x58
        public string UserHostName; // 0x60
        public System.Uri url; // 0x68
        public System.Uri referrer; // 0x70
        public string[] user_languages; // 0x78
        public System.Net.HttpListenerContext context; // 0x80
        public bool is_chunked; // 0x88
        public bool ka_set; // 0x89
        public bool keep_alive; // 0x8A
        public GCCDelegate gcc_delegate; // 0x90
        public byte[] _100continue;
        public char[] separators; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92EE980
        public void SetRequestLine(){} // RVA: 0x7FFAC92EEB30
        public void CreateQueryString(){} // RVA: 0x7FFAC92EEFE0
        public void MaybeUri(){} // RVA: 0x7FFAC92EF3D0
        public void IsPredefinedScheme(){} // RVA: 0x7FFAC92EF470
        public void FinishInitialization(){} // RVA: 0x7FFAC92EF740
        public void Unquote(){} // RVA: 0x7FFAC92F04A0
        public void AddHeader(){} // RVA: 0x7FFAC92F0520
        public void FlushInput(){} // RVA: 0x7FFAC92F1170
        public void get_HasEntityBody(){} // RVA: 0x7FFAC92F1420
        public void get_Headers(){} // RVA: 0x7FFAC31D0140
        public void get_InputStream(){} // RVA: 0x7FFAC92F1440
        public void get_IsSecureConnection(){} // RVA: 0x7FFAC92F1550
        public void get_KeepAlive(){} // RVA: 0x7FFAC92F1580
        public void get_LocalEndPoint(){} // RVA: 0x7FFAC92F1890
        public void get_ProtocolVersion(){} // RVA: 0x7FFAC2FC20E0
        public void get_RawUrl(){} // RVA: 0x7FFAC2FBF370
        public void get_Url(){} // RVA: 0x7FFAC2F9CD50
        public void get_UserHostAddress(){} // RVA: 0x7FFAC92F19E0
        public void get_UserHostName(){} // RVA: 0x7FFAC92F1A20
        public void .cctor(){} // RVA: 0x7FFAC92F1A80
    }

    public class HttpListenerRequestUriBuilder : Object
    {
        public bool useCookedRequestUrl;
        public System.Text.Encoding utf8Encoding; // 0x8
        public System.Text.Encoding ansiEncoding; // 0x10
        public string rawUri; // 0x10
        public string cookedUriScheme; // 0x18
        public string cookedUriHost; // 0x20
        public string cookedUriPath; // 0x28
        public string cookedUriQuery; // 0x30
        public System.Text.StringBuilder requestUriString; // 0x38
        public System.Collections.Generic.List`1<byte> rawOctets; // 0x40
        public string rawPath; // 0x48
        public System.Uri requestUri; // 0x50

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC92B3610
        public void .ctor(){} // RVA: 0x7FFAC92B3870
        public void GetRequestUri(){} // RVA: 0x7FFAC92B3B50
        public void Build(){} // RVA: 0x7FFAC92B3CC0
        public void BuildRequestUriUsingCookedPath(){} // RVA: 0x7FFAC92B3DB0
        public void BuildRequestUriUsingRawPath(){} // RVA: 0x7FFAC92B4520 | overloaded x2
        public void GetEncoding(){} // RVA: 0x7FFAC92B4490
        public void ParseRawPath(){} // RVA: 0x7FFAC92B4860
        public void AppendUnicodeCodePointValuePercentEncoded(){} // RVA: 0x7FFAC92B4A20
        public void AddPercentEncodedOctetToRawOctetsList(){} // RVA: 0x7FFAC92B4E20
        public void EmptyDecodeAndAppendRawOctetsList(){} // RVA: 0x7FFAC92B5050
        public void AppendOctetsPercentEncoded(){} // RVA: 0x7FFAC92B5410
        public void GetOctetsAsString(){} // RVA: 0x7FFAC92B5780
        public void GetPath(){} // RVA: 0x7FFAC92B5A50
        public void AddSlashToAsteriskOnlyPath(){} // RVA: 0x7FFAC92B5DB0
        public void LogWarning(){} // RVA: 0x7FFAC2F21310
    }

    public class HttpListenerResponse : Object
    {
        public bool ForceCloseChunked; // 0x10
        public System.Text.Encoding ContentEncoding; // 0x18
        public long ContentLength64; // 0x20
        public bool ContentType; // 0x28
        public string Headers; // 0x30
        public System.Net.CookieCollection OutputStream; // 0x38
        public System.Net.WebHeaderCollection SendChunked; // 0x40
        public bool StatusCode; // 0x48
        public System.Net.ResponseStream output_stream; // 0x50
        public System.Version version; // 0x58
        public string location; // 0x60
        public int status_code; // 0x68
        public string status_description; // 0x70
        public bool chunked; // 0x78
        public System.Net.HttpListenerContext context; // 0x80
        public bool HeadersSent; // 0x88
        public object headers_lock; // 0x90
        public bool force_close_chunked; // 0x98
        public string tspecials;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92F1C20
        public void get_ForceCloseChunked(){} // RVA: 0x7FFAC339A7F0
        public void get_ContentEncoding(){} // RVA: 0x7FFAC92F1EA0
        public void set_ContentLength64(){} // RVA: 0x7FFAC92F1F20
        public void set_ContentType(){} // RVA: 0x7FFAC92F2060
        public void get_Headers(){} // RVA: 0x7FFAC2F9E740
        public void get_OutputStream(){} // RVA: 0x7FFAC92F2180
        public void get_SendChunked(){} // RVA: 0x7FFAC33CE5C0
        public void set_SendChunked(){} // RVA: 0x7FFAC92F2210
        public void set_StatusCode(){} // RVA: 0x7FFAC92F22E0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC92F2430
        public void Close(){} // RVA: 0x7FFAC92F24E0 | overloaded x3
        public void SendHeaders(){} // RVA: 0x7FFAC92F25C0
        public void FormatHeaders(){} // RVA: 0x7FFAC92F3300
        public void CookieToClientString(){} // RVA: 0x7FFAC92F3590
        public void QuotedString(){} // RVA: 0x7FFAC92F38C0
        public void IsToken(){} // RVA: 0x7FFAC92F3A60
        public void .cctor(){} // RVA: 0x7FFAC92F3B70
    }

    public class HttpRequestCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC92F3C20
    }

    public class HttpStatusDescription : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC94626F0 | overloaded x2
    }

    public class HttpStreamAsyncResult : Object
    {
        public object AsyncState; // 0x10
        public System.Threading.ManualResetEvent AsyncWaitHandle; // 0x18
        public bool CompletedSynchronously; // 0x20
        public byte[] IsCompleted; // 0x28
        public int Offset; // 0x30
        public int Count; // 0x34
        public System.AsyncCallback Callback; // 0x38
        public object State; // 0x40
        public int SynchRead; // 0x48
        public System.Exception Error; // 0x50

        // ── Methods ──
        public void Complete(){} // RVA: 0x7FFAC92F3CE0 | overloaded x2
        public void get_AsyncState(){} // RVA: 0x7FFAC2F9E740
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFAC92F3E90
        public void get_CompletedSynchronously(){} // RVA: 0x7FFAC92F40A0
        public void get_IsCompleted(){} // RVA: 0x7FFAC92F40B0
        public void .ctor(){} // RVA: 0x7FFAC92F41F0
    }

    public class HttpValidationHelpers : Object
    {
        public char[] s_httpTrimCharacters;

        // ── Methods ──
        public void IsInvalidMethodOrHeaderString(){} // RVA: 0x7FFAC9463000
        public void .cctor(){} // RVA: 0x7FFAC9463150
    }

    public class HttpVersion : Object
    {
        public System.Version Unknown;
        public System.Version Version10; // 0x8
        public System.Version Version11; // 0x10
        public System.Version Version20; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC94654C0
    }

    public class HttpWebRequest : WebRequest
    {
        public System.Uri Address; // 0x38
        public System.Uri AllowAutoRedirect; // 0x40
        public bool AllowWriteStreamBuffering; // 0x48
        public bool AutomaticDecompression; // 0x49
        public bool InternalAllowBuffering; // 0x4A
        public bool MethodWithBuffer; // 0x4B
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection TlsProvider; // 0x50
        public string TlsSettings; // 0x58
        public bool ClientCertificates; // 0x60
        public long ConnectionGroupName; // 0x68
        public System.Net.HttpContinueDelegate ContentLength; // 0x70
        public System.Net.CookieContainer InternalContentLength; // 0x78
        public System.Net.ICredentials ThrowOnError; // 0x80
        public bool CookieContainer; // 0x88
        public bool Credentials; // 0x89
        public System.Net.WebHeaderCollection DefaultMaximumErrorResponseLength; // 0x90
        public bool Headers; // 0x98
        public int Host; // 0x9C
        public string KeepAlive; // 0xA0
        public string MaximumAutomaticRedirections; // 0xA8
        public string DefaultMaximumResponseHeadersLength; // 0xB0
        public bool ReadWriteTimeout; // 0xB8
        public bool Method; // 0xB9
        public bool PreAuthenticate; // 0xBA
        public System.Version ProtocolVersion; // 0xC0
        public bool Proxy; // 0xC8
        public System.Version RequestUri; // 0xD0
        public System.Net.IWebProxy SendChunked; // 0xD8
        public bool ServicePoint; // 0xE0
        public System.Net.ServicePoint ServicePointNoLock; // 0xE8
        public int Timeout; // 0xF0
        public int TransferEncoding; // 0xF4
        public System.Net.WebRequestStream UseDefaultCredentials; // 0xF8
        public System.Net.HttpWebResponse UnsafeAuthenticatedConnectionSharing; // 0x100
        public System.Net.WebCompletionSource ExpectContinue; // 0x108
        public System.Net.WebOperation AuthUri; // 0x110
        public int ProxyQuery; // 0x118
        public bool ServerCertValidationCallback; // 0x11C
        public int ServerCertificateValidationCallback; // 0x120
        public bool FinishedReading; // 0x124
        public bool Aborted; // 0x125
        public object locker; // 0x128
        public bool finished_reading; // 0x130
        public 0x6B13CA68 auto_decomp; // 0x134
        public int maxResponseHeadersLength; // 0x138
        public int defaultMaxResponseHeadersLength;
        public int defaultMaximumErrorResponseLength; // 0x4
        public System.Net.Cache.RequestCachePolicy defaultCachePolicy; // 0x8
        public int readWriteTimeout; // 0x13C
        public Mono.Net.Security.MobileTlsProvider tlsProvider; // 0x140
        public Mono.Security.Interface.MonoTlsSettings tlsSettings; // 0x148
        public System.Net.ServerCertValidationCallback certValidationCallback; // 0x150
        public bool hostHasPort; // 0x158
        public System.Uri hostUri; // 0x160
        public AuthorizationState auth_state; // 0x168
        public AuthorizationState proxy_auth_state; // 0x178
        public System.Func`2<System.IO.Stream,System.Threading.Tasks.Task> ResendContentFactory; // 0x188
        public int ID; // 0x190
        public bool <ThrowOnError>k__BackingField; // 0x194
        public bool unsafe_auth_blah; // 0x195
        public bool <ReuseConnection>k__BackingField; // 0x196

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC92F4280
        public void .ctor(){} // RVA: 0x7FFAC92FABC0 | overloaded x4
        public void ResetAuthorization(){} // RVA: 0x7FFAC92F4C80
        public void get_Address(){} // RVA: 0x7FFAC2F9E740
        public void set_AllowAutoRedirect(){} // RVA: 0x7FFAC3E0F360
        public void get_AllowWriteStreamBuffering(){} // RVA: 0x7FFAC41656F0
        public void set_AllowWriteStreamBuffering(){} // RVA: 0x7FFAC4164B40
        public void get_AutomaticDecompression(){} // RVA: 0x7FFAC92F4E20
        public void set_AutomaticDecompression(){} // RVA: 0x7FFAC92F4E30
        public void get_InternalAllowBuffering(){} // RVA: 0x7FFAC92F4EA0
        public void get_MethodWithBuffer(){} // RVA: 0x7FFAC92F4EB0
        public void get_TlsProvider(){} // RVA: 0x7FFAC2F8C5F0
        public void get_TlsSettings(){} // RVA: 0x7FFAC2F8C660
        public void get_ClientCertificates(){} // RVA: 0x7FFAC92F50A0
        public void set_ConnectionGroupName(){} // RVA: 0x7FFAC2FE9510
        public void get_ContentLength(){} // RVA: 0x7FFAC2F9CD50
        public void set_ContentLength(){} // RVA: 0x7FFAC92F5150
        public void set_InternalContentLength(){} // RVA: 0x7FFAC4A2BA80
        public void get_ThrowOnError(){} // RVA: 0x7FFAC8A144B0
        public void set_ThrowOnError(){} // RVA: 0x7FFAC92F5220
        public void set_CookieContainer(){} // RVA: 0x7FFAC30E06F0
        public void get_Credentials(){} // RVA: 0x7FFAC32EF410
        public void set_Credentials(){} // RVA: 0x7FFAC34D4AA0
        public void get_DefaultMaximumErrorResponseLength(){} // RVA: 0x7FFAC92F5230
        public void get_Headers(){} // RVA: 0x7FFAC32EF640
        public void get_Host(){} // RVA: 0x7FFAC92F5290
        public void set_Host(){} // RVA: 0x7FFAC92F5420
        public void TryGetHostUri(){} // RVA: 0x7FFAC92F56D0
        public void get_KeepAlive(){} // RVA: 0x7FFAC339A7F0
        public void set_KeepAlive(){} // RVA: 0x7FFAC339FA20
        public void set_MaximumAutomaticRedirections(){} // RVA: 0x7FFAC92F57B0
        public void get_DefaultMaximumResponseHeadersLength(){} // RVA: 0x7FFAC92F5840
        public void get_ReadWriteTimeout(){} // RVA: 0x7FFAC88C7230
        public void get_Method(){} // RVA: 0x7FFAC354B1A0
        public void set_Method(){} // RVA: 0x7FFAC92F58A0
        public void set_PreAuthenticate(){} // RVA: 0x7FFAC623E960
        public void get_ProtocolVersion(){} // RVA: 0x7FFAC2F8C120
        public void set_ProtocolVersion(){} // RVA: 0x7FFAC92F5E20
        public void get_Proxy(){} // RVA: 0x7FFAC3540F70
        public void set_Proxy(){} // RVA: 0x7FFAC92F5FE0
        public void get_RequestUri(){} // RVA: 0x7FFAC31D0140
        public void get_SendChunked(){} // RVA: 0x7FFAC304CF80
        public void set_SendChunked(){} // RVA: 0x7FFAC92F6120
        public void get_ServicePoint(){} // RVA: 0x7FFAC92F6190
        public void get_ServicePointNoLock(){} // RVA: 0x7FFAC2FA2970
        public void get_Timeout(){} // RVA: 0x7FFAC60855D0
        public void set_Timeout(){} // RVA: 0x7FFAC92F61A0
        public void get_TransferEncoding(){} // RVA: 0x7FFAC92F6210
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFAC92F6270
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7FFAC8A144C0
        public void get_ExpectContinue(){} // RVA: 0x7FFAC92F62F0
        public void set_ExpectContinue(){} // RVA: 0x7FFAC92F6300
        public void get_AuthUri(){} // RVA: 0x7FFAC2F9E740
        public void get_ProxyQuery(){} // RVA: 0x7FFAC92F6310
        public void get_ServerCertValidationCallback(){} // RVA: 0x7FFAC354DFA0
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7FFAC92F6340
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7FFAC92F6360
        public void GetServicePoint(){} // RVA: 0x7FFAC92F64B0
        public void SendRequest(){} // RVA: 0x7FFAC92F66D0
        public void MyGetRequestStreamAsync(){} // RVA: 0x7FFAC92F6A90
        public void BeginGetRequestStream(){} // RVA: 0x7FFAC92F71A0
        public void EndGetRequestStream(){} // RVA: 0x7FFAC92F7260
        public void GetRequestStreamAsync(){} // RVA: 0x7FFAC92F7330
        public void RunWithTimeout(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void RunWithTimeoutWorker(){} // RVA: 0x7FFAC2C6A4E0
        public void MyGetResponseAsync(){} // RVA: 0x7FFAC92F73C0
        public void GetResponseFromData(){} // RVA: 0x7FFAC92F75B0
        public void FlattenException(){} // RVA: 0x7FFAC92F7810
        public void GetWebException(){} // RVA: 0x7FFAC92F79B0 | overloaded x2
        public void CreateRequestAbortedException(){} // RVA: 0x7FFAC92F7BA0
        public void BeginGetResponse(){} // RVA: 0x7FFAC92F7C60
        public void EndGetResponse(){} // RVA: 0x7FFAC92F7E80
        public void GetResponse(){} // RVA: 0x7FFAC92F7F50
        public void set_FinishedReading(){} // RVA: 0x7FFAC92F8010
        public void get_Aborted(){} // RVA: 0x7FFAC51471A0
        public void Abort(){} // RVA: 0x7FFAC92F8020
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC92F8200
        public void GetObjectData(){} // RVA: 0x7FFAC92F8240
        public void CheckRequestStarted(){} // RVA: 0x7FFAC92F8280
        public void DoContinueDelegate(){} // RVA: 0x7FFAC92F82F0
        public void RewriteRedirectToGet(){} // RVA: 0x7FFAC92F8310
        public void Redirect(){} // RVA: 0x7FFAC92F8420
        public void GetHeaders(){} // RVA: 0x7FFAC92F8BC0
        public void DoPreAuthenticate(){} // RVA: 0x7FFAC92F9760
        public void GetRequestHeaders(){} // RVA: 0x7FFAC92F9990
        public void HandleNtlmAuth(){} // RVA: 0x7FFAC92F9EE0
        public void CheckAuthorization(){} // RVA: 0x7FFAC92FA1A0
        public void GetRewriteHandler(){} // RVA: 0x7FFAC92FA1D0
        public void CheckFinalStatus(){} // RVA: 0x7FFAC92FA440
        public void <RunWithTimeout>b__242_0(){} // RVA: 0x7FFAC2C59D00
        public void <GetRewriteHandler>b__271_0(){} // RVA: 0x7FFAC92FAA20
    }

    public class HttpWebResponse : WebResponse
    {
        public System.Uri Headers; // 0x20
        public System.Net.WebHeaderCollection ResponseUri; // 0x28
        public System.Net.CookieCollection StatusCode; // 0x30
        public string StatusDescription; // 0x38
        public System.Version version; // 0x40
        public 0x6B139DB8 statusCode; // 0x48
        public string statusDescription; // 0x50
        public long contentLength; // 0x58
        public string contentType; // 0x60
        public System.Net.CookieContainer cookie_container; // 0x68
        public bool disposed; // 0x70
        public System.IO.Stream stream; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92FEB80 | overloaded x4
        public void get_Headers(){} // RVA: 0x7FFAC2F4F130
        public void get_ResponseUri(){} // RVA: 0x7FFAC92FF270
        public void get_StatusCode(){} // RVA: 0x7FFAC2FC20C0
        public void get_StatusDescription(){} // RVA: 0x7FFAC92FF290
        public void GetResponseStream(){} // RVA: 0x7FFAC92FF2B0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC92BF840
        public void GetObjectData(){} // RVA: 0x7FFAC92FF430
        public void Close(){} // RVA: 0x7FFAC9300230
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC85F19B0
        public void Dispose(){} // RVA: 0x7FFAC9300270
        public void CheckDisposed(){} // RVA: 0x7FFAC9300280
        public void FillCookies(){} // RVA: 0x7FFAC9300310
    }

}