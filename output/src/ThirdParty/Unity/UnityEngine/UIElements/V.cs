// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 33
// Methods: 743

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class ValidateCommandEvent : CommandEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8056010
        public void .ctor(){} // RVA: 0x8056100
    }

    public class Vector2Field : BaseCompositeField`3
    {
        public object ussClassName;
        public object labelUssClassName;
        public object inputUssClassName;

        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FD4870
        public void .ctor(){} // RVA: 0x7FD4FF0
        public void .cctor(){} // RVA: 0x7FD5130
    }

    public class Vector2IntField : BaseCompositeField`3
    {
        public object ussClassName;
        public object labelUssClassName;
        public object inputUssClassName;

        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FD8730
        public void .ctor(){} // RVA: 0x7FD8EB0
        public void .cctor(){} // RVA: 0x7FD8FF0
    }

    public class Vector3Field : BaseCompositeField`3
    {
        public object ussClassName;
        public object labelUssClassName;
        public object inputUssClassName;

        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FD5820
        public void .ctor(){} // RVA: 0x7FD6130
        public void .cctor(){} // RVA: 0x7FD6270
    }

    public class Vector3IntField : BaseCompositeField`3
    {
        public object ussClassName;
        public object labelUssClassName;
        public object inputUssClassName;

        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FD9940
        public void .ctor(){} // RVA: 0x7FDA250
        public void .cctor(){} // RVA: 0x7FDA390
    }

    public class Vector4Field : BaseCompositeField`3
    {
        public object ussClassName;
        public object labelUssClassName;
        public object inputUssClassName;

        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FD6D10
        public void .ctor(){} // RVA: 0x7FD7A00
        public void .cctor(){} // RVA: 0x7FD7B40
    }

    public class VectorImage : ScriptableObject
    {
        public object version;
        public object atlas;
        public object vertices;
        public object indices;
        public object settings;
        public object size;

        // ── Methods ──
        public void get_width(){} // RVA: 0xD344A0
        public void get_height(){} // RVA: 0xB4B880
        public void .ctor(){} // RVA: 0x7F2C0A0
    }

    public class VectorImageVertex[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F710
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AF90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4D90
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E355B0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AF90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class VerticalVirtualizationController`1 : CollectionVirtualizationController
    {
        public object m_Pool;
        public object m_CollectionView;
        public object m_ActiveItems;
        public object m_DraggedItem;
        public object m_DeferredScrollToItemIndex;
        public object m_PerformDeferredScrollToItem;
        public object m_ScheduleDeferredScrollToItem;
        public object m_ScrollScheduledItem;
        public object m_ScrollCallback;
        public object m_LastFocusedElementIndex;
        public object m_LastFocusedElementTreeChildIndexes;
        public object m_VisibleItemPredicateDelegate;
        public object m_ScrollInsertionList;
        public object m_EmptyRows;

        // ── Methods ──
        public void get_activeItems(){} // RVA: 0x87C0A0
        public void get_itemsCount(){} // RVA: 0x87C130
        public void VisibleItemPredicate(){} // RVA: 0xA94080
        public void get_firstVisibleItem(){} // RVA: 0xA94080
        public void get_lastVisibleItem(){} // RVA: 0xA94080
        public void get_visibleItemCount(){} // RVA: 0x87C130
        public void get_serializedData(){} // RVA: 0x87C0A0
        public void get_firstVisibleIndex(){} // RVA: 0x87C130
        public void set_firstVisibleIndex(){} // RVA: 0x8944F0
        public void get_lastHeight(){} // RVA: 0x890F90
        public void get_alwaysRebindOnRefresh(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x894320
        public void Refresh(){} // RVA: 0x894750
        public void UnbindAll(){} // RVA: 0x894290
        public void Setup(){} // RVA: 0xA94080
        public void ShouldDeferScrollToItem(){} // RVA: 0x87DD20
        public void ScheduleDeferredScrollToItem(){} // RVA: 0x894290
        public void PerformDeferredScrollToItem(){} // RVA: 0x894290
        public void OnDetachFromPanelEvent(){} // RVA: 0x894320
        public void OnFocusIn(){} // RVA: 0x894320
        public void OnFocusOut(){} // RVA: 0x894320
        public void HandleFocus(){} // RVA: 0x899290
        public void UpdateBackground(){} // RVA: 0x894290
        public void StartDragItem(){} // RVA: 0x894320
        public void EndDrag(){} // RVA: 0x8944F0
        public void GetOrMakeItemAtIndex(){} // RVA: 0xA94080
        public void ReleaseItem(){} // RVA: 0x8944F0
        public void OnDestroyItem(){} // RVA: 0x894320
        public void OnScrollUpdate(){} // RVA: 0x894290
        public void GetDraggedIndex(){} // RVA: 0x87C130
        public void ScheduleScroll(){} // RVA: 0x894290
    }

    public class VerticalVirtualizationController`1 : CollectionVirtualizationController
    {
        public object m_Pool;
        public object m_CollectionView;
        public object m_ActiveItems;
        public object m_DraggedItem;
        public object m_DeferredScrollToItemIndex;
        public object m_PerformDeferredScrollToItem;
        public object m_ScheduleDeferredScrollToItem;
        public object m_ScrollScheduledItem;
        public object m_ScrollCallback;
        public object m_LastFocusedElementIndex;
        public object m_LastFocusedElementTreeChildIndexes;
        public object m_VisibleItemPredicateDelegate;
        public object m_ScrollInsertionList;
        public object m_EmptyRows;

        // ── Methods ──
        public void get_activeItems(){} // RVA: 0xB70160
        public void get_itemsCount(){} // RVA: 0x561C7A0
        public void VisibleItemPredicate(){} // RVA: 0x561C820
        public void get_firstVisibleItem(){} // RVA: 0x561C950
        public void get_lastVisibleItem(){} // RVA: 0x561CAA0
        public void get_visibleItemCount(){} // RVA: 0x561CB50
        public void get_serializedData(){} // RVA: 0x166BA30
        public void get_firstVisibleIndex(){} // RVA: 0x561CCA0
        public void set_firstVisibleIndex(){} // RVA: 0x561CD20
        public void get_lastHeight(){} // RVA: 0x561CD50
        public void get_alwaysRebindOnRefresh(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0x561CD70
        public void Refresh(){} // RVA: 0x561D870
        public void UnbindAll(){} // RVA: 0x561DDD0
        public void Setup(){} // RVA: 0x561DF50
        public void ShouldDeferScrollToItem(){} // RVA: 0x561E4F0
        public void ScheduleDeferredScrollToItem(){} // RVA: 0x561E5A0
        public void PerformDeferredScrollToItem(){} // RVA: 0x561E6A0
        public void OnDetachFromPanelEvent(){} // RVA: 0x561E710
        public void OnFocusIn(){} // RVA: 0x561E7D0
        public void OnFocusOut(){} // RVA: 0x561EC90
        public void HandleFocus(){} // RVA: 0x561ED20
        public void UpdateBackground(){} // RVA: 0x561EE20
        public void StartDragItem(){} // RVA: 0x561F500
        public void EndDrag(){} // RVA: 0x561F690
        public void GetOrMakeItemAtIndex(){} // RVA: 0x561FA20
        public void ReleaseItem(){} // RVA: 0x561FD40
        public void OnDestroyItem(){} // RVA: 0x561FE30
        public void OnScrollUpdate(){} // RVA: 0xB43310
        public void GetDraggedIndex(){} // RVA: 0x561FFD0
        public void ScheduleScroll(){} // RVA: 0x5620070
    }

    public class VerticalVirtualizationController`1 : CollectionVirtualizationController
    {
        public object m_Pool;
        public object m_CollectionView;
        public object m_ActiveItems;
        public object m_DraggedItem;
        public object m_DeferredScrollToItemIndex;
        public object m_PerformDeferredScrollToItem;
        public object m_ScheduleDeferredScrollToItem;
        public object m_ScrollScheduledItem;
        public object m_ScrollCallback;
        public object m_LastFocusedElementIndex;
        public object m_LastFocusedElementTreeChildIndexes;
        public object m_VisibleItemPredicateDelegate;
        public object m_ScrollInsertionList;
        public object m_EmptyRows;

        // ── Methods ──
        public void get_activeItems(){} // RVA: 0xB70160
        public void get_itemsCount(){} // RVA: 0x561C7A0
        public void VisibleItemPredicate(){} // RVA: 0x561C820
        public void get_firstVisibleItem(){} // RVA: 0x561C950
        public void get_lastVisibleItem(){} // RVA: 0x561CAA0
        public void get_visibleItemCount(){} // RVA: 0x561CB50
        public void get_serializedData(){} // RVA: 0x166BA30
        public void get_firstVisibleIndex(){} // RVA: 0x561CCA0
        public void set_firstVisibleIndex(){} // RVA: 0x561CD20
        public void get_lastHeight(){} // RVA: 0x561CD50
        public void get_alwaysRebindOnRefresh(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0x561CD70
        public void Refresh(){} // RVA: 0x561D870
        public void UnbindAll(){} // RVA: 0x561DDD0
        public void Setup(){} // RVA: 0x561DF50
        public void ShouldDeferScrollToItem(){} // RVA: 0x561E4F0
        public void ScheduleDeferredScrollToItem(){} // RVA: 0x561E5A0
        public void PerformDeferredScrollToItem(){} // RVA: 0x561E6A0
        public void OnDetachFromPanelEvent(){} // RVA: 0x561E710
        public void OnFocusIn(){} // RVA: 0x561E7D0
        public void OnFocusOut(){} // RVA: 0x561EC90
        public void HandleFocus(){} // RVA: 0x561ED20
        public void UpdateBackground(){} // RVA: 0x561EE20
        public void StartDragItem(){} // RVA: 0x561F500
        public void EndDrag(){} // RVA: 0x561F690
        public void GetOrMakeItemAtIndex(){} // RVA: 0x561FA20
        public void ReleaseItem(){} // RVA: 0x561FD40
        public void OnDestroyItem(){} // RVA: 0x561FE30
        public void OnScrollUpdate(){} // RVA: 0xB43310
        public void GetDraggedIndex(){} // RVA: 0x561FFD0
        public void ScheduleScroll(){} // RVA: 0x5620070
    }

    public class VisualData : ValueType
    {
        public object backgroundColor;
        public object backgroundImage;
        public object backgroundPositionX;
        public object backgroundPositionY;
        public object backgroundRepeat;
        public object backgroundSize;
        public object borderBottomColor;
        public object borderBottomLeftRadius;
        public object borderBottomRightRadius;
        public object borderLeftColor;
        public object borderRightColor;
        public object borderTopColor;
        public object borderTopLeftRadius;
        public object borderTopRightRadius;
        public object opacity;
        public object overflow;

        // ── Methods ──
        public void Copy(){} // RVA: 0x9960C0
        public void CopyFrom(){} // RVA: 0x996C40
        public void op_Equality(){} // RVA: 0x7ED3FF0
        public void Equals(){} // RVA: 0x996CF0
        public void GetHashCode(){} // RVA: 0x996E20
    }

    public class VisualElement : Focusable
    {
        public object _runningAnimationCount;
        public object _completedAnimationCount;
        public object s_NextId;
        public object s_EmptyClassList;
        public object userDataPropertyKey;
        public object disabledUssClassName;
        public object m_Name;
        public object m_ClassList;
        public object m_PropertyBag;
        public object m_Flags;
        public object m_ViewDataKey;
        public object m_RenderHints;
        public object lastLayout;
        public object lastPseudoPadding;
        public object renderChainData;
        public object shouldCutRenderChain;
        public object uiRenderer;
        public object m_Layout;
        public object m_BoundingBox;
        public object worldBoundingBoxDirtyDependencies;
        public object m_WorldBoundingBox;
        public object worldTransformInverseDirtyDependencies;
        public object m_WorldTransformCache;
        public object m_WorldTransformInverseCache;
        public object m_WorldClip;
        public object m_WorldClipMinusGroup;
        public object m_WorldClipIsInfinite;
        public object s_InfiniteRect;
        public object triggerPseudoMask;
        public object dependencyPseudoMask;
        public object m_PseudoStates;
        public object _containedPointerIds;
        public object m_PickingMode;
        public object m_LayoutNode;
        public object m_Style;
        public object variableContext;
        public object inheritedStylesHash;
        public object controlid;
        public object imguiContainerDescendantCount;
        public object m_EnabledSelf;
        public object m_LanguageDirection;
        public object m_LocalLanguageDirection;
        public object _generateVisualContent;
        public object k_GenerateVisualContentMarker;
        public object m_SubRenderTargetMode;
        public object s_runtimeMaterial;
        public object m_defaultMaterial;
        public object m_RunningAnimations;
        public object childCountProperty;
        public object contentRectProperty;
        public object dataSourcePathProperty;
        public object dataSourceProperty;
        public object disablePlayModeTintProperty;
        public object enabledInHierarchyProperty;
        public object enabledSelfProperty;
        public object layoutProperty;
        public object languageDirectionProperty;
        public object localBoundProperty;
        public object nameProperty;
        public object panelProperty;
        public object pickingModeProperty;
        public object styleSheetsProperty;
        public object tooltipProperty;
        public object usageHintsProperty;
        public object userDataProperty;
        public object viewDataKeyProperty;
        public object visibleProperty;
        public object visualTreeAssetSourceProperty;
        public object worldBoundProperty;
        public object worldTransformProperty;
        public object m_DataSource;
        public object m_DataSourcePath;
        public object m_Bindings;
        public object _dataSourceType;
        public object m_TrickleDownHandleEventCategories;
        public object m_BubbleUpHandleEventCategories;
        public object m_BubbleUpEventCallbackCategories;
        public object m_TrickleDownEventCallbackCategories;
        public object m_EventInterestSelfCategories;
        public object m_CachedEventInterestParentCategories;
        public object s_NextParentVersion;
        public object m_NextParentCachedVersion;
        public object m_NextParentRequiredVersion;
        public object m_CachedNextParentWithEventInterests;
        public object k_RootVisualContainerName;
        public object _hierarchy;
        public object _isRootVisualContainer;
        public object _cacheAsBitmap;
        public object m_PhysicalParent;
        public object m_LogicalParent;
        public object elementAdded;
        public object elementRemoved;
        public object s_EmptyList;
        public object m_Children;
        public object _elementPanel;
        public object m_VisualTreeAssetSource;
        public object s_CustomStyleAccess;
        public object inlineStyleAccess;
        public object resolvedStyleAccess;
        public object styleSheetList;
        public object s_InternalStyleSheetPath;
        public object tooltipPropertyKey;
        public object s_TypeData;
        public object m_TypeData;

        // ── Methods ──
        public void UnityEngine.UIElements.IResolvedStyle.get_alignContent(){} // RVA: 0x7EAA0A0
        public void UnityEngine.UIElements.IResolvedStyle.get_alignItems(){} // RVA: 0x7EAA100
        public void UnityEngine.UIElements.IResolvedStyle.get_alignSelf(){} // RVA: 0x7EAA160
        public void UnityEngine.UIElements.IResolvedStyle.get_backgroundColor(){} // RVA: 0x7EAA1C0
        public void UnityEngine.UIElements.IResolvedStyle.get_backgroundImage(){} // RVA: 0x7EAA240
        public void UnityEngine.UIElements.IResolvedStyle.get_backgroundPositionX(){} // RVA: 0x7EAA2C0
        public void UnityEngine.UIElements.IResolvedStyle.get_backgroundPositionY(){} // RVA: 0x7EAA340
        public void UnityEngine.UIElements.IResolvedStyle.get_backgroundRepeat(){} // RVA: 0x7EAA3C0
        public void UnityEngine.UIElements.IResolvedStyle.get_backgroundSize(){} // RVA: 0x7EAA420
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor(){} // RVA: 0x7EAA4A0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius(){} // RVA: 0x7EAA520
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius(){} // RVA: 0x7EAA580
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth(){} // RVA: 0x7EAA5E0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor(){} // RVA: 0x7EAA640
        public void UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth(){} // RVA: 0x7EAA6C0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderRightColor(){} // RVA: 0x7EAA720
        public void UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth(){} // RVA: 0x7EAA7A0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopColor(){} // RVA: 0x7EAA800
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius(){} // RVA: 0x7EAA880
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius(){} // RVA: 0x7EAA8E0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth(){} // RVA: 0x7EAA940
        public void UnityEngine.UIElements.IResolvedStyle.get_bottom(){} // RVA: 0x7EAA9A0
        public void UnityEngine.UIElements.IResolvedStyle.get_color(){} // RVA: 0x7EAAA00
        public void UnityEngine.UIElements.IResolvedStyle.get_display(){} // RVA: 0x7EAAA80
        public void UnityEngine.UIElements.IResolvedStyle.get_flexBasis(){} // RVA: 0x7EAAAE0
        public void UnityEngine.UIElements.IResolvedStyle.get_flexDirection(){} // RVA: 0x7EAAB40
        public void UnityEngine.UIElements.IResolvedStyle.get_flexGrow(){} // RVA: 0x7EAABA0
        public void UnityEngine.UIElements.IResolvedStyle.get_flexShrink(){} // RVA: 0x7EAAC00
        public void UnityEngine.UIElements.IResolvedStyle.get_flexWrap(){} // RVA: 0x7EAAC60
        public void UnityEngine.UIElements.IResolvedStyle.get_fontSize(){} // RVA: 0x7EAACC0
        public void UnityEngine.UIElements.IResolvedStyle.get_height(){} // RVA: 0x7EAAD20
        public void UnityEngine.UIElements.IResolvedStyle.get_justifyContent(){} // RVA: 0x7EAAD80
        public void UnityEngine.UIElements.IResolvedStyle.get_left(){} // RVA: 0x7EAADE0
        public void UnityEngine.UIElements.IResolvedStyle.get_letterSpacing(){} // RVA: 0x7EAAE40
        public void UnityEngine.UIElements.IResolvedStyle.get_marginBottom(){} // RVA: 0x7EAAEA0
        public void UnityEngine.UIElements.IResolvedStyle.get_marginLeft(){} // RVA: 0x7EAAF00
        public void UnityEngine.UIElements.IResolvedStyle.get_marginRight(){} // RVA: 0x7EAAF60
        public void UnityEngine.UIElements.IResolvedStyle.get_marginTop(){} // RVA: 0x7EAAFC0
        public void UnityEngine.UIElements.IResolvedStyle.get_maxHeight(){} // RVA: 0x7EAB020
        public void UnityEngine.UIElements.IResolvedStyle.get_maxWidth(){} // RVA: 0x7EAB080
        public void UnityEngine.UIElements.IResolvedStyle.get_minHeight(){} // RVA: 0x7EAB0E0
        public void UnityEngine.UIElements.IResolvedStyle.get_minWidth(){} // RVA: 0x7EAB140
        public void UnityEngine.UIElements.IResolvedStyle.get_opacity(){} // RVA: 0x7EAB1A0
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingBottom(){} // RVA: 0x7EAB200
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingLeft(){} // RVA: 0x7EAB260
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingRight(){} // RVA: 0x7EAB2C0
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingTop(){} // RVA: 0x7EAB320
        public void UnityEngine.UIElements.IResolvedStyle.get_position(){} // RVA: 0x7EAB380
        public void UnityEngine.UIElements.IResolvedStyle.get_right(){} // RVA: 0x7EAB3E0
        public void UnityEngine.UIElements.IResolvedStyle.get_rotate(){} // RVA: 0x7EAB440
        public void UnityEngine.UIElements.IResolvedStyle.get_scale(){} // RVA: 0x7EAB4C0
        public void UnityEngine.UIElements.IResolvedStyle.get_textOverflow(){} // RVA: 0x7EAB540
        public void UnityEngine.UIElements.IResolvedStyle.get_top(){} // RVA: 0x7EAB5A0
        public void UnityEngine.UIElements.IResolvedStyle.get_transformOrigin(){} // RVA: 0x7EAB600
        public void UnityEngine.UIElements.IResolvedStyle.get_transitionDelay(){} // RVA: 0x7EAB680
        public void UnityEngine.UIElements.IResolvedStyle.get_transitionDuration(){} // RVA: 0x7EAB6E0
        public void UnityEngine.UIElements.IResolvedStyle.get_transitionProperty(){} // RVA: 0x7EAB740
        public void UnityEngine.UIElements.IResolvedStyle.get_transitionTimingFunction(){} // RVA: 0x7EAB7A0
        public void UnityEngine.UIElements.IResolvedStyle.get_translate(){} // RVA: 0x7EAB800
        public void UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor(){} // RVA: 0x7EAB880
        public void UnityEngine.UIElements.IResolvedStyle.get_unityEditorTextRenderingMode(){} // RVA: 0x7EAB900
        public void UnityEngine.UIElements.IResolvedStyle.get_unityFont(){} // RVA: 0x7EAB960
        public void UnityEngine.UIElements.IResolvedStyle.get_unityFontDefinition(){} // RVA: 0x7EAB9B0
        public void UnityEngine.UIElements.IResolvedStyle.get_unityFontStyleAndWeight(){} // RVA: 0x7EABA30
        public void UnityEngine.UIElements.IResolvedStyle.get_unityParagraphSpacing(){} // RVA: 0x7EABA90
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceBottom(){} // RVA: 0x7EABAF0
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft(){} // RVA: 0x7EABB50
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight(){} // RVA: 0x7EABBB0
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale(){} // RVA: 0x7EABC10
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceTop(){} // RVA: 0x7EABC70
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceType(){} // RVA: 0x7EABCD0
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextAlign(){} // RVA: 0x7EABD30
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextGenerator(){} // RVA: 0x7EABD90
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor(){} // RVA: 0x7EABDF0
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth(){} // RVA: 0x7EABE70
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextOverflowPosition(){} // RVA: 0x7EABED0
        public void UnityEngine.UIElements.IResolvedStyle.get_visibility(){} // RVA: 0x7EABF30
        public void UnityEngine.UIElements.IResolvedStyle.get_whiteSpace(){} // RVA: 0x7EABF90
        public void UnityEngine.UIElements.IResolvedStyle.get_width(){} // RVA: 0x7EABFF0
        public void UnityEngine.UIElements.IResolvedStyle.get_wordSpacing(){} // RVA: 0x7EAC050
        public void get_hasRunningAnimations(){} // RVA: 0x7EAC0B0
        public void get_hasCompletedAnimations(){} // RVA: 0x7EAC110
        public void UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount(){} // RVA: 0xB9E080
        public void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(){} // RVA: 0xB9E090
        public void UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount(){} // RVA: 0xE9CE60
        public void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(){} // RVA: 0xEA1260
        public void GetStylePropertyAnimationSystem(){} // RVA: 0x7EAC170
        public void get_styleAnimation(){} // RVA: 0x2303260
        public void UnityEngine.UIElements.IStylePropertyAnimations.Start(){} // RVA: 0x7EAD600
        public void UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(){} // RVA: 0x7EAC670
        public void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(){} // RVA: 0x7EAD780
        public void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations(){} // RVA: 0x7EAD800
        public void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(){} // RVA: 0x7EAD900
        public void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(){} // RVA: 0x7EAD980
        public void TryConvertLengthUnits(){} // RVA: 0x7EADB00
        public void TryConvertTransformOriginUnits(){} // RVA: 0x7EADE00
        public void TryConvertTranslateUnits(){} // RVA: 0x7EADEB0
        public void TryConvertBackgroundSizeUnits(){} // RVA: 0x7EADF60
        public void GetParentSizeForLengthConversion(){} // RVA: 0x7EAE020
        public void get_isCompositeRoot(){} // RVA: 0x7EAE280
        public void set_isCompositeRoot(){} // RVA: 0x7EAE290
        public void get_areAncestorsAndSelfDisplayed(){} // RVA: 0x7EAE2C0
        public void set_areAncestorsAndSelfDisplayed(){} // RVA: 0x7EAE2D0
        public void get_viewDataKey(){} // RVA: 0xC0FFC0
        public void set_viewDataKey(){} // RVA: 0x7EAE350
        public void get_enableViewDataPersistence(){} // RVA: 0x7EAE490
        public void get_userData(){} // RVA: 0x7EAE4A0
        public void set_userData(){} // RVA: 0x7EAE550
        public void get_canGrabFocus(){} // RVA: 0x7EAE6A0
        public void get_focusController(){} // RVA: 0x7EAE790
        public void get_disablePlayModeTint(){} // RVA: 0x295D5B0
        public void set_disablePlayModeTint(){} // RVA: 0xB43310
        public void get_playModeTintColor(){} // RVA: 0x7EAE7E0
        public void get_usageHints(){} // RVA: 0x7EAE820
        public void set_usageHints(){} // RVA: 0x7EAE850
        public void get_renderHints(){} // RVA: 0x7CC0E00
        public void set_renderHints(){} // RVA: 0x7EAE940
        public void MarkRenderHintsClean(){} // RVA: 0x7EAE9B0
        public void get_transform(){} // RVA: 0x697DBA0
        public void UnityEngine.UIElements.ITransform.get_position(){} // RVA: 0x7EAE9C0
        public void UnityEngine.UIElements.ITransform.set_position(){} // RVA: 0x7EAEA50
        public void UnityEngine.UIElements.ITransform.get_scale(){} // RVA: 0x7EAEC00
        public void get_isLayoutManual(){} // RVA: 0x7EAECB0
        public void set_isLayoutManual(){} // RVA: 0x7EAECC0
        public void get_scaledPixelsPerPoint(){} // RVA: 0x7EAECF0
        public void get_scaledPixelsPerPoint_noChecks(){} // RVA: 0x7EAEDE0
        public void get_layout(){} // RVA: 0x7EAEE80
        public void set_layout(){} // RVA: 0x7EAEF70
        public void ClearManualLayout(){} // RVA: 0x7EAF680
        public void get_contentRect(){} // RVA: 0x7EAF8D0
        public void get_paddingRect(){} // RVA: 0x7EAFA70
        public void get_needs3DBounds(){} // RVA: 0x7EAFC10
        public void get_isLocalBounds3DDirty(){} // RVA: 0x7EAFC20
        public void set_isLocalBounds3DDirty(){} // RVA: 0x7EAFC30
        public void get_isBoundingBoxDirty(){} // RVA: 0x7EAFC60
        public void set_isBoundingBoxDirty(){} // RVA: 0x7EAFC70
        public void set_isWorldBoundingBoxDirty(){} // RVA: 0x7EAFCA0
        public void get_isWorldBoundingBoxOrDependenciesDirty(){} // RVA: 0x7EAFCD0
        public void get_boundingBox(){} // RVA: 0x7EAFCE0
        public void get_worldBoundingBox(){} // RVA: 0x7EAFD30
        public void get_boundingBoxInParentSpace(){} // RVA: 0x7EAFDF0
        public void UpdateBoundingBox(){} // RVA: 0x7EAFE40
        public void UpdateWorldBoundingBox(){} // RVA: 0x7EB0230
        public void get_localBounds3D(){} // RVA: 0x7EB02C0
        public void UpdateLocalBoundsAndPickingBounds3D(){} // RVA: 0x7EB0440
        public void get_worldBound(){} // RVA: 0x7EB0BC0
        public void get_localBound(){} // RVA: 0x7EB0CD0
        public void get_rect(){} // RVA: 0x7EB0D50
        public void get_isWorldTransformDirty(){} // RVA: 0x6741F40
        public void set_isWorldTransformDirty(){} // RVA: 0x752C760
        public void set_isWorldTransformInverseDirty(){} // RVA: 0x752C790
        public void get_isWorldTransformInverseOrDependenciesDirty(){} // RVA: 0x7EB0DB0
        public void get_worldTransform(){} // RVA: 0x7EB0DC0
        public void get_worldTransformRef(){} // RVA: 0x7EB0E30
        public void get_worldTransformInverse(){} // RVA: 0x7EB0E60
        public void UpdateWorldTransform(){} // RVA: 0x7EB0F10
        public void UpdateWorldTransformInverse(){} // RVA: 0x7EB1220
        public void get_isWorldClipDirty(){} // RVA: 0x7EB12C0
        public void set_isWorldClipDirty(){} // RVA: 0x7EB12D0
        public void get_worldClip(){} // RVA: 0x7EB1300
        public void get_worldClipMinusGroup(){} // RVA: 0x7EB1350
        public void get_worldClipIsInfinite(){} // RVA: 0x7EB13A0
        public void EnsureWorldTransformAndClipUpToDate(){} // RVA: 0x7EB13E0
        public void UpdateWorldClip(){} // RVA: 0x7EB1410
        public void CombineClipRects(){} // RVA: 0x7EB1860
        public void SubstractBorderPadding(){} // RVA: 0x7EB18F0
        public void ComputeAAAlignedBound(){} // RVA: 0x7EB1C90
        public void get_receivesHierarchyGeometryChangedEvents(){} // RVA: 0x7EB1EF0
        public void set_receivesHierarchyGeometryChangedEvents(){} // RVA: 0x7EB1F00
        public void get_boundingBoxDirtiedSinceLastLayoutPass(){} // RVA: 0x7EB1F30
        public void set_boundingBoxDirtiedSinceLastLayoutPass(){} // RVA: 0x7EB1F40
        public void get_pseudoStates(){} // RVA: 0x7EB1F70
        public void set_pseudoStates(){} // RVA: 0x7EB1F80
        public void get_containedPointerIds(){} // RVA: 0x6DE8E10
        public void set_containedPointerIds(){} // RVA: 0x7EB2000
        public void UpdateHoverPseudoState(){} // RVA: 0x7EB2010
        public void IsPartOfCapturedChain(){} // RVA: 0x7EB2120
        public void UpdateHoverPseudoStateAfterCaptureChange(){} // RVA: 0x7EB21F0
        public void get_pickingMode(){} // RVA: 0x7EB2290
        public void set_pickingMode(){} // RVA: 0x7EB22A0
        public void get_name(){} // RVA: 0x7C7DF30
        public void set_name(){} // RVA: 0x7EB2350
        public void get_classList(){} // RVA: 0x7EB2480
        public void get_fullTypeName(){} // RVA: 0x7EB2570
        public void get_typeName(){} // RVA: 0x7EB2620
        public void get_layoutNode(){} // RVA: 0x7EB2740
        public void get_computedStyle(){} // RVA: 0x7EB2750
        public void get_hasInlineStyle(){} // RVA: 0x7EB2760
        public void get_styleInitialized(){} // RVA: 0x7EB2770
        public void set_styleInitialized(){} // RVA: 0x7EB2780
        public void ChangeIMGUIContainerCount(){} // RVA: 0x7EB27B0
        public void .ctor(){} // RVA: 0x7EB27F0
        public void Finalize(){} // RVA: 0x7EB2F90
        public void GetTooltipRect(){} // RVA: 0x7EB3070
        public void SetTooltip(){} // RVA: 0x7EB30A0
        public void Focus(){} // RVA: 0x7EB31E0
        public void SetPanel(){} // RVA: 0x7EB33A0
        public void WillChangePanel(){} // RVA: 0x7EB4030
        public void HasChangedPanel(){} // RVA: 0x7EB4260
        public void SendEvent(){} // RVA: 0x7EB4710
        public void IncrementVersion(){} // RVA: 0x7EB4730
        public void InvokeHierarchyChanged(){} // RVA: 0x7EB4760
        public void SetEnabledFromHierarchyPrivate(){} // RVA: 0x7EB47B0
        public void get_isParentEnabledInHierarchy(){} // RVA: 0x7EB4C70
        public void get_enabledInHierarchy(){} // RVA: 0x7EB4CC0
        public void get_enabledSelf(){} // RVA: 0x7EB4CD0
        public void set_enabledSelf(){} // RVA: 0x7EB4CE0
        public void SetEnabled(){} // RVA: 0x7EB4D80
        public void PropagateEnabledToChildren(){} // RVA: 0x7EB4D90
        public void get_languageDirection(){} // RVA: 0x7EB4EA0
        public void set_languageDirection(){} // RVA: 0x7EB4EB0
        public void get_localLanguageDirection(){} // RVA: 0x7EB4F40
        public void set_localLanguageDirection(){} // RVA: 0x7EB4F50
        public void get_visible(){} // RVA: 0x7EB50A0
        public void set_visible(){} // RVA: 0x7EB5100
        public void MarkDirtyRepaint(){} // RVA: 0x7EB5280
        public void get_generateVisualContent(){} // RVA: 0x166BE90
        public void set_generateVisualContent(){} // RVA: 0x165B170
        public void InvokeGenerateVisualContent(){} // RVA: 0x7EB52B0
        public void GetFullHierarchicalViewDataKey(){} // RVA: 0x7EB54B0
        public void GetOrCreateViewData(){} // RVA: 0xA94080
        public void OverwriteFromViewData(){} // RVA: 0x7EB55A0
        public void SaveViewData(){} // RVA: 0x7EB57F0
        public void OnViewDataReady(){} // RVA: 0xB43310
        public void ContainsPoint(){} // RVA: 0x7EB5880
        public void get_requireMeasureFunction(){} // RVA: 0x7EB58E0
        public void set_requireMeasureFunction(){} // RVA: 0x7EB58F0
        public void AssignMeasureFunction(){} // RVA: 0x7EB5980
        public void RemoveMeasureFunction(){} // RVA: 0x7EB5A20
        public void DoMeasure(){} // RVA: 0x7EB5A60
        public void Measure(){} // RVA: 0x7EB5A80
        public void FinalizeLayout(){} // RVA: 0x7EB5C40
        public void SetInlineRule(){} // RVA: 0x7EB5CA0
        public void SetComputedStyle(){} // RVA: 0x7EB5D90
        public void ToString(){} // RVA: 0x7EB5FA0
        public void GetClassesForIteration(){} // RVA: 0x7C7DFA0
        public void AddToClassList(){} // RVA: 0x7EB6130
        public void RemoveFromClassList(){} // RVA: 0x7EB6340
        public void EnableInClassList(){} // RVA: 0x7EB64D0
        public void ClassListContains(){} // RVA: 0x7EB6500
        public void GetProperty(){} // RVA: 0x7EB6660
        public void SetProperty(){} // RVA: 0x7EB6700
        public void HasProperty(){} // RVA: 0x7EB6780
        public void ClearProperty(){} // RVA: 0x7EB6830
        public void CheckUserKeyArgument(){} // RVA: 0x7EB68C0
        public void SetPropertyInternal(){} // RVA: 0x7EB6A20
        public void UpdateCursorStyle(){} // RVA: 0x7EB6BD0
        public void get_subRenderTargetMode(){} // RVA: 0x7EB6FC0
        public void get_defaultMaterial(){} // RVA: 0x7EB6FD0
        public void GetAnimationSystem(){} // RVA: 0x7EB6FE0
        public void RegisterAnimation(){} // RVA: 0x7EB7090
        public void UnregisterAnimation(){} // RVA: 0x7EB7240
        public void UnregisterRunningAnimations(){} // RVA: 0x7EB7300
        public void RegisterRunningAnimations(){} // RVA: 0x7EB7390
        public void StartAnimation(){} // RVA: 0xA94080
        public void AssignStyleValues(){} // RVA: 0x7EB7400
        public void ReadCurrentValues(){} // RVA: 0x7EB8030
        public void UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(){} // RVA: 0x7EB9210
        public void Start(){} // RVA: 0x7EB93A0
        public void get_dataSource(){} // RVA: 0x165BD90
        public void set_dataSource(){} // RVA: 0x7EB95D0
        public void get_dataSourcePath(){} // RVA: 0x7EB96E0
        public void set_dataSourcePath(){} // RVA: 0x7EB9750
        public void TryGetBinding(){} // RVA: 0x7EB99B0
        public void ProcessBindingRequests(){} // RVA: 0x7EB9AF0
        public void CreateBindingRequests(){} // RVA: 0x7EB9C60
        public void TrackSource(){} // RVA: 0x7EB9D00
        public void DetachDataSource(){} // RVA: 0x7EB9DB0
        public void AttachDataSource(){} // RVA: 0x7EB9DE0
        public void DirtyNextParentWithEventInterests(){} // RVA: 0x7EB9E00
        public void SetAsNextParentWithEventInterests(){} // RVA: 0x7EB9E90
        public void GetCachedNextParentWithEventInterests(){} // RVA: 0x7EB9F70
        public void get_nextParentWithEventInterests(){} // RVA: 0x7EB9FF0
        public void PropagateCachedNextParentWithEventInterests(){} // RVA: 0x7EBA230
        public void AddEventCallbackCategories(){} // RVA: 0x7EBA2E0
        public void get_eventInterestParentCategories(){} // RVA: 0x7EBA300
        public void get_isEventInterestParentCategoriesDirty(){} // RVA: 0x7EBA3E0
        public void set_isEventInterestParentCategoriesDirty(){} // RVA: 0x7EBA3F0
        public void UpdateEventInterestSelfCategories(){} // RVA: 0x7EBA420
        public void UpdateEventInterestParentCategories(){} // RVA: 0x7EBA4C0
        public void HasParentEventInterests(){} // RVA: 0x7EBA5A0
        public void HasSelfEventInterests(){} // RVA: 0x7EBA5E0
        public void HasTrickleDownEventInterests(){} // RVA: 0x7EBA5F0
        public void HasBubbleUpEventInterests(){} // RVA: 0x7EBA610
        public void HasTrickleDownEventCallbacks(){} // RVA: 0x7EBA630
        public void HasBubbleUpEventCallbacks(){} // RVA: 0x7EBA640
        public void HasTrickleDownHandleEvent(){} // RVA: 0x7EBA650
        public void HasBubbleUpHandleEvent(){} // RVA: 0x7EBA660
        public void get_experimental(){} // RVA: 0x697DBA0
        public void UnityEngine.UIElements.IExperimentalFeatures.get_animation(){} // RVA: 0x697DBA0
        public void get_hierarchy(){} // RVA: 0x165EE00
        public void get_isRootVisualContainer(){} // RVA: 0x7EBA670
        public void set_isRootVisualContainer(){} // RVA: 0x7EBA680
        public void get_disableClipping(){} // RVA: 0x7EBA690
        public void set_disableClipping(){} // RVA: 0x7EBA6A0
        public void ShouldClip(){} // RVA: 0x7EBA6D0
        public void get_disableRendering(){} // RVA: 0x7EBA730
        public void set_disableRendering(){} // RVA: 0x7EBA740
        public void add_elementAdded(){} // RVA: 0x7EBA7A0
        public void remove_elementAdded(){} // RVA: 0x7EBA8C0
        public void add_elementRemoved(){} // RVA: 0x7EBA9E0
        public void remove_elementRemoved(){} // RVA: 0x7EBAB00
        public void get_parent(){} // RVA: 0x7EBAC20
        public void get_elementPanel(){} // RVA: 0x164A150
        public void set_elementPanel(){} // RVA: 0x163BCB0
        public void get_panel(){} // RVA: 0x7EBAC30
        public void get_contentContainer(){} // RVA: 0x697DBA0
        public void get_visualTreeAssetSource(){} // RVA: 0x1658FA0
        public void set_visualTreeAssetSource(){} // RVA: 0x1664380
        public void Add(){} // RVA: 0x7EBAC40
        public void Insert(){} // RVA: 0x7EBADA0
        public void Remove(){} // RVA: 0x7EBAE90
        public void Clear(){} // RVA: 0x7EBB050
        public void ElementAt(){} // RVA: 0x7EBB0D0
        public void get_Item(){} // RVA: 0x7EBB0E0
        public void get_childCount(){} // RVA: 0x7EBB1C0
        public void IndexOf(){} // RVA: 0x7EBB260
        public void ElementAtTreePath(){} // RVA: 0x7EBB350
        public void FindElementInTree(){} // RVA: 0x7EBB600
        public void Children(){} // RVA: 0x7EBB770
        public void BringToFront(){} // RVA: 0x7EBB840
        public void SendToBack(){} // RVA: 0x7EBB890
        public void PlaceBehind(){} // RVA: 0x7EBB8E0
        public void RemoveFromHierarchy(){} // RVA: 0x7EBB9F0
        public void GetFirstOfType(){} // RVA: 0xA94080
        public void GetFirstAncestorOfType(){} // RVA: 0xA94080
        public void GetFirstAncestorWhere(){} // RVA: 0x7EBBB10
        public void Contains(){} // RVA: 0x7EBBB90
        public void GatherAllChildren(){} // RVA: 0x7EBBBE0
        public void FindCommonAncestor(){} // RVA: 0x7EBBD10
        public void GetRoot(){} // RVA: 0x7EBBEA0
        public void GetRootVisualContainer(){} // RVA: 0x7EBBF30
        public void GetNextElementDepthFirst(){} // RVA: 0x7EBBF80
        public void GetPreviousElementDepthFirst(){} // RVA: 0x7EBC0C0
        public void RetargetElement(){} // RVA: 0x7EBC210
        public void get_positionWithLayout(){} // RVA: 0x7EBC2B0
        public void GetPivotedMatrixWithLayout(){} // RVA: 0x7EBC340
        public void get_hasDefaultRotationAndScale(){} // RVA: 0x7EBC7F0
        public void get_has3DTransform(){} // RVA: 0x7EBC920
        public void get_has3DTranslation(){} // RVA: 0x7EBCAB0
        public void get_has3DRotation(){} // RVA: 0x7EBCB10
        public void Min(){} // RVA: 0x7EBCC30
        public void Max(){} // RVA: 0x7EBCC40
        public void TransformAlignedBoundsToParentSpace(){} // RVA: 0x7EBCC50
        public void TransformAlignedRectToParentSpace(){} // RVA: 0x7EBCDE0
        public void CalculateConservativeRect(){} // RVA: 0x7EBCF20
        public void CalculateConservativeBounds(){} // RVA: 0x7EBD300
        public void TransformAlignedRect(){} // RVA: 0x7EBD890
        public void TransformAlignedBounds(){} // RVA: 0x7EBD910
        public void OrderMinMaxRect(){} // RVA: 0x7EBD9B0
        public void OrderMinMaxBounds(){} // RVA: 0x7EBDA00
        public void MultiplyMatrix44Point2(){} // RVA: 0x7EBDA40
        public void MultiplyVector2(){} // RVA: 0x7EBDA90
        public void MultiplyMatrix34(){} // RVA: 0x7EBDAD0
        public void TranslateMatrix34(){} // RVA: 0x7EBDD00
        public void TranslateMatrix34InPlace(){} // RVA: 0x7EBDE10
        public void get_schedule(){} // RVA: 0x697DBA0
        public void UnityEngine.UIElements.IVisualElementScheduler.Execute(){} // RVA: 0x7EBDFD0
        public void get_style(){} // RVA: 0x7EBE100
        public void get_resolvedStyle(){} // RVA: 0x7EBE1C0
        public void get_customStyle(){} // RVA: 0x7EBE2D0
        public void get_styleSheets(){} // RVA: 0x18D7680
        public void AddStyleSheetPath(){} // RVA: 0x7EBE3B0
        public void ResolveLengthValue(){} // RVA: 0x7EBE840
        public void ResolveTranslate(){} // RVA: 0x7EBE9B0
        public void ResolveTransformOrigin(){} // RVA: 0x7EBEB70
        public void ResolveRotation(){} // RVA: 0x7EBEDA0
        public void ResolveScale(){} // RVA: 0x7EBEF10
        public void get_tooltip(){} // RVA: 0x7EBF030
        public void set_tooltip(){} // RVA: 0x7EBF0C0
        public void get_typeData(){} // RVA: 0x7EBF320
        public void .cctor(){} // RVA: 0x7EBF5F0
        public void <CalculateConservativeBounds>g__IsNaN|732_0(){} // RVA: 0x7EC1280
    }

    public class VisualElementAnimationSystem : BaseVisualTreeUpdater
    {
        public object m_Animations;
        public object m_IterationList;
        public object m_HasNewAnimations;
        public object m_IterationListDirty;
        public object s_Description;
        public object s_ProfilerMarker;
        public object s_StylePropertyAnimationDescription;
        public object s_StylePropertyAnimationProfilerMarker;
        public object lastUpdate;

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7F31B90
        public void get_stylePropertyAnimationProfilerMarker(){} // RVA: 0x7F31BF0
        public void UnregisterAnimation(){} // RVA: 0x7F31C50
        public void UnregisterAnimations(){} // RVA: 0x7F31CB0
        public void RegisterAnimation(){} // RVA: 0x7F31E40
        public void RegisterAnimations(){} // RVA: 0x7F31EC0
        public void Update(){} // RVA: 0x7F32060
        public void OnVersionChanged(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x7F32530
        public void .cctor(){} // RVA: 0x7F32690
    }

    public class VisualElementAsset : UxmlAsset
    {
        public object m_Name;
        public object m_RuleIndex;
        public object m_Text;
        public object m_PickingMode;
        public object m_Classes;
        public object m_StylesheetPaths;
        public object m_Stylesheets;
        public object m_SerializedData;
        public object m_SkipClone;

        // ── Methods ──
        public void get_ruleIndex(){} // RVA: 0x4ED9D20
        public void get_classes(){} // RVA: 0x7C7E290
        public void get_stylesheetPaths(){} // RVA: 0x7F1F2E0
        public void get_hasStylesheetPaths(){} // RVA: 0x64D1440
        public void get_stylesheets(){} // RVA: 0x7F1F3A0
        public void get_hasStylesheets(){} // RVA: 0x64E5200
        public void get_serializedData(){} // RVA: 0xCD48B0
        public void get_skipClone(){} // RVA: 0x1C556E0
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void OnAfterDeserialize(){} // RVA: 0x7F1F460
        public void IdsPathMatchesAttributeOverrideIdsPath(){} // RVA: 0x7F1F5F0
        public void Instantiate(){} // RVA: 0x7F1F770
        public void ToString(){} // RVA: 0x7F1FF80
    }

    public class VisualElementAsset[] : Array
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

    public class VisualElementExtensions : Object
    {
        // ── Methods ──
        public void StretchToParentSize(){} // RVA: 0x7F2C7F0
        public void AddManipulator(){} // RVA: 0x7F2CA90
        public void RemoveManipulator(){} // RVA: 0x7F2CAF0
        public void WorldToLocal(){} // RVA: 0x7F2CD30
        public void LocalToWorld(){} // RVA: 0x7F2CC30
        public void ChangeCoordinatesTo(){} // RVA: 0x7F2CE20
    }

    public class VisualElementFactoryRegistry : Object
    {
        public object s_Factories;
        public object s_MovedTypesFactories;

        // ── Methods ──
        public void GetMovedUIControlTypeName(){} // RVA: 0x7F20050
        public void get_factories(){} // RVA: 0x7F20160
        public void RegisterFactory(){} // RVA: 0x7F203C0
        public void TryGetValue(){} // RVA: 0x7F20990
        public void RegisterEngineFactories(){} // RVA: 0x7F20A40
        public void RegisterUserFactories(){} // RVA: 0x7F22C70
    }

    public class VisualElementFocusChangeDirection : FocusChangeDirection
    {
        public object s_Left;
        public object s_Right;

        // ── Methods ──
        public void get_left(){} // RVA: 0x7F2E8C0
        public void get_right(){} // RVA: 0x7F2E920
        public void .ctor(){} // RVA: 0x7F2E980
        public void .cctor(){} // RVA: 0x7F2E9E0
    }

    public class VisualElementFocusChangeTarget : FocusChangeDirection
    {
        public object Pool;
        public object _target;

        // ── Methods ──
        public void GetPooled(){} // RVA: 0x7F2EC70
        public void Dispose(){} // RVA: 0x7F2ED90
        public void ApplyTo(){} // RVA: 0x7F2EE70
        public void .ctor(){} // RVA: 0x7F2EEC0
        public void get_target(){} // RVA: 0xB465B0
        public void set_target(){} // RVA: 0xBA9BA0
        public void .cctor(){} // RVA: 0x7F2EF70
    }

    public class VisualElementFocusRing : Object
    {
        public object root;
        public object _defaultFocusOrder;
        public object m_FocusRing;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F2F250
        public void get_focusController(){} // RVA: 0x10AE060
        public void get_defaultFocusOrder(){} // RVA: 0xE62D00
        public void set_defaultFocusOrder(){} // RVA: 0x1033F40
        public void FocusRingAutoIndexSort(){} // RVA: 0x7F2F380
        public void FocusRingSort(){} // RVA: 0x7F2F740
        public void DoUpdate(){} // RVA: 0x7F2F870
        public void BuildRingForScopeRecursive(){} // RVA: 0x7F2F960
        public void SortAndFlattenScopeLists(){} // RVA: 0x7F2FC90
        public void GetFocusableInternalIndex(){} // RVA: 0x7F2FF50
        public void GetFocusChangeDirection(){} // RVA: 0x7F30010
        public void GetNextFocusable(){} // RVA: 0x7F30510
        public void GetNextFocusableInTree(){} // RVA: 0x7F30B80
        public void GetPreviousFocusableInTree(){} // RVA: 0x7F30C20
    }

    public class VisualElementListPool : Object
    {
        public object pool;

        // ── Methods ──
        public void Copy(){} // RVA: 0x7F2C320
        public void Get(){} // RVA: 0x7F2C3F0
        public void Release(){} // RVA: 0x7F2C4D0
        public void .cctor(){} // RVA: 0x7F2C590
    }

    public class VisualElementStyleSheetSet : ValueType
    {
        public object m_Element;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x47F10
        public void Add(){} // RVA: 0x99BE80
        public void Insert(){} // RVA: 0x99BE90
        public void Remove(){} // RVA: 0x99BEA0
        public void get_count(){} // RVA: 0x99BEB0
        public void Equals(){} // RVA: 0x99BF50
        public void GetHashCode(){} // RVA: 0x995E30
    }

    public class VisualElementUtils : Object
    {
        public object s_usedNames;
        public object s_FoldoutType;
        public object s_InspectorElementUssClassName;

        // ── Methods ──
        public void GetUniqueName(){} // RVA: 0x7F313D0
        public void GetFoldoutDepth(){} // RVA: 0x7F31590
        public void AssignInspectorStyleIfNecessary(){} // RVA: 0x7F31670
        public void .cctor(){} // RVA: 0x7F31840
    }

    public class VisualElement[] : Array
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

    public class VisualTreeAsset : ScriptableObject
    {
        public object LinkedVEAInTemplatePropertyName;
        public object NoRegisteredFactoryErrorMessage;
        public object m_ImportedWithErrors;
        public object m_HasUpdatedUrls;
        public object m_ImportedWithWarnings;
        public object s_TemporarySlotInsertionPoints;
        public object s_VeaIdsPath;
        public object m_Usings;
        public object inlineSheet;
        public object m_VisualElementAssets;
        public object m_TemplateAssets;
        public object m_UxmlObjectEntries;
        public object m_UxmlObjectIds;
        public object m_AssetEntries;
        public object m_Slots;
        public object m_ContentContainerId;
        public object m_ContentHash;

        // ── Methods ──
        public void get_importedWithErrors(){} // RVA: 0x7B049C0
        public void set_importedWithErrors(){} // RVA: 0xB5DD60
        public void get_importerWithUpdatedUrls(){} // RVA: 0x7EE82D0
        public void set_importerWithUpdatedUrls(){} // RVA: 0x17F4D80
        public void get_importedWithWarnings(){} // RVA: 0x7F23070
        public void set_importedWithWarnings(){} // RVA: 0x246E8E0
        public void GetNextChildSerialNumber(){} // RVA: 0x7F23080
        public void get_usings(){} // RVA: 0xB700F0
        public void get_templateDependencies(){} // RVA: 0x7F23260
        public void get_stylesheets(){} // RVA: 0x7F23310
        public void get_visualElementAssets(){} // RVA: 0xD33E60
        public void get_templateAssets(){} // RVA: 0xD05CA0
        public void get_uxmlObjectEntries(){} // RVA: 0xBC1B30
        public void get_uxmlObjectIds(){} // RVA: 0xBBF8F0
        public void RemoveElementAndDependencies(){} // RVA: 0x7F233C0
        public void RegisterUxmlObject(){} // RVA: 0x7F23430
        public void AddUxmlObject(){} // RVA: 0x7F23630
        public void GetNextUxmlAssetId(){} // RVA: 0x7F23990
        public void RemoveUxmlObject(){} // RVA: 0x7F23A20
        public void RemoveUxmlObjectEntryDependencies(){} // RVA: 0x7F23C80
        public void CollectUxmlObjectAssets(){} // RVA: 0x7F245D0
        public void SetUxmlObjectAssets(){} // RVA: 0x7F248F0
        public void GetUxmlObjects(){} // RVA: 0x87C5F0
        public void AssetEntryExists(){} // RVA: 0x7F24CC0
        public void RegisterAssetEntry(){} // RVA: 0x7F24EE0
        public void TransferAssetEntries(){} // RVA: 0x7F24FA0
        public void GetAsset(){} // RVA: 0x7F25050
        public void GetAssetType(){} // RVA: 0x7F252D0
        public void GetUxmlObjectEntry(){} // RVA: 0x7F254B0
        public void GetUxmlObjectFactory(){} // RVA: 0x7F25630
        public void get_slots(){} // RVA: 0xC0FFC0
        public void get_contentContainerId(){} // RVA: 0x7CC0E00
        public void set_contentContainerId(){} // RVA: 0xD34740
        public void Instantiate(){} // RVA: 0x7F25D50
        public void CloneTree(){} // RVA: 0x7F260F0
        public void CloneSetupRecursively(){} // RVA: 0x7F26A20
        public void CompareForOrder(){} // RVA: 0x7F278B0
        public void TryGetSlotInsertionPoint(){} // RVA: 0x7F278F0
        public void TryGetUsingEntry(){} // RVA: 0x7F27A20
        public void RemoveUsingEntry(){} // RVA: 0x7F27C30
        public void ResolveTemplate(){} // RVA: 0x7F27CA0
        public void Create(){} // RVA: 0x7F27EC0
        public void AssignClassListFromAssetToElement(){} // RVA: 0x7F28690
        public void AssignStyleSheetFromAssetToElement(){} // RVA: 0x7F28720
        public void get_contentHash(){} // RVA: 0x7CC0E10
        public void set_contentHash(){} // RVA: 0xD346A0
        public void .ctor(){} // RVA: 0x7F289F0
        public void .cctor(){} // RVA: 0x7F28E40
        public void <Create>g__CreateError|82_0(){} // RVA: 0x7F290F0
    }

    public class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
    {
        public object s_BindingRequestObjectVEPropertyName;
        public object s_AdditionalBindingObjectVEPropertyName;
        public object s_Description;
        public object s_ProfilerMarker;
        public object s_ProfilerBindingRequestsMarker;
        public object s_MarkerUpdate;
        public object s_MarkerPoll;
        public object _disableBindingsThrottling;
        public object m_ElementsWithBindings;
        public object m_ElementsToAdd;
        public object m_ElementsToRemove;
        public object m_LastUpdateTime;
        public object m_ElementsToBind;
        public object _temporaryObjectCache;
        public object updatedBindings;

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7E78B80
        public void get_disableBindingsThrottling(){} // RVA: 0x7E78BE0
        public void GetBindingObjectFromElement(){} // RVA: 0x7E78C40
        public void StartTracking(){} // RVA: 0x7E78D70
        public void StopTracking(){} // RVA: 0x7E78E10
        public void get_temporaryObjectCache(){} // RVA: 0xBBFF90
        public void GetAdditionalBinding(){} // RVA: 0x7E78EB0
        public void StartTrackingRecursive(){} // RVA: 0x7E78F40
        public void StopTrackingRecursive(){} // RVA: 0x7E79120
        public void OnVersionChanged(){} // RVA: 0x7E792E0
        public void OnHierarchyChange(){} // RVA: 0x7E793F0
        public void CurrentTime(){} // RVA: 0x7E79420
        public void ShouldProcessBindings(){} // RVA: 0x7E79470
        public void PerformTrackingOperations(){} // RVA: 0x7E79570
        public void Update(){} // RVA: 0x7E798B0
        public void UpdateBindings(){} // RVA: 0x7E7A000
        public void Dispose(){} // RVA: 0x7E7A5B0
        public void .ctor(){} // RVA: 0x7E7A5C0
        public void .cctor(){} // RVA: 0x7E7A920
    }

    public class VisualTreeDataBindingsUpdater : BaseVisualTreeUpdater
    {
        public object s_UpdateProfilerMarker;
        public object s_ProcessBindingRequestsProfilerMarker;
        public object s_ProcessDataSourcesProfilerMarker;
        public object s_ShouldUpdateBindingProfilerMarker;
        public object s_UpdateBindingProfilerMarker;
        public object m_Updater;
        public object m_BindingRegistrationRequests;
        public object m_DataSourceChangedRequests;
        public object m_RemovedElements;
        public object m_BoundsElement;
        public object m_VersionChanges;
        public object m_TrackedObjects;
        public object m_RanUpdate;
        public object m_KnownSources;
        public object m_DirtyBindings;
        public object m_AttachedPanel;

        // ── Methods ──
        public void get_bindingManager(){} // RVA: 0x7E7AB30
        public void get_profilerMarker(){} // RVA: 0x7E7AB60
        public void .ctor(){} // RVA: 0x7E7ABC0
        public void OnHierarchyChange(){} // RVA: 0x7E7B160
        public void OnVersionChanged(){} // RVA: 0x7E7B570
        public void CacheAndLogBindingResult(){} // RVA: 0x7E7B620
        public void LogResult(){} // RVA: 0x7E7BBB0
        public void Update(){} // RVA: 0x7E7BD60
        public void GetDataSourceVersion(){} // RVA: 0x7E7D1F0
        public void IsPrefix(){} // RVA: 0x7E7D3E0
        public void ProcessDataSourceChangedRequests(){} // RVA: 0x7E7D630
        public void OnPanelChanged(){} // RVA: 0x7E7D950
        public void Dispose(){} // RVA: 0x7E7DA90
        public void ProcessAllBindingRequests(){} // RVA: 0x7E7DB50
        public void ProcessBindingRequests(){} // RVA: 0x7E7DD30
        public void ProcessPropertyChangedEvents(){} // RVA: 0x7E7DD80
        public void .cctor(){} // RVA: 0x7E7E630
    }

    public class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater
    {
        public object m_Version;
        public object m_LastVersion;
        public object s_Description;
        public object s_ProfilerMarker;

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7F32840
        public void OnVersionChanged(){} // RVA: 0x7F328A0
        public void GetChildrenMustDirtyFlags(){} // RVA: 0x7F32A10
        public void DirtyHierarchy(){} // RVA: 0x7F32A50
        public void DirtyBoundingBoxHierarchy(){} // RVA: 0x7F32BF0
        public void DirtyParentHierarchy(){} // RVA: 0x7F32C90
        public void Update(){} // RVA: 0x7F32CD0
        public void .ctor(){} // RVA: 0x7F32D40
        public void .cctor(){} // RVA: 0x7F32D50
    }

    public class VisualTreeStyleUpdater : BaseVisualTreeUpdater
    {
        public object m_ApplyStyleUpdateList;
        public object m_TransitionPropertyUpdateList;
        public object m_IsApplyingStyles;
        public object m_Version;
        public object m_LastVersion;
        public object m_StyleContextHierarchyTraversal;
        public object s_Description;
        public object s_ProfilerMarker;
        public object _disposed;

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7F34260
        public void OnVersionChanged(){} // RVA: 0x7F342C0
        public void Update(){} // RVA: 0x7F343A0
        public void get_disposed(){} // RVA: 0xC00EC0
        public void set_disposed(){} // RVA: 0xC00ED0
        public void Dispose(){} // RVA: 0x7F348B0
        public void ApplyStyles(){} // RVA: 0x7F348F0
        public void .ctor(){} // RVA: 0x7F34A40
        public void .cctor(){} // RVA: 0x7F34C00
    }

    public class VisualTreeStyleUpdaterTraversal : HierarchyTraversal
    {
        public object m_ProcessVarContext;
        public object m_UpdateList;
        public object m_ParentList;
        public object m_TempMatchResults;
        public object _currentPixelsPerPoint;
        public object m_StyleMatchingContext;
        public object m_StylePropertyReader;
        public object _currentPanel;
        public object m_AnimatedProperties;

        // ── Methods ──
        public void get_currentPixelsPerPoint(){} // RVA: 0xCD64A0
        public void set_currentPixelsPerPoint(){} // RVA: 0xD96F20
        public void get_currentPanel(){} // RVA: 0xBBF8F0
        public void set_currentPanel(){} // RVA: 0xBBF900
        public void PrepareTraversal(){} // RVA: 0x7F35260
        public void AddChangedElement(){} // RVA: 0x7F352C0
        public void Clear(){} // RVA: 0x7F353F0
        public void PropagateToChildren(){} // RVA: 0x7F35490
        public void PropagateToParents(){} // RVA: 0x7F35620
        public void OnProcessMatchResult(){} // RVA: 0x7F356D0
        public void TraverseRecursive(){} // RVA: 0x7F35710
        public void ProcessTransitions(){} // RVA: 0x7F36120
        public void ForceUpdateTransitions(){} // RVA: 0x7F36240
        public void CancelAnimationsWithNoTransitionProperty(){} // RVA: 0x7F36530
        public void ShouldSkipElement(){} // RVA: 0x7F36880
        public void ProcessMatchedRules(){} // RVA: 0x7F36910
        public void ProcessMatchedVariables(){} // RVA: 0x7F37B10
        public void .ctor(){} // RVA: 0x7F37BF0
    }

    public class VisualTreeUpdater : Object
    {
        public object m_Panel;
        public object m_UpdaterArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F381F0
        public void Dispose(){} // RVA: 0x7F38480
        public void UpdateVisualTreePhase(){} // RVA: 0x7F385B0
        public void OnVersionChanged(){} // RVA: 0x7F38780
        public void SetUpdater(){} // RVA: 0x8944F0
        public void GetUpdater(){} // RVA: 0x7F38990
        public void SetDefaultUpdaters(){} // RVA: 0x7F389D0
    }

    public class VisualTreeWorldSpaceHierarchyFlagsUpdater : VisualTreeHierarchyFlagsUpdater
    {
        // ── Methods ──
        public void OnVersionChanged(){} // RVA: 0x7F32E30
        public void GetParentMustDirtyFlags(){} // RVA: 0x7F331E0
        public void Update(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x7F33380
    }

}