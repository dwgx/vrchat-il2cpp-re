// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Buffers.Text
// Classes: 14
// Methods: 238

namespace ThirdParty.DotNet.System.Buffers.Text
{
    public class Base64
    {
        // ── Methods ──
        public void DecodeFromUtf8(){} // RVA: 0x62C27B0
        public void GetMaxDecodedFromUtf8Length(){} // RVA: 0x62C2C60
        public void DecodeFromUtf8InPlace(){} // RVA: 0x62C2C80
        public void Decode(){} // RVA: 0x5E10FF0
        public void WriteThreeLowOrderBytes(){} // RVA: 0x5D7BB40
        public void EncodeToUtf8(){} // RVA: 0x62C2F50
        public void GetMaxEncodedToUtf8Length(){} // RVA: 0x62C3350
        public void Encode(){} // RVA: 0x5E113D0
        public void EncodeAndPadOne(){} // RVA: 0x5E11430
        public void EncodeAndPadTwo(){} // RVA: 0x5E11480
        public void .cctor(){} // RVA: 0x62C3380
    }

    public class Base64
    {
        // ── Methods ──
        public void DecodeFromUtf8(){} // RVA: 0x5E10940
        public void GetMaxDecodedFromUtf8Length(){} // RVA: 0x5E10D40
        public void DecodeFromUtf8InPlace(){} // RVA: 0x5E10D60
        public void Decode(){} // RVA: 0x5E10FF0
        public void WriteThreeLowOrderBytes(){} // RVA: 0x5D7BB40
        public void EncodeToUtf8(){} // RVA: 0x5E11030
        public void GetMaxEncodedToUtf8Length(){} // RVA: 0x5E11390
        public void Encode(){} // RVA: 0x5E113D0
        public void EncodeAndPadOne(){} // RVA: 0x5E11430
        public void EncodeAndPadTwo(){} // RVA: 0x5E11480
        public void .cctor(){} // RVA: 0x5E114B0
    }

    public class FormattingHelpers
    {
        // ── Methods ──
        public void GetSymbolOrDefault(){} // RVA: 0x5E10430
        public void FillWithAsciiZeros(){} // RVA: 0x62C35B0
        public void WriteHexByte(){} // RVA: 0x62C3640
        public void WriteDigits(){} // RVA: 0x62C3950 | overloaded x2
        public void WriteDigitsWithGroupSeparator(){} // RVA: 0x62C3820
        public void WriteFourDecimalDigits(){} // RVA: 0x62C3A40
        public void WriteTwoDecimalDigits(){} // RVA: 0x62C3BA0
        public void DivMod(){} // RVA: 0x5E108A0 | overloaded x2
        public void CountDecimalTrailingZeros(){} // RVA: 0x5E108C0
        public void CountDigits(){} // RVA: 0x5E10370 | overloaded x2
        public void CountHexDigits(){} // RVA: 0x5E103D0
    }

    public class FormattingHelpers
    {
        // ── Methods ──
        public void CountDigits(){} // RVA: 0x5E10370 | overloaded x2
        public void CountHexDigits(){} // RVA: 0x5E103D0
        public void GetSymbolOrDefault(){} // RVA: 0x5E10430
        public void FillWithAsciiZeros(){} // RVA: 0x5E10440
        public void WriteHexByte(){} // RVA: 0x5E104A0
        public void WriteDigits(){} // RVA: 0x5E106B0 | overloaded x2
        public void WriteDigitsWithGroupSeparator(){} // RVA: 0x5E105D0
        public void WriteFourDecimalDigits(){} // RVA: 0x5E10760
        public void WriteTwoDecimalDigits(){} // RVA: 0x5E10820
        public void DivMod(){} // RVA: 0x5E108A0 | overloaded x2
        public void CountDecimalTrailingZeros(){} // RVA: 0x5E108C0
    }

    public class Number
    {
        // ── Methods ──
        public void NumberBufferToDouble(){} // RVA: 0x5E1E6A0
        public void NumberBufferToDecimal(){} // RVA: 0x5E1E750
        public void DecimalToNumber(){} // RVA: 0x5E1E920
        public void DigitsToInt(){} // RVA: 0x5E1EBC0
        public void Mul32x32To64(){} // RVA: 0x5E1ECE0
        public void Mul64Lossy(){} // RVA: 0x5E1ECF0
        public void abs(){} // RVA: 0x5E1ED90
        public void NumberToDouble(){} // RVA: 0x5E1EDA0
        public void RoundNumber(){} // RVA: 0x5E1F4A0
        public void .cctor(){} // RVA: 0x5E1F5C0
    }

    public class NumberBuffer
    {
        public int Handle; // 0x10
        public bool IsInvalid; // 0x14
        public byte _b0; // 0x15

        // ── Methods ──
        public void get_Digits(){} // RVA: 0x5E1F8C0
        public void get_UnsafeDigits(){} // RVA: 0x5E1F910
        public void get_NumDigits(){} // RVA: 0x5E1F920
        public void ToString(){} // RVA: 0x5E1F9B0
    }

