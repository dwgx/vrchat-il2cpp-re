// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data.SqlTypes
// Classes: 23
// Methods: 439

namespace ThirdParty.DotNet.System.Data.SqlTypes
{
    public class INullable
    {
        // ── Methods ──
        public void get_IsNull(){} // RVA: 0x7A7E01900
    }

    public class SQLResource : Object
    {
        // ── Methods ──
        public void get_NullString(){} // RVA: 0x7AE5622E0
        public void get_ArithOverflowMessage(){} // RVA: 0x7AE562320
        public void get_DivideByZeroMessage(){} // RVA: 0x7AE562360
        public void get_NullValueMessage(){} // RVA: 0x7AE5623A0
        public void get_TruncationMessage(){} // RVA: 0x7AE5623E0
        public void get_DateTimeOverflowMessage(){} // RVA: 0x7AE562420
        public void get_ConcatDiffCollationMessage(){} // RVA: 0x7AE562460
        public void get_CompareDiffCollationMessage(){} // RVA: 0x7AE5624A0
        public void get_ConversionOverflowMessage(){} // RVA: 0x7AE5624E0
        public void get_TimeZoneSpecifiedMessage(){} // RVA: 0x7AE562520
        public void get_InvalidPrecScaleMessage(){} // RVA: 0x7AE562560
        public void get_FormatMessage(){} // RVA: 0x7AE5625A0
        public void InvalidOpStreamClosed(){} // RVA: 0x7AE5625E0
        public void InvalidOpStreamNonWritable(){} // RVA: 0x7AE562630
        public void InvalidOpStreamNonReadable(){} // RVA: 0x7AE562680
        public void InvalidOpStreamNonSeekable(){} // RVA: 0x7AE5626D0
    }

