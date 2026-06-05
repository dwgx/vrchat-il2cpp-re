// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Numerics
// Classes: 22
// Methods: 283

namespace ThirdParty.DotNet.System.Numerics
{
    public class BigInteger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92D42A0 | overloaded x11
        public void get_Zero(){} // RVA: 0x7FFAF92D45D0
        public void get_MinusOne(){} // RVA: 0x7FFAF92D4630
        public void get_IsZero(){} // RVA: 0x7FFAF8D91480
        public void get_IsEven(){} // RVA: 0x7FFAF92D4690
        public void get_Sign(){} // RVA: 0x7FFAF92D46D0
        public void Parse(){} // RVA: 0x7FFAF92D4780 | overloaded x2
        public void ModPow(){} // RVA: 0x7FFAF92D47E0
        public void GetHashCode(){} // RVA: 0x7FFAF92D4FC0
        public void Equals(){} // RVA: 0x7FFAF92D5140 | overloaded x3
        public void CompareTo(){} // RVA: 0x7FFAF92D54B0 | overloaded x3
        public void ToByteArray(){} // RVA: 0x7FFAF92D5620 | overloaded x2
        public void TryWriteBytes(){} // RVA: 0x7FFAF92D56D0
        public void TryWriteOrCountBytes(){} // RVA: 0x7FFAF92D5790
        public void TryGetBytes(){} // RVA: 0x7FFAF92D5840
        public void ToString(){} // RVA: 0x7FFAF92D5F40 | overloaded x3
        public void Add(){} // RVA: 0x7FFAF92D6040
        public void op_Subtraction(){} // RVA: 0x7FFAF92D6200
        public void Subtract(){} // RVA: 0x7FFAF92D6420
        public void op_Implicit(){} // RVA: 0x7FFAF92D6760 | overloaded x8
        public void op_Explicit(){} // RVA: 0x7FFAF92D6F10 | overloaded x11
        public void op_LeftShift(){} // RVA: 0x7FFAF92D7080
        public void op_RightShift(){} // RVA: 0x7FFAF92D7330
        public void op_UnaryNegation(){} // RVA: 0x7FFAF92D77A0
        public void op_Addition(){} // RVA: 0x7FFAF92D7810
        public void op_Multiply(){} // RVA: 0x7FFAF92D7A30
        public void op_Division(){} // RVA: 0x7FFAF92D7D50
        public void op_Modulus(){} // RVA: 0x7FFAF92D8000
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAF92D8550 | overloaded x3
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAF92D8250
        public void op_Inequality(){} // RVA: 0x7FFAF92D8470 | overloaded x2
        public void op_LessThan(){} // RVA: 0x7FFAF92D84E0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAF92D8410
        public void GetPartsForBitManipulation(){} // RVA: 0x7FFAF92D85C0
        public void GetDiffLength(){} // RVA: 0x7FFAF92D87A0
        public void .cctor(){} // RVA: 0x7FFAF92D8800
    }

    public class BigIntegerCalculator
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAF92D8EA0 | overloaded x3
        public void AddSelf(){} // RVA: 0x7FFAF92D8F50
        public void Subtract(){} // RVA: 0x7FFAF92D9220 | overloaded x3
        public void SubtractSelf(){} // RVA: 0x7FFAF92D92D0
        public void Compare(){} // RVA: 0x7FFAF92D93D0 | overloaded x2
        public void Divide(){} // RVA: 0x7FFAF92D9770 | overloaded x3
        public void Remainder(){} // RVA: 0x7FFAF92D9670 | overloaded x2
        public void AddDivisor(){} // RVA: 0x7FFAF92D9B50
        public void SubtractDivisor(){} // RVA: 0x7FFAF92D9B80
        public void DivideGuessTooBig(){} // RVA: 0x7FFAF92D9BD0
        public void CreateCopy(){} // RVA: 0x7FFAF92D9C10
        public void LeadingZeros(){} // RVA: 0x7FFAF92D9C90
        public void Pow(){} // RVA: 0x7FFAF92DA380 | overloaded x8
        public void PowCore(){} // RVA: 0x7FFAF92DAF20 | overloaded x8
        public void ActualLength(){} // RVA: 0x7FFAF92DB050 | overloaded x2
        public void Square(){} // RVA: 0x7FFAF92DB180 | overloaded x2
        public void Multiply(){} // RVA: 0x7FFAF92DB7A0 | overloaded x3
        public void SubtractCore(){} // RVA: 0x7FFAF92DBD00
        public void .cctor(){} // RVA: 0x7FFAF92DBE10
    }

    public class BigNumber
    {
        // ── Methods ──
        public void TryValidateParseStyleInteger(){} // RVA: 0x7FFAF92DCD80
        public void TryParseBigInteger(){} // RVA: 0x7FFAF92DD020
        public void ParseBigInteger(){} // RVA: 0x7FFAF92DD4C0 | overloaded x2
        public void HexNumberToBigInteger(){} // RVA: 0x7FFAF92DD630
        public void NumberToBigInteger(){} // RVA: 0x7FFAF92DD900
        public void ParseFormatSpecifier(){} // RVA: 0x7FFAF92DDDA0
        public void FormatBigIntegerToHex(){} // RVA: 0x7FFAF92DDEF0
        public void FormatBigInteger(){} // RVA: 0x7FFAF92DE660 | overloaded x2
    }

    public class BitOperations
    {
        // ── Methods ──
        public void RoundUpToPowerOf2(){} // RVA: 0x7FFAFC5B77E0
        public void get_Log2DeBruijn(){} // RVA: 0x7FFAFC5B7810
        public void Log2(){} // RVA: 0x7FFAFC5B7870
        public void Log2SoftwareFallback(){} // RVA: 0x7FFAFC5B7880
    }

    public class BitOperations
    {
        // ── Methods ──
        public void RotateLeft(){} // RVA: 0x7FFAF92A9B10
    }

    public class ConstantHelper
    {
        // ── Methods ──
        public void GetByteWithAllBitsSet(){} // RVA: 0x7FFAF885B380
        public void GetSByteWithAllBitsSet(){} // RVA: 0x7FFAF885B380
        public void GetUInt16WithAllBitsSet(){} // RVA: 0x7FFAF885B390
        public void GetInt16WithAllBitsSet(){} // RVA: 0x7FFAF320BB20
        public void GetUInt32WithAllBitsSet(){} // RVA: 0x7FFAF320BB20
        public void GetInt32WithAllBitsSet(){} // RVA: 0x7FFAF320BB20
        public void GetUInt64WithAllBitsSet(){} // RVA: 0x7FFAF4753200
        public void GetInt64WithAllBitsSet(){} // RVA: 0x7FFAF4753200
        public void GetSingleWithAllBitsSet(){} // RVA: 0x7FFAF4C4EC90
        public void GetDoubleWithAllBitsSet(){} // RVA: 0x7FFAF4C4ECA0
    }

    public class ConstantHelper
    {
        // ── Methods ──
        public void GetByteWithAllBitsSet(){} // RVA: 0x7FFAF885B380
        public void GetSByteWithAllBitsSet(){} // RVA: 0x7FFAF885B380
        public void GetUInt16WithAllBitsSet(){} // RVA: 0x7FFAF885B390
        public void GetInt16WithAllBitsSet(){} // RVA: 0x7FFAF320BB20
        public void GetUInt32WithAllBitsSet(){} // RVA: 0x7FFAF320BB20
        public void GetInt32WithAllBitsSet(){} // RVA: 0x7FFAF320BB20
        public void GetUInt64WithAllBitsSet(){} // RVA: 0x7FFAF4753200
        public void GetInt64WithAllBitsSet(){} // RVA: 0x7FFAF4753200
        public void GetSingleWithAllBitsSet(){} // RVA: 0x7FFAF4C4EC90
        public void GetDoubleWithAllBitsSet(){} // RVA: 0x7FFAF4C4ECA0
    }

    public class DoubleUlong
    {
    }

    public class NumericsHelpers
    {
        // ── Methods ──
        public void GetDoubleParts(){} // RVA: 0x7FFAF92DF480
        public void GetDoubleFromParts(){} // RVA: 0x7FFAF92DF510
        public void DangerousMakeTwosComplement(){} // RVA: 0x7FFAF92DF660
        public void MakeUlong(){} // RVA: 0x7FFAF92DF6F0
        public void Abs(){} // RVA: 0x7FFAF92DF700
        public void CombineHash(){} // RVA: 0x7FFAF92DF710 | overloaded x2
        public void CbitHighZero(){} // RVA: 0x7FFAF92DF720 | overloaded x2
    }

    public class Quaternion
    {
        // ── Methods ──
        public void Normalize(){} // RVA: 0x7FFAF92D1200
        public void Inverse(){} // RVA: 0x7FFAF92D12D0
        public void Slerp(){} // RVA: 0x7FFAF92D1360
        public void op_Multiply(){} // RVA: 0x7FFAF92D1590
        public void Equals(){} // RVA: 0x7FFAF92D16D0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF92D1790
        public void GetHashCode(){} // RVA: 0x7FFAF92D1A00
    }

    public class Register
    {
    }

    public class Register
    {
    }

    public class Vector
    {
        public object IsHardwareAccelerated;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAF2D33FA0
        public void LessThan(){} // RVA: 0x7FFAF2D33FA0
        public void get_IsHardwareAccelerated(){} // RVA: 0x7FFAF2D8D320
        public void BitwiseOr(){} // RVA: 0x7FFAF2D33FA0
        public void AsVectorByte(){} // RVA: 0x7FFAF2D33FA0
        public void AsVectorUInt64(){} // RVA: 0x7FFAF2D33FA0
    }

    public class Vector
    {
        public object importedWithErrors;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAF2D33FA0
        public void LessThan(){} // RVA: 0x7FFAF2D33FA0
        public void get_IsHardwareAccelerated(){} // RVA: 0x7FFAF2D8D320
        public void BitwiseOr(){} // RVA: 0x7FFAF2D33FA0
        public void AsVectorUInt64(){} // RVA: 0x7FFAF2D33FA0
    }

    public class Vector2
    {
        // ── Methods ──
        public void get_Zero(){} // RVA: 0x7FFAF92D1A70
        public void GetHashCode(){} // RVA: 0x7FFAF92D1A80
        public void Equals(){} // RVA: 0x7FFAF92D1E70 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF92D1C70 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2DB0D10
        public void op_Addition(){} // RVA: 0x7FFAF92D1EA0
        public void op_Subtraction(){} // RVA: 0x7FFAF92D1EE0
        public void op_Multiply(){} // RVA: 0x7FFAF92D1F60 | overloaded x2
        public void op_UnaryNegation(){} // RVA: 0x7FFAF92D1F90
    }

    public class Vector3
    {
        // ── Methods ──
        public void get_Zero(){} // RVA: 0x7FFAF72D7050
        public void GetHashCode(){} // RVA: 0x7FFAF92D1FC0
        public void Equals(){} // RVA: 0x7FFAF8F12200 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF92D21F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2DB0D70 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFAF92D2560
        public void op_Subtraction(){} // RVA: 0x7FFAF92D25A0
        public void op_Multiply(){} // RVA: 0x7FFAF92D2620 | overloaded x2
        public void op_Division(){} // RVA: 0x7FFAF92D2660 | overloaded x2
        public void op_UnaryNegation(){} // RVA: 0x7FFAF92D26A0
    }

    public class Vector`1
    {
    }

    public class Vector`1
    {
        public object `/;
    }

    public class Vector`1
    {
    }

    public class Vector`1
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAF2ABD870
        public void get_Zero(){} // RVA: 0x7FFAF2D33FA0
        public void InitializeCount(){} // RVA: 0x7FFAF2ABD870
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10 | overloaded x4
        public void get_Item(){} // RVA: 0x7FFAF2D33FA0
        public void Equals(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAF2ABD840
        public void ToString(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void op_BitwiseOr(){} // RVA: 0x7FFAF2D33FA0
        public void op_Equality(){} // RVA: 0x7FFAF2D33FA0
        public void op_Inequality(){} // RVA: 0x7FFAF2D33FA0
        public void op_Explicit(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void LessThan(){} // RVA: 0x7FFAF2D33FA0
        public void ScalarEquals(){} // RVA: 0x7FFAF2D33FA0
        public void ScalarLessThan(){} // RVA: 0x7FFAF2D33FA0
        public void GetOneValue(){} // RVA: 0x7FFAF2D33FA0
        public void GetAllBitsSetValue(){} // RVA: 0x7FFAF2D33FA0
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
    }

    public class Vector`1
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAF2ABD870
        public void get_Zero(){} // RVA: 0x7FFAF2D33FA0
        public void InitializeCount(){} // RVA: 0x7FFAF2ABD870
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10 | overloaded x4
        public void get_Item(){} // RVA: 0x7FFAF2D33FA0
        public void Equals(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAF2ABD840
        public void ToString(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void op_BitwiseOr(){} // RVA: 0x7FFAF2D33FA0
        public void op_Equality(){} // RVA: 0x7FFAF2D33FA0
        public void op_Inequality(){} // RVA: 0x7FFAF2D33FA0
        public void op_Explicit(){} // RVA: 0x7FFAF2D33FA0
        public void LessThan(){} // RVA: 0x7FFAF2D33FA0
        public void ScalarEquals(){} // RVA: 0x7FFAF2D33FA0
        public void ScalarLessThan(){} // RVA: 0x7FFAF2D33FA0
        public void GetOneValue(){} // RVA: 0x7FFAF2D33FA0
        public void GetAllBitsSetValue(){} // RVA: 0x7FFAF2D33FA0
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
    }

    public class Vector`1
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAF756CBA0
        public void get_Zero(){} // RVA: 0x7FFAF756CC40
        public void InitializeCount(){} // RVA: 0x7FFAF75A4610
        public void .ctor(){} // RVA: 0x7FFAF4503740 | overloaded x4
        public void get_Item(){} // RVA: 0x7FFAF75A7670
        public void Equals(){} // RVA: 0x7FFAF75A9E40 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAF75A8970
        public void ToString(){} // RVA: 0x7FFAF75A96E0 | overloaded x2
        public void op_BitwiseOr(){} // RVA: 0x7FFAF75A9BC0
        public void op_Equality(){} // RVA: 0x7FFAF75A9C40
        public void op_Inequality(){} // RVA: 0x7FFAF75A9CE0
        public void op_Explicit(){} // RVA: 0x7FFAF75A9DF0
        public void LessThan(){} // RVA: 0x7FFAF75AA610
        public void ScalarEquals(){} // RVA: 0x7FFAF75AAF60
        public void ScalarLessThan(){} // RVA: 0x7FFAF75ABCD0
        public void GetOneValue(){} // RVA: 0x7FFAF75ACA50
        public void GetAllBitsSetValue(){} // RVA: 0x7FFAF75AD500
        public void .cctor(){} // RVA: 0x7FFAF75ADFC0
    }

}