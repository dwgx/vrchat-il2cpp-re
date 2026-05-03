// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 31
// Methods: 583

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Background : ValueType
    {
        public UnityEngine.Texture2D m_Texture; // 0x10
        public UnityEngine.Sprite m_Sprite; // 0x18
        public UnityEngine.RenderTexture m_RenderTexture; // 0x20
        public UnityEngine.UIElements.VectorImage m_VectorImage; // 0x28

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFE8348B260
        public void set_texture(){} // RVA: 0x7FFE87F7C3F0
        public void get_sprite(){} // RVA: 0x7FFE86A5E330
        public void set_sprite(){} // RVA: 0x7FFE87F7C660
        public void get_renderTexture(){} // RVA: 0x7FFE84022BE0
        public void set_renderTexture(){} // RVA: 0x7FFE87F7C8D0
        public void get_vectorImage(){} // RVA: 0x7FFE83BBC680
        public void set_vectorImage(){} // RVA: 0x7FFE87F7CB40
        public void FromTexture2D(){} // RVA: 0x7FFE87F7CDB0
        public void FromRenderTexture(){} // RVA: 0x7FFE87F7CE00
        public void FromSprite(){} // RVA: 0x7FFE87F7CE50
        public void FromVectorImage(){} // RVA: 0x7FFE87F7CEA0
        public void FromObject(){} // RVA: 0x7FFE87F7CEF0
        public void op_Equality(){} // RVA: 0x7FFE87F7D320
        public void op_Inequality(){} // RVA: 0x7FFE87F7D6F0
        public void Equals(){} // RVA: 0x7FFE87F7D770 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87F7D820
        public void ToString(){} // RVA: 0x7FFE87F7D8F0
    }

    public class BackgroundPosition : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE844568A0 | overloaded x2
        public void Initial(){} // RVA: 0x7FFE87E255E0
        public void Equals(){} // RVA: 0x7FFE87E256E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87E25720
        public void op_Equality(){} // RVA: 0x7FFE87E25750
        public void op_Inequality(){} // RVA: 0x7FFE87E257B0
        public void ToString(){} // RVA: 0x7FFE87E25830
    }

    public class BackgroundPropertyHelper : Object
    {
        // ── Methods ──
        public void ConvertScaleModeToBackgroundPosition(){} // RVA: 0x7FFE87E25910
        public void ConvertScaleModeToBackgroundRepeat(){} // RVA: 0x7FFE87E25940
        public void ConvertScaleModeToBackgroundSize(){} // RVA: 0x7FFE87E25950
        public void ResolveUnityBackgroundScaleMode(){} // RVA: 0x7FFE87E25A30
    }

    public class BackgroundRepeat : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8164E250
        public void Initial(){} // RVA: 0x7FFE87E25EF0
        public void Equals(){} // RVA: 0x7FFE87E25FA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87E25FC0
        public void op_Equality(){} // RVA: 0x7FFE87E25FE0
        public void op_Inequality(){} // RVA: 0x7FFE87E26000
        public void ToString(){} // RVA: 0x7FFE87E26020
    }

    public class BackgroundSize : ValueType
    {
        public 0x6651BAFC m_SizeType; // 0x10
        public UnityEngine.UIElements.Length m_X; // 0x14
        public UnityEngine.UIElements.Length m_Y; // 0x1C

        // ── Methods ──
        public void get_sizeType(){} // RVA: 0x7FFE8733C3B0
        public void set_sizeType(){} // RVA: 0x7FFE87E260F0
        public void get_x(){} // RVA: 0x7FFE86A62C50
        public void set_x(){} // RVA: 0x7FFE87E26120
        public void get_y(){} // RVA: 0x7FFE87E26130
        public void set_y(){} // RVA: 0x7FFE87E26140
        public void .ctor(){} // RVA: 0x7FFE87E260F0 | overloaded x2
        public void Initial(){} // RVA: 0x7FFE87E26160
        public void Equals(){} // RVA: 0x7FFE87E262D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87E26340
        public void op_Equality(){} // RVA: 0x7FFE87E263A0
        public void op_Inequality(){} // RVA: 0x7FFE87E26420
        public void ToString(){} // RVA: 0x7FFE87E264B0
    }

    public class BaseBoolField : BaseField`1
    {
        public UnityEngine.UIElements.Label m_Label; // 0x440

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E37FC0
        public void OnNavigationSubmit(){} // RVA: 0x7FFE87E384E0
        public void get_text(){} // RVA: 0x7FFE87E38520
        public void set_text(){} // RVA: 0x7FFE87E38550
        public void InitLabel(){} // RVA: 0x7FFE87E38640
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE87E38750
        public void OnClickEvent(){} // RVA: 0x7FFE87E388A0
        public void ToggleValue(){} // RVA: 0x7FFE87E38AB0
        public void UpdateMixedValueContent(){} // RVA: 0x7FFE87E38AF0
        public void RegisterEditingCallbacks(){} // RVA: 0x7FFE87E38CE0
        public void UnregisterEditingCallbacks(){} // RVA: 0x7FFE87E38DE0
    }

    public class BaseCompositeField`3 : BaseField`1
    {
        // ── Methods ──
        public void GetSpacer(){} // RVA: 0x7FFE80E2E2E0
        public void DescribeFields(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E4D070
        public void UpdateDisplay(){} // RVA: 0x7FFE80E45FE0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE810A1420
        public void OnViewDataReady(){} // RVA: 0x7FFE80E45FE0
        public void UpdateMixedValueContent(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class BaseFieldMouseDragger : Object
    {
        // ── Methods ──
        public void SetDragZone(){} // RVA: 0x7FFE87F3B890 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BaseFieldTraits`2 : UxmlTraits
    {
        // ── Methods ──
        public void Init(){}
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class BaseField`1 : BindableElement
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x7FFE860AAA00
        public void set_visualInput(){} // RVA: 0x7FFE860AAA40
        public void get_rawValue(){} // RVA: 0x7FFE81081080
        public void set_rawValue(){} // RVA: 0x7FFE860AAE70
        public void add_onValidateValue(){} // RVA: 0x7FFE860AAF40
        public void remove_onValidateValue(){} // RVA: 0x7FFE860AB0B0
        public void get_value(){} // RVA: 0x7FFE81081080
        public void set_value(){} // RVA: 0x7FFE860AB220
        public void get_labelElement(){} // RVA: 0x7FFE860AB720
        public void set_labelElement(){} // RVA: 0x7FFE860AB760
        public void get_label(){} // RVA: 0x7FFE860AB7E0
        public void set_label(){} // RVA: 0x7FFE860AB830
        public void get_showMixedValue(){} // RVA: 0x7FFE860ABB40
        public void set_showMixedValue(){} // RVA: 0x7FFE860ABB80
        public void get_mixedValueLabel(){} // RVA: 0x7FFE860ABC10
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0x7FFE860ABE60
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0x7FFE860ABEA0
        public void .ctor(){} // RVA: 0x7FFE860AC2D0 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x7FFE860AC330
        public void OnDetachFromPanel(){} // RVA: 0x7FFE860AC6B0
        public void RegisterEditingCallbacks(){} // RVA: 0x7FFE860AC760
        public void UnregisterEditingCallbacks(){} // RVA: 0x7FFE860AC870
        public void StartEditing(){} // RVA: 0x7FFE860AC9D0
        public void EndEditing(){} // RVA: 0x7FFE860ACA40
        public void OnCustomStyleResolved(){} // RVA: 0x7FFE860ACAB0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x7FFE860ACFD0
        public void AlignLabel(){} // RVA: 0x7FFE860ACFF0
        public void ValidatedValue(){} // RVA: 0x7FFE81081080
        public void UpdateMixedValueContent(){} // RVA: 0x7FFE83FBE650
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE860AD7D0
        public void OnViewDataReady(){} // RVA: 0x7FFE860AD9E0
        public void GetTooltipRect(){} // RVA: 0x7FFE860ADE50
        public void .cctor(){} // RVA: 0x7FFE860ADF10
    }

    public class BaseListView : BaseVerticalCollectionView
    {
        public string k_SizeFieldLabel;
        public bool m_ShowBoundCollectionSize; // 0x4B0
        public bool m_ShowFoldoutHeader; // 0x4B1
        public string m_HeaderTitle; // 0x4B8
        public System.Action`1<System.Collections.Generic.IEnumerable`1<int>> itemsAdded; // 0x4C0
        public System.Action`1<System.Collections.Generic.IEnumerable`1<int>> itemsRemoved; // 0x4C8
        public System.Action itemsSourceSizeChanged; // 0x4D0

        // ── Methods ──
        public void get_showBoundCollectionSize(){} // RVA: 0x7FFE87E38F10
        public void set_showBoundCollectionSize(){} // RVA: 0x7FFE87E38F20
        public void get_showFoldoutHeader(){} // RVA: 0x7FFE87E38F40
        public void set_showFoldoutHeader(){} // RVA: 0x7FFE87E38F50
        public void SetupArraySizeField(){} // RVA: 0x7FFE87E39380
        public void set_headerTitle(){} // RVA: 0x7FFE87E39800
        public void get_showAddRemoveFooter(){} // RVA: 0x7FFE87E39880
        public void set_showAddRemoveFooter(){} // RVA: 0x7FFE87E39890
        public void EnableFooter(){} // RVA: 0x7FFE87E398A0
        public void AddItems(){} // RVA: 0x7FFE87E39F90
        public void OnArraySizeFieldChanged(){} // RVA: 0x7FFE87E39FD0
        public void UpdateArraySizeField(){} // RVA: 0x7FFE87E3A2F0
        public void UpdateListViewLabel(){} // RVA: 0x7FFE87E3A3F0
        public void OnAddClicked(){} // RVA: 0x7FFE87E3A6B0
        public void OnRemoveClicked(){} // RVA: 0x7FFE87E3A890
        public void get_footer(){} // RVA: 0x7FFE81B208B0
        public void get_viewController(){} // RVA: 0x7FFE87E3AB00
        public void CreateVirtualizationController(){} // RVA: 0x7FFE87E3AB90
        public void SetViewController(){} // RVA: 0x7FFE87E3ABD0
        public void OnItemAdded(){} // RVA: 0x7FFE87E3B400
        public void OnItemsRemoved(){} // RVA: 0x7FFE87E3B420
        public void OnItemsSourceSizeChanged(){} // RVA: 0x7FFE87E3B440
        public void add_reorderModeChanged(){} // RVA: 0x7FFE87E3B510
        public void remove_reorderModeChanged(){} // RVA: 0x7FFE87E3B600
        public void get_reorderMode(){} // RVA: 0x7FFE87E3B6F0
        public void set_reorderMode(){} // RVA: 0x7FFE87E3B700
        public void CreateDragger(){} // RVA: 0x7FFE87E3B760
        public void CreateDragAndDropController(){} // RVA: 0x7FFE87E3B7E0
        public void .ctor(){} // RVA: 0x7FFE87E3B880
        public void PostRefresh(){} // RVA: 0x7FFE87E3B960
        public void HandleItemNavigation(){} // RVA: 0x7FFE87E3BA40
        public void .cctor(){} // RVA: 0x7FFE87E3BDA0
        public void <OnAddClicked>b__36_0(){} // RVA: 0x7FFE87E3CAA0
    }

    public class BaseListViewController : CollectionViewController
    {
        public System.Action itemsSourceSizeChanged; // 0x30

        // ── Methods ──
        public void add_itemsSourceSizeChanged(){} // RVA: 0x7FFE87E2C390
        public void remove_itemsSourceSizeChanged(){} // RVA: 0x7FFE87E2C480
        public void add_itemsAdded(){} // RVA: 0x7FFE87E2C570
        public void remove_itemsAdded(){} // RVA: 0x7FFE87E2C670
        public void add_itemsRemoved(){} // RVA: 0x7FFE87E2C770
        public void remove_itemsRemoved(){} // RVA: 0x7FFE87E2C870
        public void get_baseListView(){} // RVA: 0x7FFE87E2C970
        public void InvokeMakeItem(){} // RVA: 0x7FFE87E2CA00
        public void PostInitRegistration(){} // RVA: 0x7FFE87E2CC00
        public void InvokeBindItem(){} // RVA: 0x7FFE87E2CF20
        public void NeedsDragHandle(){} // RVA: 0x7FFE82E64CC0
        public void AddItems(){} // RVA: 0x7FFE87E2D1D0
        public void Move(){} // RVA: 0x7FFE87E2D800
        public void RemoveItem(){} // RVA: 0x7FFE87E2DA50
        public void RemoveItems(){} // RVA: 0x7FFE87E2DED0 | overloaded x2
        public void ClearItems(){} // RVA: 0x7FFE87E2E0A0
        public void RaiseOnSizeChanged(){} // RVA: 0x7FFE87E2E1C0
        public void RaiseItemsAdded(){} // RVA: 0x7FFE87E2E1E0
        public void RaiseItemsRemoved(){} // RVA: 0x7FFE85C283E0
        public void AddToArray(){} // RVA: 0x7FFE87E2E200
        public void RemoveFromArray(){} // RVA: 0x7FFE87E2E3E0
        public void Swap(){} // RVA: 0x7FFE87E2E590
        public void EnsureItemSourceCanBeResized(){} // RVA: 0x7FFE87E2E6D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void <AddItems>g__IsGenericList|15_0(){} // RVA: 0x7FFE87E2E810
    }

    public class BasePopupField`2 : BaseField`1
    {
        public System.Collections.Generic.List`1<T> m_Choices; // 0x440
        public UnityEngine.UIElements.TextElement m_TextElement; // 0x448

        // ── Methods ──
        public void get_textElement(){} // RVA: 0x7FFE861BECB0
        public void GetValueToDisplay(){} // RVA: 0x7FFE80E2E2E0
        public void GetListItemToDisplay(){} // RVA: 0x7FFE810A1420
        public void AddMenuItems(){} // RVA: 0x7FFE80E460A0
        public void set_choices(){} // RVA: 0x7FFE861BECE0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE861BEE30
        public void .ctor(){} // RVA: 0x7FFE861BEFA0
        public void OnPointerDownEvent(){} // RVA: 0x7FFE861BF8A0
        public void OnPointerMoveEvent(){} // RVA: 0x7FFE861BF8C0
        public void ContainsPointer(){} // RVA: 0x7FFE861BF960
        public void ProcessPointerDown(){} // RVA: 0x7FFE80E460A0
        public void OnNavigationSubmit(){} // RVA: 0x7FFE861BFA00
        public void ShowMenu(){} // RVA: 0x7FFE861BFA40
        public void UpdateMixedValueContent(){} // RVA: 0x7FFE861BFBF0
        public void .cctor(){} // RVA: 0x7FFE861BFEC0
    }

    public class BaseReorderableDragAndDropController : Object
    {
        public UnityEngine.UIElements.BaseVerticalCollectionView m_View; // 0x10

        // ── Methods ──
        public void GetSortedSelectedIds(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE87F17A60
        public void get_enableReordering(){} // RVA: 0x7FFE811E99D0
        public void set_enableReordering(){} // RVA: 0x7FFE811E99E0
        public void CanStartDrag(){} // RVA: 0x7FFE825CB0A0
        public void SetupDragAndDrop(){} // RVA: 0x7FFE87F17B80
        public void CompareId(){} // RVA: 0x7FFE840AC690
        public void HandleDragAndDrop(){} // RVA: 0x7FFE80E33B00
        public void OnDrop(){} // RVA: 0x7FFE80E460A0
        public void DragCleanup(){} // RVA: 0x7FFE810FB310
        public void HandleAutoExpand(){} // RVA: 0x7FFE810FB310
    }

    public class BaseRuntimePanel : Panel
    {
        public UnityEngine.GameObject m_SelectableGameObject; // 0x160
        public int s_CurrentRuntimePanelCounter;
        public int m_RuntimePanelCreationIndex; // 0x168
        public float m_SortingPriority; // 0x16C
        public int resolvedSortingIndex; // 0x170
        public System.Action destroyed; // 0x178
        public UnityEngine.Shader m_StandardWorldSpaceShader; // 0x180
        public bool m_DrawToCameras; // 0x188

        // ── Methods ──
        public void get_selectableGameObject(){} // RVA: 0x7FFE81624E50
        public void set_selectableGameObject(){} // RVA: 0x7FFE87F53270
        public void get_sortingPriority(){} // RVA: 0x7FFE87F53410
        public void set_sortingPriority(){} // RVA: 0x7FFE87F53420
        public void add_destroyed(){} // RVA: 0x7FFE87F534F0
        public void remove_destroyed(){} // RVA: 0x7FFE87F535E0
        public void .ctor(){} // RVA: 0x7FFE87F536D0
        public void Dispose(){} // RVA: 0x7FFE87F538D0
        public void get_standardWorldSpaceShader(){} // RVA: 0x7FFE87DA65F0
        public void get_drawToCameras(){} // RVA: 0x7FFE87F53A70
        public void set_drawToCameras(){} // RVA: 0x7FFE87F53A80
        public void get_targetDisplay(){} // RVA: 0x7FFE87F53B40
        public void set_targetDisplay(){} // RVA: 0x7FFE87F53B50
        public void get_screenRenderingWidth(){} // RVA: 0x7FFE87F53B60
        public void get_screenRenderingHeight(){} // RVA: 0x7FFE87F53BC0
        public void getScreenRenderingHeight(){} // RVA: 0x7FFE87F53C20
        public void getScreenRenderingWidth(){} // RVA: 0x7FFE87F53D10
        public void Repaint(){} // RVA: 0x7FFE87F53E00
        public void get_screenToPanelSpace(){} // RVA: 0x7FFE816611A0
        public void set_screenToPanelSpace(){} // RVA: 0x7FFE87F54400
        public void ScreenToPanel(){} // RVA: 0x7FFE87F54530 | overloaded x2
        public void AssignPanelToComponents(){} // RVA: 0x7FFE87F547D0
        public void PointerLeavesPanel(){} // RVA: 0x7FFE87F54BB0
        public void PointerEntersPanel(){} // RVA: 0x7FFE87F54C80
        public void .cctor(){} // RVA: 0x7FFE87F54D20
    }

    public class BaseSlider`1 : BaseField`1
    {
        public UnityEngine.UIElements.VisualElement _dragContainer;
        public UnityEngine.UIElements.VisualElement _dragElement;
        public UnityEngine.UIElements.VisualElement _trackElement;
        public UnityEngine.UIElements.VisualElement _dragBorderElement;
        public UnityEngine.UIElements.TextField _inputTextField;
        public bool m_IsEditingTextField;
        public T m_LowValue;
        public T m_HighValue;
        public float m_PageSize;
        public bool m_ShowInputField;
        public bool _clamped;
        public UnityEngine.UIElements.ClampedDragger`1<T> _clampedDragger;
        public UnityEngine.Rect m_DragElementStartPos;
        public 0x6650E31C m_Direction;

        // ── Methods ──
        public void get_dragContainer(){} // RVA: 0x7FFE80E2E2E0
        public void set_dragContainer(){} // RVA: 0x7FFE80E460A0
        public void get_dragElement(){} // RVA: 0x7FFE80E2E2E0
        public void set_dragElement(){} // RVA: 0x7FFE80E460A0
        public void get_trackElement(){} // RVA: 0x7FFE80E2E2E0
        public void set_trackElement(){} // RVA: 0x7FFE80E460A0
        public void get_dragBorderElement(){} // RVA: 0x7FFE80E2E2E0
        public void set_dragBorderElement(){} // RVA: 0x7FFE80E460A0
        public void get_inputTextField(){} // RVA: 0x7FFE80E2E2E0
        public void set_inputTextField(){} // RVA: 0x7FFE80E460A0
        public void get_lowValue(){} // RVA: 0x7FFE810A1420
        public void set_lowValue(){} // RVA: 0x7FFE810A1420
        public void get_highValue(){} // RVA: 0x7FFE810A1420
        public void set_highValue(){} // RVA: 0x7FFE810A1420
        public void SetHighValueWithoutNotify(){} // RVA: 0x7FFE810A1420
        public void get_pageSize(){} // RVA: 0x7FFE80E42E10
        public void set_pageSize(){} // RVA: 0x7FFE80E53B80
        public void get_showInputField(){} // RVA: 0x7FFE80E2F150
        public void set_showInputField(){} // RVA: 0x7FFE80E466C0
        public void get_clamped(){} // RVA: 0x7FFE80E2F150
        public void set_clamped(){} // RVA: 0x7FFE80E466C0
        public void get_clampedDragger(){} // RVA: 0x7FFE80E2E2E0
        public void set_clampedDragger(){} // RVA: 0x7FFE80E460A0
        public void Clamp(){} // RVA: 0x7FFE810A1420
        public void GetClampedValue(){} // RVA: 0x7FFE810A1420
        public void get_value(){} // RVA: 0x7FFE810A1420
        public void set_value(){} // RVA: 0x7FFE810A1420
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE810A1420
        public void UnityEngine.UIElements.IValueField<TValueType>.StartDragging(){} // RVA: 0x7FFE80E45FE0
        public void UnityEngine.UIElements.IValueField<TValueType>.StopDragging(){} // RVA: 0x7FFE80E45FE0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE810A1420
        public void get_direction(){} // RVA: 0x7FFE80E2EDB0
        public void set_direction(){} // RVA: 0x7FFE80E46530
        public void get_inverted(){} // RVA: 0x7FFE80E2F150
        public void set_inverted(){} // RVA: 0x7FFE80E466C0
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GetClosestPowerOfTen(){} // RVA: 0x7FFE80E43FC0
        public void RoundToMultipleOf(){}
        public void ClampValue(){} // RVA: 0x7FFE80E45FE0
        public void SliderLerpUnclamped(){} // RVA: 0x7FFE810A1420
        public void SliderNormalizeValue(){} // RVA: 0x7FFE810A1420
        public void ParseStringToValue(){} // RVA: 0x7FFE810A1420
        public void ComputeValueFromKey(){} // RVA: 0x7FFE810A1420
        public void SliderLerpDirectionalUnclamped(){} // RVA: 0x7FFE810A1420
        public void SetSliderValueFromDrag(){} // RVA: 0x7FFE80E45FE0
        public void ComputeValueAndDirectionFromDrag(){} // RVA: 0x7FFE80E54240
        public void SetSliderValueFromClick(){} // RVA: 0x7FFE80E45FE0
        public void OnKeyDown(){} // RVA: 0x7FFE80E460A0
        public void OnNavigationMove(){} // RVA: 0x7FFE80E460A0
        public void ComputeValueAndDirectionFromClick(){}
        public void AdjustDragElement(){} // RVA: 0x7FFE80E53B80
        public void UpdateDragElementPosition(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void OnViewDataReady(){} // RVA: 0x7FFE80E45FE0
        public void SameValues(){} // RVA: 0x7FFE810A1420
        public void ExecuteDefaultAction(){} // RVA: 0x7FFE80E460A0
        public void UpdateTextFieldVisibility(){} // RVA: 0x7FFE80E45FE0
        public void UpdateTextFieldValue(){} // RVA: 0x7FFE80E45FE0
        public void OnTextFieldFocusIn(){} // RVA: 0x7FFE80E460A0
        public void OnTextFieldFocusOut(){} // RVA: 0x7FFE80E460A0
        public void OnInputNavigationMoveEvent(){} // RVA: 0x7FFE80E460A0
        public void OnTextFieldValueChange(){} // RVA: 0x7FFE80E460A0
        public void UpdateMixedValueContent(){} // RVA: 0x7FFE80E45FE0
        public void RegisterEditingCallbacks(){} // RVA: 0x7FFE80E45FE0
        public void UnregisterEditingCallbacks(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class BaseTreeView : BaseVerticalCollectionView
    {
        public string ussClassName;
        public string itemUssClassName; // 0x8
        public string itemToggleUssClassName; // 0x10
        public string itemIndentsContainerUssClassName; // 0x18

        // ── Methods ──
        public void get_itemsSource(){} // RVA: 0x7FFE87E3D4E0
        public void get_viewController(){} // RVA: 0x7FFE87E3D520
        public void CreateVirtualizationController(){} // RVA: 0x7FFE87E3D5B0
        public void SetViewController(){} // RVA: 0x7FFE87E3D5F0
        public void OnItemIndexChanged(){} // RVA: 0x7FFE87E3D710
        public void CreateDragAndDropController(){} // RVA: 0x7FFE87E3D720
        public void get_autoExpand(){} // RVA: 0x7FFE87E38F10
        public void set_autoExpand(){} // RVA: 0x7FFE87E3D8F0
        public void get_expandedItemIds(){} // RVA: 0x7FFE81B15410
        public void set_expandedItemIds(){} // RVA: 0x7FFE81B23EC0
        public void .ctor(){} // RVA: 0x7FFE87E3D940 | overloaded x2
        public void OnViewDataReady(){} // RVA: 0x7FFE87E3DB60
        public void HandleItemNavigation(){} // RVA: 0x7FFE87E3DBE0
        public void SetSelectionById(){} // RVA: 0x7FFE87E3E360 | overloaded x2
        public void SetSelectionInternalById(){} // RVA: 0x7FFE87E3E4B0
        public void GetItemIndex(){} // RVA: 0x7FFE87E3E610
        public void IsExpanded(){} // RVA: 0x7FFE87E3E7F0
        public void CollapseItem(){} // RVA: 0x7FFE87E3E820
        public void ExpandItem(){} // RVA: 0x7FFE87E3E880
        public void OnTreeViewPointerUp(){} // RVA: 0x7FFE87E3E8D0
        public void IsExpandedByIndex(){} // RVA: 0x7FFE87E3E920
        public void CollapseItemByIndex(){} // RVA: 0x7FFE87E3E950
        public void ExpandItemByIndex(){} // RVA: 0x7FFE87E3E9D0
        public void .cctor(){} // RVA: 0x7FFE87E3EA60
        public void <SetSelectionInternalById>b__47_0(){} // RVA: 0x7FFE87E3EE40
    }

    public class BaseTreeViewController : CollectionViewController
    {
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.UIElements.TreeItem> m_TreeItems; // 0x30
        public System.Collections.Generic.List`1<int> m_RootIndices; // 0x38

        // ── Methods ──
        public void get_baseTreeView(){} // RVA: 0x7FFE87E2E8E0
        public void get_itemsSource(){} // RVA: 0x7FFE810FE7C0
        public void set_itemsSource(){} // RVA: 0x7FFE87E2E970
        public void RebuildTree(){} // RVA: 0x7FFE87E2E9C0
        public void GetRootItemIds(){} // RVA: 0x7FFE87CC7F60
        public void GetAllItemIds(){} // RVA: 0x7FFE80E2E390
        public void GetParentId(){} // RVA: 0x7FFE80E35520
        public void GetChildrenIds(){} // RVA: 0x7FFE80E3D230
        public void Move(){}
        public void InvokeMakeItem(){} // RVA: 0x7FFE87E2ED60
        public void InvokeBindItem(){} // RVA: 0x7FFE87E2EE30
        public void InvokeDestroyItem(){} // RVA: 0x7FFE87E2EF50
        public void PostInitRegistration(){} // RVA: 0x7FFE87E2F280
        public void OnItemPointerUp(){} // RVA: 0x7FFE87E2F700
        public void OnToggleValueChanged(){} // RVA: 0x7FFE87E2FD50
        public void GetIndexForId(){} // RVA: 0x7FFE87E2FF30
        public void GetIdForIndex(){} // RVA: 0x7FFE87E30010
        public void HasChildren(){} // RVA: 0x7FFE87E300C0
        public void Exists(){} // RVA: 0x7FFE87E30170
        public void HasChildrenByIndex(){} // RVA: 0x7FFE87E301E0
        public void GetChildrenIdsByIndex(){} // RVA: 0x7FFE87E302E0
        public void GetChildIndexForId(){} // RVA: 0x7FFE87E30390
        public void GetIndentationDepth(){} // RVA: 0x7FFE87E30560
        public void GetIndentationDepthByIndex(){} // RVA: 0x7FFE87E305C0
        public void CanChangeExpandedState(){} // RVA: 0x7FFE82E64CC0
        public void IsExpanded(){} // RVA: 0x7FFE87E30630
        public void IsExpandedByIndex(){} // RVA: 0x7FFE87E306F0
        public void ExpandItemByIndex(){} // RVA: 0x7FFE87E307B0
        public void ExpandItem(){} // RVA: 0x7FFE87E31020
        public void CollapseItemByIndex(){} // RVA: 0x7FFE87E31200
        public void CollapseItem(){} // RVA: 0x7FFE87E31710
        public void RegenerateWrappers(){} // RVA: 0x7FFE87E318A0
        public void CreateWrappers(){} // RVA: 0x7FFE87E319F0
        public void IsIndexValid(){} // RVA: 0x7FFE87E31F30
        public void RaiseItemParentChanged(){} // RVA: 0x7FFE87E31FA0
        public void .ctor(){} // RVA: 0x7FFE87E31FC0
        public void .cctor(){} // RVA: 0x7FFE87E32330
    }

    public class BaseUxmlFactory`2 : Object
    {
        public T m_Traits;
        public object field_1; // 0x57A
        public object field_2; // 0x57B
        public object field_3; // 0x57C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void get_uxmlName(){} // RVA: 0x7FFE80E2E2E0
        public void get_uxmlNamespace(){} // RVA: 0x7FFE80E2E2E0
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFE80E2E2E0
        public void get_uxmlType(){} // RVA: 0x7FFE80E2E2E0
        public void AcceptsAttributeBag(){}
    }

    public class BaseUxmlTraits : Object
    {
        public bool _canHaveAnyAttribute; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE814B8390
        public void set_canHaveAnyAttribute(){} // RVA: 0x7FFE811C55F0
    }

    public class BaseVerticalCollectionView : BindableElement
    {
        public Unity.Profiling.ProfilerMarker k_RefreshMarker;
        public Unity.Profiling.ProfilerMarker k_RebuildMarker; // 0x8
        public System.Action`1<System.Collections.Generic.IEnumerable`1<object>> itemsChosen; // 0x3D8
        public System.Action`1<System.Collections.Generic.IEnumerable`1<object>> selectionChanged; // 0x3E0
        public System.Action`1<System.Collections.Generic.IEnumerable`1<int>> selectedIndicesChanged; // 0x3E8
        public System.Action`2<int,int> itemIndexChanged; // 0x3F0
        public System.Action itemsSourceChanged; // 0x3F8
        public System.Action selectionNotChanged; // 0x400
        public System.Func`2<UnityEngine.UIElements.CanStartDragArgs,bool> canStartDrag; // 0x408
        public System.Func`2<UnityEngine.UIElements.SetupDragAndDropArgs,UnityEngine.UIElements.StartDragArgs> setupDragAndDrop; // 0x410
        public System.Func`2<UnityEngine.UIElements.HandleDragAndDropArgs,0x6651390C> dragAndDropUpdate; // 0x418
        public System.Func`2<UnityEngine.UIElements.HandleDragAndDropArgs,0x6651390C> handleDrop; // 0x420
        public 0x665186BC m_SelectionType; // 0x428
        public System.Collections.Generic.List`1<UnityEngine.UIElements.ReusableCollectionItem> k_EmptyItems; // 0x10
        public bool m_HorizontalScrollingEnabled; // 0x42C
        public 0x6650E52C m_ShowAlternatingRowBackgrounds; // 0x430
        public int s_DefaultItemHeight; // 0x18
        public float m_FixedItemHeight; // 0x434

        // ── Methods ──
        public void HasCanStartDrag(){} // RVA: 0x7FFE87E3F0F0
        public void RaiseCanStartDrag(){} // RVA: 0x7FFE87E3F100
        public void RaiseSetupDragAndDrop(){} // RVA: 0x7FFE87E3F1C0
        public void RaiseHandleDragAndDrop(){} // RVA: 0x7FFE87E3F2D0
        public void RaiseDrop(){} // RVA: 0x7FFE87E3F3B0
        public void get_itemsSource(){} // RVA: 0x7FFE87E3F490
        public void set_itemsSource(){} // RVA: 0x7FFE87E3F4C0
        public void get_contentContainer(){} // RVA: 0x7FFE813240E0
        public void get_selectionType(){} // RVA: 0x7FFE87E3F540
        public void set_selectionType(){} // RVA: 0x7FFE87E3F550
        public void get_selectedIndex(){} // RVA: 0x7FFE87E3F600
        public void set_selectedIndex(){} // RVA: 0x7FFE87E3F680
        public void get_selectedIndices(){} // RVA: 0x7FFE81B0A0D0
        public void get_selectedIds(){} // RVA: 0x7FFE81B31350
        public void get_activeItems(){} // RVA: 0x7FFE87E3F690
        public void get_scrollView(){} // RVA: 0x7FFE81B373C0
        public void get_dragger(){} // RVA: 0x7FFE81B15120
        public void get_virtualizationController(){} // RVA: 0x7FFE87E3F710
        public void get_viewController(){} // RVA: 0x7FFE81B10FA0
        public void ResolveItemHeight(){} // RVA: 0x7FFE87E3F750
        public void set_showBorder(){} // RVA: 0x7FFE87E3F7A0
        public void get_reorderable(){} // RVA: 0x7FFE87E3F840
        public void set_reorderable(){} // RVA: 0x7FFE87E3F8E0
        public void set_horizontalScrollingEnabled(){} // RVA: 0x7FFE87E3F980
        public void get_showAlternatingRowBackgrounds(){} // RVA: 0x7FFE87E3F9F0
        public void set_showAlternatingRowBackgrounds(){} // RVA: 0x7FFE87E3FA00
        public void get_virtualizationMethod(){} // RVA: 0x7FFE83339770
        public void set_virtualizationMethod(){} // RVA: 0x7FFE87E3FA20
        public void get_fixedItemHeight(){} // RVA: 0x7FFE87E3FA70
        public void set_fixedItemHeight(){} // RVA: 0x7FFE87E3FA80
        public void get_lastHeight(){} // RVA: 0x7FFE87E3FB80
        public void CreateVirtualizationController(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void GetOrCreateVirtualizationController(){} // RVA: 0x7FFE87E3F710
        public void GetOrCreateViewController(){} // RVA: 0x7FFE87E3FBD0
        public void CreateViewController(){} // RVA: 0x7FFE80E2E2E0
        public void SetViewController(){} // RVA: 0x7FFE87E3FC30
        public void CreateDragger(){} // RVA: 0x7FFE87E40040
        public void InitializeDragAndDropController(){} // RVA: 0x7FFE87E400A0
        public void CreateDragAndDropController(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE87E40D60 | overloaded x2
        public void GetRootElementForId(){} // RVA: 0x7FFE87E40E60
        public void HasValidDataAndBindings(){} // RVA: 0x7FFE87E40F70
        public void OnItemIndexChanged(){} // RVA: 0x7FFE87E40FB0
        public void OnItemsSourceChanged(){} // RVA: 0x7FFE87E40FF0
        public void RefreshItems(){} // RVA: 0x7FFE87E41010
        public void Rebuild(){} // RVA: 0x7FFE87E41180
        public void RefreshSelection(){} // RVA: 0x7FFE87E412F0
        public void PostRefresh(){} // RVA: 0x7FFE87E41580
        public void ScrollToItem(){} // RVA: 0x7FFE87E41640
        public void ScrollToItemById(){} // RVA: 0x7FFE87E416C0
        public void OnScroll(){} // RVA: 0x7FFE87E41760
        public void Resize(){} // RVA: 0x7FFE87E417E0
        public void OnAttachToPanel(){} // RVA: 0x7FFE87E418A0
        public void OnDetachFromPanel(){} // RVA: 0x7FFE87E41CF0
        public void Apply(){} // RVA: 0x7FFE87E424F0 | overloaded x2
        public void HandleItemNavigation(){} // RVA: 0x7FFE834BA0A0
        public void OnPointerMove(){} // RVA: 0x7FFE87E426C0
        public void OnPointerDown(){} // RVA: 0x7FFE87E42750
        public void OnPointerCancel(){} // RVA: 0x7FFE87E428C0
        public void OnPointerUp(){} // RVA: 0x7FFE87E42940
        public void ProcessPointerDown(){} // RVA: 0x7FFE87E42AB0
        public void ProcessPointerUp(){} // RVA: 0x7FFE87E42CD0
        public void DoSelect(){} // RVA: 0x7FFE87E43040
        public void DoRangeSelection(){} // RVA: 0x7FFE87E43550
        public void ProcessSingleClick(){} // RVA: 0x7FFE87E3F680
        public void SelectAll(){} // RVA: 0x7FFE87E436F0
        public void AddToSelection(){} // RVA: 0x7FFE87E43AD0 | overloaded x2
        public void AddToSelectionWithoutValidation(){} // RVA: 0x7FFE87E43D70
        public void RemoveFromSelection(){} // RVA: 0x7FFE87E441A0
        public void RemoveFromSelectionWithoutValidation(){} // RVA: 0x7FFE87E44200
        public void SetSelection(){} // RVA: 0x7FFE87E44600 | overloaded x2
        public void SetSelectionWithoutNotify(){} // RVA: 0x7FFE87E44610
        public void SetSelectionInternal(){} // RVA: 0x7FFE87E44620
        public void MatchesExistingSelection(){} // RVA: 0x7FFE87E44870
        public void NotifyOfSelectionChange(){} // RVA: 0x7FFE87E44B10
        public void ClearSelection(){} // RVA: 0x7FFE87E44B80
        public void ClearSelectionWithoutValidation(){} // RVA: 0x7FFE87E44C00
        public void OnViewDataReady(){} // RVA: 0x7FFE87E44E60
        public void ExecuteDefaultAction(){} // RVA: 0x7FFE87E44EA0
        public void OnSizeChanged(){} // RVA: 0x7FFE87E45290
        public void OnCustomStyleResolved(){} // RVA: 0x7FFE87E45330
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE87E3D710
        public void .cctor(){} // RVA: 0x7FFE87E454F0
        public void <.ctor>b__158_0(){} // RVA: 0x7FFE87E45DB0
        public void <Apply>g__HandleSelectionAndScroll|181_0(){} // RVA: 0x7FFE87E45E40
    }

    public class BaseVisualElementPanel : Object
    {
        public System.Action`1<UnityEngine.UIElements.BaseVisualElementPanel> panelDisposed; // 0x10
        public UnityEngine.UIElements.UIElementsBridge m_UIElementsBridge; // 0x18
        public float m_Scale; // 0x20
        public UnityEngine.Yoga.YogaConfig yogaConfig; // 0x28
        public float m_PixelsPerPoint; // 0x30
        public float _referenceSpritePixelsPerUnit; // 0x34
        public UnityEngine.UIElements.PanelClearSettings _clearSettings; // 0x38
        public bool _duringLayoutPhase; // 0x4C
        public UnityEngine.UIElements.RepaintData _repaintData; // 0x50
        public UnityEngine.UIElements.ICursorManager _cursorManager; // 0x58
        public UnityEngine.UIElements.ContextualMenuManager _contextualMenuManager; // 0x60
        public bool _disposed; // 0x68
        public UnityEngine.UIElements.ElementUnderPointer m_TopElementUnderPointers; // 0x70
        public System.Action standardShaderChanged; // 0x78
        public System.Action standardWorldSpaceShaderChanged; // 0x80
        public System.Action atlasChanged; // 0x88
        public System.Action`1<UnityEngine.Material> updateMaterial; // 0x90
        public UnityEngine.UIElements.HierarchyEvent hierarchyChanged; // 0x98
        public System.Action`1<UnityEngine.UIElements.IPanel> beforeUpdate; // 0xA0
        public bool clearDepthStencil; // 0x10
        public bool clearColor; // 0x11
        public UnityEngine.Color color; // 0x14
        public UnityEngine.UIElements.VisualElement m_RootContainer; // 0xA8
        public UnityEngine.UIElements.VisualTreeUpdater m_VisualTreeUpdater; // 0xB0
        public UnityEngine.UIElements.IStylePropertyAnimationSystem m_StylePropertyAnimationSystem; // 0xB8
        public string m_PanelName; // 0xC0
        public uint m_Version; // 0xC8
        public uint m_RepaintVersion; // 0xCC

        // ── Methods ──
        public void get_IMGUIEventInterests(){}
        public void set_IMGUIEventInterests(){}
        public void get_ownerObject(){} // RVA: 0x7FFE80E2E2E0
        public void set_ownerObject(){} // RVA: 0x7FFE80E460A0
        public void get_saveViewData(){} // RVA: 0x7FFE80E2E2E0
        public void get_getViewDataDictionary(){} // RVA: 0x7FFE80E2E2E0
        public void get_IMGUIContainersCount(){} // RVA: 0x7FFE80E2EDB0
        public void set_IMGUIContainersCount(){} // RVA: 0x7FFE80E46530
        public void get_focusController(){} // RVA: 0x7FFE80E2E2E0
        public void set_focusController(){} // RVA: 0x7FFE80E460A0
        public void get_rootIMGUIContainer(){} // RVA: 0x7FFE80E2E2E0
        public void add_panelDisposed(){} // RVA: 0x7FFE87F4F070
        public void remove_panelDisposed(){} // RVA: 0x7FFE87F4F170
        public void get_uiElementsBridge(){} // RVA: 0x7FFE87F4F270
        public void .ctor(){} // RVA: 0x7FFE87F4F2E0
        public void Dispose(){} // RVA: 0x7FFE87F4F6A0 | overloaded x2
        public void Repaint(){} // RVA: 0x7FFE80E460A0
        public void ValidateFocus(){} // RVA: 0x7FFE80E45FE0
        public void ValidateLayout(){} // RVA: 0x7FFE80E45FE0
        public void UpdateAnimations(){} // RVA: 0x7FFE80E45FE0
        public void UpdateBindings(){} // RVA: 0x7FFE80E45FE0
        public void ApplyStyles(){} // RVA: 0x7FFE80E45FE0
        public void get_scale(){} // RVA: 0x7FFE87BBABB0
        public void set_scale(){} // RVA: 0x7FFE87F4FA50
        public void set_pixelsPerPoint(){} // RVA: 0x7FFE87F4FB30
        public void get_scaledPixelsPerPoint(){} // RVA: 0x7FFE87F4FC10
        public void get_referenceSpritePixelsPerUnit(){} // RVA: 0x7FFE811C5630
        public void set_referenceSpritePixelsPerUnit(){} // RVA: 0x7FFE811C5640
        public void get_clearSettings(){} // RVA: 0x7FFE87F4FC20
        public void set_clearSettings(){} // RVA: 0x7FFE87F4FC40
        public void get_duringLayoutPhase(){} // RVA: 0x7FFE82447BA0
        public void set_duringLayoutPhase(){} // RVA: 0x7FFE824479E0
        public void get_version(){} // RVA: 0x7FFE80E2EDB0
        public void get_hierarchyVersion(){} // RVA: 0x7FFE80E2EDB0
        public void OnVersionChanged(){} // RVA: 0x7FFE80E4D070
        public void get_repaintData(){} // RVA: 0x7FFE8119C0E0
        public void set_repaintData(){} // RVA: 0x7FFE812534D0
        public void get_cursorManager(){} // RVA: 0x7FFE811C3500
        public void set_cursorManager(){} // RVA: 0x7FFE811C3510
        public void get_contextualMenuManager(){} // RVA: 0x7FFE81199370
        public void set_contextualMenuManager(){} // RVA: 0x7FFE81199380
        public void get_visualTree(){} // RVA: 0x7FFE80E2E2E0
        public void get_dispatcher(){} // RVA: 0x7FFE80E2E2E0
        public void set_dispatcher(){} // RVA: 0x7FFE80E460A0
        public void SendEvent(){} // RVA: 0x7FFE87F4FC50
        public void get_scheduler(){} // RVA: 0x7FFE80E2E2E0
        public void get_styleAnimationSystem(){} // RVA: 0x7FFE80E2E2E0
        public void set_styleAnimationSystem(){} // RVA: 0x7FFE80E460A0
        public void get_contextType(){} // RVA: 0x7FFE80E2EDB0
        public void set_contextType(){} // RVA: 0x7FFE80E46530
        public void Pick(){}
        public void PickAll(){}
        public void get_disposed(){} // RVA: 0x7FFE811C3570
        public void set_disposed(){} // RVA: 0x7FFE811C3580
        public void GetUpdater(){} // RVA: 0x7FFE80E3D230
        public void GetTopElementUnderPointer(){} // RVA: 0x7FFE87F4FD20
        public void RecomputeTopElementUnderPointer(){} // RVA: 0x7FFE87F4FD60
        public void ClearCachedElementUnderPointer(){} // RVA: 0x7FFE87F4FEA0
        public void CommitElementUnderPointers(){} // RVA: 0x7FFE87F4FEE0
        public void get_standardShader(){} // RVA: 0x7FFE80E2E2E0
        public void get_standardWorldSpaceShader(){} // RVA: 0x7FFE84A912C0
        public void add_standardShaderChanged(){} // RVA: 0x7FFE87F4FF50
        public void remove_standardShaderChanged(){} // RVA: 0x7FFE87F50040
        public void add_standardWorldSpaceShaderChanged(){} // RVA: 0x7FFE87F50130
        public void remove_standardWorldSpaceShaderChanged(){} // RVA: 0x7FFE87F50220
        public void add_atlasChanged(){} // RVA: 0x7FFE87F50310
        public void remove_atlasChanged(){} // RVA: 0x7FFE87F50400
        public void InvokeAtlasChanged(){} // RVA: 0x7FFE87F504F0
        public void get_atlas(){} // RVA: 0x7FFE80E2E2E0
        public void set_atlas(){} // RVA: 0x7FFE80E460A0
        public void InvokeUpdateMaterial(){} // RVA: 0x7FFE87F50510
        public void add_hierarchyChanged(){} // RVA: 0x7FFE87F50530
        public void remove_hierarchyChanged(){} // RVA: 0x7FFE87F50620
        public void InvokeHierarchyChanged(){} // RVA: 0x7FFE87F50710
        public void InvokeBeforeUpdate(){} // RVA: 0x7FFE87F50740
        public void UpdateElementUnderPointers(){} // RVA: 0x7FFE87F50760
        public void UnityEngine.UIElements.IGroupBox.OnOptionAdded(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(){} // RVA: 0x7FFE810FB310
        public void Update(){} // RVA: 0x7FFE87F50A20
    }

    public class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater
    {
        // ── Methods ──
        public void OnHierarchyChange(){} // RVA: 0x7FFE80E4D070
        public void OnVersionChanged(){} // RVA: 0x7FFE87E6C3C0
        public void Update(){} // RVA: 0x7FFE87E6C600
        public void ProcessNewChange(){} // RVA: 0x7FFE87E6C750
        public void ProcessAddOrMove(){} // RVA: 0x7FFE87E6C880
        public void ProcessRemove(){} // RVA: 0x7FFE87E6C940
        public void .ctor(){} // RVA: 0x7FFE87D96D40
    }

    public class BaseVisualTreeUpdater : Object
    {
        public System.Action`1<UnityEngine.UIElements.BaseVisualElementPanel> panelChanged; // 0x10
        public UnityEngine.UIElements.BaseVisualElementPanel m_Panel; // 0x18
        public object field_2; // 0x26

        // ── Methods ──
        public void add_panelChanged(){} // RVA: 0x7FFE87E71BE0
        public void remove_panelChanged(){} // RVA: 0x7FFE87E71CE0
        public void get_panel(){} // RVA: 0x7FFE83BBC680
        public void set_panel(){} // RVA: 0x7FFE87E71DE0
        public void get_visualTree(){} // RVA: 0x7FFE868CFDB0
        public void get_profilerMarker(){}
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void Update(){} // RVA: 0x7FFE80E45FE0
        public void OnVersionChanged(){} // RVA: 0x7FFE80E4D070
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BindableElement : VisualElement
    {
        public UnityEngine.UIElements.IBinding _binding; // 0x3C8
        public string _bindingPath; // 0x3D0

        // ── Methods ──
        public void get_binding(){} // RVA: 0x7FFE81B2D3F0
        public void set_bindingPath(){} // RVA: 0x7FFE81B35840
        public void .ctor(){} // RVA: 0x7FFE87E265D0
    }

    public class BlurEvent : FocusEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F2AB30
        public void PreDispatch(){} // RVA: 0x7FFE87F2AC20
        public void .ctor(){} // RVA: 0x7FFE87F2ACB0
    }

    public class BoundsField : BaseField`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E46D00 | overloaded x2
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE87E472E0
        public void UpdateMixedValueContent(){} // RVA: 0x7FFE87E474A0
        public void .cctor(){} // RVA: 0x7FFE87E47560
        public void <.ctor>b__10_0(){} // RVA: 0x7FFE87E478A0
        public void <.ctor>b__10_1(){} // RVA: 0x7FFE87E47960
    }

    public class BoundsIntField : BaseField`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E485A0 | overloaded x2
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE87E48B80
        public void UpdateMixedValueContent(){} // RVA: 0x7FFE87E48D40
        public void .cctor(){} // RVA: 0x7FFE87E48E00
        public void <.ctor>b__10_0(){} // RVA: 0x7FFE87E49140
        public void <.ctor>b__10_1(){} // RVA: 0x7FFE87E49200
    }

    public class Box : VisualElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E49DC0
        public void .cctor(){} // RVA: 0x7FFE87E49E60
    }

    public class Button : TextElement
    {
        public string ussClassName;

        // ── Methods ──
        public void get_clickable(){} // RVA: 0x7FFE87E49F70
        public void set_clickable(){} // RVA: 0x7FFE87E49F80
        public void .ctor(){} // RVA: 0x7FFE87E4A0B0 | overloaded x2
        public void OnNavigationSubmit(){} // RVA: 0x7FFE87E4A2F0
        public void DoMeasure(){} // RVA: 0x7FFE87E4A440
        public void .cctor(){} // RVA: 0x7FFE87E4A510
    }

    public class ButtonStripField : BaseField`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E4A6E0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE87E4A7F0
        public void RefreshButtonsState(){} // RVA: 0x7FFE87E4A950
    }

}