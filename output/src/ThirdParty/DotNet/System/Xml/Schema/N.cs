// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 43

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class NamespaceList
    {
        public 0x6587D8F8 type; // 0x10
        public System.Collections.Hashtable set; // 0x18
        public string targetNamespace; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x693B3C0 | overloaded x2
        public void Clone(){} // RVA: 0x693B730
        public void get_Type(){} // RVA: 0x32A5C0
        public void get_Excluded(){} // RVA: 0x30B0C0
        public void get_Enumerate(){} // RVA: 0x693B8D0
        public void Allows(){} // RVA: 0x693BA00 | overloaded x2
        public void ToString(){} // RVA: 0x693BA30
        public void IsSubset(){} // RVA: 0x693BE50
        public void Union(){} // RVA: 0x693C100
        public void CompareSetToOther(){} // RVA: 0x693C5F0
        public void Intersection(){} // RVA: 0x693C760
        public void RemoveNamespace(){} // RVA: 0x693CC60
    }

    public class NamespaceListNode
    {
        public System.Xml.Schema.NamespaceList namespaceList; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void GetResolvedSymbols(){} // RVA: 0x6ADA5D0
        public void ExpandTree(){} // RVA: 0x6ADA600
        public void ConstructPos(){} // RVA: 0x6ADAA30
        public void get_IsNullable(){} // RVA: 0x6ADAA70
    }

    public class NamespaceListV1Compat
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x693CCD0
        public void Allows(){} // RVA: 0x693CCE0
    }

    public class NfaContentValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6ADFAC0
        public void InitValidation(){} // RVA: 0x6ADFCA0
        public void ValidateElement(){} // RVA: 0x6ADFD70
        public void CompleteValidation(){} // RVA: 0x6AE0020
        public void ExpectedElements(){} // RVA: 0x6AE00A0
        public void ExpectedParticles(){} // RVA: 0x6AE02B0
    }

    public class Numeric10FacetsChecker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B05C30
        public void CheckValueFacets(){} // RVA: 0x6B06670 | overloaded x5
        public void MatchEnumeration(){} // RVA: 0x6B067F0 | overloaded x2
        public void CheckTotalAndFractionDigits(){} // RVA: 0x6B06960
        public void .cctor(){} // RVA: 0x6B06F70
    }

    public class Numeric2FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x6B07450 | overloaded x3
        public void MatchEnumeration(){} // RVA: 0x6B07590 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

}