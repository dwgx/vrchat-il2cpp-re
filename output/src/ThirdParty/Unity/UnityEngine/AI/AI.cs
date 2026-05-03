// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.AI
// Classes: 18
// Methods: 340

namespace ThirdParty.Unity.UnityEngine.AI
{
    public class NavMesh : Object
    {
        public OnNavMeshPreUpdate onPreUpdate;

        // ── Methods ──
        public void Internal_CallOnNavMeshPreUpdate(){} // RVA: 0x7FFE87BBB020
        public void Raycast(){} // RVA: 0x7FFE87BBBFF0 | overloaded x2
        public void CalculatePath(){} // RVA: 0x7FFE87BBC120 | overloaded x2
        public void CalculatePathInternal(){} // RVA: 0x7FFE87BBB1C0
        public void FindClosestEdge(){} // RVA: 0x7FFE87BBBEE0 | overloaded x2
        public void SamplePosition(){} // RVA: 0x7FFE87BBBDB0 | overloaded x2
        public void SetAreaCost(){} // RVA: 0x7FFE87BBB330
        public void GetAreaCost(){} // RVA: 0x7FFE87BBB390
        public void GetAreaFromName(){} // RVA: 0x7FFE87BBB3E0
        public void CalculateTriangulation(){} // RVA: 0x7FFE87BBB430
        public void get_avoidancePredictionTime(){} // RVA: 0x7FFE87BBB490
        public void set_avoidancePredictionTime(){} // RVA: 0x7FFE87BBB4E0
        public void AddNavMeshData(){} // RVA: 0x7FFE87BBB690 | overloaded x2
        public void RemoveNavMeshData(){} // RVA: 0x7FFE87BBB820
        public void IsValidNavMeshDataHandle(){} // RVA: 0x7FFE87BBB870
        public void IsValidLinkHandle(){} // RVA: 0x7FFE87BBB8C0
        public void InternalGetOwner(){} // RVA: 0x7FFE87BBB910
        public void InternalSetOwner(){} // RVA: 0x7FFE87BBB960
        public void InternalGetLinkOwner(){} // RVA: 0x7FFE87BBB9C0
        public void InternalSetLinkOwner(){} // RVA: 0x7FFE87BBBA10
        public void AddNavMeshDataInternal(){} // RVA: 0x7FFE87BBBA70
        public void AddNavMeshDataTransformedInternal(){} // RVA: 0x7FFE87BBBAC0
        public void RemoveNavMeshDataInternal(){} // RVA: 0x7FFE87BBB820
        public void AddLink(){} // RVA: 0x7FFE87BBBC50 | overloaded x2
        public void RemoveLink(){} // RVA: 0x7FFE87BBBCF0
        public void AddLinkInternal(){} // RVA: 0x7FFE87BBBD40
        public void RemoveLinkInternal(){} // RVA: 0x7FFE87BBBCF0
        public void SamplePositionFilter(){} // RVA: 0x7FFE87BBBE50
        public void FindClosestEdgeFilter(){} // RVA: 0x7FFE87BBBF70
        public void RaycastFilter(){} // RVA: 0x7FFE87BBC090
        public void CalculatePathFilterInternal(){} // RVA: 0x7FFE87BBC1F0
        public void CreateSettings(){} // RVA: 0x7FFE87BBC290
        public void RemoveSettings(){} // RVA: 0x7FFE87BBC300
        public void GetSettingsByID(){} // RVA: 0x7FFE87BBC350
        public void GetSettingsCount(){} // RVA: 0x7FFE87BBC3D0
        public void GetSettingsByIndex(){} // RVA: 0x7FFE87BBC420
        public void GetSettingsNameFromID(){} // RVA: 0x7FFE87BBC4A0
        public void RemoveAllNavMeshData(){} // RVA: 0x7FFE87BBC4F0
        public void Raycast_Injected(){} // RVA: 0x7FFE87BBC540
        public void CalculatePathInternal_Injected(){} // RVA: 0x7FFE87BBC5C0
        public void FindClosestEdge_Injected(){} // RVA: 0x7FFE87BBC640
        public void SamplePosition_Injected(){} // RVA: 0x7FFE87BBC6B0
        public void CalculateTriangulation_Injected(){} // RVA: 0x7FFE87BBC730
        public void AddNavMeshDataTransformedInternal_Injected(){} // RVA: 0x7FFE87BBC780
        public void AddLinkInternal_Injected(){} // RVA: 0x7FFE87BBC7F0
        public void SamplePositionFilter_Injected(){} // RVA: 0x7FFE87BBC860
        public void FindClosestEdgeFilter_Injected(){} // RVA: 0x7FFE87BBC8F0
        public void RaycastFilter_Injected(){} // RVA: 0x7FFE87BBC970
        public void CalculatePathFilterInternal_Injected(){} // RVA: 0x7FFE87BBCA00
        public void CreateSettings_Injected(){} // RVA: 0x7FFE87BBCA90
        public void GetSettingsByID_Injected(){} // RVA: 0x7FFE87BBCAE0
        public void GetSettingsByIndex_Injected(){} // RVA: 0x7FFE87BBCB40
    }

