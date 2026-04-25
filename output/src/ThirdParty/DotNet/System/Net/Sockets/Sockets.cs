// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Sockets
// Classes: 2
// Methods: 199

namespace ThirdParty.DotNet.System.Net.Sockets
{
    public class Socket : Object
    {
        public object OSSupportsIPv4;
        public object OSSupportsIPv6;
        public object Handle;
        public object AddressFamily;
        public object SocketType;
        public object ProtocolType;
        public object ExclusiveAddressUse;
        public object ReceiveTimeout;
        public object SendTimeout;
        public object DontFragment;
        public object DualMode;
        public object IsDualMode;
        public object InternalSyncObject;
        public object CleanedUp;
        public object Available;
        public object IsBound;
        public object LocalEndPoint;
        public object Blocking;
        public object Connected;
        public object NoDelay;
        public object RemoteEndPoint;
        public object FamilyHint;

        // ── Methods ──
        public void ConnectAsync(){} // RVA: 0x7FFD54750F60
        public void ReceiveAsync(){} // RVA: 0x7FFD5475A130 | overloaded x2
        public void ReceiveAsyncApm(){} // RVA: 0x7FFD54751650
        public void SendAsyncForNetworkStream(){} // RVA: 0x7FFD54751CB0
        public void SendAsyncApm(){} // RVA: 0x7FFD547521B0
        public void CompleteAccept(){} // RVA: 0x7FFD547527B0
        public void CompleteSendReceive(){} // RVA: 0x7FFD54752A70
        public void GetException(){} // RVA: 0x7FFD54752CF0
        public void ReturnSocketAsyncEventArgs(){} // RVA: 0x7FFD54752F10 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD54755300 | overloaded x2
        public void get_OSSupportsIPv4(){} // RVA: 0x7FFD547533B0
        public void get_OSSupportsIPv6(){} // RVA: 0x7FFD54753410
        public void get_Handle(){} // RVA: 0x7FFD545FA720
        public void get_AddressFamily(){} // RVA: 0x7FFD4E4FBBE0
        public void get_SocketType(){} // RVA: 0x7FFD4ED41980
        public void get_ProtocolType(){} // RVA: 0x7FFD4E70C4C0
        public void get_ExclusiveAddressUse(){} // RVA: 0x7FFD54753470
        public void set_ExclusiveAddressUse(){} // RVA: 0x7FFD547534F0
        public void set_ReceiveTimeout(){} // RVA: 0x7FFD54753590
        public void set_SendTimeout(){} // RVA: 0x7FFD54753620
        public void set_DontFragment(){} // RVA: 0x7FFD547536B0
        public void get_DualMode(){} // RVA: 0x7FFD54753750
        public void set_DualMode(){} // RVA: 0x7FFD54753840
        public void get_IsDualMode(){} // RVA: 0x7FFD547538E0
        public void CanTryAddressFamily(){} // RVA: 0x7FFD547539D0
        public void Connect(){} // RVA: 0x7FFD547579F0 | overloaded x4
        public void Send(){} // RVA: 0x7FFD5475B990 | overloaded x7
        public void Receive(){} // RVA: 0x7FFD54759FB0 | overloaded x8
        public void IOControl(){} // RVA: 0x7FFD5475E760 | overloaded x2
        public void SetIPProtectionLevel(){} // RVA: 0x7FFD547543D0
        public void BeginConnect(){} // RVA: 0x7FFD547582D0 | overloaded x4
        public void BeginSend(){} // RVA: 0x7FFD5475C5F0 | overloaded x2
        public void EndSend(){} // RVA: 0x7FFD5475CDA0 | overloaded x2
        public void BeginReceive(){} // RVA: 0x7FFD5475A660 | overloaded x2
        public void EndReceive(){} // RVA: 0x7FFD5475A940 | overloaded x2
        public void get_InternalSyncObject(){} // RVA: 0x7FFD54754B50
        public void get_CleanedUp(){} // RVA: 0x7FFD4F075DE0
        public void InitializeSockets(){} // RVA: 0x7FFD54754C80
        public void Dispose(){} // RVA: 0x7FFD5475EF50 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD53663E40
        public void InternalShutdown(){} // RVA: 0x7FFD54755110
        public void SetSocketOption(){} // RVA: 0x7FFD5475E4A0 | overloaded x4
        public void SocketDefaults(){} // RVA: 0x7FFD547554E0
        public void Socket_icall(){} // RVA: 0x7FFD54755550
        public void get_Available(){} // RVA: 0x7FFD54755700
        public void Available_internal(){} // RVA: 0x7FFD547557B0
        public void Available_icall(){} // RVA: 0x7FFD547558D0
        public void get_IsBound(){} // RVA: 0x7FFD538A9120
        public void get_LocalEndPoint(){} // RVA: 0x7FFD547558E0
        public void LocalEndPoint_internal(){} // RVA: 0x7FFD547559E0
        public void LocalEndPoint_icall(){} // RVA: 0x7FFD54755B10
        public void get_Blocking(){} // RVA: 0x7FFD4E3FB8E0
        public void set_Blocking(){} // RVA: 0x7FFD54755B20
        public void Blocking_internal(){} // RVA: 0x7FFD54755BF0
        public void Blocking_icall(){} // RVA: 0x7FFD54755D10
        public void get_Connected(){} // RVA: 0x7FFD5367F9A0
        public void set_NoDelay(){} // RVA: 0x7FFD54755E60
        public void get_RemoteEndPoint(){} // RVA: 0x7FFD54755EF0
        public void RemoteEndPoint_internal(){} // RVA: 0x7FFD54756000
        public void RemoteEndPoint_icall(){} // RVA: 0x7FFD54756130
        public void Poll(){} // RVA: 0x7FFD54756140
        public void Poll_internal(){} // RVA: 0x7FFD547562F0
        public void Poll_icall(){} // RVA: 0x7FFD54756440
        public void Accept(){} // RVA: 0x7FFD547565F0 | overloaded x2
        public void AcceptAsync(){} // RVA: 0x7FFD547567C0
        public void BeginAccept(){} // RVA: 0x7FFD54756AE0
        public void EndAccept(){} // RVA: 0x7FFD54756DD0 | overloaded x2
        public void Accept_internal(){} // RVA: 0x7FFD54756F30
        public void Accept_icall(){} // RVA: 0x7FFD547570D0
        public void Bind(){} // RVA: 0x7FFD54757170
        public void Bind_internal(){} // RVA: 0x7FFD54757360
        public void Bind_icall(){} // RVA: 0x7FFD54757480
        public void Listen(){} // RVA: 0x7FFD54757490
        public void Listen_internal(){} // RVA: 0x7FFD547575A0
        public void Listen_icall(){} // RVA: 0x7FFD547577E0
        public void BeginMConnect(){} // RVA: 0x7FFD54758580
        public void BeginSConnect(){} // RVA: 0x7FFD54758780
        public void EndConnect(){} // RVA: 0x7FFD54758DD0
        public void Connect_internal(){} // RVA: 0x7FFD54758E90
        public void Connect_icall(){} // RVA: 0x7FFD54758FA0
        public void Disconnect(){} // RVA: 0x7FFD54758FB0
        public void EndDisconnect(){} // RVA: 0x7FFD547590C0
        public void Disconnect_internal(){} // RVA: 0x7FFD54759180
        public void Disconnect_icall(){} // RVA: 0x7FFD547593B0
        public void Receive_internal(){} // RVA: 0x7FFD5475AB80 | overloaded x2
        public void Receive_array_icall(){} // RVA: 0x7FFD5475AB70
        public void Receive_icall(){} // RVA: 0x7FFD5475ACB0
        public void ReceiveFrom(){} // RVA: 0x7FFD5475ACC0
        public void BeginReceiveFrom(){} // RVA: 0x7FFD5475B060
        public void EndReceiveFrom(){} // RVA: 0x7FFD5475B3E0
        public void EndReceiveFrom_internal(){} // RVA: 0x7FFD5475B560
        public void ReceiveFrom_internal(){} // RVA: 0x7FFD5475B690
        public void ReceiveFrom_icall(){} // RVA: 0x7FFD5475B7D0
        public void SendAsync(){} // RVA: 0x7FFD5475BFB0
        public void BeginSendCallback(){} // RVA: 0x7FFD5475C9E0
        public void Send_internal(){} // RVA: 0x7FFD5475CFE0 | overloaded x2
        public void Send_array_icall(){} // RVA: 0x7FFD5475CFD0
        public void Send_icall(){} // RVA: 0x7FFD5475D110
        public void SendTo(){} // RVA: 0x7FFD5475D120
        public void BeginSendTo(){} // RVA: 0x7FFD5475D4A0
        public void BeginSendToCallback(){} // RVA: 0x7FFD5475D8B0
        public void EndSendTo(){} // RVA: 0x7FFD5475DA90
        public void SendTo_internal(){} // RVA: 0x7FFD5475DB60
        public void SendTo_icall(){} // RVA: 0x7FFD5475DCA0
        public void GetSocketOption(){} // RVA: 0x7FFD5475DCB0
        public void GetSocketOption_obj_internal(){} // RVA: 0x7FFD5475DEE0
        public void GetSocketOption_obj_icall(){} // RVA: 0x7FFD5475E020
        public void SetSocketOption_internal(){} // RVA: 0x7FFD5475E5E0
        public void SetSocketOption_icall(){} // RVA: 0x7FFD5475E750
        public void IOControl_internal(){} // RVA: 0x7FFD5475E900
        public void IOControl_icall(){} // RVA: 0x7FFD5475EA50
        public void Close(){} // RVA: 0x7FFD5475EA70 | overloaded x2
        public void Close_icall(){} // RVA: 0x7FFD5475EA80
        public void Shutdown(){} // RVA: 0x7FFD5475EBD0
        public void Shutdown_internal(){} // RVA: 0x7FFD5475ECE0
        public void Shutdown_icall(){} // RVA: 0x7FFD5475EE00
        public void Linger(){} // RVA: 0x7FFD5475F260
        public void ThrowIfDisposedAndClosed(){} // RVA: 0x7FFD5475F500
        public void ThrowIfBufferNull(){} // RVA: 0x7FFD5475F590
        public void ThrowIfBufferOutOfRange(){} // RVA: 0x7FFD5475F5F0
        public void ThrowIfUdp(){} // RVA: 0x7FFD5475F7B0
        public void ValidateEndIAsyncResult(){} // RVA: 0x7FFD5475F810
        public void QueueIOSelectorJob(){} // RVA: 0x7FFD5475F980
        public void InitSocketAsyncEventArgs(){} // RVA: 0x7FFD5475FBB0
        public void SocketOperationToSocketAsyncOperation(){} // RVA: 0x7FFD5475FE70
        public void RemapIPEndPoint(){} // RVA: 0x7FFD5475FFA0
        public void cancel_blocking_socket_operation(){} // RVA: 0x7FFD547601D0
        public void get_FamilyHint(){} // RVA: 0x7FFD54760270
        public void IsProtocolSupported_internal(){} // RVA: 0x7FFD4E426850
        public void IsProtocolSupported(){} // RVA: 0x7FFD547603B0
        public void .cctor(){} // RVA: 0x7FFD54760400
    }

