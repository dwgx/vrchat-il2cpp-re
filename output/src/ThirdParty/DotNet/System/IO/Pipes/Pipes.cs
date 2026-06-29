// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Pipes
// Classes: 11
// Methods: 112

namespace ThirdParty.DotNet.System.IO.Pipes
{
    public class ConnectionCompletionSource : PipeCompletionSource`1
    {
        public object _serverStream;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70E1E40
        public void SetCompletedSynchronously(){} // RVA: 0x70E1F10
        public void AsyncCallback(){} // RVA: 0x70E1F80
        public void HandleError(){} // RVA: 0x70E2000
        public void HandleUnexpectedCancellation(){} // RVA: 0x70E20B0
    }

    public class NamedPipeClientStream : PipeStream
    {
        public object _normalizedPipePath;
        public object _impersonationLevel;
        public object _pipeOptions;
        public object _inheritability;
        public object _direction;
        public object _access;

        // ── Methods ──
        public void TryConnect(){} // RVA: 0x70E2180
        public void ValidateRemotePipeUser(){} // RVA: 0x70E2520
        public void .ctor(){} // RVA: 0x70E2680
        public void Finalize(){} // RVA: 0x672B280
        public void Connect(){} // RVA: 0x70E2AC0
        public void ConnectInternal(){} // RVA: 0x70E2C10
        public void CheckConnectOperationsClient(){} // RVA: 0x70E2DF0
    }

    public class NamedPipeServerStream : PipeStream
    {
        public object tryCode;
        public object cleanupCode;
        public object MaxAllowedServerInstances;

        // ── Methods ──
        public void Create(){} // RVA: 0x70E2EE0
        public void WaitForConnection(){} // RVA: 0x70E3570
        public void Disconnect(){} // RVA: 0x70E3820
        public void ImpersonateAndTryCode(){} // RVA: 0x70E3A60
        public void RevertImpersonationOnBackout(){} // RVA: 0x70E3CA0
        public void WaitForConnectionCoreAsync(){} // RVA: 0x70E3DD0
        public void CheckConnectOperationsServerWithHandle(){} // RVA: 0x70E41C0
        public void .ctor(){} // RVA: 0x70E4300
        public void Finalize(){} // RVA: 0x672B280
        public void CheckConnectOperationsServer(){} // RVA: 0x70E4670
        public void CheckDisconnectOperations(){} // RVA: 0x70E4730
        public void .cctor(){} // RVA: 0x70E4870
    }

    public class PipeAccessRule : AccessRule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70E4B50
        public void AccessMaskFromRights(){} // RVA: 0x70E4BF0
    }

    public class PipeCompletionSource`1 : TaskCompletionSource`1
    {
        public object _threadPoolBinding;
        public object _cancellationRegistration;
        public object _errorCode;
        public object _overlapped;
        public object _pinnedMemory;
        public object _state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8943B0
        public void get_Overlapped(){} // RVA: 0xA94080
        public void RegisterForCancellation(){} // RVA: 0x8943F0
        public void ReleaseResources(){} // RVA: 0x894290
        public void SetCompletedSynchronously(){} // RVA: 0x894290
        public void AsyncCallback(){} // RVA: 0x8965E0
        public void HandleError(){} // RVA: 0x8944F0
        public void Cancel(){} // RVA: 0x894290
        public void HandleUnexpectedCancellation(){} // RVA: 0x894290
        public void CompleteCallback(){} // RVA: 0x8944F0
    }

    public class PipeCompletionSource`1 : TaskCompletionSource`1
    {
        public object _threadPoolBinding;
        public object _cancellationRegistration;
        public object _errorCode;
        public object _overlapped;
        public object _pinnedMemory;
        public object _state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x485E320
        public void get_Overlapped(){} // RVA: 0xBC1B30
        public void RegisterForCancellation(){} // RVA: 0x485E650
        public void ReleaseResources(){} // RVA: 0x485E060
        public void SetCompletedSynchronously(){} // RVA: 0x894290
        public void AsyncCallback(){} // RVA: 0x485E8B0
        public void HandleError(){} // RVA: 0x8944F0
        public void Cancel(){} // RVA: 0x485E8E0
        public void HandleUnexpectedCancellation(){} // RVA: 0x485E980
        public void CompleteCallback(){} // RVA: 0x485E9A0
    }

    public class PipeCompletionSource`1 : TaskCompletionSource`1
    {
        public object _threadPoolBinding;
        public object _cancellationRegistration;
        public object _errorCode;
        public object _overlapped;
        public object _pinnedMemory;
        public object _state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x485DAD0
        public void get_Overlapped(){} // RVA: 0xBC1B30
        public void RegisterForCancellation(){} // RVA: 0x485DE00
        public void ReleaseResources(){} // RVA: 0x485E060
        public void SetCompletedSynchronously(){} // RVA: 0x894290
        public void AsyncCallback(){} // RVA: 0x485E0B0
        public void HandleError(){} // RVA: 0x8944F0
        public void Cancel(){} // RVA: 0x485E0E0
        public void HandleUnexpectedCancellation(){} // RVA: 0x485E180
        public void CompleteCallback(){} // RVA: 0x485E1A0
    }

    public class PipeSecurity : NativeObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70E4CD0
        public void AddAccessRule(){} // RVA: 0x70E4DD0
    }

    public class PipeStream : Stream
    {
        public object CheckOperationsRequiresSetHandle;
        public object _threadPoolBinding;
        public object AnonymousPipeName;
        public object s_zeroTask;
        public object _handle;
        public object _canRead;
        public object _canWrite;
        public object _isAsync;
        public object _isCurrentUserOnly;
        public object _isMessageComplete;
        public object _isFromExistingHandle;
        public object _isHandleExposed;
        public object _readMode;
        public object _transmissionMode;
        public object _pipeDirection;
        public object _outBufferSize;
        public object _state;

        // ── Methods ──
        public void GetPipePath(){} // RVA: 0x70E4E60
        public void InitializeAsyncHandle(){} // RVA: 0x70E5060
        public void DisposeCore(){} // RVA: 0x70E5110
        public void ReadCore(){} // RVA: 0x70E5130
        public void ReadAsyncCore(){} // RVA: 0x70E51E0
        public void WriteCore(){} // RVA: 0x70E54B0
        public void WriteAsyncCore(){} // RVA: 0x70E5520
        public void ReadFileNative(){} // RVA: 0x70E5720
        public void WriteFileNative(){} // RVA: 0x70E5960
        public void GetSecAttrs(){} // RVA: 0x70E5BD0
        public void WinIOError(){} // RVA: 0x70E5C60
        public void .ctor(){} // RVA: 0x70E5F10
        public void Init(){} // RVA: 0x70E60D0
        public void InitializeHandle(){} // RVA: 0x70E6100
        public void Read(){} // RVA: 0x70E6460
        public void ReadAsync(){} // RVA: 0x70E6740
        public void BeginRead(){} // RVA: 0x70E69A0
        public void EndRead(){} // RVA: 0x70E6AA0
        public void Write(){} // RVA: 0x70E6D70
        public void WriteAsync(){} // RVA: 0x70E7060
        public void BeginWrite(){} // RVA: 0x70E7300
        public void EndWrite(){} // RVA: 0x70E7400
        public void CheckReadWriteArgs(){} // RVA: 0x70E7420
        public void ReadByte(){} // RVA: 0x70E75C0
        public void WriteByte(){} // RVA: 0x70E7640
        public void Flush(){} // RVA: 0x70E76B0
        public void Dispose(){} // RVA: 0x70E7710
        public void get_IsConnected(){} // RVA: 0x23ED3F0
        public void get_IsAsync(){} // RVA: 0x1DC2880
        public void UpdateMessageCompletion(){} // RVA: 0x70E77B0
        public void get_SafePipeHandle(){} // RVA: 0x70E77E0
        public void get_InternalHandle(){} // RVA: 0xD33E60
        public void get_CanRead(){} // RVA: 0xD16660
        public void get_CanWrite(){} // RVA: 0xD15320
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_Length(){} // RVA: 0x70E7870
        public void get_Position(){} // RVA: 0x70E78A0
        public void set_Position(){} // RVA: 0x70E78D0
        public void SetLength(){} // RVA: 0x70E7900
        public void Seek(){} // RVA: 0x70E7930
        public void CheckReadOperations(){} // RVA: 0x70E7960
        public void CheckWriteOperations(){} // RVA: 0x70E7AA0
        public void get_State(){} // RVA: 0xE32C80
        public void set_State(){} // RVA: 0xEEA060
        public void get_IsCurrentUserOnly(){} // RVA: 0x1D92F50
        public void set_IsCurrentUserOnly(){} // RVA: 0x70E7C30
        public void GetAccessControl(){} // RVA: 0x70E7C40
        public void .cctor(){} // RVA: 0x70E7DA0
    }

    public class PipeStreamImpersonationWorker : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA0FE0
        public void Invoke(){} // RVA: 0xBA10B0
    }

    public class ReadWriteCompletionSource : PipeCompletionSource`1
    {
        public object _isWrite;
        public object _pipeStream;
        public object _isMessageComplete;
        public object _numBytes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70E7EB0
        public void SetCompletedSynchronously(){} // RVA: 0x70E7F90
        public void AsyncCallback(){} // RVA: 0x70E8010
        public void HandleError(){} // RVA: 0x70E80C0
    }

}