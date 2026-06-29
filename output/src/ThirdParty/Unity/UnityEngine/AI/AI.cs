// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.AI
// Classes: 19
// Methods: 376

namespace ThirdParty.Unity.UnityEngine.AI
{
    public class NavMesh : Object
    {
        // ── Methods ──
        public void Internal_CallOnNavMeshPreUpdate(){} // RVA: 0x7AEE591D0
        public void Raycast(){} // RVA: 0x7AEE5A1A0
        public void CalculatePath(){} // RVA: 0x7AEE5A2D0
        public void CalculatePathInternal(){} // RVA: 0x7AEE59370
        public void FindClosestEdge(){} // RVA: 0x7AEE5A090
        public void SamplePosition(){} // RVA: 0x7AEE59F60
        public void SetAreaCost(){} // RVA: 0x7AEE594E0
        public void GetAreaCost(){} // RVA: 0x7AEE59540
        public void GetAreaFromName(){} // RVA: 0x7AEE59590
        public void CalculateTriangulation(){} // RVA: 0x7AEE595E0
        public void get_avoidancePredictionTime(){} // RVA: 0x7AEE59640
        public void set_avoidancePredictionTime(){} // RVA: 0x7AEE59690
        public void AddNavMeshData(){} // RVA: 0x7AEE59840
        public void RemoveNavMeshData(){} // RVA: 0x7AEE599D0
        public void IsValidNavMeshDataHandle(){} // RVA: 0x7AEE59A20
        public void IsValidLinkHandle(){} // RVA: 0x7AEE59A70
        public void InternalGetOwner(){} // RVA: 0x7AEE59AC0
        public void InternalSetOwner(){} // RVA: 0x7AEE59B10
        public void InternalGetLinkOwner(){} // RVA: 0x7AEE59B70
        public void InternalSetLinkOwner(){} // RVA: 0x7AEE59BC0
        public void AddNavMeshDataInternal(){} // RVA: 0x7AEE59C20
        public void AddNavMeshDataTransformedInternal(){} // RVA: 0x7AEE59C70
        public void RemoveNavMeshDataInternal(){} // RVA: 0x7AEE599D0
        public void AddLink(){} // RVA: 0x7AEE59E00
        public void RemoveLink(){} // RVA: 0x7AEE59EA0
        public void AddLinkInternal(){} // RVA: 0x7AEE59EF0
        public void RemoveLinkInternal(){} // RVA: 0x7AEE59EA0
        public void SamplePositionFilter(){} // RVA: 0x7AEE5A000
        public void FindClosestEdgeFilter(){} // RVA: 0x7AEE5A120
        public void RaycastFilter(){} // RVA: 0x7AEE5A240
        public void CalculatePathFilterInternal(){} // RVA: 0x7AEE5A3A0
        public void CreateSettings(){} // RVA: 0x7AEE5A440
        public void RemoveSettings(){} // RVA: 0x7AEE5A4B0
        public void GetSettingsByID(){} // RVA: 0x7AEE5A500
        public void GetSettingsCount(){} // RVA: 0x7AEE5A580
        public void GetSettingsByIndex(){} // RVA: 0x7AEE5A5D0
        public void GetSettingsNameFromID(){} // RVA: 0x7AEE5A650
        public void RemoveAllNavMeshData(){} // RVA: 0x7AEE5A6A0
        public void Raycast_Injected(){} // RVA: 0x7AEE5A6F0
        public void CalculatePathInternal_Injected(){} // RVA: 0x7AEE5A770
        public void FindClosestEdge_Injected(){} // RVA: 0x7AEE5A7F0
        public void SamplePosition_Injected(){} // RVA: 0x7AEE5A860
        public void CalculateTriangulation_Injected(){} // RVA: 0x7AEE5A8E0
        public void AddNavMeshDataTransformedInternal_Injected(){} // RVA: 0x7AEE5A930
        public void AddLinkInternal_Injected(){} // RVA: 0x7AEE5A9A0
        public void SamplePositionFilter_Injected(){} // RVA: 0x7AEE5AA10
        public void FindClosestEdgeFilter_Injected(){} // RVA: 0x7AEE5AAA0
        public void RaycastFilter_Injected(){} // RVA: 0x7AEE5AB20
        public void CalculatePathFilterInternal_Injected(){} // RVA: 0x7AEE5ABB0
        public void CreateSettings_Injected(){} // RVA: 0x7AEE5AC40
        public void GetSettingsByID_Injected(){} // RVA: 0x7AEE5AC90
        public void GetSettingsByIndex_Injected(){} // RVA: 0x7AEE5ACF0
    }

