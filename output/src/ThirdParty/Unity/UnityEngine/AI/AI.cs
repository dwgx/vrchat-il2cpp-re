// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.AI
// Classes: 19
// Methods: 483

namespace ThirdParty.Unity.UnityEngine.AI
{
    public class NavMesh : Object
    {
        public object onPreUpdate;

        // ── Methods ──
        public void ClearPreUpdateListeners(){} // RVA: 0x7AE4F60
        public void Internal_CallOnNavMeshPreUpdate(){} // RVA: 0x7AE5000
        public void Raycast(){} // RVA: 0x7AE6550
        public void CalculatePath(){} // RVA: 0x7AE6680
        public void CalculatePathInternal(){} // RVA: 0x7AE51A0
        public void FindClosestEdge(){} // RVA: 0x7AE6440
        public void SamplePosition(){} // RVA: 0x7AE6310
        public void SetAreaCost(){} // RVA: 0x7AE5320
        public void GetAreaCost(){} // RVA: 0x7AE5380
        public void GetAreaFromName(){} // RVA: 0x7AE53D0
        public void GetAreaNames(){} // RVA: 0x7AE5510
        public void CalculateTriangulation(){} // RVA: 0x7AE5560
        public void get_avoidancePredictionTime(){} // RVA: 0x7AE55C0
        public void set_avoidancePredictionTime(){} // RVA: 0x7AE5610
        public void AddNavMeshData(){} // RVA: 0x7AE5800
        public void RemoveNavMeshData(){} // RVA: 0x7AE59D0
        public void IsValidNavMeshDataHandle(){} // RVA: 0x7AE5A20
        public void IsValidLinkHandle(){} // RVA: 0x7AE5A70
        public void InternalGetOwner(){} // RVA: 0x7AE5AC0
        public void InternalSetOwner(){} // RVA: 0x7AE5B40
        public void InternalGetLinkOwner(){} // RVA: 0x7AE5BA0
        public void InternalSetLinkOwner(){} // RVA: 0x7AE5C20
        public void AddNavMeshDataInternal(){} // RVA: 0x7AE5C80
        public void AddNavMeshDataTransformedInternal(){} // RVA: 0x7AE5D10
        public void RemoveNavMeshDataInternal(){} // RVA: 0x7AE59D0
        public void AddLink(){} // RVA: 0x7AE5EE0
        public void RemoveLink(){} // RVA: 0x7AE5F80
        public void IsLinkActive(){} // RVA: 0x7AE5FD0
        public void SetLinkActive(){} // RVA: 0x7AE6020
        public void IsLinkOccupied(){} // RVA: 0x7AE6080
        public void IsLinkValid(){} // RVA: 0x7AE5A70
        public void GetLinkOwner(){} // RVA: 0x7AE5BA0
        public void SetLinkOwner(){} // RVA: 0x7AE60D0
        public void AddLinkInternal(){} // RVA: 0x7AE6240
        public void RemoveLinkInternal(){} // RVA: 0x7AE5F80
        public void IsOffMeshConnectionOccupied(){} // RVA: 0x7AE6080
        public void IsOffMeshConnectionActive(){} // RVA: 0x7AE5FD0
        public void SetOffMeshConnectionActive(){} // RVA: 0x7AE62B0
        public void SamplePositionFilter(){} // RVA: 0x7AE63B0
        public void FindClosestEdgeFilter(){} // RVA: 0x7AE64D0
        public void RaycastFilter(){} // RVA: 0x7AE65F0
        public void CalculatePathFilterInternal(){} // RVA: 0x7AE67F0
        public void CreateSettings(){} // RVA: 0x7AE6920
        public void RemoveSettings(){} // RVA: 0x7AE6990
        public void GetSettingsByID(){} // RVA: 0x7AE69E0
        public void GetSettingsCount(){} // RVA: 0x7AE6A60
        public void GetSettingsByIndex(){} // RVA: 0x7AE6AB0
        public void GetSettingsNameFromID(){} // RVA: 0x7AE6B30
        public void RemoveAllNavMeshData(){} // RVA: 0x7AE6C00
        public void Raycast_Injected(){} // RVA: 0x7AE6C50
        public void CalculatePathInternal_Injected(){} // RVA: 0x7AE6CD0
        public void FindClosestEdge_Injected(){} // RVA: 0x7AE6D50
        public void SamplePosition_Injected(){} // RVA: 0x7AE6DC0
        public void GetAreaFromName_Injected(){} // RVA: 0x7AE6E40
        public void CalculateTriangulation_Injected(){} // RVA: 0x7AE6E90
        public void InternalGetOwner_Injected(){} // RVA: 0x7AE6EE0
        public void InternalGetLinkOwner_Injected(){} // RVA: 0x7AE6F30
        public void AddNavMeshDataInternal_Injected(){} // RVA: 0x7AE6F80
        public void AddNavMeshDataTransformedInternal_Injected(){} // RVA: 0x7AE6FD0
        public void AddLinkInternal_Injected(){} // RVA: 0x7AE7040
        public void SamplePositionFilter_Injected(){} // RVA: 0x7AE70B0
        public void FindClosestEdgeFilter_Injected(){} // RVA: 0x7AE7140
        public void RaycastFilter_Injected(){} // RVA: 0x7AE71C0
        public void CalculatePathFilterInternal_Injected(){} // RVA: 0x7AE7250
        public void CreateSettings_Injected(){} // RVA: 0x7AE72E0
        public void GetSettingsByID_Injected(){} // RVA: 0x7AE7330
        public void GetSettingsByIndex_Injected(){} // RVA: 0x7AE7390
        public void GetSettingsNameFromID_Injected(){} // RVA: 0x7AE73F0
    }

