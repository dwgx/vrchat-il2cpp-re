// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.StyleSheets.Syntax
// Classes: 5
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.UIElements.StyleSheets.Syntax
{
    public class Expression : Object
    {
        public 0x6B12A008 type; // 0x10
        public UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier multiplier; // 0x14
        public 0x6B12A060 dataType; // 0x20
        public 0x6B12A0B8 combinator; // 0x24
        public UnityEngine.UIElements.StyleSheets.Syntax.Expression[] subExpressions; // 0x28
        public string keyword; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B22F90
    }

    public class ExpressionMultiplier : ValueType
    {
        public int type;
        public 0x6B12A110 m_Type; // 0x10
        public int min; // 0x14
        public int max; // 0x18

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAC8F93F90
        public void set_type(){} // RVA: 0x7FFAC9B23070
        public void .ctor(){} // RVA: 0x7FFAC9B23080
        public void SetType(){} // RVA: 0x7FFAC9B230A0
    }

    public class StyleSyntaxParser : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ProcessExpressionList; // 0x10
        public System.Collections.Generic.Stack`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ExpressionStack; // 0x18
        public System.Collections.Generic.Stack`1<0x6B12A0B8> m_CombinatorStack; // 0x20
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ParsedExpressionCache; // 0x28

        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFAC9B23120
        public void ParseExpression(){} // RVA: 0x7FFAC9B23350
        public void ProcessCombinatorStack(){} // RVA: 0x7FFAC9B23600
        public void ParseTerm(){} // RVA: 0x7FFAC9B23930
        public void ParseCombinatorType(){} // RVA: 0x7FFAC9B23B30
        public void ParseGroup(){} // RVA: 0x7FFAC9B23E00
        public void ParseDataType(){} // RVA: 0x7FFAC9B24180
        public void ParseNonTerminalValue(){} // RVA: 0x7FFAC9B246C0
        public void ParseProperty(){} // RVA: 0x7FFAC9B24920
        public void ParseMultiplier(){} // RVA: 0x7FFAC9B24E30
        public void ParseRanges(){} // RVA: 0x7FFAC9B250F0
        public void EatSpace(){} // RVA: 0x7FFAC9B25250
        public void IsExpressionEnd(){} // RVA: 0x7FFAC9B252B0
        public void IsCombinator(){} // RVA: 0x7FFAC9B252D0
        public void IsMultiplier(){} // RVA: 0x7FFAC9B252F0
        public void .ctor(){} // RVA: 0x7FFAC9B25320
    }

    public class StyleSyntaxToken : ValueType
    {
        public 0x6B12A218 type; // 0x10
        public string text; // 0x18
        public int number; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B25680 | overloaded x3
    }

    public class StyleSyntaxTokenizer : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken> current; // 0x10
        public int m_CurrentTokenIndex; // 0x18

        // ── Methods ──
        public void get_current(){} // RVA: 0x7FFAC9B256E0
        public void MoveNext(){} // RVA: 0x7FFAC9B25820
        public void PeekNext(){} // RVA: 0x7FFAC9B258F0
        public void Tokenize(){} // RVA: 0x7FFAC9B25A20
        public void IsNextCharacter(){} // RVA: 0x7FFAC9B264B0
        public void IsNextLetterOrDash(){} // RVA: 0x7FFAC9B26500
        public void IsNextNumber(){} // RVA: 0x7FFAC9B265D0
        public void GlobCharacter(){} // RVA: 0x7FFAC9B26670
        public void .ctor(){} // RVA: 0x7FFAC9B266E0
    }

}