// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.AI.Navigation
// Classes: 4
// Methods: 112

namespace ThirdParty.Other.Unity.AI.Navigation
{
    public class NavMeshLink : MonoBehaviour
    {
        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x7A851DB90
        public void set_agentTypeID(){} // RVA: 0x7AEB53D60
        public void get_startPoint(){} // RVA: 0x7A81330D0
        public void set_startPoint(){} // RVA: 0x7AEB53DD0
        public void get_endPoint(){} // RVA: 0x7A98DA220
        public void set_endPoint(){} // RVA: 0x7AEB53E50
        public void get_width(){} // RVA: 0x7A87B9920
        public void set_width(){} // RVA: 0x7AEB53ED0
        public void get_costModifier(){} // RVA: 0x7A8178B30
        public void set_costModifier(){} // RVA: 0x7AEB53F40
        public void get_bidirectional(){} // RVA: 0x7A98B2AB0
        public void set_bidirectional(){} // RVA: 0x7AEB53FB0
        public void get_autoUpdate(){} // RVA: 0x7A9A933F0
        public void set_autoUpdate(){} // RVA: 0x7AEB54020
        public void get_area(){} // RVA: 0x7A8178B70
        public void set_area(){} // RVA: 0x7AEB540B0
        public void OnEnable(){} // RVA: 0x7AEB54120
        public void OnDisable(){} // RVA: 0x7AEB541A0
        public void UpdateLink(){} // RVA: 0x7AEB54240
        public void AddTracking(){} // RVA: 0x7AEB542B0
        public void RemoveTracking(){} // RVA: 0x7AEB54510
        public void SetAutoUpdate(){} // RVA: 0x7AEB54020
        public void AddLink(){} // RVA: 0x7AEB54720
        public void HasTransformChanged(){} // RVA: 0x7AEB54AF0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7AEB54240
        public void UpdateTrackedInstances(){} // RVA: 0x7AEB54D20
        public void .ctor(){} // RVA: 0x7AEB54EC0
        public void .cctor(){} // RVA: 0x7AEB54FC0
    }

    public class NavMeshModifier : MonoBehaviour
    {
        // ── Methods ──
        public void get_overrideArea(){} // RVA: 0x7A81C68D0
        public void set_overrideArea(){} // RVA: 0x7A81C68E0
        public void get_area(){} // RVA: 0x7A8AB15F0
        public void set_area(){} // RVA: 0x7A94794D0
        public void get_overrideGenerateLinks(){} // RVA: 0x7A84A5BD0
        public void set_overrideGenerateLinks(){} // RVA: 0x7A84A5CD0
        public void get_generateLinks(){} // RVA: 0x7A89FCA90
        public void set_generateLinks(){} // RVA: 0x7A96C67C0
        public void get_ignoreFromBuild(){} // RVA: 0x7A9E700C0
        public void set_ignoreFromBuild(){} // RVA: 0x7A9E700B0
        public void get_applyToChildren(){} // RVA: 0x7A9E700D0
        public void set_applyToChildren(){} // RVA: 0x7A9E700A0
        public void get_activeModifiers(){} // RVA: 0x7AEB550A0
        public void OnEnable(){} // RVA: 0x7AEB55100
        public void OnDisable(){} // RVA: 0x7AEB55250
        public void AffectsAgentType(){} // RVA: 0x7AEB552E0
        public void .ctor(){} // RVA: 0x7AEB553E0
        public void .cctor(){} // RVA: 0x7AEB55530
    }

    public class NavMeshModifierVolume : MonoBehaviour
    {
        // ── Methods ──
        public void get_size(){} // RVA: 0x7A813E480
        public void set_size(){} // RVA: 0x7A813E4A0
        public void get_center(){} // RVA: 0x7A813E4B0
        public void set_center(){} // RVA: 0x7A813E4D0
        public void get_area(){} // RVA: 0x7A8D863F0
        public void set_area(){} // RVA: 0x7A8D870E0
        public void get_activeModifiers(){} // RVA: 0x7AEB55610
        public void OnEnable(){} // RVA: 0x7AEB55670
        public void OnDisable(){} // RVA: 0x7AEB557C0
        public void AffectsAgentType(){} // RVA: 0x7AEB55850
        public void .ctor(){} // RVA: 0x7AEB55950
        public void .cctor(){} // RVA: 0x7AEB55AD0
    }

