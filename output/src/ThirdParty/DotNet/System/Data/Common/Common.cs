// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data.Common
// Classes: 38
// Methods: 611

namespace ThirdParty.DotNet.System.Data.Common
{
    public class ADP : Object
    {
        public System.Type s_stackOverflowType;
        public System.Type s_outOfMemoryType; // 0x8
        public System.Type s_threadAbortType; // 0x10
        public System.Type s_nullReferenceType; // 0x18
        public System.Type s_accessViolationType; // 0x20
        public System.Type s_securityType; // 0x28
        public string StrEmpty; // 0x30
        public string[] AzureSqlServerEndpoints; // 0x38
        public UIntPtr PtrZero; // 0x40
        public int PtrSize; // 0x48

        // ── Methods ──
        public void TraceException(){} // RVA: 0x7FFAC8F31860
        public void TraceExceptionAsReturnValue(){} // RVA: 0x7FFAC8F318F0
        public void TraceExceptionWithoutRethrow(){} // RVA: 0x7FFAC8F319C0
        public void Argument(){} // RVA: 0x7FFAC8F31A90
        public void ArgumentOutOfRange(){} // RVA: 0x7FFAC8F31BE0 | overloaded x2
        public void InvalidOperation(){} // RVA: 0x7FFAC8F31C80
        public void NotSupported(){} // RVA: 0x7FFAC8F31D10
        public void IsCatchableExceptionType(){} // RVA: 0x7FFAC8F31DA0
        public void IsCatchableOrSecurityExceptionType(){} // RVA: 0x7FFAC8F31FD0
        public void InvalidEnumerationValue(){} // RVA: 0x7FFAC8F321B0
        public void InvalidSeekOrigin(){} // RVA: 0x7FFAC8F32300
        public void InvalidAcceptRejectRule(){} // RVA: 0x7FFAC8F32370
        public void InvalidMissingSchemaAction(){} // RVA: 0x7FFAC8F32460
        public void InvalidRule(){} // RVA: 0x7FFAC8F32550
        public void WrongType(){} // RVA: 0x7FFAC8F32640
        public void .cctor(){} // RVA: 0x7FFAC8F32780
    }

    public class BigIntegerStorage : DataStorage
    {
        public System.Numerics.BigInteger[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F32F00
        public void Aggregate(){} // RVA: 0x7FFAC8F330A0
        public void Compare(){} // RVA: 0x7FFAC8F330E0
        public void CompareValueTo(){} // RVA: 0x7FFAC8F33210
        public void ConvertToBigInteger(){} // RVA: 0x7FFAC8F33370
        public void ConvertFromBigInteger(){} // RVA: 0x7FFAC8F33B10
        public void ConvertValue(){} // RVA: 0x7FFAC8F343D0
        public void Copy(){} // RVA: 0x7FFAC8F34470
        public void Get(){} // RVA: 0x7FFAC8F34570
        public void Set(){} // RVA: 0x7FFAC8F34660
        public void SetCapacity(){} // RVA: 0x7FFAC8F34870
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F34990
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F34AE0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F34CD0
        public void CopyValue(){} // RVA: 0x7FFAC8F34D10
        public void SetStorage(){} // RVA: 0x7FFAC8F34E80
    }

    public class BooleanStorage : DataStorage
    {
        public bool[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F34FE0
        public void Aggregate(){} // RVA: 0x7FFAC8F351A0
        public void Compare(){} // RVA: 0x7FFAC8F35480
        public void CompareValueTo(){} // RVA: 0x7FFAC8F35570
        public void ConvertValue(){} // RVA: 0x7FFAC8F356C0
        public void Copy(){} // RVA: 0x7FFAC8F357D0
        public void Get(){} // RVA: 0x7FFAC8F35860
        public void Set(){} // RVA: 0x7FFAC8F35910
        public void SetCapacity(){} // RVA: 0x7FFAC8F35A50
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F35B70
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F35BF0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F35CC0
        public void CopyValue(){} // RVA: 0x7FFAC8F35D00
        public void SetStorage(){} // RVA: 0x7FFAC8F35E20
    }

    public class ByteStorage : DataStorage
    {
        public byte[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F35F80
        public void Aggregate(){} // RVA: 0x7FFAC8F36140
        public void Compare(){} // RVA: 0x7FFAC8F368C0
        public void CompareValueTo(){} // RVA: 0x7FFAC8F36930
        public void ConvertValue(){} // RVA: 0x7FFAC8F36A40
        public void Copy(){} // RVA: 0x7FFAC8F36B50
        public void Get(){} // RVA: 0x7FFAC8F36BE0
        public void Set(){} // RVA: 0x7FFAC8F36C90
        public void SetCapacity(){} // RVA: 0x7FFAC8F36DD0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F36EF0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F36FF0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F37080
        public void CopyValue(){} // RVA: 0x7FFAC8F370C0
        public void SetStorage(){} // RVA: 0x7FFAC8F371D0
    }

    public class CharStorage : DataStorage
    {
        public char[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F37330
        public void Aggregate(){} // RVA: 0x7FFAC8F37500
        public void Compare(){} // RVA: 0x7FFAC8F37830
        public void CompareValueTo(){} // RVA: 0x7FFAC8F37900
        public void ConvertValue(){} // RVA: 0x7FFAC8F37A20
        public void Copy(){} // RVA: 0x7FFAC8F37B20
        public void Get(){} // RVA: 0x7FFAC8F37BB0
        public void Set(){} // RVA: 0x7FFAC8F37C60
        public void SetCapacity(){} // RVA: 0x7FFAC8F37E00
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F37F20
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F38050
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F380E0
        public void CopyValue(){} // RVA: 0x7FFAC8F38120
        public void SetStorage(){} // RVA: 0x7FFAC8F38230
    }

