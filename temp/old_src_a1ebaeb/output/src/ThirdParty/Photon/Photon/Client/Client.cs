// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client
// Classes: 31
// Methods: 483

namespace ThirdParty.Photon.Photon.Client
{
    public class CustomType : Object
    {
        public object SerializeStreamFunction; // 0x36064DF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3dd400
    }

    public class DeserializeStreamMethod : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3dd280
        public void Invoke(){} // RVA: 0x7ffaa8a8e370
    }

    public class EnetChannel : Object
    {
        public object incomingUnreliableCommandsList; // 0x35FB3920
        public object outgoingReliableCommandsList; // 0x35FB3920
        public object incomingUnreliableSequenceNumber; // 0x35FB3920
        public object outgoingReliableUnsequencedNumber; // 0x35FB3920
        public object highestReceivedAck; // 0x35FB3920
        public object SequencedReceived; // 0x35FB3920
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3c24b0
        public void AddSequencedIfNew(){} // RVA: 0x7ffaae3c2980
        public void TryGetFragment(){} // RVA: 0x7ffaae3c2a50
        public void RemoveFragment(){} // RVA: 0x7ffaae3c2ad0
        public void clearAll(){} // RVA: 0x7ffaae3c2b40
        public void QueueIncomingReliableUnsequenced(){} // RVA: 0x7ffaae3c2e80
        public void ApplySequenceNumberModifier(){} // RVA: 0x7ffaae3c31c0
        public void Received(){} // RVA: 0x7ffaae3c3210
        // ── Binary Analysis Named ──
        public void GetGapBlock(){} // RVA: 0x7ffaae3c34c0
    }

    public class EnetPeer : PeerBase
    {
        public object sendWindowUpdateRequiredBackValue; // 0x35FB2840
        public object outgoingUnsequencedGroupNumber; // 0x35FB2840
        public object udpBuffer; // 0x35FB2840
        public object commandBufferSize; // 0x35FB2840
        public object udpHeader0xF3; // 0x35FB2840
        public object commandsToRemove; // 0x35FB2840
        public object fragmentLengthDatagramEncrypt; // 0x35FB2840
        public object channelsToUpdateLowestSent; // 0x35FB2840
        public object toRemove; // 0x35FB2840
        public object QueuedOutgoingCommandsCount; // 0x17000010
        public object SendWindowUpdateRequired; // 0x17000011
        public object DatagramEncryptedConnection; // 0x17000012
        public object useAck2; // 0x17000013

        // ── Original Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7ffaae3c38f0
        public void get_SendWindowUpdateRequired(){} // RVA: 0x7ffaae3c3c10
        public void set_SendWindowUpdateRequired(){} // RVA: 0x7ffaae3c3c30
        public void get_DatagramEncryptedConnection(){} // RVA: 0x7ffaae3c3c50
        public void set_DatagramEncryptedConnection(){} // RVA: 0x7ffaae3c3c70
        public void get_useAck2(){} // RVA: 0x7ffaae3c3c90
        public void .ctor(){} // RVA: 0x7ffaae3c3cc0
        public void IsTransportEncrypted(){} // RVA: 0x7ffaae3c3c50
        public void Reset(){} // RVA: 0x7ffaae3c4650
        public void ApplyRandomizedSequenceNumbers(){} // RVA: 0x7ffaae3c4ec0
        public void Connect(){} // RVA: 0x7ffaae3c5140
        public void Disconnect(){} // RVA: 0x7ffaae3c5210
        public void FetchServerTimestamp(){} // RVA: 0x7ffaae3c5750
        public void DispatchCommandQueue(){} // RVA: 0x7ffaae3c5870
        public void DispatchIncomingCommands(){} // RVA: 0x7ffaae3c5950
        public void CalculatePacketSize(){} // RVA: 0x7ffaae3c65c0
        public void CalculateInitialOffset(){} // RVA: 0x7ffaae3c6650
        public void SendAcksOnly(){} // RVA: 0x7ffaae3c66a0
        public void SendOutgoingCommands(){} // RVA: 0x7ffaae3c66c0
        public void SendOutgoingCommands(){} // RVA: 0x7ffaae3c66c0
        public void UpdateSendWindow(){} // RVA: 0x7ffaae3c77c0
        public void EnqueuePhotonMessage(){} // RVA: 0x7ffaae3c8200
        public void CreateAndEnqueueCommand(){} // RVA: 0x7ffaae3c8250
        public void SerializeAckToBuffer(){} // RVA: 0x7ffaae3c8840
        public void SerializeToBuffer(){} // RVA: 0x7ffaae3c8d40
        public void SerializeCommandToBuffer(){} // RVA: 0x7ffaae3c8e90
        public void SendData(){} // RVA: 0x7ffaae3c9070
        public void SendToSocket(){} // RVA: 0x7ffaae3c93e0
        public void SendDataEncrypted(){} // RVA: 0x7ffaae3c9550
        public void QueueSentCommand(){} // RVA: 0x7ffaae3c9860
        public void QueueOutgoingReliableCommand(){} // RVA: 0x7ffaae3c9c00
        public void QueueOutgoingUnreliableCommand(){} // RVA: 0x7ffaae3c9e30
        public void QueueOutgoingAcknowledgement(){} // RVA: 0x7ffaae3ca0d0
        public void ReceiveIncomingCommands(){} // RVA: 0x7ffaae3ca5d0
        public void ExecuteCommand(){} // RVA: 0x7ffaae3cb190
        public void QueueIncomingCommand(){} // RVA: 0x7ffaae3cc990
        public void RemoveSentReliableCommand(){} // RVA: 0x7ffaae3cd280
        public void .cctor(){} // RVA: 0x7ffaae3cd720
        public void <ExecuteCommand>b__78_0(){} // RVA: 0x7ffaae3cd800
        // ── Binary Analysis Named ──
        public void GetChannel(){} // RVA: 0x7ffaae3c50e0
        public void GetFragmentLength(){} // RVA: 0x7ffaae3c64e0
    }

    public class EventData : Object
    {
        public object SenderKey; // 0x345FD200
        public object customData; // 0x345FD200
        public object Invoke; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3f3d10
        public void get_Item(){} // RVA: 0x7ffaae3f3dc0
        public void get_Sender(){} // RVA: 0x7ffaae3f3e30
        public void set_Sender(){} // RVA: 0x7ffaa9b8c1b0
        public void get_CustomData(){} // RVA: 0x7ffaae3f3eb0
        public void Reset(){} // RVA: 0x7ffaae3f3f40
        public void ToString(){} // RVA: 0x7ffaae3f3fc0
    }

    public class IPhotonPeerListener
    {
        // ── Original Methods ──
        public void DebugReturn(){} // RVA: 0x7ffaa86618c0
        public void OnOperationResponse(){} // RVA: 0x7ffaa8660d80
        public void OnStatusChanged(){} // RVA: 0x7ffaa8661210
        public void OnEvent(){} // RVA: 0x7ffaa8660d80
        public void OnMessage(){} // RVA: 0x7ffaa86618c0
        public void OnDisconnectMessage(){} // RVA: 0x7ffaa8660d80
    }

    public class NCommand : Object
    {
        public object FeatureFlagsLow; // 0x35FB3750
        public object FV_UNRELIABLE_UNSEQUENCED; // 0x35FB3750
        public object CT_ACK; // 0x35FB3750
        public object CT_DISCONNECT; // 0x35FB3750
        public object CT_SENDUNRELIABLE; // 0x35FB3750
        public object CT_EG_SERVERTIME; // 0x35FB3750
        public object CT_EG_SEND_FRAGMENT_UNSEQUENCED; // 0x35FB3750
        public object CT_EG_ACK_2_UNSEQUENCED; // 0x35FB3750
        public object CmdSizeMinimum; // 0x35FB3750
        public object CmdSizeVerifyConnect; // 0x35FB3750
        public object CmdSizeReliableHeader; // 0x35FB3750
        public object CmdSizeFragmentHeader; // 0x35FB3750
        public object commandType; // 0x35FB3750
        public object unreliableSequenceNumber; // 0x35FB3750
        public object startSequenceNumber; // 0x35FB3750
        public object totalLength; // 0x35FB3750
        public object commandSentTime; // 0x35FB3750
        public object timeoutTime; // 0x35FB3750
        public object TimeOfReceive; // 0x35FB3750
        public object  y20; // 0x20150000
        public object  y20;
        public object c2); // 0x35F0A518
        public object 0C; // 0x35F0A530
        public object `r5; // 0x80150000

        // ── Original Methods ──
        public void get_SizeOfPayload(){} // RVA: 0x7ffaae3cd960
        public void get_IsFlaggedUnsequenced(){} // RVA: 0x7ffaae3cd980
        public void get_IsFlaggedReliable(){} // RVA: 0x7ffaae3cd990
        public void CreateAck(){} // RVA: 0x7ffaae3cd9b0
        public void CreateAck2(){} // RVA: 0x7ffaae3cdbe0
        public void Initialize(){} // RVA: 0x7ffaae3ce1b0
        public void Initialize(){} // RVA: 0x7ffaae3ce1b0
        public void Reset(){} // RVA: 0x7ffaae3ce7d0
        public void SerializeHeader(){} // RVA: 0x7ffaae3ce810
        public void Serialize(){} // RVA: 0x7ffaae3ceca0
        public void FreePayload(){} // RVA: 0x7ffaae3cecc0
        public void CompareTo(){} // RVA: 0x7ffaae3ceda0
        public void ToString(){} // RVA: 0x7ffaae3cede0
        public void ToString(){} // RVA: 0x7ffaae3cede0
        public void .ctor(){} // RVA: 0x7ffaae3cf640
    }

    public class NetworkSimulationSet : Object
    {
        public object outgoingJitter; // 0x360641B0
        public object incomingJitter; // 0x360641B0
        public object netSimThread; // 0x360641B0
        public object _lostPackagesIn; // 0x360641B0, was: <LostPackagesIn>k__BackingFiel
        public object IsSimulationEnabled; // 0x17000018
        public object OutgoingLossPercentage; // 0x17000019
        public object IncomingLossPercentage; // 0x1700001A
        public object LostPackagesOut; // 0x1700001B

        // ── Original Methods ──
        public void get_IsSimulationEnabled(){} // RVA: 0x7ffaa89fc5e0
        public void set_IsSimulationEnabled(){} // RVA: 0x7ffaae3cf650
        public void set_OutgoingLossPercentage(){} // RVA: 0x7ffaa9e6a2e0
        public void set_IncomingLossPercentage(){} // RVA: 0x7ffaa90c0cd0
        public void set_LostPackagesOut(){} // RVA: 0x7ffaa89d30d0
        public void set_LostPackagesIn(){} // RVA: 0x7ffaaa2a7b40
        public void ToString(){} // RVA: 0x7ffaae3d0280
        public void .ctor(){} // RVA: 0x7ffaae3d05d0
    }

    public class NonAllocDictionary`2 : Object
    {
        public object _freeCount; // 0x31134200
        public object _buckets; // 0x31134200
        public object keys; // 0x31134200

        // ── Original Methods ──
        public void get_Keys(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0x7ffaa86491d0
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void get_IsReadOnly(){} // RVA: 0x7ffaa864a040
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void ContainsKey(){} // RVA: 0x7ffaa887e5c0
        public void Contains(){} // RVA: 0x7ffaa887e5c0
        public void TryGetValue(){} // RVA: 0x7ffaa887e5c0
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void set_Item(){} // RVA: 0x7ffaa887e5c0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void FindNode(){} // RVA: 0x7ffaa887e5c0
        public void Insert(){} // RVA: 0x7ffaa887e5c0
        public void Expand(){} // RVA: 0x7ffaa8660cc0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void IsPrimeFromList(){} // RVA: 0x7ffaa864aae0
        public void Assert(){} // RVA: 0x7ffaa8661190
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa887e5c0
        public void GetNextPrime(){} // RVA: 0x7ffaa8650450
    }

    public class NonAllocDictionary`2 : Object
    {
        public object _freeCount; // 0x35FF4E10
        public object _buckets; // 0x35FF4E10
        public object keys; // 0x35FF4E10
        public object Keys; // 0x17000001
        public object System.Collections.Generic.IDictionary<K,V>.Values; // 0x17000002

        // ── Original Methods ──
        public void get_Keys(){} // RVA: 0x7ffaabfd2e00
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0x7ffaa89af740
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0x7ffaa8bf45b0
        public void get_Count(){} // RVA: 0x7ffaabfd2e60
        public void get_IsReadOnly(){} // RVA: 0x7ffaa8958450
        public void .ctor(){} // RVA: 0x7ffaabfd2e70
        public void ContainsKey(){} // RVA: 0x7ffaabfd3070
        public void Contains(){} // RVA: 0x7ffaabfd3090
        public void TryGetValue(){} // RVA: 0x7ffaabfd3140
        public void get_Item(){} // RVA: 0x7ffaabfd31e0
        public void set_Item(){} // RVA: 0x7ffaabfd32c0
        public void Add(){} // RVA: 0x7ffaabfd3540
        public void Add(){} // RVA: 0x7ffaabfd3540
        public void Remove(){} // RVA: 0x7ffaabfd37b0
        public void Remove(){} // RVA: 0x7ffaabfd37b0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x7ffaabfd3890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabfd3890
        public void FindNode(){} // RVA: 0x7ffaabfd3920
        public void Insert(){} // RVA: 0x7ffaabfd39b0
        public void Expand(){} // RVA: 0x7ffaabfd3ba0
        public void Clear(){} // RVA: 0x7ffaabfd3f60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x7ffaabfd3fc0
        public void IsPrimeFromList(){} // RVA: 0x7ffaabfd41b0
        public void Assert(){} // RVA: 0x7ffaabfd4620
        public void .cctor(){} // RVA: 0x7ffaabfd4680
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabfd2e00
        public void GetNextPrime(){} // RVA: 0x7ffaabfd4330
    }

    public class OperationResponse : Object
    {
        public object DebugMessage; // 0x345FD380

        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaae3f38e0
        public void ToString(){} // RVA: 0x7ffaae3f3950
        public void ToStringFull(){} // RVA: 0x7ffaae3f3ad0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ParameterDictionary : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3d07f0
        public void .ctor(){} // RVA: 0x7ffaae3d07f0
        public void op_Implicit(){} // RVA: 0x7ffaad0ae830
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Byte,System.Object>>.GetEnumerator(){} // RVA: 0x7ffaae3d0950
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaae3d09a0
        public void get_Item(){} // RVA: 0x7ffaae3d0aa0
        public void set_Item(){} // RVA: 0x7ffaae3d0b50
        public void get_Count(){} // RVA: 0x7ffaae3d0bc0
        public void Clear(){} // RVA: 0x7ffaae3d0c10
        public void Add(){} // RVA: 0x7ffaae3d1180
        public void Add(){} // RVA: 0x7ffaae3d1180
        public void Add(){} // RVA: 0x7ffaae3d1180
        public void Add(){} // RVA: 0x7ffaae3d1180
        public void Add(){} // RVA: 0x7ffaae3d1180
        public void ContainsKey(){} // RVA: 0x7ffaae3d1280
        public void TryGetValue(){} // RVA: 0x7ffaae3d12e0
        public void TryGetValue(){} // RVA: 0x7ffaae3d12e0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaae3d09f0
        public void Get(){} // RVA: 0x7ffaa887e5c0
    }

    public class PeerBase : Object
    {
        public object usedTransportProtocol; // 0x35FB2A90
        public object _proxyServerAddress; // 0x35FB2A90, was: <ProxyServerAddress>k__Backing
        public object ByteCountCurrentDispatch; // 0x35FB2A90
        public object packetLossByChallenge; // 0x35FB2A90
        public object peerID; // 0x35FB2A90
        public object serverTimeOffsetIsAvailable; // 0x35FB2A90
        public object lastRoundTripTime; // 0x35FB2A90
        public object varianceJitterMin; // 0x35FB2A90
        public object PhotonToken; // 0x35FB2A90
        public object reusableEventData; // 0x35FB2A90
        public object timeLastAckReceive; // 0x35FB2A90
        public object ApplicationIsInitialized; // 0x35FB2A90
        public object _serverFeatureFlagsAvailable; // 0x35FB2A90, was: <serverFeatureFlagsAvailable>k
        public object _serverMaxQueueableReliableCommands; // 0x35FB2A90, was: <ServerMaxQueueableReliableCom
        public object prepareWebSocketUrlCount; // 0x35FB2A90
        public object lagRandomizer; // 0x35FB2A90
        public object networkSimulationSettings; // 0x35FB2A90
        public object Stats; // 0x1700001F
        public object Listener; // 0x17000020
        public object LogLevel; // 0x17000021
        public object ServerAddress; // 0x17000022
        public object ProxyServerAddress; // 0x17000023
        public object peerConnectionState; // 0x17000024
        public object rttVarString; // 0x17000025
        public object TimeoutVarianceCompensation; // 0x17000026
        public object DisconnectTimeout; // 0x17000027
        public object PingInterval; // 0x17000028
        public object ChannelCount; // 0x17000029
        public object QueuedOutgoingCommandsCount; // 0x1700002A
        public object timeInt; // 0x1700002B
        public object ServerFeatureFlags; // 0x1700002C
        public object serverFeatureFlagsAvailable; // 0x1700002D
        public object serverFeatureAck2Available; // 0x1700002E
        public object serverFeatureSyncReliableQueue; // 0x1700002F

        // ── Original Methods ──
        public void get_Stats(){} // RVA: 0x7ffaa8efba10
        public void get_Listener(){} // RVA: 0x7ffaa919c330
        public void get_LogLevel(){} // RVA: 0x7ffaa9fb62b0
        public void get_ServerAddress(){} // RVA: 0x7ffaa8bfcc80
        public void set_ServerAddress(){} // RVA: 0x7ffaa8960890
        public void get_ProxyServerAddress(){} // RVA: 0x7ffaa8bf45b0
        public void set_ProxyServerAddress(){} // RVA: 0x7ffaa8bf45c0
        public void get_peerConnectionState(){} // RVA: 0x7ffaae3d13e0
        public void set_peerConnectionState(){} // RVA: 0x7ffaae3d13f0
        public void TryUpdateConnectionState(){} // RVA: 0x7ffaae3d1400
        public void get_rttVarString(){} // RVA: 0x7ffaae3d1420
        public void get_TimeoutVarianceCompensation(){} // RVA: 0x7ffaae3d1500
        public void get_DisconnectTimeout(){} // RVA: 0x7ffaae3d1560
        public void get_PingInterval(){} // RVA: 0x7ffaadf0ae50
        public void get_ChannelCount(){} // RVA: 0x7ffaae3d1580
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7ffaa8649ca0
        public void get_timeInt(){} // RVA: 0x7ffaae3d15a0
        public void set_ServerFeatureFlags(){} // RVA: 0x7ffaae3d15d0
        public void get_serverFeatureFlagsAvailable(){} // RVA: 0x7ffaae3d1610
        public void set_serverFeatureFlagsAvailable(){} // RVA: 0x7ffaae3d1620
        public void get_serverFeatureAck2Available(){} // RVA: 0x7ffaae3d1630
        public void set_serverFeatureAck2Available(){} // RVA: 0x7ffaae3d1640
        public void get_serverFeatureSyncReliableQueue(){} // RVA: 0x7ffaae3d1650
        public void set_serverFeatureSyncReliableQueue(){} // RVA: 0x7ffaae3d1660
        public void get_ServerMaxQueueableReliableCommands(){} // RVA: 0x7ffaae3d1670
        public void set_ServerMaxQueueableReliableCommands(){} // RVA: 0x7ffaae3d1680
        public void get_mtu(){} // RVA: 0x7ffaae3d1690
        public void get_IsIpv6(){} // RVA: 0x7ffaae3d16b0
        public void .ctor(){} // RVA: 0x7ffaae3d16d0
        public void Reset(){} // RVA: 0x7ffaae3d1c30
        public void Connect(){} // RVA: 0x7ffaa864d9c0
        public void WriteInitRequest(){} // RVA: 0x7ffaae3d25d0
        public void WriteInitV3(){} // RVA: 0x7ffaae3d2cd0
        public void PrepareWebSocketUrl(){} // RVA: 0x7ffaae3d32f0
        public void OnInitResponse(){} // RVA: 0x7ffaae3d3760
        public void Disconnect(){} // RVA: 0x7ffaa86613a0
        public void FetchServerTimestamp(){} // RVA: 0x7ffaa8660cc0
        public void IsTransportEncrypted(){} // RVA: 0x7ffaa864a040
        public void EnqueuePhotonMessage(){}
        public void SerializeOperationToMessage(){} // RVA: 0x7ffaae3d3800
        public void SendOutgoingCommands(){} // RVA: 0x7ffaa864a040
        public void SendAcksOnly(){} // RVA: 0x7ffaa8932320
        public void ReceiveIncomingCommands(){} // RVA: 0x7ffaa8667cb0
        public void DispatchIncomingCommands(){} // RVA: 0x7ffaa864a040
        public void DeserializeMessageAndCallback(){} // RVA: 0x7ffaae3d3ab0
        public void UpdateRoundTripTimeAndVariance(){} // RVA: 0x7ffaae3d4840
        public void ExchangeKeysForEncryption(){} // RVA: 0x7ffaae3d49b0
        public void DeriveSharedKey(){} // RVA: 0x7ffaae3d5050
        public void InitEncryption(){} // RVA: 0x7ffaae3d5200
        public void EnqueueActionForDispatch(){} // RVA: 0x7ffaae3d56a0
        public void EnqueueDebugReturn(){} // RVA: 0x7ffaae3d5820
        public void EnqueueStatusCallback(){} // RVA: 0x7ffaae3d5af0
        public void get_NetworkSimulationSettings(){} // RVA: 0x7ffaa8b68c40
        public void NetworkSimRun(){} // RVA: 0x7ffaae3d5d60
        public void .cctor(){} // RVA: 0x7ffaae3d6400
        public void <DeserializeMessageAndCallback>b__122_0(){} // RVA: 0x7ffaae3d65e0
        // ── Binary Analysis Named ──
        public void GetHttpKeyValueString(){} // RVA: 0x7ffaae3d2330
    }

    public class PhotonClientWebSocket : PhotonSocket
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3d6820
        public void Connect(){} // RVA: 0x7ffaae3d68a0
        public void AsyncConnectAndReceive(){} // RVA: 0x7ffaae3d69d0
        public void Disconnect(){} // RVA: 0x7ffaae3d7bc0
        public void Send(){} // RVA: 0x7ffaae3d7e10
        public void Receive(){} // RVA: 0x7ffaae3d8170
    }

    public class PhotonHashtable : Dictionary`2
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaae3c12f0
        public void .ctor(){} // RVA: 0x7ffaae3c1590
        public void .ctor(){} // RVA: 0x7ffaae3c1590
        public void get_Item(){} // RVA: 0x7ffaae3c1870
        public void set_Item(){} // RVA: 0x7ffaae3c17a0
        public void get_Item(){} // RVA: 0x7ffaae3c1870
        public void set_Item(){} // RVA: 0x7ffaae3c17a0
        public void get_Item(){} // RVA: 0x7ffaae3c1870
        public void Add(){} // RVA: 0x7ffaae3c1900
        public void ContainsKey(){} // RVA: 0x7ffaae3c19d0
        public void ToString(){} // RVA: 0x7ffaae3c1bd0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaae3c1a90
    }

    public class PhotonPeer : Object
    {
        public object NativeEncryptorApiVersion; // 0x31A29530
        public object clientVersion; // 0x31A29530
        public object UseInitV3; // 0x31A29530
        public object _serializationProtocolType; // 0x31A29530, was: <SerializationProtocolType>k__
        public object LogLevel; // 0x31A29530
        public object useByteArraySlicePoolForEvents; // 0x31A29530
        public object SendWindowSize; // 0x31A29530
        public object InitialResendTimeMax; // 0x31A29530
        public object PingInterval; // 0x31A29530
        public object OutgoingStreamBufferSize; // 0x31A29530
        public object RandomizeSequenceNumbers; // 0x31A29530
        public object PayloadEncryptionSecret; // 0x31A29530
        public object TrafficRecorder; // 0x31A29530
        public object _countDiscarded; // 0x31A29530, was: <CountDiscarded>k__BackingFiel
        public object TrafficStatsEnabled; // 0x31A29530
        public object dispatchLockObject; // 0x31A29530

        // ── Original Methods ──
        public void get_ClientSdkIdShifted(){} // RVA: 0x7ffaae3d81b0
        public void get_Version(){} // RVA: 0x7ffaae3d81c0
        public void get_UseAck2(){} // RVA: 0x7ffaae3d85a0
        public void set_UseAck2(){} // RVA: 0x7ffaae3d85b0
        public void get_SerializationProtocolType(){} // RVA: 0x7ffaa9e5ac10
        public void set_SerializationProtocolType(){} // RVA: 0x7ffaa9e6a2e0
        public void get_SocketImplementation(){} // RVA: 0x7ffaa8960130
        public void set_SocketImplementation(){} // RVA: 0x7ffaa8933e90
        public void get_SocketErrorCode(){} // RVA: 0x7ffaae3d85c0
        public void get_Listener(){} // RVA: 0x7ffaa8bf45b0
        public void set_Listener(){} // RVA: 0x7ffaa8bf45c0
        public void get_PeerState(){} // RVA: 0x7ffaae3d85f0
        public void get_ReuseEventInstance(){} // RVA: 0x7ffaa89edc00
        public void set_ReuseEventInstance(){} // RVA: 0x7ffaae3d8660
        public void get_UseByteArraySlicePoolForEvents(){} // RVA: 0x7ffaa8bfb9f0
        public void get_WrapIncomingStructs(){} // RVA: 0x7ffaa8bfb090
        public void get_QuickResendAttempts(){} // RVA: 0x7ffaa89e9d30
        public void set_QuickResendAttempts(){} // RVA: 0x7ffaae3d8810
        public void get_DisconnectTimeout(){} // RVA: 0x7ffaa92bf840
        public void set_DisconnectTimeout(){} // RVA: 0x7ffaae3d8830
        public void get_CrcEnabled(){} // RVA: 0x7ffaa8b6c110
        public void set_CrcEnabled(){} // RVA: 0x7ffaae3d8840
        public void get_ServerAddress(){} // RVA: 0x7ffaae3d88d0
        public void get_UsedProtocol(){} // RVA: 0x7ffaae3d88f0
        public void get_TransportProtocol(){} // RVA: 0x7ffaa96315d0
        public void set_TransportProtocol(){} // RVA: 0x7ffaa962f610
        public void set_IsSimulationEnabled(){} // RVA: 0x7ffaae3d8910
        public void get_NetworkSimulationSettings(){} // RVA: 0x7ffaae3d8ab0
        public void get_MaximumTransferUnit(){} // RVA: 0x7ffaa8b64610
        public void get_IsEncryptionAvailable(){} // RVA: 0x7ffaae3d8ae0
        public void get_PayloadEncryptorType(){} // RVA: 0x7ffaa8af68f0
        public void get_EncryptorType(){} // RVA: 0x7ffaa8971010
        public void set_EncryptorType(){} // RVA: 0x7ffaae3d8b10
        public void get_ServerTimeInMilliseconds(){} // RVA: 0x7ffaae3d8cd0
        public void get_EnableServerTracing(){} // RVA: 0x7ffaa9feeae0
        public void get_ConnectionTime(){} // RVA: 0x7ffaae3d8d20
        public void get_BytesIn(){} // RVA: 0x7ffaae3d8d50
        public void get_BytesOut(){} // RVA: 0x7ffaae3d8d70
        public void get_ByteCountCurrentDispatch(){} // RVA: 0x7ffaae3d8d90
        public void get_ByteCountLastOperation(){} // RVA: 0x7ffaae3d8db0
        public void get_PacketLossByCrc(){} // RVA: 0x7ffaae3d8dd0
        public void get_PacketLossByChallenge(){} // RVA: 0x7ffaae3d8df0
        public void get_CountDiscarded(){} // RVA: 0x7ffaabf46920
        public void set_CountDiscarded(){} // RVA: 0x7ffaabf46930
        public void set_DeltaUnreliableNumber(){} // RVA: 0x7ffaa932b8c0
        public void get_QueuedOutgoingCommands(){} // RVA: 0x7ffaae3d8e10
        public void get_Stats(){} // RVA: 0x7ffaa899d040
        public void set_Stats(){} // RVA: 0x7ffaa899d050
        public void .ctor(){} // RVA: 0x7ffaae3d94d0
        public void .ctor(){} // RVA: 0x7ffaae3d94d0
        public void Connect(){} // RVA: 0x7ffaae3d9550
        public void CreatePeerBase(){} // RVA: 0x7ffaae3da250
        public void Disconnect(){} // RVA: 0x7ffaae3da470
        public void FetchServerTimestamp(){} // RVA: 0x7ffaae3da730
        public void EstablishEncryption(){} // RVA: 0x7ffaae3da760
        public void InitDatagramEncryption(){} // RVA: 0x7ffaae3da840
        public void InitPayloadEncryption(){} // RVA: 0x7ffaa8efece0
        public void Service(){} // RVA: 0x7ffaae3dac90
        public void SendOutgoingCommands(){} // RVA: 0x7ffaae3dace0
        public void SendAcksOnly(){} // RVA: 0x7ffaae3daec0
        public void DispatchIncomingCommands(){} // RVA: 0x7ffaae3db030
        public void SendOperation(){} // RVA: 0x7ffaae3db220
        public void RegisterType(){} // RVA: 0x7ffaae3db6b0
        public void .cctor(){} // RVA: 0x7ffaae3db740
        public void <EstablishEncryption>b__203_0(){} // RVA: 0x7ffaae3db7a0
    }

    public class PhotonSocket : Object
    {
        public object PollReceive; // 0x33FC6EB0
        public object ConnectAddress; // 0x33FC6EB0
        public object _serverIpAddress; // 0x33FC6EB0, was: <ServerIpAddress>k__BackingFie
        public object _urlProtocol; // 0x33FC6EB0, was: <UrlProtocol>k__BackingField

        // ── Original Methods ──
        public void get_Listener(){} // RVA: 0x7ffaae3db7d0
        public void get_MTU(){} // RVA: 0x7ffaae3db800
        public void get_State(){} // RVA: 0x7ffaa9e5ac10
        public void set_State(){} // RVA: 0x7ffaa9e6a2e0
        public void get_SocketErrorCode(){} // RVA: 0x7ffaa8aeced0
        public void set_SocketErrorCode(){} // RVA: 0x7ffaa900aa90
        public void get_Connected(){} // RVA: 0x7ffaae3db830
        public void get_ServerAddress(){} // RVA: 0x7ffaa8bfcc80
        public void set_ServerAddress(){} // RVA: 0x7ffaa8960890
        public void get_ProxyServerAddress(){} // RVA: 0x7ffaa8bf45b0
        public void set_ProxyServerAddress(){} // RVA: 0x7ffaa8bf45c0
        public void set_ServerIpAddress(){} // RVA: 0x7ffaa895a200
        public void get_ServerPort(){} // RVA: 0x7ffaa89d30c0
        public void set_ServerPort(){} // RVA: 0x7ffaa89d30d0
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x7ffaa9b8bd80
        public void set_AddressResolvedAsIpv6(){} // RVA: 0x7ffaa9b91500
        public void set_UrlProtocol(){} // RVA: 0x7ffaa8a8a4d0
        public void set_UrlPath(){} // RVA: 0x7ffaa89fa510
        public void get_SerializationProtocol(){} // RVA: 0x7ffaae3db840
        public void .ctor(){} // RVA: 0x7ffaae3dba00
        public void Connect(){} // RVA: 0x7ffaae3dbb30
        public void Disconnect(){} // RVA: 0x7ffaa864a040
        public void Send(){}
        public void Receive(){} // RVA: 0x7ffaa864e9f0
        public void HandleReceivedDatagram(){} // RVA: 0x7ffaae3dbee0
        public void ReportDebugOfLevel(){} // RVA: 0x7ffaae3dbf10
        public void EnqueueDebugReturn(){} // RVA: 0x7ffaae3dbf40
        public void HandleException(){} // RVA: 0x7ffaae3dbf60
        public void TryParseAddress(){} // RVA: 0x7ffaae3dc010
        public void IpAddressTryParse(){} // RVA: 0x7ffaae3dc500
        public void AddressSortComparer(){} // RVA: 0x7ffaae3dcf80
        public void <HandleException>b__56_0(){} // RVA: 0x7ffaae3dcfe0
        // ── Binary Analysis Named ──
        public void GetIpAddresses(){} // RVA: 0x7ffaae3dc7c0
    }

    public class Pool`1 : Object
    {
        public object resetFunction; // 0x312D0D20
        public object `Ǐf; // 0xAC1243B0

        // ── Original Methods ──
        public void .ctor(){}
        public void CreatePoolItems(){} // RVA: 0x7ffaa8661210
        public void Release(){} // RVA: 0x7ffaa887e5c0
        public void Acquire(){} // RVA: 0x7ffaa887e5c0
    }

    public class Pool`1 : Object
    {
        public object resetFunction; // 0x35FDB3F8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac1241f0
        public void CreatePoolItems(){} // RVA: 0x7ffaac1243b0
        public void Release(){} // RVA: 0x7ffaac124430
        public void Acquire(){} // RVA: 0x7ffaac124600
    }

    public class Pool`1 : Object
    {
        public object resetFunction; // 0x360498E8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac1241f0
        public void CreatePoolItems(){} // RVA: 0x7ffaac1243b0
        public void Release(){} // RVA: 0x7ffaac124430
        public void Acquire(){} // RVA: 0x7ffaac124600
    }

    public class Pool`1 : Object
    {
        public object resetFunction; // 0x3604F780

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac1241f0
        public void CreatePoolItems(){} // RVA: 0x7ffaac1243b0
        public void Release(){} // RVA: 0x7ffaac124430
        public void Acquire(){} // RVA: 0x7ffaac124600
    }

    public class Protocol : Object
    {
        public object CodeDict; // 0x360648B0
        public object ProtocolType; // 0x17000065

        // ── Original Methods ──
        public void get_ProtocolType(){} // RVA: 0x7ffaa86491d0
        public void get_VersionBytes(){} // RVA: 0x7ffaa86491d0
        public void Serialize(){} // RVA: 0x7ffaae3dd510
        public void SerializeShort(){}
        public void SerializeString(){}
        public void SerializeEventData(){}
        public void SerializeOperationRequest(){}
        public void SerializeOperationResponse(){}
        public void Deserialize(){} // RVA: 0x7ffaae3dd5b0
        public void DeserializeShort(){} // RVA: 0x7ffaa864f910
        public void DeserializeByte(){} // RVA: 0x7ffaa864a2a0
        public void DeserializeEventData(){}
        public void DeserializeOperationRequest(){} // RVA: 0x7ffaa865a110
        public void DeserializeOperationResponse(){} // RVA: 0x7ffaa865a110
        public void DeserializeDisconnectMessage(){} // RVA: 0x7ffaa8649280
        public void Serialize(){} // RVA: 0x7ffaae3dd510
        public void Deserialize(){} // RVA: 0x7ffaae3dd5b0
        public void DeserializeMessage(){} // RVA: 0x7ffaae3dd6a0
        public void TryRegisterType(){} // RVA: 0x7ffaae3dd700
        public void .ctor(){} // RVA: 0x7ffaae3dda70
        public void .cctor(){} // RVA: 0x7ffaae3ddb10
    }

    public class SendOptions : ValueType
    {
        public object DeliveryMode; // 0x341773A0
        public object _reliability; // 0x33857860, was: ÍÌÍÏÌÎÌÏÏÌÍÏÍÍÏÌÍÏÍÏÏÎÏ

        // ── Original Methods ──
        public void get_Reliability(){} // RVA: 0x7ffaae3f49b0
        public void set_Reliability(){} // RVA: 0x7ffaae3f49c0
        public void .cctor(){} // RVA: 0x7ffaae3f49d0
    }

    public class SerializeStreamMethod : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6c57c0
        public void Invoke(){} // RVA: 0x7ffaa8a8e370
    }

    public class SimulationItem : Object
    {
        public object DelayedData; // 0x36064030

        // ── Original Methods ──
        public void get_Delay(){} // RVA: 0x7ffaa8d14570
    }

    public class SocketTcp : PhotonSocket
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3f4a40
        public void Finalize(){} // RVA: 0x7ffaae3f4b60
        public void Dispose(){} // RVA: 0x7ffaae3f4ba0
        public void Connect(){} // RVA: 0x7ffaae3f4cb0
        public void Disconnect(){} // RVA: 0x7ffaae3f4f50
        public void Send(){} // RVA: 0x7ffaae3f51b0
        public void Receive(){} // RVA: 0x7ffaa9fca700
        public void DnsAndConnect(){} // RVA: 0x7ffaae3f54a0
        public void ReceiveLoop(){} // RVA: 0x7ffaae3f5bd0
    }

    public class SocketUdp : PhotonSocket
    {
        public object sendLockObject; // 0x35FB22E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3f85d0
        public void Finalize(){} // RVA: 0x7ffaae3f8760
        public void Dispose(){} // RVA: 0x7ffaae3f87a0
        public void Connect(){} // RVA: 0x7ffaae3f88c0
        public void Disconnect(){} // RVA: 0x7ffaae3f8b60
        public void Send(){} // RVA: 0x7ffaae3f8df0
        public void Receive(){} // RVA: 0x7ffaa9fca700
        public void DnsAndConnect(){} // RVA: 0x7ffaae3f9960
        public void ReceiveLoop(){} // RVA: 0x7ffaae3f9fd0
    }

    public class StreamBuffer : Object
    {
        public object len; // 0x35FB3CB0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3fc490
        public void .ctor(){} // RVA: 0x7ffaae3fc490
        public void ToArray(){} // RVA: 0x7ffaae3fc500
        public void Compact(){} // RVA: 0x7ffaae3fc570
        public void get_Length(){} // RVA: 0x7ffaa8e046c0
        public void get_Position(){} // RVA: 0x7ffaa897f5c0
        public void set_Position(){} // RVA: 0x7ffaae3fc630
        public void get_Available(){} // RVA: 0x7ffaae3fc650
        public void Reset(){} // RVA: 0x7ffaae3fc660
        public void Seek(){} // RVA: 0x7ffaae3fc670
        public void Read(){} // RVA: 0x7ffaae3fc7d0
        public void Write(){} // RVA: 0x7ffaae3fc830
        public void ReadByte(){} // RVA: 0x7ffaae3fc8b0
        public void WriteByte(){} // RVA: 0x7ffaae3fc9a0
        public void WriteBytes(){} // RVA: 0x7ffaae3fca00
        // ── Binary Analysis Named ──
        public void GetBuffer(){} // RVA: 0x7ffaa89357c0
        public void GetBufferAndAdvance(){} // RVA: 0x7ffaae3fc5f0
        public void SetLength(){} // RVA: 0x7ffaae3fc790
        public void SetCapacityMinimum(){} // RVA: 0x7ffaae3fc7c0
        public void CheckSize(){} // RVA: 0x7ffaae3fca90
    }

    public class TPeer : PeerBase
    {
        public object lastPingActivity; // 0x35FB3500
        public object tcpFramedMessageHead; // 0x35FB3500

        // ── Original Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7ffaae3fe900
        public void .ctor(){} // RVA: 0x7ffaae3fe950
        public void IsTransportEncrypted(){} // RVA: 0x7ffaae3feb80
        public void Reset(){} // RVA: 0x7ffaae3feb90
        public void Connect(){} // RVA: 0x7ffaae3fed20
        public void Disconnect(){} // RVA: 0x7ffaae3ff180
        public void Disconnect(){} // RVA: 0x7ffaae3ff180
        public void FetchServerTimestamp(){} // RVA: 0x7ffaae3ff430
        public void EnqueueInit(){} // RVA: 0x7ffaae3ff570
        public void DispatchIncomingCommands(){} // RVA: 0x7ffaae3ff710
        public void SendOutgoingCommands(){} // RVA: 0x7ffaae3ffc50
        public void SendAcksOnly(){} // RVA: 0x7ffaae400120
        public void EnqueuePhotonMessage(){} // RVA: 0x7ffaae400190
        public void EnqueueMessageAsPayload(){} // RVA: 0x7ffaae4001c0
        public void SendPing(){} // RVA: 0x7ffaae400570
        public void SendData(){} // RVA: 0x7ffaae400a10
        public void ReceiveIncomingCommands(){} // RVA: 0x7ffaae400ba0
        public void ReadPingResult(){} // RVA: 0x7ffaae401240
        public void ReadPingResult(){} // RVA: 0x7ffaae401240
        public void .cctor(){} // RVA: 0x7ffaae401390
    }

    public class TrafficStats : TrafficStatsBase
    {
        public object LastSendAckTimestamp; // 0x35FB1F20
        public object _longestDeltaBetweenDispatchCalls; // 0x35FB1F20, was: <LongestDeltaBetweenDispatchCa

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89d0380
        public void get_LastReceiveTimestamp(){} // RVA: 0x7ffaa95c5a20
        public void set_LastReceiveTimestamp(){} // RVA: 0x7ffaa8ac7670
        public void get_LastDispatchTimestamp(){} // RVA: 0x7ffaa9e03940
        public void set_LastDispatchTimestamp(){} // RVA: 0x7ffaaa2bddd0
        public void get_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x7ffaa9fb1a70
        public void set_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x7ffaa9fb1a60
        public void set_LastDispatchDuration(){} // RVA: 0x7ffaae401520
        public void get_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0x7ffaa8fa2c90
        public void set_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0x7ffaa8fa3510
        public void DispatchIncomingCommandsCalled(){} // RVA: 0x7ffaae401530
        public void SendOutgoingCommandsCalled(){} // RVA: 0x7ffaae401550
        public void ToString(){} // RVA: 0x7ffaae401580
        public void ToString(){} // RVA: 0x7ffaae401580
    }

    public class TrafficStatsBase : Object
    {
        public object _packagesIn; // 0x35FB20F0, was: <PackagesIn>k__BackingField
        public object _udpFragmentsOut; // 0x35FB20F0, was: <UdpFragmentsOut>k__BackingFie
        public object _udpReliableCommandsResent; // 0x35FB20F0, was: <UdpReliableCommandsResent>k__
        public object _sendOutgoingCommandsCalls; // 0x35FB20F0, was: <SendOutgoingCommandsCalls>k__
        public object _lastRoundtripTime; // 0x35FB20F0, was: <LastRoundtripTime>k__BackingF
        public object BytesIn; // 0x17000078
        public object BytesOut; // 0x17000079
        public object PackagesIn; // 0x1700007A
        public object PackagesOut; // 0x1700007B
        public object UdpFragmentsIn; // 0x1700007C

        // ── Original Methods ──
        public void get_BytesIn(){} // RVA: 0x7ffaa894d380
        public void set_BytesIn(){} // RVA: 0x7ffaa9e463c0
        public void get_BytesOut(){} // RVA: 0x7ffaa89357c0
        public void set_BytesOut(){} // RVA: 0x7ffaa92bb750
        public void get_PackagesIn(){} // RVA: 0x7ffaa8aeced0
        public void set_PackagesIn(){} // RVA: 0x7ffaa900aa90
        public void get_PackagesOut(){} // RVA: 0x7ffaa9349010
        public void set_PackagesOut(){} // RVA: 0x7ffaa9b8c1b0
        public void get_UdpFragmentsIn(){} // RVA: 0x7ffaa8d14570
        public void set_UdpFragmentsIn(){} // RVA: 0x7ffaa90c0cd0
        public void get_UdpFragmentsOut(){} // RVA: 0x7ffaa96cc980
        public void set_UdpFragmentsOut(){} // RVA: 0x7ffaa9fdb500
        public void get_UdpUnreliableCommandsSent(){} // RVA: 0x7ffaa898dcd0
        public void set_UdpUnreliableCommandsSent(){} // RVA: 0x7ffaa898dce0
        public void get_UdpReliableCommandsSent(){} // RVA: 0x7ffaa950c6d0
        public void set_UdpReliableCommandsSent(){} // RVA: 0x7ffaa9b8cba0
        public void get_UdpReliableCommandsResent(){} // RVA: 0x7ffaa8fb82b0
        public void set_UdpReliableCommandsResent(){} // RVA: 0x7ffaa8fb82c0
        public void set_UdpReliableCommandsInFlight(){} // RVA: 0x7ffaaa1eabc0
        public void get_DispatchIncomingCommandsCalls(){} // RVA: 0x7ffaa89d3080
        public void set_DispatchIncomingCommandsCalls(){} // RVA: 0x7ffaa89d3090
        public void get_SendOutgoingCommandsCalls(){} // RVA: 0x7ffaa89d30a0
        public void set_SendOutgoingCommandsCalls(){} // RVA: 0x7ffaa89d30b0
        public void get_RoundtripTime(){} // RVA: 0x7ffaa89ad730
        public void set_RoundtripTime(){} // RVA: 0x7ffaa9c6df90
        public void get_RoundtripTimeVariance(){} // RVA: 0x7ffaa89d30e0
        public void set_RoundtripTimeVariance(){} // RVA: 0x7ffaa9c6aac0
        public void set_LastRoundtripTime(){} // RVA: 0x7ffaa9c73580
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}