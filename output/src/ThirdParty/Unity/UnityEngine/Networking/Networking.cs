// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Networking
// Classes: 14
// Methods: 151

namespace ThirdParty.Unity.UnityEngine.Networking
{
    public class CertificateHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x74FAF20
        public void Release(){} // RVA: 0x74FAF70
        public void .ctor(){} // RVA: 0x74FAFC0
        public void Finalize(){} // RVA: 0x74FB020
        public void ValidateCertificate(){} // RVA: 0x27694F0
        public void ValidateCertificateNative(){} // RVA: 0x3E0E500
        public void Dispose(){} // RVA: 0x74FB0B0
    }

    public class DownloadHandler
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x74FB110
        public void .ctor(){} // RVA: 0x2DD310
        public void Finalize(){} // RVA: 0x74FB160
        public void Dispose(){} // RVA: 0x74FB1B0
        public void get_isDone(){} // RVA: 0x74FB210
        public void IsDone(){} // RVA: 0x74FB210
        public void get_error(){} // RVA: 0x74FB260
        public void GetErrorMsg(){} // RVA: 0x74FB260
        public void get_nativeData(){} // RVA: 0x74FB2B0
        public void get_data(){} // RVA: 0x1CA1C00
        public void get_text(){} // RVA: 0x950560
        public void GetNativeData(){} // RVA: 0x83DAC0
        public void GetData(){} // RVA: 0x74FB360
        public void GetText(){} // RVA: 0x74FB3F0
        public void GetTextEncoder(){} // RVA: 0x74FB4D0
        public void GetContentType(){} // RVA: 0x74FB910
        public void ReceiveData(){} // RVA: 0x20D68C0
        public void ReceiveContentLengthHeader(){} // RVA: 0x74FB960
        public void ReceiveContentLength(){} // RVA: 0x2DD310
        public void CompleteContent(){} // RVA: 0x2DD310
        public void GetProgress(){} // RVA: 0x70F2A70
        public void GetCheckedDownloader(){} // RVA: 0x283FA0
        public void InternalGetByteArray(){} // RVA: 0x74FB360 | overloaded x2
        public void InternalGetNativeArray(){} // RVA: 0x74FB9E0
        public void DisposeNativeArray(){} // RVA: 0x74FBB20
        public void CreateNativeArrayForNativeData(){} // RVA: 0x74FBB60
    }

    public class DownloadHandlerAssetBundle
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x74F8560
        public void CreateCached(){} // RVA: 0x74F85F0
        public void InternalCreateAssetBundle(){} // RVA: 0x74F8690
        public void InternalCreateAssetBundleCached(){} // RVA: 0x74F87A0
        public void .ctor(){} // RVA: 0x74F89F0 | overloaded x2
        public void GetData(){} // RVA: 0x74F8B40
        public void GetText(){} // RVA: 0x74F8B90
        public void get_assetBundle(){} // RVA: 0x74F8BE0
        public void GetContent(){} // RVA: 0x74F8C30
        public void CreateCached_Injected(){} // RVA: 0x74F8CC0
    }

    public class DownloadHandlerBuffer
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x74FBBD0
        public void InternalCreateBuffer(){} // RVA: 0x74FBC20
        public void .ctor(){} // RVA: 0x74FBC20
        public void GetNativeData(){} // RVA: 0x74FBC80
        public void Dispose(){} // RVA: 0x74FBCB0
    }

    public class DownloadHandlerFile
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x74FBF80
        public void InternalCreateVFS(){} // RVA: 0x74FBFF0
        public void .ctor(){} // RVA: 0x74FC0D0
        public void GetNativeData(){} // RVA: 0x74FC1A0
        public void GetData(){} // RVA: 0x74FC1F0
        public void GetText(){} // RVA: 0x74FC240
    }

    public class DownloadHandlerScript
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x74FBD40
        public void CreatePreallocated(){} // RVA: 0x74FBD90
        public void InternalCreateScript(){} // RVA: 0x74FBE50 | overloaded x2
        public void .ctor(){} // RVA: 0x74FBEC0 | overloaded x2
    }

    public class DownloadHandlerTexture
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x74FF230
        public void InternalCreateTexture(){} // RVA: 0x74FF290
        public void .ctor(){} // RVA: 0x74FF300
        public void GetNativeData(){} // RVA: 0x74FBC80
        public void Dispose(){} // RVA: 0x74FBCB0
        public void get_texture(){} // RVA: 0x74FF370
        public void InternalGetTextureNative(){} // RVA: 0x74FF370
        public void GetContent(){} // RVA: 0x74FF3C0
    }

    public class EncryptionKey
    {
    }

    public class UnityWebRequest
    {
        // ── Methods ──
        public void GetWebErrorString(){} // RVA: 0x74FC290
        public void GetHTTPStatusString(){} // RVA: 0x74FC2E0
        public void get_disposeCertificateHandlerOnDispose(){} // RVA: 0x4A6500
        public void set_disposeCertificateHandlerOnDispose(){} // RVA: 0x4A78C0
        public void get_disposeDownloadHandlerOnDispose(){} // RVA: 0x4A7410
        public void set_disposeDownloadHandlerOnDispose(){} // RVA: 0x4A7670
        public void get_disposeUploadHandlerOnDispose(){} // RVA: 0x14CEB40
        public void set_disposeUploadHandlerOnDispose(){} // RVA: 0x5CF4B50
        public void ClearCookieCache(){} // RVA: 0x74FC490 | overloaded x2
        public void Create(){} // RVA: 0x74FC4F0
        public void Release(){} // RVA: 0x74FC540
        public void InternalDestroy(){} // RVA: 0x74FC590
        public void InternalSetDefaults(){} // RVA: 0x74FC630
        public void .ctor(){} // RVA: 0x74FC880 | overloaded x5
        public void Finalize(){} // RVA: 0x74FC940
        public void Dispose(){} // RVA: 0x74FC990
        public void DisposeHandlers(){} // RVA: 0x74FCA00
        public void BeginWebRequest(){} // RVA: 0x74FCA70
        public void SendWebRequest(){} // RVA: 0x74FCAC0
        public void Abort(){} // RVA: 0x74FCB70
        public void SetMethod(){} // RVA: 0x74FCBC0
        public void InternalSetMethod(){} // RVA: 0x74FCC20
        public void SetCustomMethod(){} // RVA: 0x74FCD60
        public void InternalSetCustomMethod(){} // RVA: 0x74FCDC0
        public void set_method(){} // RVA: 0x74FCF00
        public void GetError(){} // RVA: 0x74FD250
        public void get_error(){} // RVA: 0x74FD2A0
        public void set_url(){} // RVA: 0x74FD520
        public void get_uri(){} // RVA: 0x74FD5B0
        public void set_uri(){} // RVA: 0x74FD6B0
        public void GetUrl(){} // RVA: 0x74FD830
        public void SetUrl(){} // RVA: 0x74FD880
        public void InternalSetUrl(){} // RVA: 0x74FD8E0
        public void get_responseCode(){} // RVA: 0x74FDA20
        public void get_isModifiable(){} // RVA: 0x74FDA70
        public void get_isDone(){} // RVA: 0x74FDAC0
        public void get_isNetworkError(){} // RVA: 0x74FDB20
        public void get_result(){} // RVA: 0x74FDB80
        public void get_downloadedBytes(){} // RVA: 0x74FDBD0
        public void SetRedirectLimitFromScripting(){} // RVA: 0x74FDC20
        public void set_redirectLimit(){} // RVA: 0x74FDC20
        public void InternalSetRequestHeader(){} // RVA: 0x74FDC80
        public void SetRequestHeader(){} // RVA: 0x74FDCF0
        public void GetResponseHeader(){} // RVA: 0x74FDEF0
        public void GetResponseHeaderKeys(){} // RVA: 0x74FDF50
        public void GetResponseHeaders(){} // RVA: 0x74FDFA0
        public void SetUploadHandler(){} // RVA: 0x74FE1A0
        public void get_uploadHandler(){} // RVA: 0x6A24380
        public void set_uploadHandler(){} // RVA: 0x74FE200
        public void SetDownloadHandler(){} // RVA: 0x74FE390
        public void get_downloadHandler(){} // RVA: 0x2F0F420
        public void set_downloadHandler(){} // RVA: 0x74FE3F0
        public void SetCertificateHandler(){} // RVA: 0x74FE580
        public void get_certificateHandler(){} // RVA: 0x7145590
        public void set_certificateHandler(){} // RVA: 0x74FE5E0
        public void SetTimeoutMsec(){} // RVA: 0x74FE770
        public void set_timeout(){} // RVA: 0x74FE7D0
        public void Get(){} // RVA: 0x74FE950
        public void EscapeURL(){} // RVA: 0x74FEBE0 | overloaded x2
    }

    public class UnityWebRequestAssetBundle
    {
        // ── Methods ──
        public void GetAssetBundle(){} // RVA: 0x74F8360 | overloaded x3
    }

    public class UnityWebRequestAsyncOperation
    {
        // ── Methods ──
        public void get_webRequest(){} // RVA: 0x30B0C0
        public void set_webRequest(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UnityWebRequestTexture
    {
        // ── Methods ──
        public void GetTexture(){} // RVA: 0x74FF460 | overloaded x2
    }

    public class UploadHandler
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x74FED70
        public void .ctor(){} // RVA: 0x2DD310
        public void Finalize(){} // RVA: 0x74FB160
        public void Dispose(){} // RVA: 0x74FEDC0
    }

    public class UploadHandlerRaw
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x74FEE20
        public void .ctor(){} // RVA: 0x74FF0B0 | overloaded x2
        public void Dispose(){} // RVA: 0x74FF180
    }

}