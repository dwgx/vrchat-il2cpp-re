// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client
// Classes: 45
// Methods: 660

namespace ThirdParty.Photon.Photon.Client
{
    public class ByteArraySlice
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6207A20
        public void Dispose(){} // RVA: 0x6207B50
        public void Release(){} // RVA: 0x6207B90
    }

    public class ByteArraySlicePool
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6207BD0
        public void Acquire(){} // RVA: 0x6207E20
        public void PopOrCreate(){} // RVA: 0x6208270
        public void Release(){} // RVA: 0x6208590
    }

    public class CustomType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6224D90
    }

    public class DeserializeStreamMethod
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6224C10
        public void Invoke(){} // RVA: 0x439370
    }

    public class DictionaryEntryEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2878D50
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x62097A0
        public void get_Current(){} // RVA: 0x62098F0
        public void MoveNext(){} // RVA: 0x6209980
        public void Reset(){} // RVA: 0x62099C0
        public void Dispose(){} // RVA: 0x2DD310
    }

    public class DisconnectMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EnetChannel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6209A90
        public void AddSequencedIfNew(){} // RVA: 0x6209F60
        public void TryGetFragment(){} // RVA: 0x620A030
        public void RemoveFragment(){} // RVA: 0x620A0B0
        public void clearAll(){} // RVA: 0x620A120
        public void QueueIncomingReliableUnsequenced(){} // RVA: 0x620A460
        public void ApplySequenceNumberModifier(){} // RVA: 0x620A7A0
        public void Received(){} // RVA: 0x620A7F0
        public void GetGapBlock(){} // RVA: 0x620AAA0
    }

    public class EnetPeer
    {
        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x620AED0
        public void get_SendWindowUpdateRequired(){} // RVA: 0x620B1F0
        public void set_SendWindowUpdateRequired(){} // RVA: 0x620B210
        public void get_DatagramEncryptedConnection(){} // RVA: 0x620B230
        public void set_DatagramEncryptedConnection(){} // RVA: 0x620B250
        public void get_useAck2(){} // RVA: 0x620B270
        public void .ctor(){} // RVA: 0x620B2A0
        public void IsTransportEncrypted(){} // RVA: 0x620B230
        public void Reset(){} // RVA: 0x620BC30
        public void ApplyRandomizedSequenceNumbers(){} // RVA: 0x620C4A0
        public void GetChannel(){} // RVA: 0x620C6C0
        public void Connect(){} // RVA: 0x620C720
        public void Disconnect(){} // RVA: 0x620C7F0
        public void FetchServerTimestamp(){} // RVA: 0x620CD30
        public void DispatchCommandQueue(){} // RVA: 0x620CE50
        public void DispatchIncomingCommands(){} // RVA: 0x620CF30
        public void GetFragmentLength(){} // RVA: 0x620DAC0
        public void CalculatePacketSize(){} // RVA: 0x620DBA0
        public void CalculateInitialOffset(){} // RVA: 0x620DC30
        public void SendAcksOnly(){} // RVA: 0x620DC80
        public void SendOutgoingCommands(){} // RVA: 0x620DCA0 | overloaded x2
        public void UpdateSendWindow(){} // RVA: 0x620EDA0
        public void EnqueuePhotonMessage(){} // RVA: 0x620F7E0
        public void CreateAndEnqueueCommand(){} // RVA: 0x620F830
        public void SerializeAckToBuffer(){} // RVA: 0x620FE20
        public void SerializeToBuffer(){} // RVA: 0x6210320
        public void SerializeCommandToBuffer(){} // RVA: 0x6210470
        public void SendData(){} // RVA: 0x6210650
        public void SendToSocket(){} // RVA: 0x62109C0
        public void SendDataEncrypted(){} // RVA: 0x6210B30
        public void QueueSentCommand(){} // RVA: 0x6210E40
        public void QueueOutgoingReliableCommand(){} // RVA: 0x62111E0
        public void QueueOutgoingUnreliableCommand(){} // RVA: 0x6211410
        public void QueueOutgoingAcknowledgement(){} // RVA: 0x62116B0
        public void ReceiveIncomingCommands(){} // RVA: 0x6211BB0
        public void ExecuteCommand(){} // RVA: 0x6212770
        public void QueueIncomingCommand(){} // RVA: 0x6213F70
        public void RemoveSentReliableCommand(){} // RVA: 0x6214870
        public void .cctor(){} // RVA: 0x6214D10
        public void <ExecuteCommand>b__78_0(){} // RVA: 0x6214DF0
    }

    public class EventData
    {
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x623B6A0
        public void get_Item(){} // RVA: 0x623B750
        public void get_Sender(){} // RVA: 0x623B7C0
        public void set_Sender(){} // RVA: 0x16E1F00
        public void get_CustomData(){} // RVA: 0x623B840
        public void Reset(){} // RVA: 0x623B8D0
        public void ToString(){} // RVA: 0x623B950
    }

    public class IPhotonPeerListener
    {
        // ── Methods ──
        public void DebugReturn(){} // RVA: 0x25600
        public void OnOperationResponse(){} // RVA: 0x24B10
        public void OnStatusChanged(){} // RVA: 0x24FA0
        public void OnEvent(){} // RVA: 0x24B10
        public void OnMessage(){} // RVA: 0x25600
        public void OnDisconnectMessage(){} // RVA: 0x24B10
    }

    public class ITrafficRecorder
    {
        // ── Methods ──
        public void Record(){}
    }

    public class InvalidDataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x622EFA0
    }

    public class MessageProtocol
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x623BBD0 | overloaded x3
        public void Deserialize(){} // RVA: 0x623BEC0 | overloaded x3
        public void .cctor(){} // RVA: 0x623C1F0
    }

    public class NCommand
    {
        // ── Methods ──
        public void get_SizeOfPayload(){} // RVA: 0x6214F50
        public void get_IsFlaggedUnsequenced(){} // RVA: 0x6214F70
        public void get_IsFlaggedReliable(){} // RVA: 0x6214F80
        public void CreateAck(){} // RVA: 0x6214FA0
        public void CreateAck2(){} // RVA: 0x62151D0
        public void Initialize(){} // RVA: 0x62157A0 | overloaded x2
        public void Reset(){} // RVA: 0x6215DC0
        public void SerializeHeader(){} // RVA: 0x6215E00
        public void Serialize(){} // RVA: 0x6216290
        public void FreePayload(){} // RVA: 0x62162B0
        public void CompareTo(){} // RVA: 0x6216390
        public void ToString(){} // RVA: 0x62163D0 | overloaded x2
        public void .ctor(){} // RVA: 0x6216C30
    }

    public class NetworkSimulationSet
    {
        // ── Methods ──
        public void get_IsSimulationEnabled(){} // RVA: 0x3A75E0
        public void set_IsSimulationEnabled(){} // RVA: 0x6216C40
        public void set_OutgoingLossPercentage(){} // RVA: 0x1989FD0
        public void set_IncomingLossPercentage(){} // RVA: 0xA53440
        public void set_LostPackagesOut(){} // RVA: 0x37E0D0
        public void set_LostPackagesIn(){} // RVA: 0x1D75D90
        public void ToString(){} // RVA: 0x6217870
        public void .ctor(){} // RVA: 0x6217BC0
    }

    public class NonAllocDictionary`2
    {
        // ── Methods ──
        public void get_Keys(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0xCD60
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0xCD60
        public void get_Count(){} // RVA: 0xD840
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x24FA0
        public void ContainsKey(){} // RVA: 0x283FA0
        public void Contains(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void Add(){} // RVA: 0x283FA0 | overloaded x2
        public void Remove(){} // RVA: 0x283FA0 | overloaded x2
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0xCD60
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void FindNode(){} // RVA: 0x283FA0
        public void Insert(){} // RVA: 0x283FA0
        public void Expand(){} // RVA: 0x24A50
        public void Clear(){} // RVA: 0x24A50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x2BAA0
        public void IsPrimeFromList(){} // RVA: 0xE680
        public void GetNextPrime(){} // RVA: 0x13FF0
        public void Assert(){} // RVA: 0x24F20
        public void .cctor(){} // RVA: 0x24A80
    }

    public class OperationRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OperationResponse
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x623B270
        public void ToString(){} // RVA: 0x623B2E0
        public void ToStringFull(){} // RVA: 0x623B460
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ParameterDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6217DE0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x4EE6280
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Byte,System.Object>>.GetEnumerator(){} // RVA: 0x6217F40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6217F90
        public void GetEnumerator(){} // RVA: 0x6217FE0
        public void get_Item(){} // RVA: 0x6218090
        public void set_Item(){} // RVA: 0x6218140
        public void get_Count(){} // RVA: 0x62181B0
        public void Clear(){} // RVA: 0x6218200
        public void Add(){} // RVA: 0x6218770 | overloaded x5
        public void Get(){} // RVA: 0x283FA0
        public void ContainsKey(){} // RVA: 0x6218870
        public void TryGetValue(){} // RVA: 0x62188D0 | overloaded x2
    }

    public class PeerBase
    {
        // ── Methods ──
        public void get_Stats(){} // RVA: 0x9B8470
        public void get_Listener(){} // RVA: 0xB2E770
        public void get_LogLevel(){} // RVA: 0x1AE6E70
        public void get_ServerAddress(){} // RVA: 0x6374D0
        public void set_ServerAddress(){} // RVA: 0x30B890
        public void get_ProxyServerAddress(){} // RVA: 0x4976A0
        public void set_ProxyServerAddress(){} // RVA: 0x49B830
        public void get_peerConnectionState(){} // RVA: 0x62189D0
        public void set_peerConnectionState(){} // RVA: 0x62189E0
        public void TryUpdateConnectionState(){} // RVA: 0x62189F0
        public void get_rttVarString(){} // RVA: 0x6218A10
        public void get_TimeoutVarianceCompensation(){} // RVA: 0x6218AF0
        public void get_DisconnectTimeout(){} // RVA: 0x6218B50
        public void get_PingInterval(){} // RVA: 0x5D52520
        public void get_ChannelCount(){} // RVA: 0x6218B70
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0xD840
        public void get_timeInt(){} // RVA: 0x6218B90
        public void set_ServerFeatureFlags(){} // RVA: 0x6218BC0
        public void get_serverFeatureFlagsAvailable(){} // RVA: 0x6218C00
        public void set_serverFeatureFlagsAvailable(){} // RVA: 0x6218C10
        public void get_serverFeatureAck2Available(){} // RVA: 0x6218C20
        public void set_serverFeatureAck2Available(){} // RVA: 0x6218C30
        public void get_serverFeatureSyncReliableQueue(){} // RVA: 0x6218C40
        public void set_serverFeatureSyncReliableQueue(){} // RVA: 0x6218C50
        public void get_ServerMaxQueueableReliableCommands(){} // RVA: 0x6218C60
        public void set_ServerMaxQueueableReliableCommands(){} // RVA: 0x6218C70
        public void get_mtu(){} // RVA: 0x6218C80
        public void get_IsIpv6(){} // RVA: 0x6218CA0
        public void .ctor(){} // RVA: 0x6218CC0
        public void Reset(){} // RVA: 0x6219220
        public void Connect(){} // RVA: 0x115A0
        public void GetHttpKeyValueString(){} // RVA: 0x6219920
        public void WriteInitRequest(){} // RVA: 0x6219BC0
        public void WriteInitV3(){} // RVA: 0x621A2C0
        public void PrepareWebSocketUrl(){} // RVA: 0x621A8E0
        public void OnInitResponse(){} // RVA: 0x621AD50
        public void Disconnect(){} // RVA: 0x25130
        public void FetchServerTimestamp(){} // RVA: 0x24A50
        public void IsTransportEncrypted(){} // RVA: 0xDBE0
        public void EnqueuePhotonMessage(){}
        public void SerializeOperationToMessage(){} // RVA: 0x621ADF0
        public void SendOutgoingCommands(){} // RVA: 0xDBE0
        public void SendAcksOnly(){} // RVA: 0x2DD320
        public void ReceiveIncomingCommands(){} // RVA: 0x2BAA0
        public void DispatchIncomingCommands(){} // RVA: 0xDBE0
        public void DeserializeMessageAndCallback(){} // RVA: 0x621B0A0
        public void UpdateRoundTripTimeAndVariance(){} // RVA: 0x621BE30
        public void ExchangeKeysForEncryption(){} // RVA: 0x621BFA0
        public void DeriveSharedKey(){} // RVA: 0x621C640
        public void InitEncryption(){} // RVA: 0x621C7F0
        public void EnqueueActionForDispatch(){} // RVA: 0x621CC90
        public void EnqueueDebugReturn(){} // RVA: 0x621CE10
        public void EnqueueStatusCallback(){} // RVA: 0x621D0E0
        public void get_NetworkSimulationSettings(){} // RVA: 0x59E660
        public void NetworkSimRun(){} // RVA: 0x621D350
        public void .cctor(){} // RVA: 0x621D9F0
        public void <DeserializeMessageAndCallback>b__121_0(){} // RVA: 0x621DBD0
    }

    public class PhotonClientWebSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x621DE10
        public void Connect(){} // RVA: 0x621DE90
        public void AsyncConnectAndReceive(){} // RVA: 0x621DFC0
        public void Disconnect(){} // RVA: 0x621F240
        public void Send(){} // RVA: 0x621F5C0
        public void Receive(){} // RVA: 0x621FAC0
    }

    public class PhotonCodes
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6218940
    }

    public class PhotonHashtable
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x62088D0
        public void .ctor(){} // RVA: 0x6208B70 | overloaded x2
        public void get_Item(){} // RVA: 0x6208E50 | overloaded x3
        public void set_Item(){} // RVA: 0x6208D80 | overloaded x2
        public void Add(){} // RVA: 0x6208EE0
        public void ContainsKey(){} // RVA: 0x6208FB0
        public void GetEnumerator(){} // RVA: 0x6209070
        public void ToString(){} // RVA: 0x62091B0
    }

    public class PhotonPeer
    {
        // ── Methods ──
        public void get_ClientSdkIdShifted(){} // RVA: 0x621FB00
        public void get_Version(){} // RVA: 0x621FB10
        public void get_UseAck2(){} // RVA: 0x621FEF0
        public void set_UseAck2(){} // RVA: 0x621FF00
        public void get_SerializationProtocolType(){} // RVA: 0x197C3B0
        public void set_SerializationProtocolType(){} // RVA: 0x1989FD0
        public void get_SocketImplementation(){} // RVA: 0x30B130
        public void set_SocketImplementation(){} // RVA: 0x2DEE90
        public void get_SocketErrorCode(){} // RVA: 0x621FF10
        public void get_Listener(){} // RVA: 0x4976A0
        public void set_Listener(){} // RVA: 0x49B830
        public void get_PeerState(){} // RVA: 0x621FF40
        public void get_ReuseEventInstance(){} // RVA: 0x398C00
        public void set_ReuseEventInstance(){} // RVA: 0x621FFB0
        public void get_UseByteArraySlicePoolForEvents(){} // RVA: 0x65EEC0
        public void get_WrapIncomingStructs(){} // RVA: 0x65F560
        public void get_QuickResendAttempts(){} // RVA: 0x394D30
        public void set_QuickResendAttempts(){} // RVA: 0x6220160
        public void get_DisconnectTimeout(){} // RVA: 0xC5BE80
        public void set_DisconnectTimeout(){} // RVA: 0x6220180
        public void get_CrcEnabled(){} // RVA: 0x59FF30
        public void set_CrcEnabled(){} // RVA: 0x6220190
        public void get_ServerAddress(){} // RVA: 0x6220220
        public void get_UsedProtocol(){} // RVA: 0x6220240
        public void get_TransportProtocol(){} // RVA: 0x115A230
        public void set_TransportProtocol(){} // RVA: 0x114F200
        public void set_IsSimulationEnabled(){} // RVA: 0x6220260
        public void get_NetworkSimulationSettings(){} // RVA: 0x6220400
        public void get_MaximumTransferUnit(){} // RVA: 0x59C4F0
        public void get_IsEncryptionAvailable(){} // RVA: 0x6220430
        public void get_PayloadEncryptorType(){} // RVA: 0x4C7C50
        public void get_EncryptorType(){} // RVA: 0x31C010
        public void set_EncryptorType(){} // RVA: 0x6220460
        public void get_ServerTimeInMilliseconds(){} // RVA: 0x6220620
        public void get_EnableServerTracing(){} // RVA: 0x1B6CD50
        public void get_ConnectionTime(){} // RVA: 0x6220670
        public void get_BytesIn(){} // RVA: 0x62206A0
        public void get_BytesOut(){} // RVA: 0x62206C0
        public void get_ByteCountCurrentDispatch(){} // RVA: 0x62206E0
        public void get_ByteCountLastOperation(){} // RVA: 0x6220700
        public void get_PacketLossByCrc(){} // RVA: 0x6220720
        public void get_PacketLossByChallenge(){} // RVA: 0x6220740
        public void get_CountDiscarded(){} // RVA: 0x3C49C00
        public void set_CountDiscarded(){} // RVA: 0x3C49C10
        public void set_DeltaUnreliableNumber(){} // RVA: 0xCC9310
        public void get_QueuedOutgoingCommands(){} // RVA: 0x6220760
        public void get_Stats(){} // RVA: 0x348040
        public void set_Stats(){} // RVA: 0x348050
        public void .ctor(){} // RVA: 0x6220E20 | overloaded x2
        public void Connect(){} // RVA: 0x6220EA0
        public void CreatePeerBase(){} // RVA: 0x6221BA0
        public void Disconnect(){} // RVA: 0x6221DC0
        public void FetchServerTimestamp(){} // RVA: 0x6222080
        public void EstablishEncryption(){} // RVA: 0x62220B0
        public void InitDatagramEncryption(){} // RVA: 0x6222190
        public void InitPayloadEncryption(){} // RVA: 0x464450
        public void Service(){} // RVA: 0x62225E0
        public void SendOutgoingCommands(){} // RVA: 0x6222630
        public void SendAcksOnly(){} // RVA: 0x6222810
        public void DispatchIncomingCommands(){} // RVA: 0x6222980
        public void SendOperation(){} // RVA: 0x6222B70
        public void RegisterType(){} // RVA: 0x6223000
        public void .cctor(){} // RVA: 0x6223090
        public void <EstablishEncryption>b__202_0(){} // RVA: 0x62230F0
    }

    public class PhotonSocket
    {
        // ── Methods ──
        public void get_Listener(){} // RVA: 0x6223120
        public void get_MTU(){} // RVA: 0x6223150
        public void get_State(){} // RVA: 0x197C3B0
        public void set_State(){} // RVA: 0x1989FD0
        public void get_SocketErrorCode(){} // RVA: 0x760030
        public void set_SocketErrorCode(){} // RVA: 0x99E0D0
        public void get_Connected(){} // RVA: 0x6223180
        public void get_LogLevel(){} // RVA: 0x6223190
        public void get_ServerAddress(){} // RVA: 0x6374D0
        public void set_ServerAddress(){} // RVA: 0x30B890
        public void get_ProxyServerAddress(){} // RVA: 0x4976A0
        public void set_ProxyServerAddress(){} // RVA: 0x49B830
        public void set_ServerIpAddress(){} // RVA: 0x305200
        public void get_ServerPort(){} // RVA: 0x37E0C0
        public void set_ServerPort(){} // RVA: 0x37E0D0
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x16DA880
        public void set_AddressResolvedAsIpv6(){} // RVA: 0x16E0A80
        public void set_UrlProtocol(){} // RVA: 0x4354D0
        public void set_UrlPath(){} // RVA: 0x3A5510
        public void get_SerializationProtocol(){} // RVA: 0x62231C0
        public void .ctor(){} // RVA: 0x6223380
        public void Connect(){} // RVA: 0x62234C0
        public void Disconnect(){} // RVA: 0xDBE0
        public void Send(){}
        public void Receive(){} // RVA: 0x12590
        public void HandleReceivedDatagram(){} // RVA: 0x6223870
        public void ReportDebugOfLevel(){} // RVA: 0x62238A0
        public void EnqueueDebugReturn(){} // RVA: 0x62238D0
        public void HandleException(){} // RVA: 0x62238F0
        public void TryParseAddress(){} // RVA: 0x62239A0
        public void IpAddressTryParse(){} // RVA: 0x6223E90
        public void GetIpAddresses(){} // RVA: 0x6224150
        public void AddressSortComparer(){} // RVA: 0x6224910
        public void <HandleException>b__58_0(){} // RVA: 0x6224970
    }

    public class Pool`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void CreatePoolItems(){} // RVA: 0x24FA0
        public void Release(){} // RVA: 0x283FA0
        public void Acquire(){} // RVA: 0x283FA0
    }

    public class PreserveAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Protocol
    {
        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0xCD60
        public void get_VersionBytes(){} // RVA: 0xCD60
        public void Serialize(){} // RVA: 0x6224EA0 | overloaded x2
        public void SerializeShort(){}
        public void SerializeString(){}
        public void SerializeEventData(){}
        public void SerializeOperationRequest(){}
        public void SerializeOperationResponse(){}
        public void Deserialize(){} // RVA: 0x6224F40 | overloaded x2
        public void DeserializeShort(){} // RVA: 0x134B0
        public void DeserializeByte(){} // RVA: 0xDE40
        public void DeserializeEventData(){}
        public void DeserializeOperationRequest(){} // RVA: 0x1DD80
        public void DeserializeOperationResponse(){} // RVA: 0x1DD80
        public void DeserializeDisconnectMessage(){} // RVA: 0xCE10
        public void DeserializeMessage(){} // RVA: 0x6225030
        public void TryRegisterType(){} // RVA: 0x6225090
        public void .ctor(){} // RVA: 0x6225400
        public void .cctor(){} // RVA: 0x62254A0
    }

    public class Protocol16
    {
        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x6225640
        public void get_VersionBytes(){} // RVA: 0x2E07C0
        public void SerializeCustom(){} // RVA: 0x6225680
        public void DeserializeCustom(){} // RVA: 0x6225A50
        public void GetTypeOfCode(){} // RVA: 0x6225D80
        public void GetCodeOfType(){} // RVA: 0x6226100
        public void CreateArrayByType(){} // RVA: 0x62264A0
        public void SerializeOperationRequest(){} // RVA: 0x6226510 | overloaded x2
        public void DeserializeOperationRequest(){} // RVA: 0x62265F0
        public void SerializeOperationResponse(){} // RVA: 0x62266E0
        public void DeserializeDisconnectMessage(){} // RVA: 0x6226870
        public void DeserializeOperationResponse(){} // RVA: 0x6226A40
        public void SerializeEventData(){} // RVA: 0x6226C30
        public void DeserializeEventData(){} // RVA: 0x6226D10
        public void SerializeParameterTable(){} // RVA: 0x6226DD0
        public void DeserializeParameterDictionary(){} // RVA: 0x6227160
        public void Serialize(){} // RVA: 0x6227290
        public void SerializeByte(){} // RVA: 0x6227EC0
        public void SerializeBoolean(){} // RVA: 0x6227F70
        public void SerializeShort(){} // RVA: 0x6228020
        public void SerializeLengthAsShort(){} // RVA: 0x6228270
        public void SerializeInteger(){} // RVA: 0x62284C0
        public void SerializeLong(){} // RVA: 0x6228730
        public void SerializeFloat(){} // RVA: 0x6228BE0
        public void SerializeDouble(){} // RVA: 0x6229150
        public void SerializeString(){} // RVA: 0x6229610
        public void SerializeArray(){} // RVA: 0x62297F0
        public void SerializeByteArray(){} // RVA: 0x6229ED0
        public void SerializeByteArraySegment(){} // RVA: 0x6229F90
        public void SerializeIntArrayOptimized(){} // RVA: 0x622A070
        public void SerializeObjectArray(){} // RVA: 0x622A2D0
        public void SerializeHashTable(){} // RVA: 0x622A520
        public void SerializeDictionary(){} // RVA: 0x622A880
        public void SerializeDictionaryHeader(){} // RVA: 0x622A980 | overloaded x2
        public void SerializeDictionaryElements(){} // RVA: 0x622ADC0
        public void Deserialize(){} // RVA: 0x622B120
        public void DeserializeByte(){} // RVA: 0x622BA50
        public void DeserializeBoolean(){} // RVA: 0x622BA70
        public void DeserializeShort(){} // RVA: 0x622BAA0
        public void DeserializeInteger(){} // RVA: 0x622BE50
        public void DeserializeLong(){} // RVA: 0x622C220
        public void DeserializeFloat(){} // RVA: 0x622C660
        public void DeserializeDouble(){} // RVA: 0x622CAA0
        public void DeserializeString(){} // RVA: 0x622CF70
        public void DeserializeArray(){} // RVA: 0x622D0D0
        public void DeserializeByteArray(){} // RVA: 0x622DAF0
        public void DeserializeIntArray(){} // RVA: 0x622DBB0
        public void DeserializeStringArray(){} // RVA: 0x622DC70
        public void DeserializeObjectArray(){} // RVA: 0x622DD80
        public void DeserializeHashTable(){} // RVA: 0x622DF00
        public void DeserializeDictionary(){} // RVA: 0x622E070
        public void DeserializeDictionaryArray(){} // RVA: 0x622E450
        public void DeserializeDictionaryType(){} // RVA: 0x622E700
        public void .ctor(){} // RVA: 0x622E9D0
        public void .cctor(){} // RVA: 0x622EE50
    }

    public class Protocol18
    {
        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x622F000
        public void get_VersionBytes(){} // RVA: 0x2E07C0
        public void Serialize(){} // RVA: 0x622F040
        public void SerializeShort(){} // RVA: 0x622F0C0
        public void SerializeString(){} // RVA: 0x622F130
        public void Deserialize(){} // RVA: 0x622F140
        public void DeserializeShort(){} // RVA: 0x622F160
        public void DeserializeByte(){} // RVA: 0x622BA50
        public void GetAllowedDictionaryKeyTypes(){} // RVA: 0x622F1E0
        public void GetClrArrayType(){} // RVA: 0x622F3D0
        public void GetCodeOfType(){} // RVA: 0x622F730
        public void GetCodeOfTypeCode(){} // RVA: 0x622FF50
        public void Read(){} // RVA: 0x6230040 | overloaded x2
        public void ReadBoolean(){} // RVA: 0x622BA70
        public void ReadByte(){} // RVA: 0x622BA50
        public void ReadInt16(){} // RVA: 0x622F160
        public void ReadUShort(){} // RVA: 0x622F160
        public void ReadSingle(){} // RVA: 0x62312F0
        public void ReadDouble(){} // RVA: 0x6231390
        public void ReadNonAllocByteArray(){} // RVA: 0x6231430
        public void ReadByteArray(){} // RVA: 0x62314D0
        public void ReadCustomType(){} // RVA: 0x6231580
        public void DeserializeEventData(){} // RVA: 0x6231940
        public void ReadParameterDictionary(){} // RVA: 0x6231B80
        public void ReadHashtable(){} // RVA: 0x6231CB0
        public void DeserializeOperationRequest(){} // RVA: 0x6231EA0
        public void DeserializeOperationResponse(){} // RVA: 0x6231F90
        public void DeserializeDisconnectMessage(){} // RVA: 0x62321A0
        public void ReadString(){} // RVA: 0x6232380
        public void ReadCustomTypeArray(){} // RVA: 0x6232460
        public void ReadDictionaryType(){} // RVA: 0x6232D00 | overloaded x2
        public void GetDictArrayType(){} // RVA: 0x6232FB0
        public void ReadDictionary(){} // RVA: 0x62330B0
        public void ReadDictionaryElements(){} // RVA: 0x62332E0
        public void ReadObjectArray(){} // RVA: 0x6233460
        public void ReadBooleanArray(){} // RVA: 0x62335D0
        public void ReadInt16Array(){} // RVA: 0x6233810
        public void ReadSingleArray(){} // RVA: 0x6233910
        public void ReadDoubleArray(){} // RVA: 0x62339D0
        public void ReadStringArray(){} // RVA: 0x6233A90
        public void ReadHashtableArray(){} // RVA: 0x6233B90
        public void ReadDictionaryArray(){} // RVA: 0x6233D20
        public void ReadArrayInArray(){} // RVA: 0x62340B0
        public void ReadInt1(){} // RVA: 0x6234250
        public void ReadInt2(){} // RVA: 0x6234290
        public void ReadCompressedInt32(){} // RVA: 0x6234350
        public void ReadCompressedUInt32(){} // RVA: 0x6234370
        public void ReadCompressedInt64(){} // RVA: 0x6234610
        public void ReadCompressedUInt64(){} // RVA: 0x62346F0
        public void ReadCompressedInt32Array(){} // RVA: 0x62347C0
        public void ReadCompressedInt64Array(){} // RVA: 0x6234880
        public void DecodeZigZag32(){} // RVA: 0x6234930
        public void DecodeZigZag64(){} // RVA: 0x6234940
        public void Write(){} // RVA: 0x6234950 | overloaded x2
        public void SerializeEventData(){} // RVA: 0x6235F90
        public void WriteParameterTable(){} // RVA: 0x6236070
        public void SerializeOperationRequest(){} // RVA: 0x6236470 | overloaded x2
        public void SerializeOperationResponse(){} // RVA: 0x6236550
        public void WriteByte(){} // RVA: 0x6236700
        public void WriteBoolean(){} // RVA: 0x6236790
        public void WriteUShort(){} // RVA: 0x6236830
        public void WriteInt16(){} // RVA: 0x622F0C0
        public void WriteDouble(){} // RVA: 0x6236860
        public void WriteSingle(){} // RVA: 0x6236C10
        public void WriteString(){} // RVA: 0x6236FC0
        public void WriteHashtable(){} // RVA: 0x6237170
        public void WriteByteArray(){} // RVA: 0x6237480
        public void WriteArraySegmentByte(){} // RVA: 0x6237530
        public void WriteByteArraySlice(){} // RVA: 0x6237680
        public void WriteInt32ArrayCompressed(){} // RVA: 0x6237760
        public void WriteInt64ArrayCompressed(){} // RVA: 0x6237830
        public void WriteBoolArray(){} // RVA: 0x6237910
        public void WriteInt16Array(){} // RVA: 0x6237C00
        public void WriteSingleArray(){} // RVA: 0x6237CD0
        public void WriteDoubleArray(){} // RVA: 0x6237DC0
        public void WriteStringArray(){} // RVA: 0x6237EB0
        public void WriteObjectArray(){} // RVA: 0x6238070
        public void WriteArrayInArray(){} // RVA: 0x6238290
        public void WriteCustomTypeBody(){} // RVA: 0x62383C0
        public void WriteCustomType(){} // RVA: 0x6238660
        public void WriteCustomTypeArray(){} // RVA: 0x6238B40
        public void WriteArrayHeader(){} // RVA: 0x62391D0
        public void WriteDictionaryElements(){} // RVA: 0x6239330
        public void WriteDictionary(){} // RVA: 0x6239600
        public void WriteDictionaryHeader(){} // RVA: 0x6239740
        public void WriteArrayType(){} // RVA: 0x6239F00
        public void WriteHashtableArray(){} // RVA: 0x623A3D0
        public void WriteDictionaryArray(){} // RVA: 0x623A520
        public void WriteIntLength(){} // RVA: 0x623A660
        public void WriteCompressedInt32(){} // RVA: 0x623A670
        public void WriteCompressedInt64(){} // RVA: 0x623A820
        public void WriteCompressedUInt32(){} // RVA: 0x623ABC0 | overloaded x2
        public void WriteCompressedUInt64(){} // RVA: 0x623AC30
        public void EncodeZigZag32(){} // RVA: 0x623AE70
        public void EncodeZigZag64(){} // RVA: 0x623AE80
        public void .ctor(){} // RVA: 0x623AE90
        public void .cctor(){} // RVA: 0x623B190
    }

    public class SendOptions
    {
        // ── Methods ──
        public void get_Reliability(){} // RVA: 0x623C340
        public void set_Reliability(){} // RVA: 0x623C350
        public void .cctor(){} // RVA: 0x623C360
    }

    public class SerializationProtocolFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x6224B80
    }

    public class SerializeStreamMethod
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33AFC70
        public void Invoke(){} // RVA: 0x439370
    }

    public class SimulationItem
    {
        // ── Methods ──
        public void get_Delay(){} // RVA: 0x791DC0
    }

    public class SocketTcp
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x623C3D0
        public void Finalize(){} // RVA: 0x623C4F0
        public void Dispose(){} // RVA: 0x623C530
        public void Connect(){} // RVA: 0x623C640
        public void Disconnect(){} // RVA: 0x623C8E0
        public void Send(){} // RVA: 0x623CB40
        public void Receive(){} // RVA: 0x1A825D0
        public void DnsAndConnect(){} // RVA: 0x623CE30
        public void ReceiveLoop(){} // RVA: 0x623D560
    }

    public class SocketTcpAsync
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x623DF60
        public void Finalize(){} // RVA: 0x623E080
        public void Dispose(){} // RVA: 0x623E0C0
        public void Connect(){} // RVA: 0x623E1E0
        public void Disconnect(){} // RVA: 0x623E480
        public void Send(){} // RVA: 0x623E710
        public void Receive(){} // RVA: 0x1A825D0
        public void DnsAndConnect(){} // RVA: 0x623EC40
        public void ReceiveAsync(){} // RVA: 0x623F750 | overloaded x2
    }

    public class SocketUdp
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x623FF60
        public void Finalize(){} // RVA: 0x62400F0
        public void Dispose(){} // RVA: 0x6240130
        public void Connect(){} // RVA: 0x6240250
        public void Disconnect(){} // RVA: 0x62404F0
        public void Send(){} // RVA: 0x6240780
        public void Receive(){} // RVA: 0x1A825D0
        public void DnsAndConnect(){} // RVA: 0x6241300
        public void ReceiveLoop(){} // RVA: 0x6241970
    }

    public class SocketUdpAsync
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6242090
        public void Finalize(){} // RVA: 0x623E080
        public void Dispose(){} // RVA: 0x623E0C0
        public void Connect(){} // RVA: 0x62421B0
        public void Disconnect(){} // RVA: 0x6242450
        public void Send(){} // RVA: 0x62426E0
        public void Receive(){} // RVA: 0x1A825D0
        public void DnsAndConnect(){} // RVA: 0x6242C40
        public void StartReceive(){} // RVA: 0x62431B0
        public void OnReceive(){} // RVA: 0x6243430
    }

    public class StreamBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6243E20 | overloaded x2
        public void ToArray(){} // RVA: 0x6243E90
        public void Compact(){} // RVA: 0x6243F00
        public void GetBuffer(){} // RVA: 0x2E07C0
        public void GetBufferAndAdvance(){} // RVA: 0x6243F80
        public void get_Length(){} // RVA: 0x8ABED0
        public void get_Position(){} // RVA: 0x32A5C0
        public void set_Position(){} // RVA: 0x6243FC0
        public void get_Available(){} // RVA: 0x6243FE0
        public void Reset(){} // RVA: 0x6243FF0
        public void Seek(){} // RVA: 0x6244000
        public void SetLength(){} // RVA: 0x6244120
        public void SetCapacityMinimum(){} // RVA: 0x6244150
        public void Read(){} // RVA: 0x6244160
        public void Write(){} // RVA: 0x62441C0
        public void ReadByte(){} // RVA: 0x6244240
        public void WriteByte(){} // RVA: 0x6244330
        public void WriteBytes(){} // RVA: 0x6244390
        public void CheckSize(){} // RVA: 0x6244420
    }

    public class SupportClass
    {
        // ── Methods ──
        public void WriteStackTrace(){} // RVA: 0x6244530
        public void DictionaryToString(){} // RVA: 0x62450D0 | overloaded x2
        public void ByteArrayToString(){} // RVA: 0x6245C00
        public void InitializeTable(){} // RVA: 0x6245C80
        public void CalculateCrc(){} // RVA: 0x6245FB0 | overloaded x2
    }

    public class TPeer
    {
        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x6246290
        public void .ctor(){} // RVA: 0x62462E0
        public void IsTransportEncrypted(){} // RVA: 0x6246510
        public void Reset(){} // RVA: 0x6246520
        public void Connect(){} // RVA: 0x62466B0
        public void Disconnect(){} // RVA: 0x6246B10 | overloaded x2
        public void FetchServerTimestamp(){} // RVA: 0x6246DC0
        public void EnqueueInit(){} // RVA: 0x6246F00
        public void DispatchIncomingCommands(){} // RVA: 0x62470A0
        public void SendOutgoingCommands(){} // RVA: 0x62475E0
        public void SendAcksOnly(){} // RVA: 0x6247AB0
        public void EnqueuePhotonMessage(){} // RVA: 0x6247B20
        public void EnqueueMessageAsPayload(){} // RVA: 0x6247B50
        public void SendPing(){} // RVA: 0x6247EB0
        public void SendData(){} // RVA: 0x6248460
        public void ReceiveIncomingCommands(){} // RVA: 0x62485F0
        public void ReadPingResult(){} // RVA: 0x6248C90 | overloaded x2
        public void .cctor(){} // RVA: 0x6248DE0
    }

    public class TrafficStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37B380
        public void get_LastReceiveTimestamp(){} // RVA: 0x10E5CF0
        public void set_LastReceiveTimestamp(){} // RVA: 0x475080
        public void get_LastDispatchTimestamp(){} // RVA: 0x1929080
        public void set_LastDispatchTimestamp(){} // RVA: 0x1D8D640
        public void get_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x1AE3800
        public void set_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x1AE6D80
        public void set_LastDispatchDuration(){} // RVA: 0x6248F70
        public void get_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0xFC4570
        public void set_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0xFC4560
        public void DispatchIncomingCommandsCalled(){} // RVA: 0x6248F80
        public void SendOutgoingCommandsCalled(){} // RVA: 0x6248FA0
        public void ToString(){} // RVA: 0x6248FD0 | overloaded x2
    }

    public class TrafficStatsBase
    {
        // ── Methods ──
        public void get_BytesIn(){} // RVA: 0x2F8380
        public void set_BytesIn(){} // RVA: 0x1967700
        public void get_BytesOut(){} // RVA: 0x2E07C0
        public void set_BytesOut(){} // RVA: 0xC5BE60
        public void get_PackagesIn(){} // RVA: 0x760030
        public void set_PackagesIn(){} // RVA: 0x99E0D0
        public void get_PackagesOut(){} // RVA: 0xCEF5B0
        public void set_PackagesOut(){} // RVA: 0x16E1F00
        public void get_UdpFragmentsIn(){} // RVA: 0x791DC0
        public void set_UdpFragmentsIn(){} // RVA: 0xA53440
        public void get_UdpFragmentsOut(){} // RVA: 0x1209F00
        public void set_UdpFragmentsOut(){} // RVA: 0x1AFCF60
        public void get_UdpUnreliableCommandsSent(){} // RVA: 0x338CD0
        public void set_UdpUnreliableCommandsSent(){} // RVA: 0x338CE0
        public void get_UdpReliableCommandsSent(){} // RVA: 0x4C6670
        public void set_UdpReliableCommandsSent(){} // RVA: 0x4C5F20
        public void get_UdpReliableCommandsResent(){} // RVA: 0xFDC9F0
        public void set_UdpReliableCommandsResent(){} // RVA: 0xFDD6E0
        public void set_UdpReliableCommandsInFlight(){} // RVA: 0x1CB95F0
        public void get_DispatchIncomingCommandsCalls(){} // RVA: 0x37E080
        public void set_DispatchIncomingCommandsCalls(){} // RVA: 0x37E090
        public void get_SendOutgoingCommandsCalls(){} // RVA: 0x37E0A0
        public void set_SendOutgoingCommandsCalls(){} // RVA: 0x37E0B0
        public void get_RoundtripTime(){} // RVA: 0x358730
        public void set_RoundtripTime(){} // RVA: 0x179D760
        public void get_RoundtripTimeVariance(){} // RVA: 0x37E0E0
        public void set_RoundtripTimeVariance(){} // RVA: 0x4C4D50
        public void set_LastRoundtripTime(){} // RVA: 0x4C34E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UnknownType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Version
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6249710
    }

}