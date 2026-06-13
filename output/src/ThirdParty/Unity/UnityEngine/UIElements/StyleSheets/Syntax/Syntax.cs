// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.StyleSheets.Syntax
// Classes: 5
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.UIElements.StyleSheets.Syntax
{
    public class Expression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x738B6B0
    }

    public class ExpressionMultiplier
    {
        public int Infinity;

        // ── Methods ──
        public void get_type(){} // RVA: 0x67FD0D0
        public void set_type(){} // RVA: 0x738B790
        public void .ctor(){} // RVA: 0x738B7A0
        public void SetType(){} // RVA: 0x738B7C0
    }

    public class StyleSyntaxParser
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x738B840
        public void ParseExpression(){} // RVA: 0x738BA70
        public void ProcessCombinatorStack(){} // RVA: 0x738BD20
        public void ParseTerm(){} // RVA: 0x738C050
        public void ParseCombinatorType(){} // RVA: 0x738C250
        public void ParseGroup(){} // RVA: 0x738C520
        public void ParseDataType(){} // RVA: 0x738C8A0
        public void ParseNonTerminalValue(){} // RVA: 0x738CDE0
        public void ParseProperty(){} // RVA: 0x738D040
        public void ParseMultiplier(){} // RVA: 0x738D550
        public void ParseRanges(){} // RVA: 0x738D810
        public void EatSpace(){} // RVA: 0x738D970
        public void IsExpressionEnd(){} // RVA: 0x738D9D0
        public void IsCombinator(){} // RVA: 0x738D9F0
        public void IsMultiplier(){} // RVA: 0x738DA10
        public void .ctor(){} // RVA: 0x738DA40
    }

    public class StyleSyntaxToken
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x738DDA0 | overloaded x3
    }

    public class StyleSyntaxTokenizer
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken> m_Tokens; // 0x10

        // ── Methods ──
        public void get_current(){} // RVA: 0x738DE00
        public void MoveNext(){} // RVA: 0x738DF40
        public void PeekNext(){} // RVA: 0x738E010
        public void Tokenize(){} // RVA: 0x738E140
        public void IsNextCharacter(){} // RVA: 0x738EBD0
        public void IsNextLetterOrDash(){} // RVA: 0x738EC20
        public void IsNextNumber(){} // RVA: 0x738ECF0
        public void GlobCharacter(){} // RVA: 0x738ED90
        public void .ctor(){} // RVA: 0x738EE00
    }

}