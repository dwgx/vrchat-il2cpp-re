// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 11
// Methods: 187

namespace ThirdParty.DotNet.System.Net
{
    public class FileWebRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95ED7B0 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF95D74B0
        public void GetObjectData(){} // RVA: 0x7FFAF95EDE60
        public void get_Aborted(){} // RVA: 0x7FFAF95EE8F0
        public void set_ConnectionGroupName(){} // RVA: 0x7FFAF2F4B830
        public void get_ContentLength(){} // RVA: 0x7FFAF2E0A740
        public void set_ContentLength(){} // RVA: 0x7FFAF95EE900
        public void get_Credentials(){} // RVA: 0x7FFAF2E08730
        public void set_Credentials(){} // RVA: 0x7FFAF2E08740
        public void get_Headers(){} // RVA: 0x7FFAF2E55500
        public void get_Method(){} // RVA: 0x7FFAF2E2B370
        public void set_Method(){} // RVA: 0x7FFAF95EE990
        public void set_PreAuthenticate(){} // RVA: 0x7FFAF79AF5C0
        public void get_Proxy(){} // RVA: 0x7FFAF2E55590
        public void set_Proxy(){} // RVA: 0x7FFAF2E555A0
        public void get_Timeout(){} // RVA: 0x7FFAF4826560
        public void set_Timeout(){} // RVA: 0x7FFAF95EEAA0
        public void get_RequestUri(){} // RVA: 0x7FFAF34B85E0
        public void BeginGetRequestStream(){} // RVA: 0x7FFAF95EEB30
        public void BeginGetResponse(){} // RVA: 0x7FFAF95EEF40
        public void CanGetRequestStream(){} // RVA: 0x7FFAF95EF280
        public void EndGetRequestStream(){} // RVA: 0x7FFAF95EF2F0
        public void EndGetResponse(){} // RVA: 0x7FFAF95EF530
        public void GetResponse(){} // RVA: 0x7FFAF95EF770
        public void GetRequestStreamCallback(){} // RVA: 0x7FFAF95EF970
        public void GetResponseCallback(){} // RVA: 0x7FFAF95EFC70
        public void UnblockReader(){} // RVA: 0x7FFAF95F0110
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFAF95F0260
        public void Abort(){} // RVA: 0x7FFAF95F0290
        public void .cctor(){} // RVA: 0x7FFAF95F0520
    }

    public class FileWebRequestCreator : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Create(){} // RVA: 0x7FFAF95F06B0
    }

    public class FileWebResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95F1310 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF95D8CC0
        public void GetObjectData(){} // RVA: 0x7FFAF95F16D0
        public void get_Headers(){} // RVA: 0x7FFAF95F1C00
        public void get_ResponseUri(){} // RVA: 0x7FFAF95F1C20
        public void CheckDisposed(){} // RVA: 0x7FFAF95F1C40
        public void Close(){} // RVA: 0x7FFAF95F1CD0
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7FFAF95F1D20
        public void GetResponseStream(){} // RVA: 0x7FFAF95F1E80
    }

    public class FileWebStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95F0810 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF95F0920
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7FFAF95F09B0
        public void Read(){} // RVA: 0x7FFAF95F0A10
        public void Write(){} // RVA: 0x7FFAF95F0AA0
        public void BeginRead(){} // RVA: 0x7FFAF95F0B30
        public void EndRead(){} // RVA: 0x7FFAF95F0BE0
        public void BeginWrite(){} // RVA: 0x7FFAF95F0C20
        public void EndWrite(){} // RVA: 0x7FFAF95F0CD0
        public void CheckError(){} // RVA: 0x7FFAF95F0D10
    }

    public class FixedSizeReadStream
    {
        // ── Methods ──
        public void get_ContentLength(){} // RVA: 0x7FFAF2E0A740
        public void .ctor(){} // RVA: 0x7FFAF9600E10
        public void ProcessReadAsync(){} // RVA: 0x7FFAF9600E40
    }

    public class FtpControlStream
    {
        // ── Methods ──
        public void get_Credentials(){} // RVA: 0x7FFAF97831A0
        public void set_Credentials(){} // RVA: 0x7FFAF9783260
        public void .ctor(){} // RVA: 0x7FFAF9783360
        public void AbortConnect(){} // RVA: 0x7FFAF9783440
        public void AcceptCallback(){} // RVA: 0x7FFAF9783470
        public void ConnectCallback(){} // RVA: 0x7FFAF9783790
        public void SSLHandshakeCallback(){} // RVA: 0x7FFAF97838A0
        public void QueueOrCreateFtpDataStream(){} // RVA: 0x7FFAF97839D0
        public void ClearState(){} // RVA: 0x7FFAF9783E10
        public void PipelineCallback(){} // RVA: 0x7FFAF9784060
        public void BuildCommandsList(){} // RVA: 0x7FFAF9784D70
        public void QueueOrCreateDataConection(){} // RVA: 0x7FFAF97866B0
        public void GetPathInfo(){} // RVA: 0x7FFAF9786F00
        public void FormatAddress(){} // RVA: 0x7FFAF9787290
        public void FormatAddressV6(){} // RVA: 0x7FFAF9787490
        public void get_ContentLength(){} // RVA: 0x7FFAF2EE5460
        public void get_LastModified(){} // RVA: 0x7FFAF2EAA100
        public void get_ResponseUri(){} // RVA: 0x7FFAF32A7DB0
        public void get_BannerMessage(){} // RVA: 0x7FFAF9787670
        public void get_WelcomeMessage(){} // RVA: 0x7FFAF97876A0
        public void get_ExitMessage(){} // RVA: 0x7FFAF97876D0
        public void GetContentLengthFrom213Response(){} // RVA: 0x7FFAF9787700
        public void GetLastModifiedFrom213Response(){} // RVA: 0x7FFAF97878C0
        public void TryUpdateResponseUri(){} // RVA: 0x7FFAF9787E80
        public void TryUpdateContentLength(){} // RVA: 0x7FFAF9788590
        public void GetLoginDirectory(){} // RVA: 0x7FFAF97886B0
        public void GetPortV4(){} // RVA: 0x7FFAF9788760
        public void GetPortV6(){} // RVA: 0x7FFAF9788A90
        public void CreateFtpListenerSocket(){} // RVA: 0x7FFAF9788CE0
        public void GetPortCommandLine(){} // RVA: 0x7FFAF9788F90
        public void FormatFtpCommand(){} // RVA: 0x7FFAF9789150
        public void CreateFtpDataSocket(){} // RVA: 0x7FFAF9789270
        public void CheckValid(){} // RVA: 0x7FFAF9789300
        public void IsFtpDataStreamWriteable(){} // RVA: 0x7FFAF97896E0
        public void .cctor(){} // RVA: 0x7FFAF9789770
    }

    public class FtpDataStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9789AA0
        public void Dispose(){} // RVA: 0x7FFAF9789C40
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7FFAF9789CD0
        public void CheckError(){} // RVA: 0x7FFAF978A230
        public void get_CanRead(){} // RVA: 0x7FFAF2F57410
        public void get_CanSeek(){} // RVA: 0x7FFAF87D1980
        public void get_CanWrite(){} // RVA: 0x7FFAF2F56500
        public void get_Length(){} // RVA: 0x7FFAF88EB530
        public void get_Position(){} // RVA: 0x7FFAF88EB440
        public void set_Position(){} // RVA: 0x7FFAF87D1A10
        public void Seek(){} // RVA: 0x7FFAF978A280
        public void Read(){} // RVA: 0x7FFAF978A320
        public void Write(){} // RVA: 0x7FFAF978A3F0
        public void AsyncReadCallback(){} // RVA: 0x7FFAF978A490
        public void BeginRead(){} // RVA: 0x7FFAF978A630
        public void EndRead(){} // RVA: 0x7FFAF978A7C0
        public void BeginWrite(){} // RVA: 0x7FFAF978A9A0
        public void EndWrite(){} // RVA: 0x7FFAF978AA60
        public void Flush(){} // RVA: 0x7FFAF88EB5F0
        public void SetLength(){} // RVA: 0x7FFAF95CC470
        public void get_CanTimeout(){} // RVA: 0x7FFAF95CC100
        public void get_ReadTimeout(){} // RVA: 0x7FFAF95CC130
        public void set_ReadTimeout(){} // RVA: 0x7FFAF87D1A70
        public void get_WriteTimeout(){} // RVA: 0x7FFAF95CC160
        public void set_WriteTimeout(){} // RVA: 0x7FFAF87D1BD0
        public void SetSocketTimeoutOption(){} // RVA: 0x7FFAF95CC4A0
    }

    public class FtpMethodInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF978AAD0
        public void HasFlag(){} // RVA: 0x7FFAF978ABA0
        public void get_IsCommandOnly(){} // RVA: 0x7FFAF978ABB0
        public void get_IsUpload(){} // RVA: 0x7FFAF978ABC0
        public void get_IsDownload(){} // RVA: 0x7FFAF93AD930
        public void get_ShouldParseForResponseUri(){} // RVA: 0x7FFAF978ABD0
        public void GetMethodInfo(){} // RVA: 0x7FFAF978ABE0
        public void .cctor(){} // RVA: 0x7FFAF978AE30
    }

    public class FtpWebRequest
    {
        // ── Methods ──
        public void get_MethodInfo(){} // RVA: 0x7FFAF2E2E0E0
        public void get_Method(){} // RVA: 0x7FFAF978B5D0
        public void set_Method(){} // RVA: 0x7FFAF978B5F0
        public void get_RenameTo(){} // RVA: 0x7FFAF2E55500
        public void get_Credentials(){} // RVA: 0x7FFAF2E0A740
        public void set_Credentials(){} // RVA: 0x7FFAF978B7D0
        public void get_RequestUri(){} // RVA: 0x7FFAF2E08730
        public void get_Timeout(){} // RVA: 0x7FFAF3B95CF0
        public void set_Timeout(){} // RVA: 0x7FFAF978B950
        public void get_RemainingTimeout(){} // RVA: 0x7FFAF43D9080
        public void get_ReadWriteTimeout(){} // RVA: 0x7FFAF61E9380
        public void get_ContentOffset(){} // RVA: 0x7FFAF2F12D00
        public void get_ContentLength(){} // RVA: 0x7FFAF2F77C50
        public void set_ContentLength(){} // RVA: 0x7FFAF855F010
        public void get_Proxy(){} // RVA: 0x7FFAF2FC9240
        public void set_Proxy(){} // RVA: 0x7FFAF978BA80
        public void set_ConnectionGroupName(){} // RVA: 0x7FFAF978BAF0
        public void get_Aborted(){} // RVA: 0x7FFAF47D3080
        public void .ctor(){} // RVA: 0x7FFAF978BBB0
        public void GetResponse(){} // RVA: 0x7FFAF978C1B0
        public void BeginGetResponse(){} // RVA: 0x7FFAF978CB10
        public void EndGetResponse(){} // RVA: 0x7FFAF978D300
        public void BeginGetRequestStream(){} // RVA: 0x7FFAF978D650
        public void EndGetRequestStream(){} // RVA: 0x7FFAF978DC20
        public void SubmitRequest(){} // RVA: 0x7FFAF978DFF0
        public void TranslateConnectException(){} // RVA: 0x7FFAF978E5B0
        public void CreateConnectionAsync(){} // RVA: 0x7FFAF978E6C0
        public void CreateConnection(){} // RVA: 0x7FFAF978E890
        public void TimedSubmitRequestHelper(){} // RVA: 0x7FFAF978E9C0
        public void TimerCallback(){} // RVA: 0x7FFAF978EFC0
        public void get_TimerQueue(){} // RVA: 0x7FFAF978F0D0
        public void AttemptedRecovery(){} // RVA: 0x7FFAF978F190
        public void SetException(){} // RVA: 0x7FFAF978F510
        public void CheckError(){} // RVA: 0x7FFAF978F930
        public void RequestCallback(){} // RVA: 0x7FFAF978F960
        public void SyncRequestCallback(){} // RVA: 0x7FFAF978F980
        public void AsyncRequestCallback(){} // RVA: 0x7FFAF978FDE0
        public void FinishRequestStage(){} // RVA: 0x7FFAF9790AF0
        public void Abort(){} // RVA: 0x7FFAF97913E0
        public void set_CachePolicy(){} // RVA: 0x7FFAF97918F0
        public void get_UseBinary(){} // RVA: 0x7FFAF4692CF0
        public void get_UsePassive(){} // RVA: 0x7FFAF3DFA670
        public void get_ClientCertificates(){} // RVA: 0x7FFAF9791960
        public void get_EnableSsl(){} // RVA: 0x7FFAF2DAE4C0
        public void get_Headers(){} // RVA: 0x7FFAF9791B00
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFAF9791BC0
        public void set_PreAuthenticate(){} // RVA: 0x7FFAF9791BF0
        public void get_InUse(){} // RVA: 0x7FFAF9791C20
        public void EnsureFtpWebResponse(){} // RVA: 0x7FFAF9791C40
        public void DataStreamClosed(){} // RVA: 0x7FFAF97923E0
        public void .cctor(){} // RVA: 0x7FFAF9792490
    }

    public class FtpWebRequestCreator : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Create(){} // RVA: 0x7FFAF95CB5C0
    }

    public class FtpWebResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95CB620
        public void UpdateStatus(){} // RVA: 0x7FFAF95CB920
        public void GetResponseStream(){} // RVA: 0x7FFAF95CB9D0
        public void SetResponseStream(){} // RVA: 0x7FFAF95CBAC0
        public void Close(){} // RVA: 0x7FFAF95CBB60
        public void get_Headers(){} // RVA: 0x7FFAF95CBC60
        public void get_ResponseUri(){} // RVA: 0x7FFAF30E74D0
        public void get_StatusCode(){} // RVA: 0x7FFAF3A8C9F0
    }

}