// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data.Common
// Classes: 38
// Methods: 611

namespace ThirdParty.DotNet.System.Data.Common
{
    public class ADP : Object
    {
        // ── Methods ──
        public void TraceException(){} // RVA: 0x7FFE872D9CB0
        public void TraceExceptionAsReturnValue(){} // RVA: 0x7FFE872D9D40
        public void TraceExceptionWithoutRethrow(){} // RVA: 0x7FFE872D9E10
        public void Argument(){} // RVA: 0x7FFE872D9EE0
        public void ArgumentOutOfRange(){} // RVA: 0x7FFE872DA030 | overloaded x2
        public void InvalidOperation(){} // RVA: 0x7FFE872DA0D0
        public void NotSupported(){} // RVA: 0x7FFE872DA160
        public void IsCatchableExceptionType(){} // RVA: 0x7FFE872DA1F0
        public void IsCatchableOrSecurityExceptionType(){} // RVA: 0x7FFE872DA420
        public void InvalidEnumerationValue(){} // RVA: 0x7FFE872DA600
        public void InvalidSeekOrigin(){} // RVA: 0x7FFE872DA750
        public void InvalidAcceptRejectRule(){} // RVA: 0x7FFE872DA7C0
        public void InvalidMissingSchemaAction(){} // RVA: 0x7FFE872DA8B0
        public void InvalidRule(){} // RVA: 0x7FFE872DA9A0
        public void WrongType(){} // RVA: 0x7FFE872DAA90
        public void .cctor(){} // RVA: 0x7FFE872DABD0
    }

