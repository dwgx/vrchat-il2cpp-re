// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Buffers.Text
// Classes: 14
// Methods: 183

namespace ThirdParty.DotNet.System.Buffers.Text
{
    public class Base64 : Object
    {
        public object s_decodingMap;
        public object s_encodingMap;

        // ── Methods ──
        public void DecodeFromUtf8(){} // RVA: 0x6D2F790
        public void GetMaxDecodedFromUtf8Length(){} // RVA: 0x6D2FC40
        public void DecodeFromUtf8InPlace(){} // RVA: 0x6D2FC60
        public void Decode(){} // RVA: 0x688A8B0
        public void WriteThreeLowOrderBytes(){} // RVA: 0x67F4AB0
        public void EncodeToUtf8(){} // RVA: 0x6D2FF30
        public void GetMaxEncodedToUtf8Length(){} // RVA: 0x6D30320
        public void Encode(){} // RVA: 0x688AC90
        public void EncodeAndPadOne(){} // RVA: 0x688ACF0
        public void EncodeAndPadTwo(){} // RVA: 0x688AD40
        public void .cctor(){} // RVA: 0x6D30350
    }

    public class Base64 : Object
    {
        public object s_decodingMap;
        public object s_encodingMap;

        // ── Methods ──
        public void DecodeFromUtf8(){} // RVA: 0x688A200
        public void GetMaxDecodedFromUtf8Length(){} // RVA: 0x688A600
        public void DecodeFromUtf8InPlace(){} // RVA: 0x688A620
        public void Decode(){} // RVA: 0x688A8B0
        public void WriteThreeLowOrderBytes(){} // RVA: 0x67F4AB0
        public void EncodeToUtf8(){} // RVA: 0x688A8F0
        public void GetMaxEncodedToUtf8Length(){} // RVA: 0x688AC50
        public void Encode(){} // RVA: 0x688AC90
        public void EncodeAndPadOne(){} // RVA: 0x688ACF0
        public void EncodeAndPadTwo(){} // RVA: 0x688AD40
        public void .cctor(){} // RVA: 0x688AD70
    }

    public class FormattingHelpers : Object
    {
        // ── Methods ──
        public void GetSymbolOrDefault(){} // RVA: 0x6889CE0
        public void FillWithAsciiZeros(){} // RVA: 0x6D30580
        public void WriteHexByte(){} // RVA: 0x6D30600
        public void WriteDigits(){} // RVA: 0x6D308F0
        public void WriteDigitsWithGroupSeparator(){} // RVA: 0x6D307D0
        public void WriteFourDecimalDigits(){} // RVA: 0x6D309D0
        public void WriteTwoDecimalDigits(){} // RVA: 0x6D30B20
        public void DivMod(){} // RVA: 0x688A160
        public void CountDecimalTrailingZeros(){} // RVA: 0x688A180
        public void CountDigits(){} // RVA: 0x6889C20
        public void CountHexDigits(){} // RVA: 0x6889C80
    }

    public class FormattingHelpers : Object
    {
        // ── Methods ──
        public void CountDigits(){} // RVA: 0x6889C20
        public void CountHexDigits(){} // RVA: 0x6889C80
        public void GetSymbolOrDefault(){} // RVA: 0x6889CE0
        public void FillWithAsciiZeros(){} // RVA: 0x6889CF0
        public void WriteHexByte(){} // RVA: 0x6889D60
        public void WriteDigits(){} // RVA: 0x6889F70
        public void WriteDigitsWithGroupSeparator(){} // RVA: 0x6889E90
        public void WriteFourDecimalDigits(){} // RVA: 0x688A020
        public void WriteTwoDecimalDigits(){} // RVA: 0x688A0E0
        public void DivMod(){} // RVA: 0x688A160
        public void CountDecimalTrailingZeros(){} // RVA: 0x688A180
    }

    public class Number : Object
    {
        public object s_rgval64Power10;
        public object s_rgexp64Power10;
        public object s_rgval64Power10By16;
        public object s_rgexp64Power10By16;

