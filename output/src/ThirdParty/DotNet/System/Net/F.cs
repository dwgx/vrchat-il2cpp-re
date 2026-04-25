// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 11
// Methods: 187

namespace ThirdParty.DotNet.System.Net
{
    public class FileWebRequest : WebRequest
    {
        public System.Threading.WaitCallback Aborted;
        public System.Threading.WaitCallback ConnectionGroupName; // 0x8
        public string ContentLength; // 0x38
        public long Credentials; // 0x40
        public System.Net.ICredentials Headers; // 0x48
        public 0x6B0E1890 Method; // 0x50
        public System.Net.WebHeaderCollection PreAuthenticate; // 0x58
        public string Proxy; // 0x60
        public bool Timeout; // 0x68
        public System.Net.IWebProxy RequestUri; // 0x70
        public System.Threading.ManualResetEvent UseDefaultCredentials; // 0x78
        public bool m_readPending; // 0x80
        public System.Net.WebResponse m_response; // 0x88
        public System.IO.Stream m_stream; // 0x90
        public bool m_syncHint; // 0x98
        public int m_timeout; // 0x9C
        public System.Uri m_uri; // 0xA0
        public bool m_writePending; // 0xA8
        public bool m_writing; // 0xA9
        public System.Net.LazyAsyncResult m_WriteAResult; // 0xB0
        public System.Net.LazyAsyncResult m_ReadAResult; // 0xB8
        public int m_Aborted; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92D4330 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC92BE030
        public void GetObjectData(){} // RVA: 0x7FFAC92D49E0
        public void get_Aborted(){} // RVA: 0x7FFAC92D5470
        public void set_ConnectionGroupName(){} // RVA: 0x7FFAC31D0C20
        public void get_ContentLength(){} // RVA: 0x7FFAC2F9E740
        public void set_ContentLength(){} // RVA: 0x7FFAC92D5480
        public void get_Credentials(){} // RVA: 0x7FFAC2F9C730
        public void set_Credentials(){} // RVA: 0x7FFAC2F9C740
        public void get_Headers(){} // RVA: 0x7FFAC2FE9500
        public void get_Method(){} // RVA: 0x7FFAC2FBF370
        public void set_Method(){} // RVA: 0x7FFAC92D5510
        public void set_PreAuthenticate(){} // RVA: 0x7FFAC8CDF6C0
        public void get_Proxy(){} // RVA: 0x7FFAC2FE9590
        public void set_Proxy(){} // RVA: 0x7FFAC2FE95A0
        public void get_Timeout(){} // RVA: 0x7FFAC489E520
        public void set_Timeout(){} // RVA: 0x7FFAC92D5620
        public void get_RequestUri(){} // RVA: 0x7FFAC3543900
        public void BeginGetRequestStream(){} // RVA: 0x7FFAC92D56B0
        public void BeginGetResponse(){} // RVA: 0x7FFAC92D5AC0
        public void CanGetRequestStream(){} // RVA: 0x7FFAC92D5E00
        public void EndGetRequestStream(){} // RVA: 0x7FFAC92D5E70
        public void EndGetResponse(){} // RVA: 0x7FFAC92D60B0
        public void GetResponse(){} // RVA: 0x7FFAC92D62F0
        public void GetRequestStreamCallback(){} // RVA: 0x7FFAC92D64F0
        public void GetResponseCallback(){} // RVA: 0x7FFAC92D67F0
        public void UnblockReader(){} // RVA: 0x7FFAC92D6C90
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFAC92D6DE0
        public void Abort(){} // RVA: 0x7FFAC92D6E10
        public void .cctor(){} // RVA: 0x7FFAC92D70A0
    }

