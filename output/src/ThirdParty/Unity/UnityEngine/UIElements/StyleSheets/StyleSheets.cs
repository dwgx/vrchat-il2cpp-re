// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.StyleSheets
// Classes: 21
// Methods: 253

namespace ThirdParty.Unity.UnityEngine.UIElements.StyleSheets
{
    public class BaseStyleMatcher
    {
        // ── Methods ──
        public void MatchKeyword(){} // RVA: 0xDE40
        public void MatchNumber(){} // RVA: 0xDBE0
        public void MatchInteger(){} // RVA: 0xDBE0
        public void MatchLength(){} // RVA: 0xDBE0
        public void MatchPercentage(){} // RVA: 0xDBE0
        public void MatchColor(){} // RVA: 0xDBE0
        public void MatchResource(){} // RVA: 0xDBE0
        public void MatchUrl(){} // RVA: 0xDBE0
        public void MatchTime(){} // RVA: 0xDBE0
        public void MatchAngle(){} // RVA: 0xDBE0
        public void MatchCustomIdent(){} // RVA: 0xDBE0
        public void get_valueCount(){} // RVA: 0xD840
        public void get_isCurrentVariable(){} // RVA: 0xDBE0
        public void get_isCurrentComma(){} // RVA: 0xDBE0
        public void get_hasCurrent(){} // RVA: 0x7389760
        public void get_currentIndex(){} // RVA: 0x5BED50
        public void set_currentIndex(){} // RVA: 0x6374E0
        public void get_matchedVariableCount(){} // RVA: 0x197C3B0
        public void set_matchedVariableCount(){} // RVA: 0x1989FD0
        public void Initialize(){} // RVA: 0x7389790
        public void MoveNext(){} // RVA: 0x73897E0
        public void SaveContext(){} // RVA: 0x7389820
        public void RestoreContext(){} // RVA: 0x73898B0
        public void DropContext(){} // RVA: 0x7389900
        public void Match(){} // RVA: 0x7389950
        public void MatchExpression(){} // RVA: 0x7389AF0
        public void MatchExpressionWithMultiplier(){} // RVA: 0x7389C00
        public void MatchGroup(){} // RVA: 0x7389D20
        public void MatchCombinator(){} // RVA: 0x7389DE0
        public void MatchOr(){} // RVA: 0x738A120
        public void MatchOrOr(){} // RVA: 0x738A290
        public void MatchAndAnd(){} // RVA: 0x738A2B0
        public void MatchMany(){} // RVA: 0x738A2F0
        public void MatchManyByOrder(){} // RVA: 0x738A4F0
        public void MatchJuxtaposition(){} // RVA: 0x738A660
        public void MatchDataType(){} // RVA: 0x738A6E0
        public void .ctor(){} // RVA: 0x738A860
        public void .cctor(){} // RVA: 0x738A9E0
    }

