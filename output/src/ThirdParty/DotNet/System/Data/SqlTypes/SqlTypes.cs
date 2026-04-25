// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data.SqlTypes
// Classes: 23
// Methods: 520

namespace ThirdParty.DotNet.System.Data.SqlTypes
{
    public class INullable
    {
        public object IsNull;

        // ── Methods ──
        public void get_IsNull(){} // RVA: 0x7FFAC2C59D00
    }

    public class SQLResource : Object
    {
        public object NullString;
        public object ArithOverflowMessage;
        public object DivideByZeroMessage;
        public object NullValueMessage;
        public object TruncationMessage;
        public object DateTimeOverflowMessage;
        public object ConcatDiffCollationMessage;
        public object CompareDiffCollationMessage;
        public object ConversionOverflowMessage;
        public object TimeZoneSpecifiedMessage;
        public object InvalidPrecScaleMessage;
        public object FormatMessage;

        // ── Methods ──
        public void get_NullString(){} // RVA: 0x7FFAC8F0AE00
        public void get_ArithOverflowMessage(){} // RVA: 0x7FFAC8F0AE40
        public void get_DivideByZeroMessage(){} // RVA: 0x7FFAC8F0AE80
        public void get_NullValueMessage(){} // RVA: 0x7FFAC8F0AEC0
        public void get_TruncationMessage(){} // RVA: 0x7FFAC8F0AF00
        public void get_DateTimeOverflowMessage(){} // RVA: 0x7FFAC8F0AF40
        public void get_ConcatDiffCollationMessage(){} // RVA: 0x7FFAC8F0AF80
        public void get_CompareDiffCollationMessage(){} // RVA: 0x7FFAC8F0AFC0
        public void get_ConversionOverflowMessage(){} // RVA: 0x7FFAC8F0B000
        public void get_TimeZoneSpecifiedMessage(){} // RVA: 0x7FFAC8F0B040
        public void get_InvalidPrecScaleMessage(){} // RVA: 0x7FFAC8F0B080
        public void get_FormatMessage(){} // RVA: 0x7FFAC8F0B0C0
        public void InvalidOpStreamClosed(){} // RVA: 0x7FFAC8F0B100
        public void InvalidOpStreamNonWritable(){} // RVA: 0x7FFAC8F0B150
        public void InvalidOpStreamNonReadable(){} // RVA: 0x7FFAC8F0B1A0
        public void InvalidOpStreamNonSeekable(){} // RVA: 0x7FFAC8F0B1F0
    }

    public class SqlBinary : ValueType
    {
        public byte[] IsNull; // 0x10
        public System.Data.SqlTypes.SqlBinary Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F0B2A0 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFAC484C2F0
        public void get_Value(){} // RVA: 0x7FFAC8F0B470
        public void op_Implicit(){} // RVA: 0x7FFAC8F0B550
        public void ToString(){} // RVA: 0x7FFAC8F0B580
        public void PerformCompareByte(){} // RVA: 0x7FFAC8F0B690
        public void op_Equality(){} // RVA: 0x7FFAC8F0B7B0
        public void op_LessThan(){} // RVA: 0x7FFAC8F0B8C0
        public void op_GreaterThan(){} // RVA: 0x7FFAC8F0B9D0
        public void CompareTo(){} // RVA: 0x7FFAC8F0BC00 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F0BF40
        public void HashByteArray(){} // RVA: 0x7FFAC8F0C190
        public void GetHashCode(){} // RVA: 0x7FFAC8F0C200
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F0C2E0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F0C620
        public void GetXsdType(){} // RVA: 0x7FFAC8F0C800
        public void .cctor(){} // RVA: 0x7FFAC8F0C880
    }

    public class SqlBoolean : ValueType
    {
        public byte IsNull; // 0x10
        public System.Data.SqlTypes.SqlBoolean Value;
        public System.Data.SqlTypes.SqlBoolean IsTrue; // 0x1
        public System.Data.SqlTypes.SqlBoolean IsFalse; // 0x2
        public System.Data.SqlTypes.SqlBoolean ByteValue; // 0x3
        public System.Data.SqlTypes.SqlBoolean One; // 0x4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F0C9E0 | overloaded x3
        public void get_IsNull(){} // RVA: 0x7FFAC5F4D7E0
        public void get_Value(){} // RVA: 0x7FFAC8F0CA00
        public void get_IsTrue(){} // RVA: 0x7FFAC8F0CA60
        public void get_IsFalse(){} // RVA: 0x7FFAC8F0CA70
        public void op_Implicit(){} // RVA: 0x7FFAC8F0CA80
        public void op_True(){} // RVA: 0x7FFAC8F0CA90
        public void op_BitwiseAnd(){} // RVA: 0x7FFAC8F0CAE0
        public void op_BitwiseOr(){} // RVA: 0x7FFAC8F0CBD0
        public void get_ByteValue(){} // RVA: 0x7FFAC8F0CCC0
        public void ToString(){} // RVA: 0x7FFAC8F0CD50
        public void op_Equality(){} // RVA: 0x7FFAC8F0CE60
        public void And(){} // RVA: 0x7FFAC8F0CF20
        public void Or(){} // RVA: 0x7FFAC8F0D040
        public void CompareTo(){} // RVA: 0x7FFAC8F0D1C0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F0D2E0
        public void GetHashCode(){} // RVA: 0x7FFAC8F0D4A0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F0D540
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F0D670
        public void GetXsdType(){} // RVA: 0x7FFAC8F0D7D0
        public void .cctor(){} // RVA: 0x7FFAC8F0D850
    }

