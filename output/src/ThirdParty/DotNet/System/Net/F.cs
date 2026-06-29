// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 11
// Methods: 184

namespace ThirdParty.DotNet.System.Net
{
    public class FileWebRequest : WebRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE92DD30
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE918150
        public void GetObjectData(){} // RVA: 0x7AE92E3F0
        public void get_Aborted(){} // RVA: 0x7AE92EE80
        public void set_ConnectionGroupName(){} // RVA: 0x7A8296DE0
        public void get_ContentLength(){} // RVA: 0x7A8154D80
        public void set_ContentLength(){} // RVA: 0x7AE92EE90
        public void get_Credentials(){} // RVA: 0x7A8152D80
        public void set_Credentials(){} // RVA: 0x7A8152D90
        public void get_Headers(){} // RVA: 0x7A81A0050
        public void get_Method(){} // RVA: 0x7A8175DF0
        public void set_Method(){} // RVA: 0x7AE92EF20
        public void set_PreAuthenticate(){} // RVA: 0x7ACCF17C0
        public void get_Proxy(){} // RVA: 0x7A81A00E0
        public void set_Proxy(){} // RVA: 0x7A81A00F0
        public void get_Timeout(){} // RVA: 0x7A9B79A10
        public void set_Timeout(){} // RVA: 0x7AE92F030
        public void get_RequestUri(){} // RVA: 0x7A87C5850
        public void BeginGetRequestStream(){} // RVA: 0x7AE92F0C0
        public void BeginGetResponse(){} // RVA: 0x7AE92F490
        public void CanGetRequestStream(){} // RVA: 0x7AE92F7A0
        public void EndGetRequestStream(){} // RVA: 0x7AE92F810
        public void EndGetResponse(){} // RVA: 0x7AE92FA40
        public void GetResponse(){} // RVA: 0x7AE92FC70
        public void GetRequestStreamCallback(){} // RVA: 0x7AE92FE70
        public void GetResponseCallback(){} // RVA: 0x7AE930170
        public void UnblockReader(){} // RVA: 0x7AE9305E0
        public void get_UseDefaultCredentials(){} // RVA: 0x7AE930700
        public void Abort(){} // RVA: 0x7AE930730
        public void .cctor(){} // RVA: 0x7AE9309C0
    }

    public class FileWebRequestCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AE930B50
    }

    public class FileWebResponse : WebResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE931730
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE919910
        public void GetObjectData(){} // RVA: 0x7AE931AF0
        public void get_Headers(){} // RVA: 0x7AE932020
        public void get_ResponseUri(){} // RVA: 0x7AE932040
        public void CheckDisposed(){} // RVA: 0x7AE932060
        public void Close(){} // RVA: 0x7AE9320F0
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7AE932140
        public void GetResponseStream(){} // RVA: 0x7AE9322A0
    }

    public class FileWebStream : FileStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE930CB0
        public void Dispose(){} // RVA: 0x7AE930DC0
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7AE930E50
        public void Read(){} // RVA: 0x7AE930EB0
        public void Write(){} // RVA: 0x7AE930F40
        public void BeginRead(){} // RVA: 0x7AE930FD0
        public void EndRead(){} // RVA: 0x7AE931080
        public void BeginWrite(){} // RVA: 0x7AE9310C0
        public void EndWrite(){} // RVA: 0x7AE931170
        public void CheckError(){} // RVA: 0x7AE9311B0
    }

    public class FixedSizeReadStream : WebReadStream
    {
        // ── Methods ──
        public void get_ContentLength(){} // RVA: 0x7A8154D80
        public void .ctor(){} // RVA: 0x7AE9409B0
        public void ProcessReadAsync(){} // RVA: 0x7AE9409E0
    }

    public class FtpControlStream : CommandStream
    {
        // ── Methods ──
        public void get_Credentials(){} // RVA: 0x7AEAC2310
        public void set_Credentials(){} // RVA: 0x7AEAC23D0
        public void .ctor(){} // RVA: 0x7AEAC24D0
        public void AbortConnect(){} // RVA: 0x7AEAC25B0
        public void AcceptCallback(){} // RVA: 0x7AEAC25E0
        public void ConnectCallback(){} // RVA: 0x7AEAC28F0
        public void SSLHandshakeCallback(){} // RVA: 0x7AEAC2A00
        public void QueueOrCreateFtpDataStream(){} // RVA: 0x7AEAC2B30
        public void ClearState(){} // RVA: 0x7AEAC2F70
        public void PipelineCallback(){} // RVA: 0x7AEAC31C0
        public void BuildCommandsList(){} // RVA: 0x7AEAC3EC0
        public void QueueOrCreateDataConection(){} // RVA: 0x7AEAC5840
        public void GetPathInfo(){} // RVA: 0x7AEAC6090
        public void FormatAddress(){} // RVA: 0x7AEAC6430
        public void FormatAddressV6(){} // RVA: 0x7AEAC6650
        public void get_ContentLength(){} // RVA: 0x7A82305B0
        public void get_LastModified(){} // RVA: 0x7A81F50F0
        public void get_ResponseUri(){} // RVA: 0x7A8592710
        public void get_BannerMessage(){} // RVA: 0x7AEAC6840
        public void get_WelcomeMessage(){} // RVA: 0x7AEAC6870
        public void get_ExitMessage(){} // RVA: 0x7AEAC68A0
        public void GetContentLengthFrom213Response(){} // RVA: 0x7AEAC68D0
        public void GetLastModifiedFrom213Response(){} // RVA: 0x7AEAC6A90
        public void TryUpdateResponseUri(){} // RVA: 0x7AEAC7050
        public void TryUpdateContentLength(){} // RVA: 0x7AEAC7760
        public void GetLoginDirectory(){} // RVA: 0x7AEAC7870
        public void GetPortV4(){} // RVA: 0x7AEAC7920
        public void GetPortV6(){} // RVA: 0x7AEAC7C50
        public void CreateFtpListenerSocket(){} // RVA: 0x7AEAC7EA0
        public void GetPortCommandLine(){} // RVA: 0x7AEAC8170
        public void FormatFtpCommand(){} // RVA: 0x7AEAC8330
        public void CreateFtpDataSocket(){} // RVA: 0x7AEAC8450
        public void CheckValid(){} // RVA: 0x7AEAC84E0
        public void IsFtpDataStreamWriteable(){} // RVA: 0x7AEAC88C0
        public void .cctor(){} // RVA: 0x7AEAC8950
    }

    public class FtpDataStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAC8C80
        public void Dispose(){} // RVA: 0x7AEAC8E20
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7AEAC8EB0
        public void CheckError(){} // RVA: 0x7AEAC93C0
        public void get_CanRead(){} // RVA: 0x7A82A3DE0
        public void get_CanSeek(){} // RVA: 0x7ADB0FA20
        public void get_CanWrite(){} // RVA: 0x7A82A20A0
        public void get_Length(){} // RVA: 0x7ADC29F40
        public void get_Position(){} // RVA: 0x7ADC29E50
        public void set_Position(){} // RVA: 0x7ADB0FAB0
        public void Seek(){} // RVA: 0x7AEAC9410
        public void Read(){} // RVA: 0x7AEAC94B0
        public void Write(){} // RVA: 0x7AEAC9580
        public void AsyncReadCallback(){} // RVA: 0x7AEAC9620
        public void BeginRead(){} // RVA: 0x7AEAC97C0
        public void EndRead(){} // RVA: 0x7AEAC9950
        public void BeginWrite(){} // RVA: 0x7AEAC9B10
        public void EndWrite(){} // RVA: 0x7AEAC9BD0
        public void Flush(){} // RVA: 0x7ADC2A000
        public void SetLength(){} // RVA: 0x7AE90CED0
        public void get_CanTimeout(){} // RVA: 0x7AE90CB60
        public void get_ReadTimeout(){} // RVA: 0x7AE90CB90
        public void set_ReadTimeout(){} // RVA: 0x7ADB0FB10
        public void get_WriteTimeout(){} // RVA: 0x7AE90CBC0
        public void set_WriteTimeout(){} // RVA: 0x7ADB0FC70
        public void SetSocketTimeoutOption(){} // RVA: 0x7AE90CF00
    }

    public class FtpMethodInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAC9C40
        public void HasFlag(){} // RVA: 0x7AEAC9D10
        public void get_IsCommandOnly(){} // RVA: 0x7AEAC9D20
        public void get_IsUpload(){} // RVA: 0x7AEAC9D30
        public void get_IsDownload(){} // RVA: 0x7AE6EC410
        public void get_ShouldParseForResponseUri(){} // RVA: 0x7AEAC9D40
        public void GetMethodInfo(){} // RVA: 0x7AEAC9D50
        public void .cctor(){} // RVA: 0x7AEAC9FC0
    }

    public class FtpWebRequest : WebRequest
    {
        // ── Methods ──
        public void get_MethodInfo(){} // RVA: 0x7A8178B90
        public void get_Method(){} // RVA: 0x7AEACA760
        public void set_Method(){} // RVA: 0x7AEACA780
        public void get_RenameTo(){} // RVA: 0x7A81A0050
        public void get_Credentials(){} // RVA: 0x7A8154D80
        public void set_Credentials(){} // RVA: 0x7AEACA960
        public void get_RequestUri(){} // RVA: 0x7A8152D80
        public void get_Timeout(){} // RVA: 0x7A8EA8210
        public void set_Timeout(){} // RVA: 0x7AEACAAE0
        public void get_RemainingTimeout(){} // RVA: 0x7A96E4F70
        public void get_ReadWriteTimeout(){} // RVA: 0x7AB52C0D0
        public void get_ContentOffset(){} // RVA: 0x7A825E100
        public void get_ContentLength(){} // RVA: 0x7A82C2060
        public void set_ContentLength(){} // RVA: 0x7AD89C580
        public void get_Proxy(){} // RVA: 0x7A82D1450
        public void set_Proxy(){} // RVA: 0x7AEACAC10
        public void set_ConnectionGroupName(){} // RVA: 0x7AEACAC80
        public void get_Aborted(){} // RVA: 0x7A9B256A0
        public void .ctor(){} // RVA: 0x7AEACAD40
        public void GetResponse(){} // RVA: 0x7AEACB340
        public void BeginGetResponse(){} // RVA: 0x7AEACBC70
        public void EndGetResponse(){} // RVA: 0x7AEACC420
        public void BeginGetRequestStream(){} // RVA: 0x7AEACC770
        public void EndGetRequestStream(){} // RVA: 0x7AEACCD10
        public void SubmitRequest(){} // RVA: 0x7AEACD0E0
        public void TranslateConnectException(){} // RVA: 0x7AEACD6A0
        public void CreateConnectionAsync(){} // RVA: 0x7AEACD790
        public void CreateConnection(){} // RVA: 0x7AEACD970
        public void TimedSubmitRequestHelper(){} // RVA: 0x7AEACDAA0
        public void TimerCallback(){} // RVA: 0x7AEACE080
        public void get_TimerQueue(){} // RVA: 0x7AEACE190
        public void AttemptedRecovery(){} // RVA: 0x7AEACE250
        public void SetException(){} // RVA: 0x7AEACE5B0
        public void CheckError(){} // RVA: 0x7AEACE9D0
        public void RequestCallback(){} // RVA: 0x7AEACEA00
        public void SyncRequestCallback(){} // RVA: 0x7AEACEA20
        public void AsyncRequestCallback(){} // RVA: 0x7AEACEE70
        public void FinishRequestStage(){} // RVA: 0x7AEACFB20
        public void Abort(){} // RVA: 0x7AEAD03C0
        public void set_CachePolicy(){} // RVA: 0x7AEAD08A0
        public void get_UseBinary(){} // RVA: 0x7A99A0EA0
        public void get_UsePassive(){} // RVA: 0x7A9101D40
        public void get_ClientCertificates(){} // RVA: 0x7AEAD0910
        public void get_EnableSsl(){} // RVA: 0x7A80F86D0
        public void get_Headers(){} // RVA: 0x7AEAD0AB0
        public void get_UseDefaultCredentials(){} // RVA: 0x7AEAD0B70
        public void set_PreAuthenticate(){} // RVA: 0x7AEAD0BA0
        public void get_InUse(){} // RVA: 0x7AEAD0BD0
        public void EnsureFtpWebResponse(){} // RVA: 0x7AEAD0BF0
        public void DataStreamClosed(){} // RVA: 0x7AEAD1370
        public void .cctor(){} // RVA: 0x7AEAD1420
    }

    public class FtpWebRequestCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AE90C060
    }

    public class FtpWebResponse : WebResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE90C0C0
        public void UpdateStatus(){} // RVA: 0x7AE90C3C0
        public void GetResponseStream(){} // RVA: 0x7AE90C470
        public void SetResponseStream(){} // RVA: 0x7AE90C560
        public void Close(){} // RVA: 0x7AE90C600
        public void get_Headers(){} // RVA: 0x7AE90C700
        public void get_ResponseUri(){} // RVA: 0x7A83F69F0
        public void get_StatusCode(){} // RVA: 0x7A8D863F0
    }

}