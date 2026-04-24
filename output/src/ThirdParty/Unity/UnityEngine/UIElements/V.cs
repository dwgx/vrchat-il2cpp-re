// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 7
// Methods: 411

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class VectorImage : ScriptableObject
    {
        public int width; // 0x18
        public ector height; // 0x20
        public ÎÏÌÎÎÎÌÌÌ.ss[] vertices; // 0x28
        public ushort[] indices; // 0x30
        public ÎÏÌÎÎÎÌÌÌ.ningFactor[] settings; // 0x38
        public tionX size; // 0x40

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFD4E5080B0
        public void get_height(){} // RVA: 0x7FFD4E349970
        public void .ctor(){} // RVA: 0x7FFD54EDD8B0
    }

    public class VerticalVirtualizationController`1 : CollectionVirtualizationController
    {
        public cy.gContentId<T1717594384> activeItems; // 0x18
        public ÎÏÌÎÎÎÌÌÌ.? itemsCount; // 0x20
        public URA.woDigitYearMax<T1717594384> firstVisibleItem; // 0x28
        public T1717594384 lastVisibleItem; // 0x30
        public int visibleItemCount; // 0x38
        public URA.woDigitYearMax<int> serializedData; // 0x40
        public n<T1717594384,bool> firstVisibleIndex; // 0x48
        public URA.woDigitYearMax<T1717594384> lastHeight; // 0x50
        public ÎÏÌÎÎÎÌÌÌ.omLeftRadius alwaysRebindOnRefresh; // 0x58

        // ── Methods ──
        public void get_activeItems(){} // RVA: 0x7FFD4E078E90
        public void get_itemsCount(){} // RVA: 0x7FFD4E079960
        public void VisibleItemPredicate(){} // RVA: 0x7FFD4E2ADC40
        public void get_firstVisibleItem(){} // RVA: 0x7FFD4E2ADC40
        public void get_lastVisibleItem(){} // RVA: 0x7FFD4E2ADC40
        public void get_visibleItemCount(){} // RVA: 0x7FFD4E079960
        public void get_serializedData(){} // RVA: 0x7FFD4E078E90
        public void get_firstVisibleIndex(){} // RVA: 0x7FFD4E079960
        public void set_firstVisibleIndex(){} // RVA: 0x7FFD4E090ED0
        public void get_lastHeight(){} // RVA: 0x7FFD4E08D880
        public void get_alwaysRebindOnRefresh(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Refresh(){} // RVA: 0x7FFD4E091060
        public void Setup(){} // RVA: 0x7FFD4E2ADC40
        public void OnFocus(){} // RVA: 0x7FFD4E090A40
        public void OnBlur(){} // RVA: 0x7FFD4E090A40
        public void HandleFocus(){} // RVA: 0x7FFD4E097970
        public void UpdateBackground(){} // RVA: 0x7FFD4E090980
        public void StartDragItem(){} // RVA: 0x7FFD4E090A40
        public void EndDrag(){} // RVA: 0x7FFD4E090ED0
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7FFD4E2ADC40
        public void ReleaseItem(){} // RVA: 0x7FFD4E090ED0
        public void OnDestroyItem(){} // RVA: 0x7FFD4E090A40
        public void GetDraggedIndex(){} // RVA: 0x7FFD4E079960
    }

    public class VisualData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFD55016360
        public void CopyFrom(){} // RVA: 0x7FFD5501A8F0
        public void op_Equality(){} // RVA: 0x7FFD5501AA40
        public void Equals(){} // RVA: 0x7FFD5501C010 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD5501C140
    }

    public class VisualElement : Focusable
    {
        public int resolvedStyle; // 0x30
        public int UnityEngine.UIElements.IResolvedStyle.backgroundColor; // 0x34
        public uint UnityEngine.UIElements.IResolvedStyle.borderBottomColor;
        public URA.woDigitYearMax<string> UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius; // 0x8
        public object UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius; // 0x10
        public string UnityEngine.UIElements.IResolvedStyle.borderBottomWidth; // 0x18
        public string UnityEngine.UIElements.IResolvedStyle.borderLeftColor; // 0x38
        public URA.woDigitYearMax<string> UnityEngine.UIElements.IResolvedStyle.borderLeftWidth; // 0x40
        public URA.woDigitYearMax<URA.mes<?,object>> UnityEngine.UIElements.IResolvedStyle.borderRightColor; // 0x48
        public ÎÏÌÎÎÎÌÌÌ.t UnityEngine.UIElements.IResolvedStyle.borderRightWidth; // 0x50
        public string UnityEngine.UIElements.IResolvedStyle.borderTopColor; // 0x58
        public ÎÏÌÎÎÎÌÌÌ.gerMouseEvent UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius; // 0x60
        public dRecorder UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius; // 0x64
        public dRecorder UnityEngine.UIElements.IResolvedStyle.borderTopWidth; // 0x74
        public rsor.UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty UnityEngine.UIElements.IResolvedStyle.bottom; // 0x88
        public dRecorder UnityEngine.UIElements.IResolvedStyle.color; // 0x1D0
        public dRecorder UnityEngine.UIElements.IResolvedStyle.display; // 0x1E0
        public ÎÏÌÎÎÎÌÌÌ.t UnityEngine.UIElements.IResolvedStyle.flexDirection;
        public dRecorder UnityEngine.UIElements.IResolvedStyle.flexGrow; // 0x1F0
        public ÎÏÌÎÎÎÌÌÌ.t UnityEngine.UIElements.IResolvedStyle.flexShrink;
        public tSizeBias UnityEngine.UIElements.IResolvedStyle.height; // 0x200
        public tSizeBias UnityEngine.UIElements.IResolvedStyle.left; // 0x240
        public dRecorder UnityEngine.UIElements.IResolvedStyle.marginBottom; // 0x280
        public dRecorder UnityEngine.UIElements.IResolvedStyle.marginLeft; // 0x290
        public bool UnityEngine.UIElements.IResolvedStyle.marginRight; // 0x2A0
        public dRecorder UnityEngine.UIElements.IResolvedStyle.marginTop; // 0x20
        public ÎÏÌÎÎÎÌÌÌ.ta UnityEngine.UIElements.IResolvedStyle.minHeight; // 0x2A4
        public ÎÏÌÎÎÎÌÌÌ.ta UnityEngine.UIElements.IResolvedStyle.minWidth; // 0x2A8
        public ÎÏÌÎÎÎÌÌÌ.ta UnityEngine.UIElements.IResolvedStyle.opacity; // 0x2AC
        public int UnityEngine.UIElements.IResolvedStyle.paddingBottom; // 0x2B0
        public ÎÏÌÎÎÎÌÌÌ.? UnityEngine.UIElements.IResolvedStyle.paddingLeft; // 0x2B4
        public ÎÏÍÏÍÎÎÎÎÌÍÎÏÌÌÌÎ UnityEngine.UIElements.IResolvedStyle.paddingRight; // 0x2B8
        public ÎÏÌÎÎÎÌÌÌ.taPosition UnityEngine.UIElements.IResolvedStyle.paddingTop; // 0x2C0
        public ÎÏÌÎÎÎÌÌÌ.Engine.UIElements.IStyle.transformOrigin UnityEngine.UIElements.IResolvedStyle.right; // 0x318
        public int UnityEngine.UIElements.IResolvedStyle.scale; // 0x320
        public uint UnityEngine.UIElements.IResolvedStyle.top; // 0x324
        public int UnityEngine.UIElements.IResolvedStyle.transformOrigin; // 0x328
        public bool UnityEngine.UIElements.IResolvedStyle.translate; // 0x32C
        public ÎÏÌÎÎÎÌÌÌ.tyIdFromString UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor; // 0x330
        public ÎÏÌÎÎÎÌÌÌ.tyIdFromString UnityEngine.UIElements.IResolvedStyle.unitySliceLeft; // 0x334
        public ileFullDirectoryInformation<ÎÏÌÎÎÎÌÌÌ.yEngine.UIElements.IMouseEventInternal.sourcePointerEvent> UnityEngine.UIElements.IResolvedStyle.unitySliceRight; // 0x338
        public object UnityEngine.UIElements.IResolvedStyle.unitySliceScale; // 0x30
        public ertTransitionFunction>b__12_16 UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor; // 0x340
        public atrix_Injected UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth; // 0x38
        public atrix_Injected UnityEngine.UIElements.IResolvedStyle.visibility; // 0x348
        public URA.woDigitYearMax<ileDrawChainBegin.ax> UnityEngine.UIElements.IResolvedStyle.width; // 0x350
        public uint hasRunningAnimations; // 0x40
        public uint hasCompletedAnimations; // 0x358
        public uint UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount; // 0x35C
        public ÎÏÌÎÎÎÌÌÌ.omLeftRadius UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount; // 0x360
        public int styleAnimation; // 0x368
        public int isCompositeRoot; // 0x36C
        public int isHierarchyDisplayed; // 0x370
        public int viewDataKey; // 0x374
        public string enableViewDataPersistence;
        public TopElementUnderPointer userData; // 0x378
        public bool canGrabFocus; // 0x380
        public bool focusController; // 0x381
        public ÎÏÌÎÎÎÌÌÌ.omLeftRadius usageHints; // 0x388
        public ÎÏÌÎÎÎÌÌÌ.omLeftRadius renderHints; // 0x390
        public URA.woDigitYearMax<ÎÏÌÎÎÎÌÌÌ.omLeftRadius> transform; // 0x48
        public URA.woDigitYearMax<ÎÏÌÎÎÎÌÌÌ.omLeftRadius> UnityEngine.UIElements.ITransform.position; // 0x398
        public ÎÏÌÎÎÎÌÌÌ.opped UnityEngine.UIElements.ITransform.scale; // 0x3A0
        public ÎÏÌÎÎÎÌÌÌ.nt isLayoutManual; // 0x3A8
        public se scaledPixelsPerPoint; // 0x50
        public ÎÏÌÎÎÎÌÌÌ.lidateElement layout; // 0x3B0
        public URA.woDigitYearMax<ÎÏÌÎÎÎÌÌÌ.inter> contentRect; // 0x3B8
        public tor.neStore paddingRect; // 0x58
        public object isBoundingBoxDirty; // 0x60
        public URA.DateTime<?,utCubic> isWorldBoundingBoxDirty; // 0x68
        public utCubic isWorldBoundingBoxOrDependenciesDirty; // 0x3C0

        // ── Methods ──
        public void get_resolvedStyle(){} // RVA: 0x7FFD4F9181E0
        public void UnityEngine.UIElements.IResolvedStyle.get_backgroundColor(){} // RVA: 0x7FFD54FFEBD0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor(){} // RVA: 0x7FFD54FFEC30
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius(){} // RVA: 0x7FFD54FFEC90
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius(){} // RVA: 0x7FFD54FFECF0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth(){} // RVA: 0x7FFD54FFED50
        public void UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor(){} // RVA: 0x7FFD54FFEDC0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth(){} // RVA: 0x7FFD54FFEE20
        public void UnityEngine.UIElements.IResolvedStyle.get_borderRightColor(){} // RVA: 0x7FFD54FFEE90
        public void UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth(){} // RVA: 0x7FFD54FFEEF0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopColor(){} // RVA: 0x7FFD54FFEF60
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius(){} // RVA: 0x7FFD54FFEFC0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius(){} // RVA: 0x7FFD54FFF020
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth(){} // RVA: 0x7FFD54FFF080
        public void UnityEngine.UIElements.IResolvedStyle.get_bottom(){} // RVA: 0x7FFD54FFF0F0
        public void UnityEngine.UIElements.IResolvedStyle.get_color(){} // RVA: 0x7FFD54FFF160
        public void UnityEngine.UIElements.IResolvedStyle.get_display(){} // RVA: 0x7FFD54FFF1C0
        public void UnityEngine.UIElements.IResolvedStyle.get_flexDirection(){} // RVA: 0x7FFD54FFF210
        public void UnityEngine.UIElements.IResolvedStyle.get_flexGrow(){} // RVA: 0x7FFD54FFF260
        public void UnityEngine.UIElements.IResolvedStyle.get_flexShrink(){} // RVA: 0x7FFD54FFF2B0
        public void UnityEngine.UIElements.IResolvedStyle.get_height(){} // RVA: 0x7FFD54FFF300
        public void UnityEngine.UIElements.IResolvedStyle.get_left(){} // RVA: 0x7FFD54FFF370
        public void UnityEngine.UIElements.IResolvedStyle.get_marginBottom(){} // RVA: 0x7FFD54FFF3E0
        public void UnityEngine.UIElements.IResolvedStyle.get_marginLeft(){} // RVA: 0x7FFD54FFF450
        public void UnityEngine.UIElements.IResolvedStyle.get_marginRight(){} // RVA: 0x7FFD54FFF4C0
        public void UnityEngine.UIElements.IResolvedStyle.get_marginTop(){} // RVA: 0x7FFD54FFF530
        public void UnityEngine.UIElements.IResolvedStyle.get_minHeight(){} // RVA: 0x7FFD54FFF5A0
        public void UnityEngine.UIElements.IResolvedStyle.get_minWidth(){} // RVA: 0x7FFD54FFF600
        public void UnityEngine.UIElements.IResolvedStyle.get_opacity(){} // RVA: 0x7FFD54FFF660
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingBottom(){} // RVA: 0x7FFD54FFF6B0
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingLeft(){} // RVA: 0x7FFD54FFF720
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingRight(){} // RVA: 0x7FFD54FFF790
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingTop(){} // RVA: 0x7FFD54FFF800
        public void UnityEngine.UIElements.IResolvedStyle.get_right(){} // RVA: 0x7FFD54FFF870
        public void UnityEngine.UIElements.IResolvedStyle.get_scale(){} // RVA: 0x7FFD54FFF8E0
        public void UnityEngine.UIElements.IResolvedStyle.get_top(){} // RVA: 0x7FFD54FFF940
        public void UnityEngine.UIElements.IResolvedStyle.get_transformOrigin(){} // RVA: 0x7FFD54FFF9B0
        public void UnityEngine.UIElements.IResolvedStyle.get_translate(){} // RVA: 0x7FFD54FFF9E0
        public void UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor(){} // RVA: 0x7FFD54FFFA10
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft(){} // RVA: 0x7FFD54FFFA70
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight(){} // RVA: 0x7FFD54FFFAC0
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale(){} // RVA: 0x7FFD54FFFB10
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor(){} // RVA: 0x7FFD54FFFB60
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth(){} // RVA: 0x7FFD54FFFBC0
        public void UnityEngine.UIElements.IResolvedStyle.get_visibility(){} // RVA: 0x7FFD54FFFC10
        public void UnityEngine.UIElements.IResolvedStyle.get_width(){} // RVA: 0x7FFD54FFFC60
        public void get_hasRunningAnimations(){} // RVA: 0x7FFD54FFFCD0
        public void get_hasCompletedAnimations(){} // RVA: 0x7FFD54FFFD30
        public void UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount(){} // RVA: 0x7FFD4E39CCD0
        public void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(){} // RVA: 0x7FFD4E39CCE0
        public void UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount(){} // RVA: 0x7FFD4EEFEDC0
        public void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(){} // RVA: 0x7FFD4F58A6E0
        public void GetStylePropertyAnimationSystem(){} // RVA: 0x7FFD54FFFD90
        public void get_styleAnimation(){} // RVA: 0x7FFD4F9181E0
        public void UnityEngine.UIElements.IStylePropertyAnimations.Start(){} // RVA: 0x7FFD55001220 | overloaded x15
        public void UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(){} // RVA: 0x7FFD55000290
        public void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(){} // RVA: 0x7FFD550013A0
        public void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations(){} // RVA: 0x7FFD55001420
        public void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(){} // RVA: 0x7FFD55001520
        public void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(){} // RVA: 0x7FFD550015A0
        public void TryConvertLengthUnits(){} // RVA: 0x7FFD55001720
        public void TryConvertTransformOriginUnits(){} // RVA: 0x7FFD55001A20
        public void TryConvertTranslateUnits(){} // RVA: 0x7FFD55001AD0
        public void TryConvertBackgroundSizeUnits(){} // RVA: 0x7FFD55001B80
        public void GetParentSizeForLengthConversion(){} // RVA: 0x7FFD55001C40
        public void get_isCompositeRoot(){} // RVA: 0x7FFD55001E80
        public void set_isCompositeRoot(){} // RVA: 0x7FFD55001E90
        public void get_isHierarchyDisplayed(){} // RVA: 0x7FFD55001ED0
        public void set_isHierarchyDisplayed(){} // RVA: 0x7FFD55001EE0
        public void get_viewDataKey(){} // RVA: 0x7FFD4E409500
        public void set_viewDataKey(){} // RVA: 0x7FFD55001F10
        public void get_enableViewDataPersistence(){} // RVA: 0x7FFD55001FE0
        public void set_enableViewDataPersistence(){} // RVA: 0x7FFD55001FF0
        public void get_userData(){} // RVA: 0x7FFD55002020
        public void set_userData(){} // RVA: 0x7FFD550020A0
        public void get_canGrabFocus(){} // RVA: 0x7FFD55002120
        public void get_focusController(){} // RVA: 0x7FFD55002220
        public void get_usageHints(){} // RVA: 0x7FFD55002270
        public void set_usageHints(){} // RVA: 0x7FFD55002290
        public void get_renderHints(){} // RVA: 0x7FFD54D70330
        public void set_renderHints(){} // RVA: 0x7FFD55002320
        public void MarkRenderHintsClean(){} // RVA: 0x7FFD55002390
        public void get_transform(){} // RVA: 0x7FFD53ABD800
        public void UnityEngine.UIElements.ITransform.get_position(){} // RVA: 0x7FFD550023A0
        public void UnityEngine.UIElements.ITransform.set_position(){} // RVA: 0x7FFD55002420
        public void UnityEngine.UIElements.ITransform.get_scale(){} // RVA: 0x7FFD55002630
        public void get_isLayoutManual(){} // RVA: 0x7FFD550026B0
        public void set_isLayoutManual(){} // RVA: 0x7FFD550026C0
        public void get_scaledPixelsPerPoint(){} // RVA: 0x7FFD550026F0
        public void get_layout(){} // RVA: 0x7FFD55002790
        public void set_layout(){} // RVA: 0x7FFD55002970
        public void ClearManualLayout(){} // RVA: 0x7FFD55003120
        public void get_contentRect(){} // RVA: 0x7FFD55003390
        public void get_paddingRect(){} // RVA: 0x7FFD55003620
        public void get_isBoundingBoxDirty(){} // RVA: 0x7FFD55003780
        public void set_isBoundingBoxDirty(){} // RVA: 0x7FFD55003790
        public void set_isWorldBoundingBoxDirty(){} // RVA: 0x7FFD550037C0
        public void get_isWorldBoundingBoxOrDependenciesDirty(){} // RVA: 0x7FFD550037F0
        public void get_boundingBox(){} // RVA: 0x7FFD55003800
        public void get_worldBoundingBox(){} // RVA: 0x7FFD55003850
        public void get_boundingBoxInParentSpace(){} // RVA: 0x7FFD55003920
        public void UpdateBoundingBox(){} // RVA: 0x7FFD55003970
        public void UpdateWorldBoundingBox(){} // RVA: 0x7FFD55003CD0
        public void get_worldBound(){} // RVA: 0x7FFD55003D70
        public void get_localBound(){} // RVA: 0x7FFD55003E70
        public void get_rect(){} // RVA: 0x7FFD55003EF0
        public void get_isWorldTransformDirty(){} // RVA: 0x7FFD55003F50
        public void set_isWorldTransformDirty(){} // RVA: 0x7FFD5467EBE0
        public void set_isWorldTransformInverseDirty(){} // RVA: 0x7FFD5467EC10
        public void get_isWorldTransformInverseOrDependenciesDirty(){} // RVA: 0x7FFD55003F60
        public void get_worldTransform(){} // RVA: 0x7FFD55003F70
        public void get_worldTransformRef(){} // RVA: 0x7FFD55003FE0
        public void get_worldTransformInverse(){} // RVA: 0x7FFD55004010
        public void UpdateWorldTransform(){} // RVA: 0x7FFD550040C0
        public void UpdateWorldTransformInverse(){} // RVA: 0x7FFD550043D0
        public void get_isWorldClipDirty(){} // RVA: 0x7FFD55004480
        public void set_isWorldClipDirty(){} // RVA: 0x7FFD55004490
        public void get_worldClip(){} // RVA: 0x7FFD550044C0
        public void get_worldClipMinusGroup(){} // RVA: 0x7FFD55004510
        public void get_worldClipIsInfinite(){} // RVA: 0x7FFD55004560
        public void EnsureWorldTransformAndClipUpToDate(){} // RVA: 0x7FFD550045A0
        public void UpdateWorldClip(){} // RVA: 0x7FFD550045E0
        public void CombineClipRects(){} // RVA: 0x7FFD55004A30
        public void SubstractBorderPadding(){} // RVA: 0x7FFD55004AC0
        public void ComputeAAAlignedBound(){} // RVA: 0x7FFD55004D80
        public void get_pseudoStates(){} // RVA: 0x7FFD55004FE0
        public void set_pseudoStates(){} // RVA: 0x7FFD55004FF0
        public void get_containedPointerIds(){} // RVA: 0x7FFD53F32F30
        public void set_containedPointerIds(){} // RVA: 0x7FFD53F32F40
        public void UpdateHoverPseudoState(){} // RVA: 0x7FFD55005080
        public void IsPartOfCapturedChain(){} // RVA: 0x7FFD55005190
        public void get_pickingMode(){} // RVA: 0x7FFD53F32F50
        public void set_pickingMode(){} // RVA: 0x7FFD55005260
        public void get_name(){} // RVA: 0x7FFD54D3F6C0
        public void set_name(){} // RVA: 0x7FFD550052B0
        public void get_classList(){} // RVA: 0x7FFD55005380
        public void get_fullTypeName(){} // RVA: 0x7FFD55005480
        public void get_typeName(){} // RVA: 0x7FFD55005530
        public void get_yogaNode(){} // RVA: 0x7FFD4EDDA5E0
        public void set_yogaNode(){} // RVA: 0x7FFD4EDEA820
        public void get_computedStyle(){} // RVA: 0x7FFD55005560
        public void get_hasInlineStyle(){} // RVA: 0x7FFD55005570
        public void get_styleInitialized(){} // RVA: 0x7FFD55005580
        public void set_styleInitialized(){} // RVA: 0x7FFD55005590
        public void ChangeIMGUIContainerCount(){} // RVA: 0x7FFD550055C0
        public void .ctor(){} // RVA: 0x7FFD55005600
        public void ExecuteDefaultAction(){} // RVA: 0x7FFD55005CA0
        public void GetTooltipRect(){} // RVA: 0x7FFD550064E0
        public void SetTooltip(){} // RVA: 0x7FFD55006510
        public void Focus(){} // RVA: 0x7FFD55006680
        public void SetPanel(){} // RVA: 0x7FFD55006820
        public void WillChangePanel(){} // RVA: 0x7FFD550073D0
        public void HasChangedPanel(){} // RVA: 0x7FFD55007560
        public void SendEvent(){} // RVA: 0x7FFD55007870 | overloaded x2
        public void IncrementVersion(){} // RVA: 0x7FFD55007890
        public void InvokeHierarchyChanged(){} // RVA: 0x7FFD550078C0
        public void SetEnabledFromHierarchyPrivate(){} // RVA: 0x7FFD55007900
        public void get_isParentEnabledInHierarchy(){} // RVA: 0x7FFD55007DC0
        public void get_enabledInHierarchy(){} // RVA: 0x7FFD55007E00
        public void get_enabledSelf(){} // RVA: 0x7FFD55007E10
        public void set_enabledSelf(){} // RVA: 0x7FFD55007E20
        public void SetEnabled(){} // RVA: 0x7FFD55007E30
        public void PropagateEnabledToChildren(){} // RVA: 0x7FFD55007E50
        public void get_languageDirection(){} // RVA: 0x7FFD54B895A0
        public void get_localLanguageDirection(){} // RVA: 0x7FFD54B895E0
        public void set_localLanguageDirection(){} // RVA: 0x7FFD55007F30
        public void get_visible(){} // RVA: 0x7FFD55008060
        public void set_visible(){} // RVA: 0x7FFD550080C0
        public void MarkDirtyRepaint(){} // RVA: 0x7FFD55008140
        public void get_generateVisualContent(){} // RVA: 0x7FFD4EE32A20
        public void set_generateVisualContent(){} // RVA: 0x7FFD55008170
        public void InvokeGenerateVisualContent(){} // RVA: 0x7FFD550081D0
        public void GetFullHierarchicalViewDataKey(){} // RVA: 0x7FFD550083D0 | overloaded x2
        public void GetOrCreateViewData(){} // RVA: 0x7FFD4E2ADC40
        public void OverwriteFromViewData(){} // RVA: 0x7FFD550084C0
        public void SaveViewData(){} // RVA: 0x7FFD55008720
        public void IsViewDataPersitenceSupportedOnChildren(){} // RVA: 0x7FFD550087B0
        public void OnViewDataReady(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void ContainsPoint(){} // RVA: 0x7FFD550088B0
        public void get_requireMeasureFunction(){} // RVA: 0x7FFD55008910
        public void set_requireMeasureFunction(){} // RVA: 0x7FFD55008920
        public void AssignMeasureFunction(){} // RVA: 0x7FFD55008990
        public void RemoveMeasureFunction(){} // RVA: 0x7FFD55008A30
        public void DoMeasure(){} // RVA: 0x7FFD55008A60
        public void Measure(){} // RVA: 0x7FFD55008A80
        public void FinalizeLayout(){} // RVA: 0x7FFD55008BE0
        public void SetInlineRule(){} // RVA: 0x7FFD55008CC0
        public void SetComputedStyle(){} // RVA: 0x7FFD55008DB0
        public void ToString(){} // RVA: 0x7FFD55009040
        public void GetClassesForIteration(){} // RVA: 0x7FFD54D3F730
        public void AddToClassList(){} // RVA: 0x7FFD550091D0
        public void RemoveFromClassList(){} // RVA: 0x7FFD550093F0
        public void EnableInClassList(){} // RVA: 0x7FFD55009580
        public void ClassListContains(){} // RVA: 0x7FFD550095B0
        public void GetProperty(){} // RVA: 0x7FFD55009710
        public void SetProperty(){} // RVA: 0x7FFD55009790
        public void HasProperty(){} // RVA: 0x7FFD55009810
        public void TryGetPropertyInternal(){} // RVA: 0x7FFD55009890
        public void CheckUserKeyArgument(){} // RVA: 0x7FFD55009A00
        public void SetPropertyInternal(){} // RVA: 0x7FFD55009B60
        public void UpdateCursorStyle(){} // RVA: 0x7FFD55009EA0
        public void get_subRenderTargetMode(){} // RVA: 0x7FFD5500A2B0
        public void get_defaultMaterial(){} // RVA: 0x7FFD5500A2C0
        public void GetAnimationSystem(){} // RVA: 0x7FFD5500A2D0
        public void RegisterAnimation(){} // RVA: 0x7FFD5500A380
        public void UnregisterAnimation(){} // RVA: 0x7FFD5500A530
        public void UnregisterRunningAnimations(){} // RVA: 0x7FFD5500A5F0
        public void RegisterRunningAnimations(){} // RVA: 0x7FFD5500A680
        public void StartAnimation(){} // RVA: 0x7FFD4E2ADC40
        public void AssignStyleValues(){} // RVA: 0x7FFD5500A6F0
        public void ReadCurrentValues(){} // RVA: 0x7FFD5500B400
        public void UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(){} // RVA: 0x7FFD5500C410
        public void Start(){} // RVA: 0x7FFD5500C5A0
        public void DirtyNextParentWithEventCallback(){} // RVA: 0x7FFD5500C7D0
        public void SetAsNextParentWithEventCallback(){} // RVA: 0x7FFD5500C860
        public void GetCachedNextParentWithEventCallback(){} // RVA: 0x7FFD5500C930
        public void get_nextParentWithEventCallback(){} // RVA: 0x7FFD5500C9B0
        public void PropagateCachedNextParentWithEventCallback(){} // RVA: 0x7FFD5500CBF0
        public void get_eventCallbackCategories(){} // RVA: 0x7FFD5500CCA0
        public void set_eventCallbackCategories(){} // RVA: 0x7FFD5500CCB0
        public void get_eventCallbackParentCategories(){} // RVA: 0x7FFD5500CD30
        public void get_isEventCallbackParentCategoriesDirty(){} // RVA: 0x7FFD5500CE30
        public void set_isEventCallbackParentCategoriesDirty(){} // RVA: 0x7FFD5500CE40
        public void UpdateCallbackParentCategories(){} // RVA: 0x7FFD5500CE70
        public void HasEventCallbacks(){} // RVA: 0x7FFD5500CF40
        public void HasParentEventCallbacksOrDefaultActions(){} // RVA: 0x7FFD5500CF60
        public void HasEventCallbacksOrDefaultActions(){} // RVA: 0x7FFD5500CFB0
        public void HasParentEventCallbacksOrDefaultActionAtTarget(){} // RVA: 0x7FFD5500CFE0
        public void HasEventCallbacksOrDefaultActionAtTarget(){} // RVA: 0x7FFD5500D020
        public void HasDefaultAction(){} // RVA: 0x7FFD5500D050
        public void get_experimental(){} // RVA: 0x7FFD53ABD800
        public void UnityEngine.UIElements.IExperimentalFeatures.get_animation(){} // RVA: 0x7FFD53ABD800
        public void get_hierarchy(){} // RVA: 0x7FFD4EDC7A10
        public void set_hierarchy(){} // RVA: 0x7FFD4EDEF030
        public void get_isRootVisualContainer(){} // RVA: 0x7FFD5500D070
        public void set_isRootVisualContainer(){} // RVA: 0x7FFD5500D080
        public void get_disableClipping(){} // RVA: 0x7FFD5500D090
        public void set_disableClipping(){} // RVA: 0x7FFD5500D0A0
        public void ShouldClip(){} // RVA: 0x7FFD5500D0D0
        public void get_parent(){} // RVA: 0x7FFD5500D130
        public void get_elementPanel(){} // RVA: 0x7FFD4EDDD300
        public void set_elementPanel(){} // RVA: 0x7FFD4EDCF580
        public void get_panel(){} // RVA: 0x7FFD5500D140
        public void get_contentContainer(){} // RVA: 0x7FFD53ABD800
        public void set_visualTreeAssetSource(){} // RVA: 0x7FFD4EDEEBB0
        public void Add(){} // RVA: 0x7FFD5500D150
        public void Insert(){} // RVA: 0x7FFD5500D2B0
        public void Clear(){} // RVA: 0x7FFD5500D3A0
        public void ElementAt(){} // RVA: 0x7FFD5500D420
        public void get_Item(){} // RVA: 0x7FFD5500D430
        public void get_childCount(){} // RVA: 0x7FFD5500D510
        public void IndexOf(){} // RVA: 0x7FFD5500D5B0
        public void ElementAtTreePath(){} // RVA: 0x7FFD5500D6A0
        public void FindElementInTree(){} // RVA: 0x7FFD5500D940
        public void Children(){} // RVA: 0x7FFD5500DAB0
        public void BringToFront(){} // RVA: 0x7FFD5500DB70
        public void SendToBack(){} // RVA: 0x7FFD5500DBC0
        public void PlaceBehind(){} // RVA: 0x7FFD5500DC10
        public void RemoveFromHierarchy(){} // RVA: 0x7FFD5500DD30
        public void GetFirstOfType(){} // RVA: 0x7FFD4E2ADC40
        public void GetFirstAncestorOfType(){} // RVA: 0x7FFD4E2ADC40
        public void GetFirstAncestorWhere(){} // RVA: 0x7FFD5500DE50
        public void Contains(){} // RVA: 0x7FFD5500DED0
        public void GatherAllChildren(){} // RVA: 0x7FFD5500DF20
        public void FindCommonAncestor(){} // RVA: 0x7FFD5500E040
        public void GetRoot(){} // RVA: 0x7FFD5500E1D0
        public void GetRootVisualContainer(){} // RVA: 0x7FFD5500E260
        public void GetNextElementDepthFirst(){} // RVA: 0x7FFD5500E2A0
        public void GetPreviousElementDepthFirst(){} // RVA: 0x7FFD5500E3E0
        public void RetargetElement(){} // RVA: 0x7FFD5500E530
        public void get_positionWithLayout(){} // RVA: 0x7FFD5500E5E0
        public void GetPivotedMatrixWithLayout(){} // RVA: 0x7FFD5500E670
        public void get_hasDefaultRotationAndScale(){} // RVA: 0x7FFD5500EB10
        public void Min(){} // RVA: 0x7FFD5500EC40
        public void Max(){} // RVA: 0x7FFD5500EC50
        public void TransformAlignedRectToParentSpace(){} // RVA: 0x7FFD5500EC60
        public void CalculateConservativeRect(){} // RVA: 0x7FFD5500EDA0
        public void TransformAlignedRect(){} // RVA: 0x7FFD5500F180
        public void OrderMinMaxRect(){} // RVA: 0x7FFD5500F200
        public void MultiplyMatrix44Point2(){} // RVA: 0x7FFD5500F250
        public void MultiplyVector2(){} // RVA: 0x7FFD5500F2A0
        public void MultiplyMatrix34(){} // RVA: 0x7FFD5500F2E0
        public void TranslateMatrix34(){} // RVA: 0x7FFD5500F510
        public void TranslateMatrix34InPlace(){} // RVA: 0x7FFD5500F620
        public void get_schedule(){} // RVA: 0x7FFD53ABD800
        public void UnityEngine.UIElements.IVisualElementScheduler.Execute(){} // RVA: 0x7FFD5500F7E0 | overloaded x2
        public void get_style(){} // RVA: 0x7FFD5500F910
        public void get_customStyle(){} // RVA: 0x7FFD5500F9D0
        public void get_styleSheets(){} // RVA: 0x7FFD4ECF6FB0
        public void AddStyleSheetPath(){} // RVA: 0x7FFD5500FAB0
        public void ResolveLengthValue(){} // RVA: 0x7FFD5500FEB0
        public void ResolveTranslate(){} // RVA: 0x7FFD55010000
        public void ResolveTransformOrigin(){} // RVA: 0x7FFD550101B0
        public void ResolveRotation(){} // RVA: 0x7FFD550103B0
        public void ResolveScale(){} // RVA: 0x7FFD55010520
        public void get_tooltip(){} // RVA: 0x7FFD55010620
        public void set_tooltip(){} // RVA: 0x7FFD550106C0
        public void GetOrCreateTypeData(){} // RVA: 0x7FFD55010840
        public void get_typeData(){} // RVA: 0x7FFD550109A0
        public void .cctor(){} // RVA: 0x7FFD55010B60
        public void <AssignMeasureFunction>b__432_0(){} // RVA: 0x7FFD55008A80
    }

    public class VisualElementAsset : UxmlAsset
    {
        public string ruleIndex; // 0x30
        public int classes; // 0x38
        public string stylesheetPaths; // 0x40
        public ÎÏÌÎÎÎÌÌÌ.? hasStylesheetPaths; // 0x48
        public string[] stylesheets; // 0x50
        public URA.woDigitYearMax<string> hasStylesheets; // 0x58
        public URA.woDigitYearMax<ÎÏÌÎÎÎÌÌÌ.inter> skipClone; // 0x60
        public bool m_SkipClone; // 0x68

        // ── Methods ──
        public void get_ruleIndex(){} // RVA: 0x7FFD54CFE3E0
        public void get_classes(){} // RVA: 0x7FFD54D3F8D0
        public void get_stylesheetPaths(){} // RVA: 0x7FFD5504C510
        public void get_hasStylesheetPaths(){} // RVA: 0x7FFD52C3EE50
        public void get_stylesheets(){} // RVA: 0x7FFD5504C5D0
        public void get_hasStylesheets(){} // RVA: 0x7FFD4FC56B90
        public void get_skipClone(){} // RVA: 0x7FFD4E409570
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void OnAfterDeserialize(){} // RVA: 0x7FFD5504C690
    }

    public class VisualTreeAsset : ScriptableObject
    {
        public string importedWithErrors;
        public bool importedWithWarnings; // 0x18
        public bool templateDependencies; // 0x19
        public URA.DateTime<string,ÎÏÌÎÎÎÌÌÌ.omLeftRadius> stylesheets; // 0x8
        public URA.woDigitYearMax<urrentTimeMs> visualElementAssets; // 0x20
        public ÎÏÌÎÎÎÌÌÌ.inter templateAssets; // 0x28
        public URA.woDigitYearMax<ÎÏÌÎÎÎÌÌÌ.ta> uxmlObjectEntries; // 0x30
        public URA.woDigitYearMax<ÎÏÌÎÎÎÌÌÌ.nual> uxmlObjectIds; // 0x38
        public URA.woDigitYearMax<Definitions> slots; // 0x40
        public URA.woDigitYearMax<int> contentContainerId; // 0x48
        public URA.woDigitYearMax<?> contentHash; // 0x50
        public URA.woDigitYearMax<_Lengths> m_Slots; // 0x58
        public int m_ContentContainerId; // 0x60
        public int m_ContentHash; // 0x64

        // ── Methods ──
        public void get_importedWithErrors(){} // RVA: 0x7FFD54C48D80
        public void set_importedWithErrors(){} // RVA: 0x7FFD4E35C4F0
        public void get_importedWithWarnings(){} // RVA: 0x7FFD5502AAC0
        public void set_importedWithWarnings(){} // RVA: 0x7FFD4E935120
        public void GetNextChildSerialNumber(){} // RVA: 0x7FFD5504F650
        public void get_templateDependencies(){} // RVA: 0x7FFD5504F6E0
        public void get_stylesheets(){} // RVA: 0x7FFD5504F790
        public void get_visualElementAssets(){} // RVA: 0x7FFD54CFE3D0
        public void set_visualElementAssets(){} // RVA: 0x7FFD4E36F890
        public void get_templateAssets(){} // RVA: 0x7FFD54D3F6C0
        public void set_templateAssets(){} // RVA: 0x7FFD4E5F0C20
        public void get_uxmlObjectEntries(){} // RVA: 0x7FFD4E3BE740
        public void get_uxmlObjectIds(){} // RVA: 0x7FFD4E3BC730
        public void RegisterUxmlObject(){} // RVA: 0x7FFD5504F840
        public void GetUxmlObjects(){}
        public void AssetEntryExists(){} // RVA: 0x7FFD5504FB80
        public void RegisterAssetEntry(){} // RVA: 0x7FFD5504FDA0
        public void GetAsset(){} // RVA: 0x7FFD4E2ADC40
        public void GetUxmlObjectEntry(){} // RVA: 0x7FFD5504FEF0
        public void GetUxmlObjectFactory(){} // RVA: 0x7FFD55050060
        public void get_slots(){} // RVA: 0x7FFD54D3F940
        public void set_slots(){} // RVA: 0x7FFD4E409510
        public void get_contentContainerId(){} // RVA: 0x7FFD54D70330
        public void set_contentContainerId(){} // RVA: 0x7FFD4E558C10
        public void Instantiate(){} // RVA: 0x7FFD55050610 | overloaded x2
        public void CloneTree(){} // RVA: 0x7FFD550508E0 | overloaded x5
        public void CloneSetupRecursively(){} // RVA: 0x7FFD55051120
        public void CompareForOrder(){} // RVA: 0x7FFD55051E80
        public void TryGetSlotInsertionPoint(){} // RVA: 0x7FFD55051EC0
        public void ResolveTemplate(){} // RVA: 0x7FFD55052060
        public void Create(){} // RVA: 0x7FFD55052430
        public void AssignClassListFromAssetToElement(){} // RVA: 0x7FFD55052C10
        public void AssignStyleSheetFromAssetToElement(){} // RVA: 0x7FFD55052C80
        public void get_contentHash(){} // RVA: 0x7FFD54D70340
        public void set_contentHash(){} // RVA: 0x7FFD4FAF5120
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
        public void .cctor(){} // RVA: 0x7FFD55052F00
        public void <Create>g__CreateError|65_0(){} // RVA: 0x7FFD55053080
    }

    public class VisualTreeUpdater : Object
    {
        public ÎÏÌÎÎÎÌÌÌ.opped m_Panel; // 0x10
        public extFieldChanged m_UpdaterArray; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54EE8A00
        public void Dispose(){} // RVA: 0x7FFD54EE8C90
        public void UpdateVisualTreePhase(){} // RVA: 0x7FFD54EE8DB0
        public void OnVersionChanged(){} // RVA: 0x7FFD54EE8F50
        public void SetUpdater(){} // RVA: 0x7FFD4E090ED0
        public void GetUpdater(){} // RVA: 0x7FFD54EE9090
        public void SetDefaultUpdaters(){} // RVA: 0x7FFD54EE90D0
    }

}