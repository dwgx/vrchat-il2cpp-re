// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Yoga
// Classes: 10
// Methods: 172

namespace ThirdParty.Unity.UnityEngine.Yoga
{
    public class BaselineFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E1F080
        public void Invoke(){} // RVA: 0x7FFE8401DEE0
    }

    public class Logger : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E1F200
        public void Invoke(){} // RVA: 0x7FFE81998A70
    }

    public class MeasureFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E1F380
        public void Invoke(){} // RVA: 0x7FFE86FB98D0
    }

    public class MeasureOutput : Object
    {
        // ── Methods ──
        public void Make(){} // RVA: 0x7FFE87E1F500
    }

    public class Native : Object
    {
        // ── Methods ──
        public void YGNodeNewWithConfig(){} // RVA: 0x7FFE87E1F980
        public void YGNodeFree(){} // RVA: 0x7FFE87E1F9D0
        public void YGNodeFreeInternal(){} // RVA: 0x7FFE87E1FA30
        public void YGSetManagedObject(){} // RVA: 0x7FFE87E1FA80
        public void YGNodeSetConfig(){} // RVA: 0x7FFE87E1FAE0
        public void YGConfigGetDefault(){} // RVA: 0x7FFE87E1FB40
        public void YGConfigNew(){} // RVA: 0x7FFE87E1FB90
        public void YGConfigFree(){} // RVA: 0x7FFE87E1FBE0
        public void YGConfigFreeInternal(){} // RVA: 0x7FFE87E1FC40
        public void YGConfigSetUseWebDefaults(){} // RVA: 0x7FFE87E1FC90
        public void YGConfigGetUseWebDefaults(){} // RVA: 0x7FFE87E1FCF0
        public void YGConfigSetPointScaleFactor(){} // RVA: 0x7FFE87E1FD40
        public void YGNodeInsertChild(){} // RVA: 0x7FFE87E1FDA0
        public void YGNodeRemoveChild(){} // RVA: 0x7FFE87E1FE10
        public void YGNodeCalculateLayout(){} // RVA: 0x7FFE87E1FE70
        public void YGNodeMarkDirty(){} // RVA: 0x7FFE87E1FEF0
        public void YGNodeIsDirty(){} // RVA: 0x7FFE87E1FF40
        public void YGNodeCopyStyle(){} // RVA: 0x7FFE87E1FF90
        public void YGNodeSetMeasureFunc(){} // RVA: 0x7FFE87E1FFF0
        public void YGNodeRemoveMeasureFunc(){} // RVA: 0x7FFE87E20040
        public void YGNodeMeasureInvoke(){} // RVA: 0x7FFE87E20090
        public void YGNodeBaselineInvoke(){} // RVA: 0x7FFE87E20150
        public void YGNodeSetHasNewLayout(){} // RVA: 0x7FFE87E201E0
        public void YGNodeGetHasNewLayout(){} // RVA: 0x7FFE87E20240
        public void YGNodeStyleGetDirection(){} // RVA: 0x7FFE87E20290
        public void YGNodeStyleSetFlexDirection(){} // RVA: 0x7FFE87E202E0
        public void YGNodeStyleSetJustifyContent(){} // RVA: 0x7FFE87E20340
        public void YGNodeStyleSetAlignContent(){} // RVA: 0x7FFE87E203A0
        public void YGNodeStyleSetAlignItems(){} // RVA: 0x7FFE87E20400
        public void YGNodeStyleSetAlignSelf(){} // RVA: 0x7FFE87E20460
        public void YGNodeStyleSetPositionType(){} // RVA: 0x7FFE87E204C0
        public void YGNodeStyleSetFlexWrap(){} // RVA: 0x7FFE87E20520
        public void YGNodeStyleSetOverflow(){} // RVA: 0x7FFE87E20580
        public void YGNodeStyleSetDisplay(){} // RVA: 0x7FFE87E205E0
        public void YGNodeStyleSetFlex(){} // RVA: 0x7FFE87E20640
        public void YGNodeStyleSetFlexGrow(){} // RVA: 0x7FFE87E206A0
        public void YGNodeStyleSetFlexShrink(){} // RVA: 0x7FFE87E20700
        public void YGNodeStyleSetFlexBasis(){} // RVA: 0x7FFE87E20760
        public void YGNodeStyleSetFlexBasisPercent(){} // RVA: 0x7FFE87E207C0
        public void YGNodeStyleSetFlexBasisAuto(){} // RVA: 0x7FFE87E20820
        public void YGNodeStyleSetWidth(){} // RVA: 0x7FFE87E20870
        public void YGNodeStyleSetWidthPercent(){} // RVA: 0x7FFE87E208D0
        public void YGNodeStyleSetWidthAuto(){} // RVA: 0x7FFE87E20930
        public void YGNodeStyleSetHeight(){} // RVA: 0x7FFE87E20980
        public void YGNodeStyleSetHeightPercent(){} // RVA: 0x7FFE87E209E0
        public void YGNodeStyleSetHeightAuto(){} // RVA: 0x7FFE87E20A40
        public void YGNodeStyleSetMinWidth(){} // RVA: 0x7FFE87E20A90
        public void YGNodeStyleSetMinWidthPercent(){} // RVA: 0x7FFE87E20AF0
        public void YGNodeStyleSetMinHeight(){} // RVA: 0x7FFE87E20B50
        public void YGNodeStyleSetMinHeightPercent(){} // RVA: 0x7FFE87E20BB0
        public void YGNodeStyleSetMaxWidth(){} // RVA: 0x7FFE87E20C10
        public void YGNodeStyleSetMaxWidthPercent(){} // RVA: 0x7FFE87E20C70
        public void YGNodeStyleSetMaxHeight(){} // RVA: 0x7FFE87E20CD0
        public void YGNodeStyleSetMaxHeightPercent(){} // RVA: 0x7FFE87E20D30
        public void YGNodeStyleSetPosition(){} // RVA: 0x7FFE87E20D90
        public void YGNodeStyleSetPositionPercent(){} // RVA: 0x7FFE87E20E00
        public void YGNodeStyleSetMargin(){} // RVA: 0x7FFE87E20E70
        public void YGNodeStyleSetMarginPercent(){} // RVA: 0x7FFE87E20EE0
        public void YGNodeStyleSetMarginAuto(){} // RVA: 0x7FFE87E20F50
        public void YGNodeStyleSetPadding(){} // RVA: 0x7FFE87E20FB0
        public void YGNodeStyleSetPaddingPercent(){} // RVA: 0x7FFE87E21020
        public void YGNodeStyleSetBorder(){} // RVA: 0x7FFE87E21090
        public void YGNodeLayoutGetLeft(){} // RVA: 0x7FFE87E21100
        public void YGNodeLayoutGetTop(){} // RVA: 0x7FFE87E21150
        public void YGNodeLayoutGetRight(){} // RVA: 0x7FFE87E211A0
        public void YGNodeLayoutGetBottom(){} // RVA: 0x7FFE87E211F0
        public void YGNodeLayoutGetWidth(){} // RVA: 0x7FFE87E21240
        public void YGNodeLayoutGetHeight(){} // RVA: 0x7FFE87E21290
        public void YGNodeLayoutGetMargin(){} // RVA: 0x7FFE87E212E0
        public void YGNodeLayoutGetPadding(){} // RVA: 0x7FFE87E21340
        public void YGNodeLayoutGetBorder(){} // RVA: 0x7FFE87E213A0
    }

    public class YogaConfig : Object
    {
        public UnityEngine.Yoga.YogaConfig Default;
        public UIntPtr _ygConfig; // 0x10
        public UnityEngine.Yoga.Logger _logger; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E1F580 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE87E1F620
        public void get_Handle(){} // RVA: 0x7FFE84022BE0
        public void get_UseWebDefaults(){} // RVA: 0x7FFE87E1F710
        public void set_UseWebDefaults(){} // RVA: 0x7FFE87E1F760
        public void set_PointScaleFactor(){} // RVA: 0x7FFE87E1F7C0
        public void .cctor(){} // RVA: 0x7FFE87E1F820
    }

    public class YogaConstants : Object
    {
        // ── Methods ──
        public void IsUndefined(){} // RVA: 0x7FFE87E1F960
    }

    public class YogaNode : Object
    {
        public UIntPtr _ygNode; // 0x10
        public UnityEngine.Yoga.YogaConfig _config; // 0x18
        public System.WeakReference _parent; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.Yoga.YogaNode> _children; // 0x28
        public UnityEngine.Yoga.MeasureFunction _measureFunction; // 0x30
        public UnityEngine.Yoga.BaselineFunction _baselineFunction; // 0x38
        public object _data; // 0x40
        public object field_7; // 0x4
        public object field_8; // 0x5
        public object field_9; // 0x6
        public object field_10; // 0x7
        public object field_11; // 0x8
        public object field_12; // 0x9
        public object field_13; // 0xA
        public object field_14; // 0xB
        public object field_15; // 0xC
        public object field_16; // 0xD
        public object field_17; // 0xE
        public object field_18; // 0xF
        public object field_19; // 0x10
        public object field_20; // 0x11
        public object field_21; // 0x12
        public object field_22; // 0x13
        public object field_23; // 0x14
        public object field_24; // 0x15
        public object field_25; // 0x16
        public object field_26; // 0x17
        public object field_27; // 0x18
        public object field_28; // 0x19
        public object field_29; // 0x1A
        public object field_30; // 0x1B
        public object field_31; // 0x1C
        public object field_32; // 0x1D
        public object field_33; // 0x1E
        public object field_34; // 0x1F
        public object field_35; // 0x20
        public object field_36; // 0x21
        public object field_37; // 0x22
        public object field_38; // 0x23
        public object field_39; // 0x24
        public object field_40; // 0x25
        public object field_41; // 0x26
        public object field_42; // 0x27
        public object field_43; // 0x28
        public object field_44; // 0x29
        public object field_45; // 0x2A
        public object field_46; // 0x2B
        public object field_47; // 0x2C
        public object field_48; // 0x2D
        public object field_49; // 0x2E
        public object field_50; // 0x2F
        public object field_51; // 0x30
        public object field_52; // 0x31
        public object field_53; // 0x32
        public object field_54; // 0x33
        public object field_55; // 0x34
        public object field_56; // 0x35
        public object field_57; // 0x36
        public object field_58; // 0x37

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E21400
        public void Finalize(){} // RVA: 0x7FFE87E21570
        public void set_Config(){} // RVA: 0x7FFE87E21600
        public void get_IsDirty(){} // RVA: 0x7FFE87E21720
        public void MarkDirty(){} // RVA: 0x7FFE87E21770
        public void get_HasNewLayout(){} // RVA: 0x7FFE87E217C0
        public void get_IsMeasureDefined(){} // RVA: 0x7FFE87E21810
        public void get_IsBaselineDefined(){} // RVA: 0x7FFE87E21820
        public void CopyStyle(){} // RVA: 0x7FFE87E21830
        public void set_FlexDirection(){} // RVA: 0x7FFE87E218A0
        public void set_JustifyContent(){} // RVA: 0x7FFE87E21900
        public void set_Display(){} // RVA: 0x7FFE87E21960
        public void set_AlignItems(){} // RVA: 0x7FFE87E219C0
        public void set_AlignSelf(){} // RVA: 0x7FFE87E21A20
        public void set_AlignContent(){} // RVA: 0x7FFE87E21A80
        public void set_PositionType(){} // RVA: 0x7FFE87E21AE0
        public void set_Wrap(){} // RVA: 0x7FFE87E21B40
        public void set_Flex(){} // RVA: 0x7FFE87E21BA0
        public void set_FlexGrow(){} // RVA: 0x7FFE87E21C00
        public void set_FlexShrink(){} // RVA: 0x7FFE87E21C60
        public void set_FlexBasis(){} // RVA: 0x7FFE87E21CC0
        public void set_Width(){} // RVA: 0x7FFE87E21DD0
        public void set_Height(){} // RVA: 0x7FFE87E21EE0
        public void set_MaxWidth(){} // RVA: 0x7FFE87E21FF0
        public void set_MaxHeight(){} // RVA: 0x7FFE87E220A0
        public void set_MinWidth(){} // RVA: 0x7FFE87E22150
        public void set_MinHeight(){} // RVA: 0x7FFE87E22200
        public void get_LayoutX(){} // RVA: 0x7FFE87E222B0
        public void get_LayoutY(){} // RVA: 0x7FFE87E22300
        public void get_LayoutRight(){} // RVA: 0x7FFE87E22350
        public void get_LayoutBottom(){} // RVA: 0x7FFE87E223A0
        public void get_LayoutWidth(){} // RVA: 0x7FFE87E223F0
        public void get_LayoutHeight(){} // RVA: 0x7FFE87E22440
        public void set_Overflow(){} // RVA: 0x7FFE87E22490
        public void get_Count(){} // RVA: 0x7FFE87E224F0
        public void MarkLayoutSeen(){} // RVA: 0x7FFE87E22540
        public void Insert(){} // RVA: 0x7FFE87E225A0
        public void RemoveAt(){} // RVA: 0x7FFE87E22810
        public void Clear(){} // RVA: 0x7FFE87E22970
        public void SetMeasureFunction(){} // RVA: 0x7FFE87E229E0
        public void CalculateLayout(){} // RVA: 0x7FFE87E22B40
        public void MeasureInternal(){} // RVA: 0x7FFE87E22C00
        public void BaselineInternal(){} // RVA: 0x7FFE87E22CA0
        public void GetEnumerator(){} // RVA: 0x7FFE87E22D30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87E22DB0
        public void set_Left(){} // RVA: 0x7FFE87E22E30
        public void set_Top(){} // RVA: 0x7FFE87E22E40
        public void set_Right(){} // RVA: 0x7FFE87E22E50
        public void set_Bottom(){} // RVA: 0x7FFE87E22E60
        public void SetStylePosition(){} // RVA: 0x7FFE87E22E70
        public void set_MarginLeft(){} // RVA: 0x7FFE87E22F20
        public void set_MarginTop(){} // RVA: 0x7FFE87E22F30
        public void set_MarginRight(){} // RVA: 0x7FFE87E22F40
        public void set_MarginBottom(){} // RVA: 0x7FFE87E22F50
        public void SetStyleMargin(){} // RVA: 0x7FFE87E22F60
        public void set_PaddingLeft(){} // RVA: 0x7FFE87E23070
        public void set_PaddingTop(){} // RVA: 0x7FFE87E23080
        public void set_PaddingRight(){} // RVA: 0x7FFE87E23090
        public void set_PaddingBottom(){} // RVA: 0x7FFE87E230A0
        public void SetStylePadding(){} // RVA: 0x7FFE87E230B0
        public void set_BorderLeftWidth(){} // RVA: 0x7FFE87E23160
        public void set_BorderTopWidth(){} // RVA: 0x7FFE87E231D0
        public void set_BorderRightWidth(){} // RVA: 0x7FFE87E23240
        public void set_BorderBottomWidth(){} // RVA: 0x7FFE87E232B0
        public void get_LayoutMarginLeft(){} // RVA: 0x7FFE87E23320
        public void get_LayoutMarginTop(){} // RVA: 0x7FFE87E23380
        public void get_LayoutMarginRight(){} // RVA: 0x7FFE87E233E0
        public void get_LayoutMarginBottom(){} // RVA: 0x7FFE87E23440
        public void get_LayoutPaddingLeft(){} // RVA: 0x7FFE87E234A0
        public void get_LayoutPaddingTop(){} // RVA: 0x7FFE87E23500
        public void get_LayoutPaddingRight(){} // RVA: 0x7FFE87E23560
        public void get_LayoutPaddingBottom(){} // RVA: 0x7FFE87E235C0
        public void get_LayoutBorderLeft(){} // RVA: 0x7FFE87E23620
        public void get_LayoutBorderTop(){} // RVA: 0x7FFE87E23680
        public void get_LayoutBorderRight(){} // RVA: 0x7FFE87E236E0
        public void get_LayoutBorderBottom(){} // RVA: 0x7FFE87E23740
    }

    public class YogaSize : ValueType
    {
    }

    public class YogaValue : ValueType
    {
        public float value; // 0x10
        public 0x6650CDCC unit; // 0x14

        // ── Methods ──
        public void get_Unit(){} // RVA: 0x7FFE84D2D330
        public void get_Value(){} // RVA: 0x7FFE8111ED20
        public void Point(){} // RVA: 0x7FFE87E237A0
        public void Equals(){} // RVA: 0x7FFE87E23820 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87E23910
        public void Auto(){} // RVA: 0x7FFE87E23940
        public void Percent(){} // RVA: 0x7FFE87E23960
        public void op_Implicit(){} // RVA: 0x7FFE87E237A0
    }

}