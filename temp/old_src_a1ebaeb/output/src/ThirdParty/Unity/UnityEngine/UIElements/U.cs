// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 32
// Methods: 189

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class UIDocument : MonoBehaviour
    {
        public object k_DefaultSortingOrder; // 0x331C1950
        public object m_PanelSettings; // 0x331C1950
        public object m_ChildrenContent; // 0x331C1950
        public object m_RootVisualElement; // 0x331C1950

        // ── Original Methods ──
        public void get_panelSettings(){} // RVA: 0x7ffaaf2ffa30
        public void set_panelSettings(){} // RVA: 0x7ffaaf5bd1d0
        public void get_parentUI(){} // RVA: 0x7ffaa8bf45b0
        public void set_parentUI(){} // RVA: 0x7ffaa8bf45c0
        public void get_visualTreeAsset(){} // RVA: 0x7ffaaf341830
        public void set_visualTreeAsset(){} // RVA: 0x7ffaaf5bd8e0
        public void get_rootVisualElement(){} // RVA: 0x7ffaaf3418a0
        public void get_firstChildInserIndex(){} // RVA: 0x7ffaa8b645f0
        public void get_sortingOrder(){} // RVA: 0x7ffaa895b040
        public void set_sortingOrder(){} // RVA: 0x7ffaaf5bd940
        public void ApplySortingOrder(){} // RVA: 0x7ffaaf5bd960
        public void .ctor(){} // RVA: 0x7ffaaf5bd970
        public void Awake(){} // RVA: 0x7ffaaf5bdb00
        public void OnEnable(){} // RVA: 0x7ffaaf5bdb10
        public void FindUIDocumentParent(){} // RVA: 0x7ffaaf5be010
        public void Reset(){} // RVA: 0x7ffaaf5be1b0
        public void AddChildAndInsertContentToVisualTree(){} // RVA: 0x7ffaaf5be450
        public void RemoveChild(){} // RVA: 0x7ffaaf5be590
        public void RecreateUI(){} // RVA: 0x7ffaaf5be610
        public void AddRootVisualElementToTree(){} // RVA: 0x7ffaaf5bef80
        public void RemoveFromHierarchy(){} // RVA: 0x7ffaaf5bf170
        public void OnDisable(){} // RVA: 0x7ffaaf5bf360
        public void OnTransformChildrenChanged(){} // RVA: 0x7ffaaf5bf3d0
        public void OnTransformParentChanged(){} // RVA: 0x7ffaaf5bf690
        public void ReactToHierarchyChanged(){} // RVA: 0x7ffaaf5bf6a0
        // ── Binary Analysis Named ──
        public void SetupFromHierarchy(){} // RVA: 0x7ffaaf5bdd10
        public void SetupRootClassList(){} // RVA: 0x7ffaaf5bee60
    }

    public class UIElementsRuntimeUtility : Object
    {
        public object s_SortedRuntimePanels; // 0x35E93750
        public object s_RepaintProfilerMarkerName; // 0x35E93750
        public object _activeEventSystem; // 0x35E93750, was: <activeEventSystem>k__BackingF

        // ── Original Methods ──
        public void add_onCreatePanel(){} // RVA: 0x7ffaaf63e160
        public void remove_onCreatePanel(){} // RVA: 0x7ffaaf63e2c0
        public void .cctor(){} // RVA: 0x7ffaaf63e420
        public void CreateEvent(){} // RVA: 0x7ffaaf63eb20
        public void FindOrCreateRuntimePanel(){} // RVA: 0x7ffaaf63ebd0
        public void DisposeRuntimePanel(){} // RVA: 0x7ffaaf63ee10
        public void RegisterCachedPanelInternal(){} // RVA: 0x7ffaaf63f110
        public void RemoveCachedPanelInternal(){} // RVA: 0x7ffaaf63f420
        public void RepaintOffscreenPanels(){} // RVA: 0x7ffaaf63f680
        public void RepaintOverlayPanel(){} // RVA: 0x7ffaaf63f930
        public void RenderOverlaysBeforePriority(){} // RVA: 0x7ffaaf63fc00
        public void EndRenderOverlays(){} // RVA: 0x7ffaaf63fe20
        public void get_activeEventSystem(){} // RVA: 0x7ffaaf63fe90
        public void set_activeEventSystem(){} // RVA: 0x7ffaaf63fef0
        public void get_useDefaultEventSystem(){} // RVA: 0x7ffaaf63ffb0
        public void RegisterEventSystem(){} // RVA: 0x7ffaaf6400f0
        public void UnregisterEventSystem(){} // RVA: 0x7ffaaf640410
        public void get_defaultEventSystem(){} // RVA: 0x7ffaaf6405b0
        public void UpdateRuntimePanels(){} // RVA: 0x7ffaaf6406c0
        public void MarkPotentiallyEmpty(){} // RVA: 0x7ffaaf640a90
        public void RemoveUnusedPanels(){} // RVA: 0x7ffaaf640bf0
        public void RegisterPlayerloopCallback(){} // RVA: 0x7ffaaf640e20
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7ffaaf640f40
        public void SortPanels(){} // RVA: 0x7ffaaf641110
        public void MultiDisplayBottomLeftToPanelPosition(){} // RVA: 0x7ffaaf6414c0
        public void MultiDisplayToLocalScreenPosition(){} // RVA: 0x7ffaaf641650
        public void ScreenBottomLeftToPanelPosition(){} // RVA: 0x7ffaaf641810
        public void ScreenBottomLeftToPanelDelta(){} // RVA: 0x7ffaaf641930
        // ── Binary Analysis Named ──
        public void BeginRenderOverlays(){} // RVA: 0x7ffaaf63fba0
        public void SetPanelOrderingDirty(){} // RVA: 0x7ffaaf641010
        public void GetSortedPlayerPanels(){} // RVA: 0x7ffaaf641070
    }

    public class UIElementsRuntimeUtilityNative : Object
    {
        public object RepaintOffscreenPanelsCallback; // 0x32F6A5C0

        // ── Original Methods ──
        public void RepaintOverlayPanels(){} // RVA: 0x7ffaaf5c84c0
        public void UpdateRuntimePanels(){} // RVA: 0x7ffaaf5c8520
        public void RepaintOffscreenPanels(){} // RVA: 0x7ffaaf5c8580
        public void RegisterPlayerloopCallback(){} // RVA: 0x7ffaaf5c85e0
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7ffaaf5c8630
        public void VisualElementCreation(){} // RVA: 0x7ffaaf5c8680
    }

    public class UIElementsUtility : Object
    {
        public object s_EventInstance; // 0x35BC01B0
        public object s_Instance; // 0x35BC01B0
        public object s_EventProfilerMarkerName; // 0x35BC01B0
        public object s_Modifiers; // 0x35BC01B0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf643380
        public void UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7ffaaf643440
        public void UnityEngine.UIElements.IUIElementsUtility.TakeCapture(){} // RVA: 0x7ffaaf643530
        public void UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture(){} // RVA: 0x7ffaaac0a810
        public void UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(){} // RVA: 0x7ffaaf643600
        public void UnityEngine.UIElements.IUIElementsUtility.CleanupRoots(){} // RVA: 0x7ffaaf643750
        public void UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(){} // RVA: 0x7ffaaf6438f0
        public void RegisterCachedPanel(){} // RVA: 0x7ffaaf6439e0
        public void RemoveCachedPanel(){} // RVA: 0x7ffaaf643a90
        public void TryGetPanel(){} // RVA: 0x7ffaaf643b20
        public void EndContainerGUI(){} // RVA: 0x7ffaaf644190
        public void CreateEvent(){} // RVA: 0x7ffaaf644580
        public void CreateEvent(){} // RVA: 0x7ffaaf644580
        public void PixelsPerUnitScaleForElement(){} // RVA: 0x7ffaaf6455e0
        public void ParseMenuName(){} // RVA: 0x7ffaaf645770
        public void .cctor(){} // RVA: 0x7ffaaf645960
        // ── Binary Analysis Named ──
        public void BeginContainerGUI(){} // RVA: 0x7ffaaf643bc0
        public void DoDispatch(){} // RVA: 0x7ffaaf644b10
        public void GetAllPanels(){} // RVA: 0x7ffaaf645360
        public void GetPanelsIterator(){} // RVA: 0x7ffaaf6454b0
    }

    public class UIEventRegistration : Object
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaf641c00
        public void RegisterUIElementSystem(){} // RVA: 0x7ffaaf642590
        public void TakeCapture(){} // RVA: 0x7ffaaf642620
        public void ReleaseCapture(){} // RVA: 0x7ffaaf6427c0
        public void EndContainerGUIFromException(){} // RVA: 0x7ffaaf642960
        public void ProcessEvent(){} // RVA: 0x7ffaaf642b50
        public void CleanupRoots(){} // RVA: 0x7ffaaf642db0
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7ffaaf642f50
    }

    public class UQuery : Object
    {
    }

    public class UQueryBuilder`1 : ValueType
    {
        public object m_Element; // 0x31468030
        public object pseudoStatesMask; // 0x31468030

        // ── Original Methods ──
        public void get_styleSelectors(){} // RVA: 0x7ffaa86491d0
        public void get_parts(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Class(){} // RVA: 0x7ffaa887e5c0
        public void Name(){} // RVA: 0x7ffaa887e5c0
        public void SingleBaseType(){} // RVA: 0x7ffaa887e5c0
        public void AddClass(){} // RVA: 0x7ffaa8660d80
        public void AddName(){} // RVA: 0x7ffaa8660d80
        public void AddPseudoStatesRuleIfNecessasy(){} // RVA: 0x7ffaa8660cc0
        public void FinishSelector(){} // RVA: 0x7ffaa8660cc0
        public void CurrentSelectorEmpty(){} // RVA: 0x7ffaa864a040
        public void FinishCurrentSelector(){} // RVA: 0x7ffaa8660cc0
        public void Build(){} // RVA: 0x7ffaa887e5c0
        public void Equals(){} // RVA: 0x7ffaa864a2a0
        public void Equals(){} // RVA: 0x7ffaa864a2a0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
    }

    public class UQueryExtensions : Object
    {
        public object SingleElementClassQuery; // 0x31911B40
        public object SingleElementTypeAndNameQuery; // 0x31911B40

        // ── Original Methods ──
        public void Q(){} // RVA: 0x7ffaaf646700
        public void Q(){} // RVA: 0x7ffaaf646700
        public void .cctor(){} // RVA: 0x7ffaaf646dd0
    }

    public class UQueryState`1 : ValueType
    {
        public object m_Matchers; // 0x30CC2E20

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8669e70
        public void RebuildOn(){} // RVA: 0x7ffaa887e5c0
        public void Single(){} // RVA: 0x7ffaa887e5c0
        public void First(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void Equals(){} // RVA: 0x7ffaa864a2a0
        public void Equals(){} // RVA: 0x7ffaa864a2a0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa887e5c0
        public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
    }

    public class UxmlAsset : Object
    {
        public object m_OrderInDocument; // 0x331C0390
        public object m_Name; // 0x331C01E0

        // ── Original Methods ──
        public void get_fullTypeName(){} // RVA: 0x7ffaa894d380
        public void get_id(){} // RVA: 0x7ffaa8b945a0
        public void get_orderInDocument(){} // RVA: 0x7ffaa9e5ac10
        public void get_parentId(){} // RVA: 0x7ffaa8aeced0
        public void TryGetAttributeValue(){} // RVA: 0x7ffaaf64d070
        // ── Binary Analysis Named ──
        public void SetAttribute(){} // RVA: 0x7ffaaf64d250
        public void SetOrAddProperty(){} // RVA: 0x7ffaaf64d260
    }

    public class UxmlAttributeDescription : Object
    {
        public object _type; // 0x30B315F0, was: <type>k__BackingField
        public object _restriction; // 0x30B315F0, was: <restriction>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac72f370
        public void get_name(){} // RVA: 0x7ffaa894d380
        public void set_name(){} // RVA: 0x7ffaa8933e30
        public void set_obsoleteNames(){} // RVA: 0x7ffaaf648ec0
        public void set_type(){} // RVA: 0x7ffaa89600d0
        public void set_typeNamespace(){} // RVA: 0x7ffaa8933e90
        public void set_use(){} // RVA: 0x7ffaa898dce0
        public void set_restriction(){} // RVA: 0x7ffaa8bf45c0
        public void TryGetValueFromBagAsString(){} // RVA: 0x7ffaaf648fe0
        public void TryGetValueFromBag(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetValueFromBag(){} // RVA: 0x7ffaa887e5c0
    }

    public class UxmlEnumAttributeDescription`1 : TypedUxmlAttributeDescription`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void TryGetValueFromBag(){} // RVA: 0x7ffaa887e5c0
        public void ConvertValueToEnum(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetValueFromBag(){} // RVA: 0x7ffaa887e5c0
        public void GetEnumNameErrorMessage(){} // RVA: 0x7ffaa8649330
        public void GetEnumRangeErrorMessage(){} // RVA: 0x7ffaa8649330
    }

    public class UxmlFactory`1 : UxmlFactory`2
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaac868a90
        public void .ctor(){} // RVA: 0x7ffaac868b20
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Original Methods ──
        public void Create(){}
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaac868a90
        public void .ctor(){} // RVA: 0x7ffaac868b20
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaac868a90
        public void .ctor(){} // RVA: 0x7ffaac868b20
    }

    public class UxmlObjectAttributeDescription`1 : Object
    {
        // ── Original Methods ──
        public void get_defaultValue(){} // RVA: 0x7ffaa894d380
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetValueFromBag(){} // RVA: 0x7ffaac868b40
    }

    public class UxmlObjectAttributeDescription`1 : Object
    {
        // ── Original Methods ──
        public void get_defaultValue(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetValueFromBag(){} // RVA: 0x7ffaa887e5c0
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Original Methods ──
        public void CreateObject(){} // RVA: 0x7ffaa884bb60
        public void .ctor(){} // RVA: 0x7ffaab661b70
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Original Methods ──
        public void CreateObject(){} // RVA: 0x7ffaa884bb60
        public void .ctor(){} // RVA: 0x7ffaab661b70
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Original Methods ──
        public void CreateObject(){} // RVA: 0x7ffaa884bb60
        public void .ctor(){} // RVA: 0x7ffaab661b70
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Original Methods ──
        public void CreateObject(){} // RVA: 0x7ffaa884bb60
        public void .ctor(){} // RVA: 0x7ffaab661b70
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Original Methods ──
        public void CreateObject(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class UxmlObjectListAttributeDescription`1 : UxmlObjectAttributeDescription`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetValueFromBag(){}
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Original Methods ──
        public void Init(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8c586c0
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Original Methods ──
        public void Init(){}
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Original Methods ──
        public void Init(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8c586c0
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Original Methods ──
        public void Init(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8c586c0
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Original Methods ──
        public void Init(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8c586c0
    }

    public class UxmlTraits : BaseUxmlTraits
    {
        // ── Original Methods ──
        public void Init(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8c586c0
    }

    public class UxmlTypeAttributeDescription`1 : TypedUxmlAttributeDescription`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void ConvertValueToType(){} // RVA: 0x7ffaa865aa30
        public void <GetValueFromBag>b__3_0(){} // RVA: 0x7ffaa865aa30
        // ── Binary Analysis Named ──
        public void GetValueFromBag(){}
    }

}