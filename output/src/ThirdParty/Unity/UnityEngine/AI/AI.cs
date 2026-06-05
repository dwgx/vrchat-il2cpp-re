// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.AI
// Classes: 18
// Methods: 340

namespace ThirdParty.Unity.UnityEngine.AI
{
    public class NavMesh
    {
        // ── Methods ──
        public void Internal_CallOnNavMeshPreUpdate(){} // RVA: 0x7FFAF9B2A160
        public void Raycast(){} // RVA: 0x7FFAF9B2B130 | overloaded x2
        public void CalculatePath(){} // RVA: 0x7FFAF9B2B260 | overloaded x2
        public void CalculatePathInternal(){} // RVA: 0x7FFAF9B2A300
        public void FindClosestEdge(){} // RVA: 0x7FFAF9B2B020 | overloaded x2
        public void SamplePosition(){} // RVA: 0x7FFAF9B2AEF0 | overloaded x2
        public void SetAreaCost(){} // RVA: 0x7FFAF9B2A470
        public void GetAreaCost(){} // RVA: 0x7FFAF9B2A4D0
        public void GetAreaFromName(){} // RVA: 0x7FFAF9B2A520
        public void CalculateTriangulation(){} // RVA: 0x7FFAF9B2A570
        public void get_avoidancePredictionTime(){} // RVA: 0x7FFAF9B2A5D0
        public void set_avoidancePredictionTime(){} // RVA: 0x7FFAF9B2A620
        public void AddNavMeshData(){} // RVA: 0x7FFAF9B2A7D0 | overloaded x2
        public void RemoveNavMeshData(){} // RVA: 0x7FFAF9B2A960
        public void IsValidNavMeshDataHandle(){} // RVA: 0x7FFAF9B2A9B0
        public void IsValidLinkHandle(){} // RVA: 0x7FFAF9B2AA00
        public void InternalGetOwner(){} // RVA: 0x7FFAF9B2AA50
        public void InternalSetOwner(){} // RVA: 0x7FFAF9B2AAA0
        public void InternalGetLinkOwner(){} // RVA: 0x7FFAF9B2AB00
        public void InternalSetLinkOwner(){} // RVA: 0x7FFAF9B2AB50
        public void AddNavMeshDataInternal(){} // RVA: 0x7FFAF9B2ABB0
        public void AddNavMeshDataTransformedInternal(){} // RVA: 0x7FFAF9B2AC00
        public void RemoveNavMeshDataInternal(){} // RVA: 0x7FFAF9B2A960
        public void AddLink(){} // RVA: 0x7FFAF9B2AD90 | overloaded x2
        public void RemoveLink(){} // RVA: 0x7FFAF9B2AE30
        public void AddLinkInternal(){} // RVA: 0x7FFAF9B2AE80
        public void RemoveLinkInternal(){} // RVA: 0x7FFAF9B2AE30
        public void SamplePositionFilter(){} // RVA: 0x7FFAF9B2AF90
        public void FindClosestEdgeFilter(){} // RVA: 0x7FFAF9B2B0B0
        public void RaycastFilter(){} // RVA: 0x7FFAF9B2B1D0
        public void CalculatePathFilterInternal(){} // RVA: 0x7FFAF9B2B330
        public void CreateSettings(){} // RVA: 0x7FFAF9B2B3D0
        public void RemoveSettings(){} // RVA: 0x7FFAF9B2B440
        public void GetSettingsByID(){} // RVA: 0x7FFAF9B2B490
        public void GetSettingsCount(){} // RVA: 0x7FFAF9B2B510
        public void GetSettingsByIndex(){} // RVA: 0x7FFAF9B2B560
        public void GetSettingsNameFromID(){} // RVA: 0x7FFAF9B2B5E0
        public void RemoveAllNavMeshData(){} // RVA: 0x7FFAF9B2B630
        public void Raycast_Injected(){} // RVA: 0x7FFAF9B2B680
        public void CalculatePathInternal_Injected(){} // RVA: 0x7FFAF9B2B700
        public void FindClosestEdge_Injected(){} // RVA: 0x7FFAF9B2B780
        public void SamplePosition_Injected(){} // RVA: 0x7FFAF9B2B7F0
        public void CalculateTriangulation_Injected(){} // RVA: 0x7FFAF9B2B870
        public void AddNavMeshDataTransformedInternal_Injected(){} // RVA: 0x7FFAF9B2B8C0
        public void AddLinkInternal_Injected(){} // RVA: 0x7FFAF9B2B930
        public void SamplePositionFilter_Injected(){} // RVA: 0x7FFAF9B2B9A0
        public void FindClosestEdgeFilter_Injected(){} // RVA: 0x7FFAF9B2BA30
        public void RaycastFilter_Injected(){} // RVA: 0x7FFAF9B2BAB0
        public void CalculatePathFilterInternal_Injected(){} // RVA: 0x7FFAF9B2BB40
        public void CreateSettings_Injected(){} // RVA: 0x7FFAF9B2BBD0
        public void GetSettingsByID_Injected(){} // RVA: 0x7FFAF9B2BC20
        public void GetSettingsByIndex_Injected(){} // RVA: 0x7FFAF9B2BC80
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
        public void SetDestination(){} // RVA: 0x7FFAF9B26070
        public void get_destination(){} // RVA: 0x7FFAF9B260D0
        public void set_destination(){} // RVA: 0x7FFAF9B26140
        public void get_stoppingDistance(){} // RVA: 0x7FFAF9B261A0
        public void set_stoppingDistance(){} // RVA: 0x7FFAF9B261F0
        public void get_velocity(){} // RVA: 0x7FFAF9B26250
        public void set_velocity(){} // RVA: 0x7FFAF9B262C0
        public void get_nextPosition(){} // RVA: 0x7FFAF9B26320
        public void set_nextPosition(){} // RVA: 0x7FFAF9B26390
        public void get_steeringTarget(){} // RVA: 0x7FFAF9B263F0
        public void get_desiredVelocity(){} // RVA: 0x7FFAF9B26460
        public void get_remainingDistance(){} // RVA: 0x7FFAF9B264D0
        public void get_baseOffset(){} // RVA: 0x7FFAF9B26520
        public void set_baseOffset(){} // RVA: 0x7FFAF9B26570
        public void get_isOnOffMeshLink(){} // RVA: 0x7FFAF9B265D0
        public void ActivateCurrentOffMeshLink(){} // RVA: 0x7FFAF9B26620
        public void get_currentOffMeshLinkData(){} // RVA: 0x7FFAF9B26680
        public void GetCurrentOffMeshLinkDataInternal(){} // RVA: 0x7FFAF9B26720
        public void get_nextOffMeshLinkData(){} // RVA: 0x7FFAF9B267A0
        public void GetNextOffMeshLinkDataInternal(){} // RVA: 0x7FFAF9B26840
        public void CompleteOffMeshLink(){} // RVA: 0x7FFAF9B268C0
        public void get_autoTraverseOffMeshLink(){} // RVA: 0x7FFAF9B26910
        public void set_autoTraverseOffMeshLink(){} // RVA: 0x7FFAF9B26960
        public void get_autoBraking(){} // RVA: 0x7FFAF9B269C0
        public void set_autoBraking(){} // RVA: 0x7FFAF9B26A10
        public void get_autoRepath(){} // RVA: 0x7FFAF9B26A70
        public void set_autoRepath(){} // RVA: 0x7FFAF9B26AC0
        public void get_hasPath(){} // RVA: 0x7FFAF9B26B20
        public void get_pathPending(){} // RVA: 0x7FFAF9B26B70
        public void get_isPathStale(){} // RVA: 0x7FFAF9B26BC0
        public void get_pathStatus(){} // RVA: 0x7FFAF9B26C10
        public void get_pathEndPosition(){} // RVA: 0x7FFAF9B26C60
        public void Warp(){} // RVA: 0x7FFAF9B26CD0
        public void Move(){} // RVA: 0x7FFAF9B26D30
        public void Stop(){} // RVA: 0x7FFAF9B26D90 | overloaded x2
        public void Resume(){} // RVA: 0x7FFAF9B26DE0
        public void get_isStopped(){} // RVA: 0x7FFAF9B26E30
        public void set_isStopped(){} // RVA: 0x7FFAF9B26E80
        public void ResetPath(){} // RVA: 0x7FFAF9B26EE0
        public void SetPath(){} // RVA: 0x7FFAF9B26F30
        public void get_path(){} // RVA: 0x7FFAF9B26F90
        public void set_path(){} // RVA: 0x7FFAF9B27060
        public void CopyPathTo(){} // RVA: 0x7FFAF9B27100
        public void FindClosestEdge(){} // RVA: 0x7FFAF9B27160
        public void Raycast(){} // RVA: 0x7FFAF9B271C0
        public void CalculatePath(){} // RVA: 0x7FFAF9B27230
        public void CalculatePathInternal(){} // RVA: 0x7FFAF9B272D0
        public void SamplePathPosition(){} // RVA: 0x7FFAF9B27340
        public void SetLayerCost(){} // RVA: 0x7FFAF9B273C0
        public void GetLayerCost(){} // RVA: 0x7FFAF9B27430
        public void SetAreaCost(){} // RVA: 0x7FFAF9B27490
        public void GetAreaCost(){} // RVA: 0x7FFAF9B27500
        public void get_navMeshOwner(){} // RVA: 0x7FFAF9B27560
        public void get_agentTypeID(){} // RVA: 0x7FFAF9B275B0
        public void set_agentTypeID(){} // RVA: 0x7FFAF9B27600
        public void GetOwnerInternal(){} // RVA: 0x7FFAF9B27560
        public void get_walkableMask(){} // RVA: 0x7FFAF9B27660
        public void set_walkableMask(){} // RVA: 0x7FFAF9B276B0
        public void get_areaMask(){} // RVA: 0x7FFAF9B27660
        public void set_areaMask(){} // RVA: 0x7FFAF9B276B0
        public void get_speed(){} // RVA: 0x7FFAF9B27710
        public void set_speed(){} // RVA: 0x7FFAF9B27760
        public void get_angularSpeed(){} // RVA: 0x7FFAF9B277C0
        public void set_angularSpeed(){} // RVA: 0x7FFAF9B27810
        public void get_acceleration(){} // RVA: 0x7FFAF9B27870
        public void set_acceleration(){} // RVA: 0x7FFAF9B278C0
        public void get_updatePosition(){} // RVA: 0x7FFAF9B27920
        public void set_updatePosition(){} // RVA: 0x7FFAF9B27970
        public void get_updateRotation(){} // RVA: 0x7FFAF9B279D0
        public void set_updateRotation(){} // RVA: 0x7FFAF9B27A20
        public void get_updateUpAxis(){} // RVA: 0x7FFAF9B27A80
        public void set_updateUpAxis(){} // RVA: 0x7FFAF9B27AD0
        public void get_radius(){} // RVA: 0x7FFAF9B27B30
        public void set_radius(){} // RVA: 0x7FFAF9B27B80
        public void get_height(){} // RVA: 0x7FFAF9B27BE0
        public void set_height(){} // RVA: 0x7FFAF9B27C30
        public void get_obstacleAvoidanceType(){} // RVA: 0x7FFAF9B27C90
        public void set_obstacleAvoidanceType(){} // RVA: 0x7FFAF9B27CE0
        public void get_avoidancePriority(){} // RVA: 0x7FFAF9B27D40
        public void set_avoidancePriority(){} // RVA: 0x7FFAF9B27D90
        public void get_isOnNavMesh(){} // RVA: 0x7FFAF9B27DF0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void SetDestination_Injected(){} // RVA: 0x7FFAF9B27E40
        public void get_destination_Injected(){} // RVA: 0x7FFAF9B27EA0
        public void set_destination_Injected(){} // RVA: 0x7FFAF9B27F00
        public void get_velocity_Injected(){} // RVA: 0x7FFAF9B27F60
        public void set_velocity_Injected(){} // RVA: 0x7FFAF9B27FC0
        public void get_nextPosition_Injected(){} // RVA: 0x7FFAF9B28020
        public void set_nextPosition_Injected(){} // RVA: 0x7FFAF9B28080
        public void get_steeringTarget_Injected(){} // RVA: 0x7FFAF9B280E0
        public void get_desiredVelocity_Injected(){} // RVA: 0x7FFAF9B28140
        public void GetCurrentOffMeshLinkDataInternal_Injected(){} // RVA: 0x7FFAF9B281A0
        public void GetNextOffMeshLinkDataInternal_Injected(){} // RVA: 0x7FFAF9B28200
        public void get_pathEndPosition_Injected(){} // RVA: 0x7FFAF9B28260
        public void Warp_Injected(){} // RVA: 0x7FFAF9B282C0
        public void Move_Injected(){} // RVA: 0x7FFAF9B28320
        public void Raycast_Injected(){} // RVA: 0x7FFAF9B28380
        public void CalculatePathInternal_Injected(){} // RVA: 0x7FFAF9B283F0
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
        public void set_overrideArea(){} // RVA: 0x7FFAF8CEC350
        public void set_area(){} // RVA: 0x7FFAF44189D0
        public void set_ignoreFromBuild(){} // RVA: 0x7FFAF9B2C370
        public void set_overrideGenerateLinks(){} // RVA: 0x7FFAF9B2C380
        public void set_generateLinks(){} // RVA: 0x7FFAF9B2C390
        public void set_applyToChildren(){} // RVA: 0x7FFAF9B2C3A0
        public void set_root(){} // RVA: 0x7FFAF9B2C3B0
    }

