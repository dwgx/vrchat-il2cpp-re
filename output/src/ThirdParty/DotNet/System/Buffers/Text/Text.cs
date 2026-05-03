// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Buffers.Text
// Classes: 8
// Methods: 130

namespace ThirdParty.DotNet.System.Buffers.Text
{
    public class Base64 : Object
    {
        // ── Methods ──
        public void DecodeFromUtf8(){} // RVA: 0x7FFE86E031E0
        public void GetMaxDecodedFromUtf8Length(){} // RVA: 0x7FFE86E03690
        public void DecodeFromUtf8InPlace(){} // RVA: 0x7FFE86E036B0
        public void Decode(){} // RVA: 0x7FFE86951E30
        public void WriteThreeLowOrderBytes(){} // RVA: 0x7FFE868BC9D0
        public void EncodeToUtf8(){} // RVA: 0x7FFE86E03980
        public void GetMaxEncodedToUtf8Length(){} // RVA: 0x7FFE86E03D80
        public void Encode(){} // RVA: 0x7FFE86952210
        public void EncodeAndPadOne(){} // RVA: 0x7FFE86952270
        public void EncodeAndPadTwo(){} // RVA: 0x7FFE869522C0
        public void .cctor(){} // RVA: 0x7FFE86E03DB0
    }

    public class FormattingHelpers : Object
    {
        // ── Methods ──
        public void GetSymbolOrDefault(){} // RVA: 0x7FFE86951270
        public void FillWithAsciiZeros(){} // RVA: 0x7FFE86E03FE0
        public void WriteHexByte(){} // RVA: 0x7FFE86E04070
        public void WriteDigits(){} // RVA: 0x7FFE86E04380 | overloaded x2
        public void WriteDigitsWithGroupSeparator(){} // RVA: 0x7FFE86E04250
        public void WriteFourDecimalDigits(){} // RVA: 0x7FFE86E04470
        public void WriteTwoDecimalDigits(){} // RVA: 0x7FFE86E045D0
        public void DivMod(){} // RVA: 0x7FFE869516E0 | overloaded x2
        public void CountDecimalTrailingZeros(){} // RVA: 0x7FFE86951700
        public void CountDigits(){} // RVA: 0x7FFE869511B0 | overloaded x2
        public void CountHexDigits(){} // RVA: 0x7FFE86951210
    }

    public class Number : Object
    {
        // ── Methods ──
        public void NumberBufferToDouble(){} // RVA: 0x7FFE8695F4E0
        public void NumberBufferToDecimal(){} // RVA: 0x7FFE8695F590
        public void DecimalToNumber(){} // RVA: 0x7FFE8695F760
        public void DigitsToInt(){} // RVA: 0x7FFE8695FA00
        public void Mul32x32To64(){} // RVA: 0x7FFE8695FB20
        public void Mul64Lossy(){} // RVA: 0x7FFE8695FB30
        public void abs(){} // RVA: 0x7FFE8695FBD0
        public void NumberToDouble(){} // RVA: 0x7FFE8695FBE0
        public void RoundNumber(){} // RVA: 0x7FFE869602E0
        public void .cctor(){} // RVA: 0x7FFE86960400
    }

    public class NumberBuffer : ValueType
    {
        public int Scale; // 0x10
        public bool IsNegative; // 0x14
        public byte _b0; // 0x15

        // ── Methods ──
        public void get_Digits(){} // RVA: 0x7FFE86960700
        public void get_UnsafeDigits(){} // RVA: 0x7FFE86960750
        public void get_NumDigits(){} // RVA: 0x7FFE86960760
        public void ToString(){} // RVA: 0x7FFE869607F0
    }

    public class ParserHelpers : Object
    {
        // ── Methods ──
        public void IsDigit(){} // RVA: 0x7FFE869580C0
        public void .cctor(){} // RVA: 0x7FFE86E0A2C0
    }

