// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 33

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class NamespaceList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE72A980
        public void Clone(){} // RVA: 0x7AE72ACF0
        public void get_Type(){} // RVA: 0x7A8124910
        public void get_Excluded(){} // RVA: 0x7A81052C0
        public void get_Enumerate(){} // RVA: 0x7AE72AE90
        public void Allows(){} // RVA: 0x7AE72AFC0
        public void ToString(){} // RVA: 0x7AE72AFF0
        public void IsSubset(){} // RVA: 0x7AE72B430
        public void Union(){} // RVA: 0x7AE72B6F0
        public void CompareSetToOther(){} // RVA: 0x7AE72BBC0
        public void Intersection(){} // RVA: 0x7AE72BD30
        public void RemoveNamespace(){} // RVA: 0x7AE72C220
    }

    public class NamespaceListNode : SyntaxTreeNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void GetResolvedSymbols(){} // RVA: 0x7AE8CAA00
        public void ExpandTree(){} // RVA: 0x7AE8CAA30
        public void ConstructPos(){} // RVA: 0x7AE8CAE60
        public void get_IsNullable(){} // RVA: 0x7AE8CAEA0
    }

    public class NamespaceListV1Compat : NamespaceList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE72C290
        public void Allows(){} // RVA: 0x7AE72C2A0
    }

    public class NfaContentValidator : ContentValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8D0000
        public void InitValidation(){} // RVA: 0x7AE8D01E0
        public void ValidateElement(){} // RVA: 0x7AE8D02B0
        public void CompleteValidation(){} // RVA: 0x7AE8D0580
        public void ExpectedElements(){} // RVA: 0x7AE8D0600
        public void ExpectedParticles(){} // RVA: 0x7AE8D0810
    }

    public class Numeric10FacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8F6480
        public void CheckValueFacets(){} // RVA: 0x7AE8F6EC0
        public void MatchEnumeration(){} // RVA: 0x7AE8F7040
        public void CheckTotalAndFractionDigits(){} // RVA: 0x7AE8F71B0
        public void .cctor(){} // RVA: 0x7AE8F77C0
    }

    public class Numeric2FacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7AE8F7CA0
        public void MatchEnumeration(){} // RVA: 0x7AE8F7DE0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}