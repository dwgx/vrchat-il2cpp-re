// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.AI
// Classes: 18
// Methods: 340

namespace ThirdParty.Unity.UnityEngine.AI
{
    public class NavMesh
    {
        // ── Methods ──
        public void Internal_CallOnNavMeshPreUpdate(){} // RVA: 0x707A160
        public void Raycast(){} // RVA: 0x707B130 | overloaded x2
        public void CalculatePath(){} // RVA: 0x707B260 | overloaded x2
        public void CalculatePathInternal(){} // RVA: 0x707A300
        public void FindClosestEdge(){} // RVA: 0x707B020 | overloaded x2
        public void SamplePosition(){} // RVA: 0x707AEF0 | overloaded x2
        public void SetAreaCost(){} // RVA: 0x707A470
        public void GetAreaCost(){} // RVA: 0x707A4D0
        public void GetAreaFromName(){} // RVA: 0x707A520
        public void CalculateTriangulation(){} // RVA: 0x707A570
        public void get_avoidancePredictionTime(){} // RVA: 0x707A5D0
        public void set_avoidancePredictionTime(){} // RVA: 0x707A620
        public void AddNavMeshData(){} // RVA: 0x707A7D0 | overloaded x2
        public void RemoveNavMeshData(){} // RVA: 0x707A960
        public void IsValidNavMeshDataHandle(){} // RVA: 0x707A9B0
        public void IsValidLinkHandle(){} // RVA: 0x707AA00
        public void InternalGetOwner(){} // RVA: 0x707AA50
        public void InternalSetOwner(){} // RVA: 0x707AAA0
        public void InternalGetLinkOwner(){} // RVA: 0x707AB00
        public void InternalSetLinkOwner(){} // RVA: 0x707AB50
        public void AddNavMeshDataInternal(){} // RVA: 0x707ABB0
        public void AddNavMeshDataTransformedInternal(){} // RVA: 0x707AC00
        public void RemoveNavMeshDataInternal(){} // RVA: 0x707A960
        public void AddLink(){} // RVA: 0x707AD90 | overloaded x2
        public void RemoveLink(){} // RVA: 0x707AE30
        public void AddLinkInternal(){} // RVA: 0x707AE80
        public void RemoveLinkInternal(){} // RVA: 0x707AE30
        public void SamplePositionFilter(){} // RVA: 0x707AF90
        public void FindClosestEdgeFilter(){} // RVA: 0x707B0B0
        public void RaycastFilter(){} // RVA: 0x707B1D0
        public void CalculatePathFilterInternal(){} // RVA: 0x707B330
        public void CreateSettings(){} // RVA: 0x707B3D0
        public void RemoveSettings(){} // RVA: 0x707B440
        public void GetSettingsByID(){} // RVA: 0x707B490
        public void GetSettingsCount(){} // RVA: 0x707B510
        public void GetSettingsByIndex(){} // RVA: 0x707B560
        public void GetSettingsNameFromID(){} // RVA: 0x707B5E0
        public void RemoveAllNavMeshData(){} // RVA: 0x707B630
        public void Raycast_Injected(){} // RVA: 0x707B680
        public void CalculatePathInternal_Injected(){} // RVA: 0x707B700
        public void FindClosestEdge_Injected(){} // RVA: 0x707B780
        public void SamplePosition_Injected(){} // RVA: 0x707B7F0
        public void CalculateTriangulation_Injected(){} // RVA: 0x707B870
        public void AddNavMeshDataTransformedInternal_Injected(){} // RVA: 0x707B8C0
        public void AddLinkInternal_Injected(){} // RVA: 0x707B930
        public void SamplePositionFilter_Injected(){} // RVA: 0x707B9A0
        public void FindClosestEdgeFilter_Injected(){} // RVA: 0x707BA30
        public void RaycastFilter_Injected(){} // RVA: 0x707BAB0
        public void CalculatePathFilterInternal_Injected(){} // RVA: 0x707BB40
        public void CreateSettings_Injected(){} // RVA: 0x707BBD0
        public void GetSettingsByID_Injected(){} // RVA: 0x707BC20
        public void GetSettingsByIndex_Injected(){} // RVA: 0x707BC80
    }

