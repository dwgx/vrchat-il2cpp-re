// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Sockets
// Classes: 15
// Methods: 326

namespace ThirdParty.DotNet.System.Net.Sockets
{
    public class IPPacketInformation : ValueType
    {
        public System.Net.IPAddress address; // 0x10
        public int networkInterface; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC9346840
        public void GetHashCode(){} // RVA: 0x7FFAC9346910
    }

    public class IPv6MulticastOption : Object
    {
        public System.Net.IPAddress Group; // 0x10
        public long InterfaceIndex; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9346D10 | overloaded x2
        public void set_Group(){} // RVA: 0x7FFAC9346DD0
        public void set_InterfaceIndex(){} // RVA: 0x7FFAC9346E80
    }

    public class LingerOption : Object
    {
        public bool Enabled; // 0x10
        public int LingerTime; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9346950
        public void set_Enabled(){} // RVA: 0x7FFAC2FEB5F0
        public void set_LingerTime(){} // RVA: 0x7FFAC33D4990
    }

    public class MulticastOption : Object
    {
        public System.Net.IPAddress Group; // 0x10
        public System.Net.IPAddress LocalAddress; // 0x18
        public int ifIndex; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9346A20 | overloaded x2
        public void set_Group(){} // RVA: 0x7FFAC2F22E30
        public void set_LocalAddress(){} // RVA: 0x7FFAC9346B90
    }

    public class NetworkStream : Stream
    {
        public System.Net.Sockets.Socket CanRead; // 0x28
        public bool CanSeek; // 0x30
        public bool CanWrite; // 0x31
        public bool CanTimeout; // 0x32
        public int ReadTimeout; // 0x34
        public bool WriteTimeout; // 0x38
        public int DataAvailable; // 0x3C
        public int Length; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC932DA20 | overloaded x3
        public void get_CanRead(){} // RVA: 0x7FFAC2F47470
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC64EB050
        public void get_CanTimeout(){} // RVA: 0x7FFAC3006850
        public void get_ReadTimeout(){} // RVA: 0x7FFAC932DC20
        public void set_ReadTimeout(){} // RVA: 0x7FFAC932DCB0
        public void get_WriteTimeout(){} // RVA: 0x7FFAC932DD50
        public void set_WriteTimeout(){} // RVA: 0x7FFAC932DDE0
        public void get_DataAvailable(){} // RVA: 0x7FFAC932DE80
        public void get_Length(){} // RVA: 0x7FFAC932DF30
        public void get_Position(){} // RVA: 0x7FFAC932DF80
        public void set_Position(){} // RVA: 0x7FFAC932DFD0
        public void Seek(){} // RVA: 0x7FFAC932E020
        public void Read(){} // RVA: 0x7FFAC932E410 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFAC932E760
        public void Write(){} // RVA: 0x7FFAC932EB80 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFAC932EE90
        public void Close(){} // RVA: 0x7FFAC932EF00
        public void Dispose(){} // RVA: 0x7FFAC932EF80
        public void Finalize(){} // RVA: 0x7FFAC8449EF0
        public void BeginRead(){} // RVA: 0x7FFAC932F000
        public void EndRead(){} // RVA: 0x7FFAC932F3C0
        public void BeginWrite(){} // RVA: 0x7FFAC932F620
        public void EndWrite(){} // RVA: 0x7FFAC932F9E0
        public void ReadAsync(){} // RVA: 0x7FFAC9330090 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFAC93307C0 | overloaded x2
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void FlushAsync(){} // RVA: 0x7FFAC9330A80
        public void SetLength(){} // RVA: 0x7FFAC9330B20
        public void SetSocketTimeoutOption(){} // RVA: 0x7FFAC9330B70
        public void get_InternalSocket(){} // RVA: 0x7FFAC9330EC0
    }

