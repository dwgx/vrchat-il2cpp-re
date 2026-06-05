// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 100
// Methods: 420

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class UIDocument
    {
        // ── Methods ──
        public void get_panelSettings(){} // RVA: 0x7FFAF9BF5590
        public void set_panelSettings(){} // RVA: 0x7FFAF9EB3970
        public void get_parentUI(){} // RVA: 0x7FFAF2F476A0
        public void set_parentUI(){} // RVA: 0x7FFAF2F4B830
        public void get_visualTreeAsset(){} // RVA: 0x7FFAF9C37FD0
        public void set_visualTreeAsset(){} // RVA: 0x7FFAF9EB4080
        public void get_rootVisualElement(){} // RVA: 0x7FFAF9C38040
        public void get_firstChildInserIndex(){} // RVA: 0x7FFAF304CEC0
        public void get_sortingOrder(){} // RVA: 0x7FFAF2DB6040
        public void set_sortingOrder(){} // RVA: 0x7FFAF9EB40E0
        public void ApplySortingOrder(){} // RVA: 0x7FFAF9EB4100
        public void .ctor(){} // RVA: 0x7FFAF9EB4110
        public void Awake(){} // RVA: 0x7FFAF9EB42A0
        public void OnEnable(){} // RVA: 0x7FFAF9EB42B0
        public void SetupFromHierarchy(){} // RVA: 0x7FFAF9EB44B0
        public void FindUIDocumentParent(){} // RVA: 0x7FFAF9EB47B0
        public void Reset(){} // RVA: 0x7FFAF9EB4950
        public void AddChildAndInsertContentToVisualTree(){} // RVA: 0x7FFAF9EB4BF0
        public void RemoveChild(){} // RVA: 0x7FFAF9EB4D30
        public void RecreateUI(){} // RVA: 0x7FFAF9EB4DB0
        public void SetupRootClassList(){} // RVA: 0x7FFAF9EB5600
        public void AddRootVisualElementToTree(){} // RVA: 0x7FFAF9EB5720
        public void RemoveFromHierarchy(){} // RVA: 0x7FFAF9EB5910
        public void OnDisable(){} // RVA: 0x7FFAF9EB5B00
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAF9EB5B70
        public void OnTransformParentChanged(){} // RVA: 0x7FFAF9EB5E30
        public void ReactToHierarchyChanged(){} // RVA: 0x7FFAF9EB5E40
    }

    public class UIDocumentList
    {
        // ── Methods ──
        public void RemoveFromListAndFromVisualTree(){} // RVA: 0x7FFAF9EB3460
        public void AddToListAndToVisualTree(){} // RVA: 0x7FFAF9EB34D0
        public void .ctor(){} // RVA: 0x7FFAF9EB38B0
    }

    public class UIElementsBridge
    {
        // ── Methods ──
        public void SetWantsMouseJumping(){} // RVA: 0x7FFAF2AD4FA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UIElementsPackageUtility
    {
        // ── Methods ──
        public void get_IsUIEPackageLoaded(){} // RVA: 0x7FFAF9F34570
        public void set_IsUIEPackageLoaded(){} // RVA: 0x7FFAF9F345D0
        public void get_EditorResourcesBasePath(){} // RVA: 0x7FFAF9F34630
        public void set_EditorResourcesBasePath(){} // RVA: 0x7FFAF9F34690
        public void .cctor(){} // RVA: 0x7FFAF9F34750
        public void Refresh(){} // RVA: 0x7FFAF9F34750
    }

    public class UIElementsRuntimeUtility
    {
        // ── Methods ──
        public void add_onCreatePanel(){} // RVA: 0x7FFAF9F348A0
        public void remove_onCreatePanel(){} // RVA: 0x7FFAF9F34A00
        public void .cctor(){} // RVA: 0x7FFAF9F34B60
        public void CreateEvent(){} // RVA: 0x7FFAF9F35260
        public void FindOrCreateRuntimePanel(){} // RVA: 0x7FFAF9F35310
        public void DisposeRuntimePanel(){} // RVA: 0x7FFAF9F35550
        public void RegisterCachedPanelInternal(){} // RVA: 0x7FFAF9F35850
        public void RemoveCachedPanelInternal(){} // RVA: 0x7FFAF9F35B60
        public void RepaintOffscreenPanels(){} // RVA: 0x7FFAF9F35DC0
        public void RepaintOverlayPanel(){} // RVA: 0x7FFAF9F36070
        public void BeginRenderOverlays(){} // RVA: 0x7FFAF9F362E0
        public void RenderOverlaysBeforePriority(){} // RVA: 0x7FFAF9F36340
        public void EndRenderOverlays(){} // RVA: 0x7FFAF9F36560
        public void get_activeEventSystem(){} // RVA: 0x7FFAF9F365D0
        public void set_activeEventSystem(){} // RVA: 0x7FFAF9F36630
        public void get_useDefaultEventSystem(){} // RVA: 0x7FFAF9F366F0
        public void RegisterEventSystem(){} // RVA: 0x7FFAF9F36830
        public void UnregisterEventSystem(){} // RVA: 0x7FFAF9F36B50
        public void get_defaultEventSystem(){} // RVA: 0x7FFAF9F36CF0
        public void UpdateRuntimePanels(){} // RVA: 0x7FFAF9F36E00
        public void MarkPotentiallyEmpty(){} // RVA: 0x7FFAF9F371D0
        public void RemoveUnusedPanels(){} // RVA: 0x7FFAF9F37330
        public void RegisterPlayerloopCallback(){} // RVA: 0x7FFAF9F37560
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7FFAF9F37680
        public void SetPanelOrderingDirty(){} // RVA: 0x7FFAF9F37750
        public void GetSortedPlayerPanels(){} // RVA: 0x7FFAF9F377B0
        public void SortPanels(){} // RVA: 0x7FFAF9F37850
        public void MultiDisplayBottomLeftToPanelPosition(){} // RVA: 0x7FFAF9F37C00
        public void MultiDisplayToLocalScreenPosition(){} // RVA: 0x7FFAF9F37D90
        public void ScreenBottomLeftToPanelPosition(){} // RVA: 0x7FFAF9F37F50
        public void ScreenBottomLeftToPanelDelta(){} // RVA: 0x7FFAF9F38070
    }

    public class UIElementsRuntimeUtilityNative
    {
        // ── Methods ──
        public void RepaintOverlayPanels(){} // RVA: 0x7FFAF9EBEC60
        public void UpdateRuntimePanels(){} // RVA: 0x7FFAF9EBECC0
        public void RepaintOffscreenPanels(){} // RVA: 0x7FFAF9EBED20
        public void RegisterPlayerloopCallback(){} // RVA: 0x7FFAF9EBED80
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7FFAF9EBEDD0
        public void VisualElementCreation(){} // RVA: 0x7FFAF9EBEE20
    }

    public class UIElementsUtility
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9F39AC0
        public void UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7FFAF9F39B80
        public void UnityEngine.UIElements.IUIElementsUtility.TakeCapture(){} // RVA: 0x7FFAF9F39C70
        public void UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture(){} // RVA: 0x7FFAF52194F0
        public void UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(){} // RVA: 0x7FFAF9F39D40
        public void UnityEngine.UIElements.IUIElementsUtility.CleanupRoots(){} // RVA: 0x7FFAF9F39E90
        public void UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(){} // RVA: 0x7FFAF9F3A030
        public void RegisterCachedPanel(){} // RVA: 0x7FFAF9F3A120
        public void RemoveCachedPanel(){} // RVA: 0x7FFAF9F3A1D0
        public void TryGetPanel(){} // RVA: 0x7FFAF9F3A260
        public void BeginContainerGUI(){} // RVA: 0x7FFAF9F3A300
        public void EndContainerGUI(){} // RVA: 0x7FFAF9F3A8D0
        public void CreateEvent(){} // RVA: 0x7FFAF9F3ACC0 | overloaded x2
        public void DoDispatch(){} // RVA: 0x7FFAF9F3B250
        public void GetAllPanels(){} // RVA: 0x7FFAF9F3BAA0
        public void GetPanelsIterator(){} // RVA: 0x7FFAF9F3BBF0
        public void PixelsPerUnitScaleForElement(){} // RVA: 0x7FFAF9F3BD20
        public void ParseMenuName(){} // RVA: 0x7FFAF9F3BEB0
        public void .cctor(){} // RVA: 0x7FFAF9F3C0A0
    }

    public class UIEventRegistration
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF9F38340
        public void RegisterUIElementSystem(){} // RVA: 0x7FFAF9F38CD0
        public void TakeCapture(){} // RVA: 0x7FFAF9F38D60
        public void ReleaseCapture(){} // RVA: 0x7FFAF9F38F00
        public void EndContainerGUIFromException(){} // RVA: 0x7FFAF9F390A0
        public void ProcessEvent(){} // RVA: 0x7FFAF9F39290
        public void CleanupRoots(){} // RVA: 0x7FFAF9F394F0
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7FFAF9F39690
    }

    public class UIPainter2D
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9EBE580
        public void Destroy(){} // RVA: 0x7FFAF9EBE5E0
        public void Reset(){} // RVA: 0x7FFAF9EBE630
    }

    public class UIRAtlasAllocator
    {
        // ── Methods ──
        public void get_maxAtlasSize(){} // RVA: 0x7FFAF2DDA5C0
        public void get_maxImageWidth(){} // RVA: 0x7FFAF335BED0
        public void get_maxImageHeight(){} // RVA: 0x7FFAF306ED50
        public void get_virtualWidth(){} // RVA: 0x7FFAF442C3B0
        public void set_virtualWidth(){} // RVA: 0x7FFAF4439FD0
        public void get_virtualHeight(){} // RVA: 0x7FFAF3210030
        public void set_virtualHeight(){} // RVA: 0x7FFAF344E0D0
        public void get_physicalWidth(){} // RVA: 0x7FFAF379F5B0
        public void set_physicalWidth(){} // RVA: 0x7FFAF4191F00
        public void get_physicalHeight(){} // RVA: 0x7FFAF3241DC0
        public void set_physicalHeight(){} // RVA: 0x7FFAF3503440
        public void get_disposed(){} // RVA: 0x7FFAF2E44D30
        public void set_disposed(){} // RVA: 0x7FFAF2E44D40
        public void Dispose(){} // RVA: 0x7FFAF9EC6690 | overloaded x2
        public void GetLog2OfNextPower(){} // RVA: 0x7FFAF9EC6870
        public void .ctor(){} // RVA: 0x7FFAF9EC68E0
        public void TryAllocate(){} // RVA: 0x7FFAF9EC6CA0
        public void TryPartitionArea(){} // RVA: 0x7FFAF9EC6FF0
        public void BuildAreas(){} // RVA: 0x7FFAF9EC7410
        public void .cctor(){} // RVA: 0x7FFAF9EC74F0
    }

    public class UIRLayoutUpdater
    {
        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFAF9EE15C0
        public void OnVersionChanged(){} // RVA: 0x7FFAF9EE1620
        public void Update(){} // RVA: 0x7FFAF9EE1670
        public void UpdateSubTree(){} // RVA: 0x7FFAF9EE1A60
        public void DispatchChangeEvents(){} // RVA: 0x7FFAF9EE2430
        public void .ctor(){} // RVA: 0x7FFAF9EE2780
        public void .cctor(){} // RVA: 0x7FFAF9EE2840
    }

    public class UIRRepaintUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9EE67D0
        public void get_profilerMarker(){} // RVA: 0x7FFAF9EE6920
        public void get_drawStats(){} // RVA: 0x7FFAF2DB3450
        public void get_breakBatches(){} // RVA: 0x7FFAF2DB3470
        public void OnVersionChanged(){} // RVA: 0x7FFAF9EE6980
        public void Update(){} // RVA: 0x7FFAF9EE6D50
        public void CreateRenderChain(){} // RVA: 0x7FFAF9EE6FD0
        public void .cctor(){} // RVA: 0x7FFAF9EE7030
        public void OnGraphicsResourcesRecreate(){} // RVA: 0x7FFAF9EE7330
        public void OnPanelChanged(){} // RVA: 0x7FFAF9EE7650
        public void AttachToPanel(){} // RVA: 0x7FFAF9EE7670
        public void DetachFromPanel(){} // RVA: 0x7FFAF9EE7BB0
        public void InitRenderChain(){} // RVA: 0x7FFAF9EE80D0
        public void DestroyRenderChain(){} // RVA: 0x7FFAF9EE81D0
        public void OnPanelAtlasChanged(){} // RVA: 0x7FFAF9EE82E0
        public void OnPanelHierarchyChanged(){} // RVA: 0x7FFAF9EE82F0
        public void OnPanelStandardShaderChanged(){} // RVA: 0x7FFAF9EE8360
        public void OnPanelStandardWorldSpaceShaderChanged(){} // RVA: 0x7FFAF9EE8630
        public void ResetAllElementsDataRecursive(){} // RVA: 0x7FFAF9EE8900
        public void get_disposed(){} // RVA: 0x7FFAF6697520
        public void set_disposed(){} // RVA: 0x7FFAF8572490
        public void Dispose(){} // RVA: 0x7FFAF9EE8A30
    }

    public class UIRUtility
    {
        // ── Methods ──
        public void ShapeWindingIsClockwise(){} // RVA: 0x7FFAF9EEA010
        public void IsRoundRect(){} // RVA: 0x7FFAF9EEA090
        public void IsVectorImageBackground(){} // RVA: 0x7FFAF9EEA160
        public void IsElementSelfHidden(){} // RVA: 0x7FFAF9EEA290
        public void Destroy(){} // RVA: 0x7FFAF9EEA2F0
        public void GetPrevPow2(){} // RVA: 0x7FFAF9EEA460
        public void GetNextPow2(){} // RVA: 0x7FFAF9EEA480
        public void GetNextPow2Exp(){} // RVA: 0x7FFAF9EEA4A0
        public void .cctor(){} // RVA: 0x7FFAF9EEA4C0
    }

    public class UITKTextHandle
    {
        public object textInfo;
        public object layoutTextInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9F2AB10
        public void get_MeasuredSizes(){} // RVA: 0x7FFAF3FC4540
        public void set_MeasuredSizes(){} // RVA: 0x7FFAF3A001D0
        public void get_RoundedSizes(){} // RVA: 0x7FFAF9F2AD00
        public void set_RoundedSizes(){} // RVA: 0x7FFAF61637A0
        public void ComputeTextWidth(){} // RVA: 0x7FFAF9F2AD20
        public void ComputeTextHeight(){} // RVA: 0x7FFAF9F2AE90
        public void Update(){} // RVA: 0x7FFAF9F2AFE0
        public void ATagOnPointerUp(){} // RVA: 0x7FFAF9F2B1E0
        public void ATagOnPointerOver(){} // RVA: 0x7FFAF2F430B0
        public void ATagOnPointerMove(){} // RVA: 0x7FFAF9F2B4F0
        public void ATagOnPointerOut(){} // RVA: 0x7FFAF2F430B0
        public void LinkTagOnPointerDown(){} // RVA: 0x7FFAF9F2B790
        public void LinkTagOnPointerUp(){} // RVA: 0x7FFAF9F2BBC0
        public void LinkTagOnPointerMove(){} // RVA: 0x7FFAF9F2BFF0
        public void LinkTagOnPointerOut(){} // RVA: 0x7FFAF9F2C740
        public void HandleLinkTag(){} // RVA: 0x7FFAF9F2C8A0
        public void HandleATag(){} // RVA: 0x7FFAF9F2CCB0
        public void GetTextOverflowMode(){} // RVA: 0x7FFAF9F2D160
        public void ConvertUssToTextGenerationSettings(){} // RVA: 0x7FFAF9F2D2C0
        public void TextLibraryCanElide(){} // RVA: 0x7FFAF9F2DB30
        public void GetTextEffectPadding(){} // RVA: 0x7FFAF9F2DB80
        public void .cctor(){} // RVA: 0x7FFAF9F2DE50
    }

    public class UQuery
    {
    }

    public class UQueryBuilder`1
    {
        // ── Methods ──
        public void get_styleSelectors(){} // RVA: 0x7FFAF2ABCD60
        public void get_parts(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void Class(){} // RVA: 0x7FFAF2D33FA0
        public void Name(){} // RVA: 0x7FFAF2D33FA0
        public void SingleBaseType(){} // RVA: 0x7FFAF2D33FA0
        public void AddClass(){} // RVA: 0x7FFAF2AD4B10
        public void AddName(){} // RVA: 0x7FFAF2AD4B10
        public void AddPseudoStatesRuleIfNecessasy(){} // RVA: 0x7FFAF2AD4A50
        public void FinishSelector(){} // RVA: 0x7FFAF2AD4A50
        public void CurrentSelectorEmpty(){} // RVA: 0x7FFAF2ABDBE0
        public void FinishCurrentSelector(){} // RVA: 0x7FFAF2AD4A50
        public void Build(){} // RVA: 0x7FFAF2D33FA0
        public void Equals(){} // RVA: 0x7FFAF2ABDE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF2ABD840
    }

    public class UQueryExtensions
    {
        // ── Methods ──
        public void Q(){} // RVA: 0x7FFAF9F3CE40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF9F3D510
    }

    public class UQueryState`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2ADDC60
        public void RebuildOn(){} // RVA: 0x7FFAF2D33FA0
        public void Single(){} // RVA: 0x7FFAF2D33FA0
        public void First(){} // RVA: 0x7FFAF2D33FA0
        public void GetEnumerator(){} // RVA: 0x7FFAF2D33FA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void Equals(){} // RVA: 0x7FFAF2ABDE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF2ABD840
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
    }

    public class UQueryState`1
    {
    }

    public class UnsignedIntegerField
    {
        // ── Methods ──
        public void get_integerInput(){} // RVA: 0x7FFAF9E80240
        public void ValueToString(){} // RVA: 0x7FFAF9E802D0
        public void StringToValue(){} // RVA: 0x7FFAF9E804E0
        public void .ctor(){} // RVA: 0x7FFAF9E80630 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFAF9E80930
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAF9E80A00
        public void .cctor(){} // RVA: 0x7FFAF9E80AF0
    }

    public class UnsignedLongField
    {
        // ── Methods ──
        public void get_unsignedLongInput(){} // RVA: 0x7FFAF9E81420
        public void ValueToString(){} // RVA: 0x7FFAF9E814B0
        public void StringToValue(){} // RVA: 0x7FFAF9E816C0
        public void .ctor(){} // RVA: 0x7FFAF9E817B0 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFAF9E81AB0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAF9E81B80
        public void .cctor(){} // RVA: 0x7FFAF9E81C70
    }

    public class UxmlAsset
    {
        // ── Methods ──
        public void get_fullTypeName(){} // RVA: 0x7FFAF2DA8380
        public void get_id(){} // RVA: 0x7FFAF306ED50
        public void get_orderInDocument(){} // RVA: 0x7FFAF442C3B0
        public void get_parentId(){} // RVA: 0x7FFAF3210030
        public void TryGetAttributeValue(){} // RVA: 0x7FFAF9F437B0
        public void SetAttribute(){} // RVA: 0x7FFAF9F43990
        public void SetOrAddProperty(){} // RVA: 0x7FFAF9F439A0
    }

    public class UxmlAttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6F19AC0
        public void get_name(){} // RVA: 0x7FFAF2DA8380
        public void set_name(){} // RVA: 0x7FFAF2D8EE30
        public void set_obsoleteNames(){} // RVA: 0x7FFAF9F3F600
        public void set_type(){} // RVA: 0x7FFAF2DBB0D0
        public void set_typeNamespace(){} // RVA: 0x7FFAF2D8EE90
        public void set_use(){} // RVA: 0x7FFAF2DE8CE0
        public void set_restriction(){} // RVA: 0x7FFAF2F4B830
        public void TryGetValueFromBagAsString(){} // RVA: 0x7FFAF9F3F720
        public void TryGetValueFromBag(){} // RVA: 0x7FFAF2D33FA0
        public void GetValueFromBag(){} // RVA: 0x7FFAF2D33FA0
    }

    public class UxmlAttributeOverridesFactory
    {
        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x7FFAF9F3F2F0
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFAF9F3F330
        public void Create(){} // RVA: 0x7FFAF68BF620
        public void .ctor(){} // RVA: 0x7FFAF9F3F3B0
    }

    public class UxmlAttributeOverridesTraits
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9F3F400
    }

    public class UxmlBoolAttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9F42C30
        public void GetValueFromBag(){} // RVA: 0x7FFAF9F42DC0
        public void ConvertValueToBool(){} // RVA: 0x7FFAF9F42FF0
    }

    public class UxmlDoubleAttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9F40C20
        public void GetValueFromBag(){} // RVA: 0x7FFAF9F40DB0
        public void ConvertValueToDouble(){} // RVA: 0x7FFAF9F40FF0
    }

    public class UxmlEnumAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
        public void GetValueFromBag(){} // RVA: 0x7FFAF2D33FA0
        public void TryGetValueFromBag(){} // RVA: 0x7FFAF2D33FA0
        public void ConvertValueToEnum(){} // RVA: 0x7FFAF2D33FA0
        public void GetEnumNameErrorMessage(){} // RVA: 0x7FFAF2ABCEC0
        public void GetEnumRangeErrorMessage(){} // RVA: 0x7FFAF2ABCEC0
    }

    public class UxmlEnumeration
    {
        // ── Methods ──
        public void get_values(){} // RVA: 0x7FFAF5E66D40
        public void set_values(){} // RVA: 0x7FFAF9F44860
        public void Equals(){} // RVA: 0x7FFAF9F44980
        public void .ctor(){} // RVA: 0x7FFAF9F44B00
    }

    public class UxmlFactory`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class UxmlFactory`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF7093990
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){}
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF70939C0
        public void .ctor(){} // RVA: 0x7FFAF7093A50
    }

    public class UxmlFloatAttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9F405B0
        public void GetValueFromBag(){} // RVA: 0x7FFAF9F40740
        public void ConvertValueToFloat(){} // RVA: 0x7FFAF9F40980
    }

    public class UxmlHash128AttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9F43290
        public void GetValueFromBag(){} // RVA: 0x7FFAF9F43420
    }

    public class UxmlIntAttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9F41290
        public void GetValueFromBag(){} // RVA: 0x7FFAF9F41420
        public void TryGetValueFromBag(){} // RVA: 0x7FFAF9F41650
        public void ConvertValueToInt(){} // RVA: 0x7FFAF9F41840
    }

    public class UxmlLongAttributeDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9F42610
        public void GetValueFromBag(){} // RVA: 0x7FFAF9F427A0
        public void ConvertValueToLong(){} // RVA: 0x7FFAF9F429D0
    }

    public class UxmlObjectAsset
    {
    }

    public class UxmlObjectAttributeDescription`1
    {
        // ── Methods ──
        public void get_defaultValue(){} // RVA: 0x7FFAF2D33FA0
        public void GetValueFromBag(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class UxmlObjectAttributeDescription`1
    {
        // ── Methods ──
        public void get_defaultValue(){} // RVA: 0x7FFAF2DA8380
        public void GetValueFromBag(){} // RVA: 0x7FFAF7093A70
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UxmlObjectFactoryRegistry
    {
        // ── Methods ──
        public void get_factories(){} // RVA: 0x7FFAF9F43C30
        public void RegisterFactory(){} // RVA: 0x7FFAF9F43D50
        public void TryGetFactories(){} // RVA: 0x7FFAF9F44100
        public void RegisterEngineFactories(){} // RVA: 0x7FFAF9F44170
        public void RegisterUserFactories(){} // RVA: 0x7FFAF9F44460
    }

    public class UxmlObjectFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFAF2D13BC0
        public void .ctor(){} // RVA: 0x7FFAF5DC3940
    }

    public class UxmlObjectFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class UxmlObjectFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFAF2D13BC0
        public void .ctor(){} // RVA: 0x7FFAF5DC3940
    }

    public class UxmlObjectFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFAF2D13BC0
        public void .ctor(){} // RVA: 0x7FFAF5DC3940
    }

    public class UxmlObjectFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFAF2D13BC0
        public void .ctor(){} // RVA: 0x7FFAF5DC3940
    }

    public class UxmlObjectListAttributeDescription`1
    {
        // ── Methods ──
        public void GetValueFromBag(){}
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class UxmlObjectTraits`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF316D7E0
    }

}