    public class SqlBinary : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E84090
        public void get_IsNull(){} // RVA: 0x7A7673DE0
        public void get_Value(){} // RVA: 0x7A7E840A0
        public void op_Implicit(){} // RVA: 0x7AE562A30
        public void ToString(){} // RVA: 0x7A7E840B0
        public void PerformCompareByte(){} // RVA: 0x7AE562B70
        public void op_Equality(){} // RVA: 0x7AE562CA0
        public void op_LessThan(){} // RVA: 0x7AE562DB0
        public void op_GreaterThan(){} // RVA: 0x7AE562EC0
        public void CompareTo(){} // RVA: 0x7A7E841E0
        public void Equals(){} // RVA: 0x7A7E841F0
        public void HashByteArray(){} // RVA: 0x7AE563680
        public void GetHashCode(){} // RVA: 0x7A7E84200
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E84210
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E84220
        public void GetXsdType(){} // RVA: 0x7AE563D00
        public void .cctor(){} // RVA: 0x7AE563D80
    }

    public class SqlBoolean : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E842A0
        public void get_IsNull(){} // RVA: 0x7A7E842C0
        public void get_Value(){} // RVA: 0x7A7E842D0
        public void get_IsTrue(){} // RVA: 0x7A7E842E0
        public void get_IsFalse(){} // RVA: 0x7A7E842F0
        public void op_Implicit(){} // RVA: 0x7AE563F80
        public void op_True(){} // RVA: 0x7AE563F90
        public void op_BitwiseAnd(){} // RVA: 0x7AE563FE0
        public void op_BitwiseOr(){} // RVA: 0x7AE5640D0
        public void get_ByteValue(){} // RVA: 0x7A7E84300
        public void ToString(){} // RVA: 0x7A7E84310
        public void op_Equality(){} // RVA: 0x7AE564360
        public void And(){} // RVA: 0x7AE564420
        public void Or(){} // RVA: 0x7AE564540
        public void CompareTo(){} // RVA: 0x7A7E84540
        public void Equals(){} // RVA: 0x7A7E84550
        public void GetHashCode(){} // RVA: 0x7A7E84560
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E84600
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E84730
        public void GetXsdType(){} // RVA: 0x7AE564CD0
        public void .cctor(){} // RVA: 0x7AE564D50
    }

    public class SqlByte : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E84910
        public void get_IsNull(){} // RVA: 0x7A7E842C0
        public void get_Value(){} // RVA: 0x7A7E84920
        public void op_Implicit(){} // RVA: 0x7AE564EC0
        public void ToString(){} // RVA: 0x7A7E84980
        public void op_Addition(){} // RVA: 0x7AE564F60
        public void op_Subtraction(){} // RVA: 0x7AE565090
        public void op_Multiply(){} // RVA: 0x7AE5651C0
        public void op_Division(){} // RVA: 0x7AE5652F0
        public void op_Explicit(){} // RVA: 0x7AE565410
        public void op_Equality(){} // RVA: 0x7AE5655D0
        public void op_LessThan(){} // RVA: 0x7AE5656A0
        public void op_GreaterThan(){} // RVA: 0x7AE565770
        public void LessThan(){} // RVA: 0x7AE565840
        public void GreaterThan(){} // RVA: 0x7AE5658A0
        public void ToSqlDouble(){} // RVA: 0x7A7E84A10
        public void ToSqlInt64(){} // RVA: 0x7A7E84A80
        public void CompareTo(){} // RVA: 0x7A7E84C10
        public void Equals(){} // RVA: 0x7A7E84C20
        public void GetHashCode(){} // RVA: 0x7A7E84C30
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E84CE0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E84E90
        public void GetXsdType(){} // RVA: 0x7AE5662C0
        public void .cctor(){} // RVA: 0x7AE566340
    }

    public class SqlBytes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE566550
        public void get_IsNull(){} // RVA: 0x7A8E20EE0
        public void get_Buffer(){} // RVA: 0x7AE5665E0
        public void get_Length(){} // RVA: 0x7AE566610
        public void get_Value(){} // RVA: 0x7AE5666A0
        public void SetNull(){} // RVA: 0x7AE5668E0
        public void CopyStreamToBuffer(){} // RVA: 0x7AE566950
        public void FStream(){} // RVA: 0x7AE566B80
        public void SetBuffer(){} // RVA: 0x7AE566B90
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A82D1450
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7AE566C70
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7AE566F20
        public void GetXsdType(){} // RVA: 0x7AE567110
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE567190
        public void get_Null(){} // RVA: 0x7AE5671D0
    }

    public class SqlChars : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE567220
        public void get_IsNull(){} // RVA: 0x7A8E20EE0
        public void get_Buffer(){} // RVA: 0x7AE5672C0
        public void get_Length(){} // RVA: 0x7AE5672F0
        public void get_Value(){} // RVA: 0x7AE567380
        public void SetNull(){} // RVA: 0x7AE5668E0
        public void FStream(){} // RVA: 0x7AE566B80
        public void CopyStreamToBuffer(){} // RVA: 0x7AE5675C0
        public void SetBuffer(){} // RVA: 0x7AE566B90
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A82D1450
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7AE5677F0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7AE5679E0
        public void GetXsdType(){} // RVA: 0x7AE567BA0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE567C20
        public void get_Null(){} // RVA: 0x7AE567C60
    }

    public class SqlDateTime : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E85060
        public void get_IsNull(){} // RVA: 0x7A7E842C0
        public void ToTimeSpan(){} // RVA: 0x7AE567E60
        public void ToDateTime(){} // RVA: 0x7AE567EF0
        public void FromTimeSpan(){} // RVA: 0x7AE568050
        public void FromDateTime(){} // RVA: 0x7AE568250
        public void get_Value(){} // RVA: 0x7A7E85070
        public void get_DayTicks(){} // RVA: 0x7A7E85080
        public void get_TimeTicks(){} // RVA: 0x7A7E850E0
        public void op_Implicit(){} // RVA: 0x7AE568570
        public void ToString(){} // RVA: 0x7A7E85140
        public void op_Equality(){} // RVA: 0x7AE5686D0
        public void op_LessThan(){} // RVA: 0x7AE5687B0
        public void op_GreaterThan(){} // RVA: 0x7AE5688A0
        public void LessThan(){} // RVA: 0x7AE568990
        public void GreaterThan(){} // RVA: 0x7AE568A20
        public void CompareTo(){} // RVA: 0x7A7E853B0
        public void Equals(){} // RVA: 0x7A7E853E0
        public void GetHashCode(){} // RVA: 0x7A7E853F0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E854E0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E854F0
        public void GetXsdType(){} // RVA: 0x7AE5696B0
        public void .cctor(){} // RVA: 0x7AE569730
    }

    public class SqlDecimal : ValueType
    {
        // ── Methods ──
        public void CalculatePrecision(){} // RVA: 0x7A7E85500
        public void VerifyPrecision(){} // RVA: 0x7A7E85510
        public void .ctor(){} // RVA: 0x7A7E85570
        public void get_IsNull(){} // RVA: 0x7A7E85590
        public void get_Value(){} // RVA: 0x7A7E855A0
        public void get_IsPositive(){} // RVA: 0x7A7E85610
        public void SetPositive(){} // RVA: 0x7A7E85620
        public void SetSignBit(){} // RVA: 0x7A7E85630
        public void get_Scale(){} // RVA: 0x7A7E85640
        public void get_Data(){} // RVA: 0x7A7E85650
        public void ToString(){} // RVA: 0x7A7E85660
        public void Parse(){} // RVA: 0x7AE56B570
        public void ToDouble(){} // RVA: 0x7A7E85670
        public void ToDecimal(){} // RVA: 0x7A7E85680
        public void op_Implicit(){} // RVA: 0x7AE56E3A0
        public void op_UnaryNegation(){} // RVA: 0x7AE56C160
        public void op_Addition(){} // RVA: 0x7AE56C370
        public void op_Subtraction(){} // RVA: 0x7AE56CB80
        public void op_Multiply(){} // RVA: 0x7AE56CC50
        public void op_Division(){} // RVA: 0x7AE56D990
        public void ZeroToMaxLen(){} // RVA: 0x7AE56E4A0
        public void FZero(){} // RVA: 0x7A7E856B0
        public void FGt10_38(){} // RVA: 0x7A7E85710
        public void BGetPrecUI4(){} // RVA: 0x7AE56E5D0
        public void BGetPrecUI8(){} // RVA: 0x7AE56E780
        public void AddULong(){} // RVA: 0x7A7E85760
        public void MultByULong(){} // RVA: 0x7A7E85770
        public void DivByULong(){} // RVA: 0x7A7E85780
        public void AdjustScale(){} // RVA: 0x7A7E85790
        public void LAbsCmp(){} // RVA: 0x7A7E857A0
        public void MpMove(){} // RVA: 0x7AE56F830
        public void MpSet(){} // RVA: 0x7AE56F8A0
        public void MpNormalize(){} // RVA: 0x7AE56F8D0
        public void MpMul1(){} // RVA: 0x7AE56F910
        public void MpDiv1(){} // RVA: 0x7AE56F9F0
        public void DWL(){} // RVA: 0x7AE56FAF0
        public void HI(){} // RVA: 0x7ADC953C0
        public void LO(){} // RVA: 0x7A9ED9B50
        public void MpDiv(){} // RVA: 0x7AE56FB00
        public void CompareNm(){} // RVA: 0x7A7E857D0
        public void CheckValidPrecScale(){} // RVA: 0x7AE570960
        public void op_Equality(){} // RVA: 0x7AE570A40
        public void op_LessThan(){} // RVA: 0x7AE570B90
        public void op_GreaterThan(){} // RVA: 0x7AE570CE0
        public void LessThan(){} // RVA: 0x7AE570E30
        public void GreaterThan(){} // RVA: 0x7AE570EC0
        public void ToSqlDouble(){} // RVA: 0x7A7E85800
        public void ToSqlInt64(){} // RVA: 0x7A7E85890
        public void ToSqlMoney(){} // RVA: 0x7A7E85920
        public void ChFromDigit(){} // RVA: 0x7AE571250
        public void StoreFromWorkingArray(){} // RVA: 0x7A7E85950
        public void SetToZero(){} // RVA: 0x7A7E859A0
        public void CompareTo(){} // RVA: 0x7A7E85AE0
        public void Equals(){} // RVA: 0x7A7E85B10
        public void GetHashCode(){} // RVA: 0x7A7E85B20
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E85CB0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E85E80
        public void GetXsdType(){} // RVA: 0x7AE571FF0
        public void .cctor(){} // RVA: 0x7AE572070
    }

    public class SqlDouble : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E86080
        public void get_IsNull(){} // RVA: 0x7A7E842C0
        public void get_Value(){} // RVA: 0x7A7E86090
        public void op_Implicit(){} // RVA: 0x7AE573770
        public void ToString(){} // RVA: 0x7A7E860F0
        public void op_UnaryNegation(){} // RVA: 0x7AE572B80
        public void op_Addition(){} // RVA: 0x7AE572C40
        public void op_Subtraction(){} // RVA: 0x7AE572D90
        public void op_Multiply(){} // RVA: 0x7AE572EE0
        public void op_Division(){} // RVA: 0x7AE573030
        public void op_Equality(){} // RVA: 0x7AE5738A0
        public void op_LessThan(){} // RVA: 0x7AE573970
        public void op_GreaterThan(){} // RVA: 0x7AE573A40
        public void LessThan(){} // RVA: 0x7AE573B10
        public void GreaterThan(){} // RVA: 0x7AE573C30
        public void ToSqlSingle(){} // RVA: 0x7A7E86180
        public void CompareTo(){} // RVA: 0x7A7E862C0
        public void Equals(){} // RVA: 0x7A7E862E0
        public void GetHashCode(){} // RVA: 0x7A7E862F0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E863D0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E86510
        public void GetXsdType(){} // RVA: 0x7AE574870
        public void .cctor(){} // RVA: 0x7AE5748F0
    }

    public class SqlGuid : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E86740
        public void get_IsNull(){} // RVA: 0x7A7673DE0
        public void get_Value(){} // RVA: 0x7A7E867B0
        public void op_Implicit(){} // RVA: 0x7AE574C60
        public void ToString(){} // RVA: 0x7A7E867E0
        public void Compare(){} // RVA: 0x7AE574E00
        public void op_Equality(){} // RVA: 0x7AE574F10
        public void op_LessThan(){} // RVA: 0x7AE575000
        public void op_GreaterThan(){} // RVA: 0x7AE5750E0
        public void CompareTo(){} // RVA: 0x7A7E86910
        public void Equals(){} // RVA: 0x7A7E86920
        public void GetHashCode(){} // RVA: 0x7A7E86930
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E869D0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E869E0
        public void GetXsdType(){} // RVA: 0x7AE575DA0
        public void .cctor(){} // RVA: 0x7AE575E20
    }

    public class SqlInt16 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E86A30
        public void get_IsNull(){} // RVA: 0x7A7E842C0
        public void get_Value(){} // RVA: 0x7A7E86A40
        public void op_Implicit(){} // RVA: 0x7AE5766F0
        public void ToString(){} // RVA: 0x7A7E86AA0
        public void op_UnaryNegation(){} // RVA: 0x7AE576100
        public void op_Addition(){} // RVA: 0x7AE5761A0
        public void op_Subtraction(){} // RVA: 0x7AE5762D0
        public void op_Multiply(){} // RVA: 0x7AE576400
        public void op_Division(){} // RVA: 0x7AE576560
        public void op_Explicit(){} // RVA: 0x7AE5767B0
        public void op_Equality(){} // RVA: 0x7AE576910
        public void op_LessThan(){} // RVA: 0x7AE5769E0
        public void op_GreaterThan(){} // RVA: 0x7AE576AB0
        public void LessThan(){} // RVA: 0x7AE576B80
        public void GreaterThan(){} // RVA: 0x7AE576BE0
        public void ToSqlDouble(){} // RVA: 0x7A7E86B30
        public void ToSqlInt64(){} // RVA: 0x7A7E86BA0
        public void CompareTo(){} // RVA: 0x7A7E86D30
        public void Equals(){} // RVA: 0x7A7E86D40
        public void GetHashCode(){} // RVA: 0x7A7E86D50
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E86E10
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E86FC0
        public void GetXsdType(){} // RVA: 0x7AE577600
        public void .cctor(){} // RVA: 0x7AE577680
    }

    public class SqlInt32 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E87140
        public void get_IsNull(){} // RVA: 0x7A7E842C0
        public void get_Value(){} // RVA: 0x7A7E87150
        public void op_Implicit(){} // RVA: 0x7AE577FB0
        public void ToString(){} // RVA: 0x7A7E87160
        public void op_UnaryNegation(){} // RVA: 0x7AE577890
        public void op_Addition(){} // RVA: 0x7AE577930
        public void op_Subtraction(){} // RVA: 0x7AE577A90
        public void op_Multiply(){} // RVA: 0x7AE577BE0
        public void op_Division(){} // RVA: 0x7AE577D50
        public void op_Explicit(){} // RVA: 0x7AE578070
        public void SameSignInt(){} // RVA: 0x7AE5781D0
        public void op_Equality(){} // RVA: 0x7AE5781E0
        public void op_LessThan(){} // RVA: 0x7AE5782B0
        public void op_GreaterThan(){} // RVA: 0x7AE578380
        public void LessThan(){} // RVA: 0x7AE578450
        public void GreaterThan(){} // RVA: 0x7AE5784B0
        public void ToSqlDouble(){} // RVA: 0x7A7E871F0
        public void ToSqlInt64(){} // RVA: 0x7A7E87260
        public void CompareTo(){} // RVA: 0x7A7E873F0
        public void Equals(){} // RVA: 0x7A7E87400
        public void GetHashCode(){} // RVA: 0x7A7E87410
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E87490
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E875D0
        public void GetXsdType(){} // RVA: 0x7AE578E20
        public void .cctor(){} // RVA: 0x7AE578EA0
    }

    public class SqlInt64 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E87740
        public void get_IsNull(){} // RVA: 0x7A7E842C0
        public void get_Value(){} // RVA: 0x7A7E87750
        public void op_Implicit(){} // RVA: 0x7AE579C30
        public void ToString(){} // RVA: 0x7A7E877B0
        public void op_UnaryNegation(){} // RVA: 0x7AE579090
        public void op_Addition(){} // RVA: 0x7AE579140
        public void op_Subtraction(){} // RVA: 0x7AE5792B0
        public void op_Multiply(){} // RVA: 0x7AE579430
        public void op_Division(){} // RVA: 0x7AE579770
        public void op_Modulus(){} // RVA: 0x7AE579900
        public void op_Explicit(){} // RVA: 0x7AE579D10
        public void SameSignLong(){} // RVA: 0x7AE579FC0
        public void op_Equality(){} // RVA: 0x7AE579FE0
        public void op_LessThan(){} // RVA: 0x7AE57A0B0
        public void op_GreaterThan(){} // RVA: 0x7AE57A180
        public void LessThan(){} // RVA: 0x7AE57A250
        public void GreaterThan(){} // RVA: 0x7AE57A350
        public void ToSqlByte(){} // RVA: 0x7A7E87840
        public void ToSqlDouble(){} // RVA: 0x7A7E87850
        public void ToSqlInt16(){} // RVA: 0x7A7E878D0
        public void ToSqlInt32(){} // RVA: 0x7A7E878E0
        public void ToSqlDecimal(){} // RVA: 0x7A7E878F0
        public void CompareTo(){} // RVA: 0x7A7E87AB0
        public void Equals(){} // RVA: 0x7A7E87AD0
        public void GetHashCode(){} // RVA: 0x7A7E87AE0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E87BA0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E87CE0
        public void GetXsdType(){} // RVA: 0x7AE57B200
        public void .cctor(){} // RVA: 0x7AE57B280
    }

    public class SqlMoney : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E87E70
        public void get_IsNull(){} // RVA: 0x7A7E842C0
        public void get_Value(){} // RVA: 0x7A7E87E90
        public void ToDecimal(){} // RVA: 0x7A7E87EC0
        public void ToDouble(){} // RVA: 0x7A7E87EF0
        public void op_Implicit(){} // RVA: 0x7AE57C700
        public void ToString(){} // RVA: 0x7A7E87F00
        public void op_UnaryNegation(){} // RVA: 0x7AE57BC30
        public void op_Addition(){} // RVA: 0x7AE57BD60
        public void op_Subtraction(){} // RVA: 0x7AE57BF00
        public void op_Multiply(){} // RVA: 0x7AE57C0A0
        public void op_Division(){} // RVA: 0x7AE57C280
        public void op_Explicit(){} // RVA: 0x7AE57C810
        public void op_Equality(){} // RVA: 0x7AE57C990
        public void op_LessThan(){} // RVA: 0x7AE57CA60
        public void op_GreaterThan(){} // RVA: 0x7AE57CB30
        public void LessThan(){} // RVA: 0x7AE57CC00
        public void GreaterThan(){} // RVA: 0x7AE57CD00
        public void ToSqlDouble(){} // RVA: 0x7A7E87F10
        public void ToSqlDecimal(){} // RVA: 0x7A7E87F40
        public void CompareTo(){} // RVA: 0x7A7E88100
        public void Equals(){} // RVA: 0x7A7E88120
        public void GetHashCode(){} // RVA: 0x7A7E88130
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E88190
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E881A0
        public void GetXsdType(){} // RVA: 0x7AE57DAB0
        public void .cctor(){} // RVA: 0x7AE57DB30
    }

    public class SqlNullValueException : SqlTypeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5824E0
        public void SqlNullValueExceptionSerialization(){} // RVA: 0x7AE5825F0
    }

    public class SqlSingle : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E881C0
        public void get_IsNull(){} // RVA: 0x7A7E842C0
        public void get_Value(){} // RVA: 0x7A7E881D0
        public void op_Implicit(){} // RVA: 0x7AE57ECF0
        public void ToString(){} // RVA: 0x7A7E88230
        public void op_UnaryNegation(){} // RVA: 0x7AE57DF30
        public void op_Addition(){} // RVA: 0x7AE57E040
        public void op_Subtraction(){} // RVA: 0x7AE57E1D0
        public void op_Multiply(){} // RVA: 0x7AE57E360
        public void op_Division(){} // RVA: 0x7AE57E4F0
        public void op_Explicit(){} // RVA: 0x7AE57EEB0
        public void op_Equality(){} // RVA: 0x7AE57F050
        public void op_LessThan(){} // RVA: 0x7AE57F130
        public void op_GreaterThan(){} // RVA: 0x7AE57F200
        public void LessThan(){} // RVA: 0x7AE57F2D0
        public void GreaterThan(){} // RVA: 0x7AE57F330
        public void ToSqlDouble(){} // RVA: 0x7A7E882C0
        public void CompareTo(){} // RVA: 0x7A7E88450
        public void Equals(){} // RVA: 0x7A7E88460
        public void GetHashCode(){} // RVA: 0x7A7E88470
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E88530
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E88670
        public void GetXsdType(){} // RVA: 0x7AE57FC80
        public void .cctor(){} // RVA: 0x7AE57FD00
    }

    public class SqlStreamChars : Object
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0x7A7E00680
        public void get_Position(){} // RVA: 0x7A7E00680
        public void Read(){} // RVA: 0x7A7E0A0A0
        public void Seek(){} // RVA: 0x7A7E06460
    }

    public class SqlString : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E88840
        public void get_IsNull(){} // RVA: 0x7A7E88850
        public void get_Value(){} // RVA: 0x7A7E88860
        public void SetCompareInfo(){} // RVA: 0x7A7E88870
        public void op_Implicit(){} // RVA: 0x7AE580580
        public void ToString(){} // RVA: 0x7A7E88880
        public void op_Addition(){} // RVA: 0x7AE580630
        public void StringCompare(){} // RVA: 0x7AE5807E0
        public void Compare(){} // RVA: 0x7AE580B20
        public void op_Equality(){} // RVA: 0x7AE580CC0
        public void ValidateSqlCompareOptions(){} // RVA: 0x7AE580E10
        public void CompareOptionsFromSqlCompareOptions(){} // RVA: 0x7AE580EC0
        public void FBinarySort(){} // RVA: 0x7A7E88900
        public void CompareBinary(){} // RVA: 0x7AE580FE0
        public void CompareBinary2(){} // RVA: 0x7AE581210
        public void CompareTo(){} // RVA: 0x7A7E88AA0
        public void Equals(){} // RVA: 0x7A7E88AD0
        public void GetHashCode(){} // RVA: 0x7A7E88AE0
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A76850B0
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7A7E88AF0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7A7E88C50
        public void GetXsdType(){} // RVA: 0x7AE581E90
        public void .cctor(){} // RVA: 0x7AE581F10
    }

    public class SqlTruncateException : SqlTypeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE582770
        public void SqlTruncateExceptionSerialization(){} // RVA: 0x7AE582880
    }

    public class SqlTypeException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE582220
        public void SqlTypeExceptionSerialization(){} // RVA: 0x7AE582360
    }

    public class SqlXml : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE582960
        public void CreateReader(){} // RVA: 0x7AE5829C0
        public void CreateSqlXmlReader(){} // RVA: 0x7AE582BF0
        public void CreateSqlReaderDelegate(){} // RVA: 0x7AE582D70
        public void get_CreateSqlReaderMethodInfo(){} // RVA: 0x7AE582ED0
        public void get_IsNull(){} // RVA: 0x7A8D0F030
        public void SetNull(){} // RVA: 0x7AE582960
        public void System.Xml.Serialization.IXmlSerializable.GetSchema(){} // RVA: 0x7A82D1450
        public void System.Xml.Serialization.IXmlSerializable.ReadXml(){} // RVA: 0x7AE5830E0
        public void System.Xml.Serialization.IXmlSerializable.WriteXml(){} // RVA: 0x7AE583320
        public void GetXsdType(){} // RVA: 0x7AE5834D0
        public void .cctor(){} // RVA: 0x7AE583550
    }

    public class SqlXmlStreamWrapper : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE583920
        public void get_CanRead(){} // RVA: 0x7AE5839D0
        public void get_CanSeek(){} // RVA: 0x7AE583A20
        public void get_CanWrite(){} // RVA: 0x7AE583A70
        public void get_Length(){} // RVA: 0x7AE583AC0
        public void get_Position(){} // RVA: 0x7AE583B40
        public void set_Position(){} // RVA: 0x7AE583BA0
        public void Seek(){} // RVA: 0x7AE583C80
        public void Read(){} // RVA: 0x7AE583EF0
        public void Write(){} // RVA: 0x7AE584110
        public void ReadByte(){} // RVA: 0x7AE584330
        public void WriteByte(){} // RVA: 0x7AE584480
        public void SetLength(){} // RVA: 0x7AE584580
        public void Flush(){} // RVA: 0x7AE584610
        public void Dispose(){} // RVA: 0x7AE584630
        public void ThrowIfStreamCannotSeek(){} // RVA: 0x7AE584650
        public void ThrowIfStreamCannotRead(){} // RVA: 0x7AE5846E0
        public void ThrowIfStreamCannotWrite(){} // RVA: 0x7AE584770
        public void ThrowIfStreamClosed(){} // RVA: 0x7AE584800
        public void IsStreamClosed(){} // RVA: 0x7AE584870
    }

}