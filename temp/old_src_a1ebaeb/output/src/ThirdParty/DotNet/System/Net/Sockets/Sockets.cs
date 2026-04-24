// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Sockets
// Classes: 2
// Methods: 199

namespace ThirdParty.DotNet.System.Net.Sockets
{
    public class Socket : Object
    {
        public object SendCompletedHandler; // 0x313EA1D0
        public object s_zeroTask; // 0x313EA1D0
        public object s_SupportsIPv4; // 0x313EA1D0
        public object s_Initialized; // 0x313EA1D0
        public object DefaultCloseTimeout; // 0x313EA1D0
        public object is_closed; // 0x313EA1D0
        public object linger_timeout; // 0x313EA1D0
        public object protocolType; // 0x313EA1D0
        public object ReadSem; // 0x313EA1D0
        public object is_bound; // 0x313EA1D0
        public object connect_in_progress; // 0x313EA1D0
        public object BeginAcceptCallback; // 0x313EA1D0
        public object BeginConnectCallback; // 0x313EA1D0
        public object ReceiveAsyncCallback; // 0x313EA1D0
        public object ReceiveFromAsyncCallback; // 0x313EA1D0
        public object BeginSendGenericCallback; // 0x313EA1D0

        // ── Original Methods ──
        public void ConnectAsync(){} // RVA: 0x7ffaaed52f30
        public void ReceiveAsync(){} // RVA: 0x7ffaaed5c100
        public void ReceiveAsyncApm(){} // RVA: 0x7ffaaed53620
        public void SendAsyncForNetworkStream(){} // RVA: 0x7ffaaed53c80
        public void SendAsyncApm(){} // RVA: 0x7ffaaed54180
        public void CompleteAccept(){} // RVA: 0x7ffaaed54780
        public void CompleteSendReceive(){} // RVA: 0x7ffaaed54a40
        public void ReturnSocketAsyncEventArgs(){} // RVA: 0x7ffaaed54ee0
        public void ReturnSocketAsyncEventArgs(){} // RVA: 0x7ffaaed54ee0
        public void .ctor(){} // RVA: 0x7ffaaed572d0
        public void get_OSSupportsIPv4(){} // RVA: 0x7ffaaed55380
        public void get_OSSupportsIPv6(){} // RVA: 0x7ffaaed553e0
        public void get_Handle(){} // RVA: 0x7ffaaebfc6f0
        public void get_AddressFamily(){} // RVA: 0x7ffaa8aeced0
        public void get_SocketType(){} // RVA: 0x7ffaa9349010
        public void get_ProtocolType(){} // RVA: 0x7ffaa8d14570
        public void get_ExclusiveAddressUse(){} // RVA: 0x7ffaaed55440
        public void set_ExclusiveAddressUse(){} // RVA: 0x7ffaaed554c0
        public void set_ReceiveTimeout(){} // RVA: 0x7ffaaed55560
        public void set_SendTimeout(){} // RVA: 0x7ffaaed555f0
        public void set_DontFragment(){} // RVA: 0x7ffaaed55680
        public void get_DualMode(){} // RVA: 0x7ffaaed55720
        public void set_DualMode(){} // RVA: 0x7ffaaed55810
        public void get_IsDualMode(){} // RVA: 0x7ffaaed558b0
        public void CanTryAddressFamily(){} // RVA: 0x7ffaaed559a0
        public void Connect(){} // RVA: 0x7ffaaed599c0
        public void Send(){} // RVA: 0x7ffaaed5d960
        public void Send(){} // RVA: 0x7ffaaed5d960
        public void Send(){} // RVA: 0x7ffaaed5d960
        public void Send(){} // RVA: 0x7ffaaed5d960
        public void Receive(){} // RVA: 0x7ffaaed5bf80
        public void Receive(){} // RVA: 0x7ffaaed5bf80
        public void Receive(){} // RVA: 0x7ffaaed5bf80
        public void Receive(){} // RVA: 0x7ffaaed5bf80
        public void IOControl(){} // RVA: 0x7ffaaed60730
        public void EndSend(){} // RVA: 0x7ffaaed5ed70
        public void EndReceive(){} // RVA: 0x7ffaaed5c910
        public void get_InternalSyncObject(){} // RVA: 0x7ffaaed56b20
        public void get_CleanedUp(){} // RVA: 0x7ffaa9688910
        public void InitializeSockets(){} // RVA: 0x7ffaaed56c50
        public void Dispose(){} // RVA: 0x7ffaaed60f20
        public void Finalize(){} // RVA: 0x7ffaadc64ff0
        public void InternalShutdown(){} // RVA: 0x7ffaaed570e0
        public void .ctor(){} // RVA: 0x7ffaaed572d0
        public void SocketDefaults(){} // RVA: 0x7ffaaed574b0
        public void Socket_icall(){} // RVA: 0x7ffaaed57520
        public void get_Available(){} // RVA: 0x7ffaaed576d0
        public void Available_internal(){} // RVA: 0x7ffaaed57780
        public void Available_icall(){} // RVA: 0x7ffaaed578a0
        public void get_IsBound(){} // RVA: 0x7ffaadeaa2d0
        public void get_LocalEndPoint(){} // RVA: 0x7ffaaed578b0
        public void LocalEndPoint_internal(){} // RVA: 0x7ffaaed579b0
        public void LocalEndPoint_icall(){} // RVA: 0x7ffaaed57ae0
        public void get_Blocking(){} // RVA: 0x7ffaa89ec8e0
        public void set_Blocking(){} // RVA: 0x7ffaaed57af0
        public void Blocking_internal(){} // RVA: 0x7ffaaed57bc0
        public void Blocking_icall(){} // RVA: 0x7ffaaed57ce0
        public void get_Connected(){} // RVA: 0x7ffaadc80b50
        public void set_NoDelay(){} // RVA: 0x7ffaaed57e30
        public void get_RemoteEndPoint(){} // RVA: 0x7ffaaed57ec0
        public void RemoteEndPoint_internal(){} // RVA: 0x7ffaaed57fd0
        public void RemoteEndPoint_icall(){} // RVA: 0x7ffaaed58100
        public void Poll(){} // RVA: 0x7ffaaed58110
        public void Poll_internal(){} // RVA: 0x7ffaaed582c0
        public void Poll_icall(){} // RVA: 0x7ffaaed58410
        public void Accept(){} // RVA: 0x7ffaaed585c0
        public void Accept(){} // RVA: 0x7ffaaed585c0
        public void AcceptAsync(){} // RVA: 0x7ffaaed58790
        public void EndAccept(){} // RVA: 0x7ffaaed58da0
        public void EndAccept(){} // RVA: 0x7ffaaed58da0
        public void Accept_internal(){} // RVA: 0x7ffaaed58f00
        public void Accept_icall(){} // RVA: 0x7ffaaed590a0
        public void Bind(){} // RVA: 0x7ffaaed59140
        public void Bind_internal(){} // RVA: 0x7ffaaed59330
        public void Bind_icall(){} // RVA: 0x7ffaaed59450
        public void Listen(){} // RVA: 0x7ffaaed59460
        public void Listen_internal(){} // RVA: 0x7ffaaed59570
        public void Listen_icall(){} // RVA: 0x7ffaaed597b0
        public void Connect(){} // RVA: 0x7ffaaed599c0
        public void Connect(){} // RVA: 0x7ffaaed599c0
        public void Connect(){} // RVA: 0x7ffaaed599c0
        public void EndConnect(){} // RVA: 0x7ffaaed5ada0
        public void Connect_internal(){} // RVA: 0x7ffaaed5ae60
        public void Connect_icall(){} // RVA: 0x7ffaaed5af70
        public void Disconnect(){} // RVA: 0x7ffaaed5af80
        public void EndDisconnect(){} // RVA: 0x7ffaaed5b090
        public void Disconnect_internal(){} // RVA: 0x7ffaaed5b150
        public void Disconnect_icall(){} // RVA: 0x7ffaaed5b380
        public void Receive(){} // RVA: 0x7ffaaed5bf80
        public void Receive(){} // RVA: 0x7ffaaed5bf80
        public void Receive(){} // RVA: 0x7ffaaed5bf80
        public void Receive(){} // RVA: 0x7ffaaed5bf80
        public void Send(){} // RVA: 0x7ffaaed5d960
        public void ReceiveAsync(){} // RVA: 0x7ffaaed5c100
        public void EndReceive(){} // RVA: 0x7ffaaed5c910
        public void Receive_internal(){} // RVA: 0x7ffaaed5cb50
        public void Receive_array_icall(){} // RVA: 0x7ffaaed5cb40
        public void Receive_internal(){} // RVA: 0x7ffaaed5cb50
        public void Receive_icall(){} // RVA: 0x7ffaaed5cc80
        public void ReceiveFrom(){} // RVA: 0x7ffaaed5cc90
        public void EndReceiveFrom(){} // RVA: 0x7ffaaed5d3b0
        public void EndReceiveFrom_internal(){} // RVA: 0x7ffaaed5d530
        public void ReceiveFrom_internal(){} // RVA: 0x7ffaaed5d660
        public void ReceiveFrom_icall(){} // RVA: 0x7ffaaed5d7a0
        public void Send(){} // RVA: 0x7ffaaed5d960
        public void Send(){} // RVA: 0x7ffaaed5d960
        public void SendAsync(){} // RVA: 0x7ffaaed5df80
        public void EndSend(){} // RVA: 0x7ffaaed5ed70
        public void Send_internal(){} // RVA: 0x7ffaaed5efb0
        public void Send_array_icall(){} // RVA: 0x7ffaaed5efa0
        public void Send_internal(){} // RVA: 0x7ffaaed5efb0
        public void Send_icall(){} // RVA: 0x7ffaaed5f0e0
        public void SendTo(){} // RVA: 0x7ffaaed5f0f0
        public void EndSendTo(){} // RVA: 0x7ffaaed5fa60
        public void SendTo_internal(){} // RVA: 0x7ffaaed5fb30
        public void SendTo_icall(){} // RVA: 0x7ffaaed5fc70
        public void IOControl(){} // RVA: 0x7ffaaed60730
        public void IOControl_internal(){} // RVA: 0x7ffaaed608d0
        public void IOControl_icall(){} // RVA: 0x7ffaaed60a20
        public void Close(){} // RVA: 0x7ffaaed60a40
        public void Close(){} // RVA: 0x7ffaaed60a40
        public void Close_icall(){} // RVA: 0x7ffaaed60a50
        public void Shutdown(){} // RVA: 0x7ffaaed60ba0
        public void Shutdown_internal(){} // RVA: 0x7ffaaed60cb0
        public void Shutdown_icall(){} // RVA: 0x7ffaaed60dd0
        public void Dispose(){} // RVA: 0x7ffaaed60f20
        public void Linger(){} // RVA: 0x7ffaaed61230
        public void ThrowIfDisposedAndClosed(){} // RVA: 0x7ffaaed614d0
        public void ThrowIfBufferNull(){} // RVA: 0x7ffaaed61560
        public void ThrowIfBufferOutOfRange(){} // RVA: 0x7ffaaed615c0
        public void ThrowIfUdp(){} // RVA: 0x7ffaaed61780
        public void ValidateEndIAsyncResult(){} // RVA: 0x7ffaaed617e0
        public void QueueIOSelectorJob(){} // RVA: 0x7ffaaed61950
        public void InitSocketAsyncEventArgs(){} // RVA: 0x7ffaaed61b80
        public void SocketOperationToSocketAsyncOperation(){} // RVA: 0x7ffaaed61e40
        public void RemapIPEndPoint(){} // RVA: 0x7ffaaed61f70
        public void cancel_blocking_socket_operation(){} // RVA: 0x7ffaaed621a0
        public void get_FamilyHint(){} // RVA: 0x7ffaaed62240
        public void IsProtocolSupported_internal(){} // RVA: 0x7ffaa8a17850
        public void IsProtocolSupported(){} // RVA: 0x7ffaaed62380
        public void .cctor(){} // RVA: 0x7ffaaed623d0
        // ── Binary Analysis Named ──
        public void GetException(){} // RVA: 0x7ffaaed54cc0
        public void SetIPProtectionLevel(){} // RVA: 0x7ffaaed563a0
        public void BeginConnect(){} // RVA: 0x7ffaaed5a2a0
        public void BeginSend(){} // RVA: 0x7ffaaed5e5c0
        public void BeginReceive(){} // RVA: 0x7ffaaed5c630
        public void SetSocketOption(){} // RVA: 0x7ffaaed60470
        public void BeginAccept(){} // RVA: 0x7ffaaed58ab0
        public void BeginConnect(){} // RVA: 0x7ffaaed5a2a0
        public void BeginConnect(){} // RVA: 0x7ffaaed5a2a0
        public void BeginConnect(){} // RVA: 0x7ffaaed5a2a0
        public void BeginMConnect(){} // RVA: 0x7ffaaed5a550
        public void BeginSConnect(){} // RVA: 0x7ffaaed5a750
        public void BeginReceive(){} // RVA: 0x7ffaaed5c630
        public void BeginReceiveFrom(){} // RVA: 0x7ffaaed5d030
        public void BeginSend(){} // RVA: 0x7ffaaed5e5c0
        public void BeginSendCallback(){} // RVA: 0x7ffaaed5e9b0
        public void BeginSendTo(){} // RVA: 0x7ffaaed5f470
        public void BeginSendToCallback(){} // RVA: 0x7ffaaed5f880
        public void GetSocketOption(){} // RVA: 0x7ffaaed5fc80
        public void GetSocketOption_obj_internal(){} // RVA: 0x7ffaaed5feb0
        public void GetSocketOption_obj_icall(){} // RVA: 0x7ffaaed5fff0
        public void SetSocketOption(){} // RVA: 0x7ffaaed60470
        public void SetSocketOption(){} // RVA: 0x7ffaaed60470
        public void SetSocketOption(){} // RVA: 0x7ffaaed60470
        public void SetSocketOption_internal(){} // RVA: 0x7ffaaed605b0
        public void SetSocketOption_icall(){} // RVA: 0x7ffaaed60720
    }

