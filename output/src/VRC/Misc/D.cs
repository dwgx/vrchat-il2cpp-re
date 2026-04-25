// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Misc
// Classes: 7
// Methods: 74

namespace VRC.Misc
{
    /// <summary>Originally: ÍÎÌÏÌÎÍÌÎÍÏÍÏÎÍÎÍÏÏÎÎÌÎ</summary>
    public class DataCanConvertWriteJson_E4EA_E4EA : JsonConverter
    {
        // ── Methods ──
        public void ReadJson(){} // RVA: 0x7FFAC39E3F70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void WriteJson(){} // RVA: 0x7FFAC39E4170
        public void CanConvert(){} // RVA: 0x7FFAC39E42A0
    }

    /// <summary>Originally: ÌÎÎÌÎÎÎÏÍÏÍÍÍÏÍÎÍÏÌÌÎÌÍ</summary>
    public class DataCanConvertWriteJson_EDDB_EDDB : JsonConverter
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFAC39E3C30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void WriteJson(){} // RVA: 0x7FFAC39E3D00
        public void ReadJson(){} // RVA: 0x7FFAC39E3DB0
    }

    /// <summary>Originally: ÌÏÍÍÍÎÌÎÍÏÎÍÎÍÏÎÏÌÎÍÍÎÏ</summary>
    public class DataWriteJsonReadJson_A0B3_A0B3 : JsonConverter`1
    {
        // ── Methods ──
        public void ReadJson(){} // RVA: 0x7FFAC40685B0
        public void WriteJson(){} // RVA: 0x7FFAC40688D0
        public void .ctor(){} // RVA: 0x7FFAC4068910
    }

    /// <summary>Originally: ÏÎÏÎÏÍÏÎÎÎÍÌÏÏÌÌÏÍÎÌÌÎÏ</summary>
    public class Deselect_BC5B_BC5B : InputField
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC429F8E0
        public void OnDeselect(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÏÎÎÎÌÎÎÎÏÎÍÎÏÌÎÌÌÌÌÍÍÏÎ</summary>
    public class Deselect_D362_D362 : TMP_InputField
    {
        // ── Methods ──
        public void OnDeselect(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC429F930
    }

    /// <summary>Originally: ÍÌÌÏÏÎÍÍÌÏÍÌÎÌÌÌÏÎÍÎÎÍÍ</summary>
    public class DisconnectReceive_C593_C593 : PhotonSocket
    {
        public ÎÎÏÌÏÌÌÍÏÏÌÍÏÎÍÎÌÎÌÌÏÎÎ ÍÎÎÌÌÏÎÍÎÌÍÏÏÌÏÍÏÏÎÌÎÏÎ; // 0x60
        public object ÍÎÍÍÌÎÏÌÌÎÎÎÌÎÍÌÏÌÎÍÍÎÎ; // 0x68
        public UnityEngine.GameObject ÎÌÏÏÎÌÌÎÎÏÍÏÌÍÌÎÏÎÌÌÎÏÏ; // 0x70
        public int ÎÍÎÏÍÌÎÎÌÍÎÌÎÎÏÏÏÎÌÏÏÍÌ;
        public int ÎÌÎÎÏÌÏÎÌÌÏÍÌÌÍÍÍÍÌÍÏÌÌ;
        public int ÍÌÎÎÌÌÏÌÎÎÎÎÌÌÌÌÎÏÌÏÌÎÌ;

        // ── Methods ──
        public void get_Listener(){} // RVA: 0x7FFAC45A8490
        public void Dispose(){} // RVA: 0x7FFAC45A8590
        public void Cleanup(){} // RVA: 0x7FFAC45A86F0
        public void Receive(){} // RVA: 0x7FFAC45A87F0
        public void Send(){} // RVA: 0x7FFAC45A8850
        public void set_SocketErrorCode(){} // RVA: 0x7FFAC45A8A40
        public void get_Connected(){} // RVA: 0x7FFAC45A8AE0
        public void Connect(){} // RVA: 0x7FFAC45A8AF0
        public void .ctor(){} // RVA: 0x7FFAC45A9490
        public void Initialize(){} // RVA: 0x7FFAC45A96E0
        public void set_ProxyServerAddress(){} // RVA: 0x7FFAC45A96F0
        public void Disconnect(){} // RVA: 0x7FFAC45A9790
        public void get_ServerPort(){} // RVA: 0x7FFAC45A9B80
        public void set_ServerPort(){} // RVA: 0x7FFAC45A9D10
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x7FFAC45A9EA0
    }

    /// <summary>Originally: ÏÏÎÏÌÍÌÎÎÍÎÎÎÎÎÏÏÎÍÍÍÏÌ</summary>
    public class DispatchIncomingCommandsSendOutgoingComm_8BCB_8BCB : PhotonPeer
    {
        public ÌÌÌÏÍÎÌÍÌÏÎÍÍÏÍÍÌÌÌÎÍÎÎ _clientSdkIdShifted; // 0xE0
        public int _version;
        public int _useAck2; // 0xE8
        public System.Collections.Concurrent.ConcurrentDictionary`2<byte,int> _serializationProtocolType; // 0xF0
        public ÏÏÎÏÌÍÌÎÎÍÎÎÎÎÎÏÏÎÍÍÍÏÌ _socketImplementation;
        public int _socketErrorCode; // 0x8
        public int _listener; // 0xC
        public System.Collections.Concurrent.ConcurrentDictionary`2<byte,int> _peerState; // 0xF8
        public System.Collections.Concurrent.ConcurrentDictionary`2<uint,int> _reuseEventInstance; // 0x100
        public System.Collections.Concurrent.ConcurrentDictionary`2<byte,int> _useByteArraySlicePoolForEvents; // 0x108
        public System.Collections.Concurrent.ConcurrentDictionary`2<byte,int> _wrapIncomingStructs; // 0x110
        public System.Collections.Concurrent.ConcurrentDictionary`2<uint,int> _quickResendAttempts; // 0x118
        public System.Collections.Concurrent.ConcurrentDictionary`2<byte,int> ÌÏÏÍÎÌÏÎÏÍÌÎÌÌÍÏÌÌÍÎÌÎÏ; // 0x120
        public VRC.Profiling.ProfilerMarker ÏÎÍÍÎÎÎÍÌÍÏÌÍÌÍÎÎÎÍÏÏÏÌ; // 0x10
        public VRC.Profiling.ProfilerMarker ÏÍÌÏÍÌÎÍÌÎÍÌÍÌÏÍÍÍÎÍÏÏÎ; // 0x20
        public VRC.Profiling.ProfilerMarker ÌÎÎÍÍÌÏÏÎÎÌÌÍÌÍÍÏÍÌÎÎÌÎ; // 0x30
        public VRC.Profiling.ProfilerMarker ÎÎÌÎÎÏÌÌÎÏÍÌÏÎÌÌÍÌÎÍÌÏÍ; // 0x40
        public VRC.Profiling.ProfilerMarker ÌÍÍÏÎÍÌÏÎÍÏÎÍÍÍÌÎÌÎÏÌÎÏ; // 0x50
        public float ÌÎÏÌÍÌÍÎÎÌÍÏÌÎÌÎÏÎÍÏÎÎÏ; // 0x128
        public bool ÏÌÎÌÍÍÏÎÎÌÌÏÌÌÍÌÍÍÎÍÌÏÍ; // 0x12C
        public System.Collections.Generic.Dictionary`2<byte,int> ÌÏÏÍÌÍÏÍÏÌÎÌÎÌÏÍÍÎÎÏÌÍÌ; // 0x130
        public 0x6B26A768 ÏÍÏÌÌÎÍÏÌÏÌÎÎÌÍÏÎÎÌÍÏÌÍ; // 0x138
        public VRC.Core.PriorityQueue`1<ÌÏÎÎÎÌÍÎÌÍÍÎÎÍÍÌÎÍÎÏÏÌÎ> ÍÌÏÌÏÌÍÎÌÎÌÍÌÍÍÍÌÍÎÍÍÎÏ; // 0x140
        public VRC.Core.PriorityQueue`1<ÌÏÎÎÎÌÍÎÌÍÍÎÎÍÍÌÎÍÎÏÏÌÎ> ÍÍÍÎÌÍÍÍÌÍÏÌÍÍÏÌÍÍÏÍÌÍÍ; // 0x148
        public long ÎÌÍÌÍÍÏÎÏÎÎÏÌÍÏÏÎÎÎÏÍÎÏ; // 0x150
        public ÍÍÎÎÌÏÌÌÏÏÏÌÍÏÎÎÍÎÏÌÍÎÏ ÍÍÌÎÌÎÍÎÎÎÎÌÌÏÌÍÎÎÌÏÎÏÌ; // 0x158
        public long ÌÎÍÍÌÏÎÍÎÏÍÏÍÎÎÍÏÍÏÏÌÌÏ; // 0x160
        public ÍÍÎÎÌÏÌÌÏÏÏÌÍÏÎÎÍÎÏÌÍÎÏ ÏÏÎÎÎÍÎÌÍÎÏÎÎÏÎÍÌÏÏÌÌÌÏ; // 0x168
        public long ÎÎÍÎÌÌÌÌÌÍÌÎÌÍÏÌÍÌÍÎÌÌÌ; // 0x170
        public long ÎÌÍÌÏÌÏÎÌÎÌÍÍÏÎÌÎÎÎÌÎÎÏ; // 0x178

        // ── Methods ──
        public void get_ClientSdkIdShifted(){} // RVA: 0x7FFAC39E8460
        public void get_Version(){} // RVA: 0x7FFAC39E84C0
        public void get_UseAck2(){} // RVA: 0x7FFAC39E86D0
        public void set_UseAck2(){} // RVA: 0x7FFAC39E9490
        public void get_SerializationProtocolType(){} // RVA: 0x7FFAC39E9660
        public void set_SerializationProtocolType(){} // RVA: 0x7FFAC39E9880
        public void get_SocketImplementation(){} // RVA: 0x7FFAC39E9950
        public void set_SocketImplementation(){} // RVA: 0x7FFAC39E9990
        public void get_SocketErrorCode(){} // RVA: 0x7FFAC39E9A30
        public void .ctor(){} // RVA: 0x7FFAC39E9A40
        public void SendOperation(){} // RVA: 0x7FFAC39EA270
        public void get_PeerState(){} // RVA: 0x7FFAC39EAE00
        public void get_ReuseEventInstance(){} // RVA: 0x7FFAC39EAF70
        public void set_ReuseEventInstance(){} // RVA: 0x7FFAC39EB290
        public void get_UseByteArraySlicePoolForEvents(){} // RVA: 0x7FFAC39EB2C0
        public void get_WrapIncomingStructs(){} // RVA: 0x7FFAC39EBDE0
        public void get_QuickResendAttempts(){} // RVA: 0x7FFAC2E8DC40
        public void DispatchIncomingCommands(){} // RVA: 0x7FFAC39EBFA0
        public void get_DisconnectTimeout(){} // RVA: 0x7FFAC39EC000
        public void set_DisconnectTimeout(){} // RVA: 0x7FFAC39EC200
        public void get_CrcEnabled(){} // RVA: 0x7FFAC39EC2A0
        public void set_CrcEnabled(){} // RVA: 0x7FFAC39EC390
        public void get_ServerAddress(){} // RVA: 0x7FFAC39EC900
        public void get_UsedProtocol(){} // RVA: 0x7FFAC39ECA20
        public void get_TransportProtocol(){} // RVA: 0x7FFAC39ECA50
        public void set_TransportProtocol(){} // RVA: 0x7FFAC39ECA80
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFAC39ECAE0
        public void get_NetworkSimulationSettings(){} // RVA: 0x7FFAC39ED320
        public void get_MaximumTransferUnit(){} // RVA: 0x7FFAC39ED5E0
        public void get_IsEncryptionAvailable(){} // RVA: 0x7FFAC39ED600
        public void get_PayloadEncryptorType(){} // RVA: 0x7FFAC39ED680
        public void get_EncryptorType(){} // RVA: 0x7FFAC39ED880
        public void set_EncryptorType(){} // RVA: 0x7FFAC39EE400
        public void get_ServerTimeInMilliseconds(){} // RVA: 0x7FFAC39EE7A0
        public void get_EnableServerTracing(){} // RVA: 0x7FFAC39EEB10
        public void get_ConnectionTime(){} // RVA: 0x7FFAC39EED20
        public void get_BytesIn(){} // RVA: 0x7FFAC39EF120
        public void get_BytesOut(){} // RVA: 0x7FFAC39EF190
        public void .cctor(){} // RVA: 0x7FFAC39EFA30
        public void SendOutgoingCommands(){} // RVA: 0x7FFAC39EFE80
        public void get_PacketLossByCrc(){} // RVA: 0x7FFAC39EFF10
        public void Disconnect(){} // RVA: 0x7FFAC39F02A0
        public void get_CountDiscarded(){} // RVA: 0x7FFAC39F04D0
        public void set_CountDiscarded(){} // RVA: 0x7FFAC39F0540
    }

}