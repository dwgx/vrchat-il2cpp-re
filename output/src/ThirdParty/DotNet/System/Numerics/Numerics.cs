// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Numerics
// Classes: 16
// Methods: 193

namespace ThirdParty.DotNet.System.Numerics
{
    public class BigInteger : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x90BB50
        public void get_Zero(){} // RVA: 0x7289F60
        public void get_MinusOne(){} // RVA: 0x7289FC0
        public void get_IsZero(){} // RVA: 0x8E95B0
        public void get_IsEven(){} // RVA: 0x90BB60
        public void get_Sign(){} // RVA: 0x90BBA0
        public void Parse(){} // RVA: 0x728A110
        public void ModPow(){} // RVA: 0x728A170
        public void GetHashCode(){} // RVA: 0x90BBC0
        public void Equals(){} // RVA: 0x90BC50
        public void CompareTo(){} // RVA: 0x90BCA0
        public void ToByteArray(){} // RVA: 0x90BE10
        public void TryWriteBytes(){} // RVA: 0x90BE20
        public void TryWriteOrCountBytes(){} // RVA: 0x90BE60
        public void TryGetBytes(){} // RVA: 0x90BEA0
        public void ToString(){} // RVA: 0x90BF10
        public void Add(){} // RVA: 0x728BA50
        public void op_Subtraction(){} // RVA: 0x728BC10
        public void Subtract(){} // RVA: 0x728BE30
        public void op_Implicit(){} // RVA: 0x728C170
        public void op_Explicit(){} // RVA: 0x728C930
        public void op_LeftShift(){} // RVA: 0x728CAA0
        public void op_RightShift(){} // RVA: 0x728CD70
        public void op_UnaryNegation(){} // RVA: 0x728D1F0
        public void op_Addition(){} // RVA: 0x728D260
        public void op_Multiply(){} // RVA: 0x728D480
        public void op_Division(){} // RVA: 0x728D7B0
        public void op_Modulus(){} // RVA: 0x728DA80
        public void op_LessThanOrEqual(){} // RVA: 0x728DFF0
        public void op_GreaterThanOrEqual(){} // RVA: 0x728DCF0
        public void op_Inequality(){} // RVA: 0x728DF10
        public void op_LessThan(){} // RVA: 0x728DF80
        public void op_Equality(){} // RVA: 0x728DEB0
        public void GetPartsForBitManipulation(){} // RVA: 0x728E060
        public void GetDiffLength(){} // RVA: 0x728E240
        public void .cctor(){} // RVA: 0x728E2B0
    }

    public class BigIntegerCalculator : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x728E960
        public void AddSelf(){} // RVA: 0x728EA10
        public void Subtract(){} // RVA: 0x728ECE0
        public void SubtractSelf(){} // RVA: 0x728ED90
        public void Compare(){} // RVA: 0x728EE80
        public void Divide(){} // RVA: 0x728F260
        public void Remainder(){} // RVA: 0x728F160
        public void AddDivisor(){} // RVA: 0x728F630
        public void SubtractDivisor(){} // RVA: 0x728F660
        public void DivideGuessTooBig(){} // RVA: 0x728F6B0
        public void CreateCopy(){} // RVA: 0x728F6F0
        public void LeadingZeros(){} // RVA: 0x728F770
        public void Pow(){} // RVA: 0x728FE90
        public void PowCore(){} // RVA: 0x7290A80
        public void ActualLength(){} // RVA: 0x7290BC0
        public void Square(){} // RVA: 0x7290D00
        public void Multiply(){} // RVA: 0x7291330
        public void SubtractCore(){} // RVA: 0x7291890
        public void .cctor(){} // RVA: 0x72919A0
    }

    public class BigNumber : Object
    {
        // ── Methods ──
        public void TryValidateParseStyleInteger(){} // RVA: 0x7292940
        public void TryParseBigInteger(){} // RVA: 0x7292BE0
        public void ParseBigInteger(){} // RVA: 0x7293090
        public void HexNumberToBigInteger(){} // RVA: 0x7293200
        public void NumberToBigInteger(){} // RVA: 0x72934D0
        public void ParseFormatSpecifier(){} // RVA: 0x7293940
        public void FormatBigIntegerToHex(){} // RVA: 0x7293A90
        public void FormatBigInteger(){} // RVA: 0x72941A0
    }

    public class BitOperations : Object
    {
        // ── Methods ──
        public void RoundUpToPowerOf2(){} // RVA: 0xA7B5AE0
        public void get_Log2DeBruijn(){} // RVA: 0xA7B5B10
        public void Log2(){} // RVA: 0xA7B5B70
        public void Log2SoftwareFallback(){} // RVA: 0xA7B5B80
    }

    public class BitOperations : Object
    {
        // ── Methods ──
        public void RotateLeft(){} // RVA: 0x725ED90
    }

    public class ConstantHelper : Object
    {
        // ── Methods ──
        public void GetByteWithAllBitsSet(){} // RVA: 0x6824710
        public void GetSByteWithAllBitsSet(){} // RVA: 0x6824710
        public void GetUInt16WithAllBitsSet(){} // RVA: 0x6824720
        public void GetInt16WithAllBitsSet(){} // RVA: 0xFE6B70
        public void GetUInt32WithAllBitsSet(){} // RVA: 0xFE6B70
        public void GetInt32WithAllBitsSet(){} // RVA: 0xFE6B70
        public void GetUInt64WithAllBitsSet(){} // RVA: 0x2551610
        public void GetInt64WithAllBitsSet(){} // RVA: 0x2551610
        public void GetSingleWithAllBitsSet(){} // RVA: 0x2B97EB0
        public void GetDoubleWithAllBitsSet(){} // RVA: 0x2B97EC0
    }

    public class ConstantHelper : Object
    {
        // ── Methods ──
        public void GetByteWithAllBitsSet(){} // RVA: 0x6824710
        public void GetSByteWithAllBitsSet(){} // RVA: 0x6824710
        public void GetUInt16WithAllBitsSet(){} // RVA: 0x6824720
        public void GetInt16WithAllBitsSet(){} // RVA: 0xFE6B70
        public void GetUInt32WithAllBitsSet(){} // RVA: 0xFE6B70
        public void GetInt32WithAllBitsSet(){} // RVA: 0xFE6B70
        public void GetUInt64WithAllBitsSet(){} // RVA: 0x2551610
        public void GetInt64WithAllBitsSet(){} // RVA: 0x2551610
        public void GetSingleWithAllBitsSet(){} // RVA: 0x2B97EB0
        public void GetDoubleWithAllBitsSet(){} // RVA: 0x2B97EC0
    }

    public class NumericsHelpers : Object
    {
        // ── Methods ──
        public void GetDoubleParts(){} // RVA: 0x7294FD0
        public void GetDoubleFromParts(){} // RVA: 0x7295060
        public void DangerousMakeTwosComplement(){} // RVA: 0x72951B0
        public void MakeUlong(){} // RVA: 0x7295250
        public void Abs(){} // RVA: 0x7295260
        public void CombineHash(){} // RVA: 0x7295270
        public void CbitHighZero(){} // RVA: 0x7295280
    }

    public class Quaternion : ValueType
    {
        // ── Methods ──
        public void Normalize(){} // RVA: 0x7286770
        public void Inverse(){} // RVA: 0x7286840
        public void CreateFromAxisAngle(){} // RVA: 0x72868D0
        public void Slerp(){} // RVA: 0x7286980
        public void op_Multiply(){} // RVA: 0x7286BB0
        public void Equals(){} // RVA: 0x90B390
        public void ToString(){} // RVA: 0x90B460
        public void GetHashCode(){} // RVA: 0x90B470
    }

    public class Vector : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x2B83A80
        public void LessThan(){} // RVA: 0xA94080
        public void get_IsHardwareAccelerated(){} // RVA: 0xB43320
        public void BitwiseOr(){} // RVA: 0xA94080
        public void AsVectorUInt64(){} // RVA: 0xA94080
    }

    public class Vector : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0xA94080
        public void LessThan(){} // RVA: 0xA94080
        public void get_IsHardwareAccelerated(){} // RVA: 0xB43320
        public void BitwiseOr(){} // RVA: 0xA94080
        public void AsVectorByte(){} // RVA: 0xA94080
        public void AsVectorUInt64(){} // RVA: 0xA94080
    }

    public class Vector2 : ValueType
    {
        // ── Methods ──
        public void get_Zero(){} // RVA: 0x4F6B1A0
        public void GetHashCode(){} // RVA: 0x90B4E0
        public void Equals(){} // RVA: 0x90B6E0
        public void ToString(){} // RVA: 0x90B6D0
        public void .ctor(){} // RVA: 0x7C540
        public void op_Addition(){} // RVA: 0x72874B0
        public void op_Subtraction(){} // RVA: 0x72874F0
        public void op_Multiply(){} // RVA: 0x7287570
        public void op_UnaryNegation(){} // RVA: 0x72875A0
    }

    public class Vector3 : ValueType
    {
        // ── Methods ──
        public void get_Zero(){} // RVA: 0x532A4B0
        public void get_UnitY(){} // RVA: 0x72875D0
        public void get_UnitZ(){} // RVA: 0x72875E0
        public void GetHashCode(){} // RVA: 0x90B710
        public void Equals(){} // RVA: 0x90B980
        public void ToString(){} // RVA: 0x90B950
        public void Length(){} // RVA: 0x90B960
        public void Normalize(){} // RVA: 0x7287C50
        public void Transform(){} // RVA: 0x7287D30
        public void .ctor(){} // RVA: 0x7BFC0
        public void Dot(){} // RVA: 0x7287EA0
        public void op_Addition(){} // RVA: 0x7287ED0
        public void op_Subtraction(){} // RVA: 0x7287F10
        public void op_Multiply(){} // RVA: 0x7287F90
        public void op_Division(){} // RVA: 0x7287FD0
        public void op_UnaryNegation(){} // RVA: 0x7288010
    }

    public class Vector`1 : ValueType
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x87CFE0
        public void get_Zero(){} // RVA: 0xA94080
        public void InitializeCount(){} // RVA: 0x87CFE0
        public void .ctor(){} // RVA: 0x894320
        public void get_Item(){} // RVA: 0xA94080
        public void Equals(){} // RVA: 0xA94080
        public void GetHashCode(){} // RVA: 0x87C130
        public void ToString(){} // RVA: 0x87C5F0
        public void op_BitwiseOr(){} // RVA: 0xA94080
        public void op_Equality(){} // RVA: 0xA94080
        public void op_Inequality(){} // RVA: 0xA94080
        public void op_Explicit(){} // RVA: 0xA94080
        public void LessThan(){} // RVA: 0xA94080
        public void ScalarEquals(){} // RVA: 0xA94080
        public void ScalarLessThan(){} // RVA: 0xA94080
        public void GetOneValue(){} // RVA: 0xA94080
        public void GetAllBitsSetValue(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class Vector`1 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x2B96E20
        public void .ctor(){} // RVA: 0x7BE90
        public void get_Count(){} // RVA: 0x55DD5C0
        public void get_Zero(){} // RVA: 0x55DD660
        public void InitializeCount(){} // RVA: 0x55E5B70
        public void get_Item(){} // RVA: 0x6F6580
        public void GetHashCode(){} // RVA: 0x6F6590
        public void ToString(){} // RVA: 0x6F66D0
        public void op_BitwiseOr(){} // RVA: 0x55FF9C0
        public void op_Equality(){} // RVA: 0x55E9120
        public void op_Inequality(){} // RVA: 0x55E91C0
        public void op_Explicit(){} // RVA: 0x55FFA40
        public void LessThan(){} // RVA: 0x2B975B0
        public void ScalarEquals(){} // RVA: 0x55FFA90
        public void ScalarLessThan(){} // RVA: 0x5600700
        public void GetOneValue(){} // RVA: 0x5601390
        public void GetAllBitsSetValue(){} // RVA: 0x5601D50
        public void .cctor(){} // RVA: 0x5602710
    }

    public class Vector`1 : ValueType
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x87CFE0
        public void get_Zero(){} // RVA: 0xA94080
        public void InitializeCount(){} // RVA: 0x87CFE0
        public void .ctor(){} // RVA: 0x894320
        public void get_Item(){} // RVA: 0xA94080
        public void Equals(){} // RVA: 0xA94080
        public void GetHashCode(){} // RVA: 0x87C130
        public void ToString(){} // RVA: 0x87C5F0
        public void op_BitwiseOr(){} // RVA: 0xA94080
        public void op_Equality(){} // RVA: 0xA94080
        public void op_Inequality(){} // RVA: 0xA94080
        public void op_Explicit(){} // RVA: 0xA94080
        public void LessThan(){} // RVA: 0xA94080
        public void ScalarEquals(){} // RVA: 0xA94080
        public void ScalarLessThan(){} // RVA: 0xA94080
        public void GetOneValue(){} // RVA: 0xA94080
        public void GetAllBitsSetValue(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

}