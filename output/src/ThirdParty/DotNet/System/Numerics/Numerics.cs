// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Numerics
// Classes: 13
// Methods: 194

namespace ThirdParty.DotNet.System.Numerics
{
    public class BigInteger : ValueType
    {
        public int _sign; // 0x10
        public uint[] _bits; // 0x18
        public System.Numerics.BigInteger s_bnMinInt;
        public System.Numerics.BigInteger s_bnOneInt; // 0x10
        public System.Numerics.BigInteger s_bnZeroInt; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87363580 | overloaded x11
        public void get_Zero(){} // RVA: 0x7FFE873638B0
        public void get_MinusOne(){} // RVA: 0x7FFE87363910
        public void get_IsZero(){} // RVA: 0x7FFE86E21EB0
        public void get_IsEven(){} // RVA: 0x7FFE87363970
        public void get_Sign(){} // RVA: 0x7FFE873639B0
        public void Parse(){} // RVA: 0x7FFE87363A60 | overloaded x2
        public void ModPow(){} // RVA: 0x7FFE87363AC0
        public void GetHashCode(){} // RVA: 0x7FFE873642A0
        public void Equals(){} // RVA: 0x7FFE87364420 | overloaded x3
        public void CompareTo(){} // RVA: 0x7FFE87364790 | overloaded x3
        public void ToByteArray(){} // RVA: 0x7FFE87364900 | overloaded x2
        public void TryWriteBytes(){} // RVA: 0x7FFE873649B0
        public void TryWriteOrCountBytes(){} // RVA: 0x7FFE87364A70
        public void TryGetBytes(){} // RVA: 0x7FFE87364B20
        public void ToString(){} // RVA: 0x7FFE87365220 | overloaded x3
        public void Add(){} // RVA: 0x7FFE87365320
        public void op_Subtraction(){} // RVA: 0x7FFE873654E0
        public void Subtract(){} // RVA: 0x7FFE87365700
        public void op_Implicit(){} // RVA: 0x7FFE87365A40 | overloaded x8
        public void op_Explicit(){} // RVA: 0x7FFE873661F0 | overloaded x11
        public void op_LeftShift(){} // RVA: 0x7FFE87366360
        public void op_RightShift(){} // RVA: 0x7FFE87366610
        public void op_UnaryNegation(){} // RVA: 0x7FFE87366A80
        public void op_Addition(){} // RVA: 0x7FFE87366AF0
        public void op_Multiply(){} // RVA: 0x7FFE87366D10
        public void op_Division(){} // RVA: 0x7FFE87367030
        public void op_Modulus(){} // RVA: 0x7FFE873672E0
        public void op_LessThanOrEqual(){} // RVA: 0x7FFE87367830 | overloaded x3
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFE87367530
        public void op_Inequality(){} // RVA: 0x7FFE87367750 | overloaded x2
        public void op_LessThan(){} // RVA: 0x7FFE873677C0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE873676F0
        public void GetPartsForBitManipulation(){} // RVA: 0x7FFE873678A0
        public void GetDiffLength(){} // RVA: 0x7FFE87367A80
        public void .cctor(){} // RVA: 0x7FFE87367AE0
    }

