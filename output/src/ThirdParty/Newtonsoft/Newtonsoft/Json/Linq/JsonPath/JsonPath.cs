// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Linq.JsonPath
// Classes: 15
// Methods: 71

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Linq.JsonPath
{
    public class ArrayIndexFilter : PathFilter
    {
        public System.Nullable`1<int> _index; // 0x10

        // ── Methods ──
        public void get_Index(){} // RVA: 0x7FFE81116380
        public void set_Index(){} // RVA: 0x7FFE826F2ED0
        public void ExecuteFilter(){} // RVA: 0x7FFE86B94D00
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ArrayMultipleIndexFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ExecuteFilter(){} // RVA: 0x7FFE86B95860
    }

    public class ArraySliceFilter : PathFilter
    {
        public System.Nullable`1<int> _start; // 0x10
        public System.Nullable`1<int> _end; // 0x18
        public System.Nullable`1<int> _step; // 0x20

        // ── Methods ──
        public void get_Start(){} // RVA: 0x7FFE81116380
        public void set_Start(){} // RVA: 0x7FFE826F2ED0
        public void get_End(){} // RVA: 0x7FFE810FE7C0
        public void set_End(){} // RVA: 0x7FFE819EA910
        public void get_Step(){} // RVA: 0x7FFE811290C0
        public void set_Step(){} // RVA: 0x7FFE81859C50
        public void ExecuteFilter(){} // RVA: 0x7FFE86B96300
        public void IsValid(){} // RVA: 0x7FFE86B96480
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BooleanQueryExpression : QueryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83B45810
        public void GetResult(){} // RVA: 0x7FFE86B9CF10
        public void IsMatch(){} // RVA: 0x7FFE86B9D0C0
        public void MatchTokens(){} // RVA: 0x7FFE86B9D5F0
        public void RegexEquals(){} // RVA: 0x7FFE86B9D880
        public void EqualsWithStringCoercion(){} // RVA: 0x7FFE86B9DA90
        public void EqualsWithStrictMatch(){} // RVA: 0x7FFE86B9E050
    }

    public class CompositeExpression : QueryExpression
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JsonPath.QueryExpression> _expressions; // 0x18

        // ── Methods ──
        public void get_Expressions(){} // RVA: 0x7FFE810FE7C0
        public void set_Expressions(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE86B9CB40
        public void IsMatch(){} // RVA: 0x7FFE86B9CC00
    }

    public class FieldFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ExecuteFilter(){} // RVA: 0x7FFE86B97180
    }

    public class FieldMultipleFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ExecuteFilter(){} // RVA: 0x7FFE86B97DC0
    }

    public class JPath : Object
    {
        public char[] FloatCharacters;

        // ── Methods ──
        public void get_Filters(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE86B98D30
        public void ParseMain(){} // RVA: 0x7FFE86B98EB0
        public void ParsePath(){} // RVA: 0x7FFE86B990A0
        public void CreatePathFilter(){} // RVA: 0x7FFE86B99650
        public void ParseIndexer(){} // RVA: 0x7FFE86B99790
        public void ParseArrayIndexer(){} // RVA: 0x7FFE86B998C0
        public void EatWhitespace(){} // RVA: 0x7FFE86B9A2E0
        public void ParseQuery(){} // RVA: 0x7FFE86B9A330
        public void TryParseExpression(){} // RVA: 0x7FFE86B9A6B0
        public void CreateUnexpectedCharacterException(){} // RVA: 0x7FFE86B9A980
        public void ParseSide(){} // RVA: 0x7FFE86B9AAE0
        public void ParseExpression(){} // RVA: 0x7FFE86B9AD70
        public void TryParseValue(){} // RVA: 0x7FFE86B9B120
        public void ReadQuotedString(){} // RVA: 0x7FFE86B9B6A0
        public void ReadRegexString(){} // RVA: 0x7FFE86B9B980
        public void Match(){} // RVA: 0x7FFE86B9BB20
        public void ParseOperator(){} // RVA: 0x7FFE86B9BBE0
        public void ParseQuotedField(){} // RVA: 0x7FFE86B9BEC0
        public void EnsureLength(){} // RVA: 0x7FFE86B9C2A0
        public void Evaluate(){} // RVA: 0x7FFE86B9C3A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE86B9C5B0
    }

    public class PathFilter : Object
    {
        // ── Methods ──
        public void ExecuteFilter(){} // RVA: 0x7FFE80E403A0
        public void GetTokenIndex(){} // RVA: 0x7FFE86B9C690
        public void GetNextScanValue(){} // RVA: 0x7FFE86B9CA40
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class QueryExpression : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void IsMatch(){} // RVA: 0x7FFE86B9CB10 | overloaded x2
    }

    public class QueryFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ExecuteFilter(){} // RVA: 0x7FFE86B9E1B0
    }

    public class QueryScanFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ExecuteFilter(){} // RVA: 0x7FFE86B9EC50
    }

    public class RootFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void ExecuteFilter(){} // RVA: 0x7FFE86B9F7C0
        public void .cctor(){} // RVA: 0x7FFE86B9F860
    }

    public class ScanFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ExecuteFilter(){} // RVA: 0x7FFE86B9F900
    }

    public class ScanMultipleFilter : PathFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ExecuteFilter(){} // RVA: 0x7FFE86BA0230
    }

}