    public class DataStorage : Object
    {
        public System.Type[] DateTimeMode;
        public System.Data.DataColumn FormatProvider; // 0x10
        public System.Data.DataTable _table; // 0x18
        public System.Type _dataType; // 0x20
        public 0x6B1D1B00 _storageTypeCode; // 0x28
        public System.Collections.BitArray _dbNullBits; // 0x30
        public object _defaultValue; // 0x38
        public object _nullValue; // 0x40
        public bool _isCloneable; // 0x48
        public bool _isCustomDefinedType; // 0x49
        public bool _isStringType; // 0x4A
        public bool _isValueType; // 0x4B
        public System.Func`2<System.Type,System.Tuple`4<bool,bool,bool,bool>> s_inspectTypeForInterfaces; // 0x8
        public System.Collections.Concurrent.ConcurrentDictionary`2<System.Type,System.Tuple`4<bool,bool,bool,bool>> s_typeImplementsInterface; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F38470 | overloaded x3
        public void get_DateTimeMode(){} // RVA: 0x7FFAC8F38750
        public void get_FormatProvider(){} // RVA: 0x7FFAC8F38770
        public void Aggregate(){} // RVA: 0x7FFAC8F38790
        public void AggregateCount(){} // RVA: 0x7FFAC8F38860
        public void CompareBits(){} // RVA: 0x7FFAC8F38910
        public void Compare(){} // RVA: 0x7FFAC2C60290
        public void CompareValueTo(){}
        public void ConvertValue(){} // RVA: 0x7FFAC3E92FB0
        public void CopyBits(){} // RVA: 0x7FFAC8F38990
        public void Copy(){} // RVA: 0x7FFAC2C72E60
        public void Get(){} // RVA: 0x7FFAC2C67DE0
        public void GetBits(){} // RVA: 0x7FFAC8F389E0
        public void GetStringLength(){} // RVA: 0x7FFAC83CAF20
        public void HasValue(){} // RVA: 0x7FFAC8F38A20
        public void IsNull(){} // RVA: 0x7FFAC8F38A50
        public void Set(){} // RVA: 0x7FFAC2C72BC0
        public void SetNullBit(){} // RVA: 0x7FFAC8F38A70
        public void SetCapacity(){} // RVA: 0x7FFAC8F38A90
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F38B60 | overloaded x2
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F38BB0 | overloaded x2
        public void CreateStorage(){} // RVA: 0x7FFAC8F38C00
        public void GetStorageType(){} // RVA: 0x7FFAC8F3B1F0
        public void GetTypeStorage(){} // RVA: 0x7FFAC8F3B370
        public void IsTypeCustomType(){} // RVA: 0x7FFAC8F3B460 | overloaded x2
        public void IsSqlType(){} // RVA: 0x7FFAC8F3B480 | overloaded x2
        public void DetermineIfValueType(){} // RVA: 0x7FFAC8F3B590
        public void ImplementsInterfaces(){} // RVA: 0x7FFAC8F3B630
        public void InspectTypeForInterfaces(){} // RVA: 0x7FFAC8F3B7C0
        public void ImplementsINullableValue(){} // RVA: 0x7FFAC8F3BAB0
        public void IsObjectNull(){} // RVA: 0x7FFAC8F3BB80
        public void IsObjectSqlNull(){} // RVA: 0x7FFAC8F3BC20
        public void GetEmptyStorageInternal(){} // RVA: 0x7FFAC8F3BC80
        public void CopyValueInternal(){} // RVA: 0x7FFAC8F3BCA0
        public void SetStorageInternal(){} // RVA: 0x7FFAC8F3BCC0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC2C67DE0
        public void CopyValue(){}
        public void SetStorage(){} // RVA: 0x7FFAC2C79B30
        public void SetNullStorage(){} // RVA: 0x7FFAC2F4F890
        public void GetType(){} // RVA: 0x7FFAC8F3BCE0
        public void GetQualifiedName(){} // RVA: 0x7FFAC8F3BE20
        public void .cctor(){} // RVA: 0x7FFAC8F3BE90
    }

    public class DateTimeOffsetStorage : DataStorage
    {
        public System.DateTimeOffset s_defaultValue;
        public System.DateTimeOffset[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F3DB60
        public void Aggregate(){} // RVA: 0x7FFAC8F3DCE0
        public void Compare(){} // RVA: 0x7FFAC8F3E180
        public void CompareValueTo(){} // RVA: 0x7FFAC8F3E360
        public void ConvertValue(){} // RVA: 0x7FFAC8F3E510
        public void Copy(){} // RVA: 0x7FFAC8F3E5A0
        public void Get(){} // RVA: 0x7FFAC8F3E630
        public void Set(){} // RVA: 0x7FFAC8F3E780
        public void SetCapacity(){} // RVA: 0x7FFAC8F3E8B0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F3E9D0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F3EB00
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F3EBA0
        public void CopyValue(){} // RVA: 0x7FFAC8F3EBE0
        public void SetStorage(){} // RVA: 0x7FFAC8F3ED10
        public void .cctor(){} // RVA: 0x7FFAC8F3EE70
    }

