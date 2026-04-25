// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.AI
// Classes: 18
// Methods: 340

namespace ThirdParty.Unity.UnityEngine.AI
{
    public class NavMesh : Object
    {
        public OnNavMeshPreUpdate avoidancePredictionTime;

        // ── Methods ──
        public void Internal_CallOnNavMeshPreUpdate(){} // RVA: 0x7FFAC9812AB0
        public void Raycast(){} // RVA: 0x7FFAC9813A80 | overloaded x2
        public void CalculatePath(){} // RVA: 0x7FFAC9813BB0 | overloaded x2
        public void CalculatePathInternal(){} // RVA: 0x7FFAC9812C50
        public void FindClosestEdge(){} // RVA: 0x7FFAC9813970 | overloaded x2
        public void SamplePosition(){} // RVA: 0x7FFAC9813840 | overloaded x2
        public void SetAreaCost(){} // RVA: 0x7FFAC9812DC0
        public void GetAreaCost(){} // RVA: 0x7FFAC9812E20
        public void GetAreaFromName(){} // RVA: 0x7FFAC9812E70
        public void CalculateTriangulation(){} // RVA: 0x7FFAC9812EC0
        public void get_avoidancePredictionTime(){} // RVA: 0x7FFAC9812F20
        public void set_avoidancePredictionTime(){} // RVA: 0x7FFAC9812F70
        public void AddNavMeshData(){} // RVA: 0x7FFAC9813120 | overloaded x2
        public void RemoveNavMeshData(){} // RVA: 0x7FFAC98132B0
        public void IsValidNavMeshDataHandle(){} // RVA: 0x7FFAC9813300
        public void IsValidLinkHandle(){} // RVA: 0x7FFAC9813350
        public void InternalGetOwner(){} // RVA: 0x7FFAC98133A0
        public void InternalSetOwner(){} // RVA: 0x7FFAC98133F0
        public void InternalGetLinkOwner(){} // RVA: 0x7FFAC9813450
        public void InternalSetLinkOwner(){} // RVA: 0x7FFAC98134A0
        public void AddNavMeshDataInternal(){} // RVA: 0x7FFAC9813500
        public void AddNavMeshDataTransformedInternal(){} // RVA: 0x7FFAC9813550
        public void RemoveNavMeshDataInternal(){} // RVA: 0x7FFAC98132B0
        public void AddLink(){} // RVA: 0x7FFAC98136E0 | overloaded x2
        public void RemoveLink(){} // RVA: 0x7FFAC9813780
        public void AddLinkInternal(){} // RVA: 0x7FFAC98137D0
        public void RemoveLinkInternal(){} // RVA: 0x7FFAC9813780
        public void SamplePositionFilter(){} // RVA: 0x7FFAC98138E0
        public void FindClosestEdgeFilter(){} // RVA: 0x7FFAC9813A00
        public void RaycastFilter(){} // RVA: 0x7FFAC9813B20
        public void CalculatePathFilterInternal(){} // RVA: 0x7FFAC9813C80
        public void CreateSettings(){} // RVA: 0x7FFAC9813D20
        public void RemoveSettings(){} // RVA: 0x7FFAC9813D90
        public void GetSettingsByID(){} // RVA: 0x7FFAC9813DE0
        public void GetSettingsCount(){} // RVA: 0x7FFAC9813E60
        public void GetSettingsByIndex(){} // RVA: 0x7FFAC9813EB0
        public void GetSettingsNameFromID(){} // RVA: 0x7FFAC9813F30
        public void RemoveAllNavMeshData(){} // RVA: 0x7FFAC9813F80
        public void Raycast_Injected(){} // RVA: 0x7FFAC9813FD0
        public void CalculatePathInternal_Injected(){} // RVA: 0x7FFAC9814050
        public void FindClosestEdge_Injected(){} // RVA: 0x7FFAC98140D0
        public void SamplePosition_Injected(){} // RVA: 0x7FFAC9814140
        public void CalculateTriangulation_Injected(){} // RVA: 0x7FFAC98141C0
        public void AddNavMeshDataTransformedInternal_Injected(){} // RVA: 0x7FFAC9814210
        public void AddLinkInternal_Injected(){} // RVA: 0x7FFAC9814280
        public void SamplePositionFilter_Injected(){} // RVA: 0x7FFAC98142F0
        public void FindClosestEdgeFilter_Injected(){} // RVA: 0x7FFAC9814380
        public void RaycastFilter_Injected(){} // RVA: 0x7FFAC9814400
        public void CalculatePathFilterInternal_Injected(){} // RVA: 0x7FFAC9814490
        public void CreateSettings_Injected(){} // RVA: 0x7FFAC9814520
        public void GetSettingsByID_Injected(){} // RVA: 0x7FFAC9814570
        public void GetSettingsByIndex_Injected(){} // RVA: 0x7FFAC98145D0
    }

