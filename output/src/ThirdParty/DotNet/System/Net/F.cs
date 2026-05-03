// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 11
// Methods: 187

namespace ThirdParty.DotNet.System.Net
{
    public class FileWebRequest : WebRequest
    {
        public System.Threading.WaitCallback s_GetRequestStreamCallback;
        public System.Threading.WaitCallback s_GetResponseCallback; // 0x8
        public string m_connectionGroupName; // 0x38
        public long m_contentLength; // 0x40
        public System.Net.ICredentials m_credentials; // 0x48
        public 0x664DA7B4 m_fileAccess; // 0x50
        public System.Net.WebHeaderCollection m_headers; // 0x58
        public string m_method; // 0x60
        public bool m_preauthenticate; // 0x68
        public System.Net.IWebProxy m_proxy; // 0x70
        public System.Threading.ManualResetEvent m_readerEvent; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8767CA60 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87666770
        public void GetObjectData(){} // RVA: 0x7FFE8767D110
        public void get_Aborted(){} // RVA: 0x7FFE8767DBA0
        public void set_ConnectionGroupName(){} // RVA: 0x7FFE81437330
        public void get_ContentLength(){} // RVA: 0x7FFE81178740
        public void set_ContentLength(){} // RVA: 0x7FFE8767DBB0
        public void get_Credentials(){} // RVA: 0x7FFE81176730
        public void set_Credentials(){} // RVA: 0x7FFE81176740
        public void get_Headers(){} // RVA: 0x7FFE811C3500
        public void get_Method(){} // RVA: 0x7FFE81199370
        public void set_Method(){} // RVA: 0x7FFE8767DC40
        public void set_PreAuthenticate(){} // RVA: 0x7FFE87087BB0
        public void get_Proxy(){} // RVA: 0x7FFE811C3590
        public void set_Proxy(){} // RVA: 0x7FFE811C35A0
        public void get_Timeout(){} // RVA: 0x7FFE82B06F90
        public void set_Timeout(){} // RVA: 0x7FFE8767DD50
        public void get_RequestUri(){} // RVA: 0x7FFE8179C860
        public void BeginGetRequestStream(){} // RVA: 0x7FFE8767DDE0
        public void BeginGetResponse(){} // RVA: 0x7FFE8767E1F0
        public void CanGetRequestStream(){} // RVA: 0x7FFE8767E530
        public void EndGetRequestStream(){} // RVA: 0x7FFE8767E5A0
        public void EndGetResponse(){} // RVA: 0x7FFE8767E7E0
        public void GetResponse(){} // RVA: 0x7FFE8767EA20
        public void GetRequestStreamCallback(){} // RVA: 0x7FFE8767EC20
        public void GetResponseCallback(){} // RVA: 0x7FFE8767EF20
        public void UnblockReader(){} // RVA: 0x7FFE8767F3C0
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFE8767F510
        public void Abort(){} // RVA: 0x7FFE8767F540
        public void .cctor(){} // RVA: 0x7FFE8767F7D0
    }