    public class DateTimeStorage : DataStorage
    {
        public System.DateTime s_defaultValue;
        public System.DateTime[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F3EEF0
        public void Aggregate(){} // RVA: 0x7FFAC8F3F070
        public void Compare(){} // RVA: 0x7FFAC8F3F4C0
        public void CompareValueTo(){} // RVA: 0x7FFAC8F3F670
        public void ConvertValue(){} // RVA: 0x7FFAC8F3F7F0
        public void Copy(){} // RVA: 0x7FFAC8F3F900
        public void Get(){} // RVA: 0x7FFAC8F3F990
        public void Set(){} // RVA: 0x7FFAC8F3FAE0
        public void SetCapacity(){} // RVA: 0x7FFAC8F3FF50
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F40070
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F401C0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F403A0
        public void CopyValue(){} // RVA: 0x7FFAC8F403E0
        public void SetStorage(){} // RVA: 0x7FFAC8F40540
        public void .cctor(){} // RVA: 0x7FFAC8F40800
    }

    public class DecimalStorage : DataStorage
    {
        public System.Decimal s_defaultValue;
        public System.Decimal[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F40880
        public void Aggregate(){} // RVA: 0x7FFAC8F409F0
        public void Compare(){} // RVA: 0x7FFAC8F41520
        public void CompareValueTo(){} // RVA: 0x7FFAC8F41770
        public void ConvertValue(){} // RVA: 0x7FFAC8F41990
        public void Copy(){} // RVA: 0x7FFAC8F3E5A0
        public void Get(){} // RVA: 0x7FFAC8F41AA0
        public void Set(){} // RVA: 0x7FFAC8F41B40
        public void SetCapacity(){} // RVA: 0x7FFAC8F41CB0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F41DD0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F41EB0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F42020
        public void CopyValue(){} // RVA: 0x7FFAC8F42060
        public void SetStorage(){} // RVA: 0x7FFAC8F42190
    }

    public class DoubleStorage : DataStorage
    {
        public double[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F422F0
        public void Aggregate(){} // RVA: 0x7FFAC8F42440
        public void Compare(){} // RVA: 0x7FFAC8F42B20
        public void CompareValueTo(){} // RVA: 0x7FFAC8F42C30
        public void ConvertValue(){} // RVA: 0x7FFAC8F42DB0
        public void Copy(){} // RVA: 0x7FFAC8F42EC0
        public void Get(){} // RVA: 0x7FFAC8F42F50
        public void Set(){} // RVA: 0x7FFAC8F43010
        public void SetCapacity(){} // RVA: 0x7FFAC8F43150
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F43270
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F432F0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F43380
        public void CopyValue(){} // RVA: 0x7FFAC8F433C0
        public void SetStorage(){} // RVA: 0x7FFAC8F434F0
    }

    public class Int16Storage : DataStorage
    {
        public short[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F43650
        public void Aggregate(){} // RVA: 0x7FFAC8F43820
        public void Compare(){} // RVA: 0x7FFAC8F44040
        public void CompareValueTo(){} // RVA: 0x7FFAC8F440B0
        public void ConvertValue(){} // RVA: 0x7FFAC8F441A0
        public void Copy(){} // RVA: 0x7FFAC8F37B20
        public void Get(){} // RVA: 0x7FFAC8F442B0
        public void Set(){} // RVA: 0x7FFAC8F44360
        public void SetCapacity(){} // RVA: 0x7FFAC8F444A0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F445C0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F446C0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F44750
        public void CopyValue(){} // RVA: 0x7FFAC8F44790
        public void SetStorage(){} // RVA: 0x7FFAC8F448A0
    }

    public class Int32Storage : DataStorage
    {
        public int[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F44A00
        public void Aggregate(){} // RVA: 0x7FFAC8F44BD0
        public void Compare(){} // RVA: 0x7FFAC8F453B0
        public void CompareValueTo(){} // RVA: 0x7FFAC8F45430
        public void ConvertValue(){} // RVA: 0x7FFAC8F45530
        public void Copy(){} // RVA: 0x7FFAC8F45640
        public void Get(){} // RVA: 0x7FFAC8F456D0
        public void Set(){} // RVA: 0x7FFAC8F45780
        public void SetCapacity(){} // RVA: 0x7FFAC8F458C0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F459E0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F45A70
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F45B00
        public void CopyValue(){} // RVA: 0x7FFAC8F45B40
        public void SetStorage(){} // RVA: 0x7FFAC8F45C50
    }

    public class Int64Storage : DataStorage
    {
        public long[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F45DB0
        public void Aggregate(){} // RVA: 0x7FFAC8F45F70
        public void Compare(){} // RVA: 0x7FFAC8F46860
        public void CompareValueTo(){} // RVA: 0x7FFAC8F468E0
        public void ConvertValue(){} // RVA: 0x7FFAC8F469E0
        public void Copy(){} // RVA: 0x7FFAC8F46AF0
        public void Get(){} // RVA: 0x7FFAC8F46B80
        public void Set(){} // RVA: 0x7FFAC8F46C30
        public void SetCapacity(){} // RVA: 0x7FFAC8F46D70
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F46E90
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F46F20
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F46FB0
        public void CopyValue(){} // RVA: 0x7FFAC8F46FF0
        public void SetStorage(){} // RVA: 0x7FFAC8F47100
    }

