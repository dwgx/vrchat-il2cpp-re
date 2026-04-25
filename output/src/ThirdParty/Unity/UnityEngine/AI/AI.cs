// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.AI
// Classes: 7
// Methods: 228

namespace ThirdParty.Unity.UnityEngine.AI
{
    public class NavMesh : Object
    {
        public object avoidancePredictionTime;

        // ── Methods ──
        public void Internal_CallOnNavMeshPreUpdate(){} // RVA: 0x7FFD54C32AB0
        public void Raycast(){} // RVA: 0x7FFD54C33A80 | overloaded x2
        public void CalculatePath(){} // RVA: 0x7FFD54C33BB0 | overloaded x2
        public void CalculatePathInternal(){} // RVA: 0x7FFD54C32C50
        public void FindClosestEdge(){} // RVA: 0x7FFD54C33970 | overloaded x2
        public void SamplePosition(){} // RVA: 0x7FFD54C33840 | overloaded x2
        public void SetAreaCost(){} // RVA: 0x7FFD54C32DC0
        public void GetAreaCost(){} // RVA: 0x7FFD54C32E20
        public void GetAreaFromName(){} // RVA: 0x7FFD54C32E70
        public void CalculateTriangulation(){} // RVA: 0x7FFD54C32EC0
        public void get_avoidancePredictionTime(){} // RVA: 0x7FFD54C32F20
        public void set_avoidancePredictionTime(){} // RVA: 0x7FFD54C32F70
        public void AddNavMeshData(){} // RVA: 0x7FFD54C33120 | overloaded x2
        public void RemoveNavMeshData(){} // RVA: 0x7FFD54C332B0
        public void IsValidNavMeshDataHandle(){} // RVA: 0x7FFD54C33300
        public void IsValidLinkHandle(){} // RVA: 0x7FFD54C33350
        public void InternalGetOwner(){} // RVA: 0x7FFD54C333A0
        public void InternalSetOwner(){} // RVA: 0x7FFD54C333F0
        public void InternalGetLinkOwner(){} // RVA: 0x7FFD54C33450
        public void InternalSetLinkOwner(){} // RVA: 0x7FFD54C334A0
        public void AddNavMeshDataInternal(){} // RVA: 0x7FFD54C33500
        public void AddNavMeshDataTransformedInternal(){} // RVA: 0x7FFD54C33550
        public void RemoveNavMeshDataInternal(){} // RVA: 0x7FFD54C332B0
        public void AddLink(){} // RVA: 0x7FFD54C336E0 | overloaded x2
        public void RemoveLink(){} // RVA: 0x7FFD54C33780
        public void AddLinkInternal(){} // RVA: 0x7FFD54C337D0
        public void RemoveLinkInternal(){} // RVA: 0x7FFD54C33780
        public void SamplePositionFilter(){} // RVA: 0x7FFD54C338E0
        public void FindClosestEdgeFilter(){} // RVA: 0x7FFD54C33A00
        public void RaycastFilter(){} // RVA: 0x7FFD54C33B20
        public void CalculatePathFilterInternal(){} // RVA: 0x7FFD54C33C80
        public void CreateSettings(){} // RVA: 0x7FFD54C33D20
        public void RemoveSettings(){} // RVA: 0x7FFD54C33D90
        public void GetSettingsByID(){} // RVA: 0x7FFD54C33DE0
        public void GetSettingsCount(){} // RVA: 0x7FFD54C33E60
        public void GetSettingsByIndex(){} // RVA: 0x7FFD54C33EB0
        public void GetSettingsNameFromID(){} // RVA: 0x7FFD54C33F30
        public void RemoveAllNavMeshData(){} // RVA: 0x7FFD54C33F80
        public void Raycast_Injected(){} // RVA: 0x7FFD54C33FD0
        public void CalculatePathInternal_Injected(){} // RVA: 0x7FFD54C34050
        public void FindClosestEdge_Injected(){} // RVA: 0x7FFD54C340D0
        public void SamplePosition_Injected(){} // RVA: 0x7FFD54C34140
        public void CalculateTriangulation_Injected(){} // RVA: 0x7FFD54C341C0
        public void AddNavMeshDataTransformedInternal_Injected(){} // RVA: 0x7FFD54C34210
        public void AddLinkInternal_Injected(){} // RVA: 0x7FFD54C34280
        public void SamplePositionFilter_Injected(){} // RVA: 0x7FFD54C342F0
        public void FindClosestEdgeFilter_Injected(){} // RVA: 0x7FFD54C34380
        public void RaycastFilter_Injected(){} // RVA: 0x7FFD54C34400
        public void CalculatePathFilterInternal_Injected(){} // RVA: 0x7FFD54C34490
        public void CreateSettings_Injected(){} // RVA: 0x7FFD54C34520
        public void GetSettingsByID_Injected(){} // RVA: 0x7FFD54C34570
        public void GetSettingsByIndex_Injected(){} // RVA: 0x7FFD54C345D0
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
        public void SetDestination(){} // RVA: 0x7FFD54C2E9C0
        public void get_destination(){} // RVA: 0x7FFD54C2EA20
        public void set_destination(){} // RVA: 0x7FFD54C2EA90
        public void get_stoppingDistance(){} // RVA: 0x7FFD54C2EAF0
        public void set_stoppingDistance(){} // RVA: 0x7FFD54C2EB40
        public void get_velocity(){} // RVA: 0x7FFD54C2EBA0
        public void set_velocity(){} // RVA: 0x7FFD54C2EC10
        public void get_nextPosition(){} // RVA: 0x7FFD54C2EC70
        public void set_nextPosition(){} // RVA: 0x7FFD54C2ECE0
        public void get_steeringTarget(){} // RVA: 0x7FFD54C2ED40
        public void get_desiredVelocity(){} // RVA: 0x7FFD54C2EDB0
        public void get_remainingDistance(){} // RVA: 0x7FFD54C2EE20
        public void get_baseOffset(){} // RVA: 0x7FFD54C2EE70
        public void set_baseOffset(){} // RVA: 0x7FFD54C2EEC0
        public void get_isOnOffMeshLink(){} // RVA: 0x7FFD54C2EF20
        public void ActivateCurrentOffMeshLink(){} // RVA: 0x7FFD54C2EF70
        public void get_currentOffMeshLinkData(){} // RVA: 0x7FFD54C2EFD0
        public void GetCurrentOffMeshLinkDataInternal(){} // RVA: 0x7FFD54C2F070
        public void get_nextOffMeshLinkData(){} // RVA: 0x7FFD54C2F0F0
        public void GetNextOffMeshLinkDataInternal(){} // RVA: 0x7FFD54C2F190
        public void CompleteOffMeshLink(){} // RVA: 0x7FFD54C2F210
        public void get_autoTraverseOffMeshLink(){} // RVA: 0x7FFD54C2F260
        public void set_autoTraverseOffMeshLink(){} // RVA: 0x7FFD54C2F2B0
        public void get_autoBraking(){} // RVA: 0x7FFD54C2F310
        public void set_autoBraking(){} // RVA: 0x7FFD54C2F360
        public void get_autoRepath(){} // RVA: 0x7FFD54C2F3C0
        public void set_autoRepath(){} // RVA: 0x7FFD54C2F410
        public void get_hasPath(){} // RVA: 0x7FFD54C2F470
        public void get_pathPending(){} // RVA: 0x7FFD54C2F4C0
        public void get_isPathStale(){} // RVA: 0x7FFD54C2F510
        public void get_pathStatus(){} // RVA: 0x7FFD54C2F560
        public void get_pathEndPosition(){} // RVA: 0x7FFD54C2F5B0
        public void Warp(){} // RVA: 0x7FFD54C2F620
        public void Move(){} // RVA: 0x7FFD54C2F680
        public void Stop(){} // RVA: 0x7FFD54C2F6E0 | overloaded x2
        public void Resume(){} // RVA: 0x7FFD54C2F730
        public void get_isStopped(){} // RVA: 0x7FFD54C2F780
        public void set_isStopped(){} // RVA: 0x7FFD54C2F7D0
        public void ResetPath(){} // RVA: 0x7FFD54C2F830
        public void SetPath(){} // RVA: 0x7FFD54C2F880
        public void get_path(){} // RVA: 0x7FFD54C2F8E0
        public void set_path(){} // RVA: 0x7FFD54C2F9B0
        public void CopyPathTo(){} // RVA: 0x7FFD54C2FA50
        public void FindClosestEdge(){} // RVA: 0x7FFD54C2FAB0
        public void Raycast(){} // RVA: 0x7FFD54C2FB10
        public void CalculatePath(){} // RVA: 0x7FFD54C2FB80
        public void CalculatePathInternal(){} // RVA: 0x7FFD54C2FC20
        public void SamplePathPosition(){} // RVA: 0x7FFD54C2FC90
        public void SetLayerCost(){} // RVA: 0x7FFD54C2FD10
        public void GetLayerCost(){} // RVA: 0x7FFD54C2FD80
        public void SetAreaCost(){} // RVA: 0x7FFD54C2FDE0
        public void GetAreaCost(){} // RVA: 0x7FFD54C2FE50
        public void get_navMeshOwner(){} // RVA: 0x7FFD54C2FEB0
        public void get_agentTypeID(){} // RVA: 0x7FFD54C2FF00
        public void set_agentTypeID(){} // RVA: 0x7FFD54C2FF50
        public void GetOwnerInternal(){} // RVA: 0x7FFD54C2FEB0
        public void get_walkableMask(){} // RVA: 0x7FFD54C2FFB0
        public void set_walkableMask(){} // RVA: 0x7FFD54C30000
        public void get_areaMask(){} // RVA: 0x7FFD54C2FFB0
        public void set_areaMask(){} // RVA: 0x7FFD54C30000
        public void get_speed(){} // RVA: 0x7FFD54C30060
        public void set_speed(){} // RVA: 0x7FFD54C300B0
        public void get_angularSpeed(){} // RVA: 0x7FFD54C30110
        public void set_angularSpeed(){} // RVA: 0x7FFD54C30160
        public void get_acceleration(){} // RVA: 0x7FFD54C301C0
        public void set_acceleration(){} // RVA: 0x7FFD54C30210
        public void get_updatePosition(){} // RVA: 0x7FFD54C30270
        public void set_updatePosition(){} // RVA: 0x7FFD54C302C0
        public void get_updateRotation(){} // RVA: 0x7FFD54C30320
        public void set_updateRotation(){} // RVA: 0x7FFD54C30370
        public void get_updateUpAxis(){} // RVA: 0x7FFD54C303D0
        public void set_updateUpAxis(){} // RVA: 0x7FFD54C30420
        public void get_radius(){} // RVA: 0x7FFD54C30480
        public void set_radius(){} // RVA: 0x7FFD54C304D0
        public void get_height(){} // RVA: 0x7FFD54C30530
        public void set_height(){} // RVA: 0x7FFD54C30580
        public void get_obstacleAvoidanceType(){} // RVA: 0x7FFD54C305E0
        public void set_obstacleAvoidanceType(){} // RVA: 0x7FFD54C30630
        public void get_avoidancePriority(){} // RVA: 0x7FFD54C30690
        public void set_avoidancePriority(){} // RVA: 0x7FFD54C306E0
        public void get_isOnNavMesh(){} // RVA: 0x7FFD54C30740
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void SetDestination_Injected(){} // RVA: 0x7FFD54C30790
        public void get_destination_Injected(){} // RVA: 0x7FFD54C307F0
        public void set_destination_Injected(){} // RVA: 0x7FFD54C30850
        public void get_velocity_Injected(){} // RVA: 0x7FFD54C308B0
        public void set_velocity_Injected(){} // RVA: 0x7FFD54C30910
        public void get_nextPosition_Injected(){} // RVA: 0x7FFD54C30970
        public void set_nextPosition_Injected(){} // RVA: 0x7FFD54C309D0
        public void get_steeringTarget_Injected(){} // RVA: 0x7FFD54C30A30
        public void get_desiredVelocity_Injected(){} // RVA: 0x7FFD54C30A90
        public void GetCurrentOffMeshLinkDataInternal_Injected(){} // RVA: 0x7FFD54C30AF0
        public void GetNextOffMeshLinkDataInternal_Injected(){} // RVA: 0x7FFD54C30B50
        public void get_pathEndPosition_Injected(){} // RVA: 0x7FFD54C30BB0
        public void Warp_Injected(){} // RVA: 0x7FFD54C30C10
        public void Move_Injected(){} // RVA: 0x7FFD54C30C70
        public void Raycast_Injected(){} // RVA: 0x7FFD54C30CD0
        public void CalculatePathInternal_Injected(){} // RVA: 0x7FFD54C30D40
    }

