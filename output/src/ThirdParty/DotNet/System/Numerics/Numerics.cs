// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Numerics
// Classes: 16
// Methods: 186

namespace ThirdParty.DotNet.System.Numerics
{
    public class BigInteger : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E8BF20
        public void get_Zero(){} // RVA: 0x7AE613150
        public void get_MinusOne(){} // RVA: 0x7AE6131B0
        public void get_IsZero(){} // RVA: 0x7A7E6A950
        public void get_IsEven(){} // RVA: 0x7A7E8BF30
        public void get_Sign(){} // RVA: 0x7A7E8BF70
        public void Parse(){} // RVA: 0x7AE613300
        public void ModPow(){} // RVA: 0x7AE613360
        public void GetHashCode(){} // RVA: 0x7A7E8BF90
        public void Equals(){} // RVA: 0x7A7E8C020
        public void CompareTo(){} // RVA: 0x7A7E8C070
        public void ToByteArray(){} // RVA: 0x7A7E8C1E0
        public void TryWriteBytes(){} // RVA: 0x7A7E8C1F0
        public void TryWriteOrCountBytes(){} // RVA: 0x7A7E8C230
        public void TryGetBytes(){} // RVA: 0x7A7E8C270
        public void ToString(){} // RVA: 0x7A7E8C2E0
        public void Add(){} // RVA: 0x7AE614C40
        public void op_Subtraction(){} // RVA: 0x7AE614E00
        public void Subtract(){} // RVA: 0x7AE615020
        public void op_Implicit(){} // RVA: 0x7AE615360
        public void op_Explicit(){} // RVA: 0x7AE615B20
        public void op_LeftShift(){} // RVA: 0x7AE615C90
        public void op_RightShift(){} // RVA: 0x7AE615F60
        public void op_UnaryNegation(){} // RVA: 0x7AE6163E0
        public void op_Addition(){} // RVA: 0x7AE616450
        public void op_Multiply(){} // RVA: 0x7AE616670
        public void op_Division(){} // RVA: 0x7AE6169A0
        public void op_Modulus(){} // RVA: 0x7AE616C70
        public void op_LessThanOrEqual(){} // RVA: 0x7AE6171E0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7AE616EE0
        public void op_Inequality(){} // RVA: 0x7AE617100
        public void op_LessThan(){} // RVA: 0x7AE617170
        public void op_Equality(){} // RVA: 0x7AE6170A0
        public void GetPartsForBitManipulation(){} // RVA: 0x7AE617250
        public void GetDiffLength(){} // RVA: 0x7AE617430
        public void .cctor(){} // RVA: 0x7AE6174A0
    }

    public class BigIntegerCalculator : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AE617B50
        public void AddSelf(){} // RVA: 0x7AE617C00
        public void Subtract(){} // RVA: 0x7AE617ED0
        public void SubtractSelf(){} // RVA: 0x7AE617F80
        public void Compare(){} // RVA: 0x7AE618070
        public void Divide(){} // RVA: 0x7AE618450
        public void Remainder(){} // RVA: 0x7AE618350
        public void AddDivisor(){} // RVA: 0x7AE618820
        public void SubtractDivisor(){} // RVA: 0x7AE618850
        public void DivideGuessTooBig(){} // RVA: 0x7AE6188A0
        public void CreateCopy(){} // RVA: 0x7AE6188E0
        public void LeadingZeros(){} // RVA: 0x7AE618960
        public void Pow(){} // RVA: 0x7AE619080
        public void PowCore(){} // RVA: 0x7AE619C70
        public void ActualLength(){} // RVA: 0x7AE619DB0
        public void Square(){} // RVA: 0x7AE619EF0
        public void Multiply(){} // RVA: 0x7AE61A520
        public void SubtractCore(){} // RVA: 0x7AE61AA80
        public void .cctor(){} // RVA: 0x7AE61AB90
    }

    public class BigNumber : Object
    {
        // ── Methods ──
        public void TryValidateParseStyleInteger(){} // RVA: 0x7AE61BB30
        public void TryParseBigInteger(){} // RVA: 0x7AE61BDD0
        public void ParseBigInteger(){} // RVA: 0x7AE61C280
        public void HexNumberToBigInteger(){} // RVA: 0x7AE61C3F0
        public void NumberToBigInteger(){} // RVA: 0x7AE61C6C0
        public void ParseFormatSpecifier(){} // RVA: 0x7AE61CB30
        public void FormatBigIntegerToHex(){} // RVA: 0x7AE61CC80
        public void FormatBigInteger(){} // RVA: 0x7AE61D390
    }

    public class BitOperations : Object
    {
        // ── Methods ──
        public void RoundUpToPowerOf2(){} // RVA: 0x7B1949570
        public void get_Log2DeBruijn(){} // RVA: 0x7B19495A0
        public void Log2(){} // RVA: 0x7B1949600
        public void Log2SoftwareFallback(){} // RVA: 0x7B1949610
    }

    public class BitOperations : Object
    {
        // ── Methods ──
        public void RotateLeft(){} // RVA: 0x7AE5E8370
    }

    public class ConstantHelper : Object
    {
        // ── Methods ──
        public void GetByteWithAllBitsSet(){} // RVA: 0x7ADB99680
        public void GetSByteWithAllBitsSet(){} // RVA: 0x7ADB99680
        public void GetUInt16WithAllBitsSet(){} // RVA: 0x7ADB99690
        public void GetInt16WithAllBitsSet(){} // RVA: 0x7A85193D0
        public void GetUInt32WithAllBitsSet(){} // RVA: 0x7A85193D0
        public void GetInt32WithAllBitsSet(){} // RVA: 0x7A85193D0
        public void GetUInt64WithAllBitsSet(){} // RVA: 0x7A9AA5820
        public void GetInt64WithAllBitsSet(){} // RVA: 0x7A9AA5820
        public void GetSingleWithAllBitsSet(){} // RVA: 0x7A9FB2910
        public void GetDoubleWithAllBitsSet(){} // RVA: 0x7A9FB2920
    }

    public class ConstantHelper : Object
    {
        // ── Methods ──
        public void GetByteWithAllBitsSet(){} // RVA: 0x7ADB99680
        public void GetSByteWithAllBitsSet(){} // RVA: 0x7ADB99680
        public void GetUInt16WithAllBitsSet(){} // RVA: 0x7ADB99690
        public void GetInt16WithAllBitsSet(){} // RVA: 0x7A85193D0
        public void GetUInt32WithAllBitsSet(){} // RVA: 0x7A85193D0
        public void GetInt32WithAllBitsSet(){} // RVA: 0x7A85193D0
        public void GetUInt64WithAllBitsSet(){} // RVA: 0x7A9AA5820
        public void GetInt64WithAllBitsSet(){} // RVA: 0x7A9AA5820
        public void GetSingleWithAllBitsSet(){} // RVA: 0x7A9FB2910
        public void GetDoubleWithAllBitsSet(){} // RVA: 0x7A9FB2920
    }

    public class NumericsHelpers : Object
    {
        // ── Methods ──
        public void GetDoubleParts(){} // RVA: 0x7AE61E1D0
        public void GetDoubleFromParts(){} // RVA: 0x7AE61E260
        public void DangerousMakeTwosComplement(){} // RVA: 0x7AE61E3B0
        public void MakeUlong(){} // RVA: 0x7AE61E450
        public void Abs(){} // RVA: 0x7AE61E460
        public void CombineHash(){} // RVA: 0x7AE61E470
        public void CbitHighZero(){} // RVA: 0x7AE61E480
    }

    public class Quaternion : ValueType
    {
        // ── Methods ──
        public void Normalize(){} // RVA: 0x7AE60FD60
        public void Inverse(){} // RVA: 0x7AE60FE30
        public void Slerp(){} // RVA: 0x7AE60FEC0
        public void op_Multiply(){} // RVA: 0x7AE6100F0
        public void Equals(){} // RVA: 0x7A7E8B740
        public void ToString(){} // RVA: 0x7A7E8B810
        public void GetHashCode(){} // RVA: 0x7A7E8B820
    }

    public class Vector : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A8051B10
        public void LessThan(){} // RVA: 0x7A8051B10
        public void get_IsHardwareAccelerated(){} // RVA: 0x7A80D7320
        public void BitwiseOr(){} // RVA: 0x7A8051B10
        public void AsVectorByte(){} // RVA: 0x7A8051B10
        public void AsVectorUInt64(){} // RVA: 0x7A8051B10
    }

    public class Vector : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A9FAC2F0
        public void LessThan(){} // RVA: 0x7A8051B10
        public void get_IsHardwareAccelerated(){} // RVA: 0x7A80D7320
        public void BitwiseOr(){} // RVA: 0x7A8051B10
        public void AsVectorUInt64(){} // RVA: 0x7A8051B10
    }

    public class Vector2 : ValueType
    {
        // ── Methods ──
        public void get_Zero(){} // RVA: 0x7AE6105D0
        public void GetHashCode(){} // RVA: 0x7A7E8B890
        public void Equals(){} // RVA: 0x7A7E8BA90
        public void ToString(){} // RVA: 0x7A7E8BA80
        public void .ctor(){} // RVA: 0x7A7663240
        public void op_Addition(){} // RVA: 0x7AE610A00
        public void op_Subtraction(){} // RVA: 0x7AE610A40
        public void op_Multiply(){} // RVA: 0x7AE610AC0
        public void op_UnaryNegation(){} // RVA: 0x7AE610AF0
    }

    public class Vector3 : ValueType
    {
        // ── Methods ──
        public void get_Zero(){} // RVA: 0x7AC6170B0
        public void GetHashCode(){} // RVA: 0x7A7E8BAC0
        public void Equals(){} // RVA: 0x7A7E8BD20
        public void ToString(){} // RVA: 0x7A7E8BD00
        public void .ctor(){} // RVA: 0x7A7662DC0
        public void op_Addition(){} // RVA: 0x7AE6110C0
        public void op_Subtraction(){} // RVA: 0x7AE611100
        public void op_Multiply(){} // RVA: 0x7AE611180
        public void op_Division(){} // RVA: 0x7AE6111C0
        public void op_UnaryNegation(){} // RVA: 0x7AE611200
    }

    public class Vector`1 : ValueType
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7A7E015C0
        public void get_Zero(){} // RVA: 0x7A8051B10
        public void InitializeCount(){} // RVA: 0x7A7E015C0
        public void .ctor(){} // RVA: 0x7A7E18800
        public void get_Item(){} // RVA: 0x7A8051B10
        public void Equals(){} // RVA: 0x7A8051B10
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void ToString(){} // RVA: 0x7A7E00BD0
        public void op_BitwiseOr(){} // RVA: 0x7A8051B10
        public void op_Equality(){} // RVA: 0x7A8051B10
        public void op_Inequality(){} // RVA: 0x7A8051B10
        public void op_Explicit(){} // RVA: 0x7A8051B10
        public void LessThan(){} // RVA: 0x7A8051B10
        public void ScalarEquals(){} // RVA: 0x7A8051B10
        public void ScalarLessThan(){} // RVA: 0x7A8051B10
        public void GetOneValue(){} // RVA: 0x7A8051B10
        public void GetAllBitsSetValue(){} // RVA: 0x7A8051B10
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class Vector`1 : ValueType
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7A7E015C0
        public void get_Zero(){} // RVA: 0x7A8051B10
        public void InitializeCount(){} // RVA: 0x7A7E015C0
        public void .ctor(){} // RVA: 0x7A7E18800
        public void get_Item(){} // RVA: 0x7A8051B10
        public void Equals(){} // RVA: 0x7A8051B10
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void ToString(){} // RVA: 0x7A7E00BD0
        public void op_BitwiseOr(){} // RVA: 0x7A8051B10
        public void op_Equality(){} // RVA: 0x7A8051B10
        public void op_Inequality(){} // RVA: 0x7A8051B10
        public void op_Explicit(){} // RVA: 0x7A8051B10
        public void LessThan(){} // RVA: 0x7A8051B10
        public void ScalarEquals(){} // RVA: 0x7A8051B10
        public void ScalarLessThan(){} // RVA: 0x7A8051B10
        public void GetOneValue(){} // RVA: 0x7A8051B10
        public void GetAllBitsSetValue(){} // RVA: 0x7A8051B10
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class Vector`1 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7AC8E88B0
        public void .ctor(){} // RVA: 0x7A7662BD0
        public void get_Count(){} // RVA: 0x7AC8AB5A0
        public void get_Zero(){} // RVA: 0x7AC8AB640
        public void InitializeCount(){} // RVA: 0x7AC8E3070
        public void get_Item(){} // RVA: 0x7A7C85C00
        public void GetHashCode(){} // RVA: 0x7A7C85C40
        public void ToString(){} // RVA: 0x7A7C85D80
        public void op_BitwiseOr(){} // RVA: 0x7AC8E8630
        public void op_Equality(){} // RVA: 0x7AC8E86B0
        public void op_Inequality(){} // RVA: 0x7AC8E8750
        public void op_Explicit(){} // RVA: 0x7AC8E8860
        public void LessThan(){} // RVA: 0x7AC8E9080
        public void ScalarEquals(){} // RVA: 0x7AC8E99D0
        public void ScalarLessThan(){} // RVA: 0x7AC8EA730
        public void GetOneValue(){} // RVA: 0x7AC8EB4B0
        public void GetAllBitsSetValue(){} // RVA: 0x7AC8EBF60
        public void .cctor(){} // RVA: 0x7AC8ECA20
    }

}