// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization.Converters
// Classes: 85
// Methods: 436

namespace ThirdParty.DotNet.System.Text.Json.Serialization.Converters
{
    public class ArrayConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFE80E2F150
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void ConvertCollection(){} // RVA: 0x7FFE80E4F230
        public void OnWriteResume(){} // RVA: 0x7FFE80E32AD0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class BooleanConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA5170
        public void Write(){} // RVA: 0x7FFE86EA5180
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA51B0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA52E0
        public void .ctor(){} // RVA: 0x7FFE86EA5310
    }

    public class ByteArrayConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA5350
        public void Write(){} // RVA: 0x7FFE86EA53C0
        public void .ctor(){} // RVA: 0x7FFE86EA5550
    }

    public class ByteConverter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EA5590
        public void Read(){} // RVA: 0x7FFE86EA55E0
        public void Write(){} // RVA: 0x7FFE86EA5640
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA56A0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA56B0
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE86EA56E0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE86EA5760
    }

    public class CastingConverter`1 : JsonConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter _sourceConverter;
        public bool _handleNull;
        public object 0; // 0x2C8
        public object 0; // 0x2C9
        public object 0; // 0x2CA

        // ── Methods ──
        public void get_KeyType(){} // RVA: 0x7FFE80E2E2E0
        public void get_ElementType(){} // RVA: 0x7FFE80E2E2E0
        public void get_HandleNull(){} // RVA: 0x7FFE80E2F150
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_SourceConverterForCastingConverter(){} // RVA: 0x7FFE80E2E2E0
        public void Read(){} // RVA: 0x7FFE810A1420
        public void Write(){} // RVA: 0x7FFE810A1420
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFE810A1420
        public void ReadAsPropertyName(){} // RVA: 0x7FFE810A1420
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE810A1420
        public void WriteAsPropertyName(){} // RVA: 0x7FFE810A1420
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE810A1420
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE810A1420
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE810A1420
    }

    public class CharConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA57E0
        public void Write(){} // RVA: 0x7FFE86EA5850
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA5970
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA5990
        public void .ctor(){} // RVA: 0x7FFE86EA5AB0
    }

    public class ConcurrentQueueOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ConcurrentStackOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class DateTimeConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA5AF0
        public void Write(){} // RVA: 0x7FFE86EA5B00
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA5B60
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA5BC0
        public void .ctor(){} // RVA: 0x7FFE86EA5BF0
    }

    public class DateTimeOffsetConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA5C30
        public void Write(){} // RVA: 0x7FFE86EA5CD0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA5D40
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA5DA0
        public void .ctor(){} // RVA: 0x7FFE86EA5DD0
    }

    public class DecimalConverter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EA5E10
        public void Read(){} // RVA: 0x7FFE86EA5E60
        public void Write(){} // RVA: 0x7FFE86EA5EC0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA5EF0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA6010
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE86EA6040
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE86EA61C0
    }

    public class DefaultObjectConverter : ObjectConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87421030
        public void Read(){} // RVA: 0x7FFE87421080
        public void OnTryRead(){} // RVA: 0x7FFE87421150
    }

    public class DictionaryDefaultConverter`3 : JsonDictionaryConverter`3
    {
        // ── Methods ──
        public void get_CanHaveMetadata(){} // RVA: 0x7FFE811E0850
        public void OnWriteResume(){} // RVA: 0x7FFE838871F0
        public void .ctor(){} // RVA: 0x7FFE838871D0
    }

    public class DictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter`3
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE810A1420
        public void CreateCollection(){} // RVA: 0x7FFE80E4F230
        public void OnWriteResume(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class DoubleConverter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EA6210
        public void Read(){} // RVA: 0x7FFE86EA6260
        public void Write(){} // RVA: 0x7FFE86EA62C0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA62F0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA6300
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE86EA6330
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE86EA63C0
    }

    public class EnumConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CanConvert(){} // RVA: 0x7FFE83B45CC0
        public void CreateConverter(){} // RVA: 0x7FFE86EA6410
        public void Create(){} // RVA: 0x7FFE86EA6420
        public void GetEnumConverterType(){} // RVA: 0x7FFE86EA66F0
    }

    public class EnumConverter`1 : JsonConverter`1
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFE80E2F3B0
        public void .ctor(){} // RVA: 0x7FFE80E48FD0 | overloaded x2
        public void Read(){} // RVA: 0x7FFE810A1420
        public void Write(){} // RVA: 0x7FFE810A1420
        public void ConvertToUInt64(){} // RVA: 0x7FFE80E2E3D0
        public void IsValidIdentifier(){} // RVA: 0x7FFE80E2F230
        public void FormatEnumValue(){} // RVA: 0x7FFE810A1420
        public void FormatEnumValueToString(){} // RVA: 0x7FFE80E3FC10
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE810A1420
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class FSharpListConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void ConvertCollection(){} // RVA: 0x7FFE80E4F230
    }

    public class FSharpMapConverter`3 : DictionaryDefaultConverter`3
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<System.Tuple`2<V,T>>,U> _mapConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFE80E2F150
        public void CreateCollection(){} // RVA: 0x7FFE80E4F230
        public void ConvertCollection(){} // RVA: 0x7FFE80E4F230
    }

    public class FSharpOptionConverter`2 : JsonConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<U> _elementConverter;
        public System.Func`2<U,U> _optionValueGetter;
        public System.Func`2<U,U> _optionConstructor;

        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0x7FFE80E2F150
        public void get_ElementType(){} // RVA: 0x7FFE80E2E2E0
        public void get_HandleNull(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFE810A1420
        public void Write(){} // RVA: 0x7FFE810A1420
        public void Read(){} // RVA: 0x7FFE810A1420
    }

    public class FSharpSetConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void ConvertCollection(){} // RVA: 0x7FFE80E4F230
    }

    public class FSharpTypeConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CanConvert(){} // RVA: 0x7FFE86EA2AE0
        public void CreateConverter(){} // RVA: 0x7FFE86EA2C10
    }

    public class FSharpValueOptionConverter`2 : JsonConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<T> _elementConverter;
        public StructGetter`2<U,T> _optionValueGetter;
        public System.Func`2<T,U> _optionConstructor;

        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0x7FFE80E2F150
        public void get_ElementType(){} // RVA: 0x7FFE80E2E2E0
        public void get_HandleNull(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFE810A1420
        public void Write(){} // RVA: 0x7FFE810A1420
        public void Read(){} // RVA: 0x7FFE810A1420
    }

    public class GuidConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA6840
        public void Write(){} // RVA: 0x7FFE86EA68E0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA6950
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA69B0
        public void .ctor(){} // RVA: 0x7FFE86EA69E0
    }

    public class IAsyncEnumerableOfTConverter`2 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void OnTryRead(){}
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void OnTryWrite(){} // RVA: 0x7FFE810A1420
        public void OnWriteResume(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ICollectionOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFE80E2F150
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class IDictionaryConverter`1 : JsonDictionaryConverter`3
    {
        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFE80E2F150
        public void Add(){} // RVA: 0x7FFE80E50FC0
        public void CreateCollection(){} // RVA: 0x7FFE80E4F230
        public void OnWriteResume(){} // RVA: 0x7FFE810A1420
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class IDictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter`3
    {
        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFE80E2F150
        public void Add(){} // RVA: 0x7FFE810A1420
        public void CreateCollection(){} // RVA: 0x7FFE80E4F230
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class IEnumerableConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CanConvert(){} // RVA: 0x7FFE86EA1820
        public void CreateConverter(){} // RVA: 0x7FFE86EA1900
        public void .cctor(){} // RVA: 0x7FFE86EA27F0
    }

    public class IEnumerableConverter`1 : JsonCollectionConverter`2
    {
        public bool _isDeserializable;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void OnWriteResume(){} // RVA: 0x7FFE810A1420
        public void get_RuntimeType(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class IEnumerableDefaultConverter`2 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void get_CanHaveMetadata(){} // RVA: 0x7FFE811E0850
        public void OnWriteResume(){} // RVA: 0x7FFE8418D530
        public void .ctor(){} // RVA: 0x7FFE83630CB0
    }

    public class IEnumerableOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        public bool _isDeserializable;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void get_RuntimeType(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class IListConverter`1 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFE80E2F150
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void OnWriteResume(){} // RVA: 0x7FFE810A1420
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class IListOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFE80E2F150
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class IReadOnlyDictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter`3
    {
        public bool _isDeserializable;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE810A1420
        public void CreateCollection(){} // RVA: 0x7FFE80E4F230
        public void get_RuntimeType(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ISetOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFE80E2F150
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ImmutableDictionaryOfTKeyTValueConverterWithReflection`3 : ImmutableDictionaryOfTKeyTValueConverter`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x7FFE80E2F150
        public void Initialize(){} // RVA: 0x7FFE80E4F230
    }

    public class ImmutableDictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter`3
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE84195C50
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFE810FB320
        public void CreateCollection(){} // RVA: 0x7FFE841C8230
        public void ConvertCollection(){} // RVA: 0x7FFE841C82F0
        public void .ctor(){} // RVA: 0x7FFE8417F9C0
    }

    public class ImmutableEnumerableOfTConverterWithReflection`2 : ImmutableEnumerableOfTConverter`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x7FFE80E2F150
        public void Initialize(){} // RVA: 0x7FFE80E4F230
    }

    public class ImmutableEnumerableOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFE80E2F150
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void ConvertCollection(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class Int16Converter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EA6A20
        public void Read(){} // RVA: 0x7FFE86EA6A70
        public void Write(){} // RVA: 0x7FFE86EA6AD0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA6B30
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA6B40
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE86EA6B70
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE86EA6BF0
    }

    public class Int32Converter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EA6C70
        public void Read(){} // RVA: 0x7FFE86EA6CC0
        public void Write(){} // RVA: 0x7FFE86EA6D20
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA6D80
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA6D90
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE86EA6DC0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE86EA6E40
    }

    public class Int64Converter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EA6EC0
        public void Read(){} // RVA: 0x7FFE86EA6F10
        public void Write(){} // RVA: 0x7FFE86EA6F70
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA6FD0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA6FE0
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE86EA7010
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE86EA7090
    }

    public class JsonArrayConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFE86EA3540
        public void Read(){} // RVA: 0x7FFE86EA3580
        public void ReadList(){} // RVA: 0x7FFE86EA3680
        public void .ctor(){} // RVA: 0x7FFE86EA3710
    }

    public class JsonDocumentConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA7110
        public void Write(){} // RVA: 0x7FFE86EA7150
        public void .ctor(){} // RVA: 0x7FFE86EA7270
    }

    public class JsonElementConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA72B0
        public void Write(){} // RVA: 0x7FFE86EA72E0
        public void .ctor(){} // RVA: 0x7FFE86EA7390
    }

    public class JsonMetadataServicesConverter`1 : JsonResumableConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<T>> _converterCreator;
        public 0x6661739C _converterStrategy;
        public System.Text.Json.Serialization.JsonConverter`1<T> _converter;
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<UIntPtr>> _converterCreator; // 0x30
        public 0x6661739C _converterStrategy; // 0x38

        // ── Methods ──
        public void get_Converter(){} // RVA: 0x7FFE80E2E2E0
        public void get_ConverterStrategy(){} // RVA: 0x7FFE80E2F150
        public void get_KeyType(){} // RVA: 0x7FFE80E2E2E0
        public void get_ElementType(){} // RVA: 0x7FFE80E2E2E0
        public void get_ConstructorIsParameterized(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE80E4BC00
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFE810A1420
    }

    public class JsonNodeConverter : JsonConverter`1
    {
        public System.Text.Json.Serialization.Converters.JsonNodeConverter s_nodeConverter;
        public System.Text.Json.Serialization.Converters.JsonArrayConverter s_arrayConverter; // 0x8
        public System.Text.Json.Serialization.Converters.JsonObjectConverter s_objectConverter; // 0x10
        public System.Text.Json.Serialization.Converters.JsonValueConverter s_valueConverter; // 0x18

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE86EA3750
        public void get_ArrayConverter(){} // RVA: 0x7FFE86EA3840
        public void get_ObjectConverter(){} // RVA: 0x7FFE86EA3950
        public void get_ValueConverter(){} // RVA: 0x7FFE86EA3A60
        public void Write(){} // RVA: 0x7FFE86EA3B70
        public void Read(){} // RVA: 0x7FFE86EA3D00
        public void Create(){} // RVA: 0x7FFE86EA3E00
        public void .ctor(){} // RVA: 0x7FFE86EA3F70
    }

    public class JsonNodeConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void CreateConverter(){} // RVA: 0x7FFE86EA3FB0
        public void CanConvert(){} // RVA: 0x7FFE86EA4150
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonObjectConverter : JsonConverter`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFE86EA4250
        public void ReadElementAndSetProperty(){} // RVA: 0x7FFE86EA42D0
        public void Write(){} // RVA: 0x7FFE86EA3540
        public void Read(){} // RVA: 0x7FFE86EA45C0
        public void ReadObject(){} // RVA: 0x7FFE86EA46C0
        public void .ctor(){} // RVA: 0x7FFE86EA4750
    }

    public class JsonPrimitiveConverter`1 : JsonConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x7FFE84333CA0
        public void ReadAsPropertyName(){} // RVA: 0x7FFE81081080
        public void .ctor(){} // RVA: 0x7FFE83B95CC0
    }

    public class JsonValueConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFE86EA3540
        public void Read(){} // RVA: 0x7FFE86EA4790
        public void .ctor(){} // RVA: 0x7FFE86EA4860
    }

    public class KeyValuePairConverter`2 : SmallObjectWithParameterizedConstructorConverter`5
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE80E4F230
        public void TryLookupConstructorParameter(){} // RVA: 0x7FFE80E32AD0
        public void EndRead(){} // RVA: 0x7FFE80E460A0
        public void FoundKeyProperty(){}
        public void FoundValueProperty(){}
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class LargeJsonObjectExtensionDataSerializationState : Object
    {
        public System.Collections.Generic.Dictionary`2<string,System.Text.Json.Nodes.JsonNode> _tempDictionary; // 0x10

        // ── Methods ──
        public void get_Destination(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE86EA13C0
        public void AddProperty(){} // RVA: 0x7FFE86EA15C0
        public void Complete(){} // RVA: 0x7FFE86EA1650
    }

    public class LargeObjectWithParameterizedConstructorConverterWithReflection`1 : LargeObjectWithParameterizedConstructorConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x7FFE80E2F150
        public void Initialize(){} // RVA: 0x7FFE80E4F230
    }

    public class LargeObjectWithParameterizedConstructorConverter`1 : ObjectWithParameterizedConstructorConverter`1
    {
        // ── Methods ──
        public void ReadAndCacheConstructorArgument(){} // RVA: 0x7FFE84467D90
        public void CreateObject(){} // RVA: 0x7FFE84467F90
        public void InitializeConstructorArgumentCaches(){} // RVA: 0x7FFE844681E0
        public void .ctor(){} // RVA: 0x7FFE84468470
    }

    public class ListOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void OnWriteResume(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class MemoryByteConverter : JsonConverter`1
    {
        // ── Methods ──
        public void get_HandleNull(){} // RVA: 0x7FFE811E0850
        public void Read(){} // RVA: 0x7FFE8741D960
        public void Write(){} // RVA: 0x7FFE8741DA80
        public void .ctor(){} // RVA: 0x7FFE8741DB80
    }

    public class MemoryConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFE8741D3B0
        public void CreateConverter(){} // RVA: 0x7FFE8741D4E0
        public void .ctor(){} // RVA: 0x7FFE8432FD00
    }

    public class MemoryConverter`1 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void get_CanHaveMetadata(){} // RVA: 0x7FFE80E2F150
        public void get_HandleNull(){} // RVA: 0x7FFE80E2F150
        public void OnTryRead(){}
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void ConvertCollection(){} // RVA: 0x7FFE80E4F230
        public void OnWriteResume(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class NullableConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFE86EA73D0
        public void CreateConverter(){} // RVA: 0x7FFE86EA7420
        public void CreateValueConverter(){} // RVA: 0x7FFE86EA7510
        public void GetNullableConverterType(){} // RVA: 0x7FFE86EA7770
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NullableConverter`1 : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Read(){} // RVA: 0x7FFE810A1420
        public void Write(){} // RVA: 0x7FFE810A1420
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE810A1420
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE810A1420
    }

    public class ObjectConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA78C0
        public void Write(){} // RVA: 0x7FFE86EA7990
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA79D0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA7A00
        public void .ctor(){} // RVA: 0x7FFE86EA7AC0
    }

    public class ObjectConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81C15740
        public void CanConvert(){} // RVA: 0x7FFE811E0850
        public void CreateConverter(){} // RVA: 0x7FFE86EA48A0
        public void CreateKeyValuePairConverter(){} // RVA: 0x7FFE86EA4EC0
    }

    public class ObjectDefaultConverter`1 : JsonObjectConverter`1
    {
        // ── Methods ──
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFE811E0850
        public void OnTryRead(){} // RVA: 0x7FFE84997780
        public void OnTryWrite(){} // RVA: 0x7FFE84997F70
        public void ReadPropertyValue(){} // RVA: 0x7FFE84998650
        public void ReadAheadPropertyValue(){} // RVA: 0x7FFE84998760
        public void CreateInstanceForReferenceResolver(){} // RVA: 0x7FFE84998840
        public void .ctor(){} // RVA: 0x7FFE84186150
    }

    public class ObjectWithParameterizedConstructorConverter`1 : ObjectDefaultConverter`1
    {
        // ── Methods ──
        public void get_ConstructorIsParameterized(){} // RVA: 0x7FFE811E0850
        public void OnTryRead(){} // RVA: 0x7FFE84A04970
        public void InitializeConstructorArgumentCaches(){} // RVA: 0x7FFE80E4F230
        public void ReadAndCacheConstructorArgument(){}
        public void CreateObject(){} // RVA: 0x7FFE80E2E390
        public void ReadConstructorArguments(){} // RVA: 0x7FFE84A054F0
        public void ReadConstructorArgumentsWithContinuation(){} // RVA: 0x7FFE84A05C20
        public void HandleConstructorArgumentWithContinuation(){} // RVA: 0x7FFE84A05E80
        public void HandlePropertyWithContinuation(){} // RVA: 0x7FFE84A05F90
        public void BeginRead(){} // RVA: 0x7FFE84A06300
        public void EndRead(){} // RVA: 0x7FFE810FB310
        public void TryLookupConstructorParameter(){} // RVA: 0x7FFE84A06450
        public void .ctor(){} // RVA: 0x7FFE8429CB30
    }

    public class QueueOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ReadOnlyMemoryByteConverter : JsonConverter`1
    {
        // ── Methods ──
        public void get_HandleNull(){} // RVA: 0x7FFE811E0850
        public void Read(){} // RVA: 0x7FFE8741D760
        public void Write(){} // RVA: 0x7FFE8741D880
        public void .ctor(){} // RVA: 0x7FFE8741D920
    }

    public class ReadOnlyMemoryConverter`1 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void get_CanHaveMetadata(){} // RVA: 0x7FFE80E2F150
        public void get_HandleNull(){} // RVA: 0x7FFE80E2F150
        public void OnTryRead(){}
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void ConvertCollection(){} // RVA: 0x7FFE80E4F230
        public void OnWriteResume(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class SByteConverter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EA7B00
        public void Read(){} // RVA: 0x7FFE86EA7B50
        public void Write(){} // RVA: 0x7FFE86EA7BB0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA7C10
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA7C20
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE86EA7C50
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE86EA7CD0
    }

    public class SingleConverter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EA7D50
        public void Read(){} // RVA: 0x7FFE86EA7DA0
        public void Write(){} // RVA: 0x7FFE86EA7E00
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA7E30
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA7E40
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE86EA7E70
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE86EA7F00
    }

    public class SlimObjectConverter : ObjectConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87420F70
        public void Read(){} // RVA: 0x7FFE87421010
    }

    public class SmallObjectWithParameterizedConstructorConverter`5 : ObjectWithParameterizedConstructorConverter`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFE84C99F60
        public void ReadAndCacheConstructorArgument(){} // RVA: 0x7FFE84C9A350
        public void TryRead(){} // RVA: 0x7FFE80E32AD0
        public void InitializeConstructorArgumentCaches(){} // RVA: 0x7FFE84C9A590
        public void .ctor(){} // RVA: 0x7FFE84327580
    }

    public class StackOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE80E50660
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class StackOrQueueConverterWithReflection`1 : StackOrQueueConverter`1
    {
        // ── Methods ──
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Initialize(){} // RVA: 0x7FFE80E4F230
    }

    public class StackOrQueueConverter`1 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE84CF93F0
        public void CreateCollection(){} // RVA: 0x7FFE84CF9630
        public void OnWriteResume(){} // RVA: 0x7FFE84CF96F0
        public void .ctor(){} // RVA: 0x7FFE84CF9AA0
    }

    public class StringConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA7F50
        public void Write(){} // RVA: 0x7FFE86EA7F60
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA7F50
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA8010
        public void .ctor(){} // RVA: 0x7FFE86EA8160
    }

    public class TimeSpanConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA81A0
        public void Write(){} // RVA: 0x7FFE86EA8A70
        public void .ctor(){} // RVA: 0x7FFE86EA8D30
    }

    public class UInt16Converter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EA8D70
        public void Read(){} // RVA: 0x7FFE86EA8DC0
        public void Write(){} // RVA: 0x7FFE86EA8E20
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA8E80
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA8E90
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE86EA8EC0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE86EA8F40
    }

    public class UInt32Converter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EA8FC0
        public void Read(){} // RVA: 0x7FFE86EA9010
        public void Write(){} // RVA: 0x7FFE86EA9070
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA90A0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA90B0
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE86EA90E0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE86EA9160
    }

    public class UInt64Converter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EA91A0
        public void Read(){} // RVA: 0x7FFE86EA91F0
        public void Write(){} // RVA: 0x7FFE86EA9250
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE86EA9280
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE86EA9290
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE86EA92C0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE86EA9340
    }

    public class UnsupportedTypeConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFE86EA9380
        public void CreateConverter(){} // RVA: 0x7FFE86EA9570
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnsupportedTypeConverter`1 : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE810A1420
        public void Write(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class UriConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA9750
        public void Write(){} // RVA: 0x7FFE86EA97D0
        public void .ctor(){} // RVA: 0x7FFE86EA98E0
    }

    public class VersionConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE86EA9920
        public void Write(){} // RVA: 0x7FFE86EA9A70
        public void .ctor(){} // RVA: 0x7FFE86EA9B40
    }

}