    public class ParserHelpers
    {
        // ── Methods ──
        public void IsDigit(){} // RVA: 0x5E17280
        public void .cctor(){} // RVA: 0x62C9890
    }

    public class ParserHelpers
    {
        // ── Methods ──
        public void IsDigit(){} // RVA: 0x5E17280
        public void .cctor(){} // RVA: 0x5E17290
    }

    public class Utf8Constants
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x62C3530
    }

    public class Utf8Constants
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5E11660
    }

    public class Utf8Formatter
    {
        // ── Methods ──
        public void TryFormat(){} // RVA: 0x5E168A0 | overloaded x16
        public void TryFormatDateTimeG(){} // RVA: 0x5E11800
        public void TryFormatDateTimeL(){} // RVA: 0x5E11DB0
        public void TryFormatDateTimeO(){} // RVA: 0x5E12210
        public void TryFormatDateTimeR(){} // RVA: 0x5E12950
        public void TryFormatDecimalE(){} // RVA: 0x5E132A0
        public void TryFormatDecimalF(){} // RVA: 0x5E13570
        public void TryFormatDecimalG(){} // RVA: 0x5E13830
        public void TryFormatFloatingPoint(){} // RVA: 0x283FA0
        public void TryFormatInt64D(){} // RVA: 0x5E14960
        public void TryFormatInt64Default(){} // RVA: 0x5E14A20
        public void TryFormatInt32MultipleDigits(){} // RVA: 0x5E14B30
        public void TryFormatInt64MultipleDigits(){} // RVA: 0x5E14C80
        public void TryFormatInt64MoreThanNegativeBillionMaxUInt(){} // RVA: 0x5E14DE0
        public void TryFormatInt64LessThanNegativeBillionMaxUInt(){} // RVA: 0x5E14F80
        public void TryFormatInt64N(){} // RVA: 0x5E151B0
        public void TryFormatInt64(){} // RVA: 0x5E15270
        public void TryFormatUInt64D(){} // RVA: 0x5E154E0
        public void TryFormatUInt64Default(){} // RVA: 0x5E156D0
        public void TryFormatUInt32SingleDigit(){} // RVA: 0x5E157E0
        public void TryFormatUInt32MultipleDigits(){} // RVA: 0x5E15860
        public void TryFormatUInt64MultipleDigits(){} // RVA: 0x5E15930
        public void TryFormatUInt64LessThanBillionMaxUInt(){} // RVA: 0x5E15A00
        public void TryFormatUInt64MoreThanBillionMaxUInt(){} // RVA: 0x5E15B70
        public void TryFormatUInt64N(){} // RVA: 0x5E15D70
        public void TryFormatUInt64X(){} // RVA: 0x5E16040
        public void TryFormatUInt64(){} // RVA: 0x5E16190
        public void .cctor(){} // RVA: 0x5E16FA0
    }

    public class Utf8Formatter
    {
        // ── Methods ──
        public void TryFormat(){} // RVA: 0x62C8F80 | overloaded x9
        public void TryFormatDateTimeG(){} // RVA: 0x62C43C0
        public void TryFormatDateTimeO(){} // RVA: 0x62C4930
        public void TryFormatDateTimeR(){} // RVA: 0x62C50D0
        public void TryFormatDateTimeL(){} // RVA: 0x62C5650
        public void TryFormatDecimalE(){} // RVA: 0x62C5FC0
        public void TryFormatDecimalF(){} // RVA: 0x62C6470
        public void TryFormatDecimalG(){} // RVA: 0x62C6880
        public void TryFormatInt64(){} // RVA: 0x62C73F0
        public void TryFormatInt64D(){} // RVA: 0x62C76D0
        public void TryFormatInt64Default(){} // RVA: 0x62C7790
        public void TryFormatInt32MultipleDigits(){} // RVA: 0x62C7860
        public void TryFormatInt64MultipleDigits(){} // RVA: 0x62C79D0
        public void TryFormatInt64MoreThanNegativeBillionMaxUInt(){} // RVA: 0x62C7B40
        public void TryFormatInt64LessThanNegativeBillionMaxUInt(){} // RVA: 0x62C7CD0
        public void TryFormatInt64N(){} // RVA: 0x62C7EC0
        public void TryFormatUInt64(){} // RVA: 0x62C7F80
        public void TryFormatUInt64D(){} // RVA: 0x62C8260
        public void TryFormatUInt64Default(){} // RVA: 0x62C8420
        public void TryFormatUInt32SingleDigit(){} // RVA: 0x62C84F0
        public void TryFormatUInt32MultipleDigits(){} // RVA: 0x62C85C0
        public void TryFormatUInt64MultipleDigits(){} // RVA: 0x62C8690
        public void TryFormatUInt64LessThanBillionMaxUInt(){} // RVA: 0x62C8760
        public void TryFormatUInt64MoreThanBillionMaxUInt(){} // RVA: 0x62C88A0
        public void TryFormatUInt64N(){} // RVA: 0x62C8A40
        public void TryFormatUInt64X(){} // RVA: 0x62C8DC0
        public void .cctor(){} // RVA: 0x62C95B0
    }

    public class Utf8Parser
    {
        // ── Methods ──
        public void TryParse(){} // RVA: 0x62CFFC0 | overloaded x14
        public void TryParseNormalAsFloatingPoint(){} // RVA: 0x62CA180
        public void TryParseAsSpecialFloatingPoint(){} // RVA: 0x283FA0
        public void TryParseGuidN(){} // RVA: 0x62CA5D0
        public void TryParseGuidCore(){} // RVA: 0x62CAA20
        public void TryParseSByteD(){} // RVA: 0x62CB530
        public void TryParseInt16D(){} // RVA: 0x62CB7E0
        public void TryParseInt32D(){} // RVA: 0x62CBB10
        public void TryParseInt64D(){} // RVA: 0x62CBFA0
        public void TryParseSByteN(){} // RVA: 0x62CC280
        public void TryParseInt16N(){} // RVA: 0x62CC520
        public void TryParseInt32N(){} // RVA: 0x62CC7B0
        public void TryParseInt64N(){} // RVA: 0x62CCA60
        public void TryParseByteD(){} // RVA: 0x62CD330
        public void TryParseUInt16D(){} // RVA: 0x62CD540
        public void TryParseUInt32D(){} // RVA: 0x62CD7F0
        public void TryParseUInt64D(){} // RVA: 0x62CDBF0
        public void TryParseByteN(){} // RVA: 0x62CDDD0
        public void TryParseUInt16N(){} // RVA: 0x62CE020
        public void TryParseUInt32N(){} // RVA: 0x62CE270
        public void TryParseUInt64N(){} // RVA: 0x62CE4E0
        public void TryParseByteX(){} // RVA: 0x62CE760
        public void TryParseUInt16X(){} // RVA: 0x62CE9C0
        public void TryParseUInt32X(){} // RVA: 0x62CEC20
        public void TryParseUInt64X(){} // RVA: 0x62CEE80
        public void TryParseNumber(){} // RVA: 0x62CF100
        public void TryParseTimeSpanBigG(){} // RVA: 0x62CF750
        public void TryParseTimeSpanC(){} // RVA: 0x62CFC50
        public void TryParseTimeSpanFraction(){} // RVA: 0x62D0130
        public void TryCreateTimeSpan(){} // RVA: 0x5E1D100
        public void TryParseTimeSpanLittleG(){} // RVA: 0x62D02E0
        public void .cctor(){} // RVA: 0x62D05F0
    }

    public class Utf8Parser
    {
        // ── Methods ──
        public void TryParse(){} // RVA: 0x5E1CE60 | overloaded x14
        public void TryParseNormalAsFloatingPoint(){} // RVA: 0x5E17980
        public void TryParseAsSpecialFloatingPoint(){} // RVA: 0x283FA0
        public void TryParseGuidN(){} // RVA: 0x5E17D40
        public void TryParseGuidCore(){} // RVA: 0x5E18120
        public void TryParseSByteD(){} // RVA: 0x5E18590
        public void TryParseInt16D(){} // RVA: 0x5E187D0
        public void TryParseInt32D(){} // RVA: 0x5E18AA0
        public void TryParseInt64D(){} // RVA: 0x5E18ED0
        public void TryParseSByteN(){} // RVA: 0x5E19100
        public void TryParseInt16N(){} // RVA: 0x5E192F0
        public void TryParseInt32N(){} // RVA: 0x5E194E0
        public void TryParseInt64N(){} // RVA: 0x5E196E0
        public void TryParseByteD(){} // RVA: 0x5E19EC0
        public void TryParseUInt16D(){} // RVA: 0x5E1A0A0
        public void TryParseUInt32D(){} // RVA: 0x5E1A310
        public void TryParseUInt64D(){} // RVA: 0x5E1A6E0
        public void TryParseByteN(){} // RVA: 0x5E1A860
        public void TryParseUInt16N(){} // RVA: 0x5E1AA20
        public void TryParseUInt32N(){} // RVA: 0x5E1ABE0
        public void TryParseUInt64N(){} // RVA: 0x5E1ADB0
        public void TryParseByteX(){} // RVA: 0x5E1AFA0
        public void TryParseUInt16X(){} // RVA: 0x5E1B190
        public void TryParseUInt32X(){} // RVA: 0x5E1B380
        public void TryParseUInt64X(){} // RVA: 0x5E1B570
        public void TryParseNumber(){} // RVA: 0x5E1BD20
        public void TryParseTimeSpanBigG(){} // RVA: 0x5E1C2E0
        public void TryParseTimeSpanC(){} // RVA: 0x5E1C800
        public void TryParseTimeSpanLittleG(){} // RVA: 0x5E1CB60
        public void TryParseTimeSpanFraction(){} // RVA: 0x5E1CFA0
        public void TryCreateTimeSpan(){} // RVA: 0x5E1D100
        public void .cctor(){} // RVA: 0x5E1D1E0
    }

}