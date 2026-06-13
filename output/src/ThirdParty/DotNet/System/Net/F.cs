// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 11
// Methods: 187

namespace ThirdParty.DotNet.System.Net
{
    public class FileWebRequest
    {
        public System.Threading.WaitCallback s_GetRequestStreamCallback;
        public System.Threading.WaitCallback s_GetResponseCallback; // 0x8
        public string m_connectionGroupName; // 0x38
        public long m_contentLength; // 0x40
        public System.Net.ICredentials m_credentials; // 0x48
        public 0x657FC810 m_fileAccess; // 0x50
        public System.Net.WebHeaderCollection m_headers; // 0x58
        public string m_method; // 0x60
        public bool m_preauthenticate; // 0x68
        public System.Net.IWebProxy m_proxy; // 0x70
        public System.Threading.ManualResetEvent m_readerEvent; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B3D7B0 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6B274B0
        public void GetObjectData(){} // RVA: 0x6B3DE60
        public void get_Aborted(){} // RVA: 0x6B3E8F0
        public void set_ConnectionGroupName(){} // RVA: 0x49B830
        public void get_ContentLength(){} // RVA: 0x35A740
        public void set_ContentLength(){} // RVA: 0x6B3E900
        public void get_Credentials(){} // RVA: 0x358730
        public void set_Credentials(){} // RVA: 0x358740
        public void get_Headers(){} // RVA: 0x3A5500
        public void get_Method(){} // RVA: 0x37B370
        public void set_Method(){} // RVA: 0x6B3E990
        public void set_PreAuthenticate(){} // RVA: 0x4EFF5C0
        public void get_Proxy(){} // RVA: 0x3A5590
        public void set_Proxy(){} // RVA: 0x3A55A0
        public void get_Timeout(){} // RVA: 0x1D76560
        public void set_Timeout(){} // RVA: 0x6B3EAA0
        public void get_RequestUri(){} // RVA: 0xA085E0
        public void BeginGetRequestStream(){} // RVA: 0x6B3EB30
        public void BeginGetResponse(){} // RVA: 0x6B3EF40
        public void CanGetRequestStream(){} // RVA: 0x6B3F280
        public void EndGetRequestStream(){} // RVA: 0x6B3F2F0
        public void EndGetResponse(){} // RVA: 0x6B3F530
        public void GetResponse(){} // RVA: 0x6B3F770
        public void GetRequestStreamCallback(){} // RVA: 0x6B3F970
        public void GetResponseCallback(){} // RVA: 0x6B3FC70
        public void UnblockReader(){} // RVA: 0x6B40110
        public void get_UseDefaultCredentials(){} // RVA: 0x6B40260
        public void Abort(){} // RVA: 0x6B40290
        public void .cctor(){} // RVA: 0x6B40520
    }

