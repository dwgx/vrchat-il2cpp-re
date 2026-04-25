// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.WebSockets
// Classes: 9
// Methods: 142

namespace ThirdParty.DotNet.System.Net.WebSockets
{
    public class ClientWebSocket : WebSocket
    {
        public System.Net.WebSockets.ClientWebSocketOptions Options; // 0x10
        public System.Net.WebSockets.WebSocketHandle CloseStatus; // 0x18
        public int CloseStatusDescription; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC935B470
        public void get_Options(){} // RVA: 0x7FFAC2F3C380
        public void get_CloseStatus(){} // RVA: 0x7FFAC935B720
        public void get_CloseStatusDescription(){} // RVA: 0x7FFAC935B7B0
        public void get_State(){} // RVA: 0x7FFAC935B840
        public void ConnectAsync(){} // RVA: 0x7FFAC935B900
        public void ConnectAsyncCore(){} // RVA: 0x7FFAC935BC20
        public void SendAsync(){} // RVA: 0x7FFAC935BF40 | overloaded x2
        public void ReceiveAsync(){} // RVA: 0x7FFAC935C060 | overloaded x2
        public void CloseAsync(){} // RVA: 0x7FFAC935C100
        public void CloseOutputAsync(){} // RVA: 0x7FFAC935C180
        public void Abort(){} // RVA: 0x7FFAC935C200
        public void Dispose(){} // RVA: 0x7FFAC935C290
        public void ThrowIfNotConnected(){} // RVA: 0x7FFAC935C330
    }

    public class ClientWebSocketOptions : Object
    {
        public bool RequestHeaders; // 0x10
        public System.Collections.Generic.List`1<string> RequestedSubProtocols; // 0x18
        public System.Net.WebHeaderCollection Proxy; // 0x20
        public System.TimeSpan ClientCertificates; // 0x28
        public System.Net.IWebProxy RemoteCertificateValidationCallback; // 0x30
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection Cookies; // 0x38
        public System.Net.CookieContainer KeepAliveInterval; // 0x40
        public int ReceiveBufferSize; // 0x48
        public int SendBufferSize; // 0x4C
        public System.Nullable`1<System.ArraySegment`1<byte>> Buffer; // 0x50
        public System.Net.Security.RemoteCertificateValidationCallback _remoteCertificateValidationCallback; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC935CAE0
        public void get_RequestHeaders(){} // RVA: 0x7FFAC2F4F0C0
        public void get_RequestedSubProtocols(){} // RVA: 0x7FFAC2F247C0
        public void set_Proxy(){} // RVA: 0x7FFAC935CCC0
        public void get_ClientCertificates(){} // RVA: 0x7FFAC935CD70
        public void set_RemoteCertificateValidationCallback(){} // RVA: 0x7FFAC935CE20
        public void get_Cookies(){} // RVA: 0x7FFAC2F9E740
        public void AddSubProtocol(){} // RVA: 0x7FFAC935CED0
        public void get_KeepAliveInterval(){} // RVA: 0x7FFAC2F4F130
        public void get_ReceiveBufferSize(){} // RVA: 0x7FFAC2FC20C0
        public void get_SendBufferSize(){} // RVA: 0x7FFAC3F2D3C0
        public void get_Buffer(){} // RVA: 0x7FFAC6ADB050
        public void SetToReadOnly(){} // RVA: 0x7FFAC322C870
        public void ThrowIfReadOnly(){} // RVA: 0x7FFAC935D210
    }

    public class ManagedWebSocket : WebSocket
    {
        public System.Security.Cryptography.RandomNumberGenerator StateUpdateLock;
        public System.Text.UTF8Encoding ReceiveAsyncLock; // 0x8
        public 0x6B1421B8[] CloseStatus; // 0x10
        public 0x6B1421B8[] CloseStatusDescription; // 0x18
        public 0x6B1421B8[] State; // 0x20
        public 0x6B1421B8[] s_validCloseStates; // 0x28
        public System.Threading.Tasks.Task`1<System.Net.WebSockets.WebSocketReceiveResult> s_cachedCloseTask; // 0x30
        public System.IO.Stream _stream; // 0x10
        public bool _isServer; // 0x18
        public string _subprotocol; // 0x20
        public System.Threading.Timer _keepAliveTimer; // 0x28
        public System.Threading.CancellationTokenSource _abortSource; // 0x30
        public System.Memory`1<byte> _receiveBuffer; // 0x38
        public Utf8MessageState _utf8TextState; // 0x48
        public System.Threading.SemaphoreSlim _sendFrameAsyncLock; // 0x50
        public 0x6B1421B8 _state; // 0x58
        public bool _disposed; // 0x5C
        public bool _sentCloseFrame; // 0x5D
        public bool _receivedCloseFrame; // 0x5E
        public System.Nullable`1<0x6B142000> _closeStatus; // 0x60
        public string _closeStatusDescription; // 0x68
        public MessageHeader _lastReceiveHeader; // 0x70
        public int _receiveBufferOffset; // 0x88
        public int _receiveBufferCount; // 0x8C
        public int _receivedMaskOffsetOffset; // 0x90
        public byte[] _sendBuffer; // 0x98
        public bool _lastSendWasFragment; // 0xA0
        public System.Threading.Tasks.Task _lastReceiveAsync; // 0xA8