    public class NavMeshAgent : Behaviour
    {
        public object destination;
        public object stoppingDistance;
        public object velocity;
        public object nextPosition;
        public object steeringTarget;
        public object desiredVelocity;
        public object remainingDistance;
        public object baseOffset;
        public object isOnOffMeshLink;
        public object currentOffMeshLinkData;
        public object nextOffMeshLinkData;
        public object autoTraverseOffMeshLink;
        public object autoBraking;
        public object autoRepath;
        public object hasPath;
        public object pathPending;
        public object isPathStale;
        public object pathStatus;
        public object pathEndPosition;
        public object isStopped;
        public object path;
        public object navMeshOwner;
        public object agentTypeID;
        public object walkableMask;
        public object areaMask;
        public object speed;
        public object angularSpeed;
        public object acceleration;
        public object updatePosition;
        public object updateRotation;
        public object updateUpAxis;
        public object radius;
        public object height;
        public object obstacleAvoidanceType;
        public object avoidancePriority;
        public object isOnNavMesh;

        // ── Methods ──
        public void SetDestination(){} // RVA: 0x7FFAC980E9C0
        public void get_destination(){} // RVA: 0x7FFAC980EA20
        public void set_destination(){} // RVA: 0x7FFAC980EA90
        public void get_stoppingDistance(){} // RVA: 0x7FFAC980EAF0
        public void set_stoppingDistance(){} // RVA: 0x7FFAC980EB40
        public void get_velocity(){} // RVA: 0x7FFAC980EBA0
        public void set_velocity(){} // RVA: 0x7FFAC980EC10
        public void get_nextPosition(){} // RVA: 0x7FFAC980EC70
        public void set_nextPosition(){} // RVA: 0x7FFAC980ECE0
        public void get_steeringTarget(){} // RVA: 0x7FFAC980ED40
        public void get_desiredVelocity(){} // RVA: 0x7FFAC980EDB0
        public void get_remainingDistance(){} // RVA: 0x7FFAC980EE20
        public void get_baseOffset(){} // RVA: 0x7FFAC980EE70
        public void set_baseOffset(){} // RVA: 0x7FFAC980EEC0
        public void get_isOnOffMeshLink(){} // RVA: 0x7FFAC980EF20
        public void ActivateCurrentOffMeshLink(){} // RVA: 0x7FFAC980EF70
        public void get_currentOffMeshLinkData(){} // RVA: 0x7FFAC980EFD0
        public void GetCurrentOffMeshLinkDataInternal(){} // RVA: 0x7FFAC980F070
        public void get_nextOffMeshLinkData(){} // RVA: 0x7FFAC980F0F0
        public void GetNextOffMeshLinkDataInternal(){} // RVA: 0x7FFAC980F190
        public void CompleteOffMeshLink(){} // RVA: 0x7FFAC980F210
        public void get_autoTraverseOffMeshLink(){} // RVA: 0x7FFAC980F260
        public void set_autoTraverseOffMeshLink(){} // RVA: 0x7FFAC980F2B0
        public void get_autoBraking(){} // RVA: 0x7FFAC980F310
        public void set_autoBraking(){} // RVA: 0x7FFAC980F360
        public void get_autoRepath(){} // RVA: 0x7FFAC980F3C0
        public void set_autoRepath(){} // RVA: 0x7FFAC980F410
        public void get_hasPath(){} // RVA: 0x7FFAC980F470
        public void get_pathPending(){} // RVA: 0x7FFAC980F4C0
        public void get_isPathStale(){} // RVA: 0x7FFAC980F510
        public void get_pathStatus(){} // RVA: 0x7FFAC980F560
        public void get_pathEndPosition(){} // RVA: 0x7FFAC980F5B0
        public void Warp(){} // RVA: 0x7FFAC980F620
        public void Move(){} // RVA: 0x7FFAC980F680
        public void Stop(){} // RVA: 0x7FFAC980F6E0 | overloaded x2
        public void Resume(){} // RVA: 0x7FFAC980F730
        public void get_isStopped(){} // RVA: 0x7FFAC980F780
        public void set_isStopped(){} // RVA: 0x7FFAC980F7D0
        public void ResetPath(){} // RVA: 0x7FFAC980F830
        public void SetPath(){} // RVA: 0x7FFAC980F880
        public void get_path(){} // RVA: 0x7FFAC980F8E0
        public void set_path(){} // RVA: 0x7FFAC980F9B0
        public void CopyPathTo(){} // RVA: 0x7FFAC980FA50
        public void FindClosestEdge(){} // RVA: 0x7FFAC980FAB0
        public void Raycast(){} // RVA: 0x7FFAC980FB10
        public void CalculatePath(){} // RVA: 0x7FFAC980FB80
        public void CalculatePathInternal(){} // RVA: 0x7FFAC980FC20
        public void SamplePathPosition(){} // RVA: 0x7FFAC980FC90
        public void SetLayerCost(){} // RVA: 0x7FFAC980FD10
        public void GetLayerCost(){} // RVA: 0x7FFAC980FD80
        public void SetAreaCost(){} // RVA: 0x7FFAC980FDE0
        public void GetAreaCost(){} // RVA: 0x7FFAC980FE50
        public void get_navMeshOwner(){} // RVA: 0x7FFAC980FEB0
        public void get_agentTypeID(){} // RVA: 0x7FFAC980FF00
        public void set_agentTypeID(){} // RVA: 0x7FFAC980FF50
        public void GetOwnerInternal(){} // RVA: 0x7FFAC980FEB0
        public void get_walkableMask(){} // RVA: 0x7FFAC980FFB0
        public void set_walkableMask(){} // RVA: 0x7FFAC9810000
        public void get_areaMask(){} // RVA: 0x7FFAC980FFB0
        public void set_areaMask(){} // RVA: 0x7FFAC9810000
        public void get_speed(){} // RVA: 0x7FFAC9810060
        public void set_speed(){} // RVA: 0x7FFAC98100B0
        public void get_angularSpeed(){} // RVA: 0x7FFAC9810110
        public void set_angularSpeed(){} // RVA: 0x7FFAC9810160
        public void get_acceleration(){} // RVA: 0x7FFAC98101C0
        public void set_acceleration(){} // RVA: 0x7FFAC9810210
        public void get_updatePosition(){} // RVA: 0x7FFAC9810270
        public void set_updatePosition(){} // RVA: 0x7FFAC98102C0
        public void get_updateRotation(){} // RVA: 0x7FFAC9810320
        public void set_updateRotation(){} // RVA: 0x7FFAC9810370
        public void get_updateUpAxis(){} // RVA: 0x7FFAC98103D0
        public void set_updateUpAxis(){} // RVA: 0x7FFAC9810420
        public void get_radius(){} // RVA: 0x7FFAC9810480
        public void set_radius(){} // RVA: 0x7FFAC98104D0
        public void get_height(){} // RVA: 0x7FFAC9810530
        public void set_height(){} // RVA: 0x7FFAC9810580
        public void get_obstacleAvoidanceType(){} // RVA: 0x7FFAC98105E0
        public void set_obstacleAvoidanceType(){} // RVA: 0x7FFAC9810630
        public void get_avoidancePriority(){} // RVA: 0x7FFAC9810690
        public void set_avoidancePriority(){} // RVA: 0x7FFAC98106E0
        public void get_isOnNavMesh(){} // RVA: 0x7FFAC9810740
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void SetDestination_Injected(){} // RVA: 0x7FFAC9810790
        public void get_destination_Injected(){} // RVA: 0x7FFAC98107F0
        public void set_destination_Injected(){} // RVA: 0x7FFAC9810850
        public void get_velocity_Injected(){} // RVA: 0x7FFAC98108B0
        public void set_velocity_Injected(){} // RVA: 0x7FFAC9810910
        public void get_nextPosition_Injected(){} // RVA: 0x7FFAC9810970
        public void set_nextPosition_Injected(){} // RVA: 0x7FFAC98109D0
        public void get_steeringTarget_Injected(){} // RVA: 0x7FFAC9810A30
        public void get_desiredVelocity_Injected(){} // RVA: 0x7FFAC9810A90
        public void GetCurrentOffMeshLinkDataInternal_Injected(){} // RVA: 0x7FFAC9810AF0
        public void GetNextOffMeshLinkDataInternal_Injected(){} // RVA: 0x7FFAC9810B50
        public void get_pathEndPosition_Injected(){} // RVA: 0x7FFAC9810BB0
        public void Warp_Injected(){} // RVA: 0x7FFAC9810C10
        public void Move_Injected(){} // RVA: 0x7FFAC9810C70
        public void Raycast_Injected(){} // RVA: 0x7FFAC9810CD0
        public void CalculatePathInternal_Injected(){} // RVA: 0x7FFAC9810D40
    }