    public class FileWebRequestCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC92D7230
    }

    public class FileWebResponse : WebResponse
    {
        public bool Headers; // 0x20
        public long ResponseUri; // 0x28
        public 0x6B0E1890 m_fileAccess; // 0x30
        public System.Net.WebHeaderCollection m_headers; // 0x38
        public System.IO.Stream m_stream; // 0x40
        public System.Uri m_uri; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92D7E90 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC92BF840
        public void GetObjectData(){} // RVA: 0x7FFAC92D8250
        public void get_Headers(){} // RVA: 0x7FFAC92D8780
        public void get_ResponseUri(){} // RVA: 0x7FFAC92D87A0
        public void CheckDisposed(){} // RVA: 0x7FFAC92D87C0
        public void Close(){} // RVA: 0x7FFAC92D8850
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7FFAC92D88A0
        public void GetResponseStream(){} // RVA: 0x7FFAC92D8A00
    }

    public class FileWebStream : FileStream
    {
        public System.Net.FileWebRequest m_request; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92D7390 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC92D74A0
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7FFAC92D7530
        public void Read(){} // RVA: 0x7FFAC92D7590
        public void Write(){} // RVA: 0x7FFAC92D7620
        public void BeginRead(){} // RVA: 0x7FFAC92D76B0
        public void EndRead(){} // RVA: 0x7FFAC92D7760
        public void BeginWrite(){} // RVA: 0x7FFAC92D77A0
        public void EndWrite(){} // RVA: 0x7FFAC92D7850
        public void CheckError(){} // RVA: 0x7FFAC92D7890
    }

    public class FixedSizeReadStream : WebReadStream
    {
        public long ContentLength; // 0x40
        public long position; // 0x48

        // ── Methods ──
        public void get_ContentLength(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC92E7990
        public void ProcessReadAsync(){} // RVA: 0x7FFAC92E79C0
    }

    public class FtpControlStream : CommandStream
    {
        public System.Net.Sockets.Socket Credentials; // 0x88
        public System.Net.IPEndPoint ContentLength; // 0x90
        public System.Net.TlsStream LastModified; // 0x98
        public System.Text.StringBuilder ResponseUri; // 0xA0
        public System.Text.StringBuilder BannerMessage; // 0xA8
        public System.Text.StringBuilder WelcomeMessage; // 0xB0
        public System.WeakReference ExitMessage; // 0xB8
        public string _currentTypeSetting; // 0xC0
        public long _contentLength; // 0xC8
        public System.DateTime _lastModified; // 0xD0
        public bool _dataHandshakeStarted; // 0xD8
        public string _loginDirectory; // 0xE0
        public string _establishedServerDirectory; // 0xE8
        public string _requestedServerDirectory; // 0xF0
        public System.Uri _responseUri; // 0xF8
        public 0x6B13A1D8 _loginState; // 0x100
        public 0x6B13A9C0 StatusCode; // 0x104
        public string StatusLine; // 0x108
        public System.AsyncCallback s_acceptCallbackDelegate;
        public System.AsyncCallback s_connectCallbackDelegate; // 0x8
        public System.AsyncCallback s_SSLHandshakeCallback; // 0x10

        // ── Methods ──
        public void get_Credentials(){} // RVA: 0x7FFAC946B900
        public void set_Credentials(){} // RVA: 0x7FFAC946B9C0
        public void .ctor(){} // RVA: 0x7FFAC946BAC0
        public void AbortConnect(){} // RVA: 0x7FFAC946BBA0
        public void AcceptCallback(){} // RVA: 0x7FFAC946BBD0
        public void ConnectCallback(){} // RVA: 0x7FFAC946BEF0
        public void SSLHandshakeCallback(){} // RVA: 0x7FFAC946C000
        public void QueueOrCreateFtpDataStream(){} // RVA: 0x7FFAC946C130
        public void ClearState(){} // RVA: 0x7FFAC946C570
        public void PipelineCallback(){} // RVA: 0x7FFAC946C7C0
        public void BuildCommandsList(){} // RVA: 0x7FFAC946D4D0
        public void QueueOrCreateDataConection(){} // RVA: 0x7FFAC946EE10
        public void GetPathInfo(){} // RVA: 0x7FFAC946F660
        public void FormatAddress(){} // RVA: 0x7FFAC946F9F0
        public void FormatAddressV6(){} // RVA: 0x7FFAC946FBF0
        public void get_ContentLength(){} // RVA: 0x7FFAC3079460
        public void get_LastModified(){} // RVA: 0x7FFAC303E100
        public void get_ResponseUri(){} // RVA: 0x7FFAC3331F50
        public void get_BannerMessage(){} // RVA: 0x7FFAC946FDD0
        public void get_WelcomeMessage(){} // RVA: 0x7FFAC946FE00
        public void get_ExitMessage(){} // RVA: 0x7FFAC946FE30
        public void GetContentLengthFrom213Response(){} // RVA: 0x7FFAC946FE60
        public void GetLastModifiedFrom213Response(){} // RVA: 0x7FFAC9470020
        public void TryUpdateResponseUri(){} // RVA: 0x7FFAC94705E0
        public void TryUpdateContentLength(){} // RVA: 0x7FFAC9470CF0
        public void GetLoginDirectory(){} // RVA: 0x7FFAC9470E10
        public void GetPortV4(){} // RVA: 0x7FFAC9470EC0
        public void GetPortV6(){} // RVA: 0x7FFAC94711F0
        public void CreateFtpListenerSocket(){} // RVA: 0x7FFAC9471440
        public void GetPortCommandLine(){} // RVA: 0x7FFAC94716F0
        public void FormatFtpCommand(){} // RVA: 0x7FFAC94718B0
        public void CreateFtpDataSocket(){} // RVA: 0x7FFAC94719D0
        public void CheckValid(){} // RVA: 0x7FFAC9471A60
        public void IsFtpDataStreamWriteable(){} // RVA: 0x7FFAC9471E40
        public void .cctor(){} // RVA: 0x7FFAC9471ED0
    }

    public class FtpDataStream : Stream
    {
        public System.Net.FtpWebRequest CanRead; // 0x28
        public System.Net.Sockets.NetworkStream CanSeek; // 0x30
        public bool CanWrite; // 0x38
        public bool Length; // 0x39
        public bool Position; // 0x3A
        public bool CanTimeout; // 0x3B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9472200
        public void Dispose(){} // RVA: 0x7FFAC94723A0
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7FFAC9472430
        public void CheckError(){} // RVA: 0x7FFAC9472990
        public void get_CanRead(){} // RVA: 0x7FFAC33BCE50
        public void get_CanSeek(){} // RVA: 0x7FFAC84B9050
        public void get_CanWrite(){} // RVA: 0x7FFAC31D95D0
        public void get_Length(){} // RVA: 0x7FFAC85D2BA0
        public void get_Position(){} // RVA: 0x7FFAC85D2AB0
        public void set_Position(){} // RVA: 0x7FFAC84B90E0
        public void Seek(){} // RVA: 0x7FFAC94729E0
        public void Read(){} // RVA: 0x7FFAC9472A80
        public void Write(){} // RVA: 0x7FFAC9472B50
        public void AsyncReadCallback(){} // RVA: 0x7FFAC9472BF0
        public void BeginRead(){} // RVA: 0x7FFAC9472D90
        public void EndRead(){} // RVA: 0x7FFAC9472F20
        public void BeginWrite(){} // RVA: 0x7FFAC9473100
        public void EndWrite(){} // RVA: 0x7FFAC94731C0
        public void Flush(){} // RVA: 0x7FFAC85D2C60
        public void SetLength(){} // RVA: 0x7FFAC92B2FF0
        public void get_CanTimeout(){} // RVA: 0x7FFAC92B2C80
        public void get_ReadTimeout(){} // RVA: 0x7FFAC92B2CB0
        public void set_ReadTimeout(){} // RVA: 0x7FFAC84B9140
        public void get_WriteTimeout(){} // RVA: 0x7FFAC92B2CE0
        public void set_WriteTimeout(){} // RVA: 0x7FFAC84B92A0
        public void SetSocketTimeoutOption(){} // RVA: 0x7FFAC92B3020
    }

    public class FtpMethodInfo : Object
    {
        public string IsCommandOnly; // 0x10
        public 0x6B13A390 IsUpload; // 0x18
        public 0x6B13A3E8 IsDownload; // 0x1C
        public string ShouldParseForResponseUri; // 0x20
        public System.Net.FtpMethodInfo[] s_knownMethodInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9473230
        public void HasFlag(){} // RVA: 0x7FFAC9473300
        public void get_IsCommandOnly(){} // RVA: 0x7FFAC9473310
        public void get_IsUpload(){} // RVA: 0x7FFAC9473320
        public void get_IsDownload(){} // RVA: 0x7FFAC9094450
        public void get_ShouldParseForResponseUri(){} // RVA: 0x7FFAC9473330
        public void GetMethodInfo(){} // RVA: 0x7FFAC9473340
        public void .cctor(){} // RVA: 0x7FFAC9473590
    }

    public class FtpWebRequest : WebRequest
    {
        public object MethodInfo; // 0x38
        public System.Net.ICredentials Method; // 0x40
        public System.Uri RenameTo; // 0x48
        public System.Net.FtpMethodInfo Credentials; // 0x50
        public string RequestUri; // 0x58
        public bool Timeout; // 0x60
        public bool RemainingTimeout; // 0x61
        public System.DateTime ReadWriteTimeout; // 0x68
        public int ContentOffset; // 0x70
        public int ContentLength; // 0x74
        public long Proxy; // 0x78
        public long ConnectionGroupName; // 0x80
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection Aborted; // 0x88
        public bool TimerQueue; // 0x90
        public bool CachePolicy; // 0x91
        public string UseBinary; // 0x98
        public bool UsePassive; // 0xA0
        public bool ClientCertificates; // 0xA1
        public bool EnableSsl; // 0xA2
        public System.Exception Headers; // 0xA8
        public Queue UseDefaultCredentials; // 0xB0
        public Callback PreAuthenticate; // 0xB8
        public bool InUse; // 0xC0
        public System.Net.FtpControlStream _connection; // 0xC8
        public System.IO.Stream _stream; // 0xD0
        public 0x6B13A498 _requestStage; // 0xD8
        public bool _onceFailed; // 0xDC
        public System.Net.WebHeaderCollection _ftpRequestHeaders; // 0xE0
        public System.Net.FtpWebResponse _ftpWebResponse; // 0xE8
        public int _readWriteTimeout; // 0xF0
        public System.Net.ContextAwareResult _writeAsyncResult; // 0xF8
        public System.Net.LazyAsyncResult _readAsyncResult; // 0x100
        public System.Net.LazyAsyncResult _requestCompleteAsyncResult; // 0x108
        public System.Net.NetworkCredential s_defaultFtpNetworkCredential;
        public Queue s_DefaultTimerQueue; // 0x8

        // ── Methods ──
        public void get_MethodInfo(){} // RVA: 0x7FFAC2FC20E0
        public void get_Method(){} // RVA: 0x7FFAC9473D30
        public void set_Method(){} // RVA: 0x7FFAC9473D50
        public void get_RenameTo(){} // RVA: 0x7FFAC2FE9500
        public void get_Credentials(){} // RVA: 0x7FFAC2F9E740
        public void set_Credentials(){} // RVA: 0x7FFAC9473F30
        public void get_RequestUri(){} // RVA: 0x7FFAC2F9C730
        public void get_Timeout(){} // RVA: 0x7FFAC3B99E80
        public void set_Timeout(){} // RVA: 0x7FFAC94740B0
        public void get_RemainingTimeout(){} // RVA: 0x7FFAC43D9E20
        public void get_ReadWriteTimeout(){} // RVA: 0x7FFAC60855D0
        public void get_ContentOffset(){} // RVA: 0x7FFAC32EF410
        public void get_ContentLength(){} // RVA: 0x7FFAC30E5600
        public void set_ContentLength(){} // RVA: 0x7FFAC8246500
        public void get_Proxy(){} // RVA: 0x7FFAC34F9180
        public void set_Proxy(){} // RVA: 0x7FFAC94741E0
        public void set_ConnectionGroupName(){} // RVA: 0x7FFAC9474250
        public void get_Aborted(){} // RVA: 0x7FFAC4848B60
        public void .ctor(){} // RVA: 0x7FFAC9474310
        public void GetResponse(){} // RVA: 0x7FFAC9474910
        public void BeginGetResponse(){} // RVA: 0x7FFAC9475270
        public void EndGetResponse(){} // RVA: 0x7FFAC9475A60
        public void BeginGetRequestStream(){} // RVA: 0x7FFAC9475DB0
        public void EndGetRequestStream(){} // RVA: 0x7FFAC9476380
        public void SubmitRequest(){} // RVA: 0x7FFAC9476750
        public void TranslateConnectException(){} // RVA: 0x7FFAC9476D10
        public void CreateConnectionAsync(){} // RVA: 0x7FFAC9476E20
        public void CreateConnection(){} // RVA: 0x7FFAC9476FF0
        public void TimedSubmitRequestHelper(){} // RVA: 0x7FFAC9477120
        public void TimerCallback(){} // RVA: 0x7FFAC9477720
        public void get_TimerQueue(){} // RVA: 0x7FFAC9477830
        public void AttemptedRecovery(){} // RVA: 0x7FFAC94778F0
        public void SetException(){} // RVA: 0x7FFAC9477C70
        public void CheckError(){} // RVA: 0x7FFAC9478090
        public void RequestCallback(){} // RVA: 0x7FFAC94780C0
        public void SyncRequestCallback(){} // RVA: 0x7FFAC94780E0
        public void AsyncRequestCallback(){} // RVA: 0x7FFAC9478540
        public void FinishRequestStage(){} // RVA: 0x7FFAC9479250
        public void Abort(){} // RVA: 0x7FFAC9479B40
        public void set_CachePolicy(){} // RVA: 0x7FFAC947A050
        public void get_UseBinary(){} // RVA: 0x7FFAC4862190
        public void get_UsePassive(){} // RVA: 0x7FFAC3E0D160
        public void get_ClientCertificates(){} // RVA: 0x7FFAC947A0C0
        public void get_EnableSsl(){} // RVA: 0x7FFAC2F424C0
        public void get_Headers(){} // RVA: 0x7FFAC947A260
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFAC947A320
        public void set_PreAuthenticate(){} // RVA: 0x7FFAC947A350
        public void get_InUse(){} // RVA: 0x7FFAC947A380
        public void EnsureFtpWebResponse(){} // RVA: 0x7FFAC947A3A0
        public void DataStreamClosed(){} // RVA: 0x7FFAC947AB40
        public void .cctor(){} // RVA: 0x7FFAC947ABF0
    }

    public class FtpWebRequestCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC92B2140
    }

    public class FtpWebResponse : WebResponse
    {
        public System.IO.Stream Headers; // 0x20
        public long ResponseUri; // 0x28
        public System.Uri StatusCode; // 0x30
        public 0x6B13A9C0 _statusCode; // 0x38
        public string _statusLine; // 0x40
        public System.Net.WebHeaderCollection _ftpRequestHeaders; // 0x48
        public System.DateTime _lastModified; // 0x50
        public string _bannerMessage; // 0x58
        public string _welcomeMessage; // 0x60
        public string _exitMessage; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92B21A0
        public void UpdateStatus(){} // RVA: 0x7FFAC92B24A0
        public void GetResponseStream(){} // RVA: 0x7FFAC92B2550
        public void SetResponseStream(){} // RVA: 0x7FFAC92B2640
        public void Close(){} // RVA: 0x7FFAC92B26E0
        public void get_Headers(){} // RVA: 0x7FFAC92B27E0
        public void get_ResponseUri(){} // RVA: 0x7FFAC31D95E0
        public void get_StatusCode(){} // RVA: 0x7FFAC358A870
    }

}