// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UI
// Classes: 79
// Methods: 1420

namespace ThirdParty.Unity.UnityEngine.UI
{
    public class AnimationTriggers : Object
    {
        public object kDefaultNormalAnimName;
        public object kDefaultHighlightedAnimName;
        public object kDefaultPressedAnimName;
        public object kDefaultSelectedAnimName;
        public object kDefaultDisabledAnimName;
        public object m_NormalTrigger;
        public object m_HighlightedTrigger;
        public object m_PressedTrigger;
        public object m_SelectedTrigger;
        public object m_DisabledTrigger;

        // ── Methods ──
        public void get_normalTrigger(){} // RVA: 0xB5DBF0
        public void set_normalTrigger(){} // RVA: 0xB44D60
        public void get_highlightedTrigger(){} // RVA: 0xB465B0
        public void set_highlightedTrigger(){} // RVA: 0xBA9BA0
        public void get_pressedTrigger(){} // RVA: 0xB700F0
        public void set_pressedTrigger(){} // RVA: 0xB70100
        public void get_selectedTrigger(){} // RVA: 0xB70160
        public void set_selectedTrigger(){} // RVA: 0xB44DC0
        public void get_disabledTrigger(){} // RVA: 0xD33E60
        public void set_disabledTrigger(){} // RVA: 0xB708C0
        public void .ctor(){} // RVA: 0x7E2BC60
    }

    public class AspectRatioFitter : UIBehaviour
    {
        public object m_AspectMode;
        public object m_AspectRatio;
        public object m_Rect;
        public object m_DelayedSetDirty;
        public object m_DoesParentExist;
        public object m_Tracker;

        // ── Methods ──
        public void get_aspectMode(){} // RVA: 0xFEAE90
        public void set_aspectMode(){} // RVA: 0x80DDF60
        public void get_aspectRatio(){} // RVA: 0xCBAD90
        public void set_aspectRatio(){} // RVA: 0x80DDFC0
        public void get_rectTransform(){} // RVA: 0x80DE020
        public void .ctor(){} // RVA: 0xCF0310
        public void OnEnable(){} // RVA: 0x80DE160
        public void Start(){} // RVA: 0x80DE270
        public void OnDisable(){} // RVA: 0x80DE2B0
        public void OnTransformParentChanged(){} // RVA: 0x80DE310
        public void Update(){} // RVA: 0x80DE420
        public void OnRectTransformDimensionsChange(){} // RVA: 0x80DE440
        public void UpdateRect(){} // RVA: 0x80DE450
        public void GetSizeDeltaToProduceSize(){} // RVA: 0x80DE820
        public void GetParentSize(){} // RVA: 0x80DE9F0
        public void SetLayoutHorizontal(){} // RVA: 0xB43310
        public void SetLayoutVertical(){} // RVA: 0xB43310
        public void SetDirty(){} // RVA: 0x80DE440
        public void IsComponentValidOnObject(){} // RVA: 0x80DEBF0
        public void IsAspectModeValid(){} // RVA: 0x80DED10
        public void DoesParentExists(){} // RVA: 0xB68E10
    }

    public class BaseMeshEffect : UIBehaviour
    {
        public object m_Graphic;

