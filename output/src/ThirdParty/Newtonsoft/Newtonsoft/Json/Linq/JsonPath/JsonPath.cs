// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Linq.JsonPath
// Classes: 15
// Methods: 71

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Linq.JsonPath
{
    public class ArrayIndexFilter
    {
        public System.Nullable`1<int> <Index>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Index(){} // RVA: 0x2F8380
        public void set_Index(){} // RVA: 0x1967700
        public void ExecuteFilter(){} // RVA: 0x6053F30
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ArrayMultipleIndexFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ExecuteFilter(){} // RVA: 0x6054A90
    }

    public class ArraySliceFilter
    {
        public System.Nullable`1<int> <Start>k__BackingField; // 0x10
        public System.Nullable`1<int> <End>k__BackingField; // 0x18
        public System.Nullable`1<int> <Step>k__BackingField; // 0x20

        // ── Methods ──
        public void get_Start(){} // RVA: 0x2F8380
        public void set_Start(){} // RVA: 0x1967700
        public void get_End(){} // RVA: 0x2E07C0
        public void set_End(){} // RVA: 0xC5BE60
        public void get_Step(){} // RVA: 0x30B0C0
        public void set_Step(){} // RVA: 0xAE83A0
        public void ExecuteFilter(){} // RVA: 0x6055530
        public void IsValid(){} // RVA: 0x60556B0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BooleanQueryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E766D0
        public void GetResult(){} // RVA: 0x605C140
        public void IsMatch(){} // RVA: 0x605C2F0
        public void MatchTokens(){} // RVA: 0x605C820
        public void RegexEquals(){} // RVA: 0x605CAB0
        public void EqualsWithStringCoercion(){} // RVA: 0x605CCC0
        public void EqualsWithStrictMatch(){} // RVA: 0x605D280
    }

    public class CompositeExpression
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JsonPath.QueryExpression> <Expressions>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Expressions(){} // RVA: 0x2E07C0
        public void set_Expressions(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x605BD70
        public void IsMatch(){} // RVA: 0x605BE30
    }

    public class FieldFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ExecuteFilter(){} // RVA: 0x60563B0
    }

    public class FieldMultipleFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ExecuteFilter(){} // RVA: 0x6056FF0
    }

    public class JPath
    {
        public char[] FloatCharacters;

        // ── Methods ──
        public void get_Filters(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x6057F60
        public void ParseMain(){} // RVA: 0x60580E0
        public void ParsePath(){} // RVA: 0x60582D0
        public void CreatePathFilter(){} // RVA: 0x6058880
        public void ParseIndexer(){} // RVA: 0x60589C0
        public void ParseArrayIndexer(){} // RVA: 0x6058AF0
        public void EatWhitespace(){} // RVA: 0x6059510
        public void ParseQuery(){} // RVA: 0x6059560
        public void TryParseExpression(){} // RVA: 0x60598E0
        public void CreateUnexpectedCharacterException(){} // RVA: 0x6059BB0
        public void ParseSide(){} // RVA: 0x6059D10
        public void ParseExpression(){} // RVA: 0x6059FA0
        public void TryParseValue(){} // RVA: 0x605A350
        public void ReadQuotedString(){} // RVA: 0x605A8D0
        public void ReadRegexString(){} // RVA: 0x605ABB0
        public void Match(){} // RVA: 0x605AD50
        public void ParseOperator(){} // RVA: 0x605AE10
        public void ParseQuotedField(){} // RVA: 0x605B0F0
        public void EnsureLength(){} // RVA: 0x605B4D0
        public void Evaluate(){} // RVA: 0x605B5D0 | overloaded x2
        public void .cctor(){} // RVA: 0x605B7E0
    }

    public class PathFilter
    {
        // ── Methods ──
        public void ExecuteFilter(){} // RVA: 0x1EE30
        public void GetTokenIndex(){} // RVA: 0x605B8C0
        public void GetNextScanValue(){} // RVA: 0x605BC70
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class QueryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void IsMatch(){} // RVA: 0x605BD40 | overloaded x2
    }

    public class QueryFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ExecuteFilter(){} // RVA: 0x605D3E0
    }

    public class QueryScanFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ExecuteFilter(){} // RVA: 0x605DE80
    }

    public class RootFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void ExecuteFilter(){} // RVA: 0x605E9F0
        public void .cctor(){} // RVA: 0x605EA90
    }

    public class ScanFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ExecuteFilter(){} // RVA: 0x605EB30
    }

    public class ScanMultipleFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ExecuteFilter(){} // RVA: 0x605F460
    }

}