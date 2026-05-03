// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data.SqlTypes
// Classes: 23
// Methods: 520

namespace ThirdParty.DotNet.System.Data.SqlTypes
{
    public class INullable
    {
        // ── Methods ──
        public void get_IsNull(){} // RVA: 0x7FFE80E2F150
    }

    public class SQLResource : Object
    {
        // ── Methods ──
        public void get_NullString(){} // RVA: 0x7FFE872B3250
        public void get_ArithOverflowMessage(){} // RVA: 0x7FFE872B3290
        public void get_DivideByZeroMessage(){} // RVA: 0x7FFE872B32D0
        public void get_NullValueMessage(){} // RVA: 0x7FFE872B3310
        public void get_TruncationMessage(){} // RVA: 0x7FFE872B3350
        public void get_DateTimeOverflowMessage(){} // RVA: 0x7FFE872B3390
        public void get_ConcatDiffCollationMessage(){} // RVA: 0x7FFE872B33D0
        public void get_CompareDiffCollationMessage(){} // RVA: 0x7FFE872B3410
        public void get_ConversionOverflowMessage(){} // RVA: 0x7FFE872B3450
        public void get_TimeZoneSpecifiedMessage(){} // RVA: 0x7FFE872B3490
        public void get_InvalidPrecScaleMessage(){} // RVA: 0x7FFE872B34D0
        public void get_FormatMessage(){} // RVA: 0x7FFE872B3510
        public void InvalidOpStreamClosed(){} // RVA: 0x7FFE872B3550
        public void InvalidOpStreamNonWritable(){} // RVA: 0x7FFE872B35A0
        public void InvalidOpStreamNonReadable(){} // RVA: 0x7FFE872B35F0
        public void InvalidOpStreamNonSeekable(){} // RVA: 0x7FFE872B3640
    }

    public class SqlBinary : ValueType
    {
        public byte[] _value; // 0x10
        public System.Data.SqlTypes.SqlBinary Null;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872B36F0 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFE82AB4690
        public void get_Value(){} // RVA: 0x7FFE872B38C0
        public void op_Implicit(){} // RVA: 0x7FFE872B39A0
        public void ToString(){} // RVA: 0x7FFE872B39D0
        public void PerformCompareByte(){} // RVA: 0x7FFE872B3AE0
        public void op_Equality(){} // RVA: 0x7FFE872B3C00
        public void op_LessThan(){} // RVA: 0x7FFE872B3D10
        public void op_GreaterThan(){} // RVA: 0x7FFE872B3E20
        public void CompareTo(){} // RVA: 0x7FFE872B4050 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872B4390
        public void HashByteArray(){} // RVA: 0x7FFE872B45E0
        public void GetHashCode(){} // RVA: 0x7FFE872B4650
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872B4730
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872B4A70
        public void GetXsdType(){} // RVA: 0x7FFE872B4C50
        public void .cctor(){} // RVA: 0x7FFE872B4CD0
    }

    public class SqlBoolean : ValueType
    {
        public byte m_value; // 0x10
        public System.Data.SqlTypes.SqlBoolean True;
        public System.Data.SqlTypes.SqlBoolean False; // 0x1
        public System.Data.SqlTypes.SqlBoolean Null; // 0x2
        public System.Data.SqlTypes.SqlBoolean Zero; // 0x3

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872B4E30 | overloaded x3
        public void get_IsNull(){} // RVA: 0x7FFE842A4A30
        public void get_Value(){} // RVA: 0x7FFE872B4E50
        public void get_IsTrue(){} // RVA: 0x7FFE872B4EB0
        public void get_IsFalse(){} // RVA: 0x7FFE872B4EC0
        public void op_Implicit(){} // RVA: 0x7FFE872B4ED0
        public void op_True(){} // RVA: 0x7FFE872B4EE0
        public void op_BitwiseAnd(){} // RVA: 0x7FFE872B4F30
        public void op_BitwiseOr(){} // RVA: 0x7FFE872B5020
        public void get_ByteValue(){} // RVA: 0x7FFE872B5110
        public void ToString(){} // RVA: 0x7FFE872B51A0
        public void op_Equality(){} // RVA: 0x7FFE872B52B0
        public void And(){} // RVA: 0x7FFE872B5370
        public void Or(){} // RVA: 0x7FFE872B5490
        public void CompareTo(){} // RVA: 0x7FFE872B5610 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872B5730
        public void GetHashCode(){} // RVA: 0x7FFE872B58F0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872B5990
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872B5AC0
        public void GetXsdType(){} // RVA: 0x7FFE872B5C20
        public void .cctor(){} // RVA: 0x7FFE872B5CA0
    }

