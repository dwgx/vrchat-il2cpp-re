// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 21
// Methods: 269

namespace ThirdParty.DotNet.System.Net
{
    public class HeaderInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95DA790
    }

    public class HeaderInfoTable
    {
        // ── Methods ──
        public void ParseSingleValue(){} // RVA: 0x7FFAF95DA860
        public void ParseMultiValue(){} // RVA: 0x7FFAF95DA8D0
        public void .cctor(){} // RVA: 0x7FFAF95DAB90
        public void get_Item(){} // RVA: 0x7FFAF95DCD70
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class HeaderParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF70E4FE0
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    }

    public class HeaderVariantInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32D0840
        public void get_Name(){} // RVA: 0x7FFAF4584690
        public void get_Variant(){} // RVA: 0x7FFAF4959890
    }

    public class HttpConnection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96014A0
        public void Init(){} // RVA: 0x7FFAF9601950
        public void get_Reuses(){} // RVA: 0x7FFAF304C4F0
        public void get_LocalEndPoint(){} // RVA: 0x7FFAF9601BC0
        public void get_IsSecure(){} // RVA: 0x7FFAF7974D70
        public void set_Prefix(){} // RVA: 0x7FFAF2E08740
        public void OnTimeout(){} // RVA: 0x7FFAF9601D00
        public void BeginReadRequest(){} // RVA: 0x7FFAF9601D50
        public void GetRequestStream(){} // RVA: 0x7FFAF9602080
        public void GetResponseStream(){} // RVA: 0x7FFAF9602580
        public void OnRead(){} // RVA: 0x7FFAF96026C0
        public void OnReadInternal(){} // RVA: 0x7FFAF9602760
        public void RemoveConnection(){} // RVA: 0x7FFAF9602CA0
        public void ProcessInput(){} // RVA: 0x7FFAF9602D00
        public void ReadLine(){} // RVA: 0x7FFAF9602FE0
        public void SendError(){} // RVA: 0x7FFAF96034C0 | overloaded x2
        public void Unbind(){} // RVA: 0x7FFAF96034F0
        public void CloseSocket(){} // RVA: 0x7FFAF9603540
        public void Close(){} // RVA: 0x7FFAF9603610
        public void .cctor(){} // RVA: 0x7FFAF9603AB0
        public void <.ctor>b__24_0(){} // RVA: 0x7FFAF9603B90
    }

    public class HttpContinueDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2EE92A0
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
    }

    public class HttpListener
    {
        // ── Methods ──
        public void LoadCertificateAndKey(){} // RVA: 0x7FFAF9603D40
        public void CreateSslStream(){} // RVA: 0x7FFAF96042B0
        public void .ctor(){} // RVA: 0x7FFAF96045B0
        public void get_AuthenticationSchemes(){} // RVA: 0x7FFAF3241DC0
        public void get_AuthenticationSchemeSelectorDelegate(){} // RVA: 0x7FFAF2F476A0
        public void get_IgnoreWriteExceptions(){} // RVA: 0x7FFAF2E44D30
        public void get_IsListening(){} // RVA: 0x7FFAF418F2D0
        public void get_Prefixes(){} // RVA: 0x7FFAF9604B80
        public void get_Realm(){} // RVA: 0x7FFAF2E0A740
        public void Close(){} // RVA: 0x7FFAF9604BE0 | overloaded x2
        public void Cleanup(){} // RVA: 0x7FFAF9604C60
        public void BeginGetContext(){} // RVA: 0x7FFAF9605880
        public void EndGetContext(){} // RVA: 0x7FFAF9605E40
        public void SelectAuthenticationScheme(){} // RVA: 0x7FFAF9606320
        public void Start(){} // RVA: 0x7FFAF9606360
        public void Stop(){} // RVA: 0x7FFAF96063D0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAF9606400
        public void CheckDisposed(){} // RVA: 0x7FFAF9606430
        public void GetContextFromQueue(){} // RVA: 0x7FFAF96064C0
        public void RegisterContext(){} // RVA: 0x7FFAF9606590
        public void UnregisterContext(){} // RVA: 0x7FFAF9606B10
        public void AddConnection(){} // RVA: 0x7FFAF9606E30
        public void RemoveConnection(){} // RVA: 0x7FFAF9606E60
    }

    public class HttpListenerBasicIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9606E90
    }

    public class HttpListenerContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9606F50
        public void get_ErrorStatus(){} // RVA: 0x7FFAF3A8C9F0
        public void set_ErrorStatus(){} // RVA: 0x7FFAF3A8D6E0
        public void get_ErrorMessage(){} // RVA: 0x7FFAF30E74D0
        public void set_ErrorMessage(){} // RVA: 0x7FFAF2DBB890
        public void get_HaveError(){} // RVA: 0x7FFAF7C055E0
        public void get_Connection(){} // RVA: 0x7FFAF2DBB130
        public void get_Request(){} // RVA: 0x7FFAF2DA8380
        public void get_Response(){} // RVA: 0x7FFAF2D907C0
        public void ParseAuthentication(){} // RVA: 0x7FFAF9607270
        public void ParseBasicAuthentication(){} // RVA: 0x7FFAF96073C0
    }

    public class HttpListenerException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95CC9D0 | overloaded x3
        public void get_ErrorCode(){} // RVA: 0x7FFAF315FD40
    }

    public class HttpListenerPrefixCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9607690
        public void get_Count(){} // RVA: 0x7FFAF96077B0
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void Add(){} // RVA: 0x7FFAF9607800
        public void Clear(){} // RVA: 0x7FFAF9607930
        public void Contains(){} // RVA: 0x7FFAF96079F0
        public void CopyTo(){} // RVA: 0x7FFAF9607A60
        public void GetEnumerator(){} // RVA: 0x7FFAF9607AF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF9607BE0
        public void Remove(){} // RVA: 0x7FFAF9607CD0
    }

    public class HttpListenerRequest
    {
        public object ForceCloseChunked;
        public object ContentEncoding;
        public object ContentLength64;
        public object ContentType;
        public object Headers;
        public object OutputStream;
        public object SendChunked;
        public object StatusCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9607E00
        public void SetRequestLine(){} // RVA: 0x7FFAF9607FB0
        public void CreateQueryString(){} // RVA: 0x7FFAF9608460
        public void MaybeUri(){} // RVA: 0x7FFAF9608850
        public void IsPredefinedScheme(){} // RVA: 0x7FFAF96088F0
        public void FinishInitialization(){} // RVA: 0x7FFAF9608BC0
        public void Unquote(){} // RVA: 0x7FFAF9609920
        public void AddHeader(){} // RVA: 0x7FFAF96099A0
        public void FlushInput(){} // RVA: 0x7FFAF960A5F0
        public void get_HasEntityBody(){} // RVA: 0x7FFAF960A8A0
        public void get_Headers(){} // RVA: 0x7FFAF2F476A0
        public void get_InputStream(){} // RVA: 0x7FFAF960A8C0
        public void get_IsSecureConnection(){} // RVA: 0x7FFAF960A9D0
        public void get_KeepAlive(){} // RVA: 0x7FFAF960AA00
        public void get_LocalEndPoint(){} // RVA: 0x7FFAF960AD10
        public void get_ProtocolVersion(){} // RVA: 0x7FFAF2E2E0E0
        public void get_RawUrl(){} // RVA: 0x7FFAF2E2B370
        public void get_Url(){} // RVA: 0x7FFAF2E08D50
        public void get_UserHostAddress(){} // RVA: 0x7FFAF960AE60
        public void get_UserHostName(){} // RVA: 0x7FFAF960AEA0
        public void .cctor(){} // RVA: 0x7FFAF960AF00
    }

    public class HttpListenerRequestUriBuilder
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF95CCA90
        public void .ctor(){} // RVA: 0x7FFAF95CCCF0
        public void GetRequestUri(){} // RVA: 0x7FFAF95CCFD0
        public void Build(){} // RVA: 0x7FFAF95CD140
        public void BuildRequestUriUsingCookedPath(){} // RVA: 0x7FFAF95CD230
        public void BuildRequestUriUsingRawPath(){} // RVA: 0x7FFAF95CD9A0 | overloaded x2
        public void GetEncoding(){} // RVA: 0x7FFAF95CD910
        public void ParseRawPath(){} // RVA: 0x7FFAF95CDCE0
        public void AppendUnicodeCodePointValuePercentEncoded(){} // RVA: 0x7FFAF95CDEA0
        public void AddPercentEncodedOctetToRawOctetsList(){} // RVA: 0x7FFAF95CE2A0
        public void EmptyDecodeAndAppendRawOctetsList(){} // RVA: 0x7FFAF95CE4D0
        public void AppendOctetsPercentEncoded(){} // RVA: 0x7FFAF95CE890
        public void GetOctetsAsString(){} // RVA: 0x7FFAF95CEC00
        public void GetPath(){} // RVA: 0x7FFAF95CEED0
        public void AddSlashToAsteriskOnlyPath(){} // RVA: 0x7FFAF95CF230
        public void LogWarning(){} // RVA: 0x7FFAF2D8D310
    }

    public class HttpListenerResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF960B0A0
        public void get_ForceCloseChunked(){} // RVA: 0x7FFAF331DB40
        public void get_ContentEncoding(){} // RVA: 0x7FFAF960B320
        public void set_ContentLength64(){} // RVA: 0x7FFAF960B3A0
        public void set_ContentType(){} // RVA: 0x7FFAF960B4E0
        public void get_Headers(){} // RVA: 0x7FFAF2E0A740
        public void get_OutputStream(){} // RVA: 0x7FFAF960B600
        public void get_SendChunked(){} // RVA: 0x7FFAF33510E0
        public void set_SendChunked(){} // RVA: 0x7FFAF960B690
        public void set_StatusCode(){} // RVA: 0x7FFAF960B760
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAF960B8B0
        public void Close(){} // RVA: 0x7FFAF960B960 | overloaded x3
        public void SendHeaders(){} // RVA: 0x7FFAF960BA40
        public void FormatHeaders(){} // RVA: 0x7FFAF960C780
        public void CookieToClientString(){} // RVA: 0x7FFAF960CA10
        public void QuotedString(){} // RVA: 0x7FFAF960CD40
        public void IsToken(){} // RVA: 0x7FFAF960CEE0
        public void .cctor(){} // RVA: 0x7FFAF960CFF0
    }

    public class HttpRequestCreator : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Create(){} // RVA: 0x7FFAF960D0A0
    }

    public class HttpStatusDescription
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAF9779F90 | overloaded x2
    }

    public class HttpStreamAsyncResult
    {
        // ── Methods ──
        public void Complete(){} // RVA: 0x7FFAF960D160 | overloaded x2
        public void get_AsyncState(){} // RVA: 0x7FFAF2E0A740
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFAF960D310
        public void get_CompletedSynchronously(){} // RVA: 0x7FFAF960D520
        public void get_IsCompleted(){} // RVA: 0x7FFAF960D530
        public void .ctor(){} // RVA: 0x7FFAF960D670
    }

    public class HttpValidationHelpers
    {
        // ── Methods ──
        public void IsInvalidMethodOrHeaderString(){} // RVA: 0x7FFAF977A8A0
        public void .cctor(){} // RVA: 0x7FFAF977A9F0
    }

    public class HttpVersion
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF977CD60
    }

    public class HttpWebRequest
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF960D700
        public void .ctor(){} // RVA: 0x7FFAF9614040 | overloaded x4
        public void ResetAuthorization(){} // RVA: 0x7FFAF960E100
        public void get_Address(){} // RVA: 0x7FFAF2E0A740
        public void set_AllowAutoRedirect(){} // RVA: 0x7FFAF3E26F60
        public void get_AllowWriteStreamBuffering(){} // RVA: 0x7FFAF418F2D0
        public void set_AllowWriteStreamBuffering(){} // RVA: 0x7FFAF418E990
        public void get_AutomaticDecompression(){} // RVA: 0x7FFAF960E2A0
        public void set_AutomaticDecompression(){} // RVA: 0x7FFAF960E2B0
        public void get_InternalAllowBuffering(){} // RVA: 0x7FFAF960E320
        public void get_MethodWithBuffer(){} // RVA: 0x7FFAF960E330
        public void get_TlsProvider(){} // RVA: 0x7FFAF2DF85F0
        public void get_TlsSettings(){} // RVA: 0x7FFAF2DF8660
        public void get_ClientCertificates(){} // RVA: 0x7FFAF960E520
        public void set_ConnectionGroupName(){} // RVA: 0x7FFAF2E55510
        public void get_ContentLength(){} // RVA: 0x7FFAF2E08D50
        public void set_ContentLength(){} // RVA: 0x7FFAF960E5D0
        public void set_InternalContentLength(){} // RVA: 0x7FFAF49BAB90
        public void get_ThrowOnError(){} // RVA: 0x7FFAF8D2D100
        public void set_ThrowOnError(){} // RVA: 0x7FFAF960E6A0
        public void set_CookieContainer(){} // RVA: 0x7FFAF2F734F0
        public void get_Credentials(){} // RVA: 0x7FFAF2F12D00
        public void set_Credentials(){} // RVA: 0x7FFAF2F14450
        public void get_DefaultMaximumErrorResponseLength(){} // RVA: 0x7FFAF960E6B0
        public void get_Headers(){} // RVA: 0x7FFAF3246DE0
        public void get_Host(){} // RVA: 0x7FFAF960E710
        public void set_Host(){} // RVA: 0x7FFAF960E8A0
        public void TryGetHostUri(){} // RVA: 0x7FFAF960EB50
        public void get_KeepAlive(){} // RVA: 0x7FFAF331DB40
        public void set_KeepAlive(){} // RVA: 0x7FFAF331DB50
        public void set_MaximumAutomaticRedirections(){} // RVA: 0x7FFAF960EC30
        public void get_DefaultMaximumResponseHeadersLength(){} // RVA: 0x7FFAF960ECC0
        public void get_ReadWriteTimeout(){} // RVA: 0x7FFAF8BDFB40
        public void get_Method(){} // RVA: 0x7FFAF34CC130
        public void set_Method(){} // RVA: 0x7FFAF960ED20
        public void set_PreAuthenticate(){} // RVA: 0x7FFAF639ED50
        public void get_ProtocolVersion(){} // RVA: 0x7FFAF2DF8120
        public void set_ProtocolVersion(){} // RVA: 0x7FFAF960F2A0
        public void get_Proxy(){} // RVA: 0x7FFAF3546D30
        public void set_Proxy(){} // RVA: 0x7FFAF960F460
        public void get_RequestUri(){} // RVA: 0x7FFAF2F476A0
        public void get_SendChunked(){} // RVA: 0x7FFAF2EB8F80
        public void set_SendChunked(){} // RVA: 0x7FFAF960F5A0
        public void get_ServicePoint(){} // RVA: 0x7FFAF960F610
        public void get_ServicePointNoLock(){} // RVA: 0x7FFAF2E0E970
        public void get_Timeout(){} // RVA: 0x7FFAF61E9380
        public void set_Timeout(){} // RVA: 0x7FFAF960F620
        public void get_TransferEncoding(){} // RVA: 0x7FFAF960F690
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFAF960F6F0
        public void get_UnsafeAuthenticatedConnectionSharing(){} // RVA: 0x7FFAF8D2D110
        public void get_ExpectContinue(){} // RVA: 0x7FFAF960F770
        public void set_ExpectContinue(){} // RVA: 0x7FFAF960F780
        public void get_AuthUri(){} // RVA: 0x7FFAF2E0A740
        public void get_ProxyQuery(){} // RVA: 0x7FFAF960F790
        public void get_ServerCertValidationCallback(){} // RVA: 0x7FFAF34AE130
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7FFAF960F7C0
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7FFAF960F7E0
        public void GetServicePoint(){} // RVA: 0x7FFAF960F930
        public void SendRequest(){} // RVA: 0x7FFAF960FB50
        public void MyGetRequestStreamAsync(){} // RVA: 0x7FFAF960FF10
        public void BeginGetRequestStream(){} // RVA: 0x7FFAF9610620
        public void EndGetRequestStream(){} // RVA: 0x7FFAF96106E0
        public void GetRequestStreamAsync(){} // RVA: 0x7FFAF96107B0
        public void RunWithTimeout(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void RunWithTimeoutWorker(){} // RVA: 0x7FFAF2ACE490
        public void MyGetResponseAsync(){} // RVA: 0x7FFAF9610840
        public void GetResponseFromData(){} // RVA: 0x7FFAF9610A30
        public void FlattenException(){} // RVA: 0x7FFAF9610C90
        public void GetWebException(){} // RVA: 0x7FFAF9610E30 | overloaded x2
        public void CreateRequestAbortedException(){} // RVA: 0x7FFAF9611020
        public void BeginGetResponse(){} // RVA: 0x7FFAF96110E0
        public void EndGetResponse(){} // RVA: 0x7FFAF9611300
        public void GetResponse(){} // RVA: 0x7FFAF96113D0
        public void set_FinishedReading(){} // RVA: 0x7FFAF9611490
        public void get_Aborted(){} // RVA: 0x7FFAF5157D20
        public void Abort(){} // RVA: 0x7FFAF96114A0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF9611680
        public void GetObjectData(){} // RVA: 0x7FFAF96116C0
        public void CheckRequestStarted(){} // RVA: 0x7FFAF9611700
        public void DoContinueDelegate(){} // RVA: 0x7FFAF9611770
        public void RewriteRedirectToGet(){} // RVA: 0x7FFAF9611790
        public void Redirect(){} // RVA: 0x7FFAF96118A0
        public void GetHeaders(){} // RVA: 0x7FFAF9612040
        public void DoPreAuthenticate(){} // RVA: 0x7FFAF9612BE0
        public void GetRequestHeaders(){} // RVA: 0x7FFAF9612E10
        public void HandleNtlmAuth(){} // RVA: 0x7FFAF9613360
        public void CheckAuthorization(){} // RVA: 0x7FFAF9613620
        public void GetRewriteHandler(){} // RVA: 0x7FFAF9613650
        public void CheckFinalStatus(){} // RVA: 0x7FFAF96138C0
        public void <RunWithTimeout>b__242_0(){} // RVA: 0x7FFAF2ABDBE0
        public void <GetRewriteHandler>b__271_0(){} // RVA: 0x7FFAF9613EA0
    }

    public class HttpWebResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9618000 | overloaded x4
        public void get_Headers(){} // RVA: 0x7FFAF2DBB130
        public void get_ResponseUri(){} // RVA: 0x7FFAF96186F0
        public void get_StatusCode(){} // RVA: 0x7FFAF2E2E0C0
        public void get_StatusDescription(){} // RVA: 0x7FFAF9618710
        public void GetResponseStream(){} // RVA: 0x7FFAF9618730
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF95D8CC0
        public void GetObjectData(){} // RVA: 0x7FFAF96188B0
        public void Close(){} // RVA: 0x7FFAF96196B0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAF890A340
        public void Dispose(){} // RVA: 0x7FFAF96196F0
        public void CheckDisposed(){} // RVA: 0x7FFAF9619700
        public void FillCookies(){} // RVA: 0x7FFAF9619790
    }

}