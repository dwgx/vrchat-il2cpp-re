// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.WebSockets
// Classes: 9
// Methods: 142

namespace ThirdParty.DotNet.System.Net.WebSockets
{
    public class ClientWebSocket : WebSocket
    {
        public System.Net.WebSockets.ClientWebSocketOptions _options; // 0x10
        public System.Net.WebSockets.WebSocketHandle _innerWebSocket; // 0x18
        public int _state; // 0x20
        public object field_3; // 0x601

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87703BA0
        public void get_Options(){} // RVA: 0x7FFE81116380
        public void get_CloseStatus(){} // RVA: 0x7FFE87703E50
        public void get_CloseStatusDescription(){} // RVA: 0x7FFE87703EE0
        public void get_State(){} // RVA: 0x7FFE87703F70
        public void ConnectAsync(){} // RVA: 0x7FFE87704030
        public void ConnectAsyncCore(){} // RVA: 0x7FFE87704350
        public void SendAsync(){} // RVA: 0x7FFE87704670 | overloaded x2
        public void ReceiveAsync(){} // RVA: 0x7FFE87704790 | overloaded x2
        public void CloseAsync(){} // RVA: 0x7FFE87704830
        public void CloseOutputAsync(){} // RVA: 0x7FFE877048B0
        public void Abort(){} // RVA: 0x7FFE87704930
        public void Dispose(){} // RVA: 0x7FFE877049C0
        public void ThrowIfNotConnected(){} // RVA: 0x7FFE87704A60
    }