    public class NavMeshAgent
    {
        public object height;
        public object radius;
        public object velocity;
        public object carving;
        public object carveOnlyStationary;
        public object carvingMoveThreshold;
        public object carvingTimeToStationary;
        public object shape;
        public object center;
        public object size;
        public object ԟu;
        public object get_offMeshLink;
        public object valid;
        public object activated;
        public object linkType;

        // ── Methods ──
        public void SetDestination(){} // RVA: 0x7076070
        public void get_destination(){} // RVA: 0x70760D0
        public void set_destination(){} // RVA: 0x7076140
        public void get_stoppingDistance(){} // RVA: 0x70761A0
        public void set_stoppingDistance(){} // RVA: 0x70761F0
        public void get_velocity(){} // RVA: 0x7076250
        public void set_velocity(){} // RVA: 0x70762C0
        public void get_nextPosition(){} // RVA: 0x7076320
        public void set_nextPosition(){} // RVA: 0x7076390
        public void get_steeringTarget(){} // RVA: 0x70763F0
        public void get_desiredVelocity(){} // RVA: 0x7076460
        public void get_remainingDistance(){} // RVA: 0x70764D0
        public void get_baseOffset(){} // RVA: 0x7076520
        public void set_baseOffset(){} // RVA: 0x7076570
        public void get_isOnOffMeshLink(){} // RVA: 0x70765D0
        public void ActivateCurrentOffMeshLink(){} // RVA: 0x7076620
        public void get_currentOffMeshLinkData(){} // RVA: 0x7076680
        public void GetCurrentOffMeshLinkDataInternal(){} // RVA: 0x7076720
        public void get_nextOffMeshLinkData(){} // RVA: 0x70767A0
        public void GetNextOffMeshLinkDataInternal(){} // RVA: 0x7076840
        public void CompleteOffMeshLink(){} // RVA: 0x70768C0
        public void get_autoTraverseOffMeshLink(){} // RVA: 0x7076910
        public void set_autoTraverseOffMeshLink(){} // RVA: 0x7076960
        public void get_autoBraking(){} // RVA: 0x70769C0
        public void set_autoBraking(){} // RVA: 0x7076A10
        public void get_autoRepath(){} // RVA: 0x7076A70
        public void set_autoRepath(){} // RVA: 0x7076AC0
        public void get_hasPath(){} // RVA: 0x7076B20
        public void get_pathPending(){} // RVA: 0x7076B70
        public void get_isPathStale(){} // RVA: 0x7076BC0
        public void get_pathStatus(){} // RVA: 0x7076C10
        public void get_pathEndPosition(){} // RVA: 0x7076C60
        public void Warp(){} // RVA: 0x7076CD0
        public void Move(){} // RVA: 0x7076D30
        public void Stop(){} // RVA: 0x7076D90 | overloaded x2
        public void Resume(){} // RVA: 0x7076DE0
        public void get_isStopped(){} // RVA: 0x7076E30
        public void set_isStopped(){} // RVA: 0x7076E80
        public void ResetPath(){} // RVA: 0x7076EE0
        public void SetPath(){} // RVA: 0x7076F30
        public void get_path(){} // RVA: 0x7076F90
        public void set_path(){} // RVA: 0x7077060
        public void CopyPathTo(){} // RVA: 0x7077100
        public void FindClosestEdge(){} // RVA: 0x7077160
        public void Raycast(){} // RVA: 0x70771C0
        public void CalculatePath(){} // RVA: 0x7077230
        public void CalculatePathInternal(){} // RVA: 0x70772D0
        public void SamplePathPosition(){} // RVA: 0x7077340
        public void SetLayerCost(){} // RVA: 0x70773C0
        public void GetLayerCost(){} // RVA: 0x7077430
        public void SetAreaCost(){} // RVA: 0x7077490
        public void GetAreaCost(){} // RVA: 0x7077500
        public void get_navMeshOwner(){} // RVA: 0x7077560
        public void get_agentTypeID(){} // RVA: 0x70775B0
        public void set_agentTypeID(){} // RVA: 0x7077600
        public void GetOwnerInternal(){} // RVA: 0x7077560
        public void get_walkableMask(){} // RVA: 0x7077660
        public void set_walkableMask(){} // RVA: 0x70776B0
        public void get_areaMask(){} // RVA: 0x7077660
        public void set_areaMask(){} // RVA: 0x70776B0
        public void get_speed(){} // RVA: 0x7077710
        public void set_speed(){} // RVA: 0x7077760
        public void get_angularSpeed(){} // RVA: 0x70777C0
        public void set_angularSpeed(){} // RVA: 0x7077810
        public void get_acceleration(){} // RVA: 0x7077870
        public void set_acceleration(){} // RVA: 0x70778C0
        public void get_updatePosition(){} // RVA: 0x7077920
        public void set_updatePosition(){} // RVA: 0x7077970
        public void get_updateRotation(){} // RVA: 0x70779D0
        public void set_updateRotation(){} // RVA: 0x7077A20
        public void get_updateUpAxis(){} // RVA: 0x7077A80
        public void set_updateUpAxis(){} // RVA: 0x7077AD0
        public void get_radius(){} // RVA: 0x7077B30
        public void set_radius(){} // RVA: 0x7077B80
        public void get_height(){} // RVA: 0x7077BE0
        public void set_height(){} // RVA: 0x7077C30
        public void get_obstacleAvoidanceType(){} // RVA: 0x7077C90
        public void set_obstacleAvoidanceType(){} // RVA: 0x7077CE0
        public void get_avoidancePriority(){} // RVA: 0x7077D40
        public void set_avoidancePriority(){} // RVA: 0x7077D90
        public void get_isOnNavMesh(){} // RVA: 0x7077DF0
        public void .ctor(){} // RVA: 0x2DDD50
        public void SetDestination_Injected(){} // RVA: 0x7077E40
        public void get_destination_Injected(){} // RVA: 0x7077EA0
        public void set_destination_Injected(){} // RVA: 0x7077F00
        public void get_velocity_Injected(){} // RVA: 0x7077F60
        public void set_velocity_Injected(){} // RVA: 0x7077FC0
        public void get_nextPosition_Injected(){} // RVA: 0x7078020
        public void set_nextPosition_Injected(){} // RVA: 0x7078080
        public void get_steeringTarget_Injected(){} // RVA: 0x70780E0
        public void get_desiredVelocity_Injected(){} // RVA: 0x7078140
        public void GetCurrentOffMeshLinkDataInternal_Injected(){} // RVA: 0x70781A0
        public void GetNextOffMeshLinkDataInternal_Injected(){} // RVA: 0x7078200
        public void get_pathEndPosition_Injected(){} // RVA: 0x7078260
        public void Warp_Injected(){} // RVA: 0x70782C0
        public void Move_Injected(){} // RVA: 0x7078320
        public void Raycast_Injected(){} // RVA: 0x7078380
        public void CalculatePathInternal_Injected(){} // RVA: 0x70783F0
    }