    public class SqlByte : ValueType
    {
        public bool m_fNotNull; // 0x10
        public byte m_value; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8491B430 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFE842A4A30
        public void get_Value(){} // RVA: 0x7FFE872B5DB0
        public void op_Implicit(){} // RVA: 0x7FFE872B5E10
        public void ToString(){} // RVA: 0x7FFE872B5E20
        public void op_Addition(){} // RVA: 0x7FFE872B5EB0
        public void op_Subtraction(){} // RVA: 0x7FFE872B5FE0
        public void op_Multiply(){} // RVA: 0x7FFE872B6110
        public void op_Division(){} // RVA: 0x7FFE872B6240
        public void op_Explicit(){} // RVA: 0x7FFE872B6360
        public void op_Equality(){} // RVA: 0x7FFE872B6520
        public void op_LessThan(){} // RVA: 0x7FFE872B65F0
        public void op_GreaterThan(){} // RVA: 0x7FFE872B66C0
        public void LessThan(){} // RVA: 0x7FFE872B6790
        public void GreaterThan(){} // RVA: 0x7FFE872B67F0
        public void ToSqlDouble(){} // RVA: 0x7FFE872B6850
        public void ToSqlInt64(){} // RVA: 0x7FFE872B68C0
        public void CompareTo(){} // RVA: 0x7FFE872B6A50 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872B6C00
        public void GetHashCode(){} // RVA: 0x7FFE872B6E40
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872B6EF0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872B70A0
        public void GetXsdType(){} // RVA: 0x7FFE872B7210
        public void .cctor(){} // RVA: 0x7FFE872B7290
    }

    public class SqlBytes : Object
    {
        public byte[] _rgbBuf; // 0x10
        public long _lCurLen; // 0x18
        public System.IO.Stream _stream; // 0x20
        public 0x665CA9CC _state; // 0x28
        public byte[] _rgbWorkBuf; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872B74A0 | overloaded x3
        public void get_IsNull(){} // RVA: 0x7FFE81F50940
        public void get_Buffer(){} // RVA: 0x7FFE872B7530
        public void get_Length(){} // RVA: 0x7FFE872B7560
        public void get_Value(){} // RVA: 0x7FFE872B75F0
        public void SetNull(){} // RVA: 0x7FFE872B7830
        public void CopyStreamToBuffer(){} // RVA: 0x7FFE872B78A0
        public void FStream(){} // RVA: 0x7FFE872B7AD0
        public void SetBuffer(){} // RVA: 0x7FFE872B7AE0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872B7BC0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872B7E50
        public void GetXsdType(){} // RVA: 0x7FFE872B8040
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE872B80C0
        public void get_Null(){} // RVA: 0x7FFE872B8100
    }

