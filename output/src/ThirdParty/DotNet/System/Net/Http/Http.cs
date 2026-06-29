// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Http
// Classes: 18
// Methods: 130

namespace ThirdParty.DotNet.System.Net.Http
{
    public class ByteArrayContent : HttpContent
    {
        public object content;
        public object offset;
        public object count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7268060
        public void CreateContentReadStreamAsync(){} // RVA: 0x7268120
        public void SerializeToStreamAsync(){} // RVA: 0x72681F0
        public void TryComputeLength(){} // RVA: 0x7268230
    }

    public class DelegatingHandler : HttpMessageHandler
    {
        public object disposed;
        public object handler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7268240
        public void get_InnerHandler(){} // RVA: 0xB465B0
        public void set_InnerHandler(){} // RVA: 0x72682F0
        public void Dispose(){} // RVA: 0x72683A0
        public void SendAsync(){} // RVA: 0x72683D0
    }

    public class HttpClient : HttpMessageInvoker
    {
        public object TimeoutDefault;
        public object base_address;
        public object cts;
        public object disposed;
        public object headers;
        public object buffer_size;
        public object timeout;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x72684D0
        public void get_DefaultRequestHeaders(){} // RVA: 0x7268690
        public void get_MaxResponseContentBufferSize(){} // RVA: 0xBC1B30
        public void Dispose(){} // RVA: 0x7268780
        public void GetAsync(){} // RVA: 0x7268930
        public void SendAsync(){} // RVA: 0x7268AD0
        public void SendAsyncWorker(){} // RVA: 0x7268EE0
        public void .cctor(){} // RVA: 0x7269150
        public void <>n__0(){} // RVA: 0x7269200
    }

    public class HttpClientHandler : HttpMessageHandler
    {
        public object _delegatingHandler;
        public object _clientCertificateOptions;

        // ── Methods ──
        public void CreateDefaultHandler(){} // RVA: 0x72629E0
        public void .ctor(){} // RVA: 0x7262AE0
        public void Dispose(){} // RVA: 0x7262B40
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7262BA0
        public void ThrowForModifiedManagedSslOptionsIfStarted(){} // RVA: 0x7262BF0
        public void get_ClientCertificateOptions(){} // RVA: 0xE62D00
        public void set_ClientCertificateOptions(){} // RVA: 0x7262CD0
        public void get_ClientCertificates(){} // RVA: 0x7262F40
        public void set_AutomaticDecompression(){} // RVA: 0x7263080
        public void set_Proxy(){} // RVA: 0x72630E0
        public void SetWebRequestTimeout(){} // RVA: 0x7263140
        public void SendAsync(){} // RVA: 0x72631A0
        public void <set_ClientCertificateOptions>b__23_0(){} // RVA: 0x7263280
    }

    public class HttpContent : Object
    {
        public object buffer;
        public object stream;
        public object disposed;
        public object headers;

        // ── Methods ──
        public void get_Headers(){} // RVA: 0x7269BA0
        public void get_LoadedBufferLength(){} // RVA: 0x7269CF0
        public void CopyToAsync(){} // RVA: 0x7269E30
        public void CreateContentReadStreamAsync(){} // RVA: 0x7269ED0
        public void CreateFixedMemoryStream(){} // RVA: 0x726A060
        public void Dispose(){} // RVA: 0x726A0C0
        public void LoadIntoBufferAsync(){} // RVA: 0x726A100
        public void ReadAsStreamAsync(){} // RVA: 0x726A2C0
        public void ReadAsByteArrayAsync(){} // RVA: 0x726A450
        public void ReadAsStringAsync(){} // RVA: 0x726A5E0
        public void GetEncodingFromBuffer(){} // RVA: 0x726A770
        public void StartsWith(){} // RVA: 0x726A980
        public void SerializeToStreamAsync(){} // RVA: 0x87C5F0
        public void TryComputeLength(){} // RVA: 0x87D350
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HttpMessageHandler : Object
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0xB43310
        public void SendAsync(){} // RVA: 0x881FC0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HttpMessageInvoker : Object
    {
        public object handler;
        public object disposeHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x726C030
        public void Dispose(){} // RVA: 0x726C0E0
        public void SendAsync(){} // RVA: 0x7269200
    }

    public class HttpMethod : Object
    {
        public object delete_method;
        public object get_method;
        public object head_method;
        public object options_method;
        public object post_method;
        public object put_method;
        public object trace_method;
        public object method;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x726C130
        public void get_Get(){} // RVA: 0x726C200
        public void get_Method(){} // RVA: 0xB5DBF0
        public void get_Post(){} // RVA: 0x726C260
        public void op_Equality(){} // RVA: 0x726C2C0
        public void Equals(){} // RVA: 0x726C3D0
        public void GetHashCode(){} // RVA: 0x1269730
        public void ToString(){} // RVA: 0xB5DBF0
        public void .cctor(){} // RVA: 0x726C460
    }

    public class HttpRequestException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x726C9C0
    }

