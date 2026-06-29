// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data.Common
// Classes: 38
// Methods: 597

namespace ThirdParty.DotNet.System.Data.Common
{
    public class ADP : Object
    {
        public object s_stackOverflowType;
        public object s_outOfMemoryType;
        public object s_threadAbortType;
        public object s_nullReferenceType;
        public object s_accessViolationType;
        public object s_securityType;
        public object StrEmpty;
        public object AzureSqlServerEndpoints;
        public object PtrZero;
        public object PtrSize;

        // ── Methods ──
        public void TraceException(){} // RVA: 0x7201C30
        public void TraceExceptionAsReturnValue(){} // RVA: 0x7201CC0
        public void TraceExceptionWithoutRethrow(){} // RVA: 0x7201D90
        public void Argument(){} // RVA: 0x7201E60
        public void ArgumentOutOfRange(){} // RVA: 0x7201FB0
        public void InvalidOperation(){} // RVA: 0x7202050
        public void NotSupported(){} // RVA: 0x72020E0
        public void IsCatchableExceptionType(){} // RVA: 0x7202170
        public void IsCatchableOrSecurityExceptionType(){} // RVA: 0x7202390
        public void InvalidEnumerationValue(){} // RVA: 0x7202560
        public void InvalidSeekOrigin(){} // RVA: 0x72026B0
        public void InvalidAcceptRejectRule(){} // RVA: 0x7202720
        public void InvalidMissingSchemaAction(){} // RVA: 0x72027E0
        public void InvalidRule(){} // RVA: 0x72028A0
        public void WrongType(){} // RVA: 0x7202960
        public void .cctor(){} // RVA: 0x7202AA0
    }

