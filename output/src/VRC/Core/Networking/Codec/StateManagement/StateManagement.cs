// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Codec.StateManagement
// Classes: 3
// Methods: 89

namespace VRC.Core.Networking.Codec.StateManagement
{
    public class AbstractObjectStateManager
    {
        // ── Methods ──
        public void SerializationHeaderLength(){} // RVA: 0x7FFAFA0FA510
        public void get_SerializationHeaderLengthSingleBunch(){} // RVA: 0x7FFAF9E04F30
        public void get_SerializationHeaderLengthMultiBunch(){} // RVA: 0x7FFAFA0FA520
        public void get_MaximumViewID(){} // RVA: 0x7FFAF2DDA5C0
        public void set_MaximumViewID(){} // RVA: 0x7FFAF2D900C0
        public void get_MinimumViewID(){} // RVA: 0x7FFAF335BED0
        public void set_MinimumViewID(){} // RVA: 0x7FFAF335C660
        public void FlattenPlayerViewId(){} // RVA: 0x7FFAFA0FA530
        public void get_ManagedPlayerViews(){} // RVA: 0x7FFAF2E2E0E0
        public void SendEventToPlayer(){} // RVA: 0x7FFAFA0FA540
        public void SendEventToAllPlayers(){} // RVA: 0x7FFAF7975180
        public void SetOwner(){} // RVA: 0x7FFAF9DA1E20
        public void ListPlayers(){} // RVA: 0x7FFAFA0FA560
        public void Log(){} // RVA: 0x7FFAF9D9E060
        public void Warn(){} // RVA: 0x7FFAF799A9A0
        public void Error(){} // RVA: 0x7FFAFA0FA5C0
        public void .ctor(){} // RVA: 0x7FFAFA0FA5E0
        public void RaiseStorageUsage(){} // RVA: 0x7FFAF2AD4A50
        public void RecordBunch8(){}
        public void RecordBunch32(){}
        public void DeleteStateForViewId(){} // RVA: 0x7FFAF2AD4FA0
        public void OnPlayerLeft(){} // RVA: 0x7FFAF2AD4FA0
        public void OnPlayerJoined(){} // RVA: 0x7FFAF2AD4FA0
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7FFAF2ABCD60
        public void OnBeforeInstanceClose(){} // RVA: 0x7FFAF2AD4A50
        public void TestAndRecordInstanceMetadata(){}
        public void Update(){} // RVA: 0x7FFAF2AD4A50
    }

    public class PersistenceObjectStateManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA0FAC30
        public void InstanceStorageId(){} // RVA: 0x7FFAFA0FB690
        public void PlayerStorageId(){} // RVA: 0x7FFAFA0FB6B0
        public void WriteInstance(){} // RVA: 0x7FFAFA0FB6D0
        public void ReadInstance(){} // RVA: 0x7FFAFA0FB6F0
        public void WritePlayer(){} // RVA: 0x7FFAFA0FB710
        public void ReadPlayer(){} // RVA: 0x7FFAFA0FB740
        public void get_UseInstancePersistence(){} // RVA: 0x7FFAF3357360
        public void get_UsePlayerPersistence(){} // RVA: 0x7FFAFA0FB770
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7FFAFA0FB820
        public void MetadataToBytes(){} // RVA: 0x7FFAFA0FB8C0
        public void CheckSizeWarnings(){} // RVA: 0x7FFAFA0FBB30
        public void RaiseStorageUsage(){} // RVA: 0x7FFAFA0FC780
        public void InternalRaiseDataUsage(){} // RVA: 0x7FFAFA0FC8B0
        public void Update(){} // RVA: 0x7FFAFA0FCE60
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7FFAFA0FCE70
        public void OnPlayerJoined(){} // RVA: 0x7FFAFA0FD880
        public void OnPlayerLeft(){} // RVA: 0x7FFAFA0FE460
        public void OnBeforeInstanceClose(){} // RVA: 0x7FFAFA0FE870
        public void RestoreInstance(){} // RVA: 0x7FFAFA0FEA10
        public void HibernatePlayer(){} // RVA: 0x7FFAFA0FEB60
        public void RestorePlayerPersistence(){} // RVA: 0x7FFAFA0FEFD0
        public void RewriteBunchViewID(){} // RVA: 0x7FFAFA0FF4D0
        public void DeleteStateForViewId(){} // RVA: 0x7FFAFA0FF640
        public void RecordBunch8(){} // RVA: 0x7FFAFA0FF6A0
        public void RecordBunch32(){} // RVA: 0x7FFAFA0FF6F0
        public void RecordBunch(){} // RVA: 0x7FFAFA0FF770
        public void CalculateMetadataSize(){} // RVA: 0x7FFAFA0FFE40
        public void CountStateSize(){} // RVA: 0x7FFAFA0FFE70
        public void CollectPlayerPersistenceState(){} // RVA: 0x7FFAFA100970 | overloaded x2
        public void CollectInstancePersistenceState(){} // RVA: 0x7FFAFA100B00
        public void CollectState(){} // RVA: 0x7FFAFA100C90
        public void ReadState(){} // RVA: 0x7FFAFA1012D0
        public void ShouldNotPersistForAny(){} // RVA: 0x7FFAFA1014D0
        public void AdaptPlayerViewId(){} // RVA: 0x7FFAFA101500
        public void PlayerPersistenceViewIDsForPlayer(){} // RVA: 0x7FFAFA101510
        public void IsPlayerPersistenceViewIDForPlayer(){} // RVA: 0x7FFAFA101630
        public void IsPlayerStorageID(){} // RVA: 0x7FFAFA1016D0
        public void IsPlayerObjectID(){} // RVA: 0x7FFAFA101730
        public void IsSceneObjectID(){} // RVA: 0x7FFAFA1017B0
        public void InitBucketFilters(){} // RVA: 0x7FFAFA1017C0
        public void .cctor(){} // RVA: 0x7FFAFA101C50
        public void <CheckSizeWarnings>g__CollateUsage|58_0(){} // RVA: 0x7FFAFA1021C0
        public void <CheckSizeWarnings>g__RaiseWarningAndError|58_1(){} // RVA: 0x7FFAFA102350
        public void <TestAndRecordInstanceMetadata>b__62_0(){} // RVA: 0x7FFAFA1027F0
        public void <RestoreInstance>g__onRestore|66_0(){} // RVA: 0x7FFAFA102830
        public void <RestoreInstance>g__restoreInstanceFrom|66_1(){} // RVA: 0x7FFAFA1028F0
        public void <InitBucketFilters>b__98_0(){} // RVA: 0x7FFAFA103190
    }

    public class SimpleObjectStateManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA106050
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7FFAFA106160
        public void Update(){} // RVA: 0x7FFAF2D8D310
        public void OnBeforeInstanceClose(){} // RVA: 0x7FFAF2D8D310
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7FFAF2D8D320
        public void RaiseStorageUsage(){} // RVA: 0x7FFAFA106380
        public void OnPlayerLeft(){} // RVA: 0x7FFAF2D8D310
        public void OnPlayerJoined(){} // RVA: 0x7FFAFA1063C0
        public void DeleteStateForViewId(){} // RVA: 0x7FFAFA1067D0
        public void RecordBunch8(){} // RVA: 0x7FFAFA106830
        public void RecordBunch32(){} // RVA: 0x7FFAFA106AA0
        public void WriteBunches(){} // RVA: 0x7FFAFA106D70
        public void ReadBunches(){} // RVA: 0x7FFAFA107410
    }

}