    public class SocketAsyncEventArgs : EventArgs
    {
        public object AcceptSocket;
        public object BytesTransferred;
        public object LastOperation;
        public object RemoteEndPoint;
        public object SendPacketsSendSize;
        public object SocketError;
        public object SocketFlags;
        public object UserToken;
        public object CurrentSocket;
        public object Buffer;
        public object MemoryBuffer;
        public object Offset;
        public object Count;
        public object BufferList;

        // ── Methods ──
        public void get_AcceptSocket(){} // RVA: 0x7FFD4E5F0140
        public void set_AcceptSocket(){} // RVA: 0x7FFD4E5F0C20
        public void get_BytesTransferred(){} // RVA: 0x7FFD4E3E2080
        public void set_BytesTransferred(){} // RVA: 0x7FFD4E3E2090
        public void set_LastOperation(){} // RVA: 0x7FFD4E3E20D0
        public void set_RemoteEndPoint(){} // RVA: 0x7FFD4E3A7E80
        public void set_SendPacketsSendSize(){} // RVA: 0x7FFD4FBDAB80
        public void get_SocketError(){} // RVA: 0x7FFD4EFB9E80
        public void set_SocketError(){} // RVA: 0x7FFD4E4D6520
        public void set_SocketFlags(){} // RVA: 0x7FFD4FCD4C80
        public void get_UserToken(){} // RVA: 0x7FFD4E505600
        public void set_UserToken(){} // RVA: 0x7FFD4E5006F0
        public void add_Completed(){} // RVA: 0x7FFD5476B000
        public void remove_Completed(){} // RVA: 0x7FFD5476B100
        public void .ctor(){} // RVA: 0x7FFD5476B2C0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD5476B380
        public void Dispose(){} // RVA: 0x7FFD5476B3B0 | overloaded x2
        public void SetBytesTransferred(){} // RVA: 0x7FFD4E3E2090
        public void get_CurrentSocket(){} // RVA: 0x7FFD4E36F0C0
        public void SetCurrentSocket(){} // RVA: 0x7FFD4E36F0D0
        public void SetLastOperation(){} // RVA: 0x7FFD5476B410
        public void Complete_internal(){} // RVA: 0x7FFD5476B4D0
        public void OnCompleted(){} // RVA: 0x7FFD5476B500
        public void get_Buffer(){} // RVA: 0x7FFD5476B530
        public void get_MemoryBuffer(){} // RVA: 0x7FFD532199E0
        public void get_Offset(){} // RVA: 0x7FFD4FCBE530
        public void get_Count(){} // RVA: 0x7FFD4FCBE520
        public void get_BufferList(){} // RVA: 0x7FFD4E96B1A0
        public void SetBuffer(){} // RVA: 0x7FFD5476B840 | overloaded x2
    }

}