    public class SqlChars : Object
    {
        public char[] _rgchBuf; // 0x10
        public long _lCurLen; // 0x18
        public System.Data.SqlTypes.SqlStreamChars _stream; // 0x20
        public 0x665CA9CC _state; // 0x28
        public char[] _rgchWorkBuf; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872B8150 | overloaded x3
        public void get_IsNull(){} // RVA: 0x7FFE81F50940
        public void get_Buffer(){} // RVA: 0x7FFE872B81F0
        public void get_Length(){} // RVA: 0x7FFE872B8220
        public void get_Value(){} // RVA: 0x7FFE872B82B0
        public void SetNull(){} // RVA: 0x7FFE872B7830
        public void FStream(){} // RVA: 0x7FFE872B7AD0
        public void CopyStreamToBuffer(){} // RVA: 0x7FFE872B84F0
        public void SetBuffer(){} // RVA: 0x7FFE872B7AE0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872B8720
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872B8910
        public void GetXsdType(){} // RVA: 0x7FFE872B8AD0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE872B8B50
        public void get_Null(){} // RVA: 0x7FFE872B8B90
    }

    public class SqlDateTime : ValueType
    {
        public bool m_fNotNull; // 0x10
        public int m_day; // 0x14
        public int m_time; // 0x18
        public double s_SQLTicksPerMillisecond;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872B8C60 | overloaded x3
        public void get_IsNull(){} // RVA: 0x7FFE842A4A30
        public void ToTimeSpan(){} // RVA: 0x7FFE872B8D90
        public void ToDateTime(){} // RVA: 0x7FFE872B8E20
        public void FromTimeSpan(){} // RVA: 0x7FFE872B8F80
        public void FromDateTime(){} // RVA: 0x7FFE872B9180
        public void get_Value(){} // RVA: 0x7FFE872B9330
        public void get_DayTicks(){} // RVA: 0x7FFE872B93E0
        public void get_TimeTicks(){} // RVA: 0x7FFE872B9440
        public void op_Implicit(){} // RVA: 0x7FFE872B94A0
        public void ToString(){} // RVA: 0x7FFE872B94D0
        public void op_Equality(){} // RVA: 0x7FFE872B9600
        public void op_LessThan(){} // RVA: 0x7FFE872B96E0
        public void op_GreaterThan(){} // RVA: 0x7FFE872B97D0
        public void LessThan(){} // RVA: 0x7FFE872B98C0
        public void GreaterThan(){} // RVA: 0x7FFE872B9950
        public void CompareTo(){} // RVA: 0x7FFE872B9B20 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872B9D30
        public void GetHashCode(){} // RVA: 0x7FFE872B9F90
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872BA080
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872BA380
        public void GetXsdType(){} // RVA: 0x7FFE872BA5E0
        public void .cctor(){} // RVA: 0x7FFE872BA660
    }

    public class SqlDecimal : ValueType
    {
        public byte _bStatus; // 0x10
        public byte _bLen; // 0x11
        public byte _bPrec; // 0x12
        public byte _bScale; // 0x13
        public uint _data1; // 0x14

