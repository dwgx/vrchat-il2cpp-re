// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 11
// Methods: 45

namespace ThirdParty.DotNet.System.Xml
{
    public class UTF16Decoder : Decoder
    {
        public object bigEndian;
        public object lastByte;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74EF100
        public void GetCharCount(){} // RVA: 0x74EF110
        public void GetChars(){} // RVA: 0x74EF200
        public void Convert(){} // RVA: 0x74EF430
    }

    public class Ucs4Decoder : Decoder
    {
        public object lastBytes;
        public object lastBytesCount;

        // ── Methods ──
        public void GetCharCount(){} // RVA: 0x74F02D0
        public void GetFullChars(){} // RVA: 0x885B90
        public void GetChars(){} // RVA: 0x74F02E0
        public void Convert(){} // RVA: 0x74F04A0
        public void Ucs4ToUTF16(){} // RVA: 0x74F06F0
        public void .ctor(){} // RVA: 0x74F0760
    }

    public class Ucs4Decoder1234 : Ucs4Decoder
    {
        // ── Methods ──
        public void GetFullChars(){} // RVA: 0x74F0AC0
        public void .ctor(){} // RVA: 0x74F0AB0
    }

    public class Ucs4Decoder2143 : Ucs4Decoder
    {
        // ── Methods ──
        public void GetFullChars(){} // RVA: 0x74F0D80
        public void .ctor(){} // RVA: 0x74F0AB0
    }

    public class Ucs4Decoder3412 : Ucs4Decoder
    {
        // ── Methods ──
        public void GetFullChars(){} // RVA: 0x74F1040
        public void .ctor(){} // RVA: 0x74F0AB0
    }

    public class Ucs4Decoder4321 : Ucs4Decoder
    {
        // ── Methods ──
        public void GetFullChars(){} // RVA: 0x74F07F0
        public void .ctor(){} // RVA: 0x74F0AB0
    }

    public class Ucs4Encoding : Encoding
    {
        public object ucs4Decoder;

        // ── Methods ──
        public void get_WebName(){} // RVA: 0xCADE00
        public void GetDecoder(){} // RVA: 0xD05CA0
        public void GetByteCount(){} // RVA: 0x74EF8D0
        public void GetBytes(){} // RVA: 0xDAC980
        public void GetMaxByteCount(){} // RVA: 0xDAC980
        public void GetCharCount(){} // RVA: 0x74EF970
        public void GetChars(){} // RVA: 0x74EF920
        public void GetMaxCharCount(){} // RVA: 0x74EF960
        public void get_CodePage(){} // RVA: 0xDAC980
        public void GetEncoder(){} // RVA: 0xDAC980
        public void get_UCS4_Littleendian(){} // RVA: 0x74EF990
        public void get_UCS4_Bigendian(){} // RVA: 0x74EFA80
        public void get_UCS4_2143(){} // RVA: 0x74EFB70
        public void get_UCS4_3412(){} // RVA: 0x74EFC60
        public void .ctor(){} // RVA: 0x66D0BE0
    }

    public class Ucs4Encoding1234 : Ucs4Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74EFD50
        public void get_EncodingName(){} // RVA: 0x74EFE10
        public void GetPreamble(){} // RVA: 0x74EFE50
    }

    public class Ucs4Encoding2143 : Ucs4Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74F0010
        public void get_EncodingName(){} // RVA: 0x74F00D0
        public void GetPreamble(){} // RVA: 0x74F0110
    }

    public class Ucs4Encoding3412 : Ucs4Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74F0170
        public void get_EncodingName(){} // RVA: 0x74F0230
        public void GetPreamble(){} // RVA: 0x74F0270
    }

    public class Ucs4Encoding4321 : Ucs4Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74EFEB0
        public void get_EncodingName(){} // RVA: 0x74EFF70
        public void GetPreamble(){} // RVA: 0x74EFFB0
    }

}