// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 18
// Methods: 346

namespace ThirdParty.DotNet.System.Net
{
    public class WebCompletionSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B780A0
    }

    public class WebCompletionSource`1
    {
        public System.Threading.Tasks.TaskCompletionSource`1<Result<T>> completion;
        public Result<T> currentResult;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25130
        public void get_CurrentResult(){} // RVA: 0xCD60
        public void get_Task(){} // RVA: 0xCD60
        public void TrySetCompleted(){} // RVA: 0xDBE0 | overloaded x2
        public void TrySetCanceled(){} // RVA: 0xDE40 | overloaded x2
        public void TrySetException(){} // RVA: 0xDE40
        public void ThrowOnError(){} // RVA: 0x24A50
        public void WaitForCompletion(){} // RVA: 0xCD60
    }

    public class WebCompletionSource`1
    {
        public System.Threading.Tasks.TaskCompletionSource`1<Result<object>> completion; // 0x10
        public Result<object> currentResult; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B5D690
        public void get_CurrentResult(){} // RVA: 0x2E07C0
        public void get_Task(){} // RVA: 0xB2ECF0
        public void TrySetCompleted(){} // RVA: 0x4B5D8E0 | overloaded x2
        public void TrySetCanceled(){} // RVA: 0x4B5DAE0 | overloaded x2
        public void TrySetException(){} // RVA: 0x4B5DD00
        public void ThrowOnError(){} // RVA: 0x4B5DF20
        public void WaitForCompletion(){} // RVA: 0x4B5E3A0
    }

    public class WebConnection
    {
        public System.Net.NetworkCredential ntlm_credentials; // 0x10
        public bool ntlm_authenticated; // 0x18
        public bool unsafe_sharing; // 0x19
        public System.IO.Stream networkStream; // 0x20
        public System.Net.Sockets.Socket socket; // 0x28
        public Mono.Net.Security.MonoTlsStream monoTlsStream; // 0x30

        // ── Methods ──
        public void get_ServicePoint(){} // RVA: 0x358730
        public void .ctor(){} // RVA: 0x358740
        public void CanReuse(){} // RVA: 0x6B780E0
        public void CheckReusable(){} // RVA: 0x6B78110
        public void Connect(){} // RVA: 0x6B78160
        public void CreateStream(){} // RVA: 0x6B783E0
        public void InitConnection(){} // RVA: 0x6B78650
        public void GetException(){} // RVA: 0x6B788A0
        public void ReadLine(){} // RVA: 0x6B78AC0
        public void CanReuseConnection(){} // RVA: 0x6B78D20
        public void PrepareSharingNtlm(){} // RVA: 0x6B791D0
        public void Reset(){} // RVA: 0x6B79480
        public void Close(){} // RVA: 0x6B79670
        public void CloseSocket(){} // RVA: 0x6B797C0
        public void get_Closed(){} // RVA: 0x6B79B00
        public void get_IdleSince(){} // RVA: 0x3A5500
        public void StartOperation(){} // RVA: 0x6B79B10
        public void Continue(){} // RVA: 0x6B79DF0
        public void Dispose(){} // RVA: 0x6B7A050 | overloaded x2
        public void ResetNtlm(){} // RVA: 0x6B7A070
        public void get_NtlmAuthenticated(){} // RVA: 0x2F84E0
        public void set_NtlmAuthenticated(){} // RVA: 0x2F84F0
        public void get_NtlmCredential(){} // RVA: 0x2F8380
        public void set_NtlmCredential(){} // RVA: 0x2DEE30
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x6B93D0
        public void set_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0xF43D70
    }

    public class WebConnectionStream
    {
        public bool closed; // 0x28
        public bool disposed; // 0x29
        public object locker; // 0x30
        public int read_timeout; // 0x38
        public int write_timeout; // 0x3C
        public bool IgnoreIOErrors; // 0x40
        public System.Net.HttpWebRequest <Request>k__BackingField; // 0x48
        public System.Net.WebConnection <Connection>k__BackingField; // 0x50
        public System.Net.WebOperation <Operation>k__BackingField; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B7BEA0
        public void get_Request(){} // RVA: 0x358730
        public void get_Connection(){} // RVA: 0x37E0E0
        public void get_Operation(){} // RVA: 0x3A5500
        public void get_ServicePoint(){} // RVA: 0x6B7C0B0
        public void get_CanTimeout(){} // RVA: 0x3C2850
        public void get_ReadTimeout(){} // RVA: 0xFDC9F0
        public void set_ReadTimeout(){} // RVA: 0x6B7C0D0
        public void get_WriteTimeout(){} // RVA: 0x891AF0
        public void set_WriteTimeout(){} // RVA: 0x6B7C140
        public void GetException(){} // RVA: 0x6B7C1B0
        public void TryReadFromBufferedContent(){}
        public void Read(){} // RVA: 0x6B7C350
        public void BeginRead(){} // RVA: 0x6B7C610
        public void EndRead(){} // RVA: 0x6B7C890
        public void BeginWrite(){} // RVA: 0x6B7C960
        public void EndWrite(){} // RVA: 0x6B7CB90
        public void Write(){} // RVA: 0x6B7CC40
        public void Flush(){} // RVA: 0x2DD310
        public void FlushAsync(){} // RVA: 0x6B7CE80
        public void InternalClose(){} // RVA: 0x6B7CF30
        public void Close_internal(){} // RVA: 0x24B10
        public void Close(){} // RVA: 0x6B7CF40
        public void Seek(){} // RVA: 0x6B7CF60
        public void SetLength(){} // RVA: 0x6B7CFB0
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_Length(){} // RVA: 0x6B7D000
        public void get_Position(){} // RVA: 0x6B7D050
        public void set_Position(){} // RVA: 0x6B7D0A0
    }

    public class WebConnectionTunnel
    {
        public System.Net.HttpWebRequest <Request>k__BackingField; // 0x10
        public System.Uri <ConnectUri>k__BackingField; // 0x18
        public System.Net.HttpWebRequest connectRequest; // 0x20
        public 0x65859098 ntlmAuthState; // 0x28
        public bool <Success>k__BackingField; // 0x2C
        public bool <CloseConnection>k__BackingField; // 0x2D
        public int <StatusCode>k__BackingField; // 0x30
        public string <StatusDescription>k__BackingField; // 0x38
        public string[] <Challenge>k__BackingField; // 0x40
        public System.Net.WebHeaderCollection <Headers>k__BackingField; // 0x48

        // ── Methods ──
        public void get_Request(){} // RVA: 0x2F8380
        public void get_ConnectUri(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_Success(){} // RVA: 0x3BC230
        public void set_Success(){} // RVA: 0x3BC240
        public void get_CloseConnection(){} // RVA: 0x4FDE20
        public void set_CloseConnection(){} // RVA: 0x4FC950
        public void get_StatusCode(){} // RVA: 0x338CD0
        public void set_StatusCode(){} // RVA: 0x338CE0
        public void set_StatusDescription(){} // RVA: 0x49B830
        public void get_Challenge(){} // RVA: 0x35A740
        public void set_Challenge(){} // RVA: 0x305200
        public void get_Headers(){} // RVA: 0x358730
        public void set_Headers(){} // RVA: 0x358740
        public void get_ProxyVersion(){} // RVA: 0x37E0E0
        public void set_ProxyVersion(){} // RVA: 0x4354D0
        public void get_Data(){} // RVA: 0x3A5500
        public void set_Data(){} // RVA: 0x3A5510
        public void Initialize(){} // RVA: 0x6B7D0F0
        public void ReadHeaders(){} // RVA: 0x6B7D370
        public void FlushContents(){} // RVA: 0x6B7D5D0
    }

    public class WebException
    {
        public 0x658561D8 m_Status; // 0x90
        public System.Net.WebResponse m_Response; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B22900 | overloaded x10
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6B22990
        public void GetObjectData(){} // RVA: 0x6B21340
        public void get_Status(){} // RVA: 0x6AFD40
        public void get_Response(){} // RVA: 0xA1C8C0
    }

    public class WebExceptionMapping
    {
        // ── Methods ──
        public void GetWebStatusString(){} // RVA: 0x6B229C0
        public void .cctor(){} // RVA: 0x6B22BB0
    }

    public class WebHeaderCollection
    {
        public int ApproxAveHeaderLineSize;
        public int ApproxHighAvgNumHeaders;
        public System.Net.HeaderInfoTable HInfo;
        public string[] m_CommonHeaders; // 0x68

        // ── Methods ──
        public void NormalizeCommonHeaders(){} // RVA: 0x6B22C70
        public void get_InnerCollection(){} // RVA: 0x6B22E00
        public void AllowMultiValues(){} // RVA: 0x6B22F00
        public void get_AllowHttpRequestHeader(){} // RVA: 0x6B22FE0
        public void Remove(){} // RVA: 0x6B244D0 | overloaded x2
        public void AddInternal(){} // RVA: 0x6B23180
        public void ChangeInternal(){} // RVA: 0x6B231F0
        public void RemoveInternal(){} // RVA: 0x6B23260
        public void CheckBadChars(){} // RVA: 0x6B232C0
        public void ContainsNonAsciiChars(){} // RVA: 0x6B238B0
        public void ThrowOnRestrictedHeader(){} // RVA: 0x6B23920
        public void Add(){} // RVA: 0x6B23D40 | overloaded x2
        public void Set(){} // RVA: 0x6B24040
        public void SetInternal(){} // RVA: 0x6B24290
        public void GetValues(){} // RVA: 0x6B25AC0 | overloaded x2
        public void ToString(){} // RVA: 0x6B24850
        public void GetAsString(){} // RVA: 0x6B248B0
        public void .ctor(){} // RVA: 0x6B24D60 | overloaded x3
        public void OnDeserialization(){} // RVA: 0x2DD310
        public void GetObjectData(){} // RVA: 0x6B25070
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6B25660
        public void Get(){} // RVA: 0x6B25A70 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x6B259C0
        public void get_Count(){} // RVA: 0x6B25A30
        public void GetKey(){} // RVA: 0x6B25B10
        public void get_AllKeys(){} // RVA: 0x6B25B60
        public void .cctor(){} // RVA: 0x6B25BB0
    }

    public class WebOperation
    {
        public System.Net.HttpWebRequest <Request>k__BackingField; // 0x10
        public System.Net.WebConnection <Connection>k__BackingField; // 0x18
        public System.Net.ServicePoint <ServicePoint>k__BackingField; // 0x20
        public System.Net.BufferOffsetSize <WriteBuffer>k__BackingField; // 0x28
        public bool <IsNtlmChallenge>k__BackingField; // 0x30
        public int ID; // 0x34
        public System.Threading.CancellationTokenSource cts; // 0x38
        public System.Net.WebCompletionSource`1<System.Net.WebRequestStream> requestTask; // 0x40
        public System.Net.WebCompletionSource`1<System.Net.WebRequestStream> requestWrittenTask; // 0x48

        // ── Methods ──
        public void get_Request(){} // RVA: 0x2F8380
        public void get_Connection(){} // RVA: 0x2E07C0
        public void set_Connection(){} // RVA: 0x343E80
        public void get_ServicePoint(){} // RVA: 0x30B0C0
        public void set_ServicePoint(){} // RVA: 0x30B0D0
        public void get_WriteBuffer(){} // RVA: 0x30B130
        public void get_IsNtlmChallenge(){} // RVA: 0x303450
        public void .ctor(){} // RVA: 0x6B7F5C0
        public void get_Aborted(){} // RVA: 0x6B7FA10
        public void get_Closed(){} // RVA: 0x6B7FA70
        public void Abort(){} // RVA: 0x6B7FAD0
        public void Close(){} // RVA: 0x6B7FB30
        public void SetCanceled(){} // RVA: 0x6B7FBD0
        public void SetError(){} // RVA: 0x6B7FCE0
        public void SetDisposed(){} // RVA: 0x6B7FD90
        public void CheckDisposed(){} // RVA: 0x6B7FFB0
        public void ThrowIfDisposed(){} // RVA: 0x6B80100 | overloaded x2
        public void ThrowIfClosedOrDisposed(){} // RVA: 0x6B80250 | overloaded x2
        public void CheckThrowDisposed(){} // RVA: 0x6B80350
        public void RegisterRequest(){} // RVA: 0x6B803D0
        public void SetPriorityRequest(){} // RVA: 0x6B80850
        public void GetRequestStream(){} // RVA: 0x6B80A50
        public void GetRequestStreamInternal(){} // RVA: 0x6B80BE0
        public void get_WriteStream(){} // RVA: 0x6B80C30
        public void GetResponseStream(){} // RVA: 0x6B80C90
        public void get_Finished(){} // RVA: 0x3A5500
        public void Run(){} // RVA: 0x6B80CE0
        public void CompleteRequestWritten(){} // RVA: 0x6B80EC0
        public void Finish(){} // RVA: 0x6B80F50
        public void <RegisterRequest>b__48_0(){} // RVA: 0x6B81360
    }

    public class WebProxy
    {
        public bool _UseRegistry; // 0x10
        public bool _BypassOnLocal; // 0x11
        public bool m_EnableAutoproxy; // 0x12

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B43BF0 | overloaded x4
        public void get_Credentials(){} // RVA: 0x30B130
        public void get_UseDefaultCredentials(){} // RVA: 0x6B42130
        public void set_UseDefaultCredentials(){} // RVA: 0x6B421A0
        public void GetProxy(){} // RVA: 0x6B42210
        public void UpdateRegExList(){} // RVA: 0x6B42470
        public void IsMatchInBypassList(){} // RVA: 0x6B42720
        public void IsLocal(){} // RVA: 0x6B42940
        public void IsLocalInProxyHash(){} // RVA: 0x6B42EF0
        public void IsBypassed(){} // RVA: 0x6B42FE0
        public void IsBypassedManual(){} // RVA: 0x6B43120
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6B28CC0
        public void GetObjectData(){} // RVA: 0x6B436A0
        public void get_ScriptEngine(){} // RVA: 0x35A740
        public void CreateDefaultProxy(){} // RVA: 0x6B43BB0
        public void UnsafeUpdateFromRegistry(){} // RVA: 0x6BD7E0
        public void GetProxyAuto(){} // RVA: 0x6B43C00
        public void IsBypassedAuto(){} // RVA: 0x6B43D10
        public void AreAllBypassed(){} // RVA: 0x6B43DB0
        public void ProxyUri(){} // RVA: 0x6B43F50
    }

    public class WebReadStream
    {
        public System.Net.WebOperation <Operation>k__BackingField; // 0x28
        public System.IO.Stream <InnerStream>k__BackingField; // 0x30
        public bool disposed; // 0x38

        // ── Methods ──
        public void get_Operation(){} // RVA: 0x30B130
        public void get_InnerStream(){} // RVA: 0x6374D0
        public void .ctor(){} // RVA: 0x6B821D0
        public void get_Length(){} // RVA: 0x6B822E0
        public void get_Position(){} // RVA: 0x6B82320
        public void set_Position(){} // RVA: 0x6B82360
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanRead(){} // RVA: 0x3C2850
        public void get_CanWrite(){} // RVA: 0x2DD320
        public void SetLength(){} // RVA: 0x6B823A0
        public void Seek(){} // RVA: 0x6B823E0
        public void Write(){} // RVA: 0x6B82420
        public void Flush(){} // RVA: 0x6B82460
        public void GetException(){} // RVA: 0x6B824A0
        public void Read(){} // RVA: 0x6B82640
        public void BeginRead(){} // RVA: 0x6B82900
        public void EndRead(){} // RVA: 0x6B82B80
        public void ReadAsync(){} // RVA: 0x6B82C50
        public void ProcessReadAsync(){}
        public void FinishReading(){} // RVA: 0x6B6CFF0
        public void Dispose(){} // RVA: 0x6B82ED0
    }

    public class WebRequest
    {
        public int DefaultTimeout;
        public System.Collections.ArrayList s_PrefixList;
        public object s_InternalSyncObject; // 0x8
        public Queue s_DefaultTimerQueue; // 0x10
        public 0x6585D1E8 m_AuthenticationLevel; // 0x18
        public 0x657E9048 m_ImpersonationLevel; // 0x1C
        public System.Net.Cache.RequestCachePolicy m_CachePolicy; // 0x20
        public System.Net.Cache.RequestCacheProtocol m_CacheProtocol; // 0x28
        public System.Net.Cache.RequestCacheBinding m_CacheBinding; // 0x30
        public DesignerWebRequestCreate webRequestCreate; // 0x18
        public System.Net.IWebProxy s_DefaultWebProxy; // 0x20
        public bool s_DefaultWebProxyInitialized; // 0x28

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x6B268A0
        public void Create(){} // RVA: 0x6B26F30 | overloaded x3
        public void get_PrefixList(){} // RVA: 0x6B27000
        public void PopulatePrefixList(){} // RVA: 0x6B27280
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6B274B0
        public void GetObjectData(){} // RVA: 0x2DD310
        public void get_DefaultCachePolicy(){} // RVA: 0x6B274E0
        public void set_CachePolicy(){} // RVA: 0x6B27560
        public void InternalSetCachePolicy(){} // RVA: 0x6B27560
        public void get_Method(){} // RVA: 0x6B27640
        public void set_Method(){} // RVA: 0x6B27670
        public void get_RequestUri(){} // RVA: 0x6B276A0
        public void set_ConnectionGroupName(){} // RVA: 0x6B276D0
        public void get_Headers(){} // RVA: 0x6B27700
        public void get_ContentLength(){} // RVA: 0x6B27730
        public void set_ContentLength(){} // RVA: 0x6B27760
        public void get_Credentials(){} // RVA: 0x6B27790
        public void set_Credentials(){} // RVA: 0x6B277C0
        public void get_UseDefaultCredentials(){} // RVA: 0x6B277F0
        public void get_Proxy(){} // RVA: 0x6B27820
        public void set_Proxy(){} // RVA: 0x6B27850
        public void set_PreAuthenticate(){} // RVA: 0x6B27880
        public void get_Timeout(){} // RVA: 0x6B278B0
        public void set_Timeout(){} // RVA: 0x6B278E0
        public void GetResponse(){} // RVA: 0x6B27910
        public void BeginGetResponse(){} // RVA: 0x6B27940
        public void EndGetResponse(){} // RVA: 0x6B27970
        public void BeginGetRequestStream(){} // RVA: 0x6B279A0
        public void EndGetRequestStream(){} // RVA: 0x6B279D0
        public void GetRequestStreamAsync(){} // RVA: 0x6B27A00
        public void GetResponseAsync(){} // RVA: 0x6B27D10
        public void SafeCaptureIdenity(){} // RVA: 0x6B28020
        public void Abort(){} // RVA: 0x6B28070
        public void get_CacheProtocol(){} // RVA: 0x30B130
        public void set_CacheProtocol(){} // RVA: 0x2DEE90
        public void get_InternalDefaultWebProxy(){} // RVA: 0x6B280A0
        public void .cctor(){} // RVA: 0x6B28320
        public void <GetRequestStreamAsync>b__78_0(){} // RVA: 0x6B28480
        public void <GetResponseAsync>b__79_0(){} // RVA: 0x6B285B0
    }

    public class WebRequestPrefixElement
    {
        public string Prefix; // 0x10

        // ── Methods ──
        public void get_Creator(){} // RVA: 0x6B200B0
        public void set_Creator(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0xF19AE0
    }

    public class WebRequestStream
    {
        public byte[] crlf;
        public System.IO.MemoryStream writeBuffer; // 0x60
        public bool requestWritten; // 0x68
        public bool allowBuffering; // 0x69
        public bool sendChunked; // 0x6A
        public System.Net.WebCompletionSource pendingWrite; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B835A0
        public void get_InnerStream(){} // RVA: 0xA085E0
        public void get_KeepAlive(){} // RVA: 0x5A6180
        public void get_CanRead(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x3C2850
        public void get_HasWriteBuffer(){} // RVA: 0x6B83790
        public void get_WriteBufferLength(){} // RVA: 0x6B837C0
        public void GetWriteBuffer(){} // RVA: 0x6B83820
        public void FinishWriting(){} // RVA: 0x6B83950
        public void WriteAsync(){} // RVA: 0x6B83B60
        public void WriteAsyncInner(){} // RVA: 0x6B83E50
        public void ProcessWrite(){} // RVA: 0x6B84120
        public void CheckWriteOverflow(){} // RVA: 0x6B843C0
        public void Initialize(){} // RVA: 0x6B84470
        public void SetHeadersAsync(){} // RVA: 0x6B84690
        public void WriteRequestAsync(){} // RVA: 0x6B848D0
        public void WriteChunkTrailer_inner(){} // RVA: 0x6B84AF0
        public void WriteChunkTrailer(){} // RVA: 0x6B84D00
        public void KillBuffer(){} // RVA: 0x5A6A920
        public void ReadAsync(){} // RVA: 0x6B84EC0
        public void TryReadFromBufferedContent(){} // RVA: 0x6B84F70
        public void Close_internal(){} // RVA: 0x6B84FB0
        public void .cctor(){} // RVA: 0x6B85330
    }

    public class WebResponse
    {
        public bool m_IsCacheFresh; // 0x18
        public bool m_IsFromCache; // 0x19

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6B28CC0
        public void GetObjectData(){} // RVA: 0x2DD310
        public void Close(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x6B28D60 | overloaded x2
        public void get_IsFromCache(){} // RVA: 0x6B93D0
        public void GetResponseStream(){} // RVA: 0x6B28D90
        public void get_ResponseUri(){} // RVA: 0x6B28DC0
        public void get_Headers(){} // RVA: 0x6B28DF0
    }

    public class WebResponseStream
    {
        public System.Net.WebReadStream innerStream; // 0x60
        public bool nextReadCalled; // 0x68
        public bool bufferedEntireContent; // 0x69
        public System.Net.WebCompletionSource pendingRead; // 0x70
        public object locker; // 0x78
        public int nestedRead; // 0x80
        public bool read_eof; // 0x84
        public System.Net.WebRequestStream <RequestStream>k__BackingField; // 0x88
        public System.Net.WebHeaderCollection <Headers>k__BackingField; // 0x90
        public 0x65854D38 <StatusCode>k__BackingField; // 0x98

        // ── Methods ──
        public void get_RequestStream(){} // RVA: 0x31C010
        public void get_Headers(){} // RVA: 0x796DE0
        public void set_Headers(){} // RVA: 0xB54600
        public void get_StatusCode(){} // RVA: 0x1D76570
        public void set_StatusCode(){} // RVA: 0x1D76000
        public void get_StatusDescription(){} // RVA: 0xA085E0
        public void set_StatusDescription(){} // RVA: 0x9AA5F0
        public void get_Version(){} // RVA: 0xA1C130
        public void set_Version(){} // RVA: 0xAE5030
        public void get_KeepAlive(){} // RVA: 0x17323D0
        public void set_KeepAlive(){} // RVA: 0x1735610
        public void .ctor(){} // RVA: 0x6B88DD0
        public void get_CanRead(){} // RVA: 0x3C2850
        public void get_CanWrite(){} // RVA: 0x2DD320
        public void get_ChunkedRead(){} // RVA: 0x2FE4C0
        public void set_ChunkedRead(){} // RVA: 0x2FE4D0
        public void ReadAsync(){} // RVA: 0x6B88EF0
        public void ProcessRead(){} // RVA: 0x6B89150
        public void TryReadFromBufferedContent(){} // RVA: 0x6B89580
        public void get_ExpectContent(){} // RVA: 0x6B896B0
        public void Initialize(){} // RVA: 0x6B89770
        public void ReadAllAsyncInner(){} // RVA: 0x6B8A760
        public void ReadAllAsync(){} // RVA: 0x6B8A960
        public void WriteAsync(){} // RVA: 0x6B8ABA0
        public void Close_internal(){} // RVA: 0x6B8AC40
        public void GetReadException(){} // RVA: 0x6B8AD30
        public void InitReadAsync(){} // RVA: 0x6B8B0B0
        public void GetResponse(){} // RVA: 0x6B8B2D0
    }

    public class WebUtility
    {
        public char[] _htmlEntityEndingChars;

        // ── Methods ──
        public void HtmlEncode(){} // RVA: 0x6B28F50 | overloaded x2
        public void IndexOfHtmlEncodingChars(){} // RVA: 0x6B29370
        public void get_HtmlEncodeConformance(){} // RVA: 0x6B29480
        public void UrlEncode(){} // RVA: 0x6B29A90 | overloaded x3
        public void UrlDecodeInternal(){} // RVA: 0x6B29BC0
        public void UrlDecode(){} // RVA: 0x6B29F20
        public void GetNextUnicodeScalarValueFromUtf16Surrogate(){} // RVA: 0x6B29FA0
        public void HexToInt(){} // RVA: 0x6B2A070
        public void IntToHex(){} // RVA: 0x6B2A0B0
        public void IsUrlSafeChar(){} // RVA: 0x6B2A0C0
        public void ValidateUrlEncodingParameters(){} // RVA: 0x6B2A130
        public void .cctor(){} // RVA: 0x6B2A250
    }

}