    public class NavMeshBuildSettings
    {
        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x7FFAF92AD0D0
        public void set_agentTypeID(){} // RVA: 0x7FFAF32E3580
        public void get_agentRadius(){} // RVA: 0x7FFAF2DB0D30
        public void set_agentRadius(){} // RVA: 0x7FFAF4A28350
        public void get_agentHeight(){} // RVA: 0x7FFAF2DB0CF0
        public void set_agentHeight(){} // RVA: 0x7FFAF4A28340
        public void get_agentSlope(){} // RVA: 0x7FFAF2DB0D00
        public void set_agentSlope(){} // RVA: 0x7FFAF4A28380
        public void get_agentClimb(){} // RVA: 0x7FFAF9B2C4A0
        public void set_agentClimb(){} // RVA: 0x7FFAF2EB7330
        public void get_ledgeDropHeight(){} // RVA: 0x7FFAF599CAB0
        public void set_ledgeDropHeight(){} // RVA: 0x7FFAF2EB7350
        public void get_maxJumpAcrossDistance(){} // RVA: 0x7FFAF9B294A0
        public void set_maxJumpAcrossDistance(){} // RVA: 0x7FFAF2DA84D0
        public void get_minRegionArea(){} // RVA: 0x7FFAF9B2C4B0
        public void set_minRegionArea(){} // RVA: 0x7FFAF2E5A580
        public void get_overrideVoxelSize(){} // RVA: 0x7FFAF9B294B0
        public void set_overrideVoxelSize(){} // RVA: 0x7FFAF9B294C0
        public void get_voxelSize(){} // RVA: 0x7FFAF9B2C4C0
        public void set_voxelSize(){} // RVA: 0x7FFAF2EFAF60
        public void get_overrideTileSize(){} // RVA: 0x7FFAF9B2C4D0
        public void set_overrideTileSize(){} // RVA: 0x7FFAF9B2C4E0
        public void get_tileSize(){} // RVA: 0x7FFAF9B2C4F0
        public void set_tileSize(){} // RVA: 0x7FFAF45ACF60
        public void get_preserveTilesOutsideBounds(){} // RVA: 0x7FFAF9B2C500
        public void set_preserveTilesOutsideBounds(){} // RVA: 0x7FFAF9B2C510
        public void get_buildHeightMesh(){} // RVA: 0x7FFAF9B2C520
        public void set_buildHeightMesh(){} // RVA: 0x7FFAF9B2C530
        public void get_debug(){} // RVA: 0x7FFAF9B2C540
        public void set_debug(){} // RVA: 0x7FFAF2EF24F0
        public void ValidationReport(){} // RVA: 0x7FFAF9B2C550
        public void InternalValidationReport(){} // RVA: 0x7FFAF9B2C5E0
        public void InternalValidationReport_Injected(){} // RVA: 0x7FFAF9B2C640
    }

