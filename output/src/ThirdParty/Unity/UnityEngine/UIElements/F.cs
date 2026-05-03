// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 12
// Methods: 135

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class FieldMouseDragger`1 : BaseFieldMouseDragger
    {
        public UnityEngine.UIElements.IValueField`1<T> m_DrivenField;
        public UnityEngine.UIElements.VisualElement m_DragElement;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_dragging(){} // RVA: 0x7FFE80E2F150
        public void set_dragging(){} // RVA: 0x7FFE80E466C0
        public void get_startValue(){} // RVA: 0x7FFE810A1420
        public void set_startValue(){} // RVA: 0x7FFE810A1420
        public void SetDragZone(){}
        public void CanStartDrag(){} // RVA: 0x7FFE810A1420
        public void UpdateValueOnPointerDown(){} // RVA: 0x7FFE80E460A0
        public void ProcessDownEvent(){} // RVA: 0x7FFE80E460A0
        public void UpdateValueOnPointerMove(){} // RVA: 0x7FFE80E460A0
        public void ProcessMoveEvent(){} // RVA: 0x7FFE810A1420
        public void UpdateValueOnPointerUp(){} // RVA: 0x7FFE80E460A0
        public void ProcessUpEvent(){} // RVA: 0x7FFE80E4D070
        public void UpdateValueOnKeyDown(){} // RVA: 0x7FFE80E460A0
    }

    public class FixedHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        // ── Methods ──
        public void get_resolvedItemHeight(){} // RVA: 0x7FFE80E42E10
        public void VisibleItemPredicate(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7FFE80E431C0
        public void GetExpectedContentHeight(){} // RVA: 0x7FFE80E42E10
        public void ScrollToItem(){} // RVA: 0x7FFE80E46530
        public void Resize(){} // RVA: 0x7FFE80E54AE0
        public void OnScroll(){} // RVA: 0x7FFE80E54AE0
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7FFE810A1420
        public void EndDrag(){} // RVA: 0x7FFE80E46530
    }

    public class FloatField : TextValueField`1
    {
        public string ussClassName;

        // ── Methods ──
        public void get_floatInput(){} // RVA: 0x7FFE87E58190
        public void ValueToString(){} // RVA: 0x7FFE87E58220
        public void StringToValue(){} // RVA: 0x7FFE87E583E0
        public void .ctor(){} // RVA: 0x7FFE87E584E0 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFE87E58920
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87E589B0
        public void .cctor(){} // RVA: 0x7FFE87E58AA0
    }

    public class FocusChangeDirection : Object
    {
        public UnityEngine.UIElements.FocusChangeDirection _unspecified;
        public UnityEngine.UIElements.FocusChangeDirection _none; // 0x8
        public UnityEngine.UIElements.FocusChangeDirection _lastValue; // 0x10

        // ── Methods ──
        public void get_unspecified(){} // RVA: 0x7FFE87F3BE30
        public void get_none(){} // RVA: 0x7FFE87F3BE90
        public void get_lastValue(){} // RVA: 0x7FFE87F3BEF0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void op_Implicit(){} // RVA: 0x7FFE871B56C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE811AFBE0
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void ApplyTo(){} // RVA: 0x7FFE87F3BF50
        public void .cctor(){} // RVA: 0x7FFE87F3BF90
    }

    public class FocusController : Object
    {
        public UnityEngine.UIElements.IFocusRing _focusRing; // 0x10
        public UnityEngine.UIElements.TextElement m_SelectedTextElement; // 0x18
        public System.Collections.Generic.List`1<FocusedElement> m_FocusedElements; // 0x20
        public UnityEngine.UIElements.Focusable m_LastFocusedElement; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F3C170
        public void get_focusRing(){} // RVA: 0x7FFE81116380
        public void set_selectedTextElement(){} // RVA: 0x7FFE87F3C2A0
        public void get_focusedElement(){} // RVA: 0x7FFE87F3C350
        public void IsFocused(){} // RVA: 0x7FFE87F3C3B0
        public void GetRetargetedFocusedElement(){} // RVA: 0x7FFE87F3C530
        public void GetLeafFocusedElement(){} // RVA: 0x7FFE87F3C8B0
        public void IsLocalElement(){} // RVA: 0x7FFE87F3C980
        public void IsPendingFocus(){} // RVA: 0x7FFE87F3C9D0
        public void SetFocusToLastFocusedElement(){} // RVA: 0x7FFE87F3CAA0
        public void BlurLastFocusedElement(){} // RVA: 0x7FFE87F3CB40
        public void DoFocusChange(){} // RVA: 0x7FFE87F3CC40
        public void ProcessPendingFocusChange(){} // RVA: 0x7FFE87F3CE70
        public void FocusNextInDirection(){} // RVA: 0x7FFE87F3CEE0
        public void AboutToReleaseFocus(){} // RVA: 0x7FFE87F3D000
        public void ReleaseFocus(){} // RVA: 0x7FFE87F3D120
        public void AboutToGrabFocus(){} // RVA: 0x7FFE87F3D240
        public void GrabFocus(){} // RVA: 0x7FFE87F3D360
        public void Blur(){} // RVA: 0x7FFE87F3D480
        public void SwitchFocus(){} // RVA: 0x7FFE87F3D650 | overloaded x2
        public void SwitchFocusOnEvent(){} // RVA: 0x7FFE87F3D970
        public void ReevaluateFocus(){} // RVA: 0x7FFE87F3DB40
        public void GetFocusableParentForPointerEvent(){} // RVA: 0x7FFE87F3DC60
        public void get_imguiKeyboardControl(){} // RVA: 0x7FFE816311C0
        public void set_imguiKeyboardControl(){} // RVA: 0x7FFE82A4B070
        public void SyncIMGUIFocus(){} // RVA: 0x7FFE87F3DE70
    }

    public class FocusEvent : FocusEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F2B120
        public void PreDispatch(){} // RVA: 0x7FFE87F2B210
        public void .ctor(){} // RVA: 0x7FFE87F2B2E0
    }

    public class FocusEventBase`1 : EventBase`1
    {
        public UnityEngine.UIElements.Focusable _relatedTarget;
        public UnityEngine.UIElements.FocusChangeDirection _direction;
        public UnityEngine.UIElements.FocusController _focusController;
        public bool _isFocusDelegated;

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x7FFE80E2E2E0
        public void set_relatedTarget(){} // RVA: 0x7FFE80E460A0
        public void get_direction(){} // RVA: 0x7FFE80E2E2E0
        public void set_direction(){} // RVA: 0x7FFE80E460A0
        public void get_focusController(){} // RVA: 0x7FFE80E2E2E0
        public void set_focusController(){} // RVA: 0x7FFE80E460A0
        public void get_IsFocusDelegated(){} // RVA: 0x7FFE80E2F150
        public void set_IsFocusDelegated(){} // RVA: 0x7FFE80E466C0
        public void Init(){} // RVA: 0x7FFE80E45FE0
        public void LocalInit(){} // RVA: 0x7FFE80E45FE0
        public void GetPooled(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class FocusInEvent : FocusEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F2AE00
        public void Init(){} // RVA: 0x7FFE87F2AEF0
        public void LocalInit(){} // RVA: 0x7FFE87ECFB00
        public void .ctor(){} // RVA: 0x7FFE87F2AFB0
    }

    public class FocusOutEvent : FocusEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F2A810
        public void Init(){} // RVA: 0x7FFE87F2A900
        public void LocalInit(){} // RVA: 0x7FFE87ECFB00
        public void .ctor(){} // RVA: 0x7FFE87F2A9C0
    }

    public class Focusable : CallbackEventHandler
    {
        public bool _focusable; // 0x20
        public int _tabIndex; // 0x24
        public bool m_DelegatesFocus; // 0x28
        public bool m_ExcludeFromFocusRing; // 0x29
        public int _runningAnimationCount; // 0x30
        public int _completedAnimationCount; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F3B8C0
        public void get_focusController(){} // RVA: 0x7FFE80E2E2E0
        public void get_focusable(){} // RVA: 0x7FFE811E99D0
        public void set_focusable(){} // RVA: 0x7FFE811E99E0
        public void get_tabIndex(){} // RVA: 0x7FFE81A56130
        public void set_tabIndex(){} // RVA: 0x7FFE82447980
        public void get_delegatesFocus(){} // RVA: 0x7FFE87F3B8D0
        public void set_delegatesFocus(){} // RVA: 0x7FFE81C15740
        public void get_excludeFromFocusRing(){} // RVA: 0x7FFE87F3B8E0
        public void set_excludeFromFocusRing(){} // RVA: 0x7FFE87F3B8F0
        public void get_canGrabFocus(){} // RVA: 0x7FFE811E99D0
        public void Focus(){} // RVA: 0x7FFE87F3B9D0
        public void Blur(){} // RVA: 0x7FFE87F3BB00
        public void BlurImmediately(){} // RVA: 0x7FFE87F3BB50
        public void GetFocusDelegate(){} // RVA: 0x7FFE87F3BBA0
        public void GetFirstFocusableChild(){} // RVA: 0x7FFE87F3BC30
        public void ExecuteDefaultAction(){} // RVA: 0x7FFE87F3BDE0
        public void ExecuteDefaultActionDisabled(){} // RVA: 0x7FFE87F3BDE0
        public void ProcessEvent(){} // RVA: 0x7FFE87F3BDE0
    }

    public class Foldout : BindableElement
    {
        public UnityEngine.UIElements.Toggle m_Toggle; // 0x3D8
        public UnityEngine.UIElements.VisualElement m_Container; // 0x3E0
        public bool m_Value; // 0x3E8

        // ── Methods ──
        public void get_contentContainer(){} // RVA: 0x7FFE81B2A270
        public void set_text(){} // RVA: 0x7FFE87E592F0
        public void get_value(){} // RVA: 0x7FFE87E59430
        public void set_value(){} // RVA: 0x7FFE87E59440
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE87E595A0
        public void OnViewDataReady(){} // RVA: 0x7FFE87E59690
        public void Apply(){} // RVA: 0x7FFE87E597D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87E598D0
        public void OnAttachToPanel(){} // RVA: 0x7FFE87E59FA0
        public void .cctor(){} // RVA: 0x7FFE87E5A2A0
        public void <.ctor>b__29_0(){} // RVA: 0x7FFE87E5A7E0
    }

    public class FontDefinition : ValueType
    {
        public UnityEngine.Font m_Font; // 0x10
        public UnityEngine.TextCore.Text.FontAsset m_FontAsset; // 0x18

        // ── Methods ──
        public void get_font(){} // RVA: 0x7FFE8348B260
        public void get_fontAsset(){} // RVA: 0x7FFE86A5E330
        public void FromFont(){} // RVA: 0x7FFE87F80EE0
        public void FromSDFFont(){} // RVA: 0x7FFE87F80F60
        public void FromObject(){} // RVA: 0x7FFE87F80FE0
        public void IsEmpty(){} // RVA: 0x7FFE87F812B0
        public void ToString(){} // RVA: 0x7FFE87F81430
        public void Equals(){} // RVA: 0x7FFE87F81620 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87F816C0
        public void op_Equality(){} // RVA: 0x7FFE87F81880
        public void op_Inequality(){} // RVA: 0x7FFE87F818A0
    }

}