        // ── Methods ──
        public void CalculatePrecision(){} // RVA: 0x7FFE872BAE00
        public void VerifyPrecision(){} // RVA: 0x7FFE872BB040
        public void .ctor(){} // RVA: 0x7FFE872BB880 | overloaded x5
        public void get_IsNull(){} // RVA: 0x7FFE872BBAB0
        public void get_Value(){} // RVA: 0x7FFE872BBB20
        public void get_IsPositive(){} // RVA: 0x7FFE872BBB90
        public void SetPositive(){} // RVA: 0x7FFE872BBCB0
        public void SetSignBit(){} // RVA: 0x7FFE872BBD20
        public void get_Scale(){} // RVA: 0x7FFE872BBDD0
        public void get_Data(){} // RVA: 0x7FFE872BBEC0
        public void ToString(){} // RVA: 0x7FFE872BC010
        public void Parse(){} // RVA: 0x7FFE872BC450
        public void ToDouble(){} // RVA: 0x7FFE872BCBD0
        public void ToDecimal(){} // RVA: 0x7FFE872BCDB0
        public void op_Implicit(){} // RVA: 0x7FFE872BF150 | overloaded x7
        public void op_UnaryNegation(){} // RVA: 0x7FFE872BD020
        public void op_Addition(){} // RVA: 0x7FFE872BD230
        public void op_Subtraction(){} // RVA: 0x7FFE872BD9F0
        public void op_Multiply(){} // RVA: 0x7FFE872BDAC0
        public void op_Division(){} // RVA: 0x7FFE872BE740
        public void ZeroToMaxLen(){} // RVA: 0x7FFE872BF250
        public void FZero(){} // RVA: 0x7FFE872BF2D0
        public void FGt10_38(){} // RVA: 0x7FFE872BF330 | overloaded x2
        public void BGetPrecUI4(){} // RVA: 0x7FFE872BF380
        public void BGetPrecUI8(){} // RVA: 0x7FFE872BF530
        public void AddULong(){} // RVA: 0x7FFE872BF8C0
        public void MultByULong(){} // RVA: 0x7FFE872BFB50
        public void DivByULong(){} // RVA: 0x7FFE872BFE10
        public void AdjustScale(){} // RVA: 0x7FFE872C0000
        public void LAbsCmp(){} // RVA: 0x7FFE872C03F0
        public void MpMove(){} // RVA: 0x7FFE872C05A0
        public void MpSet(){} // RVA: 0x7FFE872C0600
        public void MpNormalize(){} // RVA: 0x7FFE872C0630
        public void MpMul1(){} // RVA: 0x7FFE872C0670
        public void MpDiv1(){} // RVA: 0x7FFE872C0750
        public void DWL(){} // RVA: 0x7FFE872C0850
        public void HI(){} // RVA: 0x7FFE869E75F0
        public void LO(){} // RVA: 0x7FFE82E53610
        public void MpDiv(){} // RVA: 0x7FFE872C0860
        public void CompareNm(){} // RVA: 0x7FFE872C1460
        public void CheckValidPrecScale(){} // RVA: 0x7FFE872C1650
        public void op_Equality(){} // RVA: 0x7FFE872C1730
        public void op_LessThan(){} // RVA: 0x7FFE872C1880
        public void op_GreaterThan(){} // RVA: 0x7FFE872C19D0
        public void LessThan(){} // RVA: 0x7FFE872C1B20
        public void GreaterThan(){} // RVA: 0x7FFE872C1BB0
        public void ToSqlDouble(){} // RVA: 0x7FFE872C1C40
        public void ToSqlInt64(){} // RVA: 0x7FFE872C1CD0
        public void ToSqlMoney(){} // RVA: 0x7FFE872C1D60
        public void ChFromDigit(){} // RVA: 0x7FFE872C1F40
        public void StoreFromWorkingArray(){} // RVA: 0x7FFE872C1F50
        public void SetToZero(){} // RVA: 0x7FFE872C1FA0
        public void CompareTo(){} // RVA: 0x7FFE872C2140 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872C23B0
        public void GetHashCode(){} // RVA: 0x7FFE872C27E0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872C2960
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872C2B20
        public void GetXsdType(){} // RVA: 0x7FFE872C2CE0
        public void .cctor(){} // RVA: 0x7FFE872C2D60
    }

    public class SqlDouble : ValueType
    {
        public bool m_fNotNull; // 0x10
        public double m_value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872C36D0 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFE842A4A30
        public void get_Value(){} // RVA: 0x7FFE872C3760
        public void op_Implicit(){} // RVA: 0x7FFE872C4460 | overloaded x8
        public void ToString(){} // RVA: 0x7FFE872C37E0
        public void op_UnaryNegation(){} // RVA: 0x7FFE872C3870
        public void op_Addition(){} // RVA: 0x7FFE872C3930
        public void op_Subtraction(){} // RVA: 0x7FFE872C3A80
        public void op_Multiply(){} // RVA: 0x7FFE872C3BD0
        public void op_Division(){} // RVA: 0x7FFE872C3D20
        public void op_Equality(){} // RVA: 0x7FFE872C4590
        public void op_LessThan(){} // RVA: 0x7FFE872C4660
        public void op_GreaterThan(){} // RVA: 0x7FFE872C4730
        public void LessThan(){} // RVA: 0x7FFE872C4800
        public void GreaterThan(){} // RVA: 0x7FFE872C4920
        public void ToSqlSingle(){} // RVA: 0x7FFE872C4A40
        public void CompareTo(){} // RVA: 0x7FFE872C4D10 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872C4F60
        public void GetHashCode(){} // RVA: 0x7FFE872C51D0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872C52B0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872C53E0
        public void GetXsdType(){} // RVA: 0x7FFE872C5560
        public void .cctor(){} // RVA: 0x7FFE872C55E0
    }

