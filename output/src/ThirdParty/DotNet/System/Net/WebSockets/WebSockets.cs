// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.WebSockets
// Classes: 3
// Methods: 66

namespace ThirdParty.DotNet.System.Net.WebSockets
{
    public class ManagedWebSocket : WebSocket
    {
        public object StateUpdateLock;
        public object ReceiveAsyncLock;
        public object CloseStatus;
        public object CloseStatusDescription;
        public object State;

        // ── Methods ──
        public void CreateFromConnectedStream(){} // RVA: 0x7FFD54770370
        public void get_StateUpdateLock(){} // RVA: 0x7FFD4E5F95E0
        public void get_ReceiveAsyncLock(){} // RVA: 0x7FFD4E3BC730
        public void .ctor(){} // RVA: 0x7FFD54770410
        public void Dispose(){} // RVA: 0x7FFD54770C30
        public void DisposeCore(){} // RVA: 0x7FFD54770D70
        public void get_CloseStatus(){} // RVA: 0x7FFD4E3DF370
        public void get_CloseStatusDescription(){} // RVA: 0x7FFD4E3BCD50
        public void get_State(){} // RVA: 0x7FFD4EA4EA40
        public void SendAsync(){} // RVA: 0x7FFD54770DF0
        public void SendPrivateAsync(){} // RVA: 0x7FFD547711D0
        public void ReceiveAsync(){} // RVA: 0x7FFD54771510
        public void CloseAsync(){} // RVA: 0x7FFD54771910
        public void CloseOutputAsync(){} // RVA: 0x7FFD54771A10
        public void Abort(){} // RVA: 0x7FFD54771B10
        public void SendFrameAsync(){} // RVA: 0x7FFD54771BA0
        public void SendFrameLockAcquiredNonCancelableAsync(){} // RVA: 0x7FFD54771D30
        public void WaitForWriteTaskAsync(){} // RVA: 0x7FFD54772220
        public void SendFrameFallbackAsync(){} // RVA: 0x7FFD54772440
        public void WriteFrameToSendBuffer(){} // RVA: 0x7FFD547726D0
        public void SendKeepAliveFrameAsync(){} // RVA: 0x7FFD54772AF0
        public void WriteHeader(){} // RVA: 0x7FFD54772E30
        public void WriteRandomMask(){} // RVA: 0x7FFD54773020
        public void ReceiveAsyncPrivate(){} // RVA: 0x7FFD4E2ADC40
        public void HandleReceivedCloseAsync(){} // RVA: 0x7FFD547730C0
        public void WaitForServerToCloseConnectionAsync(){} // RVA: 0x7FFD54773300
        public void HandleReceivedPingPongAsync(){} // RVA: 0x7FFD54773520
        public void IsValidCloseStatus(){} // RVA: 0x7FFD54773760
        public void CloseWithReceiveErrorAndThrowAsync(){} // RVA: 0x7FFD547737A0
        public void TryParseMessageHeaderFromReceiveBuffer(){} // RVA: 0x7FFD547739F0
        public void CloseAsyncPrivate(){} // RVA: 0x7FFD54773CE0
        public void SendCloseFrameAsync(){} // RVA: 0x7FFD54773F70
        public void ConsumeFromBuffer(){} // RVA: 0x7FFD54774200
        public void EnsureBufferContainsAsync(){} // RVA: 0x7FFD54774210
        public void ThrowIfEOFUnexpected(){} // RVA: 0x7FFD54774450
        public void AllocateSendBuffer(){} // RVA: 0x7FFD547744F0
        public void ReleaseSendBuffer(){} // RVA: 0x7FFD547745E0
        public void CombineMaskBytes(){} // RVA: 0x7FFD547746E0
        public void ApplyMask(){} // RVA: 0x7FFD547748D0 | overloaded x2
        public void ThrowIfOperationInProgress(){} // RVA: 0x7FFD547749C0
        public void ThrowOperationInProgress(){} // RVA: 0x7FFD54774A00
        public void CreateOperationCanceledException(){} // RVA: 0x7FFD54774A70
        public void TryValidateUtf8(){} // RVA: 0x7FFD54774B50
        public void ValidateAndReceiveAsync(){} // RVA: 0x7FFD54774D20
        public void .cctor(){} // RVA: 0x7FFD54774F60
    }

    public class ValueWebSocketReceiveResult : ValueType
    {
        public object EndOfMessage;
        public object MessageType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54783350
        public void get_EndOfMessage(){} // RVA: 0x7FFD53A4EBA0
        public void get_MessageType(){} // RVA: 0x7FFD4F8402A0
        public void ThrowCountOutOfRange(){} // RVA: 0x7FFD54783390
        public void ThrowMessageTypeOutOfRange(){} // RVA: 0x7FFD547833E0
    }

    public class WebSocket : Object
    {
        public object CloseStatus;
        public object CloseStatusDescription;
        public object State;
        public object DefaultKeepAliveInterval;

        // ── Methods ──
        public void get_CloseStatus(){} // RVA: 0x7FFD4E078E90
        public void get_CloseStatusDescription(){} // RVA: 0x7FFD4E078E90
        public void get_State(){} // RVA: 0x7FFD4E079960
        public void Abort(){} // RVA: 0x7FFD4E090980
        public void CloseAsync(){}
        public void CloseOutputAsync(){}
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void ReceiveAsync(){} // RVA: 0x7FFD54783430 | overloaded x2
        public void SendAsync(){} // RVA: 0x7FFD547836E0 | overloaded x2
        public void SendWithArrayPoolAsync(){} // RVA: 0x7FFD54783830
        public void get_DefaultKeepAliveInterval(){} // RVA: 0x7FFD54783AE0
        public void CreateClientWebSocket(){} // RVA: 0x7FFD54783B70
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}