        // ── Methods ──
        public void NumberBufferToDouble(){} // RVA: 0x6897FE0
        public void NumberBufferToDecimal(){} // RVA: 0x6898090
        public void DecimalToNumber(){} // RVA: 0x6898360
        public void DigitsToInt(){} // RVA: 0x68985F0
        public void Mul32x32To64(){} // RVA: 0x6898710
        public void Mul64Lossy(){} // RVA: 0x6898720
        public void abs(){} // RVA: 0x68987C0
        public void NumberToDouble(){} // RVA: 0x68987D0
        public void RoundNumber(){} // RVA: 0x6898EA0
        public void .cctor(){} // RVA: 0x6898FC0
    }

    public class NumberBuffer : ValueType
    {
        public object Scale;
        public object IsNegative;
        public object _b0;
        public object _b1;
        public object _b2;
        public object _b3;
        public object _b4;
        public object _b5;
        public object _b6;
        public object _b7;
        public object _b8;
        public object _b9;
        public object _b10;
        public object _b11;
        public object _b12;
        public object _b13;
        public object _b14;
        public object _b15;
        public object _b16;
        public object _b17;
        public object _b18;
        public object _b19;
        public object _b20;
        public object _b21;
        public object _b22;
        public object _b23;
        public object _b24;
        public object _b25;
        public object _b26;
        public object _b27;
        public object _b28;
        public object _b29;
        public object _b30;
        public object _b31;
        public object _b32;
        public object _b33;
        public object _b34;
        public object _b35;
        public object _b36;
        public object _b37;
        public object _b38;
        public object _b39;
        public object _b40;
        public object _b41;
        public object _b42;
        public object _b43;
        public object _b44;
        public object _b45;
        public object _b46;
        public object _b47;
        public object _b48;
        public object _b49;
        public object _b50;

        // ── Methods ──
        public void get_Digits(){} // RVA: 0x68992C0
        public void get_UnsafeDigits(){} // RVA: 0x6899310
        public void get_NumDigits(){} // RVA: 0x6899320
        public void ToString(){} // RVA: 0x68993B0
    }

    public class ParserHelpers : Object
    {
        public object s_hexLookup;

        // ── Methods ──
        public void IsDigit(){} // RVA: 0x6890B30
        public void .cctor(){} // RVA: 0x6D36810
    }

    public class ParserHelpers : Object
    {
        public object s_hexLookup;

        // ── Methods ──
        public void IsDigit(){} // RVA: 0x6890B30
        public void .cctor(){} // RVA: 0x6890B40
    }

    public class Utf8Constants : Object
    {
        public object s_nullUtcOffset;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6D30500
    }

    public class Utf8Constants : Object
    {
        public object s_nullUtcOffset;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x688AF20
    }

    public class Utf8Formatter : Object
    {
        public object DayAbbreviations;
        public object DayAbbreviationsLowercase;
        public object MonthAbbreviations;
        public object MonthAbbreviationsLowercase;

        // ── Methods ──
        public void TryFormat(){} // RVA: 0x6890140
        public void TryFormatDateTimeG(){} // RVA: 0x688B0C0
        public void TryFormatDateTimeL(){} // RVA: 0x688B670
        public void TryFormatDateTimeO(){} // RVA: 0x688BAD0
        public void TryFormatDateTimeR(){} // RVA: 0x688C210
        public void TryFormatDecimalE(){} // RVA: 0x688CB60
        public void TryFormatDecimalF(){} // RVA: 0x688CE10
        public void TryFormatDecimalG(){} // RVA: 0x688D0D0
        public void TryFormatFloatingPoint(){} // RVA: 0xA94080
        public void TryFormatInt64D(){} // RVA: 0x688E210
        public void TryFormatInt64Default(){} // RVA: 0x688E2D0
        public void TryFormatInt32MultipleDigits(){} // RVA: 0x688E3E0
        public void TryFormatInt64MultipleDigits(){} // RVA: 0x688E530
        public void TryFormatInt64MoreThanNegativeBillionMaxUInt(){} // RVA: 0x688E690
        public void TryFormatInt64LessThanNegativeBillionMaxUInt(){} // RVA: 0x688E830
        public void TryFormatInt64N(){} // RVA: 0x688EA60
        public void TryFormatInt64(){} // RVA: 0x688EB20
        public void TryFormatUInt64D(){} // RVA: 0x688ED90
        public void TryFormatUInt64Default(){} // RVA: 0x688EF80
        public void TryFormatUInt32SingleDigit(){} // RVA: 0x688F090
        public void TryFormatUInt32MultipleDigits(){} // RVA: 0x688F110
        public void TryFormatUInt64MultipleDigits(){} // RVA: 0x688F1E0
        public void TryFormatUInt64LessThanBillionMaxUInt(){} // RVA: 0x688F2B0
        public void TryFormatUInt64MoreThanBillionMaxUInt(){} // RVA: 0x688F420
        public void TryFormatUInt64N(){} // RVA: 0x688F620
        public void TryFormatUInt64X(){} // RVA: 0x688F8F0
        public void TryFormatUInt64(){} // RVA: 0x688FA30
        public void .cctor(){} // RVA: 0x6890850
    }

