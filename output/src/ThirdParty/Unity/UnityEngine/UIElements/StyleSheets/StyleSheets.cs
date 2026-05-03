// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.StyleSheets
// Classes: 21
// Methods: 253

namespace ThirdParty.Unity.UnityEngine.UIElements.StyleSheets
{
    public class BaseStyleMatcher : Object
    {
        public System.Text.RegularExpressions.Regex s_CustomIdentRegex;
        public System.Collections.Generic.Stack`1<MatchContext> m_ContextStack; // 0x10
        public MatchContext m_CurrentContext; // 0x18
        public object field_3; // 0x650
        public object field_4; // 0x651
        public object field_5; // 0x652

        // ── Methods ──
        public void MatchKeyword(){} // RVA: 0x7FFE80E2F3B0
        public void MatchNumber(){} // RVA: 0x7FFE80E2F150
        public void MatchInteger(){} // RVA: 0x7FFE80E2F150
        public void MatchLength(){} // RVA: 0x7FFE80E2F150
        public void MatchPercentage(){} // RVA: 0x7FFE80E2F150
        public void MatchColor(){} // RVA: 0x7FFE80E2F150
        public void MatchResource(){} // RVA: 0x7FFE80E2F150
        public void MatchUrl(){} // RVA: 0x7FFE80E2F150
        public void MatchTime(){} // RVA: 0x7FFE80E2F150
        public void MatchAngle(){} // RVA: 0x7FFE80E2F150
        public void MatchCustomIdent(){} // RVA: 0x7FFE80E2F150
        public void get_valueCount(){} // RVA: 0x7FFE80E2EDB0
        public void get_isCurrentVariable(){} // RVA: 0x7FFE80E2F150
        public void get_isCurrentComma(){} // RVA: 0x7FFE80E2F150
        public void get_hasCurrent(){} // RVA: 0x7FFE87EC98E0
        public void get_currentIndex(){} // RVA: 0x7FFE813DB630
        public void set_currentIndex(){} // RVA: 0x7FFE8144DF00
        public void get_matchedVariableCount(){} // RVA: 0x7FFE82707EE0
        public void set_matchedVariableCount(){} // RVA: 0x7FFE82717690
        public void Initialize(){} // RVA: 0x7FFE87EC9910
        public void MoveNext(){} // RVA: 0x7FFE87EC9960
        public void SaveContext(){} // RVA: 0x7FFE87EC99A0
        public void RestoreContext(){} // RVA: 0x7FFE87EC9A30
        public void DropContext(){} // RVA: 0x7FFE87EC9A80
        public void Match(){} // RVA: 0x7FFE87EC9AD0
        public void MatchExpression(){} // RVA: 0x7FFE87EC9C70
        public void MatchExpressionWithMultiplier(){} // RVA: 0x7FFE87EC9D80
        public void MatchGroup(){} // RVA: 0x7FFE87EC9EA0
        public void MatchCombinator(){} // RVA: 0x7FFE87EC9F60
        public void MatchOr(){} // RVA: 0x7FFE87ECA2A0
        public void MatchOrOr(){} // RVA: 0x7FFE87ECA410
        public void MatchAndAnd(){} // RVA: 0x7FFE87ECA430
        public void MatchMany(){} // RVA: 0x7FFE87ECA470
        public void MatchManyByOrder(){} // RVA: 0x7FFE87ECA670
        public void MatchJuxtaposition(){} // RVA: 0x7FFE87ECA7E0
        public void MatchDataType(){} // RVA: 0x7FFE87ECA860
        public void .ctor(){} // RVA: 0x7FFE87ECA9E0
        public void .cctor(){} // RVA: 0x7FFE87ECAB60
    }

    public class Dimension : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87EBD860
        public void ToLength(){} // RVA: 0x7FFE87EBD870
        public void ToTime(){} // RVA: 0x7FFE87EBD8B0
        public void ToAngle(){} // RVA: 0x7FFE87EBD8D0
        public void op_Equality(){} // RVA: 0x7FFE87EBD930
        public void Equals(){} // RVA: 0x7FFE87EBD990 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87EBDA40
        public void ToString(){} // RVA: 0x7FFE87EBDA70
    }

    public class HierarchyTraversal : Object
    {
        // ── Methods ──
        public void Traverse(){} // RVA: 0x7FFE87EAEDE0
        public void TraverseRecursive(){} // RVA: 0x7FFE80E4D070
        public void Recurse(){} // RVA: 0x7FFE87EAEE00
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ImageSource : ValueType
    {
        // ── Methods ──
        public void IsNull(){} // RVA: 0x7FFE87EBDE90
    }

    public class InitialStyle : Object
    {
        public UnityEngine.UIElements.ComputedStyle s_InitialStyle;
        public object field_1; // 0x5FA
        public object field_2; // 0x5FB
        public object field_3; // 0x5FC
        public object field_4; // 0x5FD
        public object field_5; // 0x5FE
        public object field_6; // 0x5FF
        public object field_7; // 0x600
        public object field_8; // 0x601
        public object field_9; // 0x602
        public object field_10; // 0x603
        public object field_11; // 0x604
        public object field_12; // 0x605
        public object field_13; // 0x606
        public object field_14; // 0x607
        public object field_15; // 0x608
        public object field_16; // 0x609
        public object field_17; // 0x60A
        public object field_18; // 0x60B
        public object field_19; // 0x60C
        public object field_20; // 0x60D
        public object field_21; // 0x60E
        public object field_22; // 0x60F
        public object field_23; // 0x610
        public object field_24; // 0x611
        public object field_25; // 0x612
        public object field_26; // 0x613
        public object field_27; // 0x614
        public object field_28; // 0x615
        public object field_29; // 0x616
        public object field_30; // 0x617
        public object field_31; // 0x618
        public object field_32; // 0x619
        public object field_33; // 0x61A
        public object field_34; // 0x61B
        public object field_35; // 0x61C
        public object field_36; // 0x61D
        public object field_37; // 0x61E
        public object field_38; // 0x61F
        public object field_39; // 0x620
        public object field_40; // 0x621
        public object field_41; // 0x622
        public object field_42; // 0x623
        public object field_43; // 0x624
        public object field_44; // 0x625
        public object field_45; // 0x626
        public object field_46; // 0x627
        public object field_47; // 0x628
        public object field_48; // 0x629
        public object field_49; // 0x62A
        public object field_50; // 0x62B
        public object field_51; // 0x62C
        public object field_52; // 0x62D
        public object field_53; // 0x62E
        public object field_54; // 0x62F
        public object field_55; // 0x630
        public object field_56; // 0x631
        public object field_57; // 0x632
        public object field_58; // 0x633
        public object field_59; // 0x634
        public object field_60; // 0x635
        public object field_61; // 0x636
        public object field_62; // 0x637
        public object field_63; // 0x638
        public object field_64; // 0x639
        public object field_65; // 0x63A
        public object field_66; // 0x63B
        public object field_67; // 0x63C
        public object field_68; // 0x63D
        public object field_69; // 0x63E
        public object field_70; // 0x63F
        public object field_71; // 0x640
        public object field_72; // 0x641
        public object field_73; // 0x642
        public object field_74; // 0x643
        public object field_75; // 0x644
        public object field_76; // 0x645
        public object field_77; // 0x646
        public object field_78; // 0x647
        public object field_79; // 0x648
        public object field_80; // 0x649

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE87EAEF50
        public void Acquire(){} // RVA: 0x7FFE87EAEFA0
        public void .cctor(){} // RVA: 0x7FFE87EAF060
        public void get_alignContent(){} // RVA: 0x7FFE87EB0340
        public void get_alignItems(){} // RVA: 0x7FFE87EB03C0
        public void get_alignSelf(){} // RVA: 0x7FFE87EB0440
        public void get_backgroundColor(){} // RVA: 0x7FFE87EB04C0
        public void get_backgroundImage(){} // RVA: 0x7FFE87EB0540
        public void get_backgroundPositionX(){} // RVA: 0x7FFE87EB05D0
        public void get_backgroundPositionY(){} // RVA: 0x7FFE87EB0660
        public void get_backgroundRepeat(){} // RVA: 0x7FFE87EB06F0
        public void get_backgroundSize(){} // RVA: 0x7FFE87EB0770
        public void get_borderBottomColor(){} // RVA: 0x7FFE87EB0800
        public void get_borderBottomLeftRadius(){} // RVA: 0x7FFE87EB0880
        public void get_borderBottomRightRadius(){} // RVA: 0x7FFE87EB0900
        public void get_borderBottomWidth(){} // RVA: 0x7FFE87EB0980
        public void get_borderLeftColor(){} // RVA: 0x7FFE87EB0A00
        public void get_borderLeftWidth(){} // RVA: 0x7FFE87EB0A90
        public void get_borderRightColor(){} // RVA: 0x7FFE87EB0B10
        public void get_borderRightWidth(){} // RVA: 0x7FFE87EB0BA0
        public void get_borderTopColor(){} // RVA: 0x7FFE87EB0C20
        public void get_borderTopLeftRadius(){} // RVA: 0x7FFE87EB0CB0
        public void get_borderTopRightRadius(){} // RVA: 0x7FFE87EB0D30
        public void get_borderTopWidth(){} // RVA: 0x7FFE87EB0DB0
        public void get_bottom(){} // RVA: 0x7FFE87EB0E30
        public void get_color(){} // RVA: 0x7FFE87EB0EB0
        public void get_cursor(){} // RVA: 0x7FFE87EB0F30
        public void get_display(){} // RVA: 0x7FFE87EB0FC0
        public void get_flexBasis(){} // RVA: 0x7FFE87EB1040
        public void get_flexDirection(){} // RVA: 0x7FFE87EB10C0
        public void get_flexGrow(){} // RVA: 0x7FFE87EB1140
        public void get_flexShrink(){} // RVA: 0x7FFE87EB11C0
        public void get_flexWrap(){} // RVA: 0x7FFE87EB1240
        public void get_fontSize(){} // RVA: 0x7FFE87EB12C0
        public void get_height(){} // RVA: 0x7FFE87EB1340
        public void get_justifyContent(){} // RVA: 0x7FFE87EB13C0
        public void get_left(){} // RVA: 0x7FFE87EB1440
        public void get_letterSpacing(){} // RVA: 0x7FFE87EB14C0
        public void get_marginBottom(){} // RVA: 0x7FFE87EB1540
        public void get_marginLeft(){} // RVA: 0x7FFE87EB15C0
        public void get_marginRight(){} // RVA: 0x7FFE87EB1640
        public void get_marginTop(){} // RVA: 0x7FFE87EB16C0
        public void get_maxHeight(){} // RVA: 0x7FFE87EB1740
        public void get_maxWidth(){} // RVA: 0x7FFE87EB17C0
        public void get_minHeight(){} // RVA: 0x7FFE87EB1840
        public void get_minWidth(){} // RVA: 0x7FFE87EB18C0
        public void get_opacity(){} // RVA: 0x7FFE87EB1940
        public void get_overflow(){} // RVA: 0x7FFE87EB19C0
        public void get_paddingBottom(){} // RVA: 0x7FFE87EB1A40
        public void get_paddingLeft(){} // RVA: 0x7FFE87EB1AC0
        public void get_paddingRight(){} // RVA: 0x7FFE87EB1B40
        public void get_paddingTop(){} // RVA: 0x7FFE87EB1BC0
        public void get_position(){} // RVA: 0x7FFE87EB1C40
        public void get_right(){} // RVA: 0x7FFE87EB1CC0
        public void get_rotate(){} // RVA: 0x7FFE87EB1D40
        public void get_scale(){} // RVA: 0x7FFE87EB1DD0
        public void get_textOverflow(){} // RVA: 0x7FFE87EB1E50
        public void get_textShadow(){} // RVA: 0x7FFE87EB1ED0
        public void get_top(){} // RVA: 0x7FFE87EB1F60
        public void get_transformOrigin(){} // RVA: 0x7FFE87EB1FE0
        public void get_transitionDelay(){} // RVA: 0x7FFE87EB2070
        public void get_transitionDuration(){} // RVA: 0x7FFE87EB20F0
        public void get_transitionProperty(){} // RVA: 0x7FFE87EB2170
        public void get_transitionTimingFunction(){} // RVA: 0x7FFE87EB21F0
        public void get_translate(){} // RVA: 0x7FFE87EB2270
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7FFE87EB2300
        public void get_unityFont(){} // RVA: 0x7FFE87EB2380
        public void get_unityFontDefinition(){} // RVA: 0x7FFE87EB2400
        public void get_unityFontStyleAndWeight(){} // RVA: 0x7FFE87EB2480
        public void get_unityOverflowClipBox(){} // RVA: 0x7FFE87EB2500
        public void get_unityParagraphSpacing(){} // RVA: 0x7FFE87EB2580
        public void get_unitySliceBottom(){} // RVA: 0x7FFE87EB2600
        public void get_unitySliceLeft(){} // RVA: 0x7FFE87EB2680
        public void get_unitySliceRight(){} // RVA: 0x7FFE87EB2700
        public void get_unitySliceScale(){} // RVA: 0x7FFE87EB2780
        public void get_unitySliceTop(){} // RVA: 0x7FFE87EB2800
        public void get_unityTextAlign(){} // RVA: 0x7FFE87EB2880
        public void get_unityTextOutlineColor(){} // RVA: 0x7FFE87EB2900
        public void get_unityTextOutlineWidth(){} // RVA: 0x7FFE87EB2990
        public void get_unityTextOverflowPosition(){} // RVA: 0x7FFE87EB2A10
        public void get_visibility(){} // RVA: 0x7FFE87EB2A90
        public void get_whiteSpace(){} // RVA: 0x7FFE87EB2B10
        public void get_width(){} // RVA: 0x7FFE87EB2B90
        public void get_wordSpacing(){} // RVA: 0x7FFE87EB2C10
    }

    public class MatchResult : ValueType
    {
        public 0x66522D1C errorCode; // 0x10

        // ── Methods ──
        public void get_success(){} // RVA: 0x7FFE87EC98D0
    }

    public class MatchResultInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87EC42A0
    }

    public class ScalableImage : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE87EBDC90
    }

    public class SelectorMatchRecord : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87EC42B0
        public void Compare(){} // RVA: 0x7FFE87EC4310
    }

    public class ShorthandApplicator : Object
    {
        // ── Methods ──
        public void ApplyBackgroundPosition(){} // RVA: 0x7FFE87EB2D10
        public void ApplyBorderColor(){} // RVA: 0x7FFE87EB2DE0
        public void ApplyBorderRadius(){} // RVA: 0x7FFE87EB3010
        public void ApplyBorderWidth(){} // RVA: 0x7FFE87EB3260
        public void ApplyFlex(){} // RVA: 0x7FFE87EB3380
        public void ApplyMargin(){} // RVA: 0x7FFE87EB3470
        public void ApplyPadding(){} // RVA: 0x7FFE87EB36E0
        public void ApplyTransition(){} // RVA: 0x7FFE87EB3960
        public void ApplyUnityBackgroundScaleMode(){} // RVA: 0x7FFE87EB3BF0
        public void ApplyUnityTextOutline(){} // RVA: 0x7FFE87EB3D60
        public void CompileFlexShorthand(){} // RVA: 0x7FFE87EB3EF0
        public void CompileBorderRadius(){} // RVA: 0x7FFE87EB4150
        public void CompileBackgroundPosition(){} // RVA: 0x7FFE87EB4250
        public void CompileUnityBackgroundScaleMode(){} // RVA: 0x7FFE87EB4970
        public void CompileBoxArea(){} // RVA: 0x7FFE87EB4E10 | overloaded x3
        public void CompileTextOutline(){} // RVA: 0x7FFE87EB4FC0
        public void CompileTransition(){} // RVA: 0x7FFE87EB50E0
        public void .cctor(){} // RVA: 0x7FFE87EB5EE0
        public void <CompileBackgroundPosition>g__SwapKeyword|16_0(){} // RVA: 0x7FFE87EB61C0
    }

    public class StylePropertyCache : Object
    {
        // ── Methods ──
        public void TryGetSyntax(){} // RVA: 0x7FFE87EB61D0
        public void TryGetNonTerminalValue(){} // RVA: 0x7FFE87EB6270
        public void .cctor(){} // RVA: 0x7FFE87EB6310
    }

    public class StylePropertyReader : Object
    {
        public GetCursorIdFunction getCursorIdFunc;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_Values; // 0x10
        public System.Collections.Generic.List`1<int> m_ValueCount; // 0x18
        public UnityEngine.UIElements.StyleVariableResolver m_Resolver; // 0x20

