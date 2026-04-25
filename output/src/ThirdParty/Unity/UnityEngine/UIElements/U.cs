// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 52
// Methods: 334

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class UIDocument : MonoBehaviour
    {
        public string panelSettings;
        public string parentUI;
        public int visualTreeAsset;
        public int rootVisualElement;
        public int firstChildInserIndex; // 0x20
        public UnityEngine.UIElements.PanelSettings sortingOrder; // 0x28
        public UnityEngine.UIElements.PanelSettings m_PreviousPanelSettings; // 0x30
        public UnityEngine.UIElements.UIDocument m_ParentUI; // 0x38
        public UnityEngine.UIElements.UIDocumentList m_ChildrenContent; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.UIElements.UIDocument> m_ChildrenContentCopy; // 0x48
        public UnityEngine.UIElements.VisualTreeAsset sourceAsset; // 0x50
        public UnityEngine.UIElements.VisualElement m_RootVisualElement; // 0x58
        public int m_FirstChildInsertIndex; // 0x60
        public float m_SortingOrder; // 0x64

        // ── Methods ──
        public void get_panelSettings(){} // RVA: 0x7FFAC98DDAD0
        public void set_panelSettings(){} // RVA: 0x7FFAC9B9B260
        public void get_parentUI(){} // RVA: 0x7FFAC31D0140
        public void set_parentUI(){} // RVA: 0x7FFAC31D0C20
        public void get_visualTreeAsset(){} // RVA: 0x7FFAC991F8D0
        public void set_visualTreeAsset(){} // RVA: 0x7FFAC9B9B970
        public void get_rootVisualElement(){} // RVA: 0x7FFAC991F940
        public void get_firstChildInserIndex(){} // RVA: 0x7FFAC3138C20
        public void get_sortingOrder(){} // RVA: 0x7FFAC2F4A040
        public void set_sortingOrder(){} // RVA: 0x7FFAC9B9B9D0
        public void ApplySortingOrder(){} // RVA: 0x7FFAC9B9B9F0
        public void .ctor(){} // RVA: 0x7FFAC9B9BA00
        public void Awake(){} // RVA: 0x7FFAC9B9BB90
        public void OnEnable(){} // RVA: 0x7FFAC9B9BBA0
        public void SetupFromHierarchy(){} // RVA: 0x7FFAC9B9BDA0
        public void FindUIDocumentParent(){} // RVA: 0x7FFAC9B9C0A0
        public void Reset(){} // RVA: 0x7FFAC9B9C240
        public void AddChildAndInsertContentToVisualTree(){} // RVA: 0x7FFAC9B9C4E0
        public void RemoveChild(){} // RVA: 0x7FFAC9B9C620
        public void RecreateUI(){} // RVA: 0x7FFAC9B9C6A0
        public void SetupRootClassList(){} // RVA: 0x7FFAC9B9CEF0
        public void AddRootVisualElementToTree(){} // RVA: 0x7FFAC9B9D010
        public void RemoveFromHierarchy(){} // RVA: 0x7FFAC9B9D200
        public void OnDisable(){} // RVA: 0x7FFAC9B9D3F0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAC9B9D460
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC9B9D720
        public void ReactToHierarchyChanged(){} // RVA: 0x7FFAC9B9D730
    }

    public class UIDocumentList : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.UIDocument> m_AttachedUIDocuments; // 0x10

        // ── Methods ──
        public void RemoveFromListAndFromVisualTree(){} // RVA: 0x7FFAC9B9AD50
        public void AddToListAndToVisualTree(){} // RVA: 0x7FFAC9B9ADC0
        public void .ctor(){} // RVA: 0x7FFAC9B9B1A0
    }

    public class UIElementsBridge : Object
    {
        // ── Methods ──
        public void SetWantsMouseJumping(){} // RVA: 0x7FFAC2C70ED0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UIElementsPackageUtility : Object
    {
        public bool IsUIEPackageLoaded;
        public string EditorResourcesBasePath; // 0x8

        // ── Methods ──
        public void get_IsUIEPackageLoaded(){} // RVA: 0x7FFAC9C1BEC0
        public void set_IsUIEPackageLoaded(){} // RVA: 0x7FFAC9C1BF20
        public void get_EditorResourcesBasePath(){} // RVA: 0x7FFAC9C1BF80
        public void set_EditorResourcesBasePath(){} // RVA: 0x7FFAC9C1BFE0
        public void .cctor(){} // RVA: 0x7FFAC9C1C0A0
        public void Refresh(){} // RVA: 0x7FFAC9C1C0A0
    }

    public class UIElementsRuntimeUtility : Object
    {
        public System.Action`1<UnityEngine.UIElements.BaseRuntimePanel> activeEventSystem;
        public bool useDefaultEventSystem; // 0x8
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Panel> defaultEventSystem; // 0x10
        public bool s_PanelOrderingDirty; // 0x18
        public int s_ResolvedSortingIndexMax; // 0x1C
        public string s_RepaintProfilerMarkerName; // 0x20
        public Unity.Profiling.ProfilerMarker s_RepaintProfilerMarker; // 0x28
        public int currentOverlayIndex; // 0x30
        public UnityEngine.Object <activeEventSystem>k__BackingField; // 0x38
        public UnityEngine.UIElements.DefaultEventSystem s_DefaultEventSystem; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.UIElements.PanelSettings> s_PotentiallyEmptyPanelSettings; // 0x48

        // ── Methods ──
        public void add_onCreatePanel(){} // RVA: 0x7FFAC9C1C1F0
        public void remove_onCreatePanel(){} // RVA: 0x7FFAC9C1C350
        public void .cctor(){} // RVA: 0x7FFAC9C1C4B0
        public void CreateEvent(){} // RVA: 0x7FFAC9C1CBB0
        public void FindOrCreateRuntimePanel(){} // RVA: 0x7FFAC9C1CC60
        public void DisposeRuntimePanel(){} // RVA: 0x7FFAC9C1CEA0
        public void RegisterCachedPanelInternal(){} // RVA: 0x7FFAC9C1D1A0
        public void RemoveCachedPanelInternal(){} // RVA: 0x7FFAC9C1D4B0
        public void RepaintOffscreenPanels(){} // RVA: 0x7FFAC9C1D710
        public void RepaintOverlayPanel(){} // RVA: 0x7FFAC9C1D9C0
        public void BeginRenderOverlays(){} // RVA: 0x7FFAC9C1DC30
        public void RenderOverlaysBeforePriority(){} // RVA: 0x7FFAC9C1DC90
        public void EndRenderOverlays(){} // RVA: 0x7FFAC9C1DEB0
        public void get_activeEventSystem(){} // RVA: 0x7FFAC9C1DF20
        public void set_activeEventSystem(){} // RVA: 0x7FFAC9C1DF80
        public void get_useDefaultEventSystem(){} // RVA: 0x7FFAC9C1E040
        public void RegisterEventSystem(){} // RVA: 0x7FFAC9C1E180
        public void UnregisterEventSystem(){} // RVA: 0x7FFAC9C1E4A0
        public void get_defaultEventSystem(){} // RVA: 0x7FFAC9C1E640
        public void UpdateRuntimePanels(){} // RVA: 0x7FFAC9C1E750
        public void MarkPotentiallyEmpty(){} // RVA: 0x7FFAC9C1EB20
        public void RemoveUnusedPanels(){} // RVA: 0x7FFAC9C1EC80
        public void RegisterPlayerloopCallback(){} // RVA: 0x7FFAC9C1EEB0
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7FFAC9C1EFD0
        public void SetPanelOrderingDirty(){} // RVA: 0x7FFAC9C1F0A0
        public void GetSortedPlayerPanels(){} // RVA: 0x7FFAC9C1F100
        public void SortPanels(){} // RVA: 0x7FFAC9C1F1A0
        public void MultiDisplayBottomLeftToPanelPosition(){} // RVA: 0x7FFAC9C1F550
        public void MultiDisplayToLocalScreenPosition(){} // RVA: 0x7FFAC9C1F6E0
        public void ScreenBottomLeftToPanelPosition(){} // RVA: 0x7FFAC9C1F8A0
        public void ScreenBottomLeftToPanelDelta(){} // RVA: 0x7FFAC9C1F9C0
    }

    public class UIElementsRuntimeUtilityNative : Object
    {
        public System.Action RepaintOverlayPanelsCallback;
        public System.Action UpdateRuntimePanelsCallback; // 0x8
        public System.Action RepaintOffscreenPanelsCallback; // 0x10

        // ── Methods ──
        public void RepaintOverlayPanels(){} // RVA: 0x7FFAC9BA6550
        public void UpdateRuntimePanels(){} // RVA: 0x7FFAC9BA65B0
        public void RepaintOffscreenPanels(){} // RVA: 0x7FFAC9BA6610
        public void RegisterPlayerloopCallback(){} // RVA: 0x7FFAC9BA6670
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7FFAC9BA66C0
        public void VisualElementCreation(){} // RVA: 0x7FFAC9BA6710
    }

    public class UIElementsUtility : Object
    {
        public System.Collections.Generic.Stack`1<UnityEngine.UIElements.IMGUIContainer> s_ContainerStack;
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.UIElements.Panel> s_UIElementsCache; // 0x8
        public UnityEngine.Event s_EventInstance; // 0x10
        public UnityEngine.Color editorPlayModeTintColor; // 0x18
        public float singleLineHeight; // 0x28
        public UnityEngine.UIElements.UIElementsUtility s_Instance; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Panel> s_PanelsIterationList; // 0x38
        public string s_RepaintProfilerMarkerName; // 0x40
        public string s_EventProfilerMarkerName; // 0x48
        public Unity.Profiling.ProfilerMarker s_RepaintProfilerMarker; // 0x50
        public Unity.Profiling.ProfilerMarker s_EventProfilerMarker; // 0x58
        public char[] s_Modifiers; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C21410
        public void UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7FFAC9C214D0
        public void UnityEngine.UIElements.IUIElementsUtility.TakeCapture(){} // RVA: 0x7FFAC9C215C0
        public void UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture(){} // RVA: 0x7FFAC52088B0
        public void UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(){} // RVA: 0x7FFAC9C21690
        public void UnityEngine.UIElements.IUIElementsUtility.CleanupRoots(){} // RVA: 0x7FFAC9C217E0
        public void UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(){} // RVA: 0x7FFAC9C21980
        public void RegisterCachedPanel(){} // RVA: 0x7FFAC9C21A70
        public void RemoveCachedPanel(){} // RVA: 0x7FFAC9C21B20
        public void TryGetPanel(){} // RVA: 0x7FFAC9C21BB0
        public void BeginContainerGUI(){} // RVA: 0x7FFAC9C21C50
        public void EndContainerGUI(){} // RVA: 0x7FFAC9C22220
        public void CreateEvent(){} // RVA: 0x7FFAC9C22610 | overloaded x2
        public void DoDispatch(){} // RVA: 0x7FFAC9C22BA0
        public void GetAllPanels(){} // RVA: 0x7FFAC9C233F0
        public void GetPanelsIterator(){} // RVA: 0x7FFAC9C23540
        public void PixelsPerUnitScaleForElement(){} // RVA: 0x7FFAC9C23670
        public void ParseMenuName(){} // RVA: 0x7FFAC9C23800
        public void .cctor(){} // RVA: 0x7FFAC9C239F0
    }

    public class UIEventRegistration : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.IUIElementsUtility> s_Utilities;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9C1FC90
        public void RegisterUIElementSystem(){} // RVA: 0x7FFAC9C20620
        public void TakeCapture(){} // RVA: 0x7FFAC9C206B0
        public void ReleaseCapture(){} // RVA: 0x7FFAC9C20850
        public void EndContainerGUIFromException(){} // RVA: 0x7FFAC9C209F0
        public void ProcessEvent(){} // RVA: 0x7FFAC9C20BE0
        public void CleanupRoots(){} // RVA: 0x7FFAC9C20E40
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7FFAC9C20FE0
    }

    public class UIPainter2D : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9BA5E70
        public void Destroy(){} // RVA: 0x7FFAC9BA5ED0
        public void Reset(){} // RVA: 0x7FFAC9BA5F20
    }

    public class UIRAtlasAllocator : Object
    {
        public int maxAtlasSize; // 0x10
        public int maxImageWidth; // 0x14
        public int maxImageHeight; // 0x18
        public int virtualWidth; // 0x1C
        public int virtualHeight; // 0x20
        public int physicalWidth; // 0x24
        public int physicalHeight; // 0x28
        public AreaNode disposed; // 0x30
        public Row[] m_OpenRows; // 0x38
        public int m_1SidePadding; // 0x40
        public int m_2SidePadding; // 0x44
        public Unity.Profiling.ProfilerMarker s_MarkerTryAllocate;
        public bool <disposed>k__BackingField; // 0x48

        // ── Methods ──
        public void get_maxAtlasSize(){} // RVA: 0x7FFAC2F6E5C0
        public void get_maxImageWidth(){} // RVA: 0x7FFAC33D5A20
        public void get_maxImageHeight(){} // RVA: 0x7FFAC3157800
        public void get_virtualWidth(){} // RVA: 0x7FFAC44357F0
        public void set_virtualWidth(){} // RVA: 0x7FFAC44474D0
        public void get_virtualHeight(){} // RVA: 0x7FFAC30DBBE0
        public void set_virtualHeight(){} // RVA: 0x7FFAC35DB7A0
        public void get_physicalWidth(){} // RVA: 0x7FFAC3921980
        public void set_physicalWidth(){} // RVA: 0x7FFAC41674D0
        public void get_physicalHeight(){} // RVA: 0x7FFAC32EC4C0
        public void set_physicalHeight(){} // RVA: 0x7FFAC369A6E0
        public void get_disposed(){} // RVA: 0x7FFAC2FD8D30
        public void set_disposed(){} // RVA: 0x7FFAC2FD8D40
        public void Dispose(){} // RVA: 0x7FFAC9BADF80 | overloaded x2
        public void GetLog2OfNextPower(){} // RVA: 0x7FFAC9BAE160
        public void .ctor(){} // RVA: 0x7FFAC9BAE1D0
        public void TryAllocate(){} // RVA: 0x7FFAC9BAE590
        public void TryPartitionArea(){} // RVA: 0x7FFAC9BAE8E0
        public void BuildAreas(){} // RVA: 0x7FFAC9BAED00
        public void .cctor(){} // RVA: 0x7FFAC9BAEDE0
    }

    public class UIRLayoutUpdater : BaseVisualTreeUpdater
    {
        public string profilerMarker;
        public Unity.Profiling.ProfilerMarker s_ProfilerMarker; // 0x8
        public System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEventsList; // 0x20

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFAC9BC8EB0
        public void OnVersionChanged(){} // RVA: 0x7FFAC9BC8F10
        public void Update(){} // RVA: 0x7FFAC9BC8F60
        public void UpdateSubTree(){} // RVA: 0x7FFAC9BC9350
        public void DispatchChangeEvents(){} // RVA: 0x7FFAC9BC9D20
        public void .ctor(){} // RVA: 0x7FFAC9BCA070
        public void .cctor(){} // RVA: 0x7FFAC9BCA130
    }

    public class UIRRepaintUpdater : BaseVisualTreeUpdater
    {
        public UnityEngine.UIElements.BaseVisualElementPanel profilerMarker; // 0x20
        public UnityEngine.UIElements.UIR.RenderChain drawStats; // 0x28
        public string breakBatches;
        public Unity.Profiling.ProfilerMarker disposed; // 0x8
        public bool <drawStats>k__BackingField; // 0x30
        public bool <breakBatches>k__BackingField; // 0x31
        public bool <disposed>k__BackingField; // 0x32

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9BCE0C0
        public void get_profilerMarker(){} // RVA: 0x7FFAC9BCE210
        public void get_drawStats(){} // RVA: 0x7FFAC2F47450
        public void get_breakBatches(){} // RVA: 0x7FFAC2F47470
        public void OnVersionChanged(){} // RVA: 0x7FFAC9BCE270
        public void Update(){} // RVA: 0x7FFAC9BCE640
        public void CreateRenderChain(){} // RVA: 0x7FFAC9BCE8C0
        public void .cctor(){} // RVA: 0x7FFAC9BCE920
        public void OnGraphicsResourcesRecreate(){} // RVA: 0x7FFAC9BCEC20
        public void OnPanelChanged(){} // RVA: 0x7FFAC9BCEF40
        public void AttachToPanel(){} // RVA: 0x7FFAC9BCEF60
        public void DetachFromPanel(){} // RVA: 0x7FFAC9BCF4A0
        public void InitRenderChain(){} // RVA: 0x7FFAC9BCF9C0
        public void DestroyRenderChain(){} // RVA: 0x7FFAC9BCFAC0
        public void OnPanelAtlasChanged(){} // RVA: 0x7FFAC9BCFBD0
        public void OnPanelHierarchyChanged(){} // RVA: 0x7FFAC9BCFBE0
        public void OnPanelStandardShaderChanged(){} // RVA: 0x7FFAC9BCFC50
        public void OnPanelStandardWorldSpaceShaderChanged(){} // RVA: 0x7FFAC9BCFF20
        public void ResetAllElementsDataRecursive(){} // RVA: 0x7FFAC9BD01F0
        public void get_disposed(){} // RVA: 0x7FFAC64EB050
        public void set_disposed(){} // RVA: 0x7FFAC8259980
        public void Dispose(){} // RVA: 0x7FFAC9BD0320
    }

    public class UIRUtility : Object
    {
        public string k_DefaultShaderName;
        public string k_DefaultWorldSpaceShaderName; // 0x8

        // ── Methods ──
        public void ShapeWindingIsClockwise(){} // RVA: 0x7FFAC9BD1900
        public void IsRoundRect(){} // RVA: 0x7FFAC9BD1980
        public void IsVectorImageBackground(){} // RVA: 0x7FFAC9BD1A50
        public void IsElementSelfHidden(){} // RVA: 0x7FFAC9BD1B80
        public void Destroy(){} // RVA: 0x7FFAC9BD1BE0
        public void GetPrevPow2(){} // RVA: 0x7FFAC9BD1D50
        public void GetNextPow2(){} // RVA: 0x7FFAC9BD1D70
        public void GetNextPow2Exp(){} // RVA: 0x7FFAC9BD1D90
        public void .cctor(){} // RVA: 0x7FFAC9BD1DB0
    }

    public class UITKTextHandle : TextHandle
    {
        public UnityEngine.Vector2 MeasuredSizes; // 0x38
        public UnityEngine.Vector2 RoundedSizes; // 0x40
        public UnityEngine.UIElements.TextElement m_TextElement; // 0x48
        public bool isOverridingCursor; // 0x50
        public int currentLinkIDHash; // 0x54
        public bool hasLinkTag; // 0x58
        public bool hasATag; // 0x59
        public float k_MinPadding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C12460
        public void get_MeasuredSizes(){} // RVA: 0x7FFAC3FA0C70
        public void set_MeasuredSizes(){} // RVA: 0x7FFAC35233F0
        public void get_RoundedSizes(){} // RVA: 0x7FFAC9C12650
        public void set_RoundedSizes(){} // RVA: 0x7FFAC5FE03B0
        public void ComputeTextWidth(){} // RVA: 0x7FFAC9C12670
        public void ComputeTextHeight(){} // RVA: 0x7FFAC9C127E0
        public void Update(){} // RVA: 0x7FFAC9C12930
        public void ATagOnPointerUp(){} // RVA: 0x7FFAC9C12B30
        public void ATagOnPointerOver(){} // RVA: 0x7FFAC30D5EF0
        public void ATagOnPointerMove(){} // RVA: 0x7FFAC9C12E40
        public void ATagOnPointerOut(){} // RVA: 0x7FFAC30D5EF0
        public void LinkTagOnPointerDown(){} // RVA: 0x7FFAC9C130E0
        public void LinkTagOnPointerUp(){} // RVA: 0x7FFAC9C13510
        public void LinkTagOnPointerMove(){} // RVA: 0x7FFAC9C13940
        public void LinkTagOnPointerOut(){} // RVA: 0x7FFAC9C14090
        public void HandleLinkTag(){} // RVA: 0x7FFAC9C141F0
        public void HandleATag(){} // RVA: 0x7FFAC9C14600
        public void GetTextOverflowMode(){} // RVA: 0x7FFAC9C14AB0
        public void ConvertUssToTextGenerationSettings(){} // RVA: 0x7FFAC9C14C10
        public void TextLibraryCanElide(){} // RVA: 0x7FFAC9C15480
        public void GetTextEffectPadding(){} // RVA: 0x7FFAC9C154D0
        public void .cctor(){} // RVA: 0x7FFAC9C157A0
    }

    public class UQuery : Object
    {
    }

    public class UQueryBuilder`1 : ValueType
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSelector> styleSelectors;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSelectorPart> parts;
        public UnityEngine.UIElements.VisualElement m_Element;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.RuleMatcher> m_Matchers;
        public 0x6B123AF8 m_Relationship;
        public int pseudoStatesMask;
        public int negatedPseudoStatesMask;

        // ── Methods ──
        public void get_styleSelectors(){} // RVA: 0x7FFAC2C58E90
        public void get_parts(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void Class(){} // RVA: 0x7FFAC2E8DC40
        public void Name(){} // RVA: 0x7FFAC2E8DC40
        public void SingleBaseType(){} // RVA: 0x7FFAC2E8DC40
        public void AddClass(){} // RVA: 0x7FFAC2C70A40
        public void AddName(){} // RVA: 0x7FFAC2C70A40
        public void AddPseudoStatesRuleIfNecessasy(){} // RVA: 0x7FFAC2C70980
        public void FinishSelector(){} // RVA: 0x7FFAC2C70980
        public void CurrentSelectorEmpty(){} // RVA: 0x7FFAC2C59D00
        public void FinishCurrentSelector(){} // RVA: 0x7FFAC2C70980
        public void Build(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
    }

    public class UQueryExtensions : Object
    {
        public UnityEngine.UIElements.UQueryState`1<UnityEngine.UIElements.VisualElement> SingleElementEmptyQuery;
        public UnityEngine.UIElements.UQueryState`1<UnityEngine.UIElements.VisualElement> SingleElementNameQuery; // 0x10
        public UnityEngine.UIElements.UQueryState`1<UnityEngine.UIElements.VisualElement> SingleElementClassQuery; // 0x20
        public UnityEngine.UIElements.UQueryState`1<UnityEngine.UIElements.VisualElement> SingleElementNameAndClassQuery; // 0x30
        public UnityEngine.UIElements.UQueryState`1<UnityEngine.UIElements.VisualElement> SingleElementTypeQuery; // 0x40
        public UnityEngine.UIElements.UQueryState`1<UnityEngine.UIElements.VisualElement> SingleElementTypeAndNameQuery; // 0x50
        public UnityEngine.UIElements.UQueryState`1<UnityEngine.UIElements.VisualElement> SingleElementTypeAndClassQuery; // 0x60
        public UnityEngine.UIElements.UQueryState`1<UnityEngine.UIElements.VisualElement> SingleElementTypeAndNameAndClassQuery; // 0x70

        // ── Methods ──
        public void Q(){} // RVA: 0x7FFAC9C24790 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9C24E60
    }

    public class UQueryState`1 : ValueType
    {
        public ActionQueryMatcher<T> s_Action;
        public UnityEngine.UIElements.VisualElement m_Element;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.RuleMatcher> m_Matchers;
        public ListQueryMatcher`1<T,T> s_List;
        public ListQueryMatcher`1<T,UnityEngine.UIElements.VisualElement> s_EnumerationList;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void RebuildOn(){} // RVA: 0x7FFAC2E8DC40
        public void Single(){} // RVA: 0x7FFAC2E8DC40
        public void First(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class UnsignedIntegerField : TextValueField`1
    {
        public string integerInput;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void get_integerInput(){} // RVA: 0x7FFAC9B67B40
        public void ValueToString(){} // RVA: 0x7FFAC9B67BD0
        public void StringToValue(){} // RVA: 0x7FFAC9B67DE0
        public void .ctor(){} // RVA: 0x7FFAC9B67F30 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFAC9B68230
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9B68300
        public void .cctor(){} // RVA: 0x7FFAC9B683F0
    }

    public class UnsignedLongField : TextValueField`1
    {
        public string unsignedLongInput;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void get_unsignedLongInput(){} // RVA: 0x7FFAC9B68D20
        public void ValueToString(){} // RVA: 0x7FFAC9B68DB0
        public void StringToValue(){} // RVA: 0x7FFAC9B68FC0
        public void .ctor(){} // RVA: 0x7FFAC9B690B0 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFAC9B693B0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9B69480
        public void .cctor(){} // RVA: 0x7FFAC9B69570
    }

    public class UxmlAsset : Object
    {
        public string fullTypeName; // 0x10
        public int id; // 0x18
        public int orderInDocument; // 0x1C
        public int parentId; // 0x20
        public System.Collections.Generic.List`1<string> m_Properties; // 0x28

        // ── Methods ──
        public void get_fullTypeName(){} // RVA: 0x7FFAC2F3C380
        public void get_id(){} // RVA: 0x7FFAC3157800
        public void get_orderInDocument(){} // RVA: 0x7FFAC44357F0
        public void get_parentId(){} // RVA: 0x7FFAC30DBBE0
        public void TryGetAttributeValue(){} // RVA: 0x7FFAC9C2B100
        public void SetAttribute(){} // RVA: 0x7FFAC9C2B2E0
        public void SetOrAddProperty(){} // RVA: 0x7FFAC9C2B2F0
    }

    public class UxmlAttributeDescription : Object
    {
        public string name; // 0x10
        public string[] obsoleteNames; // 0x18
        public string type; // 0x20
        public string typeNamespace; // 0x28
        public 0x6B125150 use; // 0x30
        public UnityEngine.UIElements.UxmlTypeRestriction restriction; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6D1E3D0
        public void get_name(){} // RVA: 0x7FFAC2F3C380
        public void set_name(){} // RVA: 0x7FFAC2F22E30
        public void set_obsoleteNames(){} // RVA: 0x7FFAC9C26F50
        public void set_type(){} // RVA: 0x7FFAC2F4F0D0
        public void set_typeNamespace(){} // RVA: 0x7FFAC2F22E90
        public void set_use(){} // RVA: 0x7FFAC2F7CCE0
        public void set_restriction(){} // RVA: 0x7FFAC31D0C20
        public void TryGetValueFromBagAsString(){} // RVA: 0x7FFAC9C27070
        public void TryGetValueFromBag(){} // RVA: 0x7FFAC2E8DC40
        public void GetValueFromBag(){} // RVA: 0x7FFAC2E8DC40
    }

    public class UxmlAttributeOverridesFactory : UxmlFactory`2
    {
        public object uxmlName;
        public object uxmlQualifiedName;

        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x7FFAC9C26C40
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFAC9C26C80
        public void Create(){} // RVA: 0x7FFAC67332B0
        public void .ctor(){} // RVA: 0x7FFAC9C26D00
    }

    public class UxmlAttributeOverridesTraits : UxmlTraits
    {
        public UnityEngine.UIElements.UxmlStringAttributeDescription m_ElementName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C26D50
    }

    public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C2A580
        public void GetValueFromBag(){} // RVA: 0x7FFAC9C2A710
        public void ConvertValueToBool(){} // RVA: 0x7FFAC9C2A940
    }

    public class UxmlDoubleAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C28570
        public void GetValueFromBag(){} // RVA: 0x7FFAC9C28700
        public void ConvertValueToDouble(){} // RVA: 0x7FFAC9C28940
    }

    public class UxmlEnumAttributeDescription`1 : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetValueFromBag(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetValueFromBag(){} // RVA: 0x7FFAC2E8DC40
        public void ConvertValueToEnum(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumNameErrorMessage(){} // RVA: 0x7FFAC2C58FF0
        public void GetEnumRangeErrorMessage(){} // RVA: 0x7FFAC2C58FF0
    }

    public class UxmlEnumeration : UxmlTypeRestriction
    {
        public System.Collections.Generic.List`1<string> values; // 0x10

        // ── Methods ──
        public void get_values(){} // RVA: 0x7FFAC5CC4750
        public void set_values(){} // RVA: 0x7FFAC9C2C1B0
        public void Equals(){} // RVA: 0x7FFAC9C2C2D0
        public void .ctor(){} // RVA: 0x7FFAC9C2C450
    }

    public class UxmlFactory`1 : UxmlFactory`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC6E55C30
        public void .ctor(){} // RVA: 0x7FFAC6E55CC0
    }

    public class UxmlFloatAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C27F00
        public void GetValueFromBag(){} // RVA: 0x7FFAC9C28090
        public void ConvertValueToFloat(){} // RVA: 0x7FFAC9C282D0
    }

    public class UxmlHash128AttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C2ABE0
        public void GetValueFromBag(){} // RVA: 0x7FFAC9C2AD70
    }

    public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C28BE0
        public void GetValueFromBag(){} // RVA: 0x7FFAC9C28D70
        public void TryGetValueFromBag(){} // RVA: 0x7FFAC9C28FA0
        public void ConvertValueToInt(){} // RVA: 0x7FFAC9C29190
    }

    public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C29F60
        public void GetValueFromBag(){} // RVA: 0x7FFAC9C2A0F0
        public void ConvertValueToLong(){} // RVA: 0x7FFAC9C2A320
    }

    public class UxmlObjectAsset : UxmlAsset
    {
    }

    public class UxmlObjectAttributeDescription`1 : Object
    {
        public System.Collections.Generic.List`1<T> defaultValue; // 0x10

        // ── Methods ──
        public void get_defaultValue(){} // RVA: 0x7FFAC2F3C380
        public void GetValueFromBag(){} // RVA: 0x7FFAC6E55CE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UxmlObjectFactoryRegistry : Object
    {
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<UnityEngine.UIElements.IBaseUxmlObjectFactory>> factories;

        // ── Methods ──
        public void get_factories(){} // RVA: 0x7FFAC9C2B580
        public void RegisterFactory(){} // RVA: 0x7FFAC9C2B6A0
        public void TryGetFactories(){} // RVA: 0x7FFAC9C2BA50
        public void RegisterEngineFactories(){} // RVA: 0x7FFAC9C2BAC0
        public void RegisterUserFactories(){} // RVA: 0x7FFAC9C2BDB0
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFAC2E5B230
        public void .ctor(){} // RVA: 0x7FFAC5C59B40
    }

    public class UxmlObjectListAttributeDescription`1 : UxmlObjectAttributeDescription`1
    {
        // ── Methods ──
        public void GetValueFromBag(){}
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC322C870
    }

    public class UxmlRootElementFactory : UxmlFactory`2
    {
        public object uxmlName;
        public object uxmlQualifiedName;

        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x7FFAC9C260E0
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFAC9C26120
        public void Create(){} // RVA: 0x7FFAC67332B0
        public void .ctor(){} // RVA: 0x7FFAC9C261A0
    }

    public class UxmlRootElementTraits : UxmlTraits
    {
        public UnityEngine.UIElements.UxmlStringAttributeDescription m_Name; // 0x18
        public UnityEngine.UIElements.UxmlStringAttributeDescription m_Class; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C261F0
    }

    public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C277A0
        public void GetValueFromBag(){} // RVA: 0x7FFAC9C27990
        public void TryGetValueFromBag(){} // RVA: 0x7FFAC9C27BC0
    }

    public class UxmlStyleFactory : UxmlFactory`2
    {
        public object uxmlName;
        public object uxmlQualifiedName;

        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x7FFAC9C26410
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFAC9C26450
        public void Create(){} // RVA: 0x7FFAC67332B0
        public void .ctor(){} // RVA: 0x7FFAC9C264D0
    }

    public class UxmlStyleTraits : UxmlTraits
    {
        public UnityEngine.UIElements.UxmlStringAttributeDescription m_Name; // 0x18
        public UnityEngine.UIElements.UxmlStringAttributeDescription m_Path; // 0x20
        public UnityEngine.UIElements.UxmlStringAttributeDescription m_Src; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C26520
    }

    public class UxmlTemplateFactory : UxmlFactory`2
    {
        public object uxmlName;
        public object uxmlQualifiedName;

        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x7FFAC9C26820
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFAC9C26860
        public void Create(){} // RVA: 0x7FFAC67332B0
        public void .ctor(){} // RVA: 0x7FFAC9C268E0
    }

    public class UxmlTemplateTraits : UxmlTraits
    {
        public UnityEngine.UIElements.UxmlStringAttributeDescription m_Name; // 0x18
        public UnityEngine.UIElements.UxmlStringAttributeDescription m_Path; // 0x20
        public UnityEngine.UIElements.UxmlStringAttributeDescription m_Src; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C26930
    }

    public class UxmlTraits : BaseUxmlTraits
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC322C870
    }

    public class UxmlTypeAttributeDescription`1 : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetValueFromBag(){}
        public void ConvertValueToType(){} // RVA: 0x7FFAC2C6A6F0
        public void <GetValueFromBag>b__3_0(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class UxmlTypeRestriction : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC98F6CE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UxmlUnsignedIntAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C29320
        public void GetValueFromBag(){} // RVA: 0x7FFAC9C294B0
        public void ConvertValueToUInt(){} // RVA: 0x7FFAC9C296E0
    }

    public class UxmlUnsignedLongAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C29940
        public void GetValueFromBag(){} // RVA: 0x7FFAC9C29AD0
        public void ConvertValueToUlong(){} // RVA: 0x7FFAC9C29D00
    }

}