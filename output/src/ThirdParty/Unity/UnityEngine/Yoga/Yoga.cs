// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Yoga
// Classes: 11
// Methods: 200

namespace ThirdParty.Unity.UnityEngine.Yoga
{
    public class BaselineFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF0BF2E0
        public void Invoke(){} // RVA: 0x7AB1A7AD0
    }

    public class Logger : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF0BF450
        public void Invoke(){} // RVA: 0x7A89D0820
    }

    public class MeasureFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF0BF5C0
        public void Invoke(){} // RVA: 0x7AE2674B0
    }

    public class MeasureOutput : Object
    {
        // ── Methods ──
        public void Make(){} // RVA: 0x7AF0BF730
    }

    public class Native : Object
    {
        // ── Methods ──
        public void YGNodeNewWithConfig(){} // RVA: 0x7AF0BFBB0
        public void YGNodeFree(){} // RVA: 0x7AF0BFC00
        public void YGNodeFreeInternal(){} // RVA: 0x7AF0BFC60
        public void YGSetManagedObject(){} // RVA: 0x7AF0BFCB0
        public void YGNodeSetConfig(){} // RVA: 0x7AF0BFD10
        public void YGConfigGetDefault(){} // RVA: 0x7AF0BFD70
        public void YGConfigNew(){} // RVA: 0x7AF0BFDC0
        public void YGConfigFree(){} // RVA: 0x7AF0BFE10
        public void YGConfigFreeInternal(){} // RVA: 0x7AF0BFE70
        public void YGConfigSetUseWebDefaults(){} // RVA: 0x7AF0BFEC0
        public void YGConfigGetUseWebDefaults(){} // RVA: 0x7AF0BFF20
        public void YGConfigSetPointScaleFactor(){} // RVA: 0x7AF0BFF70
        public void YGNodeInsertChild(){} // RVA: 0x7AF0BFFD0
        public void YGNodeRemoveChild(){} // RVA: 0x7AF0C0040
        public void YGNodeCalculateLayout(){} // RVA: 0x7AF0C00A0
        public void YGNodeMarkDirty(){} // RVA: 0x7AF0C0120
        public void YGNodeIsDirty(){} // RVA: 0x7AF0C0170
        public void YGNodeCopyStyle(){} // RVA: 0x7AF0C01C0
        public void YGNodeSetMeasureFunc(){} // RVA: 0x7AF0C0220
        public void YGNodeRemoveMeasureFunc(){} // RVA: 0x7AF0C0270
        public void YGNodeMeasureInvoke(){} // RVA: 0x7AF0C02C0
        public void YGNodeBaselineInvoke(){} // RVA: 0x7AF0C0380
        public void YGNodeSetHasNewLayout(){} // RVA: 0x7AF0C0410
        public void YGNodeGetHasNewLayout(){} // RVA: 0x7AF0C0470
        public void YGNodeStyleGetDirection(){} // RVA: 0x7AF0C04C0
        public void YGNodeStyleSetFlexDirection(){} // RVA: 0x7AF0C0510
        public void YGNodeStyleSetJustifyContent(){} // RVA: 0x7AF0C0570
        public void YGNodeStyleSetAlignContent(){} // RVA: 0x7AF0C05D0
        public void YGNodeStyleSetAlignItems(){} // RVA: 0x7AF0C0630
        public void YGNodeStyleSetAlignSelf(){} // RVA: 0x7AF0C0690
        public void YGNodeStyleSetPositionType(){} // RVA: 0x7AF0C06F0
        public void YGNodeStyleSetFlexWrap(){} // RVA: 0x7AF0C0750
        public void YGNodeStyleSetOverflow(){} // RVA: 0x7AF0C07B0
        public void YGNodeStyleSetDisplay(){} // RVA: 0x7AF0C0810
        public void YGNodeStyleSetFlex(){} // RVA: 0x7AF0C0870
        public void YGNodeStyleSetFlexGrow(){} // RVA: 0x7AF0C08D0
        public void YGNodeStyleSetFlexShrink(){} // RVA: 0x7AF0C0930
        public void YGNodeStyleSetFlexBasis(){} // RVA: 0x7AF0C0990
        public void YGNodeStyleSetFlexBasisPercent(){} // RVA: 0x7AF0C09F0
        public void YGNodeStyleSetFlexBasisAuto(){} // RVA: 0x7AF0C0A50
        public void YGNodeStyleSetWidth(){} // RVA: 0x7AF0C0AA0
        public void YGNodeStyleSetWidthPercent(){} // RVA: 0x7AF0C0B00
        public void YGNodeStyleSetWidthAuto(){} // RVA: 0x7AF0C0B60
        public void YGNodeStyleSetHeight(){} // RVA: 0x7AF0C0BB0
        public void YGNodeStyleSetHeightPercent(){} // RVA: 0x7AF0C0C10
        public void YGNodeStyleSetHeightAuto(){} // RVA: 0x7AF0C0C70
        public void YGNodeStyleSetMinWidth(){} // RVA: 0x7AF0C0CC0
        public void YGNodeStyleSetMinWidthPercent(){} // RVA: 0x7AF0C0D20
        public void YGNodeStyleSetMinHeight(){} // RVA: 0x7AF0C0D80
        public void YGNodeStyleSetMinHeightPercent(){} // RVA: 0x7AF0C0DE0
        public void YGNodeStyleSetMaxWidth(){} // RVA: 0x7AF0C0E40
        public void YGNodeStyleSetMaxWidthPercent(){} // RVA: 0x7AF0C0EA0
        public void YGNodeStyleSetMaxHeight(){} // RVA: 0x7AF0C0F00
        public void YGNodeStyleSetMaxHeightPercent(){} // RVA: 0x7AF0C0F60
        public void YGNodeStyleSetPosition(){} // RVA: 0x7AF0C0FC0
        public void YGNodeStyleSetPositionPercent(){} // RVA: 0x7AF0C1030
        public void YGNodeStyleSetMargin(){} // RVA: 0x7AF0C10A0
        public void YGNodeStyleSetMarginPercent(){} // RVA: 0x7AF0C1110
        public void YGNodeStyleSetMarginAuto(){} // RVA: 0x7AF0C1180
        public void YGNodeStyleSetPadding(){} // RVA: 0x7AF0C11E0
        public void YGNodeStyleSetPaddingPercent(){} // RVA: 0x7AF0C1250
        public void YGNodeStyleSetBorder(){} // RVA: 0x7AF0C12C0
        public void YGNodeLayoutGetLeft(){} // RVA: 0x7AF0C1330
        public void YGNodeLayoutGetTop(){} // RVA: 0x7AF0C1380
        public void YGNodeLayoutGetRight(){} // RVA: 0x7AF0C13D0
        public void YGNodeLayoutGetBottom(){} // RVA: 0x7AF0C1420
        public void YGNodeLayoutGetWidth(){} // RVA: 0x7AF0C1470
        public void YGNodeLayoutGetHeight(){} // RVA: 0x7AF0C14C0
        public void YGNodeLayoutGetMargin(){} // RVA: 0x7AF0C1510
        public void YGNodeLayoutGetPadding(){} // RVA: 0x7AF0C1570
        public void YGNodeLayoutGetBorder(){} // RVA: 0x7AF0C15D0
    }

    public class Native[] : Array
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

    public class YogaConfig : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF0BF7B0
        public void Finalize(){} // RVA: 0x7AF0BF850
        public void get_Handle(){} // RVA: 0x7AB1AC740
        public void get_UseWebDefaults(){} // RVA: 0x7AF0BF940
        public void set_UseWebDefaults(){} // RVA: 0x7AF0BF990
        public void set_PointScaleFactor(){} // RVA: 0x7AF0BF9F0
        public void .cctor(){} // RVA: 0x7AF0BFA50
    }

    public class YogaConstants : Object
    {
        // ── Methods ──
        public void IsUndefined(){} // RVA: 0x7AF0BFB90
    }

    public class YogaNode : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF0C1630
        public void Finalize(){} // RVA: 0x7AF0C17A0
        public void set_Config(){} // RVA: 0x7AF0C1830
        public void get_IsDirty(){} // RVA: 0x7AF0C1950
        public void MarkDirty(){} // RVA: 0x7AF0C19A0
        public void get_HasNewLayout(){} // RVA: 0x7AF0C19F0
        public void get_IsMeasureDefined(){} // RVA: 0x7AF0C1A40
        public void get_IsBaselineDefined(){} // RVA: 0x7AF0C1A50
        public void CopyStyle(){} // RVA: 0x7AF0C1A60
        public void set_FlexDirection(){} // RVA: 0x7AF0C1AD0
        public void set_JustifyContent(){} // RVA: 0x7AF0C1B30
        public void set_Display(){} // RVA: 0x7AF0C1B90
        public void set_AlignItems(){} // RVA: 0x7AF0C1BF0
        public void set_AlignSelf(){} // RVA: 0x7AF0C1C50
        public void set_AlignContent(){} // RVA: 0x7AF0C1CB0
        public void set_PositionType(){} // RVA: 0x7AF0C1D10
        public void set_Wrap(){} // RVA: 0x7AF0C1D70
        public void set_Flex(){} // RVA: 0x7AF0C1DD0
        public void set_FlexGrow(){} // RVA: 0x7AF0C1E30
        public void set_FlexShrink(){} // RVA: 0x7AF0C1E90
        public void set_FlexBasis(){} // RVA: 0x7AF0C1EF0
        public void set_Width(){} // RVA: 0x7AF0C2000
        public void set_Height(){} // RVA: 0x7AF0C2110
        public void set_MaxWidth(){} // RVA: 0x7AF0C2220
        public void set_MaxHeight(){} // RVA: 0x7AF0C22D0
        public void set_MinWidth(){} // RVA: 0x7AF0C2380
        public void set_MinHeight(){} // RVA: 0x7AF0C2430
        public void get_LayoutX(){} // RVA: 0x7AF0C24E0
        public void get_LayoutY(){} // RVA: 0x7AF0C2530
        public void get_LayoutRight(){} // RVA: 0x7AF0C2580
        public void get_LayoutBottom(){} // RVA: 0x7AF0C25D0
        public void get_LayoutWidth(){} // RVA: 0x7AF0C2620
        public void get_LayoutHeight(){} // RVA: 0x7AF0C2670
        public void set_Overflow(){} // RVA: 0x7AF0C26C0
        public void get_Count(){} // RVA: 0x7AF0C2720
        public void MarkLayoutSeen(){} // RVA: 0x7AF0C2770
        public void Insert(){} // RVA: 0x7AF0C27D0
        public void RemoveAt(){} // RVA: 0x7AF0C2A50
        public void Clear(){} // RVA: 0x7AF0C2BB0
        public void SetMeasureFunction(){} // RVA: 0x7AF0C2C20
        public void CalculateLayout(){} // RVA: 0x7AF0C2D80
        public void MeasureInternal(){} // RVA: 0x7AF0C2E40
        public void BaselineInternal(){} // RVA: 0x7AF0C2EE0
        public void GetEnumerator(){} // RVA: 0x7AF0C2F70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AF0C2FF0
        public void set_Left(){} // RVA: 0x7AF0C3070
        public void set_Top(){} // RVA: 0x7AF0C3080
        public void set_Right(){} // RVA: 0x7AF0C3090
        public void set_Bottom(){} // RVA: 0x7AF0C30A0
        public void SetStylePosition(){} // RVA: 0x7AF0C30B0
        public void set_MarginLeft(){} // RVA: 0x7AF0C3160
        public void set_MarginTop(){} // RVA: 0x7AF0C3170
        public void set_MarginRight(){} // RVA: 0x7AF0C3180
        public void set_MarginBottom(){} // RVA: 0x7AF0C3190
        public void SetStyleMargin(){} // RVA: 0x7AF0C31A0
        public void set_PaddingLeft(){} // RVA: 0x7AF0C32B0
        public void set_PaddingTop(){} // RVA: 0x7AF0C32C0
        public void set_PaddingRight(){} // RVA: 0x7AF0C32D0
        public void set_PaddingBottom(){} // RVA: 0x7AF0C32E0
        public void SetStylePadding(){} // RVA: 0x7AF0C32F0
        public void set_BorderLeftWidth(){} // RVA: 0x7AF0C33A0
        public void set_BorderTopWidth(){} // RVA: 0x7AF0C3410
        public void set_BorderRightWidth(){} // RVA: 0x7AF0C3480
        public void set_BorderBottomWidth(){} // RVA: 0x7AF0C34F0
        public void get_LayoutMarginLeft(){} // RVA: 0x7AF0C3560
        public void get_LayoutMarginTop(){} // RVA: 0x7AF0C35C0
        public void get_LayoutMarginRight(){} // RVA: 0x7AF0C3620
        public void get_LayoutMarginBottom(){} // RVA: 0x7AF0C3680
        public void get_LayoutPaddingLeft(){} // RVA: 0x7AF0C36E0
        public void get_LayoutPaddingTop(){} // RVA: 0x7AF0C3740
        public void get_LayoutPaddingRight(){} // RVA: 0x7AF0C37A0
        public void get_LayoutPaddingBottom(){} // RVA: 0x7AF0C3800
        public void get_LayoutBorderLeft(){} // RVA: 0x7AF0C3860
        public void get_LayoutBorderTop(){} // RVA: 0x7AF0C38C0
        public void get_LayoutBorderRight(){} // RVA: 0x7AF0C3920
        public void get_LayoutBorderBottom(){} // RVA: 0x7AF0C3980
    }

    public class YogaNode[] : Array
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

    public class YogaValue : ValueType
    {
        // ── Methods ──
        public void get_Unit(){} // RVA: 0x7A7A39F60
        public void get_Value(){} // RVA: 0x7A79EF510
        public void Point(){} // RVA: 0x7AF0C39E0
        public void Equals(){} // RVA: 0x7A7EFC790
        public void GetHashCode(){} // RVA: 0x7A7EFC880
        public void Auto(){} // RVA: 0x7AF0C3B80
        public void Percent(){} // RVA: 0x7AF0C3BA0
        public void op_Implicit(){} // RVA: 0x7AF0C39E0
    }

}