// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Http
// Classes: 18
// Methods: 153

namespace ThirdParty.DotNet.System.Net.Http
{
    public class ByteArrayContent : HttpContent
    {
        public byte[] content; // 0x30
        public int offset; // 0x38
        public int count; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F99920
        public void CreateContentReadStreamAsync(){} // RVA: 0x7FFAC8F999E0
        public void SerializeToStreamAsync(){} // RVA: 0x7FFAC8F99AB0
        public void TryComputeLength(){} // RVA: 0x7FFAC8F99AF0
    }

    public class DelegatingHandler : HttpMessageHandler
    {
        public bool InnerHandler; // 0x10
        public System.Net.Http.HttpMessageHandler handler; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F99B00 | overloaded x2
        public void get_InnerHandler(){} // RVA: 0x7FFAC2F247C0
        public void set_InnerHandler(){} // RVA: 0x7FFAC8F99BB0
        public void Dispose(){} // RVA: 0x7FFAC8F99C60
        public void SendAsync(){} // RVA: 0x7FFAC8F99C90
    }

    public class HttpClient : HttpMessageInvoker
    {
        public System.TimeSpan DefaultRequestHeaders;
        public System.Uri MaxResponseContentBufferSize; // 0x20
        public System.Threading.CancellationTokenSource cts; // 0x28
        public bool disposed; // 0x30
        public System.Net.Http.Headers.HttpRequestHeaders headers; // 0x38
        public long buffer_size; // 0x40
        public System.TimeSpan timeout; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F99D90 | overloaded x3
        public void get_DefaultRequestHeaders(){} // RVA: 0x7FFAC8F99F50
        public void get_MaxResponseContentBufferSize(){} // RVA: 0x7FFAC2F9E740
        public void Dispose(){} // RVA: 0x7FFAC8F9A040
        public void GetAsync(){} // RVA: 0x7FFAC8F9A1F0 | overloaded x2
        public void SendAsync(){} // RVA: 0x7FFAC8F9A390 | overloaded x3
        public void SendAsyncWorker(){} // RVA: 0x7FFAC8F9A7A0
        public void .cctor(){} // RVA: 0x7FFAC8F9AA10
        public void <>n__0(){} // RVA: 0x7FFAC8F9AAC0
    }

    public class HttpClientHandler : HttpMessageHandler
    {
        public System.Net.Http.IMonoHttpClientHandler SupportsAutomaticDecompression; // 0x10
        public 0x6B2A2738 ClientCertificateOptions; // 0x18

        // ── Methods ──
        public void CreateDefaultHandler(){} // RVA: 0x7FFAC8F94250
        public void .ctor(){} // RVA: 0x7FFAC8F94350 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC8F943B0
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7FFAC8F94410
        public void ThrowForModifiedManagedSslOptionsIfStarted(){} // RVA: 0x7FFAC8F94460
        public void get_ClientCertificateOptions(){} // RVA: 0x7FFAC3157800
        public void set_ClientCertificateOptions(){} // RVA: 0x7FFAC8F94540
        public void get_ClientCertificates(){} // RVA: 0x7FFAC8F947B0
        public void set_AutomaticDecompression(){} // RVA: 0x7FFAC8F948F0
        public void set_Proxy(){} // RVA: 0x7FFAC8F94950
        public void SetWebRequestTimeout(){} // RVA: 0x7FFAC8F949B0
        public void SendAsync(){} // RVA: 0x7FFAC8F94A10
        public void <set_ClientCertificateOptions>b__23_0(){} // RVA: 0x7FFAC8F94AF0
    }

    public class HttpContent : Object
    {
        public FixedMemoryStream Headers; // 0x10
        public System.IO.Stream LoadedBufferLength; // 0x18
        public bool disposed; // 0x20
        public System.Net.Http.Headers.HttpContentHeaders headers; // 0x28

        // ── Methods ──
        public void get_Headers(){} // RVA: 0x7FFAC8F9B470
        public void get_LoadedBufferLength(){} // RVA: 0x7FFAC8F9B5C0
        public void CopyToAsync(){} // RVA: 0x7FFAC8F9B700 | overloaded x2
        public void CreateContentReadStreamAsync(){} // RVA: 0x7FFAC8F9B7A0
        public void CreateFixedMemoryStream(){} // RVA: 0x7FFAC8F9B930
        public void Dispose(){} // RVA: 0x7FFAC8F9B990 | overloaded x2
        public void LoadIntoBufferAsync(){} // RVA: 0x7FFAC8F9B9D0 | overloaded x2
        public void ReadAsStreamAsync(){} // RVA: 0x7FFAC8F9BB90
        public void ReadAsByteArrayAsync(){} // RVA: 0x7FFAC8F9BD20
        public void ReadAsStringAsync(){} // RVA: 0x7FFAC8F9BEB0
        public void GetEncodingFromBuffer(){} // RVA: 0x7FFAC8F9C040
        public void StartsWith(){} // RVA: 0x7FFAC8F9C250
        public void SerializeToStreamAsync(){} // RVA: 0x7FFAC2C6A6F0
        public void TryComputeLength(){} // RVA: 0x7FFAC2C59F60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HttpMessageHandler : Object
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void SendAsync(){}
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HttpMessageInvoker : Object
    {
        public System.Net.Http.HttpMessageHandler handler; // 0x10
        public bool disposeHandler; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F9D910
        public void Dispose(){} // RVA: 0x7FFAC8F9D9C0 | overloaded x2
        public void SendAsync(){} // RVA: 0x7FFAC8F9AAC0
    }