    public class NavMeshAgent : Behaviour
    {
        // ── Methods ──
        public void SetDestination(){} // RVA: 0x7FFE87BB6F30
        public void get_destination(){} // RVA: 0x7FFE87BB6F90
        public void set_destination(){} // RVA: 0x7FFE87BB7000
        public void get_stoppingDistance(){} // RVA: 0x7FFE87BB7060
        public void set_stoppingDistance(){} // RVA: 0x7FFE87BB70B0
        public void get_velocity(){} // RVA: 0x7FFE87BB7110
        public void set_velocity(){} // RVA: 0x7FFE87BB7180
        public void get_nextPosition(){} // RVA: 0x7FFE87BB71E0
        public void set_nextPosition(){} // RVA: 0x7FFE87BB7250
        public void get_steeringTarget(){} // RVA: 0x7FFE87BB72B0
        public void get_desiredVelocity(){} // RVA: 0x7FFE87BB7320
        public void get_remainingDistance(){} // RVA: 0x7FFE87BB7390
        public void get_baseOffset(){} // RVA: 0x7FFE87BB73E0
        public void set_baseOffset(){} // RVA: 0x7FFE87BB7430
        public void get_isOnOffMeshLink(){} // RVA: 0x7FFE87BB7490
        public void ActivateCurrentOffMeshLink(){} // RVA: 0x7FFE87BB74E0
        public void get_currentOffMeshLinkData(){} // RVA: 0x7FFE87BB7540
        public void GetCurrentOffMeshLinkDataInternal(){} // RVA: 0x7FFE87BB75E0
        public void get_nextOffMeshLinkData(){} // RVA: 0x7FFE87BB7660
        public void GetNextOffMeshLinkDataInternal(){} // RVA: 0x7FFE87BB7700
        public void CompleteOffMeshLink(){} // RVA: 0x7FFE87BB7780
        public void get_autoTraverseOffMeshLink(){} // RVA: 0x7FFE87BB77D0
        public void set_autoTraverseOffMeshLink(){} // RVA: 0x7FFE87BB7820
        public void get_autoBraking(){} // RVA: 0x7FFE87BB7880
        public void set_autoBraking(){} // RVA: 0x7FFE87BB78D0
        public void get_autoRepath(){} // RVA: 0x7FFE87BB7930
        public void set_autoRepath(){} // RVA: 0x7FFE87BB7980
        public void get_hasPath(){} // RVA: 0x7FFE87BB79E0
        public void get_pathPending(){} // RVA: 0x7FFE87BB7A30
        public void get_isPathStale(){} // RVA: 0x7FFE87BB7A80
        public void get_pathStatus(){} // RVA: 0x7FFE87BB7AD0
        public void get_pathEndPosition(){} // RVA: 0x7FFE87BB7B20
        public void Warp(){} // RVA: 0x7FFE87BB7B90
        public void Move(){} // RVA: 0x7FFE87BB7BF0
        public void Stop(){} // RVA: 0x7FFE87BB7C50 | overloaded x2
        public void Resume(){} // RVA: 0x7FFE87BB7CA0
        public void get_isStopped(){} // RVA: 0x7FFE87BB7CF0
        public void set_isStopped(){} // RVA: 0x7FFE87BB7D40
        public void ResetPath(){} // RVA: 0x7FFE87BB7DA0
        public void SetPath(){} // RVA: 0x7FFE87BB7DF0
        public void get_path(){} // RVA: 0x7FFE87BB7E50
        public void set_path(){} // RVA: 0x7FFE87BB7F20
        public void CopyPathTo(){} // RVA: 0x7FFE87BB7FC0
        public void FindClosestEdge(){} // RVA: 0x7FFE87BB8020
        public void Raycast(){} // RVA: 0x7FFE87BB8080
        public void CalculatePath(){} // RVA: 0x7FFE87BB80F0
        public void CalculatePathInternal(){} // RVA: 0x7FFE87BB8190
        public void SamplePathPosition(){} // RVA: 0x7FFE87BB8200
        public void SetLayerCost(){} // RVA: 0x7FFE87BB8280
        public void GetLayerCost(){} // RVA: 0x7FFE87BB82F0
        public void SetAreaCost(){} // RVA: 0x7FFE87BB8350
        public void GetAreaCost(){} // RVA: 0x7FFE87BB83C0
        public void get_navMeshOwner(){} // RVA: 0x7FFE87BB8420
        public void get_agentTypeID(){} // RVA: 0x7FFE87BB8470
        public void set_agentTypeID(){} // RVA: 0x7FFE87BB84C0
        public void GetOwnerInternal(){} // RVA: 0x7FFE87BB8420
        public void get_walkableMask(){} // RVA: 0x7FFE87BB8520
        public void set_walkableMask(){} // RVA: 0x7FFE87BB8570
        public void get_areaMask(){} // RVA: 0x7FFE87BB8520
        public void set_areaMask(){} // RVA: 0x7FFE87BB8570
        public void get_speed(){} // RVA: 0x7FFE87BB85D0
        public void set_speed(){} // RVA: 0x7FFE87BB8620
        public void get_angularSpeed(){} // RVA: 0x7FFE87BB8680
        public void set_angularSpeed(){} // RVA: 0x7FFE87BB86D0
        public void get_acceleration(){} // RVA: 0x7FFE87BB8730
        public void set_acceleration(){} // RVA: 0x7FFE87BB8780
        public void get_updatePosition(){} // RVA: 0x7FFE87BB87E0
        public void set_updatePosition(){} // RVA: 0x7FFE87BB8830
        public void get_updateRotation(){} // RVA: 0x7FFE87BB8890
        public void set_updateRotation(){} // RVA: 0x7FFE87BB88E0
        public void get_updateUpAxis(){} // RVA: 0x7FFE87BB8940
        public void set_updateUpAxis(){} // RVA: 0x7FFE87BB8990
        public void get_radius(){} // RVA: 0x7FFE87BB89F0
        public void set_radius(){} // RVA: 0x7FFE87BB8A40
        public void get_height(){} // RVA: 0x7FFE87BB8AA0
        public void set_height(){} // RVA: 0x7FFE87BB8AF0
        public void get_obstacleAvoidanceType(){} // RVA: 0x7FFE87BB8B50
        public void set_obstacleAvoidanceType(){} // RVA: 0x7FFE87BB8BA0
        public void get_avoidancePriority(){} // RVA: 0x7FFE87BB8C00
        public void set_avoidancePriority(){} // RVA: 0x7FFE87BB8C50
        public void get_isOnNavMesh(){} // RVA: 0x7FFE87BB8CB0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void SetDestination_Injected(){} // RVA: 0x7FFE87BB8D00
        public void get_destination_Injected(){} // RVA: 0x7FFE87BB8D60
        public void set_destination_Injected(){} // RVA: 0x7FFE87BB8DC0
        public void get_velocity_Injected(){} // RVA: 0x7FFE87BB8E20
        public void set_velocity_Injected(){} // RVA: 0x7FFE87BB8E80
        public void get_nextPosition_Injected(){} // RVA: 0x7FFE87BB8EE0
        public void set_nextPosition_Injected(){} // RVA: 0x7FFE87BB8F40
        public void get_steeringTarget_Injected(){} // RVA: 0x7FFE87BB8FA0
        public void get_desiredVelocity_Injected(){} // RVA: 0x7FFE87BB9000
        public void GetCurrentOffMeshLinkDataInternal_Injected(){} // RVA: 0x7FFE87BB9060
        public void GetNextOffMeshLinkDataInternal_Injected(){} // RVA: 0x7FFE87BB90C0
        public void get_pathEndPosition_Injected(){} // RVA: 0x7FFE87BB9120
        public void Warp_Injected(){} // RVA: 0x7FFE87BB9180
        public void Move_Injected(){} // RVA: 0x7FFE87BB91E0
        public void Raycast_Injected(){} // RVA: 0x7FFE87BB9240
        public void CalculatePathInternal_Injected(){} // RVA: 0x7FFE87BB92B0
    }

