// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Http
// Classes: 18
// Methods: 130

namespace ThirdParty.DotNet.System.Net.Http
{
    public class ByteArrayContent : HttpContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5F16B0
        public void CreateContentReadStreamAsync(){} // RVA: 0x7AE5F1770
        public void SerializeToStreamAsync(){} // RVA: 0x7AE5F1840
        public void TryComputeLength(){} // RVA: 0x7AE5F1880
    }

    public class DelegatingHandler : HttpMessageHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5F1890
        public void get_InnerHandler(){} // RVA: 0x7A80DA7B0
        public void set_InnerHandler(){} // RVA: 0x7AE5F1940
        public void Dispose(){} // RVA: 0x7AE5F19F0
        public void SendAsync(){} // RVA: 0x7AE5F1A20
    }

    public class HttpClient : HttpMessageInvoker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5F1B20
        public void get_DefaultRequestHeaders(){} // RVA: 0x7AE5F1CE0
        public void get_MaxResponseContentBufferSize(){} // RVA: 0x7A8154D80
        public void Dispose(){} // RVA: 0x7AE5F1DD0
        public void GetAsync(){} // RVA: 0x7AE5F1F80
        public void SendAsync(){} // RVA: 0x7AE5F2120
        public void SendAsyncWorker(){} // RVA: 0x7AE5F2530
        public void .cctor(){} // RVA: 0x7AE5F27A0
        public void <>n__0(){} // RVA: 0x7AE5F2850
    }

    public class HttpClientHandler : HttpMessageHandler
    {
        // ── Methods ──
        public void CreateDefaultHandler(){} // RVA: 0x7AE5EBFD0
        public void .ctor(){} // RVA: 0x7AE5EC0D0
        public void Dispose(){} // RVA: 0x7AE5EC130
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7AE5EC190
        public void ThrowForModifiedManagedSslOptionsIfStarted(){} // RVA: 0x7AE5EC1E0
        public void get_ClientCertificateOptions(){} // RVA: 0x7A83782A0
        public void set_ClientCertificateOptions(){} // RVA: 0x7AE5EC2C0
        public void get_ClientCertificates(){} // RVA: 0x7AE5EC530
        public void set_AutomaticDecompression(){} // RVA: 0x7AE5EC670
        public void set_Proxy(){} // RVA: 0x7AE5EC6D0
        public void SetWebRequestTimeout(){} // RVA: 0x7AE5EC730
        public void SendAsync(){} // RVA: 0x7AE5EC790
        public void <set_ClientCertificateOptions>b__23_0(){} // RVA: 0x7AE5EC870
    }

    public class HttpContent : Object
    {
        // ── Methods ──
        public void get_Headers(){} // RVA: 0x7AE5F31F0
        public void get_LoadedBufferLength(){} // RVA: 0x7AE5F3340
        public void CopyToAsync(){} // RVA: 0x7AE5F3480
        public void CreateContentReadStreamAsync(){} // RVA: 0x7AE5F3520
        public void CreateFixedMemoryStream(){} // RVA: 0x7AE5F36B0
        public void Dispose(){} // RVA: 0x7AE5F3710
        public void LoadIntoBufferAsync(){} // RVA: 0x7AE5F3750
        public void ReadAsStreamAsync(){} // RVA: 0x7AE5F3910
        public void ReadAsByteArrayAsync(){} // RVA: 0x7AE5F3AA0
        public void ReadAsStringAsync(){} // RVA: 0x7AE5F3C30
        public void GetEncodingFromBuffer(){} // RVA: 0x7AE5F3DC0
        public void StartsWith(){} // RVA: 0x7AE5F3FD0
        public void SerializeToStreamAsync(){} // RVA: 0x7A7E00BD0
        public void TryComputeLength(){} // RVA: 0x7A7E019D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class HttpMessageHandler : Object
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7A80D7310
        public void SendAsync(){} // RVA: 0x7A7E06640
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class HttpMessageInvoker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5F56A0
        public void Dispose(){} // RVA: 0x7AE5F5750
        public void SendAsync(){} // RVA: 0x7AE5F2850
    }

    public class HttpMethod : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5F57A0
        public void get_Get(){} // RVA: 0x7AE5F5870
        public void get_Method(){} // RVA: 0x7A80F2570
        public void get_Post(){} // RVA: 0x7AE5F58D0
        public void op_Equality(){} // RVA: 0x7AE5F5930
        public void Equals(){} // RVA: 0x7AE5F5A40
        public void GetHashCode(){} // RVA: 0x7A8738190
        public void ToString(){} // RVA: 0x7A80F2570
        public void .cctor(){} // RVA: 0x7AE5F5AD0
    }

    public class HttpRequestException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5F6030
    }

    public class HttpRequestMessage : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5F6230
        public void get_Content(){} // RVA: 0x7A8292C30
        public void set_Content(){} // RVA: 0x7A8296DE0
        public void get_Headers(){} // RVA: 0x7AE5F6260
        public void get_Method(){} // RVA: 0x7A80DA7B0
        public void set_Method(){} // RVA: 0x7AE5F6350
        public void get_RequestUri(){} // RVA: 0x7A8105330
        public void set_RequestUri(){} // RVA: 0x7AE5F6440
        public void IsAllowedAbsoluteUri(){} // RVA: 0x7AE5F6550
        public void get_Version(){} // RVA: 0x7AE5F67F0
        public void Dispose(){} // RVA: 0x7AE5F6860
        public void SetIsUsed(){} // RVA: 0x7AE5F6890
        public void ToString(){} // RVA: 0x7AE5F68A0
    }

    public class HttpResponseMessage : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5F6C00
        public void get_Content(){} // RVA: 0x7A8292C30
        public void set_Content(){} // RVA: 0x7A8296DE0
        public void get_Headers(){} // RVA: 0x7AE5F6C60
        public void get_IsSuccessStatusCode(){} // RVA: 0x7AE5F6D50
        public void get_ReasonPhrase(){} // RVA: 0x7AE5F6D70
        public void set_ReasonPhrase(){} // RVA: 0x7A813E420
        public void get_RequestMessage(){} // RVA: 0x7A8154D80
        public void set_RequestMessage(){} // RVA: 0x7A80FF440
        public void get_StatusCode(){} // RVA: 0x7A851DB90
        public void set_StatusCode(){} // RVA: 0x7AE5F6C00
        public void get_Version(){} // RVA: 0x7AE5F6D90
        public void Dispose(){} // RVA: 0x7AE5F6E00
        public void EnsureSuccessStatusCode(){} // RVA: 0x7AE5F6E30
        public void ToString(){} // RVA: 0x7AE5F6EF0
    }

    public class HttpUtilities : Object
    {
        // ── Methods ──
        public void IsSupportedSecureScheme(){} // RVA: 0x7AE5EBD20
        public void IsSecureWebSocketScheme(){} // RVA: 0x7AE5EBED0
    }

    public class IMonoHttpClientHandler
    {
        // ── Methods ──
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7A7E01900
        public void get_SslOptions(){} // RVA: 0x7A7E00680
        public void set_SslOptions(){} // RVA: 0x7A7E18800
        public void set_AutomaticDecompression(){} // RVA: 0x7A7E189D0
        public void set_Proxy(){} // RVA: 0x7A7E18800
        public void SendAsync(){} // RVA: 0x7A7E06640
        public void SetWebRequestTimeout(){} // RVA: 0x7A7E188D0
    }

    public class MonoWebRequestHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5ECAF0
        public void EnsureModifiability(){} // RVA: 0x7AE5ECEC0
        public void set_AutomaticDecompression(){} // RVA: 0x7AE5ECF30
        public void get_CookieContainer(){} // RVA: 0x7AE5ECFA0
        public void get_MaxRequestContentBufferSize(){} // RVA: 0x7A83F69F0
        public void set_Proxy(){} // RVA: 0x7AE5ED050
        public void get_SupportsAutomaticDecompression(){} // RVA: 0x7A81BD750
        public void get_UseProxy(){} // RVA: 0x7A9107BC0
        public void get_SslOptions(){} // RVA: 0x7AE5ED140
        public void set_SslOptions(){} // RVA: 0x7AE5ED1E0
        public void Dispose(){} // RVA: 0x7AE5ED2C0
        public void GetConnectionKeepAlive(){} // RVA: 0x7AE5ED340
        public void CreateWebRequest(){} // RVA: 0x7AE5ED510
        public void CreateResponseMessage(){} // RVA: 0x7AE5EE370
        public void MethodHasBody(){} // RVA: 0x7AE5EE8C0
        public void SendAsync(){} // RVA: 0x7AE5EEA90
        public void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(){} // RVA: 0x7AE5EECD0
        public void <CreateWebRequest>b__96_0(){} // RVA: 0x7AE5EED30
    }

    public class PlatformHelper : Object
    {
        // ── Methods ──
        public void IsContentHeader(){} // RVA: 0x7AE5F1450
        public void GetSingleHeaderString(){} // RVA: 0x7AE5F1590
        public void CreateStreamContent(){} // RVA: 0x7AE5F15F0
    }

    public class SerializableHttpContent : HttpContent
    {
        // ── Methods ──
        public void SerializeToStream(){} // RVA: 0x7A80D7310
        public void ReadAsStream(){} // RVA: 0x7AE23A8A0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class StreamContent : HttpContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5F7430
        public void CreateContentReadStreamAsync(){} // RVA: 0x7AE5F74A0
        public void Dispose(){} // RVA: 0x7AE5F7510
        public void SerializeToStreamAsync(){} // RVA: 0x7AE5F7570
        public void TryComputeLength(){} // RVA: 0x7AE5F7660
    }

    public class StringContent : ByteArrayContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5F7700
        public void GetByteArray(){} // RVA: 0x7AE5F7B40
    }

}