// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 3
// Methods: 8

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class RangeContentValidator : ContentValidator
    {
        public object firstpos;
        public object followpos;
        public object positionsWithRangeTerminals;
        public object symbols;
        public object positions;
        public object minMaxNodesCount;
        public object endMarkerPos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7544900
        public void InitValidation(){} // RVA: 0x7544B30
        public void ValidateElement(){} // RVA: 0x7544E10
        public void CompleteValidation(){} // RVA: 0x7545C10
        public void ExpectedElements(){} // RVA: 0x7545C30
        public void ExpectedParticles(){} // RVA: 0x7545FF0
    }

    public class RedefineEntry : Object
    {
        public object redefine;
        public object schemaToUpdate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
    }

    public class RestrictionFacets : Object
    {
        public object Length;
        public object MinLength;
        public object MaxLength;
        public object Patterns;
        public object Enumeration;
        public object WhiteSpace;
        public object MaxInclusive;
        public object MaxExclusive;
        public object MinInclusive;
        public object MinExclusive;
        public object TotalDigits;
        public object FractionDigits;
        public object Flags;
        public object FixedFlags;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

}