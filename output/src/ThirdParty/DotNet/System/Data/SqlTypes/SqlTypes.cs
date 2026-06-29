// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data.SqlTypes
// Classes: 23
// Methods: 439

namespace ThirdParty.DotNet.System.Data.SqlTypes
{
    public class INullable
    {
        // ── Methods ──
        public void get_IsNull(){} // RVA: 0x87D280
    }

    public class SQLResource : Object
    {
        // ── Methods ──
        public void get_NullString(){} // RVA: 0x71DA690
        public void get_ArithOverflowMessage(){} // RVA: 0x71DA6D0
        public void get_DivideByZeroMessage(){} // RVA: 0x71DA710
        public void get_NullValueMessage(){} // RVA: 0x71DA750
        public void get_TruncationMessage(){} // RVA: 0x71DA790
        public void get_DateTimeOverflowMessage(){} // RVA: 0x71DA7D0
        public void get_ConcatDiffCollationMessage(){} // RVA: 0x71DA810
        public void get_CompareDiffCollationMessage(){} // RVA: 0x71DA850
        public void get_ConversionOverflowMessage(){} // RVA: 0x71DA890
        public void get_TimeZoneSpecifiedMessage(){} // RVA: 0x71DA8D0
        public void get_InvalidPrecScaleMessage(){} // RVA: 0x71DA910
        public void get_FormatMessage(){} // RVA: 0x71DA950
        public void InvalidOpStreamClosed(){} // RVA: 0x71DA990
        public void InvalidOpStreamNonWritable(){} // RVA: 0x71DA9E0
        public void InvalidOpStreamNonReadable(){} // RVA: 0x71DAA30
        public void InvalidOpStreamNonSeekable(){} // RVA: 0x71DAA80
    }

    public class SqlBinary : ValueType
    {
        public object _value;
        public object Null;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x903AE0
        public void get_IsNull(){} // RVA: 0x88E70
        public void get_Value(){} // RVA: 0x903AF0
        public void op_Implicit(){} // RVA: 0x71DADE0
        public void ToString(){} // RVA: 0x903B00
        public void PerformCompareByte(){} // RVA: 0x71DAF20
        public void op_Equality(){} // RVA: 0x71DB050
        public void op_LessThan(){} // RVA: 0x71DB160
        public void op_GreaterThan(){} // RVA: 0x71DB270
        public void CompareTo(){} // RVA: 0x903C20
        public void Equals(){} // RVA: 0x903C30
        public void HashByteArray(){} // RVA: 0x71DBA20
        public void GetHashCode(){} // RVA: 0x903C40
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x903C50
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x903C60
        public void GetXsdType(){} // RVA: 0x71DC0A0
        public void .cctor(){} // RVA: 0x71DC1F0
    }

    public class SqlBoolean : ValueType
    {
        public object m_value;
        public object True;
        public object False;
        public object Null;
        public object Zero;
        public object One;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x903CE0
        public void get_IsNull(){} // RVA: 0x497520
        public void get_Value(){} // RVA: 0x903D00
        public void get_IsTrue(){} // RVA: 0x903D10
        public void get_IsFalse(){} // RVA: 0x903D20
        public void op_Implicit(){} // RVA: 0x71DC3F0
        public void op_True(){} // RVA: 0x71DC400
        public void op_BitwiseAnd(){} // RVA: 0x71DC450
        public void op_BitwiseOr(){} // RVA: 0x71DC540
        public void get_ByteValue(){} // RVA: 0x903D30
        public void ToString(){} // RVA: 0x903D40
        public void op_Equality(){} // RVA: 0x71DC7C0
        public void And(){} // RVA: 0x71DC880
        public void Or(){} // RVA: 0x71DC9A0
        public void CompareTo(){} // RVA: 0x903F50
        public void Equals(){} // RVA: 0x903F60
        public void GetHashCode(){} // RVA: 0x903F70
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x904000
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x904130
        public void GetXsdType(){} // RVA: 0x71DD110
        public void .cctor(){} // RVA: 0x71DD260
    }

