// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client
// Classes: 45
// Methods: 659

namespace ThirdParty.Photon.Photon.Client
{
    public class ByteArraySlice : Object
    {
        public byte[] Buffer; // 0x10
        public int Offset; // 0x18
        public int Count; // 0x1C
        public Photon.Client.ByteArraySlicePool returnPool; // 0x20
        public int stackIndex; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC899F230
        public void Dispose(){} // RVA: 0x7FFAC899F360
        public void Release(){} // RVA: 0x7FFAC899F3A0
    }

    public class ByteArraySlicePool : Object
    {
        public int minStackIndex; // 0x10
        public System.Collections.Generic.Stack`1<Photon.Client.ByteArraySlice>[] poolTiers; // 0x18
        public int allocationCounter; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC899F3E0
        public void Acquire(){} // RVA: 0x7FFAC899F630
        public void PopOrCreate(){} // RVA: 0x7FFAC899FA80
        public void Release(){} // RVA: 0x7FFAC899FDA0
    }

    public class CustomType : Object
    {
        public byte Code; // 0x10
        public System.Type Type; // 0x18
        public Photon.Client.SerializeStreamMethod SerializeStreamFunction; // 0x20
        public Photon.Client.DeserializeStreamMethod DeserializeStreamFunction; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89BC1F0
    }

    public class DeserializeStreamMethod : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89BC070
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class DictionaryEntryEnumerator : ValueType
    {
        public Enumerator<object,object> System.Collections.IEnumerator.Current; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC530B710
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC89A0FB0
        public void get_Current(){} // RVA: 0x7FFAC89A1100
        public void MoveNext(){} // RVA: 0x7FFAC89A1190
        public void Reset(){} // RVA: 0x7FFAC89A11D0
        public void Dispose(){} // RVA: 0x7FFAC2F21310
    }

    public class DisconnectMessage : Object
    {
        public short Code; // 0x10
        public string DebugMessage; // 0x18
        public Photon.Client.ParameterDictionary Parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EnetChannel : Object
    {
        public byte ChannelNumber; // 0x10
        public Photon.Client.NonAllocDictionary`2<int,Photon.Client.NCommand> incomingReliableCommandsList; // 0x18
        public Photon.Client.NonAllocDictionary`2<int,Photon.Client.NCommand> incomingUnreliableCommandsList; // 0x20
        public System.Collections.Generic.Queue`1<Photon.Client.NCommand> incomingUnsequencedCommandsList; // 0x28
        public Photon.Client.NonAllocDictionary`2<int,Photon.Client.NCommand> incomingUnsequencedFragments; // 0x30
        public System.Collections.Generic.List`1<Photon.Client.NCommand> outgoingReliableCommandsList; // 0x38
        public System.Collections.Generic.List`1<Photon.Client.NCommand> outgoingUnreliableCommandsList; // 0x40
        public int incomingReliableSequenceNumber; // 0x48
        public int incomingUnreliableSequenceNumber; // 0x4C
        public int outgoingReliableSequenceNumber; // 0x50
        public int outgoingUnreliableSequenceNumber; // 0x54
        public int outgoingReliableUnsequencedNumber; // 0x58
        public int reliableUnsequencedNumbersCompletelyReceived; // 0x5C
        public System.Collections.Generic.HashSet`1<int> reliableUnsequencedNumbersReceived; // 0x60
        public int highestReceivedAck; // 0x68
        public int reliableCommandsInFlight; // 0x6C
        public int lowestUnacknowledgedSequenceNumber; // 0x70
        public ReceiveTrackingValues SequencedReceived; // 0x78
        public ReceiveTrackingValues UnsequencedReceived; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89A12A0
        public void AddSequencedIfNew(){} // RVA: 0x7FFAC89A1770
        public void TryGetFragment(){} // RVA: 0x7FFAC89A1840
        public void RemoveFragment(){} // RVA: 0x7FFAC89A18C0
        public void clearAll(){} // RVA: 0x7FFAC89A1930
        public void QueueIncomingReliableUnsequenced(){} // RVA: 0x7FFAC89A1C70
        public void ApplySequenceNumberModifier(){} // RVA: 0x7FFAC89A1FB0
        public void Received(){} // RVA: 0x7FFAC89A2000
        public void GetGapBlock(){} // RVA: 0x7FFAC89A22B0
    }

    public class EnetPeer : PeerBase
    {
        public Photon.Client.Pool`1<Photon.Client.NCommand> QueuedOutgoingCommandsCount; // 0x128
        public System.Collections.Generic.List`1<Photon.Client.NCommand> SendWindowUpdateRequired; // 0x130
        public int DatagramEncryptedConnection; // 0x138
        public Photon.Client.StreamBuffer useAck2; // 0x140
        public int[] unsequencedWindow; // 0x148
        public int outgoingUnsequencedGroupNumber; // 0x150
        public int incomingUnsequencedGroupNumber; // 0x154
        public byte udpCommandCount; // 0x158
        public byte[] udpBuffer; // 0x160
        public int udpBufferIndex; // 0x168
        public byte[] bufferForEncryption; // 0x170
        public int commandBufferSize; // 0x178
        public int challenge; // 0x17C
        public int serverSentTime; // 0x180
        public byte[] udpHeader0xF3;
        public int datagramEncryptedConnectionBackValue; // 0x184
        public Photon.Client.EnetChannel[] channelArray; // 0x188
        public System.Collections.Generic.Queue`1<int> commandsToRemove; // 0x190
        public System.Collections.Concurrent.ConcurrentQueue`1<Photon.Client.NCommand> CommandQueue; // 0x198
        public int fragmentLength; // 0x1A0
        public int fragmentLengthDatagramEncrypt; // 0x1A4
        public int fragmentLengthMtuValue; // 0x1A8
        public object datagramAccessLockObject; // 0x1B0
        public System.Collections.Generic.HashSet`1<byte> channelsToUpdateLowestSent; // 0x1B8
        public int[] lowestSentSequenceNumber; // 0x1C0
        public int[] gapBlocks; // 0x1C8
        public System.Collections.Generic.List`1<Photon.Client.NCommand> toRemove; // 0x1D0

        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7FFAC89A26E0
        public void get_SendWindowUpdateRequired(){} // RVA: 0x7FFAC89A2A00
        public void set_SendWindowUpdateRequired(){} // RVA: 0x7FFAC89A2A20
        public void get_DatagramEncryptedConnection(){} // RVA: 0x7FFAC89A2A40
        public void set_DatagramEncryptedConnection(){} // RVA: 0x7FFAC89A2A60
        public void get_useAck2(){} // RVA: 0x7FFAC89A2A80
        public void .ctor(){} // RVA: 0x7FFAC89A2AB0
        public void IsTransportEncrypted(){} // RVA: 0x7FFAC89A2A40
        public void Reset(){} // RVA: 0x7FFAC89A3440
        public void ApplyRandomizedSequenceNumbers(){} // RVA: 0x7FFAC89A3CB0
        public void GetChannel(){} // RVA: 0x7FFAC89A3ED0
        public void Connect(){} // RVA: 0x7FFAC89A3F30
        public void Disconnect(){} // RVA: 0x7FFAC89A4000
        public void FetchServerTimestamp(){} // RVA: 0x7FFAC89A4540
        public void DispatchCommandQueue(){} // RVA: 0x7FFAC89A4660
        public void DispatchIncomingCommands(){} // RVA: 0x7FFAC89A4740
        public void GetFragmentLength(){} // RVA: 0x7FFAC89A52D0
        public void CalculatePacketSize(){} // RVA: 0x7FFAC89A53B0
        public void CalculateInitialOffset(){} // RVA: 0x7FFAC89A5440
        public void SendAcksOnly(){} // RVA: 0x7FFAC89A5490
        public void SendOutgoingCommands(){} // RVA: 0x7FFAC89A54B0 | overloaded x2
        public void UpdateSendWindow(){} // RVA: 0x7FFAC89A65B0
        public void EnqueuePhotonMessage(){} // RVA: 0x7FFAC89A6FF0
        public void CreateAndEnqueueCommand(){} // RVA: 0x7FFAC89A7040
        public void SerializeAckToBuffer(){} // RVA: 0x7FFAC89A7630
        public void SerializeToBuffer(){} // RVA: 0x7FFAC89A7B30
        public void SerializeCommandToBuffer(){} // RVA: 0x7FFAC89A7C80
        public void SendData(){} // RVA: 0x7FFAC89A7E60
        public void SendToSocket(){} // RVA: 0x7FFAC89A81D0
        public void SendDataEncrypted(){} // RVA: 0x7FFAC89A8340
        public void QueueSentCommand(){} // RVA: 0x7FFAC89A8650
        public void QueueOutgoingReliableCommand(){} // RVA: 0x7FFAC89A89F0
        public void QueueOutgoingUnreliableCommand(){} // RVA: 0x7FFAC89A8C20
        public void QueueOutgoingAcknowledgement(){} // RVA: 0x7FFAC89A8EC0
        public void ReceiveIncomingCommands(){} // RVA: 0x7FFAC89A93C0
        public void ExecuteCommand(){} // RVA: 0x7FFAC89A9F80
        public void QueueIncomingCommand(){} // RVA: 0x7FFAC89AB780
        public void RemoveSentReliableCommand(){} // RVA: 0x7FFAC89AC070
        public void .cctor(){} // RVA: 0x7FFAC89AC510
        public void <ExecuteCommand>b__78_0(){} // RVA: 0x7FFAC89AC5F0
    }