    public class Dimension
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x737D6E0
        public void ToLength(){} // RVA: 0x737D6F0
        public void ToTime(){} // RVA: 0x737D730
        public void ToAngle(){} // RVA: 0x737D750
        public void op_Equality(){} // RVA: 0x737D7B0
        public void Equals(){} // RVA: 0x737D810 | overloaded x2
        public void GetHashCode(){} // RVA: 0x737D8C0
        public void ToString(){} // RVA: 0x737D8F0
    }

    public class HierarchyTraversal
    {
        // ── Methods ──
        public void Traverse(){} // RVA: 0x736EC60
        public void TraverseRecursive(){} // RVA: 0x2BAA0
        public void Recurse(){} // RVA: 0x736EC80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ImageSource
    {
        // ── Methods ──
        public void IsNull(){} // RVA: 0x737DD10
    }

    public class InitialStyle
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x736EDD0
        public void Acquire(){} // RVA: 0x736EE20
        public void .cctor(){} // RVA: 0x736EEE0
        public void get_alignContent(){} // RVA: 0x73701C0
        public void get_alignItems(){} // RVA: 0x7370240
        public void get_alignSelf(){} // RVA: 0x73702C0
        public void get_backgroundColor(){} // RVA: 0x7370340
        public void get_backgroundImage(){} // RVA: 0x73703C0
        public void get_backgroundPositionX(){} // RVA: 0x7370450
        public void get_backgroundPositionY(){} // RVA: 0x73704E0
        public void get_backgroundRepeat(){} // RVA: 0x7370570
        public void get_backgroundSize(){} // RVA: 0x73705F0
        public void get_borderBottomColor(){} // RVA: 0x7370680
        public void get_borderBottomLeftRadius(){} // RVA: 0x7370700
        public void get_borderBottomRightRadius(){} // RVA: 0x7370780
        public void get_borderBottomWidth(){} // RVA: 0x7370800
        public void get_borderLeftColor(){} // RVA: 0x7370880
        public void get_borderLeftWidth(){} // RVA: 0x7370910
        public void get_borderRightColor(){} // RVA: 0x7370990
        public void get_borderRightWidth(){} // RVA: 0x7370A20
        public void get_borderTopColor(){} // RVA: 0x7370AA0
        public void get_borderTopLeftRadius(){} // RVA: 0x7370B30
        public void get_borderTopRightRadius(){} // RVA: 0x7370BB0
        public void get_borderTopWidth(){} // RVA: 0x7370C30
        public void get_bottom(){} // RVA: 0x7370CB0
        public void get_color(){} // RVA: 0x7370D30
        public void get_cursor(){} // RVA: 0x7370DB0
        public void get_display(){} // RVA: 0x7370E40
        public void get_flexBasis(){} // RVA: 0x7370EC0
        public void get_flexDirection(){} // RVA: 0x7370F40
        public void get_flexGrow(){} // RVA: 0x7370FC0
        public void get_flexShrink(){} // RVA: 0x7371040
        public void get_flexWrap(){} // RVA: 0x73710C0
        public void get_fontSize(){} // RVA: 0x7371140
        public void get_height(){} // RVA: 0x73711C0
        public void get_justifyContent(){} // RVA: 0x7371240
        public void get_left(){} // RVA: 0x73712C0
        public void get_letterSpacing(){} // RVA: 0x7371340
        public void get_marginBottom(){} // RVA: 0x73713C0
        public void get_marginLeft(){} // RVA: 0x7371440
        public void get_marginRight(){} // RVA: 0x73714C0
        public void get_marginTop(){} // RVA: 0x7371540
        public void get_maxHeight(){} // RVA: 0x73715C0
        public void get_maxWidth(){} // RVA: 0x7371640
        public void get_minHeight(){} // RVA: 0x73716C0
        public void get_minWidth(){} // RVA: 0x7371740
        public void get_opacity(){} // RVA: 0x73717C0
        public void get_overflow(){} // RVA: 0x7371840
        public void get_paddingBottom(){} // RVA: 0x73718C0
        public void get_paddingLeft(){} // RVA: 0x7371940
        public void get_paddingRight(){} // RVA: 0x73719C0
        public void get_paddingTop(){} // RVA: 0x7371A40
        public void get_position(){} // RVA: 0x7371AC0
        public void get_right(){} // RVA: 0x7371B40
        public void get_rotate(){} // RVA: 0x7371BC0
        public void get_scale(){} // RVA: 0x7371C50
        public void get_textOverflow(){} // RVA: 0x7371CD0
        public void get_textShadow(){} // RVA: 0x7371D50
        public void get_top(){} // RVA: 0x7371DE0
        public void get_transformOrigin(){} // RVA: 0x7371E60
        public void get_transitionDelay(){} // RVA: 0x7371EF0
        public void get_transitionDuration(){} // RVA: 0x7371F70
        public void get_transitionProperty(){} // RVA: 0x7371FF0
        public void get_transitionTimingFunction(){} // RVA: 0x7372070
        public void get_translate(){} // RVA: 0x73720F0
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7372180
        public void get_unityFont(){} // RVA: 0x7372200
        public void get_unityFontDefinition(){} // RVA: 0x7372280
        public void get_unityFontStyleAndWeight(){} // RVA: 0x7372300
        public void get_unityOverflowClipBox(){} // RVA: 0x7372380
        public void get_unityParagraphSpacing(){} // RVA: 0x7372400
        public void get_unitySliceBottom(){} // RVA: 0x7372480
        public void get_unitySliceLeft(){} // RVA: 0x7372500
        public void get_unitySliceRight(){} // RVA: 0x7372580
        public void get_unitySliceScale(){} // RVA: 0x7372600
        public void get_unitySliceTop(){} // RVA: 0x7372680
        public void get_unityTextAlign(){} // RVA: 0x7372700
        public void get_unityTextOutlineColor(){} // RVA: 0x7372780
        public void get_unityTextOutlineWidth(){} // RVA: 0x7372810
        public void get_unityTextOverflowPosition(){} // RVA: 0x7372890
        public void get_visibility(){} // RVA: 0x7372910
        public void get_whiteSpace(){} // RVA: 0x7372990
        public void get_width(){} // RVA: 0x7372A10
        public void get_wordSpacing(){} // RVA: 0x7372A90
    }

    public class MatchResult
    {
        // ── Methods ──
        public void get_success(){} // RVA: 0x7389750
    }

    public class MatchResultInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7384120
    }

    public class ScalableImage
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x737DB10
    }

    public class SelectorMatchRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7384130
        public void Compare(){} // RVA: 0x7384190
    }

    public class ShorthandApplicator
    {
        // ── Methods ──
        public void ApplyBackgroundPosition(){} // RVA: 0x7372B90
        public void ApplyBorderColor(){} // RVA: 0x7372C60
        public void ApplyBorderRadius(){} // RVA: 0x7372E90
        public void ApplyBorderWidth(){} // RVA: 0x73730E0
        public void ApplyFlex(){} // RVA: 0x7373200
        public void ApplyMargin(){} // RVA: 0x73732F0
        public void ApplyPadding(){} // RVA: 0x7373560
        public void ApplyTransition(){} // RVA: 0x73737E0
        public void ApplyUnityBackgroundScaleMode(){} // RVA: 0x7373A70
        public void ApplyUnityTextOutline(){} // RVA: 0x7373BE0
        public void CompileFlexShorthand(){} // RVA: 0x7373D70
        public void CompileBorderRadius(){} // RVA: 0x7373FD0
        public void CompileBackgroundPosition(){} // RVA: 0x73740D0
        public void CompileUnityBackgroundScaleMode(){} // RVA: 0x73747F0
        public void CompileBoxArea(){} // RVA: 0x7374C90 | overloaded x3
        public void CompileTextOutline(){} // RVA: 0x7374E40
        public void CompileTransition(){} // RVA: 0x7374F60
        public void .cctor(){} // RVA: 0x7375D60
        public void <CompileBackgroundPosition>g__SwapKeyword|16_0(){} // RVA: 0x7376040
    }

    public class StylePropertyCache
    {
        // ── Methods ──
        public void TryGetSyntax(){} // RVA: 0x7376050
        public void TryGetNonTerminalValue(){} // RVA: 0x73760F0
        public void .cctor(){} // RVA: 0x7376190
    }

    public class StylePropertyReader
    {
        // ── Methods ──
        public void get_property(){} // RVA: 0x358730
        public void set_property(){} // RVA: 0x358740
        public void get_propertyId(){} // RVA: 0x59C540
        public void set_propertyId(){} // RVA: 0x65F570
        public void get_valueCount(){} // RVA: 0xC5BE80
        public void set_valueCount(){} // RVA: 0xC5BE70
        public void get_dpiScaling(){} // RVA: 0x305FE0
        public void set_dpiScaling(){} // RVA: 0x305FF0
        public void SetContext(){} // RVA: 0x737DFC0
        public void SetInlineContext(){} // RVA: 0x737E1D0
        public void MoveNextProperty(){} // RVA: 0x737E2F0
        public void GetValue(){} // RVA: 0x737E320
        public void GetValueType(){} // RVA: 0x737E3C0
        public void IsValueType(){} // RVA: 0x737E440
        public void IsKeyword(){} // RVA: 0x737E4D0
        public void ReadAsString(){} // RVA: 0x737E590
        public void ReadLength(){} // RVA: 0x737E630
        public void ReadTimeValue(){} // RVA: 0x737E780
        public void ReadTranslate(){} // RVA: 0x73825B0 | overloaded x2
        public void ReadTransformOrigin(){} // RVA: 0x7382220 | overloaded x2
        public void ReadRotate(){} // RVA: 0x7382B60 | overloaded x2
        public void ReadScale(){} // RVA: 0x7382920 | overloaded x2
        public void ReadFloat(){} // RVA: 0x737F1A0
        public void ReadInt(){} // RVA: 0x737F240
        public void ReadColor(){} // RVA: 0x737F2E0
        public void ReadEnum(){} // RVA: 0x7382DC0 | overloaded x2
        public void ReadFontDefinition(){} // RVA: 0x737F5B0
        public void ReadFont(){} // RVA: 0x737FE40
        public void ReadBackground(){} // RVA: 0x73801E0
        public void ReadCursor(){} // RVA: 0x7380660
        public void ReadTextShadow(){} // RVA: 0x7380B60
        public void ReadBackgroundPositionX(){} // RVA: 0x73810C0
        public void ReadBackgroundPositionY(){} // RVA: 0x7381100
        public void ReadBackgroundPosition(){} // RVA: 0x7382F30 | overloaded x2
        public void ReadBackgroundRepeat(){} // RVA: 0x7383190 | overloaded x2
        public void ReadBackgroundSize(){} // RVA: 0x7383310 | overloaded x2
        public void ReadListEasingFunction(){} // RVA: 0x73815D0
        public void ReadListTimeValue(){} // RVA: 0x7381820
        public void ReadListStylePropertyName(){} // RVA: 0x73819F0
        public void LoadProperties(){} // RVA: 0x7381C30
        public void SetCurrentProperty(){} // RVA: 0x73820A0
        public void ReadTransformOriginEnum(){} // RVA: 0x73823D0
        public void TryReadEnum(){} // RVA: 0x7382D10
        public void ReadAngle(){} // RVA: 0x7382E70
        public void TryGetImageSourceFromValue(){} // RVA: 0x73835E0
        public void .ctor(){} // RVA: 0x7383DC0
    }

    public class StylePropertyUtil
    {
        // ── Methods ──
        public void TryGetEnumIntValue(){} // RVA: 0x73781F0
        public void IsMatchingShorthand(){} // RVA: 0x7379650
        public void IsAnimatable(){} // RVA: 0x73797B0
        public void .cctor(){} // RVA: 0x7379840
    }

    public class StylePropertyValue
    {
    }

    public class StylePropertyValueMatcher
    {
        // ── Methods ──
        public void get_current(){} // RVA: 0x738AAC0
        public void get_valueCount(){} // RVA: 0x738AB80
        public void get_isCurrentVariable(){} // RVA: 0x2DD320
        public void get_isCurrentComma(){} // RVA: 0x738ABD0
        public void Match(){} // RVA: 0x738AC90
        public void MatchKeyword(){} // RVA: 0x738AFA0
        public void MatchNumber(){} // RVA: 0x738B070
        public void MatchInteger(){} // RVA: 0x738B070
        public void MatchLength(){} // RVA: 0x738B090
        public void MatchPercentage(){} // RVA: 0x738B110
        public void MatchColor(){} // RVA: 0x738B190
        public void MatchResource(){} // RVA: 0x738B250
        public void MatchUrl(){} // RVA: 0x738B270
        public void MatchTime(){} // RVA: 0x738B2B0
        public void MatchCustomIdent(){} // RVA: 0x738B320
        public void MatchAngle(){} // RVA: 0x738B470
        public void .ctor(){} // RVA: 0x738B4F0
    }

    public class StyleSelectorHelper
    {
        // ── Methods ──
        public void MatchesSelector(){} // RVA: 0x7384290
        public void MatchRightToLeft(){} // RVA: 0x7384590
        public void FastLookup(){} // RVA: 0x7384730
        public void FindMatches(){} // RVA: 0x7384AD0
    }

    public class StyleSheetCache
    {
        // ── Methods ──
        public void GetPropertyIds(){} // RVA: 0x7385320 | overloaded x2
        public void GetPropertyId(){} // RVA: 0x73853F0
        public void .cctor(){} // RVA: 0x7385510
    }

    public class StyleSheetColor
    {
        // ── Methods ──
        public void TryGetColor(){} // RVA: 0x7385770
        public void HexToColor32(){} // RVA: 0x73858D0
        public void .cctor(){} // RVA: 0x73858F0
    }

    public class StyleSheetExtensions
    {
        // ── Methods ──
        public void ReadAsString(){} // RVA: 0x7389350
        public void IsVarFunction(){} // RVA: 0x7389730
    }

    public class StyleValue
    {
    }

    public class StyleValueManaged
    {
    }

}