    public class NavMeshBuildDebugSettings
    {
    }

    public class NavMeshBuildMarkup
    {
        public object agentTypeID;
        public object agentRadius;
        public object agentHeight;
        public object agentSlope;
        public object agentClimb;
        public object ledgeDropHeight;
        public object maxJumpAcrossDistance;

        // ── Methods ──
        public void set_overrideArea(){} // RVA: 0x623C350
        public void set_area(){} // RVA: 0x19689D0
        public void set_ignoreFromBuild(){} // RVA: 0x707C370
        public void set_overrideGenerateLinks(){} // RVA: 0x707C380
        public void set_generateLinks(){} // RVA: 0x707C390
        public void set_applyToChildren(){} // RVA: 0x707C3A0
        public void set_root(){} // RVA: 0x707C3B0
    }

    public class NavMeshBuildSettings
    {
        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x67FD0D0
        public void set_agentTypeID(){} // RVA: 0x833580
        public void get_agentRadius(){} // RVA: 0x300D30
        public void set_agentRadius(){} // RVA: 0x1F78350
        public void get_agentHeight(){} // RVA: 0x300CF0
        public void set_agentHeight(){} // RVA: 0x1F78340
        public void get_agentSlope(){} // RVA: 0x300D00
        public void set_agentSlope(){} // RVA: 0x1F78380
        public void get_agentClimb(){} // RVA: 0x707C4A0
        public void set_agentClimb(){} // RVA: 0x407330
        public void get_ledgeDropHeight(){} // RVA: 0x2EECAB0
        public void set_ledgeDropHeight(){} // RVA: 0x407350
        public void get_maxJumpAcrossDistance(){} // RVA: 0x70794A0
        public void set_maxJumpAcrossDistance(){} // RVA: 0x2F84D0
        public void get_minRegionArea(){} // RVA: 0x707C4B0
        public void set_minRegionArea(){} // RVA: 0x3AA580
        public void get_overrideVoxelSize(){} // RVA: 0x70794B0
        public void set_overrideVoxelSize(){} // RVA: 0x70794C0
        public void get_voxelSize(){} // RVA: 0x707C4C0
        public void set_voxelSize(){} // RVA: 0x44AF60
        public void get_overrideTileSize(){} // RVA: 0x707C4D0
        public void set_overrideTileSize(){} // RVA: 0x707C4E0
        public void get_tileSize(){} // RVA: 0x707C4F0
        public void set_tileSize(){} // RVA: 0x1AFCF60
        public void get_preserveTilesOutsideBounds(){} // RVA: 0x707C500
        public void set_preserveTilesOutsideBounds(){} // RVA: 0x707C510
        public void get_buildHeightMesh(){} // RVA: 0x707C520
        public void set_buildHeightMesh(){} // RVA: 0x707C530
        public void get_debug(){} // RVA: 0x707C540
        public void set_debug(){} // RVA: 0x4424F0
        public void ValidationReport(){} // RVA: 0x707C550
        public void InternalValidationReport(){} // RVA: 0x707C5E0
        public void InternalValidationReport_Injected(){} // RVA: 0x707C640
    }