    public class Utf8Formatter : Object
    {
        public object DayAbbreviations;
        public object DayAbbreviationsLowercase;
        public object MonthAbbreviations;
        public object MonthAbbreviationsLowercase;

        // ── Methods ──
        public void TryFormat(){} // RVA: 0x6D35EE0
        public void TryFormatDateTimeG(){} // RVA: 0x6D31350
        public void TryFormatDateTimeO(){} // RVA: 0x6D318B0
        public void TryFormatDateTimeR(){} // RVA: 0x6D32060
        public void TryFormatDateTimeL(){} // RVA: 0x6D325F0
        public void TryFormatDecimalE(){} // RVA: 0x6D32F70
        public void TryFormatDecimalF(){} // RVA: 0x6D333F0
        public void TryFormatDecimalG(){} // RVA: 0x6D33800
        public void TryFormatInt64(){} // RVA: 0x6D34360
        public void TryFormatInt64D(){} // RVA: 0x6D34640
        public void TryFormatInt64Default(){} // RVA: 0x6D34700
        public void TryFormatInt32MultipleDigits(){} // RVA: 0x6D347D0
        public void TryFormatInt64MultipleDigits(){} // RVA: 0x6D34940
        public void TryFormatInt64MoreThanNegativeBillionMaxUInt(){} // RVA: 0x6D34AB0
        public void TryFormatInt64LessThanNegativeBillionMaxUInt(){} // RVA: 0x6D34C40
        public void TryFormatInt64N(){} // RVA: 0x6D34E30
        public void TryFormatUInt64(){} // RVA: 0x6D34EF0
        public void TryFormatUInt64D(){} // RVA: 0x6D351D0
        public void TryFormatUInt64Default(){} // RVA: 0x6D35390
        public void TryFormatUInt32SingleDigit(){} // RVA: 0x6D35460
        public void TryFormatUInt32MultipleDigits(){} // RVA: 0x6D35530
        public void TryFormatUInt64MultipleDigits(){} // RVA: 0x6D35600
        public void TryFormatUInt64LessThanBillionMaxUInt(){} // RVA: 0x6D356D0
        public void TryFormatUInt64MoreThanBillionMaxUInt(){} // RVA: 0x6D35810
        public void TryFormatUInt64N(){} // RVA: 0x6D359B0
        public void TryFormatUInt64X(){} // RVA: 0x6D35D20
        public void .cctor(){} // RVA: 0x6D36530
    }

    public class Utf8Parser : Object
    {
        public object s_daysToMonth365;
        public object s_daysToMonth366;

