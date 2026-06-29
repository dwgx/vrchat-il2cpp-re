// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.StyleSheets
// Classes: 23
// Methods: 320

namespace ThirdParty.Unity.UnityEngine.UIElements.StyleSheets
{
    public class BaseStyleMatcher : Object
    {
        public object s_CustomIdentRegex;
        public object m_ContextStack;
        public object m_CurrentContext;

        // ── Methods ──
        public void MatchKeyword(){} // RVA: 0x87D350
        public void MatchNumber(){} // RVA: 0x87D280
        public void MatchInteger(){} // RVA: 0x87D280
        public void MatchLength(){} // RVA: 0x87D280
        public void MatchPercentage(){} // RVA: 0x87D280
        public void MatchColor(){} // RVA: 0x87D280
        public void MatchResource(){} // RVA: 0x87D280
        public void MatchUrl(){} // RVA: 0x87D280
        public void MatchTime(){} // RVA: 0x87D280
        public void MatchAngle(){} // RVA: 0x87D280
        public void MatchCustomIdent(){} // RVA: 0x87D280
        public void get_valueCount(){} // RVA: 0x87C130
        public void get_isCurrentVariable(){} // RVA: 0x87D280
        public void get_isCurrentComma(){} // RVA: 0x87D280
        public void get_hasCurrent(){} // RVA: 0x7FA3870
        public void get_currentIndex(){} // RVA: 0xE62D00
        public void set_currentIndex(){} // RVA: 0x1033F40
        public void get_matchedVariableCount(){} // RVA: 0x2244FB0
        public void set_matchedVariableCount(){} // RVA: 0x22735B0
        public void Initialize(){} // RVA: 0x7FA38A0
        public void MoveNext(){} // RVA: 0x7FA38F0
        public void SaveContext(){} // RVA: 0x7FA3930
        public void RestoreContext(){} // RVA: 0x7FA39C0
        public void DropContext(){} // RVA: 0x7FA3A10
        public void Match(){} // RVA: 0x7FA3A60
        public void MatchExpression(){} // RVA: 0x7FA3C00
        public void MatchExpressionWithMultiplier(){} // RVA: 0x7FA3E50
        public void MatchGroup(){} // RVA: 0x7FA3F70
        public void MatchCombinator(){} // RVA: 0x7FA4030
        public void MatchOr(){} // RVA: 0x7FA4380
        public void MatchOrOr(){} // RVA: 0x7FA44F0
        public void MatchAndAnd(){} // RVA: 0x7FA4510
        public void MatchMany(){} // RVA: 0x7FA4550
        public void MatchManyByOrder(){} // RVA: 0x7FA4750
        public void MatchJuxtaposition(){} // RVA: 0x7FA48C0
        public void MatchDataType(){} // RVA: 0x7FA4940
        public void .ctor(){} // RVA: 0x7FA4AC0
        public void .cctor(){} // RVA: 0x7FA4C40
    }

    public class Dimension : ValueType
    {
        public object unit;
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A0C20
        public void ToLength(){} // RVA: 0x9A0C30
        public void ToTime(){} // RVA: 0x9A0C70
        public void ToAngle(){} // RVA: 0x9A0C90
        public void op_Equality(){} // RVA: 0x7F98230
        public void Equals(){} // RVA: 0x9A0D20
        public void GetHashCode(){} // RVA: 0x9A0D30
        public void ToString(){} // RVA: 0x9A0D60
    }