        // ── Methods ──
        public void get_graphic(){} // RVA: 0x810A300
        public void OnEnable(){} // RVA: 0x810A440
        public void OnDisable(){} // RVA: 0x810A540
        public void OnDidApplyAnimationProperties(){} // RVA: 0x810A640
        public void ModifyMesh(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class BaseVertexEffect : Object
    {
        // ── Methods ──
        public void ModifyVertices(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Button : Selectable
    {
        public object m_OnClick;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7E2BEB0
        public void get_onClick(){} // RVA: 0x10B4170
        public void set_onClick(){} // RVA: 0x15B42C0
        public void Press(){} // RVA: 0x7E2BFF0
        public void OnPointerClick(){} // RVA: 0x7E2C090
        public void OnSubmit(){} // RVA: 0x7E2C0C0
        public void OnFinishSubmit(){} // RVA: 0x7E2C1D0
    }

    public class Button[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CanvasScaler : UIBehaviour
    {
        public object m_UiScaleMode;
        public object m_ReferencePixelsPerUnit;
        public object m_ScaleFactor;
        public object m_ReferenceResolution;
        public object m_ScreenMatchMode;
        public object m_MatchWidthOrHeight;
        public object kLogBase;
        public object m_PhysicalUnit;
        public object m_FallbackScreenDPI;
        public object m_DefaultSpriteDPI;
        public object m_DynamicPixelsPerUnit;
        public object m_Canvas;
        public object m_PrevScaleFactor;
        public object m_PrevReferencePixelsPerUnit;
        public object m_PresetInfoIsWorld;

        // ── Methods ──
        public void get_uiScaleMode(){} // RVA: 0xFEAE90
        public void set_uiScaleMode(){} // RVA: 0x1269760
        public void get_referencePixelsPerUnit(){} // RVA: 0xCBAD90
        public void set_referencePixelsPerUnit(){} // RVA: 0xCBADA0
        public void get_scaleFactor(){} // RVA: 0xC27360
        public void set_scaleFactor(){} // RVA: 0x80DED30
        public void get_referenceResolution(){} // RVA: 0x80DED50
        public void set_referenceResolution(){} // RVA: 0x80DED70
        public void get_screenMatchMode(){} // RVA: 0xE9CE60
        public void set_screenMatchMode(){} // RVA: 0xEA1260
        public void get_matchWidthOrHeight(){} // RVA: 0x11E18C0
        public void set_matchWidthOrHeight(){} // RVA: 0x11E1470
        public void get_physicalUnit(){} // RVA: 0x114DAD0
        public void set_physicalUnit(){} // RVA: 0x25671C0
        public void get_fallbackScreenDPI(){} // RVA: 0xD344A0
        public void set_fallbackScreenDPI(){} // RVA: 0xD34230
        public void get_defaultSpriteDPI(){} // RVA: 0xB4B880
        public void set_defaultSpriteDPI(){} // RVA: 0x80DEDF0
        public void get_dynamicPixelsPerUnit(){} // RVA: 0x1767220
        public void set_dynamicPixelsPerUnit(){} // RVA: 0x1767230
        public void .ctor(){} // RVA: 0x80DEE10
        public void OnEnable(){} // RVA: 0x80DEEA0
        public void Canvas_preWillRenderCanvases(){} // RVA: 0x2597FF0
        public void OnDisable(){} // RVA: 0x80DEFA0
        public void Handle(){} // RVA: 0x80DF070
        public void HandleWorldCanvas(){} // RVA: 0x80DF200
        public void HandleConstantPixelSize(){} // RVA: 0x80DF270
        public void HandleScaleWithScreenSize(){} // RVA: 0x80DF2E0
        public void HandleConstantPhysicalSize(){} // RVA: 0x80DF5B0
        public void SetScaleFactor(){} // RVA: 0x80DF6D0
        public void SetReferencePixelsPerUnit(){} // RVA: 0x80DF710
    }

    public class CanvasUpdateRegistry : Object
    {
        public object s_Instance;
        public object m_PerformingLayoutUpdate;
        public object m_PerformingGraphicUpdate;
        public object m_CanvasUpdateProfilerStrings;
        public object m_CullingUpdateProfilerString;
        public object m_LayoutRebuildQueue;
        public object m_GraphicRebuildQueue;
        public object s_SortLayoutFunction;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7E2C460
        public void get_instance(){} // RVA: 0x7E2C730
        public void ObjectValidForUpdate(){} // RVA: 0x7E2C850
        public void CleanInvalidItems(){} // RVA: 0x7E2C9C0
        public void PerformUpdate(){} // RVA: 0x7E2CB90
        public void ParentCount(){} // RVA: 0x7E2D300
        public void SortLayoutList(){} // RVA: 0x7E2D530
        public void RegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7E2D5F0
        public void TryRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7E2D660
        public void InternalRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7E2D6D0
        public void RegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7E2D790
        public void TryRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7E2D800
        public void InternalRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7E2D870
        public void UnRegisterCanvasElementForRebuild(){} // RVA: 0x7E2D980
        public void DisableCanvasElementForRebuild(){} // RVA: 0x7E2DC70
        public void InternalUnRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7E2DF60
        public void InternalUnRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7E2E0C0
        public void InternalDisableCanvasElementForLayoutRebuild(){} // RVA: 0x7E2E220
        public void InternalDisableCanvasElementForGraphicRebuild(){} // RVA: 0x7E2E380
        public void IsRebuildingLayout(){} // RVA: 0x7E2E4E0
        public void IsRebuildingGraphics(){} // RVA: 0x7E2E540
        public void .cctor(){} // RVA: 0x7E2E5A0
    }

    public class ClipperRegistry : Object
    {
        public object s_Instance;
        public object m_Clippers;
        public object HasCulledThisFrame;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7E2EF90
        public void get_instance(){} // RVA: 0x7E2F050
        public void Cull(){} // RVA: 0x7E2F1D0
        public void Register(){} // RVA: 0x7E2F390
        public void Unregister(){} // RVA: 0x7E2F400
        public void Disable(){} // RVA: 0x7E2F460
    }

    public class Clipping : Object
    {
        // ── Methods ──
        public void FindCullAndClipWorldRect(){} // RVA: 0x7E2F4C0
    }

    public class ColorBlock : ValueType
    {
        public object m_NormalColor;
        public object m_HighlightedColor;
        public object m_PressedColor;
        public object m_SelectedColor;
        public object m_DisabledColor;
        public object m_ColorMultiplier;
        public object m_FadeDuration;
        public object defaultColorBlock;

        // ── Methods ──
        public void get_normalColor(){} // RVA: 0x7BF80
        public void set_normalColor(){} // RVA: 0x7BE90
        public void get_highlightedColor(){} // RVA: 0xD1A70
        public void set_highlightedColor(){} // RVA: 0x9356A0
        public void get_pressedColor(){} // RVA: 0xA11A0
        public void set_pressedColor(){} // RVA: 0x98F8B0
        public void get_selectedColor(){} // RVA: 0x98F8C0
        public void set_selectedColor(){} // RVA: 0x98F8D0
        public void get_disabledColor(){} // RVA: 0xE3210
        public void set_disabledColor(){} // RVA: 0x98F8E0
        public void get_colorMultiplier(){} // RVA: 0x98F8F0
        public void set_colorMultiplier(){} // RVA: 0x98F900
        public void get_fadeDuration(){} // RVA: 0x98F910
        public void set_fadeDuration(){} // RVA: 0x98BA50
        public void .cctor(){} // RVA: 0x7E2E680
        public void Equals(){} // RVA: 0x98F930
        public void op_Equality(){} // RVA: 0x7E2EDA0
        public void op_Inequality(){} // RVA: 0x7E2EE50
        public void GetHashCode(){} // RVA: 0x98F980
    }

    public class ContentSizeFitter : UIBehaviour
    {
        public object m_HorizontalFit;
        public object m_VerticalFit;
        public object m_Rect;
        public object m_Tracker;

        // ── Methods ──
        public void get_horizontalFit(){} // RVA: 0xFEAE90
        public void set_horizontalFit(){} // RVA: 0x80DF750
        public void get_verticalFit(){} // RVA: 0x15AF000
        public void set_verticalFit(){} // RVA: 0x80DF7B0
        public void get_rectTransform(){} // RVA: 0x80DF810
        public void .ctor(){} // RVA: 0xB43D60
        public void OnEnable(){} // RVA: 0x80DF950
        public void OnDisable(){} // RVA: 0x80DF960
        public void OnRectTransformDimensionsChange(){} // RVA: 0x80DF950
        public void HandleSelfFittingAlongAxis(){} // RVA: 0x80DF9C0
        public void SetLayoutHorizontal(){} // RVA: 0x80DFA60
        public void SetLayoutVertical(){} // RVA: 0x80DFAD0
        public void SetDirty(){} // RVA: 0x80DFC20
    }

    public class DefaultControls : Object
    {
        public object m_CurrentFactory;
        public object kWidth;
        public object kThickHeight;
        public object kThinHeight;
        public object s_ThickElementSize;
        public object s_ThinElementSize;
        public object s_ImageElementSize;
        public object s_DefaultSelectableColor;
        public object s_PanelColor;
        public object s_TextColor;

        // ── Methods ──
        public void get_factory(){} // RVA: 0x7E2FC60
        public void CreateUIElementRoot(){} // RVA: 0x7E2FCC0
        public void CreateUIObject(){} // RVA: 0x7E2FDD0
        public void SetDefaultTextValues(){} // RVA: 0x7E2FEC0
        public void SetDefaultColorTransitionValues(){} // RVA: 0x7E30050
        public void SetParentAndAlign(){} // RVA: 0x7E300B0
        public void SetLayerRecursively(){} // RVA: 0x7E30200
        public void CreatePanel(){} // RVA: 0x7E30490
        public void CreateButton(){} // RVA: 0x7E30850
        public void CreateText(){} // RVA: 0x7E30E50
        public void CreateImage(){} // RVA: 0x7E31030
        public void CreateRawImage(){} // RVA: 0x7E311A0
        public void CreateSlider(){} // RVA: 0x7E31310
        public void CreateScrollbar(){} // RVA: 0x7E31DE0
        public void CreateToggle(){} // RVA: 0x7E32510
        public void CreateInputField(){} // RVA: 0x7E32DB0
        public void CreateDropdown(){} // RVA: 0x7E33740
        public void CreateScrollView(){} // RVA: 0x7E35470
        public void .cctor(){} // RVA: 0x7E361B0
    }

    public class Dropdown : Selectable
    {
        public object m_Template;
        public object m_CaptionText;
        public object m_CaptionImage;
        public object m_ItemText;
        public object m_ItemImage;
        public object m_Value;
        public object m_Options;
        public object m_OnValueChanged;
        public object m_AlphaFadeSpeed;
        public object m_Dropdown;
        public object m_Blocker;
        public object m_Items;
        public object m_AlphaTweenRunner;
        public object validTemplate;
        public object kHighSortingLayer;
        public object s_NoOptionData;

        // ── Methods ──
        public void get_template(){} // RVA: 0x10B4170
        public void set_template(){} // RVA: 0x7E36430
        public void get_captionText(){} // RVA: 0x10B9D50
        public void set_captionText(){} // RVA: 0x7E36490
        public void get_captionImage(){} // RVA: 0xD9E3D0
        public void set_captionImage(){} // RVA: 0x7E364F0
        public void get_itemText(){} // RVA: 0xDA0520
        public void set_itemText(){} // RVA: 0x7E36550
        public void get_itemImage(){} // RVA: 0x114AC20
        public void set_itemImage(){} // RVA: 0x7E365B0
        public void get_options(){} // RVA: 0x7E36610
        public void set_options(){} // RVA: 0x7E36630
        public void get_onValueChanged(){} // RVA: 0x135A170
        public void set_onValueChanged(){} // RVA: 0x1365A40
        public void get_alphaFadeSpeed(){} // RVA: 0x7E366B0
        public void set_alphaFadeSpeed(){} // RVA: 0x7E366C0
        public void get_value(){} // RVA: 0x6CE7E30
        public void set_value(){} // RVA: 0x7E366D0
        public void SetValueWithoutNotify(){} // RVA: 0x7E366E0
        public void Set(){} // RVA: 0x7E366F0
        public void .ctor(){} // RVA: 0x7E36870
        public void Awake(){} // RVA: 0x7E36AA0
        public void Start(){} // RVA: 0x7E36D00
        public void OnDisable(){} // RVA: 0x7E36E30
        public void RefreshShownValue(){} // RVA: 0x7E36F90
        public void AddOptions(){} // RVA: 0x7E375A0
        public void ClearOptions(){} // RVA: 0x7E37790
        public void SetupTemplate(){} // RVA: 0x7E37810
        public void GetOrAddComponent(){} // RVA: 0xA94080
        public void OnPointerClick(){} // RVA: 0x7E38520
        public void OnSubmit(){} // RVA: 0x7E38520
        public void OnCancel(){} // RVA: 0x7E38530
        public void Show(){} // RVA: 0x7E38540
        public void CreateBlocker(){} // RVA: 0x7E39FB0
        public void DestroyBlocker(){} // RVA: 0x7E3A970
        public void CreateDropdownList(){} // RVA: 0x7E3AA00
        public void DestroyDropdownList(){} // RVA: 0x7E3AA70
        public void CreateItem(){} // RVA: 0x7E3AB00
        public void DestroyItem(){} // RVA: 0xB43310
        public void AddItem(){} // RVA: 0x7E3AB70
        public void AlphaFadeList(){} // RVA: 0x7E3B1E0
        public void SetAlpha(){} // RVA: 0x7E3B370
        public void Hide(){} // RVA: 0x7E3B490
        public void DelayedDestroyDropdownList(){} // RVA: 0x7E3B870
        public void ImmediateDestroyDropdownList(){} // RVA: 0x7E3B930
        public void OnSelectItem(){} // RVA: 0x7E3BC40
        public void .cctor(){} // RVA: 0x7E3BE50
    }

    public class Dropdown[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class FontData : Object
    {
        public object m_Font;
        public object m_FontSize;
        public object m_FontStyle;
        public object m_BestFit;
        public object m_MinSize;
        public object m_MaxSize;
        public object m_Alignment;
        public object m_AlignByGeometry;
        public object m_RichText;
        public object m_HorizontalOverflow;
        public object m_VerticalOverflow;
        public object m_LineSpacing;

        // ── Methods ──
        public void get_defaultFontData(){} // RVA: 0x7E3C2D0
        public void get_font(){} // RVA: 0xB5DBF0
        public void set_font(){} // RVA: 0xB44D60
        public void get_fontSize(){} // RVA: 0xE62D00
        public void set_fontSize(){} // RVA: 0x1033F40
        public void get_fontStyle(){} // RVA: 0x2244FB0
        public void set_fontStyle(){} // RVA: 0x22735B0
        public void get_bestFit(){} // RVA: 0xC38360
        public void set_bestFit(){} // RVA: 0xC38370
        public void get_minSize(){} // RVA: 0x15AF000
        public void set_minSize(){} // RVA: 0x1FAA840
        public void get_maxSize(){} // RVA: 0x1065D50
        public void set_maxSize(){} // RVA: 0x13233D0
        public void get_alignment(){} // RVA: 0x1AE5AC0
        public void set_alignment(){} // RVA: 0x23E55F0
        public void get_alignByGeometry(){} // RVA: 0xB68DF0
        public void set_alignByGeometry(){} // RVA: 0xB68E00
        public void get_richText(){} // RVA: 0xB68E10
        public void set_richText(){} // RVA: 0xB68E20
        public void get_horizontalOverflow(){} // RVA: 0xE9CE60
        public void set_horizontalOverflow(){} // RVA: 0xEA1260
        public void get_verticalOverflow(){} // RVA: 0x18A0130
        public void set_verticalOverflow(){} // RVA: 0x189D3F0
        public void get_lineSpacing(){} // RVA: 0x12CA360
        public void set_lineSpacing(){} // RVA: 0x12C9F10
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7E3C340
        public void .ctor(){} // RVA: 0xB43310
    }

    public class FontUpdateTracker : Object
    {
        public object m_Tracked;

        // ── Methods ──
        public void TrackText(){} // RVA: 0x7E3C390
        public void RebuildForFont(){} // RVA: 0x7E3C7D0
        public void UntrackText(){} // RVA: 0x7E3C9A0
        public void .cctor(){} // RVA: 0x7E3CD70
    }

    public class Graphic : UIBehaviour
    {
        public object s_DefaultUI;
        public object s_WhiteTexture;
        public object m_Material;
        public object m_Color;
        public object m_SkipLayoutUpdate;
        public object m_SkipMaterialUpdate;
        public object m_RaycastTarget;
        public object m_RaycastTargetCache;
        public object m_RaycastPadding;
        public object m_RectTransform;
        public object m_CanvasRenderer;
        public object m_Canvas;
        public object m_VertsDirty;
        public object m_MaterialDirty;
        public object m_OnDirtyLayoutCallback;
        public object m_OnDirtyVertsCallback;
        public object m_OnDirtyMaterialCallback;
        public object s_Mesh;
        public object s_VertexHelper;
        public object m_CachedMesh;
        public object m_CachedUvs;
        public object m_ColorTweenRunner;
        public object _useLegacyMeshGeneration;

        // ── Methods ──
        public void get_defaultGraphicMaterial(){} // RVA: 0x7E3CE50
        public void get_color(){} // RVA: 0x19F92B0
        public void set_color(){} // RVA: 0x7E3D060
        public void get_raycastTarget(){} // RVA: 0x1DC2880
        public void set_raycastTarget(){} // RVA: 0x7E3D0D0
        public void get_raycastPadding(){} // RVA: 0x6C221E0
        public void set_raycastPadding(){} // RVA: 0x6C221F0
        public void get_useLegacyMeshGeneration(){} // RVA: 0x2443C20
        public void set_useLegacyMeshGeneration(){} // RVA: 0x143D170
        public void .ctor(){} // RVA: 0x7E3D1B0
        public void SetAllDirty(){} // RVA: 0x7E3D340
        public void SetLayoutDirty(){} // RVA: 0x7E3D3B0
        public void SetVerticesDirty(){} // RVA: 0x7E3D450
        public void SetMaterialDirty(){} // RVA: 0x7E3D4E0
        public void SetRaycastDirty(){} // RVA: 0x7E3D580
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7E3D660
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7E3D7E0
        public void OnTransformParentChanged(){} // RVA: 0x7E3D890
        public void get_depth(){} // RVA: 0x7E3D990
        public void get_rectTransform(){} // RVA: 0x7E3DA30
        public void get_canvas(){} // RVA: 0x7E3DAD0
        public void CacheCanvas(){} // RVA: 0x7E3DBB0
        public void get_canvasRenderer(){} // RVA: 0x7E3DE50
        public void get_defaultMaterial(){} // RVA: 0x7E3DF90
        public void get_material(){} // RVA: 0x7E3DFE0
        public void set_material(){} // RVA: 0x7E3E0D0
        public void get_materialForRendering(){} // RVA: 0x7E3E250
        public void get_mainTexture(){} // RVA: 0x7E3E470
        public void OnEnable(){} // RVA: 0x7E3E4D0
        public void OnDisable(){} // RVA: 0x7E3E6D0
        public void OnDestroy(){} // RVA: 0x7E3E870
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7E3EA60
        public void OnCullingChanged(){} // RVA: 0x7E3ECB0
        public void Rebuild(){} // RVA: 0x7E3EDC0
        public void LayoutComplete(){} // RVA: 0xB43310
        public void GraphicUpdateComplete(){} // RVA: 0xB43310
        public void UpdateMaterial(){} // RVA: 0x7E3EF10
        public void UpdateGeometry(){} // RVA: 0x7E3EFE0
        public void DoMeshGeneration(){} // RVA: 0x7E3F000
        public void DoLegacyMeshGeneration(){} // RVA: 0x7E3F6B0
        public void get_workerMesh(){} // RVA: 0x7E3FD10
        public void OnFillVBO(){} // RVA: 0xB43310
        public void OnPopulateMesh(){} // RVA: 0x7E3FFC0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7551890
        public void SetNativeSize(){} // RVA: 0xB43310
        public void Raycast(){} // RVA: 0x7E401D0
        public void PixelAdjustPoint(){} // RVA: 0x7E406F0
        public void GetPixelAdjustedRect(){} // RVA: 0x7E409B0
        public void CrossFadeColor(){} // RVA: 0x7E40D30
        public void CreateColorFromAlpha(){} // RVA: 0x7E41280
        public void CrossFadeAlpha(){} // RVA: 0x7E412A0
        public void RegisterDirtyLayoutCallback(){} // RVA: 0x7E41370
        public void UnregisterDirtyLayoutCallback(){} // RVA: 0x7E41460
        public void RegisterDirtyVerticesCallback(){} // RVA: 0x7E41550
        public void UnregisterDirtyVerticesCallback(){} // RVA: 0x7E41640
        public void RegisterDirtyMaterialCallback(){} // RVA: 0x7E41730
        public void UnregisterDirtyMaterialCallback(){} // RVA: 0x7E41830
        public void .cctor(){} // RVA: 0x7E41930
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x114DE50
    }

    public class GraphicRaycaster : BaseRaycaster
    {
        public object kNoEventMaskSet;
        public object m_IgnoreReversedGraphics;
        public object m_BlockingObjects;
        public object m_BlockingMask;
        public object m_Canvas;
        public object m_RaycastResults;
        public object s_SortedGraphics;

        // ── Methods ──
        public void get_sortOrderPriority(){} // RVA: 0x7E41AD0
        public void get_renderOrderPriority(){} // RVA: 0x7E41BC0
        public void get_ignoreReversedGraphics(){} // RVA: 0xF73960
        public void set_ignoreReversedGraphics(){} // RVA: 0xF73A60
        public void get_blockingObjects(){} // RVA: 0x1AE5AC0
        public void set_blockingObjects(){} // RVA: 0x23E55F0
        public void get_blockingMask(){} // RVA: 0xB9E080
        public void set_blockingMask(){} // RVA: 0xB9E090
        public void .ctor(){} // RVA: 0x7E41CC0
        public void get_canvas(){} // RVA: 0x7E41DC0
        public void Raycast(){} // RVA: 0x7E433E0
        public void get_eventCamera(){} // RVA: 0x7E43230
        public void .cctor(){} // RVA: 0x7E43B30
    }

    public class GraphicRaycaster[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GraphicRegistry : Object
    {
        public object s_Instance;
        public object m_Graphics;
        public object m_RaycastableGraphics;
        public object s_EmptyList;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7E43D10
        public void get_instance(){} // RVA: 0x7E43F30
        public void RegisterGraphicForCanvas(){} // RVA: 0x7E44050
        public void RegisterRaycastGraphicForCanvas(){} // RVA: 0x7E443F0
        public void UnregisterGraphicForCanvas(){} // RVA: 0x7E447A0
        public void UnregisterRaycastGraphicForCanvas(){} // RVA: 0x7E44A50
        public void DisableGraphicForCanvas(){} // RVA: 0x7E44CD0
        public void DisableRaycastGraphicForCanvas(){} // RVA: 0x7E44EF0
        public void GetGraphicsForCanvas(){} // RVA: 0x7E45110
        public void GetRaycastableGraphicsForCanvas(){} // RVA: 0x7E451E0
        public void .cctor(){} // RVA: 0x7E452B0
    }

    public class Graphic[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GridLayoutGroup : LayoutGroup
    {
        public object m_StartCorner;
        public object m_StartAxis;
        public object m_CellSize;
        public object m_Spacing;
        public object m_Constraint;
        public object m_ConstraintCount;

        // ── Methods ──
        public void get_startCorner(){} // RVA: 0xD347A0
        public void set_startCorner(){} // RVA: 0x80DFCA0
        public void get_startAxis(){} // RVA: 0xD34720
        public void set_startAxis(){} // RVA: 0x80DFCF0
        public void get_cellSize(){} // RVA: 0x6297330
        public void set_cellSize(){} // RVA: 0x80DFD40
        public void get_spacing(){} // RVA: 0x6297350
        public void set_spacing(){} // RVA: 0x80DFD90
        public void get_constraint(){} // RVA: 0x23ADD10
        public void set_constraint(){} // RVA: 0x80DFDE0
        public void get_constraintCount(){} // RVA: 0x23A4270
        public void set_constraintCount(){} // RVA: 0x80DFE30
        public void .ctor(){} // RVA: 0x80DFF00
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x80DFF70
        public void CalculateLayoutInputVertical(){} // RVA: 0x80E01B0
        public void SetLayoutHorizontal(){} // RVA: 0x80E0450
        public void SetLayoutVertical(){} // RVA: 0x80E0460
        public void SetCellsAlongAxis(){} // RVA: 0x80E0470
    }

    public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x80E0D70
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x80E0D80
        public void CalculateLayoutInputVertical(){} // RVA: 0x80E0DB0
        public void SetLayoutHorizontal(){} // RVA: 0x80E0DC0
        public void SetLayoutVertical(){} // RVA: 0x80E0DD0
    }

    public class HorizontalOrVerticalLayoutGroup : LayoutGroup
    {
        public object m_Spacing;
        public object m_ChildForceExpandWidth;
        public object m_ChildForceExpandHeight;
        public object m_ChildControlWidth;
        public object m_ChildControlHeight;
        public object m_ChildScaleWidth;
        public object m_ChildScaleHeight;
        public object m_ReverseArrangement;

        // ── Methods ──
        public void get_spacing(){} // RVA: 0xC5C4A0
        public void set_spacing(){} // RVA: 0x80E0DE0
        public void get_childForceExpandWidth(){} // RVA: 0x1D450E0
        public void set_childForceExpandWidth(){} // RVA: 0x80E0ED0
        public void get_childForceExpandHeight(){} // RVA: 0x1D3EFC0
        public void set_childForceExpandHeight(){} // RVA: 0x80E0F20
        public void get_childControlWidth(){} // RVA: 0x7171AF0
        public void set_childControlWidth(){} // RVA: 0x80E0F70
        public void get_childControlHeight(){} // RVA: 0x7171AE0
        public void set_childControlHeight(){} // RVA: 0x80E0FC0
        public void get_childScaleWidth(){} // RVA: 0xC10030
        public void set_childScaleWidth(){} // RVA: 0x80E1010
        public void get_childScaleHeight(){} // RVA: 0x6296240
        public void set_childScaleHeight(){} // RVA: 0x80E1060
        public void get_reverseArrangement(){} // RVA: 0x6573C70
        public void set_reverseArrangement(){} // RVA: 0x80E10B0
        public void CalcAlongAxis(){} // RVA: 0x80E1100
        public void SetChildrenAlongAxis(){} // RVA: 0x80E15B0
        public void GetChildSizes(){} // RVA: 0x80E2130
        public void .ctor(){} // RVA: 0x80E0D70
    }

    public class ICanvasElement
    {
        // ── Methods ──
        public void Rebuild(){} // RVA: 0x8944F0
        public void get_transform(){} // RVA: 0x87C0A0
        public void LayoutComplete(){} // RVA: 0x894290
        public void GraphicUpdateComplete(){} // RVA: 0x894290
        public void IsDestroyed(){} // RVA: 0x87D280
    }

    public class ICanvasElement[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IClippable
    {
        // ── Methods ──
        public void get_gameObject(){} // RVA: 0x87C0A0
        public void RecalculateClipping(){} // RVA: 0x894290
        public void get_rectTransform(){} // RVA: 0x87C0A0
        public void Cull(){} // RVA: 0x899250
        public void SetClipRect(){} // RVA: 0x899250
        public void SetClipSoftness(){} // RVA: 0x895F20
    }

    public class IClipper
    {
        // ── Methods ──
        public void PerformClipping(){} // RVA: 0x894290
    }

    public class IClipper[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IGraphicEnabledDisabled
    {
        // ── Methods ──
        public void OnSiblingGraphicEnabledDisabled(){} // RVA: 0x894290
    }

    public class ILayoutController
    {
        // ── Methods ──
        public void SetLayoutHorizontal(){} // RVA: 0x894290
        public void SetLayoutVertical(){} // RVA: 0x894290
    }

    public class ILayoutElement
    {
        // ── Methods ──
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x894290
        public void CalculateLayoutInputVertical(){} // RVA: 0x894290
        public void get_minWidth(){} // RVA: 0x890F90
        public void get_preferredWidth(){} // RVA: 0x890F90
        public void get_flexibleWidth(){} // RVA: 0x890F90
        public void get_minHeight(){} // RVA: 0x890F90
        public void get_preferredHeight(){} // RVA: 0x890F90
        public void get_flexibleHeight(){} // RVA: 0x890F90
        public void get_layoutPriority(){} // RVA: 0x87C130
    }

    public class ILayoutIgnorer
    {
        // ── Methods ──
        public void get_ignoreLayout(){} // RVA: 0x87D280
    }

    public class IMask
    {
        // ── Methods ──
        public void Enabled(){} // RVA: 0x87D280
        public void get_rectTransform(){} // RVA: 0x87C0A0
    }

    public class IMaskable
    {
        // ── Methods ──
        public void RecalculateMasking(){} // RVA: 0x894290
    }

    public class IMaterialModifier
    {
        // ── Methods ──
        public void GetModifiedMaterial(){} // RVA: 0x87C540
    }

    public class IMaterialModifier[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IMeshModifier
    {
        // ── Methods ──
        public void ModifyMesh(){} // RVA: 0x894320
    }

    public class IVertexModifier
    {
        // ── Methods ──
        public void ModifyVertices(){} // RVA: 0x894320
    }

    public class Image : MaskableGraphic
    {
        public object s_ETC1DefaultUI;
        public object m_Sprite;
        public object m_OverrideSprite;
        public object m_Type;
        public object m_PreserveAspect;
        public object m_FillCenter;
        public object m_FillMethod;
        public object m_FillAmount;
        public object m_FillClockwise;
        public object m_FillOrigin;
        public object m_AlphaHitTestMinimumThreshold;
        public object m_Tracked;
        public object m_UseSpriteMesh;
        public object m_PixelsPerUnitMultiplier;
        public object m_CachedReferencePixelsPerUnit;
        public object s_VertScratch;
        public object s_UVScratch;
        public object s_Xy;
        public object s_Uv;
        public object m_TrackedTexturelessImages;
        public object s_Initialized;

        // ── Methods ──
        public void get_sprite(){} // RVA: 0xBC5B30
        public void set_sprite(){} // RVA: 0x7E45390
        public void DisableSpriteOptimizations(){} // RVA: 0x7E45B60
        public void get_overrideSprite(){} // RVA: 0x7E45B70
        public void set_overrideSprite(){} // RVA: 0x7E45B80
        public void get_activeSprite(){} // RVA: 0x7E45C00
        public void get_type(){} // RVA: 0x255B930
        public void set_type(){} // RVA: 0x7E45CF0
        public void get_preserveAspect(){} // RVA: 0x7E45D60
        public void set_preserveAspect(){} // RVA: 0x7E45D70
        public void get_fillCenter(){} // RVA: 0x7E45DE0
        public void set_fillCenter(){} // RVA: 0x7E45DF0
        public void get_fillMethod(){} // RVA: 0x7E45E60
        public void set_fillMethod(){} // RVA: 0x7E45E70
        public void get_fillAmount(){} // RVA: 0x11E4480
        public void set_fillAmount(){} // RVA: 0x7E45EF0
        public void get_fillClockwise(){} // RVA: 0x2443BA0
        public void set_fillClockwise(){} // RVA: 0x7E45F80
        public void get_fillOrigin(){} // RVA: 0x2531210
        public void set_fillOrigin(){} // RVA: 0x7E45FF0
        public void get_eventAlphaThreshold(){} // RVA: 0x7E46060
        public void set_eventAlphaThreshold(){} // RVA: 0x7E46080
        public void get_alphaHitTestMinimumThreshold(){} // RVA: 0x26CA7D0
        public void set_alphaHitTestMinimumThreshold(){} // RVA: 0x7E460A0
        public void get_useSpriteMesh(){} // RVA: 0x7E462B0
        public void set_useSpriteMesh(){} // RVA: 0x7E462C0
        public void .ctor(){} // RVA: 0x7E46330
        public void get_defaultETC1GraphicMaterial(){} // RVA: 0x7E46390
        public void get_mainTexture(){} // RVA: 0x7E465A0
        public void get_hasBorder(){} // RVA: 0x7E46880
        public void get_pixelsPerUnitMultiplier(){} // RVA: 0xD075A0
        public void set_pixelsPerUnitMultiplier(){} // RVA: 0x7E46A50
        public void get_pixelsPerUnit(){} // RVA: 0x7E46A80
        public void get_multipliedPixelsPerUnit(){} // RVA: 0x7E46C60
        public void get_material(){} // RVA: 0x7E46C80
        public void set_material(){} // RVA: 0x7E3E0D0
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void OnAfterDeserialize(){} // RVA: 0x7E46F00
        public void PreserveSpriteAspectRatio(){} // RVA: 0x139F440
        public void GetDrawingDimensions(){} // RVA: 0x7E46F70
        public void SetNativeSize(){} // RVA: 0x7E47550
        public void OnPopulateMesh(){} // RVA: 0x7E47830
        public void TrackSprite(){} // RVA: 0x7E479F0
        public void OnEnable(){} // RVA: 0x7E47D10
        public void OnDisable(){} // RVA: 0x7E47D70
        public void UpdateMaterial(){} // RVA: 0x7E47E50
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7E480E0
        public void GenerateSimpleSprite(){} // RVA: 0x7E48270
        public void GenerateSprite(){} // RVA: 0x7E48740
        public void GenerateSlicedSprite(){} // RVA: 0x7E48F50
        public void GenerateTiledSprite(){} // RVA: 0x7E49C20
        public void AddQuad(){} // RVA: 0x13A0D40
        public void GetAdjustedBorders(){} // RVA: 0x13A1090
        public void GenerateFilledSprite(){} // RVA: 0x7E4B4F0
        public void RadialCut(){} // RVA: 0x7E4C990
        public void CalculateLayoutInputHorizontal(){} // RVA: 0xB43310
        public void CalculateLayoutInputVertical(){} // RVA: 0xB43310
        public void get_minWidth(){} // RVA: 0x13CD2E0
        public void get_preferredWidth(){} // RVA: 0x7E4CE50
        public void get_flexibleWidth(){} // RVA: 0x7815340
        public void get_minHeight(){} // RVA: 0x13CD2E0
        public void get_preferredHeight(){} // RVA: 0x7E4D060
        public void get_flexibleHeight(){} // RVA: 0x7815340
        public void get_layoutPriority(){} // RVA: 0xDAC980
        public void IsRaycastLocationValid(){} // RVA: 0x7E4D270
        public void MapCoordinate(){} // RVA: 0x7E4D710
        public void RebuildImage(){} // RVA: 0x7E4DE90
        public void TrackImage(){} // RVA: 0x7E4E110
        public void UnTrackImage(){} // RVA: 0x7E4E280
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7E4E310
        public void .cctor(){} // RVA: 0x7E4E360
        public void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0(){} // RVA: 0x7E4E6F0
        public void <set_sprite>g__SpriteSupportsAlphaHitTest|11_1(){} // RVA: 0x7E4E780
    }

    public class Image[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class InputField : Selectable
    {
        public object m_Keyboard;
        public object kSeparators;
        public object s_IsQuestDevice;
        public object s_IsPicoDevice;
        public object m_TextComponent;
        public object m_Placeholder;
        public object m_ContentType;
        public object m_InputType;
        public object m_AsteriskChar;
        public object m_KeyboardType;
        public object m_LineType;
        public object m_HideMobileInput;
        public object m_CharacterValidation;
        public object m_CharacterLimit;
        public object m_OnSubmit;
        public object m_OnEndEdit;
        public object m_OnDidEndEdit;
        public object m_OnValueChanged;
        public object m_OnValidateInput;
        public object m_CaretColor;
        public object m_CustomCaretColor;
        public object m_SelectionColor;
        public object m_Text;
        public object m_CaretBlinkRate;
        public object m_CaretWidth;
        public object m_ReadOnly;
        public object m_ShouldActivateOnSelect;
        public object m_CaretPosition;
        public object m_CaretSelectPosition;
        public object caretRectTrans;
        public object m_CursorVerts;
        public object m_InputTextCache;
        public object m_CachedInputRenderer;
        public object m_PreventFontCallback;
        public object m_Mesh;
        public object m_AllowInput;
        public object m_ShouldActivateNextUpdate;
        public object m_UpdateDrag;
        public object m_DragPositionOutOfBounds;
        public object kHScrollSpeed;
        public object kVScrollSpeed;
        public object m_CaretVisible;
        public object m_BlinkCoroutine;
        public object m_BlinkStartTime;
        public object m_DrawStart;
        public object m_DrawEnd;
        public object m_DragCoroutine;
        public object m_OriginalText;
        public object m_WasCanceled;
        public object m_HasDoneFocusTransition;
        public object m_WaitForSecondsRealtime;
        public object m_TouchKeyboardAllowsInPlaceEditing;
        public object m_IsCompositionActive;
        public object kEmailSpecialCharacters;
        public object kOculusQuestDeviceModel;
        public object kPicoDeviceModel;
        public object m_ProcessingEvent;
        public object k_MaxTextLength;

        // ── Methods ──
        public void get_input(){} // RVA: 0x80CF050
        public void get_compositionString(){} // RVA: 0x80CF240
        public void .ctor(){} // RVA: 0x80CF350
        public void get_mesh(){} // RVA: 0x80CF810
        public void get_cachedInputTextGenerator(){} // RVA: 0x80CF980
        public void set_shouldHideMobileInput(){} // RVA: 0x80CFA40
        public void get_shouldHideMobileInput(){} // RVA: 0x80CFA90
        public void set_shouldActivateOnSelect(){} // RVA: 0x6F1A0D0
        public void get_shouldActivateOnSelect(){} // RVA: 0x80CFB30
        public void get_text(){} // RVA: 0x1667D40
        public void set_text(){} // RVA: 0x80CFBD0
        public void SetTextWithoutNotify(){} // RVA: 0x80CFBE0
        public void SetText(){} // RVA: 0x80CFBF0
        public void get_isFocused(){} // RVA: 0x80D00A0
        public void get_caretBlinkRate(){} // RVA: 0x80D00B0
        public void set_caretBlinkRate(){} // RVA: 0x80D00C0
        public void get_caretWidth(){} // RVA: 0x78F9B70
        public void set_caretWidth(){} // RVA: 0x80D0130
        public void get_textComponent(){} // RVA: 0x10B9D50
        public void set_textComponent(){} // RVA: 0x80D0190
        public void get_placeholder(){} // RVA: 0xD9E3D0
        public void set_placeholder(){} // RVA: 0x80D0520
        public void get_caretColor(){} // RVA: 0x80D0580
        public void set_caretColor(){} // RVA: 0x80D05E0
        public void get_customCaretColor(){} // RVA: 0x1672940
        public void set_customCaretColor(){} // RVA: 0x80D0650
        public void get_selectionColor(){} // RVA: 0x80D0670
        public void set_selectionColor(){} // RVA: 0x80D0680
        public void get_onEndEdit(){} // RVA: 0xBAE960
        public void set_onEndEdit(){} // RVA: 0x80D06F0
        public void get_onSubmit(){} // RVA: 0x135A170
        public void set_onSubmit(){} // RVA: 0x80D0750
        public void get_onValueChange(){} // RVA: 0x12CDBF0
        public void set_onValueChange(){} // RVA: 0x80D07B0
        public void get_onValueChanged(){} // RVA: 0x12CDBF0
        public void set_onValueChanged(){} // RVA: 0x80D07B0
        public void get_onValidateInput(){} // RVA: 0x1661250
        public void set_onValidateInput(){} // RVA: 0x80D0810
        public void get_characterLimit(){} // RVA: 0x75C0A30
        public void set_characterLimit(){} // RVA: 0x80D0870
        public void get_contentType(){} // RVA: 0x1AE6530
        public void set_contentType(){} // RVA: 0x80D0960
        public void get_lineType(){} // RVA: 0x6CE7E30
        public void set_lineType(){} // RVA: 0x80D0B10
        public void get_inputType(){} // RVA: 0x80D0C00
        public void set_inputType(){} // RVA: 0x80D0C10
        public void get_touchScreenKeyboard(){} // RVA: 0x10B4170
        public void get_keyboardType(){} // RVA: 0x6BB0770
        public void set_keyboardType(){} // RVA: 0x80D0C80
        public void get_characterValidation(){} // RVA: 0x114AC30
        public void set_characterValidation(){} // RVA: 0x80D0CF0
        public void get_readOnly(){} // RVA: 0x6E15480
        public void set_readOnly(){} // RVA: 0x6E15490
        public void get_multiLine(){} // RVA: 0x80D0D60
        public void get_asteriskChar(){} // RVA: 0x80D0D80
        public void set_asteriskChar(){} // RVA: 0x80D0D90
        public void get_wasCanceled(){} // RVA: 0x6F1A120
        public void ClampPos(){} // RVA: 0x80D0E40
        public void get_caretPositionInternal(){} // RVA: 0x80D0E80
        public void set_caretPositionInternal(){} // RVA: 0x80D0EB0
        public void get_caretSelectPositionInternal(){} // RVA: 0x80D0F00
        public void set_caretSelectPositionInternal(){} // RVA: 0x80D0F30
        public void get_hasSelection(){} // RVA: 0x80D0F80
        public void get_caretPosition(){} // RVA: 0x80D0F00
        public void set_caretPosition(){} // RVA: 0x80D0FE0
        public void get_selectionAnchorPosition(){} // RVA: 0x80D0E80
        public void set_selectionAnchorPosition(){} // RVA: 0x80D1010
        public void get_selectionFocusPosition(){} // RVA: 0x80D0F00
        public void set_selectionFocusPosition(){} // RVA: 0x80D1080
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void OnAfterDeserialize(){} // RVA: 0x80D10F0
        public void OnEnable(){} // RVA: 0x80D1250
        public void OnDisable(){} // RVA: 0x80D1600
        public void OnDestroy(){} // RVA: 0x80D1AA0
        public void CaretBlink(){} // RVA: 0x80D1AF0
        public void SetCaretVisible(){} // RVA: 0x80D1B90
        public void SetCaretActive(){} // RVA: 0x80D1C10
        public void UpdateCaretMaterial(){} // RVA: 0x80D1D00
        public void OnFocus(){} // RVA: 0x80D1EF0
        public void SelectAll(){} // RVA: 0x80D1F00
        public void MoveTextEnd(){} // RVA: 0x80D1F90
        public void MoveTextStart(){} // RVA: 0x80D20B0
        public void get_clipboard(){} // RVA: 0x80D21A0
        public void set_clipboard(){} // RVA: 0x80D21F0
        public void TouchScreenKeyboardShouldBeUsed(){} // RVA: 0x80D2240
        public void InPlaceEditing(){} // RVA: 0x80D2340
        public void InPlaceEditingChanged(){} // RVA: 0x80D2370
        public void GetInternalSelection(){} // RVA: 0x80D2410
        public void UpdateKeyboardCaret(){} // RVA: 0x80D2500
        public void UpdateCaretFromKeyboard(){} // RVA: 0x80D2630
        public void LateUpdate(){} // RVA: 0x80D27E0
        public void ScreenToLocal(){} // RVA: 0x80D3000
        public void GetUnclampedCharacterLineFromPosition(){} // RVA: 0x80D3750
        public void GetCharacterIndexFromPosition(){} // RVA: 0x80D3A70
        public void MayDrag(){} // RVA: 0x80D3DF0
        public void OnBeginDrag(){} // RVA: 0x80D3F50
        public void OnDrag(){} // RVA: 0x80D3F80
        public void MouseDragOutsideRect(){} // RVA: 0x80D4340
        public void OnEndDrag(){} // RVA: 0x80D4440
        public void OnPointerDown(){} // RVA: 0x80D4470
        public void KeyPressed(){} // RVA: 0x80D4780
        public void IsValidChar(){} // RVA: 0x80D4D90
        public void ProcessEvent(){} // RVA: 0x80D4DF0
        public void OnUpdateSelected(){} // RVA: 0x80D4E00
        public void GetSelectedString(){} // RVA: 0x80D5110
        public void FindtNextWordBegin(){} // RVA: 0x80D5210
        public void MoveRight(){} // RVA: 0x80D5320
        public void FindtPrevWordBegin(){} // RVA: 0x80D55C0
        public void MoveLeft(){} // RVA: 0x80D56C0
        public void DetermineCharacterLine(){} // RVA: 0x80D5950
        public void LineUpCharacterPosition(){} // RVA: 0x80D5B20
        public void LineDownCharacterPosition(){} // RVA: 0x80D5DC0
        public void MoveDown(){} // RVA: 0x80D6120
        public void MoveUp(){} // RVA: 0x80D6350
        public void Delete(){} // RVA: 0x80D6530
        public void ForwardSpace(){} // RVA: 0x80D67F0
        public void Backspace(){} // RVA: 0x80D6900
        public void Insert(){} // RVA: 0x80D6A80
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0x80D6C70
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0x80D6CD0
        public void SendOnValueChanged(){} // RVA: 0x80D6CF0
        public void SendOnEndEdit(){} // RVA: 0x80D6D70
        public void SendOnSubmit(){} // RVA: 0x80D6DF0
        public void Append(){} // RVA: 0x80D6F60
        public void UpdateLabel(){} // RVA: 0x80D72E0
        public void IsSelectionVisible(){} // RVA: 0x80D7A50
        public void GetLineStartPosition(){} // RVA: 0x80D7B20
        public void GetLineEndPosition(){} // RVA: 0x80D7C50
        public void SetDrawRangeToContainCaretPosition(){} // RVA: 0x80D7DE0
        public void ForceLabelUpdate(){} // RVA: 0x80D88C0
        public void MarkGeometryAsDirty(){} // RVA: 0x80D88D0
        public void Rebuild(){} // RVA: 0x80D8970
        public void LayoutComplete(){} // RVA: 0xB43310
        public void GraphicUpdateComplete(){} // RVA: 0xB43310
        public void UpdateGeometry(){} // RVA: 0x80D8980
        public void AssignPositioningIfNeeded(){} // RVA: 0x80D9040
        public void OnFillVBO(){} // RVA: 0x80D9D40
        public void GenerateCaret(){} // RVA: 0x80D9F50
        public void CreateCursorVerts(){} // RVA: 0x80DAF10
        public void GenerateHighlight(){} // RVA: 0x80DB110
        public void Validate(){} // RVA: 0x80DB920
        public void ActivateInputField(){} // RVA: 0x80DBFE0
        public void ActivateInputFieldInternal(){} // RVA: 0x80DC210
        public void OnSelect(){} // RVA: 0x80DC9B0
        public void OnPointerClick(){} // RVA: 0x80DCA00
        public void DeactivateInputField(){} // RVA: 0x80DCA30
        public void OnDeselect(){} // RVA: 0x80DCDA0
        public void OnSubmit(){} // RVA: 0x80DCDD0
        public void EnforceContentType(){} // RVA: 0x80DCE20
        public void EnforceTextHOverflow(){} // RVA: 0x80DCF90
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0x80DD0F0
        public void SetToCustom(){} // RVA: 0x80DD160
        public void DoStateTransition(){} // RVA: 0x80DD180
        public void CalculateLayoutInputHorizontal(){} // RVA: 0xB43310
        public void CalculateLayoutInputVertical(){} // RVA: 0xB43310
        public void get_minWidth(){} // RVA: 0x80DD1B0
        public void get_preferredWidth(){} // RVA: 0x80DD1C0
        public void get_flexibleWidth(){} // RVA: 0x7815340
        public void get_minHeight(){} // RVA: 0x13CD2E0
        public void get_preferredHeight(){} // RVA: 0x80DD420
        public void get_flexibleHeight(){} // RVA: 0x7815340
        public void get_layoutPriority(){} // RVA: 0xC3CCE0
        public void .cctor(){} // RVA: 0x80DD710
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x114DE50
    }

    public class InputField[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class LayoutElement : UIBehaviour
    {
        public object m_IgnoreLayout;
        public object m_MinWidth;
        public object m_MinHeight;
        public object m_PreferredWidth;
        public object m_PreferredHeight;
        public object m_FlexibleWidth;
        public object m_FlexibleHeight;
        public object m_LayoutPriority;

        // ── Methods ──
        public void get_ignoreLayout(){} // RVA: 0xC38360
        public void set_ignoreLayout(){} // RVA: 0x80E2270
        public void CalculateLayoutInputHorizontal(){} // RVA: 0xB43310
        public void CalculateLayoutInputVertical(){} // RVA: 0xB43310
        public void get_minWidth(){} // RVA: 0xCBAD90
        public void set_minWidth(){} // RVA: 0x80E22D0
        public void get_minHeight(){} // RVA: 0xC27360
        public void set_minHeight(){} // RVA: 0x80E2330
        public void get_preferredWidth(){} // RVA: 0xCD5510
        public void set_preferredWidth(){} // RVA: 0x80E2390
        public void get_preferredHeight(){} // RVA: 0xCD64A0
        public void set_preferredHeight(){} // RVA: 0x80E23F0
        public void get_flexibleWidth(){} // RVA: 0xC120F0
        public void set_flexibleWidth(){} // RVA: 0x80E2450
        public void get_flexibleHeight(){} // RVA: 0x11E18C0
        public void set_flexibleHeight(){} // RVA: 0x80E24B0
        public void get_layoutPriority(){} // RVA: 0x114DAD0
        public void set_layoutPriority(){} // RVA: 0x80E2510
        public void .ctor(){} // RVA: 0x80E2570
        public void OnEnable(){} // RVA: 0x80E25F0
        public void OnTransformParentChanged(){} // RVA: 0x80E25F0
        public void OnDisable(){} // RVA: 0x80E25F0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x80E25F0
        public void OnBeforeTransformParentChanged(){} // RVA: 0x80E25F0
        public void SetDirty(){} // RVA: 0x80E2600
    }

    public class LayoutGroup : UIBehaviour
    {
        public object m_Padding;
        public object m_ChildAlignment;
        public object m_Rect;
        public object m_Tracker;
        public object m_TotalMinSize;
        public object m_TotalPreferredSize;
        public object m_TotalFlexibleSize;
        public object m_RectChildren;

        // ── Methods ──
        public void get_padding(){} // RVA: 0xB700F0
        public void set_padding(){} // RVA: 0x80E26A0
        public void get_childAlignment(){} // RVA: 0x1065D50
        public void set_childAlignment(){} // RVA: 0x80E2770
        public void get_rectTransform(){} // RVA: 0x80E27C0
        public void get_rectChildren(){} // RVA: 0xC0FFC0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x80E2900
        public void CalculateLayoutInputVertical(){} // RVA: 0x894290
        public void get_minWidth(){} // RVA: 0x79D0740
        public void get_preferredWidth(){} // RVA: 0x7D18BA0
        public void get_flexibleWidth(){} // RVA: 0x7DBB260
        public void get_minHeight(){} // RVA: 0x7CA9140
        public void get_preferredHeight(){} // RVA: 0x7DBB250
        public void get_flexibleHeight(){} // RVA: 0x7DBB270
        public void get_layoutPriority(){} // RVA: 0xDAC980
        public void SetLayoutHorizontal(){} // RVA: 0x894290
        public void SetLayoutVertical(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0x80E2D20
        public void OnEnable(){} // RVA: 0x80E3050
        public void OnDisable(){} // RVA: 0x80E3060
        public void OnDidApplyAnimationProperties(){} // RVA: 0x80E3050
        public void GetTotalMinSize(){} // RVA: 0x80E30C0
        public void GetTotalPreferredSize(){} // RVA: 0x80E30D0
        public void GetTotalFlexibleSize(){} // RVA: 0x80E30E0
        public void GetStartOffset(){} // RVA: 0x80E30F0
        public void GetAlignmentOnAxis(){} // RVA: 0x80E3440
        public void SetLayoutInputForAxis(){} // RVA: 0x80E3490
        public void SetChildAlongAxis(){} // RVA: 0x80E3870
        public void SetChildAlongAxisWithScale(){} // RVA: 0x80E3990
        public void get_isRootLayoutGroup(){} // RVA: 0x80E3C90
        public void OnRectTransformDimensionsChange(){} // RVA: 0x80E3ED0
        public void OnTransformChildrenChanged(){} // RVA: 0x80E3050
        public void SetProperty(){} // RVA: 0xA94080
        public void SetDirty(){} // RVA: 0x80E3F00
        public void DelayedSetDirty(){} // RVA: 0x80E40A0
    }

    public class LayoutRebuilder : Object
    {
        public object m_ToRebuild;
        public object m_CachedHashFromTransform;
        public object s_Rebuilders;
        public object TAG_CACHED;
        public object _cachedControllerComponents;
        public object _cachedElementComponents;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x80E4250
        public void Clear(){} // RVA: 0x80E42D0
        public void .cctor(){} // RVA: 0x80E4330
        public void ReapplyDrivenProperties(){} // RVA: 0x80E4850
        public void get_transform(){} // RVA: 0xB5DBF0
        public void IsDestroyed(){} // RVA: 0x80E48A0
        public void StripDisabledBehavioursFromList(){} // RVA: 0x80E4970
        public void ForceRebuildLayoutImmediate(){} // RVA: 0x80E4AE0
        public void Rebuild(){} // RVA: 0x80E4C30
        public void VRC_RegisterCachedLayoutTree(){} // RVA: 0x80E50C0
        public void VRC_UnregisterCachedLayoutTree(){} // RVA: 0x80E54C0
        public void PerformLayoutControl(){} // RVA: 0x80E5620
        public void PerformLayoutCalculation(){} // RVA: 0x80E5EB0
        public void MarkLayoutForRebuild(){} // RVA: 0x80E6510
        public void ValidController(){} // RVA: 0x80E6BB0
        public void MarkLayoutRootForRebuild(){} // RVA: 0x80E6F40
        public void LayoutComplete(){} // RVA: 0x80E71C0
        public void GraphicUpdateComplete(){} // RVA: 0xB43310
        public void GetHashCode(){} // RVA: 0xE62D00
        public void Equals(){} // RVA: 0x80E7250
        public void ToString(){} // RVA: 0x80E72B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LayoutRebuilder[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class LayoutUtility : Object
    {
        // ── Methods ──
        public void GetMinSize(){} // RVA: 0x80E76D0
        public void GetPreferredSize(){} // RVA: 0x80E76F0
        public void GetFlexibleSize(){} // RVA: 0x80E7710
        public void GetMinWidth(){} // RVA: 0x80E7730
        public void GetPreferredWidth(){} // RVA: 0x80E7890
        public void GetFlexibleWidth(){} // RVA: 0x80E7B40
        public void GetMinHeight(){} // RVA: 0x80E7CA0
        public void GetPreferredHeight(){} // RVA: 0x80E7E00
        public void GetFlexibleHeight(){} // RVA: 0x80E80B0
        public void GetLayoutProperty(){} // RVA: 0x80E8230
    }

    public class Mask : UIBehaviour
    {
        public object m_RectTransform;
        public object m_ShowMaskGraphic;
        public object m_Graphic;
        public object m_MaskMaterial;
        public object m_UnmaskMaterial;

        // ── Methods ──
        public void get_rectTransform(){} // RVA: 0x80E89C0
        public void get_showMaskGraphic(){} // RVA: 0xF73960
        public void set_showMaskGraphic(){} // RVA: 0x80E8A60
        public void get_graphic(){} // RVA: 0x80E8B70
        public void .ctor(){} // RVA: 0xB79A60
        public void MaskEnabled(){} // RVA: 0x80E8C10
        public void OnSiblingGraphicEnabledDisabled(){} // RVA: 0xB43310
        public void OnEnable(){} // RVA: 0x80E8D10
        public void OnDisable(){} // RVA: 0x80E8F20
        public void IsRaycastLocationValid(){} // RVA: 0x80E9260
        public void GetModifiedMaterial(){} // RVA: 0x80E9380
    }

    public class MaskUtilities : Object
    {
        // ── Methods ──
        public void Notify2DMaskStateChanged(){} // RVA: 0x80EAD50
        public void NotifyStencilStateChanged(){} // RVA: 0x80EB0D0
        public void FindRootSortOverrideCanvas(){} // RVA: 0x80EB450
        public void GetStencilDepth(){} // RVA: 0x80EB700
        public void IsDescendantOrSelf(){} // RVA: 0x80EBBA0
        public void GetRectMaskForClippable(){} // RVA: 0x80EBF10
        public void GetRectMasksForClip(){} // RVA: 0x80EC350
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Mask[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MaskableGraphic : Graphic
    {
        public object m_ShouldRecalculateStencil;
        public object m_MaskMaterial;
        public object m_ParentMask;
        public object m_Maskable;
        public object m_IsMaskingGraphic;
        public object m_IncludeForMasking;
        public object m_OnCullStateChanged;
        public object m_ShouldRecalculate;
        public object m_StencilValue;
        public object m_Corners;

        // ── Methods ──
        public void get_onCullStateChanged(){} // RVA: 0xCA4D80
        public void set_onCullStateChanged(){} // RVA: 0xCA4D90
        public void get_maskable(){} // RVA: 0xB63970
        public void set_maskable(){} // RVA: 0x80E96A0
        public void get_isMaskingGraphic(){} // RVA: 0x26449C0
        public void set_isMaskingGraphic(){} // RVA: 0x80E96D0
        public void GetModifiedMaterial(){} // RVA: 0x80E96E0
        public void Cull(){} // RVA: 0x80E9880
        public void UpdateCull(){} // RVA: 0x80E98E0
        public void SetClipRect(){} // RVA: 0x80E9A50
        public void SetClipSoftness(){} // RVA: 0x80E9B30
        public void OnEnable(){} // RVA: 0x80E9B70
        public void OnDisable(){} // RVA: 0x80E9BD0
        public void OnTransformParentChanged(){} // RVA: 0x80E9E50
        public void ParentMaskStateChanged(){} // RVA: 0xB43310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x80E9FF0
        public void get_rootCanvasRect(){} // RVA: 0x80EA0C0
        public void UpdateClipParent(){} // RVA: 0x80EA5C0
        public void RecalculateClipping(){} // RVA: 0x79DE660
        public void RecalculateMasking(){} // RVA: 0x80EA900
        public void .ctor(){} // RVA: 0x80EA9E0
        public void UnityEngine.UI.IClippable.get_gameObject(){} // RVA: 0x114DE40
    }

    public class Misc : Object
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0x80EC6F0
        public void DestroyImmediate(){} // RVA: 0x80EC930
    }

    public class MultipleDisplayUtilities : Object
    {
        // ── Methods ──
        public void GetRelativeMousePositionForDrag(){} // RVA: 0x80ECA80
        public void GetRelativeMousePositionForRaycast(){} // RVA: 0x80ECB70
        public void RelativeMouseAtScaled(){} // RVA: 0x80ECCB0
    }

    public class Navigation : ValueType
    {
        public object m_Mode;
        public object m_WrapAround;
        public object m_SelectOnUp;
        public object m_SelectOnDown;
        public object m_SelectOnLeft;
        public object m_SelectOnRight;

        // ── Methods ──
        public void get_mode(){} // RVA: 0x77E60
        public void set_mode(){} // RVA: 0x29580
        public void get_wrapAround(){} // RVA: 0x9B0B0
        public void set_wrapAround(){} // RVA: 0x54160
        public void get_selectOnUp(){} // RVA: 0x77ED0
        public void set_selectOnUp(){} // RVA: 0x77E70
        public void get_selectOnDown(){} // RVA: 0x7E450
        public void set_selectOnDown(){} // RVA: 0x7E3E0
        public void get_selectOnLeft(){} // RVA: 0x931A0
        public void set_selectOnLeft(){} // RVA: 0x93120
        public void get_selectOnRight(){} // RVA: 0x8C630
        public void set_selectOnRight(){} // RVA: 0x8C670
        public void get_defaultNavigation(){} // RVA: 0x80ED550
        public void Equals(){} // RVA: 0x9AAE90
    }

    public class Outline : Shadow
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x810A850
        public void ModifyMesh(){} // RVA: 0x810A8C0
    }

    public class PositionAsUV1 : BaseMeshEffect
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
        public void ModifyMesh(){} // RVA: 0x810ABF0
    }

    public class RawImage : MaskableGraphic
    {
        public object m_Texture;
        public object m_UVRect;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x80ED950
        public void get_mainTexture(){} // RVA: 0x80ED980
        public void get_texture(){} // RVA: 0xBC5B30
        public void set_texture(){} // RVA: 0x80EDC40
        public void get_uvRect(){} // RVA: 0x6D09AA0
        public void set_uvRect(){} // RVA: 0x80EDDF0
        public void SetNativeSize(){} // RVA: 0x80EDE60
        public void OnPopulateMesh(){} // RVA: 0x80EE030
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7E4E310
    }

    public class RectMask2D : UIBehaviour
    {
        public object m_VertexClipper;
        public object m_RectTransform;
        public object m_MaskableTargets;
        public object m_ClipTargets;
        public object m_ShouldRecalculateClipRects;
        public object m_Clippers;
        public object m_LastClipRectCanvasSpace;
        public object m_ForceClip;
        public object m_Padding;
        public object m_Softness;
        public object m_Canvas;
        public object m_Corners;

        // ── Methods ──
        public void get_padding(){} // RVA: 0xC5C490
        public void set_padding(){} // RVA: 0x80EE4C0
        public void get_softness(){} // RVA: 0x6E311C0
        public void set_softness(){} // RVA: 0x80EE4D0
        public void get_Canvas(){} // RVA: 0x80EE500
        public void get_canvasRect(){} // RVA: 0x80EE7D0
        public void get_rectTransform(){} // RVA: 0x80EE850
        public void .ctor(){} // RVA: 0x80EE8F0
        public void OnEnable(){} // RVA: 0x80EECF0
        public void OnDisable(){} // RVA: 0x80EED60
        public void OnDestroy(){} // RVA: 0x7E2F400
        public void IsRaycastLocationValid(){} // RVA: 0x80EEEF0
        public void get_rootCanvasRect(){} // RVA: 0x80EF030
        public void PerformClipping(){} // RVA: 0x80EF300
        public void UpdateClipSoftness(){} // RVA: 0x80EFE40
        public void AddClippable(){} // RVA: 0x80F0220
        public void RemoveClippable(){} // RVA: 0x80F03D0
        public void OnTransformParentChanged(){} // RVA: 0x80F0580
        public void OnCanvasHierarchyChanged(){} // RVA: 0x80F0580
    }

    public class RectMask2D[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RectangularVertexClipper : Object
    {
        public object m_WorldCorners;
        public object m_CanvasCorners;

        // ── Methods ──
        public void GetCanvasRect(){} // RVA: 0x7E2F870
        public void .ctor(){} // RVA: 0x7E2FB50
    }

    public class ReflectionMethodsCache : Object
    {
        public object raycast3D;
        public object raycast3DAll;
        public object getRaycastNonAlloc;
        public object raycast2D;
        public object getRayIntersectionAll;
        public object getRayIntersectionAllNonAlloc;
        public object s_ReflectionMethodsCache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81056E0
        public void get_Singleton(){} // RVA: 0x8106D80
    }

    public class ScrollRect : UIBehaviour
    {
        public object m_Content;
        public object m_Horizontal;
        public object m_Vertical;
        public object m_MovementType;
        public object m_Elasticity;
        public object m_Inertia;
        public object m_DecelerationRate;
        public object m_ScrollSensitivity;
        public object m_Viewport;
        public object m_HorizontalScrollbar;
        public object m_VerticalScrollbar;
        public object m_HorizontalScrollbarVisibility;
        public object m_VerticalScrollbarVisibility;
        public object m_HorizontalScrollbarSpacing;
        public object m_VerticalScrollbarSpacing;
        public object m_OnValueChanged;
        public object m_PointerStartLocalCursor;
        public object m_ContentStartPosition;
        public object m_ViewRect;
        public object m_ContentBounds;
        public object m_ViewBounds;
        public object m_Velocity;
        public object m_Dragging;
        public object m_Scrolling;
        public object m_PrevPosition;
        public object m_PrevContentBounds;
        public object m_PrevViewBounds;
        public object m_HasRebuiltLayout;
        public object m_HSliderExpand;
        public object m_VSliderExpand;
        public object m_HSliderHeight;
        public object m_VSliderWidth;
        public object m_Rect;
        public object m_HorizontalScrollbarRect;
        public object m_VerticalScrollbarRect;
        public object m_Tracker;
        public object m_Corners;

        // ── Methods ──
        public void get_content(){} // RVA: 0xB700F0
        public void set_content(){} // RVA: 0xB70100
        public void get_horizontal(){} // RVA: 0xF73960
        public void set_horizontal(){} // RVA: 0xF73A60
        public void get_vertical(){} // RVA: 0x14F7430
        public void set_vertical(){} // RVA: 0x21CBB70
        public void get_movementType(){} // RVA: 0x1AE5AC0
        public void set_movementType(){} // RVA: 0x23E55F0
        public void get_elasticity(){} // RVA: 0xCD64A0
        public void set_elasticity(){} // RVA: 0xD96F20
        public void get_inertia(){} // RVA: 0xB78D60
        public void set_inertia(){} // RVA: 0xB7CBE0
        public void get_decelerationRate(){} // RVA: 0x11E18C0
        public void set_decelerationRate(){} // RVA: 0x11E1470
        public void get_scrollSensitivity(){} // RVA: 0x12CA360
        public void set_scrollSensitivity(){} // RVA: 0x12C9F10
        public void get_viewport(){} // RVA: 0xBC1B30
        public void set_viewport(){} // RVA: 0x80F2C70
        public void get_horizontalScrollbar(){} // RVA: 0xBBF8F0
        public void set_horizontalScrollbar(){} // RVA: 0x80F2CD0
        public void get_verticalScrollbar(){} // RVA: 0xBE58B0
        public void set_verticalScrollbar(){} // RVA: 0x80F2FC0
        public void get_horizontalScrollbarVisibility(){} // RVA: 0x12BB630
        public void set_horizontalScrollbarVisibility(){} // RVA: 0x80F32B0
        public void get_verticalScrollbarVisibility(){} // RVA: 0xE36310
        public void set_verticalScrollbarVisibility(){} // RVA: 0x80F32C0
        public void get_horizontalScrollbarSpacing(){} // RVA: 0xC5C4A0
        public void set_horizontalScrollbarSpacing(){} // RVA: 0x80F32D0
        public void get_verticalScrollbarSpacing(){} // RVA: 0xB6B1C0
        public void set_verticalScrollbarSpacing(){} // RVA: 0x80F32E0
        public void get_onValueChanged(){} // RVA: 0xBBFF90
        public void set_onValueChanged(){} // RVA: 0xBBFFA0
        public void get_viewRect(){} // RVA: 0x80F32F0
        public void get_velocity(){} // RVA: 0x80F3590
        public void set_velocity(){} // RVA: 0x2443D90
        public void get_rectTransform(){} // RVA: 0x80F35B0
        public void .ctor(){} // RVA: 0x80F3700
        public void Rebuild(){} // RVA: 0x80F3950
        public void LayoutComplete(){} // RVA: 0xB43310
        public void GraphicUpdateComplete(){} // RVA: 0xB43310
        public void UpdateCachedData(){} // RVA: 0x80F39E0
        public void OnEnable(){} // RVA: 0x80F44C0
        public void OnDisable(){} // RVA: 0x80F47B0
        public void IsActive(){} // RVA: 0x80F4B30
        public void EnsureLayoutHasRebuilt(){} // RVA: 0x80F4CB0
        public void StopMovement(){} // RVA: 0x80F4D60
        public void OnScroll(){} // RVA: 0x80F4DC0
        public void OnInitializePotentialDrag(){} // RVA: 0x80F4FA0
        public void OnBeginDrag(){} // RVA: 0x80F5010
        public void OnEndDrag(){} // RVA: 0x80F5160
        public void OnDrag(){} // RVA: 0x80F5190
        public void SetContentAnchoredPosition(){} // RVA: 0x80F53E0
        public void LateUpdate(){} // RVA: 0x80F5500
        public void UpdatePrevData(){} // RVA: 0x80F5FE0
        public void UpdateScrollbars(){} // RVA: 0x80F6170
        public void get_normalizedPosition(){} // RVA: 0x80F6440
        public void set_normalizedPosition(){} // RVA: 0x80F6480
        public void get_horizontalNormalizedPosition(){} // RVA: 0x80F64E0
        public void set_horizontalNormalizedPosition(){} // RVA: 0x80F65E0
        public void get_verticalNormalizedPosition(){} // RVA: 0x80F6600
        public void set_verticalNormalizedPosition(){} // RVA: 0x80F6710
        public void SetHorizontalNormalizedPosition(){} // RVA: 0x80F65E0
        public void SetVerticalNormalizedPosition(){} // RVA: 0x80F6710
        public void SetNormalizedPosition(){} // RVA: 0x80F6730
        public void RubberDelta(){} // RVA: 0x80F6BB0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x80F6C10
        public void get_hScrollingNeeded(){} // RVA: 0x80F6C20
        public void get_vScrollingNeeded(){} // RVA: 0x80F6CE0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0xB43310
        public void CalculateLayoutInputVertical(){} // RVA: 0xB43310
        public void get_minWidth(){} // RVA: 0x7815340
        public void get_preferredWidth(){} // RVA: 0x7815340
        public void get_flexibleWidth(){} // RVA: 0x7815340
        public void get_minHeight(){} // RVA: 0x7815340
        public void get_preferredHeight(){} // RVA: 0x7815340
        public void get_flexibleHeight(){} // RVA: 0x7815340
        public void get_layoutPriority(){} // RVA: 0xFE6B70
        public void SetLayoutHorizontal(){} // RVA: 0x80F6DA0
        public void SetLayoutVertical(){} // RVA: 0x80F77A0
        public void UpdateScrollbarVisibility(){} // RVA: 0x80F79E0
        public void UpdateOneScrollbarVisibility(){} // RVA: 0x80F7A40
        public void UpdateScrollbarLayout(){} // RVA: 0x80F7BA0
        public void UpdateBounds(){} // RVA: 0x80F8020
        public void AdjustBounds(){} // RVA: 0x80F87C0
        public void GetBounds(){} // RVA: 0x80F8860
        public void InternalGetBounds(){} // RVA: 0x80F8AB0
        public void CalculateOffset(){} // RVA: 0x80F8CF0
        public void InternalCalculateOffset(){} // RVA: 0x80F8ED0
        public void SetDirty(){} // RVA: 0x80F9090
        public void SetDirtyCaching(){} // RVA: 0x80F9110
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x114DE50
    }

    public class Scrollbar : Selectable
    {
        public object m_HandleRect;
        public object m_Direction;
        public object m_Value;
        public object m_Size;
        public object m_NumberOfSteps;
        public object m_OnValueChanged;
        public object m_ContainerRect;
        public object m_Offset;
        public object m_Tracker;
        public object m_PointerDownRepeat;
        public object isPointerDownAndNotDragging;
        public object m_DelayedUpdateVisuals;

        // ── Methods ──
        public void get_handleRect(){} // RVA: 0x10B4170
        public void set_handleRect(){} // RVA: 0x80F05F0
        public void get_direction(){} // RVA: 0x23B3150
        public void set_direction(){} // RVA: 0x80F0660
        public void .ctor(){} // RVA: 0x80F06C0
        public void get_value(){} // RVA: 0x80F07F0
        public void set_value(){} // RVA: 0x80F0850
        public void SetValueWithoutNotify(){} // RVA: 0x80F0860
        public void get_size(){} // RVA: 0xD075A0
        public void set_size(){} // RVA: 0x80F0870
        public void get_numberOfSteps(){} // RVA: 0x80F08F0
        public void set_numberOfSteps(){} // RVA: 0x80F0900
        public void get_onValueChanged(){} // RVA: 0xDA0520
        public void set_onValueChanged(){} // RVA: 0xD9D570
        public void get_stepSize(){} // RVA: 0x80F0970
        public void Rebuild(){} // RVA: 0xB43310
        public void LayoutComplete(){} // RVA: 0xB43310
        public void GraphicUpdateComplete(){} // RVA: 0xB43310
        public void OnEnable(){} // RVA: 0x80F09A0
        public void OnDisable(){} // RVA: 0x80F09E0
        public void Update(){} // RVA: 0x80F09F0
        public void UpdateCachedReferences(){} // RVA: 0x80F0A10
        public void Set(){} // RVA: 0x80F0CB0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x80F0DF0
        public void get_axis(){} // RVA: 0x80F0E30
        public void get_reverseValue(){} // RVA: 0x80F0E50
        public void UpdateVisuals(){} // RVA: 0x80F0E70
        public void UpdateDrag(){} // RVA: 0x80F1280
        public void DoUpdateDrag(){} // RVA: 0x80F1710
        public void MayDrag(){} // RVA: 0x80F17D0
        public void OnBeginDrag(){} // RVA: 0x80F1840
        public void OnDrag(){} // RVA: 0x80F1B30
        public void OnPointerDown(){} // RVA: 0x80F1D80
        public void ClickRepeat(){} // RVA: 0x80F1F30
        public void OnPointerUp(){} // RVA: 0x80F2060
        public void OnMove(){} // RVA: 0x80F20A0
        public void FindSelectableOnLeft(){} // RVA: 0x80F2750
        public void FindSelectableOnRight(){} // RVA: 0x80F2780
        public void FindSelectableOnUp(){} // RVA: 0x80F27B0
        public void FindSelectableOnDown(){} // RVA: 0x80F27E0
        public void OnInitializePotentialDrag(){} // RVA: 0x13CB610
        public void SetDirection(){} // RVA: 0x80F2810
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x114DE50
    }

    public class Selectable : UIBehaviour
    {
        public object s_Selectables;
        public object s_SelectableCount;
        public object m_EnableCalled;
        public object m_Navigation;
        public object m_Transition;
        public object m_Colors;
        public object m_SpriteState;
        public object m_AnimationTriggers;
        public object m_Interactable;
        public object m_TargetGraphic;
        public object m_GroupsAllowInteraction;
        public object m_CurrentIndex;
        public object _isPointerInside;
        public object _isPointerDown;
        public object _hasSelection;
        public object m_CanvasGroupCache;

        // ── Methods ──
        public void get_allSelectablesArray(){} // RVA: 0x80F92B0
        public void get_allSelectableCount(){} // RVA: 0x80F9460
        public void get_allSelectables(){} // RVA: 0x80F94C0
        public void AllSelectablesNoAlloc(){} // RVA: 0x80F9560
        public void get_navigation(){} // RVA: 0x5A37540
        public void set_navigation(){} // RVA: 0x80F96F0
        public void get_transition(){} // RVA: 0xE32C80
        public void set_transition(){} // RVA: 0x80F9840
        public void get_colors(){} // RVA: 0x80F98A0
        public void set_colors(){} // RVA: 0x80F98E0
        public void get_spriteState(){} // RVA: 0x80F9A60
        public void set_spriteState(){} // RVA: 0x80F9A80
        public void get_animationTriggers(){} // RVA: 0xC68EB0
        public void set_animationTriggers(){} // RVA: 0x80F9BB0
        public void get_targetGraphic(){} // RVA: 0xBC5B30
        public void set_targetGraphic(){} // RVA: 0x80F9C10
        public void get_interactable(){} // RVA: 0x11629E0
        public void set_interactable(){} // RVA: 0x80F9C70
        public void get_isPointerInside(){} // RVA: 0xBC5D20
        public void set_isPointerInside(){} // RVA: 0xBC5D30
        public void get_isPointerDown(){} // RVA: 0x21656F0
        public void set_isPointerDown(){} // RVA: 0x216AB00
        public void get_hasSelection(){} // RVA: 0x6A621D0
        public void set_hasSelection(){} // RVA: 0x6A621E0
        public void .ctor(){} // RVA: 0x80F9F00
        public void get_image(){} // RVA: 0x80FA190
        public void set_image(){} // RVA: 0xBC5B40
        public void get_animator(){} // RVA: 0x80FA210
        public void Awake(){} // RVA: 0x80FA250
        public void OnCanvasGroupChanged(){} // RVA: 0x80FA390
        public void ParentGroupAllowsInteraction(){} // RVA: 0x80FA3D0
        public void IsInteractable(){} // RVA: 0x80FA5D0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x80FA5F0
        public void OnEnable(){} // RVA: 0x80FA600
        public void OnTransformParentChanged(){} // RVA: 0x487D930
        public void OnSetProperty(){} // RVA: 0x80FAAF0
        public void OnDisable(){} // RVA: 0x80FAB70
        public void OnApplicationFocus(){} // RVA: 0x80FACF0
        public void get_currentSelectionState(){} // RVA: 0x80FAD60
        public void InstantClearState(){} // RVA: 0x80FADD0
        public void DoStateTransition(){} // RVA: 0x80FAE60
        public void FindSelectable(){} // RVA: 0x80FB180
        public void GetPointOnRectEdge(){} // RVA: 0x80FBB30
        public void Navigate(){} // RVA: 0x80FBEC0
        public void FindSelectableOnLeft(){} // RVA: 0x80FBFD0
        public void FindSelectableOnRight(){} // RVA: 0x80FC140
        public void FindSelectableOnUp(){} // RVA: 0x80FC2B0
        public void FindSelectableOnDown(){} // RVA: 0x80FC420
        public void OnMove(){} // RVA: 0x80FC590
        public void StartColorTween(){} // RVA: 0x80FC640
        public void DoSpriteSwap(){} // RVA: 0x80FC7B0
        public void TriggerAnimation(){} // RVA: 0x80FC8C0
        public void IsHighlighted(){} // RVA: 0x80FCB90
        public void IsPressed(){} // RVA: 0x80FCC00
        public void EvaluateAndTransitionToSelectionState(){} // RVA: 0x80FCC50
        public void OnPointerDown(){} // RVA: 0x80FCCC0
        public void OnPointerUp(){} // RVA: 0x80FCE60
        public void OnPointerEnter(){} // RVA: 0x80FCE90
        public void OnPointerExit(){} // RVA: 0x80FCEA0
        public void OnSelect(){} // RVA: 0x80FCEB0
        public void OnDeselect(){} // RVA: 0x80FCEC0
        public void Select(){} // RVA: 0x80FCED0
        public void .cctor(){} // RVA: 0x80FD030
    }

    public class Selectable[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SetPropertyUtility : Object
    {
        // ── Methods ──
        public void SetStruct(){} // RVA: 0xA94080
        public void SetColor(){} // RVA: 0x7A55700
        public void SetClass(){} // RVA: 0xA94080
    }

    public class Shadow : BaseMeshEffect
    {
        public object m_EffectColor;
        public object m_EffectDistance;
        public object m_UseGraphicAlpha;
        public object kMaxEffectDistance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x810A850
        public void get_effectColor(){} // RVA: 0x19F92B0
        public void set_effectColor(){} // RVA: 0x810AD40
        public void get_effectDistance(){} // RVA: 0x1DE2440
        public void set_effectDistance(){} // RVA: 0x810AE50
        public void get_useGraphicAlpha(){} // RVA: 0xC02470
        public void set_useGraphicAlpha(){} // RVA: 0x810AFC0
        public void ApplyShadowZeroAlloc(){} // RVA: 0x810B0D0
        public void ApplyShadow(){} // RVA: 0x810B500
        public void ModifyMesh(){} // RVA: 0x810B510
    }

    public class Slider : Selectable
    {
        public object m_FillRect;
        public object m_HandleRect;
        public object m_Direction;
        public object m_MinValue;
        public object m_MaxValue;
        public object m_WholeNumbers;
        public object m_Value;
        public object m_OnValueChanged;
        public object m_FillImage;
        public object m_FillTransform;
        public object m_FillContainerRect;
        public object m_HandleTransform;
        public object m_HandleContainerRect;
        public object m_Offset;
        public object m_Tracker;
        public object m_DelayedUpdateVisuals;

        // ── Methods ──
        public void get_fillRect(){} // RVA: 0x10B4170
        public void set_fillRect(){} // RVA: 0x80FD100
        public void get_handleRect(){} // RVA: 0x10B9D50
        public void set_handleRect(){} // RVA: 0x80FD170
        public void get_direction(){} // RVA: 0x23A4510
        public void set_direction(){} // RVA: 0x80FD1E0
        public void get_minValue(){} // RVA: 0xD06520
        public void set_minValue(){} // RVA: 0x80FD240
        public void get_maxValue(){} // RVA: 0x6EDDF40
        public void set_maxValue(){} // RVA: 0x80FD2C0
        public void get_wholeNumbers(){} // RVA: 0x80FD340
        public void set_wholeNumbers(){} // RVA: 0x80FD350
        public void get_value(){} // RVA: 0x80FD3D0
        public void set_value(){} // RVA: 0x80FD3F0
        public void SetValueWithoutNotify(){} // RVA: 0x80FD410
        public void get_normalizedValue(){} // RVA: 0x80FD430
        public void set_normalizedValue(){} // RVA: 0x80FD4E0
        public void get_onValueChanged(){} // RVA: 0xE3C930
        public void set_onValueChanged(){} // RVA: 0xE3D020
        public void get_stepSize(){} // RVA: 0x80FD530
        public void .ctor(){} // RVA: 0x80FD560
        public void Rebuild(){} // RVA: 0xB43310
        public void LayoutComplete(){} // RVA: 0xB43310
        public void GraphicUpdateComplete(){} // RVA: 0xB43310
        public void OnEnable(){} // RVA: 0x80FD690
        public void OnDisable(){} // RVA: 0x80F09E0
        public void Update(){} // RVA: 0x80FD6E0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x80FD730
        public void UpdateCachedReferences(){} // RVA: 0x80FDB10
        public void ClampValue(){} // RVA: 0x80FE400
        public void Set(){} // RVA: 0x80FE430
        public void OnRectTransformDimensionsChange(){} // RVA: 0x80FE520
        public void get_axis(){} // RVA: 0x80FE560
        public void get_reverseValue(){} // RVA: 0x80FE580
        public void UpdateVisuals(){} // RVA: 0x80FE5A0
        public void UpdateDrag(){} // RVA: 0x80FEA90
        public void MayDrag(){} // RVA: 0x80F17D0
        public void OnPointerDown(){} // RVA: 0x80FEDA0
        public void OnDrag(){} // RVA: 0x80FF080
        public void OnMove(){} // RVA: 0x80FF100
        public void FindSelectableOnLeft(){} // RVA: 0x80FF700
        public void FindSelectableOnRight(){} // RVA: 0x80FF730
        public void FindSelectableOnUp(){} // RVA: 0x80FF760
        public void FindSelectableOnDown(){} // RVA: 0x80FF790
        public void OnInitializePotentialDrag(){} // RVA: 0x13CB610
        public void SetDirection(){} // RVA: 0x80FF7C0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x114DE50
    }

    public class SpriteState : ValueType
    {
        public object m_HighlightedSprite;
        public object m_PressedSprite;
        public object m_SelectedSprite;
        public object m_DisabledSprite;

        // ── Methods ──
        public void get_highlightedSprite(){} // RVA: 0x77900
        public void set_highlightedSprite(){} // RVA: 0x47F10
        public void get_pressedSprite(){} // RVA: 0x77ED0
        public void set_pressedSprite(){} // RVA: 0x77E70
        public void get_selectedSprite(){} // RVA: 0x7E450
        public void set_selectedSprite(){} // RVA: 0x7E3E0
        public void get_disabledSprite(){} // RVA: 0x931A0
        public void set_disabledSprite(){} // RVA: 0x93120
        public void Equals(){} // RVA: 0x9AAF90
    }

    public class StencilMaterial : Object
    {
        public object m_List;

        // ── Methods ──
        public void Add(){} // RVA: 0x80FFF80
        public void LogWarningWhenNotInBatchmode(){} // RVA: 0x80FFEB0
        public void Remove(){} // RVA: 0x8100C40
        public void ClearAll(){} // RVA: 0x8100F60
        public void .cctor(){} // RVA: 0x8101170
    }

    public class Text : MaskableGraphic
    {
        public object m_FontData;
        public object m_Text;
        public object m_TextCache;
        public object m_TextCacheForLayout;
        public object s_DefaultText;
        public object m_DisableFontTextureRebuiltCallback;
        public object MAX_TEXT_LENGTH;
        public object m_TempVerts;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8101260
        public void get_cachedTextGenerator(){} // RVA: 0x81013F0
        public void get_cachedTextGeneratorForLayout(){} // RVA: 0x81014F0
        public void get_mainTexture(){} // RVA: 0x81015B0
        public void FontTextureChanged(){} // RVA: 0x8101960
        public void get_font(){} // RVA: 0x8101B00
        public void set_font(){} // RVA: 0x8101B20
        public void get_text(){} // RVA: 0xBC5BA0
        public void set_text(){} // RVA: 0x8101D40
        public void get_supportRichText(){} // RVA: 0x8101F80
        public void set_supportRichText(){} // RVA: 0x8101FA0
        public void get_resizeTextForBestFit(){} // RVA: 0x8102000
        public void set_resizeTextForBestFit(){} // RVA: 0x8102020
        public void get_resizeTextMinSize(){} // RVA: 0x8102080
        public void set_resizeTextMinSize(){} // RVA: 0x81020A0
        public void get_resizeTextMaxSize(){} // RVA: 0x8102100
        public void set_resizeTextMaxSize(){} // RVA: 0x8102120
        public void get_alignment(){} // RVA: 0x8102180
        public void set_alignment(){} // RVA: 0x81021A0
        public void get_alignByGeometry(){} // RVA: 0x8102200
        public void set_alignByGeometry(){} // RVA: 0x8102220
        public void get_fontSize(){} // RVA: 0x8102260
        public void set_fontSize(){} // RVA: 0x8102280
        public void get_horizontalOverflow(){} // RVA: 0x81022E0
        public void set_horizontalOverflow(){} // RVA: 0x8102300
        public void get_verticalOverflow(){} // RVA: 0x8102360
        public void set_verticalOverflow(){} // RVA: 0x8102380
        public void get_lineSpacing(){} // RVA: 0x81023E0
        public void set_lineSpacing(){} // RVA: 0x8102400
        public void get_fontStyle(){} // RVA: 0x8102470
        public void set_fontStyle(){} // RVA: 0x8102490
        public void get_pixelsPerUnit(){} // RVA: 0x81024F0
        public void OnEnable(){} // RVA: 0x8102750
        public void OnDisable(){} // RVA: 0x8102800
        public void UpdateGeometry(){} // RVA: 0x8102860
        public void AssignDefaultFont(){} // RVA: 0x8102970
        public void AssignDefaultFontIfNecessary(){} // RVA: 0x81029D0
        public void GetGenerationSettings(){} // RVA: 0x8102AF0
        public void GetTextAnchorPivot(){} // RVA: 0x8102DE0
        public void OnPopulateMesh(){} // RVA: 0x8102F50
        public void CalculateLayoutInputHorizontal(){} // RVA: 0xB43310
        public void CalculateLayoutInputVertical(){} // RVA: 0xB43310
        public void get_minWidth(){} // RVA: 0x13CD2E0
        public void get_preferredWidth(){} // RVA: 0x8103790
        public void get_flexibleWidth(){} // RVA: 0x7815340
        public void get_minHeight(){} // RVA: 0x13CD2E0
        public void get_preferredHeight(){} // RVA: 0x81038C0
        public void get_flexibleHeight(){} // RVA: 0x7815340
        public void get_layoutPriority(){} // RVA: 0xDAC980
    }

    public class Toggle : Selectable
    {
        public object toggleTransition;
        public object graphic;
        public object m_Group;
        public object onValueChanged;
        public object m_IsOn;

        // ── Methods ──
        public void get_group(){} // RVA: 0xD9E3D0
        public void set_group(){} // RVA: 0x8103A90
        public void .ctor(){} // RVA: 0x8103AC0
        public void Rebuild(){} // RVA: 0xB43310
        public void LayoutComplete(){} // RVA: 0xB43310
        public void GraphicUpdateComplete(){} // RVA: 0xB43310
        public void OnDestroy(){} // RVA: 0x8103BA0
        public void OnEnable(){} // RVA: 0x8103C90
        public void OnDisable(){} // RVA: 0x8103CD0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x8103D00
        public void SetToggleGroup(){} // RVA: 0x8103ED0
        public void get_isOn(){} // RVA: 0x6A667F0
        public void set_isOn(){} // RVA: 0x81041B0
        public void SetIsOnWithoutNotify(){} // RVA: 0x81041C0
        public void Set(){} // RVA: 0x81041D0
        public void PlayEffect(){} // RVA: 0x81043D0
        public void Start(){} // RVA: 0x8104500
        public void InternalToggle(){} // RVA: 0x8104510
        public void OnPointerClick(){} // RVA: 0x8104570
        public void OnSubmit(){} // RVA: 0x8104510
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x114DE50
    }

    public class ToggleGroup : UIBehaviour
    {
        public object m_AllowSwitchOff;
        public object m_Toggles;

        // ── Methods ──
        public void get_allowSwitchOff(){} // RVA: 0xC38360
        public void set_allowSwitchOff(){} // RVA: 0xC38370
        public void .ctor(){} // RVA: 0x8104680
        public void Start(){} // RVA: 0x8104780
        public void OnEnable(){} // RVA: 0x8104780
        public void ValidateToggleIsInGroup(){} // RVA: 0x8104790
        public void NotifyToggleOn(){} // RVA: 0x8104950
        public void UnregisterToggle(){} // RVA: 0x8104B60
        public void RegisterToggle(){} // RVA: 0x8104BE0
        public void EnsureValidState(){} // RVA: 0x8104CA0
        public void AnyTogglesOn(){} // RVA: 0x81050A0
        public void ActiveToggles(){} // RVA: 0x81052D0
        public void GetFirstActiveToggle(){} // RVA: 0x8105440
        public void SetAllTogglesOff(){} // RVA: 0x81054C0
    }

    public class Toggle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class VertexHelper : Object
    {
        public object m_Positions;
        public object m_Colors;
        public object m_Uv0S;
        public object m_Uv1S;
        public object m_Uv2S;
        public object m_Uv3S;
        public object m_Normals;
        public object m_Tangents;
        public object m_Indices;
        public object s_DefaultTangent;
        public object s_DefaultNormal;
        public object m_ListsInitalized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8107770
        public void InitializeListIfRequired(){} // RVA: 0x8107AC0
        public void Dispose(){} // RVA: 0x8108000
        public void Clear(){} // RVA: 0x8108520
        public void get_currentVertCount(){} // RVA: 0x8108620
        public void get_currentIndexCount(){} // RVA: 0x8108670
        public void PopulateUIVertex(){} // RVA: 0x81086C0
        public void SetUIVertex(){} // RVA: 0x8108910
        public void FillMesh(){} // RVA: 0x8108D20
        public void AddVert(){} // RVA: 0x81099E0
        public void AddTriangle(){} // RVA: 0x8109A90
        public void AddUIVertexQuad(){} // RVA: 0x8109C00
        public void AddUIVertexStream(){} // RVA: 0x8109E90
        public void AddUIVertexTriangleStream(){} // RVA: 0x810A010
        public void GetUIVertexStream(){} // RVA: 0x810A090
        public void .cctor(){} // RVA: 0x810A1A0
    }

    public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x80E0D70
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x80E8960
        public void CalculateLayoutInputVertical(){} // RVA: 0x80E8990
        public void SetLayoutHorizontal(){} // RVA: 0x80E89A0
        public void SetLayoutVertical(){} // RVA: 0x80E89B0
    }

    public class VerticalLayoutGroup[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}