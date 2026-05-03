// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client
// Classes: 45
// Methods: 659

namespace ThirdParty.Photon.Photon.Client
{
    public class ByteArraySlice : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D488C0
        public void Dispose(){} // RVA: 0x7FFE86D489F0
        public void Release(){} // RVA: 0x7FFE86D48A30
    }

    public class ByteArraySlicePool : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D48A70
        public void Acquire(){} // RVA: 0x7FFE86D48CC0
        public void PopOrCreate(){} // RVA: 0x7FFE86D49110
        public void Release(){} // RVA: 0x7FFE86D49430
    }

    public class CustomType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D65870
    }

    public class DeserializeStreamMethod : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D656F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class DictionaryEntryEnumerator : ValueType
    {
        public Enumerator<object,object> enumerator; // 0x10
        public object field_1; // 0xE

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE835C2650
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE86D4A640
        public void get_Current(){} // RVA: 0x7FFE86D4A790
        public void MoveNext(){} // RVA: 0x7FFE86D4A820
        public void Reset(){} // RVA: 0x7FFE86D4A860
        public void Dispose(){} // RVA: 0x7FFE810FB310
    }

    public class DisconnectMessage : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EnetChannel : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D4A930
        public void AddSequencedIfNew(){} // RVA: 0x7FFE86D4AE00
        public void TryGetFragment(){} // RVA: 0x7FFE86D4AED0
        public void RemoveFragment(){} // RVA: 0x7FFE86D4AF50
        public void clearAll(){} // RVA: 0x7FFE86D4AFC0
        public void QueueIncomingReliableUnsequenced(){} // RVA: 0x7FFE86D4B300
        public void ApplySequenceNumberModifier(){} // RVA: 0x7FFE86D4B640
        public void Received(){} // RVA: 0x7FFE86D4B690
        public void GetGapBlock(){} // RVA: 0x7FFE86D4B940
    }

    public class EnetPeer : PeerBase
    {
        public Photon.Client.Pool`1<Photon.Client.NCommand> nCommandPool; // 0x128
        public System.Collections.Generic.List`1<Photon.Client.NCommand> sentReliableCommands; // 0x130
        public int sendWindowUpdateRequiredBackValue; // 0x138
        public Photon.Client.StreamBuffer outgoingAcknowledgementsPool; // 0x140

        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7FFE86D4BD70
        public void get_SendWindowUpdateRequired(){} // RVA: 0x7FFE86D4C090
        public void set_SendWindowUpdateRequired(){} // RVA: 0x7FFE86D4C0B0
        public void get_DatagramEncryptedConnection(){} // RVA: 0x7FFE86D4C0D0
        public void set_DatagramEncryptedConnection(){} // RVA: 0x7FFE86D4C0F0
        public void get_useAck2(){} // RVA: 0x7FFE86D4C110
        public void .ctor(){} // RVA: 0x7FFE86D4C140
        public void IsTransportEncrypted(){} // RVA: 0x7FFE86D4C0D0
        public void Reset(){} // RVA: 0x7FFE86D4CAD0
        public void ApplyRandomizedSequenceNumbers(){} // RVA: 0x7FFE86D4D340
        public void GetChannel(){} // RVA: 0x7FFE86D4D560
        public void Connect(){} // RVA: 0x7FFE86D4D5C0
        public void Disconnect(){} // RVA: 0x7FFE86D4D690
        public void FetchServerTimestamp(){} // RVA: 0x7FFE86D4DBD0
        public void DispatchCommandQueue(){} // RVA: 0x7FFE86D4DCF0
        public void DispatchIncomingCommands(){} // RVA: 0x7FFE86D4DDD0
        public void GetFragmentLength(){} // RVA: 0x7FFE86D4E960
        public void CalculatePacketSize(){} // RVA: 0x7FFE86D4EA40
        public void CalculateInitialOffset(){} // RVA: 0x7FFE86D4EAD0
        public void SendAcksOnly(){} // RVA: 0x7FFE86D4EB20
        public void SendOutgoingCommands(){} // RVA: 0x7FFE86D4EB40 | overloaded x2
        public void UpdateSendWindow(){} // RVA: 0x7FFE86D4FC40
        public void EnqueuePhotonMessage(){} // RVA: 0x7FFE86D50680
        public void CreateAndEnqueueCommand(){} // RVA: 0x7FFE86D506D0
        public void SerializeAckToBuffer(){} // RVA: 0x7FFE86D50CC0
        public void SerializeToBuffer(){} // RVA: 0x7FFE86D511C0
        public void SerializeCommandToBuffer(){} // RVA: 0x7FFE86D51310
        public void SendData(){} // RVA: 0x7FFE86D514F0
        public void SendToSocket(){} // RVA: 0x7FFE86D51860
        public void SendDataEncrypted(){} // RVA: 0x7FFE86D519D0
        public void QueueSentCommand(){} // RVA: 0x7FFE86D51CE0
        public void QueueOutgoingReliableCommand(){} // RVA: 0x7FFE86D52080
        public void QueueOutgoingUnreliableCommand(){} // RVA: 0x7FFE86D522B0
        public void QueueOutgoingAcknowledgement(){} // RVA: 0x7FFE86D52550
        public void ReceiveIncomingCommands(){} // RVA: 0x7FFE86D52A50
        public void ExecuteCommand(){} // RVA: 0x7FFE86D53600
        public void QueueIncomingCommand(){} // RVA: 0x7FFE86D54E00
        public void RemoveSentReliableCommand(){} // RVA: 0x7FFE86D556F0
        public void .cctor(){} // RVA: 0x7FFE86D55B90
        public void <ExecuteCommand>b__78_0(){} // RVA: 0x7FFE86D55C70
    }

    public class EventData : Object
    {
        public byte Code; // 0x10
        public Photon.Client.ParameterDictionary Parameters; // 0x18
        public byte SenderKey; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D7C180
        public void get_Item(){} // RVA: 0x7FFE86D7C230
        public void get_Sender(){} // RVA: 0x7FFE86D7C2A0
        public void set_Sender(){} // RVA: 0x7FFE82447980
        public void get_CustomData(){} // RVA: 0x7FFE86D7C320
        public void Reset(){} // RVA: 0x7FFE86D7C3B0
        public void ToString(){} // RVA: 0x7FFE86D7C430
    }

    public class IPhotonPeerListener
    {
        // ── Methods ──
        public void DebugReturn(){} // RVA: 0x7FFE80E46BE0
        public void OnOperationResponse(){} // RVA: 0x7FFE80E460A0
        public void OnStatusChanged(){} // RVA: 0x7FFE80E46530
        public void OnEvent(){} // RVA: 0x7FFE80E460A0
        public void OnMessage(){} // RVA: 0x7FFE80E46BE0
        public void OnDisconnectMessage(){} // RVA: 0x7FFE80E460A0
    }

    public class ITrafficRecorder
    {
        // ── Methods ──
        public void Record(){}
    }

    public class InvalidDataException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D6FA80
    }

    public class MessageProtocol : Object
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFE86D7C6B0 | overloaded x3
        public void Deserialize(){} // RVA: 0x7FFE86D7C9A0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE86D7CCD0
    }

    public class NCommand : Object
    {
        public byte Ack2FeatureFlag;
        public byte ReliableSendWindowFeatureFlag;
        public byte FeatureFlagsLow;

        // ── Methods ──
        public void get_SizeOfPayload(){} // RVA: 0x7FFE86D55DD0
        public void get_IsFlaggedUnsequenced(){} // RVA: 0x7FFE86D55DF0
        public void get_IsFlaggedReliable(){} // RVA: 0x7FFE86D55E00
        public void CreateAck(){} // RVA: 0x7FFE86D55E20
        public void CreateAck2(){} // RVA: 0x7FFE86D56050
        public void Initialize(){} // RVA: 0x7FFE86D56620 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE86D56C40
        public void SerializeHeader(){} // RVA: 0x7FFE86D56C80
        public void Serialize(){} // RVA: 0x7FFE86D57110
        public void FreePayload(){} // RVA: 0x7FFE86D57130
        public void CompareTo(){} // RVA: 0x7FFE86D57210
        public void ToString(){} // RVA: 0x7FFE86D57250 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE86D57AB0
    }

    public class NetworkSimulationSet : Object
    {
        public bool isSimulationEnabled; // 0x10
        public int outgoingLag; // 0x14
        public int outgoingJitter; // 0x18
        public int outgoingLossPercentage; // 0x1C
        public int incomingLag; // 0x20

        // ── Methods ──
        public void get_IsSimulationEnabled(){} // RVA: 0x7FFE811C55E0
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFE86D57AC0
        public void set_OutgoingLossPercentage(){} // RVA: 0x7FFE82717690
        public void set_IncomingLossPercentage(){} // RVA: 0x7FFE817E4800
        public void set_LostPackagesOut(){} // RVA: 0x7FFE8119C0D0
        public void set_LostPackagesIn(){} // RVA: 0x7FFE82B06A20
        public void ToString(){} // RVA: 0x7FFE86D586F0
        public void .ctor(){} // RVA: 0x7FFE86D58A40
    }

    public class NonAllocDictionary`2 : Object
    {
        public uint[] _primeTableUInt;
        public int _freeHead;
        public int _freeCount;
        public int _usedCount;
        public uint _capacity;
        public int[] _buckets;

        // ── Methods ──
        public void get_Keys(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<K,V>.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IDictionary<K,V>.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void ContainsKey(){} // RVA: 0x7FFE810A1420
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Remove(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void FindNode(){} // RVA: 0x7FFE810A1420
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void Expand(){} // RVA: 0x7FFE80E45FE0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<K,V>>.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void IsPrimeFromList(){} // RVA: 0x7FFE80E2FBF0
        public void GetNextPrime(){} // RVA: 0x7FFE80E35560
        public void Assert(){} // RVA: 0x7FFE80E464B0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class OperationRequest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OperationResponse : Object
    {
        public byte OperationCode; // 0x10

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE86D7BD50
        public void ToString(){} // RVA: 0x7FFE86D7BDC0
        public void ToStringFull(){} // RVA: 0x7FFE86D7BF40
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ParameterDictionary : Object
    {
        public Photon.Client.NonAllocDictionary`2<byte,object> paramDict; // 0x10
        public Photon.Client.StructWrapping.StructWrapperPools wrapperPools; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D58C60 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE85B3A480
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Byte,System.Object>>.GetEnumerator(){} // RVA: 0x7FFE86D58DC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86D58E10
        public void GetEnumerator(){} // RVA: 0x7FFE86D58E60
        public void get_Item(){} // RVA: 0x7FFE86D58F10
        public void set_Item(){} // RVA: 0x7FFE86D58FC0
        public void get_Count(){} // RVA: 0x7FFE86D59030
        public void Clear(){} // RVA: 0x7FFE86D59080
        public void Add(){} // RVA: 0x7FFE86D595F0 | overloaded x5
        public void Get(){} // RVA: 0x7FFE810A1420
        public void ContainsKey(){} // RVA: 0x7FFE86D596F0
        public void TryGetValue(){} // RVA: 0x7FFE86D59750 | overloaded x2
    }

    public class PeerBase : Object
    {
        public Photon.Client.PhotonPeer photonPeer; // 0x10
        public Photon.Client.Protocol SerializationProtocol; // 0x18
        public 0x6666444C usedTransportProtocol; // 0x20
        public Photon.Client.PhotonSocket PhotonSocket; // 0x28
        public string _serverAddress; // 0x30
        public string _proxyServerAddress; // 0x38
        public int peerConnectionStateField; // 0x40
        public int ByteCountLastOperation; // 0x44
        public int ByteCountCurrentDispatch; // 0x48
        public Photon.Client.NCommand CommandInCurrentDispatch; // 0x50
        public int packetLossByCrc; // 0x58
        public int packetLossByChallenge; // 0x5C
        public int throttledBySendWindow; // 0x60
        public System.Collections.Generic.Queue`1<MyAction> ActionQueue; // 0x68
        public short peerID; // 0x70
        public short peerCount;
        public int serverTimeOffset; // 0x74
        public bool serverTimeOffsetIsAvailable; // 0x78
        public float roundTripTime; // 0x7C
        public float roundTripTimeVariance; // 0x80
        public int lastRoundTripTime; // 0x84

        // ── Methods ──
        public void get_Stats(){} // RVA: 0x7FFE81727D90
        public void get_Listener(){} // RVA: 0x7FFE8189C060
        public void get_LogLevel(){} // RVA: 0x7FFE82863E90
        public void get_ServerAddress(){} // RVA: 0x7FFE8144E200
        public void set_ServerAddress(){} // RVA: 0x7FFE81129890
        public void get_ProxyServerAddress(){} // RVA: 0x7FFE8143BA80
        public void set_ProxyServerAddress(){} // RVA: 0x7FFE81437330
        public void get_peerConnectionState(){} // RVA: 0x7FFE86D59850
        public void set_peerConnectionState(){} // RVA: 0x7FFE86D59860
        public void TryUpdateConnectionState(){} // RVA: 0x7FFE86D59870
        public void get_rttVarString(){} // RVA: 0x7FFE86D59890
        public void get_TimeoutVarianceCompensation(){} // RVA: 0x7FFE86D59970
        public void get_DisconnectTimeout(){} // RVA: 0x7FFE86D599D0
        public void get_PingInterval(){} // RVA: 0x7FFE86893420
        public void get_ChannelCount(){} // RVA: 0x7FFE86D599F0
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7FFE80E2EDB0
        public void get_timeInt(){} // RVA: 0x7FFE86D59A10
        public void set_ServerFeatureFlags(){} // RVA: 0x7FFE86D59A40
        public void get_serverFeatureFlagsAvailable(){} // RVA: 0x7FFE86D59A80
        public void set_serverFeatureFlagsAvailable(){} // RVA: 0x7FFE86D59A90
        public void get_serverFeatureAck2Available(){} // RVA: 0x7FFE86D59AA0
        public void set_serverFeatureAck2Available(){} // RVA: 0x7FFE86D59AB0
        public void get_serverFeatureSyncReliableQueue(){} // RVA: 0x7FFE86D59AC0
        public void set_serverFeatureSyncReliableQueue(){} // RVA: 0x7FFE86D59AD0
        public void get_ServerMaxQueueableReliableCommands(){} // RVA: 0x7FFE86D59AE0
        public void set_ServerMaxQueueableReliableCommands(){} // RVA: 0x7FFE86D59AF0
        public void get_mtu(){} // RVA: 0x7FFE86D59B00
        public void get_IsIpv6(){} // RVA: 0x7FFE86D59B20
        public void .ctor(){} // RVA: 0x7FFE86D59B40
        public void Reset(){} // RVA: 0x7FFE86D5A0A0
        public void Connect(){} // RVA: 0x7FFE80E32AD0
        public void GetHttpKeyValueString(){} // RVA: 0x7FFE86D5A7A0
        public void WriteInitRequest(){} // RVA: 0x7FFE86D5AA40
        public void WriteInitV3(){} // RVA: 0x7FFE86D5B140
        public void PrepareWebSocketUrl(){} // RVA: 0x7FFE86D5B760
        public void OnInitResponse(){} // RVA: 0x7FFE86D5BBD0
        public void Disconnect(){} // RVA: 0x7FFE80E466C0
        public void FetchServerTimestamp(){} // RVA: 0x7FFE80E45FE0
        public void IsTransportEncrypted(){} // RVA: 0x7FFE80E2F150
        public void EnqueuePhotonMessage(){}
        public void SerializeOperationToMessage(){} // RVA: 0x7FFE86D5BC70
        public void SendOutgoingCommands(){} // RVA: 0x7FFE80E2F150
        public void SendAcksOnly(){} // RVA: 0x7FFE810FB320
        public void ReceiveIncomingCommands(){} // RVA: 0x7FFE80E4D070
        public void DispatchIncomingCommands(){} // RVA: 0x7FFE80E2F150
        public void DeserializeMessageAndCallback(){} // RVA: 0x7FFE86D5BF20
        public void UpdateRoundTripTimeAndVariance(){} // RVA: 0x7FFE86D5CCB0
        public void ExchangeKeysForEncryption(){} // RVA: 0x7FFE86D5CE20
        public void DeriveSharedKey(){} // RVA: 0x7FFE86D5D4C0
        public void InitEncryption(){} // RVA: 0x7FFE86D5D670
        public void EnqueueActionForDispatch(){} // RVA: 0x7FFE86D5DB10
        public void EnqueueDebugReturn(){} // RVA: 0x7FFE86D5DC90
        public void EnqueueStatusCallback(){} // RVA: 0x7FFE86D5DF60
        public void get_NetworkSimulationSettings(){} // RVA: 0x7FFE813A1DA0
        public void NetworkSimRun(){} // RVA: 0x7FFE86D5E1D0
        public void .cctor(){} // RVA: 0x7FFE86D5E870
        public void <DeserializeMessageAndCallback>b__122_0(){} // RVA: 0x7FFE86D5EA50
    }

    public class PhotonClientWebSocket : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D5EC90
        public void Connect(){} // RVA: 0x7FFE86D5ED10
        public void AsyncConnectAndReceive(){} // RVA: 0x7FFE86D5EE40
        public void Disconnect(){} // RVA: 0x7FFE86D60030
        public void Send(){} // RVA: 0x7FFE86D60280
        public void Receive(){} // RVA: 0x7FFE86D605E0
    }

    public class PhotonCodes : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86D597C0
    }

    public class PhotonHashtable : Dictionary`2
    {
        public object[] boxedByte;
        public object field_1; // 0xB
        public object field_2; // 0xC

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86D49770
        public void .ctor(){} // RVA: 0x7FFE86D49A10 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE86D49CF0 | overloaded x3
        public void set_Item(){} // RVA: 0x7FFE86D49C20 | overloaded x2
        public void Add(){} // RVA: 0x7FFE86D49D80
        public void ContainsKey(){} // RVA: 0x7FFE86D49E50
        public void GetEnumerator(){} // RVA: 0x7FFE86D49F10
        public void ToString(){} // RVA: 0x7FFE86D4A050
    }

    public class PhotonPeer : Object
    {
        public bool NoSocket;
        public bool DebugBuild;
        public int NativeEncryptorApiVersion;
        public 0x666644FC TargetFramework; // 0x10
        public byte ClientSdkId; // 0x14
        public string clientVersion;
        public bool NoNativeCallbacks; // 0x8
        public bool RemoveAppIdFromWebSocketPath; // 0x15
        public bool UseInitV3; // 0x16
        public bool _useAck2; // 0x17
        public bool EnableEncryptedFlag; // 0x18
        public 0x66664CE4 _serializationProtocolType; // 0x1C
        public System.Collections.Generic.Dictionary`2<0x6666444C,System.Type> SocketImplementationConfig; // 0x20
        public System.Type _socketImplementation; // 0x28
        public 0x666644A4 LogLevel; // 0x30
        public Photon.Client.IPhotonPeerListener _listener; // 0x38
        public bool reuseEventInstance; // 0x40
        public bool useByteArraySlicePoolForEvents; // 0x41
        public bool wrapIncomingStructs; // 0x42
        public bool SendInCreationOrder; // 0x43
        public int SendWindowSize; // 0x44
        public byte quickResendAttempts; // 0x48
        public int MaxResends; // 0x4C
        public int InitialResendTimeMax; // 0x50
        public int disconnectTimeout; // 0x54
        public bool crcEnabled; // 0x58
        public int PingInterval; // 0x5C
        public byte ChannelCount; // 0x60
        public 0x6666444C _transportProtocol; // 0x61
        public int OutgoingStreamBufferSize; // 0xC
        public int mtu; // 0x64
        public bool AsyncKeyExchange; // 0x10
        public bool RandomizeSequenceNumbers; // 0x68
        public byte[] RandomizedSequenceNumbers; // 0x70
        public System.Type payloadEncryptorType; // 0x78
        public byte[] PayloadEncryptionSecret; // 0x80

        // ── Methods ──
        public void get_ClientSdkIdShifted(){} // RVA: 0x7FFE86D60620
        public void get_Version(){} // RVA: 0x7FFE86D60630
        public void get_UseAck2(){} // RVA: 0x7FFE86D60A10
        public void set_UseAck2(){} // RVA: 0x7FFE86D60A20
        public void get_SerializationProtocolType(){} // RVA: 0x7FFE82707EE0
        public void set_SerializationProtocolType(){} // RVA: 0x7FFE82717690
        public void get_SocketImplementation(){} // RVA: 0x7FFE81129130
        public void set_SocketImplementation(){} // RVA: 0x7FFE810FCE90
        public void get_SocketErrorCode(){} // RVA: 0x7FFE86D60A30
        public void get_Listener(){} // RVA: 0x7FFE8143BA80
        public void set_Listener(){} // RVA: 0x7FFE81437330
        public void get_PeerState(){} // RVA: 0x7FFE86D60A60
        public void get_ReuseEventInstance(){} // RVA: 0x7FFE811B6C00
        public void set_ReuseEventInstance(){} // RVA: 0x7FFE86D60AD0
        public void get_UseByteArraySlicePoolForEvents(){} // RVA: 0x7FFE814645D0
        public void get_WrapIncomingStructs(){} // RVA: 0x7FFE81463AF0
        public void get_QuickResendAttempts(){} // RVA: 0x7FFE811B2D30
        public void set_QuickResendAttempts(){} // RVA: 0x7FFE86D60C80
        public void get_DisconnectTimeout(){} // RVA: 0x7FFE819EA920
        public void set_DisconnectTimeout(){} // RVA: 0x7FFE86D60CA0
        public void get_CrcEnabled(){} // RVA: 0x7FFE813A1140
        public void set_CrcEnabled(){} // RVA: 0x7FFE86D60CB0
        public void get_ServerAddress(){} // RVA: 0x7FFE86D60D40
        public void get_UsedProtocol(){} // RVA: 0x7FFE86D60D60
        public void get_TransportProtocol(){} // RVA: 0x7FFE81EC3970
        public void set_TransportProtocol(){} // RVA: 0x7FFE81EB6360
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFE86D60D80
        public void get_NetworkSimulationSettings(){} // RVA: 0x7FFE86D60F20
        public void get_MaximumTransferUnit(){} // RVA: 0x7FFE8139DA60
        public void get_IsEncryptionAvailable(){} // RVA: 0x7FFE86D60F50
        public void get_PayloadEncryptorType(){} // RVA: 0x7FFE81463AE0
        public void get_EncryptorType(){} // RVA: 0x7FFE8113A010
        public void set_EncryptorType(){} // RVA: 0x7FFE86D60F80
        public void get_ServerTimeInMilliseconds(){} // RVA: 0x7FFE86D61140
        public void get_EnableServerTracing(){} // RVA: 0x7FFE820E9360
        public void get_ConnectionTime(){} // RVA: 0x7FFE86D61190
        public void get_BytesIn(){} // RVA: 0x7FFE86D611C0
        public void get_BytesOut(){} // RVA: 0x7FFE86D611E0
        public void get_ByteCountCurrentDispatch(){} // RVA: 0x7FFE86D61200
        public void get_ByteCountLastOperation(){} // RVA: 0x7FFE86D61220
        public void get_PacketLossByCrc(){} // RVA: 0x7FFE86D61240
        public void get_PacketLossByChallenge(){} // RVA: 0x7FFE86D61260
        public void get_CountDiscarded(){} // RVA: 0x7FFE848BEED0
        public void set_CountDiscarded(){} // RVA: 0x7FFE848BEEE0
        public void set_DeltaUnreliableNumber(){} // RVA: 0x7FFE81A34770
        public void get_QueuedOutgoingCommands(){} // RVA: 0x7FFE86D61280
        public void get_Stats(){} // RVA: 0x7FFE81166040
        public void set_Stats(){} // RVA: 0x7FFE81166050
        public void .ctor(){} // RVA: 0x7FFE86D61940 | overloaded x2
        public void Connect(){} // RVA: 0x7FFE86D619C0
        public void CreatePeerBase(){} // RVA: 0x7FFE86D626C0
        public void Disconnect(){} // RVA: 0x7FFE86D628E0
        public void FetchServerTimestamp(){} // RVA: 0x7FFE86D62BA0
        public void EstablishEncryption(){} // RVA: 0x7FFE86D62BD0
        public void InitDatagramEncryption(){} // RVA: 0x7FFE86D62CB0
        public void InitPayloadEncryption(){} // RVA: 0x7FFE81282380
        public void Service(){} // RVA: 0x7FFE86D63100
        public void SendOutgoingCommands(){} // RVA: 0x7FFE86D63150
        public void SendAcksOnly(){} // RVA: 0x7FFE86D63330
        public void DispatchIncomingCommands(){} // RVA: 0x7FFE86D634A0
        public void SendOperation(){} // RVA: 0x7FFE86D63690
        public void RegisterType(){} // RVA: 0x7FFE86D63B20
        public void .cctor(){} // RVA: 0x7FFE86D63BB0
        public void <EstablishEncryption>b__203_0(){} // RVA: 0x7FFE86D63C10
    }

    public class PhotonSocket : Object
    {
        public Photon.Client.PeerBase peerBase; // 0x10
        public 0x6666444C Protocol; // 0x18
        public bool PollReceive; // 0x19
        public 0x66664B84 _state; // 0x1C
        public int _socketErrorCode; // 0x20
        public string ConnectAddress; // 0x28
        public string _serverAddress; // 0x30
        public string _proxyServerAddress; // 0x38
        public string _serverIpAddress; // 0x40
        public int _serverPort; // 0x48
        public bool _addressResolvedAsIpv6; // 0x4C
        public string _urlProtocol; // 0x50
        public string _urlPath; // 0x58

        // ── Methods ──
        public void get_Listener(){} // RVA: 0x7FFE86D63C40
        public void get_MTU(){} // RVA: 0x7FFE86D63C70
        public void get_State(){} // RVA: 0x7FFE82707EE0
        public void set_State(){} // RVA: 0x7FFE82717690
        public void get_SocketErrorCode(){} // RVA: 0x7FFE8151D690
        public void set_SocketErrorCode(){} // RVA: 0x7FFE8170B670
        public void get_Connected(){} // RVA: 0x7FFE86D63CA0
        public void get_ServerAddress(){} // RVA: 0x7FFE8144E200
        public void set_ServerAddress(){} // RVA: 0x7FFE81129890
        public void get_ProxyServerAddress(){} // RVA: 0x7FFE8143BA80
        public void set_ProxyServerAddress(){} // RVA: 0x7FFE81437330
        public void set_ServerIpAddress(){} // RVA: 0x7FFE81123200
        public void get_ServerPort(){} // RVA: 0x7FFE8119C0C0
        public void set_ServerPort(){} // RVA: 0x7FFE8119C0D0
        public void get_AddressResolvedAsIpv6(){} // RVA: 0x7FFE82447BA0
        public void set_AddressResolvedAsIpv6(){} // RVA: 0x7FFE824479E0
        public void set_UrlProtocol(){} // RVA: 0x7FFE812534D0
        public void set_UrlPath(){} // RVA: 0x7FFE811C3510
        public void get_SerializationProtocol(){} // RVA: 0x7FFE86D63CB0
        public void .ctor(){} // RVA: 0x7FFE86D63E70
        public void Connect(){} // RVA: 0x7FFE86D63FA0
        public void Disconnect(){} // RVA: 0x7FFE80E2F150
        public void Send(){}
        public void Receive(){} // RVA: 0x7FFE80E33B00
        public void HandleReceivedDatagram(){} // RVA: 0x7FFE86D64350
        public void ReportDebugOfLevel(){} // RVA: 0x7FFE86D64380
        public void EnqueueDebugReturn(){} // RVA: 0x7FFE86D643B0
        public void HandleException(){} // RVA: 0x7FFE86D643D0
        public void TryParseAddress(){} // RVA: 0x7FFE86D64480
        public void IpAddressTryParse(){} // RVA: 0x7FFE86D64970
        public void GetIpAddresses(){} // RVA: 0x7FFE86D64C30
        public void AddressSortComparer(){} // RVA: 0x7FFE86D653F0
        public void <HandleException>b__56_0(){} // RVA: 0x7FFE86D65450
    }

    public class Pool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){}
        public void CreatePoolItems(){} // RVA: 0x7FFE80E46530
        public void Release(){} // RVA: 0x7FFE810A1420
        public void Acquire(){} // RVA: 0x7FFE810A1420
    }

    public class PreserveAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Protocol : Object
    {
        public Photon.Client.ByteArraySlicePool ByteArraySlicePool; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Type,Photon.Client.CustomType> TypeDict;

        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7FFE80E2E2E0
        public void get_VersionBytes(){} // RVA: 0x7FFE80E2E2E0
        public void Serialize(){} // RVA: 0x7FFE86D65980 | overloaded x2
        public void SerializeShort(){}
        public void SerializeString(){}
        public void SerializeEventData(){}
        public void SerializeOperationRequest(){}
        public void SerializeOperationResponse(){}
        public void Deserialize(){} // RVA: 0x7FFE86D65A20 | overloaded x2
        public void DeserializeShort(){} // RVA: 0x7FFE80E34A20
        public void DeserializeByte(){} // RVA: 0x7FFE80E2F3B0
        public void DeserializeEventData(){}
        public void DeserializeOperationRequest(){} // RVA: 0x7FFE80E3F2F0
        public void DeserializeOperationResponse(){} // RVA: 0x7FFE80E3F2F0
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFE80E2E390
        public void DeserializeMessage(){} // RVA: 0x7FFE86D65B10
        public void TryRegisterType(){} // RVA: 0x7FFE86D65B70
        public void .ctor(){} // RVA: 0x7FFE86D65EE0
        public void .cctor(){} // RVA: 0x7FFE86D65F80
    }

    public class Protocol16 : Protocol
    {
        public byte[] versionBytes; // 0x18
        public byte[] memShort; // 0x20

        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7FFE86D66120
        public void get_VersionBytes(){} // RVA: 0x7FFE810FE7C0
        public void SerializeCustom(){} // RVA: 0x7FFE86D66160
        public void DeserializeCustom(){} // RVA: 0x7FFE86D66530
        public void GetTypeOfCode(){} // RVA: 0x7FFE86D66860
        public void GetCodeOfType(){} // RVA: 0x7FFE86D66BE0
        public void CreateArrayByType(){} // RVA: 0x7FFE86D66F80
        public void SerializeOperationRequest(){} // RVA: 0x7FFE86D66FF0 | overloaded x2
        public void DeserializeOperationRequest(){} // RVA: 0x7FFE86D670D0
        public void SerializeOperationResponse(){} // RVA: 0x7FFE86D671C0
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFE86D67350
        public void DeserializeOperationResponse(){} // RVA: 0x7FFE86D67520
        public void SerializeEventData(){} // RVA: 0x7FFE86D67710
        public void DeserializeEventData(){} // RVA: 0x7FFE86D677F0
        public void SerializeParameterTable(){} // RVA: 0x7FFE86D678B0
        public void DeserializeParameterDictionary(){} // RVA: 0x7FFE86D67C40
        public void Serialize(){} // RVA: 0x7FFE86D67D70
        public void SerializeByte(){} // RVA: 0x7FFE86D689A0
        public void SerializeBoolean(){} // RVA: 0x7FFE86D68A50
        public void SerializeShort(){} // RVA: 0x7FFE86D68B00
        public void SerializeLengthAsShort(){} // RVA: 0x7FFE86D68D50
        public void SerializeInteger(){} // RVA: 0x7FFE86D68FA0
        public void SerializeLong(){} // RVA: 0x7FFE86D69210
        public void SerializeFloat(){} // RVA: 0x7FFE86D696C0
        public void SerializeDouble(){} // RVA: 0x7FFE86D69C30
        public void SerializeString(){} // RVA: 0x7FFE86D6A0F0
        public void SerializeArray(){} // RVA: 0x7FFE86D6A2D0
        public void SerializeByteArray(){} // RVA: 0x7FFE86D6A9B0
        public void SerializeByteArraySegment(){} // RVA: 0x7FFE86D6AA70
        public void SerializeIntArrayOptimized(){} // RVA: 0x7FFE86D6AB50
        public void SerializeObjectArray(){} // RVA: 0x7FFE86D6ADB0
        public void SerializeHashTable(){} // RVA: 0x7FFE86D6B000
        public void SerializeDictionary(){} // RVA: 0x7FFE86D6B360
        public void SerializeDictionaryHeader(){} // RVA: 0x7FFE86D6B460 | overloaded x2
        public void SerializeDictionaryElements(){} // RVA: 0x7FFE86D6B8A0
        public void Deserialize(){} // RVA: 0x7FFE86D6BC00
        public void DeserializeByte(){} // RVA: 0x7FFE86D6C530
        public void DeserializeBoolean(){} // RVA: 0x7FFE86D6C550
        public void DeserializeShort(){} // RVA: 0x7FFE86D6C580
        public void DeserializeInteger(){} // RVA: 0x7FFE86D6C930
        public void DeserializeLong(){} // RVA: 0x7FFE86D6CD00
        public void DeserializeFloat(){} // RVA: 0x7FFE86D6D140
        public void DeserializeDouble(){} // RVA: 0x7FFE86D6D580
        public void DeserializeString(){} // RVA: 0x7FFE86D6DA50
        public void DeserializeArray(){} // RVA: 0x7FFE86D6DBB0
        public void DeserializeByteArray(){} // RVA: 0x7FFE86D6E5D0
        public void DeserializeIntArray(){} // RVA: 0x7FFE86D6E690
        public void DeserializeStringArray(){} // RVA: 0x7FFE86D6E750
        public void DeserializeObjectArray(){} // RVA: 0x7FFE86D6E860
        public void DeserializeHashTable(){} // RVA: 0x7FFE86D6E9E0
        public void DeserializeDictionary(){} // RVA: 0x7FFE86D6EB50
        public void DeserializeDictionaryArray(){} // RVA: 0x7FFE86D6EF30
        public void DeserializeDictionaryType(){} // RVA: 0x7FFE86D6F1E0
        public void .ctor(){} // RVA: 0x7FFE86D6F4B0
        public void .cctor(){} // RVA: 0x7FFE86D6F930
    }

    public class Protocol18 : Protocol
    {
        public byte[] versionBytes; // 0x18
        public byte[] boolMasks;

        // ── Methods ──
        public void get_ProtocolType(){} // RVA: 0x7FFE86D6FAE0
        public void get_VersionBytes(){} // RVA: 0x7FFE810FE7C0
        public void Serialize(){} // RVA: 0x7FFE86D6FB20
        public void SerializeShort(){} // RVA: 0x7FFE86D6FBA0
        public void SerializeString(){} // RVA: 0x7FFE86D6FC10
        public void Deserialize(){} // RVA: 0x7FFE86D6FC20
        public void DeserializeShort(){} // RVA: 0x7FFE86D6FC40
        public void DeserializeByte(){} // RVA: 0x7FFE86D6C530
        public void GetAllowedDictionaryKeyTypes(){} // RVA: 0x7FFE86D6FCC0
        public void GetClrArrayType(){} // RVA: 0x7FFE86D6FEB0
        public void GetCodeOfType(){} // RVA: 0x7FFE86D70210
        public void GetCodeOfTypeCode(){} // RVA: 0x7FFE86D70A30
        public void Read(){} // RVA: 0x7FFE86D70B20 | overloaded x2
        public void ReadBoolean(){} // RVA: 0x7FFE86D6C550
        public void ReadByte(){} // RVA: 0x7FFE86D6C530
        public void ReadInt16(){} // RVA: 0x7FFE86D6FC40
        public void ReadUShort(){} // RVA: 0x7FFE86D6FC40
        public void ReadSingle(){} // RVA: 0x7FFE86D71DD0
        public void ReadDouble(){} // RVA: 0x7FFE86D71E70
        public void ReadNonAllocByteArray(){} // RVA: 0x7FFE86D71F10
        public void ReadByteArray(){} // RVA: 0x7FFE86D71FB0
        public void ReadCustomType(){} // RVA: 0x7FFE86D72060
        public void DeserializeEventData(){} // RVA: 0x7FFE86D72420
        public void ReadParameterDictionary(){} // RVA: 0x7FFE86D72660
        public void ReadHashtable(){} // RVA: 0x7FFE86D72790
        public void DeserializeOperationRequest(){} // RVA: 0x7FFE86D72980
        public void DeserializeOperationResponse(){} // RVA: 0x7FFE86D72A70
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFE86D72C80
        public void ReadString(){} // RVA: 0x7FFE86D72E60
        public void ReadCustomTypeArray(){} // RVA: 0x7FFE86D72F40
        public void ReadDictionaryType(){} // RVA: 0x7FFE86D737E0 | overloaded x2
        public void GetDictArrayType(){} // RVA: 0x7FFE86D73A90
        public void ReadDictionary(){} // RVA: 0x7FFE86D73B90
        public void ReadDictionaryElements(){} // RVA: 0x7FFE86D73DC0
        public void ReadObjectArray(){} // RVA: 0x7FFE86D73F40
        public void ReadBooleanArray(){} // RVA: 0x7FFE86D740B0
        public void ReadInt16Array(){} // RVA: 0x7FFE86D742F0
        public void ReadSingleArray(){} // RVA: 0x7FFE86D743F0
        public void ReadDoubleArray(){} // RVA: 0x7FFE86D744B0
        public void ReadStringArray(){} // RVA: 0x7FFE86D74570
        public void ReadHashtableArray(){} // RVA: 0x7FFE86D74670
        public void ReadDictionaryArray(){} // RVA: 0x7FFE86D74800
        public void ReadArrayInArray(){} // RVA: 0x7FFE86D74B90
        public void ReadInt1(){} // RVA: 0x7FFE86D74D30
        public void ReadInt2(){} // RVA: 0x7FFE86D74D70
        public void ReadCompressedInt32(){} // RVA: 0x7FFE86D74E30
        public void ReadCompressedUInt32(){} // RVA: 0x7FFE86D74E50
        public void ReadCompressedInt64(){} // RVA: 0x7FFE86D750F0
        public void ReadCompressedUInt64(){} // RVA: 0x7FFE86D751D0
        public void ReadCompressedInt32Array(){} // RVA: 0x7FFE86D752A0
        public void ReadCompressedInt64Array(){} // RVA: 0x7FFE86D75360
        public void DecodeZigZag32(){} // RVA: 0x7FFE86D75410
        public void DecodeZigZag64(){} // RVA: 0x7FFE86D75420
        public void Write(){} // RVA: 0x7FFE86D75430 | overloaded x2
        public void SerializeEventData(){} // RVA: 0x7FFE86D76A70
        public void WriteParameterTable(){} // RVA: 0x7FFE86D76B50
        public void SerializeOperationRequest(){} // RVA: 0x7FFE86D76F50 | overloaded x2
        public void SerializeOperationResponse(){} // RVA: 0x7FFE86D77030
        public void WriteByte(){} // RVA: 0x7FFE86D771E0
        public void WriteBoolean(){} // RVA: 0x7FFE86D77270
        public void WriteUShort(){} // RVA: 0x7FFE86D77310
        public void WriteInt16(){} // RVA: 0x7FFE86D6FBA0
        public void WriteDouble(){} // RVA: 0x7FFE86D77340
        public void WriteSingle(){} // RVA: 0x7FFE86D776F0
        public void WriteString(){} // RVA: 0x7FFE86D77AA0
        public void WriteHashtable(){} // RVA: 0x7FFE86D77C50
        public void WriteByteArray(){} // RVA: 0x7FFE86D77F60
        public void WriteArraySegmentByte(){} // RVA: 0x7FFE86D78010
        public void WriteByteArraySlice(){} // RVA: 0x7FFE86D78160
        public void WriteInt32ArrayCompressed(){} // RVA: 0x7FFE86D78240
        public void WriteInt64ArrayCompressed(){} // RVA: 0x7FFE86D78310
        public void WriteBoolArray(){} // RVA: 0x7FFE86D783F0
        public void WriteInt16Array(){} // RVA: 0x7FFE86D786E0
        public void WriteSingleArray(){} // RVA: 0x7FFE86D787B0
        public void WriteDoubleArray(){} // RVA: 0x7FFE86D788A0
        public void WriteStringArray(){} // RVA: 0x7FFE86D78990
        public void WriteObjectArray(){} // RVA: 0x7FFE86D78B50
        public void WriteArrayInArray(){} // RVA: 0x7FFE86D78D70
        public void WriteCustomTypeBody(){} // RVA: 0x7FFE86D78EA0
        public void WriteCustomType(){} // RVA: 0x7FFE86D79140
        public void WriteCustomTypeArray(){} // RVA: 0x7FFE86D79620
        public void WriteArrayHeader(){} // RVA: 0x7FFE86D79CB0
        public void WriteDictionaryElements(){} // RVA: 0x7FFE86D79E10
        public void WriteDictionary(){} // RVA: 0x7FFE86D7A0E0
        public void WriteDictionaryHeader(){} // RVA: 0x7FFE86D7A220
        public void WriteArrayType(){} // RVA: 0x7FFE86D7A9E0
        public void WriteHashtableArray(){} // RVA: 0x7FFE86D7AEB0
        public void WriteDictionaryArray(){} // RVA: 0x7FFE86D7B000
        public void WriteIntLength(){} // RVA: 0x7FFE86D7B140
        public void WriteCompressedInt32(){} // RVA: 0x7FFE86D7B150
        public void WriteCompressedInt64(){} // RVA: 0x7FFE86D7B300
        public void WriteCompressedUInt32(){} // RVA: 0x7FFE86D7B6A0 | overloaded x2
        public void WriteCompressedUInt64(){} // RVA: 0x7FFE86D7B710
        public void EncodeZigZag32(){} // RVA: 0x7FFE86D7B950
        public void EncodeZigZag64(){} // RVA: 0x7FFE86D7B960
        public void .ctor(){} // RVA: 0x7FFE86D7B970
        public void .cctor(){} // RVA: 0x7FFE86D7BC70
    }

    public class SendOptions : ValueType
    {
        public Photon.Client.SendOptions SendReliable;

        // ── Methods ──
        public void get_Reliability(){} // RVA: 0x7FFE86D7CE20
        public void set_Reliability(){} // RVA: 0x7FFE86D7CE30
        public void .cctor(){} // RVA: 0x7FFE86D7CE40
    }

    public class SerializationProtocolFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE86D65660
    }

    public class SerializeStreamMethod : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8401BBD0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class SimulationItem : Object
    {
        public System.Diagnostics.Stopwatch stopw; // 0x10

        // ── Methods ──
        public void get_Delay(){} // RVA: 0x7FFE81549710
    }

    public class SocketTcp : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D7CEB0
        public void Finalize(){} // RVA: 0x7FFE86D7CFD0
        public void Dispose(){} // RVA: 0x7FFE86D7D010
        public void Connect(){} // RVA: 0x7FFE86D7D120
        public void Disconnect(){} // RVA: 0x7FFE86D7D3C0
        public void Send(){} // RVA: 0x7FFE86D7D620
        public void Receive(){} // RVA: 0x7FFE82878320
        public void DnsAndConnect(){} // RVA: 0x7FFE86D7D910
        public void ReceiveLoop(){} // RVA: 0x7FFE86D7E040
    }

    public class SocketTcpAsync : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D7EA40
        public void Finalize(){} // RVA: 0x7FFE86D7EB60
        public void Dispose(){} // RVA: 0x7FFE86D7EBA0
        public void Connect(){} // RVA: 0x7FFE86D7ECC0
        public void Disconnect(){} // RVA: 0x7FFE86D7EF60
        public void Send(){} // RVA: 0x7FFE86D7F1F0
        public void Receive(){} // RVA: 0x7FFE82878320
        public void DnsAndConnect(){} // RVA: 0x7FFE86D7F720
        public void ReceiveAsync(){} // RVA: 0x7FFE86D80230 | overloaded x2
    }

    public class SocketUdp : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D80A40
        public void Finalize(){} // RVA: 0x7FFE86D80BD0
        public void Dispose(){} // RVA: 0x7FFE86D80C10
        public void Connect(){} // RVA: 0x7FFE86D80D30
        public void Disconnect(){} // RVA: 0x7FFE86D80FD0
        public void Send(){} // RVA: 0x7FFE86D81260
        public void Receive(){} // RVA: 0x7FFE82878320
        public void DnsAndConnect(){} // RVA: 0x7FFE86D81DD0
        public void ReceiveLoop(){} // RVA: 0x7FFE86D82440
    }

    public class SocketUdpAsync : PhotonSocket
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D82B70
        public void Finalize(){} // RVA: 0x7FFE86D7EB60
        public void Dispose(){} // RVA: 0x7FFE86D7EBA0
        public void Connect(){} // RVA: 0x7FFE86D82C90
        public void Disconnect(){} // RVA: 0x7FFE86D82F30
        public void Send(){} // RVA: 0x7FFE86D831C0
        public void Receive(){} // RVA: 0x7FFE82878320
        public void DnsAndConnect(){} // RVA: 0x7FFE86D83720
        public void StartReceive(){} // RVA: 0x7FFE86D83C90
        public void OnReceive(){} // RVA: 0x7FFE86D83F10
    }

    public class StreamBuffer : Object
    {
        public int DefaultInitialSize;
        public int pos; // 0x10
        public int len; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D84900 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFE86D84970
        public void Compact(){} // RVA: 0x7FFE86D849E0
        public void GetBuffer(){} // RVA: 0x7FFE810FE7C0
        public void GetBufferAndAdvance(){} // RVA: 0x7FFE86D84A60
        public void get_Length(){} // RVA: 0x7FFE8164B230
        public void get_Position(){} // RVA: 0x7FFE811485C0
        public void set_Position(){} // RVA: 0x7FFE86D84AA0
        public void get_Available(){} // RVA: 0x7FFE86D84AC0
        public void Reset(){} // RVA: 0x7FFE86D84AD0
        public void Seek(){} // RVA: 0x7FFE86D84AE0
        public void SetLength(){} // RVA: 0x7FFE86D84C00
        public void SetCapacityMinimum(){} // RVA: 0x7FFE86D84C30
        public void Read(){} // RVA: 0x7FFE86D84C40
        public void Write(){} // RVA: 0x7FFE86D84CA0
        public void ReadByte(){} // RVA: 0x7FFE86D84D20
        public void WriteByte(){} // RVA: 0x7FFE86D84E10
        public void WriteBytes(){} // RVA: 0x7FFE86D84E70
        public void CheckSize(){} // RVA: 0x7FFE86D84F00
    }

    public class SupportClass : Object
    {
        // ── Methods ──
        public void WriteStackTrace(){} // RVA: 0x7FFE86D85010
        public void DictionaryToString(){} // RVA: 0x7FFE86D85BB0 | overloaded x2
        public void ByteArrayToString(){} // RVA: 0x7FFE86D866E0
        public void InitializeTable(){} // RVA: 0x7FFE86D86760
        public void CalculateCrc(){} // RVA: 0x7FFE86D86A90 | overloaded x2
    }

    public class TPeer : PeerBase
    {
        public System.Collections.Generic.Queue`1<Photon.Client.StreamBuffer> incomingList; // 0x128

        // ── Methods ──
        public void get_QueuedOutgoingCommandsCount(){} // RVA: 0x7FFE86D86D70
        public void .ctor(){} // RVA: 0x7FFE86D86DC0
        public void IsTransportEncrypted(){} // RVA: 0x7FFE86D86FF0
        public void Reset(){} // RVA: 0x7FFE86D87000
        public void Connect(){} // RVA: 0x7FFE86D87190
        public void Disconnect(){} // RVA: 0x7FFE86D875F0 | overloaded x2
        public void FetchServerTimestamp(){} // RVA: 0x7FFE86D878A0
        public void EnqueueInit(){} // RVA: 0x7FFE86D879E0
        public void DispatchIncomingCommands(){} // RVA: 0x7FFE86D87B80
        public void SendOutgoingCommands(){} // RVA: 0x7FFE86D880C0
        public void SendAcksOnly(){} // RVA: 0x7FFE86D88590
        public void EnqueuePhotonMessage(){} // RVA: 0x7FFE86D88600
        public void EnqueueMessageAsPayload(){} // RVA: 0x7FFE86D88630
        public void SendPing(){} // RVA: 0x7FFE86D889E0
        public void SendData(){} // RVA: 0x7FFE86D88E80
        public void ReceiveIncomingCommands(){} // RVA: 0x7FFE86D89010
        public void ReadPingResult(){} // RVA: 0x7FFE86D896B0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE86D89800
    }

    public class TrafficStats : TrafficStatsBase
    {
        public System.Diagnostics.Stopwatch connectionStopwatch; // 0x60
        public int LastSendOutgoingTimestamp; // 0x68
        public int LastSendAckTimestamp; // 0x6C
        public int _lastReceiveTimestamp; // 0x70
        public int _lastDispatchTimestamp; // 0x74

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81199380
        public void get_LastReceiveTimestamp(){} // RVA: 0x7FFE81E60180
        public void set_LastReceiveTimestamp(){} // RVA: 0x7FFE81293CF0
        public void get_LastDispatchTimestamp(){} // RVA: 0x7FFE826A9B90
        public void set_LastDispatchTimestamp(){} // RVA: 0x7FFE82B1F9C0
        public void get_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x7FFE8286C0A0
        public void set_LongestDeltaBetweenDispatchCalls(){} // RVA: 0x7FFE82862F10
        public void set_LastDispatchDuration(){} // RVA: 0x7FFE86D89990
        public void get_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0x7FFE81D30560
        public void set_LongestDeltaBetweenSendOutgoingCalls(){} // RVA: 0x7FFE81D307B0
        public void DispatchIncomingCommandsCalled(){} // RVA: 0x7FFE86D899A0
        public void SendOutgoingCommandsCalled(){} // RVA: 0x7FFE86D899C0
        public void ToString(){} // RVA: 0x7FFE86D899F0 | overloaded x2
    }

    public class TrafficStatsBase : Object
    {
        public long _bytesIn; // 0x10
        public long _bytesOut; // 0x18
        public int _packagesIn; // 0x20
        public int _packagesOut; // 0x24
        public int _udpFragmentsIn; // 0x28
        public int _udpFragmentsOut; // 0x2C
        public int _udpUnreliableCommandsSent; // 0x30
        public int _udpReliableCommandsSent; // 0x34
        public int _udpReliableCommandsResent; // 0x38
        public int _udpReliableCommandsInFlight; // 0x3C
        public int _dispatchIncomingCommandsCalls; // 0x40
        public int _sendOutgoingCommandsCalls; // 0x44
        public long _roundtripTime; // 0x48
        public long _roundtripTimeVariance; // 0x50
        public long _lastRoundtripTime; // 0x58

        // ── Methods ──
        public void get_BytesIn(){} // RVA: 0x7FFE81116380
        public void set_BytesIn(){} // RVA: 0x7FFE826F2ED0
        public void get_BytesOut(){} // RVA: 0x7FFE810FE7C0
        public void set_BytesOut(){} // RVA: 0x7FFE819EA910
        public void get_PackagesIn(){} // RVA: 0x7FFE8151D690
        public void set_PackagesIn(){} // RVA: 0x7FFE8170B670
        public void get_PackagesOut(){} // RVA: 0x7FFE81A56130
        public void set_PackagesOut(){} // RVA: 0x7FFE82447980
        public void get_UdpFragmentsIn(){} // RVA: 0x7FFE81549710
        public void set_UdpFragmentsIn(){} // RVA: 0x7FFE817E4800
        public void get_UdpFragmentsOut(){} // RVA: 0x7FFE81F84A50
        public void set_UdpFragmentsOut(){} // RVA: 0x7FFE82883A50
        public void get_UdpUnreliableCommandsSent(){} // RVA: 0x7FFE81156CD0
        public void set_UdpUnreliableCommandsSent(){} // RVA: 0x7FFE81156CE0
        public void get_UdpReliableCommandsSent(){} // RVA: 0x7FFE82447220
        public void set_UdpReliableCommandsSent(){} // RVA: 0x7FFE82443340
        public void get_UdpReliableCommandsResent(){} // RVA: 0x7FFE81D46090
        public void set_UdpReliableCommandsResent(){} // RVA: 0x7FFE81D46A00
        public void set_UdpReliableCommandsInFlight(){} // RVA: 0x7FFE82A4B070
        public void get_DispatchIncomingCommandsCalls(){} // RVA: 0x7FFE8119C080
        public void set_DispatchIncomingCommandsCalls(){} // RVA: 0x7FFE8119C090
        public void get_SendOutgoingCommandsCalls(){} // RVA: 0x7FFE8119C0A0
        public void set_SendOutgoingCommandsCalls(){} // RVA: 0x7FFE8119C0B0
        public void get_RoundtripTime(){} // RVA: 0x7FFE81176730
        public void set_RoundtripTime(){} // RVA: 0x7FFE82502600
        public void get_RoundtripTimeVariance(){} // RVA: 0x7FFE8119C0E0
        public void set_RoundtripTimeVariance(){} // RVA: 0x7FFE82506C00
        public void set_LastRoundtripTime(){} // RVA: 0x7FFE825093B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnknownType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Version : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86D8A130
    }

}