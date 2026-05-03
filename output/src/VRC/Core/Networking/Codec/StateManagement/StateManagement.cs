// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Codec.StateManagement
// Classes: 3
// Methods: 89

namespace VRC.Core.Networking.Codec.StateManagement
{
    public class AbstractObjectStateManager : Object
    {
        public int _maximumViewID; // 0x10
        public int _minimumViewID; // 0x14
        public SendEventToAllPlayersDelegate _sendEventToAllPlayers; // 0x18
        public SendEventToPlayerDelegate _sendEventToPlayer; // 0x20
        public SetOwnerDelegate _setOwner; // 0x28
        public ListPlayersDelegate _listPlayers; // 0x30

        // ── Methods ──
        public void SerializationHeaderLength(){} // RVA: 0x7FFE88187560
        public void get_SerializationHeaderLengthSingleBunch(){} // RVA: 0x7FFE87E950B0
        public void get_SerializationHeaderLengthMultiBunch(){} // RVA: 0x7FFE88187570
        public void get_MaximumViewID(){} // RVA: 0x7FFE811485C0
        public void set_MaximumViewID(){} // RVA: 0x7FFE810FE0C0
        public void get_MinimumViewID(){} // RVA: 0x7FFE8164B230
        public void set_MinimumViewID(){} // RVA: 0x7FFE8164E0F0
        public void FlattenPlayerViewId(){} // RVA: 0x7FFE88187580
        public void get_ManagedPlayerViews(){} // RVA: 0x7FFE8119C0E0
        public void SendEventToPlayer(){} // RVA: 0x7FFE88187590
        public void SendEventToAllPlayers(){} // RVA: 0x7FFE85A88580
        public void SetOwner(){} // RVA: 0x7FFE87E31FA0
        public void ListPlayers(){} // RVA: 0x7FFE881875B0
        public void Log(){} // RVA: 0x7FFE87E2E1E0
        public void Warn(){} // RVA: 0x7FFE85C283E0
        public void Error(){} // RVA: 0x7FFE88187610
        public void .ctor(){} // RVA: 0x7FFE88187630
        public void RaiseStorageUsage(){} // RVA: 0x7FFE80E45FE0
        public void RecordBunch8(){}
        public void RecordBunch32(){}
        public void DeleteStateForViewId(){} // RVA: 0x7FFE80E46530
        public void OnPlayerLeft(){} // RVA: 0x7FFE80E46530
        public void OnPlayerJoined(){} // RVA: 0x7FFE80E46530
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7FFE80E2E2E0
        public void OnBeforeInstanceClose(){} // RVA: 0x7FFE80E45FE0
        public void TestAndRecordInstanceMetadata(){}
        public void Update(){} // RVA: 0x7FFE80E45FE0
    }