        // ── Methods ──
        public void CreateFromConnectedStream(){} // RVA: 0x7FFAC9350370
        public void get_StateUpdateLock(){} // RVA: 0x7FFAC31D95E0
        public void get_ReceiveAsyncLock(){} // RVA: 0x7FFAC2F9C730
        public void .ctor(){} // RVA: 0x7FFAC9350410
        public void Dispose(){} // RVA: 0x7FFAC9350C30
        public void DisposeCore(){} // RVA: 0x7FFAC9350D70
        public void get_CloseStatus(){} // RVA: 0x7FFAC2FBF370
        public void get_CloseStatusDescription(){} // RVA: 0x7FFAC2F9CD50
        public void get_State(){} // RVA: 0x7FFAC362EA40
        public void SendAsync(){} // RVA: 0x7FFAC9350DF0
        public void SendPrivateAsync(){} // RVA: 0x7FFAC93511D0
        public void ReceiveAsync(){} // RVA: 0x7FFAC9351510
        public void CloseAsync(){} // RVA: 0x7FFAC9351910
        public void CloseOutputAsync(){} // RVA: 0x7FFAC9351A10
        public void Abort(){} // RVA: 0x7FFAC9351B10
        public void SendFrameAsync(){} // RVA: 0x7FFAC9351BA0
        public void SendFrameLockAcquiredNonCancelableAsync(){} // RVA: 0x7FFAC9351D30
        public void WaitForWriteTaskAsync(){} // RVA: 0x7FFAC9352220
        public void SendFrameFallbackAsync(){} // RVA: 0x7FFAC9352440
        public void WriteFrameToSendBuffer(){} // RVA: 0x7FFAC93526D0
        public void SendKeepAliveFrameAsync(){} // RVA: 0x7FFAC9352AF0
        public void WriteHeader(){} // RVA: 0x7FFAC9352E30
        public void WriteRandomMask(){} // RVA: 0x7FFAC9353020
        public void ReceiveAsyncPrivate(){} // RVA: 0x7FFAC2E8DC40
        public void HandleReceivedCloseAsync(){} // RVA: 0x7FFAC93530C0
        public void WaitForServerToCloseConnectionAsync(){} // RVA: 0x7FFAC9353300
        public void HandleReceivedPingPongAsync(){} // RVA: 0x7FFAC9353520
        public void IsValidCloseStatus(){} // RVA: 0x7FFAC9353760
        public void CloseWithReceiveErrorAndThrowAsync(){} // RVA: 0x7FFAC93537A0
        public void TryParseMessageHeaderFromReceiveBuffer(){} // RVA: 0x7FFAC93539F0
        public void CloseAsyncPrivate(){} // RVA: 0x7FFAC9353CE0
        public void SendCloseFrameAsync(){} // RVA: 0x7FFAC9353F70
        public void ConsumeFromBuffer(){} // RVA: 0x7FFAC9354200
        public void EnsureBufferContainsAsync(){} // RVA: 0x7FFAC9354210
        public void ThrowIfEOFUnexpected(){} // RVA: 0x7FFAC9354450
        public void AllocateSendBuffer(){} // RVA: 0x7FFAC93544F0
        public void ReleaseSendBuffer(){} // RVA: 0x7FFAC93545E0
        public void CombineMaskBytes(){} // RVA: 0x7FFAC93546E0
        public void ApplyMask(){} // RVA: 0x7FFAC93548D0 | overloaded x2
        public void ThrowIfOperationInProgress(){} // RVA: 0x7FFAC93549C0
        public void ThrowOperationInProgress(){} // RVA: 0x7FFAC9354A00
        public void CreateOperationCanceledException(){} // RVA: 0x7FFAC9354A70
        public void TryValidateUtf8(){} // RVA: 0x7FFAC9354B50
        public void ValidateAndReceiveAsync(){} // RVA: 0x7FFAC9354D20
        public void .cctor(){} // RVA: 0x7FFAC9354F60
    }

