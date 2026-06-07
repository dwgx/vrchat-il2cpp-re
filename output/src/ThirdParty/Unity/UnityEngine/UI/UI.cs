// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UI
// Classes: 66
// Methods: 1219

namespace ThirdParty.Unity.UnityEngine.UI
{
    public class AnimationTriggers
    {
        // ── Methods ──
        public void get_normalTrigger(){} // RVA: 0x2F8380
        public void set_normalTrigger(){} // RVA: 0x2DEE30
        public void get_highlightedTrigger(){} // RVA: 0x2E07C0
        public void set_highlightedTrigger(){} // RVA: 0x343E80
        public void get_pressedTrigger(){} // RVA: 0x30B0C0
        public void set_pressedTrigger(){} // RVA: 0x30B0D0
        public void get_selectedTrigger(){} // RVA: 0x30B130
        public void set_selectedTrigger(){} // RVA: 0x2DEE90
        public void get_disabledTrigger(){} // RVA: 0x6374D0
        public void set_disabledTrigger(){} // RVA: 0x30B890
        public void .ctor(){} // RVA: 0x72BA740
    }

    public class AspectRatioFitter
    {
        // ── Methods ──
        public void get_aspectMode(){} // RVA: 0x760030
        public void set_aspectMode(){} // RVA: 0x74B0560
        public void get_aspectRatio(){} // RVA: 0x44AF50
        public void set_aspectRatio(){} // RVA: 0x74B05C0
        public void get_rectTransform(){} // RVA: 0x74B0620
        public void .ctor(){} // RVA: 0x4801C0
        public void OnEnable(){} // RVA: 0x74B0760
        public void Start(){} // RVA: 0x74B08A0
        public void OnDisable(){} // RVA: 0x74B0920
        public void OnTransformParentChanged(){} // RVA: 0x74B0980
        public void Update(){} // RVA: 0x74B0AC0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x74B0AE0
        public void UpdateRect(){} // RVA: 0x74B0AF0
        public void GetSizeDeltaToProduceSize(){} // RVA: 0x74B0EE0
        public void GetParentSize(){} // RVA: 0x74B1150
        public void SetLayoutHorizontal(){} // RVA: 0x2DD310
        public void SetLayoutVertical(){} // RVA: 0x2DD310
        public void SetDirty(){} // RVA: 0x74B0AE0
        public void IsComponentValidOnObject(){} // RVA: 0x74B1350
        public void IsAspectModeValid(){} // RVA: 0x74B1520
        public void DoesParentExists(){} // RVA: 0x303470
    }

    public class BaseMeshEffect
    {
        // ── Methods ──
        public void get_graphic(){} // RVA: 0x74DD5E0
        public void OnEnable(){} // RVA: 0x74DD720
        public void OnDisable(){} // RVA: 0x74DD820
        public void OnDidApplyAnimationProperties(){} // RVA: 0x74DD920
        public void ModifyMesh(){} // RVA: 0x24B10 | overloaded x2
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class BaseVertexEffect
    {
        // ── Methods ──
        public void ModifyVertices(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Button
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72BA990
        public void get_onClick(){} // RVA: 0xA94E10
        public void set_onClick(){} // RVA: 0xCF6DE0
        public void Press(){} // RVA: 0x72BAAD0
        public void OnPointerClick(){} // RVA: 0x72BAB70
        public void OnSubmit(){} // RVA: 0x72BABA0
        public void OnFinishSubmit(){} // RVA: 0x72BACB0
    }

    public class CanvasScaler
    {
        // ── Methods ──
        public void get_uiScaleMode(){} // RVA: 0x760030
        public void set_uiScaleMode(){} // RVA: 0x99E0D0
        public void get_referencePixelsPerUnit(){} // RVA: 0x44AF50
        public void set_referencePixelsPerUnit(){} // RVA: 0x44AF60
        public void get_scaleFactor(){} // RVA: 0x3BC210
        public void set_scaleFactor(){} // RVA: 0x74B1540
        public void get_referenceResolution(){} // RVA: 0x74B1560
        public void set_referenceResolution(){} // RVA: 0x74B1580
        public void get_screenMatchMode(){} // RVA: 0x4C6670
        public void set_screenMatchMode(){} // RVA: 0x4C5F20
        public void get_matchWidthOrHeight(){} // RVA: 0x4FE250
        public void set_matchWidthOrHeight(){} // RVA: 0x4FB970
        public void get_physicalUnit(){} // RVA: 0x891AF0
        public void set_physicalUnit(){} // RVA: 0x1CB95F0
        public void get_fallbackScreenDPI(){} // RVA: 0x7D0490
        public void set_fallbackScreenDPI(){} // RVA: 0x7D04A0
        public void get_defaultSpriteDPI(){} // RVA: 0x2E5970
        public void set_defaultSpriteDPI(){} // RVA: 0x74B1600
        public void get_dynamicPixelsPerUnit(){} // RVA: 0xEBB900
        public void set_dynamicPixelsPerUnit(){} // RVA: 0xEBB7C0
        public void .ctor(){} // RVA: 0x74B1620
        public void OnEnable(){} // RVA: 0x74B16B0
        public void Canvas_preWillRenderCanvases(){} // RVA: 0x1CE9460
        public void OnDisable(){} // RVA: 0x74B17B0
        public void Handle(){} // RVA: 0x74B1880
        public void HandleWorldCanvas(){} // RVA: 0x74B1A90
        public void HandleConstantPixelSize(){} // RVA: 0x74B1B00
        public void HandleScaleWithScreenSize(){} // RVA: 0x74B1B70
        public void HandleConstantPhysicalSize(){} // RVA: 0x74B1E30
        public void SetScaleFactor(){} // RVA: 0x74B1F50
        public void SetReferencePixelsPerUnit(){} // RVA: 0x74B1F90
    }

    public class CanvasUpdateRegistry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72BAF40
        public void get_instance(){} // RVA: 0x72BB210
        public void ObjectValidForUpdate(){} // RVA: 0x72BB330
        public void CleanInvalidItems(){} // RVA: 0x72BB4A0
        public void PerformUpdate(){} // RVA: 0x72BB670
        public void ParentCount(){} // RVA: 0x72BBDE0
        public void SortLayoutList(){} // RVA: 0x72BBFE0
        public void RegisterCanvasElementForLayoutRebuild(){} // RVA: 0x72BC0A0
        public void TryRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x72BC110
        public void InternalRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x72BC180
        public void RegisterCanvasElementForGraphicRebuild(){} // RVA: 0x72BC240
        public void TryRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x72BC2B0
        public void InternalRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x72BC320
        public void UnRegisterCanvasElementForRebuild(){} // RVA: 0x72BC430
        public void DisableCanvasElementForRebuild(){} // RVA: 0x72BC720
        public void InternalUnRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x72BCA10
        public void InternalUnRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x72BCB70
        public void InternalDisableCanvasElementForLayoutRebuild(){} // RVA: 0x72BCCD0
        public void InternalDisableCanvasElementForGraphicRebuild(){} // RVA: 0x72BCE30
        public void IsRebuildingLayout(){} // RVA: 0x72BCF90
        public void IsRebuildingGraphics(){} // RVA: 0x72BCFF0
        public void .cctor(){} // RVA: 0x72BD050
    }

    public class ClipperRegistry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72BDA30
        public void get_instance(){} // RVA: 0x72BDAF0
        public void Cull(){} // RVA: 0x72BDC70
        public void Register(){} // RVA: 0x72BDE50
        public void Unregister(){} // RVA: 0x72BDEC0
        public void Disable(){} // RVA: 0x72BDF20
    }

    public class Clipping
    {
        // ── Methods ──
        public void FindCullAndClipWorldRect(){} // RVA: 0x72BDF80
    }

    public class ColorBlock
    {
        // ── Methods ──
        public void get_normalColor(){} // RVA: 0x75E7E0
        public void set_normalColor(){} // RVA: 0x1A53740
        public void get_highlightedColor(){} // RVA: 0x196ABE0
        public void set_highlightedColor(){} // RVA: 0x196ABF0
        public void get_pressedColor(){} // RVA: 0x1EFB630
        public void set_pressedColor(){} // RVA: 0x5BD97C0
        public void get_selectedColor(){} // RVA: 0x5CC8940
        public void set_selectedColor(){} // RVA: 0x5CC8950
        public void get_disabledColor(){} // RVA: 0x1FA6340
        public void set_disabledColor(){} // RVA: 0x4469B20
        public void get_colorMultiplier(){} // RVA: 0x345460
        public void set_colorMultiplier(){} // RVA: 0x345470
        public void get_fadeDuration(){} // RVA: 0x862910
        public void set_fadeDuration(){} // RVA: 0x863060
        public void .cctor(){} // RVA: 0x72BD130
        public void Equals(){} // RVA: 0x72BD540 | overloaded x2
        public void op_Equality(){} // RVA: 0x72BD840
        public void op_Inequality(){} // RVA: 0x72BD8F0
        public void GetHashCode(){} // RVA: 0x72BD9A0
    }

    public class ContentSizeFitter
    {
        // ── Methods ──
        public void get_horizontalFit(){} // RVA: 0x760030
        public void set_horizontalFit(){} // RVA: 0x74B1FD0
        public void get_verticalFit(){} // RVA: 0xCEF5B0
        public void set_verticalFit(){} // RVA: 0x74B2030
        public void get_rectTransform(){} // RVA: 0x74B2090
        public void .ctor(){} // RVA: 0x2DDD50
        public void OnEnable(){} // RVA: 0x74B21D0
        public void OnDisable(){} // RVA: 0x74B21E0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x74B21D0
        public void HandleSelfFittingAlongAxis(){} // RVA: 0x74B2240
        public void SetLayoutHorizontal(){} // RVA: 0x74B22E0
        public void SetLayoutVertical(){} // RVA: 0x74B2350
        public void SetDirty(){} // RVA: 0x74B23C0
    }

