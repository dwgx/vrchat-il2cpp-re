// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data.SqlTypes
// Classes: 23
// Methods: 520

namespace ThirdParty.DotNet.System.Data.SqlTypes
{
    public class INullable
    {
        // ── Methods ──
        public void get_IsNull(){} // RVA: 0xDBE0
    }

    public class SQLResource
    {
        public object IsNull;
        public object Value;
        public object .ctor;

        // ── Methods ──
        public void get_NullString(){} // RVA: 0x6774350
        public void get_ArithOverflowMessage(){} // RVA: 0x6774390
        public void get_DivideByZeroMessage(){} // RVA: 0x67743D0
        public void get_NullValueMessage(){} // RVA: 0x6774410
        public void get_TruncationMessage(){} // RVA: 0x6774450
        public void get_DateTimeOverflowMessage(){} // RVA: 0x6774490
        public void get_ConcatDiffCollationMessage(){} // RVA: 0x67744D0
        public void get_CompareDiffCollationMessage(){} // RVA: 0x6774510
        public void get_ConversionOverflowMessage(){} // RVA: 0x6774550
        public void get_TimeZoneSpecifiedMessage(){} // RVA: 0x6774590
        public void get_InvalidPrecScaleMessage(){} // RVA: 0x67745D0
        public void get_FormatMessage(){} // RVA: 0x6774610
        public void InvalidOpStreamClosed(){} // RVA: 0x6774650
        public void InvalidOpStreamNonWritable(){} // RVA: 0x67746A0
        public void InvalidOpStreamNonReadable(){} // RVA: 0x67746F0
        public void InvalidOpStreamNonSeekable(){} // RVA: 0x6774740
    }

