// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.TMPro
// Classes: 4
// Methods: 31

namespace ThirdParty.Other.TMPro
{
    public class KerningPair : Object
    {
        // ── Methods ──
        public void get_firstGlyph(){} // RVA: 0xB8F8F0
        public void set_firstGlyph(){} // RVA: 0xB460A0
        public void get_firstGlyphAdjustments(){} // RVA: 0x371F080
        public void get_secondGlyph(){} // RVA: 0x15AF000
        public void set_secondGlyph(){} // RVA: 0x1FAA840
        public void get_secondGlyphAdjustments(){} // RVA: 0x19F92B0
        public void get_ignoreSpacingAdjustments(){} // RVA: 0xCB23E0
        public void .ctor(){} // RVA: 0x7A09360
        public void ConvertLegacyKerningData(){} // RVA: 0x7A09380
        public void .cctor(){} // RVA: 0x7A09390
    }

    public class KerningPairKey : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x944080
    }

    public class KerningPair[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class KerningTable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A09450
        public void AddKerningPair(){} // RVA: 0x7A09650
        public void AddGlyphPairAdjustmentRecord(){} // RVA: 0x7A097B0
        public void RemoveKerningPair(){} // RVA: 0x7A09A40
        public void SortKerningPairs(){} // RVA: 0x7A09AA0
    }

}