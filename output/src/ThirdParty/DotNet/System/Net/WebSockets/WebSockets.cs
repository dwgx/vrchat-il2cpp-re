// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.WebSockets
// Classes: 8
// Methods: 129

namespace ThirdParty.DotNet.System.Net.WebSockets
{
    public class ClientWebSocket
    {
        public System.Net.WebSockets.ClientWebSocketOptions _options; // 0x10
        public System.Net.WebSockets.WebSocketHandle _innerWebSocket; // 0x18
        public int _state; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BC48F0
        public void get_Options(){} // RVA: 0x2F8380
        public void get_CloseStatus(){} // RVA: 0x6BC4BA0
        public void get_CloseStatusDescription(){} // RVA: 0x6BC4C30
        public void get_State(){} // RVA: 0x6BC4CC0
        public void ConnectAsync(){} // RVA: 0x6BC4D80
        public void ConnectAsyncCore(){} // RVA: 0x6BC50A0
        public void SendAsync(){} // RVA: 0x6BC5330
        public void ReceiveAsync(){} // RVA: 0x6BC53C0
        public void CloseAsync(){} // RVA: 0x6BC5430
        public void CloseOutputAsync(){} // RVA: 0x6BC54B0
        public void Abort(){} // RVA: 0x6BC5530
        public void Dispose(){} // RVA: 0x6BC55C0
        public void ThrowIfNotConnected(){} // RVA: 0x6BC5660
    }

