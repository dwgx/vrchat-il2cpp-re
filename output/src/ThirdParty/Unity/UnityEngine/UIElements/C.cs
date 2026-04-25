// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 14
// Methods: 396

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class CallbackEventHandler : Object
    {
        // ── Methods ──
        public void RegisterCallback(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void AddEventCategories(){} // RVA: 0x7FFD4E090980
        public void UnregisterCallback(){} // RVA: 0x7FFD4E097970
        public void SendEvent(){} // RVA: 0x7FFD4E097970 | overloaded x2
        public void HandleEventAtTargetPhase(){} // RVA: 0x7FFD54FA1AB0
        public void HandleEventAtTargetAndDefaultPhase(){} // RVA: 0x7FFD54FA1B30
        public void HandleEventAtCurrentTargetAndPhase(){} // RVA: 0x7FFD51DC3D80
        public void UnityEngine.UIElements.IEventHandler.HandleEvent(){} // RVA: 0x7FFD51DC3D80
        public void HandleEvent(){} // RVA: 0x7FFD54FA1BE0
        public void HasTrickleDownHandlers(){} // RVA: 0x7FFD54FA1F00
        public void HasBubbleUpHandlers(){} // RVA: 0x7FFD54FA1F30
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFD4E341310
        public void ExecuteDefaultAction(){} // RVA: 0x7FFD4E341310
        public void ExecuteDefaultActionDisabledAtTarget(){} // RVA: 0x7FFD4E341310
        public void ExecuteDefaultActionDisabled(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E64C880
    }

    public class ChangeEvent`1 : EventBase`1
    {
        public object previousValue;
        public object newValue;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void get_previousValue(){} // RVA: 0x7FFD4E2ADC40
        public void set_previousValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_newValue(){} // RVA: 0x7FFD4E2ADC40
        public void set_newValue(){} // RVA: 0x7FFD4E2ADC40
        public void Init(){} // RVA: 0x7FFD4E090980
        public void LocalInit(){} // RVA: 0x7FFD4E090980
        public void GetPooled(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ClampedDragger`1 : Clickable
    {
        public object dragDirection;
        public object slider;
        public object startMousePosition;
        public object delta;

        // ── Methods ──
        public void add_dragging(){} // RVA: 0x7FFD4E090A40
        public void remove_dragging(){} // RVA: 0x7FFD4E090A40
        public void add_draggingEnded(){} // RVA: 0x7FFD4E090A40
        public void remove_draggingEnded(){} // RVA: 0x7FFD4E090A40
        public void get_dragDirection(){} // RVA: 0x7FFD4E2ADC40
        public void set_dragDirection(){} // RVA: 0x7FFD4E2ADC40
        public void set_slider(){} // RVA: 0x7FFD4E090A40
        public void get_startMousePosition(){} // RVA: 0x7FFD4E078E90
        public void set_startMousePosition(){} // RVA: 0x7FFD4E09F3E0
        public void get_delta(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E09AF60
        public void ProcessDownEvent(){}
        public void ProcessUpEvent(){}
        public void ProcessMoveEvent(){}
    }

    public class Clickable : PointerManipulator
    {
        public object active;
        public object lastMousePosition;
        public object acceptClicksIfDisabled;
        public object invokePolicy;

        // ── Methods ──
        public void add_clickedWithEventInfo(){} // RVA: 0x7FFD54E9FF00
        public void remove_clickedWithEventInfo(){} // RVA: 0x7FFD54EA0000
        public void add_clicked(){} // RVA: 0x7FFD54EA0100
        public void remove_clicked(){} // RVA: 0x7FFD54EA01F0
        public void get_active(){} // RVA: 0x7FFD4E55F600
        public void set_active(){} // RVA: 0x7FFD4ECB2770
        public void get_lastMousePosition(){} // RVA: 0x7FFD54EA02E0
        public void set_lastMousePosition(){} // RVA: 0x7FFD53790D30
        public void get_acceptClicksIfDisabled(){} // RVA: 0x7FFD4E409570
        public void set_acceptClicksIfDisabled(){} // RVA: 0x7FFD54EA0300
        public void get_invokePolicy(){} // RVA: 0x7FFD54EA0350
        public void .ctor(){} // RVA: 0x7FFD54EA0500 | overloaded x3
        public void OnTimer(){} // RVA: 0x7FFD54EA0670
        public void IsRepeatable(){} // RVA: 0x7FFD54EA0770
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFD54EA0790
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFD54EA0C90
        public void OnMouseDown(){} // RVA: 0x7FFD54EA11C0
        public void OnMouseMove(){} // RVA: 0x7FFD54EA12B0
        public void OnMouseUp(){} // RVA: 0x7FFD54EA1330
        public void OnMouseCaptureOut(){} // RVA: 0x7FFD54EA1460
        public void OnPointerDown(){} // RVA: 0x7FFD54EA14F0
        public void OnPointerMove(){} // RVA: 0x7FFD54EA1680
        public void OnPointerUp(){} // RVA: 0x7FFD54EA17E0
        public void OnPointerCancel(){} // RVA: 0x7FFD54EA19A0
        public void OnPointerCaptureOut(){} // RVA: 0x7FFD54EA1AC0
        public void ContainsPointer(){} // RVA: 0x7FFD54EA1BA0
        public void IsNotMouseEvent(){} // RVA: 0x7FFD54EA1C30
        public void Invoke(){} // RVA: 0x7FFD54EA1C90
        public void SimulateSingleClick(){} // RVA: 0x7FFD54EA1CE0
        public void ProcessDownEvent(){} // RVA: 0x7FFD54EA1E20
        public void ProcessMoveEvent(){} // RVA: 0x7FFD54EA21E0
        public void ProcessUpEvent(){} // RVA: 0x7FFD54EA2250
        public void ProcessCancelEvent(){} // RVA: 0x7FFD54EA2440
        public void <SimulateSingleClick>b__43_0(){} // RVA: 0x7FFD54EA25C0
    }

    public class CollectionViewController : Object
    {
        public object itemsSource;
        public object view;

        // ── Methods ──
        public void add_itemsSourceChanged(){} // RVA: 0x7FFD54EA9BB0
        public void remove_itemsSourceChanged(){} // RVA: 0x7FFD54EA9CA0
        public void add_itemIndexChanged(){} // RVA: 0x7FFD54EA9D90
        public void remove_itemIndexChanged(){} // RVA: 0x7FFD54EA9E90
        public void get_itemsSource(){} // RVA: 0x7FFD4E3447C0
        public void set_itemsSource(){} // RVA: 0x7FFD54EA9F90
        public void SetItemsSourceWithoutNotify(){} // RVA: 0x7FFD4E3A7E80
        public void get_view(){} // RVA: 0x7FFD4E35C380
        public void SetView(){} // RVA: 0x7FFD54EAA080
        public void PrepareView(){} // RVA: 0x7FFD4E341310
        public void Dispose(){} // RVA: 0x7FFD54EAA170
        public void GetItemsCount(){} // RVA: 0x7FFD54EAA270
        public void GetItemsMinCount(){} // RVA: 0x7FFD4E4A21C0
        public void GetIndexForId(){} // RVA: 0x7FFD511BE3E0
        public void GetIdForIndex(){} // RVA: 0x7FFD511BE3E0
        public void GetItemForIndex(){} // RVA: 0x7FFD54EAA2D0
        public void InvokeMakeItem(){} // RVA: 0x7FFD54EAA370
        public void InvokeBindItem(){} // RVA: 0x7FFD54EAA3C0
        public void InvokeUnbindItem(){} // RVA: 0x7FFD54EAA4A0
        public void InvokeDestroyItem(){} // RVA: 0x7FFD54EAA4E0
        public void MakeItem(){} // RVA: 0x7FFD4E078E90
        public void BindItem(){} // RVA: 0x7FFD4E097970
        public void UnbindItem(){} // RVA: 0x7FFD4E097970
        public void DestroyItem(){} // RVA: 0x7FFD4E090A40
        public void RaiseItemsSourceChanged(){} // RVA: 0x7FFD4E6232C0
        public void RaiseItemIndexChanged(){} // RVA: 0x7FFD54EA9700
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class CollectionVirtualizationController : Object
    {
        public object firstVisibleIndex;
        public object visibleItemCount;
        public object activeItems;

        // ── Methods ──
        public void get_firstVisibleIndex(){} // RVA: 0x7FFD4E079960
        public void set_firstVisibleIndex(){} // RVA: 0x7FFD4E090ED0
        public void get_visibleItemCount(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void Refresh(){} // RVA: 0x7FFD4E091060
        public void ScrollToItem(){} // RVA: 0x7FFD4E090ED0
        public void Resize(){} // RVA: 0x7FFD4E09F3E0
        public void OnScroll(){} // RVA: 0x7FFD4E09F3E0
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7FFD4E08DC30
        public void GetExpectedContentHeight(){} // RVA: 0x7FFD4E08D880
        public void OnFocus(){} // RVA: 0x7FFD4E090A40
        public void OnBlur(){} // RVA: 0x7FFD4E090A40
        public void UpdateBackground(){} // RVA: 0x7FFD4E090980
        public void get_activeItems(){} // RVA: 0x7FFD4E078E90
        public void StartDragItem(){} // RVA: 0x7FFD4E090A40
        public void EndDrag(){} // RVA: 0x7FFD4E090ED0
    }

    public class Column : Object
    {
        public object name;
        public object title;
        public object icon;
        public object index;
        public object displayIndex;
        public object visibleIndex;
        public object visible;
        public object width;
        public object minWidth;
        public object maxWidth;
        public object desiredWidth;
        public object sortable;
        public object stretchable;
        public object optional;
        public object resizable;
        public object makeHeader;
        public object bindHeader;
        public object unbindHeader;
        public object destroyHeader;
        public object makeCell;
        public object bindCell;
        public object unbindCell;
        public object destroyCell;
        public object collection;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E35C380
        public void set_name(){} // RVA: 0x7FFD54F62E90
        public void get_title(){} // RVA: 0x7FFD4E3447C0
        public void set_title(){} // RVA: 0x7FFD54F62F50
        public void get_icon(){} // RVA: 0x7FFD54F63010
        public void get_index(){} // RVA: 0x7FFD54F63030
        public void get_displayIndex(){} // RVA: 0x7FFD54F63120
        public void get_visibleIndex(){} // RVA: 0x7FFD54F63210
        public void get_visible(){} // RVA: 0x7FFD4E3FCC00
        public void set_visible(){} // RVA: 0x7FFD54F63300
        public void get_width(){} // RVA: 0x7FFD53F8ED10
        public void set_width(){} // RVA: 0x7FFD54F63340
        public void get_minWidth(){} // RVA: 0x7FFD514003C0
        public void set_minWidth(){} // RVA: 0x7FFD54F633E0
        public void get_maxWidth(){} // RVA: 0x7FFD4FBE2A90
        public void set_maxWidth(){} // RVA: 0x7FFD54F63440
        public void get_desiredWidth(){} // RVA: 0x7FFD4E36A000
        public void set_desiredWidth(){} // RVA: 0x7FFD54F634A0
        public void get_sortable(){} // RVA: 0x7FFD4F031000
        public void set_sortable(){} // RVA: 0x7FFD54F634D0
        public void get_stretchable(){} // RVA: 0x7FFD4E36A020
        public void set_stretchable(){} // RVA: 0x7FFD54F63510
        public void get_optional(){} // RVA: 0x7FFD4E375E50
        public void set_optional(){} // RVA: 0x7FFD54F63550
        public void get_resizable(){} // RVA: 0x7FFD4E375E40
        public void set_resizable(){} // RVA: 0x7FFD54F63590
        public void get_makeHeader(){} // RVA: 0x7FFD4E3BCD50
        public void set_makeHeader(){} // RVA: 0x7FFD54F635D0
        public void get_bindHeader(){} // RVA: 0x7FFD4E409590
        public void get_unbindHeader(){} // RVA: 0x7FFD4E505600
        public void get_destroyHeader(){} // RVA: 0x7FFD4E70F410
        public void get_makeCell(){} // RVA: 0x7FFD4E380010
        public void set_makeCell(){} // RVA: 0x7FFD54F63680
        public void get_bindCell(){} // RVA: 0x7FFD4E70F640
        public void get_unbindCell(){} // RVA: 0x7FFD4E96DFB0
        public void get_destroyCell(){} // RVA: 0x7FFD4E963900
        public void get_collection(){} // RVA: 0x7FFD4E96B1A0
        public void set_collection(){} // RVA: 0x7FFD4E76B370
        public void add_changed(){} // RVA: 0x7FFD54F63740
        public void remove_changed(){} // RVA: 0x7FFD54F63840
        public void add_resized(){} // RVA: 0x7FFD54F63940
        public void remove_resized(){} // RVA: 0x7FFD54F63A40
        public void NotifyChange(){} // RVA: 0x7FFD54F63B40
        public void .ctor(){} // RVA: 0x7FFD54F63B70
        public void .cctor(){} // RVA: 0x7FFD54F63BC0
    }

    public class Columns : Object
    {
        public object primaryColumnName;
        public object reorderable;
        public object resizable;
        public object resizePreview;
        public object displayList;
        public object visibleList;
        public object stretchMode;
        public object Count;
        public object IsReadOnly;
        public object Item;
        public object Item;

        // ── Methods ──
        public void get_primaryColumnName(){} // RVA: 0x7FFD4E5F0140
        public void set_primaryColumnName(){} // RVA: 0x7FFD54F67A80
        public void get_reorderable(){} // RVA: 0x7FFD4E367450
        public void set_reorderable(){} // RVA: 0x7FFD54F67B40
        public void get_resizable(){} // RVA: 0x7FFD4E367470
        public void set_resizable(){} // RVA: 0x7FFD54F67B70
        public void get_resizePreview(){} // RVA: 0x7FFD5190B050
        public void set_resizePreview(){} // RVA: 0x7FFD54F67BA0
        public void get_displayList(){} // RVA: 0x7FFD54F67BD0
        public void get_visibleList(){} // RVA: 0x7FFD54F67BF0
        public void add_changed(){} // RVA: 0x7FFD54F67C10
        public void remove_changed(){} // RVA: 0x7FFD54F67D10
        public void get_stretchMode(){} // RVA: 0x7FFD4F0A91D0
        public void set_stretchMode(){} // RVA: 0x7FFD54F67E10
        public void add_columnAdded(){} // RVA: 0x7FFD54F67E40
        public void remove_columnAdded(){} // RVA: 0x7FFD54F67F40
        public void add_columnRemoved(){} // RVA: 0x7FFD54F68040
        public void remove_columnRemoved(){} // RVA: 0x7FFD54F68140
        public void add_columnChanged(){} // RVA: 0x7FFD54F68240
        public void remove_columnChanged(){} // RVA: 0x7FFD54F68340
        public void add_columnResized(){} // RVA: 0x7FFD54F68440
        public void remove_columnResized(){} // RVA: 0x7FFD54F68540
        public void add_columnReordered(){} // RVA: 0x7FFD54F68640
        public void remove_columnReordered(){} // RVA: 0x7FFD54F68740
        public void IsPrimary(){} // RVA: 0x7FFD54F68840
        public void GetEnumerator(){} // RVA: 0x7FFD54F688F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD54F688F0
        public void Add(){} // RVA: 0x7FFD54F68940
        public void Clear(){} // RVA: 0x7FFD54F689B0
        public void Contains(){} // RVA: 0x7FFD54F68C40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFD54F68DE0
        public void Remove(){} // RVA: 0x7FFD54F68EC0
        public void OnColumnChanged(){} // RVA: 0x7FFD54F690A0
        public void OnColumnResized(){} // RVA: 0x7FFD4F295B70
        public void get_Count(){} // RVA: 0x7FFD54F69100
        public void get_IsReadOnly(){} // RVA: 0x7FFD54F69150
        public void IndexOf(){} // RVA: 0x7FFD54F691A0
        public void Insert(){} // RVA: 0x7FFD54F69270
        public void get_Item(){} // RVA: 0x7FFD54F69590 | overloaded x2
        public void ReorderDisplay(){} // RVA: 0x7FFD54F69730
        public void InitOrderColumns(){} // RVA: 0x7FFD54F698B0
        public void DirtyVisibleColumns(){} // RVA: 0x7FFD54F69980
        public void UpdateVisibleColumns(){} // RVA: 0x7FFD54F699F0
        public void NotifyChange(){} // RVA: 0x7FFD52C90F30
        public void .ctor(){} // RVA: 0x7FFD54F69CC0
    }

    public class CommandEventBase`1 : EventBase`1
    {
        public object commandName;

        // ── Methods ──
        public void get_commandName(){} // RVA: 0x7FFD4E078E90
        public void set_commandName(){} // RVA: 0x7FFD4E090A40
        public void Init(){} // RVA: 0x7FFD4E090980
        public void LocalInit(){} // RVA: 0x7FFD4E090980
        public void GetPooled(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ComputedStyle : ValueType
    {
        public object customPropertiesCount;
        public object hasTransition;
        public object alignContent;
        public object alignItems;
        public object alignSelf;
        public object backgroundColor;
        public object backgroundImage;
        public object backgroundPositionX;
        public object backgroundPositionY;
        public object backgroundRepeat;
        public object backgroundSize;
        public object borderBottomColor;
        public object borderBottomLeftRadius;
        public object borderBottomRightRadius;
        public object borderBottomWidth;
        public object borderLeftColor;
        public object borderLeftWidth;
        public object borderRightColor;
        public object borderRightWidth;
        public object borderTopColor;
        public object borderTopLeftRadius;
        public object borderTopRightRadius;
        public object borderTopWidth;
        public object bottom;
        public object color;
        public object cursor;
        public object display;
        public object flexBasis;
        public object flexDirection;
        public object flexGrow;
        public object flexShrink;
        public object flexWrap;
        public object fontSize;
        public object height;
        public object justifyContent;
        public object left;
        public object letterSpacing;
        public object marginBottom;
        public object marginLeft;
        public object marginRight;
        public object marginTop;
        public object maxHeight;
        public object maxWidth;
        public object minHeight;
        public object minWidth;
        public object opacity;
        public object overflow;
        public object paddingBottom;
        public object paddingLeft;
        public object paddingRight;
        public object paddingTop;
        public object position;
        public object right;
        public object rotate;
        public object scale;
        public object textOverflow;
        public object textShadow;
        public object top;
        public object transformOrigin;
        public object transitionDelay;
        public object transitionDuration;
        public object transitionProperty;
        public object transitionTimingFunction;
        public object translate;
        public object unityBackgroundImageTintColor;
        public object unityFont;
        public object unityFontDefinition;
        public object unityFontStyleAndWeight;
        public object unityOverflowClipBox;
        public object unityParagraphSpacing;
        public object unitySliceBottom;
        public object unitySliceLeft;
        public object unitySliceRight;
        public object unitySliceScale;
        public object unitySliceTop;
        public object unityTextAlign;
        public object unityTextOutlineColor;
        public object unityTextOutlineWidth;
        public object unityTextOverflowPosition;
        public object visibility;
        public object whiteSpace;
        public object width;
        public object wordSpacing;

        // ── Methods ──
        public void get_customPropertiesCount(){} // RVA: 0x7FFD54FCEEF0
        public void get_hasTransition(){} // RVA: 0x7FFD54FCEF40
        public void FinalizeApply(){} // RVA: 0x7FFD54FCEF60
        public void SyncWithLayout(){} // RVA: 0x7FFD54FCF140
        public void ApplyGlobalKeyword(){} // RVA: 0x7FFD54FD0020 | overloaded x2
        public void RemoveCustomStyleProperty(){} // RVA: 0x7FFD54FD0040
        public void ApplyCustomStyleProperty(){} // RVA: 0x7FFD54FD00F0
        public void ApplyAllPropertyInitial(){} // RVA: 0x7FFD54FD0310
        public void ResetComputedTransitions(){} // RVA: 0x7FFD4F8EE0C0
        public void StartAnimationInlineTranslate(){} // RVA: 0x7FFD54FD03B0
        public void get_alignContent(){} // RVA: 0x7FFD54FD0590
        public void get_alignItems(){} // RVA: 0x7FFD54FD05E0
        public void get_alignSelf(){} // RVA: 0x7FFD54FD0630
        public void get_backgroundColor(){} // RVA: 0x7FFD54FD0680
        public void get_backgroundImage(){} // RVA: 0x7FFD54FD06E0
        public void get_backgroundPositionX(){} // RVA: 0x7FFD54FD0740
        public void get_backgroundPositionY(){} // RVA: 0x7FFD54FD07A0
        public void get_backgroundRepeat(){} // RVA: 0x7FFD54FD0800
        public void get_backgroundSize(){} // RVA: 0x7FFD54FD0850
        public void get_borderBottomColor(){} // RVA: 0x7FFD54FD08B0
        public void get_borderBottomLeftRadius(){} // RVA: 0x7FFD54FD0910
        public void get_borderBottomRightRadius(){} // RVA: 0x7FFD54FD0960
        public void get_borderBottomWidth(){} // RVA: 0x7FFD54FD09B0
        public void get_borderLeftColor(){} // RVA: 0x7FFD54FD0A00
        public void get_borderLeftWidth(){} // RVA: 0x7FFD54FD0A60
        public void get_borderRightColor(){} // RVA: 0x7FFD54FD0AB0
        public void get_borderRightWidth(){} // RVA: 0x7FFD54FD0B10
        public void get_borderTopColor(){} // RVA: 0x7FFD54FD0B60
        public void get_borderTopLeftRadius(){} // RVA: 0x7FFD54FD0BC0
        public void get_borderTopRightRadius(){} // RVA: 0x7FFD54FD0C10
        public void get_borderTopWidth(){} // RVA: 0x7FFD54FD0C60
        public void get_bottom(){} // RVA: 0x7FFD54FD0CB0
        public void get_color(){} // RVA: 0x7FFD54FD0D00
        public void get_cursor(){} // RVA: 0x7FFD54FD0D60
        public void get_display(){} // RVA: 0x7FFD54FD0DC0
        public void get_flexBasis(){} // RVA: 0x7FFD54FD0E10
        public void get_flexDirection(){} // RVA: 0x7FFD54FD0E60
        public void get_flexGrow(){} // RVA: 0x7FFD54FD0EB0
        public void get_flexShrink(){} // RVA: 0x7FFD54FD0F00
        public void get_flexWrap(){} // RVA: 0x7FFD54FD0F50
        public void get_fontSize(){} // RVA: 0x7FFD54FD0FA0
        public void get_height(){} // RVA: 0x7FFD54FD0FF0
        public void get_justifyContent(){} // RVA: 0x7FFD54FD1040
        public void get_left(){} // RVA: 0x7FFD54FD1090
        public void get_letterSpacing(){} // RVA: 0x7FFD54FD10E0
        public void get_marginBottom(){} // RVA: 0x7FFD54FD1130
        public void get_marginLeft(){} // RVA: 0x7FFD54FD1180
        public void get_marginRight(){} // RVA: 0x7FFD54FD11D0
        public void get_marginTop(){} // RVA: 0x7FFD54FD1220
        public void get_maxHeight(){} // RVA: 0x7FFD54FD1270
        public void get_maxWidth(){} // RVA: 0x7FFD54FD12C0
        public void get_minHeight(){} // RVA: 0x7FFD54FD1310
        public void get_minWidth(){} // RVA: 0x7FFD54FD1360
        public void get_opacity(){} // RVA: 0x7FFD54FD13B0
        public void get_overflow(){} // RVA: 0x7FFD54FD1400
        public void get_paddingBottom(){} // RVA: 0x7FFD54FD1450
        public void get_paddingLeft(){} // RVA: 0x7FFD54FD14A0
        public void get_paddingRight(){} // RVA: 0x7FFD54FD14F0
        public void get_paddingTop(){} // RVA: 0x7FFD54FD1540
        public void get_position(){} // RVA: 0x7FFD54FD1590
        public void get_right(){} // RVA: 0x7FFD54FD15E0
        public void get_rotate(){} // RVA: 0x7FFD54FD1630
        public void get_scale(){} // RVA: 0x7FFD54FD1690
        public void get_textOverflow(){} // RVA: 0x7FFD54FD16F0
        public void get_textShadow(){} // RVA: 0x7FFD54FD1740
        public void get_top(){} // RVA: 0x7FFD54FD17B0
        public void get_transformOrigin(){} // RVA: 0x7FFD54FD1800
        public void get_transitionDelay(){} // RVA: 0x7FFD54FD1860
        public void get_transitionDuration(){} // RVA: 0x7FFD54FD18B0
        public void get_transitionProperty(){} // RVA: 0x7FFD54FD1900
        public void get_transitionTimingFunction(){} // RVA: 0x7FFD54FD1950
        public void get_translate(){} // RVA: 0x7FFD54FD19A0
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7FFD54FD1A00
        public void get_unityFont(){} // RVA: 0x7FFD54FD1A60
        public void get_unityFontDefinition(){} // RVA: 0x7FFD54FD1AB0
        public void get_unityFontStyleAndWeight(){} // RVA: 0x7FFD54FD1B10
        public void get_unityOverflowClipBox(){} // RVA: 0x7FFD54FD1B60
        public void get_unityParagraphSpacing(){} // RVA: 0x7FFD54FD1BB0
        public void get_unitySliceBottom(){} // RVA: 0x7FFD54FD1C00
        public void get_unitySliceLeft(){} // RVA: 0x7FFD54FD1C50
        public void get_unitySliceRight(){} // RVA: 0x7FFD54FD1CA0
        public void get_unitySliceScale(){} // RVA: 0x7FFD54FD1CF0
        public void get_unitySliceTop(){} // RVA: 0x7FFD54FD1D40
        public void get_unityTextAlign(){} // RVA: 0x7FFD54FD1D90
        public void get_unityTextOutlineColor(){} // RVA: 0x7FFD54FD1DE0
        public void get_unityTextOutlineWidth(){} // RVA: 0x7FFD54FD1E40
        public void get_unityTextOverflowPosition(){} // RVA: 0x7FFD54FD1E90
        public void get_visibility(){} // RVA: 0x7FFD54FD1EE0
        public void get_whiteSpace(){} // RVA: 0x7FFD54FD1F30
        public void get_width(){} // RVA: 0x7FFD54FD1F80
        public void get_wordSpacing(){} // RVA: 0x7FFD54FD1FD0
        public void Create(){} // RVA: 0x7FFD54FD2020
        public void CreateInitial(){} // RVA: 0x7FFD54FD24D0
        public void Acquire(){} // RVA: 0x7FFD54FD2C70
        public void Release(){} // RVA: 0x7FFD54FD2E60
        public void CopyFrom(){} // RVA: 0x7FFD54FD2F50
        public void ApplyProperties(){} // RVA: 0x7FFD54FD3170
        public void ApplyStyleValue(){} // RVA: 0x7FFD54FD45C0
        public void ApplyStyleValueManaged(){} // RVA: 0x7FFD54FD53D0
        public void ApplyStyleCursor(){} // RVA: 0x7FFD54FD5810
        public void ApplyStyleTextShadow(){} // RVA: 0x7FFD54FD58B0
        public void ApplyFromComputedStyle(){} // RVA: 0x7FFD54FD5920
        public void ApplyPropertyAnimation(){} // RVA: 0x7FFD54FD9830 | overloaded x15
        public void StartAnimation(){} // RVA: 0x7FFD54FD9990
        public void StartAnimationAllProperty(){} // RVA: 0x7FFD54FDD780
        public void StartAnimationInline(){} // RVA: 0x7FFD54FDFEA0
        public void ApplyStyleTransformOrigin(){} // RVA: 0x7FFD54FE2CA0
        public void ApplyStyleTranslate(){} // RVA: 0x7FFD54FE2D00
        public void ApplyStyleRotate(){} // RVA: 0x7FFD54FE2D60
        public void ApplyStyleScale(){} // RVA: 0x7FFD54FE2DC0
        public void ApplyStyleBackgroundSize(){} // RVA: 0x7FFD54FE2E20
        public void ApplyInitialValue(){} // RVA: 0x7FFD54FE2ED0 | overloaded x2
        public void ApplyUnsetValue(){} // RVA: 0x7FFD54FE50B0 | overloaded x2
        public void CompareChanges(){} // RVA: 0x7FFD54FE54D0
    }

    public class ComputedTransitionUtils : Object
    {
        // ── Methods ──
        public void UpdateComputedTransitions(){} // RVA: 0x7FFD54FF5320
        public void HasTransitionProperty(){} // RVA: 0x7FFD54FF53D0
        public void GetTransitionProperty(){} // RVA: 0x7FFD54FF54A0
        public void GetOrComputeTransitionPropertyData(){} // RVA: 0x7FFD54FF55C0
        public void GetTransitionHashCode(){} // RVA: 0x7FFD54FF5890
        public void SameTransitionProperty(){} // RVA: 0x7FFD54FF6590 | overloaded x3
        public void ComputeTransitionPropertyData(){} // RVA: 0x7FFD54FF66A0
        public void GetWrappingTransitionData(){} // RVA: 0x7FFD4E2ADC40
        public void ConvertTransitionTime(){} // RVA: 0x7FFD54FF6AD0
        public void ConvertTransitionFunction(){} // RVA: 0x7FFD54FF6B00
        public void .cctor(){} // RVA: 0x7FFD54FF7D30
    }

    public class CreationContext : ValueType
    {
        public object target;
        public object visualTreeAsset;
        public object slotInsertionPoints;
        public object attributeOverrides;

        // ── Methods ──
        public void get_target(){} // RVA: 0x7FFD4EEF9F60
        public void set_target(){} // RVA: 0x7FFD4ECFFE40
        public void get_visualTreeAsset(){} // RVA: 0x7FFD4F840220
        public void set_visualTreeAsset(){} // RVA: 0x7FFD4F840240
        public void get_slotInsertionPoints(){} // RVA: 0x7FFD4E35C380
        public void set_slotInsertionPoints(){} // RVA: 0x7FFD4E342E30
        public void get_attributeOverrides(){} // RVA: 0x7FFD4E3447C0
        public void set_attributeOverrides(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD54EDD320 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD54EDD5A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54EDD720
        public void .cctor(){} // RVA: 0x7FFD54EDD860
    }

    public class Cursor : ValueType
    {
        public object texture;
        public object hotspot;
        public object defaultCursorId;

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFD4EEF9F60
        public void set_texture(){} // RVA: 0x7FFD4ECFFE40
        public void get_hotspot(){} // RVA: 0x7FFD51515860
        public void set_hotspot(){} // RVA: 0x7FFD4FE268C0
        public void get_defaultCursorId(){} // RVA: 0x7FFD4E38E5C0
        public void set_defaultCursorId(){} // RVA: 0x7FFD4E3440C0
        public void Equals(){} // RVA: 0x7FFD54F8A770 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54F8A820
        public void op_Equality(){} // RVA: 0x7FFD54F8A900
        public void ToString(){} // RVA: 0x7FFD54F8A930
    }

    public class CustomStyleProperty`1 : ValueType
    {
        public object name;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E078E90
        public void set_name(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Equals(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
    }

}