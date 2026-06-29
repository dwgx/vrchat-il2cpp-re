// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 11
// Methods: 184

namespace ThirdParty.DotNet.System.Net
{
    public class FileWebRequest : WebRequest
    {
        public object s_GetRequestStreamCallback;
        public object s_GetResponseCallback;
        public object m_connectionGroupName;
        public object m_contentLength;
        public object m_credentials;
        public object m_fileAccess;
        public object m_headers;
        public object m_method;
        public object m_preauthenticate;
        public object m_proxy;
        public object m_readerEvent;
        public object m_readPending;
        public object m_response;
        public object m_stream;
        public object m_syncHint;
        public object m_timeout;
        public object m_uri;
        public object m_writePending;
        public object m_writing;
        public object m_WriteAResult;
        public object m_ReadAResult;
        public object m_Aborted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75A0FD0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x758B8E0
        public void GetObjectData(){} // RVA: 0x75A1620
        public void get_Aborted(){} // RVA: 0x75A2030
        public void set_ConnectionGroupName(){} // RVA: 0xD09D70
        public void get_ContentLength(){} // RVA: 0xBC1B30
        public void set_ContentLength(){} // RVA: 0x75A2040
        public void get_Credentials(){} // RVA: 0xBBF8F0
        public void set_Credentials(){} // RVA: 0xBBF900
        public void get_Headers(){} // RVA: 0xC0FFC0
        public void get_Method(){} // RVA: 0xBE2C60
        public void set_Method(){} // RVA: 0x75A20D0
        public void set_PreAuthenticate(){} // RVA: 0x5A44CB0
        public void get_Proxy(){} // RVA: 0xC10050
        public void set_Proxy(){} // RVA: 0xC10060
        public void get_Timeout(){} // RVA: 0x262A910
        public void set_Timeout(){} // RVA: 0x75A21E0
        public void get_RequestUri(){} // RVA: 0x106A050
        public void BeginGetRequestStream(){} // RVA: 0x75A2270
        public void BeginGetResponse(){} // RVA: 0x75A2640
        public void CanGetRequestStream(){} // RVA: 0x75A2950
        public void EndGetRequestStream(){} // RVA: 0x75A29C0
        public void EndGetResponse(){} // RVA: 0x75A2BF0
        public void GetResponse(){} // RVA: 0x75A2E20
        public void GetRequestStreamCallback(){} // RVA: 0x75A3020
        public void GetResponseCallback(){} // RVA: 0x75A3320
        public void UnblockReader(){} // RVA: 0x75A3790
        public void get_UseDefaultCredentials(){} // RVA: 0x75A38B0
        public void Abort(){} // RVA: 0x75A38E0
        public void .cctor(){} // RVA: 0x75A3B70
    }

