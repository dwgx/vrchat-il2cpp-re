// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Networking
// Classes: 6
// Methods: 106

namespace ThirdParty.Unity.UnityEngine.Networking
{
    public class CertificateHandler : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD550B28A0
        public void Release(){} // RVA: 0x7FFD550B28F0
        public void .ctor(){} // RVA: 0x7FFD550B2940
        public void Finalize(){} // RVA: 0x7FFD550B29A0
        public void ValidateCertificate(){} // RVA: 0x7FFD506288B0
        public void ValidateCertificateNative(){} // RVA: 0x7FFD51B52190
        public void Dispose(){} // RVA: 0x7FFD550B2A30
    }

    public class DownloadHandler : Object
    {
        public object isDone; // 0x440
        public bool error; // 0x448
        public ÎÏÌÎÎÎÌÌÌ.yle.get_minWidth nativeData; // 0x450
        public ÎÏÌÎÎÎÌÌÌ.omLeftRadius data; // 0x458
        public oseCount text; // 0x460
        public ormation<ÎÏÌÎÎÎÌÌÌ.op> createMenuCallback; // 0x4A0
        public string ussClassName;
        public string textUssClassName; // 0x8
        public string arrowUssClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20

        // ── Methods ──
        public void Release(){} // RVA: 0x7FFD550B2A90
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Finalize(){} // RVA: 0x7FFD550B2AE0
        public void Dispose(){} // RVA: 0x7FFD550B2B30
        public void get_isDone(){} // RVA: 0x7FFD550B2B90
        public void IsDone(){} // RVA: 0x7FFD550B2B90
        public void get_error(){} // RVA: 0x7FFD550B2BE0
        public void GetErrorMsg(){} // RVA: 0x7FFD550B2BE0
        public void get_nativeData(){} // RVA: 0x7FFD550B2C30
        public void get_data(){} // RVA: 0x7FFD4FBEB300
        public void get_text(){} // RVA: 0x7FFD4E51EBD0
        public void GetNativeData(){} // RVA: 0x7FFD4E792CF0
        public void GetData(){} // RVA: 0x7FFD550B2CE0
        public void GetText(){} // RVA: 0x7FFD550B2D70
        public void GetTextEncoder(){} // RVA: 0x7FFD550B2E50
        public void GetContentType(){} // RVA: 0x7FFD550B3290
        public void ReceiveData(){} // RVA: 0x7FFD500182C0
        public void ReceiveContentLengthHeader(){} // RVA: 0x7FFD550B32E0
        public void ReceiveContentLength(){} // RVA: 0x7FFD4E341310
        public void CompleteContent(){} // RVA: 0x7FFD4E341310
        public void GetProgress(){} // RVA: 0x7FFD54CAADC0
        public void GetCheckedDownloader(){} // RVA: 0x7FFD4E2ADC40
        public void InternalGetByteArray(){} // RVA: 0x7FFD550B2CE0 | overloaded x2
        public void InternalGetNativeArray(){} // RVA: 0x7FFD550B3360
        public void DisposeNativeArray(){} // RVA: 0x7FFD550B34A0
        public void CreateNativeArrayForNativeData(){} // RVA: 0x7FFD550B34E0
    }

    public class EncryptionKey : ValueType
    {
    }

    public class UnityWebRequest : Object
    {
        public object disposeCertificateHandlerOnDispose;
        public object disposeDownloadHandlerOnDispose;
        public object disposeUploadHandlerOnDispose;
        public object method;
        public object error;
        public object url;
        public object uri;
        public object responseCode;
        public object isModifiable;
        public object isDone;
        public object isNetworkError;
        public object result;
        public object downloadedBytes;
        public object redirectLimit;
        public object uploadHandler;
        public object downloadHandler;
        public object certificateHandler;
        public object timeout;

        // ── Methods ──
        public void GetWebErrorString(){} // RVA: 0x7FFD550B3C10
        public void GetHTTPStatusString(){} // RVA: 0x7FFD550B3C60
        public void get_disposeCertificateHandlerOnDispose(){} // RVA: 0x7FFD4E5F95D0
        public void set_disposeCertificateHandlerOnDispose(){} // RVA: 0x7FFD4E5F95C0
        public void get_disposeDownloadHandlerOnDispose(){} // RVA: 0x7FFD4E7DCE50
        public void set_disposeDownloadHandlerOnDispose(){} // RVA: 0x7FFD4E7DD1D0
        public void get_disposeUploadHandlerOnDispose(){} // RVA: 0x7FFD4F39B7C0
        public void set_disposeUploadHandlerOnDispose(){} // RVA: 0x7FFD538AC150
        public void ClearCookieCache(){} // RVA: 0x7FFD550B3E10 | overloaded x2
        public void Create(){} // RVA: 0x7FFD550B3E70
        public void Release(){} // RVA: 0x7FFD550B3EC0
        public void InternalDestroy(){} // RVA: 0x7FFD550B3F10
        public void InternalSetDefaults(){} // RVA: 0x7FFD550B3FB0
        public void .ctor(){} // RVA: 0x7FFD550B4200 | overloaded x5
        public void Finalize(){} // RVA: 0x7FFD550B42C0
        public void Dispose(){} // RVA: 0x7FFD550B4310
        public void DisposeHandlers(){} // RVA: 0x7FFD550B4380
        public void BeginWebRequest(){} // RVA: 0x7FFD550B43F0
        public void SendWebRequest(){} // RVA: 0x7FFD550B4440
        public void Abort(){} // RVA: 0x7FFD550B44F0
        public void SetMethod(){} // RVA: 0x7FFD550B4540
        public void InternalSetMethod(){} // RVA: 0x7FFD550B45A0
        public void SetCustomMethod(){} // RVA: 0x7FFD550B46E0
        public void InternalSetCustomMethod(){} // RVA: 0x7FFD550B4740
        public void set_method(){} // RVA: 0x7FFD550B4880
        public void GetError(){} // RVA: 0x7FFD550B4BD0
        public void get_error(){} // RVA: 0x7FFD550B4C20
        public void set_url(){} // RVA: 0x7FFD550B4EA0
        public void get_uri(){} // RVA: 0x7FFD550B4F30
        public void set_uri(){} // RVA: 0x7FFD550B5030
        public void GetUrl(){} // RVA: 0x7FFD550B51B0
        public void SetUrl(){} // RVA: 0x7FFD550B5200
        public void InternalSetUrl(){} // RVA: 0x7FFD550B5260
        public void get_responseCode(){} // RVA: 0x7FFD550B53A0
        public void get_isModifiable(){} // RVA: 0x7FFD550B53F0
        public void get_isDone(){} // RVA: 0x7FFD550B5440
        public void get_isNetworkError(){} // RVA: 0x7FFD550B54A0
        public void get_result(){} // RVA: 0x7FFD550B5500
        public void get_downloadedBytes(){} // RVA: 0x7FFD550B5550
        public void SetRedirectLimitFromScripting(){} // RVA: 0x7FFD550B55A0
        public void set_redirectLimit(){} // RVA: 0x7FFD550B55A0
        public void InternalSetRequestHeader(){} // RVA: 0x7FFD550B5600
        public void SetRequestHeader(){} // RVA: 0x7FFD550B5670
        public void GetResponseHeader(){} // RVA: 0x7FFD550B5870
        public void GetResponseHeaderKeys(){} // RVA: 0x7FFD550B58D0
        public void GetResponseHeaders(){} // RVA: 0x7FFD550B5920
        public void SetUploadHandler(){} // RVA: 0x7FFD550B5B20
        public void get_uploadHandler(){} // RVA: 0x7FFD545DAEE0
        public void set_uploadHandler(){} // RVA: 0x7FFD550B5B80
        public void SetDownloadHandler(){} // RVA: 0x7FFD550B5D10
        public void get_downloadHandler(){} // RVA: 0x7FFD50CC1130
        public void set_downloadHandler(){} // RVA: 0x7FFD550B5D70
        public void SetCertificateHandler(){} // RVA: 0x7FFD550B5F00
        public void get_certificateHandler(){} // RVA: 0x7FFD54CFDAD0
        public void set_certificateHandler(){} // RVA: 0x7FFD550B5F60
        public void SetTimeoutMsec(){} // RVA: 0x7FFD550B60F0
        public void set_timeout(){} // RVA: 0x7FFD550B6150
        public void Get(){} // RVA: 0x7FFD550B62D0
        public void EscapeURL(){} // RVA: 0x7FFD550B6560 | overloaded x2
    }

    public class UnityWebRequestAsyncOperation : AsyncOperation
    {
        public object webRequest;

        // ── Methods ──
        public void get_webRequest(){} // RVA: 0x7FFD4E36F0C0
        public void set_webRequest(){} // RVA: 0x7FFD4E36F0D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UploadHandler : Object
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x7FFD550B66F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Finalize(){} // RVA: 0x7FFD550B2AE0
        public void Dispose(){} // RVA: 0x7FFD550B6740
    }

}