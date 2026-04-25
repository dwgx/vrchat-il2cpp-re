// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Yoga
// Classes: 10
// Methods: 172

namespace ThirdParty.Unity.UnityEngine.Yoga
{
    public class BaselineFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A767E0
        public void Invoke(){} // RVA: 0x7FFAC5CBFAA0
    }

    public class Logger : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A76960
        public void Invoke(){} // RVA: 0x7FFAC383F780
    }

    public class MeasureFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A76AE0
        public void Invoke(){} // RVA: 0x7FFAC8C11390
    }

    public class MeasureOutput : Object
    {
        // ── Methods ──
        public void Make(){} // RVA: 0x7FFAC9A76C60
    }

    public class Native : Object
    {
        // ── Methods ──
        public void YGNodeNewWithConfig(){} // RVA: 0x7FFAC9A770E0
        public void YGNodeFree(){} // RVA: 0x7FFAC9A77130
        public void YGNodeFreeInternal(){} // RVA: 0x7FFAC9A77190
        public void YGSetManagedObject(){} // RVA: 0x7FFAC9A771E0
        public void YGNodeSetConfig(){} // RVA: 0x7FFAC9A77240
        public void YGConfigGetDefault(){} // RVA: 0x7FFAC9A772A0
        public void YGConfigNew(){} // RVA: 0x7FFAC9A772F0
        public void YGConfigFree(){} // RVA: 0x7FFAC9A77340
        public void YGConfigFreeInternal(){} // RVA: 0x7FFAC9A773A0
        public void YGConfigSetUseWebDefaults(){} // RVA: 0x7FFAC9A773F0
        public void YGConfigGetUseWebDefaults(){} // RVA: 0x7FFAC9A77450
        public void YGConfigSetPointScaleFactor(){} // RVA: 0x7FFAC9A774A0
        public void YGNodeInsertChild(){} // RVA: 0x7FFAC9A77500
        public void YGNodeRemoveChild(){} // RVA: 0x7FFAC9A77570
        public void YGNodeCalculateLayout(){} // RVA: 0x7FFAC9A775D0
        public void YGNodeMarkDirty(){} // RVA: 0x7FFAC9A77650
        public void YGNodeIsDirty(){} // RVA: 0x7FFAC9A776A0
        public void YGNodeCopyStyle(){} // RVA: 0x7FFAC9A776F0
        public void YGNodeSetMeasureFunc(){} // RVA: 0x7FFAC9A77750
        public void YGNodeRemoveMeasureFunc(){} // RVA: 0x7FFAC9A777A0
        public void YGNodeMeasureInvoke(){} // RVA: 0x7FFAC9A777F0
        public void YGNodeBaselineInvoke(){} // RVA: 0x7FFAC9A778B0
        public void YGNodeSetHasNewLayout(){} // RVA: 0x7FFAC9A77940
        public void YGNodeGetHasNewLayout(){} // RVA: 0x7FFAC9A779A0
        public void YGNodeStyleGetDirection(){} // RVA: 0x7FFAC9A779F0
        public void YGNodeStyleSetFlexDirection(){} // RVA: 0x7FFAC9A77A40
        public void YGNodeStyleSetJustifyContent(){} // RVA: 0x7FFAC9A77AA0
        public void YGNodeStyleSetAlignContent(){} // RVA: 0x7FFAC9A77B00
        public void YGNodeStyleSetAlignItems(){} // RVA: 0x7FFAC9A77B60
        public void YGNodeStyleSetAlignSelf(){} // RVA: 0x7FFAC9A77BC0
        public void YGNodeStyleSetPositionType(){} // RVA: 0x7FFAC9A77C20
        public void YGNodeStyleSetFlexWrap(){} // RVA: 0x7FFAC9A77C80
        public void YGNodeStyleSetOverflow(){} // RVA: 0x7FFAC9A77CE0
        public void YGNodeStyleSetDisplay(){} // RVA: 0x7FFAC9A77D40
        public void YGNodeStyleSetFlex(){} // RVA: 0x7FFAC9A77DA0
        public void YGNodeStyleSetFlexGrow(){} // RVA: 0x7FFAC9A77E00
        public void YGNodeStyleSetFlexShrink(){} // RVA: 0x7FFAC9A77E60
        public void YGNodeStyleSetFlexBasis(){} // RVA: 0x7FFAC9A77EC0
        public void YGNodeStyleSetFlexBasisPercent(){} // RVA: 0x7FFAC9A77F20
        public void YGNodeStyleSetFlexBasisAuto(){} // RVA: 0x7FFAC9A77F80
        public void YGNodeStyleSetWidth(){} // RVA: 0x7FFAC9A77FD0
        public void YGNodeStyleSetWidthPercent(){} // RVA: 0x7FFAC9A78030
        public void YGNodeStyleSetWidthAuto(){} // RVA: 0x7FFAC9A78090
        public void YGNodeStyleSetHeight(){} // RVA: 0x7FFAC9A780E0
        public void YGNodeStyleSetHeightPercent(){} // RVA: 0x7FFAC9A78140
        public void YGNodeStyleSetHeightAuto(){} // RVA: 0x7FFAC9A781A0
        public void YGNodeStyleSetMinWidth(){} // RVA: 0x7FFAC9A781F0
        public void YGNodeStyleSetMinWidthPercent(){} // RVA: 0x7FFAC9A78250
        public void YGNodeStyleSetMinHeight(){} // RVA: 0x7FFAC9A782B0
        public void YGNodeStyleSetMinHeightPercent(){} // RVA: 0x7FFAC9A78310
        public void YGNodeStyleSetMaxWidth(){} // RVA: 0x7FFAC9A78370
        public void YGNodeStyleSetMaxWidthPercent(){} // RVA: 0x7FFAC9A783D0
        public void YGNodeStyleSetMaxHeight(){} // RVA: 0x7FFAC9A78430
        public void YGNodeStyleSetMaxHeightPercent(){} // RVA: 0x7FFAC9A78490
        public void YGNodeStyleSetPosition(){} // RVA: 0x7FFAC9A784F0
        public void YGNodeStyleSetPositionPercent(){} // RVA: 0x7FFAC9A78560
        public void YGNodeStyleSetMargin(){} // RVA: 0x7FFAC9A785D0
        public void YGNodeStyleSetMarginPercent(){} // RVA: 0x7FFAC9A78640
        public void YGNodeStyleSetMarginAuto(){} // RVA: 0x7FFAC9A786B0
        public void YGNodeStyleSetPadding(){} // RVA: 0x7FFAC9A78710
        public void YGNodeStyleSetPaddingPercent(){} // RVA: 0x7FFAC9A78780
        public void YGNodeStyleSetBorder(){} // RVA: 0x7FFAC9A787F0
        public void YGNodeLayoutGetLeft(){} // RVA: 0x7FFAC9A78860
        public void YGNodeLayoutGetTop(){} // RVA: 0x7FFAC9A788B0
        public void YGNodeLayoutGetRight(){} // RVA: 0x7FFAC9A78900
        public void YGNodeLayoutGetBottom(){} // RVA: 0x7FFAC9A78950
        public void YGNodeLayoutGetWidth(){} // RVA: 0x7FFAC9A789A0
        public void YGNodeLayoutGetHeight(){} // RVA: 0x7FFAC9A789F0
        public void YGNodeLayoutGetMargin(){} // RVA: 0x7FFAC9A78A40
        public void YGNodeLayoutGetPadding(){} // RVA: 0x7FFAC9A78AA0
        public void YGNodeLayoutGetBorder(){} // RVA: 0x7FFAC9A78B00
    }

    public class YogaConfig : Object
    {
        public UnityEngine.Yoga.YogaConfig Handle;
        public UIntPtr UseWebDefaults; // 0x10
        public UnityEngine.Yoga.Logger PointScaleFactor; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A76CE0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC9A76D80
        public void get_Handle(){} // RVA: 0x7FFAC5CC4750
        public void get_UseWebDefaults(){} // RVA: 0x7FFAC9A76E70
        public void set_UseWebDefaults(){} // RVA: 0x7FFAC9A76EC0
        public void set_PointScaleFactor(){} // RVA: 0x7FFAC9A76F20
        public void .cctor(){} // RVA: 0x7FFAC9A76F80
    }

    public class YogaConstants : Object
    {
        // ── Methods ──
        public void IsUndefined(){} // RVA: 0x7FFAC9A770C0
    }

    public class YogaNode : Object
    {
        public UIntPtr Config; // 0x10
        public UnityEngine.Yoga.YogaConfig IsDirty; // 0x18
        public System.WeakReference HasNewLayout; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.Yoga.YogaNode> IsMeasureDefined; // 0x28
        public UnityEngine.Yoga.MeasureFunction IsBaselineDefined; // 0x30
        public UnityEngine.Yoga.BaselineFunction FlexDirection; // 0x38
        public object JustifyContent; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9A78B60
        public void Finalize(){} // RVA: 0x7FFAC9A78CD0
        public void set_Config(){} // RVA: 0x7FFAC9A78D60
        public void get_IsDirty(){} // RVA: 0x7FFAC9A78E80
        public void MarkDirty(){} // RVA: 0x7FFAC9A78ED0
        public void get_HasNewLayout(){} // RVA: 0x7FFAC9A78F20
        public void get_IsMeasureDefined(){} // RVA: 0x7FFAC9A78F70
        public void get_IsBaselineDefined(){} // RVA: 0x7FFAC9A78F80
        public void CopyStyle(){} // RVA: 0x7FFAC9A78F90
        public void set_FlexDirection(){} // RVA: 0x7FFAC9A79000
        public void set_JustifyContent(){} // RVA: 0x7FFAC9A79060
        public void set_Display(){} // RVA: 0x7FFAC9A790C0
        public void set_AlignItems(){} // RVA: 0x7FFAC9A79120
        public void set_AlignSelf(){} // RVA: 0x7FFAC9A79180
        public void set_AlignContent(){} // RVA: 0x7FFAC9A791E0
        public void set_PositionType(){} // RVA: 0x7FFAC9A79240
        public void set_Wrap(){} // RVA: 0x7FFAC9A792A0
        public void set_Flex(){} // RVA: 0x7FFAC9A79300
        public void set_FlexGrow(){} // RVA: 0x7FFAC9A79360
        public void set_FlexShrink(){} // RVA: 0x7FFAC9A793C0
        public void set_FlexBasis(){} // RVA: 0x7FFAC9A79420
        public void set_Width(){} // RVA: 0x7FFAC9A79530
        public void set_Height(){} // RVA: 0x7FFAC9A79640
        public void set_MaxWidth(){} // RVA: 0x7FFAC9A79750
        public void set_MaxHeight(){} // RVA: 0x7FFAC9A79800
        public void set_MinWidth(){} // RVA: 0x7FFAC9A798B0
        public void set_MinHeight(){} // RVA: 0x7FFAC9A79960
        public void get_LayoutX(){} // RVA: 0x7FFAC9A79A10
        public void get_LayoutY(){} // RVA: 0x7FFAC9A79A60
        public void get_LayoutRight(){} // RVA: 0x7FFAC9A79AB0
        public void get_LayoutBottom(){} // RVA: 0x7FFAC9A79B00
        public void get_LayoutWidth(){} // RVA: 0x7FFAC9A79B50
        public void get_LayoutHeight(){} // RVA: 0x7FFAC9A79BA0
        public void set_Overflow(){} // RVA: 0x7FFAC9A79BF0
        public void get_Count(){} // RVA: 0x7FFAC9A79C50
        public void MarkLayoutSeen(){} // RVA: 0x7FFAC9A79CA0
        public void Insert(){} // RVA: 0x7FFAC9A79D00
        public void RemoveAt(){} // RVA: 0x7FFAC9A79F70
        public void Clear(){} // RVA: 0x7FFAC9A7A0D0
        public void SetMeasureFunction(){} // RVA: 0x7FFAC9A7A140
        public void CalculateLayout(){} // RVA: 0x7FFAC9A7A2A0
        public void MeasureInternal(){} // RVA: 0x7FFAC9A7A360
        public void BaselineInternal(){} // RVA: 0x7FFAC9A7A400
        public void GetEnumerator(){} // RVA: 0x7FFAC9A7A490
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9A7A510
        public void set_Left(){} // RVA: 0x7FFAC9A7A590
        public void set_Top(){} // RVA: 0x7FFAC9A7A5A0
        public void set_Right(){} // RVA: 0x7FFAC9A7A5B0
        public void set_Bottom(){} // RVA: 0x7FFAC9A7A5C0
        public void SetStylePosition(){} // RVA: 0x7FFAC9A7A5D0
        public void set_MarginLeft(){} // RVA: 0x7FFAC9A7A680
        public void set_MarginTop(){} // RVA: 0x7FFAC9A7A690
        public void set_MarginRight(){} // RVA: 0x7FFAC9A7A6A0
        public void set_MarginBottom(){} // RVA: 0x7FFAC9A7A6B0
        public void SetStyleMargin(){} // RVA: 0x7FFAC9A7A6C0
        public void set_PaddingLeft(){} // RVA: 0x7FFAC9A7A7D0
        public void set_PaddingTop(){} // RVA: 0x7FFAC9A7A7E0
        public void set_PaddingRight(){} // RVA: 0x7FFAC9A7A7F0
        public void set_PaddingBottom(){} // RVA: 0x7FFAC9A7A800
        public void SetStylePadding(){} // RVA: 0x7FFAC9A7A810
        public void set_BorderLeftWidth(){} // RVA: 0x7FFAC9A7A8C0
        public void set_BorderTopWidth(){} // RVA: 0x7FFAC9A7A930
        public void set_BorderRightWidth(){} // RVA: 0x7FFAC9A7A9A0
        public void set_BorderBottomWidth(){} // RVA: 0x7FFAC9A7AA10
        public void get_LayoutMarginLeft(){} // RVA: 0x7FFAC9A7AA80
        public void get_LayoutMarginTop(){} // RVA: 0x7FFAC9A7AAE0
        public void get_LayoutMarginRight(){} // RVA: 0x7FFAC9A7AB40
        public void get_LayoutMarginBottom(){} // RVA: 0x7FFAC9A7ABA0
        public void get_LayoutPaddingLeft(){} // RVA: 0x7FFAC9A7AC00
        public void get_LayoutPaddingTop(){} // RVA: 0x7FFAC9A7AC60
        public void get_LayoutPaddingRight(){} // RVA: 0x7FFAC9A7ACC0
        public void get_LayoutPaddingBottom(){} // RVA: 0x7FFAC9A7AD20
        public void get_LayoutBorderLeft(){} // RVA: 0x7FFAC9A7AD80
        public void get_LayoutBorderTop(){} // RVA: 0x7FFAC9A7ADE0
        public void get_LayoutBorderRight(){} // RVA: 0x7FFAC9A7AE40
        public void get_LayoutBorderBottom(){} // RVA: 0x7FFAC9A7AEA0
    }

    public class YogaSize : ValueType
    {
        public float width; // 0x10
        public float height; // 0x14
    }

    public class YogaValue : ValueType
    {
        public float Unit; // 0x10
        public 0x6B113EA8 Value; // 0x14

        // ── Methods ──
        public void get_Unit(){} // RVA: 0x7FFAC69CBEA0
        public void get_Value(){} // RVA: 0x7FFAC2F44D20
        public void Point(){} // RVA: 0x7FFAC9A7AF00
        public void Equals(){} // RVA: 0x7FFAC9A7AF80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9A7B070
        public void Auto(){} // RVA: 0x7FFAC9A7B0A0
        public void Percent(){} // RVA: 0x7FFAC9A7B0C0
        public void op_Implicit(){} // RVA: 0x7FFAC9A7AF00
    }

}