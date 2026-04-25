// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 150

namespace ThirdParty.DotNet.System.Net
{
    public class HttpWebRequest : WebRequest
    {
        public System.Uri Address; // 0x38
        public System.Uri AllowAutoRedirect; // 0x40
        public bool AllowWriteStreamBuffering; // 0x48
        public bool AutomaticDecompression; // 0x49
        public bool InternalAllowBuffering; // 0x4A
        public bool MethodWithBuffer; // 0x4B
        public 0x66491EE0 TlsProvider; // 0x50
        public string TlsSettings; // 0x58
        public bool ClientCertificates; // 0x60
        public long ConnectionGroupName; // 0x68
        public 0x6649AF40 ContentLength; // 0x70
        public 0x6649C120 InternalContentLength; // 0x78
        public 0x6649AC80 ThrowOnError; // 0x80
        public bool CookieContainer; // 0x88
        public bool Credentials; // 0x89
        public 0x6649B3B8 DefaultMaximumErrorResponseLength; // 0x90
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
        public 0x6649C3E0 SendChunked; // 0xD8
        public bool ServicePoint; // 0xE0
        public 0x6649D9E0 ServicePointNoLock; // 0xE8
        public int Timeout; // 0xF0
        public int TransferEncoding; // 0xF4
        public 0x6649E6F0 UseDefaultCredentials; // 0xF8
        public 0x6649D568 UnsafeAuthenticatedConnectionSharing; // 0x100
        public 0x6649DE58 ExpectContinue; // 0x108
        public 0x6649E328 AuthUri; // 0x110
        public int ProxyQuery; // 0x118
        public bool ServerCertValidationCallback; // 0x11C
        public int ServerCertificateValidationCallback; // 0x120
        public bool FinishedReading; // 0x124
        public bool Aborted; // 0x125
        public object locker; // 0x128
        public bool finished_reading; // 0x130
        public 0x6649CA68 auto_decomp; // 0x134
        public int maxResponseHeadersLength; // 0x138
        public int defaultMaxResponseHeadersLength;
        public int defaultMaximumErrorResponseLength; // 0x4
        public 0x664A0110 defaultCachePolicy; // 0x8
        public int readWriteTimeout; // 0x13C
        public 0x6648CDC0 tlsProvider; // 0x140
        public ÏÍÏÍÎÌ.ÎÍÌÎÏÎÎÏÍÎÍÎÎÍÍÎÏÏÍÍÌÌÍ tlsSettings; // 0x148
        public 0x6649C6F8 certValidationCallback; // 0x150
        public bool hostHasPort; // 0x158
        public System.Uri hostUri; // 0x160
        public 0x6649D300 auth_state; // 0x168
        public 0x6649D300 proxy_auth_state; // 0x178
        public System.Func`2<System.IO.Stream,System.Threading.Tasks.Task> ResendContentFactory; // 0x188
        public int ID; // 0x190
        public bool <ThrowOnError>k__BackingField; // 0x194
        public bool unsafe_auth_blah; // 0x195
        public bool <ReuseConnection>k__BackingField; // 0x196

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54714280
        public void .ctor(){} // RVA: 0x7FFD5471ABC0 | overloaded x4
        public void ResetAuthorization(){} // RVA: 0x7FFD54714C80
        public void get_Address(){} // RVA: 0x7FFD4E3BE740
        public void set_AllowAutoRedirect(){} // RVA: 0x7FFD4F22F360
        public void get_AllowWriteStreamBuffering(){} // RVA: 0x7FFD4F5856F0
        public void set_AllowWriteStreamBuffering(){} // RVA: 0x7FFD4F584B40
        public void get_AutomaticDecompression(){} // RVA: 0x7FFD54714E20
        public void set_AutomaticDecompression(){} // RVA: 0x7FFD54714E30
        public void get_InternalAllowBuffering(){} // RVA: 0x7FFD54714EA0
        public void get_MethodWithBuffer(){} // RVA: 0x7FFD54714EB0
        public void get_TlsProvider(){} // RVA: 0x7FFD4E3AC5F0
        public void get_TlsSettings(){} // RVA: 0x7FFD4E3AC660
        public void get_ClientCertificates(){} // RVA: 0x7FFD547150A0
        public void set_ConnectionGroupName(){} // RVA: 0x7FFD4E409510
        public void get_ContentLength(){} // RVA: 0x7FFD4E3BCD50
        public void set_ContentLength(){} // RVA: 0x7FFD54715150
        public void set_InternalContentLength(){} // RVA: 0x7FFD4FE4BA80
        public void get_ThrowOnError(){} // RVA: 0x7FFD53E344B0
        public void set_ThrowOnError(){} // RVA: 0x7FFD54715220
        public void set_CookieContainer(){} // RVA: 0x7FFD4E5006F0
        public void get_Credentials(){} // RVA: 0x7FFD4E70F410
        public void set_Credentials(){} // RVA: 0x7FFD4E8F4AA0
        public void get_DefaultMaximumErrorResponseLength(){} // RVA: 0x7FFD54715230
        public void get_Headers(){} // RVA: 0x7FFD4E70F640
        public void get_Host(){} // RVA: 0x7FFD54715290
        public void set_Host(){} // RVA: 0x7FFD54715420
        public void TryGetHostUri(){} // RVA: 0x7FFD547156D0
        public void get_KeepAlive(){} // RVA: 0x7FFD4E7BA7F0
        public void set_KeepAlive(){} // RVA: 0x7FFD4E7BFA20
        public void set_MaximumAutomaticRedirections(){} // RVA: 0x7FFD547157B0
        public void get_DefaultMaximumResponseHeadersLength(){} // RVA: 0x7FFD54715840
        public void get_ReadWriteTimeout(){} // RVA: 0x7FFD53CE7230
        public void get_Method(){} // RVA: 0x7FFD4E96B1A0
        public void set_Method(){} // RVA: 0x7FFD547158A0
        public void set_PreAuthenticate(){} // RVA: 0x7FFD5165E960
        public void get_ProtocolVersion(){} // RVA: 0x7FFD4E3AC120
        public void set_ProtocolVersion(){} // RVA: 0x7FFD54715E20
        public void get_Proxy(){} // RVA: 0x7FFD4E960F70
        public void set_Proxy(){} // RVA: 0x7FFD54715FE0
        public void get_RequestUri(){} // RVA: 0x7FFD4E5F0140
        public void get_SendChunked(){} // RVA: 0x7FFD4E46CF80
        public void set_SendChunked(){} // RVA: 0x7FFD54716120
        public void get_ServicePoint(){} // RVA: 0x7FFD54716190
        public void get_ServicePointNoLock(){} // RVA: 0x7FFD4E3C2970
        public void get_Timeout(){} // RVA: 0x7FFD514A55D0
        public void set_Timeout(){} // RVA: 0x7FFD547161A0
        public void get_TransferEncoding(){} // RVA: 0x7FFD54716210
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFD54716270
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7FFD53E344C0
        public void get_ExpectContinue(){} // RVA: 0x7FFD547162F0
        public void set_ExpectContinue(){} // RVA: 0x7FFD54716300
        public void get_AuthUri(){} // RVA: 0x7FFD4E3BE740
        public void get_ProxyQuery(){} // RVA: 0x7FFD54716310
        public void get_ServerCertValidationCallback(){} // RVA: 0x7FFD4E96DFA0
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7FFD54716340
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7FFD54716360
        public void GetServicePoint(){} // RVA: 0x7FFD547164B0
        public void SendRequest(){} // RVA: 0x7FFD547166D0
        public void MyGetRequestStreamAsync(){} // RVA: 0x7FFD54716A90
        public void BeginGetRequestStream(){} // RVA: 0x7FFD547171A0
        public void EndGetRequestStream(){} // RVA: 0x7FFD54717260
        public void GetRequestStreamAsync(){} // RVA: 0x7FFD54717330
        public void RunWithTimeout(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void RunWithTimeoutWorker(){} // RVA: 0x7FFD4E08A4E0
        public void MyGetResponseAsync(){} // RVA: 0x7FFD547173C0
        public void GetResponseFromData(){} // RVA: 0x7FFD547175B0
        public void FlattenException(){} // RVA: 0x7FFD54717810
        public void GetWebException(){} // RVA: 0x7FFD547179B0 | overloaded x2
        public void CreateRequestAbortedException(){} // RVA: 0x7FFD54717BA0
        public void BeginGetResponse(){} // RVA: 0x7FFD54717C60
        public void EndGetResponse(){} // RVA: 0x7FFD54717E80
        public void GetResponse(){} // RVA: 0x7FFD54717F50
        public void set_FinishedReading(){} // RVA: 0x7FFD54718010
        public void get_Aborted(){} // RVA: 0x7FFD505671A0
        public void Abort(){} // RVA: 0x7FFD54718020
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD54718200
        public void GetObjectData(){} // RVA: 0x7FFD54718240
        public void CheckRequestStarted(){} // RVA: 0x7FFD54718280
        public void DoContinueDelegate(){} // RVA: 0x7FFD547182F0
        public void RewriteRedirectToGet(){} // RVA: 0x7FFD54718310
        public void Redirect(){} // RVA: 0x7FFD54718420
        public void GetHeaders(){} // RVA: 0x7FFD54718BC0
        public void DoPreAuthenticate(){} // RVA: 0x7FFD54719760
        public void GetRequestHeaders(){} // RVA: 0x7FFD54719990
        public void HandleNtlmAuth(){} // RVA: 0x7FFD54719EE0
        public void CheckAuthorization(){} // RVA: 0x7FFD5471A1A0
        public void GetRewriteHandler(){} // RVA: 0x7FFD5471A1D0
        public void CheckFinalStatus(){} // RVA: 0x7FFD5471A440
        public void <RunWithTimeout>b__242_0(){} // RVA: 0x7FFD4E079D00
        public void <GetRewriteHandler>b__271_0(){} // RVA: 0x7FFD5471AA20
    }

    public class ICertificatePolicy
    {
        // ── Methods ──
        public void CheckValidationResult(){}
    }

    public class WebCompletionSource`1 : Object
    {
        public System.Threading.Tasks.TaskCompletionSource`1<Result<T>> CurrentResult;
        public Result<T> Task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E091060
        public void get_CurrentResult(){} // RVA: 0x7FFD4E078E90
        public void get_Task(){} // RVA: 0x7FFD4E078E90
        public void TrySetCompleted(){} // RVA: 0x7FFD4E079D00 | overloaded x2
        public void TrySetCanceled(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void TrySetException(){} // RVA: 0x7FFD4E079F60
        public void ThrowOnError(){} // RVA: 0x7FFD4E090980
        public void WaitForCompletion(){} // RVA: 0x7FFD4E078E90
    }

    public class WebRequest : MarshalByRefObject
    {
        public int InternalSyncObject;
        public System.Collections.ArrayList PrefixList;
        public object DefaultCachePolicy; // 0x8
        public 0x6649BA40 CachePolicy; // 0x10
        public 0x664A2370 Method; // 0x18
        public 0x6642E0C8 RequestUri; // 0x1C
        public 0x664A0110 ConnectionGroupName; // 0x20
        public 0x664A01C0 Headers; // 0x28
        public 0x664A0060 ContentLength; // 0x30
        public 0x6649B468 Credentials; // 0x18
        public 0x6649C3E0 UseDefaultCredentials; // 0x20
        public bool Proxy; // 0x28

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFD546DD420
        public void Create(){} // RVA: 0x7FFD546DDAB0 | overloaded x3
        public void get_PrefixList(){} // RVA: 0x7FFD546DDB80
        public void PopulatePrefixList(){} // RVA: 0x7FFD546DDE00
        public void .ctor(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD546DE030
        public void GetObjectData(){} // RVA: 0x7FFD4E341310
        public void get_DefaultCachePolicy(){} // RVA: 0x7FFD546DE060
        public void set_CachePolicy(){} // RVA: 0x7FFD546DE0E0
        public void InternalSetCachePolicy(){} // RVA: 0x7FFD546DE0E0
        public void get_Method(){} // RVA: 0x7FFD546DE1C0
        public void set_Method(){} // RVA: 0x7FFD546DE1F0
        public void get_RequestUri(){} // RVA: 0x7FFD546DE220
        public void set_ConnectionGroupName(){} // RVA: 0x7FFD546DE250
        public void get_Headers(){} // RVA: 0x7FFD546DE280
        public void get_ContentLength(){} // RVA: 0x7FFD546DE2B0
        public void set_ContentLength(){} // RVA: 0x7FFD546DE2E0
        public void get_Credentials(){} // RVA: 0x7FFD546DE310
        public void set_Credentials(){} // RVA: 0x7FFD546DE340
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFD546DE370
        public void get_Proxy(){} // RVA: 0x7FFD546DE3A0
        public void set_Proxy(){} // RVA: 0x7FFD546DE3D0
        public void set_PreAuthenticate(){} // RVA: 0x7FFD546DE400
        public void get_Timeout(){} // RVA: 0x7FFD546DE430
        public void set_Timeout(){} // RVA: 0x7FFD546DE460
        public void GetResponse(){} // RVA: 0x7FFD546DE490
        public void BeginGetResponse(){} // RVA: 0x7FFD546DE4C0
        public void EndGetResponse(){} // RVA: 0x7FFD546DE4F0
        public void BeginGetRequestStream(){} // RVA: 0x7FFD546DE520
        public void EndGetRequestStream(){} // RVA: 0x7FFD546DE550
        public void GetRequestStreamAsync(){} // RVA: 0x7FFD546DE580
        public void GetResponseAsync(){} // RVA: 0x7FFD546DE890
        public void SafeCaptureIdenity(){} // RVA: 0x7FFD546DEBA0
        public void Abort(){} // RVA: 0x7FFD546DEBF0
        public void get_CacheProtocol(){} // RVA: 0x7FFD4E36F130
        public void set_CacheProtocol(){} // RVA: 0x7FFD4E342E90
        public void get_InternalDefaultWebProxy(){} // RVA: 0x7FFD546DEC20
        public void .cctor(){} // RVA: 0x7FFD546DEEA0
        public void <GetRequestStreamAsync>b__78_0(){} // RVA: 0x7FFD546DF000
        public void <GetResponseAsync>b__79_0(){} // RVA: 0x7FFD546DF130
    }

}