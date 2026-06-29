// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.StyleSheets.Syntax
// Classes: 5
// Methods: 31

namespace ThirdParty.Unity.UnityEngine.UIElements.StyleSheets.Syntax
{
    public class Expression : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF16AC00
    }

    public class ExpressionMultiplier : ValueType
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x7A79EAED0
        public void set_type(){} // RVA: 0x7A7F005A0
        public void .ctor(){} // RVA: 0x7A7F005B0
        public void SetType(){} // RVA: 0x7A7F005D0
    }

    public class StyleSyntaxParser : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7AF16AD90
        public void ParseExpression(){} // RVA: 0x7AF16AFC0
        public void ProcessCombinatorStack(){} // RVA: 0x7AF16B260
        public void ParseTerm(){} // RVA: 0x7AF16B580
        public void ParseCombinatorType(){} // RVA: 0x7AF16B780
        public void ParseGroup(){} // RVA: 0x7AF16BA50
        public void ParseDataType(){} // RVA: 0x7AF16BDD0
        public void ParseNonTerminalValue(){} // RVA: 0x7AF16C310
        public void ParseProperty(){} // RVA: 0x7AF16C570
        public void ParseMultiplier(){} // RVA: 0x7AF16CA80
        public void ParseRanges(){} // RVA: 0x7AF16CD10
        public void EatSpace(){} // RVA: 0x7AF16CE70
        public void IsExpressionEnd(){} // RVA: 0x7AF16CED0
        public void IsCombinator(){} // RVA: 0x7AF16CEF0
        public void IsMultiplier(){} // RVA: 0x7AF16CF10
        public void .ctor(){} // RVA: 0x7AF16CF40
    }

    public class StyleSyntaxToken : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F007B0
    }

    public class StyleSyntaxTokenizer : Object
    {
        // ── Methods ──
        public void get_current(){} // RVA: 0x7AF16D300
        public void MoveNext(){} // RVA: 0x7AF16D440
        public void PeekNext(){} // RVA: 0x7AF16D510
        public void Tokenize(){} // RVA: 0x7AF16D640
        public void IsNextCharacter(){} // RVA: 0x7AF16E0D0
        public void IsNextLetterOrDash(){} // RVA: 0x7AF16E120
        public void IsNextNumber(){} // RVA: 0x7AF16E1F0
        public void GlobCharacter(){} // RVA: 0x7AF16E290
        public void .ctor(){} // RVA: 0x7AF16E300
    }

}