    public class FileWebRequestCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x75A3D00
    }

    public class FileWebResponse : WebResponse
    {
        public object m_closed;
        public object m_contentLength;
        public object m_fileAccess;
        public object m_headers;
        public object m_stream;
        public object m_uri;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75A48E0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x758D090
        public void GetObjectData(){} // RVA: 0x75A4C50
        public void get_Headers(){} // RVA: 0x75A5130
        public void get_ResponseUri(){} // RVA: 0x75A5150
        public void CheckDisposed(){} // RVA: 0x75A5170
        public void Close(){} // RVA: 0x75A5200
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x75A5250
        public void GetResponseStream(){} // RVA: 0x75A53B0
    }

    public class FileWebStream : FileStream
    {
        public object m_request;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75A3E60
        public void Dispose(){} // RVA: 0x75A3F70
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x75A4000
        public void Read(){} // RVA: 0x75A4060
        public void Write(){} // RVA: 0x75A40F0
        public void BeginRead(){} // RVA: 0x75A4180
        public void EndRead(){} // RVA: 0x75A4230
        public void BeginWrite(){} // RVA: 0x75A4270
        public void EndWrite(){} // RVA: 0x75A4320
        public void CheckError(){} // RVA: 0x75A4360
    }

    public class FixedSizeReadStream : WebReadStream
    {
        public object _contentLength;
        public object position;

        // ── Methods ──
        public void get_ContentLength(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0x75B3A30
        public void ProcessReadAsync(){} // RVA: 0x75B3A60
    }

    public class FtpControlStream : CommandStream
    {
        public object _dataSocket;
        public object _passiveEndPoint;
        public object _tlsStream;
        public object _bannerMessage;
        public object _welcomeMessage;
        public object _exitMessage;
        public object _credentials;
        public object _currentTypeSetting;
        public object _contentLength;
        public object _lastModified;
        public object _dataHandshakeStarted;
        public object _loginDirectory;
        public object _establishedServerDirectory;
        public object _requestedServerDirectory;
        public object _responseUri;
        public object _loginState;
        public object StatusCode;
        public object StatusLine;
        public object s_acceptCallbackDelegate;
        public object s_connectCallbackDelegate;
        public object s_SSLHandshakeCallback;

        // ── Methods ──
        public void get_Credentials(){} // RVA: 0x7731A40
        public void set_Credentials(){} // RVA: 0x7731B00
        public void .ctor(){} // RVA: 0x7731C00
        public void AbortConnect(){} // RVA: 0x7731CD0
        public void AcceptCallback(){} // RVA: 0x7731D00
        public void ConnectCallback(){} // RVA: 0x7732010
        public void SSLHandshakeCallback(){} // RVA: 0x7732120
        public void QueueOrCreateFtpDataStream(){} // RVA: 0x7732250
        public void ClearState(){} // RVA: 0x7732690
        public void PipelineCallback(){} // RVA: 0x77328E0
        public void BuildCommandsList(){} // RVA: 0x77335C0
        public void QueueOrCreateDataConection(){} // RVA: 0x7734E90
        public void GetPathInfo(){} // RVA: 0x77356D0
        public void FormatAddress(){} // RVA: 0x7735A50
        public void FormatAddressV6(){} // RVA: 0x7735C70
        public void get_ContentLength(){} // RVA: 0xCA4D80
        public void get_LastModified(){} // RVA: 0xC68EB0
        public void get_ResponseUri(){} // RVA: 0x135A7B0
        public void get_BannerMessage(){} // RVA: 0x7735E60
        public void get_WelcomeMessage(){} // RVA: 0x7735E90
        public void get_ExitMessage(){} // RVA: 0x7735EC0
        public void GetContentLengthFrom213Response(){} // RVA: 0x7735EF0
        public void GetLastModifiedFrom213Response(){} // RVA: 0x77360B0
        public void TryUpdateResponseUri(){} // RVA: 0x7736AF0
        public void TryUpdateContentLength(){} // RVA: 0x7737200
        public void GetLoginDirectory(){} // RVA: 0x7737310
        public void GetPortV4(){} // RVA: 0x77373A0
        public void GetPortV6(){} // RVA: 0x77376B0
        public void CreateFtpListenerSocket(){} // RVA: 0x7737900
        public void GetPortCommandLine(){} // RVA: 0x7737BD0
        public void FormatFtpCommand(){} // RVA: 0x7737D90
        public void CreateFtpDataSocket(){} // RVA: 0x7737EB0
        public void CheckValid(){} // RVA: 0x7737F40
        public void IsFtpDataStreamWriteable(){} // RVA: 0x7738310
        public void .cctor(){} // RVA: 0x77383A0
    }

    public class FtpDataStream : Stream
    {
        public object _request;
        public object _networkStream;
        public object _writeable;
        public object _readable;
        public object _isFullyRead;
        public object _closing;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x77386D0
        public void Dispose(){} // RVA: 0x7738870
        public void System.Net.ICloseEx.CloseEx(){} // RVA: 0x7738900
        public void CheckError(){} // RVA: 0x7738E10
        public void get_CanRead(){} // RVA: 0xD15320
        public void get_CanSeek(){} // RVA: 0x679A330
        public void get_CanWrite(){} // RVA: 0xD16660
        public void get_Length(){} // RVA: 0x68B4DD0
        public void get_Position(){} // RVA: 0x68B4CE0
        public void set_Position(){} // RVA: 0x679A3C0
        public void Seek(){} // RVA: 0x7738E60
        public void Read(){} // RVA: 0x7738F00
        public void Write(){} // RVA: 0x7738FD0
        public void AsyncReadCallback(){} // RVA: 0x7739070
        public void BeginRead(){} // RVA: 0x7739200
        public void EndRead(){} // RVA: 0x7739390
        public void BeginWrite(){} // RVA: 0x7739540
        public void EndWrite(){} // RVA: 0x7739600
        public void Flush(){} // RVA: 0x68B4E90
        public void SetLength(){} // RVA: 0x7580760
        public void get_CanTimeout(){} // RVA: 0x75803F0
        public void get_ReadTimeout(){} // RVA: 0x7580420
        public void set_ReadTimeout(){} // RVA: 0x679A420
        public void get_WriteTimeout(){} // RVA: 0x7580450
        public void set_WriteTimeout(){} // RVA: 0x679A580
        public void SetSocketTimeoutOption(){} // RVA: 0x7580790
    }

    public class FtpMethodInfo : Object
    {
        public object Method;
        public object Operation;
        public object Flags;
        public object HttpCommand;
        public object s_knownMethodInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7739670
        public void HasFlag(){} // RVA: 0x7739740
        public void get_IsCommandOnly(){} // RVA: 0x7739750
        public void get_IsUpload(){} // RVA: 0x7739760
        public void get_IsDownload(){} // RVA: 0x7362290
        public void get_ShouldParseForResponseUri(){} // RVA: 0x7739770
        public void GetMethodInfo(){} // RVA: 0x7739780
        public void .cctor(){} // RVA: 0x77399F0
    }

    public class FtpWebRequest : WebRequest
    {
        public object _syncObject;
        public object _authInfo;
        public object _uri;
        public object _methodInfo;
        public object _renameTo;
        public object _getRequestStreamStarted;
        public object _getResponseStarted;
        public object _startTime;
        public object _timeout;
        public object _remainingTimeout;
        public object _contentLength;
        public object _contentOffset;
        public object _clientCertificates;
        public object _passive;
        public object _binary;
        public object _connectionGroupName;
        public object _async;
        public object _aborted;
        public object _timedOut;
        public object _exception;
        public object _timerQueue;
        public object _timerCallback;
        public object _enableSsl;
        public object _connection;
        public object _stream;
        public object _requestStage;
        public object _onceFailed;
        public object _ftpRequestHeaders;
        public object _ftpWebResponse;
        public object _readWriteTimeout;
        public object _writeAsyncResult;
        public object _readAsyncResult;
        public object _requestCompleteAsyncResult;
        public object s_defaultFtpNetworkCredential;
        public object s_DefaultTimerQueue;

        // ── Methods ──
        public void get_MethodInfo(){} // RVA: 0xBE58B0
        public void get_Method(){} // RVA: 0x16D3530
        public void set_Method(){} // RVA: 0x773A190
        public void get_RenameTo(){} // RVA: 0xC0FFC0
        public void get_Credentials(){} // RVA: 0xBC1B30
        public void set_Credentials(){} // RVA: 0x773A370
        public void get_RequestUri(){} // RVA: 0xBBF8F0
        public void get_Timeout(){} // RVA: 0x19C6270
        public void set_Timeout(){} // RVA: 0x773A4F0
        public void get_RemainingTimeout(){} // RVA: 0x21EA4F0
        public void get_ReadWriteTimeout(){} // RVA: 0x255B930
        public void get_ContentOffset(){} // RVA: 0xCD48B0
        public void get_ContentLength(){} // RVA: 0xCD3320
        public void set_ContentLength(){} // RVA: 0x6529A50
        public void get_Proxy(){} // RVA: 0xDAC980
        public void set_Proxy(){} // RVA: 0x773A620
        public void set_ConnectionGroupName(){} // RVA: 0x773A690
        public void get_Aborted(){} // RVA: 0x25D1680
        public void .ctor(){} // RVA: 0x773A750
        public void GetResponse(){} // RVA: 0x773AD30
        public void BeginGetResponse(){} // RVA: 0x773B660
        public void EndGetResponse(){} // RVA: 0x773BE10
        public void BeginGetRequestStream(){} // RVA: 0x773C160
        public void EndGetRequestStream(){} // RVA: 0x773C700
        public void SubmitRequest(){} // RVA: 0x773CAD0
        public void TranslateConnectException(){} // RVA: 0x773D090
        public void CreateConnectionAsync(){} // RVA: 0x773D180
        public void CreateConnection(){} // RVA: 0x773D360
        public void TimedSubmitRequestHelper(){} // RVA: 0x773D490
        public void TimerCallback(){} // RVA: 0x773DA70
        public void get_TimerQueue(){} // RVA: 0x773DB80
        public void AttemptedRecovery(){} // RVA: 0x773DC40
        public void SetException(){} // RVA: 0x773DFA0
        public void CheckError(){} // RVA: 0x773E3C0
        public void RequestCallback(){} // RVA: 0x773E3F0
        public void SyncRequestCallback(){} // RVA: 0x773E410
        public void AsyncRequestCallback(){} // RVA: 0x773E850
        public void FinishRequestStage(){} // RVA: 0x773F4F0
        public void Abort(){} // RVA: 0x773FD90
        public void set_CachePolicy(){} // RVA: 0x7740270
        public void get_UseBinary(){} // RVA: 0x24BB4D0
        public void get_UsePassive(){} // RVA: 0x1C4D9A0
        public void get_ClientCertificates(){} // RVA: 0x77402E0
        public void get_EnableSsl(){} // RVA: 0xB63970
        public void get_Headers(){} // RVA: 0x7740480
        public void get_UseDefaultCredentials(){} // RVA: 0x7740540
        public void set_PreAuthenticate(){} // RVA: 0x7740570
        public void get_InUse(){} // RVA: 0x77405A0
        public void EnsureFtpWebResponse(){} // RVA: 0x77405C0
        public void DataStreamClosed(){} // RVA: 0x7740D40
        public void .cctor(){} // RVA: 0x7740DF0
    }

    public class FtpWebRequestCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x757F900
    }

    public class FtpWebResponse : WebResponse
    {
        public object _responseStream;
        public object _contentLength;
        public object _responseUri;
        public object _statusCode;
        public object _statusLine;
        public object _ftpRequestHeaders;
        public object _lastModified;
        public object _bannerMessage;
        public object _welcomeMessage;
        public object _exitMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x757F960
        public void UpdateStatus(){} // RVA: 0x757FC50
        public void GetResponseStream(){} // RVA: 0x757FD00
        public void SetResponseStream(){} // RVA: 0x757FDF0
        public void Close(){} // RVA: 0x757FE90
        public void get_Headers(){} // RVA: 0x757FF90
        public void get_ResponseUri(){} // RVA: 0xD33E60
        public void get_StatusCode(){} // RVA: 0x18A0130
    }

}