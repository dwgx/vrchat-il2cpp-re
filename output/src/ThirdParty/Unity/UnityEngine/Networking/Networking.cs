// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Networking
// Classes: 14
// Methods: 151

namespace ThirdParty.Unity.UnityEngine.Networking
{
    public class CertificateHandler : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE8803B0F0
        public void Release(){} // RVA: 0x7FFE8803B140
        public void .ctor(){} // RVA: 0x7FFE8803B190
        public void Finalize(){} // RVA: 0x7FFE8803B1F0
        public void ValidateCertificate(){} // RVA: 0x7FFE834BA0A0
        public void ValidateCertificateNative(){} // RVA: 0x7FFE84A901B0
        public void Dispose(){} // RVA: 0x7FFE8803B280
    }

    public class DownloadHandler : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public object field_1; // 0xCB20
        public object field_2; // 0xCB20
        public object field_3; // 0xCB20
        public object field_4; // 0xCB20

        // ── Methods ──
        public void Release(){} // RVA: 0x7FFE8803B2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Finalize(){} // RVA: 0x7FFE8803B330
        public void Dispose(){} // RVA: 0x7FFE8803B380
        public void get_isDone(){} // RVA: 0x7FFE8803B3E0
        public void IsDone(){} // RVA: 0x7FFE8803B3E0
        public void get_error(){} // RVA: 0x7FFE8803B430
        public void GetErrorMsg(){} // RVA: 0x7FFE8803B430
        public void get_nativeData(){} // RVA: 0x7FFE8803B480
        public void get_data(){} // RVA: 0x7FFE82A336A0
        public void get_text(){} // RVA: 0x7FFE81768340
        public void GetNativeData(){} // RVA: 0x7FFE815CF4B0
        public void GetData(){} // RVA: 0x7FFE8803B530
        public void GetText(){} // RVA: 0x7FFE8803B5C0
        public void GetTextEncoder(){} // RVA: 0x7FFE8803B6A0
        public void GetContentType(){} // RVA: 0x7FFE8803BAE0
        public void ReceiveData(){} // RVA: 0x7FFE82E64CC0
        public void ReceiveContentLengthHeader(){} // RVA: 0x7FFE8803BB30
        public void ReceiveContentLength(){} // RVA: 0x7FFE810FB310
        public void CompleteContent(){} // RVA: 0x7FFE810FB310
        public void GetProgress(){} // RVA: 0x7FFE87C336C0
        public void GetCheckedDownloader(){} // RVA: 0x7FFE810A1420
        public void InternalGetByteArray(){} // RVA: 0x7FFE8803B530 | overloaded x2
        public void InternalGetNativeArray(){} // RVA: 0x7FFE8803BBB0
        public void DisposeNativeArray(){} // RVA: 0x7FFE8803BCF0
        public void CreateNativeArrayForNativeData(){} // RVA: 0x7FFE8803BD30
    }

    public class DownloadHandlerAssetBundle : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE88038730
        public void CreateCached(){} // RVA: 0x7FFE880387C0
        public void InternalCreateAssetBundle(){} // RVA: 0x7FFE88038860
        public void InternalCreateAssetBundleCached(){} // RVA: 0x7FFE88038970
        public void .ctor(){} // RVA: 0x7FFE88038BC0 | overloaded x2
        public void GetData(){} // RVA: 0x7FFE88038D10
        public void GetText(){} // RVA: 0x7FFE88038D60
        public void get_assetBundle(){} // RVA: 0x7FFE88038DB0
        public void GetContent(){} // RVA: 0x7FFE88038E00
        public void CreateCached_Injected(){} // RVA: 0x7FFE88038E90
    }

    public class DownloadHandlerBuffer : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE8803BDA0
        public void InternalCreateBuffer(){} // RVA: 0x7FFE8803BDF0
        public void .ctor(){} // RVA: 0x7FFE8803BDF0
        public void GetNativeData(){} // RVA: 0x7FFE8803BE50
        public void Dispose(){} // RVA: 0x7FFE8803BE80
    }

    public class DownloadHandlerFile : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE8803C150
        public void InternalCreateVFS(){} // RVA: 0x7FFE8803C1C0
        public void .ctor(){} // RVA: 0x7FFE8803C2A0
        public void GetNativeData(){} // RVA: 0x7FFE8803C370
        public void GetData(){} // RVA: 0x7FFE8803C3C0
        public void GetText(){} // RVA: 0x7FFE8803C410
    }

    public class DownloadHandlerScript : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE8803BF10
        public void CreatePreallocated(){} // RVA: 0x7FFE8803BF60
        public void InternalCreateScript(){} // RVA: 0x7FFE8803C020 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8803C090 | overloaded x2
    }

    public class DownloadHandlerTexture : DownloadHandler
    {
        public Unity.Collections.NativeArray`1<byte> m_NativeData; // 0x18

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE8803F400
        public void InternalCreateTexture(){} // RVA: 0x7FFE8803F460
        public void .ctor(){} // RVA: 0x7FFE8803F4D0
        public void GetNativeData(){} // RVA: 0x7FFE8803BE50
        public void Dispose(){} // RVA: 0x7FFE8803BE80
        public void get_texture(){} // RVA: 0x7FFE8803F540
        public void InternalGetTextureNative(){} // RVA: 0x7FFE8803F540
        public void GetContent(){} // RVA: 0x7FFE8803F590
    }

    public class EncryptionKey : ValueType
    {
    }

    public class UnityWebRequest : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public UnityEngine.Networking.DownloadHandler m_DownloadHandler; // 0x18
        public UnityEngine.Networking.UploadHandler m_UploadHandler; // 0x20
        public UnityEngine.Networking.CertificateHandler m_CertificateHandler; // 0x28
        public System.Uri m_Uri; // 0x30
        public string kHttpVerbGET;
        public string kHttpVerbHEAD;
        public string kHttpVerbPOST;
        public string kHttpVerbPUT;
        public string kHttpVerbCREATE;
        public string kHttpVerbDELETE;
        public bool _disposeCertificateHandlerOnDispose; // 0x38
        public bool _disposeDownloadHandlerOnDispose; // 0x39
        public bool _disposeUploadHandlerOnDispose; // 0x3A
        public object field_14; // 0x8
        public object field_15; // 0x9
        public object field_16; // 0xA
        public object field_17; // 0xB

        // ── Methods ──
        public void GetWebErrorString(){} // RVA: 0x7FFE8803C460
        public void GetHTTPStatusString(){} // RVA: 0x7FFE8803C4B0
        public void get_disposeCertificateHandlerOnDispose(){} // RVA: 0x7FFE812CF770
        public void set_disposeCertificateHandlerOnDispose(){} // RVA: 0x7FFE812D0010
        public void get_disposeDownloadHandlerOnDispose(){} // RVA: 0x7FFE812CF7D0
        public void set_disposeDownloadHandlerOnDispose(){} // RVA: 0x7FFE812D0020
        public void get_disposeUploadHandlerOnDispose(){} // RVA: 0x7FFE82230840
        public void set_disposeUploadHandlerOnDispose(){} // RVA: 0x7FFE86835A50
        public void ClearCookieCache(){} // RVA: 0x7FFE8803C660 | overloaded x2
        public void Create(){} // RVA: 0x7FFE8803C6C0
        public void Release(){} // RVA: 0x7FFE8803C710
        public void InternalDestroy(){} // RVA: 0x7FFE8803C760
        public void InternalSetDefaults(){} // RVA: 0x7FFE8803C800
        public void .ctor(){} // RVA: 0x7FFE8803CA50 | overloaded x5
        public void Finalize(){} // RVA: 0x7FFE8803CB10
        public void Dispose(){} // RVA: 0x7FFE8803CB60
        public void DisposeHandlers(){} // RVA: 0x7FFE8803CBD0
        public void BeginWebRequest(){} // RVA: 0x7FFE8803CC40
        public void SendWebRequest(){} // RVA: 0x7FFE8803CC90
        public void Abort(){} // RVA: 0x7FFE8803CD40
        public void SetMethod(){} // RVA: 0x7FFE8803CD90
        public void InternalSetMethod(){} // RVA: 0x7FFE8803CDF0
        public void SetCustomMethod(){} // RVA: 0x7FFE8803CF30
        public void InternalSetCustomMethod(){} // RVA: 0x7FFE8803CF90
        public void set_method(){} // RVA: 0x7FFE8803D0D0
        public void GetError(){} // RVA: 0x7FFE8803D420
        public void get_error(){} // RVA: 0x7FFE8803D470
        public void set_url(){} // RVA: 0x7FFE8803D6F0
        public void get_uri(){} // RVA: 0x7FFE8803D780
        public void set_uri(){} // RVA: 0x7FFE8803D880
        public void GetUrl(){} // RVA: 0x7FFE8803DA00
        public void SetUrl(){} // RVA: 0x7FFE8803DA50
        public void InternalSetUrl(){} // RVA: 0x7FFE8803DAB0
        public void get_responseCode(){} // RVA: 0x7FFE8803DBF0
        public void get_isModifiable(){} // RVA: 0x7FFE8803DC40
        public void get_isDone(){} // RVA: 0x7FFE8803DC90
        public void get_isNetworkError(){} // RVA: 0x7FFE8803DCF0
        public void get_result(){} // RVA: 0x7FFE8803DD50
        public void get_downloadedBytes(){} // RVA: 0x7FFE8803DDA0
        public void SetRedirectLimitFromScripting(){} // RVA: 0x7FFE8803DDF0
        public void set_redirectLimit(){} // RVA: 0x7FFE8803DDF0
        public void InternalSetRequestHeader(){} // RVA: 0x7FFE8803DE50
        public void SetRequestHeader(){} // RVA: 0x7FFE8803DEC0
        public void GetResponseHeader(){} // RVA: 0x7FFE8803E0C0
        public void GetResponseHeaderKeys(){} // RVA: 0x7FFE8803E120
        public void GetResponseHeaders(){} // RVA: 0x7FFE8803E170
        public void SetUploadHandler(){} // RVA: 0x7FFE8803E370
        public void get_uploadHandler(){} // RVA: 0x7FFE87563690
        public void set_uploadHandler(){} // RVA: 0x7FFE8803E3D0
        public void SetDownloadHandler(){} // RVA: 0x7FFE8803E560
        public void get_downloadHandler(){} // RVA: 0x7FFE83BBC680
        public void set_downloadHandler(){} // RVA: 0x7FFE8803E5C0
        public void SetCertificateHandler(){} // RVA: 0x7FFE8803E750
        public void get_certificateHandler(){} // RVA: 0x7FFE87C86200
        public void set_certificateHandler(){} // RVA: 0x7FFE8803E7B0
        public void SetTimeoutMsec(){} // RVA: 0x7FFE8803E940
        public void set_timeout(){} // RVA: 0x7FFE8803E9A0
        public void Get(){} // RVA: 0x7FFE8803EB20
        public void EscapeURL(){} // RVA: 0x7FFE8803EDB0 | overloaded x2
    }

    public class UnityWebRequestAssetBundle : Object
    {
        // ── Methods ──
        public void GetAssetBundle(){} // RVA: 0x7FFE88038530 | overloaded x3
    }

    public class UnityWebRequestAsyncOperation : AsyncOperation
    {
        public UnityEngine.Networking.UnityWebRequest _webRequest; // 0x20

        // ── Methods ──
        public void get_webRequest(){} // RVA: 0x7FFE811290C0
        public void set_webRequest(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnityWebRequestTexture : Object
    {
        // ── Methods ──
        public void GetTexture(){} // RVA: 0x7FFE8803F630 | overloaded x2
    }

    public class UploadHandler : Object
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x7FFE8803EF40
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Finalize(){} // RVA: 0x7FFE8803B330
        public void Dispose(){} // RVA: 0x7FFE8803EF90
    }

    public class UploadHandlerRaw : UploadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE8803EFF0
        public void .ctor(){} // RVA: 0x7FFE8803F280 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE8803F350
    }

}