    public class EventData : Object
    {
        public byte Item; // 0x10
        public Photon.Client.ParameterDictionary Sender; // 0x18
        public byte CustomData; // 0x20
        public int sender; // 0x24
        public byte CustomDataKey; // 0x28
        public object customData; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89D2B00
        public void get_Item(){} // RVA: 0x7FFAC89D2BB0
        public void get_Sender(){} // RVA: 0x7FFAC89D2C20
        public void set_Sender(){} // RVA: 0x7FFAC41674D0
        public void get_CustomData(){} // RVA: 0x7FFAC89D2CA0
        public void Reset(){} // RVA: 0x7FFAC89D2D30
        public void ToString(){} // RVA: 0x7FFAC89D2DB0
    }

    public class IPhotonPeerListener
    {
        // ── Methods ──
        public void DebugReturn(){} // RVA: 0x7FFAC2C71580
        public void OnOperationResponse(){} // RVA: 0x7FFAC2C70A40
        public void OnStatusChanged(){} // RVA: 0x7FFAC2C70ED0
        public void OnEvent(){} // RVA: 0x7FFAC2C70A40
        public void OnMessage(){} // RVA: 0x7FFAC2C71580
        public void OnDisconnectMessage(){} // RVA: 0x7FFAC2C70A40
    }

    public class ITrafficRecorder
    {
        // ── Methods ──
        public void Record(){}
    }