    public class SqlByte : ValueType
    {
        public bool IsNull; // 0x10
        public byte Value; // 0x11
        public int s_iBitNotByteMax;
        public System.Data.SqlTypes.SqlByte Null; // 0x4
        public System.Data.SqlTypes.SqlByte Zero; // 0x6
        public System.Data.SqlTypes.SqlByte MinValue; // 0x8
        public System.Data.SqlTypes.SqlByte MaxValue; // 0xA

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC65CB7E0 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFAC5F4D7E0
        public void get_Value(){} // RVA: 0x7FFAC8F0D960
        public void op_Implicit(){} // RVA: 0x7FFAC8F0D9C0
        public void ToString(){} // RVA: 0x7FFAC8F0D9D0
        public void op_Addition(){} // RVA: 0x7FFAC8F0DA60
        public void op_Subtraction(){} // RVA: 0x7FFAC8F0DB90
        public void op_Multiply(){} // RVA: 0x7FFAC8F0DCC0
        public void op_Division(){} // RVA: 0x7FFAC8F0DDF0
        public void op_Explicit(){} // RVA: 0x7FFAC8F0DF10
        public void op_Equality(){} // RVA: 0x7FFAC8F0E0D0
        public void op_LessThan(){} // RVA: 0x7FFAC8F0E1A0
        public void op_GreaterThan(){} // RVA: 0x7FFAC8F0E270
        public void LessThan(){} // RVA: 0x7FFAC8F0E340
        public void GreaterThan(){} // RVA: 0x7FFAC8F0E3A0
        public void ToSqlDouble(){} // RVA: 0x7FFAC8F0E400
        public void ToSqlInt64(){} // RVA: 0x7FFAC8F0E470
        public void CompareTo(){} // RVA: 0x7FFAC8F0E600 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F0E7B0
        public void GetHashCode(){} // RVA: 0x7FFAC8F0E9F0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F0EAA0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F0EC50
        public void GetXsdType(){} // RVA: 0x7FFAC8F0EDC0
        public void .cctor(){} // RVA: 0x7FFAC8F0EE40
    }

    public class SqlBytes : Object
    {
        public byte[] IsNull; // 0x10
        public long Buffer; // 0x18
        public System.IO.Stream Length; // 0x20
        public 0x6B1D1108 Value; // 0x28
        public byte[] Null; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F0F050 | overloaded x3
        public void get_IsNull(){} // RVA: 0x7FFAC3CE9940
        public void get_Buffer(){} // RVA: 0x7FFAC8F0F0E0
        public void get_Length(){} // RVA: 0x7FFAC8F0F110
        public void get_Value(){} // RVA: 0x7FFAC8F0F1A0
        public void SetNull(){} // RVA: 0x7FFAC8F0F3E0
        public void CopyStreamToBuffer(){} // RVA: 0x7FFAC8F0F450
        public void FStream(){} // RVA: 0x7FFAC8F0F680
        public void SetBuffer(){} // RVA: 0x7FFAC8F0F690
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F0F770
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F0FA00
        public void GetXsdType(){} // RVA: 0x7FFAC8F0FBF0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC8F0FC70
        public void get_Null(){} // RVA: 0x7FFAC8F0FCB0
    }

    public class SqlChars : Object
    {
        public char[] IsNull; // 0x10
        public long Buffer; // 0x18
        public System.Data.SqlTypes.SqlStreamChars Length; // 0x20
        public 0x6B1D1108 Value; // 0x28
        public char[] Null; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F0FD00 | overloaded x3
        public void get_IsNull(){} // RVA: 0x7FFAC3CE9940
        public void get_Buffer(){} // RVA: 0x7FFAC8F0FDA0
        public void get_Length(){} // RVA: 0x7FFAC8F0FDD0
        public void get_Value(){} // RVA: 0x7FFAC8F0FE60
        public void SetNull(){} // RVA: 0x7FFAC8F0F3E0
        public void FStream(){} // RVA: 0x7FFAC8F0F680
        public void CopyStreamToBuffer(){} // RVA: 0x7FFAC8F100A0
        public void SetBuffer(){} // RVA: 0x7FFAC8F0F690
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F102D0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F104C0
        public void GetXsdType(){} // RVA: 0x7FFAC8F10680
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC8F10700
        public void get_Null(){} // RVA: 0x7FFAC8F10740
    }