    public class NavMeshBuildDebugSettings : ValueType
    {
        public byte m_Flags; // 0x10
    }

    public class NavMeshBuildMarkup : ValueType
    {
        public int overrideArea; // 0x10
        public int area; // 0x14
        public int ignoreFromBuild; // 0x18
        public int overrideGenerateLinks; // 0x1C
        public int generateLinks; // 0x20
        public int applyToChildren; // 0x24
        public int root; // 0x28
        public int m_IgnoreChildren; // 0x2C

        // ── Methods ──
        public void set_overrideArea(){} // RVA: 0x7FFAC89D37B0
        public void set_area(){} // RVA: 0x7FFAC4420230
        public void set_ignoreFromBuild(){} // RVA: 0x7FFAC9814CC0
        public void set_overrideGenerateLinks(){} // RVA: 0x7FFAC9814CD0
        public void set_generateLinks(){} // RVA: 0x7FFAC9814CE0
        public void set_applyToChildren(){} // RVA: 0x7FFAC9814CF0
        public void set_root(){} // RVA: 0x7FFAC9814D00
    }

    public class NavMeshBuildSettings : ValueType
    {
        public int agentTypeID; // 0x10
        public float agentRadius; // 0x14
        public float agentHeight; // 0x18
        public float agentSlope; // 0x1C
        public float agentClimb; // 0x20
        public float ledgeDropHeight; // 0x24
        public float maxJumpAcrossDistance; // 0x28
        public float minRegionArea; // 0x2C
        public int overrideVoxelSize; // 0x30
        public float voxelSize; // 0x34
        public int overrideTileSize; // 0x38
        public int tileSize; // 0x3C
        public int preserveTilesOutsideBounds; // 0x40
        public uint buildHeightMesh; // 0x44
        public int debug; // 0x48
        public UnityEngine.AI.NavMeshBuildDebugSettings m_Debug; // 0x4C

        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x7FFAC8F93F90
        public void set_agentTypeID(){} // RVA: 0x7FFAC336D8B0
        public void get_agentRadius(){} // RVA: 0x7FFAC2F44D30
        public void set_agentRadius(){} // RVA: 0x7FFAC4A9B8F0
        public void get_agentHeight(){} // RVA: 0x7FFAC2F44CF0
        public void set_agentHeight(){} // RVA: 0x7FFAC4A9B920
        public void get_agentSlope(){} // RVA: 0x7FFAC2F44D00
        public void set_agentSlope(){} // RVA: 0x7FFAC4A9B8C0
        public void get_agentClimb(){} // RVA: 0x7FFAC9814DF0
        public void set_agentClimb(){} // RVA: 0x7FFAC304B330
        public void get_ledgeDropHeight(){} // RVA: 0x7FFAC58A0690
        public void set_ledgeDropHeight(){} // RVA: 0x7FFAC304B350
        public void get_maxJumpAcrossDistance(){} // RVA: 0x7FFAC9811DF0
        public void set_maxJumpAcrossDistance(){} // RVA: 0x7FFAC2F3C4D0
        public void get_minRegionArea(){} // RVA: 0x7FFAC9814E00
        public void set_minRegionArea(){} // RVA: 0x7FFAC2FEE580
        public void get_overrideVoxelSize(){} // RVA: 0x7FFAC9811E00
        public void set_overrideVoxelSize(){} // RVA: 0x7FFAC9811E10
        public void get_voxelSize(){} // RVA: 0x7FFAC9814E10
        public void set_voxelSize(){} // RVA: 0x7FFAC308EF60
        public void get_overrideTileSize(){} // RVA: 0x7FFAC9814E20
        public void set_overrideTileSize(){} // RVA: 0x7FFAC9814E30
        public void get_tileSize(){} // RVA: 0x7FFAC9814E40
        public void set_tileSize(){} // RVA: 0x7FFAC45B6490
        public void get_preserveTilesOutsideBounds(){} // RVA: 0x7FFAC9814E50
        public void set_preserveTilesOutsideBounds(){} // RVA: 0x7FFAC9814E60
        public void get_buildHeightMesh(){} // RVA: 0x7FFAC9814E70
        public void set_buildHeightMesh(){} // RVA: 0x7FFAC9814E80
        public void get_debug(){} // RVA: 0x7FFAC9814E90
        public void set_debug(){} // RVA: 0x7FFAC30864F0
        public void ValidationReport(){} // RVA: 0x7FFAC9814EA0
        public void InternalValidationReport(){} // RVA: 0x7FFAC9814F30
        public void InternalValidationReport_Injected(){} // RVA: 0x7FFAC9814F90
    }

