// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.StyleSheets
// Classes: 21
// Methods: 253

namespace ThirdParty.Unity.UnityEngine.UIElements.StyleSheets
{
    public class BaseStyleMatcher : Object
    {
        public System.Text.RegularExpressions.Regex valueCount;
        public System.Collections.Generic.Stack`1<MatchContext> isCurrentVariable; // 0x10
        public MatchContext isCurrentComma; // 0x18

        // ── Methods ──
        public void MatchKeyword(){} // RVA: 0x7FFAC2C59F60
        public void MatchNumber(){} // RVA: 0x7FFAC2C59D00
        public void MatchInteger(){} // RVA: 0x7FFAC2C59D00
        public void MatchLength(){} // RVA: 0x7FFAC2C59D00
        public void MatchPercentage(){} // RVA: 0x7FFAC2C59D00
        public void MatchColor(){} // RVA: 0x7FFAC2C59D00
        public void MatchResource(){} // RVA: 0x7FFAC2C59D00
        public void MatchUrl(){} // RVA: 0x7FFAC2C59D00
        public void MatchTime(){} // RVA: 0x7FFAC2C59D00
        public void MatchAngle(){} // RVA: 0x7FFAC2C59D00
        public void MatchCustomIdent(){} // RVA: 0x7FFAC2C59D00
        public void get_valueCount(){} // RVA: 0x7FFAC2C59960
        public void get_isCurrentVariable(){} // RVA: 0x7FFAC2C59D00
        public void get_isCurrentComma(){} // RVA: 0x7FFAC2C59D00
        public void get_hasCurrent(){} // RVA: 0x7FFAC9B21040
        public void get_currentIndex(){} // RVA: 0x7FFAC3157800
        public void set_currentIndex(){} // RVA: 0x7FFAC392CD10
        public void get_matchedVariableCount(){} // RVA: 0x7FFAC44357F0
        public void set_matchedVariableCount(){} // RVA: 0x7FFAC44474D0
        public void Initialize(){} // RVA: 0x7FFAC9B21070
        public void MoveNext(){} // RVA: 0x7FFAC9B210C0
        public void SaveContext(){} // RVA: 0x7FFAC9B21100
        public void RestoreContext(){} // RVA: 0x7FFAC9B21190
        public void DropContext(){} // RVA: 0x7FFAC9B211E0
        public void Match(){} // RVA: 0x7FFAC9B21230
        public void MatchExpression(){} // RVA: 0x7FFAC9B213D0
        public void MatchExpressionWithMultiplier(){} // RVA: 0x7FFAC9B214E0
        public void MatchGroup(){} // RVA: 0x7FFAC9B21600
        public void MatchCombinator(){} // RVA: 0x7FFAC9B216C0
        public void MatchOr(){} // RVA: 0x7FFAC9B21A00
        public void MatchOrOr(){} // RVA: 0x7FFAC9B21B70
        public void MatchAndAnd(){} // RVA: 0x7FFAC9B21B90
        public void MatchMany(){} // RVA: 0x7FFAC9B21BD0
        public void MatchManyByOrder(){} // RVA: 0x7FFAC9B21DD0
        public void MatchJuxtaposition(){} // RVA: 0x7FFAC9B21F40
        public void MatchDataType(){} // RVA: 0x7FFAC9B21FC0
        public void .ctor(){} // RVA: 0x7FFAC9B22140
        public void .cctor(){} // RVA: 0x7FFAC9B222C0
    }

    public class Dimension : ValueType
    {
        public 0x6B129820 unit; // 0x10
        public float value; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B14FC0
        public void ToLength(){} // RVA: 0x7FFAC9B14FD0
        public void ToTime(){} // RVA: 0x7FFAC9B15010
        public void ToAngle(){} // RVA: 0x7FFAC9B15030
        public void op_Equality(){} // RVA: 0x7FFAC9B15090
        public void Equals(){} // RVA: 0x7FFAC9B150F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9B151A0
        public void ToString(){} // RVA: 0x7FFAC9B151D0
    }

    public class HierarchyTraversal : Object
    {
        // ── Methods ──
        public void Traverse(){} // RVA: 0x7FFAC9B06540
        public void TraverseRecursive(){} // RVA: 0x7FFAC2C77970
        public void Recurse(){} // RVA: 0x7FFAC9B06560
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ImageSource : ValueType
    {
        public UnityEngine.Texture2D texture; // 0x10
        public UnityEngine.Sprite sprite; // 0x18
        public UnityEngine.UIElements.VectorImage vectorImage; // 0x20
        public UnityEngine.RenderTexture renderTexture; // 0x28

        // ── Methods ──
        public void IsNull(){} // RVA: 0x7FFAC9B155F0
    }

    public class InitialStyle : Object
    {
        public UnityEngine.UIElements.ComputedStyle alignContent;

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC9B066B0
        public void Acquire(){} // RVA: 0x7FFAC9B06700
        public void .cctor(){} // RVA: 0x7FFAC9B067C0
        public void get_alignContent(){} // RVA: 0x7FFAC9B07AA0
        public void get_alignItems(){} // RVA: 0x7FFAC9B07B20
        public void get_alignSelf(){} // RVA: 0x7FFAC9B07BA0
        public void get_backgroundColor(){} // RVA: 0x7FFAC9B07C20
        public void get_backgroundImage(){} // RVA: 0x7FFAC9B07CA0
        public void get_backgroundPositionX(){} // RVA: 0x7FFAC9B07D30
        public void get_backgroundPositionY(){} // RVA: 0x7FFAC9B07DC0
        public void get_backgroundRepeat(){} // RVA: 0x7FFAC9B07E50
        public void get_backgroundSize(){} // RVA: 0x7FFAC9B07ED0
        public void get_borderBottomColor(){} // RVA: 0x7FFAC9B07F60
        public void get_borderBottomLeftRadius(){} // RVA: 0x7FFAC9B07FE0
        public void get_borderBottomRightRadius(){} // RVA: 0x7FFAC9B08060
        public void get_borderBottomWidth(){} // RVA: 0x7FFAC9B080E0
        public void get_borderLeftColor(){} // RVA: 0x7FFAC9B08160
        public void get_borderLeftWidth(){} // RVA: 0x7FFAC9B081F0
        public void get_borderRightColor(){} // RVA: 0x7FFAC9B08270
        public void get_borderRightWidth(){} // RVA: 0x7FFAC9B08300
        public void get_borderTopColor(){} // RVA: 0x7FFAC9B08380
        public void get_borderTopLeftRadius(){} // RVA: 0x7FFAC9B08410
        public void get_borderTopRightRadius(){} // RVA: 0x7FFAC9B08490
        public void get_borderTopWidth(){} // RVA: 0x7FFAC9B08510
        public void get_bottom(){} // RVA: 0x7FFAC9B08590
        public void get_color(){} // RVA: 0x7FFAC9B08610
        public void get_cursor(){} // RVA: 0x7FFAC9B08690
        public void get_display(){} // RVA: 0x7FFAC9B08720
        public void get_flexBasis(){} // RVA: 0x7FFAC9B087A0
        public void get_flexDirection(){} // RVA: 0x7FFAC9B08820
        public void get_flexGrow(){} // RVA: 0x7FFAC9B088A0
        public void get_flexShrink(){} // RVA: 0x7FFAC9B08920
        public void get_flexWrap(){} // RVA: 0x7FFAC9B089A0
        public void get_fontSize(){} // RVA: 0x7FFAC9B08A20
        public void get_height(){} // RVA: 0x7FFAC9B08AA0
        public void get_justifyContent(){} // RVA: 0x7FFAC9B08B20
        public void get_left(){} // RVA: 0x7FFAC9B08BA0
        public void get_letterSpacing(){} // RVA: 0x7FFAC9B08C20
        public void get_marginBottom(){} // RVA: 0x7FFAC9B08CA0
        public void get_marginLeft(){} // RVA: 0x7FFAC9B08D20
        public void get_marginRight(){} // RVA: 0x7FFAC9B08DA0
        public void get_marginTop(){} // RVA: 0x7FFAC9B08E20
        public void get_maxHeight(){} // RVA: 0x7FFAC9B08EA0
        public void get_maxWidth(){} // RVA: 0x7FFAC9B08F20
        public void get_minHeight(){} // RVA: 0x7FFAC9B08FA0
        public void get_minWidth(){} // RVA: 0x7FFAC9B09020
        public void get_opacity(){} // RVA: 0x7FFAC9B090A0
        public void get_overflow(){} // RVA: 0x7FFAC9B09120
        public void get_paddingBottom(){} // RVA: 0x7FFAC9B091A0
        public void get_paddingLeft(){} // RVA: 0x7FFAC9B09220
        public void get_paddingRight(){} // RVA: 0x7FFAC9B092A0
        public void get_paddingTop(){} // RVA: 0x7FFAC9B09320
        public void get_position(){} // RVA: 0x7FFAC9B093A0
        public void get_right(){} // RVA: 0x7FFAC9B09420
        public void get_rotate(){} // RVA: 0x7FFAC9B094A0
        public void get_scale(){} // RVA: 0x7FFAC9B09530
        public void get_textOverflow(){} // RVA: 0x7FFAC9B095B0
        public void get_textShadow(){} // RVA: 0x7FFAC9B09630
        public void get_top(){} // RVA: 0x7FFAC9B096C0
        public void get_transformOrigin(){} // RVA: 0x7FFAC9B09740
        public void get_transitionDelay(){} // RVA: 0x7FFAC9B097D0
        public void get_transitionDuration(){} // RVA: 0x7FFAC9B09850
        public void get_transitionProperty(){} // RVA: 0x7FFAC9B098D0
        public void get_transitionTimingFunction(){} // RVA: 0x7FFAC9B09950
        public void get_translate(){} // RVA: 0x7FFAC9B099D0
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7FFAC9B09A60
        public void get_unityFont(){} // RVA: 0x7FFAC9B09AE0
        public void get_unityFontDefinition(){} // RVA: 0x7FFAC9B09B60
        public void get_unityFontStyleAndWeight(){} // RVA: 0x7FFAC9B09BE0
        public void get_unityOverflowClipBox(){} // RVA: 0x7FFAC9B09C60
        public void get_unityParagraphSpacing(){} // RVA: 0x7FFAC9B09CE0
        public void get_unitySliceBottom(){} // RVA: 0x7FFAC9B09D60
        public void get_unitySliceLeft(){} // RVA: 0x7FFAC9B09DE0
        public void get_unitySliceRight(){} // RVA: 0x7FFAC9B09E60
        public void get_unitySliceScale(){} // RVA: 0x7FFAC9B09EE0
        public void get_unitySliceTop(){} // RVA: 0x7FFAC9B09F60
        public void get_unityTextAlign(){} // RVA: 0x7FFAC9B09FE0
        public void get_unityTextOutlineColor(){} // RVA: 0x7FFAC9B0A060
        public void get_unityTextOutlineWidth(){} // RVA: 0x7FFAC9B0A0F0
        public void get_unityTextOverflowPosition(){} // RVA: 0x7FFAC9B0A170
        public void get_visibility(){} // RVA: 0x7FFAC9B0A1F0
        public void get_whiteSpace(){} // RVA: 0x7FFAC9B0A270
        public void get_width(){} // RVA: 0x7FFAC9B0A2F0
        public void get_wordSpacing(){} // RVA: 0x7FFAC9B0A370
    }

    public class MatchResult : ValueType
    {
        public 0x6B129DF8 success; // 0x10
        public string errorValue; // 0x18

        // ── Methods ──
        public void get_success(){} // RVA: 0x7FFAC9B21030
    }

    public class MatchResultInfo : ValueType
    {
        public bool success; // 0x10
        public 0x6B126648 triggerPseudoMask; // 0x14
        public 0x6B126648 dependencyPseudoMask; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B1BA00
    }

    public class ScalableImage : ValueType
    {
        public UnityEngine.Texture2D normalImage; // 0x10
        public UnityEngine.Texture2D highResolutionImage; // 0x18

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC9B153F0
    }

    public class SelectorMatchRecord : ValueType
    {
        public UnityEngine.UIElements.StyleSheet sheet; // 0x10
        public int styleSheetIndexInStack; // 0x18
        public UnityEngine.UIElements.StyleComplexSelector complexSelector; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B1BA10
        public void Compare(){} // RVA: 0x7FFAC9B1BA70
    }

    public class ShorthandApplicator : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue> s_TransitionDelayList;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue> s_TransitionDurationList; // 0x8
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName> s_TransitionPropertyList; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction> s_TransitionTimingFunctionList; // 0x18

        // ── Methods ──
        public void ApplyBackgroundPosition(){} // RVA: 0x7FFAC9B0A470
        public void ApplyBorderColor(){} // RVA: 0x7FFAC9B0A540
        public void ApplyBorderRadius(){} // RVA: 0x7FFAC9B0A770
        public void ApplyBorderWidth(){} // RVA: 0x7FFAC9B0A9C0
        public void ApplyFlex(){} // RVA: 0x7FFAC9B0AAE0
        public void ApplyMargin(){} // RVA: 0x7FFAC9B0ABD0
        public void ApplyPadding(){} // RVA: 0x7FFAC9B0AE40
        public void ApplyTransition(){} // RVA: 0x7FFAC9B0B0C0
        public void ApplyUnityBackgroundScaleMode(){} // RVA: 0x7FFAC9B0B350
        public void ApplyUnityTextOutline(){} // RVA: 0x7FFAC9B0B4C0
        public void CompileFlexShorthand(){} // RVA: 0x7FFAC9B0B650
        public void CompileBorderRadius(){} // RVA: 0x7FFAC9B0B8B0
        public void CompileBackgroundPosition(){} // RVA: 0x7FFAC9B0B9B0
        public void CompileUnityBackgroundScaleMode(){} // RVA: 0x7FFAC9B0C0D0
        public void CompileBoxArea(){} // RVA: 0x7FFAC9B0C570 | overloaded x3
        public void CompileTextOutline(){} // RVA: 0x7FFAC9B0C720
        public void CompileTransition(){} // RVA: 0x7FFAC9B0C840
        public void .cctor(){} // RVA: 0x7FFAC9B0D640
        public void <CompileBackgroundPosition>g__SwapKeyword|16_0(){} // RVA: 0x7FFAC9B0D920
    }

    public class StylePropertyCache : Object
    {
        public System.Collections.Generic.Dictionary`2<string,string> s_PropertySyntaxCache;
        public System.Collections.Generic.Dictionary`2<string,string> s_NonTerminalValues; // 0x8

        // ── Methods ──
        public void TryGetSyntax(){} // RVA: 0x7FFAC9B0D930
        public void TryGetNonTerminalValue(){} // RVA: 0x7FFAC9B0D9D0
        public void .cctor(){} // RVA: 0x7FFAC9B0DA70
    }

    public class StylePropertyReader : Object
    {
        public GetCursorIdFunction property;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue> propertyId; // 0x10
        public System.Collections.Generic.List`1<int> valueCount; // 0x18
        public UnityEngine.UIElements.StyleVariableResolver dpiScaling; // 0x20
        public UnityEngine.UIElements.StyleSheet m_Sheet; // 0x28
        public UnityEngine.UIElements.StyleProperty[] m_Properties; // 0x30
        public 0x6B129770[] m_PropertyIds; // 0x38
        public int m_CurrentValueIndex; // 0x40
        public int m_CurrentPropertyIndex; // 0x44
        public UnityEngine.UIElements.StyleProperty <property>k__BackingField; // 0x48
        public 0x6B129770 <propertyId>k__BackingField; // 0x50
        public int <valueCount>k__BackingField; // 0x54
        public float <dpiScaling>k__BackingField; // 0x58