    public class ObjectStorage : DataStorage
    {
        public object s_defaultValue;
        public object[] _values; // 0x50
        public bool _implementsIXmlSerializable; // 0x58
        public object s_tempAssemblyCacheLock; // 0x8
        public System.Collections.Generic.Dictionary`2<System.Collections.Generic.KeyValuePair`2<System.Type,System.Xml.Serialization.XmlRootAttribute>,System.Xml.Serialization.XmlSerializer> s_tempAssemblyCache; // 0x10
        public System.Xml.Serialization.XmlSerializerFactory s_serializerFactory; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F2D1C0
        public void Aggregate(){} // RVA: 0x7FFAC8F2D420
        public void Compare(){} // RVA: 0x7FFAC8F2D460
        public void CompareValueTo(){} // RVA: 0x7FFAC8F2D580
        public void CompareTo(){} // RVA: 0x7FFAC8F2D710
        public void CompareWithFamilies(){} // RVA: 0x7FFAC8F2D850
        public void Copy(){} // RVA: 0x7FFAC8F2DCD0
        public void Get(){} // RVA: 0x7FFAC8F2DD50
        public void GetFamily(){} // RVA: 0x7FFAC8F2DD90
        public void IsNull(){} // RVA: 0x7FFAC8F2DF30
        public void Set(){} // RVA: 0x7FFAC8F2DF60
        public void SetCapacity(){} // RVA: 0x7FFAC8F2EA20
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F2F0C0 | overloaded x2
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F2FE50 | overloaded x2
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F2FF90
        public void CopyValue(){} // RVA: 0x7FFAC8F2FFD0
        public void SetStorage(){} // RVA: 0x7FFAC8F30270
        public void VerifyIDynamicMetaObjectProvider(){} // RVA: 0x7FFAC8F30580
        public void GetXmlSerializer(){} // RVA: 0x7FFAC8F307A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC8F31310
    }

    public class SByteStorage : DataStorage
    {
        public sbyte[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F47260
        public void Aggregate(){} // RVA: 0x7FFAC8F47420
        public void Compare(){} // RVA: 0x7FFAC8F47BB0
        public void CompareValueTo(){} // RVA: 0x7FFAC8F47C20
        public void ConvertValue(){} // RVA: 0x7FFAC8F47D30
        public void Copy(){} // RVA: 0x7FFAC8F36B50
        public void Get(){} // RVA: 0x7FFAC8F47E40
        public void Set(){} // RVA: 0x7FFAC8F47EF0
        public void SetCapacity(){} // RVA: 0x7FFAC8F48030
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F48150
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F48250
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F482E0
        public void CopyValue(){} // RVA: 0x7FFAC8F48320
        public void SetStorage(){} // RVA: 0x7FFAC8F48430
    }

    public class SingleStorage : DataStorage
    {
        public float[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F673A0
        public void Aggregate(){} // RVA: 0x7FFAC8F674F0
        public void Compare(){} // RVA: 0x7FFAC8F67BF0
        public void CompareValueTo(){} // RVA: 0x7FFAC8F67CE0
        public void ConvertValue(){} // RVA: 0x7FFAC8F67E50
        public void Copy(){} // RVA: 0x7FFAC8F67F60
        public void Get(){} // RVA: 0x7FFAC8F67FF0
        public void Set(){} // RVA: 0x7FFAC8F680B0
        public void SetCapacity(){} // RVA: 0x7FFAC8F681F0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F68310
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F68390
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F68420
        public void CopyValue(){} // RVA: 0x7FFAC8F68460
        public void SetStorage(){} // RVA: 0x7FFAC8F68590
    }

    public class SqlBinaryStorage : DataStorage
    {
        public System.Data.SqlTypes.SqlBinary[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F51010
        public void Aggregate(){} // RVA: 0x7FFAC8F511A0
        public void Compare(){} // RVA: 0x7FFAC8F51370
        public void CompareValueTo(){} // RVA: 0x7FFAC8F51410
        public void ConvertValue(){} // RVA: 0x7FFAC8F514C0
        public void Copy(){} // RVA: 0x7FFAC8F51530
        public void Get(){} // RVA: 0x7FFAC8F51570
        public void IsNull(){} // RVA: 0x7FFAC8F515F0
        public void Set(){} // RVA: 0x7FFAC8F51670
        public void SetCapacity(){} // RVA: 0x7FFAC8F516B0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F517C0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F519B0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F51B70
        public void CopyValue(){} // RVA: 0x7FFAC8F51BB0
        public void SetStorage(){} // RVA: 0x7FFAC8F51CD0
    }

    public class SqlBooleanStorage : DataStorage
    {
        public System.Data.SqlTypes.SqlBoolean[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F66430
        public void Aggregate(){} // RVA: 0x7FFAC8F665C0
        public void Compare(){} // RVA: 0x7FFAC8F66970
        public void CompareValueTo(){} // RVA: 0x7FFAC8F66A10
        public void ConvertValue(){} // RVA: 0x7FFAC8F66AC0
        public void Copy(){} // RVA: 0x7FFAC8F66B30
        public void Get(){} // RVA: 0x7FFAC8F66B70
        public void IsNull(){} // RVA: 0x7FFAC8F66BE0
        public void Set(){} // RVA: 0x7FFAC8F66C60
        public void SetCapacity(){} // RVA: 0x7FFAC8F66CA0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F66DB0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F66FA0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F67160
        public void CopyValue(){} // RVA: 0x7FFAC8F671A0
        public void SetStorage(){} // RVA: 0x7FFAC8F672B0
    }