    public class SqlGuid : ValueType
    {
        public int s_sizeOfGuid;
        public int[] s_rgiGuidOrder; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872C57F0 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFE82AB4690
        public void get_Value(){} // RVA: 0x7FFE872C5860
        public void op_Implicit(){} // RVA: 0x7FFE872C5950
        public void ToString(){} // RVA: 0x7FFE872C59C0
        public void Compare(){} // RVA: 0x7FFE872C5AE0
        public void op_Equality(){} // RVA: 0x7FFE872C5BF0
        public void op_LessThan(){} // RVA: 0x7FFE872C5CE0
        public void op_GreaterThan(){} // RVA: 0x7FFE872C5DC0
        public void CompareTo(){} // RVA: 0x7FFE872C5FD0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872C62D0
        public void GetHashCode(){} // RVA: 0x7FFE872C6500
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872C65A0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872C6870
        public void GetXsdType(){} // RVA: 0x7FFE872C6A80
        public void .cctor(){} // RVA: 0x7FFE872C6B00
    }

    public class SqlInt16 : ValueType
    {
        public bool m_fNotNull; // 0x10
        public short m_value; // 0x12

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84929860 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFE842A4A30
        public void get_Value(){} // RVA: 0x7FFE872C6CD0
        public void op_Implicit(){} // RVA: 0x7FFE872C73D0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE872C6D50
        public void op_UnaryNegation(){} // RVA: 0x7FFE872C6DE0
        public void op_Addition(){} // RVA: 0x7FFE872C6E80
        public void op_Subtraction(){} // RVA: 0x7FFE872C6FB0
        public void op_Multiply(){} // RVA: 0x7FFE872C70E0
        public void op_Division(){} // RVA: 0x7FFE872C7240
        public void op_Explicit(){} // RVA: 0x7FFE872C7490
        public void op_Equality(){} // RVA: 0x7FFE872C75F0
        public void op_LessThan(){} // RVA: 0x7FFE872C76C0
        public void op_GreaterThan(){} // RVA: 0x7FFE872C7790
        public void LessThan(){} // RVA: 0x7FFE872C7860
        public void GreaterThan(){} // RVA: 0x7FFE872C78C0
        public void ToSqlDouble(){} // RVA: 0x7FFE872C7920
        public void ToSqlInt64(){} // RVA: 0x7FFE872C7990
        public void CompareTo(){} // RVA: 0x7FFE872C7B20 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872C7CC0
        public void GetHashCode(){} // RVA: 0x7FFE872C7F00
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872C7FC0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872C8170
        public void GetXsdType(){} // RVA: 0x7FFE872C82E0
        public void .cctor(){} // RVA: 0x7FFE872C8360
    }

