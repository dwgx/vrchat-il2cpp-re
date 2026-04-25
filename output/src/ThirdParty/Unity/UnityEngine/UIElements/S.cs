// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 48
// Methods: 524

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class SafeHandleAccess : ValueType
    {
        public UIntPtr m_Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45BB120
        public void IsNull(){} // RVA: 0x7FFAC9BADEA0
        public void op_Implicit(){} // RVA: 0x7FFAC9BADEB0
    }

    public class SavePersistentViewData : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7F980
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    }

    public class Scale : ValueType
    {
        public UnityEngine.Vector3 value; // 0x10
        public bool m_IsNone; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9BFD480
        public void Initial(){} // RVA: 0x7FFAC9BFD520
        public void None(){} // RVA: 0x7FFAC9BFD630
        public void get_value(){} // RVA: 0x7FFAC530B520
        public void op_Equality(){} // RVA: 0x7FFAC9BFD670
        public void op_Inequality(){} // RVA: 0x7FFAC9BFD6D0
        public void Equals(){} // RVA: 0x7FFAC9BFD770 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFD840
        public void ToString(){} // RVA: 0x7FFAC98AEFF0
    }

    public class ScheduledItem : Object
    {
        public System.Func`1<bool> startMs; // 0x10
        public System.Func`1<bool> delayMs;
        public System.Func`1<bool> intervalMs; // 0x8
        public long endTimeMs; // 0x18
        public long <delayMs>k__BackingField; // 0x20
        public long <intervalMs>k__BackingField; // 0x28
        public long <endTimeMs>k__BackingField; // 0x30

        // ── Methods ──
        public void get_startMs(){} // RVA: 0x7FFAC2F247C0
        public void set_startMs(){} // RVA: 0x7FFAC38920D0
        public void get_delayMs(){} // RVA: 0x7FFAC2F4F0C0
        public void set_delayMs(){} // RVA: 0x7FFAC370BEE0
        public void get_intervalMs(){} // RVA: 0x7FFAC2F4F130
        public void set_intervalMs(){} // RVA: 0x7FFAC33D3BF0
        public void get_endTimeMs(){} // RVA: 0x7FFAC31D95E0
        public void .ctor(){} // RVA: 0x7FFAC9BD2020
        public void ResetStartTime(){} // RVA: 0x7FFAC9BD2110
        public void PerformTimerUpdate(){}
        public void OnItemUnscheduled(){} // RVA: 0x7FFAC2F21310
        public void ShouldUnschedule(){} // RVA: 0x7FFAC9BD2160
        public void .cctor(){} // RVA: 0x7FFAC9BD2190
    }

    public class ScrollView : VisualElement
    {
        public int horizontalScrollerVisibility; // 0x3C8
        public 0x6B1192E0 verticalScrollerVisibility; // 0x3CC
        public 0x6B1192E0 showHorizontal; // 0x3D0
        public UnityEngine.UIElements.VisualElement showVertical; // 0x3D8
        public float needsHorizontal; // 0x3E0
        public bool needsVertical; // 0x3E4
        public float isVerticalScrollDisplayed; // 0x3E8
        public float isHorizontalScrollDisplayed; // 0x3EC
        public float scrollOffset; // 0x3F0
        public float horizontalPageSize;
        public float verticalPageSize; // 0x3F4
        public float mouseWheelScrollSize; // 0x3F8
        public float scrollableWidth; // 0x3FC
        public float scrollableHeight; // 0x4
        public float hasInertia; // 0x400
        public 0x6B1193E8 scrollDecelerationRate; // 0x404
        public 0x6B119440 elasticity; // 0x408
        public long touchScrollBehavior; // 0x8
        public long nestedInteractionKind; // 0x410
        public UnityEngine.UIElements.VisualElement elasticAnimationIntervalMs; // 0x418
        public UnityEngine.UIElements.Scroller contentViewport; // 0x420
        public UnityEngine.UIElements.Scroller horizontalScroller; // 0x428
        public UnityEngine.UIElements.VisualElement verticalScroller; // 0x430
        public UnityEngine.UIElements.VisualElement contentContainer; // 0x438
        public float mode; // 0x440
        public float previousHorizontalTouchScrollTimeStamp; // 0x444
        public float elapsedTimeSinceLastVerticalTouchScroll; // 0x448
        public float elapsedTimeSinceLastHorizontalTouchScroll; // 0x44C
        public string ussClassName; // 0x10
        public string viewportUssClassName; // 0x18
        public string horizontalVariantViewportUssClassName; // 0x20
        public string verticalVariantViewportUssClassName; // 0x28
        public string verticalHorizontalVariantViewportUssClassName; // 0x30
        public string contentAndVerticalScrollUssClassName; // 0x38
        public string contentUssClassName; // 0x40
        public string horizontalVariantContentUssClassName; // 0x48
        public string verticalVariantContentUssClassName; // 0x50
        public string verticalHorizontalVariantContentUssClassName; // 0x58
        public string hScrollerUssClassName; // 0x60
        public string vScrollerUssClassName; // 0x68
        public string horizontalVariantUssClassName; // 0x70
        public string verticalVariantUssClassName; // 0x78
        public string verticalHorizontalVariantUssClassName; // 0x80
        public string scrollVariantUssClassName; // 0x88
        public 0x6B119288 m_Mode; // 0x450
        public UnityEngine.UIElements.IVisualElementScheduledItem m_ScheduledLayoutPassResetItem; // 0x458
        public int m_ScrollingPointerId; // 0x460
        public UnityEngine.Vector2 m_StartPosition; // 0x464
        public UnityEngine.Vector2 m_PointerStartPosition; // 0x46C
        public UnityEngine.Vector2 m_Velocity; // 0x474
        public UnityEngine.Vector2 m_SpringBackVelocity; // 0x47C
        public UnityEngine.Vector2 m_LowBounds; // 0x484
        public UnityEngine.Vector2 m_HighBounds; // 0x48C
        public float m_LastVelocityLerpTime; // 0x494
        public bool m_StartedMoving; // 0x498
        public bool m_TouchStoppedVelocity; // 0x499
        public UnityEngine.UIElements.VisualElement m_CapturedTarget; // 0x4A0
        public UnityEngine.UIElements.EventCallback`1<UnityEngine.UIElements.PointerMoveEvent> m_CapturedTargetPointerMoveCallback; // 0x4A8
        public UnityEngine.UIElements.EventCallback`1<UnityEngine.UIElements.PointerUpEvent> m_CapturedTargetPointerUpCallback; // 0x4B0
        public UnityEngine.UIElements.IVisualElementScheduledItem m_PostPointerUpAnimation; // 0x4B8

        // ── Methods ──
        public void get_horizontalScrollerVisibility(){} // RVA: 0x7FFAC9B56D00
        public void set_horizontalScrollerVisibility(){} // RVA: 0x7FFAC9B56D10
        public void get_verticalScrollerVisibility(){} // RVA: 0x7FFAC9B56DB0
        public void set_verticalScrollerVisibility(){} // RVA: 0x7FFAC9B56DC0
        public void set_showHorizontal(){} // RVA: 0x7FFAC9B56E70
        public void set_showVertical(){} // RVA: 0x7FFAC9B56E90
        public void get_needsHorizontal(){} // RVA: 0x7FFAC9B56EB0
        public void get_needsVertical(){} // RVA: 0x7FFAC9B56F00
        public void get_isVerticalScrollDisplayed(){} // RVA: 0x7FFAC9B56F50
        public void get_isHorizontalScrollDisplayed(){} // RVA: 0x7FFAC9B56FB0
        public void get_scrollOffset(){} // RVA: 0x7FFAC9B57010
        public void set_scrollOffset(){} // RVA: 0x7FFAC9B57090
        public void set_horizontalPageSize(){} // RVA: 0x7FFAC9B57210
        public void set_verticalPageSize(){} // RVA: 0x7FFAC9B57220
        public void get_mouseWheelScrollSize(){} // RVA: 0x7FFAC7C6B110
        public void set_mouseWheelScrollSize(){} // RVA: 0x7FFAC9B57230
        public void get_scrollableWidth(){} // RVA: 0x7FFAC9B572C0
        public void get_scrollableHeight(){} // RVA: 0x7FFAC9B57350
        public void get_hasInertia(){} // RVA: 0x7FFAC9B573E0
        public void get_scrollDecelerationRate(){} // RVA: 0x7FFAC9B57400
        public void set_scrollDecelerationRate(){} // RVA: 0x7FFAC9B57410
        public void get_elasticity(){} // RVA: 0x7FFAC9B57430
        public void set_elasticity(){} // RVA: 0x7FFAC9B57440
        public void get_touchScrollBehavior(){} // RVA: 0x7FFAC9B57460
        public void set_touchScrollBehavior(){} // RVA: 0x7FFAC9B57470
        public void get_nestedInteractionKind(){} // RVA: 0x7FFAC9B57540
        public void set_nestedInteractionKind(){} // RVA: 0x7FFAC9B57550
        public void set_elasticAnimationIntervalMs(){} // RVA: 0x7FFAC9B57560
        public void OnHorizontalScrollDragElementChanged(){} // RVA: 0x7FFAC9B57690
        public void OnVerticalScrollDragElementChanged(){} // RVA: 0x7FFAC9B57700
        public void UpdateHorizontalSliderPageSize(){} // RVA: 0x7FFAC9B57770
        public void UpdateVerticalSliderPageSize(){} // RVA: 0x7FFAC9B57890
        public void UpdateContentViewTransform(){} // RVA: 0x7FFAC9B579B0
        public void ScrollTo(){} // RVA: 0x7FFAC9B57C40
        public void GetXDeltaOffset(){} // RVA: 0x7FFAC9B57EA0
        public void GetYDeltaOffset(){} // RVA: 0x7FFAC9B580C0
        public void GetDeltaDistance(){} // RVA: 0x7FFAC9B582E0
        public void get_contentViewport(){} // RVA: 0x7FFAC39B5300
        public void get_horizontalScroller(){} // RVA: 0x7FFAC39CADC0
        public void get_verticalScroller(){} // RVA: 0x7FFAC39C8970
        public void get_contentContainer(){} // RVA: 0x7FFAC9B58350
        public void .ctor(){} // RVA: 0x7FFAC9B58370 | overloaded x2
        public void get_mode(){} // RVA: 0x7FFAC9B59530
        public void set_mode(){} // RVA: 0x7FFAC9B59540
        public void SetScrollViewMode(){} // RVA: 0x7FFAC9B59560
        public void OnAttachToPanel(){} // RVA: 0x7FFAC9B599D0
        public void OnDetachFromPanel(){} // RVA: 0x7FFAC9B59ED0
        public void OnPointerCapture(){} // RVA: 0x7FFAC9B5A3B0
        public void OnPointerCaptureOut(){} // RVA: 0x7FFAC9B5A520
        public void OnGeometryChanged(){} // RVA: 0x7FFAC9B5A640
        public void ScheduleResetLayoutPass(){} // RVA: 0x7FFAC9B5A940
        public void ResetLayoutPass(){} // RVA: 0x7FFAC9B5AA80
        public void ComputeElasticOffset(){} // RVA: 0x7FFAC9B5AA90
        public void ComputeInitialSpringBackVelocity(){} // RVA: 0x7FFAC9B5AC00
        public void SpringBack(){} // RVA: 0x7FFAC9B5AD60
        public void ApplyScrollInertia(){} // RVA: 0x7FFAC9B5AF60
        public void PostPointerUpAnimation(){} // RVA: 0x7FFAC9B5B460
        public void OnPointerDown(){} // RVA: 0x7FFAC9B5B700
        public void OnPointerMove(){} // RVA: 0x7FFAC9B5B9D0
        public void OnPointerCancel(){} // RVA: 0x7FFAC9B5BC90
        public void OnPointerUp(){} // RVA: 0x7FFAC9B5BCF0
        public void InitTouchScrolling(){} // RVA: 0x7FFAC9B5BDE0
        public void ComputeTouchScrolling(){} // RVA: 0x7FFAC9B5C150
        public void ApplyTouchScrolling(){} // RVA: 0x7FFAC9B5C570
        public void ReleaseScrolling(){} // RVA: 0x7FFAC9B5C8A0
        public void ExecuteElasticSpringAnimation(){} // RVA: 0x7FFAC9B5CA70
        public void AdjustScrollers(){} // RVA: 0x7FFAC9B5CD10
        public void UpdateScrollers(){} // RVA: 0x7FFAC9B5CEE0
        public void OnScrollersGeometryChanged(){} // RVA: 0x7FFAC9B5D320
        public void OnScrollWheel(){} // RVA: 0x7FFAC9B5D500
        public void OnRootCustomStyleResolved(){} // RVA: 0x7FFAC9B5DA40
        public void ReadSingleLineHeight(){} // RVA: 0x7FFAC9B5DA50
        public void UpdateElasticBehaviour(){} // RVA: 0x7FFAC9B5DC50
        public void .cctor(){} // RVA: 0x7FFAC9B5DF10
        public void <.ctor>b__126_0(){} // RVA: 0x7FFAC9B5E920
        public void <.ctor>b__126_1(){} // RVA: 0x7FFAC9B5E970
    }

    public class Scroller : VisualElement
    {
        public System.Action`1<float> slider; // 0x3C8
        public UnityEngine.UIElements.Slider lowButton; // 0x3D0
        public UnityEngine.UIElements.RepeatButton highButton; // 0x3D8
        public UnityEngine.UIElements.RepeatButton value; // 0x3E0
        public string lowValue;
        public string highValue; // 0x8
        public string direction; // 0x10
        public string sliderUssClassName; // 0x18
        public string lowButtonUssClassName; // 0x20
        public string highButtonUssClassName; // 0x28

        // ── Methods ──
        public void add_valueChanged(){} // RVA: 0x7FFAC9B54FE0
        public void remove_valueChanged(){} // RVA: 0x7FFAC9B550E0
        public void get_slider(){} // RVA: 0x7FFAC39C1CA0
        public void set_slider(){} // RVA: 0x7FFAC39D0F60
        public void get_lowButton(){} // RVA: 0x7FFAC39AD490
        public void set_lowButton(){} // RVA: 0x7FFAC39B57F0
        public void get_highButton(){} // RVA: 0x7FFAC39BF4D0
        public void set_highButton(){} // RVA: 0x7FFAC39C52F0
        public void get_value(){} // RVA: 0x7FFAC9B551E0
        public void set_value(){} // RVA: 0x7FFAC9B55210
        public void get_lowValue(){} // RVA: 0x7FFAC9B55240
        public void set_lowValue(){} // RVA: 0x7FFAC9B55290
        public void get_highValue(){} // RVA: 0x7FFAC9B552F0
        public void set_highValue(){} // RVA: 0x7FFAC9B55340
        public void set_direction(){} // RVA: 0x7FFAC9B553A0
        public void .ctor(){} // RVA: 0x7FFAC9B555B0 | overloaded x2
        public void Adjust(){} // RVA: 0x7FFAC9B55B60
        public void OnSliderValueChange(){} // RVA: 0x7FFAC9B55BF0
        public void ScrollPageUp(){} // RVA: 0x7FFAC9B55EB0 | overloaded x2
        public void ScrollPageDown(){} // RVA: 0x7FFAC9B55FB0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9B560B0
    }

    public class SerializedVirtualizationData : Object
    {
        public UnityEngine.Vector2 scrollOffset; // 0x10
        public int firstVisibleIndex; // 0x18
        public float contentPadding; // 0x1C
        public float contentHeight; // 0x20
        public int anchoredItemIndex; // 0x24
        public float anchorOffset; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SetupDragAndDropArgs : ValueType
    {
        public UnityEngine.UIElements.VisualElement draggedElement; // 0x10
        public System.Collections.Generic.IEnumerable`1<int> selectedIds; // 0x18
        public UnityEngine.UIElements.StartDragArgs startDragArgs; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B71CB0
    }

    public class Slider : BaseSlider`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B5FE40 | overloaded x3
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9B5FFB0
        public void SliderLerpUnclamped(){} // RVA: 0x7FFAC9B60180
        public void SliderNormalizeValue(){} // RVA: 0x7FFAC9B418C0
        public void ParseStringToValue(){} // RVA: 0x7FFAC9B60340
        public void ComputeValueFromKey(){} // RVA: 0x7FFAC9B603D0
        public void .cctor(){} // RVA: 0x7FFAC9B60650
    }

    public class SliderInt : BaseSlider`1
    {
        public string pageSize;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B613B0 | overloaded x2
        public void get_pageSize(){} // RVA: 0x7FFAC9B61520
        public void set_pageSize(){} // RVA: 0x7FFAC9B61570
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9B615D0
        public void SliderLerpUnclamped(){} // RVA: 0x7FFAC9B61790
        public void SliderNormalizeValue(){} // RVA: 0x7FFAC9B617B0
        public void ParseStringToValue(){} // RVA: 0x7FFAC9B617E0
        public void ComputeValueAndDirectionFromClick(){} // RVA: 0x7FFAC9B618C0
        public void ComputeValueFromKey(){} // RVA: 0x7FFAC9B61B50
        public void .cctor(){} // RVA: 0x7FFAC9B61DD0
    }

    public class SortColumnDescription : Object
    {
        public int columnName; // 0x10
        public string columnIndex; // 0x18
        public 0x6B118890 column; // 0x20
        public UnityEngine.UIElements.Column direction; // 0x28
        public System.Action`1<UnityEngine.UIElements.SortColumnDescription> changed; // 0x30

        // ── Methods ──
        public void get_columnName(){} // RVA: 0x7FFAC2F247C0
        public void set_columnName(){} // RVA: 0x7FFAC9B4F490
        public void get_columnIndex(){} // RVA: 0x7FFAC2F6E5C0
        public void set_columnIndex(){} // RVA: 0x7FFAC9B4F550
        public void get_column(){} // RVA: 0x7FFAC2F4F130
        public void set_column(){} // RVA: 0x7FFAC2F22E90
        public void get_direction(){} // RVA: 0x7FFAC30DBBE0
        public void set_direction(){} // RVA: 0x7FFAC9B4F580
        public void add_changed(){} // RVA: 0x7FFAC9B4F5B0
        public void remove_changed(){} // RVA: 0x7FFAC9B4F6B0
        public void .ctor(){} // RVA: 0x7FFAC9B4F820 | overloaded x3
    }

    public class SortColumnDescriptions : Object
    {
        public System.Collections.Generic.IList`1<UnityEngine.UIElements.SortColumnDescription> Count; // 0x10
        public System.Action IsReadOnly; // 0x18

        // ── Methods ──
        public void add_changed(){} // RVA: 0x7FFAC9B4F870
        public void remove_changed(){} // RVA: 0x7FFAC9B4F960
        public void GetEnumerator(){} // RVA: 0x7FFAC9B4FA50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9B4FA50
        public void Add(){} // RVA: 0x7FFAC9B4FAA0
        public void Clear(){} // RVA: 0x7FFAC9B4FB10
        public void Contains(){} // RVA: 0x7FFAC9B4FCA0
        public void CopyTo(){} // RVA: 0x7FFAC9B4FD00
        public void Remove(){} // RVA: 0x7FFAC9B4FDE0
        public void OnDescriptionChanged(){} // RVA: 0x7FFAC32033B0
        public void get_Count(){} // RVA: 0x7FFAC9B50020
        public void get_IsReadOnly(){} // RVA: 0x7FFAC9B50070
        public void Insert(){} // RVA: 0x7FFAC9B500C0
        public void .ctor(){} // RVA: 0x7FFAC9B503E0
    }

    public class Spacing : ValueType
    {
        public float horizontal; // 0x10
        public float vertical; // 0x14
        public float right; // 0x18
        public float bottom; // 0x1C

        // ── Methods ──
        public void get_horizontal(){} // RVA: 0x7FFAC98668A0
        public void get_vertical(){} // RVA: 0x7FFAC98668C0
        public void .ctor(){} // RVA: 0x7FFAC2F45570
        public void op_Subtraction(){} // RVA: 0x7FFAC9BD36F0
    }

    public class StartDragArgs : ValueType
    {
        public string title; // 0x10
        public 0x6B11A9E8 visualMode; // 0x18
        public System.Collections.Hashtable genericData; // 0x20
        public System.Collections.Generic.IEnumerable`1<UnityEngine.Object> unityObjectReferences; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B71E30
        public void get_title(){} // RVA: 0x7FFAC3AD9F60
        public void get_visualMode(){} // RVA: 0x7FFAC49C7500
        public void get_genericData(){} // RVA: 0x7FFAC2F3C380
        public void set_genericData(){} // RVA: 0x7FFAC2F22E30
        public void get_unityObjectReferences(){} // RVA: 0x7FFAC2F247C0
        public void set_unityObjectReferences(){} // RVA: 0x7FFAC2F87E80
        public void SetGenericData(){} // RVA: 0x7FFAC9B71F40
    }

    public class StyleBackgroundSize : ValueType
    {
        public UnityEngine.UIElements.BackgroundSize value; // 0x10
        public 0x6B122448 keyword; // 0x24

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9BFD8A0
        public void get_keyword(){} // RVA: 0x7FFAC5872100
        public void .ctor(){} // RVA: 0x7FFAC82F0150 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9BFD8E0
        public void op_Implicit(){} // RVA: 0x7FFAC9BFD9C0
        public void Equals(){} // RVA: 0x7FFAC9BFDAD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFDB70
        public void ToString(){} // RVA: 0x7FFAC9BFDBE0
    }

    public class StyleCache : Object
    {
        public System.Collections.Generic.Dictionary`2<long,UnityEngine.UIElements.ComputedStyle> s_ComputedStyleCache;
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.UIElements.StyleVariableContext> s_StyleVariableContextCache; // 0x8
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.UIElements.ComputedTransitionProperty[]> s_ComputedTransitionsCache; // 0x10

        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFAC9AC45D0 | overloaded x3
        public void SetValue(){} // RVA: 0x7FFAC9AC4670 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC9AC4720
    }

    public class StyleColor : ValueType
    {
        public UnityEngine.Color value; // 0x10
        public 0x6B122448 keyword; // 0x20

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9BFDC60
        public void get_keyword(){} // RVA: 0x7FFAC9851CE0
        public void .ctor(){} // RVA: 0x7FFAC60F1490 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9BFDC80
        public void op_Implicit(){} // RVA: 0x7FFAC9BFDD00
        public void Equals(){} // RVA: 0x7FFAC9BFDDA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFDE90
        public void ToString(){} // RVA: 0x7FFAC9BFDEB0
    }

    public class StyleComplexSelector : Object
    {
        public UnityEngine.UIElements.Hashes specificity; // 0x10
        public int rule; // 0x20
        public UnityEngine.UIElements.StyleRule isSimple; // 0x28
        public bool selectors; // 0x30
        public UnityEngine.UIElements.StyleSelector[] m_Selectors; // 0x38
        public int ruleIndex; // 0x40
        public UnityEngine.UIElements.StyleComplexSelector nextInTable; // 0x48
        public int orderInStyleSheet; // 0x50
        public System.Collections.Generic.Dictionary`2<string,PseudoStateData> s_PseudoStates;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSelectorPart> m_HashList; // 0x8

        // ── Methods ──
        public void get_specificity(){} // RVA: 0x7FFAC6C90D40
        public void get_rule(){} // RVA: 0x7FFAC2F4F130
        public void set_rule(){} // RVA: 0x7FFAC2F22E90
        public void get_isSimple(){} // RVA: 0x7FFAC98DDAE0
        public void get_selectors(){} // RVA: 0x7FFAC991F6C0
        public void set_selectors(){} // RVA: 0x7FFAC9C08DE0
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC9C08E50
        public void CachePseudoStateMasks(){} // RVA: 0x7FFAC9C08E80
        public void ToString(){} // RVA: 0x7FFAC9C09710
        public void StyleSelectorPartCompare(){} // RVA: 0x7FFAC9C09A50
        public void CalculateHashes(){} // RVA: 0x7FFAC9C09AA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9C0A2A0
    }

    public class StyleCursor : ValueType
    {
        public UnityEngine.UIElements.Cursor value; // 0x10
        public 0x6B122448 keyword; // 0x28

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9BFDF20
        public void get_keyword(){} // RVA: 0x7FFAC669DCA0
        public void .ctor(){} // RVA: 0x7FFAC9BFDFE0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9BFE050
        public void op_Implicit(){} // RVA: 0x7FFAC9BFE150
        public void Equals(){} // RVA: 0x7FFAC9BFE2F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFE390
        public void ToString(){} // RVA: 0x7FFAC9BFE3B0
    }

    public class StyleDataRef`1 : ValueType
    {
        public RefCounted<T> m_Ref;

        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFAC2E8DC40
        public void Release(){} // RVA: 0x7FFAC2C70980
        public void CopyFrom(){} // RVA: 0x7FFAC2E8DC40
        public void Read(){} // RVA: 0x7FFAC2C58E90
        public void Write(){} // RVA: 0x7FFAC2C58E90
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void op_Equality(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void ReferenceEquals(){} // RVA: 0x7FFAC2E8DC40
    }

    public class StyleEnum`1 : ValueType
    {
        public T value;
        public 0x6B122448 keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC2E8DC40
        public void get_keyword(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void op_Equality(){} // RVA: 0x7FFAC2E8DC40
        public void op_Inequality(){} // RVA: 0x7FFAC2E8DC40
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void ToString(){} // RVA: 0x7FFAC2C58E90
    }

    public class StyleFloat : ValueType
    {
        public float value; // 0x10
        public 0x6B122448 keyword; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9BFE430
        public void get_keyword(){} // RVA: 0x7FFAC69CBEA0
        public void .ctor(){} // RVA: 0x7FFAC553F750 | overloaded x3
        public void op_Equality(){} // RVA: 0x7FFAC9BFE460
        public void op_Implicit(){} // RVA: 0x7FFAC9BD37E0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC9BFE4E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BD3910
        public void ToString(){} // RVA: 0x7FFAC9BFE590
    }

    public class StyleFont : ValueType
    {
        public UnityEngine.Font value; // 0x10
        public 0x6B122448 keyword; // 0x18

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9BFE600
        public void get_keyword(){} // RVA: 0x7FFAC653D9A0
        public void .ctor(){} // RVA: 0x7FFAC7761C20 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9BFE670
        public void op_Implicit(){} // RVA: 0x7FFAC9BFE7C0
        public void Equals(){} // RVA: 0x7FFAC9BFE9B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFEA50
        public void ToString(){} // RVA: 0x7FFAC9BFEB50
    }

    public class StyleFontDefinition : ValueType
    {
        public 0x6B122448 value; // 0x10
        public UnityEngine.UIElements.FontDefinition keyword; // 0x18

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9BFEBC0
        public void get_keyword(){} // RVA: 0x7FFAC8F93F90
        public void .ctor(){} // RVA: 0x7FFAC9BFEC40 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC9BFECA0
        public void Equals(){} // RVA: 0x7FFAC9BFED70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFEE30
    }

    public class StyleInt : ValueType
    {
        public int value; // 0x10
        public 0x6B122448 keyword; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC69CBE90
        public void get_keyword(){} // RVA: 0x7FFAC69CBEA0
        public void .ctor(){} // RVA: 0x7FFAC69CBF30 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9BFEE60
        public void op_Implicit(){} // RVA: 0x7FFAC9BFE490
        public void Equals(){} // RVA: 0x7FFAC9BFEEB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFEF50
        public void ToString(){} // RVA: 0x7FFAC9BFEF60
    }

    public class StyleLength : ValueType
    {
        public UnityEngine.UIElements.Length value; // 0x10
        public 0x6B122448 keyword; // 0x18

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9BFEFD0
        public void get_keyword(){} // RVA: 0x7FFAC653D9A0
        public void .ctor(){} // RVA: 0x7FFAC9BFF090 | overloaded x4
        public void op_Equality(){} // RVA: 0x7FFAC9BFF0C0
        public void op_Implicit(){} // RVA: 0x7FFAC9BFF1B0 | overloaded x3
        public void Equals(){} // RVA: 0x7FFAC9BFF260 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFF340
        public void ToString(){} // RVA: 0x7FFAC9BFF370
    }

    public class StyleMatchingContext : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet> styleSheetCount; // 0x10
        public UnityEngine.UIElements.StyleVariableContext variableContext; // 0x18
        public UnityEngine.UIElements.VisualElement currentElement; // 0x20
        public System.Action`2<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult; // 0x28
        public UnityEngine.UIElements.AncestorFilter ancestorFilter; // 0x30

        // ── Methods ──
        public void get_styleSheetCount(){} // RVA: 0x7FFAC9AC5420
        public void .ctor(){} // RVA: 0x7FFAC9AC5470
        public void AddStyleSheet(){} // RVA: 0x7FFAC9AC5790
        public void RemoveStyleSheetRange(){} // RVA: 0x7FFAC9AC5890
        public void GetStyleSheetAt(){} // RVA: 0x7FFAC9AC5900
    }

    public class StyleProperty : Object
    {
        public string name; // 0x10
        public int values; // 0x18
        public UnityEngine.UIElements.StyleValueHandle[] m_Values; // 0x20
        public bool isCustomProperty; // 0x28
        public bool requireVariableResolve; // 0x29

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC5CC4750
        public void get_values(){} // RVA: 0x7FFAC91BAEE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StylePropertyAnimationSystem : Object
    {
        public long m_CurrentTimeMs; // 0x10
        public ValuesFloat m_Floats; // 0x18
        public ValuesInt m_Ints; // 0x20
        public ValuesLength m_Lengths; // 0x28
        public ValuesColor m_Colors; // 0x30
        public ValuesBackground m_Backgrounds; // 0x38
        public ValuesFontDefinition m_FontDefinitions; // 0x40
        public ValuesFont m_Fonts; // 0x48
        public ValuesTextShadow m_TextShadows; // 0x50
        public ValuesScale m_Scale; // 0x58
        public ValuesRotate m_Rotate; // 0x60
        public ValuesTranslate m_Translate; // 0x68
        public ValuesTransformOrigin m_TransformOrigin; // 0x70
        public ValuesBackgroundPosition m_BackgroundPosition; // 0x78
        public ValuesBackgroundRepeat m_BackgroundRepeat; // 0x80
        public ValuesBackgroundSize m_BackgroundSize; // 0x88
        public System.Collections.Generic.List`1<Values> m_AllValues; // 0x90
        public System.Collections.Generic.Dictionary`2<0x6B129770,Values> m_PropertyToValues; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C01960
        public void GetOrCreate(){} // RVA: 0x7FFAC2E8DC40
        public void StartTransition(){} // RVA: 0x7FFAC9C03670 | overloaded x16
        public void CancelAllAnimations(){} // RVA: 0x7FFAC9C039E0 | overloaded x2
        public void CancelAnimation(){} // RVA: 0x7FFAC9C03BE0
        public void UpdateAnimation(){} // RVA: 0x7FFAC9C03C80
        public void GetAllAnimations(){} // RVA: 0x7FFAC9C03D20
        public void UpdateTracking(){} // RVA: 0x7FFAC2C70A40
        public void CurrentTimeMs(){} // RVA: 0x7FFAC5CC4750
        public void Update(){} // RVA: 0x7FFAC9C03EA0
    }

    public class StylePropertyName : ValueType
    {
        public 0x6B129770 id; // 0x10
        public string name; // 0x18

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAC4420210
        public void get_name(){} // RVA: 0x7FFAC4420220
        public void StylePropertyIdFromString(){} // RVA: 0x7FFAC9C08930
        public void .ctor(){} // RVA: 0x7FFAC9C08B70 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9838C50
        public void op_Inequality(){} // RVA: 0x7FFAC9C08D10
        public void op_Implicit(){} // RVA: 0x7FFAC9C08D20
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
        public void Equals(){} // RVA: 0x7FFAC9838C50 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC86B4B80
    }

    public class StylePropertyNameCollection : ValueType
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName> propertiesList; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void GetEnumerator(){} // RVA: 0x7FFAC9B91F60
        public void System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator(){} // RVA: 0x7FFAC9B920E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9B92150
    }

    public class StyleRotate : ValueType
    {
        public UnityEngine.UIElements.Rotate value; // 0x10
        public 0x6B122448 keyword; // 0x28

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9BFF3F0
        public void get_keyword(){} // RVA: 0x7FFAC669DCA0
        public void .ctor(){} // RVA: 0x7FFAC9BFF500 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9BFF520
        public void op_Implicit(){} // RVA: 0x7FFAC9BFF5B0
        public void Equals(){} // RVA: 0x7FFAC9BFF670 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFF770
        public void ToString(){} // RVA: 0x7FFAC9BFF790
    }

    public class StyleRule : Object
    {
        public UnityEngine.UIElements.StyleProperty[] properties; // 0x10
        public int line; // 0x18
        public int customPropertiesCount; // 0x1C

        // ── Methods ──
        public void get_properties(){} // RVA: 0x7FFAC5CC4750
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StyleScale : ValueType
    {
        public UnityEngine.UIElements.Scale value; // 0x10
        public 0x6B122448 keyword; // 0x20

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9BFF810
        public void get_keyword(){} // RVA: 0x7FFAC9851CE0
        public void .ctor(){} // RVA: 0x7FFAC60F1490 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9BFF8E0
        public void op_Implicit(){} // RVA: 0x7FFAC9BFF950
        public void Equals(){} // RVA: 0x7FFAC9BFF9D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFFAA0
        public void ToString(){} // RVA: 0x7FFAC9BFFB10
    }

    public class StyleSelector : Object
    {
        public UnityEngine.UIElements.StyleSelectorPart[] parts; // 0x10
        public 0x6B123AF8 previousRelationship; // 0x18
        public int pseudoStateMask; // 0x1C
        public int negatedPseudoStateMask; // 0x20

        // ── Methods ──
        public void get_parts(){} // RVA: 0x7FFAC5CC4750
        public void set_parts(){} // RVA: 0x7FFAC2F22E30
        public void get_previousRelationship(){} // RVA: 0x7FFAC669DCA0
        public void set_previousRelationship(){} // RVA: 0x7FFAC392CD10
        public void ToString(){} // RVA: 0x7FFAC9C0A440
        public void .ctor(){} // RVA: 0x7FFAC9C0A710
    }

    public class StyleSelectorPart : ValueType
    {
        public string value; // 0x10
        public 0x6B123B50 type; // 0x18
        public object tempData; // 0x20

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC51D9A30
        public void get_type(){} // RVA: 0x7FFAC653D9A0
        public void set_type(){} // RVA: 0x7FFAC49C7510
        public void ToString(){} // RVA: 0x7FFAC9C0A7E0
        public void CreateClass(){} // RVA: 0x7FFAC9C0A910
        public void CreateId(){} // RVA: 0x7FFAC9C0A9A0
        public void CreatePredicate(){} // RVA: 0x7FFAC9C0AA30
    }

    public class StyleSheet : ScriptableObject
    {
        public bool importedWithErrors; // 0x18
        public bool importedWithWarnings; // 0x19
        public UnityEngine.UIElements.StyleRule[] rules; // 0x20
        public UnityEngine.UIElements.StyleComplexSelector[] complexSelectors; // 0x28
        public float[] flattenedRecursiveImports; // 0x30
        public UnityEngine.UIElements.StyleSheets.Dimension[] contentHash; // 0x38
        public UnityEngine.Color[] isDefaultStyleSheet; // 0x40
        public string[] strings; // 0x48
        public UnityEngine.Object[] assets; // 0x50
        public ImportStruct[] imports; // 0x58
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet> m_FlattenedImportedStyleSheets; // 0x60
        public int m_ContentHash; // 0x68
        public UnityEngine.UIElements.StyleSheets.ScalableImage[] scalableImages; // 0x70
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.UIElements.StyleComplexSelector> orderedNameSelectors; // 0x78
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.UIElements.StyleComplexSelector> orderedTypeSelectors; // 0x80
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.UIElements.StyleComplexSelector> orderedClassSelectors; // 0x88
        public bool m_IsDefaultStyleSheet; // 0x90
        public string kCustomPropertyMarker;

        // ── Methods ──
        public void get_importedWithErrors(){} // RVA: 0x7FFAC9828D80
        public void set_importedWithErrors(){} // RVA: 0x7FFAC2F3C4F0
        public void get_importedWithWarnings(){} // RVA: 0x7FFAC9C0AAC0
        public void set_importedWithWarnings(){} // RVA: 0x7FFAC3515120
        public void get_rules(){} // RVA: 0x7FFAC91BAEE0
        public void set_rules(){} // RVA: 0x7FFAC9C0AAD0
        public void get_complexSelectors(){} // RVA: 0x7FFAC98DDAD0
        public void set_complexSelectors(){} // RVA: 0x7FFAC9C0AB30
        public void get_flattenedRecursiveImports(){} // RVA: 0x7FFAC991F9B0
        public void get_contentHash(){} // RVA: 0x7FFAC9C0AB90
        public void set_contentHash(){} // RVA: 0x7FFAC47BAB60
        public void get_isDefaultStyleSheet(){} // RVA: 0x7FFAC9C0ABA0
        public void set_isDefaultStyleSheet(){} // RVA: 0x7FFAC9C0ABB0
        public void TryCheckAccess(){} // RVA: 0x7FFAC2E8DC40
        public void CheckAccess(){} // RVA: 0x7FFAC2E8DC40
        public void OnEnable(){} // RVA: 0x7FFAC9C0AD10
        public void FlattenImportedStyleSheetsRecursive(){} // RVA: 0x7FFAC9C0ADF0 | overloaded x2
        public void SetupReferences(){} // RVA: 0x7FFAC9C0AF80
        public void ReadKeyword(){} // RVA: 0x7FFAC9AAA5C0
        public void ReadFloat(){} // RVA: 0x7FFAC9C0B690
        public void TryReadFloat(){} // RVA: 0x7FFAC9C0B770
        public void ReadDimension(){} // RVA: 0x7FFAC9C0B880
        public void TryReadDimension(){} // RVA: 0x7FFAC9C0B960
        public void ReadColor(){} // RVA: 0x7FFAC9C0BA80
        public void TryReadColor(){} // RVA: 0x7FFAC9C0BB30
        public void ReadString(){} // RVA: 0x7FFAC9C0BBD0
        public void TryReadString(){} // RVA: 0x7FFAC9C0BC50
        public void ReadEnum(){} // RVA: 0x7FFAC9C0BCF0
        public void TryReadEnum(){} // RVA: 0x7FFAC9C0BD70
        public void ReadVariable(){} // RVA: 0x7FFAC9C0BE10
        public void TryReadVariable(){} // RVA: 0x7FFAC9C0BE90
        public void ReadResourcePath(){} // RVA: 0x7FFAC9C0BF30
        public void TryReadResourcePath(){} // RVA: 0x7FFAC9C0BFB0
        public void ReadAssetReference(){} // RVA: 0x7FFAC9C0C050
        public void ReadMissingAssetReferenceUrl(){} // RVA: 0x7FFAC9C0C0D0
        public void TryReadAssetReference(){} // RVA: 0x7FFAC9C0C150
        public void ReadFunction(){} // RVA: 0x7FFAC9AAA5C0
        public void ReadFunctionName(){} // RVA: 0x7FFAC9C0C1F0
        public void ReadScalableImage(){} // RVA: 0x7FFAC9C0C490
        public void CustomStartsWith(){} // RVA: 0x7FFAC9C0C540
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
        public void .cctor(){} // RVA: 0x7FFAC9C0C620
    }

    public class StyleTextShadow : ValueType
    {
        public 0x6B122448 value; // 0x10
        public UnityEngine.UIElements.TextShadow keyword; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9BFFF40
        public void get_keyword(){} // RVA: 0x7FFAC8F93F90
        public void .ctor(){} // RVA: 0x7FFAC9BFFFC0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9BFFFE0
        public void op_Implicit(){} // RVA: 0x7FFAC9C000E0
        public void Equals(){} // RVA: 0x7FFAC9C00160 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9C00210
        public void ToString(){} // RVA: 0x7FFAC9C002A0
    }

    public class StyleTransformOrigin : ValueType
    {
        public UnityEngine.UIElements.TransformOrigin value; // 0x10
        public 0x6B122448 keyword; // 0x24

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9C00320
        public void get_keyword(){} // RVA: 0x7FFAC5872100
        public void .ctor(){} // RVA: 0x7FFAC82F0150 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9C00440
        public void op_Implicit(){} // RVA: 0x7FFAC9BFD9C0
        public void Equals(){} // RVA: 0x7FFAC9C00620 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9C006C0
        public void ToString(){} // RVA: 0x7FFAC9C006E0
    }

    public class StyleTranslate : ValueType
    {
        public UnityEngine.UIElements.Translate value; // 0x10
        public 0x6B122448 keyword; // 0x28

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9BFFB80
        public void get_keyword(){} // RVA: 0x7FFAC669DCA0
        public void .ctor(){} // RVA: 0x7FFAC9BFF500 | overloaded x3
        public void op_Equality(){} // RVA: 0x7FFAC9BFFC50
        public void op_Implicit(){} // RVA: 0x7FFAC9BFFCE0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC9BFFDA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFFEA0
        public void ToString(){} // RVA: 0x7FFAC9BFFEC0
    }

    public class StyleValueCollection : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StyleValue> m_Values; // 0x10

        // ── Methods ──
        public void GetStyleLength(){} // RVA: 0x7FFAC9BFC3B0
        public void GetStyleFloat(){} // RVA: 0x7FFAC9BFC460
        public void GetStyleInt(){} // RVA: 0x7FFAC9BFC4D0
        public void TryGetStyleValue(){} // RVA: 0x7FFAC9BFC550
        public void SetStyleValue(){} // RVA: 0x7FFAC9BFC6F0
        public void .ctor(){} // RVA: 0x7FFAC9BFC900
    }

    public class StyleValueExtensions : Object
    {
        // ── Methods ──
        public void DebugString(){} // RVA: 0x7FFAC2C58F80
        public void ToYogaValue(){} // RVA: 0x7FFAC9C00760
        public void ToLength(){} // RVA: 0x7FFAC9C00D60 | overloaded x2
        public void ToRotate(){} // RVA: 0x7FFAC9C00A20
        public void ToScale(){} // RVA: 0x7FFAC9C00B40
        public void ToTranslate(){} // RVA: 0x7FFAC9C00C50
        public void CopyFrom(){} // RVA: 0x7FFAC2C70C80
    }

    public class StyleValueFunctionExtension : Object
    {
        // ── Methods ──
        public void ToUssString(){} // RVA: 0x7FFAC9C0C6D0
    }

    public class StyleValueHandle : ValueType
    {
        public 0x6B123E10 valueType; // 0x10
        public int valueIndex; // 0x14

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFAC8F93F90
        public void set_valueType(){} // RVA: 0x7FFAC336D8B0
    }

    public class StyleValueKeywordExtension : Object
    {
        // ── Methods ──
        public void ToUssString(){} // RVA: 0x7FFAC9C0C7F0
    }

    public class StyleVariable : ValueType
    {
        public string name; // 0x10
        public UnityEngine.UIElements.StyleSheet sheet; // 0x18
        public UnityEngine.UIElements.StyleValueHandle[] handles; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC446FCC0
        public void GetHashCode(){} // RVA: 0x7FFAC9C0C9B0
    }

    public class StyleVariableContext : Object
    {
        public UnityEngine.UIElements.StyleVariableContext none;
        public int m_VariableHash; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleVariable> m_Variables; // 0x18
        public System.Collections.Generic.List`1<int> m_SortedHash; // 0x20

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC9C0CA50
        public void AddInitialRange(){} // RVA: 0x7FFAC9C0CBB0
        public void Clear(){} // RVA: 0x7FFAC9C0CCF0
        public void .ctor(){} // RVA: 0x7FFAC9C0CF00 | overloaded x2
        public void TryFindVariable(){} // RVA: 0x7FFAC9C0D090
        public void GetVariableHash(){} // RVA: 0x7FFAC9851CE0
        public void .cctor(){} // RVA: 0x7FFAC9C0D1E0
    }

    public class StyleVariableResolver : Object
    {
        public int currentSheet;
        public UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser currentHandles;
        public UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher resolvedValues; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue> variableContext; // 0x18
        public System.Collections.Generic.Stack`1<string> m_ResolvedVarStack; // 0x20
        public UnityEngine.UIElements.StyleProperty m_Property; // 0x28
        public System.Collections.Generic.Stack`1<ResolveContext> m_ContextStack; // 0x30
        public ResolveContext m_CurrentContext; // 0x38
        public UnityEngine.UIElements.StyleVariableContext <variableContext>k__BackingField; // 0x48

        // ── Methods ──
        public void get_currentSheet(){} // RVA: 0x7FFAC31D0140
        public void get_currentHandles(){} // RVA: 0x7FFAC2F9E740
        public void get_resolvedValues(){} // RVA: 0x7FFAC2F247C0
        public void get_variableContext(){} // RVA: 0x7FFAC2F9C730
        public void set_variableContext(){} // RVA: 0x7FFAC2F9C740
        public void Init(){} // RVA: 0x7FFAC9C0D290
        public void PushContext(){} // RVA: 0x7FFAC9C0D3B0
        public void PopContext(){} // RVA: 0x7FFAC9C0D5F0
        public void AddValue(){} // RVA: 0x7FFAC9C0D7C0
        public void ResolveVarFunction(){} // RVA: 0x7FFAC9C0DA10 | overloaded x2
        public void ValidateResolvedValues(){} // RVA: 0x7FFAC9C0DBA0
        public void ResolveVariable(){} // RVA: 0x7FFAC9C0DD90
        public void ResolveFallback(){} // RVA: 0x7FFAC9C0E1E0
        public void ParseVarFunction(){} // RVA: 0x7FFAC9C0E510
        public void .ctor(){} // RVA: 0x7FFAC9C0E600
        public void .cctor(){} // RVA: 0x7FFAC9C0E950
    }

}