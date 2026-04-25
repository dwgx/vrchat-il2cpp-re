// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Pipes
// Classes: 10
// Methods: 103

namespace ThirdParty.DotNet.System.IO.Pipes
{
    public class ConnectionCompletionSource : PipeCompletionSource`1
    {
        public System.IO.Pipes.NamedPipeServerStream _serverStream; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E0E070
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAC8E0E140
        public void AsyncCallback(){} // RVA: 0x7FFAC8E0E1B0
        public void HandleError(){} // RVA: 0x7FFAC8E0E230
        public void HandleUnexpectedCancellation(){} // RVA: 0x7FFAC8E0E2E0
    }

    public class NamedPipeClientStream : PipeStream
    {
        public string _normalizedPipePath; // 0x58
        public 0x6B0CE0C8 _impersonationLevel; // 0x60
        public 0x6B1F8AE8 _pipeOptions; // 0x64
        public 0x6B1F84B8 _inheritability; // 0x68
        public 0x6B1F8A90 _direction; // 0x6C
        public int _access; // 0x70

        // ── Methods ──
        public void TryConnect(){} // RVA: 0x7FFAC8E0E3B0
        public void ValidateRemotePipeUser(){} // RVA: 0x7FFAC8E0E740
        public void .ctor(){} // RVA: 0x7FFAC8E0E8B0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8449EF0
        public void Connect(){} // RVA: 0x7FFAC8E0ECF0
        public void ConnectInternal(){} // RVA: 0x7FFAC8E0EE40
        public void CheckConnectOperationsClient(){} // RVA: 0x7FFAC8E0F020
    }

    public class NamedPipeServerStream : PipeStream
    {
        public TryCode tryCode;
        public CleanupCode cleanupCode; // 0x8
        public int MaxAllowedServerInstances;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC8E0F110 | overloaded x2
        public void WaitForConnection(){} // RVA: 0x7FFAC8E0F790
        public void Disconnect(){} // RVA: 0x7FFAC8E0FA40
        public void ImpersonateAndTryCode(){} // RVA: 0x7FFAC8E0FC80
        public void RevertImpersonationOnBackout(){} // RVA: 0x7FFAC8E0FEC0
        public void WaitForConnectionCoreAsync(){} // RVA: 0x7FFAC8E0FFF0
        public void CheckConnectOperationsServerWithHandle(){} // RVA: 0x7FFAC8E103D0
        public void .ctor(){} // RVA: 0x7FFAC8E10510 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8449EF0
        public void CheckConnectOperationsServer(){} // RVA: 0x7FFAC8E10880
        public void CheckDisconnectOperations(){} // RVA: 0x7FFAC8E10940
        public void .cctor(){} // RVA: 0x7FFAC8E10A80
    }

    public class PipeAccessRule : AccessRule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E10D60 | overloaded x2
        public void AccessMaskFromRights(){} // RVA: 0x7FFAC8E10E00
    }

    public class PipeCompletionSource`1 : TaskCompletionSource`1
    {
        public System.Threading.ThreadPoolBoundHandle Overlapped;
        public System.Threading.CancellationTokenRegistration _cancellationRegistration;
        public int _errorCode;
        public System.Threading.NativeOverlapped* _overlapped;
        public System.Buffers.MemoryHandle _pinnedMemory;
        public int _state;

        // ── Methods ──
        public void .ctor(){}
        public void get_Overlapped(){} // RVA: 0x7FFAC2E8DC40
        public void RegisterForCancellation(){} // RVA: 0x7FFAC2C70BF0
        public void ReleaseResources(){} // RVA: 0x7FFAC2C70980
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAC2C70980
        public void AsyncCallback(){}
        public void HandleError(){} // RVA: 0x7FFAC2C70ED0
        public void Cancel(){} // RVA: 0x7FFAC2C70980
        public void HandleUnexpectedCancellation(){} // RVA: 0x7FFAC2C70980
        public void CompleteCallback(){} // RVA: 0x7FFAC2C70ED0
    }

    public class PipeSecurity : NativeObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E10EE0 | overloaded x2
        public void AddAccessRule(){} // RVA: 0x7FFAC8E10FE0
    }

    public class PipeStream : Stream
    {
        public bool IsConnected;
        public System.Threading.ThreadPoolBoundHandle IsAsync; // 0x28
        public string SafePipeHandle;
        public System.Threading.Tasks.Task`1<int> InternalHandle;
        public Microsoft.Win32.SafeHandles.SafePipeHandle CanRead; // 0x30
        public bool CanWrite; // 0x38
        public bool CanSeek; // 0x39
        public bool Length; // 0x3A
        public bool Position; // 0x3B
        public bool State; // 0x3C
        public bool IsCurrentUserOnly; // 0x3D
        public bool _isHandleExposed; // 0x3E
        public 0x6B1F8C48 _readMode; // 0x40
        public 0x6B1F8C48 _transmissionMode; // 0x44
        public 0x6B1F8A90 _pipeDirection; // 0x48
        public int _outBufferSize; // 0x4C
        public 0x6B1F8B98 _state; // 0x50

