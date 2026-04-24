// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.AI
// Classes: 7
// Methods: 228

namespace ThirdParty.Unity.UnityEngine.AI
{
    public class NavMesh : Object
    {
        // ── Original Methods ──
        public void Internal_CallOnNavMeshPreUpdate(){} // RVA: 0x7ffaaf234a10
        public void Raycast(){} // RVA: 0x7ffaaf2359e0
        public void CalculatePath(){} // RVA: 0x7ffaaf235b10
        public void CalculatePathInternal(){} // RVA: 0x7ffaaf234bb0
        public void FindClosestEdge(){} // RVA: 0x7ffaaf2358d0
        public void SamplePosition(){} // RVA: 0x7ffaaf2357a0
        public void CalculateTriangulation(){} // RVA: 0x7ffaaf234e20
        public void get_avoidancePredictionTime(){} // RVA: 0x7ffaaf234e80
        public void set_avoidancePredictionTime(){} // RVA: 0x7ffaaf234ed0
        public void AddNavMeshData(){} // RVA: 0x7ffaaf235080
        public void AddNavMeshData(){} // RVA: 0x7ffaaf235080
        public void RemoveNavMeshData(){} // RVA: 0x7ffaaf235210
        public void IsValidNavMeshDataHandle(){} // RVA: 0x7ffaaf235260
        public void IsValidLinkHandle(){} // RVA: 0x7ffaaf2352b0
        public void InternalGetOwner(){} // RVA: 0x7ffaaf235300
        public void InternalSetOwner(){} // RVA: 0x7ffaaf235350
        public void InternalGetLinkOwner(){} // RVA: 0x7ffaaf2353b0
        public void InternalSetLinkOwner(){} // RVA: 0x7ffaaf235400
        public void AddNavMeshDataInternal(){} // RVA: 0x7ffaaf235460
        public void AddNavMeshDataTransformedInternal(){} // RVA: 0x7ffaaf2354b0
        public void RemoveNavMeshDataInternal(){} // RVA: 0x7ffaaf235210
        public void AddLink(){} // RVA: 0x7ffaaf235640
        public void AddLink(){} // RVA: 0x7ffaaf235640
        public void RemoveLink(){} // RVA: 0x7ffaaf2356e0
        public void AddLinkInternal(){} // RVA: 0x7ffaaf235730
        public void RemoveLinkInternal(){} // RVA: 0x7ffaaf2356e0
        public void SamplePosition(){} // RVA: 0x7ffaaf2357a0
        public void SamplePositionFilter(){} // RVA: 0x7ffaaf235840
        public void FindClosestEdge(){} // RVA: 0x7ffaaf2358d0
        public void FindClosestEdgeFilter(){} // RVA: 0x7ffaaf235960
        public void Raycast(){} // RVA: 0x7ffaaf2359e0
        public void RaycastFilter(){} // RVA: 0x7ffaaf235a80
        public void CalculatePath(){} // RVA: 0x7ffaaf235b10
        public void CalculatePathFilterInternal(){} // RVA: 0x7ffaaf235be0
        public void CreateSettings(){} // RVA: 0x7ffaaf235c80
        public void RemoveSettings(){} // RVA: 0x7ffaaf235cf0
        public void RemoveAllNavMeshData(){} // RVA: 0x7ffaaf235ee0
        public void Raycast_Injected(){} // RVA: 0x7ffaaf235f30
        public void CalculatePathInternal_Injected(){} // RVA: 0x7ffaaf235fb0
        public void FindClosestEdge_Injected(){} // RVA: 0x7ffaaf236030
        public void SamplePosition_Injected(){} // RVA: 0x7ffaaf2360a0
        public void CalculateTriangulation_Injected(){} // RVA: 0x7ffaaf236120
        public void AddNavMeshDataTransformedInternal_Injected(){} // RVA: 0x7ffaaf236170
        public void AddLinkInternal_Injected(){} // RVA: 0x7ffaaf2361e0
        public void SamplePositionFilter_Injected(){} // RVA: 0x7ffaaf236250
        public void FindClosestEdgeFilter_Injected(){} // RVA: 0x7ffaaf2362e0
        public void RaycastFilter_Injected(){} // RVA: 0x7ffaaf236360
        public void CalculatePathFilterInternal_Injected(){} // RVA: 0x7ffaaf2363f0
        public void CreateSettings_Injected(){} // RVA: 0x7ffaaf236480
        // ── Binary Analysis Named ──
        public void SetAreaCost(){} // RVA: 0x7ffaaf234d20
        public void GetAreaCost(){} // RVA: 0x7ffaaf234d80
        public void GetAreaFromName(){} // RVA: 0x7ffaaf234dd0
        public void GetSettingsByID(){} // RVA: 0x7ffaaf235d40
        public void GetSettingsCount(){} // RVA: 0x7ffaaf235dc0
        public void GetSettingsByIndex(){} // RVA: 0x7ffaaf235e10
        public void GetSettingsNameFromID(){} // RVA: 0x7ffaaf235e90
        public void GetSettingsByID_Injected(){} // RVA: 0x7ffaaf2364d0
        public void GetSettingsByIndex_Injected(){} // RVA: 0x7ffaaf236530
    }