        // ── Methods ──
        public void get_property(){} // RVA: 0x7FFAC2F9C730
        public void set_property(){} // RVA: 0x7FFAC2F9C740
        public void get_propertyId(){} // RVA: 0x7FFAC30F10E0
        public void set_propertyId(){} // RVA: 0x7FFAC31D9010
        public void get_valueCount(){} // RVA: 0x7FFAC38913D0
        public void set_valueCount(){} // RVA: 0x7FFAC3890750
        public void get_dpiScaling(){} // RVA: 0x7FFAC2F49FE0
        public void set_dpiScaling(){} // RVA: 0x7FFAC2F49FF0
        public void SetContext(){} // RVA: 0x7FFAC9B158A0
        public void SetInlineContext(){} // RVA: 0x7FFAC9B15AB0
        public void MoveNextProperty(){} // RVA: 0x7FFAC9B15BD0
        public void GetValue(){} // RVA: 0x7FFAC9B15C00
        public void GetValueType(){} // RVA: 0x7FFAC9B15CA0
        public void IsValueType(){} // RVA: 0x7FFAC9B15D20
        public void IsKeyword(){} // RVA: 0x7FFAC9B15DB0
        public void ReadAsString(){} // RVA: 0x7FFAC9B15E70
        public void ReadLength(){} // RVA: 0x7FFAC9B15F10
        public void ReadTimeValue(){} // RVA: 0x7FFAC9B16060
        public void ReadTranslate(){} // RVA: 0x7FFAC9B19E90 | overloaded x2
        public void ReadTransformOrigin(){} // RVA: 0x7FFAC9B19B00 | overloaded x2
        public void ReadRotate(){} // RVA: 0x7FFAC9B1A440 | overloaded x2
        public void ReadScale(){} // RVA: 0x7FFAC9B1A200 | overloaded x2
        public void ReadFloat(){} // RVA: 0x7FFAC9B16A80
        public void ReadInt(){} // RVA: 0x7FFAC9B16B20
        public void ReadColor(){} // RVA: 0x7FFAC9B16BC0
        public void ReadEnum(){} // RVA: 0x7FFAC9B1A6A0 | overloaded x2
        public void ReadFontDefinition(){} // RVA: 0x7FFAC9B16E90
        public void ReadFont(){} // RVA: 0x7FFAC9B17720
        public void ReadBackground(){} // RVA: 0x7FFAC9B17AC0
        public void ReadCursor(){} // RVA: 0x7FFAC9B17F40
        public void ReadTextShadow(){} // RVA: 0x7FFAC9B18440
        public void ReadBackgroundPositionX(){} // RVA: 0x7FFAC9B189A0
        public void ReadBackgroundPositionY(){} // RVA: 0x7FFAC9B189E0
        public void ReadBackgroundPosition(){} // RVA: 0x7FFAC9B1A810 | overloaded x2
        public void ReadBackgroundRepeat(){} // RVA: 0x7FFAC9B1AA70 | overloaded x2
        public void ReadBackgroundSize(){} // RVA: 0x7FFAC9B1ABF0 | overloaded x2
        public void ReadListEasingFunction(){} // RVA: 0x7FFAC9B18EB0
        public void ReadListTimeValue(){} // RVA: 0x7FFAC9B19100
        public void ReadListStylePropertyName(){} // RVA: 0x7FFAC9B192D0
        public void LoadProperties(){} // RVA: 0x7FFAC9B19510
        public void SetCurrentProperty(){} // RVA: 0x7FFAC9B19980
        public void ReadTransformOriginEnum(){} // RVA: 0x7FFAC9B19CB0
        public void TryReadEnum(){} // RVA: 0x7FFAC9B1A5F0
        public void ReadAngle(){} // RVA: 0x7FFAC9B1A750
        public void TryGetImageSourceFromValue(){} // RVA: 0x7FFAC9B1AEC0
        public void .ctor(){} // RVA: 0x7FFAC9B1B6A0
    }

