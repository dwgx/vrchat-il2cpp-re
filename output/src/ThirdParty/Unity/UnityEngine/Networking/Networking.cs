// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Networking
// Classes: 18
// Methods: 228

namespace ThirdParty.Unity.UnityEngine.Networking
{
    public class CertificateHandler : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x812BBF0
        public void ReleaseFromScripting(){} // RVA: 0x812BC40
        public void .ctor(){} // RVA: 0x812BCB0
        public void Finalize(){} // RVA: 0x812BD10
        public void ValidateCertificate(){} // RVA: 0x263B110
        public void ValidateCertificateNative(){} // RVA: 0x487CCE0
        public void Dispose(){} // RVA: 0x812BD50
        public void ReleaseFromScripting_Injected(){} // RVA: 0x812BDC0
    }

    public class CertificateHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class DownloadHandler : Object
    {
        // ── Methods ──
        public void ReleaseFromScripting(){} // RVA: 0x812BE10
        public void .ctor(){} // RVA: 0xB43310
        public void Finalize(){} // RVA: 0x812BE80
        public void Dispose(){} // RVA: 0x812BED0
        public void get_error(){} // RVA: 0x812BF40
        public void GetErrorMsg(){} // RVA: 0x812BF50
        public void get_nativeData(){} // RVA: 0x812C040
        public void get_text(){} // RVA: 0x254FA90
        public void GetNativeData(){} // RVA: 0x10F6190
        public void GetText(){} // RVA: 0x812C0F0
        public void GetTextEncoder(){} // RVA: 0x812C1C0
        public void GetContentType(){} // RVA: 0x812C5D0
        public void ReceiveData(){} // RVA: 0x295D5B0
        public void ReceiveContentLengthHeader(){} // RVA: 0x6C48C50
        public void ReceiveContentLength(){} // RVA: 0xB43310
        public void CompleteContent(){} // RVA: 0xB43310
        public void GetProgress(){} // RVA: 0x7BAE850
        public void GetCheckedDownloader(){} // RVA: 0x306E7C0
        public void InternalGetByteArray(){} // RVA: 0x812C6C0
        public void InternalGetNativeArray(){} // RVA: 0x812C730
        public void DisposeNativeArray(){} // RVA: 0x812C870
        public void CreateNativeArrayForNativeData(){} // RVA: 0x812C8B0
        public void ReleaseFromScripting_Injected(){} // RVA: 0x812C920
        public void GetErrorMsg_Injected(){} // RVA: 0x812C970
        public void GetContentType_Injected(){} // RVA: 0x812C9D0
        public void InternalGetByteArray_Injected(){} // RVA: 0x812CA30
    }

    public class DownloadHandlerAssetBundle : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x8128AB0
        public void CreateCached(){} // RVA: 0x8128C40
        public void InternalCreateAssetBundle(){} // RVA: 0x8128E90
        public void InternalCreateAssetBundleCached(){} // RVA: 0x8128F60
        public void .ctor(){} // RVA: 0x8129150
        public void GetText(){} // RVA: 0x8129260
        public void get_assetBundle(){} // RVA: 0x81292B0
        public void GetContent(){} // RVA: 0x8129360
        public void Create_Injected(){} // RVA: 0x8129440
        public void CreateCached_Injected(){} // RVA: 0x81294D0
        public void get_assetBundle_Injected(){} // RVA: 0x8129560
    }

    public class DownloadHandlerBuffer : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x812CA90
        public void InternalCreateBuffer(){} // RVA: 0x812CAE0
        public void .ctor(){} // RVA: 0x812CAE0
        public void GetNativeData(){} // RVA: 0x812CB40
        public void Dispose(){} // RVA: 0x812CB70
    }

    public class DownloadHandlerFile : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x812CE00
        public void InternalCreateVFS(){} // RVA: 0x812CF60
        public void .ctor(){} // RVA: 0x812D010
        public void GetNativeData(){} // RVA: 0x812D0B0
        public void GetText(){} // RVA: 0x812D100
        public void Create_Injected(){} // RVA: 0x812D150
    }

    public class DownloadHandlerScript : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x812CBC0
        public void CreatePreallocated(){} // RVA: 0x812CC10
        public void InternalCreateScript(){} // RVA: 0x812CCD0
        public void .ctor(){} // RVA: 0x812CD40
    }

    public class DownloadHandlerTexture : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x8131730
        public void InternalCreateTexture(){} // RVA: 0x8131790
        public void .ctor(){} // RVA: 0x81317F0
        public void GetNativeData(){} // RVA: 0x812CB40
        public void Dispose(){} // RVA: 0x812CB70
        public void get_texture(){} // RVA: 0x8131880
        public void InternalGetTextureNative(){} // RVA: 0x8131880
        public void GetContent(){} // RVA: 0x8131930
        public void Create_Injected(){} // RVA: 0x8131A10
        public void InternalGetTextureNative_Injected(){} // RVA: 0x8131A70
    }

    public class DownloadHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class DownloadedTextureParams : ValueType
    {
        // ── Methods ──
        public void get_Default(){} // RVA: 0x8131710
        public void set_readable(){} // RVA: 0x9AF670
        public void SetFlags(){} // RVA: 0x91F160
    }

    public class EncryptionKey[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class UnityWebRequest : Object
    {
        // ── Methods ──
        public void GetWebErrorString(){} // RVA: 0x812D220
        public void GetHTTPStatusString(){} // RVA: 0x812D2F0
        public void get_disposeCertificateHandlerOnDispose(){} // RVA: 0xD16660
        public void set_disposeCertificateHandlerOnDispose(){} // RVA: 0xD14C10
        public void get_disposeDownloadHandlerOnDispose(){} // RVA: 0xD15320
        public void set_disposeDownloadHandlerOnDispose(){} // RVA: 0xD14740
        public void get_disposeUploadHandlerOnDispose(){} // RVA: 0x1DC2880
        public void set_disposeUploadHandlerOnDispose(){} // RVA: 0x676D5E0
        public void ClearCookieCache(){} // RVA: 0x812D4F0
        public void Create(){} // RVA: 0x812D6E0
        public void Release(){} // RVA: 0x812D730
        public void InternalDestroy(){} // RVA: 0x812D7A0
        public void InternalSetDefaults(){} // RVA: 0x812D860
        public void .ctor(){} // RVA: 0x812DAB0
        public void Finalize(){} // RVA: 0x812DB70
        public void Dispose(){} // RVA: 0x812DBC0
        public void DisposeHandlers(){} // RVA: 0x812DC30
        public void BeginWebRequest(){} // RVA: 0x812DCA0
        public void SendWebRequest(){} // RVA: 0x812DD90
        public void Abort(){} // RVA: 0x812DED0
        public void SetMethod(){} // RVA: 0x812DF40
        public void InternalSetMethod(){} // RVA: 0x812DFC0
        public void SetCustomMethod(){} // RVA: 0x812E140
        public void InternalSetCustomMethod(){} // RVA: 0x812E2C0
        public void set_method(){} // RVA: 0x812E400
        public void GetError(){} // RVA: 0x812E740
        public void get_error(){} // RVA: 0x812E7B0
        public void set_url(){} // RVA: 0x812EA00
        public void get_uri(){} // RVA: 0x812EA90
        public void set_uri(){} // RVA: 0x812EB00
        public void GetUrl(){} // RVA: 0x812EC90
        public void SetUrl(){} // RVA: 0x812ED80
        public void InternalSetUrl(){} // RVA: 0x812EF00
        public void get_responseCode(){} // RVA: 0x812F040
        public void get_isModifiable(){} // RVA: 0x812F0B0
        public void get_isDone(){} // RVA: 0x812F120
        public void get_isNetworkError(){} // RVA: 0x812F1A0
        public void get_result(){} // RVA: 0x812F220
        public void get_downloadedBytes(){} // RVA: 0x812F290
        public void SetRedirectLimitFromScripting(){} // RVA: 0x812F300
        public void set_redirectLimit(){} // RVA: 0x812F300
        public void InternalSetRequestHeader(){} // RVA: 0x812F380
        public void SetRequestHeader(){} // RVA: 0x812F5B0
        public void GetResponseHeader(){} // RVA: 0x812F7B0
        public void GetResponseHeaderKeys(){} // RVA: 0x812F980
        public void GetResponseHeaders(){} // RVA: 0x812F9F0
        public void SetUploadHandler(){} // RVA: 0x812FBB0
        public void get_uploadHandler(){} // RVA: 0x7489A40
        public void set_uploadHandler(){} // RVA: 0x812FC40
        public void SetDownloadHandler(){} // RVA: 0x812FE30
        public void get_downloadHandler(){} // RVA: 0x3926770
        public void set_downloadHandler(){} // RVA: 0x812FEC0
        public void SetCertificateHandler(){} // RVA: 0x81300B0
        public void get_certificateHandler(){} // RVA: 0x7C246A0
        public void set_certificateHandler(){} // RVA: 0x8130140
        public void SetTimeoutMsec(){} // RVA: 0x8130330
        public void set_timeout(){} // RVA: 0x81303B0
        public void Get(){} // RVA: 0x8130570
        public void EscapeURL(){} // RVA: 0x8130800
        public void GetWebErrorString_Injected(){} // RVA: 0x81309A0
        public void GetHTTPStatusString_Injected(){} // RVA: 0x8130A00
        public void ClearCookieCache_Injected(){} // RVA: 0x8130A60
        public void Release_Injected(){} // RVA: 0x8130AC0
        public void BeginWebRequest_Injected(){} // RVA: 0x8130B10
        public void Abort_Injected(){} // RVA: 0x8130B60
        public void SetMethod_Injected(){} // RVA: 0x8130BB0
        public void SetCustomMethod_Injected(){} // RVA: 0x8130C10
        public void GetError_Injected(){} // RVA: 0x8130C70
        public void GetUrl_Injected(){} // RVA: 0x8130CC0
        public void SetUrl_Injected(){} // RVA: 0x8130D20
        public void get_responseCode_Injected(){} // RVA: 0x8130D80
        public void get_isModifiable_Injected(){} // RVA: 0x8130DD0
        public void get_result_Injected(){} // RVA: 0x8130E20
        public void get_downloadedBytes_Injected(){} // RVA: 0x8130E70
        public void SetRedirectLimitFromScripting_Injected(){} // RVA: 0x8130EC0
        public void InternalSetRequestHeader_Injected(){} // RVA: 0x8130F20
        public void GetResponseHeader_Injected(){} // RVA: 0x8130F90
        public void GetResponseHeaderKeys_Injected(){} // RVA: 0x8131000
        public void SetUploadHandler_Injected(){} // RVA: 0x8131050
        public void SetDownloadHandler_Injected(){} // RVA: 0x81310B0
        public void SetCertificateHandler_Injected(){} // RVA: 0x8131110
        public void SetTimeoutMsec_Injected(){} // RVA: 0x8131170
    }

    public class UnityWebRequestAssetBundle : Object
    {
        // ── Methods ──
        public void GetAssetBundle(){} // RVA: 0x81288F0
    }

    public class UnityWebRequestAsyncOperation : AsyncOperation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B30300
        public void get_webRequest(){} // RVA: 0xB700F0
        public void set_webRequest(){} // RVA: 0xB70100
    }

    public class UnityWebRequestAsyncOperation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class UnityWebRequestTexture : Object
    {
        // ── Methods ──
        public void GetTexture(){} // RVA: 0x8131AD0
    }

    public class UploadHandler : Object
    {
        // ── Methods ──
        public void ReleaseFromScripting(){} // RVA: 0x81311D0
        public void .ctor(){} // RVA: 0xB43310
        public void Finalize(){} // RVA: 0x812BE80
        public void Dispose(){} // RVA: 0x8131240
        public void ReleaseFromScripting_Injected(){} // RVA: 0x81312B0
    }

    public class UploadHandlerRaw : UploadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x8131300
        public void .ctor(){} // RVA: 0x8131580
        public void Dispose(){} // RVA: 0x8131650
    }

}