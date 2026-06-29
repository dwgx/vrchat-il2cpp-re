// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.WebSockets
// Classes: 8
// Methods: 119

namespace ThirdParty.DotNet.System.Net.WebSockets
{
    public class ClientWebSocket : WebSocket
    {
        public object _options;
        public object _innerWebSocket;
        public object _state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7625670
        public void get_Options(){} // RVA: 0xB5DBF0
        public void get_CloseStatus(){} // RVA: 0x7625AD0
        public void get_CloseStatusDescription(){} // RVA: 0x7625B60
        public void get_State(){} // RVA: 0x7625BF0
        public void ConnectAsync(){} // RVA: 0x7625CB0
        public void ConnectAsyncCore(){} // RVA: 0x7625FD0
        public void SendAsync(){} // RVA: 0x7626260
        public void ReceiveAsync(){} // RVA: 0x76262F0
        public void CloseAsync(){} // RVA: 0x7626360
        public void CloseOutputAsync(){} // RVA: 0x76263E0
        public void Abort(){} // RVA: 0x7626460
        public void Dispose(){} // RVA: 0x76264F0
        public void ThrowIfNotConnected(){} // RVA: 0x7626590
    }

    public class ClientWebSocketOptions : Object
    {
        public object _isReadOnly;
        public object _requestedSubProtocols;
        public object _requestHeaders;
        public object _keepAliveInterval;
        public object _proxy;
        public object _clientCertificates;
        public object _cookies;
        public object _receiveBufferSize;
        public object _sendBufferSize;
        public object _buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7626D40
        public void get_RequestHeaders(){} // RVA: 0xB700F0
        public void get_RequestedSubProtocols(){} // RVA: 0xB465B0
        public void set_Proxy(){} // RVA: 0x7626F20
        public void get_ClientCertificates(){} // RVA: 0x7626FD0
        public void get_Cookies(){} // RVA: 0xBC1B30
        public void AddSubProtocol(){} // RVA: 0x7627080
        public void get_KeepAliveInterval(){} // RVA: 0xB70160
        public void get_ReceiveBufferSize(){} // RVA: 0xBE5890
        public void get_SendBufferSize(){} // RVA: 0x1D46130
        public void get_Buffer(){} // RVA: 0x4CD0AB0
        public void SetToReadOnly(){} // RVA: 0xF482F0
        public void ThrowIfReadOnly(){} // RVA: 0x76273D0
    }

    public class ManagedWebSocket : WebSocket
    {
        public object s_random;
        public object s_textEncoding;
        public object s_validSendStates;
        public object s_validReceiveStates;
        public object s_validCloseOutputStates;
        public object s_validCloseStates;
        public object s_cachedCloseTask;
        public object _stream;
        public object _isServer;
        public object _subprotocol;
        public object _keepAliveTimer;
        public object _abortSource;
        public object _receiveBuffer;
        public object _utf8TextState;
        public object _sendFrameAsyncLock;
        public object _state;
        public object _disposed;
        public object _sentCloseFrame;
        public object _receivedCloseFrame;
        public object _closeStatus;
        public object _closeStatusDescription;
        public object _lastReceiveHeader;
        public object _receiveBufferOffset;
        public object _receiveBufferCount;
        public object _receivedMaskOffsetOffset;
        public object _sendBuffer;
        public object _lastSendWasFragment;
        public object _lastReceiveAsync;

        // ── Methods ──
        public void CreateFromConnectedStream(){} // RVA: 0x761A8F0
        public void get_StateUpdateLock(){} // RVA: 0xD33E60
        public void get_ReceiveAsyncLock(){} // RVA: 0xBBF8F0
        public void .ctor(){} // RVA: 0x761A990
        public void Dispose(){} // RVA: 0x761B1C0
        public void DisposeCore(){} // RVA: 0x761B2C0
        public void get_CloseStatus(){} // RVA: 0xBE2C60
        public void get_CloseStatusDescription(){} // RVA: 0xBBFF90
        public void get_State(){} // RVA: 0x12BB630
        public void SendAsync(){} // RVA: 0x761B340
        public void SendPrivateAsync(){} // RVA: 0x761B730
        public void ReceiveAsync(){} // RVA: 0x761BA70
        public void CloseAsync(){} // RVA: 0x761BE40
        public void CloseOutputAsync(){} // RVA: 0x761BF40
        public void Abort(){} // RVA: 0x761C040
        public void SendFrameAsync(){} // RVA: 0x761C0D0
        public void SendFrameLockAcquiredNonCancelableAsync(){} // RVA: 0x761C260
        public void WaitForWriteTaskAsync(){} // RVA: 0x761C740
        public void SendFrameFallbackAsync(){} // RVA: 0x761C960
        public void WriteFrameToSendBuffer(){} // RVA: 0x761CBF0
        public void SendKeepAliveFrameAsync(){} // RVA: 0x761D010
        public void WriteHeader(){} // RVA: 0x761D350
        public void WriteRandomMask(){} // RVA: 0x761D540
        public void ReceiveAsyncPrivate(){} // RVA: 0xA94080
        public void HandleReceivedCloseAsync(){} // RVA: 0x761D5E0
        public void WaitForServerToCloseConnectionAsync(){} // RVA: 0x761D820
        public void HandleReceivedPingPongAsync(){} // RVA: 0x761DA40
        public void IsValidCloseStatus(){} // RVA: 0x761DC80
        public void CloseWithReceiveErrorAndThrowAsync(){} // RVA: 0x761DCC0
        public void TryParseMessageHeaderFromReceiveBuffer(){} // RVA: 0x761DF10
        public void CloseAsyncPrivate(){} // RVA: 0x761E200
        public void SendCloseFrameAsync(){} // RVA: 0x761E490
        public void ConsumeFromBuffer(){} // RVA: 0x761E720
        public void EnsureBufferContainsAsync(){} // RVA: 0x761E730
        public void ThrowIfEOFUnexpected(){} // RVA: 0x761E970
        public void AllocateSendBuffer(){} // RVA: 0x761EA10
        public void ReleaseSendBuffer(){} // RVA: 0x761EB00
        public void CombineMaskBytes(){} // RVA: 0x761EC00
        public void ApplyMask(){} // RVA: 0x761EDF0
        public void ThrowIfOperationInProgress(){} // RVA: 0x761EEE0
        public void ThrowOperationInProgress(){} // RVA: 0x761EF20
        public void CreateOperationCanceledException(){} // RVA: 0x761EF90
        public void TryValidateUtf8(){} // RVA: 0x761F080
        public void ValidateAndReceiveAsync(){} // RVA: 0x761F240
        public void .cctor(){} // RVA: 0x761F480
    }