    public class NavMeshBuildSource
    {
        // ── Methods ──
        public void get_transform(){} // RVA: 0x707C1A0
        public void set_transform(){} // RVA: 0x707C1D0
        public void get_size(){} // RVA: 0x707C1F0
        public void set_size(){} // RVA: 0x707C210
        public void get_shape(){} // RVA: 0x707C220
        public void set_shape(){} // RVA: 0x1D75D90
        public void set_area(){} // RVA: 0x65F570
        public void get_sourceObject(){} // RVA: 0x707C230
        public void get_component(){} // RVA: 0x707C280
        public void InternalGetComponent(){} // RVA: 0x707C2D0
        public void InternalGetObject(){} // RVA: 0x707C320
    }

    public class NavMeshBuilder
    {
        // ── Methods ──
        public void CollectSources(){} // RVA: 0x7075630 | overloaded x2
        public void CollectSourcesInternal(){} // RVA: 0x7075850
        public void BuildNavMeshData(){} // RVA: 0x7075910
        public void UpdateNavMeshDataListInternal(){} // RVA: 0x7075BB0
        public void UpdateNavMeshDataAsync(){} // RVA: 0x7075C30
        public void UpdateNavMeshDataAsyncListInternal(){} // RVA: 0x7075E50
        public void CollectSourcesInternal_Injected(){} // RVA: 0x7075ED0
        public void UpdateNavMeshDataListInternal_Injected(){} // RVA: 0x7075F70
        public void UpdateNavMeshDataAsyncListInternal_Injected(){} // RVA: 0x7075FF0
    }