    public class SqlByteStorage : DataStorage
    {
        public System.Data.SqlTypes.SqlByte[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F51DC0
        public void Aggregate(){} // RVA: 0x7FFAC8F51F50
        public void Compare(){} // RVA: 0x7FFAC8F53220
        public void CompareValueTo(){} // RVA: 0x7FFAC8F532C0
        public void ConvertValue(){} // RVA: 0x7FFAC8F53370
        public void Copy(){} // RVA: 0x7FFAC8F533E0
        public void Get(){} // RVA: 0x7FFAC8F53420
        public void IsNull(){} // RVA: 0x7FFAC8F534A0
        public void Set(){} // RVA: 0x7FFAC8F53520
        public void SetCapacity(){} // RVA: 0x7FFAC8F53570
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F53680
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F53870
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F53A30
        public void CopyValue(){} // RVA: 0x7FFAC8F53A70
        public void SetStorage(){} // RVA: 0x7FFAC8F53B80
    }

    public class SqlBytesStorage : DataStorage
    {
        public System.Data.SqlTypes.SqlBytes[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F53C70
        public void Aggregate(){} // RVA: 0x7FFAC8F53E20
        public void Compare(){} // RVA: 0x7FFAC34F9180
        public void CompareValueTo(){} // RVA: 0x7FFAC34F9180
        public void Copy(){} // RVA: 0x7FFAC8F51530
        public void Get(){} // RVA: 0x7FFAC8F53FD0
        public void IsNull(){} // RVA: 0x7FFAC8F54000
        public void Set(){} // RVA: 0x7FFAC8F54040
        public void SetCapacity(){} // RVA: 0x7FFAC8F54150
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F54260
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F544F0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F546B0
        public void CopyValue(){} // RVA: 0x7FFAC8F546F0
        public void SetStorage(){} // RVA: 0x7FFAC8F54810
    }

    public class SqlCharsStorage : DataStorage
    {
        public System.Data.SqlTypes.SqlChars[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F54900
        public void Aggregate(){} // RVA: 0x7FFAC8F54AB0
        public void Compare(){} // RVA: 0x7FFAC34F9180
        public void CompareValueTo(){} // RVA: 0x7FFAC34F9180
        public void Copy(){} // RVA: 0x7FFAC8F51530
        public void Get(){} // RVA: 0x7FFAC8F53FD0
        public void IsNull(){} // RVA: 0x7FFAC8F54000
        public void Set(){} // RVA: 0x7FFAC8F54C60
        public void SetCapacity(){} // RVA: 0x7FFAC8F54D70
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F54E80
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F55170
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F55330
        public void CopyValue(){} // RVA: 0x7FFAC8F55370
        public void SetStorage(){} // RVA: 0x7FFAC8F55490
    }

    public class SqlConvert : Object
    {
        // ── Methods ──
        public void ConvertToSqlByte(){} // RVA: 0x7FFAC8F48590
        public void ConvertToSqlInt16(){} // RVA: 0x7FFAC8F48770
        public void ConvertToSqlInt32(){} // RVA: 0x7FFAC8F48AE0
        public void ConvertToSqlInt64(){} // RVA: 0x7FFAC8F49000
        public void ConvertToSqlDouble(){} // RVA: 0x7FFAC8F49510
        public void ConvertToSqlDecimal(){} // RVA: 0x7FFAC8F4A110
        public void ConvertToSqlSingle(){} // RVA: 0x7FFAC8F4AA30
        public void ConvertToSqlMoney(){} // RVA: 0x7FFAC8F4B7E0
        public void ConvertToSqlDateTime(){} // RVA: 0x7FFAC8F4C1D0
        public void ConvertToSqlBoolean(){} // RVA: 0x7FFAC8F4C430
        public void ConvertToSqlGuid(){} // RVA: 0x7FFAC8F4C600
        public void ConvertToSqlBinary(){} // RVA: 0x7FFAC8F4C840
        public void ConvertToSqlString(){} // RVA: 0x7FFAC8F4CA40
        public void ConvertToSqlChars(){} // RVA: 0x7FFAC8F4CC60
        public void ConvertToSqlBytes(){} // RVA: 0x7FFAC8F4CDF0
        public void ConvertStringToDateTimeOffset(){} // RVA: 0x7FFAC8F4CF80
        public void ChangeTypeForDefaultValue(){} // RVA: 0x7FFAC8F4D050
        public void ChangeType2(){} // RVA: 0x7FFAC8F4D270
        public void ChangeTypeForXML(){} // RVA: 0x7FFAC8F4EC10
    }

    public class SqlDateTimeStorage : DataStorage
    {
        public System.Data.SqlTypes.SqlDateTime[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F55580
        public void Aggregate(){} // RVA: 0x7FFAC8F55740
        public void Compare(){} // RVA: 0x7FFAC8F55D00
        public void CompareValueTo(){} // RVA: 0x7FFAC8F55DD0
        public void ConvertValue(){} // RVA: 0x7FFAC8F55EA0
        public void Copy(){} // RVA: 0x7FFAC8F55F30
        public void Get(){} // RVA: 0x7FFAC8F55F80
        public void IsNull(){} // RVA: 0x7FFAC8F56010
        public void Set(){} // RVA: 0x7FFAC8F56090
        public void SetCapacity(){} // RVA: 0x7FFAC8F560F0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F56200
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F56410
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F565D0
        public void CopyValue(){} // RVA: 0x7FFAC8F56610
        public void SetStorage(){} // RVA: 0x7FFAC8F56750
    }

