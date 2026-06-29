// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.StyleSheets
// Classes: 23
// Methods: 316

namespace ThirdParty.Unity.UnityEngine.UIElements.StyleSheets
{
    public class BaseStyleMatcher : Object
    {
        // ── Methods ──
        public void MatchKeyword(){} // RVA: 0x7A7E019D0
        public void MatchNumber(){} // RVA: 0x7A7E01900
        public void MatchInteger(){} // RVA: 0x7A7E01900
        public void MatchLength(){} // RVA: 0x7A7E01900
        public void MatchPercentage(){} // RVA: 0x7A7E01900
        public void MatchColor(){} // RVA: 0x7A7E01900
        public void MatchResource(){} // RVA: 0x7A7E01900
        public void MatchUrl(){} // RVA: 0x7A7E01900
        public void MatchTime(){} // RVA: 0x7A7E01900
        public void MatchAngle(){} // RVA: 0x7A7E01900
        public void MatchCustomIdent(){} // RVA: 0x7A7E01900
        public void get_valueCount(){} // RVA: 0x7A7E00710
        public void get_isCurrentVariable(){} // RVA: 0x7A7E01900
        public void get_isCurrentComma(){} // RVA: 0x7A7E01900
        public void get_hasCurrent(){} // RVA: 0x7AF168B60
        public void get_currentIndex(){} // RVA: 0x7A83782A0
        public void set_currentIndex(){} // RVA: 0x7A84385B0
        public void get_matchedVariableCount(){} // RVA: 0x7A9739200
        public void set_matchedVariableCount(){} // RVA: 0x7A9746990
        public void Initialize(){} // RVA: 0x7AF168B90
        public void MoveNext(){} // RVA: 0x7AF168BE0
        public void SaveContext(){} // RVA: 0x7AF168C20
        public void RestoreContext(){} // RVA: 0x7AF168CB0
        public void DropContext(){} // RVA: 0x7AF168D00
        public void Match(){} // RVA: 0x7AF168D50
        public void MatchExpression(){} // RVA: 0x7AF168EF0
        public void MatchExpressionWithMultiplier(){} // RVA: 0x7AF169140
        public void MatchGroup(){} // RVA: 0x7AF169260
        public void MatchCombinator(){} // RVA: 0x7AF169320
        public void MatchOr(){} // RVA: 0x7AF169670
        public void MatchOrOr(){} // RVA: 0x7AF1697E0
        public void MatchAndAnd(){} // RVA: 0x7AF169800
        public void MatchMany(){} // RVA: 0x7AF169840
        public void MatchManyByOrder(){} // RVA: 0x7AF169A40
        public void MatchJuxtaposition(){} // RVA: 0x7AF169BB0
        public void MatchDataType(){} // RVA: 0x7AF169C30
        public void .ctor(){} // RVA: 0x7AF169DB0
        public void .cctor(){} // RVA: 0x7AF169F30
    }

