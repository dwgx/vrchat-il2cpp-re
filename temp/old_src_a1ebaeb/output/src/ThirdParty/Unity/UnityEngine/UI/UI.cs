// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UI
// Classes: 64
// Methods: 1216

namespace ThirdParty.Unity.UnityEngine.UI
{
    public class AnimationTriggers : Object
    {
        public object kDefaultPressedAnimName; // 0x33ACF920
        public object m_NormalTrigger; // 0x33ACF920
        public object m_SelectedTrigger; // 0x33ACF920

        // ── Original Methods ──
        public void get_normalTrigger(){} // RVA: 0x7ffaa894d380
        public void set_normalTrigger(){} // RVA: 0x7ffaa8933e30
        public void get_highlightedTrigger(){} // RVA: 0x7ffaa89357c0
        public void set_highlightedTrigger(){} // RVA: 0x7ffaa8998e80
        public void get_pressedTrigger(){} // RVA: 0x7ffaa89600c0
        public void set_pressedTrigger(){} // RVA: 0x7ffaa89600d0
        public void get_selectedTrigger(){} // RVA: 0x7ffaa8960130
        public void set_selectedTrigger(){} // RVA: 0x7ffaa8933e90
        public void get_disabledTrigger(){} // RVA: 0x7ffaa8bfcc80
        public void set_disabledTrigger(){} // RVA: 0x7ffaa8960890
        public void .ctor(){} // RVA: 0x7ffaaf473fa0
    }

    public class AspectRatioFitter : UIBehaviour
    {
        public object m_Rect; // 0x338D7610
        public object m_Tracker; // 0x338D7610
        public object aspectMode; // 0x17000098
        public object aspectRatio; // 0x17000099

        // ── Original Methods ──
        public void get_aspectMode(){} // RVA: 0x7ffaa8aeced0
        public void set_aspectMode(){} // RVA: 0x7ffaaf669e20
        public void get_aspectRatio(){} // RVA: 0x7ffaa8a9ff50
        public void set_aspectRatio(){} // RVA: 0x7ffaaf669e80
        public void get_rectTransform(){} // RVA: 0x7ffaaf669ee0
        public void .ctor(){} // RVA: 0x7ffaa8ad1220
        public void OnEnable(){} // RVA: 0x7ffaaf66a020
        public void Start(){} // RVA: 0x7ffaaf66a160
        public void OnDisable(){} // RVA: 0x7ffaaf66a1e0
        public void OnTransformParentChanged(){} // RVA: 0x7ffaaf66a240
        public void Update(){} // RVA: 0x7ffaaf66a380
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7ffaaf66a3a0
        public void UpdateRect(){} // RVA: 0x7ffaaf66a3b0
        public void IsComponentValidOnObject(){} // RVA: 0x7ffaaf66ac10
        public void IsAspectModeValid(){} // RVA: 0x7ffaaf66ade0
        // ── Binary Analysis Named ──
        public void GetSizeDeltaToProduceSize(){} // RVA: 0x7ffaaf66a7a0
        public void GetParentSize(){} // RVA: 0x7ffaaf66aa10
        public void SetLayoutHorizontal(){} // RVA: 0x7ffaa8932310
        public void SetLayoutVertical(){} // RVA: 0x7ffaa8932310
        public void SetDirty(){} // RVA: 0x7ffaaf66a3a0
        public void DoesParentExists(){} // RVA: 0x7ffaa8958470
    }

    public class BaseMeshEffect : UIBehaviour
    {
        // ── Original Methods ──
        public void get_graphic(){} // RVA: 0x7ffaaf696ec0
        public void OnEnable(){} // RVA: 0x7ffaaf697000
        public void OnDisable(){} // RVA: 0x7ffaaf697100
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7ffaaf697200
        public void ModifyMesh(){} // RVA: 0x7ffaa8660d80
        public void ModifyMesh(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class Button : Selectable
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf4741f0
        public void get_onClick(){} // RVA: 0x7ffaa8f205f0
        public void set_onClick(){} // RVA: 0x7ffaa8f20bd0
        public void Press(){} // RVA: 0x7ffaaf474330
        public void OnPointerClick(){} // RVA: 0x7ffaaf4743d0
        public void OnSubmit(){} // RVA: 0x7ffaaf474400
        public void OnFinishSubmit(){} // RVA: 0x7ffaaf474510
    }

    public class CanvasScaler : UIBehaviour
    {
        public object m_ScaleFactor; // 0x333FDDE0
        public object m_MatchWidthOrHeight; // 0x333FDDE0
        public object m_FallbackScreenDPI; // 0x333FDDE0
        public object m_Canvas; // 0x333FDDE0
        public object m_PresetInfoIsWorld; // 0x333FDDE0
        public object uiScaleMode; // 0x1700009B
        public object referencePixelsPerUnit; // 0x1700009C
        public object scaleFactor; // 0x1700009D
        public object referenceResolution; // 0x1700009E
        public object screenMatchMode; // 0x1700009F

        // ── Original Methods ──
        public void get_uiScaleMode(){} // RVA: 0x7ffaa8aeced0
        public void set_uiScaleMode(){} // RVA: 0x7ffaa900aa90
        public void get_referencePixelsPerUnit(){} // RVA: 0x7ffaa8a9ff50
        public void set_referencePixelsPerUnit(){} // RVA: 0x7ffaa8a9ff60
        public void get_scaleFactor(){} // RVA: 0x7ffaa8a11210
        public void set_scaleFactor(){} // RVA: 0x7ffaaf66ae00
        public void get_referenceResolution(){} // RVA: 0x7ffaaf66ae20
        public void set_referenceResolution(){} // RVA: 0x7ffaaf66ae40
        public void get_screenMatchMode(){} // RVA: 0x7ffaa950c6d0
        public void set_screenMatchMode(){} // RVA: 0x7ffaa9b8cba0
        public void get_matchWidthOrHeight(){} // RVA: 0x7ffaa9144a40
        public void set_matchWidthOrHeight(){} // RVA: 0x7ffaa9144ae0
        public void get_physicalUnit(){} // RVA: 0x7ffaa8de7460
        public void set_physicalUnit(){} // RVA: 0x7ffaaa1eabc0
        public void get_fallbackScreenDPI(){} // RVA: 0x7ffaa8af93a0
        public void set_fallbackScreenDPI(){} // RVA: 0x7ffaa8b01070
        public void get_defaultSpriteDPI(){} // RVA: 0x7ffaa893a970
        public void set_defaultSpriteDPI(){} // RVA: 0x7ffaaf66aec0
        public void get_dynamicPixelsPerUnit(){} // RVA: 0x7ffaa9fe53d0
        public void set_dynamicPixelsPerUnit(){} // RVA: 0x7ffaa9fe6140
        public void .ctor(){} // RVA: 0x7ffaaf66aee0
        public void OnEnable(){} // RVA: 0x7ffaaf66af70
        public void Canvas_preWillRenderCanvases(){} // RVA: 0x7ffaaa216e50
        public void OnDisable(){} // RVA: 0x7ffaaf66b070
        public void Handle(){} // RVA: 0x7ffaaf66b140
        public void HandleWorldCanvas(){} // RVA: 0x7ffaaf66b350
        public void HandleConstantPixelSize(){} // RVA: 0x7ffaaf66b3c0
        public void HandleScaleWithScreenSize(){} // RVA: 0x7ffaaf66b430
        public void HandleConstantPhysicalSize(){} // RVA: 0x7ffaaf66b6f0
        // ── Binary Analysis Named ──
        public void SetScaleFactor(){} // RVA: 0x7ffaaf66b810
        public void SetReferencePixelsPerUnit(){} // RVA: 0x7ffaaf66b850
    }

    public class CanvasUpdateRegistry : Object
    {
        public object m_PerformingGraphicUpdate; // 0x33AA6FA0
        public object m_LayoutRebuildQueue; // 0x33AA6FA0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf4747a0
        public void get_instance(){} // RVA: 0x7ffaaf474a70
        public void ObjectValidForUpdate(){} // RVA: 0x7ffaaf474b90
        public void CleanInvalidItems(){} // RVA: 0x7ffaaf474d00
        public void PerformUpdate(){} // RVA: 0x7ffaaf474ed0
        public void ParentCount(){} // RVA: 0x7ffaaf475640
        public void SortLayoutList(){} // RVA: 0x7ffaaf475840
        public void RegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7ffaaf475900
        public void TryRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7ffaaf475970
        public void InternalRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7ffaaf4759e0
        public void RegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7ffaaf475aa0
        public void TryRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7ffaaf475b10
        public void InternalRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7ffaaf475b80
        public void UnRegisterCanvasElementForRebuild(){} // RVA: 0x7ffaaf475c90
        public void DisableCanvasElementForRebuild(){} // RVA: 0x7ffaaf475f80
        public void InternalUnRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7ffaaf476270
        public void InternalUnRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7ffaaf4763d0
        public void InternalDisableCanvasElementForLayoutRebuild(){} // RVA: 0x7ffaaf476530
        public void InternalDisableCanvasElementForGraphicRebuild(){} // RVA: 0x7ffaaf476690
        public void IsRebuildingLayout(){} // RVA: 0x7ffaaf4767f0
        public void IsRebuildingGraphics(){} // RVA: 0x7ffaaf476850
        public void .cctor(){} // RVA: 0x7ffaaf4768b0
    }

    public class ClipperRegistry : Object
    {
        public object HasCulledThisFrame; // 0x339BC650
        public object instance; // 0x17000012

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf477290
        public void get_instance(){} // RVA: 0x7ffaaf477350
        public void Cull(){} // RVA: 0x7ffaaf4774d0
        public void Register(){} // RVA: 0x7ffaaf4776b0
        public void Unregister(){} // RVA: 0x7ffaaf477720
        public void Disable(){} // RVA: 0x7ffaaf477780
    }

    public class Clipping : Object
    {
        // ── Original Methods ──
        public void FindCullAndClipWorldRect(){} // RVA: 0x7ffaaf4777e0
    }

    public class ColorBlock : ValueType
    {
        public object m_PressedColor; // 0x33855220
        public object m_ColorMultiplier; // 0x33855220
        public object m_HighlightedSprite; // 0x335198C0
        public object m_DisabledSprite; // 0x335198C0

        // ── Original Methods ──
        public void get_normalColor(){} // RVA: 0x7ffaa8ce3e60
        public void set_normalColor(){} // RVA: 0x7ffaa9f2b600
        public void get_highlightedColor(){} // RVA: 0x7ffaa9e49b20
        public void set_highlightedColor(){} // RVA: 0x7ffaa9e49b30
        public void get_pressedColor(){} // RVA: 0x7ffaaa4204b0
        public void set_pressedColor(){} // RVA: 0x7ffaadd91ec0
        public void get_selectedColor(){} // RVA: 0x7ffaade810e0
        public void set_selectedColor(){} // RVA: 0x7ffaade810f0
        public void get_disabledColor(){} // RVA: 0x7ffaaa4cb790
        public void set_disabledColor(){} // RVA: 0x7ffaac72f3d0
        public void get_colorMultiplier(){} // RVA: 0x7ffaa899a460
        public void set_colorMultiplier(){} // RVA: 0x7ffaa899a470
        public void get_fadeDuration(){} // RVA: 0x7ffaa8dbada0
        public void set_fadeDuration(){} // RVA: 0x7ffaa8db9c30
        public void .cctor(){} // RVA: 0x7ffaaf476990
        public void Equals(){} // RVA: 0x7ffaaf476da0
        public void Equals(){} // RVA: 0x7ffaaf476da0
        public void op_Equality(){} // RVA: 0x7ffaaf4770a0
        public void op_Inequality(){} // RVA: 0x7ffaaf477150
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf477200
    }

    public class ContentSizeFitter : UIBehaviour
    {
        public object m_Rect; // 0x3346E700

        // ── Original Methods ──
        public void get_horizontalFit(){} // RVA: 0x7ffaa8aeced0
        public void set_horizontalFit(){} // RVA: 0x7ffaaf66b890
        public void get_verticalFit(){} // RVA: 0x7ffaa9349010
        public void set_verticalFit(){} // RVA: 0x7ffaaf66b8f0
        public void get_rectTransform(){} // RVA: 0x7ffaaf66b950
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void OnEnable(){} // RVA: 0x7ffaaf66ba90
        public void OnDisable(){} // RVA: 0x7ffaaf66baa0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7ffaaf66ba90
        public void HandleSelfFittingAlongAxis(){} // RVA: 0x7ffaaf66bb00
        // ── Binary Analysis Named ──
        public void SetLayoutHorizontal(){} // RVA: 0x7ffaaf66bba0
        public void SetLayoutVertical(){} // RVA: 0x7ffaaf66bc10
        public void SetDirty(){} // RVA: 0x7ffaaf66bc80
    }

