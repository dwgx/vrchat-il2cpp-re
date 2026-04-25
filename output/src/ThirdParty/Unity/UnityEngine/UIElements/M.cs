// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 31
// Methods: 264

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Manipulator : Object
    {
        public UnityEngine.UIElements.VisualElement target; // 0x10

        // ── Methods ──
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFAC2C70980
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFAC2C70980
        public void get_target(){} // RVA: 0x7FFAC5CC4750
        public void set_target(){} // RVA: 0x7FFAC9BA56E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ManipulatorActivationFilter : ValueType
    {
        public 0x6B11FAB0 button; // 0x10
        public 0x6B27F588 modifiers; // 0x14
        public int clickCount; // 0x18

        // ── Methods ──
        public void get_button(){} // RVA: 0x7FFAC4420210
        public void set_button(){} // RVA: 0x7FFAC336D8B0
        public void get_modifiers(){} // RVA: 0x7FFAC44202A0
        public void set_modifiers(){} // RVA: 0x7FFAC4420230
        public void get_clickCount(){} // RVA: 0x7FFAC49C7500
        public void Equals(){} // RVA: 0x7FFAC98F04C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BA52B0
        public void Matches(){} // RVA: 0x7FFAC9BA5490 | overloaded x2
        public void HasModifiers(){} // RVA: 0x7FFAC9BA5560 | overloaded x2
        public void MatchModifiers(){} // RVA: 0x7FFAC9BA5650
    }

    public class MeshBuilderNative : Object
    {
        // ── Methods ──
        public void MakeBorder(){} // RVA: 0x7FFAC9BA5F70
        public void MakeSolidRect(){} // RVA: 0x7FFAC9BA5FF0
        public void MakeTexturedRect(){} // RVA: 0x7FFAC9BA6070
        public void MakeVectorGraphicsStretchBackground(){} // RVA: 0x7FFAC9BA60F0
        public void MakeVectorGraphics9SliceBackground(){} // RVA: 0x7FFAC9BA6200
        public void MakeBorder_Injected(){} // RVA: 0x7FFAC9BA62E0
        public void MakeSolidRect_Injected(){} // RVA: 0x7FFAC9BA6350
        public void MakeTexturedRect_Injected(){} // RVA: 0x7FFAC9BA63C0
        public void MakeVectorGraphicsStretchBackground_Injected(){} // RVA: 0x7FFAC9BA6430
        public void MakeVectorGraphics9SliceBackground_Injected(){} // RVA: 0x7FFAC9BA64C0
    }

    public class MeshGenerationContext : Object
    {
        public UnityEngine.UIElements.Painter2D painter2D; // 0x10
        public Unity.Profiling.ProfilerMarker hasPainter2D;
        public Unity.Profiling.ProfilerMarker s_DrawVectorImageMarker; // 0x8
        public UnityEngine.UIElements.IStylePainter painter; // 0x18

        // ── Methods ──
        public void get_painter2D(){} // RVA: 0x7FFAC9BCD700
        public void get_hasPainter2D(){} // RVA: 0x7FFAC34D2B40
        public void .ctor(){} // RVA: 0x7FFAC2F87E80
        public void .cctor(){} // RVA: 0x7FFAC9BCD7B0
    }

    public class MeshGenerationContextUtils : Object
    {
        // ── Methods ──
        public void Rectangle(){} // RVA: 0x7FFAC9BCA6B0
        public void Text(){} // RVA: 0x7FFAC9BCA810
        public void ConvertBorderRadiusPercentToPoints(){} // RVA: 0x7FFAC9BCA8E0
        public void GetVisualElementRadii(){} // RVA: 0x7FFAC9BCA940
        public void AdjustBackgroundSizeForBorders(){} // RVA: 0x7FFAC9BCABF0
    }

    public class MeshWriteData : Object
    {
        public Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex> vertexCount; // 0x10
        public Unity.Collections.NativeSlice`1<ushort> indexCount; // 0x20
        public UnityEngine.Rect uvRegion; // 0x30
        public int currentIndex; // 0x40
        public int currentVertex; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_vertexCount(){} // RVA: 0x7FFAC9BCA250
        public void get_indexCount(){} // RVA: 0x7FFAC9BCA290
        public void get_uvRegion(){} // RVA: 0x7FFAC98F7240
        public void SetNextVertex(){} // RVA: 0x7FFAC9BCA2D0
        public void SetNextIndex(){} // RVA: 0x7FFAC9BCA380
        public void SetAllVertices(){} // RVA: 0x7FFAC9BCA410
        public void SetAllIndices(){} // RVA: 0x7FFAC9BCA4D0
        public void Reset(){} // RVA: 0x7FFAC9BCA5C0 | overloaded x2
    }

    public class MeshWriteDataInterface : ValueType
    {
        public UIntPtr vertices; // 0x10
        public UIntPtr indices; // 0x18
        public int vertexCount; // 0x20
        public int indexCount; // 0x24
    }

    public class MinMaxSlider : BaseField`1
    {
        public UnityEngine.UIElements.VisualElement dragElement; // 0x440
        public UnityEngine.UIElements.VisualElement dragMinThumb; // 0x448
        public UnityEngine.UIElements.VisualElement dragMaxThumb; // 0x450
        public UnityEngine.UIElements.ClampedDragger`1<float> clampedDragger; // 0x458
        public UnityEngine.Vector2 minValue; // 0x460
        public UnityEngine.Vector2 maxValue; // 0x468
        public UnityEngine.Rect value; // 0x470
        public UnityEngine.Rect lowLimit; // 0x480
        public 0x6B117F48 highLimit; // 0x490
        public float m_MinLimit; // 0x494
        public float m_MaxLimit; // 0x498
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string trackerUssClassName; // 0x18
        public string draggerUssClassName; // 0x20
        public string minThumbUssClassName; // 0x28
        public string maxThumbUssClassName; // 0x30

        // ── Methods ──
        public void get_dragElement(){} // RVA: 0x7FFAC39C4300
        public void set_dragElement(){} // RVA: 0x7FFAC39BD310
        public void get_dragMinThumb(){} // RVA: 0x7FFAC39BD8C0
        public void set_dragMinThumb(){} // RVA: 0x7FFAC39C6BC0
        public void get_dragMaxThumb(){} // RVA: 0x7FFAC39B43E0
        public void set_dragMaxThumb(){} // RVA: 0x7FFAC39B06B0
        public void get_clampedDragger(){} // RVA: 0x7FFAC39C3E40
        public void set_clampedDragger(){} // RVA: 0x7FFAC39C30B0
        public void get_minValue(){} // RVA: 0x7FFAC9B3FC90
        public void set_minValue(){} // RVA: 0x7FFAC9B3FCC0
        public void get_maxValue(){} // RVA: 0x7FFAC9B3FD40
        public void set_maxValue(){} // RVA: 0x7FFAC9B3FD70
        public void get_value(){} // RVA: 0x7FFAC9B3FDF0
        public void set_value(){} // RVA: 0x7FFAC9B3FE40
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9B3FEA0
        public void get_lowLimit(){} // RVA: 0x7FFAC9B3FF10
        public void set_lowLimit(){} // RVA: 0x7FFAC9B3FF20
        public void get_highLimit(){} // RVA: 0x7FFAC9B40020
        public void set_highLimit(){} // RVA: 0x7FFAC9B40030
        public void .ctor(){} // RVA: 0x7FFAC9B40170 | overloaded x2
        public void ClampValues(){} // RVA: 0x7FFAC9B40A70
        public void UpdateDragElementPosition(){} // RVA: 0x7FFAC9B40B70 | overloaded x2
        public void SliderLerpUnclamped(){} // RVA: 0x7FFAC9B418A0
        public void SliderNormalizeValue(){} // RVA: 0x7FFAC9B418C0
        public void ComputeValueFromPosition(){} // RVA: 0x7FFAC9B418E0
        public void ExecuteDefaultAction(){} // RVA: 0x7FFAC9B41A00
        public void SetSliderValueFromDrag(){} // RVA: 0x7FFAC9B41B50
        public void SetSliderValueFromClick(){} // RVA: 0x7FFAC9B41BE0
        public void ComputeValueDragStateNoThumb(){} // RVA: 0x7FFAC9B42050
        public void ComputeValueFromDraggingThumb(){} // RVA: 0x7FFAC9B42120
        public void UpdateMixedValueContent(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9B42340
    }

    public class MouseCaptureController : Object
    {
        // ── Methods ──
        public void HasMouseCapture(){} // RVA: 0x7FFAC9BA5780
        public void CaptureMouse(){} // RVA: 0x7FFAC9BA5880
        public void ReleaseMouse(){} // RVA: 0x7FFAC9BA59B0
    }

    public class MouseCaptureDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFAC9B85910
        public void DispatchEvent(){} // RVA: 0x7FFAC9B85990
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MouseCaptureEvent : MouseCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B7D570
        public void .ctor(){} // RVA: 0x7FFAC9B7D660
    }

    public class MouseCaptureEventBase`1 : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class MouseCaptureOutEvent : MouseCaptureEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B7D310
        public void .ctor(){} // RVA: 0x7FFAC9B7D400
    }

    public class MouseDownEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B86C60
        public void Init(){} // RVA: 0x7FFAC9B86D50
        public void LocalInit(){} // RVA: 0x7FFAC9B86E10
        public void .ctor(){} // RVA: 0x7FFAC9B86E20
        public void MakeFromPointerEvent(){} // RVA: 0x7FFAC9B86E70
        public void GetPooled(){} // RVA: 0x7FFAC9B86FE0 | overloaded x2
    }

    public class MouseEnterEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B88270
        public void Init(){} // RVA: 0x7FFAC9B88360
        public void LocalInit(){} // RVA: 0x7FFAC9B88420
        public void .ctor(){} // RVA: 0x7FFAC9B88430
    }

    public class MouseEnterWindowEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B888C0
        public void Init(){} // RVA: 0x7FFAC9B889B0
        public void LocalInit(){} // RVA: 0x7FFAC9B88A70
        public void .ctor(){} // RVA: 0x7FFAC9B88A80
        public void PostDispatch(){} // RVA: 0x7FFAC9B88AD0
    }

    public class MouseEventBase`1 : EventBase`1
    {
        public 0x6B27F588 modifiers;
        public UnityEngine.Vector2 mousePosition;
        public UnityEngine.Vector2 localMousePosition;
        public UnityEngine.Vector2 mouseDelta;
        public int clickCount;
        public int button;
        public int pressedButtons;
        public bool shiftKey;
        public bool ctrlKey;
        public UnityEngine.UIElements.IPointerEvent commandKey;

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7FFAC2C59960
        public void set_modifiers(){} // RVA: 0x7FFAC2C70ED0
        public void get_mousePosition(){} // RVA: 0x7FFAC2C58E90
        public void set_mousePosition(){} // RVA: 0x7FFAC2C7F3E0
        public void get_localMousePosition(){} // RVA: 0x7FFAC2C58E90
        public void set_localMousePosition(){} // RVA: 0x7FFAC2C7F3E0
        public void get_mouseDelta(){} // RVA: 0x7FFAC2C58E90
        public void set_mouseDelta(){} // RVA: 0x7FFAC2C7F3E0
        public void get_clickCount(){} // RVA: 0x7FFAC2C59960
        public void set_clickCount(){} // RVA: 0x7FFAC2C70ED0
        public void get_button(){} // RVA: 0x7FFAC2C59960
        public void set_button(){} // RVA: 0x7FFAC2C70ED0
        public void get_pressedButtons(){} // RVA: 0x7FFAC2C59960
        public void set_pressedButtons(){} // RVA: 0x7FFAC2C70ED0
        public void get_shiftKey(){} // RVA: 0x7FFAC2C59D00
        public void get_ctrlKey(){} // RVA: 0x7FFAC2C59D00
        public void get_commandKey(){} // RVA: 0x7FFAC2C59D00
        public void get_altKey(){} // RVA: 0x7FFAC2C59D00
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7FFAC2C59D00
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7FFAC2C71060
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7FFAC2C59D00
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7FFAC2C71060
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7FFAC2C58E90
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7FFAC2C70A40
        public void Init(){} // RVA: 0x7FFAC2C70980
        public void LocalInit(){} // RVA: 0x7FFAC2C70980
        public void get_currentTarget(){} // RVA: 0x7FFAC2C58E90
        public void set_currentTarget(){} // RVA: 0x7FFAC2C70A40
        public void PreDispatch(){} // RVA: 0x7FFAC2C70A40
        public void PostDispatch(){} // RVA: 0x7FFAC2C70A40
        public void GetPooled(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class MouseEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFAC9B860C0
        public void DispatchEvent(){} // RVA: 0x7FFAC9B86110
        public void SendEventToTarget(){} // RVA: 0x7FFAC9B86380
        public void SendEventToRegularTarget(){} // RVA: 0x7FFAC9B864C0
        public void SendEventToIMGUIContainer(){} // RVA: 0x7FFAC9B865E0
        public void SetBestTargetForEvent(){} // RVA: 0x7FFAC9B867F0
        public void UpdateElementUnderMouse(){} // RVA: 0x7FFAC9B868A0
        public void IsDone(){} // RVA: 0x7FFAC9B86BD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MouseEventsHelper : Object
    {
        // ── Methods ──
        public void SendEnterLeave(){} // RVA: 0x7FFAC2E8DC40
        public void SendMouseOverMouseOut(){} // RVA: 0x7FFAC9B8A290
    }

    public class MouseLeaveEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B885A0
        public void Init(){} // RVA: 0x7FFAC9B88690
        public void LocalInit(){} // RVA: 0x7FFAC9B88420
        public void .ctor(){} // RVA: 0x7FFAC9B88750
    }

    public class MouseLeaveWindowEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B88D00
        public void Init(){} // RVA: 0x7FFAC9B88DF0
        public void LocalInit(){} // RVA: 0x7FFAC9B88EF0
        public void .ctor(){} // RVA: 0x7FFAC9B88F40
        public void GetPooled(){} // RVA: 0x7FFAC9B88FC0
        public void PostDispatch(){} // RVA: 0x7FFAC9B890E0
    }

    public class MouseManipulator : Manipulator
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.ManipulatorActivationFilter> activators; // 0x18
        public UnityEngine.UIElements.ManipulatorActivationFilter m_currentActivator; // 0x20

        // ── Methods ──
        public void get_activators(){} // RVA: 0x7FFAC2F247C0
        public void set_activators(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9BA5B20
        public void CanStartManipulation(){} // RVA: 0x7FFAC9BA5BE0
        public void CanStopManipulation(){} // RVA: 0x7FFAC9BA5E00
    }

    public class MouseMoveEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B87680
        public void Init(){} // RVA: 0x7FFAC9B87770
        public void LocalInit(){} // RVA: 0x7FFAC9B87830
        public void .ctor(){} // RVA: 0x7FFAC9B87840
        public void GetPooled(){} // RVA: 0x7FFAC9B87890
    }

    public class MouseOutEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B89580
        public void .ctor(){} // RVA: 0x7FFAC9B89670
    }

    public class MouseOverEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B89340
        public void .ctor(){} // RVA: 0x7FFAC9B89430
    }

    public class MouseUpEvent : MouseEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B87150
        public void Init(){} // RVA: 0x7FFAC9B87240
        public void LocalInit(){} // RVA: 0x7FFAC9B86E10
        public void .ctor(){} // RVA: 0x7FFAC9B87300
        public void MakeFromPointerEvent(){} // RVA: 0x7FFAC9B87350
        public void GetPooled(){} // RVA: 0x7FFAC9B87510 | overloaded x3
    }

    public class MultiColumnController : Object
    {
        public UnityEngine.PropertyName header;
        public UnityEngine.PropertyName bindableElementPropertyName; // 0x4
        public string baseUssClassName; // 0x8
        public string k_HeaderContainerViewDataKey; // 0x10
        public string headerContainerUssClassName; // 0x18
        public string rowContainerUssClassName; // 0x20
        public string cellUssClassName; // 0x28
        public string cellLabelUssClassName; // 0x30
        public string k_HeaderViewDataKey; // 0x38
        public System.Action columnSortingChanged; // 0x10
        public System.Action`2<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> headerContextMenuPopulateEvent; // 0x18
        public UnityEngine.UIElements.BaseVerticalCollectionView m_View; // 0x20
        public UnityEngine.UIElements.VisualElement m_HeaderContainer; // 0x28
        public UnityEngine.UIElements.Internal.MultiColumnCollectionHeader m_MultiColumnHeader; // 0x30

        // ── Methods ──
        public void add_columnSortingChanged(){} // RVA: 0x7FFAC9B49E30
        public void remove_columnSortingChanged(){} // RVA: 0x7FFAC9B49F20
        public void add_headerContextMenuPopulateEvent(){} // RVA: 0x7FFAC9B4A010
        public void remove_headerContextMenuPopulateEvent(){} // RVA: 0x7FFAC9B4A110
        public void get_header(){} // RVA: 0x7FFAC31D95E0
        public void .ctor(){} // RVA: 0x7FFAC9B4A210
        public void BindCellItem(){} // RVA: 0x7FFAC2E8DC40
        public void UnbindCellItem(){} // RVA: 0x7FFAC9B4AAC0
        public void DefaultMakeCellItem(){} // RVA: 0x7FFAC9B4AB00
        public void DefaultBindCellItem(){} // RVA: 0x7FFAC2E8DC40
        public void MakeItem(){} // RVA: 0x7FFAC9B4ABD0
        public void BindItem(){} // RVA: 0x7FFAC2E8DC40
        public void UnbindItem(){} // RVA: 0x7FFAC9B4AF60
        public void DestroyItem(){} // RVA: 0x7FFAC9B4B2F0
        public void PrepareView(){} // RVA: 0x7FFAC9B4B6A0
        public void Dispose(){} // RVA: 0x7FFAC9B4BAA0
        public void OnHorizontalScrollerValueChanged(){} // RVA: 0x7FFAC9B4C650
        public void OnViewportGeometryChanged(){} // RVA: 0x7FFAC9B4C790
        public void OnColumnContainerGeometryChanged(){} // RVA: 0x7FFAC9B4CA20
        public void UpdateContentContainer(){} // RVA: 0x7FFAC9B4CA30
        public void OnColumnSortingChanged(){} // RVA: 0x7FFAC3203950
        public void OnContextMenuPopulateEvent(){} // RVA: 0x7FFAC7797E30
        public void OnColumnResized(){} // RVA: 0x7FFAC9B4CBE0
        public void OnColumnAdded(){} // RVA: 0x7FFAC9B4CF80
        public void OnColumnRemoved(){} // RVA: 0x7FFAC9B4CF80
        public void OnColumnReordered(){} // RVA: 0x7FFAC9B4CFA0
        public void OnColumnsChanged(){} // RVA: 0x7FFAC9B4CFE0
        public void OnColumnChanged(){} // RVA: 0x7FFAC9B4D020
        public void OnViewDataRestored(){} // RVA: 0x7FFAC9B4CF80
        public void .cctor(){} // RVA: 0x7FFAC9B4D060
    }

    public class MultiColumnListView : BaseListView
    {
        public UnityEngine.UIElements.Columns viewController; // 0x540
        public bool columns; // 0x548
        public UnityEngine.UIElements.SortColumnDescriptions sortColumnDescriptions; // 0x550
        public System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription> sortingEnabled; // 0x558
        public System.Action columnSortingChanged; // 0x560
        public System.Action`2<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> headerContextMenuPopulateEvent; // 0x568

        // ── Methods ──
        public void get_viewController(){} // RVA: 0x7FFAC9B4D5A0
        public void get_columns(){} // RVA: 0x7FFAC39B5F30
        public void set_columns(){} // RVA: 0x7FFAC9B4D630
        public void get_sortColumnDescriptions(){} // RVA: 0x7FFAC39C57A0
        public void set_sortColumnDescriptions(){} // RVA: 0x7FFAC9B4D720
        public void set_sortingEnabled(){} // RVA: 0x7FFAC9B4D820
        public void .ctor(){} // RVA: 0x7FFAC9B4D900 | overloaded x2
        public void CreateViewController(){} // RVA: 0x7FFAC9B4DB10
        public void SetViewController(){} // RVA: 0x7FFAC9B4DC20
        public void CreateVirtualizationController(){} // RVA: 0x7FFAC9B4DE70
        public void RaiseColumnSortingChanged(){} // RVA: 0x7FFAC9B4DEB0
        public void RaiseHeaderContextMenuPopulate(){} // RVA: 0x7FFAC9B4DED0
    }

    public class MultiColumnListViewController : BaseListViewController
    {
        public UnityEngine.UIElements.MultiColumnController columnController; // 0x48

        // ── Methods ──
        public void get_columnController(){} // RVA: 0x7FFAC2F9C730
        public void get_header(){} // RVA: 0x7FFAC9A8A9F0
        public void .ctor(){} // RVA: 0x7FFAC9A8AA00
        public void InvokeMakeItem(){} // RVA: 0x7FFAC9A8AAD0
        public void MakeItem(){} // RVA: 0x7FFAC9A8AC10
        public void BindItem(){} // RVA: 0x7FFAC9A8AC30
        public void UnbindItem(){} // RVA: 0x7FFAC9A8ACD0
        public void DestroyItem(){} // RVA: 0x7FFAC9A8ACF0
        public void PrepareView(){} // RVA: 0x7FFAC9A8AD10
        public void Dispose(){} // RVA: 0x7FFAC9A8AEA0
        public void UpdateReorderClassList(){} // RVA: 0x7FFAC9A8B090
    }

    public class MultiColumnTreeView : BaseTreeView
    {
        public UnityEngine.UIElements.Columns viewController; // 0x4C0
        public bool columns; // 0x4C8
        public UnityEngine.UIElements.SortColumnDescriptions sortColumnDescriptions; // 0x4D0
        public System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription> sortingEnabled; // 0x4D8
        public System.Action columnSortingChanged; // 0x4E0
        public System.Action`2<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> headerContextMenuPopulateEvent; // 0x4E8

        // ── Methods ──
        public void get_viewController(){} // RVA: 0x7FFAC9B4E470
        public void get_columns(){} // RVA: 0x7FFAC39CA190
        public void set_columns(){} // RVA: 0x7FFAC9B4E500
        public void get_sortColumnDescriptions(){} // RVA: 0x7FFAC39BEF50
        public void set_sortColumnDescriptions(){} // RVA: 0x7FFAC9B4E5F0
        public void set_sortingEnabled(){} // RVA: 0x7FFAC9B4E6F0
        public void .ctor(){} // RVA: 0x7FFAC9B4E7D0 | overloaded x2
        public void CreateViewController(){} // RVA: 0x7FFAC9B4E9E0
        public void SetViewController(){} // RVA: 0x7FFAC9B4EA80
        public void CreateVirtualizationController(){} // RVA: 0x7FFAC9B4EDB0
        public void RaiseColumnSortingChanged(){} // RVA: 0x7FFAC9B4EDF0
        public void RaiseHeaderContextMenuPopulate(){} // RVA: 0x7FFAC9B4EE10
    }

    public class MultiColumnTreeViewController : BaseTreeViewController
    {
        public UnityEngine.UIElements.MultiColumnController columnController; // 0x58

        // ── Methods ──
        public void get_columnController(){} // RVA: 0x7FFAC2FE9500
        public void get_header(){} // RVA: 0x7FFAC9A8B180
        public void .ctor(){} // RVA: 0x7FFAC9A8B190
        public void InvokeMakeItem(){} // RVA: 0x7FFAC9A8B290
        public void MakeItem(){} // RVA: 0x7FFAC9A8B420
        public void BindItem(){} // RVA: 0x7FFAC9A8B440
        public void UnbindItem(){} // RVA: 0x7FFAC9A8B4E0
        public void DestroyItem(){} // RVA: 0x7FFAC9A8B500
        public void PrepareView(){} // RVA: 0x7FFAC9A8B520
        public void Dispose(){} // RVA: 0x7FFAC9A8B550
    }

}