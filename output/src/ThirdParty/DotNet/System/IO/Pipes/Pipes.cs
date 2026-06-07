// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Pipes
// Classes: 10
// Methods: 103

namespace ThirdParty.DotNet.System.IO.Pipes
{
    public class ConnectionCompletionSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66775B0
        public void SetCompletedSynchronously(){} // RVA: 0x6677680
        public void AsyncCallback(){} // RVA: 0x66776F0
        public void HandleError(){} // RVA: 0x6677770
        public void HandleUnexpectedCancellation(){} // RVA: 0x6677820
    }

    public class NamedPipeClientStream
    {
        // ── Methods ──
        public void TryConnect(){} // RVA: 0x66778F0
        public void ValidateRemotePipeUser(){} // RVA: 0x6677C80
        public void .ctor(){} // RVA: 0x6677DF0 | overloaded x2
        public void Finalize(){} // RVA: 0x5CB2900
        public void Connect(){} // RVA: 0x6678230
        public void ConnectInternal(){} // RVA: 0x6678380
        public void CheckConnectOperationsClient(){} // RVA: 0x6678560
    }

    public class NamedPipeServerStream
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x6678650 | overloaded x2
        public void WaitForConnection(){} // RVA: 0x6678CD0
        public void Disconnect(){} // RVA: 0x6678F80
        public void ImpersonateAndTryCode(){} // RVA: 0x66791C0
        public void RevertImpersonationOnBackout(){} // RVA: 0x6679400
        public void WaitForConnectionCoreAsync(){} // RVA: 0x6679530
        public void CheckConnectOperationsServerWithHandle(){} // RVA: 0x6679910
        public void .ctor(){} // RVA: 0x6679A50 | overloaded x2
        public void Finalize(){} // RVA: 0x5CB2900
        public void CheckConnectOperationsServer(){} // RVA: 0x6679DC0
        public void CheckDisconnectOperations(){} // RVA: 0x6679E80
        public void .cctor(){} // RVA: 0x6679FC0
    }

    public class PipeAccessRule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x667A2A0 | overloaded x2
        public void AccessMaskFromRights(){} // RVA: 0x667A340
    }

    public class PipeCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void get_Overlapped(){} // RVA: 0x283FA0
        public void RegisterForCancellation(){} // RVA: 0x24CC0
        public void ReleaseResources(){} // RVA: 0x24A50
        public void SetCompletedSynchronously(){} // RVA: 0x24A50
        public void AsyncCallback(){}
        public void HandleError(){} // RVA: 0x24FA0
        public void Cancel(){} // RVA: 0x24A50
        public void HandleUnexpectedCancellation(){} // RVA: 0x24A50
        public void CompleteCallback(){} // RVA: 0x24FA0
    }

    public class PipeSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x667A420 | overloaded x2
        public void AddAccessRule(){} // RVA: 0x667A520
    }

    public class PipeStream
    {
        // ── Methods ──
        public void GetPipePath(){} // RVA: 0x667A5B0
        public void InitializeAsyncHandle(){} // RVA: 0x667A7B0
        public void DisposeCore(){} // RVA: 0x667A860
        public void ReadCore(){} // RVA: 0x667A880
        public void ReadAsyncCore(){} // RVA: 0x667A940
        public void WriteCore(){} // RVA: 0x667AC10
        public void WriteAsyncCore(){} // RVA: 0x667AC80
        public void ReadFileNative(){} // RVA: 0x667AE80
        public void WriteFileNative(){} // RVA: 0x667B0C0
        public void GetSecAttrs(){} // RVA: 0x667B330 | overloaded x2
        public void WinIOError(){} // RVA: 0x667B3C0
        public void .ctor(){} // RVA: 0x667B670 | overloaded x2
        public void Init(){} // RVA: 0x667B830
        public void InitializeHandle(){} // RVA: 0x667B860
        public void Read(){} // RVA: 0x667BBB0 | overloaded x2
        public void ReadAsync(){} // RVA: 0x667BE90 | overloaded x2
        public void BeginRead(){} // RVA: 0x667C0F0
        public void EndRead(){} // RVA: 0x667C1F0
        public void Write(){} // RVA: 0x667C4C0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x667C7B0 | overloaded x2
        public void BeginWrite(){} // RVA: 0x667CA50
        public void EndWrite(){} // RVA: 0x667CB50
        public void CheckReadWriteArgs(){} // RVA: 0x667CB70
        public void ReadByte(){} // RVA: 0x667CD10
        public void WriteByte(){} // RVA: 0x667CD90
        public void Flush(){} // RVA: 0x667CE00
        public void Dispose(){} // RVA: 0x667CE60
        public void get_IsConnected(){} // RVA: 0x1B033B0
        public void get_IsAsync(){} // RVA: 0x14CEB40
        public void UpdateMessageCompletion(){} // RVA: 0x667CF00
        public void get_SafePipeHandle(){} // RVA: 0x667CF30
        public void get_InternalHandle(){} // RVA: 0x6374D0
        public void get_CanRead(){} // RVA: 0x4A6500
        public void get_CanWrite(){} // RVA: 0x4A7410
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_Length(){} // RVA: 0x667CFC0
        public void get_Position(){} // RVA: 0x667CFF0
        public void set_Position(){} // RVA: 0x667D020
        public void SetLength(){} // RVA: 0x667D050
        public void Seek(){} // RVA: 0x667D080
        public void CheckReadOperations(){} // RVA: 0x667D0B0
        public void CheckWriteOperations(){} // RVA: 0x667D1F0
        public void get_State(){} // RVA: 0x59C540
        public void set_State(){} // RVA: 0x65F570
        public void get_IsCurrentUserOnly(){} // RVA: 0x14C9240
        public void set_IsCurrentUserOnly(){} // RVA: 0x667D380
        public void GetAccessControl(){} // RVA: 0x667D390
        public void .cctor(){} // RVA: 0x667D4F0
    }

    public class PipeStreamImpersonationWorker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33B980
        public void Invoke(){} // RVA: 0x33BA50
    }

    public class ReadWriteCompletionSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x667D600
        public void SetCompletedSynchronously(){} // RVA: 0x667D6E0
        public void AsyncCallback(){} // RVA: 0x667D760
        public void HandleError(){} // RVA: 0x667D810
    }

    public class VoidResult
    {
    }

}