        // ── Methods ──
        public void GetPipePath(){} // RVA: 0x7FFAC8E11070
        public void InitializeAsyncHandle(){} // RVA: 0x7FFAC8E11270
        public void DisposeCore(){} // RVA: 0x7FFAC8E11320
        public void ReadCore(){} // RVA: 0x7FFAC8E11340
        public void ReadAsyncCore(){} // RVA: 0x7FFAC8E11400
        public void WriteCore(){} // RVA: 0x7FFAC8E116D0
        public void WriteAsyncCore(){} // RVA: 0x7FFAC8E11740
        public void ReadFileNative(){} // RVA: 0x7FFAC8E11940
        public void WriteFileNative(){} // RVA: 0x7FFAC8E11B80
        public void GetSecAttrs(){} // RVA: 0x7FFAC8E11DF0 | overloaded x2
        public void WinIOError(){} // RVA: 0x7FFAC8E11E80
        public void .ctor(){} // RVA: 0x7FFAC8E12130 | overloaded x2
        public void Init(){} // RVA: 0x7FFAC8E122F0
        public void InitializeHandle(){} // RVA: 0x7FFAC8E12320
        public void Read(){} // RVA: 0x7FFAC8E12670 | overloaded x2
        public void ReadAsync(){} // RVA: 0x7FFAC8E12950 | overloaded x2
        public void BeginRead(){} // RVA: 0x7FFAC8E12BB0
        public void EndRead(){} // RVA: 0x7FFAC8E12CB0
        public void Write(){} // RVA: 0x7FFAC8E12F80 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFAC8E13270 | overloaded x2
        public void BeginWrite(){} // RVA: 0x7FFAC8E13510
        public void EndWrite(){} // RVA: 0x7FFAC8E13610
        public void CheckReadWriteArgs(){} // RVA: 0x7FFAC8E13630
        public void ReadByte(){} // RVA: 0x7FFAC8E137D0
        public void WriteByte(){} // RVA: 0x7FFAC8E13850
        public void Flush(){} // RVA: 0x7FFAC8E138C0
        public void Dispose(){} // RVA: 0x7FFAC8E13920
        public void get_IsConnected(){} // RVA: 0x7FFAC3ACBF60
        public void get_IsAsync(){} // RVA: 0x7FFAC3F7B7C0
        public void UpdateMessageCompletion(){} // RVA: 0x7FFAC8E139C0
        public void get_SafePipeHandle(){} // RVA: 0x7FFAC8E139F0
        public void get_InternalHandle(){} // RVA: 0x7FFAC31D95E0
        public void get_CanRead(){} // RVA: 0x7FFAC31D95D0
        public void get_CanWrite(){} // RVA: 0x7FFAC33BCE50
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_Length(){} // RVA: 0x7FFAC8E13A80
        public void get_Position(){} // RVA: 0x7FFAC8E13AB0
        public void set_Position(){} // RVA: 0x7FFAC8E13AE0
        public void SetLength(){} // RVA: 0x7FFAC8E13B10
        public void Seek(){} // RVA: 0x7FFAC8E13B40
        public void CheckReadOperations(){} // RVA: 0x7FFAC8E13B70
        public void CheckWriteOperations(){} // RVA: 0x7FFAC8E13CB0
        public void get_State(){} // RVA: 0x7FFAC30F10E0
        public void set_State(){} // RVA: 0x7FFAC31D9010
        public void get_IsCurrentUserOnly(){} // RVA: 0x7FFAC3F729F0
        public void set_IsCurrentUserOnly(){} // RVA: 0x7FFAC8E13E40
        public void GetAccessControl(){} // RVA: 0x7FFAC8E13E50
        public void .cctor(){} // RVA: 0x7FFAC8E13FB0
    }

    public class PipeStreamImpersonationWorker : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7F980
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    }

    public class ReadWriteCompletionSource : PipeCompletionSource`1
    {
        public bool _isWrite; // 0x68
        public System.IO.Pipes.PipeStream _pipeStream; // 0x70
        public bool _isMessageComplete; // 0x78
        public int _numBytes; // 0x7C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E140C0
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAC8E141A0
        public void AsyncCallback(){} // RVA: 0x7FFAC8E14220
        public void HandleError(){} // RVA: 0x7FFAC8E142D0
    }

    public class VoidResult : ValueType
    {
    }

}