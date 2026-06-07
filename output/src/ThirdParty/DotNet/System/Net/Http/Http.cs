// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Http
// Classes: 18
// Methods: 153

namespace ThirdParty.DotNet.System.Net.Http
{
    public class ByteArrayContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6802A60
        public void CreateContentReadStreamAsync(){} // RVA: 0x6802B20
        public void SerializeToStreamAsync(){} // RVA: 0x6802BF0
        public void TryComputeLength(){} // RVA: 0x6802C30
    }

    public class DelegatingHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6802C40 | overloaded x2
        public void get_InnerHandler(){} // RVA: 0x2E07C0
        public void set_InnerHandler(){} // RVA: 0x6802CF0
        public void Dispose(){} // RVA: 0x6802DA0
        public void SendAsync(){} // RVA: 0x6802DD0
    }

    public class HttpClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6802ED0 | overloaded x3
        public void get_DefaultRequestHeaders(){} // RVA: 0x6803090
        public void get_MaxResponseContentBufferSize(){} // RVA: 0x35A740
        public void Dispose(){} // RVA: 0x6803180
        public void GetAsync(){} // RVA: 0x6803330 | overloaded x2
        public void SendAsync(){} // RVA: 0x68034D0 | overloaded x3
        public void SendAsyncWorker(){} // RVA: 0x68038E0
        public void .cctor(){} // RVA: 0x6803B50
        public void <>n__0(){} // RVA: 0x6803C00
    }

    public class HttpClientHandler
    {
        // ── Methods ──
        public void CreateDefaultHandler(){} // RVA: 0x67FD390
        public void .ctor(){} // RVA: 0x67FD490 | overloaded x2
        public void Dispose(){} // RVA: 0x67FD4F0
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x67FD550
        public void ThrowForModifiedManagedSslOptionsIfStarted(){} // RVA: 0x67FD5A0
        public void get_ClientCertificateOptions(){} // RVA: 0x5BED50
        public void set_ClientCertificateOptions(){} // RVA: 0x67FD680
        public void get_ClientCertificates(){} // RVA: 0x67FD8F0
        public void set_AutomaticDecompression(){} // RVA: 0x67FDA30
        public void set_Proxy(){} // RVA: 0x67FDA90
        public void SetWebRequestTimeout(){} // RVA: 0x67FDAF0
        public void SendAsync(){} // RVA: 0x67FDB50
        public void <set_ClientCertificateOptions>b__23_0(){} // RVA: 0x67FDC30
    }

    public class HttpContent
    {
        // ── Methods ──
        public void get_Headers(){} // RVA: 0x68045B0
        public void get_LoadedBufferLength(){} // RVA: 0x6804700
        public void CopyToAsync(){} // RVA: 0x6804840 | overloaded x2
        public void CreateContentReadStreamAsync(){} // RVA: 0x68048E0
        public void CreateFixedMemoryStream(){} // RVA: 0x6804A70
        public void Dispose(){} // RVA: 0x6804AD0 | overloaded x2
        public void LoadIntoBufferAsync(){} // RVA: 0x6804B10 | overloaded x2
        public void ReadAsStreamAsync(){} // RVA: 0x6804CD0
        public void ReadAsByteArrayAsync(){} // RVA: 0x6804E60
        public void ReadAsStringAsync(){} // RVA: 0x6804FF0
        public void GetEncodingFromBuffer(){} // RVA: 0x6805180
        public void StartsWith(){} // RVA: 0x6805390
        public void SerializeToStreamAsync(){} // RVA: 0x1E6A0
        public void TryComputeLength(){} // RVA: 0xDE40
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HttpMessageHandler
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void SendAsync(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HttpMessageInvoker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6806A50
        public void Dispose(){} // RVA: 0x6806B00 | overloaded x2
        public void SendAsync(){} // RVA: 0x6803C00
    }

    public class HttpMethod
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6806B50
        public void get_Get(){} // RVA: 0x6806C20
        public void get_Method(){} // RVA: 0x2F8380
        public void get_Post(){} // RVA: 0x6806C80
        public void op_Equality(){} // RVA: 0x6806CE0
        public void Equals(){} // RVA: 0x6806DF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x99E0E0
        public void ToString(){} // RVA: 0x2F8380
        public void .cctor(){} // RVA: 0x6806E90
    }

    public class HttpRequestException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68073F0 | overloaded x3
    }

    public class HttpRequestMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68075F0 | overloaded x3
        public void get_Content(){} // RVA: 0x4976A0
        public void set_Content(){} // RVA: 0x49B830
        public void get_Headers(){} // RVA: 0x6807620
        public void get_Method(){} // RVA: 0x2E07C0
        public void set_Method(){} // RVA: 0x6807710
        public void get_RequestUri(){} // RVA: 0x30B130
        public void set_RequestUri(){} // RVA: 0x6807800
        public void IsAllowedAbsoluteUri(){} // RVA: 0x6807910
        public void get_Version(){} // RVA: 0x6807BB0
        public void Dispose(){} // RVA: 0x6807C20 | overloaded x2
        public void SetIsUsed(){} // RVA: 0x6807C50
        public void ToString(){} // RVA: 0x6807C60
    }

    public class HttpResponseMessage : 0
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6807FC0
        public void get_Content(){} // RVA: 0x4976A0
        public void set_Content(){} // RVA: 0x49B830
        public void get_Headers(){} // RVA: 0x6808020
        public void get_IsSuccessStatusCode(){} // RVA: 0x6808110
        public void get_ReasonPhrase(){} // RVA: 0x6808130
        public void set_ReasonPhrase(){} // RVA: 0x343E80
        public void get_RequestMessage(){} // RVA: 0x35A740
        public void set_RequestMessage(){} // RVA: 0x305200
        public void get_StatusCode(){} // RVA: 0x760030
        public void set_StatusCode(){} // RVA: 0x6807FC0
        public void get_Version(){} // RVA: 0x6808150
        public void Dispose(){} // RVA: 0x68081C0 | overloaded x2
        public void EnsureSuccessStatusCode(){} // RVA: 0x68081F0
        public void ToString(){} // RVA: 0x68082B0
    }

    public class HttpUtilities
    {
        // ── Methods ──
        public void IsSupportedSecureScheme(){} // RVA: 0x67FD0E0
        public void IsSecureWebSocketScheme(){} // RVA: 0x67FD290
    }

    public class IMonoHttpClientHandler
    {
        // ── Methods ──
        public void get_SupportsAutomaticDecompression(){} // RVA: 0xDBE0
        public void get_SslOptions(){} // RVA: 0xCD60
        public void set_SslOptions(){} // RVA: 0x24B10
        public void set_AutomaticDecompression(){} // RVA: 0x24FA0
        public void set_Proxy(){} // RVA: 0x24B10
        public void SendAsync(){}
        public void SetWebRequestTimeout(){} // RVA: 0x24CC0
    }

    public class MonoWebRequestHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67FDEB0
        public void EnsureModifiability(){} // RVA: 0x67FE280
        public void set_AutomaticDecompression(){} // RVA: 0x67FE2F0
        public void get_CookieContainer(){} // RVA: 0x67FE360
        public void get_MaxRequestContentBufferSize(){} // RVA: 0x6374D0
        public void set_Proxy(){} // RVA: 0x67FE410
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x3C2850
        public void get_UseProxy(){} // RVA: 0x1376F50
        public void get_SslOptions(){} // RVA: 0x67FE500
        public void set_SslOptions(){} // RVA: 0x67FE5A0
        public void Dispose(){} // RVA: 0x67FE670 | overloaded x2
        public void GetConnectionKeepAlive(){} // RVA: 0x67FE6F0
        public void CreateWebRequest(){} // RVA: 0x67FE8C0
        public void CreateResponseMessage(){} // RVA: 0x67FF700
        public void MethodHasBody(){} // RVA: 0x67FFC50
        public void SendAsync(){} // RVA: 0x67FFE20
        public void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(){} // RVA: 0x6800060
        public void <CreateWebRequest>b__96_0(){} // RVA: 0x68000C0
    }

    public class PlatformHelper
    {
        // ── Methods ──
        public void IsContentHeader(){} // RVA: 0x6802800
        public void GetSingleHeaderString(){} // RVA: 0x6802940
        public void CreateStreamContent(){} // RVA: 0x68029A0
    }

    public class SerializableHttpContent
    {
        // ── Methods ──
        public void SerializeToStream(){} // RVA: 0x2DD310
        public void ReadAsStream(){} // RVA: 0x644C920
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class StreamContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68087F0 | overloaded x3
        public void CreateContentReadStreamAsync(){} // RVA: 0x6808860
        public void Dispose(){} // RVA: 0x68088D0
        public void SerializeToStreamAsync(){} // RVA: 0x6808930
        public void TryComputeLength(){} // RVA: 0x6808A20
    }

    public class StringContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6808AC0 | overloaded x2
        public void GetByteArray(){} // RVA: 0x6808F00
    }

}