    public class FileWebRequestCreator : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x6B406B0
    }

    public class FileWebResponse
    {
        public bool m_closed; // 0x20
        public long m_contentLength; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B41310 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6B28CC0
        public void GetObjectData(){} // RVA: 0x6B416D0
        public void get_Headers(){} // RVA: 0x6B41C00
        public void get_ResponseUri(){} // RVA: 0x6B41C20
        public void CheckDisposed(){} // RVA: 0x6B41C40
        public void Close(){} // RVA: 0x6B41CD0
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x6B41D20
        public void GetResponseStream(){} // RVA: 0x6B41E80
    }

    public class FileWebStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B40810 | overloaded x2
        public void Dispose(){} // RVA: 0x6B40920
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x6B409B0
        public void Read(){} // RVA: 0x6B40A10
        public void Write(){} // RVA: 0x6B40AA0
        public void BeginRead(){} // RVA: 0x6B40B30
        public void EndRead(){} // RVA: 0x6B40BE0
        public void BeginWrite(){} // RVA: 0x6B40C20
        public void EndWrite(){} // RVA: 0x6B40CD0
        public void CheckError(){} // RVA: 0x6B40D10
    }

    public class FixedSizeReadStream
    {
        public long <ContentLength>k__BackingField; // 0x40

        // ── Methods ──
        public void get_ContentLength(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x6B50E10
        public void ProcessReadAsync(){} // RVA: 0x6B50E40
    }

    public class FtpControlStream
    {
        public System.Net.Sockets.Socket _dataSocket; // 0x88
        public System.Net.IPEndPoint _passiveEndPoint; // 0x90
        public System.Net.TlsStream _tlsStream; // 0x98
        public System.Text.StringBuilder _bannerMessage; // 0xA0
        public System.Text.StringBuilder _welcomeMessage; // 0xA8
        public System.Text.StringBuilder _exitMessage; // 0xB0
        public System.WeakReference _credentials; // 0xB8

        // ── Methods ──
        public void get_Credentials(){} // RVA: 0x6CD31A0
        public void set_Credentials(){} // RVA: 0x6CD3260
        public void .ctor(){} // RVA: 0x6CD3360
        public void AbortConnect(){} // RVA: 0x6CD3440
        public void AcceptCallback(){} // RVA: 0x6CD3470
        public void ConnectCallback(){} // RVA: 0x6CD3790
        public void SSLHandshakeCallback(){} // RVA: 0x6CD38A0
        public void QueueOrCreateFtpDataStream(){} // RVA: 0x6CD39D0
        public void ClearState(){} // RVA: 0x6CD3E10
        public void PipelineCallback(){} // RVA: 0x6CD4060
        public void BuildCommandsList(){} // RVA: 0x6CD4D70
        public void QueueOrCreateDataConection(){} // RVA: 0x6CD66B0
        public void GetPathInfo(){} // RVA: 0x6CD6F00
        public void FormatAddress(){} // RVA: 0x6CD7290
        public void FormatAddressV6(){} // RVA: 0x6CD7490
        public void get_ContentLength(){} // RVA: 0x435460
        public void get_LastModified(){} // RVA: 0x3FA100
        public void get_ResponseUri(){} // RVA: 0x7F7DB0
        public void get_BannerMessage(){} // RVA: 0x6CD7670
        public void get_WelcomeMessage(){} // RVA: 0x6CD76A0
        public void get_ExitMessage(){} // RVA: 0x6CD76D0
        public void GetContentLengthFrom213Response(){} // RVA: 0x6CD7700
        public void GetLastModifiedFrom213Response(){} // RVA: 0x6CD78C0
        public void TryUpdateResponseUri(){} // RVA: 0x6CD7E80
        public void TryUpdateContentLength(){} // RVA: 0x6CD8590
        public void GetLoginDirectory(){} // RVA: 0x6CD86B0
        public void GetPortV4(){} // RVA: 0x6CD8760
        public void GetPortV6(){} // RVA: 0x6CD8A90
        public void CreateFtpListenerSocket(){} // RVA: 0x6CD8CE0
        public void GetPortCommandLine(){} // RVA: 0x6CD8F90
        public void FormatFtpCommand(){} // RVA: 0x6CD9150
        public void CreateFtpDataSocket(){} // RVA: 0x6CD9270
        public void CheckValid(){} // RVA: 0x6CD9300
        public void IsFtpDataStreamWriteable(){} // RVA: 0x6CD96E0
        public void .cctor(){} // RVA: 0x6CD9770
    }

    public class FtpDataStream
    {
        public System.Net.FtpWebRequest _request; // 0x28
        public System.Net.Sockets.NetworkStream _networkStream; // 0x30
        public bool _writeable; // 0x38
        public bool _readable; // 0x39
        public bool _isFullyRead; // 0x3A
        public bool _closing; // 0x3B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CD9AA0
        public void Dispose(){} // RVA: 0x6CD9C40
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x6CD9CD0
        public void CheckError(){} // RVA: 0x6CDA230
        public void get_CanRead(){} // RVA: 0x4A7410
        public void get_CanSeek(){} // RVA: 0x5D21980
        public void get_CanWrite(){} // RVA: 0x4A6500
        public void get_Length(){} // RVA: 0x5E3B530
        public void get_Position(){} // RVA: 0x5E3B440
        public void set_Position(){} // RVA: 0x5D21A10
        public void Seek(){} // RVA: 0x6CDA280
        public void Read(){} // RVA: 0x6CDA320
        public void Write(){} // RVA: 0x6CDA3F0
        public void AsyncReadCallback(){} // RVA: 0x6CDA490
        public void BeginRead(){} // RVA: 0x6CDA630
        public void EndRead(){} // RVA: 0x6CDA7C0
        public void BeginWrite(){} // RVA: 0x6CDA9A0
        public void EndWrite(){} // RVA: 0x6CDAA60
        public void Flush(){} // RVA: 0x5E3B5F0
        public void SetLength(){} // RVA: 0x6B1C470
        public void get_CanTimeout(){} // RVA: 0x6B1C100
        public void get_ReadTimeout(){} // RVA: 0x6B1C130
        public void set_ReadTimeout(){} // RVA: 0x5D21A70
        public void get_WriteTimeout(){} // RVA: 0x6B1C160
        public void set_WriteTimeout(){} // RVA: 0x5D21BD0
        public void SetSocketTimeoutOption(){} // RVA: 0x6B1C4A0
    }

    public class FtpMethodInfo
    {
        public string Method; // 0x10
        public 0x65855310 Operation; // 0x18
        public 0x65855368 Flags; // 0x1C
        public string HttpCommand; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CDAAD0
        public void HasFlag(){} // RVA: 0x6CDABA0
        public void get_IsCommandOnly(){} // RVA: 0x6CDABB0
        public void get_IsUpload(){} // RVA: 0x6CDABC0
        public void get_IsDownload(){} // RVA: 0x68FD930
        public void get_ShouldParseForResponseUri(){} // RVA: 0x6CDABD0
        public void GetMethodInfo(){} // RVA: 0x6CDABE0
        public void .cctor(){} // RVA: 0x6CDAE30
    }

    public class FtpWebRequest
    {
        public object _syncObject; // 0x38
        public System.Net.ICredentials _authInfo; // 0x40
        public System.Uri _uri; // 0x48
        public System.Net.FtpMethodInfo _methodInfo; // 0x50
        public string _renameTo; // 0x58
        public bool _getRequestStreamStarted; // 0x60
        public bool _getResponseStarted; // 0x61
        public System.DateTime _startTime; // 0x68
        public int _timeout; // 0x70
        public int _remainingTimeout; // 0x74
        public long _contentLength; // 0x78
        public long _contentOffset; // 0x80
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates; // 0x88
        public bool _passive; // 0x90
        public bool _binary; // 0x91
        public string _connectionGroupName; // 0x98
        public bool _async; // 0xA0
        public bool _aborted; // 0xA1
        public bool _timedOut; // 0xA2
        public System.Exception _exception; // 0xA8
        public Queue _timerQueue; // 0xB0
        public Callback _timerCallback; // 0xB8
        public bool _enableSsl; // 0xC0

        // ── Methods ──
        public void get_MethodInfo(){} // RVA: 0x37E0E0
        public void get_Method(){} // RVA: 0x6CDB5D0
        public void set_Method(){} // RVA: 0x6CDB5F0
        public void get_RenameTo(){} // RVA: 0x3A5500
        public void get_Credentials(){} // RVA: 0x35A740
        public void set_Credentials(){} // RVA: 0x6CDB7D0
        public void get_RequestUri(){} // RVA: 0x358730
        public void get_Timeout(){} // RVA: 0x10E5CF0
        public void set_Timeout(){} // RVA: 0x6CDB950
        public void get_RemainingTimeout(){} // RVA: 0x1929080
        public void get_ReadWriteTimeout(){} // RVA: 0x3739380
        public void get_ContentOffset(){} // RVA: 0x462D00
        public void get_ContentLength(){} // RVA: 0x4C7C50
        public void set_ContentLength(){} // RVA: 0x5AAF010
        public void get_Proxy(){} // RVA: 0x519240
        public void set_Proxy(){} // RVA: 0x6CDBA80
        public void set_ConnectionGroupName(){} // RVA: 0x6CDBAF0
        public void get_Aborted(){} // RVA: 0x1D23080
        public void .ctor(){} // RVA: 0x6CDBBB0
        public void GetResponse(){} // RVA: 0x6CDC1B0
        public void BeginGetResponse(){} // RVA: 0x6CDCB10
        public void EndGetResponse(){} // RVA: 0x6CDD300
        public void BeginGetRequestStream(){} // RVA: 0x6CDD650
        public void EndGetRequestStream(){} // RVA: 0x6CDDC20
        public void SubmitRequest(){} // RVA: 0x6CDDFF0
        public void TranslateConnectException(){} // RVA: 0x6CDE5B0
        public void CreateConnectionAsync(){} // RVA: 0x6CDE6C0
        public void CreateConnection(){} // RVA: 0x6CDE890
        public void TimedSubmitRequestHelper(){} // RVA: 0x6CDE9C0
        public void TimerCallback(){} // RVA: 0x6CDEFC0
        public void get_TimerQueue(){} // RVA: 0x6CDF0D0
        public void AttemptedRecovery(){} // RVA: 0x6CDF190
        public void SetException(){} // RVA: 0x6CDF510
        public void CheckError(){} // RVA: 0x6CDF930
        public void RequestCallback(){} // RVA: 0x6CDF960
        public void SyncRequestCallback(){} // RVA: 0x6CDF980
        public void AsyncRequestCallback(){} // RVA: 0x6CDFDE0
        public void FinishRequestStage(){} // RVA: 0x6CE0AF0
        public void Abort(){} // RVA: 0x6CE13E0
        public void set_CachePolicy(){} // RVA: 0x6CE18F0
        public void get_UseBinary(){} // RVA: 0x1BE2CF0
        public void get_UsePassive(){} // RVA: 0x134A670
        public void get_ClientCertificates(){} // RVA: 0x6CE1960
        public void get_EnableSsl(){} // RVA: 0x2FE4C0
        public void get_Headers(){} // RVA: 0x6CE1B00
        public void get_UseDefaultCredentials(){} // RVA: 0x6CE1BC0
        public void set_PreAuthenticate(){} // RVA: 0x6CE1BF0
        public void get_InUse(){} // RVA: 0x6CE1C20
        public void EnsureFtpWebResponse(){} // RVA: 0x6CE1C40
        public void DataStreamClosed(){} // RVA: 0x6CE23E0
        public void .cctor(){} // RVA: 0x6CE2490
    }

    public class FtpWebRequestCreator : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x6B1B5C0
    }

    public class FtpWebResponse
    {
        public System.IO.Stream _responseStream; // 0x20
        public long _contentLength; // 0x28
        public System.Uri _responseUri; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B1B620
        public void UpdateStatus(){} // RVA: 0x6B1B920
        public void GetResponseStream(){} // RVA: 0x6B1B9D0
        public void SetResponseStream(){} // RVA: 0x6B1BAC0
        public void Close(){} // RVA: 0x6B1BB60
        public void get_Headers(){} // RVA: 0x6B1BC60
        public void get_ResponseUri(){} // RVA: 0x6374D0
        public void get_StatusCode(){} // RVA: 0xFDC9F0
    }

}