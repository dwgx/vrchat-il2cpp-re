// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Unicode
// Classes: 3
// Methods: 13

namespace ThirdParty.DotNet.System.Text.Unicode
{
    public class UnicodeHelpers : Object
    {
        // ── Methods ──
        public void GetDefinedBmpCodePointsBitmapLittleEndian(){} // RVA: 0x7FFE86E2D5A0
        public void GetUtf16SurrogatePairFromAstralScalarValue(){} // RVA: 0x7FFE86E2CC70
        public void GetUtf8RepresentationForScalarValue(){} // RVA: 0x7FFE86E2D630
        public void get_DefinedCharsBitmapSpan(){} // RVA: 0x7FFE86E2D6B0
    }

    public class UnicodeRange : Object
    {
        public int _firstCodePoint; // 0x10
        public int _length; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE873749B0
        public void get_FirstCodePoint(){} // RVA: 0x7FFE811485C0
        public void set_FirstCodePoint(){} // RVA: 0x7FFE810FE0C0
        public void get_Length(){} // RVA: 0x7FFE8164B230
        public void set_Length(){} // RVA: 0x7FFE8164E0F0
        public void Create(){} // RVA: 0x7FFE87374A80
    }

    public class UnicodeRanges : Object
    {
        public System.Text.Unicode.UnicodeRange _all;
        public System.Text.Unicode.UnicodeRange _u0000; // 0x8

        // ── Methods ──
        public void get_All(){} // RVA: 0x7FFE87374B90
        public void CreateRange(){} // RVA: 0x7FFE87374BF0
        public void get_BasicLatin(){} // RVA: 0x7FFE87374D60
    }

}