    public class DefaultControls
    {
        // ── Methods ──
        public void get_factory(){} // RVA: 0x72BE6C0
        public void CreateUIElementRoot(){} // RVA: 0x72BE720
        public void CreateUIObject(){} // RVA: 0x72BE870
        public void SetDefaultTextValues(){} // RVA: 0x72BE960
        public void SetDefaultColorTransitionValues(){} // RVA: 0x72BEAF0
        public void SetParentAndAlign(){} // RVA: 0x72BEB50
        public void SetLayerRecursively(){} // RVA: 0x72BED50
        public void CreatePanel(){} // RVA: 0x72BEF60
        public void CreateButton(){} // RVA: 0x72BF460
        public void CreateText(){} // RVA: 0x72BFB90
        public void CreateImage(){} // RVA: 0x72BFDA0
        public void CreateRawImage(){} // RVA: 0x72BFF40
        public void CreateSlider(){} // RVA: 0x72C00E0
        public void CreateScrollbar(){} // RVA: 0x72C0F60
        public void CreateToggle(){} // RVA: 0x72C1830
        public void CreateInputField(){} // RVA: 0x72C23D0
        public void CreateDropdown(){} // RVA: 0x72C2F60
        public void CreateScrollView(){} // RVA: 0x72C52B0
        public void .cctor(){} // RVA: 0x72C64E0
    }

    public class Dropdown
    {
        // ── Methods ──
        public void get_template(){} // RVA: 0xA94E10
        public void set_template(){} // RVA: 0x72C6760
        public void get_captionText(){} // RVA: 0xA902E0
        public void set_captionText(){} // RVA: 0x72C67C0
        public void get_captionImage(){} // RVA: 0x507710
        public void set_captionImage(){} // RVA: 0x72C6820
        public void get_itemText(){} // RVA: 0x507D10
        public void set_itemText(){} // RVA: 0x72C6880
        public void get_itemImage(){} // RVA: 0x59E660
        public void set_itemImage(){} // RVA: 0x72C68E0
        public void get_options(){} // RVA: 0x72C6940
        public void set_options(){} // RVA: 0x72C6960
        public void get_onValueChanged(){} // RVA: 0xA933D0
        public void set_onValueChanged(){} // RVA: 0xA96DC0
        public void get_alphaFadeSpeed(){} // RVA: 0x72C69E0
        public void set_alphaFadeSpeed(){} // RVA: 0x72C69F0
        public void get_value(){} // RVA: 0x627A640
        public void set_value(){} // RVA: 0x72C6A00
        public void SetValueWithoutNotify(){} // RVA: 0x72C6A10
        public void Set(){} // RVA: 0x72C6A20
        public void .ctor(){} // RVA: 0x72C6BA0
        public void Awake(){} // RVA: 0x72C6DD0
        public void Start(){} // RVA: 0x72C70E0
        public void OnDisable(){} // RVA: 0x72C7210
        public void RefreshShownValue(){} // RVA: 0x72C7370
        public void AddOptions(){} // RVA: 0x72C79A0 | overloaded x3
        public void ClearOptions(){} // RVA: 0x72C7B70
        public void SetupTemplate(){} // RVA: 0x72C7BF0
        public void GetOrAddComponent(){} // RVA: 0x283FA0
        public void OnPointerClick(){} // RVA: 0x72C8A20
        public void OnSubmit(){} // RVA: 0x72C8A20
        public void OnCancel(){} // RVA: 0x72C8A30
        public void Show(){} // RVA: 0x72C8A40
        public void CreateBlocker(){} // RVA: 0x72CA2D0
        public void DestroyBlocker(){} // RVA: 0x72CAE50
        public void CreateDropdownList(){} // RVA: 0x72CAEA0
        public void DestroyDropdownList(){} // RVA: 0x72CAF10
        public void CreateItem(){} // RVA: 0x72CAF60
        public void DestroyItem(){} // RVA: 0x2DD310
        public void AddItem(){} // RVA: 0x72CAFD0
        public void AlphaFadeList(){} // RVA: 0x72CB760 | overloaded x2
        public void SetAlpha(){} // RVA: 0x72CB920
        public void Hide(){} // RVA: 0x72CBA40
        public void DelayedDestroyDropdownList(){} // RVA: 0x72CBDD0
        public void ImmediateDestroyDropdownList(){} // RVA: 0x72CBE90
        public void OnSelectItem(){} // RVA: 0x72CC180
        public void .cctor(){} // RVA: 0x72CC410
    }

    public class FontData
    {
        // ── Methods ──
        public void get_defaultFontData(){} // RVA: 0x72CC8C0
        public void get_font(){} // RVA: 0x2F8380
        public void set_font(){} // RVA: 0x2DEE30
        public void get_fontSize(){} // RVA: 0x5BED50
        public void set_fontSize(){} // RVA: 0x6374E0
        public void get_fontStyle(){} // RVA: 0x197C3B0
        public void set_fontStyle(){} // RVA: 0x1989FD0
        public void get_bestFit(){} // RVA: 0x3CB9D0
        public void set_bestFit(){} // RVA: 0x3CB9E0
        public void get_minSize(){} // RVA: 0xCEF5B0
        public void set_minSize(){} // RVA: 0x16E1F00
        public void get_maxSize(){} // RVA: 0x791DC0
        public void set_maxSize(){} // RVA: 0xA53440
        public void get_alignment(){} // RVA: 0x1209F00
        public void set_alignment(){} // RVA: 0x1AFCF60
        public void get_alignByGeometry(){} // RVA: 0x303450
        public void set_alignByGeometry(){} // RVA: 0x303460
        public void get_richText(){} // RVA: 0x303470
        public void set_richText(){} // RVA: 0x303480
        public void get_horizontalOverflow(){} // RVA: 0x4C6670
        public void set_horizontalOverflow(){} // RVA: 0x4C5F20
        public void get_verticalOverflow(){} // RVA: 0xFDC9F0
        public void set_verticalOverflow(){} // RVA: 0xFDD6E0
        public void get_lineSpacing(){} // RVA: 0x9FC6D0
        public void set_lineSpacing(){} // RVA: 0x9FC6C0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x72CC930
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class FontUpdateTracker
    {
        // ── Methods ──
        public void TrackText(){} // RVA: 0x72CC980
        public void RebuildForFont(){} // RVA: 0x72CCDC0
        public void UntrackText(){} // RVA: 0x72CCF80
        public void .cctor(){} // RVA: 0x72CD350
    }

    public class Graphic
    {
        // ── Methods ──
        public void get_defaultGraphicMaterial(){} // RVA: 0x72CD430
        public void get_color(){} // RVA: 0x111F520
        public void set_color(){} // RVA: 0x72CD610
        public void get_raycastTarget(){} // RVA: 0x14CEB40
        public void set_raycastTarget(){} // RVA: 0x72CD680
        public void get_raycastPadding(){} // RVA: 0x61AF7C0
        public void set_raycastPadding(){} // RVA: 0x61AF7D0
        public void get_useLegacyMeshGeneration(){} // RVA: 0x1B6CD50
        public void set_useLegacyMeshGeneration(){} // RVA: 0xB70090
        public void .ctor(){} // RVA: 0x72CD790
        public void SetAllDirty(){} // RVA: 0x72CD920
        public void SetLayoutDirty(){} // RVA: 0x72CD990
        public void SetVerticesDirty(){} // RVA: 0x72CDA30
        public void SetMaterialDirty(){} // RVA: 0x72CDAC0
        public void SetRaycastDirty(){} // RVA: 0x72CDB60
        public void OnRectTransformDimensionsChange(){} // RVA: 0x72CDC80
        public void OnBeforeTransformParentChanged(){} // RVA: 0x72CDDF0
        public void OnTransformParentChanged(){} // RVA: 0x72CDEA0
        public void get_depth(){} // RVA: 0x72CDFA0
        public void get_rectTransform(){} // RVA: 0x72CE010
        public void get_canvas(){} // RVA: 0x72CE0B0
        public void CacheCanvas(){} // RVA: 0x72CE190
        public void get_canvasRenderer(){} // RVA: 0x72CE410
        public void get_defaultMaterial(){} // RVA: 0x72CE5A0
        public void get_material(){} // RVA: 0x72CE5F0
        public void set_material(){} // RVA: 0x72CE6E0
        public void get_materialForRendering(){} // RVA: 0x72CE860
        public void get_mainTexture(){} // RVA: 0x72CEA70
        public void OnEnable(){} // RVA: 0x72CEAD0
        public void OnDisable(){} // RVA: 0x72CED00
        public void OnDestroy(){} // RVA: 0x72CEEE0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x72CF0A0
        public void OnCullingChanged(){} // RVA: 0x72CF2F0
        public void Rebuild(){} // RVA: 0x72CF3B0
        public void LayoutComplete(){} // RVA: 0x2DD310
        public void GraphicUpdateComplete(){} // RVA: 0x2DD310
        public void UpdateMaterial(){} // RVA: 0x72CF540
        public void UpdateGeometry(){} // RVA: 0x72CF6D0
        public void DoMeshGeneration(){} // RVA: 0x72CF6F0
        public void DoLegacyMeshGeneration(){} // RVA: 0x72CFCE0
        public void get_workerMesh(){} // RVA: 0x72D02C0
        public void OnFillVBO(){} // RVA: 0x2DD310
        public void OnPopulateMesh(){} // RVA: 0x72D0570 | overloaded x2
        public void OnDidApplyAnimationProperties(){} // RVA: 0x6AED570
        public void SetNativeSize(){} // RVA: 0x2DD310
        public void Raycast(){} // RVA: 0x72D0780
        public void PixelAdjustPoint(){} // RVA: 0x72D0CB0
        public void GetPixelAdjustedRect(){} // RVA: 0x72D0F80
        public void CrossFadeColor(){} // RVA: 0x72D12E0 | overloaded x2
        public void CreateColorFromAlpha(){} // RVA: 0x72D17B0
        public void CrossFadeAlpha(){} // RVA: 0x72D17D0
        public void RegisterDirtyLayoutCallback(){} // RVA: 0x72D18A0
        public void UnregisterDirtyLayoutCallback(){} // RVA: 0x72D1990
        public void RegisterDirtyVerticesCallback(){} // RVA: 0x72D1A80
        public void UnregisterDirtyVerticesCallback(){} // RVA: 0x72D1B70
        public void RegisterDirtyMaterialCallback(){} // RVA: 0x72D1C60
        public void UnregisterDirtyMaterialCallback(){} // RVA: 0x72D1D60
        public void .cctor(){} // RVA: 0x72D1E60
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x891B00
    }

