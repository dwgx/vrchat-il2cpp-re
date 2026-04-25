// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UI
// Classes: 66
// Methods: 1219

namespace ThirdParty.Unity.UnityEngine.UI
{
    public class AnimationTriggers : Object
    {
        public string normalTrigger;
        public string highlightedTrigger;
        public string pressedTrigger;
        public string selectedTrigger;
        public string disabledTrigger;
        public string m_NormalTrigger; // 0x10
        public string m_HighlightedTrigger; // 0x18
        public string m_PressedTrigger; // 0x20
        public string m_SelectedTrigger; // 0x28
        public string m_DisabledTrigger; // 0x30

        // ── Methods ──
        public void get_normalTrigger(){} // RVA: 0x7FFAC2F3C380
        public void set_normalTrigger(){} // RVA: 0x7FFAC2F22E30
        public void get_highlightedTrigger(){} // RVA: 0x7FFAC2F247C0
        public void set_highlightedTrigger(){} // RVA: 0x7FFAC2F87E80
        public void get_pressedTrigger(){} // RVA: 0x7FFAC2F4F0C0
        public void set_pressedTrigger(){} // RVA: 0x7FFAC2F4F0D0
        public void get_selectedTrigger(){} // RVA: 0x7FFAC2F4F130
        public void set_selectedTrigger(){} // RVA: 0x7FFAC2F22E90
        public void get_disabledTrigger(){} // RVA: 0x7FFAC31D95E0
        public void set_disabledTrigger(){} // RVA: 0x7FFAC2F4F890
        public void .ctor(){} // RVA: 0x7FFAC9A52040
    }

    public class AspectRatioFitter : UIBehaviour
    {
        public 0x6B249DF0 aspectMode; // 0x20
        public float aspectRatio; // 0x24
        public UnityEngine.RectTransform rectTransform; // 0x28
        public bool m_DelayedSetDirty; // 0x30
        public bool m_DoesParentExist; // 0x31
        public UnityEngine.DrivenRectTransformTracker m_Tracker; // 0x32

        // ── Methods ──
        public void get_aspectMode(){} // RVA: 0x7FFAC30DBBE0
        public void set_aspectMode(){} // RVA: 0x7FFAC9C47EB0
        public void get_aspectRatio(){} // RVA: 0x7FFAC308EF50
        public void set_aspectRatio(){} // RVA: 0x7FFAC9C47F10
        public void get_rectTransform(){} // RVA: 0x7FFAC9C47F70
        public void .ctor(){} // RVA: 0x7FFAC30C00D0
        public void OnEnable(){} // RVA: 0x7FFAC9C480B0
        public void Start(){} // RVA: 0x7FFAC9C481F0
        public void OnDisable(){} // RVA: 0x7FFAC9C48270
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC9C482D0
        public void Update(){} // RVA: 0x7FFAC9C48410
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAC9C48430
        public void UpdateRect(){} // RVA: 0x7FFAC9C48440
        public void GetSizeDeltaToProduceSize(){} // RVA: 0x7FFAC9C48830
        public void GetParentSize(){} // RVA: 0x7FFAC9C48AA0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFAC2F21310
        public void SetLayoutVertical(){} // RVA: 0x7FFAC2F21310
        public void SetDirty(){} // RVA: 0x7FFAC9C48430
        public void IsComponentValidOnObject(){} // RVA: 0x7FFAC9C48CA0
        public void IsAspectModeValid(){} // RVA: 0x7FFAC9C48E70
        public void DoesParentExists(){} // RVA: 0x7FFAC2F47470
    }

    public class BaseMeshEffect : UIBehaviour
    {
        public UnityEngine.UI.Graphic graphic; // 0x20

