// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 43

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class NamespaceList : Object
    {
        public 0x6655B794 type; // 0x10
        public System.Collections.Hashtable set; // 0x18
        public string targetNamespace; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8747A690 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8747AA00
        public void get_Type(){} // RVA: 0x7FFE811485C0
        public void get_Excluded(){} // RVA: 0x7FFE811290C0
        public void get_Enumerate(){} // RVA: 0x7FFE8747ABA0
        public void Allows(){} // RVA: 0x7FFE8747ACD0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE8747AD00
        public void IsSubset(){} // RVA: 0x7FFE8747B120
        public void Union(){} // RVA: 0x7FFE8747B3D0
        public void CompareSetToOther(){} // RVA: 0x7FFE8747B8C0
        public void Intersection(){} // RVA: 0x7FFE8747BA30
        public void RemoveNamespace(){} // RVA: 0x7FFE8747BF30
    }

    public class NamespaceListNode : SyntaxTreeNode
    {
        public System.Xml.Schema.NamespaceList namespaceList; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void GetResolvedSymbols(){} // RVA: 0x7FFE876198C0
        public void ExpandTree(){} // RVA: 0x7FFE876198F0
        public void ConstructPos(){} // RVA: 0x7FFE87619D20
        public void get_IsNullable(){} // RVA: 0x7FFE87619D60
    }

    public class NamespaceListV1Compat : NamespaceList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8747BFA0
        public void Allows(){} // RVA: 0x7FFE8747BFB0
    }

    public class NfaContentValidator : ContentValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8761EDB0
        public void InitValidation(){} // RVA: 0x7FFE8761EF90
        public void ValidateElement(){} // RVA: 0x7FFE8761F060
        public void CompleteValidation(){} // RVA: 0x7FFE8761F310
        public void ExpectedElements(){} // RVA: 0x7FFE8761F390
        public void ExpectedParticles(){} // RVA: 0x7FFE8761F5A0
    }

    public class Numeric10FacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87644EF0
        public void CheckValueFacets(){} // RVA: 0x7FFE87645930 | overloaded x5
        public void MatchEnumeration(){} // RVA: 0x7FFE87645AB0 | overloaded x2
        public void CheckTotalAndFractionDigits(){} // RVA: 0x7FFE87645C20
        public void .cctor(){} // RVA: 0x7FFE87646230
    }

    public class Numeric2FacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7FFE87646710 | overloaded x3
        public void MatchEnumeration(){} // RVA: 0x7FFE87646850 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}