// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 60
// Methods: 599

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class SafeHandleAccess : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A767FEF0
        public void IsNull(){} // RVA: 0x7A7F02E50
        public void op_Implicit(){} // RVA: 0x7AF1F5840
    }

    public class SavePersistentViewData : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8135E00
        public void Invoke(){} // RVA: 0x7A8135ED0
    }

    public class Scale : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F08370
        public void Initial(){} // RVA: 0x7AF2451D0
        public void None(){} // RVA: 0x7AF2452E0
        public void get_value(){} // RVA: 0x7A79F03E0
        public void op_Equality(){} // RVA: 0x7AF245320
        public void op_Inequality(){} // RVA: 0x7AF245380
        public void Equals(){} // RVA: 0x7A7F083F0
        public void GetHashCode(){} // RVA: 0x7A7F08400
        public void ToString(){} // RVA: 0x7A7EDE350
    }

    public class ScheduledItem : Object
    {
        // ── Methods ──
        public void get_startMs(){} // RVA: 0x7A80DA7B0
        public void set_startMs(){} // RVA: 0x7A8A224D0
        public void get_delayMs(){} // RVA: 0x7A81052C0
        public void set_delayMs(){} // RVA: 0x7A8884B10
        public void get_intervalMs(){} // RVA: 0x7A8105330
        public void set_intervalMs(){} // RVA: 0x7A8669350
        public void get_endTimeMs(){} // RVA: 0x7A83F69F0
        public void .ctor(){} // RVA: 0x7AF219B40
        public void ResetStartTime(){} // RVA: 0x7AF219C30
        public void PerformTimerUpdate(){} // RVA: 0x7A7E18800
        public void OnItemUnscheduled(){} // RVA: 0x7A80D7310
        public void ShouldUnschedule(){} // RVA: 0x7AF219C80
        public void .cctor(){} // RVA: 0x7AF219CB0
    }

    public class ScrollView : VisualElement
    {
        // ── Methods ──
        public void get_horizontalScrollerVisibility(){} // RVA: 0x7AF19E820
        public void set_horizontalScrollerVisibility(){} // RVA: 0x7AF19E830
        public void get_verticalScrollerVisibility(){} // RVA: 0x7AF19E8D0
        public void set_verticalScrollerVisibility(){} // RVA: 0x7AF19E8E0
        public void set_showHorizontal(){} // RVA: 0x7AF19E990
        public void set_showVertical(){} // RVA: 0x7AF19E9B0
        public void get_needsHorizontal(){} // RVA: 0x7AF19E9D0
        public void get_needsVertical(){} // RVA: 0x7AF19EA20
        public void get_isVerticalScrollDisplayed(){} // RVA: 0x7AF19EA70
        public void get_isHorizontalScrollDisplayed(){} // RVA: 0x7AF19EAD0
        public void get_scrollOffset(){} // RVA: 0x7AF19EB30
        public void set_scrollOffset(){} // RVA: 0x7AF19EBB0
        public void set_horizontalPageSize(){} // RVA: 0x7AF19ED40
        public void set_verticalPageSize(){} // RVA: 0x7AF19ED50
        public void get_mouseWheelScrollSize(){} // RVA: 0x7AD3B2550
        public void set_mouseWheelScrollSize(){} // RVA: 0x7AF19ED60
        public void get_scrollableWidth(){} // RVA: 0x7AF19EDF0
        public void get_scrollableHeight(){} // RVA: 0x7AF19EE80
        public void get_hasInertia(){} // RVA: 0x7AF19EF10
        public void get_scrollDecelerationRate(){} // RVA: 0x7AF19EF30
        public void set_scrollDecelerationRate(){} // RVA: 0x7AF19EF40
        public void get_elasticity(){} // RVA: 0x7AF19EF60
        public void set_elasticity(){} // RVA: 0x7AF19EF70
        public void get_touchScrollBehavior(){} // RVA: 0x7AF19EF90
        public void set_touchScrollBehavior(){} // RVA: 0x7AF19EFA0
        public void get_nestedInteractionKind(){} // RVA: 0x7AF19F060
        public void set_nestedInteractionKind(){} // RVA: 0x7AF19F070
        public void set_elasticAnimationIntervalMs(){} // RVA: 0x7AF19F080
        public void OnHorizontalScrollDragElementChanged(){} // RVA: 0x7AF19F1B0
        public void OnVerticalScrollDragElementChanged(){} // RVA: 0x7AF19F220
        public void UpdateHorizontalSliderPageSize(){} // RVA: 0x7AF19F290
        public void UpdateVerticalSliderPageSize(){} // RVA: 0x7AF19F3B0
        public void UpdateContentViewTransform(){} // RVA: 0x7AF19F4D0
        public void ScrollTo(){} // RVA: 0x7AF19F760
        public void GetXDeltaOffset(){} // RVA: 0x7AF19F9C0
        public void GetYDeltaOffset(){} // RVA: 0x7AF19FBE0
        public void GetDeltaDistance(){} // RVA: 0x7AF19FE00
        public void get_contentViewport(){} // RVA: 0x7A8B6B210
        public void get_horizontalScroller(){} // RVA: 0x7A8B5BCB0
        public void get_verticalScroller(){} // RVA: 0x7A8B67010
        public void get_contentContainer(){} // RVA: 0x7AF19FE70
        public void .ctor(){} // RVA: 0x7AF19FE90
        public void get_mode(){} // RVA: 0x7AF1A1060
        public void set_mode(){} // RVA: 0x7AF1A1070
        public void SetScrollViewMode(){} // RVA: 0x7AF1A1090
        public void OnAttachToPanel(){} // RVA: 0x7AF1A1500
        public void OnDetachFromPanel(){} // RVA: 0x7AF1A1A00
        public void OnPointerCapture(){} // RVA: 0x7AF1A1EE0
        public void OnPointerCaptureOut(){} // RVA: 0x7AF1A2050
        public void OnGeometryChanged(){} // RVA: 0x7AF1A2170
        public void ScheduleResetLayoutPass(){} // RVA: 0x7AF1A2480
        public void ResetLayoutPass(){} // RVA: 0x7AF1A25C0
        public void ComputeElasticOffset(){} // RVA: 0x7AF1A25D0
        public void ComputeInitialSpringBackVelocity(){} // RVA: 0x7AF1A2750
        public void SpringBack(){} // RVA: 0x7AF1A28B0
        public void ApplyScrollInertia(){} // RVA: 0x7AF1A2AB0
        public void PostPointerUpAnimation(){} // RVA: 0x7AF1A2F90
        public void OnPointerDown(){} // RVA: 0x7AF1A3230
        public void OnPointerMove(){} // RVA: 0x7AF1A3500
        public void OnPointerCancel(){} // RVA: 0x7AF1A37C0
        public void OnPointerUp(){} // RVA: 0x7AF1A3820
        public void InitTouchScrolling(){} // RVA: 0x7AF1A3910
        public void ComputeTouchScrolling(){} // RVA: 0x7AF1A3C80
        public void ApplyTouchScrolling(){} // RVA: 0x7AF1A40A0
        public void ReleaseScrolling(){} // RVA: 0x7AF1A43D0
        public void ExecuteElasticSpringAnimation(){} // RVA: 0x7AF1A45A0
        public void AdjustScrollers(){} // RVA: 0x7AF1A4830
        public void UpdateScrollers(){} // RVA: 0x7AF1A49F0
        public void OnScrollersGeometryChanged(){} // RVA: 0x7AF1A4E30
        public void OnScrollWheel(){} // RVA: 0x7AF1A5010
        public void OnRootCustomStyleResolved(){} // RVA: 0x7AF1A5580
        public void ReadSingleLineHeight(){} // RVA: 0x7AF1A5590
        public void UpdateElasticBehaviour(){} // RVA: 0x7AF1A5790
        public void .cctor(){} // RVA: 0x7AF1A5A50
        public void <.ctor>b__126_0(){} // RVA: 0x7AF1A6460
        public void <.ctor>b__126_1(){} // RVA: 0x7AF1A64B0
    }

    public class Scroller : VisualElement
    {
        // ── Methods ──
        public void add_valueChanged(){} // RVA: 0x7AF19CAC0
        public void remove_valueChanged(){} // RVA: 0x7AF19CBE0
        public void get_slider(){} // RVA: 0x7A8B52950
        public void set_slider(){} // RVA: 0x7A8B63960
        public void get_lowButton(){} // RVA: 0x7A8B64520
        public void set_lowButton(){} // RVA: 0x7A8B5EE20
        public void get_highButton(){} // RVA: 0x7A8B5C760
        public void set_highButton(){} // RVA: 0x7A8B61600
        public void get_value(){} // RVA: 0x7AF19CD00
        public void set_value(){} // RVA: 0x7AF19CD30
        public void get_lowValue(){} // RVA: 0x7AF19CD60
        public void set_lowValue(){} // RVA: 0x7AF19CDB0
        public void get_highValue(){} // RVA: 0x7AF19CE10
        public void set_highValue(){} // RVA: 0x7AF19CE60
        public void set_direction(){} // RVA: 0x7AF19CEC0
        public void .ctor(){} // RVA: 0x7AF19D0D0
        public void Adjust(){} // RVA: 0x7AF19D680
        public void OnSliderValueChange(){} // RVA: 0x7AF19D710
        public void ScrollPageUp(){} // RVA: 0x7AF19D9D0
        public void ScrollPageDown(){} // RVA: 0x7AF19DAD0
        public void .cctor(){} // RVA: 0x7AF19DBD0
    }

    public class SerializedVirtualizationData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SetupDragAndDropArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F01EC0
    }

    public class Slider : BaseSlider`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF1A7980
        public void ApplyInputDeviceDelta(){} // RVA: 0x7AF1A7AF0
        public void SliderLerpUnclamped(){} // RVA: 0x7AF1A7CC0
        public void SliderNormalizeValue(){} // RVA: 0x7AF189220
        public void ParseStringToValue(){} // RVA: 0x7AF1A7E80
        public void ComputeValueFromKey(){} // RVA: 0x7AF1A7F10
        public void .cctor(){} // RVA: 0x7AF1A81A0
    }

    public class SliderInt : BaseSlider`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF1A8F00
        public void get_pageSize(){} // RVA: 0x7AF1A9070
        public void set_pageSize(){} // RVA: 0x7AF1A90C0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7AF1A9120
        public void SliderLerpUnclamped(){} // RVA: 0x7AF1A92E0
        public void SliderNormalizeValue(){} // RVA: 0x7AF1A9300
        public void ParseStringToValue(){} // RVA: 0x7AF1A9330
        public void ComputeValueAndDirectionFromClick(){} // RVA: 0x7AF1A9410
        public void ComputeValueFromKey(){} // RVA: 0x7AF1A96A0
        public void .cctor(){} // RVA: 0x7AF1A9930
    }

    public class SortColumnDescription : Object
    {
        // ── Methods ──
        public void get_columnName(){} // RVA: 0x7A80DA7B0
        public void set_columnName(){} // RVA: 0x7AF196F50
        public void get_columnIndex(){} // RVA: 0x7A8124910
        public void set_columnIndex(){} // RVA: 0x7AF197010
        public void get_column(){} // RVA: 0x7A8105330
        public void set_column(){} // RVA: 0x7A80D8E80
        public void get_direction(){} // RVA: 0x7A851DB90
        public void set_direction(){} // RVA: 0x7AF197040
        public void add_changed(){} // RVA: 0x7AF197070
        public void remove_changed(){} // RVA: 0x7AF197180
        public void .ctor(){} // RVA: 0x7AF197300
    }

    public class SortColumnDescriptions : Object
    {
        // ── Methods ──
        public void add_changed(){} // RVA: 0x7AF197350
        public void remove_changed(){} // RVA: 0x7AF197440
        public void GetEnumerator(){} // RVA: 0x7AF197530
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AF197530
        public void Add(){} // RVA: 0x7AF197580
        public void Clear(){} // RVA: 0x7AF1975F0
        public void Contains(){} // RVA: 0x7AF197780
        public void CopyTo(){} // RVA: 0x7AF1977E0
        public void Remove(){} // RVA: 0x7AF1978C0
        public void OnDescriptionChanged(){} // RVA: 0x7A8447B80
        public void get_Count(){} // RVA: 0x7AF197AF0
        public void get_IsReadOnly(){} // RVA: 0x7AF197B40
        public void Insert(){} // RVA: 0x7AF197B90
        public void .ctor(){} // RVA: 0x7AF197EB0
    }

    public class Spacing : ValueType
    {
        // ── Methods ──
        public void get_horizontal(){} // RVA: 0x7A7EDBC00
        public void get_vertical(){} // RVA: 0x7A7EDBC20
        public void .ctor(){} // RVA: 0x7A75F5650
        public void op_Subtraction(){} // RVA: 0x7AF21B230
    }

    public class StartDragArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F01FA0
        public void get_title(){} // RVA: 0x7A765F710
        public void get_visualMode(){} // RVA: 0x7A75FEFA0
        public void get_genericData(){} // RVA: 0x7A7664CF0
        public void set_genericData(){} // RVA: 0x7A7664E50
        public void get_unityObjectReferences(){} // RVA: 0x7A767FF40
        public void set_unityObjectReferences(){} // RVA: 0x7A767FF60
        public void SetGenericData(){} // RVA: 0x7A7F01FB0
    }

    public class StyleBackgroundSize : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7F08460
        public void get_keyword(){} // RVA: 0x7A7829640
        public void .ctor(){} // RVA: 0x7A7E2ADA0
        public void op_Equality(){} // RVA: 0x7AF245590
        public void op_Implicit(){} // RVA: 0x7AF245680
        public void Equals(){} // RVA: 0x7A7F084D0
        public void GetHashCode(){} // RVA: 0x7A7F08570
        public void ToString(){} // RVA: 0x7A7F085E0
    }

    public class StyleCache : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7AF10CF10
        public void SetValue(){} // RVA: 0x7AF10CFB0
        public void .cctor(){} // RVA: 0x7AF10D060
    }

    public class StyleColor : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7F08660
        public void get_keyword(){} // RVA: 0x7A7EDA5B0
        public void .ctor(){} // RVA: 0x7A7909770
        public void op_Equality(){} // RVA: 0x7AF245950
        public void op_Implicit(){} // RVA: 0x7AF2459D0
        public void Equals(){} // RVA: 0x7A7F08710
        public void GetHashCode(){} // RVA: 0x7A7F08800
        public void ToString(){} // RVA: 0x7A7F08820
    }

    public class StyleComplexSelector : Object
    {
        // ── Methods ──
        public void get_specificity(){} // RVA: 0x7AC1CB330
        public void get_rule(){} // RVA: 0x7A8105330
        public void set_rule(){} // RVA: 0x7A80D8E80
        public void get_isSimple(){} // RVA: 0x7AEF244B0
        public void get_selectors(){} // RVA: 0x7AEF66F80
        public void set_selectors(){} // RVA: 0x7AF250DD0
        public void OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void OnAfterDeserialize(){} // RVA: 0x7AF250E40
        public void CachePseudoStateMasks(){} // RVA: 0x7AF250E70
        public void ToString(){} // RVA: 0x7AF251770
        public void StyleSelectorPartCompare(){} // RVA: 0x7AF251AD0
        public void CalculateHashes(){} // RVA: 0x7AF251B20
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AF252340
    }

    public class StyleComplexSelector[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class StyleCursor : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7F088B0
        public void get_keyword(){} // RVA: 0x7A7AD1FC0
        public void .ctor(){} // RVA: 0x7A7F08910
        public void op_Equality(){} // RVA: 0x7AF245D20
        public void op_Implicit(){} // RVA: 0x7AF245E20
        public void Equals(){} // RVA: 0x7A7F089A0
        public void GetHashCode(){} // RVA: 0x7A7F08A40
        public void ToString(){} // RVA: 0x7A7F08A70
    }

    public class StyleDataRef`1 : ValueType
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7A8051B10
        public void Release(){} // RVA: 0x7A7E18770
        public void CopyFrom(){} // RVA: 0x7A8051B10
        public void Read(){} // RVA: 0x7A7E00680
        public void Write(){} // RVA: 0x7A7E00680
        public void Create(){} // RVA: 0x7A8051B10
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void op_Equality(){} // RVA: 0x7A8051B10
        public void Equals(){} // RVA: 0x7A7E019D0
        public void ReferenceEquals(){} // RVA: 0x7A8051B10
    }

    public class StyleDataRef`1 : ValueType
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7A7A391B0
        public void Release(){} // RVA: 0x7A7A391F0
        public void CopyFrom(){} // RVA: 0x7A7A39200
        public void Read(){} // RVA: 0x7A7A39210
        public void Write(){} // RVA: 0x7A7A39230
        public void Create(){} // RVA: 0x7ABEA9230
        public void GetHashCode(){} // RVA: 0x7A7A39240
        public void op_Equality(){} // RVA: 0x7ABEA9360
        public void Equals(){} // RVA: 0x7A7A392A0
        public void ReferenceEquals(){} // RVA: 0x7A7A393B0
    }

    public class StyleDataRef`1 : ValueType
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7A7A391B0
        public void Release(){} // RVA: 0x7A7A391F0
        public void CopyFrom(){} // RVA: 0x7A7A393C0
        public void Read(){} // RVA: 0x7A7A39210
        public void Write(){} // RVA: 0x7A7A393D0
        public void Create(){} // RVA: 0x7ABEA9230
        public void GetHashCode(){} // RVA: 0x7A7A393E0
        public void op_Equality(){} // RVA: 0x7ABEA9B30
        public void Equals(){} // RVA: 0x7A7A39440
        public void ReferenceEquals(){} // RVA: 0x7A7A393B0
    }

    public class StyleDataRef`1 : ValueType
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7A7A391B0
        public void Release(){} // RVA: 0x7A7A391F0
        public void CopyFrom(){} // RVA: 0x7A7A39550
        public void Read(){} // RVA: 0x7A7A39210
        public void Write(){} // RVA: 0x7A7A39560
        public void Create(){} // RVA: 0x7ABEA9230
        public void GetHashCode(){} // RVA: 0x7A7A39570
        public void op_Equality(){} // RVA: 0x7ABEAA1A0
        public void Equals(){} // RVA: 0x7A7A395D0
        public void ReferenceEquals(){} // RVA: 0x7A7A393B0
    }

    public class StyleDataRef`1 : ValueType
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7A7A391B0
        public void Release(){} // RVA: 0x7A7A391F0
        public void CopyFrom(){} // RVA: 0x7A7A396E0
        public void Read(){} // RVA: 0x7A7A39210
        public void Write(){} // RVA: 0x7A7A396F0
        public void Create(){} // RVA: 0x7ABEA9230
        public void GetHashCode(){} // RVA: 0x7A7A39700
        public void op_Equality(){} // RVA: 0x7ABEAA810
        public void Equals(){} // RVA: 0x7A7A39760
        public void ReferenceEquals(){} // RVA: 0x7A7A393B0
    }

    public class StyleDataRef`1 : ValueType
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7A7A391B0
        public void Release(){} // RVA: 0x7A7A391F0
        public void CopyFrom(){} // RVA: 0x7A7A39870
        public void Read(){} // RVA: 0x7A7A39210
        public void Write(){} // RVA: 0x7A7A39880
        public void Create(){} // RVA: 0x7ABEA9230
        public void GetHashCode(){} // RVA: 0x7A7A39890
        public void op_Equality(){} // RVA: 0x7ABEAADE0
        public void Equals(){} // RVA: 0x7A7A398F0
        public void ReferenceEquals(){} // RVA: 0x7A7A393B0
    }

    public class StyleDataRef`1 : ValueType
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7A7A391B0
        public void Release(){} // RVA: 0x7A7A391F0
        public void CopyFrom(){} // RVA: 0x7A7A39A00
        public void Read(){} // RVA: 0x7A7A39210
        public void Write(){} // RVA: 0x7A7A39A10
        public void Create(){} // RVA: 0x7ABEA9230
        public void GetHashCode(){} // RVA: 0x7A7A39A20
        public void op_Equality(){} // RVA: 0x7ABEAB4C0
        public void Equals(){} // RVA: 0x7A7A39A80
        public void ReferenceEquals(){} // RVA: 0x7A7A393B0
    }

    public class StyleEnum`1 : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A8051B10
        public void get_keyword(){} // RVA: 0x7A7E00710
        public void .ctor(){} // RVA: 0x7A8051B10
        public void op_Equality(){} // RVA: 0x7A8051B10
        public void op_Inequality(){} // RVA: 0x7A8051B10
        public void op_Implicit(){} // RVA: 0x7A8051B10
        public void Equals(){} // RVA: 0x7A7E019D0
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void ToString(){} // RVA: 0x7A7E00680
    }

    public class StyleFloat : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7F08AF0
        public void get_keyword(){} // RVA: 0x7A7A39F60
        public void .ctor(){} // RVA: 0x7A77E7A70
        public void op_Equality(){} // RVA: 0x7AF246130
        public void op_Implicit(){} // RVA: 0x7AF21B320
        public void Equals(){} // RVA: 0x7A7F08B50
        public void GetHashCode(){} // RVA: 0x7A7F06660
        public void ToString(){} // RVA: 0x7A7F08C00
    }

    public class StyleFont : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7F08C90
        public void get_keyword(){} // RVA: 0x7A79D4850
        public void .ctor(){} // RVA: 0x7A7CAC8A0
        public void op_Equality(){} // RVA: 0x7AF246340
        public void op_Implicit(){} // RVA: 0x7AF246490
        public void Equals(){} // RVA: 0x7A7F08D20
        public void GetHashCode(){} // RVA: 0x7A7F08DC0
        public void ToString(){} // RVA: 0x7A7F08EC0
    }

    public class StyleFontDefinition : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7F08F50
        public void get_keyword(){} // RVA: 0x7A79EAED0
        public void .ctor(){} // RVA: 0x7A7F08FD0
        public void op_Implicit(){} // RVA: 0x7AF246970
        public void Equals(){} // RVA: 0x7A7F09080
        public void GetHashCode(){} // RVA: 0x7A7F09140
    }

    public class StyleInt : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7A39F50
        public void get_keyword(){} // RVA: 0x7A7A39F60
        public void .ctor(){} // RVA: 0x7A7A39FF0
        public void op_Equality(){} // RVA: 0x7AF246B30
        public void op_Implicit(){} // RVA: 0x7AF246160
        public void Equals(){} // RVA: 0x7A7F091A0
        public void GetHashCode(){} // RVA: 0x7A7F09240
        public void ToString(){} // RVA: 0x7A7F09250
    }

    public class StyleLength : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7F092C0
        public void get_keyword(){} // RVA: 0x7A79D4850
        public void .ctor(){} // RVA: 0x7A7F09380
        public void op_Equality(){} // RVA: 0x7AF246D90
        public void op_Implicit(){} // RVA: 0x7AF246E80
        public void Equals(){} // RVA: 0x7A7F09430
        public void GetHashCode(){} // RVA: 0x7A7F09510
        public void ToString(){} // RVA: 0x7A7F09540
    }

    public class StyleMatchingContext : Object
    {
        // ── Methods ──
        public void get_styleSheetCount(){} // RVA: 0x7AF10DD50
        public void .ctor(){} // RVA: 0x7AF10DDA0
        public void AddStyleSheet(){} // RVA: 0x7AF10E0E0
        public void RemoveStyleSheetRange(){} // RVA: 0x7AF10E1E0
        public void GetStyleSheetAt(){} // RVA: 0x7AF10E250
    }

    public class StyleProperty : Object
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7AB1AC740
        public void get_values(){} // RVA: 0x7AE8145B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class StylePropertyAnimationSystem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF249610
        public void GetOrCreate(){} // RVA: 0x7A8051B10
        public void StartTransition(){} // RVA: 0x7AF24B320
        public void CancelAllAnimations(){} // RVA: 0x7AF24B6A0
        public void CancelAnimation(){} // RVA: 0x7AF24B8B0
        public void UpdateAnimation(){} // RVA: 0x7AF24B950
        public void GetAllAnimations(){} // RVA: 0x7AF24B9F0
        public void UpdateTracking(){} // RVA: 0x7A7E18800
        public void CurrentTimeMs(){} // RVA: 0x7AB1AC740
        public void Update(){} // RVA: 0x7AF24BB80
    }

    public class StylePropertyName : ValueType
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x7A765F070
        public void get_name(){} // RVA: 0x7A765F080
        public void StylePropertyIdFromString(){} // RVA: 0x7AF250920
        public void .ctor(){} // RVA: 0x7A7F0A930
        public void op_Equality(){} // RVA: 0x7AEE7F280
        public void op_Inequality(){} // RVA: 0x7AF250D00
        public void op_Implicit(){} // RVA: 0x7AF250D10
        public void GetHashCode(){} // RVA: 0x7A79EAED0
        public void Equals(){} // RVA: 0x7A7ED6420
        public void ToString(){} // RVA: 0x7A7E42C20
    }

    public class StylePropertyNameCollection : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7637E60
        public void GetEnumerator(){} // RVA: 0x7A7F027A0
        public void System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator(){} // RVA: 0x7A7F027D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7F02840
    }

    public class StylePropertyName[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2DA8E0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA297A10
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class StyleProperty[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class StyleRotate : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7F09640
        public void get_keyword(){} // RVA: 0x7A7AD1FC0
        public void .ctor(){} // RVA: 0x7A7F096A0
        public void op_Equality(){} // RVA: 0x7AF2471F0
        public void op_Implicit(){} // RVA: 0x7AF247280
        public void Equals(){} // RVA: 0x7A7F09750
        public void GetHashCode(){} // RVA: 0x7A7F09850
        public void ToString(){} // RVA: 0x7A7F09880
    }

    public class StyleRule : Object
    {
        // ── Methods ──
        public void get_properties(){} // RVA: 0x7AB1AC740
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class StyleRule[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class StyleScale : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7F09960
        public void get_keyword(){} // RVA: 0x7A7EDA5B0
        public void .ctor(){} // RVA: 0x7A7909770
        public void op_Equality(){} // RVA: 0x7AF2475B0
        public void op_Implicit(){} // RVA: 0x7AF247620
        public void Equals(){} // RVA: 0x7A7F09A10
        public void GetHashCode(){} // RVA: 0x7A7F09AE0
        public void ToString(){} // RVA: 0x7A7F09B50
    }

    public class StyleSelector : Object
    {
        // ── Methods ──
        public void get_parts(){} // RVA: 0x7AB1AC740
        public void set_parts(){} // RVA: 0x7A80D8E20
        public void get_previousRelationship(){} // RVA: 0x7ABB8C660
        public void set_previousRelationship(){} // RVA: 0x7A84385B0
        public void ToString(){} // RVA: 0x7AF2524E0
        public void .ctor(){} // RVA: 0x7AF2527B0
    }

    public class StyleSelectorPart : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A79E3DA0
        public void get_type(){} // RVA: 0x7A79D4850
        public void set_type(){} // RVA: 0x7A767FBC0
        public void ToString(){} // RVA: 0x7A7F0ACB0
        public void CreateClass(){} // RVA: 0x7AF2529B0
        public void CreateId(){} // RVA: 0x7AF252A40
        public void CreatePredicate(){} // RVA: 0x7AF252AD0
    }

    public class StyleSheet : ScriptableObject
    {
        // ── Methods ──
        public void get_importedWithErrors(){} // RVA: 0x7AEE6F400
        public void set_importedWithErrors(){} // RVA: 0x7A80F26E0
        public void get_importedWithWarnings(){} // RVA: 0x7AF252B60
        public void set_importedWithWarnings(){} // RVA: 0x7A8D0E640
        public void get_rules(){} // RVA: 0x7AE8145B0
        public void set_rules(){} // RVA: 0x7AF252B70
        public void get_complexSelectors(){} // RVA: 0x7AEF244A0
        public void set_complexSelectors(){} // RVA: 0x7AF252BD0
        public void get_flattenedRecursiveImports(){} // RVA: 0x7AEF67270
        public void get_contentHash(){} // RVA: 0x7AF252C30
        public void set_contentHash(){} // RVA: 0x7A9A93880
        public void get_isDefaultStyleSheet(){} // RVA: 0x7AF252C40
        public void set_isDefaultStyleSheet(){} // RVA: 0x7AF252C50
        public void TryCheckAccess(){} // RVA: 0x7A8051B10
        public void CheckAccess(){} // RVA: 0x7A8051B10
        public void OnEnable(){} // RVA: 0x7AF252DC0
        public void FlattenImportedStyleSheetsRecursive(){} // RVA: 0x7AF252EA0
        public void SetupReferences(){} // RVA: 0x7AF253030
        public void ReadKeyword(){} // RVA: 0x7AF0F2F10
        public void ReadFloat(){} // RVA: 0x7AF253770
        public void TryReadFloat(){} // RVA: 0x7AF253850
        public void ReadDimension(){} // RVA: 0x7AF253960
        public void TryReadDimension(){} // RVA: 0x7AF253A40
        public void ReadColor(){} // RVA: 0x7AF253B60
        public void TryReadColor(){} // RVA: 0x7AF253C10
        public void ReadString(){} // RVA: 0x7AF253CB0
        public void TryReadString(){} // RVA: 0x7AF253D30
        public void ReadEnum(){} // RVA: 0x7AF253DD0
        public void TryReadEnum(){} // RVA: 0x7AF253E50
        public void ReadVariable(){} // RVA: 0x7AF253EF0
        public void TryReadVariable(){} // RVA: 0x7AF253F70
        public void ReadResourcePath(){} // RVA: 0x7AF254010
        public void TryReadResourcePath(){} // RVA: 0x7AF254090
        public void ReadAssetReference(){} // RVA: 0x7AF254130
        public void ReadMissingAssetReferenceUrl(){} // RVA: 0x7AF2541B0
        public void TryReadAssetReference(){} // RVA: 0x7AF254230
        public void ReadFunction(){} // RVA: 0x7AF0F2F10
        public void ReadFunctionName(){} // RVA: 0x7AF2542D0
        public void ReadScalableImage(){} // RVA: 0x7AF254570
        public void CustomStartsWith(){} // RVA: 0x7AF254620
        public void .ctor(){} // RVA: 0x7A82F4A40
        public void .cctor(){} // RVA: 0x7AF254700
    }

    public class StyleSheet[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class StyleTextShadow : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7F09ED0
        public void get_keyword(){} // RVA: 0x7A79EAED0
        public void .ctor(){} // RVA: 0x7A7F09F50
        public void op_Equality(){} // RVA: 0x7AF247CB0
        public void op_Implicit(){} // RVA: 0x7AF247DB0
        public void Equals(){} // RVA: 0x7A7F09FB0
        public void GetHashCode(){} // RVA: 0x7A7F0A060
        public void ToString(){} // RVA: 0x7A7F0A0F0
    }

    public class StyleTransformOrigin : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7F0A170
        public void get_keyword(){} // RVA: 0x7A7829640
        public void .ctor(){} // RVA: 0x7A7E2ADA0
        public void op_Equality(){} // RVA: 0x7AF248110
        public void op_Implicit(){} // RVA: 0x7AF245680
        public void Equals(){} // RVA: 0x7A7F0A1D0
        public void GetHashCode(){} // RVA: 0x7A7F0A270
        public void ToString(){} // RVA: 0x7A7F0A2A0
    }

    public class StyleTranslate : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A7F09C40
        public void get_keyword(){} // RVA: 0x7A7AD1FC0
        public void .ctor(){} // RVA: 0x7A7F096A0
        public void op_Equality(){} // RVA: 0x7AF247920
        public void op_Implicit(){} // RVA: 0x7AF2479B0
        public void Equals(){} // RVA: 0x7A7F09D20
        public void GetHashCode(){} // RVA: 0x7A7F09E20
        public void ToString(){} // RVA: 0x7A7F09E50
    }

    public class StyleValueCollection : Object
    {
        // ── Methods ──
        public void GetStyleLength(){} // RVA: 0x7AF244070
        public void GetStyleFloat(){} // RVA: 0x7AF244120
        public void GetStyleInt(){} // RVA: 0x7AF244190
        public void TryGetStyleValue(){} // RVA: 0x7AF244210
        public void SetStyleValue(){} // RVA: 0x7AF2443C0
        public void .ctor(){} // RVA: 0x7AF2445D0
    }

    public class StyleValueExtensions : Object
    {
        // ── Methods ──
        public void DebugString(){} // RVA: 0x7A7E00BA0
        public void ToYogaValue(){} // RVA: 0x7AF248430
        public void ToLength(){} // RVA: 0x7AF248A00
        public void ToRotate(){} // RVA: 0x7AF2486C0
        public void ToScale(){} // RVA: 0x7AF2487E0
        public void ToTranslate(){} // RVA: 0x7AF2488F0
        public void CopyFrom(){} // RVA: 0x7A7E18AA0
    }

    public class StyleValueFunctionExtension : Object
    {
        // ── Methods ──
        public void ToUssString(){} // RVA: 0x7AF2547B0
    }

    public class StyleValueHandle : ValueType
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7A79EAED0
        public void set_valueType(){} // RVA: 0x7A76134D0
    }

    public class StyleValueKeywordExtension : Object
    {
        // ── Methods ──
        public void ToUssString(){} // RVA: 0x7AF2548D0
    }

    public class StyleVariable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7660880
        public void GetHashCode(){} // RVA: 0x7A7F0AD00
    }

    public class StyleVariableContext : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AF254B30
        public void AddInitialRange(){} // RVA: 0x7AF254C90
        public void Clear(){} // RVA: 0x7AF254DD0
        public void .ctor(){} // RVA: 0x7AF254FE0
        public void TryFindVariable(){} // RVA: 0x7AF255170
        public void GetVariableHash(){} // RVA: 0x7AEE980C0
        public void .cctor(){} // RVA: 0x7AF2552C0
    }

    public class StyleVariableResolver : Object
    {
        // ── Methods ──
        public void get_currentSheet(){} // RVA: 0x7A8292C30
        public void get_currentHandles(){} // RVA: 0x7A8154D80
        public void get_resolvedValues(){} // RVA: 0x7A80DA7B0
        public void get_variableContext(){} // RVA: 0x7A8152D80
        public void set_variableContext(){} // RVA: 0x7A8152D90
        public void Init(){} // RVA: 0x7AF255370
        public void PushContext(){} // RVA: 0x7AF2554B0
        public void PopContext(){} // RVA: 0x7AF2556D0
        public void AddValue(){} // RVA: 0x7AF2558A0
        public void ResolveVarFunction(){} // RVA: 0x7AF255B00
        public void ValidateResolvedValues(){} // RVA: 0x7AF255C90
        public void ResolveVariable(){} // RVA: 0x7AF255E80
        public void ResolveFallback(){} // RVA: 0x7AF2561E0
        public void ParseVarFunction(){} // RVA: 0x7AF256510
        public void .ctor(){} // RVA: 0x7AF256600
        public void .cctor(){} // RVA: 0x7AF256950
    }

    public class StyleVariable[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1330
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DF80
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2C90
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250480
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DF80
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}