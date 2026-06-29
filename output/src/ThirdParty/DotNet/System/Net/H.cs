// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 21
// Methods: 252

namespace ThirdParty.DotNet.System.Net
{
    public class HeaderInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE91B430
    }

    public class HeaderInfoTable : Object
    {
        // ── Methods ──
        public void ParseSingleValue(){} // RVA: 0x7AE91B500
        public void ParseMultiValue(){} // RVA: 0x7AE91B570
        public void .cctor(){} // RVA: 0x7AE91B850
        public void get_Item(){} // RVA: 0x7AE91DA40
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class HeaderParser : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC426AF0
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class HeaderVariantInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7613470
        public void get_Name(){} // RVA: 0x7A765F710
        public void get_Variant(){} // RVA: 0x7A75FEFA0
    }

    public class HttpConnection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE941040
        public void Init(){} // RVA: 0x7AE9414F0
        public void get_Reuses(){} // RVA: 0x7A8355900
        public void get_LocalEndPoint(){} // RVA: 0x7AE941760
        public void get_IsSecure(){} // RVA: 0x7ACF04410
        public void set_Prefix(){} // RVA: 0x7A8152D90
        public void OnTimeout(){} // RVA: 0x7AE9418A0
        public void BeginReadRequest(){} // RVA: 0x7AE9418F0
        public void GetRequestStream(){} // RVA: 0x7AE941C20
        public void GetResponseStream(){} // RVA: 0x7AE942120
        public void OnRead(){} // RVA: 0x7AE942260
        public void OnReadInternal(){} // RVA: 0x7AE942300
        public void RemoveConnection(){} // RVA: 0x7AE942840
        public void ProcessInput(){} // RVA: 0x7AE9428A0
        public void ReadLine(){} // RVA: 0x7AE942B80
        public void SendError(){} // RVA: 0x7AE943070
        public void Unbind(){} // RVA: 0x7AE9430A0
        public void CloseSocket(){} // RVA: 0x7AE9430F0
        public void Close(){} // RVA: 0x7AE9431C0
        public void .cctor(){} // RVA: 0x7AE943670
        public void <.ctor>b__24_0(){} // RVA: 0x7AE943750
    }

    public class HttpContinueDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8234420
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class HttpListener : Object
    {
        // ── Methods ──
        public void LoadCertificateAndKey(){} // RVA: 0x7AE943900
        public void CreateSslStream(){} // RVA: 0x7AE943E40
        public void .ctor(){} // RVA: 0x7AE944110
        public void get_AuthenticationSchemes(){} // RVA: 0x7A854FDE0
        public void get_AuthenticationSchemeSelectorDelegate(){} // RVA: 0x7A8292C30
        public void get_IgnoreWriteExceptions(){} // RVA: 0x7A818F850
        public void get_IsListening(){} // RVA: 0x7A9476890
        public void get_Prefixes(){} // RVA: 0x7AE9446E0
        public void get_Realm(){} // RVA: 0x7A8154D80
        public void Close(){} // RVA: 0x7AE944740
        public void Cleanup(){} // RVA: 0x7AE9447C0
        public void BeginGetContext(){} // RVA: 0x7AE9452F0
        public void EndGetContext(){} // RVA: 0x7AE945860
        public void SelectAuthenticationScheme(){} // RVA: 0x7AE945D10
        public void Start(){} // RVA: 0x7AE945D50
        public void Stop(){} // RVA: 0x7AE945DC0
        public void System.IDisposable.Dispose(){} // RVA: 0x7AE945DF0
        public void CheckDisposed(){} // RVA: 0x7AE945E20
        public void GetContextFromQueue(){} // RVA: 0x7AE945EB0
        public void RegisterContext(){} // RVA: 0x7AE945F80
        public void UnregisterContext(){} // RVA: 0x7AE946460
        public void AddConnection(){} // RVA: 0x7AE946710
        public void RemoveConnection(){} // RVA: 0x7AE946740
    }

    public class HttpListenerBasicIdentity : GenericIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE946770
    }

    public class HttpListenerContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE946830
        public void get_ErrorStatus(){} // RVA: 0x7A8D863F0
        public void set_ErrorStatus(){} // RVA: 0x7A8D870E0
        public void get_ErrorMessage(){} // RVA: 0x7A83F69F0
        public void set_ErrorMessage(){} // RVA: 0x7A8105A90
        public void get_HaveError(){} // RVA: 0x7ACDAB700
        public void get_Connection(){} // RVA: 0x7A8105330
        public void get_Request(){} // RVA: 0x7A80F2570
        public void get_Response(){} // RVA: 0x7A80DA7B0
        public void ParseAuthentication(){} // RVA: 0x7AE946B50
        public void ParseBasicAuthentication(){} // RVA: 0x7AE946CA0
    }

    public class HttpListenerException : Win32Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE90D430
        public void get_ErrorCode(){} // RVA: 0x7A846C760
    }

    public class HttpListenerPrefixCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE946F70
        public void get_Count(){} // RVA: 0x7AE947090
        public void get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void Add(){} // RVA: 0x7AE9470E0
        public void Clear(){} // RVA: 0x7AE947210
        public void Contains(){} // RVA: 0x7AE9472D0
        public void CopyTo(){} // RVA: 0x7AE947340
        public void GetEnumerator(){} // RVA: 0x7AE9473D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AE9474C0
        public void Remove(){} // RVA: 0x7AE9475B0
    }

    public class HttpListenerRequest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9476E0
        public void SetRequestLine(){} // RVA: 0x7AE947890
        public void CreateQueryString(){} // RVA: 0x7AE947D30
        public void MaybeUri(){} // RVA: 0x7AE948120
        public void IsPredefinedScheme(){} // RVA: 0x7AE9481C0
        public void FinishInitialization(){} // RVA: 0x7AE9484C0
        public void Unquote(){} // RVA: 0x7AE949220
        public void AddHeader(){} // RVA: 0x7AE9492A0
        public void FlushInput(){} // RVA: 0x7AE949F00
        public void get_HasEntityBody(){} // RVA: 0x7AE94A1C0
        public void get_Headers(){} // RVA: 0x7A8292C30
        public void get_InputStream(){} // RVA: 0x7AE94A1E0
        public void get_IsSecureConnection(){} // RVA: 0x7AE94A2F0
        public void get_KeepAlive(){} // RVA: 0x7AE94A320
        public void get_LocalEndPoint(){} // RVA: 0x7AE94A630
        public void get_ProtocolVersion(){} // RVA: 0x7A8178B90
        public void get_RawUrl(){} // RVA: 0x7A8175DF0
        public void get_Url(){} // RVA: 0x7A8153390
        public void get_UserHostAddress(){} // RVA: 0x7AE94A780
        public void get_UserHostName(){} // RVA: 0x7AE94A7C0
        public void .cctor(){} // RVA: 0x7AE94A820
    }

    public class HttpListenerRequestUriBuilder : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE90D4F0
        public void .ctor(){} // RVA: 0x7AE90D750
        public void GetRequestUri(){} // RVA: 0x7AE90DA30
        public void Build(){} // RVA: 0x7AE90DBA0
        public void BuildRequestUriUsingCookedPath(){} // RVA: 0x7AE90DC90
        public void BuildRequestUriUsingRawPath(){} // RVA: 0x7AE90E400
        public void GetEncoding(){} // RVA: 0x7AE90E370
        public void ParseRawPath(){} // RVA: 0x7AE90E760
        public void AppendUnicodeCodePointValuePercentEncoded(){} // RVA: 0x7AE90E920
        public void AddPercentEncodedOctetToRawOctetsList(){} // RVA: 0x7AE90ED30
        public void EmptyDecodeAndAppendRawOctetsList(){} // RVA: 0x7AE90EF60
        public void AppendOctetsPercentEncoded(){} // RVA: 0x7AE90F320
        public void GetOctetsAsString(){} // RVA: 0x7AE90F6A0
        public void GetPath(){} // RVA: 0x7AE90F980
        public void AddSlashToAsteriskOnlyPath(){} // RVA: 0x7AE90FCE0
        public void LogWarning(){} // RVA: 0x7A80D7310
    }

    public class HttpListenerResponse : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE94A9C0
        public void get_ForceCloseChunked(){} // RVA: 0x7A862ABC0
        public void get_ContentEncoding(){} // RVA: 0x7AE94AC40
        public void set_ContentLength64(){} // RVA: 0x7AE94ACC0
        public void set_ContentType(){} // RVA: 0x7AE94AE00
        public void get_Headers(){} // RVA: 0x7A8154D80
        public void get_OutputStream(){} // RVA: 0x7AE94AF20
        public void get_SendChunked(){} // RVA: 0x7A865DD90
        public void set_SendChunked(){} // RVA: 0x7AE94AFB0
        public void set_StatusCode(){} // RVA: 0x7AE94B080
        public void System.IDisposable.Dispose(){} // RVA: 0x7AE94B1D0
        public void Close(){} // RVA: 0x7AE94B280
        public void SendHeaders(){} // RVA: 0x7AE94B360
        public void FormatHeaders(){} // RVA: 0x7AE94C0A0
        public void CookieToClientString(){} // RVA: 0x7AE94C330
        public void QuotedString(){} // RVA: 0x7AE94C660
        public void IsToken(){} // RVA: 0x7AE94C800
        public void .cctor(){} // RVA: 0x7AE94C910
    }

    public class HttpRequestCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AE94C9C0
    }

    public class HttpStatusDescription : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7AEAB90A0
    }

    public class HttpStreamAsyncResult : Object
    {
        // ── Methods ──
        public void Complete(){} // RVA: 0x7AE94CA80
        public void get_AsyncState(){} // RVA: 0x7A8154D80
        public void get_AsyncWaitHandle(){} // RVA: 0x7AE94CBF0
        public void get_CompletedSynchronously(){} // RVA: 0x7AE94CDD0
        public void get_IsCompleted(){} // RVA: 0x7AE94CDE0
        public void .ctor(){} // RVA: 0x7AE94CEF0
    }

    public class HttpValidationHelpers : Object
    {
        // ── Methods ──
        public void IsInvalidMethodOrHeaderString(){} // RVA: 0x7AEAB99D0
        public void .cctor(){} // RVA: 0x7AEAB9B30
    }

    public class HttpVersion : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AEABBED0
    }

    public class HttpWebRequest : WebRequest
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE94CF80
        public void .ctor(){} // RVA: 0x7AE953770
        public void ResetAuthorization(){} // RVA: 0x7AE94D8F0
        public void get_Address(){} // RVA: 0x7A8154D80
        public void set_AllowAutoRedirect(){} // RVA: 0x7A9107BD0
        public void get_AllowWriteStreamBuffering(){} // RVA: 0x7A9476890
        public void set_AllowWriteStreamBuffering(){} // RVA: 0x7A9475F50
        public void get_AutomaticDecompression(){} // RVA: 0x7AE94DA90
        public void set_AutomaticDecompression(){} // RVA: 0x7AE94DAA0
        public void get_InternalAllowBuffering(){} // RVA: 0x7AE94DB10
        public void get_MethodWithBuffer(){} // RVA: 0x7AE94DB20
        public void get_TlsProvider(){} // RVA: 0x7A8142BC0
        public void get_TlsSettings(){} // RVA: 0x7A8142C30
        public void get_ClientCertificates(){} // RVA: 0x7AE94DD10
        public void set_ConnectionGroupName(){} // RVA: 0x7A81A0060
        public void get_ContentLength(){} // RVA: 0x7A8153390
        public void set_ContentLength(){} // RVA: 0x7AE94DDC0
        public void set_InternalContentLength(){} // RVA: 0x7A9D11620
        public void get_ThrowOnError(){} // RVA: 0x7AE068FA0
        public void set_ThrowOnError(){} // RVA: 0x7AE94DE90
        public void set_CookieContainer(){} // RVA: 0x7A82C0530
        public void get_Credentials(){} // RVA: 0x7A825E100
        public void set_Credentials(){} // RVA: 0x7A825F860
        public void get_DefaultMaximumErrorResponseLength(){} // RVA: 0x7AE94DEA0
        public void get_Headers(){} // RVA: 0x7A8555100
        public void get_Host(){} // RVA: 0x7AE94DF00
        public void set_Host(){} // RVA: 0x7AE94E090
        public void TryGetHostUri(){} // RVA: 0x7AE94E340
        public void get_KeepAlive(){} // RVA: 0x7A862ABC0
        public void set_KeepAlive(){} // RVA: 0x7A862ABD0
        public void set_MaximumAutomaticRedirections(){} // RVA: 0x7AE94E420
        public void get_DefaultMaximumResponseHeadersLength(){} // RVA: 0x7AE94E4B0
        public void get_ReadWriteTimeout(){} // RVA: 0x7ADF1BE20
        public void get_Method(){} // RVA: 0x7A87D9480
        public void set_Method(){} // RVA: 0x7AE94E510
        public void set_PreAuthenticate(){} // RVA: 0x7AB6D7250
        public void get_ProtocolVersion(){} // RVA: 0x7A81426F0
        public void set_ProtocolVersion(){} // RVA: 0x7AE94EAA0
        public void get_Proxy(){} // RVA: 0x7A8854870
        public void set_Proxy(){} // RVA: 0x7AE94EC70
        public void get_RequestUri(){} // RVA: 0x7A8292C30
        public void get_SendChunked(){} // RVA: 0x7A8203E30
        public void set_SendChunked(){} // RVA: 0x7AE94EDB0
        public void get_ServicePoint(){} // RVA: 0x7AE94EE20
        public void get_ServicePointNoLock(){} // RVA: 0x7A8158FC0
        public void get_Timeout(){} // RVA: 0x7AB52C0D0
        public void set_Timeout(){} // RVA: 0x7AE94EE30
        public void get_TransferEncoding(){} // RVA: 0x7AE94EEA0
        public void get_UseDefaultCredentials(){} // RVA: 0x7AE94EF00
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7AE068FB0
        public void get_ExpectContinue(){} // RVA: 0x7AE94EF80
        public void set_ExpectContinue(){} // RVA: 0x7AE94EF90
        public void get_AuthUri(){} // RVA: 0x7A8154D80
        public void get_ProxyQuery(){} // RVA: 0x7AE94EFA0
        public void get_ServerCertValidationCallback(){} // RVA: 0x7A87BB380
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7AE94EFD0
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7AE94EFF0
        public void GetServicePoint(){} // RVA: 0x7AE94F140
        public void SendRequest(){} // RVA: 0x7AE94F320
        public void MyGetRequestStreamAsync(){} // RVA: 0x7AE94F6C0
        public void BeginGetRequestStream(){} // RVA: 0x7AE94FDA0
        public void EndGetRequestStream(){} // RVA: 0x7AE94FE60
        public void GetRequestStreamAsync(){} // RVA: 0x7AE94FF30
        public void RunWithTimeout(){} // RVA: 0x7A7E00B20
        public void RunWithTimeoutWorker(){} // RVA: 0x7A7E121E0
        public void MyGetResponseAsync(){} // RVA: 0x7AE94FFC0
        public void GetResponseFromData(){} // RVA: 0x7AE9501B0
        public void FlattenException(){} // RVA: 0x7AE950410
        public void GetWebException(){} // RVA: 0x7AE9505A0
        public void CreateRequestAbortedException(){} // RVA: 0x7AE950780
        public void BeginGetResponse(){} // RVA: 0x7AE950840
        public void EndGetResponse(){} // RVA: 0x7AE950A60
        public void GetResponse(){} // RVA: 0x7AE950B30
        public void set_FinishedReading(){} // RVA: 0x7AE950BF0
        public void get_Aborted(){} // RVA: 0x7AA4B9130
        public void Abort(){} // RVA: 0x7AE950C00
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE950DE0
        public void GetObjectData(){} // RVA: 0x7AE950E20
        public void CheckRequestStarted(){} // RVA: 0x7AE950E60
        public void DoContinueDelegate(){} // RVA: 0x7AE950ED0
        public void RewriteRedirectToGet(){} // RVA: 0x7AE950EF0
        public void Redirect(){} // RVA: 0x7AE951000
        public void GetHeaders(){} // RVA: 0x7AE9517A0
        public void DoPreAuthenticate(){} // RVA: 0x7AE952340
        public void GetRequestHeaders(){} // RVA: 0x7AE952560
        public void HandleNtlmAuth(){} // RVA: 0x7AE952A90
        public void CheckAuthorization(){} // RVA: 0x7AE952D50
        public void GetRewriteHandler(){} // RVA: 0x7AE952D80
        public void CheckFinalStatus(){} // RVA: 0x7AE952FF0
        public void <RunWithTimeout>b__242_0(){} // RVA: 0x7A7E01900
        public void <GetRewriteHandler>b__271_0(){} // RVA: 0x7AE9535D0
    }

    public class HttpWebResponse : WebResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9575F0
        public void get_Headers(){} // RVA: 0x7A8105330
        public void get_ResponseUri(){} // RVA: 0x7AE957CE0
        public void get_StatusCode(){} // RVA: 0x7A8178B70
        public void get_StatusDescription(){} // RVA: 0x7AE957D00
        public void GetResponseStream(){} // RVA: 0x7AE957D20
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE919910
        public void GetObjectData(){} // RVA: 0x7AE957EA0
        public void Close(){} // RVA: 0x7AE958CA0
        public void System.IDisposable.Dispose(){} // RVA: 0x7ADC48D50
        public void Dispose(){} // RVA: 0x7AE958CE0
        public void CheckDisposed(){} // RVA: 0x7AE958CF0
        public void FillCookies(){} // RVA: 0x7AE958D80
    }

}