    public class SqlByte : ValueType
    {
        public object m_fNotNull;
        public object m_value;
        public object s_iBitNotByteMax;
        public object Null;
        public object Zero;
        public object MinValue;
        public object MaxValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x904310
        public void get_IsNull(){} // RVA: 0x497520
        public void get_Value(){} // RVA: 0x904320
        public void op_Implicit(){} // RVA: 0x71DD3D0
        public void ToString(){} // RVA: 0x904380
        public void op_Addition(){} // RVA: 0x71DD470
        public void op_Subtraction(){} // RVA: 0x71DD5A0
        public void op_Multiply(){} // RVA: 0x71DD6D0
        public void op_Division(){} // RVA: 0x71DD800
        public void op_Explicit(){} // RVA: 0x71DD920
        public void op_Equality(){} // RVA: 0x71DDAE0
        public void op_LessThan(){} // RVA: 0x71DDBB0
        public void op_GreaterThan(){} // RVA: 0x71DDC80
        public void LessThan(){} // RVA: 0x71DDD50
        public void GreaterThan(){} // RVA: 0x71DDDB0
        public void ToSqlDouble(){} // RVA: 0x904410
        public void ToSqlInt64(){} // RVA: 0x904480
        public void CompareTo(){} // RVA: 0x904600
        public void Equals(){} // RVA: 0x904610
        public void GetHashCode(){} // RVA: 0x904620
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x9046D0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x904880
        public void GetXsdType(){} // RVA: 0x71DE7C0
        public void .cctor(){} // RVA: 0x71DE910
    }

    public class SqlBytes : Object
    {
        public object _rgbBuf;
        public object _lCurLen;
        public object _stream;
        public object _state;
        public object _rgbWorkBuf;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71DEB20
        public void get_IsNull(){} // RVA: 0x1911560
        public void get_Buffer(){} // RVA: 0x71DEBB0
        public void get_Length(){} // RVA: 0x71DEBE0
        public void get_Value(){} // RVA: 0x71DEC70
        public void SetNull(){} // RVA: 0x71DEEB0
        public void CopyStreamToBuffer(){} // RVA: 0x71DEF20
        public void FStream(){} // RVA: 0x71DF150
        public void SetBuffer(){} // RVA: 0x71DF160
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0xDAC980
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x71DF240
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x71DF4F0
        public void GetXsdType(){} // RVA: 0x71DF6E0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x71DF830
        public void get_Null(){} // RVA: 0x71DF870
    }

    public class SqlChars : Object
    {
        public object _rgchBuf;
        public object _lCurLen;
        public object _stream;
        public object _state;
        public object _rgchWorkBuf;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71DF8C0
        public void get_IsNull(){} // RVA: 0x1911560
        public void get_Buffer(){} // RVA: 0x71DF960
        public void get_Length(){} // RVA: 0x71DF990
        public void get_Value(){} // RVA: 0x71DFA20
        public void SetNull(){} // RVA: 0x71DEEB0
        public void FStream(){} // RVA: 0x71DF150
        public void CopyStreamToBuffer(){} // RVA: 0x71DFC60
        public void SetBuffer(){} // RVA: 0x71DF160
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0xDAC980
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x71DFE90
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x71E0080
        public void GetXsdType(){} // RVA: 0x71E0240
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x71E0390
        public void get_Null(){} // RVA: 0x71E03D0
    }

