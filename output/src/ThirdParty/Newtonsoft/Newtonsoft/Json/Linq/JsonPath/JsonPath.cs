// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Linq.JsonPath
// Classes: 15
// Methods: 69

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Linq.JsonPath
{
    public class ArrayIndexFilter : PathFilter
    {
        // ── Methods ──
        public void get_Index(){} // RVA: 0x7A80F2570
        public void set_Index(){} // RVA: 0x7A97242F0
        public void ExecuteFilter(){} // RVA: 0x7ADE40360
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ArrayMultipleIndexFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ExecuteFilter(){} // RVA: 0x7ADE40EC0
    }

    public class ArraySliceFilter : PathFilter
    {
        // ── Methods ──
        public void get_Start(){} // RVA: 0x7A80F2570
        public void set_Start(){} // RVA: 0x7A97242F0
        public void get_End(){} // RVA: 0x7A80DA7B0
        public void set_End(){} // RVA: 0x7A8A224D0
        public void get_Step(){} // RVA: 0x7A81052C0
        public void set_Step(){} // RVA: 0x7A8884B10
        public void ExecuteFilter(){} // RVA: 0x7ADE41960
        public void IsValid(){} // RVA: 0x7ADE41AE0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BooleanQueryExpression : QueryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAC6DFD0
        public void GetResult(){} // RVA: 0x7ADE48560
        public void IsMatch(){} // RVA: 0x7ADE48700
        public void MatchTokens(){} // RVA: 0x7ADE48C30
        public void RegexEquals(){} // RVA: 0x7ADE48EA0
        public void EqualsWithStringCoercion(){} // RVA: 0x7ADE490B0
        public void EqualsWithStrictMatch(){} // RVA: 0x7ADE49680
    }

    public class CompositeExpression : QueryExpression
    {
        // ── Methods ──
        public void get_Expressions(){} // RVA: 0x7A80DA7B0
        public void set_Expressions(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7ADE48190
        public void IsMatch(){} // RVA: 0x7ADE48250
    }

    public class FieldFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ExecuteFilter(){} // RVA: 0x7ADE427E0
    }

    public class FieldMultipleFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ExecuteFilter(){} // RVA: 0x7ADE43430
    }

    public class JPath : Object
    {
        // ── Methods ──
        public void get_Filters(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7ADE443C0
        public void ParseMain(){} // RVA: 0x7ADE44540
        public void ParsePath(){} // RVA: 0x7ADE44730
        public void CreatePathFilter(){} // RVA: 0x7ADE44CE0
        public void ParseIndexer(){} // RVA: 0x7ADE44E20
        public void ParseArrayIndexer(){} // RVA: 0x7ADE44F50
        public void EatWhitespace(){} // RVA: 0x7ADE45970
        public void ParseQuery(){} // RVA: 0x7ADE459C0
        public void TryParseExpression(){} // RVA: 0x7ADE45D30
        public void CreateUnexpectedCharacterException(){} // RVA: 0x7ADE46000
        public void ParseSide(){} // RVA: 0x7ADE46150
        public void ParseExpression(){} // RVA: 0x7ADE463D0
        public void TryParseValue(){} // RVA: 0x7ADE46780
        public void ReadQuotedString(){} // RVA: 0x7ADE46D00
        public void ReadRegexString(){} // RVA: 0x7ADE46FD0
        public void Match(){} // RVA: 0x7ADE47170
        public void ParseOperator(){} // RVA: 0x7ADE47230
        public void ParseQuotedField(){} // RVA: 0x7ADE47510
        public void EnsureLength(){} // RVA: 0x7ADE478F0
        public void Evaluate(){} // RVA: 0x7ADE479F0
        public void .cctor(){} // RVA: 0x7ADE47C10
    }

    public class PathFilter : Object
    {
        // ── Methods ──
        public void ExecuteFilter(){} // RVA: 0x7A7E06710
        public void GetTokenIndex(){} // RVA: 0x7ADE47CF0
        public void GetNextScanValue(){} // RVA: 0x7ADE48090
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class QueryExpression : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void IsMatch(){} // RVA: 0x7A7E01D90
    }

    public class QueryFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ExecuteFilter(){} // RVA: 0x7ADE497E0
    }

    public class QueryScanFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ExecuteFilter(){} // RVA: 0x7ADE4A280
    }

    public class RootFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void ExecuteFilter(){} // RVA: 0x7ADE4ADE0
        public void .cctor(){} // RVA: 0x7ADE4AE80
    }

    public class ScanFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ExecuteFilter(){} // RVA: 0x7ADE4AF20
    }

    public class ScanMultipleFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ExecuteFilter(){} // RVA: 0x7ADE4B840
    }

}