        // ── Methods ──
        public void TryParse(){} // RVA: 0x6D3CD00
        public void TryParseNormalAsFloatingPoint(){} // RVA: 0x6D37080
        public void TryParseAsSpecialFloatingPoint(){} // RVA: 0xA94080
        public void TryParseGuidN(){} // RVA: 0x6D374D0
        public void TryParseGuidCore(){} // RVA: 0x6D37920
        public void TryParseSByteD(){} // RVA: 0x6D383E0
        public void TryParseInt16D(){} // RVA: 0x6D38680
        public void TryParseInt32D(){} // RVA: 0x6D389B0
        public void TryParseInt64D(){} // RVA: 0x6D38E40
        public void TryParseSByteN(){} // RVA: 0x6D39100
        public void TryParseInt16N(){} // RVA: 0x6D39390
        public void TryParseInt32N(){} // RVA: 0x6D39620
        public void TryParseInt64N(){} // RVA: 0x6D398C0
        public void TryParseByteD(){} // RVA: 0x6D3A190
        public void TryParseUInt16D(){} // RVA: 0x6D3A3A0
        public void TryParseUInt32D(){} // RVA: 0x6D3A650
        public void TryParseUInt64D(){} // RVA: 0x6D3AA50
        public void TryParseByteN(){} // RVA: 0x6D3AC30
        public void TryParseUInt16N(){} // RVA: 0x6D3AE70
        public void TryParseUInt32N(){} // RVA: 0x6D3B0B0
        public void TryParseUInt64N(){} // RVA: 0x6D3B310
        public void TryParseByteX(){} // RVA: 0x6D3B580
        public void TryParseUInt16X(){} // RVA: 0x6D3B7B0
        public void TryParseUInt32X(){} // RVA: 0x6D3B9E0
        public void TryParseUInt64X(){} // RVA: 0x6D3BC20
        public void TryParseNumber(){} // RVA: 0x6D3BE70
        public void TryParseTimeSpanBigG(){} // RVA: 0x6D3C4A0
        public void TryParseTimeSpanC(){} // RVA: 0x6D3C990
        public void TryParseTimeSpanFraction(){} // RVA: 0x6D3CE70
        public void TryCreateTimeSpan(){} // RVA: 0x6896A40
        public void TryParseTimeSpanLittleG(){} // RVA: 0x6D3D020
        public void .cctor(){} // RVA: 0x6D3D330
    }

    public class Utf8Parser : Object
    {
        public object s_daysToMonth365;
        public object s_daysToMonth366;

        // ── Methods ──
        public void TryParse(){} // RVA: 0x6896790
        public void TryParseNormalAsFloatingPoint(){} // RVA: 0x6891230
        public void TryParseAsSpecialFloatingPoint(){} // RVA: 0xA94080
        public void TryParseGuidN(){} // RVA: 0x68915F0
        public void TryParseGuidCore(){} // RVA: 0x68919D0
        public void TryParseSByteD(){} // RVA: 0x6891E40
        public void TryParseInt16D(){} // RVA: 0x6892080
        public void TryParseInt32D(){} // RVA: 0x6892350
        public void TryParseInt64D(){} // RVA: 0x6892780
        public void TryParseSByteN(){} // RVA: 0x68929C0
        public void TryParseInt16N(){} // RVA: 0x6892BB0
        public void TryParseInt32N(){} // RVA: 0x6892DA0
        public void TryParseInt64N(){} // RVA: 0x6892FA0
        public void TryParseByteD(){} // RVA: 0x6893780
        public void TryParseUInt16D(){} // RVA: 0x6893960
        public void TryParseUInt32D(){} // RVA: 0x6893BD0
        public void TryParseUInt64D(){} // RVA: 0x6893FA0
        public void TryParseByteN(){} // RVA: 0x6894140
        public void TryParseUInt16N(){} // RVA: 0x6894300
        public void TryParseUInt32N(){} // RVA: 0x68944C0
        public void TryParseUInt64N(){} // RVA: 0x6894690
        public void TryParseByteX(){} // RVA: 0x6894880
        public void TryParseUInt16X(){} // RVA: 0x6894A80
        public void TryParseUInt32X(){} // RVA: 0x6894C80
        public void TryParseUInt64X(){} // RVA: 0x6894E70
        public void TryParseNumber(){} // RVA: 0x6895650
        public void TryParseTimeSpanBigG(){} // RVA: 0x6895C20
        public void TryParseTimeSpanC(){} // RVA: 0x6896130
        public void TryParseTimeSpanLittleG(){} // RVA: 0x6896490
        public void TryParseTimeSpanFraction(){} // RVA: 0x68968D0
        public void TryCreateTimeSpan(){} // RVA: 0x6896A40
        public void .cctor(){} // RVA: 0x6896B20
    }

}