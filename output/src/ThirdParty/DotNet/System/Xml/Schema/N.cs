// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 33

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class NamespaceList : Object
    {
        public object type;
        public object set;
        public object targetNamespace;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73A08F0
        public void Clone(){} // RVA: 0x73A0C50
        public void get_Type(){} // RVA: 0xB8F8F0
        public void get_Excluded(){} // RVA: 0xB700F0
        public void get_Enumerate(){} // RVA: 0x73A0DF0
        public void Allows(){} // RVA: 0x73A0F20
        public void ToString(){} // RVA: 0x73A0F50
        public void IsSubset(){} // RVA: 0x73A1380
        public void Union(){} // RVA: 0x73A1630
        public void CompareSetToOther(){} // RVA: 0x73A1AF0
        public void Intersection(){} // RVA: 0x73A1C50
        public void RemoveNamespace(){} // RVA: 0x73A2130
    }

    public class NamespaceListNode : SyntaxTreeNode
    {
        public object namespaceList;
        public object particle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetResolvedSymbols(){} // RVA: 0x753E8F0
        public void ExpandTree(){} // RVA: 0x753E920
        public void ConstructPos(){} // RVA: 0x753ED40
        public void get_IsNullable(){} // RVA: 0x753ED80
    }

    public class NamespaceListV1Compat : NamespaceList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73A21A0
        public void Allows(){} // RVA: 0x73A21B0
    }

    public class NfaContentValidator : ContentValidator
    {
        public object firstpos;
        public object followpos;
        public object symbols;
        public object positions;
        public object endMarkerPos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7543EE0
        public void InitValidation(){} // RVA: 0x75440C0
        public void ValidateElement(){} // RVA: 0x7544190
        public void CompleteValidation(){} // RVA: 0x7544460
        public void ExpectedElements(){} // RVA: 0x75444E0
        public void ExpectedParticles(){} // RVA: 0x75446F0
    }

    public class Numeric10FacetsChecker : FacetsChecker
    {
        public object signs;
        public object maxValue;
        public object minValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75695F0
        public void CheckValueFacets(){} // RVA: 0x756A020
        public void MatchEnumeration(){} // RVA: 0x756A1A0
        public void CheckTotalAndFractionDigits(){} // RVA: 0x756A310
        public void .cctor(){} // RVA: 0x756A910
    }

    public class Numeric2FacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x756ADE0
        public void MatchEnumeration(){} // RVA: 0x756AF20
        public void .ctor(){} // RVA: 0xB43310
    }

}