    public class SqlDateTime : ValueType
    {
        public bool IsNull; // 0x10
        public int Value; // 0x14
        public int DayTicks; // 0x18
        public double TimeTicks;
        public int SQLTicksPerSecond; // 0x8
        public int SQLTicksPerMinute; // 0xC
        public int SQLTicksPerHour; // 0x10
        public int s_SQLTicksPerDay; // 0x14
        public long s_ticksPerSecond; // 0x18
        public System.DateTime s_SQLBaseDate; // 0x20
        public long s_SQLBaseDateTicks; // 0x28
        public int s_minYear; // 0x30
        public int s_maxYear; // 0x34
        public int s_minDay; // 0x38
        public int s_maxDay; // 0x3C
        public int s_minTime; // 0x40
        public int s_maxTime; // 0x44
        public int s_dayBase; // 0x48
        public int[] s_daysToMonth365; // 0x50
        public int[] s_daysToMonth366; // 0x58
        public System.DateTime s_minDateTime; // 0x60
        public System.DateTime s_maxDateTime; // 0x68
        public System.TimeSpan s_minTimeSpan; // 0x70
        public System.TimeSpan s_maxTimeSpan; // 0x78
        public string s_ISO8601_DateTimeFormat; // 0x80
        public string[] s_dateTimeFormats; // 0x88
        public System.Data.SqlTypes.SqlDateTime MinValue; // 0x90
        public System.Data.SqlTypes.SqlDateTime MaxValue; // 0x9C
        public System.Data.SqlTypes.SqlDateTime Null; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F10810 | overloaded x3
        public void get_IsNull(){} // RVA: 0x7FFAC5F4D7E0
        public void ToTimeSpan(){} // RVA: 0x7FFAC8F10940
        public void ToDateTime(){} // RVA: 0x7FFAC8F109D0
        public void FromTimeSpan(){} // RVA: 0x7FFAC8F10B30
        public void FromDateTime(){} // RVA: 0x7FFAC8F10D30
        public void get_Value(){} // RVA: 0x7FFAC8F10EE0
        public void get_DayTicks(){} // RVA: 0x7FFAC8F10F90
        public void get_TimeTicks(){} // RVA: 0x7FFAC8F10FF0
        public void op_Implicit(){} // RVA: 0x7FFAC8F11050
        public void ToString(){} // RVA: 0x7FFAC8F11080
        public void op_Equality(){} // RVA: 0x7FFAC8F111B0
        public void op_LessThan(){} // RVA: 0x7FFAC8F11290
        public void op_GreaterThan(){} // RVA: 0x7FFAC8F11380
        public void LessThan(){} // RVA: 0x7FFAC8F11470
        public void GreaterThan(){} // RVA: 0x7FFAC8F11500
        public void CompareTo(){} // RVA: 0x7FFAC8F116D0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F118E0
        public void GetHashCode(){} // RVA: 0x7FFAC8F11B40
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F11C30
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F11F30
        public void GetXsdType(){} // RVA: 0x7FFAC8F12190
        public void .cctor(){} // RVA: 0x7FFAC8F12210
    }

    public class SqlDecimal : ValueType
    {
        public byte IsNull; // 0x10
        public byte Value; // 0x11
        public byte IsPositive; // 0x12
        public byte Scale; // 0x13
        public uint Data; // 0x14
        public uint _data2; // 0x18
        public uint _data3; // 0x1C
        public uint _data4; // 0x20
        public byte s_NUMERIC_MAX_PRECISION;
        public byte MaxPrecision; // 0x1
        public byte MaxScale; // 0x2
        public byte s_bNullMask; // 0x3
        public byte s_bIsNull; // 0x4
        public byte s_bNotNull; // 0x5
        public byte s_bReverseNullMask; // 0x6
        public byte s_bSignMask; // 0x7
        public byte s_bPositive; // 0x8
        public byte s_bNegative; // 0x9
        public byte s_bReverseSignMask; // 0xA
        public uint s_uiZero; // 0xC
        public int s_cNumeMax; // 0x10
        public long s_lInt32Base; // 0x18
        public ulong s_ulInt32Base; // 0x20
        public ulong s_ulInt32BaseForMod; // 0x28
        public ulong s_llMax; // 0x30
        public uint s_ulBase10; // 0x38
        public double s_DUINT_BASE; // 0x40
        public double s_DUINT_BASE2; // 0x48
        public double s_DUINT_BASE3; // 0x50
        public double s_DMAX_NUME; // 0x58
        public uint s_DBL_DIG; // 0x60
        public byte s_cNumeDivScaleMin; // 0x64
        public uint[] s_rgulShiftBase; // 0x68
        public uint[] s_decimalHelpersLo; // 0x70
        public uint[] s_decimalHelpersMid; // 0x78
        public uint[] s_decimalHelpersHi; // 0x80
        public uint[] s_decimalHelpersHiHi; // 0x88
        public byte[] s_rgCLenFromPrec; // 0x90
        public uint s_ulT1; // 0x98
        public uint s_ulT2; // 0x9C
        public uint s_ulT3; // 0xA0
        public uint s_ulT4; // 0xA4
        public uint s_ulT5; // 0xA8
        public uint s_ulT6; // 0xAC
        public uint s_ulT7; // 0xB0
        public uint s_ulT8; // 0xB4
        public uint s_ulT9; // 0xB8
        public ulong s_dwlT10; // 0xC0
        public ulong s_dwlT11; // 0xC8
        public ulong s_dwlT12; // 0xD0
        public ulong s_dwlT13; // 0xD8
        public ulong s_dwlT14; // 0xE0
        public ulong s_dwlT15; // 0xE8
        public ulong s_dwlT16; // 0xF0
        public ulong s_dwlT17; // 0xF8
        public ulong s_dwlT18; // 0x100
        public ulong s_dwlT19; // 0x108
        public System.Data.SqlTypes.SqlDecimal Null; // 0x110
        public System.Data.SqlTypes.SqlDecimal MinValue; // 0x124
        public System.Data.SqlTypes.SqlDecimal MaxValue; // 0x138

