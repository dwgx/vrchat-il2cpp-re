// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 30
// Methods: 560

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class ValidateCommandEvent : CommandEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F262A0
        public void .ctor(){} // RVA: 0x7FFE87F26390
    }

    public class Vector2Field : BaseCompositeField`3
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFE87E4DF30
        public void .ctor(){} // RVA: 0x7FFE87E4E6A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87E4E7E0
    }

    public class Vector2IntField : BaseCompositeField`3
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFE87E51CC0
        public void .ctor(){} // RVA: 0x7FFE87E52430 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87E52570
    }

    public class Vector3Field : BaseCompositeField`3
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFE87E4EE90
        public void .ctor(){} // RVA: 0x7FFE87E4F7A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87E4F8E0
    }

    public class Vector3IntField : BaseCompositeField`3
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFE87E52E70
        public void .ctor(){} // RVA: 0x7FFE87E53780 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87E538C0
    }

    public class Vector4Field : BaseCompositeField`3
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFE87E50320
        public void .ctor(){} // RVA: 0x7FFE87E51000 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87E51140
    }

    public class VectorImage : ScriptableObject
    {
        public int version; // 0x18
        public UnityEngine.Texture2D atlas; // 0x20

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFE815E8460
        public void get_height(){} // RVA: 0x7FFE81103970
        public void .ctor(){} // RVA: 0x7FFE87E66150
    }

    public class VectorImageVertex : ValueType
    {
    }

    public class Vertex : ValueType
    {
    }

    public class VerticalVirtualizationController`1 : CollectionVirtualizationController
    {
        public UnityEngine.Pool.ObjectPool`1<T> m_Pool;
        public UnityEngine.UIElements.BaseVerticalCollectionView m_CollectionView;
        public System.Collections.Generic.List`1<T> m_ActiveItems;
        public T m_DraggedItem;
        public int m_LastFocusedElementIndex;
        public System.Collections.Generic.List`1<int> m_LastFocusedElementTreeChildIndexes;
        public System.Func`2<T,bool> m_VisibleItemPredicateDelegate;
        public System.Collections.Generic.List`1<T> m_ScrollInsertionList;
        public UnityEngine.UIElements.VisualElement m_EmptyRows;

        // ── Methods ──
        public void get_activeItems(){} // RVA: 0x7FFE80E2E2E0
        public void get_itemsCount(){} // RVA: 0x7FFE80E2EDB0
        public void VisibleItemPredicate(){} // RVA: 0x7FFE810A1420
        public void get_firstVisibleItem(){} // RVA: 0x7FFE810A1420
        public void get_lastVisibleItem(){} // RVA: 0x7FFE810A1420
        public void get_visibleItemCount(){} // RVA: 0x7FFE80E2EDB0
        public void get_serializedData(){} // RVA: 0x7FFE80E2E2E0
        public void get_firstVisibleIndex(){} // RVA: 0x7FFE80E2EDB0
        public void set_firstVisibleIndex(){} // RVA: 0x7FFE80E46530
        public void get_lastHeight(){} // RVA: 0x7FFE80E42E10
        public void get_alwaysRebindOnRefresh(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Refresh(){} // RVA: 0x7FFE80E466C0
        public void Setup(){} // RVA: 0x7FFE810A1420
        public void OnFocus(){} // RVA: 0x7FFE80E460A0
        public void OnBlur(){} // RVA: 0x7FFE80E460A0
        public void HandleFocus(){} // RVA: 0x7FFE80E4D070
        public void UpdateBackground(){} // RVA: 0x7FFE80E45FE0
        public void StartDragItem(){} // RVA: 0x7FFE80E460A0
        public void EndDrag(){} // RVA: 0x7FFE80E46530
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7FFE810A1420
        public void ReleaseItem(){} // RVA: 0x7FFE80E46530
        public void OnDestroyItem(){} // RVA: 0x7FFE80E460A0
        public void GetDraggedIndex(){} // RVA: 0x7FFE80E2EDB0
    }

    public class VisualData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFE87F9EBB0
        public void CopyFrom(){} // RVA: 0x7FFE87FA3140
        public void op_Equality(){} // RVA: 0x7FFE87FA3290
        public void Equals(){} // RVA: 0x7FFE87FA4860 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA4990
    }

    public class VisualElement : Focusable
    {
        public int _runningAnimationCount; // 0x30
        public int _completedAnimationCount; // 0x34
        public uint s_NextId;
        public System.Collections.Generic.List`1<string> s_EmptyClassList; // 0x8
        public UnityEngine.PropertyName userDataPropertyKey; // 0x10
        public string disabledUssClassName; // 0x18
        public string m_Name; // 0x38
        public System.Collections.Generic.List`1<string> m_ClassList; // 0x40
        public System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<UnityEngine.PropertyName,object>> m_PropertyBag; // 0x48
        public 0x6651F5C4 m_Flags; // 0x50
        public string m_ViewDataKey; // 0x58
        public 0x66518EFC m_RenderHints; // 0x60
        public UnityEngine.Rect lastLayout; // 0x64
        public UnityEngine.Rect lastPseudoPadding; // 0x74
        public UnityEngine.UIElements.UIR.RenderChainVEData renderChainData; // 0x88
        public UnityEngine.Rect m_Layout; // 0x1D0
        public UnityEngine.Rect m_BoundingBox; // 0x1E0
        public 0x6651F5C4 worldBoundingBoxDirtyDependencies;
        public UnityEngine.Rect m_WorldBoundingBox; // 0x1F0
        public 0x6651F5C4 worldTransformInverseDirtyDependencies;
        public UnityEngine.Matrix4x4 m_WorldTransformCache; // 0x200
        public UnityEngine.Matrix4x4 m_WorldTransformInverseCache; // 0x240
        public UnityEngine.Rect m_WorldClip; // 0x280
        public UnityEngine.Rect m_WorldClipMinusGroup; // 0x290
        public bool m_WorldClipIsInfinite; // 0x2A0
        public UnityEngine.Rect s_InfiniteRect; // 0x20
        public 0x6651F56C triggerPseudoMask; // 0x2A4
        public 0x6651F56C dependencyPseudoMask; // 0x2A8
        public 0x6651F56C m_PseudoStates; // 0x2AC
        public int _containedPointerIds; // 0x2B0
        public 0x6651F61C m_PickingMode; // 0x2B4
        public UnityEngine.Yoga.YogaNode _yogaNode; // 0x2B8
        public UnityEngine.UIElements.ComputedStyle m_Style; // 0x2C0
        public UnityEngine.UIElements.StyleVariableContext variableContext; // 0x318
        public int inheritedStylesHash; // 0x320
        public uint controlid; // 0x324
        public int imguiContainerDescendantCount; // 0x328
        public bool _enabledSelf; // 0x32C
        public 0x6651F674 m_LanguageDirection; // 0x330
        public 0x6651F674 m_LocalLanguageDirection; // 0x334
        public System.Action`1<UnityEngine.UIElements.MeshGenerationContext> _generateVisualContent; // 0x338
        public Unity.Profiling.ProfilerMarker k_GenerateVisualContentMarker; // 0x30
        public 0x6651A5AC m_SubRenderTargetMode; // 0x340
        public UnityEngine.Material s_runtimeMaterial; // 0x38
        public UnityEngine.Material m_defaultMaterial; // 0x348
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_RunningAnimations; // 0x350
        public uint s_NextParentVersion; // 0x40
        public uint m_NextParentCachedVersion; // 0x358
        public uint m_NextParentRequiredVersion; // 0x35C
        public UnityEngine.UIElements.VisualElement m_CachedNextParentWithEventCallback; // 0x360
        public int m_EventCallbackCategories; // 0x368
        public int m_CachedEventCallbackParentCategories; // 0x36C
        public int m_DefaultActionEventCategories; // 0x370
        public int m_DefaultActionAtTargetEventCategories; // 0x374
        public string k_RootVisualContainerName;
        public Hierarchy _hierarchy; // 0x378
        public bool _isRootVisualContainer; // 0x380
        public bool _cacheAsBitmap; // 0x381
        public UnityEngine.UIElements.VisualElement m_PhysicalParent; // 0x388
        public UnityEngine.UIElements.VisualElement m_LogicalParent; // 0x390
        public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement> s_EmptyList; // 0x48
        public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement> m_Children; // 0x398
        public UnityEngine.UIElements.BaseVisualElementPanel _elementPanel; // 0x3A0
        public UnityEngine.UIElements.VisualTreeAsset m_VisualTreeAssetSource; // 0x3A8
        public CustomStyleAccess s_CustomStyleAccess; // 0x50
        public UnityEngine.UIElements.InlineStyleAccess inlineStyleAccess; // 0x3B0
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet> styleSheetList; // 0x3B8
        public System.Text.RegularExpressions.Regex s_InternalStyleSheetPath; // 0x58
        public UnityEngine.PropertyName tooltipPropertyKey; // 0x60
        public System.Collections.Generic.Dictionary`2<System.Type,TypeData> s_TypeData; // 0x68
        public TypeData m_TypeData; // 0x3C0
        public UnityEngine.UIElements.VisualElement prev; // 0x10
        public UnityEngine.UIElements.VisualElement next; // 0x18
        public UnityEngine.UIElements.VisualElement groupTransformAncestor; // 0x20
        public UnityEngine.UIElements.VisualElement boneTransformAncestor; // 0x28
        public UnityEngine.UIElements.VisualElement prevDirty; // 0x30
        public UnityEngine.UIElements.VisualElement nextDirty; // 0x38
        public 0x665218D4 flags; // 0x40
        public int hierarchyDepth; // 0x44
        public 0x66521824 dirtiedValues; // 0x48
        public uint dirtyID; // 0x4C
        public UnityEngine.UIElements.UIR.RenderChainCommand firstCommand; // 0x50
        public UnityEngine.UIElements.UIR.RenderChainCommand lastCommand; // 0x58
        public UnityEngine.UIElements.UIR.RenderChainCommand firstClosingCommand; // 0x60
        public UnityEngine.UIElements.UIR.RenderChainCommand lastClosingCommand; // 0x68
        public bool isInChain; // 0x70
        public bool isHierarchyHidden; // 0x71
        public bool localFlipsWinding; // 0x72
        public bool localTransformScaleZero; // 0x73
        public bool worldFlipsWinding; // 0x74
        public bool worldTransformScaleZero; // 0x75
        public 0x665222CC clipMethod; // 0x78
        public int childrenStencilRef; // 0x7C
        public int childrenMaskDepth; // 0x80
        public bool disableNudging; // 0x84
        public UnityEngine.UIElements.UIR.MeshHandle data; // 0x88
        public UnityEngine.UIElements.UIR.MeshHandle closingData; // 0x90
        public UnityEngine.Matrix4x4 verticesSpace; // 0x98
        public int displacementUVStart; // 0xD8
        public int displacementUVEnd; // 0xDC
        public UnityEngine.UIElements.UIR.BMPAlloc transformID; // 0xE0
        public UnityEngine.UIElements.UIR.BMPAlloc clipRectID; // 0xE8
        public UnityEngine.UIElements.UIR.BMPAlloc opacityID; // 0xF0
        public UnityEngine.UIElements.UIR.BMPAlloc textCoreSettingsID; // 0xF8
        public UnityEngine.UIElements.UIR.BMPAlloc colorID; // 0x100
        public UnityEngine.UIElements.UIR.BMPAlloc backgroundColorID; // 0x108
        public UnityEngine.UIElements.UIR.BMPAlloc borderLeftColorID; // 0x110
        public UnityEngine.UIElements.UIR.BMPAlloc borderTopColorID; // 0x118
        public UnityEngine.UIElements.UIR.BMPAlloc borderRightColorID; // 0x120
        public UnityEngine.UIElements.UIR.BMPAlloc borderBottomColorID; // 0x128
        public UnityEngine.UIElements.UIR.BMPAlloc tintColorID; // 0x130
        public float compositeOpacity; // 0x138
        public UnityEngine.Color backgroundColor; // 0x13C
        public UnityEngine.UIElements.UIR.BasicNode`1<UnityEngine.UIElements.UIR.TextureEntry> textures; // 0x150
        public UnityEngine.UIElements.UIR.BMPAlloc Invalid;
        public int page; // 0x10
        public ushort pageLine; // 0x14
        public byte bitIndex; // 0x16
        public 0x665220BC ownedState; // 0x17
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.InheritedData> inheritedData; // 0x10
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData> layoutData; // 0x18
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData> rareData; // 0x20
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData> transformData; // 0x28
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData> transitionData; // 0x30
        public UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData> visualData; // 0x38
        public UnityEngine.Yoga.YogaNode yogaNode; // 0x40
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties; // 0x48
        public long matchingRulesHash; // 0x50
        public float dpiScaling; // 0x58
        public UnityEngine.UIElements.ComputedTransitionProperty[] computedTransitions; // 0x60
        public object field_130; // 0x470
        public object field_131;

        // ── Methods ──
        public void get_resolvedStyle(){} // RVA: 0x7FFE827C4A80
        public void UnityEngine.UIElements.IResolvedStyle.get_backgroundColor(){} // RVA: 0x7FFE87F87480
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor(){} // RVA: 0x7FFE87F874E0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius(){} // RVA: 0x7FFE87F87540
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius(){} // RVA: 0x7FFE87F875A0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth(){} // RVA: 0x7FFE87F87600
        public void UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor(){} // RVA: 0x7FFE87F87670
        public void UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth(){} // RVA: 0x7FFE87F876D0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderRightColor(){} // RVA: 0x7FFE87F87740
        public void UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth(){} // RVA: 0x7FFE87F877A0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopColor(){} // RVA: 0x7FFE87F87810
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius(){} // RVA: 0x7FFE87F87870
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius(){} // RVA: 0x7FFE87F878D0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth(){} // RVA: 0x7FFE87F87930
        public void UnityEngine.UIElements.IResolvedStyle.get_bottom(){} // RVA: 0x7FFE87F879A0
        public void UnityEngine.UIElements.IResolvedStyle.get_color(){} // RVA: 0x7FFE87F87A10
        public void UnityEngine.UIElements.IResolvedStyle.get_display(){} // RVA: 0x7FFE87F87A70
        public void UnityEngine.UIElements.IResolvedStyle.get_flexDirection(){} // RVA: 0x7FFE87F87AC0
        public void UnityEngine.UIElements.IResolvedStyle.get_flexGrow(){} // RVA: 0x7FFE87F87B10
        public void UnityEngine.UIElements.IResolvedStyle.get_flexShrink(){} // RVA: 0x7FFE87F87B60
        public void UnityEngine.UIElements.IResolvedStyle.get_height(){} // RVA: 0x7FFE87F87BB0
        public void UnityEngine.UIElements.IResolvedStyle.get_left(){} // RVA: 0x7FFE87F87C20
        public void UnityEngine.UIElements.IResolvedStyle.get_marginBottom(){} // RVA: 0x7FFE87F87C90
        public void UnityEngine.UIElements.IResolvedStyle.get_marginLeft(){} // RVA: 0x7FFE87F87D00
        public void UnityEngine.UIElements.IResolvedStyle.get_marginRight(){} // RVA: 0x7FFE87F87D70
        public void UnityEngine.UIElements.IResolvedStyle.get_marginTop(){} // RVA: 0x7FFE87F87DE0
        public void UnityEngine.UIElements.IResolvedStyle.get_minHeight(){} // RVA: 0x7FFE87F87E50
        public void UnityEngine.UIElements.IResolvedStyle.get_minWidth(){} // RVA: 0x7FFE87F87EB0
        public void UnityEngine.UIElements.IResolvedStyle.get_opacity(){} // RVA: 0x7FFE87F87F10
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingBottom(){} // RVA: 0x7FFE87F87F60
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingLeft(){} // RVA: 0x7FFE87F87FD0
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingRight(){} // RVA: 0x7FFE87F88040
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingTop(){} // RVA: 0x7FFE87F880B0
        public void UnityEngine.UIElements.IResolvedStyle.get_right(){} // RVA: 0x7FFE87F88120
        public void UnityEngine.UIElements.IResolvedStyle.get_scale(){} // RVA: 0x7FFE87F88190
        public void UnityEngine.UIElements.IResolvedStyle.get_top(){} // RVA: 0x7FFE87F881F0
        public void UnityEngine.UIElements.IResolvedStyle.get_transformOrigin(){} // RVA: 0x7FFE87F88260
        public void UnityEngine.UIElements.IResolvedStyle.get_translate(){} // RVA: 0x7FFE87F88290
        public void UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor(){} // RVA: 0x7FFE87F882C0
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft(){} // RVA: 0x7FFE87F88320
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight(){} // RVA: 0x7FFE87F88370
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale(){} // RVA: 0x7FFE87F883C0
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor(){} // RVA: 0x7FFE87F88410
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth(){} // RVA: 0x7FFE87F88470
        public void UnityEngine.UIElements.IResolvedStyle.get_visibility(){} // RVA: 0x7FFE87F884C0
        public void UnityEngine.UIElements.IResolvedStyle.get_width(){} // RVA: 0x7FFE87F88510
        public void get_hasRunningAnimations(){} // RVA: 0x7FFE87F88580
        public void get_hasCompletedAnimations(){} // RVA: 0x7FFE87F885E0
        public void UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount(){} // RVA: 0x7FFE81156CD0
        public void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(){} // RVA: 0x7FFE81156CE0
        public void UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount(){} // RVA: 0x7FFE82447220
        public void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(){} // RVA: 0x7FFE82443340
        public void GetStylePropertyAnimationSystem(){} // RVA: 0x7FFE87F88640
        public void get_styleAnimation(){} // RVA: 0x7FFE827C4A80
        public void UnityEngine.UIElements.IStylePropertyAnimations.Start(){} // RVA: 0x7FFE87F89AD0 | overloaded x15
        public void UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(){} // RVA: 0x7FFE87F88B40
        public void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(){} // RVA: 0x7FFE87F89C50
        public void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations(){} // RVA: 0x7FFE87F89CD0
        public void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(){} // RVA: 0x7FFE87F89DD0
        public void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(){} // RVA: 0x7FFE87F89E50
        public void TryConvertLengthUnits(){} // RVA: 0x7FFE87F89FD0
        public void TryConvertTransformOriginUnits(){} // RVA: 0x7FFE87F8A2D0
        public void TryConvertTranslateUnits(){} // RVA: 0x7FFE87F8A380
        public void TryConvertBackgroundSizeUnits(){} // RVA: 0x7FFE87F8A430
        public void GetParentSizeForLengthConversion(){} // RVA: 0x7FFE87F8A4F0
        public void get_isCompositeRoot(){} // RVA: 0x7FFE87F8A730
        public void set_isCompositeRoot(){} // RVA: 0x7FFE87F8A740
        public void get_isHierarchyDisplayed(){} // RVA: 0x7FFE87F8A780
        public void set_isHierarchyDisplayed(){} // RVA: 0x7FFE87F8A790
        public void get_viewDataKey(){} // RVA: 0x7FFE811C3500
        public void set_viewDataKey(){} // RVA: 0x7FFE87F8A7C0
        public void get_enableViewDataPersistence(){} // RVA: 0x7FFE87F8A890
        public void set_enableViewDataPersistence(){} // RVA: 0x7FFE87F8A8A0
        public void get_userData(){} // RVA: 0x7FFE87F8A8D0
        public void set_userData(){} // RVA: 0x7FFE87F8A950
        public void get_canGrabFocus(){} // RVA: 0x7FFE87F8A9D0
        public void get_focusController(){} // RVA: 0x7FFE87F8AAD0
        public void get_usageHints(){} // RVA: 0x7FFE87F8AB20
        public void set_usageHints(){} // RVA: 0x7FFE87F8AB40
        public void get_renderHints(){} // RVA: 0x7FFE87CF8BD0
        public void set_renderHints(){} // RVA: 0x7FFE87F8ABD0
        public void MarkRenderHintsClean(){} // RVA: 0x7FFE87F8AC40
        public void get_transform(){} // RVA: 0x7FFE86A47010
        public void UnityEngine.UIElements.ITransform.get_position(){} // RVA: 0x7FFE87F8AC50
        public void UnityEngine.UIElements.ITransform.set_position(){} // RVA: 0x7FFE87F8ACD0
        public void UnityEngine.UIElements.ITransform.get_scale(){} // RVA: 0x7FFE87F8AEE0
        public void get_isLayoutManual(){} // RVA: 0x7FFE87F8AF60
        public void set_isLayoutManual(){} // RVA: 0x7FFE87F8AF70
        public void get_scaledPixelsPerPoint(){} // RVA: 0x7FFE87F8AFA0
        public void get_layout(){} // RVA: 0x7FFE87F8B040
        public void set_layout(){} // RVA: 0x7FFE87F8B220
        public void ClearManualLayout(){} // RVA: 0x7FFE87F8B9D0
        public void get_contentRect(){} // RVA: 0x7FFE87F8BC40
        public void get_paddingRect(){} // RVA: 0x7FFE87F8BED0
        public void get_isBoundingBoxDirty(){} // RVA: 0x7FFE87F8C030
        public void set_isBoundingBoxDirty(){} // RVA: 0x7FFE87F8C040
        public void set_isWorldBoundingBoxDirty(){} // RVA: 0x7FFE87F8C070
        public void get_isWorldBoundingBoxOrDependenciesDirty(){} // RVA: 0x7FFE87F8C0A0
        public void get_boundingBox(){} // RVA: 0x7FFE87F8C0B0
        public void get_worldBoundingBox(){} // RVA: 0x7FFE87F8C100
        public void get_boundingBoxInParentSpace(){} // RVA: 0x7FFE87F8C1D0
        public void UpdateBoundingBox(){} // RVA: 0x7FFE87F8C220
        public void UpdateWorldBoundingBox(){} // RVA: 0x7FFE87F8C580
        public void get_worldBound(){} // RVA: 0x7FFE87F8C620
        public void get_localBound(){} // RVA: 0x7FFE87F8C720
        public void get_rect(){} // RVA: 0x7FFE87F8C7A0
        public void get_isWorldTransformDirty(){} // RVA: 0x7FFE87F8C800
        public void set_isWorldTransformDirty(){} // RVA: 0x7FFE87607350
        public void set_isWorldTransformInverseDirty(){} // RVA: 0x7FFE87607380
        public void get_isWorldTransformInverseOrDependenciesDirty(){} // RVA: 0x7FFE87F8C810
        public void get_worldTransform(){} // RVA: 0x7FFE87F8C820
        public void get_worldTransformRef(){} // RVA: 0x7FFE87F8C890
        public void get_worldTransformInverse(){} // RVA: 0x7FFE87F8C8C0
        public void UpdateWorldTransform(){} // RVA: 0x7FFE87F8C970
        public void UpdateWorldTransformInverse(){} // RVA: 0x7FFE87F8CC80
        public void get_isWorldClipDirty(){} // RVA: 0x7FFE87F8CD30
        public void set_isWorldClipDirty(){} // RVA: 0x7FFE87F8CD40
        public void get_worldClip(){} // RVA: 0x7FFE87F8CD70
        public void get_worldClipMinusGroup(){} // RVA: 0x7FFE87F8CDC0
        public void get_worldClipIsInfinite(){} // RVA: 0x7FFE87F8CE10
        public void EnsureWorldTransformAndClipUpToDate(){} // RVA: 0x7FFE87F8CE50
        public void UpdateWorldClip(){} // RVA: 0x7FFE87F8CE90
        public void CombineClipRects(){} // RVA: 0x7FFE87F8D2E0
        public void SubstractBorderPadding(){} // RVA: 0x7FFE87F8D370
        public void ComputeAAAlignedBound(){} // RVA: 0x7FFE87F8D630
        public void get_pseudoStates(){} // RVA: 0x7FFE87F8D890
        public void set_pseudoStates(){} // RVA: 0x7FFE87F8D8A0
        public void get_containedPointerIds(){} // RVA: 0x7FFE86EBC5A0
        public void set_containedPointerIds(){} // RVA: 0x7FFE86EBC5B0
        public void UpdateHoverPseudoState(){} // RVA: 0x7FFE87F8D930
        public void IsPartOfCapturedChain(){} // RVA: 0x7FFE87F8DA40
        public void get_pickingMode(){} // RVA: 0x7FFE86EBC5C0
        public void set_pickingMode(){} // RVA: 0x7FFE87F8DB10
        public void get_name(){} // RVA: 0x7FFE87CC7F60
        public void set_name(){} // RVA: 0x7FFE87F8DB60
        public void get_classList(){} // RVA: 0x7FFE87F8DC30
        public void get_fullTypeName(){} // RVA: 0x7FFE87F8DD30
        public void get_typeName(){} // RVA: 0x7FFE87F8DDE0
        public void get_yogaNode(){} // RVA: 0x7FFE81B2B930
        public void set_yogaNode(){} // RVA: 0x7FFE81B208C0
        public void get_computedStyle(){} // RVA: 0x7FFE87F8DE10
        public void get_hasInlineStyle(){} // RVA: 0x7FFE87F8DE20
        public void get_styleInitialized(){} // RVA: 0x7FFE87F8DE30
        public void set_styleInitialized(){} // RVA: 0x7FFE87F8DE40
        public void ChangeIMGUIContainerCount(){} // RVA: 0x7FFE87F8DE70
        public void .ctor(){} // RVA: 0x7FFE87F8DEB0
        public void ExecuteDefaultAction(){} // RVA: 0x7FFE87F8E550
        public void GetTooltipRect(){} // RVA: 0x7FFE87F8ED90
        public void SetTooltip(){} // RVA: 0x7FFE87F8EDC0
        public void Focus(){} // RVA: 0x7FFE87F8EF30
        public void SetPanel(){} // RVA: 0x7FFE87F8F0D0
        public void WillChangePanel(){} // RVA: 0x7FFE87F8FC80
        public void HasChangedPanel(){} // RVA: 0x7FFE87F8FE10
        public void SendEvent(){} // RVA: 0x7FFE87F90120 | overloaded x2
        public void IncrementVersion(){} // RVA: 0x7FFE87F90140
        public void InvokeHierarchyChanged(){} // RVA: 0x7FFE87F90170
        public void SetEnabledFromHierarchyPrivate(){} // RVA: 0x7FFE87F901B0
        public void get_isParentEnabledInHierarchy(){} // RVA: 0x7FFE87F90670
        public void get_enabledInHierarchy(){} // RVA: 0x7FFE87F906B0
        public void get_enabledSelf(){} // RVA: 0x7FFE87F906C0
        public void set_enabledSelf(){} // RVA: 0x7FFE87F906D0
        public void SetEnabled(){} // RVA: 0x7FFE87F906E0
        public void PropagateEnabledToChildren(){} // RVA: 0x7FFE87F90700
        public void get_languageDirection(){} // RVA: 0x7FFE87B11B20
        public void get_localLanguageDirection(){} // RVA: 0x7FFE87B11B60
        public void set_localLanguageDirection(){} // RVA: 0x7FFE87F907E0
        public void get_visible(){} // RVA: 0x7FFE87F90910
        public void set_visible(){} // RVA: 0x7FFE87F90970
        public void MarkDirtyRepaint(){} // RVA: 0x7FFE87F909F0
        public void get_generateVisualContent(){} // RVA: 0x7FFE81B24050
        public void set_generateVisualContent(){} // RVA: 0x7FFE81B082E0
        public void InvokeGenerateVisualContent(){} // RVA: 0x7FFE87F90A20
        public void GetFullHierarchicalViewDataKey(){} // RVA: 0x7FFE87F90C20 | overloaded x2
        public void GetOrCreateViewData(){} // RVA: 0x7FFE810A1420
        public void OverwriteFromViewData(){} // RVA: 0x7FFE87F90D10
        public void SaveViewData(){} // RVA: 0x7FFE87F90F70
        public void IsViewDataPersitenceSupportedOnChildren(){} // RVA: 0x7FFE87F91000
        public void OnViewDataReady(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void ContainsPoint(){} // RVA: 0x7FFE87F91100
        public void get_requireMeasureFunction(){} // RVA: 0x7FFE87F91160
        public void set_requireMeasureFunction(){} // RVA: 0x7FFE87F91170
        public void AssignMeasureFunction(){} // RVA: 0x7FFE87F911E0
        public void RemoveMeasureFunction(){} // RVA: 0x7FFE87F91280
        public void DoMeasure(){} // RVA: 0x7FFE87F912B0
        public void Measure(){} // RVA: 0x7FFE87F912D0
        public void FinalizeLayout(){} // RVA: 0x7FFE87F91430
        public void SetInlineRule(){} // RVA: 0x7FFE87F91510
        public void SetComputedStyle(){} // RVA: 0x7FFE87F91600
        public void ToString(){} // RVA: 0x7FFE87F91890
        public void GetClassesForIteration(){} // RVA: 0x7FFE87CC7FD0
        public void AddToClassList(){} // RVA: 0x7FFE87F91A20
        public void RemoveFromClassList(){} // RVA: 0x7FFE87F91C40
        public void EnableInClassList(){} // RVA: 0x7FFE87F91DD0
        public void ClassListContains(){} // RVA: 0x7FFE87F91E00
        public void GetProperty(){} // RVA: 0x7FFE87F91F60
        public void SetProperty(){} // RVA: 0x7FFE87F91FE0
        public void HasProperty(){} // RVA: 0x7FFE87F92060
        public void TryGetPropertyInternal(){} // RVA: 0x7FFE87F920E0
        public void CheckUserKeyArgument(){} // RVA: 0x7FFE87F92250
        public void SetPropertyInternal(){} // RVA: 0x7FFE87F923B0
        public void UpdateCursorStyle(){} // RVA: 0x7FFE87F926F0
        public void get_subRenderTargetMode(){} // RVA: 0x7FFE87F92B00
        public void get_defaultMaterial(){} // RVA: 0x7FFE87F92B10
        public void GetAnimationSystem(){} // RVA: 0x7FFE87F92B20
        public void RegisterAnimation(){} // RVA: 0x7FFE87F92BD0
        public void UnregisterAnimation(){} // RVA: 0x7FFE87F92D80
        public void UnregisterRunningAnimations(){} // RVA: 0x7FFE87F92E40
        public void RegisterRunningAnimations(){} // RVA: 0x7FFE87F92ED0
        public void StartAnimation(){} // RVA: 0x7FFE810A1420
        public void AssignStyleValues(){} // RVA: 0x7FFE87F92F40
        public void ReadCurrentValues(){} // RVA: 0x7FFE87F93C50
        public void UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(){} // RVA: 0x7FFE87F94C60
        public void Start(){} // RVA: 0x7FFE87F94DF0
        public void DirtyNextParentWithEventCallback(){} // RVA: 0x7FFE87F95020
        public void SetAsNextParentWithEventCallback(){} // RVA: 0x7FFE87F950B0
        public void GetCachedNextParentWithEventCallback(){} // RVA: 0x7FFE87F95180
        public void get_nextParentWithEventCallback(){} // RVA: 0x7FFE87F95200
        public void PropagateCachedNextParentWithEventCallback(){} // RVA: 0x7FFE87F95440
        public void get_eventCallbackCategories(){} // RVA: 0x7FFE87F954F0
        public void set_eventCallbackCategories(){} // RVA: 0x7FFE87F95500
        public void get_eventCallbackParentCategories(){} // RVA: 0x7FFE87F95580
        public void get_isEventCallbackParentCategoriesDirty(){} // RVA: 0x7FFE87F95680
        public void set_isEventCallbackParentCategoriesDirty(){} // RVA: 0x7FFE87F95690
        public void UpdateCallbackParentCategories(){} // RVA: 0x7FFE87F956C0
        public void HasEventCallbacks(){} // RVA: 0x7FFE87F95790
        public void HasParentEventCallbacksOrDefaultActions(){} // RVA: 0x7FFE87F957B0
        public void HasEventCallbacksOrDefaultActions(){} // RVA: 0x7FFE87F95800
        public void HasParentEventCallbacksOrDefaultActionAtTarget(){} // RVA: 0x7FFE87F95830
        public void HasEventCallbacksOrDefaultActionAtTarget(){} // RVA: 0x7FFE87F95870
        public void HasDefaultAction(){} // RVA: 0x7FFE87F958A0
        public void get_experimental(){} // RVA: 0x7FFE86A47010
        public void UnityEngine.UIElements.IExperimentalFeatures.get_animation(){} // RVA: 0x7FFE86A47010
        public void get_hierarchy(){} // RVA: 0x7FFE81B267A0
        public void set_hierarchy(){} // RVA: 0x7FFE81B353B0
        public void get_isRootVisualContainer(){} // RVA: 0x7FFE87F958C0
        public void set_isRootVisualContainer(){} // RVA: 0x7FFE87F958D0
        public void get_disableClipping(){} // RVA: 0x7FFE87F958E0
        public void set_disableClipping(){} // RVA: 0x7FFE87F958F0
        public void ShouldClip(){} // RVA: 0x7FFE87F95920
        public void get_parent(){} // RVA: 0x7FFE87F95980
        public void get_elementPanel(){} // RVA: 0x7FFE81B08D80
        public void set_elementPanel(){} // RVA: 0x7FFE81B31360
        public void get_panel(){} // RVA: 0x7FFE87F95990
        public void get_contentContainer(){} // RVA: 0x7FFE86A47010
        public void set_visualTreeAssetSource(){} // RVA: 0x7FFE81B332D0
        public void Add(){} // RVA: 0x7FFE87F959A0
        public void Insert(){} // RVA: 0x7FFE87F95B00
        public void Clear(){} // RVA: 0x7FFE87F95BF0
        public void ElementAt(){} // RVA: 0x7FFE87F95C70
        public void get_Item(){} // RVA: 0x7FFE87F95C80
        public void get_childCount(){} // RVA: 0x7FFE87F95D60
        public void IndexOf(){} // RVA: 0x7FFE87F95E00
        public void ElementAtTreePath(){} // RVA: 0x7FFE87F95EF0
        public void FindElementInTree(){} // RVA: 0x7FFE87F96190
        public void Children(){} // RVA: 0x7FFE87F96300
        public void BringToFront(){} // RVA: 0x7FFE87F963C0
        public void SendToBack(){} // RVA: 0x7FFE87F96410
        public void PlaceBehind(){} // RVA: 0x7FFE87F96460
        public void RemoveFromHierarchy(){} // RVA: 0x7FFE87F96580
        public void GetFirstOfType(){} // RVA: 0x7FFE810A1420
        public void GetFirstAncestorOfType(){} // RVA: 0x7FFE810A1420
        public void GetFirstAncestorWhere(){} // RVA: 0x7FFE87F966A0
        public void Contains(){} // RVA: 0x7FFE87F96720
        public void GatherAllChildren(){} // RVA: 0x7FFE87F96770
        public void FindCommonAncestor(){} // RVA: 0x7FFE87F96890
        public void GetRoot(){} // RVA: 0x7FFE87F96A20
        public void GetRootVisualContainer(){} // RVA: 0x7FFE87F96AB0
        public void GetNextElementDepthFirst(){} // RVA: 0x7FFE87F96AF0
        public void GetPreviousElementDepthFirst(){} // RVA: 0x7FFE87F96C30
        public void RetargetElement(){} // RVA: 0x7FFE87F96D80
        public void get_positionWithLayout(){} // RVA: 0x7FFE87F96E30
        public void GetPivotedMatrixWithLayout(){} // RVA: 0x7FFE87F96EC0
        public void get_hasDefaultRotationAndScale(){} // RVA: 0x7FFE87F97360
        public void Min(){} // RVA: 0x7FFE87F97490
        public void Max(){} // RVA: 0x7FFE87F974A0
        public void TransformAlignedRectToParentSpace(){} // RVA: 0x7FFE87F974B0
        public void CalculateConservativeRect(){} // RVA: 0x7FFE87F975F0
        public void TransformAlignedRect(){} // RVA: 0x7FFE87F979D0
        public void OrderMinMaxRect(){} // RVA: 0x7FFE87F97A50
        public void MultiplyMatrix44Point2(){} // RVA: 0x7FFE87F97AA0
        public void MultiplyVector2(){} // RVA: 0x7FFE87F97AF0
        public void MultiplyMatrix34(){} // RVA: 0x7FFE87F97B30
        public void TranslateMatrix34(){} // RVA: 0x7FFE87F97D60
        public void TranslateMatrix34InPlace(){} // RVA: 0x7FFE87F97E70
        public void get_schedule(){} // RVA: 0x7FFE86A47010
        public void UnityEngine.UIElements.IVisualElementScheduler.Execute(){} // RVA: 0x7FFE87F98030 | overloaded x2
        public void get_style(){} // RVA: 0x7FFE87F98160
        public void get_customStyle(){} // RVA: 0x7FFE87F98220
        public void get_styleSheets(){} // RVA: 0x7FFE81D7BAB0
        public void AddStyleSheetPath(){} // RVA: 0x7FFE87F98300
        public void ResolveLengthValue(){} // RVA: 0x7FFE87F98700
        public void ResolveTranslate(){} // RVA: 0x7FFE87F98850
        public void ResolveTransformOrigin(){} // RVA: 0x7FFE87F98A00
        public void ResolveRotation(){} // RVA: 0x7FFE87F98C00
        public void ResolveScale(){} // RVA: 0x7FFE87F98D70
        public void get_tooltip(){} // RVA: 0x7FFE87F98E70
        public void set_tooltip(){} // RVA: 0x7FFE87F98F10
        public void GetOrCreateTypeData(){} // RVA: 0x7FFE87F99090
        public void get_typeData(){} // RVA: 0x7FFE87F991F0
        public void .cctor(){} // RVA: 0x7FFE87F993B0
        public void <AssignMeasureFunction>b__432_0(){} // RVA: 0x7FFE87F912D0
    }

    public class VisualElementAnimationSystem : BaseVisualTreeUpdater
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_Animations; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_IterationList; // 0x28

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFE87E6B1A0
        public void get_stylePropertyAnimationProfilerMarker(){} // RVA: 0x7FFE87E6B200
        public void UnregisterAnimation(){} // RVA: 0x7FFE87E6B260
        public void UnregisterAnimations(){} // RVA: 0x7FFE87E6B2C0
        public void RegisterAnimation(){} // RVA: 0x7FFE87E6B450
        public void RegisterAnimations(){} // RVA: 0x7FFE87E6B4D0
        public void Update(){} // RVA: 0x7FFE87E6B670
        public void OnVersionChanged(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE87E6BB40
        public void .cctor(){} // RVA: 0x7FFE87E6BCA0
    }

    public class VisualElementAsset : UxmlAsset
    {
        public string m_Name; // 0x30
        public int m_RuleIndex; // 0x38
        public string m_Text; // 0x40
        public 0x6651F61C m_PickingMode; // 0x48
        public string[] m_Classes; // 0x50
        public System.Collections.Generic.List`1<string> m_StylesheetPaths; // 0x58
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet> m_Stylesheets; // 0x60

        // ── Methods ──
        public void get_ruleIndex(){} // RVA: 0x7FFE87C86B10
        public void get_classes(){} // RVA: 0x7FFE87CC8170
        public void get_stylesheetPaths(){} // RVA: 0x7FFE87FD4D60
        public void get_hasStylesheetPaths(){} // RVA: 0x7FFE85C01C60
        public void get_stylesheets(){} // RVA: 0x7FFE87FD4E20
        public void get_hasStylesheets(){} // RVA: 0x7FFE82A9EF30
        public void get_skipClone(){} // RVA: 0x7FFE811C3570
        public void OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void OnAfterDeserialize(){} // RVA: 0x7FFE87FD4EE0
    }

    public class VisualElementExtensions : Object
    {
        // ── Methods ──
        public void StretchToParentSize(){} // RVA: 0x7FFE87E667D0
        public void AddManipulator(){} // RVA: 0x7FFE87E66A70
        public void RemoveManipulator(){} // RVA: 0x7FFE87E66AD0
        public void WorldToLocal(){} // RVA: 0x7FFE87E66D10 | overloaded x2
        public void LocalToWorld(){} // RVA: 0x7FFE87E66C10
        public void ChangeCoordinatesTo(){} // RVA: 0x7FFE87E66E00
    }

    public class VisualElementFactoryRegistry : Object
    {
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<UnityEngine.UIElements.IUxmlFactory>> s_Factories;

        // ── Methods ──
        public void GetMovedUIControlTypeName(){} // RVA: 0x7FFE87FD5070
        public void get_factories(){} // RVA: 0x7FFE87FD5260
        public void RegisterFactory(){} // RVA: 0x7FFE87FD54C0
        public void TryGetValue(){} // RVA: 0x7FFE87FD59A0
        public void RegisterEngineFactories(){} // RVA: 0x7FFE87FD5A50
        public void RegisterUserFactories(){} // RVA: 0x7FFE87FD7AA0
    }

    public class VisualElementFocusChangeDirection : FocusChangeDirection
    {
        public UnityEngine.UIElements.VisualElementFocusChangeDirection s_Left;
        public UnityEngine.UIElements.VisualElementFocusChangeDirection s_Right; // 0x8

        // ── Methods ──
        public void get_left(){} // RVA: 0x7FFE87E67A10
        public void get_right(){} // RVA: 0x7FFE87E67A70
        public void .ctor(){} // RVA: 0x7FFE87E67AD0
        public void .cctor(){} // RVA: 0x7FFE87E67B30
    }

    public class VisualElementFocusChangeTarget : FocusChangeDirection
    {
        public UnityEngine.UIElements.ObjectPool`1<UnityEngine.UIElements.VisualElementFocusChangeTarget> Pool;

        // ── Methods ──
        public void GetPooled(){} // RVA: 0x7FFE87E67DC0
        public void Dispose(){} // RVA: 0x7FFE87E67EE0
        public void ApplyTo(){} // RVA: 0x7FFE87E67FC0
        public void .ctor(){} // RVA: 0x7FFE87E68010
        public void get_target(){} // RVA: 0x7FFE810FE7C0
        public void set_target(){} // RVA: 0x7FFE81161E80
        public void .cctor(){} // RVA: 0x7FFE87E680C0
    }

    public class VisualElementFocusRing : Object
    {
        public UnityEngine.UIElements.VisualElement root; // 0x10
        public 0x6651FC4C _defaultFocusOrder; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E683A0
        public void get_focusController(){} // RVA: 0x7FFE815888B0
        public void get_defaultFocusOrder(){} // RVA: 0x7FFE813DB630
        public void set_defaultFocusOrder(){} // RVA: 0x7FFE8144DF00
        public void FocusRingAutoIndexSort(){} // RVA: 0x7FFE87E684D0
        public void FocusRingSort(){} // RVA: 0x7FFE87E688A0
        public void DoUpdate(){} // RVA: 0x7FFE87E689D0
        public void BuildRingForScopeRecursive(){} // RVA: 0x7FFE87E68AC0
        public void SortAndFlattenScopeLists(){} // RVA: 0x7FFE87E68DD0
        public void GetFocusableInternalIndex(){} // RVA: 0x7FFE87E690A0
        public void GetFocusChangeDirection(){} // RVA: 0x7FFE87E69160
        public void GetNextFocusable(){} // RVA: 0x7FFE87E696B0
        public void GetNextFocusableInTree(){} // RVA: 0x7FFE87E69D90
        public void GetPreviousFocusableInTree(){} // RVA: 0x7FFE87E69E30
    }

    public class VisualElementListPool : Object
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFE87E66300
        public void Get(){} // RVA: 0x7FFE87E663D0
        public void Release(){} // RVA: 0x7FFE87E664B0
        public void .cctor(){} // RVA: 0x7FFE87E66570
    }

    public class VisualElementPanelActivator : Object
    {
        public UnityEngine.UIElements.IVisualElementPanelActivatable m_Activatable; // 0x10
        public bool _isActive; // 0x18

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x7FFE811164E0
        public void set_isActive(){} // RVA: 0x7FFE811164F0
        public void get_isDetaching(){} // RVA: 0x7FFE814B3730
        public void set_isDetaching(){} // RVA: 0x7FFE81CD0510
        public void .ctor(){} // RVA: 0x7FFE87E69F20
        public void SetActive(){} // RVA: 0x7FFE87E6A0D0
        public void SendActivation(){} // RVA: 0x7FFE87E6A240
        public void SendDeactivation(){} // RVA: 0x7FFE87E6A2C0
        public void OnEnter(){} // RVA: 0x7FFE87E6A340
        public void OnLeave(){} // RVA: 0x7FFE87E6A350
    }

    public class VisualElementStyleSheetSet : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void Add(){} // RVA: 0x7FFE87E6A3B0
        public void Remove(){} // RVA: 0x7FFE87E6A670
        public void Equals(){} // RVA: 0x7FFE87E6A8A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87E6A980
    }

    public class VisualElementUtils : Object
    {
        // ── Methods ──
        public void GetUniqueName(){} // RVA: 0x7FFE87E6A9B0
        public void GetFoldoutDepth(){} // RVA: 0x7FFE87E6AB70
        public void AssignInspectorStyleIfNecessary(){} // RVA: 0x7FFE87E6AC50
        public void .cctor(){} // RVA: 0x7FFE87E6AE20
    }

    public class VisualTreeAsset : ScriptableObject
    {
        public string LinkedVEAInTemplatePropertyName;
        public bool m_ImportedWithErrors; // 0x18
        public bool m_ImportedWithWarnings; // 0x19
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.UIElements.VisualElement> s_TemporarySlotInsertionPoints; // 0x8
        public System.Collections.Generic.List`1<UsingEntry> m_Usings; // 0x20
        public UnityEngine.UIElements.StyleSheet inlineSheet; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementAsset> m_VisualElementAssets; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.UIElements.TemplateAsset> m_TemplateAssets; // 0x38
        public System.Collections.Generic.List`1<UxmlObjectEntry> m_UxmlObjectEntries; // 0x40
        public System.Collections.Generic.List`1<int> m_UxmlObjectIds; // 0x48
        public System.Collections.Generic.List`1<AssetEntry> m_AssetEntries; // 0x50

        // ── Methods ──
        public void get_importedWithErrors(){} // RVA: 0x7FFE87BD12F0
        public void set_importedWithErrors(){} // RVA: 0x7FFE811164F0
        public void get_importedWithWarnings(){} // RVA: 0x7FFE87FB3310
        public void set_importedWithWarnings(){} // RVA: 0x7FFE81CD0510
        public void GetNextChildSerialNumber(){} // RVA: 0x7FFE87FD7EA0
        public void get_templateDependencies(){} // RVA: 0x7FFE87FD7F30
        public void get_stylesheets(){} // RVA: 0x7FFE87FD7FE0
        public void get_visualElementAssets(){} // RVA: 0x7FFE87C86B00
        public void set_visualElementAssets(){} // RVA: 0x7FFE81129890
        public void get_templateAssets(){} // RVA: 0x7FFE87CC7F60
        public void set_templateAssets(){} // RVA: 0x7FFE81437330
        public void get_uxmlObjectEntries(){} // RVA: 0x7FFE81178740
        public void get_uxmlObjectIds(){} // RVA: 0x7FFE81176730
        public void RegisterUxmlObject(){} // RVA: 0x7FFE87FD8090
        public void GetUxmlObjects(){}
        public void AssetEntryExists(){} // RVA: 0x7FFE87FD83D0
        public void RegisterAssetEntry(){} // RVA: 0x7FFE87FD85F0
        public void GetAsset(){} // RVA: 0x7FFE810A1420
        public void GetUxmlObjectEntry(){} // RVA: 0x7FFE87FD8740
        public void GetUxmlObjectFactory(){} // RVA: 0x7FFE87FD88B0
        public void get_slots(){} // RVA: 0x7FFE87CC81E0
        public void set_slots(){} // RVA: 0x7FFE811C3510
        public void get_contentContainerId(){} // RVA: 0x7FFE87CF8BD0
        public void set_contentContainerId(){} // RVA: 0x7FFE8139E520
        public void Instantiate(){} // RVA: 0x7FFE87FD8E60 | overloaded x2
        public void CloneTree(){} // RVA: 0x7FFE87FD9130 | overloaded x5
        public void CloneSetupRecursively(){} // RVA: 0x7FFE87FD9970
        public void CompareForOrder(){} // RVA: 0x7FFE87FDA6D0
        public void TryGetSlotInsertionPoint(){} // RVA: 0x7FFE87FDA710
        public void ResolveTemplate(){} // RVA: 0x7FFE87FDA8B0
        public void Create(){} // RVA: 0x7FFE87FDAC80
        public void AssignClassListFromAssetToElement(){} // RVA: 0x7FFE87FDB460
        public void AssignStyleSheetFromAssetToElement(){} // RVA: 0x7FFE87FDB4D0
        public void get_contentHash(){} // RVA: 0x7FFE87CF8BE0
        public void set_contentHash(){} // RVA: 0x7FFE829DF320
        public void .ctor(){} // RVA: 0x7FFE81345B60
        public void .cctor(){} // RVA: 0x7FFE87FDB750
        public void <Create>g__CreateError|65_0(){} // RVA: 0x7FFE87FDB8D0
    }

    public class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
    {
        public UnityEngine.PropertyName s_BindingRequestObjectVEPropertyName;
        public UnityEngine.PropertyName s_AdditionalBindingObjectVEPropertyName; // 0x4

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFE87E268C0
        public void GetBindingObjectFromElement(){} // RVA: 0x7FFE87E26920
        public void StartTracking(){} // RVA: 0x7FFE87E26A50
        public void StopTracking(){} // RVA: 0x7FFE87E26AF0
        public void get_temporaryObjectCache(){} // RVA: 0x7FFE81199370
        public void GetAdditionalBinding(){} // RVA: 0x7FFE87E26B90
        public void StartTrackingRecursive(){} // RVA: 0x7FFE87E26C20
        public void StopTrackingRecursive(){} // RVA: 0x7FFE87E26DF0
        public void OnVersionChanged(){} // RVA: 0x7FFE87E26FA0
        public void OnHierarchyChange(){} // RVA: 0x7FFE87E270B0
        public void CurrentTime(){} // RVA: 0x7FFE87E270E0
        public void PerformTrackingOperations(){} // RVA: 0x7FFE87E27130
        public void Update(){} // RVA: 0x7FFE87E27460
        public void UpdateBindings(){} // RVA: 0x7FFE87E27B10
        public void .ctor(){} // RVA: 0x7FFE87E280A0
        public void .cctor(){} // RVA: 0x7FFE87E28400
    }

    public class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater
    {
        public uint m_Version; // 0x20

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFE87E6BED0
        public void OnVersionChanged(){} // RVA: 0x7FFE87E6BF30
        public void DirtyHierarchy(){} // RVA: 0x7FFE87E6C070
        public void DirtyBoundingBoxHierarchy(){} // RVA: 0x7FFE87E6C1D0
        public void Update(){} // RVA: 0x7FFE87E6C230
        public void .ctor(){} // RVA: 0x7FFE86224C30
        public void .cctor(){} // RVA: 0x7FFE87E6C2A0
    }

    public class VisualTreeStyleUpdater : BaseVisualTreeUpdater
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_ApplyStyleUpdateList; // 0x20
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_TransitionPropertyUpdateList; // 0x28

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFE87E6D280
        public void OnVersionChanged(){} // RVA: 0x7FFE87E6D2E0
        public void Update(){} // RVA: 0x7FFE87E6D3C0
        public void get_disposed(){} // RVA: 0x7FFE811B2D30
        public void set_disposed(){} // RVA: 0x7FFE811B2D40
        public void Dispose(){} // RVA: 0x7FFE87E6D8A0
        public void ApplyStyles(){} // RVA: 0x7FFE87E6D8E0
        public void .ctor(){} // RVA: 0x7FFE87E6D9E0
        public void .cctor(){} // RVA: 0x7FFE87E6DBA0
    }

    public class VisualTreeStyleUpdaterTraversal : HierarchyTraversal
    {
        public UnityEngine.UIElements.StyleVariableContext m_ProcessVarContext; // 0x10

        // ── Methods ──
        public void get_currentPixelsPerPoint(){} // RVA: 0x7FFE81284640
        public void set_currentPixelsPerPoint(){} // RVA: 0x7FFE81308960
        public void PrepareTraversal(){} // RVA: 0x7FFE81308960
        public void AddChangedElement(){} // RVA: 0x7FFE87E6E220
        public void Clear(){} // RVA: 0x7FFE87E6E350
        public void PropagateToChildren(){} // RVA: 0x7FFE87E6E3F0
        public void PropagateToParents(){} // RVA: 0x7FFE87E6E570
        public void OnProcessMatchResult(){} // RVA: 0x7FFE87E6E620
        public void TraverseRecursive(){} // RVA: 0x7FFE87E6E660
        public void ProcessTransitions(){} // RVA: 0x7FFE87E6F0A0
        public void ForceUpdateTransitions(){} // RVA: 0x7FFE87E6F1C0
        public void CancelAnimationsWithNoTransitionProperty(){} // RVA: 0x7FFE87E6F490
        public void ShouldSkipElement(){} // RVA: 0x7FFE87E6F7E0
        public void ProcessMatchedRules(){} // RVA: 0x7FFE87E6F870
        public void ProcessMatchedVariables(){} // RVA: 0x7FFE87E70BE0
        public void .ctor(){} // RVA: 0x7FFE87E70CC0
    }

    public class VisualTreeUpdater : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E712A0
        public void Dispose(){} // RVA: 0x7FFE87E71530
        public void UpdateVisualTreePhase(){} // RVA: 0x7FFE87E71650
        public void OnVersionChanged(){} // RVA: 0x7FFE87E717F0
        public void SetUpdater(){} // RVA: 0x7FFE80E46530
        public void GetUpdater(){} // RVA: 0x7FFE87E71930
        public void SetDefaultUpdaters(){} // RVA: 0x7FFE87E71970
    }

    public class VisualTreeViewDataUpdater : BaseVisualTreeUpdater
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_UpdateList; // 0x20

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFE87E71EC0
        public void OnVersionChanged(){} // RVA: 0x7FFE87E71F20
        public void Update(){} // RVA: 0x7FFE87E72040
        public void ValidateViewDataOnSubTree(){} // RVA: 0x7FFE87E721A0
        public void PropagateToParents(){} // RVA: 0x7FFE87E72400
        public void .ctor(){} // RVA: 0x7FFE87E724B0
        public void .cctor(){} // RVA: 0x7FFE87E725F0
    }

}