    public class NavMeshAgent : Behaviour
    {
        // ── Methods ──
        public void SetDestination(){} // RVA: 0x7ADCB70
        public void get_destination(){} // RVA: 0x7ADCC20
        public void set_destination(){} // RVA: 0x7ADCCE0
        public void get_stoppingDistance(){} // RVA: 0x7ADCD90
        public void set_stoppingDistance(){} // RVA: 0x7ADCE30
        public void get_velocity(){} // RVA: 0x7ADCEE0
        public void set_velocity(){} // RVA: 0x7ADCFA0
        public void get_nextPosition(){} // RVA: 0x7ADD050
        public void set_nextPosition(){} // RVA: 0x7ADD110
        public void get_steeringTarget(){} // RVA: 0x7ADD1C0
        public void get_desiredVelocity(){} // RVA: 0x7ADD280
        public void get_remainingDistance(){} // RVA: 0x7ADD340
        public void get_baseOffset(){} // RVA: 0x7ADD3E0
        public void set_baseOffset(){} // RVA: 0x7ADD480
        public void get_isOnOffMeshLink(){} // RVA: 0x7ADD530
        public void ActivateCurrentOffMeshLink(){} // RVA: 0x7ADD5D0
        public void get_currentOffMeshLinkData(){} // RVA: 0x7ADD680
        public void GetCurrentOffMeshLinkDataInternal(){} // RVA: 0x7ADD760
        public void get_nextOffMeshLinkData(){} // RVA: 0x7ADD820
        public void GetNextOffMeshLinkDataInternal(){} // RVA: 0x7ADD900
        public void CompleteOffMeshLink(){} // RVA: 0x7ADD9C0
        public void get_autoTraverseOffMeshLink(){} // RVA: 0x7ADDA60
        public void set_autoTraverseOffMeshLink(){} // RVA: 0x7ADDB00
        public void get_autoBraking(){} // RVA: 0x7ADDBB0
        public void set_autoBraking(){} // RVA: 0x7ADDC50
        public void get_autoRepath(){} // RVA: 0x7ADDD00
        public void set_autoRepath(){} // RVA: 0x7ADDDA0
        public void get_hasPath(){} // RVA: 0x7ADDE50
        public void get_pathPending(){} // RVA: 0x7ADDEF0
        public void get_isPathStale(){} // RVA: 0x7ADDF90
        public void get_pathStatus(){} // RVA: 0x7ADE030
        public void get_pathEndPosition(){} // RVA: 0x7ADE0D0
        public void Warp(){} // RVA: 0x7ADE190
        public void Move(){} // RVA: 0x7ADE240
        public void Stop(){} // RVA: 0x7ADE2F0
        public void Resume(){} // RVA: 0x7ADE390
        public void get_isStopped(){} // RVA: 0x7ADE430
        public void set_isStopped(){} // RVA: 0x7ADE4D0
        public void ResetPath(){} // RVA: 0x7ADE580
        public void SetPath(){} // RVA: 0x7ADE620
        public void get_path(){} // RVA: 0x7ADE720
        public void set_path(){} // RVA: 0x7ADE870
        public void CopyPathTo(){} // RVA: 0x7ADE8D0
        public void FindClosestEdge(){} // RVA: 0x7ADE9D0
        public void Raycast(){} // RVA: 0x7ADEA80
        public void CalculatePath(){} // RVA: 0x7ADEB40
        public void CalculatePathInternal(){} // RVA: 0x7ADEC50
        public void SamplePathPosition(){} // RVA: 0x7ADED60
        public void SetLayerCost(){} // RVA: 0x7ADEE30
        public void GetLayerCost(){} // RVA: 0x7ADEEF0
        public void SetAreaCost(){} // RVA: 0x7ADEFA0
        public void GetAreaCost(){} // RVA: 0x7ADF060
        public void get_navMeshOwner(){} // RVA: 0x7ADF110
        public void get_agentTypeID(){} // RVA: 0x7ADF1D0
        public void set_agentTypeID(){} // RVA: 0x7ADF270
        public void GetOwnerInternal(){} // RVA: 0x7ADF110
        public void get_walkableMask(){} // RVA: 0x7ADF320
        public void set_walkableMask(){} // RVA: 0x7ADF3C0
        public void get_areaMask(){} // RVA: 0x7ADF320
        public void set_areaMask(){} // RVA: 0x7ADF3D0
        public void get_speed(){} // RVA: 0x7ADF480
        public void set_speed(){} // RVA: 0x7ADF520
        public void get_angularSpeed(){} // RVA: 0x7ADF5D0
        public void set_angularSpeed(){} // RVA: 0x7ADF670
        public void get_acceleration(){} // RVA: 0x7ADF720
        public void set_acceleration(){} // RVA: 0x7ADF7C0
        public void get_updatePosition(){} // RVA: 0x7ADF870
        public void set_updatePosition(){} // RVA: 0x7ADF910
        public void get_updateRotation(){} // RVA: 0x7ADF9C0
        public void set_updateRotation(){} // RVA: 0x7ADFA60
        public void get_updateUpAxis(){} // RVA: 0x7ADFB10
        public void set_updateUpAxis(){} // RVA: 0x7ADFBB0
        public void get_radius(){} // RVA: 0x7ADFC60
        public void set_radius(){} // RVA: 0x7ADFD00
        public void get_height(){} // RVA: 0x7ADFDB0
        public void set_height(){} // RVA: 0x7ADFE50
        public void get_obstacleAvoidanceType(){} // RVA: 0x7ADFF00
        public void set_obstacleAvoidanceType(){} // RVA: 0x7ADFFA0
        public void get_avoidancePriority(){} // RVA: 0x7AE0050
        public void set_avoidancePriority(){} // RVA: 0x7AE00F0
        public void get_isOnNavMesh(){} // RVA: 0x7AE01A0
        public void .ctor(){} // RVA: 0xB43D60
        public void SetDestination_Injected(){} // RVA: 0x7AE0240
        public void get_destination_Injected(){} // RVA: 0x7AE02A0
        public void set_destination_Injected(){} // RVA: 0x7AE0300
        public void get_stoppingDistance_Injected(){} // RVA: 0x7AE0360
        public void set_stoppingDistance_Injected(){} // RVA: 0x7AE03B0
        public void get_velocity_Injected(){} // RVA: 0x7AE0410
        public void set_velocity_Injected(){} // RVA: 0x7AE0470
        public void get_nextPosition_Injected(){} // RVA: 0x7AE04D0
        public void set_nextPosition_Injected(){} // RVA: 0x7AE0530
        public void get_steeringTarget_Injected(){} // RVA: 0x7AE0590
        public void get_desiredVelocity_Injected(){} // RVA: 0x7AE05F0
        public void get_remainingDistance_Injected(){} // RVA: 0x7AE0650
        public void get_baseOffset_Injected(){} // RVA: 0x7AE06A0
        public void set_baseOffset_Injected(){} // RVA: 0x7AE06F0
        public void get_isOnOffMeshLink_Injected(){} // RVA: 0x7AE0750
        public void ActivateCurrentOffMeshLink_Injected(){} // RVA: 0x7AE07A0
        public void GetCurrentOffMeshLinkDataInternal_Injected(){} // RVA: 0x7AE0800
        public void GetNextOffMeshLinkDataInternal_Injected(){} // RVA: 0x7AE0860
        public void CompleteOffMeshLink_Injected(){} // RVA: 0x7AE08C0
        public void get_autoTraverseOffMeshLink_Injected(){} // RVA: 0x7AE0910
        public void set_autoTraverseOffMeshLink_Injected(){} // RVA: 0x7AE0960
        public void get_autoBraking_Injected(){} // RVA: 0x7AE09C0
        public void set_autoBraking_Injected(){} // RVA: 0x7AE0A10
        public void get_autoRepath_Injected(){} // RVA: 0x7AE0A70
        public void set_autoRepath_Injected(){} // RVA: 0x7AE0AC0
        public void get_hasPath_Injected(){} // RVA: 0x7AE0B20
        public void get_pathPending_Injected(){} // RVA: 0x7AE0B70
        public void get_isPathStale_Injected(){} // RVA: 0x7AE0BC0
        public void get_pathStatus_Injected(){} // RVA: 0x7AE0C10
        public void get_pathEndPosition_Injected(){} // RVA: 0x7AE0C60
        public void Warp_Injected(){} // RVA: 0x7AE0CC0
        public void Move_Injected(){} // RVA: 0x7AE0D20
        public void Stop_Injected(){} // RVA: 0x7AE0D80
        public void Resume_Injected(){} // RVA: 0x7AE0DD0
        public void get_isStopped_Injected(){} // RVA: 0x7AE0E20
        public void set_isStopped_Injected(){} // RVA: 0x7AE0E70
        public void ResetPath_Injected(){} // RVA: 0x7AE0ED0
        public void SetPath_Injected(){} // RVA: 0x7AE0F20
        public void CopyPathTo_Injected(){} // RVA: 0x7AE0F80
        public void FindClosestEdge_Injected(){} // RVA: 0x7AE0FE0
        public void Raycast_Injected(){} // RVA: 0x7AE1040
        public void CalculatePathInternal_Injected(){} // RVA: 0x7AE10B0
        public void SamplePathPosition_Injected(){} // RVA: 0x7AE1120
        public void SetLayerCost_Injected(){} // RVA: 0x7AE11A0
        public void GetLayerCost_Injected(){} // RVA: 0x7AE1210
        public void SetAreaCost_Injected(){} // RVA: 0x7AE1270
        public void GetAreaCost_Injected(){} // RVA: 0x7AE12E0
        public void get_agentTypeID_Injected(){} // RVA: 0x7AE1340
        public void set_agentTypeID_Injected(){} // RVA: 0x7AE1390
        public void GetOwnerInternal_Injected(){} // RVA: 0x7AE13F0
        public void get_areaMask_Injected(){} // RVA: 0x7AE1440
        public void set_areaMask_Injected(){} // RVA: 0x7AE1490
        public void get_speed_Injected(){} // RVA: 0x7AE14F0
        public void set_speed_Injected(){} // RVA: 0x7AE1540
        public void get_angularSpeed_Injected(){} // RVA: 0x7AE15A0
        public void set_angularSpeed_Injected(){} // RVA: 0x7AE15F0
        public void get_acceleration_Injected(){} // RVA: 0x7AE1650
        public void set_acceleration_Injected(){} // RVA: 0x7AE16A0
        public void get_updatePosition_Injected(){} // RVA: 0x7AE1700
        public void set_updatePosition_Injected(){} // RVA: 0x7AE1750
        public void get_updateRotation_Injected(){} // RVA: 0x7AE17B0
        public void set_updateRotation_Injected(){} // RVA: 0x7AE1800
        public void get_updateUpAxis_Injected(){} // RVA: 0x7AE1860
        public void set_updateUpAxis_Injected(){} // RVA: 0x7AE18B0
        public void get_radius_Injected(){} // RVA: 0x7AE1910
        public void set_radius_Injected(){} // RVA: 0x7AE1960
        public void get_height_Injected(){} // RVA: 0x7AE19C0
        public void set_height_Injected(){} // RVA: 0x7AE1A10
        public void get_obstacleAvoidanceType_Injected(){} // RVA: 0x7AE1A70
        public void set_obstacleAvoidanceType_Injected(){} // RVA: 0x7AE1AC0
        public void get_avoidancePriority_Injected(){} // RVA: 0x7AE1B20
        public void set_avoidancePriority_Injected(){} // RVA: 0x7AE1B70
        public void get_isOnNavMesh_Injected(){} // RVA: 0x7AE1BD0
    }

