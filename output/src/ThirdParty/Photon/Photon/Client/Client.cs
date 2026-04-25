// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client
// Classes: 23
// Methods: 287

namespace ThirdParty.Photon.Photon.Client
{
    public class ByteArraySlice : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DBF230
        public void Dispose(){} // RVA: 0x7FFD53DBF360
        public void Release(){} // RVA: 0x7FFD53DBF3A0
    }

    public class ByteArraySlicePool : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DBF3E0
        public void Acquire(){} // RVA: 0x7FFD53DBF630
        public void PopOrCreate(){} // RVA: 0x7FFD53DBFA80
        public void Release(){} // RVA: 0x7FFD53DBFDA0
    }

    public class CustomType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DDC1F0
    }

    public class DeserializeStreamMethod : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DDC070
        public void Invoke(){} // RVA: 0x7FFD4E49D370
    }

    public class EnetChannel : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DC12A0
        public void AddSequencedIfNew(){} // RVA: 0x7FFD53DC1770
        public void TryGetFragment(){} // RVA: 0x7FFD53DC1840
        public void RemoveFragment(){} // RVA: 0x7FFD53DC18C0
        public void clearAll(){} // RVA: 0x7FFD53DC1930
        public void QueueIncomingReliableUnsequenced(){} // RVA: 0x7FFD53DC1C70
        public void ApplySequenceNumberModifier(){} // RVA: 0x7FFD53DC1FB0
        public void Received(){} // RVA: 0x7FFD53DC2000
        public void GetGapBlock(){} // RVA: 0x7FFD53DC22B0
    }

    public class EventData : Object
    {
        public object Item;
        public object Sender;
        public object CustomData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DF2B00
        public void get_Item(){} // RVA: 0x7FFD53DF2BB0
        public void get_Sender(){} // RVA: 0x7FFD53DF2C20
        public void set_Sender(){} // RVA: 0x7FFD4F5874D0
        public void get_CustomData(){} // RVA: 0x7FFD53DF2CA0
        public void Reset(){} // RVA: 0x7FFD53DF2D30
        public void ToString(){} // RVA: 0x7FFD53DF2DB0
    }

    public class IPhotonPeerListener
    {
        // ── Methods ──
        public void DebugReturn(){} // RVA: 0x7FFD4E091580
        public void OnOperationResponse(){} // RVA: 0x7FFD4E090A40
        public void OnStatusChanged(){} // RVA: 0x7FFD4E090ED0
        public void OnEvent(){} // RVA: 0x7FFD4E090A40
        public void OnMessage(){} // RVA: 0x7FFD4E091580
        public void OnDisconnectMessage(){} // RVA: 0x7FFD4E090A40
    }

    public class ITrafficRecorder
    {
        // ── Methods ──
        public void Record(){}
    }

    public class NCommand : Object
    {
        public object SizeOfPayload;
        public object IsFlaggedUnsequenced;
        public object IsFlaggedReliable;

        // ── Methods ──
        public void get_SizeOfPayload(){} // RVA: 0x7FFD53DCC750
        public void get_IsFlaggedUnsequenced(){} // RVA: 0x7FFD53DCC770
        public void get_IsFlaggedReliable(){} // RVA: 0x7FFD53DCC780
        public void CreateAck(){} // RVA: 0x7FFD53DCC7A0
        public void CreateAck2(){} // RVA: 0x7FFD53DCC9D0
        public void Initialize(){} // RVA: 0x7FFD53DCCFA0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFD53DCD5C0
        public void SerializeHeader(){} // RVA: 0x7FFD53DCD600
        public void Serialize(){} // RVA: 0x7FFD53DCDA90
        public void FreePayload(){} // RVA: 0x7FFD53DCDAB0
        public void CompareTo(){} // RVA: 0x7FFD53DCDB90
        public void ToString(){} // RVA: 0x7FFD53DCDBD0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD53DCE430
    }

    public class NetworkSimulationSet : Object
    {
        public object IsSimulationEnabled;
        public object OutgoingLossPercentage;
        public object IncomingLossPercentage;
        public object LostPackagesOut;
        public object LostPackagesIn;

        // ── Methods ──
        public void get_IsSimulationEnabled(){} // RVA: 0x7FFD4E40B5E0
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFD53DCE440
        public void set_OutgoingLossPercentage(){} // RVA: 0x7FFD4F8674D0
        public void set_IncomingLossPercentage(){} // RVA: 0x7FFD4EABA6E0
        public void set_LostPackagesOut(){} // RVA: 0x7FFD4E3E20D0
        public void set_LostPackagesIn(){} // RVA: 0x7FFD4FCBE500
        public void ToString(){} // RVA: 0x7FFD53DCF070
        public void .ctor(){} // RVA: 0x7FFD53DCF3C0
    }

    public class NonAllocDictionary`2 : Object
    {
        public object Keys;
        public object System.Collections.Generic.IDictionary<K,V>.Values;
        public object System.Collections.Generic.IDictionary<K,V>.Keys;
        public object Count;
        public object IsReadOnly;
        public object Item;

        // ── Methods ──
        public void get_Keys(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void Add(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Remove(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void FindNode(){} // RVA: 0x7FFD4E2ADC40
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void Expand(){} // RVA: 0x7FFD4E090980
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x7FFD4E097970
        public void IsPrimeFromList(){} // RVA: 0x7FFD4E07A7A0
        public void GetNextPrime(){} // RVA: 0x7FFD4E080110
        public void Assert(){} // RVA: 0x7FFD4E090E50
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class OperationResponse : Object
    {
        public object Item;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFD53DF26D0
        public void ToString(){} // RVA: 0x7FFD53DF2740
        public void ToStringFull(){} // RVA: 0x7FFD53DF28C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ParameterDictionary : Object
    {
        public object Item;
        public object Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DCF5E0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFD52BE53A0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Byte,System.Object>>.GetEnumerator(){} // RVA: 0x7FFD53DCF740
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD53DCF790
        public void GetEnumerator(){} // RVA: 0x7FFD53DCF7E0
        public void get_Item(){} // RVA: 0x7FFD53DCF890
        public void set_Item(){} // RVA: 0x7FFD53DCF940
        public void get_Count(){} // RVA: 0x7FFD53DCF9B0
        public void Clear(){} // RVA: 0x7FFD53DCFA00
        public void Add(){} // RVA: 0x7FFD53DCFF70 | overloaded x5
        public void Get(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsKey(){} // RVA: 0x7FFD53DD0070
        public void TryGetValue(){} // RVA: 0x7FFD53DD00D0 | overloaded x2
    }

    public class PhotonHashtable : Dictionary`2
    {
        public object Item;
        public object Item;
        public object Item;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD53DC00E0
        public void .ctor(){} // RVA: 0x7FFD53DC0380 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFD53DC0660 | overloaded x3
        public void set_Item(){} // RVA: 0x7FFD53DC0590 | overloaded x2
        public void Add(){} // RVA: 0x7FFD53DC06F0
        public void ContainsKey(){} // RVA: 0x7FFD53DC07C0
        public void GetEnumerator(){} // RVA: 0x7FFD53DC0880
        public void ToString(){} // RVA: 0x7FFD53DC09C0
    }

    public class PhotonPeer : Object
    {
        public object ClientSdkIdShifted;
        public object Version;
        public object UseAck2;
        public object SerializationProtocolType;
        public object SocketImplementation;
        public object SocketErrorCode;
        public object Listener;
        public object PeerState;
        public object ReuseEventInstance;
        public object UseByteArraySlicePoolForEvents;
        public object WrapIncomingStructs;
        public object QuickResendAttempts;
        public object DisconnectTimeout;
        public object CrcEnabled;
        public object ServerAddress;
        public object UsedProtocol;
        public object TransportProtocol;
        public object IsSimulationEnabled;
        public object NetworkSimulationSettings;
        public object MaximumTransferUnit;
        public object IsEncryptionAvailable;
        public object PayloadEncryptorType;
        public object EncryptorType;
        public object ServerTimeInMilliseconds;
        public object EnableServerTracing;
        public object ConnectionTime;
        public object BytesIn;
        public object BytesOut;
        public object ByteCountCurrentDispatch;
        public object ByteCountLastOperation;
        public object PacketLossByCrc;
        public object PacketLossByChallenge;
        public object CountDiscarded;
        public object DeltaUnreliableNumber;
        public object QueuedOutgoingCommands;
        public object Stats;

        // ── Methods ──
        public void get_ClientSdkIdShifted(){} // RVA: 0x7FFD53DD6FA0
        public void get_Version(){} // RVA: 0x7FFD53DD6FB0
        public void get_UseAck2(){} // RVA: 0x7FFD53DD7390
        public void set_UseAck2(){} // RVA: 0x7FFD53DD73A0
        public void get_SerializationProtocolType(){} // RVA: 0x7FFD4F8557F0
        public void set_SerializationProtocolType(){} // RVA: 0x7FFD4F8674D0
        public void get_SocketImplementation(){} // RVA: 0x7FFD4E36F130
        public void set_SocketImplementation(){} // RVA: 0x7FFD4E342E90
        public void get_SocketErrorCode(){} // RVA: 0x7FFD53DD73B0
        public void get_Listener(){} // RVA: 0x7FFD4E5F0140
        public void set_Listener(){} // RVA: 0x7FFD4E5F0C20
        public void get_PeerState(){} // RVA: 0x7FFD53DD73E0
        public void get_ReuseEventInstance(){} // RVA: 0x7FFD4E3FCC00
        public void set_ReuseEventInstance(){} // RVA: 0x7FFD53DD7450
        public void get_UseByteArraySlicePoolForEvents(){} // RVA: 0x7FFD4E5F8A60
        public void get_WrapIncomingStructs(){} // RVA: 0x7FFD4E5F90A0
        public void get_QuickResendAttempts(){} // RVA: 0x7FFD4E3F8D30
        public void set_QuickResendAttempts(){} // RVA: 0x7FFD53DD7600
        public void get_DisconnectTimeout(){} // RVA: 0x7FFD4ECB13D0
        public void set_DisconnectTimeout(){} // RVA: 0x7FFD53DD7620
        public void get_CrcEnabled(){} // RVA: 0x7FFD4E55F600
        public void set_CrcEnabled(){} // RVA: 0x7FFD53DD7630
        public void get_ServerAddress(){} // RVA: 0x7FFD53DD76C0
        public void get_UsedProtocol(){} // RVA: 0x7FFD53DD76E0
        public void get_TransportProtocol(){} // RVA: 0x7FFD4F031000
        public void set_TransportProtocol(){} // RVA: 0x7FFD4F024530
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFD53DD7700
        public void get_NetworkSimulationSettings(){} // RVA: 0x7FFD53DD78A0
        public void get_MaximumTransferUnit(){} // RVA: 0x7FFD4E558CA0
        public void get_IsEncryptionAvailable(){} // RVA: 0x7FFD53DD78D0
        public void get_PayloadEncryptorType(){} // RVA: 0x7FFD4E505600
        public void get_EncryptorType(){} // RVA: 0x7FFD4E380010
        public void set_EncryptorType(){} // RVA: 0x7FFD53DD7900
        public void get_ServerTimeInMilliseconds(){} // RVA: 0x7FFD53DD7AC0
        public void get_EnableServerTracing(){} // RVA: 0x7FFD4F9E9D50
        public void get_ConnectionTime(){} // RVA: 0x7FFD53DD7B10
        public void get_BytesIn(){} // RVA: 0x7FFD53DD7B40
        public void get_BytesOut(){} // RVA: 0x7FFD53DD7B60
        public void get_ByteCountCurrentDispatch(){} // RVA: 0x7FFD53DD7B80
        public void get_ByteCountLastOperation(){} // RVA: 0x7FFD53DD7BA0
        public void get_PacketLossByCrc(){} // RVA: 0x7FFD53DD7BC0
        public void get_PacketLossByChallenge(){} // RVA: 0x7FFD53DD7BE0
        public void get_CountDiscarded(){} // RVA: 0x7FFD51959470
        public void set_CountDiscarded(){} // RVA: 0x7FFD51959480
        public void set_DeltaUnreliableNumber(){} // RVA: 0x7FFD4ED1D010
        public void get_QueuedOutgoingCommands(){} // RVA: 0x7FFD53DD7C00
        public void get_Stats(){} // RVA: 0x7FFD4E3AC040
        public void set_Stats(){} // RVA: 0x7FFD4E3AC050
        public void .ctor(){} // RVA: 0x7FFD53DD82C0 | overloaded x2
        public void Connect(){} // RVA: 0x7FFD53DD8340
        public void CreatePeerBase(){} // RVA: 0x7FFD53DD9040
        public void Disconnect(){} // RVA: 0x7FFD53DD9260
        public void FetchServerTimestamp(){} // RVA: 0x7FFD53DD9520
        public void EstablishEncryption(){} // RVA: 0x7FFD53DD9550
        public void InitDatagramEncryption(){} // RVA: 0x7FFD53DD9630
        public void InitPayloadEncryption(){} // RVA: 0x7FFD4E8F4AA0
        public void Service(){} // RVA: 0x7FFD53DD9A80
        public void SendOutgoingCommands(){} // RVA: 0x7FFD53DD9AD0
        public void SendAcksOnly(){} // RVA: 0x7FFD53DD9CB0
        public void DispatchIncomingCommands(){} // RVA: 0x7FFD53DD9E20
        public void SendOperation(){} // RVA: 0x7FFD53DDA010
        public void RegisterType(){} // RVA: 0x7FFD53DDA4A0
        public void .cctor(){} // RVA: 0x7FFD53DDA530
        public void <EstablishEncryption>b__203_0(){} // RVA: 0x7FFD53DDA590
    }

    public class PhotonSocket : Object
    {
        public object Listener;
        public object MTU;
        public object State;
        public object SocketErrorCode;
        public object Connected;
        public object ServerAddress;
        public object ProxyServerAddress;
        public object ServerIpAddress;
        public object ServerPort;
        public object AddressResolvedAsIpv6;
        public object UrlProtocol;
        public object UrlPath;
        public object SerializationProtocol;

        // ── Methods ──
        public void get_Listener(){} // RVA: 0x7FFD53DDA5C0
        public void get_MTU(){} // RVA: 0x7FFD53DDA5F0
        public void get_State(){} // RVA: 0x7FFD4F8557F0
        public void set_State(){} // RVA: 0x7FFD4F8674D0
        public void get_SocketErrorCode(){} // RVA: 0x7FFD4E4FBBE0
        public void set_SocketErrorCode(){} // RVA: 0x7FFD4E9FB7A0
        public void get_Connected(){} // RVA: 0x7FFD53DDA620
        public void get_ServerAddress(){} // RVA: 0x7FFD4E5F95E0
        public void set_ServerAddress(){} // RVA: 0x7FFD4E36F890
        public void get_ProxyServerAddress(){} // RVA: 0x7FFD4E5F0140
        public void set_ProxyServerAddress(){} // RVA: 0x7FFD4E5F0C20
        public void set_ServerIpAddress(){} // RVA: 0x7FFD4E369200
        public void get_ServerPort(){} // RVA: 0x7FFD4E3E20C0
        public void set_ServerPort(){} // RVA: 0x7FFD4E3E20D0
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x7FFD4F588960
        public void set_AddressResolvedAsIpv6(){} // RVA: 0x7FFD4F58A6F0
        public void set_UrlProtocol(){} // RVA: 0x7FFD4E4994D0
        public void set_UrlPath(){} // RVA: 0x7FFD4E409510
        public void get_SerializationProtocol(){} // RVA: 0x7FFD53DDA630
        public void .ctor(){} // RVA: 0x7FFD53DDA7F0
        public void Connect(){} // RVA: 0x7FFD53DDA920
        public void Disconnect(){} // RVA: 0x7FFD4E079D00
        public void Send(){}
        public void Receive(){} // RVA: 0x7FFD4E07E6B0
        public void HandleReceivedDatagram(){} // RVA: 0x7FFD53DDACD0
        public void ReportDebugOfLevel(){} // RVA: 0x7FFD53DDAD00
        public void EnqueueDebugReturn(){} // RVA: 0x7FFD53DDAD30
        public void HandleException(){} // RVA: 0x7FFD53DDAD50
        public void TryParseAddress(){} // RVA: 0x7FFD53DDAE00
        public void IpAddressTryParse(){} // RVA: 0x7FFD53DDB2F0
        public void GetIpAddresses(){} // RVA: 0x7FFD53DDB5B0
        public void AddressSortComparer(){} // RVA: 0x7FFD53DDBD70
        public void <HandleException>b__56_0(){} // RVA: 0x7FFD53DDBDD0
    }

    public class Pool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){}
        public void CreatePoolItems(){} // RVA: 0x7FFD4E090ED0
        public void Release(){} // RVA: 0x7FFD4E2ADC40
        public void Acquire(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Protocol : Object
    {
        public object ProtocolType;
        public object VersionBytes;

        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7FFD4E078E90
        public void get_VersionBytes(){} // RVA: 0x7FFD4E078E90
        public void Serialize(){} // RVA: 0x7FFD53DDC300 | overloaded x2
        public void SerializeShort(){}
        public void SerializeString(){}
        public void SerializeEventData(){}
        public void SerializeOperationRequest(){}
        public void SerializeOperationResponse(){}
        public void Deserialize(){} // RVA: 0x7FFD53DDC3A0 | overloaded x2
        public void DeserializeShort(){} // RVA: 0x7FFD4E07F5D0
        public void DeserializeByte(){} // RVA: 0x7FFD4E079F60
        public void DeserializeEventData(){}
        public void DeserializeOperationRequest(){} // RVA: 0x7FFD4E089DD0
        public void DeserializeOperationResponse(){} // RVA: 0x7FFD4E089DD0
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFD4E078F40
        public void DeserializeMessage(){} // RVA: 0x7FFD53DDC490
        public void TryRegisterType(){} // RVA: 0x7FFD53DDC4F0
        public void .ctor(){} // RVA: 0x7FFD53DDC860
        public void .cctor(){} // RVA: 0x7FFD53DDC900
    }

    public class SendOptions : ValueType
    {
        public object Reliability;

        // ── Methods ──
        public void get_Reliability(){} // RVA: 0x7FFD53DF37A0
        public void set_Reliability(){} // RVA: 0x7FFD53DF37B0
        public void .cctor(){} // RVA: 0x7FFD53DF37C0
    }

    public class SerializeStreamMethod : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD510DD790
        public void Invoke(){} // RVA: 0x7FFD4E49D370
    }

    public class SimulationItem : Object
    {
        public object Delay;

        // ── Methods ──
        public void get_Delay(){} // RVA: 0x7FFD4E70C4C0
    }

    public class StreamBuffer : Object
    {
        public object Length;
        public object Position;
        public object Available;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DFB280 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFD53DFB2F0
        public void Compact(){} // RVA: 0x7FFD53DFB360
        public void GetBuffer(){} // RVA: 0x7FFD4E3447C0
        public void GetBufferAndAdvance(){} // RVA: 0x7FFD53DFB3E0
        public void get_Length(){} // RVA: 0x7FFD4E7F5A20
        public void get_Position(){} // RVA: 0x7FFD4E38E5C0
        public void set_Position(){} // RVA: 0x7FFD53DFB420
        public void get_Available(){} // RVA: 0x7FFD53DFB440
        public void Reset(){} // RVA: 0x7FFD53DFB450
        public void Seek(){} // RVA: 0x7FFD53DFB460
        public void SetLength(){} // RVA: 0x7FFD53DFB580
        public void SetCapacityMinimum(){} // RVA: 0x7FFD53DFB5B0
        public void Read(){} // RVA: 0x7FFD53DFB5C0
        public void Write(){} // RVA: 0x7FFD53DFB620
        public void ReadByte(){} // RVA: 0x7FFD53DFB6A0
        public void WriteByte(){} // RVA: 0x7FFD53DFB790
        public void WriteBytes(){} // RVA: 0x7FFD53DFB7F0
        public void CheckSize(){} // RVA: 0x7FFD53DFB880
    }

    public class TPeer : PeerBase
    {
        public object QueuedOutgoingCommandsCount;

        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7FFD53DFD6F0
        public void .ctor(){} // RVA: 0x7FFD53DFD740
        public void IsTransportEncrypted(){} // RVA: 0x7FFD53DFD970
        public void Reset(){} // RVA: 0x7FFD53DFD980
        public void Connect(){} // RVA: 0x7FFD53DFDB10
        public void Disconnect(){} // RVA: 0x7FFD53DFDF70 | overloaded x2
        public void FetchServerTimestamp(){} // RVA: 0x7FFD53DFE220
        public void EnqueueInit(){} // RVA: 0x7FFD53DFE360
        public void DispatchIncomingCommands(){} // RVA: 0x7FFD53DFE500
        public void SendOutgoingCommands(){} // RVA: 0x7FFD53DFEA40
        public void SendAcksOnly(){} // RVA: 0x7FFD53DFEF10
        public void EnqueuePhotonMessage(){} // RVA: 0x7FFD53DFEF80
        public void EnqueueMessageAsPayload(){} // RVA: 0x7FFD53DFEFB0
        public void SendPing(){} // RVA: 0x7FFD53DFF360
        public void SendData(){} // RVA: 0x7FFD53DFF800
        public void ReceiveIncomingCommands(){} // RVA: 0x7FFD53DFF990
        public void ReadPingResult(){} // RVA: 0x7FFD53E00030 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD53E00180
    }

}