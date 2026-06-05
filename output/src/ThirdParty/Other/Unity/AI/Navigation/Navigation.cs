// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.AI.Navigation
// Classes: 4
// Methods: 112

namespace ThirdParty.Other.Unity.AI.Navigation
{
    public class NavMeshLink
    {
        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x7FFAF3210030
        public void set_agentTypeID(){} // RVA: 0x7FFAF9815F50
        public void get_startPoint(){} // RVA: 0x7FFAF2DE8CA0
        public void set_startPoint(){} // RVA: 0x7FFAF9815FC0
        public void get_endPoint(){} // RVA: 0x7FFAF45F14E0
        public void set_endPoint(){} // RVA: 0x7FFAF9816040
        public void get_width(){} // RVA: 0x7FFAF34AC6D0
        public void set_width(){} // RVA: 0x7FFAF98160C0
        public void get_costModifier(){} // RVA: 0x7FFAF2E2E080
        public void set_costModifier(){} // RVA: 0x7FFAF9816130
        public void get_bidirectional(){} // RVA: 0x7FFAF45A8C70
        public void set_bidirectional(){} // RVA: 0x7FFAF98161A0
        public void get_autoUpdate(){} // RVA: 0x7FFAF4740FC0
        public void set_autoUpdate(){} // RVA: 0x7FFAF9816210
        public void get_area(){} // RVA: 0x7FFAF2E2E0C0
        public void set_area(){} // RVA: 0x7FFAF98162A0
        public void OnEnable(){} // RVA: 0x7FFAF9816310
        public void OnDisable(){} // RVA: 0x7FFAF9816390
        public void UpdateLink(){} // RVA: 0x7FFAF9816430
        public void AddTracking(){} // RVA: 0x7FFAF98164A0
        public void RemoveTracking(){} // RVA: 0x7FFAF9816700
        public void SetAutoUpdate(){} // RVA: 0x7FFAF9816210
        public void AddLink(){} // RVA: 0x7FFAF9816910
        public void HasTransformChanged(){} // RVA: 0x7FFAF9816CE0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAF9816430
        public void UpdateTrackedInstances(){} // RVA: 0x7FFAF9816F00
        public void .ctor(){} // RVA: 0x7FFAF98170A0
        public void .cctor(){} // RVA: 0x7FFAF98171A0
    }

    public class NavMeshModifier
    {
        // ── Methods ──
        public void get_overrideArea(){} // RVA: 0x7FFAF2E7B9D0
        public void set_overrideArea(){} // RVA: 0x7FFAF2E7B9E0
        public void get_area(){} // RVA: 0x7FFAF379F5B0
        public void set_area(){} // RVA: 0x7FFAF4191F00
        public void get_overrideGenerateLinks(){} // RVA: 0x7FFAF3198A80
        public void set_overrideGenerateLinks(){} // RVA: 0x7FFAF3198B80
        public void get_generateLinks(){} // RVA: 0x7FFAF36E6000
        public void set_generateLinks(){} // RVA: 0x7FFAF43BAB20
        public void get_ignoreFromBuild(){} // RVA: 0x7FFAF4B0EA40
        public void set_ignoreFromBuild(){} // RVA: 0x7FFAF4B0EA30
        public void get_applyToChildren(){} // RVA: 0x7FFAF4B0EA50
        public void set_applyToChildren(){} // RVA: 0x7FFAF4B0EA20
        public void get_activeModifiers(){} // RVA: 0x7FFAF9817280
        public void OnEnable(){} // RVA: 0x7FFAF98172E0
        public void OnDisable(){} // RVA: 0x7FFAF9817430
        public void AffectsAgentType(){} // RVA: 0x7FFAF98174C0
        public void .ctor(){} // RVA: 0x7FFAF98175C0
        public void .cctor(){} // RVA: 0x7FFAF9817710
    }

    public class NavMeshModifierVolume
    {
        // ── Methods ──
        public void get_size(){} // RVA: 0x7FFAF2DF3EE0
        public void set_size(){} // RVA: 0x7FFAF2DF3F00
        public void get_center(){} // RVA: 0x7FFAF2DF3F10
        public void set_center(){} // RVA: 0x7FFAF2DF3F30
        public void get_area(){} // RVA: 0x7FFAF3A8C9F0
        public void set_area(){} // RVA: 0x7FFAF3A8D6E0
        public void get_activeModifiers(){} // RVA: 0x7FFAF98177F0
        public void OnEnable(){} // RVA: 0x7FFAF9817850
        public void OnDisable(){} // RVA: 0x7FFAF98179A0
        public void AffectsAgentType(){} // RVA: 0x7FFAF9817A30
        public void .ctor(){} // RVA: 0x7FFAF9817B30
        public void .cctor(){} // RVA: 0x7FFAF9817CB0
    }

