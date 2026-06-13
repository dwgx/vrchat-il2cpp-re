// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 18
// Methods: 183

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class FieldMouseDragger`1
    {
        public UnityEngine.UIElements.IValueField`1<T> m_DrivenField;
        public UnityEngine.UIElements.VisualElement m_DragElement;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void get_dragging(){} // RVA: 0xDBE0
        public void set_dragging(){} // RVA: 0x25130
        public void get_startValue(){} // RVA: 0x283FA0
        public void set_startValue(){} // RVA: 0x283FA0
        public void SetDragZone(){}
        public void CanStartDrag(){} // RVA: 0x283FA0
        public void UpdateValueOnPointerDown(){} // RVA: 0x24B10
        public void ProcessDownEvent(){} // RVA: 0x24B10
        public void UpdateValueOnPointerMove(){} // RVA: 0x24B10
        public void ProcessMoveEvent(){} // RVA: 0x283FA0
        public void UpdateValueOnPointerUp(){} // RVA: 0x24B10
        public void ProcessUpEvent(){} // RVA: 0x2BAA0
        public void UpdateValueOnKeyDown(){} // RVA: 0x24B10
    }

    public class FieldMouseDragger`1
    {
        public UnityEngine.UIElements.IValueField`1<float> m_DrivenField; // 0x10
        public UnityEngine.UIElements.VisualElement m_DragElement; // 0x18
    }

    public class FieldMouseDragger`1
    {
        public UnityEngine.UIElements.IValueField`1<int> m_DrivenField; // 0x10
        public UnityEngine.UIElements.VisualElement m_DragElement; // 0x18
    }

    public class FixedHeightVirtualizationController`1
    {
        // ── Methods ──
        public void get_resolvedItemHeight(){} // RVA: 0x21890
        public void VisibleItemPredicate(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24B10
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x21C40
        public void GetExpectedContentHeight(){} // RVA: 0x21890
        public void ScrollToItem(){} // RVA: 0x24FA0
        public void Resize(){} // RVA: 0x33510
        public void OnScroll(){} // RVA: 0x33510
        public void GetOrMakeItemAtIndex(){} // RVA: 0x283FA0
        public void EndDrag(){} // RVA: 0x24FA0
    }

    public class FloatField
    {
        public string ussClassName;

        // ── Methods ──
        public void get_floatInput(){} // RVA: 0x7318010
        public void ValueToString(){} // RVA: 0x73180A0
        public void StringToValue(){} // RVA: 0x7318260
        public void .ctor(){} // RVA: 0x7318360 | overloaded x2
        public void CanTryParse(){} // RVA: 0x73187A0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7318830
        public void .cctor(){} // RVA: 0x7318920
    }

    public class FocusChangeDirection
    {
        public UnityEngine.UIElements.FocusChangeDirection <unspecified>k__BackingField;
        public UnityEngine.UIElements.FocusChangeDirection <none>k__BackingField; // 0x8
        public UnityEngine.UIElements.FocusChangeDirection <lastValue>k__BackingField; // 0x10

        // ── Methods ──
        public void get_unspecified(){} // RVA: 0x73FBC90
        public void get_none(){} // RVA: 0x73FBCF0
        public void get_lastValue(){} // RVA: 0x73FBD50
        public void .ctor(){} // RVA: 0x2E00C0
        public void op_Implicit(){} // RVA: 0x66767D0
        public void System.IDisposable.Dispose(){} // RVA: 0x391BE0
        public void Dispose(){} // RVA: 0x2DD310
        public void ApplyTo(){} // RVA: 0x73FBDB0
        public void .cctor(){} // RVA: 0x73FBDF0
    }

    public class FocusController
    {
        public UnityEngine.UIElements.IFocusRing minAtlasSize; // 0x10
        public UnityEngine.UIElements.TextElement maxAtlasSize; // 0x18
        public System.Collections.Generic.List`1<FocusedElement> maxSubTextureSize; // 0x20
        public UnityEngine.UIElements.Focusable activeFilters; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73FBFD0
        public void get_focusRing(){} // RVA: 0x2F8380
        public void set_selectedTextElement(){} // RVA: 0x73FC100
        public void get_focusedElement(){} // RVA: 0x73FC1B0
        public void IsFocused(){} // RVA: 0x73FC210
        public void GetRetargetedFocusedElement(){} // RVA: 0x73FC390
        public void GetLeafFocusedElement(){} // RVA: 0x73FC710
        public void IsLocalElement(){} // RVA: 0x73FC7E0
        public void IsPendingFocus(){} // RVA: 0x73FC830
        public void SetFocusToLastFocusedElement(){} // RVA: 0x73FC900
        public void BlurLastFocusedElement(){} // RVA: 0x73FC9A0
        public void DoFocusChange(){} // RVA: 0x73FCAA0
        public void ProcessPendingFocusChange(){} // RVA: 0x73FCCD0
        public void FocusNextInDirection(){} // RVA: 0x73FCD40
        public void AboutToReleaseFocus(){} // RVA: 0x73FCE60
        public void ReleaseFocus(){} // RVA: 0x73FCF80
        public void AboutToGrabFocus(){} // RVA: 0x73FD0A0
        public void GrabFocus(){} // RVA: 0x73FD1C0
        public void Blur(){} // RVA: 0x73FD2E0
        public void SwitchFocus(){} // RVA: 0x73FD4B0 | overloaded x2
        public void SwitchFocusOnEvent(){} // RVA: 0x73FD7D0
        public void ReevaluateFocus(){} // RVA: 0x73FD9A0
        public void GetFocusableParentForPointerEvent(){} // RVA: 0x73FDAC0
        public void get_imguiKeyboardControl(){} // RVA: 0x891AF0
        public void set_imguiKeyboardControl(){} // RVA: 0x1CB95F0
        public void SyncIMGUIFocus(){} // RVA: 0x73FDCD0
    }

    public class FocusEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73EAF80
        public void PreDispatch(){} // RVA: 0x73EB070
        public void .ctor(){} // RVA: 0x73EB140
    }

    public class FocusEventBase`1
    {
        public UnityEngine.UIElements.Focusable <relatedTarget>k__BackingField;
        public UnityEngine.UIElements.FocusChangeDirection <direction>k__BackingField;
        public UnityEngine.UIElements.FocusController <focusController>k__BackingField;
        public bool <IsFocusDelegated>k__BackingField;

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0xCD60
        public void set_relatedTarget(){} // RVA: 0x24B10
        public void get_direction(){} // RVA: 0xCD60
        public void set_direction(){} // RVA: 0x24B10
        public void get_focusController(){} // RVA: 0xCD60
        public void set_focusController(){} // RVA: 0x24B10
        public void get_IsFocusDelegated(){} // RVA: 0xDBE0
        public void set_IsFocusDelegated(){} // RVA: 0x25130
        public void Init(){} // RVA: 0x24A50
        public void LocalInit(){} // RVA: 0x24A50
        public void GetPooled(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class FocusEventBase`1
    {
        public UnityEngine.UIElements.Focusable <relatedTarget>k__BackingField; // 0x88
        public UnityEngine.UIElements.FocusChangeDirection <direction>k__BackingField; // 0x90
        public UnityEngine.UIElements.FocusController <focusController>k__BackingField; // 0x98
        public bool <IsFocusDelegated>k__BackingField; // 0xA0

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x31C010
        public void set_relatedTarget(){} // RVA: 0x463060
        public void get_direction(){} // RVA: 0x796DE0
        public void set_direction(){} // RVA: 0xB54600
        public void get_focusController(){} // RVA: 0xA1C8C0
        public void set_focusController(){} // RVA: 0x9AA650
        public void get_IsFocusDelegated(){} // RVA: 0x1B6CD50
        public void set_IsFocusDelegated(){} // RVA: 0xB70090
        public void Init(){} // RVA: 0x334BE90
        public void LocalInit(){} // RVA: 0x334BF30
        public void GetPooled(){} // RVA: 0x334C0F0
        public void .ctor(){} // RVA: 0x334C330
    }

    public class FocusEventBase`1
    {
        public UnityEngine.UIElements.Focusable <relatedTarget>k__BackingField; // 0x88
        public UnityEngine.UIElements.FocusChangeDirection <direction>k__BackingField; // 0x90
        public UnityEngine.UIElements.FocusController <focusController>k__BackingField; // 0x98
        public bool <IsFocusDelegated>k__BackingField; // 0xA0

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x31C010
        public void set_relatedTarget(){} // RVA: 0x463060
        public void get_direction(){} // RVA: 0x796DE0
        public void set_direction(){} // RVA: 0xB54600
        public void get_focusController(){} // RVA: 0xA1C8C0
        public void set_focusController(){} // RVA: 0x9AA650
        public void get_IsFocusDelegated(){} // RVA: 0x1B6CD50
        public void set_IsFocusDelegated(){} // RVA: 0xB70090
        public void Init(){} // RVA: 0x334BE90
        public void LocalInit(){} // RVA: 0x334BF30
        public void GetPooled(){} // RVA: 0x334C0F0
        public void .ctor(){} // RVA: 0x334C330
    }

    public class FocusEventBase`1
    {
        public UnityEngine.UIElements.Focusable <relatedTarget>k__BackingField; // 0x88
        public UnityEngine.UIElements.FocusChangeDirection <direction>k__BackingField; // 0x90
        public UnityEngine.UIElements.FocusController <focusController>k__BackingField; // 0x98
        public bool <IsFocusDelegated>k__BackingField; // 0xA0

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x31C010
        public void set_relatedTarget(){} // RVA: 0x463060
        public void get_direction(){} // RVA: 0x796DE0
        public void set_direction(){} // RVA: 0xB54600
        public void get_focusController(){} // RVA: 0xA1C8C0
        public void set_focusController(){} // RVA: 0x9AA650
        public void get_IsFocusDelegated(){} // RVA: 0x1B6CD50
        public void set_IsFocusDelegated(){} // RVA: 0xB70090
        public void Init(){} // RVA: 0x334BE90
        public void LocalInit(){} // RVA: 0x334BF30
        public void GetPooled(){} // RVA: 0x334C0F0
        public void .ctor(){} // RVA: 0x334C330
    }

    public class FocusEventBase`1
    {
        public UnityEngine.UIElements.Focusable <relatedTarget>k__BackingField; // 0x88
        public UnityEngine.UIElements.FocusChangeDirection <direction>k__BackingField; // 0x90
        public UnityEngine.UIElements.FocusController <focusController>k__BackingField; // 0x98
        public bool <IsFocusDelegated>k__BackingField; // 0xA0

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x31C010
        public void set_relatedTarget(){} // RVA: 0x463060
        public void get_direction(){} // RVA: 0x796DE0
        public void set_direction(){} // RVA: 0xB54600
        public void get_focusController(){} // RVA: 0xA1C8C0
        public void set_focusController(){} // RVA: 0x9AA650
        public void get_IsFocusDelegated(){} // RVA: 0x1B6CD50
        public void set_IsFocusDelegated(){} // RVA: 0xB70090
        public void Init(){} // RVA: 0x334BE90
        public void LocalInit(){} // RVA: 0x334BF30
        public void GetPooled(){} // RVA: 0x334C0F0
        public void .ctor(){} // RVA: 0x334C330
    }

    public class FocusInEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73EAC60
        public void Init(){} // RVA: 0x73EAD50
        public void LocalInit(){} // RVA: 0x738F980
        public void .ctor(){} // RVA: 0x73EAE10
    }

    public class FocusOutEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73EA670
        public void Init(){} // RVA: 0x73EA760
        public void LocalInit(){} // RVA: 0x738F980
        public void .ctor(){} // RVA: 0x73EA820
    }

    public class Focusable
    {
        public bool <focusable>k__BackingField; // 0x20
        public int <tabIndex>k__BackingField; // 0x24
        public bool m_DelegatesFocus; // 0x28
        public bool m_ExcludeFromFocusRing; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73FB720
        public void get_focusController(){} // RVA: 0xCD60
        public void get_focusable(){} // RVA: 0x3CB9D0
        public void set_focusable(){} // RVA: 0x3CB9E0
        public void get_tabIndex(){} // RVA: 0xCEF5B0
        public void set_tabIndex(){} // RVA: 0x16E1F00
        public void get_delegatesFocus(){} // RVA: 0x73FB730
        public void set_delegatesFocus(){} // RVA: 0x6E8B80
        public void get_excludeFromFocusRing(){} // RVA: 0x73FB740
        public void set_excludeFromFocusRing(){} // RVA: 0x73FB750
        public void get_canGrabFocus(){} // RVA: 0x3CB9D0
        public void Focus(){} // RVA: 0x73FB830
        public void Blur(){} // RVA: 0x73FB960
        public void BlurImmediately(){} // RVA: 0x73FB9B0
        public void GetFocusDelegate(){} // RVA: 0x73FBA00
        public void GetFirstFocusableChild(){} // RVA: 0x73FBA90
        public void ExecuteDefaultAction(){} // RVA: 0x73FBC40
        public void ExecuteDefaultActionDisabled(){} // RVA: 0x73FBC40
        public void ProcessEvent(){} // RVA: 0x73FBC40
    }

    public class Foldout
    {
        public UnityEngine.UIElements.Toggle m_Toggle; // 0x3D8
        public UnityEngine.UIElements.VisualElement m_Container; // 0x3E0
        public bool m_Value; // 0x3E8

        // ── Methods ──
        public void get_contentContainer(){} // RVA: 0xD98840
        public void set_text(){} // RVA: 0x7319170
        public void get_value(){} // RVA: 0x73192B0
        public void set_value(){} // RVA: 0x73192C0
        public void SetValueWithoutNotify(){} // RVA: 0x7319420
        public void OnViewDataReady(){} // RVA: 0x7319510
        public void Apply(){} // RVA: 0x7319650 | overloaded x2
        public void .ctor(){} // RVA: 0x7319750
        public void OnAttachToPanel(){} // RVA: 0x7319E20
        public void .cctor(){} // RVA: 0x731A120
        public void <.ctor>b__29_0(){} // RVA: 0x731A660
    }

    public class FontDefinition
    {
        public UnityEngine.Font m_Font; // 0x10
        public UnityEngine.TextCore.Text.FontAsset m_FontAsset; // 0x18

        // ── Methods ──
        public void get_font(){} // RVA: 0x2738C50
        public void get_fontAsset(){} // RVA: 0x5F1D510
        public void FromFont(){} // RVA: 0x7440D40
        public void FromSDFFont(){} // RVA: 0x7440DC0
        public void FromObject(){} // RVA: 0x7440E40
        public void IsEmpty(){} // RVA: 0x7441110
        public void ToString(){} // RVA: 0x7441290
        public void Equals(){} // RVA: 0x7441480 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7441520
        public void op_Equality(){} // RVA: 0x74416E0
        public void op_Inequality(){} // RVA: 0x7441700
    }

}