    public class NavMeshBuildSource : ValueType
    {
        public object transform;
        public object size;
        public object shape;
        public object area;
        public object sourceObject;
        public object component;

        // ── Methods ──
        public void get_transform(){} // RVA: 0x7FFD54C34AF0
        public void set_transform(){} // RVA: 0x7FFD54C34B20
        public void get_size(){} // RVA: 0x7FFD54C34B40
        public void set_size(){} // RVA: 0x7FFD54C34B60
        public void get_shape(){} // RVA: 0x7FFD54C34B70
        public void set_shape(){} // RVA: 0x7FFD4FCBE500
        public void set_area(){} // RVA: 0x7FFD4E5F9010
        public void get_sourceObject(){} // RVA: 0x7FFD54C34B80
        public void get_component(){} // RVA: 0x7FFD54C34BD0
        public void InternalGetComponent(){} // RVA: 0x7FFD54C34C20
        public void InternalGetObject(){} // RVA: 0x7FFD54C34C70
    }

    public class NavMeshData : Object
    {
        public object sourceBounds;
        public object position;
        public object rotation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C31EB0 | overloaded x2
        public void Internal_Create(){} // RVA: 0x7FFD54C31F50
        public void get_sourceBounds(){} // RVA: 0x7FFD54C31FB0
        public void get_position(){} // RVA: 0x7FFD54C32020
        public void set_position(){} // RVA: 0x7FFD54C32090
        public void get_rotation(){} // RVA: 0x7FFD54C320F0
        public void set_rotation(){} // RVA: 0x7FFD54C32160
        public void get_sourceBounds_Injected(){} // RVA: 0x7FFD54C321C0
        public void get_position_Injected(){} // RVA: 0x7FFD54C32220
        public void set_position_Injected(){} // RVA: 0x7FFD54C32280
        public void get_rotation_Injected(){} // RVA: 0x7FFD54C322E0
        public void set_rotation_Injected(){} // RVA: 0x7FFD54C32340
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
        public void get_height(){} // RVA: 0x7FFD54C30DB0
        public void set_height(){} // RVA: 0x7FFD54C30E00
        public void get_radius(){} // RVA: 0x7FFD54C30E60
        public void set_radius(){} // RVA: 0x7FFD54C30EB0
        public void get_velocity(){} // RVA: 0x7FFD54C30F10
        public void set_velocity(){} // RVA: 0x7FFD54C30F80
        public void get_carving(){} // RVA: 0x7FFD54C30FE0
        public void set_carving(){} // RVA: 0x7FFD54C31030
        public void get_carveOnlyStationary(){} // RVA: 0x7FFD54C31090
        public void set_carveOnlyStationary(){} // RVA: 0x7FFD54C310E0
        public void get_carvingMoveThreshold(){} // RVA: 0x7FFD54C31140
        public void set_carvingMoveThreshold(){} // RVA: 0x7FFD54C31190
        public void get_carvingTimeToStationary(){} // RVA: 0x7FFD54C311F0
        public void set_carvingTimeToStationary(){} // RVA: 0x7FFD54C31240
        public void get_shape(){} // RVA: 0x7FFD54C312A0
        public void set_shape(){} // RVA: 0x7FFD54C312F0
        public void get_center(){} // RVA: 0x7FFD54C31350
        public void set_center(){} // RVA: 0x7FFD54C313C0
        public void get_size(){} // RVA: 0x7FFD54C31420
        public void set_size(){} // RVA: 0x7FFD54C31490
        public void FitExtents(){} // RVA: 0x7FFD54C314F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_velocity_Injected(){} // RVA: 0x7FFD54C31540
        public void set_velocity_Injected(){} // RVA: 0x7FFD54C315A0
        public void get_center_Injected(){} // RVA: 0x7FFD54C31600
        public void set_center_Injected(){} // RVA: 0x7FFD54C31660
        public void get_size_Injected(){} // RVA: 0x7FFD54C316C0
        public void set_size_Injected(){} // RVA: 0x7FFD54C31720
    }

