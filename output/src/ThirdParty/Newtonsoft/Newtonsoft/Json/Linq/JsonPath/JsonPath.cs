// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Linq.JsonPath
// Classes: 15
// Methods: 69

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Linq.JsonPath
{
    public class ArrayIndexFilter : PathFilter
    {
        public object _index;

        // ── Methods ──
        public void get_Index(){} // RVA: 0xB5DBF0
        public void set_Index(){} // RVA: 0x2230E30
        public void ExecuteFilter(){} // RVA: 0x6AC7AE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ArrayMultipleIndexFilter : PathFilter
    {
        public object Indexes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ExecuteFilter(){} // RVA: 0x6AC8640
    }

    public class ArraySliceFilter : PathFilter
    {
        public object _start;
        public object _end;
        public object _step;

        // ── Methods ──
        public void get_Start(){} // RVA: 0xB5DBF0
        public void set_Start(){} // RVA: 0x2230E30
        public void get_End(){} // RVA: 0xB465B0
        public void set_End(){} // RVA: 0x15428E0
        public void get_Step(){} // RVA: 0xB700F0
        public void set_Step(){} // RVA: 0x13B3F80
        public void ExecuteFilter(){} // RVA: 0x6AC90E0
        public void IsValid(){} // RVA: 0x6AC9260
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BooleanQueryExpression : QueryExpression
    {
        public object Left;
        public object Right;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x38BA2E0
        public void GetResult(){} // RVA: 0x6ACFC20
        public void IsMatch(){} // RVA: 0x6ACFDC0
        public void MatchTokens(){} // RVA: 0x6AD02F0
        public void RegexEquals(){} // RVA: 0x6AD0560
        public void EqualsWithStringCoercion(){} // RVA: 0x6AD0760
        public void EqualsWithStrictMatch(){} // RVA: 0x6AD0D20
    }

    public class CompositeExpression : QueryExpression
    {
        public object _expressions;

        // ── Methods ──
        public void get_Expressions(){} // RVA: 0xB465B0
        public void set_Expressions(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x6ACF850
        public void IsMatch(){} // RVA: 0x6ACF910
    }

    public class FieldFilter : PathFilter
    {
        public object Name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ExecuteFilter(){} // RVA: 0x6AC9F60
    }

    public class FieldMultipleFilter : PathFilter
    {
        public object Names;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ExecuteFilter(){} // RVA: 0x6ACABB0
    }

    public class JPath : Object
    {
        public object FloatCharacters;
        public object _expression;
        public object _filters;
        public object _currentIndex;

        // ── Methods ──
        public void get_Filters(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x6ACBB40
        public void ParseMain(){} // RVA: 0x6ACBCC0
        public void ParsePath(){} // RVA: 0x6ACBEA0
        public void CreatePathFilter(){} // RVA: 0x6ACC440
        public void ParseIndexer(){} // RVA: 0x6ACC580
        public void ParseArrayIndexer(){} // RVA: 0x6ACC6B0
        public void EatWhitespace(){} // RVA: 0x6ACD0A0
        public void ParseQuery(){} // RVA: 0x6ACD0F0
        public void TryParseExpression(){} // RVA: 0x6ACD450
        public void CreateUnexpectedCharacterException(){} // RVA: 0x6ACD720
        public void ParseSide(){} // RVA: 0x6ACD840
        public void ParseExpression(){} // RVA: 0x6ACDAC0
        public void TryParseValue(){} // RVA: 0x6ACDE70
        public void ReadQuotedString(){} // RVA: 0x6ACE410
        public void ReadRegexString(){} // RVA: 0x6ACE6E0
        public void Match(){} // RVA: 0x6ACE860
        public void ParseOperator(){} // RVA: 0x6ACE920
        public void ParseQuotedField(){} // RVA: 0x6ACEC00
        public void EnsureLength(){} // RVA: 0x6ACEFE0
        public void Evaluate(){} // RVA: 0x6ACF0E0
        public void .cctor(){} // RVA: 0x6ACF300
    }

    public class PathFilter : Object
    {
        // ── Methods ──
        public void ExecuteFilter(){} // RVA: 0x882090
        public void GetTokenIndex(){} // RVA: 0x6ACF3E0
        public void GetNextScanValue(){} // RVA: 0x6ACF750
        public void .ctor(){} // RVA: 0xB43310
    }

    public class QueryExpression : Object
    {
        public object Operator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void IsMatch(){} // RVA: 0x87D710
    }

    public class QueryFilter : PathFilter
    {
        public object Expression;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ExecuteFilter(){} // RVA: 0x6AD0E80
    }

    public class QueryScanFilter : PathFilter
    {
        public object Expression;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ExecuteFilter(){} // RVA: 0x6AD1920
    }

    public class RootFilter : PathFilter
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void ExecuteFilter(){} // RVA: 0x6AD2480
        public void .cctor(){} // RVA: 0x6AD2520
    }

    public class ScanFilter : PathFilter
    {
        public object Name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ExecuteFilter(){} // RVA: 0x6AD25C0
    }

    public class ScanMultipleFilter : PathFilter
    {
        public object _names;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ExecuteFilter(){} // RVA: 0x6AD2EE0
    }

}