        // ── Methods ──
        public void get_graphic(){} // RVA: 0x7FFAC9C74F50
        public void OnEnable(){} // RVA: 0x7FFAC9C75090
        public void OnDisable(){} // RVA: 0x7FFAC9C75190
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC9C75290
        public void ModifyMesh(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class BaseVertexEffect : Object
    {
        // ── Methods ──
        public void ModifyVertices(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Button : Selectable
    {
        public ButtonClickedEvent onClick; // 0x100

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A52290
        public void get_onClick(){} // RVA: 0x7FFAC34F6C80
        public void set_onClick(){} // RVA: 0x7FFAC34F6750
        public void Press(){} // RVA: 0x7FFAC9A523D0
        public void OnPointerClick(){} // RVA: 0x7FFAC9A52470
        public void OnSubmit(){} // RVA: 0x7FFAC9A524A0
        public void OnFinishSubmit(){} // RVA: 0x7FFAC9A525B0
    }

    public class CanvasScaler : UIBehaviour
    {
        public 0x6B249EA0 uiScaleMode; // 0x20
        public float referencePixelsPerUnit; // 0x24
        public float scaleFactor; // 0x28
        public UnityEngine.Vector2 referenceResolution; // 0x2C
        public 0x6B249EF8 screenMatchMode; // 0x34
        public float matchWidthOrHeight; // 0x38
        public float physicalUnit;
        public 0x6B249F50 fallbackScreenDPI; // 0x3C
        public float defaultSpriteDPI; // 0x40
        public float dynamicPixelsPerUnit; // 0x44
        public float m_DynamicPixelsPerUnit; // 0x48
        public UnityEngine.Canvas m_Canvas; // 0x50
        public float m_PrevScaleFactor; // 0x58
        public float m_PrevReferencePixelsPerUnit; // 0x5C
        public bool m_PresetInfoIsWorld; // 0x60

        // ── Methods ──
        public void get_uiScaleMode(){} // RVA: 0x7FFAC30DBBE0
        public void set_uiScaleMode(){} // RVA: 0x7FFAC35DB7A0
        public void get_referencePixelsPerUnit(){} // RVA: 0x7FFAC308EF50
        public void set_referencePixelsPerUnit(){} // RVA: 0x7FFAC308EF60
        public void get_scaleFactor(){} // RVA: 0x7FFAC3000210
        public void set_scaleFactor(){} // RVA: 0x7FFAC9C48E90
        public void get_referenceResolution(){} // RVA: 0x7FFAC9C48EB0
        public void set_referenceResolution(){} // RVA: 0x7FFAC9C48ED0
        public void get_screenMatchMode(){} // RVA: 0x7FFAC3ADEDC0
        public void set_screenMatchMode(){} // RVA: 0x7FFAC416A6E0
        public void get_matchWidthOrHeight(){} // RVA: 0x7FFAC3716E90
        public void set_matchWidthOrHeight(){} // RVA: 0x7FFAC3717190
        public void get_physicalUnit(){} // RVA: 0x7FFAC33BD4A0
        public void set_physicalUnit(){} // RVA: 0x7FFAC47E2CD0
        public void get_fallbackScreenDPI(){} // RVA: 0x7FFAC30E80B0
        public void set_fallbackScreenDPI(){} // RVA: 0x7FFAC30EFD80
        public void get_defaultSpriteDPI(){} // RVA: 0x7FFAC2F29970
        public void set_defaultSpriteDPI(){} // RVA: 0x7FFAC9C48F50
        public void get_dynamicPixelsPerUnit(){} // RVA: 0x7FFAC45C0DE0
        public void set_dynamicPixelsPerUnit(){} // RVA: 0x7FFAC45C0F70
        public void .ctor(){} // RVA: 0x7FFAC9C48F70
        public void OnEnable(){} // RVA: 0x7FFAC9C49000
        public void Canvas_preWillRenderCanvases(){} // RVA: 0x7FFAC3708F70
        public void OnDisable(){} // RVA: 0x7FFAC9C49100
        public void Handle(){} // RVA: 0x7FFAC9C491D0
        public void HandleWorldCanvas(){} // RVA: 0x7FFAC9C493E0
        public void HandleConstantPixelSize(){} // RVA: 0x7FFAC9C49450
        public void HandleScaleWithScreenSize(){} // RVA: 0x7FFAC9C494C0
        public void HandleConstantPhysicalSize(){} // RVA: 0x7FFAC9C49780
        public void SetScaleFactor(){} // RVA: 0x7FFAC9C498A0
        public void SetReferencePixelsPerUnit(){} // RVA: 0x7FFAC9C498E0
    }

    public class CanvasUpdateRegistry : Object
    {
        public UnityEngine.UI.CanvasUpdateRegistry instance;
        public bool m_PerformingLayoutUpdate; // 0x10
        public bool m_PerformingGraphicUpdate; // 0x11
        public string[] m_CanvasUpdateProfilerStrings; // 0x18
        public string m_CullingUpdateProfilerString;
        public UnityEngine.UI.Collections.IndexedSet`1<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue; // 0x20
        public UnityEngine.UI.Collections.IndexedSet`1<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue; // 0x28
        public System.Comparison`1<UnityEngine.UI.ICanvasElement> s_SortLayoutFunction; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A52840
        public void get_instance(){} // RVA: 0x7FFAC9A52B10
        public void ObjectValidForUpdate(){} // RVA: 0x7FFAC9A52C30
        public void CleanInvalidItems(){} // RVA: 0x7FFAC9A52DA0
        public void PerformUpdate(){} // RVA: 0x7FFAC9A52F70
        public void ParentCount(){} // RVA: 0x7FFAC9A536E0
        public void SortLayoutList(){} // RVA: 0x7FFAC9A538E0
        public void RegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFAC9A539A0
        public void TryRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFAC9A53A10
        public void InternalRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFAC9A53A80
        public void RegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFAC9A53B40
        public void TryRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFAC9A53BB0
        public void InternalRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFAC9A53C20
        public void UnRegisterCanvasElementForRebuild(){} // RVA: 0x7FFAC9A53D30
        public void DisableCanvasElementForRebuild(){} // RVA: 0x7FFAC9A54020
        public void InternalUnRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFAC9A54310
        public void InternalUnRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFAC9A54470
        public void InternalDisableCanvasElementForLayoutRebuild(){} // RVA: 0x7FFAC9A545D0
        public void InternalDisableCanvasElementForGraphicRebuild(){} // RVA: 0x7FFAC9A54730
        public void IsRebuildingLayout(){} // RVA: 0x7FFAC9A54890
        public void IsRebuildingGraphics(){} // RVA: 0x7FFAC9A548F0
        public void .cctor(){} // RVA: 0x7FFAC9A54950
    }

    public class ClipperRegistry : Object
    {
        public UnityEngine.UI.ClipperRegistry instance;
        public UnityEngine.UI.Collections.IndexedSet`1<UnityEngine.UI.IClipper> m_Clippers; // 0x10
        public bool HasCulledThisFrame; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A55330
        public void get_instance(){} // RVA: 0x7FFAC9A553F0
        public void Cull(){} // RVA: 0x7FFAC9A55570
        public void Register(){} // RVA: 0x7FFAC9A55750
        public void Unregister(){} // RVA: 0x7FFAC9A557C0
        public void Disable(){} // RVA: 0x7FFAC9A55820
    }

    public class Clipping : Object
    {
        // ── Methods ──
        public void FindCullAndClipWorldRect(){} // RVA: 0x7FFAC9A55880
    }

    public class ColorBlock : ValueType
    {
        public UnityEngine.Color normalColor; // 0x10
        public UnityEngine.Color highlightedColor; // 0x20
        public UnityEngine.Color pressedColor; // 0x30
        public UnityEngine.Color selectedColor; // 0x40
        public UnityEngine.Color disabledColor; // 0x50
        public float colorMultiplier; // 0x60
        public float fadeDuration; // 0x64
        public UnityEngine.UI.ColorBlock defaultColorBlock;

        // ── Methods ──
        public void get_normalColor(){} // RVA: 0x7FFAC32C0590
        public void set_normalColor(){} // RVA: 0x7FFAC450BA60
        public void get_highlightedColor(){} // RVA: 0x7FFAC4422E80
        public void set_highlightedColor(){} // RVA: 0x7FFAC4422E90
        public void get_pressedColor(){} // RVA: 0x7FFAC4A19630
        public void set_pressedColor(){} // RVA: 0x7FFAC8370D10
        public void get_selectedColor(){} // RVA: 0x7FFAC845FF30
        public void set_selectedColor(){} // RVA: 0x7FFAC845FF40
        public void get_disabledColor(){} // RVA: 0x7FFAC4AC8580
        public void set_disabledColor(){} // RVA: 0x7FFAC6D1E430
        public void get_colorMultiplier(){} // RVA: 0x7FFAC2F89460
        public void set_colorMultiplier(){} // RVA: 0x7FFAC2F89470
        public void get_fadeDuration(){} // RVA: 0x7FFAC3391600
        public void set_fadeDuration(){} // RVA: 0x7FFAC33914E0
        public void .cctor(){} // RVA: 0x7FFAC9A54A30
        public void Equals(){} // RVA: 0x7FFAC9A54E40 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9A55140
        public void op_Inequality(){} // RVA: 0x7FFAC9A551F0
        public void GetHashCode(){} // RVA: 0x7FFAC9A552A0
    }

    public class ContentSizeFitter : UIBehaviour
    {
        public 0x6B24A000 horizontalFit; // 0x20
        public 0x6B24A000 verticalFit; // 0x24
        public UnityEngine.RectTransform rectTransform; // 0x28
        public UnityEngine.DrivenRectTransformTracker m_Tracker; // 0x30

        // ── Methods ──
        public void get_horizontalFit(){} // RVA: 0x7FFAC30DBBE0
        public void set_horizontalFit(){} // RVA: 0x7FFAC9C49920
        public void get_verticalFit(){} // RVA: 0x7FFAC3921980
        public void set_verticalFit(){} // RVA: 0x7FFAC9C49980
        public void get_rectTransform(){} // RVA: 0x7FFAC9C499E0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void OnEnable(){} // RVA: 0x7FFAC9C49B20
        public void OnDisable(){} // RVA: 0x7FFAC9C49B30
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAC9C49B20
        public void HandleSelfFittingAlongAxis(){} // RVA: 0x7FFAC9C49B90
        public void SetLayoutHorizontal(){} // RVA: 0x7FFAC9C49C30
        public void SetLayoutVertical(){} // RVA: 0x7FFAC9C49CA0
        public void SetDirty(){} // RVA: 0x7FFAC9C49D10
    }

    public class DefaultControls : Object
    {
        public IFactoryControls factory;
        public float kWidth;
        public float kThickHeight;
        public float kThinHeight;
        public UnityEngine.Vector2 s_ThickElementSize; // 0x8
        public UnityEngine.Vector2 s_ThinElementSize; // 0x10
        public UnityEngine.Vector2 s_ImageElementSize; // 0x18
        public UnityEngine.Color s_DefaultSelectableColor; // 0x20
        public UnityEngine.Color s_PanelColor; // 0x30
        public UnityEngine.Color s_TextColor; // 0x40

        // ── Methods ──
        public void get_factory(){} // RVA: 0x7FFAC9A55FC0
        public void CreateUIElementRoot(){} // RVA: 0x7FFAC9A56020
        public void CreateUIObject(){} // RVA: 0x7FFAC9A56170
        public void SetDefaultTextValues(){} // RVA: 0x7FFAC9A56260
        public void SetDefaultColorTransitionValues(){} // RVA: 0x7FFAC9A563F0
        public void SetParentAndAlign(){} // RVA: 0x7FFAC9A56450
        public void SetLayerRecursively(){} // RVA: 0x7FFAC9A56650
        public void CreatePanel(){} // RVA: 0x7FFAC9A56860
        public void CreateButton(){} // RVA: 0x7FFAC9A56D60
        public void CreateText(){} // RVA: 0x7FFAC9A57490
        public void CreateImage(){} // RVA: 0x7FFAC9A576A0
        public void CreateRawImage(){} // RVA: 0x7FFAC9A57840
        public void CreateSlider(){} // RVA: 0x7FFAC9A579E0
        public void CreateScrollbar(){} // RVA: 0x7FFAC9A58860
        public void CreateToggle(){} // RVA: 0x7FFAC9A59130
        public void CreateInputField(){} // RVA: 0x7FFAC9A59CD0
        public void CreateDropdown(){} // RVA: 0x7FFAC9A5A860
        public void CreateScrollView(){} // RVA: 0x7FFAC9A5CBB0
        public void .cctor(){} // RVA: 0x7FFAC9A5DDE0
    }

    public class Dropdown : Selectable
    {
        public UnityEngine.RectTransform template; // 0x100
        public UnityEngine.UI.Text captionText; // 0x108
        public UnityEngine.UI.Image captionImage; // 0x110
        public UnityEngine.UI.Text itemText; // 0x118
        public UnityEngine.UI.Image itemImage; // 0x120
        public int options; // 0x128
        public OptionDataList onValueChanged; // 0x130
        public DropdownEvent alphaFadeSpeed; // 0x138
        public float value; // 0x140
        public UnityEngine.GameObject m_Dropdown; // 0x148
        public UnityEngine.GameObject m_Blocker; // 0x150
        public System.Collections.Generic.List`1<DropdownItem> m_Items; // 0x158
        public UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.FloatTween> m_AlphaTweenRunner; // 0x160
        public bool validTemplate; // 0x168
        public int kHighSortingLayer;
        public OptionData s_NoOptionData;

        // ── Methods ──
        public void get_template(){} // RVA: 0x7FFAC34F6C80
        public void set_template(){} // RVA: 0x7FFAC9A5E060
        public void get_captionText(){} // RVA: 0x7FFAC36D1F40
        public void set_captionText(){} // RVA: 0x7FFAC9A5E0C0
        public void get_captionImage(){} // RVA: 0x7FFAC354B170
        public void set_captionImage(){} // RVA: 0x7FFAC9A5E120
        public void get_itemText(){} // RVA: 0x7FFAC33BC6D0
        public void set_itemText(){} // RVA: 0x7FFAC9A5E180
        public void get_itemImage(){} // RVA: 0x7FFAC313CBB0
        public void set_itemImage(){} // RVA: 0x7FFAC9A5E1E0
        public void get_options(){} // RVA: 0x7FFAC9A5E240
        public void set_options(){} // RVA: 0x7FFAC9A5E260
        public void get_onValueChanged(){} // RVA: 0x7FFAC35422C0
        public void set_onValueChanged(){} // RVA: 0x7FFAC36D84B0
        public void get_alphaFadeSpeed(){} // RVA: 0x7FFAC9A5E2E0
        public void set_alphaFadeSpeed(){} // RVA: 0x7FFAC9A5E2F0
        public void get_value(){} // RVA: 0x7FFAC8A119F0
        public void set_value(){} // RVA: 0x7FFAC9A5E300
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9A5E310
        public void Set(){} // RVA: 0x7FFAC9A5E320
        public void .ctor(){} // RVA: 0x7FFAC9A5E4A0
        public void Awake(){} // RVA: 0x7FFAC9A5E6D0
        public void Start(){} // RVA: 0x7FFAC9A5E9E0
        public void OnDisable(){} // RVA: 0x7FFAC9A5EB10
        public void RefreshShownValue(){} // RVA: 0x7FFAC9A5EC70
        public void AddOptions(){} // RVA: 0x7FFAC9A5F2A0 | overloaded x3
        public void ClearOptions(){} // RVA: 0x7FFAC9A5F470
        public void SetupTemplate(){} // RVA: 0x7FFAC9A5F4F0
        public void GetOrAddComponent(){} // RVA: 0x7FFAC2E8DC40
        public void OnPointerClick(){} // RVA: 0x7FFAC9A60320
        public void OnSubmit(){} // RVA: 0x7FFAC9A60320
        public void OnCancel(){} // RVA: 0x7FFAC9A60330
        public void Show(){} // RVA: 0x7FFAC9A60340
        public void CreateBlocker(){} // RVA: 0x7FFAC9A61BD0
        public void DestroyBlocker(){} // RVA: 0x7FFAC9A62750
        public void CreateDropdownList(){} // RVA: 0x7FFAC9A627A0
        public void DestroyDropdownList(){} // RVA: 0x7FFAC9A62810
        public void CreateItem(){} // RVA: 0x7FFAC9A62860
        public void DestroyItem(){} // RVA: 0x7FFAC2F21310
        public void AddItem(){} // RVA: 0x7FFAC9A628D0
        public void AlphaFadeList(){} // RVA: 0x7FFAC9A63060 | overloaded x2
        public void SetAlpha(){} // RVA: 0x7FFAC9A63220
        public void Hide(){} // RVA: 0x7FFAC9A63340
        public void DelayedDestroyDropdownList(){} // RVA: 0x7FFAC9A636D0
        public void ImmediateDestroyDropdownList(){} // RVA: 0x7FFAC9A63790
        public void OnSelectItem(){} // RVA: 0x7FFAC9A63A80
        public void .cctor(){} // RVA: 0x7FFAC9A63D10
    }

    public class FontData : Object
    {
        public UnityEngine.Font defaultFontData; // 0x10
        public int font; // 0x18
        public 0x6B2D8AD8 fontSize; // 0x1C
        public bool fontStyle; // 0x20
        public int bestFit; // 0x24
        public int minSize; // 0x28
        public 0x6B2D8C90 maxSize; // 0x2C
        public bool alignment; // 0x30
        public bool alignByGeometry; // 0x31
        public 0x6B2D8CE8 richText; // 0x34
        public 0x6B2D8D40 horizontalOverflow; // 0x38
        public float verticalOverflow; // 0x3C

        // ── Methods ──
        public void get_defaultFontData(){} // RVA: 0x7FFAC9A641C0
        public void get_font(){} // RVA: 0x7FFAC2F3C380
        public void set_font(){} // RVA: 0x7FFAC2F22E30
        public void get_fontSize(){} // RVA: 0x7FFAC3157800
        public void set_fontSize(){} // RVA: 0x7FFAC392CD10
        public void get_fontStyle(){} // RVA: 0x7FFAC44357F0
        public void set_fontStyle(){} // RVA: 0x7FFAC44474D0
        public void get_bestFit(){} // RVA: 0x7FFAC300F9D0
        public void set_bestFit(){} // RVA: 0x7FFAC300F9E0
        public void get_minSize(){} // RVA: 0x7FFAC3921980
        public void set_minSize(){} // RVA: 0x7FFAC41674D0
        public void get_maxSize(){} // RVA: 0x7FFAC32EC4C0
        public void set_maxSize(){} // RVA: 0x7FFAC369A6E0
        public void get_alignment(){} // RVA: 0x7FFAC3C891D0
        public void set_alignment(){} // RVA: 0x7FFAC45B6490
        public void get_alignByGeometry(){} // RVA: 0x7FFAC2F47450
        public void set_alignByGeometry(){} // RVA: 0x7FFAC2F47460
        public void get_richText(){} // RVA: 0x7FFAC2F47470
        public void set_richText(){} // RVA: 0x7FFAC2F47480
        public void get_horizontalOverflow(){} // RVA: 0x7FFAC3ADEDC0
        public void set_horizontalOverflow(){} // RVA: 0x7FFAC416A6E0
        public void get_verticalOverflow(){} // RVA: 0x7FFAC358A870
        public void set_verticalOverflow(){} // RVA: 0x7FFAC3588350
        public void get_lineSpacing(){} // RVA: 0x7FFAC363CE20
        public void set_lineSpacing(){} // RVA: 0x7FFAC363C6C0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC9A64230
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FontUpdateTracker : Object
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.Font,System.Collections.Generic.HashSet`1<UnityEngine.UI.Text>> m_Tracked;

        // ── Methods ──
        public void TrackText(){} // RVA: 0x7FFAC9A64280
        public void RebuildForFont(){} // RVA: 0x7FFAC9A646C0
        public void UntrackText(){} // RVA: 0x7FFAC9A64880
        public void .cctor(){} // RVA: 0x7FFAC9A64C50
    }

    public class Graphic : UIBehaviour
    {
        public UnityEngine.Material defaultGraphicMaterial;
        public UnityEngine.Texture2D color; // 0x8
        public UnityEngine.Material raycastTarget; // 0x20
        public UnityEngine.Color raycastPadding; // 0x28
        public bool useLegacyMeshGeneration; // 0x38
        public bool depth; // 0x39
        public bool rectTransform; // 0x3A
        public bool canvas; // 0x3B
        public UnityEngine.Vector4 canvasRenderer; // 0x3C
        public UnityEngine.RectTransform defaultMaterial; // 0x50
        public UnityEngine.CanvasRenderer material; // 0x58
        public UnityEngine.Canvas materialForRendering; // 0x60
        public bool mainTexture; // 0x68
        public bool workerMesh; // 0x69
        public UnityEngine.Events.UnityAction m_OnDirtyLayoutCallback; // 0x70
        public UnityEngine.Events.UnityAction m_OnDirtyVertsCallback; // 0x78
        public UnityEngine.Events.UnityAction m_OnDirtyMaterialCallback; // 0x80
        public UnityEngine.Mesh s_Mesh; // 0x10
        public UnityEngine.UI.VertexHelper s_VertexHelper; // 0x18
        public UnityEngine.Mesh m_CachedMesh; // 0x88
        public UnityEngine.Vector2[] m_CachedUvs; // 0x90
        public UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.ColorTween> m_ColorTweenRunner; // 0x98
        public bool <useLegacyMeshGeneration>k__BackingField; // 0xA0

        // ── Methods ──
        public void get_defaultGraphicMaterial(){} // RVA: 0x7FFAC9A64D30
        public void get_color(){} // RVA: 0x7FFAC3BCF020
        public void set_color(){} // RVA: 0x7FFAC9A64F10
        public void get_raycastTarget(){} // RVA: 0x7FFAC3F7B7C0
        public void set_raycastTarget(){} // RVA: 0x7FFAC9A64F80
        public void get_raycastPadding(){} // RVA: 0x7FFAC8946F00
        public void set_raycastPadding(){} // RVA: 0x7FFAC8946F10
        public void get_useLegacyMeshGeneration(){} // RVA: 0x7FFAC45C9D50
        public void set_useLegacyMeshGeneration(){} // RVA: 0x7FFAC37B1910
        public void .ctor(){} // RVA: 0x7FFAC9A65090
        public void SetAllDirty(){} // RVA: 0x7FFAC9A65220
        public void SetLayoutDirty(){} // RVA: 0x7FFAC9A65290
        public void SetVerticesDirty(){} // RVA: 0x7FFAC9A65330
        public void SetMaterialDirty(){} // RVA: 0x7FFAC9A653C0
        public void SetRaycastDirty(){} // RVA: 0x7FFAC9A65460
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAC9A65580
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7FFAC9A656F0
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC9A657A0
        public void get_depth(){} // RVA: 0x7FFAC9A658A0
        public void get_rectTransform(){} // RVA: 0x7FFAC9A65910
        public void get_canvas(){} // RVA: 0x7FFAC9A659B0
        public void CacheCanvas(){} // RVA: 0x7FFAC9A65A90
        public void get_canvasRenderer(){} // RVA: 0x7FFAC9A65D10
        public void get_defaultMaterial(){} // RVA: 0x7FFAC9A65EA0
        public void get_material(){} // RVA: 0x7FFAC9A65EF0
        public void set_material(){} // RVA: 0x7FFAC9A65FE0
        public void get_materialForRendering(){} // RVA: 0x7FFAC9A66160
        public void get_mainTexture(){} // RVA: 0x7FFAC9A66370
        public void OnEnable(){} // RVA: 0x7FFAC9A663D0
        public void OnDisable(){} // RVA: 0x7FFAC9A66600
        public void OnDestroy(){} // RVA: 0x7FFAC9A667E0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFAC9A669A0
        public void OnCullingChanged(){} // RVA: 0x7FFAC9A66BF0
        public void Rebuild(){} // RVA: 0x7FFAC9A66CB0
        public void LayoutComplete(){} // RVA: 0x7FFAC2F21310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFAC2F21310
        public void UpdateMaterial(){} // RVA: 0x7FFAC9A66E40
        public void UpdateGeometry(){} // RVA: 0x7FFAC9A66FD0
        public void DoMeshGeneration(){} // RVA: 0x7FFAC9A66FF0
        public void DoLegacyMeshGeneration(){} // RVA: 0x7FFAC9A675E0
        public void get_workerMesh(){} // RVA: 0x7FFAC9A67BC0
        public void OnFillVBO(){} // RVA: 0x7FFAC2F21310
        public void OnPopulateMesh(){} // RVA: 0x7FFAC9A67E70 | overloaded x2
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC92840F0
        public void SetNativeSize(){} // RVA: 0x7FFAC2F21310
        public void Raycast(){} // RVA: 0x7FFAC9A68080
        public void PixelAdjustPoint(){} // RVA: 0x7FFAC9A685B0
        public void GetPixelAdjustedRect(){} // RVA: 0x7FFAC9A68880
        public void CrossFadeColor(){} // RVA: 0x7FFAC9A68BE0 | overloaded x2
        public void CreateColorFromAlpha(){} // RVA: 0x7FFAC9A690B0
        public void CrossFadeAlpha(){} // RVA: 0x7FFAC9A690D0
        public void RegisterDirtyLayoutCallback(){} // RVA: 0x7FFAC9A691A0
        public void UnregisterDirtyLayoutCallback(){} // RVA: 0x7FFAC9A69290
        public void RegisterDirtyVerticesCallback(){} // RVA: 0x7FFAC9A69380
        public void UnregisterDirtyVerticesCallback(){} // RVA: 0x7FFAC9A69470
        public void RegisterDirtyMaterialCallback(){} // RVA: 0x7FFAC9A69560
        public void UnregisterDirtyMaterialCallback(){} // RVA: 0x7FFAC9A69660
        public void .cctor(){} // RVA: 0x7FFAC9A69760
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFAC33BCDF0
    }

    public class GraphicRaycaster : BaseRaycaster
    {
        public int sortOrderPriority;
        public bool renderOrderPriority; // 0x28
        public 0x6B2494A8 ignoreReversedGraphics; // 0x2C
        public UnityEngine.LayerMask blockingObjects; // 0x30
        public UnityEngine.Canvas blockingMask; // 0x38
        public System.Collections.Generic.List`1<UnityEngine.UI.Graphic> canvas; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.UI.Graphic> eventCamera;

        // ── Methods ──
        public void get_sortOrderPriority(){} // RVA: 0x7FFAC9A69900
        public void get_renderOrderPriority(){} // RVA: 0x7FFAC9A699E0
        public void get_ignoreReversedGraphics(){} // RVA: 0x7FFAC30F6BA0
        public void set_ignoreReversedGraphics(){} // RVA: 0x7FFAC3C24F40
        public void get_blockingObjects(){} // RVA: 0x7FFAC3C891D0
        public void set_blockingObjects(){} // RVA: 0x7FFAC45B6490
        public void get_blockingMask(){} // RVA: 0x7FFAC2F7CCD0
        public void set_blockingMask(){} // RVA: 0x7FFAC2F7CCE0
        public void .ctor(){} // RVA: 0x7FFAC9A69B10
        public void get_canvas(){} // RVA: 0x7FFAC9A69C10
        public void Raycast(){} // RVA: 0x7FFAC9A6B390 | overloaded x2
        public void get_eventCamera(){} // RVA: 0x7FFAC9A6B1B0
        public void .cctor(){} // RVA: 0x7FFAC9A6BAD0
    }

    public class GraphicRegistry : Object
    {
        public UnityEngine.UI.GraphicRegistry instance;
        public System.Collections.Generic.Dictionary`2<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet`1<UnityEngine.UI.Graphic>> m_Graphics; // 0x10
        public System.Collections.Generic.Dictionary`2<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet`1<UnityEngine.UI.Graphic>> m_RaycastableGraphics; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.UI.Graphic> s_EmptyList; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A6BD50
        public void get_instance(){} // RVA: 0x7FFAC9A6BF70
        public void RegisterGraphicForCanvas(){} // RVA: 0x7FFAC9A6C090
        public void RegisterRaycastGraphicForCanvas(){} // RVA: 0x7FFAC9A6C430
        public void UnregisterGraphicForCanvas(){} // RVA: 0x7FFAC9A6C7E0
        public void UnregisterRaycastGraphicForCanvas(){} // RVA: 0x7FFAC9A6CA90
        public void DisableGraphicForCanvas(){} // RVA: 0x7FFAC9A6CD10
        public void DisableRaycastGraphicForCanvas(){} // RVA: 0x7FFAC9A6CF30
        public void GetGraphicsForCanvas(){} // RVA: 0x7FFAC9A6D150
        public void GetRaycastableGraphicsForCanvas(){} // RVA: 0x7FFAC9A6D220
        public void .cctor(){} // RVA: 0x7FFAC9A6D2F0
    }

    public class GridLayoutGroup : LayoutGroup
    {
        public 0x6B24A0B0 startCorner; // 0x60
        public 0x6B24A108 startAxis; // 0x64
        public UnityEngine.Vector2 cellSize; // 0x68
        public UnityEngine.Vector2 spacing; // 0x70
        public 0x6B24A160 constraint; // 0x78
        public int constraintCount; // 0x7C

        // ── Methods ──
        public void get_startCorner(){} // RVA: 0x7FFAC3138C20
        public void set_startCorner(){} // RVA: 0x7FFAC9C49D90
        public void get_startAxis(){} // RVA: 0x7FFAC3138CA0
        public void set_startAxis(){} // RVA: 0x7FFAC9C49DE0
        public void get_cellSize(){} // RVA: 0x7FFAC9C49E30
        public void set_cellSize(){} // RVA: 0x7FFAC9C49E50
        public void get_spacing(){} // RVA: 0x7FFAC9C49EA0
        public void set_spacing(){} // RVA: 0x7FFAC9C49EC0
        public void get_constraint(){} // RVA: 0x7FFAC4596EF0
        public void set_constraint(){} // RVA: 0x7FFAC9C49F10
        public void get_constraintCount(){} // RVA: 0x7FFAC4598F70
        public void set_constraintCount(){} // RVA: 0x7FFAC9C49F60
        public void .ctor(){} // RVA: 0x7FFAC9C4A050
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC9C4A0C0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC9C4A2D0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFAC9C4A500
        public void SetLayoutVertical(){} // RVA: 0x7FFAC9C4A510
        public void SetCellsAlongAxis(){} // RVA: 0x7FFAC9C4A520
    }

    public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C4ACE0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC9C4ACF0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC9C4AD20
        public void SetLayoutHorizontal(){} // RVA: 0x7FFAC9C4AD30
        public void SetLayoutVertical(){} // RVA: 0x7FFAC9C4AD40
    }

    public class HorizontalOrVerticalLayoutGroup : LayoutGroup
    {
        public float spacing; // 0x60
        public bool childForceExpandWidth; // 0x64
        public bool childForceExpandHeight; // 0x65
        public bool childControlWidth; // 0x66
        public bool childControlHeight; // 0x67
        public bool childScaleWidth; // 0x68
        public bool childScaleHeight; // 0x69
        public bool reverseArrangement; // 0x6A

        // ── Methods ──
        public void get_spacing(){} // RVA: 0x7FFAC3031E10
        public void set_spacing(){} // RVA: 0x7FFAC9C4AD50
        public void get_childForceExpandWidth(){} // RVA: 0x7FFAC3F45FE0
        public void set_childForceExpandWidth(){} // RVA: 0x7FFAC9C4AE00
        public void get_childForceExpandHeight(){} // RVA: 0x7FFAC8EA0370
        public void set_childForceExpandHeight(){} // RVA: 0x7FFAC9C4AE50
        public void get_childControlWidth(){} // RVA: 0x7FFAC8EA02D0
        public void set_childControlWidth(){} // RVA: 0x7FFAC9C4AEA0
        public void get_childControlHeight(){} // RVA: 0x7FFAC8EA02C0
        public void set_childControlHeight(){} // RVA: 0x7FFAC9C4AEF0
        public void get_childScaleWidth(){} // RVA: 0x7FFAC2FE9570
        public void set_childScaleWidth(){} // RVA: 0x7FFAC9C4AF40
        public void get_childScaleHeight(){} // RVA: 0x7FFAC4670BD0
        public void set_childScaleHeight(){} // RVA: 0x7FFAC9C4AF90
        public void get_reverseArrangement(){} // RVA: 0x7FFAC8290C80
        public void set_reverseArrangement(){} // RVA: 0x7FFAC9C4AFE0
        public void CalcAlongAxis(){} // RVA: 0x7FFAC9C4B030
        public void SetChildrenAlongAxis(){} // RVA: 0x7FFAC9C4B4E0
        public void GetChildSizes(){} // RVA: 0x7FFAC9C4C090
        public void .ctor(){} // RVA: 0x7FFAC9C4ACE0
    }

    public class ICanvasElement
    {
        public object transform;

        // ── Methods ──
        public void Rebuild(){} // RVA: 0x7FFAC2C70ED0
        public void get_transform(){} // RVA: 0x7FFAC2C58E90
        public void LayoutComplete(){} // RVA: 0x7FFAC2C70980
        public void GraphicUpdateComplete(){} // RVA: 0x7FFAC2C70980
        public void IsDestroyed(){} // RVA: 0x7FFAC2C59D00
    }

    public class IClippable
    {
        public object gameObject;
        public object rectTransform;

        // ── Methods ──
        public void get_gameObject(){} // RVA: 0x7FFAC2C58E90
        public void RecalculateClipping(){} // RVA: 0x7FFAC2C70980
        public void get_rectTransform(){} // RVA: 0x7FFAC2C58E90
        public void Cull(){}
        public void SetClipRect(){}
        public void SetClipSoftness(){} // RVA: 0x7FFAC2C7F3E0
    }

    public class IClipper
    {
        // ── Methods ──
        public void PerformClipping(){} // RVA: 0x7FFAC2C70980
    }

    public class IGraphicEnabledDisabled
    {
        // ── Methods ──
        public void OnSiblingGraphicEnabledDisabled(){} // RVA: 0x7FFAC2C70980
    }

    public class ILayoutController
    {
        // ── Methods ──
        public void SetLayoutHorizontal(){} // RVA: 0x7FFAC2C70980
        public void SetLayoutVertical(){} // RVA: 0x7FFAC2C70980
    }

    public class ILayoutElement
    {
        public object minWidth;
        public object preferredWidth;
        public object flexibleWidth;
        public object minHeight;
        public object preferredHeight;
        public object flexibleHeight;
        public object layoutPriority;

        // ── Methods ──
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC2C70980
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC2C70980
        public void get_minWidth(){} // RVA: 0x7FFAC2C6D880
        public void get_preferredWidth(){} // RVA: 0x7FFAC2C6D880
        public void get_flexibleWidth(){} // RVA: 0x7FFAC2C6D880
        public void get_minHeight(){} // RVA: 0x7FFAC2C6D880
        public void get_preferredHeight(){} // RVA: 0x7FFAC2C6D880
        public void get_flexibleHeight(){} // RVA: 0x7FFAC2C6D880
        public void get_layoutPriority(){} // RVA: 0x7FFAC2C59960
    }

    public class ILayoutGroup
    {
    }

    public class ILayoutIgnorer
    {
        public object ignoreLayout;

        // ── Methods ──
        public void get_ignoreLayout(){} // RVA: 0x7FFAC2C59D00
    }

    public class ILayoutSelfController
    {
    }

    public class IMask
    {
        public object rectTransform;

        // ── Methods ──
        public void Enabled(){} // RVA: 0x7FFAC2C59D00
        public void get_rectTransform(){} // RVA: 0x7FFAC2C58E90
    }

    public class IMaskable
    {
        // ── Methods ──
        public void RecalculateMasking(){} // RVA: 0x7FFAC2C70980
    }

    public class IMaterialModifier
    {
        // ── Methods ──
        public void GetModifiedMaterial(){} // RVA: 0x7FFAC2C58F40
    }

    public class IMeshModifier
    {
        // ── Methods ──
        public void ModifyMesh(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
    }

    public class IVertexModifier
    {
        // ── Methods ──
        public void ModifyVertices(){} // RVA: 0x7FFAC2C70A40
    }

    public class Image : MaskableGraphic
    {
        public UnityEngine.Material sprite;
        public UnityEngine.Sprite overrideSprite; // 0xE0
        public UnityEngine.Sprite activeSprite; // 0xE8
        public 0x6B249660 type; // 0xF0
        public bool preserveAspect; // 0xF4
        public bool fillCenter; // 0xF5
        public 0x6B2496B8 fillMethod; // 0xF8
        public float fillAmount; // 0xFC
        public bool fillClockwise; // 0x100
        public int fillOrigin; // 0x104
        public float eventAlphaThreshold; // 0x108
        public bool alphaHitTestMinimumThreshold; // 0x10C
        public bool useSpriteMesh; // 0x10D
        public float defaultETC1GraphicMaterial; // 0x110
        public float mainTexture; // 0x114
        public UnityEngine.Vector2[] hasBorder; // 0x8
        public UnityEngine.Vector2[] pixelsPerUnitMultiplier; // 0x10
        public UnityEngine.Vector3[] pixelsPerUnit; // 0x18
        public UnityEngine.Vector3[] multipliedPixelsPerUnit; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.UI.Image> material; // 0x28
        public bool minWidth; // 0x30

        // ── Methods ──
        public void get_sprite(){} // RVA: 0x7FFAC2FA2900
        public void set_sprite(){} // RVA: 0x7FFAC9A6D3D0
        public void DisableSpriteOptimizations(){} // RVA: 0x7FFAC9A6DB70
        public void get_overrideSprite(){} // RVA: 0x7FFAC9A6DB80
        public void set_overrideSprite(){} // RVA: 0x7FFAC9A6DB90
        public void get_activeSprite(){} // RVA: 0x7FFAC9A6DC10
        public void get_type(){} // RVA: 0x7FFAC60855D0
        public void set_type(){} // RVA: 0x7FFAC9A6DD00
        public void get_preserveAspect(){} // RVA: 0x7FFAC3E5B1F0
        public void set_preserveAspect(){} // RVA: 0x7FFAC9A6DD70
        public void get_fillCenter(){} // RVA: 0x7FFAC3E5DCB0
        public void set_fillCenter(){} // RVA: 0x7FFAC9A6DDE0
        public void get_fillMethod(){} // RVA: 0x7FFAC3E69BA0
        public void set_fillMethod(){} // RVA: 0x7FFAC9A6DE50
        public void get_fillAmount(){} // RVA: 0x7FFAC30F10F0
        public void set_fillAmount(){} // RVA: 0x7FFAC9A6DED0
        public void get_fillClockwise(){} // RVA: 0x7FFAC3C8B9C0
        public void set_fillClockwise(){} // RVA: 0x7FFAC9A6DF60
        public void get_fillOrigin(){} // RVA: 0x7FFAC47B0110
        public void set_fillOrigin(){} // RVA: 0x7FFAC9A6DFD0
        public void get_eventAlphaThreshold(){} // RVA: 0x7FFAC9A6E040
        public void set_eventAlphaThreshold(){} // RVA: 0x7FFAC9A6E060
        public void get_alphaHitTestMinimumThreshold(){} // RVA: 0x7FFAC49661C0
        public void set_alphaHitTestMinimumThreshold(){} // RVA: 0x7FFAC9A6E080
        public void get_useSpriteMesh(){} // RVA: 0x7FFAC6715A00
        public void set_useSpriteMesh(){} // RVA: 0x7FFAC9A6E350
        public void .ctor(){} // RVA: 0x7FFAC9A6E3C0
        public void get_defaultETC1GraphicMaterial(){} // RVA: 0x7FFAC9A6E420
        public void get_mainTexture(){} // RVA: 0x7FFAC9A6E600
        public void get_hasBorder(){} // RVA: 0x7FFAC9A6E910
        public void get_pixelsPerUnitMultiplier(){} // RVA: 0x7FFAC9A6EAA0
        public void set_pixelsPerUnitMultiplier(){} // RVA: 0x7FFAC9A6EAB0
        public void get_pixelsPerUnit(){} // RVA: 0x7FFAC9A6EAE0
        public void get_multipliedPixelsPerUnit(){} // RVA: 0x7FFAC9A6ED30
        public void get_material(){} // RVA: 0x7FFAC9A6ED50
        public void set_material(){} // RVA: 0x7FFAC9A6F010
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC9A6F020
        public void PreserveSpriteAspectRatio(){} // RVA: 0x7FFAC36F6210
        public void GetDrawingDimensions(){} // RVA: 0x7FFAC9A6F090
        public void SetNativeSize(){} // RVA: 0x7FFAC9A6F5C0
        public void OnPopulateMesh(){} // RVA: 0x7FFAC9A6F8B0
        public void TrackSprite(){} // RVA: 0x7FFAC9A6FA70
        public void OnEnable(){} // RVA: 0x7FFAC9A6FDD0
        public void OnDisable(){} // RVA: 0x7FFAC9A6FE30
        public void UpdateMaterial(){} // RVA: 0x7FFAC9A6FF10
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFAC9A702E0
        public void GenerateSimpleSprite(){} // RVA: 0x7FFAC9A704F0
        public void GenerateSprite(){} // RVA: 0x7FFAC9A70970
        public void GenerateSlicedSprite(){} // RVA: 0x7FFAC9A710D0
        public void GenerateTiledSprite(){} // RVA: 0x7FFAC9A71BD0
        public void AddQuad(){} // RVA: 0x7FFAC36F5FB0 | overloaded x2
        public void GetAdjustedBorders(){} // RVA: 0x7FFAC36F59B0
        public void GenerateFilledSprite(){} // RVA: 0x7FFAC9A73390
        public void RadialCut(){} // RVA: 0x7FFAC9A747F0 | overloaded x2
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC2F21310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC2F21310
        public void get_minWidth(){} // RVA: 0x7FFAC37432E0
        public void get_preferredWidth(){} // RVA: 0x7FFAC9A74CB0
        public void get_flexibleWidth(){} // RVA: 0x7FFAC954F350
        public void get_minHeight(){} // RVA: 0x7FFAC37432E0
        public void get_preferredHeight(){} // RVA: 0x7FFAC9A74E70
        public void get_flexibleHeight(){} // RVA: 0x7FFAC954F350
        public void get_layoutPriority(){} // RVA: 0x7FFAC34F9180
        public void IsRaycastLocationValid(){} // RVA: 0x7FFAC9A75030
        public void MapCoordinate(){} // RVA: 0x7FFAC9A754D0
        public void RebuildImage(){} // RVA: 0x7FFAC9A75BE0
        public void TrackImage(){} // RVA: 0x7FFAC9A75E50
        public void UnTrackImage(){} // RVA: 0x7FFAC9A75FC0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC9A76050
        public void .cctor(){} // RVA: 0x7FFAC9A760A0
        public void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0(){} // RVA: 0x7FFAC9A76430
        public void <set_sprite>g__SpriteSupportsAlphaHitTest|11_1(){} // RVA: 0x7FFAC9A764C0
    }

    public class InputField : Selectable
    {
        public UnityEngine.TouchScreenKeyboard input; // 0x100
        public char[] compositionString;
        public bool mesh; // 0x8
        public bool cachedInputTextGenerator; // 0x9
        public UnityEngine.UI.Text shouldHideMobileInput; // 0x108
        public UnityEngine.UI.Graphic shouldActivateOnSelect; // 0x110
        public 0x6B2499D0 text; // 0x118
        public 0x6B249A28 isFocused; // 0x11C
        public char caretBlinkRate; // 0x120
        public 0x6B180430 caretWidth; // 0x124
        public 0x6B249AD8 textComponent; // 0x128
        public bool placeholder; // 0x12C
        public 0x6B249A80 caretColor; // 0x130
        public int customCaretColor; // 0x134
        public SubmitEvent selectionColor; // 0x138
        public SubmitEvent onEndEdit; // 0x140
        public EndEditEvent onSubmit; // 0x148
        public OnChangeEvent onValueChange; // 0x150
        public OnValidateInput onValueChanged; // 0x158
        public UnityEngine.Color onValidateInput; // 0x160
        public bool characterLimit; // 0x170
        public UnityEngine.Color contentType; // 0x174
        public string lineType; // 0x188
        public float inputType; // 0x190
        public int touchScreenKeyboard; // 0x194
        public bool keyboardType; // 0x198
        public bool characterValidation; // 0x199
        public int readOnly; // 0x19C
        public int multiLine; // 0x1A0
        public UnityEngine.RectTransform asteriskChar; // 0x1A8
        public UnityEngine.UIVertex[] wasCanceled; // 0x1B0
        public UnityEngine.TextGenerator caretPositionInternal; // 0x1B8
        public UnityEngine.CanvasRenderer caretSelectPositionInternal; // 0x1C0
        public bool hasSelection; // 0x1C8
        public UnityEngine.Mesh caretPosition; // 0x1D0
        public bool selectionAnchorPosition; // 0x1D8
        public bool selectionFocusPosition; // 0x1D9
        public bool clipboard; // 0x1DA
        public bool minWidth; // 0x1DB
        public float preferredWidth;
        public float flexibleWidth;
        public bool minHeight; // 0x1DC
        public UnityEngine.Coroutine preferredHeight; // 0x1E0
        public float flexibleHeight; // 0x1E8
        public int layoutPriority; // 0x1EC
        public int m_DrawEnd; // 0x1F0
        public UnityEngine.Coroutine m_DragCoroutine; // 0x1F8
        public string m_OriginalText; // 0x200
        public bool m_WasCanceled; // 0x208
        public bool m_HasDoneFocusTransition; // 0x209
        public UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x210
        public bool m_TouchKeyboardAllowsInPlaceEditing; // 0x218
        public bool m_IsCompositionActive; // 0x219
        public string kEmailSpecialCharacters;
        public string kOculusQuestDeviceModel;
        public string kPicoDeviceModel;
        public UnityEngine.Event m_ProcessingEvent; // 0x220
        public int k_MaxTextLength;

        // ── Methods ──
        public void get_input(){} // RVA: 0x7FFAC9C39180
        public void get_compositionString(){} // RVA: 0x7FFAC9C39370
        public void .ctor(){} // RVA: 0x7FFAC9C394C0
        public void get_mesh(){} // RVA: 0x7FFAC9C39990
        public void get_cachedInputTextGenerator(){} // RVA: 0x7FFAC9C39B00
        public void set_shouldHideMobileInput(){} // RVA: 0x7FFAC9C39BC0
        public void get_shouldHideMobileInput(){} // RVA: 0x7FFAC9C39C10
        public void set_shouldActivateOnSelect(){} // RVA: 0x7FFAC8C44910
        public void get_shouldActivateOnSelect(){} // RVA: 0x7FFAC9C39CB0
        public void get_text(){} // RVA: 0x7FFAC35410C0
        public void set_text(){} // RVA: 0x7FFAC9C39D50
        public void SetTextWithoutNotify(){} // RVA: 0x7FFAC9C39D60
        public void SetText(){} // RVA: 0x7FFAC9C39D70
        public void get_isFocused(){} // RVA: 0x7FFAC47C42D0
        public void get_caretBlinkRate(){} // RVA: 0x7FFAC9C3A260
        public void set_caretBlinkRate(){} // RVA: 0x7FFAC9C3A270
        public void get_caretWidth(){} // RVA: 0x7FFAC9645C70
        public void set_caretWidth(){} // RVA: 0x7FFAC9C3A2E0
        public void get_textComponent(){} // RVA: 0x7FFAC36D1F40
        public void set_textComponent(){} // RVA: 0x7FFAC9C3A340
        public void get_placeholder(){} // RVA: 0x7FFAC354B170
        public void set_placeholder(){} // RVA: 0x7FFAC9C3A6D0
        public void get_caretColor(){} // RVA: 0x7FFAC9C3A730
        public void set_caretColor(){} // RVA: 0x7FFAC9C3A790
        public void get_customCaretColor(){} // RVA: 0x7FFAC39E59C0
        public void set_customCaretColor(){} // RVA: 0x7FFAC9C3A800
        public void get_selectionColor(){} // RVA: 0x7FFAC9C3A820
        public void set_selectionColor(){} // RVA: 0x7FFAC9C3A830
        public void get_onEndEdit(){} // RVA: 0x7FFAC2F8C660
        public void set_onEndEdit(){} // RVA: 0x7FFAC9C3A8A0
        public void get_onSubmit(){} // RVA: 0x7FFAC35422C0
        public void set_onSubmit(){} // RVA: 0x7FFAC9C3A900
        public void get_onValueChange(){} // RVA: 0x7FFAC354DFA0
        public void set_onValueChange(){} // RVA: 0x7FFAC9C3A960
        public void get_onValueChanged(){} // RVA: 0x7FFAC354DFA0
        public void set_onValueChanged(){} // RVA: 0x7FFAC9C3A960
        public void get_onValidateInput(){} // RVA: 0x7FFAC3542410
        public void set_onValidateInput(){} // RVA: 0x7FFAC9C3A9C0
        public void get_characterLimit(){} // RVA: 0x7FFAC92F4E20
        public void set_characterLimit(){} // RVA: 0x7FFAC9C3AA20
        public void get_contentType(){} // RVA: 0x7FFAC49661E0
        public void set_contentType(){} // RVA: 0x7FFAC9C3AAD0
        public void get_lineType(){} // RVA: 0x7FFAC8A119F0
        public void set_lineType(){} // RVA: 0x7FFAC9C3AC80
        public void get_inputType(){} // RVA: 0x7FFAC9AFAC70
        public void set_inputType(){} // RVA: 0x7FFAC9C3AD70
        public void get_touchScreenKeyboard(){} // RVA: 0x7FFAC34F6C80
        public void get_keyboardType(){} // RVA: 0x7FFAC88D4E90
        public void set_keyboardType(){} // RVA: 0x7FFAC9C3ADE0
        public void get_characterValidation(){} // RVA: 0x7FFAC33BC1B0
        public void set_characterValidation(){} // RVA: 0x7FFAC9C3AE50
        public void get_readOnly(){} // RVA: 0x7FFAC8B3EBF0
        public void set_readOnly(){} // RVA: 0x7FFAC8B3EC00
        public void get_multiLine(){} // RVA: 0x7FFAC9C3AEC0
        public void get_asteriskChar(){} // RVA: 0x7FFAC9C3AEE0
        public void set_asteriskChar(){} // RVA: 0x7FFAC9C3AEF0
        public void get_wasCanceled(){} // RVA: 0x7FFAC8C44960
        public void ClampPos(){} // RVA: 0x7FFAC9C3AFA0
        public void get_caretPositionInternal(){} // RVA: 0x7FFAC9C3AFE0
        public void set_caretPositionInternal(){} // RVA: 0x7FFAC9C3B010
        public void get_caretSelectPositionInternal(){} // RVA: 0x7FFAC9C3B060
        public void set_caretSelectPositionInternal(){} // RVA: 0x7FFAC9C3B090
        public void get_hasSelection(){} // RVA: 0x7FFAC9C3B0E0
        public void get_caretPosition(){} // RVA: 0x7FFAC9C3B060
        public void set_caretPosition(){} // RVA: 0x7FFAC9C3B140
        public void get_selectionAnchorPosition(){} // RVA: 0x7FFAC9C3AFE0
        public void set_selectionAnchorPosition(){} // RVA: 0x7FFAC9C3B170
        public void get_selectionFocusPosition(){} // RVA: 0x7FFAC9C3B060
        public void set_selectionFocusPosition(){} // RVA: 0x7FFAC9C3B1E0
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC9C3B250
        public void OnEnable(){} // RVA: 0x7FFAC9C3B3B0
        public void OnDisable(){} // RVA: 0x7FFAC9C3B7A0
        public void OnDestroy(){} // RVA: 0x7FFAC9C3BC40
        public void CaretBlink(){} // RVA: 0x7FFAC9C3BC90
        public void SetCaretVisible(){} // RVA: 0x7FFAC9C3BD30
        public void SetCaretActive(){} // RVA: 0x7FFAC9C3BDB0
        public void UpdateCaretMaterial(){} // RVA: 0x7FFAC9C3BEA0
        public void OnFocus(){} // RVA: 0x7FFAC9C3C0D0
        public void SelectAll(){} // RVA: 0x7FFAC9C3C0E0
        public void MoveTextEnd(){} // RVA: 0x7FFAC9C3C170
        public void MoveTextStart(){} // RVA: 0x7FFAC9C3C290
        public void get_clipboard(){} // RVA: 0x7FFAC9C3C380
        public void set_clipboard(){} // RVA: 0x7FFAC9C3C400
        public void TouchScreenKeyboardShouldBeUsed(){} // RVA: 0x7FFAC9C3C490
        public void InPlaceEditing(){} // RVA: 0x7FFAC9C3C5B0
        public void InPlaceEditingChanged(){} // RVA: 0x7FFAC9C3C5E0
        public void GetInternalSelection(){} // RVA: 0x7FFAC9C3C690
        public void UpdateKeyboardCaret(){} // RVA: 0x7FFAC9C3C780
        public void UpdateCaretFromKeyboard(){} // RVA: 0x7FFAC9C3C890
        public void LateUpdate(){} // RVA: 0x7FFAC9C3CA40
        public void ScreenToLocal(){} // RVA: 0x7FFAC9C3D280
        public void GetUnclampedCharacterLineFromPosition(){} // RVA: 0x7FFAC9C3DA50
        public void GetCharacterIndexFromPosition(){} // RVA: 0x7FFAC9C3DD50
        public void MayDrag(){} // RVA: 0x7FFAC9C3E060
        public void OnBeginDrag(){} // RVA: 0x7FFAC9C3E1C0
        public void OnDrag(){} // RVA: 0x7FFAC9C3E1F0
        public void MouseDragOutsideRect(){} // RVA: 0x7FFAC9C3E5A0
        public void OnEndDrag(){} // RVA: 0x7FFAC9C3E6A0
        public void OnPointerDown(){} // RVA: 0x7FFAC9C3E6D0
        public void KeyPressed(){} // RVA: 0x7FFAC9C3E9C0
        public void IsValidChar(){} // RVA: 0x7FFAC9C3EFD0
        public void ProcessEvent(){} // RVA: 0x7FFAC9C3F030
        public void OnUpdateSelected(){} // RVA: 0x7FFAC9C3F040
        public void GetSelectedString(){} // RVA: 0x7FFAC9C3F2D0
        public void FindtNextWordBegin(){} // RVA: 0x7FFAC9C3F3D0
        public void MoveRight(){} // RVA: 0x7FFAC9C3F4E0
        public void FindtPrevWordBegin(){} // RVA: 0x7FFAC9C3F780
        public void MoveLeft(){} // RVA: 0x7FFAC9C3F880
        public void DetermineCharacterLine(){} // RVA: 0x7FFAC9C3FB10
        public void LineUpCharacterPosition(){} // RVA: 0x7FFAC9C3FCB0
        public void LineDownCharacterPosition(){} // RVA: 0x7FFAC9C3FF50
        public void MoveDown(){} // RVA: 0x7FFAC9C40280 | overloaded x2
        public void MoveUp(){} // RVA: 0x7FFAC9C404B0 | overloaded x2
        public void Delete(){} // RVA: 0x7FFAC9C40690
        public void ForwardSpace(){} // RVA: 0x7FFAC9C40950
        public void Backspace(){} // RVA: 0x7FFAC9C40A60
        public void Insert(){} // RVA: 0x7FFAC9C40BE0
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0x7FFAC9C40E10
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0x7FFAC9C40E70
        public void SendOnValueChanged(){} // RVA: 0x7FFAC9C40E90
        public void SendOnEndEdit(){} // RVA: 0x7FFAC9C40F50
        public void SendOnSubmit(){} // RVA: 0x7FFAC9C41010
        public void Append(){} // RVA: 0x7FFAC9C411B0 | overloaded x2
        public void UpdateLabel(){} // RVA: 0x7FFAC9C41540
        public void IsSelectionVisible(){} // RVA: 0x7FFAC9C41D00
        public void GetLineStartPosition(){} // RVA: 0x7FFAC9C41DD0
        public void GetLineEndPosition(){} // RVA: 0x7FFAC9C41F00
        public void SetDrawRangeToContainCaretPosition(){} // RVA: 0x7FFAC9C42080
        public void ForceLabelUpdate(){} // RVA: 0x7FFAC9C42AA0
        public void MarkGeometryAsDirty(){} // RVA: 0x7FFAC9C42AB0
        public void Rebuild(){} // RVA: 0x7FFAC9C42B50
        public void LayoutComplete(){} // RVA: 0x7FFAC2F21310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFAC2F21310
        public void UpdateGeometry(){} // RVA: 0x7FFAC9C42B60
        public void AssignPositioningIfNeeded(){} // RVA: 0x7FFAC9C431D0
        public void OnFillVBO(){} // RVA: 0x7FFAC9C43CC0
        public void GenerateCaret(){} // RVA: 0x7FFAC9C43ED0
        public void CreateCursorVerts(){} // RVA: 0x7FFAC9C44CA0
        public void GenerateHighlight(){} // RVA: 0x7FFAC9C44EB0
        public void Validate(){} // RVA: 0x7FFAC9C45750
        public void ActivateInputField(){} // RVA: 0x7FFAC9C45E30
        public void ActivateInputFieldInternal(){} // RVA: 0x7FFAC9C46060
        public void OnSelect(){} // RVA: 0x7FFAC9C468A0
        public void OnPointerClick(){} // RVA: 0x7FFAC9C468F0
        public void DeactivateInputField(){} // RVA: 0x7FFAC9C46920
        public void OnDeselect(){} // RVA: 0x7FFAC9C46CC0
        public void OnSubmit(){} // RVA: 0x7FFAC9C46CF0
        public void EnforceContentType(){} // RVA: 0x7FFAC9C46D40
        public void EnforceTextHOverflow(){} // RVA: 0x7FFAC9C46EB0
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0x7FFAC9C47010
        public void SetToCustom(){} // RVA: 0x7FFAC9C47080
        public void DoStateTransition(){} // RVA: 0x7FFAC9C470A0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC2F21310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC2F21310
        public void get_minWidth(){} // RVA: 0x7FFAC9C470D0
        public void get_preferredWidth(){} // RVA: 0x7FFAC9C470E0
        public void get_flexibleWidth(){} // RVA: 0x7FFAC954F350
        public void get_minHeight(){} // RVA: 0x7FFAC37432E0
        public void get_preferredHeight(){} // RVA: 0x7FFAC9C47340
        public void get_flexibleHeight(){} // RVA: 0x7FFAC954F350
        public void get_layoutPriority(){} // RVA: 0x7FFAC3013AF0
        public void .cctor(){} // RVA: 0x7FFAC9C475E0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFAC33BCDF0
    }

    public class LayoutElement : UIBehaviour
    {
        public bool ignoreLayout; // 0x20
        public float minWidth; // 0x24
        public float minHeight; // 0x28
        public float preferredWidth; // 0x2C
        public float preferredHeight; // 0x30
        public float flexibleWidth; // 0x34
        public float flexibleHeight; // 0x38
        public int layoutPriority; // 0x3C

        // ── Methods ──
        public void get_ignoreLayout(){} // RVA: 0x7FFAC300F9D0
        public void set_ignoreLayout(){} // RVA: 0x7FFAC9C4C1D0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC2F21310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC2F21310
        public void get_minWidth(){} // RVA: 0x7FFAC308EF50
        public void set_minWidth(){} // RVA: 0x7FFAC9C4C230
        public void get_minHeight(){} // RVA: 0x7FFAC3000210
        public void set_minHeight(){} // RVA: 0x7FFAC9C4C290
        public void get_preferredWidth(){} // RVA: 0x7FFAC33EAB80
        public void set_preferredWidth(){} // RVA: 0x7FFAC9C4C2F0
        public void get_preferredHeight(){} // RVA: 0x7FFAC3C40670
        public void set_preferredHeight(){} // RVA: 0x7FFAC9C4C350
        public void get_flexibleWidth(){} // RVA: 0x7FFAC2FEB630
        public void set_flexibleWidth(){} // RVA: 0x7FFAC9C4C3B0
        public void get_flexibleHeight(){} // RVA: 0x7FFAC3716E90
        public void set_flexibleHeight(){} // RVA: 0x7FFAC9C4C410
        public void get_layoutPriority(){} // RVA: 0x7FFAC33BD4A0
        public void set_layoutPriority(){} // RVA: 0x7FFAC9C4C470
        public void .ctor(){} // RVA: 0x7FFAC9C4C4D0
        public void OnEnable(){} // RVA: 0x7FFAC9C4C550
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC9C4C550
        public void OnDisable(){} // RVA: 0x7FFAC9C4C550
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC9C4C550
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7FFAC9C4C550
        public void SetDirty(){} // RVA: 0x7FFAC9C4C560
    }

    public class LayoutGroup : UIBehaviour
    {
        public UnityEngine.RectOffset padding; // 0x20
        public 0x6B2D8C90 childAlignment; // 0x28
        public UnityEngine.RectTransform rectTransform; // 0x30
        public UnityEngine.DrivenRectTransformTracker rectChildren; // 0x38
        public UnityEngine.Vector2 minWidth; // 0x3C
        public UnityEngine.Vector2 preferredWidth; // 0x44
        public UnityEngine.Vector2 flexibleWidth; // 0x4C
        public System.Collections.Generic.List`1<UnityEngine.RectTransform> minHeight; // 0x58

        // ── Methods ──
        public void get_padding(){} // RVA: 0x7FFAC2F4F0C0
        public void set_padding(){} // RVA: 0x7FFAC9C4C640
        public void get_childAlignment(){} // RVA: 0x7FFAC32EC4C0
        public void set_childAlignment(){} // RVA: 0x7FFAC9C4C710
        public void get_rectTransform(){} // RVA: 0x7FFAC9C4C760
        public void get_rectChildren(){} // RVA: 0x7FFAC2FE9500
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC9C4C8A0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC2C70980
        public void get_minWidth(){} // RVA: 0x7FFAC971C740
        public void get_preferredWidth(){} // RVA: 0x7FFAC9987640
        public void get_flexibleWidth(){} // RVA: 0x7FFAC99FA220
        public void get_minHeight(){} // RVA: 0x7FFAC993FB30
        public void get_preferredHeight(){} // RVA: 0x7FFAC99FA210
        public void get_flexibleHeight(){} // RVA: 0x7FFAC99FA230
        public void get_layoutPriority(){} // RVA: 0x7FFAC34F9180
        public void SetLayoutHorizontal(){} // RVA: 0x7FFAC2C70980
        public void SetLayoutVertical(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC9C4CCE0
        public void OnEnable(){} // RVA: 0x7FFAC9C4D010
        public void OnDisable(){} // RVA: 0x7FFAC9C4D020
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC9C4D010
        public void GetTotalMinSize(){} // RVA: 0x7FFAC9C4D080
        public void GetTotalPreferredSize(){} // RVA: 0x7FFAC9C4D090
        public void GetTotalFlexibleSize(){} // RVA: 0x7FFAC9C4D0A0
        public void GetStartOffset(){} // RVA: 0x7FFAC9C4D0B0
        public void GetAlignmentOnAxis(){} // RVA: 0x7FFAC9C4D360
        public void SetLayoutInputForAxis(){} // RVA: 0x7FFAC9C4D3B0
        public void SetChildAlongAxis(){} // RVA: 0x7FFAC9C4D850 | overloaded x2
        public void SetChildAlongAxisWithScale(){} // RVA: 0x7FFAC9C4D970 | overloaded x2
        public void get_isRootLayoutGroup(){} // RVA: 0x7FFAC9C4DD70
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAC9C4E070
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAC9C4D010
        public void SetProperty(){} // RVA: 0x7FFAC2E8DC40
        public void SetDirty(){} // RVA: 0x7FFAC9C4E0A0
        public void DelayedSetDirty(){} // RVA: 0x7FFAC9C4E240
    }

    public class LayoutRebuilder : Object
    {
        public UnityEngine.RectTransform transform; // 0x10
        public int m_CachedHashFromTransform; // 0x18
        public UnityEngine.Pool.ObjectPool`1<UnityEngine.UI.LayoutRebuilder> s_Rebuilders;
        public string TAG_CACHED;
        public System.Collections.Generic.Dictionary`2<UnityEngine.RectTransform,System.Collections.Generic.List`1<UnityEngine.Component>> _cachedControllerComponents; // 0x8
        public System.Collections.Generic.Dictionary`2<UnityEngine.RectTransform,System.Collections.Generic.List`1<UnityEngine.Component>> _cachedElementComponents; // 0x10

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC9C4E3F0
        public void Clear(){} // RVA: 0x7FFAC9C4E470
        public void .cctor(){} // RVA: 0x7FFAC9C4E4D0
        public void ReapplyDrivenProperties(){} // RVA: 0x7FFAC9C4EA00
        public void get_transform(){} // RVA: 0x7FFAC2F3C380
        public void IsDestroyed(){} // RVA: 0x7FFAC9C4EA50
        public void StripDisabledBehavioursFromList(){} // RVA: 0x7FFAC9C4EB20
        public void ForceRebuildLayoutImmediate(){} // RVA: 0x7FFAC9C4EC90
        public void Rebuild(){} // RVA: 0x7FFAC9C4EDE0
        public void VRC_RegisterCachedLayoutTree(){} // RVA: 0x7FFAC9C4F260
        public void VRC_UnregisterCachedLayoutTree(){} // RVA: 0x7FFAC9C4F650
        public void PerformLayoutControl(){} // RVA: 0x7FFAC9C4F770
        public void PerformLayoutCalculation(){} // RVA: 0x7FFAC9C4FF30
        public void MarkLayoutForRebuild(){} // RVA: 0x7FFAC9C50530
        public void ValidController(){} // RVA: 0x7FFAC9C50CB0
        public void MarkLayoutRootForRebuild(){} // RVA: 0x7FFAC9C51060
        public void LayoutComplete(){} // RVA: 0x7FFAC9C512E0
        public void GraphicUpdateComplete(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC3157800
        public void Equals(){} // RVA: 0x7FFAC9C51370
        public void ToString(){} // RVA: 0x7FFAC9C513D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LayoutUtility : Object
    {
        // ── Methods ──
        public void GetMinSize(){} // RVA: 0x7FFAC9C51830
        public void GetPreferredSize(){} // RVA: 0x7FFAC9C51850
        public void GetFlexibleSize(){} // RVA: 0x7FFAC9C51870
        public void GetMinWidth(){} // RVA: 0x7FFAC9C51890
        public void GetPreferredWidth(){} // RVA: 0x7FFAC9C519F0
        public void GetFlexibleWidth(){} // RVA: 0x7FFAC9C51CA0
        public void GetMinHeight(){} // RVA: 0x7FFAC9C51E00
        public void GetPreferredHeight(){} // RVA: 0x7FFAC9C51F60
        public void GetFlexibleHeight(){} // RVA: 0x7FFAC9C52210
        public void GetLayoutProperty(){} // RVA: 0x7FFAC9C52390 | overloaded x2
    }

    public class Mask : UIBehaviour
    {
        public UnityEngine.RectTransform rectTransform; // 0x20
        public bool showMaskGraphic; // 0x28
        public UnityEngine.UI.Graphic graphic; // 0x30
        public UnityEngine.Material m_MaskMaterial; // 0x38
        public UnityEngine.Material m_UnmaskMaterial; // 0x40

        // ── Methods ──
        public void get_rectTransform(){} // RVA: 0x7FFAC9C52AF0
        public void get_showMaskGraphic(){} // RVA: 0x7FFAC30F6BA0
        public void set_showMaskGraphic(){} // RVA: 0x7FFAC9C52B90
        public void get_graphic(){} // RVA: 0x7FFAC9C52CA0
        public void .ctor(){} // RVA: 0x7FFAC2F58BB0
        public void MaskEnabled(){} // RVA: 0x7FFAC9C52D40
        public void OnSiblingGraphicEnabledDisabled(){} // RVA: 0x7FFAC2F21310
        public void OnEnable(){} // RVA: 0x7FFAC9C52E40
        public void OnDisable(){} // RVA: 0x7FFAC9C53080
        public void IsRaycastLocationValid(){} // RVA: 0x7FFAC9C53440
        public void GetModifiedMaterial(){} // RVA: 0x7FFAC9C53520
    }

    public class MaskUtilities : Object
    {
        // ── Methods ──
        public void Notify2DMaskStateChanged(){} // RVA: 0x7FFAC9C54F10
        public void NotifyStencilStateChanged(){} // RVA: 0x7FFAC9C55290
        public void FindRootSortOverrideCanvas(){} // RVA: 0x7FFAC9C55610
        public void GetStencilDepth(){} // RVA: 0x7FFAC9C558B0
        public void IsDescendantOrSelf(){} // RVA: 0x7FFAC9C55D80
        public void GetRectMaskForClippable(){} // RVA: 0x7FFAC9C56170
        public void GetRectMasksForClip(){} // RVA: 0x7FFAC9C565E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MaskableGraphic : Graphic
    {
        public bool onCullStateChanged; // 0xA8
        public UnityEngine.Material maskable; // 0xB0
        public UnityEngine.UI.RectMask2D isMaskingGraphic; // 0xB8
        public bool rootCanvasRect; // 0xC0
        public bool m_IsMaskingGraphic; // 0xC1
        public bool m_IncludeForMasking; // 0xC2
        public CullStateChangedEvent m_OnCullStateChanged; // 0xC8
        public bool m_ShouldRecalculate; // 0xD0
        public int m_StencilValue; // 0xD4
        public UnityEngine.Vector3[] m_Corners; // 0xD8

        // ── Methods ──
        public void get_onCullStateChanged(){} // RVA: 0x7FFAC3079460
        public void set_onCullStateChanged(){} // RVA: 0x7FFAC3079470
        public void get_maskable(){} // RVA: 0x7FFAC2F424C0
        public void set_maskable(){} // RVA: 0x7FFAC9C538F0
        public void get_isMaskingGraphic(){} // RVA: 0x7FFAC906B7A0
        public void set_isMaskingGraphic(){} // RVA: 0x7FFAC9C53920
        public void GetModifiedMaterial(){} // RVA: 0x7FFAC9C53930
        public void Cull(){} // RVA: 0x7FFAC9C53B40
        public void UpdateCull(){} // RVA: 0x7FFAC9C53BA0
        public void SetClipRect(){} // RVA: 0x7FFAC9C53D40
        public void SetClipSoftness(){} // RVA: 0x7FFAC9C53E30
        public void OnEnable(){} // RVA: 0x7FFAC9C53EB0
        public void OnDisable(){} // RVA: 0x7FFAC9C53F10
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC9C54010
        public void ParentMaskStateChanged(){} // RVA: 0x7FFAC2F21310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFAC9C54180
        public void get_rootCanvasRect(){} // RVA: 0x7FFAC9C54210
        public void UpdateClipParent(){} // RVA: 0x7FFAC9C54770
        public void RecalculateClipping(){} // RVA: 0x7FFAC972B150
        public void RecalculateMasking(){} // RVA: 0x7FFAC9C54AC0
        public void .ctor(){} // RVA: 0x7FFAC9C54BA0
        public void UnityEngine.UI.IClippable.get_gameObject(){} // RVA: 0x7FFAC33BD180
    }

    public class Misc : Object
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0x7FFAC9C569D0
        public void DestroyImmediate(){} // RVA: 0x7FFAC9C56BA0
    }

    public class MultipleDisplayUtilities : Object
    {
        // ── Methods ──
        public void GetRelativeMousePositionForDrag(){} // RVA: 0x7FFAC9C56CB0
        public void GetRelativeMousePositionForRaycast(){} // RVA: 0x7FFAC9C56D90
        public void RelativeMouseAtScaled(){} // RVA: 0x7FFAC9C56EC0
    }

    public class Navigation : ValueType
    {
        public 0x6B24A9A0 mode; // 0x10
        public bool wrapAround; // 0x14
        public UnityEngine.UI.Selectable selectOnUp; // 0x18
        public UnityEngine.UI.Selectable selectOnDown; // 0x20
        public UnityEngine.UI.Selectable selectOnLeft; // 0x28
        public UnityEngine.UI.Selectable selectOnRight; // 0x30

        // ── Methods ──
        public void get_mode(){} // RVA: 0x7FFAC4420210
        public void set_mode(){} // RVA: 0x7FFAC336D8B0
        public void get_wrapAround(){} // RVA: 0x7FFAC4A0B160
        public void set_wrapAround(){} // RVA: 0x7FFAC3B9B960
        public void get_selectOnUp(){} // RVA: 0x7FFAC4420220
        public void set_selectOnUp(){} // RVA: 0x7FFAC4420240
        public void get_selectOnDown(){} // RVA: 0x7FFAC2F3C380
        public void set_selectOnDown(){} // RVA: 0x7FFAC2F22E30
        public void get_selectOnLeft(){} // RVA: 0x7FFAC2F247C0
        public void set_selectOnLeft(){} // RVA: 0x7FFAC2F87E80
        public void get_selectOnRight(){} // RVA: 0x7FFAC2F4F0C0
        public void set_selectOnRight(){} // RVA: 0x7FFAC2F4F0D0
        public void get_defaultNavigation(){} // RVA: 0x7FFAC9C577F0
        public void Equals(){} // RVA: 0x7FFAC9C57810
    }

    public class Outline : Shadow
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C754A0
        public void ModifyMesh(){} // RVA: 0x7FFAC9C75510
    }

    public class PositionAsUV1 : BaseMeshEffect
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void ModifyMesh(){} // RVA: 0x7FFAC9C75840
    }

    public class RawImage : MaskableGraphic
    {
        public UnityEngine.Texture mainTexture; // 0xE0
        public UnityEngine.Rect texture; // 0xE8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C57BF0
        public void get_mainTexture(){} // RVA: 0x7FFAC9C57C20
        public void get_texture(){} // RVA: 0x7FFAC2FA2900
        public void set_texture(){} // RVA: 0x7FFAC9C57EE0
        public void get_uvRect(){} // RVA: 0x7FFAC8A33EE0
        public void set_uvRect(){} // RVA: 0x7FFAC9C58090
        public void SetNativeSize(){} // RVA: 0x7FFAC9C58100
        public void OnPopulateMesh(){} // RVA: 0x7FFAC9C58350
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC9A76050
    }

    public class RectMask2D : UIBehaviour
    {
        public UnityEngine.UI.RectangularVertexClipper padding; // 0x20
        public UnityEngine.RectTransform softness; // 0x28
        public System.Collections.Generic.HashSet`1<UnityEngine.UI.MaskableGraphic> Canvas; // 0x30
        public System.Collections.Generic.HashSet`1<UnityEngine.UI.IClippable> canvasRect; // 0x38
        public bool rectTransform; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D> rootCanvasRect; // 0x48
        public UnityEngine.Rect m_LastClipRectCanvasSpace; // 0x50
        public bool m_ForceClip; // 0x60
        public UnityEngine.Vector4 m_Padding; // 0x64
        public UnityEngine.Vector2Int m_Softness; // 0x74
        public UnityEngine.Canvas m_Canvas; // 0x80
        public UnityEngine.Vector3[] m_Corners; // 0x88

        // ── Methods ──
        public void get_padding(){} // RVA: 0x7FFAC3031E00
        public void set_padding(){} // RVA: 0x7FFAC9C587E0
        public void get_softness(){} // RVA: 0x7FFAC8B59CC0
        public void set_softness(){} // RVA: 0x7FFAC9C587F0
        public void get_Canvas(){} // RVA: 0x7FFAC9C58820
        public void get_canvasRect(){} // RVA: 0x7FFAC9C58B20
        public void get_rectTransform(){} // RVA: 0x7FFAC9C58BA0
        public void .ctor(){} // RVA: 0x7FFAC9C58C40
        public void OnEnable(){} // RVA: 0x7FFAC9C59040
        public void OnDisable(){} // RVA: 0x7FFAC9C590B0
        public void OnDestroy(){} // RVA: 0x7FFAC9A557C0
        public void IsRaycastLocationValid(){} // RVA: 0x7FFAC9C59240
        public void get_rootCanvasRect(){} // RVA: 0x7FFAC9C59350
        public void PerformClipping(){} // RVA: 0x7FFAC9C595E0
        public void UpdateClipSoftness(){} // RVA: 0x7FFAC9C5A170
        public void AddClippable(){} // RVA: 0x7FFAC9C5A530
        public void RemoveClippable(){} // RVA: 0x7FFAC9C5A6E0
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC9C5A890
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFAC9C5A890
    }

    public class RectangularVertexClipper : Object
    {
        public UnityEngine.Vector3[] m_WorldCorners; // 0x10
        public UnityEngine.Vector3[] m_CanvasCorners; // 0x18

        // ── Methods ──
        public void GetCanvasRect(){} // RVA: 0x7FFAC9A55C10
        public void .ctor(){} // RVA: 0x7FFAC9A55EB0
    }

    public class ReflectionMethodsCache : Object
    {
        public Raycast3DCallback Singleton; // 0x10
        public RaycastAllCallback raycast3DAll; // 0x18
        public GetRaycastNonAllocCallback getRaycastNonAlloc; // 0x20
        public Raycast2DCallback raycast2D; // 0x28
        public GetRayIntersectionAllCallback getRayIntersectionAll; // 0x30
        public GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; // 0x38
        public UnityEngine.UI.ReflectionMethodsCache s_ReflectionMethodsCache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C70070
        public void get_Singleton(){} // RVA: 0x7FFAC9C719E0
    }

    public class ScrollRect : UIBehaviour
    {
        public UnityEngine.RectTransform content; // 0x20
        public bool horizontal; // 0x28
        public bool vertical; // 0x29
        public 0x6B24ACB8 movementType; // 0x2C
        public float elasticity; // 0x30
        public bool inertia; // 0x34
        public float decelerationRate; // 0x38
        public float scrollSensitivity; // 0x3C
        public UnityEngine.RectTransform viewport; // 0x40
        public UnityEngine.UI.Scrollbar horizontalScrollbar; // 0x48
        public UnityEngine.UI.Scrollbar verticalScrollbar; // 0x50
        public 0x6B24AD10 horizontalScrollbarVisibility; // 0x58
        public 0x6B24AD10 verticalScrollbarVisibility; // 0x5C
        public float horizontalScrollbarSpacing; // 0x60
        public float verticalScrollbarSpacing; // 0x64
        public ScrollRectEvent onValueChanged; // 0x68
        public UnityEngine.Vector2 viewRect; // 0x70
        public UnityEngine.Vector2 velocity; // 0x78
        public UnityEngine.RectTransform rectTransform; // 0x80
        public UnityEngine.Bounds normalizedPosition; // 0x88
        public UnityEngine.Bounds horizontalNormalizedPosition; // 0xA0
        public UnityEngine.Vector2 verticalNormalizedPosition; // 0xB8
        public bool hScrollingNeeded; // 0xC0
        public bool vScrollingNeeded; // 0xC1
        public UnityEngine.Vector2 minWidth; // 0xC4
        public UnityEngine.Bounds preferredWidth; // 0xCC
        public UnityEngine.Bounds flexibleWidth; // 0xE4
        public bool minHeight; // 0xFC
        public bool preferredHeight; // 0xFD
        public bool flexibleHeight; // 0xFE
        public float layoutPriority; // 0x100
        public float m_VSliderWidth; // 0x104
        public UnityEngine.RectTransform m_Rect; // 0x108
        public UnityEngine.RectTransform m_HorizontalScrollbarRect; // 0x110
        public UnityEngine.RectTransform m_VerticalScrollbarRect; // 0x118
        public UnityEngine.DrivenRectTransformTracker m_Tracker; // 0x120
        public UnityEngine.Vector3[] m_Corners; // 0x128

        // ── Methods ──
        public void get_content(){} // RVA: 0x7FFAC2F4F0C0
        public void set_content(){} // RVA: 0x7FFAC2F4F0D0
        public void get_horizontal(){} // RVA: 0x7FFAC30F6BA0
        public void set_horizontal(){} // RVA: 0x7FFAC3C24F40
        public void get_vertical(){} // RVA: 0x7FFAC386C550
        public void set_vertical(){} // RVA: 0x7FFAC43B4D70
        public void get_movementType(){} // RVA: 0x7FFAC3C891D0
        public void set_movementType(){} // RVA: 0x7FFAC45B6490
        public void get_elasticity(){} // RVA: 0x7FFAC3C40670
        public void set_elasticity(){} // RVA: 0x7FFAC47394E0
        public void get_inertia(){} // RVA: 0x7FFAC2F57C20
        public void set_inertia(){} // RVA: 0x7FFAC2F5BAC0
        public void get_decelerationRate(){} // RVA: 0x7FFAC3716E90
        public void set_decelerationRate(){} // RVA: 0x7FFAC3717190
        public void get_scrollSensitivity(){} // RVA: 0x7FFAC363CE20
        public void set_scrollSensitivity(){} // RVA: 0x7FFAC363C6C0
        public void get_viewport(){} // RVA: 0x7FFAC2F9E740
        public void set_viewport(){} // RVA: 0x7FFAC9C5D010
        public void get_horizontalScrollbar(){} // RVA: 0x7FFAC2F9C730
        public void set_horizontalScrollbar(){} // RVA: 0x7FFAC9C5D070
        public void get_verticalScrollbar(){} // RVA: 0x7FFAC2FC20E0
        public void set_verticalScrollbar(){} // RVA: 0x7FFAC9C5D360
        public void get_horizontalScrollbarVisibility(){} // RVA: 0x7FFAC362EA40
        public void set_horizontalScrollbarVisibility(){} // RVA: 0x7FFAC9C5D650
        public void get_verticalScrollbarVisibility(){} // RVA: 0x7FFAC313CBA0
        public void set_verticalScrollbarVisibility(){} // RVA: 0x7FFAC9C5D660
        public void get_horizontalScrollbarSpacing(){} // RVA: 0x7FFAC3031E10
        public void set_horizontalScrollbarSpacing(){} // RVA: 0x7FFAC9C5D670
        public void get_verticalScrollbarSpacing(){} // RVA: 0x7FFAC2F4A040
        public void set_verticalScrollbarSpacing(){} // RVA: 0x7FFAC9C5D680
        public void get_onValueChanged(){} // RVA: 0x7FFAC2F9CD50
        public void set_onValueChanged(){} // RVA: 0x7FFAC2F9CD60
        public void get_viewRect(){} // RVA: 0x7FFAC9C5D690
        public void get_velocity(){} // RVA: 0x7FFAC9C5D970
        public void set_velocity(){} // RVA: 0x7FFAC45C9F90
        public void get_rectTransform(){} // RVA: 0x7FFAC9C5D990
        public void .ctor(){} // RVA: 0x7FFAC9C5DAE0
        public void Rebuild(){} // RVA: 0x7FFAC9C5DD30
        public void LayoutComplete(){} // RVA: 0x7FFAC2F21310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFAC2F21310
        public void UpdateCachedData(){} // RVA: 0x7FFAC9C5DDC0
        public void OnEnable(){} // RVA: 0x7FFAC9C5E990
        public void OnDisable(){} // RVA: 0x7FFAC9C5EC80
        public void IsActive(){} // RVA: 0x7FFAC9C5F000
        public void EnsureLayoutHasRebuilt(){} // RVA: 0x7FFAC9C5F120
        public void StopMovement(){} // RVA: 0x7FFAC9C5F1D0
        public void OnScroll(){} // RVA: 0x7FFAC9C5F230
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFAC9C5F440
        public void OnBeginDrag(){} // RVA: 0x7FFAC9C5F4B0
        public void OnEndDrag(){} // RVA: 0x7FFAC9C5F610
        public void OnDrag(){} // RVA: 0x7FFAC9C5F640
        public void SetContentAnchoredPosition(){} // RVA: 0x7FFAC9C5F8A0
        public void LateUpdate(){} // RVA: 0x7FFAC9C5FA50
        public void UpdatePrevData(){} // RVA: 0x7FFAC9C605D0
        public void UpdateScrollbars(){} // RVA: 0x7FFAC9C60760
        public void get_normalizedPosition(){} // RVA: 0x7FFAC9C60A40
        public void set_normalizedPosition(){} // RVA: 0x7FFAC9C60A80
        public void get_horizontalNormalizedPosition(){} // RVA: 0x7FFAC9C60AE0
        public void set_horizontalNormalizedPosition(){} // RVA: 0x7FFAC9C60BF0
        public void get_verticalNormalizedPosition(){} // RVA: 0x7FFAC9C60C10
        public void set_verticalNormalizedPosition(){} // RVA: 0x7FFAC9C60D30
        public void SetHorizontalNormalizedPosition(){} // RVA: 0x7FFAC9C60BF0
        public void SetVerticalNormalizedPosition(){} // RVA: 0x7FFAC9C60D30
        public void SetNormalizedPosition(){} // RVA: 0x7FFAC9C60D50
        public void RubberDelta(){} // RVA: 0x7FFAC9C612D0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAC9C61330
        public void get_hScrollingNeeded(){} // RVA: 0x7FFAC9C61340
        public void get_vScrollingNeeded(){} // RVA: 0x7FFAC9C61400
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC2F21310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC2F21310
        public void get_minWidth(){} // RVA: 0x7FFAC954F350
        public void get_preferredWidth(){} // RVA: 0x7FFAC954F350
        public void get_flexibleWidth(){} // RVA: 0x7FFAC954F350
        public void get_minHeight(){} // RVA: 0x7FFAC954F350
        public void get_preferredHeight(){} // RVA: 0x7FFAC954F350
        public void get_flexibleHeight(){} // RVA: 0x7FFAC954F350
        public void get_layoutPriority(){} // RVA: 0x7FFAC32BD0E0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFAC9C614C0
        public void SetLayoutVertical(){} // RVA: 0x7FFAC9C61E50
        public void UpdateScrollbarVisibility(){} // RVA: 0x7FFAC9C62020
        public void UpdateOneScrollbarVisibility(){} // RVA: 0x7FFAC9C62080
        public void UpdateScrollbarLayout(){} // RVA: 0x7FFAC9C622E0
        public void UpdateBounds(){} // RVA: 0x7FFAC9C62760
        public void AdjustBounds(){} // RVA: 0x7FFAC9C62E90
        public void GetBounds(){} // RVA: 0x7FFAC9C62F40
        public void InternalGetBounds(){} // RVA: 0x7FFAC9C63140
        public void CalculateOffset(){} // RVA: 0x7FFAC9C633E0
        public void InternalCalculateOffset(){} // RVA: 0x7FFAC9C63430
        public void SetDirty(){} // RVA: 0x7FFAC9C635F0
        public void SetDirtyCaching(){} // RVA: 0x7FFAC9C63670
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFAC33BCDF0
    }

    public class Scrollbar : Selectable
    {
        public UnityEngine.RectTransform handleRect; // 0x100
        public 0x6B24AB00 direction; // 0x108
        public float value; // 0x10C
        public float size; // 0x110
        public int numberOfSteps; // 0x114
        public ScrollEvent onValueChanged; // 0x118
        public UnityEngine.RectTransform stepSize; // 0x120
        public UnityEngine.Vector2 axis; // 0x128
        public UnityEngine.DrivenRectTransformTracker reverseValue; // 0x130
        public UnityEngine.Coroutine m_PointerDownRepeat; // 0x138
        public bool isPointerDownAndNotDragging; // 0x140
        public bool m_DelayedUpdateVisuals; // 0x141

        // ── Methods ──
        public void get_handleRect(){} // RVA: 0x7FFAC34F6C80
        public void set_handleRect(){} // RVA: 0x7FFAC9C5A900
        public void get_direction(){} // RVA: 0x7FFAC4599E70
        public void set_direction(){} // RVA: 0x7FFAC9C5A970
        public void .ctor(){} // RVA: 0x7FFAC9C5A9D0
        public void get_value(){} // RVA: 0x7FFAC9C5AB00
        public void set_value(){} // RVA: 0x7FFAC9C5AB60
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9C5AB70
        public void get_size(){} // RVA: 0x7FFAC9A6EAA0
        public void set_size(){} // RVA: 0x7FFAC9C5AB80
        public void get_numberOfSteps(){} // RVA: 0x7FFAC9745510
        public void set_numberOfSteps(){} // RVA: 0x7FFAC9C5AC00
        public void get_onValueChanged(){} // RVA: 0x7FFAC33BC6D0
        public void set_onValueChanged(){} // RVA: 0x7FFAC33B8580
        public void get_stepSize(){} // RVA: 0x7FFAC9C5AC70
        public void Rebuild(){} // RVA: 0x7FFAC2F21310
        public void LayoutComplete(){} // RVA: 0x7FFAC2F21310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFAC2F21310
        public void OnEnable(){} // RVA: 0x7FFAC9C5ACA0
        public void OnDisable(){} // RVA: 0x7FFAC9C5ACE0
        public void Update(){} // RVA: 0x7FFAC9C5ACF0
        public void UpdateCachedReferences(){} // RVA: 0x7FFAC9C5AD10
        public void Set(){} // RVA: 0x7FFAC9C5B030
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAC9C5B170
        public void get_axis(){} // RVA: 0x7FFAC9C5B1B0
        public void get_reverseValue(){} // RVA: 0x7FFAC9C5B1D0
        public void UpdateVisuals(){} // RVA: 0x7FFAC9C5B1F0
        public void UpdateDrag(){} // RVA: 0x7FFAC9C5B530
        public void DoUpdateDrag(){} // RVA: 0x7FFAC9C5B9E0
        public void MayDrag(){} // RVA: 0x7FFAC9C5BAA0
        public void OnBeginDrag(){} // RVA: 0x7FFAC9C5BB10
        public void OnDrag(){} // RVA: 0x7FFAC9C5BE50
        public void OnPointerDown(){} // RVA: 0x7FFAC9C5BF90
        public void ClickRepeat(){} // RVA: 0x7FFAC9C5C140 | overloaded x2
        public void OnPointerUp(){} // RVA: 0x7FFAC9C5C270
        public void OnMove(){} // RVA: 0x7FFAC9C5C2B0
        public void FindSelectableOnLeft(){} // RVA: 0x7FFAC9C5C960
        public void FindSelectableOnRight(){} // RVA: 0x7FFAC9C5C990
        public void FindSelectableOnUp(){} // RVA: 0x7FFAC9C5C9C0
        public void FindSelectableOnDown(){} // RVA: 0x7FFAC9C5C9F0
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFAC371D9D0
        public void SetDirection(){} // RVA: 0x7FFAC9C5CA20
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFAC33BCDF0
    }

    public class Selectable : UIBehaviour
    {
        public UnityEngine.UI.Selectable[] allSelectablesArray;
        public int allSelectableCount; // 0x8
        public bool allSelectables; // 0x20
        public UnityEngine.UI.Navigation navigation; // 0x28
        public 0x6B24AE18 transition; // 0x50
        public UnityEngine.UI.ColorBlock colors; // 0x54
        public UnityEngine.UI.SpriteState spriteState; // 0xB0
        public UnityEngine.UI.AnimationTriggers animationTriggers; // 0xD0
        public bool targetGraphic; // 0xD8
        public UnityEngine.UI.Graphic interactable; // 0xE0
        public bool isPointerInside; // 0xE8
        public int isPointerDown; // 0xEC
        public bool hasSelection; // 0xF0
        public bool image; // 0xF1
        public bool animator; // 0xF2
        public System.Collections.Generic.List`1<UnityEngine.CanvasGroup> currentSelectionState; // 0xF8

        // ── Methods ──
        public void get_allSelectablesArray(){} // RVA: 0x7FFAC9C63810
        public void get_allSelectableCount(){} // RVA: 0x7FFAC9C639C0
        public void get_allSelectables(){} // RVA: 0x7FFAC9C63A20
        public void AllSelectablesNoAlloc(){} // RVA: 0x7FFAC9C63AC0
        public void get_navigation(){} // RVA: 0x7FFAC9C63C50
        public void set_navigation(){} // RVA: 0x7FFAC9C63C70
        public void get_transition(){} // RVA: 0x7FFAC30F10E0
        public void set_transition(){} // RVA: 0x7FFAC9C63DC0
        public void get_colors(){} // RVA: 0x7FFAC9C63E20
        public void set_colors(){} // RVA: 0x7FFAC9C63E60
        public void get_spriteState(){} // RVA: 0x7FFAC9C63FE0
        public void set_spriteState(){} // RVA: 0x7FFAC9C64000
        public void get_animationTriggers(){} // RVA: 0x7FFAC303E100
        public void set_animationTriggers(){} // RVA: 0x7FFAC9C64130
        public void get_targetGraphic(){} // RVA: 0x7FFAC2FA2900
        public void set_targetGraphic(){} // RVA: 0x7FFAC9C64190
        public void get_interactable(){} // RVA: 0x7FFAC3DBD9E0
        public void set_interactable(){} // RVA: 0x7FFAC9C641F0
        public void get_isPointerInside(){} // RVA: 0x7FFAC2FA2AD0
        public void set_isPointerInside(){} // RVA: 0x7FFAC2FA2AE0
        public void get_isPointerDown(){} // RVA: 0x7FFAC3E66790
        public void set_isPointerDown(){} // RVA: 0x7FFAC3E62B70
        public void get_hasSelection(){} // RVA: 0x7FFAC3E634D0
        public void set_hasSelection(){} // RVA: 0x7FFAC3E62830
        public void .ctor(){} // RVA: 0x7FFAC9C64480
        public void get_image(){} // RVA: 0x7FFAC9C64710
        public void set_image(){} // RVA: 0x7FFAC2FA2910
        public void get_animator(){} // RVA: 0x7FFAC9C647A0
        public void Awake(){} // RVA: 0x7FFAC9C647E0
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFAC9C64920
        public void ParentGroupAllowsInteraction(){} // RVA: 0x7FFAC9C64960
        public void IsInteractable(){} // RVA: 0x7FFAC9C64BA0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC9C64BC0
        public void OnEnable(){} // RVA: 0x7FFAC9C64BD0
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC8AEC8C0
        public void OnSetProperty(){} // RVA: 0x7FFAC9C65100
        public void OnDisable(){} // RVA: 0x7FFAC9C65180
        public void OnApplicationFocus(){} // RVA: 0x7FFAC9C65300
        public void get_currentSelectionState(){} // RVA: 0x7FFAC9C65370
        public void InstantClearState(){} // RVA: 0x7FFAC9C653E0
        public void DoStateTransition(){} // RVA: 0x7FFAC9C65470
        public void FindSelectable(){} // RVA: 0x7FFAC9C65790
        public void GetPointOnRectEdge(){} // RVA: 0x7FFAC9C66150
        public void Navigate(){} // RVA: 0x7FFAC9C66460
        public void FindSelectableOnLeft(){} // RVA: 0x7FFAC9C665B0
        public void FindSelectableOnRight(){} // RVA: 0x7FFAC9C66720
        public void FindSelectableOnUp(){} // RVA: 0x7FFAC9C66890
        public void FindSelectableOnDown(){} // RVA: 0x7FFAC9C66A00
        public void OnMove(){} // RVA: 0x7FFAC9C66B70
        public void StartColorTween(){} // RVA: 0x7FFAC9C66C20
        public void DoSpriteSwap(){} // RVA: 0x7FFAC9C66D90
        public void TriggerAnimation(){} // RVA: 0x7FFAC9C66EA0
        public void IsHighlighted(){} // RVA: 0x7FFAC9C671B0
        public void IsPressed(){} // RVA: 0x7FFAC9C67220
        public void EvaluateAndTransitionToSelectionState(){} // RVA: 0x7FFAC9C67270
        public void OnPointerDown(){} // RVA: 0x7FFAC9C672E0
        public void OnPointerUp(){} // RVA: 0x7FFAC9C67480
        public void OnPointerEnter(){} // RVA: 0x7FFAC9C674B0
        public void OnPointerExit(){} // RVA: 0x7FFAC9C674C0
        public void OnSelect(){} // RVA: 0x7FFAC9C674D0
        public void OnDeselect(){} // RVA: 0x7FFAC9C674E0
        public void Select(){} // RVA: 0x7FFAC9C674F0
        public void .cctor(){} // RVA: 0x7FFAC9C67690
    }

    public class SetPropertyUtility : Object
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x7FFAC9787770
        public void SetStruct(){} // RVA: 0x7FFAC2E8DC40
        public void SetClass(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Shadow : BaseMeshEffect
    {
        public UnityEngine.Color effectColor; // 0x28
        public UnityEngine.Vector2 effectDistance; // 0x38
        public bool useGraphicAlpha; // 0x40
        public float kMaxEffectDistance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C754A0
        public void get_effectColor(){} // RVA: 0x7FFAC3BCF020
        public void set_effectColor(){} // RVA: 0x7FFAC9C75990
        public void get_effectDistance(){} // RVA: 0x7FFAC3FA0C70
        public void set_effectDistance(){} // RVA: 0x7FFAC9C75AA0
        public void get_useGraphicAlpha(){} // RVA: 0x7FFAC2FDCC00
        public void set_useGraphicAlpha(){} // RVA: 0x7FFAC9C75C60
        public void ApplyShadowZeroAlloc(){} // RVA: 0x7FFAC9C75D70
        public void ApplyShadow(){} // RVA: 0x7FFAC9C76180
        public void ModifyMesh(){} // RVA: 0x7FFAC9C76190
    }

    public class Slider : Selectable
    {
        public UnityEngine.RectTransform fillRect; // 0x100
        public UnityEngine.RectTransform handleRect; // 0x108
        public 0x6B24AF78 direction; // 0x110
        public float minValue; // 0x114
        public float maxValue; // 0x118
        public bool wholeNumbers; // 0x11C
        public float value; // 0x120
        public SliderEvent normalizedValue; // 0x128
        public UnityEngine.UI.Image onValueChanged; // 0x130
        public UnityEngine.Transform stepSize; // 0x138
        public UnityEngine.RectTransform axis; // 0x140
        public UnityEngine.Transform reverseValue; // 0x148
        public UnityEngine.RectTransform m_HandleContainerRect; // 0x150
        public UnityEngine.Vector2 m_Offset; // 0x158
        public UnityEngine.DrivenRectTransformTracker m_Tracker; // 0x160
        public bool m_DelayedUpdateVisuals; // 0x161

        // ── Methods ──
        public void get_fillRect(){} // RVA: 0x7FFAC34F6C80
        public void set_fillRect(){} // RVA: 0x7FFAC9C67760
        public void get_handleRect(){} // RVA: 0x7FFAC36D1F40
        public void set_handleRect(){} // RVA: 0x7FFAC9C677D0
        public void get_direction(){} // RVA: 0x7FFAC39471E0
        public void set_direction(){} // RVA: 0x7FFAC9C67840
        public void get_minValue(){} // RVA: 0x7FFAC9719E50
        public void set_minValue(){} // RVA: 0x7FFAC9C678A0
        public void get_maxValue(){} // RVA: 0x7FFAC8C06760
        public void set_maxValue(){} // RVA: 0x7FFAC9C67920
        public void get_wholeNumbers(){} // RVA: 0x7FFAC9C679A0
        public void set_wholeNumbers(){} // RVA: 0x7FFAC9C679B0
        public void get_value(){} // RVA: 0x7FFAC9C67A30
        public void set_value(){} // RVA: 0x7FFAC9C67A50
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9C67A70
        public void get_normalizedValue(){} // RVA: 0x7FFAC9C67A90
        public void set_normalizedValue(){} // RVA: 0x7FFAC9C67B40
        public void get_onValueChanged(){} // RVA: 0x7FFAC35466F0
        public void set_onValueChanged(){} // RVA: 0x7FFAC39C51C0
        public void get_stepSize(){} // RVA: 0x7FFAC9C67B90
        public void .ctor(){} // RVA: 0x7FFAC9C67BC0
        public void Rebuild(){} // RVA: 0x7FFAC2F21310
        public void LayoutComplete(){} // RVA: 0x7FFAC2F21310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFAC2F21310
        public void OnEnable(){} // RVA: 0x7FFAC9C67CF0
        public void OnDisable(){} // RVA: 0x7FFAC9C5ACE0
        public void Update(){} // RVA: 0x7FFAC9C67D40
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC9C67D90
        public void UpdateCachedReferences(){} // RVA: 0x7FFAC9C681B0
        public void ClampValue(){} // RVA: 0x7FFAC9C68C00
        public void Set(){} // RVA: 0x7FFAC9C68C30
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAC9C68D20
        public void get_axis(){} // RVA: 0x7FFAC9C68D60
        public void get_reverseValue(){} // RVA: 0x7FFAC9C68D80
        public void UpdateVisuals(){} // RVA: 0x7FFAC9C68DA0
        public void UpdateDrag(){} // RVA: 0x7FFAC9C693C0
        public void MayDrag(){} // RVA: 0x7FFAC9C5BAA0
        public void OnPointerDown(){} // RVA: 0x7FFAC9C69720
        public void OnDrag(){} // RVA: 0x7FFAC9C69A00
        public void OnMove(){} // RVA: 0x7FFAC9C69A80
        public void FindSelectableOnLeft(){} // RVA: 0x7FFAC9C6A080
        public void FindSelectableOnRight(){} // RVA: 0x7FFAC9C6A0B0
        public void FindSelectableOnUp(){} // RVA: 0x7FFAC9C6A0E0
        public void FindSelectableOnDown(){} // RVA: 0x7FFAC9C6A110
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFAC371D9D0
        public void SetDirection(){} // RVA: 0x7FFAC9C6A140
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFAC33BCDF0
    }

    public class SpriteState : ValueType
    {
        public UnityEngine.Sprite highlightedSprite; // 0x10
        public UnityEngine.Sprite pressedSprite; // 0x18
        public UnityEngine.Sprite selectedSprite; // 0x20
        public UnityEngine.Sprite disabledSprite; // 0x28

        // ── Methods ──
        public void get_highlightedSprite(){} // RVA: 0x7FFAC3AD9F60
        public void set_highlightedSprite(){} // RVA: 0x7FFAC38DFE40
        public void get_pressedSprite(){} // RVA: 0x7FFAC4420220
        public void set_pressedSprite(){} // RVA: 0x7FFAC4420240
        public void get_selectedSprite(){} // RVA: 0x7FFAC2F3C380
        public void set_selectedSprite(){} // RVA: 0x7FFAC2F22E30
        public void get_disabledSprite(){} // RVA: 0x7FFAC2F247C0
        public void set_disabledSprite(){} // RVA: 0x7FFAC2F87E80
        public void Equals(){} // RVA: 0x7FFAC9C6A430
    }

    public class StencilMaterial : Object
    {
        public System.Collections.Generic.List`1<MatEntry> m_List;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC9C6A970 | overloaded x3
        public void LogWarningWhenNotInBatchmode(){} // RVA: 0x7FFAC9C6A8A0
        public void Remove(){} // RVA: 0x7FFAC9C6B550
        public void ClearAll(){} // RVA: 0x7FFAC9C6B850
        public void .cctor(){} // RVA: 0x7FFAC9C6BA50
    }

    public class Text : MaskableGraphic
    {
        public UnityEngine.UI.FontData cachedTextGenerator; // 0xE0
        public string cachedTextGeneratorForLayout; // 0xE8
        public UnityEngine.TextGenerator mainTexture; // 0xF0
        public UnityEngine.TextGenerator font; // 0xF8
        public UnityEngine.Material text;
        public bool supportRichText; // 0x100
        public int resizeTextForBestFit;
        public UnityEngine.UIVertex[] resizeTextMinSize; // 0x108

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C6BB40
        public void get_cachedTextGenerator(){} // RVA: 0x7FFAC9C6BCE0
        public void get_cachedTextGeneratorForLayout(){} // RVA: 0x7FFAC9C6BDE0
        public void get_mainTexture(){} // RVA: 0x7FFAC9C6BEA0
        public void FontTextureChanged(){} // RVA: 0x7FFAC9C6C2C0
        public void get_font(){} // RVA: 0x7FFAC9C6C460
        public void set_font(){} // RVA: 0x7FFAC9C6C480
        public void get_text(){} // RVA: 0x7FFAC2FA2970
        public void set_text(){} // RVA: 0x7FFAC9C6C710
        public void get_supportRichText(){} // RVA: 0x7FFAC9C6C8F0
        public void set_supportRichText(){} // RVA: 0x7FFAC9C6C910
        public void get_resizeTextForBestFit(){} // RVA: 0x7FFAC9C6C970
        public void set_resizeTextForBestFit(){} // RVA: 0x7FFAC9C6C990
        public void get_resizeTextMinSize(){} // RVA: 0x7FFAC9C6C9F0
        public void set_resizeTextMinSize(){} // RVA: 0x7FFAC9C6CA10
        public void get_resizeTextMaxSize(){} // RVA: 0x7FFAC9C6CA70
        public void set_resizeTextMaxSize(){} // RVA: 0x7FFAC9C6CA90
        public void get_alignment(){} // RVA: 0x7FFAC9C6CAF0
        public void set_alignment(){} // RVA: 0x7FFAC9C6CB10
        public void get_alignByGeometry(){} // RVA: 0x7FFAC9C6CB70
        public void set_alignByGeometry(){} // RVA: 0x7FFAC9C6CB90
        public void get_fontSize(){} // RVA: 0x7FFAC9C6CBD0
        public void set_fontSize(){} // RVA: 0x7FFAC9C6CBF0
        public void get_horizontalOverflow(){} // RVA: 0x7FFAC9C6CC50
        public void set_horizontalOverflow(){} // RVA: 0x7FFAC9C6CC70
        public void get_verticalOverflow(){} // RVA: 0x7FFAC9C6CCD0
        public void set_verticalOverflow(){} // RVA: 0x7FFAC9C6CCF0
        public void get_lineSpacing(){} // RVA: 0x7FFAC9C6CD50
        public void set_lineSpacing(){} // RVA: 0x7FFAC9C6CD70
        public void get_fontStyle(){} // RVA: 0x7FFAC9C6CDE0
        public void set_fontStyle(){} // RVA: 0x7FFAC9C6CE00
        public void get_pixelsPerUnit(){} // RVA: 0x7FFAC9C6CE60
        public void OnEnable(){} // RVA: 0x7FFAC9C6D150
        public void OnDisable(){} // RVA: 0x7FFAC9C6D200
        public void UpdateGeometry(){} // RVA: 0x7FFAC9C6D260
        public void AssignDefaultFont(){} // RVA: 0x7FFAC9C6D370
        public void AssignDefaultFontIfNecessary(){} // RVA: 0x7FFAC9C6D3D0
        public void GetGenerationSettings(){} // RVA: 0x7FFAC9C6D4F0
        public void GetTextAnchorPivot(){} // RVA: 0x7FFAC9C6D870
        public void OnPopulateMesh(){} // RVA: 0x7FFAC9C6D9E0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC2F21310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC2F21310
        public void get_minWidth(){} // RVA: 0x7FFAC37432E0
        public void get_preferredWidth(){} // RVA: 0x7FFAC9C6E1F0
        public void get_flexibleWidth(){} // RVA: 0x7FFAC954F350
        public void get_minHeight(){} // RVA: 0x7FFAC37432E0
        public void get_preferredHeight(){} // RVA: 0x7FFAC9C6E320
        public void get_flexibleHeight(){} // RVA: 0x7FFAC954F350
        public void get_layoutPriority(){} // RVA: 0x7FFAC34F9180
    }

    public class Toggle : Selectable
    {
        public 0x6B24B238 group; // 0x100
        public UnityEngine.UI.Graphic isOn; // 0x108
        public UnityEngine.UI.ToggleGroup m_Group; // 0x110
        public ToggleEvent onValueChanged; // 0x118
        public bool m_IsOn; // 0x120

        // ── Methods ──
        public void get_group(){} // RVA: 0x7FFAC354B170
        public void set_group(){} // RVA: 0x7FFAC9C6E430
        public void .ctor(){} // RVA: 0x7FFAC9C6E460
        public void Rebuild(){} // RVA: 0x7FFAC2F21310
        public void LayoutComplete(){} // RVA: 0x7FFAC2F21310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFAC2F21310
        public void OnDestroy(){} // RVA: 0x7FFAC9C6E540
        public void OnEnable(){} // RVA: 0x7FFAC9C6E630
        public void OnDisable(){} // RVA: 0x7FFAC9C6E670
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC9C6E6A0
        public void SetToggleGroup(){} // RVA: 0x7FFAC9C6E830
        public void get_isOn(){} // RVA: 0x7FFAC87898E0
        public void set_isOn(){} // RVA: 0x7FFAC9C6EB10
        public void SetIsOnWithoutNotify(){} // RVA: 0x7FFAC9C6EB20
        public void Set(){} // RVA: 0x7FFAC9C6EB30
        public void PlayEffect(){} // RVA: 0x7FFAC9C6ED70
        public void Start(){} // RVA: 0x7FFAC9C6EEA0
        public void InternalToggle(){} // RVA: 0x7FFAC9C6EEB0
        public void OnPointerClick(){} // RVA: 0x7FFAC9C6EF10
        public void OnSubmit(){} // RVA: 0x7FFAC9C6EEB0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFAC33BCDF0
    }

    public class ToggleGroup : UIBehaviour
    {
        public bool allowSwitchOff; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.UI.Toggle> m_Toggles; // 0x28

        // ── Methods ──
        public void get_allowSwitchOff(){} // RVA: 0x7FFAC300F9D0
        public void set_allowSwitchOff(){} // RVA: 0x7FFAC300F9E0
        public void .ctor(){} // RVA: 0x7FFAC9C6F020
        public void Start(){} // RVA: 0x7FFAC9C6F120
        public void OnEnable(){} // RVA: 0x7FFAC9C6F120
        public void ValidateToggleIsInGroup(){} // RVA: 0x7FFAC9C6F130
        public void NotifyToggleOn(){} // RVA: 0x7FFAC9C6F2F0
        public void UnregisterToggle(){} // RVA: 0x7FFAC9C6F510
        public void RegisterToggle(){} // RVA: 0x7FFAC9C6F590
        public void EnsureValidState(){} // RVA: 0x7FFAC9C6F650
        public void AnyTogglesOn(){} // RVA: 0x7FFAC9C6FA40
        public void ActiveToggles(){} // RVA: 0x7FFAC9C6FC70
        public void GetFirstActiveToggle(){} // RVA: 0x7FFAC9C6FDE0
        public void SetAllTogglesOff(){} // RVA: 0x7FFAC9C6FE60
    }

    public class VertexHelper : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.Vector3> currentVertCount; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Color32> currentIndexCount; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.Vector4> m_Uv0S; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.Vector4> m_Uv1S; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.Vector4> m_Uv2S; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.Vector4> m_Uv3S; // 0x38
        public System.Collections.Generic.List`1<UnityEngine.Vector3> m_Normals; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.Vector4> m_Tangents; // 0x48
        public System.Collections.Generic.List`1<int> m_Indices; // 0x50
        public UnityEngine.Vector4 s_DefaultTangent;
        public UnityEngine.Vector3 s_DefaultNormal; // 0x10
        public bool m_ListsInitalized; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C72490 | overloaded x2
        public void InitializeListIfRequired(){} // RVA: 0x7FFAC9C727E0
        public void Dispose(){} // RVA: 0x7FFAC9C72D20
        public void Clear(){} // RVA: 0x7FFAC9C73240
        public void get_currentVertCount(){} // RVA: 0x7FFAC9C73340
        public void get_currentIndexCount(){} // RVA: 0x7FFAC9C73390
        public void PopulateUIVertex(){} // RVA: 0x7FFAC9C733E0
        public void SetUIVertex(){} // RVA: 0x7FFAC9C73630
        public void FillMesh(){} // RVA: 0x7FFAC9C73A40
        public void AddVert(){} // RVA: 0x7FFAC9C74600 | overloaded x4
        public void AddTriangle(){} // RVA: 0x7FFAC9C746B0
        public void AddUIVertexQuad(){} // RVA: 0x7FFAC9C74820
        public void AddUIVertexStream(){} // RVA: 0x7FFAC9C74AE0
        public void AddUIVertexTriangleStream(){} // RVA: 0x7FFAC9C74C60
        public void GetUIVertexStream(){} // RVA: 0x7FFAC9C74CE0
        public void .cctor(){} // RVA: 0x7FFAC9C74DF0
    }

    public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C4ACE0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC9C52A90
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC9C52AC0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFAC9C52AD0
        public void SetLayoutVertical(){} // RVA: 0x7FFAC9C52AE0
    }

}