    public class GraphicRaycaster
    {
        // ── Methods ──
        public void get_sortOrderPriority(){} // RVA: 0x72D2000
        public void get_renderOrderPriority(){} // RVA: 0x72D20E0
        public void get_ignoreReversedGraphics(){} // RVA: 0x6E8A80
        public void set_ignoreReversedGraphics(){} // RVA: 0x6E8B80
        public void get_blockingObjects(){} // RVA: 0x1209F00
        public void set_blockingObjects(){} // RVA: 0x1AFCF60
        public void get_blockingMask(){} // RVA: 0x338CD0
        public void set_blockingMask(){} // RVA: 0x338CE0
        public void .ctor(){} // RVA: 0x72D2210
        public void get_canvas(){} // RVA: 0x72D2310
        public void Raycast(){} // RVA: 0x72D3A90 | overloaded x2
        public void get_eventCamera(){} // RVA: 0x72D38B0
        public void .cctor(){} // RVA: 0x72D41D0
    }

    public class GraphicRegistry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72D4450
        public void get_instance(){} // RVA: 0x72D4670
        public void RegisterGraphicForCanvas(){} // RVA: 0x72D4790
        public void RegisterRaycastGraphicForCanvas(){} // RVA: 0x72D4B30
        public void UnregisterGraphicForCanvas(){} // RVA: 0x72D4EE0
        public void UnregisterRaycastGraphicForCanvas(){} // RVA: 0x72D5190
        public void DisableGraphicForCanvas(){} // RVA: 0x72D5410
        public void DisableRaycastGraphicForCanvas(){} // RVA: 0x72D5630
        public void GetGraphicsForCanvas(){} // RVA: 0x72D5850
        public void GetRaycastableGraphicsForCanvas(){} // RVA: 0x72D5920
        public void .cctor(){} // RVA: 0x72D59F0
    }

    public class GridLayoutGroup
    {
        // ── Methods ──
        public void get_startCorner(){} // RVA: 0x59CEC0
        public void set_startCorner(){} // RVA: 0x74B2440
        public void get_startAxis(){} // RVA: 0x59C4F0
        public void set_startAxis(){} // RVA: 0x74B2490
        public void get_cellSize(){} // RVA: 0x74B24E0
        public void set_cellSize(){} // RVA: 0x74B2500
        public void get_spacing(){} // RVA: 0x74B2550
        public void set_spacing(){} // RVA: 0x74B2570
        public void get_constraint(){} // RVA: 0x1AE3800
        public void set_constraint(){} // RVA: 0x74B25C0
        public void get_constraintCount(){} // RVA: 0x1AE6E60
        public void set_constraintCount(){} // RVA: 0x74B2610
        public void .ctor(){} // RVA: 0x74B2700
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x74B2770
        public void CalculateLayoutInputVertical(){} // RVA: 0x74B2980
        public void SetLayoutHorizontal(){} // RVA: 0x74B2BB0
        public void SetLayoutVertical(){} // RVA: 0x74B2BC0
        public void SetCellsAlongAxis(){} // RVA: 0x74B2BD0
    }