    public class NavMeshBuildMarkup : ValueType
    {
        public object m_OverrideArea;
        public object m_Area;
        public object m_InheritIgnoreFromBuild;
        public object m_IgnoreFromBuild;
        public object m_OverrideGenerateLinks;
        public object m_GenerateLinks;
        public object m_InstanceID;
        public object m_IgnoreChildren;

        // ── Methods ──
        public void set_overrideArea(){} // RVA: 0x8E53E0
        public void set_area(){} // RVA: 0x77EE0
        public void set_ignoreFromBuild(){} // RVA: 0x9588F0
        public void set_overrideGenerateLinks(){} // RVA: 0x958900
        public void set_generateLinks(){} // RVA: 0x958910
        public void set_applyToChildren(){} // RVA: 0x958920
        public void set_root(){} // RVA: 0x958930
    }

    public class NavMeshBuildSettings : ValueType
    {
        public object m_AgentTypeID;
        public object m_AgentRadius;
        public object m_AgentHeight;
        public object m_AgentSlope;
        public object m_AgentClimb;
        public object m_LedgeDropHeight;
        public object m_MaxJumpAcrossDistance;
        public object m_MinRegionArea;
        public object m_OverrideVoxelSize;
        public object m_VoxelSize;
        public object m_OverrideTileSize;
        public object m_TileSize;
        public object m_BuildHeightMesh;
        public object m_MaxJobWorkers;
        public object m_PreserveTilesOutsideBounds;
        public object m_Debug;

        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x454FE0
        public void set_agentTypeID(){} // RVA: 0x29580
        public void get_agentRadius(){} // RVA: 0x958940
        public void set_agentRadius(){} // RVA: 0xD1B40
        public void get_agentHeight(){} // RVA: 0x958950
        public void set_agentHeight(){} // RVA: 0xD1B50
        public void get_agentSlope(){} // RVA: 0x958960
        public void set_agentSlope(){} // RVA: 0xD1B10
        public void get_agentClimb(){} // RVA: 0x958970
        public void set_agentClimb(){} // RVA: 0xFF760
        public void get_ledgeDropHeight(){} // RVA: 0x276FA0
        public void set_ledgeDropHeight(){} // RVA: 0x9B0E0
        public void get_maxJumpAcrossDistance(){} // RVA: 0x958980
        public void set_maxJumpAcrossDistance(){} // RVA: 0x9B0C0
        public void get_minRegionArea(){} // RVA: 0x958990
        public void set_minRegionArea(){} // RVA: 0x9B110
        public void get_overrideVoxelSize(){} // RVA: 0x9589A0
        public void set_overrideVoxelSize(){} // RVA: 0x9582F0
        public void get_voxelSize(){} // RVA: 0x9589B0
        public void set_voxelSize(){} // RVA: 0x9B080
        public void get_overrideTileSize(){} // RVA: 0x9589C0
        public void set_overrideTileSize(){} // RVA: 0x9589D0
        public void get_tileSize(){} // RVA: 0x9589E0
        public void set_tileSize(){} // RVA: 0x13F8B0
        public void get_preserveTilesOutsideBounds(){} // RVA: 0x9589F0
        public void set_preserveTilesOutsideBounds(){} // RVA: 0x958A00
        public void get_buildHeightMesh(){} // RVA: 0x958A10
        public void set_buildHeightMesh(){} // RVA: 0x958A20
        public void get_debug(){} // RVA: 0x958A30
        public void set_debug(){} // RVA: 0x958A40
        public void ValidationReport(){} // RVA: 0x958A50
        public void InternalValidationReport(){} // RVA: 0x7AE8210
        public void InternalValidationReport_Injected(){} // RVA: 0x7AE8270
    }

