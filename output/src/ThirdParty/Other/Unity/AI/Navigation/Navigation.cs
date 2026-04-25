// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.AI.Navigation
// Classes: 4
// Methods: 112

namespace ThirdParty.Other.Unity.AI.Navigation
{
    public class NavMeshLink : MonoBehaviour
    {
        public int agentTypeID; // 0x20
        public UnityEngine.Vector3 startPoint; // 0x24
        public UnityEngine.Vector3 endPoint; // 0x30
        public float width; // 0x3C
        public int costModifier; // 0x40
        public bool bidirectional; // 0x44
        public bool autoUpdate; // 0x45
        public int area; // 0x48
        public UnityEngine.AI.NavMeshLinkInstance m_LinkInstance; // 0x4C
        public UnityEngine.Vector3 m_LastPosition; // 0x50
        public UnityEngine.Quaternion m_LastRotation; // 0x5C
        public System.Collections.Generic.List`1<Unity.AI.Navigation.NavMeshLink> s_Tracked;

        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x7FFAC30DBBE0
        public void set_agentTypeID(){} // RVA: 0x7FFAC94FE6B0
        public void get_startPoint(){} // RVA: 0x7FFAC2F7CCA0
        public void set_startPoint(){} // RVA: 0x7FFAC94FE720
        public void get_endPoint(){} // RVA: 0x7FFAC82CAB40
        public void set_endPoint(){} // RVA: 0x7FFAC94FE7A0
        public void get_width(){} // RVA: 0x7FFAC363CE20
        public void set_width(){} // RVA: 0x7FFAC94FE820
        public void get_costModifier(){} // RVA: 0x7FFAC2FC2080
        public void set_costModifier(){} // RVA: 0x7FFAC94FE890
        public void get_bidirectional(){} // RVA: 0x7FFAC45A8350
        public void set_bidirectional(){} // RVA: 0x7FFAC94FE900
        public void get_autoUpdate(){} // RVA: 0x7FFAC47BA6D0
        public void set_autoUpdate(){} // RVA: 0x7FFAC94FE970
        public void get_area(){} // RVA: 0x7FFAC2FC20C0
        public void set_area(){} // RVA: 0x7FFAC94FEA00
        public void OnEnable(){} // RVA: 0x7FFAC94FEA70
        public void OnDisable(){} // RVA: 0x7FFAC94FEAF0
        public void UpdateLink(){} // RVA: 0x7FFAC94FEB90
        public void AddTracking(){} // RVA: 0x7FFAC94FEC00
        public void RemoveTracking(){} // RVA: 0x7FFAC94FEE60
        public void SetAutoUpdate(){} // RVA: 0x7FFAC94FE970
        public void AddLink(){} // RVA: 0x7FFAC94FF070
        public void HasTransformChanged(){} // RVA: 0x7FFAC94FF440
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC94FEB90
        public void UpdateTrackedInstances(){} // RVA: 0x7FFAC94FF660
        public void .ctor(){} // RVA: 0x7FFAC94FF800
        public void .cctor(){} // RVA: 0x7FFAC94FF900
    }

    public class NavMeshModifier : MonoBehaviour
    {
        public bool overrideArea; // 0x20
        public int area; // 0x24
        public bool overrideGenerateLinks; // 0x28
        public bool generateLinks; // 0x29
        public bool ignoreFromBuild; // 0x2A
        public bool applyToChildren; // 0x2B
        public System.Collections.Generic.List`1<int> activeModifiers; // 0x30
        public System.Collections.Generic.List`1<Unity.AI.Navigation.NavMeshModifier> s_NavMeshModifiers;

        // ── Methods ──
        public void get_overrideArea(){} // RVA: 0x7FFAC300F9D0
        public void set_overrideArea(){} // RVA: 0x7FFAC300F9E0
        public void get_area(){} // RVA: 0x7FFAC3921980
        public void set_area(){} // RVA: 0x7FFAC41674D0
        public void get_overrideGenerateLinks(){} // RVA: 0x7FFAC30F6BA0
        public void set_overrideGenerateLinks(){} // RVA: 0x7FFAC3C24F40
        public void get_generateLinks(){} // RVA: 0x7FFAC386C550
        public void set_generateLinks(){} // RVA: 0x7FFAC43B4D70
        public void get_ignoreFromBuild(){} // RVA: 0x7FFAC4B82F20
        public void set_ignoreFromBuild(){} // RVA: 0x7FFAC4B82F40
        public void get_applyToChildren(){} // RVA: 0x7FFAC4B82F30
        public void set_applyToChildren(){} // RVA: 0x7FFAC4B82F10
        public void get_activeModifiers(){} // RVA: 0x7FFAC94FF9E0
        public void OnEnable(){} // RVA: 0x7FFAC94FFA40
        public void OnDisable(){} // RVA: 0x7FFAC94FFB90
        public void AffectsAgentType(){} // RVA: 0x7FFAC94FFC20
        public void .ctor(){} // RVA: 0x7FFAC94FFD20
        public void .cctor(){} // RVA: 0x7FFAC94FFE70
    }

    public class NavMeshModifierVolume : MonoBehaviour
    {
        public UnityEngine.Vector3 size; // 0x20
        public UnityEngine.Vector3 center; // 0x2C
        public int area; // 0x38
        public System.Collections.Generic.List`1<int> activeModifiers; // 0x40
        public System.Collections.Generic.List`1<Unity.AI.Navigation.NavMeshModifierVolume> s_NavMeshModifiers;

        // ── Methods ──
        public void get_size(){} // RVA: 0x7FFAC2F87EE0
        public void set_size(){} // RVA: 0x7FFAC2F87F00
        public void get_center(){} // RVA: 0x7FFAC2F87F10
        public void set_center(){} // RVA: 0x7FFAC2F87F30
        public void get_area(){} // RVA: 0x7FFAC358A870
        public void set_area(){} // RVA: 0x7FFAC3588350
        public void get_activeModifiers(){} // RVA: 0x7FFAC94FFF50
        public void OnEnable(){} // RVA: 0x7FFAC94FFFB0
        public void OnDisable(){} // RVA: 0x7FFAC9500100
        public void AffectsAgentType(){} // RVA: 0x7FFAC9500190
        public void .ctor(){} // RVA: 0x7FFAC9500290
        public void .cctor(){} // RVA: 0x7FFAC9500410
    }

    public class NavMeshSurface : MonoBehaviour
    {
        public int agentTypeID; // 0x20
        public 0x6B2D99F8 collectObjects; // 0x24
        public UnityEngine.Vector3 size; // 0x28
        public UnityEngine.Vector3 center; // 0x34
        public UnityEngine.LayerMask layerMask; // 0x40
        public 0x6B2C6F40 useGeometry; // 0x44
        public int defaultArea; // 0x48
        public bool ignoreNavMeshAgent; // 0x4C
        public bool ignoreNavMeshObstacle; // 0x4D
        public bool overrideTileSize; // 0x4E
        public bool tileSize; // 0x4F
        public int overrideVoxelSize; // 0x50
        public bool voxelSize; // 0x54
        public float minRegionArea; // 0x58
        public float buildHeightMesh; // 0x5C
        public UnityEngine.AI.NavMeshData navMeshData; // 0x60
        public bool navMeshDataInstance; // 0x68
        public UnityEngine.AI.NavMeshDataInstance activeSurfaces; // 0x6C
        public UnityEngine.Vector3 m_LastPosition; // 0x70
        public UnityEngine.Quaternion m_LastRotation; // 0x7C
        public System.Collections.Generic.List`1<Unity.AI.Navigation.NavMeshSurface> s_NavMeshSurfaces;

        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x7FFAC30DBBE0
        public void set_agentTypeID(){} // RVA: 0x7FFAC35DB7A0
        public void get_collectObjects(){} // RVA: 0x7FFAC3921980
        public void set_collectObjects(){} // RVA: 0x7FFAC41674D0
        public void get_size(){} // RVA: 0x7FFAC2F9C700
        public void set_size(){} // RVA: 0x7FFAC2F9C720
        public void get_center(){} // RVA: 0x7FFAC95004F0
        public void set_center(){} // RVA: 0x7FFAC9500510
        public void get_layerMask(){} // RVA: 0x7FFAC2FC2080
        public void set_layerMask(){} // RVA: 0x7FFAC2FC2090
        public void get_useGeometry(){} // RVA: 0x7FFAC2FC20A0
        public void set_useGeometry(){} // RVA: 0x7FFAC2FC20B0
        public void get_defaultArea(){} // RVA: 0x7FFAC2FC20C0
        public void set_defaultArea(){} // RVA: 0x7FFAC2FC20D0
        public void get_ignoreNavMeshAgent(){} // RVA: 0x7FFAC91D9280
        public void set_ignoreNavMeshAgent(){} // RVA: 0x7FFAC9500520
        public void get_ignoreNavMeshObstacle(){} // RVA: 0x7FFAC9500530
        public void set_ignoreNavMeshObstacle(){} // RVA: 0x7FFAC9500540
        public void get_overrideTileSize(){} // RVA: 0x7FFAC9500550
        public void set_overrideTileSize(){} // RVA: 0x7FFAC9500560
        public void get_tileSize(){} // RVA: 0x7FFAC30F10E0
        public void set_tileSize(){} // RVA: 0x7FFAC31D9010
        public void get_overrideVoxelSize(){} // RVA: 0x7FFAC45A0C60
        public void set_overrideVoxelSize(){} // RVA: 0x7FFAC45A1180
        public void get_voxelSize(){} // RVA: 0x7FFAC2F49FE0
        public void set_voxelSize(){} // RVA: 0x7FFAC2F49FF0
        public void get_minRegionArea(){} // RVA: 0x7FFAC2F4A000
        public void set_minRegionArea(){} // RVA: 0x7FFAC2F4A010
        public void get_buildHeightMesh(){} // RVA: 0x7FFAC2FE9570
        public void set_buildHeightMesh(){} // RVA: 0x7FFAC2FE9580
        public void get_navMeshData(){} // RVA: 0x7FFAC2FBF370
        public void set_navMeshData(){} // RVA: 0x7FFAC2FBF380
        public void get_navMeshDataInstance(){} // RVA: 0x7FFAC47BAB70
        public void get_activeSurfaces(){} // RVA: 0x7FFAC9500570
        public void GetInflatedBounds(){} // RVA: 0x7FFAC95005D0
        public void OnEnable(){} // RVA: 0x7FFAC95006E0
        public void OnDisable(){} // RVA: 0x7FFAC9500740
        public void AddData(){} // RVA: 0x7FFAC95007E0
        public void RemoveData(){} // RVA: 0x7FFAC9500BD0
        public void GetBuildSettings(){} // RVA: 0x7FFAC9500C30
        public void BuildNavMesh(){} // RVA: 0x7FFAC9500E30
        public void UpdateNavMesh(){} // RVA: 0x7FFAC9501310
        public void Register(){} // RVA: 0x7FFAC9501660
        public void Unregister(){} // RVA: 0x7FFAC9501950
        public void UpdateActive(){} // RVA: 0x7FFAC9501B60
        public void AppendModifierVolumes(){} // RVA: 0x7FFAC9501C80
        public void CollectSources(){} // RVA: 0x7FFAC95024E0
        public void Abs(){} // RVA: 0x7FFAC487B890
        public void GetWorldBounds(){} // RVA: 0x7FFAC9503290
        public void CalculateWorldBounds(){} // RVA: 0x7FFAC9503710
        public void HasTransformChanged(){} // RVA: 0x7FFAC95042B0
        public void UpdateDataIfTransformChanged(){} // RVA: 0x7FFAC95044D0
        public void .ctor(){} // RVA: 0x7FFAC9504510
        public void .cctor(){} // RVA: 0x7FFAC9504620
    }

}