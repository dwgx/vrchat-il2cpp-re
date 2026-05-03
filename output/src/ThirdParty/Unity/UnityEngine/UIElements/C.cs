// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 28
// Methods: 485

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class CallbackEventHandler : Object
    {
        // ── Methods ──
        public void RegisterCallback(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void AddEventCategories(){} // RVA: 0x7FFE80E45FE0
        public void UnregisterCallback(){} // RVA: 0x7FFE80E4D070
        public void SendEvent(){} // RVA: 0x7FFE80E4D070 | overloaded x2
        public void HandleEventAtTargetPhase(){} // RVA: 0x7FFE87F2A360
        public void HandleEventAtTargetAndDefaultPhase(){} // RVA: 0x7FFE87F2A3E0
        public void HandleEventAtCurrentTargetAndPhase(){} // RVA: 0x7FFE84D052B0
        public void UnityEngine.UIElements.IEventHandler.HandleEvent(){} // RVA: 0x7FFE84D052B0
        public void HandleEvent(){} // RVA: 0x7FFE87F2A490
        public void HasTrickleDownHandlers(){} // RVA: 0x7FFE87F2A7B0
        public void HasBubbleUpHandlers(){} // RVA: 0x7FFE87F2A7E0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFE810FB310
        public void ExecuteDefaultAction(){} // RVA: 0x7FFE810FB310
        public void ExecuteDefaultActionDisabledAtTarget(){} // RVA: 0x7FFE810FB310
        public void ExecuteDefaultActionDisabled(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE81FCAC70
    }

    public class CanStartDragArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84C28B80
    }

    public class ChangeEvent`1 : EventBase`1
    {
        public T _previousValue;
        public T _newValue;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void get_previousValue(){} // RVA: 0x7FFE810A1420
        public void set_previousValue(){} // RVA: 0x7FFE810A1420
        public void get_newValue(){} // RVA: 0x7FFE810A1420
        public void set_newValue(){} // RVA: 0x7FFE810A1420
        public void Init(){} // RVA: 0x7FFE80E45FE0
        public void LocalInit(){} // RVA: 0x7FFE80E45FE0
        public void GetPooled(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ClampedDragger`1 : Clickable
    {
        public System.Action dragging;
        public System.Action draggingEnded;
        public 0x6650D3FC<T> _dragDirection;
        public UnityEngine.UIElements.BaseSlider`1<T> _slider;

        // ── Methods ──
        public void add_dragging(){} // RVA: 0x7FFE80E460A0
        public void remove_dragging(){} // RVA: 0x7FFE80E460A0
        public void add_draggingEnded(){} // RVA: 0x7FFE80E460A0
        public void remove_draggingEnded(){} // RVA: 0x7FFE80E460A0
        public void get_dragDirection(){} // RVA: 0x7FFE810A1420
        public void set_dragDirection(){} // RVA: 0x7FFE810A1420
        public void set_slider(){} // RVA: 0x7FFE80E460A0
        public void get_startMousePosition(){} // RVA: 0x7FFE80E2E2E0
        public void set_startMousePosition(){} // RVA: 0x7FFE80E54AE0
        public void get_delta(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E50660
        public void ProcessDownEvent(){}
        public void ProcessUpEvent(){}
        public void ProcessMoveEvent(){}
    }

    public class ClickDetector : Object
    {
        public System.Collections.Generic.List`1<ButtonClickStatus> m_ClickStatus; // 0x10

        // ── Methods ──
        public void get_s_DoubleClickTime(){} // RVA: 0x7FFE87E2AE90
        public void set_s_DoubleClickTime(){} // RVA: 0x7FFE87E2AEF0
        public void .ctor(){} // RVA: 0x7FFE87E2AF50
        public void StartClickTracking(){} // RVA: 0x7FFE87E2B230
        public void SendClickEvent(){} // RVA: 0x7FFE87E2B450
        public void CancelClickTracking(){} // RVA: 0x7FFE87E2BAA0
        public void ProcessEvent(){} // RVA: 0x7FFE87E2BB60
        public void ContainsPointer(){} // RVA: 0x7FFE87E2BF30
        public void Cleanup(){} // RVA: 0x7FFE87E2C100
        public void .cctor(){} // RVA: 0x7FFE87E2C2B0
    }

    public class ClickEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F38AF0
        public void Init(){} // RVA: 0x7FFE87F38BE0
        public void LocalInit(){} // RVA: 0x7FFE87F2F6C0
        public void .ctor(){} // RVA: 0x7FFE87F38C30
        public void GetPooled(){} // RVA: 0x7FFE87F38C80
    }

    public class Clickable : PointerManipulator
    {
        public System.Action`1<UnityEngine.UIElements.EventBase> clickedWithEventInfo; // 0x38
        public System.Action clicked; // 0x40
        public long m_Delay; // 0x48
        public long m_Interval; // 0x50

        // ── Methods ──
        public void add_clickedWithEventInfo(){} // RVA: 0x7FFE87E287A0
        public void remove_clickedWithEventInfo(){} // RVA: 0x7FFE87E288A0
        public void add_clicked(){} // RVA: 0x7FFE87E289A0
        public void remove_clicked(){} // RVA: 0x7FFE87E28A90
        public void get_active(){} // RVA: 0x7FFE813A1140
        public void set_active(){} // RVA: 0x7FFE819E83C0
        public void get_lastMousePosition(){} // RVA: 0x7FFE87E28B80
        public void set_lastMousePosition(){} // RVA: 0x7FFE8671A630
        public void get_acceptClicksIfDisabled(){} // RVA: 0x7FFE811C3570
        public void set_acceptClicksIfDisabled(){} // RVA: 0x7FFE87E28BA0
        public void get_invokePolicy(){} // RVA: 0x7FFE87E28BF0
        public void .ctor(){} // RVA: 0x7FFE87E28DA0 | overloaded x3
        public void OnTimer(){} // RVA: 0x7FFE87E28F10
        public void IsRepeatable(){} // RVA: 0x7FFE87E29010
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFE87E29030
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFE87E29530
        public void OnMouseDown(){} // RVA: 0x7FFE87E29A60
        public void OnMouseMove(){} // RVA: 0x7FFE87E29B50
        public void OnMouseUp(){} // RVA: 0x7FFE87E29BD0
        public void OnMouseCaptureOut(){} // RVA: 0x7FFE87E29D00
        public void OnPointerDown(){} // RVA: 0x7FFE87E29D90
        public void OnPointerMove(){} // RVA: 0x7FFE87E29F20
        public void OnPointerUp(){} // RVA: 0x7FFE87E2A080
        public void OnPointerCancel(){} // RVA: 0x7FFE87E2A240
        public void OnPointerCaptureOut(){} // RVA: 0x7FFE87E2A360
        public void ContainsPointer(){} // RVA: 0x7FFE87E2A440
        public void IsNotMouseEvent(){} // RVA: 0x7FFE87E2A4D0
        public void Invoke(){} // RVA: 0x7FFE87E2A530
        public void SimulateSingleClick(){} // RVA: 0x7FFE87E2A580
        public void ProcessDownEvent(){} // RVA: 0x7FFE87E2A6C0
        public void ProcessMoveEvent(){} // RVA: 0x7FFE87E2AA80
        public void ProcessUpEvent(){} // RVA: 0x7FFE87E2AAF0
        public void ProcessCancelEvent(){} // RVA: 0x7FFE87E2ACE0
        public void <SimulateSingleClick>b__43_0(){} // RVA: 0x7FFE87E2AE60
    }

    public class CollectionViewController : Object
    {
        public UnityEngine.UIElements.BaseVerticalCollectionView m_View; // 0x10
        public System.Collections.IList m_ItemsSource; // 0x18

        // ── Methods ──
        public void add_itemsSourceChanged(){} // RVA: 0x7FFE87E32450
        public void remove_itemsSourceChanged(){} // RVA: 0x7FFE87E32540
        public void add_itemIndexChanged(){} // RVA: 0x7FFE87E32630
        public void remove_itemIndexChanged(){} // RVA: 0x7FFE87E32730
        public void get_itemsSource(){} // RVA: 0x7FFE810FE7C0
        public void set_itemsSource(){} // RVA: 0x7FFE87E32830
        public void SetItemsSourceWithoutNotify(){} // RVA: 0x7FFE81161E80
        public void get_view(){} // RVA: 0x7FFE81116380
        public void SetView(){} // RVA: 0x7FFE87E32920
        public void PrepareView(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE87E32A10
        public void GetItemsCount(){} // RVA: 0x7FFE87E32B10
        public void GetItemsMinCount(){} // RVA: 0x7FFE8125C1C0
        public void GetIndexForId(){} // RVA: 0x7FFE841063D0
        public void GetIdForIndex(){} // RVA: 0x7FFE841063D0
        public void GetItemForIndex(){} // RVA: 0x7FFE87E32B70
        public void InvokeMakeItem(){} // RVA: 0x7FFE87E32C10
        public void InvokeBindItem(){} // RVA: 0x7FFE87E32C60
        public void InvokeUnbindItem(){} // RVA: 0x7FFE87E32D40
        public void InvokeDestroyItem(){} // RVA: 0x7FFE87E32D80
        public void MakeItem(){} // RVA: 0x7FFE80E2E2E0
        public void BindItem(){} // RVA: 0x7FFE80E4D070
        public void UnbindItem(){} // RVA: 0x7FFE80E4D070
        public void DestroyItem(){} // RVA: 0x7FFE80E460A0
        public void RaiseItemsSourceChanged(){} // RVA: 0x7FFE8148FC70
        public void RaiseItemIndexChanged(){} // RVA: 0x7FFE87E31FA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CollectionVirtualizationController : Object
    {
        public UnityEngine.UIElements.ScrollView m_ScrollView; // 0x10
        public object field_1; // 0x6B
        public object field_2; // 0x6C

        // ── Methods ──
        public void get_firstVisibleIndex(){} // RVA: 0x7FFE80E2EDB0
        public void set_firstVisibleIndex(){} // RVA: 0x7FFE80E46530
        public void get_visibleItemCount(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Refresh(){} // RVA: 0x7FFE80E466C0
        public void ScrollToItem(){} // RVA: 0x7FFE80E46530
        public void Resize(){} // RVA: 0x7FFE80E54AE0
        public void OnScroll(){} // RVA: 0x7FFE80E54AE0
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7FFE80E431C0
        public void GetExpectedContentHeight(){} // RVA: 0x7FFE80E42E10
        public void OnFocus(){} // RVA: 0x7FFE80E460A0
        public void OnBlur(){} // RVA: 0x7FFE80E460A0
        public void UpdateBackground(){} // RVA: 0x7FFE80E45FE0
        public void get_activeItems(){} // RVA: 0x7FFE80E2E2E0
        public void StartDragItem(){} // RVA: 0x7FFE80E460A0
        public void EndDrag(){} // RVA: 0x7FFE80E46530
    }

    public class ColorPage : ValueType
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE87F72E90
        public void ToNativeColorPage(){} // RVA: 0x7FFE87F72F40
    }

    public class Column : Object
    {
        public string k_InvalidTemplateError;
        public string m_Name; // 0x10
        public string m_Title; // 0x18
        public UnityEngine.UIElements.Background m_Icon; // 0x20
        public bool m_Visible; // 0x40
        public UnityEngine.UIElements.Length m_Width; // 0x44
        public UnityEngine.UIElements.Length m_MinWidth; // 0x4C
        public UnityEngine.UIElements.Length m_MaxWidth; // 0x54
        public float m_DesiredWidth; // 0x5C
        public bool m_Stretchable; // 0x60
        public bool m_Sortable; // 0x61
        public bool m_Optional; // 0x62
        public bool m_Resizable; // 0x63
        public System.Func`1<UnityEngine.UIElements.VisualElement> m_MakeHeader; // 0x68
        public System.Action`1<UnityEngine.UIElements.VisualElement> m_BindHeader; // 0x70
        public System.Action`1<UnityEngine.UIElements.VisualElement> m_UnbindHeader; // 0x78
        public System.Action`1<UnityEngine.UIElements.VisualElement> m_DestroyHeader; // 0x80
        public System.Func`1<UnityEngine.UIElements.VisualElement> m_MakeCell; // 0x88
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> m_BindCell; // 0x90
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> m_UnbindCellItem; // 0x98
        public System.Action`1<UnityEngine.UIElements.VisualElement> _destroyCell; // 0xA0
        public UnityEngine.UIElements.Columns _collection; // 0xA8
        public System.Action`2<UnityEngine.UIElements.Column,0x66510F1C> changed; // 0xB0
        public System.Action`1<UnityEngine.UIElements.Column> resized; // 0xB8

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81116380
        public void set_name(){} // RVA: 0x7FFE87EEB730
        public void get_title(){} // RVA: 0x7FFE810FE7C0
        public void set_title(){} // RVA: 0x7FFE87EEB7F0
        public void get_icon(){} // RVA: 0x7FFE87EEB8B0
        public void get_index(){} // RVA: 0x7FFE87EEB8D0
        public void get_displayIndex(){} // RVA: 0x7FFE87EEB9C0
        public void get_visibleIndex(){} // RVA: 0x7FFE87EEBAB0
        public void get_visible(){} // RVA: 0x7FFE811B6C00
        public void set_visible(){} // RVA: 0x7FFE87EEBBA0
        public void get_width(){} // RVA: 0x7FFE86F18390
        public void set_width(){} // RVA: 0x7FFE87EEBBE0
        public void get_minWidth(){} // RVA: 0x7FFE84337910
        public void set_minWidth(){} // RVA: 0x7FFE87EEBC80
        public void get_maxWidth(){} // RVA: 0x7FFE82A2AE30
        public void set_maxWidth(){} // RVA: 0x7FFE87EEBCE0
        public void get_desiredWidth(){} // RVA: 0x7FFE81124000
        public void set_desiredWidth(){} // RVA: 0x7FFE87EEBD40
        public void get_sortable(){} // RVA: 0x7FFE81EC3970
        public void set_sortable(){} // RVA: 0x7FFE87EEBD70
        public void get_stretchable(){} // RVA: 0x7FFE81124020
        public void set_stretchable(){} // RVA: 0x7FFE87EEBDB0
        public void get_optional(){} // RVA: 0x7FFE8112FE50
        public void set_optional(){} // RVA: 0x7FFE87EEBDF0
        public void get_resizable(){} // RVA: 0x7FFE8112FE40
        public void set_resizable(){} // RVA: 0x7FFE87EEBE30
        public void get_makeHeader(){} // RVA: 0x7FFE81176D50
        public void set_makeHeader(){} // RVA: 0x7FFE87EEBE70
        public void get_bindHeader(){} // RVA: 0x7FFE811C3590
        public void get_unbindHeader(){} // RVA: 0x7FFE81463AE0
        public void get_destroyHeader(){} // RVA: 0x7FFE81280C30
        public void get_makeCell(){} // RVA: 0x7FFE8113A010
        public void set_makeCell(){} // RVA: 0x7FFE87EEBF20
        public void get_bindCell(){} // RVA: 0x7FFE8154EB60
        public void get_unbindCell(){} // RVA: 0x7FFE817AE360
        public void get_destroyCell(){} // RVA: 0x7FFE8179C860
        public void get_collection(){} // RVA: 0x7FFE817AB5E0
        public void set_collection(){} // RVA: 0x7FFE81857260
        public void add_changed(){} // RVA: 0x7FFE87EEBFE0
        public void remove_changed(){} // RVA: 0x7FFE87EEC0E0
        public void add_resized(){} // RVA: 0x7FFE87EEC1E0
        public void remove_resized(){} // RVA: 0x7FFE87EEC2E0
        public void NotifyChange(){} // RVA: 0x7FFE87EEC3E0
        public void .ctor(){} // RVA: 0x7FFE87EEC410
        public void .cctor(){} // RVA: 0x7FFE87EEC460
    }

    public class ColumnLayout : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Column> m_StretchableColumns; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Column> m_FixedColumns; // 0x18
        public UnityEngine.UIElements.Columns m_Columns; // 0x20
        public float m_ColumnsWidth; // 0x28
        public bool m_ColumnsWidthDirty; // 0x2C

        // ── Methods ──
        public void get_columns(){} // RVA: 0x7FFE811290C0
        public void get_columnsWidth(){} // RVA: 0x7FFE87EEC510
        public void get_minColumnsWidth(){} // RVA: 0x7FFE811C5630
        public void get_maxColumnsWidth(){} // RVA: 0x7FFE81284640
        public void get_hasStretchableColumns(){} // RVA: 0x7FFE87EEC720
        public void add_layoutRequested(){} // RVA: 0x7FFE87EEC770
        public void remove_layoutRequested(){} // RVA: 0x7FFE87EEC860
        public void .ctor(){} // RVA: 0x7FFE87EEC950
        public void Dirty(){} // RVA: 0x7FFE87EECE50
        public void OnColumnAdded(){} // RVA: 0x7FFE87EECF10
        public void OnColumnRemoved(){} // RVA: 0x7FFE87EED010
        public void OnColumnReordered(){} // RVA: 0x7FFE87EED110
        public void RequiresLayoutUpdate(){} // RVA: 0x7FFE87EED120
        public void OnColumnChanged(){} // RVA: 0x7FFE87EED140
        public void OnColumnResized(){} // RVA: 0x7FFE81100B70
        public void IsClamped(){} // RVA: 0x7FFE87EED170
        public void DoLayout(){} // RVA: 0x7FFE87EED180
        public void StretchResizeColumns(){} // RVA: 0x7FFE87EEDEF0
        public void ResizeToFit(){} // RVA: 0x7FFE87EEF050
        public void ResizeColumn(){} // RVA: 0x7FFE87EEF160
        public void BeginDragResize(){} // RVA: 0x7FFE87EEF2A0
        public void GetDesiredPosition(){} // RVA: 0x7FFE87EEF590
        public void GetDesiredWidth(){} // RVA: 0x7FFE87EEF710
        public void DragResize(){} // RVA: 0x7FFE87EEF7D0
        public void EndDragResize(){} // RVA: 0x7FFE87EEFA40
        public void UpdateCache(){} // RVA: 0x7FFE87EEFE20
        public void ClearCache(){} // RVA: 0x7FFE87EF0080
    }

    public class Columns : Object
    {
        public System.Collections.Generic.IList`1<UnityEngine.UIElements.Column> m_Columns; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Column> m_DisplayColumns; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Column> m_VisibleColumns; // 0x20
        public bool m_VisibleColumnsDirty; // 0x28
        public 0x66511394 m_StretchMode; // 0x2C
        public bool m_Reorderable; // 0x30
        public bool m_Resizable; // 0x31
        public bool m_ResizePreview; // 0x32
        public string m_PrimaryColumnName; // 0x38
        public System.Action`1<0x6651133C> changed; // 0x40
        public System.Action`2<UnityEngine.UIElements.Column,int> columnAdded; // 0x48

        // ── Methods ──
        public void get_primaryColumnName(){} // RVA: 0x7FFE8143BA80
        public void set_primaryColumnName(){} // RVA: 0x7FFE87EF0320
        public void get_reorderable(){} // RVA: 0x7FFE81121450
        public void set_reorderable(){} // RVA: 0x7FFE87EF03E0
        public void get_resizable(){} // RVA: 0x7FFE81121470
        public void set_resizable(){} // RVA: 0x7FFE87EF0410
        public void get_resizePreview(){} // RVA: 0x7FFE848700A0
        public void set_resizePreview(){} // RVA: 0x7FFE87EF0440
        public void get_displayList(){} // RVA: 0x7FFE87EF0470
        public void get_visibleList(){} // RVA: 0x7FFE87EF0490
        public void add_changed(){} // RVA: 0x7FFE87EF04B0
        public void remove_changed(){} // RVA: 0x7FFE87EF05B0
        public void get_stretchMode(){} // RVA: 0x7FFE81F84A50
        public void set_stretchMode(){} // RVA: 0x7FFE87EF06B0
        public void add_columnAdded(){} // RVA: 0x7FFE87EF06E0
        public void remove_columnAdded(){} // RVA: 0x7FFE87EF07E0
        public void add_columnRemoved(){} // RVA: 0x7FFE87EF08E0
        public void remove_columnRemoved(){} // RVA: 0x7FFE87EF09E0
        public void add_columnChanged(){} // RVA: 0x7FFE87EF0AE0
        public void remove_columnChanged(){} // RVA: 0x7FFE87EF0BE0
        public void add_columnResized(){} // RVA: 0x7FFE87EF0CE0
        public void remove_columnResized(){} // RVA: 0x7FFE87EF0DE0
        public void add_columnReordered(){} // RVA: 0x7FFE87EF0EE0
        public void remove_columnReordered(){} // RVA: 0x7FFE87EF0FE0
        public void IsPrimary(){} // RVA: 0x7FFE87EF10E0
        public void GetEnumerator(){} // RVA: 0x7FFE87EF1190
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87EF1190
        public void Add(){} // RVA: 0x7FFE87EF11E0
        public void Clear(){} // RVA: 0x7FFE87EF1250
        public void Contains(){} // RVA: 0x7FFE87EF14E0 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFE87EF1680
        public void Remove(){} // RVA: 0x7FFE87EF1760
        public void OnColumnChanged(){} // RVA: 0x7FFE87EF1940
        public void OnColumnResized(){} // RVA: 0x7FFE820D3100
        public void get_Count(){} // RVA: 0x7FFE87EF19A0
        public void get_IsReadOnly(){} // RVA: 0x7FFE87EF19F0
        public void IndexOf(){} // RVA: 0x7FFE87EF1A40
        public void Insert(){} // RVA: 0x7FFE87EF1B10
        public void get_Item(){} // RVA: 0x7FFE87EF1E30 | overloaded x2
        public void ReorderDisplay(){} // RVA: 0x7FFE87EF1FD0
        public void InitOrderColumns(){} // RVA: 0x7FFE87EF2150
        public void DirtyVisibleColumns(){} // RVA: 0x7FFE87EF2220
        public void UpdateVisibleColumns(){} // RVA: 0x7FFE87EF2290
        public void NotifyChange(){} // RVA: 0x7FFE85C283E0
        public void .ctor(){} // RVA: 0x7FFE87EF2560
    }

    public class CommandEventBase`1 : EventBase`1
    {
        public string m_CommandName;

        // ── Methods ──
        public void get_commandName(){} // RVA: 0x7FFE80E2E2E0
        public void set_commandName(){} // RVA: 0x7FFE80E460A0
        public void Init(){} // RVA: 0x7FFE80E45FE0
        public void LocalInit(){} // RVA: 0x7FFE80E45FE0
        public void GetPooled(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class CommandEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFE87F26080
        public void DispatchEvent(){} // RVA: 0x7FFE87F260D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ComputedStyle : ValueType
    {
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.InheritedData> inheritedData; // 0x10
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData> layoutData; // 0x18
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData> rareData; // 0x20
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData> transformData; // 0x28
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData> transitionData; // 0x30
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData> visualData; // 0x38
        public UnityEngine.Yoga.YogaNode yogaNode; // 0x40
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties; // 0x48
        public long matchingRulesHash; // 0x50
        public float dpiScaling; // 0x58
        public UnityEngine.UIElements.ComputedTransitionProperty[] computedTransitions; // 0x60
        public object StyleDataRef`1; // 0x470
        public object m_Ref;
        public object UnityEngine.UIElements;
        public object StyleDataRef`1;
        public object field_15; // 0x82C8
        public object field_16;
        public object field_17;
        public object field_18; // 0xF2F0
        public object field_19; // 0xFE80
        public object field_20; // 0x97B0
        public object field_21; // 0x97B0
        public object field_22; // 0xA330
        public object field_23; // 0xFA6
        public object field_24; // 0x2650
        public object field_25;
        public object field_26; // 0xAA08
        public object field_27;
        public object field_28; // 0x1
        public object field_29; // 0xFFFF
        public object field_30; // 0x103
        public IntPtr field_31; // 0xF420
        public object field_32; // 0xADC0
        public RefCounted<UnityEngine.UIElements.LayoutData> m_Ref; // 0x10
        public object field_34; // 0x2998
        public object UnityEngine.UIElements;
        public object field_36; // 0x240
        public object field_37; // 0xBFE8
        public object field_38; // 0xC658
        public object field_39;
        public object field_40; // 0x18
        public object field_41;
        public object field_42; // 0xB738
        public object field_43; // 0xF5F0
        public object field_44; // 0x29C0
        public object field_45; // 0x1
        public object field_46; // 0x260
        public object field_47;
        public object field_48; // 0x29D0
        public object field_49; // 0x29D0
        public object field_50;
        public object field_51; // 0x18
        public object field_52; // 0xB
        public object field_53; // 0xB310
        public object field_54; // 0xA8F8
        public object field_55; // 0x982
        public object field_56; // 0xFBD0
        public object field_57;
        public object field_58; // 0x97A1
        public object field_59;
        public object field_60; // 0xEDD0
        public object field_61; // 0x1640
        public object field_62;
        public object field_63; // 0x108
        public object field_64; // 0x1578
        public object field_65; // 0x97D0
        public object field_66; // 0x2B90
        public object field_67; // 0x1
        public object field_68; // 0x2B0
        public object field_69;
        public object StyleDataRef`1;
        public object field_71;
        public object field_72; // 0x2AD0
        public object field_73;
        public object field_74;
        public object field_75; // 0xFA80
        public object field_76; // 0x26F0
        public object field_77; // 0x97B0
        public object field_78; // 0xA3D0
        public object field_79; // 0xE880
        public object field_80; // 0x9E80
        public object field_81; // 0x75F0
        public object field_82; // 0x2B90

        // ── Methods ──
        public void get_customPropertiesCount(){} // RVA: 0x7FFE87F577A0
        public void get_hasTransition(){} // RVA: 0x7FFE87F577F0
        public void FinalizeApply(){} // RVA: 0x7FFE87F57810
        public void SyncWithLayout(){} // RVA: 0x7FFE87F579F0
        public void ApplyGlobalKeyword(){} // RVA: 0x7FFE87F588D0 | overloaded x2
        public void RemoveCustomStyleProperty(){} // RVA: 0x7FFE87F588F0
        public void ApplyCustomStyleProperty(){} // RVA: 0x7FFE87F589A0
        public void ApplyAllPropertyInitial(){} // RVA: 0x7FFE87F58BC0
        public void ResetComputedTransitions(){} // RVA: 0x7FFE812D6640
        public void StartAnimationInlineTranslate(){} // RVA: 0x7FFE87F58C60
        public void get_alignContent(){} // RVA: 0x7FFE87F58E40
        public void get_alignItems(){} // RVA: 0x7FFE87F58E90
        public void get_alignSelf(){} // RVA: 0x7FFE87F58EE0
        public void get_backgroundColor(){} // RVA: 0x7FFE87F58F30
        public void get_backgroundImage(){} // RVA: 0x7FFE87F58F90
        public void get_backgroundPositionX(){} // RVA: 0x7FFE87F58FF0
        public void get_backgroundPositionY(){} // RVA: 0x7FFE87F59050
        public void get_backgroundRepeat(){} // RVA: 0x7FFE87F590B0
        public void get_backgroundSize(){} // RVA: 0x7FFE87F59100
        public void get_borderBottomColor(){} // RVA: 0x7FFE87F59160
        public void get_borderBottomLeftRadius(){} // RVA: 0x7FFE87F591C0
        public void get_borderBottomRightRadius(){} // RVA: 0x7FFE87F59210
        public void get_borderBottomWidth(){} // RVA: 0x7FFE87F59260
        public void get_borderLeftColor(){} // RVA: 0x7FFE87F592B0
        public void get_borderLeftWidth(){} // RVA: 0x7FFE87F59310
        public void get_borderRightColor(){} // RVA: 0x7FFE87F59360
        public void get_borderRightWidth(){} // RVA: 0x7FFE87F593C0
        public void get_borderTopColor(){} // RVA: 0x7FFE87F59410
        public void get_borderTopLeftRadius(){} // RVA: 0x7FFE87F59470
        public void get_borderTopRightRadius(){} // RVA: 0x7FFE87F594C0
        public void get_borderTopWidth(){} // RVA: 0x7FFE87F59510
        public void get_bottom(){} // RVA: 0x7FFE87F59560
        public void get_color(){} // RVA: 0x7FFE87F595B0
        public void get_cursor(){} // RVA: 0x7FFE87F59610
        public void get_display(){} // RVA: 0x7FFE87F59670
        public void get_flexBasis(){} // RVA: 0x7FFE87F596C0
        public void get_flexDirection(){} // RVA: 0x7FFE87F59710
        public void get_flexGrow(){} // RVA: 0x7FFE87F59760
        public void get_flexShrink(){} // RVA: 0x7FFE87F597B0
        public void get_flexWrap(){} // RVA: 0x7FFE87F59800
        public void get_fontSize(){} // RVA: 0x7FFE87F59850
        public void get_height(){} // RVA: 0x7FFE87F598A0
        public void get_justifyContent(){} // RVA: 0x7FFE87F598F0
        public void get_left(){} // RVA: 0x7FFE87F59940
        public void get_letterSpacing(){} // RVA: 0x7FFE87F59990
        public void get_marginBottom(){} // RVA: 0x7FFE87F599E0
        public void get_marginLeft(){} // RVA: 0x7FFE87F59A30
        public void get_marginRight(){} // RVA: 0x7FFE87F59A80
        public void get_marginTop(){} // RVA: 0x7FFE87F59AD0
        public void get_maxHeight(){} // RVA: 0x7FFE87F59B20
        public void get_maxWidth(){} // RVA: 0x7FFE87F59B70
        public void get_minHeight(){} // RVA: 0x7FFE87F59BC0
        public void get_minWidth(){} // RVA: 0x7FFE87F59C10
        public void get_opacity(){} // RVA: 0x7FFE87F59C60
        public void get_overflow(){} // RVA: 0x7FFE87F59CB0
        public void get_paddingBottom(){} // RVA: 0x7FFE87F59D00
        public void get_paddingLeft(){} // RVA: 0x7FFE87F59D50
        public void get_paddingRight(){} // RVA: 0x7FFE87F59DA0
        public void get_paddingTop(){} // RVA: 0x7FFE87F59DF0
        public void get_position(){} // RVA: 0x7FFE87F59E40
        public void get_right(){} // RVA: 0x7FFE87F59E90
        public void get_rotate(){} // RVA: 0x7FFE87F59EE0
        public void get_scale(){} // RVA: 0x7FFE87F59F40
        public void get_textOverflow(){} // RVA: 0x7FFE87F59FA0
        public void get_textShadow(){} // RVA: 0x7FFE87F59FF0
        public void get_top(){} // RVA: 0x7FFE87F5A060
        public void get_transformOrigin(){} // RVA: 0x7FFE87F5A0B0
        public void get_transitionDelay(){} // RVA: 0x7FFE87F5A110
        public void get_transitionDuration(){} // RVA: 0x7FFE87F5A160
        public void get_transitionProperty(){} // RVA: 0x7FFE87F5A1B0
        public void get_transitionTimingFunction(){} // RVA: 0x7FFE87F5A200
        public void get_translate(){} // RVA: 0x7FFE87F5A250
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7FFE87F5A2B0
        public void get_unityFont(){} // RVA: 0x7FFE87F5A310
        public void get_unityFontDefinition(){} // RVA: 0x7FFE87F5A360
        public void get_unityFontStyleAndWeight(){} // RVA: 0x7FFE87F5A3C0
        public void get_unityOverflowClipBox(){} // RVA: 0x7FFE87F5A410
        public void get_unityParagraphSpacing(){} // RVA: 0x7FFE87F5A460
        public void get_unitySliceBottom(){} // RVA: 0x7FFE87F5A4B0
        public void get_unitySliceLeft(){} // RVA: 0x7FFE87F5A500
        public void get_unitySliceRight(){} // RVA: 0x7FFE87F5A550
        public void get_unitySliceScale(){} // RVA: 0x7FFE87F5A5A0
        public void get_unitySliceTop(){} // RVA: 0x7FFE87F5A5F0
        public void get_unityTextAlign(){} // RVA: 0x7FFE87F5A640
        public void get_unityTextOutlineColor(){} // RVA: 0x7FFE87F5A690
        public void get_unityTextOutlineWidth(){} // RVA: 0x7FFE87F5A6F0
        public void get_unityTextOverflowPosition(){} // RVA: 0x7FFE87F5A740
        public void get_visibility(){} // RVA: 0x7FFE87F5A790
        public void get_whiteSpace(){} // RVA: 0x7FFE87F5A7E0
        public void get_width(){} // RVA: 0x7FFE87F5A830
        public void get_wordSpacing(){} // RVA: 0x7FFE87F5A880
        public void Create(){} // RVA: 0x7FFE87F5A8D0
        public void CreateInitial(){} // RVA: 0x7FFE87F5AD80
        public void Acquire(){} // RVA: 0x7FFE87F5B520
        public void Release(){} // RVA: 0x7FFE87F5B710
        public void CopyFrom(){} // RVA: 0x7FFE87F5B800
        public void ApplyProperties(){} // RVA: 0x7FFE87F5BA20
        public void ApplyStyleValue(){} // RVA: 0x7FFE87F5CE70
        public void ApplyStyleValueManaged(){} // RVA: 0x7FFE87F5DC80
        public void ApplyStyleCursor(){} // RVA: 0x7FFE87F5E0C0
        public void ApplyStyleTextShadow(){} // RVA: 0x7FFE87F5E160
        public void ApplyFromComputedStyle(){} // RVA: 0x7FFE87F5E1D0
        public void ApplyPropertyAnimation(){} // RVA: 0x7FFE87F620E0 | overloaded x15
        public void StartAnimation(){} // RVA: 0x7FFE87F62240
        public void StartAnimationAllProperty(){} // RVA: 0x7FFE87F66030
        public void StartAnimationInline(){} // RVA: 0x7FFE87F68750
        public void ApplyStyleTransformOrigin(){} // RVA: 0x7FFE87F6B550
        public void ApplyStyleTranslate(){} // RVA: 0x7FFE87F6B5B0
        public void ApplyStyleRotate(){} // RVA: 0x7FFE87F6B610
        public void ApplyStyleScale(){} // RVA: 0x7FFE87F6B670
        public void ApplyStyleBackgroundSize(){} // RVA: 0x7FFE87F6B6D0
        public void ApplyInitialValue(){} // RVA: 0x7FFE87F6B780 | overloaded x2
        public void ApplyUnsetValue(){} // RVA: 0x7FFE87F6D960 | overloaded x2
        public void CompareChanges(){} // RVA: 0x7FFE87F6DD80
    }

    public class ComputedTransitionProperty : ValueType
    {
    }

    public class ComputedTransitionUtils : Object
    {
        // ── Methods ──
        public void UpdateComputedTransitions(){} // RVA: 0x7FFE87F7DBD0
        public void HasTransitionProperty(){} // RVA: 0x7FFE87F7DC80
        public void GetTransitionProperty(){} // RVA: 0x7FFE87F7DD50
        public void GetOrComputeTransitionPropertyData(){} // RVA: 0x7FFE87F7DE70
        public void GetTransitionHashCode(){} // RVA: 0x7FFE87F7E140
        public void SameTransitionProperty(){} // RVA: 0x7FFE87F7EE40 | overloaded x3
        public void ComputeTransitionPropertyData(){} // RVA: 0x7FFE87F7EF50
        public void GetWrappingTransitionData(){} // RVA: 0x7FFE810A1420
        public void ConvertTransitionTime(){} // RVA: 0x7FFE87F7F380
        public void ConvertTransitionFunction(){} // RVA: 0x7FFE87F7F3B0
        public void .cctor(){} // RVA: 0x7FFE87F805E0
    }

    public class ContextClickEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F302A0
        public void .ctor(){} // RVA: 0x7FFE87F30390
    }

    public class ContextualMenuManager : Object
    {
        public bool _displayMenuHandledOSX; // 0x10

        // ── Methods ──
        public void get_displayMenuHandledOSX(){} // RVA: 0x7FFE811C55E0
        public void set_displayMenuHandledOSX(){} // RVA: 0x7FFE811C55F0
        public void DisplayMenuIfEventMatches(){} // RVA: 0x7FFE80E4F230
        public void DisplayMenu(){} // RVA: 0x7FFE87E37020
        public void DoDisplayMenu(){} // RVA: 0x7FFE80E4F230
    }

    public class ContextualMenuManipulator : MouseManipulator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E373D0
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFE87E37690
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFE87E379B0
        public void OnMouseUpDownEvent(){} // RVA: 0x7FFE87E37D00
        public void OnMouseDownEventOSX(){} // RVA: 0x7FFE87E37DF0
        public void OnMouseUpEventOSX(){} // RVA: 0x7FFE87E37E50
        public void OnKeyUpEvent(){} // RVA: 0x7FFE87E37EB0
        public void DoDisplayMenu(){} // RVA: 0x7FFE87E37F50
        public void OnContextualMenuEvent(){} // RVA: 0x7FFE819208B0
    }

    public class ContextualMenuPopulateEvent : MouseEventBase`1
    {
        public UnityEngine.UIElements.DropdownMenu _menu; // 0xC0
        public UnityEngine.UIElements.EventBase _triggerEvent; // 0xC8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F32070
        public void get_menu(){} // RVA: 0x7FFE81166120
        public void set_menu(){} // RVA: 0x7FFE81166130
        public void get_triggerEvent(){} // RVA: 0x7FFE81253460
        public void set_triggerEvent(){} // RVA: 0x7FFE81253470
        public void GetPooled(){} // RVA: 0x7FFE87F32160
        public void Init(){} // RVA: 0x7FFE87F326F0
        public void LocalInit(){} // RVA: 0x7FFE87F327C0
        public void .ctor(){} // RVA: 0x7FFE87F32920
        public void PostDispatch(){} // RVA: 0x7FFE87F32970
    }

    public class CountingBloomFilter : ValueType
    {
        // ── Methods ──
        public void AdjustSlot(){} // RVA: 0x7FFE87F12830
        public void Hash1(){} // RVA: 0x7FFE87F12860
        public void Hash2(){} // RVA: 0x7FFE87F12870
        public void IsSlotEmpty(){} // RVA: 0x7FFE87F12880
        public void InsertHash(){} // RVA: 0x7FFE87F12890
        public void RemoveHash(){} // RVA: 0x7FFE87F128C0
        public void ContainsHash(){} // RVA: 0x7FFE87F128F0
    }

    public class CreationContext : ValueType
    {
        public UnityEngine.UIElements.CreationContext Default;
        public UnityEngine.UIElements.VisualElement _target; // 0x10
        public UnityEngine.UIElements.VisualTreeAsset _visualTreeAsset; // 0x18
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.UIElements.VisualElement> _slotInsertionPoints; // 0x20

        // ── Methods ──
        public void get_target(){} // RVA: 0x7FFE8284EF60
        public void set_target(){} // RVA: 0x7FFE81D7E9E0
        public void get_visualTreeAsset(){} // RVA: 0x7FFE826F4210
        public void set_visualTreeAsset(){} // RVA: 0x7FFE826F4230
        public void get_slotInsertionPoints(){} // RVA: 0x7FFE81116380
        public void set_slotInsertionPoints(){} // RVA: 0x7FFE810FCE30
        public void get_attributeOverrides(){} // RVA: 0x7FFE810FE7C0
        public void set_attributeOverrides(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE87E65BC0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE87E65E40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87E65FC0
        public void .cctor(){} // RVA: 0x7FFE87E66100
    }

    public class Cursor : ValueType
    {
        public UnityEngine.Texture2D _texture; // 0x10
        public UnityEngine.Vector2 _hotspot; // 0x18
        public int _defaultCursorId; // 0x20

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFE8284EF60
        public void set_texture(){} // RVA: 0x7FFE81D7E9E0
        public void get_hotspot(){} // RVA: 0x7FFE8445ABF0
        public void set_hotspot(){} // RVA: 0x7FFE82C72B10
        public void get_defaultCursorId(){} // RVA: 0x7FFE811485C0
        public void set_defaultCursorId(){} // RVA: 0x7FFE810FE0C0
        public void Equals(){} // RVA: 0x7FFE87F13010 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87F130C0
        public void op_Equality(){} // RVA: 0x7FFE87F131A0
        public void ToString(){} // RVA: 0x7FFE87F131D0
    }

    public class CursorManager : Object
    {
        public bool _isCursorOverriden; // 0x10

        // ── Methods ──
        public void get_isCursorOverriden(){} // RVA: 0x7FFE811C55E0
        public void set_isCursorOverriden(){} // RVA: 0x7FFE811C55F0
        public void SetCursor(){} // RVA: 0x7FFE87F13290
        public void ResetCursor(){} // RVA: 0x7FFE87F134B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CustomStyleProperty`1 : ValueType
    {
        public string _name;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE80E2E2E0
        public void set_name(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Equals(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
    }

    public class CustomStyleResolvedEvent : EventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F3A0D0
        public void get_customStyle(){} // RVA: 0x7FFE87F3A1C0
        public void .ctor(){} // RVA: 0x7FFE87F3A250
    }

}