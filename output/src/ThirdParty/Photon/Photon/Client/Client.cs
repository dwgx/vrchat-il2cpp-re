// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client
// Classes: 56
// Methods: 776

namespace ThirdParty.Photon.Photon.Client
{
    public class ByteArraySlice : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFF4AB0
        public void Dispose(){} // RVA: 0x7ADFF4BE0
        public void Release(){} // RVA: 0x7ADFF4C20
    }

    public class ByteArraySlicePool : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFF4C60
        public void Acquire(){} // RVA: 0x7ADFF4E80
        public void PopOrCreate(){} // RVA: 0x7ADFF5280
        public void Release(){} // RVA: 0x7ADFF5560
    }

    public class ByteArraySlice[] : Array
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

    public class CustomType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE011110
    }

    public class DeserializeStreamMethod : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE010FA0
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class DictionaryEntryEnumerator : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A77DC300
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7A7E658B0
        public void get_Current(){} // RVA: 0x7A7E65A00
        public void MoveNext(){} // RVA: 0x7A7E65B30
        public void Reset(){} // RVA: 0x7A7E65B70
        public void Dispose(){} // RVA: 0x7A75F4910
    }

    public class DisconnectMessage : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class EnetChannel : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFF6A30
        public void AddSequencedIfNew(){} // RVA: 0x7ADFF6F20
        public void TryGetFragment(){} // RVA: 0x7ADFF6FE0
        public void RemoveFragment(){} // RVA: 0x7ADFF7060
        public void clearAll(){} // RVA: 0x7ADFF70D0
        public void QueueIncomingReliableUnsequenced(){} // RVA: 0x7ADFF73E0
        public void ApplySequenceNumberModifier(){} // RVA: 0x7ADFF7590
        public void Received(){} // RVA: 0x7ADFF75E0
        public void GetGapBlock(){} // RVA: 0x7ADFF7840
    }

    public class EnetChannel[] : Array
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

    public class EnetPeer : PeerBase
    {
        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7ADFF7C20
        public void get_SendWindowUpdateRequired(){} // RVA: 0x7ADFF7F10
        public void set_SendWindowUpdateRequired(){} // RVA: 0x7ADFF7F30
        public void get_DatagramEncryptedConnection(){} // RVA: 0x7ADFF7F50
        public void set_DatagramEncryptedConnection(){} // RVA: 0x7ADFF7F70
        public void get_useAck2(){} // RVA: 0x7ADFF7F90
        public void .ctor(){} // RVA: 0x7ADFF7FC0
        public void IsTransportEncrypted(){} // RVA: 0x7ADFF7F50
        public void Reset(){} // RVA: 0x7ADFF8950
        public void ApplyRandomizedSequenceNumbers(){} // RVA: 0x7ADFF9170
        public void GetChannel(){} // RVA: 0x7ADFF9340
        public void Connect(){} // RVA: 0x7ADFF93A0
        public void Disconnect(){} // RVA: 0x7ADFF9470
        public void FetchServerTimestamp(){} // RVA: 0x7ADFF9940
        public void DispatchCommandQueue(){} // RVA: 0x7ADFF9A60
        public void DispatchIncomingCommands(){} // RVA: 0x7ADFF9B40
        public void GetFragmentLength(){} // RVA: 0x7ADFFA630
        public void CalculatePacketSize(){} // RVA: 0x7ADFFA710
        public void CalculateInitialOffset(){} // RVA: 0x7ADFFA7A0
        public void SendAcksOnly(){} // RVA: 0x7ADFFA7F0
        public void SendOutgoingCommands(){} // RVA: 0x7ADFFA810
        public void UpdateSendWindow(){} // RVA: 0x7ADFFB850
        public void EnqueuePhotonMessage(){} // RVA: 0x7ADFFC1A0
        public void CreateAndEnqueueCommand(){} // RVA: 0x7ADFFC1F0
        public void SerializeAckToBuffer(){} // RVA: 0x7ADFFC7B0
        public void SerializeToBuffer(){} // RVA: 0x7ADFFCC90
        public void SerializeCommandToBuffer(){} // RVA: 0x7ADFFCDF0
        public void SendData(){} // RVA: 0x7ADFFCFD0
        public void SendToSocket(){} // RVA: 0x7ADFFD340
        public void SendDataEncrypted(){} // RVA: 0x7ADFFD4B0
        public void QueueSentCommand(){} // RVA: 0x7ADFFD7B0
        public void QueueOutgoingReliableCommand(){} // RVA: 0x7ADFFDB30
        public void QueueOutgoingUnreliableCommand(){} // RVA: 0x7ADFFDD30
        public void QueueOutgoingAcknowledgement(){} // RVA: 0x7ADFFDFA0
        public void ReceiveIncomingCommands(){} // RVA: 0x7ADFFE400
        public void ExecuteCommand(){} // RVA: 0x7ADFFEFD0
        public void QueueIncomingCommand(){} // RVA: 0x7AE000740
        public void RemoveSentReliableCommand(){} // RVA: 0x7AE000FB0
        public void .cctor(){} // RVA: 0x7AE001410
        public void <ExecuteCommand>b__78_0(){} // RVA: 0x7AE0014F0
    }

    public class EventData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE027970
        public void get_Item(){} // RVA: 0x7AE027A20
        public void get_Sender(){} // RVA: 0x7AE027A90
        public void set_Sender(){} // RVA: 0x7A94794D0
        public void get_CustomData(){} // RVA: 0x7AE027B10
        public void Reset(){} // RVA: 0x7AE027B90
        public void ToString(){} // RVA: 0x7AE027C10
    }

    public class EventData[] : Array
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

    public class IPhotonPeerListener
    {
        // ── Methods ──
        public void DebugReturn(){} // RVA: 0x7A7E19310
        public void OnOperationResponse(){} // RVA: 0x7A7E18800
        public void OnStatusChanged(){} // RVA: 0x7A7E189D0
        public void OnEvent(){} // RVA: 0x7A7E18800
        public void OnMessage(){} // RVA: 0x7A7E19310
        public void OnDisconnectMessage(){} // RVA: 0x7A7E18800
    }

    public class ITrafficRecorder
    {
        // ── Methods ──
        public void Record(){} // RVA: 0x7A7E1F930
    }

    public class InvalidDataException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE01B190
    }

    public class MessageProtocol : Object
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7AE027E70
        public void Deserialize(){} // RVA: 0x7AE028130
        public void .cctor(){} // RVA: 0x7AE028430
    }

    public class NCommand : Object
    {
        // ── Methods ──
        public void get_SizeOfPayload(){} // RVA: 0x7AE001650
        public void get_IsFlaggedUnsequenced(){} // RVA: 0x7AE001670
        public void get_IsFlaggedReliable(){} // RVA: 0x7AE001680
        public void CreateAck(){} // RVA: 0x7AE0016A0
        public void CreateAck2(){} // RVA: 0x7AE0018D0
        public void Initialize(){} // RVA: 0x7AE001ED0
        public void Reset(){} // RVA: 0x7AE002500
        public void SerializeHeader(){} // RVA: 0x7AE002540
        public void Serialize(){} // RVA: 0x7AE0029D0
        public void FreePayload(){} // RVA: 0x7AE0029F0
        public void CompareTo(){} // RVA: 0x7AE002AD0
        public void ToString(){} // RVA: 0x7AE002B10
        public void .ctor(){} // RVA: 0x7AE003370
    }

    public class NCommand[] : Array
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

    public class NetworkSimulationSet : Object
    {
        // ── Methods ──
        public void get_IsSimulationEnabled(){} // RVA: 0x7A81A2200
        public void set_IsSimulationEnabled(){} // RVA: 0x7AE003380
        public void set_OutgoingLossPercentage(){} // RVA: 0x7A9746990
        public void set_IncomingLossPercentage(){} // RVA: 0x7A8810F60
        public void set_LostPackagesOut(){} // RVA: 0x7A8178B80
        public void set_LostPackagesIn(){} // RVA: 0x7A9B79240
        public void ToString(){} // RVA: 0x7AE003FB0
        public void .ctor(){} // RVA: 0x7AE004300
    }

    public class NonAllocDictionary`2 : Object
    {
        // ── Methods ──
        public void get_Keys(){} // RVA: 0x7A8051B10
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0x7A7E00680
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0x7A7E00680
        public void get_Count(){} // RVA: 0x7A7E00710
        public void get_IsReadOnly(){} // RVA: 0x7A7E01900
        public void .ctor(){} // RVA: 0x7A7E189D0
        public void ContainsKey(){} // RVA: 0x7A8051B10
        public void Contains(){} // RVA: 0x7A8051B10
        public void TryGetValue(){} // RVA: 0x7A8051B10
        public void get_Item(){} // RVA: 0x7A8051B10
        public void set_Item(){} // RVA: 0x7A8051B10
        public void Add(){} // RVA: 0x7A8051B10
        public void Remove(){} // RVA: 0x7A8051B10
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x7A7E00680
        public void GetEnumerator(){} // RVA: 0x7A8051B10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void FindNode(){} // RVA: 0x7A8051B10
        public void Insert(){} // RVA: 0x7A8051B10
        public void Expand(){} // RVA: 0x7A7E18770
        public void Clear(){} // RVA: 0x7A7E18770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x7A7E1D590
        public void IsPrimeFromList(){} // RVA: 0x7A7E023D0
        public void GetNextPrime(){} // RVA: 0x7A7E07D40
        public void Assert(){} // RVA: 0x7A7E18C70
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class NonAllocDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA8B650
        public void get_Keys(){} // RVA: 0x7ABA8B5E0
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0x7A8154D80
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0x7A8292C30
        public void get_Count(){} // RVA: 0x7ABA8B640
        public void get_IsReadOnly(){} // RVA: 0x7A80FD690
        public void ContainsKey(){} // RVA: 0x7ABA8B850
        public void Contains(){} // RVA: 0x7ABA8B870
        public void TryGetValue(){} // RVA: 0x7ABA8B920
        public void get_Item(){} // RVA: 0x7ABA8B9C0
        public void set_Item(){} // RVA: 0x7ABA8BAA0
        public void Add(){} // RVA: 0x7ABA8BD20
        public void Remove(){} // RVA: 0x7ABA8BF90
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x7ABA8C070
        public void GetEnumerator(){} // RVA: 0x7ABA8B5E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ABA8C070
        public void FindNode(){} // RVA: 0x7ABA8C100
        public void Insert(){} // RVA: 0x7ABA8C190
        public void Expand(){} // RVA: 0x7ABA8C380
        public void Clear(){} // RVA: 0x7ABA8C740
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x7ABA8C7A0
        public void IsPrimeFromList(){} // RVA: 0x7ABA8C980
        public void GetNextPrime(){} // RVA: 0x7ABA8CAF0
        public void Assert(){} // RVA: 0x7ABA8CDE0
        public void .cctor(){} // RVA: 0x7ABA8CE40
    }

    public class NonAllocDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA8D310
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0x7A8154D80
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0x7A8292C30
        public void get_IsReadOnly(){} // RVA: 0x7A80FD690
        public void ContainsKey(){} // RVA: 0x7ABA8D510
        public void Contains(){} // RVA: 0x7ABA8D530
        public void set_Item(){} // RVA: 0x7ABA8D760
        public void Add(){} // RVA: 0x7ABA8D9E0
        public void Remove(){} // RVA: 0x7ABA8DAC0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x7ABA8C070
        public void GetEnumerator(){} // RVA: 0x7ABA8B5E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ABA8C070
        public void FindNode(){} // RVA: 0x7ABA8DD20
        public void Insert(){} // RVA: 0x7ABA8DDB0
        public void Expand(){} // RVA: 0x7ABA8DFA0
        public void Clear(){} // RVA: 0x7ABA8C740
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x7ABA8E360
        public void IsPrimeFromList(){} // RVA: 0x7ABA8C980
        public void GetNextPrime(){} // RVA: 0x7ABA8CAF0
        public void Assert(){} // RVA: 0x7ABA8CDE0
        public void .cctor(){} // RVA: 0x7ABA8E550
        public void TryGetValue(){} // RVA: 0x7ABA8D5E0
        public void get_Count(){} // RVA: 0x7ABA8B640
        public void get_Item(){} // RVA: 0x7ABA8D680
        public void get_Keys(){} // RVA: 0x7ABA8B5E0
    }

    public class OperationRequest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class OperationResponse : Object
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7AE027540
        public void ToString(){} // RVA: 0x7AE0275B0
        public void ToStringFull(){} // RVA: 0x7AE027730
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ParameterDictionary : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE004520
        public void op_Implicit(){} // RVA: 0x7ACF03D80
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Byte,System.Object>>.GetEnumerator(){} // RVA: 0x7AE004680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AE0046D0
        public void GetEnumerator(){} // RVA: 0x7AE004720
        public void get_Item(){} // RVA: 0x7AE0047D0
        public void set_Item(){} // RVA: 0x7AE004860
        public void get_Count(){} // RVA: 0x7AE0048D0
        public void Clear(){} // RVA: 0x7AE004920
        public void Add(){} // RVA: 0x7AE004E90
        public void Get(){} // RVA: 0x7AA55AC40
        public void ContainsKey(){} // RVA: 0x7AE004F90
        public void TryGetValue(){} // RVA: 0x7AA55AF70
    }

    public class ParameterDictionary[] : Array
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

    public class PeerBase : Object
    {
        // ── Methods ──
        public void get_Stats(){} // RVA: 0x7A87755C0
        public void get_Listener(){} // RVA: 0x7A88F3B10
        public void get_LogLevel(){} // RVA: 0x7A98A0C50
        public void get_ServerAddress(){} // RVA: 0x7A83F69F0
        public void set_ServerAddress(){} // RVA: 0x7A8105A90
        public void get_ProxyServerAddress(){} // RVA: 0x7A8292C30
        public void set_ProxyServerAddress(){} // RVA: 0x7A8296DE0
        public void get_peerConnectionState(){} // RVA: 0x7AE0050F0
        public void set_peerConnectionState(){} // RVA: 0x7AE005100
        public void TryUpdateConnectionState(){} // RVA: 0x7AE005110
        public void get_rttVarString(){} // RVA: 0x7AE005140
        public void get_TimeoutVarianceCompensation(){} // RVA: 0x7AE005220
        public void get_DisconnectTimeout(){} // RVA: 0x7AE005280
        public void get_PingInterval(){} // RVA: 0x7ADB40610
        public void get_ChannelCount(){} // RVA: 0x7AE0052A0
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7A7E00710
        public void get_timeInt(){} // RVA: 0x7AE0052C0
        public void set_ServerFeatureFlags(){} // RVA: 0x7AE0052F0
        public void get_serverFeatureFlagsAvailable(){} // RVA: 0x7AE005330
        public void set_serverFeatureFlagsAvailable(){} // RVA: 0x7AE005340
        public void get_serverFeatureAck2Available(){} // RVA: 0x7AE005350
        public void set_serverFeatureAck2Available(){} // RVA: 0x7AE005360
        public void get_serverFeatureSyncReliableQueue(){} // RVA: 0x7AE005370
        public void set_serverFeatureSyncReliableQueue(){} // RVA: 0x7AE005380
        public void get_ServerMaxQueueableReliableCommands(){} // RVA: 0x7AE005390
        public void set_ServerMaxQueueableReliableCommands(){} // RVA: 0x7AE0053A0
        public void get_mtu(){} // RVA: 0x7AE0053B0
        public void get_IsIpv6(){} // RVA: 0x7AE0053D0
        public void .ctor(){} // RVA: 0x7AE0053F0
        public void Reset(){} // RVA: 0x7AE005950
        public void Connect(){} // RVA: 0x7A7E01DE0
        public void GetHttpKeyValueString(){} // RVA: 0x7AE005FD0
        public void WriteInitRequest(){} // RVA: 0x7AE006290
        public void WriteInitV3(){} // RVA: 0x7AE006990
        public void PrepareWebSocketUrl(){} // RVA: 0x7AE006FB0
        public void OnInitResponse(){} // RVA: 0x7AE007420
        public void Disconnect(){} // RVA: 0x7A7E18C30
        public void FetchServerTimestamp(){} // RVA: 0x7A7E18770
        public void IsTransportEncrypted(){} // RVA: 0x7A7E01900
        public void EnqueuePhotonMessage(){} // RVA: 0x7A7E041B0
        public void SerializeOperationToMessage(){} // RVA: 0x7AE0074C0
        public void SendOutgoingCommands(){} // RVA: 0x7A7E01900
        public void SendAcksOnly(){} // RVA: 0x7A80D7320
        public void ReceiveIncomingCommands(){} // RVA: 0x7A7E1D590
        public void DispatchIncomingCommands(){} // RVA: 0x7A7E01900
        public void DeserializeMessageAndCallback(){} // RVA: 0x7AE007770
        public void UpdateRoundTripTimeAndVariance(){} // RVA: 0x7AE008510
        public void ExchangeKeysForEncryption(){} // RVA: 0x7AE008690
        public void DeriveSharedKey(){} // RVA: 0x7AE008D10
        public void InitEncryption(){} // RVA: 0x7AE008EC0
        public void EnqueueActionForDispatch(){} // RVA: 0x7AE009360
        public void EnqueueDebugReturn(){} // RVA: 0x7AE0094B0
        public void EnqueueStatusCallback(){} // RVA: 0x7AE009750
        public void get_NetworkSimulationSettings(){} // RVA: 0x7A8357A90
        public void NetworkSimRun(){} // RVA: 0x7AE009980
        public void .cctor(){} // RVA: 0x7AE009F00
        public void <DeserializeMessageAndCallback>b__121_0(){} // RVA: 0x7AE00A0E0
    }

    public class PhotonClientWebSocket : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE00A320
        public void Connect(){} // RVA: 0x7AE00A3A0
        public void AsyncConnectAndReceive(){} // RVA: 0x7AE00A4D0
        public void Disconnect(){} // RVA: 0x7AE00B770
        public void Send(){} // RVA: 0x7AE00BAE0
        public void Receive(){} // RVA: 0x7AE00BFC0
    }

    public class PhotonCodes : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE005060
    }

    public class PhotonHashtable : Dictionary`2
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADFF5850
        public void .ctor(){} // RVA: 0x7ADFF5B00
        public void get_Item(){} // RVA: 0x7ADFF5DE0
        public void set_Item(){} // RVA: 0x7ADFF5D10
        public void Add(){} // RVA: 0x7ADFF5E70
        public void ContainsKey(){} // RVA: 0x7ADFF5F40
        public void GetEnumerator(){} // RVA: 0x7ADFF6000
        public void ToString(){} // RVA: 0x7ADFF6140
    }

    public class PhotonPeer : Object
    {
        // ── Methods ──
        public void get_ClientSdkIdShifted(){} // RVA: 0x7AE00C000
        public void get_Version(){} // RVA: 0x7AE00C010
        public void get_UseAck2(){} // RVA: 0x7AE00C3F0
        public void set_UseAck2(){} // RVA: 0x7AE00C400
        public void get_SerializationProtocolType(){} // RVA: 0x7A9739200
        public void set_SerializationProtocolType(){} // RVA: 0x7A9746990
        public void get_SocketImplementation(){} // RVA: 0x7A8105330
        public void set_SocketImplementation(){} // RVA: 0x7A80D8E80
        public void get_SocketErrorCode(){} // RVA: 0x7AE00C410
        public void get_Listener(){} // RVA: 0x7A8292C30
        public void set_Listener(){} // RVA: 0x7A8296DE0
        public void get_PeerState(){} // RVA: 0x7AE00C440
        public void get_ReuseEventInstance(){} // RVA: 0x7A8193790
        public void set_ReuseEventInstance(){} // RVA: 0x7AE00C4B0
        public void get_UseByteArraySlicePoolForEvents(){} // RVA: 0x7A83F3AD0
        public void get_WrapIncomingStructs(){} // RVA: 0x7A83F4170
        public void get_QuickResendAttempts(){} // RVA: 0x7A818F850
        public void set_QuickResendAttempts(){} // RVA: 0x7AE00C630
        public void get_DisconnectTimeout(){} // RVA: 0x7A8A22410
        public void set_DisconnectTimeout(){} // RVA: 0x7AE00C650
        public void get_CrcEnabled(){} // RVA: 0x7A8359360
        public void set_CrcEnabled(){} // RVA: 0x7AE00C660
        public void get_ServerAddress(){} // RVA: 0x7AE00C6F0
        public void get_UsedProtocol(){} // RVA: 0x7AE00C710
        public void get_TransportProtocol(){} // RVA: 0x7A8F1FD00
        public void set_TransportProtocol(){} // RVA: 0x7A8F17000
        public void set_IsSimulationEnabled(){} // RVA: 0x7AE00C730
        public void get_NetworkSimulationSettings(){} // RVA: 0x7AE00C8A0
        public void get_MaximumTransferUnit(){} // RVA: 0x7A8355900
        public void get_IsEncryptionAvailable(){} // RVA: 0x7AE00C8D0
        public void get_PayloadEncryptorType(){} // RVA: 0x7A82C2060
        public void get_EncryptorType(){} // RVA: 0x7A81163D0
        public void set_EncryptorType(){} // RVA: 0x7AE00C900
        public void get_ServerTimeInMilliseconds(){} // RVA: 0x7AE00CAC0
        public void get_EnableServerTracing(){} // RVA: 0x7A9905F60
        public void get_ConnectionTime(){} // RVA: 0x7AE00CB10
        public void get_BytesIn(){} // RVA: 0x7AE00CB40
        public void get_BytesOut(){} // RVA: 0x7AE00CB60
        public void get_ByteCountCurrentDispatch(){} // RVA: 0x7AE00CB80
        public void get_ByteCountLastOperation(){} // RVA: 0x7AE00CBA0
        public void get_PacketLossByCrc(){} // RVA: 0x7AE00CBC0
        public void get_PacketLossByChallenge(){} // RVA: 0x7AE00CBE0
        public void get_CountDiscarded(){} // RVA: 0x7ABA390E0
        public void set_CountDiscarded(){} // RVA: 0x7ABA390F0
        public void set_DeltaUnreliableNumber(){} // RVA: 0x7A8A67200
        public void get_QueuedOutgoingCommands(){} // RVA: 0x7AE00CC00
        public void get_Stats(){} // RVA: 0x7A8142610
        public void set_Stats(){} // RVA: 0x7A8142620
        public void .ctor(){} // RVA: 0x7AE00D2C0
        public void Connect(){} // RVA: 0x7AE00D340
        public void CreatePeerBase(){} // RVA: 0x7AE00DFF0
        public void Disconnect(){} // RVA: 0x7AE00E200
        public void FetchServerTimestamp(){} // RVA: 0x7AE00E450
        public void EstablishEncryption(){} // RVA: 0x7AE00E480
        public void InitDatagramEncryption(){} // RVA: 0x7AE00E560
        public void InitPayloadEncryption(){} // RVA: 0x7A825F860
        public void Service(){} // RVA: 0x7AE00E9B0
        public void SendOutgoingCommands(){} // RVA: 0x7AE00EA00
        public void SendAcksOnly(){} // RVA: 0x7AE00EBB0
        public void DispatchIncomingCommands(){} // RVA: 0x7AE00ECF0
        public void SendOperation(){} // RVA: 0x7AE00EEC0
        public void RegisterType(){} // RVA: 0x7AE00F330
        public void .cctor(){} // RVA: 0x7AE00F3C0
        public void <EstablishEncryption>b__202_0(){} // RVA: 0x7AE00F420
    }

    public class PhotonSocket : Object
    {
        // ── Methods ──
        public void get_Listener(){} // RVA: 0x7AE00F450
        public void get_MTU(){} // RVA: 0x7AE00F480
        public void get_State(){} // RVA: 0x7A9739200
        public void set_State(){} // RVA: 0x7A9746990
        public void get_SocketErrorCode(){} // RVA: 0x7A851DB90
        public void set_SocketErrorCode(){} // RVA: 0x7A8738180
        public void get_Connected(){} // RVA: 0x7AE00F4B0
        public void get_LogLevel(){} // RVA: 0x7AE00F4C0
        public void get_ServerAddress(){} // RVA: 0x7A83F69F0
        public void set_ServerAddress(){} // RVA: 0x7A8105A90
        public void get_ProxyServerAddress(){} // RVA: 0x7A8292C30
        public void set_ProxyServerAddress(){} // RVA: 0x7A8296DE0
        public void set_ServerIpAddress(){} // RVA: 0x7A80FF440
        public void get_ServerPort(){} // RVA: 0x7A8178B70
        public void set_ServerPort(){} // RVA: 0x7A8178B80
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x7A9471CE0
        public void set_AddressResolvedAsIpv6(){} // RVA: 0x7A9478060
        public void set_UrlProtocol(){} // RVA: 0x7A8230620
        public void set_UrlPath(){} // RVA: 0x7A81A0060
        public void get_SerializationProtocol(){} // RVA: 0x7AE00F4F0
        public void .ctor(){} // RVA: 0x7AE00F6B0
        public void Connect(){} // RVA: 0x7AE00F7F0
        public void Disconnect(){} // RVA: 0x7A7E01900
        public void Send(){} // RVA: 0x7A7E09FB0
        public void Receive(){} // RVA: 0x7A7E01630
        public void HandleReceivedDatagram(){} // RVA: 0x7AE00FBB0
        public void ReportDebugOfLevel(){} // RVA: 0x7AE00FBE0
        public void EnqueueDebugReturn(){} // RVA: 0x7AE00FC10
        public void HandleException(){} // RVA: 0x7AE00FC30
        public void TryParseAddress(){} // RVA: 0x7AE00FCE0
        public void IpAddressTryParse(){} // RVA: 0x7AE0101D0
        public void GetIpAddresses(){} // RVA: 0x7AE0104D0
        public void AddressSortComparer(){} // RVA: 0x7AE010CA0
        public void <HandleException>b__58_0(){} // RVA: 0x7AE010D00
    }

    public class Pool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1A470
        public void CreatePoolItems(){} // RVA: 0x7A7E189D0
        public void Release(){} // RVA: 0x7A8051B10
        public void Acquire(){} // RVA: 0x7A8051B10
    }

    public class Pool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABBF0700
        public void CreatePoolItems(){} // RVA: 0x7ABBF08D0
        public void Release(){} // RVA: 0x7ABBF0950
        public void Acquire(){} // RVA: 0x7ABBF0B00
    }

    public class Pool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABBF0700
        public void CreatePoolItems(){} // RVA: 0x7ABBF08D0
        public void Release(){} // RVA: 0x7ABBF0950
        public void Acquire(){} // RVA: 0x7ABBF0B00
    }

    public class Pool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABBF0700
        public void CreatePoolItems(){} // RVA: 0x7ABBF08D0
        public void Release(){} // RVA: 0x7ABBF0950
        public void Acquire(){} // RVA: 0x7ABBF0B00
    }

    public class PreserveAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Protocol : Object
    {
        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7A7E00680
        public void get_VersionBytes(){} // RVA: 0x7A7E00680
        public void Serialize(){} // RVA: 0x7AE011220
        public void SerializeShort(){} // RVA: 0x7A7E1F660
        public void SerializeString(){} // RVA: 0x7A7E1EE20
        public void SerializeEventData(){} // RVA: 0x7A7E1EE20
        public void SerializeOperationRequest(){} // RVA: 0x7A7E1EAA0
        public void SerializeOperationResponse(){} // RVA: 0x7A7E1EE20
        public void Deserialize(){} // RVA: 0x7AE0112C0
        public void DeserializeShort(){} // RVA: 0x7A7E00A40
        public void DeserializeByte(){} // RVA: 0x7A7E019D0
        public void DeserializeEventData(){} // RVA: 0x7A7E12800
        public void DeserializeOperationRequest(){} // RVA: 0x7A7E0FC80
        public void DeserializeOperationResponse(){} // RVA: 0x7A7E0FC80
        public void DeserializeDisconnectMessage(){} // RVA: 0x7A7E00B20
        public void DeserializeMessage(){} // RVA: 0x7AE0113B0
        public void TryRegisterType(){} // RVA: 0x7AE011410
        public void .ctor(){} // RVA: 0x7AE011780
        public void .cctor(){} // RVA: 0x7AE011820
    }

    public class Protocol16 : Protocol
    {
        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7AE0119C0
        public void get_VersionBytes(){} // RVA: 0x7A80DA7B0
        public void SerializeCustom(){} // RVA: 0x7AE011A00
        public void DeserializeCustom(){} // RVA: 0x7AE011DC0
        public void GetTypeOfCode(){} // RVA: 0x7AE0120F0
        public void GetCodeOfType(){} // RVA: 0x7AE012470
        public void CreateArrayByType(){} // RVA: 0x7AE012810
        public void SerializeOperationRequest(){} // RVA: 0x7AE012880
        public void DeserializeOperationRequest(){} // RVA: 0x7AE012960
        public void SerializeOperationResponse(){} // RVA: 0x7AE012A50
        public void DeserializeDisconnectMessage(){} // RVA: 0x7AE012BE0
        public void DeserializeOperationResponse(){} // RVA: 0x7AE012DB0
        public void SerializeEventData(){} // RVA: 0x7AE012FA0
        public void DeserializeEventData(){} // RVA: 0x7AE013080
        public void SerializeParameterTable(){} // RVA: 0x7AE013140
        public void DeserializeParameterDictionary(){} // RVA: 0x7AE0134F0
        public void Serialize(){} // RVA: 0x7AE013620
        public void SerializeByte(){} // RVA: 0x7AE014260
        public void SerializeBoolean(){} // RVA: 0x7AE014310
        public void SerializeShort(){} // RVA: 0x7AE0143C0
        public void SerializeLengthAsShort(){} // RVA: 0x7AE0145E0
        public void SerializeInteger(){} // RVA: 0x7AE0147F0
        public void SerializeLong(){} // RVA: 0x7AE014A40
        public void SerializeFloat(){} // RVA: 0x7AE014ED0
        public void SerializeDouble(){} // RVA: 0x7AE015420
        public void SerializeString(){} // RVA: 0x7AE0158C0
        public void SerializeArray(){} // RVA: 0x7AE015AA0
        public void SerializeByteArray(){} // RVA: 0x7AE016180
        public void SerializeByteArraySegment(){} // RVA: 0x7AE016240
        public void SerializeIntArrayOptimized(){} // RVA: 0x7AE016320
        public void SerializeObjectArray(){} // RVA: 0x7AE016570
        public void SerializeHashTable(){} // RVA: 0x7AE0167C0
        public void SerializeDictionary(){} // RVA: 0x7AE016B40
        public void SerializeDictionaryHeader(){} // RVA: 0x7AE016C40
        public void SerializeDictionaryElements(){} // RVA: 0x7AE017090
        public void Deserialize(){} // RVA: 0x7AE0173D0
        public void DeserializeByte(){} // RVA: 0x7AE017D20
        public void DeserializeBoolean(){} // RVA: 0x7AE017D40
        public void DeserializeShort(){} // RVA: 0x7AE017D70
        public void DeserializeInteger(){} // RVA: 0x7AE0180E0
        public void DeserializeLong(){} // RVA: 0x7AE018470
        public void DeserializeFloat(){} // RVA: 0x7AE018870
        public void DeserializeDouble(){} // RVA: 0x7AE018C70
        public void DeserializeString(){} // RVA: 0x7AE019100
        public void DeserializeArray(){} // RVA: 0x7AE019260
        public void DeserializeByteArray(){} // RVA: 0x7AE019C90
        public void DeserializeIntArray(){} // RVA: 0x7AE019D50
        public void DeserializeStringArray(){} // RVA: 0x7AE019E30
        public void DeserializeObjectArray(){} // RVA: 0x7AE019F60
        public void DeserializeHashTable(){} // RVA: 0x7AE01A0F0
        public void DeserializeDictionary(){} // RVA: 0x7AE01A260
        public void DeserializeDictionaryArray(){} // RVA: 0x7AE01A640
        public void DeserializeDictionaryType(){} // RVA: 0x7AE01A8F0
        public void .ctor(){} // RVA: 0x7AE01ABC0
        public void .cctor(){} // RVA: 0x7AE01B040
    }

    public class Protocol18 : Protocol
    {
        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7AE01B1F0
        public void get_VersionBytes(){} // RVA: 0x7A80DA7B0
        public void Serialize(){} // RVA: 0x7AE01B230
        public void SerializeShort(){} // RVA: 0x7AE01B2B0
        public void SerializeString(){} // RVA: 0x7AE01B320
        public void Deserialize(){} // RVA: 0x7AE01B330
        public void DeserializeShort(){} // RVA: 0x7AE01B350
        public void DeserializeByte(){} // RVA: 0x7AE017D20
        public void GetAllowedDictionaryKeyTypes(){} // RVA: 0x7AE01B3D0
        public void GetClrArrayType(){} // RVA: 0x7AE01B5D0
        public void GetCodeOfType(){} // RVA: 0x7AE01B930
        public void GetCodeOfTypeCode(){} // RVA: 0x7AE01C150
        public void Read(){} // RVA: 0x7AE01C240
        public void ReadBoolean(){} // RVA: 0x7AE017D40
        public void ReadByte(){} // RVA: 0x7AE017D20
        public void ReadInt16(){} // RVA: 0x7AE01B350
        public void ReadUShort(){} // RVA: 0x7AE01B350
        public void ReadSingle(){} // RVA: 0x7AE01D550
        public void ReadDouble(){} // RVA: 0x7AE01D5F0
        public void ReadNonAllocByteArray(){} // RVA: 0x7AE01D690
        public void ReadByteArray(){} // RVA: 0x7AE01D730
        public void ReadCustomType(){} // RVA: 0x7AE01D7E0
        public void DeserializeEventData(){} // RVA: 0x7AE01DBB0
        public void ReadParameterDictionary(){} // RVA: 0x7AE01DDF0
        public void ReadHashtable(){} // RVA: 0x7AE01DF20
        public void DeserializeOperationRequest(){} // RVA: 0x7AE01E110
        public void DeserializeOperationResponse(){} // RVA: 0x7AE01E200
        public void DeserializeDisconnectMessage(){} // RVA: 0x7AE01E410
        public void ReadString(){} // RVA: 0x7AE01E610
        public void ReadCustomTypeArray(){} // RVA: 0x7AE01E6F0
        public void ReadDictionaryType(){} // RVA: 0x7AE01EF90
        public void GetDictArrayType(){} // RVA: 0x7AE01F240
        public void ReadDictionary(){} // RVA: 0x7AE01F340
        public void ReadDictionaryElements(){} // RVA: 0x7AE01F570
        public void ReadObjectArray(){} // RVA: 0x7AE01F6F0
        public void ReadBooleanArray(){} // RVA: 0x7AE01F870
        public void ReadInt16Array(){} // RVA: 0x7AE01FAF0
        public void ReadSingleArray(){} // RVA: 0x7AE01FBF0
        public void ReadDoubleArray(){} // RVA: 0x7AE01FCB0
        public void ReadStringArray(){} // RVA: 0x7AE01FD70
        public void ReadHashtableArray(){} // RVA: 0x7AE01FE80
        public void ReadDictionaryArray(){} // RVA: 0x7AE020010
        public void ReadArrayInArray(){} // RVA: 0x7AE0203A0
        public void ReadInt1(){} // RVA: 0x7AE020540
        public void ReadInt2(){} // RVA: 0x7AE020580
        public void ReadCompressedInt32(){} // RVA: 0x7AE020640
        public void ReadCompressedUInt32(){} // RVA: 0x7AE020660
        public void ReadCompressedInt64(){} // RVA: 0x7AE020900
        public void ReadCompressedUInt64(){} // RVA: 0x7AE0209F0
        public void ReadCompressedInt32Array(){} // RVA: 0x7AE020AD0
        public void ReadCompressedInt64Array(){} // RVA: 0x7AE020B90
        public void DecodeZigZag32(){} // RVA: 0x7AE020C40
        public void DecodeZigZag64(){} // RVA: 0x7AE020C50
        public void Write(){} // RVA: 0x7AE020C60
        public void SerializeEventData(){} // RVA: 0x7AE0222F0
        public void WriteParameterTable(){} // RVA: 0x7AE0223D0
        public void SerializeOperationRequest(){} // RVA: 0x7AE0227D0
        public void SerializeOperationResponse(){} // RVA: 0x7AE0228B0
        public void WriteByte(){} // RVA: 0x7AE022A60
        public void WriteBoolean(){} // RVA: 0x7AE022AF0
        public void WriteUShort(){} // RVA: 0x7AE022B90
        public void WriteInt16(){} // RVA: 0x7AE01B2B0
        public void WriteDouble(){} // RVA: 0x7AE022BC0
        public void WriteSingle(){} // RVA: 0x7AE022F50
        public void WriteString(){} // RVA: 0x7AE0232E0
        public void WriteHashtable(){} // RVA: 0x7AE023490
        public void WriteByteArray(){} // RVA: 0x7AE0237B0
        public void WriteArraySegmentByte(){} // RVA: 0x7AE023860
        public void WriteByteArraySlice(){} // RVA: 0x7AE0239B0
        public void WriteInt32ArrayCompressed(){} // RVA: 0x7AE023A90
        public void WriteInt64ArrayCompressed(){} // RVA: 0x7AE023B70
        public void WriteBoolArray(){} // RVA: 0x7AE023C50
        public void WriteInt16Array(){} // RVA: 0x7AE023F20
        public void WriteSingleArray(){} // RVA: 0x7AE024000
        public void WriteDoubleArray(){} // RVA: 0x7AE0240F0
        public void WriteStringArray(){} // RVA: 0x7AE0241E0
        public void WriteObjectArray(){} // RVA: 0x7AE0243A0
        public void WriteArrayInArray(){} // RVA: 0x7AE0245C0
        public void WriteCustomTypeBody(){} // RVA: 0x7AE024700
        public void WriteCustomType(){} // RVA: 0x7AE0249A0
        public void WriteCustomTypeArray(){} // RVA: 0x7AE024E70
        public void WriteArrayHeader(){} // RVA: 0x7AE0254F0
        public void WriteDictionaryElements(){} // RVA: 0x7AE025650
        public void WriteDictionary(){} // RVA: 0x7AE025920
        public void WriteDictionaryHeader(){} // RVA: 0x7AE025A60
        public void WriteArrayType(){} // RVA: 0x7AE026220
        public void WriteHashtableArray(){} // RVA: 0x7AE0266F0
        public void WriteDictionaryArray(){} // RVA: 0x7AE026840
        public void WriteIntLength(){} // RVA: 0x7AE026990
        public void WriteCompressedInt32(){} // RVA: 0x7AE0269A0
        public void WriteCompressedInt64(){} // RVA: 0x7AE026B50
        public void WriteCompressedUInt32(){} // RVA: 0x7AE026EC0
        public void WriteCompressedUInt64(){} // RVA: 0x7AE026F30
        public void EncodeZigZag32(){} // RVA: 0x7AE027140
        public void EncodeZigZag64(){} // RVA: 0x7AE027150
        public void .ctor(){} // RVA: 0x7AE027160
        public void .cctor(){} // RVA: 0x7AE027460
    }

    public class SendOptions : ValueType
    {
        // ── Methods ──
        public void get_Reliability(){} // RVA: 0x7A7E666C0
        public void set_Reliability(){} // RVA: 0x7A7E666D0
        public void .cctor(){} // RVA: 0x7AE0285A0
    }

    public class SerializationProtocolFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AE010F10
    }

    public class SerializeStreamMethod : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB1A5730
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class SimulationItem : Object
    {
        // ── Methods ──
        public void get_Delay(){} // RVA: 0x7A854FDE0
    }

    public class SocketTcp : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE028610
        public void Finalize(){} // RVA: 0x7AE028730
        public void Dispose(){} // RVA: 0x7AE028770
        public void Connect(){} // RVA: 0x7AE028880
        public void Disconnect(){} // RVA: 0x7AE028AF0
        public void Send(){} // RVA: 0x7AE028D30
        public void Receive(){} // RVA: 0x7A983BB50
        public void DnsAndConnect(){} // RVA: 0x7AE029040
        public void ReceiveLoop(){} // RVA: 0x7AE029780
    }

    public class SocketTcpAsync : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE02A140
        public void Finalize(){} // RVA: 0x7AE02A260
        public void Dispose(){} // RVA: 0x7AE02A2A0
        public void Connect(){} // RVA: 0x7AE02A3C0
        public void Disconnect(){} // RVA: 0x7AE02A630
        public void Send(){} // RVA: 0x7AE02A8A0
        public void Receive(){} // RVA: 0x7A983BB50
        public void DnsAndConnect(){} // RVA: 0x7AE02ADD0
        public void ReceiveAsync(){} // RVA: 0x7AE02B8F0
    }

    public class SocketUdp : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE02C100
        public void Finalize(){} // RVA: 0x7AE02C290
        public void Dispose(){} // RVA: 0x7AE02C2D0
        public void Connect(){} // RVA: 0x7AE02C3F0
        public void Disconnect(){} // RVA: 0x7AE02C660
        public void Send(){} // RVA: 0x7AE02C8D0
        public void Receive(){} // RVA: 0x7A983BB50
        public void DnsAndConnect(){} // RVA: 0x7AE02D420
        public void ReceiveLoop(){} // RVA: 0x7AE02DA90
    }

    public class SocketUdpAsync : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE02E1A0
        public void Finalize(){} // RVA: 0x7AE02A260
        public void Dispose(){} // RVA: 0x7AE02A2A0
        public void Connect(){} // RVA: 0x7AE02E2C0
        public void Disconnect(){} // RVA: 0x7AE02E530
        public void Send(){} // RVA: 0x7AE02E7A0
        public void Receive(){} // RVA: 0x7A983BB50
        public void DnsAndConnect(){} // RVA: 0x7AE02ED00
        public void StartReceive(){} // RVA: 0x7AE02F270
        public void OnReceive(){} // RVA: 0x7AE02F4F0
    }

    public class StreamBuffer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE02FEE0
        public void ToArray(){} // RVA: 0x7AE02FF50
        public void Compact(){} // RVA: 0x7AE02FFC0
        public void GetBuffer(){} // RVA: 0x7A80DA7B0
        public void GetBufferAndAdvance(){} // RVA: 0x7AE030040
        public void get_Length(){} // RVA: 0x7A8668BC0
        public void get_Position(){} // RVA: 0x7A8124910
        public void set_Position(){} // RVA: 0x7AE030080
        public void get_Available(){} // RVA: 0x7AE0300A0
        public void Reset(){} // RVA: 0x7AE0300B0
        public void Seek(){} // RVA: 0x7AE0300C0
        public void SetLength(){} // RVA: 0x7AE0301E0
        public void SetCapacityMinimum(){} // RVA: 0x7AE030210
        public void Read(){} // RVA: 0x7AE030220
        public void Write(){} // RVA: 0x7AE030280
        public void ReadByte(){} // RVA: 0x7AE030300
        public void WriteByte(){} // RVA: 0x7AE0303F0
        public void WriteBytes(){} // RVA: 0x7AE030450
        public void CheckSize(){} // RVA: 0x7AE0304E0
    }

    public class StreamBuffer[] : Array
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

    public class SupportClass : Object
    {
        // ── Methods ──
        public void WriteStackTrace(){} // RVA: 0x7AE0305F0
        public void DictionaryToString(){} // RVA: 0x7AE031180
        public void ByteArrayToString(){} // RVA: 0x7AE031C80
        public void InitializeTable(){} // RVA: 0x7AE031D00
        public void CalculateCrc(){} // RVA: 0x7AE032040
    }

    public class TPeer : PeerBase
    {
        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7AE0322F0
        public void .ctor(){} // RVA: 0x7AE032340
        public void IsTransportEncrypted(){} // RVA: 0x7AE032570
        public void Reset(){} // RVA: 0x7AE032580
        public void Connect(){} // RVA: 0x7AE032710
        public void Disconnect(){} // RVA: 0x7AE032B70
        public void FetchServerTimestamp(){} // RVA: 0x7AE032DF0
        public void EnqueueInit(){} // RVA: 0x7AE032F30
        public void DispatchIncomingCommands(){} // RVA: 0x7AE0330D0
        public void SendOutgoingCommands(){} // RVA: 0x7AE0335D0
        public void SendAcksOnly(){} // RVA: 0x7AE033A80
        public void EnqueuePhotonMessage(){} // RVA: 0x7AE033AF0
        public void EnqueueMessageAsPayload(){} // RVA: 0x7AE033B20
        public void SendPing(){} // RVA: 0x7AE033E60
        public void SendData(){} // RVA: 0x7AE0343B0
        public void ReceiveIncomingCommands(){} // RVA: 0x7AE034540
        public void ReadPingResult(){} // RVA: 0x7AE034BB0
        public void .cctor(){} // RVA: 0x7AE034D00
    }

    public class TrafficStats : TrafficStatsBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8175E00
        public void get_LastReceiveTimestamp(){} // RVA: 0x7A8EA8210
        public void set_LastReceiveTimestamp(){} // RVA: 0x7A8270510
        public void get_LastDispatchTimestamp(){} // RVA: 0x7A96E4F70
        public void set_LastDispatchTimestamp(){} // RVA: 0x7A9B90E90
        public void get_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x7A989D5C0
        public void set_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x7A98A0B60
        public void set_LastDispatchDuration(){} // RVA: 0x7AE034E90
        public void get_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0x7A8D6DF30
        public void set_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0x7A8D6DF20
        public void DispatchIncomingCommandsCalled(){} // RVA: 0x7AE034EA0
        public void SendOutgoingCommandsCalled(){} // RVA: 0x7AE034EC0
        public void ToString(){} // RVA: 0x7AE034EF0
    }

    public class TrafficStatsBase : Object
    {
        // ── Methods ──
        public void get_BytesIn(){} // RVA: 0x7A80F2570
        public void set_BytesIn(){} // RVA: 0x7A97242F0
        public void get_BytesOut(){} // RVA: 0x7A80DA7B0
        public void set_BytesOut(){} // RVA: 0x7A8A224D0
        public void get_PackagesIn(){} // RVA: 0x7A851DB90
        public void set_PackagesIn(){} // RVA: 0x7A8738180
        public void get_PackagesOut(){} // RVA: 0x7A8AB15F0
        public void set_PackagesOut(){} // RVA: 0x7A94794D0
        public void get_UdpFragmentsIn(){} // RVA: 0x7A854FDE0
        public void set_UdpFragmentsIn(){} // RVA: 0x7A8810F60
        public void get_UdpFragmentsOut(){} // RVA: 0x7A8F9ACE0
        public void set_UdpFragmentsOut(){} // RVA: 0x7A98B6D80
        public void get_UdpUnreliableCommandsSent(){} // RVA: 0x7A8133100
        public void set_UdpUnreliableCommandsSent(){} // RVA: 0x7A8133110
        public void get_UdpReliableCommandsSent(){} // RVA: 0x7A82C2070
        public void set_UdpReliableCommandsSent(){} // RVA: 0x7A82C0430
        public void get_UdpReliableCommandsResent(){} // RVA: 0x7A8D863F0
        public void set_UdpReliableCommandsResent(){} // RVA: 0x7A8D870E0
        public void set_UdpReliableCommandsInFlight(){} // RVA: 0x7A9ABBD00
        public void get_DispatchIncomingCommandsCalls(){} // RVA: 0x7A8178B30
        public void set_DispatchIncomingCommandsCalls(){} // RVA: 0x7A8178B40
        public void get_SendOutgoingCommandsCalls(){} // RVA: 0x7A8178B50
        public void set_SendOutgoingCommandsCalls(){} // RVA: 0x7A8178B60
        public void get_RoundtripTime(){} // RVA: 0x7A8152D80
        public void set_RoundtripTime(){} // RVA: 0x7A9558880
        public void get_RoundtripTimeVariance(){} // RVA: 0x7A8178B90
        public void set_RoundtripTimeVariance(){} // RVA: 0x7A82C1E60
        public void set_LastRoundtripTime(){} // RVA: 0x7A82C2080
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UnknownType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Version : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE035630
    }

}