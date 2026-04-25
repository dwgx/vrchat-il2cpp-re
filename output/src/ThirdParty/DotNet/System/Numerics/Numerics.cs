// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Numerics
// Classes: 13
// Methods: 178

namespace ThirdParty.DotNet.System.Numerics
{
    public class BigInteger : ValueType
    {
        public int Zero; // 0x10
        public uint[] MinusOne; // 0x18
        public System.Numerics.BigInteger IsZero;
        public System.Numerics.BigInteger IsEven; // 0x10
        public System.Numerics.BigInteger Sign; // 0x20
        public System.Numerics.BigInteger s_bnMinusOneInt; // 0x30
        public byte[] s_success; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FBADC0 | overloaded x11
        public void get_Zero(){} // RVA: 0x7FFAC8FBB0F0
        public void get_MinusOne(){} // RVA: 0x7FFAC8FBB150
        public void get_IsZero(){} // RVA: 0x7FFAC8A78820
        public void get_IsEven(){} // RVA: 0x7FFAC8FBB1B0
        public void get_Sign(){} // RVA: 0x7FFAC8FBB1F0
        public void Parse(){} // RVA: 0x7FFAC8FBB2A0 | overloaded x2
        public void ModPow(){} // RVA: 0x7FFAC8FBB300
        public void GetHashCode(){} // RVA: 0x7FFAC8FBBAE0
        public void Equals(){} // RVA: 0x7FFAC8FBBC60 | overloaded x3
        public void CompareTo(){} // RVA: 0x7FFAC8FBBFD0 | overloaded x3
        public void ToByteArray(){} // RVA: 0x7FFAC8FBC140 | overloaded x2
        public void TryWriteBytes(){} // RVA: 0x7FFAC8FBC1F0
        public void TryWriteOrCountBytes(){} // RVA: 0x7FFAC8FBC2B0
        public void TryGetBytes(){} // RVA: 0x7FFAC8FBC360
        public void ToString(){} // RVA: 0x7FFAC8FBCA60 | overloaded x3
        public void Add(){} // RVA: 0x7FFAC8FBCB60
        public void op_Subtraction(){} // RVA: 0x7FFAC8FBCD20
        public void Subtract(){} // RVA: 0x7FFAC8FBCF40
        public void op_Implicit(){} // RVA: 0x7FFAC8FBD280 | overloaded x8
        public void op_Explicit(){} // RVA: 0x7FFAC8FBDA30 | overloaded x11
        public void op_LeftShift(){} // RVA: 0x7FFAC8FBDBA0
        public void op_RightShift(){} // RVA: 0x7FFAC8FBDE50
        public void op_UnaryNegation(){} // RVA: 0x7FFAC8FBE2C0
        public void op_Addition(){} // RVA: 0x7FFAC8FBE330
        public void op_Multiply(){} // RVA: 0x7FFAC8FBE550
        public void op_Division(){} // RVA: 0x7FFAC8FBE870
        public void op_Modulus(){} // RVA: 0x7FFAC8FBEB20
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAC8FBF070 | overloaded x3
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAC8FBED70
        public void op_Inequality(){} // RVA: 0x7FFAC8FBEF90 | overloaded x2
        public void op_LessThan(){} // RVA: 0x7FFAC8FBF000 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC8FBEF30
        public void GetPartsForBitManipulation(){} // RVA: 0x7FFAC8FBF0E0
        public void GetDiffLength(){} // RVA: 0x7FFAC8FBF2C0
        public void .cctor(){} // RVA: 0x7FFAC8FBF320
    }