    public class SqlDateTime : ValueType
    {
        public object m_fNotNull;
        public object m_day;
        public object m_time;
        public object s_SQLTicksPerMillisecond;
        public object SQLTicksPerSecond;
        public object SQLTicksPerMinute;
        public object SQLTicksPerHour;
        public object s_SQLTicksPerDay;
        public object s_ticksPerSecond;
        public object s_SQLBaseDate;
        public object s_SQLBaseDateTicks;
        public object s_minYear;
        public object s_maxYear;
        public object s_minDay;
        public object s_maxDay;
        public object s_minTime;
        public object s_maxTime;
        public object s_dayBase;
        public object s_daysToMonth365;
        public object s_daysToMonth366;
        public object s_minDateTime;
        public object s_maxDateTime;
        public object s_minTimeSpan;
        public object s_maxTimeSpan;
        public object s_ISO8601_DateTimeFormat;
        public object s_dateTimeFormats;
        public object MinValue;
        public object MaxValue;
        public object Null;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x904A50
        public void get_IsNull(){} // RVA: 0x497520
        public void ToTimeSpan(){} // RVA: 0x71E05D0
        public void ToDateTime(){} // RVA: 0x71E0660
        public void FromTimeSpan(){} // RVA: 0x71E07C0
        public void FromDateTime(){} // RVA: 0x71E09C0
        public void get_Value(){} // RVA: 0x904A60
        public void get_DayTicks(){} // RVA: 0x904A70
        public void get_TimeTicks(){} // RVA: 0x904AD0
        public void op_Implicit(){} // RVA: 0x71E0CE0
        public void ToString(){} // RVA: 0x904B30
        public void op_Equality(){} // RVA: 0x71E0E40
        public void op_LessThan(){} // RVA: 0x71E0F20
        public void op_GreaterThan(){} // RVA: 0x71E1010
        public void LessThan(){} // RVA: 0x71E1100
        public void GreaterThan(){} // RVA: 0x71E1190
        public void CompareTo(){} // RVA: 0x904D90
        public void Equals(){} // RVA: 0x904DC0
        public void GetHashCode(){} // RVA: 0x904DD0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x904EC0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x904ED0
        public void GetXsdType(){} // RVA: 0x71E1E10
        public void .cctor(){} // RVA: 0x71E1F60
    }

    public class SqlDecimal : ValueType
    {
        public object _bStatus;
        public object _bLen;
        public object _bPrec;
        public object _bScale;
        public object _data1;
        public object _data2;
        public object _data3;
        public object _data4;
        public object s_NUMERIC_MAX_PRECISION;
        public object MaxPrecision;
        public object MaxScale;
        public object s_bNullMask;
        public object s_bIsNull;
        public object s_bNotNull;
        public object s_bReverseNullMask;
        public object s_bSignMask;
        public object s_bPositive;
        public object s_bNegative;
        public object s_bReverseSignMask;
        public object s_uiZero;
        public object s_cNumeMax;
        public object s_lInt32Base;
        public object s_ulInt32Base;
        public object s_ulInt32BaseForMod;
        public object s_llMax;
        public object s_ulBase10;
        public object s_DUINT_BASE;
        public object s_DUINT_BASE2;
        public object s_DUINT_BASE3;
        public object s_DMAX_NUME;
        public object s_DBL_DIG;
        public object s_cNumeDivScaleMin;
        public object s_rgulShiftBase;
        public object s_decimalHelpersLo;
        public object s_decimalHelpersMid;
        public object s_decimalHelpersHi;
        public object s_decimalHelpersHiHi;
        public object s_rgCLenFromPrec;
        public object s_ulT1;
        public object s_ulT2;
        public object s_ulT3;
        public object s_ulT4;
        public object s_ulT5;
        public object s_ulT6;
        public object s_ulT7;
        public object s_ulT8;
        public object s_ulT9;
        public object s_dwlT10;
        public object s_dwlT11;
        public object s_dwlT12;
        public object s_dwlT13;
        public object s_dwlT14;
        public object s_dwlT15;
        public object s_dwlT16;
        public object s_dwlT17;
        public object s_dwlT18;
        public object s_dwlT19;
        public object Null;
        public object MinValue;
        public object MaxValue;

