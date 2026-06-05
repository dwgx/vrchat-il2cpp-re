// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client
// Classes: 50
// Methods: 726

namespace ThirdParty.Photon.Photon.Client
{
    public class ByteArraySlice
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CB7A20
        public void Dispose(){} // RVA: 0x7FFAF8CB7B50
        public void Release(){} // RVA: 0x7FFAF8CB7B90
    }

    public class ByteArraySlicePool
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CB7BD0
        public void Acquire(){} // RVA: 0x7FFAF8CB7E20
        public void PopOrCreate(){} // RVA: 0x7FFAF8CB8270
        public void Release(){} // RVA: 0x7FFAF8CB8590
    }

    public class CustomType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CD4D90
    }

    public class DeserializeStreamMethod
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CD4C10
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
    }

    public class DictionaryEntryEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5328D50
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAF8CB97A0
        public void get_Current(){} // RVA: 0x7FFAF8CB98F0
        public void MoveNext(){} // RVA: 0x7FFAF8CB9980
        public void Reset(){} // RVA: 0x7FFAF8CB99C0
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
    }

    public class DisconnectMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class EnetChannel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CB9A90
        public void AddSequencedIfNew(){} // RVA: 0x7FFAF8CB9F60
        public void TryGetFragment(){} // RVA: 0x7FFAF8CBA030
        public void RemoveFragment(){} // RVA: 0x7FFAF8CBA0B0
        public void clearAll(){} // RVA: 0x7FFAF8CBA120
        public void QueueIncomingReliableUnsequenced(){} // RVA: 0x7FFAF8CBA460
        public void ApplySequenceNumberModifier(){} // RVA: 0x7FFAF8CBA7A0
        public void Received(){} // RVA: 0x7FFAF8CBA7F0
        public void GetGapBlock(){} // RVA: 0x7FFAF8CBAAA0
    }

    public class EnetPeer
    {
        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7FFAF8CBAED0
        public void get_SendWindowUpdateRequired(){} // RVA: 0x7FFAF8CBB1F0
        public void set_SendWindowUpdateRequired(){} // RVA: 0x7FFAF8CBB210
        public void get_DatagramEncryptedConnection(){} // RVA: 0x7FFAF8CBB230
        public void set_DatagramEncryptedConnection(){} // RVA: 0x7FFAF8CBB250
        public void get_useAck2(){} // RVA: 0x7FFAF8CBB270
        public void .ctor(){} // RVA: 0x7FFAF8CBB2A0
        public void IsTransportEncrypted(){} // RVA: 0x7FFAF8CBB230
        public void Reset(){} // RVA: 0x7FFAF8CBBC30
        public void ApplyRandomizedSequenceNumbers(){} // RVA: 0x7FFAF8CBC4A0
        public void GetChannel(){} // RVA: 0x7FFAF8CBC6C0
        public void Connect(){} // RVA: 0x7FFAF8CBC720
        public void Disconnect(){} // RVA: 0x7FFAF8CBC7F0
        public void FetchServerTimestamp(){} // RVA: 0x7FFAF8CBCD30
        public void DispatchCommandQueue(){} // RVA: 0x7FFAF8CBCE50
        public void DispatchIncomingCommands(){} // RVA: 0x7FFAF8CBCF30
        public void GetFragmentLength(){} // RVA: 0x7FFAF8CBDAC0
        public void CalculatePacketSize(){} // RVA: 0x7FFAF8CBDBA0
        public void CalculateInitialOffset(){} // RVA: 0x7FFAF8CBDC30
        public void SendAcksOnly(){} // RVA: 0x7FFAF8CBDC80
        public void SendOutgoingCommands(){} // RVA: 0x7FFAF8CBDCA0 | overloaded x2
        public void UpdateSendWindow(){} // RVA: 0x7FFAF8CBEDA0
        public void EnqueuePhotonMessage(){} // RVA: 0x7FFAF8CBF7E0
        public void CreateAndEnqueueCommand(){} // RVA: 0x7FFAF8CBF830
        public void SerializeAckToBuffer(){} // RVA: 0x7FFAF8CBFE20
        public void SerializeToBuffer(){} // RVA: 0x7FFAF8CC0320
        public void SerializeCommandToBuffer(){} // RVA: 0x7FFAF8CC0470
        public void SendData(){} // RVA: 0x7FFAF8CC0650
        public void SendToSocket(){} // RVA: 0x7FFAF8CC09C0
        public void SendDataEncrypted(){} // RVA: 0x7FFAF8CC0B30
        public void QueueSentCommand(){} // RVA: 0x7FFAF8CC0E40
        public void QueueOutgoingReliableCommand(){} // RVA: 0x7FFAF8CC11E0
        public void QueueOutgoingUnreliableCommand(){} // RVA: 0x7FFAF8CC1410
        public void QueueOutgoingAcknowledgement(){} // RVA: 0x7FFAF8CC16B0
        public void ReceiveIncomingCommands(){} // RVA: 0x7FFAF8CC1BB0
        public void ExecuteCommand(){} // RVA: 0x7FFAF8CC2770
        public void QueueIncomingCommand(){} // RVA: 0x7FFAF8CC3F70
        public void RemoveSentReliableCommand(){} // RVA: 0x7FFAF8CC4870
        public void .cctor(){} // RVA: 0x7FFAF8CC4D10
        public void <ExecuteCommand>b__78_0(){} // RVA: 0x7FFAF8CC4DF0
    }

    public class EventData
    {
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CEB6A0
        public void get_Item(){} // RVA: 0x7FFAF8CEB750
        public void get_Sender(){} // RVA: 0x7FFAF8CEB7C0
        public void set_Sender(){} // RVA: 0x7FFAF4191F00
        public void get_CustomData(){} // RVA: 0x7FFAF8CEB840
        public void Reset(){} // RVA: 0x7FFAF8CEB8D0
        public void ToString(){} // RVA: 0x7FFAF8CEB950
    }

    public class IPhotonPeerListener
    {
        // ── Methods ──
        public void DebugReturn(){} // RVA: 0x7FFAF2AD5600
        public void OnOperationResponse(){} // RVA: 0x7FFAF2AD4B10
        public void OnStatusChanged(){} // RVA: 0x7FFAF2AD4FA0
        public void OnEvent(){} // RVA: 0x7FFAF2AD4B10
        public void OnMessage(){} // RVA: 0x7FFAF2AD5600
        public void OnDisconnectMessage(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ITrafficRecorder
    {
        // ── Methods ──
        public void Record(){}
    }

    public class InvalidDataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CDEFA0
    }

    public class MessageProtocol
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF8CEBBD0 | overloaded x3
        public void Deserialize(){} // RVA: 0x7FFAF8CEBEC0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAF8CEC1F0
    }

    public class NCommand
    {
        // ── Methods ──
        public void get_SizeOfPayload(){} // RVA: 0x7FFAF8CC4F50
        public void get_IsFlaggedUnsequenced(){} // RVA: 0x7FFAF8CC4F70
        public void get_IsFlaggedReliable(){} // RVA: 0x7FFAF8CC4F80
        public void CreateAck(){} // RVA: 0x7FFAF8CC4FA0
        public void CreateAck2(){} // RVA: 0x7FFAF8CC51D0
        public void Initialize(){} // RVA: 0x7FFAF8CC57A0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAF8CC5DC0
        public void SerializeHeader(){} // RVA: 0x7FFAF8CC5E00
        public void Serialize(){} // RVA: 0x7FFAF8CC6290
        public void FreePayload(){} // RVA: 0x7FFAF8CC62B0
        public void CompareTo(){} // RVA: 0x7FFAF8CC6390
        public void ToString(){} // RVA: 0x7FFAF8CC63D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF8CC6C30
    }

    public class NetworkSimulationSet
    {
        // ── Methods ──
        public void get_IsSimulationEnabled(){} // RVA: 0x7FFAF2E575E0
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFAF8CC6C40
        public void set_OutgoingLossPercentage(){} // RVA: 0x7FFAF4439FD0
        public void set_IncomingLossPercentage(){} // RVA: 0x7FFAF3503440
        public void set_LostPackagesOut(){} // RVA: 0x7FFAF2E2E0D0
        public void set_LostPackagesIn(){} // RVA: 0x7FFAF4825D90
        public void ToString(){} // RVA: 0x7FFAF8CC7870
        public void .ctor(){} // RVA: 0x7FFAF8CC7BC0
    }

    public class NonAllocDictionary`2
    {
        // ── Methods ──
        public void get_Keys(){} // RVA: 0x7FFAF2D33FA0
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0x7FFAF2ABCD60
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2ABDBE0
        public void .ctor(){} // RVA: 0x7FFAF2AD4FA0
        public void ContainsKey(){} // RVA: 0x7FFAF2D33FA0
        public void Contains(){} // RVA: 0x7FFAF2D33FA0
        public void TryGetValue(){} // RVA: 0x7FFAF2D33FA0
        public void get_Item(){} // RVA: 0x7FFAF2D33FA0
        public void set_Item(){} // RVA: 0x7FFAF2D33FA0
        public void Add(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void Remove(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void GetEnumerator(){} // RVA: 0x7FFAF2D33FA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void FindNode(){} // RVA: 0x7FFAF2D33FA0
        public void Insert(){} // RVA: 0x7FFAF2D33FA0
        public void Expand(){} // RVA: 0x7FFAF2AD4A50
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void IsPrimeFromList(){} // RVA: 0x7FFAF2ABE680
        public void GetNextPrime(){} // RVA: 0x7FFAF2AC3FF0
        public void Assert(){} // RVA: 0x7FFAF2AD4F20
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
    }

    public class NonAllocDictionary`2
    {
        // ── Methods ──
        public void get_Keys(){} // RVA: 0x7FFAF674A8B0
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0x7FFAF2E0A740
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0x7FFAF2F476A0
        public void get_Count(){} // RVA: 0x7FFAF674A910
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2DB3450
        public void .ctor(){} // RVA: 0x7FFAF674A920
        public void ContainsKey(){} // RVA: 0x7FFAF674AB20
        public void Contains(){} // RVA: 0x7FFAF674AB40
        public void TryGetValue(){} // RVA: 0x7FFAF674ABF0
        public void get_Item(){} // RVA: 0x7FFAF674AC90
        public void set_Item(){} // RVA: 0x7FFAF674AD70
        public void Add(){} // RVA: 0x7FFAF674AFF0 | overloaded x2
        public void Remove(){} // RVA: 0x7FFAF674B260 | overloaded x2
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x7FFAF674B340
        public void GetEnumerator(){} // RVA: 0x7FFAF674A8B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF674B340
        public void FindNode(){} // RVA: 0x7FFAF674B3D0
        public void Insert(){} // RVA: 0x7FFAF674B460
        public void Expand(){} // RVA: 0x7FFAF674B650
        public void Clear(){} // RVA: 0x7FFAF674BA10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x7FFAF674BA70
        public void IsPrimeFromList(){} // RVA: 0x7FFAF674BC60
        public void GetNextPrime(){} // RVA: 0x7FFAF674BDE0
        public void Assert(){} // RVA: 0x7FFAF674C0D0
        public void .cctor(){} // RVA: 0x7FFAF674C130
    }

    public class NonAllocDictionary`2
    {
        // ── Methods ──
        public void get_Keys(){} // RVA: 0x7FFAF674A8B0
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0x7FFAF2E0A740
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0x7FFAF2F476A0
        public void get_Count(){} // RVA: 0x7FFAF674A910
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2DB3450
        public void .ctor(){} // RVA: 0x7FFAF674C260
        public void ContainsKey(){} // RVA: 0x7FFAF674C460
        public void Contains(){} // RVA: 0x7FFAF674C480
        public void TryGetValue(){} // RVA: 0x7FFAF674C520
        public void get_Item(){} // RVA: 0x7FFAF674C5C0
        public void set_Item(){} // RVA: 0x7FFAF674C6A0
        public void Add(){} // RVA: 0x7FFAF674C920 | overloaded x2
        public void Remove(){} // RVA: 0x7FFAF674CB80 | overloaded x2
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x7FFAF674B340
        public void GetEnumerator(){} // RVA: 0x7FFAF674A8B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF674B340
        public void FindNode(){} // RVA: 0x7FFAF674CC60
        public void Insert(){} // RVA: 0x7FFAF674CCF0
        public void Expand(){} // RVA: 0x7FFAF674CEE0
        public void Clear(){} // RVA: 0x7FFAF674BA10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x7FFAF674D2A0
        public void IsPrimeFromList(){} // RVA: 0x7FFAF674BC60
        public void GetNextPrime(){} // RVA: 0x7FFAF674BDE0
        public void Assert(){} // RVA: 0x7FFAF674C0D0
        public void .cctor(){} // RVA: 0x7FFAF674D490
    }

    public class OperationRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class OperationResponse
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAF8CEB270
        public void ToString(){} // RVA: 0x7FFAF8CEB2E0
        public void ToStringFull(){} // RVA: 0x7FFAF8CEB460
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ParameterDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CC7DE0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAF7996280
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Byte,System.Object>>.GetEnumerator(){} // RVA: 0x7FFAF8CC7F40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF8CC7F90
        public void GetEnumerator(){} // RVA: 0x7FFAF8CC7FE0
        public void get_Item(){} // RVA: 0x7FFAF8CC8090
        public void set_Item(){} // RVA: 0x7FFAF8CC8140
        public void get_Count(){} // RVA: 0x7FFAF8CC81B0
        public void Clear(){} // RVA: 0x7FFAF8CC8200
        public void Add(){} // RVA: 0x7FFAF8CC8770 | overloaded x5
        public void Get(){} // RVA: 0x7FFAF2D33FA0
        public void ContainsKey(){} // RVA: 0x7FFAF8CC8870
        public void TryGetValue(){} // RVA: 0x7FFAF8CC88D0 | overloaded x2
    }

    public class PeerBase
    {
        // ── Methods ──
        public void get_Stats(){} // RVA: 0x7FFAF3468470
        public void get_Listener(){} // RVA: 0x7FFAF35DE770
        public void get_LogLevel(){} // RVA: 0x7FFAF4596E70
        public void get_ServerAddress(){} // RVA: 0x7FFAF30E74D0
        public void set_ServerAddress(){} // RVA: 0x7FFAF2DBB890
        public void get_ProxyServerAddress(){} // RVA: 0x7FFAF2F476A0
        public void set_ProxyServerAddress(){} // RVA: 0x7FFAF2F4B830
        public void get_peerConnectionState(){} // RVA: 0x7FFAF8CC89D0
        public void set_peerConnectionState(){} // RVA: 0x7FFAF8CC89E0
        public void TryUpdateConnectionState(){} // RVA: 0x7FFAF8CC89F0
        public void get_rttVarString(){} // RVA: 0x7FFAF8CC8A10
        public void get_TimeoutVarianceCompensation(){} // RVA: 0x7FFAF8CC8AF0
        public void get_DisconnectTimeout(){} // RVA: 0x7FFAF8CC8B50
        public void get_PingInterval(){} // RVA: 0x7FFAF8802520
        public void get_ChannelCount(){} // RVA: 0x7FFAF8CC8B70
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7FFAF2ABD840
        public void get_timeInt(){} // RVA: 0x7FFAF8CC8B90
        public void set_ServerFeatureFlags(){} // RVA: 0x7FFAF8CC8BC0
        public void get_serverFeatureFlagsAvailable(){} // RVA: 0x7FFAF8CC8C00
        public void set_serverFeatureFlagsAvailable(){} // RVA: 0x7FFAF8CC8C10
        public void get_serverFeatureAck2Available(){} // RVA: 0x7FFAF8CC8C20
        public void set_serverFeatureAck2Available(){} // RVA: 0x7FFAF8CC8C30
        public void get_serverFeatureSyncReliableQueue(){} // RVA: 0x7FFAF8CC8C40
        public void set_serverFeatureSyncReliableQueue(){} // RVA: 0x7FFAF8CC8C50
        public void get_ServerMaxQueueableReliableCommands(){} // RVA: 0x7FFAF8CC8C60
        public void set_ServerMaxQueueableReliableCommands(){} // RVA: 0x7FFAF8CC8C70
        public void get_mtu(){} // RVA: 0x7FFAF8CC8C80
        public void get_IsIpv6(){} // RVA: 0x7FFAF8CC8CA0
        public void .ctor(){} // RVA: 0x7FFAF8CC8CC0
        public void Reset(){} // RVA: 0x7FFAF8CC9220
        public void Connect(){} // RVA: 0x7FFAF2AC15A0
        public void GetHttpKeyValueString(){} // RVA: 0x7FFAF8CC9920
        public void WriteInitRequest(){} // RVA: 0x7FFAF8CC9BC0
        public void WriteInitV3(){} // RVA: 0x7FFAF8CCA2C0
        public void PrepareWebSocketUrl(){} // RVA: 0x7FFAF8CCA8E0
        public void OnInitResponse(){} // RVA: 0x7FFAF8CCAD50
        public void Disconnect(){} // RVA: 0x7FFAF2AD5130
        public void FetchServerTimestamp(){} // RVA: 0x7FFAF2AD4A50
        public void IsTransportEncrypted(){} // RVA: 0x7FFAF2ABDBE0
        public void EnqueuePhotonMessage(){}
        public void SerializeOperationToMessage(){} // RVA: 0x7FFAF8CCADF0
        public void SendOutgoingCommands(){} // RVA: 0x7FFAF2ABDBE0
        public void SendAcksOnly(){} // RVA: 0x7FFAF2D8D320
        public void ReceiveIncomingCommands(){} // RVA: 0x7FFAF2ADBAA0
        public void DispatchIncomingCommands(){} // RVA: 0x7FFAF2ABDBE0
        public void DeserializeMessageAndCallback(){} // RVA: 0x7FFAF8CCB0A0
        public void UpdateRoundTripTimeAndVariance(){} // RVA: 0x7FFAF8CCBE30
        public void ExchangeKeysForEncryption(){} // RVA: 0x7FFAF8CCBFA0
        public void DeriveSharedKey(){} // RVA: 0x7FFAF8CCC640
        public void InitEncryption(){} // RVA: 0x7FFAF8CCC7F0
        public void EnqueueActionForDispatch(){} // RVA: 0x7FFAF8CCCC90
        public void EnqueueDebugReturn(){} // RVA: 0x7FFAF8CCCE10
        public void EnqueueStatusCallback(){} // RVA: 0x7FFAF8CCD0E0
        public void get_NetworkSimulationSettings(){} // RVA: 0x7FFAF304E660
        public void NetworkSimRun(){} // RVA: 0x7FFAF8CCD350
        public void .cctor(){} // RVA: 0x7FFAF8CCD9F0
        public void <DeserializeMessageAndCallback>b__121_0(){} // RVA: 0x7FFAF8CCDBD0
    }

    public class PhotonClientWebSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CCDE10
        public void Connect(){} // RVA: 0x7FFAF8CCDE90
        public void AsyncConnectAndReceive(){} // RVA: 0x7FFAF8CCDFC0
        public void Disconnect(){} // RVA: 0x7FFAF8CCF240
        public void Send(){} // RVA: 0x7FFAF8CCF5C0
        public void Receive(){} // RVA: 0x7FFAF8CCFAC0
    }

    public class PhotonCodes
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8CC8940
    }

    public class PhotonHashtable
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8CB88D0
        public void .ctor(){} // RVA: 0x7FFAF8CB8B70 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAF8CB8E50 | overloaded x3
        public void set_Item(){} // RVA: 0x7FFAF8CB8D80 | overloaded x2
        public void Add(){} // RVA: 0x7FFAF8CB8EE0
        public void ContainsKey(){} // RVA: 0x7FFAF8CB8FB0
        public void GetEnumerator(){} // RVA: 0x7FFAF8CB9070
        public void ToString(){} // RVA: 0x7FFAF8CB91B0
    }

    public class PhotonPeer
    {
        // ── Methods ──
        public void get_ClientSdkIdShifted(){} // RVA: 0x7FFAF8CCFB00
        public void get_Version(){} // RVA: 0x7FFAF8CCFB10
        public void get_UseAck2(){} // RVA: 0x7FFAF8CCFEF0
        public void set_UseAck2(){} // RVA: 0x7FFAF8CCFF00
        public void get_SerializationProtocolType(){} // RVA: 0x7FFAF442C3B0
        public void set_SerializationProtocolType(){} // RVA: 0x7FFAF4439FD0
        public void get_SocketImplementation(){} // RVA: 0x7FFAF2DBB130
        public void set_SocketImplementation(){} // RVA: 0x7FFAF2D8EE90
        public void get_SocketErrorCode(){} // RVA: 0x7FFAF8CCFF10
        public void get_Listener(){} // RVA: 0x7FFAF2F476A0
        public void set_Listener(){} // RVA: 0x7FFAF2F4B830
        public void get_PeerState(){} // RVA: 0x7FFAF8CCFF40
        public void get_ReuseEventInstance(){} // RVA: 0x7FFAF2E48C00
        public void set_ReuseEventInstance(){} // RVA: 0x7FFAF8CCFFB0
        public void get_UseByteArraySlicePoolForEvents(){} // RVA: 0x7FFAF310EEC0
        public void get_WrapIncomingStructs(){} // RVA: 0x7FFAF310F560
        public void get_QuickResendAttempts(){} // RVA: 0x7FFAF2E44D30
        public void set_QuickResendAttempts(){} // RVA: 0x7FFAF8CD0160
        public void get_DisconnectTimeout(){} // RVA: 0x7FFAF370BE80
        public void set_DisconnectTimeout(){} // RVA: 0x7FFAF8CD0180
        public void get_CrcEnabled(){} // RVA: 0x7FFAF304FF30
        public void set_CrcEnabled(){} // RVA: 0x7FFAF8CD0190
        public void get_ServerAddress(){} // RVA: 0x7FFAF8CD0220
        public void get_UsedProtocol(){} // RVA: 0x7FFAF8CD0240
        public void get_TransportProtocol(){} // RVA: 0x7FFAF3C0A230
        public void set_TransportProtocol(){} // RVA: 0x7FFAF3BFF200
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFAF8CD0260
        public void get_NetworkSimulationSettings(){} // RVA: 0x7FFAF8CD0400
        public void get_MaximumTransferUnit(){} // RVA: 0x7FFAF304C4F0
        public void get_IsEncryptionAvailable(){} // RVA: 0x7FFAF8CD0430
        public void get_PayloadEncryptorType(){} // RVA: 0x7FFAF2F77C50
        public void get_EncryptorType(){} // RVA: 0x7FFAF2DCC010
        public void set_EncryptorType(){} // RVA: 0x7FFAF8CD0460
        public void get_ServerTimeInMilliseconds(){} // RVA: 0x7FFAF8CD0620
        public void get_EnableServerTracing(){} // RVA: 0x7FFAF461CD50
        public void get_ConnectionTime(){} // RVA: 0x7FFAF8CD0670
        public void get_BytesIn(){} // RVA: 0x7FFAF8CD06A0
        public void get_BytesOut(){} // RVA: 0x7FFAF8CD06C0
        public void get_ByteCountCurrentDispatch(){} // RVA: 0x7FFAF8CD06E0
        public void get_ByteCountLastOperation(){} // RVA: 0x7FFAF8CD0700
        public void get_PacketLossByCrc(){} // RVA: 0x7FFAF8CD0720
        public void get_PacketLossByChallenge(){} // RVA: 0x7FFAF8CD0740
        public void get_CountDiscarded(){} // RVA: 0x7FFAF66F9C00
        public void set_CountDiscarded(){} // RVA: 0x7FFAF66F9C10
        public void set_DeltaUnreliableNumber(){} // RVA: 0x7FFAF3779310
        public void get_QueuedOutgoingCommands(){} // RVA: 0x7FFAF8CD0760
        public void get_Stats(){} // RVA: 0x7FFAF2DF8040
        public void set_Stats(){} // RVA: 0x7FFAF2DF8050
        public void .ctor(){} // RVA: 0x7FFAF8CD0E20 | overloaded x2
        public void Connect(){} // RVA: 0x7FFAF8CD0EA0
        public void CreatePeerBase(){} // RVA: 0x7FFAF8CD1BA0
        public void Disconnect(){} // RVA: 0x7FFAF8CD1DC0
        public void FetchServerTimestamp(){} // RVA: 0x7FFAF8CD2080
        public void EstablishEncryption(){} // RVA: 0x7FFAF8CD20B0
        public void InitDatagramEncryption(){} // RVA: 0x7FFAF8CD2190
        public void InitPayloadEncryption(){} // RVA: 0x7FFAF2F14450
        public void Service(){} // RVA: 0x7FFAF8CD25E0
        public void SendOutgoingCommands(){} // RVA: 0x7FFAF8CD2630
        public void SendAcksOnly(){} // RVA: 0x7FFAF8CD2810
        public void DispatchIncomingCommands(){} // RVA: 0x7FFAF8CD2980
        public void SendOperation(){} // RVA: 0x7FFAF8CD2B70
        public void RegisterType(){} // RVA: 0x7FFAF8CD3000
        public void .cctor(){} // RVA: 0x7FFAF8CD3090
        public void <EstablishEncryption>b__202_0(){} // RVA: 0x7FFAF8CD30F0
    }

    public class PhotonSocket
    {
        // ── Methods ──
        public void get_Listener(){} // RVA: 0x7FFAF8CD3120
        public void get_MTU(){} // RVA: 0x7FFAF8CD3150
        public void get_State(){} // RVA: 0x7FFAF442C3B0
        public void set_State(){} // RVA: 0x7FFAF4439FD0
        public void get_SocketErrorCode(){} // RVA: 0x7FFAF3210030
        public void set_SocketErrorCode(){} // RVA: 0x7FFAF344E0D0
        public void get_Connected(){} // RVA: 0x7FFAF8CD3180
        public void get_LogLevel(){} // RVA: 0x7FFAF8CD3190
        public void get_ServerAddress(){} // RVA: 0x7FFAF30E74D0
        public void set_ServerAddress(){} // RVA: 0x7FFAF2DBB890
        public void get_ProxyServerAddress(){} // RVA: 0x7FFAF2F476A0
        public void set_ProxyServerAddress(){} // RVA: 0x7FFAF2F4B830
        public void set_ServerIpAddress(){} // RVA: 0x7FFAF2DB5200
        public void get_ServerPort(){} // RVA: 0x7FFAF2E2E0C0
        public void set_ServerPort(){} // RVA: 0x7FFAF2E2E0D0
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x7FFAF418A880
        public void set_AddressResolvedAsIpv6(){} // RVA: 0x7FFAF4190A80
        public void set_UrlProtocol(){} // RVA: 0x7FFAF2EE54D0
        public void set_UrlPath(){} // RVA: 0x7FFAF2E55510
        public void get_SerializationProtocol(){} // RVA: 0x7FFAF8CD31C0
        public void .ctor(){} // RVA: 0x7FFAF8CD3380
        public void Connect(){} // RVA: 0x7FFAF8CD34C0
        public void Disconnect(){} // RVA: 0x7FFAF2ABDBE0
        public void Send(){}
        public void Receive(){} // RVA: 0x7FFAF2AC2590
        public void HandleReceivedDatagram(){} // RVA: 0x7FFAF8CD3870
        public void ReportDebugOfLevel(){} // RVA: 0x7FFAF8CD38A0
        public void EnqueueDebugReturn(){} // RVA: 0x7FFAF8CD38D0
        public void HandleException(){} // RVA: 0x7FFAF8CD38F0
        public void TryParseAddress(){} // RVA: 0x7FFAF8CD39A0
        public void IpAddressTryParse(){} // RVA: 0x7FFAF8CD3E90
        public void GetIpAddresses(){} // RVA: 0x7FFAF8CD4150
        public void AddressSortComparer(){} // RVA: 0x7FFAF8CD4910
        public void <HandleException>b__58_0(){} // RVA: 0x7FFAF8CD4970
    }

    public class Pool`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void CreatePoolItems(){} // RVA: 0x7FFAF2AD4FA0
        public void Release(){} // RVA: 0x7FFAF2D33FA0
        public void Acquire(){} // RVA: 0x7FFAF2D33FA0
    }

    public class Pool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF68A5130
        public void CreatePoolItems(){} // RVA: 0x7FFAF68A52F0
        public void Release(){} // RVA: 0x7FFAF68A5370
        public void Acquire(){} // RVA: 0x7FFAF68A5540
    }

    public class Pool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF68A5130
        public void CreatePoolItems(){} // RVA: 0x7FFAF68A52F0
        public void Release(){} // RVA: 0x7FFAF68A5370
        public void Acquire(){} // RVA: 0x7FFAF68A5540
    }

    public class Pool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF68A5130
        public void CreatePoolItems(){} // RVA: 0x7FFAF68A52F0
        public void Release(){} // RVA: 0x7FFAF68A5370
        public void Acquire(){} // RVA: 0x7FFAF68A5540
    }

    public class PreserveAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Protocol
    {
        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7FFAF2ABCD60
        public void get_VersionBytes(){} // RVA: 0x7FFAF2ABCD60
        public void Serialize(){} // RVA: 0x7FFAF8CD4EA0 | overloaded x2
        public void SerializeShort(){}
        public void SerializeString(){}
        public void SerializeEventData(){}
        public void SerializeOperationRequest(){}
        public void SerializeOperationResponse(){}
        public void Deserialize(){} // RVA: 0x7FFAF8CD4F40 | overloaded x2
        public void DeserializeShort(){} // RVA: 0x7FFAF2AC34B0
        public void DeserializeByte(){} // RVA: 0x7FFAF2ABDE40
        public void DeserializeEventData(){}
        public void DeserializeOperationRequest(){} // RVA: 0x7FFAF2ACDD80
        public void DeserializeOperationResponse(){} // RVA: 0x7FFAF2ACDD80
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFAF2ABCE10
        public void DeserializeMessage(){} // RVA: 0x7FFAF8CD5030
        public void TryRegisterType(){} // RVA: 0x7FFAF8CD5090
        public void .ctor(){} // RVA: 0x7FFAF8CD5400
        public void .cctor(){} // RVA: 0x7FFAF8CD54A0
    }

    public class Protocol16
    {
        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7FFAF8CD5640
        public void get_VersionBytes(){} // RVA: 0x7FFAF2D907C0
        public void SerializeCustom(){} // RVA: 0x7FFAF8CD5680
        public void DeserializeCustom(){} // RVA: 0x7FFAF8CD5A50
        public void GetTypeOfCode(){} // RVA: 0x7FFAF8CD5D80
        public void GetCodeOfType(){} // RVA: 0x7FFAF8CD6100
        public void CreateArrayByType(){} // RVA: 0x7FFAF8CD64A0
        public void SerializeOperationRequest(){} // RVA: 0x7FFAF8CD6510 | overloaded x2
        public void DeserializeOperationRequest(){} // RVA: 0x7FFAF8CD65F0
        public void SerializeOperationResponse(){} // RVA: 0x7FFAF8CD66E0
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFAF8CD6870
        public void DeserializeOperationResponse(){} // RVA: 0x7FFAF8CD6A40
        public void SerializeEventData(){} // RVA: 0x7FFAF8CD6C30
        public void DeserializeEventData(){} // RVA: 0x7FFAF8CD6D10
        public void SerializeParameterTable(){} // RVA: 0x7FFAF8CD6DD0
        public void DeserializeParameterDictionary(){} // RVA: 0x7FFAF8CD7160
        public void Serialize(){} // RVA: 0x7FFAF8CD7290
        public void SerializeByte(){} // RVA: 0x7FFAF8CD7EC0
        public void SerializeBoolean(){} // RVA: 0x7FFAF8CD7F70
        public void SerializeShort(){} // RVA: 0x7FFAF8CD8020
        public void SerializeLengthAsShort(){} // RVA: 0x7FFAF8CD8270
        public void SerializeInteger(){} // RVA: 0x7FFAF8CD84C0
        public void SerializeLong(){} // RVA: 0x7FFAF8CD8730
        public void SerializeFloat(){} // RVA: 0x7FFAF8CD8BE0
        public void SerializeDouble(){} // RVA: 0x7FFAF8CD9150
        public void SerializeString(){} // RVA: 0x7FFAF8CD9610
        public void SerializeArray(){} // RVA: 0x7FFAF8CD97F0
        public void SerializeByteArray(){} // RVA: 0x7FFAF8CD9ED0
        public void SerializeByteArraySegment(){} // RVA: 0x7FFAF8CD9F90
        public void SerializeIntArrayOptimized(){} // RVA: 0x7FFAF8CDA070
        public void SerializeObjectArray(){} // RVA: 0x7FFAF8CDA2D0
        public void SerializeHashTable(){} // RVA: 0x7FFAF8CDA520
        public void SerializeDictionary(){} // RVA: 0x7FFAF8CDA880
        public void SerializeDictionaryHeader(){} // RVA: 0x7FFAF8CDA980 | overloaded x2
        public void SerializeDictionaryElements(){} // RVA: 0x7FFAF8CDADC0
        public void Deserialize(){} // RVA: 0x7FFAF8CDB120
        public void DeserializeByte(){} // RVA: 0x7FFAF8CDBA50
        public void DeserializeBoolean(){} // RVA: 0x7FFAF8CDBA70
        public void DeserializeShort(){} // RVA: 0x7FFAF8CDBAA0
        public void DeserializeInteger(){} // RVA: 0x7FFAF8CDBE50
        public void DeserializeLong(){} // RVA: 0x7FFAF8CDC220
        public void DeserializeFloat(){} // RVA: 0x7FFAF8CDC660
        public void DeserializeDouble(){} // RVA: 0x7FFAF8CDCAA0
        public void DeserializeString(){} // RVA: 0x7FFAF8CDCF70
        public void DeserializeArray(){} // RVA: 0x7FFAF8CDD0D0
        public void DeserializeByteArray(){} // RVA: 0x7FFAF8CDDAF0
        public void DeserializeIntArray(){} // RVA: 0x7FFAF8CDDBB0
        public void DeserializeStringArray(){} // RVA: 0x7FFAF8CDDC70
        public void DeserializeObjectArray(){} // RVA: 0x7FFAF8CDDD80
        public void DeserializeHashTable(){} // RVA: 0x7FFAF8CDDF00
        public void DeserializeDictionary(){} // RVA: 0x7FFAF8CDE070
        public void DeserializeDictionaryArray(){} // RVA: 0x7FFAF8CDE450
        public void DeserializeDictionaryType(){} // RVA: 0x7FFAF8CDE700
        public void .ctor(){} // RVA: 0x7FFAF8CDE9D0
        public void .cctor(){} // RVA: 0x7FFAF8CDEE50
    }

    public class Protocol18
    {
        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7FFAF8CDF000
        public void get_VersionBytes(){} // RVA: 0x7FFAF2D907C0
        public void Serialize(){} // RVA: 0x7FFAF8CDF040
        public void SerializeShort(){} // RVA: 0x7FFAF8CDF0C0
        public void SerializeString(){} // RVA: 0x7FFAF8CDF130
        public void Deserialize(){} // RVA: 0x7FFAF8CDF140
        public void DeserializeShort(){} // RVA: 0x7FFAF8CDF160
        public void DeserializeByte(){} // RVA: 0x7FFAF8CDBA50
        public void GetAllowedDictionaryKeyTypes(){} // RVA: 0x7FFAF8CDF1E0
        public void GetClrArrayType(){} // RVA: 0x7FFAF8CDF3D0
        public void GetCodeOfType(){} // RVA: 0x7FFAF8CDF730
        public void GetCodeOfTypeCode(){} // RVA: 0x7FFAF8CDFF50
        public void Read(){} // RVA: 0x7FFAF8CE0040 | overloaded x2
        public void ReadBoolean(){} // RVA: 0x7FFAF8CDBA70
        public void ReadByte(){} // RVA: 0x7FFAF8CDBA50
        public void ReadInt16(){} // RVA: 0x7FFAF8CDF160
        public void ReadUShort(){} // RVA: 0x7FFAF8CDF160
        public void ReadSingle(){} // RVA: 0x7FFAF8CE12F0
        public void ReadDouble(){} // RVA: 0x7FFAF8CE1390
        public void ReadNonAllocByteArray(){} // RVA: 0x7FFAF8CE1430
        public void ReadByteArray(){} // RVA: 0x7FFAF8CE14D0
        public void ReadCustomType(){} // RVA: 0x7FFAF8CE1580
        public void DeserializeEventData(){} // RVA: 0x7FFAF8CE1940
        public void ReadParameterDictionary(){} // RVA: 0x7FFAF8CE1B80
        public void ReadHashtable(){} // RVA: 0x7FFAF8CE1CB0
        public void DeserializeOperationRequest(){} // RVA: 0x7FFAF8CE1EA0
        public void DeserializeOperationResponse(){} // RVA: 0x7FFAF8CE1F90
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFAF8CE21A0
        public void ReadString(){} // RVA: 0x7FFAF8CE2380
        public void ReadCustomTypeArray(){} // RVA: 0x7FFAF8CE2460
        public void ReadDictionaryType(){} // RVA: 0x7FFAF8CE2D00 | overloaded x2
        public void GetDictArrayType(){} // RVA: 0x7FFAF8CE2FB0
        public void ReadDictionary(){} // RVA: 0x7FFAF8CE30B0
        public void ReadDictionaryElements(){} // RVA: 0x7FFAF8CE32E0
        public void ReadObjectArray(){} // RVA: 0x7FFAF8CE3460
        public void ReadBooleanArray(){} // RVA: 0x7FFAF8CE35D0
        public void ReadInt16Array(){} // RVA: 0x7FFAF8CE3810
        public void ReadSingleArray(){} // RVA: 0x7FFAF8CE3910
        public void ReadDoubleArray(){} // RVA: 0x7FFAF8CE39D0
        public void ReadStringArray(){} // RVA: 0x7FFAF8CE3A90
        public void ReadHashtableArray(){} // RVA: 0x7FFAF8CE3B90
        public void ReadDictionaryArray(){} // RVA: 0x7FFAF8CE3D20
        public void ReadArrayInArray(){} // RVA: 0x7FFAF8CE40B0
        public void ReadInt1(){} // RVA: 0x7FFAF8CE4250
        public void ReadInt2(){} // RVA: 0x7FFAF8CE4290
        public void ReadCompressedInt32(){} // RVA: 0x7FFAF8CE4350
        public void ReadCompressedUInt32(){} // RVA: 0x7FFAF8CE4370
        public void ReadCompressedInt64(){} // RVA: 0x7FFAF8CE4610
        public void ReadCompressedUInt64(){} // RVA: 0x7FFAF8CE46F0
        public void ReadCompressedInt32Array(){} // RVA: 0x7FFAF8CE47C0
        public void ReadCompressedInt64Array(){} // RVA: 0x7FFAF8CE4880
        public void DecodeZigZag32(){} // RVA: 0x7FFAF8CE4930
        public void DecodeZigZag64(){} // RVA: 0x7FFAF8CE4940
        public void Write(){} // RVA: 0x7FFAF8CE4950 | overloaded x2
        public void SerializeEventData(){} // RVA: 0x7FFAF8CE5F90
        public void WriteParameterTable(){} // RVA: 0x7FFAF8CE6070
        public void SerializeOperationRequest(){} // RVA: 0x7FFAF8CE6470 | overloaded x2
        public void SerializeOperationResponse(){} // RVA: 0x7FFAF8CE6550
        public void WriteByte(){} // RVA: 0x7FFAF8CE6700
        public void WriteBoolean(){} // RVA: 0x7FFAF8CE6790
        public void WriteUShort(){} // RVA: 0x7FFAF8CE6830
        public void WriteInt16(){} // RVA: 0x7FFAF8CDF0C0
        public void WriteDouble(){} // RVA: 0x7FFAF8CE6860
        public void WriteSingle(){} // RVA: 0x7FFAF8CE6C10
        public void WriteString(){} // RVA: 0x7FFAF8CE6FC0
        public void WriteHashtable(){} // RVA: 0x7FFAF8CE7170
        public void WriteByteArray(){} // RVA: 0x7FFAF8CE7480
        public void WriteArraySegmentByte(){} // RVA: 0x7FFAF8CE7530
        public void WriteByteArraySlice(){} // RVA: 0x7FFAF8CE7680
        public void WriteInt32ArrayCompressed(){} // RVA: 0x7FFAF8CE7760
        public void WriteInt64ArrayCompressed(){} // RVA: 0x7FFAF8CE7830
        public void WriteBoolArray(){} // RVA: 0x7FFAF8CE7910
        public void WriteInt16Array(){} // RVA: 0x7FFAF8CE7C00
        public void WriteSingleArray(){} // RVA: 0x7FFAF8CE7CD0
        public void WriteDoubleArray(){} // RVA: 0x7FFAF8CE7DC0
        public void WriteStringArray(){} // RVA: 0x7FFAF8CE7EB0
        public void WriteObjectArray(){} // RVA: 0x7FFAF8CE8070
        public void WriteArrayInArray(){} // RVA: 0x7FFAF8CE8290
        public void WriteCustomTypeBody(){} // RVA: 0x7FFAF8CE83C0
        public void WriteCustomType(){} // RVA: 0x7FFAF8CE8660
        public void WriteCustomTypeArray(){} // RVA: 0x7FFAF8CE8B40
        public void WriteArrayHeader(){} // RVA: 0x7FFAF8CE91D0
        public void WriteDictionaryElements(){} // RVA: 0x7FFAF8CE9330
        public void WriteDictionary(){} // RVA: 0x7FFAF8CE9600
        public void WriteDictionaryHeader(){} // RVA: 0x7FFAF8CE9740
        public void WriteArrayType(){} // RVA: 0x7FFAF8CE9F00
        public void WriteHashtableArray(){} // RVA: 0x7FFAF8CEA3D0
        public void WriteDictionaryArray(){} // RVA: 0x7FFAF8CEA520
        public void WriteIntLength(){} // RVA: 0x7FFAF8CEA660
        public void WriteCompressedInt32(){} // RVA: 0x7FFAF8CEA670
        public void WriteCompressedInt64(){} // RVA: 0x7FFAF8CEA820
        public void WriteCompressedUInt32(){} // RVA: 0x7FFAF8CEABC0 | overloaded x2
        public void WriteCompressedUInt64(){} // RVA: 0x7FFAF8CEAC30
        public void EncodeZigZag32(){} // RVA: 0x7FFAF8CEAE70
        public void EncodeZigZag64(){} // RVA: 0x7FFAF8CEAE80
        public void .ctor(){} // RVA: 0x7FFAF8CEAE90
        public void .cctor(){} // RVA: 0x7FFAF8CEB190
    }

    public class SendOptions
    {
        // ── Methods ──
        public void get_Reliability(){} // RVA: 0x7FFAF8CEC340
        public void set_Reliability(){} // RVA: 0x7FFAF8CEC350
        public void .cctor(){} // RVA: 0x7FFAF8CEC360
    }

    public class SerializationProtocolFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF8CD4B80
    }

    public class SerializeStreamMethod
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5E5FC70
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
    }

    public class SimulationItem
    {
        // ── Methods ──
        public void get_Delay(){} // RVA: 0x7FFAF3241DC0
    }

    public class SocketTcp
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CEC3D0
        public void Finalize(){} // RVA: 0x7FFAF8CEC4F0
        public void Dispose(){} // RVA: 0x7FFAF8CEC530
        public void Connect(){} // RVA: 0x7FFAF8CEC640
        public void Disconnect(){} // RVA: 0x7FFAF8CEC8E0
        public void Send(){} // RVA: 0x7FFAF8CECB40
        public void Receive(){} // RVA: 0x7FFAF45325D0
        public void DnsAndConnect(){} // RVA: 0x7FFAF8CECE30
        public void ReceiveLoop(){} // RVA: 0x7FFAF8CED560
    }

    public class SocketTcpAsync
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CEDF60
        public void Finalize(){} // RVA: 0x7FFAF8CEE080
        public void Dispose(){} // RVA: 0x7FFAF8CEE0C0
        public void Connect(){} // RVA: 0x7FFAF8CEE1E0
        public void Disconnect(){} // RVA: 0x7FFAF8CEE480
        public void Send(){} // RVA: 0x7FFAF8CEE710
        public void Receive(){} // RVA: 0x7FFAF45325D0
        public void DnsAndConnect(){} // RVA: 0x7FFAF8CEEC40
        public void ReceiveAsync(){} // RVA: 0x7FFAF8CEF750 | overloaded x2
    }

    public class SocketUdp
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CEFF60
        public void Finalize(){} // RVA: 0x7FFAF8CF00F0
        public void Dispose(){} // RVA: 0x7FFAF8CF0130
        public void Connect(){} // RVA: 0x7FFAF8CF0250
        public void Disconnect(){} // RVA: 0x7FFAF8CF04F0
        public void Send(){} // RVA: 0x7FFAF8CF0780
        public void Receive(){} // RVA: 0x7FFAF45325D0
        public void DnsAndConnect(){} // RVA: 0x7FFAF8CF1300
        public void ReceiveLoop(){} // RVA: 0x7FFAF8CF1970
    }

    public class SocketUdpAsync
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CF2090
        public void Finalize(){} // RVA: 0x7FFAF8CEE080
        public void Dispose(){} // RVA: 0x7FFAF8CEE0C0
        public void Connect(){} // RVA: 0x7FFAF8CF21B0
        public void Disconnect(){} // RVA: 0x7FFAF8CF2450
        public void Send(){} // RVA: 0x7FFAF8CF26E0
        public void Receive(){} // RVA: 0x7FFAF45325D0
        public void DnsAndConnect(){} // RVA: 0x7FFAF8CF2C40
        public void StartReceive(){} // RVA: 0x7FFAF8CF31B0
        public void OnReceive(){} // RVA: 0x7FFAF8CF3430
    }

    public class StreamBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CF3E20 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFAF8CF3E90
        public void Compact(){} // RVA: 0x7FFAF8CF3F00
        public void GetBuffer(){} // RVA: 0x7FFAF2D907C0
        public void GetBufferAndAdvance(){} // RVA: 0x7FFAF8CF3F80
        public void get_Length(){} // RVA: 0x7FFAF335BED0
        public void get_Position(){} // RVA: 0x7FFAF2DDA5C0
        public void set_Position(){} // RVA: 0x7FFAF8CF3FC0
        public void get_Available(){} // RVA: 0x7FFAF8CF3FE0
        public void Reset(){} // RVA: 0x7FFAF8CF3FF0
        public void Seek(){} // RVA: 0x7FFAF8CF4000
        public void SetLength(){} // RVA: 0x7FFAF8CF4120
        public void SetCapacityMinimum(){} // RVA: 0x7FFAF8CF4150
        public void Read(){} // RVA: 0x7FFAF8CF4160
        public void Write(){} // RVA: 0x7FFAF8CF41C0
        public void ReadByte(){} // RVA: 0x7FFAF8CF4240
        public void WriteByte(){} // RVA: 0x7FFAF8CF4330
        public void WriteBytes(){} // RVA: 0x7FFAF8CF4390
        public void CheckSize(){} // RVA: 0x7FFAF8CF4420
    }

    public class SupportClass
    {
        // ── Methods ──
        public void WriteStackTrace(){} // RVA: 0x7FFAF8CF4530
        public void DictionaryToString(){} // RVA: 0x7FFAF8CF50D0 | overloaded x2
        public void ByteArrayToString(){} // RVA: 0x7FFAF8CF5C00
        public void InitializeTable(){} // RVA: 0x7FFAF8CF5C80
        public void CalculateCrc(){} // RVA: 0x7FFAF8CF5FB0 | overloaded x2
    }

    public class TPeer
    {
        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7FFAF8CF6290
        public void .ctor(){} // RVA: 0x7FFAF8CF62E0
        public void IsTransportEncrypted(){} // RVA: 0x7FFAF8CF6510
        public void Reset(){} // RVA: 0x7FFAF8CF6520
        public void Connect(){} // RVA: 0x7FFAF8CF66B0
        public void Disconnect(){} // RVA: 0x7FFAF8CF6B10 | overloaded x2
        public void FetchServerTimestamp(){} // RVA: 0x7FFAF8CF6DC0
        public void EnqueueInit(){} // RVA: 0x7FFAF8CF6F00
        public void DispatchIncomingCommands(){} // RVA: 0x7FFAF8CF70A0
        public void SendOutgoingCommands(){} // RVA: 0x7FFAF8CF75E0
        public void SendAcksOnly(){} // RVA: 0x7FFAF8CF7AB0
        public void EnqueuePhotonMessage(){} // RVA: 0x7FFAF8CF7B20
        public void EnqueueMessageAsPayload(){} // RVA: 0x7FFAF8CF7B50
        public void SendPing(){} // RVA: 0x7FFAF8CF7EB0
        public void SendData(){} // RVA: 0x7FFAF8CF8460
        public void ReceiveIncomingCommands(){} // RVA: 0x7FFAF8CF85F0
        public void ReadPingResult(){} // RVA: 0x7FFAF8CF8C90 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8CF8DE0
    }

    public class TrafficStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E2B380
        public void get_LastReceiveTimestamp(){} // RVA: 0x7FFAF3B95CF0
        public void set_LastReceiveTimestamp(){} // RVA: 0x7FFAF2F25080
        public void get_LastDispatchTimestamp(){} // RVA: 0x7FFAF43D9080
        public void set_LastDispatchTimestamp(){} // RVA: 0x7FFAF483D640
        public void get_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x7FFAF4593800
        public void set_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x7FFAF4596D80
        public void set_LastDispatchDuration(){} // RVA: 0x7FFAF8CF8F70
        public void get_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0x7FFAF3A74570
        public void set_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0x7FFAF3A74560
        public void DispatchIncomingCommandsCalled(){} // RVA: 0x7FFAF8CF8F80
        public void SendOutgoingCommandsCalled(){} // RVA: 0x7FFAF8CF8FA0
        public void ToString(){} // RVA: 0x7FFAF8CF8FD0 | overloaded x2
    }

    public class TrafficStatsBase
    {
        // ── Methods ──
        public void get_BytesIn(){} // RVA: 0x7FFAF2DA8380
        public void set_BytesIn(){} // RVA: 0x7FFAF4417700
        public void get_BytesOut(){} // RVA: 0x7FFAF2D907C0
        public void set_BytesOut(){} // RVA: 0x7FFAF370BE60
        public void get_PackagesIn(){} // RVA: 0x7FFAF3210030
        public void set_PackagesIn(){} // RVA: 0x7FFAF344E0D0
        public void get_PackagesOut(){} // RVA: 0x7FFAF379F5B0
        public void set_PackagesOut(){} // RVA: 0x7FFAF4191F00
        public void get_UdpFragmentsIn(){} // RVA: 0x7FFAF3241DC0
        public void set_UdpFragmentsIn(){} // RVA: 0x7FFAF3503440
        public void get_UdpFragmentsOut(){} // RVA: 0x7FFAF3CB9F00
        public void set_UdpFragmentsOut(){} // RVA: 0x7FFAF45ACF60
        public void get_UdpUnreliableCommandsSent(){} // RVA: 0x7FFAF2DE8CD0
        public void set_UdpUnreliableCommandsSent(){} // RVA: 0x7FFAF2DE8CE0
        public void get_UdpReliableCommandsSent(){} // RVA: 0x7FFAF2F76670
        public void set_UdpReliableCommandsSent(){} // RVA: 0x7FFAF2F75F20
        public void get_UdpReliableCommandsResent(){} // RVA: 0x7FFAF3A8C9F0
        public void set_UdpReliableCommandsResent(){} // RVA: 0x7FFAF3A8D6E0
        public void set_UdpReliableCommandsInFlight(){} // RVA: 0x7FFAF47695F0
        public void get_DispatchIncomingCommandsCalls(){} // RVA: 0x7FFAF2E2E080
        public void set_DispatchIncomingCommandsCalls(){} // RVA: 0x7FFAF2E2E090
        public void get_SendOutgoingCommandsCalls(){} // RVA: 0x7FFAF2E2E0A0
        public void set_SendOutgoingCommandsCalls(){} // RVA: 0x7FFAF2E2E0B0
        public void get_RoundtripTime(){} // RVA: 0x7FFAF2E08730
        public void set_RoundtripTime(){} // RVA: 0x7FFAF424D760
        public void get_RoundtripTimeVariance(){} // RVA: 0x7FFAF2E2E0E0
        public void set_RoundtripTimeVariance(){} // RVA: 0x7FFAF2F74D50
        public void set_LastRoundtripTime(){} // RVA: 0x7FFAF2F734E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UnknownType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Version
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8CF9710
    }

}