    public class NavMeshData
    {
        public object bounciness;
        public object dynamicFriction;
        public object staticFriction;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7079560 | overloaded x2
        public void Internal_Create(){} // RVA: 0x7079600
        public void get_sourceBounds(){} // RVA: 0x7079660
        public void get_position(){} // RVA: 0x70796D0
        public void set_position(){} // RVA: 0x7079740
        public void get_rotation(){} // RVA: 0x70797A0
        public void set_rotation(){} // RVA: 0x7079810
        public void get_sourceBounds_Injected(){} // RVA: 0x7079870
        public void get_position_Injected(){} // RVA: 0x70798D0
        public void set_position_Injected(){} // RVA: 0x7079930
        public void get_rotation_Injected(){} // RVA: 0x7079990
        public void set_rotation_Injected(){} // RVA: 0x70799F0
    }

    public class NavMeshDataInstance
    {
        public object startPosition;
        public object endPosition;
        public object costModifier;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7079A50
        public void get_id(){} // RVA: 0x19689B0
        public void set_id(){} // RVA: 0x833580
        public void Remove(){} // RVA: 0x7079AC0
        public void get_owner(){} // RVA: 0x7079B10
        public void set_owner(){} // RVA: 0x7079B60
    }

    public class NavMeshHit
    {
        public object valid;
        public object id;
        public object owner;

        // ── Methods ──
        public void get_position(){} // RVA: 0x7079450
        public void set_position(){} // RVA: 0x210E450
        public void get_normal(){} // RVA: 0x7079470
        public void set_normal(){} // RVA: 0x7079490
        public void get_distance(){} // RVA: 0x70794A0
        public void set_distance(){} // RVA: 0x2F84D0
        public void get_mask(){} // RVA: 0x33B6D30
        public void set_mask(){} // RVA: 0x1989FD0
        public void get_hit(){} // RVA: 0x70794B0
        public void set_hit(){} // RVA: 0x70794C0
    }

    public class NavMeshLinkData
    {
        public object valid;
        public object id;
        public object owner;

        // ── Methods ──
        public void get_startPosition(){} // RVA: 0x7079450
        public void set_startPosition(){} // RVA: 0x210E450
        public void get_endPosition(){} // RVA: 0x7079470
        public void set_endPosition(){} // RVA: 0x7079490
        public void get_costModifier(){} // RVA: 0x70794A0
        public void set_costModifier(){} // RVA: 0x2F84D0
        public void get_bidirectional(){} // RVA: 0x7079CD0
        public void set_bidirectional(){} // RVA: 0x7079CE0
        public void get_width(){} // RVA: 0x7079CF0
        public void set_width(){} // RVA: 0xFEC7A0
        public void get_area(){} // RVA: 0x7079D00
        public void set_area(){} // RVA: 0x16E1F00
        public void get_agentTypeID(){} // RVA: 0x43DB8C0
        public void set_agentTypeID(){} // RVA: 0xA53440
    }

    public class NavMeshLinkInstance
    {
        public object costs;
        public object areaMask;
        public object agentTypeID;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7079D10
        public void get_id(){} // RVA: 0x19689B0
        public void set_id(){} // RVA: 0x833580
        public void Remove(){} // RVA: 0x7079D80
        public void get_owner(){} // RVA: 0x7079DD0
        public void set_owner(){} // RVA: 0x7079E20
    }

    public class NavMeshObstacle
    {
        public object activated;
        public object occupied;
        public object costOverride;
        public object biDirectional;
        public object navMeshLayer;
        public object area;
        public object autoUpdatePositions;
        public object startTransform;
        public object endTransform;