    public class BigIntegerStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7203120
        public void Aggregate(){} // RVA: 0x7203290
        public void Compare(){} // RVA: 0x72032D0
        public void CompareValueTo(){} // RVA: 0x7203400
        public void ConvertToBigInteger(){} // RVA: 0x7203560
        public void ConvertFromBigInteger(){} // RVA: 0x7203BF0
        public void ConvertValue(){} // RVA: 0x7204380
        public void Copy(){} // RVA: 0x7204420
        public void Get(){} // RVA: 0x7204520
        public void Set(){} // RVA: 0x7204610
        public void SetCapacity(){} // RVA: 0x7204820
        public void ConvertXmlToObject(){} // RVA: 0x7204940
        public void ConvertObjectToXml(){} // RVA: 0x7204A90
        public void GetEmptyStorage(){} // RVA: 0x7204C80
        public void CopyValue(){} // RVA: 0x7204CC0
        public void SetStorage(){} // RVA: 0x7204E50
    }

    public class BooleanStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7204FB0
        public void Aggregate(){} // RVA: 0x7205120
        public void Compare(){} // RVA: 0x72053D0
        public void CompareValueTo(){} // RVA: 0x72054A0
        public void ConvertValue(){} // RVA: 0x72055C0
        public void Copy(){} // RVA: 0x72056B0
        public void Get(){} // RVA: 0x7205740
        public void Set(){} // RVA: 0x72057C0
        public void SetCapacity(){} // RVA: 0x7205900
        public void ConvertXmlToObject(){} // RVA: 0x7205A20
        public void ConvertObjectToXml(){} // RVA: 0x7205A90
        public void GetEmptyStorage(){} // RVA: 0x7205B50
        public void CopyValue(){} // RVA: 0x7205B90
        public void SetStorage(){} // RVA: 0x7205CB0
    }

    public class ByteStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7205E10
        public void Aggregate(){} // RVA: 0x7205F80
        public void Compare(){} // RVA: 0x72066C0
        public void CompareValueTo(){} // RVA: 0x7206730
        public void ConvertValue(){} // RVA: 0x7206800
        public void Copy(){} // RVA: 0x72068F0
        public void Get(){} // RVA: 0x7206980
        public void Set(){} // RVA: 0x7206A00
        public void SetCapacity(){} // RVA: 0x7206B40
        public void ConvertXmlToObject(){} // RVA: 0x7206C60
        public void ConvertObjectToXml(){} // RVA: 0x7206D50
        public void GetEmptyStorage(){} // RVA: 0x7206DD0
        public void CopyValue(){} // RVA: 0x7206E10
        public void SetStorage(){} // RVA: 0x7206F20
    }

    public class CharStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7207080
        public void Aggregate(){} // RVA: 0x7207200
        public void Compare(){} // RVA: 0x7207500
        public void CompareValueTo(){} // RVA: 0x7207580
        public void ConvertValue(){} // RVA: 0x7207660
        public void Copy(){} // RVA: 0x7207750
        public void Get(){} // RVA: 0x72077E0
        public void Set(){} // RVA: 0x7207860
        public void SetCapacity(){} // RVA: 0x7207A00
        public void ConvertXmlToObject(){} // RVA: 0x7207B20
        public void ConvertObjectToXml(){} // RVA: 0x7207C40
        public void GetEmptyStorage(){} // RVA: 0x7207CF0
        public void CopyValue(){} // RVA: 0x7207D30
        public void SetStorage(){} // RVA: 0x7207E40
    }

    public class DataStorage : Object
    {
        public object s_storageClassType;
        public object _column;
        public object _table;
        public object _dataType;
        public object _storageTypeCode;
        public object _dbNullBits;
        public object _defaultValue;
        public object _nullValue;
        public object _isCloneable;
        public object _isCustomDefinedType;
        public object _isStringType;
        public object _isValueType;
        public object s_inspectTypeForInterfaces;
        public object s_typeImplementsInterface;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7208080
        public void get_DateTimeMode(){} // RVA: 0x7208370
        public void get_FormatProvider(){} // RVA: 0x7208390
        public void Aggregate(){} // RVA: 0x72083B0
        public void AggregateCount(){} // RVA: 0x7208460
        public void CompareBits(){} // RVA: 0x72084F0
        public void Compare(){} // RVA: 0x8830B0
        public void CompareValueTo(){} // RVA: 0x883740
        public void ConvertValue(){} // RVA: 0x1CB3B00
        public void CopyBits(){} // RVA: 0x7208570
        public void Copy(){} // RVA: 0x8965E0
        public void Get(){} // RVA: 0x87C160
        public void GetBits(){} // RVA: 0x72085C0
        public void GetStringLength(){} // RVA: 0x66ABE00
        public void HasValue(){} // RVA: 0x7208600
        public void IsNull(){} // RVA: 0x7208630
        public void Set(){} // RVA: 0x895750
        public void SetNullBit(){} // RVA: 0x7208650
        public void SetCapacity(){} // RVA: 0x7208670
        public void ConvertXmlToObject(){} // RVA: 0x7208740
        public void ConvertObjectToXml(){} // RVA: 0x7208790
        public void CreateStorage(){} // RVA: 0x72087E0
        public void GetStorageType(){} // RVA: 0x720B010
        public void GetTypeStorage(){} // RVA: 0x720B170
        public void IsTypeCustomType(){} // RVA: 0x720B260
        public void IsSqlType(){} // RVA: 0x720B280
        public void DetermineIfValueType(){} // RVA: 0x720B380
        public void ImplementsInterfaces(){} // RVA: 0x720B420
        public void InspectTypeForInterfaces(){} // RVA: 0x720B5B0
        public void ImplementsINullableValue(){} // RVA: 0x720B810
        public void IsObjectNull(){} // RVA: 0x720B910
        public void IsObjectSqlNull(){} // RVA: 0x720B9B0
        public void GetEmptyStorageInternal(){} // RVA: 0x720BA10
        public void CopyValueInternal(){} // RVA: 0x720BA30
        public void SetStorageInternal(){} // RVA: 0x720BA50
        public void GetEmptyStorage(){} // RVA: 0x87C160
        public void CopyValue(){} // RVA: 0x897870
        public void SetStorage(){} // RVA: 0x8943B0
        public void SetNullStorage(){} // RVA: 0xB708C0
        public void GetType(){} // RVA: 0x720BA70
        public void GetQualifiedName(){} // RVA: 0x720BBD0
        public void .cctor(){} // RVA: 0x720BC40
    }

    public class DateTimeOffsetStorage : DataStorage
    {
        public object s_defaultValue;
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x720D310
        public void Aggregate(){} // RVA: 0x720D460
        public void Compare(){} // RVA: 0x720D8D0
        public void CompareValueTo(){} // RVA: 0x720DAB0
        public void ConvertValue(){} // RVA: 0x720DC60
        public void Copy(){} // RVA: 0x720DCF0
        public void Get(){} // RVA: 0x720DD80
        public void Set(){} // RVA: 0x720DED0
        public void SetCapacity(){} // RVA: 0x720E000
        public void ConvertXmlToObject(){} // RVA: 0x720E120
        public void ConvertObjectToXml(){} // RVA: 0x720E250
        public void GetEmptyStorage(){} // RVA: 0x720E2F0
        public void CopyValue(){} // RVA: 0x720E330
        public void SetStorage(){} // RVA: 0x720E460
        public void .cctor(){} // RVA: 0x720E5C0
    }

    public class DateTimeStorage : DataStorage
    {
        public object s_defaultValue;
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x720E640
        public void Aggregate(){} // RVA: 0x720E790
        public void Compare(){} // RVA: 0x720EBC0
        public void CompareValueTo(){} // RVA: 0x720ED70
        public void ConvertValue(){} // RVA: 0x720EEF0
        public void Copy(){} // RVA: 0x720F000
        public void Get(){} // RVA: 0x720F090
        public void Set(){} // RVA: 0x720F1E0
        public void SetCapacity(){} // RVA: 0x720F650
        public void ConvertXmlToObject(){} // RVA: 0x720F770
        public void ConvertObjectToXml(){} // RVA: 0x720F8C0
        public void GetEmptyStorage(){} // RVA: 0x720FAA0
        public void CopyValue(){} // RVA: 0x720FAE0
        public void SetStorage(){} // RVA: 0x720FC60
        public void .cctor(){} // RVA: 0x720FF40
    }

    public class DecimalStorage : DataStorage
    {
        public object s_defaultValue;
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x720FFC0
        public void Aggregate(){} // RVA: 0x72100F0
        public void Compare(){} // RVA: 0x7210BF0
        public void CompareValueTo(){} // RVA: 0x7210E40
        public void ConvertValue(){} // RVA: 0x7211060
        public void Copy(){} // RVA: 0x720DCF0
        public void Get(){} // RVA: 0x7211170
        public void Set(){} // RVA: 0x7211210
        public void SetCapacity(){} // RVA: 0x7211380
        public void ConvertXmlToObject(){} // RVA: 0x72114A0
        public void ConvertObjectToXml(){} // RVA: 0x7211580
        public void GetEmptyStorage(){} // RVA: 0x72116F0
        public void CopyValue(){} // RVA: 0x7211730
        public void SetStorage(){} // RVA: 0x7211860
    }

    public class DoubleStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x72119C0
        public void Aggregate(){} // RVA: 0x7211AC0
        public void Compare(){} // RVA: 0x7212180
        public void CompareValueTo(){} // RVA: 0x7212290
        public void ConvertValue(){} // RVA: 0x72123E0
        public void Copy(){} // RVA: 0x72124E0
        public void Get(){} // RVA: 0x7212570
        public void Set(){} // RVA: 0x72125F0
        public void SetCapacity(){} // RVA: 0x7212730
        public void ConvertXmlToObject(){} // RVA: 0x7212850
        public void ConvertObjectToXml(){} // RVA: 0x72128C0
        public void GetEmptyStorage(){} // RVA: 0x7212940
        public void CopyValue(){} // RVA: 0x7212980
        public void SetStorage(){} // RVA: 0x7212AB0
    }

    public class Int16Storage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7212C10
        public void Aggregate(){} // RVA: 0x7212D90
        public void Compare(){} // RVA: 0x7213560
        public void CompareValueTo(){} // RVA: 0x72135D0
        public void ConvertValue(){} // RVA: 0x72136A0
        public void Copy(){} // RVA: 0x7207750
        public void Get(){} // RVA: 0x72137A0
        public void Set(){} // RVA: 0x7213820
        public void SetCapacity(){} // RVA: 0x7213960
        public void ConvertXmlToObject(){} // RVA: 0x7213A80
        public void ConvertObjectToXml(){} // RVA: 0x7213B70
        public void GetEmptyStorage(){} // RVA: 0x7213BF0
        public void CopyValue(){} // RVA: 0x7213C30
        public void SetStorage(){} // RVA: 0x7213D40
    }

    public class Int32Storage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7213EA0
        public void Aggregate(){} // RVA: 0x7214020
        public void Compare(){} // RVA: 0x72147E0
        public void CompareValueTo(){} // RVA: 0x7214860
        public void ConvertValue(){} // RVA: 0x7214950
        public void Copy(){} // RVA: 0x7214A40
        public void Get(){} // RVA: 0x7214AD0
        public void Set(){} // RVA: 0x7214B50
        public void SetCapacity(){} // RVA: 0x7214C90
        public void ConvertXmlToObject(){} // RVA: 0x7214DB0
        public void ConvertObjectToXml(){} // RVA: 0x7214E30
        public void GetEmptyStorage(){} // RVA: 0x7214EB0
        public void CopyValue(){} // RVA: 0x7214EF0
        public void SetStorage(){} // RVA: 0x7215000
    }

    public class Int64Storage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7215160
        public void Aggregate(){} // RVA: 0x72152D0
        public void Compare(){} // RVA: 0x7215BA0
        public void CompareValueTo(){} // RVA: 0x7215C20
        public void ConvertValue(){} // RVA: 0x7215D10
        public void Copy(){} // RVA: 0x7215E10
        public void Get(){} // RVA: 0x7215EA0
        public void Set(){} // RVA: 0x7215F20
        public void SetCapacity(){} // RVA: 0x7216060
        public void ConvertXmlToObject(){} // RVA: 0x7216180
        public void ConvertObjectToXml(){} // RVA: 0x7216200
        public void GetEmptyStorage(){} // RVA: 0x7216280
        public void CopyValue(){} // RVA: 0x72162C0
        public void SetStorage(){} // RVA: 0x72163D0
    }

    public class ObjectStorage : DataStorage
    {
        public object s_defaultValue;
        public object _values;
        public object _implementsIXmlSerializable;
        public object s_tempAssemblyCacheLock;
        public object s_tempAssemblyCache;
        public object s_serializerFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71FD920
        public void Aggregate(){} // RVA: 0x71FDB30
        public void Compare(){} // RVA: 0x71FDB70
        public void CompareValueTo(){} // RVA: 0x71FDC90
        public void CompareTo(){} // RVA: 0x71FDE10
        public void CompareWithFamilies(){} // RVA: 0x71FDF50
        public void Copy(){} // RVA: 0x71FE390
        public void Get(){} // RVA: 0x71FE410
        public void GetFamily(){} // RVA: 0x71FE450
        public void IsNull(){} // RVA: 0x71FE5E0
        public void Set(){} // RVA: 0x71FE610
        public void SetCapacity(){} // RVA: 0x71FEF70
        public void ConvertXmlToObject(){} // RVA: 0x71FF5C0
        public void ConvertObjectToXml(){} // RVA: 0x72002C0
        public void GetEmptyStorage(){} // RVA: 0x7200400
        public void CopyValue(){} // RVA: 0x7200440
        public void SetStorage(){} // RVA: 0x72006E0
        public void VerifyIDynamicMetaObjectProvider(){} // RVA: 0x72009F0
        public void GetXmlSerializer(){} // RVA: 0x7200C00
        public void .cctor(){} // RVA: 0x72016F0
    }

    public class SByteStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7216530
        public void Aggregate(){} // RVA: 0x72166A0
        public void Compare(){} // RVA: 0x7216DF0
        public void CompareValueTo(){} // RVA: 0x7216E60
        public void ConvertValue(){} // RVA: 0x7216F30
        public void Copy(){} // RVA: 0x72068F0
        public void Get(){} // RVA: 0x7217020
        public void Set(){} // RVA: 0x72170A0
        public void SetCapacity(){} // RVA: 0x72171E0
        public void ConvertXmlToObject(){} // RVA: 0x7217300
        public void ConvertObjectToXml(){} // RVA: 0x72173F0
        public void GetEmptyStorage(){} // RVA: 0x7217470
        public void CopyValue(){} // RVA: 0x72174B0
        public void SetStorage(){} // RVA: 0x72175C0
    }

    public class SingleStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7235C70
        public void Aggregate(){} // RVA: 0x7235D70
        public void Compare(){} // RVA: 0x7236450
        public void CompareValueTo(){} // RVA: 0x7236540
        public void ConvertValue(){} // RVA: 0x7236680
        public void Copy(){} // RVA: 0x7236780
        public void Get(){} // RVA: 0x7236810
        public void Set(){} // RVA: 0x7236890
        public void SetCapacity(){} // RVA: 0x72369D0
        public void ConvertXmlToObject(){} // RVA: 0x7236AF0
        public void ConvertObjectToXml(){} // RVA: 0x7236B60
        public void GetEmptyStorage(){} // RVA: 0x7236BE0
        public void CopyValue(){} // RVA: 0x7236C20
        public void SetStorage(){} // RVA: 0x7236D50
    }

    public class SqlBinaryStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x721FCF0
        public void Aggregate(){} // RVA: 0x721FE50
        public void Compare(){} // RVA: 0x7220010
        public void CompareValueTo(){} // RVA: 0x72200B0
        public void ConvertValue(){} // RVA: 0x7220160
        public void Copy(){} // RVA: 0x72201D0
        public void Get(){} // RVA: 0x7220210
        public void IsNull(){} // RVA: 0x7220290
        public void Set(){} // RVA: 0x7220310
        public void SetCapacity(){} // RVA: 0x7220350
        public void ConvertXmlToObject(){} // RVA: 0x7220460
        public void ConvertObjectToXml(){} // RVA: 0x7220660
        public void GetEmptyStorage(){} // RVA: 0x7220820
        public void CopyValue(){} // RVA: 0x7220860
        public void SetStorage(){} // RVA: 0x7220980
    }

    public class SqlBooleanStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7234D40
        public void Aggregate(){} // RVA: 0x7234EA0
        public void Compare(){} // RVA: 0x7235230
        public void CompareValueTo(){} // RVA: 0x72352D0
        public void ConvertValue(){} // RVA: 0x7235380
        public void Copy(){} // RVA: 0x72353F0
        public void Get(){} // RVA: 0x7235430
        public void IsNull(){} // RVA: 0x72354A0
        public void Set(){} // RVA: 0x7235520
        public void SetCapacity(){} // RVA: 0x7235560
        public void ConvertXmlToObject(){} // RVA: 0x7235670
        public void ConvertObjectToXml(){} // RVA: 0x7235870
        public void GetEmptyStorage(){} // RVA: 0x7235A30
        public void CopyValue(){} // RVA: 0x7235A70
        public void SetStorage(){} // RVA: 0x7235B80
    }

    public class SqlByteStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7220A70
        public void Aggregate(){} // RVA: 0x7220BD0
        public void Compare(){} // RVA: 0x7221EB0
        public void CompareValueTo(){} // RVA: 0x7221F50
        public void ConvertValue(){} // RVA: 0x7222000
        public void Copy(){} // RVA: 0x7222070
        public void Get(){} // RVA: 0x72220B0
        public void IsNull(){} // RVA: 0x7222130
        public void Set(){} // RVA: 0x72221B0
        public void SetCapacity(){} // RVA: 0x7222200
        public void ConvertXmlToObject(){} // RVA: 0x7222310
        public void ConvertObjectToXml(){} // RVA: 0x7222500
        public void GetEmptyStorage(){} // RVA: 0x72226C0
        public void CopyValue(){} // RVA: 0x7222700
        public void SetStorage(){} // RVA: 0x7222810
    }

    public class SqlBytesStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7222900
        public void Aggregate(){} // RVA: 0x7222A80
        public void Compare(){} // RVA: 0xDAC980
        public void CompareValueTo(){} // RVA: 0xDAC980
        public void Copy(){} // RVA: 0x72201D0
        public void Get(){} // RVA: 0x7222C00
        public void IsNull(){} // RVA: 0x7222C30
        public void Set(){} // RVA: 0x7222C70
        public void SetCapacity(){} // RVA: 0x7222D80
        public void ConvertXmlToObject(){} // RVA: 0x7222E90
        public void ConvertObjectToXml(){} // RVA: 0x7223130
        public void GetEmptyStorage(){} // RVA: 0x72232F0
        public void CopyValue(){} // RVA: 0x7223330
        public void SetStorage(){} // RVA: 0x7223450
    }

    public class SqlCharsStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7223540
        public void Aggregate(){} // RVA: 0x72236C0
        public void Compare(){} // RVA: 0xDAC980
        public void CompareValueTo(){} // RVA: 0xDAC980
        public void Copy(){} // RVA: 0x72201D0
        public void Get(){} // RVA: 0x7222C00
        public void IsNull(){} // RVA: 0x7222C30
        public void Set(){} // RVA: 0x7223840
        public void SetCapacity(){} // RVA: 0x7223950
        public void ConvertXmlToObject(){} // RVA: 0x7223A60
        public void ConvertObjectToXml(){} // RVA: 0x7223D70
        public void GetEmptyStorage(){} // RVA: 0x7223F30
        public void CopyValue(){} // RVA: 0x7223F70
        public void SetStorage(){} // RVA: 0x7224090
    }

    public class SqlConvert : Object
    {
        // ── Methods ──
        public void ConvertToSqlByte(){} // RVA: 0x7217720
        public void ConvertToSqlInt16(){} // RVA: 0x72178F0
        public void ConvertToSqlInt32(){} // RVA: 0x7217C30
        public void ConvertToSqlInt64(){} // RVA: 0x7218100
        public void ConvertToSqlDouble(){} // RVA: 0x72185A0
        public void ConvertToSqlDecimal(){} // RVA: 0x7219110
        public void ConvertToSqlSingle(){} // RVA: 0x72199A0
        public void ConvertToSqlMoney(){} // RVA: 0x721A6D0
        public void ConvertToSqlDateTime(){} // RVA: 0x721B050
        public void ConvertToSqlBoolean(){} // RVA: 0x721B2A0
        public void ConvertToSqlGuid(){} // RVA: 0x721B460
        public void ConvertToSqlBinary(){} // RVA: 0x721B6B0
        public void ConvertToSqlString(){} // RVA: 0x721B8A0
        public void ConvertToSqlChars(){} // RVA: 0x721BAA0
        public void ConvertToSqlBytes(){} // RVA: 0x721BC30
        public void ConvertStringToDateTimeOffset(){} // RVA: 0x721BDC0
        public void ChangeTypeForDefaultValue(){} // RVA: 0x721BE90
        public void ChangeType2(){} // RVA: 0x721C080
        public void ChangeTypeForXML(){} // RVA: 0x721D950
    }

    public class SqlDateTimeStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7224180
        public void Aggregate(){} // RVA: 0x7224310
        public void Compare(){} // RVA: 0x72248B0
        public void CompareValueTo(){} // RVA: 0x7224980
        public void ConvertValue(){} // RVA: 0x7224A50
        public void Copy(){} // RVA: 0x7224AE0
        public void Get(){} // RVA: 0x7224B30
        public void IsNull(){} // RVA: 0x7224BC0
        public void Set(){} // RVA: 0x7224C40
        public void SetCapacity(){} // RVA: 0x7224CA0
        public void ConvertXmlToObject(){} // RVA: 0x7224DB0
        public void ConvertObjectToXml(){} // RVA: 0x7224FC0
        public void GetEmptyStorage(){} // RVA: 0x7225180
        public void CopyValue(){} // RVA: 0x72251C0
        public void SetStorage(){} // RVA: 0x7225300
    }

    public class SqlDecimalStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x72253F0
        public void Aggregate(){} // RVA: 0x7225580
        public void Compare(){} // RVA: 0x72268C0
        public void CompareValueTo(){} // RVA: 0x7226990
        public void ConvertValue(){} // RVA: 0x7226A60
        public void Copy(){} // RVA: 0x7226AE0
        public void Get(){} // RVA: 0x7226B30
        public void IsNull(){} // RVA: 0x7226BB0
        public void Set(){} // RVA: 0x7226C90
        public void SetCapacity(){} // RVA: 0x7226CF0
        public void ConvertXmlToObject(){} // RVA: 0x7226E00
        public void ConvertObjectToXml(){} // RVA: 0x7227000
        public void GetEmptyStorage(){} // RVA: 0x72271C0
        public void CopyValue(){} // RVA: 0x7227200
        public void SetStorage(){} // RVA: 0x7227330
    }

    public class SqlDoubleStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x72274B0
        public void Aggregate(){} // RVA: 0x7227620
        public void Compare(){} // RVA: 0x72288C0
        public void CompareValueTo(){} // RVA: 0x7228980
        public void ConvertValue(){} // RVA: 0x7228A40
        public void Copy(){} // RVA: 0x7228AC0
        public void Get(){} // RVA: 0x7228B10
        public void IsNull(){} // RVA: 0x7228B90
        public void Set(){} // RVA: 0x7228C10
        public void SetCapacity(){} // RVA: 0x7228C70
        public void ConvertXmlToObject(){} // RVA: 0x7228D80
        public void ConvertObjectToXml(){} // RVA: 0x7228F90
        public void GetEmptyStorage(){} // RVA: 0x7229150
        public void CopyValue(){} // RVA: 0x7229190
        public void SetStorage(){} // RVA: 0x72292C0
    }

    public class SqlGuidStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x72293B0
        public void Aggregate(){} // RVA: 0x7229510
        public void Compare(){} // RVA: 0x72296D0
        public void CompareValueTo(){} // RVA: 0x7229770
        public void ConvertValue(){} // RVA: 0x7229820
        public void Copy(){} // RVA: 0x72201D0
        public void Get(){} // RVA: 0x7229890
        public void IsNull(){} // RVA: 0x7229910
        public void Set(){} // RVA: 0x7229990
        public void SetCapacity(){} // RVA: 0x72299D0
        public void ConvertXmlToObject(){} // RVA: 0x7229AE0
        public void ConvertObjectToXml(){} // RVA: 0x7229CE0
        public void GetEmptyStorage(){} // RVA: 0x7229EA0
        public void CopyValue(){} // RVA: 0x7229EE0
        public void SetStorage(){} // RVA: 0x722A000
    }

    public class SqlInt16Storage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x722A0F0
        public void Aggregate(){} // RVA: 0x722A250
        public void Compare(){} // RVA: 0x722B4E0
        public void CompareValueTo(){} // RVA: 0x722B580
        public void ConvertValue(){} // RVA: 0x722B630
        public void Copy(){} // RVA: 0x722B6A0
        public void Get(){} // RVA: 0x722B6E0
        public void IsNull(){} // RVA: 0x722B750
        public void Set(){} // RVA: 0x722B7D0
        public void SetCapacity(){} // RVA: 0x722B810
        public void ConvertXmlToObject(){} // RVA: 0x722B920
        public void ConvertObjectToXml(){} // RVA: 0x722BB20
        public void GetEmptyStorage(){} // RVA: 0x722BCE0
        public void CopyValue(){} // RVA: 0x722BD20
        public void SetStorage(){} // RVA: 0x722BE30
    }

    public class SqlInt32Storage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x722BF20
        public void Aggregate(){} // RVA: 0x722C080
        public void Compare(){} // RVA: 0x722D310
        public void CompareValueTo(){} // RVA: 0x722D3B0
        public void ConvertValue(){} // RVA: 0x722D460
        public void Copy(){} // RVA: 0x722D4D0
        public void Get(){} // RVA: 0x722D510
        public void IsNull(){} // RVA: 0x722D590
        public void Set(){} // RVA: 0x722D610
        public void SetCapacity(){} // RVA: 0x722D660
        public void ConvertXmlToObject(){} // RVA: 0x722D770
        public void ConvertObjectToXml(){} // RVA: 0x722D970
        public void GetEmptyStorage(){} // RVA: 0x722DB30
        public void CopyValue(){} // RVA: 0x722DB70
        public void SetStorage(){} // RVA: 0x722DC80
    }

    public class SqlInt64Storage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x722DD70
        public void Aggregate(){} // RVA: 0x722DEE0
        public void Compare(){} // RVA: 0x722F1B0
        public void CompareValueTo(){} // RVA: 0x722F270
        public void ConvertValue(){} // RVA: 0x722F330
        public void Copy(){} // RVA: 0x7228AC0
        public void Get(){} // RVA: 0x722F3B0
        public void IsNull(){} // RVA: 0x722F430
        public void Set(){} // RVA: 0x722F4B0
        public void SetCapacity(){} // RVA: 0x722F510
        public void ConvertXmlToObject(){} // RVA: 0x722F620
        public void ConvertObjectToXml(){} // RVA: 0x722F830
        public void GetEmptyStorage(){} // RVA: 0x722F9F0
        public void CopyValue(){} // RVA: 0x722FA30
        public void SetStorage(){} // RVA: 0x722FB60
    }

    public class SqlMoneyStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x722FC50
        public void Aggregate(){} // RVA: 0x722FDC0
        public void Compare(){} // RVA: 0x72310E0
        public void CompareValueTo(){} // RVA: 0x72311A0
        public void ConvertValue(){} // RVA: 0x7231260
        public void Copy(){} // RVA: 0x7228AC0
        public void Get(){} // RVA: 0x72312E0
        public void IsNull(){} // RVA: 0x7231360
        public void Set(){} // RVA: 0x72313E0
        public void SetCapacity(){} // RVA: 0x7231440
        public void ConvertXmlToObject(){} // RVA: 0x7231550
        public void ConvertObjectToXml(){} // RVA: 0x7231760
        public void GetEmptyStorage(){} // RVA: 0x7231920
        public void CopyValue(){} // RVA: 0x7231960
        public void SetStorage(){} // RVA: 0x7231A90
    }

    public class SqlSingleStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7231B80
        public void Aggregate(){} // RVA: 0x7231CE0
        public void Compare(){} // RVA: 0x7233010
        public void CompareValueTo(){} // RVA: 0x72330B0
        public void ConvertValue(){} // RVA: 0x7233160
        public void Copy(){} // RVA: 0x722D4D0
        public void Get(){} // RVA: 0x72331D0
        public void IsNull(){} // RVA: 0x7233250
        public void Set(){} // RVA: 0x72332D0
        public void SetCapacity(){} // RVA: 0x7233320
        public void ConvertXmlToObject(){} // RVA: 0x7233430
        public void ConvertObjectToXml(){} // RVA: 0x7233630
        public void GetEmptyStorage(){} // RVA: 0x72337F0
        public void CopyValue(){} // RVA: 0x7233830
        public void SetStorage(){} // RVA: 0x7233940
    }

    public class SqlStringStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7233A30
        public void Aggregate(){} // RVA: 0x7233BB0
        public void Compare(){} // RVA: 0x7233F60
        public void CompareValueTo(){} // RVA: 0x72340B0
        public void ConvertValue(){} // RVA: 0x7234180
        public void Copy(){} // RVA: 0x7234210
        public void Get(){} // RVA: 0x72342D0
        public void GetStringLength(){} // RVA: 0x7234360
        public void IsNull(){} // RVA: 0x7234470
        public void Set(){} // RVA: 0x72344F0
        public void SetCapacity(){} // RVA: 0x72345A0
        public void ConvertXmlToObject(){} // RVA: 0x72346B0
        public void ConvertObjectToXml(){} // RVA: 0x72348B0
        public void GetEmptyStorage(){} // RVA: 0x7234A70
        public void CopyValue(){} // RVA: 0x7234AB0
        public void SetStorage(){} // RVA: 0x7234C50
    }

    public class SqlUdtStorage : DataStorage
    {
        public object _values;
        public object _implementsIXmlSerializable;
        public object _implementsIComparable;
        public object s_typeToNull;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7236F40
        public void GetStaticNullForUdtType(){} // RVA: 0x7237150
        public void IsNull(){} // RVA: 0x72372C0
        public void Aggregate(){} // RVA: 0x7237380
        public void Compare(){} // RVA: 0x72373C0
        public void CompareValueTo(){} // RVA: 0x7237400
        public void Copy(){} // RVA: 0x7237610
        public void Get(){} // RVA: 0x7222C00
        public void Set(){} // RVA: 0x72376C0
        public void SetCapacity(){} // RVA: 0x72378C0
        public void ConvertXmlToObject(){} // RVA: 0x7237C50
        public void ConvertObjectToXml(){} // RVA: 0x72380F0
        public void GetEmptyStorage(){} // RVA: 0x7238210
        public void CopyValue(){} // RVA: 0x7238250
        public void SetStorage(){} // RVA: 0x72383C0
        public void .cctor(){} // RVA: 0x72384B0
    }

    public class StringStorage : DataStorage
    {
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7238710
        public void Aggregate(){} // RVA: 0x7238800
        public void Compare(){} // RVA: 0x7238AB0
        public void CompareValueTo(){} // RVA: 0x7238B40
        public void ConvertValue(){} // RVA: 0x7238BE0
        public void Copy(){} // RVA: 0x72201D0
        public void Get(){} // RVA: 0x71FE410
        public void GetStringLength(){} // RVA: 0x7238C10
        public void IsNull(){} // RVA: 0x71FE5E0
        public void Set(){} // RVA: 0x7238C50
        public void SetCapacity(){} // RVA: 0x7238CD0
        public void ConvertXmlToObject(){} // RVA: 0x1CB3B00
        public void ConvertObjectToXml(){} // RVA: 0x7238DE0
        public void GetEmptyStorage(){} // RVA: 0x7238E10
        public void CopyValue(){} // RVA: 0x7238E50
        public void SetStorage(){} // RVA: 0x7238F70
    }

    public class TimeSpanStorage : DataStorage
    {
        public object s_defaultValue;
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7239060
        public void Aggregate(){} // RVA: 0x72391B0
        public void Compare(){} // RVA: 0x7239F20
        public void CompareValueTo(){} // RVA: 0x723A090
        public void ConvertToTimeSpan(){} // RVA: 0x723A220
        public void ConvertValue(){} // RVA: 0x723A4B0
        public void Copy(){} // RVA: 0x720F000
        public void Get(){} // RVA: 0x723A560
        public void Set(){} // RVA: 0x723A680
        public void SetCapacity(){} // RVA: 0x723A780
        public void ConvertXmlToObject(){} // RVA: 0x723A8A0
        public void ConvertObjectToXml(){} // RVA: 0x723A920
        public void GetEmptyStorage(){} // RVA: 0x723AA00
        public void CopyValue(){} // RVA: 0x723AA40
        public void SetStorage(){} // RVA: 0x723AB50
        public void .cctor(){} // RVA: 0x723ACB0
    }

    public class UInt16Storage : DataStorage
    {
        public object s_defaultValue;
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x723AD30
        public void Aggregate(){} // RVA: 0x723AE50
        public void Compare(){} // RVA: 0x723B630
        public void CompareValueTo(){} // RVA: 0x723B6F0
        public void ConvertValue(){} // RVA: 0x723B7F0
        public void Copy(){} // RVA: 0x7207750
        public void Get(){} // RVA: 0x723B8F0
        public void Set(){} // RVA: 0x723B9B0
        public void SetCapacity(){} // RVA: 0x723BB10
        public void ConvertXmlToObject(){} // RVA: 0x723BC30
        public void ConvertObjectToXml(){} // RVA: 0x723BD20
        public void GetEmptyStorage(){} // RVA: 0x723BDA0
        public void CopyValue(){} // RVA: 0x723BDE0
        public void SetStorage(){} // RVA: 0x723BEF0
    }

    public class UInt32Storage : DataStorage
    {
        public object s_defaultValue;
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x723C050
        public void Aggregate(){} // RVA: 0x723C160
        public void Compare(){} // RVA: 0x723C920
        public void CompareValueTo(){} // RVA: 0x723C9F0
        public void ConvertValue(){} // RVA: 0x723CB00
        public void Copy(){} // RVA: 0x7214A40
        public void Get(){} // RVA: 0x723CBF0
        public void Set(){} // RVA: 0x723CCB0
        public void SetCapacity(){} // RVA: 0x723CE10
        public void ConvertXmlToObject(){} // RVA: 0x723CF30
        public void ConvertObjectToXml(){} // RVA: 0x723CFB0
        public void GetEmptyStorage(){} // RVA: 0x723D030
        public void CopyValue(){} // RVA: 0x723D070
        public void SetStorage(){} // RVA: 0x723D180
    }

    public class UInt64Storage : DataStorage
    {
        public object s_defaultValue;
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x723D2E0
        public void Aggregate(){} // RVA: 0x723D400
        public void Compare(){} // RVA: 0x723DD70
        public void CompareValueTo(){} // RVA: 0x723DE40
        public void ConvertValue(){} // RVA: 0x723DF50
        public void Copy(){} // RVA: 0x7215E10
        public void Get(){} // RVA: 0x723E050
        public void Set(){} // RVA: 0x723E110
        public void SetCapacity(){} // RVA: 0x723E270
        public void ConvertXmlToObject(){} // RVA: 0x723E390
        public void ConvertObjectToXml(){} // RVA: 0x723E410
        public void GetEmptyStorage(){} // RVA: 0x723E490
        public void CopyValue(){} // RVA: 0x723E4D0
        public void SetStorage(){} // RVA: 0x723E5E0
    }

}