    public class SqlDecimalStorage : DataStorage
    {
        public System.Data.SqlTypes.SqlDecimal[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F56840
        public void Aggregate(){} // RVA: 0x7FFAC8F56A00
        public void Compare(){} // RVA: 0x7FFAC8F57D70
        public void CompareValueTo(){} // RVA: 0x7FFAC8F57E40
        public void ConvertValue(){} // RVA: 0x7FFAC8F57F10
        public void Copy(){} // RVA: 0x7FFAC8F57F90
        public void Get(){} // RVA: 0x7FFAC8F57FE0
        public void IsNull(){} // RVA: 0x7FFAC8F58060
        public void Set(){} // RVA: 0x7FFAC8F58140
        public void SetCapacity(){} // RVA: 0x7FFAC8F581A0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F582B0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F584A0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F58660
        public void CopyValue(){} // RVA: 0x7FFAC8F586A0
        public void SetStorage(){} // RVA: 0x7FFAC8F587D0
    }

    public class SqlDoubleStorage : DataStorage
    {
        public System.Data.SqlTypes.SqlDouble[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F58950
        public void Aggregate(){} // RVA: 0x7FFAC8F58AF0
        public void Compare(){} // RVA: 0x7FFAC8F59DE0
        public void CompareValueTo(){} // RVA: 0x7FFAC8F59EA0
        public void ConvertValue(){} // RVA: 0x7FFAC8F59F60
        public void Copy(){} // RVA: 0x7FFAC8F59FE0
        public void Get(){} // RVA: 0x7FFAC8F5A030
        public void IsNull(){} // RVA: 0x7FFAC8F5A0B0
        public void Set(){} // RVA: 0x7FFAC8F5A130
        public void SetCapacity(){} // RVA: 0x7FFAC8F5A190
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F5A2A0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F5A4A0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F5A660
        public void CopyValue(){} // RVA: 0x7FFAC8F5A6A0
        public void SetStorage(){} // RVA: 0x7FFAC8F5A7D0
    }

    public class SqlGuidStorage : DataStorage
    {
        public System.Data.SqlTypes.SqlGuid[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F5A8C0
        public void Aggregate(){} // RVA: 0x7FFAC8F5AA50
        public void Compare(){} // RVA: 0x7FFAC8F5AC20
        public void CompareValueTo(){} // RVA: 0x7FFAC8F5ACC0
        public void ConvertValue(){} // RVA: 0x7FFAC8F5AD70
        public void Copy(){} // RVA: 0x7FFAC8F51530
        public void Get(){} // RVA: 0x7FFAC8F5ADE0
        public void IsNull(){} // RVA: 0x7FFAC8F5AE60
        public void Set(){} // RVA: 0x7FFAC8F5AEE0
        public void SetCapacity(){} // RVA: 0x7FFAC8F5AF20
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F5B030
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F5B220
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F5B3E0
        public void CopyValue(){} // RVA: 0x7FFAC8F5B420
        public void SetStorage(){} // RVA: 0x7FFAC8F5B540
    }

    public class SqlInt16Storage : DataStorage
    {
        public System.Data.SqlTypes.SqlInt16[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F5B630
        public void Aggregate(){} // RVA: 0x7FFAC8F5B7C0
        public void Compare(){} // RVA: 0x7FFAC8F5CA40
        public void CompareValueTo(){} // RVA: 0x7FFAC8F5CAE0
        public void ConvertValue(){} // RVA: 0x7FFAC8F5CB90
        public void Copy(){} // RVA: 0x7FFAC8F5CC00
        public void Get(){} // RVA: 0x7FFAC8F5CC40
        public void IsNull(){} // RVA: 0x7FFAC8F5CCB0
        public void Set(){} // RVA: 0x7FFAC8F5CD30
        public void SetCapacity(){} // RVA: 0x7FFAC8F5CD70
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F5CE80
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F5D070
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F5D230
        public void CopyValue(){} // RVA: 0x7FFAC8F5D270
        public void SetStorage(){} // RVA: 0x7FFAC8F5D380
    }

    public class SqlInt32Storage : DataStorage
    {
        public System.Data.SqlTypes.SqlInt32[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F5D470
        public void Aggregate(){} // RVA: 0x7FFAC8F5D600
        public void Compare(){} // RVA: 0x7FFAC8F5E880
        public void CompareValueTo(){} // RVA: 0x7FFAC8F5E920
        public void ConvertValue(){} // RVA: 0x7FFAC8F5E9D0
        public void Copy(){} // RVA: 0x7FFAC8F5EA40
        public void Get(){} // RVA: 0x7FFAC8F5EA80
        public void IsNull(){} // RVA: 0x7FFAC8F5EB00
        public void Set(){} // RVA: 0x7FFAC8F5EB80
        public void SetCapacity(){} // RVA: 0x7FFAC8F5EBD0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F5ECE0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F5EED0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F5F090
        public void CopyValue(){} // RVA: 0x7FFAC8F5F0D0
        public void SetStorage(){} // RVA: 0x7FFAC8F5F1E0
    }

