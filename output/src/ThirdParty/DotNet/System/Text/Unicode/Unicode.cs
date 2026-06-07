// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Unicode
// Classes: 3
// Methods: 13

namespace ThirdParty.DotNet.System.Text.Unicode
{
    public class UnicodeHelpers
    {
        public object FirstCodePoint;

        // ── Methods ──
        public void GetDefinedBmpCodePointsBitmapLittleEndian(){} // RVA: 0x62ECB70
        public void GetUtf16SurrogatePairFromAstralScalarValue(){} // RVA: 0x62EC240
        public void GetUtf8RepresentationForScalarValue(){} // RVA: 0x62ECC00
        public void get_DefinedCharsBitmapSpan(){} // RVA: 0x62ECC80
    }

    public class UnicodeRange
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68356D0
        public void get_FirstCodePoint(){} // RVA: 0x32A5C0
        public void set_FirstCodePoint(){} // RVA: 0x2E00C0
        public void get_Length(){} // RVA: 0x8ABED0
        public void set_Length(){} // RVA: 0x8AC660
        public void Create(){} // RVA: 0x68357A0
    }

    public class UnicodeRanges
    {
        public object IsAscii;
        public object IsBmp;

        // ── Methods ──
        public void get_All(){} // RVA: 0x68358B0
        public void CreateRange(){} // RVA: 0x6835910
        public void get_BasicLatin(){} // RVA: 0x6835A80
    }

}