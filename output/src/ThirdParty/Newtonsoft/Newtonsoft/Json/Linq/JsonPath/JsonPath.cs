// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Linq.JsonPath
// Classes: 15
// Methods: 71

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Linq.JsonPath
{
    public class ArrayIndexFilter
    {
        // ── Methods ──
        public void get_Index(){} // RVA: 0x7FFAF2DA8380
        public void set_Index(){} // RVA: 0x7FFAF4417700
        public void ExecuteFilter(){} // RVA: 0x7FFAF8B03F30
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ArrayMultipleIndexFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void ExecuteFilter(){} // RVA: 0x7FFAF8B04A90
    }

    public class ArraySliceFilter
    {
        // ── Methods ──
        public void get_Start(){} // RVA: 0x7FFAF2DA8380
        public void set_Start(){} // RVA: 0x7FFAF4417700
        public void get_End(){} // RVA: 0x7FFAF2D907C0
        public void set_End(){} // RVA: 0x7FFAF370BE60
        public void get_Step(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Step(){} // RVA: 0x7FFAF35983A0
        public void ExecuteFilter(){} // RVA: 0x7FFAF8B05530
        public void IsValid(){} // RVA: 0x7FFAF8B056B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BooleanQueryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF59266D0
        public void GetResult(){} // RVA: 0x7FFAF8B0C140
        public void IsMatch(){} // RVA: 0x7FFAF8B0C2F0
        public void MatchTokens(){} // RVA: 0x7FFAF8B0C820
        public void RegexEquals(){} // RVA: 0x7FFAF8B0CAB0
        public void EqualsWithStringCoercion(){} // RVA: 0x7FFAF8B0CCC0
        public void EqualsWithStrictMatch(){} // RVA: 0x7FFAF8B0D280
    }

    public class CompositeExpression
    {
        // ── Methods ──
        public void get_Expressions(){} // RVA: 0x7FFAF2D907C0
        public void set_Expressions(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAF8B0BD70
        public void IsMatch(){} // RVA: 0x7FFAF8B0BE30
    }

    public class FieldFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void ExecuteFilter(){} // RVA: 0x7FFAF8B063B0
    }

    public class FieldMultipleFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void ExecuteFilter(){} // RVA: 0x7FFAF8B06FF0
    }

    public class JPath
    {
        // ── Methods ──
        public void get_Filters(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF8B07F60
        public void ParseMain(){} // RVA: 0x7FFAF8B080E0
        public void ParsePath(){} // RVA: 0x7FFAF8B082D0
        public void CreatePathFilter(){} // RVA: 0x7FFAF8B08880
        public void ParseIndexer(){} // RVA: 0x7FFAF8B089C0
        public void ParseArrayIndexer(){} // RVA: 0x7FFAF8B08AF0
        public void EatWhitespace(){} // RVA: 0x7FFAF8B09510
        public void ParseQuery(){} // RVA: 0x7FFAF8B09560
        public void TryParseExpression(){} // RVA: 0x7FFAF8B098E0
        public void CreateUnexpectedCharacterException(){} // RVA: 0x7FFAF8B09BB0
        public void ParseSide(){} // RVA: 0x7FFAF8B09D10
        public void ParseExpression(){} // RVA: 0x7FFAF8B09FA0
        public void TryParseValue(){} // RVA: 0x7FFAF8B0A350
        public void ReadQuotedString(){} // RVA: 0x7FFAF8B0A8D0
        public void ReadRegexString(){} // RVA: 0x7FFAF8B0ABB0
        public void Match(){} // RVA: 0x7FFAF8B0AD50
        public void ParseOperator(){} // RVA: 0x7FFAF8B0AE10
        public void ParseQuotedField(){} // RVA: 0x7FFAF8B0B0F0
        public void EnsureLength(){} // RVA: 0x7FFAF8B0B4D0
        public void Evaluate(){} // RVA: 0x7FFAF8B0B5D0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8B0B7E0
    }

    public class PathFilter
    {
        // ── Methods ──
        public void ExecuteFilter(){} // RVA: 0x7FFAF2ACEE30
        public void GetTokenIndex(){} // RVA: 0x7FFAF8B0B8C0
        public void GetNextScanValue(){} // RVA: 0x7FFAF8B0BC70
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class QueryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void IsMatch(){} // RVA: 0x7FFAF8B0BD40 | overloaded x2
    }

    public class QueryFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void ExecuteFilter(){} // RVA: 0x7FFAF8B0D3E0
    }

    public class QueryScanFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void ExecuteFilter(){} // RVA: 0x7FFAF8B0DE80
    }

    public class RootFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void ExecuteFilter(){} // RVA: 0x7FFAF8B0E9F0
        public void .cctor(){} // RVA: 0x7FFAF8B0EA90
    }

    public class ScanFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void ExecuteFilter(){} // RVA: 0x7FFAF8B0EB30
    }

    public class ScanMultipleFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void ExecuteFilter(){} // RVA: 0x7FFAF8B0F460
    }

}