    public class NavMeshBuildSource
    {
        // ── Methods ──
        public void get_transform(){} // RVA: 0x7FFAF9B2C1A0
        public void set_transform(){} // RVA: 0x7FFAF9B2C1D0
        public void get_size(){} // RVA: 0x7FFAF9B2C1F0
        public void set_size(){} // RVA: 0x7FFAF9B2C210
        public void get_shape(){} // RVA: 0x7FFAF9B2C220
        public void set_shape(){} // RVA: 0x7FFAF4825D90
        public void set_area(){} // RVA: 0x7FFAF310F570
        public void get_sourceObject(){} // RVA: 0x7FFAF9B2C230
        public void get_component(){} // RVA: 0x7FFAF9B2C280
        public void InternalGetComponent(){} // RVA: 0x7FFAF9B2C2D0
        public void InternalGetObject(){} // RVA: 0x7FFAF9B2C320
    }

    public class NavMeshBuilder
    {
        // ── Methods ──
        public void CollectSources(){} // RVA: 0x7FFAF9B25630 | overloaded x2
        public void CollectSourcesInternal(){} // RVA: 0x7FFAF9B25850
        public void BuildNavMeshData(){} // RVA: 0x7FFAF9B25910
        public void UpdateNavMeshDataListInternal(){} // RVA: 0x7FFAF9B25BB0
        public void UpdateNavMeshDataAsync(){} // RVA: 0x7FFAF9B25C30
        public void UpdateNavMeshDataAsyncListInternal(){} // RVA: 0x7FFAF9B25E50
        public void CollectSourcesInternal_Injected(){} // RVA: 0x7FFAF9B25ED0
        public void UpdateNavMeshDataListInternal_Injected(){} // RVA: 0x7FFAF9B25F70
        public void UpdateNavMeshDataAsyncListInternal_Injected(){} // RVA: 0x7FFAF9B25FF0
    }

