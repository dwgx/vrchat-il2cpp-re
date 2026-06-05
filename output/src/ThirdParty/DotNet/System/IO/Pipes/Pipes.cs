// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Pipes
// Classes: 12
// Methods: 123

namespace ThirdParty.DotNet.System.IO.Pipes
{
    public class ConnectionCompletionSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF91275B0
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAF9127680
        public void AsyncCallback(){} // RVA: 0x7FFAF91276F0
        public void HandleError(){} // RVA: 0x7FFAF9127770
        public void HandleUnexpectedCancellation(){} // RVA: 0x7FFAF9127820
    }

    public class NamedPipeClientStream
    {
        // ── Methods ──
        public void TryConnect(){} // RVA: 0x7FFAF91278F0
        public void ValidateRemotePipeUser(){} // RVA: 0x7FFAF9127C80
        public void .ctor(){} // RVA: 0x7FFAF9127DF0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF8762900
        public void Connect(){} // RVA: 0x7FFAF9128230
        public void ConnectInternal(){} // RVA: 0x7FFAF9128380
        public void CheckConnectOperationsClient(){} // RVA: 0x7FFAF9128560
    }

    public class NamedPipeServerStream
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9128650 | overloaded x2
        public void WaitForConnection(){} // RVA: 0x7FFAF9128CD0
        public void Disconnect(){} // RVA: 0x7FFAF9128F80
        public void ImpersonateAndTryCode(){} // RVA: 0x7FFAF91291C0
        public void RevertImpersonationOnBackout(){} // RVA: 0x7FFAF9129400
        public void WaitForConnectionCoreAsync(){} // RVA: 0x7FFAF9129530
        public void CheckConnectOperationsServerWithHandle(){} // RVA: 0x7FFAF9129910
        public void .ctor(){} // RVA: 0x7FFAF9129A50 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF8762900
        public void CheckConnectOperationsServer(){} // RVA: 0x7FFAF9129DC0
        public void CheckDisconnectOperations(){} // RVA: 0x7FFAF9129E80
        public void .cctor(){} // RVA: 0x7FFAF9129FC0
    }

    public class PipeAccessRule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF912A2A0 | overloaded x2
        public void AccessMaskFromRights(){} // RVA: 0x7FFAF912A340
    }

    public class PipeCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void get_Overlapped(){} // RVA: 0x7FFAF2D33FA0
        public void RegisterForCancellation(){} // RVA: 0x7FFAF2AD4CC0
        public void ReleaseResources(){} // RVA: 0x7FFAF2AD4A50
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAF2AD4A50
        public void AsyncCallback(){}
        public void HandleError(){} // RVA: 0x7FFAF2AD4FA0
        public void Cancel(){} // RVA: 0x7FFAF2AD4A50
        public void HandleUnexpectedCancellation(){} // RVA: 0x7FFAF2AD4A50
        public void CompleteCallback(){} // RVA: 0x7FFAF2AD4FA0
    }

    public class PipeCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF689FFD0
        public void get_Overlapped(){} // RVA: 0x7FFAF2E0A740
        public void RegisterForCancellation(){} // RVA: 0x7FFAF68A0300
        public void ReleaseResources(){} // RVA: 0x7FFAF689FD10
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAF2AD4A50
        public void AsyncCallback(){} // RVA: 0x7FFAF68A0560
        public void HandleError(){} // RVA: 0x7FFAF2AD4FA0
        public void Cancel(){} // RVA: 0x7FFAF68A0590
        public void HandleUnexpectedCancellation(){} // RVA: 0x7FFAF68A0630
        public void CompleteCallback(){} // RVA: 0x7FFAF68A0650
    }

    public class PipeCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF689F780
        public void get_Overlapped(){} // RVA: 0x7FFAF2E0A740
        public void RegisterForCancellation(){} // RVA: 0x7FFAF689FAB0
        public void ReleaseResources(){} // RVA: 0x7FFAF689FD10
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAF2AD4A50
        public void AsyncCallback(){} // RVA: 0x7FFAF689FD60
        public void HandleError(){} // RVA: 0x7FFAF2AD4FA0
        public void Cancel(){} // RVA: 0x7FFAF689FD90
        public void HandleUnexpectedCancellation(){} // RVA: 0x7FFAF689FE30
        public void CompleteCallback(){} // RVA: 0x7FFAF689FE50
    }

    public class PipeSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF912A420 | overloaded x2
        public void AddAccessRule(){} // RVA: 0x7FFAF912A520
    }

    public class PipeStream
    {
        // ── Methods ──
        public void GetPipePath(){} // RVA: 0x7FFAF912A5B0
        public void InitializeAsyncHandle(){} // RVA: 0x7FFAF912A7B0
        public void DisposeCore(){} // RVA: 0x7FFAF912A860
        public void ReadCore(){} // RVA: 0x7FFAF912A880
        public void ReadAsyncCore(){} // RVA: 0x7FFAF912A940
        public void WriteCore(){} // RVA: 0x7FFAF912AC10
        public void WriteAsyncCore(){} // RVA: 0x7FFAF912AC80
        public void ReadFileNative(){} // RVA: 0x7FFAF912AE80
        public void WriteFileNative(){} // RVA: 0x7FFAF912B0C0
        public void GetSecAttrs(){} // RVA: 0x7FFAF912B330 | overloaded x2
        public void WinIOError(){} // RVA: 0x7FFAF912B3C0
        public void .ctor(){} // RVA: 0x7FFAF912B670 | overloaded x2
        public void Init(){} // RVA: 0x7FFAF912B830
        public void InitializeHandle(){} // RVA: 0x7FFAF912B860
        public void Read(){} // RVA: 0x7FFAF912BBB0 | overloaded x2
        public void ReadAsync(){} // RVA: 0x7FFAF912BE90 | overloaded x2
        public void BeginRead(){} // RVA: 0x7FFAF912C0F0
        public void EndRead(){} // RVA: 0x7FFAF912C1F0
        public void Write(){} // RVA: 0x7FFAF912C4C0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFAF912C7B0 | overloaded x2
        public void BeginWrite(){} // RVA: 0x7FFAF912CA50
        public void EndWrite(){} // RVA: 0x7FFAF912CB50
        public void CheckReadWriteArgs(){} // RVA: 0x7FFAF912CB70
        public void ReadByte(){} // RVA: 0x7FFAF912CD10
        public void WriteByte(){} // RVA: 0x7FFAF912CD90
        public void Flush(){} // RVA: 0x7FFAF912CE00
        public void Dispose(){} // RVA: 0x7FFAF912CE60
        public void get_IsConnected(){} // RVA: 0x7FFAF45B33B0
        public void get_IsAsync(){} // RVA: 0x7FFAF3F7EB40
        public void UpdateMessageCompletion(){} // RVA: 0x7FFAF912CF00
        public void get_SafePipeHandle(){} // RVA: 0x7FFAF912CF30
        public void get_InternalHandle(){} // RVA: 0x7FFAF30E74D0
        public void get_CanRead(){} // RVA: 0x7FFAF2F56500
        public void get_CanWrite(){} // RVA: 0x7FFAF2F57410
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_Length(){} // RVA: 0x7FFAF912CFC0
        public void get_Position(){} // RVA: 0x7FFAF912CFF0
        public void set_Position(){} // RVA: 0x7FFAF912D020
        public void SetLength(){} // RVA: 0x7FFAF912D050
        public void Seek(){} // RVA: 0x7FFAF912D080
        public void CheckReadOperations(){} // RVA: 0x7FFAF912D0B0
        public void CheckWriteOperations(){} // RVA: 0x7FFAF912D1F0
        public void get_State(){} // RVA: 0x7FFAF304C540
        public void set_State(){} // RVA: 0x7FFAF310F570
        public void get_IsCurrentUserOnly(){} // RVA: 0x7FFAF3F79240
        public void set_IsCurrentUserOnly(){} // RVA: 0x7FFAF912D380
        public void GetAccessControl(){} // RVA: 0x7FFAF912D390
        public void .cctor(){} // RVA: 0x7FFAF912D4F0
    }

    public class PipeStreamImpersonationWorker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DEB980
        public void Invoke(){} // RVA: 0x7FFAF2DEBA50
    }

    public class ReadWriteCompletionSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF912D600
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAF912D6E0
        public void AsyncCallback(){} // RVA: 0x7FFAF912D760
        public void HandleError(){} // RVA: 0x7FFAF912D810
    }

    public class VoidResult
    {
    }

}