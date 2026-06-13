// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Sockets
// Classes: 15
// Methods: 326

namespace ThirdParty.DotNet.System.Net.Sockets
{
    public class IPPacketInformation
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x6BAFCC0
        public void GetHashCode(){} // RVA: 0x6BAFD90
    }

    public class IPv6MulticastOption
    {
        public System.Net.IPAddress m_Group; // 0x10
        public long m_Interface; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BB0190 | overloaded x2
        public void set_Group(){} // RVA: 0x6BB0250
        public void set_InterfaceIndex(){} // RVA: 0x6BB0300
    }

    public class LingerOption
    {
        public bool Group; // 0x10
        public int LocalAddress; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BAFDD0
        public void set_Enabled(){} // RVA: 0x3A75F0
        public void set_LingerTime(){} // RVA: 0x8AC660
    }

    public class MulticastOption
    {
        public System.Net.IPAddress Group; // 0x10
        public System.Net.IPAddress InterfaceIndex; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BAFEA0 | overloaded x2
        public void set_Group(){} // RVA: 0x2DEE30
        public void set_LocalAddress(){} // RVA: 0x6BB0010
    }

    public class NetworkStream
    {
        public System.Net.Sockets.Socket _streamSocket; // 0x28
        public bool _ownsSocket; // 0x30
        public bool _readable; // 0x31
        public bool _writeable; // 0x32
        public int _closeTimeout; // 0x34
        public bool _cleanedUp; // 0x38
        public int _currentReadTimeout; // 0x3C
        public int _currentWriteTimeout; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B96EA0 | overloaded x3
        public void get_CanRead(){} // RVA: 0x303470
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x3BE7520
        public void get_CanTimeout(){} // RVA: 0x3C2850
        public void get_ReadTimeout(){} // RVA: 0x6B970A0
        public void set_ReadTimeout(){} // RVA: 0x6B97130
        public void get_WriteTimeout(){} // RVA: 0x6B971D0
        public void set_WriteTimeout(){} // RVA: 0x6B97260
        public void get_DataAvailable(){} // RVA: 0x6B97300
        public void get_Length(){} // RVA: 0x6B973B0
        public void get_Position(){} // RVA: 0x6B97400
        public void set_Position(){} // RVA: 0x6B97450
        public void Seek(){} // RVA: 0x6B974A0
        public void Read(){} // RVA: 0x6B97890 | overloaded x2
        public void ReadByte(){} // RVA: 0x6B97BE0
        public void Write(){} // RVA: 0x6B98000 | overloaded x2
        public void WriteByte(){} // RVA: 0x6B98310
        public void Close(){} // RVA: 0x6B98380
        public void Dispose(){} // RVA: 0x6B98400
        public void Finalize(){} // RVA: 0x5CB2900
        public void BeginRead(){} // RVA: 0x6B98480
        public void EndRead(){} // RVA: 0x6B98840
        public void BeginWrite(){} // RVA: 0x6B98AA0
        public void EndWrite(){} // RVA: 0x6B98E60
        public void ReadAsync(){} // RVA: 0x6B99510 | overloaded x2
        public void WriteAsync(){} // RVA: 0x6B99C40 | overloaded x2
        public void Flush(){} // RVA: 0x2DD310
        public void FlushAsync(){} // RVA: 0x6B99F00
        public void SetLength(){} // RVA: 0x6B99FA0
        public void SetSocketTimeoutOption(){} // RVA: 0x6B99FF0
        public void get_InternalSocket(){} // RVA: 0x6B9A340
    }

    public class SafeSocketHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BB33B0
        public void ReleaseHandle(){} // RVA: 0x6BB34E0
        public void RegisterForBlockingSyscall(){} // RVA: 0x6BB3C90
        public void UnRegisterForBlockingSyscall(){} // RVA: 0x6BB4110
        public void .cctor(){} // RVA: 0x6BB43B0
    }

    public class SendPacketsElement
    {
    }

    public class Socket
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
        public 0x6585B668 addressFamily; // 0x20

        // ── Methods ──
        public void ConnectAsync(){} // RVA: 0x6B9A3E0
        public void ReceiveAsync(){} // RVA: 0x6BA35B0 | overloaded x2
        public void ReceiveAsyncApm(){} // RVA: 0x6B9AAD0
        public void SendAsyncForNetworkStream(){} // RVA: 0x6B9B130
        public void SendAsyncApm(){} // RVA: 0x6B9B630
        public void CompleteAccept(){} // RVA: 0x6B9BC30
        public void CompleteSendReceive(){} // RVA: 0x6B9BEF0
        public void GetException(){} // RVA: 0x6B9C170
        public void ReturnSocketAsyncEventArgs(){} // RVA: 0x6B9C390 | overloaded x2
        public void .ctor(){} // RVA: 0x6B9E780 | overloaded x2
        public void get_OSSupportsIPv4(){} // RVA: 0x6B9C830
        public void get_OSSupportsIPv6(){} // RVA: 0x6B9C890
        public void get_Handle(){} // RVA: 0x6A43BA0
        public void get_AddressFamily(){} // RVA: 0x760030
        public void get_SocketType(){} // RVA: 0xCEF5B0
        public void get_ProtocolType(){} // RVA: 0x791DC0
        public void get_ExclusiveAddressUse(){} // RVA: 0x6B9C8F0
        public void set_ExclusiveAddressUse(){} // RVA: 0x6B9C970
        public void set_ReceiveTimeout(){} // RVA: 0x6B9CA10
        public void set_SendTimeout(){} // RVA: 0x6B9CAA0
        public void set_DontFragment(){} // RVA: 0x6B9CB30
        public void get_DualMode(){} // RVA: 0x6B9CBD0
        public void set_DualMode(){} // RVA: 0x6B9CCC0
        public void get_IsDualMode(){} // RVA: 0x6B9CD60
        public void CanTryAddressFamily(){} // RVA: 0x6B9CE50
        public void Connect(){} // RVA: 0x6BA0E70 | overloaded x4
        public void Send(){} // RVA: 0x6BA4E10 | overloaded x7
        public void Receive(){} // RVA: 0x6BA3430 | overloaded x8
        public void IOControl(){} // RVA: 0x6BA7BE0 | overloaded x2
        public void SetIPProtectionLevel(){} // RVA: 0x6B9D850
        public void BeginConnect(){} // RVA: 0x6BA1750 | overloaded x4
        public void BeginSend(){} // RVA: 0x6BA5A70 | overloaded x2
        public void EndSend(){} // RVA: 0x6BA6220 | overloaded x2
        public void BeginReceive(){} // RVA: 0x6BA3AE0 | overloaded x2
        public void EndReceive(){} // RVA: 0x6BA3DC0 | overloaded x2
        public void get_InternalSyncObject(){} // RVA: 0x6B9DFD0
        public void get_CleanedUp(){} // RVA: 0x11A2580
        public void InitializeSockets(){} // RVA: 0x6B9E100
        public void Dispose(){} // RVA: 0x6BA83D0 | overloaded x2
        public void Finalize(){} // RVA: 0x5AAC950
        public void InternalShutdown(){} // RVA: 0x6B9E590
        public void SetSocketOption(){} // RVA: 0x6BA7920 | overloaded x4
        public void SocketDefaults(){} // RVA: 0x6B9E960
        public void Socket_icall(){} // RVA: 0x6B9E9D0
        public void get_Available(){} // RVA: 0x6B9EB80
        public void Available_internal(){} // RVA: 0x6B9EC30
        public void Available_icall(){} // RVA: 0x6B9ED50
        public void get_IsBound(){} // RVA: 0x1BE4C90
        public void get_LocalEndPoint(){} // RVA: 0x6B9ED60
        public void LocalEndPoint_internal(){} // RVA: 0x6B9EE60
        public void LocalEndPoint_icall(){} // RVA: 0x6B9EF90
        public void get_Blocking(){} // RVA: 0x3978E0
        public void set_Blocking(){} // RVA: 0x6B9EFA0
        public void Blocking_internal(){} // RVA: 0x6B9F070
        public void Blocking_icall(){} // RVA: 0x6B9F190
        public void get_Connected(){} // RVA: 0x1BE5300
        public void set_NoDelay(){} // RVA: 0x6B9F2E0
        public void get_RemoteEndPoint(){} // RVA: 0x6B9F370
        public void RemoteEndPoint_internal(){} // RVA: 0x6B9F480
        public void RemoteEndPoint_icall(){} // RVA: 0x6B9F5B0
        public void Poll(){} // RVA: 0x6B9F5C0
        public void Poll_internal(){} // RVA: 0x6B9F770
        public void Poll_icall(){} // RVA: 0x6B9F8C0
        public void Accept(){} // RVA: 0x6B9FA70 | overloaded x2
        public void AcceptAsync(){} // RVA: 0x6B9FC40
        public void BeginAccept(){} // RVA: 0x6B9FF60
        public void EndAccept(){} // RVA: 0x6BA0250 | overloaded x2
        public void Accept_internal(){} // RVA: 0x6BA03B0
        public void Accept_icall(){} // RVA: 0x6BA0550
        public void Bind(){} // RVA: 0x6BA05F0
        public void Bind_internal(){} // RVA: 0x6BA07E0
        public void Bind_icall(){} // RVA: 0x6BA0900
        public void Listen(){} // RVA: 0x6BA0910
        public void Listen_internal(){} // RVA: 0x6BA0A20
        public void Listen_icall(){} // RVA: 0x6BA0C60
        public void BeginMConnect(){} // RVA: 0x6BA1A00
        public void BeginSConnect(){} // RVA: 0x6BA1C00
        public void EndConnect(){} // RVA: 0x6BA2250
        public void Connect_internal(){} // RVA: 0x6BA2310
        public void Connect_icall(){} // RVA: 0x6BA2420
        public void Disconnect(){} // RVA: 0x6BA2430
        public void EndDisconnect(){} // RVA: 0x6BA2540
        public void Disconnect_internal(){} // RVA: 0x6BA2600
        public void Disconnect_icall(){} // RVA: 0x6BA2830
        public void Receive_internal(){} // RVA: 0x6BA4000 | overloaded x2
        public void Receive_array_icall(){} // RVA: 0x6BA3FF0
        public void Receive_icall(){} // RVA: 0x6BA4130
        public void ReceiveFrom(){} // RVA: 0x6BA4140
        public void BeginReceiveFrom(){} // RVA: 0x6BA44E0
        public void EndReceiveFrom(){} // RVA: 0x6BA4860
        public void EndReceiveFrom_internal(){} // RVA: 0x6BA49E0
        public void ReceiveFrom_internal(){} // RVA: 0x6BA4B10
        public void ReceiveFrom_icall(){} // RVA: 0x6BA4C50
        public void SendAsync(){} // RVA: 0x6BA5430
        public void BeginSendCallback(){} // RVA: 0x6BA5E60
        public void Send_internal(){} // RVA: 0x6BA6460 | overloaded x2
        public void Send_array_icall(){} // RVA: 0x6BA6450
        public void Send_icall(){} // RVA: 0x6BA6590
        public void SendTo(){} // RVA: 0x6BA65A0
        public void BeginSendTo(){} // RVA: 0x6BA6920
        public void BeginSendToCallback(){} // RVA: 0x6BA6D30
        public void EndSendTo(){} // RVA: 0x6BA6F10
        public void SendTo_internal(){} // RVA: 0x6BA6FE0
        public void SendTo_icall(){} // RVA: 0x6BA7120
        public void GetSocketOption(){} // RVA: 0x6BA7130
        public void GetSocketOption_obj_internal(){} // RVA: 0x6BA7360
        public void GetSocketOption_obj_icall(){} // RVA: 0x6BA74A0
        public void SetSocketOption_internal(){} // RVA: 0x6BA7A60
        public void SetSocketOption_icall(){} // RVA: 0x6BA7BD0
        public void IOControl_internal(){} // RVA: 0x6BA7D80
        public void IOControl_icall(){} // RVA: 0x6BA7ED0
        public void Close(){} // RVA: 0x6BA7EF0 | overloaded x2
        public void Close_icall(){} // RVA: 0x6BA7F00
        public void Shutdown(){} // RVA: 0x6BA8050
        public void Shutdown_internal(){} // RVA: 0x6BA8160
        public void Shutdown_icall(){} // RVA: 0x6BA8280
        public void Linger(){} // RVA: 0x6BA86E0
        public void ThrowIfDisposedAndClosed(){} // RVA: 0x6BA8980
        public void ThrowIfBufferNull(){} // RVA: 0x6BA8A10
        public void ThrowIfBufferOutOfRange(){} // RVA: 0x6BA8A70
        public void ThrowIfUdp(){} // RVA: 0x6BA8C30
        public void ValidateEndIAsyncResult(){} // RVA: 0x6BA8C90
        public void QueueIOSelectorJob(){} // RVA: 0x6BA8E00
        public void InitSocketAsyncEventArgs(){} // RVA: 0x6BA9030
        public void SocketOperationToSocketAsyncOperation(){} // RVA: 0x6BA92F0
        public void RemapIPEndPoint(){} // RVA: 0x6BA9420
        public void cancel_blocking_socket_operation(){} // RVA: 0x6BA9650
        public void get_FamilyHint(){} // RVA: 0x6BA96F0
        public void IsProtocolSupported_internal(){} // RVA: 0x3C2850
        public void IsProtocolSupported(){} // RVA: 0x6BA9830
        public void .cctor(){} // RVA: 0x6BA9880
    }

    public class SocketAsyncEventArgs
    {
        public bool disposed; // 0x10
        public int in_progress; // 0x14
        public System.Net.EndPoint remote_ep; // 0x18
        public System.Net.Sockets.Socket current_socket; // 0x20
        public System.Net.Sockets.SocketAsyncResult socket_async_result; // 0x28
        public System.Exception <ConnectByNameError>k__BackingField; // 0x30
        public System.Net.Sockets.Socket <AcceptSocket>k__BackingField; // 0x38
        public int <BytesTransferred>k__BackingField; // 0x40
        public bool <DisconnectReuseSocket>k__BackingField; // 0x44
        public 0x6585B980 <LastOperation>k__BackingField; // 0x48
        public System.Net.Sockets.IPPacketInformation <ReceiveMessageFromPacketInfo>k__BackingField; // 0x50
        public System.Net.Sockets.SendPacketsElement[] <SendPacketsElements>k__BackingField; // 0x60
        public 0x6585BCF0 <SendPacketsFlags>k__BackingField; // 0x68
        public int <SendPacketsSendSize>k__BackingField; // 0x6C

        // ── Methods ──
        public void get_AcceptSocket(){} // RVA: 0x4976A0
        public void set_AcceptSocket(){} // RVA: 0x49B830
        public void get_BytesTransferred(){} // RVA: 0x37E080
        public void set_BytesTransferred(){} // RVA: 0x37E090
        public void set_LastOperation(){} // RVA: 0x37E0D0
        public void set_RemoteEndPoint(){} // RVA: 0x343E80
        public void set_SendPacketsSendSize(){} // RVA: 0x1C91470
        public void get_SocketError(){} // RVA: 0x10E5CF0
        public void set_SocketError(){} // RVA: 0x475080
        public void set_SocketFlags(){} // RVA: 0x1D8D640
        public void get_UserToken(){} // RVA: 0x4C7C50
        public void set_UserToken(){} // RVA: 0x4C34F0
        public void add_Completed(){} // RVA: 0x6BB4480
        public void remove_Completed(){} // RVA: 0x6BB4580
        public void .ctor(){} // RVA: 0x6BB4740 | overloaded x2
        public void Finalize(){} // RVA: 0x6BB4800
        public void Dispose(){} // RVA: 0x6BB4830 | overloaded x2
        public void SetBytesTransferred(){} // RVA: 0x37E090
        public void get_CurrentSocket(){} // RVA: 0x30B0C0
        public void SetCurrentSocket(){} // RVA: 0x30B0D0
        public void SetLastOperation(){} // RVA: 0x6BB4890
        public void Complete_internal(){} // RVA: 0x6BB4950
        public void OnCompleted(){} // RVA: 0x6BB4980
        public void get_Buffer(){} // RVA: 0x6BB49B0
        public void get_MemoryBuffer(){} // RVA: 0x576C5E0
        public void get_Offset(){} // RVA: 0x1D76570
        public void get_Count(){} // RVA: 0x1D76560
        public void get_BufferList(){} // RVA: 0xA1C130
        public void SetBuffer(){} // RVA: 0x6BB4CC0 | overloaded x2
    }

    public class SocketAsyncResult
    {
        public System.Net.Sockets.Socket socket; // 0x30
        public 0x6585BF58 operation; // 0x38

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x6BB4DF0
        public void .ctor(){} // RVA: 0x6BB5220 | overloaded x2
        public void Init(){} // RVA: 0x6BB4E20
        public void get_ErrorCode(){} // RVA: 0x6BB5340
        public void CheckIfThrowDelayedException(){} // RVA: 0x6BB53E0
        public void CompleteDisposed(){} // RVA: 0x6BB5490
        public void Complete(){} // RVA: 0x6BB5890 | overloaded x7
    }

    public class SocketException
    {
        public System.Net.EndPoint m_EndPoint; // 0x98

        // ── Methods ──
        public void WSAGetLastError_icall(){} // RVA: 0x6BAFB90
        public void .ctor(){} // RVA: 0x6B1C9D0 | overloaded x5
        public void get_ErrorCode(){} // RVA: 0x6AFD40
        public void get_Message(){} // RVA: 0x6BAFC20
        public void get_SocketErrorCode(){} // RVA: 0x6AFD40
    }

    public class TcpClient
    {
        public System.Net.Sockets.Socket m_ClientSocket; // 0x10
        public bool m_Active; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BB0730 | overloaded x4
        public void get_Client(){} // RVA: 0x2F8380
        public void set_Client(){} // RVA: 0x2DEE30
        public void get_Connected(){} // RVA: 0x6BB0790
        public void Connect(){} // RVA: 0x6BB0F20 | overloaded x2
        public void BeginConnect(){} // RVA: 0x6BB1010
        public void EndConnect(){} // RVA: 0x6BB1040
        public void ConnectAsync(){} // RVA: 0x6BB1070
        public void GetStream(){} // RVA: 0x6BB1230
        public void Close(){} // RVA: 0x6BB13A0
        public void Dispose(){} // RVA: 0x32AFC0 | overloaded x2
        public void Finalize(){} // RVA: 0x5AAC950
        public void initialize(){} // RVA: 0x6BB1590
    }

    public class TcpListener
    {
        public System.Net.IPEndPoint AddressFamily; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BB1660
        public void get_LocalEndpoint(){} // RVA: 0x6BB18D0
        public void Start(){} // RVA: 0x6BB1910 | overloaded x2
        public void Stop(){} // RVA: 0x6BB1A40
        public void BeginAcceptTcpClient(){} // RVA: 0x6BB1BE0
        public void EndAcceptTcpClient(){} // RVA: 0x6BB1C70
    }

    public class UdpClient
    {
        public System.Net.Sockets.Socket m_ClientSocket; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BB1E20
        public void get_Client(){} // RVA: 0x2F8380
        public void set_Client(){} // RVA: 0x2DEE30
        public void FreeResources(){} // RVA: 0x6BB2060
        public void Dispose(){} // RVA: 0x6BB20C0 | overloaded x2
        public void CheckForBroadcast(){} // RVA: 0x6BB2160
        public void IsBroadcast(){} // RVA: 0x6BB2240
        public void BeginSend(){} // RVA: 0x6BB22D0
        public void EndSend(){} // RVA: 0x6BB25E0
        public void BeginReceive(){} // RVA: 0x6BB26A0
        public void EndReceive(){} // RVA: 0x6BB2800
        public void SendAsync(){} // RVA: 0x6BB2BC0
        public void ReceiveAsync(){} // RVA: 0x6BB2D30
        public void createClientSocket(){} // RVA: 0x6BB2E70
        public void <ReceiveAsync>b__65_0(){} // RVA: 0x6BB26A0
        public void <ReceiveAsync>b__65_1(){} // RVA: 0x6BB2F40
    }

    public class UdpReceiveResult
    {
        public byte[] m_buffer; // 0x10
        public System.Net.IPEndPoint m_remoteEndPoint; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BB30D0
        public void get_Buffer(){} // RVA: 0x1AD4690
        public void get_RemoteEndPoint(){} // RVA: 0x19689C0
        public void GetHashCode(){} // RVA: 0x6BB3240
        public void Equals(){} // RVA: 0x40AD960 | overloaded x2
    }

}