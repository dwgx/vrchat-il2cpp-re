// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 100
// Methods: 437

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class UIDocument : MonoBehaviour
    {
        // ── Methods ──
        public void get_panelSettings(){} // RVA: 0x7AEF244A0
        public void set_panelSettings(){} // RVA: 0x7AF1E2A60
        public void get_parentUI(){} // RVA: 0x7A8292C30
        public void set_parentUI(){} // RVA: 0x7A8296DE0
        public void get_visualTreeAsset(){} // RVA: 0x7AEF67190
        public void set_visualTreeAsset(){} // RVA: 0x7AF1E31A0
        public void get_rootVisualElement(){} // RVA: 0x7AEF67200
        public void get_firstChildInserIndex(){} // RVA: 0x7A83562E0
        public void get_sortingOrder(){} // RVA: 0x7A8100280
        public void set_sortingOrder(){} // RVA: 0x7AF1E3200
        public void ApplySortingOrder(){} // RVA: 0x7AF1E3220
        public void .ctor(){} // RVA: 0x7AF1E3230
        public void Awake(){} // RVA: 0x7AF1E33C0
        public void OnEnable(){} // RVA: 0x7AF1E33D0
        public void SetupFromHierarchy(){} // RVA: 0x7AF1E35C0
        public void FindUIDocumentParent(){} // RVA: 0x7AF1E38C0
        public void Reset(){} // RVA: 0x7AF1E3A60
        public void AddChildAndInsertContentToVisualTree(){} // RVA: 0x7AF1E3D00
        public void RemoveChild(){} // RVA: 0x7AF1E3E40
        public void RecreateUI(){} // RVA: 0x7AF1E3EC0
        public void SetupRootClassList(){} // RVA: 0x7AF1E4710
        public void AddRootVisualElementToTree(){} // RVA: 0x7AF1E4830
        public void RemoveFromHierarchy(){} // RVA: 0x7AF1E4A20
        public void OnDisable(){} // RVA: 0x7AF1E4C10
        public void OnTransformChildrenChanged(){} // RVA: 0x7AF1E4C80
        public void OnTransformParentChanged(){} // RVA: 0x7AF1E4F50
        public void ReactToHierarchyChanged(){} // RVA: 0x7AF1E4F60
    }

    public class UIDocumentList : Object
    {
        // ── Methods ──
        public void RemoveFromListAndFromVisualTree(){} // RVA: 0x7AF1E2540
        public void AddToListAndToVisualTree(){} // RVA: 0x7AF1E25B0
        public void .ctor(){} // RVA: 0x7AF1E29A0
    }

    public class UIDocument[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class UIElementsBridge : Object
    {
        // ── Methods ──
        public void SetWantsMouseJumping(){} // RVA: 0x7A7E189D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UIElementsPackageUtility : Object
    {
        // ── Methods ──
        public void get_IsUIEPackageLoaded(){} // RVA: 0x7AF263FC0
        public void set_IsUIEPackageLoaded(){} // RVA: 0x7AF264020
        public void get_EditorResourcesBasePath(){} // RVA: 0x7AF264080
        public void set_EditorResourcesBasePath(){} // RVA: 0x7AF2640E0
        public void .cctor(){} // RVA: 0x7AF2641A0
        public void Refresh(){} // RVA: 0x7AF2641A0
    }

    public class UIElementsRuntimeUtility : Object
    {
        // ── Methods ──
        public void add_onCreatePanel(){} // RVA: 0x7AF2642F0
        public void remove_onCreatePanel(){} // RVA: 0x7AF264450
        public void .cctor(){} // RVA: 0x7AF2645B0
        public void CreateEvent(){} // RVA: 0x7AF264CB0
        public void FindOrCreateRuntimePanel(){} // RVA: 0x7AF264D60
        public void DisposeRuntimePanel(){} // RVA: 0x7AF264F90
        public void RegisterCachedPanelInternal(){} // RVA: 0x7AF2652A0
        public void RemoveCachedPanelInternal(){} // RVA: 0x7AF2655A0
        public void RepaintOffscreenPanels(){} // RVA: 0x7AF265800
        public void RepaintOverlayPanel(){} // RVA: 0x7AF265AD0
        public void BeginRenderOverlays(){} // RVA: 0x7AF265D50
        public void RenderOverlaysBeforePriority(){} // RVA: 0x7AF265DB0
        public void EndRenderOverlays(){} // RVA: 0x7AF265FC0
        public void get_activeEventSystem(){} // RVA: 0x7AF266030
        public void set_activeEventSystem(){} // RVA: 0x7AF266090
        public void get_useDefaultEventSystem(){} // RVA: 0x7AF266150
        public void RegisterEventSystem(){} // RVA: 0x7AF266290
        public void UnregisterEventSystem(){} // RVA: 0x7AF2665B0
        public void get_defaultEventSystem(){} // RVA: 0x7AF266750
        public void UpdateRuntimePanels(){} // RVA: 0x7AF266860
        public void MarkPotentiallyEmpty(){} // RVA: 0x7AF266C30
        public void RemoveUnusedPanels(){} // RVA: 0x7AF266D90
        public void RegisterPlayerloopCallback(){} // RVA: 0x7AF266FD0
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7AF2670F0
        public void SetPanelOrderingDirty(){} // RVA: 0x7AF2671C0
        public void GetSortedPlayerPanels(){} // RVA: 0x7AF267220
        public void SortPanels(){} // RVA: 0x7AF2672C0
        public void MultiDisplayBottomLeftToPanelPosition(){} // RVA: 0x7AF267670
        public void MultiDisplayToLocalScreenPosition(){} // RVA: 0x7AF267800
        public void ScreenBottomLeftToPanelPosition(){} // RVA: 0x7AF2679C0
        public void ScreenBottomLeftToPanelDelta(){} // RVA: 0x7AF267AE0
    }

    public class UIElementsRuntimeUtilityNative : Object
    {
        // ── Methods ──
        public void RepaintOverlayPanels(){} // RVA: 0x7AF1EDCB0
        public void UpdateRuntimePanels(){} // RVA: 0x7AF1EDD10
        public void RepaintOffscreenPanels(){} // RVA: 0x7AF1EDD70
        public void RegisterPlayerloopCallback(){} // RVA: 0x7AF1EDDD0
        public void UnregisterPlayerloopCallback(){} // RVA: 0x7AF1EDE20
        public void VisualElementCreation(){} // RVA: 0x7AF1EDE70
    }

    public class UIElementsRuntimeUtilityNative[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class UIElementsUtility : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF2695A0
        public void UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7AF269660
        public void UnityEngine.UIElements.IUIElementsUtility.TakeCapture(){} // RVA: 0x7AF269750
        public void UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture(){} // RVA: 0x7AA57AB40
        public void UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(){} // RVA: 0x7AF269820
        public void UnityEngine.UIElements.IUIElementsUtility.CleanupRoots(){} // RVA: 0x7AF269970
        public void UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(){} // RVA: 0x7AF269B10
        public void RegisterCachedPanel(){} // RVA: 0x7AF269C00
        public void RemoveCachedPanel(){} // RVA: 0x7AF269CB0
        public void TryGetPanel(){} // RVA: 0x7AF269D40
        public void BeginContainerGUI(){} // RVA: 0x7AF269DE0
        public void EndContainerGUI(){} // RVA: 0x7AF26A3C0
        public void CreateEvent(){} // RVA: 0x7AF26A7B0
        public void DoDispatch(){} // RVA: 0x7AF26AD40
        public void GetAllPanels(){} // RVA: 0x7AF26B5A0
        public void GetPanelsIterator(){} // RVA: 0x7AF26B6F0
        public void PixelsPerUnitScaleForElement(){} // RVA: 0x7AF26B820
        public void ParseMenuName(){} // RVA: 0x7AF26B9A0
        public void .cctor(){} // RVA: 0x7AF26BB90
    }

    public class UIEventRegistration : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF267DB0
        public void RegisterUIElementSystem(){} // RVA: 0x7AF268750
        public void TakeCapture(){} // RVA: 0x7AF2687E0
        public void ReleaseCapture(){} // RVA: 0x7AF268990
        public void EndContainerGUIFromException(){} // RVA: 0x7AF268B40
        public void ProcessEvent(){} // RVA: 0x7AF268D40
        public void CleanupRoots(){} // RVA: 0x7AF268FB0
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7AF269160
    }

    public class UIPainter2D : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AF1ED5D0
        public void Destroy(){} // RVA: 0x7AF1ED630
        public void Reset(){} // RVA: 0x7AF1ED680
    }

    public class UIRAtlasAllocator : Object
    {
        // ── Methods ──
        public void get_maxAtlasSize(){} // RVA: 0x7A8124910
        public void get_maxImageWidth(){} // RVA: 0x7A8668BC0
        public void get_maxImageHeight(){} // RVA: 0x7A83782A0
        public void get_virtualWidth(){} // RVA: 0x7A9739200
        public void set_virtualWidth(){} // RVA: 0x7A9746990
        public void get_virtualHeight(){} // RVA: 0x7A851DB90
        public void set_virtualHeight(){} // RVA: 0x7A8738180
        public void get_physicalWidth(){} // RVA: 0x7A8AB15F0
        public void set_physicalWidth(){} // RVA: 0x7A94794D0
        public void get_physicalHeight(){} // RVA: 0x7A854FDE0
        public void set_physicalHeight(){} // RVA: 0x7A8810F60
        public void get_disposed(){} // RVA: 0x7A818F850
        public void set_disposed(){} // RVA: 0x7A818F860
        public void Dispose(){} // RVA: 0x7AF1F5910
        public void GetLog2OfNextPower(){} // RVA: 0x7AF1F5AF0
        public void .ctor(){} // RVA: 0x7AF1F5B60
        public void TryAllocate(){} // RVA: 0x7AF1F5F20
        public void TryPartitionArea(){} // RVA: 0x7AF1F6270
        public void BuildAreas(){} // RVA: 0x7AF1F6680
        public void .cctor(){} // RVA: 0x7AF1F6760
    }

    public class UIRLayoutUpdater : BaseVisualTreeUpdater
    {
        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7AF2109A0
        public void OnVersionChanged(){} // RVA: 0x7AF210A00
        public void Update(){} // RVA: 0x7AF210A50
        public void UpdateSubTree(){} // RVA: 0x7AF210E30
        public void DispatchChangeEvents(){} // RVA: 0x7AF211820
        public void .ctor(){} // RVA: 0x7AF211B80
        public void .cctor(){} // RVA: 0x7AF211C40
    }

    public class UIRRepaintUpdater : BaseVisualTreeUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF215BC0
        public void get_profilerMarker(){} // RVA: 0x7AF215D30
        public void get_drawStats(){} // RVA: 0x7A80FD690
        public void get_breakBatches(){} // RVA: 0x7A80FD6B0
        public void OnVersionChanged(){} // RVA: 0x7AF215D90
        public void Update(){} // RVA: 0x7AF216160
        public void CreateRenderChain(){} // RVA: 0x7AF2163E0
        public void .cctor(){} // RVA: 0x7AF216440
        public void OnGraphicsResourcesRecreate(){} // RVA: 0x7AF216740
        public void OnPanelChanged(){} // RVA: 0x7AF216A50
        public void AttachToPanel(){} // RVA: 0x7AF216A70
        public void DetachFromPanel(){} // RVA: 0x7AF216FB0
        public void InitRenderChain(){} // RVA: 0x7AF2174D0
        public void DestroyRenderChain(){} // RVA: 0x7AF2175D0
        public void OnPanelAtlasChanged(){} // RVA: 0x7AF2176E0
        public void OnPanelHierarchyChanged(){} // RVA: 0x7AF2176F0
        public void OnPanelStandardShaderChanged(){} // RVA: 0x7AF217760
        public void OnPanelStandardWorldSpaceShaderChanged(){} // RVA: 0x7AF217A30
        public void ResetAllElementsDataRecursive(){} // RVA: 0x7AF217D00
        public void get_disposed(){} // RVA: 0x7AB9DF6A0
        public void set_disposed(){} // RVA: 0x7AD8AFA40
        public void Dispose(){} // RVA: 0x7AF217E30
    }

    public class UIRUtility : Object
    {
        // ── Methods ──
        public void ShapeWindingIsClockwise(){} // RVA: 0x7AF219420
        public void IsRoundRect(){} // RVA: 0x7AF2194A0
        public void IsVectorImageBackground(){} // RVA: 0x7AF219570
        public void IsElementSelfHidden(){} // RVA: 0x7AF2196A0
        public void Destroy(){} // RVA: 0x7AF219700
        public void GetPrevPow2(){} // RVA: 0x7AF219870
        public void GetNextPow2(){} // RVA: 0x7AF219890
        public void GetNextPow2Exp(){} // RVA: 0x7AF2198B0
        public void .cctor(){} // RVA: 0x7AF2198D0
    }

    public class UITKTextHandle : TextHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF25A3A0
        public void get_MeasuredSizes(){} // RVA: 0x7A92A8950
        public void set_MeasuredSizes(){} // RVA: 0x7A82C26E0
        public void get_RoundedSizes(){} // RVA: 0x7AF25A590
        public void set_RoundedSizes(){} // RVA: 0x7A82C0820
        public void ComputeTextWidth(){} // RVA: 0x7AF25A5B0
        public void ComputeTextHeight(){} // RVA: 0x7AF25A720
        public void Update(){} // RVA: 0x7AF25A870
        public void ATagOnPointerUp(){} // RVA: 0x7AF25AA70
        public void ATagOnPointerOver(){} // RVA: 0x7A828E5F0
        public void ATagOnPointerMove(){} // RVA: 0x7AF25AD70
        public void ATagOnPointerOut(){} // RVA: 0x7A828E5F0
        public void LinkTagOnPointerDown(){} // RVA: 0x7AF25B000
        public void LinkTagOnPointerUp(){} // RVA: 0x7AF25B430
        public void LinkTagOnPointerMove(){} // RVA: 0x7AF25B860
        public void LinkTagOnPointerOut(){} // RVA: 0x7AF25BFC0
        public void HandleLinkTag(){} // RVA: 0x7AF25C130
        public void HandleATag(){} // RVA: 0x7AF25C530
        public void GetTextOverflowMode(){} // RVA: 0x7AF25C9E0
        public void ConvertUssToTextGenerationSettings(){} // RVA: 0x7AF25CB40
        public void TextLibraryCanElide(){} // RVA: 0x7AF25D3B0
        public void GetTextEffectPadding(){} // RVA: 0x7AF25D400
        public void .cctor(){} // RVA: 0x7AF25D6D0
    }

    public class UQueryBuilder`1 : ValueType
    {
        // ── Methods ──
        public void get_styleSelectors(){} // RVA: 0x7A7E00680
        public void get_parts(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A7E18800
        public void Class(){} // RVA: 0x7A8051B10
        public void Name(){} // RVA: 0x7A8051B10
        public void SingleBaseType(){} // RVA: 0x7A8051B10
        public void AddClass(){} // RVA: 0x7A7E18800
        public void AddName(){} // RVA: 0x7A7E18800
        public void AddPseudoStatesRuleIfNecessasy(){} // RVA: 0x7A7E18770
        public void FinishSelector(){} // RVA: 0x7A7E18770
        public void CurrentSelectorEmpty(){} // RVA: 0x7A7E01900
        public void FinishCurrentSelector(){} // RVA: 0x7A7E18770
        public void Build(){} // RVA: 0x7A8051B10
        public void Equals(){} // RVA: 0x7A7E019D0
        public void GetHashCode(){} // RVA: 0x7A7E00710
    }

    public class UQueryExtensions : Object
    {
        // ── Methods ──
        public void Q(){} // RVA: 0x7AF26C950
        public void .cctor(){} // RVA: 0x7AF26D020
    }

    public class UQueryState`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18890
        public void RebuildOn(){} // RVA: 0x7A8051B10
        public void Single(){} // RVA: 0x7A8051B10
        public void First(){} // RVA: 0x7A8051B10
        public void GetEnumerator(){} // RVA: 0x7A8051B10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void Equals(){} // RVA: 0x7A7E019D0
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class UnsignedIntegerField : TextValueField`1
    {
        // ── Methods ──
        public void get_integerInput(){} // RVA: 0x7AF1AF650
        public void ValueToString(){} // RVA: 0x7AF1AF6E0
        public void StringToValue(){} // RVA: 0x7AF1AF8F0
        public void .ctor(){} // RVA: 0x7AF1AFA40
        public void CanTryParse(){} // RVA: 0x7AF1AFD40
        public void ApplyInputDeviceDelta(){} // RVA: 0x7AF1AFE10
        public void .cctor(){} // RVA: 0x7AF1AFF00
    }

    public class UnsignedLongField : TextValueField`1
    {
        // ── Methods ──
        public void get_unsignedLongInput(){} // RVA: 0x7AF1B0830
        public void ValueToString(){} // RVA: 0x7AF1B08C0
        public void StringToValue(){} // RVA: 0x7AF1B0AD0
        public void .ctor(){} // RVA: 0x7AF1B0BC0
        public void CanTryParse(){} // RVA: 0x7AF1B0EC0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7AF1B0F90
        public void .cctor(){} // RVA: 0x7AF1B1080
    }

    public class UxmlAsset : Object
    {
        // ── Methods ──
        public void get_fullTypeName(){} // RVA: 0x7A80F2570
        public void get_id(){} // RVA: 0x7A83782A0
        public void get_orderInDocument(){} // RVA: 0x7A9739200
        public void get_parentId(){} // RVA: 0x7A851DB90
        public void TryGetAttributeValue(){} // RVA: 0x7AF2731F0
        public void SetAttribute(){} // RVA: 0x7AF2733D0
        public void SetOrAddProperty(){} // RVA: 0x7AF2733E0
    }

    public class UxmlAttributeDescription : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC257C20
        public void get_name(){} // RVA: 0x7A80F2570
        public void set_name(){} // RVA: 0x7A80D8E20
        public void set_obsoleteNames(){} // RVA: 0x7AF26F050
        public void set_type(){} // RVA: 0x7A81052D0
        public void set_typeNamespace(){} // RVA: 0x7A80D8E80
        public void set_use(){} // RVA: 0x7A8133110
        public void set_restriction(){} // RVA: 0x7A8296DE0
        public void TryGetValueFromBagAsString(){} // RVA: 0x7AF26F170
        public void TryGetValueFromBag(){} // RVA: 0x7A8051B10
        public void GetValueFromBag(){} // RVA: 0x7A8051B10
    }

    public class UxmlEnumAttributeDescription`1 : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18770
        public void GetValueFromBag(){} // RVA: 0x7A8051B10
        public void TryGetValueFromBag(){} // RVA: 0x7A8051B10
        public void ConvertValueToEnum(){} // RVA: 0x7A8051B10
        public void GetEnumNameErrorMessage(){} // RVA: 0x7A7E00C10
        public void GetEnumRangeErrorMessage(){} // RVA: 0x7A7E00C10
    }

    public class UxmlFactory`1 : UxmlFactory`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class UxmlFactory`1 : UxmlFactory`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC3D0F70
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A7E00BD0
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AC3D0FA0
        public void .ctor(){} // RVA: 0x7AC3D1030
    }

    public class UxmlObjectAttributeDescription`1 : Object
    {
        // ── Methods ──
        public void get_defaultValue(){} // RVA: 0x7A8051B10
        public void GetValueFromBag(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7A80804D0
        public void .ctor(){} // RVA: 0x7AB10B4F0
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7A80804D0
        public void .ctor(){} // RVA: 0x7AB10B4F0
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7A80804D0
        public void .ctor(){} // RVA: 0x7AB10B4F0
    }

    public class UxmlObjectFactory`2 : BaseUxmlFactory`2
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7A80804D0
        public void .ctor(){} // RVA: 0x7AB10B4F0
    }

    public class UxmlObjectListAttributeDescription`1 : UxmlObjectAttributeDescription`1
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x7A7E00BD0
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E1DDC0
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A847A240
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A847A240
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A847A240
    }

    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A847A240
    }

    public class UxmlRootElementFactory : UxmlFactory`2
    {
        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x7AF26E1E0
        public void get_uxmlQualifiedName(){} // RVA: 0x7AF26E220
        public void Create(){} // RVA: 0x7ABC0A600
        public void .ctor(){} // RVA: 0x7AF26E2A0
    }

    public class UxmlRootElementTraits : UxmlTraits
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF26E2F0
    }

    public class UxmlStyleFactory : UxmlFactory`2
    {
        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x7AF26E510
        public void get_uxmlQualifiedName(){} // RVA: 0x7AF26E550
        public void Create(){} // RVA: 0x7ABC0A600
        public void .ctor(){} // RVA: 0x7AF26E5D0
    }

    public class UxmlStyleTraits : UxmlTraits
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF26E620
    }

    public class UxmlTemplateFactory : UxmlFactory`2
    {
        // ── Methods ──
        public void get_uxmlName(){} // RVA: 0x7AF26E920
        public void get_uxmlQualifiedName(){} // RVA: 0x7AF26E960
        public void Create(){} // RVA: 0x7ABC0A600
        public void .ctor(){} // RVA: 0x7AF26E9E0
    }

    public class UxmlTemplateTraits : UxmlTraits
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF26EA30
    }

    public class UxmlTraits : BaseUxmlTraits
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A847A240
    }

    public class UxmlTypeAttributeDescription`1 : TypedUxmlAttributeDescription`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18770
        public void GetValueFromBag(){} // RVA: 0x7A7E00BD0
        public void ConvertValueToType(){} // RVA: 0x7A7E00BD0
        public void <GetValueFromBag>b__3_0(){} // RVA: 0x7A7E00BD0
    }

}