// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Networking
// Classes: 14
// Methods: 151

namespace ThirdParty.Unity.UnityEngine.Networking
{
    public class CertificateHandler : Object
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9C928A0
        public void Release(){} // RVA: 0x7FFAC9C928F0
        public void .ctor(){} // RVA: 0x7FFAC9C92940
        public void Finalize(){} // RVA: 0x7FFAC9C929A0
        public void ValidateCertificate(){} // RVA: 0x7FFAC52088B0
        public void ValidateCertificateNative(){} // RVA: 0x7FFAC6732190
        public void Dispose(){} // RVA: 0x7FFAC9C92A30
    }

    public class DownloadHandler : Object
    {
        public UIntPtr isDone; // 0x10

        // ── Methods ──
        public void Release(){} // RVA: 0x7FFAC9C92A90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Finalize(){} // RVA: 0x7FFAC9C92AE0
        public void Dispose(){} // RVA: 0x7FFAC9C92B30
        public void get_isDone(){} // RVA: 0x7FFAC9C92B90
        public void IsDone(){} // RVA: 0x7FFAC9C92B90
        public void get_error(){} // RVA: 0x7FFAC9C92BE0
        public void GetErrorMsg(){} // RVA: 0x7FFAC9C92BE0
        public void get_nativeData(){} // RVA: 0x7FFAC9C92C30
        public void get_data(){} // RVA: 0x7FFAC47CB300
        public void get_text(){} // RVA: 0x7FFAC30FEBD0
        public void GetNativeData(){} // RVA: 0x7FFAC3372CF0
        public void GetData(){} // RVA: 0x7FFAC9C92CE0
        public void GetText(){} // RVA: 0x7FFAC9C92D70
        public void GetTextEncoder(){} // RVA: 0x7FFAC9C92E50
        public void GetContentType(){} // RVA: 0x7FFAC9C93290
        public void ReceiveData(){} // RVA: 0x7FFAC4BF82C0
        public void ReceiveContentLengthHeader(){} // RVA: 0x7FFAC9C932E0
        public void ReceiveContentLength(){} // RVA: 0x7FFAC2F21310
        public void CompleteContent(){} // RVA: 0x7FFAC2F21310
        public void GetProgress(){} // RVA: 0x7FFAC988ADC0
        public void GetCheckedDownloader(){} // RVA: 0x7FFAC2E8DC40
        public void InternalGetByteArray(){} // RVA: 0x7FFAC9C92CE0 | overloaded x2
        public void InternalGetNativeArray(){} // RVA: 0x7FFAC9C93360
        public void DisposeNativeArray(){} // RVA: 0x7FFAC9C934A0
        public void CreateNativeArrayForNativeData(){} // RVA: 0x7FFAC9C934E0
    }

    public class DownloadHandlerAssetBundle : DownloadHandler
    {
        public object assetBundle;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9C8FEE0
        public void CreateCached(){} // RVA: 0x7FFAC9C8FF70
        public void InternalCreateAssetBundle(){} // RVA: 0x7FFAC9C90010
        public void InternalCreateAssetBundleCached(){} // RVA: 0x7FFAC9C90120
        public void .ctor(){} // RVA: 0x7FFAC9C90370 | overloaded x2
        public void GetData(){} // RVA: 0x7FFAC9C904C0
        public void GetText(){} // RVA: 0x7FFAC9C90510
        public void get_assetBundle(){} // RVA: 0x7FFAC9C90560
        public void GetContent(){} // RVA: 0x7FFAC9C905B0
        public void CreateCached_Injected(){} // RVA: 0x7FFAC9C90640
    }

    public class DownloadHandlerBuffer : DownloadHandler
    {
        public Unity.Collections.NativeArray`1<byte> m_NativeData; // 0x18

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9C93550
        public void InternalCreateBuffer(){} // RVA: 0x7FFAC9C935A0
        public void .ctor(){} // RVA: 0x7FFAC9C935A0
        public void GetNativeData(){} // RVA: 0x7FFAC9C93600
        public void Dispose(){} // RVA: 0x7FFAC9C93630
    }

    public class DownloadHandlerFile : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9C93900
        public void InternalCreateVFS(){} // RVA: 0x7FFAC9C93970
        public void .ctor(){} // RVA: 0x7FFAC9C93A50
        public void GetNativeData(){} // RVA: 0x7FFAC9C93B20
        public void GetData(){} // RVA: 0x7FFAC9C93B70
        public void GetText(){} // RVA: 0x7FFAC9C93BC0
    }

    public class DownloadHandlerScript : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9C936C0
        public void CreatePreallocated(){} // RVA: 0x7FFAC9C93710
        public void InternalCreateScript(){} // RVA: 0x7FFAC9C937D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC9C93840 | overloaded x2
    }

    public class DownloadHandlerTexture : DownloadHandler
    {
        public Unity.Collections.NativeArray`1<byte> texture; // 0x18
        public bool mNonReadable; // 0x28

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9C96BB0
        public void InternalCreateTexture(){} // RVA: 0x7FFAC9C96C10
        public void .ctor(){} // RVA: 0x7FFAC9C96C80
        public void GetNativeData(){} // RVA: 0x7FFAC9C93600
        public void Dispose(){} // RVA: 0x7FFAC9C93630
        public void get_texture(){} // RVA: 0x7FFAC9C96CF0
        public void InternalGetTextureNative(){} // RVA: 0x7FFAC9C96CF0
        public void GetContent(){} // RVA: 0x7FFAC9C96D40
    }

    public class EncryptionKey : ValueType
    {
        public ulong A; // 0x10
        public ulong B; // 0x18
        public ulong C; // 0x20
        public ulong D; // 0x28
    }

    public class UnityWebRequest : Object
    {
        public UIntPtr disposeCertificateHandlerOnDispose; // 0x10
        public UnityEngine.Networking.DownloadHandler disposeDownloadHandlerOnDispose; // 0x18
        public UnityEngine.Networking.UploadHandler disposeUploadHandlerOnDispose; // 0x20
        public UnityEngine.Networking.CertificateHandler method; // 0x28
        public System.Uri error; // 0x30
        public string url;
        public string uri;
        public string responseCode;
        public string isModifiable;
        public string isDone;
        public string isNetworkError;
        public bool result; // 0x38
        public bool downloadedBytes; // 0x39
        public bool redirectLimit; // 0x3A

        // ── Methods ──
        public void GetWebErrorString(){} // RVA: 0x7FFAC9C93C10
        public void GetHTTPStatusString(){} // RVA: 0x7FFAC9C93C60
        public void get_disposeCertificateHandlerOnDispose(){} // RVA: 0x7FFAC31D95D0
        public void set_disposeCertificateHandlerOnDispose(){} // RVA: 0x7FFAC31D95C0
        public void get_disposeDownloadHandlerOnDispose(){} // RVA: 0x7FFAC33BCE50
        public void set_disposeDownloadHandlerOnDispose(){} // RVA: 0x7FFAC33BD1D0
        public void get_disposeUploadHandlerOnDispose(){} // RVA: 0x7FFAC3F7B7C0
        public void set_disposeUploadHandlerOnDispose(){} // RVA: 0x7FFAC848C150
        public void ClearCookieCache(){} // RVA: 0x7FFAC9C93E10 | overloaded x2
        public void Create(){} // RVA: 0x7FFAC9C93E70
        public void Release(){} // RVA: 0x7FFAC9C93EC0
        public void InternalDestroy(){} // RVA: 0x7FFAC9C93F10
        public void InternalSetDefaults(){} // RVA: 0x7FFAC9C93FB0
        public void .ctor(){} // RVA: 0x7FFAC9C94200 | overloaded x5
        public void Finalize(){} // RVA: 0x7FFAC9C942C0
        public void Dispose(){} // RVA: 0x7FFAC9C94310
        public void DisposeHandlers(){} // RVA: 0x7FFAC9C94380
        public void BeginWebRequest(){} // RVA: 0x7FFAC9C943F0
        public void SendWebRequest(){} // RVA: 0x7FFAC9C94440
        public void Abort(){} // RVA: 0x7FFAC9C944F0
        public void SetMethod(){} // RVA: 0x7FFAC9C94540
        public void InternalSetMethod(){} // RVA: 0x7FFAC9C945A0
        public void SetCustomMethod(){} // RVA: 0x7FFAC9C946E0
        public void InternalSetCustomMethod(){} // RVA: 0x7FFAC9C94740
        public void set_method(){} // RVA: 0x7FFAC9C94880
        public void GetError(){} // RVA: 0x7FFAC9C94BD0
        public void get_error(){} // RVA: 0x7FFAC9C94C20
        public void set_url(){} // RVA: 0x7FFAC9C94EA0
        public void get_uri(){} // RVA: 0x7FFAC9C94F30
        public void set_uri(){} // RVA: 0x7FFAC9C95030
        public void GetUrl(){} // RVA: 0x7FFAC9C951B0
        public void SetUrl(){} // RVA: 0x7FFAC9C95200
        public void InternalSetUrl(){} // RVA: 0x7FFAC9C95260
        public void get_responseCode(){} // RVA: 0x7FFAC9C953A0
        public void get_isModifiable(){} // RVA: 0x7FFAC9C953F0
        public void get_isDone(){} // RVA: 0x7FFAC9C95440
        public void get_isNetworkError(){} // RVA: 0x7FFAC9C954A0
        public void get_result(){} // RVA: 0x7FFAC9C95500
        public void get_downloadedBytes(){} // RVA: 0x7FFAC9C95550
        public void SetRedirectLimitFromScripting(){} // RVA: 0x7FFAC9C955A0
        public void set_redirectLimit(){} // RVA: 0x7FFAC9C955A0
        public void InternalSetRequestHeader(){} // RVA: 0x7FFAC9C95600
        public void SetRequestHeader(){} // RVA: 0x7FFAC9C95670
        public void GetResponseHeader(){} // RVA: 0x7FFAC9C95870
        public void GetResponseHeaderKeys(){} // RVA: 0x7FFAC9C958D0
        public void GetResponseHeaders(){} // RVA: 0x7FFAC9C95920
        public void SetUploadHandler(){} // RVA: 0x7FFAC9C95B20
        public void get_uploadHandler(){} // RVA: 0x7FFAC91BAEE0
        public void set_uploadHandler(){} // RVA: 0x7FFAC9C95B80
        public void SetDownloadHandler(){} // RVA: 0x7FFAC9C95D10
        public void get_downloadHandler(){} // RVA: 0x7FFAC58A1130
        public void set_downloadHandler(){} // RVA: 0x7FFAC9C95D70
        public void SetCertificateHandler(){} // RVA: 0x7FFAC9C95F00
        public void get_certificateHandler(){} // RVA: 0x7FFAC98DDAD0
        public void set_certificateHandler(){} // RVA: 0x7FFAC9C95F60
        public void SetTimeoutMsec(){} // RVA: 0x7FFAC9C960F0
        public void set_timeout(){} // RVA: 0x7FFAC9C96150
        public void Get(){} // RVA: 0x7FFAC9C962D0
        public void EscapeURL(){} // RVA: 0x7FFAC9C96560 | overloaded x2
    }

    public class UnityWebRequestAssetBundle : Object
    {
        // ── Methods ──
        public void GetAssetBundle(){} // RVA: 0x7FFAC9C8FCE0 | overloaded x3
    }

    public class UnityWebRequestAsyncOperation : AsyncOperation
    {
        public UnityEngine.Networking.UnityWebRequest webRequest; // 0x20

        // ── Methods ──
        public void get_webRequest(){} // RVA: 0x7FFAC2F4F0C0
        public void set_webRequest(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnityWebRequestTexture : Object
    {
        // ── Methods ──
        public void GetTexture(){} // RVA: 0x7FFAC9C96DE0 | overloaded x2
    }

    public class UploadHandler : Object
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void Release(){} // RVA: 0x7FFAC9C966F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Finalize(){} // RVA: 0x7FFAC9C92AE0
        public void Dispose(){} // RVA: 0x7FFAC9C96740
    }

    public class UploadHandlerRaw : UploadHandler
    {
        public Unity.Collections.NativeArray`1<byte> m_Payload; // 0x18

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9C967A0
        public void .ctor(){} // RVA: 0x7FFAC9C96A30 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC9C96B00
    }

}