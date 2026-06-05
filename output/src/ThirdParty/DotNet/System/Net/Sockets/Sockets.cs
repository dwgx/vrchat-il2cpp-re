// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Sockets
// Classes: 15
// Methods: 326

namespace ThirdParty.DotNet.System.Net.Sockets
{
    public class IPPacketInformation
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAF965FCC0
        public void GetHashCode(){} // RVA: 0x7FFAF965FD90
    }

    public class IPv6MulticastOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9660190 | overloaded x2
        public void set_Group(){} // RVA: 0x7FFAF9660250
        public void set_InterfaceIndex(){} // RVA: 0x7FFAF9660300
    }

    public class LingerOption
    {
        public object Group;
        public object LocalAddress;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF965FDD0
        public void set_Enabled(){} // RVA: 0x7FFAF2E575F0
        public void set_LingerTime(){} // RVA: 0x7FFAF335C660
    }

    public class MulticastOption
    {
        public object Group;
        public object InterfaceIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF965FEA0 | overloaded x2
        public void set_Group(){} // RVA: 0x7FFAF2D8EE30
        public void set_LocalAddress(){} // RVA: 0x7FFAF9660010
    }

    public class NetworkStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9646EA0 | overloaded x3
        public void get_CanRead(){} // RVA: 0x7FFAF2DB3470
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF6697520
        public void get_CanTimeout(){} // RVA: 0x7FFAF2E72850
        public void get_ReadTimeout(){} // RVA: 0x7FFAF96470A0
        public void set_ReadTimeout(){} // RVA: 0x7FFAF9647130
        public void get_WriteTimeout(){} // RVA: 0x7FFAF96471D0
        public void set_WriteTimeout(){} // RVA: 0x7FFAF9647260
        public void get_DataAvailable(){} // RVA: 0x7FFAF9647300
        public void get_Length(){} // RVA: 0x7FFAF96473B0
        public void get_Position(){} // RVA: 0x7FFAF9647400
        public void set_Position(){} // RVA: 0x7FFAF9647450
        public void Seek(){} // RVA: 0x7FFAF96474A0
        public void Read(){} // RVA: 0x7FFAF9647890 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFAF9647BE0
        public void Write(){} // RVA: 0x7FFAF9648000 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFAF9648310
        public void Close(){} // RVA: 0x7FFAF9648380
        public void Dispose(){} // RVA: 0x7FFAF9648400
        public void Finalize(){} // RVA: 0x7FFAF8762900
        public void BeginRead(){} // RVA: 0x7FFAF9648480
        public void EndRead(){} // RVA: 0x7FFAF9648840
        public void BeginWrite(){} // RVA: 0x7FFAF9648AA0
        public void EndWrite(){} // RVA: 0x7FFAF9648E60
        public void ReadAsync(){} // RVA: 0x7FFAF9649510 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFAF9649C40 | overloaded x2
        public void Flush(){} // RVA: 0x7FFAF2D8D310
        public void FlushAsync(){} // RVA: 0x7FFAF9649F00
        public void SetLength(){} // RVA: 0x7FFAF9649FA0
        public void SetSocketTimeoutOption(){} // RVA: 0x7FFAF9649FF0
        public void get_InternalSocket(){} // RVA: 0x7FFAF964A340
    }

    public class SafeSocketHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96633B0
        public void ReleaseHandle(){} // RVA: 0x7FFAF96634E0
        public void RegisterForBlockingSyscall(){} // RVA: 0x7FFAF9663C90
        public void UnRegisterForBlockingSyscall(){} // RVA: 0x7FFAF9664110
        public void .cctor(){} // RVA: 0x7FFAF96643B0
    }

    public class SendPacketsElement
    {
    }

    public class Socket
    {
        // ── Methods ──
        public void ConnectAsync(){} // RVA: 0x7FFAF964A3E0
        public void ReceiveAsync(){} // RVA: 0x7FFAF96535B0 | overloaded x2
        public void ReceiveAsyncApm(){} // RVA: 0x7FFAF964AAD0
        public void SendAsyncForNetworkStream(){} // RVA: 0x7FFAF964B130
        public void SendAsyncApm(){} // RVA: 0x7FFAF964B630
        public void CompleteAccept(){} // RVA: 0x7FFAF964BC30
        public void CompleteSendReceive(){} // RVA: 0x7FFAF964BEF0
        public void GetException(){} // RVA: 0x7FFAF964C170
        public void ReturnSocketAsyncEventArgs(){} // RVA: 0x7FFAF964C390 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF964E780 | overloaded x2
        public void get_OSSupportsIPv4(){} // RVA: 0x7FFAF964C830
        public void get_OSSupportsIPv6(){} // RVA: 0x7FFAF964C890
        public void get_Handle(){} // RVA: 0x7FFAF94F3BA0
        public void get_AddressFamily(){} // RVA: 0x7FFAF3210030
        public void get_SocketType(){} // RVA: 0x7FFAF379F5B0
        public void get_ProtocolType(){} // RVA: 0x7FFAF3241DC0
        public void get_ExclusiveAddressUse(){} // RVA: 0x7FFAF964C8F0
        public void set_ExclusiveAddressUse(){} // RVA: 0x7FFAF964C970
        public void set_ReceiveTimeout(){} // RVA: 0x7FFAF964CA10
        public void set_SendTimeout(){} // RVA: 0x7FFAF964CAA0
        public void set_DontFragment(){} // RVA: 0x7FFAF964CB30
        public void get_DualMode(){} // RVA: 0x7FFAF964CBD0
        public void set_DualMode(){} // RVA: 0x7FFAF964CCC0
        public void get_IsDualMode(){} // RVA: 0x7FFAF964CD60
        public void CanTryAddressFamily(){} // RVA: 0x7FFAF964CE50
        public void Connect(){} // RVA: 0x7FFAF9650E70 | overloaded x4
        public void Send(){} // RVA: 0x7FFAF9654E10 | overloaded x7
        public void Receive(){} // RVA: 0x7FFAF9653430 | overloaded x8
        public void IOControl(){} // RVA: 0x7FFAF9657BE0 | overloaded x2
        public void SetIPProtectionLevel(){} // RVA: 0x7FFAF964D850
        public void BeginConnect(){} // RVA: 0x7FFAF9651750 | overloaded x4
        public void BeginSend(){} // RVA: 0x7FFAF9655A70 | overloaded x2
        public void EndSend(){} // RVA: 0x7FFAF9656220 | overloaded x2
        public void BeginReceive(){} // RVA: 0x7FFAF9653AE0 | overloaded x2
        public void EndReceive(){} // RVA: 0x7FFAF9653DC0 | overloaded x2
        public void get_InternalSyncObject(){} // RVA: 0x7FFAF964DFD0
        public void get_CleanedUp(){} // RVA: 0x7FFAF3C52580
        public void InitializeSockets(){} // RVA: 0x7FFAF964E100
        public void Dispose(){} // RVA: 0x7FFAF96583D0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF855C950
        public void InternalShutdown(){} // RVA: 0x7FFAF964E590
        public void SetSocketOption(){} // RVA: 0x7FFAF9657920 | overloaded x4
        public void SocketDefaults(){} // RVA: 0x7FFAF964E960
        public void Socket_icall(){} // RVA: 0x7FFAF964E9D0
        public void get_Available(){} // RVA: 0x7FFAF964EB80
        public void Available_internal(){} // RVA: 0x7FFAF964EC30
        public void Available_icall(){} // RVA: 0x7FFAF964ED50
        public void get_IsBound(){} // RVA: 0x7FFAF4694C90
        public void get_LocalEndPoint(){} // RVA: 0x7FFAF964ED60
        public void LocalEndPoint_internal(){} // RVA: 0x7FFAF964EE60
        public void LocalEndPoint_icall(){} // RVA: 0x7FFAF964EF90
        public void get_Blocking(){} // RVA: 0x7FFAF2E478E0
        public void set_Blocking(){} // RVA: 0x7FFAF964EFA0
        public void Blocking_internal(){} // RVA: 0x7FFAF964F070
        public void Blocking_icall(){} // RVA: 0x7FFAF964F190
        public void get_Connected(){} // RVA: 0x7FFAF4695300
        public void set_NoDelay(){} // RVA: 0x7FFAF964F2E0
        public void get_RemoteEndPoint(){} // RVA: 0x7FFAF964F370
        public void RemoteEndPoint_internal(){} // RVA: 0x7FFAF964F480
        public void RemoteEndPoint_icall(){} // RVA: 0x7FFAF964F5B0
        public void Poll(){} // RVA: 0x7FFAF964F5C0
        public void Poll_internal(){} // RVA: 0x7FFAF964F770
        public void Poll_icall(){} // RVA: 0x7FFAF964F8C0
        public void Accept(){} // RVA: 0x7FFAF964FA70 | overloaded x2
        public void AcceptAsync(){} // RVA: 0x7FFAF964FC40
        public void BeginAccept(){} // RVA: 0x7FFAF964FF60
        public void EndAccept(){} // RVA: 0x7FFAF9650250 | overloaded x2
        public void Accept_internal(){} // RVA: 0x7FFAF96503B0
        public void Accept_icall(){} // RVA: 0x7FFAF9650550
        public void Bind(){} // RVA: 0x7FFAF96505F0
        public void Bind_internal(){} // RVA: 0x7FFAF96507E0
        public void Bind_icall(){} // RVA: 0x7FFAF9650900
        public void Listen(){} // RVA: 0x7FFAF9650910
        public void Listen_internal(){} // RVA: 0x7FFAF9650A20
        public void Listen_icall(){} // RVA: 0x7FFAF9650C60
        public void BeginMConnect(){} // RVA: 0x7FFAF9651A00
        public void BeginSConnect(){} // RVA: 0x7FFAF9651C00
        public void EndConnect(){} // RVA: 0x7FFAF9652250
        public void Connect_internal(){} // RVA: 0x7FFAF9652310
        public void Connect_icall(){} // RVA: 0x7FFAF9652420
        public void Disconnect(){} // RVA: 0x7FFAF9652430
        public void EndDisconnect(){} // RVA: 0x7FFAF9652540
        public void Disconnect_internal(){} // RVA: 0x7FFAF9652600
        public void Disconnect_icall(){} // RVA: 0x7FFAF9652830
        public void Receive_internal(){} // RVA: 0x7FFAF9654000 | overloaded x2
        public void Receive_array_icall(){} // RVA: 0x7FFAF9653FF0
        public void Receive_icall(){} // RVA: 0x7FFAF9654130
        public void ReceiveFrom(){} // RVA: 0x7FFAF9654140
        public void BeginReceiveFrom(){} // RVA: 0x7FFAF96544E0
        public void EndReceiveFrom(){} // RVA: 0x7FFAF9654860
        public void EndReceiveFrom_internal(){} // RVA: 0x7FFAF96549E0
        public void ReceiveFrom_internal(){} // RVA: 0x7FFAF9654B10
        public void ReceiveFrom_icall(){} // RVA: 0x7FFAF9654C50
        public void SendAsync(){} // RVA: 0x7FFAF9655430
        public void BeginSendCallback(){} // RVA: 0x7FFAF9655E60
        public void Send_internal(){} // RVA: 0x7FFAF9656460 | overloaded x2
        public void Send_array_icall(){} // RVA: 0x7FFAF9656450
        public void Send_icall(){} // RVA: 0x7FFAF9656590
        public void SendTo(){} // RVA: 0x7FFAF96565A0
        public void BeginSendTo(){} // RVA: 0x7FFAF9656920
        public void BeginSendToCallback(){} // RVA: 0x7FFAF9656D30
        public void EndSendTo(){} // RVA: 0x7FFAF9656F10
        public void SendTo_internal(){} // RVA: 0x7FFAF9656FE0
        public void SendTo_icall(){} // RVA: 0x7FFAF9657120
        public void GetSocketOption(){} // RVA: 0x7FFAF9657130
        public void GetSocketOption_obj_internal(){} // RVA: 0x7FFAF9657360
        public void GetSocketOption_obj_icall(){} // RVA: 0x7FFAF96574A0
        public void SetSocketOption_internal(){} // RVA: 0x7FFAF9657A60
        public void SetSocketOption_icall(){} // RVA: 0x7FFAF9657BD0
        public void IOControl_internal(){} // RVA: 0x7FFAF9657D80
        public void IOControl_icall(){} // RVA: 0x7FFAF9657ED0
        public void Close(){} // RVA: 0x7FFAF9657EF0 | overloaded x2
        public void Close_icall(){} // RVA: 0x7FFAF9657F00
        public void Shutdown(){} // RVA: 0x7FFAF9658050
        public void Shutdown_internal(){} // RVA: 0x7FFAF9658160
        public void Shutdown_icall(){} // RVA: 0x7FFAF9658280
        public void Linger(){} // RVA: 0x7FFAF96586E0
        public void ThrowIfDisposedAndClosed(){} // RVA: 0x7FFAF9658980
        public void ThrowIfBufferNull(){} // RVA: 0x7FFAF9658A10
        public void ThrowIfBufferOutOfRange(){} // RVA: 0x7FFAF9658A70
        public void ThrowIfUdp(){} // RVA: 0x7FFAF9658C30
        public void ValidateEndIAsyncResult(){} // RVA: 0x7FFAF9658C90
        public void QueueIOSelectorJob(){} // RVA: 0x7FFAF9658E00
        public void InitSocketAsyncEventArgs(){} // RVA: 0x7FFAF9659030
        public void SocketOperationToSocketAsyncOperation(){} // RVA: 0x7FFAF96592F0
        public void RemapIPEndPoint(){} // RVA: 0x7FFAF9659420
        public void cancel_blocking_socket_operation(){} // RVA: 0x7FFAF9659650
        public void get_FamilyHint(){} // RVA: 0x7FFAF96596F0
        public void IsProtocolSupported_internal(){} // RVA: 0x7FFAF2E72850
        public void IsProtocolSupported(){} // RVA: 0x7FFAF9659830
        public void .cctor(){} // RVA: 0x7FFAF9659880
    }

    public class SocketAsyncEventArgs
    {
        // ── Methods ──
        public void get_AcceptSocket(){} // RVA: 0x7FFAF2F476A0
        public void set_AcceptSocket(){} // RVA: 0x7FFAF2F4B830
        public void get_BytesTransferred(){} // RVA: 0x7FFAF2E2E080
        public void set_BytesTransferred(){} // RVA: 0x7FFAF2E2E090
        public void set_LastOperation(){} // RVA: 0x7FFAF2E2E0D0
        public void set_RemoteEndPoint(){} // RVA: 0x7FFAF2DF3E80
        public void set_SendPacketsSendSize(){} // RVA: 0x7FFAF4741470
        public void get_SocketError(){} // RVA: 0x7FFAF3B95CF0
        public void set_SocketError(){} // RVA: 0x7FFAF2F25080
        public void set_SocketFlags(){} // RVA: 0x7FFAF483D640
        public void get_UserToken(){} // RVA: 0x7FFAF2F77C50
        public void set_UserToken(){} // RVA: 0x7FFAF2F734F0
        public void add_Completed(){} // RVA: 0x7FFAF9664480
        public void remove_Completed(){} // RVA: 0x7FFAF9664580
        public void .ctor(){} // RVA: 0x7FFAF9664740 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF9664800
        public void Dispose(){} // RVA: 0x7FFAF9664830 | overloaded x2
        public void SetBytesTransferred(){} // RVA: 0x7FFAF2E2E090
        public void get_CurrentSocket(){} // RVA: 0x7FFAF2DBB0C0
        public void SetCurrentSocket(){} // RVA: 0x7FFAF2DBB0D0
        public void SetLastOperation(){} // RVA: 0x7FFAF9664890
        public void Complete_internal(){} // RVA: 0x7FFAF9664950
        public void OnCompleted(){} // RVA: 0x7FFAF9664980
        public void get_Buffer(){} // RVA: 0x7FFAF96649B0
        public void get_MemoryBuffer(){} // RVA: 0x7FFAF821C5E0
        public void get_Offset(){} // RVA: 0x7FFAF4826570
        public void get_Count(){} // RVA: 0x7FFAF4826560
        public void get_BufferList(){} // RVA: 0x7FFAF34CC130
        public void SetBuffer(){} // RVA: 0x7FFAF9664CC0 | overloaded x2
    }

    public class SocketAsyncResult
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAF9664DF0
        public void .ctor(){} // RVA: 0x7FFAF9665220 | overloaded x2
        public void Init(){} // RVA: 0x7FFAF9664E20
        public void get_ErrorCode(){} // RVA: 0x7FFAF9665340
        public void CheckIfThrowDelayedException(){} // RVA: 0x7FFAF96653E0
        public void CompleteDisposed(){} // RVA: 0x7FFAF9665490
        public void Complete(){} // RVA: 0x7FFAF9665890 | overloaded x7
    }

    public class SocketException
    {
        // ── Methods ──
        public void WSAGetLastError_icall(){} // RVA: 0x7FFAF965FB90
        public void .ctor(){} // RVA: 0x7FFAF95CC9D0 | overloaded x5
        public void get_ErrorCode(){} // RVA: 0x7FFAF315FD40
        public void get_Message(){} // RVA: 0x7FFAF965FC20
        public void get_SocketErrorCode(){} // RVA: 0x7FFAF315FD40
    }

    public class TcpClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9660730 | overloaded x4
        public void get_Client(){} // RVA: 0x7FFAF2DA8380
        public void set_Client(){} // RVA: 0x7FFAF2D8EE30
        public void get_Connected(){} // RVA: 0x7FFAF9660790
        public void Connect(){} // RVA: 0x7FFAF9660F20 | overloaded x2
        public void BeginConnect(){} // RVA: 0x7FFAF9661010
        public void EndConnect(){} // RVA: 0x7FFAF9661040
        public void ConnectAsync(){} // RVA: 0x7FFAF9661070
        public void GetStream(){} // RVA: 0x7FFAF9661230
        public void Close(){} // RVA: 0x7FFAF96613A0
        public void Dispose(){} // RVA: 0x7FFAF2DDAFC0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF855C950
        public void initialize(){} // RVA: 0x7FFAF9661590
    }

    public class TcpListener
    {
        public object AddressFamily;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9661660
        public void get_LocalEndpoint(){} // RVA: 0x7FFAF96618D0
        public void Start(){} // RVA: 0x7FFAF9661910 | overloaded x2
        public void Stop(){} // RVA: 0x7FFAF9661A40
        public void BeginAcceptTcpClient(){} // RVA: 0x7FFAF9661BE0
        public void EndAcceptTcpClient(){} // RVA: 0x7FFAF9661C70
    }

    public class UdpClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9661E20
        public void get_Client(){} // RVA: 0x7FFAF2DA8380
        public void set_Client(){} // RVA: 0x7FFAF2D8EE30
        public void FreeResources(){} // RVA: 0x7FFAF9662060
        public void Dispose(){} // RVA: 0x7FFAF96620C0 | overloaded x2
        public void CheckForBroadcast(){} // RVA: 0x7FFAF9662160
        public void IsBroadcast(){} // RVA: 0x7FFAF9662240
        public void BeginSend(){} // RVA: 0x7FFAF96622D0
        public void EndSend(){} // RVA: 0x7FFAF96625E0
        public void BeginReceive(){} // RVA: 0x7FFAF96626A0
        public void EndReceive(){} // RVA: 0x7FFAF9662800
        public void SendAsync(){} // RVA: 0x7FFAF9662BC0
        public void ReceiveAsync(){} // RVA: 0x7FFAF9662D30
        public void createClientSocket(){} // RVA: 0x7FFAF9662E70
        public void <ReceiveAsync>b__65_0(){} // RVA: 0x7FFAF96626A0
        public void <ReceiveAsync>b__65_1(){} // RVA: 0x7FFAF9662F40
    }

    public class UdpReceiveResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96630D0
        public void get_Buffer(){} // RVA: 0x7FFAF4584690
        public void get_RemoteEndPoint(){} // RVA: 0x7FFAF44189C0
        public void GetHashCode(){} // RVA: 0x7FFAF9663240
        public void Equals(){} // RVA: 0x7FFAF6B5D960 | overloaded x2
    }

}