    public class NavMeshAgent : Behaviour
    {
        // ── Methods ──
        public void SetDestination(){} // RVA: 0x7AEE550D0
        public void get_destination(){} // RVA: 0x7AEE55130
        public void set_destination(){} // RVA: 0x7AEE551A0
        public void get_stoppingDistance(){} // RVA: 0x7AEE55200
        public void set_stoppingDistance(){} // RVA: 0x7AEE55250
        public void get_velocity(){} // RVA: 0x7AEE552B0
        public void set_velocity(){} // RVA: 0x7AEE55320
        public void get_nextPosition(){} // RVA: 0x7AEE55380
        public void set_nextPosition(){} // RVA: 0x7AEE553F0
        public void get_steeringTarget(){} // RVA: 0x7AEE55450
        public void get_desiredVelocity(){} // RVA: 0x7AEE554C0
        public void get_remainingDistance(){} // RVA: 0x7AEE55530
        public void get_baseOffset(){} // RVA: 0x7AEE55580
        public void set_baseOffset(){} // RVA: 0x7AEE555D0
        public void get_isOnOffMeshLink(){} // RVA: 0x7AEE55630
        public void ActivateCurrentOffMeshLink(){} // RVA: 0x7AEE55680
        public void get_currentOffMeshLinkData(){} // RVA: 0x7AEE556E0
        public void GetCurrentOffMeshLinkDataInternal(){} // RVA: 0x7AEE55780
        public void get_nextOffMeshLinkData(){} // RVA: 0x7AEE55800
        public void GetNextOffMeshLinkDataInternal(){} // RVA: 0x7AEE558A0
        public void CompleteOffMeshLink(){} // RVA: 0x7AEE55920
        public void get_autoTraverseOffMeshLink(){} // RVA: 0x7AEE55970
        public void set_autoTraverseOffMeshLink(){} // RVA: 0x7AEE559C0
        public void get_autoBraking(){} // RVA: 0x7AEE55A20
        public void set_autoBraking(){} // RVA: 0x7AEE55A70
        public void get_autoRepath(){} // RVA: 0x7AEE55AD0
        public void set_autoRepath(){} // RVA: 0x7AEE55B20
        public void get_hasPath(){} // RVA: 0x7AEE55B80
        public void get_pathPending(){} // RVA: 0x7AEE55BD0
        public void get_isPathStale(){} // RVA: 0x7AEE55C20
        public void get_pathStatus(){} // RVA: 0x7AEE55C70
        public void get_pathEndPosition(){} // RVA: 0x7AEE55CC0
        public void Warp(){} // RVA: 0x7AEE55D30
        public void Move(){} // RVA: 0x7AEE55D90
        public void Stop(){} // RVA: 0x7AEE55DF0
        public void Resume(){} // RVA: 0x7AEE55E40
        public void get_isStopped(){} // RVA: 0x7AEE55E90
        public void set_isStopped(){} // RVA: 0x7AEE55EE0
        public void ResetPath(){} // RVA: 0x7AEE55F40
        public void SetPath(){} // RVA: 0x7AEE55F90
        public void get_path(){} // RVA: 0x7AEE55FF0
        public void set_path(){} // RVA: 0x7AEE560C0
        public void CopyPathTo(){} // RVA: 0x7AEE56160
        public void FindClosestEdge(){} // RVA: 0x7AEE561C0
        public void Raycast(){} // RVA: 0x7AEE56220
        public void CalculatePath(){} // RVA: 0x7AEE56290
        public void CalculatePathInternal(){} // RVA: 0x7AEE56330
        public void SamplePathPosition(){} // RVA: 0x7AEE563A0
        public void SetLayerCost(){} // RVA: 0x7AEE56420
        public void GetLayerCost(){} // RVA: 0x7AEE56490
        public void SetAreaCost(){} // RVA: 0x7AEE564F0
        public void GetAreaCost(){} // RVA: 0x7AEE56560
        public void get_navMeshOwner(){} // RVA: 0x7AEE565C0
        public void get_agentTypeID(){} // RVA: 0x7AEE56610
        public void set_agentTypeID(){} // RVA: 0x7AEE56660
        public void GetOwnerInternal(){} // RVA: 0x7AEE565C0
        public void get_walkableMask(){} // RVA: 0x7AEE566C0
        public void set_walkableMask(){} // RVA: 0x7AEE56710
        public void get_areaMask(){} // RVA: 0x7AEE566C0
        public void set_areaMask(){} // RVA: 0x7AEE56710
        public void get_speed(){} // RVA: 0x7AEE56770
        public void set_speed(){} // RVA: 0x7AEE567C0
        public void get_angularSpeed(){} // RVA: 0x7AEE56820
        public void set_angularSpeed(){} // RVA: 0x7AEE56870
        public void get_acceleration(){} // RVA: 0x7AEE568D0
        public void set_acceleration(){} // RVA: 0x7AEE56920
        public void get_updatePosition(){} // RVA: 0x7AEE56980
        public void set_updatePosition(){} // RVA: 0x7AEE569D0
        public void get_updateRotation(){} // RVA: 0x7AEE56A30
        public void set_updateRotation(){} // RVA: 0x7AEE56A80
        public void get_updateUpAxis(){} // RVA: 0x7AEE56AE0
        public void set_updateUpAxis(){} // RVA: 0x7AEE56B30
        public void get_radius(){} // RVA: 0x7AEE56B90
        public void set_radius(){} // RVA: 0x7AEE56BE0
        public void get_height(){} // RVA: 0x7AEE56C40
        public void set_height(){} // RVA: 0x7AEE56C90
        public void get_obstacleAvoidanceType(){} // RVA: 0x7AEE56CF0
        public void set_obstacleAvoidanceType(){} // RVA: 0x7AEE56D40
        public void get_avoidancePriority(){} // RVA: 0x7AEE56DA0
        public void set_avoidancePriority(){} // RVA: 0x7AEE56DF0
        public void get_isOnNavMesh(){} // RVA: 0x7AEE56E50
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void SetDestination_Injected(){} // RVA: 0x7AEE56EA0
        public void get_destination_Injected(){} // RVA: 0x7AEE56F00
        public void set_destination_Injected(){} // RVA: 0x7AEE56F60
        public void get_velocity_Injected(){} // RVA: 0x7AEE56FC0
        public void set_velocity_Injected(){} // RVA: 0x7AEE57020
        public void get_nextPosition_Injected(){} // RVA: 0x7AEE57080
        public void set_nextPosition_Injected(){} // RVA: 0x7AEE570E0
        public void get_steeringTarget_Injected(){} // RVA: 0x7AEE57140
        public void get_desiredVelocity_Injected(){} // RVA: 0x7AEE571A0
        public void GetCurrentOffMeshLinkDataInternal_Injected(){} // RVA: 0x7AEE57200
        public void GetNextOffMeshLinkDataInternal_Injected(){} // RVA: 0x7AEE57260
        public void get_pathEndPosition_Injected(){} // RVA: 0x7AEE572C0
        public void Warp_Injected(){} // RVA: 0x7AEE57320
        public void Move_Injected(){} // RVA: 0x7AEE57380
        public void Raycast_Injected(){} // RVA: 0x7AEE573E0
        public void CalculatePathInternal_Injected(){} // RVA: 0x7AEE57450
    }