    public class FileWebRequestCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE8767F960
    }

    public class FileWebResponse : WebResponse
    {
        public bool m_closed; // 0x20
        public long m_contentLength; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876805C0 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87667F80
        public void GetObjectData(){} // RVA: 0x7FFE87680980
        public void get_Headers(){} // RVA: 0x7FFE87680EB0
        public void get_ResponseUri(){} // RVA: 0x7FFE87680ED0
        public void CheckDisposed(){} // RVA: 0x7FFE87680EF0
        public void Close(){} // RVA: 0x7FFE87680F80
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7FFE87680FD0
        public void GetResponseStream(){} // RVA: 0x7FFE87681130
    }

    public class FileWebStream : FileStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8767FAC0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE8767FBD0
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7FFE8767FC60
        public void Read(){} // RVA: 0x7FFE8767FCC0
        public void Write(){} // RVA: 0x7FFE8767FD50
        public void BeginRead(){} // RVA: 0x7FFE8767FDE0
        public void EndRead(){} // RVA: 0x7FFE8767FE90
        public void BeginWrite(){} // RVA: 0x7FFE8767FED0
        public void EndWrite(){} // RVA: 0x7FFE8767FF80
        public void CheckError(){} // RVA: 0x7FFE8767FFC0
    }

    public class FixedSizeReadStream : WebReadStream
    {
        public long _contentLength; // 0x40

        // ── Methods ──
        public void get_ContentLength(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE876900C0
        public void ProcessReadAsync(){} // RVA: 0x7FFE876900F0
    }

    public class FtpControlStream : CommandStream
    {
        public System.Net.Sockets.Socket _dataSocket; // 0x88
        public System.Net.IPEndPoint _passiveEndPoint; // 0x90
        public System.Net.TlsStream _tlsStream; // 0x98
        public System.Text.StringBuilder _bannerMessage; // 0xA0
        public System.Text.StringBuilder _welcomeMessage; // 0xA8
        public System.Text.StringBuilder _exitMessage; // 0xB0
        public System.WeakReference _credentials; // 0xB8

        // ── Methods ──
        public void get_Credentials(){} // RVA: 0x7FFE87814040
        public void set_Credentials(){} // RVA: 0x7FFE87814100
        public void .ctor(){} // RVA: 0x7FFE87814200
        public void AbortConnect(){} // RVA: 0x7FFE878142E0
        public void AcceptCallback(){} // RVA: 0x7FFE87814310
        public void ConnectCallback(){} // RVA: 0x7FFE87814630
        public void SSLHandshakeCallback(){} // RVA: 0x7FFE87814740
        public void QueueOrCreateFtpDataStream(){} // RVA: 0x7FFE87814870
        public void ClearState(){} // RVA: 0x7FFE87814CB0
        public void PipelineCallback(){} // RVA: 0x7FFE87814F00
        public void BuildCommandsList(){} // RVA: 0x7FFE87815C10
        public void QueueOrCreateDataConection(){} // RVA: 0x7FFE87817550
        public void GetPathInfo(){} // RVA: 0x7FFE87817DA0
        public void FormatAddress(){} // RVA: 0x7FFE87818130
        public void FormatAddressV6(){} // RVA: 0x7FFE87818330
        public void get_ContentLength(){} // RVA: 0x7FFE81253460
        public void get_LastModified(){} // RVA: 0x7FFE81218100
        public void get_ResponseUri(){} // RVA: 0x7FFE8158D5D0
        public void get_BannerMessage(){} // RVA: 0x7FFE87818510
        public void get_WelcomeMessage(){} // RVA: 0x7FFE87818540
        public void get_ExitMessage(){} // RVA: 0x7FFE87818570
        public void GetContentLengthFrom213Response(){} // RVA: 0x7FFE878185A0
        public void GetLastModifiedFrom213Response(){} // RVA: 0x7FFE87818760
        public void TryUpdateResponseUri(){} // RVA: 0x7FFE87818D20
        public void TryUpdateContentLength(){} // RVA: 0x7FFE87819430
        public void GetLoginDirectory(){} // RVA: 0x7FFE87819550
        public void GetPortV4(){} // RVA: 0x7FFE87819600
        public void GetPortV6(){} // RVA: 0x7FFE87819930
        public void CreateFtpListenerSocket(){} // RVA: 0x7FFE87819B80
        public void GetPortCommandLine(){} // RVA: 0x7FFE87819E30
        public void FormatFtpCommand(){} // RVA: 0x7FFE87819FF0
        public void CreateFtpDataSocket(){} // RVA: 0x7FFE8781A110
        public void CheckValid(){} // RVA: 0x7FFE8781A1A0
        public void IsFtpDataStreamWriteable(){} // RVA: 0x7FFE8781A580
        public void .cctor(){} // RVA: 0x7FFE8781A610
    }

    public class FtpDataStream : Stream
    {
        public System.Net.FtpWebRequest _request; // 0x28
        public System.Net.Sockets.NetworkStream _networkStream; // 0x30
        public bool _writeable; // 0x38
        public bool _readable; // 0x39
        public bool _isFullyRead; // 0x3A
        public bool _closing; // 0x3B
        public object field_6; // 0x40C
        public object field_7; // 0x40D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8781A940
        public void Dispose(){} // RVA: 0x7FFE8781AAE0
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7FFE8781AB70
        public void CheckError(){} // RVA: 0x7FFE8781B0D0
        public void get_CanRead(){} // RVA: 0x7FFE812CF7D0
        public void get_CanSeek(){} // RVA: 0x7FFE86862880
        public void get_CanWrite(){} // RVA: 0x7FFE812CF770
        public void get_Length(){} // RVA: 0x7FFE8697C370
        public void get_Position(){} // RVA: 0x7FFE8697C280
        public void set_Position(){} // RVA: 0x7FFE86862910
        public void Seek(){} // RVA: 0x7FFE8781B120
        public void Read(){} // RVA: 0x7FFE8781B1C0
        public void Write(){} // RVA: 0x7FFE8781B290
        public void AsyncReadCallback(){} // RVA: 0x7FFE8781B330
        public void BeginRead(){} // RVA: 0x7FFE8781B4D0
        public void EndRead(){} // RVA: 0x7FFE8781B660
        public void BeginWrite(){} // RVA: 0x7FFE8781B840
        public void EndWrite(){} // RVA: 0x7FFE8781B900
        public void Flush(){} // RVA: 0x7FFE8697C430
        public void SetLength(){} // RVA: 0x7FFE8765B730
        public void get_CanTimeout(){} // RVA: 0x7FFE8765B3C0
        public void get_ReadTimeout(){} // RVA: 0x7FFE8765B3F0
        public void set_ReadTimeout(){} // RVA: 0x7FFE86862970
        public void get_WriteTimeout(){} // RVA: 0x7FFE8765B420
        public void set_WriteTimeout(){} // RVA: 0x7FFE86862AD0
        public void SetSocketTimeoutOption(){} // RVA: 0x7FFE8765B760
    }

    public class FtpMethodInfo : Object
    {
        public string Method; // 0x10
        public 0x665332B4 Operation; // 0x18
        public 0x6653330C Flags; // 0x1C
        public string HttpCommand; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8781B970
        public void HasFlag(){} // RVA: 0x7FFE8781BA40
        public void get_IsCommandOnly(){} // RVA: 0x7FFE8781BA50
        public void get_IsUpload(){} // RVA: 0x7FFE8781BA60
        public void get_IsDownload(){} // RVA: 0x7FFE8743CC00
        public void get_ShouldParseForResponseUri(){} // RVA: 0x7FFE8781BA70
        public void GetMethodInfo(){} // RVA: 0x7FFE8781BA80
        public void .cctor(){} // RVA: 0x7FFE8781BCD0
    }

    public class FtpWebRequest : WebRequest
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
        public void get_MethodInfo(){} // RVA: 0x7FFE8119C0E0
        public void get_Method(){} // RVA: 0x7FFE8781C470
        public void set_Method(){} // RVA: 0x7FFE8781C490
        public void get_RenameTo(){} // RVA: 0x7FFE811C3500
        public void get_Credentials(){} // RVA: 0x7FFE81178740
        public void set_Credentials(){} // RVA: 0x7FFE8781C670
        public void get_RequestUri(){} // RVA: 0x7FFE81176730
        public void get_Timeout(){} // RVA: 0x7FFE81E60180
        public void set_Timeout(){} // RVA: 0x7FFE8781C7F0
        public void get_RemainingTimeout(){} // RVA: 0x7FFE826A9B90
        public void get_ReadWriteTimeout(){} // RVA: 0x7FFE843B5350
        public void get_ContentOffset(){} // RVA: 0x7FFE81280C30
        public void get_ContentLength(){} // RVA: 0x7FFE81463AE0
        public void set_ContentLength(){} // RVA: 0x7FFE865EFE40
        public void get_Proxy(){} // RVA: 0x7FFE813240E0
        public void set_Proxy(){} // RVA: 0x7FFE8781C920
        public void set_ConnectionGroupName(){} // RVA: 0x7FFE8781C990
        public void get_Aborted(){} // RVA: 0x7FFE82AB0F00
        public void .ctor(){} // RVA: 0x7FFE8781CA50
        public void GetResponse(){} // RVA: 0x7FFE8781D050
        public void BeginGetResponse(){} // RVA: 0x7FFE8781D9B0
        public void EndGetResponse(){} // RVA: 0x7FFE8781E1A0
        public void BeginGetRequestStream(){} // RVA: 0x7FFE8781E4F0
        public void EndGetRequestStream(){} // RVA: 0x7FFE8781EAC0
        public void SubmitRequest(){} // RVA: 0x7FFE8781EE90
        public void TranslateConnectException(){} // RVA: 0x7FFE8781F450
        public void CreateConnectionAsync(){} // RVA: 0x7FFE8781F560
        public void CreateConnection(){} // RVA: 0x7FFE8781F730
        public void TimedSubmitRequestHelper(){} // RVA: 0x7FFE8781F860
        public void TimerCallback(){} // RVA: 0x7FFE8781FE60
        public void get_TimerQueue(){} // RVA: 0x7FFE8781FF70
        public void AttemptedRecovery(){} // RVA: 0x7FFE87820030
        public void SetException(){} // RVA: 0x7FFE878203B0
        public void CheckError(){} // RVA: 0x7FFE878207D0
        public void RequestCallback(){} // RVA: 0x7FFE87820800
        public void SyncRequestCallback(){} // RVA: 0x7FFE87820820
        public void AsyncRequestCallback(){} // RVA: 0x7FFE87820C80
        public void FinishRequestStage(){} // RVA: 0x7FFE87821990
        public void Abort(){} // RVA: 0x7FFE87822280
        public void set_CachePolicy(){} // RVA: 0x7FFE87822790
        public void get_UseBinary(){} // RVA: 0x7FFE82975460
        public void get_UsePassive(){} // RVA: 0x7FFE820BF400
        public void get_ClientCertificates(){} // RVA: 0x7FFE87822800
        public void get_EnableSsl(){} // RVA: 0x7FFE8111C4C0
        public void get_Headers(){} // RVA: 0x7FFE878229A0
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFE87822A60
        public void set_PreAuthenticate(){} // RVA: 0x7FFE87822A90
        public void get_InUse(){} // RVA: 0x7FFE87822AC0
        public void EnsureFtpWebResponse(){} // RVA: 0x7FFE87822AE0
        public void DataStreamClosed(){} // RVA: 0x7FFE87823280
        public void .cctor(){} // RVA: 0x7FFE87823330
    }

    public class FtpWebRequestCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE8765A880
    }

    public class FtpWebResponse : WebResponse
    {
        public System.IO.Stream _responseStream; // 0x20
        public long _contentLength; // 0x28
        public System.Uri _responseUri; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8765A8E0
        public void UpdateStatus(){} // RVA: 0x7FFE8765ABE0
        public void GetResponseStream(){} // RVA: 0x7FFE8765AC90
        public void SetResponseStream(){} // RVA: 0x7FFE8765AD80
        public void Close(){} // RVA: 0x7FFE8765AE20
        public void get_Headers(){} // RVA: 0x7FFE8765AF20
        public void get_ResponseUri(){} // RVA: 0x7FFE8144E200
        public void get_StatusCode(){} // RVA: 0x7FFE81D46090
    }

}