    public class NavMeshAgent : Behaviour
    {
        // ── Original Methods ──
        public void get_destination(){} // RVA: 0x7ffaaf230980
        public void set_destination(){} // RVA: 0x7ffaaf2309f0
        public void get_stoppingDistance(){} // RVA: 0x7ffaaf230a50
        public void set_stoppingDistance(){} // RVA: 0x7ffaaf230aa0
        public void get_velocity(){} // RVA: 0x7ffaaf230b00
        public void set_velocity(){} // RVA: 0x7ffaaf230b70
        public void get_nextPosition(){} // RVA: 0x7ffaaf230bd0
        public void set_nextPosition(){} // RVA: 0x7ffaaf230c40
        public void get_steeringTarget(){} // RVA: 0x7ffaaf230ca0
        public void get_desiredVelocity(){} // RVA: 0x7ffaaf230d10
        public void get_remainingDistance(){} // RVA: 0x7ffaaf230d80
        public void get_baseOffset(){} // RVA: 0x7ffaaf230dd0
        public void set_baseOffset(){} // RVA: 0x7ffaaf230e20
        public void get_isOnOffMeshLink(){} // RVA: 0x7ffaaf230e80
        public void ActivateCurrentOffMeshLink(){} // RVA: 0x7ffaaf230ed0
        public void get_currentOffMeshLinkData(){} // RVA: 0x7ffaaf230f30
        public void get_nextOffMeshLinkData(){} // RVA: 0x7ffaaf231050
        public void CompleteOffMeshLink(){} // RVA: 0x7ffaaf231170
        public void get_autoTraverseOffMeshLink(){} // RVA: 0x7ffaaf2311c0
        public void set_autoTraverseOffMeshLink(){} // RVA: 0x7ffaaf231210
        public void get_autoBraking(){} // RVA: 0x7ffaaf231270
        public void set_autoBraking(){} // RVA: 0x7ffaaf2312c0
        public void get_autoRepath(){} // RVA: 0x7ffaaf231320
        public void set_autoRepath(){} // RVA: 0x7ffaaf231370
        public void get_hasPath(){} // RVA: 0x7ffaaf2313d0
        public void get_pathPending(){} // RVA: 0x7ffaaf231420
        public void get_isPathStale(){} // RVA: 0x7ffaaf231470
        public void get_pathStatus(){} // RVA: 0x7ffaaf2314c0
        public void get_pathEndPosition(){} // RVA: 0x7ffaaf231510
        public void Warp(){} // RVA: 0x7ffaaf231580
        public void Move(){} // RVA: 0x7ffaaf2315e0
        public void Stop(){} // RVA: 0x7ffaaf231640
        public void Stop(){} // RVA: 0x7ffaaf231640
        public void Resume(){} // RVA: 0x7ffaaf231690
        public void get_isStopped(){} // RVA: 0x7ffaaf2316e0
        public void set_isStopped(){} // RVA: 0x7ffaaf231730
        public void ResetPath(){} // RVA: 0x7ffaaf231790
        public void get_path(){} // RVA: 0x7ffaaf231840
        public void set_path(){} // RVA: 0x7ffaaf231910
        public void CopyPathTo(){} // RVA: 0x7ffaaf2319b0
        public void FindClosestEdge(){} // RVA: 0x7ffaaf231a10
        public void Raycast(){} // RVA: 0x7ffaaf231a70
        public void CalculatePath(){} // RVA: 0x7ffaaf231ae0
        public void CalculatePathInternal(){} // RVA: 0x7ffaaf231b80
        public void SamplePathPosition(){} // RVA: 0x7ffaaf231bf0
        public void get_navMeshOwner(){} // RVA: 0x7ffaaf231e10
        public void get_agentTypeID(){} // RVA: 0x7ffaaf231e60
        public void set_agentTypeID(){} // RVA: 0x7ffaaf231eb0
        public void get_walkableMask(){} // RVA: 0x7ffaaf231f10
        public void set_walkableMask(){} // RVA: 0x7ffaaf231f60
        public void get_areaMask(){} // RVA: 0x7ffaaf231f10
        public void set_areaMask(){} // RVA: 0x7ffaaf231f60
        public void get_speed(){} // RVA: 0x7ffaaf231fc0
        public void set_speed(){} // RVA: 0x7ffaaf232010
        public void get_angularSpeed(){} // RVA: 0x7ffaaf232070
        public void set_angularSpeed(){} // RVA: 0x7ffaaf2320c0
        public void get_acceleration(){} // RVA: 0x7ffaaf232120
        public void set_acceleration(){} // RVA: 0x7ffaaf232170
        public void get_updatePosition(){} // RVA: 0x7ffaaf2321d0
        public void set_updatePosition(){} // RVA: 0x7ffaaf232220
        public void get_updateRotation(){} // RVA: 0x7ffaaf232280
        public void set_updateRotation(){} // RVA: 0x7ffaaf2322d0
        public void get_updateUpAxis(){} // RVA: 0x7ffaaf232330
        public void set_updateUpAxis(){} // RVA: 0x7ffaaf232380
        public void get_radius(){} // RVA: 0x7ffaaf2323e0
        public void set_radius(){} // RVA: 0x7ffaaf232430
        public void get_height(){} // RVA: 0x7ffaaf232490
        public void set_height(){} // RVA: 0x7ffaaf2324e0
        public void get_obstacleAvoidanceType(){} // RVA: 0x7ffaaf232540
        public void set_obstacleAvoidanceType(){} // RVA: 0x7ffaaf232590
        public void get_avoidancePriority(){} // RVA: 0x7ffaaf2325f0
        public void set_avoidancePriority(){} // RVA: 0x7ffaaf232640
        public void get_isOnNavMesh(){} // RVA: 0x7ffaaf2326a0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_destination_Injected(){} // RVA: 0x7ffaaf232750
        public void set_destination_Injected(){} // RVA: 0x7ffaaf2327b0
        public void get_velocity_Injected(){} // RVA: 0x7ffaaf232810
        public void set_velocity_Injected(){} // RVA: 0x7ffaaf232870
        public void get_nextPosition_Injected(){} // RVA: 0x7ffaaf2328d0
        public void set_nextPosition_Injected(){} // RVA: 0x7ffaaf232930
        public void get_steeringTarget_Injected(){} // RVA: 0x7ffaaf232990
        public void get_desiredVelocity_Injected(){} // RVA: 0x7ffaaf2329f0
        public void get_pathEndPosition_Injected(){} // RVA: 0x7ffaaf232b10
        public void Warp_Injected(){} // RVA: 0x7ffaaf232b70
        public void Move_Injected(){} // RVA: 0x7ffaaf232bd0
        public void Raycast_Injected(){} // RVA: 0x7ffaaf232c30
        public void CalculatePathInternal_Injected(){} // RVA: 0x7ffaaf232ca0
        // ── Binary Analysis Named ──
        public void SetDestination(){} // RVA: 0x7ffaaf230920
        public void GetCurrentOffMeshLinkDataInternal(){} // RVA: 0x7ffaaf230fd0
        public void GetNextOffMeshLinkDataInternal(){} // RVA: 0x7ffaaf2310f0
        public void SetPath(){} // RVA: 0x7ffaaf2317e0
        public void SetLayerCost(){} // RVA: 0x7ffaaf231c70
        public void GetLayerCost(){} // RVA: 0x7ffaaf231ce0
        public void SetAreaCost(){} // RVA: 0x7ffaaf231d40
        public void GetAreaCost(){} // RVA: 0x7ffaaf231db0
        public void GetOwnerInternal(){} // RVA: 0x7ffaaf231e10
        public void SetDestination_Injected(){} // RVA: 0x7ffaaf2326f0
        public void GetCurrentOffMeshLinkDataInternal_Injected(){} // RVA: 0x7ffaaf232a50
        public void GetNextOffMeshLinkDataInternal_Injected(){} // RVA: 0x7ffaaf232ab0
    }