        // ── Methods ──
        public void get_property(){} // RVA: 0x7FFE81176730
        public void set_property(){} // RVA: 0x7FFE81176740
        public void get_propertyId(){} // RVA: 0x7FFE8139DAD0
        public void set_propertyId(){} // RVA: 0x7FFE81463B00
        public void get_valueCount(){} // RVA: 0x7FFE819EA920
        public void set_valueCount(){} // RVA: 0x7FFE819EA900
        public void get_dpiScaling(){} // RVA: 0x7FFE81123FE0
        public void set_dpiScaling(){} // RVA: 0x7FFE81123FF0
        public void SetContext(){} // RVA: 0x7FFE87EBE140
        public void SetInlineContext(){} // RVA: 0x7FFE87EBE350
        public void MoveNextProperty(){} // RVA: 0x7FFE87EBE470
        public void GetValue(){} // RVA: 0x7FFE87EBE4A0
        public void GetValueType(){} // RVA: 0x7FFE87EBE540
        public void IsValueType(){} // RVA: 0x7FFE87EBE5C0
        public void IsKeyword(){} // RVA: 0x7FFE87EBE650
        public void ReadAsString(){} // RVA: 0x7FFE87EBE710
        public void ReadLength(){} // RVA: 0x7FFE87EBE7B0
        public void ReadTimeValue(){} // RVA: 0x7FFE87EBE900
        public void ReadTranslate(){} // RVA: 0x7FFE87EC2730 | overloaded x2
        public void ReadTransformOrigin(){} // RVA: 0x7FFE87EC23A0 | overloaded x2
        public void ReadRotate(){} // RVA: 0x7FFE87EC2CE0 | overloaded x2
        public void ReadScale(){} // RVA: 0x7FFE87EC2AA0 | overloaded x2
        public void ReadFloat(){} // RVA: 0x7FFE87EBF320
        public void ReadInt(){} // RVA: 0x7FFE87EBF3C0
        public void ReadColor(){} // RVA: 0x7FFE87EBF460
        public void ReadEnum(){} // RVA: 0x7FFE87EC2F40 | overloaded x2
        public void ReadFontDefinition(){} // RVA: 0x7FFE87EBF730
        public void ReadFont(){} // RVA: 0x7FFE87EBFFC0
        public void ReadBackground(){} // RVA: 0x7FFE87EC0360
        public void ReadCursor(){} // RVA: 0x7FFE87EC07E0
        public void ReadTextShadow(){} // RVA: 0x7FFE87EC0CE0
        public void ReadBackgroundPositionX(){} // RVA: 0x7FFE87EC1240
        public void ReadBackgroundPositionY(){} // RVA: 0x7FFE87EC1280
        public void ReadBackgroundPosition(){} // RVA: 0x7FFE87EC30B0 | overloaded x2
        public void ReadBackgroundRepeat(){} // RVA: 0x7FFE87EC3310 | overloaded x2
        public void ReadBackgroundSize(){} // RVA: 0x7FFE87EC3490 | overloaded x2
        public void ReadListEasingFunction(){} // RVA: 0x7FFE87EC1750
        public void ReadListTimeValue(){} // RVA: 0x7FFE87EC19A0
        public void ReadListStylePropertyName(){} // RVA: 0x7FFE87EC1B70
        public void LoadProperties(){} // RVA: 0x7FFE87EC1DB0
        public void SetCurrentProperty(){} // RVA: 0x7FFE87EC2220
        public void ReadTransformOriginEnum(){} // RVA: 0x7FFE87EC2550
        public void TryReadEnum(){} // RVA: 0x7FFE87EC2E90
        public void ReadAngle(){} // RVA: 0x7FFE87EC2FF0
        public void TryGetImageSourceFromValue(){} // RVA: 0x7FFE87EC3760
        public void .ctor(){} // RVA: 0x7FFE87EC3F40
    }

