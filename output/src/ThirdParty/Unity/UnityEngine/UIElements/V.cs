// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 30
// Methods: 560

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class ValidateCommandEvent : CommandEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B7D9F0
        public void .ctor(){} // RVA: 0x7FFAC9B7DAE0
    }

    public class Vector2Field : BaseCompositeField`3
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFAC9AA5690
        public void .ctor(){} // RVA: 0x7FFAC9AA5E00 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9AA5F40
    }

    public class Vector2IntField : BaseCompositeField`3
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFAC9AA9420
        public void .ctor(){} // RVA: 0x7FFAC9AA9B90 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9AA9CD0
    }

    public class Vector3Field : BaseCompositeField`3
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFAC9AA65F0
        public void .ctor(){} // RVA: 0x7FFAC9AA6F00 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9AA7040
    }

    public class Vector3IntField : BaseCompositeField`3
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFAC9AAA5D0
        public void .ctor(){} // RVA: 0x7FFAC9AAAEE0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9AAB020
    }

    public class Vector4Field : BaseCompositeField`3
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFAC9AA7A80
        public void .ctor(){} // RVA: 0x7FFAC9AA8760 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9AA88A0
    }

    public class VectorImage : ScriptableObject
    {
        public int width; // 0x18
        public UnityEngine.Texture2D height; // 0x20
        public UnityEngine.UIElements.VectorImageVertex[] vertices; // 0x28
        public ushort[] indices; // 0x30
        public UnityEngine.UIElements.GradientSettings[] settings; // 0x38
        public UnityEngine.Vector2 size; // 0x40

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFAC30E80B0
        public void get_height(){} // RVA: 0x7FFAC2F29970
        public void .ctor(){} // RVA: 0x7FFAC9ABD8B0
    }

    public class VectorImageVertex : ValueType
    {
        public UnityEngine.Vector3 position; // 0x10
        public UnityEngine.Color32 tint; // 0x1C
        public UnityEngine.Vector2 uv; // 0x20
        public uint settingIndex; // 0x28
        public UnityEngine.Color32 flags; // 0x2C
        public UnityEngine.Vector4 circle; // 0x30
    }

    public class Vertex : ValueType
    {
        public float nearZ;
        public UnityEngine.Vector3 position; // 0x10
        public UnityEngine.Color32 tint; // 0x1C
        public UnityEngine.Vector2 uv; // 0x20
        public UnityEngine.Color32 xformClipPages; // 0x28
        public UnityEngine.Color32 ids; // 0x2C
        public UnityEngine.Color32 flags; // 0x30
        public UnityEngine.Color32 opacityColorPages; // 0x34
        public UnityEngine.Color32 settingIndex; // 0x38
        public UnityEngine.Vector4 circle; // 0x3C
        public float textureId; // 0x4C
    }

    public class VerticalVirtualizationController`1 : CollectionVirtualizationController
    {
        public UnityEngine.Pool.ObjectPool`1<T> activeItems;
        public UnityEngine.UIElements.BaseVerticalCollectionView itemsCount;
        public System.Collections.Generic.List`1<T> firstVisibleItem;
        public T lastVisibleItem;
        public int visibleItemCount;
        public System.Collections.Generic.List`1<int> serializedData;
        public System.Func`2<T,bool> firstVisibleIndex;
        public System.Collections.Generic.List`1<T> lastHeight;
        public UnityEngine.UIElements.VisualElement alwaysRebindOnRefresh;

        // ── Methods ──
        public void get_activeItems(){} // RVA: 0x7FFAC2C58E90
        public void get_itemsCount(){} // RVA: 0x7FFAC2C59960
        public void VisibleItemPredicate(){} // RVA: 0x7FFAC2E8DC40
        public void get_firstVisibleItem(){} // RVA: 0x7FFAC2E8DC40
        public void get_lastVisibleItem(){} // RVA: 0x7FFAC2E8DC40
        public void get_visibleItemCount(){} // RVA: 0x7FFAC2C59960
        public void get_serializedData(){} // RVA: 0x7FFAC2C58E90
        public void get_firstVisibleIndex(){} // RVA: 0x7FFAC2C59960
        public void set_firstVisibleIndex(){} // RVA: 0x7FFAC2C70ED0
        public void get_lastHeight(){} // RVA: 0x7FFAC2C6D880
        public void get_alwaysRebindOnRefresh(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void Refresh(){} // RVA: 0x7FFAC2C71060
        public void Setup(){} // RVA: 0x7FFAC2E8DC40
        public void OnFocus(){} // RVA: 0x7FFAC2C70A40
        public void OnBlur(){} // RVA: 0x7FFAC2C70A40
        public void HandleFocus(){} // RVA: 0x7FFAC2C77970
        public void UpdateBackground(){} // RVA: 0x7FFAC2C70980
        public void StartDragItem(){} // RVA: 0x7FFAC2C70A40
        public void EndDrag(){} // RVA: 0x7FFAC2C70ED0
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7FFAC2E8DC40
        public void ReleaseItem(){} // RVA: 0x7FFAC2C70ED0
        public void OnDestroyItem(){} // RVA: 0x7FFAC2C70A40
        public void GetDraggedIndex(){} // RVA: 0x7FFAC2C59960
    }

    public class VisualData : ValueType
    {
        public UnityEngine.Color backgroundColor; // 0x10
        public UnityEngine.UIElements.Background backgroundImage; // 0x20
        public UnityEngine.UIElements.BackgroundPosition backgroundPositionX; // 0x40
        public UnityEngine.UIElements.BackgroundPosition backgroundPositionY; // 0x4C
        public UnityEngine.UIElements.BackgroundRepeat backgroundRepeat; // 0x58
        public UnityEngine.UIElements.BackgroundSize backgroundSize; // 0x60
        public UnityEngine.Color borderBottomColor; // 0x74
        public UnityEngine.UIElements.Length borderBottomLeftRadius; // 0x84
        public UnityEngine.UIElements.Length borderBottomRightRadius; // 0x8C
        public UnityEngine.Color borderLeftColor; // 0x94
        public UnityEngine.Color borderRightColor; // 0xA4
        public UnityEngine.Color borderTopColor; // 0xB4
        public UnityEngine.UIElements.Length borderTopLeftRadius; // 0xC4
        public UnityEngine.UIElements.Length borderTopRightRadius; // 0xCC
        public float opacity; // 0xD4
        public 0x6B122708 overflow; // 0xD8

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFAC9BF6360
        public void CopyFrom(){} // RVA: 0x7FFAC9BFA8F0
        public void op_Equality(){} // RVA: 0x7FFAC9BFAA40
        public void Equals(){} // RVA: 0x7FFAC9BFC010 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFC140
    }

    public class VisualElement : Focusable
    {
        public int resolvedStyle; // 0x30
        public int UnityEngine.UIElements.IResolvedStyle.backgroundColor; // 0x34
        public uint UnityEngine.UIElements.IResolvedStyle.borderBottomColor;
        public System.Collections.Generic.List`1<string> UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius; // 0x8
        public UnityEngine.PropertyName UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius; // 0x10
        public string UnityEngine.UIElements.IResolvedStyle.borderBottomWidth; // 0x18
        public string UnityEngine.UIElements.IResolvedStyle.borderLeftColor; // 0x38
        public System.Collections.Generic.List`1<string> UnityEngine.UIElements.IResolvedStyle.borderLeftWidth; // 0x40
        public System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<UnityEngine.PropertyName,object>> UnityEngine.UIElements.IResolvedStyle.borderRightColor; // 0x48
        public 0x6B1266A0 UnityEngine.UIElements.IResolvedStyle.borderRightWidth; // 0x50
        public string UnityEngine.UIElements.IResolvedStyle.borderTopColor; // 0x58
        public 0x6B11FFD8 UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius; // 0x60
        public UnityEngine.Rect UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius; // 0x64
        public UnityEngine.Rect UnityEngine.UIElements.IResolvedStyle.borderTopWidth; // 0x74
        public UnityEngine.UIElements.UIR.RenderChainVEData UnityEngine.UIElements.IResolvedStyle.bottom; // 0x88
        public UnityEngine.Rect UnityEngine.UIElements.IResolvedStyle.color; // 0x1D0
        public UnityEngine.Rect UnityEngine.UIElements.IResolvedStyle.display; // 0x1E0
        public 0x6B1266A0 UnityEngine.UIElements.IResolvedStyle.flexDirection;
        public UnityEngine.Rect UnityEngine.UIElements.IResolvedStyle.flexGrow; // 0x1F0
        public 0x6B1266A0 UnityEngine.UIElements.IResolvedStyle.flexShrink;
        public UnityEngine.Matrix4x4 UnityEngine.UIElements.IResolvedStyle.height; // 0x200
        public UnityEngine.Matrix4x4 UnityEngine.UIElements.IResolvedStyle.left; // 0x240
        public UnityEngine.Rect UnityEngine.UIElements.IResolvedStyle.marginBottom; // 0x280
        public UnityEngine.Rect UnityEngine.UIElements.IResolvedStyle.marginLeft; // 0x290
        public bool UnityEngine.UIElements.IResolvedStyle.marginRight; // 0x2A0
        public UnityEngine.Rect UnityEngine.UIElements.IResolvedStyle.marginTop; // 0x20
        public 0x6B126648 UnityEngine.UIElements.IResolvedStyle.minHeight; // 0x2A4
        public 0x6B126648 UnityEngine.UIElements.IResolvedStyle.minWidth; // 0x2A8
        public 0x6B126648 UnityEngine.UIElements.IResolvedStyle.opacity; // 0x2AC
        public int UnityEngine.UIElements.IResolvedStyle.paddingBottom; // 0x2B0
        public 0x6B1266F8 UnityEngine.UIElements.IResolvedStyle.paddingLeft; // 0x2B4
        public UnityEngine.Yoga.YogaNode UnityEngine.UIElements.IResolvedStyle.paddingRight; // 0x2B8
        public UnityEngine.UIElements.ComputedStyle UnityEngine.UIElements.IResolvedStyle.paddingTop; // 0x2C0
        public UnityEngine.UIElements.StyleVariableContext UnityEngine.UIElements.IResolvedStyle.right; // 0x318
        public int UnityEngine.UIElements.IResolvedStyle.scale; // 0x320
        public uint UnityEngine.UIElements.IResolvedStyle.top; // 0x324
        public int UnityEngine.UIElements.IResolvedStyle.transformOrigin; // 0x328
        public bool UnityEngine.UIElements.IResolvedStyle.translate; // 0x32C
        public 0x6B126750 UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor; // 0x330
        public 0x6B126750 UnityEngine.UIElements.IResolvedStyle.unitySliceLeft; // 0x334
        public System.Action`1<UnityEngine.UIElements.MeshGenerationContext> UnityEngine.UIElements.IResolvedStyle.unitySliceRight; // 0x338
        public Unity.Profiling.ProfilerMarker UnityEngine.UIElements.IResolvedStyle.unitySliceScale; // 0x30
        public 0x6B121688 UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor; // 0x340
        public UnityEngine.Material UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth; // 0x38
        public UnityEngine.Material UnityEngine.UIElements.IResolvedStyle.visibility; // 0x348
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> UnityEngine.UIElements.IResolvedStyle.width; // 0x350
        public uint hasRunningAnimations; // 0x40
        public uint hasCompletedAnimations; // 0x358
        public uint UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount; // 0x35C
        public UnityEngine.UIElements.VisualElement UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount; // 0x360
        public int styleAnimation; // 0x368
        public int isCompositeRoot; // 0x36C
        public int isHierarchyDisplayed; // 0x370
        public int viewDataKey; // 0x374
        public string enableViewDataPersistence;
        public Hierarchy userData; // 0x378
        public bool canGrabFocus; // 0x380
        public bool focusController; // 0x381
        public UnityEngine.UIElements.VisualElement usageHints; // 0x388
        public UnityEngine.UIElements.VisualElement renderHints; // 0x390
        public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement> transform; // 0x48
        public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement> UnityEngine.UIElements.ITransform.position; // 0x398
        public UnityEngine.UIElements.BaseVisualElementPanel UnityEngine.UIElements.ITransform.scale; // 0x3A0
        public UnityEngine.UIElements.VisualTreeAsset isLayoutManual; // 0x3A8
        public CustomStyleAccess scaledPixelsPerPoint; // 0x50
        public UnityEngine.UIElements.InlineStyleAccess layout; // 0x3B0
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet> contentRect; // 0x3B8
        public System.Text.RegularExpressions.Regex paddingRect; // 0x58
        public UnityEngine.PropertyName isBoundingBoxDirty; // 0x60
        public System.Collections.Generic.Dictionary`2<System.Type,TypeData> isWorldBoundingBoxDirty; // 0x68
        public TypeData isWorldBoundingBoxOrDependenciesDirty; // 0x3C0

        // ── Methods ──
        public void get_resolvedStyle(){} // RVA: 0x7FFAC44F81E0
        public void UnityEngine.UIElements.IResolvedStyle.get_backgroundColor(){} // RVA: 0x7FFAC9BDEBD0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor(){} // RVA: 0x7FFAC9BDEC30
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius(){} // RVA: 0x7FFAC9BDEC90
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius(){} // RVA: 0x7FFAC9BDECF0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth(){} // RVA: 0x7FFAC9BDED50
        public void UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor(){} // RVA: 0x7FFAC9BDEDC0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth(){} // RVA: 0x7FFAC9BDEE20
        public void UnityEngine.UIElements.IResolvedStyle.get_borderRightColor(){} // RVA: 0x7FFAC9BDEE90
        public void UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth(){} // RVA: 0x7FFAC9BDEEF0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopColor(){} // RVA: 0x7FFAC9BDEF60
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius(){} // RVA: 0x7FFAC9BDEFC0
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius(){} // RVA: 0x7FFAC9BDF020
        public void UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth(){} // RVA: 0x7FFAC9BDF080
        public void UnityEngine.UIElements.IResolvedStyle.get_bottom(){} // RVA: 0x7FFAC9BDF0F0
        public void UnityEngine.UIElements.IResolvedStyle.get_color(){} // RVA: 0x7FFAC9BDF160
        public void UnityEngine.UIElements.IResolvedStyle.get_display(){} // RVA: 0x7FFAC9BDF1C0
        public void UnityEngine.UIElements.IResolvedStyle.get_flexDirection(){} // RVA: 0x7FFAC9BDF210
        public void UnityEngine.UIElements.IResolvedStyle.get_flexGrow(){} // RVA: 0x7FFAC9BDF260
        public void UnityEngine.UIElements.IResolvedStyle.get_flexShrink(){} // RVA: 0x7FFAC9BDF2B0
        public void UnityEngine.UIElements.IResolvedStyle.get_height(){} // RVA: 0x7FFAC9BDF300
        public void UnityEngine.UIElements.IResolvedStyle.get_left(){} // RVA: 0x7FFAC9BDF370
        public void UnityEngine.UIElements.IResolvedStyle.get_marginBottom(){} // RVA: 0x7FFAC9BDF3E0
        public void UnityEngine.UIElements.IResolvedStyle.get_marginLeft(){} // RVA: 0x7FFAC9BDF450
        public void UnityEngine.UIElements.IResolvedStyle.get_marginRight(){} // RVA: 0x7FFAC9BDF4C0
        public void UnityEngine.UIElements.IResolvedStyle.get_marginTop(){} // RVA: 0x7FFAC9BDF530
        public void UnityEngine.UIElements.IResolvedStyle.get_minHeight(){} // RVA: 0x7FFAC9BDF5A0
        public void UnityEngine.UIElements.IResolvedStyle.get_minWidth(){} // RVA: 0x7FFAC9BDF600
        public void UnityEngine.UIElements.IResolvedStyle.get_opacity(){} // RVA: 0x7FFAC9BDF660
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingBottom(){} // RVA: 0x7FFAC9BDF6B0
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingLeft(){} // RVA: 0x7FFAC9BDF720
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingRight(){} // RVA: 0x7FFAC9BDF790
        public void UnityEngine.UIElements.IResolvedStyle.get_paddingTop(){} // RVA: 0x7FFAC9BDF800
        public void UnityEngine.UIElements.IResolvedStyle.get_right(){} // RVA: 0x7FFAC9BDF870
        public void UnityEngine.UIElements.IResolvedStyle.get_scale(){} // RVA: 0x7FFAC9BDF8E0
        public void UnityEngine.UIElements.IResolvedStyle.get_top(){} // RVA: 0x7FFAC9BDF940
        public void UnityEngine.UIElements.IResolvedStyle.get_transformOrigin(){} // RVA: 0x7FFAC9BDF9B0
        public void UnityEngine.UIElements.IResolvedStyle.get_translate(){} // RVA: 0x7FFAC9BDF9E0
        public void UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor(){} // RVA: 0x7FFAC9BDFA10
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft(){} // RVA: 0x7FFAC9BDFA70
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight(){} // RVA: 0x7FFAC9BDFAC0
        public void UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale(){} // RVA: 0x7FFAC9BDFB10
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor(){} // RVA: 0x7FFAC9BDFB60
        public void UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth(){} // RVA: 0x7FFAC9BDFBC0
        public void UnityEngine.UIElements.IResolvedStyle.get_visibility(){} // RVA: 0x7FFAC9BDFC10
        public void UnityEngine.UIElements.IResolvedStyle.get_width(){} // RVA: 0x7FFAC9BDFC60
        public void get_hasRunningAnimations(){} // RVA: 0x7FFAC9BDFCD0
        public void get_hasCompletedAnimations(){} // RVA: 0x7FFAC9BDFD30
        public void UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount(){} // RVA: 0x7FFAC2F7CCD0
        public void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(){} // RVA: 0x7FFAC2F7CCE0
        public void UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount(){} // RVA: 0x7FFAC3ADEDC0
        public void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(){} // RVA: 0x7FFAC416A6E0
        public void GetStylePropertyAnimationSystem(){} // RVA: 0x7FFAC9BDFD90
        public void get_styleAnimation(){} // RVA: 0x7FFAC44F81E0
        public void UnityEngine.UIElements.IStylePropertyAnimations.Start(){} // RVA: 0x7FFAC9BE1220 | overloaded x15
        public void UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(){} // RVA: 0x7FFAC9BE0290
        public void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(){} // RVA: 0x7FFAC9BE13A0
        public void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations(){} // RVA: 0x7FFAC9BE1420
        public void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(){} // RVA: 0x7FFAC9BE1520
        public void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(){} // RVA: 0x7FFAC9BE15A0
        public void TryConvertLengthUnits(){} // RVA: 0x7FFAC9BE1720
        public void TryConvertTransformOriginUnits(){} // RVA: 0x7FFAC9BE1A20
        public void TryConvertTranslateUnits(){} // RVA: 0x7FFAC9BE1AD0
        public void TryConvertBackgroundSizeUnits(){} // RVA: 0x7FFAC9BE1B80
        public void GetParentSizeForLengthConversion(){} // RVA: 0x7FFAC9BE1C40
        public void get_isCompositeRoot(){} // RVA: 0x7FFAC9BE1E80
        public void set_isCompositeRoot(){} // RVA: 0x7FFAC9BE1E90
        public void get_isHierarchyDisplayed(){} // RVA: 0x7FFAC9BE1ED0
        public void set_isHierarchyDisplayed(){} // RVA: 0x7FFAC9BE1EE0
        public void get_viewDataKey(){} // RVA: 0x7FFAC2FE9500
        public void set_viewDataKey(){} // RVA: 0x7FFAC9BE1F10
        public void get_enableViewDataPersistence(){} // RVA: 0x7FFAC9BE1FE0
        public void set_enableViewDataPersistence(){} // RVA: 0x7FFAC9BE1FF0
        public void get_userData(){} // RVA: 0x7FFAC9BE2020
        public void set_userData(){} // RVA: 0x7FFAC9BE20A0
        public void get_canGrabFocus(){} // RVA: 0x7FFAC9BE2120
        public void get_focusController(){} // RVA: 0x7FFAC9BE2220
        public void get_usageHints(){} // RVA: 0x7FFAC9BE2270
        public void set_usageHints(){} // RVA: 0x7FFAC9BE2290
        public void get_renderHints(){} // RVA: 0x7FFAC9950330
        public void set_renderHints(){} // RVA: 0x7FFAC9BE2320
        public void MarkRenderHintsClean(){} // RVA: 0x7FFAC9BE2390
        public void get_transform(){} // RVA: 0x7FFAC869D800
        public void UnityEngine.UIElements.ITransform.get_position(){} // RVA: 0x7FFAC9BE23A0
        public void UnityEngine.UIElements.ITransform.set_position(){} // RVA: 0x7FFAC9BE2420
        public void UnityEngine.UIElements.ITransform.get_scale(){} // RVA: 0x7FFAC9BE2630
        public void get_isLayoutManual(){} // RVA: 0x7FFAC9BE26B0
        public void set_isLayoutManual(){} // RVA: 0x7FFAC9BE26C0
        public void get_scaledPixelsPerPoint(){} // RVA: 0x7FFAC9BE26F0
        public void get_layout(){} // RVA: 0x7FFAC9BE2790
        public void set_layout(){} // RVA: 0x7FFAC9BE2970
        public void ClearManualLayout(){} // RVA: 0x7FFAC9BE3120
        public void get_contentRect(){} // RVA: 0x7FFAC9BE3390
        public void get_paddingRect(){} // RVA: 0x7FFAC9BE3620
        public void get_isBoundingBoxDirty(){} // RVA: 0x7FFAC9BE3780
        public void set_isBoundingBoxDirty(){} // RVA: 0x7FFAC9BE3790
        public void set_isWorldBoundingBoxDirty(){} // RVA: 0x7FFAC9BE37C0
        public void get_isWorldBoundingBoxOrDependenciesDirty(){} // RVA: 0x7FFAC9BE37F0
        public void get_boundingBox(){} // RVA: 0x7FFAC9BE3800
        public void get_worldBoundingBox(){} // RVA: 0x7FFAC9BE3850
        public void get_boundingBoxInParentSpace(){} // RVA: 0x7FFAC9BE3920
        public void UpdateBoundingBox(){} // RVA: 0x7FFAC9BE3970
        public void UpdateWorldBoundingBox(){} // RVA: 0x7FFAC9BE3CD0
        public void get_worldBound(){} // RVA: 0x7FFAC9BE3D70
        public void get_localBound(){} // RVA: 0x7FFAC9BE3E70
        public void get_rect(){} // RVA: 0x7FFAC9BE3EF0
        public void get_isWorldTransformDirty(){} // RVA: 0x7FFAC9BE3F50
        public void set_isWorldTransformDirty(){} // RVA: 0x7FFAC925EBE0
        public void set_isWorldTransformInverseDirty(){} // RVA: 0x7FFAC925EC10
        public void get_isWorldTransformInverseOrDependenciesDirty(){} // RVA: 0x7FFAC9BE3F60
        public void get_worldTransform(){} // RVA: 0x7FFAC9BE3F70
        public void get_worldTransformRef(){} // RVA: 0x7FFAC9BE3FE0
        public void get_worldTransformInverse(){} // RVA: 0x7FFAC9BE4010
        public void UpdateWorldTransform(){} // RVA: 0x7FFAC9BE40C0
        public void UpdateWorldTransformInverse(){} // RVA: 0x7FFAC9BE43D0
        public void get_isWorldClipDirty(){} // RVA: 0x7FFAC9BE4480
        public void set_isWorldClipDirty(){} // RVA: 0x7FFAC9BE4490
        public void get_worldClip(){} // RVA: 0x7FFAC9BE44C0
        public void get_worldClipMinusGroup(){} // RVA: 0x7FFAC9BE4510
        public void get_worldClipIsInfinite(){} // RVA: 0x7FFAC9BE4560
        public void EnsureWorldTransformAndClipUpToDate(){} // RVA: 0x7FFAC9BE45A0
        public void UpdateWorldClip(){} // RVA: 0x7FFAC9BE45E0
        public void CombineClipRects(){} // RVA: 0x7FFAC9BE4A30
        public void SubstractBorderPadding(){} // RVA: 0x7FFAC9BE4AC0
        public void ComputeAAAlignedBound(){} // RVA: 0x7FFAC9BE4D80
        public void get_pseudoStates(){} // RVA: 0x7FFAC9BE4FE0
        public void set_pseudoStates(){} // RVA: 0x7FFAC9BE4FF0
        public void get_containedPointerIds(){} // RVA: 0x7FFAC8B12F30
        public void set_containedPointerIds(){} // RVA: 0x7FFAC8B12F40
        public void UpdateHoverPseudoState(){} // RVA: 0x7FFAC9BE5080
        public void IsPartOfCapturedChain(){} // RVA: 0x7FFAC9BE5190
        public void get_pickingMode(){} // RVA: 0x7FFAC8B12F50
        public void set_pickingMode(){} // RVA: 0x7FFAC9BE5260
        public void get_name(){} // RVA: 0x7FFAC991F6C0
        public void set_name(){} // RVA: 0x7FFAC9BE52B0
        public void get_classList(){} // RVA: 0x7FFAC9BE5380
        public void get_fullTypeName(){} // RVA: 0x7FFAC9BE5480
        public void get_typeName(){} // RVA: 0x7FFAC9BE5530
        public void get_yogaNode(){} // RVA: 0x7FFAC39BA5E0
        public void set_yogaNode(){} // RVA: 0x7FFAC39CA820
        public void get_computedStyle(){} // RVA: 0x7FFAC9BE5560
        public void get_hasInlineStyle(){} // RVA: 0x7FFAC9BE5570
        public void get_styleInitialized(){} // RVA: 0x7FFAC9BE5580
        public void set_styleInitialized(){} // RVA: 0x7FFAC9BE5590
        public void ChangeIMGUIContainerCount(){} // RVA: 0x7FFAC9BE55C0
        public void .ctor(){} // RVA: 0x7FFAC9BE5600
        public void ExecuteDefaultAction(){} // RVA: 0x7FFAC9BE5CA0
        public void GetTooltipRect(){} // RVA: 0x7FFAC9BE64E0
        public void SetTooltip(){} // RVA: 0x7FFAC9BE6510
        public void Focus(){} // RVA: 0x7FFAC9BE6680
        public void SetPanel(){} // RVA: 0x7FFAC9BE6820
        public void WillChangePanel(){} // RVA: 0x7FFAC9BE73D0
        public void HasChangedPanel(){} // RVA: 0x7FFAC9BE7560
        public void SendEvent(){} // RVA: 0x7FFAC9BE7870 | overloaded x2
        public void IncrementVersion(){} // RVA: 0x7FFAC9BE7890
        public void InvokeHierarchyChanged(){} // RVA: 0x7FFAC9BE78C0
        public void SetEnabledFromHierarchyPrivate(){} // RVA: 0x7FFAC9BE7900
        public void get_isParentEnabledInHierarchy(){} // RVA: 0x7FFAC9BE7DC0
        public void get_enabledInHierarchy(){} // RVA: 0x7FFAC9BE7E00
        public void get_enabledSelf(){} // RVA: 0x7FFAC9BE7E10
        public void set_enabledSelf(){} // RVA: 0x7FFAC9BE7E20
        public void SetEnabled(){} // RVA: 0x7FFAC9BE7E30
        public void PropagateEnabledToChildren(){} // RVA: 0x7FFAC9BE7E50
        public void get_languageDirection(){} // RVA: 0x7FFAC97695A0
        public void get_localLanguageDirection(){} // RVA: 0x7FFAC97695E0
        public void set_localLanguageDirection(){} // RVA: 0x7FFAC9BE7F30
        public void get_visible(){} // RVA: 0x7FFAC9BE8060
        public void set_visible(){} // RVA: 0x7FFAC9BE80C0
        public void MarkDirtyRepaint(){} // RVA: 0x7FFAC9BE8140
        public void get_generateVisualContent(){} // RVA: 0x7FFAC3A12A20
        public void set_generateVisualContent(){} // RVA: 0x7FFAC9BE8170
        public void InvokeGenerateVisualContent(){} // RVA: 0x7FFAC9BE81D0
        public void GetFullHierarchicalViewDataKey(){} // RVA: 0x7FFAC9BE83D0 | overloaded x2
        public void GetOrCreateViewData(){} // RVA: 0x7FFAC2E8DC40
        public void OverwriteFromViewData(){} // RVA: 0x7FFAC9BE84C0
        public void SaveViewData(){} // RVA: 0x7FFAC9BE8720
        public void IsViewDataPersitenceSupportedOnChildren(){} // RVA: 0x7FFAC9BE87B0
        public void OnViewDataReady(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void ContainsPoint(){} // RVA: 0x7FFAC9BE88B0
        public void get_requireMeasureFunction(){} // RVA: 0x7FFAC9BE8910
        public void set_requireMeasureFunction(){} // RVA: 0x7FFAC9BE8920
        public void AssignMeasureFunction(){} // RVA: 0x7FFAC9BE8990
        public void RemoveMeasureFunction(){} // RVA: 0x7FFAC9BE8A30
        public void DoMeasure(){} // RVA: 0x7FFAC9BE8A60
        public void Measure(){} // RVA: 0x7FFAC9BE8A80
        public void FinalizeLayout(){} // RVA: 0x7FFAC9BE8BE0
        public void SetInlineRule(){} // RVA: 0x7FFAC9BE8CC0
        public void SetComputedStyle(){} // RVA: 0x7FFAC9BE8DB0
        public void ToString(){} // RVA: 0x7FFAC9BE9040
        public void GetClassesForIteration(){} // RVA: 0x7FFAC991F730
        public void AddToClassList(){} // RVA: 0x7FFAC9BE91D0
        public void RemoveFromClassList(){} // RVA: 0x7FFAC9BE93F0
        public void EnableInClassList(){} // RVA: 0x7FFAC9BE9580
        public void ClassListContains(){} // RVA: 0x7FFAC9BE95B0
        public void GetProperty(){} // RVA: 0x7FFAC9BE9710
        public void SetProperty(){} // RVA: 0x7FFAC9BE9790
        public void HasProperty(){} // RVA: 0x7FFAC9BE9810
        public void TryGetPropertyInternal(){} // RVA: 0x7FFAC9BE9890
        public void CheckUserKeyArgument(){} // RVA: 0x7FFAC9BE9A00
        public void SetPropertyInternal(){} // RVA: 0x7FFAC9BE9B60
        public void UpdateCursorStyle(){} // RVA: 0x7FFAC9BE9EA0
        public void get_subRenderTargetMode(){} // RVA: 0x7FFAC9BEA2B0
        public void get_defaultMaterial(){} // RVA: 0x7FFAC9BEA2C0
        public void GetAnimationSystem(){} // RVA: 0x7FFAC9BEA2D0
        public void RegisterAnimation(){} // RVA: 0x7FFAC9BEA380
        public void UnregisterAnimation(){} // RVA: 0x7FFAC9BEA530
        public void UnregisterRunningAnimations(){} // RVA: 0x7FFAC9BEA5F0
        public void RegisterRunningAnimations(){} // RVA: 0x7FFAC9BEA680
        public void StartAnimation(){} // RVA: 0x7FFAC2E8DC40
        public void AssignStyleValues(){} // RVA: 0x7FFAC9BEA6F0
        public void ReadCurrentValues(){} // RVA: 0x7FFAC9BEB400
        public void UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(){} // RVA: 0x7FFAC9BEC410
        public void Start(){} // RVA: 0x7FFAC9BEC5A0
        public void DirtyNextParentWithEventCallback(){} // RVA: 0x7FFAC9BEC7D0
        public void SetAsNextParentWithEventCallback(){} // RVA: 0x7FFAC9BEC860
        public void GetCachedNextParentWithEventCallback(){} // RVA: 0x7FFAC9BEC930
        public void get_nextParentWithEventCallback(){} // RVA: 0x7FFAC9BEC9B0
        public void PropagateCachedNextParentWithEventCallback(){} // RVA: 0x7FFAC9BECBF0
        public void get_eventCallbackCategories(){} // RVA: 0x7FFAC9BECCA0
        public void set_eventCallbackCategories(){} // RVA: 0x7FFAC9BECCB0
        public void get_eventCallbackParentCategories(){} // RVA: 0x7FFAC9BECD30
        public void get_isEventCallbackParentCategoriesDirty(){} // RVA: 0x7FFAC9BECE30
        public void set_isEventCallbackParentCategoriesDirty(){} // RVA: 0x7FFAC9BECE40
        public void UpdateCallbackParentCategories(){} // RVA: 0x7FFAC9BECE70
        public void HasEventCallbacks(){} // RVA: 0x7FFAC9BECF40
        public void HasParentEventCallbacksOrDefaultActions(){} // RVA: 0x7FFAC9BECF60
        public void HasEventCallbacksOrDefaultActions(){} // RVA: 0x7FFAC9BECFB0
        public void HasParentEventCallbacksOrDefaultActionAtTarget(){} // RVA: 0x7FFAC9BECFE0
        public void HasEventCallbacksOrDefaultActionAtTarget(){} // RVA: 0x7FFAC9BED020
        public void HasDefaultAction(){} // RVA: 0x7FFAC9BED050
        public void get_experimental(){} // RVA: 0x7FFAC869D800
        public void UnityEngine.UIElements.IExperimentalFeatures.get_animation(){} // RVA: 0x7FFAC869D800
        public void get_hierarchy(){} // RVA: 0x7FFAC39A7A10
        public void set_hierarchy(){} // RVA: 0x7FFAC39CF030
        public void get_isRootVisualContainer(){} // RVA: 0x7FFAC9BED070
        public void set_isRootVisualContainer(){} // RVA: 0x7FFAC9BED080
        public void get_disableClipping(){} // RVA: 0x7FFAC9BED090
        public void set_disableClipping(){} // RVA: 0x7FFAC9BED0A0
        public void ShouldClip(){} // RVA: 0x7FFAC9BED0D0
        public void get_parent(){} // RVA: 0x7FFAC9BED130
        public void get_elementPanel(){} // RVA: 0x7FFAC39BD300
        public void set_elementPanel(){} // RVA: 0x7FFAC39AF580
        public void get_panel(){} // RVA: 0x7FFAC9BED140
        public void get_contentContainer(){} // RVA: 0x7FFAC869D800
        public void set_visualTreeAssetSource(){} // RVA: 0x7FFAC39CEBB0
        public void Add(){} // RVA: 0x7FFAC9BED150
        public void Insert(){} // RVA: 0x7FFAC9BED2B0
        public void Clear(){} // RVA: 0x7FFAC9BED3A0
        public void ElementAt(){} // RVA: 0x7FFAC9BED420
        public void get_Item(){} // RVA: 0x7FFAC9BED430
        public void get_childCount(){} // RVA: 0x7FFAC9BED510
        public void IndexOf(){} // RVA: 0x7FFAC9BED5B0
        public void ElementAtTreePath(){} // RVA: 0x7FFAC9BED6A0
        public void FindElementInTree(){} // RVA: 0x7FFAC9BED940
        public void Children(){} // RVA: 0x7FFAC9BEDAB0
        public void BringToFront(){} // RVA: 0x7FFAC9BEDB70
        public void SendToBack(){} // RVA: 0x7FFAC9BEDBC0
        public void PlaceBehind(){} // RVA: 0x7FFAC9BEDC10
        public void RemoveFromHierarchy(){} // RVA: 0x7FFAC9BEDD30
        public void GetFirstOfType(){} // RVA: 0x7FFAC2E8DC40
        public void GetFirstAncestorOfType(){} // RVA: 0x7FFAC2E8DC40
        public void GetFirstAncestorWhere(){} // RVA: 0x7FFAC9BEDE50
        public void Contains(){} // RVA: 0x7FFAC9BEDED0
        public void GatherAllChildren(){} // RVA: 0x7FFAC9BEDF20
        public void FindCommonAncestor(){} // RVA: 0x7FFAC9BEE040
        public void GetRoot(){} // RVA: 0x7FFAC9BEE1D0
        public void GetRootVisualContainer(){} // RVA: 0x7FFAC9BEE260
        public void GetNextElementDepthFirst(){} // RVA: 0x7FFAC9BEE2A0
        public void GetPreviousElementDepthFirst(){} // RVA: 0x7FFAC9BEE3E0
        public void RetargetElement(){} // RVA: 0x7FFAC9BEE530
        public void get_positionWithLayout(){} // RVA: 0x7FFAC9BEE5E0
        public void GetPivotedMatrixWithLayout(){} // RVA: 0x7FFAC9BEE670
        public void get_hasDefaultRotationAndScale(){} // RVA: 0x7FFAC9BEEB10
        public void Min(){} // RVA: 0x7FFAC9BEEC40
        public void Max(){} // RVA: 0x7FFAC9BEEC50
        public void TransformAlignedRectToParentSpace(){} // RVA: 0x7FFAC9BEEC60
        public void CalculateConservativeRect(){} // RVA: 0x7FFAC9BEEDA0
        public void TransformAlignedRect(){} // RVA: 0x7FFAC9BEF180
        public void OrderMinMaxRect(){} // RVA: 0x7FFAC9BEF200
        public void MultiplyMatrix44Point2(){} // RVA: 0x7FFAC9BEF250
        public void MultiplyVector2(){} // RVA: 0x7FFAC9BEF2A0
        public void MultiplyMatrix34(){} // RVA: 0x7FFAC9BEF2E0
        public void TranslateMatrix34(){} // RVA: 0x7FFAC9BEF510
        public void TranslateMatrix34InPlace(){} // RVA: 0x7FFAC9BEF620
        public void get_schedule(){} // RVA: 0x7FFAC869D800
        public void UnityEngine.UIElements.IVisualElementScheduler.Execute(){} // RVA: 0x7FFAC9BEF7E0 | overloaded x2
        public void get_style(){} // RVA: 0x7FFAC9BEF910
        public void get_customStyle(){} // RVA: 0x7FFAC9BEF9D0
        public void get_styleSheets(){} // RVA: 0x7FFAC38D6FB0
        public void AddStyleSheetPath(){} // RVA: 0x7FFAC9BEFAB0
        public void ResolveLengthValue(){} // RVA: 0x7FFAC9BEFEB0
        public void ResolveTranslate(){} // RVA: 0x7FFAC9BF0000
        public void ResolveTransformOrigin(){} // RVA: 0x7FFAC9BF01B0
        public void ResolveRotation(){} // RVA: 0x7FFAC9BF03B0
        public void ResolveScale(){} // RVA: 0x7FFAC9BF0520
        public void get_tooltip(){} // RVA: 0x7FFAC9BF0620
        public void set_tooltip(){} // RVA: 0x7FFAC9BF06C0
        public void GetOrCreateTypeData(){} // RVA: 0x7FFAC9BF0840
        public void get_typeData(){} // RVA: 0x7FFAC9BF09A0
        public void .cctor(){} // RVA: 0x7FFAC9BF0B60
        public void <AssignMeasureFunction>b__432_0(){} // RVA: 0x7FFAC9BE8A80
    }

    public class VisualElementAnimationSystem : BaseVisualTreeUpdater
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> profilerMarker; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> stylePropertyAnimationProfilerMarker; // 0x28
        public bool m_HasNewAnimations; // 0x30
        public bool m_IterationListDirty; // 0x31
        public string s_Description;
        public Unity.Profiling.ProfilerMarker s_ProfilerMarker; // 0x8
        public string s_StylePropertyAnimationDescription; // 0x10
        public Unity.Profiling.ProfilerMarker s_StylePropertyAnimationProfilerMarker; // 0x18
        public long lastUpdate; // 0x38

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFAC9AC2900
        public void get_stylePropertyAnimationProfilerMarker(){} // RVA: 0x7FFAC9AC2960
        public void UnregisterAnimation(){} // RVA: 0x7FFAC9AC29C0
        public void UnregisterAnimations(){} // RVA: 0x7FFAC9AC2A20
        public void RegisterAnimation(){} // RVA: 0x7FFAC9AC2BB0
        public void RegisterAnimations(){} // RVA: 0x7FFAC9AC2C30
        public void Update(){} // RVA: 0x7FFAC9AC2DD0
        public void OnVersionChanged(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC9AC32A0
        public void .cctor(){} // RVA: 0x7FFAC9AC3400
    }

    public class VisualElementAsset : UxmlAsset
    {
        public string ruleIndex; // 0x30
        public int classes; // 0x38
        public string stylesheetPaths; // 0x40
        public 0x6B1266F8 hasStylesheetPaths; // 0x48
        public string[] stylesheets; // 0x50
        public System.Collections.Generic.List`1<string> hasStylesheets; // 0x58
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet> skipClone; // 0x60
        public bool m_SkipClone; // 0x68

        // ── Methods ──
        public void get_ruleIndex(){} // RVA: 0x7FFAC98DE3E0
        public void get_classes(){} // RVA: 0x7FFAC991F8D0
        public void get_stylesheetPaths(){} // RVA: 0x7FFAC9C2C510
        public void get_hasStylesheetPaths(){} // RVA: 0x7FFAC781EE50
        public void get_stylesheets(){} // RVA: 0x7FFAC9C2C5D0
        public void get_hasStylesheets(){} // RVA: 0x7FFAC4836B90
        public void get_skipClone(){} // RVA: 0x7FFAC2FE9570
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC9C2C690
    }

    public class VisualElementExtensions : Object
    {
        // ── Methods ──
        public void StretchToParentSize(){} // RVA: 0x7FFAC9ABDF30
        public void AddManipulator(){} // RVA: 0x7FFAC9ABE1D0
        public void RemoveManipulator(){} // RVA: 0x7FFAC9ABE230
        public void WorldToLocal(){} // RVA: 0x7FFAC9ABE470 | overloaded x2
        public void LocalToWorld(){} // RVA: 0x7FFAC9ABE370
        public void ChangeCoordinatesTo(){} // RVA: 0x7FFAC9ABE560
    }

    public class VisualElementFactoryRegistry : Object
    {
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<UnityEngine.UIElements.IUxmlFactory>> factories;
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<UnityEngine.UIElements.IUxmlFactory>> s_MovedTypesFactories; // 0x8

        // ── Methods ──
        public void GetMovedUIControlTypeName(){} // RVA: 0x7FFAC9C2C820
        public void get_factories(){} // RVA: 0x7FFAC9C2CA10
        public void RegisterFactory(){} // RVA: 0x7FFAC9C2CC70
        public void TryGetValue(){} // RVA: 0x7FFAC9C2D150
        public void RegisterEngineFactories(){} // RVA: 0x7FFAC9C2D200
        public void RegisterUserFactories(){} // RVA: 0x7FFAC9C2F250
    }

    public class VisualElementFocusChangeDirection : FocusChangeDirection
    {
        public UnityEngine.UIElements.VisualElementFocusChangeDirection left;
        public UnityEngine.UIElements.VisualElementFocusChangeDirection right; // 0x8

        // ── Methods ──
        public void get_left(){} // RVA: 0x7FFAC9ABF170
        public void get_right(){} // RVA: 0x7FFAC9ABF1D0
        public void .ctor(){} // RVA: 0x7FFAC9ABF230
        public void .cctor(){} // RVA: 0x7FFAC9ABF290
    }

    public class VisualElementFocusChangeTarget : FocusChangeDirection
    {
        public UnityEngine.UIElements.ObjectPool`1<UnityEngine.UIElements.VisualElementFocusChangeTarget> target;
        public UnityEngine.UIElements.Focusable <target>k__BackingField; // 0x18

        // ── Methods ──
        public void GetPooled(){} // RVA: 0x7FFAC9ABF520
        public void Dispose(){} // RVA: 0x7FFAC9ABF640
        public void ApplyTo(){} // RVA: 0x7FFAC9ABF720
        public void .ctor(){} // RVA: 0x7FFAC9ABF770
        public void get_target(){} // RVA: 0x7FFAC2F247C0
        public void set_target(){} // RVA: 0x7FFAC2F87E80
        public void .cctor(){} // RVA: 0x7FFAC9ABF820
    }

    public class VisualElementFocusRing : Object
    {
        public UnityEngine.UIElements.VisualElement focusController; // 0x10
        public 0x6B126D28 defaultFocusOrder; // 0x18
        public System.Collections.Generic.List`1<FocusRingRecord> m_FocusRing; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9ABFB00
        public void get_focusController(){} // RVA: 0x7FFAC8D71270
        public void get_defaultFocusOrder(){} // RVA: 0x7FFAC3157800
        public void set_defaultFocusOrder(){} // RVA: 0x7FFAC392CD10
        public void FocusRingAutoIndexSort(){} // RVA: 0x7FFAC9ABFC30
        public void FocusRingSort(){} // RVA: 0x7FFAC9AC0000
        public void DoUpdate(){} // RVA: 0x7FFAC9AC0130
        public void BuildRingForScopeRecursive(){} // RVA: 0x7FFAC9AC0220
        public void SortAndFlattenScopeLists(){} // RVA: 0x7FFAC9AC0530
        public void GetFocusableInternalIndex(){} // RVA: 0x7FFAC9AC0800
        public void GetFocusChangeDirection(){} // RVA: 0x7FFAC9AC08C0
        public void GetNextFocusable(){} // RVA: 0x7FFAC9AC0E10
        public void GetNextFocusableInTree(){} // RVA: 0x7FFAC9AC14F0
        public void GetPreviousFocusableInTree(){} // RVA: 0x7FFAC9AC1590
    }

    public class VisualElementListPool : Object
    {
        public UnityEngine.UIElements.ObjectPool`1<System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>> pool;

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFAC9ABDA60
        public void Get(){} // RVA: 0x7FFAC9ABDB30
        public void Release(){} // RVA: 0x7FFAC9ABDC10
        public void .cctor(){} // RVA: 0x7FFAC9ABDCD0
    }

    public class VisualElementPanelActivator : Object
    {
        public UnityEngine.UIElements.IVisualElementPanelActivatable isActive; // 0x10
        public bool isDetaching; // 0x18
        public bool <isDetaching>k__BackingField; // 0x19
        public UnityEngine.UIElements.EventCallback`1<UnityEngine.UIElements.AttachToPanelEvent> m_OnAttachToPanelCallback; // 0x20
        public UnityEngine.UIElements.EventCallback`1<UnityEngine.UIElements.DetachFromPanelEvent> m_OnDetachFromPanelCallback; // 0x28

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x7FFAC2F3C4E0
        public void set_isActive(){} // RVA: 0x7FFAC2F3C4F0
        public void get_isDetaching(){} // RVA: 0x7FFAC3228D50
        public void set_isDetaching(){} // RVA: 0x7FFAC3515120
        public void .ctor(){} // RVA: 0x7FFAC9AC1680
        public void SetActive(){} // RVA: 0x7FFAC9AC1830
        public void SendActivation(){} // RVA: 0x7FFAC9AC19A0
        public void SendDeactivation(){} // RVA: 0x7FFAC9AC1A20
        public void OnEnter(){} // RVA: 0x7FFAC9AC1AA0
        public void OnLeave(){} // RVA: 0x7FFAC9AC1AB0
    }

    public class VisualElementStyleSheetSet : ValueType
    {
        public UnityEngine.UIElements.VisualElement m_Element; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void Add(){} // RVA: 0x7FFAC9AC1B10
        public void Remove(){} // RVA: 0x7FFAC9AC1DD0
        public void Equals(){} // RVA: 0x7FFAC9AC2000 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9AC20E0
    }

    public class VisualElementUtils : Object
    {
        public System.Collections.Generic.HashSet`1<string> s_usedNames;
        public System.Type s_FoldoutType; // 0x8
        public string s_InspectorElementUssClassName; // 0x10

        // ── Methods ──
        public void GetUniqueName(){} // RVA: 0x7FFAC9AC2110
        public void GetFoldoutDepth(){} // RVA: 0x7FFAC9AC22D0
        public void AssignInspectorStyleIfNecessary(){} // RVA: 0x7FFAC9AC23B0
        public void .cctor(){} // RVA: 0x7FFAC9AC2580
    }

    public class VisualTreeAsset : ScriptableObject
    {
        public string importedWithErrors;
        public bool importedWithWarnings; // 0x18
        public bool templateDependencies; // 0x19
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.UIElements.VisualElement> stylesheets; // 0x8
        public System.Collections.Generic.List`1<UsingEntry> visualElementAssets; // 0x20
        public UnityEngine.UIElements.StyleSheet templateAssets; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementAsset> uxmlObjectEntries; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.UIElements.TemplateAsset> uxmlObjectIds; // 0x38
        public System.Collections.Generic.List`1<UxmlObjectEntry> slots; // 0x40
        public System.Collections.Generic.List`1<int> contentContainerId; // 0x48
        public System.Collections.Generic.List`1<AssetEntry> contentHash; // 0x50
        public System.Collections.Generic.List`1<SlotDefinition> m_Slots; // 0x58
        public int m_ContentContainerId; // 0x60
        public int m_ContentHash; // 0x64

        // ── Methods ──
        public void get_importedWithErrors(){} // RVA: 0x7FFAC9828D80
        public void set_importedWithErrors(){} // RVA: 0x7FFAC2F3C4F0
        public void get_importedWithWarnings(){} // RVA: 0x7FFAC9C0AAC0
        public void set_importedWithWarnings(){} // RVA: 0x7FFAC3515120
        public void GetNextChildSerialNumber(){} // RVA: 0x7FFAC9C2F650
        public void get_templateDependencies(){} // RVA: 0x7FFAC9C2F6E0
        public void get_stylesheets(){} // RVA: 0x7FFAC9C2F790
        public void get_visualElementAssets(){} // RVA: 0x7FFAC98DE3D0
        public void set_visualElementAssets(){} // RVA: 0x7FFAC2F4F890
        public void get_templateAssets(){} // RVA: 0x7FFAC991F6C0
        public void set_templateAssets(){} // RVA: 0x7FFAC31D0C20
        public void get_uxmlObjectEntries(){} // RVA: 0x7FFAC2F9E740
        public void get_uxmlObjectIds(){} // RVA: 0x7FFAC2F9C730
        public void RegisterUxmlObject(){} // RVA: 0x7FFAC9C2F840
        public void GetUxmlObjects(){}
        public void AssetEntryExists(){} // RVA: 0x7FFAC9C2FB80
        public void RegisterAssetEntry(){} // RVA: 0x7FFAC9C2FDA0
        public void GetAsset(){} // RVA: 0x7FFAC2E8DC40
        public void GetUxmlObjectEntry(){} // RVA: 0x7FFAC9C2FEF0
        public void GetUxmlObjectFactory(){} // RVA: 0x7FFAC9C30060
        public void get_slots(){} // RVA: 0x7FFAC991F940
        public void set_slots(){} // RVA: 0x7FFAC2FE9510
        public void get_contentContainerId(){} // RVA: 0x7FFAC9950330
        public void set_contentContainerId(){} // RVA: 0x7FFAC3138C10
        public void Instantiate(){} // RVA: 0x7FFAC9C30610 | overloaded x2
        public void CloneTree(){} // RVA: 0x7FFAC9C308E0 | overloaded x5
        public void CloneSetupRecursively(){} // RVA: 0x7FFAC9C31120
        public void CompareForOrder(){} // RVA: 0x7FFAC9C31E80
        public void TryGetSlotInsertionPoint(){} // RVA: 0x7FFAC9C31EC0
        public void ResolveTemplate(){} // RVA: 0x7FFAC9C32060
        public void Create(){} // RVA: 0x7FFAC9C32430
        public void AssignClassListFromAssetToElement(){} // RVA: 0x7FFAC9C32C10
        public void AssignStyleSheetFromAssetToElement(){} // RVA: 0x7FFAC9C32C80
        public void get_contentHash(){} // RVA: 0x7FFAC9950340
        public void set_contentHash(){} // RVA: 0x7FFAC46D5120
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
        public void .cctor(){} // RVA: 0x7FFAC9C32F00
        public void <Create>g__CreateError|65_0(){} // RVA: 0x7FFAC9C33080
    }

    public class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
    {
        public UnityEngine.PropertyName profilerMarker;
        public UnityEngine.PropertyName temporaryObjectCache; // 0x4
        public string s_Description; // 0x8
        public Unity.Profiling.ProfilerMarker s_ProfilerMarker; // 0x10
        public Unity.Profiling.ProfilerMarker s_ProfilerBindingRequestsMarker; // 0x18
        public Unity.Profiling.ProfilerMarker s_MarkerUpdate; // 0x20
        public Unity.Profiling.ProfilerMarker s_MarkerPoll; // 0x28
        public bool <disableBindingsThrottling>k__BackingField; // 0x30
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_ElementsWithBindings; // 0x38
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_ElementsToAdd; // 0x40
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_ElementsToRemove; // 0x48
        public long m_LastUpdateTime; // 0x50
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_ElementsToBind; // 0x58
        public System.Collections.Generic.Dictionary`2<object,object> <temporaryObjectCache>k__BackingField; // 0x60
        public System.Collections.Generic.List`1<UnityEngine.UIElements.IBinding> updatedBindings; // 0x68

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFAC9A7E020
        public void GetBindingObjectFromElement(){} // RVA: 0x7FFAC9A7E080
        public void StartTracking(){} // RVA: 0x7FFAC9A7E1B0
        public void StopTracking(){} // RVA: 0x7FFAC9A7E250
        public void get_temporaryObjectCache(){} // RVA: 0x7FFAC2FBF370
        public void GetAdditionalBinding(){} // RVA: 0x7FFAC9A7E2F0
        public void StartTrackingRecursive(){} // RVA: 0x7FFAC9A7E380
        public void StopTrackingRecursive(){} // RVA: 0x7FFAC9A7E550
        public void OnVersionChanged(){} // RVA: 0x7FFAC9A7E700
        public void OnHierarchyChange(){} // RVA: 0x7FFAC9A7E810
        public void CurrentTime(){} // RVA: 0x7FFAC9A7E840
        public void PerformTrackingOperations(){} // RVA: 0x7FFAC9A7E890
        public void Update(){} // RVA: 0x7FFAC9A7EBC0
        public void UpdateBindings(){} // RVA: 0x7FFAC9A7F270
        public void .ctor(){} // RVA: 0x7FFAC9A7F800
        public void .cctor(){} // RVA: 0x7FFAC9A7FB60
    }

    public class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater
    {
        public uint profilerMarker; // 0x20
        public uint m_LastVersion; // 0x24
        public string s_Description;
        public Unity.Profiling.ProfilerMarker s_ProfilerMarker; // 0x8

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFAC9AC3630
        public void OnVersionChanged(){} // RVA: 0x7FFAC9AC3690
        public void DirtyHierarchy(){} // RVA: 0x7FFAC9AC37D0
        public void DirtyBoundingBoxHierarchy(){} // RVA: 0x7FFAC9AC3930
        public void Update(){} // RVA: 0x7FFAC9AC3990
        public void .ctor(){} // RVA: 0x7FFAC7E01460
        public void .cctor(){} // RVA: 0x7FFAC9AC3A00
    }

    public class VisualTreeStyleUpdater : BaseVisualTreeUpdater
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> profilerMarker; // 0x20
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> disposed; // 0x28
        public bool m_IsApplyingStyles; // 0x30
        public uint m_Version; // 0x34
        public uint m_LastVersion; // 0x38
        public UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal; // 0x40
        public string s_Description;
        public Unity.Profiling.ProfilerMarker s_ProfilerMarker; // 0x8
        public bool <disposed>k__BackingField; // 0x48

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFAC9AC49E0
        public void OnVersionChanged(){} // RVA: 0x7FFAC9AC4A40
        public void Update(){} // RVA: 0x7FFAC9AC4B20
        public void get_disposed(){} // RVA: 0x7FFAC2FD8D30
        public void set_disposed(){} // RVA: 0x7FFAC2FD8D40
        public void Dispose(){} // RVA: 0x7FFAC9AC5000
        public void ApplyStyles(){} // RVA: 0x7FFAC9AC5040
        public void .ctor(){} // RVA: 0x7FFAC9AC5140
        public void .cctor(){} // RVA: 0x7FFAC9AC5300
    }

    public class VisualTreeStyleUpdaterTraversal : HierarchyTraversal
    {
        public UnityEngine.UIElements.StyleVariableContext currentPixelsPerPoint; // 0x10
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_UpdateList; // 0x18
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_ParentList; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> m_TempMatchResults; // 0x28
        public float <currentPixelsPerPoint>k__BackingField; // 0x30
        public UnityEngine.UIElements.StyleMatchingContext m_StyleMatchingContext; // 0x38
        public UnityEngine.UIElements.StyleSheets.StylePropertyReader m_StylePropertyReader; // 0x40
        public System.Collections.Generic.List`1<0x6B129770> m_AnimatedProperties; // 0x48

        // ── Methods ──
        public void get_currentPixelsPerPoint(){} // RVA: 0x7FFAC3C40670
        public void set_currentPixelsPerPoint(){} // RVA: 0x7FFAC47394E0
        public void PrepareTraversal(){} // RVA: 0x7FFAC47394E0
        public void AddChangedElement(){} // RVA: 0x7FFAC9AC5980
        public void Clear(){} // RVA: 0x7FFAC9AC5AB0
        public void PropagateToChildren(){} // RVA: 0x7FFAC9AC5B50
        public void PropagateToParents(){} // RVA: 0x7FFAC9AC5CD0
        public void OnProcessMatchResult(){} // RVA: 0x7FFAC9AC5D80
        public void TraverseRecursive(){} // RVA: 0x7FFAC9AC5DC0
        public void ProcessTransitions(){} // RVA: 0x7FFAC9AC6800
        public void ForceUpdateTransitions(){} // RVA: 0x7FFAC9AC6920
        public void CancelAnimationsWithNoTransitionProperty(){} // RVA: 0x7FFAC9AC6BF0
        public void ShouldSkipElement(){} // RVA: 0x7FFAC9AC6F40
        public void ProcessMatchedRules(){} // RVA: 0x7FFAC9AC6FD0
        public void ProcessMatchedVariables(){} // RVA: 0x7FFAC9AC8340
        public void .ctor(){} // RVA: 0x7FFAC9AC8420
    }

    public class VisualTreeUpdater : Object
    {
        public UnityEngine.UIElements.BaseVisualElementPanel m_Panel; // 0x10
        public UpdaterArray m_UpdaterArray; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9AC8A00
        public void Dispose(){} // RVA: 0x7FFAC9AC8C90
        public void UpdateVisualTreePhase(){} // RVA: 0x7FFAC9AC8DB0
        public void OnVersionChanged(){} // RVA: 0x7FFAC9AC8F50
        public void SetUpdater(){} // RVA: 0x7FFAC2C70ED0
        public void GetUpdater(){} // RVA: 0x7FFAC9AC9090
        public void SetDefaultUpdaters(){} // RVA: 0x7FFAC9AC90D0
    }

    public class VisualTreeViewDataUpdater : BaseVisualTreeUpdater
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> profilerMarker; // 0x20
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement> m_ParentList; // 0x28
        public uint m_Version; // 0x30
        public uint m_LastVersion; // 0x34
        public string s_Description;
        public Unity.Profiling.ProfilerMarker s_ProfilerMarker; // 0x8

        // ── Methods ──
        public void get_profilerMarker(){} // RVA: 0x7FFAC9AC9620
        public void OnVersionChanged(){} // RVA: 0x7FFAC9AC9680
        public void Update(){} // RVA: 0x7FFAC9AC97A0
        public void ValidateViewDataOnSubTree(){} // RVA: 0x7FFAC9AC9900
        public void PropagateToParents(){} // RVA: 0x7FFAC9AC9B60
        public void .ctor(){} // RVA: 0x7FFAC9AC9C10
        public void .cctor(){} // RVA: 0x7FFAC9AC9D50
    }

}