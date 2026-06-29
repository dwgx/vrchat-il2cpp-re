// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Sockets
// Classes: 17
// Methods: 291

namespace ThirdParty.DotNet.System.Net.Sockets
{
    public class IPPacketInformation : ValueType
    {
        public object address;
        public object networkInterface;

        // ── Methods ──
        public void Equals(){} // RVA: 0x91BB20
        public void GetHashCode(){} // RVA: 0x91BBF0
    }

    public class IPv6MulticastOption : Object
    {
        public object m_Group;
        public object m_Interface;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76111D0
        public void set_Group(){} // RVA: 0x7611290
        public void set_InterfaceIndex(){} // RVA: 0x7611340
    }

    public class LingerOption : Object
    {
        public object enabled;
        public object lingerTime;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7610E10
        public void set_Enabled(){} // RVA: 0xC120B0
        public void set_LingerTime(){} // RVA: 0x116BB10
    }

    public class MulticastOption : Object
    {
        public object group;
        public object localAddress;
        public object ifIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7610EE0
        public void set_Group(){} // RVA: 0xB44D60
        public void set_LocalAddress(){} // RVA: 0x7611050
    }

    public class NetworkStream : Stream
    {
        public object _streamSocket;
        public object _ownsSocket;
        public object _readable;
        public object _writeable;
        public object _closeTimeout;
        public object _cleanedUp;
        public object _currentReadTimeout;
        public object _currentWriteTimeout;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75F8B00
        public void get_CanRead(){} // RVA: 0xB68E10
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0x4674B20
        public void get_CanTimeout(){} // RVA: 0xC2E4C0
        public void get_ReadTimeout(){} // RVA: 0x75F8D00
        public void set_ReadTimeout(){} // RVA: 0x75F8D60
        public void get_WriteTimeout(){} // RVA: 0x75F8E00
        public void set_WriteTimeout(){} // RVA: 0x75F8E60
        public void get_DataAvailable(){} // RVA: 0x75F8F00
        public void get_Length(){} // RVA: 0x75F8FB0
        public void get_Position(){} // RVA: 0x75F9000
        public void set_Position(){} // RVA: 0x75F9050
        public void Seek(){} // RVA: 0x75F90A0
        public void Read(){} // RVA: 0x75F93B0
        public void ReadByte(){} // RVA: 0x75F96D0
        public void Write(){} // RVA: 0x75F9A10
        public void WriteByte(){} // RVA: 0x75F9CE0
        public void Close(){} // RVA: 0x75F9D50
        public void Dispose(){} // RVA: 0x75F9DD0
        public void Finalize(){} // RVA: 0x672B280
        public void BeginRead(){} // RVA: 0x75F9E50
        public void EndRead(){} // RVA: 0x75FA140
        public void BeginWrite(){} // RVA: 0x75FA2C0
        public void EndWrite(){} // RVA: 0x75FA5B0
        public void ReadAsync(){} // RVA: 0x75FAAB0
        public void WriteAsync(){} // RVA: 0x75FB040
        public void Flush(){} // RVA: 0xB43310
        public void FlushAsync(){} // RVA: 0x75FB240
        public void SetLength(){} // RVA: 0x75FB2E0
        public void SetSocketTimeoutOption(){} // RVA: 0x75FB330
        public void get_InternalSocket(){} // RVA: 0x75FB650
    }

    public class SafeSocketHandle : SafeHandleMinusOneIsInvalid
    {
        public object blocking_threads;
        public object threads_stacktraces;
        public object in_cleanup;
        public object SOCKET_CLOSED;
        public object ABORT_RETRIES;
        public object THROW_ON_ABORT_RETRIES;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76144F0
        public void ReleaseHandle(){} // RVA: 0x7614540
        public void RegisterForBlockingSyscall(){} // RVA: 0x7614CF0
        public void UnRegisterForBlockingSyscall(){} // RVA: 0x7615140
        public void .cctor(){} // RVA: 0x76153A0
    }

