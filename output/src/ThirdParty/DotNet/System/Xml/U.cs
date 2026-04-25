// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 11
// Methods: 49

namespace ThirdParty.DotNet.System.Xml
{
    public class UTF16Decoder : Decoder
    {
        public bool bigEndian; // 0x20
        public int lastByte; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9220B40
        public void GetCharCount(){} // RVA: 0x7FFAC9220B50 | overloaded x2
        public void GetChars(){} // RVA: 0x7FFAC9220C50
        public void Convert(){} // RVA: 0x7FFAC9220E50
    }

    public class Ucs4Decoder : Decoder
    {
        public byte[] lastBytes; // 0x20
        public int lastBytesCount; // 0x28

        // ── Methods ──
        public void GetCharCount(){} // RVA: 0x7FFAC9221C70
        public void GetFullChars(){}
        public void GetChars(){} // RVA: 0x7FFAC9221C80
        public void Convert(){} // RVA: 0x7FFAC9221E30
        public void Ucs4ToUTF16(){} // RVA: 0x7FFAC9222050
        public void .ctor(){} // RVA: 0x7FFAC92220C0
    }

    public class Ucs4Decoder1234 : Ucs4Decoder
    {
        // ── Methods ──
        public void GetFullChars(){} // RVA: 0x7FFAC9222410
        public void .ctor(){} // RVA: 0x7FFAC9222400
    }

    public class Ucs4Decoder2143 : Ucs4Decoder
    {
        // ── Methods ──
        public void GetFullChars(){} // RVA: 0x7FFAC92226C0
        public void .ctor(){} // RVA: 0x7FFAC9222400
    }

    public class Ucs4Decoder3412 : Ucs4Decoder
    {
        // ── Methods ──
        public void GetFullChars(){} // RVA: 0x7FFAC9222970
        public void .ctor(){} // RVA: 0x7FFAC9222400
    }

    public class Ucs4Decoder4321 : Ucs4Decoder
    {
        // ── Methods ──
        public void GetFullChars(){} // RVA: 0x7FFAC9222150
        public void .ctor(){} // RVA: 0x7FFAC9222400
    }

    public class Ucs4Encoding : Encoding
    {
        public System.Xml.Ucs4Decoder WebName; // 0x38

        // ── Methods ──
        public void get_WebName(){} // RVA: 0x7FFAC30821C0
        public void GetDecoder(){} // RVA: 0x7FFAC31D0140
        public void GetByteCount(){} // RVA: 0x7FFAC9221270 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFAC34F9180 | overloaded x2
        public void GetMaxByteCount(){} // RVA: 0x7FFAC34F9180
        public void GetCharCount(){} // RVA: 0x7FFAC9221310 | overloaded x2
        public void GetChars(){} // RVA: 0x7FFAC92212C0
        public void GetMaxCharCount(){} // RVA: 0x7FFAC9221300
        public void get_CodePage(){} // RVA: 0x7FFAC34F9180
        public void GetEncoder(){} // RVA: 0x7FFAC34F9180
        public void get_UCS4_Littleendian(){} // RVA: 0x7FFAC9221330
        public void get_UCS4_Bigendian(){} // RVA: 0x7FFAC9221420
        public void get_UCS4_2143(){} // RVA: 0x7FFAC9221510
        public void get_UCS4_3412(){} // RVA: 0x7FFAC9221600
        public void .ctor(){} // RVA: 0x7FFAC83F00A0
    }

    public class Ucs4Encoding1234 : Ucs4Encoding
    {
        public object EncodingName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92216F0
        public void get_EncodingName(){} // RVA: 0x7FFAC92217B0
        public void GetPreamble(){} // RVA: 0x7FFAC92217F0
    }

    public class Ucs4Encoding2143 : Ucs4Encoding
    {
        public object EncodingName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92219B0
        public void get_EncodingName(){} // RVA: 0x7FFAC9221A70
        public void GetPreamble(){} // RVA: 0x7FFAC9221AB0
    }

    public class Ucs4Encoding3412 : Ucs4Encoding
    {
        public object EncodingName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9221B10
        public void get_EncodingName(){} // RVA: 0x7FFAC9221BD0
        public void GetPreamble(){} // RVA: 0x7FFAC9221C10
    }

    public class Ucs4Encoding4321 : Ucs4Encoding
    {
        public object EncodingName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9221850
        public void get_EncodingName(){} // RVA: 0x7FFAC9221910
        public void GetPreamble(){} // RVA: 0x7FFAC9221950
    }

}