    public class SqlInt64Storage : DataStorage
    {
        public System.Data.SqlTypes.SqlInt64[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F5F2D0
        public void Aggregate(){} // RVA: 0x7FFAC8F5F470
        public void Compare(){} // RVA: 0x7FFAC8F60790
        public void CompareValueTo(){} // RVA: 0x7FFAC8F60850
        public void ConvertValue(){} // RVA: 0x7FFAC8F60910
        public void Copy(){} // RVA: 0x7FFAC8F59FE0
        public void Get(){} // RVA: 0x7FFAC8F60990
        public void IsNull(){} // RVA: 0x7FFAC8F60A10
        public void Set(){} // RVA: 0x7FFAC8F60A90
        public void SetCapacity(){} // RVA: 0x7FFAC8F60AF0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F60C00
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F60E00
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F60FC0
        public void CopyValue(){} // RVA: 0x7FFAC8F61000
        public void SetStorage(){} // RVA: 0x7FFAC8F61130
    }

    public class SqlMoneyStorage : DataStorage
    {
        public System.Data.SqlTypes.SqlMoney[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F61220
        public void Aggregate(){} // RVA: 0x7FFAC8F613C0
        public void Compare(){} // RVA: 0x7FFAC8F62730
        public void CompareValueTo(){} // RVA: 0x7FFAC8F627F0
        public void ConvertValue(){} // RVA: 0x7FFAC8F628B0
        public void Copy(){} // RVA: 0x7FFAC8F59FE0
        public void Get(){} // RVA: 0x7FFAC8F62930
        public void IsNull(){} // RVA: 0x7FFAC8F629B0
        public void Set(){} // RVA: 0x7FFAC8F62A30
        public void SetCapacity(){} // RVA: 0x7FFAC8F62A90
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F62BA0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F62DA0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F62F60
        public void CopyValue(){} // RVA: 0x7FFAC8F62FA0
        public void SetStorage(){} // RVA: 0x7FFAC8F630D0
    }

    public class SqlSingleStorage : DataStorage
    {
        public System.Data.SqlTypes.SqlSingle[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F631C0
        public void Aggregate(){} // RVA: 0x7FFAC8F63350
        public void Compare(){} // RVA: 0x7FFAC8F64690
        public void CompareValueTo(){} // RVA: 0x7FFAC8F64730
        public void ConvertValue(){} // RVA: 0x7FFAC8F647E0
        public void Copy(){} // RVA: 0x7FFAC8F5EA40
        public void Get(){} // RVA: 0x7FFAC8F64850
        public void IsNull(){} // RVA: 0x7FFAC8F648D0
        public void Set(){} // RVA: 0x7FFAC8F64950
        public void SetCapacity(){} // RVA: 0x7FFAC8F649A0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F64AB0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F64CA0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F64E60
        public void CopyValue(){} // RVA: 0x7FFAC8F64EA0
        public void SetStorage(){} // RVA: 0x7FFAC8F64FB0
    }

    public class SqlStringStorage : DataStorage
    {
        public System.Data.SqlTypes.SqlString[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F650A0
        public void Aggregate(){} // RVA: 0x7FFAC8F65250
        public void Compare(){} // RVA: 0x7FFAC8F65650 | overloaded x2
        public void CompareValueTo(){} // RVA: 0x7FFAC8F657A0
        public void ConvertValue(){} // RVA: 0x7FFAC8F65870
        public void Copy(){} // RVA: 0x7FFAC8F65900
        public void Get(){} // RVA: 0x7FFAC8F659C0
        public void GetStringLength(){} // RVA: 0x7FFAC8F65A50
        public void IsNull(){} // RVA: 0x7FFAC8F65B60
        public void Set(){} // RVA: 0x7FFAC8F65BE0
        public void SetCapacity(){} // RVA: 0x7FFAC8F65CA0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F65DB0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F65FA0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F66160
        public void CopyValue(){} // RVA: 0x7FFAC8F661A0
        public void SetStorage(){} // RVA: 0x7FFAC8F66340
    }

