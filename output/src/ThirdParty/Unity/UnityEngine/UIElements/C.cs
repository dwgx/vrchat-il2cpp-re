// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 28
// Methods: 485

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class CallbackEventHandler : Object
    {
        public bool isIMGUIContainer; // 0x10
        public UnityEngine.UIElements.EventCallbackRegistry m_CallbackRegistry; // 0x18
        public string ExecuteDefaultActionName;
        public string ExecuteDefaultActionAtTargetName;

        // ── Methods ──
        public void RegisterCallback(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void AddEventCategories(){} // RVA: 0x7FFAC2C70980
        public void UnregisterCallback(){} // RVA: 0x7FFAC2C77970
        public void SendEvent(){} // RVA: 0x7FFAC2C77970 | overloaded x2
        public void HandleEventAtTargetPhase(){} // RVA: 0x7FFAC9B81AB0
        public void HandleEventAtTargetAndDefaultPhase(){} // RVA: 0x7FFAC9B81B30
        public void HandleEventAtCurrentTargetAndPhase(){} // RVA: 0x7FFAC69A3D80
        public void UnityEngine.UIElements.IEventHandler.HandleEvent(){} // RVA: 0x7FFAC69A3D80
        public void HandleEvent(){} // RVA: 0x7FFAC9B81BE0
        public void HasTrickleDownHandlers(){} // RVA: 0x7FFAC9B81F00
        public void HasBubbleUpHandlers(){} // RVA: 0x7FFAC9B81F30
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFAC2F21310
        public void ExecuteDefaultAction(){} // RVA: 0x7FFAC2F21310
        public void ExecuteDefaultActionDisabledAtTarget(){} // RVA: 0x7FFAC2F21310
        public void ExecuteDefaultActionDisabled(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC322C880
    }

    public class CanStartDragArgs : ValueType
    {
        public UnityEngine.UIElements.VisualElement draggedElement; // 0x10
        public int id; // 0x18
        public System.Collections.Generic.IEnumerable`1<int> selectedIds; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC68C66B0
    }

    public class ChangeEvent`1 : EventBase`1
    {
        public T previousValue;
        public T newValue;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void get_previousValue(){} // RVA: 0x7FFAC2E8DC40
        public void set_previousValue(){} // RVA: 0x7FFAC2E8DC40
        public void get_newValue(){} // RVA: 0x7FFAC2E8DC40
        public void set_newValue(){} // RVA: 0x7FFAC2E8DC40
        public void Init(){} // RVA: 0x7FFAC2C70980
        public void LocalInit(){} // RVA: 0x7FFAC2C70980
        public void GetPooled(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ClampedDragger`1 : Clickable
    {
        public System.Action dragDirection;
        public System.Action slider;
        public 0x6B1144D8<T> startMousePosition;
        public UnityEngine.UIElements.BaseSlider`1<T> delta;
        public UnityEngine.Vector2 <startMousePosition>k__BackingField;

        // ── Methods ──
        public void add_dragging(){} // RVA: 0x7FFAC2C70A40
        public void remove_dragging(){} // RVA: 0x7FFAC2C70A40
        public void add_draggingEnded(){} // RVA: 0x7FFAC2C70A40
        public void remove_draggingEnded(){} // RVA: 0x7FFAC2C70A40
        public void get_dragDirection(){} // RVA: 0x7FFAC2E8DC40
        public void set_dragDirection(){} // RVA: 0x7FFAC2E8DC40
        public void set_slider(){} // RVA: 0x7FFAC2C70A40
        public void get_startMousePosition(){} // RVA: 0x7FFAC2C58E90
        public void set_startMousePosition(){} // RVA: 0x7FFAC2C7F3E0
        public void get_delta(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void ProcessDownEvent(){}
        public void ProcessUpEvent(){}
        public void ProcessMoveEvent(){}
    }

    public class ClickDetector : Object
    {
        public System.Collections.Generic.List`1<ButtonClickStatus> s_DoubleClickTime; // 0x10
        public int <s_DoubleClickTime>k__BackingField;

        // ── Methods ──
        public void get_s_DoubleClickTime(){} // RVA: 0x7FFAC9A825F0
        public void set_s_DoubleClickTime(){} // RVA: 0x7FFAC9A82650
        public void .ctor(){} // RVA: 0x7FFAC9A826B0
        public void StartClickTracking(){} // RVA: 0x7FFAC9A82990
        public void SendClickEvent(){} // RVA: 0x7FFAC9A82BB0
        public void CancelClickTracking(){} // RVA: 0x7FFAC9A83200
        public void ProcessEvent(){} // RVA: 0x7FFAC9A832C0
        public void ContainsPointer(){} // RVA: 0x7FFAC9A83690
        public void Cleanup(){} // RVA: 0x7FFAC9A83860
        public void .cctor(){} // RVA: 0x7FFAC9A83A10
    }

    public class ClickEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B90240
        public void Init(){} // RVA: 0x7FFAC9B90330
        public void LocalInit(){} // RVA: 0x7FFAC9B86E10
        public void .ctor(){} // RVA: 0x7FFAC9B90380
        public void GetPooled(){} // RVA: 0x7FFAC9B903D0
    }

    public class Clickable : PointerManipulator
    {
        public System.Action`1<UnityEngine.UIElements.EventBase> active; // 0x38
        public System.Action lastMousePosition; // 0x40
        public long acceptClicksIfDisabled; // 0x48
        public long invokePolicy; // 0x50
        public bool <active>k__BackingField; // 0x58
        public UnityEngine.Vector2 <lastMousePosition>k__BackingField; // 0x5C
        public int m_ActivePointerId; // 0x64
        public bool m_AcceptClicksIfDisabled; // 0x68
        public UnityEngine.UIElements.IVisualElementScheduledItem m_Repeater; // 0x70

        // ── Methods ──
        public void add_clickedWithEventInfo(){} // RVA: 0x7FFAC9A7FF00
        public void remove_clickedWithEventInfo(){} // RVA: 0x7FFAC9A80000
        public void add_clicked(){} // RVA: 0x7FFAC9A80100
        public void remove_clicked(){} // RVA: 0x7FFAC9A801F0
        public void get_active(){} // RVA: 0x7FFAC313F600
        public void set_active(){} // RVA: 0x7FFAC3892770
        public void get_lastMousePosition(){} // RVA: 0x7FFAC9A802E0
        public void set_lastMousePosition(){} // RVA: 0x7FFAC8370D30
        public void get_acceptClicksIfDisabled(){} // RVA: 0x7FFAC2FE9570
        public void set_acceptClicksIfDisabled(){} // RVA: 0x7FFAC9A80300
        public void get_invokePolicy(){} // RVA: 0x7FFAC9A80350
        public void .ctor(){} // RVA: 0x7FFAC9A80500 | overloaded x3
        public void OnTimer(){} // RVA: 0x7FFAC9A80670
        public void IsRepeatable(){} // RVA: 0x7FFAC9A80770
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFAC9A80790
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFAC9A80C90
        public void OnMouseDown(){} // RVA: 0x7FFAC9A811C0
        public void OnMouseMove(){} // RVA: 0x7FFAC9A812B0
        public void OnMouseUp(){} // RVA: 0x7FFAC9A81330
        public void OnMouseCaptureOut(){} // RVA: 0x7FFAC9A81460
        public void OnPointerDown(){} // RVA: 0x7FFAC9A814F0
        public void OnPointerMove(){} // RVA: 0x7FFAC9A81680
        public void OnPointerUp(){} // RVA: 0x7FFAC9A817E0
        public void OnPointerCancel(){} // RVA: 0x7FFAC9A819A0
        public void OnPointerCaptureOut(){} // RVA: 0x7FFAC9A81AC0
        public void ContainsPointer(){} // RVA: 0x7FFAC9A81BA0
        public void IsNotMouseEvent(){} // RVA: 0x7FFAC9A81C30
        public void Invoke(){} // RVA: 0x7FFAC9A81C90
        public void SimulateSingleClick(){} // RVA: 0x7FFAC9A81CE0
        public void ProcessDownEvent(){} // RVA: 0x7FFAC9A81E20
        public void ProcessMoveEvent(){} // RVA: 0x7FFAC9A821E0
        public void ProcessUpEvent(){} // RVA: 0x7FFAC9A82250
        public void ProcessCancelEvent(){} // RVA: 0x7FFAC9A82440
        public void <SimulateSingleClick>b__43_0(){} // RVA: 0x7FFAC9A825C0
    }

    public class CollectionViewController : Object
    {
        public UnityEngine.UIElements.BaseVerticalCollectionView itemsSource; // 0x10
        public System.Collections.IList view; // 0x18
        public System.Action itemsSourceChanged; // 0x20
        public System.Action`2<int,int> itemIndexChanged; // 0x28

        // ── Methods ──
        public void add_itemsSourceChanged(){} // RVA: 0x7FFAC9A89BB0
        public void remove_itemsSourceChanged(){} // RVA: 0x7FFAC9A89CA0
        public void add_itemIndexChanged(){} // RVA: 0x7FFAC9A89D90
        public void remove_itemIndexChanged(){} // RVA: 0x7FFAC9A89E90
        public void get_itemsSource(){} // RVA: 0x7FFAC2F247C0
        public void set_itemsSource(){} // RVA: 0x7FFAC9A89F90
        public void SetItemsSourceWithoutNotify(){} // RVA: 0x7FFAC2F87E80
        public void get_view(){} // RVA: 0x7FFAC2F3C380
        public void SetView(){} // RVA: 0x7FFAC9A8A080
        public void PrepareView(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC9A8A170
        public void GetItemsCount(){} // RVA: 0x7FFAC9A8A270
        public void GetItemsMinCount(){} // RVA: 0x7FFAC30821C0
        public void GetIndexForId(){} // RVA: 0x7FFAC5D9E3E0
        public void GetIdForIndex(){} // RVA: 0x7FFAC5D9E3E0
        public void GetItemForIndex(){} // RVA: 0x7FFAC9A8A2D0
        public void InvokeMakeItem(){} // RVA: 0x7FFAC9A8A370
        public void InvokeBindItem(){} // RVA: 0x7FFAC9A8A3C0
        public void InvokeUnbindItem(){} // RVA: 0x7FFAC9A8A4A0
        public void InvokeDestroyItem(){} // RVA: 0x7FFAC9A8A4E0
        public void MakeItem(){} // RVA: 0x7FFAC2C58E90
        public void BindItem(){} // RVA: 0x7FFAC2C77970
        public void UnbindItem(){} // RVA: 0x7FFAC2C77970
        public void DestroyItem(){} // RVA: 0x7FFAC2C70A40
        public void RaiseItemsSourceChanged(){} // RVA: 0x7FFAC32032C0
        public void RaiseItemIndexChanged(){} // RVA: 0x7FFAC9A89700
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CollectionVirtualizationController : Object
    {
        public UnityEngine.UIElements.ScrollView firstVisibleIndex; // 0x10

        // ── Methods ──
        public void get_firstVisibleIndex(){} // RVA: 0x7FFAC2C59960
        public void set_firstVisibleIndex(){} // RVA: 0x7FFAC2C70ED0
        public void get_visibleItemCount(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Refresh(){} // RVA: 0x7FFAC2C71060
        public void ScrollToItem(){} // RVA: 0x7FFAC2C70ED0
        public void Resize(){} // RVA: 0x7FFAC2C7F3E0
        public void OnScroll(){} // RVA: 0x7FFAC2C7F3E0
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7FFAC2C6DC30
        public void GetExpectedContentHeight(){} // RVA: 0x7FFAC2C6D880
        public void OnFocus(){} // RVA: 0x7FFAC2C70A40
        public void OnBlur(){} // RVA: 0x7FFAC2C70A40
        public void UpdateBackground(){} // RVA: 0x7FFAC2C70980
        public void get_activeItems(){} // RVA: 0x7FFAC2C58E90
        public void StartDragItem(){} // RVA: 0x7FFAC2C70A40
        public void EndDrag(){} // RVA: 0x7FFAC2C70ED0
    }

    public class ColorPage : ValueType
    {
        public bool isValid; // 0x10
        public UnityEngine.Color32 pageAndID; // 0x14

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC9BCA5E0
        public void ToNativeColorPage(){} // RVA: 0x7FFAC9BCA690
    }

    public class Column : Object
    {
        public string name;
        public string title; // 0x10
        public string icon; // 0x18
        public UnityEngine.UIElements.Background index; // 0x20
        public bool displayIndex; // 0x40
        public UnityEngine.UIElements.Length visibleIndex; // 0x44
        public UnityEngine.UIElements.Length visible; // 0x4C
        public UnityEngine.UIElements.Length width; // 0x54
        public float minWidth; // 0x5C
        public bool maxWidth; // 0x60
        public bool desiredWidth; // 0x61
        public bool sortable; // 0x62
        public bool stretchable; // 0x63
        public System.Func`1<UnityEngine.UIElements.VisualElement> optional; // 0x68
        public System.Action`1<UnityEngine.UIElements.VisualElement> resizable; // 0x70
        public System.Action`1<UnityEngine.UIElements.VisualElement> makeHeader; // 0x78
        public System.Action`1<UnityEngine.UIElements.VisualElement> bindHeader; // 0x80
        public System.Func`1<UnityEngine.UIElements.VisualElement> unbindHeader; // 0x88
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> destroyHeader; // 0x90
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> makeCell; // 0x98
        public System.Action`1<UnityEngine.UIElements.VisualElement> bindCell; // 0xA0
        public UnityEngine.UIElements.Columns unbindCell; // 0xA8
        public System.Action`2<UnityEngine.UIElements.Column,0x6B117FF8> destroyCell; // 0xB0
        public System.Action`1<UnityEngine.UIElements.Column> collection; // 0xB8

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F3C380
        public void set_name(){} // RVA: 0x7FFAC9B42E90
        public void get_title(){} // RVA: 0x7FFAC2F247C0
        public void set_title(){} // RVA: 0x7FFAC9B42F50
        public void get_icon(){} // RVA: 0x7FFAC9B43010
        public void get_index(){} // RVA: 0x7FFAC9B43030
        public void get_displayIndex(){} // RVA: 0x7FFAC9B43120
        public void get_visibleIndex(){} // RVA: 0x7FFAC9B43210
        public void get_visible(){} // RVA: 0x7FFAC2FDCC00
        public void set_visible(){} // RVA: 0x7FFAC9B43300
        public void get_width(){} // RVA: 0x7FFAC8B6ED10
        public void set_width(){} // RVA: 0x7FFAC9B43340
        public void get_minWidth(){} // RVA: 0x7FFAC5FE03C0
        public void set_minWidth(){} // RVA: 0x7FFAC9B433E0
        public void get_maxWidth(){} // RVA: 0x7FFAC47C2A90
        public void set_maxWidth(){} // RVA: 0x7FFAC9B43440
        public void get_desiredWidth(){} // RVA: 0x7FFAC2F4A000
        public void set_desiredWidth(){} // RVA: 0x7FFAC9B434A0
        public void get_sortable(){} // RVA: 0x7FFAC3C11000
        public void set_sortable(){} // RVA: 0x7FFAC9B434D0
        public void get_stretchable(){} // RVA: 0x7FFAC2F4A020
        public void set_stretchable(){} // RVA: 0x7FFAC9B43510
        public void get_optional(){} // RVA: 0x7FFAC2F55E50
        public void set_optional(){} // RVA: 0x7FFAC9B43550
        public void get_resizable(){} // RVA: 0x7FFAC2F55E40
        public void set_resizable(){} // RVA: 0x7FFAC9B43590
        public void get_makeHeader(){} // RVA: 0x7FFAC2F9CD50
        public void set_makeHeader(){} // RVA: 0x7FFAC9B435D0
        public void get_bindHeader(){} // RVA: 0x7FFAC2FE9590
        public void get_unbindHeader(){} // RVA: 0x7FFAC30E5600
        public void get_destroyHeader(){} // RVA: 0x7FFAC32EF410
        public void get_makeCell(){} // RVA: 0x7FFAC2F60010
        public void set_makeCell(){} // RVA: 0x7FFAC9B43680
        public void get_bindCell(){} // RVA: 0x7FFAC32EF640
        public void get_unbindCell(){} // RVA: 0x7FFAC354DFB0
        public void get_destroyCell(){} // RVA: 0x7FFAC3543900
        public void get_collection(){} // RVA: 0x7FFAC354B1A0
        public void set_collection(){} // RVA: 0x7FFAC334B370
        public void add_changed(){} // RVA: 0x7FFAC9B43740
        public void remove_changed(){} // RVA: 0x7FFAC9B43840
        public void add_resized(){} // RVA: 0x7FFAC9B43940
        public void remove_resized(){} // RVA: 0x7FFAC9B43A40
        public void NotifyChange(){} // RVA: 0x7FFAC9B43B40
        public void .ctor(){} // RVA: 0x7FFAC9B43B70
        public void .cctor(){} // RVA: 0x7FFAC9B43BC0
    }

    public class ColumnLayout : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Column> columns; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Column> columnsWidth; // 0x18
        public UnityEngine.UIElements.Columns minColumnsWidth; // 0x20
        public float maxColumnsWidth; // 0x28
        public bool hasStretchableColumns; // 0x2C
        public float m_MaxColumnsWidth; // 0x30
        public float m_MinColumnsWidth; // 0x34
        public bool m_IsDirty; // 0x38
        public float m_PreviousWidth; // 0x3C
        public bool m_DragResizeInPreviewMode; // 0x40
        public bool m_DragResizing; // 0x41
        public float m_DragStartPos; // 0x44
        public float m_DragLastPos; // 0x48
        public float m_DragInitialColumnWidth; // 0x4C
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Column> m_DragStretchableColumns; // 0x50
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Column> m_DragFixedColumns; // 0x58
        public System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.Column,float> m_PreviewDesiredWidths; // 0x60
        public System.Action layoutRequested; // 0x68

        // ── Methods ──
        public void get_columns(){} // RVA: 0x7FFAC2F4F0C0
        public void get_columnsWidth(){} // RVA: 0x7FFAC9B43C70
        public void get_minColumnsWidth(){} // RVA: 0x7FFAC2FEB630
        public void get_maxColumnsWidth(){} // RVA: 0x7FFAC3C40670
        public void get_hasStretchableColumns(){} // RVA: 0x7FFAC9B43E80
        public void add_layoutRequested(){} // RVA: 0x7FFAC9B43ED0
        public void remove_layoutRequested(){} // RVA: 0x7FFAC9B43FC0
        public void .ctor(){} // RVA: 0x7FFAC9B440B0
        public void Dirty(){} // RVA: 0x7FFAC9B445B0
        public void OnColumnAdded(){} // RVA: 0x7FFAC9B44670
        public void OnColumnRemoved(){} // RVA: 0x7FFAC9B44770
        public void OnColumnReordered(){} // RVA: 0x7FFAC9B44870
        public void RequiresLayoutUpdate(){} // RVA: 0x7FFAC9B44880
        public void OnColumnChanged(){} // RVA: 0x7FFAC9B448A0
        public void OnColumnResized(){} // RVA: 0x7FFAC2F26B70
        public void IsClamped(){} // RVA: 0x7FFAC9B448D0
        public void DoLayout(){} // RVA: 0x7FFAC9B448E0
        public void StretchResizeColumns(){} // RVA: 0x7FFAC9B45650
        public void ResizeToFit(){} // RVA: 0x7FFAC9B467B0
        public void ResizeColumn(){} // RVA: 0x7FFAC9B468C0
        public void BeginDragResize(){} // RVA: 0x7FFAC9B46A00
        public void GetDesiredPosition(){} // RVA: 0x7FFAC9B46CF0
        public void GetDesiredWidth(){} // RVA: 0x7FFAC9B46E70
        public void DragResize(){} // RVA: 0x7FFAC9B46F30
        public void EndDragResize(){} // RVA: 0x7FFAC9B471A0
        public void UpdateCache(){} // RVA: 0x7FFAC9B47580
        public void ClearCache(){} // RVA: 0x7FFAC9B477E0
    }

    public class Columns : Object
    {
        public System.Collections.Generic.IList`1<UnityEngine.UIElements.Column> primaryColumnName; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Column> reorderable; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Column> resizable; // 0x20
        public bool resizePreview; // 0x28
        public 0x6B118470 displayList; // 0x2C
        public bool visibleList; // 0x30
        public bool stretchMode; // 0x31
        public bool Count; // 0x32
        public string IsReadOnly; // 0x38
        public System.Action`1<0x6B118418> Item; // 0x40
        public System.Action`2<UnityEngine.UIElements.Column,int> Item; // 0x48
        public System.Action`1<UnityEngine.UIElements.Column> columnRemoved; // 0x50
        public System.Action`2<UnityEngine.UIElements.Column,0x6B117FF8> columnChanged; // 0x58
        public System.Action`1<UnityEngine.UIElements.Column> columnResized; // 0x60
        public System.Action`3<UnityEngine.UIElements.Column,int,int> columnReordered; // 0x68

        // ── Methods ──
        public void get_primaryColumnName(){} // RVA: 0x7FFAC31D0140
        public void set_primaryColumnName(){} // RVA: 0x7FFAC9B47A80
        public void get_reorderable(){} // RVA: 0x7FFAC2F47450
        public void set_reorderable(){} // RVA: 0x7FFAC9B47B40
        public void get_resizable(){} // RVA: 0x7FFAC2F47470
        public void set_resizable(){} // RVA: 0x7FFAC9B47B70
        public void get_resizePreview(){} // RVA: 0x7FFAC64EB050
        public void set_resizePreview(){} // RVA: 0x7FFAC9B47BA0
        public void get_displayList(){} // RVA: 0x7FFAC9B47BD0
        public void get_visibleList(){} // RVA: 0x7FFAC9B47BF0
        public void add_changed(){} // RVA: 0x7FFAC9B47C10
        public void remove_changed(){} // RVA: 0x7FFAC9B47D10
        public void get_stretchMode(){} // RVA: 0x7FFAC3C891D0
        public void set_stretchMode(){} // RVA: 0x7FFAC9B47E10
        public void add_columnAdded(){} // RVA: 0x7FFAC9B47E40
        public void remove_columnAdded(){} // RVA: 0x7FFAC9B47F40
        public void add_columnRemoved(){} // RVA: 0x7FFAC9B48040
        public void remove_columnRemoved(){} // RVA: 0x7FFAC9B48140
        public void add_columnChanged(){} // RVA: 0x7FFAC9B48240
        public void remove_columnChanged(){} // RVA: 0x7FFAC9B48340
        public void add_columnResized(){} // RVA: 0x7FFAC9B48440
        public void remove_columnResized(){} // RVA: 0x7FFAC9B48540
        public void add_columnReordered(){} // RVA: 0x7FFAC9B48640
        public void remove_columnReordered(){} // RVA: 0x7FFAC9B48740
        public void IsPrimary(){} // RVA: 0x7FFAC9B48840
        public void GetEnumerator(){} // RVA: 0x7FFAC9B488F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9B488F0
        public void Add(){} // RVA: 0x7FFAC9B48940
        public void Clear(){} // RVA: 0x7FFAC9B489B0
        public void Contains(){} // RVA: 0x7FFAC9B48C40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAC9B48DE0
        public void Remove(){} // RVA: 0x7FFAC9B48EC0
        public void OnColumnChanged(){} // RVA: 0x7FFAC9B490A0
        public void OnColumnResized(){} // RVA: 0x7FFAC3E75B70
        public void get_Count(){} // RVA: 0x7FFAC9B49100
        public void get_IsReadOnly(){} // RVA: 0x7FFAC9B49150
        public void IndexOf(){} // RVA: 0x7FFAC9B491A0
        public void Insert(){} // RVA: 0x7FFAC9B49270
        public void get_Item(){} // RVA: 0x7FFAC9B49590 | overloaded x2
        public void ReorderDisplay(){} // RVA: 0x7FFAC9B49730
        public void InitOrderColumns(){} // RVA: 0x7FFAC9B498B0
        public void DirtyVisibleColumns(){} // RVA: 0x7FFAC9B49980
        public void UpdateVisibleColumns(){} // RVA: 0x7FFAC9B499F0
        public void NotifyChange(){} // RVA: 0x7FFAC7870F30
        public void .ctor(){} // RVA: 0x7FFAC9B49CC0
    }

    public class CommandEventBase`1 : EventBase`1
    {
        public string commandName;

        // ── Methods ──
        public void get_commandName(){} // RVA: 0x7FFAC2C58E90
        public void set_commandName(){} // RVA: 0x7FFAC2C70A40
        public void Init(){} // RVA: 0x7FFAC2C70980
        public void LocalInit(){} // RVA: 0x7FFAC2C70980
        public void GetPooled(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class CommandEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFAC9B7D7D0
        public void DispatchEvent(){} // RVA: 0x7FFAC9B7D820
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ComputedStyle : ValueType
    {
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.InheritedData> customPropertiesCount; // 0x10
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData> hasTransition; // 0x18
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData> alignContent; // 0x20
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData> alignItems; // 0x28
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData> alignSelf; // 0x30
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData> backgroundColor; // 0x38
        public UnityEngine.Yoga.YogaNode backgroundImage; // 0x40
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.UIElements.StyleSheets.StylePropertyValue> backgroundPositionX; // 0x48
        public long backgroundPositionY; // 0x50
        public float backgroundRepeat; // 0x58
        public UnityEngine.UIElements.ComputedTransitionProperty[] backgroundSize; // 0x60

        // ── Methods ──
        public void get_customPropertiesCount(){} // RVA: 0x7FFAC9BAEEF0
        public void get_hasTransition(){} // RVA: 0x7FFAC9BAEF40
        public void FinalizeApply(){} // RVA: 0x7FFAC9BAEF60
        public void SyncWithLayout(){} // RVA: 0x7FFAC9BAF140
        public void ApplyGlobalKeyword(){} // RVA: 0x7FFAC9BB0020 | overloaded x2
        public void RemoveCustomStyleProperty(){} // RVA: 0x7FFAC9BB0040
        public void ApplyCustomStyleProperty(){} // RVA: 0x7FFAC9BB00F0
        public void ApplyAllPropertyInitial(){} // RVA: 0x7FFAC9BB0310
        public void ResetComputedTransitions(){} // RVA: 0x7FFAC44CE0C0
        public void StartAnimationInlineTranslate(){} // RVA: 0x7FFAC9BB03B0
        public void get_alignContent(){} // RVA: 0x7FFAC9BB0590
        public void get_alignItems(){} // RVA: 0x7FFAC9BB05E0
        public void get_alignSelf(){} // RVA: 0x7FFAC9BB0630
        public void get_backgroundColor(){} // RVA: 0x7FFAC9BB0680
        public void get_backgroundImage(){} // RVA: 0x7FFAC9BB06E0
        public void get_backgroundPositionX(){} // RVA: 0x7FFAC9BB0740
        public void get_backgroundPositionY(){} // RVA: 0x7FFAC9BB07A0
        public void get_backgroundRepeat(){} // RVA: 0x7FFAC9BB0800
        public void get_backgroundSize(){} // RVA: 0x7FFAC9BB0850
        public void get_borderBottomColor(){} // RVA: 0x7FFAC9BB08B0
        public void get_borderBottomLeftRadius(){} // RVA: 0x7FFAC9BB0910
        public void get_borderBottomRightRadius(){} // RVA: 0x7FFAC9BB0960
        public void get_borderBottomWidth(){} // RVA: 0x7FFAC9BB09B0
        public void get_borderLeftColor(){} // RVA: 0x7FFAC9BB0A00
        public void get_borderLeftWidth(){} // RVA: 0x7FFAC9BB0A60
        public void get_borderRightColor(){} // RVA: 0x7FFAC9BB0AB0
        public void get_borderRightWidth(){} // RVA: 0x7FFAC9BB0B10
        public void get_borderTopColor(){} // RVA: 0x7FFAC9BB0B60
        public void get_borderTopLeftRadius(){} // RVA: 0x7FFAC9BB0BC0
        public void get_borderTopRightRadius(){} // RVA: 0x7FFAC9BB0C10
        public void get_borderTopWidth(){} // RVA: 0x7FFAC9BB0C60
        public void get_bottom(){} // RVA: 0x7FFAC9BB0CB0
        public void get_color(){} // RVA: 0x7FFAC9BB0D00
        public void get_cursor(){} // RVA: 0x7FFAC9BB0D60
        public void get_display(){} // RVA: 0x7FFAC9BB0DC0
        public void get_flexBasis(){} // RVA: 0x7FFAC9BB0E10
        public void get_flexDirection(){} // RVA: 0x7FFAC9BB0E60
        public void get_flexGrow(){} // RVA: 0x7FFAC9BB0EB0
        public void get_flexShrink(){} // RVA: 0x7FFAC9BB0F00
        public void get_flexWrap(){} // RVA: 0x7FFAC9BB0F50
        public void get_fontSize(){} // RVA: 0x7FFAC9BB0FA0
        public void get_height(){} // RVA: 0x7FFAC9BB0FF0
        public void get_justifyContent(){} // RVA: 0x7FFAC9BB1040
        public void get_left(){} // RVA: 0x7FFAC9BB1090
        public void get_letterSpacing(){} // RVA: 0x7FFAC9BB10E0
        public void get_marginBottom(){} // RVA: 0x7FFAC9BB1130
        public void get_marginLeft(){} // RVA: 0x7FFAC9BB1180
        public void get_marginRight(){} // RVA: 0x7FFAC9BB11D0
        public void get_marginTop(){} // RVA: 0x7FFAC9BB1220
        public void get_maxHeight(){} // RVA: 0x7FFAC9BB1270
        public void get_maxWidth(){} // RVA: 0x7FFAC9BB12C0
        public void get_minHeight(){} // RVA: 0x7FFAC9BB1310
        public void get_minWidth(){} // RVA: 0x7FFAC9BB1360
        public void get_opacity(){} // RVA: 0x7FFAC9BB13B0
        public void get_overflow(){} // RVA: 0x7FFAC9BB1400
        public void get_paddingBottom(){} // RVA: 0x7FFAC9BB1450
        public void get_paddingLeft(){} // RVA: 0x7FFAC9BB14A0
        public void get_paddingRight(){} // RVA: 0x7FFAC9BB14F0
        public void get_paddingTop(){} // RVA: 0x7FFAC9BB1540
        public void get_position(){} // RVA: 0x7FFAC9BB1590
        public void get_right(){} // RVA: 0x7FFAC9BB15E0
        public void get_rotate(){} // RVA: 0x7FFAC9BB1630
        public void get_scale(){} // RVA: 0x7FFAC9BB1690
        public void get_textOverflow(){} // RVA: 0x7FFAC9BB16F0
        public void get_textShadow(){} // RVA: 0x7FFAC9BB1740
        public void get_top(){} // RVA: 0x7FFAC9BB17B0
        public void get_transformOrigin(){} // RVA: 0x7FFAC9BB1800
        public void get_transitionDelay(){} // RVA: 0x7FFAC9BB1860
        public void get_transitionDuration(){} // RVA: 0x7FFAC9BB18B0
        public void get_transitionProperty(){} // RVA: 0x7FFAC9BB1900
        public void get_transitionTimingFunction(){} // RVA: 0x7FFAC9BB1950
        public void get_translate(){} // RVA: 0x7FFAC9BB19A0
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7FFAC9BB1A00
        public void get_unityFont(){} // RVA: 0x7FFAC9BB1A60
        public void get_unityFontDefinition(){} // RVA: 0x7FFAC9BB1AB0
        public void get_unityFontStyleAndWeight(){} // RVA: 0x7FFAC9BB1B10
        public void get_unityOverflowClipBox(){} // RVA: 0x7FFAC9BB1B60
        public void get_unityParagraphSpacing(){} // RVA: 0x7FFAC9BB1BB0
        public void get_unitySliceBottom(){} // RVA: 0x7FFAC9BB1C00
        public void get_unitySliceLeft(){} // RVA: 0x7FFAC9BB1C50
        public void get_unitySliceRight(){} // RVA: 0x7FFAC9BB1CA0
        public void get_unitySliceScale(){} // RVA: 0x7FFAC9BB1CF0
        public void get_unitySliceTop(){} // RVA: 0x7FFAC9BB1D40
        public void get_unityTextAlign(){} // RVA: 0x7FFAC9BB1D90
        public void get_unityTextOutlineColor(){} // RVA: 0x7FFAC9BB1DE0
        public void get_unityTextOutlineWidth(){} // RVA: 0x7FFAC9BB1E40
        public void get_unityTextOverflowPosition(){} // RVA: 0x7FFAC9BB1E90
        public void get_visibility(){} // RVA: 0x7FFAC9BB1EE0
        public void get_whiteSpace(){} // RVA: 0x7FFAC9BB1F30
        public void get_width(){} // RVA: 0x7FFAC9BB1F80
        public void get_wordSpacing(){} // RVA: 0x7FFAC9BB1FD0
        public void Create(){} // RVA: 0x7FFAC9BB2020
        public void CreateInitial(){} // RVA: 0x7FFAC9BB24D0
        public void Acquire(){} // RVA: 0x7FFAC9BB2C70
        public void Release(){} // RVA: 0x7FFAC9BB2E60
        public void CopyFrom(){} // RVA: 0x7FFAC9BB2F50
        public void ApplyProperties(){} // RVA: 0x7FFAC9BB3170
        public void ApplyStyleValue(){} // RVA: 0x7FFAC9BB45C0
        public void ApplyStyleValueManaged(){} // RVA: 0x7FFAC9BB53D0
        public void ApplyStyleCursor(){} // RVA: 0x7FFAC9BB5810
        public void ApplyStyleTextShadow(){} // RVA: 0x7FFAC9BB58B0
        public void ApplyFromComputedStyle(){} // RVA: 0x7FFAC9BB5920
        public void ApplyPropertyAnimation(){} // RVA: 0x7FFAC9BB9830 | overloaded x15
        public void StartAnimation(){} // RVA: 0x7FFAC9BB9990
        public void StartAnimationAllProperty(){} // RVA: 0x7FFAC9BBD780
        public void StartAnimationInline(){} // RVA: 0x7FFAC9BBFEA0
        public void ApplyStyleTransformOrigin(){} // RVA: 0x7FFAC9BC2CA0
        public void ApplyStyleTranslate(){} // RVA: 0x7FFAC9BC2D00
        public void ApplyStyleRotate(){} // RVA: 0x7FFAC9BC2D60
        public void ApplyStyleScale(){} // RVA: 0x7FFAC9BC2DC0
        public void ApplyStyleBackgroundSize(){} // RVA: 0x7FFAC9BC2E20
        public void ApplyInitialValue(){} // RVA: 0x7FFAC9BC2ED0 | overloaded x2
        public void ApplyUnsetValue(){} // RVA: 0x7FFAC9BC50B0 | overloaded x2
        public void CompareChanges(){} // RVA: 0x7FFAC9BC54D0
    }

    public class ComputedTransitionProperty : ValueType
    {
        public 0x6B129770 id; // 0x10
        public int durationMs; // 0x14
        public int delayMs; // 0x18
        public System.Func`2<float,float> easingCurve; // 0x20
    }

    public class ComputedTransitionUtils : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty> s_ComputedTransitionsBuffer;

        // ── Methods ──
        public void UpdateComputedTransitions(){} // RVA: 0x7FFAC9BD5320
        public void HasTransitionProperty(){} // RVA: 0x7FFAC9BD53D0
        public void GetTransitionProperty(){} // RVA: 0x7FFAC9BD54A0
        public void GetOrComputeTransitionPropertyData(){} // RVA: 0x7FFAC9BD55C0
        public void GetTransitionHashCode(){} // RVA: 0x7FFAC9BD5890
        public void SameTransitionProperty(){} // RVA: 0x7FFAC9BD6590 | overloaded x3
        public void ComputeTransitionPropertyData(){} // RVA: 0x7FFAC9BD66A0
        public void GetWrappingTransitionData(){} // RVA: 0x7FFAC2E8DC40
        public void ConvertTransitionTime(){} // RVA: 0x7FFAC9BD6AD0
        public void ConvertTransitionFunction(){} // RVA: 0x7FFAC9BD6B00
        public void .cctor(){} // RVA: 0x7FFAC9BD7D30
    }

    public class ContextClickEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B879F0
        public void .ctor(){} // RVA: 0x7FFAC9B87AE0
    }

    public class ContextualMenuManager : Object
    {
        public bool displayMenuHandledOSX; // 0x10

        // ── Methods ──
        public void get_displayMenuHandledOSX(){} // RVA: 0x7FFAC2FEB5E0
        public void set_displayMenuHandledOSX(){} // RVA: 0x7FFAC2FEB5F0
        public void DisplayMenuIfEventMatches(){} // RVA: 0x7FFAC2C79B30
        public void DisplayMenu(){} // RVA: 0x7FFAC9A8E780
        public void DoDisplayMenu(){} // RVA: 0x7FFAC2C79B30
    }

    public class ContextualMenuManipulator : MouseManipulator
    {
        public System.Action`1<UnityEngine.UIElements.ContextualMenuPopulateEvent> m_MenuBuilder; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A8EB30
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFAC9A8EDF0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFAC9A8F110
        public void OnMouseUpDownEvent(){} // RVA: 0x7FFAC9A8F460
        public void OnMouseDownEventOSX(){} // RVA: 0x7FFAC9A8F550
        public void OnMouseUpEventOSX(){} // RVA: 0x7FFAC9A8F5B0
        public void OnKeyUpEvent(){} // RVA: 0x7FFAC9A8F610
        public void DoDisplayMenu(){} // RVA: 0x7FFAC9A8F6B0
        public void OnContextualMenuEvent(){} // RVA: 0x7FFAC37CD440
    }

    public class ContextualMenuPopulateEvent : MouseEventBase`1
    {
        public UnityEngine.UIElements.DropdownMenu menu; // 0xC0
        public UnityEngine.UIElements.EventBase triggerEvent; // 0xC8
        public UnityEngine.UIElements.ContextualMenuManager m_ContextualMenuManager; // 0xD0

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B897C0
        public void get_menu(){} // RVA: 0x7FFAC2F8C120
        public void set_menu(){} // RVA: 0x7FFAC2F8C130
        public void get_triggerEvent(){} // RVA: 0x7FFAC3079460
        public void set_triggerEvent(){} // RVA: 0x7FFAC3079470
        public void GetPooled(){} // RVA: 0x7FFAC9B898B0
        public void Init(){} // RVA: 0x7FFAC9B89E40
        public void LocalInit(){} // RVA: 0x7FFAC9B89F10
        public void .ctor(){} // RVA: 0x7FFAC9B8A070
        public void PostDispatch(){} // RVA: 0x7FFAC9B8A0C0
    }

    public class CountingBloomFilter : ValueType
    {
        public <m_Counters>e__FixedBuffer m_Counters; // 0x10

        // ── Methods ──
        public void AdjustSlot(){} // RVA: 0x7FFAC9B69F90
        public void Hash1(){} // RVA: 0x7FFAC9B69FC0
        public void Hash2(){} // RVA: 0x7FFAC9B69FD0
        public void IsSlotEmpty(){} // RVA: 0x7FFAC9B69FE0
        public void InsertHash(){} // RVA: 0x7FFAC9B69FF0
        public void RemoveHash(){} // RVA: 0x7FFAC9B6A020
        public void ContainsHash(){} // RVA: 0x7FFAC9B6A050
    }

    public class CreationContext : ValueType
    {
        public UnityEngine.UIElements.CreationContext target;
        public UnityEngine.UIElements.VisualElement visualTreeAsset; // 0x10
        public UnityEngine.UIElements.VisualTreeAsset slotInsertionPoints; // 0x18
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.UIElements.VisualElement> attributeOverrides; // 0x20
        public System.Collections.Generic.List`1<AttributeOverride> <attributeOverrides>k__BackingField; // 0x28

        // ── Methods ──
        public void get_target(){} // RVA: 0x7FFAC3AD9F60
        public void set_target(){} // RVA: 0x7FFAC38DFE40
        public void get_visualTreeAsset(){} // RVA: 0x7FFAC4420220
        public void set_visualTreeAsset(){} // RVA: 0x7FFAC4420240
        public void get_slotInsertionPoints(){} // RVA: 0x7FFAC2F3C380
        public void set_slotInsertionPoints(){} // RVA: 0x7FFAC2F22E30
        public void get_attributeOverrides(){} // RVA: 0x7FFAC2F247C0
        public void set_attributeOverrides(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9ABD320 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC9ABD5A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9ABD720
        public void .cctor(){} // RVA: 0x7FFAC9ABD860
    }

    public class Cursor : ValueType
    {
        public UnityEngine.Texture2D texture; // 0x10
        public UnityEngine.Vector2 hotspot; // 0x18
        public int defaultCursorId; // 0x20

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFAC3AD9F60
        public void set_texture(){} // RVA: 0x7FFAC38DFE40
        public void get_hotspot(){} // RVA: 0x7FFAC60F5860
        public void set_hotspot(){} // RVA: 0x7FFAC4A068C0
        public void get_defaultCursorId(){} // RVA: 0x7FFAC2F6E5C0
        public void set_defaultCursorId(){} // RVA: 0x7FFAC2F240C0
        public void Equals(){} // RVA: 0x7FFAC9B6A770 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9B6A820
        public void op_Equality(){} // RVA: 0x7FFAC9B6A900
        public void ToString(){} // RVA: 0x7FFAC9B6A930
    }

    public class CursorManager : Object
    {
        public bool isCursorOverriden; // 0x10

        // ── Methods ──
        public void get_isCursorOverriden(){} // RVA: 0x7FFAC2FEB5E0
        public void set_isCursorOverriden(){} // RVA: 0x7FFAC2FEB5F0
        public void SetCursor(){} // RVA: 0x7FFAC9B6A9F0
        public void ResetCursor(){} // RVA: 0x7FFAC9B6AC10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CustomStyleProperty`1 : ValueType
    {
        public string name;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2C58E90
        public void set_name(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void Equals(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
    }

    public class CustomStyleResolvedEvent : EventBase`1
    {
        public object customStyle;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B91820
        public void get_customStyle(){} // RVA: 0x7FFAC9B91910
        public void .ctor(){} // RVA: 0x7FFAC9B919A0
    }

}