        // ── Methods ──
        public void CalculatePrecision(){} // RVA: 0x904EE0
        public void VerifyPrecision(){} // RVA: 0x904EF0
        public void .ctor(){} // RVA: 0x904F50
        public void get_IsNull(){} // RVA: 0x904F70
        public void get_Value(){} // RVA: 0x904F80
        public void get_IsPositive(){} // RVA: 0x904FF0
        public void SetPositive(){} // RVA: 0x905000
        public void SetSignBit(){} // RVA: 0x905010
        public void get_Scale(){} // RVA: 0x905020
        public void get_Data(){} // RVA: 0x905030
        public void ToString(){} // RVA: 0x905040
        public void Parse(){} // RVA: 0x71E3E30
        public void ToDouble(){} // RVA: 0x905050
        public void ToDecimal(){} // RVA: 0x905060
        public void op_Implicit(){} // RVA: 0x71E6C60
        public void op_UnaryNegation(){} // RVA: 0x71E4A20
        public void op_Addition(){} // RVA: 0x71E4C30
        public void op_Subtraction(){} // RVA: 0x71E5440
        public void op_Multiply(){} // RVA: 0x71E5510
        public void op_Division(){} // RVA: 0x71E6250
        public void ZeroToMaxLen(){} // RVA: 0x71E6D60
        public void FZero(){} // RVA: 0x905090
        public void FGt10_38(){} // RVA: 0x9050F0
        public void BGetPrecUI4(){} // RVA: 0x71E6E90
        public void BGetPrecUI8(){} // RVA: 0x71E7040
        public void AddULong(){} // RVA: 0x905140
        public void MultByULong(){} // RVA: 0x905150
        public void DivByULong(){} // RVA: 0x905160
        public void AdjustScale(){} // RVA: 0x905170
        public void LAbsCmp(){} // RVA: 0x905180
        public void MpMove(){} // RVA: 0x71E80F0
        public void MpSet(){} // RVA: 0x71E8160
        public void MpNormalize(){} // RVA: 0x71E8190
        public void MpMul1(){} // RVA: 0x71E81D0
        public void MpDiv1(){} // RVA: 0x71E82B0
        public void DWL(){} // RVA: 0x71E83B0
        public void HI(){} // RVA: 0x691FD10
        public void LO(){} // RVA: 0x294E720
        public void MpDiv(){} // RVA: 0x71E83C0
        public void CompareNm(){} // RVA: 0x9051B0
        public void CheckValidPrecScale(){} // RVA: 0x71E9220
        public void op_Equality(){} // RVA: 0x71E9300
        public void op_LessThan(){} // RVA: 0x71E9450
        public void op_GreaterThan(){} // RVA: 0x71E95A0
        public void LessThan(){} // RVA: 0x71E96F0
        public void GreaterThan(){} // RVA: 0x71E9780
        public void ToSqlDouble(){} // RVA: 0x9051E0
        public void ToSqlInt64(){} // RVA: 0x905270
        public void ToSqlMoney(){} // RVA: 0x905300
        public void ChFromDigit(){} // RVA: 0x71E9B10
        public void StoreFromWorkingArray(){} // RVA: 0x905330
        public void SetToZero(){} // RVA: 0x905380
        public void CompareTo(){} // RVA: 0x9054C0
        public void Equals(){} // RVA: 0x9054F0
        public void GetHashCode(){} // RVA: 0x905500
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x905690
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x905860
        public void GetXsdType(){} // RVA: 0x71EA8B0
        public void .cctor(){} // RVA: 0x71EAA00
    }

