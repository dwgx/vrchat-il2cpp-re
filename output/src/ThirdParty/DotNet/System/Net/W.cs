// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 17
// Methods: 336

namespace ThirdParty.DotNet.System.Net
{
    public class WebCompletionSource : WebCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876B7350
    }

    public class WebCompletionSource`1 : Object
    {
        public System.Threading.Tasks.TaskCompletionSource`1<Result<T>> completion;
        public Result<T> currentResult;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E466C0
        public void get_CurrentResult(){} // RVA: 0x7FFE80E2E2E0
        public void get_Task(){} // RVA: 0x7FFE80E2E2E0
        public void TrySetCompleted(){} // RVA: 0x7FFE80E2F150 | overloaded x2
        public void TrySetCanceled(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void TrySetException(){} // RVA: 0x7FFE80E2F3B0
        public void ThrowOnError(){} // RVA: 0x7FFE80E45FE0
        public void WaitForCompletion(){} // RVA: 0x7FFE80E2E2E0
    }

    public class WebConnection : Object
    {
        public System.Net.NetworkCredential ntlm_credentials; // 0x10
        public bool ntlm_authenticated; // 0x18
        public bool unsafe_sharing; // 0x19
        public System.IO.Stream networkStream; // 0x20
        public System.Net.Sockets.Socket socket; // 0x28
        public Mono.Net.Security.MonoTlsStream monoTlsStream; // 0x30

        // ── Methods ──
        public void get_ServicePoint(){} // RVA: 0x7FFE81176730
        public void .ctor(){} // RVA: 0x7FFE81176740
        public void CanReuse(){} // RVA: 0x7FFE876B7390
        public void CheckReusable(){} // RVA: 0x7FFE876B73C0
        public void Connect(){} // RVA: 0x7FFE876B7410
        public void CreateStream(){} // RVA: 0x7FFE876B7690
        public void InitConnection(){} // RVA: 0x7FFE876B7900
        public void GetException(){} // RVA: 0x7FFE876B7B50
        public void ReadLine(){} // RVA: 0x7FFE876B7D70
        public void CanReuseConnection(){} // RVA: 0x7FFE876B7FD0
        public void PrepareSharingNtlm(){} // RVA: 0x7FFE876B8480
        public void Reset(){} // RVA: 0x7FFE876B8730
        public void Close(){} // RVA: 0x7FFE876B8920
        public void CloseSocket(){} // RVA: 0x7FFE876B8A70
        public void get_Closed(){} // RVA: 0x7FFE876B8DB0
        public void get_IdleSince(){} // RVA: 0x7FFE811C3500
        public void StartOperation(){} // RVA: 0x7FFE876B8DC0
        public void Continue(){} // RVA: 0x7FFE876B90A0
        public void Dispose(){} // RVA: 0x7FFE876B9300 | overloaded x2
        public void ResetNtlm(){} // RVA: 0x7FFE876B9320
        public void get_NtlmAuthenticated(){} // RVA: 0x7FFE811164E0
        public void set_NtlmAuthenticated(){} // RVA: 0x7FFE811164F0
        public void get_NtlmCredential(){} // RVA: 0x7FFE81116380
        public void set_NtlmCredential(){} // RVA: 0x7FFE810FCE30
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7FFE814B3730
        public void set_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7FFE81CD0510
    }

    public class WebConnectionStream : Stream
    {
        public bool closed; // 0x28
        public bool disposed; // 0x29
        public object locker; // 0x30
        public int read_timeout; // 0x38
        public int write_timeout; // 0x3C
        public bool IgnoreIOErrors; // 0x40
        public System.Net.HttpWebRequest _request; // 0x48
        public System.Net.WebConnection _connection; // 0x50
        public System.Net.WebOperation _operation; // 0x58
        public byte[] crlf;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876BB150
        public void get_Request(){} // RVA: 0x7FFE81176730
        public void get_Connection(){} // RVA: 0x7FFE8119C0E0
        public void get_Operation(){} // RVA: 0x7FFE811C3500
        public void get_ServicePoint(){} // RVA: 0x7FFE876BB360
        public void get_CanTimeout(){} // RVA: 0x7FFE811E0850
        public void get_ReadTimeout(){} // RVA: 0x7FFE81D46090
        public void set_ReadTimeout(){} // RVA: 0x7FFE876BB380
        public void get_WriteTimeout(){} // RVA: 0x7FFE816311C0
        public void set_WriteTimeout(){} // RVA: 0x7FFE876BB3F0
        public void GetException(){} // RVA: 0x7FFE876BB460
        public void TryReadFromBufferedContent(){}
        public void Read(){} // RVA: 0x7FFE876BB600
        public void BeginRead(){} // RVA: 0x7FFE876BB8C0
        public void EndRead(){} // RVA: 0x7FFE876BBB40
        public void BeginWrite(){} // RVA: 0x7FFE876BBC10
        public void EndWrite(){} // RVA: 0x7FFE876BBE40
        public void Write(){} // RVA: 0x7FFE876BBEF0
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void FlushAsync(){} // RVA: 0x7FFE876BC130
        public void InternalClose(){} // RVA: 0x7FFE876BC1E0
        public void Close_internal(){} // RVA: 0x7FFE80E460A0
        public void Close(){} // RVA: 0x7FFE876BC1F0
        public void Seek(){} // RVA: 0x7FFE876BC210
        public void SetLength(){} // RVA: 0x7FFE876BC260
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_Length(){} // RVA: 0x7FFE876BC2B0
        public void get_Position(){} // RVA: 0x7FFE876BC300
        public void set_Position(){} // RVA: 0x7FFE876BC350
    }

    public class WebConnectionTunnel : Object
    {
        public System.Net.HttpWebRequest _request; // 0x10
        public System.Uri _connectUri; // 0x18
        public System.Net.HttpWebRequest connectRequest; // 0x20
        public 0x6653703C ntlmAuthState; // 0x28
        public bool _success; // 0x2C
        public bool _closeConnection; // 0x2D
        public int _statusCode; // 0x30
        public string _statusDescription; // 0x38
        public string[] _challenge; // 0x40
        public System.Net.WebHeaderCollection _headers; // 0x48

        // ── Methods ──
        public void get_Request(){} // RVA: 0x7FFE81116380
        public void get_ConnectUri(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_Success(){} // RVA: 0x7FFE811DA230
        public void set_Success(){} // RVA: 0x7FFE811DA240
        public void get_CloseConnection(){} // RVA: 0x7FFE8130C7C0
        public void set_CloseConnection(){} // RVA: 0x7FFE8130B300
        public void get_StatusCode(){} // RVA: 0x7FFE81156CD0
        public void set_StatusCode(){} // RVA: 0x7FFE81156CE0
        public void set_StatusDescription(){} // RVA: 0x7FFE81437330
        public void get_Challenge(){} // RVA: 0x7FFE81178740
        public void set_Challenge(){} // RVA: 0x7FFE81123200
        public void get_Headers(){} // RVA: 0x7FFE81176730
        public void set_Headers(){} // RVA: 0x7FFE81176740
        public void get_ProxyVersion(){} // RVA: 0x7FFE8119C0E0
        public void set_ProxyVersion(){} // RVA: 0x7FFE812534D0
        public void get_Data(){} // RVA: 0x7FFE811C3500
        public void set_Data(){} // RVA: 0x7FFE811C3510
        public void Initialize(){} // RVA: 0x7FFE876BC3A0
        public void ReadHeaders(){} // RVA: 0x7FFE876BC620
        public void FlushContents(){} // RVA: 0x7FFE876BC880
    }

    public class WebException : InvalidOperationException
    {
        public 0x6653417C m_Status; // 0x90
        public System.Net.WebResponse m_Response; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87661BC0 | overloaded x10
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87661C50
        public void GetObjectData(){} // RVA: 0x7FFE87660600
        public void get_Status(){} // RVA: 0x7FFE814AA220
        public void get_Response(){} // RVA: 0x7FFE817AE360
    }

    public class WebExceptionMapping : Object
    {
        // ── Methods ──
        public void GetWebStatusString(){} // RVA: 0x7FFE87661C80
        public void .cctor(){} // RVA: 0x7FFE87661E70
    }

    public class WebHeaderCollection : NameValueCollection
    {
        public int ApproxAveHeaderLineSize;
        public int ApproxHighAvgNumHeaders;
        public System.Net.HeaderInfoTable HInfo;
        public string[] m_CommonHeaders; // 0x68

        // ── Methods ──
        public void NormalizeCommonHeaders(){} // RVA: 0x7FFE87661F30
        public void get_InnerCollection(){} // RVA: 0x7FFE876620C0
        public void AllowMultiValues(){} // RVA: 0x7FFE876621C0
        public void get_AllowHttpRequestHeader(){} // RVA: 0x7FFE876622A0
        public void Remove(){} // RVA: 0x7FFE87663790 | overloaded x2
        public void AddInternal(){} // RVA: 0x7FFE87662440
        public void ChangeInternal(){} // RVA: 0x7FFE876624B0
        public void RemoveInternal(){} // RVA: 0x7FFE87662520
        public void CheckBadChars(){} // RVA: 0x7FFE87662580
        public void ContainsNonAsciiChars(){} // RVA: 0x7FFE87662B70
        public void ThrowOnRestrictedHeader(){} // RVA: 0x7FFE87662BE0
        public void Add(){} // RVA: 0x7FFE87663000 | overloaded x2
        public void Set(){} // RVA: 0x7FFE87663300
        public void SetInternal(){} // RVA: 0x7FFE87663550
        public void GetValues(){} // RVA: 0x7FFE87664D80 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE87663B10
        public void GetAsString(){} // RVA: 0x7FFE87663B70
        public void .ctor(){} // RVA: 0x7FFE87664020 | overloaded x3
        public void OnDeserialization(){} // RVA: 0x7FFE810FB310
        public void GetObjectData(){} // RVA: 0x7FFE87664330
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87664920
        public void Get(){} // RVA: 0x7FFE87664D30 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE87664C80
        public void get_Count(){} // RVA: 0x7FFE87664CF0
        public void GetKey(){} // RVA: 0x7FFE87664DD0
        public void get_AllKeys(){} // RVA: 0x7FFE87664E20
        public void .cctor(){} // RVA: 0x7FFE87664E70
    }

    public class WebOperation : Object
    {
        public System.Net.HttpWebRequest _request; // 0x10
        public System.Net.WebConnection _connection; // 0x18
        public System.Net.ServicePoint _servicePoint; // 0x20
        public System.Net.BufferOffsetSize _writeBuffer; // 0x28
        public bool _isNtlmChallenge; // 0x30
        public int ID; // 0x34
        public System.Threading.CancellationTokenSource cts; // 0x38
        public System.Net.WebCompletionSource`1<System.Net.WebRequestStream> requestTask; // 0x40
        public System.Net.WebCompletionSource`1<System.Net.WebRequestStream> requestWrittenTask; // 0x48

        // ── Methods ──
        public void get_Request(){} // RVA: 0x7FFE81116380
        public void get_Connection(){} // RVA: 0x7FFE810FE7C0
        public void set_Connection(){} // RVA: 0x7FFE81161E80
        public void get_ServicePoint(){} // RVA: 0x7FFE811290C0
        public void set_ServicePoint(){} // RVA: 0x7FFE811290D0
        public void get_WriteBuffer(){} // RVA: 0x7FFE81129130
        public void get_IsNtlmChallenge(){} // RVA: 0x7FFE81121450
        public void .ctor(){} // RVA: 0x7FFE876BE870
        public void get_Aborted(){} // RVA: 0x7FFE876BECC0
        public void get_Closed(){} // RVA: 0x7FFE876BED20
        public void Abort(){} // RVA: 0x7FFE876BED80
        public void Close(){} // RVA: 0x7FFE876BEDE0
        public void SetCanceled(){} // RVA: 0x7FFE876BEE80
        public void SetError(){} // RVA: 0x7FFE876BEF90
        public void SetDisposed(){} // RVA: 0x7FFE876BF040
        public void CheckDisposed(){} // RVA: 0x7FFE876BF260
        public void ThrowIfDisposed(){} // RVA: 0x7FFE876BF3B0 | overloaded x2
        public void ThrowIfClosedOrDisposed(){} // RVA: 0x7FFE876BF500 | overloaded x2
        public void CheckThrowDisposed(){} // RVA: 0x7FFE876BF600
        public void RegisterRequest(){} // RVA: 0x7FFE876BF680
        public void SetPriorityRequest(){} // RVA: 0x7FFE876BFB00
        public void GetRequestStream(){} // RVA: 0x7FFE876BFD00
        public void GetRequestStreamInternal(){} // RVA: 0x7FFE876BFE90
        public void get_WriteStream(){} // RVA: 0x7FFE876BFEE0
        public void GetResponseStream(){} // RVA: 0x7FFE876BFF40
        public void get_Finished(){} // RVA: 0x7FFE811C3500
        public void Run(){} // RVA: 0x7FFE876BFF90
        public void CompleteRequestWritten(){} // RVA: 0x7FFE876C0170
        public void Finish(){} // RVA: 0x7FFE876C0200
        public void <RegisterRequest>b__48_0(){} // RVA: 0x7FFE876C0610
    }

    public class WebProxy : Object
    {
        public bool _UseRegistry; // 0x10
        public bool _BypassOnLocal; // 0x11
        public bool m_EnableAutoproxy; // 0x12

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87682EA0 | overloaded x4
        public void get_Credentials(){} // RVA: 0x7FFE81129130
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFE876813E0
        public void set_UseDefaultCredentials(){} // RVA: 0x7FFE87681450
        public void GetProxy(){} // RVA: 0x7FFE876814C0
        public void UpdateRegExList(){} // RVA: 0x7FFE87681720
        public void IsMatchInBypassList(){} // RVA: 0x7FFE876819D0
        public void IsLocal(){} // RVA: 0x7FFE87681BF0
        public void IsLocalInProxyHash(){} // RVA: 0x7FFE876821A0
        public void IsBypassed(){} // RVA: 0x7FFE87682290
        public void IsBypassedManual(){} // RVA: 0x7FFE876823D0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87667F80
        public void GetObjectData(){} // RVA: 0x7FFE87682950
        public void get_ScriptEngine(){} // RVA: 0x7FFE81178740
        public void CreateDefaultProxy(){} // RVA: 0x7FFE87682E60
        public void UnsafeUpdateFromRegistry(){} // RVA: 0x7FFE814B8390
        public void GetProxyAuto(){} // RVA: 0x7FFE87682EB0
        public void IsBypassedAuto(){} // RVA: 0x7FFE87682FC0
        public void AreAllBypassed(){} // RVA: 0x7FFE87683060
        public void ProxyUri(){} // RVA: 0x7FFE87683200
    }

    public class WebReadStream : Stream
    {
        public System.Net.WebOperation _operation; // 0x28
        public System.IO.Stream _innerStream; // 0x30
        public bool disposed; // 0x38
        public object field_3; // 0x57E
        public object field_4; // 0x57F
        public object field_5; // 0x580
        public object field_6; // 0x581

        // ── Methods ──
        public void get_Operation(){} // RVA: 0x7FFE81129130
        public void get_InnerStream(){} // RVA: 0x7FFE8144E200
        public void .ctor(){} // RVA: 0x7FFE876C1480
        public void get_Length(){} // RVA: 0x7FFE876C1590
        public void get_Position(){} // RVA: 0x7FFE876C15D0
        public void set_Position(){} // RVA: 0x7FFE876C1610
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanRead(){} // RVA: 0x7FFE811E0850
        public void get_CanWrite(){} // RVA: 0x7FFE810FB320
        public void SetLength(){} // RVA: 0x7FFE876C1650
        public void Seek(){} // RVA: 0x7FFE876C1690
        public void Write(){} // RVA: 0x7FFE876C16D0
        public void Flush(){} // RVA: 0x7FFE876C1710
        public void GetException(){} // RVA: 0x7FFE876C1750
        public void Read(){} // RVA: 0x7FFE876C18F0
        public void BeginRead(){} // RVA: 0x7FFE876C1BB0
        public void EndRead(){} // RVA: 0x7FFE876C1E30
        public void ReadAsync(){} // RVA: 0x7FFE876C1F00
        public void ProcessReadAsync(){}
        public void FinishReading(){} // RVA: 0x7FFE876AC2A0
        public void Dispose(){} // RVA: 0x7FFE876C2180
    }

    public class WebRequest : MarshalByRefObject
    {
        public int DefaultTimeout;
        public System.Collections.ArrayList s_PrefixList;
        public object s_InternalSyncObject; // 0x8
        public Queue s_DefaultTimerQueue; // 0x10
        public 0x6653B294 m_AuthenticationLevel; // 0x18
        public 0x664C6FEC m_ImpersonationLevel; // 0x1C
        public System.Net.Cache.RequestCachePolicy m_CachePolicy; // 0x20
        public System.Net.Cache.RequestCacheProtocol m_CacheProtocol; // 0x28
        public System.Net.Cache.RequestCacheBinding m_CacheBinding; // 0x30
        public DesignerWebRequestCreate webRequestCreate; // 0x18
        public System.Net.IWebProxy s_DefaultWebProxy; // 0x20
        public bool s_DefaultWebProxyInitialized; // 0x28
        public object field_12; // 0x45C
        public object field_13; // 0x45D
        public object field_14; // 0x45E
        public object field_15; // 0x45F

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFE87665B60
        public void Create(){} // RVA: 0x7FFE876661F0 | overloaded x3
        public void get_PrefixList(){} // RVA: 0x7FFE876662C0
        public void PopulatePrefixList(){} // RVA: 0x7FFE87666540
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87666770
        public void GetObjectData(){} // RVA: 0x7FFE810FB310
        public void get_DefaultCachePolicy(){} // RVA: 0x7FFE876667A0
        public void set_CachePolicy(){} // RVA: 0x7FFE87666820
        public void InternalSetCachePolicy(){} // RVA: 0x7FFE87666820
        public void get_Method(){} // RVA: 0x7FFE87666900
        public void set_Method(){} // RVA: 0x7FFE87666930
        public void get_RequestUri(){} // RVA: 0x7FFE87666960
        public void set_ConnectionGroupName(){} // RVA: 0x7FFE87666990
        public void get_Headers(){} // RVA: 0x7FFE876669C0
        public void get_ContentLength(){} // RVA: 0x7FFE876669F0
        public void set_ContentLength(){} // RVA: 0x7FFE87666A20
        public void get_Credentials(){} // RVA: 0x7FFE87666A50
        public void set_Credentials(){} // RVA: 0x7FFE87666A80
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFE87666AB0
        public void get_Proxy(){} // RVA: 0x7FFE87666AE0
        public void set_Proxy(){} // RVA: 0x7FFE87666B10
        public void set_PreAuthenticate(){} // RVA: 0x7FFE87666B40
        public void get_Timeout(){} // RVA: 0x7FFE87666B70
        public void set_Timeout(){} // RVA: 0x7FFE87666BA0
        public void GetResponse(){} // RVA: 0x7FFE87666BD0
        public void BeginGetResponse(){} // RVA: 0x7FFE87666C00
        public void EndGetResponse(){} // RVA: 0x7FFE87666C30
        public void BeginGetRequestStream(){} // RVA: 0x7FFE87666C60
        public void EndGetRequestStream(){} // RVA: 0x7FFE87666C90
        public void GetRequestStreamAsync(){} // RVA: 0x7FFE87666CC0
        public void GetResponseAsync(){} // RVA: 0x7FFE87666FD0
        public void SafeCaptureIdenity(){} // RVA: 0x7FFE876672E0
        public void Abort(){} // RVA: 0x7FFE87667330
        public void get_CacheProtocol(){} // RVA: 0x7FFE81129130
        public void set_CacheProtocol(){} // RVA: 0x7FFE810FCE90
        public void get_InternalDefaultWebProxy(){} // RVA: 0x7FFE87667360
        public void .cctor(){} // RVA: 0x7FFE876675E0
        public void <GetRequestStreamAsync>b__78_0(){} // RVA: 0x7FFE87667740
        public void <GetResponseAsync>b__79_0(){} // RVA: 0x7FFE87667870
    }

    public class WebRequestPrefixElement : Object
    {
        public string Prefix; // 0x10

        // ── Methods ──
        public void get_Creator(){} // RVA: 0x7FFE8765F370
        public void set_Creator(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
    }

    public class WebRequestStream : WebConnectionStream
    {
        public byte[] crlf;
        public System.IO.MemoryStream writeBuffer; // 0x60
        public bool requestWritten; // 0x68
        public bool allowBuffering; // 0x69
        public bool sendChunked; // 0x6A
        public System.Net.WebCompletionSource pendingWrite; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876C2850
        public void get_InnerStream(){} // RVA: 0x7FFE8179C860
        public void get_KeepAlive(){} // RVA: 0x7FFE813A1D80
        public void get_CanRead(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE811E0850
        public void get_HasWriteBuffer(){} // RVA: 0x7FFE876C2A40
        public void get_WriteBufferLength(){} // RVA: 0x7FFE876C2A70
        public void GetWriteBuffer(){} // RVA: 0x7FFE876C2AD0
        public void FinishWriting(){} // RVA: 0x7FFE876C2C00
        public void WriteAsync(){} // RVA: 0x7FFE876C2E10
        public void WriteAsyncInner(){} // RVA: 0x7FFE876C3100
        public void ProcessWrite(){} // RVA: 0x7FFE876C33D0
        public void CheckWriteOverflow(){} // RVA: 0x7FFE876C3670
        public void Initialize(){} // RVA: 0x7FFE876C3720
        public void SetHeadersAsync(){} // RVA: 0x7FFE876C3940
        public void WriteRequestAsync(){} // RVA: 0x7FFE876C3B80
        public void WriteChunkTrailer_inner(){} // RVA: 0x7FFE876C3DA0
        public void WriteChunkTrailer(){} // RVA: 0x7FFE876C3FB0
        public void KillBuffer(){} // RVA: 0x7FFE865AB620
        public void ReadAsync(){} // RVA: 0x7FFE876C4170
        public void TryReadFromBufferedContent(){} // RVA: 0x7FFE876C4220
        public void Close_internal(){} // RVA: 0x7FFE876C4260
        public void .cctor(){} // RVA: 0x7FFE876C45E0
    }

    public class WebResponse : MarshalByRefObject
    {
        public bool m_IsCacheFresh; // 0x18
        public bool m_IsFromCache; // 0x19
        public object field_2; // 0x46C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87667F80
        public void GetObjectData(){} // RVA: 0x7FFE810FB310
        public void Close(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE87668020 | overloaded x2
        public void get_IsFromCache(){} // RVA: 0x7FFE814B3730
        public void GetResponseStream(){} // RVA: 0x7FFE87668050
        public void get_ResponseUri(){} // RVA: 0x7FFE87668080
        public void get_Headers(){} // RVA: 0x7FFE876680B0
    }

    public class WebResponseStream : WebConnectionStream
    {
        public System.Net.WebReadStream innerStream; // 0x60
        public bool nextReadCalled; // 0x68
        public bool bufferedEntireContent; // 0x69
        public System.Net.WebCompletionSource pendingRead; // 0x70
        public object locker; // 0x78
        public int nestedRead; // 0x80
        public bool read_eof; // 0x84
        public System.Net.WebRequestStream _requestStream; // 0x88
        public System.Net.WebHeaderCollection _headers; // 0x90
        public 0x66532CDC _statusCode; // 0x98

        // ── Methods ──
        public void get_RequestStream(){} // RVA: 0x7FFE8113A010
        public void get_Headers(){} // RVA: 0x7FFE8154EB60
        public void set_Headers(){} // RVA: 0x7FFE818CE320
        public void get_StatusCode(){} // RVA: 0x7FFE82B06A40
        public void set_StatusCode(){} // RVA: 0x7FFE82B06FA0
        public void get_StatusDescription(){} // RVA: 0x7FFE8179C860
        public void set_StatusDescription(){} // RVA: 0x7FFE8171B4D0
        public void get_Version(){} // RVA: 0x7FFE817AB5E0
        public void set_Version(){} // RVA: 0x7FFE81857260
        public void get_KeepAlive(){} // RVA: 0x7FFE824A0700
        public void set_KeepAlive(){} // RVA: 0x7FFE824A0BA0
        public void .ctor(){} // RVA: 0x7FFE876C8080
        public void get_CanRead(){} // RVA: 0x7FFE811E0850
        public void get_CanWrite(){} // RVA: 0x7FFE810FB320
        public void get_ChunkedRead(){} // RVA: 0x7FFE8111C4C0
        public void set_ChunkedRead(){} // RVA: 0x7FFE8111C4D0
        public void ReadAsync(){} // RVA: 0x7FFE876C81A0
        public void ProcessRead(){} // RVA: 0x7FFE876C8400
        public void TryReadFromBufferedContent(){} // RVA: 0x7FFE876C8830
        public void get_ExpectContent(){} // RVA: 0x7FFE876C8960
        public void Initialize(){} // RVA: 0x7FFE876C8A20
        public void ReadAllAsyncInner(){} // RVA: 0x7FFE876C9A10
        public void ReadAllAsync(){} // RVA: 0x7FFE876C9C10
        public void WriteAsync(){} // RVA: 0x7FFE876C9E50
        public void Close_internal(){} // RVA: 0x7FFE876C9EF0
        public void GetReadException(){} // RVA: 0x7FFE876C9FE0
        public void InitReadAsync(){} // RVA: 0x7FFE876CA360
        public void GetResponse(){} // RVA: 0x7FFE876CA580
    }

    public class WebUtility : Object
    {
        public char[] _htmlEntityEndingChars;

        // ── Methods ──
        public void HtmlEncode(){} // RVA: 0x7FFE87668210 | overloaded x2
        public void IndexOfHtmlEncodingChars(){} // RVA: 0x7FFE87668630
        public void get_HtmlEncodeConformance(){} // RVA: 0x7FFE87668740
        public void UrlEncode(){} // RVA: 0x7FFE87668D50 | overloaded x3
        public void UrlDecodeInternal(){} // RVA: 0x7FFE87668E80
        public void UrlDecode(){} // RVA: 0x7FFE876691E0
        public void GetNextUnicodeScalarValueFromUtf16Surrogate(){} // RVA: 0x7FFE87669260
        public void HexToInt(){} // RVA: 0x7FFE87669330
        public void IntToHex(){} // RVA: 0x7FFE87669370
        public void IsUrlSafeChar(){} // RVA: 0x7FFE87669380
        public void ValidateUrlEncodingParameters(){} // RVA: 0x7FFE876693F0
        public void .cctor(){} // RVA: 0x7FFE87669510
    }

}