    public class InvalidDataException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89C6400
    }

    public class MessageProtocol : Object
    {
        public float[] memFloatBlock;
        public byte[] memDeserialize; // 0x8

        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAC89D3030 | overloaded x3
        public void Deserialize(){} // RVA: 0x7FFAC89D3320 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC89D3650
    }

    public class NCommand : Object
    {
        public byte SizeOfPayload;
        public byte IsFlaggedUnsequenced;
        public byte IsFlaggedReliable;
        public byte FV_UNRELIABLE;
        public byte FV_RELIABLE;
        public byte FV_UNRELIABLE_UNSEQUENCED;
        public byte FV_RELIBALE_UNSEQUENCED;
        public byte CT_NONE;
        public byte CT_ACK;
        public byte CT_CONNECT;
        public byte CT_VERIFYCONNECT;
        public byte CT_DISCONNECT;
        public byte CT_PING;
        public byte CT_SENDRELIABLE;
        public byte CT_SENDUNRELIABLE;
        public byte CT_SENDFRAGMENT;
        public byte CT_SENDUNSEQUENCED;
        public byte CT_EG_SERVERTIME;
        public byte CT_EG_SEND_UNRELIABLE_PROCESSED;
        public byte CT_EG_SEND_RELIABLE_UNSEQUENCED;
        public byte CT_EG_SEND_FRAGMENT_UNSEQUENCED;
        public byte CT_EG_ACK_UNSEQUENCED;
        public byte CT_EG_ACK_2;
        public byte CT_EG_ACK_2_UNSEQUENCED;
        public byte CT_EG_ACK_2_NULL;
        public int HEADER_UDP_PACK_LENGTH;
        public int CmdSizeMinimum;
        public int CmdSizeAck;
        public int CmdSizeConnect;
        public int CmdSizeVerifyConnect;
        public int CmdSizeDisconnect;
        public int CmdSizePing;
        public int CmdSizeReliableHeader;
        public int CmdSizeUnreliableHeader;
        public int CmdSizeUnsequensedHeader;
        public int CmdSizeFragmentHeader;
        public int CmdSizeMaxHeader;
        public byte commandFlags; // 0x10
        public byte commandType; // 0x11
        public byte commandChannelID; // 0x12
        public int reliableSequenceNumber; // 0x14
        public int unreliableSequenceNumber; // 0x18
        public int unsequencedGroupNumber; // 0x1C
        public byte reservedByte; // 0x20
        public int startSequenceNumber; // 0x24
        public int fragmentCount; // 0x28
        public int fragmentNumber; // 0x2C
        public int totalLength; // 0x30
        public int fragmentOffset; // 0x34
        public int fragmentsRemaining; // 0x38
        public int commandSentTime; // 0x3C
        public byte commandSentCount; // 0x40
        public int roundTripTimeout; // 0x44
        public int timeoutTime; // 0x48
        public int ackReceivedReliableSequenceNumber; // 0x4C
        public int ackReceivedSentTime; // 0x50
        public int TimeOfReceive; // 0x54
        public int Size; // 0x58
        public Photon.Client.StreamBuffer Payload; // 0x60

        // ── Methods ──
        public void get_SizeOfPayload(){} // RVA: 0x7FFAC89AC750
        public void get_IsFlaggedUnsequenced(){} // RVA: 0x7FFAC89AC770
        public void get_IsFlaggedReliable(){} // RVA: 0x7FFAC89AC780
        public void CreateAck(){} // RVA: 0x7FFAC89AC7A0
        public void CreateAck2(){} // RVA: 0x7FFAC89AC9D0
        public void Initialize(){} // RVA: 0x7FFAC89ACFA0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAC89AD5C0
        public void SerializeHeader(){} // RVA: 0x7FFAC89AD600
        public void Serialize(){} // RVA: 0x7FFAC89ADA90
        public void FreePayload(){} // RVA: 0x7FFAC89ADAB0
        public void CompareTo(){} // RVA: 0x7FFAC89ADB90
        public void ToString(){} // RVA: 0x7FFAC89ADBD0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC89AE430
    }

    public class NetworkSimulationSet : Object
    {
        public bool IsSimulationEnabled; // 0x10
        public int OutgoingLossPercentage; // 0x14
        public int IncomingLossPercentage; // 0x18
        public int LostPackagesOut; // 0x1C
        public int LostPackagesIn; // 0x20
        public int incomingJitter; // 0x24
        public int incomingLossPercentage; // 0x28
        public Photon.Client.PeerBase peerBase; // 0x30
        public System.Threading.Thread netSimThread; // 0x38
        public System.Threading.ManualResetEvent NetSimManualResetEvent; // 0x40
        public int <LostPackagesOut>k__BackingField; // 0x48
        public int <LostPackagesIn>k__BackingField; // 0x4C

        // ── Methods ──
        public void get_IsSimulationEnabled(){} // RVA: 0x7FFAC2FEB5E0
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFAC89AE440
        public void set_OutgoingLossPercentage(){} // RVA: 0x7FFAC44474D0
        public void set_IncomingLossPercentage(){} // RVA: 0x7FFAC369A6E0
        public void set_LostPackagesOut(){} // RVA: 0x7FFAC2FC20D0
        public void set_LostPackagesIn(){} // RVA: 0x7FFAC489E500
        public void ToString(){} // RVA: 0x7FFAC89AF070
        public void .ctor(){} // RVA: 0x7FFAC89AF3C0
    }

    public class NonAllocDictionary`2 : Object
    {
        public uint[] Keys;
        public int System.Collections.Generic.IDictionary<K,V>.Values;
        public int System.Collections.Generic.IDictionary<K,V>.Keys;
        public int Count;
        public uint IsReadOnly;
        public int[] Item;
        public Node<U,T>[] _nodes;
        public bool isReadOnly;
        public System.Collections.Generic.ICollection`1<U> keys;
        public System.Collections.Generic.ICollection`1<T> values;

        // ── Methods ──
        public void get_Keys(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void ContainsKey(){} // RVA: 0x7FFAC2E8DC40
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Remove(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void FindNode(){} // RVA: 0x7FFAC2E8DC40
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void Expand(){} // RVA: 0x7FFAC2C70980
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void IsPrimeFromList(){} // RVA: 0x7FFAC2C5A7A0
        public void GetNextPrime(){} // RVA: 0x7FFAC2C60110
        public void Assert(){} // RVA: 0x7FFAC2C70E50
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class OperationRequest : Object
    {
        public byte OperationCode; // 0x10
        public Photon.Client.ParameterDictionary Parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OperationResponse : Object
    {
        public byte Item; // 0x10
        public short ReturnCode; // 0x12
        public string DebugMessage; // 0x18
        public Photon.Client.ParameterDictionary Parameters; // 0x20

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC89D26D0
        public void ToString(){} // RVA: 0x7FFAC89D2740
        public void ToStringFull(){} // RVA: 0x7FFAC89D28C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ParameterDictionary : Object
    {
        public Photon.Client.NonAllocDictionary`2<byte,object> Item; // 0x10
        public Photon.Client.StructWrapping.StructWrapperPools Count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89AF5E0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC77C53A0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Byte,System.Object>>.GetEnumerator(){} // RVA: 0x7FFAC89AF740
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC89AF790
        public void GetEnumerator(){} // RVA: 0x7FFAC89AF7E0
        public void get_Item(){} // RVA: 0x7FFAC89AF890
        public void set_Item(){} // RVA: 0x7FFAC89AF940
        public void get_Count(){} // RVA: 0x7FFAC89AF9B0
        public void Clear(){} // RVA: 0x7FFAC89AFA00
        public void Add(){} // RVA: 0x7FFAC89AFF70 | overloaded x5
        public void Get(){} // RVA: 0x7FFAC2E8DC40
        public void ContainsKey(){} // RVA: 0x7FFAC89B0070
        public void TryGetValue(){} // RVA: 0x7FFAC89B00D0 | overloaded x2
    }

    public class PeerBase : Object
    {
        public Photon.Client.PhotonPeer Stats; // 0x10
        public Photon.Client.Protocol Listener; // 0x18
        public 0x6B26A660 LogLevel; // 0x20
        public Photon.Client.PhotonSocket ServerAddress; // 0x28
        public string ProxyServerAddress; // 0x30
        public string peerConnectionState; // 0x38
        public int rttVarString; // 0x40
        public int TimeoutVarianceCompensation; // 0x44
        public int DisconnectTimeout; // 0x48
        public Photon.Client.NCommand PingInterval; // 0x50
        public int ChannelCount; // 0x58
        public int QueuedOutgoingCommandsCount; // 0x5C
        public int timeInt; // 0x60
        public System.Collections.Generic.Queue`1<MyAction> ServerFeatureFlags; // 0x68
        public short serverFeatureFlagsAvailable; // 0x70
        public short serverFeatureAck2Available;
        public int serverFeatureSyncReliableQueue; // 0x74
        public bool ServerMaxQueueableReliableCommands; // 0x78
        public float mtu; // 0x7C
        public float IsIpv6; // 0x80
        public int NetworkSimulationSettings; // 0x84
        public int lowestRoundTripTime; // 0x88
        public int highestRoundTripTimeVariance; // 0x8C
        public int varianceJitterMin; // 0x90
        public int varianceJitterMax; // 0x94
        public int varianceJitterFactor; // 0x98
        public object PhotonToken; // 0xA0
        public object CustomInitData; // 0xA8
        public string AppId; // 0xB0
        public Photon.Client.EventData reusableEventData; // 0xB8
        public System.Diagnostics.Stopwatch watch; // 0xC0
        public int timeoutInt; // 0xC8
        public int timeLastAckReceive; // 0xCC
        public int longestSendCall; // 0xD0
        public int timeIntCurrentSend; // 0xD4
        public bool ApplicationIsInitialized; // 0xD8
        public bool isEncryptionAvailable; // 0xD9
        public ushort serverFeatureFlags; // 0xDA
        public bool <serverFeatureFlagsAvailable>k__BackingField; // 0xDC
        public bool <serverFeatureAck2Available>k__BackingField; // 0xDD
        public bool <serverFeatureSyncReliableQueue>k__BackingField; // 0xDE
        public ushort <ServerMaxQueueableReliableCommands>k__BackingField; // 0xE0
        public Photon.Client.Pool`1<Photon.Client.StreamBuffer> MessageBufferPool; // 0x8
        public byte[] messageHeader; // 0xE8
        public int prepareWebSocketUrlCount; // 0xF0
        public System.Text.StringBuilder prepareWebSocketUrlSB; // 0xF8
        public Photon.Client.Encryption.ICryptoProvider CryptoProvider; // 0x100
        public System.Random lagRandomizer; // 0x108
        public System.Collections.Generic.LinkedList`1<Photon.Client.SimulationItem> NetSimListOutgoing; // 0x110
        public System.Collections.Generic.LinkedList`1<Photon.Client.SimulationItem> NetSimListIncoming; // 0x118
        public Photon.Client.NetworkSimulationSet networkSimulationSettings; // 0x120

        // ── Methods ──
        public void get_Stats(){} // RVA: 0x7FFAC34D3020
        public void get_Listener(){} // RVA: 0x7FFAC37735C0
        public void get_LogLevel(){} // RVA: 0x7FFAC459CC70
        public void get_ServerAddress(){} // RVA: 0x7FFAC31D95E0
        public void set_ServerAddress(){} // RVA: 0x7FFAC2F4F890
        public void get_ProxyServerAddress(){} // RVA: 0x7FFAC31D0140
        public void set_ProxyServerAddress(){} // RVA: 0x7FFAC31D0C20
        public void get_peerConnectionState(){} // RVA: 0x7FFAC89B01D0
        public void set_peerConnectionState(){} // RVA: 0x7FFAC89B01E0
        public void TryUpdateConnectionState(){} // RVA: 0x7FFAC89B01F0
        public void get_rttVarString(){} // RVA: 0x7FFAC89B0210
        public void get_TimeoutVarianceCompensation(){} // RVA: 0x7FFAC89B02F0
        public void get_DisconnectTimeout(){} // RVA: 0x7FFAC89B0350
        public void get_PingInterval(){} // RVA: 0x7FFAC84E9BF0
        public void get_ChannelCount(){} // RVA: 0x7FFAC89B0370
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7FFAC2C59960
        public void get_timeInt(){} // RVA: 0x7FFAC89B0390
        public void set_ServerFeatureFlags(){} // RVA: 0x7FFAC89B03C0
        public void get_serverFeatureFlagsAvailable(){} // RVA: 0x7FFAC89B0400
        public void set_serverFeatureFlagsAvailable(){} // RVA: 0x7FFAC89B0410
        public void get_serverFeatureAck2Available(){} // RVA: 0x7FFAC89B0420
        public void set_serverFeatureAck2Available(){} // RVA: 0x7FFAC89B0430
        public void get_serverFeatureSyncReliableQueue(){} // RVA: 0x7FFAC89B0440
        public void set_serverFeatureSyncReliableQueue(){} // RVA: 0x7FFAC89B0450
        public void get_ServerMaxQueueableReliableCommands(){} // RVA: 0x7FFAC89B0460
        public void set_ServerMaxQueueableReliableCommands(){} // RVA: 0x7FFAC89B0470
        public void get_mtu(){} // RVA: 0x7FFAC89B0480
        public void get_IsIpv6(){} // RVA: 0x7FFAC89B04A0
        public void .ctor(){} // RVA: 0x7FFAC89B04C0
        public void Reset(){} // RVA: 0x7FFAC89B0A20
        public void Connect(){} // RVA: 0x7FFAC2C5D680
        public void GetHttpKeyValueString(){} // RVA: 0x7FFAC89B1120
        public void WriteInitRequest(){} // RVA: 0x7FFAC89B13C0
        public void WriteInitV3(){} // RVA: 0x7FFAC89B1AC0
        public void PrepareWebSocketUrl(){} // RVA: 0x7FFAC89B20E0
        public void OnInitResponse(){} // RVA: 0x7FFAC89B2550
        public void Disconnect(){} // RVA: 0x7FFAC2C71060
        public void FetchServerTimestamp(){} // RVA: 0x7FFAC2C70980
        public void IsTransportEncrypted(){} // RVA: 0x7FFAC2C59D00
        public void EnqueuePhotonMessage(){}
        public void SerializeOperationToMessage(){} // RVA: 0x7FFAC89B25F0
        public void SendOutgoingCommands(){} // RVA: 0x7FFAC2C59D00
        public void SendAcksOnly(){} // RVA: 0x7FFAC2F21320
        public void ReceiveIncomingCommands(){} // RVA: 0x7FFAC2C77970
        public void DispatchIncomingCommands(){} // RVA: 0x7FFAC2C59D00
        public void DeserializeMessageAndCallback(){} // RVA: 0x7FFAC89B28A0
        public void UpdateRoundTripTimeAndVariance(){} // RVA: 0x7FFAC89B3630
        public void ExchangeKeysForEncryption(){} // RVA: 0x7FFAC89B37A0
        public void DeriveSharedKey(){} // RVA: 0x7FFAC89B3E40
        public void InitEncryption(){} // RVA: 0x7FFAC89B3FF0
        public void EnqueueActionForDispatch(){} // RVA: 0x7FFAC89B4490
        public void EnqueueDebugReturn(){} // RVA: 0x7FFAC89B4610
        public void EnqueueStatusCallback(){} // RVA: 0x7FFAC89B48E0
        public void get_NetworkSimulationSettings(){} // RVA: 0x7FFAC313CBB0
        public void NetworkSimRun(){} // RVA: 0x7FFAC89B4B50
        public void .cctor(){} // RVA: 0x7FFAC89B51F0
        public void <DeserializeMessageAndCallback>b__122_0(){} // RVA: 0x7FFAC89B53D0
    }

    public class PhotonClientWebSocket : PhotonSocket
    {
        public System.Net.WebSockets.ClientWebSocket clientWebSocket; // 0x60
        public System.Threading.Tasks.Task sendTask; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89B5610
        public void Connect(){} // RVA: 0x7FFAC89B5690
        public void AsyncConnectAndReceive(){} // RVA: 0x7FFAC89B57C0
        public void Disconnect(){} // RVA: 0x7FFAC89B69B0
        public void Send(){} // RVA: 0x7FFAC89B6C00
        public void Receive(){} // RVA: 0x7FFAC89B6F60
    }

    public class PhotonCodes : Object
    {
        public byte ClientKey;
        public byte ModeKey; // 0x1
        public byte ServerKey; // 0x2
        public byte InitEncryption; // 0x3
        public byte Ping; // 0x4

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC89B0140
    }

    public class PhotonHashtable : Dictionary`2
    {
        public object[] Item;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC89A00E0
        public void .ctor(){} // RVA: 0x7FFAC89A0380 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC89A0660 | overloaded x3
        public void set_Item(){} // RVA: 0x7FFAC89A0590 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC89A06F0
        public void ContainsKey(){} // RVA: 0x7FFAC89A07C0
        public void GetEnumerator(){} // RVA: 0x7FFAC89A0880
        public void ToString(){} // RVA: 0x7FFAC89A09C0
    }

    public class PhotonPeer : Object
    {
        public bool ClientSdkIdShifted;
        public bool Version;
        public int UseAck2;
        public 0x6B26A710 SerializationProtocolType; // 0x10
        public byte SocketImplementation; // 0x14
        public string SocketErrorCode;
        public bool Listener; // 0x8
        public bool PeerState; // 0x15
        public bool ReuseEventInstance; // 0x16
        public bool UseByteArraySlicePoolForEvents; // 0x17
        public bool WrapIncomingStructs; // 0x18
        public 0x6B26AEF8 QuickResendAttempts; // 0x1C
        public System.Collections.Generic.Dictionary`2<0x6B26A660,System.Type> DisconnectTimeout; // 0x20
        public System.Type CrcEnabled; // 0x28
        public 0x6B26A6B8 ServerAddress; // 0x30
        public Photon.Client.IPhotonPeerListener UsedProtocol; // 0x38
        public bool TransportProtocol; // 0x40
        public bool IsSimulationEnabled; // 0x41
        public bool NetworkSimulationSettings; // 0x42
        public bool MaximumTransferUnit; // 0x43
        public int IsEncryptionAvailable; // 0x44
        public byte PayloadEncryptorType; // 0x48
        public int EncryptorType; // 0x4C
        public int ServerTimeInMilliseconds; // 0x50
        public int EnableServerTracing; // 0x54
        public bool ConnectionTime; // 0x58
        public int BytesIn; // 0x5C
        public byte BytesOut; // 0x60
        public 0x6B26A660 ByteCountCurrentDispatch; // 0x61
        public int ByteCountLastOperation; // 0xC
        public int PacketLossByCrc; // 0x64
        public bool PacketLossByChallenge; // 0x10
        public bool CountDiscarded; // 0x68
        public byte[] DeltaUnreliableNumber; // 0x70
        public System.Type QueuedOutgoingCommands; // 0x78
        public byte[] Stats; // 0x80
        public System.Type encryptorType; // 0x88
        public Photon.Client.Encryption.IPhotonEncryptor Encryptor; // 0x90
        public Photon.Client.ITrafficRecorder TrafficRecorder; // 0x98
        public bool <EnableServerTracing>k__BackingField; // 0xA0
        public bool PingUsedAsInit; // 0xA1
        public int <CountDiscarded>k__BackingField; // 0xA4
        public int <DeltaUnreliableNumber>k__BackingField; // 0xA8
        public Photon.Client.TrafficStats <Stats>k__BackingField; // 0xB0
        public bool TrafficStatsEnabled; // 0xB8
        public Photon.Client.PeerBase peerBase; // 0xC0
        public object sendOutgoingLockObject; // 0xC8
        public object dispatchLockObject; // 0xD0
        public object enqueueLock; // 0xD8

        // ── Methods ──
        public void get_ClientSdkIdShifted(){} // RVA: 0x7FFAC89B6FA0
        public void get_Version(){} // RVA: 0x7FFAC89B6FB0
        public void get_UseAck2(){} // RVA: 0x7FFAC89B7390
        public void set_UseAck2(){} // RVA: 0x7FFAC89B73A0
        public void get_SerializationProtocolType(){} // RVA: 0x7FFAC44357F0
        public void set_SerializationProtocolType(){} // RVA: 0x7FFAC44474D0
        public void get_SocketImplementation(){} // RVA: 0x7FFAC2F4F130
        public void set_SocketImplementation(){} // RVA: 0x7FFAC2F22E90
        public void get_SocketErrorCode(){} // RVA: 0x7FFAC89B73B0
        public void get_Listener(){} // RVA: 0x7FFAC31D0140
        public void set_Listener(){} // RVA: 0x7FFAC31D0C20
        public void get_PeerState(){} // RVA: 0x7FFAC89B73E0
        public void get_ReuseEventInstance(){} // RVA: 0x7FFAC2FDCC00
        public void set_ReuseEventInstance(){} // RVA: 0x7FFAC89B7450
        public void get_UseByteArraySlicePoolForEvents(){} // RVA: 0x7FFAC31D8A60
        public void get_WrapIncomingStructs(){} // RVA: 0x7FFAC31D90A0
        public void get_QuickResendAttempts(){} // RVA: 0x7FFAC2FD8D30
        public void set_QuickResendAttempts(){} // RVA: 0x7FFAC89B7600
        public void get_DisconnectTimeout(){} // RVA: 0x7FFAC38913D0
        public void set_DisconnectTimeout(){} // RVA: 0x7FFAC89B7620
        public void get_CrcEnabled(){} // RVA: 0x7FFAC313F600
        public void set_CrcEnabled(){} // RVA: 0x7FFAC89B7630
        public void get_ServerAddress(){} // RVA: 0x7FFAC89B76C0
        public void get_UsedProtocol(){} // RVA: 0x7FFAC89B76E0
        public void get_TransportProtocol(){} // RVA: 0x7FFAC3C11000
        public void set_TransportProtocol(){} // RVA: 0x7FFAC3C04530
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFAC89B7700
        public void get_NetworkSimulationSettings(){} // RVA: 0x7FFAC89B78A0
        public void get_MaximumTransferUnit(){} // RVA: 0x7FFAC3138CA0
        public void get_IsEncryptionAvailable(){} // RVA: 0x7FFAC89B78D0
        public void get_PayloadEncryptorType(){} // RVA: 0x7FFAC30E5600
        public void get_EncryptorType(){} // RVA: 0x7FFAC2F60010
        public void set_EncryptorType(){} // RVA: 0x7FFAC89B7900
        public void get_ServerTimeInMilliseconds(){} // RVA: 0x7FFAC89B7AC0
        public void get_EnableServerTracing(){} // RVA: 0x7FFAC45C9D50
        public void get_ConnectionTime(){} // RVA: 0x7FFAC89B7B10
        public void get_BytesIn(){} // RVA: 0x7FFAC89B7B40
        public void get_BytesOut(){} // RVA: 0x7FFAC89B7B60
        public void get_ByteCountCurrentDispatch(){} // RVA: 0x7FFAC89B7B80
        public void get_ByteCountLastOperation(){} // RVA: 0x7FFAC89B7BA0
        public void get_PacketLossByCrc(){} // RVA: 0x7FFAC89B7BC0
        public void get_PacketLossByChallenge(){} // RVA: 0x7FFAC89B7BE0
        public void get_CountDiscarded(){} // RVA: 0x7FFAC6539470
        public void set_CountDiscarded(){} // RVA: 0x7FFAC6539480
        public void set_DeltaUnreliableNumber(){} // RVA: 0x7FFAC38FD010
        public void get_QueuedOutgoingCommands(){} // RVA: 0x7FFAC89B7C00
        public void get_Stats(){} // RVA: 0x7FFAC2F8C040
        public void set_Stats(){} // RVA: 0x7FFAC2F8C050
        public void .ctor(){} // RVA: 0x7FFAC89B82C0 | overloaded x2
        public void Connect(){} // RVA: 0x7FFAC89B8340
        public void CreatePeerBase(){} // RVA: 0x7FFAC89B9040
        public void Disconnect(){} // RVA: 0x7FFAC89B9260
        public void FetchServerTimestamp(){} // RVA: 0x7FFAC89B9520
        public void EstablishEncryption(){} // RVA: 0x7FFAC89B9550
        public void InitDatagramEncryption(){} // RVA: 0x7FFAC89B9630
        public void InitPayloadEncryption(){} // RVA: 0x7FFAC34D4AA0
        public void Service(){} // RVA: 0x7FFAC89B9A80
        public void SendOutgoingCommands(){} // RVA: 0x7FFAC89B9AD0
        public void SendAcksOnly(){} // RVA: 0x7FFAC89B9CB0
        public void DispatchIncomingCommands(){} // RVA: 0x7FFAC89B9E20
        public void SendOperation(){} // RVA: 0x7FFAC89BA010
        public void RegisterType(){} // RVA: 0x7FFAC89BA4A0
        public void .cctor(){} // RVA: 0x7FFAC89BA530
        public void <EstablishEncryption>b__203_0(){} // RVA: 0x7FFAC89BA590
    }

    public class PhotonSocket : Object
    {
        public Photon.Client.PeerBase Listener; // 0x10
        public 0x6B26A660 MTU; // 0x18
        public bool State; // 0x19
        public 0x6B26AD98 SocketErrorCode; // 0x1C
        public int Connected; // 0x20
        public string ServerAddress; // 0x28
        public string ProxyServerAddress; // 0x30
        public string ServerIpAddress; // 0x38
        public string ServerPort; // 0x40
        public int AddressResolvedAsIpv6; // 0x48
        public bool UrlProtocol; // 0x4C
        public string UrlPath; // 0x50
        public string SerializationProtocol; // 0x58

        // ── Methods ──
        public void get_Listener(){} // RVA: 0x7FFAC89BA5C0
        public void get_MTU(){} // RVA: 0x7FFAC89BA5F0
        public void get_State(){} // RVA: 0x7FFAC44357F0
        public void set_State(){} // RVA: 0x7FFAC44474D0
        public void get_SocketErrorCode(){} // RVA: 0x7FFAC30DBBE0
        public void set_SocketErrorCode(){} // RVA: 0x7FFAC35DB7A0
        public void get_Connected(){} // RVA: 0x7FFAC89BA620
        public void get_ServerAddress(){} // RVA: 0x7FFAC31D95E0
        public void set_ServerAddress(){} // RVA: 0x7FFAC2F4F890
        public void get_ProxyServerAddress(){} // RVA: 0x7FFAC31D0140
        public void set_ProxyServerAddress(){} // RVA: 0x7FFAC31D0C20
        public void set_ServerIpAddress(){} // RVA: 0x7FFAC2F49200
        public void get_ServerPort(){} // RVA: 0x7FFAC2FC20C0
        public void set_ServerPort(){} // RVA: 0x7FFAC2FC20D0
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x7FFAC4168960
        public void set_AddressResolvedAsIpv6(){} // RVA: 0x7FFAC416A6F0
        public void set_UrlProtocol(){} // RVA: 0x7FFAC30794D0
        public void set_UrlPath(){} // RVA: 0x7FFAC2FE9510
        public void get_SerializationProtocol(){} // RVA: 0x7FFAC89BA630
        public void .ctor(){} // RVA: 0x7FFAC89BA7F0
        public void Connect(){} // RVA: 0x7FFAC89BA920
        public void Disconnect(){} // RVA: 0x7FFAC2C59D00
        public void Send(){}
        public void Receive(){} // RVA: 0x7FFAC2C5E6B0
        public void HandleReceivedDatagram(){} // RVA: 0x7FFAC89BACD0
        public void ReportDebugOfLevel(){} // RVA: 0x7FFAC89BAD00
        public void EnqueueDebugReturn(){} // RVA: 0x7FFAC89BAD30
        public void HandleException(){} // RVA: 0x7FFAC89BAD50
        public void TryParseAddress(){} // RVA: 0x7FFAC89BAE00
        public void IpAddressTryParse(){} // RVA: 0x7FFAC89BB2F0
        public void GetIpAddresses(){} // RVA: 0x7FFAC89BB5B0
        public void AddressSortComparer(){} // RVA: 0x7FFAC89BBD70
        public void <HandleException>b__56_0(){} // RVA: 0x7FFAC89BBDD0
    }

    public class Pool`1 : Object
    {
        public System.Func`1<T> createFunction;
        public System.Collections.Generic.Queue`1<T> pool;
        public System.Action`1<T> resetFunction;

        // ── Methods ──
        public void .ctor(){}
        public void CreatePoolItems(){} // RVA: 0x7FFAC2C70ED0
        public void Release(){} // RVA: 0x7FFAC2E8DC40
        public void Acquire(){} // RVA: 0x7FFAC2E8DC40
    }

    public class PreserveAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Protocol : Object
    {
        public Photon.Client.ByteArraySlicePool ProtocolType; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Type,Photon.Client.CustomType> VersionBytes;
        public System.Collections.Generic.Dictionary`2<byte,Photon.Client.CustomType> CodeDict; // 0x8

        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7FFAC2C58E90
        public void get_VersionBytes(){} // RVA: 0x7FFAC2C58E90
        public void Serialize(){} // RVA: 0x7FFAC89BC300 | overloaded x2
        public void SerializeShort(){}
        public void SerializeString(){}
        public void SerializeEventData(){}
        public void SerializeOperationRequest(){}
        public void SerializeOperationResponse(){}
        public void Deserialize(){} // RVA: 0x7FFAC89BC3A0 | overloaded x2
        public void DeserializeShort(){} // RVA: 0x7FFAC2C5F5D0
        public void DeserializeByte(){} // RVA: 0x7FFAC2C59F60
        public void DeserializeEventData(){}
        public void DeserializeOperationRequest(){} // RVA: 0x7FFAC2C69DD0
        public void DeserializeOperationResponse(){} // RVA: 0x7FFAC2C69DD0
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFAC2C58F40
        public void DeserializeMessage(){} // RVA: 0x7FFAC89BC490
        public void TryRegisterType(){} // RVA: 0x7FFAC89BC4F0
        public void .ctor(){} // RVA: 0x7FFAC89BC860
        public void .cctor(){} // RVA: 0x7FFAC89BC900
    }

    public class Protocol16 : Protocol
    {
        public byte[] ProtocolType; // 0x18
        public byte[] VersionBytes; // 0x20
        public long[] memLongBlock; // 0x28
        public byte[] memLongBlockBytes; // 0x30
        public float[] memFloatBlock;
        public byte[] memFloatBlockBytes; // 0x8
        public double[] memDoubleBlock; // 0x38
        public byte[] memDoubleBlockBytes; // 0x40
        public byte[] memInteger; // 0x48
        public byte[] memLong; // 0x50
        public byte[] memFloat; // 0x58
        public byte[] memDouble; // 0x60

        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7FFAC89BCAA0
        public void get_VersionBytes(){} // RVA: 0x7FFAC2F247C0
        public void SerializeCustom(){} // RVA: 0x7FFAC89BCAE0
        public void DeserializeCustom(){} // RVA: 0x7FFAC89BCEB0
        public void GetTypeOfCode(){} // RVA: 0x7FFAC89BD1E0
        public void GetCodeOfType(){} // RVA: 0x7FFAC89BD560
        public void CreateArrayByType(){} // RVA: 0x7FFAC89BD900
        public void SerializeOperationRequest(){} // RVA: 0x7FFAC89BD970 | overloaded x2
        public void DeserializeOperationRequest(){} // RVA: 0x7FFAC89BDA50
        public void SerializeOperationResponse(){} // RVA: 0x7FFAC89BDB40
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFAC89BDCD0
        public void DeserializeOperationResponse(){} // RVA: 0x7FFAC89BDEA0
        public void SerializeEventData(){} // RVA: 0x7FFAC89BE090
        public void DeserializeEventData(){} // RVA: 0x7FFAC89BE170
        public void SerializeParameterTable(){} // RVA: 0x7FFAC89BE230
        public void DeserializeParameterDictionary(){} // RVA: 0x7FFAC89BE5C0
        public void Serialize(){} // RVA: 0x7FFAC89BE6F0
        public void SerializeByte(){} // RVA: 0x7FFAC89BF320
        public void SerializeBoolean(){} // RVA: 0x7FFAC89BF3D0
        public void SerializeShort(){} // RVA: 0x7FFAC89BF480
        public void SerializeLengthAsShort(){} // RVA: 0x7FFAC89BF6D0
        public void SerializeInteger(){} // RVA: 0x7FFAC89BF920
        public void SerializeLong(){} // RVA: 0x7FFAC89BFB90
        public void SerializeFloat(){} // RVA: 0x7FFAC89C0040
        public void SerializeDouble(){} // RVA: 0x7FFAC89C05B0
        public void SerializeString(){} // RVA: 0x7FFAC89C0A70
        public void SerializeArray(){} // RVA: 0x7FFAC89C0C50
        public void SerializeByteArray(){} // RVA: 0x7FFAC89C1330
        public void SerializeByteArraySegment(){} // RVA: 0x7FFAC89C13F0
        public void SerializeIntArrayOptimized(){} // RVA: 0x7FFAC89C14D0
        public void SerializeObjectArray(){} // RVA: 0x7FFAC89C1730
        public void SerializeHashTable(){} // RVA: 0x7FFAC89C1980
        public void SerializeDictionary(){} // RVA: 0x7FFAC89C1CE0
        public void SerializeDictionaryHeader(){} // RVA: 0x7FFAC89C1DE0 | overloaded x2
        public void SerializeDictionaryElements(){} // RVA: 0x7FFAC89C2220
        public void Deserialize(){} // RVA: 0x7FFAC89C2580
        public void DeserializeByte(){} // RVA: 0x7FFAC89C2EB0
        public void DeserializeBoolean(){} // RVA: 0x7FFAC89C2ED0
        public void DeserializeShort(){} // RVA: 0x7FFAC89C2F00
        public void DeserializeInteger(){} // RVA: 0x7FFAC89C32B0
        public void DeserializeLong(){} // RVA: 0x7FFAC89C3680
        public void DeserializeFloat(){} // RVA: 0x7FFAC89C3AC0
        public void DeserializeDouble(){} // RVA: 0x7FFAC89C3F00
        public void DeserializeString(){} // RVA: 0x7FFAC89C43D0
        public void DeserializeArray(){} // RVA: 0x7FFAC89C4530
        public void DeserializeByteArray(){} // RVA: 0x7FFAC89C4F50
        public void DeserializeIntArray(){} // RVA: 0x7FFAC89C5010
        public void DeserializeStringArray(){} // RVA: 0x7FFAC89C50D0
        public void DeserializeObjectArray(){} // RVA: 0x7FFAC89C51E0
        public void DeserializeHashTable(){} // RVA: 0x7FFAC89C5360
        public void DeserializeDictionary(){} // RVA: 0x7FFAC89C54D0
        public void DeserializeDictionaryArray(){} // RVA: 0x7FFAC89C58B0
        public void DeserializeDictionaryType(){} // RVA: 0x7FFAC89C5B60
        public void .ctor(){} // RVA: 0x7FFAC89C5E30
        public void .cctor(){} // RVA: 0x7FFAC89C62B0
    }

    public class Protocol18 : Protocol
    {
        public byte[] ProtocolType; // 0x18
        public byte[] VersionBytes;
        public double[] memDoubleBlock; // 0x20
        public float[] memFloatBlock; // 0x28
        public byte[] memCustomTypeBodyLengthSerialized; // 0x30
        public byte[] memCompressedUInt32; // 0x38
        public byte[] memCompressedUInt64; // 0x40

        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7FFAC89C6460
        public void get_VersionBytes(){} // RVA: 0x7FFAC2F247C0
        public void Serialize(){} // RVA: 0x7FFAC89C64A0
        public void SerializeShort(){} // RVA: 0x7FFAC89C6520
        public void SerializeString(){} // RVA: 0x7FFAC89C6590
        public void Deserialize(){} // RVA: 0x7FFAC89C65A0
        public void DeserializeShort(){} // RVA: 0x7FFAC89C65C0
        public void DeserializeByte(){} // RVA: 0x7FFAC89C2EB0
        public void GetAllowedDictionaryKeyTypes(){} // RVA: 0x7FFAC89C6640
        public void GetClrArrayType(){} // RVA: 0x7FFAC89C6830
        public void GetCodeOfType(){} // RVA: 0x7FFAC89C6B90
        public void GetCodeOfTypeCode(){} // RVA: 0x7FFAC89C73B0
        public void Read(){} // RVA: 0x7FFAC89C74A0 | overloaded x2
        public void ReadBoolean(){} // RVA: 0x7FFAC89C2ED0
        public void ReadByte(){} // RVA: 0x7FFAC89C2EB0
        public void ReadInt16(){} // RVA: 0x7FFAC89C65C0
        public void ReadUShort(){} // RVA: 0x7FFAC89C65C0
        public void ReadSingle(){} // RVA: 0x7FFAC89C8750
        public void ReadDouble(){} // RVA: 0x7FFAC89C87F0
        public void ReadNonAllocByteArray(){} // RVA: 0x7FFAC89C8890
        public void ReadByteArray(){} // RVA: 0x7FFAC89C8930
        public void ReadCustomType(){} // RVA: 0x7FFAC89C89E0
        public void DeserializeEventData(){} // RVA: 0x7FFAC89C8DA0
        public void ReadParameterDictionary(){} // RVA: 0x7FFAC89C8FE0
        public void ReadHashtable(){} // RVA: 0x7FFAC89C9110
        public void DeserializeOperationRequest(){} // RVA: 0x7FFAC89C9300
        public void DeserializeOperationResponse(){} // RVA: 0x7FFAC89C93F0
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFAC89C9600
        public void ReadString(){} // RVA: 0x7FFAC89C97E0
        public void ReadCustomTypeArray(){} // RVA: 0x7FFAC89C98C0
        public void ReadDictionaryType(){} // RVA: 0x7FFAC89CA160 | overloaded x2
        public void GetDictArrayType(){} // RVA: 0x7FFAC89CA410
        public void ReadDictionary(){} // RVA: 0x7FFAC89CA510
        public void ReadDictionaryElements(){} // RVA: 0x7FFAC89CA740
        public void ReadObjectArray(){} // RVA: 0x7FFAC89CA8C0
        public void ReadBooleanArray(){} // RVA: 0x7FFAC89CAA30
        public void ReadInt16Array(){} // RVA: 0x7FFAC89CAC70
        public void ReadSingleArray(){} // RVA: 0x7FFAC89CAD70
        public void ReadDoubleArray(){} // RVA: 0x7FFAC89CAE30
        public void ReadStringArray(){} // RVA: 0x7FFAC89CAEF0
        public void ReadHashtableArray(){} // RVA: 0x7FFAC89CAFF0
        public void ReadDictionaryArray(){} // RVA: 0x7FFAC89CB180
        public void ReadArrayInArray(){} // RVA: 0x7FFAC89CB510
        public void ReadInt1(){} // RVA: 0x7FFAC89CB6B0
        public void ReadInt2(){} // RVA: 0x7FFAC89CB6F0
        public void ReadCompressedInt32(){} // RVA: 0x7FFAC89CB7B0
        public void ReadCompressedUInt32(){} // RVA: 0x7FFAC89CB7D0
        public void ReadCompressedInt64(){} // RVA: 0x7FFAC89CBA70
        public void ReadCompressedUInt64(){} // RVA: 0x7FFAC89CBB50
        public void ReadCompressedInt32Array(){} // RVA: 0x7FFAC89CBC20
        public void ReadCompressedInt64Array(){} // RVA: 0x7FFAC89CBCE0
        public void DecodeZigZag32(){} // RVA: 0x7FFAC89CBD90
        public void DecodeZigZag64(){} // RVA: 0x7FFAC89CBDA0
        public void Write(){} // RVA: 0x7FFAC89CBDB0 | overloaded x2
        public void SerializeEventData(){} // RVA: 0x7FFAC89CD3F0
        public void WriteParameterTable(){} // RVA: 0x7FFAC89CD4D0
        public void SerializeOperationRequest(){} // RVA: 0x7FFAC89CD8D0 | overloaded x2
        public void SerializeOperationResponse(){} // RVA: 0x7FFAC89CD9B0
        public void WriteByte(){} // RVA: 0x7FFAC89CDB60
        public void WriteBoolean(){} // RVA: 0x7FFAC89CDBF0
        public void WriteUShort(){} // RVA: 0x7FFAC89CDC90
        public void WriteInt16(){} // RVA: 0x7FFAC89C6520
        public void WriteDouble(){} // RVA: 0x7FFAC89CDCC0
        public void WriteSingle(){} // RVA: 0x7FFAC89CE070
        public void WriteString(){} // RVA: 0x7FFAC89CE420
        public void WriteHashtable(){} // RVA: 0x7FFAC89CE5D0
        public void WriteByteArray(){} // RVA: 0x7FFAC89CE8E0
        public void WriteArraySegmentByte(){} // RVA: 0x7FFAC89CE990
        public void WriteByteArraySlice(){} // RVA: 0x7FFAC89CEAE0
        public void WriteInt32ArrayCompressed(){} // RVA: 0x7FFAC89CEBC0
        public void WriteInt64ArrayCompressed(){} // RVA: 0x7FFAC89CEC90
        public void WriteBoolArray(){} // RVA: 0x7FFAC89CED70
        public void WriteInt16Array(){} // RVA: 0x7FFAC89CF060
        public void WriteSingleArray(){} // RVA: 0x7FFAC89CF130
        public void WriteDoubleArray(){} // RVA: 0x7FFAC89CF220
        public void WriteStringArray(){} // RVA: 0x7FFAC89CF310
        public void WriteObjectArray(){} // RVA: 0x7FFAC89CF4D0
        public void WriteArrayInArray(){} // RVA: 0x7FFAC89CF6F0
        public void WriteCustomTypeBody(){} // RVA: 0x7FFAC89CF820
        public void WriteCustomType(){} // RVA: 0x7FFAC89CFAC0
        public void WriteCustomTypeArray(){} // RVA: 0x7FFAC89CFFA0
        public void WriteArrayHeader(){} // RVA: 0x7FFAC89D0630
        public void WriteDictionaryElements(){} // RVA: 0x7FFAC89D0790
        public void WriteDictionary(){} // RVA: 0x7FFAC89D0A60
        public void WriteDictionaryHeader(){} // RVA: 0x7FFAC89D0BA0
        public void WriteArrayType(){} // RVA: 0x7FFAC89D1360
        public void WriteHashtableArray(){} // RVA: 0x7FFAC89D1830
        public void WriteDictionaryArray(){} // RVA: 0x7FFAC89D1980
        public void WriteIntLength(){} // RVA: 0x7FFAC89D1AC0
        public void WriteCompressedInt32(){} // RVA: 0x7FFAC89D1AD0
        public void WriteCompressedInt64(){} // RVA: 0x7FFAC89D1C80
        public void WriteCompressedUInt32(){} // RVA: 0x7FFAC89D2020 | overloaded x2
        public void WriteCompressedUInt64(){} // RVA: 0x7FFAC89D2090
        public void EncodeZigZag32(){} // RVA: 0x7FFAC89D22D0
        public void EncodeZigZag64(){} // RVA: 0x7FFAC89D22E0
        public void .ctor(){} // RVA: 0x7FFAC89D22F0
        public void .cctor(){} // RVA: 0x7FFAC89D25F0
    }

    public class SendOptions : ValueType
    {
        public Photon.Client.SendOptions Reliability;
        public Photon.Client.SendOptions SendUnreliable; // 0x8
        public 0x6B26B4D0 DeliveryMode; // 0x10
        public bool Encrypt; // 0x14
        public byte Channel; // 0x15

        // ── Methods ──
        public void get_Reliability(){} // RVA: 0x7FFAC89D37A0
        public void set_Reliability(){} // RVA: 0x7FFAC89D37B0
        public void .cctor(){} // RVA: 0x7FFAC89D37C0
    }

    public class SerializationProtocolFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC89BBFE0
    }

    public class SerializeStreamMethod : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5CBD790
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class SimulationItem : Object
    {
        public System.Diagnostics.Stopwatch Delay; // 0x10
        public int TimeToExecute; // 0x18
        public byte[] DelayedData; // 0x20
        public int <Delay>k__BackingField; // 0x28

        // ── Methods ──
        public void get_Delay(){} // RVA: 0x7FFAC32EC4C0
    }

    public class SocketTcp : PhotonSocket
    {
        public System.Net.Sockets.Socket sock; // 0x60
        public object syncer; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89D3830
        public void Finalize(){} // RVA: 0x7FFAC89D3950
        public void Dispose(){} // RVA: 0x7FFAC89D3990
        public void Connect(){} // RVA: 0x7FFAC89D3AA0
        public void Disconnect(){} // RVA: 0x7FFAC89D3D40
        public void Send(){} // RVA: 0x7FFAC89D3FA0
        public void Receive(){} // RVA: 0x7FFAC45A87F0
        public void DnsAndConnect(){} // RVA: 0x7FFAC89D4290
        public void ReceiveLoop(){} // RVA: 0x7FFAC89D49C0
    }

    public class SocketTcpAsync : PhotonSocket
    {
        public System.Net.Sockets.Socket sock; // 0x60
        public object syncer; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89D53C0
        public void Finalize(){} // RVA: 0x7FFAC89D54E0
        public void Dispose(){} // RVA: 0x7FFAC89D5520
        public void Connect(){} // RVA: 0x7FFAC89D5640
        public void Disconnect(){} // RVA: 0x7FFAC89D58E0
        public void Send(){} // RVA: 0x7FFAC89D5B70
        public void Receive(){} // RVA: 0x7FFAC45A87F0
        public void DnsAndConnect(){} // RVA: 0x7FFAC89D60A0
        public void ReceiveAsync(){} // RVA: 0x7FFAC89D6BB0 | overloaded x2
    }

    public class SocketUdp : PhotonSocket
    {
        public System.Net.Sockets.Socket sock; // 0x60
        public object syncer; // 0x68
        public object sendLockObject; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89D73C0
        public void Finalize(){} // RVA: 0x7FFAC89D7550
        public void Dispose(){} // RVA: 0x7FFAC89D7590
        public void Connect(){} // RVA: 0x7FFAC89D76B0
        public void Disconnect(){} // RVA: 0x7FFAC89D7950
        public void Send(){} // RVA: 0x7FFAC89D7BE0
        public void Receive(){} // RVA: 0x7FFAC45A87F0
        public void DnsAndConnect(){} // RVA: 0x7FFAC89D8750
        public void ReceiveLoop(){} // RVA: 0x7FFAC89D8DC0
    }

    public class SocketUdpAsync : PhotonSocket
    {
        public System.Net.Sockets.Socket sock; // 0x60
        public object syncer; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89D94F0
        public void Finalize(){} // RVA: 0x7FFAC89D54E0
        public void Dispose(){} // RVA: 0x7FFAC89D5520
        public void Connect(){} // RVA: 0x7FFAC89D9610
        public void Disconnect(){} // RVA: 0x7FFAC89D98B0
        public void Send(){} // RVA: 0x7FFAC89D9B40
        public void Receive(){} // RVA: 0x7FFAC45A87F0
        public void DnsAndConnect(){} // RVA: 0x7FFAC89DA0A0
        public void StartReceive(){} // RVA: 0x7FFAC89DA610
        public void OnReceive(){} // RVA: 0x7FFAC89DA890
    }

    public class StreamBuffer : Object
    {
        public int Length;
        public int Position; // 0x10
        public int Available; // 0x14
        public byte[] buf; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89DB280 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFAC89DB2F0
        public void Compact(){} // RVA: 0x7FFAC89DB360
        public void GetBuffer(){} // RVA: 0x7FFAC2F247C0
        public void GetBufferAndAdvance(){} // RVA: 0x7FFAC89DB3E0
        public void get_Length(){} // RVA: 0x7FFAC33D5A20
        public void get_Position(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Position(){} // RVA: 0x7FFAC89DB420
        public void get_Available(){} // RVA: 0x7FFAC89DB440
        public void Reset(){} // RVA: 0x7FFAC89DB450
        public void Seek(){} // RVA: 0x7FFAC89DB460
        public void SetLength(){} // RVA: 0x7FFAC89DB580
        public void SetCapacityMinimum(){} // RVA: 0x7FFAC89DB5B0
        public void Read(){} // RVA: 0x7FFAC89DB5C0
        public void Write(){} // RVA: 0x7FFAC89DB620
        public void ReadByte(){} // RVA: 0x7FFAC89DB6A0
        public void WriteByte(){} // RVA: 0x7FFAC89DB790
        public void WriteBytes(){} // RVA: 0x7FFAC89DB7F0
        public void CheckSize(){} // RVA: 0x7FFAC89DB880
    }

    public class SupportClass : Object
    {
        public uint[] crcLookupTable;

        // ── Methods ──
        public void WriteStackTrace(){} // RVA: 0x7FFAC89DB990
        public void DictionaryToString(){} // RVA: 0x7FFAC89DC530 | overloaded x2
        public void ByteArrayToString(){} // RVA: 0x7FFAC89DD060
        public void InitializeTable(){} // RVA: 0x7FFAC89DD0E0
        public void CalculateCrc(){} // RVA: 0x7FFAC89DD410 | overloaded x2
    }

    public class TPeer : PeerBase
    {
        public System.Collections.Generic.Queue`1<Photon.Client.StreamBuffer> QueuedOutgoingCommandsCount; // 0x128
        public System.Collections.Generic.List`1<Photon.Client.StreamBuffer> outgoingStream; // 0x130
        public int lastPingActivity; // 0x138
        public byte[] pingRequest; // 0x140
        public Photon.Client.ParameterDictionary pingParamDict; // 0x148
        public byte[] tcpFramedMessageHead;
        public byte[] tcpMsgHead; // 0x8
        public bool DoFraming; // 0x150

        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7FFAC89DD6F0
        public void .ctor(){} // RVA: 0x7FFAC89DD740
        public void IsTransportEncrypted(){} // RVA: 0x7FFAC89DD970
        public void Reset(){} // RVA: 0x7FFAC89DD980
        public void Connect(){} // RVA: 0x7FFAC89DDB10
        public void Disconnect(){} // RVA: 0x7FFAC89DDF70 | overloaded x2
        public void FetchServerTimestamp(){} // RVA: 0x7FFAC89DE220
        public void EnqueueInit(){} // RVA: 0x7FFAC89DE360
        public void DispatchIncomingCommands(){} // RVA: 0x7FFAC89DE500
        public void SendOutgoingCommands(){} // RVA: 0x7FFAC89DEA40
        public void SendAcksOnly(){} // RVA: 0x7FFAC89DEF10
        public void EnqueuePhotonMessage(){} // RVA: 0x7FFAC89DEF80
        public void EnqueueMessageAsPayload(){} // RVA: 0x7FFAC89DEFB0
        public void SendPing(){} // RVA: 0x7FFAC89DF360
        public void SendData(){} // RVA: 0x7FFAC89DF800
        public void ReceiveIncomingCommands(){} // RVA: 0x7FFAC89DF990
        public void ReadPingResult(){} // RVA: 0x7FFAC89E0030 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC89E0180
    }

    public class TrafficStats : TrafficStatsBase
    {
        public System.Diagnostics.Stopwatch LastReceiveTimestamp; // 0x60
        public int LastDispatchTimestamp; // 0x68
        public int LongestDeltaBetweenDispatchCalls; // 0x6C
        public int LastDispatchDuration; // 0x70
        public int LongestDeltaBetweenSendOutgoingCalls; // 0x74
        public int <LongestDeltaBetweenDispatchCalls>k__BackingField; // 0x78
        public int <LastDispatchDuration>k__BackingField; // 0x7C
        public int <LongestDeltaBetweenSendOutgoingCalls>k__BackingField; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FBF380
        public void get_LastReceiveTimestamp(){} // RVA: 0x7FFAC3B99E80
        public void set_LastReceiveTimestamp(){} // RVA: 0x7FFAC30B6520
        public void get_LastDispatchTimestamp(){} // RVA: 0x7FFAC43D9E20
        public void set_LastDispatchTimestamp(){} // RVA: 0x7FFAC48B4C80
        public void get_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x7FFAC4596EF0
        public void set_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x7FFAC45963A0
        public void set_LastDispatchDuration(){} // RVA: 0x7FFAC89E0310
        public void get_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0x7FFAC35729C0
        public void set_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0x7FFAC3572BF0
        public void DispatchIncomingCommandsCalled(){} // RVA: 0x7FFAC89E0320
        public void SendOutgoingCommandsCalled(){} // RVA: 0x7FFAC89E0340
        public void ToString(){} // RVA: 0x7FFAC89E0370 | overloaded x2
    }

    public class TrafficStatsBase : Object
    {
        public long BytesIn; // 0x10
        public long BytesOut; // 0x18
        public int PackagesIn; // 0x20
        public int PackagesOut; // 0x24
        public int UdpFragmentsIn; // 0x28
        public int UdpFragmentsOut; // 0x2C
        public int UdpUnreliableCommandsSent; // 0x30
        public int UdpReliableCommandsSent; // 0x34
        public int UdpReliableCommandsResent; // 0x38
        public int UdpReliableCommandsInFlight; // 0x3C
        public int DispatchIncomingCommandsCalls; // 0x40
        public int SendOutgoingCommandsCalls; // 0x44
        public long RoundtripTime; // 0x48
        public long RoundtripTimeVariance; // 0x50
        public long LastRoundtripTime; // 0x58

        // ── Methods ──
        public void get_BytesIn(){} // RVA: 0x7FFAC2F3C380
        public void set_BytesIn(){} // RVA: 0x7FFAC441EFB0
        public void get_BytesOut(){} // RVA: 0x7FFAC2F247C0
        public void set_BytesOut(){} // RVA: 0x7FFAC38920D0
        public void get_PackagesIn(){} // RVA: 0x7FFAC30DBBE0
        public void set_PackagesIn(){} // RVA: 0x7FFAC35DB7A0
        public void get_PackagesOut(){} // RVA: 0x7FFAC3921980
        public void set_PackagesOut(){} // RVA: 0x7FFAC41674D0
        public void get_UdpFragmentsIn(){} // RVA: 0x7FFAC32EC4C0
        public void set_UdpFragmentsIn(){} // RVA: 0x7FFAC369A6E0
        public void get_UdpFragmentsOut(){} // RVA: 0x7FFAC3C891D0
        public void set_UdpFragmentsOut(){} // RVA: 0x7FFAC45B6490
        public void get_UdpUnreliableCommandsSent(){} // RVA: 0x7FFAC2F7CCD0
        public void set_UdpUnreliableCommandsSent(){} // RVA: 0x7FFAC2F7CCE0
        public void get_UdpReliableCommandsSent(){} // RVA: 0x7FFAC3ADEDC0
        public void set_UdpReliableCommandsSent(){} // RVA: 0x7FFAC416A6E0
        public void get_UdpReliableCommandsResent(){} // RVA: 0x7FFAC358A870
        public void set_UdpReliableCommandsResent(){} // RVA: 0x7FFAC3588350
        public void set_UdpReliableCommandsInFlight(){} // RVA: 0x7FFAC47E2CD0
        public void get_DispatchIncomingCommandsCalls(){} // RVA: 0x7FFAC2FC2080
        public void set_DispatchIncomingCommandsCalls(){} // RVA: 0x7FFAC2FC2090
        public void get_SendOutgoingCommandsCalls(){} // RVA: 0x7FFAC2FC20A0
        public void set_SendOutgoingCommandsCalls(){} // RVA: 0x7FFAC2FC20B0
        public void get_RoundtripTime(){} // RVA: 0x7FFAC2F9C730
        public void set_RoundtripTime(){} // RVA: 0x7FFAC4248FC0
        public void get_RoundtripTimeVariance(){} // RVA: 0x7FFAC2FC20E0
        public void set_RoundtripTimeVariance(){} // RVA: 0x7FFAC42499F0
        public void set_LastRoundtripTime(){} // RVA: 0x7FFAC4249140
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnknownType : Object
    {
        public byte TypeCode; // 0x10
        public int Size; // 0x14
        public byte[] Data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Version : Object
    {
        public byte[] clientVersion;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC89E0AB0
    }

}