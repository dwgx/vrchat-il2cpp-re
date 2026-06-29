// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.WebSockets
// Classes: 8
// Methods: 119

namespace ThirdParty.DotNet.System.Net.WebSockets
{
    public class ClientWebSocket : WebSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9B3620
        public void get_Options(){} // RVA: 0x7A80F2570
        public void get_CloseStatus(){} // RVA: 0x7AE9B3A80
        public void get_CloseStatusDescription(){} // RVA: 0x7AE9B3B10
        public void get_State(){} // RVA: 0x7AE9B3BA0
        public void ConnectAsync(){} // RVA: 0x7AE9B3C60
        public void ConnectAsyncCore(){} // RVA: 0x7AE9B3F80
        public void SendAsync(){} // RVA: 0x7AE9B4210
        public void ReceiveAsync(){} // RVA: 0x7AE9B42A0
        public void CloseAsync(){} // RVA: 0x7AE9B4310
        public void CloseOutputAsync(){} // RVA: 0x7AE9B4390
        public void Abort(){} // RVA: 0x7AE9B4410
        public void Dispose(){} // RVA: 0x7AE9B44A0
        public void ThrowIfNotConnected(){} // RVA: 0x7AE9B4540
    }

    public class ClientWebSocketOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9B4CF0
        public void get_RequestHeaders(){} // RVA: 0x7A81052C0
        public void get_RequestedSubProtocols(){} // RVA: 0x7A80DA7B0
        public void set_Proxy(){} // RVA: 0x7AE9B4ED0
        public void get_ClientCertificates(){} // RVA: 0x7AE9B4F80
        public void get_Cookies(){} // RVA: 0x7A8154D80
        public void AddSubProtocol(){} // RVA: 0x7AE9B5030
        public void get_KeepAliveInterval(){} // RVA: 0x7A8105330
        public void get_ReceiveBufferSize(){} // RVA: 0x7A8178B70
        public void get_SendBufferSize(){} // RVA: 0x7A9231EA0
        public void get_Buffer(){} // RVA: 0x7ABFD6C80
        public void SetToReadOnly(){} // RVA: 0x7A847A240
        public void ThrowIfReadOnly(){} // RVA: 0x7AE9B5380
    }

    public class ManagedWebSocket : WebSocket
    {
        // ── Methods ──
        public void CreateFromConnectedStream(){} // RVA: 0x7AE9A86F0
        public void get_StateUpdateLock(){} // RVA: 0x7A83F69F0
        public void get_ReceiveAsyncLock(){} // RVA: 0x7A8152D80
        public void .ctor(){} // RVA: 0x7AE9A8790
        public void Dispose(){} // RVA: 0x7AE9A8FC0
        public void DisposeCore(){} // RVA: 0x7AE9A90C0
        public void get_CloseStatus(){} // RVA: 0x7A8175DF0
        public void get_CloseStatusDescription(){} // RVA: 0x7A8153390
        public void get_State(){} // RVA: 0x7A87A7DA0
        public void SendAsync(){} // RVA: 0x7AE9A9140
        public void SendPrivateAsync(){} // RVA: 0x7AE9A9530
        public void ReceiveAsync(){} // RVA: 0x7AE9A9870
        public void CloseAsync(){} // RVA: 0x7AE9A9C40
        public void CloseOutputAsync(){} // RVA: 0x7AE9A9D40
        public void Abort(){} // RVA: 0x7AE9A9E40
        public void SendFrameAsync(){} // RVA: 0x7AE9A9ED0
        public void SendFrameLockAcquiredNonCancelableAsync(){} // RVA: 0x7AE9AA060
        public void WaitForWriteTaskAsync(){} // RVA: 0x7AE9AA540
        public void SendFrameFallbackAsync(){} // RVA: 0x7AE9AA760
        public void WriteFrameToSendBuffer(){} // RVA: 0x7AE9AA9F0
        public void SendKeepAliveFrameAsync(){} // RVA: 0x7AE9AAE10
        public void WriteHeader(){} // RVA: 0x7AE9AB150
        public void WriteRandomMask(){} // RVA: 0x7AE9AB340
        public void ReceiveAsyncPrivate(){} // RVA: 0x7A8051B10
        public void HandleReceivedCloseAsync(){} // RVA: 0x7AE9AB3E0
        public void WaitForServerToCloseConnectionAsync(){} // RVA: 0x7AE9AB620
        public void HandleReceivedPingPongAsync(){} // RVA: 0x7AE9AB840
        public void IsValidCloseStatus(){} // RVA: 0x7AE9ABA80
        public void CloseWithReceiveErrorAndThrowAsync(){} // RVA: 0x7AE9ABAC0
        public void TryParseMessageHeaderFromReceiveBuffer(){} // RVA: 0x7AE9ABD10
        public void CloseAsyncPrivate(){} // RVA: 0x7AE9AC000
        public void SendCloseFrameAsync(){} // RVA: 0x7AE9AC290
        public void ConsumeFromBuffer(){} // RVA: 0x7AE9AC520
        public void EnsureBufferContainsAsync(){} // RVA: 0x7AE9AC530
        public void ThrowIfEOFUnexpected(){} // RVA: 0x7AE9AC770
        public void AllocateSendBuffer(){} // RVA: 0x7AE9AC810
        public void ReleaseSendBuffer(){} // RVA: 0x7AE9AC900
        public void CombineMaskBytes(){} // RVA: 0x7AE9ACA00
        public void ApplyMask(){} // RVA: 0x7AE9ACBF0
        public void ThrowIfOperationInProgress(){} // RVA: 0x7AE9ACCE0
        public void ThrowOperationInProgress(){} // RVA: 0x7AE9ACD20
        public void CreateOperationCanceledException(){} // RVA: 0x7AE9ACD90
        public void TryValidateUtf8(){} // RVA: 0x7AE9ACE80
        public void ValidateAndReceiveAsync(){} // RVA: 0x7AE9AD040
        public void .cctor(){} // RVA: 0x7AE9AD280
    }

    public class WebSocket : Object
    {
        // ── Methods ──
        public void get_CloseStatus(){} // RVA: 0x7A7E00680
        public void get_CloseStatusDescription(){} // RVA: 0x7A7E00680
        public void get_State(){} // RVA: 0x7A7E00710
        public void Abort(){} // RVA: 0x7A7E18770
        public void CloseAsync(){} // RVA: 0x7A7E10CD0
        public void CloseOutputAsync(){} // RVA: 0x7A7E10CD0
        public void Dispose(){} // RVA: 0x7A7E18770
        public void ReceiveAsync(){} // RVA: 0x7A7E06640
        public void SendAsync(){} // RVA: 0x7A7E10690
        public void get_DefaultKeepAliveInterval(){} // RVA: 0x7AE9BB420
        public void CreateClientWebSocket(){} // RVA: 0x7AE9BB4B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class WebSocketException : Win32Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE90D430
        public void GetObjectData(){} // RVA: 0x7AE9BBAD0
        public void get_ErrorCode(){} // RVA: 0x7A846C760
        public void GetErrorMessage(){} // RVA: 0x7AE9BBDE0
        public void SetErrorCodeOnError(){} // RVA: 0x7AE9BBF90
        public void Succeeded(){} // RVA: 0x7AE9BBFA0
    }

    public class WebSocketHandle : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AE9B53F0
        public void IsValid(){} // RVA: 0x7A936FE60
        public void get_CloseStatus(){} // RVA: 0x7AE9B54D0
        public void get_CloseStatusDescription(){} // RVA: 0x7AE9B54F0
        public void get_State(){} // RVA: 0x7AE9B5510
        public void CheckPlatformSupport(){} // RVA: 0x7A80D7310
        public void Dispose(){} // RVA: 0x7AE9B5540
        public void Abort(){} // RVA: 0x7AE9B5570
        public void SendAsync(){} // RVA: 0x7AE9B5600
        public void ReceiveAsync(){} // RVA: 0x7AE9B5650
        public void CloseAsync(){} // RVA: 0x7AE9B5690
        public void CloseOutputAsync(){} // RVA: 0x7AE9B56C0
        public void ConnectAsyncCore(){} // RVA: 0x7AE9B56F0
        public void ConnectSocketAsync(){} // RVA: 0x7AE9B59B0
        public void BuildRequestHeader(){} // RVA: 0x7AE9B5C10
        public void CreateSecKeyAndSecWebSocketAccept(){} // RVA: 0x7AE9B66F0
        public void ParseAndValidateConnectResponseAsync(){} // RVA: 0x7AE9B6B90
        public void ValidateAndTrackHeader(){} // RVA: 0x7AE9B6E40
        public void ReadResponseHeaderLineAsync(){} // RVA: 0x7AE9B70A0
        public void .ctor(){} // RVA: 0x7AE9B72A0
        public void .cctor(){} // RVA: 0x7AE9B7350
    }

    public class WebSocketReceiveResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BBFD0
        public void get_Count(){} // RVA: 0x7A8124910
        public void get_EndOfMessage(){} // RVA: 0x7A8227C00
        public void get_MessageType(){} // RVA: 0x7A83782A0
    }

    public class WebSocketValidate : Object
    {
        // ── Methods ──
        public void ThrowIfInvalidState(){} // RVA: 0x7AE9B2D50
        public void ValidateSubprotocol(){} // RVA: 0x7AE9B2EF0
        public void ValidateCloseStatus(){} // RVA: 0x7AE9B31A0
        public void ValidateArraySegment(){} // RVA: 0x7AE9B33E0
    }

}