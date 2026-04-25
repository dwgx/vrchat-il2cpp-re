// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 12
// Methods: 135

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class FieldMouseDragger`1 : BaseFieldMouseDragger
    {
        public UnityEngine.UIElements.IValueField`1<T> dragging;
        public UnityEngine.UIElements.VisualElement startValue;
        public UnityEngine.Rect m_DragHotZone;
        public bool <dragging>k__BackingField;
        public T <startValue>k__BackingField;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_dragging(){} // RVA: 0x7FFAC2C59D00
        public void set_dragging(){} // RVA: 0x7FFAC2C71060
        public void get_startValue(){} // RVA: 0x7FFAC2E8DC40
        public void set_startValue(){} // RVA: 0x7FFAC2E8DC40
        public void SetDragZone(){}
        public void CanStartDrag(){} // RVA: 0x7FFAC2E8DC40
        public void UpdateValueOnPointerDown(){} // RVA: 0x7FFAC2C70A40
        public void ProcessDownEvent(){} // RVA: 0x7FFAC2C70A40
        public void UpdateValueOnPointerMove(){} // RVA: 0x7FFAC2C70A40
        public void ProcessMoveEvent(){} // RVA: 0x7FFAC2E8DC40
        public void UpdateValueOnPointerUp(){} // RVA: 0x7FFAC2C70A40
        public void ProcessUpEvent(){} // RVA: 0x7FFAC2C77970
        public void UpdateValueOnKeyDown(){} // RVA: 0x7FFAC2C70A40
    }

    public class FixedHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        public object resolvedItemHeight;

        // ── Methods ──
        public void get_resolvedItemHeight(){} // RVA: 0x7FFAC2C6D880
        public void VisibleItemPredicate(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7FFAC2C6DC30
        public void GetExpectedContentHeight(){} // RVA: 0x7FFAC2C6D880
        public void ScrollToItem(){} // RVA: 0x7FFAC2C70ED0
        public void Resize(){} // RVA: 0x7FFAC2C7F3E0
        public void OnScroll(){} // RVA: 0x7FFAC2C7F3E0
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7FFAC2E8DC40
        public void EndDrag(){} // RVA: 0x7FFAC2C70ED0
    }

    public class FloatField : TextValueField`1
    {
        public string floatInput;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void get_floatInput(){} // RVA: 0x7FFAC9AAF8F0
        public void ValueToString(){} // RVA: 0x7FFAC9AAF980
        public void StringToValue(){} // RVA: 0x7FFAC9AAFB40
        public void .ctor(){} // RVA: 0x7FFAC9AAFC40 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFAC9AB0080
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9AB0110
        public void .cctor(){} // RVA: 0x7FFAC9AB0200
    }

    public class FocusChangeDirection : Object
    {
        public UnityEngine.UIElements.FocusChangeDirection unspecified;
        public UnityEngine.UIElements.FocusChangeDirection none; // 0x8
        public UnityEngine.UIElements.FocusChangeDirection lastValue; // 0x10
        public int m_Value; // 0x10

        // ── Methods ──
        public void get_unspecified(){} // RVA: 0x7FFAC9B93580
        public void get_none(){} // RVA: 0x7FFAC9B935E0
        public void get_lastValue(){} // RVA: 0x7FFAC9B93640
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void op_Implicit(){} // RVA: 0x7FFAC8E0D290
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2FD5BE0
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void ApplyTo(){} // RVA: 0x7FFAC9B936A0
        public void .cctor(){} // RVA: 0x7FFAC9B936E0
    }

    public class FocusController : Object
    {
        public UnityEngine.UIElements.IFocusRing focusRing; // 0x10
        public UnityEngine.UIElements.TextElement selectedTextElement; // 0x18
        public System.Collections.Generic.List`1<FocusedElement> focusedElement; // 0x20
        public UnityEngine.UIElements.Focusable imguiKeyboardControl; // 0x28
        public UnityEngine.UIElements.Focusable m_LastPendingFocusedElement; // 0x30
        public int m_PendingFocusCount; // 0x38
        public int <imguiKeyboardControl>k__BackingField; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B938C0
        public void get_focusRing(){} // RVA: 0x7FFAC2F3C380
        public void set_selectedTextElement(){} // RVA: 0x7FFAC9B939F0
        public void get_focusedElement(){} // RVA: 0x7FFAC9B93AA0
        public void IsFocused(){} // RVA: 0x7FFAC9B93B00
        public void GetRetargetedFocusedElement(){} // RVA: 0x7FFAC9B93C80
        public void GetLeafFocusedElement(){} // RVA: 0x7FFAC9B94000
        public void IsLocalElement(){} // RVA: 0x7FFAC9B940D0
        public void IsPendingFocus(){} // RVA: 0x7FFAC9B94120
        public void SetFocusToLastFocusedElement(){} // RVA: 0x7FFAC9B941F0
        public void BlurLastFocusedElement(){} // RVA: 0x7FFAC9B94290
        public void DoFocusChange(){} // RVA: 0x7FFAC9B94390
        public void ProcessPendingFocusChange(){} // RVA: 0x7FFAC9B945C0
        public void FocusNextInDirection(){} // RVA: 0x7FFAC9B94630
        public void AboutToReleaseFocus(){} // RVA: 0x7FFAC9B94750
        public void ReleaseFocus(){} // RVA: 0x7FFAC9B94870
        public void AboutToGrabFocus(){} // RVA: 0x7FFAC9B94990
        public void GrabFocus(){} // RVA: 0x7FFAC9B94AB0
        public void Blur(){} // RVA: 0x7FFAC9B94BD0
        public void SwitchFocus(){} // RVA: 0x7FFAC9B94DA0 | overloaded x2
        public void SwitchFocusOnEvent(){} // RVA: 0x7FFAC9B950C0
        public void ReevaluateFocus(){} // RVA: 0x7FFAC9B95290
        public void GetFocusableParentForPointerEvent(){} // RVA: 0x7FFAC9B953B0
        public void get_imguiKeyboardControl(){} // RVA: 0x7FFAC33BD4A0
        public void set_imguiKeyboardControl(){} // RVA: 0x7FFAC47E2CD0
        public void SyncIMGUIFocus(){} // RVA: 0x7FFAC9B955C0
    }

    public class FocusEvent : FocusEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B82870
        public void PreDispatch(){} // RVA: 0x7FFAC9B82960
        public void .ctor(){} // RVA: 0x7FFAC9B82A30
    }

    public class FocusEventBase`1 : EventBase`1
    {
        public UnityEngine.UIElements.Focusable relatedTarget;
        public UnityEngine.UIElements.FocusChangeDirection direction;
        public UnityEngine.UIElements.FocusController focusController;
        public bool IsFocusDelegated;

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x7FFAC2C58E90
        public void set_relatedTarget(){} // RVA: 0x7FFAC2C70A40
        public void get_direction(){} // RVA: 0x7FFAC2C58E90
        public void set_direction(){} // RVA: 0x7FFAC2C70A40
        public void get_focusController(){} // RVA: 0x7FFAC2C58E90
        public void set_focusController(){} // RVA: 0x7FFAC2C70A40
        public void get_IsFocusDelegated(){} // RVA: 0x7FFAC2C59D00
        public void set_IsFocusDelegated(){} // RVA: 0x7FFAC2C71060
        public void Init(){} // RVA: 0x7FFAC2C70980
        public void LocalInit(){} // RVA: 0x7FFAC2C70980
        public void GetPooled(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class FocusInEvent : FocusEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B82550
        public void Init(){} // RVA: 0x7FFAC9B82640
        public void LocalInit(){} // RVA: 0x7FFAC9B27260
        public void .ctor(){} // RVA: 0x7FFAC9B82700
    }

    public class FocusOutEvent : FocusEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B81F60
        public void Init(){} // RVA: 0x7FFAC9B82050
        public void LocalInit(){} // RVA: 0x7FFAC9B27260
        public void .ctor(){} // RVA: 0x7FFAC9B82110
    }

    public class Focusable : CallbackEventHandler
    {
        public bool focusController; // 0x20
        public int focusable; // 0x24
        public bool tabIndex; // 0x28
        public bool delegatesFocus; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B93010
        public void get_focusController(){} // RVA: 0x7FFAC2C58E90
        public void get_focusable(){} // RVA: 0x7FFAC300F9D0
        public void set_focusable(){} // RVA: 0x7FFAC300F9E0
        public void get_tabIndex(){} // RVA: 0x7FFAC3921980
        public void set_tabIndex(){} // RVA: 0x7FFAC41674D0
        public void get_delegatesFocus(){} // RVA: 0x7FFAC9B93020
        public void set_delegatesFocus(){} // RVA: 0x7FFAC3C24F40
        public void get_excludeFromFocusRing(){} // RVA: 0x7FFAC9B93030
        public void set_excludeFromFocusRing(){} // RVA: 0x7FFAC9B93040
        public void get_canGrabFocus(){} // RVA: 0x7FFAC300F9D0
        public void Focus(){} // RVA: 0x7FFAC9B93120
        public void Blur(){} // RVA: 0x7FFAC9B93250
        public void BlurImmediately(){} // RVA: 0x7FFAC9B932A0
        public void GetFocusDelegate(){} // RVA: 0x7FFAC9B932F0
        public void GetFirstFocusableChild(){} // RVA: 0x7FFAC9B93380
        public void ExecuteDefaultAction(){} // RVA: 0x7FFAC9B93530
        public void ExecuteDefaultActionDisabled(){} // RVA: 0x7FFAC9B93530
        public void ProcessEvent(){} // RVA: 0x7FFAC9B93530
    }

    public class Foldout : BindableElement
    {
        public UnityEngine.UIElements.Toggle contentContainer; // 0x3D8
        public UnityEngine.UIElements.VisualElement text; // 0x3E0
        public bool value; // 0x3E8
        public string ussClassName;
        public string toggleUssClassName; // 0x8
        public string contentUssClassName; // 0x10
        public string inputUssClassName; // 0x18
        public string checkmarkUssClassName; // 0x20
        public string textUssClassName; // 0x28
        public string toggleInspectorUssClassName; // 0x30
        public string ussFoldoutDepthClassName; // 0x38
        public int ussFoldoutMaxDepth; // 0x40
        public UnityEngine.UIElements.KeyboardNavigationManipulator m_NavigationManipulator; // 0x3F0

        // ── Methods ──
        public void get_contentContainer(){} // RVA: 0x7FFAC39BF4D0
        public void set_text(){} // RVA: 0x7FFAC9AB0A50
        public void get_value(){} // RVA: 0x7FFAC9AB0B90
        public void set_value(){} // RVA: 0x7FFAC9AB0BA0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9AB0D00
        public void OnViewDataReady(){} // RVA: 0x7FFAC9AB0DF0
        public void Apply(){} // RVA: 0x7FFAC9AB0F30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC9AB1030
        public void OnAttachToPanel(){} // RVA: 0x7FFAC9AB1700
        public void .cctor(){} // RVA: 0x7FFAC9AB1A00
        public void <.ctor>b__29_0(){} // RVA: 0x7FFAC9AB1F40
    }

    public class FontDefinition : ValueType
    {
        public UnityEngine.Font font; // 0x10
        public UnityEngine.TextCore.Text.FontAsset fontAsset; // 0x18

        // ── Methods ──
        public void get_font(){} // RVA: 0x7FFAC51D9A30
        public void get_fontAsset(){} // RVA: 0x7FFAC86B4B80
        public void FromFont(){} // RVA: 0x7FFAC9BD8630
        public void FromSDFFont(){} // RVA: 0x7FFAC9BD86B0
        public void FromObject(){} // RVA: 0x7FFAC9BD8730
        public void IsEmpty(){} // RVA: 0x7FFAC9BD8A00
        public void ToString(){} // RVA: 0x7FFAC9BD8B80
        public void Equals(){} // RVA: 0x7FFAC9BD8D70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BD8E10
        public void op_Equality(){} // RVA: 0x7FFAC9BD8FD0
        public void op_Inequality(){} // RVA: 0x7FFAC9BD8FF0
    }

}