    public class NavMeshBuildSource : ValueType
    {
        public object m_Transform;
        public object m_Size;
        public object m_Shape;
        public object m_Area;
        public object m_InstanceID;
        public object m_ComponentID;
        public object m_GenerateLinks;

        // ── Methods ──
        public void get_transform(){} // RVA: 0x46C460
        public void set_transform(){} // RVA: 0x46C440
        public void get_size(){} // RVA: 0x958880
        public void set_size(){} // RVA: 0x9588A0
        public void get_shape(){} // RVA: 0x9588B0
        public void set_shape(){} // RVA: 0x4AA3F0
        public void set_area(){} // RVA: 0x9588C0
        public void get_sourceObject(){} // RVA: 0x9588D0
        public void get_component(){} // RVA: 0x9588E0
        public void InternalGetComponent(){} // RVA: 0x7AE7DF0
        public void InternalGetObject(){} // RVA: 0x7AE7E70
        public void InternalGetComponent_Injected(){} // RVA: 0x7AE7EF0
        public void InternalGetObject_Injected(){} // RVA: 0x7AE7F40
    }

    public class NavMeshBuildSource[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F930
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B050
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E35750
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B050
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class NavMeshBuilder : Object
    {
        // ── Methods ──
        public void CollectSources(){} // RVA: 0x7ADBC90
        public void CollectSourcesInternal(){} // RVA: 0x7ADBE70
        public void BuildNavMeshData(){} // RVA: 0x7ADC210
        public void UpdateNavMeshDataListInternal(){} // RVA: 0x7ADC550
        public void UpdateNavMeshDataAsync(){} // RVA: 0x7ADC610
        public void UpdateNavMeshDataAsyncListInternal(){} // RVA: 0x7ADC8B0
        public void CollectSourcesInternal_Injected(){} // RVA: 0x7ADC9D0
        public void UpdateNavMeshDataListInternal_Injected(){} // RVA: 0x7ADCA70
        public void UpdateNavMeshDataAsyncListInternal_Injected(){} // RVA: 0x7ADCAF0
    }

    public class NavMeshData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4450
        public void Internal_Create(){} // RVA: 0x7AE44F0
        public void get_sourceBounds(){} // RVA: 0x7AE4550
        public void get_position(){} // RVA: 0x7AE4610
        public void set_position(){} // RVA: 0x7AE46D0
        public void get_rotation(){} // RVA: 0x7AE4780
        public void set_rotation(){} // RVA: 0x7AE4840
        public void get_sourceBounds_Injected(){} // RVA: 0x7AE48F0
        public void get_position_Injected(){} // RVA: 0x7AE4950
        public void set_position_Injected(){} // RVA: 0x7AE49B0
        public void get_rotation_Injected(){} // RVA: 0x7AE4A10
        public void set_rotation_Injected(){} // RVA: 0x7AE4A70
    }

