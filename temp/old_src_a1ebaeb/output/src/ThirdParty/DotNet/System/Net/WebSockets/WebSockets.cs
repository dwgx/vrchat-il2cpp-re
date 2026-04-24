// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.WebSockets
// Classes: 3
// Methods: 66

namespace ThirdParty.DotNet.System.Net.WebSockets
{
    public class ManagedWebSocket : WebSocket
    {
        public object s_validSendStates; // 0x30BAA5D0
        public object s_validCloseStates; // 0x30BAA5D0
        public object _isServer; // 0x30BAA5D0
        public object _abortSource; // 0x30BAA5D0
        public object _sendFrameAsyncLock; // 0x30BAA5D0
        public object _sentCloseFrame; // 0x30BAA5D0
        public object _closeStatusDescription; // 0x30BAA5D0
        public object _receiveBufferCount; // 0x30BAA5D0
        public object _lastSendWasFragment; // 0x30BAA5D0
        public object  m1; // 0x859261D0

        // ── Original Methods ──
        public void CreateFromConnectedStream(){} // RVA: 0x7ffaaed72340
        public void get_StateUpdateLock(){} // RVA: 0x7ffaa8bfcc80
        public void get_ReceiveAsyncLock(){} // RVA: 0x7ffaa89ad730
        public void .ctor(){} // RVA: 0x7ffaaed723e0
        public void Dispose(){} // RVA: 0x7ffaaed72c00
        public void DisposeCore(){} // RVA: 0x7ffaaed72d40
        public void get_CloseStatus(){} // RVA: 0x7ffaa89d0370
        public void get_CloseStatusDescription(){} // RVA: 0x7ffaa89add50
        public void get_State(){} // RVA: 0x7ffaa905bf10
        public void SendAsync(){} // RVA: 0x7ffaaed72dc0
        public void SendPrivateAsync(){} // RVA: 0x7ffaaed731a0
        public void ReceiveAsync(){} // RVA: 0x7ffaaed734e0
        public void CloseAsync(){} // RVA: 0x7ffaaed738e0
        public void CloseOutputAsync(){} // RVA: 0x7ffaaed739e0
        public void Abort(){} // RVA: 0x7ffaaed73ae0
        public void SendFrameAsync(){} // RVA: 0x7ffaaed73b70
        public void SendFrameLockAcquiredNonCancelableAsync(){} // RVA: 0x7ffaaed73d00
        public void WaitForWriteTaskAsync(){} // RVA: 0x7ffaaed741f0
        public void SendFrameFallbackAsync(){} // RVA: 0x7ffaaed74410
        public void WriteFrameToSendBuffer(){} // RVA: 0x7ffaaed746a0
        public void SendKeepAliveFrameAsync(){} // RVA: 0x7ffaaed74ac0
        public void WriteHeader(){} // RVA: 0x7ffaaed74e00
        public void WriteRandomMask(){} // RVA: 0x7ffaaed74ff0
        public void ReceiveAsyncPrivate(){} // RVA: 0x7ffaa887e5c0
        public void HandleReceivedCloseAsync(){} // RVA: 0x7ffaaed75090
        public void WaitForServerToCloseConnectionAsync(){} // RVA: 0x7ffaaed752d0
        public void HandleReceivedPingPongAsync(){} // RVA: 0x7ffaaed754f0
        public void IsValidCloseStatus(){} // RVA: 0x7ffaaed75730
        public void CloseWithReceiveErrorAndThrowAsync(){} // RVA: 0x7ffaaed75770
        public void TryParseMessageHeaderFromReceiveBuffer(){} // RVA: 0x7ffaaed759c0
        public void CloseAsyncPrivate(){} // RVA: 0x7ffaaed75cb0
        public void SendCloseFrameAsync(){} // RVA: 0x7ffaaed75f40
        public void ConsumeFromBuffer(){} // RVA: 0x7ffaaed761d0
        public void EnsureBufferContainsAsync(){} // RVA: 0x7ffaaed761e0
        public void ThrowIfEOFUnexpected(){} // RVA: 0x7ffaaed76420
        public void AllocateSendBuffer(){} // RVA: 0x7ffaaed764c0
        public void ReleaseSendBuffer(){} // RVA: 0x7ffaaed765b0
        public void CombineMaskBytes(){} // RVA: 0x7ffaaed766b0
        public void ApplyMask(){} // RVA: 0x7ffaaed768a0
        public void ApplyMask(){} // RVA: 0x7ffaaed768a0
        public void ThrowIfOperationInProgress(){} // RVA: 0x7ffaaed76990
        public void ThrowOperationInProgress(){} // RVA: 0x7ffaaed769d0
        public void CreateOperationCanceledException(){} // RVA: 0x7ffaaed76a40
        public void TryValidateUtf8(){} // RVA: 0x7ffaaed76b20
        public void ValidateAndReceiveAsync(){} // RVA: 0x7ffaaed76cf0
        public void .cctor(){} // RVA: 0x7ffaaed76f30
    }

    public class ValueWebSocketReceiveResult : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaed85320
        public void get_EndOfMessage(){} // RVA: 0x7ffaae04fdb0
        public void get_MessageType(){} // RVA: 0x7ffaa9e47530
        public void ThrowCountOutOfRange(){} // RVA: 0x7ffaaed85360
        public void ThrowMessageTypeOutOfRange(){} // RVA: 0x7ffaaed853b0
    }

    public class WebSocket : Object
    {
        // ── Original Methods ──
        public void get_CloseStatus(){} // RVA: 0x7ffaa86491d0
        public void get_CloseStatusDescription(){} // RVA: 0x7ffaa86491d0
        public void get_State(){} // RVA: 0x7ffaa8649ca0
        public void Abort(){} // RVA: 0x7ffaa8660cc0
        public void CloseAsync(){}
        public void CloseOutputAsync(){}
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void ReceiveAsync(){} // RVA: 0x7ffaaed85400
        public void SendAsync(){} // RVA: 0x7ffaaed856b0
        public void ReceiveAsync(){} // RVA: 0x7ffaaed85400
        public void SendAsync(){} // RVA: 0x7ffaaed856b0
        public void SendWithArrayPoolAsync(){} // RVA: 0x7ffaaed85800
        public void get_DefaultKeepAliveInterval(){} // RVA: 0x7ffaaed85ab0
        public void CreateClientWebSocket(){} // RVA: 0x7ffaaed85b40
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}