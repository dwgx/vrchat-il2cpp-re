// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP
// Classes: 21
// Methods: 415

namespace ThirdParty.BestHTTP.BestHTTP
{
    public class ConnectionBase
    {
        // ── Methods ──
        public void get_ServerAddress(){} // RVA: 0x7FFAF2DA8380
        public void set_ServerAddress(){} // RVA: 0x7FFAF2D8EE30
        public void get_State(){} // RVA: 0x7FFAF306ED50
        public void set_State(){} // RVA: 0x7FFAF30E74E0
        public void get_IsFree(){} // RVA: 0x7FFAFBEDB690
        public void get_IsActive(){} // RVA: 0x7FFAFBEDB6B0
        public void get_CurrentRequest(){} // RVA: 0x7FFAF2DBB0C0
        public void set_CurrentRequest(){} // RVA: 0x7FFAF2DBB0D0
        public void get_IsRemovable(){} // RVA: 0x7FFAFBEDB6D0
        public void get_StartTime(){} // RVA: 0x7FFAF2DBB130
        public void set_StartTime(){} // RVA: 0x7FFAF335C650
        public void get_TimedOutStart(){} // RVA: 0x7FFAF30E74D0
        public void set_TimedOutStart(){} // RVA: 0x7FFAF4A24DF0
        public void get_HasProxy(){} // RVA: 0x7FFAFBEDB7F0
        public void get_LastProcessedUri(){} // RVA: 0x7FFAF2F476A0
        public void set_LastProcessedUri(){} // RVA: 0x7FFAF2F4B830
        public void .ctor(){} // RVA: 0x7FFAFBEDB8D0 | overloaded x2
        public void Abort(){} // RVA: 0x7FFAF2AD4FA0
        public void Process(){} // RVA: 0x7FFAFBEDB990
        public void ThreadFunc(){} // RVA: 0x7FFAF2D8D310
        public void HandleProgressCallback(){} // RVA: 0x7FFAFBEDBC80
        public void HandleCallback(){} // RVA: 0x7FFAFBEDBEC0
        public void Recycle(){} // RVA: 0x7FFAFBEDBFC0
        public void RecycleNow(){} // RVA: 0x7FFAFBEDC040
        public void get_IsDisposed(){} // RVA: 0x7FFAF4694C90
        public void set_IsDisposed(){} // RVA: 0x7FFAF4692170
        public void Dispose(){} // RVA: 0x7FFAFBEDC220 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAFBEDC230
    }