    public class NavMeshDataInstance : ValueType
    {
        public object _id;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x958630
        public void get_id(){} // RVA: 0x77E60
        public void set_id(){} // RVA: 0x29580
        public void Remove(){} // RVA: 0x958640
        public void get_owner(){} // RVA: 0x958690
        public void set_owner(){} // RVA: 0x9586A0
    }

    public class NavMeshHit : ValueType
    {
        public object m_Position;
        public object m_Normal;
        public object m_Distance;
        public object m_Mask;
        public object m_Hit;

        // ── Methods ──
        public void get_position(){} // RVA: 0x45A5B0
        public void set_position(){} // RVA: 0x45A580
        public void get_normal(){} // RVA: 0x9582C0
        public void set_normal(){} // RVA: 0x9582E0
        public void get_distance(){} // RVA: 0x9B090
        public void set_distance(){} // RVA: 0x9B0C0
        public void get_mask(){} // RVA: 0x9F5A0
        public void set_mask(){} // RVA: 0x9F5B0
        public void get_hit(){} // RVA: 0x77D30
        public void set_hit(){} // RVA: 0x9582F0
    }

    public class NavMeshLinkData : ValueType
    {
        public object m_StartPosition;
        public object m_EndPosition;
        public object m_CostModifier;
        public object m_Bidirectional;
        public object m_Width;
        public object m_Area;
        public object m_AgentTypeID;

