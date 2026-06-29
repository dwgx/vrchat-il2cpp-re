// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP
// Classes: 23
// Methods: 420

namespace ThirdParty.BestHTTP.BestHTTP
{
    public class ConnectionBase : Object
    {
        // ── Methods ──
        public void get_ServerAddress(){} // RVA: 0x7A80F2570
        public void set_ServerAddress(){} // RVA: 0x7A80D8E20
        public void get_State(){} // RVA: 0x7A83782A0
        public void set_State(){} // RVA: 0x7A84385B0
        public void get_IsFree(){} // RVA: 0x7B125F170
        public void get_IsActive(){} // RVA: 0x7B125F190
        public void get_CurrentRequest(){} // RVA: 0x7A81052C0
        public void set_CurrentRequest(){} // RVA: 0x7A81052D0
        public void get_IsRemovable(){} // RVA: 0x7B125F1B0
        public void get_StartTime(){} // RVA: 0x7A8105330
        public void set_StartTime(){} // RVA: 0x7A8669350
        public void get_TimedOutStart(){} // RVA: 0x7A83F69F0
        public void set_TimedOutStart(){} // RVA: 0x7A9D7F900
        public void get_HasProxy(){} // RVA: 0x7B125F2D0
        public void get_LastProcessedUri(){} // RVA: 0x7A8292C30
        public void set_LastProcessedUri(){} // RVA: 0x7A8296DE0
        public void .ctor(){} // RVA: 0x7B125F3B0
        public void Abort(){} // RVA: 0x7A7E189D0
        public void Process(){} // RVA: 0x7B125F470
        public void ThreadFunc(){} // RVA: 0x7A80D7310
        public void HandleProgressCallback(){} // RVA: 0x7B125F760
        public void HandleCallback(){} // RVA: 0x7B125F9A0
        public void Recycle(){} // RVA: 0x7B125FAA0
        public void RecycleNow(){} // RVA: 0x7B125FB20
        public void get_IsDisposed(){} // RVA: 0x7A99A2DD0
        public void set_IsDisposed(){} // RVA: 0x7A99A0310
        public void Dispose(){} // RVA: 0x7B125FD00
        public void Finalize(){} // RVA: 0x7B125FD10
    }

    public class ConnectionBase[] : Array
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