    public class NavMeshBuildMarkup : ValueType
    {
        // ── Methods ──
        public void set_overrideArea(){} // RVA: 0x7A7E666D0
        public void set_area(){} // RVA: 0x7A765F090
        public void set_ignoreFromBuild(){} // RVA: 0x7A7ED4330
        public void set_overrideGenerateLinks(){} // RVA: 0x7A7ED4340
        public void set_generateLinks(){} // RVA: 0x7A7ED4350
        public void set_applyToChildren(){} // RVA: 0x7A7ED4360
        public void set_root(){} // RVA: 0x7A7ED4370
    }

    public class NavMeshBuildSettings : ValueType
    {
        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x7A79EAED0
        public void set_agentTypeID(){} // RVA: 0x7A76134D0
        public void get_agentRadius(){} // RVA: 0x7A7ED4380
        public void set_agentRadius(){} // RVA: 0x7A76B8940
        public void get_agentHeight(){} // RVA: 0x7A7ED4390
        public void set_agentHeight(){} // RVA: 0x7A76B8930
        public void get_agentSlope(){} // RVA: 0x7A7ED43A0
        public void set_agentSlope(){} // RVA: 0x7A76B8970
        public void get_agentClimb(){} // RVA: 0x7A7ED43B0
        public void set_agentClimb(){} // RVA: 0x7A76E1BA0
        public void get_ledgeDropHeight(){} // RVA: 0x7A7832350
        public void set_ledgeDropHeight(){} // RVA: 0x7A76870C0
        public void get_maxJumpAcrossDistance(){} // RVA: 0x7A7ED3A80
        public void set_maxJumpAcrossDistance(){} // RVA: 0x7A7687100
        public void get_minRegionArea(){} // RVA: 0x7A7ED43C0
        public void set_minRegionArea(){} // RVA: 0x7A76870E0
        public void get_overrideVoxelSize(){} // RVA: 0x7A7ED3AA0
        public void set_overrideVoxelSize(){} // RVA: 0x7A7ED3AB0
        public void get_voxelSize(){} // RVA: 0x7A7ED43D0
        public void set_voxelSize(){} // RVA: 0x7A76870D0
        public void get_overrideTileSize(){} // RVA: 0x7A7ED43E0
        public void set_overrideTileSize(){} // RVA: 0x7A7ED43F0
        public void get_tileSize(){} // RVA: 0x7A7ED4400
        public void set_tileSize(){} // RVA: 0x7A7719790
        public void get_preserveTilesOutsideBounds(){} // RVA: 0x7A7ED4410
        public void set_preserveTilesOutsideBounds(){} // RVA: 0x7A7ED4420
        public void get_buildHeightMesh(){} // RVA: 0x7A7ED4430
        public void set_buildHeightMesh(){} // RVA: 0x7A7ED4440
        public void get_debug(){} // RVA: 0x7A7ED4450
        public void set_debug(){} // RVA: 0x7A7ED4460
        public void ValidationReport(){} // RVA: 0x7A7ED4470
        public void InternalValidationReport(){} // RVA: 0x7AEE5B650
        public void InternalValidationReport_Injected(){} // RVA: 0x7AEE5B6B0
    }