    public class NavMeshBuildSource : ValueType
    {
        public UnityEngine.Matrix4x4 transform; // 0x10
        public UnityEngine.Vector3 size; // 0x50
        public 0x6B2C6EE8 shape; // 0x5C
        public int area; // 0x60
        public int sourceObject; // 0x64
        public int component; // 0x68
        public int m_GenerateLinks; // 0x6C

        // ── Methods ──
        public void get_transform(){} // RVA: 0x7FFAC9814AF0
        public void set_transform(){} // RVA: 0x7FFAC9814B20
        public void get_size(){} // RVA: 0x7FFAC9814B40
        public void set_size(){} // RVA: 0x7FFAC9814B60
        public void get_shape(){} // RVA: 0x7FFAC9814B70
        public void set_shape(){} // RVA: 0x7FFAC489E500
        public void set_area(){} // RVA: 0x7FFAC31D9010
        public void get_sourceObject(){} // RVA: 0x7FFAC9814B80
        public void get_component(){} // RVA: 0x7FFAC9814BD0
        public void InternalGetComponent(){} // RVA: 0x7FFAC9814C20
        public void InternalGetObject(){} // RVA: 0x7FFAC9814C70
    }

    public class NavMeshBuilder : Object
    {
        // ── Methods ──
        public void CollectSources(){} // RVA: 0x7FFAC980DF80 | overloaded x2
        public void CollectSourcesInternal(){} // RVA: 0x7FFAC980E1A0
        public void BuildNavMeshData(){} // RVA: 0x7FFAC980E260
        public void UpdateNavMeshDataListInternal(){} // RVA: 0x7FFAC980E500
        public void UpdateNavMeshDataAsync(){} // RVA: 0x7FFAC980E580
        public void UpdateNavMeshDataAsyncListInternal(){} // RVA: 0x7FFAC980E7A0
        public void CollectSourcesInternal_Injected(){} // RVA: 0x7FFAC980E820
        public void UpdateNavMeshDataListInternal_Injected(){} // RVA: 0x7FFAC980E8C0
        public void UpdateNavMeshDataAsyncListInternal_Injected(){} // RVA: 0x7FFAC980E940
    }

