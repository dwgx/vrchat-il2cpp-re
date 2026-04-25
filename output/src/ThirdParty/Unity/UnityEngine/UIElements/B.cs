// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 31
// Methods: 583

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Background : ValueType
    {
        public UnityEngine.Texture2D texture; // 0x10
        public UnityEngine.Sprite sprite; // 0x18
        public UnityEngine.RenderTexture renderTexture; // 0x20
        public UnityEngine.UIElements.VectorImage vectorImage; // 0x28

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFAC51D9A30
        public void set_texture(){} // RVA: 0x7FFAC9BD3B40
        public void get_sprite(){} // RVA: 0x7FFAC86B4B80
        public void set_sprite(){} // RVA: 0x7FFAC9BD3DB0
        public void get_renderTexture(){} // RVA: 0x7FFAC5CC4750
        public void set_renderTexture(){} // RVA: 0x7FFAC9BD4020
        public void get_vectorImage(){} // RVA: 0x7FFAC58A1130
        public void set_vectorImage(){} // RVA: 0x7FFAC9BD4290
        public void FromTexture2D(){} // RVA: 0x7FFAC9BD4500
        public void FromRenderTexture(){} // RVA: 0x7FFAC9BD4550
        public void FromSprite(){} // RVA: 0x7FFAC9BD45A0
        public void FromVectorImage(){} // RVA: 0x7FFAC9BD45F0
        public void FromObject(){} // RVA: 0x7FFAC9BD4640
        public void op_Equality(){} // RVA: 0x7FFAC9BD4A70
        public void op_Inequality(){} // RVA: 0x7FFAC9BD4E40
        public void Equals(){} // RVA: 0x7FFAC9BD4EC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BD4F70
        public void ToString(){} // RVA: 0x7FFAC9BD5040
    }

    public class BackgroundPosition : ValueType
    {
        public 0x6B122B28 keyword; // 0x10
        public UnityEngine.UIElements.Length offset; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60F16B0 | overloaded x2
        public void Initial(){} // RVA: 0x7FFAC9A7CD40
        public void Equals(){} // RVA: 0x7FFAC9A7CE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9A7CE80
        public void op_Equality(){} // RVA: 0x7FFAC9A7CEB0
        public void op_Inequality(){} // RVA: 0x7FFAC9A7CF10
        public void ToString(){} // RVA: 0x7FFAC9A7CF90
    }

    public class BackgroundPropertyHelper : Object
    {
        // ── Methods ──
        public void ConvertScaleModeToBackgroundPosition(){} // RVA: 0x7FFAC9A7D070
        public void ConvertScaleModeToBackgroundRepeat(){} // RVA: 0x7FFAC9A7D0A0
        public void ConvertScaleModeToBackgroundSize(){} // RVA: 0x7FFAC9A7D0B0
        public void ResolveUnityBackgroundScaleMode(){} // RVA: 0x7FFAC9A7D190
    }

    public class BackgroundRepeat : ValueType
    {
        public 0x6B122B80 x; // 0x10
        public 0x6B122B80 y; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC33D6D50
        public void Initial(){} // RVA: 0x7FFAC9A7D650
        public void Equals(){} // RVA: 0x7FFAC9A7D700 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9A7D720
        public void op_Equality(){} // RVA: 0x7FFAC9A7D740
        public void op_Inequality(){} // RVA: 0x7FFAC9A7D760
        public void ToString(){} // RVA: 0x7FFAC9A7D780
    }

    public class BackgroundSize : ValueType
    {
        public 0x6B122BD8 sizeType; // 0x10
        public UnityEngine.UIElements.Length x; // 0x14
        public UnityEngine.UIElements.Length y; // 0x1C

        // ── Methods ──
        public void get_sizeType(){} // RVA: 0x7FFAC8F93F90
        public void set_sizeType(){} // RVA: 0x7FFAC9A7D850
        public void get_x(){} // RVA: 0x7FFAC86B94A0
        public void set_x(){} // RVA: 0x7FFAC9A7D880
        public void get_y(){} // RVA: 0x7FFAC9A7D890
        public void set_y(){} // RVA: 0x7FFAC9A7D8A0
        public void .ctor(){} // RVA: 0x7FFAC9A7D850 | overloaded x2
        public void Initial(){} // RVA: 0x7FFAC9A7D8C0
        public void Equals(){} // RVA: 0x7FFAC9A7DA30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9A7DAA0
        public void op_Equality(){} // RVA: 0x7FFAC9A7DB00
        public void op_Inequality(){} // RVA: 0x7FFAC9A7DB80
        public void ToString(){} // RVA: 0x7FFAC9A7DC10
    }

    public class BaseBoolField : BaseField`1
    {
        public UnityEngine.UIElements.Label text; // 0x440
        public UnityEngine.UIElements.VisualElement m_CheckMark; // 0x448
        public UnityEngine.UIElements.Clickable m_Clickable; // 0x450
        public string m_OriginalText; // 0x458

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A8F720
        public void OnNavigationSubmit(){} // RVA: 0x7FFAC9A8FC40
        public void get_text(){} // RVA: 0x7FFAC9A8FC80
        public void set_text(){} // RVA: 0x7FFAC9A8FCB0
        public void InitLabel(){} // RVA: 0x7FFAC9A8FDA0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9A8FEB0
        public void OnClickEvent(){} // RVA: 0x7FFAC9A90000
        public void ToggleValue(){} // RVA: 0x7FFAC9A90210
        public void UpdateMixedValueContent(){} // RVA: 0x7FFAC9A90250
        public void RegisterEditingCallbacks(){} // RVA: 0x7FFAC9A90440
        public void UnregisterEditingCallbacks(){} // RVA: 0x7FFAC9A90540
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
        public void GetSpacer(){} // RVA: 0x7FFAC2C58E90
        public void DescribeFields(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C77970
        public void UpdateDisplay(){} // RVA: 0x7FFAC2C70980
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC2E8DC40
        public void OnViewDataReady(){} // RVA: 0x7FFAC2C70980
        public void UpdateMixedValueContent(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class BaseFieldMouseDragger : Object
    {
        // ── Methods ──
        public void SetDragZone(){} // RVA: 0x7FFAC9B92FE0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BaseFieldTraits`2 : UxmlTraits
    {
        public T m_Value;

        // ── Methods ──
        public void Init(){}
        public void .ctor(){} // RVA: 0x7FFAC2C70980
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
        public U m_Value; // 0x3F0
        public System.Func`2<U,U> onValidateValue; // 0x3F8
        public UnityEngine.UIElements.Label <labelElement>k__BackingField; // 0x400
        public bool m_ShowMixedValue; // 0x408
        public UnityEngine.UIElements.Label m_MixedValueLabel; // 0x410
        public bool m_SkipValidation; // 0x418
        public UnityEngine.UIElements.VisualElement m_CachedContextWidthElement; // 0x420
        public UnityEngine.UIElements.VisualElement m_CachedInspectorElement; // 0x428
        public System.Action <UnityEngine.UIElements.IEditableElement.editingStarted>k__BackingField; // 0x430
        public System.Action <UnityEngine.UIElements.IEditableElement.editingEnded>k__BackingField; // 0x438

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x7FFAC7C82120
        public void set_visualInput(){} // RVA: 0x7FFAC7C82160
        public void get_rawValue(){} // RVA: 0x7FFAC2E5B230
        public void set_rawValue(){} // RVA: 0x7FFAC7C825B0
        public void add_onValidateValue(){} // RVA: 0x7FFAC7C82680
        public void remove_onValidateValue(){} // RVA: 0x7FFAC7C827F0
        public void get_value(){} // RVA: 0x7FFAC2E5B230
        public void set_value(){} // RVA: 0x7FFAC7C82960
        public void get_labelElement(){} // RVA: 0x7FFAC7C82E60
        public void set_labelElement(){} // RVA: 0x7FFAC7C82EA0
        public void get_label(){} // RVA: 0x7FFAC7C82F20
        public void set_label(){} // RVA: 0x7FFAC7C82F70
        public void get_showMixedValue(){} // RVA: 0x7FFAC7C83280
        public void set_showMixedValue(){} // RVA: 0x7FFAC7C832C0
        public void get_mixedValueLabel(){} // RVA: 0x7FFAC7C83350
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0x7FFAC7C835B0
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0x7FFAC7C835F0
        public void .ctor(){} // RVA: 0x7FFAC7C83A20 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x7FFAC7C83A80
        public void OnDetachFromPanel(){} // RVA: 0x7FFAC7C83E10
        public void RegisterEditingCallbacks(){} // RVA: 0x7FFAC7C83EC0
        public void UnregisterEditingCallbacks(){} // RVA: 0x7FFAC7C83FD0
        public void StartEditing(){} // RVA: 0x7FFAC7C84130
        public void EndEditing(){} // RVA: 0x7FFAC7C841A0
        public void OnCustomStyleResolved(){} // RVA: 0x7FFAC7C84210
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x7FFAC7C84740
        public void AlignLabel(){} // RVA: 0x7FFAC7C84760
        public void ValidatedValue(){} // RVA: 0x7FFAC2E5B230
        public void UpdateMixedValueContent(){} // RVA: 0x7FFAC5C85BA0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC7C84F70
        public void OnViewDataReady(){} // RVA: 0x7FFAC7C85190
        public void GetTooltipRect(){} // RVA: 0x7FFAC7C85610
        public void .cctor(){} // RVA: 0x7FFAC7C856D0
    }

    public class BaseListView : BaseVerticalCollectionView
    {
        public string showBoundCollectionSize;
        public bool showFoldoutHeader; // 0x4B0
        public bool headerTitle; // 0x4B1
        public string showAddRemoveFooter; // 0x4B8
        public System.Action`1<System.Collections.Generic.IEnumerable`1<int>> footer; // 0x4C0
        public System.Action`1<System.Collections.Generic.IEnumerable`1<int>> viewController; // 0x4C8
        public System.Action reorderMode; // 0x4D0
        public UnityEngine.UIElements.Label m_ListViewLabel; // 0x4D8
        public UnityEngine.UIElements.Foldout m_Foldout; // 0x4E0
        public UnityEngine.UIElements.TextField m_ArraySizeField; // 0x4E8
        public bool m_IsOverMultiEditLimit; // 0x4F0
        public UnityEngine.UIElements.VisualElement m_Footer; // 0x4F8
        public UnityEngine.UIElements.Button m_AddButton; // 0x500
        public UnityEngine.UIElements.Button m_RemoveButton; // 0x508
        public System.Action`1<System.Collections.Generic.IEnumerable`1<int>> m_ItemAddedCallback; // 0x510
        public System.Action`1<System.Collections.Generic.IEnumerable`1<int>> m_ItemRemovedCallback; // 0x518
        public System.Action m_ItemsSourceSizeChangedCallback; // 0x520
        public 0x6B1151E8 m_ReorderMode; // 0x528
        public System.Action reorderModeChanged; // 0x530
        public string ussClassName; // 0x8
        public string itemUssClassName; // 0x10
        public string emptyLabelUssClassName; // 0x18
        public string overMaxMultiEditLimitClassName; // 0x20
        public string reorderableUssClassName; // 0x28
        public string reorderableItemUssClassName; // 0x30
        public string reorderableItemContainerUssClassName; // 0x38
        public string reorderableItemHandleUssClassName; // 0x40
        public string reorderableItemHandleBarUssClassName; // 0x48
        public string footerUssClassName; // 0x50
        public string foldoutHeaderUssClassName; // 0x58
        public string arraySizeFieldUssClassName; // 0x60
        public string arraySizeFieldWithHeaderUssClassName; // 0x68
        public string arraySizeFieldWithFooterUssClassName; // 0x70
        public string listViewWithHeaderUssClassName; // 0x78
        public string listViewWithFooterUssClassName; // 0x80
        public string scrollViewWithFooterUssClassName; // 0x88
        public string footerAddButtonName; // 0x90
        public string footerRemoveButtonName; // 0x98
        public string m_MaxMultiEditStr; // 0x538
        public string k_EmptyListStr; // 0xA0

        // ── Methods ──
        public void get_showBoundCollectionSize(){} // RVA: 0x7FFAC9A90670
        public void set_showBoundCollectionSize(){} // RVA: 0x7FFAC9A90680
        public void get_showFoldoutHeader(){} // RVA: 0x7FFAC9A906A0
        public void set_showFoldoutHeader(){} // RVA: 0x7FFAC9A906B0
        public void SetupArraySizeField(){} // RVA: 0x7FFAC9A90AE0
        public void set_headerTitle(){} // RVA: 0x7FFAC9A90F60
        public void get_showAddRemoveFooter(){} // RVA: 0x7FFAC9A90FE0
        public void set_showAddRemoveFooter(){} // RVA: 0x7FFAC9A90FF0
        public void EnableFooter(){} // RVA: 0x7FFAC9A91000
        public void AddItems(){} // RVA: 0x7FFAC9A916F0
        public void OnArraySizeFieldChanged(){} // RVA: 0x7FFAC9A91730
        public void UpdateArraySizeField(){} // RVA: 0x7FFAC9A91A50
        public void UpdateListViewLabel(){} // RVA: 0x7FFAC9A91B50
        public void OnAddClicked(){} // RVA: 0x7FFAC9A91E10
        public void OnRemoveClicked(){} // RVA: 0x7FFAC9A91FF0
        public void get_footer(){} // RVA: 0x7FFAC39AE5C0
        public void get_viewController(){} // RVA: 0x7FFAC9A92260
        public void CreateVirtualizationController(){} // RVA: 0x7FFAC9A922F0
        public void SetViewController(){} // RVA: 0x7FFAC9A92330
        public void OnItemAdded(){} // RVA: 0x7FFAC9A92B60
        public void OnItemsRemoved(){} // RVA: 0x7FFAC9A92B80
        public void OnItemsSourceSizeChanged(){} // RVA: 0x7FFAC9A92BA0
        public void add_reorderModeChanged(){} // RVA: 0x7FFAC9A92C70
        public void remove_reorderModeChanged(){} // RVA: 0x7FFAC9A92D60
        public void get_reorderMode(){} // RVA: 0x7FFAC9A92E50
        public void set_reorderMode(){} // RVA: 0x7FFAC9A92E60
        public void CreateDragger(){} // RVA: 0x7FFAC9A92EC0
        public void CreateDragAndDropController(){} // RVA: 0x7FFAC9A92F40
        public void .ctor(){} // RVA: 0x7FFAC9A92FE0
        public void PostRefresh(){} // RVA: 0x7FFAC9A930C0
        public void HandleItemNavigation(){} // RVA: 0x7FFAC9A931A0
        public void .cctor(){} // RVA: 0x7FFAC9A93500
        public void <OnAddClicked>b__36_0(){} // RVA: 0x7FFAC9A94200
    }

    public class BaseListViewController : CollectionViewController
    {
        public System.Action baseListView; // 0x30
        public System.Action`1<System.Collections.Generic.IEnumerable`1<int>> itemsAdded; // 0x38
        public System.Action`1<System.Collections.Generic.IEnumerable`1<int>> itemsRemoved; // 0x40

        // ── Methods ──
        public void add_itemsSourceSizeChanged(){} // RVA: 0x7FFAC9A83AF0
        public void remove_itemsSourceSizeChanged(){} // RVA: 0x7FFAC9A83BE0
        public void add_itemsAdded(){} // RVA: 0x7FFAC9A83CD0
        public void remove_itemsAdded(){} // RVA: 0x7FFAC9A83DD0
        public void add_itemsRemoved(){} // RVA: 0x7FFAC9A83ED0
        public void remove_itemsRemoved(){} // RVA: 0x7FFAC9A83FD0
        public void get_baseListView(){} // RVA: 0x7FFAC9A840D0
        public void InvokeMakeItem(){} // RVA: 0x7FFAC9A84160
        public void PostInitRegistration(){} // RVA: 0x7FFAC9A84360
        public void InvokeBindItem(){} // RVA: 0x7FFAC9A84680
        public void NeedsDragHandle(){} // RVA: 0x7FFAC4BF82C0
        public void AddItems(){} // RVA: 0x7FFAC9A84930
        public void Move(){} // RVA: 0x7FFAC9A84F60
        public void RemoveItem(){} // RVA: 0x7FFAC9A851B0
        public void RemoveItems(){} // RVA: 0x7FFAC9A85630 | overloaded x2
        public void ClearItems(){} // RVA: 0x7FFAC9A85800
        public void RaiseOnSizeChanged(){} // RVA: 0x7FFAC9A85920
        public void RaiseItemsAdded(){} // RVA: 0x7FFAC9A85940
        public void RaiseItemsRemoved(){} // RVA: 0x7FFAC7870F30
        public void AddToArray(){} // RVA: 0x7FFAC9A85960
        public void RemoveFromArray(){} // RVA: 0x7FFAC9A85B40
        public void Swap(){} // RVA: 0x7FFAC9A85CF0
        public void EnsureItemSourceCanBeResized(){} // RVA: 0x7FFAC9A85E30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void <AddItems>g__IsGenericList|15_0(){} // RVA: 0x7FFAC9A85F70
    }

    public class BasePopupField`2 : BaseField`1
    {
        public System.Collections.Generic.List`1<T> textElement; // 0x440
        public UnityEngine.UIElements.TextElement choices; // 0x448
        public UnityEngine.UIElements.VisualElement m_ArrowElement; // 0x450
        public System.Func`2<T,string> m_FormatSelectedValueCallback; // 0x458
        public System.Func`2<T,string> m_FormatListItemCallback; // 0x460
        public System.Func`1<UnityEngine.UIElements.IGenericMenu> createMenuCallback; // 0x468
        public string ussClassName;
        public string textUssClassName; // 0x8
        public string arrowUssClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20

        // ── Methods ──
        public void get_textElement(){} // RVA: 0x7FFAC7D9C460
        public void GetValueToDisplay(){} // RVA: 0x7FFAC2C58E90
        public void GetListItemToDisplay(){} // RVA: 0x7FFAC2E8DC40
        public void AddMenuItems(){} // RVA: 0x7FFAC2C70A40
        public void set_choices(){} // RVA: 0x7FFAC7D9C490
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC7D9C5E0
        public void .ctor(){} // RVA: 0x7FFAC7D9C750
        public void OnPointerDownEvent(){} // RVA: 0x7FFAC7D9D050
        public void OnPointerMoveEvent(){} // RVA: 0x7FFAC7D9D070
        public void ContainsPointer(){} // RVA: 0x7FFAC7D9D110
        public void ProcessPointerDown(){} // RVA: 0x7FFAC2C70A40
        public void OnNavigationSubmit(){} // RVA: 0x7FFAC7D9D1B0
        public void ShowMenu(){} // RVA: 0x7FFAC7D9D1F0
        public void UpdateMixedValueContent(){} // RVA: 0x7FFAC7D9D3A0
        public void .cctor(){} // RVA: 0x7FFAC7D9D670
    }

    public class BaseReorderableDragAndDropController : Object
    {
        public UnityEngine.UIElements.BaseVerticalCollectionView enableReordering; // 0x10
        public System.Collections.Generic.List`1<int> m_SortedSelectedIds; // 0x18
        public bool <enableReordering>k__BackingField; // 0x20

        // ── Methods ──
        public void GetSortedSelectedIds(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC9B6F1C0
        public void get_enableReordering(){} // RVA: 0x7FFAC300F9D0
        public void set_enableReordering(){} // RVA: 0x7FFAC300F9E0
        public void CanStartDrag(){} // RVA: 0x7FFAC42D3240
        public void SetupDragAndDrop(){} // RVA: 0x7FFAC9B6F2E0
        public void CompareId(){} // RVA: 0x7FFAC5D73510
        public void HandleDragAndDrop(){} // RVA: 0x7FFAC2C5E6B0
        public void OnDrop(){} // RVA: 0x7FFAC2C70A40
        public void DragCleanup(){} // RVA: 0x7FFAC2F21310
        public void HandleAutoExpand(){} // RVA: 0x7FFAC2F21310
    }

    public class BaseRuntimePanel : Panel
    {
        public UnityEngine.GameObject selectableGameObject; // 0x160
        public int sortingPriority;
        public int standardWorldSpaceShader; // 0x168
        public float drawToCameras; // 0x16C
        public int targetDisplay; // 0x170
        public System.Action screenRenderingWidth; // 0x178
        public UnityEngine.Shader screenRenderingHeight; // 0x180
        public bool screenToPanelSpace; // 0x188
        public UnityEngine.RenderTexture targetTexture; // 0x190
        public UnityEngine.Matrix4x4 panelToWorld; // 0x198
        public int <targetDisplay>k__BackingField; // 0x1D8
        public System.Func`2<UnityEngine.Vector2,UnityEngine.Vector2> DefaultScreenToPanelSpace; // 0x8
        public System.Func`2<UnityEngine.Vector2,UnityEngine.Vector2> m_ScreenToPanelSpace; // 0x1E0

        // ── Methods ──
        public void get_selectableGameObject(){} // RVA: 0x7FFAC33A98A0
        public void set_selectableGameObject(){} // RVA: 0x7FFAC9BAA9C0
        public void get_sortingPriority(){} // RVA: 0x7FFAC9BAAB60
        public void set_sortingPriority(){} // RVA: 0x7FFAC9BAAB70
        public void add_destroyed(){} // RVA: 0x7FFAC9BAAC40
        public void remove_destroyed(){} // RVA: 0x7FFAC9BAAD30
        public void .ctor(){} // RVA: 0x7FFAC9BAAE20
        public void Dispose(){} // RVA: 0x7FFAC9BAB020
        public void get_standardWorldSpaceShader(){} // RVA: 0x7FFAC99FDD50
        public void get_drawToCameras(){} // RVA: 0x7FFAC9BAB1C0
        public void set_drawToCameras(){} // RVA: 0x7FFAC9BAB1D0
        public void get_targetDisplay(){} // RVA: 0x7FFAC9BAB290
        public void set_targetDisplay(){} // RVA: 0x7FFAC9BAB2A0
        public void get_screenRenderingWidth(){} // RVA: 0x7FFAC9BAB2B0
        public void get_screenRenderingHeight(){} // RVA: 0x7FFAC9BAB310
        public void getScreenRenderingHeight(){} // RVA: 0x7FFAC9BAB370
        public void getScreenRenderingWidth(){} // RVA: 0x7FFAC9BAB460
        public void Repaint(){} // RVA: 0x7FFAC9BAB550
        public void get_screenToPanelSpace(){} // RVA: 0x7FFAC33F8150
        public void set_screenToPanelSpace(){} // RVA: 0x7FFAC9BABB50
        public void ScreenToPanel(){} // RVA: 0x7FFAC9BABC80 | overloaded x2
        public void AssignPanelToComponents(){} // RVA: 0x7FFAC9BABF20
        public void PointerLeavesPanel(){} // RVA: 0x7FFAC9BAC300
        public void PointerEntersPanel(){} // RVA: 0x7FFAC9BAC3D0
        public void .cctor(){} // RVA: 0x7FFAC9BAC470
    }

    public class BaseSlider`1 : BaseField`1
    {
        public UnityEngine.UIElements.VisualElement dragContainer;
        public UnityEngine.UIElements.VisualElement dragElement;
        public UnityEngine.UIElements.VisualElement trackElement;
        public UnityEngine.UIElements.VisualElement dragBorderElement;
        public UnityEngine.UIElements.TextField inputTextField;
        public bool lowValue;
        public T highValue;
        public T pageSize;
        public float showInputField;
        public bool clamped;
        public bool clampedDragger;
        public UnityEngine.UIElements.ClampedDragger`1<T> value;
        public UnityEngine.Rect direction;
        public 0x6B1153F8 inverted;
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
        public void get_dragContainer(){} // RVA: 0x7FFAC2C58E90
        public void set_dragContainer(){} // RVA: 0x7FFAC2C70A40
        public void get_dragElement(){} // RVA: 0x7FFAC2C58E90
        public void set_dragElement(){} // RVA: 0x7FFAC2C70A40
        public void get_trackElement(){} // RVA: 0x7FFAC2C58E90
        public void set_trackElement(){} // RVA: 0x7FFAC2C70A40
        public void get_dragBorderElement(){} // RVA: 0x7FFAC2C58E90
        public void set_dragBorderElement(){} // RVA: 0x7FFAC2C70A40
        public void get_inputTextField(){} // RVA: 0x7FFAC2C58E90
        public void set_inputTextField(){} // RVA: 0x7FFAC2C70A40
        public void get_lowValue(){} // RVA: 0x7FFAC2E8DC40
        public void set_lowValue(){} // RVA: 0x7FFAC2E8DC40
        public void get_highValue(){} // RVA: 0x7FFAC2E8DC40
        public void set_highValue(){} // RVA: 0x7FFAC2E8DC40
        public void SetHighValueWithoutNotify(){} // RVA: 0x7FFAC2E8DC40
        public void get_pageSize(){} // RVA: 0x7FFAC2C6D880
        public void set_pageSize(){} // RVA: 0x7FFAC2C7E480
        public void get_showInputField(){} // RVA: 0x7FFAC2C59D00
        public void set_showInputField(){} // RVA: 0x7FFAC2C71060
        public void get_clamped(){} // RVA: 0x7FFAC2C59D00
        public void set_clamped(){} // RVA: 0x7FFAC2C71060
        public void get_clampedDragger(){} // RVA: 0x7FFAC2C58E90
        public void set_clampedDragger(){} // RVA: 0x7FFAC2C70A40
        public void Clamp(){} // RVA: 0x7FFAC2E8DC40
        public void GetClampedValue(){} // RVA: 0x7FFAC2E8DC40
        public void get_value(){} // RVA: 0x7FFAC2E8DC40
        public void set_value(){} // RVA: 0x7FFAC2E8DC40
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC2E8DC40
        public void UnityEngine.UIElements.IValueField<TValueType>.StartDragging(){} // RVA: 0x7FFAC2C70980
        public void UnityEngine.UIElements.IValueField<TValueType>.StopDragging(){} // RVA: 0x7FFAC2C70980
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC2E8DC40
        public void get_direction(){} // RVA: 0x7FFAC2C59960
        public void set_direction(){} // RVA: 0x7FFAC2C70ED0
        public void get_inverted(){} // RVA: 0x7FFAC2C59D00
        public void set_inverted(){} // RVA: 0x7FFAC2C71060
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetClosestPowerOfTen(){} // RVA: 0x7FFAC2C6EA30
        public void RoundToMultipleOf(){}
        public void ClampValue(){} // RVA: 0x7FFAC2C70980
        public void SliderLerpUnclamped(){} // RVA: 0x7FFAC2E8DC40
        public void SliderNormalizeValue(){} // RVA: 0x7FFAC2E8DC40
        public void ParseStringToValue(){} // RVA: 0x7FFAC2E8DC40
        public void ComputeValueFromKey(){} // RVA: 0x7FFAC2E8DC40
        public void SliderLerpDirectionalUnclamped(){} // RVA: 0x7FFAC2E8DC40
        public void SetSliderValueFromDrag(){} // RVA: 0x7FFAC2C70980
        public void ComputeValueAndDirectionFromDrag(){} // RVA: 0x7FFAC2C7EB40
        public void SetSliderValueFromClick(){} // RVA: 0x7FFAC2C70980
        public void OnKeyDown(){} // RVA: 0x7FFAC2C70A40
        public void OnNavigationMove(){} // RVA: 0x7FFAC2C70A40
        public void ComputeValueAndDirectionFromClick(){}
        public void AdjustDragElement(){} // RVA: 0x7FFAC2C7E480
        public void UpdateDragElementPosition(){} // RVA: 0x7FFAC2C70980 | overloaded x2
        public void OnViewDataReady(){} // RVA: 0x7FFAC2C70980
        public void SameValues(){} // RVA: 0x7FFAC2E8DC40
        public void ExecuteDefaultAction(){} // RVA: 0x7FFAC2C70A40
        public void UpdateTextFieldVisibility(){} // RVA: 0x7FFAC2C70980
        public void UpdateTextFieldValue(){} // RVA: 0x7FFAC2C70980
        public void OnTextFieldFocusIn(){} // RVA: 0x7FFAC2C70A40
        public void OnTextFieldFocusOut(){} // RVA: 0x7FFAC2C70A40
        public void OnInputNavigationMoveEvent(){} // RVA: 0x7FFAC2C70A40
        public void OnTextFieldValueChange(){} // RVA: 0x7FFAC2C70A40
        public void UpdateMixedValueContent(){} // RVA: 0x7FFAC2C70980
        public void RegisterEditingCallbacks(){} // RVA: 0x7FFAC2C70980
        public void UnregisterEditingCallbacks(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class BaseTreeView : BaseVerticalCollectionView
    {
        public string itemsSource;
        public string viewController; // 0x8
        public string autoExpand; // 0x10
        public string expandedItemIds; // 0x18
        public string itemIndentUssClassName; // 0x20
        public string itemContentContainerUssClassName; // 0x28
        public bool m_AutoExpand; // 0x4B0
        public System.Collections.Generic.List`1<int> m_ExpandedItemIds; // 0x4B8

        // ── Methods ──
        public void get_itemsSource(){} // RVA: 0x7FFAC9A94C40
        public void get_viewController(){} // RVA: 0x7FFAC9A94C80
        public void CreateVirtualizationController(){} // RVA: 0x7FFAC9A94D10
        public void SetViewController(){} // RVA: 0x7FFAC9A94D50
        public void OnItemIndexChanged(){} // RVA: 0x7FFAC9A94E70
        public void CreateDragAndDropController(){} // RVA: 0x7FFAC9A94E80
        public void get_autoExpand(){} // RVA: 0x7FFAC9A90670
        public void set_autoExpand(){} // RVA: 0x7FFAC9A95050
        public void get_expandedItemIds(){} // RVA: 0x7FFAC39C0420
        public void set_expandedItemIds(){} // RVA: 0x7FFAC39C78A0
        public void .ctor(){} // RVA: 0x7FFAC9A950A0 | overloaded x2
        public void OnViewDataReady(){} // RVA: 0x7FFAC9A952C0
        public void HandleItemNavigation(){} // RVA: 0x7FFAC9A95340
        public void SetSelectionById(){} // RVA: 0x7FFAC9A95AC0 | overloaded x2
        public void SetSelectionInternalById(){} // RVA: 0x7FFAC9A95C10
        public void GetItemIndex(){} // RVA: 0x7FFAC9A95D70
        public void IsExpanded(){} // RVA: 0x7FFAC9A95F50
        public void CollapseItem(){} // RVA: 0x7FFAC9A95F80
        public void ExpandItem(){} // RVA: 0x7FFAC9A95FE0
        public void OnTreeViewPointerUp(){} // RVA: 0x7FFAC9A96030
        public void IsExpandedByIndex(){} // RVA: 0x7FFAC9A96080
        public void CollapseItemByIndex(){} // RVA: 0x7FFAC9A960B0
        public void ExpandItemByIndex(){} // RVA: 0x7FFAC9A96130
        public void .cctor(){} // RVA: 0x7FFAC9A961C0
        public void <SetSelectionInternalById>b__47_0(){} // RVA: 0x7FFAC9A965A0
    }

    public class BaseTreeViewController : CollectionViewController
    {
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.UIElements.TreeItem> baseTreeView; // 0x30
        public System.Collections.Generic.List`1<int> itemsSource; // 0x38
        public System.Collections.Generic.List`1<UnityEngine.UIElements.TreeViewItemWrapper> m_ItemWrappers; // 0x40
        public System.Collections.Generic.HashSet`1<int> m_TreeItemIdsWithItemWrappers; // 0x48
        public System.Collections.Generic.List`1<UnityEngine.UIElements.TreeViewItemWrapper> m_WrapperInsertionList; // 0x50
        public Unity.Profiling.ProfilerMarker K_ExpandItemByIndex;
        public Unity.Profiling.ProfilerMarker k_CreateWrappers; // 0x8

        // ── Methods ──
        public void get_baseTreeView(){} // RVA: 0x7FFAC9A86040
        public void get_itemsSource(){} // RVA: 0x7FFAC2F247C0
        public void set_itemsSource(){} // RVA: 0x7FFAC9A860D0
        public void RebuildTree(){} // RVA: 0x7FFAC9A86120
        public void GetRootItemIds(){} // RVA: 0x7FFAC991F6C0
        public void GetAllItemIds(){} // RVA: 0x7FFAC2C58F40
        public void GetParentId(){} // RVA: 0x7FFAC2C600D0
        public void GetChildrenIds(){} // RVA: 0x7FFAC2C67DE0
        public void Move(){}
        public void InvokeMakeItem(){} // RVA: 0x7FFAC9A864C0
        public void InvokeBindItem(){} // RVA: 0x7FFAC9A86590
        public void InvokeDestroyItem(){} // RVA: 0x7FFAC9A866B0
        public void PostInitRegistration(){} // RVA: 0x7FFAC9A869E0
        public void OnItemPointerUp(){} // RVA: 0x7FFAC9A86E60
        public void OnToggleValueChanged(){} // RVA: 0x7FFAC9A874B0
        public void GetIndexForId(){} // RVA: 0x7FFAC9A87690
        public void GetIdForIndex(){} // RVA: 0x7FFAC9A87770
        public void HasChildren(){} // RVA: 0x7FFAC9A87820
        public void Exists(){} // RVA: 0x7FFAC9A878D0
        public void HasChildrenByIndex(){} // RVA: 0x7FFAC9A87940
        public void GetChildrenIdsByIndex(){} // RVA: 0x7FFAC9A87A40
        public void GetChildIndexForId(){} // RVA: 0x7FFAC9A87AF0
        public void GetIndentationDepth(){} // RVA: 0x7FFAC9A87CC0
        public void GetIndentationDepthByIndex(){} // RVA: 0x7FFAC9A87D20
        public void CanChangeExpandedState(){} // RVA: 0x7FFAC4BF82C0
        public void IsExpanded(){} // RVA: 0x7FFAC9A87D90
        public void IsExpandedByIndex(){} // RVA: 0x7FFAC9A87E50
        public void ExpandItemByIndex(){} // RVA: 0x7FFAC9A87F10
        public void ExpandItem(){} // RVA: 0x7FFAC9A88780
        public void CollapseItemByIndex(){} // RVA: 0x7FFAC9A88960
        public void CollapseItem(){} // RVA: 0x7FFAC9A88E70
        public void RegenerateWrappers(){} // RVA: 0x7FFAC9A89000
        public void CreateWrappers(){} // RVA: 0x7FFAC9A89150
        public void IsIndexValid(){} // RVA: 0x7FFAC9A89690
        public void RaiseItemParentChanged(){} // RVA: 0x7FFAC9A89700
        public void .ctor(){} // RVA: 0x7FFAC9A89720
        public void .cctor(){} // RVA: 0x7FFAC9A89A90
    }

    public class BaseUxmlFactory`2 : Object
    {
        public T uxmlName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void get_uxmlName(){} // RVA: 0x7FFAC2C58E90
        public void get_uxmlNamespace(){} // RVA: 0x7FFAC2C58E90
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFAC2C58E90
        public void get_uxmlType(){} // RVA: 0x7FFAC2C58E90
        public void AcceptsAttributeBag(){}
    }

    public class BaseUxmlTraits : Object
    {
        public bool canHaveAnyAttribute; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC322C870
        public void set_canHaveAnyAttribute(){} // RVA: 0x7FFAC2FEB5F0
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
        public System.Func`2<UnityEngine.UIElements.CanStartDragArgs,bool> dragger; // 0x408
        public System.Func`2<UnityEngine.UIElements.SetupDragAndDropArgs,UnityEngine.UIElements.StartDragArgs> virtualizationController; // 0x410
        public System.Func`2<UnityEngine.UIElements.HandleDragAndDropArgs,0x6B11A9E8> viewController; // 0x418
        public System.Func`2<UnityEngine.UIElements.HandleDragAndDropArgs,0x6B11A9E8> showBorder; // 0x420
        public 0x6B11F798 reorderable; // 0x428
        public System.Collections.Generic.List`1<UnityEngine.UIElements.ReusableCollectionItem> horizontalScrollingEnabled; // 0x10
        public bool showAlternatingRowBackgrounds; // 0x42C
        public 0x6B115608 virtualizationMethod; // 0x430
        public int fixedItemHeight; // 0x18
        public float lastHeight; // 0x434
        public bool m_ItemHeightIsInline; // 0x438
        public 0x6B115660 m_VirtualizationMethod; // 0x43C
        public UnityEngine.UIElements.ScrollView m_ScrollView; // 0x440
        public UnityEngine.UIElements.CollectionViewController m_ViewController; // 0x448
        public UnityEngine.UIElements.CollectionVirtualizationController m_VirtualizationController; // 0x450
        public UnityEngine.UIElements.KeyboardNavigationManipulator m_NavigationManipulator; // 0x458
        public UnityEngine.UIElements.SerializedVirtualizationData serializedVirtualizationData; // 0x460
        public System.Collections.Generic.List`1<int> m_SelectedIds; // 0x468
        public System.Collections.Generic.List`1<int> m_SelectedIndices; // 0x470
        public System.Collections.Generic.List`1<object> m_SelectedItems; // 0x478
        public float m_LastHeight; // 0x480
        public bool m_IsRangeSelectionDirectionUp; // 0x484
        public UnityEngine.UIElements.ListViewDragger m_Dragger; // 0x488
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
        public void HasCanStartDrag(){} // RVA: 0x7FFAC9A96850
        public void RaiseCanStartDrag(){} // RVA: 0x7FFAC9A96860
        public void RaiseSetupDragAndDrop(){} // RVA: 0x7FFAC9A96920
        public void RaiseHandleDragAndDrop(){} // RVA: 0x7FFAC9A96A30
        public void RaiseDrop(){} // RVA: 0x7FFAC9A96B10
        public void get_itemsSource(){} // RVA: 0x7FFAC9A96BF0
        public void set_itemsSource(){} // RVA: 0x7FFAC9A96C20
        public void get_contentContainer(){} // RVA: 0x7FFAC34F9180
        public void get_selectionType(){} // RVA: 0x7FFAC9A96CA0
        public void set_selectionType(){} // RVA: 0x7FFAC9A96CB0
        public void get_selectedIndex(){} // RVA: 0x7FFAC9A96D60
        public void set_selectedIndex(){} // RVA: 0x7FFAC9A96DE0
        public void get_selectedIndices(){} // RVA: 0x7FFAC39CF8B0
        public void get_selectedIds(){} // RVA: 0x7FFAC39BF760
        public void get_activeItems(){} // RVA: 0x7FFAC9A96DF0
        public void get_scrollView(){} // RVA: 0x7FFAC39C4300
        public void get_dragger(){} // RVA: 0x7FFAC39B91C0
        public void get_virtualizationController(){} // RVA: 0x7FFAC9A96E70
        public void get_viewController(){} // RVA: 0x7FFAC39BD8C0
        public void ResolveItemHeight(){} // RVA: 0x7FFAC9A96EB0
        public void set_showBorder(){} // RVA: 0x7FFAC9A96F00
        public void get_reorderable(){} // RVA: 0x7FFAC9A96FA0
        public void set_reorderable(){} // RVA: 0x7FFAC9A97040
        public void set_horizontalScrollingEnabled(){} // RVA: 0x7FFAC9A970E0
        public void get_showAlternatingRowBackgrounds(){} // RVA: 0x7FFAC9A97150
        public void set_showAlternatingRowBackgrounds(){} // RVA: 0x7FFAC9A97160
        public void get_virtualizationMethod(){} // RVA: 0x7FFAC50886F0
        public void set_virtualizationMethod(){} // RVA: 0x7FFAC9A97180
        public void get_fixedItemHeight(){} // RVA: 0x7FFAC9A971D0
        public void set_fixedItemHeight(){} // RVA: 0x7FFAC9A971E0
        public void get_lastHeight(){} // RVA: 0x7FFAC9A972E0
        public void CreateVirtualizationController(){} // RVA: 0x7FFAC2C70980 | overloaded x2
        public void GetOrCreateVirtualizationController(){} // RVA: 0x7FFAC9A96E70
        public void GetOrCreateViewController(){} // RVA: 0x7FFAC9A97330
        public void CreateViewController(){} // RVA: 0x7FFAC2C58E90
        public void SetViewController(){} // RVA: 0x7FFAC9A97390
        public void CreateDragger(){} // RVA: 0x7FFAC9A977A0
        public void InitializeDragAndDropController(){} // RVA: 0x7FFAC9A97800
        public void CreateDragAndDropController(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC9A984C0 | overloaded x2
        public void GetRootElementForId(){} // RVA: 0x7FFAC9A985C0
        public void HasValidDataAndBindings(){} // RVA: 0x7FFAC9A986D0
        public void OnItemIndexChanged(){} // RVA: 0x7FFAC9A98710
        public void OnItemsSourceChanged(){} // RVA: 0x7FFAC9A98750
        public void RefreshItems(){} // RVA: 0x7FFAC9A98770
        public void Rebuild(){} // RVA: 0x7FFAC9A988E0
        public void RefreshSelection(){} // RVA: 0x7FFAC9A98A50
        public void PostRefresh(){} // RVA: 0x7FFAC9A98CE0
        public void ScrollToItem(){} // RVA: 0x7FFAC9A98DA0
        public void ScrollToItemById(){} // RVA: 0x7FFAC9A98E20
        public void OnScroll(){} // RVA: 0x7FFAC9A98EC0
        public void Resize(){} // RVA: 0x7FFAC9A98F40
        public void OnAttachToPanel(){} // RVA: 0x7FFAC9A99000
        public void OnDetachFromPanel(){} // RVA: 0x7FFAC9A99450
        public void Apply(){} // RVA: 0x7FFAC9A99C50 | overloaded x2
        public void HandleItemNavigation(){} // RVA: 0x7FFAC52088B0
        public void OnPointerMove(){} // RVA: 0x7FFAC9A99E20
        public void OnPointerDown(){} // RVA: 0x7FFAC9A99EB0
        public void OnPointerCancel(){} // RVA: 0x7FFAC9A9A020
        public void OnPointerUp(){} // RVA: 0x7FFAC9A9A0A0
        public void ProcessPointerDown(){} // RVA: 0x7FFAC9A9A210
        public void ProcessPointerUp(){} // RVA: 0x7FFAC9A9A430
        public void DoSelect(){} // RVA: 0x7FFAC9A9A7A0
        public void DoRangeSelection(){} // RVA: 0x7FFAC9A9ACB0
        public void ProcessSingleClick(){} // RVA: 0x7FFAC9A96DE0
        public void SelectAll(){} // RVA: 0x7FFAC9A9AE50
        public void AddToSelection(){} // RVA: 0x7FFAC9A9B230 | overloaded x2
        public void AddToSelectionWithoutValidation(){} // RVA: 0x7FFAC9A9B4D0
        public void RemoveFromSelection(){} // RVA: 0x7FFAC9A9B900
        public void RemoveFromSelectionWithoutValidation(){} // RVA: 0x7FFAC9A9B960
        public void SetSelection(){} // RVA: 0x7FFAC9A9BD60 | overloaded x2
        public void SetSelectionWithoutNotify(){} // RVA: 0x7FFAC9A9BD70
        public void SetSelectionInternal(){} // RVA: 0x7FFAC9A9BD80
        public void MatchesExistingSelection(){} // RVA: 0x7FFAC9A9BFD0
        public void NotifyOfSelectionChange(){} // RVA: 0x7FFAC9A9C270
        public void ClearSelection(){} // RVA: 0x7FFAC9A9C2E0
        public void ClearSelectionWithoutValidation(){} // RVA: 0x7FFAC9A9C360
        public void OnViewDataReady(){} // RVA: 0x7FFAC9A9C5C0
        public void ExecuteDefaultAction(){} // RVA: 0x7FFAC9A9C600
        public void OnSizeChanged(){} // RVA: 0x7FFAC9A9C9F0
        public void OnCustomStyleResolved(){} // RVA: 0x7FFAC9A9CA90
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC9A94E70
        public void .cctor(){} // RVA: 0x7FFAC9A9CC50
        public void <.ctor>b__158_0(){} // RVA: 0x7FFAC9A9D510
        public void <Apply>g__HandleSelectionAndScroll|181_0(){} // RVA: 0x7FFAC9A9D5A0
    }

    public class BaseVisualElementPanel : Object
    {
        public System.Action`1<UnityEngine.UIElements.BaseVisualElementPanel> IMGUIEventInterests; // 0x10
        public UnityEngine.UIElements.UIElementsBridge ownerObject; // 0x18
        public float saveViewData; // 0x20
        public UnityEngine.Yoga.YogaConfig getViewDataDictionary; // 0x28
        public float IMGUIContainersCount; // 0x30
        public float focusController; // 0x34
        public UnityEngine.UIElements.PanelClearSettings rootIMGUIContainer; // 0x38
        public bool uiElementsBridge; // 0x4C
        public UnityEngine.UIElements.RepaintData scale; // 0x50
        public UnityEngine.UIElements.ICursorManager pixelsPerPoint; // 0x58
        public UnityEngine.UIElements.ContextualMenuManager scaledPixelsPerPoint; // 0x60
        public bool referenceSpritePixelsPerUnit; // 0x68
        public UnityEngine.UIElements.ElementUnderPointer clearSettings; // 0x70
        public System.Action duringLayoutPhase; // 0x78
        public System.Action version; // 0x80
        public System.Action hierarchyVersion; // 0x88
        public System.Action`1<UnityEngine.Material> repaintData; // 0x90
        public UnityEngine.UIElements.HierarchyEvent cursorManager; // 0x98
        public System.Action`1<UnityEngine.UIElements.IPanel> contextualMenuManager; // 0xA0

        // ── Methods ──
        public void get_IMGUIEventInterests(){}
        public void set_IMGUIEventInterests(){}
        public void get_ownerObject(){} // RVA: 0x7FFAC2C58E90
        public void set_ownerObject(){} // RVA: 0x7FFAC2C70A40
        public void get_saveViewData(){} // RVA: 0x7FFAC2C58E90
        public void get_getViewDataDictionary(){} // RVA: 0x7FFAC2C58E90
        public void get_IMGUIContainersCount(){} // RVA: 0x7FFAC2C59960
        public void set_IMGUIContainersCount(){} // RVA: 0x7FFAC2C70ED0
        public void get_focusController(){} // RVA: 0x7FFAC2C58E90
        public void set_focusController(){} // RVA: 0x7FFAC2C70A40
        public void get_rootIMGUIContainer(){} // RVA: 0x7FFAC2C58E90
        public void add_panelDisposed(){} // RVA: 0x7FFAC9BA67C0
        public void remove_panelDisposed(){} // RVA: 0x7FFAC9BA68C0
        public void get_uiElementsBridge(){} // RVA: 0x7FFAC9BA69C0
        public void .ctor(){} // RVA: 0x7FFAC9BA6A30
        public void Dispose(){} // RVA: 0x7FFAC9BA6DF0 | overloaded x2
        public void Repaint(){} // RVA: 0x7FFAC2C70A40
        public void ValidateFocus(){} // RVA: 0x7FFAC2C70980
        public void ValidateLayout(){} // RVA: 0x7FFAC2C70980
        public void UpdateAnimations(){} // RVA: 0x7FFAC2C70980
        public void UpdateBindings(){} // RVA: 0x7FFAC2C70980
        public void ApplyStyles(){} // RVA: 0x7FFAC2C70980
        public void get_scale(){} // RVA: 0x7FFAC9812640
        public void set_scale(){} // RVA: 0x7FFAC9BA71A0
        public void set_pixelsPerPoint(){} // RVA: 0x7FFAC9BA7280
        public void get_scaledPixelsPerPoint(){} // RVA: 0x7FFAC9BA7360
        public void get_referenceSpritePixelsPerUnit(){} // RVA: 0x7FFAC2FEB630
        public void set_referenceSpritePixelsPerUnit(){} // RVA: 0x7FFAC2FEB640
        public void get_clearSettings(){} // RVA: 0x7FFAC9BA7370
        public void set_clearSettings(){} // RVA: 0x7FFAC9BA7390
        public void get_duringLayoutPhase(){} // RVA: 0x7FFAC4168960
        public void set_duringLayoutPhase(){} // RVA: 0x7FFAC416A6F0
        public void get_version(){} // RVA: 0x7FFAC2C59960
        public void get_hierarchyVersion(){} // RVA: 0x7FFAC2C59960
        public void OnVersionChanged(){} // RVA: 0x7FFAC2C77970
        public void get_repaintData(){} // RVA: 0x7FFAC2FC20E0
        public void set_repaintData(){} // RVA: 0x7FFAC30794D0
        public void get_cursorManager(){} // RVA: 0x7FFAC2FE9500
        public void set_cursorManager(){} // RVA: 0x7FFAC2FE9510
        public void get_contextualMenuManager(){} // RVA: 0x7FFAC2FBF370
        public void set_contextualMenuManager(){} // RVA: 0x7FFAC2FBF380
        public void get_visualTree(){} // RVA: 0x7FFAC2C58E90
        public void get_dispatcher(){} // RVA: 0x7FFAC2C58E90
        public void set_dispatcher(){} // RVA: 0x7FFAC2C70A40
        public void SendEvent(){} // RVA: 0x7FFAC9BA73A0
        public void get_scheduler(){} // RVA: 0x7FFAC2C58E90
        public void get_styleAnimationSystem(){} // RVA: 0x7FFAC2C58E90
        public void set_styleAnimationSystem(){} // RVA: 0x7FFAC2C70A40
        public void get_contextType(){} // RVA: 0x7FFAC2C59960
        public void set_contextType(){} // RVA: 0x7FFAC2C70ED0
        public void Pick(){}
        public void PickAll(){}
        public void get_disposed(){} // RVA: 0x7FFAC2FE9570
        public void set_disposed(){} // RVA: 0x7FFAC2FE9580
        public void GetUpdater(){} // RVA: 0x7FFAC2C67DE0
        public void GetTopElementUnderPointer(){} // RVA: 0x7FFAC9BA7470
        public void RecomputeTopElementUnderPointer(){} // RVA: 0x7FFAC9BA74B0
        public void ClearCachedElementUnderPointer(){} // RVA: 0x7FFAC9BA75F0
        public void CommitElementUnderPointers(){} // RVA: 0x7FFAC9BA7630
        public void get_standardShader(){} // RVA: 0x7FFAC2C58E90
        public void get_standardWorldSpaceShader(){} // RVA: 0x7FFAC67332B0
        public void add_standardShaderChanged(){} // RVA: 0x7FFAC9BA76A0
        public void remove_standardShaderChanged(){} // RVA: 0x7FFAC9BA7790
        public void add_standardWorldSpaceShaderChanged(){} // RVA: 0x7FFAC9BA7880
        public void remove_standardWorldSpaceShaderChanged(){} // RVA: 0x7FFAC9BA7970
        public void add_atlasChanged(){} // RVA: 0x7FFAC9BA7A60
        public void remove_atlasChanged(){} // RVA: 0x7FFAC9BA7B50
        public void InvokeAtlasChanged(){} // RVA: 0x7FFAC9BA7C40
        public void get_atlas(){} // RVA: 0x7FFAC2C58E90
        public void set_atlas(){} // RVA: 0x7FFAC2C70A40
        public void InvokeUpdateMaterial(){} // RVA: 0x7FFAC9BA7C60
        public void add_hierarchyChanged(){} // RVA: 0x7FFAC9BA7C80
        public void remove_hierarchyChanged(){} // RVA: 0x7FFAC9BA7D70
        public void InvokeHierarchyChanged(){} // RVA: 0x7FFAC9BA7E60
        public void InvokeBeforeUpdate(){} // RVA: 0x7FFAC9BA7E90
        public void UpdateElementUnderPointers(){} // RVA: 0x7FFAC9BA7EB0
        public void UnityEngine.UIElements.IGroupBox.OnOptionAdded(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(){} // RVA: 0x7FFAC2F21310
        public void Update(){} // RVA: 0x7FFAC9BA8170
    }

    public class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater
    {
        public 0x6B1271A0 m_State; // 0x20
        public UnityEngine.UIElements.VisualElement m_CurrentChangeElement; // 0x28
        public UnityEngine.UIElements.VisualElement m_CurrentChangeParent; // 0x30

        // ── Methods ──
        public void OnHierarchyChange(){} // RVA: 0x7FFAC2C77970
        public void OnVersionChanged(){} // RVA: 0x7FFAC9AC3B20
        public void Update(){} // RVA: 0x7FFAC9AC3D60
        public void ProcessNewChange(){} // RVA: 0x7FFAC9AC3EB0
        public void ProcessAddOrMove(){} // RVA: 0x7FFAC9AC3FE0
        public void ProcessRemove(){} // RVA: 0x7FFAC9AC40A0
        public void .ctor(){} // RVA: 0x7FFAC99EE4A0
    }

    public class BaseVisualTreeUpdater : Object
    {
        public System.Action`1<UnityEngine.UIElements.BaseVisualElementPanel> panel; // 0x10
        public UnityEngine.UIElements.BaseVisualElementPanel visualTree; // 0x18

        // ── Methods ──
        public void add_panelChanged(){} // RVA: 0x7FFAC9AC9340
        public void remove_panelChanged(){} // RVA: 0x7FFAC9AC9440
        public void get_panel(){} // RVA: 0x7FFAC58A1130
        public void set_panel(){} // RVA: 0x7FFAC9AC9540
        public void get_visualTree(){} // RVA: 0x7FFAC85265B0
        public void get_profilerMarker(){}
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void Update(){} // RVA: 0x7FFAC2C70980
        public void OnVersionChanged(){} // RVA: 0x7FFAC2C77970
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BindableElement : VisualElement
    {
        public UnityEngine.UIElements.IBinding binding; // 0x3C8
        public string bindingPath; // 0x3D0

        // ── Methods ──
        public void get_binding(){} // RVA: 0x7FFAC39C0A20
        public void set_bindingPath(){} // RVA: 0x7FFAC39D0F60
        public void .ctor(){} // RVA: 0x7FFAC9A7DD30
    }

    public class BlurEvent : FocusEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B82280
        public void PreDispatch(){} // RVA: 0x7FFAC9B82370
        public void .ctor(){} // RVA: 0x7FFAC9B82400
    }

    public class BoundsField : BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string centerFieldUssClassName; // 0x18
        public string extentsFieldUssClassName; // 0x20
        public UnityEngine.UIElements.Vector3Field m_CenterField; // 0x450
        public UnityEngine.UIElements.Vector3Field m_ExtentsField; // 0x458

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A9E460 | overloaded x2
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9A9EA40
        public void UpdateMixedValueContent(){} // RVA: 0x7FFAC9A9EC00
        public void .cctor(){} // RVA: 0x7FFAC9A9ECC0
        public void <.ctor>b__10_0(){} // RVA: 0x7FFAC9A9F000
        public void <.ctor>b__10_1(){} // RVA: 0x7FFAC9A9F0C0
    }

    public class BoundsIntField : BaseField`1
    {
        public UnityEngine.UIElements.Vector3IntField m_PositionField; // 0x450
        public UnityEngine.UIElements.Vector3IntField m_SizeField; // 0x458
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string positionUssClassName; // 0x18
        public string sizeUssClassName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A9FD00 | overloaded x2
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9AA02E0
        public void UpdateMixedValueContent(){} // RVA: 0x7FFAC9AA04A0
        public void .cctor(){} // RVA: 0x7FFAC9AA0560
        public void <.ctor>b__10_0(){} // RVA: 0x7FFAC9AA08A0
        public void <.ctor>b__10_1(){} // RVA: 0x7FFAC9AA0960
    }

    public class Box : VisualElement
    {
        public string ussClassName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9AA1520
        public void .cctor(){} // RVA: 0x7FFAC9AA15C0
    }

    public class Button : TextElement
    {
        public string clickable;
        public UnityEngine.UIElements.Clickable m_Clickable; // 0x4A0
        public string NonEmptyString; // 0x8

        // ── Methods ──
        public void get_clickable(){} // RVA: 0x7FFAC9AA16D0
        public void set_clickable(){} // RVA: 0x7FFAC9AA16E0
        public void .ctor(){} // RVA: 0x7FFAC9AA1810 | overloaded x2
        public void OnNavigationSubmit(){} // RVA: 0x7FFAC9AA1A50
        public void DoMeasure(){} // RVA: 0x7FFAC9AA1BA0
        public void .cctor(){} // RVA: 0x7FFAC9AA1C70
    }

    public class ButtonStripField : BaseField`1
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Button> m_Buttons; // 0x440

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9AA1E40
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9AA1F50
        public void RefreshButtonsState(){} // RVA: 0x7FFAC9AA20B0
    }

}