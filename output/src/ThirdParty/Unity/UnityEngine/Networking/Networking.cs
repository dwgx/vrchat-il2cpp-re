// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Networking
// Classes: 17
// Methods: 197

namespace ThirdParty.Unity.UnityEngine.Networking
{
    public class CertificateHandler : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AF2DB010
        public void Release(){} // RVA: 0x7AF2DB060
        public void .ctor(){} // RVA: 0x7AF2DB0B0
        public void Finalize(){} // RVA: 0x7AF2DB110
        public void ValidateCertificate(){} // RVA: 0x7AA57AB40
        public void ValidateCertificateNative(){} // RVA: 0x7ABC094F0
        public void Dispose(){} // RVA: 0x7AF2DB1A0
    }

    public class CertificateHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class DownloadHandler : Object
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x7AF2DB200
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Finalize(){} // RVA: 0x7AF2DB250
        public void Dispose(){} // RVA: 0x7AF2DB2A0
        public void get_isDone(){} // RVA: 0x7AF2DB300
        public void IsDone(){} // RVA: 0x7AF2DB300
        public void get_error(){} // RVA: 0x7AF2DB350
        public void GetErrorMsg(){} // RVA: 0x7AF2DB350
        public void get_nativeData(){} // RVA: 0x7AF2DB3A0
        public void get_data(){} // RVA: 0x7A9AA40B0
        public void get_text(){} // RVA: 0x7A874BF50
        public void GetNativeData(){} // RVA: 0x7A85FAA40
        public void GetData(){} // RVA: 0x7AF2DB450
        public void GetText(){} // RVA: 0x7AF2DB4E0
        public void GetTextEncoder(){} // RVA: 0x7AF2DB5B0
        public void GetContentType(){} // RVA: 0x7AF2DB9F0
        public void ReceiveData(){} // RVA: 0x7A9EEB150
        public void ReceiveContentLengthHeader(){} // RVA: 0x7AF2DBA40
        public void ReceiveContentLength(){} // RVA: 0x7A80D7310
        public void CompleteContent(){} // RVA: 0x7A80D7310
        public void GetProgress(){} // RVA: 0x7AEED1930
        public void GetCheckedDownloader(){} // RVA: 0x7AA444D20
        public void InternalGetByteArray(){} // RVA: 0x7AF2DB450
        public void InternalGetNativeArray(){} // RVA: 0x7AF2DBAC0
        public void DisposeNativeArray(){} // RVA: 0x7AF2DBC00
        public void CreateNativeArrayForNativeData(){} // RVA: 0x7AF2DBC40
    }

    public class DownloadHandlerAssetBundle : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AF2D8620
        public void CreateCached(){} // RVA: 0x7AF2D86B0
        public void InternalCreateAssetBundle(){} // RVA: 0x7AF2D8750
        public void InternalCreateAssetBundleCached(){} // RVA: 0x7AF2D8860
        public void .ctor(){} // RVA: 0x7AF2D8AC0
        public void GetData(){} // RVA: 0x7AF2D8C10
        public void GetText(){} // RVA: 0x7AF2D8C60
        public void get_assetBundle(){} // RVA: 0x7AF2D8CB0
        public void GetContent(){} // RVA: 0x7AF2D8D00
        public void CreateCached_Injected(){} // RVA: 0x7AF2D8D90
    }

    public class DownloadHandlerBuffer : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AF2DBCB0
        public void InternalCreateBuffer(){} // RVA: 0x7AF2DBD00
        public void .ctor(){} // RVA: 0x7AF2DBD00
        public void GetNativeData(){} // RVA: 0x7AF2DBD60
        public void Dispose(){} // RVA: 0x7AF2DBD90
    }

    public class DownloadHandlerFile : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AF2DC060
        public void InternalCreateVFS(){} // RVA: 0x7AF2DC0D0
        public void .ctor(){} // RVA: 0x7AF2DC1B0
        public void GetNativeData(){} // RVA: 0x7AF2DC280
        public void GetData(){} // RVA: 0x7AF2DC2D0
        public void GetText(){} // RVA: 0x7AF2DC320
    }

    public class DownloadHandlerScript : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AF2DBE20
        public void CreatePreallocated(){} // RVA: 0x7AF2DBE70
        public void InternalCreateScript(){} // RVA: 0x7AF2DBF30
        public void .ctor(){} // RVA: 0x7AF2DBFA0
    }

    public class DownloadHandlerTexture : DownloadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AF2DF320
        public void InternalCreateTexture(){} // RVA: 0x7AF2DF380
        public void .ctor(){} // RVA: 0x7AF2DF3F0
        public void GetNativeData(){} // RVA: 0x7AF2DBD60
        public void Dispose(){} // RVA: 0x7AF2DBD90
        public void get_texture(){} // RVA: 0x7AF2DF460
        public void InternalGetTextureNative(){} // RVA: 0x7AF2DF460
        public void GetContent(){} // RVA: 0x7AF2DF4B0
    }

    public class DownloadHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class EncryptionKey[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class UnityWebRequest : Object
    {
        // ── Methods ──
        public void GetWebErrorString(){} // RVA: 0x7AF2DC370
        public void GetHTTPStatusString(){} // RVA: 0x7AF2DC3C0
        public void get_disposeCertificateHandlerOnDispose(){} // RVA: 0x7A82A20A0
        public void set_disposeCertificateHandlerOnDispose(){} // RVA: 0x7A82A2C90
        public void get_disposeDownloadHandlerOnDispose(){} // RVA: 0x7A82A3DE0
        public void set_disposeDownloadHandlerOnDispose(){} // RVA: 0x7A82A20B0
        public void get_disposeUploadHandlerOnDispose(){} // RVA: 0x7A9286CF0
        public void set_disposeUploadHandlerOnDispose(){} // RVA: 0x7ADAE26D0
        public void ClearCookieCache(){} // RVA: 0x7AF2DC570
        public void Create(){} // RVA: 0x7AF2DC5D0
        public void Release(){} // RVA: 0x7AF2DC620
        public void InternalDestroy(){} // RVA: 0x7AF2DC670
        public void InternalSetDefaults(){} // RVA: 0x7AF2DC710
        public void .ctor(){} // RVA: 0x7AF2DC960
        public void Finalize(){} // RVA: 0x7AF2DCA20
        public void Dispose(){} // RVA: 0x7AF2DCA70
        public void DisposeHandlers(){} // RVA: 0x7AF2DCAE0
        public void BeginWebRequest(){} // RVA: 0x7AF2DCB50
        public void SendWebRequest(){} // RVA: 0x7AF2DCBA0
        public void Abort(){} // RVA: 0x7AF2DCC50
        public void SetMethod(){} // RVA: 0x7AF2DCCA0
        public void InternalSetMethod(){} // RVA: 0x7AF2DCD00
        public void SetCustomMethod(){} // RVA: 0x7AF2DCE40
        public void InternalSetCustomMethod(){} // RVA: 0x7AF2DCEA0
        public void set_method(){} // RVA: 0x7AF2DCFE0
        public void GetError(){} // RVA: 0x7AF2DD330
        public void get_error(){} // RVA: 0x7AF2DD380
        public void set_url(){} // RVA: 0x7AF2DD600
        public void get_uri(){} // RVA: 0x7AF2DD690
        public void set_uri(){} // RVA: 0x7AF2DD790
        public void GetUrl(){} // RVA: 0x7AF2DD920
        public void SetUrl(){} // RVA: 0x7AF2DD970
        public void InternalSetUrl(){} // RVA: 0x7AF2DD9D0
        public void get_responseCode(){} // RVA: 0x7AF2DDB10
        public void get_isModifiable(){} // RVA: 0x7AF2DDB60
        public void get_isDone(){} // RVA: 0x7AF2DDBB0
        public void get_isNetworkError(){} // RVA: 0x7AF2DDC10
        public void get_result(){} // RVA: 0x7AF2DDC70
        public void get_downloadedBytes(){} // RVA: 0x7AF2DDCC0
        public void SetRedirectLimitFromScripting(){} // RVA: 0x7AF2DDD10
        public void set_redirectLimit(){} // RVA: 0x7AF2DDD10
        public void InternalSetRequestHeader(){} // RVA: 0x7AF2DDD70
        public void SetRequestHeader(){} // RVA: 0x7AF2DDDE0
        public void GetResponseHeader(){} // RVA: 0x7AF2DDFE0
        public void GetResponseHeaderKeys(){} // RVA: 0x7AF2DE040
        public void GetResponseHeaders(){} // RVA: 0x7AF2DE090
        public void SetUploadHandler(){} // RVA: 0x7AF2DE290
        public void get_uploadHandler(){} // RVA: 0x7AE8145B0
        public void set_uploadHandler(){} // RVA: 0x7AF2DE2F0
        public void SetDownloadHandler(){} // RVA: 0x7AF2DE480
        public void get_downloadHandler(){} // RVA: 0x7AACE3A80
        public void set_downloadHandler(){} // RVA: 0x7AF2DE4E0
        public void SetCertificateHandler(){} // RVA: 0x7AF2DE670
        public void get_certificateHandler(){} // RVA: 0x7AEF244A0
        public void set_certificateHandler(){} // RVA: 0x7AF2DE6D0
        public void SetTimeoutMsec(){} // RVA: 0x7AF2DE860
        public void set_timeout(){} // RVA: 0x7AF2DE8C0
        public void Get(){} // RVA: 0x7AF2DEA40
        public void EscapeURL(){} // RVA: 0x7AF2DECD0
    }

    public class UnityWebRequestAssetBundle : Object
    {
        // ── Methods ──
        public void GetAssetBundle(){} // RVA: 0x7AF2D8420
    }

    public class UnityWebRequestAsyncOperation : AsyncOperation
    {
        // ── Methods ──
        public void get_webRequest(){} // RVA: 0x7A81052C0
        public void set_webRequest(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UnityWebRequestAsyncOperation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class UnityWebRequestTexture : Object
    {
        // ── Methods ──
        public void GetTexture(){} // RVA: 0x7AF2DF550
    }

    public class UploadHandler : Object
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x7AF2DEE70
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Finalize(){} // RVA: 0x7AF2DB250
        public void Dispose(){} // RVA: 0x7AF2DEEC0
    }

    public class UploadHandlerRaw : UploadHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AF2DEF20
        public void .ctor(){} // RVA: 0x7AF2DF1A0
        public void Dispose(){} // RVA: 0x7AF2DF270
    }

}