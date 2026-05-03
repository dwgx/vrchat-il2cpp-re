// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Misc
// Classes: 9
// Methods: 104

namespace VRC.Misc
{
    /// <summary>Originally: ÌÍÌÍÍÏÍÌÏÎÌÍÌÎÎÌÍÍÍÌÍÎÌ</summary>
    public class DataCanConvertWriteJson_A53C : JsonConverter
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFE81B408D0
        public void ReadJson(){} // RVA: 0x7FFE81B409A0
        public void WriteJson(){} // RVA: 0x7FFE81B40B60
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÍÌÌÎÎÏÎÌÌÎÏÌÌÍÍÎÍÌÌÌÏÍÎ</summary>
    public class DataCanConvertWriteJson_CE0B : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFE81B40C10
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CanConvert(){} // RVA: 0x7FFE81B40D40
        public void ReadJson(){} // RVA: 0x7FFE81B40E10
    }

    /// <summary>Originally: ÍÍÎÌÏÌÎÌÍÌÎÎÏÌÌÎÌÌÌÌÏÎÌ</summary>
    public class DataWriteJsonReadJson_17BB : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82320C90
        public void WriteJson(){} // RVA: 0x7FFE82320CC0
        public void ReadJson(){} // RVA: 0x7FFE82320D00
    }

    /// <summary>Originally: ÍÍÍÍÍÌÌÌÌÌÍÍÌÎÎÌÎÍÌÍÍÍÎ</summary>
    public class Deselect_2C17 : TMP_InputField
    {
        // ── Methods ──
        public void OnDeselect(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE8255FB60
    }

    /// <summary>Originally: ÌÌÍÏÌÍÍÌÍÌÌÍÎÏÎÍÎÎÏÍÎÏÎ</summary>
    public class Deselect_5D83 : InputField
    {
        // ── Methods ──
        public void OnDeselect(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE8255FB10
    }

    /// <summary>Originally: ÎÎÏÏÍÏÌÏÍÏÎÏÍÎÌÌÏÍÍÌÎÍÌ</summary>
    public class DisconnectConnect_AB47 : PhotonSocket
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE828765A0
        public void Cleanup(){} // RVA: 0x7FFE82876700
        public void get_State(){} // RVA: 0x7FFE828767A0
        public void set_State(){} // RVA: 0x7FFE828768A0
        public void get_SocketErrorCode(){} // RVA: 0x7FFE828769A0
        public void Disconnect(){} // RVA: 0x7FFE828769B0
        public void get_Connected(){} // RVA: 0x7FFE82876DA0
        public void get_ServerAddress(){} // RVA: 0x7FFE82876F30
        public void set_ServerAddress(){} // RVA: 0x7FFE82877030
        public void Send(){} // RVA: 0x7FFE828771C0
        public void set_ProxyServerAddress(){} // RVA: 0x7FFE828773B0
        public void set_ServerIpAddress(){} // RVA: 0x7FFE82877540
        public void get_ServerPort(){} // RVA: 0x7FFE828775E0
        public void set_ServerPort(){} // RVA: 0x7FFE828775F0
        public void Connect(){} // RVA: 0x7FFE82877690
        public void set_AddressResolvedAsIpv6(){} // RVA: 0x7FFE82878030
        public void .ctor(){} // RVA: 0x7FFE828780D0
        public void Receive(){} // RVA: 0x7FFE82878320
    }

    /// <summary>Originally: ÌÌÍÎÎÏÌÍÍÍÎÍÍÍÌÍÌÍÏÎÏÌÌ</summary>
    public class DispatchIncomingCommandsSendOutgoingComm_9C0E : PhotonPeer
    {
        public ÎÍÍÌÏÏÎÍÍÎÍÍÍÏÍÏÌÏÌÌÌÎÌ _noSocket; // 0xE0
        public int _debugBuild;
        public int _nativeEncryptorApiVersion; // 0xE8
        public System.Collections.Concurrent.ConcurrentDictionary`2<byte,int> _targetFramework; // 0xF0
        public ÌÌÍÎÎÏÌÍÍÍÎÍÍÍÌÍÌÍÏÎÏÌÌ _clientSdkId;
        public int _clientVersion; // 0x8
        public int _noNativeCallbacks; // 0xC
        public System.Collections.Concurrent.ConcurrentDictionary`2<byte,int> _removeAppIdFromWebSocketPath; // 0xF8
        public System.Collections.Concurrent.ConcurrentDictionary`2<uint,int> _useInitV3; // 0x100
        public System.Collections.Concurrent.ConcurrentDictionary`2<byte,int> f_99E; // 0x108
        public System.Collections.Concurrent.ConcurrentDictionary`2<byte,int> _enableEncryptedFlag; // 0x110
        public System.Collections.Concurrent.ConcurrentDictionary`2<uint,int> f_6E4; // 0x118

        // ── Methods ──
        public void get_ClientSdkIdShifted(){} // RVA: 0x7FFE81B44C20
        public void .ctor(){} // RVA: 0x7FFE81B44C30
        public void Initialize(){} // RVA: 0x7FFE81B45460
        public void set_UseAck2(){} // RVA: 0x7FFE81B45860
        public void get_SerializationProtocolType(){} // RVA: 0x7FFE81B45980
        public void set_SerializationProtocolType(){} // RVA: 0x7FFE81B45EF0
        public void get_SocketImplementation(){} // RVA: 0x7FFE81B46280
        public void set_SocketImplementation(){} // RVA: 0x7FFE81B462C0
        public void get_SocketErrorCode(){} // RVA: 0x7FFE810A1420
        public void get_Listener(){} // RVA: 0x7FFE81B46340
        public void set_Listener(){} // RVA: 0x7FFE81B46E60
        public void get_PeerState(){} // RVA: 0x7FFE81B47120
        public void get_ReuseEventInstance(){} // RVA: 0x7FFE81B47340
        public void set_ReuseEventInstance(){} // RVA: 0x7FFE81B47370
        public void get_UseByteArraySlicePoolForEvents(){} // RVA: 0x7FFE81B473A0
        public void get_WrapIncomingStructs(){} // RVA: 0x7FFE81B47F20
        public void Disconnect(){} // RVA: 0x7FFE81B47F80
        public void set_QuickResendAttempts(){} // RVA: 0x7FFE81B481B0
        public void get_DisconnectTimeout(){} // RVA: 0x7FFE81B482E0
        public void set_DisconnectTimeout(){} // RVA: 0x7FFE81B48350
        public void get_CrcEnabled(){} // RVA: 0x7FFE81B483B0
        public void set_CrcEnabled(){} // RVA: 0x7FFE81B483D0
        public void get_ServerAddress(){} // RVA: 0x7FFE81B486F0
        public void get_UsedProtocol(){} // RVA: 0x7FFE81B488F0
        public void get_TransportProtocol(){} // RVA: 0x7FFE81B48AA0
        public void set_TransportProtocol(){} // RVA: 0x7FFE81B48E40
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFE81B48EC0
        public void get_NetworkSimulationSettings(){} // RVA: 0x7FFE81B48F30
        public void get_MaximumTransferUnit(){} // RVA: 0x7FFE81B49000
        public void get_IsEncryptionAvailable(){} // RVA: 0x7FFE81B49130
        public void get_PayloadEncryptorType(){} // RVA: 0x7FFE81B491B0
        public void get_EncryptorType(){} // RVA: 0x7FFE81B491E0
        public void .cctor(){} // RVA: 0x7FFE81B49280
        public void get_ServerTimeInMilliseconds(){} // RVA: 0x7FFE81B496D0
        public void get_EnableServerTracing(){} // RVA: 0x7FFE81B49840
        public void get_ConnectionTime(){} // RVA: 0x7FFE81B498E0
        public void DispatchIncomingCommands(){} // RVA: 0x7FFE81B4A120
        public void get_BytesOut(){} // RVA: 0x7FFE81B4A180
        public void SendOutgoingCommands(){} // RVA: 0x7FFE81B4A220
        public void get_ByteCountLastOperation(){} // RVA: 0x7FFE81B4A2B0
        public void get_PacketLossByCrc(){} // RVA: 0x7FFE81B4A480
        public void get_PacketLossByChallenge(){} // RVA: 0x7FFE81B4B240
        public void get_CountDiscarded(){} // RVA: 0x7FFE81B4B330
        public void set_CountDiscarded(){} // RVA: 0x7FFE81B4BBD0
        public void SendOperation(){} // RVA: 0x7FFE81B4C140
    }

    /// <summary>Originally: ÏÍÌÎÍÍÌÎÌÌÎÎÌÌÌÌÌÏÌÏÍÌÏ</summary>
    public class dateTimestampComponent_4D49 : MonoBehaviour
    {
        public ÏÌÎÌÌÌÍÌÌÌÌÌÌÏÍÍÎÌÏÏÏÍÌ _dateTimestamp; // 0x20

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE8984BC30
        public void OnDisable(){} // RVA: 0x7FFE8984BC30
        public void IsInvoking(){} // RVA: 0x7FFE8984BC70
        public void CancelInvoke(){} // RVA: 0x7FFE8984BD80
        public void Invoke(){} // RVA: 0x7FFE811C3500
        public void InvokeRepeating(){} // RVA: 0x7FFE8984BE90
        public void OnDestroy(){} // RVA: 0x7FFE8984CEB0
        public void OnApplicationPause(){} // RVA: 0x7FFE8984DEE0
        public void StartCoroutine(){} // RVA: 0x7FFE811C3500
        public void Awake(){} // RVA: 0x7FFE8984DF20
        public void Start(){} // RVA: 0x7FFE8984EF30
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Initialize(){} // RVA: 0x7FFE811C3500
        public void StopCoroutine(){} // RVA: 0x7FFE811C3500
    }

    /// <summary>Originally: ÌÌÎÎÍÏÎÍÌÎÏÎÎÍÎÎÍÍÌÏÏÏÏ</summary>
    public class displayComponent_3626 : MonoBehaviour
    {
        public UnityEngine.UI.RawImage display; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE896545C0
        public void Start(){} // RVA: 0x7FFE89654650
        public void IsInvoking(){} // RVA: 0x7FFE87582E90
        public void CancelInvoke(){} // RVA: 0x7FFE896547C0
        public void Invoke(){} // RVA: 0x7FFE87582E90
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Initialize(){} // RVA: 0x7FFE89654850
        public void OnApplicationPause(){} // RVA: 0x7FFE896547C0
        public void StartCoroutine(){} // RVA: 0x7FFE89654880
        public void OnBecameVisible(){} // RVA: 0x7FFE89654850
        public void OnBecameInvisible(){} // RVA: 0x7FFE89654900
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE89654A70
    }

}