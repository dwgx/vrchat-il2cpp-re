// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 4
// Methods: 93

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class DefaultEventSystem : Object
    {
        public object isAppFocused;
        public object input;
        public object focusedPanel;

        // ── Methods ──
        public void get_isAppFocused(){} // RVA: 0x7FFD54F8ACC0
        public void get_input(){} // RVA: 0x7FFD54F8AD40
        public void GetDefaultInput(){} // RVA: 0x7FFD54F8ADB0
        public void ShouldIgnoreEventsOnAppNotFocused(){} // RVA: 0x7FFD54F8AE80
        public void get_focusedPanel(){} // RVA: 0x7FFD4E3E20E0
        public void set_focusedPanel(){} // RVA: 0x7FFD54F8AED0
        public void Update(){} // RVA: 0x7FFD54F8AF60
        public void FocusBasedEventSequence(){} // RVA: 0x7FFD54F8B110
        public void SendIMGUIEvents(){} // RVA: 0x7FFD54F8B140
        public void ProcessMouseEvents(){} // RVA: 0x7FFD54F8B9B0
        public void SendInputEvents(){} // RVA: 0x7FFD54F8C250
        public void OnFocusEvent(){} // RVA: 0x7FFD54F8C680
        public void SendFocusBasedEvent(){} // RVA: 0x7FFD4E2ADC40
        public void SendPositionBasedEvent(){} // RVA: 0x7FFD4E2ADC40
        public void UpdateFocusedPanel(){} // RVA: 0x7FFD54F8C690
        public void MakeTouchEvent(){} // RVA: 0x7FFD54F8C730
        public void MakePenEvent(){} // RVA: 0x7FFD54F8C850
        public void ProcessTouchEvents(){} // RVA: 0x7FFD54F8C940
        public void ProcessPenEvents(){} // RVA: 0x7FFD54F8CF50
        public void GetRawMoveVector(){} // RVA: 0x7FFD54F8D420
        public void ShouldSendMoveFromInput(){} // RVA: 0x7FFD54F8D580
        public void ProcessTabEvent(){} // RVA: 0x7FFD54F8D810
        public void .ctor(){} // RVA: 0x7FFD54F8DB50
        public void .cctor(){} // RVA: 0x7FFD54F8DE60
    }

    public class DefaultMultiColumnTreeViewController`1 : MultiColumnTreeViewController
    {
        public object treeDataController;
        public object itemsSource;

        // ── Methods ──
        public void get_treeDataController(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E09AF60
        public void get_itemsSource(){} // RVA: 0x7FFD4E078E90
        public void set_itemsSource(){} // RVA: 0x7FFD4E090A40
        public void SetRootItems(){} // RVA: 0x7FFD4E090A40
        public void GetItemForIndex(){} // RVA: 0x7FFD4E087DE0
        public void GetParentId(){} // RVA: 0x7FFD4E0800D0
        public void HasChildren(){} // RVA: 0x7FFD4E07A310
        public void GetChildrenIds(){} // RVA: 0x7FFD4E087DE0
        public void Move(){}
        public void IsChildOf(){}
        public void GetAllItemIds(){} // RVA: 0x7FFD4E078F40
    }

    public class DefaultTreeViewController`1 : TreeViewController
    {
        public object treeDataController;
        public object itemsSource;

        // ── Methods ──
        public void get_treeDataController(){} // RVA: 0x7FFD4E078E90
        public void get_itemsSource(){} // RVA: 0x7FFD4E078E90
        public void set_itemsSource(){} // RVA: 0x7FFD4E090A40
        public void SetRootItems(){} // RVA: 0x7FFD4E090A40
        public void GetItemForIndex(){} // RVA: 0x7FFD4E087DE0
        public void GetParentId(){} // RVA: 0x7FFD4E0800D0
        public void HasChildren(){} // RVA: 0x7FFD4E07A310
        public void GetChildrenIds(){} // RVA: 0x7FFD4E087DE0
        public void Move(){}
        public void IsChildOf(){}
        public void GetAllItemIds(){} // RVA: 0x7FFD4E078F40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class DynamicHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        public object defaultExpectedHeight;
        public object contentPadding;
        public object contentHeight;
        public object anchoredIndex;
        public object anchorOffset;
        public object viewportMaxOffset;
        public object alwaysRebindOnRefresh;

        // ── Methods ──
        public void get_defaultExpectedHeight(){} // RVA: 0x7FFD4E08D880
        public void get_contentPadding(){} // RVA: 0x7FFD4E08D880
        public void set_contentPadding(){} // RVA: 0x7FFD4E09E480
        public void get_contentHeight(){} // RVA: 0x7FFD4E08D880
        public void set_contentHeight(){} // RVA: 0x7FFD4E09E480
        public void get_anchoredIndex(){} // RVA: 0x7FFD4E079960
        public void set_anchoredIndex(){} // RVA: 0x7FFD4E090ED0
        public void get_anchorOffset(){} // RVA: 0x7FFD4E08D880
        public void set_anchorOffset(){} // RVA: 0x7FFD4E09E480
        public void get_viewportMaxOffset(){} // RVA: 0x7FFD4E08D880
        public void get_alwaysRebindOnRefresh(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Refresh(){} // RVA: 0x7FFD4E091060
        public void ScrollToItem(){} // RVA: 0x7FFD4E090ED0
        public void Resize(){} // RVA: 0x7FFD4E09F3E0
        public void OnScroll(){} // RVA: 0x7FFD4E09F3E0
        public void OnScrollUpdate(){} // RVA: 0x7FFD4E090980
        public void CycleItems(){} // RVA: 0x7FFD4E090ED0
        public void NeedsFill(){} // RVA: 0x7FFD4E079D00
        public void Fill(){} // RVA: 0x7FFD4E090980
        public void UpdateScrollViewContainer(){}
        public void ApplyScrollViewUpdate(){} // RVA: 0x7FFD4E091060
        public void UpdateAnchor(){} // RVA: 0x7FFD4E090980
        public void ScheduleFill(){} // RVA: 0x7FFD4E090980
        public void ScheduleScroll(){} // RVA: 0x7FFD4E090980
        public void ScheduleScrollDirectionReset(){} // RVA: 0x7FFD4E090980
        public void ResetScroll(){} // RVA: 0x7FFD4E090980
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7FFD4E08DC30
        public void GetFirstVisibleItem(){}
        public void GetExpectedContentHeight(){} // RVA: 0x7FFD4E08D880
        public void GetContentHeightForIndex(){} // RVA: 0x7FFD4E08DC30
        public void GetCachedContentHeight(){} // RVA: 0x7FFD4E2ADC40
        public void RegisterItemHeight(){} // RVA: 0x7FFD4E094400
        public void UnregisterItemHeight(){} // RVA: 0x7FFD4E090ED0
        public void CleanItemHeightCache(){} // RVA: 0x7FFD4E090980
        public void OnRecycledItemGeometryChanged(){} // RVA: 0x7FFD4E090A40
        public void UpdateRegisteredHeight(){} // RVA: 0x7FFD4E079F60
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7FFD4E2ADC40
        public void ReleaseItem(){} // RVA: 0x7FFD4E090ED0
        public void StartDragItem(){} // RVA: 0x7FFD4E090A40
        public void EndDrag(){} // RVA: 0x7FFD4E090ED0
        public void HideItem(){} // RVA: 0x7FFD4E090ED0
        public void MarkWaitingForLayout(){} // RVA: 0x7FFD4E2ADC40
        public void IsIndexOutOfBounds(){} // RVA: 0x7FFD4E07A310
    }

}