    public class StylePropertyUtil : Object
    {
        public System.Collections.Generic.Dictionary`2<string,0x6B129770> s_NameToId;
        public System.Collections.Generic.Dictionary`2<0x6B129770,string> s_IdToName; // 0x8
        public System.Collections.Generic.HashSet`1<0x6B129770> s_AnimatableProperties; // 0x10
        public System.Collections.Generic.Dictionary`2<0x6B129770,0x6B11FF80> s_AnimatableWithUsageHintProperties; // 0x18

        // ── Methods ──
        public void TryGetEnumIntValue(){} // RVA: 0x7FFAC9B0FAD0
        public void IsMatchingShorthand(){} // RVA: 0x7FFAC9B10F30
        public void IsAnimatable(){} // RVA: 0x7FFAC9B11090
        public void .cctor(){} // RVA: 0x7FFAC9B11120
    }

    public class StylePropertyValue : ValueType
    {
        public UnityEngine.UIElements.StyleSheet sheet; // 0x10
        public UnityEngine.UIElements.StyleValueHandle handle; // 0x18
    }

    public class StylePropertyValueMatcher : BaseStyleMatcher
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue> current; // 0x20

        // ── Methods ──
        public void get_current(){} // RVA: 0x7FFAC9B223A0
        public void get_valueCount(){} // RVA: 0x7FFAC9B22460
        public void get_isCurrentVariable(){} // RVA: 0x7FFAC2F21320
        public void get_isCurrentComma(){} // RVA: 0x7FFAC9B224B0
        public void Match(){} // RVA: 0x7FFAC9B22570
        public void MatchKeyword(){} // RVA: 0x7FFAC9B22880
        public void MatchNumber(){} // RVA: 0x7FFAC9B22950
        public void MatchInteger(){} // RVA: 0x7FFAC9B22950
        public void MatchLength(){} // RVA: 0x7FFAC9B22970
        public void MatchPercentage(){} // RVA: 0x7FFAC9B229F0
        public void MatchColor(){} // RVA: 0x7FFAC9B22A70
        public void MatchResource(){} // RVA: 0x7FFAC9B22B30
        public void MatchUrl(){} // RVA: 0x7FFAC9B22B50
        public void MatchTime(){} // RVA: 0x7FFAC9B22B90
        public void MatchCustomIdent(){} // RVA: 0x7FFAC9B22C00
        public void MatchAngle(){} // RVA: 0x7FFAC9B22D50
        public void .ctor(){} // RVA: 0x7FFAC9B22DD0
    }

    public class StyleSelectorHelper : Object
    {
        // ── Methods ──
        public void MatchesSelector(){} // RVA: 0x7FFAC9B1BB70
        public void MatchRightToLeft(){} // RVA: 0x7FFAC9B1BE70
        public void FastLookup(){} // RVA: 0x7FFAC9B1C010
        public void FindMatches(){} // RVA: 0x7FFAC9B1C3B0
    }

    public class StyleSheetCache : Object
    {
        public SheetHandleKeyComparer s_Comparer;
        public System.Collections.Generic.Dictionary`2<SheetHandleKey,0x6B129770[]> s_RulePropertyIdsCache; // 0x8

        // ── Methods ──
        public void GetPropertyIds(){} // RVA: 0x7FFAC9B1CC00 | overloaded x2
        public void GetPropertyId(){} // RVA: 0x7FFAC9B1CCD0
        public void .cctor(){} // RVA: 0x7FFAC9B1CDF0
    }

    public class StyleSheetColor : Object
    {
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Color32> s_NameToColor;

        // ── Methods ──
        public void TryGetColor(){} // RVA: 0x7FFAC9B1D050
        public void HexToColor32(){} // RVA: 0x7FFAC9B1D1B0
        public void .cctor(){} // RVA: 0x7FFAC9B1D1D0
    }

    public class StyleSheetExtensions : Object
    {
        // ── Methods ──
        public void ReadAsString(){} // RVA: 0x7FFAC9B20C30
        public void IsVarFunction(){} // RVA: 0x7FFAC9B21010
    }

    public class StyleValue : ValueType
    {
        public 0x6B129770 id; // 0x10
        public 0x6B122448 keyword; // 0x14
        public float number; // 0x18
        public UnityEngine.UIElements.Length length; // 0x18
        public UnityEngine.Color color; // 0x18
        public System.Runtime.InteropServices.GCHandle resource; // 0x18
        public UnityEngine.UIElements.BackgroundPosition position; // 0x18
        public UnityEngine.UIElements.BackgroundRepeat repeat; // 0x18
    }

    public class StyleValueManaged : ValueType
    {
        public 0x6B129770 id; // 0x10
        public 0x6B122448 keyword; // 0x14
        public object value; // 0x18
    }

}