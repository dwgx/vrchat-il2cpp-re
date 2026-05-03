// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Http
// Classes: 18
// Methods: 153

namespace ThirdParty.DotNet.System.Net.Http
{
    public class ByteArrayContent : HttpContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87341D40
        public void CreateContentReadStreamAsync(){} // RVA: 0x7FFE87341E00
        public void SerializeToStreamAsync(){} // RVA: 0x7FFE87341ED0
        public void TryComputeLength(){} // RVA: 0x7FFE87341F10
    }

    public class DelegatingHandler : HttpMessageHandler
    {
        public bool disposed; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87341F20 | overloaded x2
        public void get_InnerHandler(){} // RVA: 0x7FFE810FE7C0
        public void set_InnerHandler(){} // RVA: 0x7FFE87341FD0
        public void Dispose(){} // RVA: 0x7FFE87342080
        public void SendAsync(){} // RVA: 0x7FFE873420B0
    }

    public class HttpClient : HttpMessageInvoker
    {
        public System.TimeSpan TimeoutDefault;
        public System.Uri base_address; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE873421B0 | overloaded x3
        public void get_DefaultRequestHeaders(){} // RVA: 0x7FFE87342370
        public void get_MaxResponseContentBufferSize(){} // RVA: 0x7FFE81178740
        public void Dispose(){} // RVA: 0x7FFE87342460
        public void GetAsync(){} // RVA: 0x7FFE87342610 | overloaded x2
        public void SendAsync(){} // RVA: 0x7FFE873427B0 | overloaded x3
        public void SendAsyncWorker(){} // RVA: 0x7FFE87342BC0
        public void .cctor(){} // RVA: 0x7FFE87342E30
        public void <>n__0(){} // RVA: 0x7FFE87342EE0
    }

    public class HttpClientHandler : HttpMessageHandler
    {
        public System.Net.Http.IMonoHttpClientHandler _delegatingHandler; // 0x10
        public 0x6669C524 _clientCertificateOptions; // 0x18
        public object field_2; // 0x1
        public object field_3; // 0x2
        public object field_4; // 0x3

        // ── Methods ──
        public void CreateDefaultHandler(){} // RVA: 0x7FFE8733C670
        public void .ctor(){} // RVA: 0x7FFE8733C770 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE8733C7D0
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7FFE8733C830
        public void ThrowForModifiedManagedSslOptionsIfStarted(){} // RVA: 0x7FFE8733C880
        public void get_ClientCertificateOptions(){} // RVA: 0x7FFE813DB630
        public void set_ClientCertificateOptions(){} // RVA: 0x7FFE8733C960
        public void get_ClientCertificates(){} // RVA: 0x7FFE8733CBD0
        public void set_AutomaticDecompression(){} // RVA: 0x7FFE8733CD10
        public void set_Proxy(){} // RVA: 0x7FFE8733CD70
        public void SetWebRequestTimeout(){} // RVA: 0x7FFE8733CDD0
        public void SendAsync(){} // RVA: 0x7FFE8733CE30
        public void <set_ClientCertificateOptions>b__23_0(){} // RVA: 0x7FFE8733CF10
    }

    public class HttpContent : Object
    {
        public FixedMemoryStream buffer; // 0x10
        public System.IO.Stream stream; // 0x18

        // ── Methods ──
        public void get_Headers(){} // RVA: 0x7FFE87343890
        public void get_LoadedBufferLength(){} // RVA: 0x7FFE873439E0
        public void CopyToAsync(){} // RVA: 0x7FFE87343B20 | overloaded x2
        public void CreateContentReadStreamAsync(){} // RVA: 0x7FFE87343BC0
        public void CreateFixedMemoryStream(){} // RVA: 0x7FFE87343D50
        public void Dispose(){} // RVA: 0x7FFE87343DB0 | overloaded x2
        public void LoadIntoBufferAsync(){} // RVA: 0x7FFE87343DF0 | overloaded x2
        public void ReadAsStreamAsync(){} // RVA: 0x7FFE87343FB0
        public void ReadAsByteArrayAsync(){} // RVA: 0x7FFE87344140
        public void ReadAsStringAsync(){} // RVA: 0x7FFE873442D0
        public void GetEncodingFromBuffer(){} // RVA: 0x7FFE87344460
        public void StartsWith(){} // RVA: 0x7FFE87344670
        public void SerializeToStreamAsync(){} // RVA: 0x7FFE80E3FC10
        public void TryComputeLength(){} // RVA: 0x7FFE80E2F3B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HttpMessageHandler : Object
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void SendAsync(){}
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HttpMessageInvoker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87345D30
        public void Dispose(){} // RVA: 0x7FFE87345DE0 | overloaded x2
        public void SendAsync(){} // RVA: 0x7FFE87342EE0
    }

    public class HttpMethod : Object
    {
        public System.Net.Http.HttpMethod delete_method;
        public System.Net.Http.HttpMethod get_method; // 0x8
        public System.Net.Http.HttpMethod head_method; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87345E30
        public void get_Get(){} // RVA: 0x7FFE87345F00
        public void get_Method(){} // RVA: 0x7FFE81116380
        public void get_Post(){} // RVA: 0x7FFE87345F60
        public void op_Equality(){} // RVA: 0x7FFE87345FC0
        public void Equals(){} // RVA: 0x7FFE873460D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
        public void ToString(){} // RVA: 0x7FFE81116380
        public void .cctor(){} // RVA: 0x7FFE87346170
    }

    public class HttpRequestException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE873466D0 | overloaded x3
    }

    public class HttpRequestMessage : Object
    {
        public System.Net.Http.Headers.HttpRequestHeaders headers; // 0x10
        public System.Net.Http.HttpMethod method; // 0x18
        public System.Version version; // 0x20
        public System.Uri uri; // 0x28
        public bool is_used; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE873468D0 | overloaded x3
        public void get_Content(){} // RVA: 0x7FFE8143BA80
        public void set_Content(){} // RVA: 0x7FFE81437330
        public void get_Headers(){} // RVA: 0x7FFE87346900
        public void get_Method(){} // RVA: 0x7FFE810FE7C0
        public void set_Method(){} // RVA: 0x7FFE873469F0
        public void get_RequestUri(){} // RVA: 0x7FFE81129130
        public void set_RequestUri(){} // RVA: 0x7FFE87346AE0
        public void IsAllowedAbsoluteUri(){} // RVA: 0x7FFE87346BF0
        public void get_Version(){} // RVA: 0x7FFE87346E90
        public void Dispose(){} // RVA: 0x7FFE87346F00 | overloaded x2
        public void SetIsUsed(){} // RVA: 0x7FFE87346F30
        public void ToString(){} // RVA: 0x7FFE87346F40
    }

    public class HttpResponseMessage : Object
    {
        public System.Net.Http.Headers.HttpResponseHeaders headers; // 0x10
        public string reasonPhrase; // 0x18
        public 0x66532CDC statusCode; // 0x20
        public System.Version version; // 0x28
        public bool disposed; // 0x30
        public System.Net.Http.HttpContent _content; // 0x38
        public System.Net.Http.HttpRequestMessage _requestMessage; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE873472A0
        public void get_Content(){} // RVA: 0x7FFE8143BA80
        public void set_Content(){} // RVA: 0x7FFE81437330
        public void get_Headers(){} // RVA: 0x7FFE87347300
        public void get_IsSuccessStatusCode(){} // RVA: 0x7FFE873473F0
        public void get_ReasonPhrase(){} // RVA: 0x7FFE87347410
        public void set_ReasonPhrase(){} // RVA: 0x7FFE81161E80
        public void get_RequestMessage(){} // RVA: 0x7FFE81178740
        public void set_RequestMessage(){} // RVA: 0x7FFE81123200
        public void get_StatusCode(){} // RVA: 0x7FFE8151D690
        public void set_StatusCode(){} // RVA: 0x7FFE873472A0
        public void get_Version(){} // RVA: 0x7FFE87347430
        public void Dispose(){} // RVA: 0x7FFE873474A0 | overloaded x2
        public void EnsureSuccessStatusCode(){} // RVA: 0x7FFE873474D0
        public void ToString(){} // RVA: 0x7FFE87347590
    }

    public class HttpUtilities : Object
    {
        // ── Methods ──
        public void IsSupportedSecureScheme(){} // RVA: 0x7FFE8733C3C0
        public void IsSecureWebSocketScheme(){} // RVA: 0x7FFE8733C570
    }

    public class IMonoHttpClientHandler
    {
        // ── Methods ──
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7FFE80E2F150
        public void get_SslOptions(){} // RVA: 0x7FFE80E2E2E0
        public void set_SslOptions(){} // RVA: 0x7FFE80E460A0
        public void set_AutomaticDecompression(){} // RVA: 0x7FFE80E46530
        public void set_Proxy(){} // RVA: 0x7FFE80E460A0
        public void SendAsync(){}
        public void SetWebRequestTimeout(){} // RVA: 0x7FFE80E46250
    }

    public class MonoWebRequestHandler : Object
    {
        public long groupCounter;
        public bool allowAutoRedirect; // 0x10
        public 0x6653598C automaticDecompression; // 0x14
        public System.Net.CookieContainer cookieContainer; // 0x18
        public System.Net.ICredentials credentials; // 0x20
        public int maxAutomaticRedirections; // 0x28
        public long maxRequestContentBufferSize; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8733D190
        public void EnsureModifiability(){} // RVA: 0x7FFE8733D560
        public void set_AutomaticDecompression(){} // RVA: 0x7FFE8733D5D0
        public void get_CookieContainer(){} // RVA: 0x7FFE8733D640
        public void get_MaxRequestContentBufferSize(){} // RVA: 0x7FFE8144E200
        public void set_Proxy(){} // RVA: 0x7FFE8733D6F0
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7FFE811E0850
        public void get_UseProxy(){} // RVA: 0x7FFE820ED800
        public void get_SslOptions(){} // RVA: 0x7FFE8733D7E0
        public void set_SslOptions(){} // RVA: 0x7FFE8733D880
        public void Dispose(){} // RVA: 0x7FFE8733D950 | overloaded x2
        public void GetConnectionKeepAlive(){} // RVA: 0x7FFE8733D9D0
        public void CreateWebRequest(){} // RVA: 0x7FFE8733DBA0
        public void CreateResponseMessage(){} // RVA: 0x7FFE8733E9E0
        public void MethodHasBody(){} // RVA: 0x7FFE8733EF30
        public void SendAsync(){} // RVA: 0x7FFE8733F100
        public void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(){} // RVA: 0x7FFE8733F340
        public void <CreateWebRequest>b__96_0(){} // RVA: 0x7FFE8733F3A0
    }

    public class PlatformHelper : Object
    {
        // ── Methods ──
        public void IsContentHeader(){} // RVA: 0x7FFE87341AE0
        public void GetSingleHeaderString(){} // RVA: 0x7FFE87341C20
        public void CreateStreamContent(){} // RVA: 0x7FFE87341C80
    }

    public class SerializableHttpContent : HttpContent
    {
        // ── Methods ──
        public void SerializeToStream(){} // RVA: 0x7FFE810FB310
        public void ReadAsStream(){} // RVA: 0x7FFE86F8D300
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StreamContent : HttpContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87347AD0 | overloaded x3
        public void CreateContentReadStreamAsync(){} // RVA: 0x7FFE87347B40
        public void Dispose(){} // RVA: 0x7FFE87347BB0
        public void SerializeToStreamAsync(){} // RVA: 0x7FFE87347C10
        public void TryComputeLength(){} // RVA: 0x7FFE87347D00
    }

    public class StringContent : ByteArrayContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87347DA0 | overloaded x2
        public void GetByteArray(){} // RVA: 0x7FFE873481E0
    }

}