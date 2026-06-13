// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 100
// Methods: 420

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class UIDocument
    {
        public string k_RootStyleClassName;
        public string k_VisualElementNameSuffix;
        public int k_DefaultSortingOrder;
        public int s_CurrentUIDocumentCounter;
        public int m_UIDocumentCreationIndex; // 0x20
        public UnityEngine.UIElements.PanelSettings m_PanelSettings; // 0x28

        // ── Methods ──
        public void get_panelSettings(){} // RVA: 0x7145590
        public void set_panelSettings(){} // RVA: 0x7403970
        public void get_parentUI(){} // RVA: 0x4976A0
        public void set_parentUI(){} // RVA: 0x49B830
        public void get_visualTreeAsset(){} // RVA: 0x7187FD0
        public void set_visualTreeAsset(){} // RVA: 0x7404080
        public void get_rootVisualElement(){} // RVA: 0x7188040
        public void get_firstChildInserIndex(){} // RVA: 0x59CEC0
        public void get_sortingOrder(){} // RVA: 0x306040
        public void set_sortingOrder(){} // RVA: 0x74040E0
        public void ApplySortingOrder(){} // RVA: 0x7404100
        public void .ctor(){} // RVA: 0x7404110
        public void Awake(){} // RVA: 0x74042A0
        public void OnEnable(){} // RVA: 0x74042B0
        public void SetupFromHierarchy(){} // RVA: 0x74044B0
        public void FindUIDocumentParent(){} // RVA: 0x74047B0
        public void Reset(){} // RVA: 0x7404950
        public void AddChildAndInsertContentToVisualTree(){} // RVA: 0x7404BF0
        public void RemoveChild(){} // RVA: 0x7404D30
        public void RecreateUI(){} // RVA: 0x7404DB0
        public void SetupRootClassList(){} // RVA: 0x7405600
        public void AddRootVisualElementToTree(){} // RVA: 0x7405720
        public void RemoveFromHierarchy(){} // RVA: 0x7405910
        public void OnDisable(){} // RVA: 0x7405B00
        public void OnTransformChildrenChanged(){} // RVA: 0x7405B70
        public void OnTransformParentChanged(){} // RVA: 0x7405E30
        public void ReactToHierarchyChanged(){} // RVA: 0x7405E40
    }

    public class UIDocumentList
    {
        // ── Methods ──
        public void RemoveFromListAndFromVisualTree(){} // RVA: 0x7403460
        public void AddToListAndToVisualTree(){} // RVA: 0x74034D0
        public void .ctor(){} // RVA: 0x74038B0
    }

    public class UIElementsBridge
    {
        // ── Methods ──
        public void SetWantsMouseJumping(){} // RVA: 0x24FA0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UIElementsPackageUtility
    {
        public bool <IsUIEPackageLoaded>k__BackingField;
        public string <EditorResourcesBasePath>k__BackingField; // 0x8

        // ── Methods ──
        public void get_IsUIEPackageLoaded(){} // RVA: 0x7484570
        public void set_IsUIEPackageLoaded(){} // RVA: 0x74845D0
        public void get_EditorResourcesBasePath(){} // RVA: 0x7484630
        public void set_EditorResourcesBasePath(){} // RVA: 0x7484690
        public void .cctor(){} // RVA: 0x7484750
        public void Refresh(){} // RVA: 0x7484750
    }

    public class UIElementsRuntimeUtility
    {
        public System.Action`1<UnityEngine.UIElements.BaseRuntimePanel> onCreatePanel;
        public bool s_RegisteredPlayerloopCallback; // 0x8
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Panel> s_SortedRuntimePanels; // 0x10

        // ── Methods ──
        public void add_onCreatePanel(){} // RVA: 0x74848A0
        public void remove_onCreatePanel(){} // RVA: 0x7484A00
        public void .cctor(){} // RVA: 0x7484B60
        public void CreateEvent(){} // RVA: 0x7485260
        public void FindOrCreateRuntimePanel(){} // RVA: 0x7485310
        public void DisposeRuntimePanel(){} // RVA: 0x7485550
        public void RegisterCachedPanelInternal(){} // RVA: 0x7485850
        public void RemoveCachedPanelInternal(){} // RVA: 0x7485B60
        public void RepaintOffscreenPanels(){} // RVA: 0x7485DC0
        public void RepaintOverlayPanel(){} // RVA: 0x7486070
        public void BeginRenderOverlays(){} // RVA: 0x74862E0
        public void RenderOverlaysBeforePriority(){} // RVA: 0x7486340
        public void EndRenderOverlays(){} // RVA: 0x7486560
        public void get_activeEventSystem(){} // RVA: 0x74865D0
        public void set_activeEventSystem(){} // RVA: 0x7486630
        public void get_useDefaultEventSystem(){} // RVA: 0x74866F0
        public void RegisterEventSystem(){} // RVA: 0x7486830
        public void UnregisterEventSystem(){} // RVA: 0x7486B50
        public void get_defaultEventSystem(){} // RVA: 0x7486CF0
        public void UpdateRuntimePanels(){} // RVA: 0x7486E00
        public void MarkPotentiallyEmpty(){} // RVA: 0x74871D0
        public void RemoveUnusedPanels(){} // RVA: 0x7487330
        public void RegisterPlayerloopCallback(){} // RVA: 0x7487560
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7487680
        public void SetPanelOrderingDirty(){} // RVA: 0x7487750
        public void GetSortedPlayerPanels(){} // RVA: 0x74877B0
        public void SortPanels(){} // RVA: 0x7487850
        public void MultiDisplayBottomLeftToPanelPosition(){} // RVA: 0x7487C00
        public void MultiDisplayToLocalScreenPosition(){} // RVA: 0x7487D90
        public void ScreenBottomLeftToPanelPosition(){} // RVA: 0x7487F50
        public void ScreenBottomLeftToPanelDelta(){} // RVA: 0x7488070
    }

    public class UIElementsRuntimeUtilityNative
    {
        // ── Methods ──
        public void RepaintOverlayPanels(){} // RVA: 0x740EC60
        public void UpdateRuntimePanels(){} // RVA: 0x740ECC0
        public void RepaintOffscreenPanels(){} // RVA: 0x740ED20
        public void RegisterPlayerloopCallback(){} // RVA: 0x740ED80
        public void UnregisterPlayerloopCallback(){} // RVA: 0x740EDD0
        public void VisualElementCreation(){} // RVA: 0x740EE20
    }

    public class UIElementsUtility
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7489AC0
        public void UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7489B80
        public void UnityEngine.UIElements.IUIElementsUtility.TakeCapture(){} // RVA: 0x7489C70
        public void UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture(){} // RVA: 0x27694F0
        public void UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(){} // RVA: 0x7489D40
        public void UnityEngine.UIElements.IUIElementsUtility.CleanupRoots(){} // RVA: 0x7489E90
        public void UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(){} // RVA: 0x748A030
        public void RegisterCachedPanel(){} // RVA: 0x748A120
        public void RemoveCachedPanel(){} // RVA: 0x748A1D0
        public void TryGetPanel(){} // RVA: 0x748A260
        public void BeginContainerGUI(){} // RVA: 0x748A300
        public void EndContainerGUI(){} // RVA: 0x748A8D0
        public void CreateEvent(){} // RVA: 0x748ACC0 | overloaded x2
        public void DoDispatch(){} // RVA: 0x748B250
        public void GetAllPanels(){} // RVA: 0x748BAA0
        public void GetPanelsIterator(){} // RVA: 0x748BBF0
        public void PixelsPerUnitScaleForElement(){} // RVA: 0x748BD20
        public void ParseMenuName(){} // RVA: 0x748BEB0
        public void .cctor(){} // RVA: 0x748C0A0
    }

    public class UIEventRegistration
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7488340
        public void RegisterUIElementSystem(){} // RVA: 0x7488CD0
        public void TakeCapture(){} // RVA: 0x7488D60
        public void ReleaseCapture(){} // RVA: 0x7488F00
        public void EndContainerGUIFromException(){} // RVA: 0x74890A0
        public void ProcessEvent(){} // RVA: 0x7489290
        public void CleanupRoots(){} // RVA: 0x74894F0
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7489690
    }

    public class UIPainter2D
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x740E580
        public void Destroy(){} // RVA: 0x740E5E0
        public void Reset(){} // RVA: 0x740E630
    }

    public class UIRAtlasAllocator
    {
        public int <maxAtlasSize>k__BackingField; // 0x10
        public int <maxImageWidth>k__BackingField; // 0x14
        public int <maxImageHeight>k__BackingField; // 0x18
        public int <virtualWidth>k__BackingField; // 0x1C
        public int <virtualHeight>k__BackingField; // 0x20
        public int <physicalWidth>k__BackingField; // 0x24
        public int <physicalHeight>k__BackingField; // 0x28
        public AreaNode m_FirstUnpartitionedArea; // 0x30

        // ── Methods ──
        public void get_maxAtlasSize(){} // RVA: 0x32A5C0
        public void get_maxImageWidth(){} // RVA: 0x8ABED0
        public void get_maxImageHeight(){} // RVA: 0x5BED50
        public void get_virtualWidth(){} // RVA: 0x197C3B0
        public void set_virtualWidth(){} // RVA: 0x1989FD0
        public void get_virtualHeight(){} // RVA: 0x760030
        public void set_virtualHeight(){} // RVA: 0x99E0D0
        public void get_physicalWidth(){} // RVA: 0xCEF5B0
        public void set_physicalWidth(){} // RVA: 0x16E1F00
        public void get_physicalHeight(){} // RVA: 0x791DC0
        public void set_physicalHeight(){} // RVA: 0xA53440
        public void get_disposed(){} // RVA: 0x394D30
        public void set_disposed(){} // RVA: 0x394D40
        public void Dispose(){} // RVA: 0x7416690 | overloaded x2
        public void GetLog2OfNextPower(){} // RVA: 0x7416870
        public void .ctor(){} // RVA: 0x74168E0
        public void TryAllocate(){} // RVA: 0x7416CA0
        public void TryPartitionArea(){} // RVA: 0x7416FF0
        public void BuildAreas(){} // RVA: 0x7417410
        public void .cctor(){} // RVA: 0x74174F0
    }

    public class UIRLayoutUpdater
    {
        public string s_Description;

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x74315C0
        public void OnVersionChanged(){} // RVA: 0x7431620
        public void Update(){} // RVA: 0x7431670
        public void UpdateSubTree(){} // RVA: 0x7431A60
        public void DispatchChangeEvents(){} // RVA: 0x7432430
        public void .ctor(){} // RVA: 0x7432780
        public void .cctor(){} // RVA: 0x7432840
    }

    public class UIRRepaintUpdater
    {
        public UnityEngine.UIElements.BaseVisualElementPanel attachedPanel; // 0x20
        public UnityEngine.UIElements.UIR.RenderChain renderChain; // 0x28
        public string s_Description;
        public Unity.Profiling.ProfilerMarker s_ProfilerMarker; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74367D0
        public void get_profilerMarker(){} // RVA: 0x7436920
        public void get_drawStats(){} // RVA: 0x303450
        public void get_breakBatches(){} // RVA: 0x303470
        public void OnVersionChanged(){} // RVA: 0x7436980
        public void Update(){} // RVA: 0x7436D50
        public void CreateRenderChain(){} // RVA: 0x7436FD0
        public void .cctor(){} // RVA: 0x7437030
        public void OnGraphicsResourcesRecreate(){} // RVA: 0x7437330
        public void OnPanelChanged(){} // RVA: 0x7437650
        public void AttachToPanel(){} // RVA: 0x7437670
        public void DetachFromPanel(){} // RVA: 0x7437BB0
        public void InitRenderChain(){} // RVA: 0x74380D0
        public void DestroyRenderChain(){} // RVA: 0x74381D0
        public void OnPanelAtlasChanged(){} // RVA: 0x74382E0
        public void OnPanelHierarchyChanged(){} // RVA: 0x74382F0
        public void OnPanelStandardShaderChanged(){} // RVA: 0x7438360
        public void OnPanelStandardWorldSpaceShaderChanged(){} // RVA: 0x7438630
        public void ResetAllElementsDataRecursive(){} // RVA: 0x7438900
        public void get_disposed(){} // RVA: 0x3BE7520
        public void set_disposed(){} // RVA: 0x5AC2490
        public void Dispose(){} // RVA: 0x7438A30
    }

    public class UIRUtility
    {
        // ── Methods ──
        public void ShapeWindingIsClockwise(){} // RVA: 0x743A010
        public void IsRoundRect(){} // RVA: 0x743A090
        public void IsVectorImageBackground(){} // RVA: 0x743A160
        public void IsElementSelfHidden(){} // RVA: 0x743A290
        public void Destroy(){} // RVA: 0x743A2F0
        public void GetPrevPow2(){} // RVA: 0x743A460
        public void GetNextPow2(){} // RVA: 0x743A480
        public void GetNextPow2Exp(){} // RVA: 0x743A4A0
        public void .cctor(){} // RVA: 0x743A4C0
    }

    public class UITKTextHandle
    {
        public UnityEngine.Vector2 textInfo; // 0x38
        public UnityEngine.Vector2 layoutTextInfo; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x747AB10
        public void get_MeasuredSizes(){} // RVA: 0x1514540
        public void set_MeasuredSizes(){} // RVA: 0xF501D0
        public void get_RoundedSizes(){} // RVA: 0x747AD00
        public void set_RoundedSizes(){} // RVA: 0x36B37A0
        public void ComputeTextWidth(){} // RVA: 0x747AD20
        public void ComputeTextHeight(){} // RVA: 0x747AE90
        public void Update(){} // RVA: 0x747AFE0
        public void ATagOnPointerUp(){} // RVA: 0x747B1E0
        public void ATagOnPointerOver(){} // RVA: 0x4930B0
        public void ATagOnPointerMove(){} // RVA: 0x747B4F0
        public void ATagOnPointerOut(){} // RVA: 0x4930B0
        public void LinkTagOnPointerDown(){} // RVA: 0x747B790
        public void LinkTagOnPointerUp(){} // RVA: 0x747BBC0
        public void LinkTagOnPointerMove(){} // RVA: 0x747BFF0
        public void LinkTagOnPointerOut(){} // RVA: 0x747C740
        public void HandleLinkTag(){} // RVA: 0x747C8A0
        public void HandleATag(){} // RVA: 0x747CCB0
        public void GetTextOverflowMode(){} // RVA: 0x747D160
        public void ConvertUssToTextGenerationSettings(){} // RVA: 0x747D2C0
        public void TextLibraryCanElide(){} // RVA: 0x747DB30
        public void GetTextEffectPadding(){} // RVA: 0x747DB80
        public void .cctor(){} // RVA: 0x747DE50
    }

    public class UQuery
    {
    }

    public class UQueryBuilder`1
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSelector> m_StyleSelectors;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSelectorPart> m_Parts;

        // ── Methods ──
        public void get_styleSelectors(){} // RVA: 0xCD60
        public void get_parts(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24B10
        public void Class(){} // RVA: 0x283FA0
        public void Name(){} // RVA: 0x283FA0
        public void SingleBaseType(){} // RVA: 0x283FA0
        public void AddClass(){} // RVA: 0x24B10
        public void AddName(){} // RVA: 0x24B10
        public void AddPseudoStatesRuleIfNecessasy(){} // RVA: 0x24A50
        public void FinishSelector(){} // RVA: 0x24A50
        public void CurrentSelectorEmpty(){} // RVA: 0xDBE0
        public void FinishCurrentSelector(){} // RVA: 0x24A50
        public void Build(){} // RVA: 0x283FA0
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840
    }

    public class UQueryExtensions
    {
        // ── Methods ──
        public void Q(){} // RVA: 0x748CE40 | overloaded x2
        public void .cctor(){} // RVA: 0x748D510
    }

    public class UQueryState`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DC60
        public void RebuildOn(){} // RVA: 0x283FA0
        public void Single(){} // RVA: 0x283FA0
        public void First(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840
        public void .cctor(){} // RVA: 0x24A80
    }

    public class UQueryState`1
    {
    }

    public class UnsignedIntegerField
    {
        public string ussClassName;

        // ── Methods ──
        public void get_integerInput(){} // RVA: 0x73D0240
        public void ValueToString(){} // RVA: 0x73D02D0
        public void StringToValue(){} // RVA: 0x73D04E0
        public void .ctor(){} // RVA: 0x73D0630 | overloaded x2
        public void CanTryParse(){} // RVA: 0x73D0930
        public void ApplyInputDeviceDelta(){} // RVA: 0x73D0A00
        public void .cctor(){} // RVA: 0x73D0AF0
    }

    public class UnsignedLongField
    {
        public string ussClassName;

        // ── Methods ──
        public void get_unsignedLongInput(){} // RVA: 0x73D1420
        public void ValueToString(){} // RVA: 0x73D14B0
        public void StringToValue(){} // RVA: 0x73D16C0
        public void .ctor(){} // RVA: 0x73D17B0 | overloaded x2
        public void CanTryParse(){} // RVA: 0x73D1AB0
        public void ApplyInputDeviceDelta(){} // RVA: 0x73D1B80
        public void .cctor(){} // RVA: 0x73D1C70
    }

    public class UxmlAsset
    {
        public string m_FullTypeName; // 0x10
        public int m_Id; // 0x18
        public int m_OrderInDocument; // 0x1C
        public int m_ParentId; // 0x20

        // ── Methods ──
        public void get_fullTypeName(){} // RVA: 0x2F8380
        public void get_id(){} // RVA: 0x5BED50
        public void get_orderInDocument(){} // RVA: 0x197C3B0
        public void get_parentId(){} // RVA: 0x760030
        public void TryGetAttributeValue(){} // RVA: 0x74937B0
        public void SetAttribute(){} // RVA: 0x7493990
        public void SetOrAddProperty(){} // RVA: 0x74939A0
    }

    public class UxmlAttributeDescription
    {
        public string <name>k__BackingField; // 0x10
        public string[] m_ObsoleteNames; // 0x18
        public string <type>k__BackingField; // 0x20
        public string <typeNamespace>k__BackingField; // 0x28
        public 0x658400D0 <use>k__BackingField; // 0x30
        public UnityEngine.UIElements.UxmlTypeRestriction <restriction>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4469AC0
        public void get_name(){} // RVA: 0x2F8380
        public void set_name(){} // RVA: 0x2DEE30
        public void set_obsoleteNames(){} // RVA: 0x748F600
        public void set_type(){} // RVA: 0x30B0D0
        public void set_typeNamespace(){} // RVA: 0x2DEE90
        public void set_use(){} // RVA: 0x338CE0
        public void set_restriction(){} // RVA: 0x49B830
        public void TryGetValueFromBagAsString(){} // RVA: 0x748F720
        public void TryGetValueFromBag(){} // RVA: 0x283FA0
        public void GetValueFromBag(){} // RVA: 0x283FA0
    }

    public class UxmlAttributeOverridesFactory
    {
        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x748F2F0
        public void get_uxmlQualifiedName(){} // RVA: 0x748F330
        public void Create(){} // RVA: 0x3E0F620
        public void .ctor(){} // RVA: 0x748F3B0
    }

    public class UxmlAttributeOverridesTraits
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x748F400
    }

    public class UxmlBoolAttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7492C30
        public void GetValueFromBag(){} // RVA: 0x7492DC0
        public void ConvertValueToBool(){} // RVA: 0x7492FF0
    }

    public class UxmlDoubleAttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7490C20
        public void GetValueFromBag(){} // RVA: 0x7490DB0
        public void ConvertValueToDouble(){} // RVA: 0x7490FF0
    }

    public class UxmlEnumAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void GetValueFromBag(){} // RVA: 0x283FA0
        public void TryGetValueFromBag(){} // RVA: 0x283FA0
        public void ConvertValueToEnum(){} // RVA: 0x283FA0
        public void GetEnumNameErrorMessage(){} // RVA: 0xCEC0
        public void GetEnumRangeErrorMessage(){} // RVA: 0xCEC0
    }

    public class UxmlEnumeration
    {
        public System.Collections.Generic.List`1<string> m_Values; // 0x10

        // ── Methods ──
        public void get_values(){} // RVA: 0x33B6D40
        public void set_values(){} // RVA: 0x7494860
        public void Equals(){} // RVA: 0x7494980
        public void .ctor(){} // RVA: 0x7494B00
    }

    public class UxmlFactory`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
    }

    public class UxmlFactory`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x45E3990
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){}
        public void .ctor(){} // RVA: 0x24A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x45E39C0
        public void .ctor(){} // RVA: 0x45E3A50
    }

    public class UxmlFloatAttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74905B0
        public void GetValueFromBag(){} // RVA: 0x7490740
        public void ConvertValueToFloat(){} // RVA: 0x7490980
    }

    public class UxmlHash128AttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7493290
        public void GetValueFromBag(){} // RVA: 0x7493420
    }

    public class UxmlIntAttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7491290
        public void GetValueFromBag(){} // RVA: 0x7491420
        public void TryGetValueFromBag(){} // RVA: 0x7491650
        public void ConvertValueToInt(){} // RVA: 0x7491840
    }

    public class UxmlLongAttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7492610
        public void GetValueFromBag(){} // RVA: 0x74927A0
        public void ConvertValueToLong(){} // RVA: 0x74929D0
    }

    public class UxmlObjectAsset
    {
    }

    public class UxmlObjectAttributeDescription`1
    {
        public T <defaultValue>k__BackingField;

        // ── Methods ──
        public void get_defaultValue(){} // RVA: 0x283FA0
        public void GetValueFromBag(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class UxmlObjectAttributeDescription`1
    {
        public System.Collections.Generic.List`1<T> <defaultValue>k__BackingField; // 0x10

        // ── Methods ──
        public void get_defaultValue(){} // RVA: 0x2F8380
        public void GetValueFromBag(){} // RVA: 0x45E3A70
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UxmlObjectFactoryRegistry
    {
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<UnityEngine.UIElements.IBaseUxmlObjectFactory>> s_Factories;

        // ── Methods ──
        public void get_factories(){} // RVA: 0x7493C30
        public void RegisterFactory(){} // RVA: 0x7493D50
        public void TryGetFactories(){} // RVA: 0x7494100
        public void RegisterEngineFactories(){} // RVA: 0x7494170
        public void RegisterUserFactories(){} // RVA: 0x7494460
    }

    public class UxmlObjectFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x263BC0
        public void .ctor(){} // RVA: 0x3313940
    }

    public class UxmlObjectFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class UxmlObjectFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x263BC0
        public void .ctor(){} // RVA: 0x3313940
    }

    public class UxmlObjectFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x263BC0
        public void .ctor(){} // RVA: 0x3313940
    }

    public class UxmlObjectFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x263BC0
        public void .ctor(){} // RVA: 0x3313940
    }

    public class UxmlObjectListAttributeDescription`1
    {
        // ── Methods ──
        public void GetValueFromBag(){}
        public void .ctor(){} // RVA: 0x24A50
    }

    public class UxmlObjectTraits`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x6BD7E0
    }

}