    public class SqlInt32 : ValueType
    {
        public bool m_fNotNull; // 0x10
        public int m_value; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84931890 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFE842A4A30
        public void get_Value(){} // RVA: 0x7FFE872C8430
        public void op_Implicit(){} // RVA: 0x7FFE872C8CF0 | overloaded x3
        public void ToString(){} // RVA: 0x7FFE872C84E0
        public void op_UnaryNegation(){} // RVA: 0x7FFE872C8570
        public void op_Addition(){} // RVA: 0x7FFE872C8610
        public void op_Subtraction(){} // RVA: 0x7FFE872C87A0
        public void op_Multiply(){} // RVA: 0x7FFE872C8920
        public void op_Division(){} // RVA: 0x7FFE872C8A90
        public void op_Explicit(){} // RVA: 0x7FFE872C8DB0
        public void SameSignInt(){} // RVA: 0x7FFE872C8F10
        public void op_Equality(){} // RVA: 0x7FFE872C8F30
        public void op_LessThan(){} // RVA: 0x7FFE872C9000
        public void op_GreaterThan(){} // RVA: 0x7FFE872C90D0
        public void LessThan(){} // RVA: 0x7FFE872C91A0
        public void GreaterThan(){} // RVA: 0x7FFE872C9200
        public void ToSqlDouble(){} // RVA: 0x7FFE872C9260
        public void ToSqlInt64(){} // RVA: 0x7FFE872C92D0
        public void CompareTo(){} // RVA: 0x7FFE872C9460 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872C9610
        public void GetHashCode(){} // RVA: 0x7FFE872C9850
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872C98C0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872C9A00
        public void GetXsdType(){} // RVA: 0x7FFE872C9B70
        public void .cctor(){} // RVA: 0x7FFE872C9BF0
    }

    public class SqlInt64 : ValueType
    {
        public bool m_fNotNull; // 0x10
        public long m_value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8492DCA0 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFE842A4A30
        public void get_Value(){} // RVA: 0x7FFE872C9CD0
        public void op_Implicit(){} // RVA: 0x7FFE872CA980 | overloaded x4
        public void ToString(){} // RVA: 0x7FFE872C9D50
        public void op_UnaryNegation(){} // RVA: 0x7FFE872C9DE0
        public void op_Addition(){} // RVA: 0x7FFE872C9E90
        public void op_Subtraction(){} // RVA: 0x7FFE872CA000
        public void op_Multiply(){} // RVA: 0x7FFE872CA180
        public void op_Division(){} // RVA: 0x7FFE872CA4C0
        public void op_Modulus(){} // RVA: 0x7FFE872CA650
        public void op_Explicit(){} // RVA: 0x7FFE872CAA60
        public void SameSignLong(){} // RVA: 0x7FFE872CAD20
        public void op_Equality(){} // RVA: 0x7FFE872CAD40
        public void op_LessThan(){} // RVA: 0x7FFE872CAE10
        public void op_GreaterThan(){} // RVA: 0x7FFE872CAEE0
        public void LessThan(){} // RVA: 0x7FFE872CAFB0
        public void GreaterThan(){} // RVA: 0x7FFE872CB0B0
        public void ToSqlByte(){} // RVA: 0x7FFE872CB1B0
        public void ToSqlDouble(){} // RVA: 0x7FFE872CB220
        public void ToSqlInt16(){} // RVA: 0x7FFE872CB2A0
        public void ToSqlInt32(){} // RVA: 0x7FFE872CB410
        public void ToSqlDecimal(){} // RVA: 0x7FFE872CB580
        public void CompareTo(){} // RVA: 0x7FFE872CB740 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872CB990
        public void GetHashCode(){} // RVA: 0x7FFE872CBBF0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872CBCB0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872CBDF0
        public void GetXsdType(){} // RVA: 0x7FFE872CBF60
        public void .cctor(){} // RVA: 0x7FFE872CBFE0
    }