    public class SendPacketsElement : Object
    {
        public object m_FilePath;
        public object m_Buffer;
        public object m_Offset;
        public object m_Count;
        public object m_endOfPacket;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Socket : Object
    {
        public object AcceptCompletedHandler;
        public object ReceiveCompletedHandler;
        public object SendCompletedHandler;
        public object s_rentedSocketSentinel;
        public object s_rentedInt32Sentinel;
        public object s_zeroTask;
        public object _cachedTaskEventArgs;
        public object s_InternalSyncObject;
        public object s_SupportsIPv4;
        public object s_SupportsIPv6;
        public object s_OSSupportsIPv6;
        public object s_Initialized;
        public object s_LoggingEnabled;
        public object s_PerfCountersEnabled;
        public object DefaultCloseTimeout;
        public object SOCKET_CLOSED_CODE;
        public object TIMEOUT_EXCEPTION_MSG;
        public object is_closed;
        public object is_listening;
        public object useOverlappedIO;
        public object linger_timeout;
        public object addressFamily;
        public object socketType;
        public object protocolType;
        public object m_Handle;
        public object seed_endpoint;
        public object ReadSem;
        public object WriteSem;
        public object is_blocking;
        public object is_bound;
        public object is_connected;
        public object m_IntCleanedUp;
        public object connect_in_progress;
        public object ID;
        public object AcceptAsyncCallback;
        public object BeginAcceptCallback;
        public object BeginAcceptReceiveCallback;
        public object ConnectAsyncCallback;
        public object BeginConnectCallback;
        public object DisconnectAsyncCallback;
        public object BeginDisconnectCallback;
        public object ReceiveAsyncCallback;
        public object BeginReceiveCallback;
        public object BeginReceiveGenericCallback;
        public object ReceiveFromAsyncCallback;
        public object BeginReceiveFromCallback;
        public object SendAsyncCallback;
        public object BeginSendGenericCallback;
        public object SendToAsyncCallback;