    public class Dimension : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EFFF00
        public void ToLength(){} // RVA: 0x7A7EFFF10
        public void ToTime(){} // RVA: 0x7A7EFFF50
        public void ToAngle(){} // RVA: 0x7A7EFFF70
        public void op_Equality(){} // RVA: 0x7AF15DD10
        public void Equals(){} // RVA: 0x7A7F00000
        public void GetHashCode(){} // RVA: 0x7A7F00010
        public void ToString(){} // RVA: 0x7A7F00040
    }

    public class Dimension[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D0370
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2A50
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA27F280
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class HierarchyTraversal : Object
    {
        // ── Methods ──
        public void Traverse(){} // RVA: 0x7AF14F320
        public void TraverseRecursive(){} // RVA: 0x7A7E1D590
        public void Recurse(){} // RVA: 0x7AF14F340
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ImageSource : ValueType
    {
        // ── Methods ──
        public void IsNull(){} // RVA: 0x7A7F000C0
    }

    public class InitialStyle : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7AF14F4B0
        public void Acquire(){} // RVA: 0x7AF14F500
        public void .cctor(){} // RVA: 0x7AF14F5C0
        public void get_alignContent(){} // RVA: 0x7AF150820
        public void get_alignItems(){} // RVA: 0x7AF1508A0
        public void get_alignSelf(){} // RVA: 0x7AF150920
        public void get_backgroundColor(){} // RVA: 0x7AF1509A0
        public void get_backgroundImage(){} // RVA: 0x7AF150A20
        public void get_backgroundPositionX(){} // RVA: 0x7AF150AB0
        public void get_backgroundPositionY(){} // RVA: 0x7AF150B40
        public void get_backgroundRepeat(){} // RVA: 0x7AF150BD0
        public void get_backgroundSize(){} // RVA: 0x7AF150C50
        public void get_borderBottomColor(){} // RVA: 0x7AF150CE0
        public void get_borderBottomLeftRadius(){} // RVA: 0x7AF150D60
        public void get_borderBottomRightRadius(){} // RVA: 0x7AF150DE0
        public void get_borderBottomWidth(){} // RVA: 0x7AF150E60
        public void get_borderLeftColor(){} // RVA: 0x7AF150EE0
        public void get_borderLeftWidth(){} // RVA: 0x7AF150F70
        public void get_borderRightColor(){} // RVA: 0x7AF150FF0
        public void get_borderRightWidth(){} // RVA: 0x7AF151080
        public void get_borderTopColor(){} // RVA: 0x7AF151100
        public void get_borderTopLeftRadius(){} // RVA: 0x7AF151190
        public void get_borderTopRightRadius(){} // RVA: 0x7AF151210
        public void get_borderTopWidth(){} // RVA: 0x7AF151290
        public void get_bottom(){} // RVA: 0x7AF151310
        public void get_color(){} // RVA: 0x7AF151390
        public void get_cursor(){} // RVA: 0x7AF151410
        public void get_display(){} // RVA: 0x7AF1514A0
        public void get_flexBasis(){} // RVA: 0x7AF151520
        public void get_flexDirection(){} // RVA: 0x7AF1515A0
        public void get_flexGrow(){} // RVA: 0x7AF151620
        public void get_flexShrink(){} // RVA: 0x7AF1516A0
        public void get_flexWrap(){} // RVA: 0x7AF151720
        public void get_fontSize(){} // RVA: 0x7AF1517A0
        public void get_height(){} // RVA: 0x7AF151820
        public void get_justifyContent(){} // RVA: 0x7AF1518A0
        public void get_left(){} // RVA: 0x7AF151920
        public void get_letterSpacing(){} // RVA: 0x7AF1519A0
        public void get_marginBottom(){} // RVA: 0x7AF151A20
        public void get_marginLeft(){} // RVA: 0x7AF151AA0
        public void get_marginRight(){} // RVA: 0x7AF151B20
        public void get_marginTop(){} // RVA: 0x7AF151BA0
        public void get_maxHeight(){} // RVA: 0x7AF151C20
        public void get_maxWidth(){} // RVA: 0x7AF151CA0
        public void get_minHeight(){} // RVA: 0x7AF151D20
        public void get_minWidth(){} // RVA: 0x7AF151DA0
        public void get_opacity(){} // RVA: 0x7AF151E20
        public void get_overflow(){} // RVA: 0x7AF151EA0
        public void get_paddingBottom(){} // RVA: 0x7AF151F20
        public void get_paddingLeft(){} // RVA: 0x7AF151FA0
        public void get_paddingRight(){} // RVA: 0x7AF152020
        public void get_paddingTop(){} // RVA: 0x7AF1520A0
        public void get_position(){} // RVA: 0x7AF152120
        public void get_right(){} // RVA: 0x7AF1521A0
        public void get_rotate(){} // RVA: 0x7AF152220
        public void get_scale(){} // RVA: 0x7AF1522B0
        public void get_textOverflow(){} // RVA: 0x7AF152330
        public void get_textShadow(){} // RVA: 0x7AF1523B0
        public void get_top(){} // RVA: 0x7AF152440
        public void get_transformOrigin(){} // RVA: 0x7AF1524C0
        public void get_transitionDelay(){} // RVA: 0x7AF152550
        public void get_transitionDuration(){} // RVA: 0x7AF1525D0
        public void get_transitionProperty(){} // RVA: 0x7AF152650
        public void get_transitionTimingFunction(){} // RVA: 0x7AF1526D0
        public void get_translate(){} // RVA: 0x7AF152750
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7AF1527E0
        public void get_unityFont(){} // RVA: 0x7AF152860
        public void get_unityFontDefinition(){} // RVA: 0x7AF1528E0
        public void get_unityFontStyleAndWeight(){} // RVA: 0x7AF152960
        public void get_unityOverflowClipBox(){} // RVA: 0x7AF1529E0
        public void get_unityParagraphSpacing(){} // RVA: 0x7AF152A60
        public void get_unitySliceBottom(){} // RVA: 0x7AF152AE0
        public void get_unitySliceLeft(){} // RVA: 0x7AF152B60
        public void get_unitySliceRight(){} // RVA: 0x7AF152BE0
        public void get_unitySliceScale(){} // RVA: 0x7AF152C60
        public void get_unitySliceTop(){} // RVA: 0x7AF152CE0
        public void get_unityTextAlign(){} // RVA: 0x7AF152D60
        public void get_unityTextOutlineColor(){} // RVA: 0x7AF152DE0
        public void get_unityTextOutlineWidth(){} // RVA: 0x7AF152E70
        public void get_unityTextOverflowPosition(){} // RVA: 0x7AF152EF0
        public void get_visibility(){} // RVA: 0x7AF152F70
        public void get_whiteSpace(){} // RVA: 0x7AF152FF0
        public void get_width(){} // RVA: 0x7AF153070
        public void get_wordSpacing(){} // RVA: 0x7AF1530F0
    }

    public class MatchResult : ValueType
    {
        // ── Methods ──
        public void get_success(){} // RVA: 0x7A7F00590
    }

    public class MatchResultInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F00150
    }

    public class ScalableImage : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7A7F00070
    }

    public class ScalableImage[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SelectorMatchRecord : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F00180
        public void Compare(){} // RVA: 0x7AF164530
    }

    public class ShorthandApplicator : Object
    {
        // ── Methods ──
        public void ApplyBackgroundPosition(){} // RVA: 0x7AF1531F0
        public void ApplyBorderColor(){} // RVA: 0x7AF1532C0
        public void ApplyBorderRadius(){} // RVA: 0x7AF1534F0
        public void ApplyBorderWidth(){} // RVA: 0x7AF1536A0
        public void ApplyFlex(){} // RVA: 0x7AF153900
        public void ApplyMargin(){} // RVA: 0x7AF1539F0
        public void ApplyPadding(){} // RVA: 0x7AF153BF0
        public void ApplyTransition(){} // RVA: 0x7AF153DF0
        public void ApplyUnityBackgroundScaleMode(){} // RVA: 0x7AF154080
        public void ApplyUnityTextOutline(){} // RVA: 0x7AF1541D0
        public void CompileFlexShorthand(){} // RVA: 0x7AF154360
        public void CompileBorderRadius(){} // RVA: 0x7AF1545C0
        public void CompileBackgroundPosition(){} // RVA: 0x7AF1546C0
        public void CompileUnityBackgroundScaleMode(){} // RVA: 0x7AF154DD0
        public void CompileBoxArea(){} // RVA: 0x7AF1551F0
        public void CompileTextOutline(){} // RVA: 0x7AF1553A0
        public void CompileTransition(){} // RVA: 0x7AF1554C0
        public void .cctor(){} // RVA: 0x7AF1562C0
        public void <CompileBackgroundPosition>g__SwapKeyword|16_0(){} // RVA: 0x7AF1565A0
    }

    public class StylePropertyCache : Object
    {
        // ── Methods ──
        public void TryGetSyntax(){} // RVA: 0x7AF1565B0
        public void TryGetNonTerminalValue(){} // RVA: 0x7AF156650
        public void .cctor(){} // RVA: 0x7AF1566F0
    }

    public class StylePropertyId[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D3F10
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA281BF0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class StylePropertyReader : Object
    {
        // ── Methods ──
        public void get_property(){} // RVA: 0x7A8152D80
        public void set_property(){} // RVA: 0x7A8152D90
        public void get_propertyId(){} // RVA: 0x7A8355950
        public void set_propertyId(){} // RVA: 0x7A83F4180
        public void get_valueCount(){} // RVA: 0x7A8A22410
        public void set_valueCount(){} // RVA: 0x7A8A25530
        public void get_dpiScaling(){} // RVA: 0x7A8100220
        public void set_dpiScaling(){} // RVA: 0x7A8100230
        public void SetContext(){} // RVA: 0x7AF15E520
        public void SetInlineContext(){} // RVA: 0x7AF15E730
        public void MoveNextProperty(){} // RVA: 0x7AF15E850
        public void GetValue(){} // RVA: 0x7AF15E880
        public void GetValueType(){} // RVA: 0x7AF15E920
        public void IsValueType(){} // RVA: 0x7AF15E9A0
        public void IsKeyword(){} // RVA: 0x7AF15EA30
        public void ReadAsString(){} // RVA: 0x7AF15EAF0
        public void ReadLength(){} // RVA: 0x7AF15EB90
        public void ReadTimeValue(){} // RVA: 0x7AF15ECF0
        public void ReadTranslate(){} // RVA: 0x7AF162970
        public void ReadTransformOrigin(){} // RVA: 0x7AF162620
        public void ReadRotate(){} // RVA: 0x7AF162F10
        public void ReadScale(){} // RVA: 0x7AF162CD0
        public void ReadFloat(){} // RVA: 0x7AF15F610
        public void ReadInt(){} // RVA: 0x7AF15F6B0
        public void ReadColor(){} // RVA: 0x7AF15F750
        public void ReadEnum(){} // RVA: 0x7AF163170
        public void ReadFontDefinition(){} // RVA: 0x7AF15FA10
        public void ReadFont(){} // RVA: 0x7AF160290
        public void ReadBackground(){} // RVA: 0x7AF160630
        public void ReadCursor(){} // RVA: 0x7AF160AB0
        public void ReadTextShadow(){} // RVA: 0x7AF160FA0
        public void ReadBackgroundPositionX(){} // RVA: 0x7AF1614D0
        public void ReadBackgroundPositionY(){} // RVA: 0x7AF161510
        public void ReadBackgroundPosition(){} // RVA: 0x7AF1632F0
        public void ReadBackgroundRepeat(){} // RVA: 0x7AF163540
        public void ReadBackgroundSize(){} // RVA: 0x7AF1636C0
        public void ReadListEasingFunction(){} // RVA: 0x7AF1619C0
        public void ReadListTimeValue(){} // RVA: 0x7AF161C10
        public void ReadListStylePropertyName(){} // RVA: 0x7AF161DC0
        public void LoadProperties(){} // RVA: 0x7AF162000
        public void SetCurrentProperty(){} // RVA: 0x7AF1624A0
        public void ReadTransformOriginEnum(){} // RVA: 0x7AF162790
        public void TryReadEnum(){} // RVA: 0x7AF1630C0
        public void ReadAngle(){} // RVA: 0x7AF163220
        public void TryGetImageSourceFromValue(){} // RVA: 0x7AF163990
        public void .ctor(){} // RVA: 0x7AF164170
    }

    public class StylePropertyUtil : Object
    {
        // ── Methods ──
        public void TryGetEnumIntValue(){} // RVA: 0x7AF158750
        public void IsMatchingShorthand(){} // RVA: 0x7AF159BB0
        public void IsAnimatable(){} // RVA: 0x7AF159D10
        public void .cctor(){} // RVA: 0x7AF159DA0
    }

    public class StylePropertyValueMatcher : BaseStyleMatcher
    {
        // ── Methods ──
        public void get_current(){} // RVA: 0x7AF16A010
        public void get_valueCount(){} // RVA: 0x7AF16A0D0
        public void get_isCurrentVariable(){} // RVA: 0x7A80D7320
        public void get_isCurrentComma(){} // RVA: 0x7AF16A120
        public void Match(){} // RVA: 0x7AF16A1E0
        public void MatchKeyword(){} // RVA: 0x7AF16A4F0
        public void MatchNumber(){} // RVA: 0x7AF16A5C0
        public void MatchInteger(){} // RVA: 0x7AF16A5C0
        public void MatchLength(){} // RVA: 0x7AF16A5E0
        public void MatchPercentage(){} // RVA: 0x7AF16A660
        public void MatchColor(){} // RVA: 0x7AF16A6E0
        public void MatchResource(){} // RVA: 0x7AF16A7A0
        public void MatchUrl(){} // RVA: 0x7AF16A7C0
        public void MatchTime(){} // RVA: 0x7AF16A800
        public void MatchCustomIdent(){} // RVA: 0x7AF16A870
        public void MatchAngle(){} // RVA: 0x7AF16A9C0
        public void .ctor(){} // RVA: 0x7AF16AA40
    }

    public class StyleSelectorHelper : Object
    {
        // ── Methods ──
        public void MatchesSelector(){} // RVA: 0x7AF164650
        public void MatchRightToLeft(){} // RVA: 0x7AF1649C0
        public void FastLookup(){} // RVA: 0x7AF164B80
        public void FindMatches(){} // RVA: 0x7AF164F70
    }

    public class StyleSheetCache : Object
    {
        // ── Methods ──
        public void GetPropertyIds(){} // RVA: 0x7AF1657D0
        public void GetPropertyId(){} // RVA: 0x7AF1658B0
        public void .cctor(){} // RVA: 0x7AF1659D0
    }

    public class StyleSheetColor : Object
    {
        // ── Methods ──
        public void TryGetColor(){} // RVA: 0x7AF165C30
        public void HexToColor32(){} // RVA: 0x7AF165D90
        public void .cctor(){} // RVA: 0x7AF165DB0
    }

    public class StyleSheetExtensions : Object
    {
        // ── Methods ──
        public void ReadAsString(){} // RVA: 0x7AF168750
        public void IsVarFunction(){} // RVA: 0x7AF168B30
    }

    public class StyleValueManaged[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class StyleValue[] : Array
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