    public class FileConnection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBEDC280
        public void Abort(){} // RVA: 0x7FFAFBEDC290
        public void ThreadFunc(){} // RVA: 0x7FFAFBEDC310
    }

    public class HTTPConnection
    {
        // ── Methods ──
        public void get_IsRemovable(){} // RVA: 0x7FFAFBEDCE30
        public void .ctor(){} // RVA: 0x7FFAFBEDC280
        public void ThreadFunc(){} // RVA: 0x7FFAFBEDD000
        public void Connect(){} // RVA: 0x7FFAFBEDE760
        public void Receive(){} // RVA: 0x7FFAFBEDF6B0
        public void LoadFromCache(){} // RVA: 0x7FFAFBEDFEE0
        public void TryLoadAllFromCache(){} // RVA: 0x7FFAFBEE04E0
        public void TryStoreInCache(){} // RVA: 0x7FFAFBEE0780
        public void GetRedirectUri(){} // RVA: 0x7FFAFBEE08E0
        public void Abort(){} // RVA: 0x7FFAFBEE0AF0
        public void Close(){} // RVA: 0x7FFAFBEE0B80
        public void Dispose(){} // RVA: 0x7FFAFBEE0DB0
        public void <Connect>b__7_0(){} // RVA: 0x7FFAFBEE0DD0
    }

    public class HTTPConnectionRecycledDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E0D190
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
        public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class HTTPManager
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFBEE0E20
        public void get_MaxConnectionPerServer(){} // RVA: 0x7FFAFBEE18D0
        public void set_MaxConnectionPerServer(){} // RVA: 0x7FFAFBEE1930
        public void get_KeepAliveDefaultValue(){} // RVA: 0x7FFAFBEE19E0
        public void set_KeepAliveDefaultValue(){} // RVA: 0x7FFAFBEE1A40
        public void get_IsCachingDisabled(){} // RVA: 0x7FFAFBEE1AA0
        public void set_IsCachingDisabled(){} // RVA: 0x7FFAFBEE1B00
        public void get_MaxConnectionIdleTime(){} // RVA: 0x7FFAFBEE1B60
        public void set_MaxConnectionIdleTime(){} // RVA: 0x7FFAFBEE1BC0
        public void get_IsCookiesEnabled(){} // RVA: 0x7FFAFBEE1C20
        public void set_IsCookiesEnabled(){} // RVA: 0x7FFAFBEE1C80
        public void get_CookieJarSize(){} // RVA: 0x7FFAFBEE1CE0
        public void set_CookieJarSize(){} // RVA: 0x7FFAFBEE1D40
        public void get_EnablePrivateBrowsing(){} // RVA: 0x7FFAFBEE1DA0
        public void set_EnablePrivateBrowsing(){} // RVA: 0x7FFAFBEE1E00
        public void get_ConnectTimeout(){} // RVA: 0x7FFAFBEE1E60
        public void set_ConnectTimeout(){} // RVA: 0x7FFAFBEE1EC0
        public void get_RequestTimeout(){} // RVA: 0x7FFAFBEE1F20
        public void set_RequestTimeout(){} // RVA: 0x7FFAFBEE1F80
        public void get_RootCacheFolderProvider(){} // RVA: 0x7FFAFBEE1FE0
        public void set_RootCacheFolderProvider(){} // RVA: 0x7FFAFBEE2040
        public void get_Proxy(){} // RVA: 0x7FFAFBEE2100
        public void set_Proxy(){} // RVA: 0x7FFAFBEE2160
        public void get_Heartbeats(){} // RVA: 0x7FFAFBEE2220
        public void get_Logger(){} // RVA: 0x7FFAFBEE2510
        public void set_Logger(){} // RVA: 0x7FFAFBEE2680
        public void get_DefaultCertificateVerifyer(){} // RVA: 0x7FFAFBEE2740
        public void set_DefaultCertificateVerifyer(){} // RVA: 0x7FFAFBEE27A0
        public void get_DefaultClientCredentialsProvider(){} // RVA: 0x7FFAFBEE2860
        public void set_DefaultClientCredentialsProvider(){} // RVA: 0x7FFAFBEE28C0
        public void get_UseAlternateSSLDefaultValue(){} // RVA: 0x7FFAFBEE2980
        public void set_UseAlternateSSLDefaultValue(){} // RVA: 0x7FFAFBEE29E0
        public void get_DefaultCertificationValidator(){} // RVA: 0x7FFAFBEE2A40
        public void set_DefaultCertificationValidator(){} // RVA: 0x7FFAFBEE2AA0
        public void get_MaxPathLength(){} // RVA: 0x7FFAFBEE2B60
        public void set_MaxPathLength(){} // RVA: 0x7FFAFBEE2BC0
        public void get_IsQuitting(){} // RVA: 0x7FFAFBEE2C20
        public void set_IsQuitting(){} // RVA: 0x7FFAFBEE2C80
        public void Setup(){} // RVA: 0x7FFAFBEE2CE0
        public void SendRequest(){} // RVA: 0x7FFAFBEE3330 | overloaded x5
        public void GetGeneralStatistics(){} // RVA: 0x7FFAFBEE3630
        public void SendRequestImpl(){} // RVA: 0x7FFAFBEE3AE0
        public void GetKeyForRequest(){} // RVA: 0x7FFAFBEE3DA0
        public void CreateConnection(){} // RVA: 0x7FFAFBEE4030
        public void FindOrCreateFreeConnection(){} // RVA: 0x7FFAFBEE4140
        public void CanProcessFromQueue(){} // RVA: 0x7FFAFBEE47F0
        public void RecycleConnection(){} // RVA: 0x7FFAFBEE4900
        public void OnConnectionRecylced(){} // RVA: 0x7FFAFBEE49E0
        public void GetConnectionWith(){} // RVA: 0x7FFAFBEE4BB0
        public void RemoveFromQueue(){} // RVA: 0x7FFAFBEE4E80
        public void GetRootCacheFolder(){} // RVA: 0x7FFAFBEE4F10
        public void OnUpdate(){} // RVA: 0x7FFAFBEE50E0
        public void OnQuit(){} // RVA: 0x7FFAFBEE6320
        public void AbortAll(){} // RVA: 0x7FFAFBEE6570
    }

    public class HTTPProtocolFactory
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAFBEE6D60
        public void GetProtocolFromUri(){} // RVA: 0x7FFAFBEE6F20
        public void IsSecureProtocol(){} // RVA: 0x7FFAFBEE6FF0
    }

    public class HTTPProxy
    {
        // ── Methods ──
        public void get_IsTransparent(){} // RVA: 0x7FFAF2E7B9D0
        public void set_IsTransparent(){} // RVA: 0x7FFAF2E7B9E0
        public void get_SendWholeUri(){} // RVA: 0x7FFAF316B3A0
        public void set_SendWholeUri(){} // RVA: 0x7FFAF35D65D0
        public void get_NonTransparentForHTTPS(){} // RVA: 0x7FFAF4647EB0
        public void set_NonTransparentForHTTPS(){} // RVA: 0x7FFAF3F5D720
        public void .ctor(){} // RVA: 0x7FFAFBEE71E0 | overloaded x5
        public void GetRequestPath(){} // RVA: 0x7FFAFBEE7220
        public void Connect(){} // RVA: 0x7FFAFBEE7340
    }

    public class HTTPRange
    {
        // ── Methods ──
        public void get_FirstBytePos(){} // RVA: 0x7FFAF2DDA5C0
        public void set_FirstBytePos(){} // RVA: 0x7FFAF2D900C0
        public void get_LastBytePos(){} // RVA: 0x7FFAF335BED0
        public void set_LastBytePos(){} // RVA: 0x7FFAF335C660
        public void get_ContentLength(){} // RVA: 0x7FFAF306ED50
        public void set_ContentLength(){} // RVA: 0x7FFAF30E74E0
        public void get_IsValid(){} // RVA: 0x7FFAF2DA8390
        public void set_IsValid(){} // RVA: 0x7FFAF2DA83A0
        public void .ctor(){} // RVA: 0x7FFAFBEE8B10 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAFBEE8B30
    }

    public class HTTPRequest
    {
        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7FFAF2DA8380
        public void set_Uri(){} // RVA: 0x7FFAF2D8EE30
        public void get_MethodType(){} // RVA: 0x7FFAF2DA84E0
        public void set_MethodType(){} // RVA: 0x7FFAF2DA84F0
        public void get_RawData(){} // RVA: 0x7FFAF2DBB0C0
        public void set_RawData(){} // RVA: 0x7FFAF2DBB0D0
        public void get_UploadStream(){} // RVA: 0x7FFAF2DBB130
        public void set_UploadStream(){} // RVA: 0x7FFAF2D8EE90
        public void get_DisposeUploadStream(){} // RVA: 0x7FFAF2DB3450
        public void set_DisposeUploadStream(){} // RVA: 0x7FFAF2DB3460
        public void get_UseUploadStreamLength(){} // RVA: 0x7FFAF2DB3470
        public void set_UseUploadStreamLength(){} // RVA: 0x7FFAF2DB3480
        public void get_IsKeepAlive(){} // RVA: 0x7FFAFBEE8EC0
        public void set_IsKeepAlive(){} // RVA: 0x7FFAFBEE8ED0
        public void get_DisableCache(){} // RVA: 0x7FFAFBEE8F40
        public void set_DisableCache(){} // RVA: 0x7FFAFBEE8F50
        public void get_CacheOnly(){} // RVA: 0x7FFAFBEE8FC0
        public void set_CacheOnly(){} // RVA: 0x7FFAFBEE8FD0
        public void get_UseStreaming(){} // RVA: 0x7FFAFBEC3E70
        public void set_UseStreaming(){} // RVA: 0x7FFAFBEE9040
        public void get_StreamFragmentSize(){} // RVA: 0x7FFAF8D2A2E0
        public void set_StreamFragmentSize(){} // RVA: 0x7FFAFBEE90B0
        public void get_MaxFragmentQueueLength(){} // RVA: 0x7FFAF2E2E080
        public void set_MaxFragmentQueueLength(){} // RVA: 0x7FFAF2E2E090
        public void get_Callback(){} // RVA: 0x7FFAF2E08730
        public void set_Callback(){} // RVA: 0x7FFAF2E08740
        public void get_DisableRetry(){} // RVA: 0x7FFAF2DB6020
        public void set_DisableRetry(){} // RVA: 0x7FFAF2DB6030
        public void get_IsRedirected(){} // RVA: 0x7FFAF3C0A230
        public void set_IsRedirected(){} // RVA: 0x7FFAF3BFF200
        public void get_RedirectUri(){} // RVA: 0x7FFAF2E08D50
        public void set_RedirectUri(){} // RVA: 0x7FFAF2E08D60
        public void get_CurrentUri(){} // RVA: 0x7FFAFBEE9170
        public void get_Response(){} // RVA: 0x7FFAF2E55590
        public void set_Response(){} // RVA: 0x7FFAF2E555A0
        public void get_ProxyResponse(){} // RVA: 0x7FFAF2F77C50
        public void set_ProxyResponse(){} // RVA: 0x7FFAF2F734F0
        public void get_Exception(){} // RVA: 0x7FFAF2F12D00
        public void set_Exception(){} // RVA: 0x7FFAF2F14450
        public void get_Tag(){} // RVA: 0x7FFAF2DCC010
        public void set_Tag(){} // RVA: 0x7FFAF2F13060
        public void get_Credentials(){} // RVA: 0x7FFAF3246DE0
        public void set_Credentials(){} // RVA: 0x7FFAF3604600
        public void get_HasProxy(){} // RVA: 0x7FFAFB60F640
        public void get_Proxy(){} // RVA: 0x7FFAF34CC8C0
        public void set_Proxy(){} // RVA: 0x7FFAF345A650
        public void get_MaxRedirects(){} // RVA: 0x7FFAF4826590
        public void set_MaxRedirects(){} // RVA: 0x7FFAF4826550
        public void get_UseAlternateSSL(){} // RVA: 0x7FFAF304FF40
        public void set_UseAlternateSSL(){} // RVA: 0x7FFAF3056940
        public void get_IsCookiesEnabled(){} // RVA: 0x7FFAF3050300
        public void set_IsCookiesEnabled(){} // RVA: 0x7FFAF304E540
        public void get_Cookies(){} // RVA: 0x7FFAFBEE9180
        public void set_Cookies(){} // RVA: 0x7FFAF3595030
        public void get_FormUsage(){} // RVA: 0x7FFAF4B867F0
        public void set_FormUsage(){} // RVA: 0x7FFAF8ACE410
        public void get_State(){} // RVA: 0x7FFAF68A1350
        public void set_State(){} // RVA: 0x7FFAF68A1360
        public void get_RedirectCount(){} // RVA: 0x7FFAF4346340
        public void set_RedirectCount(){} // RVA: 0x7FFAF4346350
        public void add_CustomCertificationValidator(){} // RVA: 0x7FFAFBEE9250
        public void remove_CustomCertificationValidator(){} // RVA: 0x7FFAFBEE9350
        public void get_ConnectTimeout(){} // RVA: 0x7FFAF2EE5460
        public void set_ConnectTimeout(){} // RVA: 0x7FFAFB63A2E0
        public void get_Timeout(){} // RVA: 0x7FFAF2EAA100
        public void set_Timeout(){} // RVA: 0x7FFAF9384D30
        public void get_EnableTimoutForStreaming(){} // RVA: 0x7FFAF3DAD610
        public void set_EnableTimoutForStreaming(){} // RVA: 0x7FFAF8BDFB20
        public void get_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x7FFAF8E29020
        public void set_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x7FFAF8E29030
        public void get_Priority(){} // RVA: 0x7FFAF9458410
        public void set_Priority(){} // RVA: 0x7FFAF9458420
        public void get_CustomCertificateVerifyer(){} // RVA: 0x7FFAF2E0E900
        public void set_CustomCertificateVerifyer(){} // RVA: 0x7FFAF2E0E910
        public void get_CustomClientCredentialsProvider(){} // RVA: 0x7FFAF2E0E970
        public void set_CustomClientCredentialsProvider(){} // RVA: 0x7FFAF2E0E980
        public void get_CustomTLSServerNameList(){} // RVA: 0x7FFAF2DF82A0
        public void set_CustomTLSServerNameList(){} // RVA: 0x7FFAF2DF82B0
        public void get_ProtocolHandler(){} // RVA: 0x7FFAF9D86570
        public void set_ProtocolHandler(){} // RVA: 0x7FFAFBEE9450
        public void add_OnBeforeRedirection(){} // RVA: 0x7FFAFBEE9460
        public void remove_OnBeforeRedirection(){} // RVA: 0x7FFAFBEE9560
        public void add_OnBeforeHeaderSend(){} // RVA: 0x7FFAFBEE9660
        public void remove_OnBeforeHeaderSend(){} // RVA: 0x7FFAFBEE9760
        public void get_TryToMinimizeTCPLatency(){} // RVA: 0x7FFAF311C530
        public void set_TryToMinimizeTCPLatency(){} // RVA: 0x7FFAF311C8F0
        public void get_SendBufferSize(){} // RVA: 0x7FFAF9A5CBE0
        public void set_SendBufferSize(){} // RVA: 0x7FFAF9A5CBF0
        public void get_ReceiveBufferSize(){} // RVA: 0x7FFAF3E7BAD0
        public void set_ReceiveBufferSize(){} // RVA: 0x7FFAF3E87860
        public void get_Downloaded(){} // RVA: 0x7FFAF304E660
        public void set_Downloaded(){} // RVA: 0x7FFAF8E7FC10
        public void get_DownloadLength(){} // RVA: 0x7FFAF353EE80
        public void set_DownloadLength(){} // RVA: 0x7FFAFBEE9860
        public void get_DownloadProgressChanged(){} // RVA: 0x7FFAF93C7290
        public void set_DownloadProgressChanged(){} // RVA: 0x7FFAF9611490
        public void get_UploadStreamLength(){} // RVA: 0x7FFAFBEE9870
        public void get_Uploaded(){} // RVA: 0x7FFAF35433D0
        public void set_Uploaded(){} // RVA: 0x7FFAFBEE98C0
        public void get_UploadLength(){} // RVA: 0x7FFAF2DF85F0
        public void set_UploadLength(){} // RVA: 0x7FFAF8E57620
        public void get_UploadProgressChanged(){} // RVA: 0x7FFAF412DAF0
        public void set_UploadProgressChanged(){} // RVA: 0x7FFAF4136780
        public void get_Headers(){} // RVA: 0x7FFAF383A610
        public void set_Headers(){} // RVA: 0x7FFAF3845D10
        public void .ctor(){} // RVA: 0x7FFAFBEE9F70 | overloaded x8
        public void AddField(){} // RVA: 0x7FFAFBEEA750 | overloaded x2
        public void AddBinaryData(){} // RVA: 0x7FFAFBEEA880 | overloaded x3
        public void SetForm(){} // RVA: 0x7FFAF3843D70
        public void GetFormFields(){} // RVA: 0x7FFAFBEEA970
        public void ClearForm(){} // RVA: 0x7FFAFBEEAA50
        public void SelectFormImplementation(){} // RVA: 0x7FFAFBEEAB10
        public void AddHeader(){} // RVA: 0x7FFAFBEEAC50
        public void SetHeader(){} // RVA: 0x7FFAFBEEAEF0
        public void RemoveHeader(){} // RVA: 0x7FFAFBEEB1D0
        public void HasHeader(){} // RVA: 0x7FFAFBEEB240
        public void GetFirstHeaderValue(){} // RVA: 0x7FFAFBEEB2C0
        public void GetHeaderValues(){} // RVA: 0x7FFAFBEEB3A0
        public void RemoveHeaders(){} // RVA: 0x7FFAFBEEB440
        public void SetRangeHeader(){} // RVA: 0x7FFAFBEEB580 | overloaded x2
        public void EnumerateHeaders(){} // RVA: 0x7FFAFBEEB690 | overloaded x2
        public void SendHeaders(){} // RVA: 0x7FFAFBEEC640
        public void DumpHeaders(){} // RVA: 0x7FFAFBEEC880
        public void GetEntityBody(){} // RVA: 0x7FFAFBEECA70
        public void SendOutTo(){} // RVA: 0x7FFAFBEECAF0
        public void UpgradeCallback(){} // RVA: 0x7FFAFBEED850
        public void CallCallback(){} // RVA: 0x7FFAFBEED930
        public void CallOnBeforeRedirection(){} // RVA: 0x7FFAFBEED9F0
        public void FinishStreaming(){} // RVA: 0x7FFAFBEEDA30
        public void Prepare(){} // RVA: 0x7FFAF2D8D310
        public void CallCustomCertificationValidator(){} // RVA: 0x7FFAFBEEDB10
        public void Send(){} // RVA: 0x7FFAFBEEDB60
        public void Abort(){} // RVA: 0x7FFAFBEEDBB0
        public void Clear(){} // RVA: 0x7FFAFBEEE120
        public void VerboseLogging(){} // RVA: 0x7FFAFBEEE240
        public void get_Current(){} // RVA: 0x7FFAF2FC9240
        public void MoveNext(){} // RVA: 0x7FFAFBEEE360
        public void Reset(){} // RVA: 0x7FFAFBEEE370
        public void System.Collections.Generic.IEnumerator<BestHTTP.HTTPRequest>.get_Current(){} // RVA: 0x7FFAF44EF520
        public void Dispose(){} // RVA: 0x7FFAFBEEE3B0
        public void .cctor(){} // RVA: 0x7FFAFBEEE3D0
    }

    public class HTTPResponse
    {
        // ── Methods ──
        public void get_VersionMajor(){} // RVA: 0x7FFAF2DDA5C0
        public void set_VersionMajor(){} // RVA: 0x7FFAF2D900C0
        public void get_VersionMinor(){} // RVA: 0x7FFAF335BED0
        public void set_VersionMinor(){} // RVA: 0x7FFAF335C660
        public void get_StatusCode(){} // RVA: 0x7FFAF306ED50
        public void set_StatusCode(){} // RVA: 0x7FFAF30E74E0
        public void get_IsSuccess(){} // RVA: 0x7FFAFBEEEC90
        public void get_Message(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Message(){} // RVA: 0x7FFAF2DBB0D0
        public void get_IsStreamed(){} // RVA: 0x7FFAF3198A80
        public void set_IsStreamed(){} // RVA: 0x7FFAF3198B80
        public void get_IsStreamingFinished(){} // RVA: 0x7FFAF36E6000
        public void set_IsStreamingFinished(){} // RVA: 0x7FFAF43BAB20
        public void get_IsFromCache(){} // RVA: 0x7FFAF4B0EA40
        public void set_IsFromCache(){} // RVA: 0x7FFAF4B0EA30
        public void get_CacheFileInfo(){} // RVA: 0x7FFAF30E74D0
        public void set_CacheFileInfo(){} // RVA: 0x7FFAF2DBB890
        public void get_IsCacheOnly(){} // RVA: 0x7FFAF2F56500
        public void set_IsCacheOnly(){} // RVA: 0x7FFAF2F578C0
        public void get_Headers(){} // RVA: 0x7FFAF2E0A740
        public void set_Headers(){} // RVA: 0x7FFAF2DB5200
        public void get_Data(){} // RVA: 0x7FFAF2E08730
        public void set_Data(){} // RVA: 0x7FFAF2E08740
        public void get_IsUpgraded(){} // RVA: 0x7FFAF2E478E0
        public void set_IsUpgraded(){} // RVA: 0x7FFAF2E478F0
        public void get_Cookies(){} // RVA: 0x7FFAF2E55500
        public void set_Cookies(){} // RVA: 0x7FFAF2E55510
        public void get_DataAsText(){} // RVA: 0x7FFAFBEEECB0
        public void get_DataAsTexture2D(){} // RVA: 0x7FFAFBEEEDC0
        public void get_IsClosedManually(){} // RVA: 0x7FFAF2E09320
        public void set_IsClosedManually(){} // RVA: 0x7FFAF2E09330
        public void .ctor(){} // RVA: 0x7FFAFBEEEF80
        public void Receive(){} // RVA: 0x7FFAFBEEF160
        public void ReadPayload(){} // RVA: 0x7FFAFBEEFB70
        public void ReadHeaders(){} // RVA: 0x7FFAFBEEFDA0
        public void AddHeader(){} // RVA: 0x7FFAFBEEFFA0
        public void GetHeaderValues(){} // RVA: 0x7FFAFBEF0240
        public void GetFirstHeaderValue(){} // RVA: 0x7FFAFBEF02F0
        public void HasHeaderWithValue(){} // RVA: 0x7FFAFBEF03E0
        public void HasHeader(){} // RVA: 0x7FFAFBEF0550
        public void GetRange(){} // RVA: 0x7FFAFBEF0570
        public void ReadTo(){} // RVA: 0x7FFAFBEF0B30 | overloaded x2
        public void NoTrimReadTo(){} // RVA: 0x7FFAFBEF0E30
        public void ReadChunkLength(){} // RVA: 0x7FFAFBEF10D0
        public void ReadChunked(){} // RVA: 0x7FFAFBEF1300
        public void ReadRaw(){} // RVA: 0x7FFAFBEF1C30
        public void ReadUnknownSize(){} // RVA: 0x7FFAFBEF22A0
        public void DecodeStream(){} // RVA: 0x7FFAFBEF2960
        public void CloseDecompressors(){} // RVA: 0x7FFAFBEF2D60
        public void Decompress(){} // RVA: 0x7FFAFBEF2F10
        public void BeginReceiveStreamFragments(){} // RVA: 0x7FFAFBEF3310
        public void FeedStreamFragment(){} // RVA: 0x7FFAFBEF3430
        public void FlushRemainingFragmentBuffer(){} // RVA: 0x7FFAFBEF36C0
        public void AddStreamedFragment(){} // RVA: 0x7FFAFBEF3920
        public void WaitWhileFragmentQueueIsFull(){} // RVA: 0x7FFAFBEF3C40
        public void FragmentQueueIsFull(){} // RVA: 0x7FFAFBEF3D90
        public void GetStreamedFragments(){} // RVA: 0x7FFAFBEF4030
        public void HasStreamedFragments(){} // RVA: 0x7FFAFBEF4360
        public void FinishStreaming(){} // RVA: 0x7FFAFBEF4460
        public void VerboseLogging(){} // RVA: 0x7FFAFBEF4510
        public void Dispose(){} // RVA: 0x7FFAFBEF4680
    }

    public class HTTPUpdateDelegator
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAFBEF4820
        public void set_Instance(){} // RVA: 0x7FFAFBEF4880
        public void get_IsCreated(){} // RVA: 0x7FFAFBEF4930
        public void set_IsCreated(){} // RVA: 0x7FFAFBEF4990
        public void get_IsThreaded(){} // RVA: 0x7FFAFBEF49F0
        public void set_IsThreaded(){} // RVA: 0x7FFAFBEF4A50
        public void get_IsThreadRunning(){} // RVA: 0x7FFAFBEF4AB0
        public void set_IsThreadRunning(){} // RVA: 0x7FFAFBEF4B10
        public void get_ThreadFrequencyInMS(){} // RVA: 0x7FFAFBEF4B70
        public void set_ThreadFrequencyInMS(){} // RVA: 0x7FFAFBEF4BD0
        public void .cctor(){} // RVA: 0x7FFAFBEF4C30
        public void CheckInstance(){} // RVA: 0x7FFAFBEF4C90
        public void Setup(){} // RVA: 0x7FFAFBEF51F0
        public void ThreadFunc(){} // RVA: 0x7FFAFBEF5400
        public void Update(){} // RVA: 0x7FFAFBEF56A0
        public void OnDisable(){} // RVA: 0x7FFAFBEF57C0
        public void OnApplicationPause(){} // RVA: 0x7FFAFBEF5880
        public void OnApplicationQuit(){} // RVA: 0x7FFAFBEF5920
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class IProtocol
    {
        // ── Methods ──
        public void get_IsClosed(){} // RVA: 0x7FFAF2ABDBE0
        public void HandleEvents(){} // RVA: 0x7FFAF2AD4A50
    }

    public class KeepAliveHeader
    {
        // ── Methods ──
        public void get_TimeOut(){} // RVA: 0x7FFAF2DA8380
        public void set_TimeOut(){} // RVA: 0x7FFAF4417700
        public void get_MaxRequests(){} // RVA: 0x7FFAF306ED50
        public void set_MaxRequests(){} // RVA: 0x7FFAF30E74E0
        public void Parse(){} // RVA: 0x7FFAFBEDCBD0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class OnBeforeHeaderSendDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DE8B80
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
        public void BeginInvoke(){} // RVA: 0x7FFAF2DE8C70
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class OnBeforeRedirectionDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C94DD0
        public void Invoke(){} // RVA: 0x7FFAF2EE94E0
        public void BeginInvoke(){} // RVA: 0x7FFAF3C26A90
        public void EndInvoke(){} // RVA: 0x7FFAF45EC940
    }

    public class OnDownloadProgressDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF3C269B0
        public void Invoke(){} // RVA: 0x7FFAF2EE94E0
        public void BeginInvoke(){} // RVA: 0x7FFAFBEE8D80
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class OnHeaderEnumerationDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF48C1FC0
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
        public void BeginInvoke(){} // RVA: 0x7FFAF45AE3C0
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class OnRequestFinishedDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF48C1FC0
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
        public void BeginInvoke(){} // RVA: 0x7FFAF45AE3C0
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class OnUploadProgressDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF3C269B0
        public void Invoke(){} // RVA: 0x7FFAF2EE94E0
        public void BeginInvoke(){} // RVA: 0x7FFAFBEE8E20
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class Proxy
    {
        // ── Methods ──
        public void get_Address(){} // RVA: 0x7FFAF2DA8380
        public void set_Address(){} // RVA: 0x7FFAF2D8EE30
        public void get_Credentials(){} // RVA: 0x7FFAF2D907C0
        public void set_Credentials(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Connect(){} // RVA: 0x7FFAF2ADDC60
        public void GetRequestPath(){} // RVA: 0x7FFAF2ABCE10
    }

    public class SOCKSProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E51980
        public void GetRequestPath(){} // RVA: 0x7FFAFBEF5DF0
        public void Connect(){} // RVA: 0x7FFAFBEF5E90
        public void WriteString(){} // RVA: 0x7FFAFBEF70E0
        public void WriteBytes(){} // RVA: 0x7FFAFBEF7210
        public void BufferToHexStr(){} // RVA: 0x7FFAFBEF7260
    }

}