    public class NavMeshData : Object
    {
        public object sourceBounds;
        public object position;
        public object rotation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9811EB0 | overloaded x2
        public void Internal_Create(){} // RVA: 0x7FFAC9811F50
        public void get_sourceBounds(){} // RVA: 0x7FFAC9811FB0
        public void get_position(){} // RVA: 0x7FFAC9812020
        public void set_position(){} // RVA: 0x7FFAC9812090
        public void get_rotation(){} // RVA: 0x7FFAC98120F0
        public void set_rotation(){} // RVA: 0x7FFAC9812160
        public void get_sourceBounds_Injected(){} // RVA: 0x7FFAC98121C0
        public void get_position_Injected(){} // RVA: 0x7FFAC9812220
        public void set_position_Injected(){} // RVA: 0x7FFAC9812280
        public void get_rotation_Injected(){} // RVA: 0x7FFAC98122E0
        public void set_rotation_Injected(){} // RVA: 0x7FFAC9812340
    }

    public class NavMeshDataInstance : ValueType
    {
        public int valid; // 0x10

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFAC98123A0
        public void get_id(){} // RVA: 0x7FFAC4420210
        public void set_id(){} // RVA: 0x7FFAC336D8B0
        public void Remove(){} // RVA: 0x7FFAC9812410
        public void get_owner(){} // RVA: 0x7FFAC9812460
        public void set_owner(){} // RVA: 0x7FFAC98124B0
    }

