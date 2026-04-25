// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 4
// Methods: 8

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class RangeContentValidator : ContentValidator
    {
        public System.Xml.Schema.BitSet firstpos; // 0x18
        public System.Xml.Schema.BitSet[] followpos; // 0x20
        public System.Xml.Schema.BitSet positionsWithRangeTerminals; // 0x28
        public System.Xml.Schema.SymbolsDictionary symbols; // 0x30
        public System.Xml.Schema.Positions positions; // 0x38
        public int minMaxNodesCount; // 0x40
        public int endMarkerPos; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9277040
        public void InitValidation(){} // RVA: 0x7FFAC9277270
        public void ValidateElement(){} // RVA: 0x7FFAC9277530
        public void CompleteValidation(){} // RVA: 0x7FFAC92782A0
        public void ExpectedElements(){} // RVA: 0x7FFAC92782C0
        public void ExpectedParticles(){} // RVA: 0x7FFAC9278680
    }

    public class RangePositionInfo : ValueType
    {
        public System.Xml.Schema.BitSet curpos; // 0x10
        public System.Decimal[] rangeCounters; // 0x18
    }

    public class RedefineEntry : Object
    {
        public System.Xml.Schema.XmlSchemaRedefine redefine; // 0x10
        public System.Xml.Schema.XmlSchema schemaToUpdate; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
    }

    public class RestrictionFacets : Object
    {
        public int Length; // 0x10
        public int MinLength; // 0x14
        public int MaxLength; // 0x18
        public System.Collections.ArrayList Patterns; // 0x20
        public System.Collections.ArrayList Enumeration; // 0x28
        public 0x6B1609D8 WhiteSpace; // 0x30
        public object MaxInclusive; // 0x38
        public object MaxExclusive; // 0x40
        public object MinInclusive; // 0x48
        public object MinExclusive; // 0x50
        public int TotalDigits; // 0x58
        public int FractionDigits; // 0x5C
        public 0x6B160980 Flags; // 0x60
        public 0x6B160980 FixedFlags; // 0x64

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}