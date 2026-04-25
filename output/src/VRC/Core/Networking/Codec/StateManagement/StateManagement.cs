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
        public 0x66564F30 MaximumViewID; // 0x18
        public 0x66564ED8 MinimumViewID; // 0x20
        public 0x66564F88 ManagedPlayerViews; // 0x28
        public 0x66564E80 ObjectStateSizeBytes; // 0x30
        public 0x66564FE0 _log; // 0x38
        public 0x66564FE0 _warn; // 0x40
        public 0x66564FE0 _error; // 0x48
        public System.Collections.Generic.HashSet`1<int> _managedPlayerViews; // 0x50

        // ── Methods ──
        public void SerializationHeaderLength(){} // RVA: 0x7FFD552027B0
        public void get_SerializationHeaderLengthSingleBunch(){} // RVA: 0x7FFD54F0C810
        public void get_SerializationHeaderLengthMultiBunch(){} // RVA: 0x7FFD552027C0
        public void get_MaximumViewID(){} // RVA: 0x7FFD4E38E5C0
        public void set_MaximumViewID(){} // RVA: 0x7FFD4E3440C0
        public void get_MinimumViewID(){} // RVA: 0x7FFD4E7F5A20
        public void set_MinimumViewID(){} // RVA: 0x7FFD4E7F4990
        public void FlattenPlayerViewId(){} // RVA: 0x7FFD552027D0
        public void get_ManagedPlayerViews(){} // RVA: 0x7FFD4E3E20E0
        public void SendEventToPlayer(){} // RVA: 0x7FFD552027E0
        public void SendEventToAllPlayers(){} // RVA: 0x7FFD52BB7E30
        public void SetOwner(){} // RVA: 0x7FFD54EA9700
        public void ListPlayers(){} // RVA: 0x7FFD55202800
        public void Log(){} // RVA: 0x7FFD54EA5940
        public void Warn(){} // RVA: 0x7FFD52C90F30
        public void Error(){} // RVA: 0x7FFD55202860
        public void .ctor(){} // RVA: 0x7FFD55202880
        public void RaiseStorageUsage(){} // RVA: 0x7FFD4E090980
        public void RecordBunch8(){}
        public void RecordBunch32(){}
        public void DeleteStateForViewId(){} // RVA: 0x7FFD4E090ED0
        public void OnPlayerLeft(){} // RVA: 0x7FFD4E090ED0
        public void OnPlayerJoined(){} // RVA: 0x7FFD4E090ED0
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7FFD4E078E90
        public void OnBeforeInstanceClose(){} // RVA: 0x7FFD4E090980
        public void TestAndRecordInstanceMetadata(){}
        public void Update(){} // RVA: 0x7FFD4E090980
    }

    public class PersistenceObjectStateManager : AbstractObjectStateManager
    {
        public 0x665650E8 UseInstancePersistence; // 0x58
        public 0x66565350 UsePlayerPersistence; // 0x60
        public 0x66565508 ObjectStateSizeBytes; // 0x68
        public 0x665654B0 _playerStorageId; // 0x70
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
        public 0x66565198 _writeInstance; // 0x98
        public 0x665651F0 _readInstance; // 0xA0
        public 0x665652A0 _writePlayer; // 0xA8
        public 0x665652F8 _readPlayer; // 0xB0
        public 0x665653A8 _raiseDataUsage; // 0xB8
        public Google.FlatBuffers32.FlatBufferBuilder _metadataBuilder; // 0xC0
        public System.Nullable`1<long> _activeMetadataSize; // 0xC8
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.Networking.FlatBuffers.FlatBuffers32.WorldMetadataT> ReceivedMetadata; // 0xD8
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.WorldMetadataT BaseWorldMetadata; // 0xE0
        public System.Collections.Generic.Dictionary`2<int,0x66560390> ActiveStateLookup; // 0xE8
        public System.Collections.Generic.Dictionary`2<int,0x66560390> IncompleteStateLookup; // 0xF0
        public System.Collections.Generic.Dictionary`2<int,0x66560390> RecoveredStateLookup; // 0xF8
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
        public System.Collections.Generic.List`1<0x66565610> PlayerBucketFilters; // 0x120
        public 0x66565610 InstanceBucketFilter; // 0x128

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55202ED0
        public void InstanceStorageId(){} // RVA: 0x7FFD55203930
        public void PlayerStorageId(){} // RVA: 0x7FFD55203950
        public void WriteInstance(){} // RVA: 0x7FFD55203970
        public void ReadInstance(){} // RVA: 0x7FFD55203990
        public void WritePlayer(){} // RVA: 0x7FFD552039B0
        public void ReadPlayer(){} // RVA: 0x7FFD552039E0
        public void get_UseInstancePersistence(){} // RVA: 0x7FFD4E7EC650
        public void get_UsePlayerPersistence(){} // RVA: 0x7FFD55203A10
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7FFD55203AC0
        public void MetadataToBytes(){} // RVA: 0x7FFD55203B60
        public void CheckSizeWarnings(){} // RVA: 0x7FFD55203DD0
        public void RaiseStorageUsage(){} // RVA: 0x7FFD55204A20
        public void InternalRaiseDataUsage(){} // RVA: 0x7FFD55204B50
        public void Update(){} // RVA: 0x7FFD55205100
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7FFD55205110
        public void OnPlayerJoined(){} // RVA: 0x7FFD55205B20
        public void OnPlayerLeft(){} // RVA: 0x7FFD55206700
        public void OnBeforeInstanceClose(){} // RVA: 0x7FFD55206B10
        public void RestoreInstance(){} // RVA: 0x7FFD55206CB0
        public void HibernatePlayer(){} // RVA: 0x7FFD55206E00
        public void RestorePlayerPersistence(){} // RVA: 0x7FFD55207270
        public void RewriteBunchViewID(){} // RVA: 0x7FFD55207770
        public void DeleteStateForViewId(){} // RVA: 0x7FFD552078E0
        public void RecordBunch8(){} // RVA: 0x7FFD55207940
        public void RecordBunch32(){} // RVA: 0x7FFD55207990
        public void RecordBunch(){} // RVA: 0x7FFD55207A10
        public void CalculateMetadataSize(){} // RVA: 0x7FFD552080E0
        public void CountStateSize(){} // RVA: 0x7FFD55208110
        public void CollectPlayerPersistenceState(){} // RVA: 0x7FFD55208C10 | overloaded x2
        public void CollectInstancePersistenceState(){} // RVA: 0x7FFD55208DA0
        public void CollectState(){} // RVA: 0x7FFD55208F30
        public void ReadState(){} // RVA: 0x7FFD55209570
        public void ShouldNotPersistForAny(){} // RVA: 0x7FFD55209770
        public void AdaptPlayerViewId(){} // RVA: 0x7FFD552097A0
        public void PlayerPersistenceViewIDsForPlayer(){} // RVA: 0x7FFD552097B0
        public void IsPlayerPersistenceViewIDForPlayer(){} // RVA: 0x7FFD552098D0
        public void IsPlayerStorageID(){} // RVA: 0x7FFD55209970
        public void IsPlayerObjectID(){} // RVA: 0x7FFD552099D0
        public void IsSceneObjectID(){} // RVA: 0x7FFD55209A50
        public void InitBucketFilters(){} // RVA: 0x7FFD55209A60
        public void .cctor(){} // RVA: 0x7FFD55209EF0
        public void <CheckSizeWarnings>g__CollateUsage|58_0(){} // RVA: 0x7FFD5520A460
        public void <CheckSizeWarnings>g__RaiseWarningAndError|58_1(){} // RVA: 0x7FFD5520A5F0
        public void <TestAndRecordInstanceMetadata>b__62_0(){} // RVA: 0x7FFD5520AA90
        public void <RestoreInstance>g__onRestore|66_0(){} // RVA: 0x7FFD5520AAD0
        public void <RestoreInstance>g__restoreInstanceFrom|66_1(){} // RVA: 0x7FFD5520AB90
        public void <InitBucketFilters>b__98_0(){} // RVA: 0x7FFD5520B430
    }

    public class SimpleObjectStateManager : AbstractObjectStateManager
    {
        public System.Collections.Generic.Dictionary`2<int,0x66565AE0> ObjectStateSizeBytes; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5520E2F0
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7FFD5520E400
        public void Update(){} // RVA: 0x7FFD4E341310
        public void OnBeforeInstanceClose(){} // RVA: 0x7FFD4E341310
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7FFD4E341320
        public void RaiseStorageUsage(){} // RVA: 0x7FFD5520E620
        public void OnPlayerLeft(){} // RVA: 0x7FFD4E341310
        public void OnPlayerJoined(){} // RVA: 0x7FFD5520E660
        public void DeleteStateForViewId(){} // RVA: 0x7FFD5520EA70
        public void RecordBunch8(){} // RVA: 0x7FFD5520EAD0
        public void RecordBunch32(){} // RVA: 0x7FFD5520ED40
        public void WriteBunches(){} // RVA: 0x7FFD5520F010
        public void ReadBunches(){} // RVA: 0x7FFD5520F6B0
    }

}