    public class Dimension[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAE630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3CA0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E58FD0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class HierarchyTraversal : Object
    {
        // ── Methods ──
        public void Traverse(){} // RVA: 0x7F14C00
        public void TraverseRecursive(){} // RVA: 0x899290
        public void Recurse(){} // RVA: 0x7F86D60
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ImageSource : ValueType
    {
        public object texture;
        public object sprite;
        public object vectorImage;
        public object renderTexture;

        // ── Methods ──
        public void IsNull(){} // RVA: 0x9A0FC0
    }

    public class InitialStyle : Object
    {
        public object s_InitialStyle;

        // ── Methods ──
        public void Get(){} // RVA: 0x7F86ED0
        public void Acquire(){} // RVA: 0x7F86F20
        public void .cctor(){} // RVA: 0x7F86FD0
        public void get_alignContent(){} // RVA: 0x7F88290
        public void get_alignItems(){} // RVA: 0x7F88310
        public void get_alignSelf(){} // RVA: 0x7F88390
        public void get_backgroundColor(){} // RVA: 0x7F88410
        public void get_backgroundImage(){} // RVA: 0x7F88490
        public void get_backgroundPositionX(){} // RVA: 0x7F88520
        public void get_backgroundPositionY(){} // RVA: 0x7F885B0
        public void get_backgroundRepeat(){} // RVA: 0x7F88640
        public void get_backgroundSize(){} // RVA: 0x7F886C0
        public void get_borderBottomColor(){} // RVA: 0x7F88750
        public void get_borderBottomLeftRadius(){} // RVA: 0x7F887D0
        public void get_borderBottomRightRadius(){} // RVA: 0x7F88850
        public void get_borderBottomWidth(){} // RVA: 0x7F888D0
        public void get_borderLeftColor(){} // RVA: 0x7F88950
        public void get_borderLeftWidth(){} // RVA: 0x7F889E0
        public void get_borderRightColor(){} // RVA: 0x7F88A60
        public void get_borderRightWidth(){} // RVA: 0x7F88AF0
        public void get_borderTopColor(){} // RVA: 0x7F88B70
        public void get_borderTopLeftRadius(){} // RVA: 0x7F88C00
        public void get_borderTopRightRadius(){} // RVA: 0x7F88C80
        public void get_borderTopWidth(){} // RVA: 0x7F88D00
        public void get_bottom(){} // RVA: 0x7F88D80
        public void get_color(){} // RVA: 0x7F88E00
        public void get_cursor(){} // RVA: 0x7F88E80
        public void get_display(){} // RVA: 0x7F88F10
        public void get_flexBasis(){} // RVA: 0x7F88F90
        public void get_flexDirection(){} // RVA: 0x7F89010
        public void get_flexGrow(){} // RVA: 0x7F89090
        public void get_flexShrink(){} // RVA: 0x7F89110
        public void get_flexWrap(){} // RVA: 0x7F89190
        public void get_fontSize(){} // RVA: 0x7F89210
        public void get_height(){} // RVA: 0x7F89290
        public void get_justifyContent(){} // RVA: 0x7F89310
        public void get_left(){} // RVA: 0x7F89390
        public void get_letterSpacing(){} // RVA: 0x7F89410
        public void get_marginBottom(){} // RVA: 0x7F89490
        public void get_marginLeft(){} // RVA: 0x7F89510
        public void get_marginRight(){} // RVA: 0x7F89590
        public void get_marginTop(){} // RVA: 0x7F89610
        public void get_maxHeight(){} // RVA: 0x7F89690
        public void get_maxWidth(){} // RVA: 0x7F89710
        public void get_minHeight(){} // RVA: 0x7F89790
        public void get_minWidth(){} // RVA: 0x7F89810
        public void get_opacity(){} // RVA: 0x7F89890
        public void get_overflow(){} // RVA: 0x7F89910
        public void get_paddingBottom(){} // RVA: 0x7F89990
        public void get_paddingLeft(){} // RVA: 0x7F89A10
        public void get_paddingRight(){} // RVA: 0x7F89A90
        public void get_paddingTop(){} // RVA: 0x7F89B10
        public void get_position(){} // RVA: 0x7F89B90
        public void get_right(){} // RVA: 0x7F89C10
        public void get_rotate(){} // RVA: 0x7F89C90
        public void get_scale(){} // RVA: 0x7F89D20
        public void get_textOverflow(){} // RVA: 0x7F89DA0
        public void get_textShadow(){} // RVA: 0x7F89E20
        public void get_top(){} // RVA: 0x7F89EB0
        public void get_transformOrigin(){} // RVA: 0x7F89F30
        public void get_transitionDelay(){} // RVA: 0x7F89FC0
        public void get_transitionDuration(){} // RVA: 0x7F8A040
        public void get_transitionProperty(){} // RVA: 0x7F8A0C0
        public void get_transitionTimingFunction(){} // RVA: 0x7F8A140
        public void get_translate(){} // RVA: 0x7F8A1C0
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7F8A250
        public void get_unityEditorTextRenderingMode(){} // RVA: 0x7F8A2D0
        public void get_unityFont(){} // RVA: 0x7F8A350
        public void get_unityFontDefinition(){} // RVA: 0x7F8A3D0
        public void get_unityFontStyleAndWeight(){} // RVA: 0x7F8A450
        public void get_unityOverflowClipBox(){} // RVA: 0x7F8A4D0
        public void get_unityParagraphSpacing(){} // RVA: 0x7F8A550
        public void get_unitySliceBottom(){} // RVA: 0x7F8A5D0
        public void get_unitySliceLeft(){} // RVA: 0x7F8A650
        public void get_unitySliceRight(){} // RVA: 0x7F8A6D0
        public void get_unitySliceScale(){} // RVA: 0x7F8A750
        public void get_unitySliceTop(){} // RVA: 0x7F8A7D0
        public void get_unitySliceType(){} // RVA: 0x7F8A850
        public void get_unityTextAlign(){} // RVA: 0x7F8A8D0
        public void get_unityTextGenerator(){} // RVA: 0x7F8A950
        public void get_unityTextOutlineColor(){} // RVA: 0x7F8A9D0
        public void get_unityTextOutlineWidth(){} // RVA: 0x7F8AA60
        public void get_unityTextOverflowPosition(){} // RVA: 0x7F8AAE0
        public void get_visibility(){} // RVA: 0x7F8AB60
        public void get_whiteSpace(){} // RVA: 0x7F8ABE0
        public void get_width(){} // RVA: 0x7F8AC60
        public void get_wordSpacing(){} // RVA: 0x7F8ACE0
    }

    public class MatchResult : ValueType
    {
        public object errorCode;
        public object errorValue;

        // ── Methods ──
        public void get_success(){} // RVA: 0x9A1330
    }

    public class MatchResultInfo : ValueType
    {
        public object success;
        public object triggerPseudoMask;
        public object dependencyPseudoMask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A1050
    }

    public class ScalableImage : ValueType
    {
        public object normalImage;
        public object highResolutionImage;

        // ── Methods ──
        public void ToString(){} // RVA: 0x9A0E30
    }

    public class ScalableImage[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SelectorMatchRecord : ValueType
    {
        public object sheet;
        public object styleSheetIndexInStack;
        public object complexSelector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A1120
        public void Compare(){} // RVA: 0x7F9EC00
    }

    public class ShorthandApplicator : Object
    {
        public object s_TransitionDelayList;
        public object s_TransitionDurationList;
        public object s_TransitionPropertyList;
        public object s_TransitionTimingFunctionList;

        // ── Methods ──
        public void ApplyBackgroundPosition(){} // RVA: 0x7F8AD60
        public void ApplyBorderColor(){} // RVA: 0x7F8AE30
        public void ApplyBorderRadius(){} // RVA: 0x7F8B060
        public void ApplyBorderWidth(){} // RVA: 0x7F8B210
        public void ApplyFlex(){} // RVA: 0x7F8B470
        public void ApplyMargin(){} // RVA: 0x7F8B560
        public void ApplyPadding(){} // RVA: 0x7F8B760
        public void ApplyTransition(){} // RVA: 0x7F8B960
        public void ApplyUnityBackgroundScaleMode(){} // RVA: 0x7F8BBF0
        public void ApplyUnityTextOutline(){} // RVA: 0x7F8BD40
        public void CompileFlexShorthand(){} // RVA: 0x7F8BED0
        public void CompileBorderRadius(){} // RVA: 0x7F8C130
        public void CompileBackgroundPosition(){} // RVA: 0x7F8C230
        public void CompileUnityBackgroundScaleMode(){} // RVA: 0x7F8C930
        public void CompileBoxArea(){} // RVA: 0x7F8CD50
        public void CompileTextOutline(){} // RVA: 0x7F8CF00
        public void CompileTransition(){} // RVA: 0x7F8D020
        public void .cctor(){} // RVA: 0x7F8DE20
        public void <CompileBackgroundPosition>g__SwapKeyword|16_0(){} // RVA: 0x7F8E100
    }

    public class StylePropertyCache : Object
    {
        public object s_PropertySyntaxCache;
        public object s_NonTerminalValues;

        // ── Methods ──
        public void TryGetSyntax(){} // RVA: 0x7F8E110
        public void TryGetNonTerminalValue(){} // RVA: 0x7F8E1B0
        public void .cctor(){} // RVA: 0x7F8E250
    }

    public class StylePropertyId[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class StylePropertyReader : Object
    {
        public object getCursorIdFunc;
        public object m_Values;
        public object m_ValueCount;
        public object m_Resolver;
        public object m_Sheet;
        public object m_Properties;
        public object m_PropertyIds;
        public object m_CurrentValueIndex;
        public object m_CurrentPropertyIndex;
        public object _property;
        public object _propertyId;
        public object _valueCount;
        public object _dpiScaling;

        // ── Methods ──
        public void get_property(){} // RVA: 0xBBF8F0
        public void set_property(){} // RVA: 0xBBF900
        public void get_propertyId(){} // RVA: 0xE32C80
        public void set_propertyId(){} // RVA: 0xEEA060
        public void get_valueCount(){} // RVA: 0x15443F0
        public void set_valueCount(){} // RVA: 0x15443E0
        public void get_dpiScaling(){} // RVA: 0xB6B160
        public void set_dpiScaling(){} // RVA: 0xB6B170
        public void SetContext(){} // RVA: 0x7F98A30
        public void SetInlineContext(){} // RVA: 0x7F98C40
        public void MoveNextProperty(){} // RVA: 0x7F98D60
        public void GetValue(){} // RVA: 0x7F98D90
        public void GetValueType(){} // RVA: 0x7F98E30
        public void IsValueType(){} // RVA: 0x7F98EB0
        public void IsKeyword(){} // RVA: 0x7F98F40
        public void ReadAsString(){} // RVA: 0x7F99000
        public void ReadLength(){} // RVA: 0x7F990A0
        public void ReadTimeValue(){} // RVA: 0x7F99200
        public void ReadTranslate(){} // RVA: 0x7F9CFA0
        public void ReadTransformOrigin(){} // RVA: 0x7F9C990
        public void ReadRotate(){} // RVA: 0x7F9D510
        public void ReadScale(){} // RVA: 0x7F9D300
        public void ReadFloat(){} // RVA: 0x7F99960
        public void ReadInt(){} // RVA: 0x7F99A00
        public void ReadColor(){} // RVA: 0x7F99AA0
        public void ReadEnum(){} // RVA: 0x7F9D850
        public void ReadFontDefinition(){} // RVA: 0x7F99D80
        public void ReadFont(){} // RVA: 0x7F9A5F0
        public void ReadBackground(){} // RVA: 0x7F9A980
        public void ReadCursor(){} // RVA: 0x7F9AE00
        public void ReadTextShadow(){} // RVA: 0x7F9B2E0
        public void ReadBackgroundPositionX(){} // RVA: 0x7F9B810
        public void ReadBackgroundPositionY(){} // RVA: 0x7F9B850
        public void ReadBackgroundPosition(){} // RVA: 0x7F9DA10
        public void ReadBackgroundRepeat(){} // RVA: 0x7F9DBF0
        public void ReadBackgroundSize(){} // RVA: 0x7F9DD90
        public void ReadListEasingFunction(){} // RVA: 0x7F9BD50
        public void ReadListTimeValue(){} // RVA: 0x7F9BF80
        public void ReadListStylePropertyName(){} // RVA: 0x7F9C130
        public void LoadProperties(){} // RVA: 0x7F9C370
        public void SetCurrentProperty(){} // RVA: 0x7F9C810
        public void ReadTransformOriginEnum(){} // RVA: 0x7F9CE50
        public void TryReadEnum(){} // RVA: 0x7F9D760
        public void ReadAngle(){} // RVA: 0x7F9D940
        public void TryGetImageSourceFromValue(){} // RVA: 0x7F9E0B0
        public void .ctor(){} // RVA: 0x7F9E840
    }

    public class StylePropertyUtil : Object
    {
        public object s_NameToId;
        public object s_IdToName;
        public object s_UssNameToCSharpName;
        public object s_CSharpNameToUssName;
        public object s_AnimatableProperties;
        public object s_AnimatableWithUsageHintProperties;

        // ── Methods ──
        public void TryGetEnumIntValue(){} // RVA: 0x7F903C0
        public void IsMatchingShorthand(){} // RVA: 0x7F91A70
        public void IsAnimatable(){} // RVA: 0x7F91BD0
        public void .cctor(){} // RVA: 0x7F91C60
    }

    public class StylePropertyValueMatcher : BaseStyleMatcher
    {
        public object m_Values;

        // ── Methods ──
        public void get_current(){} // RVA: 0x7FA4D20
        public void get_valueCount(){} // RVA: 0x7FA4DE0
        public void get_isCurrentVariable(){} // RVA: 0xB43320
        public void get_isCurrentComma(){} // RVA: 0x7FA4E30
        public void Match(){} // RVA: 0x7FA4EF0
        public void MatchKeyword(){} // RVA: 0x7FA5200
        public void MatchNumber(){} // RVA: 0x7FA52D0
        public void MatchInteger(){} // RVA: 0x7FA52D0
        public void MatchLength(){} // RVA: 0x7FA52F0
        public void MatchPercentage(){} // RVA: 0x7FA5370
        public void MatchColor(){} // RVA: 0x7FA53F0
        public void MatchResource(){} // RVA: 0x7FA54B0
        public void MatchUrl(){} // RVA: 0x7FA54D0
        public void MatchTime(){} // RVA: 0x7FA5510
        public void MatchCustomIdent(){} // RVA: 0x7FA5580
        public void MatchAngle(){} // RVA: 0x7FA56D0
        public void .ctor(){} // RVA: 0x7FA5750
    }

    public class StyleSelectorHelper : Object
    {
        // ── Methods ──
        public void MatchesSelector(){} // RVA: 0x7F9ED20
        public void MatchRightToLeft(){} // RVA: 0x7F9EFF0
        public void TestSelectorLinkedList(){} // RVA: 0x7F9F1B0
        public void FastLookup(){} // RVA: 0x7F9F2E0
        public void FindMatches(){} // RVA: 0x7F9F6C0
    }

    public class StyleSheetCache : Object
    {
        public object s_Comparer;
        public object s_RulePropertyIdsCache;

        // ── Methods ──
        public void GetPropertyIds(){} // RVA: 0x7FA0530
        public void GetPropertyId(){} // RVA: 0x7FA0610
        public void .cctor(){} // RVA: 0x7FA0730
    }

    public class StyleSheetColor : Object
    {
        public object s_NameToColor;

        // ── Methods ──
        public void TryGetColor(){} // RVA: 0x7FA0970
        public void HexToColor32(){} // RVA: 0x7FA0AD0
        public void .cctor(){} // RVA: 0x7FA0AF0
    }

    public class StyleSheetExtensions : Object
    {
        // ── Methods ──
        public void ReadAsString(){} // RVA: 0x7FA3490
        public void IsVarFunction(){} // RVA: 0x7FA3840
    }

    public class StyleValueManaged[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class StyleValue[] : Array
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