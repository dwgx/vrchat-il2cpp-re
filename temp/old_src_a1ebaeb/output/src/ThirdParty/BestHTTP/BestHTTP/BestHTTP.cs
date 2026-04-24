// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP
// Classes: 1
// Methods: 153

namespace ThirdParty.BestHTTP.BestHTTP
{
    public class HTTPRequest : Object
    {
        public object UploadChunkSize; // 0x3515E610
        public object _rawData; // 0x3515E610, was: <RawData>k__BackingField
        public object _useUploadStreamLength; // 0x3515E610, was: <UseUploadStreamLength>k__Back
        public object _callback; // 0x3515E610, was: <Callback>k__BackingField
        public object _disableRetry; // 0x3515E610, was: <DisableRetry>k__BackingField
        public object _response; // 0x3515E610, was: <Response>k__BackingField
        public object _tag; // 0x3515E610, was: <Tag>k__BackingField
        public object _maxRedirects; // 0x3515E610, was: <MaxRedirects>k__BackingField
        public object customCookies; // 0x3515E610
        public object _redirectCount; // 0x3515E610, was: <RedirectCount>k__BackingField
        public object _timeout; // 0x3515E610, was: <Timeout>k__BackingField
        public object _priority; // 0x3515E610, was: <Priority>k__BackingField
        public object _customTLSServerNameList; // 0x3515E610, was: <CustomTLSServerNameList>k__Ba
        public object _onBeforeHeaderSend; // 0x3515E610
        public object _receiveBufferSize; // 0x3515E610, was: <ReceiveBufferSize>k__BackingF
        public object _downloadProgressChanged; // 0x3515E610, was: <DownloadProgressChanged>k__Ba
        public object _uploadProgressChanged; // 0x3515E610, was: <UploadProgressChanged>k__Back
        public object cacheOnly; // 0x3515E610
        public object _headers; // 0x3515E610, was: <Headers>k__BackingField

