// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 11
// Methods: 128

namespace ThirdParty.DotNet.System
{
    public class NUInt : ValueType
    {
        public void* _value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45BB120 | overloaded x2
        public void op_Explicit(){} // RVA: 0x7FFAC44F81E0 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7FFAC8A58D90
    }

    public class NonSerializedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NotImplemented : Object
    {
        public object ByDesign;

        // ── Methods ──
        public void get_ByDesign(){} // RVA: 0x7FFAC865D260
    }

    public class NotImplementedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class NotSupportedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x4
    }

    public class NullConsoleDriver : Object
    {
        public System.ConsoleKeyInfo EmptyConsoleKeyInfo;

        // ── Methods ──
        public void ReadKey(){} // RVA: 0x7FFAC86A2A70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC86A2AE0
    }

    public class NullReferenceException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class Nullable : Object
    {
        // ── Methods ──
        public void GetUnderlyingType(){} // RVA: 0x7FFAC8636F00
    }

    public class Nullable`1 : ValueType
    {
        public bool HasValue;
        public T Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void get_HasValue(){} // RVA: 0x7FFAC2C59D00
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
        public void GetValueOrDefault(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC2C59F60
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void Box(){} // RVA: 0x7FFAC2E8DC40
        public void Unbox(){} // RVA: 0x7FFAC2E8DC40
        public void UnboxExact(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Number : Object
    {
        public string[] s_posCurrencyFormats;
        public string[] s_negCurrencyFormats; // 0x8
        public string[] s_posPercentFormats; // 0x10
        public string[] s_negPercentFormats; // 0x18
        public string[] s_negNumberFormats; // 0x20
        public int[] s_charToHexLookup; // 0x28
        public ulong[] s_rgval64Power10; // 0x30
        public sbyte[] s_rgexp64Power10; // 0x38
        public ulong[] s_rgval64Power10By16; // 0x40
        public short[] s_rgexp64Power10By16; // 0x48

        // ── Methods ──
        public void FormatDecimal(){} // RVA: 0x7FFAC8637070
        public void TryFormatDecimal(){} // RVA: 0x7FFAC8637250
        public void DecimalToNumber(){} // RVA: 0x7FFAC8637440
        public void FormatDouble(){} // RVA: 0x7FFAC86379D0 | overloaded x2
        public void TryFormatDouble(){} // RVA: 0x7FFAC8637880
        public void FormatSingle(){} // RVA: 0x7FFAC8637F50 | overloaded x2
        public void TryFormatSingle(){} // RVA: 0x7FFAC8637E00
        public void TryCopyTo(){} // RVA: 0x7FFAC8638240
        public void FormatInt32(){} // RVA: 0x7FFAC86383B0
        public void TryFormatInt32(){} // RVA: 0x7FFAC86386A0
        public void FormatUInt32(){} // RVA: 0x7FFAC8638A10
        public void TryFormatUInt32(){} // RVA: 0x7FFAC8638CB0
        public void FormatInt64(){} // RVA: 0x7FFAC8638F90
        public void TryFormatInt64(){} // RVA: 0x7FFAC8639290
        public void FormatUInt64(){} // RVA: 0x7FFAC8639600
        public void TryFormatUInt64(){} // RVA: 0x7FFAC86398A0
        public void Int32ToNumber(){} // RVA: 0x7FFAC8639B90
        public void NegativeInt32ToDecStr(){} // RVA: 0x7FFAC8639C90
        public void TryNegativeInt32ToDecStr(){} // RVA: 0x7FFAC8639E00
        public void Int32ToHexStr(){} // RVA: 0x7FFAC8639FA0
        public void TryInt32ToHexStr(){} // RVA: 0x7FFAC863A0A0
        public void Int32ToHexChars(){} // RVA: 0x7FFAC863A1D0
        public void UInt32ToNumber(){} // RVA: 0x7FFAC863A210
        public void UInt32ToDecChars(){} // RVA: 0x7FFAC863A300
        public void UInt32ToDecStr(){} // RVA: 0x7FFAC863A360
        public void TryUInt32ToDecStr(){} // RVA: 0x7FFAC863A490
        public void Int64ToNumber(){} // RVA: 0x7FFAC863A600
        public void NegativeInt64ToDecStr(){} // RVA: 0x7FFAC863A7E0
        public void TryNegativeInt64ToDecStr(){} // RVA: 0x7FFAC863AA10
        public void Int64ToHexStr(){} // RVA: 0x7FFAC863AC80
        public void TryInt64ToHexStr(){} // RVA: 0x7FFAC863AE50
        public void UInt64ToNumber(){} // RVA: 0x7FFAC863B050
        public void UInt64ToDecStr(){} // RVA: 0x7FFAC863B210
        public void TryUInt64ToDecStr(){} // RVA: 0x7FFAC863B3F0
        public void ParseFormatSpecifier(){} // RVA: 0x7FFAC863B5F0
        public void NumberToString(){} // RVA: 0x7FFAC863B790
        public void NumberToStringFormat(){} // RVA: 0x7FFAC863BE20
        public void FormatCurrency(){} // RVA: 0x7FFAC863CB00
        public void FormatFixed(){} // RVA: 0x7FFAC863CD60
        public void FormatNumber(){} // RVA: 0x7FFAC863D240
        public void FormatScientific(){} // RVA: 0x7FFAC863D430
        public void FormatExponent(){} // RVA: 0x7FFAC863D560
        public void FormatGeneral(){} // RVA: 0x7FFAC863D740
        public void FormatPercent(){} // RVA: 0x7FFAC863D9B0
        public void RoundNumber(){} // RVA: 0x7FFAC863DC20
        public void FindSection(){} // RVA: 0x7FFAC863DCF0
        public void Low32(){} // RVA: 0x7FFAC4BE6C10
        public void High32(){} // RVA: 0x7FFAC863DE00
        public void Int64DivMod1E9(){} // RVA: 0x7FFAC863DE10
        public void NumberToInt32(){} // RVA: 0x7FFAC863DE60
        public void NumberToInt64(){} // RVA: 0x7FFAC863DEC0
        public void NumberToUInt32(){} // RVA: 0x7FFAC863DF30
        public void NumberToUInt64(){} // RVA: 0x7FFAC863DF90
        public void ParseInt32(){} // RVA: 0x7FFAC863E000
        public void ParseInt64(){} // RVA: 0x7FFAC863E240
        public void ParseUInt32(){} // RVA: 0x7FFAC863E490
        public void ParseUInt64(){} // RVA: 0x7FFAC863E6D0
        public void ParseNumber(){} // RVA: 0x7FFAC863E910
        public void TryParseInt32(){} // RVA: 0x7FFAC863F490
        public void TryParseInt32IntegerStyle(){} // RVA: 0x7FFAC863F670
        public void TryParseInt64IntegerStyle(){} // RVA: 0x7FFAC863FCE0
        public void TryParseInt64(){} // RVA: 0x7FFAC8640340
        public void TryParseUInt32(){} // RVA: 0x7FFAC8640530
        public void TryParseUInt32IntegerStyle(){} // RVA: 0x7FFAC8640720
        public void TryParseUInt32HexNumberStyle(){} // RVA: 0x7FFAC8640D50
        public void TryParseUInt64(){} // RVA: 0x7FFAC86410B0
        public void TryParseUInt64IntegerStyle(){} // RVA: 0x7FFAC86412B0
        public void TryParseUInt64HexNumberStyle(){} // RVA: 0x7FFAC86418F0
        public void ParseDecimal(){} // RVA: 0x7FFAC8641C50
        public void NumberBufferToDecimal(){} // RVA: 0x7FFAC8641D80
        public void ParseDouble(){} // RVA: 0x7FFAC8642120
        public void ParseSingle(){} // RVA: 0x7FFAC8642460
        public void TryParseDecimal(){} // RVA: 0x7FFAC86427D0
        public void TryParseDouble(){} // RVA: 0x7FFAC86428F0
        public void TryParseSingle(){} // RVA: 0x7FFAC8642A10
        public void StringToNumber(){} // RVA: 0x7FFAC8642BA0
        public void TryStringToNumber(){} // RVA: 0x7FFAC8642D40
        public void TrailingZeros(){} // RVA: 0x7FFAC8642EC0
        public void MatchChars(){} // RVA: 0x7FFAC8642F40
        public void IsWhite(){} // RVA: 0x7FFAC8642FA0
        public void IsDigit(){} // RVA: 0x7FFAC85AE8F0
        public void ThrowOverflowOrFormatException(){} // RVA: 0x7FFAC8642FC0
        public void NumberBufferToDouble(){} // RVA: 0x7FFAC8643050
        public void DigitsToInt(){} // RVA: 0x7FFAC8643100
        public void Mul32x32To64(){} // RVA: 0x7FFAC85B6350
        public void Mul64Lossy(){} // RVA: 0x7FFAC8643140
        public void abs(){} // RVA: 0x7FFAC85B6400
        public void NumberToDouble(){} // RVA: 0x7FFAC86431E0
        public void DoubleToNumber(){} // RVA: 0x7FFAC8643860
        public void .cctor(){} // RVA: 0x7FFAC8643990
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
        public void get_Digits(){} // RVA: 0x7FFAC8A56E20
        public void get_UnsafeDigits(){} // RVA: 0x7FFAC85B6F80
        public void get_NumDigits(){} // RVA: 0x7FFAC8A56E90
        public void ToString(){} // RVA: 0x7FFAC8A56F60
    }

}