        // ── Methods ──
        public void get_height(){} // RVA: 0x7078460
        public void set_height(){} // RVA: 0x70784B0
        public void get_radius(){} // RVA: 0x7078510
        public void set_radius(){} // RVA: 0x7078560
        public void get_velocity(){} // RVA: 0x70785C0
        public void set_velocity(){} // RVA: 0x7078630
        public void get_carving(){} // RVA: 0x7078690
        public void set_carving(){} // RVA: 0x70786E0
        public void get_carveOnlyStationary(){} // RVA: 0x7078740
        public void set_carveOnlyStationary(){} // RVA: 0x7078790
        public void get_carvingMoveThreshold(){} // RVA: 0x70787F0
        public void set_carvingMoveThreshold(){} // RVA: 0x7078840
        public void get_carvingTimeToStationary(){} // RVA: 0x70788A0
        public void set_carvingTimeToStationary(){} // RVA: 0x70788F0
        public void get_shape(){} // RVA: 0x7078950
        public void set_shape(){} // RVA: 0x70789A0
        public void get_center(){} // RVA: 0x7078A00
        public void set_center(){} // RVA: 0x7078A70
        public void get_size(){} // RVA: 0x7078AD0
        public void set_size(){} // RVA: 0x7078B40
        public void FitExtents(){} // RVA: 0x7078BA0
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_velocity_Injected(){} // RVA: 0x7078BF0
        public void set_velocity_Injected(){} // RVA: 0x7078C50
        public void get_center_Injected(){} // RVA: 0x7078CB0
        public void set_center_Injected(){} // RVA: 0x7078D10
        public void get_size_Injected(){} // RVA: 0x7078D70
        public void set_size_Injected(){} // RVA: 0x7078DD0
    }

    public class NavMeshPath
    {
        public object PN00;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x707BCE0
        public void Finalize(){} // RVA: 0x707BD30
        public void InitializeNavMeshPath(){} // RVA: 0x707BDC0
        public void DestroyNavMeshPath(){} // RVA: 0x707BE10
        public void GetCornersNonAlloc(){} // RVA: 0x707BE60
        public void CalculateCornersInternal(){} // RVA: 0x707BEC0
        public void ClearCornersInternal(){} // RVA: 0x707BF10
        public void ClearCorners(){} // RVA: 0x707BF60
        public void CalculateCorners(){} // RVA: 0x707C000
        public void get_corners(){} // RVA: 0x707C0A0
        public void get_status(){} // RVA: 0x707C150
    }

    public class NavMeshQueryFilter
    {
        public object corners;
        public object status;

        // ── Methods ──
        public void get_costs(){} // RVA: 0x1AD4690
        public void set_costs(){} // RVA: 0x100A2F0
        public void get_areaMask(){} // RVA: 0x1EA9890
        public void set_areaMask(){} // RVA: 0x1EA98A0
        public void get_agentTypeID(){} // RVA: 0x1EA98B0
        public void set_agentTypeID(){} // RVA: 0x1EA98C0
        public void GetAreaCost(){} // RVA: 0x7079F90
        public void SetAreaCost(){} // RVA: 0x707A070
    }

    public class NavMeshTriangulation
    {
    }

    public class OffMeshLink
    {
        // ── Methods ──
        public void get_activated(){} // RVA: 0x7078EE0
        public void set_activated(){} // RVA: 0x7078F30
        public void get_occupied(){} // RVA: 0x7078F90
        public void get_costOverride(){} // RVA: 0x7078FE0
        public void set_costOverride(){} // RVA: 0x7079030
        public void get_biDirectional(){} // RVA: 0x7079090
        public void set_biDirectional(){} // RVA: 0x70790E0
        public void UpdatePositions(){} // RVA: 0x7079140
        public void get_navMeshLayer(){} // RVA: 0x7079190
        public void set_navMeshLayer(){} // RVA: 0x70791E0
        public void get_area(){} // RVA: 0x7079190
        public void set_area(){} // RVA: 0x70791E0
        public void get_autoUpdatePositions(){} // RVA: 0x7079240
        public void set_autoUpdatePositions(){} // RVA: 0x7079290
        public void get_startTransform(){} // RVA: 0x70792F0
        public void set_startTransform(){} // RVA: 0x7079340
        public void get_endTransform(){} // RVA: 0x70793A0
        public void set_endTransform(){} // RVA: 0x70793F0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class OffMeshLinkData
    {
        public object position;
        public object normal;
        public object distance;
        public object mask;
        public object hit;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x61D2420
        public void get_activated(){} // RVA: 0x7078E30
        public void get_linkType(){} // RVA: 0x1EA98B0
        public void get_startPos(){} // RVA: 0x2FA8D0
        public void get_endPos(){} // RVA: 0x6E9FE70
        public void get_offMeshLink(){} // RVA: 0x7078E40
        public void GetOffMeshLinkInternal(){} // RVA: 0x7078E90
    }

}