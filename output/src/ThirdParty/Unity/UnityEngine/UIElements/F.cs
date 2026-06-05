// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 18
// Methods: 183

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class FieldMouseDragger`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void get_dragging(){} // RVA: 0x7FFAF2ABDBE0
        public void set_dragging(){} // RVA: 0x7FFAF2AD5130
        public void get_startValue(){} // RVA: 0x7FFAF2D33FA0
        public void set_startValue(){} // RVA: 0x7FFAF2D33FA0
        public void SetDragZone(){}
        public void CanStartDrag(){} // RVA: 0x7FFAF2D33FA0
        public void UpdateValueOnPointerDown(){} // RVA: 0x7FFAF2AD4B10
        public void ProcessDownEvent(){} // RVA: 0x7FFAF2AD4B10
        public void UpdateValueOnPointerMove(){} // RVA: 0x7FFAF2AD4B10
        public void ProcessMoveEvent(){} // RVA: 0x7FFAF2D33FA0
        public void UpdateValueOnPointerUp(){} // RVA: 0x7FFAF2AD4B10
        public void ProcessUpEvent(){} // RVA: 0x7FFAF2ADBAA0
        public void UpdateValueOnKeyDown(){} // RVA: 0x7FFAF2AD4B10
    }

    public class FieldMouseDragger`1
    {
    }

    public class FieldMouseDragger`1
    {
    }

    public class FixedHeightVirtualizationController`1
    {
        // ── Methods ──
        public void get_resolvedItemHeight(){} // RVA: 0x7FFAF2AD1890
        public void VisibleItemPredicate(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7FFAF2AD1C40
        public void GetExpectedContentHeight(){} // RVA: 0x7FFAF2AD1890
        public void ScrollToItem(){} // RVA: 0x7FFAF2AD4FA0
        public void Resize(){} // RVA: 0x7FFAF2AE3510
        public void OnScroll(){} // RVA: 0x7FFAF2AE3510
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7FFAF2D33FA0
        public void EndDrag(){} // RVA: 0x7FFAF2AD4FA0
    }

    public class FloatField
    {
        // ── Methods ──
        public void get_floatInput(){} // RVA: 0x7FFAF9DC8010
        public void ValueToString(){} // RVA: 0x7FFAF9DC80A0
        public void StringToValue(){} // RVA: 0x7FFAF9DC8260
        public void .ctor(){} // RVA: 0x7FFAF9DC8360 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFAF9DC87A0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAF9DC8830
        public void .cctor(){} // RVA: 0x7FFAF9DC8920
    }

    public class FocusChangeDirection
    {
        // ── Methods ──
        public void get_unspecified(){} // RVA: 0x7FFAF9EABC90
        public void get_none(){} // RVA: 0x7FFAF9EABCF0
        public void get_lastValue(){} // RVA: 0x7FFAF9EABD50
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void op_Implicit(){} // RVA: 0x7FFAF91267D0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAF2E41BE0
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void ApplyTo(){} // RVA: 0x7FFAF9EABDB0
        public void .cctor(){} // RVA: 0x7FFAF9EABDF0
    }

    public class FocusController
    {
        public object minAtlasSize;
        public object maxAtlasSize;
        public object maxSubTextureSize;
        public object activeFilters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9EABFD0
        public void get_focusRing(){} // RVA: 0x7FFAF2DA8380
        public void set_selectedTextElement(){} // RVA: 0x7FFAF9EAC100
        public void get_focusedElement(){} // RVA: 0x7FFAF9EAC1B0
        public void IsFocused(){} // RVA: 0x7FFAF9EAC210
        public void GetRetargetedFocusedElement(){} // RVA: 0x7FFAF9EAC390
        public void GetLeafFocusedElement(){} // RVA: 0x7FFAF9EAC710
        public void IsLocalElement(){} // RVA: 0x7FFAF9EAC7E0
        public void IsPendingFocus(){} // RVA: 0x7FFAF9EAC830
        public void SetFocusToLastFocusedElement(){} // RVA: 0x7FFAF9EAC900
        public void BlurLastFocusedElement(){} // RVA: 0x7FFAF9EAC9A0
        public void DoFocusChange(){} // RVA: 0x7FFAF9EACAA0
        public void ProcessPendingFocusChange(){} // RVA: 0x7FFAF9EACCD0
        public void FocusNextInDirection(){} // RVA: 0x7FFAF9EACD40
        public void AboutToReleaseFocus(){} // RVA: 0x7FFAF9EACE60
        public void ReleaseFocus(){} // RVA: 0x7FFAF9EACF80
        public void AboutToGrabFocus(){} // RVA: 0x7FFAF9EAD0A0
        public void GrabFocus(){} // RVA: 0x7FFAF9EAD1C0
        public void Blur(){} // RVA: 0x7FFAF9EAD2E0
        public void SwitchFocus(){} // RVA: 0x7FFAF9EAD4B0 | overloaded x2
        public void SwitchFocusOnEvent(){} // RVA: 0x7FFAF9EAD7D0
        public void ReevaluateFocus(){} // RVA: 0x7FFAF9EAD9A0
        public void GetFocusableParentForPointerEvent(){} // RVA: 0x7FFAF9EADAC0
        public void get_imguiKeyboardControl(){} // RVA: 0x7FFAF3341AF0
        public void set_imguiKeyboardControl(){} // RVA: 0x7FFAF47695F0
        public void SyncIMGUIFocus(){} // RVA: 0x7FFAF9EADCD0
    }

    public class FocusEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF9E9AF80
        public void PreDispatch(){} // RVA: 0x7FFAF9E9B070
        public void .ctor(){} // RVA: 0x7FFAF9E9B140
    }

    public class FocusEventBase`1
    {
        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x7FFAF2ABCD60
        public void set_relatedTarget(){} // RVA: 0x7FFAF2AD4B10
        public void get_direction(){} // RVA: 0x7FFAF2ABCD60
        public void set_direction(){} // RVA: 0x7FFAF2AD4B10
        public void get_focusController(){} // RVA: 0x7FFAF2ABCD60
        public void set_focusController(){} // RVA: 0x7FFAF2AD4B10
        public void get_IsFocusDelegated(){} // RVA: 0x7FFAF2ABDBE0
        public void set_IsFocusDelegated(){} // RVA: 0x7FFAF2AD5130
        public void Init(){} // RVA: 0x7FFAF2AD4A50
        public void LocalInit(){} // RVA: 0x7FFAF2AD4A50
        public void GetPooled(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class FocusEventBase`1
    {
        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x7FFAF2DCC010
        public void set_relatedTarget(){} // RVA: 0x7FFAF2F13060
        public void get_direction(){} // RVA: 0x7FFAF3246DE0
        public void set_direction(){} // RVA: 0x7FFAF3604600
        public void get_focusController(){} // RVA: 0x7FFAF34CC8C0
        public void set_focusController(){} // RVA: 0x7FFAF345A650
        public void get_IsFocusDelegated(){} // RVA: 0x7FFAF461CD50
        public void set_IsFocusDelegated(){} // RVA: 0x7FFAF3620090
        public void Init(){} // RVA: 0x7FFAF5DFBE90
        public void LocalInit(){} // RVA: 0x7FFAF5DFBF30
        public void GetPooled(){} // RVA: 0x7FFAF5DFC0F0
        public void .ctor(){} // RVA: 0x7FFAF5DFC330
    }

    public class FocusEventBase`1
    {
        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x7FFAF2DCC010
        public void set_relatedTarget(){} // RVA: 0x7FFAF2F13060
        public void get_direction(){} // RVA: 0x7FFAF3246DE0
        public void set_direction(){} // RVA: 0x7FFAF3604600
        public void get_focusController(){} // RVA: 0x7FFAF34CC8C0
        public void set_focusController(){} // RVA: 0x7FFAF345A650
        public void get_IsFocusDelegated(){} // RVA: 0x7FFAF461CD50
        public void set_IsFocusDelegated(){} // RVA: 0x7FFAF3620090
        public void Init(){} // RVA: 0x7FFAF5DFBE90
        public void LocalInit(){} // RVA: 0x7FFAF5DFBF30
        public void GetPooled(){} // RVA: 0x7FFAF5DFC0F0
        public void .ctor(){} // RVA: 0x7FFAF5DFC330
    }

    public class FocusEventBase`1
    {
        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x7FFAF2DCC010
        public void set_relatedTarget(){} // RVA: 0x7FFAF2F13060
        public void get_direction(){} // RVA: 0x7FFAF3246DE0
        public void set_direction(){} // RVA: 0x7FFAF3604600
        public void get_focusController(){} // RVA: 0x7FFAF34CC8C0
        public void set_focusController(){} // RVA: 0x7FFAF345A650
        public void get_IsFocusDelegated(){} // RVA: 0x7FFAF461CD50
        public void set_IsFocusDelegated(){} // RVA: 0x7FFAF3620090
        public void Init(){} // RVA: 0x7FFAF5DFBE90
        public void LocalInit(){} // RVA: 0x7FFAF5DFBF30
        public void GetPooled(){} // RVA: 0x7FFAF5DFC0F0
        public void .ctor(){} // RVA: 0x7FFAF5DFC330
    }

    public class FocusEventBase`1
    {
        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x7FFAF2DCC010
        public void set_relatedTarget(){} // RVA: 0x7FFAF2F13060
        public void get_direction(){} // RVA: 0x7FFAF3246DE0
        public void set_direction(){} // RVA: 0x7FFAF3604600
        public void get_focusController(){} // RVA: 0x7FFAF34CC8C0
        public void set_focusController(){} // RVA: 0x7FFAF345A650
        public void get_IsFocusDelegated(){} // RVA: 0x7FFAF461CD50
        public void set_IsFocusDelegated(){} // RVA: 0x7FFAF3620090
        public void Init(){} // RVA: 0x7FFAF5DFBE90
        public void LocalInit(){} // RVA: 0x7FFAF5DFBF30
        public void GetPooled(){} // RVA: 0x7FFAF5DFC0F0
        public void .ctor(){} // RVA: 0x7FFAF5DFC330
    }

    public class FocusInEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF9E9AC60
        public void Init(){} // RVA: 0x7FFAF9E9AD50
        public void LocalInit(){} // RVA: 0x7FFAF9E3F980
        public void .ctor(){} // RVA: 0x7FFAF9E9AE10
    }

    public class FocusOutEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF9E9A670
        public void Init(){} // RVA: 0x7FFAF9E9A760
        public void LocalInit(){} // RVA: 0x7FFAF9E3F980
        public void .ctor(){} // RVA: 0x7FFAF9E9A820
    }

    public class Focusable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9EAB720
        public void get_focusController(){} // RVA: 0x7FFAF2ABCD60
        public void get_focusable(){} // RVA: 0x7FFAF2E7B9D0
        public void set_focusable(){} // RVA: 0x7FFAF2E7B9E0
        public void get_tabIndex(){} // RVA: 0x7FFAF379F5B0
        public void set_tabIndex(){} // RVA: 0x7FFAF4191F00
        public void get_delegatesFocus(){} // RVA: 0x7FFAF9EAB730
        public void set_delegatesFocus(){} // RVA: 0x7FFAF3198B80
        public void get_excludeFromFocusRing(){} // RVA: 0x7FFAF9EAB740
        public void set_excludeFromFocusRing(){} // RVA: 0x7FFAF9EAB750
        public void get_canGrabFocus(){} // RVA: 0x7FFAF2E7B9D0
        public void Focus(){} // RVA: 0x7FFAF9EAB830
        public void Blur(){} // RVA: 0x7FFAF9EAB960
        public void BlurImmediately(){} // RVA: 0x7FFAF9EAB9B0
        public void GetFocusDelegate(){} // RVA: 0x7FFAF9EABA00
        public void GetFirstFocusableChild(){} // RVA: 0x7FFAF9EABA90
        public void ExecuteDefaultAction(){} // RVA: 0x7FFAF9EABC40
        public void ExecuteDefaultActionDisabled(){} // RVA: 0x7FFAF9EABC40
        public void ProcessEvent(){} // RVA: 0x7FFAF9EABC40
    }

    public class Foldout
    {
        // ── Methods ──
        public void get_contentContainer(){} // RVA: 0x7FFAF3848840
        public void set_text(){} // RVA: 0x7FFAF9DC9170
        public void get_value(){} // RVA: 0x7FFAF9DC92B0
        public void set_value(){} // RVA: 0x7FFAF9DC92C0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAF9DC9420
        public void OnViewDataReady(){} // RVA: 0x7FFAF9DC9510
        public void Apply(){} // RVA: 0x7FFAF9DC9650 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF9DC9750
        public void OnAttachToPanel(){} // RVA: 0x7FFAF9DC9E20
        public void .cctor(){} // RVA: 0x7FFAF9DCA120
        public void <.ctor>b__29_0(){} // RVA: 0x7FFAF9DCA660
    }

    public class FontDefinition
    {
        // ── Methods ──
        public void get_font(){} // RVA: 0x7FFAF51E8C50
        public void get_fontAsset(){} // RVA: 0x7FFAF89CD510
        public void FromFont(){} // RVA: 0x7FFAF9EF0D40
        public void FromSDFFont(){} // RVA: 0x7FFAF9EF0DC0
        public void FromObject(){} // RVA: 0x7FFAF9EF0E40
        public void IsEmpty(){} // RVA: 0x7FFAF9EF1110
        public void ToString(){} // RVA: 0x7FFAF9EF1290
        public void Equals(){} // RVA: 0x7FFAF9EF1480 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9EF1520
        public void op_Equality(){} // RVA: 0x7FFAF9EF16E0
        public void op_Inequality(){} // RVA: 0x7FFAF9EF1700
    }

}