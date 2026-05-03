// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 31
// Methods: 264

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Manipulator : Object
    {
        public UnityEngine.UIElements.VisualElement m_Target; // 0x10

        // ── Methods ──
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFE80E45FE0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFE80E45FE0
        public void get_target(){} // RVA: 0x7FFE84022BE0
        public void set_target(){} // RVA: 0x7FFE87F4DF90
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ManipulatorActivationFilter : ValueType
    {
        public 0x665189D4 _button; // 0x10
        public 0x66679374 _modifiers; // 0x14
        public int _clickCount; // 0x18

        // ── Methods ──
        public void get_button(){} // RVA: 0x7FFE826F4220
        public void set_button(){} // RVA: 0x7FFE815BF990
        public void get_modifiers(){} // RVA: 0x7FFE826F42A0
        public void set_modifiers(){} // RVA: 0x7FFE826F4290
        public void get_clickCount(){} // RVA: 0x7FFE82C33000
        public void Equals(){} // RVA: 0x7FFE87C98D60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87F4DB60
        public void Matches(){} // RVA: 0x7FFE87F4DD40 | overloaded x2
        public void HasModifiers(){} // RVA: 0x7FFE87F4DE10 | overloaded x2
        public void MatchModifiers(){} // RVA: 0x7FFE87F4DF00
    }

    public class MeshBuilderNative : Object
    {
        // ── Methods ──
        public void MakeBorder(){} // RVA: 0x7FFE87F4E820
        public void MakeSolidRect(){} // RVA: 0x7FFE87F4E8A0
        public void MakeTexturedRect(){} // RVA: 0x7FFE87F4E920
        public void MakeVectorGraphicsStretchBackground(){} // RVA: 0x7FFE87F4E9A0
        public void MakeVectorGraphics9SliceBackground(){} // RVA: 0x7FFE87F4EAB0
        public void MakeBorder_Injected(){} // RVA: 0x7FFE87F4EB90
        public void MakeSolidRect_Injected(){} // RVA: 0x7FFE87F4EC00
        public void MakeTexturedRect_Injected(){} // RVA: 0x7FFE87F4EC70
        public void MakeVectorGraphicsStretchBackground_Injected(){} // RVA: 0x7FFE87F4ECE0
        public void MakeVectorGraphics9SliceBackground_Injected(){} // RVA: 0x7FFE87F4ED70
    }

    public class MeshGenerationContext : Object
    {
        public UnityEngine.UIElements.Painter2D m_Painter2D; // 0x10
        public Unity.Profiling.ProfilerMarker s_AllocateMarker;

        // ── Methods ──
        public void get_painter2D(){} // RVA: 0x7FFE87F75FB0
        public void get_hasPainter2D(){} // RVA: 0x7FFE81C8DC00
        public void .ctor(){} // RVA: 0x7FFE81161E80
        public void .cctor(){} // RVA: 0x7FFE87F76060
    }

    public class MeshGenerationContextUtils : Object
    {
        // ── Methods ──
        public void Rectangle(){} // RVA: 0x7FFE87F72F60
        public void Text(){} // RVA: 0x7FFE87F730C0
        public void ConvertBorderRadiusPercentToPoints(){} // RVA: 0x7FFE87F73190
        public void GetVisualElementRadii(){} // RVA: 0x7FFE87F731F0
        public void AdjustBackgroundSizeForBorders(){} // RVA: 0x7FFE87F734A0
    }

    public class MeshWriteData : Object
    {
        public Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex> m_Vertices; // 0x10
        public Unity.Collections.NativeSlice`1<ushort> m_Indices; // 0x20
        public UnityEngine.Rect m_UVRegion; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_vertexCount(){} // RVA: 0x7FFE87F72B00
        public void get_indexCount(){} // RVA: 0x7FFE87F72B40
        public void get_uvRegion(){} // RVA: 0x7FFE87C9FAE0
        public void SetNextVertex(){} // RVA: 0x7FFE87F72B80
        public void SetNextIndex(){} // RVA: 0x7FFE87F72C30
        public void SetAllVertices(){} // RVA: 0x7FFE87F72CC0
        public void SetAllIndices(){} // RVA: 0x7FFE87F72D80
        public void Reset(){} // RVA: 0x7FFE87F72E70 | overloaded x2
    }

    public class MeshWriteDataInterface : ValueType
    {
    }

    public class MinMaxSlider : BaseField`1
    {
        public UnityEngine.UIElements.VisualElement _dragElement; // 0x440
        public UnityEngine.UIElements.VisualElement _dragMinThumb; // 0x448
        public UnityEngine.UIElements.VisualElement _dragMaxThumb; // 0x450
        public UnityEngine.UIElements.ClampedDragger`1<float> _clampedDragger; // 0x458
        public UnityEngine.Vector2 m_DragElementStartPos; // 0x460
        public UnityEngine.Vector2 m_ValueStartPos; // 0x468
        public UnityEngine.Rect m_DragMinThumbRect; // 0x470
        public UnityEngine.Rect m_DragMaxThumbRect; // 0x480
        public 0x66510E6C m_DragState; // 0x490

        // ── Methods ──
        public void get_dragElement(){} // RVA: 0x7FFE81B373C0
        public void set_dragElement(){} // RVA: 0x7FFE81B2F130
        public void get_dragMinThumb(){} // RVA: 0x7FFE81B10FA0
        public void set_dragMinThumb(){} // RVA: 0x7FFE81B23CA0
        public void get_dragMaxThumb(){} // RVA: 0x7FFE81B330C0
        public void set_dragMaxThumb(){} // RVA: 0x7FFE81B09FE0
        public void get_clampedDragger(){} // RVA: 0x7FFE81B339E0
        public void set_clampedDragger(){} // RVA: 0x7FFE81B25930
        public void get_minValue(){} // RVA: 0x7FFE87EE8530
        public void set_minValue(){} // RVA: 0x7FFE87EE8560
        public void get_maxValue(){} // RVA: 0x7FFE87EE85E0
        public void set_maxValue(){} // RVA: 0x7FFE87EE8610
        public void get_value(){} // RVA: 0x7FFE87EE8690
        public void set_value(){} // RVA: 0x7FFE87EE86E0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE87EE8740
        public void get_lowLimit(){} // RVA: 0x7FFE87EE87B0
        public void set_lowLimit(){} // RVA: 0x7FFE87EE87C0
        public void get_highLimit(){} // RVA: 0x7FFE87EE88C0
        public void set_highLimit(){} // RVA: 0x7FFE87EE88D0
        public void .ctor(){} // RVA: 0x7FFE87EE8A10 | overloaded x2
        public void ClampValues(){} // RVA: 0x7FFE87EE9310
        public void UpdateDragElementPosition(){} // RVA: 0x7FFE87EE9410 | overloaded x2
        public void SliderLerpUnclamped(){} // RVA: 0x7FFE87EEA140
        public void SliderNormalizeValue(){} // RVA: 0x7FFE87EEA160
        public void ComputeValueFromPosition(){} // RVA: 0x7FFE87EEA180
        public void ExecuteDefaultAction(){} // RVA: 0x7FFE87EEA2A0
        public void SetSliderValueFromDrag(){} // RVA: 0x7FFE87EEA3F0
        public void SetSliderValueFromClick(){} // RVA: 0x7FFE87EEA480
        public void ComputeValueDragStateNoThumb(){} // RVA: 0x7FFE87EEA8F0
        public void ComputeValueFromDraggingThumb(){} // RVA: 0x7FFE87EEA9C0
        public void UpdateMixedValueContent(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87EEABE0
    }

    public class MouseCaptureController : Object
    {
        // ── Methods ──
        public void HasMouseCapture(){} // RVA: 0x7FFE87F4E030
        public void CaptureMouse(){} // RVA: 0x7FFE87F4E130
        public void ReleaseMouse(){} // RVA: 0x7FFE87F4E260
    }

    public class MouseCaptureDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFE87F2E1C0
        public void DispatchEvent(){} // RVA: 0x7FFE87F2E240
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MouseCaptureEvent : MouseCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F25E20
        public void .ctor(){} // RVA: 0x7FFE87F25F10
    }

    public class MouseCaptureEventBase`1 : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class MouseCaptureOutEvent : MouseCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F25BC0
        public void .ctor(){} // RVA: 0x7FFE87F25CB0
    }

    public class MouseDownEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F2F510
        public void Init(){} // RVA: 0x7FFE87F2F600
        public void LocalInit(){} // RVA: 0x7FFE87F2F6C0
        public void .ctor(){} // RVA: 0x7FFE87F2F6D0
        public void MakeFromPointerEvent(){} // RVA: 0x7FFE87F2F720
        public void GetPooled(){} // RVA: 0x7FFE87F2F890 | overloaded x2
    }

    public class MouseEnterEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F30B20
        public void Init(){} // RVA: 0x7FFE87F30C10
        public void LocalInit(){} // RVA: 0x7FFE87F30CD0
        public void .ctor(){} // RVA: 0x7FFE87F30CE0
    }

    public class MouseEnterWindowEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F31170
        public void Init(){} // RVA: 0x7FFE87F31260
        public void LocalInit(){} // RVA: 0x7FFE87F31320
        public void .ctor(){} // RVA: 0x7FFE87F31330
        public void PostDispatch(){} // RVA: 0x7FFE87F31380
    }

    public class MouseEventBase`1 : EventBase`1
    {
        public 0x66679374 _modifiers;
        public UnityEngine.Vector2 _mousePosition;
        public UnityEngine.Vector2 _localMousePosition;
        public UnityEngine.Vector2 _mouseDelta;
        public int _clickCount;
        public int _button;
        public int _pressedButtons;
        public bool _triggeredByOS;
        public bool _recomputeTopElementUnderMouse;
        public UnityEngine.UIElements.IPointerEvent _sourcePointerEvent;
        public object field_10; // 0x22A
        public object field_11; // 0x22B
        public object field_12; // 0x22C
        public object field_13; // 0x22D
        public object field_14; // 0x22E

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7FFE80E2EDB0
        public void set_modifiers(){} // RVA: 0x7FFE80E46530
        public void get_mousePosition(){} // RVA: 0x7FFE80E2E2E0
        public void set_mousePosition(){} // RVA: 0x7FFE80E54AE0
        public void get_localMousePosition(){} // RVA: 0x7FFE80E2E2E0
        public void set_localMousePosition(){} // RVA: 0x7FFE80E54AE0
        public void get_mouseDelta(){} // RVA: 0x7FFE80E2E2E0
        public void set_mouseDelta(){} // RVA: 0x7FFE80E54AE0
        public void get_clickCount(){} // RVA: 0x7FFE80E2EDB0
        public void set_clickCount(){} // RVA: 0x7FFE80E46530
        public void get_button(){} // RVA: 0x7FFE80E2EDB0
        public void set_button(){} // RVA: 0x7FFE80E46530
        public void get_pressedButtons(){} // RVA: 0x7FFE80E2EDB0
        public void set_pressedButtons(){} // RVA: 0x7FFE80E46530
        public void get_shiftKey(){} // RVA: 0x7FFE80E2F150
        public void get_ctrlKey(){} // RVA: 0x7FFE80E2F150
        public void get_commandKey(){} // RVA: 0x7FFE80E2F150
        public void get_altKey(){} // RVA: 0x7FFE80E2F150
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7FFE80E2F150
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7FFE80E466C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7FFE80E2F150
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7FFE80E466C0
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7FFE80E2E2E0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7FFE80E460A0
        public void Init(){} // RVA: 0x7FFE80E45FE0
        public void LocalInit(){} // RVA: 0x7FFE80E45FE0
        public void get_currentTarget(){} // RVA: 0x7FFE80E2E2E0
        public void set_currentTarget(){} // RVA: 0x7FFE80E460A0
        public void PreDispatch(){} // RVA: 0x7FFE80E460A0
        public void PostDispatch(){} // RVA: 0x7FFE80E460A0
        public void GetPooled(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class MouseEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFE87F2E970
        public void DispatchEvent(){} // RVA: 0x7FFE87F2E9C0
        public void SendEventToTarget(){} // RVA: 0x7FFE87F2EC30
        public void SendEventToRegularTarget(){} // RVA: 0x7FFE87F2ED70
        public void SendEventToIMGUIContainer(){} // RVA: 0x7FFE87F2EE90
        public void SetBestTargetForEvent(){} // RVA: 0x7FFE87F2F0A0
        public void UpdateElementUnderMouse(){} // RVA: 0x7FFE87F2F150
        public void IsDone(){} // RVA: 0x7FFE87F2F480
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MouseEventsHelper : Object
    {
        // ── Methods ──
        public void SendEnterLeave(){} // RVA: 0x7FFE810A1420
        public void SendMouseOverMouseOut(){} // RVA: 0x7FFE87F32B40
    }

    public class MouseLeaveEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F30E50
        public void Init(){} // RVA: 0x7FFE87F30F40
        public void LocalInit(){} // RVA: 0x7FFE87F30CD0
        public void .ctor(){} // RVA: 0x7FFE87F31000
    }

    public class MouseLeaveWindowEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F315B0
        public void Init(){} // RVA: 0x7FFE87F316A0
        public void LocalInit(){} // RVA: 0x7FFE87F317A0
        public void .ctor(){} // RVA: 0x7FFE87F317F0
        public void GetPooled(){} // RVA: 0x7FFE87F31870
        public void PostDispatch(){} // RVA: 0x7FFE87F31990
    }

    public class MouseManipulator : Manipulator
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.ManipulatorActivationFilter> _activators; // 0x18

        // ── Methods ──
        public void get_activators(){} // RVA: 0x7FFE810FE7C0
        public void set_activators(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE87F4E3D0
        public void CanStartManipulation(){} // RVA: 0x7FFE87F4E490
        public void CanStopManipulation(){} // RVA: 0x7FFE87F4E6B0
    }

    public class MouseMoveEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F2FF30
        public void Init(){} // RVA: 0x7FFE87F30020
        public void LocalInit(){} // RVA: 0x7FFE87F300E0
        public void .ctor(){} // RVA: 0x7FFE87F300F0
        public void GetPooled(){} // RVA: 0x7FFE87F30140
    }

    public class MouseOutEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F31E30
        public void .ctor(){} // RVA: 0x7FFE87F31F20
    }

    public class MouseOverEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F31BF0
        public void .ctor(){} // RVA: 0x7FFE87F31CE0
    }

    public class MouseUpEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F2FA00
        public void Init(){} // RVA: 0x7FFE87F2FAF0
        public void LocalInit(){} // RVA: 0x7FFE87F2F6C0
        public void .ctor(){} // RVA: 0x7FFE87F2FBB0
        public void MakeFromPointerEvent(){} // RVA: 0x7FFE87F2FC00
        public void GetPooled(){} // RVA: 0x7FFE87F2FDC0 | overloaded x3
    }

    public class MultiColumnController : Object
    {
        public UnityEngine.PropertyName k_BoundColumnVePropertyName;

        // ── Methods ──
        public void add_columnSortingChanged(){} // RVA: 0x7FFE87EF26D0
        public void remove_columnSortingChanged(){} // RVA: 0x7FFE87EF27C0
        public void add_headerContextMenuPopulateEvent(){} // RVA: 0x7FFE87EF28B0
        public void remove_headerContextMenuPopulateEvent(){} // RVA: 0x7FFE87EF29B0
        public void get_header(){} // RVA: 0x7FFE8144E200
        public void .ctor(){} // RVA: 0x7FFE87EF2AB0
        public void BindCellItem(){} // RVA: 0x7FFE810A1420
        public void UnbindCellItem(){} // RVA: 0x7FFE87EF3360
        public void DefaultMakeCellItem(){} // RVA: 0x7FFE87EF33A0
        public void DefaultBindCellItem(){} // RVA: 0x7FFE810A1420
        public void MakeItem(){} // RVA: 0x7FFE87EF3470
        public void BindItem(){} // RVA: 0x7FFE810A1420
        public void UnbindItem(){} // RVA: 0x7FFE87EF3800
        public void DestroyItem(){} // RVA: 0x7FFE87EF3B90
        public void PrepareView(){} // RVA: 0x7FFE87EF3F40
        public void Dispose(){} // RVA: 0x7FFE87EF4340
        public void OnHorizontalScrollerValueChanged(){} // RVA: 0x7FFE87EF4EF0
        public void OnViewportGeometryChanged(){} // RVA: 0x7FFE87EF5030
        public void OnColumnContainerGeometryChanged(){} // RVA: 0x7FFE87EF52C0
        public void UpdateContentContainer(){} // RVA: 0x7FFE87EF52D0
        public void OnColumnSortingChanged(){} // RVA: 0x7FFE8143C6A0
        public void OnContextMenuPopulateEvent(){} // RVA: 0x7FFE85A88580
        public void OnColumnResized(){} // RVA: 0x7FFE87EF5480
        public void OnColumnAdded(){} // RVA: 0x7FFE87EF5820
        public void OnColumnRemoved(){} // RVA: 0x7FFE87EF5820
        public void OnColumnReordered(){} // RVA: 0x7FFE87EF5840
        public void OnColumnsChanged(){} // RVA: 0x7FFE87EF5880
        public void OnColumnChanged(){} // RVA: 0x7FFE87EF58C0
        public void OnViewDataRestored(){} // RVA: 0x7FFE87EF5820
        public void .cctor(){} // RVA: 0x7FFE87EF5900
    }

    public class MultiColumnListView : BaseListView
    {
        public UnityEngine.UIElements.Columns m_Columns; // 0x540
        public bool m_SortingEnabled; // 0x548
        public UnityEngine.UIElements.SortColumnDescriptions m_SortColumnDescriptions; // 0x550
        public System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription> m_SortedColumns; // 0x558

        // ── Methods ──
        public void get_viewController(){} // RVA: 0x7FFE87EF5E40
        public void get_columns(){} // RVA: 0x7FFE81B26880
        public void set_columns(){} // RVA: 0x7FFE87EF5ED0
        public void get_sortColumnDescriptions(){} // RVA: 0x7FFE81B24550
        public void set_sortColumnDescriptions(){} // RVA: 0x7FFE87EF5FC0
        public void set_sortingEnabled(){} // RVA: 0x7FFE87EF60C0
        public void .ctor(){} // RVA: 0x7FFE87EF61A0 | overloaded x2
        public void CreateViewController(){} // RVA: 0x7FFE87EF63B0
        public void SetViewController(){} // RVA: 0x7FFE87EF64C0
        public void CreateVirtualizationController(){} // RVA: 0x7FFE87EF6710
        public void RaiseColumnSortingChanged(){} // RVA: 0x7FFE87EF6750
        public void RaiseHeaderContextMenuPopulate(){} // RVA: 0x7FFE87EF6770
    }

    public class MultiColumnListViewController : BaseListViewController
    {
        public UnityEngine.UIElements.MultiColumnController m_ColumnController; // 0x48
        public object field_1; // 0x62

        // ── Methods ──
        public void get_columnController(){} // RVA: 0x7FFE81176730
        public void get_header(){} // RVA: 0x7FFE87E33290
        public void .ctor(){} // RVA: 0x7FFE87E332A0
        public void InvokeMakeItem(){} // RVA: 0x7FFE87E33370
        public void MakeItem(){} // RVA: 0x7FFE87E334B0
        public void BindItem(){} // RVA: 0x7FFE87E334D0
        public void UnbindItem(){} // RVA: 0x7FFE87E33570
        public void DestroyItem(){} // RVA: 0x7FFE87E33590
        public void PrepareView(){} // RVA: 0x7FFE87E335B0
        public void Dispose(){} // RVA: 0x7FFE87E33740
        public void UpdateReorderClassList(){} // RVA: 0x7FFE87E33930
    }

    public class MultiColumnTreeView : BaseTreeView
    {
        public UnityEngine.UIElements.Columns m_Columns; // 0x4C0
        public bool m_SortingEnabled; // 0x4C8
        public UnityEngine.UIElements.SortColumnDescriptions m_SortColumnDescriptions; // 0x4D0
        public System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription> m_SortedColumns; // 0x4D8

        // ── Methods ──
        public void get_viewController(){} // RVA: 0x7FFE87EF6D10
        public void get_columns(){} // RVA: 0x7FFE81B0DED0
        public void set_columns(){} // RVA: 0x7FFE87EF6DA0
        public void get_sortColumnDescriptions(){} // RVA: 0x7FFE81B10190
        public void set_sortColumnDescriptions(){} // RVA: 0x7FFE87EF6E90
        public void set_sortingEnabled(){} // RVA: 0x7FFE87EF6F90
        public void .ctor(){} // RVA: 0x7FFE87EF7070 | overloaded x2
        public void CreateViewController(){} // RVA: 0x7FFE87EF7280
        public void SetViewController(){} // RVA: 0x7FFE87EF7320
        public void CreateVirtualizationController(){} // RVA: 0x7FFE87EF7650
        public void RaiseColumnSortingChanged(){} // RVA: 0x7FFE87EF7690
        public void RaiseHeaderContextMenuPopulate(){} // RVA: 0x7FFE87EF76B0
    }

    public class MultiColumnTreeViewController : BaseTreeViewController
    {
        public UnityEngine.UIElements.MultiColumnController m_ColumnController; // 0x58
        public object field_1; // 0x64

        // ── Methods ──
        public void get_columnController(){} // RVA: 0x7FFE811C3500
        public void get_header(){} // RVA: 0x7FFE87E33A20
        public void .ctor(){} // RVA: 0x7FFE87E33A30
        public void InvokeMakeItem(){} // RVA: 0x7FFE87E33B30
        public void MakeItem(){} // RVA: 0x7FFE87E33CC0
        public void BindItem(){} // RVA: 0x7FFE87E33CE0
        public void UnbindItem(){} // RVA: 0x7FFE87E33D80
        public void DestroyItem(){} // RVA: 0x7FFE87E33DA0
        public void PrepareView(){} // RVA: 0x7FFE87E33DC0
        public void Dispose(){} // RVA: 0x7FFE87E33DF0
    }

}