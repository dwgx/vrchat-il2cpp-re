// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 4
// Methods: 93

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class DefaultEventSystem : Object
    {
        public System.Func`1<bool> isAppFocused;
        public 0x6647A3B8 input; // 0x10
        public string focusedPanel; // 0x18
        public string m_VerticalAxis; // 0x20
        public string m_SubmitButton; // 0x28
        public string m_CancelButton; // 0x30
        public float m_InputActionsPerSecond; // 0x38
        public float m_RepeatDelay; // 0x3C
        public bool m_SendingTouchEvents; // 0x40
        public bool m_SendingPenEvent; // 0x41
        public UnityEngine.Event m_Event; // 0x48
        public 0x664803F8 m_FocusedPanel; // 0x50
        public 0x664803F8 m_PreviousFocusedPanel; // 0x58
        public UnityEngine.UIElements.Focusable m_PreviousFocusedElement; // 0x60
        public 0x665DF588 m_CurrentModifiers; // 0x68
        public int m_LastMousePressButton; // 0x6C
        public float m_NextMousePressTime; // 0x70
        public int m_LastMouseClickCount; // 0x74
        public UnityEngine.Vector2 m_LastMousePosition; // 0x78
        public bool m_MouseProcessedAtLeastOnce; // 0x80
        public int m_ConsecutiveMoveCount; // 0x84
        public UnityEngine.Vector2 m_LastMoveVector; // 0x88
        public float m_PrevActionTime; // 0x90
        public bool m_IsMoveFromKeyboard; // 0x94

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
        public UnityEngine.UIElements.TreeDataController`1<T> treeDataController;

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
        public UnityEngine.UIElements.TreeDataController`1<T> treeDataController;

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
        public int defaultExpectedHeight;
        public System.Collections.Generic.Dictionary`2<int,float> contentPadding;
        public System.Collections.Generic.Dictionary`2<int,ContentHeightCacheInfo<T>> contentHeight;
        public System.Collections.Generic.HashSet`1<int> anchoredIndex;
        public int anchorOffset;
        public int viewportMaxOffset;
        public bool alwaysRebindOnRefresh;
        public 0x66474BB8<T> m_LastChange;
        public 0x66474C10<T> m_ScrollDirection;
        public UnityEngine.Vector2 m_DelayedScrollOffset;
        public float m_AccumulatedHeight;
        public float m_MinimumItemHeight;
        public System.Action m_FillCallback;
        public System.Action m_ScrollCallback;
        public System.Action m_ScrollResetCallback;
        public System.Action`1<0x66474D18> m_GeometryChangedCallback;
        public 0x66486E30 m_ScheduledItem;
        public 0x66486E30 m_ScrollScheduledItem;
        public 0x66486E30 m_ScrollResetScheduledItem;
        public System.Predicate`1<int> m_IndexOutOfBoundsPredicate;

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