// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Pipes
// Classes: 11
// Methods: 112

namespace ThirdParty.DotNet.System.IO.Pipes
{
    public class ConnectionCompletionSource : PipeCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE465D20
        public void SetCompletedSynchronously(){} // RVA: 0x7AE465DF0
        public void AsyncCallback(){} // RVA: 0x7AE465E60
        public void HandleError(){} // RVA: 0x7AE465EE0
        public void HandleUnexpectedCancellation(){} // RVA: 0x7AE465F90
    }

    public class NamedPipeClientStream : PipeStream
    {
        // ── Methods ──
        public void TryConnect(){} // RVA: 0x7AE466060
        public void ValidateRemotePipeUser(){} // RVA: 0x7AE466400
        public void .ctor(){} // RVA: 0x7AE466570
        public void Finalize(){} // RVA: 0x7ADAA0970
        public void Connect(){} // RVA: 0x7AE4669B0
        public void ConnectInternal(){} // RVA: 0x7AE466B00
        public void CheckConnectOperationsClient(){} // RVA: 0x7AE466CE0
    }

    public class NamedPipeServerStream : PipeStream
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AE466DD0
        public void WaitForConnection(){} // RVA: 0x7AE467460
        public void Disconnect(){} // RVA: 0x7AE467710
        public void ImpersonateAndTryCode(){} // RVA: 0x7AE467950
        public void RevertImpersonationOnBackout(){} // RVA: 0x7AE467B90
        public void WaitForConnectionCoreAsync(){} // RVA: 0x7AE467CC0
        public void CheckConnectOperationsServerWithHandle(){} // RVA: 0x7AE4680B0
        public void .ctor(){} // RVA: 0x7AE4681F0
        public void Finalize(){} // RVA: 0x7ADAA0970
        public void CheckConnectOperationsServer(){} // RVA: 0x7AE468560
        public void CheckDisconnectOperations(){} // RVA: 0x7AE468620
        public void .cctor(){} // RVA: 0x7AE468760
    }

    public class PipeAccessRule : AccessRule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE468A40
        public void AccessMaskFromRights(){} // RVA: 0x7AE468AE0
    }

    public class PipeCompletionSource`1 : TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18890
        public void get_Overlapped(){} // RVA: 0x7A8051B10
        public void RegisterForCancellation(){} // RVA: 0x7A7E188D0
        public void ReleaseResources(){} // RVA: 0x7A7E18770
        public void SetCompletedSynchronously(){} // RVA: 0x7A7E18770
        public void AsyncCallback(){} // RVA: 0x7A7E1ABE0
        public void HandleError(){} // RVA: 0x7A7E189D0
        public void Cancel(){} // RVA: 0x7A7E18770
        public void HandleUnexpectedCancellation(){} // RVA: 0x7A7E18770
        public void CompleteCallback(){} // RVA: 0x7A7E189D0
    }

    public class PipeCompletionSource`1 : TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABBEB5B0
        public void get_Overlapped(){} // RVA: 0x7A8154D80
        public void RegisterForCancellation(){} // RVA: 0x7ABBEB8E0
        public void ReleaseResources(){} // RVA: 0x7ABBEB2F0
        public void SetCompletedSynchronously(){} // RVA: 0x7A7E18770
        public void AsyncCallback(){} // RVA: 0x7ABBEBB40
        public void HandleError(){} // RVA: 0x7A7E189D0
        public void Cancel(){} // RVA: 0x7ABBEBB70
        public void HandleUnexpectedCancellation(){} // RVA: 0x7ABBEBC10
        public void CompleteCallback(){} // RVA: 0x7ABBEBC30
    }

    public class PipeCompletionSource`1 : TaskCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABBEAD60
        public void get_Overlapped(){} // RVA: 0x7A8154D80
        public void RegisterForCancellation(){} // RVA: 0x7ABBEB090
        public void ReleaseResources(){} // RVA: 0x7ABBEB2F0
        public void SetCompletedSynchronously(){} // RVA: 0x7A7E18770
        public void AsyncCallback(){} // RVA: 0x7ABBEB340
        public void HandleError(){} // RVA: 0x7A7E189D0
        public void Cancel(){} // RVA: 0x7ABBEB370
        public void HandleUnexpectedCancellation(){} // RVA: 0x7ABBEB410
        public void CompleteCallback(){} // RVA: 0x7ABBEB430
    }

    public class PipeSecurity : NativeObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE468BC0
        public void AddAccessRule(){} // RVA: 0x7AE468CC0
    }

    public class PipeStream : Stream
    {
        // ── Methods ──
        public void GetPipePath(){} // RVA: 0x7AE468D50
        public void InitializeAsyncHandle(){} // RVA: 0x7AE468F50
        public void DisposeCore(){} // RVA: 0x7AE469000
        public void ReadCore(){} // RVA: 0x7AE469020
        public void ReadAsyncCore(){} // RVA: 0x7AE4690E0
        public void WriteCore(){} // RVA: 0x7AE4693B0
        public void WriteAsyncCore(){} // RVA: 0x7AE469420
        public void ReadFileNative(){} // RVA: 0x7AE469620
        public void WriteFileNative(){} // RVA: 0x7AE469860
        public void GetSecAttrs(){} // RVA: 0x7AE469AD0
        public void WinIOError(){} // RVA: 0x7AE469B60
        public void .ctor(){} // RVA: 0x7AE469E10
        public void Init(){} // RVA: 0x7AE469FD0
        public void InitializeHandle(){} // RVA: 0x7AE46A000
        public void Read(){} // RVA: 0x7AE46A360
        public void ReadAsync(){} // RVA: 0x7AE46A640
        public void BeginRead(){} // RVA: 0x7AE46A8A0
        public void EndRead(){} // RVA: 0x7AE46A9A0
        public void Write(){} // RVA: 0x7AE46AC70
        public void WriteAsync(){} // RVA: 0x7AE46AF60
        public void BeginWrite(){} // RVA: 0x7AE46B200
        public void EndWrite(){} // RVA: 0x7AE46B300
        public void CheckReadWriteArgs(){} // RVA: 0x7AE46B320
        public void ReadByte(){} // RVA: 0x7AE46B4C0
        public void WriteByte(){} // RVA: 0x7AE46B540
        public void Flush(){} // RVA: 0x7AE46B5B0
        public void Dispose(){} // RVA: 0x7AE46B610
        public void get_IsConnected(){} // RVA: 0x7A98BD6E0
        public void get_IsAsync(){} // RVA: 0x7A9286CF0
        public void UpdateMessageCompletion(){} // RVA: 0x7AE46B6B0
        public void get_SafePipeHandle(){} // RVA: 0x7AE46B6E0
        public void get_InternalHandle(){} // RVA: 0x7A83F69F0
        public void get_CanRead(){} // RVA: 0x7A82A20A0
        public void get_CanWrite(){} // RVA: 0x7A82A3DE0
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_Length(){} // RVA: 0x7AE46B770
        public void get_Position(){} // RVA: 0x7AE46B7A0
        public void set_Position(){} // RVA: 0x7AE46B7D0
        public void SetLength(){} // RVA: 0x7AE46B800
        public void Seek(){} // RVA: 0x7AE46B830
        public void CheckReadOperations(){} // RVA: 0x7AE46B860
        public void CheckWriteOperations(){} // RVA: 0x7AE46B9A0
        public void get_State(){} // RVA: 0x7A8355950
        public void set_State(){} // RVA: 0x7A83F4180
        public void get_IsCurrentUserOnly(){} // RVA: 0x7A9281370
        public void set_IsCurrentUserOnly(){} // RVA: 0x7AE46BB30
        public void GetAccessControl(){} // RVA: 0x7AE46BB40
        public void .cctor(){} // RVA: 0x7AE46BCA0
    }

    public class PipeStreamImpersonationWorker : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8135E00
        public void Invoke(){} // RVA: 0x7A8135ED0
    }

    public class ReadWriteCompletionSource : PipeCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE46BDB0
        public void SetCompletedSynchronously(){} // RVA: 0x7AE46BE90
        public void AsyncCallback(){} // RVA: 0x7AE46BF10
        public void HandleError(){} // RVA: 0x7AE46BFC0
    }

}