    public class SqlMoney : ValueType
    {
        public bool _fNotNull; // 0x10
        public long _value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872CC250 | overloaded x5
        public void get_IsNull(){} // RVA: 0x7FFE842A4A30
        public void get_Value(){} // RVA: 0x7FFE872CC440
        public void ToDecimal(){} // RVA: 0x7FFE872CC4F0
        public void ToDouble(){} // RVA: 0x7FFE872CC610
        public void op_Implicit(){} // RVA: 0x7FFE872CD460 | overloaded x6
        public void ToString(){} // RVA: 0x7FFE872CC780
        public void op_UnaryNegation(){} // RVA: 0x7FFE872CC990
        public void op_Addition(){} // RVA: 0x7FFE872CCAC0
        public void op_Subtraction(){} // RVA: 0x7FFE872CCC60
        public void op_Multiply(){} // RVA: 0x7FFE872CCE00
        public void op_Division(){} // RVA: 0x7FFE872CCFE0
        public void op_Explicit(){} // RVA: 0x7FFE872CD570
        public void op_Equality(){} // RVA: 0x7FFE872CD6F0
        public void op_LessThan(){} // RVA: 0x7FFE872CD7C0
        public void op_GreaterThan(){} // RVA: 0x7FFE872CD890
        public void LessThan(){} // RVA: 0x7FFE872CD960
        public void GreaterThan(){} // RVA: 0x7FFE872CDA60
        public void ToSqlDouble(){} // RVA: 0x7FFE872CDB60
        public void ToSqlDecimal(){} // RVA: 0x7FFE872CDCF0
        public void CompareTo(){} // RVA: 0x7FFE872CDEB0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872CE100
        public void GetHashCode(){} // RVA: 0x7FFE872CE360
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872CE3C0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872CE5A0
        public void GetXsdType(){} // RVA: 0x7FFE872CE810
        public void .cctor(){} // RVA: 0x7FFE872CE890
    }