        // ── Methods ──
        public void CalculatePrecision(){} // RVA: 0x7FFAC8F129B0
        public void VerifyPrecision(){} // RVA: 0x7FFAC8F12BF0
        public void .ctor(){} // RVA: 0x7FFAC8F13430 | overloaded x5
        public void get_IsNull(){} // RVA: 0x7FFAC8F13660
        public void get_Value(){} // RVA: 0x7FFAC8F136D0
        public void get_IsPositive(){} // RVA: 0x7FFAC8F13740
        public void SetPositive(){} // RVA: 0x7FFAC8F13860
        public void SetSignBit(){} // RVA: 0x7FFAC8F138D0
        public void get_Scale(){} // RVA: 0x7FFAC8F13980
        public void get_Data(){} // RVA: 0x7FFAC8F13A70
        public void ToString(){} // RVA: 0x7FFAC8F13BC0
        public void Parse(){} // RVA: 0x7FFAC8F14000
        public void ToDouble(){} // RVA: 0x7FFAC8F14780
        public void ToDecimal(){} // RVA: 0x7FFAC8F14960
        public void op_Implicit(){} // RVA: 0x7FFAC8F16D00 | overloaded x7
        public void op_UnaryNegation(){} // RVA: 0x7FFAC8F14BD0
        public void op_Addition(){} // RVA: 0x7FFAC8F14DE0
        public void op_Subtraction(){} // RVA: 0x7FFAC8F155A0
        public void op_Multiply(){} // RVA: 0x7FFAC8F15670
        public void op_Division(){} // RVA: 0x7FFAC8F162F0
        public void ZeroToMaxLen(){} // RVA: 0x7FFAC8F16E00
        public void FZero(){} // RVA: 0x7FFAC8F16E80
        public void FGt10_38(){} // RVA: 0x7FFAC8F16EE0 | overloaded x2
        public void BGetPrecUI4(){} // RVA: 0x7FFAC8F16F30
        public void BGetPrecUI8(){} // RVA: 0x7FFAC8F170E0
        public void AddULong(){} // RVA: 0x7FFAC8F17470
        public void MultByULong(){} // RVA: 0x7FFAC8F17700
        public void DivByULong(){} // RVA: 0x7FFAC8F179C0
        public void AdjustScale(){} // RVA: 0x7FFAC8F17BB0
        public void LAbsCmp(){} // RVA: 0x7FFAC8F17FA0
        public void MpMove(){} // RVA: 0x7FFAC8F18150
        public void MpSet(){} // RVA: 0x7FFAC8F181B0
        public void MpNormalize(){} // RVA: 0x7FFAC8F181E0
        public void MpMul1(){} // RVA: 0x7FFAC8F18220
        public void MpDiv1(){} // RVA: 0x7FFAC8F18300
        public void DWL(){} // RVA: 0x7FFAC8F18400
        public void HI(){} // RVA: 0x7FFAC863DE00
        public void LO(){} // RVA: 0x7FFAC4BE6C10
        public void MpDiv(){} // RVA: 0x7FFAC8F18410
        public void CompareNm(){} // RVA: 0x7FFAC8F19010
        public void CheckValidPrecScale(){} // RVA: 0x7FFAC8F19200
        public void op_Equality(){} // RVA: 0x7FFAC8F192E0
        public void op_LessThan(){} // RVA: 0x7FFAC8F19430
        public void op_GreaterThan(){} // RVA: 0x7FFAC8F19580
        public void LessThan(){} // RVA: 0x7FFAC8F196D0
        public void GreaterThan(){} // RVA: 0x7FFAC8F19760
        public void ToSqlDouble(){} // RVA: 0x7FFAC8F197F0
        public void ToSqlInt64(){} // RVA: 0x7FFAC8F19880
        public void ToSqlMoney(){} // RVA: 0x7FFAC8F19910
        public void ChFromDigit(){} // RVA: 0x7FFAC8F19AF0
        public void StoreFromWorkingArray(){} // RVA: 0x7FFAC8F19B00
        public void SetToZero(){} // RVA: 0x7FFAC8F19B50
        public void CompareTo(){} // RVA: 0x7FFAC8F19CF0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F19F60
        public void GetHashCode(){} // RVA: 0x7FFAC8F1A390
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F1A510
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F1A6D0
        public void GetXsdType(){} // RVA: 0x7FFAC8F1A890
        public void .cctor(){} // RVA: 0x7FFAC8F1A910
    }

