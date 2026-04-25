// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Buffers.Text
// Classes: 8
// Methods: 130

namespace ThirdParty.DotNet.System.Buffers.Text
{
    public class Base64 : Object
    {
        public sbyte[] s_decodingMap;
        public byte[] s_encodingMap; // 0x8

        // ── Methods ──
        public void DecodeFromUtf8(){} // RVA: 0x7FFAC8A59B50
        public void GetMaxDecodedFromUtf8Length(){} // RVA: 0x7FFAC8A5A000
        public void DecodeFromUtf8InPlace(){} // RVA: 0x7FFAC8A5A020
        public void Decode(){} // RVA: 0x7FFAC85A8660
        public void WriteThreeLowOrderBytes(){} // RVA: 0x7FFAC85131D0
        public void EncodeToUtf8(){} // RVA: 0x7FFAC8A5A2F0
        public void GetMaxEncodedToUtf8Length(){} // RVA: 0x7FFAC8A5A6F0
        public void Encode(){} // RVA: 0x7FFAC85A8A40
        public void EncodeAndPadOne(){} // RVA: 0x7FFAC85A8AA0
        public void EncodeAndPadTwo(){} // RVA: 0x7FFAC85A8AF0
        public void .cctor(){} // RVA: 0x7FFAC8A5A720
    }

    public class FormattingHelpers : Object
    {
        // ── Methods ──
        public void GetSymbolOrDefault(){} // RVA: 0x7FFAC85A7AA0
        public void FillWithAsciiZeros(){} // RVA: 0x7FFAC8A5A950
        public void WriteHexByte(){} // RVA: 0x7FFAC8A5A9E0
        public void WriteDigits(){} // RVA: 0x7FFAC8A5ACF0 | overloaded x2
        public void WriteDigitsWithGroupSeparator(){} // RVA: 0x7FFAC8A5ABC0
        public void WriteFourDecimalDigits(){} // RVA: 0x7FFAC8A5ADE0
        public void WriteTwoDecimalDigits(){} // RVA: 0x7FFAC8A5AF40
        public void DivMod(){} // RVA: 0x7FFAC85A7F10 | overloaded x2
        public void CountDecimalTrailingZeros(){} // RVA: 0x7FFAC85A7F30
        public void CountDigits(){} // RVA: 0x7FFAC85A79E0 | overloaded x2
        public void CountHexDigits(){} // RVA: 0x7FFAC85A7A40
    }

    public class Number : Object
    {
        public ulong[] s_rgval64Power10;
        public sbyte[] s_rgexp64Power10; // 0x8
        public ulong[] s_rgval64Power10By16; // 0x10
        public short[] s_rgexp64Power10By16; // 0x18

        // ── Methods ──
        public void NumberBufferToDouble(){} // RVA: 0x7FFAC85B5D10
        public void NumberBufferToDecimal(){} // RVA: 0x7FFAC85B5DC0
        public void DecimalToNumber(){} // RVA: 0x7FFAC85B5F90
        public void DigitsToInt(){} // RVA: 0x7FFAC85B6230
        public void Mul32x32To64(){} // RVA: 0x7FFAC85B6350
        public void Mul64Lossy(){} // RVA: 0x7FFAC85B6360
        public void abs(){} // RVA: 0x7FFAC85B6400
        public void NumberToDouble(){} // RVA: 0x7FFAC85B6410
        public void RoundNumber(){} // RVA: 0x7FFAC85B6B10
        public void .cctor(){} // RVA: 0x7FFAC85B6C30
    }