    public class SqlUdtStorage : DataStorage
    {
        public object[] _values; // 0x50
        public bool _implementsIXmlSerializable; // 0x58
        public bool _implementsIComparable; // 0x59
        public System.Collections.Concurrent.ConcurrentDictionary`2<System.Type,object> s_typeToNull;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F68780 | overloaded x2
        public void GetStaticNullForUdtType(){} // RVA: 0x7FFAC8F68A00
        public void IsNull(){} // RVA: 0x7FFAC8F68B70
        public void Aggregate(){} // RVA: 0x7FFAC8F68C30
        public void Compare(){} // RVA: 0x7FFAC8F68C70
        public void CompareValueTo(){} // RVA: 0x7FFAC8F68CB0
        public void Copy(){} // RVA: 0x7FFAC8F68EC0
        public void Get(){} // RVA: 0x7FFAC8F53FD0
        public void Set(){} // RVA: 0x7FFAC8F68F70
        public void SetCapacity(){} // RVA: 0x7FFAC8F69170
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F694F0 | overloaded x2
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F699B0 | overloaded x2
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F69AD0
        public void CopyValue(){} // RVA: 0x7FFAC8F69B10
        public void SetStorage(){} // RVA: 0x7FFAC8F69C80
        public void .cctor(){} // RVA: 0x7FFAC8F69D70
    }

    public class StringStorage : DataStorage
    {
        public string[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F69FD0
        public void Aggregate(){} // RVA: 0x7FFAC8F6A110
        public void Compare(){} // RVA: 0x7FFAC8F6A3D0
        public void CompareValueTo(){} // RVA: 0x7FFAC8F6A460
        public void ConvertValue(){} // RVA: 0x7FFAC8F6A550
        public void Copy(){} // RVA: 0x7FFAC8F51530
        public void Get(){} // RVA: 0x7FFAC8F2DD50
        public void GetStringLength(){} // RVA: 0x7FFAC8F6A580
        public void IsNull(){} // RVA: 0x7FFAC8F2DF30
        public void Set(){} // RVA: 0x7FFAC8F6A5C0
        public void SetCapacity(){} // RVA: 0x7FFAC8F6A640
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC3E92FB0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F6A750
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F6A7B0
        public void CopyValue(){} // RVA: 0x7FFAC8F6A7F0
        public void SetStorage(){} // RVA: 0x7FFAC8F6A910
    }

    public class TimeSpanStorage : DataStorage
    {
        public System.TimeSpan s_defaultValue;
        public System.TimeSpan[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F6AA00
        public void Aggregate(){} // RVA: 0x7FFAC8F6AB80
        public void Compare(){} // RVA: 0x7FFAC8F6B900
        public void CompareValueTo(){} // RVA: 0x7FFAC8F6BA70
        public void ConvertToTimeSpan(){} // RVA: 0x7FFAC8F6BC00
        public void ConvertValue(){} // RVA: 0x7FFAC8F6BEE0
        public void Copy(){} // RVA: 0x7FFAC8F3F900
        public void Get(){} // RVA: 0x7FFAC8F6BF90
        public void Set(){} // RVA: 0x7FFAC8F6C0B0
        public void SetCapacity(){} // RVA: 0x7FFAC8F6C1B0
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F6C2D0
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F6C350
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F6C430
        public void CopyValue(){} // RVA: 0x7FFAC8F6C470
        public void SetStorage(){} // RVA: 0x7FFAC8F6C580
        public void .cctor(){} // RVA: 0x7FFAC8F6C6E0
    }

    public class UInt16Storage : DataStorage
    {
        public ushort s_defaultValue;
        public ushort[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F6C760
        public void Aggregate(){} // RVA: 0x7FFAC8F6C8D0
        public void Compare(){} // RVA: 0x7FFAC8F6D100
        public void CompareValueTo(){} // RVA: 0x7FFAC8F6D1C0
        public void ConvertValue(){} // RVA: 0x7FFAC8F6D2D0
        public void Copy(){} // RVA: 0x7FFAC8F37B20
        public void Get(){} // RVA: 0x7FFAC8F6D3E0
        public void Set(){} // RVA: 0x7FFAC8F6D4B0
        public void SetCapacity(){} // RVA: 0x7FFAC8F6D610
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F6D730
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F6D830
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F6D8C0
        public void CopyValue(){} // RVA: 0x7FFAC8F6D900
        public void SetStorage(){} // RVA: 0x7FFAC8F6DA10
    }

    public class UInt32Storage : DataStorage
    {
        public uint s_defaultValue;
        public uint[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F6DB70
        public void Aggregate(){} // RVA: 0x7FFAC8F6DCD0
        public void Compare(){} // RVA: 0x7FFAC8F6E4F0
        public void CompareValueTo(){} // RVA: 0x7FFAC8F6E5C0
        public void ConvertValue(){} // RVA: 0x7FFAC8F6E6E0
        public void Copy(){} // RVA: 0x7FFAC8F45640
        public void Get(){} // RVA: 0x7FFAC8F6E7F0
        public void Set(){} // RVA: 0x7FFAC8F6E8C0
        public void SetCapacity(){} // RVA: 0x7FFAC8F6EA20
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F6EB40
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F6EBD0
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F6EC60
        public void CopyValue(){} // RVA: 0x7FFAC8F6ECA0
        public void SetStorage(){} // RVA: 0x7FFAC8F6EDB0
    }

    public class UInt64Storage : DataStorage
    {
        public ulong s_defaultValue;
        public ulong[] _values; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F6EF10
        public void Aggregate(){} // RVA: 0x7FFAC8F6F080
        public void Compare(){} // RVA: 0x7FFAC8F6FA20
        public void CompareValueTo(){} // RVA: 0x7FFAC8F6FAF0
        public void ConvertValue(){} // RVA: 0x7FFAC8F6FC10
        public void Copy(){} // RVA: 0x7FFAC8F46AF0
        public void Get(){} // RVA: 0x7FFAC8F6FD20
        public void Set(){} // RVA: 0x7FFAC8F6FDF0
        public void SetCapacity(){} // RVA: 0x7FFAC8F6FF50
        public void ConvertXmlToObject(){} // RVA: 0x7FFAC8F70070
        public void ConvertObjectToXml(){} // RVA: 0x7FFAC8F70100
        public void GetEmptyStorage(){} // RVA: 0x7FFAC8F70190
        public void CopyValue(){} // RVA: 0x7FFAC8F701D0
        public void SetStorage(){} // RVA: 0x7FFAC8F702E0
    }

}