    public class DefaultControls : Object
    {
        public object kThickHeight; // 0x33AA6290
        public object s_ThinElementSize; // 0x33AA6290
        public object s_PanelColor; // 0x33AA6290
        public object `;

        // ── Original Methods ──
        public void get_factory(){} // RVA: 0x7ffaaf477f20
        public void CreateUIElementRoot(){} // RVA: 0x7ffaaf477f80
        public void CreateUIObject(){} // RVA: 0x7ffaaf4780d0
        public void CreatePanel(){} // RVA: 0x7ffaaf4787c0
        public void CreateButton(){} // RVA: 0x7ffaaf478cc0
        public void CreateText(){} // RVA: 0x7ffaaf4793f0
        public void CreateImage(){} // RVA: 0x7ffaaf479600
        public void CreateRawImage(){} // RVA: 0x7ffaaf4797a0
        public void CreateSlider(){} // RVA: 0x7ffaaf479940
        public void CreateScrollbar(){} // RVA: 0x7ffaaf47a7c0
        public void CreateToggle(){} // RVA: 0x7ffaaf47b090
        public void CreateInputField(){} // RVA: 0x7ffaaf47bc30
        public void CreateDropdown(){} // RVA: 0x7ffaaf47c7c0
        public void CreateScrollView(){} // RVA: 0x7ffaaf47eb10
        public void .cctor(){} // RVA: 0x7ffaaf47fd40
        // ── Binary Analysis Named ──
        public void SetDefaultTextValues(){} // RVA: 0x7ffaaf4781c0
        public void SetDefaultColorTransitionValues(){} // RVA: 0x7ffaaf478350
        public void SetParentAndAlign(){} // RVA: 0x7ffaaf4783b0
        public void SetLayerRecursively(){} // RVA: 0x7ffaaf4785b0
    }

    public class Dropdown : Selectable
    {
        public object m_CaptionImage; // 0x3173B000
        public object m_Value; // 0x3173B000
        public object m_AlphaFadeSpeed; // 0x3173B000
        public object m_Items; // 0x3173B000
        public object kHighSortingLayer; // 0x3173B000
        public object  ; // 0x31742160

        // ── Original Methods ──
        public void get_template(){} // RVA: 0x7ffaa8f205f0
        public void set_template(){} // RVA: 0x7ffaaf47ffc0
        public void get_captionText(){} // RVA: 0x7ffaa9102670
        public void set_captionText(){} // RVA: 0x7ffaaf480020
        public void get_captionImage(){} // RVA: 0x7ffaa8f76f40
        public void set_captionImage(){} // RVA: 0x7ffaaf480080
        public void get_itemText(){} // RVA: 0x7ffaa8de7450
        public void set_itemText(){} // RVA: 0x7ffaaf4800e0
        public void get_itemImage(){} // RVA: 0x7ffaa8b68c40
        public void set_itemImage(){} // RVA: 0x7ffaaf480140
        public void get_options(){} // RVA: 0x7ffaaf4801a0
        public void set_options(){} // RVA: 0x7ffaaf4801c0
        public void get_onValueChanged(){} // RVA: 0x7ffaa8f76810
        public void set_onValueChanged(){} // RVA: 0x7ffaa9101830
        public void get_alphaFadeSpeed(){} // RVA: 0x7ffaaf480240
        public void set_alphaFadeSpeed(){} // RVA: 0x7ffaaf480250
        public void get_value(){} // RVA: 0x7ffaae432c10
        public void set_value(){} // RVA: 0x7ffaaf480260
        public void .ctor(){} // RVA: 0x7ffaaf480400
        public void Awake(){} // RVA: 0x7ffaaf480630
        public void Start(){} // RVA: 0x7ffaaf480940
        public void OnDisable(){} // RVA: 0x7ffaaf480a70
        public void RefreshShownValue(){} // RVA: 0x7ffaaf480bd0
        public void AddOptions(){} // RVA: 0x7ffaaf481200
        public void AddOptions(){} // RVA: 0x7ffaaf481200
        public void AddOptions(){} // RVA: 0x7ffaaf481200
        public void ClearOptions(){} // RVA: 0x7ffaaf4813d0
        public void OnPointerClick(){} // RVA: 0x7ffaaf482280
        public void OnSubmit(){} // RVA: 0x7ffaaf482280
        public void OnCancel(){} // RVA: 0x7ffaaf482290
        public void Show(){} // RVA: 0x7ffaaf4822a0
        public void CreateBlocker(){} // RVA: 0x7ffaaf483b30
        public void DestroyBlocker(){} // RVA: 0x7ffaaf4846b0
        public void CreateDropdownList(){} // RVA: 0x7ffaaf484700
        public void DestroyDropdownList(){} // RVA: 0x7ffaaf484770
        public void CreateItem(){} // RVA: 0x7ffaaf4847c0
        public void DestroyItem(){} // RVA: 0x7ffaa8932310
        public void AddItem(){} // RVA: 0x7ffaaf484830
        public void AlphaFadeList(){} // RVA: 0x7ffaaf484fc0
        public void AlphaFadeList(){} // RVA: 0x7ffaaf484fc0
        public void Hide(){} // RVA: 0x7ffaaf4852a0
        public void DelayedDestroyDropdownList(){} // RVA: 0x7ffaaf485630
        public void ImmediateDestroyDropdownList(){} // RVA: 0x7ffaaf4856f0
        public void OnSelectItem(){} // RVA: 0x7ffaaf4859e0
        public void .cctor(){} // RVA: 0x7ffaaf485c70
        // ── Binary Analysis Named ──
        public void SetValueWithoutNotify(){} // RVA: 0x7ffaaf480270
        public void Set(){} // RVA: 0x7ffaaf480280
        public void SetupTemplate(){} // RVA: 0x7ffaaf481450
        public void GetOrAddComponent(){} // RVA: 0x7ffaa887e5c0
        public void SetAlpha(){} // RVA: 0x7ffaaf485180
    }

    public class FontData : Object
    {
        public object m_FontStyle; // 0x3343D1F0
        public object m_MaxSize; // 0x3343D1F0
        public object m_RichText; // 0x3343D1F0
        public object m_LineSpacing; // 0x3343D1F0
        public object defaultFontData; // 0x17000028
        public object font; // 0x17000029
        public object fontSize; // 0x1700002A
        public object fontStyle; // 0x1700002B

        // ── Original Methods ──
        public void get_defaultFontData(){} // RVA: 0x7ffaaf486120
        public void get_font(){} // RVA: 0x7ffaa894d380
        public void set_font(){} // RVA: 0x7ffaa8933e30
        public void get_fontSize(){} // RVA: 0x7ffaa8b945a0
        public void set_fontSize(){} // RVA: 0x7ffaa9357830
        public void get_fontStyle(){} // RVA: 0x7ffaa9e5ac10
        public void set_fontStyle(){} // RVA: 0x7ffaa9e6a2e0
        public void get_bestFit(){} // RVA: 0x7ffaa8a209d0
        public void set_bestFit(){} // RVA: 0x7ffaa8a209e0
        public void get_minSize(){} // RVA: 0x7ffaa9349010
        public void set_minSize(){} // RVA: 0x7ffaa9b8c1b0
        public void get_maxSize(){} // RVA: 0x7ffaa8d14570
        public void set_maxSize(){} // RVA: 0x7ffaa90c0cd0
        public void get_alignment(){} // RVA: 0x7ffaa96cc980
        public void set_alignment(){} // RVA: 0x7ffaa9fdb500
        public void get_alignByGeometry(){} // RVA: 0x7ffaa8958450
        public void set_alignByGeometry(){} // RVA: 0x7ffaa8958460
        public void get_richText(){} // RVA: 0x7ffaa8958470
        public void set_richText(){} // RVA: 0x7ffaa8958480
        public void get_horizontalOverflow(){} // RVA: 0x7ffaa950c6d0
        public void set_horizontalOverflow(){} // RVA: 0x7ffaa9b8cba0
        public void get_verticalOverflow(){} // RVA: 0x7ffaa8fb82b0
        public void set_verticalOverflow(){} // RVA: 0x7ffaa8fb82c0
        public void get_lineSpacing(){} // RVA: 0x7ffaa9068340
        public void set_lineSpacing(){} // RVA: 0x7ffaa9068080
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaaf486190
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class FontUpdateTracker : Object
    {
        // ── Original Methods ──
        public void TrackText(){} // RVA: 0x7ffaaf4861e0
        public void RebuildForFont(){} // RVA: 0x7ffaaf486620
        public void UntrackText(){} // RVA: 0x7ffaaf4867e0
        public void .cctor(){} // RVA: 0x7ffaaf486bb0
    }

    public class Graphic : UIBehaviour
    {
        public object m_Material; // 0x318C1090
        public object m_SkipMaterialUpdate; // 0x318C1090
        public object m_RaycastPadding; // 0x318C1090
        public object m_Canvas; // 0x318C1090
        public object m_OnDirtyLayoutCallback; // 0x318C1090
        public object s_Mesh; // 0x318C1090
        public object m_CachedUvs; // 0x318C1090

        // ── Original Methods ──
        public void get_defaultGraphicMaterial(){} // RVA: 0x7ffaaf486c90
        public void get_color(){} // RVA: 0x7ffaa95ffd80
        public void set_color(){} // RVA: 0x7ffaaf486e70
        public void get_raycastTarget(){} // RVA: 0x7ffaa99a3bf0
        public void set_raycastTarget(){} // RVA: 0x7ffaaf486ee0
        public void get_raycastPadding(){} // RVA: 0x7ffaae368110
        public void set_raycastPadding(){} // RVA: 0x7ffaae368120
        public void get_useLegacyMeshGeneration(){} // RVA: 0x7ffaa9feeae0
        public void set_useLegacyMeshGeneration(){} // RVA: 0x7ffaa91d7fd0
        public void .ctor(){} // RVA: 0x7ffaaf486ff0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7ffaaf4874e0
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7ffaaf487650
        public void OnTransformParentChanged(){} // RVA: 0x7ffaaf487700
        public void get_depth(){} // RVA: 0x7ffaaf487800
        public void get_rectTransform(){} // RVA: 0x7ffaaf487870
        public void get_canvas(){} // RVA: 0x7ffaaf487910
        public void CacheCanvas(){} // RVA: 0x7ffaaf4879f0
        public void get_canvasRenderer(){} // RVA: 0x7ffaaf487c70
        public void get_defaultMaterial(){} // RVA: 0x7ffaaf487e00
        public void get_material(){} // RVA: 0x7ffaaf487e50
        public void set_material(){} // RVA: 0x7ffaaf487f40
        public void get_materialForRendering(){} // RVA: 0x7ffaaf4880c0
        public void get_mainTexture(){} // RVA: 0x7ffaaf4882d0
        public void OnEnable(){} // RVA: 0x7ffaaf488330
        public void OnDisable(){} // RVA: 0x7ffaaf488560
        public void OnDestroy(){} // RVA: 0x7ffaaf488740
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7ffaaf488900
        public void OnCullingChanged(){} // RVA: 0x7ffaaf488b50
        public void Rebuild(){} // RVA: 0x7ffaaf488c10
        public void LayoutComplete(){} // RVA: 0x7ffaa8932310
        public void GraphicUpdateComplete(){} // RVA: 0x7ffaa8932310
        public void UpdateMaterial(){} // RVA: 0x7ffaaf488da0
        public void UpdateGeometry(){} // RVA: 0x7ffaaf488f30
        public void get_workerMesh(){} // RVA: 0x7ffaaf489b20
        public void OnFillVBO(){} // RVA: 0x7ffaa8932310
        public void OnPopulateMesh(){} // RVA: 0x7ffaaf489dd0
        public void OnPopulateMesh(){} // RVA: 0x7ffaaf489dd0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7ffaaeca60c0
        public void Raycast(){} // RVA: 0x7ffaaf489fe0
        public void PixelAdjustPoint(){} // RVA: 0x7ffaaf48a510
        public void CrossFadeColor(){} // RVA: 0x7ffaaf48ab40
        public void CrossFadeColor(){} // RVA: 0x7ffaaf48ab40
        public void CreateColorFromAlpha(){} // RVA: 0x7ffaaf48b010
        public void CrossFadeAlpha(){} // RVA: 0x7ffaaf48b030
        public void RegisterDirtyLayoutCallback(){} // RVA: 0x7ffaaf48b100
        public void UnregisterDirtyLayoutCallback(){} // RVA: 0x7ffaaf48b1f0
        public void RegisterDirtyVerticesCallback(){} // RVA: 0x7ffaaf48b2e0
        public void UnregisterDirtyVerticesCallback(){} // RVA: 0x7ffaaf48b3d0
        public void RegisterDirtyMaterialCallback(){} // RVA: 0x7ffaaf48b4c0
        public void UnregisterDirtyMaterialCallback(){} // RVA: 0x7ffaaf48b5c0
        public void .cctor(){} // RVA: 0x7ffaaf48b6c0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7ffaa8de7a30
        // ── Binary Analysis Named ──
        public void SetAllDirty(){} // RVA: 0x7ffaaf487180
        public void SetLayoutDirty(){} // RVA: 0x7ffaaf4871f0
        public void SetVerticesDirty(){} // RVA: 0x7ffaaf487290
        public void SetMaterialDirty(){} // RVA: 0x7ffaaf487320
        public void SetRaycastDirty(){} // RVA: 0x7ffaaf4873c0
        public void DoMeshGeneration(){} // RVA: 0x7ffaaf488f50
        public void DoLegacyMeshGeneration(){} // RVA: 0x7ffaaf489540
        public void SetNativeSize(){} // RVA: 0x7ffaa8932310
        public void GetPixelAdjustedRect(){} // RVA: 0x7ffaaf48a7e0
    }

    public class GraphicRaycaster : BaseRaycaster
    {
        public object m_BlockingObjects; // 0x3387D040
        public object m_RaycastResults; // 0x3387D040

        // ── Original Methods ──
        public void get_sortOrderPriority(){} // RVA: 0x7ffaaf48b860
        public void get_renderOrderPriority(){} // RVA: 0x7ffaaf48b940
        public void get_ignoreReversedGraphics(){} // RVA: 0x7ffaa8b0edb0
        public void set_ignoreReversedGraphics(){} // RVA: 0x7ffaa96574d0
        public void get_blockingObjects(){} // RVA: 0x7ffaa96cc980
        public void set_blockingObjects(){} // RVA: 0x7ffaa9fdb500
        public void get_blockingMask(){} // RVA: 0x7ffaa898dcd0
        public void set_blockingMask(){} // RVA: 0x7ffaa898dce0
        public void .ctor(){} // RVA: 0x7ffaaf48ba70
        public void get_canvas(){} // RVA: 0x7ffaaf48bb70
        public void Raycast(){} // RVA: 0x7ffaaf48d2f0
        public void get_eventCamera(){} // RVA: 0x7ffaaf48d110
        public void Raycast(){} // RVA: 0x7ffaaf48d2f0
        public void .cctor(){} // RVA: 0x7ffaaf48da30
    }

    public class GraphicRegistry : Object
    {
        public object m_RaycastableGraphics; // 0x335A2120

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf48dcb0
        public void get_instance(){} // RVA: 0x7ffaaf48ded0
        public void RegisterGraphicForCanvas(){} // RVA: 0x7ffaaf48dff0
        public void RegisterRaycastGraphicForCanvas(){} // RVA: 0x7ffaaf48e390
        public void UnregisterGraphicForCanvas(){} // RVA: 0x7ffaaf48e740
        public void UnregisterRaycastGraphicForCanvas(){} // RVA: 0x7ffaaf48e9f0
        public void DisableGraphicForCanvas(){} // RVA: 0x7ffaaf48ec70
        public void DisableRaycastGraphicForCanvas(){} // RVA: 0x7ffaaf48ee90
        public void .cctor(){} // RVA: 0x7ffaaf48f250
        // ── Binary Analysis Named ──
        public void GetGraphicsForCanvas(){} // RVA: 0x7ffaaf48f0b0
        public void GetRaycastableGraphicsForCanvas(){} // RVA: 0x7ffaaf48f180
    }

    public class GridLayoutGroup : LayoutGroup
    {
        public object m_CellSize; // 0x3390D570
        public object m_ConstraintCount; // 0x3390D570
        public object startCorner; // 0x170000A8
        public object startAxis; // 0x170000A9

        // ── Original Methods ──
        public void get_startCorner(){} // RVA: 0x7ffaa8b645f0
        public void set_startCorner(){} // RVA: 0x7ffaaf66bd00
        public void get_startAxis(){} // RVA: 0x7ffaa8b64610
        public void set_startAxis(){} // RVA: 0x7ffaaf66bd50
        public void get_cellSize(){} // RVA: 0x7ffaaf66bda0
        public void set_cellSize(){} // RVA: 0x7ffaaf66bdc0
        public void get_spacing(){} // RVA: 0x7ffaaf66be10
        public void set_spacing(){} // RVA: 0x7ffaaf66be30
        public void get_constraint(){} // RVA: 0x7ffaa9fb1a70
        public void set_constraint(){} // RVA: 0x7ffaaf66be80
        public void get_constraintCount(){} // RVA: 0x7ffaa9fb8830
        public void set_constraintCount(){} // RVA: 0x7ffaaf66bed0
        public void .ctor(){} // RVA: 0x7ffaaf66bfc0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7ffaaf66c030
        public void CalculateLayoutInputVertical(){} // RVA: 0x7ffaaf66c240
        // ── Binary Analysis Named ──
        public void SetLayoutHorizontal(){} // RVA: 0x7ffaaf66c470
        public void SetLayoutVertical(){} // RVA: 0x7ffaaf66c480
        public void SetCellsAlongAxis(){} // RVA: 0x7ffaaf66c490
    }

    public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf66cc50
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7ffaaf66cc60
        public void CalculateLayoutInputVertical(){} // RVA: 0x7ffaaf66cc90
        // ── Binary Analysis Named ──
        public void SetLayoutHorizontal(){} // RVA: 0x7ffaaf66cca0
        public void SetLayoutVertical(){} // RVA: 0x7ffaaf66ccb0
    }

    public class HorizontalOrVerticalLayoutGroup : LayoutGroup
    {
        public object m_ChildForceExpandHeight; // 0x334648B0
        public object m_ChildScaleWidth; // 0x334648B0

        // ── Original Methods ──
        public void get_spacing(){} // RVA: 0x7ffaa8a42e10
        public void set_spacing(){} // RVA: 0x7ffaaf66ccc0
        public void get_childForceExpandWidth(){} // RVA: 0x7ffaa9970570
        public void set_childForceExpandWidth(){} // RVA: 0x7ffaaf66cd70
        public void get_childForceExpandHeight(){} // RVA: 0x7ffaae8c22f0
        public void set_childForceExpandHeight(){} // RVA: 0x7ffaaf66cdc0
        public void get_childControlWidth(){} // RVA: 0x7ffaae8c2250
        public void set_childControlWidth(){} // RVA: 0x7ffaaf66ce10
        public void get_childControlHeight(){} // RVA: 0x7ffaae8c2240
        public void set_childControlHeight(){} // RVA: 0x7ffaaf66ce60
        public void get_childScaleWidth(){} // RVA: 0x7ffaa89fa570
        public void set_childScaleWidth(){} // RVA: 0x7ffaaf66ceb0
        public void get_childScaleHeight(){} // RVA: 0x7ffaaa08e8f0
        public void set_childScaleHeight(){} // RVA: 0x7ffaaf66cf00
        public void get_reverseArrangement(){} // RVA: 0x7ffaadcb1e30
        public void set_reverseArrangement(){} // RVA: 0x7ffaaf66cf50
        public void CalcAlongAxis(){} // RVA: 0x7ffaaf66cfa0
        public void .ctor(){} // RVA: 0x7ffaaf66cc50
        // ── Binary Analysis Named ──
        public void SetChildrenAlongAxis(){} // RVA: 0x7ffaaf66d450
        public void GetChildSizes(){} // RVA: 0x7ffaaf66e000
    }

    public class ICanvasElement
    {
        // ── Original Methods ──
        public void Rebuild(){} // RVA: 0x7ffaa8661210
        public void get_transform(){} // RVA: 0x7ffaa86491d0
        public void LayoutComplete(){} // RVA: 0x7ffaa8660cc0
        public void GraphicUpdateComplete(){} // RVA: 0x7ffaa8660cc0
        public void IsDestroyed(){} // RVA: 0x7ffaa864a040
    }

    public class IClippable
    {
        // ── Original Methods ──
        public void get_gameObject(){} // RVA: 0x7ffaa86491d0
        public void RecalculateClipping(){} // RVA: 0x7ffaa8660cc0
        public void get_rectTransform(){} // RVA: 0x7ffaa86491d0
        public void Cull(){}
        // ── Binary Analysis Named ──
        public void SetClipRect(){}
        public void SetClipSoftness(){} // RVA: 0x7ffaa866f720
    }

    public class IClipper
    {
        // ── Original Methods ──
        public void PerformClipping(){} // RVA: 0x7ffaa8660cc0
    }

    public class IGraphicEnabledDisabled
    {
        // ── Original Methods ──
        public void OnSiblingGraphicEnabledDisabled(){} // RVA: 0x7ffaa8660cc0
    }

    public class ILayoutController
    {
        // ── Binary Analysis Named ──
        public void SetLayoutHorizontal(){} // RVA: 0x7ffaa8660cc0
        public void SetLayoutVertical(){} // RVA: 0x7ffaa8660cc0
    }

    public class ILayoutElement
    {
        // ── Original Methods ──
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7ffaa8660cc0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7ffaa8660cc0
        public void get_minWidth(){} // RVA: 0x7ffaa865dbc0
        public void get_preferredWidth(){} // RVA: 0x7ffaa865dbc0
        public void get_flexibleWidth(){} // RVA: 0x7ffaa865dbc0
        public void get_minHeight(){} // RVA: 0x7ffaa865dbc0
        public void get_preferredHeight(){} // RVA: 0x7ffaa865dbc0
        public void get_flexibleHeight(){} // RVA: 0x7ffaa865dbc0
        public void get_layoutPriority(){} // RVA: 0x7ffaa8649ca0
    }

    public class ILayoutGroup
    {
    }

    public class ILayoutIgnorer
    {
        // ── Original Methods ──
        public void get_ignoreLayout(){} // RVA: 0x7ffaa864a040
    }

    public class ILayoutSelfController
    {
    }

    public class IMask
    {
        // ── Original Methods ──
        public void Enabled(){} // RVA: 0x7ffaa864a040
        public void get_rectTransform(){} // RVA: 0x7ffaa86491d0
    }

    public class IMaskable
    {
        // ── Original Methods ──
        public void RecalculateMasking(){} // RVA: 0x7ffaa8660cc0
    }

    public class IMaterialModifier
    {
        // ── Binary Analysis Named ──
        public void GetModifiedMaterial(){} // RVA: 0x7ffaa8649280
    }

    public class IMeshModifier
    {
        // ── Original Methods ──
        public void ModifyMesh(){} // RVA: 0x7ffaa8660d80
        public void ModifyMesh(){} // RVA: 0x7ffaa8660d80
    }

    public class Image : MaskableGraphic
    {
        public object m_OverrideSprite; // 0x3368EEA0
        public object m_FillCenter; // 0x3368EEA0
        public object m_FillClockwise; // 0x3368EEA0
        public object m_Tracked; // 0x3368EEA0
        public object m_CachedReferencePixelsPerUnit; // 0x3368EEA0
        public object s_Xy; // 0x3368EEA0
        public object s_Initialized; // 0x3368EEA0

        // ── Original Methods ──
        public void get_sprite(){} // RVA: 0x7ffaa89b3900
        public void set_sprite(){} // RVA: 0x7ffaaf48f330
        public void DisableSpriteOptimizations(){} // RVA: 0x7ffaaf48fad0
        public void get_overrideSprite(){} // RVA: 0x7ffaaf48fae0
        public void set_overrideSprite(){} // RVA: 0x7ffaaf48faf0
        public void get_activeSprite(){} // RVA: 0x7ffaaf48fb70
        public void get_type(){} // RVA: 0x7ffaaba8f7a0
        public void set_type(){} // RVA: 0x7ffaaf48fc60
        public void get_preserveAspect(){} // RVA: 0x7ffaa98c01f0
        public void set_preserveAspect(){} // RVA: 0x7ffaaf48fcd0
        public void get_fillCenter(){} // RVA: 0x7ffaa98b2c70
        public void set_fillCenter(){} // RVA: 0x7ffaaf48fd40
        public void get_fillMethod(){} // RVA: 0x7ffaa98b8b60
        public void set_fillMethod(){} // RVA: 0x7ffaaf48fdb0
        public void get_fillAmount(){} // RVA: 0x7ffaa8b0b350
        public void set_fillAmount(){} // RVA: 0x7ffaaf48fe30
        public void get_fillClockwise(){} // RVA: 0x7ffaa96c9090
        public void set_fillClockwise(){} // RVA: 0x7ffaaf48fec0
        public void get_fillOrigin(){} // RVA: 0x7ffaaa1b8000
        public void set_fillOrigin(){} // RVA: 0x7ffaaf48ff30
        public void get_eventAlphaThreshold(){} // RVA: 0x7ffaaf48ffa0
        public void set_eventAlphaThreshold(){} // RVA: 0x7ffaaf48ffc0
        public void get_alphaHitTestMinimumThreshold(){} // RVA: 0x7ffaaa36dc40
        public void set_alphaHitTestMinimumThreshold(){} // RVA: 0x7ffaaf48ffe0
        public void get_useSpriteMesh(){} // RVA: 0x7ffaac120b10
        public void set_useSpriteMesh(){} // RVA: 0x7ffaaf4902b0
        public void .ctor(){} // RVA: 0x7ffaaf490320
        public void get_defaultETC1GraphicMaterial(){} // RVA: 0x7ffaaf490380
        public void get_mainTexture(){} // RVA: 0x7ffaaf490560
        public void get_hasBorder(){} // RVA: 0x7ffaaf490870
        public void get_pixelsPerUnitMultiplier(){} // RVA: 0x7ffaaf490a00
        public void set_pixelsPerUnitMultiplier(){} // RVA: 0x7ffaaf490a10
        public void get_pixelsPerUnit(){} // RVA: 0x7ffaaf490a40
        public void get_multipliedPixelsPerUnit(){} // RVA: 0x7ffaaf490c90
        public void get_material(){} // RVA: 0x7ffaaf490cb0
        public void set_material(){} // RVA: 0x7ffaaf490f70
        public void OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void OnAfterDeserialize(){} // RVA: 0x7ffaaf490f80
        public void PreserveSpriteAspectRatio(){} // RVA: 0x7ffaa9120d80
        public void OnPopulateMesh(){} // RVA: 0x7ffaaf491810
        public void TrackSprite(){} // RVA: 0x7ffaaf4919d0
        public void OnEnable(){} // RVA: 0x7ffaaf491d30
        public void OnDisable(){} // RVA: 0x7ffaaf491d90
        public void UpdateMaterial(){} // RVA: 0x7ffaaf491e70
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7ffaaf492240
        public void GenerateSimpleSprite(){} // RVA: 0x7ffaaf492450
        public void GenerateSprite(){} // RVA: 0x7ffaaf4928d0
        public void GenerateSlicedSprite(){} // RVA: 0x7ffaaf493030
        public void GenerateTiledSprite(){} // RVA: 0x7ffaaf493b30
        public void AddQuad(){} // RVA: 0x7ffaa91212f0
        public void AddQuad(){} // RVA: 0x7ffaa91212f0
        public void GenerateFilledSprite(){} // RVA: 0x7ffaaf4952f0
        public void RadialCut(){} // RVA: 0x7ffaaf496750
        public void RadialCut(){} // RVA: 0x7ffaaf496750
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7ffaa8932310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7ffaa8932310
        public void get_minWidth(){} // RVA: 0x7ffaa916f990
        public void get_preferredWidth(){} // RVA: 0x7ffaaf496c10
        public void get_flexibleWidth(){} // RVA: 0x7ffaaef71320
        public void get_minHeight(){} // RVA: 0x7ffaa916f990
        public void get_preferredHeight(){} // RVA: 0x7ffaaf496dd0
        public void get_flexibleHeight(){} // RVA: 0x7ffaaef71320
        public void get_layoutPriority(){} // RVA: 0x7ffaa8f22da0
        public void IsRaycastLocationValid(){} // RVA: 0x7ffaaf496f90
        public void MapCoordinate(){} // RVA: 0x7ffaaf497430
        public void RebuildImage(){} // RVA: 0x7ffaaf497b40
        public void TrackImage(){} // RVA: 0x7ffaaf497db0
        public void UnTrackImage(){} // RVA: 0x7ffaaf497f20
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7ffaaf497fb0
        public void .cctor(){} // RVA: 0x7ffaaf498000
        public void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0(){} // RVA: 0x7ffaaf498390
        public void <set_sprite>g__SpriteSupportsAlphaHitTest|11_1(){} // RVA: 0x7ffaaf498420
        // ── Binary Analysis Named ──
        public void GetDrawingDimensions(){} // RVA: 0x7ffaaf490ff0
        public void SetNativeSize(){} // RVA: 0x7ffaaf491520
        public void GetAdjustedBorders(){} // RVA: 0x7ffaa9120e70
    }

    public class InputField : Selectable
    {
        public object s_IsQuestDevice; // 0x3357D6E0
        public object m_Placeholder; // 0x3357D6E0
        public object m_AsteriskChar; // 0x3357D6E0
        public object m_HideMobileInput; // 0x3357D6E0
        public object m_OnSubmit; // 0x3357D6E0
        public object m_OnValueChanged; // 0x3357D6E0
        public object m_CustomCaretColor; // 0x3357D6E0
        public object m_CaretBlinkRate; // 0x3357D6E0
        public object m_ShouldActivateOnSelect; // 0x3357D6E0
        public object caretRectTrans; // 0x3357D6E0
        public object m_CachedInputRenderer; // 0x3357D6E0
        public object m_AllowInput; // 0x3357D6E0
        public object m_DragPositionOutOfBounds; // 0x3357D6E0
        public object m_CaretVisible; // 0x3357D6E0
        public object m_DrawStart; // 0x3357D6E0
        public object m_OriginalText; // 0x3357D6E0
        public object m_WaitForSecondsRealtime; // 0x3357D6E0
        public object kEmailSpecialCharacters; // 0x3357D6E0
        public object m_ProcessingEvent; // 0x3357D6E0

        // ── Original Methods ──
        public void get_input(){} // RVA: 0x7ffaaf65b0f0
        public void get_compositionString(){} // RVA: 0x7ffaaf65b2e0
        public void .ctor(){} // RVA: 0x7ffaaf65b430
        public void get_mesh(){} // RVA: 0x7ffaaf65b900
        public void get_cachedInputTextGenerator(){} // RVA: 0x7ffaaf65ba70
        public void set_shouldHideMobileInput(){} // RVA: 0x7ffaaf65bb30
        public void get_shouldHideMobileInput(){} // RVA: 0x7ffaaf65bb80
        public void set_shouldActivateOnSelect(){} // RVA: 0x7ffaae666870
        public void get_shouldActivateOnSelect(){} // RVA: 0x7ffaaf65bc20
        public void get_text(){} // RVA: 0x7ffaa8f6f0b0
        public void set_text(){} // RVA: 0x7ffaaf65bcc0
        public void get_isFocused(){} // RVA: 0x7ffaaa1cc1c0
        public void get_caretBlinkRate(){} // RVA: 0x7ffaaf65c1d0
        public void set_caretBlinkRate(){} // RVA: 0x7ffaaf65c1e0
        public void get_caretWidth(){} // RVA: 0x7ffaaf067c50
        public void set_caretWidth(){} // RVA: 0x7ffaaf65c250
        public void get_textComponent(){} // RVA: 0x7ffaa9102670
        public void set_textComponent(){} // RVA: 0x7ffaaf65c2b0
        public void get_placeholder(){} // RVA: 0x7ffaa8f76f40
        public void set_placeholder(){} // RVA: 0x7ffaaf65c640
        public void get_caretColor(){} // RVA: 0x7ffaaf65c6a0
        public void set_caretColor(){} // RVA: 0x7ffaaf65c700
        public void get_customCaretColor(){} // RVA: 0x7ffaa9410630
        public void set_customCaretColor(){} // RVA: 0x7ffaaf65c770
        public void get_selectionColor(){} // RVA: 0x7ffaaf65c790
        public void set_selectionColor(){} // RVA: 0x7ffaaf65c7a0
        public void get_onEndEdit(){} // RVA: 0x7ffaa899d660
        public void set_onEndEdit(){} // RVA: 0x7ffaaf65c810
        public void get_onSubmit(){} // RVA: 0x7ffaa8f76810
        public void set_onSubmit(){} // RVA: 0x7ffaaf65c870
        public void get_onValueChange(){} // RVA: 0x7ffaa8f6e840
        public void set_onValueChange(){} // RVA: 0x7ffaaf65c8d0
        public void get_onValueChanged(){} // RVA: 0x7ffaa8f6e840
        public void set_onValueChanged(){} // RVA: 0x7ffaaf65c8d0
        public void get_onValidateInput(){} // RVA: 0x7ffaa8f77ed0
        public void set_onValidateInput(){} // RVA: 0x7ffaaf65c930
        public void get_characterLimit(){} // RVA: 0x7ffaaed16df0
        public void set_characterLimit(){} // RVA: 0x7ffaaf65c990
        public void get_contentType(){} // RVA: 0x7ffaaa36dc60
        public void set_contentType(){} // RVA: 0x7ffaaf65ca40
        public void get_lineType(){} // RVA: 0x7ffaae432c10
        public void set_lineType(){} // RVA: 0x7ffaaf65cbf0
        public void get_inputType(){} // RVA: 0x7ffaaf51cbd0
        public void set_inputType(){} // RVA: 0x7ffaaf65cce0
        public void get_touchScreenKeyboard(){} // RVA: 0x7ffaa8f205f0
        public void get_keyboardType(){} // RVA: 0x7ffaae2f60a0
        public void set_keyboardType(){} // RVA: 0x7ffaaf65cd50
        public void get_characterValidation(){} // RVA: 0x7ffaa8de6c30
        public void set_characterValidation(){} // RVA: 0x7ffaaf65cdc0
        public void get_readOnly(){} // RVA: 0x7ffaae55fdf0
        public void set_readOnly(){} // RVA: 0x7ffaae55fe00
        public void get_multiLine(){} // RVA: 0x7ffaaf65ce30
        public void get_asteriskChar(){} // RVA: 0x7ffaaf65ce50
        public void set_asteriskChar(){} // RVA: 0x7ffaaf65ce60
        public void get_wasCanceled(){} // RVA: 0x7ffaae6668c0
        public void ClampPos(){} // RVA: 0x7ffaaf65cf10
        public void get_caretPositionInternal(){} // RVA: 0x7ffaaf65cf50
        public void set_caretPositionInternal(){} // RVA: 0x7ffaaf65cf80
        public void get_caretSelectPositionInternal(){} // RVA: 0x7ffaaf65cfd0
        public void set_caretSelectPositionInternal(){} // RVA: 0x7ffaaf65d000
        public void get_hasSelection(){} // RVA: 0x7ffaaf65d050
        public void get_caretPosition(){} // RVA: 0x7ffaaf65cfd0
        public void set_caretPosition(){} // RVA: 0x7ffaaf65d0b0
        public void get_selectionAnchorPosition(){} // RVA: 0x7ffaaf65cf50
        public void set_selectionAnchorPosition(){} // RVA: 0x7ffaaf65d0e0
        public void get_selectionFocusPosition(){} // RVA: 0x7ffaaf65cfd0
        public void set_selectionFocusPosition(){} // RVA: 0x7ffaaf65d150
        public void OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void OnAfterDeserialize(){} // RVA: 0x7ffaaf65d1c0
        public void OnEnable(){} // RVA: 0x7ffaaf65d320
        public void OnDisable(){} // RVA: 0x7ffaaf65d710
        public void OnDestroy(){} // RVA: 0x7ffaaf65dbb0
        public void CaretBlink(){} // RVA: 0x7ffaaf65dc00
        public void UpdateCaretMaterial(){} // RVA: 0x7ffaaf65de10
        public void OnFocus(){} // RVA: 0x7ffaaf65e040
        public void SelectAll(){} // RVA: 0x7ffaaf65e050
        public void MoveTextEnd(){} // RVA: 0x7ffaaf65e0e0
        public void MoveTextStart(){} // RVA: 0x7ffaaf65e200
        public void get_clipboard(){} // RVA: 0x7ffaaf65e2f0
        public void set_clipboard(){} // RVA: 0x7ffaaf65e370
        public void TouchScreenKeyboardShouldBeUsed(){} // RVA: 0x7ffaaf65e400
        public void InPlaceEditing(){} // RVA: 0x7ffaaf65e520
        public void InPlaceEditingChanged(){} // RVA: 0x7ffaaf65e550
        public void UpdateKeyboardCaret(){} // RVA: 0x7ffaaf65e6f0
        public void UpdateCaretFromKeyboard(){} // RVA: 0x7ffaaf65e800
        public void LateUpdate(){} // RVA: 0x7ffaaf65e9b0
        public void ScreenToLocal(){} // RVA: 0x7ffaaf65f1f0
        public void MayDrag(){} // RVA: 0x7ffaaf65ffd0
        public void OnBeginDrag(){} // RVA: 0x7ffaaf660130
        public void OnDrag(){} // RVA: 0x7ffaaf660160
        public void MouseDragOutsideRect(){} // RVA: 0x7ffaaf660510
        public void OnEndDrag(){} // RVA: 0x7ffaaf660610
        public void OnPointerDown(){} // RVA: 0x7ffaaf660640
        public void KeyPressed(){} // RVA: 0x7ffaaf660930
        public void IsValidChar(){} // RVA: 0x7ffaaf660f40
        public void ProcessEvent(){} // RVA: 0x7ffaaf660fa0
        public void OnUpdateSelected(){} // RVA: 0x7ffaaf660fb0
        public void FindtNextWordBegin(){} // RVA: 0x7ffaaf661340
        public void MoveRight(){} // RVA: 0x7ffaaf661450
        public void FindtPrevWordBegin(){} // RVA: 0x7ffaaf6616f0
        public void MoveLeft(){} // RVA: 0x7ffaaf6617f0
        public void DetermineCharacterLine(){} // RVA: 0x7ffaaf661a80
        public void LineUpCharacterPosition(){} // RVA: 0x7ffaaf661c20
        public void LineDownCharacterPosition(){} // RVA: 0x7ffaaf661ec0
        public void MoveDown(){} // RVA: 0x7ffaaf6621f0
        public void MoveDown(){} // RVA: 0x7ffaaf6621f0
        public void MoveUp(){} // RVA: 0x7ffaaf662420
        public void MoveUp(){} // RVA: 0x7ffaaf662420
        public void Delete(){} // RVA: 0x7ffaaf662600
        public void ForwardSpace(){} // RVA: 0x7ffaaf6628c0
        public void Backspace(){} // RVA: 0x7ffaaf6629d0
        public void Insert(){} // RVA: 0x7ffaaf662b50
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0x7ffaaf662d80
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0x7ffaaf662de0
        public void SendOnValueChanged(){} // RVA: 0x7ffaaf662e00
        public void SendOnEndEdit(){} // RVA: 0x7ffaaf662ec0
        public void SendOnSubmit(){} // RVA: 0x7ffaaf662f80
        public void Append(){} // RVA: 0x7ffaaf663120
        public void Append(){} // RVA: 0x7ffaaf663120
        public void UpdateLabel(){} // RVA: 0x7ffaaf6634b0
        public void IsSelectionVisible(){} // RVA: 0x7ffaaf663c70
        public void ForceLabelUpdate(){} // RVA: 0x7ffaaf664a10
        public void MarkGeometryAsDirty(){} // RVA: 0x7ffaaf664a20
        public void Rebuild(){} // RVA: 0x7ffaaf664ac0
        public void LayoutComplete(){} // RVA: 0x7ffaa8932310
        public void GraphicUpdateComplete(){} // RVA: 0x7ffaa8932310
        public void UpdateGeometry(){} // RVA: 0x7ffaaf664ad0
        public void AssignPositioningIfNeeded(){} // RVA: 0x7ffaaf665140
        public void OnFillVBO(){} // RVA: 0x7ffaaf665c30
        public void GenerateCaret(){} // RVA: 0x7ffaaf665e40
        public void CreateCursorVerts(){} // RVA: 0x7ffaaf666c10
        public void GenerateHighlight(){} // RVA: 0x7ffaaf666e20
        public void Validate(){} // RVA: 0x7ffaaf6676c0
        public void ActivateInputField(){} // RVA: 0x7ffaaf667da0
        public void ActivateInputFieldInternal(){} // RVA: 0x7ffaaf667fd0
        public void OnSelect(){} // RVA: 0x7ffaaf668810
        public void OnPointerClick(){} // RVA: 0x7ffaaf668860
        public void DeactivateInputField(){} // RVA: 0x7ffaaf668890
        public void OnDeselect(){} // RVA: 0x7ffaaf668c30
        public void OnSubmit(){} // RVA: 0x7ffaaf668c60
        public void EnforceContentType(){} // RVA: 0x7ffaaf668cb0
        public void EnforceTextHOverflow(){} // RVA: 0x7ffaaf668e20
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7ffaa8932310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7ffaa8932310
        public void get_minWidth(){} // RVA: 0x7ffaaf669040
        public void get_preferredWidth(){} // RVA: 0x7ffaaf669050
        public void get_flexibleWidth(){} // RVA: 0x7ffaaef71320
        public void get_minHeight(){} // RVA: 0x7ffaa916f990
        public void get_preferredHeight(){} // RVA: 0x7ffaaf6692b0
        public void get_flexibleHeight(){} // RVA: 0x7ffaaef71320
        public void get_layoutPriority(){} // RVA: 0x7ffaa8a24af0
        public void .cctor(){} // RVA: 0x7ffaaf669550
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7ffaa8de7a30
        // ── Binary Analysis Named ──
        public void SetTextWithoutNotify(){} // RVA: 0x7ffaaf65bcd0
        public void SetText(){} // RVA: 0x7ffaaf65bce0
        public void SetCaretVisible(){} // RVA: 0x7ffaaf65dca0
        public void SetCaretActive(){} // RVA: 0x7ffaaf65dd20
        public void GetInternalSelection(){} // RVA: 0x7ffaaf65e600
        public void GetUnclampedCharacterLineFromPosition(){} // RVA: 0x7ffaaf65f9c0
        public void GetCharacterIndexFromPosition(){} // RVA: 0x7ffaaf65fcc0
        public void GetSelectedString(){} // RVA: 0x7ffaaf661240
        public void GetLineStartPosition(){} // RVA: 0x7ffaaf663d40
        public void GetLineEndPosition(){} // RVA: 0x7ffaaf663e70
        public void SetDrawRangeToContainCaretPosition(){} // RVA: 0x7ffaaf663ff0
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0x7ffaaf668f80
        public void SetToCustom(){} // RVA: 0x7ffaaf668ff0
        public void DoStateTransition(){} // RVA: 0x7ffaaf669010
    }

    public class LayoutElement : UIBehaviour
    {
        public object m_MinHeight; // 0x33464C70
        public object m_FlexibleWidth; // 0x33464C70

        // ── Original Methods ──
        public void get_ignoreLayout(){} // RVA: 0x7ffaa8a209d0
        public void set_ignoreLayout(){} // RVA: 0x7ffaaf66e140
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7ffaa8932310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7ffaa8932310
        public void get_minWidth(){} // RVA: 0x7ffaa8a9ff50
        public void set_minWidth(){} // RVA: 0x7ffaaf66e1a0
        public void get_minHeight(){} // RVA: 0x7ffaa8a11210
        public void set_minHeight(){} // RVA: 0x7ffaaf66e200
        public void get_preferredWidth(){} // RVA: 0x7ffaa8e22440
        public void set_preferredWidth(){} // RVA: 0x7ffaaf66e260
        public void get_preferredHeight(){} // RVA: 0x7ffaa9672970
        public void set_preferredHeight(){} // RVA: 0x7ffaaf66e2c0
        public void get_flexibleWidth(){} // RVA: 0x7ffaa89fc630
        public void set_flexibleWidth(){} // RVA: 0x7ffaaf66e320
        public void get_flexibleHeight(){} // RVA: 0x7ffaa9144a40
        public void set_flexibleHeight(){} // RVA: 0x7ffaaf66e380
        public void get_layoutPriority(){} // RVA: 0x7ffaa8de7460
        public void set_layoutPriority(){} // RVA: 0x7ffaaf66e3e0
        public void .ctor(){} // RVA: 0x7ffaaf66e440
        public void OnEnable(){} // RVA: 0x7ffaaf66e4c0
        public void OnTransformParentChanged(){} // RVA: 0x7ffaaf66e4c0
        public void OnDisable(){} // RVA: 0x7ffaaf66e4c0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7ffaaf66e4c0
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7ffaaf66e4c0
        // ── Binary Analysis Named ──
        public void SetDirty(){} // RVA: 0x7ffaaf66e4d0
    }

    public class LayoutGroup : UIBehaviour
    {
        public object m_Rect; // 0x318099A0
        public object m_TotalPreferredSize; // 0x318099A0

        // ── Original Methods ──
        public void get_padding(){} // RVA: 0x7ffaa89600c0
        public void set_padding(){} // RVA: 0x7ffaaf66e5b0
        public void get_childAlignment(){} // RVA: 0x7ffaa8d14570
        public void set_childAlignment(){} // RVA: 0x7ffaaf66e680
        public void get_rectTransform(){} // RVA: 0x7ffaaf66e6d0
        public void get_rectChildren(){} // RVA: 0x7ffaa89fa500
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7ffaaf66e810
        public void CalculateLayoutInputVertical(){} // RVA: 0x7ffaa8660cc0
        public void get_minWidth(){} // RVA: 0x7ffaaf13e720
        public void get_preferredWidth(){} // RVA: 0x7ffaaf3a95a0
        public void get_flexibleWidth(){} // RVA: 0x7ffaaf41c180
        public void get_minHeight(){} // RVA: 0x7ffaaf361a90
        public void get_preferredHeight(){} // RVA: 0x7ffaaf41c170
        public void get_flexibleHeight(){} // RVA: 0x7ffaaf41c190
        public void get_layoutPriority(){} // RVA: 0x7ffaa8f22da0
        public void .ctor(){} // RVA: 0x7ffaaf66ec50
        public void OnEnable(){} // RVA: 0x7ffaaf66ef80
        public void OnDisable(){} // RVA: 0x7ffaaf66ef90
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7ffaaf66ef80
        public void get_isRootLayoutGroup(){} // RVA: 0x7ffaaf66fce0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7ffaaf66ffe0
        public void OnTransformChildrenChanged(){} // RVA: 0x7ffaaf66ef80
        public void DelayedSetDirty(){} // RVA: 0x7ffaaf6701b0
        // ── Binary Analysis Named ──
        public void SetLayoutHorizontal(){} // RVA: 0x7ffaa8660cc0
        public void SetLayoutVertical(){} // RVA: 0x7ffaa8660cc0
        public void GetTotalMinSize(){} // RVA: 0x7ffaaf66eff0
        public void GetTotalPreferredSize(){} // RVA: 0x7ffaaf66f000
        public void GetTotalFlexibleSize(){} // RVA: 0x7ffaaf66f010
        public void GetStartOffset(){} // RVA: 0x7ffaaf66f020
        public void GetAlignmentOnAxis(){} // RVA: 0x7ffaaf66f2d0
        public void SetLayoutInputForAxis(){} // RVA: 0x7ffaaf66f320
        public void SetChildAlongAxis(){} // RVA: 0x7ffaaf66f7c0
        public void SetChildAlongAxisWithScale(){} // RVA: 0x7ffaaf66f8e0
        public void SetChildAlongAxis(){} // RVA: 0x7ffaaf66f7c0
        public void SetChildAlongAxisWithScale(){} // RVA: 0x7ffaaf66f8e0
        public void SetProperty(){} // RVA: 0x7ffaa887e5c0
        public void SetDirty(){} // RVA: 0x7ffaaf670010
    }

    public class LayoutRebuilder : Object
    {
        public object s_Rebuilders; // 0x332DB2F0
        public object _cachedElementComponents; // 0x332DB2F0
        public object transform; // 0x170000D4

        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaaf670360
        public void Clear(){} // RVA: 0x7ffaaf6703e0
        public void .cctor(){} // RVA: 0x7ffaaf670440
        public void ReapplyDrivenProperties(){} // RVA: 0x7ffaaf670970
        public void get_transform(){} // RVA: 0x7ffaa894d380
        public void IsDestroyed(){} // RVA: 0x7ffaaf6709c0
        public void StripDisabledBehavioursFromList(){} // RVA: 0x7ffaaf670a90
        public void ForceRebuildLayoutImmediate(){} // RVA: 0x7ffaaf670c00
        public void Rebuild(){} // RVA: 0x7ffaaf670d50
        public void VRC_RegisterCachedLayoutTree(){} // RVA: 0x7ffaaf6711d0
        public void VRC_UnregisterCachedLayoutTree(){} // RVA: 0x7ffaaf6715c0
        public void PerformLayoutControl(){} // RVA: 0x7ffaaf6716e0
        public void PerformLayoutCalculation(){} // RVA: 0x7ffaaf671ea0
        public void MarkLayoutForRebuild(){} // RVA: 0x7ffaaf6724a0
        public void ValidController(){} // RVA: 0x7ffaaf672c20
        public void MarkLayoutRootForRebuild(){} // RVA: 0x7ffaaf672fd0
        public void LayoutComplete(){} // RVA: 0x7ffaaf673250
        public void GraphicUpdateComplete(){} // RVA: 0x7ffaa8932310
        public void Equals(){} // RVA: 0x7ffaaf6732e0
        public void ToString(){} // RVA: 0x7ffaaf673340
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa8b945a0
    }

    public class LayoutUtility : Object
    {
        // ── Binary Analysis Named ──
        public void GetMinSize(){} // RVA: 0x7ffaaf6737a0
        public void GetPreferredSize(){} // RVA: 0x7ffaaf6737c0
        public void GetFlexibleSize(){} // RVA: 0x7ffaaf6737e0
        public void GetMinWidth(){} // RVA: 0x7ffaaf673800
        public void GetPreferredWidth(){} // RVA: 0x7ffaaf673960
        public void GetFlexibleWidth(){} // RVA: 0x7ffaaf673c10
        public void GetMinHeight(){} // RVA: 0x7ffaaf673d70
        public void GetPreferredHeight(){} // RVA: 0x7ffaaf673ed0
        public void GetFlexibleHeight(){} // RVA: 0x7ffaaf674180
        public void GetLayoutProperty(){} // RVA: 0x7ffaaf674300
        public void GetLayoutProperty(){} // RVA: 0x7ffaaf674300
    }

    public class Mask : UIBehaviour
    {
        public object m_Graphic; // 0x3346C030

        // ── Original Methods ──
        public void get_rectTransform(){} // RVA: 0x7ffaaf674a60
        public void get_showMaskGraphic(){} // RVA: 0x7ffaa8b0edb0
        public void set_showMaskGraphic(){} // RVA: 0x7ffaaf674b00
        public void get_graphic(){} // RVA: 0x7ffaaf674c10
        public void .ctor(){} // RVA: 0x7ffaa8969bb0
        public void MaskEnabled(){} // RVA: 0x7ffaaf674cb0
        public void OnSiblingGraphicEnabledDisabled(){} // RVA: 0x7ffaa8932310
        public void OnEnable(){} // RVA: 0x7ffaaf674db0
        public void OnDisable(){} // RVA: 0x7ffaaf674ff0
        public void IsRaycastLocationValid(){} // RVA: 0x7ffaaf6753b0
        // ── Binary Analysis Named ──
        public void GetModifiedMaterial(){} // RVA: 0x7ffaaf675490
    }

    public class MaskUtilities : Object
    {
        // ── Original Methods ──
        public void Notify2DMaskStateChanged(){} // RVA: 0x7ffaaf676e80
        public void NotifyStencilStateChanged(){} // RVA: 0x7ffaaf677200
        public void FindRootSortOverrideCanvas(){} // RVA: 0x7ffaaf677580
        public void IsDescendantOrSelf(){} // RVA: 0x7ffaaf677cf0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetStencilDepth(){} // RVA: 0x7ffaaf677820
        public void GetRectMaskForClippable(){} // RVA: 0x7ffaaf6780e0
        public void GetRectMasksForClip(){} // RVA: 0x7ffaaf678550
    }

    public class MaskableGraphic : Graphic
    {
        public object m_ParentMask; // 0x318C0B40
        public object m_IncludeForMasking; // 0x318C0B40
        public object m_StencilValue; // 0x318C0B40

        // ── Original Methods ──
        public void get_onCullStateChanged(){} // RVA: 0x7ffaa8a8a460
        public void set_onCullStateChanged(){} // RVA: 0x7ffaa8a8a470
        public void get_maskable(){} // RVA: 0x7ffaa89534c0
        public void set_maskable(){} // RVA: 0x7ffaaf675860
        public void get_isMaskingGraphic(){} // RVA: 0x7ffaaea8d770
        public void set_isMaskingGraphic(){} // RVA: 0x7ffaaf675890
        public void Cull(){} // RVA: 0x7ffaaf675ab0
        public void UpdateCull(){} // RVA: 0x7ffaaf675b10
        public void OnEnable(){} // RVA: 0x7ffaaf675e20
        public void OnDisable(){} // RVA: 0x7ffaaf675e80
        public void OnTransformParentChanged(){} // RVA: 0x7ffaaf675f80
        public void ParentMaskStateChanged(){} // RVA: 0x7ffaa8932310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7ffaaf6760f0
        public void get_rootCanvasRect(){} // RVA: 0x7ffaaf676180
        public void UpdateClipParent(){} // RVA: 0x7ffaaf6766e0
        public void RecalculateClipping(){} // RVA: 0x7ffaaf14d130
        public void RecalculateMasking(){} // RVA: 0x7ffaaf676a30
        public void .ctor(){} // RVA: 0x7ffaaf676b10
        public void UnityEngine.UI.IClippable.get_gameObject(){} // RVA: 0x7ffaa8de79e0
        // ── Binary Analysis Named ──
        public void GetModifiedMaterial(){} // RVA: 0x7ffaaf6758a0
        public void SetClipRect(){} // RVA: 0x7ffaaf675cb0
        public void SetClipSoftness(){} // RVA: 0x7ffaaf675da0
    }

    public class Misc : Object
    {
        // ── Original Methods ──
        public void Destroy(){} // RVA: 0x7ffaaf678940
        public void DestroyImmediate(){} // RVA: 0x7ffaaf678b10
    }

    public class MultipleDisplayUtilities : Object
    {
        // ── Original Methods ──
        public void RelativeMouseAtScaled(){} // RVA: 0x7ffaaf678e30
        // ── Binary Analysis Named ──
        public void GetRelativeMousePositionForDrag(){} // RVA: 0x7ffaaf678c20
        public void GetRelativeMousePositionForRaycast(){} // RVA: 0x7ffaaf678d00
    }

    public class Navigation : ValueType
    {
        public object m_SelectOnUp; // 0x3376D620
        public object m_SelectOnRight; // 0x3376D620
        public object m_PressedColor; // 0x33855220

        // ── Original Methods ──
        public void get_mode(){} // RVA: 0x7ffaa9e47550
        public void set_mode(){} // RVA: 0x7ffaa8d92880
        public void get_wrapAround(){} // RVA: 0x7ffaaa412730
        public void set_wrapAround(){} // RVA: 0x7ffaa95cde50
        public void get_selectOnUp(){} // RVA: 0x7ffaa9e47540
        public void set_selectOnUp(){} // RVA: 0x7ffaa9e47560
        public void get_selectOnDown(){} // RVA: 0x7ffaa894d380
        public void set_selectOnDown(){} // RVA: 0x7ffaa8933e30
        public void get_selectOnLeft(){} // RVA: 0x7ffaa89357c0
        public void set_selectOnLeft(){} // RVA: 0x7ffaa8998e80
        public void get_selectOnRight(){} // RVA: 0x7ffaa89600c0
        public void set_selectOnRight(){} // RVA: 0x7ffaa89600d0
        public void get_defaultNavigation(){} // RVA: 0x7ffaaf679760
        public void Equals(){} // RVA: 0x7ffaaf679780
    }

    public class Outline : Shadow
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf697410
        public void ModifyMesh(){} // RVA: 0x7ffaaf697480
    }

    public class PositionAsUV1 : BaseMeshEffect
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void ModifyMesh(){} // RVA: 0x7ffaaf6977b0
    }

    public class RawImage : MaskableGraphic
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf679b60
        public void get_mainTexture(){} // RVA: 0x7ffaaf679b90
        public void get_texture(){} // RVA: 0x7ffaa89b3900
        public void set_texture(){} // RVA: 0x7ffaaf679e50
        public void get_uvRect(){} // RVA: 0x7ffaae455100
        public void set_uvRect(){} // RVA: 0x7ffaaf67a000
        public void OnPopulateMesh(){} // RVA: 0x7ffaaf67a2c0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7ffaaf497fb0
        // ── Binary Analysis Named ──
        public void SetNativeSize(){} // RVA: 0x7ffaaf67a070
    }

    public class RectMask2D : UIBehaviour
    {
        public object m_MaskableTargets; // 0x335D8E60
        public object m_Clippers; // 0x335D8E60
        public object m_Padding; // 0x335D8E60
        public object m_Corners; // 0x335D8E60
        public object padding; // 0x170000E6
        public object softness; // 0x170000E7
        public object Canvas; // 0x170000E8
        public object canvasRect; // 0x170000E9

        // ── Original Methods ──
        public void get_padding(){} // RVA: 0x7ffaa8a42e00
        public void set_padding(){} // RVA: 0x7ffaaf67a750
        public void get_softness(){} // RVA: 0x7ffaae57aec0
        public void set_softness(){} // RVA: 0x7ffaaf67a760
        public void get_Canvas(){} // RVA: 0x7ffaaf67a790
        public void get_canvasRect(){} // RVA: 0x7ffaaf67aa90
        public void get_rectTransform(){} // RVA: 0x7ffaaf67ab10
        public void .ctor(){} // RVA: 0x7ffaaf67abb0
        public void OnEnable(){} // RVA: 0x7ffaaf67afb0
        public void OnDisable(){} // RVA: 0x7ffaaf67b020
        public void OnDestroy(){} // RVA: 0x7ffaaf477720
        public void IsRaycastLocationValid(){} // RVA: 0x7ffaaf67b1b0
        public void get_rootCanvasRect(){} // RVA: 0x7ffaaf67b2c0
        public void PerformClipping(){} // RVA: 0x7ffaaf67b550
        public void UpdateClipSoftness(){} // RVA: 0x7ffaaf67c0e0
        public void AddClippable(){} // RVA: 0x7ffaaf67c4a0
        public void RemoveClippable(){} // RVA: 0x7ffaaf67c650
        public void OnTransformParentChanged(){} // RVA: 0x7ffaaf67c800
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7ffaaf67c800
    }

    public class RectangularVertexClipper : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf477e10
        // ── Binary Analysis Named ──
        public void GetCanvasRect(){} // RVA: 0x7ffaaf477b70
    }

    public class ReflectionMethodsCache : Object
    {
        public object getRaycastNonAlloc; // 0x33CF81B0
        public object getRayIntersectionAllNonAlloc; // 0x33CF81B0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf691fe0
        public void get_Singleton(){} // RVA: 0x7ffaaf693950
    }

    public class ScrollRect : UIBehaviour
    {
        public object m_Vertical; // 0x31A11510
        public object m_Inertia; // 0x31A11510
        public object m_Viewport; // 0x31A11510
        public object m_HorizontalScrollbarVisibility; // 0x31A11510
        public object m_VerticalScrollbarSpacing; // 0x31A11510
        public object m_ContentStartPosition; // 0x31A11510
        public object m_ViewBounds; // 0x31A11510
        public object m_Scrolling; // 0x31A11510
        public object m_PrevViewBounds; // 0x31A11510
        public object m_VSliderExpand; // 0x31A11510
        public object m_Rect; // 0x31A11510
        public object m_Tracker; // 0x31A11510

        // ── Original Methods ──
        public void get_content(){} // RVA: 0x7ffaa89600c0
        public void set_content(){} // RVA: 0x7ffaa89600d0
        public void get_horizontal(){} // RVA: 0x7ffaa8b0edb0
        public void set_horizontal(){} // RVA: 0x7ffaa96574d0
        public void get_vertical(){} // RVA: 0x7ffaa92971f0
        public void set_vertical(){} // RVA: 0x7ffaa9dde1d0
        public void get_movementType(){} // RVA: 0x7ffaa96cc980
        public void set_movementType(){} // RVA: 0x7ffaa9fdb500
        public void get_elasticity(){} // RVA: 0x7ffaa9672970
        public void set_elasticity(){} // RVA: 0x7ffaaa150900
        public void get_inertia(){} // RVA: 0x7ffaa8968c20
        public void set_inertia(){} // RVA: 0x7ffaa896cac0
        public void get_decelerationRate(){} // RVA: 0x7ffaa9144a40
        public void set_decelerationRate(){} // RVA: 0x7ffaa9144ae0
        public void get_scrollSensitivity(){} // RVA: 0x7ffaa9068340
        public void set_scrollSensitivity(){} // RVA: 0x7ffaa9068080
        public void get_viewport(){} // RVA: 0x7ffaa89af740
        public void set_viewport(){} // RVA: 0x7ffaaf67ef80
        public void get_horizontalScrollbar(){} // RVA: 0x7ffaa89ad730
        public void set_horizontalScrollbar(){} // RVA: 0x7ffaaf67efe0
        public void get_verticalScrollbar(){} // RVA: 0x7ffaa89d30e0
        public void set_verticalScrollbar(){} // RVA: 0x7ffaaf67f2d0
        public void get_horizontalScrollbarVisibility(){} // RVA: 0x7ffaa905bf10
        public void set_horizontalScrollbarVisibility(){} // RVA: 0x7ffaaf67f5c0
        public void get_verticalScrollbarVisibility(){} // RVA: 0x7ffaa8b6e710
        public void set_verticalScrollbarVisibility(){} // RVA: 0x7ffaaf67f5d0
        public void get_horizontalScrollbarSpacing(){} // RVA: 0x7ffaa8a42e10
        public void set_horizontalScrollbarSpacing(){} // RVA: 0x7ffaaf67f5e0
        public void get_verticalScrollbarSpacing(){} // RVA: 0x7ffaa895b040
        public void set_verticalScrollbarSpacing(){} // RVA: 0x7ffaaf67f5f0
        public void get_onValueChanged(){} // RVA: 0x7ffaa89add50
        public void set_onValueChanged(){} // RVA: 0x7ffaa89add60
        public void get_viewRect(){} // RVA: 0x7ffaaf67f600
        public void get_velocity(){} // RVA: 0x7ffaaf67f8e0
        public void set_velocity(){} // RVA: 0x7ffaa9feeab0
        public void get_rectTransform(){} // RVA: 0x7ffaaf67f900
        public void .ctor(){} // RVA: 0x7ffaaf67fa50
        public void Rebuild(){} // RVA: 0x7ffaaf67fca0
        public void LayoutComplete(){} // RVA: 0x7ffaa8932310
        public void GraphicUpdateComplete(){} // RVA: 0x7ffaa8932310
        public void UpdateCachedData(){} // RVA: 0x7ffaaf67fd30
        public void OnEnable(){} // RVA: 0x7ffaaf680900
        public void OnDisable(){} // RVA: 0x7ffaaf680bf0
        public void IsActive(){} // RVA: 0x7ffaaf680f70
        public void EnsureLayoutHasRebuilt(){} // RVA: 0x7ffaaf681090
        public void StopMovement(){} // RVA: 0x7ffaaf681140
        public void OnScroll(){} // RVA: 0x7ffaaf6811a0
        public void OnInitializePotentialDrag(){} // RVA: 0x7ffaaf6813b0
        public void OnBeginDrag(){} // RVA: 0x7ffaaf681420
        public void OnEndDrag(){} // RVA: 0x7ffaaf681580
        public void OnDrag(){} // RVA: 0x7ffaaf6815b0
        public void LateUpdate(){} // RVA: 0x7ffaaf6819c0
        public void UpdatePrevData(){} // RVA: 0x7ffaaf682540
        public void UpdateScrollbars(){} // RVA: 0x7ffaaf6826d0
        public void get_normalizedPosition(){} // RVA: 0x7ffaaf6829b0
        public void set_normalizedPosition(){} // RVA: 0x7ffaaf6829f0
        public void get_horizontalNormalizedPosition(){} // RVA: 0x7ffaaf682a50
        public void set_horizontalNormalizedPosition(){} // RVA: 0x7ffaaf682b60
        public void get_verticalNormalizedPosition(){} // RVA: 0x7ffaaf682b80
        public void set_verticalNormalizedPosition(){} // RVA: 0x7ffaaf682ca0
        public void RubberDelta(){} // RVA: 0x7ffaaf683240
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7ffaaf6832a0
        public void get_hScrollingNeeded(){} // RVA: 0x7ffaaf6832b0
        public void get_vScrollingNeeded(){} // RVA: 0x7ffaaf683370
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7ffaa8932310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7ffaa8932310
        public void get_minWidth(){} // RVA: 0x7ffaaef71320
        public void get_preferredWidth(){} // RVA: 0x7ffaaef71320
        public void get_flexibleWidth(){} // RVA: 0x7ffaaef71320
        public void get_minHeight(){} // RVA: 0x7ffaaef71320
        public void get_preferredHeight(){} // RVA: 0x7ffaaef71320
        public void get_flexibleHeight(){} // RVA: 0x7ffaaef71320
        public void get_layoutPriority(){} // RVA: 0x7ffaa8ce12f0
        public void UpdateScrollbarVisibility(){} // RVA: 0x7ffaaf683f90
        public void UpdateOneScrollbarVisibility(){} // RVA: 0x7ffaaf683ff0
        public void UpdateScrollbarLayout(){} // RVA: 0x7ffaaf684250
        public void UpdateBounds(){} // RVA: 0x7ffaaf6846d0
        public void AdjustBounds(){} // RVA: 0x7ffaaf684e00
        public void InternalGetBounds(){} // RVA: 0x7ffaaf6850b0
        public void CalculateOffset(){} // RVA: 0x7ffaaf685350
        public void InternalCalculateOffset(){} // RVA: 0x7ffaaf6853a0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7ffaa8de7a30
        // ── Binary Analysis Named ──
        public void SetContentAnchoredPosition(){} // RVA: 0x7ffaaf681810
        public void SetHorizontalNormalizedPosition(){} // RVA: 0x7ffaaf682b60
        public void SetVerticalNormalizedPosition(){} // RVA: 0x7ffaaf682ca0
        public void SetNormalizedPosition(){} // RVA: 0x7ffaaf682cc0
        public void SetLayoutHorizontal(){} // RVA: 0x7ffaaf683430
        public void SetLayoutVertical(){} // RVA: 0x7ffaaf683dc0
        public void GetBounds(){} // RVA: 0x7ffaaf684eb0
        public void SetDirty(){} // RVA: 0x7ffaaf685560
        public void SetDirtyCaching(){} // RVA: 0x7ffaaf6855e0
    }

    public class Scrollbar : Selectable
    {
        public object m_Value; // 0x3353A870
        public object m_OnValueChanged; // 0x3353A870
        public object m_Tracker; // 0x3353A870
        public object m_DelayedUpdateVisuals; // 0x3353A870
        public object handleRect; // 0x170000EC
        public object direction; // 0x170000ED
        public object value; // 0x170000EE
        public object size; // 0x170000EF

        // ── Original Methods ──
        public void get_handleRect(){} // RVA: 0x7ffaa8f205f0
        public void set_handleRect(){} // RVA: 0x7ffaaf67c870
        public void get_direction(){} // RVA: 0x7ffaa9fb9680
        public void set_direction(){} // RVA: 0x7ffaaf67c8e0
        public void .ctor(){} // RVA: 0x7ffaaf67c940
        public void get_value(){} // RVA: 0x7ffaaf67ca70
        public void set_value(){} // RVA: 0x7ffaaf67cad0
        public void get_size(){} // RVA: 0x7ffaaf490a00
        public void set_size(){} // RVA: 0x7ffaaf67caf0
        public void get_numberOfSteps(){} // RVA: 0x7ffaaf1674f0
        public void set_numberOfSteps(){} // RVA: 0x7ffaaf67cb70
        public void get_onValueChanged(){} // RVA: 0x7ffaa8de7450
        public void set_onValueChanged(){} // RVA: 0x7ffaa8de5d60
        public void get_stepSize(){} // RVA: 0x7ffaaf67cbe0
        public void Rebuild(){} // RVA: 0x7ffaa8932310
        public void LayoutComplete(){} // RVA: 0x7ffaa8932310
        public void GraphicUpdateComplete(){} // RVA: 0x7ffaa8932310
        public void OnEnable(){} // RVA: 0x7ffaaf67cc10
        public void OnDisable(){} // RVA: 0x7ffaaf67cc50
        public void Update(){} // RVA: 0x7ffaaf67cc60
        public void UpdateCachedReferences(){} // RVA: 0x7ffaaf67cc80
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7ffaaf67d0e0
        public void get_axis(){} // RVA: 0x7ffaaf67d120
        public void get_reverseValue(){} // RVA: 0x7ffaaf67d140
        public void UpdateVisuals(){} // RVA: 0x7ffaaf67d160
        public void UpdateDrag(){} // RVA: 0x7ffaaf67d4a0
        public void MayDrag(){} // RVA: 0x7ffaaf67da10
        public void OnBeginDrag(){} // RVA: 0x7ffaaf67da80
        public void OnDrag(){} // RVA: 0x7ffaaf67ddc0
        public void OnPointerDown(){} // RVA: 0x7ffaaf67df00
        public void ClickRepeat(){} // RVA: 0x7ffaaf67e0b0
        public void ClickRepeat(){} // RVA: 0x7ffaaf67e0b0
        public void OnPointerUp(){} // RVA: 0x7ffaaf67e1e0
        public void OnMove(){} // RVA: 0x7ffaaf67e220
        public void FindSelectableOnLeft(){} // RVA: 0x7ffaaf67e8d0
        public void FindSelectableOnRight(){} // RVA: 0x7ffaaf67e900
        public void FindSelectableOnUp(){} // RVA: 0x7ffaaf67e930
        public void FindSelectableOnDown(){} // RVA: 0x7ffaaf67e960
        public void OnInitializePotentialDrag(){} // RVA: 0x7ffaa916cfc0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7ffaa8de7a30
        // ── Binary Analysis Named ──
        public void SetValueWithoutNotify(){} // RVA: 0x7ffaaf67cae0
        public void Set(){} // RVA: 0x7ffaaf67cfa0
        public void DoUpdateDrag(){} // RVA: 0x7ffaaf67d950
        public void SetDirection(){} // RVA: 0x7ffaaf67e990
    }

    public class Selectable : UIBehaviour
    {
        public object m_EnableCalled; // 0x3173B470
        public object m_Colors; // 0x3173B470
        public object m_Interactable; // 0x3173B470
        public object m_CurrentIndex; // 0x3173B470
        public object _hasSelection; // 0x3173B470, was: <hasSelection>k__BackingField
        public object m_WrapAround; // 0x3376D620
        public object m_SelectOnLeft; // 0x3376D620
        public object m_HighlightedColor; // 0x33855220

        // ── Original Methods ──
        public void get_allSelectablesArray(){} // RVA: 0x7ffaaf685780
        public void get_allSelectableCount(){} // RVA: 0x7ffaaf685930
        public void get_allSelectables(){} // RVA: 0x7ffaaf685990
        public void AllSelectablesNoAlloc(){} // RVA: 0x7ffaaf685a30
        public void get_navigation(){} // RVA: 0x7ffaaf685bc0
        public void set_navigation(){} // RVA: 0x7ffaaf685be0
        public void get_transition(){} // RVA: 0x7ffaa8b023d0
        public void set_transition(){} // RVA: 0x7ffaaf685d30
        public void get_colors(){} // RVA: 0x7ffaaf685d90
        public void set_colors(){} // RVA: 0x7ffaaf685dd0
        public void get_spriteState(){} // RVA: 0x7ffaaf685f50
        public void set_spriteState(){} // RVA: 0x7ffaaf685f70
        public void get_animationTriggers(){} // RVA: 0x7ffaa8a4f100
        public void set_animationTriggers(){} // RVA: 0x7ffaaf6860a0
        public void get_targetGraphic(){} // RVA: 0x7ffaa89b3900
        public void set_targetGraphic(){} // RVA: 0x7ffaaf686100
        public void get_interactable(){} // RVA: 0x7ffaa97ef160
        public void set_interactable(){} // RVA: 0x7ffaaf686160
        public void get_isPointerInside(){} // RVA: 0x7ffaa89b3ad0
        public void set_isPointerInside(){} // RVA: 0x7ffaa89b3ae0
        public void get_isPointerDown(){} // RVA: 0x7ffaa98b1d50
        public void set_isPointerDown(){} // RVA: 0x7ffaa98c11a0
        public void get_hasSelection(){} // RVA: 0x7ffaa98b8b50
        public void set_hasSelection(){} // RVA: 0x7ffaa98b8e60
        public void .ctor(){} // RVA: 0x7ffaaf6863f0
        public void get_image(){} // RVA: 0x7ffaaf686680
        public void set_image(){} // RVA: 0x7ffaa89b3910
        public void get_animator(){} // RVA: 0x7ffaaf686710
        public void Awake(){} // RVA: 0x7ffaaf686750
        public void OnCanvasGroupChanged(){} // RVA: 0x7ffaaf686890
        public void ParentGroupAllowsInteraction(){} // RVA: 0x7ffaaf6868d0
        public void IsInteractable(){} // RVA: 0x7ffaaf686b10
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7ffaaf686b30
        public void OnEnable(){} // RVA: 0x7ffaaf686b40
        public void OnTransformParentChanged(){} // RVA: 0x7ffaa9cf9d80
        public void OnSetProperty(){} // RVA: 0x7ffaaf687070
        public void OnDisable(){} // RVA: 0x7ffaaf6870f0
        public void OnApplicationFocus(){} // RVA: 0x7ffaaf687270
        public void get_currentSelectionState(){} // RVA: 0x7ffaaf6872e0
        public void InstantClearState(){} // RVA: 0x7ffaaf687350
        public void FindSelectable(){} // RVA: 0x7ffaaf687700
        public void Navigate(){} // RVA: 0x7ffaaf6883d0
        public void FindSelectableOnLeft(){} // RVA: 0x7ffaaf688520
        public void FindSelectableOnRight(){} // RVA: 0x7ffaaf688690
        public void FindSelectableOnUp(){} // RVA: 0x7ffaaf688800
        public void FindSelectableOnDown(){} // RVA: 0x7ffaaf688970
        public void OnMove(){} // RVA: 0x7ffaaf688ae0
        public void StartColorTween(){} // RVA: 0x7ffaaf688b90
        public void TriggerAnimation(){} // RVA: 0x7ffaaf688e10
        public void IsHighlighted(){} // RVA: 0x7ffaaf689120
        public void IsPressed(){} // RVA: 0x7ffaaf689190
        public void EvaluateAndTransitionToSelectionState(){} // RVA: 0x7ffaaf6891e0
        public void OnPointerDown(){} // RVA: 0x7ffaaf689250
        public void OnPointerUp(){} // RVA: 0x7ffaaf6893f0
        public void OnPointerEnter(){} // RVA: 0x7ffaaf689420
        public void OnPointerExit(){} // RVA: 0x7ffaaf689430
        public void OnSelect(){} // RVA: 0x7ffaaf689440
        public void OnDeselect(){} // RVA: 0x7ffaaf689450
        public void Select(){} // RVA: 0x7ffaaf689460
        public void .cctor(){} // RVA: 0x7ffaaf689600
        // ── Binary Analysis Named ──
        public void DoStateTransition(){} // RVA: 0x7ffaaf6873e0
        public void GetPointOnRectEdge(){} // RVA: 0x7ffaaf6880c0
        public void DoSpriteSwap(){} // RVA: 0x7ffaaf688d00
    }

    public class SetPropertyUtility : Object
    {
        // ── Binary Analysis Named ──
        public void SetColor(){} // RVA: 0x7ffaaf1a9740
        public void SetStruct(){} // RVA: 0x7ffaa887e5c0
        public void SetClass(){} // RVA: 0x7ffaa887e5c0
    }

    public class Shadow : BaseMeshEffect
    {
        public object m_UseGraphicAlpha; // 0x337A6940

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf697410
        public void get_effectColor(){} // RVA: 0x7ffaa95ffd80
        public void set_effectColor(){} // RVA: 0x7ffaaf697900
        public void get_effectDistance(){} // RVA: 0x7ffaa99c9a50
        public void set_effectDistance(){} // RVA: 0x7ffaaf697a10
        public void get_useGraphicAlpha(){} // RVA: 0x7ffaa89edc00
        public void set_useGraphicAlpha(){} // RVA: 0x7ffaaf697bd0
        public void ApplyShadowZeroAlloc(){} // RVA: 0x7ffaaf697ce0
        public void ApplyShadow(){} // RVA: 0x7ffaaf6980f0
        public void ModifyMesh(){} // RVA: 0x7ffaaf698100
    }

    public class Slider : Selectable
    {
        public object m_Direction; // 0x3358A650
        public object m_WholeNumbers; // 0x3358A650
        public object m_FillImage; // 0x3358A650
        public object m_HandleTransform; // 0x3358A650
        public object m_Tracker; // 0x3358A650

        // ── Original Methods ──
        public void get_fillRect(){} // RVA: 0x7ffaa8f205f0
        public void set_fillRect(){} // RVA: 0x7ffaaf6896d0
        public void get_handleRect(){} // RVA: 0x7ffaa9102670
        public void set_handleRect(){} // RVA: 0x7ffaaf689740
        public void get_direction(){} // RVA: 0x7ffaa936f8e0
        public void set_direction(){} // RVA: 0x7ffaaf6897b0
        public void get_minValue(){} // RVA: 0x7ffaaf13be30
        public void set_minValue(){} // RVA: 0x7ffaaf689810
        public void get_maxValue(){} // RVA: 0x7ffaae628750
        public void set_maxValue(){} // RVA: 0x7ffaaf689890
        public void get_wholeNumbers(){} // RVA: 0x7ffaaf689910
        public void set_wholeNumbers(){} // RVA: 0x7ffaaf689920
        public void get_value(){} // RVA: 0x7ffaaf6899a0
        public void set_value(){} // RVA: 0x7ffaaf6899c0
        public void get_normalizedValue(){} // RVA: 0x7ffaaf689a00
        public void set_normalizedValue(){} // RVA: 0x7ffaaf689ab0
        public void get_onValueChanged(){} // RVA: 0x7ffaa8f78450
        public void set_onValueChanged(){} // RVA: 0x7ffaa93ff110
        public void get_stepSize(){} // RVA: 0x7ffaaf689b00
        public void .ctor(){} // RVA: 0x7ffaaf689b30
        public void Rebuild(){} // RVA: 0x7ffaa8932310
        public void LayoutComplete(){} // RVA: 0x7ffaa8932310
        public void GraphicUpdateComplete(){} // RVA: 0x7ffaa8932310
        public void OnEnable(){} // RVA: 0x7ffaaf689c60
        public void OnDisable(){} // RVA: 0x7ffaaf67cc50
        public void Update(){} // RVA: 0x7ffaaf689cb0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7ffaaf689d00
        public void UpdateCachedReferences(){} // RVA: 0x7ffaaf68a120
        public void ClampValue(){} // RVA: 0x7ffaaf68ab70
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7ffaaf68ac90
        public void get_axis(){} // RVA: 0x7ffaaf68acd0
        public void get_reverseValue(){} // RVA: 0x7ffaaf68acf0
        public void UpdateVisuals(){} // RVA: 0x7ffaaf68ad10
        public void UpdateDrag(){} // RVA: 0x7ffaaf68b330
        public void MayDrag(){} // RVA: 0x7ffaaf67da10
        public void OnPointerDown(){} // RVA: 0x7ffaaf68b690
        public void OnDrag(){} // RVA: 0x7ffaaf68b970
        public void OnMove(){} // RVA: 0x7ffaaf68b9f0
        public void FindSelectableOnLeft(){} // RVA: 0x7ffaaf68bff0
        public void FindSelectableOnRight(){} // RVA: 0x7ffaaf68c020
        public void FindSelectableOnUp(){} // RVA: 0x7ffaaf68c050
        public void FindSelectableOnDown(){} // RVA: 0x7ffaaf68c080
        public void OnInitializePotentialDrag(){} // RVA: 0x7ffaa916cfc0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7ffaa8de7a30
        // ── Binary Analysis Named ──
        public void SetValueWithoutNotify(){} // RVA: 0x7ffaaf6899e0
        public void Set(){} // RVA: 0x7ffaaf68aba0
        public void SetDirection(){} // RVA: 0x7ffaaf68c0b0
    }

    public class SpriteState : ValueType
    {
        public object m_SelectedSprite; // 0x335198C0

        // ── Original Methods ──
        public void get_highlightedSprite(){} // RVA: 0x7ffaa950bda0
        public void set_highlightedSprite(){} // RVA: 0x7ffaa930eca0
        public void get_pressedSprite(){} // RVA: 0x7ffaa9e47540
        public void set_pressedSprite(){} // RVA: 0x7ffaa9e47560
        public void get_selectedSprite(){} // RVA: 0x7ffaa894d380
        public void set_selectedSprite(){} // RVA: 0x7ffaa8933e30
        public void get_disabledSprite(){} // RVA: 0x7ffaa89357c0
        public void set_disabledSprite(){} // RVA: 0x7ffaa8998e80
        public void Equals(){} // RVA: 0x7ffaaf68c3a0
    }

    public class StencilMaterial : Object
    {
        // ── Original Methods ──
        public void Add(){} // RVA: 0x7ffaaf68c8e0
        public void Add(){} // RVA: 0x7ffaaf68c8e0
        public void LogWarningWhenNotInBatchmode(){} // RVA: 0x7ffaaf68c810
        public void Add(){} // RVA: 0x7ffaaf68c8e0
        public void Remove(){} // RVA: 0x7ffaaf68d4c0
        public void ClearAll(){} // RVA: 0x7ffaaf68d7c0
        public void .cctor(){} // RVA: 0x7ffaaf68d9c0
    }

    public class Text : MaskableGraphic
    {
        public object m_TextCache; // 0x33754D00
        public object m_DisableFontTextureRebuiltCallback; // 0x33754D00

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf68dab0
        public void get_cachedTextGenerator(){} // RVA: 0x7ffaaf68dc50
        public void get_cachedTextGeneratorForLayout(){} // RVA: 0x7ffaaf68dd50
        public void get_mainTexture(){} // RVA: 0x7ffaaf68de10
        public void FontTextureChanged(){} // RVA: 0x7ffaaf68e230
        public void get_font(){} // RVA: 0x7ffaaf68e3d0
        public void set_font(){} // RVA: 0x7ffaaf68e3f0
        public void get_text(){} // RVA: 0x7ffaa89b3970
        public void set_text(){} // RVA: 0x7ffaaf68e680
        public void get_supportRichText(){} // RVA: 0x7ffaaf68e860
        public void set_supportRichText(){} // RVA: 0x7ffaaf68e880
        public void get_resizeTextForBestFit(){} // RVA: 0x7ffaaf68e8e0
        public void set_resizeTextForBestFit(){} // RVA: 0x7ffaaf68e900
        public void get_resizeTextMinSize(){} // RVA: 0x7ffaaf68e960
        public void set_resizeTextMinSize(){} // RVA: 0x7ffaaf68e980
        public void get_resizeTextMaxSize(){} // RVA: 0x7ffaaf68e9e0
        public void set_resizeTextMaxSize(){} // RVA: 0x7ffaaf68ea00
        public void get_alignment(){} // RVA: 0x7ffaaf68ea60
        public void set_alignment(){} // RVA: 0x7ffaaf68ea80
        public void get_alignByGeometry(){} // RVA: 0x7ffaaf68eae0
        public void set_alignByGeometry(){} // RVA: 0x7ffaaf68eb00
        public void get_fontSize(){} // RVA: 0x7ffaaf68eb40
        public void set_fontSize(){} // RVA: 0x7ffaaf68eb60
        public void get_horizontalOverflow(){} // RVA: 0x7ffaaf68ebc0
        public void set_horizontalOverflow(){} // RVA: 0x7ffaaf68ebe0
        public void get_verticalOverflow(){} // RVA: 0x7ffaaf68ec40
        public void set_verticalOverflow(){} // RVA: 0x7ffaaf68ec60
        public void get_lineSpacing(){} // RVA: 0x7ffaaf68ecc0
        public void set_lineSpacing(){} // RVA: 0x7ffaaf68ece0
        public void get_fontStyle(){} // RVA: 0x7ffaaf68ed50
        public void set_fontStyle(){} // RVA: 0x7ffaaf68ed70
        public void get_pixelsPerUnit(){} // RVA: 0x7ffaaf68edd0
        public void OnEnable(){} // RVA: 0x7ffaaf68f0c0
        public void OnDisable(){} // RVA: 0x7ffaaf68f170
        public void UpdateGeometry(){} // RVA: 0x7ffaaf68f1d0
        public void AssignDefaultFont(){} // RVA: 0x7ffaaf68f2e0
        public void AssignDefaultFontIfNecessary(){} // RVA: 0x7ffaaf68f340
        public void OnPopulateMesh(){} // RVA: 0x7ffaaf68f950
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7ffaa8932310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7ffaa8932310
        public void get_minWidth(){} // RVA: 0x7ffaa916f990
        public void get_preferredWidth(){} // RVA: 0x7ffaaf690160
        public void get_flexibleWidth(){} // RVA: 0x7ffaaef71320
        public void get_minHeight(){} // RVA: 0x7ffaa916f990
        public void get_preferredHeight(){} // RVA: 0x7ffaaf690290
        public void get_flexibleHeight(){} // RVA: 0x7ffaaef71320
        public void get_layoutPriority(){} // RVA: 0x7ffaa8f22da0
        // ── Binary Analysis Named ──
        public void GetGenerationSettings(){} // RVA: 0x7ffaaf68f460
        public void GetTextAnchorPivot(){} // RVA: 0x7ffaaf68f7e0
    }

    public class Toggle : Selectable
    {
        public object m_Group; // 0x335615C0

        // ── Original Methods ──
        public void get_group(){} // RVA: 0x7ffaa8f76f40
        public void set_group(){} // RVA: 0x7ffaaf6903a0
        public void .ctor(){} // RVA: 0x7ffaaf6903d0
        public void Rebuild(){} // RVA: 0x7ffaa8932310
        public void LayoutComplete(){} // RVA: 0x7ffaa8932310
        public void GraphicUpdateComplete(){} // RVA: 0x7ffaa8932310
        public void OnDestroy(){} // RVA: 0x7ffaaf6904b0
        public void OnEnable(){} // RVA: 0x7ffaaf6905a0
        public void OnDisable(){} // RVA: 0x7ffaaf6905e0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7ffaaf690610
        public void get_isOn(){} // RVA: 0x7ffaae1aaaf0
        public void set_isOn(){} // RVA: 0x7ffaaf690a80
        public void PlayEffect(){} // RVA: 0x7ffaaf690ce0
        public void Start(){} // RVA: 0x7ffaaf690e10
        public void InternalToggle(){} // RVA: 0x7ffaaf690e20
        public void OnPointerClick(){} // RVA: 0x7ffaaf690e80
        public void OnSubmit(){} // RVA: 0x7ffaaf690e20
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7ffaa8de7a30
        // ── Binary Analysis Named ──
        public void SetToggleGroup(){} // RVA: 0x7ffaaf6907a0
        public void SetIsOnWithoutNotify(){} // RVA: 0x7ffaaf690a90
        public void Set(){} // RVA: 0x7ffaaf690aa0
    }

    public class ToggleGroup : UIBehaviour
    {
        // ── Original Methods ──
        public void get_allowSwitchOff(){} // RVA: 0x7ffaa8a209d0
        public void set_allowSwitchOff(){} // RVA: 0x7ffaa8a209e0
        public void .ctor(){} // RVA: 0x7ffaaf690f90
        public void Start(){} // RVA: 0x7ffaaf691090
        public void OnEnable(){} // RVA: 0x7ffaaf691090
        public void ValidateToggleIsInGroup(){} // RVA: 0x7ffaaf6910a0
        public void NotifyToggleOn(){} // RVA: 0x7ffaaf691260
        public void UnregisterToggle(){} // RVA: 0x7ffaaf691480
        public void RegisterToggle(){} // RVA: 0x7ffaaf691500
        public void EnsureValidState(){} // RVA: 0x7ffaaf6915c0
        public void AnyTogglesOn(){} // RVA: 0x7ffaaf6919b0
        public void ActiveToggles(){} // RVA: 0x7ffaaf691be0
        // ── Binary Analysis Named ──
        public void GetFirstActiveToggle(){} // RVA: 0x7ffaaf691d50
        public void SetAllTogglesOff(){} // RVA: 0x7ffaaf691dd0
    }

    public class VertexHelper : Object
    {
        public object m_Uv0S; // 0x33AB7820
        public object m_Uv3S; // 0x33AB7820
        public object m_Indices; // 0x33AB7820
        public object m_ListsInitalized; // 0x33AB7820
        public object currentVertCount; // 0x17000152
        public object currentIndexCount; // 0x17000153

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf694400
        public void .ctor(){} // RVA: 0x7ffaaf694400
        public void InitializeListIfRequired(){} // RVA: 0x7ffaaf694750
        public void Dispose(){} // RVA: 0x7ffaaf694c90
        public void Clear(){} // RVA: 0x7ffaaf6951b0
        public void get_currentVertCount(){} // RVA: 0x7ffaaf6952b0
        public void get_currentIndexCount(){} // RVA: 0x7ffaaf695300
        public void PopulateUIVertex(){} // RVA: 0x7ffaaf695350
        public void FillMesh(){} // RVA: 0x7ffaaf6959b0
        public void AddVert(){} // RVA: 0x7ffaaf696570
        public void AddVert(){} // RVA: 0x7ffaaf696570
        public void AddVert(){} // RVA: 0x7ffaaf696570
        public void AddVert(){} // RVA: 0x7ffaaf696570
        public void AddTriangle(){} // RVA: 0x7ffaaf696620
        public void AddUIVertexQuad(){} // RVA: 0x7ffaaf696790
        public void AddUIVertexStream(){} // RVA: 0x7ffaaf696a50
        public void AddUIVertexTriangleStream(){} // RVA: 0x7ffaaf696bd0
        public void .cctor(){} // RVA: 0x7ffaaf696d60
        // ── Binary Analysis Named ──
        public void SetUIVertex(){} // RVA: 0x7ffaaf6955a0
        public void GetUIVertexStream(){} // RVA: 0x7ffaaf696c50
    }

    public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf66cc50
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7ffaaf674a00
        public void CalculateLayoutInputVertical(){} // RVA: 0x7ffaaf674a30
        // ── Binary Analysis Named ──
        public void SetLayoutHorizontal(){} // RVA: 0x7ffaaf674a40
        public void SetLayoutVertical(){} // RVA: 0x7ffaaf674a50
    }

}