    public class BigIntegerStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872DB350
        public void Aggregate(){} // RVA: 0x7FFE872DB4F0
        public void Compare(){} // RVA: 0x7FFE872DB530
        public void CompareValueTo(){} // RVA: 0x7FFE872DB660
        public void ConvertToBigInteger(){} // RVA: 0x7FFE872DB7C0
        public void ConvertFromBigInteger(){} // RVA: 0x7FFE872DBF60
        public void ConvertValue(){} // RVA: 0x7FFE872DC820
        public void Copy(){} // RVA: 0x7FFE872DC8C0
        public void Get(){} // RVA: 0x7FFE872DC9C0
        public void Set(){} // RVA: 0x7FFE872DCAB0
        public void SetCapacity(){} // RVA: 0x7FFE872DCCC0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872DCDE0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872DCF30
        public void GetEmptyStorage(){} // RVA: 0x7FFE872DD120
        public void CopyValue(){} // RVA: 0x7FFE872DD160
        public void SetStorage(){} // RVA: 0x7FFE872DD2D0
    }

    public class BooleanStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872DD430
        public void Aggregate(){} // RVA: 0x7FFE872DD5F0
        public void Compare(){} // RVA: 0x7FFE872DD8D0
        public void CompareValueTo(){} // RVA: 0x7FFE872DD9C0
        public void ConvertValue(){} // RVA: 0x7FFE872DDB10
        public void Copy(){} // RVA: 0x7FFE872DDC20
        public void Get(){} // RVA: 0x7FFE872DDCB0
        public void Set(){} // RVA: 0x7FFE872DDD60
        public void SetCapacity(){} // RVA: 0x7FFE872DDEA0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872DDFC0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872DE040
        public void GetEmptyStorage(){} // RVA: 0x7FFE872DE110
        public void CopyValue(){} // RVA: 0x7FFE872DE150
        public void SetStorage(){} // RVA: 0x7FFE872DE270
    }

    public class ByteStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872DE3D0
        public void Aggregate(){} // RVA: 0x7FFE872DE590
        public void Compare(){} // RVA: 0x7FFE872DED10
        public void CompareValueTo(){} // RVA: 0x7FFE872DED80
        public void ConvertValue(){} // RVA: 0x7FFE872DEE90
        public void Copy(){} // RVA: 0x7FFE872DEFA0
        public void Get(){} // RVA: 0x7FFE872DF030
        public void Set(){} // RVA: 0x7FFE872DF0E0
        public void SetCapacity(){} // RVA: 0x7FFE872DF220
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872DF340
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872DF440
        public void GetEmptyStorage(){} // RVA: 0x7FFE872DF4D0
        public void CopyValue(){} // RVA: 0x7FFE872DF510
        public void SetStorage(){} // RVA: 0x7FFE872DF620
    }

    public class CharStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872DF780
        public void Aggregate(){} // RVA: 0x7FFE872DF950
        public void Compare(){} // RVA: 0x7FFE872DFC80
        public void CompareValueTo(){} // RVA: 0x7FFE872DFD50
        public void ConvertValue(){} // RVA: 0x7FFE872DFE70
        public void Copy(){} // RVA: 0x7FFE872DFF70
        public void Get(){} // RVA: 0x7FFE872E0000
        public void Set(){} // RVA: 0x7FFE872E00B0
        public void SetCapacity(){} // RVA: 0x7FFE872E0250
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872E0370
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872E04A0
        public void GetEmptyStorage(){} // RVA: 0x7FFE872E0530
        public void CopyValue(){} // RVA: 0x7FFE872E0570
        public void SetStorage(){} // RVA: 0x7FFE872E0680
    }

    public class DataStorage : Object
    {
        public System.Type[] s_storageClassType;
        public System.Data.DataColumn _column; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872E08C0 | overloaded x3
        public void get_DateTimeMode(){} // RVA: 0x7FFE872E0BA0
        public void get_FormatProvider(){} // RVA: 0x7FFE872E0BC0
        public void Aggregate(){} // RVA: 0x7FFE872E0BE0
        public void AggregateCount(){} // RVA: 0x7FFE872E0CB0
        public void CompareBits(){} // RVA: 0x7FFE872E0D60
        public void Compare(){} // RVA: 0x7FFE80E356E0
        public void CompareValueTo(){}
        public void ConvertValue(){} // RVA: 0x7FFE82153650
        public void CopyBits(){} // RVA: 0x7FFE872E0DE0
        public void Copy(){} // RVA: 0x7FFE80E484C0
        public void Get(){} // RVA: 0x7FFE80E3D230
        public void GetBits(){} // RVA: 0x7FFE872E0E30
        public void GetStringLength(){} // RVA: 0x7FFE86774820
        public void HasValue(){} // RVA: 0x7FFE872E0E70
        public void IsNull(){} // RVA: 0x7FFE872E0EA0
        public void Set(){} // RVA: 0x7FFE80E48220
        public void SetNullBit(){} // RVA: 0x7FFE872E0EC0
        public void SetCapacity(){} // RVA: 0x7FFE872E0EE0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872E0FB0 | overloaded x2
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872E1000 | overloaded x2
        public void CreateStorage(){} // RVA: 0x7FFE872E1050
        public void GetStorageType(){} // RVA: 0x7FFE872E3640
        public void GetTypeStorage(){} // RVA: 0x7FFE872E37C0
        public void IsTypeCustomType(){} // RVA: 0x7FFE872E38B0 | overloaded x2
        public void IsSqlType(){} // RVA: 0x7FFE872E38D0 | overloaded x2
        public void DetermineIfValueType(){} // RVA: 0x7FFE872E39E0
        public void ImplementsInterfaces(){} // RVA: 0x7FFE872E3A80
        public void InspectTypeForInterfaces(){} // RVA: 0x7FFE872E3C10
        public void ImplementsINullableValue(){} // RVA: 0x7FFE872E3F00
        public void IsObjectNull(){} // RVA: 0x7FFE872E3FD0
        public void IsObjectSqlNull(){} // RVA: 0x7FFE872E4070
        public void GetEmptyStorageInternal(){} // RVA: 0x7FFE872E40D0
        public void CopyValueInternal(){} // RVA: 0x7FFE872E40F0
        public void SetStorageInternal(){} // RVA: 0x7FFE872E4110
        public void GetEmptyStorage(){} // RVA: 0x7FFE80E3D230
        public void CopyValue(){}
        public void SetStorage(){} // RVA: 0x7FFE80E4F230
        public void SetNullStorage(){} // RVA: 0x7FFE81129890
        public void GetType(){} // RVA: 0x7FFE872E4130
        public void GetQualifiedName(){} // RVA: 0x7FFE872E4270
        public void .cctor(){} // RVA: 0x7FFE872E42E0
    }

    public class DateTimeOffsetStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872E5FB0
        public void Aggregate(){} // RVA: 0x7FFE872E6130
        public void Compare(){} // RVA: 0x7FFE872E65D0
        public void CompareValueTo(){} // RVA: 0x7FFE872E67B0
        public void ConvertValue(){} // RVA: 0x7FFE872E6960
        public void Copy(){} // RVA: 0x7FFE872E69F0
        public void Get(){} // RVA: 0x7FFE872E6A80
        public void Set(){} // RVA: 0x7FFE872E6BD0
        public void SetCapacity(){} // RVA: 0x7FFE872E6D00
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872E6E20
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872E6F50
        public void GetEmptyStorage(){} // RVA: 0x7FFE872E6FF0
        public void CopyValue(){} // RVA: 0x7FFE872E7030
        public void SetStorage(){} // RVA: 0x7FFE872E7160
        public void .cctor(){} // RVA: 0x7FFE872E72C0
    }

    public class DateTimeStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872E7340
        public void Aggregate(){} // RVA: 0x7FFE872E74C0
        public void Compare(){} // RVA: 0x7FFE872E7910
        public void CompareValueTo(){} // RVA: 0x7FFE872E7AC0
        public void ConvertValue(){} // RVA: 0x7FFE872E7C40
        public void Copy(){} // RVA: 0x7FFE872E7D50
        public void Get(){} // RVA: 0x7FFE872E7DE0
        public void Set(){} // RVA: 0x7FFE872E7F30
        public void SetCapacity(){} // RVA: 0x7FFE872E83A0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872E84C0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872E8610
        public void GetEmptyStorage(){} // RVA: 0x7FFE872E87F0
        public void CopyValue(){} // RVA: 0x7FFE872E8830
        public void SetStorage(){} // RVA: 0x7FFE872E8990
        public void .cctor(){} // RVA: 0x7FFE872E8C50
    }

    public class DecimalStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872E8CD0
        public void Aggregate(){} // RVA: 0x7FFE872E8E40
        public void Compare(){} // RVA: 0x7FFE872E9970
        public void CompareValueTo(){} // RVA: 0x7FFE872E9BC0
        public void ConvertValue(){} // RVA: 0x7FFE872E9DE0
        public void Copy(){} // RVA: 0x7FFE872E69F0
        public void Get(){} // RVA: 0x7FFE872E9EF0
        public void Set(){} // RVA: 0x7FFE872E9F90
        public void SetCapacity(){} // RVA: 0x7FFE872EA100
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872EA220
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872EA300
        public void GetEmptyStorage(){} // RVA: 0x7FFE872EA470
        public void CopyValue(){} // RVA: 0x7FFE872EA4B0
        public void SetStorage(){} // RVA: 0x7FFE872EA5E0
    }

    public class DoubleStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872EA740
        public void Aggregate(){} // RVA: 0x7FFE872EA890
        public void Compare(){} // RVA: 0x7FFE872EAF70
        public void CompareValueTo(){} // RVA: 0x7FFE872EB080
        public void ConvertValue(){} // RVA: 0x7FFE872EB200
        public void Copy(){} // RVA: 0x7FFE872EB310
        public void Get(){} // RVA: 0x7FFE872EB3A0
        public void Set(){} // RVA: 0x7FFE872EB460
        public void SetCapacity(){} // RVA: 0x7FFE872EB5A0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872EB6C0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872EB740
        public void GetEmptyStorage(){} // RVA: 0x7FFE872EB7D0
        public void CopyValue(){} // RVA: 0x7FFE872EB810
        public void SetStorage(){} // RVA: 0x7FFE872EB940
    }

    public class Int16Storage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872EBAA0
        public void Aggregate(){} // RVA: 0x7FFE872EBC70
        public void Compare(){} // RVA: 0x7FFE872EC490
        public void CompareValueTo(){} // RVA: 0x7FFE872EC500
        public void ConvertValue(){} // RVA: 0x7FFE872EC5F0
        public void Copy(){} // RVA: 0x7FFE872DFF70
        public void Get(){} // RVA: 0x7FFE872EC700
        public void Set(){} // RVA: 0x7FFE872EC7B0
        public void SetCapacity(){} // RVA: 0x7FFE872EC8F0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872ECA10
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872ECB10
        public void GetEmptyStorage(){} // RVA: 0x7FFE872ECBA0
        public void CopyValue(){} // RVA: 0x7FFE872ECBE0
        public void SetStorage(){} // RVA: 0x7FFE872ECCF0
    }

    public class Int32Storage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872ECE50
        public void Aggregate(){} // RVA: 0x7FFE872ED020
        public void Compare(){} // RVA: 0x7FFE872ED800
        public void CompareValueTo(){} // RVA: 0x7FFE872ED880
        public void ConvertValue(){} // RVA: 0x7FFE872ED980
        public void Copy(){} // RVA: 0x7FFE872EDA90
        public void Get(){} // RVA: 0x7FFE872EDB20
        public void Set(){} // RVA: 0x7FFE872EDBD0
        public void SetCapacity(){} // RVA: 0x7FFE872EDD10
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872EDE30
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872EDEC0
        public void GetEmptyStorage(){} // RVA: 0x7FFE872EDF50
        public void CopyValue(){} // RVA: 0x7FFE872EDF90
        public void SetStorage(){} // RVA: 0x7FFE872EE0A0
    }

    public class Int64Storage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872EE200
        public void Aggregate(){} // RVA: 0x7FFE872EE3C0
        public void Compare(){} // RVA: 0x7FFE872EECB0
        public void CompareValueTo(){} // RVA: 0x7FFE872EED30
        public void ConvertValue(){} // RVA: 0x7FFE872EEE30
        public void Copy(){} // RVA: 0x7FFE872EEF40
        public void Get(){} // RVA: 0x7FFE872EEFD0
        public void Set(){} // RVA: 0x7FFE872EF080
        public void SetCapacity(){} // RVA: 0x7FFE872EF1C0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872EF2E0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872EF370
        public void GetEmptyStorage(){} // RVA: 0x7FFE872EF400
        public void CopyValue(){} // RVA: 0x7FFE872EF440
        public void SetStorage(){} // RVA: 0x7FFE872EF550
    }

    public class ObjectStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872D5610
        public void Aggregate(){} // RVA: 0x7FFE872D5870
        public void Compare(){} // RVA: 0x7FFE872D58B0
        public void CompareValueTo(){} // RVA: 0x7FFE872D59D0
        public void CompareTo(){} // RVA: 0x7FFE872D5B60
        public void CompareWithFamilies(){} // RVA: 0x7FFE872D5CA0
        public void Copy(){} // RVA: 0x7FFE872D6120
        public void Get(){} // RVA: 0x7FFE872D61A0
        public void GetFamily(){} // RVA: 0x7FFE872D61E0
        public void IsNull(){} // RVA: 0x7FFE872D6380
        public void Set(){} // RVA: 0x7FFE872D63B0
        public void SetCapacity(){} // RVA: 0x7FFE872D6E70
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872D7510 | overloaded x2
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872D82A0 | overloaded x2
        public void GetEmptyStorage(){} // RVA: 0x7FFE872D83E0
        public void CopyValue(){} // RVA: 0x7FFE872D8420
        public void SetStorage(){} // RVA: 0x7FFE872D86C0
        public void VerifyIDynamicMetaObjectProvider(){} // RVA: 0x7FFE872D89D0
        public void GetXmlSerializer(){} // RVA: 0x7FFE872D8BF0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE872D9760
    }

    public class SByteStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872EF6B0
        public void Aggregate(){} // RVA: 0x7FFE872EF870
        public void Compare(){} // RVA: 0x7FFE872F0000
        public void CompareValueTo(){} // RVA: 0x7FFE872F0070
        public void ConvertValue(){} // RVA: 0x7FFE872F0180
        public void Copy(){} // RVA: 0x7FFE872DEFA0
        public void Get(){} // RVA: 0x7FFE872F0290
        public void Set(){} // RVA: 0x7FFE872F0340
        public void SetCapacity(){} // RVA: 0x7FFE872F0480
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872F05A0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872F06A0
        public void GetEmptyStorage(){} // RVA: 0x7FFE872F0730
        public void CopyValue(){} // RVA: 0x7FFE872F0770
        public void SetStorage(){} // RVA: 0x7FFE872F0880
    }

    public class SingleStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8730F7F0
        public void Aggregate(){} // RVA: 0x7FFE8730F940
        public void Compare(){} // RVA: 0x7FFE87310040
        public void CompareValueTo(){} // RVA: 0x7FFE87310130
        public void ConvertValue(){} // RVA: 0x7FFE873102A0
        public void Copy(){} // RVA: 0x7FFE873103B0
        public void Get(){} // RVA: 0x7FFE87310440
        public void Set(){} // RVA: 0x7FFE87310500
        public void SetCapacity(){} // RVA: 0x7FFE87310640
        public void ConvertXmlToObject(){} // RVA: 0x7FFE87310760
        public void ConvertObjectToXml(){} // RVA: 0x7FFE873107E0
        public void GetEmptyStorage(){} // RVA: 0x7FFE87310870
        public void CopyValue(){} // RVA: 0x7FFE873108B0
        public void SetStorage(){} // RVA: 0x7FFE873109E0
    }

    public class SqlBinaryStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872F9460
        public void Aggregate(){} // RVA: 0x7FFE872F95F0
        public void Compare(){} // RVA: 0x7FFE872F97C0
        public void CompareValueTo(){} // RVA: 0x7FFE872F9860
        public void ConvertValue(){} // RVA: 0x7FFE872F9910
        public void Copy(){} // RVA: 0x7FFE872F9980
        public void Get(){} // RVA: 0x7FFE872F99C0
        public void IsNull(){} // RVA: 0x7FFE872F9A40
        public void Set(){} // RVA: 0x7FFE872F9AC0
        public void SetCapacity(){} // RVA: 0x7FFE872F9B00
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872F9C10
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872F9E00
        public void GetEmptyStorage(){} // RVA: 0x7FFE872F9FC0
        public void CopyValue(){} // RVA: 0x7FFE872FA000
        public void SetStorage(){} // RVA: 0x7FFE872FA120
    }

    public class SqlBooleanStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8730E880
        public void Aggregate(){} // RVA: 0x7FFE8730EA10
        public void Compare(){} // RVA: 0x7FFE8730EDC0
        public void CompareValueTo(){} // RVA: 0x7FFE8730EE60
        public void ConvertValue(){} // RVA: 0x7FFE8730EF10
        public void Copy(){} // RVA: 0x7FFE8730EF80
        public void Get(){} // RVA: 0x7FFE8730EFC0
        public void IsNull(){} // RVA: 0x7FFE8730F030
        public void Set(){} // RVA: 0x7FFE8730F0B0
        public void SetCapacity(){} // RVA: 0x7FFE8730F0F0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE8730F200
        public void ConvertObjectToXml(){} // RVA: 0x7FFE8730F3F0
        public void GetEmptyStorage(){} // RVA: 0x7FFE8730F5B0
        public void CopyValue(){} // RVA: 0x7FFE8730F5F0
        public void SetStorage(){} // RVA: 0x7FFE8730F700
    }

    public class SqlByteStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872FA210
        public void Aggregate(){} // RVA: 0x7FFE872FA3A0
        public void Compare(){} // RVA: 0x7FFE872FB670
        public void CompareValueTo(){} // RVA: 0x7FFE872FB710
        public void ConvertValue(){} // RVA: 0x7FFE872FB7C0
        public void Copy(){} // RVA: 0x7FFE872FB830
        public void Get(){} // RVA: 0x7FFE872FB870
        public void IsNull(){} // RVA: 0x7FFE872FB8F0
        public void Set(){} // RVA: 0x7FFE872FB970
        public void SetCapacity(){} // RVA: 0x7FFE872FB9C0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872FBAD0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872FBCC0
        public void GetEmptyStorage(){} // RVA: 0x7FFE872FBE80
        public void CopyValue(){} // RVA: 0x7FFE872FBEC0
        public void SetStorage(){} // RVA: 0x7FFE872FBFD0
    }

    public class SqlBytesStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872FC0C0
        public void Aggregate(){} // RVA: 0x7FFE872FC270
        public void Compare(){} // RVA: 0x7FFE813240E0
        public void CompareValueTo(){} // RVA: 0x7FFE813240E0
        public void Copy(){} // RVA: 0x7FFE872F9980
        public void Get(){} // RVA: 0x7FFE872FC420
        public void IsNull(){} // RVA: 0x7FFE872FC450
        public void Set(){} // RVA: 0x7FFE872FC490
        public void SetCapacity(){} // RVA: 0x7FFE872FC5A0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872FC6B0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872FC940
        public void GetEmptyStorage(){} // RVA: 0x7FFE872FCB00
        public void CopyValue(){} // RVA: 0x7FFE872FCB40
        public void SetStorage(){} // RVA: 0x7FFE872FCC60
    }

    public class SqlCharsStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872FCD50
        public void Aggregate(){} // RVA: 0x7FFE872FCF00
        public void Compare(){} // RVA: 0x7FFE813240E0
        public void CompareValueTo(){} // RVA: 0x7FFE813240E0
        public void Copy(){} // RVA: 0x7FFE872F9980
        public void Get(){} // RVA: 0x7FFE872FC420
        public void IsNull(){} // RVA: 0x7FFE872FC450
        public void Set(){} // RVA: 0x7FFE872FD0B0
        public void SetCapacity(){} // RVA: 0x7FFE872FD1C0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872FD2D0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872FD5C0
        public void GetEmptyStorage(){} // RVA: 0x7FFE872FD780
        public void CopyValue(){} // RVA: 0x7FFE872FD7C0
        public void SetStorage(){} // RVA: 0x7FFE872FD8E0
    }

    public class SqlConvert : Object
    {
        // ── Methods ──
        public void ConvertToSqlByte(){} // RVA: 0x7FFE872F09E0
        public void ConvertToSqlInt16(){} // RVA: 0x7FFE872F0BC0
        public void ConvertToSqlInt32(){} // RVA: 0x7FFE872F0F30
        public void ConvertToSqlInt64(){} // RVA: 0x7FFE872F1450
        public void ConvertToSqlDouble(){} // RVA: 0x7FFE872F1960
        public void ConvertToSqlDecimal(){} // RVA: 0x7FFE872F2560
        public void ConvertToSqlSingle(){} // RVA: 0x7FFE872F2E80
        public void ConvertToSqlMoney(){} // RVA: 0x7FFE872F3C30
        public void ConvertToSqlDateTime(){} // RVA: 0x7FFE872F4620
        public void ConvertToSqlBoolean(){} // RVA: 0x7FFE872F4880
        public void ConvertToSqlGuid(){} // RVA: 0x7FFE872F4A50
        public void ConvertToSqlBinary(){} // RVA: 0x7FFE872F4C90
        public void ConvertToSqlString(){} // RVA: 0x7FFE872F4E90
        public void ConvertToSqlChars(){} // RVA: 0x7FFE872F50B0
        public void ConvertToSqlBytes(){} // RVA: 0x7FFE872F5240
        public void ConvertStringToDateTimeOffset(){} // RVA: 0x7FFE872F53D0
        public void ChangeTypeForDefaultValue(){} // RVA: 0x7FFE872F54A0
        public void ChangeType2(){} // RVA: 0x7FFE872F56C0
        public void ChangeTypeForXML(){} // RVA: 0x7FFE872F7060
    }

    public class SqlDateTimeStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872FD9D0
        public void Aggregate(){} // RVA: 0x7FFE872FDB90
        public void Compare(){} // RVA: 0x7FFE872FE150
        public void CompareValueTo(){} // RVA: 0x7FFE872FE220
        public void ConvertValue(){} // RVA: 0x7FFE872FE2F0
        public void Copy(){} // RVA: 0x7FFE872FE380
        public void Get(){} // RVA: 0x7FFE872FE3D0
        public void IsNull(){} // RVA: 0x7FFE872FE460
        public void Set(){} // RVA: 0x7FFE872FE4E0
        public void SetCapacity(){} // RVA: 0x7FFE872FE540
        public void ConvertXmlToObject(){} // RVA: 0x7FFE872FE650
        public void ConvertObjectToXml(){} // RVA: 0x7FFE872FE860
        public void GetEmptyStorage(){} // RVA: 0x7FFE872FEA20
        public void CopyValue(){} // RVA: 0x7FFE872FEA60
        public void SetStorage(){} // RVA: 0x7FFE872FEBA0
    }

    public class SqlDecimalStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE872FEC90
        public void Aggregate(){} // RVA: 0x7FFE872FEE50
        public void Compare(){} // RVA: 0x7FFE873001C0
        public void CompareValueTo(){} // RVA: 0x7FFE87300290
        public void ConvertValue(){} // RVA: 0x7FFE87300360
        public void Copy(){} // RVA: 0x7FFE873003E0
        public void Get(){} // RVA: 0x7FFE87300430
        public void IsNull(){} // RVA: 0x7FFE873004B0
        public void Set(){} // RVA: 0x7FFE87300590
        public void SetCapacity(){} // RVA: 0x7FFE873005F0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE87300700
        public void ConvertObjectToXml(){} // RVA: 0x7FFE873008F0
        public void GetEmptyStorage(){} // RVA: 0x7FFE87300AB0
        public void CopyValue(){} // RVA: 0x7FFE87300AF0
        public void SetStorage(){} // RVA: 0x7FFE87300C20
    }

    public class SqlDoubleStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87300DA0
        public void Aggregate(){} // RVA: 0x7FFE87300F40
        public void Compare(){} // RVA: 0x7FFE87302230
        public void CompareValueTo(){} // RVA: 0x7FFE873022F0
        public void ConvertValue(){} // RVA: 0x7FFE873023B0
        public void Copy(){} // RVA: 0x7FFE87302430
        public void Get(){} // RVA: 0x7FFE87302480
        public void IsNull(){} // RVA: 0x7FFE87302500
        public void Set(){} // RVA: 0x7FFE87302580
        public void SetCapacity(){} // RVA: 0x7FFE873025E0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE873026F0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE873028F0
        public void GetEmptyStorage(){} // RVA: 0x7FFE87302AB0
        public void CopyValue(){} // RVA: 0x7FFE87302AF0
        public void SetStorage(){} // RVA: 0x7FFE87302C20
    }

    public class SqlGuidStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87302D10
        public void Aggregate(){} // RVA: 0x7FFE87302EA0
        public void Compare(){} // RVA: 0x7FFE87303070
        public void CompareValueTo(){} // RVA: 0x7FFE87303110
        public void ConvertValue(){} // RVA: 0x7FFE873031C0
        public void Copy(){} // RVA: 0x7FFE872F9980
        public void Get(){} // RVA: 0x7FFE87303230
        public void IsNull(){} // RVA: 0x7FFE873032B0
        public void Set(){} // RVA: 0x7FFE87303330
        public void SetCapacity(){} // RVA: 0x7FFE87303370
        public void ConvertXmlToObject(){} // RVA: 0x7FFE87303480
        public void ConvertObjectToXml(){} // RVA: 0x7FFE87303670
        public void GetEmptyStorage(){} // RVA: 0x7FFE87303830
        public void CopyValue(){} // RVA: 0x7FFE87303870
        public void SetStorage(){} // RVA: 0x7FFE87303990
    }

    public class SqlInt16Storage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87303A80
        public void Aggregate(){} // RVA: 0x7FFE87303C10
        public void Compare(){} // RVA: 0x7FFE87304E90
        public void CompareValueTo(){} // RVA: 0x7FFE87304F30
        public void ConvertValue(){} // RVA: 0x7FFE87304FE0
        public void Copy(){} // RVA: 0x7FFE87305050
        public void Get(){} // RVA: 0x7FFE87305090
        public void IsNull(){} // RVA: 0x7FFE87305100
        public void Set(){} // RVA: 0x7FFE87305180
        public void SetCapacity(){} // RVA: 0x7FFE873051C0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE873052D0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE873054C0
        public void GetEmptyStorage(){} // RVA: 0x7FFE87305680
        public void CopyValue(){} // RVA: 0x7FFE873056C0
        public void SetStorage(){} // RVA: 0x7FFE873057D0
    }

    public class SqlInt32Storage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE873058C0
        public void Aggregate(){} // RVA: 0x7FFE87305A50
        public void Compare(){} // RVA: 0x7FFE87306CD0
        public void CompareValueTo(){} // RVA: 0x7FFE87306D70
        public void ConvertValue(){} // RVA: 0x7FFE87306E20
        public void Copy(){} // RVA: 0x7FFE87306E90
        public void Get(){} // RVA: 0x7FFE87306ED0
        public void IsNull(){} // RVA: 0x7FFE87306F50
        public void Set(){} // RVA: 0x7FFE87306FD0
        public void SetCapacity(){} // RVA: 0x7FFE87307020
        public void ConvertXmlToObject(){} // RVA: 0x7FFE87307130
        public void ConvertObjectToXml(){} // RVA: 0x7FFE87307320
        public void GetEmptyStorage(){} // RVA: 0x7FFE873074E0
        public void CopyValue(){} // RVA: 0x7FFE87307520
        public void SetStorage(){} // RVA: 0x7FFE87307630
    }

    public class SqlInt64Storage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87307720
        public void Aggregate(){} // RVA: 0x7FFE873078C0
        public void Compare(){} // RVA: 0x7FFE87308BE0
        public void CompareValueTo(){} // RVA: 0x7FFE87308CA0
        public void ConvertValue(){} // RVA: 0x7FFE87308D60
        public void Copy(){} // RVA: 0x7FFE87302430
        public void Get(){} // RVA: 0x7FFE87308DE0
        public void IsNull(){} // RVA: 0x7FFE87308E60
        public void Set(){} // RVA: 0x7FFE87308EE0
        public void SetCapacity(){} // RVA: 0x7FFE87308F40
        public void ConvertXmlToObject(){} // RVA: 0x7FFE87309050
        public void ConvertObjectToXml(){} // RVA: 0x7FFE87309250
        public void GetEmptyStorage(){} // RVA: 0x7FFE87309410
        public void CopyValue(){} // RVA: 0x7FFE87309450
        public void SetStorage(){} // RVA: 0x7FFE87309580
    }

    public class SqlMoneyStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87309670
        public void Aggregate(){} // RVA: 0x7FFE87309810
        public void Compare(){} // RVA: 0x7FFE8730AB80
        public void CompareValueTo(){} // RVA: 0x7FFE8730AC40
        public void ConvertValue(){} // RVA: 0x7FFE8730AD00
        public void Copy(){} // RVA: 0x7FFE87302430
        public void Get(){} // RVA: 0x7FFE8730AD80
        public void IsNull(){} // RVA: 0x7FFE8730AE00
        public void Set(){} // RVA: 0x7FFE8730AE80
        public void SetCapacity(){} // RVA: 0x7FFE8730AEE0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE8730AFF0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE8730B1F0
        public void GetEmptyStorage(){} // RVA: 0x7FFE8730B3B0
        public void CopyValue(){} // RVA: 0x7FFE8730B3F0
        public void SetStorage(){} // RVA: 0x7FFE8730B520
    }

    public class SqlSingleStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8730B610
        public void Aggregate(){} // RVA: 0x7FFE8730B7A0
        public void Compare(){} // RVA: 0x7FFE8730CAE0
        public void CompareValueTo(){} // RVA: 0x7FFE8730CB80
        public void ConvertValue(){} // RVA: 0x7FFE8730CC30
        public void Copy(){} // RVA: 0x7FFE87306E90
        public void Get(){} // RVA: 0x7FFE8730CCA0
        public void IsNull(){} // RVA: 0x7FFE8730CD20
        public void Set(){} // RVA: 0x7FFE8730CDA0
        public void SetCapacity(){} // RVA: 0x7FFE8730CDF0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE8730CF00
        public void ConvertObjectToXml(){} // RVA: 0x7FFE8730D0F0
        public void GetEmptyStorage(){} // RVA: 0x7FFE8730D2B0
        public void CopyValue(){} // RVA: 0x7FFE8730D2F0
        public void SetStorage(){} // RVA: 0x7FFE8730D400
    }

    public class SqlStringStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8730D4F0
        public void Aggregate(){} // RVA: 0x7FFE8730D6A0
        public void Compare(){} // RVA: 0x7FFE8730DAA0 | overloaded x2
        public void CompareValueTo(){} // RVA: 0x7FFE8730DBF0
        public void ConvertValue(){} // RVA: 0x7FFE8730DCC0
        public void Copy(){} // RVA: 0x7FFE8730DD50
        public void Get(){} // RVA: 0x7FFE8730DE10
        public void GetStringLength(){} // RVA: 0x7FFE8730DEA0
        public void IsNull(){} // RVA: 0x7FFE8730DFB0
        public void Set(){} // RVA: 0x7FFE8730E030
        public void SetCapacity(){} // RVA: 0x7FFE8730E0F0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE8730E200
        public void ConvertObjectToXml(){} // RVA: 0x7FFE8730E3F0
        public void GetEmptyStorage(){} // RVA: 0x7FFE8730E5B0
        public void CopyValue(){} // RVA: 0x7FFE8730E5F0
        public void SetStorage(){} // RVA: 0x7FFE8730E790
    }

    public class SqlUdtStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87310BD0 | overloaded x2
        public void GetStaticNullForUdtType(){} // RVA: 0x7FFE87310E50
        public void IsNull(){} // RVA: 0x7FFE87310FC0
        public void Aggregate(){} // RVA: 0x7FFE87311080
        public void Compare(){} // RVA: 0x7FFE873110C0
        public void CompareValueTo(){} // RVA: 0x7FFE87311100
        public void Copy(){} // RVA: 0x7FFE87311310
        public void Get(){} // RVA: 0x7FFE872FC420
        public void Set(){} // RVA: 0x7FFE873113C0
        public void SetCapacity(){} // RVA: 0x7FFE873115C0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE87311940 | overloaded x2
        public void ConvertObjectToXml(){} // RVA: 0x7FFE87311E00 | overloaded x2
        public void GetEmptyStorage(){} // RVA: 0x7FFE87311F20
        public void CopyValue(){} // RVA: 0x7FFE87311F60
        public void SetStorage(){} // RVA: 0x7FFE873120D0
        public void .cctor(){} // RVA: 0x7FFE873121C0
    }

    public class StringStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87312420
        public void Aggregate(){} // RVA: 0x7FFE87312560
        public void Compare(){} // RVA: 0x7FFE87312820
        public void CompareValueTo(){} // RVA: 0x7FFE873128B0
        public void ConvertValue(){} // RVA: 0x7FFE873129A0
        public void Copy(){} // RVA: 0x7FFE872F9980
        public void Get(){} // RVA: 0x7FFE872D61A0
        public void GetStringLength(){} // RVA: 0x7FFE873129D0
        public void IsNull(){} // RVA: 0x7FFE872D6380
        public void Set(){} // RVA: 0x7FFE87312A10
        public void SetCapacity(){} // RVA: 0x7FFE87312A90
        public void ConvertXmlToObject(){} // RVA: 0x7FFE82153650
        public void ConvertObjectToXml(){} // RVA: 0x7FFE87312BA0
        public void GetEmptyStorage(){} // RVA: 0x7FFE87312C00
        public void CopyValue(){} // RVA: 0x7FFE87312C40
        public void SetStorage(){} // RVA: 0x7FFE87312D60
    }

    public class TimeSpanStorage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87312E50
        public void Aggregate(){} // RVA: 0x7FFE87312FD0
        public void Compare(){} // RVA: 0x7FFE87313D50
        public void CompareValueTo(){} // RVA: 0x7FFE87313EC0
        public void ConvertToTimeSpan(){} // RVA: 0x7FFE87314050
        public void ConvertValue(){} // RVA: 0x7FFE87314330
        public void Copy(){} // RVA: 0x7FFE872E7D50
        public void Get(){} // RVA: 0x7FFE873143E0
        public void Set(){} // RVA: 0x7FFE87314500
        public void SetCapacity(){} // RVA: 0x7FFE87314600
        public void ConvertXmlToObject(){} // RVA: 0x7FFE87314720
        public void ConvertObjectToXml(){} // RVA: 0x7FFE873147A0
        public void GetEmptyStorage(){} // RVA: 0x7FFE87314880
        public void CopyValue(){} // RVA: 0x7FFE873148C0
        public void SetStorage(){} // RVA: 0x7FFE873149D0
        public void .cctor(){} // RVA: 0x7FFE87314B30
    }

    public class UInt16Storage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87314BB0
        public void Aggregate(){} // RVA: 0x7FFE87314D20
        public void Compare(){} // RVA: 0x7FFE87315550
        public void CompareValueTo(){} // RVA: 0x7FFE87315610
        public void ConvertValue(){} // RVA: 0x7FFE87315720
        public void Copy(){} // RVA: 0x7FFE872DFF70
        public void Get(){} // RVA: 0x7FFE87315830
        public void Set(){} // RVA: 0x7FFE87315900
        public void SetCapacity(){} // RVA: 0x7FFE87315A60
        public void ConvertXmlToObject(){} // RVA: 0x7FFE87315B80
        public void ConvertObjectToXml(){} // RVA: 0x7FFE87315C80
        public void GetEmptyStorage(){} // RVA: 0x7FFE87315D10
        public void CopyValue(){} // RVA: 0x7FFE87315D50
        public void SetStorage(){} // RVA: 0x7FFE87315E60
    }

    public class UInt32Storage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87315FC0
        public void Aggregate(){} // RVA: 0x7FFE87316120
        public void Compare(){} // RVA: 0x7FFE87316940
        public void CompareValueTo(){} // RVA: 0x7FFE87316A10
        public void ConvertValue(){} // RVA: 0x7FFE87316B30
        public void Copy(){} // RVA: 0x7FFE872EDA90
        public void Get(){} // RVA: 0x7FFE87316C40
        public void Set(){} // RVA: 0x7FFE87316D10
        public void SetCapacity(){} // RVA: 0x7FFE87316E70
        public void ConvertXmlToObject(){} // RVA: 0x7FFE87316F90
        public void ConvertObjectToXml(){} // RVA: 0x7FFE87317020
        public void GetEmptyStorage(){} // RVA: 0x7FFE873170B0
        public void CopyValue(){} // RVA: 0x7FFE873170F0
        public void SetStorage(){} // RVA: 0x7FFE87317200
    }

    public class UInt64Storage : DataStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87317360
        public void Aggregate(){} // RVA: 0x7FFE873174D0
        public void Compare(){} // RVA: 0x7FFE87317E70
        public void CompareValueTo(){} // RVA: 0x7FFE87317F40
        public void ConvertValue(){} // RVA: 0x7FFE87318060
        public void Copy(){} // RVA: 0x7FFE872EEF40
        public void Get(){} // RVA: 0x7FFE87318170
        public void Set(){} // RVA: 0x7FFE87318240
        public void SetCapacity(){} // RVA: 0x7FFE873183A0
        public void ConvertXmlToObject(){} // RVA: 0x7FFE873184C0
        public void ConvertObjectToXml(){} // RVA: 0x7FFE87318550
        public void GetEmptyStorage(){} // RVA: 0x7FFE873185E0
        public void CopyValue(){} // RVA: 0x7FFE87318620
        public void SetStorage(){} // RVA: 0x7FFE87318730
    }

}