    public class SqlDouble : ValueType
    {
        public object m_fNotNull;
        public object m_value;
        public object Null;
        public object Zero;
        public object MinValue;
        public object MaxValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x905A60
        public void get_IsNull(){} // RVA: 0x497520
        public void get_Value(){} // RVA: 0x905A70
        public void op_Implicit(){} // RVA: 0x71EC100
        public void ToString(){} // RVA: 0x905AD0
        public void op_UnaryNegation(){} // RVA: 0x71EB510
        public void op_Addition(){} // RVA: 0x71EB5D0
        public void op_Subtraction(){} // RVA: 0x71EB720
        public void op_Multiply(){} // RVA: 0x71EB870
        public void op_Division(){} // RVA: 0x71EB9C0
        public void op_Equality(){} // RVA: 0x71EC230
        public void op_LessThan(){} // RVA: 0x71EC300
        public void op_GreaterThan(){} // RVA: 0x71EC3D0
        public void LessThan(){} // RVA: 0x71EC4A0
        public void GreaterThan(){} // RVA: 0x71EC5C0
        public void ToSqlSingle(){} // RVA: 0x905B60
        public void CompareTo(){} // RVA: 0x905C90
        public void Equals(){} // RVA: 0x905CB0
        public void GetHashCode(){} // RVA: 0x905CC0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x905DA0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x905EE0
        public void GetXsdType(){} // RVA: 0x71ED1F0
        public void .cctor(){} // RVA: 0x71ED340
    }

    public class SqlGuid : ValueType
    {
        public object s_sizeOfGuid;
        public object s_rgiGuidOrder;
        public object m_value;
        public object Null;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x906060
        public void get_IsNull(){} // RVA: 0x88E70
        public void get_Value(){} // RVA: 0x9060D0
        public void op_Implicit(){} // RVA: 0x71ED6B0
        public void ToString(){} // RVA: 0x906100
        public void Compare(){} // RVA: 0x71ED850
        public void op_Equality(){} // RVA: 0x71ED960
        public void op_LessThan(){} // RVA: 0x71EDA50
        public void op_GreaterThan(){} // RVA: 0x71EDB30
        public void CompareTo(){} // RVA: 0x906230
        public void Equals(){} // RVA: 0x906240
        public void GetHashCode(){} // RVA: 0x906250
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x9062F0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x906300
        public void GetXsdType(){} // RVA: 0x71EE7E0
        public void .cctor(){} // RVA: 0x71EE930
    }

    public class SqlInt16 : ValueType
    {
        public object m_fNotNull;
        public object m_value;
        public object s_MASKI2;
        public object Null;
        public object Zero;
        public object MinValue;
        public object MaxValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x906350
        public void get_IsNull(){} // RVA: 0x497520
        public void get_Value(){} // RVA: 0x906360
        public void op_Implicit(){} // RVA: 0x71EF200
        public void ToString(){} // RVA: 0x9063C0
        public void op_UnaryNegation(){} // RVA: 0x71EEC10
        public void op_Addition(){} // RVA: 0x71EECB0
        public void op_Subtraction(){} // RVA: 0x71EEDE0
        public void op_Multiply(){} // RVA: 0x71EEF10
        public void op_Division(){} // RVA: 0x71EF070
        public void op_Explicit(){} // RVA: 0x71EF2C0
        public void op_Equality(){} // RVA: 0x71EF420
        public void op_LessThan(){} // RVA: 0x71EF4F0
        public void op_GreaterThan(){} // RVA: 0x71EF5C0
        public void LessThan(){} // RVA: 0x71EF690
        public void GreaterThan(){} // RVA: 0x71EF6F0
        public void ToSqlDouble(){} // RVA: 0x906450
        public void ToSqlInt64(){} // RVA: 0x9064C0
        public void CompareTo(){} // RVA: 0x906640
        public void Equals(){} // RVA: 0x906650
        public void GetHashCode(){} // RVA: 0x906660
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x906720
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x9068D0
        public void GetXsdType(){} // RVA: 0x71F0100
        public void .cctor(){} // RVA: 0x71F0250
    }