    public class StylePropertyUtil : Object
    {
        // ── Methods ──
        public void TryGetEnumIntValue(){} // RVA: 0x7FFE87EB8370
        public void IsMatchingShorthand(){} // RVA: 0x7FFE87EB97D0
        public void IsAnimatable(){} // RVA: 0x7FFE87EB9930
        public void .cctor(){} // RVA: 0x7FFE87EB99C0
    }

    public class StylePropertyValue : ValueType
    {
    }

    public class StylePropertyValueMatcher : BaseStyleMatcher
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_Values; // 0x20
        public object field_1; // 0x656
        public object field_2; // 0x657
        public object field_3; // 0x658

        // ── Methods ──
        public void get_current(){} // RVA: 0x7FFE87ECAC40
        public void get_valueCount(){} // RVA: 0x7FFE87ECAD00
        public void get_isCurrentVariable(){} // RVA: 0x7FFE810FB320
        public void get_isCurrentComma(){} // RVA: 0x7FFE87ECAD50
        public void Match(){} // RVA: 0x7FFE87ECAE10
        public void MatchKeyword(){} // RVA: 0x7FFE87ECB120
        public void MatchNumber(){} // RVA: 0x7FFE87ECB1F0
        public void MatchInteger(){} // RVA: 0x7FFE87ECB1F0
        public void MatchLength(){} // RVA: 0x7FFE87ECB210
        public void MatchPercentage(){} // RVA: 0x7FFE87ECB290
        public void MatchColor(){} // RVA: 0x7FFE87ECB310
        public void MatchResource(){} // RVA: 0x7FFE87ECB3D0
        public void MatchUrl(){} // RVA: 0x7FFE87ECB3F0
        public void MatchTime(){} // RVA: 0x7FFE87ECB430
        public void MatchCustomIdent(){} // RVA: 0x7FFE87ECB4A0
        public void MatchAngle(){} // RVA: 0x7FFE87ECB5F0
        public void .ctor(){} // RVA: 0x7FFE87ECB670
    }

    public class StyleSelectorHelper : Object
    {
        // ── Methods ──
        public void MatchesSelector(){} // RVA: 0x7FFE87EC4410
        public void MatchRightToLeft(){} // RVA: 0x7FFE87EC4710
        public void FastLookup(){} // RVA: 0x7FFE87EC48B0
        public void FindMatches(){} // RVA: 0x7FFE87EC4C50
    }

    public class StyleSheetCache : Object
    {
        // ── Methods ──
        public void GetPropertyIds(){} // RVA: 0x7FFE87EC54A0 | overloaded x2
        public void GetPropertyId(){} // RVA: 0x7FFE87EC5570
        public void .cctor(){} // RVA: 0x7FFE87EC5690
    }

    public class StyleSheetColor : Object
    {
        // ── Methods ──
        public void TryGetColor(){} // RVA: 0x7FFE87EC58F0
        public void HexToColor32(){} // RVA: 0x7FFE87EC5A50
        public void .cctor(){} // RVA: 0x7FFE87EC5A70
    }

    public class StyleSheetExtensions : Object
    {
        // ── Methods ──
        public void ReadAsString(){} // RVA: 0x7FFE87EC94D0
        public void IsVarFunction(){} // RVA: 0x7FFE87EC98B0
    }

    public class StyleValue : ValueType
    {
    }

    public class StyleValueManaged : ValueType
    {
    }

}