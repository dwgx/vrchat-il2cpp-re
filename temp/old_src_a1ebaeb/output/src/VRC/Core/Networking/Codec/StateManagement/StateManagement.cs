// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Codec.StateManagement
// Classes: 3
// Methods: 89

namespace VRC.Core.Networking.Codec.StateManagement
{
    public class AbstractObjectStateManager : Object
    {
        public object _sendEventToAllPlayers; // 0x334EB300
        public object _listPlayers; // 0x334EB300
        public object _error; // 0x334EB300

        // ── Original Methods ──
        public void SerializationHeaderLength(){} // RVA: 0x7ffaaf8051d0
        public void get_SerializationHeaderLengthSingleBunch(){} // RVA: 0x7ffaaf50e770
        public void get_SerializationHeaderLengthMultiBunch(){} // RVA: 0x7ffaaf8051e0
        public void get_MaximumViewID(){} // RVA: 0x7ffaa897f5c0
        public void set_MaximumViewID(){} // RVA: 0x7ffaa89350c0
        public void get_MinimumViewID(){} // RVA: 0x7ffaa8e046c0
        public void set_MinimumViewID(){} // RVA: 0x7ffaa8e03640
        public void FlattenPlayerViewId(){} // RVA: 0x7ffaaf8051f0
        public void get_ManagedPlayerViews(){} // RVA: 0x7ffaa89d30e0
        public void SendEventToPlayer(){} // RVA: 0x7ffaaf805200
        public void SendEventToAllPlayers(){} // RVA: 0x7ffaad0af8e0
        public void ListPlayers(){} // RVA: 0x7ffaaf805220
        public void Log(){} // RVA: 0x7ffaaf4a78a0
        public void Warn(){} // RVA: 0x7ffaad0b8810
        public void Error(){} // RVA: 0x7ffaaf805280
        public void .ctor(){} // RVA: 0x7ffaaf8052a0
        public void RaiseStorageUsage(){} // RVA: 0x7ffaa8660cc0
        public void RecordBunch8(){}
        public void RecordBunch32(){}
        public void DeleteStateForViewId(){} // RVA: 0x7ffaa8661210
        public void OnPlayerLeft(){} // RVA: 0x7ffaa8661210
        public void OnPlayerJoined(){} // RVA: 0x7ffaa8661210
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7ffaa86491d0
        public void OnBeforeInstanceClose(){} // RVA: 0x7ffaa8660cc0
        public void TestAndRecordInstanceMetadata(){}
        public void Update(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetOwner(){} // RVA: 0x7ffaaf4ab660
    }