        // ── Methods ──
        public void get_startPosition(){} // RVA: 0x45A5B0
        public void set_startPosition(){} // RVA: 0x45A580
        public void get_endPosition(){} // RVA: 0x9582C0
        public void set_endPosition(){} // RVA: 0x9582E0
        public void get_costModifier(){} // RVA: 0x9B090
        public void set_costModifier(){} // RVA: 0x9B0C0
        public void get_bidirectional(){} // RVA: 0x77CB0
        public void set_bidirectional(){} // RVA: 0x9586B0
        public void get_width(){} // RVA: 0x9B0D0
        public void set_width(){} // RVA: 0x9B0A0
        public void get_area(){} // RVA: 0xE1E20
        public void set_area(){} // RVA: 0xE1E00
        public void get_agentTypeID(){} // RVA: 0x77D20
        public void set_agentTypeID(){} // RVA: 0x77CF0
    }

    public class NavMeshLinkInstance : ValueType
    {
        public object _id;

        // ── Methods ──
        public void get_id(){} // RVA: 0x77E60
        public void set_id(){} // RVA: 0x29580
    }

    public class NavMeshObstacle : Behaviour
    {
        // ── Methods ──
        public void get_height(){} // RVA: 0x7AE1C20
        public void set_height(){} // RVA: 0x7AE1CC0
        public void get_radius(){} // RVA: 0x7AE1D70
        public void set_radius(){} // RVA: 0x7AE1E10
        public void get_velocity(){} // RVA: 0x7AE1EC0
        public void set_velocity(){} // RVA: 0x7AE1F80
        public void get_carving(){} // RVA: 0x7AE2030
        public void set_carving(){} // RVA: 0x7AE20D0
        public void get_carveOnlyStationary(){} // RVA: 0x7AE2180
        public void set_carveOnlyStationary(){} // RVA: 0x7AE2220
        public void get_carvingMoveThreshold(){} // RVA: 0x7AE22D0
        public void set_carvingMoveThreshold(){} // RVA: 0x7AE2370
        public void get_carvingTimeToStationary(){} // RVA: 0x7AE2420
        public void set_carvingTimeToStationary(){} // RVA: 0x7AE24C0
        public void get_shape(){} // RVA: 0x7AE2570
        public void set_shape(){} // RVA: 0x7AE2610
        public void get_center(){} // RVA: 0x7AE26C0
        public void set_center(){} // RVA: 0x7AE2780
        public void get_size(){} // RVA: 0x7AE2830
        public void set_size(){} // RVA: 0x7AE28F0
        public void FitExtents(){} // RVA: 0x7AE29A0
        public void .ctor(){} // RVA: 0xB43D60
        public void get_height_Injected(){} // RVA: 0x7AE2A40
        public void set_height_Injected(){} // RVA: 0x7AE2A90
        public void get_radius_Injected(){} // RVA: 0x7AE2AF0
        public void set_radius_Injected(){} // RVA: 0x7AE2B40
        public void get_velocity_Injected(){} // RVA: 0x7AE2BA0
        public void set_velocity_Injected(){} // RVA: 0x7AE2C00
        public void get_carving_Injected(){} // RVA: 0x7AE2C60
        public void set_carving_Injected(){} // RVA: 0x7AE2CB0
        public void get_carveOnlyStationary_Injected(){} // RVA: 0x7AE2D10
        public void set_carveOnlyStationary_Injected(){} // RVA: 0x7AE2D60
        public void get_carvingMoveThreshold_Injected(){} // RVA: 0x7AE2DC0
        public void set_carvingMoveThreshold_Injected(){} // RVA: 0x7AE2E10
        public void get_carvingTimeToStationary_Injected(){} // RVA: 0x7AE2E70
        public void set_carvingTimeToStationary_Injected(){} // RVA: 0x7AE2EC0
        public void get_shape_Injected(){} // RVA: 0x7AE2F20
        public void set_shape_Injected(){} // RVA: 0x7AE2F70
        public void get_center_Injected(){} // RVA: 0x7AE2FD0
        public void set_center_Injected(){} // RVA: 0x7AE3030
        public void get_size_Injected(){} // RVA: 0x7AE3090
        public void set_size_Injected(){} // RVA: 0x7AE30F0
        public void FitExtents_Injected(){} // RVA: 0x7AE3150
    }