    public class BigIntegerCalculator : Object
    {
        public int ReducerThreshold;
        public int SquareThreshold; // 0x4
        public int AllocationThreshold; // 0x8
        public int MultiplyThreshold; // 0xC

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC8FBF9C0 | overloaded x3
        public void AddSelf(){} // RVA: 0x7FFAC8FBFA70
        public void Subtract(){} // RVA: 0x7FFAC8FBFD40 | overloaded x3
        public void SubtractSelf(){} // RVA: 0x7FFAC8FBFDF0
        public void Compare(){} // RVA: 0x7FFAC8FBFEF0 | overloaded x2
        public void Divide(){} // RVA: 0x7FFAC8FC0290 | overloaded x3
        public void Remainder(){} // RVA: 0x7FFAC8FC0190 | overloaded x2
        public void AddDivisor(){} // RVA: 0x7FFAC8FC0670
        public void SubtractDivisor(){} // RVA: 0x7FFAC8FC06A0
        public void DivideGuessTooBig(){} // RVA: 0x7FFAC8FC06F0
        public void CreateCopy(){} // RVA: 0x7FFAC8FC0730
        public void LeadingZeros(){} // RVA: 0x7FFAC8FC07B0
        public void Pow(){} // RVA: 0x7FFAC8FC0EA0 | overloaded x8
        public void PowCore(){} // RVA: 0x7FFAC8FC1A40 | overloaded x8
        public void ActualLength(){} // RVA: 0x7FFAC8FC1B70 | overloaded x2
        public void Square(){} // RVA: 0x7FFAC8FC1CA0 | overloaded x2
        public void Multiply(){} // RVA: 0x7FFAC8FC22C0 | overloaded x3
        public void SubtractCore(){} // RVA: 0x7FFAC8FC2820
        public void .cctor(){} // RVA: 0x7FFAC8FC2930
    }

    public class BigNumber : Object
    {
        // ── Methods ──
        public void TryValidateParseStyleInteger(){} // RVA: 0x7FFAC8FC38A0
        public void TryParseBigInteger(){} // RVA: 0x7FFAC8FC3B40
        public void ParseBigInteger(){} // RVA: 0x7FFAC8FC3FE0 | overloaded x2
        public void HexNumberToBigInteger(){} // RVA: 0x7FFAC8FC4150
        public void NumberToBigInteger(){} // RVA: 0x7FFAC8FC4420
        public void ParseFormatSpecifier(){} // RVA: 0x7FFAC8FC48C0
        public void FormatBigIntegerToHex(){} // RVA: 0x7FFAC8FC4A10
        public void FormatBigInteger(){} // RVA: 0x7FFAC8FC5180 | overloaded x2
    }

    public class BitOperations : Object
    {
        public object Log2DeBruijn;

        // ── Methods ──
        public void RoundUpToPowerOf2(){} // RVA: 0x7FFACC0E1080
        public void get_Log2DeBruijn(){} // RVA: 0x7FFACC0E10B0
        public void Log2(){} // RVA: 0x7FFACC0E1110
        public void Log2SoftwareFallback(){} // RVA: 0x7FFACC0E1120
    }

    public class ConstantHelper : Object
    {
        // ── Methods ──
        public void GetByteWithAllBitsSet(){} // RVA: 0x7FFAC85429E0
        public void GetSByteWithAllBitsSet(){} // RVA: 0x7FFAC85429E0
        public void GetUInt16WithAllBitsSet(){} // RVA: 0x7FFAC85429F0
        public void GetInt16WithAllBitsSet(){} // RVA: 0x7FFAC32BD0E0
        public void GetUInt32WithAllBitsSet(){} // RVA: 0x7FFAC32BD0E0
        public void GetInt32WithAllBitsSet(){} // RVA: 0x7FFAC32BD0E0
        public void GetUInt64WithAllBitsSet(){} // RVA: 0x7FFAC47CC900
        public void GetInt64WithAllBitsSet(){} // RVA: 0x7FFAC47CC900
        public void GetSingleWithAllBitsSet(){} // RVA: 0x7FFAC4C78880
        public void GetDoubleWithAllBitsSet(){} // RVA: 0x7FFAC4C78890
    }

    public class DoubleUlong : ValueType
    {
        public double dbl; // 0x10
        public ulong uu; // 0x10
    }

    public class NumericsHelpers : Object
    {
        // ── Methods ──
        public void GetDoubleParts(){} // RVA: 0x7FFAC8FC5FA0
        public void GetDoubleFromParts(){} // RVA: 0x7FFAC8FC6030
        public void DangerousMakeTwosComplement(){} // RVA: 0x7FFAC8FC6180
        public void MakeUlong(){} // RVA: 0x7FFAC8FC6210
        public void Abs(){} // RVA: 0x7FFAC8FC6220
        public void CombineHash(){} // RVA: 0x7FFAC8FC6230 | overloaded x2
        public void CbitHighZero(){} // RVA: 0x7FFAC8FC6240 | overloaded x2
    }

    public class Quaternion : ValueType
    {
        public float X; // 0x10
        public float Y; // 0x14
        public float Z; // 0x18
        public float W; // 0x1C

