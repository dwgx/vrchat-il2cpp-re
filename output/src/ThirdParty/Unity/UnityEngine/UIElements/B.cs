// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 16
// Methods: 398

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Background : ValueType
    {
        public UnityEngine.Texture2D texture; // 0x10
        public UnityEngine.Sprite sprite; // 0x18
        public UnityEngine.RenderTexture renderTexture; // 0x20
        public UnityEngine.UIElements.VectorImage vectorImage; // 0x28

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFD505F9A30
        public void set_texture(){} // RVA: 0x7FFD54FF3B40
        public void get_sprite(){} // RVA: 0x7FFD53AD4B80
        public void set_sprite(){} // RVA: 0x7FFD54FF3DB0
        public void get_renderTexture(){} // RVA: 0x7FFD510E4750
        public void set_renderTexture(){} // RVA: 0x7FFD54FF4020
        public void get_vectorImage(){} // RVA: 0x7FFD50CC1130
        public void set_vectorImage(){} // RVA: 0x7FFD54FF4290
        public void FromTexture2D(){} // RVA: 0x7FFD54FF4500
        public void FromRenderTexture(){} // RVA: 0x7FFD54FF4550
        public void FromSprite(){} // RVA: 0x7FFD54FF45A0
        public void FromVectorImage(){} // RVA: 0x7FFD54FF45F0
        public void FromObject(){} // RVA: 0x7FFD54FF4640
        public void op_Equality(){} // RVA: 0x7FFD54FF4A70
        public void op_Inequality(){} // RVA: 0x7FFD54FF4E40
        public void Equals(){} // RVA: 0x7FFD54FF4EC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54FF4F70
        public void ToString(){} // RVA: 0x7FFD54FF5040
    }

    public class BackgroundPosition : ValueType
    {
        public 0x66482B28 keyword; // 0x10
        public UnityEngine.UIElements.Length offset; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD515116B0 | overloaded x2
        public void Initial(){} // RVA: 0x7FFD54E9CD40
        public void Equals(){} // RVA: 0x7FFD54E9CE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54E9CE80
        public void op_Equality(){} // RVA: 0x7FFD54E9CEB0
        public void op_Inequality(){} // RVA: 0x7FFD54E9CF10
        public void ToString(){} // RVA: 0x7FFD54E9CF90
    }

    public class BackgroundRepeat : ValueType
    {
        public 0x66482B80 x; // 0x10
        public 0x66482B80 y; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E7F6D50
        public void Initial(){} // RVA: 0x7FFD54E9D650
        public void Equals(){} // RVA: 0x7FFD54E9D700 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54E9D720
        public void op_Equality(){} // RVA: 0x7FFD54E9D740
        public void op_Inequality(){} // RVA: 0x7FFD54E9D760
        public void ToString(){} // RVA: 0x7FFD54E9D780
    }

    public class BackgroundSize : ValueType
    {
        public 0x66482BD8 sizeType; // 0x10
        public UnityEngine.UIElements.Length x; // 0x14
        public UnityEngine.UIElements.Length y; // 0x1C

        // ── Methods ──
        public void get_sizeType(){} // RVA: 0x7FFD543B3F90
        public void set_sizeType(){} // RVA: 0x7FFD54E9D850
        public void get_x(){} // RVA: 0x7FFD53AD94A0
        public void set_x(){} // RVA: 0x7FFD54E9D880
        public void get_y(){} // RVA: 0x7FFD54E9D890
        public void set_y(){} // RVA: 0x7FFD54E9D8A0
        public void .ctor(){} // RVA: 0x7FFD54E9D850 | overloaded x2
        public void Initial(){} // RVA: 0x7FFD54E9D8C0
        public void Equals(){} // RVA: 0x7FFD54E9DA30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54E9DAA0
        public void op_Equality(){} // RVA: 0x7FFD54E9DB00
        public void op_Inequality(){} // RVA: 0x7FFD54E9DB80
        public void ToString(){} // RVA: 0x7FFD54E9DC10
    }

    public class BaseCompositeField`3 : BaseField`1
    {
        public System.Collections.Generic.List`1<V> m_Fields;
        public bool m_ShouldUpdateDisplay;
        public bool m_ForceUpdateDisplay;
        public int m_PropertyIndex;
        public string ussClassName;
        public string labelUssClassName;
        public string inputUssClassName;
        public string spacerUssClassName;
        public string multilineVariantUssClassName;
        public string fieldGroupUssClassName;
        public string fieldUssClassName;
        public string firstFieldVariantUssClassName;
        public string twoLinesVariantUssClassName;

        // ── Methods ──
        public void GetSpacer(){} // RVA: 0x7FFD4E078E90
        public void DescribeFields(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E097970
        public void UpdateDisplay(){} // RVA: 0x7FFD4E090980
        public void SetValueWithoutNotify(){} // RVA: 0x7FFD4E2ADC40
        public void OnViewDataReady(){} // RVA: 0x7FFD4E090980
        public void UpdateMixedValueContent(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class BaseFieldMouseDragger : Object
    {
        // ── Methods ──
        public void SetDragZone(){} // RVA: 0x7FFD54FB2FE0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class BaseFieldTraits`2 : UxmlTraits
    {
        public 0x664852B0 m_Value; // 0x80

        // ── Methods ──
        public void Init(){}
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class BaseField`1 : BindableElement
    {
        public string visualInput;
        public string rawValue; // 0x8
        public string value; // 0x10
        public string labelElement; // 0x18
        public string label; // 0x20
        public string showMixedValue; // 0x28
        public string mixedValueLabel; // 0x30
        public string UnityEngine.UIElements.IEditableElement.editingStarted; // 0x38
        public string UnityEngine.UIElements.IEditableElement.editingEnded; // 0x40
        public UnityEngine.PropertyName serializedPropertyCopyName; // 0x48
        public UnityEngine.UIElements.CustomStyleProperty`1<float> s_LabelWidthRatioProperty; // 0x50
        public UnityEngine.UIElements.CustomStyleProperty`1<float> s_LabelExtraPaddingProperty; // 0x58
        public UnityEngine.UIElements.CustomStyleProperty`1<float> s_LabelBaseMinWidthProperty; // 0x60
        public UnityEngine.UIElements.CustomStyleProperty`1<float> s_LabelExtraContextWidthProperty; // 0x68
        public float m_LabelWidthRatio; // 0x3D8
        public float m_LabelExtraPadding; // 0x3DC
        public float m_LabelBaseMinWidth; // 0x3E0
        public float m_LabelExtraContextWidth; // 0x3E4
        public UnityEngine.UIElements.VisualElement m_VisualInput; // 0x3E8
        public System.Enum m_Value; // 0x3F0
        public System.Func`2<System.Enum,System.Enum> onValidateValue; // 0x3F8
        public 0x66477BD8 <labelElement>k__BackingField; // 0x400
        public bool m_ShowMixedValue; // 0x408
        public 0x66477BD8 m_MixedValueLabel; // 0x410
        public bool m_SkipValidation; // 0x418
        public UnityEngine.UIElements.VisualElement m_CachedContextWidthElement; // 0x420
        public UnityEngine.UIElements.VisualElement m_CachedInspectorElement; // 0x428
        public System.Action <UnityEngine.UIElements.IEditableElement.editingStarted>k__BackingField; // 0x430
        public System.Action <UnityEngine.UIElements.IEditableElement.editingEnded>k__BackingField; // 0x438

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x7FFD530A2120
        public void set_visualInput(){} // RVA: 0x7FFD530A2160
        public void get_rawValue(){} // RVA: 0x7FFD4E27B230
        public void set_rawValue(){} // RVA: 0x7FFD530A25B0
        public void add_onValidateValue(){} // RVA: 0x7FFD530A2680
        public void remove_onValidateValue(){} // RVA: 0x7FFD530A27F0
        public void get_value(){} // RVA: 0x7FFD4E27B230
        public void set_value(){} // RVA: 0x7FFD530A2960
        public void get_labelElement(){} // RVA: 0x7FFD530A2E60
        public void set_labelElement(){} // RVA: 0x7FFD530A2EA0
        public void get_label(){} // RVA: 0x7FFD530A2F20
        public void set_label(){} // RVA: 0x7FFD530A2F70
        public void get_showMixedValue(){} // RVA: 0x7FFD530A3280
        public void set_showMixedValue(){} // RVA: 0x7FFD530A32C0
        public void get_mixedValueLabel(){} // RVA: 0x7FFD530A3350
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0x7FFD530A35B0
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0x7FFD530A35F0
        public void .ctor(){} // RVA: 0x7FFD530A3A20 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x7FFD530A3A80
        public void OnDetachFromPanel(){} // RVA: 0x7FFD530A3E10
        public void RegisterEditingCallbacks(){} // RVA: 0x7FFD530A3EC0
        public void UnregisterEditingCallbacks(){} // RVA: 0x7FFD530A3FD0
        public void StartEditing(){} // RVA: 0x7FFD530A4130
        public void EndEditing(){} // RVA: 0x7FFD530A41A0
        public void OnCustomStyleResolved(){} // RVA: 0x7FFD530A4210
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x7FFD530A4740
        public void AlignLabel(){} // RVA: 0x7FFD530A4760
        public void ValidatedValue(){} // RVA: 0x7FFD4E27B230
        public void UpdateMixedValueContent(){} // RVA: 0x7FFD510A5BA0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFD530A4F70
        public void OnViewDataReady(){} // RVA: 0x7FFD530A5190
        public void GetTooltipRect(){} // RVA: 0x7FFD530A5610
        public void .cctor(){} // RVA: 0x7FFD530A56D0
    }

    public class BasePopupField`2 : BaseField`1
    {
        public System.Collections.Generic.List`1<T> textElement;
        public UnityEngine.UIElements.TextElement choices;
        public UnityEngine.UIElements.VisualElement m_ArrowElement;
        public System.Func`2<T,string> m_FormatSelectedValueCallback;
        public System.Func`2<T,string> m_FormatListItemCallback;
        public System.Func`1<0x66476E18> createMenuCallback;
        public string ussClassName;
        public string textUssClassName;
        public string arrowUssClassName;
        public string labelUssClassName;
        public string inputUssClassName;

        // ── Methods ──
        public void get_textElement(){} // RVA: 0x7FFD531BC460
        public void GetValueToDisplay(){} // RVA: 0x7FFD4E078E90
        public void GetListItemToDisplay(){} // RVA: 0x7FFD4E2ADC40
        public void AddMenuItems(){} // RVA: 0x7FFD4E090A40
        public void set_choices(){} // RVA: 0x7FFD531BC490
        public void SetValueWithoutNotify(){} // RVA: 0x7FFD531BC5E0
        public void .ctor(){} // RVA: 0x7FFD531BC750
        public void OnPointerDownEvent(){} // RVA: 0x7FFD531BD050
        public void OnPointerMoveEvent(){} // RVA: 0x7FFD531BD070
        public void ContainsPointer(){} // RVA: 0x7FFD531BD110
        public void ProcessPointerDown(){} // RVA: 0x7FFD4E090A40
        public void OnNavigationSubmit(){} // RVA: 0x7FFD531BD1B0
        public void ShowMenu(){} // RVA: 0x7FFD531BD1F0
        public void UpdateMixedValueContent(){} // RVA: 0x7FFD531BD3A0
        public void .cctor(){} // RVA: 0x7FFD531BD670
    }

    public class BaseSlider`1 : BaseField`1
    {
        public UnityEngine.UIElements.VisualElement dragContainer;
        public UnityEngine.UIElements.VisualElement dragElement;
        public UnityEngine.UIElements.VisualElement trackElement;
        public UnityEngine.UIElements.VisualElement dragBorderElement;
        public ` inputTextField;
        public bool lowValue;
        public T highValue;
        public T pageSize;
        public float showInputField;
        public bool clamped;
        public bool clampedDragger;
        public UnityEngine.UIElements.ClampedDragger`1<T> value;
        public UnityEngine.Rect direction;
        public 0x664753F8 inverted;
        public bool m_Inverted;
        public string ussClassName;
        public string labelUssClassName;
        public string inputUssClassName;
        public string horizontalVariantUssClassName;
        public string verticalVariantUssClassName;
        public string dragContainerUssClassName;
        public string trackerUssClassName;
        public string draggerUssClassName;
        public string draggerBorderUssClassName;
        public string textFieldClassName;

        // ── Methods ──
        public void get_dragContainer(){} // RVA: 0x7FFD4E078E90
        public void set_dragContainer(){} // RVA: 0x7FFD4E090A40
        public void get_dragElement(){} // RVA: 0x7FFD4E078E90
        public void set_dragElement(){} // RVA: 0x7FFD4E090A40
        public void get_trackElement(){} // RVA: 0x7FFD4E078E90
        public void set_trackElement(){} // RVA: 0x7FFD4E090A40
        public void get_dragBorderElement(){} // RVA: 0x7FFD4E078E90
        public void set_dragBorderElement(){} // RVA: 0x7FFD4E090A40
        public void get_inputTextField(){} // RVA: 0x7FFD4E078E90
        public void set_inputTextField(){} // RVA: 0x7FFD4E090A40
        public void get_lowValue(){} // RVA: 0x7FFD4E2ADC40
        public void set_lowValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_highValue(){} // RVA: 0x7FFD4E2ADC40
        public void set_highValue(){} // RVA: 0x7FFD4E2ADC40
        public void SetHighValueWithoutNotify(){} // RVA: 0x7FFD4E2ADC40
        public void get_pageSize(){} // RVA: 0x7FFD4E08D880
        public void set_pageSize(){} // RVA: 0x7FFD4E09E480
        public void get_showInputField(){} // RVA: 0x7FFD4E079D00
        public void set_showInputField(){} // RVA: 0x7FFD4E091060
        public void get_clamped(){} // RVA: 0x7FFD4E079D00
        public void set_clamped(){} // RVA: 0x7FFD4E091060
        public void get_clampedDragger(){} // RVA: 0x7FFD4E078E90
        public void set_clampedDragger(){} // RVA: 0x7FFD4E090A40
        public void Clamp(){} // RVA: 0x7FFD4E2ADC40
        public void GetClampedValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_value(){} // RVA: 0x7FFD4E2ADC40
        public void set_value(){} // RVA: 0x7FFD4E2ADC40
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFD4E2ADC40
        public void UnityEngine.UIElements.IValueField<TValueType>.StartDragging(){} // RVA: 0x7FFD4E090980
        public void UnityEngine.UIElements.IValueField<TValueType>.StopDragging(){} // RVA: 0x7FFD4E090980
        public void SetValueWithoutNotify(){} // RVA: 0x7FFD4E2ADC40
        public void get_direction(){} // RVA: 0x7FFD4E079960
        public void set_direction(){} // RVA: 0x7FFD4E090ED0
        public void get_inverted(){} // RVA: 0x7FFD4E079D00
        public void set_inverted(){} // RVA: 0x7FFD4E091060
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetClosestPowerOfTen(){} // RVA: 0x7FFD4E08EA30
        public void RoundToMultipleOf(){}
        public void ClampValue(){} // RVA: 0x7FFD4E090980
        public void SliderLerpUnclamped(){} // RVA: 0x7FFD4E2ADC40
        public void SliderNormalizeValue(){} // RVA: 0x7FFD4E2ADC40
        public void ParseStringToValue(){} // RVA: 0x7FFD4E2ADC40
        public void ComputeValueFromKey(){} // RVA: 0x7FFD4E2ADC40
        public void SliderLerpDirectionalUnclamped(){} // RVA: 0x7FFD4E2ADC40
        public void SetSliderValueFromDrag(){} // RVA: 0x7FFD4E090980
        public void ComputeValueAndDirectionFromDrag(){} // RVA: 0x7FFD4E09EB40
        public void SetSliderValueFromClick(){} // RVA: 0x7FFD4E090980
        public void OnKeyDown(){} // RVA: 0x7FFD4E090A40
        public void OnNavigationMove(){} // RVA: 0x7FFD4E090A40
        public void ComputeValueAndDirectionFromClick(){}
        public void AdjustDragElement(){} // RVA: 0x7FFD4E09E480
        public void UpdateDragElementPosition(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void OnViewDataReady(){} // RVA: 0x7FFD4E090980
        public void SameValues(){} // RVA: 0x7FFD4E2ADC40
        public void ExecuteDefaultAction(){} // RVA: 0x7FFD4E090A40
        public void UpdateTextFieldVisibility(){} // RVA: 0x7FFD4E090980
        public void UpdateTextFieldValue(){} // RVA: 0x7FFD4E090980
        public void OnTextFieldFocusIn(){} // RVA: 0x7FFD4E090A40
        public void OnTextFieldFocusOut(){} // RVA: 0x7FFD4E090A40
        public void OnInputNavigationMoveEvent(){} // RVA: 0x7FFD4E090A40
        public void OnTextFieldValueChange(){} // RVA: 0x7FFD4E090A40
        public void UpdateMixedValueContent(){} // RVA: 0x7FFD4E090980
        public void RegisterEditingCallbacks(){} // RVA: 0x7FFD4E090980
        public void UnregisterEditingCallbacks(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class BaseTreeViewController : CollectionViewController
    {
        public System.Collections.Generic.Dictionary`2<int,0x66479B78> baseTreeView; // 0x30
        public System.Collections.Generic.List`1<int> itemsSource; // 0x38
        public System.Collections.Generic.List`1<0x66479BD0> m_ItemWrappers; // 0x40
        public System.Collections.Generic.HashSet`1<int> m_TreeItemIdsWithItemWrappers; // 0x48
        public System.Collections.Generic.List`1<0x66479BD0> m_WrapperInsertionList; // 0x50
        public Unity.Profiling.ProfilerMarker K_ExpandItemByIndex;
        public Unity.Profiling.ProfilerMarker k_CreateWrappers; // 0x8

        // ── Methods ──
        public void get_baseTreeView(){} // RVA: 0x7FFD54EA6040
        public void get_itemsSource(){} // RVA: 0x7FFD4E3447C0
        public void set_itemsSource(){} // RVA: 0x7FFD54EA60D0
        public void RebuildTree(){} // RVA: 0x7FFD54EA6120
        public void GetRootItemIds(){} // RVA: 0x7FFD54D3F6C0
        public void GetAllItemIds(){} // RVA: 0x7FFD4E078F40
        public void GetParentId(){} // RVA: 0x7FFD4E0800D0
        public void GetChildrenIds(){} // RVA: 0x7FFD4E087DE0
        public void Move(){}
        public void InvokeMakeItem(){} // RVA: 0x7FFD54EA64C0
        public void InvokeBindItem(){} // RVA: 0x7FFD54EA6590
        public void InvokeDestroyItem(){} // RVA: 0x7FFD54EA66B0
        public void PostInitRegistration(){} // RVA: 0x7FFD54EA69E0
        public void OnItemPointerUp(){} // RVA: 0x7FFD54EA6E60
        public void OnToggleValueChanged(){} // RVA: 0x7FFD54EA74B0
        public void GetIndexForId(){} // RVA: 0x7FFD54EA7690
        public void GetIdForIndex(){} // RVA: 0x7FFD54EA7770
        public void HasChildren(){} // RVA: 0x7FFD54EA7820
        public void Exists(){} // RVA: 0x7FFD54EA78D0
        public void HasChildrenByIndex(){} // RVA: 0x7FFD54EA7940
        public void GetChildrenIdsByIndex(){} // RVA: 0x7FFD54EA7A40
        public void GetChildIndexForId(){} // RVA: 0x7FFD54EA7AF0
        public void GetIndentationDepth(){} // RVA: 0x7FFD54EA7CC0
        public void GetIndentationDepthByIndex(){} // RVA: 0x7FFD54EA7D20
        public void CanChangeExpandedState(){} // RVA: 0x7FFD500182C0
        public void IsExpanded(){} // RVA: 0x7FFD54EA7D90
        public void IsExpandedByIndex(){} // RVA: 0x7FFD54EA7E50
        public void ExpandItemByIndex(){} // RVA: 0x7FFD54EA7F10
        public void ExpandItem(){} // RVA: 0x7FFD54EA8780
        public void CollapseItemByIndex(){} // RVA: 0x7FFD54EA8960
        public void CollapseItem(){} // RVA: 0x7FFD54EA8E70
        public void RegenerateWrappers(){} // RVA: 0x7FFD54EA9000
        public void CreateWrappers(){} // RVA: 0x7FFD54EA9150
        public void IsIndexValid(){} // RVA: 0x7FFD54EA9690
        public void RaiseItemParentChanged(){} // RVA: 0x7FFD54EA9700
        public void .ctor(){} // RVA: 0x7FFD54EA9720
        public void .cctor(){} // RVA: 0x7FFD54EA9A90
    }

    public class BaseUxmlFactory`2 : Object
    {
        public UxmlTraits uxmlName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void get_uxmlName(){} // RVA: 0x7FFD4E078E90
        public void get_uxmlNamespace(){} // RVA: 0x7FFD4E078E90
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFD4E078E90
        public void get_uxmlType(){} // RVA: 0x7FFD4E078E90
        public void AcceptsAttributeBag(){}
    }

    public class BaseUxmlTraits : Object
    {
        public bool canHaveAnyAttribute; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E64C870
        public void set_canHaveAnyAttribute(){} // RVA: 0x7FFD4E40B5F0
    }

    public class BaseVerticalCollectionView : BindableElement
    {
        public Unity.Profiling.ProfilerMarker itemsSource;
        public Unity.Profiling.ProfilerMarker contentContainer; // 0x8
        public System.Action`1<System.Collections.Generic.IEnumerable`1<object>> selectionType; // 0x3D8
        public System.Action`1<System.Collections.Generic.IEnumerable`1<object>> selectedIndex; // 0x3E0
        public System.Action`1<System.Collections.Generic.IEnumerable`1<int>> selectedIndices; // 0x3E8
        public System.Action`2<int,int> selectedIds; // 0x3F0
        public System.Action activeItems; // 0x3F8
        public System.Action scrollView; // 0x400
        public System.Func`2<0x6647AA40,bool> dragger; // 0x408
        public System.Func`2<0x6647AA98,UnityEngine.UIElements.StartDragArgs> virtualizationController; // 0x410
        public System.Func`2<0x6647AAF0,0x6647A9E8> viewController; // 0x418
        public System.Func`2<0x6647AAF0,0x6647A9E8> showBorder; // 0x420
        public g/s reorderable; // 0x428
        public System.Collections.Generic.List`1<0x66474D18> horizontalScrollingEnabled; // 0x10
        public bool showAlternatingRowBackgrounds; // 0x42C
        public 0x66475608 virtualizationMethod; // 0x430
        public int fixedItemHeight; // 0x18
        public float lastHeight; // 0x434
        public bool m_ItemHeightIsInline; // 0x438
        public 0x66475660 m_VirtualizationMethod; // 0x43C
        public 0x664794F0 m_ScrollView; // 0x440
        public UnityEngine.UIElements.CollectionViewController m_ViewController; // 0x448
        public UnityEngine.UIElements.CollectionVirtualizationController m_VirtualizationController; // 0x450
        public 0x6647F950 m_NavigationManipulator; // 0x458
        public 0x664756B8 serializedVirtualizationData; // 0x460
        public System.Collections.Generic.List`1<int> m_SelectedIds; // 0x468
        public System.Collections.Generic.List`1<int> m_SelectedIndices; // 0x470
        public System.Collections.Generic.List`1<object> m_SelectedItems; // 0x478
        public float m_LastHeight; // 0x480
        public bool m_IsRangeSelectionDirectionUp; // 0x484
        public 0x6647AC50 m_Dragger; // 0x488
        public UnityEngine.UIElements.CustomStyleProperty`1<int> s_ItemHeightProperty; // 0x20
        public System.Action`2<int,int> m_ItemIndexChangedCallback; // 0x490
        public System.Action m_ItemsSourceChangedCallback; // 0x498
        public string ussClassName; // 0x28
        public string borderUssClassName; // 0x30
        public string itemUssClassName; // 0x38
        public string dragHoverBarUssClassName; // 0x40
        public string dragHoverMarkerUssClassName; // 0x48
        public string itemDragHoverUssClassName; // 0x50
        public string itemSelectedVariantUssClassName; // 0x58
        public string itemAlternativeBackgroundUssClassName; // 0x60
        public string listScrollViewUssClassName; // 0x68
        public string backgroundFillUssClassName; // 0x70
        public UnityEngine.Vector3 m_TouchDownPosition; // 0x4A0

        // ── Methods ──
        public void HasCanStartDrag(){} // RVA: 0x7FFD54EB6850
        public void RaiseCanStartDrag(){} // RVA: 0x7FFD54EB6860
        public void RaiseSetupDragAndDrop(){} // RVA: 0x7FFD54EB6920
        public void RaiseHandleDragAndDrop(){} // RVA: 0x7FFD54EB6A30
        public void RaiseDrop(){} // RVA: 0x7FFD54EB6B10
        public void get_itemsSource(){} // RVA: 0x7FFD54EB6BF0
        public void set_itemsSource(){} // RVA: 0x7FFD54EB6C20
        public void get_contentContainer(){} // RVA: 0x7FFD4E919180
        public void get_selectionType(){} // RVA: 0x7FFD54EB6CA0
        public void set_selectionType(){} // RVA: 0x7FFD54EB6CB0
        public void get_selectedIndex(){} // RVA: 0x7FFD54EB6D60
        public void set_selectedIndex(){} // RVA: 0x7FFD54EB6DE0
        public void get_selectedIndices(){} // RVA: 0x7FFD4EDEF8B0
        public void get_selectedIds(){} // RVA: 0x7FFD4EDDF760
        public void get_activeItems(){} // RVA: 0x7FFD54EB6DF0
        public void get_scrollView(){} // RVA: 0x7FFD4EDE4300
        public void get_dragger(){} // RVA: 0x7FFD4EDD91C0
        public void get_virtualizationController(){} // RVA: 0x7FFD54EB6E70
        public void get_viewController(){} // RVA: 0x7FFD4EDDD8C0
        public void ResolveItemHeight(){} // RVA: 0x7FFD54EB6EB0
        public void set_showBorder(){} // RVA: 0x7FFD54EB6F00
        public void get_reorderable(){} // RVA: 0x7FFD54EB6FA0
        public void set_reorderable(){} // RVA: 0x7FFD54EB7040
        public void set_horizontalScrollingEnabled(){} // RVA: 0x7FFD54EB70E0
        public void get_showAlternatingRowBackgrounds(){} // RVA: 0x7FFD54EB7150
        public void set_showAlternatingRowBackgrounds(){} // RVA: 0x7FFD54EB7160
        public void get_virtualizationMethod(){} // RVA: 0x7FFD504A86F0
        public void set_virtualizationMethod(){} // RVA: 0x7FFD54EB7180
        public void get_fixedItemHeight(){} // RVA: 0x7FFD54EB71D0
        public void set_fixedItemHeight(){} // RVA: 0x7FFD54EB71E0
        public void get_lastHeight(){} // RVA: 0x7FFD54EB72E0
        public void CreateVirtualizationController(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void GetOrCreateVirtualizationController(){} // RVA: 0x7FFD54EB6E70
        public void GetOrCreateViewController(){} // RVA: 0x7FFD54EB7330
        public void CreateViewController(){} // RVA: 0x7FFD4E078E90
        public void SetViewController(){} // RVA: 0x7FFD54EB7390
        public void CreateDragger(){} // RVA: 0x7FFD54EB77A0
        public void InitializeDragAndDropController(){} // RVA: 0x7FFD54EB7800
        public void CreateDragAndDropController(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD54EB84C0 | overloaded x2
        public void GetRootElementForId(){} // RVA: 0x7FFD54EB85C0
        public void HasValidDataAndBindings(){} // RVA: 0x7FFD54EB86D0
        public void OnItemIndexChanged(){} // RVA: 0x7FFD54EB8710
        public void OnItemsSourceChanged(){} // RVA: 0x7FFD54EB8750
        public void RefreshItems(){} // RVA: 0x7FFD54EB8770
        public void Rebuild(){} // RVA: 0x7FFD54EB88E0
        public void RefreshSelection(){} // RVA: 0x7FFD54EB8A50
        public void PostRefresh(){} // RVA: 0x7FFD54EB8CE0
        public void ScrollToItem(){} // RVA: 0x7FFD54EB8DA0
        public void ScrollToItemById(){} // RVA: 0x7FFD54EB8E20
        public void OnScroll(){} // RVA: 0x7FFD54EB8EC0
        public void Resize(){} // RVA: 0x7FFD54EB8F40
        public void OnAttachToPanel(){} // RVA: 0x7FFD54EB9000
        public void OnDetachFromPanel(){} // RVA: 0x7FFD54EB9450
        public void Apply(){} // RVA: 0x7FFD54EB9C50 | overloaded x2
        public void HandleItemNavigation(){} // RVA: 0x7FFD506288B0
        public void OnPointerMove(){} // RVA: 0x7FFD54EB9E20
        public void OnPointerDown(){} // RVA: 0x7FFD54EB9EB0
        public void OnPointerCancel(){} // RVA: 0x7FFD54EBA020
        public void OnPointerUp(){} // RVA: 0x7FFD54EBA0A0
        public void ProcessPointerDown(){} // RVA: 0x7FFD54EBA210
        public void ProcessPointerUp(){} // RVA: 0x7FFD54EBA430
        public void DoSelect(){} // RVA: 0x7FFD54EBA7A0
        public void DoRangeSelection(){} // RVA: 0x7FFD54EBACB0
        public void ProcessSingleClick(){} // RVA: 0x7FFD54EB6DE0
        public void SelectAll(){} // RVA: 0x7FFD54EBAE50
        public void AddToSelection(){} // RVA: 0x7FFD54EBB230 | overloaded x2
        public void AddToSelectionWithoutValidation(){} // RVA: 0x7FFD54EBB4D0
        public void RemoveFromSelection(){} // RVA: 0x7FFD54EBB900
        public void RemoveFromSelectionWithoutValidation(){} // RVA: 0x7FFD54EBB960
        public void SetSelection(){} // RVA: 0x7FFD54EBBD60 | overloaded x2
        public void SetSelectionWithoutNotify(){} // RVA: 0x7FFD54EBBD70
        public void SetSelectionInternal(){} // RVA: 0x7FFD54EBBD80
        public void MatchesExistingSelection(){} // RVA: 0x7FFD54EBBFD0
        public void NotifyOfSelectionChange(){} // RVA: 0x7FFD54EBC270
        public void ClearSelection(){} // RVA: 0x7FFD54EBC2E0
        public void ClearSelectionWithoutValidation(){} // RVA: 0x7FFD54EBC360
        public void OnViewDataReady(){} // RVA: 0x7FFD54EBC5C0
        public void ExecuteDefaultAction(){} // RVA: 0x7FFD54EBC600
        public void OnSizeChanged(){} // RVA: 0x7FFD54EBC9F0
        public void OnCustomStyleResolved(){} // RVA: 0x7FFD54EBCA90
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD54EB4E70
        public void .cctor(){} // RVA: 0x7FFD54EBCC50
        public void <.ctor>b__158_0(){} // RVA: 0x7FFD54EBD510
        public void <Apply>g__HandleSelectionAndScroll|181_0(){} // RVA: 0x7FFD54EBD5A0
    }

    public class BaseVisualElementPanel : Object
    {
        public System.Action`1<UnityEngine.UIElements.BaseVisualElementPanel> IMGUIEventInterests; // 0x10
        public 0x66484548 ownerObject; // 0x18
        public float saveViewData; // 0x20
        public 0x664739D8 getViewDataDictionary; // 0x28
        public float IMGUIContainersCount; // 0x30
        public float focusController; // 0x34
        public UnityEngine.UIElements.PanelClearSettings rootIMGUIContainer; // 0x38
        public bool uiElementsBridge; // 0x4C
        public 0x66480088 scale; // 0x50
        public 0x6647A258 pixelsPerPoint; // 0x58
        public 0x66474F80 scaledPixelsPerPoint; // 0x60
        public bool referenceSpritePixelsPerUnit; // 0x68
        public 0x6647BA68 clearSettings; // 0x70
        public System.Action duringLayoutPhase; // 0x78
        public System.Action version; // 0x80
        public System.Action hierarchyVersion; // 0x88
        public System.Action`1<UnityEngine.Material> repaintData; // 0x90
        public 0x664800E0 cursorManager; // 0x98
        public System.Action`1<UnityEngine.UIElements.IPanel> contextualMenuManager; // 0xA0

        // ── Methods ──
        public void get_IMGUIEventInterests(){}
        public void set_IMGUIEventInterests(){}
        public void get_ownerObject(){} // RVA: 0x7FFD4E078E90
        public void set_ownerObject(){} // RVA: 0x7FFD4E090A40
        public void get_saveViewData(){} // RVA: 0x7FFD4E078E90
        public void get_getViewDataDictionary(){} // RVA: 0x7FFD4E078E90
        public void get_IMGUIContainersCount(){} // RVA: 0x7FFD4E079960
        public void set_IMGUIContainersCount(){} // RVA: 0x7FFD4E090ED0
        public void get_focusController(){} // RVA: 0x7FFD4E078E90
        public void set_focusController(){} // RVA: 0x7FFD4E090A40
        public void get_rootIMGUIContainer(){} // RVA: 0x7FFD4E078E90
        public void add_panelDisposed(){} // RVA: 0x7FFD54FC67C0
        public void remove_panelDisposed(){} // RVA: 0x7FFD54FC68C0
        public void get_uiElementsBridge(){} // RVA: 0x7FFD54FC69C0
        public void .ctor(){} // RVA: 0x7FFD54FC6A30
        public void Dispose(){} // RVA: 0x7FFD54FC6DF0 | overloaded x2
        public void Repaint(){} // RVA: 0x7FFD4E090A40
        public void ValidateFocus(){} // RVA: 0x7FFD4E090980
        public void ValidateLayout(){} // RVA: 0x7FFD4E090980
        public void UpdateAnimations(){} // RVA: 0x7FFD4E090980
        public void UpdateBindings(){} // RVA: 0x7FFD4E090980
        public void ApplyStyles(){} // RVA: 0x7FFD4E090980
        public void get_scale(){} // RVA: 0x7FFD54C32640
        public void set_scale(){} // RVA: 0x7FFD54FC71A0
        public void set_pixelsPerPoint(){} // RVA: 0x7FFD54FC7280
        public void get_scaledPixelsPerPoint(){} // RVA: 0x7FFD54FC7360
        public void get_referenceSpritePixelsPerUnit(){} // RVA: 0x7FFD4E40B630
        public void set_referenceSpritePixelsPerUnit(){} // RVA: 0x7FFD4E40B640
        public void get_clearSettings(){} // RVA: 0x7FFD54FC7370
        public void set_clearSettings(){} // RVA: 0x7FFD54FC7390
        public void get_duringLayoutPhase(){} // RVA: 0x7FFD4F588960
        public void set_duringLayoutPhase(){} // RVA: 0x7FFD4F58A6F0
        public void get_version(){} // RVA: 0x7FFD4E079960
        public void get_hierarchyVersion(){} // RVA: 0x7FFD4E079960
        public void OnVersionChanged(){} // RVA: 0x7FFD4E097970
        public void get_repaintData(){} // RVA: 0x7FFD4E3E20E0
        public void set_repaintData(){} // RVA: 0x7FFD4E4994D0
        public void get_cursorManager(){} // RVA: 0x7FFD4E409500
        public void set_cursorManager(){} // RVA: 0x7FFD4E409510
        public void get_contextualMenuManager(){} // RVA: 0x7FFD4E3DF370
        public void set_contextualMenuManager(){} // RVA: 0x7FFD4E3DF380
        public void get_visualTree(){} // RVA: 0x7FFD4E078E90
        public void get_dispatcher(){} // RVA: 0x7FFD4E078E90
        public void set_dispatcher(){} // RVA: 0x7FFD4E090A40
        public void SendEvent(){} // RVA: 0x7FFD54FC73A0
        public void get_scheduler(){} // RVA: 0x7FFD4E078E90
        public void get_styleAnimationSystem(){} // RVA: 0x7FFD4E078E90
        public void set_styleAnimationSystem(){} // RVA: 0x7FFD4E090A40
        public void get_contextType(){} // RVA: 0x7FFD4E079960
        public void set_contextType(){} // RVA: 0x7FFD4E090ED0
        public void Pick(){}
        public void PickAll(){}
        public void get_disposed(){} // RVA: 0x7FFD4E409570
        public void set_disposed(){} // RVA: 0x7FFD4E409580
        public void GetUpdater(){} // RVA: 0x7FFD4E087DE0
        public void GetTopElementUnderPointer(){} // RVA: 0x7FFD54FC7470
        public void RecomputeTopElementUnderPointer(){} // RVA: 0x7FFD54FC74B0
        public void ClearCachedElementUnderPointer(){} // RVA: 0x7FFD54FC75F0
        public void CommitElementUnderPointers(){} // RVA: 0x7FFD54FC7630
        public void get_standardShader(){} // RVA: 0x7FFD4E078E90
        public void get_standardWorldSpaceShader(){} // RVA: 0x7FFD51B532B0
        public void add_standardShaderChanged(){} // RVA: 0x7FFD54FC76A0
        public void remove_standardShaderChanged(){} // RVA: 0x7FFD54FC7790
        public void add_standardWorldSpaceShaderChanged(){} // RVA: 0x7FFD54FC7880
        public void remove_standardWorldSpaceShaderChanged(){} // RVA: 0x7FFD54FC7970
        public void add_atlasChanged(){} // RVA: 0x7FFD54FC7A60
        public void remove_atlasChanged(){} // RVA: 0x7FFD54FC7B50
        public void InvokeAtlasChanged(){} // RVA: 0x7FFD54FC7C40
        public void get_atlas(){} // RVA: 0x7FFD4E078E90
        public void set_atlas(){} // RVA: 0x7FFD4E090A40
        public void InvokeUpdateMaterial(){} // RVA: 0x7FFD54FC7C60
        public void add_hierarchyChanged(){} // RVA: 0x7FFD54FC7C80
        public void remove_hierarchyChanged(){} // RVA: 0x7FFD54FC7D70
        public void InvokeHierarchyChanged(){} // RVA: 0x7FFD54FC7E60
        public void InvokeBeforeUpdate(){} // RVA: 0x7FFD54FC7E90
        public void UpdateElementUnderPointers(){} // RVA: 0x7FFD54FC7EB0
        public void UnityEngine.UIElements.IGroupBox.OnOptionAdded(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(){} // RVA: 0x7FFD4E341310
        public void Update(){} // RVA: 0x7FFD54FC8170
    }

    public class BindableElement : VisualElement
    {
        public 0x664758C8 binding; // 0x3C8
        public string bindingPath; // 0x3D0

        // ── Methods ──
        public void get_binding(){} // RVA: 0x7FFD4EDE0A20
        public void set_bindingPath(){} // RVA: 0x7FFD4EDF0F60
        public void .ctor(){} // RVA: 0x7FFD54E9DD30
    }

}