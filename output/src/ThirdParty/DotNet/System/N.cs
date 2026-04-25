// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 3
// Methods: 106

namespace ThirdParty.DotNet.System
{
    public class NullReferenceException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F917540 | overloaded x3
    }

    public class Nullable`1 : ValueType
    {
        public object HasValue;
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_HasValue(){} // RVA: 0x7FFD4E079D00
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
        public void GetValueOrDefault(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD4E079F60
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void Box(){} // RVA: 0x7FFD4E2ADC40
        public void Unbox(){} // RVA: 0x7FFD4E2ADC40
        public void UnboxExact(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Number : Object
    {
        // ── Methods ──
        public void FormatDecimal(){} // RVA: 0x7FFD53A57070
        public void TryFormatDecimal(){} // RVA: 0x7FFD53A57250
        public void DecimalToNumber(){} // RVA: 0x7FFD53A57440
        public void FormatDouble(){} // RVA: 0x7FFD53A579D0 | overloaded x2
        public void TryFormatDouble(){} // RVA: 0x7FFD53A57880
        public void FormatSingle(){} // RVA: 0x7FFD53A57F50 | overloaded x2
        public void TryFormatSingle(){} // RVA: 0x7FFD53A57E00
        public void TryCopyTo(){} // RVA: 0x7FFD53A58240
        public void FormatInt32(){} // RVA: 0x7FFD53A583B0
        public void TryFormatInt32(){} // RVA: 0x7FFD53A586A0
        public void FormatUInt32(){} // RVA: 0x7FFD53A58A10
        public void TryFormatUInt32(){} // RVA: 0x7FFD53A58CB0
        public void FormatInt64(){} // RVA: 0x7FFD53A58F90
        public void TryFormatInt64(){} // RVA: 0x7FFD53A59290
        public void FormatUInt64(){} // RVA: 0x7FFD53A59600
        public void TryFormatUInt64(){} // RVA: 0x7FFD53A598A0
        public void Int32ToNumber(){} // RVA: 0x7FFD53A59B90
        public void NegativeInt32ToDecStr(){} // RVA: 0x7FFD53A59C90
        public void TryNegativeInt32ToDecStr(){} // RVA: 0x7FFD53A59E00
        public void Int32ToHexStr(){} // RVA: 0x7FFD53A59FA0
        public void TryInt32ToHexStr(){} // RVA: 0x7FFD53A5A0A0
        public void Int32ToHexChars(){} // RVA: 0x7FFD53A5A1D0
        public void UInt32ToNumber(){} // RVA: 0x7FFD53A5A210
        public void UInt32ToDecChars(){} // RVA: 0x7FFD53A5A300
        public void UInt32ToDecStr(){} // RVA: 0x7FFD53A5A360
        public void TryUInt32ToDecStr(){} // RVA: 0x7FFD53A5A490
        public void Int64ToNumber(){} // RVA: 0x7FFD53A5A600
        public void NegativeInt64ToDecStr(){} // RVA: 0x7FFD53A5A7E0
        public void TryNegativeInt64ToDecStr(){} // RVA: 0x7FFD53A5AA10
        public void Int64ToHexStr(){} // RVA: 0x7FFD53A5AC80
        public void TryInt64ToHexStr(){} // RVA: 0x7FFD53A5AE50
        public void UInt64ToNumber(){} // RVA: 0x7FFD53A5B050
        public void UInt64ToDecStr(){} // RVA: 0x7FFD53A5B210
        public void TryUInt64ToDecStr(){} // RVA: 0x7FFD53A5B3F0
        public void ParseFormatSpecifier(){} // RVA: 0x7FFD53A5B5F0
        public void NumberToString(){} // RVA: 0x7FFD53A5B790
        public void NumberToStringFormat(){} // RVA: 0x7FFD53A5BE20
        public void FormatCurrency(){} // RVA: 0x7FFD53A5CB00
        public void FormatFixed(){} // RVA: 0x7FFD53A5CD60
        public void FormatNumber(){} // RVA: 0x7FFD53A5D240
        public void FormatScientific(){} // RVA: 0x7FFD53A5D430
        public void FormatExponent(){} // RVA: 0x7FFD53A5D560
        public void FormatGeneral(){} // RVA: 0x7FFD53A5D740
        public void FormatPercent(){} // RVA: 0x7FFD53A5D9B0
        public void RoundNumber(){} // RVA: 0x7FFD53A5DC20
        public void FindSection(){} // RVA: 0x7FFD53A5DCF0
        public void Low32(){} // RVA: 0x7FFD50006C10
        public void High32(){} // RVA: 0x7FFD53A5DE00
        public void Int64DivMod1E9(){} // RVA: 0x7FFD53A5DE10
        public void NumberToInt32(){} // RVA: 0x7FFD53A5DE60
        public void NumberToInt64(){} // RVA: 0x7FFD53A5DEC0
        public void NumberToUInt32(){} // RVA: 0x7FFD53A5DF30
        public void NumberToUInt64(){} // RVA: 0x7FFD53A5DF90
        public void ParseInt32(){} // RVA: 0x7FFD53A5E000
        public void ParseInt64(){} // RVA: 0x7FFD53A5E240
        public void ParseUInt32(){} // RVA: 0x7FFD53A5E490
        public void ParseUInt64(){} // RVA: 0x7FFD53A5E6D0
        public void ParseNumber(){} // RVA: 0x7FFD53A5E910
        public void TryParseInt32(){} // RVA: 0x7FFD53A5F490
        public void TryParseInt32IntegerStyle(){} // RVA: 0x7FFD53A5F670
        public void TryParseInt64IntegerStyle(){} // RVA: 0x7FFD53A5FCE0
        public void TryParseInt64(){} // RVA: 0x7FFD53A60340
        public void TryParseUInt32(){} // RVA: 0x7FFD53A60530
        public void TryParseUInt32IntegerStyle(){} // RVA: 0x7FFD53A60720
        public void TryParseUInt32HexNumberStyle(){} // RVA: 0x7FFD53A60D50
        public void TryParseUInt64(){} // RVA: 0x7FFD53A610B0
        public void TryParseUInt64IntegerStyle(){} // RVA: 0x7FFD53A612B0
        public void TryParseUInt64HexNumberStyle(){} // RVA: 0x7FFD53A618F0
        public void ParseDecimal(){} // RVA: 0x7FFD53A61C50
        public void NumberBufferToDecimal(){} // RVA: 0x7FFD53A61D80
        public void ParseDouble(){} // RVA: 0x7FFD53A62120
        public void ParseSingle(){} // RVA: 0x7FFD53A62460
        public void TryParseDecimal(){} // RVA: 0x7FFD53A627D0
        public void TryParseDouble(){} // RVA: 0x7FFD53A628F0
        public void TryParseSingle(){} // RVA: 0x7FFD53A62A10
        public void StringToNumber(){} // RVA: 0x7FFD53A62BA0
        public void TryStringToNumber(){} // RVA: 0x7FFD53A62D40
        public void TrailingZeros(){} // RVA: 0x7FFD53A62EC0
        public void MatchChars(){} // RVA: 0x7FFD53A62F40
        public void IsWhite(){} // RVA: 0x7FFD53A62FA0
        public void IsDigit(){} // RVA: 0x7FFD539CE8F0
        public void ThrowOverflowOrFormatException(){} // RVA: 0x7FFD53A62FC0
        public void NumberBufferToDouble(){} // RVA: 0x7FFD53A63050
        public void DigitsToInt(){} // RVA: 0x7FFD53A63100
        public void Mul32x32To64(){} // RVA: 0x7FFD539D6350
        public void Mul64Lossy(){} // RVA: 0x7FFD53A63140
        public void abs(){} // RVA: 0x7FFD539D6400
        public void NumberToDouble(){} // RVA: 0x7FFD53A631E0
        public void DoubleToNumber(){} // RVA: 0x7FFD53A63860
        public void .cctor(){} // RVA: 0x7FFD53A63990
    }

}