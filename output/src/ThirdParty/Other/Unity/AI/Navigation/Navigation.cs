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
        public ÏÌÍÏÍÎÍÌÌÌ.ÎÏÌÏÌÍÍÍÍÌÎÌÌÍÏÍÎÎÌÎÏÏ m_LinkInstance; // 0x4C
        public UnityEngine.Vector3 m_LastPosition; // 0x50
        public UnityEngine.Quaternion m_LastRotation; // 0x5C
        public System.Collections.Generic.List`1<Unity.AI.Navigation.NavMeshLink> s_Tracked;

        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x7FFD4E4FBBE0
        public void set_agentTypeID(){} // RVA: 0x7FFD5491E6B0
        public void get_startPoint(){} // RVA: 0x7FFD4E39CCA0
        public void set_startPoint(){} // RVA: 0x7FFD5491E720
        public void get_endPoint(){} // RVA: 0x7FFD536EAB40
        public void set_endPoint(){} // RVA: 0x7FFD5491E7A0
        public void get_width(){} // RVA: 0x7FFD4EA5CE20
        public void set_width(){} // RVA: 0x7FFD5491E820
        public void get_costModifier(){} // RVA: 0x7FFD4E3E2080
        public void set_costModifier(){} // RVA: 0x7FFD5491E890
        public void get_bidirectional(){} // RVA: 0x7FFD4F9C8350
        public void set_bidirectional(){} // RVA: 0x7FFD5491E900
        public void get_autoUpdate(){} // RVA: 0x7FFD4FBDA6D0
        public void set_autoUpdate(){} // RVA: 0x7FFD5491E970
        public void get_area(){} // RVA: 0x7FFD4E3E20C0
        public void set_area(){} // RVA: 0x7FFD5491EA00
        public void OnEnable(){} // RVA: 0x7FFD5491EA70
        public void OnDisable(){} // RVA: 0x7FFD5491EAF0
        public void UpdateLink(){} // RVA: 0x7FFD5491EB90
        public void AddTracking(){} // RVA: 0x7FFD5491EC00
        public void RemoveTracking(){} // RVA: 0x7FFD5491EE60
        public void SetAutoUpdate(){} // RVA: 0x7FFD5491E970
        public void AddLink(){} // RVA: 0x7FFD5491F070
        public void HasTransformChanged(){} // RVA: 0x7FFD5491F440
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD5491EB90
        public void UpdateTrackedInstances(){} // RVA: 0x7FFD5491F660
        public void .ctor(){} // RVA: 0x7FFD5491F800
        public void .cctor(){} // RVA: 0x7FFD5491F900
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
        public void get_overrideArea(){} // RVA: 0x7FFD4E42F9D0
        public void set_overrideArea(){} // RVA: 0x7FFD4E42F9E0
        public void get_area(){} // RVA: 0x7FFD4ED41980
        public void set_area(){} // RVA: 0x7FFD4F5874D0
        public void get_overrideGenerateLinks(){} // RVA: 0x7FFD4E516BA0
        public void set_overrideGenerateLinks(){} // RVA: 0x7FFD4F044F40
        public void get_generateLinks(){} // RVA: 0x7FFD4EC8C550
        public void set_generateLinks(){} // RVA: 0x7FFD4F7D4D70
        public void get_ignoreFromBuild(){} // RVA: 0x7FFD4FFA2F20
        public void set_ignoreFromBuild(){} // RVA: 0x7FFD4FFA2F40
        public void get_applyToChildren(){} // RVA: 0x7FFD4FFA2F30
        public void set_applyToChildren(){} // RVA: 0x7FFD4FFA2F10
        public void get_activeModifiers(){} // RVA: 0x7FFD5491F9E0
        public void OnEnable(){} // RVA: 0x7FFD5491FA40
        public void OnDisable(){} // RVA: 0x7FFD5491FB90
        public void AffectsAgentType(){} // RVA: 0x7FFD5491FC20
        public void .ctor(){} // RVA: 0x7FFD5491FD20
        public void .cctor(){} // RVA: 0x7FFD5491FE70
    }

    public class NavMeshModifierVolume : MonoBehaviour
    {
        public UnityEngine.Vector3 size; // 0x20
        public UnityEngine.Vector3 center; // 0x2C
        public int area; // 0x38
        public System.Collections.Generic.List`1<int> activeModifiers; // 0x40
        public System.Collections.Generic.List`1<Unity.AI.Navigation.NavMeshModifierVolume> s_NavMeshModifiers;

        // ── Methods ──
        public void get_size(){} // RVA: 0x7FFD4E3A7EE0
        public void set_size(){} // RVA: 0x7FFD4E3A7F00
        public void get_center(){} // RVA: 0x7FFD4E3A7F10
        public void set_center(){} // RVA: 0x7FFD4E3A7F30
        public void get_area(){} // RVA: 0x7FFD4E9AA870
        public void set_area(){} // RVA: 0x7FFD4E9A8350
        public void get_activeModifiers(){} // RVA: 0x7FFD5491FF50
        public void OnEnable(){} // RVA: 0x7FFD5491FFB0
        public void OnDisable(){} // RVA: 0x7FFD54920100
        public void AffectsAgentType(){} // RVA: 0x7FFD54920190
        public void .ctor(){} // RVA: 0x7FFD54920290
        public void .cctor(){} // RVA: 0x7FFD54920410
    }

    public class NavMeshSurface : MonoBehaviour
    {
        public int agentTypeID; // 0x20
        public 0x666399F8 collectObjects; // 0x24
        public UnityEngine.Vector3 size; // 0x28
        public UnityEngine.Vector3 center; // 0x34
        public UnityEngine.LayerMask layerMask; // 0x40
        public ÏÌÍÏÍÎÍÌÌÌ.ÍÌÌÌ useGeometry; // 0x44
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
        public ÏÌÍÏÍÎÍÌÌÌ.ÍÍÎÍÌÎÍÍÏÎÍÌÌÍÍÏÌÍÍÏ activeSurfaces; // 0x6C
        public UnityEngine.Vector3 m_LastPosition; // 0x70
        public UnityEngine.Quaternion m_LastRotation; // 0x7C
        public System.Collections.Generic.List`1<Unity.AI.Navigation.NavMeshSurface> s_NavMeshSurfaces;

        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x7FFD4E4FBBE0
        public void set_agentTypeID(){} // RVA: 0x7FFD4E9FB7A0
        public void get_collectObjects(){} // RVA: 0x7FFD4ED41980
        public void set_collectObjects(){} // RVA: 0x7FFD4F5874D0
        public void get_size(){} // RVA: 0x7FFD4E3BC700
        public void set_size(){} // RVA: 0x7FFD4E3BC720
        public void get_center(){} // RVA: 0x7FFD549204F0
        public void set_center(){} // RVA: 0x7FFD54920510
        public void get_layerMask(){} // RVA: 0x7FFD4E3E2080
        public void set_layerMask(){} // RVA: 0x7FFD4E3E2090
        public void get_useGeometry(){} // RVA: 0x7FFD4E3E20A0
        public void set_useGeometry(){} // RVA: 0x7FFD4E3E20B0
        public void get_defaultArea(){} // RVA: 0x7FFD4E3E20C0
        public void set_defaultArea(){} // RVA: 0x7FFD4E3E20D0
        public void get_ignoreNavMeshAgent(){} // RVA: 0x7FFD545F9280
        public void set_ignoreNavMeshAgent(){} // RVA: 0x7FFD54920520
        public void get_ignoreNavMeshObstacle(){} // RVA: 0x7FFD54920530
        public void set_ignoreNavMeshObstacle(){} // RVA: 0x7FFD54920540
        public void get_overrideTileSize(){} // RVA: 0x7FFD54920550
        public void set_overrideTileSize(){} // RVA: 0x7FFD54920560
        public void get_tileSize(){} // RVA: 0x7FFD4E5110E0
        public void set_tileSize(){} // RVA: 0x7FFD4E5F9010
        public void get_overrideVoxelSize(){} // RVA: 0x7FFD4F9C0C60
        public void set_overrideVoxelSize(){} // RVA: 0x7FFD4F9C1180
        public void get_voxelSize(){} // RVA: 0x7FFD4E369FE0
        public void set_voxelSize(){} // RVA: 0x7FFD4E369FF0
        public void get_minRegionArea(){} // RVA: 0x7FFD4E36A000
        public void set_minRegionArea(){} // RVA: 0x7FFD4E36A010
        public void get_buildHeightMesh(){} // RVA: 0x7FFD4E409570
        public void set_buildHeightMesh(){} // RVA: 0x7FFD4E409580
        public void get_navMeshData(){} // RVA: 0x7FFD4E3DF370
        public void set_navMeshData(){} // RVA: 0x7FFD4E3DF380
        public void get_navMeshDataInstance(){} // RVA: 0x7FFD4FBDAB70
        public void get_activeSurfaces(){} // RVA: 0x7FFD54920570
        public void GetInflatedBounds(){} // RVA: 0x7FFD549205D0
        public void OnEnable(){} // RVA: 0x7FFD549206E0
        public void OnDisable(){} // RVA: 0x7FFD54920740
        public void AddData(){} // RVA: 0x7FFD549207E0
        public void RemoveData(){} // RVA: 0x7FFD54920BD0
        public void GetBuildSettings(){} // RVA: 0x7FFD54920C30
        public void BuildNavMesh(){} // RVA: 0x7FFD54920E30
        public void UpdateNavMesh(){} // RVA: 0x7FFD54921310
        public void Register(){} // RVA: 0x7FFD54921660
        public void Unregister(){} // RVA: 0x7FFD54921950
        public void UpdateActive(){} // RVA: 0x7FFD54921B60
        public void AppendModifierVolumes(){} // RVA: 0x7FFD54921C80
        public void CollectSources(){} // RVA: 0x7FFD549224E0
        public void Abs(){} // RVA: 0x7FFD4FC9B890
        public void GetWorldBounds(){} // RVA: 0x7FFD54923290
        public void CalculateWorldBounds(){} // RVA: 0x7FFD54923710
        public void HasTransformChanged(){} // RVA: 0x7FFD549242B0
        public void UpdateDataIfTransformChanged(){} // RVA: 0x7FFD549244D0
        public void .ctor(){} // RVA: 0x7FFD54924510
        public void .cctor(){} // RVA: 0x7FFD54924620
    }

}