    public class HttpMethod : Object
    {
        public System.Net.Http.HttpMethod Get;
        public System.Net.Http.HttpMethod Method; // 0x8
        public System.Net.Http.HttpMethod Post; // 0x10
        public System.Net.Http.HttpMethod options_method; // 0x18
        public System.Net.Http.HttpMethod post_method; // 0x20
        public System.Net.Http.HttpMethod put_method; // 0x28
        public System.Net.Http.HttpMethod trace_method; // 0x30
        public string method; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F9DA10
        public void get_Get(){} // RVA: 0x7FFAC8F9DAE0
        public void get_Method(){} // RVA: 0x7FFAC2F3C380
        public void get_Post(){} // RVA: 0x7FFAC8F9DB40
        public void op_Equality(){} // RVA: 0x7FFAC8F9DBA0
        public void Equals(){} // RVA: 0x7FFAC8F9DCB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
        public void ToString(){} // RVA: 0x7FFAC2F3C380
        public void .cctor(){} // RVA: 0x7FFAC8F9DD50
    }

    public class HttpRequestException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F9E2B0 | overloaded x3
    }

    public class HttpRequestMessage : Object
    {
        public System.Net.Http.Headers.HttpRequestHeaders Content; // 0x10
        public System.Net.Http.HttpMethod Headers; // 0x18
        public System.Version Method; // 0x20
        public System.Uri RequestUri; // 0x28
        public bool Version; // 0x30
        public bool disposed; // 0x31
        public System.Net.Http.HttpContent <Content>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F9E4B0 | overloaded x3
        public void get_Content(){} // RVA: 0x7FFAC31D0140
        public void set_Content(){} // RVA: 0x7FFAC31D0C20
        public void get_Headers(){} // RVA: 0x7FFAC8F9E4E0
        public void get_Method(){} // RVA: 0x7FFAC2F247C0
        public void set_Method(){} // RVA: 0x7FFAC8F9E5D0
        public void get_RequestUri(){} // RVA: 0x7FFAC2F4F130
        public void set_RequestUri(){} // RVA: 0x7FFAC8F9E6C0
        public void IsAllowedAbsoluteUri(){} // RVA: 0x7FFAC8F9E7D0
        public void get_Version(){} // RVA: 0x7FFAC8F9EA70
        public void Dispose(){} // RVA: 0x7FFAC8F9EAE0 | overloaded x2
        public void SetIsUsed(){} // RVA: 0x7FFAC8F9EB10
        public void ToString(){} // RVA: 0x7FFAC8F9EB20
    }

    public class HttpResponseMessage : Object
    {
        public System.Net.Http.Headers.HttpResponseHeaders Content; // 0x10
        public string Headers; // 0x18
        public 0x6B139DB8 IsSuccessStatusCode; // 0x20
        public System.Version ReasonPhrase; // 0x28
        public bool RequestMessage; // 0x30
        public System.Net.Http.HttpContent StatusCode; // 0x38
        public System.Net.Http.HttpRequestMessage Version; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F9EE80
        public void get_Content(){} // RVA: 0x7FFAC31D0140
        public void set_Content(){} // RVA: 0x7FFAC31D0C20
        public void get_Headers(){} // RVA: 0x7FFAC8F9EEE0
        public void get_IsSuccessStatusCode(){} // RVA: 0x7FFAC8F9EFD0
        public void get_ReasonPhrase(){} // RVA: 0x7FFAC8F9EFF0
        public void set_ReasonPhrase(){} // RVA: 0x7FFAC2F87E80
        public void get_RequestMessage(){} // RVA: 0x7FFAC2F9E740
        public void set_RequestMessage(){} // RVA: 0x7FFAC2F49200
        public void get_StatusCode(){} // RVA: 0x7FFAC30DBBE0
        public void set_StatusCode(){} // RVA: 0x7FFAC8F9EE80
        public void get_Version(){} // RVA: 0x7FFAC8F9F010
        public void Dispose(){} // RVA: 0x7FFAC8F9F080 | overloaded x2
        public void EnsureSuccessStatusCode(){} // RVA: 0x7FFAC8F9F0B0
        public void ToString(){} // RVA: 0x7FFAC8F9F170
    }

    public class HttpUtilities : Object
    {
        // ── Methods ──
        public void IsSupportedSecureScheme(){} // RVA: 0x7FFAC8F93FA0
        public void IsSecureWebSocketScheme(){} // RVA: 0x7FFAC8F94150
    }

