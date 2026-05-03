// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.AI.Navigation
// Classes: 4
// Methods: 112

namespace ThirdParty.Other.Unity.AI.Navigation
{
    public class NavMeshLink : MonoBehaviour
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
        public void get_agentTypeID(){} // RVA: 0x7FFE8151D690
        public void set_agentTypeID(){} // RVA: 0x7FFE878A6DF0
        public void get_startPoint(){} // RVA: 0x7FFE81156CA0
        public void set_startPoint(){} // RVA: 0x7FFE878A6E60
        public void get_endPoint(){} // RVA: 0x7FFE828CAED0
        public void set_endPoint(){} // RVA: 0x7FFE878A6EE0
        public void get_width(){} // RVA: 0x7FFE8178C5D0
        public void set_width(){} // RVA: 0x7FFE878A6F60
        public void get_costModifier(){} // RVA: 0x7FFE8119C080
        public void set_costModifier(){} // RVA: 0x7FFE878A6FD0
        public void get_bidirectional(){} // RVA: 0x7FFE82876440
        public void set_bidirectional(){} // RVA: 0x7FFE878A7040
        public void get_autoUpdate(){} // RVA: 0x7FFE82A22A70
        public void set_autoUpdate(){} // RVA: 0x7FFE878A70B0
        public void get_area(){} // RVA: 0x7FFE8119C0C0
        public void set_area(){} // RVA: 0x7FFE878A7140
        public void OnEnable(){} // RVA: 0x7FFE878A71B0
        public void OnDisable(){} // RVA: 0x7FFE878A7230
        public void UpdateLink(){} // RVA: 0x7FFE878A72D0
        public void AddTracking(){} // RVA: 0x7FFE878A7340
        public void RemoveTracking(){} // RVA: 0x7FFE878A75A0
        public void SetAutoUpdate(){} // RVA: 0x7FFE878A70B0
        public void AddLink(){} // RVA: 0x7FFE878A77B0
        public void HasTransformChanged(){} // RVA: 0x7FFE878A7B80
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFE878A72D0
        public void UpdateTrackedInstances(){} // RVA: 0x7FFE878A7DA0
        public void .ctor(){} // RVA: 0x7FFE878A7F40
        public void .cctor(){} // RVA: 0x7FFE878A8040
    }

    public class NavMeshModifier : MonoBehaviour
    {
        public bool m_OverrideArea; // 0x20
        public int m_Area; // 0x24
        public bool m_OverrideGenerateLinks; // 0x28
        public bool m_GenerateLinks; // 0x29
        public bool m_IgnoreFromBuild; // 0x2A
        public bool m_ApplyToChildren; // 0x2B
        public System.Collections.Generic.List`1<int> m_AffectedAgents; // 0x30

        // ── Methods ──
        public void get_overrideArea(){} // RVA: 0x7FFE811E99D0
        public void set_overrideArea(){} // RVA: 0x7FFE811E99E0
        public void get_area(){} // RVA: 0x7FFE81A56130
        public void set_area(){} // RVA: 0x7FFE82447980
        public void get_overrideGenerateLinks(){} // RVA: 0x7FFE815F1380
        public void set_overrideGenerateLinks(){} // RVA: 0x7FFE81C15740
        public void get_generateLinks(){} // RVA: 0x7FFE819C2EA0
        public void set_generateLinks(){} // RVA: 0x7FFE8268C820
        public void get_ignoreFromBuild(){} // RVA: 0x7FFE82DEC5E0
        public void set_ignoreFromBuild(){} // RVA: 0x7FFE82DEC5B0
        public void get_applyToChildren(){} // RVA: 0x7FFE82DEC5C0
        public void set_applyToChildren(){} // RVA: 0x7FFE82DEC5D0
        public void get_activeModifiers(){} // RVA: 0x7FFE878A8120
        public void OnEnable(){} // RVA: 0x7FFE878A8180
        public void OnDisable(){} // RVA: 0x7FFE878A82D0
        public void AffectsAgentType(){} // RVA: 0x7FFE878A8360
        public void .ctor(){} // RVA: 0x7FFE878A8460
        public void .cctor(){} // RVA: 0x7FFE878A85B0
    }

    public class NavMeshModifierVolume : MonoBehaviour
    {
        public UnityEngine.Vector3 m_Size; // 0x20
        public UnityEngine.Vector3 m_Center; // 0x2C
        public int m_Area; // 0x38
        public System.Collections.Generic.List`1<int> m_AffectedAgents; // 0x40

        // ── Methods ──
        public void get_size(){} // RVA: 0x7FFE81161EE0
        public void set_size(){} // RVA: 0x7FFE81161F00
        public void get_center(){} // RVA: 0x7FFE81161F10
        public void set_center(){} // RVA: 0x7FFE81161F30
        public void get_area(){} // RVA: 0x7FFE81D46090
        public void set_area(){} // RVA: 0x7FFE81D46A00
        public void get_activeModifiers(){} // RVA: 0x7FFE878A8690
        public void OnEnable(){} // RVA: 0x7FFE878A86F0
        public void OnDisable(){} // RVA: 0x7FFE878A8840
        public void AffectsAgentType(){} // RVA: 0x7FFE878A88D0
        public void .ctor(){} // RVA: 0x7FFE878A89D0
        public void .cctor(){} // RVA: 0x7FFE878A8B50
    }

    public class NavMeshSurface : MonoBehaviour
    {
        public int m_AgentTypeID; // 0x20
        public 0x666D3EC4 m_CollectObjects; // 0x24
        public UnityEngine.Vector3 m_Size; // 0x28
        public UnityEngine.Vector3 m_Center; // 0x34
        public UnityEngine.LayerMask m_LayerMask; // 0x40
        public 0x666C1FBC m_UseGeometry; // 0x44
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
        public void get_agentTypeID(){} // RVA: 0x7FFE8151D690
        public void set_agentTypeID(){} // RVA: 0x7FFE8170B670
        public void get_collectObjects(){} // RVA: 0x7FFE81A56130
        public void set_collectObjects(){} // RVA: 0x7FFE82447980
        public void get_size(){} // RVA: 0x7FFE81176700
        public void set_size(){} // RVA: 0x7FFE81176720
        public void get_center(){} // RVA: 0x7FFE878A8C30
        public void set_center(){} // RVA: 0x7FFE878A8C50
        public void get_layerMask(){} // RVA: 0x7FFE8119C080
        public void set_layerMask(){} // RVA: 0x7FFE8119C090
        public void get_useGeometry(){} // RVA: 0x7FFE8119C0A0
        public void set_useGeometry(){} // RVA: 0x7FFE8119C0B0
        public void get_defaultArea(){} // RVA: 0x7FFE8119C0C0
        public void set_defaultArea(){} // RVA: 0x7FFE8119C0D0
        public void get_ignoreNavMeshAgent(){} // RVA: 0x7FFE875819F0
        public void set_ignoreNavMeshAgent(){} // RVA: 0x7FFE878A8C60
        public void get_ignoreNavMeshObstacle(){} // RVA: 0x7FFE878A8C70
        public void set_ignoreNavMeshObstacle(){} // RVA: 0x7FFE878A8C80
        public void get_overrideTileSize(){} // RVA: 0x7FFE878A8C90
        public void set_overrideTileSize(){} // RVA: 0x7FFE878A8CA0
        public void get_tileSize(){} // RVA: 0x7FFE8139DAD0
        public void set_tileSize(){} // RVA: 0x7FFE81463B00
        public void get_overrideVoxelSize(){} // RVA: 0x7FFE8196FB30
        public void set_overrideVoxelSize(){} // RVA: 0x7FFE8286F2D0
        public void get_voxelSize(){} // RVA: 0x7FFE81123FE0
        public void set_voxelSize(){} // RVA: 0x7FFE81123FF0
        public void get_minRegionArea(){} // RVA: 0x7FFE81124000
        public void set_minRegionArea(){} // RVA: 0x7FFE81124010
        public void get_buildHeightMesh(){} // RVA: 0x7FFE811C3570
        public void set_buildHeightMesh(){} // RVA: 0x7FFE811C3580
        public void get_navMeshData(){} // RVA: 0x7FFE81199370
        public void set_navMeshData(){} // RVA: 0x7FFE81199380
        public void get_navMeshDataInstance(){} // RVA: 0x7FFE82A22F10
        public void get_activeSurfaces(){} // RVA: 0x7FFE878A8CB0
        public void GetInflatedBounds(){} // RVA: 0x7FFE878A8D10
        public void OnEnable(){} // RVA: 0x7FFE878A8E20
        public void OnDisable(){} // RVA: 0x7FFE878A8E80
        public void AddData(){} // RVA: 0x7FFE878A8F20
        public void RemoveData(){} // RVA: 0x7FFE878A9310
        public void GetBuildSettings(){} // RVA: 0x7FFE878A9370
        public void BuildNavMesh(){} // RVA: 0x7FFE878A9570
        public void UpdateNavMesh(){} // RVA: 0x7FFE878A9A50
        public void Register(){} // RVA: 0x7FFE878A9DA0
        public void Unregister(){} // RVA: 0x7FFE878AA090
        public void UpdateActive(){} // RVA: 0x7FFE878AA2A0
        public void AppendModifierVolumes(){} // RVA: 0x7FFE878AA3C0
        public void CollectSources(){} // RVA: 0x7FFE878AAC20
        public void Abs(){} // RVA: 0x7FFE82AE3C10
        public void GetWorldBounds(){} // RVA: 0x7FFE878AB9D0
        public void CalculateWorldBounds(){} // RVA: 0x7FFE878ABE50
        public void HasTransformChanged(){} // RVA: 0x7FFE878AC9F0
        public void UpdateDataIfTransformChanged(){} // RVA: 0x7FFE878ACC10
        public void .ctor(){} // RVA: 0x7FFE878ACC50
        public void .cctor(){} // RVA: 0x7FFE878ACD60
    }

}