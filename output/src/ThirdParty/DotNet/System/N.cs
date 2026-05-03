// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 11
// Methods: 128

namespace ThirdParty.DotNet.System
{
    public class NUInt : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82889220 | overloaded x2
        public void op_Explicit(){} // RVA: 0x7FFE827C4A80 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7FFE86E02420
    }

    public class NonSerializedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NotImplemented : Object
    {
        // ── Methods ──
        public void get_ByDesign(){} // RVA: 0x7FFE86A06A50
    }

    public class NotImplementedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class NotSupportedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x4
    }

    public class NullConsoleDriver : Object
    {
        // ── Methods ──
        public void ReadKey(){} // RVA: 0x7FFE86A4C220
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86A4C290
    }

    public class NullReferenceException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class Nullable : Object
    {
        // ── Methods ──
        public void GetUnderlyingType(){} // RVA: 0x7FFE869E06F0
    }

    public class Nullable`1 : ValueType
    {
        public bool hasValue;
        public T value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_HasValue(){} // RVA: 0x7FFE80E2F150
        public void get_Value(){} // RVA: 0x7FFE810A1420
        public void GetValueOrDefault(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void Box(){} // RVA: 0x7FFE810A1420
        public void Unbox(){} // RVA: 0x7FFE810A1420
        public void UnboxExact(){} // RVA: 0x7FFE810A1420
    }

    public class Number : Object
    {
        // ── Methods ──
        public void FormatDecimal(){} // RVA: 0x7FFE869E0860
        public void TryFormatDecimal(){} // RVA: 0x7FFE869E0A40
        public void DecimalToNumber(){} // RVA: 0x7FFE869E0C30
        public void FormatDouble(){} // RVA: 0x7FFE869E11C0 | overloaded x2
        public void TryFormatDouble(){} // RVA: 0x7FFE869E1070
        public void FormatSingle(){} // RVA: 0x7FFE869E1740 | overloaded x2
        public void TryFormatSingle(){} // RVA: 0x7FFE869E15F0
        public void TryCopyTo(){} // RVA: 0x7FFE869E1A30
        public void FormatInt32(){} // RVA: 0x7FFE869E1BA0
        public void TryFormatInt32(){} // RVA: 0x7FFE869E1E90
        public void FormatUInt32(){} // RVA: 0x7FFE869E2200
        public void TryFormatUInt32(){} // RVA: 0x7FFE869E24A0
        public void FormatInt64(){} // RVA: 0x7FFE869E2780
        public void TryFormatInt64(){} // RVA: 0x7FFE869E2A80
        public void FormatUInt64(){} // RVA: 0x7FFE869E2DF0
        public void TryFormatUInt64(){} // RVA: 0x7FFE869E3090
        public void Int32ToNumber(){} // RVA: 0x7FFE869E3380
        public void NegativeInt32ToDecStr(){} // RVA: 0x7FFE869E3480
        public void TryNegativeInt32ToDecStr(){} // RVA: 0x7FFE869E35F0
        public void Int32ToHexStr(){} // RVA: 0x7FFE869E3790
        public void TryInt32ToHexStr(){} // RVA: 0x7FFE869E3890
        public void Int32ToHexChars(){} // RVA: 0x7FFE869E39C0
        public void UInt32ToNumber(){} // RVA: 0x7FFE869E3A00
        public void UInt32ToDecChars(){} // RVA: 0x7FFE869E3AF0
        public void UInt32ToDecStr(){} // RVA: 0x7FFE869E3B50
        public void TryUInt32ToDecStr(){} // RVA: 0x7FFE869E3C80
        public void Int64ToNumber(){} // RVA: 0x7FFE869E3DF0
        public void NegativeInt64ToDecStr(){} // RVA: 0x7FFE869E3FD0
        public void TryNegativeInt64ToDecStr(){} // RVA: 0x7FFE869E4200
        public void Int64ToHexStr(){} // RVA: 0x7FFE869E4470
        public void TryInt64ToHexStr(){} // RVA: 0x7FFE869E4640
        public void UInt64ToNumber(){} // RVA: 0x7FFE869E4840
        public void UInt64ToDecStr(){} // RVA: 0x7FFE869E4A00
        public void TryUInt64ToDecStr(){} // RVA: 0x7FFE869E4BE0
        public void ParseFormatSpecifier(){} // RVA: 0x7FFE869E4DE0
        public void NumberToString(){} // RVA: 0x7FFE869E4F80
        public void NumberToStringFormat(){} // RVA: 0x7FFE869E5610
        public void FormatCurrency(){} // RVA: 0x7FFE869E62F0
        public void FormatFixed(){} // RVA: 0x7FFE869E6550
        public void FormatNumber(){} // RVA: 0x7FFE869E6A30
        public void FormatScientific(){} // RVA: 0x7FFE869E6C20
        public void FormatExponent(){} // RVA: 0x7FFE869E6D50
        public void FormatGeneral(){} // RVA: 0x7FFE869E6F30
        public void FormatPercent(){} // RVA: 0x7FFE869E71A0
        public void RoundNumber(){} // RVA: 0x7FFE869E7410
        public void FindSection(){} // RVA: 0x7FFE869E74E0
        public void Low32(){} // RVA: 0x7FFE82E53610
        public void High32(){} // RVA: 0x7FFE869E75F0
        public void Int64DivMod1E9(){} // RVA: 0x7FFE869E7600
        public void NumberToInt32(){} // RVA: 0x7FFE869E7650
        public void NumberToInt64(){} // RVA: 0x7FFE869E76B0
        public void NumberToUInt32(){} // RVA: 0x7FFE869E7720
        public void NumberToUInt64(){} // RVA: 0x7FFE869E7780
        public void ParseInt32(){} // RVA: 0x7FFE869E77F0
        public void ParseInt64(){} // RVA: 0x7FFE869E7A30
        public void ParseUInt32(){} // RVA: 0x7FFE869E7C80
        public void ParseUInt64(){} // RVA: 0x7FFE869E7EC0
        public void ParseNumber(){} // RVA: 0x7FFE869E8100
        public void TryParseInt32(){} // RVA: 0x7FFE869E8C80
        public void TryParseInt32IntegerStyle(){} // RVA: 0x7FFE869E8E60
        public void TryParseInt64IntegerStyle(){} // RVA: 0x7FFE869E94D0
        public void TryParseInt64(){} // RVA: 0x7FFE869E9B30
        public void TryParseUInt32(){} // RVA: 0x7FFE869E9D20
        public void TryParseUInt32IntegerStyle(){} // RVA: 0x7FFE869E9F10
        public void TryParseUInt32HexNumberStyle(){} // RVA: 0x7FFE869EA540
        public void TryParseUInt64(){} // RVA: 0x7FFE869EA8A0
        public void TryParseUInt64IntegerStyle(){} // RVA: 0x7FFE869EAAA0
        public void TryParseUInt64HexNumberStyle(){} // RVA: 0x7FFE869EB0E0
        public void ParseDecimal(){} // RVA: 0x7FFE869EB440
        public void NumberBufferToDecimal(){} // RVA: 0x7FFE869EB570
        public void ParseDouble(){} // RVA: 0x7FFE869EB910
        public void ParseSingle(){} // RVA: 0x7FFE869EBC50
        public void TryParseDecimal(){} // RVA: 0x7FFE869EBFC0
        public void TryParseDouble(){} // RVA: 0x7FFE869EC0E0
        public void TryParseSingle(){} // RVA: 0x7FFE869EC200
        public void StringToNumber(){} // RVA: 0x7FFE869EC390
        public void TryStringToNumber(){} // RVA: 0x7FFE869EC530
        public void TrailingZeros(){} // RVA: 0x7FFE869EC6B0
        public void MatchChars(){} // RVA: 0x7FFE869EC730
        public void IsWhite(){} // RVA: 0x7FFE869EC790
        public void IsDigit(){} // RVA: 0x7FFE869580C0
        public void ThrowOverflowOrFormatException(){} // RVA: 0x7FFE869EC7B0
        public void NumberBufferToDouble(){} // RVA: 0x7FFE869EC840
        public void DigitsToInt(){} // RVA: 0x7FFE869EC8F0
        public void Mul32x32To64(){} // RVA: 0x7FFE8695FB20
        public void Mul64Lossy(){} // RVA: 0x7FFE869EC930
        public void abs(){} // RVA: 0x7FFE8695FBD0
        public void NumberToDouble(){} // RVA: 0x7FFE869EC9D0
        public void DoubleToNumber(){} // RVA: 0x7FFE869ED050
        public void .cctor(){} // RVA: 0x7FFE869ED180
    }

    public class NumberBuffer : ValueType
    {
        public int Scale; // 0x10
        public bool IsNegative; // 0x14
        public byte _b0; // 0x15

        // ── Methods ──
        public void get_Digits(){} // RVA: 0x7FFE86E004B0
        public void get_UnsafeDigits(){} // RVA: 0x7FFE86960750
        public void get_NumDigits(){} // RVA: 0x7FFE86E00520
        public void ToString(){} // RVA: 0x7FFE86E005F0
    }

}