// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 18
// Methods: 346

namespace ThirdParty.DotNet.System.Net
{
    public class WebCompletionSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96280A0
    }

    public class WebCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD5130
        public void get_CurrentResult(){} // RVA: 0x7FFAF2ABCD60
        public void get_Task(){} // RVA: 0x7FFAF2ABCD60
        public void TrySetCompleted(){} // RVA: 0x7FFAF2ABDBE0 | overloaded x2
        public void TrySetCanceled(){} // RVA: 0x7FFAF2ABDE40 | overloaded x2
        public void TrySetException(){} // RVA: 0x7FFAF2ABDE40
        public void ThrowOnError(){} // RVA: 0x7FFAF2AD4A50
        public void WaitForCompletion(){} // RVA: 0x7FFAF2ABCD60
    }

    public class WebCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF760D690
        public void get_CurrentResult(){} // RVA: 0x7FFAF2D907C0
        public void get_Task(){} // RVA: 0x7FFAF35DECF0
        public void TrySetCompleted(){} // RVA: 0x7FFAF760D8E0 | overloaded x2
        public void TrySetCanceled(){} // RVA: 0x7FFAF760DAE0 | overloaded x2
        public void TrySetException(){} // RVA: 0x7FFAF760DD00
        public void ThrowOnError(){} // RVA: 0x7FFAF760DF20
        public void WaitForCompletion(){} // RVA: 0x7FFAF760E3A0
    }

    public class WebConnection
    {
        // ── Methods ──
        public void get_ServicePoint(){} // RVA: 0x7FFAF2E08730
        public void .ctor(){} // RVA: 0x7FFAF2E08740
        public void CanReuse(){} // RVA: 0x7FFAF96280E0
        public void CheckReusable(){} // RVA: 0x7FFAF9628110
        public void Connect(){} // RVA: 0x7FFAF9628160
        public void CreateStream(){} // RVA: 0x7FFAF96283E0
        public void InitConnection(){} // RVA: 0x7FFAF9628650
        public void GetException(){} // RVA: 0x7FFAF96288A0
        public void ReadLine(){} // RVA: 0x7FFAF9628AC0
        public void CanReuseConnection(){} // RVA: 0x7FFAF9628D20
        public void PrepareSharingNtlm(){} // RVA: 0x7FFAF96291D0
        public void Reset(){} // RVA: 0x7FFAF9629480
        public void Close(){} // RVA: 0x7FFAF9629670
        public void CloseSocket(){} // RVA: 0x7FFAF96297C0
        public void get_Closed(){} // RVA: 0x7FFAF9629B00
        public void get_IdleSince(){} // RVA: 0x7FFAF2E55500
        public void StartOperation(){} // RVA: 0x7FFAF9629B10
        public void Continue(){} // RVA: 0x7FFAF9629DF0
        public void Dispose(){} // RVA: 0x7FFAF962A050 | overloaded x2
        public void ResetNtlm(){} // RVA: 0x7FFAF962A070
        public void get_NtlmAuthenticated(){} // RVA: 0x7FFAF2DA84E0
        public void set_NtlmAuthenticated(){} // RVA: 0x7FFAF2DA84F0
        public void get_NtlmCredential(){} // RVA: 0x7FFAF2DA8380
        public void set_NtlmCredential(){} // RVA: 0x7FFAF2D8EE30
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7FFAF31693D0
        public void set_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7FFAF39F3D70
    }

    public class WebConnectionStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF962BEA0
        public void get_Request(){} // RVA: 0x7FFAF2E08730
        public void get_Connection(){} // RVA: 0x7FFAF2E2E0E0
        public void get_Operation(){} // RVA: 0x7FFAF2E55500
        public void get_ServicePoint(){} // RVA: 0x7FFAF962C0B0
        public void get_CanTimeout(){} // RVA: 0x7FFAF2E72850
        public void get_ReadTimeout(){} // RVA: 0x7FFAF3A8C9F0
        public void set_ReadTimeout(){} // RVA: 0x7FFAF962C0D0
        public void get_WriteTimeout(){} // RVA: 0x7FFAF3341AF0
        public void set_WriteTimeout(){} // RVA: 0x7FFAF962C140
        public void GetException(){} // RVA: 0x7FFAF962C1B0
        public void TryReadFromBufferedContent(){}
        public void Read(){} // RVA: 0x7FFAF962C350
        public void BeginRead(){} // RVA: 0x7FFAF962C610
        public void EndRead(){} // RVA: 0x7FFAF962C890
        public void BeginWrite(){} // RVA: 0x7FFAF962C960
        public void EndWrite(){} // RVA: 0x7FFAF962CB90
        public void Write(){} // RVA: 0x7FFAF962CC40
        public void Flush(){} // RVA: 0x7FFAF2D8D310
        public void FlushAsync(){} // RVA: 0x7FFAF962CE80
        public void InternalClose(){} // RVA: 0x7FFAF962CF30
        public void Close_internal(){} // RVA: 0x7FFAF2AD4B10
        public void Close(){} // RVA: 0x7FFAF962CF40
        public void Seek(){} // RVA: 0x7FFAF962CF60
        public void SetLength(){} // RVA: 0x7FFAF962CFB0
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_Length(){} // RVA: 0x7FFAF962D000
        public void get_Position(){} // RVA: 0x7FFAF962D050
        public void set_Position(){} // RVA: 0x7FFAF962D0A0
    }

    public class WebConnectionTunnel
    {
        // ── Methods ──
        public void get_Request(){} // RVA: 0x7FFAF2DA8380
        public void get_ConnectUri(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void get_Success(){} // RVA: 0x7FFAF2E6C230
        public void set_Success(){} // RVA: 0x7FFAF2E6C240
        public void get_CloseConnection(){} // RVA: 0x7FFAF2FADE20
        public void set_CloseConnection(){} // RVA: 0x7FFAF2FAC950
        public void get_StatusCode(){} // RVA: 0x7FFAF2DE8CD0
        public void set_StatusCode(){} // RVA: 0x7FFAF2DE8CE0
        public void set_StatusDescription(){} // RVA: 0x7FFAF2F4B830
        public void get_Challenge(){} // RVA: 0x7FFAF2E0A740
        public void set_Challenge(){} // RVA: 0x7FFAF2DB5200
        public void get_Headers(){} // RVA: 0x7FFAF2E08730
        public void set_Headers(){} // RVA: 0x7FFAF2E08740
        public void get_ProxyVersion(){} // RVA: 0x7FFAF2E2E0E0
        public void set_ProxyVersion(){} // RVA: 0x7FFAF2EE54D0
        public void get_Data(){} // RVA: 0x7FFAF2E55500
        public void set_Data(){} // RVA: 0x7FFAF2E55510
        public void Initialize(){} // RVA: 0x7FFAF962D0F0
        public void ReadHeaders(){} // RVA: 0x7FFAF962D370
        public void FlushContents(){} // RVA: 0x7FFAF962D5D0
    }

    public class WebException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95D2900 | overloaded x10
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF95D2990
        public void GetObjectData(){} // RVA: 0x7FFAF95D1340
        public void get_Status(){} // RVA: 0x7FFAF315FD40
        public void get_Response(){} // RVA: 0x7FFAF34CC8C0
    }

    public class WebExceptionMapping
    {
        // ── Methods ──
        public void GetWebStatusString(){} // RVA: 0x7FFAF95D29C0
        public void .cctor(){} // RVA: 0x7FFAF95D2BB0
    }

    public class WebHeaderCollection
    {
        // ── Methods ──
        public void NormalizeCommonHeaders(){} // RVA: 0x7FFAF95D2C70
        public void get_InnerCollection(){} // RVA: 0x7FFAF95D2E00
        public void AllowMultiValues(){} // RVA: 0x7FFAF95D2F00
        public void get_AllowHttpRequestHeader(){} // RVA: 0x7FFAF95D2FE0
        public void Remove(){} // RVA: 0x7FFAF95D44D0 | overloaded x2
        public void AddInternal(){} // RVA: 0x7FFAF95D3180
        public void ChangeInternal(){} // RVA: 0x7FFAF95D31F0
        public void RemoveInternal(){} // RVA: 0x7FFAF95D3260
        public void CheckBadChars(){} // RVA: 0x7FFAF95D32C0
        public void ContainsNonAsciiChars(){} // RVA: 0x7FFAF95D38B0
        public void ThrowOnRestrictedHeader(){} // RVA: 0x7FFAF95D3920
        public void Add(){} // RVA: 0x7FFAF95D3D40 | overloaded x2
        public void Set(){} // RVA: 0x7FFAF95D4040
        public void SetInternal(){} // RVA: 0x7FFAF95D4290
        public void GetValues(){} // RVA: 0x7FFAF95D5AC0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF95D4850
        public void GetAsString(){} // RVA: 0x7FFAF95D48B0
        public void .ctor(){} // RVA: 0x7FFAF95D4D60 | overloaded x3
        public void OnDeserialization(){} // RVA: 0x7FFAF2D8D310
        public void GetObjectData(){} // RVA: 0x7FFAF95D5070
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF95D5660
        public void Get(){} // RVA: 0x7FFAF95D5A70 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAF95D59C0
        public void get_Count(){} // RVA: 0x7FFAF95D5A30
        public void GetKey(){} // RVA: 0x7FFAF95D5B10
        public void get_AllKeys(){} // RVA: 0x7FFAF95D5B60
        public void .cctor(){} // RVA: 0x7FFAF95D5BB0
    }

    public class WebOperation
    {
        // ── Methods ──
        public void get_Request(){} // RVA: 0x7FFAF2DA8380
        public void get_Connection(){} // RVA: 0x7FFAF2D907C0
        public void set_Connection(){} // RVA: 0x7FFAF2DF3E80
        public void get_ServicePoint(){} // RVA: 0x7FFAF2DBB0C0
        public void set_ServicePoint(){} // RVA: 0x7FFAF2DBB0D0
        public void get_WriteBuffer(){} // RVA: 0x7FFAF2DBB130
        public void get_IsNtlmChallenge(){} // RVA: 0x7FFAF2DB3450
        public void .ctor(){} // RVA: 0x7FFAF962F5C0
        public void get_Aborted(){} // RVA: 0x7FFAF962FA10
        public void get_Closed(){} // RVA: 0x7FFAF962FA70
        public void Abort(){} // RVA: 0x7FFAF962FAD0
        public void Close(){} // RVA: 0x7FFAF962FB30
        public void SetCanceled(){} // RVA: 0x7FFAF962FBD0
        public void SetError(){} // RVA: 0x7FFAF962FCE0
        public void SetDisposed(){} // RVA: 0x7FFAF962FD90
        public void CheckDisposed(){} // RVA: 0x7FFAF962FFB0
        public void ThrowIfDisposed(){} // RVA: 0x7FFAF9630100 | overloaded x2
        public void ThrowIfClosedOrDisposed(){} // RVA: 0x7FFAF9630250 | overloaded x2
        public void CheckThrowDisposed(){} // RVA: 0x7FFAF9630350
        public void RegisterRequest(){} // RVA: 0x7FFAF96303D0
        public void SetPriorityRequest(){} // RVA: 0x7FFAF9630850
        public void GetRequestStream(){} // RVA: 0x7FFAF9630A50
        public void GetRequestStreamInternal(){} // RVA: 0x7FFAF9630BE0
        public void get_WriteStream(){} // RVA: 0x7FFAF9630C30
        public void GetResponseStream(){} // RVA: 0x7FFAF9630C90
        public void get_Finished(){} // RVA: 0x7FFAF2E55500
        public void Run(){} // RVA: 0x7FFAF9630CE0
        public void CompleteRequestWritten(){} // RVA: 0x7FFAF9630EC0
        public void Finish(){} // RVA: 0x7FFAF9630F50
        public void <RegisterRequest>b__48_0(){} // RVA: 0x7FFAF9631360
    }

    public class WebProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95F3BF0 | overloaded x4
        public void get_Credentials(){} // RVA: 0x7FFAF2DBB130
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFAF95F2130
        public void set_UseDefaultCredentials(){} // RVA: 0x7FFAF95F21A0
        public void GetProxy(){} // RVA: 0x7FFAF95F2210
        public void UpdateRegExList(){} // RVA: 0x7FFAF95F2470
        public void IsMatchInBypassList(){} // RVA: 0x7FFAF95F2720
        public void IsLocal(){} // RVA: 0x7FFAF95F2940
        public void IsLocalInProxyHash(){} // RVA: 0x7FFAF95F2EF0
        public void IsBypassed(){} // RVA: 0x7FFAF95F2FE0
        public void IsBypassedManual(){} // RVA: 0x7FFAF95F3120
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF95D8CC0
        public void GetObjectData(){} // RVA: 0x7FFAF95F36A0
        public void get_ScriptEngine(){} // RVA: 0x7FFAF2E0A740
        public void CreateDefaultProxy(){} // RVA: 0x7FFAF95F3BB0
        public void UnsafeUpdateFromRegistry(){} // RVA: 0x7FFAF316D7E0
        public void GetProxyAuto(){} // RVA: 0x7FFAF95F3C00
        public void IsBypassedAuto(){} // RVA: 0x7FFAF95F3D10
        public void AreAllBypassed(){} // RVA: 0x7FFAF95F3DB0
        public void ProxyUri(){} // RVA: 0x7FFAF95F3F50
    }

    public class WebReadStream
    {
        // ── Methods ──
        public void get_Operation(){} // RVA: 0x7FFAF2DBB130
        public void get_InnerStream(){} // RVA: 0x7FFAF30E74D0
        public void .ctor(){} // RVA: 0x7FFAF96321D0
        public void get_Length(){} // RVA: 0x7FFAF96322E0
        public void get_Position(){} // RVA: 0x7FFAF9632320
        public void set_Position(){} // RVA: 0x7FFAF9632360
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanRead(){} // RVA: 0x7FFAF2E72850
        public void get_CanWrite(){} // RVA: 0x7FFAF2D8D320
        public void SetLength(){} // RVA: 0x7FFAF96323A0
        public void Seek(){} // RVA: 0x7FFAF96323E0
        public void Write(){} // RVA: 0x7FFAF9632420
        public void Flush(){} // RVA: 0x7FFAF9632460
        public void GetException(){} // RVA: 0x7FFAF96324A0
        public void Read(){} // RVA: 0x7FFAF9632640
        public void BeginRead(){} // RVA: 0x7FFAF9632900
        public void EndRead(){} // RVA: 0x7FFAF9632B80
        public void ReadAsync(){} // RVA: 0x7FFAF9632C50
        public void ProcessReadAsync(){}
        public void FinishReading(){} // RVA: 0x7FFAF961CFF0
        public void Dispose(){} // RVA: 0x7FFAF9632ED0
    }

    public class WebRequest
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFAF95D68A0
        public void Create(){} // RVA: 0x7FFAF95D6F30 | overloaded x3
        public void get_PrefixList(){} // RVA: 0x7FFAF95D7000
        public void PopulatePrefixList(){} // RVA: 0x7FFAF95D7280
        public void .ctor(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF95D74B0
        public void GetObjectData(){} // RVA: 0x7FFAF2D8D310
        public void get_DefaultCachePolicy(){} // RVA: 0x7FFAF95D74E0
        public void set_CachePolicy(){} // RVA: 0x7FFAF95D7560
        public void InternalSetCachePolicy(){} // RVA: 0x7FFAF95D7560
        public void get_Method(){} // RVA: 0x7FFAF95D7640
        public void set_Method(){} // RVA: 0x7FFAF95D7670
        public void get_RequestUri(){} // RVA: 0x7FFAF95D76A0
        public void set_ConnectionGroupName(){} // RVA: 0x7FFAF95D76D0
        public void get_Headers(){} // RVA: 0x7FFAF95D7700
        public void get_ContentLength(){} // RVA: 0x7FFAF95D7730
        public void set_ContentLength(){} // RVA: 0x7FFAF95D7760
        public void get_Credentials(){} // RVA: 0x7FFAF95D7790
        public void set_Credentials(){} // RVA: 0x7FFAF95D77C0
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFAF95D77F0
        public void get_Proxy(){} // RVA: 0x7FFAF95D7820
        public void set_Proxy(){} // RVA: 0x7FFAF95D7850
        public void set_PreAuthenticate(){} // RVA: 0x7FFAF95D7880
        public void get_Timeout(){} // RVA: 0x7FFAF95D78B0
        public void set_Timeout(){} // RVA: 0x7FFAF95D78E0
        public void GetResponse(){} // RVA: 0x7FFAF95D7910
        public void BeginGetResponse(){} // RVA: 0x7FFAF95D7940
        public void EndGetResponse(){} // RVA: 0x7FFAF95D7970
        public void BeginGetRequestStream(){} // RVA: 0x7FFAF95D79A0
        public void EndGetRequestStream(){} // RVA: 0x7FFAF95D79D0
        public void GetRequestStreamAsync(){} // RVA: 0x7FFAF95D7A00
        public void GetResponseAsync(){} // RVA: 0x7FFAF95D7D10
        public void SafeCaptureIdenity(){} // RVA: 0x7FFAF95D8020
        public void Abort(){} // RVA: 0x7FFAF95D8070
        public void get_CacheProtocol(){} // RVA: 0x7FFAF2DBB130
        public void set_CacheProtocol(){} // RVA: 0x7FFAF2D8EE90
        public void get_InternalDefaultWebProxy(){} // RVA: 0x7FFAF95D80A0
        public void .cctor(){} // RVA: 0x7FFAF95D8320
        public void <GetRequestStreamAsync>b__78_0(){} // RVA: 0x7FFAF95D8480
        public void <GetResponseAsync>b__79_0(){} // RVA: 0x7FFAF95D85B0
    }

    public class WebRequestPrefixElement
    {
        // ── Methods ──
        public void get_Creator(){} // RVA: 0x7FFAF95D00B0
        public void set_Creator(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
    }

    public class WebRequestStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96335A0
        public void get_InnerStream(){} // RVA: 0x7FFAF34B85E0
        public void get_KeepAlive(){} // RVA: 0x7FFAF3056180
        public void get_CanRead(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF2E72850
        public void get_HasWriteBuffer(){} // RVA: 0x7FFAF9633790
        public void get_WriteBufferLength(){} // RVA: 0x7FFAF96337C0
        public void GetWriteBuffer(){} // RVA: 0x7FFAF9633820
        public void FinishWriting(){} // RVA: 0x7FFAF9633950
        public void WriteAsync(){} // RVA: 0x7FFAF9633B60
        public void WriteAsyncInner(){} // RVA: 0x7FFAF9633E50
        public void ProcessWrite(){} // RVA: 0x7FFAF9634120
        public void CheckWriteOverflow(){} // RVA: 0x7FFAF96343C0
        public void Initialize(){} // RVA: 0x7FFAF9634470
        public void SetHeadersAsync(){} // RVA: 0x7FFAF9634690
        public void WriteRequestAsync(){} // RVA: 0x7FFAF96348D0
        public void WriteChunkTrailer_inner(){} // RVA: 0x7FFAF9634AF0
        public void WriteChunkTrailer(){} // RVA: 0x7FFAF9634D00
        public void KillBuffer(){} // RVA: 0x7FFAF851A920
        public void ReadAsync(){} // RVA: 0x7FFAF9634EC0
        public void TryReadFromBufferedContent(){} // RVA: 0x7FFAF9634F70
        public void Close_internal(){} // RVA: 0x7FFAF9634FB0
        public void .cctor(){} // RVA: 0x7FFAF9635330
    }

    public class WebResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF95D8CC0
        public void GetObjectData(){} // RVA: 0x7FFAF2D8D310
        public void Close(){} // RVA: 0x7FFAF2D8D310
        public void Dispose(){} // RVA: 0x7FFAF95D8D60 | overloaded x2
        public void get_IsFromCache(){} // RVA: 0x7FFAF31693D0
        public void GetResponseStream(){} // RVA: 0x7FFAF95D8D90
        public void get_ResponseUri(){} // RVA: 0x7FFAF95D8DC0
        public void get_Headers(){} // RVA: 0x7FFAF95D8DF0
    }

    public class WebResponseStream
    {
        // ── Methods ──
        public void get_RequestStream(){} // RVA: 0x7FFAF2DCC010
        public void get_Headers(){} // RVA: 0x7FFAF3246DE0
        public void set_Headers(){} // RVA: 0x7FFAF3604600
        public void get_StatusCode(){} // RVA: 0x7FFAF4826570
        public void set_StatusCode(){} // RVA: 0x7FFAF4826000
        public void get_StatusDescription(){} // RVA: 0x7FFAF34B85E0
        public void set_StatusDescription(){} // RVA: 0x7FFAF345A5F0
        public void get_Version(){} // RVA: 0x7FFAF34CC130
        public void set_Version(){} // RVA: 0x7FFAF3595030
        public void get_KeepAlive(){} // RVA: 0x7FFAF41E23D0
        public void set_KeepAlive(){} // RVA: 0x7FFAF41E5610
        public void .ctor(){} // RVA: 0x7FFAF9638DD0
        public void get_CanRead(){} // RVA: 0x7FFAF2E72850
        public void get_CanWrite(){} // RVA: 0x7FFAF2D8D320
        public void get_ChunkedRead(){} // RVA: 0x7FFAF2DAE4C0
        public void set_ChunkedRead(){} // RVA: 0x7FFAF2DAE4D0
        public void ReadAsync(){} // RVA: 0x7FFAF9638EF0
        public void ProcessRead(){} // RVA: 0x7FFAF9639150
        public void TryReadFromBufferedContent(){} // RVA: 0x7FFAF9639580
        public void get_ExpectContent(){} // RVA: 0x7FFAF96396B0
        public void Initialize(){} // RVA: 0x7FFAF9639770
        public void ReadAllAsyncInner(){} // RVA: 0x7FFAF963A760
        public void ReadAllAsync(){} // RVA: 0x7FFAF963A960
        public void WriteAsync(){} // RVA: 0x7FFAF963ABA0
        public void Close_internal(){} // RVA: 0x7FFAF963AC40
        public void GetReadException(){} // RVA: 0x7FFAF963AD30
        public void InitReadAsync(){} // RVA: 0x7FFAF963B0B0
        public void GetResponse(){} // RVA: 0x7FFAF963B2D0
    }

    public class WebUtility
    {
        // ── Methods ──
        public void HtmlEncode(){} // RVA: 0x7FFAF95D8F50 | overloaded x2
        public void IndexOfHtmlEncodingChars(){} // RVA: 0x7FFAF95D9370
        public void get_HtmlEncodeConformance(){} // RVA: 0x7FFAF95D9480
        public void UrlEncode(){} // RVA: 0x7FFAF95D9A90 | overloaded x3
        public void UrlDecodeInternal(){} // RVA: 0x7FFAF95D9BC0
        public void UrlDecode(){} // RVA: 0x7FFAF95D9F20
        public void GetNextUnicodeScalarValueFromUtf16Surrogate(){} // RVA: 0x7FFAF95D9FA0
        public void HexToInt(){} // RVA: 0x7FFAF95DA070
        public void IntToHex(){} // RVA: 0x7FFAF95DA0B0
        public void IsUrlSafeChar(){} // RVA: 0x7FFAF95DA0C0
        public void ValidateUrlEncodingParameters(){} // RVA: 0x7FFAF95DA130
        public void .cctor(){} // RVA: 0x7FFAF95DA250
    }

}