    public class SqlDouble : ValueType
    {
        public bool IsNull; // 0x10
        public double Value; // 0x18
        public System.Data.SqlTypes.SqlDouble Null;
        public System.Data.SqlTypes.SqlDouble Zero; // 0x10
        public System.Data.SqlTypes.SqlDouble MinValue; // 0x20
        public System.Data.SqlTypes.SqlDouble MaxValue; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F1B280 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFAC5F4D7E0
        public void get_Value(){} // RVA: 0x7FFAC8F1B310
        public void op_Implicit(){} // RVA: 0x7FFAC8F1C010 | overloaded x8
        public void ToString(){} // RVA: 0x7FFAC8F1B390
        public void op_UnaryNegation(){} // RVA: 0x7FFAC8F1B420
        public void op_Addition(){} // RVA: 0x7FFAC8F1B4E0
        public void op_Subtraction(){} // RVA: 0x7FFAC8F1B630
        public void op_Multiply(){} // RVA: 0x7FFAC8F1B780
        public void op_Division(){} // RVA: 0x7FFAC8F1B8D0
        public void op_Equality(){} // RVA: 0x7FFAC8F1C140
        public void op_LessThan(){} // RVA: 0x7FFAC8F1C210
        public void op_GreaterThan(){} // RVA: 0x7FFAC8F1C2E0
        public void LessThan(){} // RVA: 0x7FFAC8F1C3B0
        public void GreaterThan(){} // RVA: 0x7FFAC8F1C4D0
        public void ToSqlSingle(){} // RVA: 0x7FFAC8F1C5F0
        public void CompareTo(){} // RVA: 0x7FFAC8F1C8C0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F1CB10
        public void GetHashCode(){} // RVA: 0x7FFAC8F1CD80
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F1CE60
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F1CF90
        public void GetXsdType(){} // RVA: 0x7FFAC8F1D110
        public void .cctor(){} // RVA: 0x7FFAC8F1D190
    }

    public class SqlGuid : ValueType
    {
        public int IsNull;
        public int[] Value; // 0x8
        public byte[] m_value; // 0x10
        public System.Data.SqlTypes.SqlGuid Null; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F1D3A0 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFAC484C2F0
        public void get_Value(){} // RVA: 0x7FFAC8F1D410
        public void op_Implicit(){} // RVA: 0x7FFAC8F1D500
        public void ToString(){} // RVA: 0x7FFAC8F1D570
        public void Compare(){} // RVA: 0x7FFAC8F1D690
        public void op_Equality(){} // RVA: 0x7FFAC8F1D7A0
        public void op_LessThan(){} // RVA: 0x7FFAC8F1D890
        public void op_GreaterThan(){} // RVA: 0x7FFAC8F1D970
        public void CompareTo(){} // RVA: 0x7FFAC8F1DB80 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F1DE80
        public void GetHashCode(){} // RVA: 0x7FFAC8F1E0B0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F1E150
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F1E420
        public void GetXsdType(){} // RVA: 0x7FFAC8F1E630
        public void .cctor(){} // RVA: 0x7FFAC8F1E6B0
    }

    public class SqlInt16 : ValueType
    {
        public bool IsNull; // 0x10
        public short Value; // 0x12
        public int s_MASKI2;
        public System.Data.SqlTypes.SqlInt16 Null; // 0x4
        public System.Data.SqlTypes.SqlInt16 Zero; // 0x8
        public System.Data.SqlTypes.SqlInt16 MinValue; // 0xC
        public System.Data.SqlTypes.SqlInt16 MaxValue; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC65D0CD0 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFAC5F4D7E0
        public void get_Value(){} // RVA: 0x7FFAC8F1E880
        public void op_Implicit(){} // RVA: 0x7FFAC8F1EF80 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC8F1E900
        public void op_UnaryNegation(){} // RVA: 0x7FFAC8F1E990
        public void op_Addition(){} // RVA: 0x7FFAC8F1EA30
        public void op_Subtraction(){} // RVA: 0x7FFAC8F1EB60
        public void op_Multiply(){} // RVA: 0x7FFAC8F1EC90
        public void op_Division(){} // RVA: 0x7FFAC8F1EDF0
        public void op_Explicit(){} // RVA: 0x7FFAC8F1F040
        public void op_Equality(){} // RVA: 0x7FFAC8F1F1A0
        public void op_LessThan(){} // RVA: 0x7FFAC8F1F270
        public void op_GreaterThan(){} // RVA: 0x7FFAC8F1F340
        public void LessThan(){} // RVA: 0x7FFAC8F1F410
        public void GreaterThan(){} // RVA: 0x7FFAC8F1F470
        public void ToSqlDouble(){} // RVA: 0x7FFAC8F1F4D0
        public void ToSqlInt64(){} // RVA: 0x7FFAC8F1F540
        public void CompareTo(){} // RVA: 0x7FFAC8F1F6D0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F1F870
        public void GetHashCode(){} // RVA: 0x7FFAC8F1FAB0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F1FB70
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F1FD20
        public void GetXsdType(){} // RVA: 0x7FFAC8F1FE90
        public void .cctor(){} // RVA: 0x7FFAC8F1FF10
    }