    public class BigIntegerCalculator : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE87368180 | overloaded x3
        public void AddSelf(){} // RVA: 0x7FFE87368230
        public void Subtract(){} // RVA: 0x7FFE87368500 | overloaded x3
        public void SubtractSelf(){} // RVA: 0x7FFE873685B0
        public void Compare(){} // RVA: 0x7FFE873686B0 | overloaded x2
        public void Divide(){} // RVA: 0x7FFE87368A50 | overloaded x3
        public void Remainder(){} // RVA: 0x7FFE87368950 | overloaded x2
        public void AddDivisor(){} // RVA: 0x7FFE87368E30
        public void SubtractDivisor(){} // RVA: 0x7FFE87368E60
        public void DivideGuessTooBig(){} // RVA: 0x7FFE87368EB0
        public void CreateCopy(){} // RVA: 0x7FFE87368EF0
        public void LeadingZeros(){} // RVA: 0x7FFE87368F70
        public void Pow(){} // RVA: 0x7FFE87369660 | overloaded x8
        public void PowCore(){} // RVA: 0x7FFE8736A200 | overloaded x8
        public void ActualLength(){} // RVA: 0x7FFE8736A330 | overloaded x2
        public void Square(){} // RVA: 0x7FFE8736A460 | overloaded x2
        public void Multiply(){} // RVA: 0x7FFE8736AA80 | overloaded x3
        public void SubtractCore(){} // RVA: 0x7FFE8736AFE0
        public void .cctor(){} // RVA: 0x7FFE8736B0F0
    }

    public class BigNumber : Object
    {
        // ── Methods ──
        public void TryValidateParseStyleInteger(){} // RVA: 0x7FFE8736C060
        public void TryParseBigInteger(){} // RVA: 0x7FFE8736C300
        public void ParseBigInteger(){} // RVA: 0x7FFE8736C7A0 | overloaded x2
        public void HexNumberToBigInteger(){} // RVA: 0x7FFE8736C910
        public void NumberToBigInteger(){} // RVA: 0x7FFE8736CBE0
        public void ParseFormatSpecifier(){} // RVA: 0x7FFE8736D080
        public void FormatBigIntegerToHex(){} // RVA: 0x7FFE8736D1D0
        public void FormatBigInteger(){} // RVA: 0x7FFE8736D940 | overloaded x2
    }

    public class BitOperations : Object
    {
        // ── Methods ──
        public void RoundUpToPowerOf2(){} // RVA: 0x7FFE8A547050
        public void get_Log2DeBruijn(){} // RVA: 0x7FFE8A547080
        public void Log2(){} // RVA: 0x7FFE8A5470E0
        public void Log2SoftwareFallback(){} // RVA: 0x7FFE8A5470F0
    }

    public class ConstantHelper : Object
    {
        // ── Methods ──
        public void GetByteWithAllBitsSet(){} // RVA: 0x7FFE868EC210
        public void GetSByteWithAllBitsSet(){} // RVA: 0x7FFE868EC210
        public void GetUInt16WithAllBitsSet(){} // RVA: 0x7FFE868EC220
        public void GetInt16WithAllBitsSet(){} // RVA: 0x7FFE81517DA0
        public void GetUInt32WithAllBitsSet(){} // RVA: 0x7FFE81517DA0
        public void GetInt32WithAllBitsSet(){} // RVA: 0x7FFE81517DA0
        public void GetUInt64WithAllBitsSet(){} // RVA: 0x7FFE82A34CA0
        public void GetInt64WithAllBitsSet(){} // RVA: 0x7FFE82A34CA0
        public void GetSingleWithAllBitsSet(){} // RVA: 0x7FFE82F11E90
        public void GetDoubleWithAllBitsSet(){} // RVA: 0x7FFE82F11EA0
    }

    public class DoubleUlong : ValueType
    {
    }

    public class NumericsHelpers : Object
    {
        // ── Methods ──
        public void GetDoubleParts(){} // RVA: 0x7FFE8736E760
        public void GetDoubleFromParts(){} // RVA: 0x7FFE8736E7F0
        public void DangerousMakeTwosComplement(){} // RVA: 0x7FFE8736E940
        public void MakeUlong(){} // RVA: 0x7FFE8736E9D0
        public void Abs(){} // RVA: 0x7FFE8736E9E0
        public void CombineHash(){} // RVA: 0x7FFE8736E9F0 | overloaded x2
        public void CbitHighZero(){} // RVA: 0x7FFE8736EA00 | overloaded x2
    }

    public class Quaternion : ValueType
    {
        // ── Methods ──
        public void Normalize(){} // RVA: 0x7FFE873604E0
        public void Inverse(){} // RVA: 0x7FFE873605B0
        public void Slerp(){} // RVA: 0x7FFE87360640
        public void op_Multiply(){} // RVA: 0x7FFE87360870
        public void Equals(){} // RVA: 0x7FFE873609B0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE87360A70
        public void GetHashCode(){} // RVA: 0x7FFE87360CE0
    }

    public class Register : ValueType
    {
    }

    public class Vector : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE810A1420
        public void LessThan(){} // RVA: 0x7FFE810A1420
        public void get_IsHardwareAccelerated(){} // RVA: 0x7FFE810FB320
        public void BitwiseOr(){} // RVA: 0x7FFE810A1420
        public void AsVectorByte(){} // RVA: 0x7FFE810A1420
        public void AsVectorUInt64(){} // RVA: 0x7FFE810A1420
    }

    public class Vector2 : ValueType
    {
        public float X; // 0x10

        // ── Methods ──
        public void get_Zero(){} // RVA: 0x7FFE87360D50
        public void GetHashCode(){} // RVA: 0x7FFE87360D60
        public void Equals(){} // RVA: 0x7FFE87361150 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE87360F50 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8111ED10
        public void op_Addition(){} // RVA: 0x7FFE87361180
        public void op_Subtraction(){} // RVA: 0x7FFE873611C0
        public void op_Multiply(){} // RVA: 0x7FFE87361240 | overloaded x2
        public void op_UnaryNegation(){} // RVA: 0x7FFE87361270
    }

    public class Vector3 : ValueType
    {
        public float X; // 0x10

        // ── Methods ──
        public void get_Zero(){} // RVA: 0x7FFE8543D940
        public void GetHashCode(){} // RVA: 0x7FFE873612A0
        public void Equals(){} // RVA: 0x7FFE86FA2B80 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE873614D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8111ED70 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFE87361840
        public void op_Subtraction(){} // RVA: 0x7FFE87361880
        public void op_Multiply(){} // RVA: 0x7FFE87361900 | overloaded x2
        public void op_Division(){} // RVA: 0x7FFE87361940 | overloaded x2
        public void op_UnaryNegation(){} // RVA: 0x7FFE87361980
    }

    public class Vector`1 : ValueType
    {
        public System.Numerics.Register register; // 0x10
        public int s_count;
        public System.Numerics.Vector`1<ushort> s_zero; // 0x4
    }

}