    public class FileConnection : ConnectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B125FD60
        public void Abort(){} // RVA: 0x7B125FD70
        public void ThreadFunc(){} // RVA: 0x7B125FDF0
    }

    public class HTTPConnection : ConnectionBase
    {
        // ── Methods ──
        public void get_IsRemovable(){} // RVA: 0x7B1260910
        public void .ctor(){} // RVA: 0x7B125FD60
        public void ThreadFunc(){} // RVA: 0x7B1260AE0
        public void Connect(){} // RVA: 0x7B1262220
        public void Receive(){} // RVA: 0x7B12631C0
        public void LoadFromCache(){} // RVA: 0x7B12639F0
        public void TryLoadAllFromCache(){} // RVA: 0x7B1264010
        public void TryStoreInCache(){} // RVA: 0x7B12642B0
        public void GetRedirectUri(){} // RVA: 0x7B1264420
        public void Abort(){} // RVA: 0x7B1264630
        public void Close(){} // RVA: 0x7B12646C0
        public void Dispose(){} // RVA: 0x7B12648F0
        public void <Connect>b__7_0(){} // RVA: 0x7B1264910
    }

    public class HTTPConnectionRecycledDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81577F0
        public void Invoke(){} // RVA: 0x7A8133090
        public void BeginInvoke(){} // RVA: 0x7A81330A0
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class HTTPManager : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B1264960
        public void get_MaxConnectionPerServer(){} // RVA: 0x7B1265410
        public void set_MaxConnectionPerServer(){} // RVA: 0x7B1265470
        public void get_KeepAliveDefaultValue(){} // RVA: 0x7B1265520
        public void set_KeepAliveDefaultValue(){} // RVA: 0x7B1265580
        public void get_IsCachingDisabled(){} // RVA: 0x7B12655E0
        public void set_IsCachingDisabled(){} // RVA: 0x7B1265640
        public void get_MaxConnectionIdleTime(){} // RVA: 0x7B12656A0
        public void set_MaxConnectionIdleTime(){} // RVA: 0x7B1265700
        public void get_IsCookiesEnabled(){} // RVA: 0x7B1265760
        public void set_IsCookiesEnabled(){} // RVA: 0x7B12657C0
        public void get_CookieJarSize(){} // RVA: 0x7B1265820
        public void set_CookieJarSize(){} // RVA: 0x7B1265880
        public void get_EnablePrivateBrowsing(){} // RVA: 0x7B12658E0
        public void set_EnablePrivateBrowsing(){} // RVA: 0x7B1265940
        public void get_ConnectTimeout(){} // RVA: 0x7B12659A0
        public void set_ConnectTimeout(){} // RVA: 0x7B1265A00
        public void get_RequestTimeout(){} // RVA: 0x7B1265A60
        public void set_RequestTimeout(){} // RVA: 0x7B1265AC0
        public void get_RootCacheFolderProvider(){} // RVA: 0x7B1265B20
        public void set_RootCacheFolderProvider(){} // RVA: 0x7B1265B80
        public void get_Proxy(){} // RVA: 0x7B1265C40
        public void set_Proxy(){} // RVA: 0x7B1265CA0
        public void get_Heartbeats(){} // RVA: 0x7B1265D60
        public void get_Logger(){} // RVA: 0x7B1266050
        public void set_Logger(){} // RVA: 0x7B12661C0
        public void get_DefaultCertificateVerifyer(){} // RVA: 0x7B1266280
        public void set_DefaultCertificateVerifyer(){} // RVA: 0x7B12662E0
        public void get_DefaultClientCredentialsProvider(){} // RVA: 0x7B12663A0
        public void set_DefaultClientCredentialsProvider(){} // RVA: 0x7B1266400
        public void get_UseAlternateSSLDefaultValue(){} // RVA: 0x7B12664C0
        public void set_UseAlternateSSLDefaultValue(){} // RVA: 0x7B1266520
        public void get_DefaultCertificationValidator(){} // RVA: 0x7B1266580
        public void set_DefaultCertificationValidator(){} // RVA: 0x7B12665E0
        public void get_MaxPathLength(){} // RVA: 0x7B12666A0
        public void set_MaxPathLength(){} // RVA: 0x7B1266700
        public void get_IsQuitting(){} // RVA: 0x7B1266760
        public void set_IsQuitting(){} // RVA: 0x7B12667C0
        public void Setup(){} // RVA: 0x7B1266820
        public void SendRequest(){} // RVA: 0x7B1266E70
        public void GetGeneralStatistics(){} // RVA: 0x7B1267130
        public void SendRequestImpl(){} // RVA: 0x7B12675D0
        public void GetKeyForRequest(){} // RVA: 0x7B1267890
        public void CreateConnection(){} // RVA: 0x7B1267B30
        public void FindOrCreateFreeConnection(){} // RVA: 0x7B1267C50
        public void CanProcessFromQueue(){} // RVA: 0x7B1268330
        public void RecycleConnection(){} // RVA: 0x7B1268450
        public void OnConnectionRecylced(){} // RVA: 0x7B1268530
        public void GetConnectionWith(){} // RVA: 0x7B12686E0
        public void RemoveFromQueue(){} // RVA: 0x7B1268980
        public void GetRootCacheFolder(){} // RVA: 0x7B1268A10
        public void OnUpdate(){} // RVA: 0x7B1268BE0
        public void OnQuit(){} // RVA: 0x7B1269E30
        public void AbortAll(){} // RVA: 0x7B126A050
    }

    public class HTTPProtocolFactory : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7B126A820
        public void GetProtocolFromUri(){} // RVA: 0x7B126A9E0
        public void IsSecureProtocol(){} // RVA: 0x7B126AAB0
    }

    public class HTTPProxy : Proxy
    {
        // ── Methods ──
        public void get_IsTransparent(){} // RVA: 0x7A81C68D0
        public void set_IsTransparent(){} // RVA: 0x7A81C68E0
        public void get_SendWholeUri(){} // RVA: 0x7A8477E00
        public void set_SendWholeUri(){} // RVA: 0x7A88C2D40
        public void get_NonTransparentForHTTPS(){} // RVA: 0x7A9955EA0
        public void set_NonTransparentForHTTPS(){} // RVA: 0x7A9265AF0
        public void .ctor(){} // RVA: 0x7B126ACA0
        public void GetRequestPath(){} // RVA: 0x7B126ACE0
        public void Connect(){} // RVA: 0x7B126AE00
    }

    public class HTTPRange : Object
    {
        // ── Methods ──
        public void get_FirstBytePos(){} // RVA: 0x7A8124910
        public void set_FirstBytePos(){} // RVA: 0x7A80DA0C0
        public void get_LastBytePos(){} // RVA: 0x7A8668BC0
        public void set_LastBytePos(){} // RVA: 0x7A8669360
        public void get_ContentLength(){} // RVA: 0x7A83782A0
        public void set_ContentLength(){} // RVA: 0x7A84385B0
        public void get_IsValid(){} // RVA: 0x7A80F2580
        public void set_IsValid(){} // RVA: 0x7A80F2590
        public void .ctor(){} // RVA: 0x7B126C5F0
        public void ToString(){} // RVA: 0x7B126C610
    }

    public class HTTPRequest : Object
    {
        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7A80F2570
        public void set_Uri(){} // RVA: 0x7A80D8E20
        public void get_MethodType(){} // RVA: 0x7A80F26D0
        public void set_MethodType(){} // RVA: 0x7A80F26E0
        public void get_RawData(){} // RVA: 0x7A81052C0
        public void set_RawData(){} // RVA: 0x7A81052D0
        public void get_UploadStream(){} // RVA: 0x7A8105330
        public void set_UploadStream(){} // RVA: 0x7A80D8E80
        public void get_DisposeUploadStream(){} // RVA: 0x7A80FD690
        public void set_DisposeUploadStream(){} // RVA: 0x7A80FD6A0
        public void get_UseUploadStreamLength(){} // RVA: 0x7A80FD6B0
        public void set_UseUploadStreamLength(){} // RVA: 0x7A80FD6C0
        public void get_IsKeepAlive(){} // RVA: 0x7B126C9A0
        public void set_IsKeepAlive(){} // RVA: 0x7B126C9B0
        public void get_DisableCache(){} // RVA: 0x7B126CA20
        public void set_DisableCache(){} // RVA: 0x7B126CA30
        public void get_CacheOnly(){} // RVA: 0x7B126CAA0
        public void set_CacheOnly(){} // RVA: 0x7B126CAB0
        public void get_UseStreaming(){} // RVA: 0x7B1247660
        public void set_UseStreaming(){} // RVA: 0x7B126CB20
        public void get_StreamFragmentSize(){} // RVA: 0x7AE066140
        public void set_StreamFragmentSize(){} // RVA: 0x7B126CB90
        public void get_MaxFragmentQueueLength(){} // RVA: 0x7A8178B30
        public void set_MaxFragmentQueueLength(){} // RVA: 0x7A8178B40
        public void get_Callback(){} // RVA: 0x7A8152D80
        public void set_Callback(){} // RVA: 0x7A8152D90
        public void get_DisableRetry(){} // RVA: 0x7A8100260
        public void set_DisableRetry(){} // RVA: 0x7A8100270
        public void get_IsRedirected(){} // RVA: 0x7A8F1FD00
        public void set_IsRedirected(){} // RVA: 0x7A8F17000
        public void get_RedirectUri(){} // RVA: 0x7A8153390
        public void set_RedirectUri(){} // RVA: 0x7A81533A0
        public void get_CurrentUri(){} // RVA: 0x7B126CC50
        public void get_Response(){} // RVA: 0x7A81A00E0
        public void set_Response(){} // RVA: 0x7A81A00F0
        public void get_ProxyResponse(){} // RVA: 0x7A82C2060
        public void set_ProxyResponse(){} // RVA: 0x7A82C0530
        public void get_Exception(){} // RVA: 0x7A825E100
        public void set_Exception(){} // RVA: 0x7A825F860
        public void get_Tag(){} // RVA: 0x7A81163D0
        public void set_Tag(){} // RVA: 0x7A825E460
        public void get_Credentials(){} // RVA: 0x7A8555100
        public void set_Credentials(){} // RVA: 0x7A8919DE0
        public void get_HasProxy(){} // RVA: 0x7B09742A0
        public void get_Proxy(){} // RVA: 0x7A87D9C10
        public void set_Proxy(){} // RVA: 0x7A8744720
        public void get_MaxRedirects(){} // RVA: 0x7A9B79A40
        public void set_MaxRedirects(){} // RVA: 0x7A9B79A00
        public void get_UseAlternateSSL(){} // RVA: 0x7A8359370
        public void set_UseAlternateSSL(){} // RVA: 0x7A835FCA0
        public void get_IsCookiesEnabled(){} // RVA: 0x7A8359710
        public void set_IsCookiesEnabled(){} // RVA: 0x7A8357970
        public void get_Cookies(){} // RVA: 0x7B126CC60
        public void set_Cookies(){} // RVA: 0x7A8881790
        public void get_FormUsage(){} // RVA: 0x7A9EEB080
        public void set_FormUsage(){} // RVA: 0x7ADE0AE80
        public void get_State(){} // RVA: 0x7ABBEC920
        public void set_State(){} // RVA: 0x7ABBEC930
        public void get_RedirectCount(){} // RVA: 0x7A9651770
        public void set_RedirectCount(){} // RVA: 0x7A9651780
        public void add_CustomCertificationValidator(){} // RVA: 0x7B126CD30
        public void remove_CustomCertificationValidator(){} // RVA: 0x7B126CE50
        public void get_ConnectTimeout(){} // RVA: 0x7A82305B0
        public void set_ConnectTimeout(){} // RVA: 0x7B09A02E0
        public void get_Timeout(){} // RVA: 0x7A81F50F0
        public void set_Timeout(){} // RVA: 0x7AE6C3A40
        public void get_EnableTimoutForStreaming(){} // RVA: 0x7A90B4C50
        public void set_EnableTimoutForStreaming(){} // RVA: 0x7ADF1BE00
        public void get_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x7AE165960
        public void set_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x7AE165970
        public void get_Priority(){} // RVA: 0x7AE796F00
        public void set_Priority(){} // RVA: 0x7AE796F10
        public void get_CustomCertificateVerifyer(){} // RVA: 0x7A8158F50
        public void set_CustomCertificateVerifyer(){} // RVA: 0x7A8158F60
        public void get_CustomClientCredentialsProvider(){} // RVA: 0x7A8158FC0
        public void set_CustomClientCredentialsProvider(){} // RVA: 0x7A8158FD0
        public void get_CustomTLSServerNameList(){} // RVA: 0x7A8142870
        public void set_CustomTLSServerNameList(){} // RVA: 0x7A8142880
        public void get_ProtocolHandler(){} // RVA: 0x7AF0B6750
        public void set_ProtocolHandler(){} // RVA: 0x7B126CF70
        public void add_OnBeforeRedirection(){} // RVA: 0x7B126CF80
        public void remove_OnBeforeRedirection(){} // RVA: 0x7B126D080
        public void add_OnBeforeHeaderSend(){} // RVA: 0x7B126D180
        public void remove_OnBeforeHeaderSend(){} // RVA: 0x7B126D280
        public void get_TryToMinimizeTCPLatency(){} // RVA: 0x7A8401420
        public void set_TryToMinimizeTCPLatency(){} // RVA: 0x7A84017D0
        public void get_SendBufferSize(){} // RVA: 0x7AED8BDB0
        public void set_SendBufferSize(){} // RVA: 0x7AED8BDC0
        public void get_ReceiveBufferSize(){} // RVA: 0x7A9183130
        public void set_ReceiveBufferSize(){} // RVA: 0x7A918EF30
        public void get_Downloaded(){} // RVA: 0x7A8357A90
        public void set_Downloaded(){} // RVA: 0x7AE1BD260
        public void get_DownloadLength(){} // RVA: 0x7A884CA70
        public void set_DownloadLength(){} // RVA: 0x7B126D380
        public void get_DownloadProgressChanged(){} // RVA: 0x7AE706660
        public void set_DownloadProgressChanged(){} // RVA: 0x7AE950BF0
        public void get_UploadStreamLength(){} // RVA: 0x7B126D390
        public void get_Uploaded(){} // RVA: 0x7A8850FF0
        public void set_Uploaded(){} // RVA: 0x7B126D3E0
        public void get_UploadLength(){} // RVA: 0x7A8142BC0
        public void set_UploadLength(){} // RVA: 0x7AE194210
        public void get_UploadProgressChanged(){} // RVA: 0x7A9437E00
        public void set_UploadProgressChanged(){} // RVA: 0x7A9440AF0
        public void get_Headers(){} // RVA: 0x7A8B4D7B0
        public void set_Headers(){} // RVA: 0x7A8B59B40
        public void .ctor(){} // RVA: 0x7B126DA90
        public void AddField(){} // RVA: 0x7B126E270
        public void AddBinaryData(){} // RVA: 0x7B126E3A0
        public void SetForm(){} // RVA: 0x7A8B578B0
        public void GetFormFields(){} // RVA: 0x7B126E490
        public void ClearForm(){} // RVA: 0x7B126E570
        public void SelectFormImplementation(){} // RVA: 0x7B126E630
        public void AddHeader(){} // RVA: 0x7B126E770
        public void SetHeader(){} // RVA: 0x7B126EA10
        public void RemoveHeader(){} // RVA: 0x7B126ECF0
        public void HasHeader(){} // RVA: 0x7B126ED60
        public void GetFirstHeaderValue(){} // RVA: 0x7B126EDE0
        public void GetHeaderValues(){} // RVA: 0x7B126EEC0
        public void RemoveHeaders(){} // RVA: 0x7B126EF60
        public void SetRangeHeader(){} // RVA: 0x7B126F0A0
        public void EnumerateHeaders(){} // RVA: 0x7B126F1B0
        public void SendHeaders(){} // RVA: 0x7B1270150
        public void DumpHeaders(){} // RVA: 0x7B1270380
        public void GetEntityBody(){} // RVA: 0x7B1270580
        public void SendOutTo(){} // RVA: 0x7B1270600
        public void UpgradeCallback(){} // RVA: 0x7B1271350
        public void CallCallback(){} // RVA: 0x7B1271430
        public void CallOnBeforeRedirection(){} // RVA: 0x7B12714F0
        public void FinishStreaming(){} // RVA: 0x7B1271530
        public void Prepare(){} // RVA: 0x7A80D7310
        public void CallCustomCertificationValidator(){} // RVA: 0x7B1271610
        public void Send(){} // RVA: 0x7B1271660
        public void Abort(){} // RVA: 0x7B12716B0
        public void Clear(){} // RVA: 0x7B1271C40
        public void VerboseLogging(){} // RVA: 0x7B1271D60
        public void get_Current(){} // RVA: 0x7A82D1450
        public void MoveNext(){} // RVA: 0x7B1271E90
        public void Reset(){} // RVA: 0x7B1271EA0
        public void System.Collections.Generic.IEnumerator<BestHTTP.HTTPRequest>.get_Current(){} // RVA: 0x7A97F8BA0
        public void Dispose(){} // RVA: 0x7B1271EE0
        public void .cctor(){} // RVA: 0x7B1271F00
    }

    public class HTTPRequest[] : Array
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

    public class HTTPResponse : Object
    {
        // ── Methods ──
        public void get_VersionMajor(){} // RVA: 0x7A8124910
        public void set_VersionMajor(){} // RVA: 0x7A80DA0C0
        public void get_VersionMinor(){} // RVA: 0x7A8668BC0
        public void set_VersionMinor(){} // RVA: 0x7A8669360
        public void get_StatusCode(){} // RVA: 0x7A83782A0
        public void set_StatusCode(){} // RVA: 0x7A84385B0
        public void get_IsSuccess(){} // RVA: 0x7B12727E0
        public void get_Message(){} // RVA: 0x7A81052C0
        public void set_Message(){} // RVA: 0x7A81052D0
        public void get_IsStreamed(){} // RVA: 0x7A84A5BD0
        public void set_IsStreamed(){} // RVA: 0x7A84A5CD0
        public void get_IsStreamingFinished(){} // RVA: 0x7A89FCA90
        public void set_IsStreamingFinished(){} // RVA: 0x7A96C67C0
        public void get_IsFromCache(){} // RVA: 0x7A9E700C0
        public void set_IsFromCache(){} // RVA: 0x7A9E700B0
        public void get_CacheFileInfo(){} // RVA: 0x7A83F69F0
        public void set_CacheFileInfo(){} // RVA: 0x7A8105A90
        public void get_IsCacheOnly(){} // RVA: 0x7A82A20A0
        public void set_IsCacheOnly(){} // RVA: 0x7A82A2C90
        public void get_Headers(){} // RVA: 0x7A8154D80
        public void set_Headers(){} // RVA: 0x7A80FF440
        public void get_Data(){} // RVA: 0x7A8152D80
        public void set_Data(){} // RVA: 0x7A8152D90
        public void get_IsUpgraded(){} // RVA: 0x7A8192400
        public void set_IsUpgraded(){} // RVA: 0x7A8192410
        public void get_Cookies(){} // RVA: 0x7A81A0050
        public void set_Cookies(){} // RVA: 0x7A81A0060
        public void get_DataAsText(){} // RVA: 0x7B1272800
        public void get_DataAsTexture2D(){} // RVA: 0x7B1272910
        public void get_IsClosedManually(){} // RVA: 0x7A8153980
        public void set_IsClosedManually(){} // RVA: 0x7A8153990
        public void .ctor(){} // RVA: 0x7B1272AD0
        public void Receive(){} // RVA: 0x7B1272CD0
        public void ReadPayload(){} // RVA: 0x7B12736F0
        public void ReadHeaders(){} // RVA: 0x7B1273920
        public void AddHeader(){} // RVA: 0x7B1273B20
        public void GetHeaderValues(){} // RVA: 0x7B1273DC0
        public void GetFirstHeaderValue(){} // RVA: 0x7B1273E70
        public void HasHeaderWithValue(){} // RVA: 0x7B1273F60
        public void HasHeader(){} // RVA: 0x7B12740E0
        public void GetRange(){} // RVA: 0x7B1274100
        public void ReadTo(){} // RVA: 0x7B12746D0
        public void NoTrimReadTo(){} // RVA: 0x7B12749B0
        public void ReadChunkLength(){} // RVA: 0x7B1274C50
        public void ReadChunked(){} // RVA: 0x7B1274E80
        public void ReadRaw(){} // RVA: 0x7B12757C0
        public void ReadUnknownSize(){} // RVA: 0x7B1275E40
        public void DecodeStream(){} // RVA: 0x7B1276520
        public void CloseDecompressors(){} // RVA: 0x7B1276920
        public void Decompress(){} // RVA: 0x7B1276AD0
        public void BeginReceiveStreamFragments(){} // RVA: 0x7B1276ED0
        public void FeedStreamFragment(){} // RVA: 0x7B1277000
        public void FlushRemainingFragmentBuffer(){} // RVA: 0x7B1277290
        public void AddStreamedFragment(){} // RVA: 0x7B1277500
        public void WaitWhileFragmentQueueIsFull(){} // RVA: 0x7B1277830
        public void FragmentQueueIsFull(){} // RVA: 0x7B1277980
        public void GetStreamedFragments(){} // RVA: 0x7B1277C20
        public void HasStreamedFragments(){} // RVA: 0x7B1277F50
        public void FinishStreaming(){} // RVA: 0x7B1278050
        public void VerboseLogging(){} // RVA: 0x7B1278100
        public void Dispose(){} // RVA: 0x7B1278270
    }

    public class HTTPUpdateDelegator : MonoBehaviour
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7B1278410
        public void set_Instance(){} // RVA: 0x7B1278470
        public void get_IsCreated(){} // RVA: 0x7B1278520
        public void set_IsCreated(){} // RVA: 0x7B1278580
        public void get_IsThreaded(){} // RVA: 0x7B12785E0
        public void set_IsThreaded(){} // RVA: 0x7B1278640
        public void get_IsThreadRunning(){} // RVA: 0x7B12786A0
        public void set_IsThreadRunning(){} // RVA: 0x7B1278700
        public void get_ThreadFrequencyInMS(){} // RVA: 0x7B1278760
        public void set_ThreadFrequencyInMS(){} // RVA: 0x7B12787C0
        public void .cctor(){} // RVA: 0x7B1278820
        public void CheckInstance(){} // RVA: 0x7B1278880
        public void Setup(){} // RVA: 0x7B1278DF0
        public void ThreadFunc(){} // RVA: 0x7B1279000
        public void Update(){} // RVA: 0x7B12792A0
        public void OnDisable(){} // RVA: 0x7B12793C0
        public void OnApplicationPause(){} // RVA: 0x7B1279480
        public void OnApplicationQuit(){} // RVA: 0x7B1279520
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class IProtocol
    {
        // ── Methods ──
        public void get_IsClosed(){} // RVA: 0x7A7E01900
        public void HandleEvents(){} // RVA: 0x7A7E18770
    }

    public class KeepAliveHeader : Object
    {
        // ── Methods ──
        public void get_TimeOut(){} // RVA: 0x7A80F2570
        public void set_TimeOut(){} // RVA: 0x7A97242F0
        public void get_MaxRequests(){} // RVA: 0x7A83782A0
        public void set_MaxRequests(){} // RVA: 0x7A84385B0
        public void Parse(){} // RVA: 0x7B12606D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class OnBeforeHeaderSendDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8132FA0
        public void Invoke(){} // RVA: 0x7A8133090
        public void BeginInvoke(){} // RVA: 0x7A81330A0
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class OnBeforeRedirectionDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFD1B70
        public void Invoke(){} // RVA: 0x7A8234660
        public void BeginInvoke(){} // RVA: 0x7A8F31640
        public void EndInvoke(){} // RVA: 0x7A98D5590
    }

    public class OnDownloadProgressDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8F31550
        public void Invoke(){} // RVA: 0x7A8234660
        public void BeginInvoke(){} // RVA: 0x7B126C860
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class OnHeaderEnumerationDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9C160C0
        public void Invoke(){} // RVA: 0x7A82344F0
        public void BeginInvoke(){} // RVA: 0x7A98B8490
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class OnRequestFinishedDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9C160C0
        public void Invoke(){} // RVA: 0x7A82344F0
        public void BeginInvoke(){} // RVA: 0x7A98B8490
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class OnUploadProgressDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8F31550
        public void Invoke(){} // RVA: 0x7A8234660
        public void BeginInvoke(){} // RVA: 0x7B126C900
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class Proxy : Object
    {
        // ── Methods ──
        public void get_Address(){} // RVA: 0x7A80F2570
        public void set_Address(){} // RVA: 0x7A80D8E20
        public void get_Credentials(){} // RVA: 0x7A80DA7B0
        public void set_Credentials(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Connect(){} // RVA: 0x7A7E18890
        public void GetRequestPath(){} // RVA: 0x7A7E00B20
    }

    public class SOCKSProxy : Proxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE18E510
        public void GetRequestPath(){} // RVA: 0x7B12799F0
        public void Connect(){} // RVA: 0x7B1279A90
        public void WriteString(){} // RVA: 0x7B127ACF0
        public void WriteBytes(){} // RVA: 0x7B127AE20
        public void BufferToHexStr(){} // RVA: 0x7B127AE70
    }

}