    public class SqlInt32 : ValueType
    {
        public bool IsNull; // 0x10
        public int Value; // 0x14
        public long s_iIntMin;
        public long s_lBitNotIntMax; // 0x8
        public System.Data.SqlTypes.SqlInt32 Null; // 0x10
        public System.Data.SqlTypes.SqlInt32 Zero; // 0x18
        public System.Data.SqlTypes.SqlInt32 MinValue; // 0x20
        public System.Data.SqlTypes.SqlInt32 MaxValue; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC65D8D00 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFAC5F4D7E0
        public void get_Value(){} // RVA: 0x7FFAC8F1FFE0
        public void op_Implicit(){} // RVA: 0x7FFAC8F208A0 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAC8F20090
        public void op_UnaryNegation(){} // RVA: 0x7FFAC8F20120
        public void op_Addition(){} // RVA: 0x7FFAC8F201C0
        public void op_Subtraction(){} // RVA: 0x7FFAC8F20350
        public void op_Multiply(){} // RVA: 0x7FFAC8F204D0
        public void op_Division(){} // RVA: 0x7FFAC8F20640
        public void op_Explicit(){} // RVA: 0x7FFAC8F20960
        public void SameSignInt(){} // RVA: 0x7FFAC8F20AC0
        public void op_Equality(){} // RVA: 0x7FFAC8F20AE0
        public void op_LessThan(){} // RVA: 0x7FFAC8F20BB0
        public void op_GreaterThan(){} // RVA: 0x7FFAC8F20C80
        public void LessThan(){} // RVA: 0x7FFAC8F20D50
        public void GreaterThan(){} // RVA: 0x7FFAC8F20DB0
        public void ToSqlDouble(){} // RVA: 0x7FFAC8F20E10
        public void ToSqlInt64(){} // RVA: 0x7FFAC8F20E80
        public void CompareTo(){} // RVA: 0x7FFAC8F21010 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F211C0
        public void GetHashCode(){} // RVA: 0x7FFAC8F21400
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F21470
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F215B0
        public void GetXsdType(){} // RVA: 0x7FFAC8F21720
        public void .cctor(){} // RVA: 0x7FFAC8F217A0
    }

    public class SqlInt64 : ValueType
    {
        public bool IsNull; // 0x10
        public long Value; // 0x18
        public long s_lLowIntMask;
        public long s_lHighIntMask; // 0x8
        public System.Data.SqlTypes.SqlInt64 Null; // 0x10
        public System.Data.SqlTypes.SqlInt64 Zero; // 0x20
        public System.Data.SqlTypes.SqlInt64 MinValue; // 0x30
        public System.Data.SqlTypes.SqlInt64 MaxValue; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC65D5110 | overloaded x2
        public void get_IsNull(){} // RVA: 0x7FFAC5F4D7E0
        public void get_Value(){} // RVA: 0x7FFAC8F21880
        public void op_Implicit(){} // RVA: 0x7FFAC8F22530 | overloaded x4
        public void ToString(){} // RVA: 0x7FFAC8F21900
        public void op_UnaryNegation(){} // RVA: 0x7FFAC8F21990
        public void op_Addition(){} // RVA: 0x7FFAC8F21A40
        public void op_Subtraction(){} // RVA: 0x7FFAC8F21BB0
        public void op_Multiply(){} // RVA: 0x7FFAC8F21D30
        public void op_Division(){} // RVA: 0x7FFAC8F22070
        public void op_Modulus(){} // RVA: 0x7FFAC8F22200
        public void op_Explicit(){} // RVA: 0x7FFAC8F22610
        public void SameSignLong(){} // RVA: 0x7FFAC8F228D0
        public void op_Equality(){} // RVA: 0x7FFAC8F228F0
        public void op_LessThan(){} // RVA: 0x7FFAC8F229C0
        public void op_GreaterThan(){} // RVA: 0x7FFAC8F22A90
        public void LessThan(){} // RVA: 0x7FFAC8F22B60
        public void GreaterThan(){} // RVA: 0x7FFAC8F22C60
        public void ToSqlByte(){} // RVA: 0x7FFAC8F22D60
        public void ToSqlDouble(){} // RVA: 0x7FFAC8F22DD0
        public void ToSqlInt16(){} // RVA: 0x7FFAC8F22E50
        public void ToSqlInt32(){} // RVA: 0x7FFAC8F22FC0
        public void ToSqlDecimal(){} // RVA: 0x7FFAC8F23130
        public void CompareTo(){} // RVA: 0x7FFAC8F232F0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F23540
        public void GetHashCode(){} // RVA: 0x7FFAC8F237A0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F23860
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F239A0
        public void GetXsdType(){} // RVA: 0x7FFAC8F23B10
        public void .cctor(){} // RVA: 0x7FFAC8F23B90
    }

