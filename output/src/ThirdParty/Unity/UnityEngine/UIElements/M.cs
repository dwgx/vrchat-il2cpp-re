// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 44
// Methods: 638

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Manipulator : Object
    {
        // ── Methods ──
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7A7E18770
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7A7E18770
        public void get_target(){} // RVA: 0x7AB1AC740
        public void set_target(){} // RVA: 0x7AF1ECED0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ManipulatorActivationFilter : ValueType
    {
        // ── Methods ──
        public void get_button(){} // RVA: 0x7A765F070
        public void set_button(){} // RVA: 0x7A76134D0
        public void get_modifiers(){} // RVA: 0x7A765F0A0
        public void set_modifiers(){} // RVA: 0x7A765F090
        public void get_clickCount(){} // RVA: 0x7A75FEFA0
        public void Equals(){} // RVA: 0x7A7F02CC0
        public void GetHashCode(){} // RVA: 0x7A7F02D00
        public void Matches(){} // RVA: 0x7A7F02D40
        public void HasModifiers(){} // RVA: 0x7A7F02D50
        public void MatchModifiers(){} // RVA: 0x7A7F02D60
    }

    public class MeshBuilderNative : Object
    {
        // ── Methods ──
        public void MakeBorder(){} // RVA: 0x7AF1ED6D0
        public void MakeSolidRect(){} // RVA: 0x7AF1ED750
        public void MakeTexturedRect(){} // RVA: 0x7AF1ED7D0
        public void MakeVectorGraphicsStretchBackground(){} // RVA: 0x7AF1ED850
        public void MakeVectorGraphics9SliceBackground(){} // RVA: 0x7AF1ED960
        public void MakeBorder_Injected(){} // RVA: 0x7AF1EDA40
        public void MakeSolidRect_Injected(){} // RVA: 0x7AF1EDAB0
        public void MakeTexturedRect_Injected(){} // RVA: 0x7AF1EDB20
        public void MakeVectorGraphicsStretchBackground_Injected(){} // RVA: 0x7AF1EDB90
        public void MakeVectorGraphics9SliceBackground_Injected(){} // RVA: 0x7AF1EDC20
    }

    public class MeshGenerationContext : Object
    {
        // ── Methods ──
        public void get_painter2D(){} // RVA: 0x7AF215200
        public void get_hasPainter2D(){} // RVA: 0x7A8CCB4F0
        public void .ctor(){} // RVA: 0x7A813E420
        public void .cctor(){} // RVA: 0x7AF2152B0
    }

    public class MeshGenerationContextUtils : Object
    {
        // ── Methods ──
        public void Rectangle(){} // RVA: 0x7AF2121C0
        public void Text(){} // RVA: 0x7AF212320
        public void ConvertBorderRadiusPercentToPoints(){} // RVA: 0x7AF2123F0
        public void GetVisualElementRadii(){} // RVA: 0x7AF212450
        public void AdjustBackgroundSizeForBorders(){} // RVA: 0x7AF212700
    }

    public class MeshWriteData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_vertexCount(){} // RVA: 0x7AF211D60
        public void get_indexCount(){} // RVA: 0x7AF211DA0
        public void get_uvRegion(){} // RVA: 0x7AEF3E930
        public void SetNextVertex(){} // RVA: 0x7AF211DE0
        public void SetNextIndex(){} // RVA: 0x7AF211E90
        public void SetAllVertices(){} // RVA: 0x7AF211F20
        public void SetAllIndices(){} // RVA: 0x7AF211FE0
        public void Reset(){} // RVA: 0x7AF2120D0
    }

    public class MinMaxSlider : BaseField`1
    {
        // ── Methods ──
        public void get_dragElement(){} // RVA: 0x7A8B526C0
        public void set_dragElement(){} // RVA: 0x7A8B59A70
        public void get_dragMinThumb(){} // RVA: 0x7A8B5E0F0
        public void set_dragMinThumb(){} // RVA: 0x7A8B67A70
        public void get_dragMaxThumb(){} // RVA: 0x7A8B5A090
        public void set_dragMaxThumb(){} // RVA: 0x7A8B4F9E0
        public void get_clampedDragger(){} // RVA: 0x7A8B6D320
        public void set_clampedDragger(){} // RVA: 0x7A8B5B280
        public void get_minValue(){} // RVA: 0x7AF1875F0
        public void set_minValue(){} // RVA: 0x7AF187620
        public void get_maxValue(){} // RVA: 0x7AF1876A0
        public void set_maxValue(){} // RVA: 0x7AF1876D0
        public void get_value(){} // RVA: 0x7AF187750
        public void set_value(){} // RVA: 0x7AF1877A0
        public void SetValueWithoutNotify(){} // RVA: 0x7AF187800
        public void get_lowLimit(){} // RVA: 0x7AF187870
        public void set_lowLimit(){} // RVA: 0x7AF187880
        public void get_highLimit(){} // RVA: 0x7AF187980
        public void set_highLimit(){} // RVA: 0x7AF187990
        public void .ctor(){} // RVA: 0x7AF187AD0
        public void ClampValues(){} // RVA: 0x7AF1883D0
        public void UpdateDragElementPosition(){} // RVA: 0x7AF1884D0
        public void SliderLerpUnclamped(){} // RVA: 0x7AF189200
        public void SliderNormalizeValue(){} // RVA: 0x7AF189220
        public void ComputeValueFromPosition(){} // RVA: 0x7AF189240
        public void ExecuteDefaultAction(){} // RVA: 0x7AF189360
        public void SetSliderValueFromDrag(){} // RVA: 0x7AF1894B0
        public void SetSliderValueFromClick(){} // RVA: 0x7AF189540
        public void ComputeValueDragStateNoThumb(){} // RVA: 0x7AF1899B0
        public void ComputeValueFromDraggingThumb(){} // RVA: 0x7AF189A80
        public void UpdateMixedValueContent(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AF189CA0
    }

    public class MouseCaptureController : Object
    {
        // ── Methods ──
        public void HasMouseCapture(){} // RVA: 0x7AF1ECF70
        public void CaptureMouse(){} // RVA: 0x7AF1ED030
        public void ReleaseMouse(){} // RVA: 0x7AF1ED150
    }

    public class MouseCaptureDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7AF1CD2F0
        public void DispatchEvent(){} // RVA: 0x7AF1CD370
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class MouseCaptureEvent : MouseCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1C4FD0
        public void .ctor(){} // RVA: 0x7AF1C50C0
    }

    public class MouseCaptureEventBase`1 : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class MouseCaptureEventBase`1 : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7ABA38F90
        public void .ctor(){} // RVA: 0x7ABA39030
    }

    public class MouseCaptureEventBase`1 : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7ABA38F90
        public void .ctor(){} // RVA: 0x7ABA39030
    }

    public class MouseCaptureOutEvent : MouseCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1C4D70
        public void .ctor(){} // RVA: 0x7AF1C4E60
    }

    public class MouseDownEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1CE5D0
        public void Init(){} // RVA: 0x7AF1CE6C0
        public void LocalInit(){} // RVA: 0x7AF1CE780
        public void .ctor(){} // RVA: 0x7AF1CE790
        public void MakeFromPointerEvent(){} // RVA: 0x7AF1CE7E0
        public void GetPooled(){} // RVA: 0x7AF1CE940
    }

    public class MouseEnterEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1CFBC0
        public void Init(){} // RVA: 0x7AF1CFCB0
        public void LocalInit(){} // RVA: 0x7AF1CFD70
        public void .ctor(){} // RVA: 0x7AF1CFD80
    }

    public class MouseEnterWindowEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1D0210
        public void Init(){} // RVA: 0x7AF1D0300
        public void LocalInit(){} // RVA: 0x7AF1D03C0
        public void .ctor(){} // RVA: 0x7AF1D03D0
        public void PostDispatch(){} // RVA: 0x7AF1D0420
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A7E00710
        public void set_modifiers(){} // RVA: 0x7A7E189D0
        public void get_mousePosition(){} // RVA: 0x7A7E00680
        public void set_mousePosition(){} // RVA: 0x7A7E1A3B0
        public void get_localMousePosition(){} // RVA: 0x7A7E00680
        public void set_localMousePosition(){} // RVA: 0x7A7E1A3B0
        public void get_mouseDelta(){} // RVA: 0x7A7E00680
        public void set_mouseDelta(){} // RVA: 0x7A7E1A3B0
        public void get_clickCount(){} // RVA: 0x7A7E00710
        public void set_clickCount(){} // RVA: 0x7A7E189D0
        public void get_button(){} // RVA: 0x7A7E00710
        public void set_button(){} // RVA: 0x7A7E189D0
        public void get_pressedButtons(){} // RVA: 0x7A7E00710
        public void set_pressedButtons(){} // RVA: 0x7A7E189D0
        public void get_shiftKey(){} // RVA: 0x7A7E01900
        public void get_ctrlKey(){} // RVA: 0x7A7E01900
        public void get_commandKey(){} // RVA: 0x7A7E01900
        public void get_altKey(){} // RVA: 0x7A7E01900
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A7E01900
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A7E18C30
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7A7E01900
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7A7E18C30
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A7E00680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A7E18800
        public void Init(){} // RVA: 0x7A7E18770
        public void LocalInit(){} // RVA: 0x7A7E18770
        public void get_currentTarget(){} // RVA: 0x7A7E00680
        public void set_currentTarget(){} // RVA: 0x7A7E18800
        public void PreDispatch(){} // RVA: 0x7A7E18800
        public void PostDispatch(){} // RVA: 0x7A7E18800
        public void GetPooled(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_mousePosition(){} // RVA: 0x7ABA39050
        public void set_mousePosition(){} // RVA: 0x7ABA39070
        public void get_localMousePosition(){} // RVA: 0x7ABA39080
        public void set_localMousePosition(){} // RVA: 0x7ABA390A0
        public void get_mouseDelta(){} // RVA: 0x7ABA390B0
        public void set_mouseDelta(){} // RVA: 0x7ABA390D0
        public void get_clickCount(){} // RVA: 0x7ABA390E0
        public void set_clickCount(){} // RVA: 0x7ABA390F0
        public void get_button(){} // RVA: 0x7A8A69800
        public void set_button(){} // RVA: 0x7A8A67200
        public void get_pressedButtons(){} // RVA: 0x7ABA39100
        public void set_pressedButtons(){} // RVA: 0x7ABA39110
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A94ED040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A94F0290
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39120
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A8142680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A8142690
        public void Init(){} // RVA: 0x7ABA39140
        public void LocalInit(){} // RVA: 0x7ABA391E0
        public void get_currentTarget(){} // RVA: 0x7ABA39360
        public void set_currentTarget(){} // RVA: 0x7ABA39380
        public void PreDispatch(){} // RVA: 0x7ABA394A0
        public void PostDispatch(){} // RVA: 0x7ABA39600
        public void GetPooled(){} // RVA: 0x7ABA3A060
        public void .ctor(){} // RVA: 0x7ABA3A450
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_mousePosition(){} // RVA: 0x7ABA39050
        public void set_mousePosition(){} // RVA: 0x7ABA39070
        public void get_localMousePosition(){} // RVA: 0x7ABA39080
        public void set_localMousePosition(){} // RVA: 0x7ABA390A0
        public void get_mouseDelta(){} // RVA: 0x7ABA390B0
        public void set_mouseDelta(){} // RVA: 0x7ABA390D0
        public void get_clickCount(){} // RVA: 0x7ABA390E0
        public void set_clickCount(){} // RVA: 0x7ABA390F0
        public void get_button(){} // RVA: 0x7A8A69800
        public void set_button(){} // RVA: 0x7A8A67200
        public void get_pressedButtons(){} // RVA: 0x7ABA39100
        public void set_pressedButtons(){} // RVA: 0x7ABA39110
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A94ED040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A94F0290
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39120
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A8142680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A8142690
        public void Init(){} // RVA: 0x7ABA39140
        public void LocalInit(){} // RVA: 0x7ABA391E0
        public void get_currentTarget(){} // RVA: 0x7ABA39360
        public void set_currentTarget(){} // RVA: 0x7ABA39380
        public void PreDispatch(){} // RVA: 0x7ABA394A0
        public void PostDispatch(){} // RVA: 0x7ABA39600
        public void GetPooled(){} // RVA: 0x7ABA3A060
        public void .ctor(){} // RVA: 0x7ABA3A450
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_mousePosition(){} // RVA: 0x7ABA39050
        public void set_mousePosition(){} // RVA: 0x7ABA39070
        public void get_localMousePosition(){} // RVA: 0x7ABA39080
        public void set_localMousePosition(){} // RVA: 0x7ABA390A0
        public void get_mouseDelta(){} // RVA: 0x7ABA390B0
        public void set_mouseDelta(){} // RVA: 0x7ABA390D0
        public void get_clickCount(){} // RVA: 0x7ABA390E0
        public void set_clickCount(){} // RVA: 0x7ABA390F0
        public void get_button(){} // RVA: 0x7A8A69800
        public void set_button(){} // RVA: 0x7A8A67200
        public void get_pressedButtons(){} // RVA: 0x7ABA39100
        public void set_pressedButtons(){} // RVA: 0x7ABA39110
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A94ED040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A94F0290
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39120
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A8142680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A8142690
        public void Init(){} // RVA: 0x7ABA39140
        public void LocalInit(){} // RVA: 0x7ABA391E0
        public void get_currentTarget(){} // RVA: 0x7ABA39360
        public void set_currentTarget(){} // RVA: 0x7ABA39380
        public void PreDispatch(){} // RVA: 0x7ABA394A0
        public void PostDispatch(){} // RVA: 0x7ABA39600
        public void GetPooled(){} // RVA: 0x7ABA3A060
        public void .ctor(){} // RVA: 0x7ABA3A450
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_mousePosition(){} // RVA: 0x7ABA39050
        public void set_mousePosition(){} // RVA: 0x7ABA39070
        public void get_localMousePosition(){} // RVA: 0x7ABA39080
        public void set_localMousePosition(){} // RVA: 0x7ABA390A0
        public void get_mouseDelta(){} // RVA: 0x7ABA390B0
        public void set_mouseDelta(){} // RVA: 0x7ABA390D0
        public void get_clickCount(){} // RVA: 0x7ABA390E0
        public void set_clickCount(){} // RVA: 0x7ABA390F0
        public void get_button(){} // RVA: 0x7A8A69800
        public void set_button(){} // RVA: 0x7A8A67200
        public void get_pressedButtons(){} // RVA: 0x7ABA39100
        public void set_pressedButtons(){} // RVA: 0x7ABA39110
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A94ED040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A94F0290
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39120
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A8142680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A8142690
        public void Init(){} // RVA: 0x7ABA39140
        public void LocalInit(){} // RVA: 0x7ABA391E0
        public void get_currentTarget(){} // RVA: 0x7ABA39360
        public void set_currentTarget(){} // RVA: 0x7ABA39380
        public void PreDispatch(){} // RVA: 0x7ABA394A0
        public void PostDispatch(){} // RVA: 0x7ABA39600
        public void GetPooled(){} // RVA: 0x7ABA3A060
        public void .ctor(){} // RVA: 0x7ABA3A450
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_mousePosition(){} // RVA: 0x7ABA39050
        public void set_mousePosition(){} // RVA: 0x7ABA39070
        public void get_localMousePosition(){} // RVA: 0x7ABA39080
        public void set_localMousePosition(){} // RVA: 0x7ABA390A0
        public void get_mouseDelta(){} // RVA: 0x7ABA390B0
        public void set_mouseDelta(){} // RVA: 0x7ABA390D0
        public void get_clickCount(){} // RVA: 0x7ABA390E0
        public void set_clickCount(){} // RVA: 0x7ABA390F0
        public void get_button(){} // RVA: 0x7A8A69800
        public void set_button(){} // RVA: 0x7A8A67200
        public void get_pressedButtons(){} // RVA: 0x7ABA39100
        public void set_pressedButtons(){} // RVA: 0x7ABA39110
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A94ED040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A94F0290
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39120
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A8142680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A8142690
        public void Init(){} // RVA: 0x7ABA39140
        public void LocalInit(){} // RVA: 0x7ABA391E0
        public void get_currentTarget(){} // RVA: 0x7ABA39360
        public void set_currentTarget(){} // RVA: 0x7ABA39380
        public void PreDispatch(){} // RVA: 0x7ABA394A0
        public void PostDispatch(){} // RVA: 0x7ABA39600
        public void GetPooled(){} // RVA: 0x7ABA3A060
        public void .ctor(){} // RVA: 0x7ABA3A450
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_mousePosition(){} // RVA: 0x7ABA39050
        public void set_mousePosition(){} // RVA: 0x7ABA39070
        public void get_localMousePosition(){} // RVA: 0x7ABA39080
        public void set_localMousePosition(){} // RVA: 0x7ABA390A0
        public void get_mouseDelta(){} // RVA: 0x7ABA390B0
        public void set_mouseDelta(){} // RVA: 0x7ABA390D0
        public void get_clickCount(){} // RVA: 0x7ABA390E0
        public void set_clickCount(){} // RVA: 0x7ABA390F0
        public void get_button(){} // RVA: 0x7A8A69800
        public void set_button(){} // RVA: 0x7A8A67200
        public void get_pressedButtons(){} // RVA: 0x7ABA39100
        public void set_pressedButtons(){} // RVA: 0x7ABA39110
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A94ED040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A94F0290
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39120
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A8142680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A8142690
        public void Init(){} // RVA: 0x7ABA39140
        public void LocalInit(){} // RVA: 0x7ABA391E0
        public void get_currentTarget(){} // RVA: 0x7ABA39360
        public void set_currentTarget(){} // RVA: 0x7ABA39380
        public void PreDispatch(){} // RVA: 0x7ABA394A0
        public void PostDispatch(){} // RVA: 0x7ABA39600
        public void GetPooled(){} // RVA: 0x7ABA3A060
        public void .ctor(){} // RVA: 0x7ABA3A450
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_mousePosition(){} // RVA: 0x7ABA39050
        public void set_mousePosition(){} // RVA: 0x7ABA39070
        public void get_localMousePosition(){} // RVA: 0x7ABA39080
        public void set_localMousePosition(){} // RVA: 0x7ABA390A0
        public void get_mouseDelta(){} // RVA: 0x7ABA390B0
        public void set_mouseDelta(){} // RVA: 0x7ABA390D0
        public void get_clickCount(){} // RVA: 0x7ABA390E0
        public void set_clickCount(){} // RVA: 0x7ABA390F0
        public void get_button(){} // RVA: 0x7A8A69800
        public void set_button(){} // RVA: 0x7A8A67200
        public void get_pressedButtons(){} // RVA: 0x7ABA39100
        public void set_pressedButtons(){} // RVA: 0x7ABA39110
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A94ED040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A94F0290
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39120
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A8142680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A8142690
        public void Init(){} // RVA: 0x7ABA39140
        public void LocalInit(){} // RVA: 0x7ABA391E0
        public void get_currentTarget(){} // RVA: 0x7ABA39360
        public void set_currentTarget(){} // RVA: 0x7ABA39380
        public void PreDispatch(){} // RVA: 0x7ABA394A0
        public void PostDispatch(){} // RVA: 0x7ABA39600
        public void GetPooled(){} // RVA: 0x7ABA3A060
        public void .ctor(){} // RVA: 0x7ABA3A450
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_mousePosition(){} // RVA: 0x7ABA39050
        public void set_mousePosition(){} // RVA: 0x7ABA39070
        public void get_localMousePosition(){} // RVA: 0x7ABA39080
        public void set_localMousePosition(){} // RVA: 0x7ABA390A0
        public void get_mouseDelta(){} // RVA: 0x7ABA390B0
        public void set_mouseDelta(){} // RVA: 0x7ABA390D0
        public void get_clickCount(){} // RVA: 0x7ABA390E0
        public void set_clickCount(){} // RVA: 0x7ABA390F0
        public void get_button(){} // RVA: 0x7A8A69800
        public void set_button(){} // RVA: 0x7A8A67200
        public void get_pressedButtons(){} // RVA: 0x7ABA39100
        public void set_pressedButtons(){} // RVA: 0x7ABA39110
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A94ED040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A94F0290
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39120
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A8142680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A8142690
        public void Init(){} // RVA: 0x7ABA39140
        public void LocalInit(){} // RVA: 0x7ABA391E0
        public void get_currentTarget(){} // RVA: 0x7ABA39360
        public void set_currentTarget(){} // RVA: 0x7ABA39380
        public void PreDispatch(){} // RVA: 0x7ABA394A0
        public void PostDispatch(){} // RVA: 0x7ABA39600
        public void GetPooled(){} // RVA: 0x7ABA3A060
        public void .ctor(){} // RVA: 0x7ABA3A450
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_mousePosition(){} // RVA: 0x7ABA39050
        public void set_mousePosition(){} // RVA: 0x7ABA39070
        public void get_localMousePosition(){} // RVA: 0x7ABA39080
        public void set_localMousePosition(){} // RVA: 0x7ABA390A0
        public void get_mouseDelta(){} // RVA: 0x7ABA390B0
        public void set_mouseDelta(){} // RVA: 0x7ABA390D0
        public void get_clickCount(){} // RVA: 0x7ABA390E0
        public void set_clickCount(){} // RVA: 0x7ABA390F0
        public void get_button(){} // RVA: 0x7A8A69800
        public void set_button(){} // RVA: 0x7A8A67200
        public void get_pressedButtons(){} // RVA: 0x7ABA39100
        public void set_pressedButtons(){} // RVA: 0x7ABA39110
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A94ED040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A94F0290
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39120
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A8142680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A8142690
        public void Init(){} // RVA: 0x7ABA39140
        public void LocalInit(){} // RVA: 0x7ABA391E0
        public void get_currentTarget(){} // RVA: 0x7ABA39360
        public void set_currentTarget(){} // RVA: 0x7ABA39380
        public void PreDispatch(){} // RVA: 0x7ABA394A0
        public void PostDispatch(){} // RVA: 0x7ABA39600
        public void GetPooled(){} // RVA: 0x7ABA3A060
        public void .ctor(){} // RVA: 0x7ABA3A450
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_mousePosition(){} // RVA: 0x7ABA39050
        public void set_mousePosition(){} // RVA: 0x7ABA39070
        public void get_localMousePosition(){} // RVA: 0x7ABA39080
        public void set_localMousePosition(){} // RVA: 0x7ABA390A0
        public void get_mouseDelta(){} // RVA: 0x7ABA390B0
        public void set_mouseDelta(){} // RVA: 0x7ABA390D0
        public void get_clickCount(){} // RVA: 0x7ABA390E0
        public void set_clickCount(){} // RVA: 0x7ABA390F0
        public void get_button(){} // RVA: 0x7A8A69800
        public void set_button(){} // RVA: 0x7A8A67200
        public void get_pressedButtons(){} // RVA: 0x7ABA39100
        public void set_pressedButtons(){} // RVA: 0x7ABA39110
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A94ED040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A94F0290
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39120
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A8142680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A8142690
        public void Init(){} // RVA: 0x7ABA39140
        public void LocalInit(){} // RVA: 0x7ABA391E0
        public void get_currentTarget(){} // RVA: 0x7ABA39360
        public void set_currentTarget(){} // RVA: 0x7ABA39380
        public void PreDispatch(){} // RVA: 0x7ABA394A0
        public void PostDispatch(){} // RVA: 0x7ABA39600
        public void GetPooled(){} // RVA: 0x7ABA3A060
        public void .ctor(){} // RVA: 0x7ABA3A450
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_mousePosition(){} // RVA: 0x7ABA39050
        public void set_mousePosition(){} // RVA: 0x7ABA39070
        public void get_localMousePosition(){} // RVA: 0x7ABA39080
        public void set_localMousePosition(){} // RVA: 0x7ABA390A0
        public void get_mouseDelta(){} // RVA: 0x7ABA390B0
        public void set_mouseDelta(){} // RVA: 0x7ABA390D0
        public void get_clickCount(){} // RVA: 0x7ABA390E0
        public void set_clickCount(){} // RVA: 0x7ABA390F0
        public void get_button(){} // RVA: 0x7A8A69800
        public void set_button(){} // RVA: 0x7A8A67200
        public void get_pressedButtons(){} // RVA: 0x7ABA39100
        public void set_pressedButtons(){} // RVA: 0x7ABA39110
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A94ED040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A94F0290
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39120
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A8142680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A8142690
        public void Init(){} // RVA: 0x7ABA39140
        public void LocalInit(){} // RVA: 0x7ABA391E0
        public void get_currentTarget(){} // RVA: 0x7ABA39360
        public void set_currentTarget(){} // RVA: 0x7ABA39380
        public void PreDispatch(){} // RVA: 0x7ABA394A0
        public void PostDispatch(){} // RVA: 0x7ABA39600
        public void GetPooled(){} // RVA: 0x7ABA3A060
        public void .ctor(){} // RVA: 0x7ABA3A450
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_mousePosition(){} // RVA: 0x7ABA39050
        public void set_mousePosition(){} // RVA: 0x7ABA39070
        public void get_localMousePosition(){} // RVA: 0x7ABA39080
        public void set_localMousePosition(){} // RVA: 0x7ABA390A0
        public void get_mouseDelta(){} // RVA: 0x7ABA390B0
        public void set_mouseDelta(){} // RVA: 0x7ABA390D0
        public void get_clickCount(){} // RVA: 0x7ABA390E0
        public void set_clickCount(){} // RVA: 0x7ABA390F0
        public void get_button(){} // RVA: 0x7A8A69800
        public void set_button(){} // RVA: 0x7A8A67200
        public void get_pressedButtons(){} // RVA: 0x7ABA39100
        public void set_pressedButtons(){} // RVA: 0x7ABA39110
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7A94ED040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7A94F0290
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39120
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ABA39130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7A8142680
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7A8142690
        public void Init(){} // RVA: 0x7ABA39140
        public void LocalInit(){} // RVA: 0x7ABA391E0
        public void get_currentTarget(){} // RVA: 0x7ABA39360
        public void set_currentTarget(){} // RVA: 0x7ABA39380
        public void PreDispatch(){} // RVA: 0x7ABA394A0
        public void PostDispatch(){} // RVA: 0x7ABA39600
        public void GetPooled(){} // RVA: 0x7ABA3A060
        public void .ctor(){} // RVA: 0x7ABA3A450
    }

    public class MouseEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7AF1CDA30
        public void DispatchEvent(){} // RVA: 0x7AF1CDA80
        public void SendEventToTarget(){} // RVA: 0x7AF1CDCF0
        public void SendEventToRegularTarget(){} // RVA: 0x7AF1CDE10
        public void SendEventToIMGUIContainer(){} // RVA: 0x7AF1CDF20
        public void SetBestTargetForEvent(){} // RVA: 0x7AF1CE130
        public void UpdateElementUnderMouse(){} // RVA: 0x7AF1CE1E0
        public void IsDone(){} // RVA: 0x7AF1CE540
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class MouseEventsHelper : Object
    {
        // ── Methods ──
        public void SendEnterLeave(){} // RVA: 0x7A8051B10
        public void SendMouseOverMouseOut(){} // RVA: 0x7AF1D1BD0
    }

    public class MouseLeaveEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1CFEF0
        public void Init(){} // RVA: 0x7AF1CFFE0
        public void LocalInit(){} // RVA: 0x7AF1CFD70
        public void .ctor(){} // RVA: 0x7AF1D00A0
    }

    public class MouseLeaveWindowEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1D0640
        public void Init(){} // RVA: 0x7AF1D0730
        public void LocalInit(){} // RVA: 0x7AF1D0830
        public void .ctor(){} // RVA: 0x7AF1D0880
        public void GetPooled(){} // RVA: 0x7AF1D0900
        public void PostDispatch(){} // RVA: 0x7AF1D0A20
    }

    public class MouseManipulator : Manipulator
    {
        // ── Methods ──
        public void get_activators(){} // RVA: 0x7A80DA7B0
        public void set_activators(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF1ED270
        public void CanStartManipulation(){} // RVA: 0x7AF1ED330
        public void CanStopManipulation(){} // RVA: 0x7AF1ED560
    }

    public class MouseMoveEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1CEFD0
        public void Init(){} // RVA: 0x7AF1CF0C0
        public void LocalInit(){} // RVA: 0x7AF1CF180
        public void .ctor(){} // RVA: 0x7AF1CF190
        public void GetPooled(){} // RVA: 0x7AF1CF1E0
    }

    public class MouseOutEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1D0EB0
        public void .ctor(){} // RVA: 0x7AF1D0FA0
    }

    public class MouseOverEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1D0C70
        public void .ctor(){} // RVA: 0x7AF1D0D60
    }

    public class MouseUpEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1CEAB0
        public void Init(){} // RVA: 0x7AF1CEBA0
        public void LocalInit(){} // RVA: 0x7AF1CE780
        public void .ctor(){} // RVA: 0x7AF1CEC60
        public void MakeFromPointerEvent(){} // RVA: 0x7AF1CECB0
        public void GetPooled(){} // RVA: 0x7AF1CEE60
    }

    public class MultiColumnController : Object
    {
        // ── Methods ──
        public void add_columnSortingChanged(){} // RVA: 0x7AF1918E0
        public void remove_columnSortingChanged(){} // RVA: 0x7AF1919D0
        public void add_headerContextMenuPopulateEvent(){} // RVA: 0x7AF191AC0
        public void remove_headerContextMenuPopulateEvent(){} // RVA: 0x7AF191BD0
        public void get_header(){} // RVA: 0x7A83F69F0
        public void .ctor(){} // RVA: 0x7AF191CE0
        public void BindCellItem(){} // RVA: 0x7A8051B10
        public void UnbindCellItem(){} // RVA: 0x7AF192590
        public void DefaultMakeCellItem(){} // RVA: 0x7AF1925D0
        public void DefaultBindCellItem(){} // RVA: 0x7A8051B10
        public void MakeItem(){} // RVA: 0x7AF1926A0
        public void BindItem(){} // RVA: 0x7A8051B10
        public void UnbindItem(){} // RVA: 0x7AF192A40
        public void DestroyItem(){} // RVA: 0x7AF192DD0
        public void PrepareView(){} // RVA: 0x7AF193180
        public void Dispose(){} // RVA: 0x7AF193580
        public void OnHorizontalScrollerValueChanged(){} // RVA: 0x7AF194130
        public void OnViewportGeometryChanged(){} // RVA: 0x7AF194270
        public void OnColumnContainerGeometryChanged(){} // RVA: 0x7AF194500
        public void UpdateContentContainer(){} // RVA: 0x7AF194510
        public void OnColumnSortingChanged(){} // RVA: 0x7A8429A00
        public void OnContextMenuPopulateEvent(){} // RVA: 0x7ACD587F0
        public void OnColumnResized(){} // RVA: 0x7AF1946C0
        public void OnColumnAdded(){} // RVA: 0x7AF194A60
        public void OnColumnRemoved(){} // RVA: 0x7AF194A60
        public void OnColumnReordered(){} // RVA: 0x7AF194A80
        public void OnColumnsChanged(){} // RVA: 0x7AF194AC0
        public void OnColumnChanged(){} // RVA: 0x7AF194B00
        public void OnViewDataRestored(){} // RVA: 0x7AF194A60
        public void .cctor(){} // RVA: 0x7AF194B40
    }

    public class MultiColumnListView : BaseListView
    {
        // ── Methods ──
        public void get_viewController(){} // RVA: 0x7AF195080
        public void get_columns(){} // RVA: 0x7A8B65870
        public void set_columns(){} // RVA: 0x7AF195100
        public void get_sortColumnDescriptions(){} // RVA: 0x7A8B76290
        public void set_sortColumnDescriptions(){} // RVA: 0x7AF1951F0
        public void set_sortingEnabled(){} // RVA: 0x7AF1952F0
        public void .ctor(){} // RVA: 0x7AF1953D0
        public void CreateViewController(){} // RVA: 0x7AF1955E0
        public void SetViewController(){} // RVA: 0x7AF1956F0
        public void CreateVirtualizationController(){} // RVA: 0x7AF195940
        public void RaiseColumnSortingChanged(){} // RVA: 0x7AF195980
        public void RaiseHeaderContextMenuPopulate(){} // RVA: 0x7AF1959A0
    }

    public class MultiColumnListViewController : BaseListViewController
    {
        // ── Methods ──
        public void get_columnController(){} // RVA: 0x7A8152D80
        public void get_header(){} // RVA: 0x7AF0D32C0
        public void .ctor(){} // RVA: 0x7AF0D32D0
        public void InvokeMakeItem(){} // RVA: 0x7AF0D33B0
        public void MakeItem(){} // RVA: 0x7AF0D34D0
        public void BindItem(){} // RVA: 0x7AF0D34F0
        public void UnbindItem(){} // RVA: 0x7AF0D3590
        public void DestroyItem(){} // RVA: 0x7AF0D35B0
        public void PrepareView(){} // RVA: 0x7AF0D35D0
        public void Dispose(){} // RVA: 0x7AF0D3760
        public void UpdateReorderClassList(){} // RVA: 0x7AF0D3950
    }

    public class MultiColumnTreeView : BaseTreeView
    {
        // ── Methods ──
        public void get_viewController(){} // RVA: 0x7AF195F40
        public void get_columns(){} // RVA: 0x7A8B58DC0
        public void set_columns(){} // RVA: 0x7AF195FC0
        public void get_sortColumnDescriptions(){} // RVA: 0x7A8B5DB90
        public void set_sortColumnDescriptions(){} // RVA: 0x7AF1960B0
        public void set_sortingEnabled(){} // RVA: 0x7AF1961B0
        public void .ctor(){} // RVA: 0x7AF196290
        public void CreateViewController(){} // RVA: 0x7AF1964A0
        public void SetViewController(){} // RVA: 0x7AF196540
        public void CreateVirtualizationController(){} // RVA: 0x7AF196870
        public void RaiseColumnSortingChanged(){} // RVA: 0x7AF1968B0
        public void RaiseHeaderContextMenuPopulate(){} // RVA: 0x7AF1968D0
    }

    public class MultiColumnTreeViewController : BaseTreeViewController
    {
        // ── Methods ──
        public void get_columnController(){} // RVA: 0x7A81A0050
        public void get_header(){} // RVA: 0x7AF0D3A40
        public void .ctor(){} // RVA: 0x7AF0D3A50
        public void InvokeMakeItem(){} // RVA: 0x7AF0D3B60
        public void MakeItem(){} // RVA: 0x7AF0D3CB0
        public void BindItem(){} // RVA: 0x7AF0D3CD0
        public void UnbindItem(){} // RVA: 0x7AF0D3D70
        public void DestroyItem(){} // RVA: 0x7AF0D3D90
        public void PrepareView(){} // RVA: 0x7AF0D3DB0
        public void Dispose(){} // RVA: 0x7AF0D3DE0
    }

}