    public class Utf8Constants : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86E03F60
    }

    public class Utf8Formatter : Object
    {
        // ── Methods ──
        public void TryFormat(){} // RVA: 0x7FFE869576E0 | overloaded x16
        public void TryFormatDateTimeG(){} // RVA: 0x7FFE86952640
        public void TryFormatDateTimeL(){} // RVA: 0x7FFE86952BF0
        public void TryFormatDateTimeO(){} // RVA: 0x7FFE86953050
        public void TryFormatDateTimeR(){} // RVA: 0x7FFE86953790
        public void TryFormatDecimalE(){} // RVA: 0x7FFE869540E0
        public void TryFormatDecimalF(){} // RVA: 0x7FFE869543B0
        public void TryFormatDecimalG(){} // RVA: 0x7FFE86954670
        public void TryFormatFloatingPoint(){} // RVA: 0x7FFE810A1420
        public void TryFormatInt64D(){} // RVA: 0x7FFE869557A0
        public void TryFormatInt64Default(){} // RVA: 0x7FFE86955860
        public void TryFormatInt32MultipleDigits(){} // RVA: 0x7FFE86955970
        public void TryFormatInt64MultipleDigits(){} // RVA: 0x7FFE86955AC0
        public void TryFormatInt64MoreThanNegativeBillionMaxUInt(){} // RVA: 0x7FFE86955C20
        public void TryFormatInt64LessThanNegativeBillionMaxUInt(){} // RVA: 0x7FFE86955DC0
        public void TryFormatInt64N(){} // RVA: 0x7FFE86955FF0
        public void TryFormatInt64(){} // RVA: 0x7FFE869560B0
        public void TryFormatUInt64D(){} // RVA: 0x7FFE86956320
        public void TryFormatUInt64Default(){} // RVA: 0x7FFE86956510
        public void TryFormatUInt32SingleDigit(){} // RVA: 0x7FFE86956620
        public void TryFormatUInt32MultipleDigits(){} // RVA: 0x7FFE869566A0
        public void TryFormatUInt64MultipleDigits(){} // RVA: 0x7FFE86956770
        public void TryFormatUInt64LessThanBillionMaxUInt(){} // RVA: 0x7FFE86956840
        public void TryFormatUInt64MoreThanBillionMaxUInt(){} // RVA: 0x7FFE869569B0
        public void TryFormatUInt64N(){} // RVA: 0x7FFE86956BB0
        public void TryFormatUInt64X(){} // RVA: 0x7FFE86956E80
        public void TryFormatUInt64(){} // RVA: 0x7FFE86956FD0
        public void .cctor(){} // RVA: 0x7FFE86957DE0
    }

    public class Utf8Parser : Object
    {
        // ── Methods ──
        public void TryParse(){} // RVA: 0x7FFE86E109F0 | overloaded x14
        public void TryParseNormalAsFloatingPoint(){} // RVA: 0x7FFE86E0ABB0
        public void TryParseAsSpecialFloatingPoint(){} // RVA: 0x7FFE810A1420
        public void TryParseGuidN(){} // RVA: 0x7FFE86E0B000
        public void TryParseGuidCore(){} // RVA: 0x7FFE86E0B450
        public void TryParseSByteD(){} // RVA: 0x7FFE86E0BF60
        public void TryParseInt16D(){} // RVA: 0x7FFE86E0C210
        public void TryParseInt32D(){} // RVA: 0x7FFE86E0C540
        public void TryParseInt64D(){} // RVA: 0x7FFE86E0C9D0
        public void TryParseSByteN(){} // RVA: 0x7FFE86E0CCB0
        public void TryParseInt16N(){} // RVA: 0x7FFE86E0CF50
        public void TryParseInt32N(){} // RVA: 0x7FFE86E0D1E0
        public void TryParseInt64N(){} // RVA: 0x7FFE86E0D490
        public void TryParseByteD(){} // RVA: 0x7FFE86E0DD60
        public void TryParseUInt16D(){} // RVA: 0x7FFE86E0DF70
        public void TryParseUInt32D(){} // RVA: 0x7FFE86E0E220
        public void TryParseUInt64D(){} // RVA: 0x7FFE86E0E620
        public void TryParseByteN(){} // RVA: 0x7FFE86E0E800
        public void TryParseUInt16N(){} // RVA: 0x7FFE86E0EA50
        public void TryParseUInt32N(){} // RVA: 0x7FFE86E0ECA0
        public void TryParseUInt64N(){} // RVA: 0x7FFE86E0EF10
        public void TryParseByteX(){} // RVA: 0x7FFE86E0F190
        public void TryParseUInt16X(){} // RVA: 0x7FFE86E0F3F0
        public void TryParseUInt32X(){} // RVA: 0x7FFE86E0F650
        public void TryParseUInt64X(){} // RVA: 0x7FFE86E0F8B0
        public void TryParseNumber(){} // RVA: 0x7FFE86E0FB30
        public void TryParseTimeSpanBigG(){} // RVA: 0x7FFE86E10180
        public void TryParseTimeSpanC(){} // RVA: 0x7FFE86E10680
        public void TryParseTimeSpanFraction(){} // RVA: 0x7FFE86E10B60
        public void TryCreateTimeSpan(){} // RVA: 0x7FFE8695DF40
        public void TryParseTimeSpanLittleG(){} // RVA: 0x7FFE86E10D10
        public void .cctor(){} // RVA: 0x7FFE86E11020
    }

}