    public class IMonoHttpClientHandler
    {
        public object SupportsAutomaticDecompression;
        public object SslOptions;
        public object AutomaticDecompression;
        public object Proxy;

        // ── Methods ──
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7FFAC2C59D00
        public void get_SslOptions(){} // RVA: 0x7FFAC2C58E90
        public void set_SslOptions(){} // RVA: 0x7FFAC2C70A40
        public void set_AutomaticDecompression(){} // RVA: 0x7FFAC2C70ED0
        public void set_Proxy(){} // RVA: 0x7FFAC2C70A40
        public void SendAsync(){}
        public void SetWebRequestTimeout(){} // RVA: 0x7FFAC2C70BF0
    }

    public class MonoWebRequestHandler : Object
    {
        public long AutomaticDecompression;
        public bool CookieContainer; // 0x10
        public 0x6B13CA68 MaxRequestContentBufferSize; // 0x14
        public System.Net.CookieContainer Proxy; // 0x18
        public System.Net.ICredentials SupportsAutomaticDecompression; // 0x20
        public int UseProxy; // 0x28
        public long SslOptions; // 0x30
        public bool preAuthenticate; // 0x38
        public System.Net.IWebProxy proxy; // 0x40
        public bool useCookies; // 0x48
        public bool useProxy; // 0x49
        public System.Net.Security.SslClientAuthenticationOptions sslOptions; // 0x50
        public bool allowPipelining; // 0x58
        public System.Net.Cache.RequestCachePolicy cachePolicy; // 0x60
        public 0x6B142370 authenticationLevel; // 0x68
        public System.TimeSpan continueTimeout; // 0x70
        public 0x6B0CE0C8 impersonationLevel; // 0x78
        public int maxResponseHeadersLength; // 0x7C
        public int readWriteTimeout; // 0x80
        public System.Net.Security.RemoteCertificateValidationCallback serverCertificateValidationCallback; // 0x88
        public bool unsafeAuthenticatedConnectionSharing; // 0x90
        public bool sentRequest; // 0x91
        public string connectionGroupName; // 0x98
        public System.Nullable`1<System.TimeSpan> timeout; // 0xA0
        public bool disposed; // 0xB0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F94D70
        public void EnsureModifiability(){} // RVA: 0x7FFAC8F95140
        public void set_AutomaticDecompression(){} // RVA: 0x7FFAC8F951B0
        public void get_CookieContainer(){} // RVA: 0x7FFAC8F95220
        public void get_MaxRequestContentBufferSize(){} // RVA: 0x7FFAC31D95E0
        public void set_Proxy(){} // RVA: 0x7FFAC8F952D0
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7FFAC3006850
        public void get_UseProxy(){} // RVA: 0x7FFAC3E0F350
        public void get_SslOptions(){} // RVA: 0x7FFAC8F953C0
        public void set_SslOptions(){} // RVA: 0x7FFAC8F95460
        public void Dispose(){} // RVA: 0x7FFAC8F95530 | overloaded x2
        public void GetConnectionKeepAlive(){} // RVA: 0x7FFAC8F955B0
        public void CreateWebRequest(){} // RVA: 0x7FFAC8F95780
        public void CreateResponseMessage(){} // RVA: 0x7FFAC8F965C0
        public void MethodHasBody(){} // RVA: 0x7FFAC8F96B10
        public void SendAsync(){} // RVA: 0x7FFAC8F96CE0
        public void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(){} // RVA: 0x7FFAC8F96F20
        public void <CreateWebRequest>b__96_0(){} // RVA: 0x7FFAC8F96F80
    }

    public class PlatformHelper : Object
    {
        // ── Methods ──
        public void IsContentHeader(){} // RVA: 0x7FFAC8F996C0
        public void GetSingleHeaderString(){} // RVA: 0x7FFAC8F99800
        public void CreateStreamContent(){} // RVA: 0x7FFAC8F99860
    }

    public class SerializableHttpContent : HttpContent
    {
        // ── Methods ──
        public void SerializeToStream(){} // RVA: 0x7FFAC2F21310
        public void ReadAsStream(){} // RVA: 0x7FFAC8BE3CA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StreamContent : HttpContent
    {
        public System.IO.Stream content; // 0x30
        public int bufferSize; // 0x38
        public System.Threading.CancellationToken cancellationToken; // 0x40
        public long startPosition; // 0x48
        public bool contentCopied; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F9F6B0 | overloaded x3
        public void CreateContentReadStreamAsync(){} // RVA: 0x7FFAC8F9F720
        public void Dispose(){} // RVA: 0x7FFAC8F9F790
        public void SerializeToStreamAsync(){} // RVA: 0x7FFAC8F9F7F0
        public void TryComputeLength(){} // RVA: 0x7FFAC8F9F8E0
    }

    public class StringContent : ByteArrayContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F9F980 | overloaded x2
        public void GetByteArray(){} // RVA: 0x7FFAC8F9FDC0
    }

}