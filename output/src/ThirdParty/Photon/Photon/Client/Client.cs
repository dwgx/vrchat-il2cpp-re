// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client
// Classes: 56
// Methods: 777

namespace ThirdParty.Photon.Photon.Client
{
    public class ByteArraySlice : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C76770
        public void Dispose(){} // RVA: 0x6C767E0
        public void Release(){} // RVA: 0x6C76820
    }

    public class ByteArraySlicePool : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C76860
        public void Acquire(){} // RVA: 0x6C76A80
        public void PopOrCreate(){} // RVA: 0x6C76E70
        public void Release(){} // RVA: 0x6C77150
    }

    public class ByteArraySlice[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CustomType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C92A00
    }

    public class DeserializeStreamMethod : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C92890
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class DictionaryEntryEnumerator : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x216AC0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x8E45C0
        public void get_Current(){} // RVA: 0x8E4710
        public void MoveNext(){} // RVA: 0x8E4840
        public void Reset(){} // RVA: 0x8E4880
        public void Dispose(){} // RVA: 0x3FC0
    }

    public class DisconnectMessage : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EnetChannel : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C785E0
        public void AddSequencedIfNew(){} // RVA: 0x6C78AD0
        public void TryGetFragment(){} // RVA: 0x6C78B90
        public void RemoveFragment(){} // RVA: 0x6C78C10
        public void clearAll(){} // RVA: 0x6C78C80
        public void QueueIncomingReliableUnsequenced(){} // RVA: 0x6C78F90
        public void ApplySequenceNumberModifier(){} // RVA: 0x6C79140
        public void Received(){} // RVA: 0x6C79190
        public void GetGapBlock(){} // RVA: 0x6C793F0
    }

    public class EnetChannel[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class EnetPeer : PeerBase
    {
        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x6C797D0
        public void get_SendWindowUpdateRequired(){} // RVA: 0x6C79AC0
        public void set_SendWindowUpdateRequired(){} // RVA: 0x6C79AE0
        public void get_DatagramEncryptedConnection(){} // RVA: 0x6C79B00
        public void set_DatagramEncryptedConnection(){} // RVA: 0x6C79B20
        public void get_useAck2(){} // RVA: 0x6C79B40
        public void .ctor(){} // RVA: 0x6C79B70
        public void IsTransportEncrypted(){} // RVA: 0x6C79B00
        public void Reset(){} // RVA: 0x6C7A500
        public void ApplyRandomizedSequenceNumbers(){} // RVA: 0x6C7AD20
        public void GetChannel(){} // RVA: 0x6C7AEF0
        public void Connect(){} // RVA: 0x6C7AF50
        public void Disconnect(){} // RVA: 0x6C7B020
        public void FetchServerTimestamp(){} // RVA: 0x6C7B4F0
        public void DispatchCommandQueue(){} // RVA: 0x6C7B610
        public void DispatchIncomingCommands(){} // RVA: 0x6C7B6F0
        public void GetFragmentLength(){} // RVA: 0x6C7C1E0
        public void CalculatePacketSize(){} // RVA: 0x6C7C2C0
        public void CalculateInitialOffset(){} // RVA: 0x6C7C350
        public void SendAcksOnly(){} // RVA: 0x6C7C3A0
        public void SendOutgoingCommands(){} // RVA: 0x6C7C3C0
        public void UpdateSendWindow(){} // RVA: 0x6C7D3F0
        public void EnqueuePhotonMessage(){} // RVA: 0x6C7DD40
        public void CreateAndEnqueueCommand(){} // RVA: 0x6C7DD90
        public void SerializeAckToBuffer(){} // RVA: 0x6C7E350
        public void SerializeToBuffer(){} // RVA: 0x6C7E830
        public void SerializeCommandToBuffer(){} // RVA: 0x6C7E990
        public void SendData(){} // RVA: 0x6C7EB70
        public void SendToSocket(){} // RVA: 0x6C7EEE0
        public void SendDataEncrypted(){} // RVA: 0x6C7F050
        public void QueueSentCommand(){} // RVA: 0x6C7F350
        public void QueueOutgoingReliableCommand(){} // RVA: 0x6C7F6D0
        public void QueueOutgoingUnreliableCommand(){} // RVA: 0x6C7F8D0
        public void QueueOutgoingAcknowledgement(){} // RVA: 0x6C7FB40
        public void ReceiveIncomingCommands(){} // RVA: 0x6C7FFA0
        public void ExecuteCommand(){} // RVA: 0x6C80B40
        public void QueueIncomingCommand(){} // RVA: 0x6C82280
        public void RemoveSentReliableCommand(){} // RVA: 0x6C82AD0
        public void .cctor(){} // RVA: 0x6C82F10
        public void <ExecuteCommand>b__78_0(){} // RVA: 0x6C82FF0
    }

    public class EventData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CA9050
        public void get_Item(){} // RVA: 0x6CA9100
        public void get_Sender(){} // RVA: 0x6CA9170
        public void set_Sender(){} // RVA: 0x1FAA840
        public void get_CustomData(){} // RVA: 0x6CA91F0
        public void Reset(){} // RVA: 0x6CA9270
        public void ToString(){} // RVA: 0x6CA92F0
    }

    public class EventData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IPhotonPeerListener
    {
        // ── Methods ──
        public void DebugReturn(){} // RVA: 0x894DF0
        public void OnOperationResponse(){} // RVA: 0x894320
        public void OnStatusChanged(){} // RVA: 0x8944F0
        public void OnEvent(){} // RVA: 0x894320
        public void OnMessage(){} // RVA: 0x894DF0
        public void OnDisconnectMessage(){} // RVA: 0x894320
    }

    public class ITrafficRecorder
    {
        // ── Methods ──
        public void Record(){} // RVA: 0x89B5A0
    }

    public class InvalidDataException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C9C980
    }

    public class MessageProtocol : Object
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x6CA9550
        public void Deserialize(){} // RVA: 0x6CA9810
        public void .cctor(){} // RVA: 0x6CA9B10
    }

    public class NCommand : Object
    {
        // ── Methods ──
        public void get_SizeOfPayload(){} // RVA: 0x6C83150
        public void get_IsFlaggedUnsequenced(){} // RVA: 0x6C83170
        public void get_IsFlaggedReliable(){} // RVA: 0x6C83180
        public void CreateAck(){} // RVA: 0x6C831A0
        public void CreateAck2(){} // RVA: 0x6C833D0
        public void Initialize(){} // RVA: 0x6C839D0
        public void Reset(){} // RVA: 0x6C84000
        public void SerializeHeader(){} // RVA: 0x6C84040
        public void Serialize(){} // RVA: 0x16D4560
        public void FreePayload(){} // RVA: 0x6C844D0
        public void CompareTo(){} // RVA: 0x6C845B0
        public void ToString(){} // RVA: 0x6C845F0
        public void .ctor(){} // RVA: 0x6C84E20
    }

    public class NCommand[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class NetworkSimulationSet : Object
    {
        // ── Methods ──
        public void get_IsSimulationEnabled(){} // RVA: 0xC120A0
        public void set_IsSimulationEnabled(){} // RVA: 0x6C84F10
        public void set_OutgoingLossPercentage(){} // RVA: 0x22735B0
        public void set_IncomingLossPercentage(){} // RVA: 0x13233D0
        public void set_LostPackagesOut(){} // RVA: 0xBE58A0
        public void set_LostPackagesIn(){} // RVA: 0x262A680
        public void ToString(){} // RVA: 0x6C85B40
        public void .ctor(){} // RVA: 0x6C85E70
    }

    public class NonAllocDictionary`2 : Object
    {
        // ── Methods ──
        public void get_Keys(){} // RVA: 0xA94080
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0x87C0A0
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0x87C0A0
        public void get_Count(){} // RVA: 0x87C130
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x8944F0
        public void ContainsKey(){} // RVA: 0xA94080
        public void Contains(){} // RVA: 0xA94080
        public void TryGetValue(){} // RVA: 0xA94080
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void Add(){} // RVA: 0xA94080
        public void Remove(){} // RVA: 0xA94080
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x87C0A0
        public void GetEnumerator(){} // RVA: 0xA94080
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void FindNode(){} // RVA: 0xA94080
        public void Insert(){} // RVA: 0xA94080
        public void Expand(){} // RVA: 0x894290
        public void Clear(){} // RVA: 0x894290
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x899290
        public void IsPrimeFromList(){} // RVA: 0x87DD60
        public void GetNextPrime(){} // RVA: 0x883700
        public void Assert(){} // RVA: 0x894790
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class NonAllocDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x47200F0
        public void get_Keys(){} // RVA: 0x4720080
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0xBC1B30
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0xD05CA0
        public void get_Count(){} // RVA: 0x47200E0
        public void get_IsReadOnly(){} // RVA: 0xB68DF0
        public void ContainsKey(){} // RVA: 0x47202F0
        public void Contains(){} // RVA: 0x4720310
        public void TryGetValue(){} // RVA: 0x47203C0
        public void get_Item(){} // RVA: 0x4720460
        public void set_Item(){} // RVA: 0x4720540
        public void Add(){} // RVA: 0x47207C0
        public void Remove(){} // RVA: 0x4720A30
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x4720B10
        public void GetEnumerator(){} // RVA: 0x4720080
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4720B10
        public void FindNode(){} // RVA: 0x4720BA0
        public void Insert(){} // RVA: 0x4720C30
        public void Expand(){} // RVA: 0x4720E20
        public void Clear(){} // RVA: 0x47211E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x4721240
        public void IsPrimeFromList(){} // RVA: 0x4721420
        public void GetNextPrime(){} // RVA: 0x4721590
        public void Assert(){} // RVA: 0x4721880
        public void .cctor(){} // RVA: 0x47218E0
    }

    public class NonAllocDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4721A10
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0xBC1B30
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0xD05CA0
        public void get_IsReadOnly(){} // RVA: 0xB68DF0
        public void ContainsKey(){} // RVA: 0x4721C10
        public void Contains(){} // RVA: 0x4721C30
        public void set_Item(){} // RVA: 0x4721E60
        public void Add(){} // RVA: 0x47220E0
        public void Remove(){} // RVA: 0x47221C0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x4720B10
        public void GetEnumerator(){} // RVA: 0x4720080
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4720B10
        public void FindNode(){} // RVA: 0x4722420
        public void Insert(){} // RVA: 0x47224B0
        public void Expand(){} // RVA: 0x47226A0
        public void Clear(){} // RVA: 0x47211E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x4722A60
        public void IsPrimeFromList(){} // RVA: 0x4721420
        public void GetNextPrime(){} // RVA: 0x4721590
        public void Assert(){} // RVA: 0x4721880
        public void .cctor(){} // RVA: 0x4722C50
        public void TryGetValue(){} // RVA: 0x4721CE0
        public void get_Count(){} // RVA: 0x47200E0
        public void get_Item(){} // RVA: 0x4721D80
        public void get_Keys(){} // RVA: 0x4720080
    }

    public class OperationRequest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OperationResponse : Object
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x6CA8C70
        public void ToString(){} // RVA: 0x6CA8CE0
        public void ToStringFull(){} // RVA: 0x6CA8E40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ParameterDictionary : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C86090
        public void op_Implicit(){} // RVA: 0x2C8D450
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Byte,System.Object>>.GetEnumerator(){} // RVA: 0x6C861F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6C86240
        public void GetEnumerator(){} // RVA: 0x6C86290
        public void get_Item(){} // RVA: 0x6C86340
        public void set_Item(){} // RVA: 0x6C863D0
        public void get_Count(){} // RVA: 0x6C86440
        public void Clear(){} // RVA: 0x6C86490
        public void Add(){} // RVA: 0x6C869F0
        public void Get(){} // RVA: 0x3183930
        public void ContainsKey(){} // RVA: 0x6C86AF0
        public void TryGetValue(){} // RVA: 0x3183C60
    }

    public class ParameterDictionary[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PeerBase : Object
    {
        // ── Methods ──
        public void get_Stats(){} // RVA: 0x1287960
        public void get_Listener(){} // RVA: 0x13F93E0
        public void get_LogLevel(){} // RVA: 0x23ADB30
        public void get_ServerAddress(){} // RVA: 0xD33E60
        public void set_ServerAddress(){} // RVA: 0xB708C0
        public void get_ProxyServerAddress(){} // RVA: 0xD05CA0
        public void set_ProxyServerAddress(){} // RVA: 0xD09D70
        public void get_peerConnectionState(){} // RVA: 0x6C86C50
        public void set_peerConnectionState(){} // RVA: 0x6C86C60
        public void TryUpdateConnectionState(){} // RVA: 0x6C86C70
        public void get_rttVarString(){} // RVA: 0x6C86CA0
        public void get_TimeoutVarianceCompensation(){} // RVA: 0x6C86D70
        public void get_DisconnectTimeout(){} // RVA: 0x6C86DD0
        public void get_PingInterval(){} // RVA: 0x67CAAA0
        public void get_ChannelCount(){} // RVA: 0x6C86DF0
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x87C130
        public void get_timeInt(){} // RVA: 0x6C86E10
        public void set_ServerFeatureFlags(){} // RVA: 0x6C86E40
        public void get_serverFeatureFlagsAvailable(){} // RVA: 0x6C86E80
        public void set_serverFeatureFlagsAvailable(){} // RVA: 0x6C86E90
        public void get_serverFeatureAck2Available(){} // RVA: 0x6C86EA0
        public void set_serverFeatureAck2Available(){} // RVA: 0x6C86EB0
        public void get_serverFeatureSyncReliableQueue(){} // RVA: 0x6C86EC0
        public void set_serverFeatureSyncReliableQueue(){} // RVA: 0x6C86ED0
        public void get_ServerMaxQueueableReliableCommands(){} // RVA: 0x6C86EE0
        public void set_ServerMaxQueueableReliableCommands(){} // RVA: 0x6C86EF0
        public void get_mtu(){} // RVA: 0x6C86F00
        public void get_IsIpv6(){} // RVA: 0x6C86F20
        public void .ctor(){} // RVA: 0x6C86F40
        public void Reset(){} // RVA: 0x6C874A0
        public void Connect(){} // RVA: 0x87D760
        public void GetHttpKeyValueString(){} // RVA: 0x6C87B20
        public void WriteInitRequest(){} // RVA: 0x6C87DE0
        public void WriteInitV3(){} // RVA: 0x6C884D0
        public void PrepareWebSocketUrl(){} // RVA: 0x6C88AF0
        public void OnInitResponse(){} // RVA: 0x6C88F90
        public void Disconnect(){} // RVA: 0x894750
        public void FetchServerTimestamp(){} // RVA: 0x894290
        public void IsTransportEncrypted(){} // RVA: 0x87D280
        public void EnqueuePhotonMessage(){} // RVA: 0x87FA90
        public void SerializeOperationToMessage(){} // RVA: 0x6C89030
        public void SendOutgoingCommands(){} // RVA: 0x87D280
        public void SendAcksOnly(){} // RVA: 0xB43320
        public void ReceiveIncomingCommands(){} // RVA: 0x899290
        public void DispatchIncomingCommands(){} // RVA: 0x87D280
        public void DeserializeMessageAndCallback(){} // RVA: 0x6C892E0
        public void UpdateRoundTripTimeAndVariance(){} // RVA: 0x6C8A040
        public void ExchangeKeysForEncryption(){} // RVA: 0x6C8A1C0
        public void DeriveSharedKey(){} // RVA: 0x6C8A820
        public void InitEncryption(){} // RVA: 0x6C8A9D0
        public void EnqueueActionForDispatch(){} // RVA: 0x6C8AE50
        public void EnqueueDebugReturn(){} // RVA: 0x6C8AFA0
        public void EnqueueStatusCallback(){} // RVA: 0x6C8B240
        public void get_NetworkSimulationSettings(){} // RVA: 0x114AC20
        public void NetworkSimRun(){} // RVA: 0x6C8B470
        public void .cctor(){} // RVA: 0x6C8B9F0
        public void <DeserializeMessageAndCallback>b__121_0(){} // RVA: 0x6C8BBD0
    }

    public class PhotonClientWebSocket : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C8BE10
        public void Connect(){} // RVA: 0x6C8BE90
        public void AsyncConnectAndReceive(){} // RVA: 0x6C8BFC0
        public void Disconnect(){} // RVA: 0x6C8D180
        public void Send(){} // RVA: 0x6C8D4F0
        public void Receive(){} // RVA: 0x6C8D9D0
    }

    public class PhotonCodes : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6C86BC0
    }

    public class PhotonHashtable : Dictionary`2
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6C77440
        public void .ctor(){} // RVA: 0x6C776E0
        public void get_Item(){} // RVA: 0x6C779C0
        public void set_Item(){} // RVA: 0x6C778F0
        public void Add(){} // RVA: 0x6C77A40
        public void ContainsKey(){} // RVA: 0x6C77B10
        public void GetEnumerator(){} // RVA: 0x6C77BD0
        public void ToString(){} // RVA: 0x6C77D10
    }

    public class PhotonPeer : Object
    {
        // ── Methods ──
        public void get_ClientSdkIdShifted(){} // RVA: 0x6C8DA10
        public void get_Version(){} // RVA: 0x6C8DA20
        public void get_UseAck2(){} // RVA: 0x6C8DDF0
        public void set_UseAck2(){} // RVA: 0x6C8DE00
        public void get_SerializationProtocolType(){} // RVA: 0x2244FB0
        public void set_SerializationProtocolType(){} // RVA: 0x22735B0
        public void get_SocketImplementation(){} // RVA: 0xB70160
        public void set_SocketImplementation(){} // RVA: 0xB44DC0
        public void get_SocketErrorCode(){} // RVA: 0x6C8DE10
        public void get_Listener(){} // RVA: 0xD05CA0
        public void set_Listener(){} // RVA: 0xD09D70
        public void get_PeerState(){} // RVA: 0x6C8DE40
        public void get_ReuseEventInstance(){} // RVA: 0xC02470
        public void set_ReuseEventInstance(){} // RVA: 0x6C8DEB0
        public void get_UseByteArraySlicePoolForEvents(){} // RVA: 0xEEA010
        public void get_WrapIncomingStructs(){} // RVA: 0xEEA480
        public void get_QuickResendAttempts(){} // RVA: 0xBFDA40
        public void set_QuickResendAttempts(){} // RVA: 0x6C8E030
        public void get_DisconnectTimeout(){} // RVA: 0x15443F0
        public void set_DisconnectTimeout(){} // RVA: 0x6C8E050
        public void get_CrcEnabled(){} // RVA: 0xE3F480
        public void set_CrcEnabled(){} // RVA: 0x6C8E060
        public void get_ServerAddress(){} // RVA: 0x6C8E0F0
        public void get_UsedProtocol(){} // RVA: 0x6C8E110
        public void get_TransportProtocol(){} // RVA: 0x1A1E0A0
        public void set_TransportProtocol(){} // RVA: 0x1A194B0
        public void set_IsSimulationEnabled(){} // RVA: 0x6C8E130
        public void get_NetworkSimulationSettings(){} // RVA: 0x6C8E2A0
        public void get_MaximumTransferUnit(){} // RVA: 0xD34720
        public void get_IsEncryptionAvailable(){} // RVA: 0x6C8E2D0
        public void get_PayloadEncryptorType(){} // RVA: 0xCD3320
        public void get_EncryptorType(){} // RVA: 0xB813B0
        public void set_EncryptorType(){} // RVA: 0x6C8E300
        public void get_ServerTimeInMilliseconds(){} // RVA: 0x6C8E4E0
        public void get_EnableServerTracing(){} // RVA: 0x2443C20
        public void get_ConnectionTime(){} // RVA: 0x6C8E530
        public void get_BytesIn(){} // RVA: 0x6C8E560
        public void get_BytesOut(){} // RVA: 0x6C8E580
        public void get_ByteCountCurrentDispatch(){} // RVA: 0x6C8E5A0
        public void get_ByteCountLastOperation(){} // RVA: 0x6C8E5C0
        public void get_PacketLossByCrc(){} // RVA: 0x6C8E5E0
        public void get_PacketLossByChallenge(){} // RVA: 0x6C8E600
        public void get_CountDiscarded(){} // RVA: 0x6C8E620
        public void set_CountDiscarded(){} // RVA: 0x6C8E630
        public void set_DeltaUnreliableNumber(){} // RVA: 0x158BEC0
        public void get_QueuedOutgoingCommands(){} // RVA: 0x6C8E640
        public void get_Stats(){} // RVA: 0xBAE340
        public void set_Stats(){} // RVA: 0xBAE350
        public void .ctor(){} // RVA: 0x6C8EC70
        public void Connect(){} // RVA: 0x6C8ECF0
        public void CreatePeerBase(){} // RVA: 0x6C8F9A0
        public void Disconnect(){} // RVA: 0x6C8FBB0
        public void FetchServerTimestamp(){} // RVA: 0x6C8FE00
        public void EstablishEncryption(){} // RVA: 0x6C8FE30
        public void InitDatagramEncryption(){} // RVA: 0x6C8FF10
        public void InitPayloadEncryption(){} // RVA: 0xCD3600
        public void Service(){} // RVA: 0x6C90350
        public void SendOutgoingCommands(){} // RVA: 0x6C903A0
        public void SendAcksOnly(){} // RVA: 0x6C90550
        public void DispatchIncomingCommands(){} // RVA: 0x6C90690
        public void SendOperation(){} // RVA: 0x6C90860
        public void RegisterType(){} // RVA: 0x6C90CC0
        public void .cctor(){} // RVA: 0x6C90D50
        public void <EstablishEncryption>b__202_0(){} // RVA: 0x6C90DB0
    }

    public class PhotonSocket : Object
    {
        // ── Methods ──
        public void get_Listener(){} // RVA: 0x6C90DE0
        public void get_MTU(){} // RVA: 0x6C90E10
        public void get_State(){} // RVA: 0x2244FB0
        public void set_State(){} // RVA: 0x22735B0
        public void get_SocketErrorCode(){} // RVA: 0xFEAE90
        public void set_SocketErrorCode(){} // RVA: 0x1269760
        public void get_Connected(){} // RVA: 0x6C90E40
        public void get_LogLevel(){} // RVA: 0x6C90E50
        public void get_ServerAddress(){} // RVA: 0xD33E60
        public void set_ServerAddress(){} // RVA: 0xB708C0
        public void get_ProxyServerAddress(){} // RVA: 0xD05CA0
        public void set_ProxyServerAddress(){} // RVA: 0xD09D70
        public void set_ServerIpAddress(){} // RVA: 0xB6A8C0
        public void get_ServerPort(){} // RVA: 0xBE5890
        public void set_ServerPort(){} // RVA: 0xBE58A0
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x1FAA110
        public void set_AddressResolvedAsIpv6(){} // RVA: 0x1FABCC0
        public void set_UrlProtocol(){} // RVA: 0xCA4DF0
        public void set_UrlPath(){} // RVA: 0xC0FFD0
        public void get_SerializationProtocol(){} // RVA: 0x6C90E80
        public void .ctor(){} // RVA: 0x6C91020
        public void Connect(){} // RVA: 0x6C91160
        public void Disconnect(){} // RVA: 0x87D280
        public void Send(){} // RVA: 0x885970
        public void Receive(){} // RVA: 0x87D050
        public void HandleReceivedDatagram(){} // RVA: 0x6C91500
        public void ReportDebugOfLevel(){} // RVA: 0x6C91530
        public void EnqueueDebugReturn(){} // RVA: 0x6C91560
        public void HandleException(){} // RVA: 0x6C91580
        public void TryParseAddress(){} // RVA: 0x6C91630
        public void IpAddressTryParse(){} // RVA: 0x6C91B00
        public void GetIpAddresses(){} // RVA: 0x6C91E00
        public void AddressSortComparer(){} // RVA: 0x6C925A0
        public void <HandleException>b__58_0(){} // RVA: 0x6C92600
    }

    public class Pool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x895FE0
        public void CreatePoolItems(){} // RVA: 0x8944F0
        public void Release(){} // RVA: 0xA94080
        public void Acquire(){} // RVA: 0xA94080
    }

    public class Pool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4864570
        public void CreatePoolItems(){} // RVA: 0x4864740
        public void Release(){} // RVA: 0x48647C0
        public void Acquire(){} // RVA: 0x4864970
    }

    public class Pool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4864570
        public void CreatePoolItems(){} // RVA: 0x4864740
        public void Release(){} // RVA: 0x48647C0
        public void Acquire(){} // RVA: 0x4864970
    }

    public class Pool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4864570
        public void CreatePoolItems(){} // RVA: 0x4864740
        public void Release(){} // RVA: 0x48647C0
        public void Acquire(){} // RVA: 0x4864970
    }

    public class PreserveAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Protocol : Object
    {
        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x87C0A0
        public void get_VersionBytes(){} // RVA: 0x87C0A0
        public void Serialize(){} // RVA: 0x6C92B10
        public void SerializeShort(){} // RVA: 0x89B2D0
        public void SerializeString(){} // RVA: 0x89AA50
        public void SerializeEventData(){} // RVA: 0x89AA50
        public void SerializeOperationRequest(){} // RVA: 0x89A670
        public void SerializeOperationResponse(){} // RVA: 0x89AA50
        public void Deserialize(){} // RVA: 0x6C92BB0
        public void DeserializeShort(){} // RVA: 0x87C460
        public void DeserializeByte(){} // RVA: 0x87D350
        public void DeserializeEventData(){} // RVA: 0x88E290
        public void DeserializeOperationRequest(){} // RVA: 0x88B6A0
        public void DeserializeOperationResponse(){} // RVA: 0x88B6A0
        public void DeserializeDisconnectMessage(){} // RVA: 0x87C540
        public void DeserializeMessage(){} // RVA: 0x6C92CA0
        public void TryRegisterType(){} // RVA: 0x6C92D00
        public void .ctor(){} // RVA: 0x6C93060
        public void .cctor(){} // RVA: 0x6C93100
    }

    public class Protocol16 : Protocol
    {
        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x6C932A0
        public void get_VersionBytes(){} // RVA: 0xB465B0
        public void SerializeCustom(){} // RVA: 0x6C932E0
        public void DeserializeCustom(){} // RVA: 0x6C93680
        public void GetTypeOfCode(){} // RVA: 0x6C939A0
        public void GetCodeOfType(){} // RVA: 0x6C93E00
        public void CreateArrayByType(){} // RVA: 0x6C941C0
        public void SerializeOperationRequest(){} // RVA: 0x6C94230
        public void DeserializeOperationRequest(){} // RVA: 0x6C94310
        public void SerializeOperationResponse(){} // RVA: 0x6C94400
        public void DeserializeDisconnectMessage(){} // RVA: 0x6C94590
        public void DeserializeOperationResponse(){} // RVA: 0x6C94750
        public void SerializeEventData(){} // RVA: 0x6C94930
        public void DeserializeEventData(){} // RVA: 0x6C94A10
        public void SerializeParameterTable(){} // RVA: 0x6C94AD0
        public void DeserializeParameterDictionary(){} // RVA: 0x6C94E80
        public void Serialize(){} // RVA: 0x6C94FB0
        public void SerializeByte(){} // RVA: 0x6C95BA0
        public void SerializeBoolean(){} // RVA: 0x6C95C50
        public void SerializeShort(){} // RVA: 0x6C95D00
        public void SerializeLengthAsShort(){} // RVA: 0x6C95F20
        public void SerializeInteger(){} // RVA: 0x6C96130
        public void SerializeLong(){} // RVA: 0x6C96380
        public void SerializeFloat(){} // RVA: 0x6C96810
        public void SerializeDouble(){} // RVA: 0x6C96D60
        public void SerializeString(){} // RVA: 0x6C97200
        public void SerializeArray(){} // RVA: 0x6C973E0
        public void SerializeByteArray(){} // RVA: 0x6C97AB0
        public void SerializeByteArraySegment(){} // RVA: 0x6C97B70
        public void SerializeIntArrayOptimized(){} // RVA: 0x6C97C50
        public void SerializeObjectArray(){} // RVA: 0x6C97EA0
        public void SerializeHashTable(){} // RVA: 0x6C980F0
        public void SerializeDictionary(){} // RVA: 0x6C98470
        public void SerializeDictionaryHeader(){} // RVA: 0x6C98570
        public void SerializeDictionaryElements(){} // RVA: 0x6C98940
        public void Deserialize(){} // RVA: 0x6C98C80
        public void DeserializeByte(){} // RVA: 0x6C994F0
        public void DeserializeBoolean(){} // RVA: 0x6C99510
        public void DeserializeShort(){} // RVA: 0x6C99540
        public void DeserializeInteger(){} // RVA: 0x6C998B0
        public void DeserializeLong(){} // RVA: 0x6C99C40
        public void DeserializeFloat(){} // RVA: 0x6C9A040
        public void DeserializeDouble(){} // RVA: 0x6C9A440
        public void DeserializeString(){} // RVA: 0x6C9A8D0
        public void DeserializeArray(){} // RVA: 0x6C9AA00
        public void DeserializeByteArray(){} // RVA: 0x6C9B430
        public void DeserializeIntArray(){} // RVA: 0x6C9B4F0
        public void DeserializeStringArray(){} // RVA: 0x6C9B5D0
        public void DeserializeObjectArray(){} // RVA: 0x6C9B700
        public void DeserializeHashTable(){} // RVA: 0x6C9B890
        public void DeserializeDictionary(){} // RVA: 0x6C9BA00
        public void DeserializeDictionaryArray(){} // RVA: 0x6C9BDD0
        public void DeserializeDictionaryType(){} // RVA: 0x6C9C080
        public void .ctor(){} // RVA: 0x6C9C3B0
        public void .cctor(){} // RVA: 0x6C9C830
    }

    public class Protocol18 : Protocol
    {
        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x6C9C9E0
        public void get_VersionBytes(){} // RVA: 0xB465B0
        public void Serialize(){} // RVA: 0x6C9CA20
        public void SerializeShort(){} // RVA: 0x6C9CAA0
        public void SerializeString(){} // RVA: 0x6C9CB10
        public void Deserialize(){} // RVA: 0x6C9CB20
        public void DeserializeShort(){} // RVA: 0x6C9CB40
        public void DeserializeByte(){} // RVA: 0x6C994F0
        public void GetAllowedDictionaryKeyTypes(){} // RVA: 0x6C9CBC0
        public void GetClrArrayType(){} // RVA: 0x6C9CD20
        public void GetCodeOfType(){} // RVA: 0x6C9D1D0
        public void GetCodeOfTypeCode(){} // RVA: 0x6C9D9B0
        public void Read(){} // RVA: 0x6C9DAA0
        public void ReadBoolean(){} // RVA: 0x6C99510
        public void ReadByte(){} // RVA: 0x6C994F0
        public void ReadInt16(){} // RVA: 0x6C9CB40
        public void ReadUShort(){} // RVA: 0x6C9CB40
        public void ReadSingle(){} // RVA: 0x6C9ED80
        public void ReadDouble(){} // RVA: 0x6C9EE20
        public void ReadNonAllocByteArray(){} // RVA: 0x6C9EEC0
        public void ReadByteArray(){} // RVA: 0x6C9EF60
        public void ReadCustomType(){} // RVA: 0x6C9F010
        public void DeserializeEventData(){} // RVA: 0x6C9F3C0
        public void ReadParameterDictionary(){} // RVA: 0x6C9F600
        public void ReadHashtable(){} // RVA: 0x6C9F730
        public void DeserializeOperationRequest(){} // RVA: 0x6C9F920
        public void DeserializeOperationResponse(){} // RVA: 0x6C9FA10
        public void DeserializeDisconnectMessage(){} // RVA: 0x6C9FC10
        public void ReadString(){} // RVA: 0x6C9FDF0
        public void ReadCustomTypeArray(){} // RVA: 0x6C9FEA0
        public void ReadDictionaryType(){} // RVA: 0x6CA0780
        public void GetDictArrayType(){} // RVA: 0x6CA0A60
        public void ReadDictionary(){} // RVA: 0x6CA0B60
        public void ReadDictionaryElements(){} // RVA: 0x6CA0D80
        public void ReadObjectArray(){} // RVA: 0x6CA0F00
        public void ReadBooleanArray(){} // RVA: 0x6CA1080
        public void ReadInt16Array(){} // RVA: 0x6CA1300
        public void ReadSingleArray(){} // RVA: 0x6CA1400
        public void ReadDoubleArray(){} // RVA: 0x6CA14C0
        public void ReadStringArray(){} // RVA: 0x6CA1580
        public void ReadHashtableArray(){} // RVA: 0x6CA1720
        public void ReadDictionaryArray(){} // RVA: 0x6CA18B0
        public void ReadArrayInArray(){} // RVA: 0x6CA1C40
        public void ReadInt1(){} // RVA: 0x6CA1DA0
        public void ReadInt2(){} // RVA: 0x6CA1DE0
        public void ReadCompressedInt32(){} // RVA: 0x6CA1EA0
        public void ReadCompressedUInt32(){} // RVA: 0x6CA1EC0
        public void ReadCompressedInt64(){} // RVA: 0x6CA2160
        public void ReadCompressedUInt64(){} // RVA: 0x6CA2250
        public void ReadCompressedInt32Array(){} // RVA: 0x6CA2330
        public void ReadCompressedInt64Array(){} // RVA: 0x6CA23F0
        public void DecodeZigZag32(){} // RVA: 0x6CA24A0
        public void DecodeZigZag64(){} // RVA: 0x6CA24B0
        public void Write(){} // RVA: 0x6CA24C0
        public void SerializeEventData(){} // RVA: 0x6CA3AC0
        public void WriteParameterTable(){} // RVA: 0x6CA3BA0
        public void SerializeOperationRequest(){} // RVA: 0x6CA3FA0
        public void SerializeOperationResponse(){} // RVA: 0x6CA4080
        public void WriteByte(){} // RVA: 0x6CA4230
        public void WriteBoolean(){} // RVA: 0x6CA42C0
        public void WriteUShort(){} // RVA: 0x6CA4360
        public void WriteInt16(){} // RVA: 0x6C9CAA0
        public void WriteDouble(){} // RVA: 0x6CA4390
        public void WriteSingle(){} // RVA: 0x6CA4720
        public void WriteString(){} // RVA: 0x6CA4AB0
        public void WriteHashtable(){} // RVA: 0x6CA4C60
        public void WriteByteArray(){} // RVA: 0x6CA4F80
        public void WriteArraySegmentByte(){} // RVA: 0x6CA5030
        public void WriteByteArraySlice(){} // RVA: 0x6CA5180
        public void WriteInt32ArrayCompressed(){} // RVA: 0x6CA5260
        public void WriteInt64ArrayCompressed(){} // RVA: 0x6CA5340
        public void WriteBoolArray(){} // RVA: 0x6CA5420
        public void WriteInt16Array(){} // RVA: 0x6CA56F0
        public void WriteSingleArray(){} // RVA: 0x6CA57D0
        public void WriteDoubleArray(){} // RVA: 0x6CA58C0
        public void WriteStringArray(){} // RVA: 0x6CA59B0
        public void WriteObjectArray(){} // RVA: 0x6CA5B70
        public void WriteArrayInArray(){} // RVA: 0x6CA5D90
        public void WriteCustomTypeBody(){} // RVA: 0x6CA5ED0
        public void WriteCustomType(){} // RVA: 0x6CA6170
        public void WriteCustomTypeArray(){} // RVA: 0x6CA6630
        public void WriteArrayHeader(){} // RVA: 0x6CA6CA0
        public void WriteDictionaryElements(){} // RVA: 0x6CA6E00
        public void WriteDictionary(){} // RVA: 0x6CA70D0
        public void WriteDictionaryHeader(){} // RVA: 0x6CA7210
        public void WriteArrayType(){} // RVA: 0x6CA79C0
        public void WriteHashtableArray(){} // RVA: 0x6CA7E20
        public void WriteDictionaryArray(){} // RVA: 0x6CA7F70
        public void WriteIntLength(){} // RVA: 0x6CA80C0
        public void WriteCompressedInt32(){} // RVA: 0x6CA80D0
        public void WriteCompressedInt64(){} // RVA: 0x6CA8280
        public void WriteCompressedUInt32(){} // RVA: 0x6CA85F0
        public void WriteCompressedUInt64(){} // RVA: 0x6CA8660
        public void EncodeZigZag32(){} // RVA: 0x6CA8870
        public void EncodeZigZag64(){} // RVA: 0x6CA8880
        public void .ctor(){} // RVA: 0x6CA8890
        public void .cctor(){} // RVA: 0x6CA8B90
    }

    public class SendOptions : ValueType
    {
        // ── Methods ──
        public void get_Reliability(){} // RVA: 0x8E53D0
        public void set_Reliability(){} // RVA: 0x8E53E0
        public void .cctor(){} // RVA: 0x6CA9C80
    }

    public class SerializationProtocolFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x6C92800
    }

    public class SerializeStreamMethod : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3AF90
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class SimulationItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C84E30
        public void get_Delay(){} // RVA: 0x1065D50
    }

    public class SocketTcp : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CA9CF0
        public void Finalize(){} // RVA: 0x6CA9E10
        public void Dispose(){} // RVA: 0x6CA9E50
        public void Connect(){} // RVA: 0x6CA9F60
        public void Disconnect(){} // RVA: 0x6CAA1D0
        public void Send(){} // RVA: 0x6CAA410
        public void Receive(){} // RVA: 0x2344860
        public void DnsAndConnect(){} // RVA: 0x6CAA710
        public void ReceiveLoop(){} // RVA: 0x6CAAE20
    }

    public class SocketTcpAsync : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CAB7D0
        public void Finalize(){} // RVA: 0x6CAB8F0
        public void Dispose(){} // RVA: 0x6CAB930
        public void Connect(){} // RVA: 0x6CABA50
        public void Disconnect(){} // RVA: 0x6CABCC0
        public void Send(){} // RVA: 0x6CABF30
        public void Receive(){} // RVA: 0x2344860
        public void DnsAndConnect(){} // RVA: 0x6CAC450
        public void ReceiveAsync(){} // RVA: 0x6CACF60
    }

    public class SocketUdp : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CAD770
        public void Finalize(){} // RVA: 0x6CAD900
        public void Dispose(){} // RVA: 0x6CAD940
        public void Connect(){} // RVA: 0x6CADA60
        public void Disconnect(){} // RVA: 0x6CADCD0
        public void Send(){} // RVA: 0x6CADF40
        public void Receive(){} // RVA: 0x2344860
        public void DnsAndConnect(){} // RVA: 0x6CAEA70
        public void ReceiveLoop(){} // RVA: 0x6CAF0D0
    }

    public class SocketUdpAsync : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CAF7E0
        public void Finalize(){} // RVA: 0x6CAB8F0
        public void Dispose(){} // RVA: 0x6CAB930
        public void Connect(){} // RVA: 0x6CAF900
        public void Disconnect(){} // RVA: 0x6CAFB70
        public void Send(){} // RVA: 0x6CAFDE0
        public void Receive(){} // RVA: 0x2344860
        public void DnsAndConnect(){} // RVA: 0x6CB0330
        public void StartReceive(){} // RVA: 0x6CB0880
        public void OnReceive(){} // RVA: 0x6CB0B00
    }

    public class StreamBuffer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CB14F0
        public void ToArray(){} // RVA: 0x6CB1560
        public void Compact(){} // RVA: 0x6CB15D0
        public void GetBuffer(){} // RVA: 0xB465B0
        public void GetBufferAndAdvance(){} // RVA: 0x6CB1650
        public void get_Length(){} // RVA: 0x116A650
        public void get_Position(){} // RVA: 0xB8F8F0
        public void set_Position(){} // RVA: 0x6CB1690
        public void get_Available(){} // RVA: 0x6CB16B0
        public void Reset(){} // RVA: 0x6CB16C0
        public void Seek(){} // RVA: 0x6CB16D0
        public void SetLength(){} // RVA: 0x6CB17F0
        public void SetCapacityMinimum(){} // RVA: 0x6CB1820
        public void Read(){} // RVA: 0x6CB1830
        public void Write(){} // RVA: 0x6CB1890
        public void ReadByte(){} // RVA: 0x6CB1910
        public void WriteByte(){} // RVA: 0x6CB1A00
        public void WriteBytes(){} // RVA: 0x6CB1A60
        public void CheckSize(){} // RVA: 0x6CB1AF0
    }

    public class StreamBuffer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SupportClass : Object
    {
        // ── Methods ──
        public void WriteStackTrace(){} // RVA: 0x6CB1C00
        public void DictionaryToString(){} // RVA: 0x6CB2740
        public void ByteArrayToString(){} // RVA: 0x6CB31E0
        public void InitializeTable(){} // RVA: 0x6CB3210
        public void CalculateCrc(){} // RVA: 0x6CB3550
    }

    public class TPeer : PeerBase
    {
        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x6CB3800
        public void .ctor(){} // RVA: 0x6CB3850
        public void IsTransportEncrypted(){} // RVA: 0x6CB3A80
        public void Reset(){} // RVA: 0x6CB3A90
        public void Connect(){} // RVA: 0x6CB3C20
        public void Disconnect(){} // RVA: 0x6CB4080
        public void FetchServerTimestamp(){} // RVA: 0x6CB4300
        public void EnqueueInit(){} // RVA: 0x6CB4440
        public void DispatchIncomingCommands(){} // RVA: 0x6CB45E0
        public void SendOutgoingCommands(){} // RVA: 0x6CB4AE0
        public void SendAcksOnly(){} // RVA: 0x6CB4F90
        public void EnqueuePhotonMessage(){} // RVA: 0x6CB5000
        public void EnqueueMessageAsPayload(){} // RVA: 0x6CB5030
        public void SendPing(){} // RVA: 0x6CB5370
        public void SendData(){} // RVA: 0x6CB58B0
        public void ReceiveIncomingCommands(){} // RVA: 0x6CB5A40
        public void ReadPingResult(){} // RVA: 0x6CB6080
        public void .cctor(){} // RVA: 0x6CB61B0
    }

    public class TrafficStats : TrafficStatsBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBE2C70
        public void get_LastReceiveTimestamp(){} // RVA: 0x19C6270
        public void set_LastReceiveTimestamp(){} // RVA: 0xCE5450
        public void get_LastDispatchTimestamp(){} // RVA: 0x21EA4F0
        public void set_LastDispatchTimestamp(){} // RVA: 0x26432E0
        public void get_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x23ADD10
        public void set_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x23B2A80
        public void set_LastDispatchDuration(){} // RVA: 0x6CB6340
        public void get_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0xD34760
        public void set_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0xD34750
        public void DispatchIncomingCommandsCalled(){} // RVA: 0x6CB6350
        public void SendOutgoingCommandsCalled(){} // RVA: 0x6CB6370
        public void ToString(){} // RVA: 0x6CB63A0
    }

    public class TrafficStatsBase : Object
    {
        // ── Methods ──
        public void get_BytesIn(){} // RVA: 0xB5DBF0
        public void set_BytesIn(){} // RVA: 0x2230E30
        public void get_BytesOut(){} // RVA: 0xB465B0
        public void set_BytesOut(){} // RVA: 0x15428E0
        public void get_PackagesIn(){} // RVA: 0xFEAE90
        public void set_PackagesIn(){} // RVA: 0x1269760
        public void get_PackagesOut(){} // RVA: 0x15AF000
        public void set_PackagesOut(){} // RVA: 0x1FAA840
        public void get_UdpFragmentsIn(){} // RVA: 0x1065D50
        public void set_UdpFragmentsIn(){} // RVA: 0x13233D0
        public void get_UdpFragmentsOut(){} // RVA: 0x1AE5AC0
        public void set_UdpFragmentsOut(){} // RVA: 0x23E55F0
        public void get_UdpUnreliableCommandsSent(){} // RVA: 0xB9E080
        public void set_UdpUnreliableCommandsSent(){} // RVA: 0xB9E090
        public void get_UdpReliableCommandsSent(){} // RVA: 0xE9CE60
        public void set_UdpReliableCommandsSent(){} // RVA: 0xEA1260
        public void get_UdpReliableCommandsResent(){} // RVA: 0x18A0130
        public void set_UdpReliableCommandsResent(){} // RVA: 0x189D3F0
        public void set_UdpReliableCommandsInFlight(){} // RVA: 0x25671C0
        public void get_DispatchIncomingCommandsCalls(){} // RVA: 0xBE5850
        public void set_DispatchIncomingCommandsCalls(){} // RVA: 0xBE5860
        public void get_SendOutgoingCommandsCalls(){} // RVA: 0xBE5870
        public void set_SendOutgoingCommandsCalls(){} // RVA: 0xBE5880
        public void get_RoundtripTime(){} // RVA: 0xBBF8F0
        public void set_RoundtripTime(){} // RVA: 0x20633C0
        public void get_RoundtripTimeVariance(){} // RVA: 0xBE58B0
        public void set_RoundtripTimeVariance(){} // RVA: 0xE9E640
        public void set_LastRoundtripTime(){} // RVA: 0xEA1CE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnknownType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Version : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6CB6AC0
    }

}