    public class NavMeshData
    {
        public object bounciness;
        public object dynamicFriction;
        public object staticFriction;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B29560 | overloaded x2
        public void Internal_Create(){} // RVA: 0x7FFAF9B29600
        public void get_sourceBounds(){} // RVA: 0x7FFAF9B29660
        public void get_position(){} // RVA: 0x7FFAF9B296D0
        public void set_position(){} // RVA: 0x7FFAF9B29740
        public void get_rotation(){} // RVA: 0x7FFAF9B297A0
        public void set_rotation(){} // RVA: 0x7FFAF9B29810
        public void get_sourceBounds_Injected(){} // RVA: 0x7FFAF9B29870
        public void get_position_Injected(){} // RVA: 0x7FFAF9B298D0
        public void set_position_Injected(){} // RVA: 0x7FFAF9B29930
        public void get_rotation_Injected(){} // RVA: 0x7FFAF9B29990
        public void set_rotation_Injected(){} // RVA: 0x7FFAF9B299F0
    }

    public class NavMeshDataInstance
    {
        public object startPosition;
        public object endPosition;
        public object costModifier;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFAF9B29A50
        public void get_id(){} // RVA: 0x7FFAF44189B0
        public void set_id(){} // RVA: 0x7FFAF32E3580
        public void Remove(){} // RVA: 0x7FFAF9B29AC0
        public void get_owner(){} // RVA: 0x7FFAF9B29B10
        public void set_owner(){} // RVA: 0x7FFAF9B29B60
    }