    public class NavMeshTriangulation : ValueType
    {
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
        public void get_activated(){} // RVA: 0x7FFD54C31830
        public void set_activated(){} // RVA: 0x7FFD54C31880
        public void get_occupied(){} // RVA: 0x7FFD54C318E0
        public void get_costOverride(){} // RVA: 0x7FFD54C31930
        public void set_costOverride(){} // RVA: 0x7FFD54C31980
        public void get_biDirectional(){} // RVA: 0x7FFD54C319E0
        public void set_biDirectional(){} // RVA: 0x7FFD54C31A30
        public void UpdatePositions(){} // RVA: 0x7FFD54C31A90
        public void get_navMeshLayer(){} // RVA: 0x7FFD54C31AE0
        public void set_navMeshLayer(){} // RVA: 0x7FFD54C31B30
        public void get_area(){} // RVA: 0x7FFD54C31AE0
        public void set_area(){} // RVA: 0x7FFD54C31B30
        public void get_autoUpdatePositions(){} // RVA: 0x7FFD54C31B90
        public void set_autoUpdatePositions(){} // RVA: 0x7FFD54C31BE0
        public void get_startTransform(){} // RVA: 0x7FFD54C31C40
        public void set_startTransform(){} // RVA: 0x7FFD54C31C90
        public void get_endTransform(){} // RVA: 0x7FFD54C31CF0
        public void set_endTransform(){} // RVA: 0x7FFD54C31D40
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}