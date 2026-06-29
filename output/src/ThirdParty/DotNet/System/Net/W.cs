// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 18
// Methods: 313

namespace ThirdParty.DotNet.System.Net
{
    public class WebCompletionSource : WebCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x75DA190
    }

    public class WebCompletionSource`1 : Object
    {
        public object completion;
        public object currentResult;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894750
        public void get_CurrentResult(){} // RVA: 0x87C0A0
        public void get_Task(){} // RVA: 0x87C0A0
        public void TrySetCompleted(){} // RVA: 0x87D280
        public void TrySetCanceled(){} // RVA: 0x87D350
        public void TrySetException(){} // RVA: 0x87D350
        public void ThrowOnError(){} // RVA: 0x894290
        public void WaitForCompletion(){} // RVA: 0x87C0A0
    }

    public class WebCompletionSource`1 : Object
    {
        public object completion;
        public object currentResult;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x562B750
        public void get_CurrentResult(){} // RVA: 0xB465B0
        public void get_Task(){} // RVA: 0x13F9340
        public void TrySetCompleted(){} // RVA: 0x562B9A0
        public void TrySetCanceled(){} // RVA: 0x562BBA0
        public void TrySetException(){} // RVA: 0x562BDC0
        public void ThrowOnError(){} // RVA: 0x562BFE0
        public void WaitForCompletion(){} // RVA: 0x562C460
    }

    public class WebConnection : Object
    {
        public object ntlm_credentials;
        public object ntlm_authenticated;
        public object unsafe_sharing;
        public object networkStream;
        public object socket;
        public object monoTlsStream;
        public object tunnel;
        public object disposed;
        public object _servicePoint;
        public object ID;
        public object idleSince;
        public object currentOperation;

        // ── Methods ──
        public void get_ServicePoint(){} // RVA: 0xBBF8F0
        public void .ctor(){} // RVA: 0xBBF900
        public void CanReuse(){} // RVA: 0x75DA1D0
        public void CheckReusable(){} // RVA: 0x75DA200
        public void Connect(){} // RVA: 0x75DA250
        public void CreateStream(){} // RVA: 0x75DA4D0
        public void InitConnection(){} // RVA: 0x75DA740
        public void GetException(){} // RVA: 0x75DA990
        public void ReadLine(){} // RVA: 0x75DABB0
        public void CanReuseConnection(){} // RVA: 0x75DAE10
        public void PrepareSharingNtlm(){} // RVA: 0x75DB290
        public void Reset(){} // RVA: 0x75DB550
        public void Close(){} // RVA: 0x75DB700
        public void CloseSocket(){} // RVA: 0x75DB820
        public void get_Closed(){} // RVA: 0x75DBB30
        public void get_IdleSince(){} // RVA: 0xC0FFC0
        public void StartOperation(){} // RVA: 0x75DBB40
        public void Continue(){} // RVA: 0x75DBDE0
        public void Dispose(){} // RVA: 0x75DC010
        public void ResetNtlm(){} // RVA: 0x75DC030
        public void get_NtlmAuthenticated(){} // RVA: 0xB5DD50
        public void set_NtlmAuthenticated(){} // RVA: 0xB5DD60
        public void get_NtlmCredential(){} // RVA: 0xB5DBF0
        public void set_NtlmCredential(){} // RVA: 0xB44D60
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0xF43F30
        public void set_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x17F4D80
    }

    public class WebConnectionStream : Stream
    {
        public object closed;
        public object disposed;
        public object locker;
        public object read_timeout;
        public object write_timeout;
        public object IgnoreIOErrors;
        public object _request;
        public object _connection;
        public object _operation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75DDE70
        public void get_Request(){} // RVA: 0xBBF8F0
        public void get_Connection(){} // RVA: 0xBE58B0
        public void get_Operation(){} // RVA: 0xC0FFC0
        public void get_ServicePoint(){} // RVA: 0x75DE080
        public void get_CanTimeout(){} // RVA: 0xC2E4C0
        public void get_ReadTimeout(){} // RVA: 0x18A0130
        public void set_ReadTimeout(){} // RVA: 0x75DE0A0
        public void get_WriteTimeout(){} // RVA: 0x114DAD0
        public void set_WriteTimeout(){} // RVA: 0x75DE110
        public void GetException(){} // RVA: 0x75DE180
        public void TryReadFromBufferedContent(){} // RVA: 0x880120
        public void Read(){} // RVA: 0x75DE320
        public void BeginRead(){} // RVA: 0x75DE5E0
        public void EndRead(){} // RVA: 0x75DE860
        public void BeginWrite(){} // RVA: 0x75DE930
        public void EndWrite(){} // RVA: 0x75DEB60
        public void Write(){} // RVA: 0x75DEC10
        public void Flush(){} // RVA: 0xB43310
        public void FlushAsync(){} // RVA: 0x75DEE50
        public void InternalClose(){} // RVA: 0x75DEF00
        public void Close_internal(){} // RVA: 0x894320
        public void Close(){} // RVA: 0x75DEF10
        public void Seek(){} // RVA: 0x75DEF30
        public void SetLength(){} // RVA: 0x75DEF80
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_Length(){} // RVA: 0x75DEFD0
        public void get_Position(){} // RVA: 0x75DF020
        public void set_Position(){} // RVA: 0x75DF070
    }

    public class WebConnectionTunnel : Object
    {
        public object _request;
        public object _connectUri;
        public object connectRequest;
        public object ntlmAuthState;
        public object _success;
        public object _closeConnection;
        public object _statusCode;
        public object _statusDescription;
        public object _challenge;
        public object _headers;
        public object _proxyVersion;
        public object _data;

        // ── Methods ──
        public void get_Request(){} // RVA: 0xB5DBF0
        public void get_ConnectUri(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Success(){} // RVA: 0xC27380
        public void set_Success(){} // RVA: 0xC27390
        public void get_CloseConnection(){} // RVA: 0xD96880
        public void set_CloseConnection(){} // RVA: 0xD95180
        public void get_StatusCode(){} // RVA: 0xB9E080
        public void set_StatusCode(){} // RVA: 0xB9E090
        public void set_StatusDescription(){} // RVA: 0xD09D70
        public void get_Challenge(){} // RVA: 0xBC1B30
        public void set_Challenge(){} // RVA: 0xB6A8C0
        public void get_Headers(){} // RVA: 0xBBF8F0
        public void set_Headers(){} // RVA: 0xBBF900
        public void get_ProxyVersion(){} // RVA: 0xBE58B0
        public void set_ProxyVersion(){} // RVA: 0xCA4DF0
        public void get_Data(){} // RVA: 0xC0FFC0
        public void set_Data(){} // RVA: 0xC0FFD0
        public void Initialize(){} // RVA: 0x75DF0C0
        public void ReadHeaders(){} // RVA: 0x75DF340
        public void FlushContents(){} // RVA: 0x75DF5A0
    }

    public class WebException : InvalidOperationException
    {
        public object m_Status;
        public object m_Response;
        public object m_InternalStatus;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7586DE0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7586E70
        public void GetObjectData(){} // RVA: 0x7585810
        public void get_Status(){} // RVA: 0xF3A950
        public void get_Response(){} // RVA: 0x106A7D0
    }

    public class WebExceptionMapping : Object
    {
        public object s_Mapping;

        // ── Methods ──
        public void GetWebStatusString(){} // RVA: 0x7586EA0
        public void .cctor(){} // RVA: 0x7587090
    }

    public class WebHeaderCollection : NameValueCollection
    {
        public object ApproxAveHeaderLineSize;
        public object ApproxHighAvgNumHeaders;
        public object HInfo;
        public object m_CommonHeaders;
        public object m_NumCommonHeaders;
        public object s_CommonHeaderNames;
        public object s_CommonHeaderHints;
        public object c_AcceptRanges;
        public object c_ContentLength;
        public object c_CacheControl;
        public object c_ContentType;
        public object c_Date;
        public object c_Expires;
        public object c_ETag;
        public object c_LastModified;
        public object c_Location;
        public object c_ProxyAuthenticate;
        public object c_P3P;
        public object c_SetCookie2;
        public object c_SetCookie;
        public object c_Server;
        public object c_Via;
        public object c_WwwAuthenticate;
        public object c_XAspNetVersion;
        public object c_XPoweredBy;
        public object m_InnerCollection;
        public object m_Type;
        public object HttpTrimCharacters;
        public object RfcCharMap;

        // ── Methods ──
        public void NormalizeCommonHeaders(){} // RVA: 0x7587150
        public void get_InnerCollection(){} // RVA: 0x75872E0
        public void AllowMultiValues(){} // RVA: 0x75873E0
        public void get_AllowHttpRequestHeader(){} // RVA: 0x75874C0
        public void Remove(){} // RVA: 0x7588990
        public void AddInternal(){} // RVA: 0x7587660
        public void ChangeInternal(){} // RVA: 0x75876D0
        public void RemoveInternal(){} // RVA: 0x7587740
        public void CheckBadChars(){} // RVA: 0x75877A0
        public void ContainsNonAsciiChars(){} // RVA: 0x7587D80
        public void ThrowOnRestrictedHeader(){} // RVA: 0x7587DF0
        public void Add(){} // RVA: 0x7588200
        public void Set(){} // RVA: 0x7588500
        public void SetInternal(){} // RVA: 0x7588750
        public void GetValues(){} // RVA: 0x7589F70
        public void ToString(){} // RVA: 0x7588D10
        public void GetAsString(){} // RVA: 0x7588D70
        public void .ctor(){} // RVA: 0x7589200
        public void OnDeserialization(){} // RVA: 0xB43310
        public void GetObjectData(){} // RVA: 0x7589510
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7589B00
        public void Get(){} // RVA: 0x7589F20
        public void GetEnumerator(){} // RVA: 0x7589E70
        public void get_Count(){} // RVA: 0x7589EE0
        public void GetKey(){} // RVA: 0x7589FC0
        public void get_AllKeys(){} // RVA: 0x758A010
        public void .cctor(){} // RVA: 0x758A060
    }

    public class WebOperation : Object
    {
        public object _request;
        public object _connection;
        public object _servicePoint;
        public object _writeBuffer;
        public object _isNtlmChallenge;
        public object ID;
        public object cts;
        public object requestTask;
        public object requestWrittenTask;
        public object responseTask;
        public object finishedTask;
        public object writeStream;
        public object responseStream;
        public object disposedInfo;
        public object closedInfo;
        public object priorityRequest;
        public object requestSent;
        public object finished;

        // ── Methods ──
        public void get_Request(){} // RVA: 0xB5DBF0
        public void get_Connection(){} // RVA: 0xB465B0
        public void set_Connection(){} // RVA: 0xBA9BA0
        public void get_ServicePoint(){} // RVA: 0xB700F0
        public void set_ServicePoint(){} // RVA: 0xB70100
        public void get_WriteBuffer(){} // RVA: 0xB70160
        public void get_IsNtlmChallenge(){} // RVA: 0xB68DF0
        public void .ctor(){} // RVA: 0x75E1560
        public void get_Aborted(){} // RVA: 0x75E19C0
        public void get_Closed(){} // RVA: 0x75E1A20
        public void Abort(){} // RVA: 0x75E1A80
        public void Close(){} // RVA: 0x75E1AE0
        public void SetCanceled(){} // RVA: 0x75E1B80
        public void SetError(){} // RVA: 0x75E1C90
        public void SetDisposed(){} // RVA: 0x75E1D40
        public void CheckDisposed(){} // RVA: 0x75E1F60
        public void ThrowIfDisposed(){} // RVA: 0x75E20B0
        public void ThrowIfClosedOrDisposed(){} // RVA: 0x75E2200
        public void CheckThrowDisposed(){} // RVA: 0x75E2300
        public void RegisterRequest(){} // RVA: 0x75E2380
        public void SetPriorityRequest(){} // RVA: 0x75E27D0
        public void GetRequestStream(){} // RVA: 0x75E29A0
        public void GetRequestStreamInternal(){} // RVA: 0x75E2B30
        public void get_WriteStream(){} // RVA: 0x75E2B80
        public void GetResponseStream(){} // RVA: 0x75E2BE0
        public void get_Finished(){} // RVA: 0xC0FFC0
        public void Run(){} // RVA: 0x75E2C30
        public void CompleteRequestWritten(){} // RVA: 0x75E2E20
        public void Finish(){} // RVA: 0x75E2EB0
        public void <RegisterRequest>b__48_0(){} // RVA: 0x75E32A0
    }

    public class WebProxy : Object
    {
        public object _UseRegistry;
        public object _BypassOnLocal;
        public object m_EnableAutoproxy;
        public object _ProxyAddress;
        public object _BypassList;
        public object _Credentials;
        public object _RegExBypassList;
        public object _ProxyHostAddresses;
        public object m_ScriptEngine;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75A6F40
        public void get_Credentials(){} // RVA: 0xB70160
        public void get_UseDefaultCredentials(){} // RVA: 0x75A5670
        public void set_UseDefaultCredentials(){} // RVA: 0x75A56E0
        public void GetProxy(){} // RVA: 0x75A5750
        public void UpdateRegExList(){} // RVA: 0x75A59B0
        public void IsMatchInBypassList(){} // RVA: 0x75A5C50
        public void IsLocal(){} // RVA: 0x75A5E80
        public void IsLocalInProxyHash(){} // RVA: 0x75A6200
        public void IsBypassed(){} // RVA: 0x75A62F0
        public void IsBypassedManual(){} // RVA: 0x75A6430
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x758D090
        public void GetObjectData(){} // RVA: 0x75A6A00
        public void get_ScriptEngine(){} // RVA: 0xBC1B30
        public void CreateDefaultProxy(){} // RVA: 0x75A6F00
        public void UnsafeUpdateFromRegistry(){} // RVA: 0xF482F0
        public void GetProxyAuto(){} // RVA: 0x75A6F50
        public void IsBypassedAuto(){} // RVA: 0x75A7060
        public void AreAllBypassed(){} // RVA: 0x75A7100
        public void ProxyUri(){} // RVA: 0x75A72A0
    }

    public class WebReadStream : Stream
    {
        public object _operation;
        public object _innerStream;
        public object disposed;

        // ── Methods ──
        public void get_Operation(){} // RVA: 0xB70160
        public void get_InnerStream(){} // RVA: 0xD33E60
        public void .ctor(){} // RVA: 0x75E4110
        public void get_Length(){} // RVA: 0x75E4220
        public void get_Position(){} // RVA: 0x75E4260
        public void set_Position(){} // RVA: 0x75E42A0
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanRead(){} // RVA: 0xC2E4C0
        public void get_CanWrite(){} // RVA: 0xB43320
        public void SetLength(){} // RVA: 0x75E42E0
        public void Seek(){} // RVA: 0x75E4320
        public void Write(){} // RVA: 0x75E4360
        public void Flush(){} // RVA: 0x75E43A0
        public void GetException(){} // RVA: 0x75E43E0
        public void Read(){} // RVA: 0x75E4580
        public void BeginRead(){} // RVA: 0x75E4840
        public void EndRead(){} // RVA: 0x75E4AC0
        public void ReadAsync(){} // RVA: 0x75E4B90
        public void ProcessReadAsync(){} // RVA: 0x88D750
        public void FinishReading(){} // RVA: 0x75CF3D0
        public void Dispose(){} // RVA: 0x75E4E10
    }

    public class WebRequest : MarshalByRefObject
    {
        public object DefaultTimeout;
        public object s_PrefixList;
        public object s_InternalSyncObject;
        public object s_DefaultTimerQueue;
        public object m_AuthenticationLevel;
        public object m_ImpersonationLevel;
        public object m_CachePolicy;
        public object m_CacheProtocol;
        public object m_CacheBinding;
        public object webRequestCreate;
        public object s_DefaultWebProxy;
        public object s_DefaultWebProxyInitialized;

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x758AD10
        public void Create(){} // RVA: 0x758B390
        public void get_PrefixList(){} // RVA: 0x758B460
        public void PopulatePrefixList(){} // RVA: 0x758B6B0
        public void .ctor(){} // RVA: 0xB43310
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x758B8E0
        public void GetObjectData(){} // RVA: 0xB43310
        public void get_DefaultCachePolicy(){} // RVA: 0x758B910
        public void set_CachePolicy(){} // RVA: 0x758B980
        public void InternalSetCachePolicy(){} // RVA: 0x758B980
        public void get_Method(){} // RVA: 0x758BA60
        public void set_Method(){} // RVA: 0x758BA90
        public void get_RequestUri(){} // RVA: 0x758BAC0
        public void set_ConnectionGroupName(){} // RVA: 0x758BAF0
        public void get_Headers(){} // RVA: 0x758BB20
        public void get_ContentLength(){} // RVA: 0x758BB50
        public void set_ContentLength(){} // RVA: 0x758BB80
        public void get_Credentials(){} // RVA: 0x758BBB0
        public void set_Credentials(){} // RVA: 0x758BBE0
        public void get_UseDefaultCredentials(){} // RVA: 0x758BC10
        public void get_Proxy(){} // RVA: 0x758BC40
        public void set_Proxy(){} // RVA: 0x758BC70
        public void set_PreAuthenticate(){} // RVA: 0x758BCA0
        public void get_Timeout(){} // RVA: 0x758BCD0
        public void set_Timeout(){} // RVA: 0x758BD00
        public void GetResponse(){} // RVA: 0x758BD30
        public void BeginGetResponse(){} // RVA: 0x758BD60
        public void EndGetResponse(){} // RVA: 0x758BD90
        public void BeginGetRequestStream(){} // RVA: 0x758BDC0
        public void EndGetRequestStream(){} // RVA: 0x758BDF0
        public void GetRequestStreamAsync(){} // RVA: 0x758BE20
        public void GetResponseAsync(){} // RVA: 0x758C130
        public void SafeCaptureIdenity(){} // RVA: 0x758C440
        public void Abort(){} // RVA: 0x758C490
        public void get_CacheProtocol(){} // RVA: 0xB70160
        public void set_CacheProtocol(){} // RVA: 0xB44DC0
        public void get_InternalDefaultWebProxy(){} // RVA: 0x758C4C0
        public void .cctor(){} // RVA: 0x758C710
        public void <GetRequestStreamAsync>b__78_0(){} // RVA: 0x758C870
        public void <GetResponseAsync>b__79_0(){} // RVA: 0x758C9A0
    }

    public class WebRequestPrefixElement : Object
    {
        public object Prefix;
        public object creator;
        public object creatorType;

        // ── Methods ──
        public void get_Creator(){} // RVA: 0x75846C0
        public void set_Creator(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x17C92C0
    }

    public class WebRequestStream : WebConnectionStream
    {
        public object crlf;
        public object writeBuffer;
        public object requestWritten;
        public object allowBuffering;
        public object sendChunked;
        public object pendingWrite;
        public object totalWritten;
        public object headers;
        public object headersSent;
        public object completeRequestWritten;
        public object chunkTrailerWritten;
        public object ME;
        public object _innerStream;
        public object _keepAlive;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75E54E0
        public void get_InnerStream(){} // RVA: 0x106A050
        public void get_KeepAlive(){} // RVA: 0xE3F3E0
        public void get_CanRead(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xC2E4C0
        public void get_HasWriteBuffer(){} // RVA: 0x75E56E0
        public void get_WriteBufferLength(){} // RVA: 0x75E5710
        public void GetWriteBuffer(){} // RVA: 0x75E5770
        public void FinishWriting(){} // RVA: 0x75E58A0
        public void WriteAsync(){} // RVA: 0x75E5AB0
        public void WriteAsyncInner(){} // RVA: 0x75E5DA0
        public void ProcessWrite(){} // RVA: 0x75E6080
        public void CheckWriteOverflow(){} // RVA: 0x75E6320
        public void Initialize(){} // RVA: 0x75E63D0
        public void SetHeadersAsync(){} // RVA: 0x75E65F0
        public void WriteRequestAsync(){} // RVA: 0x75E6830
        public void WriteChunkTrailer_inner(){} // RVA: 0x75E6A50
        public void WriteChunkTrailer(){} // RVA: 0x75E6C60
        public void KillBuffer(){} // RVA: 0x64E4D50
        public void ReadAsync(){} // RVA: 0x75E6E20
        public void TryReadFromBufferedContent(){} // RVA: 0x75E6ED0
        public void Close_internal(){} // RVA: 0x75E6F10
        public void .cctor(){} // RVA: 0x75E7290
    }

    public class WebResponse : MarshalByRefObject
    {
        public object m_IsCacheFresh;
        public object m_IsFromCache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x758D090
        public void GetObjectData(){} // RVA: 0xB43310
        public void Close(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0x758D130
        public void get_IsFromCache(){} // RVA: 0xF43F30
        public void GetResponseStream(){} // RVA: 0x758D160
        public void get_ResponseUri(){} // RVA: 0x758D190
        public void get_Headers(){} // RVA: 0x758D1C0
    }

    public class WebResponseStream : WebConnectionStream
    {
        public object innerStream;
        public object nextReadCalled;
        public object bufferedEntireContent;
        public object pendingRead;
        public object locker;
        public object nestedRead;
        public object read_eof;
        public object _requestStream;
        public object _headers;
        public object _statusCode;
        public object _statusDescription;
        public object _version;
        public object _keepAlive;
        public object ME;
        public object _chunkedRead;

        // ── Methods ──
        public void get_RequestStream(){} // RVA: 0xB813B0
        public void get_Headers(){} // RVA: 0x1069350
        public void set_Headers(){} // RVA: 0xD5CC10
        public void get_StatusCode(){} // RVA: 0x262A930
        public void set_StatusCode(){} // RVA: 0x262A900
        public void get_StatusDescription(){} // RVA: 0x106A050
        public void set_StatusDescription(){} // RVA: 0xD5CCD0
        public void get_Version(){} // RVA: 0x12EB090
        public void set_Version(){} // RVA: 0x13B1040
        public void get_KeepAlive(){} // RVA: 0x2009180
        public void set_KeepAlive(){} // RVA: 0x20097F0
        public void .ctor(){} // RVA: 0x75EAD30
        public void get_CanRead(){} // RVA: 0xC2E4C0
        public void get_CanWrite(){} // RVA: 0xB43320
        public void get_ChunkedRead(){} // RVA: 0xB63970
        public void set_ChunkedRead(){} // RVA: 0xB63980
        public void ReadAsync(){} // RVA: 0x75EAE50
        public void ProcessRead(){} // RVA: 0x75EB0C0
        public void TryReadFromBufferedContent(){} // RVA: 0x75EB4F0
        public void get_ExpectContent(){} // RVA: 0x75EB620
        public void Initialize(){} // RVA: 0x75EB6E0
        public void ReadAllAsyncInner(){} // RVA: 0x75EC6D0
        public void ReadAllAsync(){} // RVA: 0x75EC8D0
        public void WriteAsync(){} // RVA: 0x75ECB10
        public void Close_internal(){} // RVA: 0x75ECBB0
        public void GetReadException(){} // RVA: 0x75ECCA0
        public void InitReadAsync(){} // RVA: 0x75ED020
        public void GetResponse(){} // RVA: 0x75ED240
    }

    public class WebUtility : Object
    {
        public object _htmlEntityEndingChars;
        public object _htmlDecodeConformance;
        public object _htmlEncodeConformance;

        // ── Methods ──
        public void HtmlEncode(){} // RVA: 0x758D320
        public void IndexOfHtmlEncodingChars(){} // RVA: 0x758D770
        public void get_HtmlEncodeConformance(){} // RVA: 0x758D870
        public void UrlEncode(){} // RVA: 0x758DEC0
        public void UrlDecodeInternal(){} // RVA: 0x758DFF0
        public void UrlDecode(){} // RVA: 0x758E330
        public void GetNextUnicodeScalarValueFromUtf16Surrogate(){} // RVA: 0x758E3B0
        public void HexToInt(){} // RVA: 0x758E450
        public void IntToHex(){} // RVA: 0x758E490
        public void IsUrlSafeChar(){} // RVA: 0x758E4A0
        public void ValidateUrlEncodingParameters(){} // RVA: 0x758E510
        public void .cctor(){} // RVA: 0x758E630
    }

}