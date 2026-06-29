// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Codec.StateManagement
// Classes: 3
// Methods: 88

namespace VRC.Core.Networking.Codec.StateManagement
{
    public class AbstractObjectStateManager : Object
    {
        // ── Methods ──
        public void SerializationHeaderLength(){} // RVA: 0x8284110
        public void get_SerializationHeaderLengthSingleBunch(){} // RVA: 0x7F7BDC0
        public void get_SerializationHeaderLengthMultiBunch(){} // RVA: 0x8284120
        public void get_MaximumViewID(){} // RVA: 0xB8F8F0
        public void set_MaximumViewID(){} // RVA: 0xB460A0
        public void get_MinimumViewID(){} // RVA: 0x116A650
        public void set_MinimumViewID(){} // RVA: 0x116BB10
        public void FlattenPlayerViewId(){} // RVA: 0x8284130
        public void get_ManagedPlayerViews(){} // RVA: 0xBE58B0
        public void SendEventToPlayer(){} // RVA: 0x8284140
        public void SendEventToAllPlayers(){} // RVA: 0x59516C0
        public void SetOwner(){} // RVA: 0x7E88CB0
        public void ListPlayers(){} // RVA: 0x8284160
        public void Log(){} // RVA: 0x7E836F0
        public void Warn(){} // RVA: 0x5A630D0
        public void Error(){} // RVA: 0x8004CA0
        public void .ctor(){} // RVA: 0x82841C0
        public void RaiseStorageUsage(){} // RVA: 0x894290
        public void RecordBunch8(){} // RVA: 0x894FC0
        public void RecordBunch32(){} // RVA: 0x894FC0
        public void DeleteStateForViewId(){} // RVA: 0x8944F0
        public void OnPlayerLeft(){} // RVA: 0x8944F0
        public void OnPlayerJoined(){} // RVA: 0x8944F0
        public void get_ObjectStateSizeBytes(){} // RVA: 0x87C0A0
        public void OnBeforeInstanceClose(){} // RVA: 0x894290
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x87EA40
        public void Update(){} // RVA: 0x894290
    }

    public class PersistenceObjectStateManager : AbstractObjectStateManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x82847A0
        public void InstanceStorageId(){} // RVA: 0x82851F0
        public void PlayerStorageId(){} // RVA: 0x8285210
        public void WriteInstance(){} // RVA: 0x8285230
        public void ReadInstance(){} // RVA: 0x8285250
        public void WritePlayer(){} // RVA: 0x8285270
        public void ReadPlayer(){} // RVA: 0x82852A0
        public void get_UseInstancePersistence(){} // RVA: 0x1165720
        public void get_UsePlayerPersistence(){} // RVA: 0x82852D0
        public void get_ObjectStateSizeBytes(){} // RVA: 0x8285380
        public void MetadataToBytes(){} // RVA: 0x8285420
        public void CheckSizeWarnings(){} // RVA: 0x8285650
        public void RaiseStorageUsage(){} // RVA: 0x8286230
        public void InternalRaiseDataUsage(){} // RVA: 0x8286330
        public void Update(){} // RVA: 0x82868E0
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x82868F0
        public void OnPlayerJoined(){} // RVA: 0x82872F0
        public void OnPlayerLeft(){} // RVA: 0x8287EC0
        public void OnBeforeInstanceClose(){} // RVA: 0x82881F0
        public void RestoreInstance(){} // RVA: 0x8288380
        public void HibernatePlayer(){} // RVA: 0x82884D0
        public void RestorePlayerPersistence(){} // RVA: 0x8288940
        public void RewriteBunchViewID(){} // RVA: 0x8288E30
        public void DeleteStateForViewId(){} // RVA: 0x8288FA0
        public void RecordBunch8(){} // RVA: 0x8289000
        public void RecordBunch32(){} // RVA: 0x8289050
        public void RecordBunch(){} // RVA: 0x82890D0
        public void CalculateMetadataSize(){} // RVA: 0x82897A0
        public void CountStateSize(){} // RVA: 0x82897D0
        public void CollectPlayerPersistenceState(){} // RVA: 0x828A2F0
        public void CollectInstancePersistenceState(){} // RVA: 0x828A480
        public void CollectState(){} // RVA: 0x828A610
        public void ReadState(){} // RVA: 0x828AC60
        public void ShouldNotPersistForAny(){} // RVA: 0x828AE60
        public void AdaptPlayerViewId(){} // RVA: 0x828AE90
        public void PlayerPersistenceViewIDsForPlayer(){} // RVA: 0x828AEA0
        public void IsPlayerPersistenceViewIDForPlayer(){} // RVA: 0x828AFC0
        public void IsPlayerStorageID(){} // RVA: 0x828B060
        public void IsPlayerObjectID(){} // RVA: 0x828B0C0
        public void IsSceneObjectID(){} // RVA: 0x828B140
        public void InitBucketFilters(){} // RVA: 0x828B150
        public void .cctor(){} // RVA: 0x828B5F0
        public void <CheckSizeWarnings>g__CollateUsage|58_0(){} // RVA: 0x828BB60
        public void <CheckSizeWarnings>g__RaiseWarningAndError|58_1(){} // RVA: 0x828BCF0
        public void <TestAndRecordInstanceMetadata>b__62_0(){} // RVA: 0x828C180
        public void <RestoreInstance>g__onRestore|66_0(){} // RVA: 0x828C1C0
        public void <RestoreInstance>g__restoreInstanceFrom|66_1(){} // RVA: 0x828C280
        public void <InitBucketFilters>b__98_0(){} // RVA: 0x828CB20
    }

    public class SimpleObjectStateManager : AbstractObjectStateManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x828F750
        public void get_ObjectStateSizeBytes(){} // RVA: 0x828F860
        public void Update(){} // RVA: 0xB43310
        public void OnBeforeInstanceClose(){} // RVA: 0xB43310
        public void TestAndRecordInstanceMetadata(){} // RVA: 0xB43320
        public void RaiseStorageUsage(){} // RVA: 0x828FA70
        public void OnPlayerLeft(){} // RVA: 0xB43310
        public void OnPlayerJoined(){} // RVA: 0x828FAB0
        public void DeleteStateForViewId(){} // RVA: 0x828FED0
        public void RecordBunch8(){} // RVA: 0x828FF30
        public void RecordBunch32(){} // RVA: 0x82901A0
        public void WriteBunches(){} // RVA: 0x8290470
        public void ReadBunches(){} // RVA: 0x8290B10
    }

}