    public class NavMeshPath : Object
    {
        public object m_Ptr;
        public object m_Corners;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7450
        public void Finalize(){} // RVA: 0x7AE74A0
        public void InitializeNavMeshPath(){} // RVA: 0x7AE7530
        public void DestroyNavMeshPath(){} // RVA: 0x7AE7580
        public void GetCornersNonAlloc(){} // RVA: 0x7AE75D0
        public void CalculateCornersInternal(){} // RVA: 0x7AE7720
        public void ClearCornersInternal(){} // RVA: 0x7AE7850
        public void ClearCorners(){} // RVA: 0x7AE78C0
        public void CalculateCorners(){} // RVA: 0x7AE79A0
        public void get_corners(){} // RVA: 0x7AE7A10
        public void get_status(){} // RVA: 0x7AE7A90
        public void GetCornersNonAlloc_Injected(){} // RVA: 0x7AE7B00
        public void CalculateCornersInternal_Injected(){} // RVA: 0x7AE7B60
        public void ClearCornersInternal_Injected(){} // RVA: 0x7AE7BC0
        public void get_status_Injected(){} // RVA: 0x7AE7C10
    }

    public class NavMeshQueryFilter : ValueType
    {
        public object _costs;
        public object _areaMask;
        public object _agentTypeID;