        // ── Methods ──
        public void ConnectAsync(){} // RVA: 0x75FB6F0
        public void ReceiveAsync(){} // RVA: 0x7604580
        public void ReceiveAsyncApm(){} // RVA: 0x75FBDC0
        public void SendAsyncForNetworkStream(){} // RVA: 0x75FC400
        public void SendAsyncApm(){} // RVA: 0x75FC8F0
        public void CompleteAccept(){} // RVA: 0x75FCEF0
        public void CompleteSendReceive(){} // RVA: 0x75FD1C0
        public void GetException(){} // RVA: 0x75FD440
        public void ReturnSocketAsyncEventArgs(){} // RVA: 0x75FD670
        public void .ctor(){} // RVA: 0x75FF960
        public void get_OSSupportsIPv4(){} // RVA: 0x75FDB10
        public void get_OSSupportsIPv6(){} // RVA: 0x75FDB70
        public void get_Handle(){} // RVA: 0x74A9290
        public void get_AddressFamily(){} // RVA: 0xFEAE90
        public void get_SocketType(){} // RVA: 0x15AF000
        public void get_ProtocolType(){} // RVA: 0x1065D50
        public void get_ExclusiveAddressUse(){} // RVA: 0x75FDBD0
        public void set_ExclusiveAddressUse(){} // RVA: 0x75FDC20
        public void set_ReceiveTimeout(){} // RVA: 0x75FDCC0
        public void set_SendTimeout(){} // RVA: 0x75FDD50
        public void set_DontFragment(){} // RVA: 0x75FDDE0
        public void get_DualMode(){} // RVA: 0x75FDE80
        public void set_DualMode(){} // RVA: 0x75FDF50
        public void get_IsDualMode(){} // RVA: 0x75FDFF0
        public void CanTryAddressFamily(){} // RVA: 0x75FE050
        public void Connect(){} // RVA: 0x7601F50
        public void Send(){} // RVA: 0x7605DF0
        public void Receive(){} // RVA: 0x7604400
        public void IOControl(){} // RVA: 0x7608BB0
        public void SetIPProtectionLevel(){} // RVA: 0x75FEA50
        public void BeginConnect(){} // RVA: 0x7602850
        public void BeginSend(){} // RVA: 0x7606A30
        public void EndSend(){} // RVA: 0x76071E0
        public void BeginReceive(){} // RVA: 0x7604AB0
        public void EndReceive(){} // RVA: 0x7604D90
        public void get_InternalSyncObject(){} // RVA: 0x75FF1D0
        public void get_CleanedUp(){} // RVA: 0x1AA6CE0
        public void InitializeSockets(){} // RVA: 0x75FF300
        public void Dispose(){} // RVA: 0x76093B0
        public void Finalize(){} // RVA: 0x6527310
        public void InternalShutdown(){} // RVA: 0x75FF770
        public void SetSocketOption(){} // RVA: 0x76088F0
        public void SocketDefaults(){} // RVA: 0x75FFB40
        public void Socket_icall(){} // RVA: 0x75FFBB0
        public void get_Available(){} // RVA: 0x75FFD60
        public void Available_internal(){} // RVA: 0x75FFE10
        public void Available_icall(){} // RVA: 0x75FFF30
        public void get_IsBound(){} // RVA: 0x24BED30
        public void get_LocalEndPoint(){} // RVA: 0x75FFF40
        public void LocalEndPoint_internal(){} // RVA: 0x7600040
        public void LocalEndPoint_icall(){} // RVA: 0x7600170
        public void get_Blocking(){} // RVA: 0xC00EC0
        public void set_Blocking(){} // RVA: 0x7600180
        public void Blocking_internal(){} // RVA: 0x7600250
        public void Blocking_icall(){} // RVA: 0x7600370
        public void get_Connected(){} // RVA: 0x24BE000
        public void set_NoDelay(){} // RVA: 0x76004D0
        public void get_RemoteEndPoint(){} // RVA: 0x7600560
        public void RemoteEndPoint_internal(){} // RVA: 0x7600670
        public void RemoteEndPoint_icall(){} // RVA: 0x76007A0
        public void Poll(){} // RVA: 0x76007B0
        public void Poll_internal(){} // RVA: 0x7600950
        public void Poll_icall(){} // RVA: 0x7600AA0
        public void Accept(){} // RVA: 0x7600C50
        public void AcceptAsync(){} // RVA: 0x7600E20
        public void BeginAccept(){} // RVA: 0x7601140
        public void EndAccept(){} // RVA: 0x7601440
        public void Accept_internal(){} // RVA: 0x76015A0
        public void Accept_icall(){} // RVA: 0x7601740
        public void Bind(){} // RVA: 0x76017E0
        public void Bind_internal(){} // RVA: 0x76019D0
        public void Bind_icall(){} // RVA: 0x7601AF0
        public void Listen(){} // RVA: 0x7601B00
        public void Listen_internal(){} // RVA: 0x7601C10
        public void Listen_icall(){} // RVA: 0x7601D30
        public void BeginMConnect(){} // RVA: 0x7602B00
        public void BeginSConnect(){} // RVA: 0x7602D10
        public void EndConnect(){} // RVA: 0x7603360
        public void Connect_internal(){} // RVA: 0x7603420
        public void Connect_icall(){} // RVA: 0x7603530
        public void Disconnect(){} // RVA: 0x7603540
        public void EndDisconnect(){} // RVA: 0x7603650
        public void Disconnect_internal(){} // RVA: 0x7603710
        public void Disconnect_icall(){} // RVA: 0x7603830
        public void Receive_internal(){} // RVA: 0x7604FD0
        public void Receive_array_icall(){} // RVA: 0x7604FC0
        public void Receive_icall(){} // RVA: 0x7605100
        public void ReceiveFrom(){} // RVA: 0x7605110
        public void BeginReceiveFrom(){} // RVA: 0x76054C0
        public void EndReceiveFrom(){} // RVA: 0x7605840
        public void EndReceiveFrom_internal(){} // RVA: 0x76059C0
        public void ReceiveFrom_internal(){} // RVA: 0x7605AF0
        public void ReceiveFrom_icall(){} // RVA: 0x7605C30
        public void SendAsync(){} // RVA: 0x76063F0
        public void BeginSendCallback(){} // RVA: 0x7606E20
        public void Send_internal(){} // RVA: 0x7607420
        public void Send_array_icall(){} // RVA: 0x7607410
        public void Send_icall(){} // RVA: 0x7607550
        public void SendTo(){} // RVA: 0x7607560
        public void BeginSendTo(){} // RVA: 0x7607900
        public void BeginSendToCallback(){} // RVA: 0x7607D10
        public void EndSendTo(){} // RVA: 0x7607EF0
        public void SendTo_internal(){} // RVA: 0x7607FC0
        public void SendTo_icall(){} // RVA: 0x7608100
        public void GetSocketOption(){} // RVA: 0x7608110
        public void GetSocketOption_obj_internal(){} // RVA: 0x7608330
        public void GetSocketOption_obj_icall(){} // RVA: 0x7608470
        public void SetSocketOption_internal(){} // RVA: 0x7608A30
        public void SetSocketOption_icall(){} // RVA: 0x7608BA0
        public void IOControl_internal(){} // RVA: 0x7608D50
        public void IOControl_icall(){} // RVA: 0x7608EA0
        public void Close(){} // RVA: 0x7608EC0
        public void Close_icall(){} // RVA: 0x7608ED0
        public void Shutdown(){} // RVA: 0x7609020
        public void Shutdown_internal(){} // RVA: 0x7609130
        public void Shutdown_icall(){} // RVA: 0x7609250
        public void Linger(){} // RVA: 0x76096C0
        public void ThrowIfDisposedAndClosed(){} // RVA: 0x7609960
        public void ThrowIfBufferNull(){} // RVA: 0x76099F0
        public void ThrowIfBufferOutOfRange(){} // RVA: 0x7609A50
        public void ThrowIfUdp(){} // RVA: 0x7609C10
        public void ValidateEndIAsyncResult(){} // RVA: 0x7609C70
        public void QueueIOSelectorJob(){} // RVA: 0x7609DE0
        public void InitSocketAsyncEventArgs(){} // RVA: 0x760A010
        public void SocketOperationToSocketAsyncOperation(){} // RVA: 0x760A2D0
        public void RemapIPEndPoint(){} // RVA: 0x760A400
        public void cancel_blocking_socket_operation(){} // RVA: 0x760A670
        public void get_FamilyHint(){} // RVA: 0x760A710
        public void IsProtocolSupported_internal(){} // RVA: 0xC2E4C0
        public void IsProtocolSupported(){} // RVA: 0x760A850
        public void .cctor(){} // RVA: 0x760A8A0
    }

