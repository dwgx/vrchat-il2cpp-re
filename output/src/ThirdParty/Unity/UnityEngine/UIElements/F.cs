// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 5
// Methods: 68

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class FieldMouseDragger`1 : BaseFieldMouseDragger
    {
        public object dragging;
        public object startValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_dragging(){} // RVA: 0x7FFD4E079D00
        public void set_dragging(){} // RVA: 0x7FFD4E091060
        public void get_startValue(){} // RVA: 0x7FFD4E2ADC40
        public void set_startValue(){} // RVA: 0x7FFD4E2ADC40
        public void SetDragZone(){}
        public void CanStartDrag(){} // RVA: 0x7FFD4E2ADC40
        public void UpdateValueOnPointerDown(){} // RVA: 0x7FFD4E090A40
        public void ProcessDownEvent(){} // RVA: 0x7FFD4E090A40
        public void UpdateValueOnPointerMove(){} // RVA: 0x7FFD4E090A40
        public void ProcessMoveEvent(){} // RVA: 0x7FFD4E2ADC40
        public void UpdateValueOnPointerUp(){} // RVA: 0x7FFD4E090A40
        public void ProcessUpEvent(){} // RVA: 0x7FFD4E097970
        public void UpdateValueOnKeyDown(){} // RVA: 0x7FFD4E090A40
    }

    public class FixedHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        public object resolvedItemHeight;

        // ── Methods ──
        public void get_resolvedItemHeight(){} // RVA: 0x7FFD4E08D880
        public void VisibleItemPredicate(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7FFD4E08DC30
        public void GetExpectedContentHeight(){} // RVA: 0x7FFD4E08D880
        public void ScrollToItem(){} // RVA: 0x7FFD4E090ED0
        public void Resize(){} // RVA: 0x7FFD4E09F3E0
        public void OnScroll(){} // RVA: 0x7FFD4E09F3E0
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7FFD4E2ADC40
        public void EndDrag(){} // RVA: 0x7FFD4E090ED0
    }

    public class FocusEventBase`1 : EventBase`1
    {
        public object relatedTarget;
        public object direction;
        public object focusController;
        public object IsFocusDelegated;

        // ── Methods ──
        public void get_relatedTarget(){} // RVA: 0x7FFD4E078E90
        public void set_relatedTarget(){} // RVA: 0x7FFD4E090A40
        public void get_direction(){} // RVA: 0x7FFD4E078E90
        public void set_direction(){} // RVA: 0x7FFD4E090A40
        public void get_focusController(){} // RVA: 0x7FFD4E078E90
        public void set_focusController(){} // RVA: 0x7FFD4E090A40
        public void get_IsFocusDelegated(){} // RVA: 0x7FFD4E079D00
        public void set_IsFocusDelegated(){} // RVA: 0x7FFD4E091060
        public void Init(){} // RVA: 0x7FFD4E090980
        public void LocalInit(){} // RVA: 0x7FFD4E090980
        public void GetPooled(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class Focusable : CallbackEventHandler
    {
        public object focusController;
        public object focusable;
        public object tabIndex;
        public object delegatesFocus;
        public object excludeFromFocusRing;
        public object canGrabFocus;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54FB3010
        public void get_focusController(){} // RVA: 0x7FFD4E078E90
        public void get_focusable(){} // RVA: 0x7FFD4E42F9D0
        public void set_focusable(){} // RVA: 0x7FFD4E42F9E0
        public void get_tabIndex(){} // RVA: 0x7FFD4ED41980
        public void set_tabIndex(){} // RVA: 0x7FFD4F5874D0
        public void get_delegatesFocus(){} // RVA: 0x7FFD54FB3020
        public void set_delegatesFocus(){} // RVA: 0x7FFD4F044F40
        public void get_excludeFromFocusRing(){} // RVA: 0x7FFD54FB3030
        public void set_excludeFromFocusRing(){} // RVA: 0x7FFD54FB3040
        public void get_canGrabFocus(){} // RVA: 0x7FFD4E42F9D0
        public void Focus(){} // RVA: 0x7FFD54FB3120
        public void Blur(){} // RVA: 0x7FFD54FB3250
        public void BlurImmediately(){} // RVA: 0x7FFD54FB32A0
        public void GetFocusDelegate(){} // RVA: 0x7FFD54FB32F0
        public void GetFirstFocusableChild(){} // RVA: 0x7FFD54FB3380
        public void ExecuteDefaultAction(){} // RVA: 0x7FFD54FB3530
        public void ExecuteDefaultActionDisabled(){} // RVA: 0x7FFD54FB3530
        public void ProcessEvent(){} // RVA: 0x7FFD54FB3530
    }

    public class FontDefinition : ValueType
    {
        public object font;
        public object fontAsset;

        // ── Methods ──
        public void get_font(){} // RVA: 0x7FFD505F9A30
        public void get_fontAsset(){} // RVA: 0x7FFD53AD4B80
        public void FromFont(){} // RVA: 0x7FFD54FF8630
        public void FromSDFFont(){} // RVA: 0x7FFD54FF86B0
        public void FromObject(){} // RVA: 0x7FFD54FF8730
        public void IsEmpty(){} // RVA: 0x7FFD54FF8A00
        public void ToString(){} // RVA: 0x7FFD54FF8B80
        public void Equals(){} // RVA: 0x7FFD54FF8D70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54FF8E10
        public void op_Equality(){} // RVA: 0x7FFD54FF8FD0
        public void op_Inequality(){} // RVA: 0x7FFD54FF8FF0
    }

}