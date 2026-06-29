// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.AI.Navigation
// Classes: 8
// Methods: 197

namespace ThirdParty.Other.Unity.AI.Navigation
{
    public class NavMeshLink : MonoBehaviour
    {
        public object m_SerializedVersion;
        public object m_AgentTypeID;
        public object m_StartPoint;
        public object m_EndPoint;
        public object m_StartTransform;
        public object m_EndTransform;
        public object m_Activated;
        public object m_Width;
        public object m_CostModifier;
        public object m_IsOverridingCost;
        public object m_Bidirectional;
        public object m_AutoUpdatePosition;
        public object m_Area;
        public object m_LinkInstance;
        public object m_StartTransformWasEmpty;
        public object m_EndTransformWasEmpty;
        public object m_LastStartWorldPosition;
        public object m_LastEndWorldPosition;
        public object m_LastPosition;
        public object m_LastRotation;
        public object s_Tracked;

        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x15AF000
        public void set_agentTypeID(){} // RVA: 0x77C1C50
        public void get_startPoint(){} // RVA: 0xBBF8C0
        public void set_startPoint(){} // RVA: 0x77C1C60
        public void get_endPoint(){} // RVA: 0x77C1CD0
        public void set_endPoint(){} // RVA: 0x77C1CF0
        public void get_startTransform(){} // RVA: 0xBC1B30
        public void set_startTransform(){} // RVA: 0x77C1D60
        public void get_endTransform(){} // RVA: 0xBBF8F0
        public void set_endTransform(){} // RVA: 0x77C1EE0
        public void get_width(){} // RVA: 0x1122A70
        public void set_width(){} // RVA: 0x77C2060
        public void get_costModifier(){} // RVA: 0x77C20A0
        public void set_costModifier(){} // RVA: 0x77C20C0
        public void get_bidirectional(){} // RVA: 0x1125460
        public void set_bidirectional(){} // RVA: 0x77C2120
        public void get_autoUpdate(){} // RVA: 0x27FA8B0
        public void set_autoUpdate(){} // RVA: 0x77C2130
        public void get_area(){} // RVA: 0xD347A0
        public void set_area(){} // RVA: 0x77C21C0
        public void get_activated(){} // RVA: 0xC00EC0
        public void set_activated(){} // RVA: 0x77C21D0
        public void get_occupied(){} // RVA: 0x77C2230
        public void ClearTrackedList(){} // RVA: 0x77C2280
        public void UpgradeSerializedVersion(){} // RVA: 0x77C2320
        public void Awake(){} // RVA: 0x77C2640
        public void OnEnable(){} // RVA: 0x77C2650
        public void OnDisable(){} // RVA: 0x77C2700
        public void UpdateLink(){} // RVA: 0x77C27A0
        public void AddTracking(){} // RVA: 0x77C2890
        public void RemoveTracking(){} // RVA: 0x77C2B00
        public void GetWorldPositions(){} // RVA: 0x77C2D10
        public void GetLocalPositions(){} // RVA: 0x77C31C0
        public void AddLink(){} // RVA: 0x77C3700
        public void RecordEndpointTransforms(){} // RVA: 0x77C3BB0
        public void HaveTransformsChanged(){} // RVA: 0x77C3D20
        public void LocalToWorldUnscaled(){} // RVA: 0x77C4410
        public void OnDidApplyAnimationProperties(){} // RVA: 0x77C4680
        public void UpdateTrackedInstances(){} // RVA: 0x77C4690
        public void get_autoUpdatePositions(){} // RVA: 0x27FA8B0
        public void set_autoUpdatePositions(){} // RVA: 0x77C4840
        public void get_biDirectional(){} // RVA: 0x1125460
        public void set_biDirectional(){} // RVA: 0x77C2120
        public void get_costOverride(){} // RVA: 0x77C20A0
        public void set_costOverride(){} // RVA: 0x77C20C0
        public void UpdatePositions(){} // RVA: 0x77C4680
        public void .ctor(){} // RVA: 0x77C4850
        public void .cctor(){} // RVA: 0x77C49F0
    }