    public class NavMeshBuildSource : ValueType
    {
        // ── Methods ──
        public void get_transform(){} // RVA: 0x7A79FB250
        public void set_transform(){} // RVA: 0x7A79FB230
        public void get_size(){} // RVA: 0x7A7ED4240
        public void set_size(){} // RVA: 0x7A7ED4260
        public void get_shape(){} // RVA: 0x7A7ED4270
        public void set_shape(){} // RVA: 0x7A7A3B200
        public void set_area(){} // RVA: 0x7A7ED4280
        public void get_sourceObject(){} // RVA: 0x7A7ED4290
        public void get_component(){} // RVA: 0x7A7ED42E0
        public void InternalGetComponent(){} // RVA: 0x7AEE5B340
        public void InternalGetObject(){} // RVA: 0x7AEE5B390
    }

    public class NavMeshBuildSource[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A40C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29ED50
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E4690
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25DB30
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29ED50
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class NavMeshBuilder : Object
    {
        // ── Methods ──
        public void CollectSources(){} // RVA: 0x7AEE54690
        public void CollectSourcesInternal(){} // RVA: 0x7AEE548B0
        public void BuildNavMeshData(){} // RVA: 0x7AEE54970
        public void UpdateNavMeshDataListInternal(){} // RVA: 0x7AEE54C10
        public void UpdateNavMeshDataAsync(){} // RVA: 0x7AEE54C90
        public void UpdateNavMeshDataAsyncListInternal(){} // RVA: 0x7AEE54EB0
        public void CollectSourcesInternal_Injected(){} // RVA: 0x7AEE54F30
        public void UpdateNavMeshDataListInternal_Injected(){} // RVA: 0x7AEE54FD0
        public void UpdateNavMeshDataAsyncListInternal_Injected(){} // RVA: 0x7AEE55050
    }

    public class NavMeshData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE585C0
        public void Internal_Create(){} // RVA: 0x7AEE58660
        public void get_sourceBounds(){} // RVA: 0x7AEE586C0
        public void get_position(){} // RVA: 0x7AEE58730
        public void set_position(){} // RVA: 0x7AEE587A0
        public void get_rotation(){} // RVA: 0x7AEE58800
        public void set_rotation(){} // RVA: 0x7AEE58870
        public void get_sourceBounds_Injected(){} // RVA: 0x7AEE588D0
        public void get_position_Injected(){} // RVA: 0x7AEE58930
        public void set_position_Injected(){} // RVA: 0x7AEE58990
        public void get_rotation_Injected(){} // RVA: 0x7AEE589F0
        public void set_rotation_Injected(){} // RVA: 0x7AEE58A50
    }

