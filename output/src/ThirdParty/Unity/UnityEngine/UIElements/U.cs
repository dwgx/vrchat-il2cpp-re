// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 52
// Methods: 334

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class UIDocument : MonoBehaviour
    {
        public string k_RootStyleClassName;
        public string k_VisualElementNameSuffix;
        public int k_DefaultSortingOrder;
        public int s_CurrentUIDocumentCounter;
        public int m_UIDocumentCreationIndex; // 0x20
        public UnityEngine.UIElements.PanelSettings m_PanelSettings; // 0x28

        // ── Methods ──
        public void get_panelSettings(){} // RVA: 0x7FFE87C86200
        public void set_panelSettings(){} // RVA: 0x7FFE87F43B10
        public void get_parentUI(){} // RVA: 0x7FFE8143BA80
        public void set_parentUI(){} // RVA: 0x7FFE81437330
        public void get_visualTreeAsset(){} // RVA: 0x7FFE87CC8170
        public void set_visualTreeAsset(){} // RVA: 0x7FFE87F44220
        public void get_rootVisualElement(){} // RVA: 0x7FFE87CC81E0
        public void get_firstChildInserIndex(){} // RVA: 0x7FFE8139EA30
        public void get_sortingOrder(){} // RVA: 0x7FFE81124040
        public void set_sortingOrder(){} // RVA: 0x7FFE87F44280
        public void ApplySortingOrder(){} // RVA: 0x7FFE87F442A0
        public void .ctor(){} // RVA: 0x7FFE87F442B0
        public void Awake(){} // RVA: 0x7FFE87F44440
        public void OnEnable(){} // RVA: 0x7FFE87F44450
        public void SetupFromHierarchy(){} // RVA: 0x7FFE87F44650
        public void FindUIDocumentParent(){} // RVA: 0x7FFE87F44950
        public void Reset(){} // RVA: 0x7FFE87F44AF0
        public void AddChildAndInsertContentToVisualTree(){} // RVA: 0x7FFE87F44D90
        public void RemoveChild(){} // RVA: 0x7FFE87F44ED0
        public void RecreateUI(){} // RVA: 0x7FFE87F44F50
        public void SetupRootClassList(){} // RVA: 0x7FFE87F457A0
        public void AddRootVisualElementToTree(){} // RVA: 0x7FFE87F458C0
        public void RemoveFromHierarchy(){} // RVA: 0x7FFE87F45AB0
        public void OnDisable(){} // RVA: 0x7FFE87F45CA0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFE87F45D10
        public void OnTransformParentChanged(){} // RVA: 0x7FFE87F45FD0
        public void ReactToHierarchyChanged(){} // RVA: 0x7FFE87F45FE0
    }

    public class UIDocumentList : Object
    {
        // ── Methods ──
        public void RemoveFromListAndFromVisualTree(){} // RVA: 0x7FFE87F43600
        public void AddToListAndToVisualTree(){} // RVA: 0x7FFE87F43670
        public void .ctor(){} // RVA: 0x7FFE87F43A50
    }

    public class UIElementsBridge : Object
    {
        // ── Methods ──
        public void SetWantsMouseJumping(){} // RVA: 0x7FFE80E46530
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UIElementsPackageUtility : Object
    {
        public bool _isUIEPackageLoaded;
        public string _editorResourcesBasePath; // 0x8

        // ── Methods ──
        public void get_IsUIEPackageLoaded(){} // RVA: 0x7FFE87FC4710
        public void set_IsUIEPackageLoaded(){} // RVA: 0x7FFE87FC4770
        public void get_EditorResourcesBasePath(){} // RVA: 0x7FFE87FC47D0
        public void set_EditorResourcesBasePath(){} // RVA: 0x7FFE87FC4830
        public void .cctor(){} // RVA: 0x7FFE87FC48F0
        public void Refresh(){} // RVA: 0x7FFE87FC48F0
    }

    public class UIElementsRuntimeUtility : Object
    {
        public System.Action`1<UnityEngine.UIElements.BaseRuntimePanel> onCreatePanel;
        public bool s_RegisteredPlayerloopCallback; // 0x8
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Panel> s_SortedRuntimePanels; // 0x10

        // ── Methods ──
        public void add_onCreatePanel(){} // RVA: 0x7FFE87FC4A40
        public void remove_onCreatePanel(){} // RVA: 0x7FFE87FC4BA0
        public void .cctor(){} // RVA: 0x7FFE87FC4D00
        public void CreateEvent(){} // RVA: 0x7FFE87FC5400
        public void FindOrCreateRuntimePanel(){} // RVA: 0x7FFE87FC54B0
        public void DisposeRuntimePanel(){} // RVA: 0x7FFE87FC56F0
        public void RegisterCachedPanelInternal(){} // RVA: 0x7FFE87FC59F0
        public void RemoveCachedPanelInternal(){} // RVA: 0x7FFE87FC5D00
        public void RepaintOffscreenPanels(){} // RVA: 0x7FFE87FC5F60
        public void RepaintOverlayPanel(){} // RVA: 0x7FFE87FC6210
        public void BeginRenderOverlays(){} // RVA: 0x7FFE87FC6480
        public void RenderOverlaysBeforePriority(){} // RVA: 0x7FFE87FC64E0
        public void EndRenderOverlays(){} // RVA: 0x7FFE87FC6700
        public void get_activeEventSystem(){} // RVA: 0x7FFE87FC6770
        public void set_activeEventSystem(){} // RVA: 0x7FFE87FC67D0
        public void get_useDefaultEventSystem(){} // RVA: 0x7FFE87FC6890
        public void RegisterEventSystem(){} // RVA: 0x7FFE87FC69D0
        public void UnregisterEventSystem(){} // RVA: 0x7FFE87FC6CF0
        public void get_defaultEventSystem(){} // RVA: 0x7FFE87FC6E90
        public void UpdateRuntimePanels(){} // RVA: 0x7FFE87FC6FA0
        public void MarkPotentiallyEmpty(){} // RVA: 0x7FFE87FC7370
        public void RemoveUnusedPanels(){} // RVA: 0x7FFE87FC74D0
        public void RegisterPlayerloopCallback(){} // RVA: 0x7FFE87FC7700
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7FFE87FC7820
        public void SetPanelOrderingDirty(){} // RVA: 0x7FFE87FC78F0
        public void GetSortedPlayerPanels(){} // RVA: 0x7FFE87FC7950
        public void SortPanels(){} // RVA: 0x7FFE87FC79F0
        public void MultiDisplayBottomLeftToPanelPosition(){} // RVA: 0x7FFE87FC7DA0
        public void MultiDisplayToLocalScreenPosition(){} // RVA: 0x7FFE87FC7F30
        public void ScreenBottomLeftToPanelPosition(){} // RVA: 0x7FFE87FC80F0
        public void ScreenBottomLeftToPanelDelta(){} // RVA: 0x7FFE87FC8210
    }

    public class UIElementsRuntimeUtilityNative : Object
    {
        // ── Methods ──
        public void RepaintOverlayPanels(){} // RVA: 0x7FFE87F4EE00
        public void UpdateRuntimePanels(){} // RVA: 0x7FFE87F4EE60
        public void RepaintOffscreenPanels(){} // RVA: 0x7FFE87F4EEC0
        public void RegisterPlayerloopCallback(){} // RVA: 0x7FFE87F4EF20
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7FFE87F4EF70
        public void VisualElementCreation(){} // RVA: 0x7FFE87F4EFC0
    }

    public class UIElementsUtility : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FC9C60
        public void UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7FFE87FC9D20
        public void UnityEngine.UIElements.IUIElementsUtility.TakeCapture(){} // RVA: 0x7FFE87FC9E10
        public void UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture(){} // RVA: 0x7FFE834BA0A0
        public void UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(){} // RVA: 0x7FFE87FC9EE0
        public void UnityEngine.UIElements.IUIElementsUtility.CleanupRoots(){} // RVA: 0x7FFE87FCA030
        public void UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(){} // RVA: 0x7FFE87FCA1D0
        public void RegisterCachedPanel(){} // RVA: 0x7FFE87FCA2C0
        public void RemoveCachedPanel(){} // RVA: 0x7FFE87FCA370
        public void TryGetPanel(){} // RVA: 0x7FFE87FCA400
        public void BeginContainerGUI(){} // RVA: 0x7FFE87FCA4A0
        public void EndContainerGUI(){} // RVA: 0x7FFE87FCAA70
        public void CreateEvent(){} // RVA: 0x7FFE87FCAE60 | overloaded x2
        public void DoDispatch(){} // RVA: 0x7FFE87FCB3F0
        public void GetAllPanels(){} // RVA: 0x7FFE87FCBC40
        public void GetPanelsIterator(){} // RVA: 0x7FFE87FCBD90
        public void PixelsPerUnitScaleForElement(){} // RVA: 0x7FFE87FCBEC0
        public void ParseMenuName(){} // RVA: 0x7FFE87FCC050
        public void .cctor(){} // RVA: 0x7FFE87FCC240
    }

    public class UIEventRegistration : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87FC84E0
        public void RegisterUIElementSystem(){} // RVA: 0x7FFE87FC8E70
        public void TakeCapture(){} // RVA: 0x7FFE87FC8F00
        public void ReleaseCapture(){} // RVA: 0x7FFE87FC90A0
        public void EndContainerGUIFromException(){} // RVA: 0x7FFE87FC9240
        public void ProcessEvent(){} // RVA: 0x7FFE87FC9430
        public void CleanupRoots(){} // RVA: 0x7FFE87FC9690
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7FFE87FC9830
    }

    public class UIPainter2D : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87F4E720
        public void Destroy(){} // RVA: 0x7FFE87F4E780
        public void Reset(){} // RVA: 0x7FFE87F4E7D0
    }

    public class UIRAtlasAllocator : Object
    {
        public int _maxAtlasSize; // 0x10
        public int _maxImageWidth; // 0x14
        public int _maxImageHeight; // 0x18
        public int _virtualWidth; // 0x1C
        public int _virtualHeight; // 0x20
        public int _physicalWidth; // 0x24
        public int _physicalHeight; // 0x28
        public AreaNode m_FirstUnpartitionedArea; // 0x30

        // ── Methods ──
        public void get_maxAtlasSize(){} // RVA: 0x7FFE811485C0
        public void get_maxImageWidth(){} // RVA: 0x7FFE8164B230
        public void get_maxImageHeight(){} // RVA: 0x7FFE813DB630
        public void get_virtualWidth(){} // RVA: 0x7FFE82707EE0
        public void set_virtualWidth(){} // RVA: 0x7FFE82717690
        public void get_virtualHeight(){} // RVA: 0x7FFE8151D690
        public void set_virtualHeight(){} // RVA: 0x7FFE8170B670
        public void get_physicalWidth(){} // RVA: 0x7FFE81A56130
        public void set_physicalWidth(){} // RVA: 0x7FFE82447980
        public void get_physicalHeight(){} // RVA: 0x7FFE81549710
        public void set_physicalHeight(){} // RVA: 0x7FFE817E4800
        public void get_disposed(){} // RVA: 0x7FFE811B2D30
        public void set_disposed(){} // RVA: 0x7FFE811B2D40
        public void Dispose(){} // RVA: 0x7FFE87F56830 | overloaded x2
        public void GetLog2OfNextPower(){} // RVA: 0x7FFE87F56A10
        public void .ctor(){} // RVA: 0x7FFE87F56A80
        public void TryAllocate(){} // RVA: 0x7FFE87F56E40
        public void TryPartitionArea(){} // RVA: 0x7FFE87F57190
        public void BuildAreas(){} // RVA: 0x7FFE87F575B0
        public void .cctor(){} // RVA: 0x7FFE87F57690
    }

    public class UIRLayoutUpdater : BaseVisualTreeUpdater
    {
        public string s_Description;

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFE87F71760
        public void OnVersionChanged(){} // RVA: 0x7FFE87F717C0
        public void Update(){} // RVA: 0x7FFE87F71810
        public void UpdateSubTree(){} // RVA: 0x7FFE87F71C00
        public void DispatchChangeEvents(){} // RVA: 0x7FFE87F725D0
        public void .ctor(){} // RVA: 0x7FFE87F72920
        public void .cctor(){} // RVA: 0x7FFE87F729E0
    }

    public class UIRRepaintUpdater : BaseVisualTreeUpdater
    {
        public UnityEngine.UIElements.BaseVisualElementPanel attachedPanel; // 0x20
        public UnityEngine.UIElements.UIR.RenderChain renderChain; // 0x28
        public string s_Description;
        public Unity.Profiling.ProfilerMarker s_ProfilerMarker; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F76970
        public void get_profilerMarker(){} // RVA: 0x7FFE87F76AC0
        public void get_drawStats(){} // RVA: 0x7FFE81121450
        public void get_breakBatches(){} // RVA: 0x7FFE81121470
        public void OnVersionChanged(){} // RVA: 0x7FFE87F76B20
        public void Update(){} // RVA: 0x7FFE87F76EF0
        public void CreateRenderChain(){} // RVA: 0x7FFE87F77170
        public void .cctor(){} // RVA: 0x7FFE87F771D0
        public void OnGraphicsResourcesRecreate(){} // RVA: 0x7FFE87F774D0
        public void OnPanelChanged(){} // RVA: 0x7FFE87F777F0
        public void AttachToPanel(){} // RVA: 0x7FFE87F77810
        public void DetachFromPanel(){} // RVA: 0x7FFE87F77D50
        public void InitRenderChain(){} // RVA: 0x7FFE87F78270
        public void DestroyRenderChain(){} // RVA: 0x7FFE87F78370
        public void OnPanelAtlasChanged(){} // RVA: 0x7FFE87F78480
        public void OnPanelHierarchyChanged(){} // RVA: 0x7FFE87F78490
        public void OnPanelStandardShaderChanged(){} // RVA: 0x7FFE87F78500
        public void OnPanelStandardWorldSpaceShaderChanged(){} // RVA: 0x7FFE87F787D0
        public void ResetAllElementsDataRecursive(){} // RVA: 0x7FFE87F78AA0
        public void get_disposed(){} // RVA: 0x7FFE848700A0
        public void set_disposed(){} // RVA: 0x7FFE866032C0
        public void Dispose(){} // RVA: 0x7FFE87F78BD0
    }

    public class UIRUtility : Object
    {
        // ── Methods ──
        public void ShapeWindingIsClockwise(){} // RVA: 0x7FFE87F7A1B0
        public void IsRoundRect(){} // RVA: 0x7FFE87F7A230
        public void IsVectorImageBackground(){} // RVA: 0x7FFE87F7A300
        public void IsElementSelfHidden(){} // RVA: 0x7FFE87F7A430
        public void Destroy(){} // RVA: 0x7FFE87F7A490
        public void GetPrevPow2(){} // RVA: 0x7FFE87F7A600
        public void GetNextPow2(){} // RVA: 0x7FFE87F7A620
        public void GetNextPow2Exp(){} // RVA: 0x7FFE87F7A640
        public void .cctor(){} // RVA: 0x7FFE87F7A660
    }

    public class UITKTextHandle : TextHandle
    {
        public UnityEngine.Vector2 _measuredSizes; // 0x38
        public UnityEngine.Vector2 _roundedSizes; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FBACB0
        public void get_MeasuredSizes(){} // RVA: 0x7FFE822B97B0
        public void set_MeasuredSizes(){} // RVA: 0x7FFE81CDDAA0
        public void get_RoundedSizes(){} // RVA: 0x7FFE87FBAEA0
        public void set_RoundedSizes(){} // RVA: 0x7FFE84337900
        public void ComputeTextWidth(){} // RVA: 0x7FFE87FBAEC0
        public void ComputeTextHeight(){} // RVA: 0x7FFE87FBB030
        public void Update(){} // RVA: 0x7FFE87FBB180
        public void ATagOnPointerUp(){} // RVA: 0x7FFE87FBB380
        public void ATagOnPointerOver(){} // RVA: 0x7FFE812B1E10
        public void ATagOnPointerMove(){} // RVA: 0x7FFE87FBB690
        public void ATagOnPointerOut(){} // RVA: 0x7FFE812B1E10
        public void LinkTagOnPointerDown(){} // RVA: 0x7FFE87FBB930
        public void LinkTagOnPointerUp(){} // RVA: 0x7FFE87FBBD60
        public void LinkTagOnPointerMove(){} // RVA: 0x7FFE87FBC190
        public void LinkTagOnPointerOut(){} // RVA: 0x7FFE87FBC8E0
        public void HandleLinkTag(){} // RVA: 0x7FFE87FBCA40
        public void HandleATag(){} // RVA: 0x7FFE87FBCE50
        public void GetTextOverflowMode(){} // RVA: 0x7FFE87FBD300
        public void ConvertUssToTextGenerationSettings(){} // RVA: 0x7FFE87FBD460
        public void TextLibraryCanElide(){} // RVA: 0x7FFE87FBDCD0
        public void GetTextEffectPadding(){} // RVA: 0x7FFE87FBDD20
        public void .cctor(){} // RVA: 0x7FFE87FBDFF0
    }

    public class UQuery : Object
    {
    }

    public class UQueryBuilder`1 : ValueType
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSelector> m_StyleSelectors;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSelectorPart> m_Parts;

        // ── Methods ──
        public void get_styleSelectors(){} // RVA: 0x7FFE80E2E2E0
        public void get_parts(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Class(){} // RVA: 0x7FFE810A1420
        public void Name(){} // RVA: 0x7FFE810A1420
        public void SingleBaseType(){} // RVA: 0x7FFE810A1420
        public void AddClass(){} // RVA: 0x7FFE80E460A0
        public void AddName(){} // RVA: 0x7FFE80E460A0
        public void AddPseudoStatesRuleIfNecessasy(){} // RVA: 0x7FFE80E45FE0
        public void FinishSelector(){} // RVA: 0x7FFE80E45FE0
        public void CurrentSelectorEmpty(){} // RVA: 0x7FFE80E2F150
        public void FinishCurrentSelector(){} // RVA: 0x7FFE80E45FE0
        public void Build(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
    }

    public class UQueryExtensions : Object
    {
        // ── Methods ──
        public void Q(){} // RVA: 0x7FFE87FCCFE0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87FCD6B0
    }

    public class UQueryState`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void RebuildOn(){} // RVA: 0x7FFE810A1420
        public void Single(){} // RVA: 0x7FFE810A1420
        public void First(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class UnsignedIntegerField : TextValueField`1
    {
        public string ussClassName;

        // ── Methods ──
        public void get_integerInput(){} // RVA: 0x7FFE87F103E0
        public void ValueToString(){} // RVA: 0x7FFE87F10470
        public void StringToValue(){} // RVA: 0x7FFE87F10680
        public void .ctor(){} // RVA: 0x7FFE87F107D0 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFE87F10AD0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87F10BA0
        public void .cctor(){} // RVA: 0x7FFE87F10C90
    }

    public class UnsignedLongField : TextValueField`1
    {
        public string ussClassName;

        // ── Methods ──
        public void get_unsignedLongInput(){} // RVA: 0x7FFE87F115C0
        public void ValueToString(){} // RVA: 0x7FFE87F11650
        public void StringToValue(){} // RVA: 0x7FFE87F11860
        public void .ctor(){} // RVA: 0x7FFE87F11950 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFE87F11C50
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87F11D20
        public void .cctor(){} // RVA: 0x7FFE87F11E10
    }

    public class UxmlAsset : Object
    {
        public string m_FullTypeName; // 0x10
        public int m_Id; // 0x18
        public int m_OrderInDocument; // 0x1C
        public int m_ParentId; // 0x20

        // ── Methods ──
        public void get_fullTypeName(){} // RVA: 0x7FFE81116380
        public void get_id(){} // RVA: 0x7FFE813DB630
        public void get_orderInDocument(){} // RVA: 0x7FFE82707EE0
        public void get_parentId(){} // RVA: 0x7FFE8151D690
        public void TryGetAttributeValue(){} // RVA: 0x7FFE87FD3950
        public void SetAttribute(){} // RVA: 0x7FFE87FD3B30
        public void SetOrAddProperty(){} // RVA: 0x7FFE87FD3B40
    }

    public class UxmlAttributeDescription : Object
    {
        public string _name; // 0x10
        public string[] m_ObsoleteNames; // 0x18
        public string _type; // 0x20
        public string _typeNamespace; // 0x28
        public dFixup.Id _use; // 0x30
        public UnityEngine.UIElements.UxmlTypeRestriction _restriction; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE850A4920
        public void get_name(){} // RVA: 0x7FFE81116380
        public void set_name(){} // RVA: 0x7FFE810FCE30
        public void set_obsoleteNames(){} // RVA: 0x7FFE87FCF7A0
        public void set_type(){} // RVA: 0x7FFE811290D0
        public void set_typeNamespace(){} // RVA: 0x7FFE810FCE90
        public void set_use(){} // RVA: 0x7FFE81156CE0
        public void set_restriction(){} // RVA: 0x7FFE81437330
        public void TryGetValueFromBagAsString(){} // RVA: 0x7FFE87FCF8C0
        public void TryGetValueFromBag(){} // RVA: 0x7FFE810A1420
        public void GetValueFromBag(){} // RVA: 0x7FFE810A1420
    }

    public class UxmlAttributeOverridesFactory : UxmlFactory`2
    {
        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x7FFE87FCF490
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFE87FCF4D0
        public void Create(){} // RVA: 0x7FFE84A912C0
        public void .ctor(){} // RVA: 0x7FFE87FCF550
    }

    public class UxmlAttributeOverridesTraits : UxmlTraits
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FCF5A0
    }

    public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FD2DD0
        public void GetValueFromBag(){} // RVA: 0x7FFE87FD2F60
        public void ConvertValueToBool(){} // RVA: 0x7FFE87FD3190
    }

    public class UxmlDoubleAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FD0DC0
        public void GetValueFromBag(){} // RVA: 0x7FFE87FD0F50
        public void ConvertValueToDouble(){} // RVA: 0x7FFE87FD1190
    }

    public class UxmlEnumAttributeDescription`1 : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void GetValueFromBag(){} // RVA: 0x7FFE810A1420
        public void TryGetValueFromBag(){} // RVA: 0x7FFE810A1420
        public void ConvertValueToEnum(){} // RVA: 0x7FFE810A1420
        public void GetEnumNameErrorMessage(){} // RVA: 0x7FFE80E2E440
        public void GetEnumRangeErrorMessage(){} // RVA: 0x7FFE80E2E440
    }

    public class UxmlEnumeration : UxmlTypeRestriction
    {
        public System.Collections.Generic.List`1<string> m_Values; // 0x10

        // ── Methods ──
        public void get_values(){} // RVA: 0x7FFE84022BE0
        public void set_values(){} // RVA: 0x7FFE87FD4A00
        public void Equals(){} // RVA: 0x7FFE87FD4B20
        public void .ctor(){} // RVA: 0x7FFE87FD4CA0
    }

    public class UxmlFactory`1 : UxmlFactory`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE851E15D0
        public void .ctor(){} // RVA: 0x7FFE851E1660
    }

    public class UxmlFloatAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FD0750
        public void GetValueFromBag(){} // RVA: 0x7FFE87FD08E0
        public void ConvertValueToFloat(){} // RVA: 0x7FFE87FD0B20
    }

    public class UxmlHash128AttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FD3430
        public void GetValueFromBag(){} // RVA: 0x7FFE87FD35C0
    }

    public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FD1430
        public void GetValueFromBag(){} // RVA: 0x7FFE87FD15C0
        public void TryGetValueFromBag(){} // RVA: 0x7FFE87FD17F0
        public void ConvertValueToInt(){} // RVA: 0x7FFE87FD19E0
    }

    public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FD27B0
        public void GetValueFromBag(){} // RVA: 0x7FFE87FD2940
        public void ConvertValueToLong(){} // RVA: 0x7FFE87FD2B70
    }

    public class UxmlObjectAsset : UxmlAsset
    {
    }

    public class UxmlObjectAttributeDescription`1 : Object
    {
        public System.Collections.Generic.List`1<T> _defaultValue; // 0x10

        // ── Methods ──
        public void get_defaultValue(){} // RVA: 0x7FFE81116380
        public void GetValueFromBag(){} // RVA: 0x7FFE851E1680
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UxmlObjectFactoryRegistry : Object
    {
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<UnityEngine.UIElements.IBaseUxmlObjectFactory>> s_Factories;

        // ── Methods ──
        public void get_factories(){} // RVA: 0x7FFE87FD3DD0
        public void RegisterFactory(){} // RVA: 0x7FFE87FD3EF0
        public void TryGetFactories(){} // RVA: 0x7FFE87FD42A0
        public void RegisterEngineFactories(){} // RVA: 0x7FFE87FD4310
        public void RegisterUserFactories(){} // RVA: 0x7FFE87FD4600
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFE81081080
        public void .ctor(){} // RVA: 0x7FFE83F924A0
    }

    public class UxmlObjectListAttributeDescription`1 : UxmlObjectAttributeDescription`1
    {
        // ── Methods ──
        public void GetValueFromBag(){}
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE814B8390
    }

    public class UxmlRootElementFactory : UxmlFactory`2
    {
        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x7FFE87FCE930
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFE87FCE970
        public void Create(){} // RVA: 0x7FFE84A912C0
        public void .ctor(){} // RVA: 0x7FFE87FCE9F0
    }

    public class UxmlRootElementTraits : UxmlTraits
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FCEA40
    }

    public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FCFFF0
        public void GetValueFromBag(){} // RVA: 0x7FFE87FD01E0
        public void TryGetValueFromBag(){} // RVA: 0x7FFE87FD0410
    }

    public class UxmlStyleFactory : UxmlFactory`2
    {
        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x7FFE87FCEC60
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFE87FCECA0
        public void Create(){} // RVA: 0x7FFE84A912C0
        public void .ctor(){} // RVA: 0x7FFE87FCED20
    }

    public class UxmlStyleTraits : UxmlTraits
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FCED70
    }

    public class UxmlTemplateFactory : UxmlFactory`2
    {
        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x7FFE87FCF070
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFE87FCF0B0
        public void Create(){} // RVA: 0x7FFE84A912C0
        public void .ctor(){} // RVA: 0x7FFE87FCF130
    }

    public class UxmlTemplateTraits : UxmlTraits
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FCF180
    }

    public class UxmlTraits : BaseUxmlTraits
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE814B8390
    }

    public class UxmlTypeAttributeDescription`1 : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void GetValueFromBag(){}
        public void ConvertValueToType(){} // RVA: 0x7FFE80E3FC10
        public void <GetValueFromBag>b__3_0(){} // RVA: 0x7FFE80E3FC10
    }

    public class UxmlTypeRestriction : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87C9F580
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UxmlUnsignedIntAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FD1B70
        public void GetValueFromBag(){} // RVA: 0x7FFE87FD1D00
        public void ConvertValueToUInt(){} // RVA: 0x7FFE87FD1F30
    }

    public class UxmlUnsignedLongAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FD2190
        public void GetValueFromBag(){} // RVA: 0x7FFE87FD2320
        public void ConvertValueToUlong(){} // RVA: 0x7FFE87FD2550
    }

}