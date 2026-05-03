// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.StyleSheets.Syntax
// Classes: 5
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.UIElements.StyleSheets.Syntax
{
    public class Expression : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87ECB830
    }

    public class ExpressionMultiplier : ValueType
    {
        public int Infinity;

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFE8733C3B0
        public void set_type(){} // RVA: 0x7FFE87ECB910
        public void .ctor(){} // RVA: 0x7FFE87ECB920
        public void SetType(){} // RVA: 0x7FFE87ECB940
    }

    public class StyleSyntaxParser : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFE87ECB9C0
        public void ParseExpression(){} // RVA: 0x7FFE87ECBBF0
        public void ProcessCombinatorStack(){} // RVA: 0x7FFE87ECBEA0
        public void ParseTerm(){} // RVA: 0x7FFE87ECC1D0
        public void ParseCombinatorType(){} // RVA: 0x7FFE87ECC3D0
        public void ParseGroup(){} // RVA: 0x7FFE87ECC6A0
        public void ParseDataType(){} // RVA: 0x7FFE87ECCA20
        public void ParseNonTerminalValue(){} // RVA: 0x7FFE87ECCF60
        public void ParseProperty(){} // RVA: 0x7FFE87ECD1C0
        public void ParseMultiplier(){} // RVA: 0x7FFE87ECD6D0
        public void ParseRanges(){} // RVA: 0x7FFE87ECD990
        public void EatSpace(){} // RVA: 0x7FFE87ECDAF0
        public void IsExpressionEnd(){} // RVA: 0x7FFE87ECDB50
        public void IsCombinator(){} // RVA: 0x7FFE87ECDB70
        public void IsMultiplier(){} // RVA: 0x7FFE87ECDB90
        public void .ctor(){} // RVA: 0x7FFE87ECDBC0
    }

    public class StyleSyntaxToken : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87ECDF20 | overloaded x3
    }

    public class StyleSyntaxTokenizer : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken> m_Tokens; // 0x10

        // ── Methods ──
        public void get_current(){} // RVA: 0x7FFE87ECDF80
        public void MoveNext(){} // RVA: 0x7FFE87ECE0C0
        public void PeekNext(){} // RVA: 0x7FFE87ECE190
        public void Tokenize(){} // RVA: 0x7FFE87ECE2C0
        public void IsNextCharacter(){} // RVA: 0x7FFE87ECED50
        public void IsNextLetterOrDash(){} // RVA: 0x7FFE87ECEDA0
        public void IsNextNumber(){} // RVA: 0x7FFE87ECEE70
        public void GlobCharacter(){} // RVA: 0x7FFE87ECEF10
        public void .ctor(){} // RVA: 0x7FFE87ECEF80
    }

}