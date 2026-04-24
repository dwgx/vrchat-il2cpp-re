// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 8
// Methods: 197

namespace ThirdParty.DotNet.System.Net
{
    public class DefaultCertificatePolicy : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void CheckValidationResult(){} // RVA: 0x7ffaaed00df0
    }

    public class HttpWebRequest : WebRequest
    {
        public object hostChanged; // 0x30B89A60
        public object allowReadStreamBuffering; // 0x30B89A60
        public object haveContentLength; // 0x30B89A60
        public object cookieContainer; // 0x30B89A60
        public object requestSent; // 0x30B89A60
        public object maxAutoRedirect; // 0x30B89A60
        public object initialMethod; // 0x30B89A60
        public object usedPreAuth; // 0x30B89A60
        public object actualVersion; // 0x30B89A60
        public object servicePoint; // 0x30B89A60
        public object writeStream; // 0x30B89A60
        public object currentOperation; // 0x30B89A60
        public object redirects; // 0x30B89A60
        public object locker; // 0x30B89A60
        public object maxResponseHeadersLength; // 0x30B89A60
        public object defaultCachePolicy; // 0x30B89A60
        public object tlsSettings; // 0x30B89A60
        public object hostUri; // 0x30B89A60
        public object ResendContentFactory; // 0x30B89A60
        public object unsafe_auth_blah; // 0x30B89A60

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaed16250
        public void .ctor(){} // RVA: 0x7ffaaed1cb90
        public void .ctor(){} // RVA: 0x7ffaaed1cb90
        public void .ctor(){} // RVA: 0x7ffaaed1cb90
        public void ResetAuthorization(){} // RVA: 0x7ffaaed16c50
        public void get_Address(){} // RVA: 0x7ffaa89af740
        public void set_AllowAutoRedirect(){} // RVA: 0x7ffaa983cbb0
        public void get_AllowWriteStreamBuffering(){} // RVA: 0x7ffaa9b8d280
        public void set_AllowWriteStreamBuffering(){} // RVA: 0x7ffaa9b8b940
        public void get_AutomaticDecompression(){} // RVA: 0x7ffaaed16df0
        public void set_AutomaticDecompression(){} // RVA: 0x7ffaaed16e00
        public void get_InternalAllowBuffering(){} // RVA: 0x7ffaaed16e70
        public void get_MethodWithBuffer(){} // RVA: 0x7ffaaed16e80
        public void get_TlsProvider(){} // RVA: 0x7ffaa899d5f0
        public void get_TlsSettings(){} // RVA: 0x7ffaa899d660
        public void get_ClientCertificates(){} // RVA: 0x7ffaaed17070
        public void set_ConnectionGroupName(){} // RVA: 0x7ffaa89fa510
        public void get_ContentLength(){} // RVA: 0x7ffaa89add50
        public void set_ContentLength(){} // RVA: 0x7ffaaed17120
        public void set_InternalContentLength(){} // RVA: 0x7ffaaa5ccc00
        public void get_ThrowOnError(){} // RVA: 0x7ffaae4356d0
        public void set_ThrowOnError(){} // RVA: 0x7ffaaed171f0
        public void set_CookieContainer(){} // RVA: 0x7ffaa8af19e0
        public void get_Credentials(){} // RVA: 0x7ffaa8d1a3b0
        public void set_Credentials(){} // RVA: 0x7ffaa8efece0
        public void get_DefaultMaximumErrorResponseLength(){} // RVA: 0x7ffaaed17200
        public void get_Headers(){} // RVA: 0x7ffaa8d1b980
        public void get_Host(){} // RVA: 0x7ffaaed17260
        public void set_Host(){} // RVA: 0x7ffaaed173f0
        public void TryGetHostUri(){} // RVA: 0x7ffaaed176a0
        public void get_KeepAlive(){} // RVA: 0x7ffaa8dcb5d0
        public void set_KeepAlive(){} // RVA: 0x7ffaa8dc7aa0
        public void set_MaximumAutomaticRedirections(){} // RVA: 0x7ffaaed17780
        public void get_DefaultMaximumResponseHeadersLength(){} // RVA: 0x7ffaaed17810
        public void get_ReadWriteTimeout(){} // RVA: 0x7ffaae2e8440
        public void get_Method(){} // RVA: 0x7ffaa8f74720
        public void set_Method(){} // RVA: 0x7ffaaed17870
        public void set_PreAuthenticate(){} // RVA: 0x7ffaabc50480
        public void get_ProtocolVersion(){} // RVA: 0x7ffaa899d120
        public void set_ProtocolVersion(){} // RVA: 0x7ffaaed17df0
        public void get_Proxy(){} // RVA: 0x7ffaa8f6dbf0
        public void set_Proxy(){} // RVA: 0x7ffaaed17fb0
        public void get_RequestUri(){} // RVA: 0x7ffaa8bf45b0
        public void get_SendChunked(){} // RVA: 0x7ffaa8a5df80
        public void set_SendChunked(){} // RVA: 0x7ffaaed180f0
        public void get_ServicePoint(){} // RVA: 0x7ffaaed18160
        public void get_ServicePointNoLock(){} // RVA: 0x7ffaa89b3970
        public void get_Timeout(){} // RVA: 0x7ffaaba8f7a0
        public void set_Timeout(){} // RVA: 0x7ffaaed18170
        public void get_TransferEncoding(){} // RVA: 0x7ffaaed181e0
        public void get_UseDefaultCredentials(){} // RVA: 0x7ffaaed18240
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7ffaae4356e0
        public void get_ExpectContinue(){} // RVA: 0x7ffaaed182c0
        public void set_ExpectContinue(){} // RVA: 0x7ffaaed182d0
        public void get_AuthUri(){} // RVA: 0x7ffaa89af740
        public void get_ProxyQuery(){} // RVA: 0x7ffaaed182e0
        public void get_ServerCertValidationCallback(){} // RVA: 0x7ffaa8f6e840
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7ffaaed18310
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7ffaaed18330
        public void SendRequest(){} // RVA: 0x7ffaaed186a0
        public void MyGetRequestStreamAsync(){} // RVA: 0x7ffaaed18a60
        public void EndGetRequestStream(){} // RVA: 0x7ffaaed19230
        public void RunWithTimeout(){} // RVA: 0x7ffaa8649280
        public void RunWithTimeoutWorker(){} // RVA: 0x7ffaa865a820
        public void RunWithTimeout(){} // RVA: 0x7ffaa8649280
        public void MyGetResponseAsync(){} // RVA: 0x7ffaaed19390
        public void FlattenException(){} // RVA: 0x7ffaaed197e0
        public void CreateRequestAbortedException(){} // RVA: 0x7ffaaed19b70
        public void EndGetResponse(){} // RVA: 0x7ffaaed19e50
        public void set_FinishedReading(){} // RVA: 0x7ffaaed19fe0
        public void get_Aborted(){} // RVA: 0x7ffaaab49100
        public void Abort(){} // RVA: 0x7ffaaed19ff0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ffaaed1a1d0
        public void RewriteRedirectToGet(){} // RVA: 0x7ffaaed1a2e0
        public void Redirect(){} // RVA: 0x7ffaaed1a3f0
        public void HandleNtlmAuth(){} // RVA: 0x7ffaaed1beb0
        public void <RunWithTimeout>b__242_0(){} // RVA: 0x7ffaa864a040
        public void <GetRewriteHandler>b__271_0(){} // RVA: 0x7ffaaed1c9f0
        public void .ctor(){} // RVA: 0x7ffaaed1cb90
        // ── Binary Analysis Named ──
        public void GetServicePoint(){} // RVA: 0x7ffaaed18480
        public void BeginGetRequestStream(){} // RVA: 0x7ffaaed19170
        public void GetRequestStreamAsync(){} // RVA: 0x7ffaaed19300
        public void GetResponseFromData(){} // RVA: 0x7ffaaed19580
        public void GetWebException(){} // RVA: 0x7ffaaed19980
        public void GetWebException(){} // RVA: 0x7ffaaed19980
        public void BeginGetResponse(){} // RVA: 0x7ffaaed19c30
        public void GetResponse(){} // RVA: 0x7ffaaed19f20
        public void GetObjectData(){} // RVA: 0x7ffaaed1a210
        public void CheckRequestStarted(){} // RVA: 0x7ffaaed1a250
        public void DoContinueDelegate(){} // RVA: 0x7ffaaed1a2c0
        public void GetHeaders(){} // RVA: 0x7ffaaed1ab90
        public void DoPreAuthenticate(){} // RVA: 0x7ffaaed1b730
        public void GetRequestHeaders(){} // RVA: 0x7ffaaed1b960
        public void CheckAuthorization(){} // RVA: 0x7ffaaed1c170
        public void GetRewriteHandler(){} // RVA: 0x7ffaaed1c1a0
        public void CheckFinalStatus(){} // RVA: 0x7ffaaed1c410
    }

    public class ICertificatePolicy
    {
        // ── Binary Analysis Named ──
        public void CheckValidationResult(){}
    }

    public class ServerCertValidationCallback : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaecfdca0
        public void get_ValidationCallback(){} // RVA: 0x7ffaa894d380
        public void Callback(){} // RVA: 0x7ffaaecfddb0
        public void Invoke(){} // RVA: 0x7ffaaecfde60
    }

    public class ServicePoint : Object
    {
        public object protocolVersion; // 0x350E4800
        public object sendContinue; // 0x350E4800
        public object useNagle; // 0x350E4800
        public object tcp_keepalive_time; // 0x350E4800
        public object connectionLeaseTimeout; // 0x350E4800
        public object _scheduler; // 0x350E4800, was: <Scheduler>k__BackingField
        public object m_ServerCertificateOrBytes; // 0x350E4800
        public object _buckets; // 0x350EA500

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaed28900
        public void get_Key(){} // RVA: 0x7ffaa89add50
        public void get_Scheduler(){} // RVA: 0x7ffaa89fa590
        public void set_Scheduler(){} // RVA: 0x7ffaa89fa5a0
        public void get_Address(){} // RVA: 0x7ffaa894d380
        public void get_ConnectionLimit(){} // RVA: 0x7ffaa9fb1a70
        public void get_ProtocolVersion(){} // RVA: 0x7ffaa89600c0
        public void set_Expect100Continue(){} // RVA: 0x7ffaa8958480
        public void get_UseNagleAlgorithm(){} // RVA: 0x7ffaa89edc00
        public void set_UseNagleAlgorithm(){} // RVA: 0x7ffaa89edc10
        public void get_SendContinue(){} // RVA: 0x7ffaaed28b00
        public void set_SendContinue(){} // RVA: 0x7ffaa8958480
        public void KeepAliveSetup(){} // RVA: 0x7ffaaed28cb0
        public void PutBytes(){} // RVA: 0x7ffaaed28f60
        public void get_UsesProxy(){} // RVA: 0x7ffaa8958450
        public void set_UsesProxy(){} // RVA: 0x7ffaa8958460
        public void get_UseConnect(){} // RVA: 0x7ffaabef8500
        public void set_UseConnect(){} // RVA: 0x7ffaadc7ab30
        public void get_HasTimedOut(){} // RVA: 0x7ffaaed28fd0
        public void get_HostEntry(){} // RVA: 0x7ffaaed29150
        public void SendRequest(){} // RVA: 0x7ffaaed29820
        public void CloseConnectionGroup(){} // RVA: 0x7ffaaed29a10
        public void FreeServicePoint(){} // RVA: 0x7ffaaed29d00
        public void UpdateServerCertificate(){} // RVA: 0x7ffaaed29d60
        public void UpdateClientCertificate(){} // RVA: 0x7ffaaed29e60
        public void CallEndPointDelegate(){} // RVA: 0x7ffaaed29f60
        // ── Binary Analysis Named ──
        public void SetTcpKeepAlive(){} // RVA: 0x7ffaaed28bc0
        public void SetVersion(){} // RVA: 0x7ffaa89600d0
    }

    public class ServicePointManager : Object
    {
        public object defaultConnectionLimit; // 0x350E4250
        public object dnsRefreshTimeout; // 0x350E4250
        public object expectContinue; // 0x350E4250
        public object tcp_keepalive; // 0x350E4250

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaed2a030
        public void get_CertificatePolicy(){} // RVA: 0x7ffaaed2a190
        public void set_CertificatePolicy(){} // RVA: 0x7ffaaed2a2b0
        public void get_CheckCertificateRevocationList(){} // RVA: 0x7ffaaed2a3d0
        public void get_DnsRefreshTimeout(){} // RVA: 0x7ffaaed2a430
        public void get_SecurityProtocol(){} // RVA: 0x7ffaaed2a490
        public void get_ServerCertValidationCallback(){} // RVA: 0x7ffaaed2a4f0
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7ffaaed2a550
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7ffaaed2a5e0
        public void FindServicePoint(){} // RVA: 0x7ffaaed2a770
        public void CloseConnectionGroup(){} // RVA: 0x7ffaaed2b240
        public void RemoveServicePoint(){} // RVA: 0x7ffaaed2b5f0
        // ── Binary Analysis Named ──
        public void GetLegacyCertificatePolicy(){} // RVA: 0x7ffaaed2a370
    }

    public class WebCompletionSource`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa86613a0
        public void get_CurrentResult(){} // RVA: 0x7ffaa86491d0
        public void get_Task(){} // RVA: 0x7ffaa86491d0
        public void TrySetCompleted(){} // RVA: 0x7ffaa864a040
        public void TrySetCompleted(){} // RVA: 0x7ffaa864a040
        public void TrySetCanceled(){} // RVA: 0x7ffaa864a2a0
        public void TrySetCanceled(){} // RVA: 0x7ffaa864a2a0
        public void TrySetException(){} // RVA: 0x7ffaa864a2a0
        public void ThrowOnError(){} // RVA: 0x7ffaa8660cc0
        public void WaitForCompletion(){} // RVA: 0x7ffaa86491d0
    }

    public class WebRequest : MarshalByRefObject
    {
        public object s_InternalSyncObject; // 0x30B89DE0
        public object m_ImpersonationLevel; // 0x30B89DE0
        public object m_CacheBinding; // 0x30B89DE0
        public object s_DefaultWebProxyInitialized; // 0x30B89DE0
        public object InternalSyncObject; // 0x1700045C
        public object PrefixList; // 0x1700045D
        public object DefaultCachePolicy; // 0x1700045E
        public object CachePolicy; // 0x1700045F

        // ── Original Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7ffaaecdf3f0
        public void Create(){} // RVA: 0x7ffaaecdfa80
        public void Create(){} // RVA: 0x7ffaaecdfa80
        public void Create(){} // RVA: 0x7ffaaecdfa80
        public void get_PrefixList(){} // RVA: 0x7ffaaecdfb50
        public void PopulatePrefixList(){} // RVA: 0x7ffaaecdfdd0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ffaaece0000
        public void get_DefaultCachePolicy(){} // RVA: 0x7ffaaece0030
        public void set_CachePolicy(){} // RVA: 0x7ffaaece00b0
        public void InternalSetCachePolicy(){} // RVA: 0x7ffaaece00b0
        public void get_Method(){} // RVA: 0x7ffaaece0190
        public void set_Method(){} // RVA: 0x7ffaaece01c0
        public void get_RequestUri(){} // RVA: 0x7ffaaece01f0
        public void set_ConnectionGroupName(){} // RVA: 0x7ffaaece0220
        public void get_Headers(){} // RVA: 0x7ffaaece0250
        public void get_ContentLength(){} // RVA: 0x7ffaaece0280
        public void set_ContentLength(){} // RVA: 0x7ffaaece02b0
        public void get_Credentials(){} // RVA: 0x7ffaaece02e0
        public void set_Credentials(){} // RVA: 0x7ffaaece0310
        public void get_UseDefaultCredentials(){} // RVA: 0x7ffaaece0340
        public void get_Proxy(){} // RVA: 0x7ffaaece0370
        public void set_Proxy(){} // RVA: 0x7ffaaece03a0
        public void set_PreAuthenticate(){} // RVA: 0x7ffaaece03d0
        public void get_Timeout(){} // RVA: 0x7ffaaece0400
        public void set_Timeout(){} // RVA: 0x7ffaaece0430
        public void EndGetResponse(){} // RVA: 0x7ffaaece04c0
        public void EndGetRequestStream(){} // RVA: 0x7ffaaece0520
        public void SafeCaptureIdenity(){} // RVA: 0x7ffaaece0b70
        public void Abort(){} // RVA: 0x7ffaaece0bc0
        public void get_CacheProtocol(){} // RVA: 0x7ffaa8960130
        public void set_CacheProtocol(){} // RVA: 0x7ffaa8933e90
        public void get_InternalDefaultWebProxy(){} // RVA: 0x7ffaaece0bf0
        public void .cctor(){} // RVA: 0x7ffaaece0e70
        public void <GetRequestStreamAsync>b__78_0(){} // RVA: 0x7ffaaece0fd0
        public void <GetResponseAsync>b__79_0(){} // RVA: 0x7ffaaece1100
        // ── Binary Analysis Named ──
        public void GetObjectData(){} // RVA: 0x7ffaa8932310
        public void GetResponse(){} // RVA: 0x7ffaaece0460
        public void BeginGetResponse(){} // RVA: 0x7ffaaece0490
        public void BeginGetRequestStream(){} // RVA: 0x7ffaaece04f0
        public void GetRequestStreamAsync(){} // RVA: 0x7ffaaece0550
        public void GetResponseAsync(){} // RVA: 0x7ffaaece0860
    }

}