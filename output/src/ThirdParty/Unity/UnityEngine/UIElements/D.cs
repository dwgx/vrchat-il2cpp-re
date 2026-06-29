// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 25
// Methods: 222

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class DefaultDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7AF1C58C0
        public void DispatchEvent(){} // RVA: 0x7AF1C5940
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DefaultDragAndDropClient : DragAndDropData
    {
        // ── Methods ──
        public void get_source(){} // RVA: 0x7AF1B72D0
        public void GetGenericData(){} // RVA: 0x7AF1B7320
        public void StartDrag(){} // RVA: 0x7AF1B7390
        public void UpdateDrag(){} // RVA: 0x7AF1B7B90
        public void AcceptDrag(){} // RVA: 0x7A80D7310
        public void SetVisualMode(){} // RVA: 0x7A8738180
        public void DragCleanup(){} // RVA: 0x7AF1B7D70
        public void get_data(){} // RVA: 0x7A97F8BA0
        public void .ctor(){} // RVA: 0x7AF1B7E10
    }

    public class DefaultEventSystem : Object
    {
        // ── Methods ──
        public void get_isAppFocused(){} // RVA: 0x7AF1B27E0
        public void get_input(){} // RVA: 0x7AF1B2860
        public void GetDefaultInput(){} // RVA: 0x7AF1B28D0
        public void ShouldIgnoreEventsOnAppNotFocused(){} // RVA: 0x7AF1B29A0
        public void get_focusedPanel(){} // RVA: 0x7A8178B90
        public void set_focusedPanel(){} // RVA: 0x7AF1B29F0
        public void Update(){} // RVA: 0x7AF1B2A80
        public void FocusBasedEventSequence(){} // RVA: 0x7AF1B2C30
        public void SendIMGUIEvents(){} // RVA: 0x7AF1B2C60
        public void ProcessMouseEvents(){} // RVA: 0x7AF1B34D0
        public void SendInputEvents(){} // RVA: 0x7AF1B3D70
        public void OnFocusEvent(){} // RVA: 0x7AF1B41A0
        public void SendFocusBasedEvent(){} // RVA: 0x7A8051B10
        public void SendPositionBasedEvent(){} // RVA: 0x7A8051B10
        public void UpdateFocusedPanel(){} // RVA: 0x7AF1B41B0
        public void MakeTouchEvent(){} // RVA: 0x7AF1B4250
        public void MakePenEvent(){} // RVA: 0x7AF1B4370
        public void ProcessTouchEvents(){} // RVA: 0x7AF1B4460
        public void ProcessPenEvents(){} // RVA: 0x7AF1B4A70
        public void GetRawMoveVector(){} // RVA: 0x7AF1B4EF0
        public void ShouldSendMoveFromInput(){} // RVA: 0x7AF1B5050
        public void ProcessTabEvent(){} // RVA: 0x7AF1B52E0
        public void .ctor(){} // RVA: 0x7AF1B5610
        public void .cctor(){} // RVA: 0x7AF1B5920
    }

    public class DefaultGroupManager : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A81052D0
        public void OnOptionSelectionChanged(){} // RVA: 0x7AF1E5D90
        public void RegisterOption(){} // RVA: 0x7AF1E6020
        public void UnregisterOption(){} // RVA: 0x7AF1E6150
        public void .ctor(){} // RVA: 0x7AF1E61E0
    }

    public class DefaultMultiColumnTreeViewController`1 : MultiColumnTreeViewController
    {
        // ── Methods ──
        public void get_treeDataController(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A7E1DDC0
        public void get_itemsSource(){} // RVA: 0x7A7E00680
        public void set_itemsSource(){} // RVA: 0x7A7E18800
        public void SetRootItems(){} // RVA: 0x7A7E18800
        public void GetItemForIndex(){} // RVA: 0x7A7E00740
        public void GetParentId(){} // RVA: 0x7A7E062A0
        public void HasChildren(){} // RVA: 0x7A7E01F00
        public void GetChildrenIds(){} // RVA: 0x7A7E00740
        public void Move(){} // RVA: 0x7A7E1AE40
        public void IsChildOf(){} // RVA: 0x7A7E01C20
        public void GetAllItemIds(){} // RVA: 0x7A7E00B20
    }

    public class DefaultTreeViewController`1 : TreeViewController
    {
        // ── Methods ──
        public void get_treeDataController(){} // RVA: 0x7A7E00680
        public void get_itemsSource(){} // RVA: 0x7A7E00680
        public void set_itemsSource(){} // RVA: 0x7A7E18800
        public void SetRootItems(){} // RVA: 0x7A7E18800
        public void GetItemForIndex(){} // RVA: 0x7A7E00740
        public void GetParentId(){} // RVA: 0x7A7E062A0
        public void HasChildren(){} // RVA: 0x7A7E01F00
        public void GetChildrenIds(){} // RVA: 0x7A7E00740
        public void Move(){} // RVA: 0x7A7E1AE40
        public void IsChildOf(){} // RVA: 0x7A7E01C20
        public void GetAllItemIds(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class DetachFromPanelEvent : PanelChangedEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1D3AD0
        public void .ctor(){} // RVA: 0x7AF1D3BC0
    }

    public class DisposeHelper : Object
    {
        // ── Methods ──
        public void NotifyDisposedUsed(){} // RVA: 0x7AF1B69D0
    }

    public class DoubleField : TextValueField`1
    {
        // ── Methods ──
        public void get_doubleInput(){} // RVA: 0x7AF0F43A0
        public void ValueToString(){} // RVA: 0x7AF0F4430
        public void StringToValue(){} // RVA: 0x7AF0F45F0
        public void .ctor(){} // RVA: 0x7AF0F46F0
        public void CanTryParse(){} // RVA: 0x7AF0F49F0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7AF0F4A80
        public void .cctor(){} // RVA: 0x7AF0F4B70
    }

    public class DragAndDropArgs : ValueType
    {
        // ── Methods ──
        public void set_target(){} // RVA: 0x7A7637E60
        public void get_insertAtIndex(){} // RVA: 0x7A75FEFA0
        public void set_insertAtIndex(){} // RVA: 0x7A767FBC0
        public void get_parentId(){} // RVA: 0x7A767FBD0
        public void set_parentId(){} // RVA: 0x7A767FBE0
        public void get_childIndex(){} // RVA: 0x7A7677B20
        public void set_childIndex(){} // RVA: 0x7A7677B10
        public void get_dragAndDropPosition(){} // RVA: 0x7A7699630
        public void set_dragAndDropPosition(){} // RVA: 0x7A7699640
        public void get_dragAndDropData(){} // RVA: 0x7A767FF40
        public void set_dragAndDropData(){} // RVA: 0x7A767FF60
    }

    public class DragAndDropData : Object
    {
        // ── Methods ──
        public void GetGenericData(){} // RVA: 0x7A7E00B20
        public void get_source(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DragAndDropUtility : Object
    {
        // ── Methods ──
        public void GetDragAndDrop(){} // RVA: 0x7AF1B70D0
    }

    public class DragEventsProcessor : Object
    {
        // ── Methods ──
        public void get_supportsDragEvents(){} // RVA: 0x7A81BD750
        public void get_useDragEvents(){} // RVA: 0x7AF1B7EC0
        public void get_dragAndDrop(){} // RVA: 0x7AF1B7F20
        public void get_isEditorContext(){} // RVA: 0x7AF1B7F50
        public void .ctor(){} // RVA: 0x7AF1B8030
        public void RegisterCallbacksFromTarget(){} // RVA: 0x7AF1B81C0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7AF1B84F0
        public void CanStartDrag(){} // RVA: 0x7A7E019D0
        public void StartDrag(){} // RVA: 0x7A7E00560
        public void UpdateDrag(){} // RVA: 0x7A7E18800
        public void OnDrop(){} // RVA: 0x7A7E18800
        public void ClearDragAndDropUI(){} // RVA: 0x7A7E18C30
        public void OnPointerDownEvent(){} // RVA: 0x7AF1B8950
        public void OnPointerUpEvent(){} // RVA: 0x7AF1B8A70
        public void OnPointerLeaveEvent(){} // RVA: 0x7AF1B8C60
        public void OnPointerCancelEvent(){} // RVA: 0x7AF1B8C80
        public void OnPointerCapturedOut(){} // RVA: 0x7AF1B8D90
        public void OnPointerMoveEvent(){} // RVA: 0x7AF1B8E70
        public void GetDropTarget(){} // RVA: 0x7AF1B9290
    }

    public class DropdownField : PopupField`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF0F5410
    }

    public class DropdownMenu : Object
    {
        // ── Methods ──
        public void MenuItems(){} // RVA: 0x7AB1AC740
        public void AppendAction(){} // RVA: 0x7AF1C1FA0
        public void AppendSeparator(){} // RVA: 0x7AF1C20D0
        public void InsertSeparator(){} // RVA: 0x7AF1C2280
        public void PrepareForDisplay(){} // RVA: 0x7AF1C2440
        public void .ctor(){} // RVA: 0x7AF1C2910
    }

    public class DropdownMenuAction : DropdownMenuItem
    {
        // ── Methods ──
        public void set_status(){} // RVA: 0x7A84385B0
        public void set_eventInfo(){} // RVA: 0x7A81052D0
        public void set_userData(){} // RVA: 0x7A80D8E80
        public void AlwaysEnabled(){} // RVA: 0x7AF1C1BC0
        public void AlwaysDisabled(){} // RVA: 0x7AF1C1BD0
        public void .ctor(){} // RVA: 0x7AF1C1BE0
        public void UpdateActionStatus(){} // RVA: 0x7AF1C1D30
    }

    public class DropdownMenuEventInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF1C1A20
    }

    public class DropdownMenuItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DropdownMenuSeparator : DropdownMenuItem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class DropdownUtility : Object
    {
        // ── Methods ──
        public void CreateDropdown(){} // RVA: 0x7AF1C29D0
    }

    public class DynamicAtlas : AtlasBase
    {
        // ── Methods ──
        public void get_isInitialized(){} // RVA: 0x7AF0C3FC0
        public void OnAssignedToPanel(){} // RVA: 0x7AF0C3FE0
        public void OnRemovedFromPanel(){} // RVA: 0x7AF0C40E0
        public void Reset(){} // RVA: 0x7AF0C4180
        public void InitPages(){} // RVA: 0x7AF0C4270
        public void DestroyPages(){} // RVA: 0x7AF0C4520
        public void TryGetAtlas(){} // RVA: 0x7AF0C4640
        public void ReturnAtlas(){} // RVA: 0x7AF0C4B50
        public void OnUpdateDynamicTextures(){} // RVA: 0x7AF0C4E40
        public void IsTextureFormatSupported(){} // RVA: 0x7AF0C4EC0
        public void IsTextureValid(){} // RVA: 0x7AF0C4F50
        public void set_minAtlasSize(){} // RVA: 0x7AF0C5150
        public void set_maxAtlasSize(){} // RVA: 0x7AF0C5170
        public void get_defaultFilters(){} // RVA: 0x7AE3EFA60
        public void set_activeFilters(){} // RVA: 0x7AF0C5190
        public void get_maxSubTextureSize(){} // RVA: 0x7AEFCF7E0
        public void set_maxSubTextureSize(){} // RVA: 0x7AF0C51B0
        public void set_customFilter(){} // RVA: 0x7AF0C51D0
        public void .ctor(){} // RVA: 0x7AF0C5280
    }

    public class DynamicAtlasCustomFilter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC226250
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class DynamicAtlasPage : Object
    {
        // ── Methods ──
        public void get_textureId(){} // RVA: 0x7A8124910
        public void set_textureId(){} // RVA: 0x7A80DA0C0
        public void get_atlas(){} // RVA: 0x7A80DA7B0
        public void set_atlas(){} // RVA: 0x7A813E420
        public void get_format(){} // RVA: 0x7A851DB90
        public void get_filterMode(){} // RVA: 0x7A8AB15F0
        public void .ctor(){} // RVA: 0x7AF20F370
        public void get_disposed(){} // RVA: 0x7A8359360
        public void set_disposed(){} // RVA: 0x7A8A21900
        public void Dispose(){} // RVA: 0x7AF20F770
        public void TryAdd(){} // RVA: 0x7AF20F9E0
        public void Update(){} // RVA: 0x7AF20FBD0
        public void Remove(){} // RVA: 0x7AF20FED0
        public void Commit(){} // RVA: 0x7AF20FFA0
        public void UpdateAtlasTexture(){} // RVA: 0x7AF2100D0
        public void CreateAtlasTexture(){} // RVA: 0x7AF210760
    }

    public class DynamicAtlasSettings : Object
    {
        // ── Methods ──
        public void get_minAtlasSize(){} // RVA: 0x7A8124910
        public void set_minAtlasSize(){} // RVA: 0x7A80DA0C0
        public void get_maxAtlasSize(){} // RVA: 0x7A8668BC0
        public void set_maxAtlasSize(){} // RVA: 0x7A8669360
        public void get_maxSubTextureSize(){} // RVA: 0x7A83782A0
        public void set_maxSubTextureSize(){} // RVA: 0x7A84385B0
        public void get_activeFilters(){} // RVA: 0x7A9739200
        public void set_activeFilters(){} // RVA: 0x7A9746990
        public void get_defaultFilters(){} // RVA: 0x7AE3EFA60
        public void get_customFilter(){} // RVA: 0x7A81052C0
        public void set_customFilter(){} // RVA: 0x7A81052D0
        public void get_defaults(){} // RVA: 0x7AF1DCF00
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DynamicHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        // ── Methods ──
        public void get_defaultExpectedHeight(){} // RVA: 0x7A7E155B0
        public void get_contentPadding(){} // RVA: 0x7A7E155B0
        public void set_contentPadding(){} // RVA: 0x7A7E262C0
        public void get_contentHeight(){} // RVA: 0x7A7E155B0
        public void set_contentHeight(){} // RVA: 0x7A7E262C0
        public void get_anchoredIndex(){} // RVA: 0x7A7E00710
        public void set_anchoredIndex(){} // RVA: 0x7A7E189D0
        public void get_anchorOffset(){} // RVA: 0x7A7E155B0
        public void set_anchorOffset(){} // RVA: 0x7A7E262C0
        public void get_viewportMaxOffset(){} // RVA: 0x7A7E155B0
        public void get_alwaysRebindOnRefresh(){} // RVA: 0x7A7E01900
        public void .ctor(){} // RVA: 0x7A7E18800
        public void Refresh(){} // RVA: 0x7A7E18C30
        public void ScrollToItem(){} // RVA: 0x7A7E189D0
        public void Resize(){} // RVA: 0x7A7E1A3B0
        public void OnScroll(){} // RVA: 0x7A7E1A3B0
        public void OnScrollUpdate(){} // RVA: 0x7A7E18770
        public void CycleItems(){} // RVA: 0x7A7E189D0
        public void NeedsFill(){} // RVA: 0x7A7E01900
        public void Fill(){} // RVA: 0x7A7E18770
        public void UpdateScrollViewContainer(){} // RVA: 0x7A7E26740
        public void ApplyScrollViewUpdate(){} // RVA: 0x7A7E18C30
        public void UpdateAnchor(){} // RVA: 0x7A7E18770
        public void ScheduleFill(){} // RVA: 0x7A7E18770
        public void ScheduleScroll(){} // RVA: 0x7A7E18770
        public void ScheduleScrollDirectionReset(){} // RVA: 0x7A7E18770
        public void ResetScroll(){} // RVA: 0x7A7E18770
        public void GetIndexFromPosition(){} // RVA: 0x7A7E07BD0
        public void GetExpectedItemHeight(){} // RVA: 0x7A7E15950
        public void GetFirstVisibleItem(){} // RVA: 0x7A7E0D3E0
        public void GetExpectedContentHeight(){} // RVA: 0x7A7E155B0
        public void GetContentHeightForIndex(){} // RVA: 0x7A7E15950
        public void GetCachedContentHeight(){} // RVA: 0x7A8051B10
        public void RegisterItemHeight(){} // RVA: 0x7A7E1C190
        public void UnregisterItemHeight(){} // RVA: 0x7A7E189D0
        public void CleanItemHeightCache(){} // RVA: 0x7A7E18770
        public void OnRecycledItemGeometryChanged(){} // RVA: 0x7A7E18800
        public void UpdateRegisteredHeight(){} // RVA: 0x7A7E019D0
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7A8051B10
        public void ReleaseItem(){} // RVA: 0x7A7E189D0
        public void StartDragItem(){} // RVA: 0x7A7E18800
        public void EndDrag(){} // RVA: 0x7A7E189D0
        public void HideItem(){} // RVA: 0x7A7E189D0
        public void MarkWaitingForLayout(){} // RVA: 0x7A8051B10
        public void IsIndexOutOfBounds(){} // RVA: 0x7A7E01F00
    }

}