    public class HttpRequestMessage : Object
    {
        public object headers;
        public object method;
        public object version;
        public object uri;
        public object is_used;
        public object disposed;
        public object _content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x726CCA0
        public void get_Content(){} // RVA: 0xD05CA0
        public void set_Content(){} // RVA: 0xD09D70
        public void get_Headers(){} // RVA: 0x726CCD0
        public void get_Method(){} // RVA: 0xB465B0
        public void set_Method(){} // RVA: 0x726CDC0
        public void get_RequestUri(){} // RVA: 0xB70160
        public void set_RequestUri(){} // RVA: 0x726CEB0
        public void IsAllowedAbsoluteUri(){} // RVA: 0x726CFC0
        public void get_Version(){} // RVA: 0x726D260
        public void Dispose(){} // RVA: 0x726D2D0
        public void SetIsUsed(){} // RVA: 0x726D300
        public void ToString(){} // RVA: 0x726D310
    }

    public class HttpResponseMessage : Object
    {
        public object headers;
        public object reasonPhrase;
        public object statusCode;
        public object version;
        public object disposed;
        public object _content;
        public object _requestMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x726D670
        public void get_Content(){} // RVA: 0xD05CA0
        public void set_Content(){} // RVA: 0xD09D70
        public void get_Headers(){} // RVA: 0x726D6D0
        public void get_IsSuccessStatusCode(){} // RVA: 0x726D7C0
        public void get_ReasonPhrase(){} // RVA: 0x726D7E0
        public void set_ReasonPhrase(){} // RVA: 0xBA9BA0
        public void get_RequestMessage(){} // RVA: 0xBC1B30
        public void set_RequestMessage(){} // RVA: 0xB6A8C0
        public void get_StatusCode(){} // RVA: 0xFEAE90
        public void set_StatusCode(){} // RVA: 0x726D670
        public void get_Version(){} // RVA: 0x726D800
        public void Dispose(){} // RVA: 0x726D870
        public void EnsureSuccessStatusCode(){} // RVA: 0x726D8A0
        public void ToString(){} // RVA: 0x726D960
    }

    public class HttpUtilities : Object
    {
        // ── Methods ──
        public void IsSupportedSecureScheme(){} // RVA: 0x7262730
        public void IsSecureWebSocketScheme(){} // RVA: 0x72628E0
    }

    public class IMonoHttpClientHandler
    {
        // ── Methods ──
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x87D280
        public void get_SslOptions(){} // RVA: 0x87C0A0
        public void set_SslOptions(){} // RVA: 0x894320
        public void set_AutomaticDecompression(){} // RVA: 0x8944F0
        public void set_Proxy(){} // RVA: 0x894320
        public void SendAsync(){} // RVA: 0x881FC0
        public void SetWebRequestTimeout(){} // RVA: 0x8943F0
    }

    public class MonoWebRequestHandler : Object
    {
        public object groupCounter;
        public object allowAutoRedirect;
        public object automaticDecompression;
        public object cookieContainer;
        public object credentials;
        public object maxAutomaticRedirections;
        public object maxRequestContentBufferSize;
        public object preAuthenticate;
        public object proxy;
        public object useCookies;
        public object useProxy;
        public object sslOptions;
        public object allowPipelining;
        public object cachePolicy;
        public object authenticationLevel;
        public object continueTimeout;
        public object impersonationLevel;
        public object maxResponseHeadersLength;
        public object readWriteTimeout;
        public object serverCertificateValidationCallback;
        public object unsafeAuthenticatedConnectionSharing;
        public object sentRequest;
        public object connectionGroupName;
        public object timeout;
        public object disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7263500
        public void EnsureModifiability(){} // RVA: 0x72638C0
        public void set_AutomaticDecompression(){} // RVA: 0x7263930
        public void get_CookieContainer(){} // RVA: 0x72639A0
        public void get_MaxRequestContentBufferSize(){} // RVA: 0xD33E60
        public void set_Proxy(){} // RVA: 0x7263A50
        public void get_SupportsAutomaticDecompression(){} // RVA: 0xC2E4C0
        public void get_UseProxy(){} // RVA: 0x1C58C80
        public void get_SslOptions(){} // RVA: 0x7263B40
        public void set_SslOptions(){} // RVA: 0x7263BE0
        public void Dispose(){} // RVA: 0x7263CC0
        public void GetConnectionKeepAlive(){} // RVA: 0x7263D40
        public void CreateWebRequest(){} // RVA: 0x7263F10
        public void CreateResponseMessage(){} // RVA: 0x7264D70
        public void MethodHasBody(){} // RVA: 0x72652C0
        public void SendAsync(){} // RVA: 0x7265490
        public void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(){} // RVA: 0x72656D0
        public void <CreateWebRequest>b__96_0(){} // RVA: 0x7265730
    }

    public class PlatformHelper : Object
    {
        // ── Methods ──
        public void IsContentHeader(){} // RVA: 0x7267E00
        public void GetSingleHeaderString(){} // RVA: 0x7267F40
        public void CreateStreamContent(){} // RVA: 0x7267FA0
    }

    public class SerializableHttpContent : HttpContent
    {
        // ── Methods ──
        public void SerializeToStream(){} // RVA: 0xB43310
        public void ReadAsStream(){} // RVA: 0x6EBD380
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StreamContent : HttpContent
    {
        public object content;
        public object bufferSize;
        public object cancellationToken;
        public object startPosition;
        public object contentCopied;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x726DEA0
        public void CreateContentReadStreamAsync(){} // RVA: 0x726DF10
        public void Dispose(){} // RVA: 0x726DF80
        public void SerializeToStreamAsync(){} // RVA: 0x726DFE0
        public void TryComputeLength(){} // RVA: 0x726E0D0
    }

    public class StringContent : ByteArrayContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x726E170
        public void GetByteArray(){} // RVA: 0x726E5B0
    }

}