    public class NavMeshBuildSource : ValueType
    {
        public object m_Shape; // 0x32D538E0
        public object m_ComponentID; // 0x32D538E0

        // ── Original Methods ──
        public void get_transform(){} // RVA: 0x7ffaaf236a50
        public void set_transform(){} // RVA: 0x7ffaaf236a80
        public void get_size(){} // RVA: 0x7ffaaf236aa0
        public void set_size(){} // RVA: 0x7ffaaf236ac0
        public void get_shape(){} // RVA: 0x7ffaaf236ad0
        public void set_shape(){} // RVA: 0x7ffaaa2a7b40
        public void set_area(){} // RVA: 0x7ffaa8bfb270
        public void get_sourceObject(){} // RVA: 0x7ffaaf236ae0
        public void get_component(){} // RVA: 0x7ffaaf236b30
        public void InternalGetComponent(){} // RVA: 0x7ffaaf236b80
        public void InternalGetObject(){} // RVA: 0x7ffaaf236bd0
    }

    public class NavMeshData : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf233e10
        public void .ctor(){} // RVA: 0x7ffaaf233e10
        public void Internal_Create(){} // RVA: 0x7ffaaf233eb0
        public void get_sourceBounds(){} // RVA: 0x7ffaaf233f10
        public void get_position(){} // RVA: 0x7ffaaf233f80
        public void set_position(){} // RVA: 0x7ffaaf233ff0
        public void get_rotation(){} // RVA: 0x7ffaaf234050
        public void set_rotation(){} // RVA: 0x7ffaaf2340c0
        public void get_sourceBounds_Injected(){} // RVA: 0x7ffaaf234120
        public void get_position_Injected(){} // RVA: 0x7ffaaf234180
        public void set_position_Injected(){} // RVA: 0x7ffaaf2341e0
        public void get_rotation_Injected(){} // RVA: 0x7ffaaf234240
        public void set_rotation_Injected(){} // RVA: 0x7ffaaf2342a0
    }

    public class NavMeshObstacle : Behaviour
    {
        // ── Original Methods ──
        public void get_height(){} // RVA: 0x7ffaaf232d10
        public void set_height(){} // RVA: 0x7ffaaf232d60
        public void get_radius(){} // RVA: 0x7ffaaf232dc0
        public void set_radius(){} // RVA: 0x7ffaaf232e10
        public void get_velocity(){} // RVA: 0x7ffaaf232e70
        public void set_velocity(){} // RVA: 0x7ffaaf232ee0
        public void get_carving(){} // RVA: 0x7ffaaf232f40
        public void set_carving(){} // RVA: 0x7ffaaf232f90
        public void get_carveOnlyStationary(){} // RVA: 0x7ffaaf232ff0
        public void set_carveOnlyStationary(){} // RVA: 0x7ffaaf233040
        public void get_carvingMoveThreshold(){} // RVA: 0x7ffaaf2330a0
        public void set_carvingMoveThreshold(){} // RVA: 0x7ffaaf2330f0
        public void get_carvingTimeToStationary(){} // RVA: 0x7ffaaf233150
        public void set_carvingTimeToStationary(){} // RVA: 0x7ffaaf2331a0
        public void get_shape(){} // RVA: 0x7ffaaf233200
        public void set_shape(){} // RVA: 0x7ffaaf233250
        public void get_center(){} // RVA: 0x7ffaaf2332b0
        public void set_center(){} // RVA: 0x7ffaaf233320
        public void get_size(){} // RVA: 0x7ffaaf233380
        public void set_size(){} // RVA: 0x7ffaaf2333f0
        public void FitExtents(){} // RVA: 0x7ffaaf233450
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_velocity_Injected(){} // RVA: 0x7ffaaf2334a0
        public void set_velocity_Injected(){} // RVA: 0x7ffaaf233500
        public void get_center_Injected(){} // RVA: 0x7ffaaf233560
        public void set_center_Injected(){} // RVA: 0x7ffaaf2335c0
        public void get_size_Injected(){} // RVA: 0x7ffaaf233620
        public void set_size_Injected(){} // RVA: 0x7ffaaf233680
    }

    public class NavMeshTriangulation : ValueType
    {
        public object areas; // 0x32D53D30
    }

    public class OffMeshLink : Behaviour
    {
        // ── Original Methods ──
        public void get_activated(){} // RVA: 0x7ffaaf233790
        public void set_activated(){} // RVA: 0x7ffaaf2337e0
        public void get_occupied(){} // RVA: 0x7ffaaf233840
        public void get_costOverride(){} // RVA: 0x7ffaaf233890
        public void set_costOverride(){} // RVA: 0x7ffaaf2338e0
        public void get_biDirectional(){} // RVA: 0x7ffaaf233940
        public void set_biDirectional(){} // RVA: 0x7ffaaf233990
        public void UpdatePositions(){} // RVA: 0x7ffaaf2339f0
        public void get_navMeshLayer(){} // RVA: 0x7ffaaf233a40
        public void set_navMeshLayer(){} // RVA: 0x7ffaaf233a90
        public void get_area(){} // RVA: 0x7ffaaf233a40
        public void set_area(){} // RVA: 0x7ffaaf233a90
        public void get_autoUpdatePositions(){} // RVA: 0x7ffaaf233af0
        public void set_autoUpdatePositions(){} // RVA: 0x7ffaaf233b40
        public void get_startTransform(){} // RVA: 0x7ffaaf233ba0
        public void set_startTransform(){} // RVA: 0x7ffaaf233bf0
        public void get_endTransform(){} // RVA: 0x7ffaaf233c50
        public void set_endTransform(){} // RVA: 0x7ffaaf233ca0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}