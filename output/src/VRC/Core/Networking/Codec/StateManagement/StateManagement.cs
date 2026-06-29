// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Codec.StateManagement
// Classes: 3
// Methods: 91

namespace VRC.Core.Networking.Codec.StateManagement
{
    public class AbstractObjectStateManager : Object
    {
        // ── Methods ──
        public void SerializationHeaderLength(){} // RVA: 0x7AF429410
        public void get_SerializationHeaderLengthSingleBunch(){} // RVA: 0x7AF1351D0
        public void get_SerializationHeaderLengthMultiBunch(){} // RVA: 0x7AF429420
        public void get_MaximumViewID(){} // RVA: 0x7A8124910
        public void set_MaximumViewID(){} // RVA: 0x7A80DA0C0
        public void get_MinimumViewID(){} // RVA: 0x7A8668BC0
        public void set_MinimumViewID(){} // RVA: 0x7A8669360
        public void FlattenPlayerViewId(){} // RVA: 0x7AF429430
        public void get_ManagedPlayerViews(){} // RVA: 0x7A8178B90
        public void SendEventToPlayer(){} // RVA: 0x7AF429440
        public void SendEventToAllPlayers(){} // RVA: 0x7ACD587F0
        public void SetOwner(){} // RVA: 0x7AF0D1FD0
        public void ListPlayers(){} // RVA: 0x7AF429460
        public void Log(){} // RVA: 0x7AF0CE230
        public void Warn(){} // RVA: 0x7ACDEF340
        public void Error(){} // RVA: 0x7AF4294C0
        public void .ctor(){} // RVA: 0x7AF4294E0
        public void RaiseStorageUsage(){} // RVA: 0x7A7E18770
        public void RecordBunch8(){} // RVA: 0x7A7E194E0
        public void RecordBunch32(){} // RVA: 0x7A7E194E0
        public void DeleteStateForViewId(){} // RVA: 0x7A7E189D0
        public void OnPlayerLeft(){} // RVA: 0x7A7E189D0
        public void OnPlayerJoined(){} // RVA: 0x7A7E189D0
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7A7E00680
        public void OnBeforeInstanceClose(){} // RVA: 0x7A7E18770
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7A7E030C0
        public void Update(){} // RVA: 0x7A7E18770
        public void <MaximumViewID>k__BackingField(){} // RVA: 0x7B3FB4428
    }

    public class PersistenceObjectStateManager : AbstractObjectStateManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF429B30
        public void InstanceStorageId(){} // RVA: 0x7AF42A590
        public void PlayerStorageId(){} // RVA: 0x7AF42A5B0
        public void WriteInstance(){} // RVA: 0x7AF42A5D0
        public void ReadInstance(){} // RVA: 0x7AF42A5F0
        public void WritePlayer(){} // RVA: 0x7AF42A610
        public void ReadPlayer(){} // RVA: 0x7AF42A640
        public void get_UseInstancePersistence(){} // RVA: 0x7A8663F60
        public void get_UsePlayerPersistence(){} // RVA: 0x7AF42A670
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7AF42A720
        public void MetadataToBytes(){} // RVA: 0x7AF42A7C0
        public void CheckSizeWarnings(){} // RVA: 0x7AF42A9F0
        public void RaiseStorageUsage(){} // RVA: 0x7AF42B5E0
        public void InternalRaiseDataUsage(){} // RVA: 0x7AF42B6E0
        public void Update(){} // RVA: 0x7AF42BC90
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7AF42BCA0
        public void OnPlayerJoined(){} // RVA: 0x7AF42C6B0
        public void OnPlayerLeft(){} // RVA: 0x7AF42D290
        public void OnBeforeInstanceClose(){} // RVA: 0x7AF42D5C0
        public void RestoreInstance(){} // RVA: 0x7AF42D760
        public void HibernatePlayer(){} // RVA: 0x7AF42D8B0
        public void RestorePlayerPersistence(){} // RVA: 0x7AF42DD30
        public void RewriteBunchViewID(){} // RVA: 0x7AF42E230
        public void DeleteStateForViewId(){} // RVA: 0x7AF42E3A0
        public void RecordBunch8(){} // RVA: 0x7AF42E400
        public void RecordBunch32(){} // RVA: 0x7AF42E450
        public void RecordBunch(){} // RVA: 0x7AF42E4D0
        public void CalculateMetadataSize(){} // RVA: 0x7AF42EBA0
        public void CountStateSize(){} // RVA: 0x7AF42EBD0
        public void CollectPlayerPersistenceState(){} // RVA: 0x7AF42F6F0
        public void CollectInstancePersistenceState(){} // RVA: 0x7AF42F880
        public void CollectState(){} // RVA: 0x7AF42FA10
        public void ReadState(){} // RVA: 0x7AF430060
        public void ShouldNotPersistForAny(){} // RVA: 0x7AF430260
        public void AdaptPlayerViewId(){} // RVA: 0x7AF430290
        public void PlayerPersistenceViewIDsForPlayer(){} // RVA: 0x7AF4302A0
        public void IsPlayerPersistenceViewIDForPlayer(){} // RVA: 0x7AF4303C0
        public void IsPlayerStorageID(){} // RVA: 0x7AF430460
        public void IsPlayerObjectID(){} // RVA: 0x7AF4304C0
        public void IsSceneObjectID(){} // RVA: 0x7AF430540
        public void InitBucketFilters(){} // RVA: 0x7AF430550
        public void .cctor(){} // RVA: 0x7AF4309F0
        public void <CheckSizeWarnings>g__CollateUsage|58_0(){} // RVA: 0x7AF430F60
        public void <CheckSizeWarnings>g__RaiseWarningAndError|58_1(){} // RVA: 0x7AF4310F0
        public void <TestAndRecordInstanceMetadata>b__62_0(){} // RVA: 0x7AF431580
        public void <RestoreInstance>g__onRestore|66_0(){} // RVA: 0x7AF4315C0
        public void <RestoreInstance>g__restoreInstanceFrom|66_1(){} // RVA: 0x7AF431680
        public void <InitBucketFilters>b__98_0(){} // RVA: 0x7AF431F30
        public void _onDecodeError(){} // RVA: 0x7B3FB4328
    }

    public class SimpleObjectStateManager : AbstractObjectStateManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF434E30
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7AF434F40
        public void Update(){} // RVA: 0x7A80D7310
        public void OnBeforeInstanceClose(){} // RVA: 0x7A80D7310
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7A80D7320
        public void RaiseStorageUsage(){} // RVA: 0x7AF435150
        public void OnPlayerLeft(){} // RVA: 0x7A80D7310
        public void OnPlayerJoined(){} // RVA: 0x7AF435190
        public void DeleteStateForViewId(){} // RVA: 0x7AF4355B0
        public void RecordBunch8(){} // RVA: 0x7AF435610
        public void RecordBunch32(){} // RVA: 0x7AF435880
        public void WriteBunches(){} // RVA: 0x7AF435B50
        public void ReadBunches(){} // RVA: 0x7AF4361F0
        public void latestBunches(){} // RVA: 0x7B41DB578
    }

}