    public class NavMeshHit
    {
        public object valid;
        public object id;
        public object owner;

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFAF9B29450
        public void set_position(){} // RVA: 0x7FFAF4BBE450
        public void get_normal(){} // RVA: 0x7FFAF9B29470
        public void set_normal(){} // RVA: 0x7FFAF9B29490
        public void get_distance(){} // RVA: 0x7FFAF9B294A0
        public void set_distance(){} // RVA: 0x7FFAF2DA84D0
        public void get_mask(){} // RVA: 0x7FFAF5E66D30
        public void set_mask(){} // RVA: 0x7FFAF4439FD0
        public void get_hit(){} // RVA: 0x7FFAF9B294B0
        public void set_hit(){} // RVA: 0x7FFAF9B294C0
    }

    public class NavMeshLinkData
    {
        public object valid;
        public object id;
        public object owner;

        // ── Methods ──
        public void get_startPosition(){} // RVA: 0x7FFAF9B29450
        public void set_startPosition(){} // RVA: 0x7FFAF4BBE450
        public void get_endPosition(){} // RVA: 0x7FFAF9B29470
        public void set_endPosition(){} // RVA: 0x7FFAF9B29490
        public void get_costModifier(){} // RVA: 0x7FFAF9B294A0
        public void set_costModifier(){} // RVA: 0x7FFAF2DA84D0
        public void get_bidirectional(){} // RVA: 0x7FFAF9B29CD0
        public void set_bidirectional(){} // RVA: 0x7FFAF9B29CE0
        public void get_width(){} // RVA: 0x7FFAF9B29CF0
        public void set_width(){} // RVA: 0x7FFAF3A9C7A0
        public void get_area(){} // RVA: 0x7FFAF9B29D00
        public void set_area(){} // RVA: 0x7FFAF4191F00
        public void get_agentTypeID(){} // RVA: 0x7FFAF6E8B8C0
        public void set_agentTypeID(){} // RVA: 0x7FFAF3503440
    }

