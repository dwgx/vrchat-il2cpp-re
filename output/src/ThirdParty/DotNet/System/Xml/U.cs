// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 11
// Methods: 49

namespace ThirdParty.DotNet.System.Xml
{
    public class UTF16Decoder : Decoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875C92B0
        public void GetCharCount(){} // RVA: 0x7FFE875C92C0 | overloaded x2
        public void GetChars(){} // RVA: 0x7FFE875C93C0
        public void Convert(){} // RVA: 0x7FFE875C95C0
    }

    public class Ucs4Decoder : Decoder
    {
        // ── Methods ──
        public void GetCharCount(){} // RVA: 0x7FFE875CA3E0
        public void GetFullChars(){}
        public void GetChars(){} // RVA: 0x7FFE875CA3F0
        public void Convert(){} // RVA: 0x7FFE875CA5A0
        public void Ucs4ToUTF16(){} // RVA: 0x7FFE875CA7C0
        public void .ctor(){} // RVA: 0x7FFE875CA830
    }

    public class Ucs4Decoder1234 : Ucs4Decoder
    {
        // ── Methods ──
        public void GetFullChars(){} // RVA: 0x7FFE875CAB80
        public void .ctor(){} // RVA: 0x7FFE875CAB70
    }

    public class Ucs4Decoder2143 : Ucs4Decoder
    {
        // ── Methods ──
        public void GetFullChars(){} // RVA: 0x7FFE875CAE30
        public void .ctor(){} // RVA: 0x7FFE875CAB70
    }

    public class Ucs4Decoder3412 : Ucs4Decoder
    {
        // ── Methods ──
        public void GetFullChars(){} // RVA: 0x7FFE875CB0E0
        public void .ctor(){} // RVA: 0x7FFE875CAB70
    }

    public class Ucs4Decoder4321 : Ucs4Decoder
    {
        // ── Methods ──
        public void GetFullChars(){} // RVA: 0x7FFE875CA8C0
        public void .ctor(){} // RVA: 0x7FFE875CAB70
    }

    public class Ucs4Encoding : Encoding
    {
        public System.Xml.Ucs4Decoder ucs4Decoder; // 0x38
        public object field_1; // 0x2CE
        public object field_2; // 0x2CF
        public object field_3; // 0x2D0
        public object field_4; // 0x2D1
        public object field_5; // 0x2D2

        // ── Methods ──
        public void get_WebName(){} // RVA: 0x7FFE8125C1C0
        public void GetDecoder(){} // RVA: 0x7FFE8143BA80
        public void GetByteCount(){} // RVA: 0x7FFE875C99E0 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFE813240E0 | overloaded x2
        public void GetMaxByteCount(){} // RVA: 0x7FFE813240E0
        public void GetCharCount(){} // RVA: 0x7FFE875C9A80 | overloaded x2
        public void GetChars(){} // RVA: 0x7FFE875C9A30
        public void GetMaxCharCount(){} // RVA: 0x7FFE875C9A70
        public void get_CodePage(){} // RVA: 0x7FFE813240E0
        public void GetEncoder(){} // RVA: 0x7FFE813240E0
        public void get_UCS4_Littleendian(){} // RVA: 0x7FFE875C9AA0
        public void get_UCS4_Bigendian(){} // RVA: 0x7FFE875C9B90
        public void get_UCS4_2143(){} // RVA: 0x7FFE875C9C80
        public void get_UCS4_3412(){} // RVA: 0x7FFE875C9D70
        public void .ctor(){} // RVA: 0x7FFE867999A0
    }

    public class Ucs4Encoding1234 : Ucs4Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875C9E60
        public void get_EncodingName(){} // RVA: 0x7FFE875C9F20
        public void GetPreamble(){} // RVA: 0x7FFE875C9F60
    }

    public class Ucs4Encoding2143 : Ucs4Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875CA120
        public void get_EncodingName(){} // RVA: 0x7FFE875CA1E0
        public void GetPreamble(){} // RVA: 0x7FFE875CA220
    }

    public class Ucs4Encoding3412 : Ucs4Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875CA280
        public void get_EncodingName(){} // RVA: 0x7FFE875CA340
        public void GetPreamble(){} // RVA: 0x7FFE875CA380
    }

    public class Ucs4Encoding4321 : Ucs4Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE875C9FC0
        public void get_EncodingName(){} // RVA: 0x7FFE875CA080
        public void GetPreamble(){} // RVA: 0x7FFE875CA0C0
    }

}