    public class SqlMoney : ValueType
    {
        public bool IsNull; // 0x10
        public long Value; // 0x18
        public int s_iMoneyScale;
        public long s_lTickBase; // 0x8
        public double s_dTickBase; // 0x10
        public long s_minLong; // 0x18
        public long s_maxLong; // 0x20
        public System.Data.SqlTypes.SqlMoney Null; // 0x28
        public System.Data.SqlTypes.SqlMoney Zero; // 0x38
        public System.Data.SqlTypes.SqlMoney MinValue; // 0x48
        public System.Data.SqlTypes.SqlMoney MaxValue; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F23E00 | overloaded x5
        public void get_IsNull(){} // RVA: 0x7FFAC5F4D7E0
        public void get_Value(){} // RVA: 0x7FFAC8F23FF0
        public void ToDecimal(){} // RVA: 0x7FFAC8F240A0
        public void ToDouble(){} // RVA: 0x7FFAC8F241C0
        public void op_Implicit(){} // RVA: 0x7FFAC8F25010 | overloaded x6
        public void ToString(){} // RVA: 0x7FFAC8F24330
        public void op_UnaryNegation(){} // RVA: 0x7FFAC8F24540
        public void op_Addition(){} // RVA: 0x7FFAC8F24670
        public void op_Subtraction(){} // RVA: 0x7FFAC8F24810
        public void op_Multiply(){} // RVA: 0x7FFAC8F249B0
        public void op_Division(){} // RVA: 0x7FFAC8F24B90
        public void op_Explicit(){} // RVA: 0x7FFAC8F25120
        public void op_Equality(){} // RVA: 0x7FFAC8F252A0
        public void op_LessThan(){} // RVA: 0x7FFAC8F25370
        public void op_GreaterThan(){} // RVA: 0x7FFAC8F25440
        public void LessThan(){} // RVA: 0x7FFAC8F25510
        public void GreaterThan(){} // RVA: 0x7FFAC8F25610
        public void ToSqlDouble(){} // RVA: 0x7FFAC8F25710
        public void ToSqlDecimal(){} // RVA: 0x7FFAC8F258A0
        public void CompareTo(){} // RVA: 0x7FFAC8F25A60 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F25CB0
        public void GetHashCode(){} // RVA: 0x7FFAC8F25F10
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F25F70
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F26150
        public void GetXsdType(){} // RVA: 0x7FFAC8F263C0
        public void .cctor(){} // RVA: 0x7FFAC8F26440
    }