    public class NavMeshSurface : MonoBehaviour
    {
        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x7A851DB90
        public void set_agentTypeID(){} // RVA: 0x7A8738180
        public void get_collectObjects(){} // RVA: 0x7A8AB15F0
        public void set_collectObjects(){} // RVA: 0x7A94794D0
        public void get_size(){} // RVA: 0x7A8152D50
        public void set_size(){} // RVA: 0x7A8152D70
        public void get_center(){} // RVA: 0x7AEB55BB0
        public void set_center(){} // RVA: 0x7AEB55BD0
        public void get_layerMask(){} // RVA: 0x7A8178B30
        public void set_layerMask(){} // RVA: 0x7A8178B40
        public void get_useGeometry(){} // RVA: 0x7A8178B50
        public void set_useGeometry(){} // RVA: 0x7A8178B60
        public void get_defaultArea(){} // RVA: 0x7A8178B70
        public void set_defaultArea(){} // RVA: 0x7A8178B80
        public void get_ignoreNavMeshAgent(){} // RVA: 0x7AE832D20
        public void set_ignoreNavMeshAgent(){} // RVA: 0x7AEB55BE0
        public void get_ignoreNavMeshObstacle(){} // RVA: 0x7AEB55BF0
        public void set_ignoreNavMeshObstacle(){} // RVA: 0x7AEB55C00
        public void get_overrideTileSize(){} // RVA: 0x7AEB55C10
        public void set_overrideTileSize(){} // RVA: 0x7AEB55C20
        public void get_tileSize(){} // RVA: 0x7A8355950
        public void set_tileSize(){} // RVA: 0x7A83F4180
        public void get_overrideVoxelSize(){} // RVA: 0x7A89A1A40
        public void set_overrideVoxelSize(){} // RVA: 0x7A98AA9F0
        public void get_voxelSize(){} // RVA: 0x7A8100220
        public void set_voxelSize(){} // RVA: 0x7A8100230
        public void get_minRegionArea(){} // RVA: 0x7A8100240
        public void set_minRegionArea(){} // RVA: 0x7A8100250
        public void get_buildHeightMesh(){} // RVA: 0x7A81A00C0
        public void set_buildHeightMesh(){} // RVA: 0x7A81A00D0
        public void get_navMeshData(){} // RVA: 0x7A8175DF0
        public void set_navMeshData(){} // RVA: 0x7A8175E00
        public void get_navMeshDataInstance(){} // RVA: 0x7A9A93890
        public void get_activeSurfaces(){} // RVA: 0x7AEB55C30
        public void GetInflatedBounds(){} // RVA: 0x7AEB55C90
        public void OnEnable(){} // RVA: 0x7AEB55DA0
        public void OnDisable(){} // RVA: 0x7AEB55E00
        public void AddData(){} // RVA: 0x7AEB55EA0
        public void RemoveData(){} // RVA: 0x7AEB56290
        public void GetBuildSettings(){} // RVA: 0x7AEB562F0
        public void BuildNavMesh(){} // RVA: 0x7AEB564F0
        public void UpdateNavMesh(){} // RVA: 0x7AEB569E0
        public void Register(){} // RVA: 0x7AEB56D30
        public void Unregister(){} // RVA: 0x7AEB57020
        public void UpdateActive(){} // RVA: 0x7AEB57230
        public void AppendModifierVolumes(){} // RVA: 0x7AEB57360
        public void CollectSources(){} // RVA: 0x7AEB57BD0
        public void Abs(){} // RVA: 0x7A9B58C00
        public void GetWorldBounds(){} // RVA: 0x7AEB58980
        public void CalculateWorldBounds(){} // RVA: 0x7AEB58E20
        public void HasTransformChanged(){} // RVA: 0x7AEB59A60
        public void UpdateDataIfTransformChanged(){} // RVA: 0x7AEB59C90
        public void .ctor(){} // RVA: 0x7AEB59CD0
        public void .cctor(){} // RVA: 0x7AEB59DE0
    }

}