// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 55
// Methods: 590

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class SafeHandleAccess
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B12320
        public void IsNull(){} // RVA: 0x74165B0
        public void op_Implicit(){} // RVA: 0x74165C0
    }

    public class SavePersistentViewData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33B980
        public void Invoke(){} // RVA: 0x33BA50
    }

    public class Scale
    {
        public UnityEngine.Vector3 m_Scale; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7465B30
        public void Initial(){} // RVA: 0x7465BD0
        public void None(){} // RVA: 0x7465CE0
        public void get_value(){} // RVA: 0x210E270
        public void op_Equality(){} // RVA: 0x7465D20
        public void op_Inequality(){} // RVA: 0x7465D80
        public void Equals(){} // RVA: 0x7465E20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7465EF0
        public void ToString(){} // RVA: 0x7116B50
    }

    public class ScheduledItem
    {
        public System.Func`1<bool> timerUpdateStopCondition; // 0x10
        public System.Func`1<bool> OnceCondition;
        public System.Func`1<bool> ForeverCondition; // 0x8
        public long <startMs>k__BackingField; // 0x18

        // ── Methods ──
        public void get_startMs(){} // RVA: 0x2E07C0
        public void set_startMs(){} // RVA: 0xC5BE60
        public void get_delayMs(){} // RVA: 0x30B0C0
        public void set_delayMs(){} // RVA: 0xAE83A0
        public void get_intervalMs(){} // RVA: 0x30B130
        public void set_intervalMs(){} // RVA: 0x8AC650
        public void get_endTimeMs(){} // RVA: 0x6374D0
        public void .ctor(){} // RVA: 0x743A730
        public void ResetStartTime(){} // RVA: 0x743A820
        public void PerformTimerUpdate(){}
        public void OnItemUnscheduled(){} // RVA: 0x2DD310
        public void ShouldUnschedule(){} // RVA: 0x743A870
        public void .cctor(){} // RVA: 0x743A8A0
    }

    public class ScrollView
    {
        public int m_FirstLayoutPass; // 0x3C8
        public 0x65834260 m_HorizontalScrollerVisibility; // 0x3CC
        public 0x65834260 m_VerticalScrollerVisibility; // 0x3D0
        public UnityEngine.UIElements.VisualElement m_AttachedRootVisualContainer; // 0x3D8
        public float m_SingleLineHeight; // 0x3E0
        public bool m_MouseWheelScrollSizeIsInline; // 0x3E4
        public float m_HorizontalPageSize; // 0x3E8
        public float m_VerticalPageSize; // 0x3EC
        public float m_MouseWheelScrollSize; // 0x3F0
        public float k_DefaultScrollDecelerationRate;
        public float m_ScrollDecelerationRate; // 0x3F4
        public float k_ScaledPixelsPerPointMultiplier; // 0x3F8
        public float k_TouchScrollInertiaBaseTimeInterval; // 0x3FC
        public float k_DefaultElasticity; // 0x4
        public float m_Elasticity; // 0x400
        public 0x65834368 m_TouchScrollBehavior; // 0x404
        public 0x658343C0 m_NestedInteractionKind; // 0x408
        public long k_DefaultElasticAnimationInterval; // 0x8
        public long m_ElasticAnimationIntervalMs; // 0x410
        public UnityEngine.UIElements.VisualElement <contentViewport>k__BackingField; // 0x418
        public UnityEngine.UIElements.Scroller <horizontalScroller>k__BackingField; // 0x420
        public UnityEngine.UIElements.Scroller <verticalScroller>k__BackingField; // 0x428
        public UnityEngine.UIElements.VisualElement m_ContentContainer; // 0x430
        public UnityEngine.UIElements.VisualElement m_ContentAndVerticalScrollContainer; // 0x438
        public float previousVerticalTouchScrollTimeStamp; // 0x440

        // ── Methods ──
        public void get_horizontalScrollerVisibility(){} // RVA: 0x73BF400
        public void set_horizontalScrollerVisibility(){} // RVA: 0x73BF410
        public void get_verticalScrollerVisibility(){} // RVA: 0x73BF4B0
        public void set_verticalScrollerVisibility(){} // RVA: 0x73BF4C0
        public void set_showHorizontal(){} // RVA: 0x73BF570
        public void set_showVertical(){} // RVA: 0x73BF590
        public void get_needsHorizontal(){} // RVA: 0x73BF5B0
        public void get_needsVertical(){} // RVA: 0x73BF600
        public void get_isVerticalScrollDisplayed(){} // RVA: 0x73BF650
        public void get_isHorizontalScrollDisplayed(){} // RVA: 0x73BF6B0
        public void get_scrollOffset(){} // RVA: 0x73BF710
        public void set_scrollOffset(){} // RVA: 0x73BF790
        public void set_horizontalPageSize(){} // RVA: 0x73BF910
        public void set_verticalPageSize(){} // RVA: 0x73BF920
        public void get_mouseWheelScrollSize(){} // RVA: 0x55DD450
        public void set_mouseWheelScrollSize(){} // RVA: 0x73BF930
        public void get_scrollableWidth(){} // RVA: 0x73BF9C0
        public void get_scrollableHeight(){} // RVA: 0x73BFA50
        public void get_hasInertia(){} // RVA: 0x73BFAE0
        public void get_scrollDecelerationRate(){} // RVA: 0x73BFB00
        public void set_scrollDecelerationRate(){} // RVA: 0x73BFB10
        public void get_elasticity(){} // RVA: 0x73BFB30
        public void set_elasticity(){} // RVA: 0x73BFB40
        public void get_touchScrollBehavior(){} // RVA: 0x73BFB60
        public void set_touchScrollBehavior(){} // RVA: 0x73BFB70
        public void get_nestedInteractionKind(){} // RVA: 0x73BFC40
        public void set_nestedInteractionKind(){} // RVA: 0x73BFC50
        public void set_elasticAnimationIntervalMs(){} // RVA: 0x73BFC60
        public void OnHorizontalScrollDragElementChanged(){} // RVA: 0x73BFD90
        public void OnVerticalScrollDragElementChanged(){} // RVA: 0x73BFE00
        public void UpdateHorizontalSliderPageSize(){} // RVA: 0x73BFE70
        public void UpdateVerticalSliderPageSize(){} // RVA: 0x73BFF90
        public void UpdateContentViewTransform(){} // RVA: 0x73C00B0
        public void ScrollTo(){} // RVA: 0x73C0340
        public void GetXDeltaOffset(){} // RVA: 0x73C05A0
        public void GetYDeltaOffset(){} // RVA: 0x73C07C0
        public void GetDeltaDistance(){} // RVA: 0x73C09E0
        public void get_contentViewport(){} // RVA: 0xDA6540
        public void get_horizontalScroller(){} // RVA: 0xD97D80
        public void get_verticalScroller(){} // RVA: 0xDA2770
        public void get_contentContainer(){} // RVA: 0x73C0A50
        public void .ctor(){} // RVA: 0x73C0A70 | overloaded x2
        public void get_mode(){} // RVA: 0x73C1C30
        public void set_mode(){} // RVA: 0x73C1C40
        public void SetScrollViewMode(){} // RVA: 0x73C1C60
        public void OnAttachToPanel(){} // RVA: 0x73C20D0
        public void OnDetachFromPanel(){} // RVA: 0x73C25D0
        public void OnPointerCapture(){} // RVA: 0x73C2AB0
        public void OnPointerCaptureOut(){} // RVA: 0x73C2C20
        public void OnGeometryChanged(){} // RVA: 0x73C2D40
        public void ScheduleResetLayoutPass(){} // RVA: 0x73C3040
        public void ResetLayoutPass(){} // RVA: 0x73C3180
        public void ComputeElasticOffset(){} // RVA: 0x73C3190
        public void ComputeInitialSpringBackVelocity(){} // RVA: 0x73C3300
        public void SpringBack(){} // RVA: 0x73C3460
        public void ApplyScrollInertia(){} // RVA: 0x73C3660
        public void PostPointerUpAnimation(){} // RVA: 0x73C3B60
        public void OnPointerDown(){} // RVA: 0x73C3E00
        public void OnPointerMove(){} // RVA: 0x73C40D0
        public void OnPointerCancel(){} // RVA: 0x73C4390
        public void OnPointerUp(){} // RVA: 0x73C43F0
        public void InitTouchScrolling(){} // RVA: 0x73C44E0
        public void ComputeTouchScrolling(){} // RVA: 0x73C4850
        public void ApplyTouchScrolling(){} // RVA: 0x73C4C70
        public void ReleaseScrolling(){} // RVA: 0x73C4FA0
        public void ExecuteElasticSpringAnimation(){} // RVA: 0x73C5170
        public void AdjustScrollers(){} // RVA: 0x73C5410
        public void UpdateScrollers(){} // RVA: 0x73C55E0
        public void OnScrollersGeometryChanged(){} // RVA: 0x73C5A20
        public void OnScrollWheel(){} // RVA: 0x73C5C00
        public void OnRootCustomStyleResolved(){} // RVA: 0x73C6140
        public void ReadSingleLineHeight(){} // RVA: 0x73C6150
        public void UpdateElasticBehaviour(){} // RVA: 0x73C6350
        public void .cctor(){} // RVA: 0x73C6610
        public void <.ctor>b__126_0(){} // RVA: 0x73C7020
        public void <.ctor>b__126_1(){} // RVA: 0x73C7070
    }

    public class Scroller
    {
        public System.Action`1<float> valueChanged; // 0x3C8
        public UnityEngine.UIElements.Slider <slider>k__BackingField; // 0x3D0
        public UnityEngine.UIElements.RepeatButton <lowButton>k__BackingField; // 0x3D8
        public UnityEngine.UIElements.RepeatButton <highButton>k__BackingField; // 0x3E0
        public string ussClassName;
        public string horizontalVariantUssClassName; // 0x8
        public string verticalVariantUssClassName; // 0x10

        // ── Methods ──
        public void add_valueChanged(){} // RVA: 0x73BD6E0
        public void remove_valueChanged(){} // RVA: 0x73BD7E0
        public void get_slider(){} // RVA: 0xD8F1C0
        public void set_slider(){} // RVA: 0xD9F4F0
        public void get_lowButton(){} // RVA: 0xDA0010
        public void set_lowButton(){} // RVA: 0xD9ACB0
        public void get_highButton(){} // RVA: 0xD98840
        public void set_highButton(){} // RVA: 0xD9D360
        public void get_value(){} // RVA: 0x73BD8E0
        public void set_value(){} // RVA: 0x73BD910
        public void get_lowValue(){} // RVA: 0x73BD940
        public void set_lowValue(){} // RVA: 0x73BD990
        public void get_highValue(){} // RVA: 0x73BD9F0
        public void set_highValue(){} // RVA: 0x73BDA40
        public void set_direction(){} // RVA: 0x73BDAA0
        public void .ctor(){} // RVA: 0x73BDCB0 | overloaded x2
        public void Adjust(){} // RVA: 0x73BE260
        public void OnSliderValueChange(){} // RVA: 0x73BE2F0
        public void ScrollPageUp(){} // RVA: 0x73BE5B0 | overloaded x2
        public void ScrollPageDown(){} // RVA: 0x73BE6B0 | overloaded x2
        public void .cctor(){} // RVA: 0x73BE7B0
    }

    public class SerializedVirtualizationData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SetupDragAndDropArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73DA3B0
    }

    public class Slider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73C8540 | overloaded x3
        public void ApplyInputDeviceDelta(){} // RVA: 0x73C86B0
        public void SliderLerpUnclamped(){} // RVA: 0x73C8880
        public void SliderNormalizeValue(){} // RVA: 0x73A9FE0
        public void ParseStringToValue(){} // RVA: 0x73C8A40
        public void ComputeValueFromKey(){} // RVA: 0x73C8AD0
        public void .cctor(){} // RVA: 0x73C8D50
    }

    public class SliderInt
    {
        public string ussClassName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73C9AB0 | overloaded x2
        public void get_pageSize(){} // RVA: 0x73C9C20
        public void set_pageSize(){} // RVA: 0x73C9C70
        public void ApplyInputDeviceDelta(){} // RVA: 0x73C9CD0
        public void SliderLerpUnclamped(){} // RVA: 0x73C9E90
        public void SliderNormalizeValue(){} // RVA: 0x73C9EB0
        public void ParseStringToValue(){} // RVA: 0x73C9EE0
        public void ComputeValueAndDirectionFromClick(){} // RVA: 0x73C9FC0
        public void ComputeValueFromKey(){} // RVA: 0x73CA250
        public void .cctor(){} // RVA: 0x73CA4D0
    }

    public class SortColumnDescription
    {
        public int m_ColumnIndex; // 0x10
        public string m_ColumnName; // 0x18
        public 0x65833810 m_SortDirection; // 0x20
        public UnityEngine.UIElements.Column <column>k__BackingField; // 0x28

        // ── Methods ──
        public void get_columnName(){} // RVA: 0x2E07C0
        public void set_columnName(){} // RVA: 0x73B7B90
        public void get_columnIndex(){} // RVA: 0x32A5C0
        public void set_columnIndex(){} // RVA: 0x73B7C50
        public void get_column(){} // RVA: 0x30B130
        public void set_column(){} // RVA: 0x2DEE90
        public void get_direction(){} // RVA: 0x760030
        public void set_direction(){} // RVA: 0x73B7C80
        public void add_changed(){} // RVA: 0x73B7CB0
        public void remove_changed(){} // RVA: 0x73B7DB0
        public void .ctor(){} // RVA: 0x73B7F20 | overloaded x3
    }

    public class SortColumnDescriptions
    {
        public System.Collections.Generic.IList`1<UnityEngine.UIElements.SortColumnDescription> m_Descriptions; // 0x10
        public System.Action changed; // 0x18

        // ── Methods ──
        public void add_changed(){} // RVA: 0x73B7F70
        public void remove_changed(){} // RVA: 0x73B8060
        public void GetEnumerator(){} // RVA: 0x73B8150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x73B8150
        public void Add(){} // RVA: 0x73B81A0
        public void Clear(){} // RVA: 0x73B8210
        public void Contains(){} // RVA: 0x73B83A0
        public void CopyTo(){} // RVA: 0x73B8400
        public void Remove(){} // RVA: 0x73B84E0
        public void OnDescriptionChanged(){} // RVA: 0x68B350
        public void get_Count(){} // RVA: 0x73B8720
        public void get_IsReadOnly(){} // RVA: 0x73B8770
        public void Insert(){} // RVA: 0x73B87C0
        public void .ctor(){} // RVA: 0x73B8AE0
    }

    public class Spacing
    {
        public float left; // 0x10
        public float top; // 0x14

        // ── Methods ──
        public void get_horizontal(){} // RVA: 0x70CDED0
        public void get_vertical(){} // RVA: 0x70CDEF0
        public void .ctor(){} // RVA: 0x301570
        public void op_Subtraction(){} // RVA: 0x743BE00
    }

    public class StartDragArgs
    {
        public string <title>k__BackingField; // 0x10
        public 0x65835968 <visualMode>k__BackingField; // 0x18
        public System.Collections.Hashtable <genericData>k__BackingField; // 0x20
        public System.Collections.Generic.IEnumerable`1<UnityEngine.Object> <unityObjectReferences>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73DA530
        public void get_title(){} // RVA: 0x1AD4690
        public void get_visualMode(){} // RVA: 0x1EA9890
        public void get_genericData(){} // RVA: 0x2F8380
        public void set_genericData(){} // RVA: 0x2DEE30
        public void get_unityObjectReferences(){} // RVA: 0x2E07C0
        public void set_unityObjectReferences(){} // RVA: 0x343E80
        public void SetGenericData(){} // RVA: 0x73DA640
    }

    public class StyleBackgroundSize
    {
        public UnityEngine.UIElements.BackgroundSize m_Value; // 0x10
        public 0x6583D3C8 m_Keyword; // 0x24

        // ── Methods ──
        public void get_value(){} // RVA: 0x7465F50
        public void get_keyword(){} // RVA: 0x2EE0010
        public void .ctor(){} // RVA: 0x5B58C20 | overloaded x2
        public void op_Equality(){} // RVA: 0x7465F90
        public void op_Implicit(){} // RVA: 0x7466070
        public void Equals(){} // RVA: 0x7466180 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7466220
        public void ToString(){} // RVA: 0x7466290
    }

    public class StyleCache
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x732CCF0 | overloaded x3
        public void SetValue(){} // RVA: 0x732CD90 | overloaded x3
        public void .cctor(){} // RVA: 0x732CE40
    }

    public class StyleColor
    {
        public UnityEngine.Color m_Value; // 0x10
        public 0x6583D3C8 m_Keyword; // 0x20

        // ── Methods ──
        public void get_value(){} // RVA: 0x7466310
        public void get_keyword(){} // RVA: 0x70B92A0
        public void .ctor(){} // RVA: 0x37C5C40 | overloaded x2
        public void op_Equality(){} // RVA: 0x7466330
        public void op_Implicit(){} // RVA: 0x74663B0
        public void Equals(){} // RVA: 0x7466450 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7466540
        public void ToString(){} // RVA: 0x7466560
    }

    public class StyleComplexSelector
    {
        public UnityEngine.UIElements.Hashes ancestorHashes; // 0x10
        public int m_Specificity; // 0x20
        public UnityEngine.UIElements.StyleRule <rule>k__BackingField; // 0x28
        public bool m_isSimple; // 0x30

        // ── Methods ──
        public void get_specificity(){} // RVA: 0x43DC7A0
        public void get_rule(){} // RVA: 0x30B130
        public void set_rule(){} // RVA: 0x2DEE90
        public void get_isSimple(){} // RVA: 0x71455A0
        public void get_selectors(){} // RVA: 0x7187DC0
        public void set_selectors(){} // RVA: 0x7471490
        public void OnBeforeSerialize(){} // RVA: 0x2DD310
        public void OnAfterDeserialize(){} // RVA: 0x7471500
        public void CachePseudoStateMasks(){} // RVA: 0x7471530
        public void ToString(){} // RVA: 0x7471DC0
        public void StyleSelectorPartCompare(){} // RVA: 0x7472100
        public void CalculateHashes(){} // RVA: 0x7472150
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x7472950
    }

    public class StyleCursor
    {
        public UnityEngine.UIElements.Cursor m_Value; // 0x10
        public 0x6583D3C8 m_Keyword; // 0x28

        // ── Methods ──
        public void get_value(){} // RVA: 0x74665D0
        public void get_keyword(){} // RVA: 0x3D92310
        public void .ctor(){} // RVA: 0x7466690 | overloaded x2
        public void op_Equality(){} // RVA: 0x7466700
        public void op_Implicit(){} // RVA: 0x7466800
        public void Equals(){} // RVA: 0x74669A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7466A40
        public void ToString(){} // RVA: 0x7466A60
    }

    public class StyleDataRef`1
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x283FA0
        public void Release(){} // RVA: 0x24A50
        public void CopyFrom(){} // RVA: 0x283FA0
        public void Read(){} // RVA: 0xCD60
        public void Write(){} // RVA: 0xCD60
        public void Create(){} // RVA: 0x283FA0
        public void GetHashCode(){} // RVA: 0xD840
        public void op_Equality(){} // RVA: 0x283FA0
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void ReferenceEquals(){} // RVA: 0x283FA0
    }

    public class StyleDataRef`1
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x40B3AA0
        public void Release(){} // RVA: 0x40B3AE0
        public void CopyFrom(){} // RVA: 0x40B3B70
        public void Read(){} // RVA: 0x40B3C90
        public void Write(){} // RVA: 0x40B3CB0
        public void Create(){} // RVA: 0x40B3ED0
        public void GetHashCode(){} // RVA: 0x40B3FB0
        public void op_Equality(){} // RVA: 0x40B4000
        public void Equals(){} // RVA: 0x40B41E0 | overloaded x2
        public void ReferenceEquals(){} // RVA: 0x40B42E0
    }

    public class StyleDataRef`1
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x40B3AA0
        public void Release(){} // RVA: 0x40B3AE0
        public void CopyFrom(){} // RVA: 0x40B42F0
        public void Read(){} // RVA: 0x40B3C90
        public void Write(){} // RVA: 0x40B4510
        public void Create(){} // RVA: 0x40B3ED0
        public void GetHashCode(){} // RVA: 0x40B4770
        public void op_Equality(){} // RVA: 0x40B47C0
        public void Equals(){} // RVA: 0x40B49E0 | overloaded x2
        public void ReferenceEquals(){} // RVA: 0x40B42E0
    }

    public class StyleDataRef`1
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x40B3AA0
        public void Release(){} // RVA: 0x40B3AE0
        public void CopyFrom(){} // RVA: 0x40B4AE0
        public void Read(){} // RVA: 0x40B3C90
        public void Write(){} // RVA: 0x40B4C00
        public void Create(){} // RVA: 0x40B3ED0
        public void GetHashCode(){} // RVA: 0x40B4DD0
        public void op_Equality(){} // RVA: 0x40B4E20
        public void Equals(){} // RVA: 0x40B5090 | overloaded x2
        public void ReferenceEquals(){} // RVA: 0x40B42E0
    }

    public class StyleDataRef`1
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x40B3AA0
        public void Release(){} // RVA: 0x40B3AE0
        public void CopyFrom(){} // RVA: 0x40B5190
        public void Read(){} // RVA: 0x40B3C90
        public void Write(){} // RVA: 0x40B52D0
        public void Create(){} // RVA: 0x40B3ED0
        public void GetHashCode(){} // RVA: 0x40B5440
        public void op_Equality(){} // RVA: 0x40B5490
        public void Equals(){} // RVA: 0x40B5610 | overloaded x2
        public void ReferenceEquals(){} // RVA: 0x40B42E0
    }

    public class StyleDataRef`1
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x40B3AA0
        public void Release(){} // RVA: 0x40B3AE0
        public void CopyFrom(){} // RVA: 0x40B5710
        public void Read(){} // RVA: 0x40B3C90
        public void Write(){} // RVA: 0x40B5830
        public void Create(){} // RVA: 0x40B3ED0
        public void GetHashCode(){} // RVA: 0x40B5A00
        public void op_Equality(){} // RVA: 0x40B5A50
        public void Equals(){} // RVA: 0x40B5BF0 | overloaded x2
        public void ReferenceEquals(){} // RVA: 0x40B42E0
    }

    public class StyleDataRef`1
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x40B3AA0
        public void Release(){} // RVA: 0x40B3AE0
        public void CopyFrom(){} // RVA: 0x40B5CF0
        public void Read(){} // RVA: 0x40B3C90
        public void Write(){} // RVA: 0x40B5E10
        public void Create(){} // RVA: 0x40B3ED0
        public void GetHashCode(){} // RVA: 0x40B60D0
        public void op_Equality(){} // RVA: 0x40B6120
        public void Equals(){} // RVA: 0x40B6340 | overloaded x2
        public void ReferenceEquals(){} // RVA: 0x40B42E0
    }

    public class StyleEnum`1
    {
        public T m_Value;
        public 0x6583D3C8 m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x283FA0
        public void get_keyword(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x3
        public void op_Equality(){} // RVA: 0x283FA0
        public void op_Inequality(){} // RVA: 0x283FA0
        public void op_Implicit(){} // RVA: 0x283FA0 | overloaded x2
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840
        public void ToString(){} // RVA: 0xCD60
    }

    public class StyleEnum`1
    {
        public T m_Value;
        public 0x6583D3C8 m_Keyword;
    }

    public class StyleFloat
    {
        public float m_Value; // 0x10
        public 0x6583D3C8 m_Keyword; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x7466AE0
        public void get_keyword(){} // RVA: 0x40B7110
        public void .ctor(){} // RVA: 0x2B60610 | overloaded x3
        public void op_Equality(){} // RVA: 0x7466B10
        public void op_Implicit(){} // RVA: 0x743BEF0 | overloaded x2
        public void Equals(){} // RVA: 0x7466B90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x743C020
        public void ToString(){} // RVA: 0x7466C40
    }

    public class StyleFont
    {
        public UnityEngine.Font m_Value; // 0x10
        public 0x6583D3C8 m_Keyword; // 0x18

        // ── Methods ──
        public void get_value(){} // RVA: 0x7466CB0
        public void get_keyword(){} // RVA: 0x3C4E030
        public void .ctor(){} // RVA: 0x501BB70 | overloaded x2
        public void op_Equality(){} // RVA: 0x7466D20
        public void op_Implicit(){} // RVA: 0x7466E70
        public void Equals(){} // RVA: 0x7467060 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7467100
        public void ToString(){} // RVA: 0x7467200
    }

    public class StyleFontDefinition
    {
        public 0x6583D3C8 m_Keyword; // 0x10
        public UnityEngine.UIElements.FontDefinition m_Value; // 0x18

        // ── Methods ──
        public void get_value(){} // RVA: 0x7467270
        public void get_keyword(){} // RVA: 0x67FD0D0
        public void .ctor(){} // RVA: 0x74672F0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7467350
        public void Equals(){} // RVA: 0x7467420 | overloaded x2
        public void GetHashCode(){} // RVA: 0x74674E0
    }

    public class StyleInt
    {
        public int m_Value; // 0x10
        public 0x6583D3C8 m_Keyword; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x40B7100
        public void get_keyword(){} // RVA: 0x40B7110
        public void .ctor(){} // RVA: 0x40B71A0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7467510
        public void op_Implicit(){} // RVA: 0x7466B40
        public void Equals(){} // RVA: 0x7467560 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7467600
        public void ToString(){} // RVA: 0x7467610
    }

    public class StyleLength
    {
        public UnityEngine.UIElements.Length m_Value; // 0x10
        public 0x6583D3C8 m_Keyword; // 0x18

        // ── Methods ──
        public void get_value(){} // RVA: 0x7467680
        public void get_keyword(){} // RVA: 0x3C4E030
        public void .ctor(){} // RVA: 0x7467740 | overloaded x4
        public void op_Equality(){} // RVA: 0x7467770
        public void op_Implicit(){} // RVA: 0x7467860 | overloaded x3
        public void Equals(){} // RVA: 0x7467910 | overloaded x2
        public void GetHashCode(){} // RVA: 0x74679F0
        public void ToString(){} // RVA: 0x7467A20
    }

    public class StyleMatchingContext
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet> m_StyleSheetStack; // 0x10

        // ── Methods ──
        public void get_styleSheetCount(){} // RVA: 0x732DB40
        public void .ctor(){} // RVA: 0x732DB90
        public void AddStyleSheet(){} // RVA: 0x732DEB0
        public void RemoveStyleSheetRange(){} // RVA: 0x732DFB0
        public void GetStyleSheetAt(){} // RVA: 0x732E020
    }

    public class StyleProperty
    {
        public string properties; // 0x10
        public int m_Line; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x33B6D40
        public void get_values(){} // RVA: 0x6A24380
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class StylePropertyAnimationSystem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x746A010
        public void GetOrCreate(){} // RVA: 0x283FA0
        public void StartTransition(){} // RVA: 0x746BD20 | overloaded x16
        public void CancelAllAnimations(){} // RVA: 0x746C090 | overloaded x2
        public void CancelAnimation(){} // RVA: 0x746C290
        public void UpdateAnimation(){} // RVA: 0x746C330
        public void GetAllAnimations(){} // RVA: 0x746C3D0
        public void UpdateTracking(){} // RVA: 0x24B10
        public void CurrentTimeMs(){} // RVA: 0x33B6D40
        public void Update(){} // RVA: 0x746C550
    }

    public class StylePropertyName
    {
        public 0x658446F0 <id>k__BackingField; // 0x10
        public string <name>k__BackingField; // 0x18

        // ── Methods ──
        public void get_id(){} // RVA: 0x19689B0
        public void get_name(){} // RVA: 0x19689C0
        public void StylePropertyIdFromString(){} // RVA: 0x7470FE0
        public void .ctor(){} // RVA: 0x7471220 | overloaded x2
        public void op_Equality(){} // RVA: 0x70A02E0
        public void op_Inequality(){} // RVA: 0x74713C0
        public void op_Implicit(){} // RVA: 0x74713D0
        public void GetHashCode(){} // RVA: 0x67FD0D0
        public void Equals(){} // RVA: 0x70A02E0 | overloaded x2
        public void ToString(){} // RVA: 0x5F1D510
    }

    public class StylePropertyNameCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x100A2F0
        public void GetEnumerator(){} // RVA: 0x73FA670
        public void System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator(){} // RVA: 0x73FA7F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x73FA860
    }

    public class StyleRotate
    {
        public UnityEngine.UIElements.Rotate m_Value; // 0x10
        public 0x6583D3C8 m_Keyword; // 0x28

        // ── Methods ──
        public void get_value(){} // RVA: 0x7467AA0
        public void get_keyword(){} // RVA: 0x3D92310
        public void .ctor(){} // RVA: 0x7467BB0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7467BD0
        public void op_Implicit(){} // RVA: 0x7467C60
        public void Equals(){} // RVA: 0x7467D20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7467E20
        public void ToString(){} // RVA: 0x7467E40
    }

    public class StyleRule
    {
        public UnityEngine.UIElements.StyleProperty[] m_Properties; // 0x10

        // ── Methods ──
        public void get_properties(){} // RVA: 0x33B6D40
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class StyleScale
    {
        public UnityEngine.UIElements.Scale m_Value; // 0x10
        public 0x6583D3C8 m_Keyword; // 0x20

        // ── Methods ──
        public void get_value(){} // RVA: 0x7467EC0
        public void get_keyword(){} // RVA: 0x70B92A0
        public void .ctor(){} // RVA: 0x37C5C40 | overloaded x2
        public void op_Equality(){} // RVA: 0x7467F90
        public void op_Implicit(){} // RVA: 0x7468000
        public void Equals(){} // RVA: 0x7468080 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7468150
        public void ToString(){} // RVA: 0x74681C0
    }

    public class StyleSelector
    {
        public UnityEngine.UIElements.StyleSelectorPart[] value; // 0x10
        public 0x6583EA78 type; // 0x18

        // ── Methods ──
        public void get_parts(){} // RVA: 0x33B6D40
        public void set_parts(){} // RVA: 0x2DEE30
        public void get_previousRelationship(){} // RVA: 0x3D92310
        public void set_previousRelationship(){} // RVA: 0x6374E0
        public void ToString(){} // RVA: 0x7472AF0
        public void .ctor(){} // RVA: 0x7472DC0
    }

    public class StyleSelectorPart
    {
        public string m_Value; // 0x10
        public 0x6583EAD0 m_Type; // 0x18

        // ── Methods ──
        public void get_value(){} // RVA: 0x2738C50
        public void get_type(){} // RVA: 0x3C4E030
        public void set_type(){} // RVA: 0x1EA98A0
        public void ToString(){} // RVA: 0x7472E90
        public void CreateClass(){} // RVA: 0x7472FC0
        public void CreateId(){} // RVA: 0x7473050
        public void CreatePredicate(){} // RVA: 0x74730E0
    }

    public class StyleSheet
    {
        public bool m_ImportedWithErrors; // 0x18
        public bool m_ImportedWithWarnings; // 0x19
        public UnityEngine.UIElements.StyleRule[] m_Rules; // 0x20
        public UnityEngine.UIElements.StyleComplexSelector[] m_ComplexSelectors; // 0x28
        public float[] floats; // 0x30
        public UnityEngine.UIElements.StyleSheets.Dimension[] dimensions; // 0x38
        public UnityEngine.Color[] colors; // 0x40

        // ── Methods ──
        public void get_importedWithErrors(){} // RVA: 0x7090430
        public void set_importedWithErrors(){} // RVA: 0x2F84F0
        public void get_importedWithWarnings(){} // RVA: 0x7473170
        public void set_importedWithWarnings(){} // RVA: 0xF43D70
        public void get_rules(){} // RVA: 0x6A24380
        public void set_rules(){} // RVA: 0x7473180
        public void get_complexSelectors(){} // RVA: 0x7145590
        public void set_complexSelectors(){} // RVA: 0x74731E0
        public void get_flattenedRecursiveImports(){} // RVA: 0x71880B0
        public void get_contentHash(){} // RVA: 0x7473240
        public void set_contentHash(){} // RVA: 0x1C91450
        public void get_isDefaultStyleSheet(){} // RVA: 0x7473250
        public void set_isDefaultStyleSheet(){} // RVA: 0x7473260
        public void TryCheckAccess(){} // RVA: 0x283FA0
        public void CheckAccess(){} // RVA: 0x283FA0
        public void OnEnable(){} // RVA: 0x74733C0
        public void FlattenImportedStyleSheetsRecursive(){} // RVA: 0x74734A0 | overloaded x2
        public void SetupReferences(){} // RVA: 0x7473630
        public void ReadKeyword(){} // RVA: 0x7312CE0
        public void ReadFloat(){} // RVA: 0x7473D40
        public void TryReadFloat(){} // RVA: 0x7473E20
        public void ReadDimension(){} // RVA: 0x7473F30
        public void TryReadDimension(){} // RVA: 0x7474010
        public void ReadColor(){} // RVA: 0x7474130
        public void TryReadColor(){} // RVA: 0x74741E0
        public void ReadString(){} // RVA: 0x7474280
        public void TryReadString(){} // RVA: 0x7474300
        public void ReadEnum(){} // RVA: 0x74743A0
        public void TryReadEnum(){} // RVA: 0x7474420
        public void ReadVariable(){} // RVA: 0x74744C0
        public void TryReadVariable(){} // RVA: 0x7474540
        public void ReadResourcePath(){} // RVA: 0x74745E0
        public void TryReadResourcePath(){} // RVA: 0x7474660
        public void ReadAssetReference(){} // RVA: 0x7474700
        public void ReadMissingAssetReferenceUrl(){} // RVA: 0x7474780
        public void TryReadAssetReference(){} // RVA: 0x7474800
        public void ReadFunction(){} // RVA: 0x7312CE0
        public void ReadFunctionName(){} // RVA: 0x74748A0
        public void ReadScalableImage(){} // RVA: 0x7474B40
        public void CustomStartsWith(){} // RVA: 0x7474BF0
        public void .ctor(){} // RVA: 0x53BFB0
        public void .cctor(){} // RVA: 0x7474CD0
    }

    public class StyleTextShadow
    {
        public 0x6583D3C8 m_Keyword; // 0x10
        public UnityEngine.UIElements.TextShadow m_Value; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x74685F0
        public void get_keyword(){} // RVA: 0x67FD0D0
        public void .ctor(){} // RVA: 0x7468670 | overloaded x2
        public void op_Equality(){} // RVA: 0x7468690
        public void op_Implicit(){} // RVA: 0x7468790
        public void Equals(){} // RVA: 0x7468810 | overloaded x2
        public void GetHashCode(){} // RVA: 0x74688C0
        public void ToString(){} // RVA: 0x7468950
    }

    public class StyleTransformOrigin
    {
        public UnityEngine.UIElements.TransformOrigin m_Value; // 0x10
        public 0x6583D3C8 m_Keyword; // 0x24

        // ── Methods ──
        public void get_value(){} // RVA: 0x74689D0
        public void get_keyword(){} // RVA: 0x2EE0010
        public void .ctor(){} // RVA: 0x5B58C20 | overloaded x2
        public void op_Equality(){} // RVA: 0x7468AF0
        public void op_Implicit(){} // RVA: 0x7466070
        public void Equals(){} // RVA: 0x7468CD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7468D70
        public void ToString(){} // RVA: 0x7468D90
    }

    public class StyleTranslate
    {
        public UnityEngine.UIElements.Translate m_Value; // 0x10
        public 0x6583D3C8 m_Keyword; // 0x28

        // ── Methods ──
        public void get_value(){} // RVA: 0x7468230
        public void get_keyword(){} // RVA: 0x3D92310
        public void .ctor(){} // RVA: 0x7467BB0 | overloaded x3
        public void op_Equality(){} // RVA: 0x7468300
        public void op_Implicit(){} // RVA: 0x7468390 | overloaded x2
        public void Equals(){} // RVA: 0x7468450 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7468550
        public void ToString(){} // RVA: 0x7468570
    }

    public class StyleValueCollection
    {
        // ── Methods ──
        public void GetStyleLength(){} // RVA: 0x7464A60
        public void GetStyleFloat(){} // RVA: 0x7464B10
        public void GetStyleInt(){} // RVA: 0x7464B80
        public void TryGetStyleValue(){} // RVA: 0x7464C00
        public void SetStyleValue(){} // RVA: 0x7464DA0
        public void .ctor(){} // RVA: 0x7464FB0
    }

    public class StyleValueExtensions
    {
        // ── Methods ──
        public void DebugString(){} // RVA: 0xCE50
        public void ToYogaValue(){} // RVA: 0x7468E10
        public void ToLength(){} // RVA: 0x7469410 | overloaded x2
        public void ToRotate(){} // RVA: 0x74690D0
        public void ToScale(){} // RVA: 0x74691F0
        public void ToTranslate(){} // RVA: 0x7469300
        public void CopyFrom(){} // RVA: 0x24D50
    }

    public class StyleValueFunctionExtension
    {
        // ── Methods ──
        public void ToUssString(){} // RVA: 0x7474D80
    }

    public class StyleValueHandle
    {
        public 0x6583ED90 m_ValueType; // 0x10

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x67FD0D0
        public void set_valueType(){} // RVA: 0x833580
    }

    public class StyleValueKeywordExtension
    {
        // ── Methods ──
        public void ToUssString(){} // RVA: 0x7474EA0
    }

    public class StyleVariable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19D8110
        public void GetHashCode(){} // RVA: 0x7475060
    }

    public class StyleVariableContext
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7475100
        public void AddInitialRange(){} // RVA: 0x7475260
        public void Clear(){} // RVA: 0x74753A0
        public void .ctor(){} // RVA: 0x74755B0 | overloaded x2
        public void TryFindVariable(){} // RVA: 0x7475740
        public void GetVariableHash(){} // RVA: 0x70B92A0
        public void .cctor(){} // RVA: 0x7475890
    }

    public class StyleVariableResolver
    {
        public int kMaxResolves;
        public UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser s_SyntaxParser;
        public UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher m_Matcher; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_ResolvedValues; // 0x18

        // ── Methods ──
        public void get_currentSheet(){} // RVA: 0x4976A0
        public void get_currentHandles(){} // RVA: 0x35A740
        public void get_resolvedValues(){} // RVA: 0x2E07C0
        public void get_variableContext(){} // RVA: 0x358730
        public void set_variableContext(){} // RVA: 0x358740
        public void Init(){} // RVA: 0x7475940
        public void PushContext(){} // RVA: 0x7475A60
        public void PopContext(){} // RVA: 0x7475CA0
        public void AddValue(){} // RVA: 0x7475E70
        public void ResolveVarFunction(){} // RVA: 0x74760C0 | overloaded x2
        public void ValidateResolvedValues(){} // RVA: 0x7476250
        public void ResolveVariable(){} // RVA: 0x7476440
        public void ResolveFallback(){} // RVA: 0x7476890
        public void ParseVarFunction(){} // RVA: 0x7476BC0
        public void .ctor(){} // RVA: 0x7476CB0
        public void .cctor(){} // RVA: 0x7477000
    }

}