    public class WebSocket : Object
    {
        // ── Methods ──
        public void get_CloseStatus(){} // RVA: 0x87C0A0
        public void get_CloseStatusDescription(){} // RVA: 0x87C0A0
        public void get_State(){} // RVA: 0x87C130
        public void Abort(){} // RVA: 0x894290
        public void CloseAsync(){} // RVA: 0x88C6F0
        public void CloseOutputAsync(){} // RVA: 0x88C6F0
        public void Dispose(){} // RVA: 0x894290
        public void ReceiveAsync(){} // RVA: 0x881FC0
        public void SendAsync(){} // RVA: 0x88C0B0
        public void get_DefaultKeepAliveInterval(){} // RVA: 0x762D540
        public void CreateClientWebSocket(){} // RVA: 0x762D5D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class WebSocketException : Win32Exception
    {
        public object _webSocketErrorCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7580C70
        public void GetObjectData(){} // RVA: 0x762DBE0
        public void get_ErrorCode(){} // RVA: 0xF3A950
        public void GetErrorMessage(){} // RVA: 0x762DEE0
        public void SetErrorCodeOnError(){} // RVA: 0x762E090
        public void Succeeded(){} // RVA: 0x762E0A0
    }

    public class WebSocketHandle : Object
    {
        public object t_cachedStringBuilder;
        public object s_defaultHttpEncoding;
        public object _abortSource;
        public object _state;
        public object _webSocket;

        // ── Methods ──
        public void Create(){} // RVA: 0x7627440
        public void IsValid(){} // RVA: 0x1E868F0
        public void get_CloseStatus(){} // RVA: 0x7627520
        public void get_CloseStatusDescription(){} // RVA: 0x7627540
        public void get_State(){} // RVA: 0x7627560
        public void CheckPlatformSupport(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0x7627590
        public void Abort(){} // RVA: 0x76275C0
        public void SendAsync(){} // RVA: 0x7627650
        public void ReceiveAsync(){} // RVA: 0x76276A0
        public void CloseAsync(){} // RVA: 0x76276E0
        public void CloseOutputAsync(){} // RVA: 0x7627710
        public void ConnectAsyncCore(){} // RVA: 0x7627740
        public void ConnectSocketAsync(){} // RVA: 0x7627A00
        public void BuildRequestHeader(){} // RVA: 0x7627C60
        public void CreateSecKeyAndSecWebSocketAccept(){} // RVA: 0x7628720
        public void ParseAndValidateConnectResponseAsync(){} // RVA: 0x7628BC0
        public void ValidateAndTrackHeader(){} // RVA: 0x7628E70
        public void ReadResponseHeaderLineAsync(){} // RVA: 0x76290D0
        public void .ctor(){} // RVA: 0x76292D0
        public void .cctor(){} // RVA: 0x7629380
    }

    public class WebSocketReceiveResult : Object
    {
        public object _count;
        public object _endOfMessage;
        public object _messageType;
        public object _closeStatus;
        public object _closeStatusDescription;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x762E0D0
        public void get_Count(){} // RVA: 0xB8F8F0
        public void get_EndOfMessage(){} // RVA: 0xC9C250
        public void get_MessageType(){} // RVA: 0xE62D00
    }

    public class WebSocketValidate : Object
    {
        // ── Methods ──
        public void ThrowIfInvalidState(){} // RVA: 0x7624DC0
        public void ValidateSubprotocol(){} // RVA: 0x7624F40
        public void ValidateCloseStatus(){} // RVA: 0x7625200
        public void ValidateArraySegment(){} // RVA: 0x7625430
    }

}