    public class SqlNullValueException : SqlTypeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F2ADC0 | overloaded x4
        public void SqlNullValueExceptionSerialization(){} // RVA: 0x7FFAC8F2AEC0
    }

    public class SqlSingle : ValueType
    {
        public bool IsNull; // 0x10
        public float Value; // 0x14
        public System.Data.SqlTypes.SqlSingle Null;
        public System.Data.SqlTypes.SqlSingle Zero; // 0x8
        public System.Data.SqlTypes.SqlSingle MinValue; // 0x10
        public System.Data.SqlTypes.SqlSingle MaxValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F26650 | overloaded x3
        public void get_IsNull(){} // RVA: 0x7FFAC5F4D7E0
        public void get_Value(){} // RVA: 0x7FFAC8F266C0
        public void op_Implicit(){} // RVA: 0x7FFAC8F27600 | overloaded x7
        public void ToString(){} // RVA: 0x7FFAC8F267B0
        public void op_UnaryNegation(){} // RVA: 0x7FFAC8F26840
        public void op_Addition(){} // RVA: 0x7FFAC8F26950
        public void op_Subtraction(){} // RVA: 0x7FFAC8F26AE0
        public void op_Multiply(){} // RVA: 0x7FFAC8F26C70
        public void op_Division(){} // RVA: 0x7FFAC8F26E00
        public void op_Explicit(){} // RVA: 0x7FFAC8F277C0
        public void op_Equality(){} // RVA: 0x7FFAC8F27960
        public void op_LessThan(){} // RVA: 0x7FFAC8F27A40
        public void op_GreaterThan(){} // RVA: 0x7FFAC8F27B10
        public void LessThan(){} // RVA: 0x7FFAC8F27BE0
        public void GreaterThan(){} // RVA: 0x7FFAC8F27C40
        public void ToSqlDouble(){} // RVA: 0x7FFAC8F27CA0
        public void CompareTo(){} // RVA: 0x7FFAC8F27E30 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F27FE0
        public void GetHashCode(){} // RVA: 0x7FFAC8F28220
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F282E0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F28410
        public void GetXsdType(){} // RVA: 0x7FFAC8F28590
        public void .cctor(){} // RVA: 0x7FFAC8F28610
    }

    public class SqlStreamChars : Object
    {
        public object Length;
        public object Position;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFAC2C58E90
        public void get_Position(){} // RVA: 0x7FFAC2C58E90
        public void Read(){}
        public void Seek(){}
    }

    public class SqlString : ValueType
    {
        public string IsNull; // 0x10
        public System.Globalization.CompareInfo Value; // 0x18
        public int m_lcid; // 0x20
        public 0x6B1D1528 m_flag; // 0x24
        public bool m_fNotNull; // 0x28
        public System.Data.SqlTypes.SqlString Null;
        public System.Text.UnicodeEncoding s_unicodeEncoding; // 0x20
        public int IgnoreCase; // 0x28
        public int IgnoreWidth; // 0x2C
        public int IgnoreNonSpace; // 0x30
        public int IgnoreKanaType; // 0x34
        public int BinarySort; // 0x38
        public int BinarySort2; // 0x3C
        public 0x6B1D1528 s_iDefaultFlag; // 0x40
        public 0x6B0DB010 s_iValidCompareOptionMask; // 0x44
        public 0x6B1D1528 s_iValidSqlCompareOptionMask; // 0x48
        public int s_lcidUSEnglish; // 0x4C
        public int s_lcidBinary; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F28B50 | overloaded x4
        public void get_IsNull(){} // RVA: 0x7FFAC3515610
        public void get_Value(){} // RVA: 0x7FFAC8F28D30
        public void SetCompareInfo(){} // RVA: 0x7FFAC8F28DC0
        public void op_Implicit(){} // RVA: 0x7FFAC8F28E90
        public void ToString(){} // RVA: 0x7FFAC8F28EC0
        public void op_Addition(){} // RVA: 0x7FFAC8F28F40
        public void StringCompare(){} // RVA: 0x7FFAC8F290F0
        public void Compare(){} // RVA: 0x7FFAC8F29430
        public void op_Equality(){} // RVA: 0x7FFAC8F295D0
        public void ValidateSqlCompareOptions(){} // RVA: 0x7FFAC8F29720
        public void CompareOptionsFromSqlCompareOptions(){} // RVA: 0x7FFAC8F297D0
        public void FBinarySort(){} // RVA: 0x7FFAC8F29890
        public void CompareBinary(){} // RVA: 0x7FFAC8F298F0
        public void CompareBinary2(){} // RVA: 0x7FFAC8F29B00
        public void CompareTo(){} // RVA: 0x7FFAC8F29DB0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8F29EF0
        public void GetHashCode(){} // RVA: 0x7FFAC8F2A240
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F2A4D0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F2A630
        public void GetXsdType(){} // RVA: 0x7FFAC8F2A770
        public void .cctor(){} // RVA: 0x7FFAC8F2A7F0
    }

    public class SqlTruncateException : SqlTypeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F2B040 | overloaded x4
        public void SqlTruncateExceptionSerialization(){} // RVA: 0x7FFAC8F2B140
    }

    public class SqlTypeException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F2AB00 | overloaded x4
        public void SqlTypeExceptionSerialization(){} // RVA: 0x7FFAC8F2AC40
    }

    public class SqlXml : Object
    {
        public System.Func`4<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader> CreateSqlReaderMethodInfo;
        public System.Xml.XmlReaderSettings IsNull; // 0x8
        public System.Xml.XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; // 0x10
        public System.Reflection.MethodInfo s_createSqlReaderMethodInfo; // 0x18
        public System.Reflection.MethodInfo _createSqlReaderMethodInfo; // 0x10
        public bool _fNotNull; // 0x18
        public System.IO.Stream _stream; // 0x20
        public bool _firstCreateReader; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F2B220
        public void CreateReader(){} // RVA: 0x7FFAC8F2B280
        public void CreateSqlXmlReader(){} // RVA: 0x7FFAC8F2B4B0
        public void CreateSqlReaderDelegate(){} // RVA: 0x7FFAC8F2B630
        public void get_CreateSqlReaderMethodInfo(){} // RVA: 0x7FFAC8F2B790
        public void get_IsNull(){} // RVA: 0x7FFAC3515610
        public void SetNull(){} // RVA: 0x7FFAC8F2B220
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7FFAC34F9180
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7FFAC8F2B9A0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7FFAC8F2BBE0
        public void GetXsdType(){} // RVA: 0x7FFAC8F2BD90
        public void .cctor(){} // RVA: 0x7FFAC8F2BE10
    }

    public class SqlXmlStreamWrapper : Stream
    {
        public System.IO.Stream CanRead; // 0x28
        public long CanSeek; // 0x30
        public bool CanWrite; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F2C1E0
        public void get_CanRead(){} // RVA: 0x7FFAC8F2C290
        public void get_CanSeek(){} // RVA: 0x7FFAC8F2C2E0
        public void get_CanWrite(){} // RVA: 0x7FFAC8F2C330
        public void get_Length(){} // RVA: 0x7FFAC8F2C380
        public void get_Position(){} // RVA: 0x7FFAC8F2C400
        public void set_Position(){} // RVA: 0x7FFAC8F2C460
        public void Seek(){} // RVA: 0x7FFAC8F2C540
        public void Read(){} // RVA: 0x7FFAC8F2C7B0
        public void Write(){} // RVA: 0x7FFAC8F2C9D0
        public void ReadByte(){} // RVA: 0x7FFAC8F2CBF0
        public void WriteByte(){} // RVA: 0x7FFAC8F2CD40
        public void SetLength(){} // RVA: 0x7FFAC8F2CE40
        public void Flush(){} // RVA: 0x7FFAC8F2CED0
        public void Dispose(){} // RVA: 0x7FFAC8F2CEF0
        public void ThrowIfStreamCannotSeek(){} // RVA: 0x7FFAC8F2CF10
        public void ThrowIfStreamCannotRead(){} // RVA: 0x7FFAC8F2CFA0
        public void ThrowIfStreamCannotWrite(){} // RVA: 0x7FFAC8F2D030
        public void ThrowIfStreamClosed(){} // RVA: 0x7FFAC8F2D0C0
        public void IsStreamClosed(){} // RVA: 0x7FFAC8F2D130
    }

}