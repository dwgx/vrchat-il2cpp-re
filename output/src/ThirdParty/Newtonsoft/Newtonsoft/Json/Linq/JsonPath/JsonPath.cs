// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Linq.JsonPath
// Classes: 15
// Methods: 71

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Linq.JsonPath
{
    public class ArrayIndexFilter : PathFilter
    {
        public System.Nullable`1<int> Index; // 0x10

        // ── Methods ──
        public void get_Index(){} // RVA: 0x7FFAC2F3C380
        public void set_Index(){} // RVA: 0x7FFAC441EFB0
        public void ExecuteFilter(){} // RVA: 0x7FFAC87EB5E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ArrayMultipleIndexFilter : PathFilter
    {
        public System.Collections.Generic.List`1<int> Indexes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ExecuteFilter(){} // RVA: 0x7FFAC87EC140
    }

    public class ArraySliceFilter : PathFilter
    {
        public System.Nullable`1<int> Start; // 0x10
        public System.Nullable`1<int> End; // 0x18
        public System.Nullable`1<int> Step; // 0x20

        // ── Methods ──
        public void get_Start(){} // RVA: 0x7FFAC2F3C380
        public void set_Start(){} // RVA: 0x7FFAC441EFB0
        public void get_End(){} // RVA: 0x7FFAC2F247C0
        public void set_End(){} // RVA: 0x7FFAC38920D0
        public void get_Step(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Step(){} // RVA: 0x7FFAC370BEE0
        public void ExecuteFilter(){} // RVA: 0x7FFAC87ECBE0
        public void IsValid(){} // RVA: 0x7FFAC87ECD60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BooleanQueryExpression : QueryExpression
    {
        public object Left; // 0x18
        public object Right; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5808D30
        public void GetResult(){} // RVA: 0x7FFAC87F37F0
        public void IsMatch(){} // RVA: 0x7FFAC87F39A0
        public void MatchTokens(){} // RVA: 0x7FFAC87F3ED0
        public void RegexEquals(){} // RVA: 0x7FFAC87F4160
        public void EqualsWithStringCoercion(){} // RVA: 0x7FFAC87F4370
        public void EqualsWithStrictMatch(){} // RVA: 0x7FFAC87F4930
    }

    public class CompositeExpression : QueryExpression
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JsonPath.QueryExpression> Expressions; // 0x18

        // ── Methods ──
        public void get_Expressions(){} // RVA: 0x7FFAC2F247C0
        public void set_Expressions(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC87F3420
        public void IsMatch(){} // RVA: 0x7FFAC87F34E0
    }

    public class FieldFilter : PathFilter
    {
        public string Name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ExecuteFilter(){} // RVA: 0x7FFAC87EDA60
    }

    public class FieldMultipleFilter : PathFilter
    {
        public System.Collections.Generic.List`1<string> Names; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ExecuteFilter(){} // RVA: 0x7FFAC87EE6A0
    }

    public class JPath : Object
    {
        public char[] Filters;
        public string _expression; // 0x10
        public System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JsonPath.PathFilter> <Filters>k__BackingField; // 0x18
        public int _currentIndex; // 0x20

        // ── Methods ──
        public void get_Filters(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC87EF610
        public void ParseMain(){} // RVA: 0x7FFAC87EF790
        public void ParsePath(){} // RVA: 0x7FFAC87EF980
        public void CreatePathFilter(){} // RVA: 0x7FFAC87EFF30
        public void ParseIndexer(){} // RVA: 0x7FFAC87F0070
        public void ParseArrayIndexer(){} // RVA: 0x7FFAC87F01A0
        public void EatWhitespace(){} // RVA: 0x7FFAC87F0BC0
        public void ParseQuery(){} // RVA: 0x7FFAC87F0C10
        public void TryParseExpression(){} // RVA: 0x7FFAC87F0F90
        public void CreateUnexpectedCharacterException(){} // RVA: 0x7FFAC87F1260
        public void ParseSide(){} // RVA: 0x7FFAC87F13C0
        public void ParseExpression(){} // RVA: 0x7FFAC87F1650
        public void TryParseValue(){} // RVA: 0x7FFAC87F1A00
        public void ReadQuotedString(){} // RVA: 0x7FFAC87F1F80
        public void ReadRegexString(){} // RVA: 0x7FFAC87F2260
        public void Match(){} // RVA: 0x7FFAC87F2400
        public void ParseOperator(){} // RVA: 0x7FFAC87F24C0
        public void ParseQuotedField(){} // RVA: 0x7FFAC87F27A0
        public void EnsureLength(){} // RVA: 0x7FFAC87F2B80
        public void Evaluate(){} // RVA: 0x7FFAC87F2C80 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC87F2E90
    }

    public class PathFilter : Object
    {
        // ── Methods ──
        public void ExecuteFilter(){} // RVA: 0x7FFAC2C6AE80
        public void GetTokenIndex(){} // RVA: 0x7FFAC87F2F70
        public void GetNextScanValue(){} // RVA: 0x7FFAC87F3320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class QueryExpression : Object
    {
        public 0x6B1CB9B8 Operator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void IsMatch(){} // RVA: 0x7FFAC87F33F0 | overloaded x2
    }

    public class QueryFilter : PathFilter
    {
        public Newtonsoft.Json.Linq.JsonPath.QueryExpression Expression; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ExecuteFilter(){} // RVA: 0x7FFAC87F4A90
    }

    public class QueryScanFilter : PathFilter
    {
        public Newtonsoft.Json.Linq.JsonPath.QueryExpression Expression; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ExecuteFilter(){} // RVA: 0x7FFAC87F5530
    }

    public class RootFilter : PathFilter
    {
        public Newtonsoft.Json.Linq.JsonPath.RootFilter Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ExecuteFilter(){} // RVA: 0x7FFAC87F60A0
        public void .cctor(){} // RVA: 0x7FFAC87F6140
    }

    public class ScanFilter : PathFilter
    {
        public string Name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ExecuteFilter(){} // RVA: 0x7FFAC87F61E0
    }

    public class ScanMultipleFilter : PathFilter
    {
        public System.Collections.Generic.List`1<string> _names; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ExecuteFilter(){} // RVA: 0x7FFAC87F6B10
    }

}