    public class NavMeshSurface
    {
        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x7FFAF3210030
        public void set_agentTypeID(){} // RVA: 0x7FFAF344E0D0
        public void get_collectObjects(){} // RVA: 0x7FFAF379F5B0
        public void set_collectObjects(){} // RVA: 0x7FFAF4191F00
        public void get_size(){} // RVA: 0x7FFAF2E08700
        public void set_size(){} // RVA: 0x7FFAF2E08720
        public void get_center(){} // RVA: 0x7FFAF9817D90
        public void set_center(){} // RVA: 0x7FFAF9817DB0
        public void get_layerMask(){} // RVA: 0x7FFAF2E2E080
        public void set_layerMask(){} // RVA: 0x7FFAF2E2E090
        public void get_useGeometry(){} // RVA: 0x7FFAF2E2E0A0
        public void set_useGeometry(){} // RVA: 0x7FFAF2E2E0B0
        public void get_defaultArea(){} // RVA: 0x7FFAF2E2E0C0
        public void set_defaultArea(){} // RVA: 0x7FFAF2E2E0D0
        public void get_ignoreNavMeshAgent(){} // RVA: 0x7FFAF94F2700
        public void set_ignoreNavMeshAgent(){} // RVA: 0x7FFAF9817DC0
        public void get_ignoreNavMeshObstacle(){} // RVA: 0x7FFAF9817DD0
        public void set_ignoreNavMeshObstacle(){} // RVA: 0x7FFAF9817DE0
        public void get_overrideTileSize(){} // RVA: 0x7FFAF9817DF0
        public void set_overrideTileSize(){} // RVA: 0x7FFAF9817E00
        public void get_tileSize(){} // RVA: 0x7FFAF304C540
        public void set_tileSize(){} // RVA: 0x7FFAF310F570
        public void get_overrideVoxelSize(){} // RVA: 0x7FFAF368B570
        public void set_overrideVoxelSize(){} // RVA: 0x7FFAF45A0B50
        public void get_voxelSize(){} // RVA: 0x7FFAF2DB5FE0
        public void set_voxelSize(){} // RVA: 0x7FFAF2DB5FF0
        public void get_minRegionArea(){} // RVA: 0x7FFAF2DB6000
        public void set_minRegionArea(){} // RVA: 0x7FFAF2DB6010
        public void get_buildHeightMesh(){} // RVA: 0x7FFAF2E55570
        public void set_buildHeightMesh(){} // RVA: 0x7FFAF2E55580
        public void get_navMeshData(){} // RVA: 0x7FFAF2E2B370
        public void set_navMeshData(){} // RVA: 0x7FFAF2E2B380
        public void get_navMeshDataInstance(){} // RVA: 0x7FFAF4741460
        public void get_activeSurfaces(){} // RVA: 0x7FFAF9817E10
        public void GetInflatedBounds(){} // RVA: 0x7FFAF9817E70
        public void OnEnable(){} // RVA: 0x7FFAF9817F80
        public void OnDisable(){} // RVA: 0x7FFAF9817FE0
        public void AddData(){} // RVA: 0x7FFAF9818080
        public void RemoveData(){} // RVA: 0x7FFAF9818470
        public void GetBuildSettings(){} // RVA: 0x7FFAF98184D0
        public void BuildNavMesh(){} // RVA: 0x7FFAF98186D0
        public void UpdateNavMesh(){} // RVA: 0x7FFAF9818BB0
        public void Register(){} // RVA: 0x7FFAF9818F00
        public void Unregister(){} // RVA: 0x7FFAF98191F0
        public void UpdateActive(){} // RVA: 0x7FFAF9819400
        public void AppendModifierVolumes(){} // RVA: 0x7FFAF9819520
        public void CollectSources(){} // RVA: 0x7FFAF9819D80
        public void Abs(){} // RVA: 0x7FFAF4805D90
        public void GetWorldBounds(){} // RVA: 0x7FFAF981AB30
        public void CalculateWorldBounds(){} // RVA: 0x7FFAF981AFB0
        public void HasTransformChanged(){} // RVA: 0x7FFAF981BB50
        public void UpdateDataIfTransformChanged(){} // RVA: 0x7FFAF981BD70
        public void .ctor(){} // RVA: 0x7FFAF981BDB0
        public void .cctor(){} // RVA: 0x7FFAF981BEC0
    }

}