    public class SqlInt32 : ValueType
    {
        public object m_fNotNull;
        public object m_value;
        public object s_iIntMin;
        public object s_lBitNotIntMax;
        public object Null;
        public object Zero;
        public object MinValue;
        public object MaxValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x906A50
        public void get_IsNull(){} // RVA: 0x497520
        public void get_Value(){} // RVA: 0x906A60
        public void op_Implicit(){} // RVA: 0x71F0B80
        public void ToString(){} // RVA: 0x906A70
        public void op_UnaryNegation(){} // RVA: 0x71F0460
        public void op_Addition(){} // RVA: 0x71F0500
        public void op_Subtraction(){} // RVA: 0x71F0660
        public void op_Multiply(){} // RVA: 0x71F07B0
        public void op_Division(){} // RVA: 0x71F0920
        public void op_Explicit(){} // RVA: 0x71F0C40
        public void SameSignInt(){} // RVA: 0x71F0DA0
        public void op_Equality(){} // RVA: 0x71F0DB0
        public void op_LessThan(){} // RVA: 0x71F0E80
        public void op_GreaterThan(){} // RVA: 0x71F0F50
        public void LessThan(){} // RVA: 0x71F1020
        public void GreaterThan(){} // RVA: 0x71F1080
        public void ToSqlDouble(){} // RVA: 0x906B00
        public void ToSqlInt64(){} // RVA: 0x906B70
        public void CompareTo(){} // RVA: 0x906CF0
        public void Equals(){} // RVA: 0x906D00
        public void GetHashCode(){} // RVA: 0x906D10
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x906D90
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x906ED0
        public void GetXsdType(){} // RVA: 0x71F19E0
        public void .cctor(){} // RVA: 0x71F1B30
    }

    public class SqlInt64 : ValueType
    {
        public object m_fNotNull;
        public object m_value;
        public object s_lLowIntMask;
        public object s_lHighIntMask;
        public object Null;
        public object Zero;
        public object MinValue;
        public object MaxValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x907040
        public void get_IsNull(){} // RVA: 0x497520
        public void get_Value(){} // RVA: 0x907050
        public void op_Implicit(){} // RVA: 0x71F28C0
        public void ToString(){} // RVA: 0x9070B0
        public void op_UnaryNegation(){} // RVA: 0x71F1D20
        public void op_Addition(){} // RVA: 0x71F1DD0
        public void op_Subtraction(){} // RVA: 0x71F1F40
        public void op_Multiply(){} // RVA: 0x71F20C0
        public void op_Division(){} // RVA: 0x71F2400
        public void op_Modulus(){} // RVA: 0x71F2590
        public void op_Explicit(){} // RVA: 0x71F29A0
        public void SameSignLong(){} // RVA: 0x71F2C50
        public void op_Equality(){} // RVA: 0x71F2C70
        public void op_LessThan(){} // RVA: 0x71F2D40
        public void op_GreaterThan(){} // RVA: 0x71F2E10
        public void LessThan(){} // RVA: 0x71F2EE0
        public void GreaterThan(){} // RVA: 0x71F2FE0
        public void ToSqlByte(){} // RVA: 0x907140
        public void ToSqlDouble(){} // RVA: 0x907150
        public void ToSqlInt16(){} // RVA: 0x9071D0
        public void ToSqlInt32(){} // RVA: 0x9071E0
        public void ToSqlDecimal(){} // RVA: 0x9071F0
        public void CompareTo(){} // RVA: 0x9073A0
        public void Equals(){} // RVA: 0x9073C0
        public void GetHashCode(){} // RVA: 0x9073D0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x907490
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x9075D0
        public void GetXsdType(){} // RVA: 0x71F3E80
        public void .cctor(){} // RVA: 0x71F3FD0
    }