    public class SafeSocketHandle : SafeHandleMinusOneIsInvalid
    {
        public System.Collections.Generic.List`1<System.Threading.Thread> blocking_threads; // 0x20
        public System.Collections.Generic.Dictionary`2<System.Threading.Thread,System.Diagnostics.StackTrace> threads_stacktraces; // 0x28
        public bool in_cleanup; // 0x30
        public int SOCKET_CLOSED;
        public int ABORT_RETRIES;
        public bool THROW_ON_ABORT_RETRIES;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9349F30
        public void ReleaseHandle(){} // RVA: 0x7FFAC934A060
        public void RegisterForBlockingSyscall(){} // RVA: 0x7FFAC934A810
        public void UnRegisterForBlockingSyscall(){} // RVA: 0x7FFAC934AC90
        public void .cctor(){} // RVA: 0x7FFAC934AF30
    }

    public class SendPacketsElement : Object
    {
        public string m_FilePath; // 0x10
        public byte[] m_Buffer; // 0x18
        public int m_Offset; // 0x20
        public int m_Count; // 0x24
        public bool m_endOfPacket; // 0x28
    }

    public class Socket : Object
    {
        public System.EventHandler`1<System.Net.Sockets.SocketAsyncEventArgs> OSSupportsIPv4;
        public System.EventHandler`1<System.Net.Sockets.SocketAsyncEventArgs> OSSupportsIPv6; // 0x8
        public System.EventHandler`1<System.Net.Sockets.SocketAsyncEventArgs> Handle; // 0x10
        public TaskSocketAsyncEventArgs`1<System.Net.Sockets.Socket> AddressFamily; // 0x18
        public Int32TaskSocketAsyncEventArgs SocketType; // 0x20
        public System.Threading.Tasks.Task`1<int> ProtocolType; // 0x28
        public CachedEventArgs ExclusiveAddressUse; // 0x10
        public object ReceiveTimeout; // 0x30
        public bool SendTimeout; // 0x38
        public bool DontFragment; // 0x39
        public bool DualMode; // 0x3A
        public bool IsDualMode; // 0x3B
        public bool InternalSyncObject; // 0x3C
        public bool CleanedUp; // 0x3D
        public int Available;
        public int IsBound;
        public string LocalEndPoint;
        public bool Blocking; // 0x18
        public bool Connected; // 0x19
        public bool NoDelay; // 0x1A
        public int RemoteEndPoint; // 0x1C
        public 0x6B1406E8 FamilyHint; // 0x20
        public 0x6B140C68 socketType; // 0x24
        public 0x6B140950 protocolType; // 0x28
        public System.Net.Sockets.SafeSocketHandle m_Handle; // 0x30
        public System.Net.EndPoint seed_endpoint; // 0x38
        public System.Threading.SemaphoreSlim ReadSem; // 0x40
        public System.Threading.SemaphoreSlim WriteSem; // 0x48
        public bool is_blocking; // 0x50
        public bool is_bound; // 0x51
        public bool is_connected; // 0x52
        public int m_IntCleanedUp; // 0x54
        public bool connect_in_progress; // 0x58
        public int ID; // 0x5C
        public System.AsyncCallback AcceptAsyncCallback; // 0x40
        public System.IOAsyncCallback BeginAcceptCallback; // 0x48
        public System.IOAsyncCallback BeginAcceptReceiveCallback; // 0x50
        public System.AsyncCallback ConnectAsyncCallback; // 0x58
        public System.IOAsyncCallback BeginConnectCallback; // 0x60
        public System.AsyncCallback DisconnectAsyncCallback; // 0x68
        public System.IOAsyncCallback BeginDisconnectCallback; // 0x70
        public System.AsyncCallback ReceiveAsyncCallback; // 0x78
        public System.IOAsyncCallback BeginReceiveCallback; // 0x80
        public System.IOAsyncCallback BeginReceiveGenericCallback; // 0x88
        public System.AsyncCallback ReceiveFromAsyncCallback; // 0x90
        public System.IOAsyncCallback BeginReceiveFromCallback; // 0x98
        public System.AsyncCallback SendAsyncCallback; // 0xA0
        public System.IOAsyncCallback BeginSendGenericCallback; // 0xA8
        public System.AsyncCallback SendToAsyncCallback; // 0xB0

        // ── Methods ──
        public void ConnectAsync(){} // RVA: 0x7FFAC9330F60
        public void ReceiveAsync(){} // RVA: 0x7FFAC933A130 | overloaded x2
        public void ReceiveAsyncApm(){} // RVA: 0x7FFAC9331650
        public void SendAsyncForNetworkStream(){} // RVA: 0x7FFAC9331CB0
        public void SendAsyncApm(){} // RVA: 0x7FFAC93321B0
        public void CompleteAccept(){} // RVA: 0x7FFAC93327B0
        public void CompleteSendReceive(){} // RVA: 0x7FFAC9332A70
        public void GetException(){} // RVA: 0x7FFAC9332CF0
        public void ReturnSocketAsyncEventArgs(){} // RVA: 0x7FFAC9332F10 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC9335300 | overloaded x2
        public void get_OSSupportsIPv4(){} // RVA: 0x7FFAC93333B0
        public void get_OSSupportsIPv6(){} // RVA: 0x7FFAC9333410
        public void get_Handle(){} // RVA: 0x7FFAC91DA720
        public void get_AddressFamily(){} // RVA: 0x7FFAC30DBBE0
        public void get_SocketType(){} // RVA: 0x7FFAC3921980
        public void get_ProtocolType(){} // RVA: 0x7FFAC32EC4C0
        public void get_ExclusiveAddressUse(){} // RVA: 0x7FFAC9333470
        public void set_ExclusiveAddressUse(){} // RVA: 0x7FFAC93334F0
        public void set_ReceiveTimeout(){} // RVA: 0x7FFAC9333590
        public void set_SendTimeout(){} // RVA: 0x7FFAC9333620
        public void set_DontFragment(){} // RVA: 0x7FFAC93336B0
        public void get_DualMode(){} // RVA: 0x7FFAC9333750
        public void set_DualMode(){} // RVA: 0x7FFAC9333840
        public void get_IsDualMode(){} // RVA: 0x7FFAC93338E0
        public void CanTryAddressFamily(){} // RVA: 0x7FFAC93339D0
        public void Connect(){} // RVA: 0x7FFAC93379F0 | overloaded x4
        public void Send(){} // RVA: 0x7FFAC933B990 | overloaded x7
        public void Receive(){} // RVA: 0x7FFAC9339FB0 | overloaded x8
        public void IOControl(){} // RVA: 0x7FFAC933E760 | overloaded x2
        public void SetIPProtectionLevel(){} // RVA: 0x7FFAC93343D0
        public void BeginConnect(){} // RVA: 0x7FFAC93382D0 | overloaded x4
        public void BeginSend(){} // RVA: 0x7FFAC933C5F0 | overloaded x2
        public void EndSend(){} // RVA: 0x7FFAC933CDA0 | overloaded x2
        public void BeginReceive(){} // RVA: 0x7FFAC933A660 | overloaded x2
        public void EndReceive(){} // RVA: 0x7FFAC933A940 | overloaded x2
        public void get_InternalSyncObject(){} // RVA: 0x7FFAC9334B50
        public void get_CleanedUp(){} // RVA: 0x7FFAC3C55DE0
        public void InitializeSockets(){} // RVA: 0x7FFAC9334C80
        public void Dispose(){} // RVA: 0x7FFAC933EF50 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8243E40
        public void InternalShutdown(){} // RVA: 0x7FFAC9335110
        public void SetSocketOption(){} // RVA: 0x7FFAC933E4A0 | overloaded x4
        public void SocketDefaults(){} // RVA: 0x7FFAC93354E0
        public void Socket_icall(){} // RVA: 0x7FFAC9335550
        public void get_Available(){} // RVA: 0x7FFAC9335700
        public void Available_internal(){} // RVA: 0x7FFAC93357B0
        public void Available_icall(){} // RVA: 0x7FFAC93358D0
        public void get_IsBound(){} // RVA: 0x7FFAC8489120
        public void get_LocalEndPoint(){} // RVA: 0x7FFAC93358E0
        public void LocalEndPoint_internal(){} // RVA: 0x7FFAC93359E0
        public void LocalEndPoint_icall(){} // RVA: 0x7FFAC9335B10
        public void get_Blocking(){} // RVA: 0x7FFAC2FDB8E0
        public void set_Blocking(){} // RVA: 0x7FFAC9335B20
        public void Blocking_internal(){} // RVA: 0x7FFAC9335BF0
        public void Blocking_icall(){} // RVA: 0x7FFAC9335D10
        public void get_Connected(){} // RVA: 0x7FFAC825F9A0
        public void set_NoDelay(){} // RVA: 0x7FFAC9335E60
        public void get_RemoteEndPoint(){} // RVA: 0x7FFAC9335EF0
        public void RemoteEndPoint_internal(){} // RVA: 0x7FFAC9336000
        public void RemoteEndPoint_icall(){} // RVA: 0x7FFAC9336130
        public void Poll(){} // RVA: 0x7FFAC9336140
        public void Poll_internal(){} // RVA: 0x7FFAC93362F0
        public void Poll_icall(){} // RVA: 0x7FFAC9336440
        public void Accept(){} // RVA: 0x7FFAC93365F0 | overloaded x2
        public void AcceptAsync(){} // RVA: 0x7FFAC93367C0
        public void BeginAccept(){} // RVA: 0x7FFAC9336AE0
        public void EndAccept(){} // RVA: 0x7FFAC9336DD0 | overloaded x2
        public void Accept_internal(){} // RVA: 0x7FFAC9336F30
        public void Accept_icall(){} // RVA: 0x7FFAC93370D0
        public void Bind(){} // RVA: 0x7FFAC9337170
        public void Bind_internal(){} // RVA: 0x7FFAC9337360
        public void Bind_icall(){} // RVA: 0x7FFAC9337480
        public void Listen(){} // RVA: 0x7FFAC9337490
        public void Listen_internal(){} // RVA: 0x7FFAC93375A0
        public void Listen_icall(){} // RVA: 0x7FFAC93377E0
        public void BeginMConnect(){} // RVA: 0x7FFAC9338580
        public void BeginSConnect(){} // RVA: 0x7FFAC9338780
        public void EndConnect(){} // RVA: 0x7FFAC9338DD0
        public void Connect_internal(){} // RVA: 0x7FFAC9338E90
        public void Connect_icall(){} // RVA: 0x7FFAC9338FA0
        public void Disconnect(){} // RVA: 0x7FFAC9338FB0
        public void EndDisconnect(){} // RVA: 0x7FFAC93390C0
        public void Disconnect_internal(){} // RVA: 0x7FFAC9339180
        public void Disconnect_icall(){} // RVA: 0x7FFAC93393B0
        public void Receive_internal(){} // RVA: 0x7FFAC933AB80 | overloaded x2
        public void Receive_array_icall(){} // RVA: 0x7FFAC933AB70
        public void Receive_icall(){} // RVA: 0x7FFAC933ACB0
        public void ReceiveFrom(){} // RVA: 0x7FFAC933ACC0
        public void BeginReceiveFrom(){} // RVA: 0x7FFAC933B060
        public void EndReceiveFrom(){} // RVA: 0x7FFAC933B3E0
        public void EndReceiveFrom_internal(){} // RVA: 0x7FFAC933B560
        public void ReceiveFrom_internal(){} // RVA: 0x7FFAC933B690
        public void ReceiveFrom_icall(){} // RVA: 0x7FFAC933B7D0
        public void SendAsync(){} // RVA: 0x7FFAC933BFB0
        public void BeginSendCallback(){} // RVA: 0x7FFAC933C9E0
        public void Send_internal(){} // RVA: 0x7FFAC933CFE0 | overloaded x2
        public void Send_array_icall(){} // RVA: 0x7FFAC933CFD0
        public void Send_icall(){} // RVA: 0x7FFAC933D110
        public void SendTo(){} // RVA: 0x7FFAC933D120
        public void BeginSendTo(){} // RVA: 0x7FFAC933D4A0
        public void BeginSendToCallback(){} // RVA: 0x7FFAC933D8B0
        public void EndSendTo(){} // RVA: 0x7FFAC933DA90
        public void SendTo_internal(){} // RVA: 0x7FFAC933DB60
        public void SendTo_icall(){} // RVA: 0x7FFAC933DCA0
        public void GetSocketOption(){} // RVA: 0x7FFAC933DCB0
        public void GetSocketOption_obj_internal(){} // RVA: 0x7FFAC933DEE0
        public void GetSocketOption_obj_icall(){} // RVA: 0x7FFAC933E020
        public void SetSocketOption_internal(){} // RVA: 0x7FFAC933E5E0
        public void SetSocketOption_icall(){} // RVA: 0x7FFAC933E750
        public void IOControl_internal(){} // RVA: 0x7FFAC933E900
        public void IOControl_icall(){} // RVA: 0x7FFAC933EA50
        public void Close(){} // RVA: 0x7FFAC933EA70 | overloaded x2
        public void Close_icall(){} // RVA: 0x7FFAC933EA80
        public void Shutdown(){} // RVA: 0x7FFAC933EBD0
        public void Shutdown_internal(){} // RVA: 0x7FFAC933ECE0
        public void Shutdown_icall(){} // RVA: 0x7FFAC933EE00
        public void Linger(){} // RVA: 0x7FFAC933F260
        public void ThrowIfDisposedAndClosed(){} // RVA: 0x7FFAC933F500
        public void ThrowIfBufferNull(){} // RVA: 0x7FFAC933F590
        public void ThrowIfBufferOutOfRange(){} // RVA: 0x7FFAC933F5F0
        public void ThrowIfUdp(){} // RVA: 0x7FFAC933F7B0
        public void ValidateEndIAsyncResult(){} // RVA: 0x7FFAC933F810
        public void QueueIOSelectorJob(){} // RVA: 0x7FFAC933F980
        public void InitSocketAsyncEventArgs(){} // RVA: 0x7FFAC933FBB0
        public void SocketOperationToSocketAsyncOperation(){} // RVA: 0x7FFAC933FE70
        public void RemapIPEndPoint(){} // RVA: 0x7FFAC933FFA0
        public void cancel_blocking_socket_operation(){} // RVA: 0x7FFAC93401D0
        public void get_FamilyHint(){} // RVA: 0x7FFAC9340270
        public void IsProtocolSupported_internal(){} // RVA: 0x7FFAC3006850
        public void IsProtocolSupported(){} // RVA: 0x7FFAC93403B0
        public void .cctor(){} // RVA: 0x7FFAC9340400
    }

    public class SocketAsyncEventArgs : EventArgs
    {
        public bool AcceptSocket; // 0x10
        public int BytesTransferred; // 0x14
        public System.Net.EndPoint LastOperation; // 0x18
        public System.Net.Sockets.Socket RemoteEndPoint; // 0x20
        public System.Net.Sockets.SocketAsyncResult SendPacketsSendSize; // 0x28
        public System.Exception SocketError; // 0x30
        public System.Net.Sockets.Socket SocketFlags; // 0x38
        public int UserToken; // 0x40
        public bool CurrentSocket; // 0x44
        public 0x6B140A00 Buffer; // 0x48
        public System.Net.Sockets.IPPacketInformation MemoryBuffer; // 0x50
        public System.Net.Sockets.SendPacketsElement[] Offset; // 0x60
        public 0x6B140D70 Count; // 0x68
        public int BufferList; // 0x6C
        public 0x6B140AB0 <SocketError>k__BackingField; // 0x70
        public 0x6B140B08 <SocketFlags>k__BackingField; // 0x74
        public object <UserToken>k__BackingField; // 0x78
        public System.EventHandler`1<System.Net.Sockets.SocketAsyncEventArgs> Completed; // 0x80
        public System.Memory`1<byte> _buffer; // 0x88
        public int _offset; // 0x98
        public int _count; // 0x9C
        public bool _bufferIsExplicitArray; // 0xA0
        public System.Collections.Generic.IList`1<System.ArraySegment`1<byte>> _bufferList; // 0xA8
        public System.Collections.Generic.List`1<System.ArraySegment`1<byte>> _bufferListInternal; // 0xB0

        // ── Methods ──
        public void get_AcceptSocket(){} // RVA: 0x7FFAC31D0140
        public void set_AcceptSocket(){} // RVA: 0x7FFAC31D0C20
        public void get_BytesTransferred(){} // RVA: 0x7FFAC2FC2080
        public void set_BytesTransferred(){} // RVA: 0x7FFAC2FC2090
        public void set_LastOperation(){} // RVA: 0x7FFAC2FC20D0
        public void set_RemoteEndPoint(){} // RVA: 0x7FFAC2F87E80
        public void set_SendPacketsSendSize(){} // RVA: 0x7FFAC47BAB80
        public void get_SocketError(){} // RVA: 0x7FFAC3B99E80
        public void set_SocketError(){} // RVA: 0x7FFAC30B6520
        public void set_SocketFlags(){} // RVA: 0x7FFAC48B4C80
        public void get_UserToken(){} // RVA: 0x7FFAC30E5600
        public void set_UserToken(){} // RVA: 0x7FFAC30E06F0
        public void add_Completed(){} // RVA: 0x7FFAC934B000
        public void remove_Completed(){} // RVA: 0x7FFAC934B100
        public void .ctor(){} // RVA: 0x7FFAC934B2C0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC934B380
        public void Dispose(){} // RVA: 0x7FFAC934B3B0 | overloaded x2
        public void SetBytesTransferred(){} // RVA: 0x7FFAC2FC2090
        public void get_CurrentSocket(){} // RVA: 0x7FFAC2F4F0C0
        public void SetCurrentSocket(){} // RVA: 0x7FFAC2F4F0D0
        public void SetLastOperation(){} // RVA: 0x7FFAC934B410
        public void Complete_internal(){} // RVA: 0x7FFAC934B4D0
        public void OnCompleted(){} // RVA: 0x7FFAC934B500
        public void get_Buffer(){} // RVA: 0x7FFAC934B530
        public void get_MemoryBuffer(){} // RVA: 0x7FFAC7DF99E0
        public void get_Offset(){} // RVA: 0x7FFAC489E530
        public void get_Count(){} // RVA: 0x7FFAC489E520
        public void get_BufferList(){} // RVA: 0x7FFAC354B1A0
        public void SetBuffer(){} // RVA: 0x7FFAC934B840 | overloaded x2
    }

    public class SocketAsyncResult : IOAsyncResult
    {
        public System.Net.Sockets.Socket Handle; // 0x30
        public 0x6B140FD8 ErrorCode; // 0x38
        public System.Exception DelayedException; // 0x40
        public System.Net.EndPoint EndPoint; // 0x48
        public System.Memory`1<byte> Buffer; // 0x50
        public int Offset; // 0x60
        public int Size; // 0x64
        public 0x6B140B08 SockFlags; // 0x68
        public System.Net.Sockets.Socket AcceptSocket; // 0x70
        public System.Net.IPAddress[] Addresses; // 0x78
        public int Port; // 0x80
        public System.Collections.Generic.IList`1<System.ArraySegment`1<byte>> Buffers; // 0x88
        public bool ReuseSocket; // 0x90
        public int CurrentAddress; // 0x94
        public System.Net.Sockets.Socket AcceptedSocket; // 0x98
        public int Total; // 0xA0
        public int error; // 0xA4
        public int EndCalled; // 0xA8

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAC934B970
        public void .ctor(){} // RVA: 0x7FFAC934BDA0 | overloaded x2
        public void Init(){} // RVA: 0x7FFAC934B9A0
        public void get_ErrorCode(){} // RVA: 0x7FFAC934BEC0
        public void CheckIfThrowDelayedException(){} // RVA: 0x7FFAC934BF60
        public void CompleteDisposed(){} // RVA: 0x7FFAC934C010
        public void Complete(){} // RVA: 0x7FFAC934C410 | overloaded x7
    }

