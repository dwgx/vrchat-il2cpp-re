// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.AI.Navigation
// Classes: 4
// Methods: 112

namespace ThirdParty.Other.Unity.AI.Navigation
{
    public class NavMeshLink : MonoBehaviour
    {
        public object m_EndPoint; // 0x3381C970
        public object m_Bidirectional; // 0x3381C970
        public object m_LinkInstance; // 0x3381C970
        public object s_Tracked; // 0x3381C970
        public object agentTypeID; // 0x17000001
        public object startPoint; // 0x17000002
        public object endPoint; // 0x17000003
        public object width; // 0x17000004

        // ── Original Methods ──
        public void get_agentTypeID(){} // RVA: 0x7ffaa8aeced0
        public void set_agentTypeID(){} // RVA: 0x7ffaaef20680
        public void get_startPoint(){} // RVA: 0x7ffaa898dca0
        public void set_startPoint(){} // RVA: 0x7ffaaef206f0
        public void get_endPoint(){} // RVA: 0x7ffaadcebcf0
        public void set_endPoint(){} // RVA: 0x7ffaaef20770
        public void get_width(){} // RVA: 0x7ffaa9068340
        public void set_width(){} // RVA: 0x7ffaaef207f0
        public void get_costModifier(){} // RVA: 0x7ffaa89d3080
        public void set_costModifier(){} // RVA: 0x7ffaaef20860
        public void get_bidirectional(){} // RVA: 0x7ffaa9fc9180
        public void set_bidirectional(){} // RVA: 0x7ffaaef208d0
        public void get_autoUpdate(){} // RVA: 0x7ffaaa1c25c0
        public void set_autoUpdate(){} // RVA: 0x7ffaaef20940
        public void get_area(){} // RVA: 0x7ffaa89d30c0
        public void set_area(){} // RVA: 0x7ffaaef209d0
        public void OnEnable(){} // RVA: 0x7ffaaef20a40
        public void OnDisable(){} // RVA: 0x7ffaaef20ac0
        public void UpdateLink(){} // RVA: 0x7ffaaef20b60
        public void AddTracking(){} // RVA: 0x7ffaaef20bd0
        public void RemoveTracking(){} // RVA: 0x7ffaaef20e30
        public void AddLink(){} // RVA: 0x7ffaaef21040
        public void HasTransformChanged(){} // RVA: 0x7ffaaef21410
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7ffaaef20b60
        public void UpdateTrackedInstances(){} // RVA: 0x7ffaaef21630
        public void .ctor(){} // RVA: 0x7ffaaef217d0
        public void .cctor(){} // RVA: 0x7ffaaef218d0
        // ── Binary Analysis Named ──
        public void SetAutoUpdate(){} // RVA: 0x7ffaaef20940
    }

    public class NavMeshModifier : MonoBehaviour
    {
        public object m_OverrideGenerateLinks; // 0x334C5180
        public object m_ApplyToChildren; // 0x334C5180

        // ── Original Methods ──
        public void get_overrideArea(){} // RVA: 0x7ffaa8a209d0
        public void set_overrideArea(){} // RVA: 0x7ffaa8a209e0
        public void get_area(){} // RVA: 0x7ffaa9349010
        public void set_area(){} // RVA: 0x7ffaa9b8c1b0
        public void get_overrideGenerateLinks(){} // RVA: 0x7ffaa8b0edb0
        public void set_overrideGenerateLinks(){} // RVA: 0x7ffaa96574d0
        public void get_generateLinks(){} // RVA: 0x7ffaa92971f0
        public void set_generateLinks(){} // RVA: 0x7ffaa9dde1d0
        public void get_ignoreFromBuild(){} // RVA: 0x7ffaaa57f5c0
        public void set_ignoreFromBuild(){} // RVA: 0x7ffaaa57f5b0
        public void get_applyToChildren(){} // RVA: 0x7ffaaa57f5a0
        public void set_applyToChildren(){} // RVA: 0x7ffaaa57f5d0
        public void get_activeModifiers(){} // RVA: 0x7ffaaef219b0
        public void OnEnable(){} // RVA: 0x7ffaaef21a10
        public void OnDisable(){} // RVA: 0x7ffaaef21b60
        public void AffectsAgentType(){} // RVA: 0x7ffaaef21bf0
        public void .ctor(){} // RVA: 0x7ffaaef21cf0
        public void .cctor(){} // RVA: 0x7ffaaef21e40
    }

    public class NavMeshModifierVolume : MonoBehaviour
    {
        public object m_Area; // 0x335E2B10

        // ── Original Methods ──
        public void get_size(){} // RVA: 0x7ffaa8998ee0
        public void set_size(){} // RVA: 0x7ffaa8998f00
        public void get_center(){} // RVA: 0x7ffaa8998f10
        public void set_center(){} // RVA: 0x7ffaa8998f30
        public void get_area(){} // RVA: 0x7ffaa8fb82b0
        public void set_area(){} // RVA: 0x7ffaa8fb82c0
        public void get_activeModifiers(){} // RVA: 0x7ffaaef21f20
        public void OnEnable(){} // RVA: 0x7ffaaef21f80
        public void OnDisable(){} // RVA: 0x7ffaaef220d0
        public void AffectsAgentType(){} // RVA: 0x7ffaaef22160
        public void .ctor(){} // RVA: 0x7ffaaef22260
        public void .cctor(){} // RVA: 0x7ffaaef223e0
    }