    public class SqlNullValueException : SqlTypeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872D3210 | overloaded x4
        public void SqlNullValueExceptionSerialization(){} // RVA: 0x7FFE872D3310
    }

    public class SqlSingle : ValueType
    {
        public bool _fNotNull; // 0x10
        public float _value; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872CEAA0 | overloaded x3
        public void get_IsNull(){} // RVA: 0x7FFE842A4A30
        public void get_Value(){} // RVA: 0x7FFE872CEB10
        public void op_Implicit(){} // RVA: 0x7FFE872CFA50 | overloaded x7
        public void ToString(){} // RVA: 0x7FFE872CEC00
        public void op_UnaryNegation(){} // RVA: 0x7FFE872CEC90
        public void op_Addition(){} // RVA: 0x7FFE872CEDA0
        public void op_Subtraction(){} // RVA: 0x7FFE872CEF30
        public void op_Multiply(){} // RVA: 0x7FFE872CF0C0
        public void op_Division(){} // RVA: 0x7FFE872CF250
        public void op_Explicit(){} // RVA: 0x7FFE872CFC10
        public void op_Equality(){} // RVA: 0x7FFE872CFDB0
        public void op_LessThan(){} // RVA: 0x7FFE872CFE90
        public void op_GreaterThan(){} // RVA: 0x7FFE872CFF60
        public void LessThan(){} // RVA: 0x7FFE872D0030
        public void GreaterThan(){} // RVA: 0x7FFE872D0090
        public void ToSqlDouble(){} // RVA: 0x7FFE872D00F0
        public void CompareTo(){} // RVA: 0x7FFE872D0280 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872D0430
        public void GetHashCode(){} // RVA: 0x7FFE872D0670
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872D0730
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872D0860
        public void GetXsdType(){} // RVA: 0x7FFE872D09E0
        public void .cctor(){} // RVA: 0x7FFE872D0A60
    }

    public class SqlStreamChars : Object
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFE80E2E2E0
        public void get_Position(){} // RVA: 0x7FFE80E2E2E0
        public void Read(){}
        public void Seek(){}
    }

    public class SqlString : ValueType
    {
        public string m_value; // 0x10
        public System.Globalization.CompareInfo m_cmpInfo; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872D0FA0 | overloaded x4
        public void get_IsNull(){} // RVA: 0x7FFE81CD0D20
        public void get_Value(){} // RVA: 0x7FFE872D1180
        public void SetCompareInfo(){} // RVA: 0x7FFE872D1210
        public void op_Implicit(){} // RVA: 0x7FFE872D12E0
        public void ToString(){} // RVA: 0x7FFE872D1310
        public void op_Addition(){} // RVA: 0x7FFE872D1390
        public void StringCompare(){} // RVA: 0x7FFE872D1540
        public void Compare(){} // RVA: 0x7FFE872D1880
        public void op_Equality(){} // RVA: 0x7FFE872D1A20
        public void ValidateSqlCompareOptions(){} // RVA: 0x7FFE872D1B70
        public void CompareOptionsFromSqlCompareOptions(){} // RVA: 0x7FFE872D1C20
        public void FBinarySort(){} // RVA: 0x7FFE872D1CE0
        public void CompareBinary(){} // RVA: 0x7FFE872D1D40
        public void CompareBinary2(){} // RVA: 0x7FFE872D1F50
        public void CompareTo(){} // RVA: 0x7FFE872D2200 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE872D2340
        public void GetHashCode(){} // RVA: 0x7FFE872D2690
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872D2920
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872D2A80
        public void GetXsdType(){} // RVA: 0x7FFE872D2BC0
        public void .cctor(){} // RVA: 0x7FFE872D2C40
    }

    public class SqlTruncateException : SqlTypeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872D3490 | overloaded x4
        public void SqlTruncateExceptionSerialization(){} // RVA: 0x7FFE872D3590
    }

    public class SqlTypeException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872D2F50 | overloaded x4
        public void SqlTypeExceptionSerialization(){} // RVA: 0x7FFE872D3090
    }

    public class SqlXml : Object
    {
        public System.Func`4<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader> s_sqlReaderDelegate;
        public System.Xml.XmlReaderSettings s_defaultXmlReaderSettings; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872D3670
        public void CreateReader(){} // RVA: 0x7FFE872D36D0
        public void CreateSqlXmlReader(){} // RVA: 0x7FFE872D3900
        public void CreateSqlReaderDelegate(){} // RVA: 0x7FFE872D3A80
        public void get_CreateSqlReaderMethodInfo(){} // RVA: 0x7FFE872D3BE0
        public void get_IsNull(){} // RVA: 0x7FFE81CD0D20
        public void SetNull(){} // RVA: 0x7FFE872D3670
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFE813240E0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFE872D3DF0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFE872D4030
        public void GetXsdType(){} // RVA: 0x7FFE872D41E0
        public void .cctor(){} // RVA: 0x7FFE872D4260
    }

    public class SqlXmlStreamWrapper : Stream
    {
        public System.IO.Stream _stream; // 0x28
        public long _lPosition; // 0x30
        public bool _isClosed; // 0x38
        public object field_3; // 0x1A4
        public object field_4; // 0x1A5

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872D4630
        public void get_CanRead(){} // RVA: 0x7FFE872D46E0
        public void get_CanSeek(){} // RVA: 0x7FFE872D4730
        public void get_CanWrite(){} // RVA: 0x7FFE872D4780
        public void get_Length(){} // RVA: 0x7FFE872D47D0
        public void get_Position(){} // RVA: 0x7FFE872D4850
        public void set_Position(){} // RVA: 0x7FFE872D48B0
        public void Seek(){} // RVA: 0x7FFE872D4990
        public void Read(){} // RVA: 0x7FFE872D4C00
        public void Write(){} // RVA: 0x7FFE872D4E20
        public void ReadByte(){} // RVA: 0x7FFE872D5040
        public void WriteByte(){} // RVA: 0x7FFE872D5190
        public void SetLength(){} // RVA: 0x7FFE872D5290
        public void Flush(){} // RVA: 0x7FFE872D5320
        public void Dispose(){} // RVA: 0x7FFE872D5340
        public void ThrowIfStreamCannotSeek(){} // RVA: 0x7FFE872D5360
        public void ThrowIfStreamCannotRead(){} // RVA: 0x7FFE872D53F0
        public void ThrowIfStreamCannotWrite(){} // RVA: 0x7FFE872D5480
        public void ThrowIfStreamClosed(){} // RVA: 0x7FFE872D5510
        public void IsStreamClosed(){} // RVA: 0x7FFE872D5580
    }

}