    public class SocketException : Win32Exception
    {
        public System.Net.EndPoint ErrorCode; // 0x98

        // ── Methods ──
        public void WSAGetLastError_icall(){} // RVA: 0x7FFAC9346710
        public void .ctor(){} // RVA: 0x7FFAC92B3550 | overloaded x5
        public void get_ErrorCode(){} // RVA: 0x7FFAC3220660
        public void get_Message(){} // RVA: 0x7FFAC93467A0
        public void get_SocketErrorCode(){} // RVA: 0x7FFAC3220660
    }

    public class TcpClient : Object
    {
        public System.Net.Sockets.Socket Client; // 0x10
        public bool Connected; // 0x18
        public System.Net.Sockets.NetworkStream m_DataStream; // 0x20
        public 0x6B1406E8 m_Family; // 0x28
        public bool m_CleanedUp; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93472B0 | overloaded x4
        public void get_Client(){} // RVA: 0x7FFAC2F3C380
        public void set_Client(){} // RVA: 0x7FFAC2F22E30
        public void get_Connected(){} // RVA: 0x7FFAC9347310
        public void Connect(){} // RVA: 0x7FFAC9347AA0 | overloaded x2
        public void BeginConnect(){} // RVA: 0x7FFAC9347B90
        public void EndConnect(){} // RVA: 0x7FFAC9347BC0
        public void ConnectAsync(){} // RVA: 0x7FFAC9347BF0
        public void GetStream(){} // RVA: 0x7FFAC9347DB0
        public void Close(){} // RVA: 0x7FFAC9347F20
        public void Dispose(){} // RVA: 0x7FFAC2F6EFC0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8243E40
        public void initialize(){} // RVA: 0x7FFAC9348110
    }

