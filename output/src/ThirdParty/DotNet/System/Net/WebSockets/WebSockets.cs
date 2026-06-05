// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.WebSockets
// Classes: 8
// Methods: 129

namespace ThirdParty.DotNet.System.Net.WebSockets
{
    public class ClientWebSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96748F0
        public void get_Options(){} // RVA: 0x7FFAF2DA8380
        public void get_CloseStatus(){} // RVA: 0x7FFAF9674BA0
        public void get_CloseStatusDescription(){} // RVA: 0x7FFAF9674C30
        public void get_State(){} // RVA: 0x7FFAF9674CC0
        public void ConnectAsync(){} // RVA: 0x7FFAF9674D80
        public void ConnectAsyncCore(){} // RVA: 0x7FFAF96750A0
        public void SendAsync(){} // RVA: 0x7FFAF9675330
        public void ReceiveAsync(){} // RVA: 0x7FFAF96753C0
        public void CloseAsync(){} // RVA: 0x7FFAF9675430
        public void CloseOutputAsync(){} // RVA: 0x7FFAF96754B0
        public void Abort(){} // RVA: 0x7FFAF9675530
        public void Dispose(){} // RVA: 0x7FFAF96755C0
        public void ThrowIfNotConnected(){} // RVA: 0x7FFAF9675660
    }

    public class ClientWebSocketOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9675E10
        public void get_RequestHeaders(){} // RVA: 0x7FFAF2DBB0C0
        public void get_RequestedSubProtocols(){} // RVA: 0x7FFAF2D907C0
        public void set_Proxy(){} // RVA: 0x7FFAF9675FF0
        public void get_ClientCertificates(){} // RVA: 0x7FFAF96760A0
        public void get_Cookies(){} // RVA: 0x7FFAF2E0A740
        public void AddSubProtocol(){} // RVA: 0x7FFAF9676150
        public void get_KeepAliveInterval(){} // RVA: 0x7FFAF2DBB130
        public void get_ReceiveBufferSize(){} // RVA: 0x7FFAF2E2E0C0
        public void get_SendBufferSize(){} // RVA: 0x7FFAF3F29960
        public void get_Buffer(){} // RVA: 0x7FFAF6C963F0
        public void SetToReadOnly(){} // RVA: 0x7FFAF316D7E0
        public void ThrowIfReadOnly(){} // RVA: 0x7FFAF9676490
    }

    public class ManagedWebSocket
    {
        // ── Methods ──
        public void CreateFromConnectedStream(){} // RVA: 0x7FFAF96697F0
        public void get_StateUpdateLock(){} // RVA: 0x7FFAF30E74D0
        public void get_ReceiveAsyncLock(){} // RVA: 0x7FFAF2E08730
        public void .ctor(){} // RVA: 0x7FFAF9669890
        public void Dispose(){} // RVA: 0x7FFAF966A0B0
        public void DisposeCore(){} // RVA: 0x7FFAF966A1F0
        public void get_CloseStatus(){} // RVA: 0x7FFAF2E2B370
        public void get_CloseStatusDescription(){} // RVA: 0x7FFAF2E08D50
        public void get_State(){} // RVA: 0x7FFAF349AB90
        public void SendAsync(){} // RVA: 0x7FFAF966A270
        public void SendPrivateAsync(){} // RVA: 0x7FFAF966A650
        public void ReceiveAsync(){} // RVA: 0x7FFAF966A990
        public void CloseAsync(){} // RVA: 0x7FFAF966AD90
        public void CloseOutputAsync(){} // RVA: 0x7FFAF966AE90
        public void Abort(){} // RVA: 0x7FFAF966AF90
        public void SendFrameAsync(){} // RVA: 0x7FFAF966B020
        public void SendFrameLockAcquiredNonCancelableAsync(){} // RVA: 0x7FFAF966B1B0
        public void WaitForWriteTaskAsync(){} // RVA: 0x7FFAF966B6A0
        public void SendFrameFallbackAsync(){} // RVA: 0x7FFAF966B8C0
        public void WriteFrameToSendBuffer(){} // RVA: 0x7FFAF966BB50
        public void SendKeepAliveFrameAsync(){} // RVA: 0x7FFAF966BF70
        public void WriteHeader(){} // RVA: 0x7FFAF966C2B0
        public void WriteRandomMask(){} // RVA: 0x7FFAF966C4A0
        public void ReceiveAsyncPrivate(){} // RVA: 0x7FFAF2D33FA0
        public void HandleReceivedCloseAsync(){} // RVA: 0x7FFAF966C540
        public void WaitForServerToCloseConnectionAsync(){} // RVA: 0x7FFAF966C780
        public void HandleReceivedPingPongAsync(){} // RVA: 0x7FFAF966C9A0
        public void IsValidCloseStatus(){} // RVA: 0x7FFAF966CBE0
        public void CloseWithReceiveErrorAndThrowAsync(){} // RVA: 0x7FFAF966CC20
        public void TryParseMessageHeaderFromReceiveBuffer(){} // RVA: 0x7FFAF966CE70
        public void CloseAsyncPrivate(){} // RVA: 0x7FFAF966D160
        public void SendCloseFrameAsync(){} // RVA: 0x7FFAF966D3F0
        public void ConsumeFromBuffer(){} // RVA: 0x7FFAF966D680
        public void EnsureBufferContainsAsync(){} // RVA: 0x7FFAF966D690
        public void ThrowIfEOFUnexpected(){} // RVA: 0x7FFAF966D8D0
        public void AllocateSendBuffer(){} // RVA: 0x7FFAF966D970
        public void ReleaseSendBuffer(){} // RVA: 0x7FFAF966DA60
        public void CombineMaskBytes(){} // RVA: 0x7FFAF966DB60
        public void ApplyMask(){} // RVA: 0x7FFAF966DD50 | overloaded x2
        public void ThrowIfOperationInProgress(){} // RVA: 0x7FFAF966DE40
        public void ThrowOperationInProgress(){} // RVA: 0x7FFAF966DE80
        public void CreateOperationCanceledException(){} // RVA: 0x7FFAF966DEF0
        public void TryValidateUtf8(){} // RVA: 0x7FFAF966DFD0
        public void ValidateAndReceiveAsync(){} // RVA: 0x7FFAF966E1A0
        public void .cctor(){} // RVA: 0x7FFAF966E3E0
    }

    public class WebSocket
    {
        // ── Methods ──
        public void get_CloseStatus(){} // RVA: 0x7FFAF2ABCD60
        public void get_CloseStatusDescription(){} // RVA: 0x7FFAF2ABCD60
        public void get_State(){} // RVA: 0x7FFAF2ABD840
        public void Abort(){} // RVA: 0x7FFAF2AD4A50
        public void CloseAsync(){}
        public void CloseOutputAsync(){}
        public void Dispose(){} // RVA: 0x7FFAF2AD4A50
        public void ReceiveAsync(){}
        public void SendAsync(){}
        public void get_DefaultKeepAliveInterval(){} // RVA: 0x7FFAF967C500
        public void CreateClientWebSocket(){} // RVA: 0x7FFAF967C590
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class WebSocketException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95CC9D0 | overloaded x9
        public void GetObjectData(){} // RVA: 0x7FFAF967CBB0
        public void get_ErrorCode(){} // RVA: 0x7FFAF315FD40
        public void GetErrorMessage(){} // RVA: 0x7FFAF967CEC0
        public void SetErrorCodeOnError(){} // RVA: 0x7FFAF967D070
        public void Succeeded(){} // RVA: 0x7FFAF967D080
    }

    public class WebSocketHandle
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9676500
        public void IsValid(){} // RVA: 0x7FFAF4067070
        public void get_CloseStatus(){} // RVA: 0x7FFAF96765E0
        public void get_CloseStatusDescription(){} // RVA: 0x7FFAF9676600
        public void get_State(){} // RVA: 0x7FFAF9676620
        public void CheckPlatformSupport(){} // RVA: 0x7FFAF2D8D310
        public void Dispose(){} // RVA: 0x7FFAF9676650
        public void Abort(){} // RVA: 0x7FFAF9676680
        public void SendAsync(){} // RVA: 0x7FFAF9676710
        public void ReceiveAsync(){} // RVA: 0x7FFAF9676760
        public void CloseAsync(){} // RVA: 0x7FFAF96767A0
        public void CloseOutputAsync(){} // RVA: 0x7FFAF96767D0
        public void ConnectAsyncCore(){} // RVA: 0x7FFAF9676800
        public void ConnectSocketAsync(){} // RVA: 0x7FFAF9676AC0
        public void BuildRequestHeader(){} // RVA: 0x7FFAF9676D20
        public void CreateSecKeyAndSecWebSocketAccept(){} // RVA: 0x7FFAF9677810
        public void ParseAndValidateConnectResponseAsync(){} // RVA: 0x7FFAF9677CA0
        public void ValidateAndTrackHeader(){} // RVA: 0x7FFAF9677F30
        public void ReadResponseHeaderLineAsync(){} // RVA: 0x7FFAF9678190
        public void .ctor(){} // RVA: 0x7FFAF9678390
        public void .cctor(){} // RVA: 0x7FFAF9678440
    }

    public class WebSocketReceiveResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF967D0B0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAF2DDA5C0
        public void get_EndOfMessage(){} // RVA: 0x7FFAF2EDCBD0
        public void get_MessageType(){} // RVA: 0x7FFAF306ED50
    }

    public class WebSocketValidate
    {
        // ── Methods ──
        public void ThrowIfInvalidState(){} // RVA: 0x7FFAF9674010
        public void ValidateSubprotocol(){} // RVA: 0x7FFAF96741B0
        public void ValidateCloseStatus(){} // RVA: 0x7FFAF9674470
        public void ValidateArraySegment(){} // RVA: 0x7FFAF96746B0
    }

}