    public class NavMeshLinkInstance
    {
        public object costs;
        public object areaMask;
        public object agentTypeID;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFAF9B29D10
        public void get_id(){} // RVA: 0x7FFAF44189B0
        public void set_id(){} // RVA: 0x7FFAF32E3580
        public void Remove(){} // RVA: 0x7FFAF9B29D80
        public void get_owner(){} // RVA: 0x7FFAF9B29DD0
        public void set_owner(){} // RVA: 0x7FFAF9B29E20
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
        public void get_height(){} // RVA: 0x7FFAF9B28460
        public void set_height(){} // RVA: 0x7FFAF9B284B0
        public void get_radius(){} // RVA: 0x7FFAF9B28510
        public void set_radius(){} // RVA: 0x7FFAF9B28560
        public void get_velocity(){} // RVA: 0x7FFAF9B285C0
        public void set_velocity(){} // RVA: 0x7FFAF9B28630
        public void get_carving(){} // RVA: 0x7FFAF9B28690
        public void set_carving(){} // RVA: 0x7FFAF9B286E0
        public void get_carveOnlyStationary(){} // RVA: 0x7FFAF9B28740
        public void set_carveOnlyStationary(){} // RVA: 0x7FFAF9B28790
        public void get_carvingMoveThreshold(){} // RVA: 0x7FFAF9B287F0
        public void set_carvingMoveThreshold(){} // RVA: 0x7FFAF9B28840
        public void get_carvingTimeToStationary(){} // RVA: 0x7FFAF9B288A0
        public void set_carvingTimeToStationary(){} // RVA: 0x7FFAF9B288F0
        public void get_shape(){} // RVA: 0x7FFAF9B28950
        public void set_shape(){} // RVA: 0x7FFAF9B289A0
        public void get_center(){} // RVA: 0x7FFAF9B28A00
        public void set_center(){} // RVA: 0x7FFAF9B28A70
        public void get_size(){} // RVA: 0x7FFAF9B28AD0
        public void set_size(){} // RVA: 0x7FFAF9B28B40
        public void FitExtents(){} // RVA: 0x7FFAF9B28BA0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_velocity_Injected(){} // RVA: 0x7FFAF9B28BF0
        public void set_velocity_Injected(){} // RVA: 0x7FFAF9B28C50
        public void get_center_Injected(){} // RVA: 0x7FFAF9B28CB0
        public void set_center_Injected(){} // RVA: 0x7FFAF9B28D10
        public void get_size_Injected(){} // RVA: 0x7FFAF9B28D70
        public void set_size_Injected(){} // RVA: 0x7FFAF9B28DD0
    }