    public class HorizontalLayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74B3390
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x74B33A0
        public void CalculateLayoutInputVertical(){} // RVA: 0x74B33D0
        public void SetLayoutHorizontal(){} // RVA: 0x74B33E0
        public void SetLayoutVertical(){} // RVA: 0x74B33F0
    }

    public class HorizontalOrVerticalLayoutGroup
    {
        // ── Methods ──
        public void get_spacing(){} // RVA: 0x3EDE10
        public void set_spacing(){} // RVA: 0x74B3400
        public void get_childForceExpandWidth(){} // RVA: 0x1498640
        public void set_childForceExpandWidth(){} // RVA: 0x74B34B0
        public void get_childForceExpandHeight(){} // RVA: 0x67098B0
        public void set_childForceExpandHeight(){} // RVA: 0x74B3500
        public void get_childControlWidth(){} // RVA: 0x6709810
        public void set_childControlWidth(){} // RVA: 0x74B3550
        public void get_childControlHeight(){} // RVA: 0x6709800
        public void set_childControlHeight(){} // RVA: 0x74B35A0
        public void get_childScaleWidth(){} // RVA: 0x3A5570
        public void set_childScaleWidth(){} // RVA: 0x74B35F0
        public void get_childScaleHeight(){} // RVA: 0x4EC4D70
        public void set_childScaleHeight(){} // RVA: 0x74B3640
        public void get_reverseArrangement(){} // RVA: 0x5AF9770
        public void set_reverseArrangement(){} // RVA: 0x74B3690
        public void CalcAlongAxis(){} // RVA: 0x74B36E0
        public void SetChildrenAlongAxis(){} // RVA: 0x74B3B90
        public void GetChildSizes(){} // RVA: 0x74B4740
        public void .ctor(){} // RVA: 0x74B3390
    }

    public class ICanvasElement
    {
        // ── Methods ──
        public void Rebuild(){} // RVA: 0x24FA0
        public void get_transform(){} // RVA: 0xCD60
        public void LayoutComplete(){} // RVA: 0x24A50
        public void GraphicUpdateComplete(){} // RVA: 0x24A50
        public void IsDestroyed(){} // RVA: 0xDBE0
    }

    public class IClippable
    {
        // ── Methods ──
        public void get_gameObject(){} // RVA: 0xCD60
        public void RecalculateClipping(){} // RVA: 0x24A50
        public void get_rectTransform(){} // RVA: 0xCD60
        public void Cull(){}
        public void SetClipRect(){}
        public void SetClipSoftness(){} // RVA: 0x33510
    }

    public class IClipper
    {
        // ── Methods ──
        public void PerformClipping(){} // RVA: 0x24A50
    }

    public class IGraphicEnabledDisabled
    {
        // ── Methods ──
        public void OnSiblingGraphicEnabledDisabled(){} // RVA: 0x24A50
    }

    public class ILayoutController
    {
        // ── Methods ──
        public void SetLayoutHorizontal(){} // RVA: 0x24A50
        public void SetLayoutVertical(){} // RVA: 0x24A50
    }

    public class ILayoutElement
    {
        // ── Methods ──
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x24A50
        public void CalculateLayoutInputVertical(){} // RVA: 0x24A50
        public void get_minWidth(){} // RVA: 0x21890
        public void get_preferredWidth(){} // RVA: 0x21890
        public void get_flexibleWidth(){} // RVA: 0x21890
        public void get_minHeight(){} // RVA: 0x21890
        public void get_preferredHeight(){} // RVA: 0x21890
        public void get_flexibleHeight(){} // RVA: 0x21890
        public void get_layoutPriority(){} // RVA: 0xD840
    }

    public class ILayoutGroup
    {
    }

    public class ILayoutIgnorer
    {
        // ── Methods ──
        public void get_ignoreLayout(){} // RVA: 0xDBE0
    }

    public class ILayoutSelfController : K,i
    {
    }

    public class IMask
    {
        // ── Methods ──
        public void Enabled(){} // RVA: 0xDBE0
        public void get_rectTransform(){} // RVA: 0xCD60
    }

    public class IMaskable
    {
        // ── Methods ──
        public void RecalculateMasking(){} // RVA: 0x24A50
    }

    public class IMaterialModifier
    {
        // ── Methods ──
        public void GetModifiedMaterial(){} // RVA: 0xCE10
    }

    public class IMeshModifier
    {
        // ── Methods ──
        public void ModifyMesh(){} // RVA: 0x24B10 | overloaded x2
    }

    public class IVertexModifier
    {
        // ── Methods ──
        public void ModifyVertices(){} // RVA: 0x24B10
    }

    public class Image
    {
        // ── Methods ──
        public void get_sprite(){} // RVA: 0x35E900
        public void set_sprite(){} // RVA: 0x72D5AD0
        public void DisableSpriteOptimizations(){} // RVA: 0x72D6270
        public void get_overrideSprite(){} // RVA: 0x72D6280
        public void set_overrideSprite(){} // RVA: 0x72D6290
        public void get_activeSprite(){} // RVA: 0x72D6310
        public void get_type(){} // RVA: 0x3739380
        public void set_type(){} // RVA: 0x72D6400
        public void get_preserveAspect(){} // RVA: 0x72D6470
        public void set_preserveAspect(){} // RVA: 0x72D6480
        public void get_fillCenter(){} // RVA: 0x72D64F0
        public void set_fillCenter(){} // RVA: 0x72D6500
        public void get_fillMethod(){} // RVA: 0x72D6570
        public void set_fillMethod(){} // RVA: 0x72D6580
        public void get_fillAmount(){} // RVA: 0x942D40
        public void set_fillAmount(){} // RVA: 0x72D6600
        public void get_fillClockwise(){} // RVA: 0x12108C0
        public void set_fillClockwise(){} // RVA: 0x72D6690
        public void get_fillOrigin(){} // RVA: 0x1C86A00
        public void set_fillOrigin(){} // RVA: 0x72D6700
        public void get_eventAlphaThreshold(){} // RVA: 0x72D6770
        public void set_eventAlphaThreshold(){} // RVA: 0x72D6790
        public void get_alphaHitTestMinimumThreshold(){} // RVA: 0x1E48700
        public void set_alphaHitTestMinimumThreshold(){} // RVA: 0x72D67B0
        public void get_useSpriteMesh(){} // RVA: 0x3DF1A50
        public void set_useSpriteMesh(){} // RVA: 0x72D6A80
        public void .ctor(){} // RVA: 0x72D6AF0
        public void get_defaultETC1GraphicMaterial(){} // RVA: 0x72D6B50
        public void get_mainTexture(){} // RVA: 0x72D6D30
        public void get_hasBorder(){} // RVA: 0x72D7040
        public void get_pixelsPerUnitMultiplier(){} // RVA: 0x499030
        public void set_pixelsPerUnitMultiplier(){} // RVA: 0x72D71D0
        public void get_pixelsPerUnit(){} // RVA: 0x72D7200
        public void get_multipliedPixelsPerUnit(){} // RVA: 0x72D7450
        public void get_material(){} // RVA: 0x72D7470
        public void set_material(){} // RVA: 0x72D7730
        public void OnBeforeSerialize(){} // RVA: 0x2DD310
        public void OnAfterDeserialize(){} // RVA: 0x72D7740
        public void PreserveSpriteAspectRatio(){} // RVA: 0xAB08B0
        public void GetDrawingDimensions(){} // RVA: 0x72D77B0
        public void SetNativeSize(){} // RVA: 0x72D7CE0
        public void OnPopulateMesh(){} // RVA: 0x72D7FD0
        public void TrackSprite(){} // RVA: 0x72D8190
        public void OnEnable(){} // RVA: 0x72D84F0
        public void OnDisable(){} // RVA: 0x72D8550
        public void UpdateMaterial(){} // RVA: 0x72D8630
        public void OnCanvasHierarchyChanged(){} // RVA: 0x72D8A00
        public void GenerateSimpleSprite(){} // RVA: 0x72D8C10
        public void GenerateSprite(){} // RVA: 0x72D9090
        public void GenerateSlicedSprite(){} // RVA: 0x72D97F0
        public void GenerateTiledSprite(){} // RVA: 0x72DA2F0
        public void AddQuad(){} // RVA: 0xAB11C0 | overloaded x2
        public void GetAdjustedBorders(){} // RVA: 0xAB09A0
        public void GenerateFilledSprite(){} // RVA: 0x72DBAB0
        public void RadialCut(){} // RVA: 0x72DCF10 | overloaded x2
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x2DD310
        public void CalculateLayoutInputVertical(){} // RVA: 0x2DD310
        public void get_minWidth(){} // RVA: 0xAFF380
        public void get_preferredWidth(){} // RVA: 0x72DD3D0
        public void get_flexibleWidth(){} // RVA: 0x6DB6BF0
        public void get_minHeight(){} // RVA: 0xAFF380
        public void get_preferredHeight(){} // RVA: 0x72DD590
        public void get_flexibleHeight(){} // RVA: 0x6DB6BF0
        public void get_layoutPriority(){} // RVA: 0x519240
        public void IsRaycastLocationValid(){} // RVA: 0x72DD750
        public void MapCoordinate(){} // RVA: 0x72DDBF0
        public void RebuildImage(){} // RVA: 0x72DE300
        public void TrackImage(){} // RVA: 0x72DE570
        public void UnTrackImage(){} // RVA: 0x72DE6E0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x72DE770
        public void .cctor(){} // RVA: 0x72DE7C0
        public void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0(){} // RVA: 0x72DEB50
        public void <set_sprite>g__SpriteSupportsAlphaHitTest|11_1(){} // RVA: 0x72DEBE0
    }

    public class InputField
    {
        // ── Methods ──
        public void get_input(){} // RVA: 0x74A1830
        public void get_compositionString(){} // RVA: 0x74A1A20
        public void .ctor(){} // RVA: 0x74A1B70
        public void get_mesh(){} // RVA: 0x74A2040
        public void get_cachedInputTextGenerator(){} // RVA: 0x74A21B0
        public void set_shouldHideMobileInput(){} // RVA: 0x74A2270
        public void get_shouldHideMobileInput(){} // RVA: 0x74A22C0
        public void set_shouldActivateOnSelect(){} // RVA: 0x64ADD80
        public void get_shouldActivateOnSelect(){} // RVA: 0x74A2360
        public void get_text(){} // RVA: 0xD83B50
        public void set_text(){} // RVA: 0x74A2400
        public void SetTextWithoutNotify(){} // RVA: 0x74A2410
        public void SetText(){} // RVA: 0x74A2420
        public void get_isFocused(){} // RVA: 0x1C9ABD0
        public void get_caretBlinkRate(){} // RVA: 0x74A2910
        public void set_caretBlinkRate(){} // RVA: 0x74A2920
        public void get_caretWidth(){} // RVA: 0x6EAD520
        public void set_caretWidth(){} // RVA: 0x74A2990
        public void get_textComponent(){} // RVA: 0xA902E0
        public void set_textComponent(){} // RVA: 0x74A29F0
        public void get_placeholder(){} // RVA: 0x507710
        public void set_placeholder(){} // RVA: 0x74A2D80
        public void get_caretColor(){} // RVA: 0x74A2DE0
        public void set_caretColor(){} // RVA: 0x74A2E40
        public void get_customCaretColor(){} // RVA: 0xDB7B90
        public void set_customCaretColor(){} // RVA: 0x74A2EB0
        public void get_selectionColor(){} // RVA: 0x74A2ED0
        public void set_selectionColor(){} // RVA: 0x74A2EE0
        public void get_onEndEdit(){} // RVA: 0x348660
        public void set_onEndEdit(){} // RVA: 0x74A2F50
        public void get_onSubmit(){} // RVA: 0xA933D0
        public void set_onSubmit(){} // RVA: 0x74A2FB0
        public void get_onValueChange(){} // RVA: 0x9FE130
        public void set_onValueChange(){} // RVA: 0x74A3010
        public void get_onValueChanged(){} // RVA: 0x9FE130
        public void set_onValueChanged(){} // RVA: 0x74A3010
        public void get_onValidateInput(){} // RVA: 0xD8A610
        public void set_onValidateInput(){} // RVA: 0x74A3070
        public void get_characterLimit(){} // RVA: 0x6B5E2A0
        public void set_characterLimit(){} // RVA: 0x74A30D0
        public void get_contentType(){} // RVA: 0x13CBAD0
        public void set_contentType(){} // RVA: 0x74A3180
        public void get_lineType(){} // RVA: 0x627A640
        public void set_lineType(){} // RVA: 0x74A3330
        public void get_inputType(){} // RVA: 0x7363390
        public void set_inputType(){} // RVA: 0x74A3420
        public void get_touchScreenKeyboard(){} // RVA: 0xA94E10
        public void get_keyboardType(){} // RVA: 0x613D7A0
        public void set_keyboardType(){} // RVA: 0x74A3490
        public void get_characterValidation(){} // RVA: 0x88E540
        public void set_characterValidation(){} // RVA: 0x74A3500
        public void get_readOnly(){} // RVA: 0x63A7830
        public void set_readOnly(){} // RVA: 0x63A7840
        public void get_multiLine(){} // RVA: 0x74A3570
        public void get_asteriskChar(){} // RVA: 0x74A3590
        public void set_asteriskChar(){} // RVA: 0x74A35A0
        public void get_wasCanceled(){} // RVA: 0x64ADDD0
        public void ClampPos(){} // RVA: 0x74A3650
        public void get_caretPositionInternal(){} // RVA: 0x74A3690
        public void set_caretPositionInternal(){} // RVA: 0x74A36C0
        public void get_caretSelectPositionInternal(){} // RVA: 0x74A3710
        public void set_caretSelectPositionInternal(){} // RVA: 0x74A3740
        public void get_hasSelection(){} // RVA: 0x74A3790
        public void get_caretPosition(){} // RVA: 0x74A3710
        public void set_caretPosition(){} // RVA: 0x74A37F0
        public void get_selectionAnchorPosition(){} // RVA: 0x74A3690
        public void set_selectionAnchorPosition(){} // RVA: 0x74A3820
        public void get_selectionFocusPosition(){} // RVA: 0x74A3710
        public void set_selectionFocusPosition(){} // RVA: 0x74A3890
        public void OnBeforeSerialize(){} // RVA: 0x2DD310
        public void OnAfterDeserialize(){} // RVA: 0x74A3900
        public void OnEnable(){} // RVA: 0x74A3A60
        public void OnDisable(){} // RVA: 0x74A3E50
        public void OnDestroy(){} // RVA: 0x74A42F0
        public void CaretBlink(){} // RVA: 0x74A4340
        public void SetCaretVisible(){} // RVA: 0x74A43E0
        public void SetCaretActive(){} // RVA: 0x74A4460
        public void UpdateCaretMaterial(){} // RVA: 0x74A4550
        public void OnFocus(){} // RVA: 0x74A4780
        public void SelectAll(){} // RVA: 0x74A4790
        public void MoveTextEnd(){} // RVA: 0x74A4820
        public void MoveTextStart(){} // RVA: 0x74A4940
        public void get_clipboard(){} // RVA: 0x74A4A30
        public void set_clipboard(){} // RVA: 0x74A4AB0
        public void TouchScreenKeyboardShouldBeUsed(){} // RVA: 0x74A4B40
        public void InPlaceEditing(){} // RVA: 0x74A4C60
        public void InPlaceEditingChanged(){} // RVA: 0x74A4C90
        public void GetInternalSelection(){} // RVA: 0x74A4D40
        public void UpdateKeyboardCaret(){} // RVA: 0x74A4E30
        public void UpdateCaretFromKeyboard(){} // RVA: 0x74A4F40
        public void LateUpdate(){} // RVA: 0x74A50F0
        public void ScreenToLocal(){} // RVA: 0x74A5930
        public void GetUnclampedCharacterLineFromPosition(){} // RVA: 0x74A6100
        public void GetCharacterIndexFromPosition(){} // RVA: 0x74A6400
        public void MayDrag(){} // RVA: 0x74A6710
        public void OnBeginDrag(){} // RVA: 0x74A6870
        public void OnDrag(){} // RVA: 0x74A68A0
        public void MouseDragOutsideRect(){} // RVA: 0x74A6C50
        public void OnEndDrag(){} // RVA: 0x74A6D50
        public void OnPointerDown(){} // RVA: 0x74A6D80
        public void KeyPressed(){} // RVA: 0x74A7070
        public void IsValidChar(){} // RVA: 0x74A7680
        public void ProcessEvent(){} // RVA: 0x74A76E0
        public void OnUpdateSelected(){} // RVA: 0x74A76F0
        public void GetSelectedString(){} // RVA: 0x74A7980
        public void FindtNextWordBegin(){} // RVA: 0x74A7A80
        public void MoveRight(){} // RVA: 0x74A7B90
        public void FindtPrevWordBegin(){} // RVA: 0x74A7E30
        public void MoveLeft(){} // RVA: 0x74A7F30
        public void DetermineCharacterLine(){} // RVA: 0x74A81C0
        public void LineUpCharacterPosition(){} // RVA: 0x74A8360
        public void LineDownCharacterPosition(){} // RVA: 0x74A8600
        public void MoveDown(){} // RVA: 0x74A8930 | overloaded x2
        public void MoveUp(){} // RVA: 0x74A8B60 | overloaded x2
        public void Delete(){} // RVA: 0x74A8D40
        public void ForwardSpace(){} // RVA: 0x74A9000
        public void Backspace(){} // RVA: 0x74A9110
        public void Insert(){} // RVA: 0x74A9290
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0x74A94C0
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0x74A9520
        public void SendOnValueChanged(){} // RVA: 0x74A9540
        public void SendOnEndEdit(){} // RVA: 0x74A9600
        public void SendOnSubmit(){} // RVA: 0x74A96C0
        public void Append(){} // RVA: 0x74A9860 | overloaded x2
        public void UpdateLabel(){} // RVA: 0x74A9BF0
        public void IsSelectionVisible(){} // RVA: 0x74AA3B0
        public void GetLineStartPosition(){} // RVA: 0x74AA480
        public void GetLineEndPosition(){} // RVA: 0x74AA5B0
        public void SetDrawRangeToContainCaretPosition(){} // RVA: 0x74AA730
        public void ForceLabelUpdate(){} // RVA: 0x74AB150
        public void MarkGeometryAsDirty(){} // RVA: 0x74AB160
        public void Rebuild(){} // RVA: 0x74AB200
        public void LayoutComplete(){} // RVA: 0x2DD310
        public void GraphicUpdateComplete(){} // RVA: 0x2DD310
        public void UpdateGeometry(){} // RVA: 0x74AB210
        public void AssignPositioningIfNeeded(){} // RVA: 0x74AB880
        public void OnFillVBO(){} // RVA: 0x74AC370
        public void GenerateCaret(){} // RVA: 0x74AC580
        public void CreateCursorVerts(){} // RVA: 0x74AD350
        public void GenerateHighlight(){} // RVA: 0x74AD560
        public void Validate(){} // RVA: 0x74ADE00
        public void ActivateInputField(){} // RVA: 0x74AE4E0
        public void ActivateInputFieldInternal(){} // RVA: 0x74AE710
        public void OnSelect(){} // RVA: 0x74AEF50
        public void OnPointerClick(){} // RVA: 0x74AEFA0
        public void DeactivateInputField(){} // RVA: 0x74AEFD0
        public void OnDeselect(){} // RVA: 0x74AF370
        public void OnSubmit(){} // RVA: 0x74AF3A0
        public void EnforceContentType(){} // RVA: 0x74AF3F0
        public void EnforceTextHOverflow(){} // RVA: 0x74AF560
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0x74AF6C0
        public void SetToCustom(){} // RVA: 0x74AF730
        public void DoStateTransition(){} // RVA: 0x74AF750
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x2DD310
        public void CalculateLayoutInputVertical(){} // RVA: 0x2DD310
        public void get_minWidth(){} // RVA: 0x74AF780
        public void get_preferredWidth(){} // RVA: 0x74AF790
        public void get_flexibleWidth(){} // RVA: 0x6DB6BF0
        public void get_minHeight(){} // RVA: 0xAFF380
        public void get_preferredHeight(){} // RVA: 0x74AF9F0
        public void get_flexibleHeight(){} // RVA: 0x6DB6BF0
        public void get_layoutPriority(){} // RVA: 0x3CFAF0
        public void .cctor(){} // RVA: 0x74AFC90
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x891B00
    }

    public class LayoutElement
    {
        // ── Methods ──
        public void get_ignoreLayout(){} // RVA: 0x3CB9D0
        public void set_ignoreLayout(){} // RVA: 0x74B4880
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x2DD310
        public void CalculateLayoutInputVertical(){} // RVA: 0x2DD310
        public void get_minWidth(){} // RVA: 0x44AF50
        public void set_minWidth(){} // RVA: 0x74B48E0
        public void get_minHeight(){} // RVA: 0x3BC210
        public void set_minHeight(){} // RVA: 0x74B4940
        public void get_preferredWidth(){} // RVA: 0x4652A0
        public void set_preferredWidth(){} // RVA: 0x74B49A0
        public void get_preferredHeight(){} // RVA: 0x466280
        public void set_preferredHeight(){} // RVA: 0x74B4A00
        public void get_flexibleWidth(){} // RVA: 0x3A7630
        public void set_flexibleWidth(){} // RVA: 0x74B4A60
        public void get_flexibleHeight(){} // RVA: 0x4FE250
        public void set_flexibleHeight(){} // RVA: 0x74B4AC0
        public void get_layoutPriority(){} // RVA: 0x891AF0
        public void set_layoutPriority(){} // RVA: 0x74B4B20
        public void .ctor(){} // RVA: 0x74B4B80
        public void OnEnable(){} // RVA: 0x74B4C00
        public void OnTransformParentChanged(){} // RVA: 0x74B4C00
        public void OnDisable(){} // RVA: 0x74B4C00
        public void OnDidApplyAnimationProperties(){} // RVA: 0x74B4C00
        public void OnBeforeTransformParentChanged(){} // RVA: 0x74B4C00
        public void SetDirty(){} // RVA: 0x74B4C10
    }

    public class LayoutGroup
    {
        // ── Methods ──
        public void get_padding(){} // RVA: 0x30B0C0
        public void set_padding(){} // RVA: 0x74B4CF0
        public void get_childAlignment(){} // RVA: 0x791DC0
        public void set_childAlignment(){} // RVA: 0x74B4DC0
        public void get_rectTransform(){} // RVA: 0x74B4E10
        public void get_rectChildren(){} // RVA: 0x3A5500
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x74B4F50
        public void CalculateLayoutInputVertical(){} // RVA: 0x24A50
        public void get_minWidth(){} // RVA: 0x6F83E10
        public void get_preferredWidth(){} // RVA: 0x71EFD40
        public void get_flexibleWidth(){} // RVA: 0x7262920
        public void get_minHeight(){} // RVA: 0x71A8230
        public void get_preferredHeight(){} // RVA: 0x7262910
        public void get_flexibleHeight(){} // RVA: 0x7262930
        public void get_layoutPriority(){} // RVA: 0x519240
        public void SetLayoutHorizontal(){} // RVA: 0x24A50
        public void SetLayoutVertical(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x74B5390
        public void OnEnable(){} // RVA: 0x74B56C0
        public void OnDisable(){} // RVA: 0x74B56D0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x74B56C0
        public void GetTotalMinSize(){} // RVA: 0x74B5730
        public void GetTotalPreferredSize(){} // RVA: 0x74B5740
        public void GetTotalFlexibleSize(){} // RVA: 0x74B5750
        public void GetStartOffset(){} // RVA: 0x74B5760
        public void GetAlignmentOnAxis(){} // RVA: 0x74B5A10
        public void SetLayoutInputForAxis(){} // RVA: 0x74B5A60
        public void SetChildAlongAxis(){} // RVA: 0x74B5F00 | overloaded x2
        public void SetChildAlongAxisWithScale(){} // RVA: 0x74B6020 | overloaded x2
        public void get_isRootLayoutGroup(){} // RVA: 0x74B6420
        public void OnRectTransformDimensionsChange(){} // RVA: 0x74B6720
        public void OnTransformChildrenChanged(){} // RVA: 0x74B56C0
        public void SetProperty(){} // RVA: 0x283FA0
        public void SetDirty(){} // RVA: 0x74B6750
        public void DelayedSetDirty(){} // RVA: 0x74B68F0
    }

    public class LayoutRebuilder
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x74B6AA0
        public void Clear(){} // RVA: 0x74B6B20
        public void .cctor(){} // RVA: 0x74B6B80
        public void ReapplyDrivenProperties(){} // RVA: 0x74B70B0
        public void get_transform(){} // RVA: 0x2F8380
        public void IsDestroyed(){} // RVA: 0x74B7100
        public void StripDisabledBehavioursFromList(){} // RVA: 0x74B71D0
        public void ForceRebuildLayoutImmediate(){} // RVA: 0x74B7340
        public void Rebuild(){} // RVA: 0x74B7490
        public void VRC_RegisterCachedLayoutTree(){} // RVA: 0x74B7910
        public void VRC_UnregisterCachedLayoutTree(){} // RVA: 0x74B7D00
        public void PerformLayoutControl(){} // RVA: 0x74B7E20
        public void PerformLayoutCalculation(){} // RVA: 0x74B85E0
        public void MarkLayoutForRebuild(){} // RVA: 0x74B8BE0
        public void ValidController(){} // RVA: 0x74B9360
        public void MarkLayoutRootForRebuild(){} // RVA: 0x74B9710
        public void LayoutComplete(){} // RVA: 0x74B9990
        public void GraphicUpdateComplete(){} // RVA: 0x2DD310
        public void GetHashCode(){} // RVA: 0x5BED50
        public void Equals(){} // RVA: 0x74B9A20
        public void ToString(){} // RVA: 0x74B9A80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LayoutUtility
    {
        // ── Methods ──
        public void GetMinSize(){} // RVA: 0x74B9EE0
        public void GetPreferredSize(){} // RVA: 0x74B9F00
        public void GetFlexibleSize(){} // RVA: 0x74B9F20
        public void GetMinWidth(){} // RVA: 0x74B9F40
        public void GetPreferredWidth(){} // RVA: 0x74BA0A0
        public void GetFlexibleWidth(){} // RVA: 0x74BA350
        public void GetMinHeight(){} // RVA: 0x74BA4B0
        public void GetPreferredHeight(){} // RVA: 0x74BA610
        public void GetFlexibleHeight(){} // RVA: 0x74BA8C0
        public void GetLayoutProperty(){} // RVA: 0x74BAA40 | overloaded x2
    }

    public class Mask
    {
        // ── Methods ──
        public void get_rectTransform(){} // RVA: 0x74BB1A0
        public void get_showMaskGraphic(){} // RVA: 0x6E8A80
        public void set_showMaskGraphic(){} // RVA: 0x74BB240
        public void get_graphic(){} // RVA: 0x74BB350
        public void .ctor(){} // RVA: 0x314BB0
        public void MaskEnabled(){} // RVA: 0x74BB3F0
        public void OnSiblingGraphicEnabledDisabled(){} // RVA: 0x2DD310
        public void OnEnable(){} // RVA: 0x74BB4F0
        public void OnDisable(){} // RVA: 0x74BB730
        public void IsRaycastLocationValid(){} // RVA: 0x74BBAF0
        public void GetModifiedMaterial(){} // RVA: 0x74BBBD0
    }

    public class MaskUtilities
    {
        // ── Methods ──
        public void Notify2DMaskStateChanged(){} // RVA: 0x74BD5C0
        public void NotifyStencilStateChanged(){} // RVA: 0x74BD940
        public void FindRootSortOverrideCanvas(){} // RVA: 0x74BDCC0
        public void GetStencilDepth(){} // RVA: 0x74BDF60
        public void IsDescendantOrSelf(){} // RVA: 0x74BE430
        public void GetRectMaskForClippable(){} // RVA: 0x74BE820
        public void GetRectMasksForClip(){} // RVA: 0x74BEC90
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MaskableGraphic : s_WhiteTexture
    {
        // ── Methods ──
        public void get_onCullStateChanged(){} // RVA: 0x435460
        public void set_onCullStateChanged(){} // RVA: 0x435470
        public void get_maskable(){} // RVA: 0x2FE4C0
        public void set_maskable(){} // RVA: 0x74BBFA0
        public void get_isMaskingGraphic(){} // RVA: 0x68D4C80
        public void set_isMaskingGraphic(){} // RVA: 0x74BBFD0
        public void GetModifiedMaterial(){} // RVA: 0x74BBFE0
        public void Cull(){} // RVA: 0x74BC1F0
        public void UpdateCull(){} // RVA: 0x74BC250
        public void SetClipRect(){} // RVA: 0x74BC3F0
        public void SetClipSoftness(){} // RVA: 0x74BC4E0
        public void OnEnable(){} // RVA: 0x74BC560
        public void OnDisable(){} // RVA: 0x74BC5C0
        public void OnTransformParentChanged(){} // RVA: 0x74BC6C0
        public void ParentMaskStateChanged(){} // RVA: 0x2DD310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x74BC830
        public void get_rootCanvasRect(){} // RVA: 0x74BC8C0
        public void UpdateClipParent(){} // RVA: 0x74BCE20
        public void RecalculateClipping(){} // RVA: 0x6F92820
        public void RecalculateMasking(){} // RVA: 0x74BD170
        public void .ctor(){} // RVA: 0x74BD250
        public void UnityEngine.UI.IClippable.get_gameObject(){} // RVA: 0x891B50
    }

    public class Misc
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0x74BF080
        public void DestroyImmediate(){} // RVA: 0x74BF250
    }

    public class MultipleDisplayUtilities
    {
        // ── Methods ──
        public void GetRelativeMousePositionForDrag(){} // RVA: 0x74BF360
        public void GetRelativeMousePositionForRaycast(){} // RVA: 0x74BF440
        public void RelativeMouseAtScaled(){} // RVA: 0x74BF570
    }

    public class Navigation
    {
        // ── Methods ──
        public void get_mode(){} // RVA: 0x19689B0
        public void set_mode(){} // RVA: 0x833580
        public void get_wrapAround(){} // RVA: 0x1EED2E0
        public void set_wrapAround(){} // RVA: 0x10EEB40
        public void get_selectOnUp(){} // RVA: 0x19689C0
        public void set_selectOnUp(){} // RVA: 0x1968950
        public void get_selectOnDown(){} // RVA: 0x2F8380
        public void set_selectOnDown(){} // RVA: 0x2DEE30
        public void get_selectOnLeft(){} // RVA: 0x2E07C0
        public void set_selectOnLeft(){} // RVA: 0x343E80
        public void get_selectOnRight(){} // RVA: 0x30B0C0
        public void set_selectOnRight(){} // RVA: 0x30B0D0
        public void get_defaultNavigation(){} // RVA: 0x74BFEA0
        public void Equals(){} // RVA: 0x74BFEC0
    }

    public class Outline
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74DDB30
        public void ModifyMesh(){} // RVA: 0x74DDBA0
    }

    public class PositionAsUV1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
        public void ModifyMesh(){} // RVA: 0x74DDED0
    }

    public class RawImage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74C02A0
        public void get_mainTexture(){} // RVA: 0x74C02D0
        public void get_texture(){} // RVA: 0x35E900
        public void set_texture(){} // RVA: 0x74C0590
        public void get_uvRect(){} // RVA: 0x629CB30
        public void set_uvRect(){} // RVA: 0x74C0740
        public void SetNativeSize(){} // RVA: 0x74C07B0
        public void OnPopulateMesh(){} // RVA: 0x74C0A00
        public void OnDidApplyAnimationProperties(){} // RVA: 0x72DE770
    }

    public class RectMask2D
    {
        // ── Methods ──
        public void get_padding(){} // RVA: 0x3EDE00
        public void set_padding(){} // RVA: 0x74C0E90
        public void get_softness(){} // RVA: 0x63C2900
        public void set_softness(){} // RVA: 0x74C0EA0
        public void get_Canvas(){} // RVA: 0x74C0ED0
        public void get_canvasRect(){} // RVA: 0x74C11D0
        public void get_rectTransform(){} // RVA: 0x74C1250
        public void .ctor(){} // RVA: 0x74C12F0
        public void OnEnable(){} // RVA: 0x74C16F0
        public void OnDisable(){} // RVA: 0x74C1760
        public void OnDestroy(){} // RVA: 0x72BDEC0
        public void IsRaycastLocationValid(){} // RVA: 0x74C18F0
        public void get_rootCanvasRect(){} // RVA: 0x74C1A00
        public void PerformClipping(){} // RVA: 0x74C1C90
        public void UpdateClipSoftness(){} // RVA: 0x74C2820
        public void AddClippable(){} // RVA: 0x74C2BE0
        public void RemoveClippable(){} // RVA: 0x74C2D90
        public void OnTransformParentChanged(){} // RVA: 0x74C2F40
        public void OnCanvasHierarchyChanged(){} // RVA: 0x74C2F40
    }

    public class RectangularVertexClipper
    {
        // ── Methods ──
        public void GetCanvasRect(){} // RVA: 0x72BE310
        public void .ctor(){} // RVA: 0x72BE5B0
    }

    public class ReflectionMethodsCache
    {
        public object Key;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74D8700
        public void get_Singleton(){} // RVA: 0x74DA070
    }

    public class ScrollRect
    {
        // ── Methods ──
        public void get_content(){} // RVA: 0x30B0C0
        public void set_content(){} // RVA: 0x30B0D0
        public void get_horizontal(){} // RVA: 0x6E8A80
        public void set_horizontal(){} // RVA: 0x6E8B80
        public void get_vertical(){} // RVA: 0xC36000
        public void set_vertical(){} // RVA: 0x190AB20
        public void get_movementType(){} // RVA: 0x1209F00
        public void set_movementType(){} // RVA: 0x1AFCF60
        public void get_elasticity(){} // RVA: 0x466280
        public void set_elasticity(){} // RVA: 0x4FDE90
        public void get_inertia(){} // RVA: 0x313C20
        public void set_inertia(){} // RVA: 0x317AC0
        public void get_decelerationRate(){} // RVA: 0x4FE250
        public void set_decelerationRate(){} // RVA: 0x4FB970
        public void get_scrollSensitivity(){} // RVA: 0x9FC6D0
        public void set_scrollSensitivity(){} // RVA: 0x9FC6C0
        public void get_viewport(){} // RVA: 0x35A740
        public void set_viewport(){} // RVA: 0x74C56C0
        public void get_horizontalScrollbar(){} // RVA: 0x358730
        public void set_horizontalScrollbar(){} // RVA: 0x74C5720
        public void get_verticalScrollbar(){} // RVA: 0x37E0E0
        public void set_verticalScrollbar(){} // RVA: 0x74C5A10
        public void get_horizontalScrollbarVisibility(){} // RVA: 0x9EAB90
        public void set_horizontalScrollbarVisibility(){} // RVA: 0x74C5D00
        public void get_verticalScrollbarVisibility(){} // RVA: 0x5A54D0
        public void set_verticalScrollbarVisibility(){} // RVA: 0x74C5D10
        public void get_horizontalScrollbarSpacing(){} // RVA: 0x3EDE10
        public void set_horizontalScrollbarSpacing(){} // RVA: 0x74C5D20
        public void get_verticalScrollbarSpacing(){} // RVA: 0x306040
        public void set_verticalScrollbarSpacing(){} // RVA: 0x74C5D30
        public void get_onValueChanged(){} // RVA: 0x358D50
        public void set_onValueChanged(){} // RVA: 0x358D60
        public void get_viewRect(){} // RVA: 0x74C5D40
        public void get_velocity(){} // RVA: 0x74C6020
        public void set_velocity(){} // RVA: 0x1B6CF30
        public void get_rectTransform(){} // RVA: 0x74C6040
        public void .ctor(){} // RVA: 0x74C6190
        public void Rebuild(){} // RVA: 0x74C63E0
        public void LayoutComplete(){} // RVA: 0x2DD310
        public void GraphicUpdateComplete(){} // RVA: 0x2DD310
        public void UpdateCachedData(){} // RVA: 0x74C6470
        public void OnEnable(){} // RVA: 0x74C7040
        public void OnDisable(){} // RVA: 0x74C7330
        public void IsActive(){} // RVA: 0x74C76B0
        public void EnsureLayoutHasRebuilt(){} // RVA: 0x74C77D0
        public void StopMovement(){} // RVA: 0x74C7880
        public void OnScroll(){} // RVA: 0x74C78E0
        public void OnInitializePotentialDrag(){} // RVA: 0x74C7AF0
        public void OnBeginDrag(){} // RVA: 0x74C7B60
        public void OnEndDrag(){} // RVA: 0x74C7CC0
        public void OnDrag(){} // RVA: 0x74C7CF0
        public void SetContentAnchoredPosition(){} // RVA: 0x74C7F50
        public void LateUpdate(){} // RVA: 0x74C8100
        public void UpdatePrevData(){} // RVA: 0x74C8C80
        public void UpdateScrollbars(){} // RVA: 0x74C8E10
        public void get_normalizedPosition(){} // RVA: 0x74C90F0
        public void set_normalizedPosition(){} // RVA: 0x74C9130
        public void get_horizontalNormalizedPosition(){} // RVA: 0x74C9190
        public void set_horizontalNormalizedPosition(){} // RVA: 0x74C92A0
        public void get_verticalNormalizedPosition(){} // RVA: 0x74C92C0
        public void set_verticalNormalizedPosition(){} // RVA: 0x74C93E0
        public void SetHorizontalNormalizedPosition(){} // RVA: 0x74C92A0
        public void SetVerticalNormalizedPosition(){} // RVA: 0x74C93E0
        public void SetNormalizedPosition(){} // RVA: 0x74C9400
        public void RubberDelta(){} // RVA: 0x74C9980
        public void OnRectTransformDimensionsChange(){} // RVA: 0x74C99E0
        public void get_hScrollingNeeded(){} // RVA: 0x74C99F0
        public void get_vScrollingNeeded(){} // RVA: 0x74C9AB0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x2DD310
        public void CalculateLayoutInputVertical(){} // RVA: 0x2DD310
        public void get_minWidth(){} // RVA: 0x6DB6BF0
        public void get_preferredWidth(){} // RVA: 0x6DB6BF0
        public void get_flexibleWidth(){} // RVA: 0x6DB6BF0
        public void get_minHeight(){} // RVA: 0x6DB6BF0
        public void get_preferredHeight(){} // RVA: 0x6DB6BF0
        public void get_flexibleHeight(){} // RVA: 0x6DB6BF0
        public void get_layoutPriority(){} // RVA: 0x75BB20
        public void SetLayoutHorizontal(){} // RVA: 0x74C9B70
        public void SetLayoutVertical(){} // RVA: 0x74CA500
        public void UpdateScrollbarVisibility(){} // RVA: 0x74CA6D0
        public void UpdateOneScrollbarVisibility(){} // RVA: 0x74CA730
        public void UpdateScrollbarLayout(){} // RVA: 0x74CA990
        public void UpdateBounds(){} // RVA: 0x74CAE10
        public void AdjustBounds(){} // RVA: 0x74CB540
        public void GetBounds(){} // RVA: 0x74CB5F0
        public void InternalGetBounds(){} // RVA: 0x74CB7F0
        public void CalculateOffset(){} // RVA: 0x74CBA90
        public void InternalCalculateOffset(){} // RVA: 0x74CBAE0
        public void SetDirty(){} // RVA: 0x74CBCA0
        public void SetDirtyCaching(){} // RVA: 0x74CBD20
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x891B00
    }

    public class Scrollbar
    {
        // ── Methods ──
        public void get_handleRect(){} // RVA: 0xA94E10
        public void set_handleRect(){} // RVA: 0x74C2FB0
        public void get_direction(){} // RVA: 0x1AE9D90
        public void set_direction(){} // RVA: 0x74C3020
        public void .ctor(){} // RVA: 0x74C3080
        public void get_value(){} // RVA: 0x74C31B0
        public void set_value(){} // RVA: 0x74C3210
        public void SetValueWithoutNotify(){} // RVA: 0x74C3220
        public void get_size(){} // RVA: 0x499030
        public void set_size(){} // RVA: 0x74C3230
        public void get_numberOfSteps(){} // RVA: 0x6FACBE0
        public void set_numberOfSteps(){} // RVA: 0x74C32B0
        public void get_onValueChanged(){} // RVA: 0x507D10
        public void set_onValueChanged(){} // RVA: 0x50A8C0
        public void get_stepSize(){} // RVA: 0x74C3320
        public void Rebuild(){} // RVA: 0x2DD310
        public void LayoutComplete(){} // RVA: 0x2DD310
        public void GraphicUpdateComplete(){} // RVA: 0x2DD310
        public void OnEnable(){} // RVA: 0x74C3350
        public void OnDisable(){} // RVA: 0x74C3390
        public void Update(){} // RVA: 0x74C33A0
        public void UpdateCachedReferences(){} // RVA: 0x74C33C0
        public void Set(){} // RVA: 0x74C36E0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x74C3820
        public void get_axis(){} // RVA: 0x74C3860
        public void get_reverseValue(){} // RVA: 0x74C3880
        public void UpdateVisuals(){} // RVA: 0x74C38A0
        public void UpdateDrag(){} // RVA: 0x74C3BE0
        public void DoUpdateDrag(){} // RVA: 0x74C4090
        public void MayDrag(){} // RVA: 0x74C4150
        public void OnBeginDrag(){} // RVA: 0x74C41C0
        public void OnDrag(){} // RVA: 0x74C4500
        public void OnPointerDown(){} // RVA: 0x74C4640
        public void ClickRepeat(){} // RVA: 0x74C47F0 | overloaded x2
        public void OnPointerUp(){} // RVA: 0x74C4920
        public void OnMove(){} // RVA: 0x74C4960
        public void FindSelectableOnLeft(){} // RVA: 0x74C5010
        public void FindSelectableOnRight(){} // RVA: 0x74C5040
        public void FindSelectableOnUp(){} // RVA: 0x74C5070
        public void FindSelectableOnDown(){} // RVA: 0x74C50A0
        public void OnInitializePotentialDrag(){} // RVA: 0xAFB540
        public void SetDirection(){} // RVA: 0x74C50D0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x891B00
    }

    public class Selectable
    {
        // ── Methods ──
        public void get_allSelectablesArray(){} // RVA: 0x74CBEC0
        public void get_allSelectableCount(){} // RVA: 0x74CC070
        public void get_allSelectables(){} // RVA: 0x74CC0D0
        public void AllSelectablesNoAlloc(){} // RVA: 0x74CC170
        public void get_navigation(){} // RVA: 0x4F0FC10
        public void set_navigation(){} // RVA: 0x74CC300
        public void get_transition(){} // RVA: 0x59C540
        public void set_transition(){} // RVA: 0x74CC450
        public void get_colors(){} // RVA: 0x74CC4B0
        public void set_colors(){} // RVA: 0x74CC4F0
        public void get_spriteState(){} // RVA: 0x74CC670
        public void set_spriteState(){} // RVA: 0x74CC690
        public void get_animationTriggers(){} // RVA: 0x3FA100
        public void set_animationTriggers(){} // RVA: 0x74CC7C0
        public void get_targetGraphic(){} // RVA: 0x35E900
        public void set_targetGraphic(){} // RVA: 0x74CC820
        public void get_interactable(){} // RVA: 0x12FD610
        public void set_interactable(){} // RVA: 0x74CC880
        public void get_isPointerInside(){} // RVA: 0x35EAD0
        public void set_isPointerInside(){} // RVA: 0x35EAE0
        public void get_isPointerDown(){} // RVA: 0x18AA2A0
        public void set_isPointerDown(){} // RVA: 0x18A5C20
        public void get_hasSelection(){} // RVA: 0x1CACB60
        public void set_hasSelection(){} // RVA: 0x5FEDD40
        public void .ctor(){} // RVA: 0x74CCB10
        public void get_image(){} // RVA: 0x74CCDA0
        public void set_image(){} // RVA: 0x35E910
        public void get_animator(){} // RVA: 0x74CCE30
        public void Awake(){} // RVA: 0x74CCE70
        public void OnCanvasGroupChanged(){} // RVA: 0x74CCFB0
        public void ParentGroupAllowsInteraction(){} // RVA: 0x74CCFF0
        public void IsInteractable(){} // RVA: 0x74CD230
        public void OnDidApplyAnimationProperties(){} // RVA: 0x74CD250
        public void OnEnable(){} // RVA: 0x74CD260
        public void OnTransformParentChanged(){} // RVA: 0x1854D10
        public void OnSetProperty(){} // RVA: 0x74CD790
        public void OnDisable(){} // RVA: 0x74CD810
        public void OnApplicationFocus(){} // RVA: 0x74CD990
        public void get_currentSelectionState(){} // RVA: 0x74CDA00
        public void InstantClearState(){} // RVA: 0x74CDA70
        public void DoStateTransition(){} // RVA: 0x74CDB00
        public void FindSelectable(){} // RVA: 0x74CDE20
        public void GetPointOnRectEdge(){} // RVA: 0x74CE7E0
        public void Navigate(){} // RVA: 0x74CEAF0
        public void FindSelectableOnLeft(){} // RVA: 0x74CEC40
        public void FindSelectableOnRight(){} // RVA: 0x74CEDB0
        public void FindSelectableOnUp(){} // RVA: 0x74CEF20
        public void FindSelectableOnDown(){} // RVA: 0x74CF090
        public void OnMove(){} // RVA: 0x74CF200
        public void StartColorTween(){} // RVA: 0x74CF2B0
        public void DoSpriteSwap(){} // RVA: 0x74CF420
        public void TriggerAnimation(){} // RVA: 0x74CF530
        public void IsHighlighted(){} // RVA: 0x74CF840
        public void IsPressed(){} // RVA: 0x74CF8B0
        public void EvaluateAndTransitionToSelectionState(){} // RVA: 0x74CF900
        public void OnPointerDown(){} // RVA: 0x74CF970
        public void OnPointerUp(){} // RVA: 0x74CFB10
        public void OnPointerEnter(){} // RVA: 0x74CFB40
        public void OnPointerExit(){} // RVA: 0x74CFB50
        public void OnSelect(){} // RVA: 0x74CFB60
        public void OnDeselect(){} // RVA: 0x74CFB70
        public void Select(){} // RVA: 0x74CFB80
        public void .cctor(){} // RVA: 0x74CFD20
    }

    public class SetPropertyUtility
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x6FEEE20
        public void SetStruct(){} // RVA: 0x283FA0
        public void SetClass(){} // RVA: 0x283FA0
    }

    public class Shadow
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74DDB30
        public void get_effectColor(){} // RVA: 0x111F520
        public void set_effectColor(){} // RVA: 0x74DE020
        public void get_effectDistance(){} // RVA: 0x1514540
        public void set_effectDistance(){} // RVA: 0x74DE130
        public void get_useGraphicAlpha(){} // RVA: 0x398C00
        public void set_useGraphicAlpha(){} // RVA: 0x74DE2F0
        public void ApplyShadowZeroAlloc(){} // RVA: 0x74DE400
        public void ApplyShadow(){} // RVA: 0x74DE810
        public void ModifyMesh(){} // RVA: 0x74DE820
    }

    public class Slider
    {
        // ── Methods ──
        public void get_fillRect(){} // RVA: 0xA94E10
        public void set_fillRect(){} // RVA: 0x74CFDF0
        public void get_handleRect(){} // RVA: 0xA902E0
        public void set_handleRect(){} // RVA: 0x74CFE60
        public void get_direction(){} // RVA: 0x1AEE360
        public void set_direction(){} // RVA: 0x74CFED0
        public void get_minValue(){} // RVA: 0x497F20
        public void set_minValue(){} // RVA: 0x74CFF30
        public void get_maxValue(){} // RVA: 0x646FC40
        public void set_maxValue(){} // RVA: 0x74CFFB0
        public void get_wholeNumbers(){} // RVA: 0x74D0030
        public void set_wholeNumbers(){} // RVA: 0x74D0040
        public void get_value(){} // RVA: 0x74D00C0
        public void set_value(){} // RVA: 0x74D00E0
        public void SetValueWithoutNotify(){} // RVA: 0x74D0100
        public void get_normalizedValue(){} // RVA: 0x74D0120
        public void set_normalizedValue(){} // RVA: 0x74D01D0
        public void get_onValueChanged(){} // RVA: 0xA8EE80
        public void set_onValueChanged(){} // RVA: 0xD182E0
        public void get_stepSize(){} // RVA: 0x74D0220
        public void .ctor(){} // RVA: 0x74D0250
        public void Rebuild(){} // RVA: 0x2DD310
        public void LayoutComplete(){} // RVA: 0x2DD310
        public void GraphicUpdateComplete(){} // RVA: 0x2DD310
        public void OnEnable(){} // RVA: 0x74D0380
        public void OnDisable(){} // RVA: 0x74C3390
        public void Update(){} // RVA: 0x74D03D0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x74D0420
        public void UpdateCachedReferences(){} // RVA: 0x74D0840
        public void ClampValue(){} // RVA: 0x74D1290
        public void Set(){} // RVA: 0x74D12C0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x74D13B0
        public void get_axis(){} // RVA: 0x74D13F0
        public void get_reverseValue(){} // RVA: 0x74D1410
        public void UpdateVisuals(){} // RVA: 0x74D1430
        public void UpdateDrag(){} // RVA: 0x74D1A50
        public void MayDrag(){} // RVA: 0x74C4150
        public void OnPointerDown(){} // RVA: 0x74D1DB0
        public void OnDrag(){} // RVA: 0x74D2090
        public void OnMove(){} // RVA: 0x74D2110
        public void FindSelectableOnLeft(){} // RVA: 0x74D2710
        public void FindSelectableOnRight(){} // RVA: 0x74D2740
        public void FindSelectableOnUp(){} // RVA: 0x74D2770
        public void FindSelectableOnDown(){} // RVA: 0x74D27A0
        public void OnInitializePotentialDrag(){} // RVA: 0xAFB540
        public void SetDirection(){} // RVA: 0x74D27D0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x891B00
    }

    public class SpriteState
    {
        // ── Methods ──
        public void get_highlightedSprite(){} // RVA: 0x1AD4690
        public void set_highlightedSprite(){} // RVA: 0x100A2F0
        public void get_pressedSprite(){} // RVA: 0x19689C0
        public void set_pressedSprite(){} // RVA: 0x1968950
        public void get_selectedSprite(){} // RVA: 0x2F8380
        public void set_selectedSprite(){} // RVA: 0x2DEE30
        public void get_disabledSprite(){} // RVA: 0x2E07C0
        public void set_disabledSprite(){} // RVA: 0x343E80
        public void Equals(){} // RVA: 0x74D2AC0
    }

    public class StencilMaterial
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x74D3000 | overloaded x3
        public void LogWarningWhenNotInBatchmode(){} // RVA: 0x74D2F30
        public void Remove(){} // RVA: 0x74D3BE0
        public void ClearAll(){} // RVA: 0x74D3EE0
        public void .cctor(){} // RVA: 0x74D40E0
    }

    public class Text
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74D41D0
        public void get_cachedTextGenerator(){} // RVA: 0x74D4370
        public void get_cachedTextGeneratorForLayout(){} // RVA: 0x74D4470
        public void get_mainTexture(){} // RVA: 0x74D4530
        public void FontTextureChanged(){} // RVA: 0x74D4950
        public void get_font(){} // RVA: 0x74D4AF0
        public void set_font(){} // RVA: 0x74D4B10
        public void get_text(){} // RVA: 0x35E970
        public void set_text(){} // RVA: 0x74D4DA0
        public void get_supportRichText(){} // RVA: 0x74D4F80
        public void set_supportRichText(){} // RVA: 0x74D4FA0
        public void get_resizeTextForBestFit(){} // RVA: 0x74D5000
        public void set_resizeTextForBestFit(){} // RVA: 0x74D5020
        public void get_resizeTextMinSize(){} // RVA: 0x74D5080
        public void set_resizeTextMinSize(){} // RVA: 0x74D50A0
        public void get_resizeTextMaxSize(){} // RVA: 0x74D5100
        public void set_resizeTextMaxSize(){} // RVA: 0x74D5120
        public void get_alignment(){} // RVA: 0x74D5180
        public void set_alignment(){} // RVA: 0x74D51A0
        public void get_alignByGeometry(){} // RVA: 0x74D5200
        public void set_alignByGeometry(){} // RVA: 0x74D5220
        public void get_fontSize(){} // RVA: 0x74D5260
        public void set_fontSize(){} // RVA: 0x74D5280
        public void get_horizontalOverflow(){} // RVA: 0x74D52E0
        public void set_horizontalOverflow(){} // RVA: 0x74D5300
        public void get_verticalOverflow(){} // RVA: 0x74D5360
        public void set_verticalOverflow(){} // RVA: 0x74D5380
        public void get_lineSpacing(){} // RVA: 0x74D53E0
        public void set_lineSpacing(){} // RVA: 0x74D5400
        public void get_fontStyle(){} // RVA: 0x74D5470
        public void set_fontStyle(){} // RVA: 0x74D5490
        public void get_pixelsPerUnit(){} // RVA: 0x74D54F0
        public void OnEnable(){} // RVA: 0x74D57E0
        public void OnDisable(){} // RVA: 0x74D5890
        public void UpdateGeometry(){} // RVA: 0x74D58F0
        public void AssignDefaultFont(){} // RVA: 0x74D5A00
        public void AssignDefaultFontIfNecessary(){} // RVA: 0x74D5A60
        public void GetGenerationSettings(){} // RVA: 0x74D5B80
        public void GetTextAnchorPivot(){} // RVA: 0x74D5F00
        public void OnPopulateMesh(){} // RVA: 0x74D6070
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x2DD310
        public void CalculateLayoutInputVertical(){} // RVA: 0x2DD310
        public void get_minWidth(){} // RVA: 0xAFF380
        public void get_preferredWidth(){} // RVA: 0x74D6880
        public void get_flexibleWidth(){} // RVA: 0x6DB6BF0
        public void get_minHeight(){} // RVA: 0xAFF380
        public void get_preferredHeight(){} // RVA: 0x74D69B0
        public void get_flexibleHeight(){} // RVA: 0x6DB6BF0
        public void get_layoutPriority(){} // RVA: 0x519240
    }

    public class Toggle
    {
        // ── Methods ──
        public void get_group(){} // RVA: 0x507710
        public void set_group(){} // RVA: 0x74D6AC0
        public void .ctor(){} // RVA: 0x74D6AF0
        public void Rebuild(){} // RVA: 0x2DD310
        public void LayoutComplete(){} // RVA: 0x2DD310
        public void GraphicUpdateComplete(){} // RVA: 0x2DD310
        public void OnDestroy(){} // RVA: 0x74D6BD0
        public void OnEnable(){} // RVA: 0x74D6CC0
        public void OnDisable(){} // RVA: 0x74D6D00
        public void OnDidApplyAnimationProperties(){} // RVA: 0x74D6D30
        public void SetToggleGroup(){} // RVA: 0x74D6EC0
        public void get_isOn(){} // RVA: 0x5FF2270
        public void set_isOn(){} // RVA: 0x74D71A0
        public void SetIsOnWithoutNotify(){} // RVA: 0x74D71B0
        public void Set(){} // RVA: 0x74D71C0
        public void PlayEffect(){} // RVA: 0x74D7400
        public void Start(){} // RVA: 0x74D7530
        public void InternalToggle(){} // RVA: 0x74D7540
        public void OnPointerClick(){} // RVA: 0x74D75A0
        public void OnSubmit(){} // RVA: 0x74D7540
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x891B00
    }

    public class ToggleGroup
    {
        // ── Methods ──
        public void get_allowSwitchOff(){} // RVA: 0x3CB9D0
        public void set_allowSwitchOff(){} // RVA: 0x3CB9E0
        public void .ctor(){} // RVA: 0x74D76B0
        public void Start(){} // RVA: 0x74D77B0
        public void OnEnable(){} // RVA: 0x74D77B0
        public void ValidateToggleIsInGroup(){} // RVA: 0x74D77C0
        public void NotifyToggleOn(){} // RVA: 0x74D7980
        public void UnregisterToggle(){} // RVA: 0x74D7BA0
        public void RegisterToggle(){} // RVA: 0x74D7C20
        public void EnsureValidState(){} // RVA: 0x74D7CE0
        public void AnyTogglesOn(){} // RVA: 0x74D80D0
        public void ActiveToggles(){} // RVA: 0x74D8300
        public void GetFirstActiveToggle(){} // RVA: 0x74D8470
        public void SetAllTogglesOff(){} // RVA: 0x74D84F0
    }

    public class VertexHelper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74DAB20 | overloaded x2
        public void InitializeListIfRequired(){} // RVA: 0x74DAE70
        public void Dispose(){} // RVA: 0x74DB3B0
        public void Clear(){} // RVA: 0x74DB8D0
        public void get_currentVertCount(){} // RVA: 0x74DB9D0
        public void get_currentIndexCount(){} // RVA: 0x74DBA20
        public void PopulateUIVertex(){} // RVA: 0x74DBA70
        public void SetUIVertex(){} // RVA: 0x74DBCC0
        public void FillMesh(){} // RVA: 0x74DC0D0
        public void AddVert(){} // RVA: 0x74DCC90 | overloaded x4
        public void AddTriangle(){} // RVA: 0x74DCD40
        public void AddUIVertexQuad(){} // RVA: 0x74DCEB0
        public void AddUIVertexStream(){} // RVA: 0x74DD170
        public void AddUIVertexTriangleStream(){} // RVA: 0x74DD2F0
        public void GetUIVertexStream(){} // RVA: 0x74DD370
        public void .cctor(){} // RVA: 0x74DD480
    }

    public class VerticalLayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74B3390
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x74BB140
        public void CalculateLayoutInputVertical(){} // RVA: 0x74BB170
        public void SetLayoutHorizontal(){} // RVA: 0x74BB180
        public void SetLayoutVertical(){} // RVA: 0x74BB190
    }

}