    public class PersistenceObjectStateManager : AbstractObjectStateManager
    {
        public OnDecodeError _onDecodeError; // 0x58
        public GetBucketLimitsDelegate _getBucketLimits; // 0x60
        public InstanceStorageIdDelegate _instanceStorageId; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88187C80
        public void InstanceStorageId(){} // RVA: 0x7FFE881886E0
        public void PlayerStorageId(){} // RVA: 0x7FFE88188700
        public void WriteInstance(){} // RVA: 0x7FFE88188720
        public void ReadInstance(){} // RVA: 0x7FFE88188740
        public void WritePlayer(){} // RVA: 0x7FFE88188760
        public void ReadPlayer(){} // RVA: 0x7FFE88188790
        public void get_UseInstancePersistence(){} // RVA: 0x7FFE81647650
        public void get_UsePlayerPersistence(){} // RVA: 0x7FFE881887C0
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7FFE88188870
        public void MetadataToBytes(){} // RVA: 0x7FFE88188910
        public void CheckSizeWarnings(){} // RVA: 0x7FFE88188B80
        public void RaiseStorageUsage(){} // RVA: 0x7FFE881897D0
        public void InternalRaiseDataUsage(){} // RVA: 0x7FFE88189900
        public void Update(){} // RVA: 0x7FFE88189EB0
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7FFE88189EC0
        public void OnPlayerJoined(){} // RVA: 0x7FFE8818A8D0
        public void OnPlayerLeft(){} // RVA: 0x7FFE8818B4B0
        public void OnBeforeInstanceClose(){} // RVA: 0x7FFE8818B8C0
        public void RestoreInstance(){} // RVA: 0x7FFE8818BA60
        public void HibernatePlayer(){} // RVA: 0x7FFE8818BBB0
        public void RestorePlayerPersistence(){} // RVA: 0x7FFE8818C020
        public void RewriteBunchViewID(){} // RVA: 0x7FFE8818C520
        public void DeleteStateForViewId(){} // RVA: 0x7FFE8818C690
        public void RecordBunch8(){} // RVA: 0x7FFE8818C6F0
        public void RecordBunch32(){} // RVA: 0x7FFE8818C740
        public void RecordBunch(){} // RVA: 0x7FFE8818C7C0
        public void CalculateMetadataSize(){} // RVA: 0x7FFE8818CE90
        public void CountStateSize(){} // RVA: 0x7FFE8818CEC0
        public void CollectPlayerPersistenceState(){} // RVA: 0x7FFE8818D9C0 | overloaded x2
        public void CollectInstancePersistenceState(){} // RVA: 0x7FFE8818DB50
        public void CollectState(){} // RVA: 0x7FFE8818DCE0
        public void ReadState(){} // RVA: 0x7FFE8818E320
        public void ShouldNotPersistForAny(){} // RVA: 0x7FFE8818E520
        public void AdaptPlayerViewId(){} // RVA: 0x7FFE8818E550
        public void PlayerPersistenceViewIDsForPlayer(){} // RVA: 0x7FFE8818E560
        public void IsPlayerPersistenceViewIDForPlayer(){} // RVA: 0x7FFE8818E680
        public void IsPlayerStorageID(){} // RVA: 0x7FFE8818E720
        public void IsPlayerObjectID(){} // RVA: 0x7FFE8818E780
        public void IsSceneObjectID(){} // RVA: 0x7FFE8818E800
        public void InitBucketFilters(){} // RVA: 0x7FFE8818E810
        public void .cctor(){} // RVA: 0x7FFE8818ECA0
        public void <CheckSizeWarnings>g__CollateUsage|58_0(){} // RVA: 0x7FFE8818F210
        public void <CheckSizeWarnings>g__RaiseWarningAndError|58_1(){} // RVA: 0x7FFE8818F3A0
        public void <TestAndRecordInstanceMetadata>b__62_0(){} // RVA: 0x7FFE8818F840
        public void <RestoreInstance>g__onRestore|66_0(){} // RVA: 0x7FFE8818F880
        public void <RestoreInstance>g__restoreInstanceFrom|66_1(){} // RVA: 0x7FFE8818F940
        public void <InitBucketFilters>b__98_0(){} // RVA: 0x7FFE881901E0
    }

    public class SimpleObjectStateManager : AbstractObjectStateManager
    {
        public System.Collections.Generic.Dictionary`2<int,BunchesInformation> latestBunches; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881930A0
        public void get_ObjectStateSizeBytes(){} // RVA: 0x7FFE881931B0
        public void Update(){} // RVA: 0x7FFE810FB310
        public void OnBeforeInstanceClose(){} // RVA: 0x7FFE810FB310
        public void TestAndRecordInstanceMetadata(){} // RVA: 0x7FFE810FB320
        public void RaiseStorageUsage(){} // RVA: 0x7FFE881933D0
        public void OnPlayerLeft(){} // RVA: 0x7FFE810FB310
        public void OnPlayerJoined(){} // RVA: 0x7FFE88193410
        public void DeleteStateForViewId(){} // RVA: 0x7FFE88193820
        public void RecordBunch8(){} // RVA: 0x7FFE88193880
        public void RecordBunch32(){} // RVA: 0x7FFE88193AF0
        public void WriteBunches(){} // RVA: 0x7FFE88193DC0
        public void ReadBunches(){} // RVA: 0x7FFE88194460
    }

}