    public class ClientWebSocketOptions : Object
    {
        public bool _isReadOnly; // 0x10
        public System.Collections.Generic.List`1<string> _requestedSubProtocols; // 0x18
        public System.Net.WebHeaderCollection _requestHeaders; // 0x20
        public System.TimeSpan _keepAliveInterval; // 0x28
        public System.Net.IWebProxy _proxy; // 0x30
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates; // 0x38
        public System.Net.CookieContainer _cookies; // 0x40
        public int _receiveBufferSize; // 0x48
        public int _sendBufferSize; // 0x4C
        public System.Nullable`1<System.ArraySegment`1<byte>> _buffer; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87705210
        public void get_RequestHeaders(){} // RVA: 0x7FFE811290C0
        public void get_RequestedSubProtocols(){} // RVA: 0x7FFE810FE7C0
        public void set_Proxy(){} // RVA: 0x7FFE877053F0
        public void get_ClientCertificates(){} // RVA: 0x7FFE877054A0
        public void set_RemoteCertificateValidationCallback(){} // RVA: 0x7FFE87705550
        public void get_Cookies(){} // RVA: 0x7FFE81178740
        public void AddSubProtocol(){} // RVA: 0x7FFE87705600
        public void get_KeepAliveInterval(){} // RVA: 0x7FFE81129130
        public void get_ReceiveBufferSize(){} // RVA: 0x7FFE8119C0C0
        public void get_SendBufferSize(){} // RVA: 0x7FFE821E0A40
        public void get_Buffer(){} // RVA: 0x7FFE84E4C290
        public void SetToReadOnly(){} // RVA: 0x7FFE814B8390
        public void ThrowIfReadOnly(){} // RVA: 0x7FFE87705940
    }

    public class ManagedWebSocket : WebSocket
    {
        public System.Security.Cryptography.RandomNumberGenerator s_random;
        public System.Text.UTF8Encoding s_textEncoding; // 0x8
        public 0x6653B0DC[] s_validSendStates; // 0x10
        public 0x6653B0DC[] s_validReceiveStates; // 0x18
        public 0x6653B0DC[] s_validCloseOutputStates; // 0x20

        // ── Methods ──
        public void CreateFromConnectedStream(){} // RVA: 0x7FFE876F8AA0
        public void get_StateUpdateLock(){} // RVA: 0x7FFE8144E200
        public void get_ReceiveAsyncLock(){} // RVA: 0x7FFE81176730
        public void .ctor(){} // RVA: 0x7FFE876F8B40
        public void Dispose(){} // RVA: 0x7FFE876F9360
        public void DisposeCore(){} // RVA: 0x7FFE876F94A0
        public void get_CloseStatus(){} // RVA: 0x7FFE81199370
        public void get_CloseStatusDescription(){} // RVA: 0x7FFE81176D50
        public void get_State(){} // RVA: 0x7FFE8175AC90
        public void SendAsync(){} // RVA: 0x7FFE876F9520
        public void SendPrivateAsync(){} // RVA: 0x7FFE876F9900
        public void ReceiveAsync(){} // RVA: 0x7FFE876F9C40
        public void CloseAsync(){} // RVA: 0x7FFE876FA040
        public void CloseOutputAsync(){} // RVA: 0x7FFE876FA140
        public void Abort(){} // RVA: 0x7FFE876FA240
        public void SendFrameAsync(){} // RVA: 0x7FFE876FA2D0
        public void SendFrameLockAcquiredNonCancelableAsync(){} // RVA: 0x7FFE876FA460
        public void WaitForWriteTaskAsync(){} // RVA: 0x7FFE876FA950
        public void SendFrameFallbackAsync(){} // RVA: 0x7FFE876FAB70
        public void WriteFrameToSendBuffer(){} // RVA: 0x7FFE876FAE00
        public void SendKeepAliveFrameAsync(){} // RVA: 0x7FFE876FB220
        public void WriteHeader(){} // RVA: 0x7FFE876FB560
        public void WriteRandomMask(){} // RVA: 0x7FFE876FB750
        public void ReceiveAsyncPrivate(){} // RVA: 0x7FFE810A1420
        public void HandleReceivedCloseAsync(){} // RVA: 0x7FFE876FB7F0
        public void WaitForServerToCloseConnectionAsync(){} // RVA: 0x7FFE876FBA30
        public void HandleReceivedPingPongAsync(){} // RVA: 0x7FFE876FBC50
        public void IsValidCloseStatus(){} // RVA: 0x7FFE876FBE90
        public void CloseWithReceiveErrorAndThrowAsync(){} // RVA: 0x7FFE876FBED0
        public void TryParseMessageHeaderFromReceiveBuffer(){} // RVA: 0x7FFE876FC120
        public void CloseAsyncPrivate(){} // RVA: 0x7FFE876FC410
        public void SendCloseFrameAsync(){} // RVA: 0x7FFE876FC6A0
        public void ConsumeFromBuffer(){} // RVA: 0x7FFE876FC930
        public void EnsureBufferContainsAsync(){} // RVA: 0x7FFE876FC940
        public void ThrowIfEOFUnexpected(){} // RVA: 0x7FFE876FCB80
        public void AllocateSendBuffer(){} // RVA: 0x7FFE876FCC20
        public void ReleaseSendBuffer(){} // RVA: 0x7FFE876FCD10
        public void CombineMaskBytes(){} // RVA: 0x7FFE876FCE10
        public void ApplyMask(){} // RVA: 0x7FFE876FD000 | overloaded x2
        public void ThrowIfOperationInProgress(){} // RVA: 0x7FFE876FD0F0
        public void ThrowOperationInProgress(){} // RVA: 0x7FFE876FD130
        public void CreateOperationCanceledException(){} // RVA: 0x7FFE876FD1A0
        public void TryValidateUtf8(){} // RVA: 0x7FFE876FD280
        public void ValidateAndReceiveAsync(){} // RVA: 0x7FFE876FD450
        public void .cctor(){} // RVA: 0x7FFE876FD690
    }

    public class ValueWebSocketReceiveResult : ValueType
    {
        public uint _countAndEndOfMessage; // 0x10
        public 0x6653B02C _messageType; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8770BA80
        public void get_EndOfMessage(){} // RVA: 0x7FFE869D8370
        public void get_MessageType(){} // RVA: 0x7FFE826F42A0
        public void ThrowCountOutOfRange(){} // RVA: 0x7FFE8770BAC0
        public void ThrowMessageTypeOutOfRange(){} // RVA: 0x7FFE8770BB10
    }

    public class WebSocket : Object
    {
        // ── Methods ──
        public void get_CloseStatus(){} // RVA: 0x7FFE80E2E2E0
        public void get_CloseStatusDescription(){} // RVA: 0x7FFE80E2E2E0
        public void get_State(){} // RVA: 0x7FFE80E2EDB0
        public void Abort(){} // RVA: 0x7FFE80E45FE0
        public void CloseAsync(){}
        public void CloseOutputAsync(){}
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void ReceiveAsync(){} // RVA: 0x7FFE8770BB60 | overloaded x2
        public void SendAsync(){} // RVA: 0x7FFE8770BE10 | overloaded x2
        public void SendWithArrayPoolAsync(){} // RVA: 0x7FFE8770BF60
        public void get_DefaultKeepAliveInterval(){} // RVA: 0x7FFE8770C210
        public void CreateClientWebSocket(){} // RVA: 0x7FFE8770C2A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class WebSocketException : Win32Exception
    {
        public 0x6653AF7C _webSocketErrorCode; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8765BC90 | overloaded x9
        public void GetObjectData(){} // RVA: 0x7FFE8770DA60
        public void get_ErrorCode(){} // RVA: 0x7FFE814AA220
        public void GetErrorMessage(){} // RVA: 0x7FFE8770DD70
        public void SetErrorCodeOnError(){} // RVA: 0x7FFE8770DF20
        public void Succeeded(){} // RVA: 0x7FFE8770DF30
    }

    public class WebSocketHandle : Object
    {
        public System.Text.StringBuilder t_cachedStringBuilder; // 0xFFFF
        public System.Text.Encoding s_defaultHttpEncoding;
        public System.Threading.CancellationTokenSource _abortSource; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE877059B0
        public void IsValid(){} // RVA: 0x7FFE82323B00
        public void get_CloseStatus(){} // RVA: 0x7FFE87705A90
        public void get_CloseStatusDescription(){} // RVA: 0x7FFE87705AB0
        public void get_State(){} // RVA: 0x7FFE87705AD0
        public void CheckPlatformSupport(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE87705B00
        public void Abort(){} // RVA: 0x7FFE87705B30
        public void SendAsync(){} // RVA: 0x7FFE87705C10 | overloaded x2
        public void ReceiveAsync(){} // RVA: 0x7FFE87705CC0 | overloaded x2
        public void CloseAsync(){} // RVA: 0x7FFE87705D20
        public void CloseOutputAsync(){} // RVA: 0x7FFE87705D50
        public void ConnectAsyncCore(){} // RVA: 0x7FFE87705D80
        public void ConnectSocketAsync(){} // RVA: 0x7FFE87706040
        public void BuildRequestHeader(){} // RVA: 0x7FFE877062A0
        public void CreateSecKeyAndSecWebSocketAccept(){} // RVA: 0x7FFE87706D90
        public void ParseAndValidateConnectResponseAsync(){} // RVA: 0x7FFE87707220
        public void ValidateAndTrackHeader(){} // RVA: 0x7FFE877074B0
        public void ReadResponseHeaderLineAsync(){} // RVA: 0x7FFE87707710
        public void .ctor(){} // RVA: 0x7FFE87707910
        public void .cctor(){} // RVA: 0x7FFE877079C0
    }

    public class WebSocketReceiveResult : Object
    {
        public int _count; // 0x10
        public bool _endOfMessage; // 0x14
        public 0x6653B02C _messageType; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8770DF60 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE811485C0
        public void get_EndOfMessage(){} // RVA: 0x7FFE8124ABD0
        public void get_MessageType(){} // RVA: 0x7FFE813DB630
    }

    public class WebSocketValidate : Object
    {
        // ── Methods ──
        public void ThrowIfInvalidState(){} // RVA: 0x7FFE877032C0
        public void ValidateSubprotocol(){} // RVA: 0x7FFE87703460
        public void ValidateCloseStatus(){} // RVA: 0x7FFE87703720
        public void ValidateArraySegment(){} // RVA: 0x7FFE87703960
    }

}