// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Misc
// Classes: 7
// Methods: 88

namespace VRC.Misc
{
    /// <summary>Originally: ÏÏÏÍÍÎÏÍÍÏÏÏÏÍÌÏÎÍÏÏÎÍÍ</summary>
    public class DataCanConvertWriteJson_043E : JsonConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CanConvert(){} // RVA: 0x1671D30
        public void ReadJson(){} // RVA: 0x1671DD0
        public void WriteJson(){} // RVA: 0x1671F80
    }

    /// <summary>Originally: ÏÍÏÌÏÌÎÎÎÏÍÎÎÌÌÌÍÌÍÎÏÌÍ</summary>
    public class DataCanConvertWriteJson_3A41 : JsonConverter
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x1671A30
        public void ReadJson(){} // RVA: 0x1671AD0
        public void .ctor(){} // RVA: 0xB43310
        public void WriteJson(){} // RVA: 0x1671C80
    }

    /// <summary>Originally: ÍÏÏÏÏÍÏÎÌÏÏÍÎÎÎÌÌÌÎÏÏÎÏ</summary>
    public class DataWriteJsonReadJson_C103 : JsonConverter`1
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x1E842D0
        public void ReadJson(){} // RVA: 0x1E84310
        public void .ctor(){} // RVA: 0x1E84600
    }

    /// <summary>Originally: ÏÎÍÍÌÌÌÎÎÍÏÎÍÌÏÍÎÍÌÎÍÎÏ</summary>
    public class Deselect_41DC : TMP_InputField
    {
        // ── Methods ──
        public void get_inputSystem(){} // RVA: 0x20BC4C0
        public void get_compositionString(){} // RVA: 0x20BC570
        public void get_compositionLength(){} // RVA: 0x20BC620
        public void Awake(){} // RVA: 0x20BC780
        public void OnDeselect(){} // RVA: 0xB43310
        public void get_shouldActivateOnSelect(){} // RVA: 0x20BC830
        public void get_shouldHideMobileInput(){} // RVA: 0x20BC8E0
        public void .ctor(){} // RVA: 0x20BC990
        public void Initialize(){} // RVA: 0x20BC9E0
        public void set_shouldHideSoftKeyboard(){} // RVA: 0x20BCA90
        // ── Unresolved (hash) ──
        public void m_22E(){} // RVA: 0x20BC6D0
    }

    /// <summary>Originally: ÌÍÎÎÍÌÌÌÏÍÌÎÎÌÌÍÍÌÎÌÎÎÏ</summary>
    public class Deselect_F3EF : InputField
    {
        // ── Methods ──
        public void OnDeselect(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x20BC470
    }

    /// <summary>Originally: ÏÌÏÏÌÎÍÎÍÎÎÎÌÍÎÍÏÍÌÌÎÎÍ</summary>
    public class DisconnectReceive_3BEB : PhotonSocket
    {
        // ── Methods ──
        public void get_Listener(){} // RVA: 0x2343F60
        public void get_MTU(){} // RVA: 0x2343F70
        public void get_State(){} // RVA: 0x23440A0
        public void set_State(){} // RVA: 0x2344240
        public void get_SocketErrorCode(){} // RVA: 0x2344340
        public void Dispose(){} // RVA: 0x23444E0
        public void .ctor(){} // RVA: 0x2344610
        public void Receive(){} // RVA: 0x2344860
        public void get_ServerAddress(){} // RVA: 0x23448C0
        public void set_ServerAddress(){} // RVA: 0x23449C0
        public void get_ProxyServerAddress(){} // RVA: 0x2344B80
        public void Connect(){} // RVA: 0x2344D40
        public void Disconnect(){} // RVA: 0x2345470
        public void get_ServerPort(){} // RVA: 0x2345780
        public void Send(){} // RVA: 0x2345880
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x2345A30
        public void set_AddressResolvedAsIpv6(){} // RVA: 0x2345C00
        public void set_UrlProtocol(){} // RVA: 0x2345C10
    }

    /// <summary>Originally: ÎÏÎÍÎÍÌÍÏÏÎÏÌÎÌÏÍÌÎÍÍÏÍ</summary>
    public class DispatchIncomingCommandsSendOutgoingComm_CA67 : PhotonPeer
    {
        // ── Methods ──
        public void get_ClientSdkIdShifted(){} // RVA: 0x16756F0
        public void SendOutgoingCommands(){} // RVA: 0x16758C0
        public void get_UseAck2(){} // RVA: 0x1675950
        public void set_UseAck2(){} // RVA: 0x1675BE0
        public void get_SerializationProtocolType(){} // RVA: 0x1675C50
        public void set_SerializationProtocolType(){} // RVA: 0x16761F0
        public void get_SocketImplementation(){} // RVA: 0x16762C0
        public void set_SocketImplementation(){} // RVA: 0x1676360
        public void .cctor(){} // RVA: 0x1676510
        public void get_Listener(){} // RVA: 0x1676A20
        public void set_Listener(){} // RVA: 0x1676BD0
        public void get_PeerState(){} // RVA: 0x1676CF0
        public void SendOperation(){} // RVA: 0x1677230
        public void set_ReuseEventInstance(){} // RVA: 0x1677EE0
        public void get_UseByteArraySlicePoolForEvents(){} // RVA: 0x1677F40
        public void get_WrapIncomingStructs(){} // RVA: 0x1678100
        public void get_QuickResendAttempts(){} // RVA: 0x1678810
        public void set_QuickResendAttempts(){} // RVA: 0x1678830
        public void get_DisconnectTimeout(){} // RVA: 0x1678900
        public void set_DisconnectTimeout(){} // RVA: 0x1678970
        public void get_CrcEnabled(){} // RVA: 0x1678BC0
        public void set_CrcEnabled(){} // RVA: 0x1678C00
        public void get_ServerAddress(){} // RVA: 0x1678F80
        public void get_UsedProtocol(){} // RVA: 0x1678F90
        public void get_TransportProtocol(){} // RVA: 0x1679250
        public void set_TransportProtocol(){} // RVA: 0x1679750
        public void set_IsSimulationEnabled(){} // RVA: 0x16797F0
        public void get_NetworkSimulationSettings(){} // RVA: 0x1679B60
        public void Disconnect(){} // RVA: 0x167A900
        public void get_IsEncryptionAvailable(){} // RVA: 0x167AB00
        public void get_PayloadEncryptorType(){} // RVA: 0x167B090
        public void get_EncryptorType(){} // RVA: 0x167BBD0
        public void set_EncryptorType(){} // RVA: 0x167BD50
        public void get_ServerTimeInMilliseconds(){} // RVA: 0x167C670
        public void get_EnableServerTracing(){} // RVA: 0x167CC00
        public void get_ConnectionTime(){} // RVA: 0x167D700
        public void get_BytesIn(){} // RVA: 0x167D890
        public void get_BytesOut(){} // RVA: 0x2C63050
        public void .ctor(){} // RVA: 0x167DCA0
        public void Initialize(){} // RVA: 0x167E5E0
        public void get_PacketLossByCrc(){} // RVA: 0x167E700
        public void get_PacketLossByChallenge(){} // RVA: 0x167E730
        public void DispatchIncomingCommands(){} // RVA: 0x167E760
        public void set_CountDiscarded(){} // RVA: 0x167E7C0
        public void set_DeltaUnreliableNumber(){} // RVA: 0x167E840
        public void get_QueuedOutgoingCommands(){} // RVA: 0x167EA10
    }

}