// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 43

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class NamespaceList : Object
    {
        public 0x6B162710 Type; // 0x10
        public System.Collections.Hashtable Excluded; // 0x18
        public string Enumerate; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90D1EE0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC90D2250
        public void get_Type(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Excluded(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Enumerate(){} // RVA: 0x7FFAC90D23F0
        public void Allows(){} // RVA: 0x7FFAC90D2520 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC90D2550
        public void IsSubset(){} // RVA: 0x7FFAC90D2970
        public void Union(){} // RVA: 0x7FFAC90D2C20
        public void CompareSetToOther(){} // RVA: 0x7FFAC90D3110
        public void Intersection(){} // RVA: 0x7FFAC90D3280
        public void RemoveNamespace(){} // RVA: 0x7FFAC90D3780
    }

    public class NamespaceListNode : SyntaxTreeNode
    {
        public System.Xml.Schema.NamespaceList IsNullable; // 0x10
        public object particle; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void GetResolvedSymbols(){} // RVA: 0x7FFAC9271150
        public void ExpandTree(){} // RVA: 0x7FFAC9271180
        public void ConstructPos(){} // RVA: 0x7FFAC92715B0
        public void get_IsNullable(){} // RVA: 0x7FFAC92715F0
    }

    public class NamespaceListV1Compat : NamespaceList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90D37F0
        public void Allows(){} // RVA: 0x7FFAC90D3800
    }

    public class NfaContentValidator : ContentValidator
    {
        public System.Xml.Schema.BitSet firstpos; // 0x18
        public System.Xml.Schema.BitSet[] followpos; // 0x20
        public System.Xml.Schema.SymbolsDictionary symbols; // 0x28
        public System.Xml.Schema.Positions positions; // 0x30
        public int endMarkerPos; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9276640
        public void InitValidation(){} // RVA: 0x7FFAC9276820
        public void ValidateElement(){} // RVA: 0x7FFAC92768F0
        public void CompleteValidation(){} // RVA: 0x7FFAC9276BA0
        public void ExpectedElements(){} // RVA: 0x7FFAC9276C20
        public void ExpectedParticles(){} // RVA: 0x7FFAC9276E30
    }

    public class Numeric10FacetsChecker : FacetsChecker
    {
        public char[] signs;
        public System.Decimal maxValue; // 0x10
        public System.Decimal minValue; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC929C7B0
        public void CheckValueFacets(){} // RVA: 0x7FFAC929D1F0 | overloaded x5
        public void MatchEnumeration(){} // RVA: 0x7FFAC929D370 | overloaded x2
        public void CheckTotalAndFractionDigits(){} // RVA: 0x7FFAC929D4E0
        public void .cctor(){} // RVA: 0x7FFAC929DAF0
    }

    public class Numeric2FacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7FFAC929DFD0 | overloaded x3
        public void MatchEnumeration(){} // RVA: 0x7FFAC929E110 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}