    public class NavMeshHit : ValueType
    {
        public UnityEngine.Vector3 position; // 0x10
        public UnityEngine.Vector3 normal; // 0x1C
        public float distance; // 0x28
        public int mask; // 0x2C
        public int hit; // 0x30

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFAC9811DA0
        public void set_position(){} // RVA: 0x7FFAC530B6C0
        public void get_normal(){} // RVA: 0x7FFAC9811DC0
        public void set_normal(){} // RVA: 0x7FFAC9811DE0
        public void get_distance(){} // RVA: 0x7FFAC9811DF0
        public void set_distance(){} // RVA: 0x7FFAC2F3C4D0
        public void get_mask(){} // RVA: 0x7FFAC5CC4740
        public void set_mask(){} // RVA: 0x7FFAC44474D0
        public void get_hit(){} // RVA: 0x7FFAC9811E00
        public void set_hit(){} // RVA: 0x7FFAC9811E10
    }

    public class NavMeshLinkData : ValueType
    {
        public UnityEngine.Vector3 startPosition; // 0x10
        public UnityEngine.Vector3 endPosition; // 0x1C
        public float costModifier; // 0x28
        public int bidirectional; // 0x2C
        public float width; // 0x30
        public int area; // 0x34
        public int agentTypeID; // 0x38

