// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 18
// Methods: 313

namespace ThirdParty.DotNet.System.Net
{
    public class WebCompletionSource : WebCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9673E0
    }

    public class WebCompletionSource`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18C30
        public void get_CurrentResult(){} // RVA: 0x7A7E00680
        public void get_Task(){} // RVA: 0x7A7E00680
        public void TrySetCompleted(){} // RVA: 0x7A7E01900
        public void TrySetCanceled(){} // RVA: 0x7A7E019D0
        public void TrySetException(){} // RVA: 0x7A7E019D0
        public void ThrowOnError(){} // RVA: 0x7A7E18770
        public void WaitForCompletion(){} // RVA: 0x7A7E00680
    }

    public class WebCompletionSource`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC95B330
        public void get_CurrentResult(){} // RVA: 0x7A80DA7B0
        public void get_Task(){} // RVA: 0x7A88F4180
        public void TrySetCompleted(){} // RVA: 0x7AC95B580
        public void TrySetCanceled(){} // RVA: 0x7AC95B780
        public void TrySetException(){} // RVA: 0x7AC95B9A0
        public void ThrowOnError(){} // RVA: 0x7AC95BBC0
        public void WaitForCompletion(){} // RVA: 0x7AC95C040
    }

    public class WebConnection : Object
    {
        // ── Methods ──
        public void get_ServicePoint(){} // RVA: 0x7A8152D80
        public void .ctor(){} // RVA: 0x7A8152D90
        public void CanReuse(){} // RVA: 0x7AE967420
        public void CheckReusable(){} // RVA: 0x7AE967450
        public void Connect(){} // RVA: 0x7AE9674A0
        public void CreateStream(){} // RVA: 0x7AE967720
        public void InitConnection(){} // RVA: 0x7AE967990
        public void GetException(){} // RVA: 0x7AE967BE0
        public void ReadLine(){} // RVA: 0x7AE967E00
        public void CanReuseConnection(){} // RVA: 0x7AE968060
        public void PrepareSharingNtlm(){} // RVA: 0x7AE9684E0
        public void Reset(){} // RVA: 0x7AE9687A0
        public void Close(){} // RVA: 0x7AE968950
        public void CloseSocket(){} // RVA: 0x7AE968A70
        public void get_Closed(){} // RVA: 0x7AE968D80
        public void get_IdleSince(){} // RVA: 0x7A81A0050
        public void StartOperation(){} // RVA: 0x7AE968D90
        public void Continue(){} // RVA: 0x7AE969030
        public void Dispose(){} // RVA: 0x7AE969260
        public void ResetNtlm(){} // RVA: 0x7AE969280
        public void get_NtlmAuthenticated(){} // RVA: 0x7A80F26D0
        public void set_NtlmAuthenticated(){} // RVA: 0x7A80F26E0
        public void get_NtlmCredential(){} // RVA: 0x7A80F2570
        public void set_NtlmCredential(){} // RVA: 0x7A80D8E20
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7A8475E20
        public void set_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7A8D0E640
    }

    public class WebConnectionStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE96B0C0
        public void get_Request(){} // RVA: 0x7A8152D80
        public void get_Connection(){} // RVA: 0x7A8178B90
        public void get_Operation(){} // RVA: 0x7A81A0050
        public void get_ServicePoint(){} // RVA: 0x7AE96B2D0
        public void get_CanTimeout(){} // RVA: 0x7A81BD750
        public void get_ReadTimeout(){} // RVA: 0x7A8D863F0
        public void set_ReadTimeout(){} // RVA: 0x7AE96B2F0
        public void get_WriteTimeout(){} // RVA: 0x7A864E8D0
        public void set_WriteTimeout(){} // RVA: 0x7AE96B360
        public void GetException(){} // RVA: 0x7AE96B3D0
        public void TryReadFromBufferedContent(){} // RVA: 0x7A7E04800
        public void Read(){} // RVA: 0x7AE96B570
        public void BeginRead(){} // RVA: 0x7AE96B830
        public void EndRead(){} // RVA: 0x7AE96BAB0
        public void BeginWrite(){} // RVA: 0x7AE96BB80
        public void EndWrite(){} // RVA: 0x7AE96BDB0
        public void Write(){} // RVA: 0x7AE96BE60
        public void Flush(){} // RVA: 0x7A80D7310
        public void FlushAsync(){} // RVA: 0x7AE96C0A0
        public void InternalClose(){} // RVA: 0x7AE96C150
        public void Close_internal(){} // RVA: 0x7A7E18800
        public void Close(){} // RVA: 0x7AE96C160
        public void Seek(){} // RVA: 0x7AE96C180
        public void SetLength(){} // RVA: 0x7AE96C1D0
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_Length(){} // RVA: 0x7AE96C220
        public void get_Position(){} // RVA: 0x7AE96C270
        public void set_Position(){} // RVA: 0x7AE96C2C0
    }

    public class WebConnectionTunnel : Object
    {
        // ── Methods ──
        public void get_Request(){} // RVA: 0x7A80F2570
        public void get_ConnectUri(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_Success(){} // RVA: 0x7A81B7080
        public void set_Success(){} // RVA: 0x7A81B7090
        public void get_CloseConnection(){} // RVA: 0x7A8ABD450
        public void set_CloseConnection(){} // RVA: 0x7A9A784C0
        public void get_StatusCode(){} // RVA: 0x7A8133100
        public void set_StatusCode(){} // RVA: 0x7A8133110
        public void set_StatusDescription(){} // RVA: 0x7A8296DE0
        public void get_Challenge(){} // RVA: 0x7A8154D80
        public void set_Challenge(){} // RVA: 0x7A80FF440
        public void get_Headers(){} // RVA: 0x7A8152D80
        public void set_Headers(){} // RVA: 0x7A8152D90
        public void get_ProxyVersion(){} // RVA: 0x7A8178B90
        public void set_ProxyVersion(){} // RVA: 0x7A8230620
        public void get_Data(){} // RVA: 0x7A81A0050
        public void set_Data(){} // RVA: 0x7A81A0060
        public void Initialize(){} // RVA: 0x7AE96C310
        public void ReadHeaders(){} // RVA: 0x7AE96C590
        public void FlushContents(){} // RVA: 0x7AE96C7F0
    }

    public class WebException : InvalidOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9135E0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE913670
        public void GetObjectData(){} // RVA: 0x7AE912010
        public void get_Status(){} // RVA: 0x7A846C760
        public void get_Response(){} // RVA: 0x7A87D9C10
    }

    public class WebExceptionMapping : Object
    {
        // ── Methods ──
        public void GetWebStatusString(){} // RVA: 0x7AE9136A0
        public void .cctor(){} // RVA: 0x7AE913890
    }

    public class WebHeaderCollection : NameValueCollection
    {
        // ── Methods ──
        public void NormalizeCommonHeaders(){} // RVA: 0x7AE913950
        public void get_InnerCollection(){} // RVA: 0x7AE913AE0
        public void AllowMultiValues(){} // RVA: 0x7AE913BE0
        public void get_AllowHttpRequestHeader(){} // RVA: 0x7AE913CC0
        public void Remove(){} // RVA: 0x7AE9151B0
        public void AddInternal(){} // RVA: 0x7AE913E60
        public void ChangeInternal(){} // RVA: 0x7AE913ED0
        public void RemoveInternal(){} // RVA: 0x7AE913F40
        public void CheckBadChars(){} // RVA: 0x7AE913FA0
        public void ContainsNonAsciiChars(){} // RVA: 0x7AE914590
        public void ThrowOnRestrictedHeader(){} // RVA: 0x7AE914600
        public void Add(){} // RVA: 0x7AE914A20
        public void Set(){} // RVA: 0x7AE914D20
        public void SetInternal(){} // RVA: 0x7AE914F70
        public void GetValues(){} // RVA: 0x7AE9167A0
        public void ToString(){} // RVA: 0x7AE915530
        public void GetAsString(){} // RVA: 0x7AE915590
        public void .ctor(){} // RVA: 0x7AE915A30
        public void OnDeserialization(){} // RVA: 0x7A80D7310
        public void GetObjectData(){} // RVA: 0x7AE915D40
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE916330
        public void Get(){} // RVA: 0x7AE916750
        public void GetEnumerator(){} // RVA: 0x7AE9166A0
        public void get_Count(){} // RVA: 0x7AE916710
        public void GetKey(){} // RVA: 0x7AE9167F0
        public void get_AllKeys(){} // RVA: 0x7AE916840
        public void .cctor(){} // RVA: 0x7AE916890
    }

    public class WebOperation : Object
    {
        // ── Methods ──
        public void get_Request(){} // RVA: 0x7A80F2570
        public void get_Connection(){} // RVA: 0x7A80DA7B0
        public void set_Connection(){} // RVA: 0x7A813E420
        public void get_ServicePoint(){} // RVA: 0x7A81052C0
        public void set_ServicePoint(){} // RVA: 0x7A81052D0
        public void get_WriteBuffer(){} // RVA: 0x7A8105330
        public void get_IsNtlmChallenge(){} // RVA: 0x7A80FD690
        public void .ctor(){} // RVA: 0x7AE96E7F0
        public void get_Aborted(){} // RVA: 0x7AE96EC50
        public void get_Closed(){} // RVA: 0x7AE96ECB0
        public void Abort(){} // RVA: 0x7AE96ED10
        public void Close(){} // RVA: 0x7AE96ED70
        public void SetCanceled(){} // RVA: 0x7AE96EE10
        public void SetError(){} // RVA: 0x7AE96EF20
        public void SetDisposed(){} // RVA: 0x7AE96EFD0
        public void CheckDisposed(){} // RVA: 0x7AE96F1F0
        public void ThrowIfDisposed(){} // RVA: 0x7AE96F340
        public void ThrowIfClosedOrDisposed(){} // RVA: 0x7AE96F490
        public void CheckThrowDisposed(){} // RVA: 0x7AE96F590
        public void RegisterRequest(){} // RVA: 0x7AE96F610
        public void SetPriorityRequest(){} // RVA: 0x7AE96FA60
        public void GetRequestStream(){} // RVA: 0x7AE96FC30
        public void GetRequestStreamInternal(){} // RVA: 0x7AE96FDC0
        public void get_WriteStream(){} // RVA: 0x7AE96FE10
        public void GetResponseStream(){} // RVA: 0x7AE96FE70
        public void get_Finished(){} // RVA: 0x7A81A0050
        public void Run(){} // RVA: 0x7AE96FEC0
        public void CompleteRequestWritten(){} // RVA: 0x7AE9700B0
        public void Finish(){} // RVA: 0x7AE970140
        public void <RegisterRequest>b__48_0(){} // RVA: 0x7AE970530
    }

    public class WebProxy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE933E00
        public void get_Credentials(){} // RVA: 0x7A8105330
        public void get_UseDefaultCredentials(){} // RVA: 0x7AE932560
        public void set_UseDefaultCredentials(){} // RVA: 0x7AE9325D0
        public void GetProxy(){} // RVA: 0x7AE932640
        public void UpdateRegExList(){} // RVA: 0x7AE9328A0
        public void IsMatchInBypassList(){} // RVA: 0x7AE932B50
        public void IsLocal(){} // RVA: 0x7AE932D80
        public void IsLocalInProxyHash(){} // RVA: 0x7AE933100
        public void IsBypassed(){} // RVA: 0x7AE9331F0
        public void IsBypassedManual(){} // RVA: 0x7AE933330
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE919910
        public void GetObjectData(){} // RVA: 0x7AE9338B0
        public void get_ScriptEngine(){} // RVA: 0x7A8154D80
        public void CreateDefaultProxy(){} // RVA: 0x7AE933DC0
        public void UnsafeUpdateFromRegistry(){} // RVA: 0x7A847A240
        public void GetProxyAuto(){} // RVA: 0x7AE933E10
        public void IsBypassedAuto(){} // RVA: 0x7AE933F20
        public void AreAllBypassed(){} // RVA: 0x7AE933FC0
        public void ProxyUri(){} // RVA: 0x7AE934160
    }

    public class WebReadStream : Stream
    {
        // ── Methods ──
        public void get_Operation(){} // RVA: 0x7A8105330
        public void get_InnerStream(){} // RVA: 0x7A83F69F0
        public void .ctor(){} // RVA: 0x7AE9713A0
        public void get_Length(){} // RVA: 0x7AE9714B0
        public void get_Position(){} // RVA: 0x7AE9714F0
        public void set_Position(){} // RVA: 0x7AE971530
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanRead(){} // RVA: 0x7A81BD750
        public void get_CanWrite(){} // RVA: 0x7A80D7320
        public void SetLength(){} // RVA: 0x7AE971570
        public void Seek(){} // RVA: 0x7AE9715B0
        public void Write(){} // RVA: 0x7AE9715F0
        public void Flush(){} // RVA: 0x7AE971630
        public void GetException(){} // RVA: 0x7AE971670
        public void Read(){} // RVA: 0x7AE971810
        public void BeginRead(){} // RVA: 0x7AE971AD0
        public void EndRead(){} // RVA: 0x7AE971D50
        public void ReadAsync(){} // RVA: 0x7AE971E20
        public void ProcessReadAsync(){} // RVA: 0x7A7E11CC0
        public void FinishReading(){} // RVA: 0x7AE95C530
        public void Dispose(){} // RVA: 0x7AE9720A0
    }

    public class WebRequest : MarshalByRefObject
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7AE917570
        public void Create(){} // RVA: 0x7AE917C00
        public void get_PrefixList(){} // RVA: 0x7AE917CD0
        public void PopulatePrefixList(){} // RVA: 0x7AE917F20
        public void .ctor(){} // RVA: 0x7A80D7310
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE918150
        public void GetObjectData(){} // RVA: 0x7A80D7310
        public void get_DefaultCachePolicy(){} // RVA: 0x7AE918180
        public void set_CachePolicy(){} // RVA: 0x7AE918200
        public void InternalSetCachePolicy(){} // RVA: 0x7AE918200
        public void get_Method(){} // RVA: 0x7AE9182E0
        public void set_Method(){} // RVA: 0x7AE918310
        public void get_RequestUri(){} // RVA: 0x7AE918340
        public void set_ConnectionGroupName(){} // RVA: 0x7AE918370
        public void get_Headers(){} // RVA: 0x7AE9183A0
        public void get_ContentLength(){} // RVA: 0x7AE9183D0
        public void set_ContentLength(){} // RVA: 0x7AE918400
        public void get_Credentials(){} // RVA: 0x7AE918430
        public void set_Credentials(){} // RVA: 0x7AE918460
        public void get_UseDefaultCredentials(){} // RVA: 0x7AE918490
        public void get_Proxy(){} // RVA: 0x7AE9184C0
        public void set_Proxy(){} // RVA: 0x7AE9184F0
        public void set_PreAuthenticate(){} // RVA: 0x7AE918520
        public void get_Timeout(){} // RVA: 0x7AE918550
        public void set_Timeout(){} // RVA: 0x7AE918580
        public void GetResponse(){} // RVA: 0x7AE9185B0
        public void BeginGetResponse(){} // RVA: 0x7AE9185E0
        public void EndGetResponse(){} // RVA: 0x7AE918610
        public void BeginGetRequestStream(){} // RVA: 0x7AE918640
        public void EndGetRequestStream(){} // RVA: 0x7AE918670
        public void GetRequestStreamAsync(){} // RVA: 0x7AE9186A0
        public void GetResponseAsync(){} // RVA: 0x7AE9189B0
        public void SafeCaptureIdenity(){} // RVA: 0x7AE918CC0
        public void Abort(){} // RVA: 0x7AE918D10
        public void get_CacheProtocol(){} // RVA: 0x7A8105330
        public void set_CacheProtocol(){} // RVA: 0x7A80D8E80
        public void get_InternalDefaultWebProxy(){} // RVA: 0x7AE918D40
        public void .cctor(){} // RVA: 0x7AE918F90
        public void <GetRequestStreamAsync>b__78_0(){} // RVA: 0x7AE9190F0
        public void <GetResponseAsync>b__79_0(){} // RVA: 0x7AE919220
    }

    public class WebRequestPrefixElement : Object
    {
        // ── Methods ──
        public void get_Creator(){} // RVA: 0x7AE910D90
        public void set_Creator(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A8CE4080
    }

    public class WebRequestStream : WebConnectionStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE972770
        public void get_InnerStream(){} // RVA: 0x7A87C5850
        public void get_KeepAlive(){} // RVA: 0x7A835F4E0
        public void get_CanRead(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7A81BD750
        public void get_HasWriteBuffer(){} // RVA: 0x7AE972970
        public void get_WriteBufferLength(){} // RVA: 0x7AE9729A0
        public void GetWriteBuffer(){} // RVA: 0x7AE972A00
        public void FinishWriting(){} // RVA: 0x7AE972B30
        public void WriteAsync(){} // RVA: 0x7AE972D40
        public void WriteAsyncInner(){} // RVA: 0x7AE973030
        public void ProcessWrite(){} // RVA: 0x7AE973310
        public void CheckWriteOverflow(){} // RVA: 0x7AE9735B0
        public void Initialize(){} // RVA: 0x7AE973660
        public void SetHeadersAsync(){} // RVA: 0x7AE973880
        public void WriteRequestAsync(){} // RVA: 0x7AE973AC0
        public void WriteChunkTrailer_inner(){} // RVA: 0x7AE973CE0
        public void WriteChunkTrailer(){} // RVA: 0x7AE973EF0
        public void KillBuffer(){} // RVA: 0x7AD8575C0
        public void ReadAsync(){} // RVA: 0x7AE9740B0
        public void TryReadFromBufferedContent(){} // RVA: 0x7AE974160
        public void Close_internal(){} // RVA: 0x7AE9741A0
        public void .cctor(){} // RVA: 0x7AE974520
    }

    public class WebResponse : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE919910
        public void GetObjectData(){} // RVA: 0x7A80D7310
        public void Close(){} // RVA: 0x7A80D7310
        public void Dispose(){} // RVA: 0x7AE9199B0
        public void get_IsFromCache(){} // RVA: 0x7A8475E20
        public void GetResponseStream(){} // RVA: 0x7AE9199E0
        public void get_ResponseUri(){} // RVA: 0x7AE919A10
        public void get_Headers(){} // RVA: 0x7AE919A40
    }

    public class WebResponseStream : WebConnectionStream
    {
        // ── Methods ──
        public void get_RequestStream(){} // RVA: 0x7A81163D0
        public void get_Headers(){} // RVA: 0x7A8555100
        public void set_Headers(){} // RVA: 0x7A8919DE0
        public void get_StatusCode(){} // RVA: 0x7A9B79A20
        public void set_StatusCode(){} // RVA: 0x7A9B794B0
        public void get_StatusDescription(){} // RVA: 0x7A87C5850
        public void set_StatusDescription(){} // RVA: 0x7A87446C0
        public void get_Version(){} // RVA: 0x7A87D9480
        public void set_Version(){} // RVA: 0x7A8881790
        public void get_KeepAlive(){} // RVA: 0x7A94ED040
        public void set_KeepAlive(){} // RVA: 0x7A94F0290
        public void .ctor(){} // RVA: 0x7AE977FD0
        public void get_CanRead(){} // RVA: 0x7A81BD750
        public void get_CanWrite(){} // RVA: 0x7A80D7320
        public void get_ChunkedRead(){} // RVA: 0x7A80F86D0
        public void set_ChunkedRead(){} // RVA: 0x7A80F86E0
        public void ReadAsync(){} // RVA: 0x7AE9780F0
        public void ProcessRead(){} // RVA: 0x7AE978360
        public void TryReadFromBufferedContent(){} // RVA: 0x7AE978790
        public void get_ExpectContent(){} // RVA: 0x7AE9788C0
        public void Initialize(){} // RVA: 0x7AE978980
        public void ReadAllAsyncInner(){} // RVA: 0x7AE979970
        public void ReadAllAsync(){} // RVA: 0x7AE979B70
        public void WriteAsync(){} // RVA: 0x7AE979DB0
        public void Close_internal(){} // RVA: 0x7AE979E50
        public void GetReadException(){} // RVA: 0x7AE979F40
        public void InitReadAsync(){} // RVA: 0x7AE97A2C0
        public void GetResponse(){} // RVA: 0x7AE97A4E0
    }

    public class WebUtility : Object
    {
        // ── Methods ──
        public void HtmlEncode(){} // RVA: 0x7AE919BA0
        public void IndexOfHtmlEncodingChars(){} // RVA: 0x7AE919FC0
        public void get_HtmlEncodeConformance(){} // RVA: 0x7AE91A0D0
        public void UrlEncode(){} // RVA: 0x7AE91A720
        public void UrlDecodeInternal(){} // RVA: 0x7AE91A850
        public void UrlDecode(){} // RVA: 0x7AE91ABB0
        public void GetNextUnicodeScalarValueFromUtf16Surrogate(){} // RVA: 0x7AE91AC30
        public void HexToInt(){} // RVA: 0x7AE91AD00
        public void IntToHex(){} // RVA: 0x7AE91AD40
        public void IsUrlSafeChar(){} // RVA: 0x7AE91AD50
        public void ValidateUrlEncodingParameters(){} // RVA: 0x7AE91ADC0
        public void .cctor(){} // RVA: 0x7AE91AEE0
    }

}