    public class ValueWebSocketReceiveResult : ValueType
    {
        public uint EndOfMessage; // 0x10
        public 0x6B142108 MessageType; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9363350
        public void get_EndOfMessage(){} // RVA: 0x7FFAC862EBA0
        public void get_MessageType(){} // RVA: 0x7FFAC44202A0
        public void ThrowCountOutOfRange(){} // RVA: 0x7FFAC9363390
        public void ThrowMessageTypeOutOfRange(){} // RVA: 0x7FFAC93633E0
    }

    public class WebSocket : Object
    {
        public object CloseStatus;
        public object CloseStatusDescription;
        public object State;
        public object DefaultKeepAliveInterval;

        // ── Methods ──
        public void get_CloseStatus(){} // RVA: 0x7FFAC2C58E90
        public void get_CloseStatusDescription(){} // RVA: 0x7FFAC2C58E90
        public void get_State(){} // RVA: 0x7FFAC2C59960
        public void Abort(){} // RVA: 0x7FFAC2C70980
        public void CloseAsync(){}
        public void CloseOutputAsync(){}
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void ReceiveAsync(){} // RVA: 0x7FFAC9363430 | overloaded x2
        public void SendAsync(){} // RVA: 0x7FFAC93636E0 | overloaded x2
        public void SendWithArrayPoolAsync(){} // RVA: 0x7FFAC9363830
        public void get_DefaultKeepAliveInterval(){} // RVA: 0x7FFAC9363AE0
        public void CreateClientWebSocket(){} // RVA: 0x7FFAC9363B70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class WebSocketException : Win32Exception
    {
        public 0x6B142058 ErrorCode; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92B3550 | overloaded x9
        public void GetObjectData(){} // RVA: 0x7FFAC9365330
        public void get_ErrorCode(){} // RVA: 0x7FFAC3220660
        public void GetErrorMessage(){} // RVA: 0x7FFAC9365640
        public void SetErrorCodeOnError(){} // RVA: 0x7FFAC93657F0
        public void Succeeded(){} // RVA: 0x7FFAC9365800
    }

    public class WebSocketHandle : Object
    {
        public System.Text.StringBuilder CloseStatus; // 0xFFFF
        public System.Text.Encoding CloseStatusDescription;
        public System.Threading.CancellationTokenSource State; // 0x10
        public 0x6B1421B8 _state; // 0x18
        public System.Net.WebSockets.WebSocket _webSocket; // 0x20

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC935D280
        public void IsValid(){} // RVA: 0x7FFAC406B370
        public void get_CloseStatus(){} // RVA: 0x7FFAC935D360
        public void get_CloseStatusDescription(){} // RVA: 0x7FFAC935D380
        public void get_State(){} // RVA: 0x7FFAC935D3A0
        public void CheckPlatformSupport(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC935D3D0
        public void Abort(){} // RVA: 0x7FFAC935D400
        public void SendAsync(){} // RVA: 0x7FFAC935D4E0 | overloaded x2
        public void ReceiveAsync(){} // RVA: 0x7FFAC935D590 | overloaded x2
        public void CloseAsync(){} // RVA: 0x7FFAC935D5F0
        public void CloseOutputAsync(){} // RVA: 0x7FFAC935D620
        public void ConnectAsyncCore(){} // RVA: 0x7FFAC935D650
        public void ConnectSocketAsync(){} // RVA: 0x7FFAC935D910
        public void BuildRequestHeader(){} // RVA: 0x7FFAC935DB70
        public void CreateSecKeyAndSecWebSocketAccept(){} // RVA: 0x7FFAC935E660
        public void ParseAndValidateConnectResponseAsync(){} // RVA: 0x7FFAC935EAF0
        public void ValidateAndTrackHeader(){} // RVA: 0x7FFAC935ED80
        public void ReadResponseHeaderLineAsync(){} // RVA: 0x7FFAC935EFE0
        public void .ctor(){} // RVA: 0x7FFAC935F1E0
        public void .cctor(){} // RVA: 0x7FFAC935F290
    }

    public class WebSocketReceiveResult : Object
    {
        public int Count; // 0x10
        public bool EndOfMessage; // 0x14
        public 0x6B142108 MessageType; // 0x18
        public System.Nullable`1<0x6B142000> <CloseStatus>k__BackingField; // 0x1C
        public string <CloseStatusDescription>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9365830 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC2F6E5C0
        public void get_EndOfMessage(){} // RVA: 0x7FFAC3070BD0
        public void get_MessageType(){} // RVA: 0x7FFAC3157800
    }

    public class WebSocketValidate : Object
    {
        // ── Methods ──
        public void ThrowIfInvalidState(){} // RVA: 0x7FFAC935AB90
        public void ValidateSubprotocol(){} // RVA: 0x7FFAC935AD30
        public void ValidateCloseStatus(){} // RVA: 0x7FFAC935AFF0
        public void ValidateArraySegment(){} // RVA: 0x7FFAC935B230
    }

}