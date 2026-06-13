// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.AI.Navigation
// Classes: 4
// Methods: 112

namespace ThirdParty.Other.Unity.AI.Navigation
{
    public class NavMeshLink
    {
        public int m_AgentTypeID; // 0x20
        public UnityEngine.Vector3 m_StartPoint; // 0x24
        public UnityEngine.Vector3 m_EndPoint; // 0x30
        public float m_Width; // 0x3C
        public int m_CostModifier; // 0x40
        public bool m_Bidirectional; // 0x44
        public bool m_AutoUpdatePosition; // 0x45
        public int m_Area; // 0x48

        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x760030
        public void set_agentTypeID(){} // RVA: 0x6D65F50
        public void get_startPoint(){} // RVA: 0x338CA0
        public void set_startPoint(){} // RVA: 0x6D65FC0
        public void get_endPoint(){} // RVA: 0x1B414E0
        public void set_endPoint(){} // RVA: 0x6D66040
        public void get_width(){} // RVA: 0x9FC6D0
        public void set_width(){} // RVA: 0x6D660C0
        public void get_costModifier(){} // RVA: 0x37E080
        public void set_costModifier(){} // RVA: 0x6D66130
        public void get_bidirectional(){} // RVA: 0x1AF8C70
        public void set_bidirectional(){} // RVA: 0x6D661A0
        public void get_autoUpdate(){} // RVA: 0x1C90FC0
        public void set_autoUpdate(){} // RVA: 0x6D66210
        public void get_area(){} // RVA: 0x37E0C0
        public void set_area(){} // RVA: 0x6D662A0
        public void OnEnable(){} // RVA: 0x6D66310
        public void OnDisable(){} // RVA: 0x6D66390
        public void UpdateLink(){} // RVA: 0x6D66430
        public void AddTracking(){} // RVA: 0x6D664A0
        public void RemoveTracking(){} // RVA: 0x6D66700
        public void SetAutoUpdate(){} // RVA: 0x6D66210
        public void AddLink(){} // RVA: 0x6D66910
        public void HasTransformChanged(){} // RVA: 0x6D66CE0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x6D66430
        public void UpdateTrackedInstances(){} // RVA: 0x6D66F00
        public void .ctor(){} // RVA: 0x6D670A0
        public void .cctor(){} // RVA: 0x6D671A0
    }

    public class NavMeshModifier
    {
        public bool m_OverrideArea; // 0x20
        public int m_Area; // 0x24
        public bool m_OverrideGenerateLinks; // 0x28
        public bool m_GenerateLinks; // 0x29
        public bool m_IgnoreFromBuild; // 0x2A
        public bool m_ApplyToChildren; // 0x2B
        public System.Collections.Generic.List`1<int> m_AffectedAgents; // 0x30

        // ── Methods ──
        public void get_overrideArea(){} // RVA: 0x3CB9D0
        public void set_overrideArea(){} // RVA: 0x3CB9E0
        public void get_area(){} // RVA: 0xCEF5B0
        public void set_area(){} // RVA: 0x16E1F00
        public void get_overrideGenerateLinks(){} // RVA: 0x6E8A80
        public void set_overrideGenerateLinks(){} // RVA: 0x6E8B80
        public void get_generateLinks(){} // RVA: 0xC36000
        public void set_generateLinks(){} // RVA: 0x190AB20
        public void get_ignoreFromBuild(){} // RVA: 0x205EA40
        public void set_ignoreFromBuild(){} // RVA: 0x205EA30
        public void get_applyToChildren(){} // RVA: 0x205EA50
        public void set_applyToChildren(){} // RVA: 0x205EA20
        public void get_activeModifiers(){} // RVA: 0x6D67280
        public void OnEnable(){} // RVA: 0x6D672E0
        public void OnDisable(){} // RVA: 0x6D67430
        public void AffectsAgentType(){} // RVA: 0x6D674C0
        public void .ctor(){} // RVA: 0x6D675C0
        public void .cctor(){} // RVA: 0x6D67710
    }

    public class NavMeshModifierVolume
    {
        public UnityEngine.Vector3 m_Size; // 0x20
        public UnityEngine.Vector3 m_Center; // 0x2C
        public int m_Area; // 0x38
        public System.Collections.Generic.List`1<int> m_AffectedAgents; // 0x40

        // ── Methods ──
        public void get_size(){} // RVA: 0x343EE0
        public void set_size(){} // RVA: 0x343F00
        public void get_center(){} // RVA: 0x343F10
        public void set_center(){} // RVA: 0x343F30
        public void get_area(){} // RVA: 0xFDC9F0
        public void set_area(){} // RVA: 0xFDD6E0
        public void get_activeModifiers(){} // RVA: 0x6D677F0
        public void OnEnable(){} // RVA: 0x6D67850
        public void OnDisable(){} // RVA: 0x6D679A0
        public void AffectsAgentType(){} // RVA: 0x6D67A30
        public void .ctor(){} // RVA: 0x6D67B30
        public void .cctor(){} // RVA: 0x6D67CB0
    }