        // ── Methods ──
        public void get_startPosition(){} // RVA: 0x7FFAC9811DA0
        public void set_startPosition(){} // RVA: 0x7FFAC530B6C0
        public void get_endPosition(){} // RVA: 0x7FFAC9811DC0
        public void set_endPosition(){} // RVA: 0x7FFAC9811DE0
        public void get_costModifier(){} // RVA: 0x7FFAC9811DF0
        public void set_costModifier(){} // RVA: 0x7FFAC2F3C4D0
        public void get_bidirectional(){} // RVA: 0x7FFAC9812620
        public void set_bidirectional(){} // RVA: 0x7FFAC9812630
        public void get_width(){} // RVA: 0x7FFAC9812640
        public void set_width(){} // RVA: 0x7FFAC4447440
        public void get_area(){} // RVA: 0x7FFAC9812650
        public void set_area(){} // RVA: 0x7FFAC41674D0
        public void get_agentTypeID(){} // RVA: 0x7FFAC6C8FE60
        public void set_agentTypeID(){} // RVA: 0x7FFAC369A6E0
    }

    public class NavMeshLinkInstance : ValueType
    {
        public int valid; // 0x10

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFAC9812660
        public void get_id(){} // RVA: 0x7FFAC4420210
        public void set_id(){} // RVA: 0x7FFAC336D8B0
        public void Remove(){} // RVA: 0x7FFAC98126D0
        public void get_owner(){} // RVA: 0x7FFAC9812720
        public void set_owner(){} // RVA: 0x7FFAC9812770
    }

    public class NavMeshObstacle : Behaviour
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

