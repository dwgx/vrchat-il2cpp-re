// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.StyleSheets.Syntax
// Classes: 5
// Methods: 31

namespace ThirdParty.Unity.UnityEngine.UIElements.StyleSheets.Syntax
{
    public class Expression : Object
    {
        public object type;
        public object multiplier;
        public object dataType;
        public object combinator;
        public object subExpressions;
        public object keyword;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FA5910
    }

    public class ExpressionMultiplier : ValueType
    {
        public object Infinity;
        public object m_Type;
        public object min;
        public object max;

        // ── Methods ──
        public void get_type(){} // RVA: 0x454FE0
        public void set_type(){} // RVA: 0x9A1340
        public void .ctor(){} // RVA: 0x9A1350
        public void SetType(){} // RVA: 0x9A1370
    }

    public class StyleSyntaxParser : Object
    {
        public object m_ProcessExpressionList;
        public object m_ExpressionStack;
        public object m_CombinatorStack;
        public object m_ParsedExpressionCache;

        // ── Methods ──
        public void Parse(){} // RVA: 0x7FA5AA0
        public void ParseExpression(){} // RVA: 0x7FA5CD0
        public void ProcessCombinatorStack(){} // RVA: 0x7FA5F70
        public void ParseTerm(){} // RVA: 0x7FA6290
        public void ParseCombinatorType(){} // RVA: 0x7FA6490
        public void ParseGroup(){} // RVA: 0x7FA6760
        public void ParseDataType(){} // RVA: 0x7FA6AE0
        public void ParseNonTerminalValue(){} // RVA: 0x7FA7000
        public void ParseProperty(){} // RVA: 0x7FA7260
        public void ParseMultiplier(){} // RVA: 0x7FA7770
        public void ParseRanges(){} // RVA: 0x7FA7A10
        public void EatSpace(){} // RVA: 0x7FA7B70
        public void IsExpressionEnd(){} // RVA: 0x7FA7BD0
        public void IsCombinator(){} // RVA: 0x7FA7BF0
        public void IsMultiplier(){} // RVA: 0x7FA7C10
        public void .ctor(){} // RVA: 0x7FA7C40
    }

    public class StyleSyntaxToken : ValueType
    {
        public object type;
        public object text;
        public object number;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A1550
    }

    public class StyleSyntaxTokenizer : Object
    {
        public object m_Tokens;
        public object m_CurrentTokenIndex;

        // ── Methods ──
        public void get_current(){} // RVA: 0x7FA8000
        public void MoveNext(){} // RVA: 0x7FA8140
        public void PeekNext(){} // RVA: 0x7FA8210
        public void Tokenize(){} // RVA: 0x7FA8340
        public void IsNextCharacter(){} // RVA: 0x7FA8DA0
        public void IsNextLetterOrDash(){} // RVA: 0x7FA8DF0
        public void IsNextNumber(){} // RVA: 0x7FA8EA0
        public void GlobCharacter(){} // RVA: 0x7FA8F10
        public void .ctor(){} // RVA: 0x7FA8F80
    }

}