    public class NavMeshBuildDebugSettings : ValueType
    {
    }

    public class NavMeshBuildMarkup : ValueType
    {
        public int m_OverrideArea; // 0x10
        public int m_Area; // 0x14
        public int m_InheritIgnoreFromBuild; // 0x18
        public int m_IgnoreFromBuild; // 0x1C
        public int m_OverrideGenerateLinks; // 0x20
        public int m_GenerateLinks; // 0x24
        public int m_InstanceID; // 0x28

        // ── Methods ──
        public void set_overrideArea(){} // RVA: 0x7FFE86D7CE30
        public void set_area(){} // RVA: 0x7FFE826F4290
        public void set_ignoreFromBuild(){} // RVA: 0x7FFE87BBD230
        public void set_overrideGenerateLinks(){} // RVA: 0x7FFE87BBD240
        public void set_generateLinks(){} // RVA: 0x7FFE87BBD250
        public void set_applyToChildren(){} // RVA: 0x7FFE87BBD260
        public void set_root(){} // RVA: 0x7FFE87BBD270
    }

    public class NavMeshBuildSettings : ValueType
    {
        public int m_AgentTypeID; // 0x10
        public float m_AgentRadius; // 0x14
        public float m_AgentHeight; // 0x18
        public float m_AgentSlope; // 0x1C
        public float m_AgentClimb; // 0x20
        public float m_LedgeDropHeight; // 0x24
        public float m_MaxJumpAcrossDistance; // 0x28
        public float m_MinRegionArea; // 0x2C
        public int m_OverrideVoxelSize; // 0x30
        public float m_VoxelSize; // 0x34
        public int m_OverrideTileSize; // 0x38
        public int m_TileSize; // 0x3C
        public int m_BuildHeightMesh; // 0x40
        public uint m_MaxJobWorkers; // 0x44
        public int m_PreserveTilesOutsideBounds; // 0x48

        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x7FFE8733C3B0
        public void set_agentTypeID(){} // RVA: 0x7FFE815BF990
        public void get_agentRadius(){} // RVA: 0x7FFE8111ED30
        public void set_agentRadius(){} // RVA: 0x7FFE82D03BD0
        public void get_agentHeight(){} // RVA: 0x7FFE8111ECF0
        public void set_agentHeight(){} // RVA: 0x7FFE82D03BC0
        public void get_agentSlope(){} // RVA: 0x7FFE8111ED00
        public void set_agentSlope(){} // RVA: 0x7FFE82D03B80
        public void get_agentClimb(){} // RVA: 0x7FFE87BBD360
        public void set_agentClimb(){} // RVA: 0x7FFE81225330
        public void get_ledgeDropHeight(){} // RVA: 0x7FFE83BBBBE0
        public void set_ledgeDropHeight(){} // RVA: 0x7FFE81225350
        public void get_maxJumpAcrossDistance(){} // RVA: 0x7FFE87BBA360
        public void set_maxJumpAcrossDistance(){} // RVA: 0x7FFE811164D0
        public void get_minRegionArea(){} // RVA: 0x7FFE87BBD370
        public void set_minRegionArea(){} // RVA: 0x7FFE811C8580
        public void get_overrideVoxelSize(){} // RVA: 0x7FFE87BBA370
        public void set_overrideVoxelSize(){} // RVA: 0x7FFE87BBA380
        public void get_voxelSize(){} // RVA: 0x7FFE87BBD380
        public void set_voxelSize(){} // RVA: 0x7FFE81268F60
        public void get_overrideTileSize(){} // RVA: 0x7FFE87BBD390
        public void set_overrideTileSize(){} // RVA: 0x7FFE87BBD3A0
        public void get_tileSize(){} // RVA: 0x7FFE87BBD3B0
        public void set_tileSize(){} // RVA: 0x7FFE82883A50
        public void get_preserveTilesOutsideBounds(){} // RVA: 0x7FFE87BBD3C0
        public void set_preserveTilesOutsideBounds(){} // RVA: 0x7FFE87BBD3D0
        public void get_buildHeightMesh(){} // RVA: 0x7FFE87BBD3E0
        public void set_buildHeightMesh(){} // RVA: 0x7FFE87BBD3F0
        public void get_debug(){} // RVA: 0x7FFE87BBD400
        public void set_debug(){} // RVA: 0x7FFE812604F0
        public void ValidationReport(){} // RVA: 0x7FFE87BBD410
        public void InternalValidationReport(){} // RVA: 0x7FFE87BBD4A0
        public void InternalValidationReport_Injected(){} // RVA: 0x7FFE87BBD500
    }

