// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 14
// Methods: 396

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class CallbackEventHandler : Object
    {
        public object ExecuteDefaultActionName; // 0x30B602A0
        public object _tabIndex; // 0x30B60030, was: <tabIndex>k__BackingField

        // ── Original Methods ──
        public void RegisterCallback(){} // RVA: 0x7ffaa887e5c0
        public void AddEventCategories(){} // RVA: 0x7ffaa8660cc0
        public void RegisterCallback(){} // RVA: 0x7ffaa887e5c0
        public void RegisterCallback(){} // RVA: 0x7ffaa887e5c0
        public void UnregisterCallback(){} // RVA: 0x7ffaa8667cb0
        public void SendEvent(){} // RVA: 0x7ffaa8667cb0
        public void SendEvent(){} // RVA: 0x7ffaa8667cb0
        public void HandleEventAtTargetPhase(){} // RVA: 0x7ffaaf5a3a20
        public void HandleEventAtTargetAndDefaultPhase(){} // RVA: 0x7ffaaf5a3aa0
        public void HandleEventAtCurrentTargetAndPhase(){} // RVA: 0x7ffaac3b4260
        public void UnityEngine.UIElements.IEventHandler.HandleEvent(){} // RVA: 0x7ffaac3b4260
        public void HandleEvent(){} // RVA: 0x7ffaaf5a3b50
        public void HasTrickleDownHandlers(){} // RVA: 0x7ffaaf5a3e70
        public void HasBubbleUpHandlers(){} // RVA: 0x7ffaaf5a3ea0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7ffaa8932310
        public void ExecuteDefaultAction(){} // RVA: 0x7ffaa8932310
        public void ExecuteDefaultActionDisabledAtTarget(){} // RVA: 0x7ffaa8932310
        public void ExecuteDefaultActionDisabled(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa97393e0
    }

    public class ChangeEvent`1 : EventBase`1
    {
        public object _previousValue; // 0x83AFBB00, was: <previousValue>k__BackingField

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void get_previousValue(){} // RVA: 0x7ffaa887e5c0
        public void set_previousValue(){} // RVA: 0x7ffaa887e5c0
        public void get_newValue(){} // RVA: 0x7ffaa887e5c0
        public void set_newValue(){} // RVA: 0x7ffaa887e5c0
        public void Init(){} // RVA: 0x7ffaa8660cc0
        public void LocalInit(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
    }

    public class ClampedDragger`1 : Clickable
    {
        public object _dragDirection; // 0x30DCCDB0, was: <dragDirection>k__BackingField

        // ── Original Methods ──
        public void add_dragging(){} // RVA: 0x7ffaa8660d80
        public void remove_dragging(){} // RVA: 0x7ffaa8660d80
        public void add_draggingEnded(){} // RVA: 0x7ffaa8660d80
        public void remove_draggingEnded(){} // RVA: 0x7ffaa8660d80
        public void get_dragDirection(){} // RVA: 0x7ffaa887e5c0
        public void set_dragDirection(){} // RVA: 0x7ffaa887e5c0
        public void set_slider(){} // RVA: 0x7ffaa8660d80
        public void get_startMousePosition(){} // RVA: 0x7ffaa86491d0
        public void set_startMousePosition(){} // RVA: 0x7ffaa866f720
        public void get_delta(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa866b2a0
        public void ProcessDownEvent(){}
        public void ProcessUpEvent(){}
        public void ProcessMoveEvent(){}
    }

    public class Clickable : PointerManipulator
    {
        public object m_Delay; // 0x30DCCFB0
        public object _lastMousePosition; // 0x30DCCFB0, was: <lastMousePosition>k__BackingF
        public object m_Repeater; // 0x30DCCFB0

        // ── Original Methods ──
        public void add_clickedWithEventInfo(){} // RVA: 0x7ffaaf4a1e60
        public void remove_clickedWithEventInfo(){} // RVA: 0x7ffaaf4a1f60
        public void add_clicked(){} // RVA: 0x7ffaaf4a2060
        public void remove_clicked(){} // RVA: 0x7ffaaf4a2150
        public void get_active(){} // RVA: 0x7ffaa8b6c110
        public void set_active(){} // RVA: 0x7ffaa92bb760
        public void get_lastMousePosition(){} // RVA: 0x7ffaaf4a2240
        public void set_lastMousePosition(){} // RVA: 0x7ffaadd91ee0
        public void get_acceptClicksIfDisabled(){} // RVA: 0x7ffaa89fa570
        public void set_acceptClicksIfDisabled(){} // RVA: 0x7ffaaf4a2260
        public void get_invokePolicy(){} // RVA: 0x7ffaaf4a22b0
        public void .ctor(){} // RVA: 0x7ffaaf4a2460
        public void .ctor(){} // RVA: 0x7ffaaf4a2460
        public void .ctor(){} // RVA: 0x7ffaaf4a2460
        public void OnTimer(){} // RVA: 0x7ffaaf4a25d0
        public void IsRepeatable(){} // RVA: 0x7ffaaf4a26d0
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7ffaaf4a26f0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7ffaaf4a2bf0
        public void OnMouseDown(){} // RVA: 0x7ffaaf4a3120
        public void OnMouseMove(){} // RVA: 0x7ffaaf4a3210
        public void OnMouseUp(){} // RVA: 0x7ffaaf4a3290
        public void OnMouseCaptureOut(){} // RVA: 0x7ffaaf4a33c0
        public void OnPointerDown(){} // RVA: 0x7ffaaf4a3450
        public void OnPointerMove(){} // RVA: 0x7ffaaf4a35e0
        public void OnPointerUp(){} // RVA: 0x7ffaaf4a3740
        public void OnPointerCancel(){} // RVA: 0x7ffaaf4a3900
        public void OnPointerCaptureOut(){} // RVA: 0x7ffaaf4a3a20
        public void ContainsPointer(){} // RVA: 0x7ffaaf4a3b00
        public void IsNotMouseEvent(){} // RVA: 0x7ffaaf4a3b90
        public void Invoke(){} // RVA: 0x7ffaaf4a3bf0
        public void SimulateSingleClick(){} // RVA: 0x7ffaaf4a3c40
        public void ProcessDownEvent(){} // RVA: 0x7ffaaf4a3d80
        public void ProcessMoveEvent(){} // RVA: 0x7ffaaf4a4140
        public void ProcessUpEvent(){} // RVA: 0x7ffaaf4a41b0
        public void ProcessCancelEvent(){} // RVA: 0x7ffaaf4a43a0
        public void <SimulateSingleClick>b__43_0(){} // RVA: 0x7ffaaf4a4520
    }

    public class CollectionViewController : Object
    {
        public object itemsSourceChanged; // 0x30E6C330

        // ── Original Methods ──
        public void add_itemsSourceChanged(){} // RVA: 0x7ffaaf4abb10
        public void remove_itemsSourceChanged(){} // RVA: 0x7ffaaf4abc00
        public void add_itemIndexChanged(){} // RVA: 0x7ffaaf4abcf0
        public void remove_itemIndexChanged(){} // RVA: 0x7ffaaf4abdf0
        public void get_itemsSource(){} // RVA: 0x7ffaa89357c0
        public void set_itemsSource(){} // RVA: 0x7ffaaf4abef0
        public void get_view(){} // RVA: 0x7ffaa894d380
        public void PrepareView(){} // RVA: 0x7ffaa8932310
        public void Dispose(){} // RVA: 0x7ffaaf4ac0d0
        public void InvokeMakeItem(){} // RVA: 0x7ffaaf4ac2d0
        public void InvokeBindItem(){} // RVA: 0x7ffaaf4ac320
        public void InvokeUnbindItem(){} // RVA: 0x7ffaaf4ac400
        public void InvokeDestroyItem(){} // RVA: 0x7ffaaf4ac440
        public void MakeItem(){} // RVA: 0x7ffaa86491d0
        public void BindItem(){} // RVA: 0x7ffaa8667cb0
        public void UnbindItem(){} // RVA: 0x7ffaa8667cb0
        public void DestroyItem(){} // RVA: 0x7ffaa8660d80
        public void RaiseItemsSourceChanged(){} // RVA: 0x7ffaa8c26ca0
        public void RaiseItemIndexChanged(){} // RVA: 0x7ffaaf4ab660
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetItemsSourceWithoutNotify(){} // RVA: 0x7ffaa8998e80
        public void SetView(){} // RVA: 0x7ffaaf4abfe0
        public void GetItemsCount(){} // RVA: 0x7ffaaf4ac1d0
        public void GetItemsMinCount(){} // RVA: 0x7ffaa8a931c0
        public void GetIndexForId(){} // RVA: 0x7ffaab7a6ce0
        public void GetIdForIndex(){} // RVA: 0x7ffaab7a6ce0
        public void GetItemForIndex(){} // RVA: 0x7ffaaf4ac230
    }

    public class CollectionVirtualizationController : Object
    {
        // ── Original Methods ──
        public void get_firstVisibleIndex(){} // RVA: 0x7ffaa8649ca0
        public void set_firstVisibleIndex(){} // RVA: 0x7ffaa8661210
        public void get_visibleItemCount(){} // RVA: 0x7ffaa8649ca0
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void Refresh(){} // RVA: 0x7ffaa86613a0
        public void ScrollToItem(){} // RVA: 0x7ffaa8661210
        public void Resize(){} // RVA: 0x7ffaa866f720
        public void OnScroll(){} // RVA: 0x7ffaa866f720
        public void OnFocus(){} // RVA: 0x7ffaa8660d80
        public void OnBlur(){} // RVA: 0x7ffaa8660d80
        public void UpdateBackground(){} // RVA: 0x7ffaa8660cc0
        public void get_activeItems(){} // RVA: 0x7ffaa86491d0
        public void StartDragItem(){} // RVA: 0x7ffaa8660d80
        public void EndDrag(){} // RVA: 0x7ffaa8661210
        // ── Binary Analysis Named ──
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7ffaa865df70
        public void GetExpectedContentHeight(){} // RVA: 0x7ffaa865dbc0
    }

    public class Column : Object
    {
        public object m_Title; // 0x30BB9ED0
        public object m_Width; // 0x30BB9ED0
        public object m_DesiredWidth; // 0x30BB9ED0
        public object m_Optional; // 0x30BB9ED0
        public object m_BindHeader; // 0x30BB9ED0
        public object m_MakeCell; // 0x30BB9ED0
        public object _destroyCell; // 0x30BB9ED0, was: <destroyCell>k__BackingField
        public object resized; // 0x30BB9ED0

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa894d380
        public void set_name(){} // RVA: 0x7ffaaf564df0
        public void get_title(){} // RVA: 0x7ffaa89357c0
        public void set_title(){} // RVA: 0x7ffaaf564eb0
        public void get_icon(){} // RVA: 0x7ffaaf564f70
        public void get_index(){} // RVA: 0x7ffaaf564f90
        public void get_displayIndex(){} // RVA: 0x7ffaaf565080
        public void get_visibleIndex(){} // RVA: 0x7ffaaf565170
        public void get_visible(){} // RVA: 0x7ffaa89edc00
        public void set_visible(){} // RVA: 0x7ffaaf565260
        public void get_width(){} // RVA: 0x7ffaae58ff10
        public void set_width(){} // RVA: 0x7ffaaf5652a0
        public void get_minWidth(){} // RVA: 0x7ffaab9f1b90
        public void set_minWidth(){} // RVA: 0x7ffaaf565340
        public void get_maxWidth(){} // RVA: 0x7ffaaa1ca980
        public void set_maxWidth(){} // RVA: 0x7ffaaf5653a0
        public void get_desiredWidth(){} // RVA: 0x7ffaa895b000
        public void set_desiredWidth(){} // RVA: 0x7ffaaf565400
        public void get_sortable(){} // RVA: 0x7ffaa96315d0
        public void set_sortable(){} // RVA: 0x7ffaaf565430
        public void get_stretchable(){} // RVA: 0x7ffaa895b020
        public void set_stretchable(){} // RVA: 0x7ffaaf565470
        public void get_optional(){} // RVA: 0x7ffaa8966e50
        public void set_optional(){} // RVA: 0x7ffaaf5654b0
        public void get_resizable(){} // RVA: 0x7ffaa8966e40
        public void set_resizable(){} // RVA: 0x7ffaaf5654f0
        public void get_makeHeader(){} // RVA: 0x7ffaa89add50
        public void set_makeHeader(){} // RVA: 0x7ffaaf565530
        public void get_bindHeader(){} // RVA: 0x7ffaa89fa590
        public void get_unbindHeader(){} // RVA: 0x7ffaa8af68f0
        public void get_destroyHeader(){} // RVA: 0x7ffaa8d1a3b0
        public void get_makeCell(){} // RVA: 0x7ffaa8971010
        public void set_makeCell(){} // RVA: 0x7ffaaf5655e0
        public void get_bindCell(){} // RVA: 0x7ffaa8d1b980
        public void get_unbindCell(){} // RVA: 0x7ffaa8f75d20
        public void get_destroyCell(){} // RVA: 0x7ffaa8f78170
        public void get_collection(){} // RVA: 0x7ffaa8f74720
        public void set_collection(){} // RVA: 0x7ffaa8d71dc0
        public void add_changed(){} // RVA: 0x7ffaaf5656a0
        public void remove_changed(){} // RVA: 0x7ffaaf5657a0
        public void add_resized(){} // RVA: 0x7ffaaf5658a0
        public void remove_resized(){} // RVA: 0x7ffaaf5659a0
        public void NotifyChange(){} // RVA: 0x7ffaaf565aa0
        public void .ctor(){} // RVA: 0x7ffaaf565ad0
        public void .cctor(){} // RVA: 0x7ffaaf565b20
    }

    public class Columns : Object
    {
        public object m_VisibleColumns; // 0x314908B0
        public object m_Reorderable; // 0x314908B0
        public object m_PrimaryColumnName; // 0x314908B0
        public object columnRemoved; // 0x314908B0
        public object columnReordered; // 0x314908B0

        // ── Original Methods ──
        public void get_primaryColumnName(){} // RVA: 0x7ffaa8bf45b0
        public void set_primaryColumnName(){} // RVA: 0x7ffaaf5699e0
        public void get_reorderable(){} // RVA: 0x7ffaa8958450
        public void set_reorderable(){} // RVA: 0x7ffaaf569aa0
        public void get_resizable(){} // RVA: 0x7ffaa8958470
        public void set_resizable(){} // RVA: 0x7ffaaf569ad0
        public void get_resizePreview(){} // RVA: 0x7ffaabef8500
        public void set_resizePreview(){} // RVA: 0x7ffaaf569b00
        public void get_displayList(){} // RVA: 0x7ffaaf569b30
        public void get_visibleList(){} // RVA: 0x7ffaaf569b50
        public void add_changed(){} // RVA: 0x7ffaaf569b70
        public void remove_changed(){} // RVA: 0x7ffaaf569c70
        public void get_stretchMode(){} // RVA: 0x7ffaa96cc980
        public void set_stretchMode(){} // RVA: 0x7ffaaf569d70
        public void add_columnAdded(){} // RVA: 0x7ffaaf569da0
        public void remove_columnAdded(){} // RVA: 0x7ffaaf569ea0
        public void add_columnRemoved(){} // RVA: 0x7ffaaf569fa0
        public void remove_columnRemoved(){} // RVA: 0x7ffaaf56a0a0
        public void add_columnChanged(){} // RVA: 0x7ffaaf56a1a0
        public void remove_columnChanged(){} // RVA: 0x7ffaaf56a2a0
        public void add_columnResized(){} // RVA: 0x7ffaaf56a3a0
        public void remove_columnResized(){} // RVA: 0x7ffaaf56a4a0
        public void add_columnReordered(){} // RVA: 0x7ffaaf56a5a0
        public void remove_columnReordered(){} // RVA: 0x7ffaaf56a6a0
        public void IsPrimary(){} // RVA: 0x7ffaaf56a7a0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaf56a850
        public void Add(){} // RVA: 0x7ffaaf56a8a0
        public void Clear(){} // RVA: 0x7ffaaf56a910
        public void Contains(){} // RVA: 0x7ffaaf56aba0
        public void Contains(){} // RVA: 0x7ffaaf56aba0
        public void CopyTo(){} // RVA: 0x7ffaaf56ad40
        public void Remove(){} // RVA: 0x7ffaaf56ae20
        public void OnColumnChanged(){} // RVA: 0x7ffaaf56b000
        public void OnColumnResized(){} // RVA: 0x7ffaa9886000
        public void get_Count(){} // RVA: 0x7ffaaf56b060
        public void get_IsReadOnly(){} // RVA: 0x7ffaaf56b0b0
        public void IndexOf(){} // RVA: 0x7ffaaf56b100
        public void Insert(){} // RVA: 0x7ffaaf56b1d0
        public void get_Item(){} // RVA: 0x7ffaaf56b4f0
        public void get_Item(){} // RVA: 0x7ffaaf56b4f0
        public void ReorderDisplay(){} // RVA: 0x7ffaaf56b690
        public void InitOrderColumns(){} // RVA: 0x7ffaaf56b810
        public void DirtyVisibleColumns(){} // RVA: 0x7ffaaf56b8e0
        public void UpdateVisibleColumns(){} // RVA: 0x7ffaaf56b950
        public void NotifyChange(){} // RVA: 0x7ffaad0b8810
        public void .ctor(){} // RVA: 0x7ffaaf56bc20
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaf56a850
    }

    public class CommandEventBase`1 : EventBase`1
    {
        // ── Original Methods ──
        public void get_commandName(){} // RVA: 0x7ffaa86491d0
        public void set_commandName(){} // RVA: 0x7ffaa8660d80
        public void Init(){} // RVA: 0x7ffaa8660cc0
        public void LocalInit(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
    }

    public class ComputedStyle : ValueType
    {
        public object rareData; // 0x35BC2DB0
        public object visualData; // 0x35BC2DB0
        public object matchingRulesHash; // 0x35BC2DB0

        // ── Original Methods ──
        public void get_customPropertiesCount(){} // RVA: 0x7ffaaf5d0e60
        public void get_hasTransition(){} // RVA: 0x7ffaaf5d0eb0
        public void FinalizeApply(){} // RVA: 0x7ffaaf5d0ed0
        public void SyncWithLayout(){} // RVA: 0x7ffaaf5d10b0
        public void ApplyGlobalKeyword(){} // RVA: 0x7ffaaf5d1f90
        public void ApplyGlobalKeyword(){} // RVA: 0x7ffaaf5d1f90
        public void RemoveCustomStyleProperty(){} // RVA: 0x7ffaaf5d1fb0
        public void ApplyCustomStyleProperty(){} // RVA: 0x7ffaaf5d2060
        public void ApplyAllPropertyInitial(){} // RVA: 0x7ffaaf5d2280
        public void ResetComputedTransitions(){} // RVA: 0x7ffaa9ed5f40
        public void StartAnimationInlineTranslate(){} // RVA: 0x7ffaaf5d2320
        public void get_alignContent(){} // RVA: 0x7ffaaf5d2500
        public void get_alignItems(){} // RVA: 0x7ffaaf5d2550
        public void get_alignSelf(){} // RVA: 0x7ffaaf5d25a0
        public void get_backgroundColor(){} // RVA: 0x7ffaaf5d25f0
        public void get_backgroundImage(){} // RVA: 0x7ffaaf5d2650
        public void get_backgroundPositionX(){} // RVA: 0x7ffaaf5d26b0
        public void get_backgroundPositionY(){} // RVA: 0x7ffaaf5d2710
        public void get_backgroundRepeat(){} // RVA: 0x7ffaaf5d2770
        public void get_backgroundSize(){} // RVA: 0x7ffaaf5d27c0
        public void get_borderBottomColor(){} // RVA: 0x7ffaaf5d2820
        public void get_borderBottomLeftRadius(){} // RVA: 0x7ffaaf5d2880
        public void get_borderBottomRightRadius(){} // RVA: 0x7ffaaf5d28d0
        public void get_borderBottomWidth(){} // RVA: 0x7ffaaf5d2920
        public void get_borderLeftColor(){} // RVA: 0x7ffaaf5d2970
        public void get_borderLeftWidth(){} // RVA: 0x7ffaaf5d29d0
        public void get_borderRightColor(){} // RVA: 0x7ffaaf5d2a20
        public void get_borderRightWidth(){} // RVA: 0x7ffaaf5d2a80
        public void get_borderTopColor(){} // RVA: 0x7ffaaf5d2ad0
        public void get_borderTopLeftRadius(){} // RVA: 0x7ffaaf5d2b30
        public void get_borderTopRightRadius(){} // RVA: 0x7ffaaf5d2b80
        public void get_borderTopWidth(){} // RVA: 0x7ffaaf5d2bd0
        public void get_bottom(){} // RVA: 0x7ffaaf5d2c20
        public void get_color(){} // RVA: 0x7ffaaf5d2c70
        public void get_cursor(){} // RVA: 0x7ffaaf5d2cd0
        public void get_display(){} // RVA: 0x7ffaaf5d2d30
        public void get_flexBasis(){} // RVA: 0x7ffaaf5d2d80
        public void get_flexDirection(){} // RVA: 0x7ffaaf5d2dd0
        public void get_flexGrow(){} // RVA: 0x7ffaaf5d2e20
        public void get_flexShrink(){} // RVA: 0x7ffaaf5d2e70
        public void get_flexWrap(){} // RVA: 0x7ffaaf5d2ec0
        public void get_fontSize(){} // RVA: 0x7ffaaf5d2f10
        public void get_height(){} // RVA: 0x7ffaaf5d2f60
        public void get_justifyContent(){} // RVA: 0x7ffaaf5d2fb0
        public void get_left(){} // RVA: 0x7ffaaf5d3000
        public void get_letterSpacing(){} // RVA: 0x7ffaaf5d3050
        public void get_marginBottom(){} // RVA: 0x7ffaaf5d30a0
        public void get_marginLeft(){} // RVA: 0x7ffaaf5d30f0
        public void get_marginRight(){} // RVA: 0x7ffaaf5d3140
        public void get_marginTop(){} // RVA: 0x7ffaaf5d3190
        public void get_maxHeight(){} // RVA: 0x7ffaaf5d31e0
        public void get_maxWidth(){} // RVA: 0x7ffaaf5d3230
        public void get_minHeight(){} // RVA: 0x7ffaaf5d3280
        public void get_minWidth(){} // RVA: 0x7ffaaf5d32d0
        public void get_opacity(){} // RVA: 0x7ffaaf5d3320
        public void get_overflow(){} // RVA: 0x7ffaaf5d3370
        public void get_paddingBottom(){} // RVA: 0x7ffaaf5d33c0
        public void get_paddingLeft(){} // RVA: 0x7ffaaf5d3410
        public void get_paddingRight(){} // RVA: 0x7ffaaf5d3460
        public void get_paddingTop(){} // RVA: 0x7ffaaf5d34b0
        public void get_position(){} // RVA: 0x7ffaaf5d3500
        public void get_right(){} // RVA: 0x7ffaaf5d3550
        public void get_rotate(){} // RVA: 0x7ffaaf5d35a0
        public void get_scale(){} // RVA: 0x7ffaaf5d3600
        public void get_textOverflow(){} // RVA: 0x7ffaaf5d3660
        public void get_textShadow(){} // RVA: 0x7ffaaf5d36b0
        public void get_top(){} // RVA: 0x7ffaaf5d3720
        public void get_transformOrigin(){} // RVA: 0x7ffaaf5d3770
        public void get_transitionDelay(){} // RVA: 0x7ffaaf5d37d0
        public void get_transitionDuration(){} // RVA: 0x7ffaaf5d3820
        public void get_transitionProperty(){} // RVA: 0x7ffaaf5d3870
        public void get_transitionTimingFunction(){} // RVA: 0x7ffaaf5d38c0
        public void get_translate(){} // RVA: 0x7ffaaf5d3910
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7ffaaf5d3970
        public void get_unityFont(){} // RVA: 0x7ffaaf5d39d0
        public void get_unityFontDefinition(){} // RVA: 0x7ffaaf5d3a20
        public void get_unityFontStyleAndWeight(){} // RVA: 0x7ffaaf5d3a80
        public void get_unityOverflowClipBox(){} // RVA: 0x7ffaaf5d3ad0
        public void get_unityParagraphSpacing(){} // RVA: 0x7ffaaf5d3b20
        public void get_unitySliceBottom(){} // RVA: 0x7ffaaf5d3b70
        public void get_unitySliceLeft(){} // RVA: 0x7ffaaf5d3bc0
        public void get_unitySliceRight(){} // RVA: 0x7ffaaf5d3c10
        public void get_unitySliceScale(){} // RVA: 0x7ffaaf5d3c60
        public void get_unitySliceTop(){} // RVA: 0x7ffaaf5d3cb0
        public void get_unityTextAlign(){} // RVA: 0x7ffaaf5d3d00
        public void get_unityTextOutlineColor(){} // RVA: 0x7ffaaf5d3d50
        public void get_unityTextOutlineWidth(){} // RVA: 0x7ffaaf5d3db0
        public void get_unityTextOverflowPosition(){} // RVA: 0x7ffaaf5d3e00
        public void get_visibility(){} // RVA: 0x7ffaaf5d3e50
        public void get_whiteSpace(){} // RVA: 0x7ffaaf5d3ea0
        public void get_width(){} // RVA: 0x7ffaaf5d3ef0
        public void get_wordSpacing(){} // RVA: 0x7ffaaf5d3f40
        public void Create(){} // RVA: 0x7ffaaf5d3f90
        public void CreateInitial(){} // RVA: 0x7ffaaf5d4440
        public void Acquire(){} // RVA: 0x7ffaaf5d4be0
        public void Release(){} // RVA: 0x7ffaaf5d4dd0
        public void CopyFrom(){} // RVA: 0x7ffaaf5d4ec0
        public void ApplyProperties(){} // RVA: 0x7ffaaf5d50e0
        public void ApplyStyleValue(){} // RVA: 0x7ffaaf5d6530
        public void ApplyStyleValueManaged(){} // RVA: 0x7ffaaf5d7340
        public void ApplyStyleCursor(){} // RVA: 0x7ffaaf5d7780
        public void ApplyStyleTextShadow(){} // RVA: 0x7ffaaf5d7820
        public void ApplyFromComputedStyle(){} // RVA: 0x7ffaaf5d7890
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void ApplyPropertyAnimation(){} // RVA: 0x7ffaaf5db7a0
        public void StartAnimation(){} // RVA: 0x7ffaaf5db900
        public void StartAnimationAllProperty(){} // RVA: 0x7ffaaf5df6f0
        public void StartAnimationInline(){} // RVA: 0x7ffaaf5e1e10
        public void ApplyStyleTransformOrigin(){} // RVA: 0x7ffaaf5e4c10
        public void ApplyStyleTranslate(){} // RVA: 0x7ffaaf5e4c70
        public void ApplyStyleRotate(){} // RVA: 0x7ffaaf5e4cd0
        public void ApplyStyleScale(){} // RVA: 0x7ffaaf5e4d30
        public void ApplyStyleBackgroundSize(){} // RVA: 0x7ffaaf5e4d90
        public void ApplyInitialValue(){} // RVA: 0x7ffaaf5e4e40
        public void ApplyInitialValue(){} // RVA: 0x7ffaaf5e4e40
        public void ApplyUnsetValue(){} // RVA: 0x7ffaaf5e7020
        public void ApplyUnsetValue(){} // RVA: 0x7ffaaf5e7020
        public void CompareChanges(){} // RVA: 0x7ffaaf5e7440
    }

    public class ComputedTransitionUtils : Object
    {
        // ── Original Methods ──
        public void UpdateComputedTransitions(){} // RVA: 0x7ffaaf5f7290
        public void HasTransitionProperty(){} // RVA: 0x7ffaaf5f7340
        public void SameTransitionProperty(){} // RVA: 0x7ffaaf5f8500
        public void SameTransitionProperty(){} // RVA: 0x7ffaaf5f8500
        public void SameTransitionProperty(){} // RVA: 0x7ffaaf5f8500
        public void ComputeTransitionPropertyData(){} // RVA: 0x7ffaaf5f8610
        public void ConvertTransitionTime(){} // RVA: 0x7ffaaf5f8a40
        public void ConvertTransitionFunction(){} // RVA: 0x7ffaaf5f8a70
        public void .cctor(){} // RVA: 0x7ffaaf5f9ca0
        // ── Binary Analysis Named ──
        public void GetTransitionProperty(){} // RVA: 0x7ffaaf5f7410
        public void GetOrComputeTransitionPropertyData(){} // RVA: 0x7ffaaf5f7530
        public void GetTransitionHashCode(){} // RVA: 0x7ffaaf5f7800
        public void GetWrappingTransitionData(){} // RVA: 0x7ffaa887e5c0
    }

    public class CreationContext : ValueType
    {
        public object _visualTreeAsset; // 0x30D43910, was: <visualTreeAsset>k__BackingFie

        // ── Original Methods ──
        public void get_target(){} // RVA: 0x7ffaa950bda0
        public void set_target(){} // RVA: 0x7ffaa930eca0
        public void get_visualTreeAsset(){} // RVA: 0x7ffaa9e47540
        public void set_visualTreeAsset(){} // RVA: 0x7ffaa9e47560
        public void get_slotInsertionPoints(){} // RVA: 0x7ffaa894d380
        public void set_slotInsertionPoints(){} // RVA: 0x7ffaa8933e30
        public void get_attributeOverrides(){} // RVA: 0x7ffaa89357c0
        public void set_attributeOverrides(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf4df280
        public void .ctor(){} // RVA: 0x7ffaaf4df280
        public void Equals(){} // RVA: 0x7ffaaf4df500
        public void Equals(){} // RVA: 0x7ffaaf4df500
        public void .cctor(){} // RVA: 0x7ffaaf4df7c0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf4df680
    }

    public class Cursor : ValueType
    {
        public object _defaultCursorId; // 0x35BDA880, was: <defaultCursorId>k__BackingFie

        // ── Original Methods ──
        public void get_texture(){} // RVA: 0x7ffaa950bda0
        public void set_texture(){} // RVA: 0x7ffaa930eca0
        public void get_hotspot(){} // RVA: 0x7ffaabb06e10
        public void set_hotspot(){} // RVA: 0x7ffaaa40d8d0
        public void get_defaultCursorId(){} // RVA: 0x7ffaa897f5c0
        public void set_defaultCursorId(){} // RVA: 0x7ffaa89350c0
        public void Equals(){} // RVA: 0x7ffaaf58c6d0
        public void Equals(){} // RVA: 0x7ffaaf58c6d0
        public void op_Equality(){} // RVA: 0x7ffaaf58c860
        public void ToString(){} // RVA: 0x7ffaaf58c890
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf58c780
    }

    public class CustomStyleProperty`1 : ValueType
    {
        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa86491d0
        public void set_name(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Equals(){} // RVA: 0x7ffaa887e5c0
        public void Equals(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
    }

}