        // ── Methods ──
        public void get_costs(){} // RVA: 0x77900
        public void set_costs(){} // RVA: 0x47F10
        public void get_areaMask(){} // RVA: 0x14790
        public void set_areaMask(){} // RVA: 0x92DD0
        public void get_agentTypeID(){} // RVA: 0x92DE0
        public void set_agentTypeID(){} // RVA: 0x92DF0
        public void GetAreaCost(){} // RVA: 0x9586C0
        public void SetAreaCost(){} // RVA: 0x9586D0
    }

    public class NavMeshTriangulation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DD60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34170
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class NavMesh[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class OffMeshLink : Behaviour
    {
        // ── Methods ──
        public void get_activated(){} // RVA: 0x7AE3300
        public void set_activated(){} // RVA: 0x7AE33A0
        public void get_occupied(){} // RVA: 0x7AE3450
        public void get_costOverride(){} // RVA: 0x7AE34F0
        public void set_costOverride(){} // RVA: 0x7AE3590
        public void get_biDirectional(){} // RVA: 0x7AE3640
        public void set_biDirectional(){} // RVA: 0x7AE36E0
        public void UpdatePositions(){} // RVA: 0x7AE3790
        public void get_navMeshLayer(){} // RVA: 0x7AE3830
        public void set_navMeshLayer(){} // RVA: 0x7AE38D0
        public void get_area(){} // RVA: 0x7AE3830
        public void set_area(){} // RVA: 0x7AE38D0
        public void get_autoUpdatePositions(){} // RVA: 0x7AE3980
        public void set_autoUpdatePositions(){} // RVA: 0x7AE3A20
        public void get_startTransform(){} // RVA: 0x7AE3AD0
        public void set_startTransform(){} // RVA: 0x7AE3B90
        public void get_endTransform(){} // RVA: 0x7AE3C70
        public void set_endTransform(){} // RVA: 0x7AE3D30
        public void .ctor(){} // RVA: 0xB43D60
        public void get_activated_Injected(){} // RVA: 0x7AE3E10
        public void set_activated_Injected(){} // RVA: 0x7AE3E60
        public void get_occupied_Injected(){} // RVA: 0x7AE3EC0
        public void get_costOverride_Injected(){} // RVA: 0x7AE3F10
        public void set_costOverride_Injected(){} // RVA: 0x7AE3F60
        public void get_biDirectional_Injected(){} // RVA: 0x7AE3FC0
        public void set_biDirectional_Injected(){} // RVA: 0x7AE4010
        public void UpdatePositions_Injected(){} // RVA: 0x7AE4070
        public void get_area_Injected(){} // RVA: 0x7AE40C0
        public void set_area_Injected(){} // RVA: 0x7AE4110
        public void get_autoUpdatePositions_Injected(){} // RVA: 0x7AE4170
        public void set_autoUpdatePositions_Injected(){} // RVA: 0x7AE41C0
        public void get_startTransform_Injected(){} // RVA: 0x7AE4220
        public void set_startTransform_Injected(){} // RVA: 0x7AE4270
        public void get_endTransform_Injected(){} // RVA: 0x7AE42D0
        public void set_endTransform_Injected(){} // RVA: 0x7AE4320
    }

    public class OffMeshLinkData : ValueType
    {
        public object m_Valid;
        public object m_Activated;
        public object m_InstanceID;
        public object m_LinkType;
        public object m_StartPos;
        public object m_EndPos;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x368020
        public void get_activated(){} // RVA: 0x9582A0
        public void get_linkType(){} // RVA: 0x92DE0
        public void get_startPos(){} // RVA: 0x262C90
        public void get_endPos(){} // RVA: 0x9356D0
        public void get_owner(){} // RVA: 0x9582B0
        public void GetLinkOwnerInternal(){} // RVA: 0x7AE3230
        public void GetLinkOwnerInternal_Injected(){} // RVA: 0x7AE32B0
    }

}