    public class SocketAsyncEventArgs : EventArgs
    {
        public object remote_ep; // 0x313E9EB0
        public object _connectByNameError; // 0x313E9EB0, was: <ConnectByNameError>k__Backing
        public object _disconnectReuseSocket; // 0x313E9EB0, was: <DisconnectReuseSocket>k__Back
        public object _sendPacketsElements; // 0x313E9EB0, was: <SendPacketsElements>k__Backin
        public object _socketError; // 0x313E9EB0, was: <SocketError>k__BackingField
        public object Completed; // 0x313E9EB0
        public object _count; // 0x313E9EB0
        public object _bufferListInternal; // 0x313E9EB0

        // ── Original Methods ──
        public void get_AcceptSocket(){} // RVA: 0x7ffaa8bf45b0
        public void set_AcceptSocket(){} // RVA: 0x7ffaa8bf45c0
        public void get_BytesTransferred(){} // RVA: 0x7ffaa89d3080
        public void set_BytesTransferred(){} // RVA: 0x7ffaa89d3090
        public void set_LastOperation(){} // RVA: 0x7ffaa89d30d0
        public void set_RemoteEndPoint(){} // RVA: 0x7ffaa8998e80
        public void set_SendPacketsSendSize(){} // RVA: 0x7ffaaa1c2a70
        public void get_SocketError(){} // RVA: 0x7ffaa95c5a20
        public void set_SocketError(){} // RVA: 0x7ffaa8ac7670
        public void set_SocketFlags(){} // RVA: 0x7ffaaa2bddd0
        public void get_UserToken(){} // RVA: 0x7ffaa8af68f0
        public void set_UserToken(){} // RVA: 0x7ffaa8af19e0
        public void add_Completed(){} // RVA: 0x7ffaaed6cfd0
        public void remove_Completed(){} // RVA: 0x7ffaaed6d0d0
        public void .ctor(){} // RVA: 0x7ffaaed6d290
        public void .ctor(){} // RVA: 0x7ffaaed6d290
        public void Finalize(){} // RVA: 0x7ffaaed6d350
        public void Dispose(){} // RVA: 0x7ffaaed6d380
        public void Dispose(){} // RVA: 0x7ffaaed6d380
        public void get_CurrentSocket(){} // RVA: 0x7ffaa89600c0
        public void Complete_internal(){} // RVA: 0x7ffaaed6d4a0
        public void OnCompleted(){} // RVA: 0x7ffaaed6d4d0
        public void get_Buffer(){} // RVA: 0x7ffaaed6d500
        public void get_MemoryBuffer(){} // RVA: 0x7ffaad82e340
        public void get_Offset(){} // RVA: 0x7ffaaa2a8330
        public void get_Count(){} // RVA: 0x7ffaaa2a7db0
        public void get_BufferList(){} // RVA: 0x7ffaa8f74720
        // ── Binary Analysis Named ──
        public void SetBytesTransferred(){} // RVA: 0x7ffaa89d3090
        public void SetCurrentSocket(){} // RVA: 0x7ffaa89600d0
        public void SetLastOperation(){} // RVA: 0x7ffaaed6d3e0
        public void SetBuffer(){} // RVA: 0x7ffaaed6d810
        public void SetBuffer(){} // RVA: 0x7ffaaed6d810
    }

}