    public class NumberBuffer : ValueType
    {
        public int Digits; // 0x10
        public bool UnsafeDigits; // 0x14
        public byte NumDigits; // 0x15
        public byte _b1; // 0x16
        public byte _b2; // 0x17
        public byte _b3; // 0x18
        public byte _b4; // 0x19
        public byte _b5; // 0x1A
        public byte _b6; // 0x1B
        public byte _b7; // 0x1C
        public byte _b8; // 0x1D
        public byte _b9; // 0x1E
        public byte _b10; // 0x1F
        public byte _b11; // 0x20
        public byte _b12; // 0x21
        public byte _b13; // 0x22
        public byte _b14; // 0x23
        public byte _b15; // 0x24
        public byte _b16; // 0x25
        public byte _b17; // 0x26
        public byte _b18; // 0x27
        public byte _b19; // 0x28
        public byte _b20; // 0x29
        public byte _b21; // 0x2A
        public byte _b22; // 0x2B
        public byte _b23; // 0x2C
        public byte _b24; // 0x2D
        public byte _b25; // 0x2E
        public byte _b26; // 0x2F
        public byte _b27; // 0x30
        public byte _b28; // 0x31
        public byte _b29; // 0x32
        public byte _b30; // 0x33
        public byte _b31; // 0x34
        public byte _b32; // 0x35
        public byte _b33; // 0x36
        public byte _b34; // 0x37
        public byte _b35; // 0x38
        public byte _b36; // 0x39
        public byte _b37; // 0x3A
        public byte _b38; // 0x3B
        public byte _b39; // 0x3C
        public byte _b40; // 0x3D
        public byte _b41; // 0x3E
        public byte _b42; // 0x3F
        public byte _b43; // 0x40
        public byte _b44; // 0x41
        public byte _b45; // 0x42
        public byte _b46; // 0x43
        public byte _b47; // 0x44
        public byte _b48; // 0x45
        public byte _b49; // 0x46
        public byte _b50; // 0x47

        // ── Methods ──
        public void get_Digits(){} // RVA: 0x7FFAC85B6F30
        public void get_UnsafeDigits(){} // RVA: 0x7FFAC85B6F80
        public void get_NumDigits(){} // RVA: 0x7FFAC85B6F90
        public void ToString(){} // RVA: 0x7FFAC85B7020
    }

    public class ParserHelpers : Object
    {
        public byte[] s_hexLookup;

        // ── Methods ──
        public void IsDigit(){} // RVA: 0x7FFAC85AE8F0
        public void .cctor(){} // RVA: 0x7FFAC8A60C30
    }

    public class Utf8Constants : Object
    {
        public System.TimeSpan s_nullUtcOffset;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8A5A8D0
    }

    public class Utf8Formatter : Object
    {
        public uint[] DayAbbreviations;
        public uint[] DayAbbreviationsLowercase; // 0x8
        public uint[] MonthAbbreviations; // 0x10
        public uint[] MonthAbbreviationsLowercase; // 0x18

        // ── Methods ──
        public void TryFormat(){} // RVA: 0x7FFAC85ADF10 | overloaded x16
        public void TryFormatDateTimeG(){} // RVA: 0x7FFAC85A8E70
        public void TryFormatDateTimeL(){} // RVA: 0x7FFAC85A9420
        public void TryFormatDateTimeO(){} // RVA: 0x7FFAC85A9880
        public void TryFormatDateTimeR(){} // RVA: 0x7FFAC85A9FC0
        public void TryFormatDecimalE(){} // RVA: 0x7FFAC85AA910
        public void TryFormatDecimalF(){} // RVA: 0x7FFAC85AABE0
        public void TryFormatDecimalG(){} // RVA: 0x7FFAC85AAEA0
        public void TryFormatFloatingPoint(){} // RVA: 0x7FFAC2E8DC40
        public void TryFormatInt64D(){} // RVA: 0x7FFAC85ABFD0
        public void TryFormatInt64Default(){} // RVA: 0x7FFAC85AC090
        public void TryFormatInt32MultipleDigits(){} // RVA: 0x7FFAC85AC1A0
        public void TryFormatInt64MultipleDigits(){} // RVA: 0x7FFAC85AC2F0
        public void TryFormatInt64MoreThanNegativeBillionMaxUInt(){} // RVA: 0x7FFAC85AC450
        public void TryFormatInt64LessThanNegativeBillionMaxUInt(){} // RVA: 0x7FFAC85AC5F0
        public void TryFormatInt64N(){} // RVA: 0x7FFAC85AC820
        public void TryFormatInt64(){} // RVA: 0x7FFAC85AC8E0
        public void TryFormatUInt64D(){} // RVA: 0x7FFAC85ACB50
        public void TryFormatUInt64Default(){} // RVA: 0x7FFAC85ACD40
        public void TryFormatUInt32SingleDigit(){} // RVA: 0x7FFAC85ACE50
        public void TryFormatUInt32MultipleDigits(){} // RVA: 0x7FFAC85ACED0
        public void TryFormatUInt64MultipleDigits(){} // RVA: 0x7FFAC85ACFA0
        public void TryFormatUInt64LessThanBillionMaxUInt(){} // RVA: 0x7FFAC85AD070
        public void TryFormatUInt64MoreThanBillionMaxUInt(){} // RVA: 0x7FFAC85AD1E0
        public void TryFormatUInt64N(){} // RVA: 0x7FFAC85AD3E0
        public void TryFormatUInt64X(){} // RVA: 0x7FFAC85AD6B0
        public void TryFormatUInt64(){} // RVA: 0x7FFAC85AD800
        public void .cctor(){} // RVA: 0x7FFAC85AE610
    }