        // ── Original Methods ──
        public void get_Uri(){} // RVA: 0x7ffaa894d380
        public void set_Uri(){} // RVA: 0x7ffaa8933e30
        public void get_MethodType(){} // RVA: 0x7ffaa894d4e0
        public void set_MethodType(){} // RVA: 0x7ffaa894d4f0
        public void get_RawData(){} // RVA: 0x7ffaa89600c0
        public void set_RawData(){} // RVA: 0x7ffaa89600d0
        public void get_UploadStream(){} // RVA: 0x7ffaa8960130
        public void set_UploadStream(){} // RVA: 0x7ffaa8933e90
        public void get_DisposeUploadStream(){} // RVA: 0x7ffaa8958450
        public void set_DisposeUploadStream(){} // RVA: 0x7ffaa8958460
        public void get_UseUploadStreamLength(){} // RVA: 0x7ffaa8958470
        public void set_UseUploadStreamLength(){} // RVA: 0x7ffaa8958480
        public void get_IsKeepAlive(){} // RVA: 0x7ffab145d950
        public void set_IsKeepAlive(){} // RVA: 0x7ffab145d960
        public void get_DisableCache(){} // RVA: 0x7ffab145d9d0
        public void set_DisableCache(){} // RVA: 0x7ffab145d9e0
        public void get_CacheOnly(){} // RVA: 0x7ffab145da50
        public void set_CacheOnly(){} // RVA: 0x7ffab145da60
        public void get_UseStreaming(){} // RVA: 0x7ffab145dad0
        public void set_UseStreaming(){} // RVA: 0x7ffab145dae0
        public void get_StreamFragmentSize(){} // RVA: 0x7ffaa9ad6340
        public void set_StreamFragmentSize(){} // RVA: 0x7ffab145db50
        public void get_MaxFragmentQueueLength(){} // RVA: 0x7ffaa89d3080
        public void set_MaxFragmentQueueLength(){} // RVA: 0x7ffaa89d3090
        public void get_Callback(){} // RVA: 0x7ffaa89ad730
        public void set_Callback(){} // RVA: 0x7ffaa89ad740
        public void get_DisableRetry(){} // RVA: 0x7ffaa895b020
        public void set_DisableRetry(){} // RVA: 0x7ffaa895b030
        public void get_IsRedirected(){} // RVA: 0x7ffaa96315d0
        public void set_IsRedirected(){} // RVA: 0x7ffaa962f610
        public void get_RedirectUri(){} // RVA: 0x7ffaa89add50
        public void set_RedirectUri(){} // RVA: 0x7ffaa89add60
        public void get_CurrentUri(){} // RVA: 0x7ffab145dc10
        public void get_Response(){} // RVA: 0x7ffaa89fa590
        public void set_Response(){} // RVA: 0x7ffaa89fa5a0
        public void get_ProxyResponse(){} // RVA: 0x7ffaa8af68f0
        public void set_ProxyResponse(){} // RVA: 0x7ffaa8af19e0
        public void get_Exception(){} // RVA: 0x7ffaa8d1a3b0
        public void set_Exception(){} // RVA: 0x7ffaa8efece0
        public void get_Tag(){} // RVA: 0x7ffaa8971010
        public void set_Tag(){} // RVA: 0x7ffaa8f7b010
        public void get_Credentials(){} // RVA: 0x7ffaa8d1b980
        public void set_Credentials(){} // RVA: 0x7ffaa8f7b070
        public void get_HasProxy(){} // RVA: 0x7ffab0cdaf50
        public void get_Proxy(){} // RVA: 0x7ffaa8f75d20
        public void set_Proxy(){} // RVA: 0x7ffaa8f7b0d0
        public void get_MaxRedirects(){} // RVA: 0x7ffaaa2a7de0
        public void set_MaxRedirects(){} // RVA: 0x7ffaaa2a7dd0
        public void get_UseAlternateSSL(){} // RVA: 0x7ffaa8b6f1e0
        public void set_UseAlternateSSL(){} // RVA: 0x7ffaa8b70a80
        public void get_IsCookiesEnabled(){} // RVA: 0x7ffaa8b6ad60
        public void set_IsCookiesEnabled(){} // RVA: 0x7ffaa8b6bb90
        public void get_Cookies(){} // RVA: 0x7ffab145dc20
        public void set_Cookies(){} // RVA: 0x7ffaa8d71dc0
        public void get_FormUsage(){} // RVA: 0x7ffaaa5f96a0
        public void set_FormUsage(){} // RVA: 0x7ffaae1d6ca0
        public void get_State(){} // RVA: 0x7ffaac120410
        public void set_State(){} // RVA: 0x7ffaac120420
        public void get_RedirectCount(){} // RVA: 0x7ffaa9d66e50
        public void set_RedirectCount(){} // RVA: 0x7ffaa9d66790
        public void add_CustomCertificationValidator(){} // RVA: 0x7ffab145dcf0
        public void remove_CustomCertificationValidator(){} // RVA: 0x7ffab145ddf0
        public void get_ConnectTimeout(){} // RVA: 0x7ffaa8a8a460
        public void set_ConnectTimeout(){} // RVA: 0x7ffab0cf2590
        public void get_Timeout(){} // RVA: 0x7ffaa8a4f100
        public void set_Timeout(){} // RVA: 0x7ffaaea8d820
        public void get_EnableTimoutForStreaming(){} // RVA: 0x7ffaa97ef160
        public void set_EnableTimoutForStreaming(){} // RVA: 0x7ffaae2e8420
        public void get_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x7ffaae5315e0
        public void set_EnableSafeReadOnUnknownContentLength(){} // RVA: 0x7ffaae5315f0
        public void get_Priority(){} // RVA: 0x7ffaaeb60f00
        public void set_Priority(){} // RVA: 0x7ffaaeb60f10
        public void get_CustomCertificateVerifyer(){} // RVA: 0x7ffaa89b3900
        public void set_CustomCertificateVerifyer(){} // RVA: 0x7ffaa89b3910
        public void get_CustomClientCredentialsProvider(){} // RVA: 0x7ffaa89b3970
        public void set_CustomClientCredentialsProvider(){} // RVA: 0x7ffaa89b3980
        public void get_CustomTLSServerNameList(){} // RVA: 0x7ffaa899d2a0
        public void set_CustomTLSServerNameList(){} // RVA: 0x7ffaa899d2b0
        public void get_ProtocolHandler(){} // RVA: 0x7ffaa98b8b60
        public void set_ProtocolHandler(){} // RVA: 0x7ffaa98b9050
        public void add_OnBeforeRedirection(){} // RVA: 0x7ffab145def0
        public void remove_OnBeforeRedirection(){} // RVA: 0x7ffab145dff0
        public void add_OnBeforeHeaderSend(){} // RVA: 0x7ffab145e0f0
        public void remove_OnBeforeHeaderSend(){} // RVA: 0x7ffab145e1f0
        public void get_TryToMinimizeTCPLatency(){} // RVA: 0x7ffaa8c09ad0
        public void set_TryToMinimizeTCPLatency(){} // RVA: 0x7ffaa8c0bc40
        public void get_SendBufferSize(){} // RVA: 0x7ffaaf1674f0
        public void set_SendBufferSize(){} // RVA: 0x7ffaaf167500
        public void get_ReceiveBufferSize(){} // RVA: 0x7ffaaa36dc60
        public void set_ReceiveBufferSize(){} // RVA: 0x7ffaaa36dc70
        public void get_Downloaded(){} // RVA: 0x7ffaa8b68c40
        public void set_Downloaded(){} // RVA: 0x7ffaae5881c0
        public void get_DownloadLength(){} // RVA: 0x7ffaa8f78450
        public void set_DownloadLength(){} // RVA: 0x7ffab145e2f0
        public void get_DownloadProgressChanged(){} // RVA: 0x7ffaaeacfd80
        public void set_DownloadProgressChanged(){} // RVA: 0x7ffaaed19fe0
        public void get_UploadStreamLength(){} // RVA: 0x7ffab145e300
        public void get_Uploaded(){} // RVA: 0x7ffaa8f76810
        public void set_Uploaded(){} // RVA: 0x7ffab145e350
        public void get_UploadLength(){} // RVA: 0x7ffaa899d5f0
        public void set_UploadLength(){} // RVA: 0x7ffaae55fbe0
        public void get_UploadProgressChanged(){} // RVA: 0x7ffaa9b4da80
        public void set_UploadProgressChanged(){} // RVA: 0x7ffaa9b58ef0
        public void get_Headers(){} // RVA: 0x7ffaa8f77ed0
        public void set_Headers(){} // RVA: 0x7ffaa93f6970
        public void .ctor(){} // RVA: 0x7ffab145ea00
        public void .ctor(){} // RVA: 0x7ffab145ea00
        public void .ctor(){} // RVA: 0x7ffab145ea00
        public void .ctor(){} // RVA: 0x7ffab145ea00
        public void .ctor(){} // RVA: 0x7ffab145ea00
        public void .ctor(){} // RVA: 0x7ffab145ea00
        public void .ctor(){} // RVA: 0x7ffab145ea00
        public void .ctor(){} // RVA: 0x7ffab145ea00
        public void AddField(){} // RVA: 0x7ffab145f1e0
        public void AddField(){} // RVA: 0x7ffab145f1e0
        public void AddBinaryData(){} // RVA: 0x7ffab145f310
        public void AddBinaryData(){} // RVA: 0x7ffab145f310
        public void AddBinaryData(){} // RVA: 0x7ffab145f310
        public void ClearForm(){} // RVA: 0x7ffab145f4e0
        public void SelectFormImplementation(){} // RVA: 0x7ffab145f5a0
        public void AddHeader(){} // RVA: 0x7ffab145f6e0
        public void RemoveHeader(){} // RVA: 0x7ffab145fc60
        public void HasHeader(){} // RVA: 0x7ffab145fcd0
        public void RemoveHeaders(){} // RVA: 0x7ffab145fed0
        public void EnumerateHeaders(){} // RVA: 0x7ffab1460120
        public void EnumerateHeaders(){} // RVA: 0x7ffab1460120
        public void SendHeaders(){} // RVA: 0x7ffab14610d0
        public void DumpHeaders(){} // RVA: 0x7ffab1461310
        public void SendOutTo(){} // RVA: 0x7ffab1461580
        public void UpgradeCallback(){} // RVA: 0x7ffab14622e0
        public void CallCallback(){} // RVA: 0x7ffab14623c0
        public void CallOnBeforeRedirection(){} // RVA: 0x7ffab1462480
        public void FinishStreaming(){} // RVA: 0x7ffab14624c0
        public void Prepare(){} // RVA: 0x7ffaa8932310
        public void CallCustomCertificationValidator(){} // RVA: 0x7ffab14625a0
        public void Send(){} // RVA: 0x7ffab14625f0
        public void Abort(){} // RVA: 0x7ffab1462640
        public void Clear(){} // RVA: 0x7ffab1462bb0
        public void VerboseLogging(){} // RVA: 0x7ffab1462cd0
        public void get_Current(){} // RVA: 0x7ffaa8f22da0
        public void MoveNext(){} // RVA: 0x7ffab1462df0
        public void Reset(){} // RVA: 0x7ffab1462e00
        public void System.Collections.Generic.IEnumerator<BestHTTP.HTTPRequest>.get_Current(){} // RVA: 0x7ffaa9f19100
        public void Dispose(){} // RVA: 0x7ffab1462e40
        public void .cctor(){} // RVA: 0x7ffab1462e60
        // ── Binary Analysis Named ──
        public void SetForm(){} // RVA: 0x7ffaa93e3af0
        public void GetFormFields(){} // RVA: 0x7ffab145f400
        public void SetHeader(){} // RVA: 0x7ffab145f980
        public void GetFirstHeaderValue(){} // RVA: 0x7ffab145fd50
        public void GetHeaderValues(){} // RVA: 0x7ffab145fe30
        public void SetRangeHeader(){} // RVA: 0x7ffab1460010
        public void SetRangeHeader(){} // RVA: 0x7ffab1460010
        public void GetEntityBody(){} // RVA: 0x7ffab1461500
    }

}