    public class NavMeshSurface
    {
        public int m_AgentTypeID; // 0x20
        public 0x659FC430 m_CollectObjects; // 0x24
        public UnityEngine.Vector3 m_Size; // 0x28
        public UnityEngine.Vector3 m_Center; // 0x34
        public UnityEngine.LayerMask m_LayerMask; // 0x40
        public 0x659EA528 m_UseGeometry; // 0x44
        public int m_DefaultArea; // 0x48
        public bool m_GenerateLinks; // 0x4C
        public bool m_IgnoreNavMeshAgent; // 0x4D
        public bool m_IgnoreNavMeshObstacle; // 0x4E
        public bool m_OverrideTileSize; // 0x4F
        public int m_TileSize; // 0x50
        public bool m_OverrideVoxelSize; // 0x54
        public float m_VoxelSize; // 0x58
        public float m_MinRegionArea; // 0x5C
        public UnityEngine.AI.NavMeshData m_NavMeshData; // 0x60
        public bool m_BuildHeightMesh; // 0x68
        public UnityEngine.AI.NavMeshDataInstance m_NavMeshDataInstance; // 0x6C

        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x760030
        public void set_agentTypeID(){} // RVA: 0x99E0D0
        public void get_collectObjects(){} // RVA: 0xCEF5B0
        public void set_collectObjects(){} // RVA: 0x16E1F00
        public void get_size(){} // RVA: 0x358700
        public void set_size(){} // RVA: 0x358720
        public void get_center(){} // RVA: 0x6D67D90
        public void set_center(){} // RVA: 0x6D67DB0
        public void get_layerMask(){} // RVA: 0x37E080
        public void set_layerMask(){} // RVA: 0x37E090
        public void get_useGeometry(){} // RVA: 0x37E0A0
        public void set_useGeometry(){} // RVA: 0x37E0B0
        public void get_defaultArea(){} // RVA: 0x37E0C0
        public void set_defaultArea(){} // RVA: 0x37E0D0
        public void get_ignoreNavMeshAgent(){} // RVA: 0x6A42700
        public void set_ignoreNavMeshAgent(){} // RVA: 0x6D67DC0
        public void get_ignoreNavMeshObstacle(){} // RVA: 0x6D67DD0
        public void set_ignoreNavMeshObstacle(){} // RVA: 0x6D67DE0
        public void get_overrideTileSize(){} // RVA: 0x6D67DF0
        public void set_overrideTileSize(){} // RVA: 0x6D67E00
        public void get_tileSize(){} // RVA: 0x59C540
        public void set_tileSize(){} // RVA: 0x65F570
        public void get_overrideVoxelSize(){} // RVA: 0xBDB570
        public void set_overrideVoxelSize(){} // RVA: 0x1AF0B50
        public void get_voxelSize(){} // RVA: 0x305FE0
        public void set_voxelSize(){} // RVA: 0x305FF0
        public void get_minRegionArea(){} // RVA: 0x306000
        public void set_minRegionArea(){} // RVA: 0x306010
        public void get_buildHeightMesh(){} // RVA: 0x3A5570
        public void set_buildHeightMesh(){} // RVA: 0x3A5580
        public void get_navMeshData(){} // RVA: 0x37B370
        public void set_navMeshData(){} // RVA: 0x37B380
        public void get_navMeshDataInstance(){} // RVA: 0x1C91460
        public void get_activeSurfaces(){} // RVA: 0x6D67E10
        public void GetInflatedBounds(){} // RVA: 0x6D67E70
        public void OnEnable(){} // RVA: 0x6D67F80
        public void OnDisable(){} // RVA: 0x6D67FE0
        public void AddData(){} // RVA: 0x6D68080
        public void RemoveData(){} // RVA: 0x6D68470
        public void GetBuildSettings(){} // RVA: 0x6D684D0
        public void BuildNavMesh(){} // RVA: 0x6D686D0
        public void UpdateNavMesh(){} // RVA: 0x6D68BB0
        public void Register(){} // RVA: 0x6D68F00
        public void Unregister(){} // RVA: 0x6D691F0
        public void UpdateActive(){} // RVA: 0x6D69400
        public void AppendModifierVolumes(){} // RVA: 0x6D69520
        public void CollectSources(){} // RVA: 0x6D69D80
        public void Abs(){} // RVA: 0x1D55D90
        public void GetWorldBounds(){} // RVA: 0x6D6AB30
        public void CalculateWorldBounds(){} // RVA: 0x6D6AFB0
        public void HasTransformChanged(){} // RVA: 0x6D6BB50
        public void UpdateDataIfTransformChanged(){} // RVA: 0x6D6BD70
        public void .ctor(){} // RVA: 0x6D6BDB0
        public void .cctor(){} // RVA: 0x6D6BEC0
    }

}