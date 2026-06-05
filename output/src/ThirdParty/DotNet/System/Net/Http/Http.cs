// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Http
// Classes: 18
// Methods: 153

namespace ThirdParty.DotNet.System.Net.Http
{
    public class ByteArrayContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92B2A60
        public void CreateContentReadStreamAsync(){} // RVA: 0x7FFAF92B2B20
        public void SerializeToStreamAsync(){} // RVA: 0x7FFAF92B2BF0
        public void TryComputeLength(){} // RVA: 0x7FFAF92B2C30
    }

    public class DelegatingHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92B2C40 | overloaded x2
        public void get_InnerHandler(){} // RVA: 0x7FFAF2D907C0
        public void set_InnerHandler(){} // RVA: 0x7FFAF92B2CF0
        public void Dispose(){} // RVA: 0x7FFAF92B2DA0
        public void SendAsync(){} // RVA: 0x7FFAF92B2DD0
    }

    public class HttpClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92B2ED0 | overloaded x3
        public void get_DefaultRequestHeaders(){} // RVA: 0x7FFAF92B3090
        public void get_MaxResponseContentBufferSize(){} // RVA: 0x7FFAF2E0A740
        public void Dispose(){} // RVA: 0x7FFAF92B3180
        public void GetAsync(){} // RVA: 0x7FFAF92B3330 | overloaded x2
        public void SendAsync(){} // RVA: 0x7FFAF92B34D0 | overloaded x3
        public void SendAsyncWorker(){} // RVA: 0x7FFAF92B38E0
        public void .cctor(){} // RVA: 0x7FFAF92B3B50
        public void <>n__0(){} // RVA: 0x7FFAF92B3C00
    }

    public class HttpClientHandler
    {
        // ── Methods ──
        public void CreateDefaultHandler(){} // RVA: 0x7FFAF92AD390
        public void .ctor(){} // RVA: 0x7FFAF92AD490 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF92AD4F0
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7FFAF92AD550
        public void ThrowForModifiedManagedSslOptionsIfStarted(){} // RVA: 0x7FFAF92AD5A0
        public void get_ClientCertificateOptions(){} // RVA: 0x7FFAF306ED50
        public void set_ClientCertificateOptions(){} // RVA: 0x7FFAF92AD680
        public void get_ClientCertificates(){} // RVA: 0x7FFAF92AD8F0
        public void set_AutomaticDecompression(){} // RVA: 0x7FFAF92ADA30
        public void set_Proxy(){} // RVA: 0x7FFAF92ADA90
        public void SetWebRequestTimeout(){} // RVA: 0x7FFAF92ADAF0
        public void SendAsync(){} // RVA: 0x7FFAF92ADB50
        public void <set_ClientCertificateOptions>b__23_0(){} // RVA: 0x7FFAF92ADC30
    }

    public class HttpContent
    {
        // ── Methods ──
        public void get_Headers(){} // RVA: 0x7FFAF92B45B0
        public void get_LoadedBufferLength(){} // RVA: 0x7FFAF92B4700
        public void CopyToAsync(){} // RVA: 0x7FFAF92B4840 | overloaded x2
        public void CreateContentReadStreamAsync(){} // RVA: 0x7FFAF92B48E0
        public void CreateFixedMemoryStream(){} // RVA: 0x7FFAF92B4A70
        public void Dispose(){} // RVA: 0x7FFAF92B4AD0 | overloaded x2
        public void LoadIntoBufferAsync(){} // RVA: 0x7FFAF92B4B10 | overloaded x2
        public void ReadAsStreamAsync(){} // RVA: 0x7FFAF92B4CD0
        public void ReadAsByteArrayAsync(){} // RVA: 0x7FFAF92B4E60
        public void ReadAsStringAsync(){} // RVA: 0x7FFAF92B4FF0
        public void GetEncodingFromBuffer(){} // RVA: 0x7FFAF92B5180
        public void StartsWith(){} // RVA: 0x7FFAF92B5390
        public void SerializeToStreamAsync(){} // RVA: 0x7FFAF2ACE6A0
        public void TryComputeLength(){} // RVA: 0x7FFAF2ABDE40
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class HttpMessageHandler
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void SendAsync(){}
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class HttpMessageInvoker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92B6A50
        public void Dispose(){} // RVA: 0x7FFAF92B6B00 | overloaded x2
        public void SendAsync(){} // RVA: 0x7FFAF92B3C00
    }

    public class HttpMethod
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92B6B50
        public void get_Get(){} // RVA: 0x7FFAF92B6C20
        public void get_Method(){} // RVA: 0x7FFAF2DA8380
        public void get_Post(){} // RVA: 0x7FFAF92B6C80
        public void op_Equality(){} // RVA: 0x7FFAF92B6CE0
        public void Equals(){} // RVA: 0x7FFAF92B6DF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
        public void ToString(){} // RVA: 0x7FFAF2DA8380
        public void .cctor(){} // RVA: 0x7FFAF92B6E90
    }

    public class HttpRequestException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92B73F0 | overloaded x3
    }

    public class HttpRequestMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92B75F0 | overloaded x3
        public void get_Content(){} // RVA: 0x7FFAF2F476A0
        public void set_Content(){} // RVA: 0x7FFAF2F4B830
        public void get_Headers(){} // RVA: 0x7FFAF92B7620
        public void get_Method(){} // RVA: 0x7FFAF2D907C0
        public void set_Method(){} // RVA: 0x7FFAF92B7710
        public void get_RequestUri(){} // RVA: 0x7FFAF2DBB130
        public void set_RequestUri(){} // RVA: 0x7FFAF92B7800
        public void IsAllowedAbsoluteUri(){} // RVA: 0x7FFAF92B7910
        public void get_Version(){} // RVA: 0x7FFAF92B7BB0
        public void Dispose(){} // RVA: 0x7FFAF92B7C20 | overloaded x2
        public void SetIsUsed(){} // RVA: 0x7FFAF92B7C50
        public void ToString(){} // RVA: 0x7FFAF92B7C60
    }

    public class HttpResponseMessage : 0
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92B7FC0
        public void get_Content(){} // RVA: 0x7FFAF2F476A0
        public void set_Content(){} // RVA: 0x7FFAF2F4B830
        public void get_Headers(){} // RVA: 0x7FFAF92B8020
        public void get_IsSuccessStatusCode(){} // RVA: 0x7FFAF92B8110
        public void get_ReasonPhrase(){} // RVA: 0x7FFAF92B8130
        public void set_ReasonPhrase(){} // RVA: 0x7FFAF2DF3E80
        public void get_RequestMessage(){} // RVA: 0x7FFAF2E0A740
        public void set_RequestMessage(){} // RVA: 0x7FFAF2DB5200
        public void get_StatusCode(){} // RVA: 0x7FFAF3210030
        public void set_StatusCode(){} // RVA: 0x7FFAF92B7FC0
        public void get_Version(){} // RVA: 0x7FFAF92B8150
        public void Dispose(){} // RVA: 0x7FFAF92B81C0 | overloaded x2
        public void EnsureSuccessStatusCode(){} // RVA: 0x7FFAF92B81F0
        public void ToString(){} // RVA: 0x7FFAF92B82B0
    }

    public class HttpUtilities
    {
        // ── Methods ──
        public void IsSupportedSecureScheme(){} // RVA: 0x7FFAF92AD0E0
        public void IsSecureWebSocketScheme(){} // RVA: 0x7FFAF92AD290
    }

    public class IMonoHttpClientHandler
    {
        // ── Methods ──
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SslOptions(){} // RVA: 0x7FFAF2ABCD60
        public void set_SslOptions(){} // RVA: 0x7FFAF2AD4B10
        public void set_AutomaticDecompression(){} // RVA: 0x7FFAF2AD4FA0
        public void set_Proxy(){} // RVA: 0x7FFAF2AD4B10
        public void SendAsync(){}
        public void SetWebRequestTimeout(){} // RVA: 0x7FFAF2AD4CC0
    }

    public class MonoWebRequestHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92ADEB0
        public void EnsureModifiability(){} // RVA: 0x7FFAF92AE280
        public void set_AutomaticDecompression(){} // RVA: 0x7FFAF92AE2F0
        public void get_CookieContainer(){} // RVA: 0x7FFAF92AE360
        public void get_MaxRequestContentBufferSize(){} // RVA: 0x7FFAF30E74D0
        public void set_Proxy(){} // RVA: 0x7FFAF92AE410
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7FFAF2E72850
        public void get_UseProxy(){} // RVA: 0x7FFAF3E26F50
        public void get_SslOptions(){} // RVA: 0x7FFAF92AE500
        public void set_SslOptions(){} // RVA: 0x7FFAF92AE5A0
        public void Dispose(){} // RVA: 0x7FFAF92AE670 | overloaded x2
        public void GetConnectionKeepAlive(){} // RVA: 0x7FFAF92AE6F0
        public void CreateWebRequest(){} // RVA: 0x7FFAF92AE8C0
        public void CreateResponseMessage(){} // RVA: 0x7FFAF92AF700
        public void MethodHasBody(){} // RVA: 0x7FFAF92AFC50
        public void SendAsync(){} // RVA: 0x7FFAF92AFE20
        public void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(){} // RVA: 0x7FFAF92B0060
        public void <CreateWebRequest>b__96_0(){} // RVA: 0x7FFAF92B00C0
    }

    public class PlatformHelper
    {
        // ── Methods ──
        public void IsContentHeader(){} // RVA: 0x7FFAF92B2800
        public void GetSingleHeaderString(){} // RVA: 0x7FFAF92B2940
        public void CreateStreamContent(){} // RVA: 0x7FFAF92B29A0
    }

    public class SerializableHttpContent
    {
        // ── Methods ──
        public void SerializeToStream(){} // RVA: 0x7FFAF2D8D310
        public void ReadAsStream(){} // RVA: 0x7FFAF8EFC920
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class StreamContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92B87F0 | overloaded x3
        public void CreateContentReadStreamAsync(){} // RVA: 0x7FFAF92B8860
        public void Dispose(){} // RVA: 0x7FFAF92B88D0
        public void SerializeToStreamAsync(){} // RVA: 0x7FFAF92B8930
        public void TryComputeLength(){} // RVA: 0x7FFAF92B8A20
    }

    public class StringContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92B8AC0 | overloaded x2
        public void GetByteArray(){} // RVA: 0x7FFAF92B8F00
    }

}