    public class NavMeshBuildSource : ValueType
    {
        public UnityEngine.Matrix4x4 m_Transform; // 0x10
        public UnityEngine.Vector3 m_Size; // 0x50
        public 0x666C1F64 m_Shape; // 0x5C
        public int m_Area; // 0x60
        public int m_InstanceID; // 0x64
        public int m_ComponentID; // 0x68

        // ── Methods ──
        public void get_transform(){} // RVA: 0x7FFE87BBD060
        public void set_transform(){} // RVA: 0x7FFE87BBD090
        public void get_size(){} // RVA: 0x7FFE87BBD0B0
        public void set_size(){} // RVA: 0x7FFE87BBD0D0
        public void get_shape(){} // RVA: 0x7FFE87BBD0E0
        public void set_shape(){} // RVA: 0x7FFE82B06A20
        public void set_area(){} // RVA: 0x7FFE81463B00
        public void get_sourceObject(){} // RVA: 0x7FFE87BBD0F0
        public void get_component(){} // RVA: 0x7FFE87BBD140
        public void InternalGetComponent(){} // RVA: 0x7FFE87BBD190
        public void InternalGetObject(){} // RVA: 0x7FFE87BBD1E0
    }

    public class NavMeshBuilder : Object
    {
        // ── Methods ──
        public void CollectSources(){} // RVA: 0x7FFE87BB64F0 | overloaded x2
        public void CollectSourcesInternal(){} // RVA: 0x7FFE87BB6710
        public void BuildNavMeshData(){} // RVA: 0x7FFE87BB67D0
        public void UpdateNavMeshDataListInternal(){} // RVA: 0x7FFE87BB6A70
        public void UpdateNavMeshDataAsync(){} // RVA: 0x7FFE87BB6AF0
        public void UpdateNavMeshDataAsyncListInternal(){} // RVA: 0x7FFE87BB6D10
        public void CollectSourcesInternal_Injected(){} // RVA: 0x7FFE87BB6D90
        public void UpdateNavMeshDataListInternal_Injected(){} // RVA: 0x7FFE87BB6E30
        public void UpdateNavMeshDataAsyncListInternal_Injected(){} // RVA: 0x7FFE87BB6EB0
    }

