// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Codec.StateManagement
// Classes: 3
// Methods: 89

namespace VRC.Core.Networking.Codec.StateManagement
{
    public class AbstractObjectStateManager
    {
        // ── Methods ──
        public void SerializationHeaderLength(){} // RVA: 0x764A510
        public void get_SerializationHeaderLengthSingleBunch(){} // RVA: 0x7354F30
        public void get_SerializationHeaderLengthMultiBunch(){} // RVA: 0x764A520
        public void get_MaximumViewID(){} // RVA: 0x32A5C0
        public void set_MaximumViewID(){} // RVA: 0x2E00C0
        public void get_MinimumViewID(){} // RVA: 0x8ABED0
        public void set_MinimumViewID(){} // RVA: 0x8AC660
        public void FlattenPlayerViewId(){} // RVA: 0x764A530
        public void get_ManagedPlayerViews(){} // RVA: 0x37E0E0
        public void SendEventToPlayer(){} // RVA: 0x764A540
        public void SendEventToAllPlayers(){} // RVA: 0x4EC5180
        public void SetOwner(){} // RVA: 0x72F1E20
        public void ListPlayers(){} // RVA: 0x764A560
        public void Log(){} // RVA: 0x72EE060
        public void Warn(){} // RVA: 0x4EEA9A0
        public void Error(){} // RVA: 0x764A5C0
        public void .ctor(){} // RVA: 0x764A5E0
        public void RaiseStorageUsage(){} // RVA: 0x24A50
        public void RecordBunch8(){}
        public void RecordBunch32(){}
        public void DeleteStateForViewId(){} // RVA: 0x24FA0
        public void OnPlayerLeft(){} // RVA: 0x24FA0
        public void OnPlayerJoined(){} // RVA: 0x24FA0
        public void get_ObjectStateSizeBytes(){} // RVA: 0xCD60
        public void OnBeforeInstanceClose(){} // RVA: 0x24A50
        public void TestAndRecordInstanceMetadata(){}
        public void Update(){} // RVA: 0x24A50
    }

    public class PersistenceObjectStateManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x764AC30
        public void InstanceStorageId(){} // RVA: 0x764B690
        public void PlayerStorageId(){} // RVA: 0x764B6B0
        public void WriteInstance(){} // RVA: 0x764B6D0
        public void ReadInstance(){} // RVA: 0x764B6F0
        public void WritePlayer(){} // RVA: 0x764B710
        public void ReadPlayer(){} // RVA: 0x764B740
        public void get_UseInstancePersistence(){} // RVA: 0x8A7360
        public void get_UsePlayerPersistence(){} // RVA: 0x764B770
        public void get_ObjectStateSizeBytes(){} // RVA: 0x764B820
        public void MetadataToBytes(){} // RVA: 0x764B8C0
        public void CheckSizeWarnings(){} // RVA: 0x764BB30
        public void RaiseStorageUsage(){} // RVA: 0x764C780
        public void InternalRaiseDataUsage(){} // RVA: 0x764C8B0
        public void Update(){} // RVA: 0x764CE60
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x764CE70
        public void OnPlayerJoined(){} // RVA: 0x764D880
        public void OnPlayerLeft(){} // RVA: 0x764E460
        public void OnBeforeInstanceClose(){} // RVA: 0x764E870
        public void RestoreInstance(){} // RVA: 0x764EA10
        public void HibernatePlayer(){} // RVA: 0x764EB60
        public void RestorePlayerPersistence(){} // RVA: 0x764EFD0
        public void RewriteBunchViewID(){} // RVA: 0x764F4D0
        public void DeleteStateForViewId(){} // RVA: 0x764F640
        public void RecordBunch8(){} // RVA: 0x764F6A0
        public void RecordBunch32(){} // RVA: 0x764F6F0
        public void RecordBunch(){} // RVA: 0x764F770
        public void CalculateMetadataSize(){} // RVA: 0x764FE40
        public void CountStateSize(){} // RVA: 0x764FE70
        public void CollectPlayerPersistenceState(){} // RVA: 0x7650970 | overloaded x2
        public void CollectInstancePersistenceState(){} // RVA: 0x7650B00
        public void CollectState(){} // RVA: 0x7650C90
        public void ReadState(){} // RVA: 0x76512D0
        public void ShouldNotPersistForAny(){} // RVA: 0x76514D0
        public void AdaptPlayerViewId(){} // RVA: 0x7651500
        public void PlayerPersistenceViewIDsForPlayer(){} // RVA: 0x7651510
        public void IsPlayerPersistenceViewIDForPlayer(){} // RVA: 0x7651630
        public void IsPlayerStorageID(){} // RVA: 0x76516D0
        public void IsPlayerObjectID(){} // RVA: 0x7651730
        public void IsSceneObjectID(){} // RVA: 0x76517B0
        public void InitBucketFilters(){} // RVA: 0x76517C0
        public void .cctor(){} // RVA: 0x7651C50
        public void <CheckSizeWarnings>g__CollateUsage|58_0(){} // RVA: 0x76521C0
        public void <CheckSizeWarnings>g__RaiseWarningAndError|58_1(){} // RVA: 0x7652350
        public void <TestAndRecordInstanceMetadata>b__62_0(){} // RVA: 0x76527F0
        public void <RestoreInstance>g__onRestore|66_0(){} // RVA: 0x7652830
        public void <RestoreInstance>g__restoreInstanceFrom|66_1(){} // RVA: 0x76528F0
        public void <InitBucketFilters>b__98_0(){} // RVA: 0x7653190
    }

    public class SimpleObjectStateManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7656050
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7656160
        public void Update(){} // RVA: 0x2DD310
        public void OnBeforeInstanceClose(){} // RVA: 0x2DD310
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x2DD320
        public void RaiseStorageUsage(){} // RVA: 0x7656380
        public void OnPlayerLeft(){} // RVA: 0x2DD310
        public void OnPlayerJoined(){} // RVA: 0x76563C0
        public void DeleteStateForViewId(){} // RVA: 0x76567D0
        public void RecordBunch8(){} // RVA: 0x7656830
        public void RecordBunch32(){} // RVA: 0x7656AA0
        public void WriteBunches(){} // RVA: 0x7656D70
        public void ReadBunches(){} // RVA: 0x7657410
    }

}