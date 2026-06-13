// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 32
// Methods: 608

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class ValidateCommandEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73E6100
        public void .ctor(){} // RVA: 0x73E61F0
    }

    public class Vector2Field
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x730DDB0
        public void .ctor(){} // RVA: 0x730E520 | overloaded x2
        public void .cctor(){} // RVA: 0x730E660
    }

    public class Vector2IntField
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7311B40
        public void .ctor(){} // RVA: 0x73122B0 | overloaded x2
        public void .cctor(){} // RVA: 0x73123F0
    }

    public class Vector3Field
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x730ED10
        public void .ctor(){} // RVA: 0x730F620 | overloaded x2
        public void .cctor(){} // RVA: 0x730F760
    }

    public class Vector3IntField
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7312CF0
        public void .ctor(){} // RVA: 0x7313600 | overloaded x2
        public void .cctor(){} // RVA: 0x7313740
    }

    public class Vector4Field
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x73101A0
        public void .ctor(){} // RVA: 0x7310E80 | overloaded x2
        public void .cctor(){} // RVA: 0x7310FC0
    }

    public class VectorImage
    {
        public int version; // 0x18
        public UnityEngine.Texture2D atlas; // 0x20

        // ── Methods ──
        public void get_width(){} // RVA: 0x7D0490
        public void get_height(){} // RVA: 0x2E5970
        public void .ctor(){} // RVA: 0x7325FD0
    }

    public class VectorImageVertex
    {
    }

    public class Vertex
    {
    }

    public class VerticalVirtualizationController`1
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
        public void get_activeItems(){} // RVA: 0xCD60
        public void get_itemsCount(){} // RVA: 0xD840
        public void VisibleItemPredicate(){} // RVA: 0x283FA0
        public void get_firstVisibleItem(){} // RVA: 0x283FA0
        public void get_lastVisibleItem(){} // RVA: 0x283FA0
        public void get_visibleItemCount(){} // RVA: 0xD840
        public void get_serializedData(){} // RVA: 0xCD60
        public void get_firstVisibleIndex(){} // RVA: 0xD840
        public void set_firstVisibleIndex(){} // RVA: 0x24FA0
        public void get_lastHeight(){} // RVA: 0x21890
        public void get_alwaysRebindOnRefresh(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x24B10
        public void Refresh(){} // RVA: 0x25130
        public void Setup(){} // RVA: 0x283FA0
        public void OnFocus(){} // RVA: 0x24B10
        public void OnBlur(){} // RVA: 0x24B10
        public void HandleFocus(){} // RVA: 0x2BAA0
        public void UpdateBackground(){} // RVA: 0x24A50
        public void StartDragItem(){} // RVA: 0x24B10
        public void EndDrag(){} // RVA: 0x24FA0
        public void GetOrMakeItemAtIndex(){} // RVA: 0x283FA0
        public void ReleaseItem(){} // RVA: 0x24FA0
        public void OnDestroyItem(){} // RVA: 0x24B10
        public void GetDraggedIndex(){} // RVA: 0xD840
    }

    public class VerticalVirtualizationController`1
    {
        public UnityEngine.Pool.ObjectPool`1<T> m_Pool; // 0x18
        public UnityEngine.UIElements.BaseVerticalCollectionView m_CollectionView; // 0x20
        public System.Collections.Generic.List`1<T> m_ActiveItems; // 0x28
        public T m_DraggedItem; // 0x30
        public int m_LastFocusedElementIndex; // 0x38
        public System.Collections.Generic.List`1<int> m_LastFocusedElementTreeChildIndexes; // 0x40
        public System.Func`2<T,bool> m_VisibleItemPredicateDelegate; // 0x48
        public System.Collections.Generic.List`1<T> m_ScrollInsertionList; // 0x50
        public UnityEngine.UIElements.VisualElement m_EmptyRows; // 0x58

        // ── Methods ──
        public void get_activeItems(){} // RVA: 0x30B130
        public void get_itemsCount(){} // RVA: 0x4B4F060
        public void VisibleItemPredicate(){} // RVA: 0x4B4F0E0
        public void get_firstVisibleItem(){} // RVA: 0x4B4F1D0
        public void get_lastVisibleItem(){} // RVA: 0x4B4F1F0
        public void get_visibleItemCount(){} // RVA: 0x4B4F210
        public void get_serializedData(){} // RVA: 0x4B4F230
        public void get_firstVisibleIndex(){} // RVA: 0x4B4F250
        public void set_firstVisibleIndex(){} // RVA: 0x4B4F2D0
        public void get_lastHeight(){} // RVA: 0x4B4F300
        public void get_alwaysRebindOnRefresh(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x4B4F320
        public void Refresh(){} // RVA: 0x4B4FC90
        public void Setup(){} // RVA: 0x4B50150
        public void OnFocus(){} // RVA: 0x4B506D0
        public void OnBlur(){} // RVA: 0x4B50B90
        public void HandleFocus(){} // RVA: 0x4B50C20
        public void UpdateBackground(){} // RVA: 0x4B50D20
        public void StartDragItem(){} // RVA: 0x4B51400
        public void EndDrag(){} // RVA: 0x4B51630
        public void GetOrMakeItemAtIndex(){} // RVA: 0x4B519C0
        public void ReleaseItem(){} // RVA: 0x4B51CD0
        public void OnDestroyItem(){} // RVA: 0x4B51DC0
        public void GetDraggedIndex(){} // RVA: 0x4B51F60
    }

    public class VerticalVirtualizationController`1
    {
        public UnityEngine.Pool.ObjectPool`1<T> m_Pool; // 0x18
        public UnityEngine.UIElements.BaseVerticalCollectionView m_CollectionView; // 0x20
        public System.Collections.Generic.List`1<T> m_ActiveItems; // 0x28
        public T m_DraggedItem; // 0x30
        public int m_LastFocusedElementIndex; // 0x38
        public System.Collections.Generic.List`1<int> m_LastFocusedElementTreeChildIndexes; // 0x40
        public System.Func`2<T,bool> m_VisibleItemPredicateDelegate; // 0x48
        public System.Collections.Generic.List`1<T> m_ScrollInsertionList; // 0x50
        public UnityEngine.UIElements.VisualElement m_EmptyRows; // 0x58

        // ── Methods ──
        public void get_activeItems(){} // RVA: 0x30B130
        public void get_itemsCount(){} // RVA: 0x4B4F060
        public void VisibleItemPredicate(){} // RVA: 0x4B4F0E0
        public void get_firstVisibleItem(){} // RVA: 0x4B4F1D0
        public void get_lastVisibleItem(){} // RVA: 0x4B4F1F0
        public void get_visibleItemCount(){} // RVA: 0x4B4F210
        public void get_serializedData(){} // RVA: 0x4B4F230
        public void get_firstVisibleIndex(){} // RVA: 0x4B4F250
        public void set_firstVisibleIndex(){} // RVA: 0x4B4F2D0
        public void get_lastHeight(){} // RVA: 0x4B4F300
        public void get_alwaysRebindOnRefresh(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x4B4F320
        public void Refresh(){} // RVA: 0x4B4FC90
        public void Setup(){} // RVA: 0x4B50150
        public void OnFocus(){} // RVA: 0x4B506D0
        public void OnBlur(){} // RVA: 0x4B50B90
        public void HandleFocus(){} // RVA: 0x4B50C20
        public void UpdateBackground(){} // RVA: 0x4B50D20
        public void StartDragItem(){} // RVA: 0x4B51400
        public void EndDrag(){} // RVA: 0x4B51630
        public void GetOrMakeItemAtIndex(){} // RVA: 0x4B519C0
        public void ReleaseItem(){} // RVA: 0x4B51CD0
        public void OnDestroyItem(){} // RVA: 0x4B51DC0
        public void GetDraggedIndex(){} // RVA: 0x4B51F60
    }

    public class VisualData
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x745EA10
        public void CopyFrom(){} // RVA: 0x7462FA0
        public void op_Equality(){} // RVA: 0x74630F0
        public void Equals(){} // RVA: 0x74646C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x74647F0
    }

    public class VisualElement : UnityEngine.UIElements
    {
        public int <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField; // 0x30
        public int <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField; // 0x34
        public uint s_NextId;
        public System.Collections.Generic.List`1<string> s_EmptyClassList; // 0x8
        public UnityEngine.PropertyName userDataPropertyKey; // 0x10
        public string disabledUssClassName; // 0x18
        public string m_Name; // 0x38
        public System.Collections.Generic.List`1<string> m_ClassList; // 0x40
        public System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<UnityEngine.PropertyName,object>> m_PropertyBag; // 0x48
        public 0x65841620 m_Flags; // 0x50
        public string m_ViewDataKey; // 0x58
        public 0x6583AF58 m_RenderHints; // 0x60
        public UnityEngine.Rect lastLayout; // 0x64
        public UnityEngine.Rect lastPseudoPadding; // 0x74
        public UnityEngine.UIElements.UIR.RenderChainVEData renderChainData; // 0x88
        public UnityEngine.Rect m_Layout; // 0x1D0
        public UnityEngine.Rect m_BoundingBox; // 0x1E0
        public 0x65841620 worldBoundingBoxDirtyDependencies;
        public UnityEngine.Rect m_WorldBoundingBox; // 0x1F0
        public 0x65841620 worldTransformInverseDirtyDependencies;
        public UnityEngine.Matrix4x4 m_WorldTransformCache; // 0x200
        public UnityEngine.Matrix4x4 m_WorldTransformInverseCache; // 0x240
        public UnityEngine.Rect m_WorldClip; // 0x280
        public UnityEngine.Rect m_WorldClipMinusGroup; // 0x290
        public bool m_WorldClipIsInfinite; // 0x2A0
        public UnityEngine.Rect s_InfiniteRect; // 0x20
        public 0x658415C8 triggerPseudoMask; // 0x2A4
        public 0x658415C8 dependencyPseudoMask; // 0x2A8
        public 0x658415C8 m_PseudoStates; // 0x2AC
        public int <containedPointerIds>k__BackingField; // 0x2B0
        public 0x65841678 m_PickingMode; // 0x2B4
        public UnityEngine.Yoga.YogaNode <yogaNode>k__BackingField; // 0x2B8
        public UnityEngine.UIElements.ComputedStyle m_Style; // 0x2C0
        public UnityEngine.UIElements.StyleVariableContext variableContext; // 0x318
        public int inheritedStylesHash; // 0x320
        public uint controlid; // 0x324
        public int imguiContainerDescendantCount; // 0x328
        public bool <enabledSelf>k__BackingField; // 0x32C
        public 0x658416D0 m_LanguageDirection; // 0x330
        public 0x658416D0 m_LocalLanguageDirection; // 0x334
        public System.Action`1<UnityEngine.UIElements.MeshGenerationContext> <generateVisualContent>k__BackingField; // 0x338
        public Unity.Profiling.ProfilerMarker k_GenerateVisualContentMarker; // 0x30
        public 0x6583C608 m_SubRenderTargetMode; // 0x340
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
        public Hierarchy <hierarchy>k__BackingField; // 0x378
        public bool <isRootVisualContainer>k__BackingField; // 0x380
        public bool <cacheAsBitmap>k__BackingField; // 0x381
        public UnityEngine.UIElements.VisualElement m_PhysicalParent; // 0x388
        public UnityEngine.UIElements.VisualElement m_LogicalParent; // 0x390
        public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement> s_EmptyList; // 0x48
        public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement> m_Children; // 0x398
        public UnityEngine.UIElements.BaseVisualElementPanel <elementPanel>k__BackingField; // 0x3A0
        public UnityEngine.UIElements.VisualTreeAsset m_VisualTreeAssetSource; // 0x3A8
        public CustomStyleAccess s_CustomStyleAccess; // 0x50
        public UnityEngine.UIElements.InlineStyleAccess inlineStyleAccess; // 0x3B0
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet> styleSheetList; // 0x3B8
        public System.Text.RegularExpressions.Regex s_InternalStyleSheetPath; // 0x58
        public UnityEngine.PropertyName tooltipPropertyKey; // 0x60
        public System.Collections.Generic.Dictionary`2<System.Type,TypeData> s_TypeData; // 0x68
        public TypeData m_TypeData; // 0x3C0

        // ── Methods ──
        public void get_resolvedStyle(){} // RVA: 0x1A3F520
        public void UnityEngine.UIElements.IResolvedStyle.get_backgroundColor(){} // RVA: 0x74472E0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor(){} // RVA: 0x7447340
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius(){} // RVA: 0x74473A0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius(){} // RVA: 0x7447400
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth(){} // RVA: 0x7447460
        public void UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor(){} // RVA: 0x74474D0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth(){} // RVA: 0x7447530
        public void UnityEngine.UIElements.IResolvedStyle.get_borderRightColor(){} // RVA: 0x74475A0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth(){} // RVA: 0x7447600
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopColor(){} // RVA: 0x7447670
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius(){} // RVA: 0x74476D0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius(){} // RVA: 0x7447730
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth(){} // RVA: 0x7447790
        public void UnityEngine.UIElements.IResolvedStyle.get_bottom(){} // RVA: 0x7447800
        public void UnityEngine.UIElements.IResolvedStyle.get_color(){} // RVA: 0x7447870
        public void UnityEngine.UIElements.IResolvedStyle.get_display(){} // RVA: 0x74478D0
        public void UnityEngine.UIElements.IResolvedStyle.get_flexDirection(){} // RVA: 0x7447920
        public void UnityEngine.UIElements.IResolvedStyle.get_flexGrow(){} // RVA: 0x7447970
        public void UnityEngine.UIElements.IResolvedStyle.get_flexShrink(){} // RVA: 0x74479C0
        public void UnityEngine.UIElements.IResolvedStyle.get_height(){} // RVA: 0x7447A10
        public void UnityEngine.UIElements.IResolvedStyle.get_left(){} // RVA: 0x7447A80
        public void UnityEngine.UIElements.IResolvedStyle.get_marginBottom(){} // RVA: 0x7447AF0
        public void UnityEngine.UIElements.IResolvedStyle.get_marginLeft(){} // RVA: 0x7447B60
        public void UnityEngine.UIElements.IResolvedStyle.get_marginRight(){} // RVA: 0x7447BD0
        public void UnityEngine.UIElements.IResolvedStyle.get_marginTop(){} // RVA: 0x7447C40
        public void UnityEngine.UIElements.IResolvedStyle.get_minHeight(){} // RVA: 0x7447CB0
        public void UnityEngine.UIElements.IResolvedStyle.get_minWidth(){} // RVA: 0x7447D10
        public void UnityEngine.UIElements.IResolvedStyle.get_opacity(){} // RVA: 0x7447D70
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingBottom(){} // RVA: 0x7447DC0
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingLeft(){} // RVA: 0x7447E30
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingRight(){} // RVA: 0x7447EA0
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingTop(){} // RVA: 0x7447F10
        public void UnityEngine.UIElements.IResolvedStyle.get_right(){} // RVA: 0x7447F80
        public void UnityEngine.UIElements.IResolvedStyle.get_scale(){} // RVA: 0x7447FF0
        public void UnityEngine.UIElements.IResolvedStyle.get_top(){} // RVA: 0x7448050
        public void UnityEngine.UIElements.IResolvedStyle.get_transformOrigin(){} // RVA: 0x74480C0
        public void UnityEngine.UIElements.IResolvedStyle.get_translate(){} // RVA: 0x74480F0
        public void UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor(){} // RVA: 0x7448120
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft(){} // RVA: 0x7448180
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight(){} // RVA: 0x74481D0
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale(){} // RVA: 0x7448220
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor(){} // RVA: 0x7448270
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth(){} // RVA: 0x74482D0
        public void UnityEngine.UIElements.IResolvedStyle.get_visibility(){} // RVA: 0x7448320
        public void UnityEngine.UIElements.IResolvedStyle.get_width(){} // RVA: 0x7448370
        public void get_hasRunningAnimations(){} // RVA: 0x74483E0
        public void get_hasCompletedAnimations(){} // RVA: 0x7448440
        public void UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount(){} // RVA: 0x338CD0
        public void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(){} // RVA: 0x338CE0
        public void UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount(){} // RVA: 0x4C6670
        public void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(){} // RVA: 0x4C5F20
        public void GetStylePropertyAnimationSystem(){} // RVA: 0x74484A0
        public void get_styleAnimation(){} // RVA: 0x1A3F520
        public void UnityEngine.UIElements.IStylePropertyAnimations.Start(){} // RVA: 0x7449930 | overloaded x15
        public void UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(){} // RVA: 0x74489A0
        public void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(){} // RVA: 0x7449AB0
        public void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations(){} // RVA: 0x7449B30
        public void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(){} // RVA: 0x7449C30
        public void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(){} // RVA: 0x7449CB0
        public void TryConvertLengthUnits(){} // RVA: 0x7449E30
        public void TryConvertTransformOriginUnits(){} // RVA: 0x744A130
        public void TryConvertTranslateUnits(){} // RVA: 0x744A1E0
        public void TryConvertBackgroundSizeUnits(){} // RVA: 0x744A290
        public void GetParentSizeForLengthConversion(){} // RVA: 0x744A350
        public void get_isCompositeRoot(){} // RVA: 0x744A590
        public void set_isCompositeRoot(){} // RVA: 0x744A5A0
        public void get_isHierarchyDisplayed(){} // RVA: 0x744A5E0
        public void set_isHierarchyDisplayed(){} // RVA: 0x744A5F0
        public void get_viewDataKey(){} // RVA: 0x3A5500
        public void set_viewDataKey(){} // RVA: 0x744A620
        public void get_enableViewDataPersistence(){} // RVA: 0x744A6F0
        public void set_enableViewDataPersistence(){} // RVA: 0x744A700
        public void get_userData(){} // RVA: 0x744A730
        public void set_userData(){} // RVA: 0x744A7B0
        public void get_canGrabFocus(){} // RVA: 0x744A830
        public void get_focusController(){} // RVA: 0x744A930
        public void get_usageHints(){} // RVA: 0x744A980
        public void set_usageHints(){} // RVA: 0x744A9A0
        public void get_renderHints(){} // RVA: 0x71B8A30
        public void set_renderHints(){} // RVA: 0x744AA30
        public void MarkRenderHintsClean(){} // RVA: 0x744AAA0
        public void get_transform(){} // RVA: 0x5F061A0
        public void UnityEngine.UIElements.ITransform.get_position(){} // RVA: 0x744AAB0
        public void UnityEngine.UIElements.ITransform.set_position(){} // RVA: 0x744AB30
        public void UnityEngine.UIElements.ITransform.get_scale(){} // RVA: 0x744AD40
        public void get_isLayoutManual(){} // RVA: 0x744ADC0
        public void set_isLayoutManual(){} // RVA: 0x744ADD0
        public void get_scaledPixelsPerPoint(){} // RVA: 0x744AE00
        public void get_layout(){} // RVA: 0x744AEA0
        public void set_layout(){} // RVA: 0x744B080
        public void ClearManualLayout(){} // RVA: 0x744B830
        public void get_contentRect(){} // RVA: 0x744BAA0
        public void get_paddingRect(){} // RVA: 0x744BD30
        public void get_isBoundingBoxDirty(){} // RVA: 0x744BE90
        public void set_isBoundingBoxDirty(){} // RVA: 0x744BEA0
        public void set_isWorldBoundingBoxDirty(){} // RVA: 0x744BED0
        public void get_isWorldBoundingBoxOrDependenciesDirty(){} // RVA: 0x744BF00
        public void get_boundingBox(){} // RVA: 0x744BF10
        public void get_worldBoundingBox(){} // RVA: 0x744BF60
        public void get_boundingBoxInParentSpace(){} // RVA: 0x744C030
        public void UpdateBoundingBox(){} // RVA: 0x744C080
        public void UpdateWorldBoundingBox(){} // RVA: 0x744C3E0
        public void get_worldBound(){} // RVA: 0x744C480
        public void get_localBound(){} // RVA: 0x744C580
        public void get_rect(){} // RVA: 0x744C600
        public void get_isWorldTransformDirty(){} // RVA: 0x744C660
        public void set_isWorldTransformDirty(){} // RVA: 0x6AC8060
        public void set_isWorldTransformInverseDirty(){} // RVA: 0x6AC8090
        public void get_isWorldTransformInverseOrDependenciesDirty(){} // RVA: 0x744C670
        public void get_worldTransform(){} // RVA: 0x744C680
        public void get_worldTransformRef(){} // RVA: 0x744C6F0
        public void get_worldTransformInverse(){} // RVA: 0x744C720
        public void UpdateWorldTransform(){} // RVA: 0x744C7D0
        public void UpdateWorldTransformInverse(){} // RVA: 0x744CAE0
        public void get_isWorldClipDirty(){} // RVA: 0x744CB90
        public void set_isWorldClipDirty(){} // RVA: 0x744CBA0
        public void get_worldClip(){} // RVA: 0x744CBD0
        public void get_worldClipMinusGroup(){} // RVA: 0x744CC20
        public void get_worldClipIsInfinite(){} // RVA: 0x744CC70
        public void EnsureWorldTransformAndClipUpToDate(){} // RVA: 0x744CCB0
        public void UpdateWorldClip(){} // RVA: 0x744CCF0
        public void CombineClipRects(){} // RVA: 0x744D140
        public void SubstractBorderPadding(){} // RVA: 0x744D1D0
        public void ComputeAAAlignedBound(){} // RVA: 0x744D490
        public void get_pseudoStates(){} // RVA: 0x744D6F0
        public void set_pseudoStates(){} // RVA: 0x744D700
        public void get_containedPointerIds(){} // RVA: 0x637BB80
        public void set_containedPointerIds(){} // RVA: 0x637BB90
        public void UpdateHoverPseudoState(){} // RVA: 0x744D790
        public void IsPartOfCapturedChain(){} // RVA: 0x744D8A0
        public void get_pickingMode(){} // RVA: 0x637BBA0
        public void set_pickingMode(){} // RVA: 0x744D970
        public void get_name(){} // RVA: 0x7187DC0
        public void set_name(){} // RVA: 0x744D9C0
        public void get_classList(){} // RVA: 0x744DA90
        public void get_fullTypeName(){} // RVA: 0x744DB90
        public void get_typeName(){} // RVA: 0x744DC40
        public void get_yogaNode(){} // RVA: 0xDA70C0
        public void set_yogaNode(){} // RVA: 0xD90E40
        public void get_computedStyle(){} // RVA: 0x744DC70
        public void get_hasInlineStyle(){} // RVA: 0x744DC80
        public void get_styleInitialized(){} // RVA: 0x744DC90
        public void set_styleInitialized(){} // RVA: 0x744DCA0
        public void ChangeIMGUIContainerCount(){} // RVA: 0x744DCD0
        public void .ctor(){} // RVA: 0x744DD10
        public void ExecuteDefaultAction(){} // RVA: 0x744E3B0
        public void GetTooltipRect(){} // RVA: 0x744EBF0
        public void SetTooltip(){} // RVA: 0x744EC20
        public void Focus(){} // RVA: 0x744ED90
        public void SetPanel(){} // RVA: 0x744EF30
        public void WillChangePanel(){} // RVA: 0x744FAE0
        public void HasChangedPanel(){} // RVA: 0x744FC70
        public void SendEvent(){} // RVA: 0x744FF80 | overloaded x2
        public void IncrementVersion(){} // RVA: 0x744FFA0
        public void InvokeHierarchyChanged(){} // RVA: 0x744FFD0
        public void SetEnabledFromHierarchyPrivate(){} // RVA: 0x7450010
        public void get_isParentEnabledInHierarchy(){} // RVA: 0x74504D0
        public void get_enabledInHierarchy(){} // RVA: 0x7450510
        public void get_enabledSelf(){} // RVA: 0x7450520
        public void set_enabledSelf(){} // RVA: 0x7450530
        public void SetEnabled(){} // RVA: 0x7450540
        public void PropagateEnabledToChildren(){} // RVA: 0x7450560
        public void get_languageDirection(){} // RVA: 0x6FD0C90
        public void get_localLanguageDirection(){} // RVA: 0x6FD0CD0
        public void set_localLanguageDirection(){} // RVA: 0x7450640
        public void get_visible(){} // RVA: 0x7450770
        public void set_visible(){} // RVA: 0x74507D0
        public void MarkDirtyRepaint(){} // RVA: 0x7450850
        public void get_generateVisualContent(){} // RVA: 0xD8AB10
        public void set_generateVisualContent(){} // RVA: 0xDB5330
        public void InvokeGenerateVisualContent(){} // RVA: 0x7450880
        public void GetFullHierarchicalViewDataKey(){} // RVA: 0x7450A80 | overloaded x2
        public void GetOrCreateViewData(){} // RVA: 0x283FA0
        public void OverwriteFromViewData(){} // RVA: 0x7450B70
        public void SaveViewData(){} // RVA: 0x7450DD0
        public void IsViewDataPersitenceSupportedOnChildren(){} // RVA: 0x7450E60
        public void OnViewDataReady(){} // RVA: 0x2DD310 | overloaded x2
        public void ContainsPoint(){} // RVA: 0x7450F60
        public void get_requireMeasureFunction(){} // RVA: 0x7450FC0
        public void set_requireMeasureFunction(){} // RVA: 0x7450FD0
        public void AssignMeasureFunction(){} // RVA: 0x7451040
        public void RemoveMeasureFunction(){} // RVA: 0x74510E0
        public void DoMeasure(){} // RVA: 0x7451110
        public void Measure(){} // RVA: 0x7451130
        public void FinalizeLayout(){} // RVA: 0x7451290
        public void SetInlineRule(){} // RVA: 0x7451370
        public void SetComputedStyle(){} // RVA: 0x7451460
        public void ToString(){} // RVA: 0x74516F0
        public void GetClassesForIteration(){} // RVA: 0x7187E30
        public void AddToClassList(){} // RVA: 0x7451880
        public void RemoveFromClassList(){} // RVA: 0x7451AA0
        public void EnableInClassList(){} // RVA: 0x7451C30
        public void ClassListContains(){} // RVA: 0x7451C60
        public void GetProperty(){} // RVA: 0x7451DC0
        public void SetProperty(){} // RVA: 0x7451E40
        public void HasProperty(){} // RVA: 0x7451EC0
        public void TryGetPropertyInternal(){} // RVA: 0x7451F40
        public void CheckUserKeyArgument(){} // RVA: 0x74520B0
        public void SetPropertyInternal(){} // RVA: 0x7452210
        public void UpdateCursorStyle(){} // RVA: 0x7452550
        public void get_subRenderTargetMode(){} // RVA: 0x7452960
        public void get_defaultMaterial(){} // RVA: 0x7452970
        public void GetAnimationSystem(){} // RVA: 0x7452980
        public void RegisterAnimation(){} // RVA: 0x7452A30
        public void UnregisterAnimation(){} // RVA: 0x7452BE0
        public void UnregisterRunningAnimations(){} // RVA: 0x7452CA0
        public void RegisterRunningAnimations(){} // RVA: 0x7452D30
        public void StartAnimation(){} // RVA: 0x283FA0
        public void AssignStyleValues(){} // RVA: 0x7452DA0
        public void ReadCurrentValues(){} // RVA: 0x7453AB0
        public void UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(){} // RVA: 0x7454AC0
        public void Start(){} // RVA: 0x7454C50
        public void DirtyNextParentWithEventCallback(){} // RVA: 0x7454E80
        public void SetAsNextParentWithEventCallback(){} // RVA: 0x7454F10
        public void GetCachedNextParentWithEventCallback(){} // RVA: 0x7454FE0
        public void get_nextParentWithEventCallback(){} // RVA: 0x7455060
        public void PropagateCachedNextParentWithEventCallback(){} // RVA: 0x74552A0
        public void get_eventCallbackCategories(){} // RVA: 0x7455350
        public void set_eventCallbackCategories(){} // RVA: 0x7455360
        public void get_eventCallbackParentCategories(){} // RVA: 0x74553E0
        public void get_isEventCallbackParentCategoriesDirty(){} // RVA: 0x74554E0
        public void set_isEventCallbackParentCategoriesDirty(){} // RVA: 0x74554F0
        public void UpdateCallbackParentCategories(){} // RVA: 0x7455520
        public void HasEventCallbacks(){} // RVA: 0x74555F0
        public void HasParentEventCallbacksOrDefaultActions(){} // RVA: 0x7455610
        public void HasEventCallbacksOrDefaultActions(){} // RVA: 0x7455660
        public void HasParentEventCallbacksOrDefaultActionAtTarget(){} // RVA: 0x7455690
        public void HasEventCallbacksOrDefaultActionAtTarget(){} // RVA: 0x74556D0
        public void HasDefaultAction(){} // RVA: 0x7455700
        public void get_experimental(){} // RVA: 0x5F061A0
        public void UnityEngine.UIElements.IExperimentalFeatures.get_animation(){} // RVA: 0x5F061A0
        public void get_hierarchy(){} // RVA: 0xDA44B0
        public void set_hierarchy(){} // RVA: 0xD92A30
        public void get_isRootVisualContainer(){} // RVA: 0x7455720
        public void set_isRootVisualContainer(){} // RVA: 0x7455730
        public void get_disableClipping(){} // RVA: 0x7455740
        public void set_disableClipping(){} // RVA: 0x7455750
        public void ShouldClip(){} // RVA: 0x7455780
        public void get_parent(){} // RVA: 0x74557E0
        public void get_elementPanel(){} // RVA: 0xD8F130
        public void set_elementPanel(){} // RVA: 0xD9C3C0
        public void get_panel(){} // RVA: 0x74557F0
        public void get_contentContainer(){} // RVA: 0x5F061A0
        public void set_visualTreeAssetSource(){} // RVA: 0xD9F7D0
        public void Add(){} // RVA: 0x7455800
        public void Insert(){} // RVA: 0x7455960
        public void Clear(){} // RVA: 0x7455A50
        public void ElementAt(){} // RVA: 0x7455AD0
        public void get_Item(){} // RVA: 0x7455AE0
        public void get_childCount(){} // RVA: 0x7455BC0
        public void IndexOf(){} // RVA: 0x7455C60
        public void ElementAtTreePath(){} // RVA: 0x7455D50
        public void FindElementInTree(){} // RVA: 0x7455FF0
        public void Children(){} // RVA: 0x7456160
        public void BringToFront(){} // RVA: 0x7456220
        public void SendToBack(){} // RVA: 0x7456270
        public void PlaceBehind(){} // RVA: 0x74562C0
        public void RemoveFromHierarchy(){} // RVA: 0x74563E0
        public void GetFirstOfType(){} // RVA: 0x283FA0
        public void GetFirstAncestorOfType(){} // RVA: 0x283FA0
        public void GetFirstAncestorWhere(){} // RVA: 0x7456500
        public void Contains(){} // RVA: 0x7456580
        public void GatherAllChildren(){} // RVA: 0x74565D0
        public void FindCommonAncestor(){} // RVA: 0x74566F0
        public void GetRoot(){} // RVA: 0x7456880
        public void GetRootVisualContainer(){} // RVA: 0x7456910
        public void GetNextElementDepthFirst(){} // RVA: 0x7456950
        public void GetPreviousElementDepthFirst(){} // RVA: 0x7456A90
        public void RetargetElement(){} // RVA: 0x7456BE0
        public void get_positionWithLayout(){} // RVA: 0x7456C90
        public void GetPivotedMatrixWithLayout(){} // RVA: 0x7456D20
        public void get_hasDefaultRotationAndScale(){} // RVA: 0x74571C0
        public void Min(){} // RVA: 0x74572F0
        public void Max(){} // RVA: 0x7457300
        public void TransformAlignedRectToParentSpace(){} // RVA: 0x7457310
        public void CalculateConservativeRect(){} // RVA: 0x7457450
        public void TransformAlignedRect(){} // RVA: 0x7457830
        public void OrderMinMaxRect(){} // RVA: 0x74578B0
        public void MultiplyMatrix44Point2(){} // RVA: 0x7457900
        public void MultiplyVector2(){} // RVA: 0x7457950
        public void MultiplyMatrix34(){} // RVA: 0x7457990
        public void TranslateMatrix34(){} // RVA: 0x7457BC0
        public void TranslateMatrix34InPlace(){} // RVA: 0x7457CD0
        public void get_schedule(){} // RVA: 0x5F061A0
        public void UnityEngine.UIElements.IVisualElementScheduler.Execute(){} // RVA: 0x7457E90 | overloaded x2
        public void get_style(){} // RVA: 0x7457FC0
        public void get_customStyle(){} // RVA: 0x7458080
        public void get_styleSheets(){} // RVA: 0x10073D0
        public void AddStyleSheetPath(){} // RVA: 0x7458160
        public void ResolveLengthValue(){} // RVA: 0x7458560
        public void ResolveTranslate(){} // RVA: 0x74586B0
        public void ResolveTransformOrigin(){} // RVA: 0x7458860
        public void ResolveRotation(){} // RVA: 0x7458A60
        public void ResolveScale(){} // RVA: 0x7458BD0
        public void get_tooltip(){} // RVA: 0x7458CD0
        public void set_tooltip(){} // RVA: 0x7458D70
        public void GetOrCreateTypeData(){} // RVA: 0x7458EF0
        public void get_typeData(){} // RVA: 0x7459050
        public void .cctor(){} // RVA: 0x7459210
        public void <AssignMeasureFunction>b__432_0(){} // RVA: 0x7451130
    }

    public class VisualElementAnimationSystem
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_Animations; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_IterationList; // 0x28

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x732B020
        public void get_stylePropertyAnimationProfilerMarker(){} // RVA: 0x732B080
        public void UnregisterAnimation(){} // RVA: 0x732B0E0
        public void UnregisterAnimations(){} // RVA: 0x732B140
        public void RegisterAnimation(){} // RVA: 0x732B2D0
        public void RegisterAnimations(){} // RVA: 0x732B350
        public void Update(){} // RVA: 0x732B4F0
        public void OnVersionChanged(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x732B9C0
        public void .cctor(){} // RVA: 0x732BB20
    }

    public class VisualElementAsset
    {
        public string m_Name; // 0x30
        public int m_RuleIndex; // 0x38
        public string m_Text; // 0x40
        public 0x65841678 m_PickingMode; // 0x48
        public string[] m_Classes; // 0x50
        public System.Collections.Generic.List`1<string> m_StylesheetPaths; // 0x58
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet> m_Stylesheets; // 0x60

        // ── Methods ──
        public void get_ruleIndex(){} // RVA: 0x7145EA0
        public void get_classes(){} // RVA: 0x7187FD0
        public void get_stylesheetPaths(){} // RVA: 0x7494BC0
        public void get_hasStylesheetPaths(){} // RVA: 0x51563D0
        public void get_stylesheets(){} // RVA: 0x7494C80
        public void get_hasStylesheets(){} // RVA: 0x1D110B0
        public void get_skipClone(){} // RVA: 0x3A5570
        public void OnBeforeSerialize(){} // RVA: 0x2DD310
        public void OnAfterDeserialize(){} // RVA: 0x7494D40
    }

    public class VisualElementExtensions
    {
        // ── Methods ──
        public void StretchToParentSize(){} // RVA: 0x7326650
        public void AddManipulator(){} // RVA: 0x73268F0
        public void RemoveManipulator(){} // RVA: 0x7326950
        public void WorldToLocal(){} // RVA: 0x7326B90 | overloaded x2
        public void LocalToWorld(){} // RVA: 0x7326A90
        public void ChangeCoordinatesTo(){} // RVA: 0x7326C80
    }

    public class VisualElementFactoryRegistry
    {
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<UnityEngine.UIElements.IUxmlFactory>> s_Factories;

        // ── Methods ──
        public void GetMovedUIControlTypeName(){} // RVA: 0x7494ED0
        public void get_factories(){} // RVA: 0x74950C0
        public void RegisterFactory(){} // RVA: 0x7495320
        public void TryGetValue(){} // RVA: 0x7495800
        public void RegisterEngineFactories(){} // RVA: 0x74958B0
        public void RegisterUserFactories(){} // RVA: 0x7497900
    }

    public class VisualElementFocusChangeDirection
    {
        public UnityEngine.UIElements.VisualElementFocusChangeDirection s_Left;
        public UnityEngine.UIElements.VisualElementFocusChangeDirection s_Right; // 0x8

        // ── Methods ──
        public void get_left(){} // RVA: 0x7327890
        public void get_right(){} // RVA: 0x73278F0
        public void .ctor(){} // RVA: 0x7327950
        public void .cctor(){} // RVA: 0x73279B0
    }

    public class VisualElementFocusChangeTarget
    {
        public UnityEngine.UIElements.ObjectPool`1<UnityEngine.UIElements.VisualElementFocusChangeTarget> Pool;

        // ── Methods ──
        public void GetPooled(){} // RVA: 0x7327C40
        public void Dispose(){} // RVA: 0x7327D60
        public void ApplyTo(){} // RVA: 0x7327E40
        public void .ctor(){} // RVA: 0x7327E90
        public void get_target(){} // RVA: 0x2E07C0
        public void set_target(){} // RVA: 0x343E80
        public void .cctor(){} // RVA: 0x7327F40
    }

    public class VisualElementFocusRing
    {
        public UnityEngine.UIElements.VisualElement root; // 0x10
        public 0x65841CA8 <defaultFocusOrder>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7328220
        public void get_focusController(){} // RVA: 0x7F0180
        public void get_defaultFocusOrder(){} // RVA: 0x5BED50
        public void set_defaultFocusOrder(){} // RVA: 0x6374E0
        public void FocusRingAutoIndexSort(){} // RVA: 0x7328350
        public void FocusRingSort(){} // RVA: 0x7328720
        public void DoUpdate(){} // RVA: 0x7328850
        public void BuildRingForScopeRecursive(){} // RVA: 0x7328940
        public void SortAndFlattenScopeLists(){} // RVA: 0x7328C50
        public void GetFocusableInternalIndex(){} // RVA: 0x7328F20
        public void GetFocusChangeDirection(){} // RVA: 0x7328FE0
        public void GetNextFocusable(){} // RVA: 0x7329530
        public void GetNextFocusableInTree(){} // RVA: 0x7329C10
        public void GetPreviousFocusableInTree(){} // RVA: 0x7329CB0
    }

    public class VisualElementListPool
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7326180
        public void Get(){} // RVA: 0x7326250
        public void Release(){} // RVA: 0x7326330
        public void .cctor(){} // RVA: 0x73263F0
    }

    public class VisualElementPanelActivator
    {
        public UnityEngine.UIElements.IVisualElementPanelActivatable m_Activatable; // 0x10
        public bool <isActive>k__BackingField; // 0x18

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x2F84E0
        public void set_isActive(){} // RVA: 0x2F84F0
        public void get_isDetaching(){} // RVA: 0x6B93D0
        public void set_isDetaching(){} // RVA: 0xF43D70
        public void .ctor(){} // RVA: 0x7329DA0
        public void SetActive(){} // RVA: 0x7329F50
        public void SendActivation(){} // RVA: 0x732A0C0
        public void SendDeactivation(){} // RVA: 0x732A140
        public void OnEnter(){} // RVA: 0x732A1C0
        public void OnLeave(){} // RVA: 0x732A1D0
    }

    public class VisualElementStyleSheetSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x100A2F0
        public void Add(){} // RVA: 0x732A230
        public void Remove(){} // RVA: 0x732A4F0
        public void Equals(){} // RVA: 0x732A720 | overloaded x2
        public void GetHashCode(){} // RVA: 0x732A800
    }

    public class VisualElementUtils
    {
        // ── Methods ──
        public void GetUniqueName(){} // RVA: 0x732A830
        public void GetFoldoutDepth(){} // RVA: 0x732A9F0
        public void AssignInspectorStyleIfNecessary(){} // RVA: 0x732AAD0
        public void .cctor(){} // RVA: 0x732ACA0
    }

    public class VisualTreeAsset
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
        public void get_importedWithErrors(){} // RVA: 0x7090430
        public void set_importedWithErrors(){} // RVA: 0x2F84F0
        public void get_importedWithWarnings(){} // RVA: 0x7473170
        public void set_importedWithWarnings(){} // RVA: 0xF43D70
        public void GetNextChildSerialNumber(){} // RVA: 0x7497D00
        public void get_templateDependencies(){} // RVA: 0x7497D90
        public void get_stylesheets(){} // RVA: 0x7497E40
        public void get_visualElementAssets(){} // RVA: 0x7145E90
        public void set_visualElementAssets(){} // RVA: 0x30B890
        public void get_templateAssets(){} // RVA: 0x7187DC0
        public void set_templateAssets(){} // RVA: 0x49B830
        public void get_uxmlObjectEntries(){} // RVA: 0x35A740
        public void get_uxmlObjectIds(){} // RVA: 0x358730
        public void RegisterUxmlObject(){} // RVA: 0x7497EF0
        public void GetUxmlObjects(){}
        public void AssetEntryExists(){} // RVA: 0x7498230
        public void RegisterAssetEntry(){} // RVA: 0x7498450
        public void GetAsset(){} // RVA: 0x283FA0
        public void GetUxmlObjectEntry(){} // RVA: 0x74985A0
        public void GetUxmlObjectFactory(){} // RVA: 0x7498710
        public void get_slots(){} // RVA: 0x7188040
        public void set_slots(){} // RVA: 0x3A5510
        public void get_contentContainerId(){} // RVA: 0x71B8A30
        public void set_contentContainerId(){} // RVA: 0x59C530
        public void Instantiate(){} // RVA: 0x7498CC0 | overloaded x2
        public void CloneTree(){} // RVA: 0x7498F90 | overloaded x5
        public void CloneSetupRecursively(){} // RVA: 0x74997D0
        public void CompareForOrder(){} // RVA: 0x749A530
        public void TryGetSlotInsertionPoint(){} // RVA: 0x749A570
        public void ResolveTemplate(){} // RVA: 0x749A710
        public void Create(){} // RVA: 0x749AAE0
        public void AssignClassListFromAssetToElement(){} // RVA: 0x749B2C0
        public void AssignStyleSheetFromAssetToElement(){} // RVA: 0x749B330
        public void get_contentHash(){} // RVA: 0x71B8A40
        public void set_contentHash(){} // RVA: 0x1C5A610
        public void .ctor(){} // RVA: 0x53BFB0
        public void .cctor(){} // RVA: 0x749B5B0
        public void <Create>g__CreateError|65_0(){} // RVA: 0x749B730
    }

    public class VisualTreeBindingsUpdater
    {
        public UnityEngine.PropertyName s_BindingRequestObjectVEPropertyName;
        public UnityEngine.PropertyName s_AdditionalBindingObjectVEPropertyName; // 0x4

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x72E6740
        public void GetBindingObjectFromElement(){} // RVA: 0x72E67A0
        public void StartTracking(){} // RVA: 0x72E68D0
        public void StopTracking(){} // RVA: 0x72E6970
        public void get_temporaryObjectCache(){} // RVA: 0x37B370
        public void GetAdditionalBinding(){} // RVA: 0x72E6A10
        public void StartTrackingRecursive(){} // RVA: 0x72E6AA0
        public void StopTrackingRecursive(){} // RVA: 0x72E6C70
        public void OnVersionChanged(){} // RVA: 0x72E6E20
        public void OnHierarchyChange(){} // RVA: 0x72E6F30
        public void CurrentTime(){} // RVA: 0x72E6F60
        public void PerformTrackingOperations(){} // RVA: 0x72E6FB0
        public void Update(){} // RVA: 0x72E72E0
        public void UpdateBindings(){} // RVA: 0x72E7990
        public void .ctor(){} // RVA: 0x72E7F20
        public void .cctor(){} // RVA: 0x72E8280
    }

    public class VisualTreeHierarchyFlagsUpdater
    {
        public uint m_Version; // 0x20

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x732BD50
        public void OnVersionChanged(){} // RVA: 0x732BDB0
        public void DirtyHierarchy(){} // RVA: 0x732BEF0
        public void DirtyBoundingBoxHierarchy(){} // RVA: 0x732C050
        public void Update(){} // RVA: 0x732C0B0
        public void .ctor(){} // RVA: 0x5774570
        public void .cctor(){} // RVA: 0x732C120
    }

    public class VisualTreeStyleUpdater
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_ApplyStyleUpdateList; // 0x20
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_TransitionPropertyUpdateList; // 0x28

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x732D100
        public void OnVersionChanged(){} // RVA: 0x732D160
        public void Update(){} // RVA: 0x732D240
        public void get_disposed(){} // RVA: 0x394D30
        public void set_disposed(){} // RVA: 0x394D40
        public void Dispose(){} // RVA: 0x732D720
        public void ApplyStyles(){} // RVA: 0x732D760
        public void .ctor(){} // RVA: 0x732D860
        public void .cctor(){} // RVA: 0x732DA20
    }

    public class VisualTreeStyleUpdaterTraversal
    {
        public UnityEngine.UIElements.StyleVariableContext m_ProcessVarContext; // 0x10

        // ── Methods ──
        public void get_currentPixelsPerPoint(){} // RVA: 0x466280
        public void set_currentPixelsPerPoint(){} // RVA: 0x4FDE90
        public void PrepareTraversal(){} // RVA: 0x4FDE90
        public void AddChangedElement(){} // RVA: 0x732E0A0
        public void Clear(){} // RVA: 0x732E1D0
        public void PropagateToChildren(){} // RVA: 0x732E270
        public void PropagateToParents(){} // RVA: 0x732E3F0
        public void OnProcessMatchResult(){} // RVA: 0x732E4A0
        public void TraverseRecursive(){} // RVA: 0x732E4E0
        public void ProcessTransitions(){} // RVA: 0x732EF20
        public void ForceUpdateTransitions(){} // RVA: 0x732F040
        public void CancelAnimationsWithNoTransitionProperty(){} // RVA: 0x732F310
        public void ShouldSkipElement(){} // RVA: 0x732F660
        public void ProcessMatchedRules(){} // RVA: 0x732F6F0
        public void ProcessMatchedVariables(){} // RVA: 0x7330A60
        public void .ctor(){} // RVA: 0x7330B40
    }

    public class VisualTreeUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7331120
        public void Dispose(){} // RVA: 0x73313B0
        public void UpdateVisualTreePhase(){} // RVA: 0x73314D0
        public void OnVersionChanged(){} // RVA: 0x7331670
        public void SetUpdater(){} // RVA: 0x24FA0
        public void GetUpdater(){} // RVA: 0x73317B0
        public void SetDefaultUpdaters(){} // RVA: 0x73317F0
    }

    public class VisualTreeViewDataUpdater
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_UpdateList; // 0x20

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7331D40
        public void OnVersionChanged(){} // RVA: 0x7331DA0
        public void Update(){} // RVA: 0x7331EC0
        public void ValidateViewDataOnSubTree(){} // RVA: 0x7332020
        public void PropagateToParents(){} // RVA: 0x7332280
        public void .ctor(){} // RVA: 0x7332330
        public void .cctor(){} // RVA: 0x7332470
    }

}