    public class SqlMoney : ValueType
    {
        public object _fNotNull;
        public object _value;
        public object s_iMoneyScale;
        public object s_lTickBase;
        public object s_dTickBase;
        public object s_minLong;
        public object s_maxLong;
        public object Null;
        public object Zero;
        public object MinValue;
        public object MaxValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x907760
        public void get_IsNull(){} // RVA: 0x497520
        public void get_Value(){} // RVA: 0x907780
        public void ToDecimal(){} // RVA: 0x9077B0
        public void ToDouble(){} // RVA: 0x9077E0
        public void op_Implicit(){} // RVA: 0x71F5440
        public void ToString(){} // RVA: 0x9077F0
        public void op_UnaryNegation(){} // RVA: 0x71F4970
        public void op_Addition(){} // RVA: 0x71F4AA0
        public void op_Subtraction(){} // RVA: 0x71F4C40
        public void op_Multiply(){} // RVA: 0x71F4DE0
        public void op_Division(){} // RVA: 0x71F4FC0
        public void op_Explicit(){} // RVA: 0x71F5550
        public void op_Equality(){} // RVA: 0x71F56D0
        public void op_LessThan(){} // RVA: 0x71F57A0
        public void op_GreaterThan(){} // RVA: 0x71F5870
        public void LessThan(){} // RVA: 0x71F5940
        public void GreaterThan(){} // RVA: 0x71F5A40
        public void ToSqlDouble(){} // RVA: 0x907800
        public void ToSqlDecimal(){} // RVA: 0x907830
        public void CompareTo(){} // RVA: 0x9079E0
        public void Equals(){} // RVA: 0x907A00
        public void GetHashCode(){} // RVA: 0x907A10
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x907A70
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x907A80
        public void GetXsdType(){} // RVA: 0x71F67E0
        public void .cctor(){} // RVA: 0x71F6930
    }