    public class TcpListener : Object
    {
        public System.Net.IPEndPoint LocalEndpoint; // 0x10
        public System.Net.Sockets.Socket m_ServerSocket; // 0x18
        public bool m_Active; // 0x20
        public bool m_ExclusiveAddressUse; // 0x21

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93481E0
        public void get_LocalEndpoint(){} // RVA: 0x7FFAC9348450
        public void Start(){} // RVA: 0x7FFAC9348490 | overloaded x2
        public void Stop(){} // RVA: 0x7FFAC93485C0
        public void BeginAcceptTcpClient(){} // RVA: 0x7FFAC9348760
        public void EndAcceptTcpClient(){} // RVA: 0x7FFAC93487F0
    }

    public class UdpClient : Object
    {
        public System.Net.Sockets.Socket Client; // 0x10
        public bool m_Active; // 0x18
        public byte[] m_Buffer; // 0x20
        public 0x6B1406E8 m_Family; // 0x28
        public bool m_CleanedUp; // 0x2C
        public bool m_IsBroadcast; // 0x2D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93489A0
        public void get_Client(){} // RVA: 0x7FFAC2F3C380
        public void set_Client(){} // RVA: 0x7FFAC2F22E30
        public void FreeResources(){} // RVA: 0x7FFAC9348BE0
        public void Dispose(){} // RVA: 0x7FFAC9348C40 | overloaded x2
        public void CheckForBroadcast(){} // RVA: 0x7FFAC9348CE0
        public void IsBroadcast(){} // RVA: 0x7FFAC9348DC0
        public void BeginSend(){} // RVA: 0x7FFAC9348E50
        public void EndSend(){} // RVA: 0x7FFAC9349160
        public void BeginReceive(){} // RVA: 0x7FFAC9349220
        public void EndReceive(){} // RVA: 0x7FFAC9349380
        public void SendAsync(){} // RVA: 0x7FFAC9349740
        public void ReceiveAsync(){} // RVA: 0x7FFAC93498B0
        public void createClientSocket(){} // RVA: 0x7FFAC93499F0
        public void <ReceiveAsync>b__65_0(){} // RVA: 0x7FFAC9349220
        public void <ReceiveAsync>b__65_1(){} // RVA: 0x7FFAC9349AC0
    }

    public class UdpReceiveResult : ValueType
    {
        public byte[] Buffer; // 0x10
        public System.Net.IPEndPoint RemoteEndPoint; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9349C50
        public void get_Buffer(){} // RVA: 0x7FFAC3AD9F60
        public void get_RemoteEndPoint(){} // RVA: 0x7FFAC4420220
        public void GetHashCode(){} // RVA: 0x7FFAC9349DC0
        public void Equals(){} // RVA: 0x7FFAC69C26F0 | overloaded x2
    }

}