    public class NavMeshDataInstance : ValueType
    {
        // ── Methods ──
        public void get_valid(){} // RVA: 0x7A7ED3E00
        public void get_id(){} // RVA: 0x7A765F070
        public void set_id(){} // RVA: 0x7A76134D0
        public void Remove(){} // RVA: 0x7A7ED3E10
        public void get_owner(){} // RVA: 0x7A7ED3E60
        public void set_owner(){} // RVA: 0x7A7ED3EB0
    }

    public class NavMeshHit : ValueType
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x7A79F03C0
        public void set_position(){} // RVA: 0x7A79F03B0
        public void get_normal(){} // RVA: 0x7A7ED3A50
        public void set_normal(){} // RVA: 0x7A7ED3A70
        public void get_distance(){} // RVA: 0x7A7ED3A80
        public void set_distance(){} // RVA: 0x7A7687100
        public void get_mask(){} // RVA: 0x7A7ED3A90
        public void set_mask(){} // RVA: 0x7A768B140
        public void get_hit(){} // RVA: 0x7A7ED3AA0
        public void set_hit(){} // RVA: 0x7A7ED3AB0
    }

    public class NavMeshLinkData : ValueType
    {
        // ── Methods ──
        public void get_startPosition(){} // RVA: 0x7A79F03C0
        public void set_startPosition(){} // RVA: 0x7A79F03B0
        public void get_endPosition(){} // RVA: 0x7A7ED3A50
        public void set_endPosition(){} // RVA: 0x7A7ED3A70
        public void get_costModifier(){} // RVA: 0x7A7ED3A80
        public void set_costModifier(){} // RVA: 0x7A7687100
        public void get_bidirectional(){} // RVA: 0x7A7ED3EC0
        public void set_bidirectional(){} // RVA: 0x7A7ED3ED0
        public void get_width(){} // RVA: 0x7A7ED3EE0
        public void set_width(){} // RVA: 0x7A7687080
        public void get_area(){} // RVA: 0x7A7ED3EF0
        public void set_area(){} // RVA: 0x7A76C73E0
        public void get_agentTypeID(){} // RVA: 0x7A7AD20B0
        public void set_agentTypeID(){} // RVA: 0x7A765EDE0
    }

    public class NavMeshLinkInstance : ValueType
    {
        // ── Methods ──
        public void get_valid(){} // RVA: 0x7A7ED3F00
        public void get_id(){} // RVA: 0x7A765F070
        public void set_id(){} // RVA: 0x7A76134D0
        public void Remove(){} // RVA: 0x7A7ED3F10
        public void get_owner(){} // RVA: 0x7A7ED3F60
        public void set_owner(){} // RVA: 0x7A7ED3FB0
    }

    public class NavMeshObstacle : Behaviour
    {
        // ── Methods ──
        public void get_height(){} // RVA: 0x7AEE574C0
        public void set_height(){} // RVA: 0x7AEE57510
        public void get_radius(){} // RVA: 0x7AEE57570
        public void set_radius(){} // RVA: 0x7AEE575C0
        public void get_velocity(){} // RVA: 0x7AEE57620
        public void set_velocity(){} // RVA: 0x7AEE57690
        public void get_carving(){} // RVA: 0x7AEE576F0
        public void set_carving(){} // RVA: 0x7AEE57740
        public void get_carveOnlyStationary(){} // RVA: 0x7AEE577A0
        public void set_carveOnlyStationary(){} // RVA: 0x7AEE577F0
        public void get_carvingMoveThreshold(){} // RVA: 0x7AEE57850
        public void set_carvingMoveThreshold(){} // RVA: 0x7AEE578A0
        public void get_carvingTimeToStationary(){} // RVA: 0x7AEE57900
        public void set_carvingTimeToStationary(){} // RVA: 0x7AEE57950
        public void get_shape(){} // RVA: 0x7AEE579B0
        public void set_shape(){} // RVA: 0x7AEE57A00
        public void get_center(){} // RVA: 0x7AEE57A60
        public void set_center(){} // RVA: 0x7AEE57AD0
        public void get_size(){} // RVA: 0x7AEE57B30
        public void set_size(){} // RVA: 0x7AEE57BA0
        public void FitExtents(){} // RVA: 0x7AEE57C00
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_velocity_Injected(){} // RVA: 0x7AEE57C50
        public void set_velocity_Injected(){} // RVA: 0x7AEE57CB0
        public void get_center_Injected(){} // RVA: 0x7AEE57D10
        public void set_center_Injected(){} // RVA: 0x7AEE57D70
        public void get_size_Injected(){} // RVA: 0x7AEE57DD0
        public void set_size_Injected(){} // RVA: 0x7AEE57E30
    }

    public class NavMeshPath : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE5AD50
        public void Finalize(){} // RVA: 0x7AEE5ADA0
        public void InitializeNavMeshPath(){} // RVA: 0x7AEE5AE30
        public void DestroyNavMeshPath(){} // RVA: 0x7AEE5AE80
        public void GetCornersNonAlloc(){} // RVA: 0x7AEE5AED0
        public void CalculateCornersInternal(){} // RVA: 0x7AEE5AF30
        public void ClearCornersInternal(){} // RVA: 0x7AEE5AF80
        public void ClearCorners(){} // RVA: 0x7AEE5AFD0
        public void CalculateCorners(){} // RVA: 0x7AEE5B070
        public void get_corners(){} // RVA: 0x7AEE5B110
        public void get_status(){} // RVA: 0x7AEE5B1C0
    }

    public class NavMeshQueryFilter : ValueType
    {
        // ── Methods ──
        public void get_costs(){} // RVA: 0x7A765F710
        public void set_costs(){} // RVA: 0x7A7637E60
        public void get_areaMask(){} // RVA: 0x7A75FEFA0
        public void set_areaMask(){} // RVA: 0x7A767FBC0
        public void get_agentTypeID(){} // RVA: 0x7A767FBD0
        public void set_agentTypeID(){} // RVA: 0x7A767FBE0
        public void GetAreaCost(){} // RVA: 0x7A7ED4080
        public void SetAreaCost(){} // RVA: 0x7A7ED4090
    }

    public class NavMeshTriangulation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1330
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DF80
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2C90
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250480
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DF80
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class NavMesh[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class OffMeshLink : Behaviour
    {
        // ── Methods ──
        public void get_activated(){} // RVA: 0x7AEE57F40
        public void set_activated(){} // RVA: 0x7AEE57F90
        public void get_occupied(){} // RVA: 0x7AEE57FF0
        public void get_costOverride(){} // RVA: 0x7AEE58040
        public void set_costOverride(){} // RVA: 0x7AEE58090
        public void get_biDirectional(){} // RVA: 0x7AEE580F0
        public void set_biDirectional(){} // RVA: 0x7AEE58140
        public void UpdatePositions(){} // RVA: 0x7AEE581A0
        public void get_navMeshLayer(){} // RVA: 0x7AEE581F0
        public void set_navMeshLayer(){} // RVA: 0x7AEE58240
        public void get_area(){} // RVA: 0x7AEE581F0
        public void set_area(){} // RVA: 0x7AEE58240
        public void get_autoUpdatePositions(){} // RVA: 0x7AEE582A0
        public void set_autoUpdatePositions(){} // RVA: 0x7AEE582F0
        public void get_startTransform(){} // RVA: 0x7AEE58350
        public void set_startTransform(){} // RVA: 0x7AEE583A0
        public void get_endTransform(){} // RVA: 0x7AEE58400
        public void set_endTransform(){} // RVA: 0x7AEE58450
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class OffMeshLinkData : ValueType
    {
        // ── Methods ──
        public void get_valid(){} // RVA: 0x7A7E520D0
        public void get_activated(){} // RVA: 0x7A7ED39F0
        public void get_linkType(){} // RVA: 0x7A767FBD0
        public void get_startPos(){} // RVA: 0x7A7824240
        public void get_endPos(){} // RVA: 0x7A7EB3CA0
        public void get_offMeshLink(){} // RVA: 0x7A7ED3A00
        public void GetOffMeshLinkInternal(){} // RVA: 0x7AEE57EF0
    }

}