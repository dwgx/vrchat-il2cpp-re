// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 4
// Methods: 93

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class DefaultEventSystem : Object
    {
        public object m_HorizontalAxis; // 0x317396C0
        public object m_CancelButton; // 0x317396C0
        public object m_SendingTouchEvents; // 0x317396C0
        public object m_FocusedPanel; // 0x317396C0
        public object m_CurrentModifiers; // 0x317396C0
        public object m_LastMouseClickCount; // 0x317396C0
        public object m_ConsecutiveMoveCount; // 0x317396C0
        public object m_IsMoveFromKeyboard; // 0x317396C0
        public object isAppFocused; // 0x1700019D
        public object input; // 0x1700019E
        public object focusedPanel; // 0x1700019F
        public object NotifyDisposedUsed; // 0xB3F6FFF0

        // ── Original Methods ──
        public void get_isAppFocused(){} // RVA: 0x7ffaaf58cc20
        public void get_input(){} // RVA: 0x7ffaaf58cca0
        public void ShouldIgnoreEventsOnAppNotFocused(){} // RVA: 0x7ffaaf58cde0
        public void get_focusedPanel(){} // RVA: 0x7ffaa89d30e0
        public void set_focusedPanel(){} // RVA: 0x7ffaaf58ce30
        public void Update(){} // RVA: 0x7ffaaf58cec0
        public void FocusBasedEventSequence(){} // RVA: 0x7ffaaf58d070
        public void SendIMGUIEvents(){} // RVA: 0x7ffaaf58d0a0
        public void ProcessMouseEvents(){} // RVA: 0x7ffaaf58d910
        public void SendInputEvents(){} // RVA: 0x7ffaaf58e1b0
        public void OnFocusEvent(){} // RVA: 0x7ffaaf58e5e0
        public void SendFocusBasedEvent(){} // RVA: 0x7ffaa887e5c0
        public void SendPositionBasedEvent(){} // RVA: 0x7ffaa887e5c0
        public void UpdateFocusedPanel(){} // RVA: 0x7ffaaf58e5f0
        public void MakeTouchEvent(){} // RVA: 0x7ffaaf58e690
        public void MakePenEvent(){} // RVA: 0x7ffaaf58e7b0
        public void ProcessTouchEvents(){} // RVA: 0x7ffaaf58e8a0
        public void ProcessPenEvents(){} // RVA: 0x7ffaaf58eeb0
        public void ShouldSendMoveFromInput(){} // RVA: 0x7ffaaf58f4e0
        public void ProcessTabEvent(){} // RVA: 0x7ffaaf58f770
        public void .ctor(){} // RVA: 0x7ffaaf58fab0
        public void .cctor(){} // RVA: 0x7ffaaf58fdc0
        // ── Binary Analysis Named ──
        public void GetDefaultInput(){} // RVA: 0x7ffaaf58cd10
        public void GetRawMoveVector(){} // RVA: 0x7ffaaf58f380
    }

    public class DefaultMultiColumnTreeViewController`1 : MultiColumnTreeViewController
    {
        // ── Original Methods ──
        public void get_treeDataController(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa866b2a0
        public void get_itemsSource(){} // RVA: 0x7ffaa86491d0
        public void set_itemsSource(){} // RVA: 0x7ffaa8660d80
        public void HasChildren(){} // RVA: 0x7ffaa864a650
        public void Move(){}
        public void IsChildOf(){}
        // ── Binary Analysis Named ──
        public void SetRootItems(){} // RVA: 0x7ffaa8660d80
        public void GetItemForIndex(){} // RVA: 0x7ffaa8658120
        public void GetParentId(){} // RVA: 0x7ffaa8650410
        public void GetChildrenIds(){} // RVA: 0x7ffaa8658120
        public void GetAllItemIds(){} // RVA: 0x7ffaa8649280
    }

    public class DefaultTreeViewController`1 : TreeViewController
    {
        // ── Original Methods ──
        public void get_treeDataController(){} // RVA: 0x7ffaa86491d0
        public void get_itemsSource(){} // RVA: 0x7ffaa86491d0
        public void set_itemsSource(){} // RVA: 0x7ffaa8660d80
        public void HasChildren(){} // RVA: 0x7ffaa864a650
        public void Move(){}
        public void IsChildOf(){}
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetRootItems(){} // RVA: 0x7ffaa8660d80
        public void GetItemForIndex(){} // RVA: 0x7ffaa8658120
        public void GetParentId(){} // RVA: 0x7ffaa8650410
        public void GetChildrenIds(){} // RVA: 0x7ffaa8658120
        public void GetAllItemIds(){} // RVA: 0x7ffaa8649280
    }

    public class DynamicHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        public object m_ContentHeightCache; // 0x30E64820
        public object m_ForcedLastVisibleItem; // 0x30E64820
        public object m_ScrollDirection; // 0x30E64820
        public object m_MinimumItemHeight; // 0x30E64820
        public object m_ScrollResetCallback; // 0x30E64820
        public object m_ScrollScheduledItem; // 0x30E64820

        // ── Original Methods ──
        public void get_defaultExpectedHeight(){} // RVA: 0x7ffaa865dbc0
        public void get_contentPadding(){} // RVA: 0x7ffaa865dbc0
        public void set_contentPadding(){} // RVA: 0x7ffaa866e7c0
        public void get_contentHeight(){} // RVA: 0x7ffaa865dbc0
        public void set_contentHeight(){} // RVA: 0x7ffaa866e7c0
        public void get_anchoredIndex(){} // RVA: 0x7ffaa8649ca0
        public void set_anchoredIndex(){} // RVA: 0x7ffaa8661210
        public void get_anchorOffset(){} // RVA: 0x7ffaa865dbc0
        public void set_anchorOffset(){} // RVA: 0x7ffaa866e7c0
        public void get_viewportMaxOffset(){} // RVA: 0x7ffaa865dbc0
        public void get_alwaysRebindOnRefresh(){} // RVA: 0x7ffaa864a040
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Refresh(){} // RVA: 0x7ffaa86613a0
        public void ScrollToItem(){} // RVA: 0x7ffaa8661210
        public void Resize(){} // RVA: 0x7ffaa866f720
        public void OnScroll(){} // RVA: 0x7ffaa866f720
        public void OnScrollUpdate(){} // RVA: 0x7ffaa8660cc0
        public void CycleItems(){} // RVA: 0x7ffaa8661210
        public void NeedsFill(){} // RVA: 0x7ffaa864a040
        public void Fill(){} // RVA: 0x7ffaa8660cc0
        public void UpdateScrollViewContainer(){}
        public void ApplyScrollViewUpdate(){} // RVA: 0x7ffaa86613a0
        public void UpdateAnchor(){} // RVA: 0x7ffaa8660cc0
        public void ScheduleFill(){} // RVA: 0x7ffaa8660cc0
        public void ScheduleScroll(){} // RVA: 0x7ffaa8660cc0
        public void ScheduleScrollDirectionReset(){} // RVA: 0x7ffaa8660cc0
        public void ResetScroll(){} // RVA: 0x7ffaa8660cc0
        public void RegisterItemHeight(){} // RVA: 0x7ffaa8664740
        public void UnregisterItemHeight(){} // RVA: 0x7ffaa8661210
        public void CleanItemHeightCache(){} // RVA: 0x7ffaa8660cc0
        public void OnRecycledItemGeometryChanged(){} // RVA: 0x7ffaa8660d80
        public void UpdateRegisteredHeight(){} // RVA: 0x7ffaa864a2a0
        public void ReleaseItem(){} // RVA: 0x7ffaa8661210
        public void StartDragItem(){} // RVA: 0x7ffaa8660d80
        public void EndDrag(){} // RVA: 0x7ffaa8661210
        public void HideItem(){} // RVA: 0x7ffaa8661210
        public void MarkWaitingForLayout(){} // RVA: 0x7ffaa887e5c0
        public void IsIndexOutOfBounds(){} // RVA: 0x7ffaa864a650
        // ── Binary Analysis Named ──
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7ffaa865df70
        public void GetFirstVisibleItem(){}
        public void GetExpectedContentHeight(){} // RVA: 0x7ffaa865dbc0
        public void GetContentHeightForIndex(){} // RVA: 0x7ffaa865df70
        public void GetCachedContentHeight(){} // RVA: 0x7ffaa887e5c0
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7ffaa887e5c0
    }

}