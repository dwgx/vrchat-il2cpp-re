// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 18
// Methods: 195

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class FieldMouseDragger`1 : BaseFieldMouseDragger
    {
        public object m_DrivenField;
        public object m_DragElement;
        public object m_DragHotZone;
        public object _dragging;
        public object _startValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void get_dragging(){} // RVA: 0x87D280
        public void set_dragging(){} // RVA: 0x894750
        public void get_startValue(){} // RVA: 0xA94080
        public void set_startValue(){} // RVA: 0xA94080
        public void SetDragZone(){} // RVA: 0x8943B0
        public void CanStartDrag(){} // RVA: 0xA94080
        public void UpdateValueOnPointerDown(){} // RVA: 0x894320
        public void ProcessDownEvent(){} // RVA: 0x894320
        public void UpdateValueOnPointerMove(){} // RVA: 0x894320
        public void ProcessMoveEvent(){} // RVA: 0xA94080
        public void UpdateValueOnPointerUp(){} // RVA: 0x894320
        public void ProcessUpEvent(){} // RVA: 0x899290
        public void UpdateValueOnKeyDown(){} // RVA: 0x894320
    }

    public class FieldMouseDragger`1 : BaseFieldMouseDragger
    {
        public object m_DrivenField;
        public object m_DragElement;
        public object m_DragHotZone;
        public object _dragging;
        public object _startValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DE0870
    }

    public class FieldMouseDragger`1 : BaseFieldMouseDragger
    {
        public object m_DrivenField;
        public object m_DragElement;
        public object m_DragHotZone;
        public object _dragging;
        public object _startValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DE0870
    }

    public class FixedHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        public object m_ScrolledToItemIndex;
        public object m_ForcedScroll;

        // ── Methods ──
        public void get_resolvedItemHeight(){} // RVA: 0x890F90
        public void VisibleItemPredicate(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894320
        public void OnGeometryChangedEvent(){} // RVA: 0x894320
        public void GetIndexFromPosition(){} // RVA: 0x8833B0
        public void GetExpectedItemHeight(){} // RVA: 0x891330
        public void GetExpectedContentHeight(){} // RVA: 0x890F90
        public void ScrollToItem(){} // RVA: 0x8944F0
        public void Resize(){} // RVA: 0x895F20
        public void OnScroll(){} // RVA: 0x895F20
        public void OnScrollUpdate(){} // RVA: 0x894290
        public void GetOrMakeItemAtIndex(){} // RVA: 0xA94080
        public void EndDrag(){} // RVA: 0x8944F0
    }

    public class FloatField : TextValueField`1
    {
        public object ussClassName;
        public object labelUssClassName;
        public object inputUssClassName;

        // ── Methods ──
        public void get_floatInput(){} // RVA: 0x7FDF080
        public void ValueToString(){} // RVA: 0x7FDF110
        public void StringToValue(){} // RVA: 0x7FDF2D0
        public void UpdateValueFromText(){} // RVA: 0x7FDF400
        public void .ctor(){} // RVA: 0x7FDF500
        public void CanTryParse(){} // RVA: 0x7FDF820
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FDF8B0
        public void .cctor(){} // RVA: 0x7FDF9A0
    }

    public class FocusChangeDirection : Object
    {
        public object _unspecified;
        public object _none;
        public object _lastValue;
        public object m_Value;

        // ── Methods ──
        public void get_unspecified(){} // RVA: 0x806CCD0
        public void get_none(){} // RVA: 0x806CD30
        public void get_lastValue(){} // RVA: 0x806CD90
        public void .ctor(){} // RVA: 0xB460A0
        public void op_Implicit(){} // RVA: 0x70E1060
        public void System.IDisposable.Dispose(){} // RVA: 0xBFA230
        public void Dispose(){} // RVA: 0xB43310
        public void ApplyTo(){} // RVA: 0x806CDF0
        public void .cctor(){} // RVA: 0x806CE30
    }

    public class FocusController : Object
    {
        public object _focusRing;
        public object m_SelectedTextElement;
        public object m_FocusedElements;
        public object m_LastFocusedElement;
        public object m_LastPendingFocusedElement;
        public object m_PendingFocusCount;
        public object _imguiKeyboardControl;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x806D010
        public void get_focusRing(){} // RVA: 0xB5DBF0
        public void set_selectedTextElement(){} // RVA: 0x806D140
        public void get_focusedElement(){} // RVA: 0x806D1F0
        public void IgnoreEvent(){} // RVA: 0x806D250
        public void IsFocused(){} // RVA: 0x806D320
        public void GetRetargetedFocusedElement(){} // RVA: 0x806D4B0
        public void GetLeafFocusedElement(){} // RVA: 0x806D830
        public void IsLocalElement(){} // RVA: 0x806D900
        public void IsPendingFocus(){} // RVA: 0x806D950
        public void SetFocusToLastFocusedElement(){} // RVA: 0x806DA20
        public void BlurLastFocusedElement(){} // RVA: 0x806DAC0
        public void DoFocusChange(){} // RVA: 0x806DBC0
        public void ProcessPendingFocusChange(){} // RVA: 0x806DC40
        public void GetFocusTargets(){} // RVA: 0x806E180
        public void FocusNextInDirection(){} // RVA: 0x806E380
        public void AboutToReleaseFocus(){} // RVA: 0x806E490
        public void ReleaseFocus(){} // RVA: 0x806E5B0
        public void AboutToGrabFocus(){} // RVA: 0x806E950
        public void GrabFocus(){} // RVA: 0x806EA70
        public void Blur(){} // RVA: 0x806EE20
        public void SwitchFocus(){} // RVA: 0x806F000
        public void SwitchFocusOnEvent(){} // RVA: 0x806F650
        public void ReevaluateFocus(){} // RVA: 0x806F820
        public void GetFocusableParentForPointerEvent(){} // RVA: 0x806F8F0
        public void get_imguiKeyboardControl(){} // RVA: 0x114DAD0
        public void set_imguiKeyboardControl(){} // RVA: 0x25671C0
        public void SyncIMGUIFocus(){} // RVA: 0x806FB20
    }

    public class FocusEvent : FocusEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x805DC30
        public void .ctor(){} // RVA: 0x805DD20
    }

    public class FocusEventBase`1 : EventBase`1
    {
        public object _relatedTarget;
        public object _direction;
        public object _focusController;
        public object _isFocusDelegated;

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x87C0A0
        public void set_relatedTarget(){} // RVA: 0x894320
        public void get_direction(){} // RVA: 0x87C0A0
        public void set_direction(){} // RVA: 0x894320
        public void get_focusController(){} // RVA: 0x87C0A0
        public void set_focusController(){} // RVA: 0x894320
        public void get_IsFocusDelegated(){} // RVA: 0x87D280
        public void set_IsFocusDelegated(){} // RVA: 0x894750
        public void Init(){} // RVA: 0x894290
        public void LocalInit(){} // RVA: 0x894290
        public void GetPooled(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
    }

    public class FocusEventBase`1 : EventBase`1
    {
        public object _relatedTarget;
        public object _direction;
        public object _focusController;
        public object _isFocusDelegated;

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0xBBFF90
        public void set_relatedTarget(){} // RVA: 0xBBFFA0
        public void get_direction(){} // RVA: 0xC10050
        public void set_direction(){} // RVA: 0xC10060
        public void get_focusController(){} // RVA: 0xCD3320
        public void set_focusController(){} // RVA: 0xCD4740
        public void get_IsFocusDelegated(){} // RVA: 0xE3F400
        public void set_IsFocusDelegated(){} // RVA: 0xE3CFC0
        public void Init(){} // RVA: 0x3DF0C30
        public void LocalInit(){} // RVA: 0x3DF0CC0
        public void GetPooled(){} // RVA: 0x3DF0E70
        public void .ctor(){} // RVA: 0x3DF1130
    }

    public class FocusEventBase`1 : EventBase`1
    {
        public object _relatedTarget;
        public object _direction;
        public object _focusController;
        public object _isFocusDelegated;

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0xBBFF90
        public void set_relatedTarget(){} // RVA: 0xBBFFA0
        public void get_direction(){} // RVA: 0xC10050
        public void set_direction(){} // RVA: 0xC10060
        public void get_focusController(){} // RVA: 0xCD3320
        public void set_focusController(){} // RVA: 0xCD4740
        public void get_IsFocusDelegated(){} // RVA: 0xE3F400
        public void set_IsFocusDelegated(){} // RVA: 0xE3CFC0
        public void Init(){} // RVA: 0x3DF0C30
        public void LocalInit(){} // RVA: 0x3DF0CC0
        public void GetPooled(){} // RVA: 0x3DF0E70
        public void .ctor(){} // RVA: 0x3DF1130
    }

    public class FocusEventBase`1 : EventBase`1
    {
        public object _relatedTarget;
        public object _direction;
        public object _focusController;
        public object _isFocusDelegated;

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0xBBFF90
        public void set_relatedTarget(){} // RVA: 0xBBFFA0
        public void get_direction(){} // RVA: 0xC10050
        public void set_direction(){} // RVA: 0xC10060
        public void get_focusController(){} // RVA: 0xCD3320
        public void set_focusController(){} // RVA: 0xCD4740
        public void get_IsFocusDelegated(){} // RVA: 0xE3F400
        public void set_IsFocusDelegated(){} // RVA: 0xE3CFC0
        public void Init(){} // RVA: 0x3DF0C30
        public void LocalInit(){} // RVA: 0x3DF0CC0
        public void GetPooled(){} // RVA: 0x3DF0E70
        public void .ctor(){} // RVA: 0x3DF1130
    }

    public class FocusEventBase`1 : EventBase`1
    {
        public object _relatedTarget;
        public object _direction;
        public object _focusController;
        public object _isFocusDelegated;

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0xBBFF90
        public void set_relatedTarget(){} // RVA: 0xBBFFA0
        public void get_direction(){} // RVA: 0xC10050
        public void set_direction(){} // RVA: 0xC10060
        public void get_focusController(){} // RVA: 0xCD3320
        public void set_focusController(){} // RVA: 0xCD4740
        public void get_IsFocusDelegated(){} // RVA: 0xE3F400
        public void set_IsFocusDelegated(){} // RVA: 0xE3CFC0
        public void Init(){} // RVA: 0x3DF0C30
        public void LocalInit(){} // RVA: 0x3DF0CC0
        public void GetPooled(){} // RVA: 0x3DF0E70
        public void .ctor(){} // RVA: 0x3DF1130
    }

    public class FocusInEvent : FocusEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x805D8A0
        public void Init(){} // RVA: 0x805D990
        public void LocalInit(){} // RVA: 0x7FA9B20
        public void .ctor(){} // RVA: 0x805DA50
        public void PostDispatch(){} // RVA: 0x805DAA0
    }

    public class FocusOutEvent : FocusEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x805D2C0
        public void Init(){} // RVA: 0x805D3B0
        public void LocalInit(){} // RVA: 0x7FA9B20
        public void .ctor(){} // RVA: 0x805D470
        public void PostDispatch(){} // RVA: 0x805D4C0
    }

    public class Focusable : CallbackEventHandler
    {
        public object focusableProperty;
        public object tabIndexProperty;
        public object delegatesFocusProperty;
        public object canGrabFocusProperty;
        public object m_Focusable;
        public object m_TabIndex;
        public object m_DelegatesFocus;
        public object m_ExcludeFromFocusRing;
        public object _isEligibleToReceiveFocusFromDisabledChild;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x806C060
        public void get_focusController(){} // RVA: 0x87C0A0
        public void get_focusable(){} // RVA: 0xC38360
        public void set_focusable(){} // RVA: 0x806C0E0
        public void get_tabIndex(){} // RVA: 0x15AF000
        public void set_tabIndex(){} // RVA: 0x806C160
        public void get_delegatesFocus(){} // RVA: 0x806C1E0
        public void set_delegatesFocus(){} // RVA: 0x806C1F0
        public void get_excludeFromFocusRing(){} // RVA: 0x806C270
        public void set_excludeFromFocusRing(){} // RVA: 0x806C280
        public void get_isEligibleToReceiveFocusFromDisabledChild(){} // RVA: 0x28E58A0
        public void set_isEligibleToReceiveFocusFromDisabledChild(){} // RVA: 0x28E5890
        public void get_canGrabFocus(){} // RVA: 0x13B1020
        public void Focus(){} // RVA: 0x806C350
        public void Blur(){} // RVA: 0x806C4B0
        public void BlurImmediately(){} // RVA: 0x806C500
        public void GetFocusDelegate(){} // RVA: 0x806C550
        public void GetFirstFocusableChild(){} // RVA: 0x806C610
        public void .cctor(){} // RVA: 0x806C820
    }

    public class Foldout : BindableElement
    {
        public object textProperty;
        public object toggleOnLabelClickProperty;
        public object valueProperty;
        public object m_Toggle;
        public object m_Container;
        public object m_Value;
        public object ussClassName;
        public object toggleUssClassName;
        public object contentUssClassName;
        public object inputUssClassName;
        public object checkmarkUssClassName;
        public object textUssClassName;
        public object toggleInspectorUssClassName;
        public object ussFoldoutDepthClassName;
        public object ussFoldoutMaxDepth;
        public object m_NavigationManipulator;

        // ── Methods ──
        public void get_toggle(){} // RVA: 0x16686F0
        public void get_contentContainer(){} // RVA: 0x1653580
        public void get_focusable(){} // RVA: 0xC38360
        public void set_focusable(){} // RVA: 0x7FE0190
        public void get_toggleOnLabelClick(){} // RVA: 0x7FE0230
        public void set_toggleOnLabelClick(){} // RVA: 0x7FE0260
        public void get_text(){} // RVA: 0x7FE0300
        public void set_text(){} // RVA: 0x7FE0350
        public void get_value(){} // RVA: 0x7F00040
        public void set_value(){} // RVA: 0x7FE0580
        public void SetValueWithoutNotify(){} // RVA: 0x7FE0770
        public void OnViewDataReady(){} // RVA: 0x7FE0860
        public void Apply(){} // RVA: 0x7FE09D0
        public void .ctor(){} // RVA: 0x7FE0AE0
        public void OnAttachToPanel(){} // RVA: 0x7FE1230
        public void .cctor(){} // RVA: 0x7FE1540
        public void <.ctor>b__39_0(){} // RVA: 0x7FE1E20
    }

    public class FontDefinition : ValueType
    {
        public object m_Font;
        public object m_FontAsset;

        // ── Methods ──
        public void get_font(){} // RVA: 0x44D9F0
        public void set_font(){} // RVA: 0x9AA540
        public void get_fontAsset(){} // RVA: 0x8C0C50
        public void set_fontAsset(){} // RVA: 0x9AA550
        public void FromFont(){} // RVA: 0x80B78A0
        public void FromSDFFont(){} // RVA: 0x80B7920
        public void FromObject(){} // RVA: 0x80B79A0
        public void IsEmpty(){} // RVA: 0x9AA560
        public void ToString(){} // RVA: 0x9AA570
        public void Equals(){} // RVA: 0x9AA6C0
        public void GetHashCode(){} // RVA: 0x9AA6D0
        public void op_Equality(){} // RVA: 0x80B8240
        public void op_Inequality(){} // RVA: 0x80B8260
    }

}