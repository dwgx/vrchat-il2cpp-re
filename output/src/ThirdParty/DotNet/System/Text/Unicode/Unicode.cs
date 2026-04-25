// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Unicode
// Classes: 3
// Methods: 13

namespace ThirdParty.DotNet.System.Text.Unicode
{
    public class UnicodeHelpers : Object
    {
        public object DefinedCharsBitmapSpan;

        // ── Methods ──
        public void GetDefinedBmpCodePointsBitmapLittleEndian(){} // RVA: 0x7FFAC8A83F10
        public void GetUtf16SurrogatePairFromAstralScalarValue(){} // RVA: 0x7FFAC8A835E0
        public void GetUtf8RepresentationForScalarValue(){} // RVA: 0x7FFAC8A83FA0
        public void get_DefinedCharsBitmapSpan(){} // RVA: 0x7FFAC8A84020
    }

    public class UnicodeRange : Object
    {
        public int FirstCodePoint; // 0x10
        public int Length; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FCC1F0
        public void get_FirstCodePoint(){} // RVA: 0x7FFAC2F6E5C0
        public void set_FirstCodePoint(){} // RVA: 0x7FFAC2F240C0
        public void get_Length(){} // RVA: 0x7FFAC33D5A20
        public void set_Length(){} // RVA: 0x7FFAC33D4990
        public void Create(){} // RVA: 0x7FFAC8FCC2C0
    }

    public class UnicodeRanges : Object
    {
        public System.Text.Unicode.UnicodeRange All;
        public System.Text.Unicode.UnicodeRange BasicLatin; // 0x8

        // ── Methods ──
        public void get_All(){} // RVA: 0x7FFAC8FCC3D0
        public void CreateRange(){} // RVA: 0x7FFAC8FCC430
        public void get_BasicLatin(){} // RVA: 0x7FFAC8FCC5A0
    }

}