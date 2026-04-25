// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 17
// Methods: 336

namespace ThirdParty.DotNet.System.Net
{
    public class WebCompletionSource : WebCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC930EC20
    }

    public class WebCompletionSource`1 : Object
    {
        public System.Threading.Tasks.TaskCompletionSource`1<Result<T>> CurrentResult;
        public Result<T> Task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C71060
        public void get_CurrentResult(){} // RVA: 0x7FFAC2C58E90
        public void get_Task(){} // RVA: 0x7FFAC2C58E90
        public void TrySetCompleted(){} // RVA: 0x7FFAC2C59D00 | overloaded x2
        public void TrySetCanceled(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void TrySetException(){} // RVA: 0x7FFAC2C59F60
        public void ThrowOnError(){} // RVA: 0x7FFAC2C70980
        public void WaitForCompletion(){} // RVA: 0x7FFAC2C58E90
    }

    public class WebConnection : Object
    {
        public System.Net.NetworkCredential ServicePoint; // 0x10
        public bool Closed; // 0x18
        public bool IdleSince; // 0x19
        public System.IO.Stream NtlmAuthenticated; // 0x20
        public System.Net.Sockets.Socket NtlmCredential; // 0x28
        public Mono.Net.Security.MonoTlsStream UnsafeAuthenticatedConnectionSharing; // 0x30
        public System.Net.WebConnectionTunnel tunnel; // 0x38
        public int disposed; // 0x40
        public System.Net.ServicePoint <ServicePoint>k__BackingField; // 0x48
        public int ID; // 0x50
        public System.DateTime idleSince; // 0x58
        public System.Net.WebOperation currentOperation; // 0x60

        // ── Methods ──
        public void get_ServicePoint(){} // RVA: 0x7FFAC2F9C730
        public void .ctor(){} // RVA: 0x7FFAC2F9C740
        public void CanReuse(){} // RVA: 0x7FFAC930EC60
        public void CheckReusable(){} // RVA: 0x7FFAC930EC90
        public void Connect(){} // RVA: 0x7FFAC930ECE0
        public void CreateStream(){} // RVA: 0x7FFAC930EF60
        public void InitConnection(){} // RVA: 0x7FFAC930F1D0
        public void GetException(){} // RVA: 0x7FFAC930F420
        public void ReadLine(){} // RVA: 0x7FFAC930F640
        public void CanReuseConnection(){} // RVA: 0x7FFAC930F8A0
        public void PrepareSharingNtlm(){} // RVA: 0x7FFAC930FD50
        public void Reset(){} // RVA: 0x7FFAC9310000
        public void Close(){} // RVA: 0x7FFAC93101F0
        public void CloseSocket(){} // RVA: 0x7FFAC9310340
        public void get_Closed(){} // RVA: 0x7FFAC9310680
        public void get_IdleSince(){} // RVA: 0x7FFAC2FE9500
        public void StartOperation(){} // RVA: 0x7FFAC9310690
        public void Continue(){} // RVA: 0x7FFAC9310970
        public void Dispose(){} // RVA: 0x7FFAC9310BD0 | overloaded x2
        public void ResetNtlm(){} // RVA: 0x7FFAC9310BF0
        public void get_NtlmAuthenticated(){} // RVA: 0x7FFAC2F3C4E0
        public void set_NtlmAuthenticated(){} // RVA: 0x7FFAC2F3C4F0
        public void get_NtlmCredential(){} // RVA: 0x7FFAC2F3C380
        public void set_NtlmCredential(){} // RVA: 0x7FFAC2F22E30
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7FFAC3228D50
        public void set_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7FFAC3515120
    }

    public class WebConnectionStream : Stream
    {
        public bool Request; // 0x28
        public bool Connection; // 0x29
        public object Operation; // 0x30
        public int ServicePoint; // 0x38
        public int CanTimeout; // 0x3C
        public bool ReadTimeout; // 0x40
        public System.Net.HttpWebRequest WriteTimeout; // 0x48
        public System.Net.WebConnection CanSeek; // 0x50
        public System.Net.WebOperation Length; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9312A20
        public void get_Request(){} // RVA: 0x7FFAC2F9C730
        public void get_Connection(){} // RVA: 0x7FFAC2FC20E0
        public void get_Operation(){} // RVA: 0x7FFAC2FE9500
        public void get_ServicePoint(){} // RVA: 0x7FFAC9312C30
        public void get_CanTimeout(){} // RVA: 0x7FFAC3006850
        public void get_ReadTimeout(){} // RVA: 0x7FFAC358A870
        public void set_ReadTimeout(){} // RVA: 0x7FFAC9312C50
        public void get_WriteTimeout(){} // RVA: 0x7FFAC33BD4A0
        public void set_WriteTimeout(){} // RVA: 0x7FFAC9312CC0
        public void GetException(){} // RVA: 0x7FFAC9312D30
        public void TryReadFromBufferedContent(){}
        public void Read(){} // RVA: 0x7FFAC9312ED0
        public void BeginRead(){} // RVA: 0x7FFAC9313190
        public void EndRead(){} // RVA: 0x7FFAC9313410
        public void BeginWrite(){} // RVA: 0x7FFAC93134E0
        public void EndWrite(){} // RVA: 0x7FFAC9313710
        public void Write(){} // RVA: 0x7FFAC93137C0
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void FlushAsync(){} // RVA: 0x7FFAC9313A00
        public void InternalClose(){} // RVA: 0x7FFAC9313AB0
        public void Close_internal(){} // RVA: 0x7FFAC2C70A40
        public void Close(){} // RVA: 0x7FFAC9313AC0
        public void Seek(){} // RVA: 0x7FFAC9313AE0
        public void SetLength(){} // RVA: 0x7FFAC9313B30
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_Length(){} // RVA: 0x7FFAC9313B80
        public void get_Position(){} // RVA: 0x7FFAC9313BD0
        public void set_Position(){} // RVA: 0x7FFAC9313C20
    }

    public class WebConnectionTunnel : Object
    {
        public System.Net.HttpWebRequest Request; // 0x10
        public System.Uri ConnectUri; // 0x18
        public System.Net.HttpWebRequest Success; // 0x20
        public 0x6B13E118 CloseConnection; // 0x28
        public bool StatusCode; // 0x2C
        public bool StatusDescription; // 0x2D
        public int Challenge; // 0x30
        public string Headers; // 0x38
        public string[] ProxyVersion; // 0x40
        public System.Net.WebHeaderCollection Data; // 0x48
        public System.Version <ProxyVersion>k__BackingField; // 0x50
        public byte[] <Data>k__BackingField; // 0x58

        // ── Methods ──
        public void get_Request(){} // RVA: 0x7FFAC2F3C380
        public void get_ConnectUri(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_Success(){} // RVA: 0x7FFAC3000230
        public void set_Success(){} // RVA: 0x7FFAC3000240
        public void get_CloseConnection(){} // RVA: 0x7FFAC392CE00
        public void set_CloseConnection(){} // RVA: 0x7FFAC473AAD0
        public void get_StatusCode(){} // RVA: 0x7FFAC2F7CCD0
        public void set_StatusCode(){} // RVA: 0x7FFAC2F7CCE0
        public void set_StatusDescription(){} // RVA: 0x7FFAC31D0C20
        public void get_Challenge(){} // RVA: 0x7FFAC2F9E740
        public void set_Challenge(){} // RVA: 0x7FFAC2F49200
        public void get_Headers(){} // RVA: 0x7FFAC2F9C730
        public void set_Headers(){} // RVA: 0x7FFAC2F9C740
        public void get_ProxyVersion(){} // RVA: 0x7FFAC2FC20E0
        public void set_ProxyVersion(){} // RVA: 0x7FFAC30794D0
        public void get_Data(){} // RVA: 0x7FFAC2FE9500
        public void set_Data(){} // RVA: 0x7FFAC2FE9510
        public void Initialize(){} // RVA: 0x7FFAC9313C70
        public void ReadHeaders(){} // RVA: 0x7FFAC9313EF0
        public void FlushContents(){} // RVA: 0x7FFAC9314150
    }

    public class WebException : InvalidOperationException
    {
        public 0x6B13B258 Status; // 0x90
        public System.Net.WebResponse Response; // 0x98
        public 0x6B13B200 m_InternalStatus; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92B9480 | overloaded x10
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC92B9510
        public void GetObjectData(){} // RVA: 0x7FFAC92B7EC0
        public void get_Status(){} // RVA: 0x7FFAC3220660
        public void get_Response(){} // RVA: 0x7FFAC354DFB0
    }

    public class WebExceptionMapping : Object
    {
        public string[] s_Mapping;

        // ── Methods ──
        public void GetWebStatusString(){} // RVA: 0x7FFAC92B9540
        public void .cctor(){} // RVA: 0x7FFAC92B9730
    }

    public class WebHeaderCollection : NameValueCollection
    {
        public int InnerCollection;
        public int AllowHttpRequestHeader;
        public System.Net.HeaderInfoTable Count;
        public string[] AllKeys; // 0x68
        public int m_NumCommonHeaders; // 0x70
        public string[] s_CommonHeaderNames; // 0x8
        public sbyte[] s_CommonHeaderHints; // 0x10
        public int c_AcceptRanges;
        public int c_ContentLength;
        public int c_CacheControl;
        public int c_ContentType;
        public int c_Date;
        public int c_Expires;
        public int c_ETag;
        public int c_LastModified;
        public int c_Location;
        public int c_ProxyAuthenticate;
        public int c_P3P;
        public int c_SetCookie2;
        public int c_SetCookie;
        public int c_Server;
        public int c_Via;
        public int c_WwwAuthenticate;
        public int c_XAspNetVersion;
        public int c_XPoweredBy;
        public System.Collections.Specialized.NameValueCollection m_InnerCollection; // 0x78
        public 0x6B13B308 m_Type; // 0x80
        public char[] HttpTrimCharacters; // 0x18
        public 0x6B13B360[] RfcCharMap; // 0x20

        // ── Methods ──
        public void NormalizeCommonHeaders(){} // RVA: 0x7FFAC92B97F0
        public void get_InnerCollection(){} // RVA: 0x7FFAC92B9980
        public void AllowMultiValues(){} // RVA: 0x7FFAC92B9A80
        public void get_AllowHttpRequestHeader(){} // RVA: 0x7FFAC92B9B60
        public void Remove(){} // RVA: 0x7FFAC92BB050 | overloaded x2
        public void AddInternal(){} // RVA: 0x7FFAC92B9D00
        public void ChangeInternal(){} // RVA: 0x7FFAC92B9D70
        public void RemoveInternal(){} // RVA: 0x7FFAC92B9DE0
        public void CheckBadChars(){} // RVA: 0x7FFAC92B9E40
        public void ContainsNonAsciiChars(){} // RVA: 0x7FFAC92BA430
        public void ThrowOnRestrictedHeader(){} // RVA: 0x7FFAC92BA4A0
        public void Add(){} // RVA: 0x7FFAC92BA8C0 | overloaded x2
        public void Set(){} // RVA: 0x7FFAC92BABC0
        public void SetInternal(){} // RVA: 0x7FFAC92BAE10
        public void GetValues(){} // RVA: 0x7FFAC92BC640 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC92BB3D0
        public void GetAsString(){} // RVA: 0x7FFAC92BB430
        public void .ctor(){} // RVA: 0x7FFAC92BB8E0 | overloaded x3
        public void OnDeserialization(){} // RVA: 0x7FFAC2F21310
        public void GetObjectData(){} // RVA: 0x7FFAC92BBBF0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC92BC1E0
        public void Get(){} // RVA: 0x7FFAC92BC5F0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAC92BC540
        public void get_Count(){} // RVA: 0x7FFAC92BC5B0
        public void GetKey(){} // RVA: 0x7FFAC92BC690
        public void get_AllKeys(){} // RVA: 0x7FFAC92BC6E0
        public void .cctor(){} // RVA: 0x7FFAC92BC730
    }

    public class WebOperation : Object
    {
        public System.Net.HttpWebRequest Request; // 0x10
        public System.Net.WebConnection Connection; // 0x18
        public System.Net.ServicePoint ServicePoint; // 0x20
        public System.Net.BufferOffsetSize WriteBuffer; // 0x28
        public bool IsNtlmChallenge; // 0x30
        public int Aborted; // 0x34
        public System.Threading.CancellationTokenSource Closed; // 0x38
        public System.Net.WebCompletionSource`1<System.Net.WebRequestStream> WriteStream; // 0x40
        public System.Net.WebCompletionSource`1<System.Net.WebRequestStream> Finished; // 0x48
        public System.Net.WebCompletionSource`1<System.Net.WebResponseStream> responseTask; // 0x50
        public System.Net.WebCompletionSource`1<System.ValueTuple`2<bool,System.Net.WebOperation>> finishedTask; // 0x58
        public System.Net.WebRequestStream writeStream; // 0x60
        public System.Net.WebResponseStream responseStream; // 0x68
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo disposedInfo; // 0x70
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo closedInfo; // 0x78
        public System.Net.WebOperation priorityRequest; // 0x80
        public int requestSent; // 0x88
        public int finished; // 0x8C

        // ── Methods ──
        public void get_Request(){} // RVA: 0x7FFAC2F3C380
        public void get_Connection(){} // RVA: 0x7FFAC2F247C0
        public void set_Connection(){} // RVA: 0x7FFAC2F87E80
        public void get_ServicePoint(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ServicePoint(){} // RVA: 0x7FFAC2F4F0D0
        public void get_WriteBuffer(){} // RVA: 0x7FFAC2F4F130
        public void get_IsNtlmChallenge(){} // RVA: 0x7FFAC2F47450
        public void .ctor(){} // RVA: 0x7FFAC9316140
        public void get_Aborted(){} // RVA: 0x7FFAC9316590
        public void get_Closed(){} // RVA: 0x7FFAC93165F0
        public void Abort(){} // RVA: 0x7FFAC9316650
        public void Close(){} // RVA: 0x7FFAC93166B0
        public void SetCanceled(){} // RVA: 0x7FFAC9316750
        public void SetError(){} // RVA: 0x7FFAC9316860
        public void SetDisposed(){} // RVA: 0x7FFAC9316910
        public void CheckDisposed(){} // RVA: 0x7FFAC9316B30
        public void ThrowIfDisposed(){} // RVA: 0x7FFAC9316C80 | overloaded x2
        public void ThrowIfClosedOrDisposed(){} // RVA: 0x7FFAC9316DD0 | overloaded x2
        public void CheckThrowDisposed(){} // RVA: 0x7FFAC9316ED0
        public void RegisterRequest(){} // RVA: 0x7FFAC9316F50
        public void SetPriorityRequest(){} // RVA: 0x7FFAC93173D0
        public void GetRequestStream(){} // RVA: 0x7FFAC93175D0
        public void GetRequestStreamInternal(){} // RVA: 0x7FFAC9317760
        public void get_WriteStream(){} // RVA: 0x7FFAC93177B0
        public void GetResponseStream(){} // RVA: 0x7FFAC9317810
        public void get_Finished(){} // RVA: 0x7FFAC2FE9500
        public void Run(){} // RVA: 0x7FFAC9317860
        public void CompleteRequestWritten(){} // RVA: 0x7FFAC9317A40
        public void Finish(){} // RVA: 0x7FFAC9317AD0
        public void <RegisterRequest>b__48_0(){} // RVA: 0x7FFAC9317EE0
    }

    public class WebProxy : Object
    {
        public bool Credentials; // 0x10
        public bool UseDefaultCredentials; // 0x11
        public bool ScriptEngine; // 0x12
        public System.Uri _ProxyAddress; // 0x18
        public System.Collections.ArrayList _BypassList; // 0x20
        public System.Net.ICredentials _Credentials; // 0x28
        public System.Text.RegularExpressions.Regex[] _RegExBypassList; // 0x30
        public System.Collections.Hashtable _ProxyHostAddresses; // 0x38
        public System.Net.AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92DA770 | overloaded x4
        public void get_Credentials(){} // RVA: 0x7FFAC2F4F130
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFAC92D8CB0
        public void set_UseDefaultCredentials(){} // RVA: 0x7FFAC92D8D20
        public void GetProxy(){} // RVA: 0x7FFAC92D8D90
        public void UpdateRegExList(){} // RVA: 0x7FFAC92D8FF0
        public void IsMatchInBypassList(){} // RVA: 0x7FFAC92D92A0
        public void IsLocal(){} // RVA: 0x7FFAC92D94C0
        public void IsLocalInProxyHash(){} // RVA: 0x7FFAC92D9A70
        public void IsBypassed(){} // RVA: 0x7FFAC92D9B60
        public void IsBypassedManual(){} // RVA: 0x7FFAC92D9CA0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC92BF840
        public void GetObjectData(){} // RVA: 0x7FFAC92DA220
        public void get_ScriptEngine(){} // RVA: 0x7FFAC2F9E740
        public void CreateDefaultProxy(){} // RVA: 0x7FFAC92DA730
        public void UnsafeUpdateFromRegistry(){} // RVA: 0x7FFAC322C870
        public void GetProxyAuto(){} // RVA: 0x7FFAC92DA780
        public void IsBypassedAuto(){} // RVA: 0x7FFAC92DA890
        public void AreAllBypassed(){} // RVA: 0x7FFAC92DA930
        public void ProxyUri(){} // RVA: 0x7FFAC92DAAD0
    }

    public class WebReadStream : Stream
    {
        public System.Net.WebOperation Operation; // 0x28
        public System.IO.Stream InnerStream; // 0x30
        public bool Length; // 0x38

        // ── Methods ──
        public void get_Operation(){} // RVA: 0x7FFAC2F4F130
        public void get_InnerStream(){} // RVA: 0x7FFAC31D95E0
        public void .ctor(){} // RVA: 0x7FFAC9318D50
        public void get_Length(){} // RVA: 0x7FFAC9318E60
        public void get_Position(){} // RVA: 0x7FFAC9318EA0
        public void set_Position(){} // RVA: 0x7FFAC9318EE0
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanRead(){} // RVA: 0x7FFAC3006850
        public void get_CanWrite(){} // RVA: 0x7FFAC2F21320
        public void SetLength(){} // RVA: 0x7FFAC9318F20
        public void Seek(){} // RVA: 0x7FFAC9318F60
        public void Write(){} // RVA: 0x7FFAC9318FA0
        public void Flush(){} // RVA: 0x7FFAC9318FE0
        public void GetException(){} // RVA: 0x7FFAC9319020
        public void Read(){} // RVA: 0x7FFAC93191C0
        public void BeginRead(){} // RVA: 0x7FFAC9319480
        public void EndRead(){} // RVA: 0x7FFAC9319700
        public void ReadAsync(){} // RVA: 0x7FFAC93197D0
        public void ProcessReadAsync(){}
        public void FinishReading(){} // RVA: 0x7FFAC9303B70
        public void Dispose(){} // RVA: 0x7FFAC9319A50
    }

    public class WebRequest : MarshalByRefObject
    {
        public int InternalSyncObject;
        public System.Collections.ArrayList PrefixList;
        public object DefaultCachePolicy; // 0x8
        public Queue CachePolicy; // 0x10
        public 0x6B142370 Method; // 0x18
        public 0x6B0CE0C8 RequestUri; // 0x1C
        public System.Net.Cache.RequestCachePolicy ConnectionGroupName; // 0x20
        public System.Net.Cache.RequestCacheProtocol Headers; // 0x28
        public System.Net.Cache.RequestCacheBinding ContentLength; // 0x30
        public DesignerWebRequestCreate Credentials; // 0x18
        public System.Net.IWebProxy UseDefaultCredentials; // 0x20
        public bool Proxy; // 0x28

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFAC92BD420
        public void Create(){} // RVA: 0x7FFAC92BDAB0 | overloaded x3
        public void get_PrefixList(){} // RVA: 0x7FFAC92BDB80
        public void PopulatePrefixList(){} // RVA: 0x7FFAC92BDE00
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC92BE030
        public void GetObjectData(){} // RVA: 0x7FFAC2F21310
        public void get_DefaultCachePolicy(){} // RVA: 0x7FFAC92BE060
        public void set_CachePolicy(){} // RVA: 0x7FFAC92BE0E0
        public void InternalSetCachePolicy(){} // RVA: 0x7FFAC92BE0E0
        public void get_Method(){} // RVA: 0x7FFAC92BE1C0
        public void set_Method(){} // RVA: 0x7FFAC92BE1F0
        public void get_RequestUri(){} // RVA: 0x7FFAC92BE220
        public void set_ConnectionGroupName(){} // RVA: 0x7FFAC92BE250
        public void get_Headers(){} // RVA: 0x7FFAC92BE280
        public void get_ContentLength(){} // RVA: 0x7FFAC92BE2B0
        public void set_ContentLength(){} // RVA: 0x7FFAC92BE2E0
        public void get_Credentials(){} // RVA: 0x7FFAC92BE310
        public void set_Credentials(){} // RVA: 0x7FFAC92BE340
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFAC92BE370
        public void get_Proxy(){} // RVA: 0x7FFAC92BE3A0
        public void set_Proxy(){} // RVA: 0x7FFAC92BE3D0
        public void set_PreAuthenticate(){} // RVA: 0x7FFAC92BE400
        public void get_Timeout(){} // RVA: 0x7FFAC92BE430
        public void set_Timeout(){} // RVA: 0x7FFAC92BE460
        public void GetResponse(){} // RVA: 0x7FFAC92BE490
        public void BeginGetResponse(){} // RVA: 0x7FFAC92BE4C0
        public void EndGetResponse(){} // RVA: 0x7FFAC92BE4F0
        public void BeginGetRequestStream(){} // RVA: 0x7FFAC92BE520
        public void EndGetRequestStream(){} // RVA: 0x7FFAC92BE550
        public void GetRequestStreamAsync(){} // RVA: 0x7FFAC92BE580
        public void GetResponseAsync(){} // RVA: 0x7FFAC92BE890
        public void SafeCaptureIdenity(){} // RVA: 0x7FFAC92BEBA0
        public void Abort(){} // RVA: 0x7FFAC92BEBF0
        public void get_CacheProtocol(){} // RVA: 0x7FFAC2F4F130
        public void set_CacheProtocol(){} // RVA: 0x7FFAC2F22E90
        public void get_InternalDefaultWebProxy(){} // RVA: 0x7FFAC92BEC20
        public void .cctor(){} // RVA: 0x7FFAC92BEEA0
        public void <GetRequestStreamAsync>b__78_0(){} // RVA: 0x7FFAC92BF000
        public void <GetResponseAsync>b__79_0(){} // RVA: 0x7FFAC92BF130
    }

    public class WebRequestPrefixElement : Object
    {
        public string Creator; // 0x10
        public System.Net.IWebRequestCreate creator; // 0x18
        public System.Type creatorType; // 0x20

        // ── Methods ──
        public void get_Creator(){} // RVA: 0x7FFAC92B6C30
        public void set_Creator(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC34EC240
    }

    public class WebRequestStream : WebConnectionStream
    {
        public byte[] InnerStream;
        public System.IO.MemoryStream KeepAlive; // 0x60
        public bool CanRead; // 0x68
        public bool CanWrite; // 0x69
        public bool HasWriteBuffer; // 0x6A
        public System.Net.WebCompletionSource WriteBufferLength; // 0x70
        public long totalWritten; // 0x78
        public byte[] headers; // 0x80
        public bool headersSent; // 0x88
        public int completeRequestWritten; // 0x8C
        public int chunkTrailerWritten; // 0x90
        public string ME; // 0x98
        public System.IO.Stream <InnerStream>k__BackingField; // 0xA0
        public bool <KeepAlive>k__BackingField; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC931A120
        public void get_InnerStream(){} // RVA: 0x7FFAC3543900
        public void get_KeepAlive(){} // RVA: 0x7FFAC3141F10
        public void get_CanRead(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC3006850
        public void get_HasWriteBuffer(){} // RVA: 0x7FFAC931A310
        public void get_WriteBufferLength(){} // RVA: 0x7FFAC931A340
        public void GetWriteBuffer(){} // RVA: 0x7FFAC931A3A0
        public void FinishWriting(){} // RVA: 0x7FFAC931A4D0
        public void WriteAsync(){} // RVA: 0x7FFAC931A6E0
        public void WriteAsyncInner(){} // RVA: 0x7FFAC931A9D0
        public void ProcessWrite(){} // RVA: 0x7FFAC931ACA0
        public void CheckWriteOverflow(){} // RVA: 0x7FFAC931AF40
        public void Initialize(){} // RVA: 0x7FFAC931AFF0
        public void SetHeadersAsync(){} // RVA: 0x7FFAC931B210
        public void WriteRequestAsync(){} // RVA: 0x7FFAC931B450
        public void WriteChunkTrailer_inner(){} // RVA: 0x7FFAC931B670
        public void WriteChunkTrailer(){} // RVA: 0x7FFAC931B880
        public void KillBuffer(){} // RVA: 0x7FFAC8201CE0
        public void ReadAsync(){} // RVA: 0x7FFAC931BA40
        public void TryReadFromBufferedContent(){} // RVA: 0x7FFAC931BAF0
        public void Close_internal(){} // RVA: 0x7FFAC931BB30
        public void .cctor(){} // RVA: 0x7FFAC931BEB0
    }

    public class WebResponse : MarshalByRefObject
    {
        public bool IsFromCache; // 0x18
        public bool ResponseUri; // 0x19

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC92BF840
        public void GetObjectData(){} // RVA: 0x7FFAC2F21310
        public void Close(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC92BF8E0 | overloaded x2
        public void get_IsFromCache(){} // RVA: 0x7FFAC3228D50
        public void GetResponseStream(){} // RVA: 0x7FFAC92BF910
        public void get_ResponseUri(){} // RVA: 0x7FFAC92BF940
        public void get_Headers(){} // RVA: 0x7FFAC92BF970
    }

    public class WebResponseStream : WebConnectionStream
    {
        public System.Net.WebReadStream RequestStream; // 0x60
        public bool Headers; // 0x68
        public bool StatusCode; // 0x69
        public System.Net.WebCompletionSource StatusDescription; // 0x70
        public object Version; // 0x78
        public int KeepAlive; // 0x80
        public bool CanRead; // 0x84
        public System.Net.WebRequestStream CanWrite; // 0x88
        public System.Net.WebHeaderCollection ChunkedRead; // 0x90
        public 0x6B139DB8 ExpectContent; // 0x98
        public string <StatusDescription>k__BackingField; // 0xA0
        public System.Version <Version>k__BackingField; // 0xA8
        public bool <KeepAlive>k__BackingField; // 0xB0
        public string ME; // 0xB8
        public bool <ChunkedRead>k__BackingField; // 0xC0

        // ── Methods ──
        public void get_RequestStream(){} // RVA: 0x7FFAC2F60010
        public void get_Headers(){} // RVA: 0x7FFAC32EF640
        public void set_Headers(){} // RVA: 0x7FFAC354E360
        public void get_StatusCode(){} // RVA: 0x7FFAC489E530
        public void set_StatusCode(){} // RVA: 0x7FFAC489E540
        public void get_StatusDescription(){} // RVA: 0x7FFAC3543900
        public void set_StatusDescription(){} // RVA: 0x7FFAC354E420
        public void get_Version(){} // RVA: 0x7FFAC354B1A0
        public void set_Version(){} // RVA: 0x7FFAC334B370
        public void get_KeepAlive(){} // RVA: 0x7FFAC41E71E0
        public void set_KeepAlive(){} // RVA: 0x7FFAC41E6D30
        public void .ctor(){} // RVA: 0x7FFAC931F950
        public void get_CanRead(){} // RVA: 0x7FFAC3006850
        public void get_CanWrite(){} // RVA: 0x7FFAC2F21320
        public void get_ChunkedRead(){} // RVA: 0x7FFAC2F424C0
        public void set_ChunkedRead(){} // RVA: 0x7FFAC2F424D0
        public void ReadAsync(){} // RVA: 0x7FFAC931FA70
        public void ProcessRead(){} // RVA: 0x7FFAC931FCD0
        public void TryReadFromBufferedContent(){} // RVA: 0x7FFAC9320100
        public void get_ExpectContent(){} // RVA: 0x7FFAC9320230
        public void Initialize(){} // RVA: 0x7FFAC93202F0
        public void ReadAllAsyncInner(){} // RVA: 0x7FFAC93212E0
        public void ReadAllAsync(){} // RVA: 0x7FFAC93214E0
        public void WriteAsync(){} // RVA: 0x7FFAC9321720
        public void Close_internal(){} // RVA: 0x7FFAC93217C0
        public void GetReadException(){} // RVA: 0x7FFAC93218B0
        public void InitReadAsync(){} // RVA: 0x7FFAC9321C30
        public void GetResponse(){} // RVA: 0x7FFAC9321E50
    }

    public class WebUtility : Object
    {
        public char[] HtmlEncodeConformance;
        public 0x6B13FDF8 _htmlDecodeConformance; // 0x8
        public 0x6B13FE50 _htmlEncodeConformance; // 0xC

        // ── Methods ──
        public void HtmlEncode(){} // RVA: 0x7FFAC92BFAD0 | overloaded x2
        public void IndexOfHtmlEncodingChars(){} // RVA: 0x7FFAC92BFEF0
        public void get_HtmlEncodeConformance(){} // RVA: 0x7FFAC92C0000
        public void UrlEncode(){} // RVA: 0x7FFAC92C0610 | overloaded x3
        public void UrlDecodeInternal(){} // RVA: 0x7FFAC92C0740
        public void UrlDecode(){} // RVA: 0x7FFAC92C0AA0
        public void GetNextUnicodeScalarValueFromUtf16Surrogate(){} // RVA: 0x7FFAC92C0B20
        public void HexToInt(){} // RVA: 0x7FFAC92C0BF0
        public void IntToHex(){} // RVA: 0x7FFAC92C0C30
        public void IsUrlSafeChar(){} // RVA: 0x7FFAC92C0C40
        public void ValidateUrlEncodingParameters(){} // RVA: 0x7FFAC92C0CB0
        public void .cctor(){} // RVA: 0x7FFAC92C0DD0
    }

}