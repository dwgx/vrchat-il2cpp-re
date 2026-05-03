// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 48
// Methods: 524

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class SafeHandleAccess : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82889220
        public void IsNull(){} // RVA: 0x7FFE87F56750
        public void op_Implicit(){} // RVA: 0x7FFE87F56760
    }

    public class SavePersistentViewData : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81159980
        public void Invoke(){} // RVA: 0x7FFE81159A50
    }

    public class Scale : ValueType
    {
        public UnityEngine.Vector3 m_Scale; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FA5CD0
        public void Initial(){} // RVA: 0x7FFE87FA5D70
        public void None(){} // RVA: 0x7FFE87FA5E80
        public void get_value(){} // RVA: 0x7FFE835C1D60
        public void op_Equality(){} // RVA: 0x7FFE87FA5EC0
        public void op_Inequality(){} // RVA: 0x7FFE87FA5F20
        public void Equals(){} // RVA: 0x7FFE87FA5FC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA6090
        public void ToString(){} // RVA: 0x7FFE87C57810
    }

    public class ScheduledItem : Object
    {
        public System.Func`1<bool> timerUpdateStopCondition; // 0x10
        public System.Func`1<bool> OnceCondition;
        public System.Func`1<bool> ForeverCondition; // 0x8
        public long _startMs; // 0x18

        // ── Methods ──
        public void get_startMs(){} // RVA: 0x7FFE810FE7C0
        public void set_startMs(){} // RVA: 0x7FFE819EA910
        public void get_delayMs(){} // RVA: 0x7FFE811290C0
        public void set_delayMs(){} // RVA: 0x7FFE81859C50
        public void get_intervalMs(){} // RVA: 0x7FFE81129130
        public void set_intervalMs(){} // RVA: 0x7FFE8164D390
        public void get_endTimeMs(){} // RVA: 0x7FFE8144E200
        public void .ctor(){} // RVA: 0x7FFE87F7A8D0
        public void ResetStartTime(){} // RVA: 0x7FFE87F7A9C0
        public void PerformTimerUpdate(){}
        public void OnItemUnscheduled(){} // RVA: 0x7FFE810FB310
        public void ShouldUnschedule(){} // RVA: 0x7FFE87F7AA10
        public void .cctor(){} // RVA: 0x7FFE87F7AA40
    }

    public class ScrollView : VisualElement
    {
        public int m_FirstLayoutPass; // 0x3C8
        public 0x66512204 m_HorizontalScrollerVisibility; // 0x3CC
        public 0x66512204 m_VerticalScrollerVisibility; // 0x3D0
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
        public 0x6651230C m_TouchScrollBehavior; // 0x404
        public 0x66512364 m_NestedInteractionKind; // 0x408
        public long k_DefaultElasticAnimationInterval; // 0x8
        public long m_ElasticAnimationIntervalMs; // 0x410
        public UnityEngine.UIElements.VisualElement _contentViewport; // 0x418
        public UnityEngine.UIElements.Scroller _horizontalScroller; // 0x420
        public UnityEngine.UIElements.Scroller _verticalScroller; // 0x428
        public UnityEngine.UIElements.VisualElement m_ContentContainer; // 0x430
        public UnityEngine.UIElements.VisualElement m_ContentAndVerticalScrollContainer; // 0x438
        public float previousVerticalTouchScrollTimeStamp; // 0x440

        // ── Methods ──
        public void get_horizontalScrollerVisibility(){} // RVA: 0x7FFE87EFF5A0
        public void set_horizontalScrollerVisibility(){} // RVA: 0x7FFE87EFF5B0
        public void get_verticalScrollerVisibility(){} // RVA: 0x7FFE87EFF650
        public void set_verticalScrollerVisibility(){} // RVA: 0x7FFE87EFF660
        public void set_showHorizontal(){} // RVA: 0x7FFE87EFF710
        public void set_showVertical(){} // RVA: 0x7FFE87EFF730
        public void get_needsHorizontal(){} // RVA: 0x7FFE87EFF750
        public void get_needsVertical(){} // RVA: 0x7FFE87EFF7A0
        public void get_isVerticalScrollDisplayed(){} // RVA: 0x7FFE87EFF7F0
        public void get_isHorizontalScrollDisplayed(){} // RVA: 0x7FFE87EFF850
        public void get_scrollOffset(){} // RVA: 0x7FFE87EFF8B0
        public void set_scrollOffset(){} // RVA: 0x7FFE87EFF930
        public void set_horizontalPageSize(){} // RVA: 0x7FFE87EFFAB0
        public void set_verticalPageSize(){} // RVA: 0x7FFE87EFFAC0
        public void get_mouseWheelScrollSize(){} // RVA: 0x7FFE860939F0
        public void set_mouseWheelScrollSize(){} // RVA: 0x7FFE87EFFAD0
        public void get_scrollableWidth(){} // RVA: 0x7FFE87EFFB60
        public void get_scrollableHeight(){} // RVA: 0x7FFE87EFFBF0
        public void get_hasInertia(){} // RVA: 0x7FFE87EFFC80
        public void get_scrollDecelerationRate(){} // RVA: 0x7FFE87EFFCA0
        public void set_scrollDecelerationRate(){} // RVA: 0x7FFE87EFFCB0
        public void get_elasticity(){} // RVA: 0x7FFE87EFFCD0
        public void set_elasticity(){} // RVA: 0x7FFE87EFFCE0
        public void get_touchScrollBehavior(){} // RVA: 0x7FFE87EFFD00
        public void set_touchScrollBehavior(){} // RVA: 0x7FFE87EFFD10
        public void get_nestedInteractionKind(){} // RVA: 0x7FFE87EFFDE0
        public void set_nestedInteractionKind(){} // RVA: 0x7FFE87EFFDF0
        public void set_elasticAnimationIntervalMs(){} // RVA: 0x7FFE87EFFE00
        public void OnHorizontalScrollDragElementChanged(){} // RVA: 0x7FFE87EFFF30
        public void OnVerticalScrollDragElementChanged(){} // RVA: 0x7FFE87EFFFA0
        public void UpdateHorizontalSliderPageSize(){} // RVA: 0x7FFE87F00010
        public void UpdateVerticalSliderPageSize(){} // RVA: 0x7FFE87F00130
        public void UpdateContentViewTransform(){} // RVA: 0x7FFE87F00250
        public void ScrollTo(){} // RVA: 0x7FFE87F004E0
        public void GetXDeltaOffset(){} // RVA: 0x7FFE87F00740
        public void GetYDeltaOffset(){} // RVA: 0x7FFE87F00960
        public void GetDeltaDistance(){} // RVA: 0x7FFE87F00B80
        public void get_contentViewport(){} // RVA: 0x7FFE81B23520
        public void get_horizontalScroller(){} // RVA: 0x7FFE81B33330
        public void get_verticalScroller(){} // RVA: 0x7FFE81B2E4C0
        public void get_contentContainer(){} // RVA: 0x7FFE87F00BF0
        public void .ctor(){} // RVA: 0x7FFE87F00C10 | overloaded x2
        public void get_mode(){} // RVA: 0x7FFE87F01DD0
        public void set_mode(){} // RVA: 0x7FFE87F01DE0
        public void SetScrollViewMode(){} // RVA: 0x7FFE87F01E00
        public void OnAttachToPanel(){} // RVA: 0x7FFE87F02270
        public void OnDetachFromPanel(){} // RVA: 0x7FFE87F02770
        public void OnPointerCapture(){} // RVA: 0x7FFE87F02C50
        public void OnPointerCaptureOut(){} // RVA: 0x7FFE87F02DC0
        public void OnGeometryChanged(){} // RVA: 0x7FFE87F02EE0
        public void ScheduleResetLayoutPass(){} // RVA: 0x7FFE87F031E0
        public void ResetLayoutPass(){} // RVA: 0x7FFE87F03320
        public void ComputeElasticOffset(){} // RVA: 0x7FFE87F03330
        public void ComputeInitialSpringBackVelocity(){} // RVA: 0x7FFE87F034A0
        public void SpringBack(){} // RVA: 0x7FFE87F03600
        public void ApplyScrollInertia(){} // RVA: 0x7FFE87F03800
        public void PostPointerUpAnimation(){} // RVA: 0x7FFE87F03D00
        public void OnPointerDown(){} // RVA: 0x7FFE87F03FA0
        public void OnPointerMove(){} // RVA: 0x7FFE87F04270
        public void OnPointerCancel(){} // RVA: 0x7FFE87F04530
        public void OnPointerUp(){} // RVA: 0x7FFE87F04590
        public void InitTouchScrolling(){} // RVA: 0x7FFE87F04680
        public void ComputeTouchScrolling(){} // RVA: 0x7FFE87F049F0
        public void ApplyTouchScrolling(){} // RVA: 0x7FFE87F04E10
        public void ReleaseScrolling(){} // RVA: 0x7FFE87F05140
        public void ExecuteElasticSpringAnimation(){} // RVA: 0x7FFE87F05310
        public void AdjustScrollers(){} // RVA: 0x7FFE87F055B0
        public void UpdateScrollers(){} // RVA: 0x7FFE87F05780
        public void OnScrollersGeometryChanged(){} // RVA: 0x7FFE87F05BC0
        public void OnScrollWheel(){} // RVA: 0x7FFE87F05DA0
        public void OnRootCustomStyleResolved(){} // RVA: 0x7FFE87F062E0
        public void ReadSingleLineHeight(){} // RVA: 0x7FFE87F062F0
        public void UpdateElasticBehaviour(){} // RVA: 0x7FFE87F064F0
        public void .cctor(){} // RVA: 0x7FFE87F067B0
        public void <.ctor>b__126_0(){} // RVA: 0x7FFE87F071C0
        public void <.ctor>b__126_1(){} // RVA: 0x7FFE87F07210
    }

    public class Scroller : VisualElement
    {
        public System.Action`1<float> valueChanged; // 0x3C8
        public UnityEngine.UIElements.Slider _slider; // 0x3D0
        public UnityEngine.UIElements.RepeatButton _lowButton; // 0x3D8
        public UnityEngine.UIElements.RepeatButton _highButton; // 0x3E0
        public string ussClassName;
        public string horizontalVariantUssClassName; // 0x8
        public string verticalVariantUssClassName; // 0x10

        // ── Methods ──
        public void add_valueChanged(){} // RVA: 0x7FFE87EFD880
        public void remove_valueChanged(){} // RVA: 0x7FFE87EFD980
        public void get_slider(){} // RVA: 0x7FFE81B0DE50
        public void set_slider(){} // RVA: 0x7FFE81B35840
        public void get_lowButton(){} // RVA: 0x7FFE81B0E4A0
        public void set_lowButton(){} // RVA: 0x7FFE81B2FC80
        public void get_highButton(){} // RVA: 0x7FFE81B2A270
        public void set_highButton(){} // RVA: 0x7FFE81B30C40
        public void get_value(){} // RVA: 0x7FFE87EFDA80
        public void set_value(){} // RVA: 0x7FFE87EFDAB0
        public void get_lowValue(){} // RVA: 0x7FFE87EFDAE0
        public void set_lowValue(){} // RVA: 0x7FFE87EFDB30
        public void get_highValue(){} // RVA: 0x7FFE87EFDB90
        public void set_highValue(){} // RVA: 0x7FFE87EFDBE0
        public void set_direction(){} // RVA: 0x7FFE87EFDC40
        public void .ctor(){} // RVA: 0x7FFE87EFDE50 | overloaded x2
        public void Adjust(){} // RVA: 0x7FFE87EFE400
        public void OnSliderValueChange(){} // RVA: 0x7FFE87EFE490
        public void ScrollPageUp(){} // RVA: 0x7FFE87EFE750 | overloaded x2
        public void ScrollPageDown(){} // RVA: 0x7FFE87EFE850 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87EFE950
    }

    public class SerializedVirtualizationData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SetupDragAndDropArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F1A550
    }

    public class Slider : BaseSlider`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F086E0 | overloaded x3
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87F08850
        public void SliderLerpUnclamped(){} // RVA: 0x7FFE87F08A20
        public void SliderNormalizeValue(){} // RVA: 0x7FFE87EEA160
        public void ParseStringToValue(){} // RVA: 0x7FFE87F08BE0
        public void ComputeValueFromKey(){} // RVA: 0x7FFE87F08C70
        public void .cctor(){} // RVA: 0x7FFE87F08EF0
    }

    public class SliderInt : BaseSlider`1
    {
        public string ussClassName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F09C50 | overloaded x2
        public void get_pageSize(){} // RVA: 0x7FFE87F09DC0
        public void set_pageSize(){} // RVA: 0x7FFE87F09E10
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87F09E70
        public void SliderLerpUnclamped(){} // RVA: 0x7FFE87F0A030
        public void SliderNormalizeValue(){} // RVA: 0x7FFE87F0A050
        public void ParseStringToValue(){} // RVA: 0x7FFE87F0A080
        public void ComputeValueAndDirectionFromClick(){} // RVA: 0x7FFE87F0A160
        public void ComputeValueFromKey(){} // RVA: 0x7FFE87F0A3F0
        public void .cctor(){} // RVA: 0x7FFE87F0A670
    }

    public class SortColumnDescription : Object
    {
        public int m_ColumnIndex; // 0x10
        public string m_ColumnName; // 0x18
        public 0x665117B4 m_SortDirection; // 0x20
        public UnityEngine.UIElements.Column _column; // 0x28

        // ── Methods ──
        public void get_columnName(){} // RVA: 0x7FFE810FE7C0
        public void set_columnName(){} // RVA: 0x7FFE87EF7D30
        public void get_columnIndex(){} // RVA: 0x7FFE811485C0
        public void set_columnIndex(){} // RVA: 0x7FFE87EF7DF0
        public void get_column(){} // RVA: 0x7FFE81129130
        public void set_column(){} // RVA: 0x7FFE810FCE90
        public void get_direction(){} // RVA: 0x7FFE8151D690
        public void set_direction(){} // RVA: 0x7FFE87EF7E20
        public void add_changed(){} // RVA: 0x7FFE87EF7E50
        public void remove_changed(){} // RVA: 0x7FFE87EF7F50
        public void .ctor(){} // RVA: 0x7FFE87EF80C0 | overloaded x3
    }

    public class SortColumnDescriptions : Object
    {
        public System.Collections.Generic.IList`1<UnityEngine.UIElements.SortColumnDescription> m_Descriptions; // 0x10
        public System.Action changed; // 0x18

        // ── Methods ──
        public void add_changed(){} // RVA: 0x7FFE87EF8110
        public void remove_changed(){} // RVA: 0x7FFE87EF8200
        public void GetEnumerator(){} // RVA: 0x7FFE87EF82F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87EF82F0
        public void Add(){} // RVA: 0x7FFE87EF8340
        public void Clear(){} // RVA: 0x7FFE87EF83B0
        public void Contains(){} // RVA: 0x7FFE87EF8540
        public void CopyTo(){} // RVA: 0x7FFE87EF85A0
        public void Remove(){} // RVA: 0x7FFE87EF8680
        public void OnDescriptionChanged(){} // RVA: 0x7FFE8148FF70
        public void get_Count(){} // RVA: 0x7FFE87EF88C0
        public void get_IsReadOnly(){} // RVA: 0x7FFE87EF8910
        public void Insert(){} // RVA: 0x7FFE87EF8960
        public void .ctor(){} // RVA: 0x7FFE87EF8C80
    }

    public class Spacing : ValueType
    {
        public float left; // 0x10
        public float top; // 0x14

        // ── Methods ──
        public void get_horizontal(){} // RVA: 0x7FFE87C0EDF0
        public void get_vertical(){} // RVA: 0x7FFE87C0EE10
        public void .ctor(){} // RVA: 0x7FFE8111F570
        public void op_Subtraction(){} // RVA: 0x7FFE87F7BFA0
    }

    public class StartDragArgs : ValueType
    {
        public string _title; // 0x10
        public 0x6651390C _visualMode; // 0x18
        public System.Collections.Hashtable _genericData; // 0x20
        public System.Collections.Generic.IEnumerable`1<UnityEngine.Object> _unityObjectReferences; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F1A6D0
        public void get_title(){} // RVA: 0x7FFE8284EF60
        public void get_visualMode(){} // RVA: 0x7FFE82C33000
        public void get_genericData(){} // RVA: 0x7FFE81116380
        public void set_genericData(){} // RVA: 0x7FFE810FCE30
        public void get_unityObjectReferences(){} // RVA: 0x7FFE810FE7C0
        public void set_unityObjectReferences(){} // RVA: 0x7FFE81161E80
        public void SetGenericData(){} // RVA: 0x7FFE87F1A7E0
    }

    public class StyleBackgroundSize : ValueType
    {
        public UnityEngine.UIElements.BackgroundSize m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x24

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87FA60F0
        public void get_keyword(){} // RVA: 0x7FFE83BAF260
        public void .ctor(){} // RVA: 0x7FFE86699A50 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87FA6130
        public void op_Implicit(){} // RVA: 0x7FFE87FA6210
        public void Equals(){} // RVA: 0x7FFE87FA6320 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA63C0
        public void ToString(){} // RVA: 0x7FFE87FA6430
    }

    public class StyleCache : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFE87E6CE70 | overloaded x3
        public void SetValue(){} // RVA: 0x7FFE87E6CF10 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE87E6CFC0
    }

    public class StyleColor : ValueType
    {
        public UnityEngine.Color m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x20

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87FA64B0
        public void get_keyword(){} // RVA: 0x7FFE87BFA280
        public void .ctor(){} // RVA: 0x7FFE84456680 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87FA64D0
        public void op_Implicit(){} // RVA: 0x7FFE87FA6550
        public void Equals(){} // RVA: 0x7FFE87FA65F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA66E0
        public void ToString(){} // RVA: 0x7FFE87FA6700
    }

    public class StyleComplexSelector : Object
    {
        public UnityEngine.UIElements.Hashes ancestorHashes; // 0x10
        public int m_Specificity; // 0x20
        public UnityEngine.UIElements.StyleRule _rule; // 0x28
        public bool m_isSimple; // 0x30

        // ── Methods ──
        public void get_specificity(){} // RVA: 0x7FFE850173A0
        public void get_rule(){} // RVA: 0x7FFE81129130
        public void set_rule(){} // RVA: 0x7FFE810FCE90
        public void get_isSimple(){} // RVA: 0x7FFE87C86210
        public void get_selectors(){} // RVA: 0x7FFE87CC7F60
        public void set_selectors(){} // RVA: 0x7FFE87FB1630
        public void OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void OnAfterDeserialize(){} // RVA: 0x7FFE87FB16A0
        public void CachePseudoStateMasks(){} // RVA: 0x7FFE87FB16D0
        public void ToString(){} // RVA: 0x7FFE87FB1F60
        public void StyleSelectorPartCompare(){} // RVA: 0x7FFE87FB22A0
        public void CalculateHashes(){} // RVA: 0x7FFE87FB22F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87FB2AF0
    }

    public class StyleCursor : ValueType
    {
        public UnityEngine.UIElements.Cursor m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x28

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87FA6770
        public void get_keyword(){} // RVA: 0x7FFE84A02990
        public void .ctor(){} // RVA: 0x7FFE87FA6830 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87FA68A0
        public void op_Implicit(){} // RVA: 0x7FFE87FA69A0
        public void Equals(){} // RVA: 0x7FFE87FA6B40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA6BE0
        public void ToString(){} // RVA: 0x7FFE87FA6C00
    }

    public class StyleDataRef`1 : ValueType
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFE810A1420
        public void Release(){} // RVA: 0x7FFE80E45FE0
        public void CopyFrom(){} // RVA: 0x7FFE810A1420
        public void Read(){} // RVA: 0x7FFE80E2E2E0
        public void Write(){} // RVA: 0x7FFE80E2E2E0
        public void Create(){} // RVA: 0x7FFE810A1420
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void op_Equality(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void ReferenceEquals(){} // RVA: 0x7FFE810A1420
    }

    public class StyleEnum`1 : ValueType
    {
        public T m_Value;
        public 0x6651B36C m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE810A1420
        public void get_keyword(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void op_Equality(){} // RVA: 0x7FFE810A1420
        public void op_Inequality(){} // RVA: 0x7FFE810A1420
        public void op_Implicit(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
    }

    public class StyleFloat : ValueType
    {
        public float m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87FA6C80
        public void get_keyword(){} // RVA: 0x7FFE84D2D330
        public void .ctor(){} // RVA: 0x7FFE838423C0 | overloaded x3
        public void op_Equality(){} // RVA: 0x7FFE87FA6CB0
        public void op_Implicit(){} // RVA: 0x7FFE87F7C090 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE87FA6D30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87F7C1C0
        public void ToString(){} // RVA: 0x7FFE87FA6DE0
    }

    public class StyleFont : ValueType
    {
        public UnityEngine.Font m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x18

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87FA6E50
        public void get_keyword(){} // RVA: 0x7FFE848C3400
        public void .ctor(){} // RVA: 0x7FFE85A7EE00 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87FA6EC0
        public void op_Implicit(){} // RVA: 0x7FFE87FA7010
        public void Equals(){} // RVA: 0x7FFE87FA7200 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA72A0
        public void ToString(){} // RVA: 0x7FFE87FA73A0
    }

    public class StyleFontDefinition : ValueType
    {
        public 0x6651B36C m_Keyword; // 0x10
        public UnityEngine.UIElements.FontDefinition m_Value; // 0x18

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87FA7410
        public void get_keyword(){} // RVA: 0x7FFE8733C3B0
        public void .ctor(){} // RVA: 0x7FFE87FA7490 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE87FA74F0
        public void Equals(){} // RVA: 0x7FFE87FA75C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA7680
    }

    public class StyleInt : ValueType
    {
        public int m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE84D2D320
        public void get_keyword(){} // RVA: 0x7FFE84D2D330
        public void .ctor(){} // RVA: 0x7FFE84D2D3C0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87FA76B0
        public void op_Implicit(){} // RVA: 0x7FFE87FA6CE0
        public void Equals(){} // RVA: 0x7FFE87FA7700 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA77A0
        public void ToString(){} // RVA: 0x7FFE87FA77B0
    }

    public class StyleLength : ValueType
    {
        public UnityEngine.UIElements.Length m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x18

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87FA7820
        public void get_keyword(){} // RVA: 0x7FFE848C3400
        public void .ctor(){} // RVA: 0x7FFE87FA78E0 | overloaded x4
        public void op_Equality(){} // RVA: 0x7FFE87FA7910
        public void op_Implicit(){} // RVA: 0x7FFE87FA7A00 | overloaded x3
        public void Equals(){} // RVA: 0x7FFE87FA7AB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA7B90
        public void ToString(){} // RVA: 0x7FFE87FA7BC0
    }

    public class StyleMatchingContext : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet> m_StyleSheetStack; // 0x10

        // ── Methods ──
        public void get_styleSheetCount(){} // RVA: 0x7FFE87E6DCC0
        public void .ctor(){} // RVA: 0x7FFE87E6DD10
        public void AddStyleSheet(){} // RVA: 0x7FFE87E6E030
        public void RemoveStyleSheetRange(){} // RVA: 0x7FFE87E6E130
        public void GetStyleSheetAt(){} // RVA: 0x7FFE87E6E1A0
    }

    public class StyleProperty : Object
    {
        public string m_Name; // 0x10
        public int m_Line; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE84022BE0
        public void get_values(){} // RVA: 0x7FFE87563690
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StylePropertyAnimationSystem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FAA1B0
        public void GetOrCreate(){} // RVA: 0x7FFE810A1420
        public void StartTransition(){} // RVA: 0x7FFE87FABEC0 | overloaded x16
        public void CancelAllAnimations(){} // RVA: 0x7FFE87FAC230 | overloaded x2
        public void CancelAnimation(){} // RVA: 0x7FFE87FAC430
        public void UpdateAnimation(){} // RVA: 0x7FFE87FAC4D0
        public void GetAllAnimations(){} // RVA: 0x7FFE87FAC570
        public void UpdateTracking(){} // RVA: 0x7FFE80E460A0
        public void CurrentTimeMs(){} // RVA: 0x7FFE84022BE0
        public void Update(){} // RVA: 0x7FFE87FAC6F0
    }

    public class StylePropertyName : ValueType
    {
        public 0x66522694 _id; // 0x10
        public string _name; // 0x18

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFE826F4220
        public void get_name(){} // RVA: 0x7FFE826F4210
        public void StylePropertyIdFromString(){} // RVA: 0x7FFE87FB1180
        public void .ctor(){} // RVA: 0x7FFE87FB13C0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87BE11A0
        public void op_Inequality(){} // RVA: 0x7FFE87FB1560
        public void op_Implicit(){} // RVA: 0x7FFE87FB1570
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
        public void Equals(){} // RVA: 0x7FFE87BE11A0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE86A5E330
    }

    public class StylePropertyNameCollection : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void GetEnumerator(){} // RVA: 0x7FFE87F3A810
        public void System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator(){} // RVA: 0x7FFE87F3A990
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87F3AA00
    }

    public class StyleRotate : ValueType
    {
        public UnityEngine.UIElements.Rotate m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x28

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87FA7C40
        public void get_keyword(){} // RVA: 0x7FFE84A02990
        public void .ctor(){} // RVA: 0x7FFE87FA7D50 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87FA7D70
        public void op_Implicit(){} // RVA: 0x7FFE87FA7E00
        public void Equals(){} // RVA: 0x7FFE87FA7EC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA7FC0
        public void ToString(){} // RVA: 0x7FFE87FA7FE0
    }

    public class StyleRule : Object
    {
        public UnityEngine.UIElements.StyleProperty[] m_Properties; // 0x10

        // ── Methods ──
        public void get_properties(){} // RVA: 0x7FFE84022BE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StyleScale : ValueType
    {
        public UnityEngine.UIElements.Scale m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x20

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87FA8060
        public void get_keyword(){} // RVA: 0x7FFE87BFA280
        public void .ctor(){} // RVA: 0x7FFE84456680 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87FA8130
        public void op_Implicit(){} // RVA: 0x7FFE87FA81A0
        public void Equals(){} // RVA: 0x7FFE87FA8220 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA82F0
        public void ToString(){} // RVA: 0x7FFE87FA8360
    }

    public class StyleSelector : Object
    {
        public UnityEngine.UIElements.StyleSelectorPart[] m_Parts; // 0x10
        public 0x6651CA1C m_PreviousRelationship; // 0x18

        // ── Methods ──
        public void get_parts(){} // RVA: 0x7FFE84022BE0
        public void set_parts(){} // RVA: 0x7FFE810FCE30
        public void get_previousRelationship(){} // RVA: 0x7FFE84A02990
        public void set_previousRelationship(){} // RVA: 0x7FFE8144DF00
        public void ToString(){} // RVA: 0x7FFE87FB2C90
        public void .ctor(){} // RVA: 0x7FFE87FB2F60
    }

    public class StyleSelectorPart : ValueType
    {
        public string m_Value; // 0x10
        public 0x6651CA74 m_Type; // 0x18

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE8348B260
        public void get_type(){} // RVA: 0x7FFE848C3400
        public void set_type(){} // RVA: 0x7FFE82C33010
        public void ToString(){} // RVA: 0x7FFE87FB3030
        public void CreateClass(){} // RVA: 0x7FFE87FB3160
        public void CreateId(){} // RVA: 0x7FFE87FB31F0
        public void CreatePredicate(){} // RVA: 0x7FFE87FB3280
    }

    public class StyleSheet : ScriptableObject
    {
        public bool m_ImportedWithErrors; // 0x18
        public bool m_ImportedWithWarnings; // 0x19
        public UnityEngine.UIElements.StyleRule[] m_Rules; // 0x20
        public UnityEngine.UIElements.StyleComplexSelector[] m_ComplexSelectors; // 0x28
        public float[] floats; // 0x30
        public UnityEngine.UIElements.StyleSheets.Dimension[] dimensions; // 0x38
        public UnityEngine.Color[] colors; // 0x40

        // ── Methods ──
        public void get_importedWithErrors(){} // RVA: 0x7FFE87BD12F0
        public void set_importedWithErrors(){} // RVA: 0x7FFE811164F0
        public void get_importedWithWarnings(){} // RVA: 0x7FFE87FB3310
        public void set_importedWithWarnings(){} // RVA: 0x7FFE81CD0510
        public void get_rules(){} // RVA: 0x7FFE87563690
        public void set_rules(){} // RVA: 0x7FFE87FB3320
        public void get_complexSelectors(){} // RVA: 0x7FFE87C86200
        public void set_complexSelectors(){} // RVA: 0x7FFE87FB3380
        public void get_flattenedRecursiveImports(){} // RVA: 0x7FFE87CC8250
        public void get_contentHash(){} // RVA: 0x7FFE87FB33E0
        public void set_contentHash(){} // RVA: 0x7FFE82A22F00
        public void get_isDefaultStyleSheet(){} // RVA: 0x7FFE87FB33F0
        public void set_isDefaultStyleSheet(){} // RVA: 0x7FFE87FB3400
        public void TryCheckAccess(){} // RVA: 0x7FFE810A1420
        public void CheckAccess(){} // RVA: 0x7FFE810A1420
        public void OnEnable(){} // RVA: 0x7FFE87FB3560
        public void FlattenImportedStyleSheetsRecursive(){} // RVA: 0x7FFE87FB3640 | overloaded x2
        public void SetupReferences(){} // RVA: 0x7FFE87FB37D0
        public void ReadKeyword(){} // RVA: 0x7FFE87E52E60
        public void ReadFloat(){} // RVA: 0x7FFE87FB3EE0
        public void TryReadFloat(){} // RVA: 0x7FFE87FB3FC0
        public void ReadDimension(){} // RVA: 0x7FFE87FB40D0
        public void TryReadDimension(){} // RVA: 0x7FFE87FB41B0
        public void ReadColor(){} // RVA: 0x7FFE87FB42D0
        public void TryReadColor(){} // RVA: 0x7FFE87FB4380
        public void ReadString(){} // RVA: 0x7FFE87FB4420
        public void TryReadString(){} // RVA: 0x7FFE87FB44A0
        public void ReadEnum(){} // RVA: 0x7FFE87FB4540
        public void TryReadEnum(){} // RVA: 0x7FFE87FB45C0
        public void ReadVariable(){} // RVA: 0x7FFE87FB4660
        public void TryReadVariable(){} // RVA: 0x7FFE87FB46E0
        public void ReadResourcePath(){} // RVA: 0x7FFE87FB4780
        public void TryReadResourcePath(){} // RVA: 0x7FFE87FB4800
        public void ReadAssetReference(){} // RVA: 0x7FFE87FB48A0
        public void ReadMissingAssetReferenceUrl(){} // RVA: 0x7FFE87FB4920
        public void TryReadAssetReference(){} // RVA: 0x7FFE87FB49A0
        public void ReadFunction(){} // RVA: 0x7FFE87E52E60
        public void ReadFunctionName(){} // RVA: 0x7FFE87FB4A40
        public void ReadScalableImage(){} // RVA: 0x7FFE87FB4CE0
        public void CustomStartsWith(){} // RVA: 0x7FFE87FB4D90
        public void .ctor(){} // RVA: 0x7FFE81345B60
        public void .cctor(){} // RVA: 0x7FFE87FB4E70
    }

    public class StyleTextShadow : ValueType
    {
        public 0x6651B36C m_Keyword; // 0x10
        public UnityEngine.UIElements.TextShadow m_Value; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87FA8790
        public void get_keyword(){} // RVA: 0x7FFE8733C3B0
        public void .ctor(){} // RVA: 0x7FFE87FA8810 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87FA8830
        public void op_Implicit(){} // RVA: 0x7FFE87FA8930
        public void Equals(){} // RVA: 0x7FFE87FA89B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA8A60
        public void ToString(){} // RVA: 0x7FFE87FA8AF0
    }

    public class StyleTransformOrigin : ValueType
    {
        public UnityEngine.UIElements.TransformOrigin m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x24

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87FA8B70
        public void get_keyword(){} // RVA: 0x7FFE83BAF260
        public void .ctor(){} // RVA: 0x7FFE86699A50 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87FA8C90
        public void op_Implicit(){} // RVA: 0x7FFE87FA6210
        public void Equals(){} // RVA: 0x7FFE87FA8E70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA8F10
        public void ToString(){} // RVA: 0x7FFE87FA8F30
    }

    public class StyleTranslate : ValueType
    {
        public UnityEngine.UIElements.Translate m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x28

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87FA83D0
        public void get_keyword(){} // RVA: 0x7FFE84A02990
        public void .ctor(){} // RVA: 0x7FFE87FA7D50 | overloaded x3
        public void op_Equality(){} // RVA: 0x7FFE87FA84A0
        public void op_Implicit(){} // RVA: 0x7FFE87FA8530 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE87FA85F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA86F0
        public void ToString(){} // RVA: 0x7FFE87FA8710
    }

    public class StyleValueCollection : Object
    {
        // ── Methods ──
        public void GetStyleLength(){} // RVA: 0x7FFE87FA4C00
        public void GetStyleFloat(){} // RVA: 0x7FFE87FA4CB0
        public void GetStyleInt(){} // RVA: 0x7FFE87FA4D20
        public void TryGetStyleValue(){} // RVA: 0x7FFE87FA4DA0
        public void SetStyleValue(){} // RVA: 0x7FFE87FA4F40
        public void .ctor(){} // RVA: 0x7FFE87FA5150
    }

    public class StyleValueExtensions : Object
    {
        // ── Methods ──
        public void DebugString(){} // RVA: 0x7FFE80E2E3D0
        public void ToYogaValue(){} // RVA: 0x7FFE87FA8FB0
        public void ToLength(){} // RVA: 0x7FFE87FA95B0 | overloaded x2
        public void ToRotate(){} // RVA: 0x7FFE87FA9270
        public void ToScale(){} // RVA: 0x7FFE87FA9390
        public void ToTranslate(){} // RVA: 0x7FFE87FA94A0
        public void CopyFrom(){} // RVA: 0x7FFE80E462E0
    }

    public class StyleValueFunctionExtension : Object
    {
        // ── Methods ──
        public void ToUssString(){} // RVA: 0x7FFE87FB4F20
    }

    public class StyleValueHandle : ValueType
    {
        public 0x6651CD34 m_ValueType; // 0x10

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFE8733C3B0
        public void set_valueType(){} // RVA: 0x7FFE815BF990
    }

    public class StyleValueKeywordExtension : Object
    {
        // ── Methods ──
        public void ToUssString(){} // RVA: 0x7FFE87FB5040
    }

    public class StyleVariable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82760A10
        public void GetHashCode(){} // RVA: 0x7FFE87FB5200
    }

    public class StyleVariableContext : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE87FB52A0
        public void AddInitialRange(){} // RVA: 0x7FFE87FB5400
        public void Clear(){} // RVA: 0x7FFE87FB5540
        public void .ctor(){} // RVA: 0x7FFE87FB5750 | overloaded x2
        public void TryFindVariable(){} // RVA: 0x7FFE87FB58E0
        public void GetVariableHash(){} // RVA: 0x7FFE87BFA280
        public void .cctor(){} // RVA: 0x7FFE87FB5A30
    }

    public class StyleVariableResolver : Object
    {
        public int kMaxResolves;
        public UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser s_SyntaxParser;
        public UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher m_Matcher; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_ResolvedValues; // 0x18

        // ── Methods ──
        public void get_currentSheet(){} // RVA: 0x7FFE8143BA80
        public void get_currentHandles(){} // RVA: 0x7FFE81178740
        public void get_resolvedValues(){} // RVA: 0x7FFE810FE7C0
        public void get_variableContext(){} // RVA: 0x7FFE81176730
        public void set_variableContext(){} // RVA: 0x7FFE81176740
        public void Init(){} // RVA: 0x7FFE87FB5AE0
        public void PushContext(){} // RVA: 0x7FFE87FB5C00
        public void PopContext(){} // RVA: 0x7FFE87FB5E40
        public void AddValue(){} // RVA: 0x7FFE87FB6010
        public void ResolveVarFunction(){} // RVA: 0x7FFE87FB6260 | overloaded x2
        public void ValidateResolvedValues(){} // RVA: 0x7FFE87FB63F0
        public void ResolveVariable(){} // RVA: 0x7FFE87FB65E0
        public void ResolveFallback(){} // RVA: 0x7FFE87FB6A30
        public void ParseVarFunction(){} // RVA: 0x7FFE87FB6D60
        public void .ctor(){} // RVA: 0x7FFE87FB6E50
        public void .cctor(){} // RVA: 0x7FFE87FB71A0
    }

}