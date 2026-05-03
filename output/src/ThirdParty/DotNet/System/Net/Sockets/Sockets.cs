// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Sockets
// Classes: 15
// Methods: 326

namespace ThirdParty.DotNet.System.Net.Sockets
{
    public class IPPacketInformation : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE876EEF70
        public void GetHashCode(){} // RVA: 0x7FFE876EF040
    }

    public class IPv6MulticastOption : Object
    {
        public System.Net.IPAddress m_Group; // 0x10
        public long m_Interface; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876EF440 | overloaded x2
        public void set_Group(){} // RVA: 0x7FFE876EF500
        public void set_InterfaceIndex(){} // RVA: 0x7FFE876EF5B0
    }

    public class LingerOption : Object
    {
        public bool enabled; // 0x10
        public int lingerTime; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876EF080
        public void set_Enabled(){} // RVA: 0x7FFE811C55F0
        public void set_LingerTime(){} // RVA: 0x7FFE8164E0F0
    }

    public class MulticastOption : Object
    {
        public System.Net.IPAddress group; // 0x10
        public System.Net.IPAddress localAddress; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876EF150 | overloaded x2
        public void set_Group(){} // RVA: 0x7FFE810FCE30
        public void set_LocalAddress(){} // RVA: 0x7FFE876EF2C0
    }

    public class NetworkStream : Stream
    {
        public System.Net.Sockets.Socket _streamSocket; // 0x28
        public bool _ownsSocket; // 0x30
        public bool _readable; // 0x31
        public bool _writeable; // 0x32
        public int _closeTimeout; // 0x34
        public bool _cleanedUp; // 0x38
        public int _currentReadTimeout; // 0x3C
        public int _currentWriteTimeout; // 0x40
        public object field_8; // 0x5B9
        public object field_9; // 0x5BA

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876D6150 | overloaded x3
        public void get_CanRead(){} // RVA: 0x7FFE81121470
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE848700A0
        public void get_CanTimeout(){} // RVA: 0x7FFE811E0850
        public void get_ReadTimeout(){} // RVA: 0x7FFE876D6350
        public void set_ReadTimeout(){} // RVA: 0x7FFE876D63E0
        public void get_WriteTimeout(){} // RVA: 0x7FFE876D6480
        public void set_WriteTimeout(){} // RVA: 0x7FFE876D6510
        public void get_DataAvailable(){} // RVA: 0x7FFE876D65B0
        public void get_Length(){} // RVA: 0x7FFE876D6660
        public void get_Position(){} // RVA: 0x7FFE876D66B0
        public void set_Position(){} // RVA: 0x7FFE876D6700
        public void Seek(){} // RVA: 0x7FFE876D6750
        public void Read(){} // RVA: 0x7FFE876D6B40 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFE876D6E90
        public void Write(){} // RVA: 0x7FFE876D72B0 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFE876D75C0
        public void Close(){} // RVA: 0x7FFE876D7630
        public void Dispose(){} // RVA: 0x7FFE876D76B0
        public void Finalize(){} // RVA: 0x7FFE867F3800
        public void BeginRead(){} // RVA: 0x7FFE876D7730
        public void EndRead(){} // RVA: 0x7FFE876D7AF0
        public void BeginWrite(){} // RVA: 0x7FFE876D7D50
        public void EndWrite(){} // RVA: 0x7FFE876D8110
        public void ReadAsync(){} // RVA: 0x7FFE876D87C0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFE876D8EF0 | overloaded x2
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void FlushAsync(){} // RVA: 0x7FFE876D91B0
        public void SetLength(){} // RVA: 0x7FFE876D9250
        public void SetSocketTimeoutOption(){} // RVA: 0x7FFE876D92A0
        public void get_InternalSocket(){} // RVA: 0x7FFE876D95F0
    }

    public class SafeSocketHandle : SafeHandleMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876F2660
        public void ReleaseHandle(){} // RVA: 0x7FFE876F2790
        public void RegisterForBlockingSyscall(){} // RVA: 0x7FFE876F2F40
        public void UnRegisterForBlockingSyscall(){} // RVA: 0x7FFE876F33C0
        public void .cctor(){} // RVA: 0x7FFE876F3660
    }

    public class SendPacketsElement : Object
    {
    }

    public class Socket : Object
    {
        public System.EventHandler`1<System.Net.Sockets.SocketAsyncEventArgs> AcceptCompletedHandler;
        public System.EventHandler`1<System.Net.Sockets.SocketAsyncEventArgs> ReceiveCompletedHandler; // 0x8
        public System.EventHandler`1<System.Net.Sockets.SocketAsyncEventArgs> SendCompletedHandler; // 0x10
        public TaskSocketAsyncEventArgs`1<System.Net.Sockets.Socket> s_rentedSocketSentinel; // 0x18
        public Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel; // 0x20
        public System.Threading.Tasks.Task`1<int> s_zeroTask; // 0x28
        public CachedEventArgs _cachedTaskEventArgs; // 0x10
        public object s_InternalSyncObject; // 0x30
        public bool s_SupportsIPv4; // 0x38
        public bool s_SupportsIPv6; // 0x39
        public bool s_OSSupportsIPv6; // 0x3A
        public bool s_Initialized; // 0x3B
        public bool s_LoggingEnabled; // 0x3C
        public bool s_PerfCountersEnabled; // 0x3D
        public int DefaultCloseTimeout;
        public int SOCKET_CLOSED_CODE;
        public string TIMEOUT_EXCEPTION_MSG;
        public bool is_closed; // 0x18
        public bool is_listening; // 0x19
        public bool useOverlappedIO; // 0x1A
        public int linger_timeout; // 0x1C
        public 0x6653960C addressFamily; // 0x20

        // ── Methods ──
        public void ConnectAsync(){} // RVA: 0x7FFE876D9690
        public void ReceiveAsync(){} // RVA: 0x7FFE876E2860 | overloaded x2
        public void ReceiveAsyncApm(){} // RVA: 0x7FFE876D9D80
        public void SendAsyncForNetworkStream(){} // RVA: 0x7FFE876DA3E0
        public void SendAsyncApm(){} // RVA: 0x7FFE876DA8E0
        public void CompleteAccept(){} // RVA: 0x7FFE876DAEE0
        public void CompleteSendReceive(){} // RVA: 0x7FFE876DB1A0
        public void GetException(){} // RVA: 0x7FFE876DB420
        public void ReturnSocketAsyncEventArgs(){} // RVA: 0x7FFE876DB640 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE876DDA30 | overloaded x2
        public void get_OSSupportsIPv4(){} // RVA: 0x7FFE876DBAE0
        public void get_OSSupportsIPv6(){} // RVA: 0x7FFE876DBB40
        public void get_Handle(){} // RVA: 0x7FFE87582E90
        public void get_AddressFamily(){} // RVA: 0x7FFE8151D690
        public void get_SocketType(){} // RVA: 0x7FFE81A56130
        public void get_ProtocolType(){} // RVA: 0x7FFE81549710
        public void get_ExclusiveAddressUse(){} // RVA: 0x7FFE876DBBA0
        public void set_ExclusiveAddressUse(){} // RVA: 0x7FFE876DBC20
        public void set_ReceiveTimeout(){} // RVA: 0x7FFE876DBCC0
        public void set_SendTimeout(){} // RVA: 0x7FFE876DBD50
        public void set_DontFragment(){} // RVA: 0x7FFE876DBDE0
        public void get_DualMode(){} // RVA: 0x7FFE876DBE80
        public void set_DualMode(){} // RVA: 0x7FFE876DBF70
        public void get_IsDualMode(){} // RVA: 0x7FFE876DC010
        public void CanTryAddressFamily(){} // RVA: 0x7FFE876DC100
        public void Connect(){} // RVA: 0x7FFE876E0120 | overloaded x4
        public void Send(){} // RVA: 0x7FFE876E40C0 | overloaded x7
        public void Receive(){} // RVA: 0x7FFE876E26E0 | overloaded x8
        public void IOControl(){} // RVA: 0x7FFE876E6E90 | overloaded x2
        public void SetIPProtectionLevel(){} // RVA: 0x7FFE876DCB00
        public void BeginConnect(){} // RVA: 0x7FFE876E0A00 | overloaded x4
        public void BeginSend(){} // RVA: 0x7FFE876E4D20 | overloaded x2
        public void EndSend(){} // RVA: 0x7FFE876E54D0 | overloaded x2
        public void BeginReceive(){} // RVA: 0x7FFE876E2D90 | overloaded x2
        public void EndReceive(){} // RVA: 0x7FFE876E3070 | overloaded x2
        public void get_InternalSyncObject(){} // RVA: 0x7FFE876DD280
        public void get_CleanedUp(){} // RVA: 0x7FFE81F18160
        public void InitializeSockets(){} // RVA: 0x7FFE876DD3B0
        public void Dispose(){} // RVA: 0x7FFE876E7680 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE865ED780
        public void InternalShutdown(){} // RVA: 0x7FFE876DD840
        public void SetSocketOption(){} // RVA: 0x7FFE876E6BD0 | overloaded x4
        public void SocketDefaults(){} // RVA: 0x7FFE876DDC10
        public void Socket_icall(){} // RVA: 0x7FFE876DDC80
        public void get_Available(){} // RVA: 0x7FFE876DDE30
        public void Available_internal(){} // RVA: 0x7FFE876DDEE0
        public void Available_icall(){} // RVA: 0x7FFE876DE000
        public void get_IsBound(){} // RVA: 0x7FFE82976380
        public void get_LocalEndPoint(){} // RVA: 0x7FFE876DE010
        public void LocalEndPoint_internal(){} // RVA: 0x7FFE876DE110
        public void LocalEndPoint_icall(){} // RVA: 0x7FFE876DE240
        public void get_Blocking(){} // RVA: 0x7FFE811B58E0
        public void set_Blocking(){} // RVA: 0x7FFE876DE250
        public void Blocking_internal(){} // RVA: 0x7FFE876DE320
        public void Blocking_icall(){} // RVA: 0x7FFE876DE440
        public void get_Connected(){} // RVA: 0x7FFE82976140
        public void set_NoDelay(){} // RVA: 0x7FFE876DE590
        public void get_RemoteEndPoint(){} // RVA: 0x7FFE876DE620
        public void RemoteEndPoint_internal(){} // RVA: 0x7FFE876DE730
        public void RemoteEndPoint_icall(){} // RVA: 0x7FFE876DE860
        public void Poll(){} // RVA: 0x7FFE876DE870
        public void Poll_internal(){} // RVA: 0x7FFE876DEA20
        public void Poll_icall(){} // RVA: 0x7FFE876DEB70
        public void Accept(){} // RVA: 0x7FFE876DED20 | overloaded x2
        public void AcceptAsync(){} // RVA: 0x7FFE876DEEF0
        public void BeginAccept(){} // RVA: 0x7FFE876DF210
        public void EndAccept(){} // RVA: 0x7FFE876DF500 | overloaded x2
        public void Accept_internal(){} // RVA: 0x7FFE876DF660
        public void Accept_icall(){} // RVA: 0x7FFE876DF800
        public void Bind(){} // RVA: 0x7FFE876DF8A0
        public void Bind_internal(){} // RVA: 0x7FFE876DFA90
        public void Bind_icall(){} // RVA: 0x7FFE876DFBB0
        public void Listen(){} // RVA: 0x7FFE876DFBC0
        public void Listen_internal(){} // RVA: 0x7FFE876DFCD0
        public void Listen_icall(){} // RVA: 0x7FFE876DFF10
        public void BeginMConnect(){} // RVA: 0x7FFE876E0CB0
        public void BeginSConnect(){} // RVA: 0x7FFE876E0EB0
        public void EndConnect(){} // RVA: 0x7FFE876E1500
        public void Connect_internal(){} // RVA: 0x7FFE876E15C0
        public void Connect_icall(){} // RVA: 0x7FFE876E16D0
        public void Disconnect(){} // RVA: 0x7FFE876E16E0
        public void EndDisconnect(){} // RVA: 0x7FFE876E17F0
        public void Disconnect_internal(){} // RVA: 0x7FFE876E18B0
        public void Disconnect_icall(){} // RVA: 0x7FFE876E1AE0
        public void Receive_internal(){} // RVA: 0x7FFE876E32B0 | overloaded x2
        public void Receive_array_icall(){} // RVA: 0x7FFE876E32A0
        public void Receive_icall(){} // RVA: 0x7FFE876E33E0
        public void ReceiveFrom(){} // RVA: 0x7FFE876E33F0
        public void BeginReceiveFrom(){} // RVA: 0x7FFE876E3790
        public void EndReceiveFrom(){} // RVA: 0x7FFE876E3B10
        public void EndReceiveFrom_internal(){} // RVA: 0x7FFE876E3C90
        public void ReceiveFrom_internal(){} // RVA: 0x7FFE876E3DC0
        public void ReceiveFrom_icall(){} // RVA: 0x7FFE876E3F00
        public void SendAsync(){} // RVA: 0x7FFE876E46E0
        public void BeginSendCallback(){} // RVA: 0x7FFE876E5110
        public void Send_internal(){} // RVA: 0x7FFE876E5710 | overloaded x2
        public void Send_array_icall(){} // RVA: 0x7FFE876E5700
        public void Send_icall(){} // RVA: 0x7FFE876E5840
        public void SendTo(){} // RVA: 0x7FFE876E5850
        public void BeginSendTo(){} // RVA: 0x7FFE876E5BD0
        public void BeginSendToCallback(){} // RVA: 0x7FFE876E5FE0
        public void EndSendTo(){} // RVA: 0x7FFE876E61C0
        public void SendTo_internal(){} // RVA: 0x7FFE876E6290
        public void SendTo_icall(){} // RVA: 0x7FFE876E63D0
        public void GetSocketOption(){} // RVA: 0x7FFE876E63E0
        public void GetSocketOption_obj_internal(){} // RVA: 0x7FFE876E6610
        public void GetSocketOption_obj_icall(){} // RVA: 0x7FFE876E6750
        public void SetSocketOption_internal(){} // RVA: 0x7FFE876E6D10
        public void SetSocketOption_icall(){} // RVA: 0x7FFE876E6E80
        public void IOControl_internal(){} // RVA: 0x7FFE876E7030
        public void IOControl_icall(){} // RVA: 0x7FFE876E7180
        public void Close(){} // RVA: 0x7FFE876E71A0 | overloaded x2
        public void Close_icall(){} // RVA: 0x7FFE876E71B0
        public void Shutdown(){} // RVA: 0x7FFE876E7300
        public void Shutdown_internal(){} // RVA: 0x7FFE876E7410
        public void Shutdown_icall(){} // RVA: 0x7FFE876E7530
        public void Linger(){} // RVA: 0x7FFE876E7990
        public void ThrowIfDisposedAndClosed(){} // RVA: 0x7FFE876E7C30
        public void ThrowIfBufferNull(){} // RVA: 0x7FFE876E7CC0
        public void ThrowIfBufferOutOfRange(){} // RVA: 0x7FFE876E7D20
        public void ThrowIfUdp(){} // RVA: 0x7FFE876E7EE0
        public void ValidateEndIAsyncResult(){} // RVA: 0x7FFE876E7F40
        public void QueueIOSelectorJob(){} // RVA: 0x7FFE876E80B0
        public void InitSocketAsyncEventArgs(){} // RVA: 0x7FFE876E82E0
        public void SocketOperationToSocketAsyncOperation(){} // RVA: 0x7FFE876E85A0
        public void RemapIPEndPoint(){} // RVA: 0x7FFE876E86D0
        public void cancel_blocking_socket_operation(){} // RVA: 0x7FFE876E8900
        public void get_FamilyHint(){} // RVA: 0x7FFE876E89A0
        public void IsProtocolSupported_internal(){} // RVA: 0x7FFE811E0850
        public void IsProtocolSupported(){} // RVA: 0x7FFE876E8AE0
        public void .cctor(){} // RVA: 0x7FFE876E8B30
    }

    public class SocketAsyncEventArgs : EventArgs
    {
        public bool disposed; // 0x10
        public int in_progress; // 0x14
        public System.Net.EndPoint remote_ep; // 0x18
        public System.Net.Sockets.Socket current_socket; // 0x20
        public System.Net.Sockets.SocketAsyncResult socket_async_result; // 0x28
        public System.Exception _connectByNameError; // 0x30
        public System.Net.Sockets.Socket _acceptSocket; // 0x38
        public int _bytesTransferred; // 0x40
        public bool _disconnectReuseSocket; // 0x44
        public 0x66539924 _lastOperation; // 0x48
        public System.Net.Sockets.IPPacketInformation _receiveMessageFromPacketInfo; // 0x50
        public System.Net.Sockets.SendPacketsElement[] _sendPacketsElements; // 0x60
        public 0x66539C94 _sendPacketsFlags; // 0x68
        public int _sendPacketsSendSize; // 0x6C

        // ── Methods ──
        public void get_AcceptSocket(){} // RVA: 0x7FFE8143BA80
        public void set_AcceptSocket(){} // RVA: 0x7FFE81437330
        public void get_BytesTransferred(){} // RVA: 0x7FFE8119C080
        public void set_BytesTransferred(){} // RVA: 0x7FFE8119C090
        public void set_LastOperation(){} // RVA: 0x7FFE8119C0D0
        public void set_RemoteEndPoint(){} // RVA: 0x7FFE81161E80
        public void set_SendPacketsSendSize(){} // RVA: 0x7FFE82A22F20
        public void get_SocketError(){} // RVA: 0x7FFE81E60180
        public void set_SocketError(){} // RVA: 0x7FFE81293CF0
        public void set_SocketFlags(){} // RVA: 0x7FFE82B1F9C0
        public void get_UserToken(){} // RVA: 0x7FFE81463AE0
        public void set_UserToken(){} // RVA: 0x7FFE81464570
        public void add_Completed(){} // RVA: 0x7FFE876F3730
        public void remove_Completed(){} // RVA: 0x7FFE876F3830
        public void .ctor(){} // RVA: 0x7FFE876F39F0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE876F3AB0
        public void Dispose(){} // RVA: 0x7FFE876F3AE0 | overloaded x2
        public void SetBytesTransferred(){} // RVA: 0x7FFE8119C090
        public void get_CurrentSocket(){} // RVA: 0x7FFE811290C0
        public void SetCurrentSocket(){} // RVA: 0x7FFE811290D0
        public void SetLastOperation(){} // RVA: 0x7FFE876F3B40
        public void Complete_internal(){} // RVA: 0x7FFE876F3C00
        public void OnCompleted(){} // RVA: 0x7FFE876F3C30
        public void get_Buffer(){} // RVA: 0x7FFE876F3C60
        public void get_MemoryBuffer(){} // RVA: 0x7FFE8621CDA0
        public void get_Offset(){} // RVA: 0x7FFE82B06A40
        public void get_Count(){} // RVA: 0x7FFE82B06F90
        public void get_BufferList(){} // RVA: 0x7FFE817AB5E0
        public void SetBuffer(){} // RVA: 0x7FFE876F3F70 | overloaded x2
    }

    public class SocketAsyncResult : IOAsyncResult
    {
        public System.Net.Sockets.Socket socket; // 0x30
        public 0x66539EFC operation; // 0x38

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFE876F40A0
        public void .ctor(){} // RVA: 0x7FFE876F44D0 | overloaded x2
        public void Init(){} // RVA: 0x7FFE876F40D0
        public void get_ErrorCode(){} // RVA: 0x7FFE876F45F0
        public void CheckIfThrowDelayedException(){} // RVA: 0x7FFE876F4690
        public void CompleteDisposed(){} // RVA: 0x7FFE876F4740
        public void Complete(){} // RVA: 0x7FFE876F4B40 | overloaded x7
    }

    public class SocketException : Win32Exception
    {
        public System.Net.EndPoint m_EndPoint; // 0x98
        public object field_1; // 0x5DA
        public object field_2; // 0x5DB

        // ── Methods ──
        public void WSAGetLastError_icall(){} // RVA: 0x7FFE876EEE40
        public void .ctor(){} // RVA: 0x7FFE8765BC90 | overloaded x5
        public void get_ErrorCode(){} // RVA: 0x7FFE814AA220
        public void get_Message(){} // RVA: 0x7FFE876EEED0
        public void get_SocketErrorCode(){} // RVA: 0x7FFE814AA220
    }

    public class TcpClient : Object
    {
        public System.Net.Sockets.Socket m_ClientSocket; // 0x10
        public bool m_Active; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876EF9E0 | overloaded x4
        public void get_Client(){} // RVA: 0x7FFE81116380
        public void set_Client(){} // RVA: 0x7FFE810FCE30
        public void get_Connected(){} // RVA: 0x7FFE876EFA40
        public void Connect(){} // RVA: 0x7FFE876F01D0 | overloaded x2
        public void BeginConnect(){} // RVA: 0x7FFE876F02C0
        public void EndConnect(){} // RVA: 0x7FFE876F02F0
        public void ConnectAsync(){} // RVA: 0x7FFE876F0320
        public void GetStream(){} // RVA: 0x7FFE876F04E0
        public void Close(){} // RVA: 0x7FFE876F0650
        public void Dispose(){} // RVA: 0x7FFE81148FC0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE865ED780
        public void initialize(){} // RVA: 0x7FFE876F0840
    }

    public class TcpListener : Object
    {
        public System.Net.IPEndPoint m_ServerSocketEP; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876F0910
        public void get_LocalEndpoint(){} // RVA: 0x7FFE876F0B80
        public void Start(){} // RVA: 0x7FFE876F0BC0 | overloaded x2
        public void Stop(){} // RVA: 0x7FFE876F0CF0
        public void BeginAcceptTcpClient(){} // RVA: 0x7FFE876F0E90
        public void EndAcceptTcpClient(){} // RVA: 0x7FFE876F0F20
    }

    public class UdpClient : Object
    {
        public System.Net.Sockets.Socket m_ClientSocket; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876F10D0
        public void get_Client(){} // RVA: 0x7FFE81116380
        public void set_Client(){} // RVA: 0x7FFE810FCE30
        public void FreeResources(){} // RVA: 0x7FFE876F1310
        public void Dispose(){} // RVA: 0x7FFE876F1370 | overloaded x2
        public void CheckForBroadcast(){} // RVA: 0x7FFE876F1410
        public void IsBroadcast(){} // RVA: 0x7FFE876F14F0
        public void BeginSend(){} // RVA: 0x7FFE876F1580
        public void EndSend(){} // RVA: 0x7FFE876F1890
        public void BeginReceive(){} // RVA: 0x7FFE876F1950
        public void EndReceive(){} // RVA: 0x7FFE876F1AB0
        public void SendAsync(){} // RVA: 0x7FFE876F1E70
        public void ReceiveAsync(){} // RVA: 0x7FFE876F1FE0
        public void createClientSocket(){} // RVA: 0x7FFE876F2120
        public void <ReceiveAsync>b__65_0(){} // RVA: 0x7FFE876F1950
        public void <ReceiveAsync>b__65_1(){} // RVA: 0x7FFE876F21F0
    }

    public class UdpReceiveResult : ValueType
    {
        public byte[] m_buffer; // 0x10
        public System.Net.IPEndPoint m_remoteEndPoint; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876F2380
        public void get_Buffer(){} // RVA: 0x7FFE8284EF60
        public void get_RemoteEndPoint(){} // RVA: 0x7FFE826F4210
        public void GetHashCode(){} // RVA: 0x7FFE876F24F0
        public void Equals(){} // RVA: 0x7FFE84D23B90 | overloaded x2
    }

}