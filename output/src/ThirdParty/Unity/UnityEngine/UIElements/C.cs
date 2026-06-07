// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 28
// Methods: 485

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class CallbackEventHandler
    {
        // ── Methods ──
        public void RegisterCallback(){} // RVA: 0x283FA0 | overloaded x3
        public void AddEventCategories(){} // RVA: 0x24A50
        public void UnregisterCallback(){} // RVA: 0x2BAA0
        public void SendEvent(){} // RVA: 0x2BAA0 | overloaded x2
        public void HandleEventAtTargetPhase(){} // RVA: 0x73EA1C0
        public void HandleEventAtTargetAndDefaultPhase(){} // RVA: 0x73EA240
        public void HandleEventAtCurrentTargetAndPhase(){} // RVA: 0x408EFF0
        public void UnityEngine.UIElements.IEventHandler.HandleEvent(){} // RVA: 0x408EFF0
        public void HandleEvent(){} // RVA: 0x73EA2F0
        public void HasTrickleDownHandlers(){} // RVA: 0x73EA610
        public void HasBubbleUpHandlers(){} // RVA: 0x73EA640
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x2DD310
        public void ExecuteDefaultAction(){} // RVA: 0x2DD310
        public void ExecuteDefaultActionDisabledAtTarget(){} // RVA: 0x2DD310
        public void ExecuteDefaultActionDisabled(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x6BDA00
    }

    public class CanStartDragArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3FB0F00
    }

    public class ChangeEvent`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
        public void get_previousValue(){} // RVA: 0x283FA0
        public void set_previousValue(){} // RVA: 0x283FA0
        public void get_newValue(){} // RVA: 0x283FA0
        public void set_newValue(){} // RVA: 0x283FA0
        public void Init(){} // RVA: 0x24A50
        public void LocalInit(){} // RVA: 0x24A50
        public void GetPooled(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class ClampedDragger`1
    {
        // ── Methods ──
        public void add_dragging(){} // RVA: 0x24B10
        public void remove_dragging(){} // RVA: 0x24B10
        public void add_draggingEnded(){} // RVA: 0x24B10
        public void remove_draggingEnded(){} // RVA: 0x24B10
        public void get_dragDirection(){} // RVA: 0x283FA0
        public void set_dragDirection(){} // RVA: 0x283FA0
        public void set_slider(){} // RVA: 0x24B10
        public void get_startMousePosition(){} // RVA: 0xCD60
        public void set_startMousePosition(){} // RVA: 0x33510
        public void get_delta(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2F090
        public void ProcessDownEvent(){}
        public void ProcessUpEvent(){}
        public void ProcessMoveEvent(){}
    }

    public class ClickDetector
    {
        public object baseListView;

        // ── Methods ──
        public void get_s_DoubleClickTime(){} // RVA: 0x72EAD10
        public void set_s_DoubleClickTime(){} // RVA: 0x72EAD70
        public void .ctor(){} // RVA: 0x72EADD0
        public void StartClickTracking(){} // RVA: 0x72EB0B0
        public void SendClickEvent(){} // RVA: 0x72EB2D0
        public void CancelClickTracking(){} // RVA: 0x72EB920
        public void ProcessEvent(){} // RVA: 0x72EB9E0
        public void ContainsPointer(){} // RVA: 0x72EBDB0
        public void Cleanup(){} // RVA: 0x72EBF80
        public void .cctor(){} // RVA: 0x72EC130
    }

    public class ClickEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F8950
        public void Init(){} // RVA: 0x73F8A40
        public void LocalInit(){} // RVA: 0x73EF520
        public void .ctor(){} // RVA: 0x73F8A90
        public void GetPooled(){} // RVA: 0x73F8AE0
    }

    public class Clickable
    {
        // ── Methods ──
        public void add_clickedWithEventInfo(){} // RVA: 0x72E8620
        public void remove_clickedWithEventInfo(){} // RVA: 0x72E8720
        public void add_clicked(){} // RVA: 0x72E8820
        public void remove_clicked(){} // RVA: 0x72E8910
        public void get_active(){} // RVA: 0x59FF30
        public void set_active(){} // RVA: 0xC5F680
        public void get_lastMousePosition(){} // RVA: 0x72E8A00
        public void set_lastMousePosition(){} // RVA: 0x5BD97E0
        public void get_acceptClicksIfDisabled(){} // RVA: 0x3A5570
        public void set_acceptClicksIfDisabled(){} // RVA: 0x72E8A20
        public void get_invokePolicy(){} // RVA: 0x72E8A70
        public void .ctor(){} // RVA: 0x72E8C20 | overloaded x3
        public void OnTimer(){} // RVA: 0x72E8D90
        public void IsRepeatable(){} // RVA: 0x72E8E90
        public void RegisterCallbacksOnTarget(){} // RVA: 0x72E8EB0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x72E93B0
        public void OnMouseDown(){} // RVA: 0x72E98E0
        public void OnMouseMove(){} // RVA: 0x72E99D0
        public void OnMouseUp(){} // RVA: 0x72E9A50
        public void OnMouseCaptureOut(){} // RVA: 0x72E9B80
        public void OnPointerDown(){} // RVA: 0x72E9C10
        public void OnPointerMove(){} // RVA: 0x72E9DA0
        public void OnPointerUp(){} // RVA: 0x72E9F00
        public void OnPointerCancel(){} // RVA: 0x72EA0C0
        public void OnPointerCaptureOut(){} // RVA: 0x72EA1E0
        public void ContainsPointer(){} // RVA: 0x72EA2C0
        public void IsNotMouseEvent(){} // RVA: 0x72EA350
        public void Invoke(){} // RVA: 0x72EA3B0
        public void SimulateSingleClick(){} // RVA: 0x72EA400
        public void ProcessDownEvent(){} // RVA: 0x72EA540
        public void ProcessMoveEvent(){} // RVA: 0x72EA900
        public void ProcessUpEvent(){} // RVA: 0x72EA970
        public void ProcessCancelEvent(){} // RVA: 0x72EAB60
        public void <SimulateSingleClick>b__43_0(){} // RVA: 0x72EACE0
    }

    public class CollectionViewController
    {
        // ── Methods ──
        public void add_itemsSourceChanged(){} // RVA: 0x72F22D0
        public void remove_itemsSourceChanged(){} // RVA: 0x72F23C0
        public void add_itemIndexChanged(){} // RVA: 0x72F24B0
        public void remove_itemIndexChanged(){} // RVA: 0x72F25B0
        public void get_itemsSource(){} // RVA: 0x2E07C0
        public void set_itemsSource(){} // RVA: 0x72F26B0
        public void SetItemsSourceWithoutNotify(){} // RVA: 0x343E80
        public void get_view(){} // RVA: 0x2F8380
        public void SetView(){} // RVA: 0x72F27A0
        public void PrepareView(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x72F2890
        public void GetItemsCount(){} // RVA: 0x72F2990
        public void GetItemsMinCount(){} // RVA: 0x43E1C0
        public void GetIndexForId(){} // RVA: 0x3471610
        public void GetIdForIndex(){} // RVA: 0x3471610
        public void GetItemForIndex(){} // RVA: 0x72F29F0
        public void InvokeMakeItem(){} // RVA: 0x72F2A90
        public void InvokeBindItem(){} // RVA: 0x72F2AE0
        public void InvokeUnbindItem(){} // RVA: 0x72F2BC0
        public void InvokeDestroyItem(){} // RVA: 0x72F2C00
        public void MakeItem(){} // RVA: 0xCD60
        public void BindItem(){} // RVA: 0x2BAA0
        public void UnbindItem(){} // RVA: 0x2BAA0
        public void DestroyItem(){} // RVA: 0x24B10
        public void RaiseItemsSourceChanged(){} // RVA: 0x68B300
        public void RaiseItemIndexChanged(){} // RVA: 0x72F1E20
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CollectionVirtualizationController
    {
        // ── Methods ──
        public void get_firstVisibleIndex(){} // RVA: 0xD840
        public void set_firstVisibleIndex(){} // RVA: 0x24FA0
        public void get_visibleItemCount(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x2DEE30
        public void Refresh(){} // RVA: 0x25130
        public void ScrollToItem(){} // RVA: 0x24FA0
        public void Resize(){} // RVA: 0x33510
        public void OnScroll(){} // RVA: 0x33510
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x21C40
        public void GetExpectedContentHeight(){} // RVA: 0x21890
        public void OnFocus(){} // RVA: 0x24B10
        public void OnBlur(){} // RVA: 0x24B10
        public void UpdateBackground(){} // RVA: 0x24A50
        public void get_activeItems(){} // RVA: 0xCD60
        public void StartDragItem(){} // RVA: 0x24B10
        public void EndDrag(){} // RVA: 0x24FA0
    }

    public class ColorPage
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7432CF0
        public void ToNativeColorPage(){} // RVA: 0x7432DA0
    }

    public class Column
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x2F8380
        public void set_name(){} // RVA: 0x73AB5B0
        public void get_title(){} // RVA: 0x2E07C0
        public void set_title(){} // RVA: 0x73AB670
        public void get_icon(){} // RVA: 0x50D1DB0
        public void get_index(){} // RVA: 0x73AB730
        public void get_displayIndex(){} // RVA: 0x73AB820
        public void get_visibleIndex(){} // RVA: 0x73AB910
        public void get_visible(){} // RVA: 0x398C00
        public void set_visible(){} // RVA: 0x73ABA00
        public void get_width(){} // RVA: 0x63D7960
        public void set_width(){} // RVA: 0x73ABA40
        public void get_minWidth(){} // RVA: 0x36B37B0
        public void set_minWidth(){} // RVA: 0x73ABAE0
        public void get_maxWidth(){} // RVA: 0x1C99390
        public void set_maxWidth(){} // RVA: 0x73ABB40
        public void get_desiredWidth(){} // RVA: 0x306000
        public void set_desiredWidth(){} // RVA: 0x73ABBA0
        public void get_sortable(){} // RVA: 0x115A230
        public void set_sortable(){} // RVA: 0x73ABBD0
        public void get_stretchable(){} // RVA: 0x306020
        public void set_stretchable(){} // RVA: 0x73ABC10
        public void get_optional(){} // RVA: 0x311E50
        public void set_optional(){} // RVA: 0x73ABC50
        public void get_resizable(){} // RVA: 0x311E40
        public void set_resizable(){} // RVA: 0x73ABC90
        public void get_makeHeader(){} // RVA: 0x358D50
        public void set_makeHeader(){} // RVA: 0x73ABCD0
        public void get_bindHeader(){} // RVA: 0x3A5590
        public void get_unbindHeader(){} // RVA: 0x4C7C50
        public void get_destroyHeader(){} // RVA: 0x462D00
        public void get_makeCell(){} // RVA: 0x31C010
        public void set_makeCell(){} // RVA: 0x73ABD80
        public void get_bindCell(){} // RVA: 0x796DE0
        public void get_unbindCell(){} // RVA: 0xA1C8C0
        public void get_destroyCell(){} // RVA: 0xA085E0
        public void get_collection(){} // RVA: 0xA1C130
        public void set_collection(){} // RVA: 0xAE5030
        public void add_changed(){} // RVA: 0x73ABE40
        public void remove_changed(){} // RVA: 0x73ABF40
        public void add_resized(){} // RVA: 0x73AC040
        public void remove_resized(){} // RVA: 0x73AC140
        public void NotifyChange(){} // RVA: 0x73AC240
        public void .ctor(){} // RVA: 0x73AC270
        public void .cctor(){} // RVA: 0x73AC2C0
    }

    public class ColumnLayout
    {
        // ── Methods ──
        public void get_columns(){} // RVA: 0x30B0C0
        public void get_columnsWidth(){} // RVA: 0x73AC370
        public void get_minColumnsWidth(){} // RVA: 0x3A7630
        public void get_maxColumnsWidth(){} // RVA: 0x466280
        public void get_hasStretchableColumns(){} // RVA: 0x73AC580
        public void add_layoutRequested(){} // RVA: 0x73AC5D0
        public void remove_layoutRequested(){} // RVA: 0x73AC6C0
        public void .ctor(){} // RVA: 0x73AC7B0
        public void Dirty(){} // RVA: 0x73ACCB0
        public void OnColumnAdded(){} // RVA: 0x73ACD70
        public void OnColumnRemoved(){} // RVA: 0x73ACE70
        public void OnColumnReordered(){} // RVA: 0x73ACF70
        public void RequiresLayoutUpdate(){} // RVA: 0x73ACF80
        public void OnColumnChanged(){} // RVA: 0x73ACFA0
        public void OnColumnResized(){} // RVA: 0x2E2B70
        public void IsClamped(){} // RVA: 0x73ACFD0
        public void DoLayout(){} // RVA: 0x73ACFE0
        public void StretchResizeColumns(){} // RVA: 0x73ADD50
        public void ResizeToFit(){} // RVA: 0x73AEEB0
        public void ResizeColumn(){} // RVA: 0x73AEFC0
        public void BeginDragResize(){} // RVA: 0x73AF100
        public void GetDesiredPosition(){} // RVA: 0x73AF3F0
        public void GetDesiredWidth(){} // RVA: 0x73AF570
        public void DragResize(){} // RVA: 0x73AF630
        public void EndDragResize(){} // RVA: 0x73AF8A0
        public void UpdateCache(){} // RVA: 0x73AFC80
        public void ClearCache(){} // RVA: 0x73AFEE0
    }

    public class Columns
    {
        // ── Methods ──
        public void get_primaryColumnName(){} // RVA: 0x4976A0
        public void set_primaryColumnName(){} // RVA: 0x73B0180
        public void get_reorderable(){} // RVA: 0x303450
        public void set_reorderable(){} // RVA: 0x73B0240
        public void get_resizable(){} // RVA: 0x303470
        public void set_resizable(){} // RVA: 0x73B0270
        public void get_resizePreview(){} // RVA: 0x3BE7520
        public void set_resizePreview(){} // RVA: 0x73B02A0
        public void get_displayList(){} // RVA: 0x73B02D0
        public void get_visibleList(){} // RVA: 0x73B02F0
        public void add_changed(){} // RVA: 0x73B0310
        public void remove_changed(){} // RVA: 0x73B0410
        public void get_stretchMode(){} // RVA: 0x1209F00
        public void set_stretchMode(){} // RVA: 0x73B0510
        public void add_columnAdded(){} // RVA: 0x73B0540
        public void remove_columnAdded(){} // RVA: 0x73B0640
        public void add_columnRemoved(){} // RVA: 0x73B0740
        public void remove_columnRemoved(){} // RVA: 0x73B0840
        public void add_columnChanged(){} // RVA: 0x73B0940
        public void remove_columnChanged(){} // RVA: 0x73B0A40
        public void add_columnResized(){} // RVA: 0x73B0B40
        public void remove_columnResized(){} // RVA: 0x73B0C40
        public void add_columnReordered(){} // RVA: 0x73B0D40
        public void remove_columnReordered(){} // RVA: 0x73B0E40
        public void IsPrimary(){} // RVA: 0x73B0F40
        public void GetEnumerator(){} // RVA: 0x73B0FF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x73B0FF0
        public void Add(){} // RVA: 0x73B1040
        public void Clear(){} // RVA: 0x73B10B0
        public void Contains(){} // RVA: 0x73B1340 | overloaded x2
        public void CopyTo(){} // RVA: 0x73B14E0
        public void Remove(){} // RVA: 0x73B15C0
        public void OnColumnChanged(){} // RVA: 0x73B17A0
        public void OnColumnResized(){} // RVA: 0x1351CE0
        public void get_Count(){} // RVA: 0x73B1800
        public void get_IsReadOnly(){} // RVA: 0x73B1850
        public void IndexOf(){} // RVA: 0x73B18A0
        public void Insert(){} // RVA: 0x73B1970
        public void get_Item(){} // RVA: 0x73B1C90 | overloaded x2
        public void ReorderDisplay(){} // RVA: 0x73B1E30
        public void InitOrderColumns(){} // RVA: 0x73B1FB0
        public void DirtyVisibleColumns(){} // RVA: 0x73B2080
        public void UpdateVisibleColumns(){} // RVA: 0x73B20F0
        public void NotifyChange(){} // RVA: 0x4EEA9A0
        public void .ctor(){} // RVA: 0x73B23C0
    }

    public class CommandEventBase`1
    {
        // ── Methods ──
        public void get_commandName(){} // RVA: 0xCD60
        public void set_commandName(){} // RVA: 0x24B10
        public void Init(){} // RVA: 0x24A50
        public void LocalInit(){} // RVA: 0x24A50
        public void GetPooled(){} // RVA: 0x283FA0 | overloaded x2
        public void .ctor(){} // RVA: 0x24A50
    }

    public class CommandEventDispatchingStrategy
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x73E5EE0
        public void DispatchEvent(){} // RVA: 0x73E5F30
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ComputedStyle
    {
        // ── Methods ──
        public void get_customPropertiesCount(){} // RVA: 0x7417600
        public void get_hasTransition(){} // RVA: 0x7417650
        public void FinalizeApply(){} // RVA: 0x7417670
        public void SyncWithLayout(){} // RVA: 0x7417850
        public void ApplyGlobalKeyword(){} // RVA: 0x7418730 | overloaded x2
        public void RemoveCustomStyleProperty(){} // RVA: 0x7418750
        public void ApplyCustomStyleProperty(){} // RVA: 0x7418800
        public void ApplyAllPropertyInitial(){} // RVA: 0x7418A20
        public void ResetComputedTransitions(){} // RVA: 0x4AED90
        public void StartAnimationInlineTranslate(){} // RVA: 0x7418AC0
        public void get_alignContent(){} // RVA: 0x7418CA0
        public void get_alignItems(){} // RVA: 0x7418CF0
        public void get_alignSelf(){} // RVA: 0x7418D40
        public void get_backgroundColor(){} // RVA: 0x7418D90
        public void get_backgroundImage(){} // RVA: 0x7418DF0
        public void get_backgroundPositionX(){} // RVA: 0x7418E50
        public void get_backgroundPositionY(){} // RVA: 0x7418EB0
        public void get_backgroundRepeat(){} // RVA: 0x7418F10
        public void get_backgroundSize(){} // RVA: 0x7418F60
        public void get_borderBottomColor(){} // RVA: 0x7418FC0
        public void get_borderBottomLeftRadius(){} // RVA: 0x7419020
        public void get_borderBottomRightRadius(){} // RVA: 0x7419070
        public void get_borderBottomWidth(){} // RVA: 0x74190C0
        public void get_borderLeftColor(){} // RVA: 0x7419110
        public void get_borderLeftWidth(){} // RVA: 0x7419170
        public void get_borderRightColor(){} // RVA: 0x74191C0
        public void get_borderRightWidth(){} // RVA: 0x7419220
        public void get_borderTopColor(){} // RVA: 0x7419270
        public void get_borderTopLeftRadius(){} // RVA: 0x74192D0
        public void get_borderTopRightRadius(){} // RVA: 0x7419320
        public void get_borderTopWidth(){} // RVA: 0x7419370
        public void get_bottom(){} // RVA: 0x74193C0
        public void get_color(){} // RVA: 0x7419410
        public void get_cursor(){} // RVA: 0x7419470
        public void get_display(){} // RVA: 0x74194D0
        public void get_flexBasis(){} // RVA: 0x7419520
        public void get_flexDirection(){} // RVA: 0x7419570
        public void get_flexGrow(){} // RVA: 0x74195C0
        public void get_flexShrink(){} // RVA: 0x7419610
        public void get_flexWrap(){} // RVA: 0x7419660
        public void get_fontSize(){} // RVA: 0x74196B0
        public void get_height(){} // RVA: 0x7419700
        public void get_justifyContent(){} // RVA: 0x7419750
        public void get_left(){} // RVA: 0x74197A0
        public void get_letterSpacing(){} // RVA: 0x74197F0
        public void get_marginBottom(){} // RVA: 0x7419840
        public void get_marginLeft(){} // RVA: 0x7419890
        public void get_marginRight(){} // RVA: 0x74198E0
        public void get_marginTop(){} // RVA: 0x7419930
        public void get_maxHeight(){} // RVA: 0x7419980
        public void get_maxWidth(){} // RVA: 0x74199D0
        public void get_minHeight(){} // RVA: 0x7419A20
        public void get_minWidth(){} // RVA: 0x7419A70
        public void get_opacity(){} // RVA: 0x7419AC0
        public void get_overflow(){} // RVA: 0x7419B10
        public void get_paddingBottom(){} // RVA: 0x7419B60
        public void get_paddingLeft(){} // RVA: 0x7419BB0
        public void get_paddingRight(){} // RVA: 0x7419C00
        public void get_paddingTop(){} // RVA: 0x7419C50
        public void get_position(){} // RVA: 0x7419CA0
        public void get_right(){} // RVA: 0x7419CF0
        public void get_rotate(){} // RVA: 0x7419D40
        public void get_scale(){} // RVA: 0x7419DA0
        public void get_textOverflow(){} // RVA: 0x7419E00
        public void get_textShadow(){} // RVA: 0x7419E50
        public void get_top(){} // RVA: 0x7419EC0
        public void get_transformOrigin(){} // RVA: 0x7419F10
        public void get_transitionDelay(){} // RVA: 0x7419F70
        public void get_transitionDuration(){} // RVA: 0x7419FC0
        public void get_transitionProperty(){} // RVA: 0x741A010
        public void get_transitionTimingFunction(){} // RVA: 0x741A060
        public void get_translate(){} // RVA: 0x741A0B0
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x741A110
        public void get_unityFont(){} // RVA: 0x741A170
        public void get_unityFontDefinition(){} // RVA: 0x741A1C0
        public void get_unityFontStyleAndWeight(){} // RVA: 0x741A220
        public void get_unityOverflowClipBox(){} // RVA: 0x741A270
        public void get_unityParagraphSpacing(){} // RVA: 0x741A2C0
        public void get_unitySliceBottom(){} // RVA: 0x741A310
        public void get_unitySliceLeft(){} // RVA: 0x741A360
        public void get_unitySliceRight(){} // RVA: 0x741A3B0
        public void get_unitySliceScale(){} // RVA: 0x741A400
        public void get_unitySliceTop(){} // RVA: 0x741A450
        public void get_unityTextAlign(){} // RVA: 0x741A4A0
        public void get_unityTextOutlineColor(){} // RVA: 0x741A4F0
        public void get_unityTextOutlineWidth(){} // RVA: 0x741A550
        public void get_unityTextOverflowPosition(){} // RVA: 0x741A5A0
        public void get_visibility(){} // RVA: 0x741A5F0
        public void get_whiteSpace(){} // RVA: 0x741A640
        public void get_width(){} // RVA: 0x741A690
        public void get_wordSpacing(){} // RVA: 0x741A6E0
        public void Create(){} // RVA: 0x741A730
        public void CreateInitial(){} // RVA: 0x741ABE0
        public void Acquire(){} // RVA: 0x741B380
        public void Release(){} // RVA: 0x741B570
        public void CopyFrom(){} // RVA: 0x741B660
        public void ApplyProperties(){} // RVA: 0x741B880
        public void ApplyStyleValue(){} // RVA: 0x741CCD0
        public void ApplyStyleValueManaged(){} // RVA: 0x741DAE0
        public void ApplyStyleCursor(){} // RVA: 0x741DF20
        public void ApplyStyleTextShadow(){} // RVA: 0x741DFC0
        public void ApplyFromComputedStyle(){} // RVA: 0x741E030
        public void ApplyPropertyAnimation(){} // RVA: 0x7421F40 | overloaded x15
        public void StartAnimation(){} // RVA: 0x74220A0
        public void StartAnimationAllProperty(){} // RVA: 0x7425E90
        public void StartAnimationInline(){} // RVA: 0x74285B0
        public void ApplyStyleTransformOrigin(){} // RVA: 0x742B3B0
        public void ApplyStyleTranslate(){} // RVA: 0x742B410
        public void ApplyStyleRotate(){} // RVA: 0x742B470
        public void ApplyStyleScale(){} // RVA: 0x742B4D0
        public void ApplyStyleBackgroundSize(){} // RVA: 0x742B530
        public void ApplyInitialValue(){} // RVA: 0x742B5E0 | overloaded x2
        public void ApplyUnsetValue(){} // RVA: 0x742D7C0 | overloaded x2
        public void CompareChanges(){} // RVA: 0x742DBE0
    }

    public class ComputedTransitionProperty
    {
    }

    public class ComputedTransitionUtils
    {
        // ── Methods ──
        public void UpdateComputedTransitions(){} // RVA: 0x743DA30
        public void HasTransitionProperty(){} // RVA: 0x743DAE0
        public void GetTransitionProperty(){} // RVA: 0x743DBB0
        public void GetOrComputeTransitionPropertyData(){} // RVA: 0x743DCD0
        public void GetTransitionHashCode(){} // RVA: 0x743DFA0
        public void SameTransitionProperty(){} // RVA: 0x743ECA0 | overloaded x3
        public void ComputeTransitionPropertyData(){} // RVA: 0x743EDB0
        public void GetWrappingTransitionData(){} // RVA: 0x283FA0
        public void ConvertTransitionTime(){} // RVA: 0x743F1E0
        public void ConvertTransitionFunction(){} // RVA: 0x743F210
        public void .cctor(){} // RVA: 0x7440440
    }

    public class ContextClickEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F0100
        public void .ctor(){} // RVA: 0x73F01F0
    }

    public class ContextualMenuManager
    {
        // ── Methods ──
        public void get_displayMenuHandledOSX(){} // RVA: 0x3A75E0
        public void set_displayMenuHandledOSX(){} // RVA: 0x3A75F0
        public void DisplayMenuIfEventMatches(){} // RVA: 0x2DC60
        public void DisplayMenu(){} // RVA: 0x72F6EA0
        public void DoDisplayMenu(){} // RVA: 0x2DC60
    }

    public class ContextualMenuManipulator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72F7250
        public void RegisterCallbacksOnTarget(){} // RVA: 0x72F7510
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x72F7830
        public void OnMouseUpDownEvent(){} // RVA: 0x72F7B80
        public void OnMouseDownEventOSX(){} // RVA: 0x72F7C70
        public void OnMouseUpEventOSX(){} // RVA: 0x72F7CD0
        public void OnKeyUpEvent(){} // RVA: 0x72F7D30
        public void DoDisplayMenu(){} // RVA: 0x72F7DD0
        public void OnContextualMenuEvent(){} // RVA: 0xB89A80
    }

    public class ContextualMenuPopulateEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F1ED0
        public void get_menu(){} // RVA: 0x348120
        public void set_menu(){} // RVA: 0x348130
        public void get_triggerEvent(){} // RVA: 0x435460
        public void set_triggerEvent(){} // RVA: 0x435470
        public void GetPooled(){} // RVA: 0x73F1FC0
        public void Init(){} // RVA: 0x73F2550
        public void LocalInit(){} // RVA: 0x73F2620
        public void .ctor(){} // RVA: 0x73F2780
        public void PostDispatch(){} // RVA: 0x73F27D0
    }

    public class CountingBloomFilter
    {
        // ── Methods ──
        public void AdjustSlot(){} // RVA: 0x73D2690
        public void Hash1(){} // RVA: 0x73D26C0
        public void Hash2(){} // RVA: 0x73D26D0
        public void IsSlotEmpty(){} // RVA: 0x73D26E0
        public void InsertHash(){} // RVA: 0x73D26F0
        public void RemoveHash(){} // RVA: 0x73D2720
        public void ContainsHash(){} // RVA: 0x73D2750
    }

    public class CreationContext
    {
        // ── Methods ──
        public void get_target(){} // RVA: 0x1AD4690
        public void set_target(){} // RVA: 0x100A2F0
        public void get_visualTreeAsset(){} // RVA: 0x19689C0
        public void set_visualTreeAsset(){} // RVA: 0x1968950
        public void get_slotInsertionPoints(){} // RVA: 0x2F8380
        public void set_slotInsertionPoints(){} // RVA: 0x2DEE30
        public void get_attributeOverrides(){} // RVA: 0x2E07C0
        public void set_attributeOverrides(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x7325A40 | overloaded x2
        public void Equals(){} // RVA: 0x7325CC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7325E40
        public void .cctor(){} // RVA: 0x7325F80
    }

    public class Cursor
    {
        // ── Methods ──
        public void get_texture(){} // RVA: 0x1AD4690
        public void set_texture(){} // RVA: 0x100A2F0
        public void get_hotspot(){} // RVA: 0x37CA1B0
        public void set_hotspot(){} // RVA: 0x1EE8D20
        public void get_defaultCursorId(){} // RVA: 0x32A5C0
        public void set_defaultCursorId(){} // RVA: 0x2E00C0
        public void Equals(){} // RVA: 0x73D2E70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x73D2F20
        public void op_Equality(){} // RVA: 0x73D3000
        public void ToString(){} // RVA: 0x73D3030
    }

    public class CursorManager
    {
        // ── Methods ──
        public void get_isCursorOverriden(){} // RVA: 0x3A75E0
        public void set_isCursorOverriden(){} // RVA: 0x3A75F0
        public void SetCursor(){} // RVA: 0x73D30F0
        public void ResetCursor(){} // RVA: 0x73D3310
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CustomStyleProperty`1
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0xCD60
        public void set_name(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24B10
        public void Equals(){} // RVA: 0x283FA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840
    }

    public class CustomStyleResolvedEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F9F30
        public void get_customStyle(){} // RVA: 0x73FA020
        public void .ctor(){} // RVA: 0x73FA0B0
    }

}