    public class PersistenceObjectStateManager : AbstractObjectStateManager
    {
        public object _instanceStorageId; // 0x33B05280
        public object _enableInstancePersistence; // 0x33B05280
        public object _instancePersistenceRecoveredID; // 0x33B05280
        public object _maximumBunchSize; // 0x33B05280
        public object _writeInstance; // 0x33B05280
        public object _readPlayer; // 0x33B05280
        public object _activeMetadataSize; // 0x33B05280
        public object ActiveStateLookup; // 0x33B05280
        public object PlayerPersistenceViewIDs; // 0x33B05280
        public object raiseSizeRequested; // 0x33B05280
        public object INSTANCE_OBJECTS_BUCKET; // 0x33B05280
        public object DeHashBuckets; // 0x33B05280
        public object h; // 0x822E68A0
        public object h; // 0x822E7620
        public object h; // 0x8234C3F0
        public object h; // 0x8234CCF0
        public object h; // 0x8234D5F0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf8058f0
        public void InstanceStorageId(){} // RVA: 0x7ffaaf806350
        public void PlayerStorageId(){} // RVA: 0x7ffaaf806370
        public void WriteInstance(){} // RVA: 0x7ffaaf806390
        public void ReadInstance(){} // RVA: 0x7ffaaf8063b0
        public void WritePlayer(){} // RVA: 0x7ffaaf8063d0
        public void ReadPlayer(){} // RVA: 0x7ffaaf806400
        public void get_UseInstancePersistence(){} // RVA: 0x7ffaa8dfe0d0
        public void get_UsePlayerPersistence(){} // RVA: 0x7ffaaf806430
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7ffaaf8064e0
        public void MetadataToBytes(){} // RVA: 0x7ffaaf806580
        public void RaiseStorageUsage(){} // RVA: 0x7ffaaf807440
        public void InternalRaiseDataUsage(){} // RVA: 0x7ffaaf807570
        public void Update(){} // RVA: 0x7ffaaf807b20
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7ffaaf807b30
        public void OnPlayerJoined(){} // RVA: 0x7ffaaf808540
        public void OnPlayerLeft(){} // RVA: 0x7ffaaf809120
        public void OnBeforeInstanceClose(){} // RVA: 0x7ffaaf809530
        public void RestoreInstance(){} // RVA: 0x7ffaaf8096d0
        public void HibernatePlayer(){} // RVA: 0x7ffaaf809820
        public void RestorePlayerPersistence(){} // RVA: 0x7ffaaf809c90
        public void RewriteBunchViewID(){} // RVA: 0x7ffaaf80a190
        public void DeleteStateForViewId(){} // RVA: 0x7ffaaf80a300
        public void RecordBunch8(){} // RVA: 0x7ffaaf80a360
        public void RecordBunch32(){} // RVA: 0x7ffaaf80a3b0
        public void RecordBunch(){} // RVA: 0x7ffaaf80a430
        public void CalculateMetadataSize(){} // RVA: 0x7ffaaf80ab00
        public void CountStateSize(){} // RVA: 0x7ffaaf80ab30
        public void CollectPlayerPersistenceState(){} // RVA: 0x7ffaaf80b630
        public void CollectPlayerPersistenceState(){} // RVA: 0x7ffaaf80b630
        public void CollectInstancePersistenceState(){} // RVA: 0x7ffaaf80b7c0
        public void CollectState(){} // RVA: 0x7ffaaf80b950
        public void ReadState(){} // RVA: 0x7ffaaf80bf90
        public void ShouldNotPersistForAny(){} // RVA: 0x7ffaaf80c190
        public void AdaptPlayerViewId(){} // RVA: 0x7ffaaf80c1c0
        public void PlayerPersistenceViewIDsForPlayer(){} // RVA: 0x7ffaaf80c1d0
        public void IsPlayerPersistenceViewIDForPlayer(){} // RVA: 0x7ffaaf80c2f0
        public void IsPlayerStorageID(){} // RVA: 0x7ffaaf80c390
        public void IsPlayerObjectID(){} // RVA: 0x7ffaaf80c3f0
        public void IsSceneObjectID(){} // RVA: 0x7ffaaf80c470
        public void InitBucketFilters(){} // RVA: 0x7ffaaf80c480
        public void .cctor(){} // RVA: 0x7ffaaf80c910
        public void <CheckSizeWarnings>g__CollateUsage|58_0(){} // RVA: 0x7ffaaf80ce80
        public void <CheckSizeWarnings>g__RaiseWarningAndError|58_1(){} // RVA: 0x7ffaaf80d010
        public void <TestAndRecordInstanceMetadata>b__62_0(){} // RVA: 0x7ffaaf80d4b0
        public void <RestoreInstance>g__onRestore|66_0(){} // RVA: 0x7ffaaf80d4f0
        public void <RestoreInstance>g__restoreInstanceFrom|66_1(){} // RVA: 0x7ffaaf80d5b0
        public void <InitBucketFilters>b__98_0(){} // RVA: 0x7ffaaf80de50
        // ── Binary Analysis Named ──
        public void CheckSizeWarnings(){} // RVA: 0x7ffaaf8067f0
    }

    public class SimpleObjectStateManager : AbstractObjectStateManager
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf810d10
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7ffaaf810e20
        public void Update(){} // RVA: 0x7ffaa8932310
        public void OnBeforeInstanceClose(){} // RVA: 0x7ffaa8932310
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7ffaa8932320
        public void RaiseStorageUsage(){} // RVA: 0x7ffaaf811040
        public void OnPlayerLeft(){} // RVA: 0x7ffaa8932310
        public void OnPlayerJoined(){} // RVA: 0x7ffaaf811080
        public void DeleteStateForViewId(){} // RVA: 0x7ffaaf811490
        public void RecordBunch8(){} // RVA: 0x7ffaaf8114f0
        public void RecordBunch32(){} // RVA: 0x7ffaaf811760
        public void WriteBunches(){} // RVA: 0x7ffaaf811a30
        public void ReadBunches(){} // RVA: 0x7ffaaf8120d0
    }

}