    public class SocketAsyncEventArgs : EventArgs
    {
        public object disposed;
        public object in_progress;
        public object remote_ep;
        public object current_socket;
        public object socket_async_result;
        public object _connectByNameError;
        public object _acceptSocket;
        public object _bytesTransferred;
        public object _disconnectReuseSocket;
        public object _lastOperation;
        public object _receiveMessageFromPacketInfo;
        public object _sendPacketsElements;
        public object _sendPacketsFlags;
        public object _sendPacketsSendSize;
        public object _socketError;
        public object _socketFlags;
        public object _userToken;
        public object Completed;
        public object _buffer;
        public object _offset;
        public object _count;
        public object _bufferIsExplicitArray;
        public object _bufferList;
        public object _bufferListInternal;

        // ── Methods ──
        public void get_AcceptSocket(){} // RVA: 0xD05CA0
        public void set_AcceptSocket(){} // RVA: 0xD09D70
        public void get_BytesTransferred(){} // RVA: 0xBE5850
        public void set_BytesTransferred(){} // RVA: 0xBE5860
        public void set_LastOperation(){} // RVA: 0xBE58A0
        public void set_RemoteEndPoint(){} // RVA: 0xBA9BA0
        public void set_SendPacketsSendSize(){} // RVA: 0x2540700
        public void get_SocketError(){} // RVA: 0x19C6270
        public void set_SocketError(){} // RVA: 0xCE5450
        public void set_SocketFlags(){} // RVA: 0x26432E0
        public void get_UserToken(){} // RVA: 0xCD3320
        public void set_UserToken(){} // RVA: 0xCD4740
        public void add_Completed(){} // RVA: 0x7615470
        public void remove_Completed(){} // RVA: 0x7615590
        public void .ctor(){} // RVA: 0x7615770
        public void Finalize(){} // RVA: 0x7615830
        public void Dispose(){} // RVA: 0x7615860
        public void SetBytesTransferred(){} // RVA: 0xBE5860
        public void get_CurrentSocket(){} // RVA: 0xB700F0
        public void SetCurrentSocket(){} // RVA: 0xB70100
        public void SetLastOperation(){} // RVA: 0x76158C0
        public void Complete_internal(){} // RVA: 0x7615980
        public void OnCompleted(){} // RVA: 0x76159B0
        public void get_Buffer(){} // RVA: 0x76159E0
        public void get_MemoryBuffer(){} // RVA: 0x6D099E0
        public void get_Offset(){} // RVA: 0x262A930
        public void get_Count(){} // RVA: 0x262A910
        public void get_BufferList(){} // RVA: 0x12EB090
        public void SetBuffer(){} // RVA: 0x7615CF0
    }

