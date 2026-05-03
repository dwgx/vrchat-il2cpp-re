// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 25
// Methods: 228

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class DefaultDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFE87F26720
        public void DispatchEvent(){} // RVA: 0x7FFE87F267B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DefaultDragAndDropClient : DragAndDropData
    {
        public System.Collections.Hashtable m_GenericData; // 0x10
        public UnityEngine.UIElements.Label m_DraggedInfoLabel; // 0x18

        // ── Methods ──
        public void get_source(){} // RVA: 0x7FFE87F182A0
        public void GetGenericData(){} // RVA: 0x7FFE87F182F0
        public void StartDrag(){} // RVA: 0x7FFE87F18360
        public void UpdateDrag(){} // RVA: 0x7FFE87F18B90
        public void AcceptDrag(){} // RVA: 0x7FFE810FB310
        public void SetVisualMode(){} // RVA: 0x7FFE8170B670
        public void DragCleanup(){} // RVA: 0x7FFE87F18D70
        public void get_data(){} // RVA: 0x7FFE827C4A80
        public void .ctor(){} // RVA: 0x7FFE87F18E10
    }

    public class DefaultEventSystem : Object
    {
        public System.Func`1<bool> IsEditorRemoteConnected;
        public IInput m_Input; // 0x10
        public string m_HorizontalAxis; // 0x18

        // ── Methods ──
        public void get_isAppFocused(){} // RVA: 0x7FFE87F13560
        public void get_input(){} // RVA: 0x7FFE87F135E0
        public void GetDefaultInput(){} // RVA: 0x7FFE87F13650
        public void ShouldIgnoreEventsOnAppNotFocused(){} // RVA: 0x7FFE87F13720
        public void get_focusedPanel(){} // RVA: 0x7FFE8119C0E0
        public void set_focusedPanel(){} // RVA: 0x7FFE87F13770
        public void Update(){} // RVA: 0x7FFE87F13800
        public void FocusBasedEventSequence(){} // RVA: 0x7FFE87F139B0
        public void SendIMGUIEvents(){} // RVA: 0x7FFE87F139E0
        public void ProcessMouseEvents(){} // RVA: 0x7FFE87F14250
        public void SendInputEvents(){} // RVA: 0x7FFE87F14AF0
        public void OnFocusEvent(){} // RVA: 0x7FFE87F14F20
        public void SendFocusBasedEvent(){} // RVA: 0x7FFE810A1420
        public void SendPositionBasedEvent(){} // RVA: 0x7FFE810A1420
        public void UpdateFocusedPanel(){} // RVA: 0x7FFE87F14F30
        public void MakeTouchEvent(){} // RVA: 0x7FFE87F14FD0
        public void MakePenEvent(){} // RVA: 0x7FFE87F150F0
        public void ProcessTouchEvents(){} // RVA: 0x7FFE87F151E0
        public void ProcessPenEvents(){} // RVA: 0x7FFE87F157F0
        public void GetRawMoveVector(){} // RVA: 0x7FFE87F15CC0
        public void ShouldSendMoveFromInput(){} // RVA: 0x7FFE87F15E20
        public void ProcessTabEvent(){} // RVA: 0x7FFE87F160B0
        public void .ctor(){} // RVA: 0x7FFE87F163F0
        public void .cctor(){} // RVA: 0x7FFE87F16700
    }

    public class DefaultGroupManager : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE811290D0
        public void OnOptionSelectionChanged(){} // RVA: 0x7FFE87F46DF0
        public void RegisterOption(){} // RVA: 0x7FFE87F47070
        public void UnregisterOption(){} // RVA: 0x7FFE87F471A0
        public void .ctor(){} // RVA: 0x7FFE87F47230
    }

    public class DefaultMultiColumnTreeViewController`1 : MultiColumnTreeViewController
    {
        public UnityEngine.UIElements.TreeDataController`1<T> m_TreeDataController;
        public object field_1; // 0x5D

        // ── Methods ──
        public void get_treeDataController(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E50660
        public void get_itemsSource(){} // RVA: 0x7FFE80E2E2E0
        public void set_itemsSource(){} // RVA: 0x7FFE80E460A0
        public void SetRootItems(){} // RVA: 0x7FFE80E460A0
        public void GetItemForIndex(){} // RVA: 0x7FFE80E3D230
        public void GetParentId(){} // RVA: 0x7FFE80E35520
        public void HasChildren(){} // RVA: 0x7FFE80E2F760
        public void GetChildrenIds(){} // RVA: 0x7FFE80E3D230
        public void Move(){}
        public void IsChildOf(){}
        public void GetAllItemIds(){} // RVA: 0x7FFE80E2E390
    }

    public class DefaultTreeViewController`1 : TreeViewController
    {
        public UnityEngine.UIElements.TreeDataController`1<T> m_TreeDataController;
        public object field_1; // 0x5F

        // ── Methods ──
        public void get_treeDataController(){} // RVA: 0x7FFE80E2E2E0
        public void get_itemsSource(){} // RVA: 0x7FFE80E2E2E0
        public void set_itemsSource(){} // RVA: 0x7FFE80E460A0
        public void SetRootItems(){} // RVA: 0x7FFE80E460A0
        public void GetItemForIndex(){} // RVA: 0x7FFE80E3D230
        public void GetParentId(){} // RVA: 0x7FFE80E35520
        public void HasChildren(){} // RVA: 0x7FFE80E2F760
        public void GetChildrenIds(){} // RVA: 0x7FFE80E3D230
        public void Move(){}
        public void IsChildOf(){}
        public void GetAllItemIds(){} // RVA: 0x7FFE80E2E390
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class DetachFromPanelEvent : PanelChangedEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F34A50
        public void .ctor(){} // RVA: 0x7FFE87F34B40
    }

    public class DisposeHelper : Object
    {
        // ── Methods ──
        public void NotifyDisposedUsed(){} // RVA: 0x7FFE87F179A0
    }

    public class DoubleField : TextValueField`1
    {
        public string ussClassName;

        // ── Methods ──
        public void get_doubleInput(){} // RVA: 0x7FFE87E542F0
        public void ValueToString(){} // RVA: 0x7FFE87E54380
        public void StringToValue(){} // RVA: 0x7FFE87E54540
        public void .ctor(){} // RVA: 0x7FFE87E54640 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFE87E54940
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87E549D0
        public void .cctor(){} // RVA: 0x7FFE87E54AC0
    }

    public class DragAndDropArgs : ValueType
    {
        public object _target; // 0x10
        public int _insertAtIndex; // 0x18
        public int _parentId; // 0x1C
        public int _childIndex; // 0x20
        public 0x6651385C _dragAndDropPosition; // 0x24
        public UnityEngine.UIElements.DragAndDropData _dragAndDropData; // 0x28

        // ── Methods ──
        public void set_target(){} // RVA: 0x7FFE81D7E9E0
        public void get_insertAtIndex(){} // RVA: 0x7FFE82C33000
        public void set_insertAtIndex(){} // RVA: 0x7FFE82C33010
        public void get_parentId(){} // RVA: 0x7FFE82C33020
        public void set_parentId(){} // RVA: 0x7FFE82C33030
        public void get_childIndex(){} // RVA: 0x7FFE811485C0
        public void set_childIndex(){} // RVA: 0x7FFE810FE0C0
        public void get_dragAndDropPosition(){} // RVA: 0x7FFE8164B230
        public void set_dragAndDropPosition(){} // RVA: 0x7FFE8164E0F0
        public void get_dragAndDropData(){} // RVA: 0x7FFE810FE7C0
        public void set_dragAndDropData(){} // RVA: 0x7FFE81161E80
    }

    public class DragAndDropData : Object
    {
        // ── Methods ──
        public void GetGenericData(){} // RVA: 0x7FFE80E2E390
        public void get_source(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DragAndDropUtility : Object
    {
        // ── Methods ──
        public void GetDragAndDrop(){} // RVA: 0x7FFE87F180A0
    }

    public class DragEventsProcessor : Object
    {
        public bool m_IsRegistered; // 0x10
        public 0x665135F4 m_DragState; // 0x14
        public UnityEngine.Vector3 m_Start; // 0x18
        public UnityEngine.UIElements.VisualElement m_Target; // 0x28

        // ── Methods ──
        public void get_supportsDragEvents(){} // RVA: 0x7FFE811E0850
        public void get_useDragEvents(){} // RVA: 0x7FFE87F18EC0
        public void get_dragAndDrop(){} // RVA: 0x7FFE87F18F20
        public void get_isEditorContext(){} // RVA: 0x7FFE87F18F50
        public void .ctor(){} // RVA: 0x7FFE87F19030
        public void RegisterCallbacksFromTarget(){} // RVA: 0x7FFE87F191C0 | overloaded x2
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFE87F194F0 | overloaded x2
        public void CanStartDrag(){} // RVA: 0x7FFE80E2F3B0
        public void StartDrag(){}
        public void UpdateDrag(){} // RVA: 0x7FFE80E460A0
        public void OnDrop(){} // RVA: 0x7FFE80E460A0
        public void ClearDragAndDropUI(){} // RVA: 0x7FFE80E466C0
        public void OnPointerDownEvent(){} // RVA: 0x7FFE87F19950
        public void OnPointerUpEvent(){} // RVA: 0x7FFE87F19A90
        public void OnPointerLeaveEvent(){} // RVA: 0x7FFE87F19CC0
        public void OnPointerCancelEvent(){} // RVA: 0x7FFE87F19CE0
        public void OnPointerCapturedOut(){} // RVA: 0x7FFE87F19E40
        public void OnPointerMoveEvent(){} // RVA: 0x7FFE87F19F20
        public void GetDropTarget(){} // RVA: 0x7FFE87F1A380
    }

    public class DropdownField : PopupField`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E55300 | overloaded x2
    }

    public class DropdownMenu : Object
    {
        // ── Methods ──
        public void MenuItems(){} // RVA: 0x7FFE84022BE0
        public void AppendAction(){} // RVA: 0x7FFE87F22DE0 | overloaded x2
        public void AppendSeparator(){} // RVA: 0x7FFE87F22F10
        public void InsertSeparator(){} // RVA: 0x7FFE87F230C0
        public void PrepareForDisplay(){} // RVA: 0x7FFE87F23280
        public void .ctor(){} // RVA: 0x7FFE87F23750
    }

    public class DropdownMenuAction : DropdownMenuItem
    {
        public string _name; // 0x10
        public 0x66513E8C _status; // 0x18
        public UnityEngine.UIElements.DropdownMenuEventInfo _eventInfo; // 0x20

        // ── Methods ──
        public void set_status(){} // RVA: 0x7FFE8144DF00
        public void set_eventInfo(){} // RVA: 0x7FFE811290D0
        public void set_userData(){} // RVA: 0x7FFE810FCE90
        public void AlwaysEnabled(){} // RVA: 0x7FFE87F22A00
        public void AlwaysDisabled(){} // RVA: 0x7FFE87F22A10
        public void .ctor(){} // RVA: 0x7FFE87F22A20
        public void UpdateActionStatus(){} // RVA: 0x7FFE87F22B70
    }

    public class DropdownMenuEventInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F22860
    }

    public class DropdownMenuItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DropdownMenuSeparator : DropdownMenuItem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class DropdownUtility : Object
    {
        // ── Methods ──
        public void CreateDropdown(){} // RVA: 0x7FFE87F23810
    }

    public class DynamicAtlas : AtlasBase
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.Texture,TextureInfo> m_Database; // 0x18
        public UnityEngine.UIElements.DynamicAtlasPage m_PointPage; // 0x20
        public UnityEngine.UIElements.DynamicAtlasPage m_BilinearPage; // 0x28
        public 0x665756D4 m_ColorSpace; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.UIElements.IPanel> m_Panels; // 0x38
        public int m_MinAtlasSize; // 0x40
        public int m_MaxAtlasSize; // 0x44

        // ── Methods ──
        public void get_isInitialized(){} // RVA: 0x7FFE87E23DA0
        public void OnAssignedToPanel(){} // RVA: 0x7FFE87E23DC0
        public void OnRemovedFromPanel(){} // RVA: 0x7FFE87E23EC0
        public void Reset(){} // RVA: 0x7FFE87E23F60
        public void InitPages(){} // RVA: 0x7FFE87E24030
        public void DestroyPages(){} // RVA: 0x7FFE87E242E0
        public void TryGetAtlas(){} // RVA: 0x7FFE87E24400
        public void ReturnAtlas(){} // RVA: 0x7FFE87E24920
        public void OnUpdateDynamicTextures(){} // RVA: 0x7FFE87E24C10
        public void IsTextureFormatSupported(){} // RVA: 0x7FFE87E24C90
        public void IsTextureValid(){} // RVA: 0x7FFE87E24D10
        public void set_minAtlasSize(){} // RVA: 0x7FFE87E24F40
        public void set_maxAtlasSize(){} // RVA: 0x7FFE87E24F60
        public void get_defaultFilters(){} // RVA: 0x7FFE87140130
        public void set_activeFilters(){} // RVA: 0x7FFE87E24F80
        public void get_maxSubTextureSize(){} // RVA: 0x7FFE87D30410
        public void set_maxSubTextureSize(){} // RVA: 0x7FFE87E24FA0
        public void set_customFilter(){} // RVA: 0x7FFE87E24FC0
        public void .ctor(){} // RVA: 0x7FFE87E25070
    }

    public class DynamicAtlasCustomFilter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE850720F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class DynamicAtlasPage : Object
    {
        public UnityEngine.UIElements.TextureId _textureId; // 0x10
        public UnityEngine.RenderTexture _atlas; // 0x18
        public 0x665759EC _format; // 0x20
        public 0x665757DC _filterMode; // 0x24
        public UnityEngine.Vector2Int _minSize; // 0x28

        // ── Methods ──
        public void get_textureId(){} // RVA: 0x7FFE811485C0
        public void set_textureId(){} // RVA: 0x7FFE810FE0C0
        public void get_atlas(){} // RVA: 0x7FFE810FE7C0
        public void set_atlas(){} // RVA: 0x7FFE81161E80
        public void get_format(){} // RVA: 0x7FFE8151D690
        public void get_filterMode(){} // RVA: 0x7FFE81A56130
        public void .ctor(){} // RVA: 0x7FFE87F70120
        public void get_disposed(){} // RVA: 0x7FFE813A1140
        public void set_disposed(){} // RVA: 0x7FFE819E83C0
        public void Dispose(){} // RVA: 0x7FFE87F70510 | overloaded x2
        public void TryAdd(){} // RVA: 0x7FFE87F70780
        public void Update(){} // RVA: 0x7FFE87F70980
        public void Remove(){} // RVA: 0x7FFE87F70C80
        public void Commit(){} // RVA: 0x7FFE87F70D50
        public void UpdateAtlasTexture(){} // RVA: 0x7FFE87F70E80
        public void CreateAtlasTexture(){} // RVA: 0x7FFE87F71520
    }

    public class DynamicAtlasSettings : Object
    {
        public int m_MinAtlasSize; // 0x10
        public int m_MaxAtlasSize; // 0x14
        public int m_MaxSubTextureSize; // 0x18
        public 0x6650CF84 m_ActiveFilters; // 0x1C
        public UnityEngine.UIElements.DynamicAtlasCustomFilter m_CustomFilter; // 0x20
        public object field_5; // 0x297
        public object field_6; // 0x298

        // ── Methods ──
        public void get_minAtlasSize(){} // RVA: 0x7FFE811485C0
        public void set_minAtlasSize(){} // RVA: 0x7FFE810FE0C0
        public void get_maxAtlasSize(){} // RVA: 0x7FFE8164B230
        public void set_maxAtlasSize(){} // RVA: 0x7FFE8164E0F0
        public void get_maxSubTextureSize(){} // RVA: 0x7FFE813DB630
        public void set_maxSubTextureSize(){} // RVA: 0x7FFE8144DF00
        public void get_activeFilters(){} // RVA: 0x7FFE82707EE0
        public void set_activeFilters(){} // RVA: 0x7FFE82717690
        public void get_defaultFilters(){} // RVA: 0x7FFE87140130
        public void get_customFilter(){} // RVA: 0x7FFE811290C0
        public void set_customFilter(){} // RVA: 0x7FFE811290D0
        public void get_defaults(){} // RVA: 0x7FFE87F3DF30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DynamicHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        public int m_HighestCachedIndex;
        public System.Collections.Generic.Dictionary`2<int,float> m_ItemHeightCache;
        public System.Collections.Generic.Dictionary`2<int,ContentHeightCacheInfo<T>> m_ContentHeightCache;
        public System.Collections.Generic.HashSet`1<int> m_WaitingCache;
        public int m_ForcedFirstVisibleItem;
        public int m_ForcedLastVisibleItem;
        public bool m_StickToBottom;

        // ── Methods ──
        public void get_defaultExpectedHeight(){} // RVA: 0x7FFE80E42E10
        public void get_contentPadding(){} // RVA: 0x7FFE80E42E10
        public void set_contentPadding(){} // RVA: 0x7FFE80E53B80
        public void get_contentHeight(){} // RVA: 0x7FFE80E42E10
        public void set_contentHeight(){} // RVA: 0x7FFE80E53B80
        public void get_anchoredIndex(){} // RVA: 0x7FFE80E2EDB0
        public void set_anchoredIndex(){} // RVA: 0x7FFE80E46530
        public void get_anchorOffset(){} // RVA: 0x7FFE80E42E10
        public void set_anchorOffset(){} // RVA: 0x7FFE80E53B80
        public void get_viewportMaxOffset(){} // RVA: 0x7FFE80E42E10
        public void get_alwaysRebindOnRefresh(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Refresh(){} // RVA: 0x7FFE80E466C0
        public void ScrollToItem(){} // RVA: 0x7FFE80E46530
        public void Resize(){} // RVA: 0x7FFE80E54AE0
        public void OnScroll(){} // RVA: 0x7FFE80E54AE0
        public void OnScrollUpdate(){} // RVA: 0x7FFE80E45FE0
        public void CycleItems(){} // RVA: 0x7FFE80E46530
        public void NeedsFill(){} // RVA: 0x7FFE80E2F150
        public void Fill(){} // RVA: 0x7FFE80E45FE0
        public void UpdateScrollViewContainer(){}
        public void ApplyScrollViewUpdate(){} // RVA: 0x7FFE80E466C0
        public void UpdateAnchor(){} // RVA: 0x7FFE80E45FE0
        public void ScheduleFill(){} // RVA: 0x7FFE80E45FE0
        public void ScheduleScroll(){} // RVA: 0x7FFE80E45FE0
        public void ScheduleScrollDirectionReset(){} // RVA: 0x7FFE80E45FE0
        public void ResetScroll(){} // RVA: 0x7FFE80E45FE0
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7FFE80E431C0
        public void GetFirstVisibleItem(){}
        public void GetExpectedContentHeight(){} // RVA: 0x7FFE80E42E10
        public void GetContentHeightForIndex(){} // RVA: 0x7FFE80E431C0
        public void GetCachedContentHeight(){} // RVA: 0x7FFE810A1420
        public void RegisterItemHeight(){} // RVA: 0x7FFE80E49A70
        public void UnregisterItemHeight(){} // RVA: 0x7FFE80E46530
        public void CleanItemHeightCache(){} // RVA: 0x7FFE80E45FE0
        public void OnRecycledItemGeometryChanged(){} // RVA: 0x7FFE80E460A0
        public void UpdateRegisteredHeight(){} // RVA: 0x7FFE80E2F3B0
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7FFE810A1420
        public void ReleaseItem(){} // RVA: 0x7FFE80E46530
        public void StartDragItem(){} // RVA: 0x7FFE80E460A0
        public void EndDrag(){} // RVA: 0x7FFE80E46530
        public void HideItem(){} // RVA: 0x7FFE80E46530
        public void MarkWaitingForLayout(){} // RVA: 0x7FFE810A1420
        public void IsIndexOutOfBounds(){} // RVA: 0x7FFE80E2F760
    }

}