        // ── Methods ──
        public void get_height(){} // RVA: 0x7FFAC9810DB0
        public void set_height(){} // RVA: 0x7FFAC9810E00
        public void get_radius(){} // RVA: 0x7FFAC9810E60
        public void set_radius(){} // RVA: 0x7FFAC9810EB0
        public void get_velocity(){} // RVA: 0x7FFAC9810F10
        public void set_velocity(){} // RVA: 0x7FFAC9810F80
        public void get_carving(){} // RVA: 0x7FFAC9810FE0
        public void set_carving(){} // RVA: 0x7FFAC9811030
        public void get_carveOnlyStationary(){} // RVA: 0x7FFAC9811090
        public void set_carveOnlyStationary(){} // RVA: 0x7FFAC98110E0
        public void get_carvingMoveThreshold(){} // RVA: 0x7FFAC9811140
        public void set_carvingMoveThreshold(){} // RVA: 0x7FFAC9811190
        public void get_carvingTimeToStationary(){} // RVA: 0x7FFAC98111F0
        public void set_carvingTimeToStationary(){} // RVA: 0x7FFAC9811240
        public void get_shape(){} // RVA: 0x7FFAC98112A0
        public void set_shape(){} // RVA: 0x7FFAC98112F0
        public void get_center(){} // RVA: 0x7FFAC9811350
        public void set_center(){} // RVA: 0x7FFAC98113C0
        public void get_size(){} // RVA: 0x7FFAC9811420
        public void set_size(){} // RVA: 0x7FFAC9811490
        public void FitExtents(){} // RVA: 0x7FFAC98114F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_velocity_Injected(){} // RVA: 0x7FFAC9811540
        public void set_velocity_Injected(){} // RVA: 0x7FFAC98115A0
        public void get_center_Injected(){} // RVA: 0x7FFAC9811600
        public void set_center_Injected(){} // RVA: 0x7FFAC9811660
        public void get_size_Injected(){} // RVA: 0x7FFAC98116C0
        public void set_size_Injected(){} // RVA: 0x7FFAC9811720
    }

    public class NavMeshPath : Object
    {
        public UIntPtr corners; // 0x10
        public UnityEngine.Vector3[] status; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9814630
        public void Finalize(){} // RVA: 0x7FFAC9814680
        public void InitializeNavMeshPath(){} // RVA: 0x7FFAC9814710
        public void DestroyNavMeshPath(){} // RVA: 0x7FFAC9814760
        public void GetCornersNonAlloc(){} // RVA: 0x7FFAC98147B0
        public void CalculateCornersInternal(){} // RVA: 0x7FFAC9814810
        public void ClearCornersInternal(){} // RVA: 0x7FFAC9814860
        public void ClearCorners(){} // RVA: 0x7FFAC98148B0
        public void CalculateCorners(){} // RVA: 0x7FFAC9814950
        public void get_corners(){} // RVA: 0x7FFAC98149F0
        public void get_status(){} // RVA: 0x7FFAC9814AA0
    }

    public class NavMeshQueryFilter : ValueType
    {
        public float[] costs; // 0x10
        public int areaMask; // 0x18
        public int agentTypeID; // 0x1C

        // ── Methods ──
        public void get_costs(){} // RVA: 0x7FFAC3AD9F60
        public void set_costs(){} // RVA: 0x7FFAC38DFE40
        public void get_areaMask(){} // RVA: 0x7FFAC49C7500
        public void set_areaMask(){} // RVA: 0x7FFAC49C7510
        public void get_agentTypeID(){} // RVA: 0x7FFAC49C7520
        public void set_agentTypeID(){} // RVA: 0x7FFAC49C7530
        public void GetAreaCost(){} // RVA: 0x7FFAC98128E0
        public void SetAreaCost(){} // RVA: 0x7FFAC98129C0
    }

    public class NavMeshTriangulation : ValueType
    {
        public UnityEngine.Vector3[] vertices; // 0x10
        public int[] indices; // 0x18
        public int[] areas; // 0x20
    }

    public class OffMeshLink : Behaviour
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
        public void get_activated(){} // RVA: 0x7FFAC9811830
        public void set_activated(){} // RVA: 0x7FFAC9811880
        public void get_occupied(){} // RVA: 0x7FFAC98118E0
        public void get_costOverride(){} // RVA: 0x7FFAC9811930
        public void set_costOverride(){} // RVA: 0x7FFAC9811980
        public void get_biDirectional(){} // RVA: 0x7FFAC98119E0
        public void set_biDirectional(){} // RVA: 0x7FFAC9811A30
        public void UpdatePositions(){} // RVA: 0x7FFAC9811A90
        public void get_navMeshLayer(){} // RVA: 0x7FFAC9811AE0
        public void set_navMeshLayer(){} // RVA: 0x7FFAC9811B30
        public void get_area(){} // RVA: 0x7FFAC9811AE0
        public void set_area(){} // RVA: 0x7FFAC9811B30
        public void get_autoUpdatePositions(){} // RVA: 0x7FFAC9811B90
        public void set_autoUpdatePositions(){} // RVA: 0x7FFAC9811BE0
        public void get_startTransform(){} // RVA: 0x7FFAC9811C40
        public void set_startTransform(){} // RVA: 0x7FFAC9811C90
        public void get_endTransform(){} // RVA: 0x7FFAC9811CF0
        public void set_endTransform(){} // RVA: 0x7FFAC9811D40
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class OffMeshLinkData : ValueType
    {
        public int valid; // 0x10
        public int activated; // 0x14
        public int linkType; // 0x18
        public 0x6B2C6A18 startPos; // 0x1C
        public UnityEngine.Vector3 endPos; // 0x20
        public UnityEngine.Vector3 offMeshLink; // 0x2C

        // ── Methods ──
        public void get_valid(){} // RVA: 0x7FFAC8969B60
        public void get_activated(){} // RVA: 0x7FFAC9811780
        public void get_linkType(){} // RVA: 0x7FFAC49C7520
        public void get_startPos(){} // RVA: 0x7FFAC2F3E8D0
        public void get_endPos(){} // RVA: 0x7FFAC96385C0
        public void get_offMeshLink(){} // RVA: 0x7FFAC9811790
        public void GetOffMeshLinkInternal(){} // RVA: 0x7FFAC98117E0
    }

}