    public class SocketAsyncResult : IOAsyncResult
    {
        public object socket;
        public object operation;
        public object DelayedException;
        public object EndPoint;
        public object Buffer;
        public object Offset;
        public object Size;
        public object SockFlags;
        public object AcceptSocket;
        public object Addresses;
        public object Port;
        public object Buffers;
        public object ReuseSocket;
        public object CurrentAddress;
        public object AcceptedSocket;
        public object Total;
        public object error;
        public object EndCalled;

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7615E20
        public void .ctor(){} // RVA: 0x7616270
        public void Init(){} // RVA: 0x7615E50
        public void get_ErrorCode(){} // RVA: 0x7616390
        public void CheckIfThrowDelayedException(){} // RVA: 0x7616420
        public void CompleteDisposed(){} // RVA: 0x76164D0
        public void Complete(){} // RVA: 0x76168D0
    }

    public class SocketException : Win32Exception
    {
        public object m_EndPoint;

        // ── Methods ──
        public void WSAGetLastError_icall(){} // RVA: 0x7610BD0
        public void .ctor(){} // RVA: 0x7580C70
        public void get_ErrorCode(){} // RVA: 0xF3A950
        public void get_Message(){} // RVA: 0x7610C60
        public void get_SocketErrorCode(){} // RVA: 0xF3A950
    }

    public class TcpClient : Object
    {
        public object m_ClientSocket;
        public object m_Active;
        public object m_DataStream;
        public object m_Family;
        public object m_CleanedUp;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7611770
        public void get_Client(){} // RVA: 0xB5DBF0
        public void set_Client(){} // RVA: 0xB44D60
        public void get_Connected(){} // RVA: 0x76117D0
        public void Connect(){} // RVA: 0x7611F50
        public void BeginConnect(){} // RVA: 0x7612040
        public void EndConnect(){} // RVA: 0x7612070
        public void ConnectAsync(){} // RVA: 0x76120A0
        public void GetStream(){} // RVA: 0x7612260
        public void Close(){} // RVA: 0x76123D0
        public void Dispose(){} // RVA: 0xB90310
        public void Finalize(){} // RVA: 0x6527310
        public void initialize(){} // RVA: 0x76125B0
    }

    public class TcpClient[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TcpListener : Object
    {
        public object m_ServerSocketEP;
        public object m_ServerSocket;
        public object m_Active;
        public object m_ExclusiveAddressUse;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7612680
        public void get_LocalEndpoint(){} // RVA: 0x76128F0
        public void Start(){} // RVA: 0x7612930
        public void Stop(){} // RVA: 0x7612A60
        public void BeginAcceptTcpClient(){} // RVA: 0x7612C00
        public void EndAcceptTcpClient(){} // RVA: 0x7612C90
    }

    public class UdpClient : Object
    {
        public object m_ClientSocket;
        public object m_Active;
        public object m_Buffer;
        public object m_Family;
        public object m_CleanedUp;
        public object m_IsBroadcast;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7612E40
        public void get_Client(){} // RVA: 0xB5DBF0
        public void set_Client(){} // RVA: 0xB44D60
        public void FreeResources(){} // RVA: 0x7613080
        public void Dispose(){} // RVA: 0x76130E0
        public void CheckForBroadcast(){} // RVA: 0x7613180
        public void IsBroadcast(){} // RVA: 0x7613260
        public void BeginSend(){} // RVA: 0x76132F0
        public void EndSend(){} // RVA: 0x7613600
        public void BeginReceive(){} // RVA: 0x76136B0
        public void EndReceive(){} // RVA: 0x7613810
        public void SendAsync(){} // RVA: 0x7613BD0
        public void ReceiveAsync(){} // RVA: 0x7613D40
        public void createClientSocket(){} // RVA: 0x7613E80
        public void <ReceiveAsync>b__65_0(){} // RVA: 0x76136B0
        public void <ReceiveAsync>b__65_1(){} // RVA: 0x7613F50
    }

    public class UdpClient[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class UdpReceiveResult : ValueType
    {
        public object m_buffer;
        public object m_remoteEndPoint;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x91BCF0
        public void get_Buffer(){} // RVA: 0x77900
        public void get_RemoteEndPoint(){} // RVA: 0x77ED0
        public void GetHashCode(){} // RVA: 0x91BD00
        public void Equals(){} // RVA: 0x4A33E0
    }

}