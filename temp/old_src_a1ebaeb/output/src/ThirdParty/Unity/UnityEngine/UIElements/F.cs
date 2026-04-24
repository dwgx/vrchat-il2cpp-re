// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 5
// Methods: 68

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class FieldMouseDragger`1 : BaseFieldMouseDragger
    {
        public object m_DragHotZone; // 0x30FBC810
        public object m_DrivenField; // 0x83B8B488

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void get_dragging(){} // RVA: 0x7ffaa864a040
        public void set_dragging(){} // RVA: 0x7ffaa86613a0
        public void get_startValue(){} // RVA: 0x7ffaa887e5c0
        public void set_startValue(){} // RVA: 0x7ffaa887e5c0
        public void CanStartDrag(){} // RVA: 0x7ffaa887e5c0
        public void UpdateValueOnPointerDown(){} // RVA: 0x7ffaa8660d80
        public void ProcessDownEvent(){} // RVA: 0x7ffaa8660d80
        public void UpdateValueOnPointerMove(){} // RVA: 0x7ffaa8660d80
        public void ProcessMoveEvent(){} // RVA: 0x7ffaa887e5c0
        public void UpdateValueOnPointerUp(){} // RVA: 0x7ffaa8660d80
        public void ProcessUpEvent(){} // RVA: 0x7ffaa8667cb0
        public void UpdateValueOnKeyDown(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void SetDragZone(){}
    }

    public class FixedHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        // ── Original Methods ──
        public void get_resolvedItemHeight(){} // RVA: 0x7ffaa865dbc0
        public void VisibleItemPredicate(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void ScrollToItem(){} // RVA: 0x7ffaa8661210
        public void Resize(){} // RVA: 0x7ffaa866f720
        public void OnScroll(){} // RVA: 0x7ffaa866f720
        public void EndDrag(){} // RVA: 0x7ffaa8661210
        // ── Binary Analysis Named ──
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7ffaa865df70
        public void GetExpectedContentHeight(){} // RVA: 0x7ffaa865dbc0
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7ffaa887e5c0
    }

    public class FocusEventBase`1 : EventBase`1
    {
        public object _focusController; // 0x30FBE590, was: <focusController>k__BackingFie

        // ── Original Methods ──
        public void get_relatedTarget(){} // RVA: 0x7ffaa86491d0
        public void set_relatedTarget(){} // RVA: 0x7ffaa8660d80
        public void get_direction(){} // RVA: 0x7ffaa86491d0
        public void set_direction(){} // RVA: 0x7ffaa8660d80
        public void get_focusController(){} // RVA: 0x7ffaa86491d0
        public void set_focusController(){} // RVA: 0x7ffaa8660d80
        public void get_IsFocusDelegated(){} // RVA: 0x7ffaa864a040
        public void set_IsFocusDelegated(){} // RVA: 0x7ffaa86613a0
        public void Init(){} // RVA: 0x7ffaa8660cc0
        public void LocalInit(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
    }

    public class Focusable : CallbackEventHandler
    {
        public object m_DelegatesFocus; // 0x30B60030
        public object _completedAnimationCount; // 0x30B5B6B0, was: <UnityEngine.UIElements.IStyle

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf5b4f80
        public void get_focusController(){} // RVA: 0x7ffaa86491d0
        public void get_focusable(){} // RVA: 0x7ffaa8a209d0
        public void set_focusable(){} // RVA: 0x7ffaa8a209e0
        public void get_tabIndex(){} // RVA: 0x7ffaa9349010
        public void set_tabIndex(){} // RVA: 0x7ffaa9b8c1b0
        public void get_delegatesFocus(){} // RVA: 0x7ffaaf5b4f90
        public void set_delegatesFocus(){} // RVA: 0x7ffaa96574d0
        public void get_excludeFromFocusRing(){} // RVA: 0x7ffaaf5b4fa0
        public void set_excludeFromFocusRing(){} // RVA: 0x7ffaaf5b4fb0
        public void get_canGrabFocus(){} // RVA: 0x7ffaa8a209d0
        public void Focus(){} // RVA: 0x7ffaaf5b5090
        public void Blur(){} // RVA: 0x7ffaaf5b51c0
        public void BlurImmediately(){} // RVA: 0x7ffaaf5b5210
        public void ExecuteDefaultAction(){} // RVA: 0x7ffaaf5b54a0
        public void ExecuteDefaultActionDisabled(){} // RVA: 0x7ffaaf5b54a0
        public void ProcessEvent(){} // RVA: 0x7ffaaf5b54a0
        // ── Binary Analysis Named ──
        public void GetFocusDelegate(){} // RVA: 0x7ffaaf5b5260
        public void GetFirstFocusableChild(){} // RVA: 0x7ffaaf5b52f0
    }

    public class FontDefinition : ValueType
    {
        // ── Original Methods ──
        public void get_font(){} // RVA: 0x7ffaaabdb990
        public void get_fontAsset(){} // RVA: 0x7ffaae0d5d90
        public void FromFont(){} // RVA: 0x7ffaaf5fa5a0
        public void FromSDFFont(){} // RVA: 0x7ffaaf5fa620
        public void FromObject(){} // RVA: 0x7ffaaf5fa6a0
        public void IsEmpty(){} // RVA: 0x7ffaaf5fa970
        public void ToString(){} // RVA: 0x7ffaaf5faaf0
        public void Equals(){} // RVA: 0x7ffaaf5face0
        public void Equals(){} // RVA: 0x7ffaaf5face0
        public void op_Equality(){} // RVA: 0x7ffaaf5faf40
        public void op_Inequality(){} // RVA: 0x7ffaaf5faf60
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf5fad80
    }

}