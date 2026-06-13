// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 45
// Methods: 688

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Manipulator
    {
        public UnityEngine.UIElements.VisualElement m_Target; // 0x10

        // ── Methods ──
        public void RegisterCallbacksOnTarget(){} // RVA: 0x24A50
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x24A50
        public void get_target(){} // RVA: 0x33B6D40
        public void set_target(){} // RVA: 0x740DDF0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ManipulatorActivationFilter
    {
        public 0x6583AA30 <button>k__BackingField; // 0x10
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x14
        public int <clickCount>k__BackingField; // 0x18

        // ── Methods ──
        public void get_button(){} // RVA: 0x19689B0
        public void set_button(){} // RVA: 0x833580
        public void get_modifiers(){} // RVA: 0x19689E0
        public void set_modifiers(){} // RVA: 0x19689D0
        public void get_clickCount(){} // RVA: 0x1EA9890
        public void Equals(){} // RVA: 0x7158AE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x740D9C0
        public void Matches(){} // RVA: 0x740DBA0 | overloaded x2
        public void HasModifiers(){} // RVA: 0x740DC70 | overloaded x2
        public void MatchModifiers(){} // RVA: 0x740DD60
    }

    public class MeshBuilderNative
    {
        // ── Methods ──
        public void MakeBorder(){} // RVA: 0x740E680
        public void MakeSolidRect(){} // RVA: 0x740E700
        public void MakeTexturedRect(){} // RVA: 0x740E780
        public void MakeVectorGraphicsStretchBackground(){} // RVA: 0x740E800
        public void MakeVectorGraphics9SliceBackground(){} // RVA: 0x740E910
        public void MakeBorder_Injected(){} // RVA: 0x740E9F0
        public void MakeSolidRect_Injected(){} // RVA: 0x740EA60
        public void MakeTexturedRect_Injected(){} // RVA: 0x740EAD0
        public void MakeVectorGraphicsStretchBackground_Injected(){} // RVA: 0x740EB40
        public void MakeVectorGraphics9SliceBackground_Injected(){} // RVA: 0x740EBD0
    }

    public class MeshGenerationContext
    {
        public UnityEngine.UIElements.Painter2D isPainterActive; // 0x10
        public Unity.Profiling.ProfilerMarker maxArcRadius;

        // ── Methods ──
        public void get_painter2D(){} // RVA: 0x7435E10
        public void get_hasPainter2D(){} // RVA: 0xF01170
        public void .ctor(){} // RVA: 0x343E80
        public void .cctor(){} // RVA: 0x7435EC0
    }

    public class MeshGenerationContextUtils
    {
        // ── Methods ──
        public void Rectangle(){} // RVA: 0x7432DC0
        public void Text(){} // RVA: 0x7432F20
        public void ConvertBorderRadiusPercentToPoints(){} // RVA: 0x7432FF0
        public void GetVisualElementRadii(){} // RVA: 0x7433050
        public void AdjustBackgroundSizeForBorders(){} // RVA: 0x7433300
    }

    public class MeshWriteData
    {
        public Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex> m_Vertices; // 0x10
        public Unity.Collections.NativeSlice`1<ushort> m_Indices; // 0x20
        public UnityEngine.Rect m_UVRegion; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_vertexCount(){} // RVA: 0x7432960
        public void get_indexCount(){} // RVA: 0x74329A0
        public void get_uvRegion(){} // RVA: 0x715F860
        public void SetNextVertex(){} // RVA: 0x74329E0
        public void SetNextIndex(){} // RVA: 0x7432A90
        public void SetAllVertices(){} // RVA: 0x7432B20
        public void SetAllIndices(){} // RVA: 0x7432BE0
        public void Reset(){} // RVA: 0x7432CD0 | overloaded x2
    }

    public class MeshWriteDataInterface
    {
    }

    public class MinMaxSlider
    {
        public UnityEngine.UIElements.VisualElement <dragElement>k__BackingField; // 0x440
        public UnityEngine.UIElements.VisualElement <dragMinThumb>k__BackingField; // 0x448
        public UnityEngine.UIElements.VisualElement <dragMaxThumb>k__BackingField; // 0x450
        public UnityEngine.UIElements.ClampedDragger`1<float> <clampedDragger>k__BackingField; // 0x458
        public UnityEngine.Vector2 m_DragElementStartPos; // 0x460
        public UnityEngine.Vector2 m_ValueStartPos; // 0x468
        public UnityEngine.Rect m_DragMinThumbRect; // 0x470
        public UnityEngine.Rect m_DragMaxThumbRect; // 0x480
        public 0x65832EC8 m_DragState; // 0x490

        // ── Methods ──
        public void get_dragElement(){} // RVA: 0xD8EF30
        public void set_dragElement(){} // RVA: 0xD95C40
        public void get_dragMinThumb(){} // RVA: 0xD9A100
        public void set_dragMinThumb(){} // RVA: 0xDA31D0
        public void get_dragMaxThumb(){} // RVA: 0xD961C0
        public void set_dragMaxThumb(){} // RVA: 0xD8C530
        public void get_clampedDragger(){} // RVA: 0xDA8310
        public void set_clampedDragger(){} // RVA: 0xD973F0
        public void get_minValue(){} // RVA: 0x73A83B0
        public void set_minValue(){} // RVA: 0x73A83E0
        public void get_maxValue(){} // RVA: 0x73A8460
        public void set_maxValue(){} // RVA: 0x73A8490
        public void get_value(){} // RVA: 0x73A8510
        public void set_value(){} // RVA: 0x73A8560
        public void SetValueWithoutNotify(){} // RVA: 0x73A85C0
        public void get_lowLimit(){} // RVA: 0x73A8630
        public void set_lowLimit(){} // RVA: 0x73A8640
        public void get_highLimit(){} // RVA: 0x73A8740
        public void set_highLimit(){} // RVA: 0x73A8750
        public void .ctor(){} // RVA: 0x73A8890 | overloaded x2
        public void ClampValues(){} // RVA: 0x73A9190
        public void UpdateDragElementPosition(){} // RVA: 0x73A9290 | overloaded x2
        public void SliderLerpUnclamped(){} // RVA: 0x73A9FC0
        public void SliderNormalizeValue(){} // RVA: 0x73A9FE0
        public void ComputeValueFromPosition(){} // RVA: 0x73AA000
        public void ExecuteDefaultAction(){} // RVA: 0x73AA120
        public void SetSliderValueFromDrag(){} // RVA: 0x73AA270
        public void SetSliderValueFromClick(){} // RVA: 0x73AA300
        public void ComputeValueDragStateNoThumb(){} // RVA: 0x73AA770
        public void ComputeValueFromDraggingThumb(){} // RVA: 0x73AA840
        public void UpdateMixedValueContent(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x73AAA60
    }

    public class MouseCaptureController
    {
        // ── Methods ──
        public void HasMouseCapture(){} // RVA: 0x740DE90
        public void CaptureMouse(){} // RVA: 0x740DF90
        public void ReleaseMouse(){} // RVA: 0x740E0C0
    }

    public class MouseCaptureDispatchingStrategy
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x73EE020
        public void DispatchEvent(){} // RVA: 0x73EE0A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MouseCaptureEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73E5C80
        public void .ctor(){} // RVA: 0x73E5D70
    }

    public class MouseCaptureEventBase`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x24A50
    }

    public class MouseCaptureEventBase`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x3C49AB0
        public void .ctor(){} // RVA: 0x3C49B50
    }

    public class MouseCaptureEventBase`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x3C49AB0
        public void .ctor(){} // RVA: 0x3C49B50
    }

    public class MouseCaptureOutEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73E5A20
        public void .ctor(){} // RVA: 0x73E5B10
    }

    public class MouseDownEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73EF370
        public void Init(){} // RVA: 0x73EF460
        public void LocalInit(){} // RVA: 0x73EF520
        public void .ctor(){} // RVA: 0x73EF530
        public void MakeFromPointerEvent(){} // RVA: 0x73EF580
        public void GetPooled(){} // RVA: 0x73EF6F0 | overloaded x2
    }

    public class MouseEnterEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F0980
        public void Init(){} // RVA: 0x73F0A70
        public void LocalInit(){} // RVA: 0x73F0B30
        public void .ctor(){} // RVA: 0x73F0B40
    }

    public class MouseEnterWindowEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F0FD0
        public void Init(){} // RVA: 0x73F10C0
        public void LocalInit(){} // RVA: 0x73F1180
        public void .ctor(){} // RVA: 0x73F1190
        public void PostDispatch(){} // RVA: 0x73F11E0
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField;
        public UnityEngine.Vector2 <mousePosition>k__BackingField;
        public UnityEngine.Vector2 <localMousePosition>k__BackingField;
        public UnityEngine.Vector2 <mouseDelta>k__BackingField;
        public int <clickCount>k__BackingField;
        public int <button>k__BackingField;
        public int <pressedButtons>k__BackingField;
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField;
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField;
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField;

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xD840
        public void set_modifiers(){} // RVA: 0x24FA0
        public void get_mousePosition(){} // RVA: 0xCD60
        public void set_mousePosition(){} // RVA: 0x33510
        public void get_localMousePosition(){} // RVA: 0xCD60
        public void set_localMousePosition(){} // RVA: 0x33510
        public void get_mouseDelta(){} // RVA: 0xCD60
        public void set_mouseDelta(){} // RVA: 0x33510
        public void get_clickCount(){} // RVA: 0xD840
        public void set_clickCount(){} // RVA: 0x24FA0
        public void get_button(){} // RVA: 0xD840
        public void set_button(){} // RVA: 0x24FA0
        public void get_pressedButtons(){} // RVA: 0xD840
        public void set_pressedButtons(){} // RVA: 0x24FA0
        public void get_shiftKey(){} // RVA: 0xDBE0
        public void get_ctrlKey(){} // RVA: 0xDBE0
        public void get_commandKey(){} // RVA: 0xDBE0
        public void get_altKey(){} // RVA: 0xDBE0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0xDBE0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x25130
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0xDBE0
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x25130
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0xCD60
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x24B10
        public void Init(){} // RVA: 0x24A50
        public void LocalInit(){} // RVA: 0x24A50
        public void get_currentTarget(){} // RVA: 0xCD60
        public void set_currentTarget(){} // RVA: 0x24B10
        public void PreDispatch(){} // RVA: 0x24B10
        public void PostDispatch(){} // RVA: 0x24B10
        public void GetPooled(){} // RVA: 0x283FA0 | overloaded x4
        public void .ctor(){} // RVA: 0x24A50
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x88
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x8C
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x94
        public UnityEngine.Vector2 <mouseDelta>k__BackingField; // 0x9C
        public int <clickCount>k__BackingField; // 0xA4
        public int <button>k__BackingField; // 0xA8
        public int <pressedButtons>k__BackingField; // 0xAC
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0xB0
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0xB1
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xBB90C0
        public void set_modifiers(){} // RVA: 0xBB9E60
        public void get_mousePosition(){} // RVA: 0x3C49B70
        public void set_mousePosition(){} // RVA: 0x3C49B90
        public void get_localMousePosition(){} // RVA: 0x3C49BA0
        public void set_localMousePosition(){} // RVA: 0x3C49BC0
        public void get_mouseDelta(){} // RVA: 0x3C49BD0
        public void set_mouseDelta(){} // RVA: 0x3C49BF0
        public void get_clickCount(){} // RVA: 0x3C49C00
        public void set_clickCount(){} // RVA: 0x3C49C10
        public void get_button(){} // RVA: 0xCC3CB0
        public void set_button(){} // RVA: 0xCC9310
        public void get_pressedButtons(){} // RVA: 0x3C49C20
        public void set_pressedButtons(){} // RVA: 0x3C49C30
        public void get_shiftKey(){} // RVA: 0x37CDA10
        public void get_ctrlKey(){} // RVA: 0x37CDA20
        public void get_commandKey(){} // RVA: 0x37CDA30
        public void get_altKey(){} // RVA: 0x37CDA40
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x17323D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1735610
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C40
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C50
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x3480B0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x3480C0
        public void Init(){} // RVA: 0x3C49C60
        public void LocalInit(){} // RVA: 0x3C49D00
        public void get_currentTarget(){} // RVA: 0x3C49E80
        public void set_currentTarget(){} // RVA: 0x3C49EA0
        public void PreDispatch(){} // RVA: 0x3C49FD0
        public void PostDispatch(){} // RVA: 0x3C4A130
        public void GetPooled(){} // RVA: 0x3C4ABC0 | overloaded x4
        public void .ctor(){} // RVA: 0x3C4AFE0
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x88
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x8C
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x94
        public UnityEngine.Vector2 <mouseDelta>k__BackingField; // 0x9C
        public int <clickCount>k__BackingField; // 0xA4
        public int <button>k__BackingField; // 0xA8
        public int <pressedButtons>k__BackingField; // 0xAC
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0xB0
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0xB1
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xBB90C0
        public void set_modifiers(){} // RVA: 0xBB9E60
        public void get_mousePosition(){} // RVA: 0x3C49B70
        public void set_mousePosition(){} // RVA: 0x3C49B90
        public void get_localMousePosition(){} // RVA: 0x3C49BA0
        public void set_localMousePosition(){} // RVA: 0x3C49BC0
        public void get_mouseDelta(){} // RVA: 0x3C49BD0
        public void set_mouseDelta(){} // RVA: 0x3C49BF0
        public void get_clickCount(){} // RVA: 0x3C49C00
        public void set_clickCount(){} // RVA: 0x3C49C10
        public void get_button(){} // RVA: 0xCC3CB0
        public void set_button(){} // RVA: 0xCC9310
        public void get_pressedButtons(){} // RVA: 0x3C49C20
        public void set_pressedButtons(){} // RVA: 0x3C49C30
        public void get_shiftKey(){} // RVA: 0x37CDA10
        public void get_ctrlKey(){} // RVA: 0x37CDA20
        public void get_commandKey(){} // RVA: 0x37CDA30
        public void get_altKey(){} // RVA: 0x37CDA40
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x17323D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1735610
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C40
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C50
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x3480B0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x3480C0
        public void Init(){} // RVA: 0x3C49C60
        public void LocalInit(){} // RVA: 0x3C49D00
        public void get_currentTarget(){} // RVA: 0x3C49E80
        public void set_currentTarget(){} // RVA: 0x3C49EA0
        public void PreDispatch(){} // RVA: 0x3C49FD0
        public void PostDispatch(){} // RVA: 0x3C4A130
        public void GetPooled(){} // RVA: 0x3C4ABC0 | overloaded x4
        public void .ctor(){} // RVA: 0x3C4AFE0
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x88
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x8C
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x94
        public UnityEngine.Vector2 <mouseDelta>k__BackingField; // 0x9C
        public int <clickCount>k__BackingField; // 0xA4
        public int <button>k__BackingField; // 0xA8
        public int <pressedButtons>k__BackingField; // 0xAC
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0xB0
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0xB1
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xBB90C0
        public void set_modifiers(){} // RVA: 0xBB9E60
        public void get_mousePosition(){} // RVA: 0x3C49B70
        public void set_mousePosition(){} // RVA: 0x3C49B90
        public void get_localMousePosition(){} // RVA: 0x3C49BA0
        public void set_localMousePosition(){} // RVA: 0x3C49BC0
        public void get_mouseDelta(){} // RVA: 0x3C49BD0
        public void set_mouseDelta(){} // RVA: 0x3C49BF0
        public void get_clickCount(){} // RVA: 0x3C49C00
        public void set_clickCount(){} // RVA: 0x3C49C10
        public void get_button(){} // RVA: 0xCC3CB0
        public void set_button(){} // RVA: 0xCC9310
        public void get_pressedButtons(){} // RVA: 0x3C49C20
        public void set_pressedButtons(){} // RVA: 0x3C49C30
        public void get_shiftKey(){} // RVA: 0x37CDA10
        public void get_ctrlKey(){} // RVA: 0x37CDA20
        public void get_commandKey(){} // RVA: 0x37CDA30
        public void get_altKey(){} // RVA: 0x37CDA40
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x17323D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1735610
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C40
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C50
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x3480B0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x3480C0
        public void Init(){} // RVA: 0x3C49C60
        public void LocalInit(){} // RVA: 0x3C49D00
        public void get_currentTarget(){} // RVA: 0x3C49E80
        public void set_currentTarget(){} // RVA: 0x3C49EA0
        public void PreDispatch(){} // RVA: 0x3C49FD0
        public void PostDispatch(){} // RVA: 0x3C4A130
        public void GetPooled(){} // RVA: 0x3C4ABC0 | overloaded x4
        public void .ctor(){} // RVA: 0x3C4AFE0
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x88
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x8C
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x94
        public UnityEngine.Vector2 <mouseDelta>k__BackingField; // 0x9C
        public int <clickCount>k__BackingField; // 0xA4
        public int <button>k__BackingField; // 0xA8
        public int <pressedButtons>k__BackingField; // 0xAC
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0xB0
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0xB1
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xBB90C0
        public void set_modifiers(){} // RVA: 0xBB9E60
        public void get_mousePosition(){} // RVA: 0x3C49B70
        public void set_mousePosition(){} // RVA: 0x3C49B90
        public void get_localMousePosition(){} // RVA: 0x3C49BA0
        public void set_localMousePosition(){} // RVA: 0x3C49BC0
        public void get_mouseDelta(){} // RVA: 0x3C49BD0
        public void set_mouseDelta(){} // RVA: 0x3C49BF0
        public void get_clickCount(){} // RVA: 0x3C49C00
        public void set_clickCount(){} // RVA: 0x3C49C10
        public void get_button(){} // RVA: 0xCC3CB0
        public void set_button(){} // RVA: 0xCC9310
        public void get_pressedButtons(){} // RVA: 0x3C49C20
        public void set_pressedButtons(){} // RVA: 0x3C49C30
        public void get_shiftKey(){} // RVA: 0x37CDA10
        public void get_ctrlKey(){} // RVA: 0x37CDA20
        public void get_commandKey(){} // RVA: 0x37CDA30
        public void get_altKey(){} // RVA: 0x37CDA40
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x17323D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1735610
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C40
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C50
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x3480B0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x3480C0
        public void Init(){} // RVA: 0x3C49C60
        public void LocalInit(){} // RVA: 0x3C49D00
        public void get_currentTarget(){} // RVA: 0x3C49E80
        public void set_currentTarget(){} // RVA: 0x3C49EA0
        public void PreDispatch(){} // RVA: 0x3C49FD0
        public void PostDispatch(){} // RVA: 0x3C4A130
        public void GetPooled(){} // RVA: 0x3C4ABC0 | overloaded x4
        public void .ctor(){} // RVA: 0x3C4AFE0
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x88
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x8C
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x94
        public UnityEngine.Vector2 <mouseDelta>k__BackingField; // 0x9C
        public int <clickCount>k__BackingField; // 0xA4
        public int <button>k__BackingField; // 0xA8
        public int <pressedButtons>k__BackingField; // 0xAC
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0xB0
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0xB1
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xBB90C0
        public void set_modifiers(){} // RVA: 0xBB9E60
        public void get_mousePosition(){} // RVA: 0x3C49B70
        public void set_mousePosition(){} // RVA: 0x3C49B90
        public void get_localMousePosition(){} // RVA: 0x3C49BA0
        public void set_localMousePosition(){} // RVA: 0x3C49BC0
        public void get_mouseDelta(){} // RVA: 0x3C49BD0
        public void set_mouseDelta(){} // RVA: 0x3C49BF0
        public void get_clickCount(){} // RVA: 0x3C49C00
        public void set_clickCount(){} // RVA: 0x3C49C10
        public void get_button(){} // RVA: 0xCC3CB0
        public void set_button(){} // RVA: 0xCC9310
        public void get_pressedButtons(){} // RVA: 0x3C49C20
        public void set_pressedButtons(){} // RVA: 0x3C49C30
        public void get_shiftKey(){} // RVA: 0x37CDA10
        public void get_ctrlKey(){} // RVA: 0x37CDA20
        public void get_commandKey(){} // RVA: 0x37CDA30
        public void get_altKey(){} // RVA: 0x37CDA40
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x17323D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1735610
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C40
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C50
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x3480B0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x3480C0
        public void Init(){} // RVA: 0x3C49C60
        public void LocalInit(){} // RVA: 0x3C49D00
        public void get_currentTarget(){} // RVA: 0x3C49E80
        public void set_currentTarget(){} // RVA: 0x3C49EA0
        public void PreDispatch(){} // RVA: 0x3C49FD0
        public void PostDispatch(){} // RVA: 0x3C4A130
        public void GetPooled(){} // RVA: 0x3C4ABC0 | overloaded x4
        public void .ctor(){} // RVA: 0x3C4AFE0
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x88
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x8C
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x94
        public UnityEngine.Vector2 <mouseDelta>k__BackingField; // 0x9C
        public int <clickCount>k__BackingField; // 0xA4
        public int <button>k__BackingField; // 0xA8
        public int <pressedButtons>k__BackingField; // 0xAC
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0xB0
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0xB1
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xBB90C0
        public void set_modifiers(){} // RVA: 0xBB9E60
        public void get_mousePosition(){} // RVA: 0x3C49B70
        public void set_mousePosition(){} // RVA: 0x3C49B90
        public void get_localMousePosition(){} // RVA: 0x3C49BA0
        public void set_localMousePosition(){} // RVA: 0x3C49BC0
        public void get_mouseDelta(){} // RVA: 0x3C49BD0
        public void set_mouseDelta(){} // RVA: 0x3C49BF0
        public void get_clickCount(){} // RVA: 0x3C49C00
        public void set_clickCount(){} // RVA: 0x3C49C10
        public void get_button(){} // RVA: 0xCC3CB0
        public void set_button(){} // RVA: 0xCC9310
        public void get_pressedButtons(){} // RVA: 0x3C49C20
        public void set_pressedButtons(){} // RVA: 0x3C49C30
        public void get_shiftKey(){} // RVA: 0x37CDA10
        public void get_ctrlKey(){} // RVA: 0x37CDA20
        public void get_commandKey(){} // RVA: 0x37CDA30
        public void get_altKey(){} // RVA: 0x37CDA40
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x17323D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1735610
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C40
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C50
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x3480B0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x3480C0
        public void Init(){} // RVA: 0x3C49C60
        public void LocalInit(){} // RVA: 0x3C49D00
        public void get_currentTarget(){} // RVA: 0x3C49E80
        public void set_currentTarget(){} // RVA: 0x3C49EA0
        public void PreDispatch(){} // RVA: 0x3C49FD0
        public void PostDispatch(){} // RVA: 0x3C4A130
        public void GetPooled(){} // RVA: 0x3C4ABC0 | overloaded x4
        public void .ctor(){} // RVA: 0x3C4AFE0
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x88
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x8C
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x94
        public UnityEngine.Vector2 <mouseDelta>k__BackingField; // 0x9C
        public int <clickCount>k__BackingField; // 0xA4
        public int <button>k__BackingField; // 0xA8
        public int <pressedButtons>k__BackingField; // 0xAC
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0xB0
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0xB1
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xBB90C0
        public void set_modifiers(){} // RVA: 0xBB9E60
        public void get_mousePosition(){} // RVA: 0x3C49B70
        public void set_mousePosition(){} // RVA: 0x3C49B90
        public void get_localMousePosition(){} // RVA: 0x3C49BA0
        public void set_localMousePosition(){} // RVA: 0x3C49BC0
        public void get_mouseDelta(){} // RVA: 0x3C49BD0
        public void set_mouseDelta(){} // RVA: 0x3C49BF0
        public void get_clickCount(){} // RVA: 0x3C49C00
        public void set_clickCount(){} // RVA: 0x3C49C10
        public void get_button(){} // RVA: 0xCC3CB0
        public void set_button(){} // RVA: 0xCC9310
        public void get_pressedButtons(){} // RVA: 0x3C49C20
        public void set_pressedButtons(){} // RVA: 0x3C49C30
        public void get_shiftKey(){} // RVA: 0x37CDA10
        public void get_ctrlKey(){} // RVA: 0x37CDA20
        public void get_commandKey(){} // RVA: 0x37CDA30
        public void get_altKey(){} // RVA: 0x37CDA40
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x17323D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1735610
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C40
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C50
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x3480B0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x3480C0
        public void Init(){} // RVA: 0x3C49C60
        public void LocalInit(){} // RVA: 0x3C49D00
        public void get_currentTarget(){} // RVA: 0x3C49E80
        public void set_currentTarget(){} // RVA: 0x3C49EA0
        public void PreDispatch(){} // RVA: 0x3C49FD0
        public void PostDispatch(){} // RVA: 0x3C4A130
        public void GetPooled(){} // RVA: 0x3C4ABC0 | overloaded x4
        public void .ctor(){} // RVA: 0x3C4AFE0
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x88
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x8C
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x94
        public UnityEngine.Vector2 <mouseDelta>k__BackingField; // 0x9C
        public int <clickCount>k__BackingField; // 0xA4
        public int <button>k__BackingField; // 0xA8
        public int <pressedButtons>k__BackingField; // 0xAC
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0xB0
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0xB1
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xBB90C0
        public void set_modifiers(){} // RVA: 0xBB9E60
        public void get_mousePosition(){} // RVA: 0x3C49B70
        public void set_mousePosition(){} // RVA: 0x3C49B90
        public void get_localMousePosition(){} // RVA: 0x3C49BA0
        public void set_localMousePosition(){} // RVA: 0x3C49BC0
        public void get_mouseDelta(){} // RVA: 0x3C49BD0
        public void set_mouseDelta(){} // RVA: 0x3C49BF0
        public void get_clickCount(){} // RVA: 0x3C49C00
        public void set_clickCount(){} // RVA: 0x3C49C10
        public void get_button(){} // RVA: 0xCC3CB0
        public void set_button(){} // RVA: 0xCC9310
        public void get_pressedButtons(){} // RVA: 0x3C49C20
        public void set_pressedButtons(){} // RVA: 0x3C49C30
        public void get_shiftKey(){} // RVA: 0x37CDA10
        public void get_ctrlKey(){} // RVA: 0x37CDA20
        public void get_commandKey(){} // RVA: 0x37CDA30
        public void get_altKey(){} // RVA: 0x37CDA40
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x17323D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1735610
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C40
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C50
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x3480B0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x3480C0
        public void Init(){} // RVA: 0x3C49C60
        public void LocalInit(){} // RVA: 0x3C49D00
        public void get_currentTarget(){} // RVA: 0x3C49E80
        public void set_currentTarget(){} // RVA: 0x3C49EA0
        public void PreDispatch(){} // RVA: 0x3C49FD0
        public void PostDispatch(){} // RVA: 0x3C4A130
        public void GetPooled(){} // RVA: 0x3C4ABC0 | overloaded x4
        public void .ctor(){} // RVA: 0x3C4AFE0
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x88
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x8C
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x94
        public UnityEngine.Vector2 <mouseDelta>k__BackingField; // 0x9C
        public int <clickCount>k__BackingField; // 0xA4
        public int <button>k__BackingField; // 0xA8
        public int <pressedButtons>k__BackingField; // 0xAC
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0xB0
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0xB1
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xBB90C0
        public void set_modifiers(){} // RVA: 0xBB9E60
        public void get_mousePosition(){} // RVA: 0x3C49B70
        public void set_mousePosition(){} // RVA: 0x3C49B90
        public void get_localMousePosition(){} // RVA: 0x3C49BA0
        public void set_localMousePosition(){} // RVA: 0x3C49BC0
        public void get_mouseDelta(){} // RVA: 0x3C49BD0
        public void set_mouseDelta(){} // RVA: 0x3C49BF0
        public void get_clickCount(){} // RVA: 0x3C49C00
        public void set_clickCount(){} // RVA: 0x3C49C10
        public void get_button(){} // RVA: 0xCC3CB0
        public void set_button(){} // RVA: 0xCC9310
        public void get_pressedButtons(){} // RVA: 0x3C49C20
        public void set_pressedButtons(){} // RVA: 0x3C49C30
        public void get_shiftKey(){} // RVA: 0x37CDA10
        public void get_ctrlKey(){} // RVA: 0x37CDA20
        public void get_commandKey(){} // RVA: 0x37CDA30
        public void get_altKey(){} // RVA: 0x37CDA40
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x17323D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1735610
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C40
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C50
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x3480B0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x3480C0
        public void Init(){} // RVA: 0x3C49C60
        public void LocalInit(){} // RVA: 0x3C49D00
        public void get_currentTarget(){} // RVA: 0x3C49E80
        public void set_currentTarget(){} // RVA: 0x3C49EA0
        public void PreDispatch(){} // RVA: 0x3C49FD0
        public void PostDispatch(){} // RVA: 0x3C4A130
        public void GetPooled(){} // RVA: 0x3C4ABC0 | overloaded x4
        public void .ctor(){} // RVA: 0x3C4AFE0
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x88
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x8C
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x94
        public UnityEngine.Vector2 <mouseDelta>k__BackingField; // 0x9C
        public int <clickCount>k__BackingField; // 0xA4
        public int <button>k__BackingField; // 0xA8
        public int <pressedButtons>k__BackingField; // 0xAC
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0xB0
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0xB1
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xBB90C0
        public void set_modifiers(){} // RVA: 0xBB9E60
        public void get_mousePosition(){} // RVA: 0x3C49B70
        public void set_mousePosition(){} // RVA: 0x3C49B90
        public void get_localMousePosition(){} // RVA: 0x3C49BA0
        public void set_localMousePosition(){} // RVA: 0x3C49BC0
        public void get_mouseDelta(){} // RVA: 0x3C49BD0
        public void set_mouseDelta(){} // RVA: 0x3C49BF0
        public void get_clickCount(){} // RVA: 0x3C49C00
        public void set_clickCount(){} // RVA: 0x3C49C10
        public void get_button(){} // RVA: 0xCC3CB0
        public void set_button(){} // RVA: 0xCC9310
        public void get_pressedButtons(){} // RVA: 0x3C49C20
        public void set_pressedButtons(){} // RVA: 0x3C49C30
        public void get_shiftKey(){} // RVA: 0x37CDA10
        public void get_ctrlKey(){} // RVA: 0x37CDA20
        public void get_commandKey(){} // RVA: 0x37CDA30
        public void get_altKey(){} // RVA: 0x37CDA40
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x17323D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1735610
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C40
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C50
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x3480B0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x3480C0
        public void Init(){} // RVA: 0x3C49C60
        public void LocalInit(){} // RVA: 0x3C49D00
        public void get_currentTarget(){} // RVA: 0x3C49E80
        public void set_currentTarget(){} // RVA: 0x3C49EA0
        public void PreDispatch(){} // RVA: 0x3C49FD0
        public void PostDispatch(){} // RVA: 0x3C4A130
        public void GetPooled(){} // RVA: 0x3C4ABC0 | overloaded x4
        public void .ctor(){} // RVA: 0x3C4AFE0
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x88
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x8C
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x94
        public UnityEngine.Vector2 <mouseDelta>k__BackingField; // 0x9C
        public int <clickCount>k__BackingField; // 0xA4
        public int <button>k__BackingField; // 0xA8
        public int <pressedButtons>k__BackingField; // 0xAC
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0xB0
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0xB1
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xBB90C0
        public void set_modifiers(){} // RVA: 0xBB9E60
        public void get_mousePosition(){} // RVA: 0x3C49B70
        public void set_mousePosition(){} // RVA: 0x3C49B90
        public void get_localMousePosition(){} // RVA: 0x3C49BA0
        public void set_localMousePosition(){} // RVA: 0x3C49BC0
        public void get_mouseDelta(){} // RVA: 0x3C49BD0
        public void set_mouseDelta(){} // RVA: 0x3C49BF0
        public void get_clickCount(){} // RVA: 0x3C49C00
        public void set_clickCount(){} // RVA: 0x3C49C10
        public void get_button(){} // RVA: 0xCC3CB0
        public void set_button(){} // RVA: 0xCC9310
        public void get_pressedButtons(){} // RVA: 0x3C49C20
        public void set_pressedButtons(){} // RVA: 0x3C49C30
        public void get_shiftKey(){} // RVA: 0x37CDA10
        public void get_ctrlKey(){} // RVA: 0x37CDA20
        public void get_commandKey(){} // RVA: 0x37CDA30
        public void get_altKey(){} // RVA: 0x37CDA40
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x17323D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1735610
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C40
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C50
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x3480B0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x3480C0
        public void Init(){} // RVA: 0x3C49C60
        public void LocalInit(){} // RVA: 0x3C49D00
        public void get_currentTarget(){} // RVA: 0x3C49E80
        public void set_currentTarget(){} // RVA: 0x3C49EA0
        public void PreDispatch(){} // RVA: 0x3C49FD0
        public void PostDispatch(){} // RVA: 0x3C4A130
        public void GetPooled(){} // RVA: 0x3C4ABC0 | overloaded x4
        public void .ctor(){} // RVA: 0x3C4AFE0
    }

    public class MouseEventBase`1
    {
        public 0x659A0EE8 <modifiers>k__BackingField; // 0x88
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x8C
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x94
        public UnityEngine.Vector2 <mouseDelta>k__BackingField; // 0x9C
        public int <clickCount>k__BackingField; // 0xA4
        public int <button>k__BackingField; // 0xA8
        public int <pressedButtons>k__BackingField; // 0xAC
        public bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0xB0
        public bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0xB1
        public UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xBB90C0
        public void set_modifiers(){} // RVA: 0xBB9E60
        public void get_mousePosition(){} // RVA: 0x3C49B70
        public void set_mousePosition(){} // RVA: 0x3C49B90
        public void get_localMousePosition(){} // RVA: 0x3C49BA0
        public void set_localMousePosition(){} // RVA: 0x3C49BC0
        public void get_mouseDelta(){} // RVA: 0x3C49BD0
        public void set_mouseDelta(){} // RVA: 0x3C49BF0
        public void get_clickCount(){} // RVA: 0x3C49C00
        public void set_clickCount(){} // RVA: 0x3C49C10
        public void get_button(){} // RVA: 0xCC3CB0
        public void set_button(){} // RVA: 0xCC9310
        public void get_pressedButtons(){} // RVA: 0x3C49C20
        public void set_pressedButtons(){} // RVA: 0x3C49C30
        public void get_shiftKey(){} // RVA: 0x37CDA10
        public void get_ctrlKey(){} // RVA: 0x37CDA20
        public void get_commandKey(){} // RVA: 0x37CDA30
        public void get_altKey(){} // RVA: 0x37CDA40
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x17323D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1735610
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C40
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x3C49C50
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x3480B0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x3480C0
        public void Init(){} // RVA: 0x3C49C60
        public void LocalInit(){} // RVA: 0x3C49D00
        public void get_currentTarget(){} // RVA: 0x3C49E80
        public void set_currentTarget(){} // RVA: 0x3C49EA0
        public void PreDispatch(){} // RVA: 0x3C49FD0
        public void PostDispatch(){} // RVA: 0x3C4A130
        public void GetPooled(){} // RVA: 0x3C4ABC0 | overloaded x4
        public void .ctor(){} // RVA: 0x3C4AFE0
    }

    public class MouseEventDispatchingStrategy
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x73EE7D0
        public void DispatchEvent(){} // RVA: 0x73EE820
        public void SendEventToTarget(){} // RVA: 0x73EEA90
        public void SendEventToRegularTarget(){} // RVA: 0x73EEBD0
        public void SendEventToIMGUIContainer(){} // RVA: 0x73EECF0
        public void SetBestTargetForEvent(){} // RVA: 0x73EEF00
        public void UpdateElementUnderMouse(){} // RVA: 0x73EEFB0
        public void IsDone(){} // RVA: 0x73EF2E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MouseEventsHelper
    {
        // ── Methods ──
        public void SendEnterLeave(){} // RVA: 0x283FA0
        public void SendMouseOverMouseOut(){} // RVA: 0x73F29A0
    }

    public class MouseLeaveEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F0CB0
        public void Init(){} // RVA: 0x73F0DA0
        public void LocalInit(){} // RVA: 0x73F0B30
        public void .ctor(){} // RVA: 0x73F0E60
    }

    public class MouseLeaveWindowEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F1410
        public void Init(){} // RVA: 0x73F1500
        public void LocalInit(){} // RVA: 0x73F1600
        public void .ctor(){} // RVA: 0x73F1650
        public void GetPooled(){} // RVA: 0x73F16D0
        public void PostDispatch(){} // RVA: 0x73F17F0
    }

    public class MouseManipulator
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.ManipulatorActivationFilter> <activators>k__BackingField; // 0x18

        // ── Methods ──
        public void get_activators(){} // RVA: 0x2E07C0
        public void set_activators(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x740E230
        public void CanStartManipulation(){} // RVA: 0x740E2F0
        public void CanStopManipulation(){} // RVA: 0x740E510
    }

    public class MouseMoveEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73EFD90
        public void Init(){} // RVA: 0x73EFE80
        public void LocalInit(){} // RVA: 0x73EFF40
        public void .ctor(){} // RVA: 0x73EFF50
        public void GetPooled(){} // RVA: 0x73EFFA0
    }

    public class MouseOutEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F1C90
        public void .ctor(){} // RVA: 0x73F1D80
    }

    public class MouseOverEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73F1A50
        public void .ctor(){} // RVA: 0x73F1B40
    }

    public class MouseUpEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73EF860
        public void Init(){} // RVA: 0x73EF950
        public void LocalInit(){} // RVA: 0x73EF520
        public void .ctor(){} // RVA: 0x73EFA10
        public void MakeFromPointerEvent(){} // RVA: 0x73EFA60
        public void GetPooled(){} // RVA: 0x73EFC20 | overloaded x3
    }

    public class MultiColumnController
    {
        public UnityEngine.PropertyName k_BoundColumnVePropertyName;

        // ── Methods ──
        public void add_columnSortingChanged(){} // RVA: 0x73B2530
        public void remove_columnSortingChanged(){} // RVA: 0x73B2620
        public void add_headerContextMenuPopulateEvent(){} // RVA: 0x73B2710
        public void remove_headerContextMenuPopulateEvent(){} // RVA: 0x73B2810
        public void get_header(){} // RVA: 0x6374D0
        public void .ctor(){} // RVA: 0x73B2910
        public void BindCellItem(){} // RVA: 0x283FA0
        public void UnbindCellItem(){} // RVA: 0x73B31C0
        public void DefaultMakeCellItem(){} // RVA: 0x73B3200
        public void DefaultBindCellItem(){} // RVA: 0x283FA0
        public void MakeItem(){} // RVA: 0x73B32D0
        public void BindItem(){} // RVA: 0x283FA0
        public void UnbindItem(){} // RVA: 0x73B3660
        public void DestroyItem(){} // RVA: 0x73B39F0
        public void PrepareView(){} // RVA: 0x73B3DA0
        public void Dispose(){} // RVA: 0x73B41A0
        public void OnHorizontalScrollerValueChanged(){} // RVA: 0x73B4D50
        public void OnViewportGeometryChanged(){} // RVA: 0x73B4E90
        public void OnColumnContainerGeometryChanged(){} // RVA: 0x73B5120
        public void UpdateContentContainer(){} // RVA: 0x73B5130
        public void OnColumnSortingChanged(){} // RVA: 0x6242C0
        public void OnContextMenuPopulateEvent(){} // RVA: 0x4EC5180
        public void OnColumnResized(){} // RVA: 0x73B52E0
        public void OnColumnAdded(){} // RVA: 0x73B5680
        public void OnColumnRemoved(){} // RVA: 0x73B5680
        public void OnColumnReordered(){} // RVA: 0x73B56A0
        public void OnColumnsChanged(){} // RVA: 0x73B56E0
        public void OnColumnChanged(){} // RVA: 0x73B5720
        public void OnViewDataRestored(){} // RVA: 0x73B5680
        public void .cctor(){} // RVA: 0x73B5760
    }

    public class MultiColumnListView
    {
        public UnityEngine.UIElements.Columns m_Columns; // 0x540
        public bool m_SortingEnabled; // 0x548
        public UnityEngine.UIElements.SortColumnDescriptions m_SortColumnDescriptions; // 0x550
        public System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription> m_SortedColumns; // 0x558

        // ── Methods ──
        public void get_viewController(){} // RVA: 0x73B5CA0
        public void get_columns(){} // RVA: 0xDA11E0
        public void set_columns(){} // RVA: 0x73B5D30
        public void get_sortColumnDescriptions(){} // RVA: 0xDB1280
        public void set_sortColumnDescriptions(){} // RVA: 0x73B5E20
        public void set_sortingEnabled(){} // RVA: 0x73B5F20
        public void .ctor(){} // RVA: 0x73B6000 | overloaded x2
        public void CreateViewController(){} // RVA: 0x73B6210
        public void SetViewController(){} // RVA: 0x73B6320
        public void CreateVirtualizationController(){} // RVA: 0x73B6570
        public void RaiseColumnSortingChanged(){} // RVA: 0x73B65B0
        public void RaiseHeaderContextMenuPopulate(){} // RVA: 0x73B65D0
    }

    public class MultiColumnListViewController
    {
        public UnityEngine.UIElements.MultiColumnController m_ColumnController; // 0x48

        // ── Methods ──
        public void get_columnController(){} // RVA: 0x358730
        public void get_header(){} // RVA: 0x72F3110
        public void .ctor(){} // RVA: 0x72F3120
        public void InvokeMakeItem(){} // RVA: 0x72F31F0
        public void MakeItem(){} // RVA: 0x72F3330
        public void BindItem(){} // RVA: 0x72F3350
        public void UnbindItem(){} // RVA: 0x72F33F0
        public void DestroyItem(){} // RVA: 0x72F3410
        public void PrepareView(){} // RVA: 0x72F3430
        public void Dispose(){} // RVA: 0x72F35C0
        public void UpdateReorderClassList(){} // RVA: 0x72F37B0
    }

    public class MultiColumnTreeView
    {
        public UnityEngine.UIElements.Columns m_Columns; // 0x4C0
        public bool m_SortingEnabled; // 0x4C8
        public UnityEngine.UIElements.SortColumnDescriptions m_SortColumnDescriptions; // 0x4D0
        public System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription> m_SortedColumns; // 0x4D8

        // ── Methods ──
        public void get_viewController(){} // RVA: 0x73B6B70
        public void get_columns(){} // RVA: 0xD95090
        public void set_columns(){} // RVA: 0x73B6C00
        public void get_sortColumnDescriptions(){} // RVA: 0xD99BE0
        public void set_sortColumnDescriptions(){} // RVA: 0x73B6CF0
        public void set_sortingEnabled(){} // RVA: 0x73B6DF0
        public void .ctor(){} // RVA: 0x73B6ED0 | overloaded x2
        public void CreateViewController(){} // RVA: 0x73B70E0
        public void SetViewController(){} // RVA: 0x73B7180
        public void CreateVirtualizationController(){} // RVA: 0x73B74B0
        public void RaiseColumnSortingChanged(){} // RVA: 0x73B74F0
        public void RaiseHeaderContextMenuPopulate(){} // RVA: 0x73B7510
    }

    public class MultiColumnTreeViewController
    {
        public UnityEngine.UIElements.MultiColumnController m_ColumnController; // 0x58

        // ── Methods ──
        public void get_columnController(){} // RVA: 0x3A5500
        public void get_header(){} // RVA: 0x72F38A0
        public void .ctor(){} // RVA: 0x72F38B0
        public void InvokeMakeItem(){} // RVA: 0x72F39B0
        public void MakeItem(){} // RVA: 0x72F3B40
        public void BindItem(){} // RVA: 0x72F3B60
        public void UnbindItem(){} // RVA: 0x72F3C00
        public void DestroyItem(){} // RVA: 0x72F3C20
        public void PrepareView(){} // RVA: 0x72F3C40
        public void Dispose(){} // RVA: 0x72F3C70
    }

}