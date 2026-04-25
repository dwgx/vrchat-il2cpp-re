// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Codec.StateManagement
// Classes: 3
// Methods: 89

namespace VRC.Core.Networking.Codec.StateManagement
{
    public class AbstractObjectStateManager : Object
    {
        public int SerializationHeaderLengthSingleBunch; // 0x10
        public int SerializationHeaderLengthMultiBunch; // 0x14
        public SendEventToAllPlayersDelegate MaximumViewID; // 0x18
        public SendEventToPlayerDelegate MinimumViewID; // 0x20
        public SetOwnerDelegate ManagedPlayerViews; // 0x28
        public ListPlayersDelegate ObjectStateSizeBytes; // 0x30
        public LogDelegate _log; // 0x38
        public LogDelegate _warn; // 0x40
        public LogDelegate _error; // 0x48
        public System.Collections.Generic.HashSet`1<int> _managedPlayerViews; // 0x50

        // ── Methods ──
        public void SerializationHeaderLength(){} // RVA: 0x7FFAC9DE27B0
        public void get_SerializationHeaderLengthSingleBunch(){} // RVA: 0x7FFAC9AEC810
        public void get_SerializationHeaderLengthMultiBunch(){} // RVA: 0x7FFAC9DE27C0
        public void get_MaximumViewID(){} // RVA: 0x7FFAC2F6E5C0
        public void set_MaximumViewID(){} // RVA: 0x7FFAC2F240C0
        public void get_MinimumViewID(){} // RVA: 0x7FFAC33D5A20
        public void set_MinimumViewID(){} // RVA: 0x7FFAC33D4990
        public void FlattenPlayerViewId(){} // RVA: 0x7FFAC9DE27D0
        public void get_ManagedPlayerViews(){} // RVA: 0x7FFAC2FC20E0
        public void SendEventToPlayer(){} // RVA: 0x7FFAC9DE27E0
        public void SendEventToAllPlayers(){} // RVA: 0x7FFAC7797E30
        public void SetOwner(){} // RVA: 0x7FFAC9A89700
        public void ListPlayers(){} // RVA: 0x7FFAC9DE2800
        public void Log(){} // RVA: 0x7FFAC9A85940
        public void Warn(){} // RVA: 0x7FFAC7870F30
        public void Error(){} // RVA: 0x7FFAC9DE2860
        public void .ctor(){} // RVA: 0x7FFAC9DE2880
        public void RaiseStorageUsage(){} // RVA: 0x7FFAC2C70980
        public void RecordBunch8(){}
        public void RecordBunch32(){}
        public void DeleteStateForViewId(){} // RVA: 0x7FFAC2C70ED0
        public void OnPlayerLeft(){} // RVA: 0x7FFAC2C70ED0
        public void OnPlayerJoined(){} // RVA: 0x7FFAC2C70ED0
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7FFAC2C58E90
        public void OnBeforeInstanceClose(){} // RVA: 0x7FFAC2C70980
        public void TestAndRecordInstanceMetadata(){}
        public void Update(){} // RVA: 0x7FFAC2C70980
    }

    public class PersistenceObjectStateManager : AbstractObjectStateManager
    {
        public OnDecodeError UseInstancePersistence; // 0x58
        public GetBucketLimitsDelegate UsePlayerPersistence; // 0x60
        public InstanceStorageIdDelegate ObjectStateSizeBytes; // 0x68
        public PlayerStorageIdDelegate _playerStorageId; // 0x70
        public bool _enablePlayerPersistence; // 0x78
        public bool _enableInstancePersistence; // 0x79
        public bool _didSendPersistenceRecoveredMessage; // 0x7A
        public byte _serializationRecoveryID; // 0x7B
        public byte _instancePersistenceRecoveredID; // 0x7C
        public byte _playerPersistenceRecoveredID; // 0x7D
        public System.Collections.Generic.List`1<int> _didSendPlayerPersistenceRecoveredMessage; // 0x80
        public int _maximumBunchSize; // 0x88
        public int _playerPersistenceMinID; // 0x8C
        public int _playerPersistenceMaxID; // 0x90
        public WriteInstanceDelegate _writeInstance; // 0x98
        public ReadInstanceDelegate _readInstance; // 0xA0
        public WritePlayerDelegate _writePlayer; // 0xA8
        public ReadPlayerDelegate _readPlayer; // 0xB0
        public RaiseDataUsage _raiseDataUsage; // 0xB8
        public Google.FlatBuffers32.FlatBufferBuilder _metadataBuilder; // 0xC0
        public System.Nullable`1<long> _activeMetadataSize; // 0xC8
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.Networking.FlatBuffers.FlatBuffers32.WorldMetadataT> ReceivedMetadata; // 0xD8
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.WorldMetadataT BaseWorldMetadata; // 0xE0
        public System.Collections.Generic.Dictionary`2<int,VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataPairT> ActiveStateLookup; // 0xE8
        public System.Collections.Generic.Dictionary`2<int,VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataPairT> IncompleteStateLookup; // 0xF0
        public System.Collections.Generic.Dictionary`2<int,VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataPairT> RecoveredStateLookup; // 0xF8
        public System.Collections.Generic.HashSet`1<int> PlayerPersistenceViewIDs; // 0x100
        public System.Collections.Generic.IDictionary`2<string,System.Collections.Generic.IDictionary`2<int,int>> _lastUsage; // 0x108
        public object raiseSizeRequestLock; // 0x110
        public bool raiseSizeRequested; // 0x118
        public string PLAYER_STORAGE_BUCKET;
        public string PLAYER_OBJECTS_BUCKET;
        public string INSTANCE_OBJECTS_BUCKET;
        public string[] AllBuckets;
        public System.Collections.Generic.Dictionary`2<string,uint> HashBuckets; // 0x8
        public System.Collections.Generic.Dictionary`2<uint,string> DeHashBuckets; // 0x10
        public System.Collections.Generic.List`1<BucketInfo> PlayerBucketFilters; // 0x120
        public BucketInfo InstanceBucketFilter; // 0x128

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9DE2ED0
        public void InstanceStorageId(){} // RVA: 0x7FFAC9DE3930
        public void PlayerStorageId(){} // RVA: 0x7FFAC9DE3950
        public void WriteInstance(){} // RVA: 0x7FFAC9DE3970
        public void ReadInstance(){} // RVA: 0x7FFAC9DE3990
        public void WritePlayer(){} // RVA: 0x7FFAC9DE39B0
        public void ReadPlayer(){} // RVA: 0x7FFAC9DE39E0
        public void get_UseInstancePersistence(){} // RVA: 0x7FFAC33CC650
        public void get_UsePlayerPersistence(){} // RVA: 0x7FFAC9DE3A10
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7FFAC9DE3AC0
        public void MetadataToBytes(){} // RVA: 0x7FFAC9DE3B60
        public void CheckSizeWarnings(){} // RVA: 0x7FFAC9DE3DD0
        public void RaiseStorageUsage(){} // RVA: 0x7FFAC9DE4A20
        public void InternalRaiseDataUsage(){} // RVA: 0x7FFAC9DE4B50
        public void Update(){} // RVA: 0x7FFAC9DE5100
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7FFAC9DE5110
        public void OnPlayerJoined(){} // RVA: 0x7FFAC9DE5B20
        public void OnPlayerLeft(){} // RVA: 0x7FFAC9DE6700
        public void OnBeforeInstanceClose(){} // RVA: 0x7FFAC9DE6B10
        public void RestoreInstance(){} // RVA: 0x7FFAC9DE6CB0
        public void HibernatePlayer(){} // RVA: 0x7FFAC9DE6E00
        public void RestorePlayerPersistence(){} // RVA: 0x7FFAC9DE7270
        public void RewriteBunchViewID(){} // RVA: 0x7FFAC9DE7770
        public void DeleteStateForViewId(){} // RVA: 0x7FFAC9DE78E0
        public void RecordBunch8(){} // RVA: 0x7FFAC9DE7940
        public void RecordBunch32(){} // RVA: 0x7FFAC9DE7990
        public void RecordBunch(){} // RVA: 0x7FFAC9DE7A10
        public void CalculateMetadataSize(){} // RVA: 0x7FFAC9DE80E0
        public void CountStateSize(){} // RVA: 0x7FFAC9DE8110
        public void CollectPlayerPersistenceState(){} // RVA: 0x7FFAC9DE8C10 | overloaded x2
        public void CollectInstancePersistenceState(){} // RVA: 0x7FFAC9DE8DA0
        public void CollectState(){} // RVA: 0x7FFAC9DE8F30
        public void ReadState(){} // RVA: 0x7FFAC9DE9570
        public void ShouldNotPersistForAny(){} // RVA: 0x7FFAC9DE9770
        public void AdaptPlayerViewId(){} // RVA: 0x7FFAC9DE97A0
        public void PlayerPersistenceViewIDsForPlayer(){} // RVA: 0x7FFAC9DE97B0
        public void IsPlayerPersistenceViewIDForPlayer(){} // RVA: 0x7FFAC9DE98D0
        public void IsPlayerStorageID(){} // RVA: 0x7FFAC9DE9970
        public void IsPlayerObjectID(){} // RVA: 0x7FFAC9DE99D0
        public void IsSceneObjectID(){} // RVA: 0x7FFAC9DE9A50
        public void InitBucketFilters(){} // RVA: 0x7FFAC9DE9A60
        public void .cctor(){} // RVA: 0x7FFAC9DE9EF0
        public void <CheckSizeWarnings>g__CollateUsage|58_0(){} // RVA: 0x7FFAC9DEA460
        public void <CheckSizeWarnings>g__RaiseWarningAndError|58_1(){} // RVA: 0x7FFAC9DEA5F0
        public void <TestAndRecordInstanceMetadata>b__62_0(){} // RVA: 0x7FFAC9DEAA90
        public void <RestoreInstance>g__onRestore|66_0(){} // RVA: 0x7FFAC9DEAAD0
        public void <RestoreInstance>g__restoreInstanceFrom|66_1(){} // RVA: 0x7FFAC9DEAB90
        public void <InitBucketFilters>b__98_0(){} // RVA: 0x7FFAC9DEB430
    }

    public class SimpleObjectStateManager : AbstractObjectStateManager
    {
        public System.Collections.Generic.Dictionary`2<int,BunchesInformation> ObjectStateSizeBytes; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9DEE2F0
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7FFAC9DEE400
        public void Update(){} // RVA: 0x7FFAC2F21310
        public void OnBeforeInstanceClose(){} // RVA: 0x7FFAC2F21310
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7FFAC2F21320
        public void RaiseStorageUsage(){} // RVA: 0x7FFAC9DEE620
        public void OnPlayerLeft(){} // RVA: 0x7FFAC2F21310
        public void OnPlayerJoined(){} // RVA: 0x7FFAC9DEE660
        public void DeleteStateForViewId(){} // RVA: 0x7FFAC9DEEA70
        public void RecordBunch8(){} // RVA: 0x7FFAC9DEEAD0
        public void RecordBunch32(){} // RVA: 0x7FFAC9DEED40
        public void WriteBunches(){} // RVA: 0x7FFAC9DEF010
        public void ReadBunches(){} // RVA: 0x7FFAC9DEF6B0
    }

}