    public class ClientWebSocketOptions
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

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BC5E10
        public void get_RequestHeaders(){} // RVA: 0x30B0C0
        public void get_RequestedSubProtocols(){} // RVA: 0x2E07C0
        public void set_Proxy(){} // RVA: 0x6BC5FF0
        public void get_ClientCertificates(){} // RVA: 0x6BC60A0
        public void get_Cookies(){} // RVA: 0x35A740
        public void AddSubProtocol(){} // RVA: 0x6BC6150
        public void get_KeepAliveInterval(){} // RVA: 0x30B130
        public void get_ReceiveBufferSize(){} // RVA: 0x37E0C0
        public void get_SendBufferSize(){} // RVA: 0x1479960
        public void get_Buffer(){} // RVA: 0x41E63F0
        public void SetToReadOnly(){} // RVA: 0x6BD7E0
        public void ThrowIfReadOnly(){} // RVA: 0x6BC6490
    }

    public class ManagedWebSocket
    {
        public System.Security.Cryptography.RandomNumberGenerator s_random;
        public System.Text.UTF8Encoding s_textEncoding; // 0x8
        public 0x6585D030[] s_validSendStates; // 0x10
        public 0x6585D030[] s_validReceiveStates; // 0x18
        public 0x6585D030[] s_validCloseOutputStates; // 0x20

        // ── Methods ──
        public void CreateFromConnectedStream(){} // RVA: 0x6BB97F0
        public void get_StateUpdateLock(){} // RVA: 0x6374D0
        public void get_ReceiveAsyncLock(){} // RVA: 0x358730
        public void .ctor(){} // RVA: 0x6BB9890
        public void Dispose(){} // RVA: 0x6BBA0B0
        public void DisposeCore(){} // RVA: 0x6BBA1F0
        public void get_CloseStatus(){} // RVA: 0x37B370
        public void get_CloseStatusDescription(){} // RVA: 0x358D50
        public void get_State(){} // RVA: 0x9EAB90
        public void SendAsync(){} // RVA: 0x6BBA270
        public void SendPrivateAsync(){} // RVA: 0x6BBA650
        public void ReceiveAsync(){} // RVA: 0x6BBA990
        public void CloseAsync(){} // RVA: 0x6BBAD90
        public void CloseOutputAsync(){} // RVA: 0x6BBAE90
        public void Abort(){} // RVA: 0x6BBAF90
        public void SendFrameAsync(){} // RVA: 0x6BBB020
        public void SendFrameLockAcquiredNonCancelableAsync(){} // RVA: 0x6BBB1B0
        public void WaitForWriteTaskAsync(){} // RVA: 0x6BBB6A0
        public void SendFrameFallbackAsync(){} // RVA: 0x6BBB8C0
        public void WriteFrameToSendBuffer(){} // RVA: 0x6BBBB50
        public void SendKeepAliveFrameAsync(){} // RVA: 0x6BBBF70
        public void WriteHeader(){} // RVA: 0x6BBC2B0
        public void WriteRandomMask(){} // RVA: 0x6BBC4A0
        public void ReceiveAsyncPrivate(){} // RVA: 0x283FA0
        public void HandleReceivedCloseAsync(){} // RVA: 0x6BBC540
        public void WaitForServerToCloseConnectionAsync(){} // RVA: 0x6BBC780
        public void HandleReceivedPingPongAsync(){} // RVA: 0x6BBC9A0
        public void IsValidCloseStatus(){} // RVA: 0x6BBCBE0
        public void CloseWithReceiveErrorAndThrowAsync(){} // RVA: 0x6BBCC20
        public void TryParseMessageHeaderFromReceiveBuffer(){} // RVA: 0x6BBCE70
        public void CloseAsyncPrivate(){} // RVA: 0x6BBD160
        public void SendCloseFrameAsync(){} // RVA: 0x6BBD3F0
        public void ConsumeFromBuffer(){} // RVA: 0x6BBD680
        public void EnsureBufferContainsAsync(){} // RVA: 0x6BBD690
        public void ThrowIfEOFUnexpected(){} // RVA: 0x6BBD8D0
        public void AllocateSendBuffer(){} // RVA: 0x6BBD970
        public void ReleaseSendBuffer(){} // RVA: 0x6BBDA60
        public void CombineMaskBytes(){} // RVA: 0x6BBDB60
        public void ApplyMask(){} // RVA: 0x6BBDD50 | overloaded x2
        public void ThrowIfOperationInProgress(){} // RVA: 0x6BBDE40
        public void ThrowOperationInProgress(){} // RVA: 0x6BBDE80
        public void CreateOperationCanceledException(){} // RVA: 0x6BBDEF0
        public void TryValidateUtf8(){} // RVA: 0x6BBDFD0
        public void ValidateAndReceiveAsync(){} // RVA: 0x6BBE1A0
        public void .cctor(){} // RVA: 0x6BBE3E0
    }

    public class WebSocket
    {
        // ── Methods ──
        public void get_CloseStatus(){} // RVA: 0xCD60
        public void get_CloseStatusDescription(){} // RVA: 0xCD60
        public void get_State(){} // RVA: 0xD840
        public void Abort(){} // RVA: 0x24A50
        public void CloseAsync(){}
        public void CloseOutputAsync(){}
        public void Dispose(){} // RVA: 0x24A50
        public void ReceiveAsync(){}
        public void SendAsync(){}
        public void get_DefaultKeepAliveInterval(){} // RVA: 0x6BCC500
        public void CreateClientWebSocket(){} // RVA: 0x6BCC590
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class WebSocketException
    {
        public 0x6585CED0 _webSocketErrorCode; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B1C9D0 | overloaded x9
        public void GetObjectData(){} // RVA: 0x6BCCBB0
        public void get_ErrorCode(){} // RVA: 0x6AFD40
        public void GetErrorMessage(){} // RVA: 0x6BCCEC0
        public void SetErrorCodeOnError(){} // RVA: 0x6BCD070
        public void Succeeded(){} // RVA: 0x6BCD080
    }

    public class WebSocketHandle
    {
        public System.Text.StringBuilder t_cachedStringBuilder; // 0xFFFFFFFF
        public System.Text.Encoding s_defaultHttpEncoding;
        public System.Threading.CancellationTokenSource _abortSource; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x6BC6500
        public void IsValid(){} // RVA: 0x15B7070
        public void get_CloseStatus(){} // RVA: 0x6BC65E0
        public void get_CloseStatusDescription(){} // RVA: 0x6BC6600
        public void get_State(){} // RVA: 0x6BC6620
        public void CheckPlatformSupport(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x6BC6650
        public void Abort(){} // RVA: 0x6BC6680
        public void SendAsync(){} // RVA: 0x6BC6710
        public void ReceiveAsync(){} // RVA: 0x6BC6760
        public void CloseAsync(){} // RVA: 0x6BC67A0
        public void CloseOutputAsync(){} // RVA: 0x6BC67D0
        public void ConnectAsyncCore(){} // RVA: 0x6BC6800
        public void ConnectSocketAsync(){} // RVA: 0x6BC6AC0
        public void BuildRequestHeader(){} // RVA: 0x6BC6D20
        public void CreateSecKeyAndSecWebSocketAccept(){} // RVA: 0x6BC7810
        public void ParseAndValidateConnectResponseAsync(){} // RVA: 0x6BC7CA0
        public void ValidateAndTrackHeader(){} // RVA: 0x6BC7F30
        public void ReadResponseHeaderLineAsync(){} // RVA: 0x6BC8190
        public void .ctor(){} // RVA: 0x6BC8390
        public void .cctor(){} // RVA: 0x6BC8440
    }

    public class WebSocketReceiveResult
    {
        public int <Count>k__BackingField; // 0x10
        public bool <EndOfMessage>k__BackingField; // 0x14
        public 0x6585CF80 <MessageType>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BCD0B0 | overloaded x2
        public void get_Count(){} // RVA: 0x32A5C0
        public void get_EndOfMessage(){} // RVA: 0x42CBD0
        public void get_MessageType(){} // RVA: 0x5BED50
    }

    public class WebSocketValidate
    {
        // ── Methods ──
        public void ThrowIfInvalidState(){} // RVA: 0x6BC4010
        public void ValidateSubprotocol(){} // RVA: 0x6BC41B0
        public void ValidateCloseStatus(){} // RVA: 0x6BC4470
        public void ValidateArraySegment(){} // RVA: 0x6BC46B0
    }

}