        // ── Methods ──
        public void Inverse(){} // RVA: 0x7FFAC8FB80C0
        public void Slerp(){} // RVA: 0x7FFAC8FB8150
        public void op_Multiply(){} // RVA: 0x7FFAC8FB8380
        public void Equals(){} // RVA: 0x7FFAC8FB84C0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC8FB8580
        public void GetHashCode(){} // RVA: 0x7FFAC8FB87F0
    }

    public class Register : ValueType
    {
        public byte byte_0; // 0x10
        public byte byte_1; // 0x11
        public byte byte_2; // 0x12
        public byte byte_3; // 0x13
        public byte byte_4; // 0x14
        public byte byte_5; // 0x15
        public byte byte_6; // 0x16
        public byte byte_7; // 0x17
        public byte byte_8; // 0x18
        public byte byte_9; // 0x19
        public byte byte_10; // 0x1A
        public byte byte_11; // 0x1B
        public byte byte_12; // 0x1C
        public byte byte_13; // 0x1D
        public byte byte_14; // 0x1E
        public byte byte_15; // 0x1F
        public sbyte sbyte_0; // 0x10
        public sbyte sbyte_1; // 0x11
        public sbyte sbyte_2; // 0x12
        public sbyte sbyte_3; // 0x13
        public sbyte sbyte_4; // 0x14
        public sbyte sbyte_5; // 0x15
        public sbyte sbyte_6; // 0x16
        public sbyte sbyte_7; // 0x17
        public sbyte sbyte_8; // 0x18
        public sbyte sbyte_9; // 0x19
        public sbyte sbyte_10; // 0x1A
        public sbyte sbyte_11; // 0x1B
        public sbyte sbyte_12; // 0x1C
        public sbyte sbyte_13; // 0x1D
        public sbyte sbyte_14; // 0x1E
        public sbyte sbyte_15; // 0x1F
        public ushort uint16_0; // 0x10
        public ushort uint16_1; // 0x12
        public ushort uint16_2; // 0x14
        public ushort uint16_3; // 0x16
        public ushort uint16_4; // 0x18
        public ushort uint16_5; // 0x1A
        public ushort uint16_6; // 0x1C
        public ushort uint16_7; // 0x1E
        public short int16_0; // 0x10
        public short int16_1; // 0x12
        public short int16_2; // 0x14
        public short int16_3; // 0x16
        public short int16_4; // 0x18
        public short int16_5; // 0x1A
        public short int16_6; // 0x1C
        public short int16_7; // 0x1E
        public uint uint32_0; // 0x10
        public uint uint32_1; // 0x14
        public uint uint32_2; // 0x18
        public uint uint32_3; // 0x1C
        public int int32_0; // 0x10
        public int int32_1; // 0x14
        public int int32_2; // 0x18
        public int int32_3; // 0x1C
        public ulong uint64_0; // 0x10
        public ulong uint64_1; // 0x18
        public long int64_0; // 0x10
        public long int64_1; // 0x18
        public float single_0; // 0x10
        public float single_1; // 0x14
        public float single_2; // 0x18
        public float single_3; // 0x1C
        public double double_0; // 0x10
        public double double_1; // 0x18
    }

    public class Vector : Object
    {
        public object IsHardwareAccelerated;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2E8DC40
        public void LessThan(){} // RVA: 0x7FFAC2E8DC40
        public void get_IsHardwareAccelerated(){} // RVA: 0x7FFAC2F21320
        public void BitwiseOr(){} // RVA: 0x7FFAC2E8DC40
        public void AsVectorByte(){} // RVA: 0x7FFAC2E8DC40
        public void AsVectorUInt64(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Vector2 : ValueType
    {
        public float X; // 0x10
        public float Y; // 0x14

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAC8FB8860
        public void Equals(){} // RVA: 0x7FFAC8FB8C50 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC8FB8A50 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F44D10
    }

    public class Vector3 : ValueType
    {
        public float X; // 0x10
        public float Y; // 0x14
        public float Z; // 0x18

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAC8FB8C80
        public void Equals(){} // RVA: 0x7FFAC8BF9BC0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC8FB8EB0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F44D70
    }

    public class Vector`1 : ValueType
    {
        public System.Numerics.Register register; // 0x10
        public int s_count;
        public System.Numerics.Vector`1<ushort> s_zero; // 0x4
        public System.Numerics.Vector`1<ushort> s_one; // 0x14
        public System.Numerics.Vector`1<ushort> s_allOnes; // 0x24
    }

}