    public class SqlBinary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67747F0 | overloaded x2
        public void get_IsNull(){} // RVA: 0x1D26810
        public void get_Value(){} // RVA: 0x67749C0
        public void op_Implicit(){} // RVA: 0x6774AA0
        public void ToString(){} // RVA: 0x6774AD0
        public void PerformCompareByte(){} // RVA: 0x6774BE0
        public void op_Equality(){} // RVA: 0x6774D00
        public void op_LessThan(){} // RVA: 0x6774E10
        public void op_GreaterThan(){} // RVA: 0x6774F20
        public void CompareTo(){} // RVA: 0x6775150 | overloaded x2
        public void Equals(){} // RVA: 0x6775490
        public void HashByteArray(){} // RVA: 0x67756E0
        public void GetHashCode(){} // RVA: 0x6775750
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x6775830
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x6775B70
        public void GetXsdType(){} // RVA: 0x6775D50
        public void .cctor(){} // RVA: 0x6775DD0
    }

    public class SqlBoolean
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6775F30 | overloaded x3
        public void get_IsNull(){} // RVA: 0x362AF20
        public void get_Value(){} // RVA: 0x6775F50
        public void get_IsTrue(){} // RVA: 0x6775FB0
        public void get_IsFalse(){} // RVA: 0x6775FC0
        public void op_Implicit(){} // RVA: 0x6775FD0
        public void op_True(){} // RVA: 0x6775FE0
        public void op_BitwiseAnd(){} // RVA: 0x6776030
        public void op_BitwiseOr(){} // RVA: 0x6776120
        public void get_ByteValue(){} // RVA: 0x6776210
        public void ToString(){} // RVA: 0x67762A0
        public void op_Equality(){} // RVA: 0x67763B0
        public void And(){} // RVA: 0x6776470
        public void Or(){} // RVA: 0x6776590
        public void CompareTo(){} // RVA: 0x6776710 | overloaded x2
        public void Equals(){} // RVA: 0x6776830
        public void GetHashCode(){} // RVA: 0x67769F0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x6776A90
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x6776BC0
        public void GetXsdType(){} // RVA: 0x6776D20
        public void .cctor(){} // RVA: 0x6776DA0
    }

    public class SqlByte
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3CA5E30 | overloaded x2
        public void get_IsNull(){} // RVA: 0x362AF20
        public void get_Value(){} // RVA: 0x6776EB0
        public void op_Implicit(){} // RVA: 0x6776F10
        public void ToString(){} // RVA: 0x6776F20
        public void op_Addition(){} // RVA: 0x6776FB0
        public void op_Subtraction(){} // RVA: 0x67770E0
        public void op_Multiply(){} // RVA: 0x6777210
        public void op_Division(){} // RVA: 0x6777340
        public void op_Explicit(){} // RVA: 0x6777460
        public void op_Equality(){} // RVA: 0x6777620
        public void op_LessThan(){} // RVA: 0x67776F0
        public void op_GreaterThan(){} // RVA: 0x67777C0
        public void LessThan(){} // RVA: 0x6777890
        public void GreaterThan(){} // RVA: 0x67778F0
        public void ToSqlDouble(){} // RVA: 0x6777950
        public void ToSqlInt64(){} // RVA: 0x67779C0
        public void CompareTo(){} // RVA: 0x6777B50 | overloaded x2
        public void Equals(){} // RVA: 0x6777D00
        public void GetHashCode(){} // RVA: 0x6777F40
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x6777FF0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x67781A0
        public void GetXsdType(){} // RVA: 0x6778310
        public void .cctor(){} // RVA: 0x6778390
    }

    public class SqlBytes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67785A0 | overloaded x3
        public void get_IsNull(){} // RVA: 0x104D6D0
        public void get_Buffer(){} // RVA: 0x6778630
        public void get_Length(){} // RVA: 0x6778660
        public void get_Value(){} // RVA: 0x67786F0
        public void SetNull(){} // RVA: 0x6778930
        public void CopyStreamToBuffer(){} // RVA: 0x67789A0
        public void FStream(){} // RVA: 0x6778BD0
        public void SetBuffer(){} // RVA: 0x6778BE0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x6778CC0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x6778F50
        public void GetXsdType(){} // RVA: 0x6779140
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x67791C0
        public void get_Null(){} // RVA: 0x6779200
    }

    public class SqlChars
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6779250 | overloaded x3
        public void get_IsNull(){} // RVA: 0x104D6D0
        public void get_Buffer(){} // RVA: 0x67792F0
        public void get_Length(){} // RVA: 0x6779320
        public void get_Value(){} // RVA: 0x67793B0
        public void SetNull(){} // RVA: 0x6778930
        public void FStream(){} // RVA: 0x6778BD0
        public void CopyStreamToBuffer(){} // RVA: 0x67795F0
        public void SetBuffer(){} // RVA: 0x6778BE0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x6779820
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x6779A10
        public void GetXsdType(){} // RVA: 0x6779BD0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6779C50
        public void get_Null(){} // RVA: 0x6779C90
    }

    public class SqlDateTime
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6779D60 | overloaded x3
        public void get_IsNull(){} // RVA: 0x362AF20
        public void ToTimeSpan(){} // RVA: 0x6779E90
        public void ToDateTime(){} // RVA: 0x6779F20
        public void FromTimeSpan(){} // RVA: 0x677A080
        public void FromDateTime(){} // RVA: 0x677A280
        public void get_Value(){} // RVA: 0x677A430
        public void get_DayTicks(){} // RVA: 0x677A4E0
        public void get_TimeTicks(){} // RVA: 0x677A540
        public void op_Implicit(){} // RVA: 0x677A5A0
        public void ToString(){} // RVA: 0x677A5D0
        public void op_Equality(){} // RVA: 0x677A700
        public void op_LessThan(){} // RVA: 0x677A7E0
        public void op_GreaterThan(){} // RVA: 0x677A8D0
        public void LessThan(){} // RVA: 0x677A9C0
        public void GreaterThan(){} // RVA: 0x677AA50
        public void CompareTo(){} // RVA: 0x677AC20 | overloaded x2
        public void Equals(){} // RVA: 0x677AE30
        public void GetHashCode(){} // RVA: 0x677B090
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x677B180
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x677B480
        public void GetXsdType(){} // RVA: 0x677B6E0
        public void .cctor(){} // RVA: 0x677B760
    }

    public class SqlDecimal
    {
        // ── Methods ──
        public void CalculatePrecision(){} // RVA: 0x677BF00
        public void VerifyPrecision(){} // RVA: 0x677C140
        public void .ctor(){} // RVA: 0x677C980 | overloaded x5
        public void get_IsNull(){} // RVA: 0x677CBB0
        public void get_Value(){} // RVA: 0x677CC20
        public void get_IsPositive(){} // RVA: 0x677CC90
        public void SetPositive(){} // RVA: 0x677CDB0
        public void SetSignBit(){} // RVA: 0x677CE20
        public void get_Scale(){} // RVA: 0x677CED0
        public void get_Data(){} // RVA: 0x677CFC0
        public void ToString(){} // RVA: 0x677D110
        public void Parse(){} // RVA: 0x677D550
        public void ToDouble(){} // RVA: 0x677DCD0
        public void ToDecimal(){} // RVA: 0x677DEB0
        public void op_Implicit(){} // RVA: 0x6780250 | overloaded x7
        public void op_UnaryNegation(){} // RVA: 0x677E120
        public void op_Addition(){} // RVA: 0x677E330
        public void op_Subtraction(){} // RVA: 0x677EAF0
        public void op_Multiply(){} // RVA: 0x677EBC0
        public void op_Division(){} // RVA: 0x677F840
        public void ZeroToMaxLen(){} // RVA: 0x6780350
        public void FZero(){} // RVA: 0x67803D0
        public void FGt10_38(){} // RVA: 0x6780430 | overloaded x2
        public void BGetPrecUI4(){} // RVA: 0x6780480
        public void BGetPrecUI8(){} // RVA: 0x6780630
        public void AddULong(){} // RVA: 0x67809C0
        public void MultByULong(){} // RVA: 0x6780C50
        public void DivByULong(){} // RVA: 0x6780F10
        public void AdjustScale(){} // RVA: 0x6781100
        public void LAbsCmp(){} // RVA: 0x67814F0
        public void MpMove(){} // RVA: 0x67816A0
        public void MpSet(){} // RVA: 0x6781700
        public void MpNormalize(){} // RVA: 0x6781730
        public void MpMul1(){} // RVA: 0x6781770
        public void MpDiv1(){} // RVA: 0x6781850
        public void DWL(){} // RVA: 0x6781950
        public void HI(){} // RVA: 0x5EA67B0
        public void LO(){} // RVA: 0x20C5210
        public void MpDiv(){} // RVA: 0x6781960
        public void CompareNm(){} // RVA: 0x6782560
        public void CheckValidPrecScale(){} // RVA: 0x6782750
        public void op_Equality(){} // RVA: 0x6782830
        public void op_LessThan(){} // RVA: 0x6782980
        public void op_GreaterThan(){} // RVA: 0x6782AD0
        public void LessThan(){} // RVA: 0x6782C20
        public void GreaterThan(){} // RVA: 0x6782CB0
        public void ToSqlDouble(){} // RVA: 0x6782D40
        public void ToSqlInt64(){} // RVA: 0x6782DD0
        public void ToSqlMoney(){} // RVA: 0x6782E60
        public void ChFromDigit(){} // RVA: 0x6783040
        public void StoreFromWorkingArray(){} // RVA: 0x6783050
        public void SetToZero(){} // RVA: 0x67830A0
        public void CompareTo(){} // RVA: 0x6783240 | overloaded x2
        public void Equals(){} // RVA: 0x67834B0
        public void GetHashCode(){} // RVA: 0x67838E0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x6783A60
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x6783C20
        public void GetXsdType(){} // RVA: 0x6783DE0
        public void .cctor(){} // RVA: 0x6783E60
    }

    public class SqlDouble
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67847D0 | overloaded x2
        public void get_IsNull(){} // RVA: 0x362AF20
        public void get_Value(){} // RVA: 0x6784860
        public void op_Implicit(){} // RVA: 0x6785560 | overloaded x8
        public void ToString(){} // RVA: 0x67848E0
        public void op_UnaryNegation(){} // RVA: 0x6784970
        public void op_Addition(){} // RVA: 0x6784A30
        public void op_Subtraction(){} // RVA: 0x6784B80
        public void op_Multiply(){} // RVA: 0x6784CD0
        public void op_Division(){} // RVA: 0x6784E20
        public void op_Equality(){} // RVA: 0x6785690
        public void op_LessThan(){} // RVA: 0x6785760
        public void op_GreaterThan(){} // RVA: 0x6785830
        public void LessThan(){} // RVA: 0x6785900
        public void GreaterThan(){} // RVA: 0x6785A20
        public void ToSqlSingle(){} // RVA: 0x6785B40
        public void CompareTo(){} // RVA: 0x6785E10 | overloaded x2
        public void Equals(){} // RVA: 0x6786060
        public void GetHashCode(){} // RVA: 0x67862D0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x67863B0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x67864E0
        public void GetXsdType(){} // RVA: 0x6786660
        public void .cctor(){} // RVA: 0x67866E0
    }

    public class SqlGuid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67868F0 | overloaded x2
        public void get_IsNull(){} // RVA: 0x1D26810
        public void get_Value(){} // RVA: 0x6786960
        public void op_Implicit(){} // RVA: 0x6786A50
        public void ToString(){} // RVA: 0x6786AC0
        public void Compare(){} // RVA: 0x6786BE0
        public void op_Equality(){} // RVA: 0x6786CF0
        public void op_LessThan(){} // RVA: 0x6786DE0
        public void op_GreaterThan(){} // RVA: 0x6786EC0
        public void CompareTo(){} // RVA: 0x67870D0 | overloaded x2
        public void Equals(){} // RVA: 0x67873D0
        public void GetHashCode(){} // RVA: 0x6787600
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x67876A0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x6787970
        public void GetXsdType(){} // RVA: 0x6787B80
        public void .cctor(){} // RVA: 0x6787C00
    }

    public class SqlInt16
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3CAB320 | overloaded x2
        public void get_IsNull(){} // RVA: 0x362AF20
        public void get_Value(){} // RVA: 0x6787DD0
        public void op_Implicit(){} // RVA: 0x67884D0 | overloaded x2
        public void ToString(){} // RVA: 0x6787E50
        public void op_UnaryNegation(){} // RVA: 0x6787EE0
        public void op_Addition(){} // RVA: 0x6787F80
        public void op_Subtraction(){} // RVA: 0x67880B0
        public void op_Multiply(){} // RVA: 0x67881E0
        public void op_Division(){} // RVA: 0x6788340
        public void op_Explicit(){} // RVA: 0x6788590
        public void op_Equality(){} // RVA: 0x67886F0
        public void op_LessThan(){} // RVA: 0x67887C0
        public void op_GreaterThan(){} // RVA: 0x6788890
        public void LessThan(){} // RVA: 0x6788960
        public void GreaterThan(){} // RVA: 0x67889C0
        public void ToSqlDouble(){} // RVA: 0x6788A20
        public void ToSqlInt64(){} // RVA: 0x6788A90
        public void CompareTo(){} // RVA: 0x6788C20 | overloaded x2
        public void Equals(){} // RVA: 0x6788DC0
        public void GetHashCode(){} // RVA: 0x6789000
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x67890C0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x6789270
        public void GetXsdType(){} // RVA: 0x67893E0
        public void .cctor(){} // RVA: 0x6789460
    }

    public class SqlInt32
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3CB3350 | overloaded x2
        public void get_IsNull(){} // RVA: 0x362AF20
        public void get_Value(){} // RVA: 0x6789530
        public void op_Implicit(){} // RVA: 0x6789DF0 | overloaded x3
        public void ToString(){} // RVA: 0x67895E0
        public void op_UnaryNegation(){} // RVA: 0x6789670
        public void op_Addition(){} // RVA: 0x6789710
        public void op_Subtraction(){} // RVA: 0x67898A0
        public void op_Multiply(){} // RVA: 0x6789A20
        public void op_Division(){} // RVA: 0x6789B90
        public void op_Explicit(){} // RVA: 0x6789EB0
        public void SameSignInt(){} // RVA: 0x678A010
        public void op_Equality(){} // RVA: 0x678A030
        public void op_LessThan(){} // RVA: 0x678A100
        public void op_GreaterThan(){} // RVA: 0x678A1D0
        public void LessThan(){} // RVA: 0x678A2A0
        public void GreaterThan(){} // RVA: 0x678A300
        public void ToSqlDouble(){} // RVA: 0x678A360
        public void ToSqlInt64(){} // RVA: 0x678A3D0
        public void CompareTo(){} // RVA: 0x678A560 | overloaded x2
        public void Equals(){} // RVA: 0x678A710
        public void GetHashCode(){} // RVA: 0x678A950
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x678A9C0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x678AB00
        public void GetXsdType(){} // RVA: 0x678AC70
        public void .cctor(){} // RVA: 0x678ACF0
    }

    public class SqlInt64
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3CAF760 | overloaded x2
        public void get_IsNull(){} // RVA: 0x362AF20
        public void get_Value(){} // RVA: 0x678ADD0
        public void op_Implicit(){} // RVA: 0x678BA80 | overloaded x4
        public void ToString(){} // RVA: 0x678AE50
        public void op_UnaryNegation(){} // RVA: 0x678AEE0
        public void op_Addition(){} // RVA: 0x678AF90
        public void op_Subtraction(){} // RVA: 0x678B100
        public void op_Multiply(){} // RVA: 0x678B280
        public void op_Division(){} // RVA: 0x678B5C0
        public void op_Modulus(){} // RVA: 0x678B750
        public void op_Explicit(){} // RVA: 0x678BB60
        public void SameSignLong(){} // RVA: 0x678BE20
        public void op_Equality(){} // RVA: 0x678BE40
        public void op_LessThan(){} // RVA: 0x678BF10
        public void op_GreaterThan(){} // RVA: 0x678BFE0
        public void LessThan(){} // RVA: 0x678C0B0
        public void GreaterThan(){} // RVA: 0x678C1B0
        public void ToSqlByte(){} // RVA: 0x678C2B0
        public void ToSqlDouble(){} // RVA: 0x678C320
        public void ToSqlInt16(){} // RVA: 0x678C3A0
        public void ToSqlInt32(){} // RVA: 0x678C510
        public void ToSqlDecimal(){} // RVA: 0x678C680
        public void CompareTo(){} // RVA: 0x678C840 | overloaded x2
        public void Equals(){} // RVA: 0x678CA90
        public void GetHashCode(){} // RVA: 0x678CCF0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x678CDB0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x678CEF0
        public void GetXsdType(){} // RVA: 0x678D060
        public void .cctor(){} // RVA: 0x678D0E0
    }

    public class SqlMoney
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x678D350 | overloaded x5
        public void get_IsNull(){} // RVA: 0x362AF20
        public void get_Value(){} // RVA: 0x678D540
        public void ToDecimal(){} // RVA: 0x678D5F0
        public void ToDouble(){} // RVA: 0x678D710
        public void op_Implicit(){} // RVA: 0x678E560 | overloaded x6
        public void ToString(){} // RVA: 0x678D880
        public void op_UnaryNegation(){} // RVA: 0x678DA90
        public void op_Addition(){} // RVA: 0x678DBC0
        public void op_Subtraction(){} // RVA: 0x678DD60
        public void op_Multiply(){} // RVA: 0x678DF00
        public void op_Division(){} // RVA: 0x678E0E0
        public void op_Explicit(){} // RVA: 0x678E670
        public void op_Equality(){} // RVA: 0x678E7F0
        public void op_LessThan(){} // RVA: 0x678E8C0
        public void op_GreaterThan(){} // RVA: 0x678E990
        public void LessThan(){} // RVA: 0x678EA60
        public void GreaterThan(){} // RVA: 0x678EB60
        public void ToSqlDouble(){} // RVA: 0x678EC60
        public void ToSqlDecimal(){} // RVA: 0x678EDF0
        public void CompareTo(){} // RVA: 0x678EFB0 | overloaded x2
        public void Equals(){} // RVA: 0x678F200
        public void GetHashCode(){} // RVA: 0x678F460
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x678F4C0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x678F6A0
        public void GetXsdType(){} // RVA: 0x678F910
        public void .cctor(){} // RVA: 0x678F990
    }

    public class SqlNullValueException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6794310 | overloaded x4
        public void SqlNullValueExceptionSerialization(){} // RVA: 0x6794410
    }

    public class SqlSingle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x678FBA0 | overloaded x3
        public void get_IsNull(){} // RVA: 0x362AF20
        public void get_Value(){} // RVA: 0x678FC10
        public void op_Implicit(){} // RVA: 0x6790B50 | overloaded x7
        public void ToString(){} // RVA: 0x678FD00
        public void op_UnaryNegation(){} // RVA: 0x678FD90
        public void op_Addition(){} // RVA: 0x678FEA0
        public void op_Subtraction(){} // RVA: 0x6790030
        public void op_Multiply(){} // RVA: 0x67901C0
        public void op_Division(){} // RVA: 0x6790350
        public void op_Explicit(){} // RVA: 0x6790D10
        public void op_Equality(){} // RVA: 0x6790EB0
        public void op_LessThan(){} // RVA: 0x6790F90
        public void op_GreaterThan(){} // RVA: 0x6791060
        public void LessThan(){} // RVA: 0x6791130
        public void GreaterThan(){} // RVA: 0x6791190
        public void ToSqlDouble(){} // RVA: 0x67911F0
        public void CompareTo(){} // RVA: 0x6791380 | overloaded x2
        public void Equals(){} // RVA: 0x6791530
        public void GetHashCode(){} // RVA: 0x6791770
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x6791830
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x6791960
        public void GetXsdType(){} // RVA: 0x6791AE0
        public void .cctor(){} // RVA: 0x6791B60
    }

    public class SqlStreamChars
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0xCD60
        public void get_Position(){} // RVA: 0xCD60
        public void Read(){}
        public void Seek(){}
    }

    public class SqlString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67920A0 | overloaded x4
        public void get_IsNull(){} // RVA: 0xF44720
        public void get_Value(){} // RVA: 0x6792280
        public void SetCompareInfo(){} // RVA: 0x6792310
        public void op_Implicit(){} // RVA: 0x67923E0
        public void ToString(){} // RVA: 0x6792410
        public void op_Addition(){} // RVA: 0x6792490
        public void StringCompare(){} // RVA: 0x6792640
        public void Compare(){} // RVA: 0x6792980
        public void op_Equality(){} // RVA: 0x6792B20
        public void ValidateSqlCompareOptions(){} // RVA: 0x6792C70
        public void CompareOptionsFromSqlCompareOptions(){} // RVA: 0x6792D20
        public void FBinarySort(){} // RVA: 0x6792DE0
        public void CompareBinary(){} // RVA: 0x6792E40
        public void CompareBinary2(){} // RVA: 0x6793050
        public void CompareTo(){} // RVA: 0x6793300 | overloaded x2
        public void Equals(){} // RVA: 0x6793440
        public void GetHashCode(){} // RVA: 0x6793790
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x6793A20
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x6793B80
        public void GetXsdType(){} // RVA: 0x6793CC0
        public void .cctor(){} // RVA: 0x6793D40
    }

    public class SqlTruncateException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6794590 | overloaded x4
        public void SqlTruncateExceptionSerialization(){} // RVA: 0x6794690
    }

    public class SqlTypeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6794050 | overloaded x4
        public void SqlTypeExceptionSerialization(){} // RVA: 0x6794190
    }

    public class SqlXml
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6794770
        public void CreateReader(){} // RVA: 0x67947D0
        public void CreateSqlXmlReader(){} // RVA: 0x6794A00
        public void CreateSqlReaderDelegate(){} // RVA: 0x6794B80
        public void get_CreateSqlReaderMethodInfo(){} // RVA: 0x6794CE0
        public void get_IsNull(){} // RVA: 0xF44720
        public void SetNull(){} // RVA: 0x6794770
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x519240
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x6794EF0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x6795130
        public void GetXsdType(){} // RVA: 0x67952E0
        public void .cctor(){} // RVA: 0x6795360
    }

    public class SqlXmlStreamWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6795730
        public void get_CanRead(){} // RVA: 0x67957E0
        public void get_CanSeek(){} // RVA: 0x6795830
        public void get_CanWrite(){} // RVA: 0x6795880
        public void get_Length(){} // RVA: 0x67958D0
        public void get_Position(){} // RVA: 0x6795950
        public void set_Position(){} // RVA: 0x67959B0
        public void Seek(){} // RVA: 0x6795A90
        public void Read(){} // RVA: 0x6795D00
        public void Write(){} // RVA: 0x6795F20
        public void ReadByte(){} // RVA: 0x6796140
        public void WriteByte(){} // RVA: 0x6796290
        public void SetLength(){} // RVA: 0x6796390
        public void Flush(){} // RVA: 0x6796420
        public void Dispose(){} // RVA: 0x6796440
        public void ThrowIfStreamCannotSeek(){} // RVA: 0x6796460
        public void ThrowIfStreamCannotRead(){} // RVA: 0x67964F0
        public void ThrowIfStreamCannotWrite(){} // RVA: 0x6796580
        public void ThrowIfStreamClosed(){} // RVA: 0x6796610
        public void IsStreamClosed(){} // RVA: 0x6796680
    }

}