// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Misc
// Classes: 7
// Methods: 74

namespace VRC.Misc
{
    /// <summary>Originally: ÍÎÌÏÌÎÍÌÎÍÏÍÏÎÍÎÍÏÏÎÎÌÎ</summary>
    public class DataCanConvertWriteJson_E4EA : JsonConverter
    {
        // ── Methods ──
        public void ReadJson(){} // RVA: 0x7FFD4EE03F70
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void WriteJson(){} // RVA: 0x7FFD4EE04170
        public void CanConvert(){} // RVA: 0x7FFD4EE042A0
    }

    /// <summary>Originally: ÌÎÎÌÎÎÎÏÍÏÍÍÍÏÍÎÍÏÌÌÎÌÍ</summary>
    public class DataCanConvertWriteJson_EDDB : JsonConverter
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFD4EE03C30
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void WriteJson(){} // RVA: 0x7FFD4EE03D00
        public void ReadJson(){} // RVA: 0x7FFD4EE03DB0
    }

    /// <summary>Originally: ÌÏÍÍÍÎÌÎÍÏÎÍÎÍÏÎÏÌÎÍÍÎÏ</summary>
    public class DataWriteJsonReadJson_A0B3 : JsonConverter`1
    {
        // ── Methods ──
        public void ReadJson(){} // RVA: 0x7FFD4F4885B0
        public void WriteJson(){} // RVA: 0x7FFD4F4888D0
        public void .ctor(){} // RVA: 0x7FFD4F488910
    }

    /// <summary>Originally: ÏÎÏÎÏÍÏÎÎÎÍÌÏÏÌÌÏÍÎÌÌÎÏ</summary>
    public class Deselect_BC5B : InputField
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F6BF8E0
        public void OnDeselect(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÏÎÎÎÌÎÎÎÏÎÍÎÏÌÎÌÌÌÌÍÍÏÎ</summary>
    public class Deselect_D362 : TMP_InputField
    {
        // ── Methods ──
        public void OnDeselect(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4F6BF930
    }

    /// <summary>Originally: ÍÌÌÏÏÎÍÍÌÏÍÌÎÌÌÌÏÎÍÎÎÍÍ</summary>
    public class DisconnectReceive_C593 : PhotonSocket
    {
        public ÎÎÏÌÏÌÌÍÏÏÌÍÏÎÍÎÌÎÌÌÏÎÎ ÍÎÎÌÌÏÎÍÎÌÍÏÏÌÏÍÏÏÎÌÎÏÎ; // 0x60
        public object ÍÎÍÍÌÎÏÌÌÎÎÎÌÎÍÌÏÌÎÍÍÎÎ; // 0x68
        public UnityEngine.GameObject ÎÌÏÏÎÌÌÎÎÏÍÏÌÍÌÎÏÎÌÌÎÏÏ; // 0x70
        public int ÎÍÎÏÍÌÎÎÌÍÎÌÎÎÏÏÏÎÌÏÏÍÌ;
        public int ÎÌÎÎÏÌÏÎÌÌÏÍÌÌÍÍÍÍÌÍÏÌÌ;
        public int ÍÌÎÎÌÌÏÌÎÎÎÎÌÌÌÌÎÏÌÏÌÎÌ;

        // ── Methods ──
        public void get_Listener(){} // RVA: 0x7FFD4F9C8490
        public void Dispose(){} // RVA: 0x7FFD4F9C8590
        public void Cleanup(){} // RVA: 0x7FFD4F9C86F0
        public void Receive(){} // RVA: 0x7FFD4F9C87F0
        public void Send(){} // RVA: 0x7FFD4F9C8850
        public void set_SocketErrorCode(){} // RVA: 0x7FFD4F9C8A40
        public void get_Connected(){} // RVA: 0x7FFD4F9C8AE0
        public void Connect(){} // RVA: 0x7FFD4F9C8AF0
        public void .ctor(){} // RVA: 0x7FFD4F9C9490
        public void Initialize(){} // RVA: 0x7FFD4F9C96E0
        public void set_ProxyServerAddress(){} // RVA: 0x7FFD4F9C96F0
        public void Disconnect(){} // RVA: 0x7FFD4F9C9790
        public void get_ServerPort(){} // RVA: 0x7FFD4F9C9B80
        public void set_ServerPort(){} // RVA: 0x7FFD4F9C9D10
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x7FFD4F9C9EA0
    }

    /// <summary>Originally: ÏÏÎÏÌÍÌÎÎÍÎÎÎÎÎÏÏÎÍÍÍÏÌ</summary>
    public class DispatchIncomingCommandsSendOutgoingComm_8BCB : PhotonPeer
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
        public 0x665CA768 ÏÍÏÌÌÎÍÏÌÏÌÎÎÌÍÏÎÎÌÍÏÌÍ; // 0x138
        public VRC.Core.PriorityQueue`1<ÌÏÎÎÎÌÍÎÌÍÍÎÎÍÍÌÎÍÎÏÏÌÎ> ÍÌÏÌÏÌÍÎÌÎÌÍÌÍÍÍÌÍÎÍÍÎÏ; // 0x140
        public VRC.Core.PriorityQueue`1<ÌÏÎÎÎÌÍÎÌÍÍÎÎÍÍÌÎÍÎÏÏÌÎ> ÍÍÍÎÌÍÍÍÌÍÏÌÍÍÏÌÍÍÏÍÌÍÍ; // 0x148
        public long ÎÌÍÌÍÍÏÎÏÎÎÏÌÍÏÏÎÎÎÏÍÎÏ; // 0x150
        public ÍÍÎÎÌÏÌÌÏÏÏÌÍÏÎÎÍÎÏÌÍÎÏ ÍÍÌÎÌÎÍÎÎÎÎÌÌÏÌÍÎÎÌÏÎÏÌ; // 0x158
        public long ÌÎÍÍÌÏÎÍÎÏÍÏÍÎÎÍÏÍÏÏÌÌÏ; // 0x160
        public ÍÍÎÎÌÏÌÌÏÏÏÌÍÏÎÎÍÎÏÌÍÎÏ ÏÏÎÎÎÍÎÌÍÎÏÎÎÏÎÍÌÏÏÌÌÌÏ; // 0x168
        public long ÎÎÍÎÌÌÌÌÌÍÌÎÌÍÏÌÍÌÍÎÌÌÌ; // 0x170
        public long ÎÌÍÌÏÌÏÎÌÎÌÍÍÏÎÌÎÎÎÌÎÎÏ; // 0x178

        // ── Methods ──
        public void get_ClientSdkIdShifted(){} // RVA: 0x7FFD4EE08460
        public void get_Version(){} // RVA: 0x7FFD4EE084C0
        public void get_UseAck2(){} // RVA: 0x7FFD4EE086D0
        public void set_UseAck2(){} // RVA: 0x7FFD4EE09490
        public void get_SerializationProtocolType(){} // RVA: 0x7FFD4EE09660
        public void set_SerializationProtocolType(){} // RVA: 0x7FFD4EE09880
        public void get_SocketImplementation(){} // RVA: 0x7FFD4EE09950
        public void set_SocketImplementation(){} // RVA: 0x7FFD4EE09990
        public void get_SocketErrorCode(){} // RVA: 0x7FFD4EE09A30
        public void .ctor(){} // RVA: 0x7FFD4EE09A40
        public void SendOperation(){} // RVA: 0x7FFD4EE0A270
        public void get_PeerState(){} // RVA: 0x7FFD4EE0AE00
        public void get_ReuseEventInstance(){} // RVA: 0x7FFD4EE0AF70
        public void set_ReuseEventInstance(){} // RVA: 0x7FFD4EE0B290
        public void get_UseByteArraySlicePoolForEvents(){} // RVA: 0x7FFD4EE0B2C0
        public void get_WrapIncomingStructs(){} // RVA: 0x7FFD4EE0BDE0
        public void get_QuickResendAttempts(){} // RVA: 0x7FFD4E2ADC40
        public void DispatchIncomingCommands(){} // RVA: 0x7FFD4EE0BFA0
        public void get_DisconnectTimeout(){} // RVA: 0x7FFD4EE0C000
        public void set_DisconnectTimeout(){} // RVA: 0x7FFD4EE0C200
        public void get_CrcEnabled(){} // RVA: 0x7FFD4EE0C2A0
        public void set_CrcEnabled(){} // RVA: 0x7FFD4EE0C390
        public void get_ServerAddress(){} // RVA: 0x7FFD4EE0C900
        public void get_UsedProtocol(){} // RVA: 0x7FFD4EE0CA20
        public void get_TransportProtocol(){} // RVA: 0x7FFD4EE0CA50
        public void set_TransportProtocol(){} // RVA: 0x7FFD4EE0CA80
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFD4EE0CAE0
        public void get_NetworkSimulationSettings(){} // RVA: 0x7FFD4EE0D320
        public void get_MaximumTransferUnit(){} // RVA: 0x7FFD4EE0D5E0
        public void get_IsEncryptionAvailable(){} // RVA: 0x7FFD4EE0D600
        public void get_PayloadEncryptorType(){} // RVA: 0x7FFD4EE0D680
        public void get_EncryptorType(){} // RVA: 0x7FFD4EE0D880
        public void set_EncryptorType(){} // RVA: 0x7FFD4EE0E400
        public void get_ServerTimeInMilliseconds(){} // RVA: 0x7FFD4EE0E7A0
        public void get_EnableServerTracing(){} // RVA: 0x7FFD4EE0EB10
        public void get_ConnectionTime(){} // RVA: 0x7FFD4EE0ED20
        public void get_BytesIn(){} // RVA: 0x7FFD4EE0F120
        public void get_BytesOut(){} // RVA: 0x7FFD4EE0F190
        public void .cctor(){} // RVA: 0x7FFD4EE0FA30
        public void SendOutgoingCommands(){} // RVA: 0x7FFD4EE0FE80
        public void get_PacketLossByCrc(){} // RVA: 0x7FFD4EE0FF10
        public void Disconnect(){} // RVA: 0x7FFD4EE102A0
        public void get_CountDiscarded(){} // RVA: 0x7FFD4EE104D0
        public void set_CountDiscarded(){} // RVA: 0x7FFD4EE10540
    }

}