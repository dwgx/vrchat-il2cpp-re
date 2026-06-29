// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 45
// Methods: 645

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class ManagedJobExtension : Object
    {
        // ── Methods ──
        public void ScheduleOrRunJob(){} // RVA: 0xA94080
    }

    public class Manipulator : Object
    {
        // ── Methods ──
        public void RegisterCallbacksOnTarget(){} // RVA: 0x894290
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x894290
        public void get_target(){} // RVA: 0x3E42230
        public void set_target(){} // RVA: 0x8083680
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ManipulatorActivationFilter : ValueType
    {
        // ── Methods ──
        public void get_button(){} // RVA: 0x77E60
        public void set_button(){} // RVA: 0x29580
        public void get_modifiers(){} // RVA: 0x77E50
        public void set_modifiers(){} // RVA: 0x77EE0
        public void get_clickCount(){} // RVA: 0x14790
        public void Equals(){} // RVA: 0x9A5FB0
        public void GetHashCode(){} // RVA: 0x9A5FF0
        public void Matches(){} // RVA: 0x9A6010
        public void HasModifiers(){} // RVA: 0x9A6020
        public void MatchModifiers(){} // RVA: 0x9A6030
    }

    public class MeshBuilderNative : Object
    {
        // ── Methods ──
        public void MakeBorder(){} // RVA: 0x8083E40
        public void MakeSolidRect(){} // RVA: 0x8083EC0
        public void MakeTexturedRect(){} // RVA: 0x8083F40
        public void MakeVectorGraphicsStretchBackground(){} // RVA: 0x8083FC0
        public void MakeVectorGraphics9SliceBackground(){} // RVA: 0x80841A0
        public void MakeBorder_Injected(){} // RVA: 0x8084370
        public void MakeSolidRect_Injected(){} // RVA: 0x80843E0
        public void MakeTexturedRect_Injected(){} // RVA: 0x8084450
        public void MakeVectorGraphicsStretchBackground_Injected(){} // RVA: 0x80844C0
        public void MakeVectorGraphics9SliceBackground_Injected(){} // RVA: 0x8084550
    }

    public class MeshGenerationContext : Object
    {
        // ── Methods ──
        public void get_visualElement(){} // RVA: 0xB5DBF0
        public void set_visualElement(){} // RVA: 0xB44D60
        public void get_painter2D(){} // RVA: 0x80A89A0
        public void get_hasPainter2D(){} // RVA: 0x25E9250
        public void get_meshGenerator(){} // RVA: 0xBC1B30
        public void set_meshGenerator(){} // RVA: 0xB6A8C0
        public void get_entryRecorder(){} // RVA: 0xBBF8F0
        public void set_entryRecorder(){} // RVA: 0xBBF900
        public void get_parentEntry(){} // RVA: 0xBE58B0
        public void set_parentEntry(){} // RVA: 0xCA4DF0
        public void .ctor(){} // RVA: 0x80A8AB0
        public void GetTempMeshAllocator(){} // RVA: 0x80A8D20
        public void InsertMeshGenerationNode(){} // RVA: 0x80A8D40
        public void InsertUnsafeMeshGenerationNode(){} // RVA: 0x80A8DD0
        public void AddMeshGenerationJob(){} // RVA: 0x80A8E60
        public void AddMeshGenerationCallback(){} // RVA: 0x80A8ED0
        public void Begin(){} // RVA: 0x80A8F00
        public void End(){} // RVA: 0x80A90D0
        public void get_disposed(){} // RVA: 0xE3F480
        public void set_disposed(){} // RVA: 0x1546550
        public void Dispose(){} // RVA: 0x80A92A0
        public void .cctor(){} // RVA: 0x80A97F0
    }

    public class MeshGenerationNode : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x80A98A0
        public void GetParentEntry(){} // RVA: 0x9A9CA0
    }

    public class MeshGenerationNodeImpl : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x80A9BF0
        public void Init(){} // RVA: 0x80A9C30
        public void Reset(){} // RVA: 0x80A9D70
        public void GetNode(){} // RVA: 0x7F76420
        public void GetUnsafeNode(){} // RVA: 0x7F76420
        public void GetParentEntry(){} // RVA: 0xB465B0
        public void DrawMesh(){} // RVA: 0x80A9E90
        public void DrawGradients(){} // RVA: 0x80A9FC0
        public void get_disposed(){} // RVA: 0xF73960
        public void set_disposed(){} // RVA: 0xF73A60
        public void Dispose(){} // RVA: 0x80AA210
    }

    public class MeshGenerationNodeManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x80AA250
        public void CreateNode(){} // RVA: 0x80AA3F0
        public void CreateUnsafeNode(){} // RVA: 0x80AA420
        public void CreateImpl(){} // RVA: 0x80AA450
        public void ResetAll(){} // RVA: 0x80AA720
        public void get_disposed(){} // RVA: 0xF73960
        public void set_disposed(){} // RVA: 0xF73A60
        public void Dispose(){} // RVA: 0x80AA830
    }

    public class MeshWriteData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MinMaxSlider : BaseField`1
    {
        // ── Methods ──
        public void get_dragElement(){} // RVA: 0x166DF20
        public void set_dragElement(){} // RVA: 0x1649450
        public void get_dragMinThumb(){} // RVA: 0x16495F0
        public void set_dragMinThumb(){} // RVA: 0x163CED0
        public void get_dragMaxThumb(){} // RVA: 0x1667A50
        public void set_dragMaxThumb(){} // RVA: 0x163E380
        public void get_clampedDragger(){} // RVA: 0x165B7D0
        public void set_clampedDragger(){} // RVA: 0x163A4F0
        public void get_minValue(){} // RVA: 0x7FF5DF0
        public void set_minValue(){} // RVA: 0x7FF5E20
        public void get_maxValue(){} // RVA: 0x7FF5F30
        public void set_maxValue(){} // RVA: 0x7FF5F60
        public void get_value(){} // RVA: 0x7FF6070
        public void set_value(){} // RVA: 0x7FF60C0
        public void SetValueWithoutNotify(){} // RVA: 0x7FF6120
        public void get_range(){} // RVA: 0x7FF6190
        public void get_lowLimit(){} // RVA: 0x7FF6210
        public void set_lowLimit(){} // RVA: 0x7FF6220
        public void get_highLimit(){} // RVA: 0x623B9F0
        public void set_highLimit(){} // RVA: 0x7FF6370
        public void .ctor(){} // RVA: 0x7FF6510
        public void ClampValues(){} // RVA: 0x7FF70C0
        public void UpdateDragElementPosition(){} // RVA: 0x7FF71B0
        public void SliderLerpUnclamped(){} // RVA: 0x7FF7990
        public void SliderNormalizeValue(){} // RVA: 0x7FF79B0
        public void ComputeValueFromPosition(){} // RVA: 0x7FF79D0
        public void HandleEventBubbleUp(){} // RVA: 0x7FF7A60
        public void GetNavigationState(){} // RVA: 0x7FF7C80
        public void SetNavigationState(){} // RVA: 0x7FF7D60
        public void OnFocusIn(){} // RVA: 0x7FF7ED0
        public void OnBlur(){} // RVA: 0x7FF7F00
        public void OnNavigationSubmit(){} // RVA: 0x7FF8010
        public void OnNavigationMove(){} // RVA: 0x7FF8040
        public void ComputeValueFromKey(){} // RVA: 0x7FF8100
        public void SetSliderValueFromDrag(){} // RVA: 0x7FF8650
        public void SetSliderValueFromClick(){} // RVA: 0x7FF86E0
        public void ComputeValueFromDraggingThumb(){} // RVA: 0x7FF8A90
        public void UpdateMixedValueContent(){} // RVA: 0xB43310
        public void RegisterEditingCallbacks(){} // RVA: 0x7FF8CC0
        public void UnregisterEditingCallbacks(){} // RVA: 0x7FF8E00
        public void .cctor(){} // RVA: 0x7FF90C0
    }

    public class MouseCaptureController : Object
    {
        // ── Methods ──
        public void HasMouseCapture(){} // RVA: 0x8083720
        public void CaptureMouse(){} // RVA: 0x80837E0
    }

    public class MouseCaptureEvent : MouseCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8055DB0
        public void .ctor(){} // RVA: 0x8055EA0
    }

    public class MouseCaptureEventBase`1 : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
    }

    public class MouseCaptureEventBase`1 : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x46CB670
    }

    public class MouseCaptureEventBase`1 : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x46CB670
    }

    public class MouseCaptureOutEvent : MouseCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8055AF0
        public void PreDispatch(){} // RVA: 0x8055BE0
        public void .ctor(){} // RVA: 0x8055C40
    }

    public class MouseDownEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x805FE10
        public void Init(){} // RVA: 0x805FF00
        public void LocalInit(){} // RVA: 0x805FFC0
        public void .ctor(){} // RVA: 0x805FFD0
        public void MakeFromPointerEvent(){} // RVA: 0x8060020
        public void GetPooled(){} // RVA: 0x80600E0
    }

    public class MouseEnterEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8061460
        public void Init(){} // RVA: 0x8061550
        public void LocalInit(){} // RVA: 0xBDB7E0
        public void .ctor(){} // RVA: 0x8061610
        public void Dispatch(){} // RVA: 0x8061660
    }

    public class MouseEnterWindowEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8062030
        public void Init(){} // RVA: 0x8062120
        public void LocalInit(){} // RVA: 0xBDB7B0
        public void .ctor(){} // RVA: 0x80621E0
        public void PostDispatch(){} // RVA: 0x8062230
        public void Dispatch(){} // RVA: 0x8062330
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x87C130
        public void set_modifiers(){} // RVA: 0x8944F0
        public void get_mousePosition(){} // RVA: 0x87C0A0
        public void set_mousePosition(){} // RVA: 0x895F20
        public void get_localMousePosition(){} // RVA: 0x87C0A0
        public void set_localMousePosition(){} // RVA: 0x895F20
        public void get_mouseDelta(){} // RVA: 0x87C0A0
        public void set_mouseDelta(){} // RVA: 0x895F20
        public void get_clickCount(){} // RVA: 0x87C130
        public void set_clickCount(){} // RVA: 0x8944F0
        public void get_button(){} // RVA: 0x87C130
        public void set_button(){} // RVA: 0x8944F0
        public void get_pressedButtons(){} // RVA: 0x87C130
        public void set_pressedButtons(){} // RVA: 0x8944F0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x87D280
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x894750
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x87C0A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x894320
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x87C130
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x87BEB0
        public void Init(){} // RVA: 0x894290
        public void LocalInit(){} // RVA: 0x894290
        public void get_currentTarget(){} // RVA: 0x87C0A0
        public void set_currentTarget(){} // RVA: 0x894320
        public void PreDispatch(){} // RVA: 0x894320
        public void PostDispatch(){} // RVA: 0x894320
        public void Dispatch(){} // RVA: 0x894320
        public void GetPooled(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_mousePosition(){} // RVA: 0xD34770
        public void set_mousePosition(){} // RVA: 0xD346C0
        public void get_localMousePosition(){} // RVA: 0xD346D0
        public void set_localMousePosition(){} // RVA: 0xD34690
        public void get_mouseDelta(){} // RVA: 0x46CB690
        public void set_mouseDelta(){} // RVA: 0x46CB6B0
        public void get_clickCount(){} // RVA: 0xD34730
        public void set_clickCount(){} // RVA: 0xD34790
        public void get_button(){} // RVA: 0x14780B0
        public void set_button(){} // RVA: 0x147EE80
        public void get_pressedButtons(){} // RVA: 0x40A8A30
        public void set_pressedButtons(){} // RVA: 0x46CB6C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x1C4D9A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1C4DB10
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x106A7D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0xD5CC70
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x46CB6D0
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x46CB730
        public void Init(){} // RVA: 0x46CB750
        public void LocalInit(){} // RVA: 0x46CB7E0
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x46CB960
        public void PreDispatch(){} // RVA: 0x46CBA70
        public void PostDispatch(){} // RVA: 0x46CBBE0
        public void Dispatch(){} // RVA: 0x46CBD50
        public void GetPooled(){} // RVA: 0x46CC740
        public void .ctor(){} // RVA: 0x46CCB40
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_mousePosition(){} // RVA: 0xD34770
        public void set_mousePosition(){} // RVA: 0xD346C0
        public void get_localMousePosition(){} // RVA: 0xD346D0
        public void set_localMousePosition(){} // RVA: 0xD34690
        public void get_mouseDelta(){} // RVA: 0x46CB690
        public void set_mouseDelta(){} // RVA: 0x46CB6B0
        public void get_clickCount(){} // RVA: 0xD34730
        public void set_clickCount(){} // RVA: 0xD34790
        public void get_button(){} // RVA: 0x14780B0
        public void set_button(){} // RVA: 0x147EE80
        public void get_pressedButtons(){} // RVA: 0x40A8A30
        public void set_pressedButtons(){} // RVA: 0x46CB6C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x1C4D9A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1C4DB10
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x106A7D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0xD5CC70
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x46CB6D0
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x46CB730
        public void Init(){} // RVA: 0x46CB750
        public void LocalInit(){} // RVA: 0x46CB7E0
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x46CB960
        public void PreDispatch(){} // RVA: 0x46CBA70
        public void PostDispatch(){} // RVA: 0x46CBBE0
        public void Dispatch(){} // RVA: 0x46CBD50
        public void GetPooled(){} // RVA: 0x46CC740
        public void .ctor(){} // RVA: 0x46CCB40
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_mousePosition(){} // RVA: 0xD34770
        public void set_mousePosition(){} // RVA: 0xD346C0
        public void get_localMousePosition(){} // RVA: 0xD346D0
        public void set_localMousePosition(){} // RVA: 0xD34690
        public void get_mouseDelta(){} // RVA: 0x46CB690
        public void set_mouseDelta(){} // RVA: 0x46CB6B0
        public void get_clickCount(){} // RVA: 0xD34730
        public void set_clickCount(){} // RVA: 0xD34790
        public void get_button(){} // RVA: 0x14780B0
        public void set_button(){} // RVA: 0x147EE80
        public void get_pressedButtons(){} // RVA: 0x40A8A30
        public void set_pressedButtons(){} // RVA: 0x46CB6C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x1C4D9A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1C4DB10
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x106A7D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0xD5CC70
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x46CB6D0
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x46CB730
        public void Init(){} // RVA: 0x46CB750
        public void LocalInit(){} // RVA: 0x46CB7E0
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x46CB960
        public void PreDispatch(){} // RVA: 0x46CBA70
        public void PostDispatch(){} // RVA: 0x46CBBE0
        public void Dispatch(){} // RVA: 0x46CBD50
        public void GetPooled(){} // RVA: 0x46CC740
        public void .ctor(){} // RVA: 0x46CCB40
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_mousePosition(){} // RVA: 0xD34770
        public void set_mousePosition(){} // RVA: 0xD346C0
        public void get_localMousePosition(){} // RVA: 0xD346D0
        public void set_localMousePosition(){} // RVA: 0xD34690
        public void get_mouseDelta(){} // RVA: 0x46CB690
        public void set_mouseDelta(){} // RVA: 0x46CB6B0
        public void get_clickCount(){} // RVA: 0xD34730
        public void set_clickCount(){} // RVA: 0xD34790
        public void get_button(){} // RVA: 0x14780B0
        public void set_button(){} // RVA: 0x147EE80
        public void get_pressedButtons(){} // RVA: 0x40A8A30
        public void set_pressedButtons(){} // RVA: 0x46CB6C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x1C4D9A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1C4DB10
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x106A7D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0xD5CC70
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x46CB6D0
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x46CB730
        public void Init(){} // RVA: 0x46CB750
        public void LocalInit(){} // RVA: 0x46CB7E0
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x46CB960
        public void PreDispatch(){} // RVA: 0x46CBA70
        public void PostDispatch(){} // RVA: 0x46CBBE0
        public void Dispatch(){} // RVA: 0x46CBD50
        public void GetPooled(){} // RVA: 0x46CC740
        public void .ctor(){} // RVA: 0x46CCB40
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_mousePosition(){} // RVA: 0xD34770
        public void set_mousePosition(){} // RVA: 0xD346C0
        public void get_localMousePosition(){} // RVA: 0xD346D0
        public void set_localMousePosition(){} // RVA: 0xD34690
        public void get_mouseDelta(){} // RVA: 0x46CB690
        public void set_mouseDelta(){} // RVA: 0x46CB6B0
        public void get_clickCount(){} // RVA: 0xD34730
        public void set_clickCount(){} // RVA: 0xD34790
        public void get_button(){} // RVA: 0x14780B0
        public void set_button(){} // RVA: 0x147EE80
        public void get_pressedButtons(){} // RVA: 0x40A8A30
        public void set_pressedButtons(){} // RVA: 0x46CB6C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x1C4D9A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1C4DB10
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x106A7D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0xD5CC70
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x46CB6D0
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x46CB730
        public void Init(){} // RVA: 0x46CB750
        public void LocalInit(){} // RVA: 0x46CB7E0
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x46CB960
        public void PreDispatch(){} // RVA: 0x46CBA70
        public void PostDispatch(){} // RVA: 0x46CBBE0
        public void Dispatch(){} // RVA: 0x46CBD50
        public void GetPooled(){} // RVA: 0x46CC740
        public void .ctor(){} // RVA: 0x46CCB40
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_mousePosition(){} // RVA: 0xD34770
        public void set_mousePosition(){} // RVA: 0xD346C0
        public void get_localMousePosition(){} // RVA: 0xD346D0
        public void set_localMousePosition(){} // RVA: 0xD34690
        public void get_mouseDelta(){} // RVA: 0x46CB690
        public void set_mouseDelta(){} // RVA: 0x46CB6B0
        public void get_clickCount(){} // RVA: 0xD34730
        public void set_clickCount(){} // RVA: 0xD34790
        public void get_button(){} // RVA: 0x14780B0
        public void set_button(){} // RVA: 0x147EE80
        public void get_pressedButtons(){} // RVA: 0x40A8A30
        public void set_pressedButtons(){} // RVA: 0x46CB6C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x1C4D9A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1C4DB10
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x106A7D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0xD5CC70
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x46CB6D0
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x46CB730
        public void Init(){} // RVA: 0x46CB750
        public void LocalInit(){} // RVA: 0x46CB7E0
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x46CB960
        public void PreDispatch(){} // RVA: 0x46CBA70
        public void PostDispatch(){} // RVA: 0x46CBBE0
        public void Dispatch(){} // RVA: 0x46CBD50
        public void GetPooled(){} // RVA: 0x46CC740
        public void .ctor(){} // RVA: 0x46CCB40
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_mousePosition(){} // RVA: 0xD34770
        public void set_mousePosition(){} // RVA: 0xD346C0
        public void get_localMousePosition(){} // RVA: 0xD346D0
        public void set_localMousePosition(){} // RVA: 0xD34690
        public void get_mouseDelta(){} // RVA: 0x46CB690
        public void set_mouseDelta(){} // RVA: 0x46CB6B0
        public void get_clickCount(){} // RVA: 0xD34730
        public void set_clickCount(){} // RVA: 0xD34790
        public void get_button(){} // RVA: 0x14780B0
        public void set_button(){} // RVA: 0x147EE80
        public void get_pressedButtons(){} // RVA: 0x40A8A30
        public void set_pressedButtons(){} // RVA: 0x46CB6C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x1C4D9A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1C4DB10
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x106A7D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0xD5CC70
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x46CB6D0
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x46CB730
        public void Init(){} // RVA: 0x46CB750
        public void LocalInit(){} // RVA: 0x46CB7E0
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x46CB960
        public void PreDispatch(){} // RVA: 0x46CBA70
        public void PostDispatch(){} // RVA: 0x46CBBE0
        public void Dispatch(){} // RVA: 0x46CBD50
        public void GetPooled(){} // RVA: 0x46CC740
        public void .ctor(){} // RVA: 0x46CCB40
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_mousePosition(){} // RVA: 0xD34770
        public void set_mousePosition(){} // RVA: 0xD346C0
        public void get_localMousePosition(){} // RVA: 0xD346D0
        public void set_localMousePosition(){} // RVA: 0xD34690
        public void get_mouseDelta(){} // RVA: 0x46CB690
        public void set_mouseDelta(){} // RVA: 0x46CB6B0
        public void get_clickCount(){} // RVA: 0xD34730
        public void set_clickCount(){} // RVA: 0xD34790
        public void get_button(){} // RVA: 0x14780B0
        public void set_button(){} // RVA: 0x147EE80
        public void get_pressedButtons(){} // RVA: 0x40A8A30
        public void set_pressedButtons(){} // RVA: 0x46CB6C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x1C4D9A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1C4DB10
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x106A7D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0xD5CC70
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x46CB6D0
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x46CB730
        public void Init(){} // RVA: 0x46CB750
        public void LocalInit(){} // RVA: 0x46CB7E0
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x46CB960
        public void PreDispatch(){} // RVA: 0x46CBA70
        public void PostDispatch(){} // RVA: 0x46CBBE0
        public void Dispatch(){} // RVA: 0x46CBD50
        public void GetPooled(){} // RVA: 0x46CC740
        public void .ctor(){} // RVA: 0x46CCB40
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_mousePosition(){} // RVA: 0xD34770
        public void set_mousePosition(){} // RVA: 0xD346C0
        public void get_localMousePosition(){} // RVA: 0xD346D0
        public void set_localMousePosition(){} // RVA: 0xD34690
        public void get_mouseDelta(){} // RVA: 0x46CB690
        public void set_mouseDelta(){} // RVA: 0x46CB6B0
        public void get_clickCount(){} // RVA: 0xD34730
        public void set_clickCount(){} // RVA: 0xD34790
        public void get_button(){} // RVA: 0x14780B0
        public void set_button(){} // RVA: 0x147EE80
        public void get_pressedButtons(){} // RVA: 0x40A8A30
        public void set_pressedButtons(){} // RVA: 0x46CB6C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x1C4D9A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1C4DB10
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x106A7D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0xD5CC70
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x46CB6D0
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x46CB730
        public void Init(){} // RVA: 0x46CB750
        public void LocalInit(){} // RVA: 0x46CB7E0
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x46CB960
        public void PreDispatch(){} // RVA: 0x46CBA70
        public void PostDispatch(){} // RVA: 0x46CBBE0
        public void Dispatch(){} // RVA: 0x46CBD50
        public void GetPooled(){} // RVA: 0x46CC740
        public void .ctor(){} // RVA: 0x46CCB40
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_mousePosition(){} // RVA: 0xD34770
        public void set_mousePosition(){} // RVA: 0xD346C0
        public void get_localMousePosition(){} // RVA: 0xD346D0
        public void set_localMousePosition(){} // RVA: 0xD34690
        public void get_mouseDelta(){} // RVA: 0x46CB690
        public void set_mouseDelta(){} // RVA: 0x46CB6B0
        public void get_clickCount(){} // RVA: 0xD34730
        public void set_clickCount(){} // RVA: 0xD34790
        public void get_button(){} // RVA: 0x14780B0
        public void set_button(){} // RVA: 0x147EE80
        public void get_pressedButtons(){} // RVA: 0x40A8A30
        public void set_pressedButtons(){} // RVA: 0x46CB6C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x1C4D9A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1C4DB10
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x106A7D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0xD5CC70
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x46CB6D0
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x46CB730
        public void Init(){} // RVA: 0x46CB750
        public void LocalInit(){} // RVA: 0x46CB7E0
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x46CB960
        public void PreDispatch(){} // RVA: 0x46CBA70
        public void PostDispatch(){} // RVA: 0x46CBBE0
        public void Dispatch(){} // RVA: 0x46CBD50
        public void GetPooled(){} // RVA: 0x46CC740
        public void .ctor(){} // RVA: 0x46CCB40
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_mousePosition(){} // RVA: 0xD34770
        public void set_mousePosition(){} // RVA: 0xD346C0
        public void get_localMousePosition(){} // RVA: 0xD346D0
        public void set_localMousePosition(){} // RVA: 0xD34690
        public void get_mouseDelta(){} // RVA: 0x46CB690
        public void set_mouseDelta(){} // RVA: 0x46CB6B0
        public void get_clickCount(){} // RVA: 0xD34730
        public void set_clickCount(){} // RVA: 0xD34790
        public void get_button(){} // RVA: 0x14780B0
        public void set_button(){} // RVA: 0x147EE80
        public void get_pressedButtons(){} // RVA: 0x40A8A30
        public void set_pressedButtons(){} // RVA: 0x46CB6C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x1C4D9A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1C4DB10
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x106A7D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0xD5CC70
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x46CB6D0
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x46CB730
        public void Init(){} // RVA: 0x46CB750
        public void LocalInit(){} // RVA: 0x46CB7E0
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x46CB960
        public void PreDispatch(){} // RVA: 0x46CBA70
        public void PostDispatch(){} // RVA: 0x46CBBE0
        public void Dispatch(){} // RVA: 0x46CBD50
        public void GetPooled(){} // RVA: 0x46CC740
        public void .ctor(){} // RVA: 0x46CCB40
    }

    public class MouseEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_mousePosition(){} // RVA: 0xD34770
        public void set_mousePosition(){} // RVA: 0xD346C0
        public void get_localMousePosition(){} // RVA: 0xD346D0
        public void set_localMousePosition(){} // RVA: 0xD34690
        public void get_mouseDelta(){} // RVA: 0x46CB690
        public void set_mouseDelta(){} // RVA: 0x46CB6B0
        public void get_clickCount(){} // RVA: 0xD34730
        public void set_clickCount(){} // RVA: 0xD34790
        public void get_button(){} // RVA: 0x14780B0
        public void set_button(){} // RVA: 0x147EE80
        public void get_pressedButtons(){} // RVA: 0x40A8A30
        public void set_pressedButtons(){} // RVA: 0x46CB6C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x1C4D9A0
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x1C4DB10
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x106A7D0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0xD5CC70
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_pointerId(){} // RVA: 0x46CB6D0
        public void UnityEngine.UIElements.IPointerOrMouseEvent.get_position(){} // RVA: 0x46CB730
        public void Init(){} // RVA: 0x46CB750
        public void LocalInit(){} // RVA: 0x46CB7E0
        public void get_currentTarget(){} // RVA: 0x46CB940
        public void set_currentTarget(){} // RVA: 0x46CB960
        public void PreDispatch(){} // RVA: 0x46CBA70
        public void PostDispatch(){} // RVA: 0x46CBBE0
        public void Dispatch(){} // RVA: 0x46CBD50
        public void GetPooled(){} // RVA: 0x46CC740
        public void .ctor(){} // RVA: 0x46CCB40
    }

    public class MouseEventsHelper : Object
    {
        // ── Methods ──
        public void SendEnterLeave(){} // RVA: 0xA94080
        public void SendMouseOverMouseOut(){} // RVA: 0x8063710
    }

    public class MouseLeaveEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8061790
        public void Init(){} // RVA: 0x8061880
        public void LocalInit(){} // RVA: 0xBDB7E0
        public void .ctor(){} // RVA: 0x8061940
        public void Dispatch(){} // RVA: 0x8061660
    }

    public class MouseLeaveWindowEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x80624F0
        public void Init(){} // RVA: 0x80625E0
        public void LocalInit(){} // RVA: 0xBDB7B0
        public void .ctor(){} // RVA: 0x80626A0
        public void GetPooled(){} // RVA: 0x80626F0
        public void PostDispatch(){} // RVA: 0x8062810
        public void Dispatch(){} // RVA: 0x80629D0
    }

    public class MouseManipulator : Manipulator
    {
        // ── Methods ──
        public void get_activators(){} // RVA: 0xB465B0
        public void set_activators(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8083900
    }

    public class MouseMoveEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8060760
        public void Init(){} // RVA: 0x8060850
        public void LocalInit(){} // RVA: 0x7FA9B20
        public void .ctor(){} // RVA: 0x8060910
        public void GetPooled(){} // RVA: 0x8060960
    }

    public class MouseOutEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8061D70
        public void Dispatch(){} // RVA: 0x8061660
        public void PreDispatch(){} // RVA: 0x8061E60
        public void .ctor(){} // RVA: 0x8061EE0
    }

    public class MouseOverEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8061AB0
        public void Dispatch(){} // RVA: 0x8061660
        public void PreDispatch(){} // RVA: 0x8061BA0
        public void .ctor(){} // RVA: 0x8061C20
    }

    public class MouseUpEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8060280
        public void Init(){} // RVA: 0x8060370
        public void LocalInit(){} // RVA: 0x805FFC0
        public void .ctor(){} // RVA: 0x8060430
        public void MakeFromPointerEvent(){} // RVA: 0x8060480
        public void GetPooled(){} // RVA: 0x80605C0
    }

    public class MultiColumnController : Object
    {
        // ── Methods ──
        public void add_columnSortingChanged(){} // RVA: 0x8005540
        public void remove_columnSortingChanged(){} // RVA: 0x8005630
        public void add_headerContextMenuPopulateEvent(){} // RVA: 0x8005720
        public void remove_headerContextMenuPopulateEvent(){} // RVA: 0x8005830
        public void get_header(){} // RVA: 0xBBF8F0
        public void get_sortingMode(){} // RVA: 0xB9E080
        public void set_sortingMode(){} // RVA: 0x8005940
        public void .ctor(){} // RVA: 0x8005990
        public void BindCellItem(){} // RVA: 0xA94080
        public void UnbindCellItem(){} // RVA: 0x8006240
        public void DefaultMakeCellItem(){} // RVA: 0x8006280
        public void DefaultBindCellItem(){} // RVA: 0xA94080
        public void MakeItem(){} // RVA: 0x8006330
        public void BindItem(){} // RVA: 0xA94080
        public void UnbindItem(){} // RVA: 0x80066D0
        public void DestroyItem(){} // RVA: 0x8006A20
        public void PrepareView(){} // RVA: 0x8006D90
        public void Dispose(){} // RVA: 0x8007190
        public void OnHorizontalScrollerValueChanged(){} // RVA: 0x8007E80
        public void OnViewportGeometryChanged(){} // RVA: 0x8007FC0
        public void OnColumnContainerGeometryChanged(){} // RVA: 0x8008280
        public void UpdateContentContainer(){} // RVA: 0x8008290
        public void OnColumnSortingChanged(){} // RVA: 0x8008450
        public void UpdateDragger(){} // RVA: 0x80084A0
        public void SortIfNeeded(){} // RVA: 0x8008550
        public void CombinedComparison(){} // RVA: 0x8008AB0
        public void GetSourceIndex(){} // RVA: 0x8008FC0
        public void GetSortedIndex(){} // RVA: 0x8009090
        public void GetIndexFromList(){} // RVA: 0x8009160
        public void OnContextMenuPopulateEvent(){} // RVA: 0x59516C0
        public void OnColumnResized(){} // RVA: 0x80091F0
        public void OnColumnAdded(){} // RVA: 0x80095E0
        public void OnColumnRemoved(){} // RVA: 0x80095E0
        public void OnColumnReordered(){} // RVA: 0x8009600
        public void OnColumnsChanged(){} // RVA: 0x8009640
        public void OnColumnChanged(){} // RVA: 0x8009680
        public void OnViewDataRestored(){} // RVA: 0x80095E0
        public void .cctor(){} // RVA: 0x80096C0
    }

    public class MultiColumnListView : BaseListView
    {
        // ── Methods ──
        public void get_viewController(){} // RVA: 0x8009FE0
        public void get_columns(){} // RVA: 0x164ECC0
        public void set_columns(){} // RVA: 0x800A060
        public void get_sortColumnDescriptions(){} // RVA: 0x165DB50
        public void set_sortColumnDescriptions(){} // RVA: 0x800A260
        public void get_sortingMode(){} // RVA: 0x800A3C0
        public void set_sortingMode(){} // RVA: 0x800A3D0
        public void .ctor(){} // RVA: 0x800A530
        public void CreateViewController(){} // RVA: 0x800A740
        public void SetViewController(){} // RVA: 0x800A8E0
        public void CreateVirtualizationController(){} // RVA: 0x800AB40
        public void RaiseColumnSortingChanged(){} // RVA: 0x800AB80
        public void ColumnsChanged(){} // RVA: 0x800ABA0
        public void RaiseHeaderContextMenuPopulate(){} // RVA: 0x800AC30
        public void .cctor(){} // RVA: 0x800AC50
    }

    public class MultiColumnListViewController : BaseListViewController
    {
        // ── Methods ──
        public void get_columnController(){} // RVA: 0xBBF8F0
        public void .ctor(){} // RVA: 0x7E8BE40
        public void PreRefresh(){} // RVA: 0x7E8BFA0
        public void SortIfNeeded(){} // RVA: 0x7E8BFC0
        public void InvokeMakeItem(){} // RVA: 0x7E8C010
        public void InvokeBindItem(){} // RVA: 0x7E8C130
        public void GetItemForIndex(){} // RVA: 0x7E8C220
        public void GetIndexForId(){} // RVA: 0x7E8C2E0
        public void GetIdForIndex(){} // RVA: 0x7E8C3C0
        public void MakeItem(){} // RVA: 0x7E8C3E0
        public void BindItem(){} // RVA: 0x7E8C400
        public void UnbindItem(){} // RVA: 0x7E8C4A0
        public void DestroyItem(){} // RVA: 0x7E8C4C0
        public void PrepareView(){} // RVA: 0x7E8C4E0
        public void Dispose(){} // RVA: 0x7E8C670
        public void UpdateReorderClassList(){} // RVA: 0x7E8C860
    }

    public class MultiColumnTreeView : BaseTreeView
    {
        // ── Methods ──
        public void get_viewController(){} // RVA: 0x800B750
        public void get_columns(){} // RVA: 0x16535F0
        public void set_columns(){} // RVA: 0x800B7D0
        public void get_sortColumnDescriptions(){} // RVA: 0x16633F0
        public void set_sortColumnDescriptions(){} // RVA: 0x800B9D0
        public void get_sortingMode(){} // RVA: 0x800BB30
        public void set_sortingMode(){} // RVA: 0x800BB40
        public void .ctor(){} // RVA: 0x800BCA0
        public void CreateViewController(){} // RVA: 0x800BEB0
        public void SetViewController(){} // RVA: 0x800BF50
        public void CreateVirtualizationController(){} // RVA: 0x800C1B0
        public void RaiseColumnSortingChanged(){} // RVA: 0x800C1F0
        public void ColumnsChanged(){} // RVA: 0x800ABA0
        public void RaiseHeaderContextMenuPopulate(){} // RVA: 0x800C210
        public void .cctor(){} // RVA: 0x800C230
    }

    public class MultiColumnTreeViewController : BaseTreeViewController
    {
        // ── Methods ──
        public void get_columnController(){} // RVA: 0xBBFF90
        public void .ctor(){} // RVA: 0x7E8C950
        public void PreRefresh(){} // RVA: 0x7E8CA60
        public void InvokeMakeItem(){} // RVA: 0x7E8CAA0
        public void MakeItem(){} // RVA: 0x7E8CBF0
        public void BindItem(){} // RVA: 0x7E8CC10
        public void UnbindItem(){} // RVA: 0x7E8CCB0
        public void DestroyItem(){} // RVA: 0x7E8CCD0
        public void PrepareView(){} // RVA: 0x7E8CCF0
        public void Dispose(){} // RVA: 0x7E8CD20
    }

}