    public class NavMeshPath
    {
        public object PN00;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B2BCE0
        public void Finalize(){} // RVA: 0x7FFAF9B2BD30
        public void InitializeNavMeshPath(){} // RVA: 0x7FFAF9B2BDC0
        public void DestroyNavMeshPath(){} // RVA: 0x7FFAF9B2BE10
        public void GetCornersNonAlloc(){} // RVA: 0x7FFAF9B2BE60
        public void CalculateCornersInternal(){} // RVA: 0x7FFAF9B2BEC0
        public void ClearCornersInternal(){} // RVA: 0x7FFAF9B2BF10
        public void ClearCorners(){} // RVA: 0x7FFAF9B2BF60
        public void CalculateCorners(){} // RVA: 0x7FFAF9B2C000
        public void get_corners(){} // RVA: 0x7FFAF9B2C0A0
        public void get_status(){} // RVA: 0x7FFAF9B2C150
    }

    public class NavMeshQueryFilter
    {
        public object corners;
        public object status;

        // ── Methods ──
        public void get_costs(){} // RVA: 0x7FFAF4584690
        public void set_costs(){} // RVA: 0x7FFAF3ABA2F0
        public void get_areaMask(){} // RVA: 0x7FFAF4959890
        public void set_areaMask(){} // RVA: 0x7FFAF49598A0
        public void get_agentTypeID(){} // RVA: 0x7FFAF49598B0
        public void set_agentTypeID(){} // RVA: 0x7FFAF49598C0
        public void GetAreaCost(){} // RVA: 0x7FFAF9B29F90
        public void SetAreaCost(){} // RVA: 0x7FFAF9B2A070
    }

    public class NavMeshTriangulation
    {
    }

    public class OffMeshLink
    {
        // ── Methods ──
        public void get_activated(){} // RVA: 0x7FFAF9B28EE0
        public void set_activated(){} // RVA: 0x7FFAF9B28F30
        public void get_occupied(){} // RVA: 0x7FFAF9B28F90
        public void get_costOverride(){} // RVA: 0x7FFAF9B28FE0
        public void set_costOverride(){} // RVA: 0x7FFAF9B29030
        public void get_biDirectional(){} // RVA: 0x7FFAF9B29090
        public void set_biDirectional(){} // RVA: 0x7FFAF9B290E0
        public void UpdatePositions(){} // RVA: 0x7FFAF9B29140
        public void get_navMeshLayer(){} // RVA: 0x7FFAF9B29190
        public void set_navMeshLayer(){} // RVA: 0x7FFAF9B291E0
        public void get_area(){} // RVA: 0x7FFAF9B29190
        public void set_area(){} // RVA: 0x7FFAF9B291E0
        public void get_autoUpdatePositions(){} // RVA: 0x7FFAF9B29240
        public void set_autoUpdatePositions(){} // RVA: 0x7FFAF9B29290
        public void get_startTransform(){} // RVA: 0x7FFAF9B292F0
        public void set_startTransform(){} // RVA: 0x7FFAF9B29340
        public void get_endTransform(){} // RVA: 0x7FFAF9B293A0
        public void set_endTransform(){} // RVA: 0x7FFAF9B293F0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class OffMeshLinkData
    {
        public object position;
        public object normal;
        public object distance;
        public object mask;
        public object hit;

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFAF8C82420
        public void get_activated(){} // RVA: 0x7FFAF9B28E30
        public void get_linkType(){} // RVA: 0x7FFAF49598B0
        public void get_startPos(){} // RVA: 0x7FFAF2DAA8D0
        public void get_endPos(){} // RVA: 0x7FFAF994FE70
        public void get_offMeshLink(){} // RVA: 0x7FFAF9B28E40
        public void GetOffMeshLinkInternal(){} // RVA: 0x7FFAF9B28E90
    }

}