    public class SqlNullValueException : SqlTypeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x71FB470
        public void SqlNullValueExceptionSerialization(){} // RVA: 0x71FB580
    }

    public class SqlSingle : ValueType
    {
        public object _fNotNull;
        public object _value;
        public object Null;
        public object Zero;
        public object MinValue;
        public object MaxValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x907AA0
        public void get_IsNull(){} // RVA: 0x497520
        public void get_Value(){} // RVA: 0x907AB0
        public void op_Implicit(){} // RVA: 0x71F7AF0
        public void ToString(){} // RVA: 0x907B10
        public void op_UnaryNegation(){} // RVA: 0x71F6D30
        public void op_Addition(){} // RVA: 0x71F6E40
        public void op_Subtraction(){} // RVA: 0x71F6FD0
        public void op_Multiply(){} // RVA: 0x71F7160
        public void op_Division(){} // RVA: 0x71F72F0
        public void op_Explicit(){} // RVA: 0x71F7CB0
        public void op_Equality(){} // RVA: 0x71F7E50
        public void op_LessThan(){} // RVA: 0x71F7F30
        public void op_GreaterThan(){} // RVA: 0x71F8000
        public void LessThan(){} // RVA: 0x71F80D0
        public void GreaterThan(){} // RVA: 0x71F8130
        public void ToSqlDouble(){} // RVA: 0x907BA0
        public void CompareTo(){} // RVA: 0x907D20
        public void Equals(){} // RVA: 0x907D30
        public void GetHashCode(){} // RVA: 0x907D40
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x907E00
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x907F40
        public void GetXsdType(){} // RVA: 0x71F8A70
        public void .cctor(){} // RVA: 0x71F8BC0
    }

    public class SqlStreamChars : Object
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0x87C0A0
        public void get_Position(){} // RVA: 0x87C0A0
        public void Read(){} // RVA: 0x885A60
        public void Seek(){} // RVA: 0x881DE0
    }

    public class SqlString : ValueType
    {
        public object m_value;
        public object m_cmpInfo;
        public object m_lcid;
        public object m_flag;
        public object m_fNotNull;
        public object Null;
        public object s_unicodeEncoding;
        public object IgnoreCase;
        public object IgnoreWidth;
        public object IgnoreNonSpace;
        public object IgnoreKanaType;
        public object BinarySort;
        public object BinarySort2;
        public object s_iDefaultFlag;
        public object s_iValidCompareOptionMask;
        public object s_iValidSqlCompareOptionMask;
        public object s_lcidUSEnglish;
        public object s_lcidBinary;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9081B0
        public void get_IsNull(){} // RVA: 0x9081C0
        public void get_Value(){} // RVA: 0x9081D0
        public void SetCompareInfo(){} // RVA: 0x9081E0
        public void op_Implicit(){} // RVA: 0x71F9440
        public void ToString(){} // RVA: 0x9081F0
        public void op_Addition(){} // RVA: 0x71F94F0
        public void StringCompare(){} // RVA: 0x71F96A0
        public void Compare(){} // RVA: 0x71F99E0
        public void op_Equality(){} // RVA: 0x71F9B80
        public void ValidateSqlCompareOptions(){} // RVA: 0x71F9CD0
        public void CompareOptionsFromSqlCompareOptions(){} // RVA: 0x71F9D80
        public void FBinarySort(){} // RVA: 0x908270
        public void CompareBinary(){} // RVA: 0x71F9EA0
        public void CompareBinary2(){} // RVA: 0x71FA0D0
        public void CompareTo(){} // RVA: 0x908410
        public void Equals(){} // RVA: 0x908440
        public void GetHashCode(){} // RVA: 0x908450
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x99090
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x908460
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x9085C0
        public void GetXsdType(){} // RVA: 0x71FAD50
        public void .cctor(){} // RVA: 0x71FAEA0
    }

    public class SqlTruncateException : SqlTypeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x71FB700
        public void SqlTruncateExceptionSerialization(){} // RVA: 0x71FB810
    }

    public class SqlTypeException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x71FB1B0
        public void SqlTypeExceptionSerialization(){} // RVA: 0x71FB2F0
    }

    public class SqlXml : Object
    {
        public object s_sqlReaderDelegate;
        public object s_defaultXmlReaderSettings;
        public object s_defaultXmlReaderSettingsCloseInput;
        public object s_createSqlReaderMethodInfo;
        public object _createSqlReaderMethodInfo;
        public object _fNotNull;
        public object _stream;
        public object _firstCreateReader;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71FB8F0
        public void CreateReader(){} // RVA: 0x71FB950
        public void CreateSqlXmlReader(){} // RVA: 0x71FBB80
        public void CreateSqlReaderDelegate(){} // RVA: 0x71FBD00
        public void get_CreateSqlReaderMethodInfo(){} // RVA: 0x71FBE30
        public void get_IsNull(){} // RVA: 0x17F43E0
        public void SetNull(){} // RVA: 0x71FB8F0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0xDAC980
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x71FC060
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x71FC2A0
        public void GetXsdType(){} // RVA: 0x71FC450
        public void .cctor(){} // RVA: 0x71FC5A0
    }

    public class SqlXmlStreamWrapper : Stream
    {
        public object _stream;
        public object _lPosition;
        public object _isClosed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71FC940
        public void get_CanRead(){} // RVA: 0x71FC9F0
        public void get_CanSeek(){} // RVA: 0x71FCA40
        public void get_CanWrite(){} // RVA: 0x71FCA90
        public void get_Length(){} // RVA: 0x71FCAE0
        public void get_Position(){} // RVA: 0x71FCB60
        public void set_Position(){} // RVA: 0x71FCBC0
        public void Seek(){} // RVA: 0x71FCCA0
        public void Read(){} // RVA: 0x71FCF10
        public void Write(){} // RVA: 0x71FD130
        public void ReadByte(){} // RVA: 0x71FD350
        public void WriteByte(){} // RVA: 0x71FD4A0
        public void SetLength(){} // RVA: 0x71FD5A0
        public void Flush(){} // RVA: 0x71FD630
        public void Dispose(){} // RVA: 0x71FD650
        public void ThrowIfStreamCannotSeek(){} // RVA: 0x71FD670
        public void ThrowIfStreamCannotRead(){} // RVA: 0x71FD700
        public void ThrowIfStreamCannotWrite(){} // RVA: 0x71FD790
        public void ThrowIfStreamClosed(){} // RVA: 0x71FD820
        public void IsStreamClosed(){} // RVA: 0x71FD890
    }

}