    public class NavMeshData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BBA420 | overloaded x2
        public void Internal_Create(){} // RVA: 0x7FFE87BBA4C0
        public void get_sourceBounds(){} // RVA: 0x7FFE87BBA520
        public void get_position(){} // RVA: 0x7FFE87BBA590
        public void set_position(){} // RVA: 0x7FFE87BBA600
        public void get_rotation(){} // RVA: 0x7FFE87BBA660
        public void set_rotation(){} // RVA: 0x7FFE87BBA6D0
        public void get_sourceBounds_Injected(){} // RVA: 0x7FFE87BBA730
        public void get_position_Injected(){} // RVA: 0x7FFE87BBA790
        public void set_position_Injected(){} // RVA: 0x7FFE87BBA7F0
        public void get_rotation_Injected(){} // RVA: 0x7FFE87BBA850
        public void set_rotation_Injected(){} // RVA: 0x7FFE87BBA8B0
    }

    public class NavMeshDataInstance : ValueType
    {
        public int _id; // 0x10
        public object field_1; // 0x46
        public object field_2; // 0x47

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFE87BBA910
        public void get_id(){} // RVA: 0x7FFE826F4220
        public void set_id(){} // RVA: 0x7FFE815BF990
        public void Remove(){} // RVA: 0x7FFE87BBA980
        public void get_owner(){} // RVA: 0x7FFE87BBA9D0
        public void set_owner(){} // RVA: 0x7FFE87BBAA20
    }

    public class NavMeshHit : ValueType
    {
        public UnityEngine.Vector3 m_Position; // 0x10
        public UnityEngine.Vector3 m_Normal; // 0x1C
        public float m_Distance; // 0x28
        public int m_Mask; // 0x2C
        public int m_Hit; // 0x30

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFE87BBA310
        public void set_position(){} // RVA: 0x7FFE835C1F00
        public void get_normal(){} // RVA: 0x7FFE87BBA330
        public void set_normal(){} // RVA: 0x7FFE87BBA350
        public void get_distance(){} // RVA: 0x7FFE87BBA360
        public void set_distance(){} // RVA: 0x7FFE811164D0
        public void get_mask(){} // RVA: 0x7FFE84022BD0
        public void set_mask(){} // RVA: 0x7FFE82717690
        public void get_hit(){} // RVA: 0x7FFE87BBA370
        public void set_hit(){} // RVA: 0x7FFE87BBA380
    }

    public class NavMeshLinkData : ValueType
    {
        public UnityEngine.Vector3 m_StartPosition; // 0x10
        public UnityEngine.Vector3 m_EndPosition; // 0x1C
        public float m_CostModifier; // 0x28
        public int m_Bidirectional; // 0x2C
        public float m_Width; // 0x30
        public int m_Area; // 0x34
        public int m_AgentTypeID; // 0x38

        // ── Methods ──
        public void get_startPosition(){} // RVA: 0x7FFE87BBA310
        public void set_startPosition(){} // RVA: 0x7FFE835C1F00
        public void get_endPosition(){} // RVA: 0x7FFE87BBA330
        public void set_endPosition(){} // RVA: 0x7FFE87BBA350
        public void get_costModifier(){} // RVA: 0x7FFE87BBA360
        public void set_costModifier(){} // RVA: 0x7FFE811164D0
        public void get_bidirectional(){} // RVA: 0x7FFE87BBAB90
        public void set_bidirectional(){} // RVA: 0x7FFE87BBABA0
        public void get_width(){} // RVA: 0x7FFE87BBABB0
        public void set_width(){} // RVA: 0x7FFE81D54160
        public void get_area(){} // RVA: 0x7FFE87BBABC0
        public void set_area(){} // RVA: 0x7FFE82447980
        public void get_agentTypeID(){} // RVA: 0x7FFE850164C0
        public void set_agentTypeID(){} // RVA: 0x7FFE817E4800
    }

    public class NavMeshLinkInstance : ValueType
    {
        public int _id; // 0x10
        public object field_1; // 0x50
        public object field_2; // 0x51

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFE87BBABD0
        public void get_id(){} // RVA: 0x7FFE826F4220
        public void set_id(){} // RVA: 0x7FFE815BF990
        public void Remove(){} // RVA: 0x7FFE87BBAC40
        public void get_owner(){} // RVA: 0x7FFE87BBAC90
        public void set_owner(){} // RVA: 0x7FFE87BBACE0
    }

    public class NavMeshObstacle : Behaviour
    {
        // ── Methods ──
        public void get_height(){} // RVA: 0x7FFE87BB9320
        public void set_height(){} // RVA: 0x7FFE87BB9370
        public void get_radius(){} // RVA: 0x7FFE87BB93D0
        public void set_radius(){} // RVA: 0x7FFE87BB9420
        public void get_velocity(){} // RVA: 0x7FFE87BB9480
        public void set_velocity(){} // RVA: 0x7FFE87BB94F0
        public void get_carving(){} // RVA: 0x7FFE87BB9550
        public void set_carving(){} // RVA: 0x7FFE87BB95A0
        public void get_carveOnlyStationary(){} // RVA: 0x7FFE87BB9600
        public void set_carveOnlyStationary(){} // RVA: 0x7FFE87BB9650
        public void get_carvingMoveThreshold(){} // RVA: 0x7FFE87BB96B0
        public void set_carvingMoveThreshold(){} // RVA: 0x7FFE87BB9700
        public void get_carvingTimeToStationary(){} // RVA: 0x7FFE87BB9760
        public void set_carvingTimeToStationary(){} // RVA: 0x7FFE87BB97B0
        public void get_shape(){} // RVA: 0x7FFE87BB9810
        public void set_shape(){} // RVA: 0x7FFE87BB9860
        public void get_center(){} // RVA: 0x7FFE87BB98C0
        public void set_center(){} // RVA: 0x7FFE87BB9930
        public void get_size(){} // RVA: 0x7FFE87BB9990
        public void set_size(){} // RVA: 0x7FFE87BB9A00
        public void FitExtents(){} // RVA: 0x7FFE87BB9A60
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_velocity_Injected(){} // RVA: 0x7FFE87BB9AB0
        public void set_velocity_Injected(){} // RVA: 0x7FFE87BB9B10
        public void get_center_Injected(){} // RVA: 0x7FFE87BB9B70
        public void set_center_Injected(){} // RVA: 0x7FFE87BB9BD0
        public void get_size_Injected(){} // RVA: 0x7FFE87BB9C30
        public void set_size_Injected(){} // RVA: 0x7FFE87BB9C90
    }

    public class NavMeshPath : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public UnityEngine.Vector3[] m_Corners; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BBCBA0
        public void Finalize(){} // RVA: 0x7FFE87BBCBF0
        public void InitializeNavMeshPath(){} // RVA: 0x7FFE87BBCC80
        public void DestroyNavMeshPath(){} // RVA: 0x7FFE87BBCCD0
        public void GetCornersNonAlloc(){} // RVA: 0x7FFE87BBCD20
        public void CalculateCornersInternal(){} // RVA: 0x7FFE87BBCD80
        public void ClearCornersInternal(){} // RVA: 0x7FFE87BBCDD0
        public void ClearCorners(){} // RVA: 0x7FFE87BBCE20
        public void CalculateCorners(){} // RVA: 0x7FFE87BBCEC0
        public void get_corners(){} // RVA: 0x7FFE87BBCF60
        public void get_status(){} // RVA: 0x7FFE87BBD010
    }

    public class NavMeshQueryFilter : ValueType
    {
        public float[] _costs; // 0x10
        public int _areaMask; // 0x18
        public int _agentTypeID; // 0x1C

        // ── Methods ──
        public void get_costs(){} // RVA: 0x7FFE8284EF60
        public void set_costs(){} // RVA: 0x7FFE81D7E9E0
        public void get_areaMask(){} // RVA: 0x7FFE82C33000
        public void set_areaMask(){} // RVA: 0x7FFE82C33010
        public void get_agentTypeID(){} // RVA: 0x7FFE82C33020
        public void set_agentTypeID(){} // RVA: 0x7FFE82C33030
        public void GetAreaCost(){} // RVA: 0x7FFE87BBAE50
        public void SetAreaCost(){} // RVA: 0x7FFE87BBAF30
    }

    public class NavMeshTriangulation : ValueType
    {
    }

    public class OffMeshLink : Behaviour
    {
        // ── Methods ──
        public void get_activated(){} // RVA: 0x7FFE87BB9DA0
        public void set_activated(){} // RVA: 0x7FFE87BB9DF0
        public void get_occupied(){} // RVA: 0x7FFE87BB9E50
        public void get_costOverride(){} // RVA: 0x7FFE87BB9EA0
        public void set_costOverride(){} // RVA: 0x7FFE87BB9EF0
        public void get_biDirectional(){} // RVA: 0x7FFE87BB9F50
        public void set_biDirectional(){} // RVA: 0x7FFE87BB9FA0
        public void UpdatePositions(){} // RVA: 0x7FFE87BBA000
        public void get_navMeshLayer(){} // RVA: 0x7FFE87BBA050
        public void set_navMeshLayer(){} // RVA: 0x7FFE87BBA0A0
        public void get_area(){} // RVA: 0x7FFE87BBA050
        public void set_area(){} // RVA: 0x7FFE87BBA0A0
        public void get_autoUpdatePositions(){} // RVA: 0x7FFE87BBA100
        public void set_autoUpdatePositions(){} // RVA: 0x7FFE87BBA150
        public void get_startTransform(){} // RVA: 0x7FFE87BBA1B0
        public void set_startTransform(){} // RVA: 0x7FFE87BBA200
        public void get_endTransform(){} // RVA: 0x7FFE87BBA260
        public void set_endTransform(){} // RVA: 0x7FFE87BBA2B0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class OffMeshLinkData : ValueType
    {
        public int m_Valid; // 0x10
        public int m_Activated; // 0x14
        public int m_InstanceID; // 0x18
        public 0x666C1A94 m_LinkType; // 0x1C
        public UnityEngine.Vector3 m_StartPos; // 0x20
        public UnityEngine.Vector3 m_EndPos; // 0x2C

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFE86D131F0
        public void get_activated(){} // RVA: 0x7FFE87BB9CF0
        public void get_linkType(){} // RVA: 0x7FFE82C33020
        public void get_startPos(){} // RVA: 0x7FFE811188D0
        public void get_endPos(){} // RVA: 0x7FFE879E0D00
        public void get_offMeshLink(){} // RVA: 0x7FFE87BB9D00
        public void GetOffMeshLinkInternal(){} // RVA: 0x7FFE87BB9D50
    }

}