    public class Utf8Parser : Object
    {
        public int[] s_daysToMonth365;
        public int[] s_daysToMonth366; // 0x8

        // ── Methods ──
        public void TryParse(){} // RVA: 0x7FFAC8A67360 | overloaded x14
        public void TryParseNormalAsFloatingPoint(){} // RVA: 0x7FFAC8A61520
        public void TryParseAsSpecialFloatingPoint(){} // RVA: 0x7FFAC2E8DC40
        public void TryParseGuidN(){} // RVA: 0x7FFAC8A61970
        public void TryParseGuidCore(){} // RVA: 0x7FFAC8A61DC0
        public void TryParseSByteD(){} // RVA: 0x7FFAC8A628D0
        public void TryParseInt16D(){} // RVA: 0x7FFAC8A62B80
        public void TryParseInt32D(){} // RVA: 0x7FFAC8A62EB0
        public void TryParseInt64D(){} // RVA: 0x7FFAC8A63340
        public void TryParseSByteN(){} // RVA: 0x7FFAC8A63620
        public void TryParseInt16N(){} // RVA: 0x7FFAC8A638C0
        public void TryParseInt32N(){} // RVA: 0x7FFAC8A63B50
        public void TryParseInt64N(){} // RVA: 0x7FFAC8A63E00
        public void TryParseByteD(){} // RVA: 0x7FFAC8A646D0
        public void TryParseUInt16D(){} // RVA: 0x7FFAC8A648E0
        public void TryParseUInt32D(){} // RVA: 0x7FFAC8A64B90
        public void TryParseUInt64D(){} // RVA: 0x7FFAC8A64F90
        public void TryParseByteN(){} // RVA: 0x7FFAC8A65170
        public void TryParseUInt16N(){} // RVA: 0x7FFAC8A653C0
        public void TryParseUInt32N(){} // RVA: 0x7FFAC8A65610
        public void TryParseUInt64N(){} // RVA: 0x7FFAC8A65880
        public void TryParseByteX(){} // RVA: 0x7FFAC8A65B00
        public void TryParseUInt16X(){} // RVA: 0x7FFAC8A65D60
        public void TryParseUInt32X(){} // RVA: 0x7FFAC8A65FC0
        public void TryParseUInt64X(){} // RVA: 0x7FFAC8A66220
        public void TryParseNumber(){} // RVA: 0x7FFAC8A664A0
        public void TryParseTimeSpanBigG(){} // RVA: 0x7FFAC8A66AF0
        public void TryParseTimeSpanC(){} // RVA: 0x7FFAC8A66FF0
        public void TryParseTimeSpanFraction(){} // RVA: 0x7FFAC8A674D0
        public void TryCreateTimeSpan(){} // RVA: 0x7FFAC85B4770
        public void TryParseTimeSpanLittleG(){} // RVA: 0x7FFAC8A67680
        public void .cctor(){} // RVA: 0x7FFAC8A67990
    }

}