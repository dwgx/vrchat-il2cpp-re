// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Pipes
// Classes: 10
// Methods: 103

namespace ThirdParty.DotNet.System.IO.Pipes
{
    public class ConnectionCompletionSource : PipeCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871B64A0
        public void SetCompletedSynchronously(){} // RVA: 0x7FFE871B6570
        public void AsyncCallback(){} // RVA: 0x7FFE871B65E0
        public void HandleError(){} // RVA: 0x7FFE871B6660
        public void HandleUnexpectedCancellation(){} // RVA: 0x7FFE871B6710
    }

    public class NamedPipeClientStream : PipeStream
    {
        // ── Methods ──
        public void TryConnect(){} // RVA: 0x7FFE871B67E0
        public void ValidateRemotePipeUser(){} // RVA: 0x7FFE871B6B70
        public void .ctor(){} // RVA: 0x7FFE871B6CE0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE867F3800
        public void Connect(){} // RVA: 0x7FFE871B7120
        public void ConnectInternal(){} // RVA: 0x7FFE871B7270
        public void CheckConnectOperationsClient(){} // RVA: 0x7FFE871B7450
    }

    public class NamedPipeServerStream : PipeStream
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE871B7540 | overloaded x2
        public void WaitForConnection(){} // RVA: 0x7FFE871B7BC0
        public void Disconnect(){} // RVA: 0x7FFE871B7E70
        public void ImpersonateAndTryCode(){} // RVA: 0x7FFE871B80B0
        public void RevertImpersonationOnBackout(){} // RVA: 0x7FFE871B82F0
        public void WaitForConnectionCoreAsync(){} // RVA: 0x7FFE871B8420
        public void CheckConnectOperationsServerWithHandle(){} // RVA: 0x7FFE871B8800
        public void .ctor(){} // RVA: 0x7FFE871B8940 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE867F3800
        public void CheckConnectOperationsServer(){} // RVA: 0x7FFE871B8CB0
        public void CheckDisconnectOperations(){} // RVA: 0x7FFE871B8D70
        public void .cctor(){} // RVA: 0x7FFE871B8EB0
    }

    public class PipeAccessRule : AccessRule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871B9190 | overloaded x2
        public void AccessMaskFromRights(){} // RVA: 0x7FFE871B9230
    }

    public class PipeCompletionSource`1 : TaskCompletionSource`1
    {
        public System.Threading.ThreadPoolBoundHandle _threadPoolBinding;

        // ── Methods ──
        public void .ctor(){}
        public void get_Overlapped(){} // RVA: 0x7FFE810A1420
        public void RegisterForCancellation(){} // RVA: 0x7FFE80E46250
        public void ReleaseResources(){} // RVA: 0x7FFE80E45FE0
        public void SetCompletedSynchronously(){} // RVA: 0x7FFE80E45FE0
        public void AsyncCallback(){}
        public void HandleError(){} // RVA: 0x7FFE80E46530
        public void Cancel(){} // RVA: 0x7FFE80E45FE0
        public void HandleUnexpectedCancellation(){} // RVA: 0x7FFE80E45FE0
        public void CompleteCallback(){} // RVA: 0x7FFE80E46530
    }

    public class PipeSecurity : NativeObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871B9310 | overloaded x2
        public void AddAccessRule(){} // RVA: 0x7FFE871B9410
    }

    public class PipeStream : Stream
    {
        public bool CheckOperationsRequiresSetHandle;
        public System.Threading.ThreadPoolBoundHandle _threadPoolBinding; // 0x28
        public string AnonymousPipeName;
        public System.Threading.Tasks.Task`1<int> s_zeroTask;
        public Microsoft.Win32.SafeHandles.SafePipeHandle _handle; // 0x30
        public bool _canRead; // 0x38
        public bool _canWrite; // 0x39
        public bool _isAsync; // 0x3A
        public bool _isCurrentUserOnly; // 0x3B
        public bool _isMessageComplete; // 0x3C
        public bool _isFromExistingHandle; // 0x3D

        // ── Methods ──
        public void GetPipePath(){} // RVA: 0x7FFE871B94A0
        public void InitializeAsyncHandle(){} // RVA: 0x7FFE871B96A0
        public void DisposeCore(){} // RVA: 0x7FFE871B9750
        public void ReadCore(){} // RVA: 0x7FFE871B9770
        public void ReadAsyncCore(){} // RVA: 0x7FFE871B9830
        public void WriteCore(){} // RVA: 0x7FFE871B9B00
        public void WriteAsyncCore(){} // RVA: 0x7FFE871B9B70
        public void ReadFileNative(){} // RVA: 0x7FFE871B9D70
        public void WriteFileNative(){} // RVA: 0x7FFE871B9FB0
        public void GetSecAttrs(){} // RVA: 0x7FFE871BA220 | overloaded x2
        public void WinIOError(){} // RVA: 0x7FFE871BA2B0
        public void .ctor(){} // RVA: 0x7FFE871BA560 | overloaded x2
        public void Init(){} // RVA: 0x7FFE871BA720
        public void InitializeHandle(){} // RVA: 0x7FFE871BA750
        public void Read(){} // RVA: 0x7FFE871BAAA0 | overloaded x2
        public void ReadAsync(){} // RVA: 0x7FFE871BAD80 | overloaded x2
        public void BeginRead(){} // RVA: 0x7FFE871BAFE0
        public void EndRead(){} // RVA: 0x7FFE871BB0E0
        public void Write(){} // RVA: 0x7FFE871BB3B0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFE871BB6A0 | overloaded x2
        public void BeginWrite(){} // RVA: 0x7FFE871BB940
        public void EndWrite(){} // RVA: 0x7FFE871BBA40
        public void CheckReadWriteArgs(){} // RVA: 0x7FFE871BBA60
        public void ReadByte(){} // RVA: 0x7FFE871BBC00
        public void WriteByte(){} // RVA: 0x7FFE871BBC80
        public void Flush(){} // RVA: 0x7FFE871BBCF0
        public void Dispose(){} // RVA: 0x7FFE871BBD50
        public void get_IsConnected(){} // RVA: 0x7FFE828ADCE0
        public void get_IsAsync(){} // RVA: 0x7FFE82230840
        public void UpdateMessageCompletion(){} // RVA: 0x7FFE871BBDF0
        public void get_SafePipeHandle(){} // RVA: 0x7FFE871BBE20
        public void get_InternalHandle(){} // RVA: 0x7FFE8144E200
        public void get_CanRead(){} // RVA: 0x7FFE812CF770
        public void get_CanWrite(){} // RVA: 0x7FFE812CF7D0
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_Length(){} // RVA: 0x7FFE871BBEB0
        public void get_Position(){} // RVA: 0x7FFE871BBEE0
        public void set_Position(){} // RVA: 0x7FFE871BBF10
        public void SetLength(){} // RVA: 0x7FFE871BBF40
        public void Seek(){} // RVA: 0x7FFE871BBF70
        public void CheckReadOperations(){} // RVA: 0x7FFE871BBFA0
        public void CheckWriteOperations(){} // RVA: 0x7FFE871BC0E0
        public void get_State(){} // RVA: 0x7FFE8139DAD0
        public void set_State(){} // RVA: 0x7FFE81463B00
        public void get_IsCurrentUserOnly(){} // RVA: 0x7FFE8222F780
        public void set_IsCurrentUserOnly(){} // RVA: 0x7FFE871BC270
        public void GetAccessControl(){} // RVA: 0x7FFE871BC280
        public void .cctor(){} // RVA: 0x7FFE871BC3E0
    }

    public class PipeStreamImpersonationWorker : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81159980
        public void Invoke(){} // RVA: 0x7FFE81159A50
    }

    public class ReadWriteCompletionSource : PipeCompletionSource`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871BC4F0
        public void SetCompletedSynchronously(){} // RVA: 0x7FFE871BC5D0
        public void AsyncCallback(){} // RVA: 0x7FFE871BC650
        public void HandleError(){} // RVA: 0x7FFE871BC700
    }

    public class VoidResult : ValueType
    {
    }

}