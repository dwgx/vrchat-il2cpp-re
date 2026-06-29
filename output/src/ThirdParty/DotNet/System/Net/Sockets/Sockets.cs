// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Sockets
// Classes: 15
// Methods: 275

namespace ThirdParty.DotNet.System.Net.Sockets
{
    public class IPPacketInformation : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7E9B920
        public void GetHashCode(){} // RVA: 0x7A7E9B9F0
    }

    public class IPv6MulticastOption : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE99F100
        public void set_Group(){} // RVA: 0x7AE99F1C0
        public void set_InterfaceIndex(){} // RVA: 0x7AE99F270
    }

    public class LingerOption : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE99ED40
        public void set_Enabled(){} // RVA: 0x7A81A2210
        public void set_LingerTime(){} // RVA: 0x7A8669360
    }

    public class MulticastOption : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE99EE10
        public void set_Group(){} // RVA: 0x7A80D8E20
        public void set_LocalAddress(){} // RVA: 0x7AE99EF80
    }

    public class NetworkStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE985F50
        public void get_CanRead(){} // RVA: 0x7A80FD6B0
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7AB9DF6A0
        public void get_CanTimeout(){} // RVA: 0x7A81BD750
        public void get_ReadTimeout(){} // RVA: 0x7AE986150
        public void set_ReadTimeout(){} // RVA: 0x7AE9861E0
        public void get_WriteTimeout(){} // RVA: 0x7AE986280
        public void set_WriteTimeout(){} // RVA: 0x7AE986310
        public void get_DataAvailable(){} // RVA: 0x7AE9863B0
        public void get_Length(){} // RVA: 0x7AE986460
        public void get_Position(){} // RVA: 0x7AE9864B0
        public void set_Position(){} // RVA: 0x7AE986500
        public void Seek(){} // RVA: 0x7AE986550
        public void Read(){} // RVA: 0x7AE986920
        public void ReadByte(){} // RVA: 0x7AE986C70
        public void Write(){} // RVA: 0x7AE987070
        public void WriteByte(){} // RVA: 0x7AE987380
        public void Close(){} // RVA: 0x7AE9873F0
        public void Dispose(){} // RVA: 0x7AE987470
        public void Finalize(){} // RVA: 0x7ADAA0970
        public void BeginRead(){} // RVA: 0x7AE9874F0
        public void EndRead(){} // RVA: 0x7AE987880
        public void BeginWrite(){} // RVA: 0x7AE987AC0
        public void EndWrite(){} // RVA: 0x7AE987E50
        public void ReadAsync(){} // RVA: 0x7AE9884C0
        public void WriteAsync(){} // RVA: 0x7AE988BA0
        public void Flush(){} // RVA: 0x7A80D7310
        public void FlushAsync(){} // RVA: 0x7AE988E40
        public void SetLength(){} // RVA: 0x7AE988EE0
        public void SetSocketTimeoutOption(){} // RVA: 0x7AE988F30
        public void get_InternalSocket(){} // RVA: 0x7AE989280
    }

    public class SafeSocketHandle : SafeHandleMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9A22F0
        public void ReleaseHandle(){} // RVA: 0x7AE9A2420
        public void RegisterForBlockingSyscall(){} // RVA: 0x7AE9A2BD0
        public void UnRegisterForBlockingSyscall(){} // RVA: 0x7AE9A3020
        public void .cctor(){} // RVA: 0x7AE9A3280
    }

    public class Socket : Object
    {
        // ── Methods ──
        public void ConnectAsync(){} // RVA: 0x7AE989320
        public void ReceiveAsync(){} // RVA: 0x7AE9924C0
        public void ReceiveAsyncApm(){} // RVA: 0x7AE9899F0
        public void SendAsyncForNetworkStream(){} // RVA: 0x7AE98A030
        public void SendAsyncApm(){} // RVA: 0x7AE98A520
        public void CompleteAccept(){} // RVA: 0x7AE98AB20
        public void CompleteSendReceive(){} // RVA: 0x7AE98ADF0
        public void GetException(){} // RVA: 0x7AE98B070
        public void ReturnSocketAsyncEventArgs(){} // RVA: 0x7AE98B2A0
        public void .ctor(){} // RVA: 0x7AE98D670
        public void get_OSSupportsIPv4(){} // RVA: 0x7AE98B740
        public void get_OSSupportsIPv6(){} // RVA: 0x7AE98B7A0
        public void get_Handle(){} // RVA: 0x7AE8341C0
        public void get_AddressFamily(){} // RVA: 0x7A851DB90
        public void get_SocketType(){} // RVA: 0x7A8AB15F0
        public void get_ProtocolType(){} // RVA: 0x7A854FDE0
        public void get_ExclusiveAddressUse(){} // RVA: 0x7AE98B800
        public void set_ExclusiveAddressUse(){} // RVA: 0x7AE98B880
        public void set_ReceiveTimeout(){} // RVA: 0x7AE98B920
        public void set_SendTimeout(){} // RVA: 0x7AE98B9B0
        public void set_DontFragment(){} // RVA: 0x7AE98BA40
        public void get_DualMode(){} // RVA: 0x7AE98BAE0
        public void set_DualMode(){} // RVA: 0x7AE98BBD0
        public void get_IsDualMode(){} // RVA: 0x7AE98BC70
        public void CanTryAddressFamily(){} // RVA: 0x7AE98BD60
        public void Connect(){} // RVA: 0x7AE98FD70
        public void Send(){} // RVA: 0x7AE993D30
        public void Receive(){} // RVA: 0x7AE992340
        public void IOControl(){} // RVA: 0x7AE996B00
        public void SetIPProtectionLevel(){} // RVA: 0x7AE98C760
        public void BeginConnect(){} // RVA: 0x7AE990670
        public void BeginSend(){} // RVA: 0x7AE994970
        public void EndSend(){} // RVA: 0x7AE995120
        public void BeginReceive(){} // RVA: 0x7AE9929F0
        public void EndReceive(){} // RVA: 0x7AE992CD0
        public void get_InternalSyncObject(){} // RVA: 0x7AE98CEE0
        public void get_CleanedUp(){} // RVA: 0x7A8F5FF30
        public void InitializeSockets(){} // RVA: 0x7AE98D010
        public void Dispose(){} // RVA: 0x7AE9972F0
        public void Finalize(){} // RVA: 0x7AD899E40
        public void InternalShutdown(){} // RVA: 0x7AE98D480
        public void SetSocketOption(){} // RVA: 0x7AE996840
        public void SocketDefaults(){} // RVA: 0x7AE98D850
        public void Socket_icall(){} // RVA: 0x7AE98D8C0
        public void get_Available(){} // RVA: 0x7AE98DA70
        public void Available_internal(){} // RVA: 0x7AE98DB20
        public void Available_icall(){} // RVA: 0x7AE98DC40
        public void get_IsBound(){} // RVA: 0x7A99A2DD0
        public void get_LocalEndPoint(){} // RVA: 0x7AE98DC50
        public void LocalEndPoint_internal(){} // RVA: 0x7AE98DD50
        public void LocalEndPoint_icall(){} // RVA: 0x7AE98DE80
        public void get_Blocking(){} // RVA: 0x7A8192400
        public void set_Blocking(){} // RVA: 0x7AE98DE90
        public void Blocking_internal(){} // RVA: 0x7AE98DF60
        public void Blocking_icall(){} // RVA: 0x7AE98E080
        public void get_Connected(){} // RVA: 0x7A99A3440
        public void set_NoDelay(){} // RVA: 0x7AE98E1D0
        public void get_RemoteEndPoint(){} // RVA: 0x7AE98E260
        public void RemoteEndPoint_internal(){} // RVA: 0x7AE98E370
        public void RemoteEndPoint_icall(){} // RVA: 0x7AE98E4A0
        public void Poll(){} // RVA: 0x7AE98E4B0
        public void Poll_internal(){} // RVA: 0x7AE98E660
        public void Poll_icall(){} // RVA: 0x7AE98E7B0
        public void Accept(){} // RVA: 0x7AE98E960
        public void AcceptAsync(){} // RVA: 0x7AE98EB30
        public void BeginAccept(){} // RVA: 0x7AE98EE50
        public void EndAccept(){} // RVA: 0x7AE98F150
        public void Accept_internal(){} // RVA: 0x7AE98F2B0
        public void Accept_icall(){} // RVA: 0x7AE98F450
        public void Bind(){} // RVA: 0x7AE98F4F0
        public void Bind_internal(){} // RVA: 0x7AE98F6E0
        public void Bind_icall(){} // RVA: 0x7AE98F800
        public void Listen(){} // RVA: 0x7AE98F810
        public void Listen_internal(){} // RVA: 0x7AE98F920
        public void Listen_icall(){} // RVA: 0x7AE98FB60
        public void BeginMConnect(){} // RVA: 0x7AE990920
        public void BeginSConnect(){} // RVA: 0x7AE990B30
        public void EndConnect(){} // RVA: 0x7AE991180
        public void Connect_internal(){} // RVA: 0x7AE991240
        public void Connect_icall(){} // RVA: 0x7AE991350
        public void Disconnect(){} // RVA: 0x7AE991360
        public void EndDisconnect(){} // RVA: 0x7AE991470
        public void Disconnect_internal(){} // RVA: 0x7AE991530
        public void Disconnect_icall(){} // RVA: 0x7AE991760
        public void Receive_internal(){} // RVA: 0x7AE992F10
        public void Receive_array_icall(){} // RVA: 0x7AE992F00
        public void Receive_icall(){} // RVA: 0x7AE993040
        public void ReceiveFrom(){} // RVA: 0x7AE993050
        public void BeginReceiveFrom(){} // RVA: 0x7AE993400
        public void EndReceiveFrom(){} // RVA: 0x7AE993780
        public void EndReceiveFrom_internal(){} // RVA: 0x7AE993900
        public void ReceiveFrom_internal(){} // RVA: 0x7AE993A30
        public void ReceiveFrom_icall(){} // RVA: 0x7AE993B70
        public void SendAsync(){} // RVA: 0x7AE994330
        public void BeginSendCallback(){} // RVA: 0x7AE994D60
        public void Send_internal(){} // RVA: 0x7AE995360
        public void Send_array_icall(){} // RVA: 0x7AE995350
        public void Send_icall(){} // RVA: 0x7AE995490
        public void SendTo(){} // RVA: 0x7AE9954A0
        public void BeginSendTo(){} // RVA: 0x7AE995840
        public void BeginSendToCallback(){} // RVA: 0x7AE995C50
        public void EndSendTo(){} // RVA: 0x7AE995E30
        public void SendTo_internal(){} // RVA: 0x7AE995F00
        public void SendTo_icall(){} // RVA: 0x7AE996040
        public void GetSocketOption(){} // RVA: 0x7AE996050
        public void GetSocketOption_obj_internal(){} // RVA: 0x7AE996280
        public void GetSocketOption_obj_icall(){} // RVA: 0x7AE9963C0
        public void SetSocketOption_internal(){} // RVA: 0x7AE996980
        public void SetSocketOption_icall(){} // RVA: 0x7AE996AF0
        public void IOControl_internal(){} // RVA: 0x7AE996CA0
        public void IOControl_icall(){} // RVA: 0x7AE996DF0
        public void Close(){} // RVA: 0x7AE996E10
        public void Close_icall(){} // RVA: 0x7AE996E20
        public void Shutdown(){} // RVA: 0x7AE996F70
        public void Shutdown_internal(){} // RVA: 0x7AE997080
        public void Shutdown_icall(){} // RVA: 0x7AE9971A0
        public void Linger(){} // RVA: 0x7AE997610
        public void ThrowIfDisposedAndClosed(){} // RVA: 0x7AE9978B0
        public void ThrowIfBufferNull(){} // RVA: 0x7AE997940
        public void ThrowIfBufferOutOfRange(){} // RVA: 0x7AE9979A0
        public void ThrowIfUdp(){} // RVA: 0x7AE997B60
        public void ValidateEndIAsyncResult(){} // RVA: 0x7AE997BC0
        public void QueueIOSelectorJob(){} // RVA: 0x7AE997D30
        public void InitSocketAsyncEventArgs(){} // RVA: 0x7AE997F60
        public void SocketOperationToSocketAsyncOperation(){} // RVA: 0x7AE998220
        public void RemapIPEndPoint(){} // RVA: 0x7AE998350
        public void cancel_blocking_socket_operation(){} // RVA: 0x7AE998580
        public void get_FamilyHint(){} // RVA: 0x7AE998620
        public void IsProtocolSupported_internal(){} // RVA: 0x7A81BD750
        public void IsProtocolSupported(){} // RVA: 0x7AE998760
        public void .cctor(){} // RVA: 0x7AE9987B0
    }

    public class SocketAsyncEventArgs : EventArgs
    {
        // ── Methods ──
        public void get_AcceptSocket(){} // RVA: 0x7A8292C30
        public void set_AcceptSocket(){} // RVA: 0x7A8296DE0
        public void get_BytesTransferred(){} // RVA: 0x7A8178B30
        public void set_BytesTransferred(){} // RVA: 0x7A8178B40
        public void set_LastOperation(){} // RVA: 0x7A8178B80
        public void set_RemoteEndPoint(){} // RVA: 0x7A813E420
        public void set_SendPacketsSendSize(){} // RVA: 0x7A9A938A0
        public void get_SocketError(){} // RVA: 0x7A8EA8210
        public void set_SocketError(){} // RVA: 0x7A8270510
        public void set_SocketFlags(){} // RVA: 0x7A9B90E90
        public void get_UserToken(){} // RVA: 0x7A82C2060
        public void set_UserToken(){} // RVA: 0x7A82C0530
        public void add_Completed(){} // RVA: 0x7AE9A3350
        public void remove_Completed(){} // RVA: 0x7AE9A3470
        public void .ctor(){} // RVA: 0x7AE9A3650
        public void Finalize(){} // RVA: 0x7AE9A3710
        public void Dispose(){} // RVA: 0x7AE9A3740
        public void SetBytesTransferred(){} // RVA: 0x7A8178B40
        public void get_CurrentSocket(){} // RVA: 0x7A81052C0
        public void SetCurrentSocket(){} // RVA: 0x7A81052D0
        public void SetLastOperation(){} // RVA: 0x7AE9A37A0
        public void Complete_internal(){} // RVA: 0x7AE9A3860
        public void OnCompleted(){} // RVA: 0x7AE9A3890
        public void get_Buffer(){} // RVA: 0x7AE9A38C0
        public void get_MemoryBuffer(){} // RVA: 0x7AD53B5F0
        public void get_Offset(){} // RVA: 0x7A9B79A20
        public void get_Count(){} // RVA: 0x7A9B79A10
        public void get_BufferList(){} // RVA: 0x7A87D9480
        public void SetBuffer(){} // RVA: 0x7AE9A3BD0
    }

    public class SocketAsyncResult : IOAsyncResult
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7AE9A3D00
        public void .ctor(){} // RVA: 0x7AE9A4150
        public void Init(){} // RVA: 0x7AE9A3D30
        public void get_ErrorCode(){} // RVA: 0x7AE9A4270
        public void CheckIfThrowDelayedException(){} // RVA: 0x7AE9A4300
        public void CompleteDisposed(){} // RVA: 0x7AE9A43B0
        public void Complete(){} // RVA: 0x7AE9A47B0
    }

    public class SocketException : Win32Exception
    {
        // ── Methods ──
        public void WSAGetLastError_icall(){} // RVA: 0x7AE99EB00
        public void .ctor(){} // RVA: 0x7AE90D430
        public void get_ErrorCode(){} // RVA: 0x7A846C760
        public void get_Message(){} // RVA: 0x7AE99EB90
        public void get_SocketErrorCode(){} // RVA: 0x7A846C760
    }

    public class TcpClient : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE99F6A0
        public void get_Client(){} // RVA: 0x7A80F2570
        public void set_Client(){} // RVA: 0x7A80D8E20
        public void get_Connected(){} // RVA: 0x7AE99F700
        public void Connect(){} // RVA: 0x7AE99FE80
        public void BeginConnect(){} // RVA: 0x7AE99FF70
        public void EndConnect(){} // RVA: 0x7AE99FFA0
        public void ConnectAsync(){} // RVA: 0x7AE99FFD0
        public void GetStream(){} // RVA: 0x7AE9A0190
        public void Close(){} // RVA: 0x7AE9A0300
        public void Dispose(){} // RVA: 0x7A8125330
        public void Finalize(){} // RVA: 0x7AD899E40
        public void initialize(){} // RVA: 0x7AE9A04E0
    }

    public class TcpClient[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class TcpListener : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9A05B0
        public void get_LocalEndpoint(){} // RVA: 0x7AE9A0820
        public void Start(){} // RVA: 0x7AE9A0860
        public void Stop(){} // RVA: 0x7AE9A0990
        public void BeginAcceptTcpClient(){} // RVA: 0x7AE9A0B30
        public void EndAcceptTcpClient(){} // RVA: 0x7AE9A0BC0
    }

    public class UdpClient : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9A0D70
        public void get_Client(){} // RVA: 0x7A80F2570
        public void set_Client(){} // RVA: 0x7A80D8E20
        public void FreeResources(){} // RVA: 0x7AE9A0FB0
        public void Dispose(){} // RVA: 0x7AE9A1010
        public void CheckForBroadcast(){} // RVA: 0x7AE9A10B0
        public void IsBroadcast(){} // RVA: 0x7AE9A1190
        public void BeginSend(){} // RVA: 0x7AE9A1220
        public void EndSend(){} // RVA: 0x7AE9A1530
        public void BeginReceive(){} // RVA: 0x7AE9A15E0
        public void EndReceive(){} // RVA: 0x7AE9A1740
        public void SendAsync(){} // RVA: 0x7AE9A1B00
        public void ReceiveAsync(){} // RVA: 0x7AE9A1C70
        public void createClientSocket(){} // RVA: 0x7AE9A1DB0
        public void <ReceiveAsync>b__65_0(){} // RVA: 0x7AE9A15E0
        public void <ReceiveAsync>b__65_1(){} // RVA: 0x7AE9A1E80
    }

    public class UdpReceiveResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E9BA50
        public void get_Buffer(){} // RVA: 0x7A765F710
        public void get_RemoteEndPoint(){} // RVA: 0x7A765F080
        public void GetHashCode(){} // RVA: 0x7A7E9BA60
        public void Equals(){} // RVA: 0x7A7A390F0
    }

}