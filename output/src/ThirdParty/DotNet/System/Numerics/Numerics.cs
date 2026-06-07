// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Numerics
// Classes: 13
// Methods: 194

namespace ThirdParty.DotNet.System.Numerics
{
    public class BigInteger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68242A0 | overloaded x11
        public void get_Zero(){} // RVA: 0x68245D0
        public void get_MinusOne(){} // RVA: 0x6824630
        public void get_IsZero(){} // RVA: 0x62E1480
        public void get_IsEven(){} // RVA: 0x6824690
        public void get_Sign(){} // RVA: 0x68246D0
        public void Parse(){} // RVA: 0x6824780 | overloaded x2
        public void ModPow(){} // RVA: 0x68247E0
        public void GetHashCode(){} // RVA: 0x6824FC0
        public void Equals(){} // RVA: 0x6825140 | overloaded x3
        public void CompareTo(){} // RVA: 0x68254B0 | overloaded x3
        public void ToByteArray(){} // RVA: 0x6825620 | overloaded x2
        public void TryWriteBytes(){} // RVA: 0x68256D0
        public void TryWriteOrCountBytes(){} // RVA: 0x6825790
        public void TryGetBytes(){} // RVA: 0x6825840
        public void ToString(){} // RVA: 0x6825F40 | overloaded x3
        public void Add(){} // RVA: 0x6826040
        public void op_Subtraction(){} // RVA: 0x6826200
        public void Subtract(){} // RVA: 0x6826420
        public void op_Implicit(){} // RVA: 0x6826760 | overloaded x8
        public void op_Explicit(){} // RVA: 0x6826F10 | overloaded x11
        public void op_LeftShift(){} // RVA: 0x6827080
        public void op_RightShift(){} // RVA: 0x6827330
        public void op_UnaryNegation(){} // RVA: 0x68277A0
        public void op_Addition(){} // RVA: 0x6827810
        public void op_Multiply(){} // RVA: 0x6827A30
        public void op_Division(){} // RVA: 0x6827D50
        public void op_Modulus(){} // RVA: 0x6828000
        public void op_LessThanOrEqual(){} // RVA: 0x6828550 | overloaded x3
        public void op_GreaterThanOrEqual(){} // RVA: 0x6828250
        public void op_Inequality(){} // RVA: 0x6828470 | overloaded x2
        public void op_LessThan(){} // RVA: 0x68284E0 | overloaded x2
        public void op_Equality(){} // RVA: 0x6828410
        public void GetPartsForBitManipulation(){} // RVA: 0x68285C0
        public void GetDiffLength(){} // RVA: 0x68287A0
        public void .cctor(){} // RVA: 0x6828800
    }

    public class BigIntegerCalculator
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x6828EA0 | overloaded x3
        public void AddSelf(){} // RVA: 0x6828F50
        public void Subtract(){} // RVA: 0x6829220 | overloaded x3
        public void SubtractSelf(){} // RVA: 0x68292D0
        public void Compare(){} // RVA: 0x68293D0 | overloaded x2
        public void Divide(){} // RVA: 0x6829770 | overloaded x3
        public void Remainder(){} // RVA: 0x6829670 | overloaded x2
        public void AddDivisor(){} // RVA: 0x6829B50
        public void SubtractDivisor(){} // RVA: 0x6829B80
        public void DivideGuessTooBig(){} // RVA: 0x6829BD0
        public void CreateCopy(){} // RVA: 0x6829C10
        public void LeadingZeros(){} // RVA: 0x6829C90
        public void Pow(){} // RVA: 0x682A380 | overloaded x8
        public void PowCore(){} // RVA: 0x682AF20 | overloaded x8
        public void ActualLength(){} // RVA: 0x682B050 | overloaded x2
        public void Square(){} // RVA: 0x682B180 | overloaded x2
        public void Multiply(){} // RVA: 0x682B7A0 | overloaded x3
        public void SubtractCore(){} // RVA: 0x682BD00
        public void .cctor(){} // RVA: 0x682BE10
    }

    public class BigNumber
    {
        // ── Methods ──
        public void TryValidateParseStyleInteger(){} // RVA: 0x682CD80
        public void TryParseBigInteger(){} // RVA: 0x682D020
        public void ParseBigInteger(){} // RVA: 0x682D4C0 | overloaded x2
        public void HexNumberToBigInteger(){} // RVA: 0x682D630
        public void NumberToBigInteger(){} // RVA: 0x682D900
        public void ParseFormatSpecifier(){} // RVA: 0x682DDA0
        public void FormatBigIntegerToHex(){} // RVA: 0x682DEF0
        public void FormatBigInteger(){} // RVA: 0x682E660 | overloaded x2
    }

    public class BitOperations
    {
        // ── Methods ──
        public void RoundUpToPowerOf2(){} // RVA: 0x9B077E0
        public void get_Log2DeBruijn(){} // RVA: 0x9B07810
        public void Log2(){} // RVA: 0x9B07870
        public void Log2SoftwareFallback(){} // RVA: 0x9B07880
    }

    public class ConstantHelper
    {
        // ── Methods ──
        public void GetByteWithAllBitsSet(){} // RVA: 0x5DAB380
        public void GetSByteWithAllBitsSet(){} // RVA: 0x5DAB380
        public void GetUInt16WithAllBitsSet(){} // RVA: 0x5DAB390
        public void GetInt16WithAllBitsSet(){} // RVA: 0x75BB20
        public void GetUInt32WithAllBitsSet(){} // RVA: 0x75BB20
        public void GetInt32WithAllBitsSet(){} // RVA: 0x75BB20
        public void GetUInt64WithAllBitsSet(){} // RVA: 0x1CA3200
        public void GetInt64WithAllBitsSet(){} // RVA: 0x1CA3200
        public void GetSingleWithAllBitsSet(){} // RVA: 0x219EC90
        public void GetDoubleWithAllBitsSet(){} // RVA: 0x219ECA0
    }

    public class DoubleUlong
    {
    }

    public class NumericsHelpers
    {
        // ── Methods ──
        public void GetDoubleParts(){} // RVA: 0x682F480
        public void GetDoubleFromParts(){} // RVA: 0x682F510
        public void DangerousMakeTwosComplement(){} // RVA: 0x682F660
        public void MakeUlong(){} // RVA: 0x682F6F0
        public void Abs(){} // RVA: 0x682F700
        public void CombineHash(){} // RVA: 0x682F710 | overloaded x2
        public void CbitHighZero(){} // RVA: 0x682F720 | overloaded x2
    }

    public class Quaternion
    {
        // ── Methods ──
        public void Normalize(){} // RVA: 0x6821200
        public void Inverse(){} // RVA: 0x68212D0
        public void Slerp(){} // RVA: 0x6821360
        public void op_Multiply(){} // RVA: 0x6821590
        public void Equals(){} // RVA: 0x68216D0 | overloaded x2
        public void ToString(){} // RVA: 0x6821790
        public void GetHashCode(){} // RVA: 0x6821A00
    }

    public class Register
    {
    }

    public class Vector
    {
        public object IsHardwareAccelerated;

        // ── Methods ──
        public void Equals(){} // RVA: 0x283FA0
        public void LessThan(){} // RVA: 0x283FA0
        public void get_IsHardwareAccelerated(){} // RVA: 0x2DD320
        public void BitwiseOr(){} // RVA: 0x283FA0
        public void AsVectorByte(){} // RVA: 0x283FA0
        public void AsVectorUInt64(){} // RVA: 0x283FA0
    }

    public class Vector2
    {
        // ── Methods ──
        public void get_Zero(){} // RVA: 0x6821A70
        public void GetHashCode(){} // RVA: 0x6821A80
        public void Equals(){} // RVA: 0x6821E70 | overloaded x2
        public void ToString(){} // RVA: 0x6821C70 | overloaded x2
        public void .ctor(){} // RVA: 0x300D10
        public void op_Addition(){} // RVA: 0x6821EA0
        public void op_Subtraction(){} // RVA: 0x6821EE0
        public void op_Multiply(){} // RVA: 0x6821F60 | overloaded x2
        public void op_UnaryNegation(){} // RVA: 0x6821F90
    }

    public class Vector3
    {
        // ── Methods ──
        public void get_Zero(){} // RVA: 0x4827050
        public void GetHashCode(){} // RVA: 0x6821FC0
        public void Equals(){} // RVA: 0x6462200 | overloaded x2
        public void ToString(){} // RVA: 0x68221F0 | overloaded x2
        public void .ctor(){} // RVA: 0x300D70 | overloaded x2
        public void op_Addition(){} // RVA: 0x6822560
        public void op_Subtraction(){} // RVA: 0x68225A0
        public void op_Multiply(){} // RVA: 0x6822620 | overloaded x2
        public void op_Division(){} // RVA: 0x6822660 | overloaded x2
        public void op_UnaryNegation(){} // RVA: 0x68226A0
    }

    public class Vector`1
    {
    }

}