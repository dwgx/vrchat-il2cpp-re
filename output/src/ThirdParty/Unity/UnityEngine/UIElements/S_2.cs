// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 31
// Methods: 327

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class SafeHandleAccess : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x93050
        public void IsNull(){} // RVA: 0x9A9C70
        public void op_Implicit(){} // RVA: 0x80A3B80
    }

    public class SavePersistentViewData : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA0FE0
        public void Invoke(){} // RVA: 0xBA10B0
    }

    public class ScheduledItem : Object
    {
        // ── Methods ──
        public void get_startMs(){} // RVA: 0xB465B0
        public void set_startMs(){} // RVA: 0x15428E0
        public void get_delayMs(){} // RVA: 0xB700F0
        public void set_delayMs(){} // RVA: 0x13B3F80
        public void get_intervalMs(){} // RVA: 0xB70160
        public void set_intervalMs(){} // RVA: 0x116B360
        public void get_endTimeMs(){} // RVA: 0xD33E60
        public void .ctor(){} // RVA: 0x80AFCF0
        public void ResetStartTime(){} // RVA: 0x80AFDE0
        public void PerformTimerUpdate(){} // RVA: 0x894320
        public void OnItemUnscheduled(){} // RVA: 0xB43310
        public void ShouldUnschedule(){} // RVA: 0x80AFE30
        public void .cctor(){} // RVA: 0x80AFE60
    }

    public class ScrollView : VisualElement
    {
        // ── Methods ──
        public void get_horizontalScrollerVisibility(){} // RVA: 0x8017C10
        public void set_horizontalScrollerVisibility(){} // RVA: 0x8017C20
        public void get_verticalScrollerVisibility(){} // RVA: 0x8017D30
        public void set_verticalScrollerVisibility(){} // RVA: 0x8017D40
        public void get_elasticAnimationIntervalMs(){} // RVA: 0x8017E60
        public void set_elasticAnimationIntervalMs(){} // RVA: 0x8017E70
        public void set_showHorizontal(){} // RVA: 0x8017FF0
        public void set_showVertical(){} // RVA: 0x8018010
        public void get_needsHorizontal(){} // RVA: 0x8018030
        public void get_needsVertical(){} // RVA: 0x8018080
        public void get_isVerticalScrollDisplayed(){} // RVA: 0x80180D0
        public void get_isHorizontalScrollDisplayed(){} // RVA: 0x8018140
        public void get_scrollOffset(){} // RVA: 0x80181B0
        public void set_scrollOffset(){} // RVA: 0x80181D0
        public void get_horizontalPageSize(){} // RVA: 0x800F170
        public void set_horizontalPageSize(){} // RVA: 0x8018400
        public void get_verticalPageSize(){} // RVA: 0x80184B0
        public void set_verticalPageSize(){} // RVA: 0x80184C0
        public void get_mouseWheelScrollSize(){} // RVA: 0x6106670
        public void set_mouseWheelScrollSize(){} // RVA: 0x8018570
        public void get_scrollableWidth(){} // RVA: 0x8018640
        public void get_scrollableHeight(){} // RVA: 0x80186D0
        public void get_hasInertia(){} // RVA: 0x8018760
        public void get_scrollDecelerationRate(){} // RVA: 0x8018780
        public void set_scrollDecelerationRate(){} // RVA: 0x8018790
        public void get_elasticity(){} // RVA: 0x80188B0
        public void set_elasticity(){} // RVA: 0x80188C0
        public void get_touchScrollBehavior(){} // RVA: 0x80189E0
        public void set_touchScrollBehavior(){} // RVA: 0x80189F0
        public void get_nestedInteractionKind(){} // RVA: 0x60EFE60
        public void set_nestedInteractionKind(){} // RVA: 0x8018B10
        public void OnHorizontalScrollDragElementChanged(){} // RVA: 0x8018BA0
        public void OnVerticalScrollDragElementChanged(){} // RVA: 0x8018C00
        public void UpdateHorizontalSliderPageSize(){} // RVA: 0x8018C60
        public void UpdateVerticalSliderPageSize(){} // RVA: 0x8018DB0
        public void UpdateContentViewTransform(){} // RVA: 0x8018F00
        public void ScrollTo(){} // RVA: 0x8019190
        public void GetXDeltaOffset(){} // RVA: 0x8019390
        public void GetYDeltaOffset(){} // RVA: 0x80195B0
        public void GetDeltaDistance(){} // RVA: 0x80197D0
        public void get_contentViewport(){} // RVA: 0x1651990
        public void get_horizontalScroller(){} // RVA: 0x16594C0
        public void get_verticalScroller(){} // RVA: 0x164C740
        public void get_contentContainer(){} // RVA: 0x8019840
        public void .ctor(){} // RVA: 0x8019860
        public void get_mode(){} // RVA: 0x801ABE0
        public void set_mode(){} // RVA: 0x801ABF0
        public void SetScrollViewMode(){} // RVA: 0x801AC90
        public void OnAttachToPanel(){} // RVA: 0x801B130
        public void OnDetachFromPanel(){} // RVA: 0x801B6F0
        public void OnPointerCapture(){} // RVA: 0x801C2D0
        public void OnPointerCaptureOut(){} // RVA: 0x801C3E0
        public void OnGeometryChanged(){} // RVA: 0x801C690
        public void OnVerticalSliderViewDataRestored(){} // RVA: 0x801C970
        public void OnHorizontalSliderViewDataRestored(){} // RVA: 0x801CA20
        public void OnVerticalScrollerSetValueWithoutNotify(){} // RVA: 0x801CAD0
        public void OnHorizontalScrollerSetValueWithoutNotify(){} // RVA: 0x801CAF0
        public void ScheduleResetLayoutPass(){} // RVA: 0x801CB10
        public void ResetLayoutPass(){} // RVA: 0x801CC50
        public void ComputeElasticOffset(){} // RVA: 0x801CC60
        public void ComputeInitialSpringBackVelocity(){} // RVA: 0x801CDE0
        public void SpringBack(){} // RVA: 0x801CEE0
        public void ApplyScrollInertia(){} // RVA: 0x801D0D0
        public void PostPointerUpAnimation(){} // RVA: 0x801D440
        public void OnPointerDown(){} // RVA: 0x801D6E0
        public void OnPointerMove(){} // RVA: 0x801D9A0
        public void OnPointerCancel(){} // RVA: 0x801DC50
        public void OnPointerUp(){} // RVA: 0x801DCB0
        public void InitTouchScrolling(){} // RVA: 0x801DDA0
        public void ComputeTouchScrolling(){} // RVA: 0x801E100
        public void ApplyTouchScrolling(){} // RVA: 0x801E550
        public void ReleaseScrolling(){} // RVA: 0x801E860
        public void ExecuteElasticSpringAnimation(){} // RVA: 0x801E9E0
        public void AdjustScrollers(){} // RVA: 0x801EC00
        public void UpdateScrollers(){} // RVA: 0x801EDC0
        public void OnScrollersGeometryChanged(){} // RVA: 0x801F340
        public void OnScrollWheel(){} // RVA: 0x801F510
        public void OnRootCustomStyleResolved(){} // RVA: 0x801F9E0
        public void MarkSingleLineHeightDirty(){} // RVA: 0x801F9E0
        public void OnRootPointerUp(){} // RVA: 0x801F9F0
        public void ReadSingleLineHeight(){} // RVA: 0x801FA00
        public void UpdateElasticBehaviour(){} // RVA: 0x801FF60
        public void SetScrollOffsetWithoutNotify(){} // RVA: 0x8020220
        public void OnViewDataReady(){} // RVA: 0x8020330
        public void .cctor(){} // RVA: 0x80203F0
        public void <.ctor>b__140_0(){} // RVA: 0x8021AF0
        public void <.ctor>b__140_1(){} // RVA: 0x8021B20
    }

    public class SetValueVisitor`1 : PathVisitor
    {
        // ── Methods ──
        public void get_group(){} // RVA: 0x87C0A0
        public void set_group(){} // RVA: 0x894320
        public void Reset(){} // RVA: 0x894290
        public void VisitPath(){} // RVA: 0x8954D0
        public void .ctor(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class SetupDragAndDropArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A4AF0
    }

    public class SliderInt : BaseSlider`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x80248F0
        public void get_pageSize(){} // RVA: 0x8024A60
        public void set_pageSize(){} // RVA: 0x8024AB0
        public void ApplyInputDeviceDelta(){} // RVA: 0x8024B90
        public void SliderLerpUnclamped(){} // RVA: 0x8024D50
        public void SliderNormalizeValue(){} // RVA: 0x8024D70
        public void SliderRange(){} // RVA: 0x8024DB0
        public void ParseStringToValue(){} // RVA: 0x8024E40
        public void ComputeValueAndDirectionFromClick(){} // RVA: 0x80250B0
        public void ComputeValueFromKey(){} // RVA: 0x8025340
        public void .cctor(){} // RVA: 0x80255D0
    }

    public class Spacing : ValueType
    {
        // ── Methods ──
        public void get_horizontal(){} // RVA: 0x961C60
        public void get_vertical(){} // RVA: 0x961C80
        public void .ctor(){} // RVA: 0x4FE0
        public void op_Subtraction(){} // RVA: 0x80B1470
    }

    public class StartDragArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A4D20
        public void get_title(){} // RVA: 0x77900
        public void get_visualMode(){} // RVA: 0x14790
        public void get_genericData(){} // RVA: 0x7E450
        public void set_genericData(){} // RVA: 0x7E3E0
        public void get_unityObjectReferences(){} // RVA: 0x931A0
        public void set_unityObjectReferences(){} // RVA: 0x93120
        public void get_assetPaths(){} // RVA: 0x8C630
        public void set_assetPaths(){} // RVA: 0x8C670
        public void SetGenericData(){} // RVA: 0x9A4D30
    }

    public class StyleCache : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7F33E50
        public void SetValue(){} // RVA: 0x7F33EF0
        public void .cctor(){} // RVA: 0x7F33FA0
    }

    public class StyleComplexSelector : Object
    {
        // ── Methods ──
        public void get_specificity(){} // RVA: 0x4EDA0B0
        public void get_rule(){} // RVA: 0xB70160
        public void set_rule(){} // RVA: 0xB44DC0
        public void get_isSimple(){} // RVA: 0x7C246B0
        public void get_selectors(){} // RVA: 0x7C7DF30
        public void set_selectors(){} // RVA: 0x7EE6580
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void OnAfterDeserialize(){} // RVA: 0x7EE65F0
        public void CachePseudoStateMasks(){} // RVA: 0x7EE6620
        public void ToString(){} // RVA: 0x7EE6F20
        public void StyleSelectorPartCompare(){} // RVA: 0x7EE7260
        public void CalculateHashes(){} // RVA: 0x7EE72B0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x7EE7AD0
    }

    public class StyleComplexSelector[] : Array
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

    public class StyleMatchingContext : Object
    {
        // ── Methods ──
        public void get_styleSheetCount(){} // RVA: 0x7F34CE0
        public void .ctor(){} // RVA: 0x7F34D30
        public void AddStyleSheet(){} // RVA: 0x7F35070
        public void RemoveStyleSheetRange(){} // RVA: 0x7F35170
        public void GetStyleSheetAt(){} // RVA: 0x7F351E0
    }

    public class StyleProperty : Object
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x3E42230
        public void get_values(){} // RVA: 0x7489A40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StylePropertyAnimationSystem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7EDE990
        public void GetOrCreate(){} // RVA: 0xA94080
        public void StartTransition(){} // RVA: 0x7EE0650
        public void StartTransitionEnum(){} // RVA: 0x7EDF1A0
        public void CancelAllAnimations(){} // RVA: 0x7EE09D0
        public void CancelAnimation(){} // RVA: 0x7EE0BE0
        public void UpdateAnimation(){} // RVA: 0x7EE0C80
        public void GetAllAnimations(){} // RVA: 0x7EE0D20
        public void UpdateTracking(){} // RVA: 0x894320
        public void CurrentTimeMs(){} // RVA: 0x3E42230
        public void Update(){} // RVA: 0x7EE0EB0
    }

    public class StylePropertyNameCollection : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x47F10
        public void GetEnumerator(){} // RVA: 0x9A58A0
        public void System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator(){} // RVA: 0x9A58D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x9A5940
    }

    public class StylePropertyName[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EBB010
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E73620
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class StyleProperty[] : Array
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

    public class StyleRule : Object
    {
        // ── Methods ──
        public void get_properties(){} // RVA: 0x3E42230
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StyleRule[] : Array
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

    public class StyleSelector : Object
    {
        // ── Methods ──
        public void get_parts(){} // RVA: 0x3E42230
        public void set_parts(){} // RVA: 0xB44D60
        public void get_previousRelationship(){} // RVA: 0x47FDFF0
        public void set_previousRelationship(){} // RVA: 0x1033F40
        public void ToString(){} // RVA: 0x7EE7C70
        public void .ctor(){} // RVA: 0x7EE7F20
    }

    public class StyleSelectorPart : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x44D9F0
        public void get_type(){} // RVA: 0x438050
        public void set_type(){} // RVA: 0x92DD0
        public void ToString(){} // RVA: 0x999F80
        public void CreateClass(){} // RVA: 0x7EE8120
        public void CreateId(){} // RVA: 0x7EE81B0
        public void CreatePredicate(){} // RVA: 0x7EE8240
    }

    public class StyleSelector[] : Array
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

    public class StyleSheet[] : Array
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

    public class StyleValueFunctionExtension : Object
    {
        // ── Methods ──
        public void ToUssString(){} // RVA: 0x7EE9DB0
    }

    public class StyleValueHandle : ValueType
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x454FE0
        public void set_valueType(){} // RVA: 0x29580
    }

    public class StyleValueKeywordExtension : Object
    {
        // ── Methods ──
        public void ToUssString(){} // RVA: 0x7EE9ED0
    }

    public class StyleVariable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x79C50
        public void GetHashCode(){} // RVA: 0x99A110
    }

    public class StyleVariableContext : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7EEA180
        public void AddInitialRange(){} // RVA: 0x7EEA480
        public void Clear(){} // RVA: 0x7EEA5F0
        public void .ctor(){} // RVA: 0x7EEA880
        public void TryFindVariable(){} // RVA: 0x7EEAA90
        public void GetVariableHash(){} // RVA: 0x7B51740
        public void .cctor(){} // RVA: 0x7EEABE0
        public void <Add>g__ComputeOrderSensitiveHash|7_0(){} // RVA: 0x7EEAC90
    }

    public class StyleVariableResolver : Object
    {
        // ── Methods ──
        public void get_currentSheet(){} // RVA: 0xD05CA0
        public void get_currentHandles(){} // RVA: 0xBC1B30
        public void get_resolvedValues(){} // RVA: 0xB465B0
        public void get_variableContext(){} // RVA: 0xBBF8F0
        public void set_variableContext(){} // RVA: 0xBBF900
        public void Init(){} // RVA: 0x7EEACA0
        public void PushContext(){} // RVA: 0x7EEADE0
        public void PopContext(){} // RVA: 0x7EEB000
        public void AddValue(){} // RVA: 0x7EEB1D0
        public void ResolveVarFunction(){} // RVA: 0x7EEB5A0
        public void ValidateResolvedValues(){} // RVA: 0x7EEB730
        public void ResolveVariable(){} // RVA: 0x7EEB920
        public void ResolveFallback(){} // RVA: 0x7EEBC80
        public void ParseVarFunction(){} // RVA: 0x7EEBFA0
        public void .ctor(){} // RVA: 0x7EEC0D0
        public void .cctor(){} // RVA: 0x7EEC420
    }

    public class StyleVariable[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DD60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34170
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}