    public class NavMeshLink[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class NavMeshModifier : MonoBehaviour
    {
        public object m_SerializedVersion;
        public object m_OverrideArea;
        public object m_Area;
        public object m_OverrideGenerateLinks;
        public object m_GenerateLinks;
        public object m_IgnoreFromBuild;
        public object m_ApplyToChildren;
        public object m_AffectedAgents;
        public object s_NavMeshModifiers;

        // ── Methods ──
        public void get_overrideArea(){} // RVA: 0xF45EE0
        public void set_overrideArea(){} // RVA: 0x1AD91E0
        public void get_area(){} // RVA: 0x15AF000
        public void set_area(){} // RVA: 0x1FAA840
        public void get_overrideGenerateLinks(){} // RVA: 0xF73960
        public void set_overrideGenerateLinks(){} // RVA: 0xF73A60
        public void get_generateLinks(){} // RVA: 0x14F7430
        public void set_generateLinks(){} // RVA: 0x21CBB70
        public void get_ignoreFromBuild(){} // RVA: 0x28E58A0
        public void set_ignoreFromBuild(){} // RVA: 0x28E5890
        public void get_applyToChildren(){} // RVA: 0x28E5880
        public void set_applyToChildren(){} // RVA: 0x28E5870
        public void get_activeModifiers(){} // RVA: 0x77C4AD0
        public void ClearNavMeshModifiers(){} // RVA: 0x77C4B30
        public void OnEnable(){} // RVA: 0x77C4BD0
        public void OnDisable(){} // RVA: 0x77C4D20
        public void AffectsAgentType(){} // RVA: 0x77C4DB0
        public void .ctor(){} // RVA: 0x77C4EB0
        public void .cctor(){} // RVA: 0x77C5000
    }

    public class NavMeshModifierVolume : MonoBehaviour
    {
        public object m_SerializedVersion;
        public object m_Size;
        public object m_Center;
        public object m_Area;
        public object m_AffectedAgents;
        public object s_NavMeshModifiers;

        // ── Methods ──
        public void get_size(){} // RVA: 0xB9E050
        public void set_size(){} // RVA: 0xB9E070
        public void get_center(){} // RVA: 0x2408800
        public void set_center(){} // RVA: 0x1422080
        public void get_area(){} // RVA: 0x114DAD0
        public void set_area(){} // RVA: 0x25671C0
        public void get_activeModifiers(){} // RVA: 0x77C50E0
        public void ClearNavMeshModifiers(){} // RVA: 0x77C5140
        public void OnEnable(){} // RVA: 0x77C51E0
        public void OnDisable(){} // RVA: 0x77C5330
        public void AffectsAgentType(){} // RVA: 0x77C53C0
        public void .ctor(){} // RVA: 0x77C54C0
        public void .cctor(){} // RVA: 0x77C5640
    }

    public class NavMeshModifierVolume[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class NavMeshModifier[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class NavMeshSurface : MonoBehaviour
    {
        public object m_SerializedVersion;
        public object m_AgentTypeID;
        public object m_CollectObjects;
        public object m_Size;
        public object m_Center;
        public object m_LayerMask;
        public object m_UseGeometry;
        public object m_DefaultArea;
        public object m_GenerateLinks;
        public object m_IgnoreNavMeshAgent;
        public object m_IgnoreNavMeshObstacle;
        public object m_OverrideTileSize;
        public object m_TileSize;
        public object m_OverrideVoxelSize;
        public object m_VoxelSize;
        public object m_MinRegionArea;
        public object m_NavMeshData;
        public object m_BuildHeightMesh;
        public object m_NavMeshDataInstance;
        public object m_LastPosition;
        public object m_LastRotation;
        public object s_NavMeshSurfaces;

        // ── Methods ──
        public void get_agentTypeID(){} // RVA: 0x15AF000
        public void set_agentTypeID(){} // RVA: 0x1FAA840
        public void get_collectObjects(){} // RVA: 0x1065D50
        public void set_collectObjects(){} // RVA: 0x13233D0
        public void get_size(){} // RVA: 0xBA9C30
        public void set_size(){} // RVA: 0xBA9C50
        public void get_center(){} // RVA: 0xBA9C60
        public void set_center(){} // RVA: 0xBA9C80
        public void get_layerMask(){} // RVA: 0xBE5870
        public void set_layerMask(){} // RVA: 0xBE5880
        public void get_useGeometry(){} // RVA: 0xBE5890
        public void set_useGeometry(){} // RVA: 0xBE58A0
        public void get_defaultArea(){} // RVA: 0x1D46130
        public void set_defaultArea(){} // RVA: 0x262A680
        public void get_ignoreNavMeshAgent(){} // RVA: 0x24BED30
        public void set_ignoreNavMeshAgent(){} // RVA: 0x24BA470
        public void get_ignoreNavMeshObstacle(){} // RVA: 0x24BE000
        public void set_ignoreNavMeshObstacle(){} // RVA: 0x24BB3B0
        public void get_overrideTileSize(){} // RVA: 0x24BA230
        public void set_overrideTileSize(){} // RVA: 0x24BB840
        public void get_tileSize(){} // RVA: 0x15443F0
        public void set_tileSize(){} // RVA: 0x15443E0
        public void get_overrideVoxelSize(){} // RVA: 0xE3F480
        public void set_overrideVoxelSize(){} // RVA: 0x1546550
        public void get_voxelSize(){} // RVA: 0xB6B180
        public void set_voxelSize(){} // RVA: 0xB6B190
        public void get_minRegionArea(){} // RVA: 0xC5C4A0
        public void set_minRegionArea(){} // RVA: 0x18AD0F0
        public void get_buildHeightMesh(){} // RVA: 0xBC03E0
        public void set_buildHeightMesh(){} // RVA: 0xBC03F0
        public void get_navMeshData(){} // RVA: 0xBBFF90
        public void set_navMeshData(){} // RVA: 0xBBFFA0
        public void get_navMeshDataInstance(){} // RVA: 0x21EA4F0
        public void get_activeSurfaces(){} // RVA: 0x77C5720
        public void GetInflatedBounds(){} // RVA: 0x77C5780
        public void ClearNavMeshSurfaces(){} // RVA: 0x77C5890
        public void OnEnable(){} // RVA: 0x77C5930
        public void OnDisable(){} // RVA: 0x77C5990
        public void AddData(){} // RVA: 0x77C5A30
        public void RemoveData(){} // RVA: 0x77C5E30
        public void GetBuildSettings(){} // RVA: 0x77C5E90
        public void BuildNavMesh(){} // RVA: 0x77C6090
        public void UpdateNavMesh(){} // RVA: 0x77C6500
        public void Register(){} // RVA: 0x77C6690
        public void Unregister(){} // RVA: 0x77C6980
        public void UpdateActive(){} // RVA: 0x77C6B90
        public void AppendModifierVolumes(){} // RVA: 0x77C6CC0
        public void CollectSources(){} // RVA: 0x77C7550
        public void Abs(){} // RVA: 0x2604730
        public void GetWorldBounds(){} // RVA: 0x77C8350
        public void CalculateWorldBounds(){} // RVA: 0x77C87F0
        public void HasTransformChanged(){} // RVA: 0x77C9320
        public void UpdateDataIfTransformChanged(){} // RVA: 0x77C9560
        public void CollectSourcesInVolume(){} // RVA: 0x77C95A0
        public void CollectSourcesInHierarchy(){} // RVA: 0x77C9620
        public void .ctor(){} // RVA: 0x77C9800
        public void .cctor(){} // RVA: 0x77C9920
    }

    public class NavMeshSurface[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}