    public class NavMeshSurface : MonoBehaviour
    {
        public object m_Size; // 0x33877580
        public object m_UseGeometry; // 0x33877580
        public object m_IgnoreNavMeshAgent; // 0x33877580
        public object m_TileSize; // 0x33877580
        public object m_MinRegionArea; // 0x33877580
        public object m_NavMeshDataInstance; // 0x33877580
        public object s_NavMeshSurfaces; // 0x33877580
        public object agentTypeID; // 0x17000014
        public object collectObjects; // 0x17000015
        public object size; // 0x17000016
        public object center; // 0x17000017
        public object layerMask; // 0x17000018
        public object useGeometry; // 0x17000019
        public object defaultArea; // 0x1700001A

        // ── Original Methods ──
        public void get_agentTypeID(){} // RVA: 0x7ffaa8aeced0
        public void set_agentTypeID(){} // RVA: 0x7ffaa900aa90
        public void get_collectObjects(){} // RVA: 0x7ffaa9349010
        public void set_collectObjects(){} // RVA: 0x7ffaa9b8c1b0
        public void get_size(){} // RVA: 0x7ffaa89ad700
        public void set_size(){} // RVA: 0x7ffaa89ad720
        public void get_center(){} // RVA: 0x7ffaaef224c0
        public void set_center(){} // RVA: 0x7ffaaef224e0
        public void get_layerMask(){} // RVA: 0x7ffaa89d3080
        public void set_layerMask(){} // RVA: 0x7ffaa89d3090
        public void get_useGeometry(){} // RVA: 0x7ffaa89d30a0
        public void set_useGeometry(){} // RVA: 0x7ffaa89d30b0
        public void get_defaultArea(){} // RVA: 0x7ffaa89d30c0
        public void set_defaultArea(){} // RVA: 0x7ffaa89d30d0
        public void get_ignoreNavMeshAgent(){} // RVA: 0x7ffaaebfb250
        public void set_ignoreNavMeshAgent(){} // RVA: 0x7ffaaef224f0
        public void get_ignoreNavMeshObstacle(){} // RVA: 0x7ffaaef22500
        public void set_ignoreNavMeshObstacle(){} // RVA: 0x7ffaaef22510
        public void get_overrideTileSize(){} // RVA: 0x7ffaaef22520
        public void set_overrideTileSize(){} // RVA: 0x7ffaaef22530
        public void get_tileSize(){} // RVA: 0x7ffaa8b023d0
        public void set_tileSize(){} // RVA: 0x7ffaa8bfb270
        public void get_overrideVoxelSize(){} // RVA: 0x7ffaa9fc1d50
        public void set_overrideVoxelSize(){} // RVA: 0x7ffaa9fc1c30
        public void get_voxelSize(){} // RVA: 0x7ffaa895afe0
        public void set_voxelSize(){} // RVA: 0x7ffaa895aff0
        public void get_minRegionArea(){} // RVA: 0x7ffaa895b000
        public void set_minRegionArea(){} // RVA: 0x7ffaa895b010
        public void get_buildHeightMesh(){} // RVA: 0x7ffaa89fa570
        public void set_buildHeightMesh(){} // RVA: 0x7ffaa89fa580
        public void get_navMeshData(){} // RVA: 0x7ffaa89d0370
        public void set_navMeshData(){} // RVA: 0x7ffaa89d0380
        public void get_navMeshDataInstance(){} // RVA: 0x7ffaaa1c2a60
        public void get_activeSurfaces(){} // RVA: 0x7ffaaef22540
        public void OnEnable(){} // RVA: 0x7ffaaef226b0
        public void OnDisable(){} // RVA: 0x7ffaaef22710
        public void AddData(){} // RVA: 0x7ffaaef227b0
        public void RemoveData(){} // RVA: 0x7ffaaef22ba0
        public void BuildNavMesh(){} // RVA: 0x7ffaaef22e00
        public void UpdateNavMesh(){} // RVA: 0x7ffaaef232e0
        public void Register(){} // RVA: 0x7ffaaef23630
        public void Unregister(){} // RVA: 0x7ffaaef23920
        public void UpdateActive(){} // RVA: 0x7ffaaef23b30
        public void AppendModifierVolumes(){} // RVA: 0x7ffaaef23c50
        public void CollectSources(){} // RVA: 0x7ffaaef244b0
        public void Abs(){} // RVA: 0x7ffaaa2837a0
        public void CalculateWorldBounds(){} // RVA: 0x7ffaaef256e0
        public void HasTransformChanged(){} // RVA: 0x7ffaaef26280
        public void UpdateDataIfTransformChanged(){} // RVA: 0x7ffaaef264a0
        public void .ctor(){} // RVA: 0x7ffaaef264e0
        public void .cctor(){} // RVA: 0x7ffaaef265f0
        // ── Binary Analysis Named ──
        public void GetInflatedBounds(){} // RVA: 0x7ffaaef225a0
        public void GetBuildSettings(){} // RVA: 0x7ffaaef22c00
        public void GetWorldBounds(){} // RVA: 0x7ffaaef25260
    }

}